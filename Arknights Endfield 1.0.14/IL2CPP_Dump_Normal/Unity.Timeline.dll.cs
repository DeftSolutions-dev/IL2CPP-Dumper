// ========================================================
// Dumped by @desirepro
// Assembly: Unity.Timeline.dll
// Classes:  180
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x200001B
    public struct PostPlaybackState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Timeline.ActivationTrack.PostPlaybackState Active;        // 0x0
        public static UnityEngine.Timeline.ActivationTrack.PostPlaybackState Inactive;        // 0x0
        public static UnityEngine.Timeline.ActivationTrack.PostPlaybackState Revert;        // 0x0
        public static UnityEngine.Timeline.ActivationTrack.PostPlaybackState LeaveAsIs;        // 0x0

    }

    // TypeToken: 0x200001D
    public struct WeightInfo
    {
        // Fields
        public UnityEngine.Playables.Playable mixer;        // 0x10
        public UnityEngine.Playables.Playable parentMixer;        // 0x20
        public System.Int32 port;        // 0x30

    }

    // TypeToken: 0x200001F
    public struct LoopMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Timeline.AnimationPlayableAsset.LoopMode UseSourceAsset;        // 0x0
        public static UnityEngine.Timeline.AnimationPlayableAsset.LoopMode On;        // 0x0
        public static UnityEngine.Timeline.AnimationPlayableAsset.LoopMode Off;        // 0x0

    }

    // TypeToken: 0x2000020
    public struct ClothResetOption
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Timeline.AnimationPlayableAsset.ClothResetOption SoftReset;        // 0x0
        public static UnityEngine.Timeline.AnimationPlayableAsset.ClothResetOption UseClothRelativeTeleport;        // 0x0
        public static UnityEngine.Timeline.AnimationPlayableAsset.ClothResetOption UseStablizationTime;        // 0x0
        public static UnityEngine.Timeline.AnimationPlayableAsset.ClothResetOption DisablePhysics;        // 0x0

    }

    // TypeToken: 0x2000021
    public struct Versions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Timeline.AnimationPlayableAsset.Versions Initial;        // 0x0
        public static UnityEngine.Timeline.AnimationPlayableAsset.Versions RotationAsEuler;        // 0x0

    }

    // TypeToken: 0x2000022
    public class AnimationPlayableAssetUpgrade
    {
        // Methods
        private System.Void ConvertRotationToEuler(UnityEngine.Timeline.AnimationPlayableAsset asset) { }

    }

    // TypeToken: 0x200002A
    public class AnimationTrackUpgrade
    {
        // Methods
        private System.Void ConvertRotationsToEuler(UnityEngine.Timeline.AnimationTrack track) { }
        private System.Void ConvertRootMotion(UnityEngine.Timeline.AnimationTrack track) { }
        private System.Void ConvertInfiniteTrack(UnityEngine.Timeline.AnimationTrack track) { }

    }

    // TypeToken: 0x200002E
    public struct Versions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Timeline.TimelineClip.Versions Initial;        // 0x0
        public static UnityEngine.Timeline.TimelineClip.Versions ClipInFromGlobalToLocal;        // 0x0

    }

    // TypeToken: 0x200002F
    public class TimelineClipUpgrade
    {
        // Methods
        private System.Void UpgradeClipInFromGlobalToLocal(UnityEngine.Timeline.TimelineClip clip) { }

    }

    // TypeToken: 0x2000030
    public struct ClipExtrapolation
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Timeline.TimelineClip.ClipExtrapolation None;        // 0x0
        public static UnityEngine.Timeline.TimelineClip.ClipExtrapolation Hold;        // 0x0
        public static UnityEngine.Timeline.TimelineClip.ClipExtrapolation Loop;        // 0x0
        public static UnityEngine.Timeline.TimelineClip.ClipExtrapolation PingPong;        // 0x0
        public static UnityEngine.Timeline.TimelineClip.ClipExtrapolation Continue;        // 0x0

    }

    // TypeToken: 0x2000031
    public struct BlendCurveMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Timeline.TimelineClip.BlendCurveMode Auto;        // 0x0
        public static UnityEngine.Timeline.TimelineClip.BlendCurveMode Manual;        // 0x0

    }

    // TypeToken: 0x2000033
    public struct Versions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Timeline.TimelineAsset.Versions Initial;        // 0x0

    }

    // TypeToken: 0x2000034
    public class TimelineAssetUpgrade
    {
    }

    // TypeToken: 0x2000035
    public struct MediaType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Timeline.TimelineAsset.MediaType Animation;        // 0x0
        public static UnityEngine.Timeline.TimelineAsset.MediaType Audio;        // 0x0
        public static UnityEngine.Timeline.TimelineAsset.MediaType Texture;        // 0x0
        public static UnityEngine.Timeline.TimelineAsset.MediaType Video;        // 0x0
        public static UnityEngine.Timeline.TimelineAsset.MediaType Script;        // 0x0
        public static UnityEngine.Timeline.TimelineAsset.MediaType Hybrid;        // 0x0
        public static UnityEngine.Timeline.TimelineAsset.MediaType Group;        // 0x0

    }

    // TypeToken: 0x2000036
    public struct DurationMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Timeline.TimelineAsset.DurationMode BasedOnClips;        // 0x0
        public static UnityEngine.Timeline.TimelineAsset.DurationMode FixedLength;        // 0x0

    }

    // TypeToken: 0x2000037
    public class EditorSettings
    {
        // Fields
        private static readonly System.Double kMinFrameRate;        // 0x0
        private static readonly System.Double kMaxFrameRate;        // 0x8
        private static readonly System.Double kDefaultFrameRate;        // 0x10
        private System.Double m_Framerate;        // 0x10
        private System.Boolean m_ScenePreview;        // 0x18

        // Methods
        private System.Double get_frameRate() { }
        private System.Void set_frameRate(System.Double value) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200003A
    public struct Versions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Timeline.TrackAsset.Versions Initial;        // 0x0
        public static UnityEngine.Timeline.TrackAsset.Versions RotationAsEuler;        // 0x0
        public static UnityEngine.Timeline.TrackAsset.Versions RootMotionUpgrade;        // 0x0
        public static UnityEngine.Timeline.TrackAsset.Versions AnimatedTrackProperties;        // 0x0

    }

    // TypeToken: 0x200003B
    public class TrackAssetUpgrade
    {
    }

    // TypeToken: 0x200003C
    public struct TransientBuildData
    {
        // Fields
        public System.Collections.Generic.List<UnityEngine.Timeline.TrackAsset> trackList;        // 0x10
        public System.Collections.Generic.List<UnityEngine.Timeline.TimelineClip> clipList;        // 0x18
        public System.Collections.Generic.List<UnityEngine.Timeline.IMarker> markerList;        // 0x20

        // Methods
        private UnityEngine.Timeline.TrackAsset.TransientBuildData Create() { }
        private System.Void Clear() { }

    }

    // TypeToken: 0x200004C
    public struct DescriptorBlendTreeType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Timeline.BlendTreeDescriptor.DescriptorBlendTreeType Direct;        // 0x0
        public static UnityEngine.Timeline.BlendTreeDescriptor.DescriptorBlendTreeType Simple1D;        // 0x0
        public static UnityEngine.Timeline.BlendTreeDescriptor.DescriptorBlendTreeType Simple2D;        // 0x0
        public static UnityEngine.Timeline.BlendTreeDescriptor.DescriptorBlendTreeType Complex2D;        // 0x0

    }

    // TypeToken: 0x2000057
    public class TransformAdditive
    {
        // Fields
        public UnityEngine.Vector3 position;        // 0x10
        public UnityEngine.Vector3 rotationEuler;        // 0x1C
        public UnityEngine.Vector3 scale;        // 0x28

        // Methods
        private System.Void .ctor() { }
        private System.Void Reset() { }
        private System.Boolean HasChanges() { }

    }

    // TypeToken: 0x2000059
    public class TransformAdditive
    {
        // Fields
        public UnityEngine.Vector3 position;        // 0x10
        public UnityEngine.Vector3 rotationEular;        // 0x1C
        public UnityEngine.Vector3 scale;        // 0x28

        // Methods
        private System.Void Reset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005C
    public class AnimationCurveInfo
    {
        // Fields
        public System.String path;        // 0x10
        public System.String propertyName;        // 0x18
        public UnityEngine.AnimationCurve curve;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006A
    public struct Entry
    {
        // Fields
        public System.Int64 intervalStart;        // 0x0
        public System.Int64 intervalEnd;        // 0x0
        public T item;        // 0x0

    }

    // TypeToken: 0x2000078
    public class EventKeyValue
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.Timeline.SignalAsset> m_Signals;        // 0x10
        private System.Collections.Generic.List<UnityEngine.Events.UnityEvent> m_Events;        // 0x18

        // Methods
        private System.Boolean TryGetValue(UnityEngine.Timeline.SignalAsset key, UnityEngine.Events.UnityEvent& value) { }
        private System.Void Append(UnityEngine.Timeline.SignalAsset key, UnityEngine.Events.UnityEvent value) { }
        private System.Void Remove(System.Int32 idx) { }
        private System.Void Remove(UnityEngine.Timeline.SignalAsset key) { }
        private System.Collections.Generic.List<UnityEngine.Timeline.SignalAsset> get_signals() { }
        private System.Collections.Generic.List<UnityEngine.Events.UnityEvent> get_events() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007E
    public struct PostPlaybackState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState Active;        // 0x0
        public static UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState Inactive;        // 0x0
        public static UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState Revert;        // 0x0

    }

    // TypeToken: 0x200007F
    public struct InitialState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Timeline.ActivationControlPlayable.InitialState Unset;        // 0x0
        public static UnityEngine.Timeline.ActivationControlPlayable.InitialState Active;        // 0x0
        public static UnityEngine.Timeline.ActivationControlPlayable.InitialState Inactive;        // 0x0

    }

    // TypeToken: 0x2000089
    public struct NotificationEntry
    {
        // Fields
        public System.Double time;        // 0x10
        public UnityEngine.Playables.INotification payload;        // 0x18
        public System.Boolean notificationFired;        // 0x20
        public UnityEngine.Timeline.NotificationFlags flags;        // 0x22

        // Methods
        private System.Boolean get_triggerInEditor() { }
        private System.Boolean get_prewarm() { }
        private System.Boolean get_triggerOnce() { }

    }

    // TypeToken: 0x2000099
    public struct UseEditMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Timeline.TimeFieldAttribute.UseEditMode None;        // 0x0
        public static UnityEngine.Timeline.TimeFieldAttribute.UseEditMode ApplyEditMode;        // 0x0

    }

namespace Beyond.Gameplay.Core
{

    // TypeToken: 0x200000E
    public class DontAutoBindAttribute : DontAutoBindRuntimeAttribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000F
    public class DontAutoBindRuntimeAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000010
    public class RuntimeJumpBehaviour : PlayableBehaviour
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000011
    public class RuntimeJumpClip : PlayableAsset, ITimelineClipAsset
    {
        // Fields
        public System.Boolean isReverseJump;        // 0x18
        public System.Boolean needChangeOptionAfterJump;        // 0x19
        public System.Int32 optionIndexAfterJump;        // 0x1C
        public System.Double crossFadeDurationAfterJump;        // 0x20
        public System.Boolean isJumpFirst;        // 0x28

        // Methods
        private UnityEngine.Timeline.ClipCaps get_clipCaps() { }
        private UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000012
    public class RuntimeJumpTrack : TrackAsset
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000013
    public class RuntimeLoopBehaviour : PlayableBehaviour
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000014
    public class RuntimeLoopClip : PlayableAsset, ITimelineClipAsset
    {
        // Fields
        public System.Double crossFadeDuration;        // 0x18

        // Methods
        private UnityEngine.Timeline.ClipCaps get_clipCaps() { }
        private UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000015
    public class RuntimeLoopTrack : TrackAsset
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000016
    public class TimelineNPCLookAtController : MonoBehaviour
    {
        // Fields
        private static readonly System.Collections.Generic.HashSet<Beyond.Gameplay.Core.TimelineNPCLookAtController> s_instances;        // 0x0
        public System.Boolean m_lookAtDirty;        // 0x18
        public ScriptAnimation.TimelineNPCLookAtTarget lookAtTarget;        // 0x20
        public ScriptAnimation.TimelineNPCLookAtEyeTarget lookAtEyeTarget;        // 0x28
        public System.Boolean lookAtEnabled;        // 0x30
        public System.Boolean lookAtEyeEnabled;        // 0x31

        // Methods
        private System.Collections.Generic.IEnumerable<Beyond.Gameplay.Core.TimelineNPCLookAtController> get_Instances() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Boolean get_lookAtDirty() { }
        private System.Void set_lookAtDirty(System.Boolean value) { }
        private System.Single get_lookAtWeight() { }
        private System.Void set_lookAtWeight(System.Single value) { }
        private System.Single get_lookAtBodyWeight() { }
        private System.Void set_lookAtBodyWeight(System.Single value) { }
        private System.Single get_lookAtRoll() { }
        private System.Void set_lookAtRoll(System.Single value) { }
        private System.Single get_lookAtHorizontal() { }
        private System.Void set_lookAtHorizontal(System.Single value) { }
        private System.Single get_lookAtVertical() { }
        private System.Void set_lookAtVertical(System.Single value) { }
        private System.Single get_lookAtEyeWeight() { }
        private System.Void set_lookAtEyeWeight(System.Single value) { }
        private System.Boolean get_lookAtUseDegree() { }
        private System.Void set_lookAtUseDegree(System.Boolean value) { }
        private System.Boolean get_EyeUseDegree() { }
        private System.Void set_EyeUseDegree(System.Boolean value) { }
        private System.Single get_lookAtEyeUp() { }
        private System.Void set_lookAtEyeUp(System.Single value) { }
        private System.Single get_lookAtEyeDown() { }
        private System.Void set_lookAtEyeDown(System.Single value) { }
        private UnityEngine.Vector3 get_finalPosition() { }
        private System.Void set_finalPosition(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_finalEyePosition() { }
        private System.Void set_finalEyePosition(UnityEngine.Vector3 value) { }
        private System.Void MarkLookAtDirty() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

}

namespace Beyond.SourceGenerator
{

    // TypeToken: 0x200000A
    public class CameraControlConfigAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000B
    public class DataNAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000C
    public class ECSComponentAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000D
    public class AnimatorBlackboardAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace Events
{

    // TypeToken: 0x2000008
    public interface INotificationTrack
    {
    }

    // TypeToken: 0x2000009
    public interface ITimelineNotification
    {
        // Methods
        private System.Void OnNotify() { }

    }

}

namespace HG.Rendering.Runtime
{

    // TypeToken: 0x2000002
    public class HGConstantBufferLayoutAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace ScriptAnimation
{

    // TypeToken: 0x2000003
    public class TimelineNPCClothWeightController : MonoBehaviour
    {
        // Fields
        public System.Boolean forceSetPhysicsClothWeight;        // 0x18
        public System.Single physicsClothWeight;        // 0x1C
        public System.Boolean forceSetLoopBodyAddWeight;        // 0x20
        public System.Single loopBodyAddWeight;        // 0x24

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000004
    public class TimelineNPCLookAtEyeTarget : MonoBehaviour
    {
        // Fields
        public System.Single lookAtWeight;        // 0x18
        public System.Boolean useDegree;        // 0x1C
        public System.Single lookAtUp;        // 0x20
        public System.Single lookAtDown;        // 0x24

        // Methods
        private System.Void ResetLookAtWeight() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000005
    public class TimelineNPCLookAtTarget : MonoBehaviour
    {
        // Fields
        public System.Single lookAtWeight;        // 0x18
        public System.Single lookAtBodyWeight;        // 0x1C
        public System.Boolean useDegree;        // 0x20
        public System.Single lookAtHorizontal;        // 0x24
        public System.Single lookAtVertical;        // 0x28
        public System.Single lookAtRoll;        // 0x2C

        // Methods
        private System.Void ResetLookAtWeight() { }
        private System.Void .ctor() { }

    }

}

namespace ScriptAnimation.ScriptAnimationApply
{

    // TypeToken: 0x2000006
    public class ScriptAnimationApplyBehaviour : PlayableBehaviour
    {
        // Fields
        private UnityEngine.Timeline.IScriptAnimationJobSync m_JobSync;        // 0x10

        // Methods
        private System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void InitBehaviour(UnityEngine.Timeline.IScriptAnimationJobSync jobSync) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000007
    public class ScriptAnimationApplyPlayable : PlayableAsset
    {
        // Methods
        private UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner) { }
        private System.Void .ctor() { }

    }

}

namespace UnityEngine
{

    // TypeToken: 0x2000017
    public class PlayerLoopChecker
    {
    }

}

namespace UnityEngine.Timeline
{

    // TypeToken: 0x2000018
    public class ActivationMixerPlayable : PlayableBehaviour
    {
        // Fields
        private UnityEngine.Timeline.ActivationTrack.PostPlaybackState m_PostPlaybackState;        // 0x10
        private System.Boolean m_BoundGameObjectInitialStateIsActive;        // 0x14
        private UnityEngine.GameObject m_BoundGameObject;        // 0x18

        // Methods
        private UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.ActivationMixerPlayable> Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount) { }
        private System.Void set_postPlaybackState(UnityEngine.Timeline.ActivationTrack.PostPlaybackState value) { }
        private System.Void SetBoundGameObject(UnityEngine.GameObject go) { }
        private System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable) { }
        private System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData) { }
        private System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void _DoSetActive(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000019
    public class ActivationPlayableAsset : PlayableAsset, ITimelineClipAsset
    {
        // Methods
        private UnityEngine.Timeline.ClipCaps get_clipCaps() { }
        private UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001A
    public class ActivationTrack : TrackAsset
    {
        // Fields
        private UnityEngine.Timeline.ActivationTrack.PostPlaybackState m_PostPlaybackState;        // 0xC0
        private UnityEngine.Timeline.ActivationMixerPlayable m_ActivationMixer;        // 0xC8

        // Methods
        private System.Boolean CanCompileClips() { }
        private UnityEngine.Timeline.ActivationTrack.PostPlaybackState get_postPlaybackState() { }
        private System.Void set_postPlaybackState(UnityEngine.Timeline.ActivationTrack.PostPlaybackState value) { }
        private UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount) { }
        private UnityEngine.GameObject GetBinding(UnityEngine.Playables.PlayableDirector director) { }
        private System.Void UpdateTrackMode() { }
        private System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver) { }
        private System.Void OnCreateClip(UnityEngine.Timeline.TimelineClip clip) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001C
    public class AnimationOutputWeightProcessor, ITimelineEvaluateCallback
    {
        // Fields
        private UnityEngine.Animator m_outputAnimator;        // 0x10
        private UnityEngine.Animations.AnimationPlayableOutput m_Output;        // 0x18
        private readonly System.Collections.Generic.List<UnityEngine.Timeline.AnimationOutputWeightProcessor.WeightInfo> m_Mixers;        // 0x28

        // Methods
        private System.Void .ctor(UnityEngine.Animations.AnimationPlayableOutput output, UnityEngine.Animator animator) { }
        private System.Void FindMixers() { }
        private System.Void FindMixers(UnityEngine.Playables.Playable parent, System.Int32 port, UnityEngine.Playables.Playable node) { }
        private System.Void Evaluate() { }

    }

    // TypeToken: 0x200001E
    public class AnimationPlayableAsset : PlayableAsset, ITimelineClipAsset, IPropertyPreview, ISerializationCallbackReceiver
    {
        // Fields
        private UnityEngine.AnimationClip m_Clip;        // 0x18
        private UnityEngine.Vector3 m_Position;        // 0x20
        private UnityEngine.Vector3 m_EulerAngles;        // 0x2C
        private System.Boolean m_UseTrackMatchFields;        // 0x38
        private UnityEngine.Timeline.MatchTargetFields m_MatchTargetFields;        // 0x3C
        private System.Boolean m_RemoveStartOffset;        // 0x40
        private System.Boolean m_ApplyFootIK;        // 0x41
        private UnityEngine.Timeline.AnimationPlayableAsset.LoopMode m_Loop;        // 0x44
        private System.Boolean m_IgniteOnce;        // 0x48
        private System.Boolean m_OnlyDeltaTime;        // 0x49
        private System.Boolean m_DynamicLink;        // 0x4A
        private UnityEngine.Timeline.AnimationPlayableAsset.ClothResetOption m_ClothResetOption;        // 0x4C
        private UnityEngine.Timeline.AppliedOffsetMode <appliedOffsetMode>k__BackingField;        // 0x50
        private static readonly System.Int32 k_LatestVersion;        // 0x0
        private System.Int32 m_Version;        // 0x54
        private UnityEngine.Quaternion m_Rotation;        // 0x58

        // Methods
        private UnityEngine.Vector3 get_position() { }
        private System.Void set_position(UnityEngine.Vector3 value) { }
        private UnityEngine.Quaternion get_rotation() { }
        private System.Void set_rotation(UnityEngine.Quaternion value) { }
        private UnityEngine.Vector3 get_eulerAngles() { }
        private System.Void set_eulerAngles(UnityEngine.Vector3 value) { }
        private System.Boolean get_useTrackMatchFields() { }
        private System.Void set_useTrackMatchFields(System.Boolean value) { }
        private UnityEngine.Timeline.MatchTargetFields get_matchTargetFields() { }
        private System.Void set_matchTargetFields(UnityEngine.Timeline.MatchTargetFields value) { }
        private System.Boolean get_removeStartOffset() { }
        private System.Void set_removeStartOffset(System.Boolean value) { }
        private System.Boolean get_applyFootIK() { }
        private System.Void set_applyFootIK(System.Boolean value) { }
        private UnityEngine.Timeline.AnimationPlayableAsset.LoopMode get_loop() { }
        private System.Void set_loop(UnityEngine.Timeline.AnimationPlayableAsset.LoopMode value) { }
        private System.Boolean get_IgniteOnce() { }
        private System.Void set_IgniteOnce(System.Boolean value) { }
        private System.Boolean get_OnlyDeltaTime() { }
        private System.Void set_OnlyDeltaTime(System.Boolean value) { }
        private System.Boolean get_DynamicLink() { }
        private System.Void set_DynamicLink(System.Boolean value) { }
        private System.Boolean get_hasRootTransforms() { }
        private UnityEngine.Timeline.AppliedOffsetMode get_appliedOffsetMode() { }
        private System.Void set_appliedOffsetMode(UnityEngine.Timeline.AppliedOffsetMode value) { }
        private UnityEngine.AnimationClip get_clip() { }
        private System.Void set_clip(UnityEngine.AnimationClip value) { }
        private System.Double get_duration() { }
        private UnityEngine.Timeline.AnimationPlayableAsset.ClothResetOption get_clothResetOption() { }
        private System.Void set_clothResetOption(UnityEngine.Timeline.AnimationPlayableAsset.ClothResetOption value) { }
        private System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs() { }
        private UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go) { }
        private UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip, UnityEngine.Vector3 positionOffset, UnityEngine.Vector3 eulerOffset, System.Boolean removeStartOffset, UnityEngine.Timeline.AppliedOffsetMode mode, System.Boolean applyFootIK, UnityEngine.Timeline.AnimationPlayableAsset.LoopMode loop) { }
        private System.Boolean ShouldApplyOffset(UnityEngine.Timeline.AppliedOffsetMode mode, UnityEngine.AnimationClip clip) { }
        private System.Boolean ShouldApplyScaleRemove(UnityEngine.Timeline.AppliedOffsetMode mode) { }
        private UnityEngine.Timeline.ClipCaps get_clipCaps() { }
        private System.Void ResetOffsets() { }
        private System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver) { }
        private System.Boolean HasRootTransforms(UnityEngine.AnimationClip clip) { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        private System.Void OnUpgradeFromVersion(System.Int32 oldVersion) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000024
    public class AnimationPreviewUpdateCallback
    {
    }

    // TypeToken: 0x2000025
    public struct MatchTargetFields
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Timeline.MatchTargetFields PositionX;        // 0x0
        public static UnityEngine.Timeline.MatchTargetFields PositionY;        // 0x0
        public static UnityEngine.Timeline.MatchTargetFields PositionZ;        // 0x0
        public static UnityEngine.Timeline.MatchTargetFields RotationX;        // 0x0
        public static UnityEngine.Timeline.MatchTargetFields RotationY;        // 0x0
        public static UnityEngine.Timeline.MatchTargetFields RotationZ;        // 0x0

    }

    // TypeToken: 0x2000026
    public struct TrackOffset
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Timeline.TrackOffset ApplyTransformOffsets;        // 0x0
        public static UnityEngine.Timeline.TrackOffset ApplySceneOffsets;        // 0x0
        public static UnityEngine.Timeline.TrackOffset Auto;        // 0x0

    }

    // TypeToken: 0x2000027
    public struct AppliedOffsetMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Timeline.AppliedOffsetMode NoRootTransform;        // 0x0
        public static UnityEngine.Timeline.AppliedOffsetMode TransformOffset;        // 0x0
        public static UnityEngine.Timeline.AppliedOffsetMode SceneOffset;        // 0x0
        public static UnityEngine.Timeline.AppliedOffsetMode TransformOffsetLegacy;        // 0x0
        public static UnityEngine.Timeline.AppliedOffsetMode SceneOffsetLegacy;        // 0x0
        public static UnityEngine.Timeline.AppliedOffsetMode SceneOffsetEditor;        // 0x0
        public static UnityEngine.Timeline.AppliedOffsetMode SceneOffsetLegacyEditor;        // 0x0

    }

    // TypeToken: 0x2000028
    public class MatchTargetFieldConstants
    {
        // Fields
        public static UnityEngine.Timeline.MatchTargetFields All;        // 0x0
        public static UnityEngine.Timeline.MatchTargetFields None;        // 0x4
        public static UnityEngine.Timeline.MatchTargetFields Position;        // 0x8
        public static UnityEngine.Timeline.MatchTargetFields Rotation;        // 0xC

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000029
    public class AnimationTrack : TrackAsset, ILayerable
    {
        // Fields
        private static System.String k_DefaultInfiniteClipName;        // 0x0
        private static System.String k_DefaultRecordableClipName;        // 0x0
        private UnityEngine.Timeline.TimelineClip.ClipExtrapolation m_InfiniteClipPreExtrapolation;        // 0xC0
        private UnityEngine.Timeline.TimelineClip.ClipExtrapolation m_InfiniteClipPostExtrapolation;        // 0xC4
        private UnityEngine.Vector3 m_InfiniteClipOffsetPosition;        // 0xC8
        private UnityEngine.Vector3 m_InfiniteClipOffsetEulerAngles;        // 0xD4
        private System.Double m_InfiniteClipTimeOffset;        // 0xE0
        private System.Boolean m_InfiniteClipRemoveOffset;        // 0xE8
        private System.Boolean m_InfiniteClipApplyFootIK;        // 0xE9
        private UnityEngine.Timeline.AnimationPlayableAsset.LoopMode mInfiniteClipLoop;        // 0xEC
        private UnityEngine.Timeline.MatchTargetFields m_MatchTargetFields;        // 0xF0
        private UnityEngine.Vector3 m_Position;        // 0xF4
        private UnityEngine.Vector3 m_EulerAngles;        // 0x100
        private UnityEngine.AvatarMask m_AvatarMask;        // 0x110
        private System.Boolean m_ApplyAvatarMask;        // 0x118
        private UnityEngine.Timeline.TrackOffset m_TrackOffset;        // 0x11C
        private UnityEngine.AnimationClip m_InfiniteClip;        // 0x120
        private System.Boolean m_IsAdditive;        // 0x128
        private System.Boolean m_IsAdditiveToLast;        // 0x129
        public System.Boolean muteScriptAnimAddon;        // 0x12A
        private System.Boolean m_UseScriptAnimAddon;        // 0x12B
        private UnityEngine.ScriptableObject m_TimelineNPCDescriptor;        // 0x130
        private System.String m_LookAtTargetPath;        // 0x138
        private System.Boolean m_LookAtUseAdditive;        // 0x140
        private UnityEngine.Transform m_LookAtTarget;        // 0x148
        private System.Collections.Generic.HashSet<UnityEngine.Timeline.RuntimeElement> m_allRuntimeClipUnderTrack;        // 0x150
        private static readonly System.Collections.Generic.Queue<UnityEngine.Transform> s_CachedQueue;        // 0x0
        private UnityEngine.Quaternion m_OpenClipOffsetRotation;        // 0x158
        private UnityEngine.Quaternion m_Rotation;        // 0x168
        private System.Boolean m_ApplyOffsets;        // 0x178

        // Methods
        private UnityEngine.Vector3 get_position() { }
        private System.Void set_position(UnityEngine.Vector3 value) { }
        private UnityEngine.Quaternion get_rotation() { }
        private System.Void set_rotation(UnityEngine.Quaternion value) { }
        private UnityEngine.Vector3 get_eulerAngles() { }
        private System.Void set_eulerAngles(UnityEngine.Vector3 value) { }
        private System.Boolean get_applyOffsets() { }
        private System.Void set_applyOffsets(System.Boolean value) { }
        private UnityEngine.Timeline.TrackOffset get_trackOffset() { }
        private System.Void set_trackOffset(UnityEngine.Timeline.TrackOffset value) { }
        private UnityEngine.Timeline.MatchTargetFields get_matchTargetFields() { }
        private System.Void set_matchTargetFields(UnityEngine.Timeline.MatchTargetFields value) { }
        private UnityEngine.AnimationClip get_infiniteClip() { }
        private System.Void set_infiniteClip(UnityEngine.AnimationClip value) { }
        private System.Boolean get_infiniteClipRemoveOffset() { }
        private System.Void set_infiniteClipRemoveOffset(System.Boolean value) { }
        private UnityEngine.AvatarMask get_avatarMask() { }
        private System.Void set_avatarMask(UnityEngine.AvatarMask value) { }
        private System.Boolean get_applyAvatarMask() { }
        private System.Void set_applyAvatarMask(System.Boolean value) { }
        private System.Boolean get_isUsingScriptAnimAddon() { }
        private System.Void set_isUsingScriptAnimAddon(System.Boolean value) { }
        private System.Boolean get_lookAtUseAdditive() { }
        private System.Void set_lookAtUseAdditive(System.Boolean value) { }
        private System.Boolean IsControlByThisTrack(UnityEngine.Timeline.RuntimeElement element) { }
        private System.Boolean CanCompileClips() { }
        private System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs() { }
        private System.Boolean get_inClipMode() { }
        private UnityEngine.Vector3 get_infiniteClipOffsetPosition() { }
        private System.Void set_infiniteClipOffsetPosition(UnityEngine.Vector3 value) { }
        private UnityEngine.Quaternion get_infiniteClipOffsetRotation() { }
        private System.Void set_infiniteClipOffsetRotation(UnityEngine.Quaternion value) { }
        private UnityEngine.Vector3 get_infiniteClipOffsetEulerAngles() { }
        private System.Void set_infiniteClipOffsetEulerAngles(UnityEngine.Vector3 value) { }
        private System.Boolean get_infiniteClipApplyFootIK() { }
        private System.Void set_infiniteClipApplyFootIK(System.Boolean value) { }
        private System.Double get_infiniteClipTimeOffset() { }
        private System.Void set_infiniteClipTimeOffset(System.Double value) { }
        private UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_infiniteClipPreExtrapolation() { }
        private System.Void set_infiniteClipPreExtrapolation(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value) { }
        private UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_infiniteClipPostExtrapolation() { }
        private System.Void set_infiniteClipPostExtrapolation(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value) { }
        private UnityEngine.Timeline.AnimationPlayableAsset.LoopMode get_infiniteClipLoop() { }
        private System.Void set_infiniteClipLoop(UnityEngine.Timeline.AnimationPlayableAsset.LoopMode value) { }
        private System.Void ResetOffsets() { }
        private UnityEngine.Timeline.TimelineClip CreateClip(UnityEngine.AnimationClip clip) { }
        private System.Void CreateInfiniteClip(System.String infiniteClipName) { }
        private UnityEngine.Timeline.TimelineClip CreateRecordableClip(System.String animClipName) { }
        private System.Void OnCreateClip(UnityEngine.Timeline.TimelineClip clip) { }
        private System.Int32 CalculateItemsHash() { }
        private System.Void UpdateClipOffsets() { }
        private UnityEngine.Playables.Playable _CreatePlayableFromClip(UnityEngine.Timeline.TimelineClip c, UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.AppliedOffsetMode mode) { }
        private UnityEngine.Playables.Playable CompileTrackPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Timeline.AnimationTrack track, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.Timeline.AppliedOffsetMode mode) { }
        private System.Boolean ShouldLinkWithMainTrackMixer(UnityEngine.Timeline.AnimationTrack animationTrack) { }
        private UnityEngine.Playables.Playable ApplyScriptAnimationPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animations.AnimationLayerMixerPlayable mixer, UnityEngine.GameObject go) { }
        private UnityEngine.Playables.Playable UnityEngine.Timeline.ILayerable.CreateLayerMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount) { }
        private UnityEngine.Playables.Playable CreateMixerPlayableGraph(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree) { }
        private System.Void AttachCustomBlend(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animations.AnimationLayerMixerPlayable layerMixer) { }
        private System.Void AttachLastAdditiveClip(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animations.AnimationLayerMixerPlayable layerMixer, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, System.Collections.Generic.List<UnityEngine.Timeline.AnimationTrack> flattenTracks) { }
        private System.Int32 GetDefaultBlendCount() { }
        private System.Void AttachDefaultBlend(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animations.AnimationLayerMixerPlayable mixer, System.Boolean requireOffset, UnityEngine.Animator animator) { }
        private UnityEngine.Playables.Playable AttachOffsetPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable playable, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        private System.Boolean RequiresMotionXPlayable(UnityEngine.Timeline.AppliedOffsetMode mode, UnityEngine.GameObject gameObject) { }
        private System.Boolean UsesAbsoluteMotion(UnityEngine.Timeline.AppliedOffsetMode mode) { }
        private System.Boolean HasController(UnityEngine.GameObject gameObject) { }
        private UnityEngine.Animator GetBinding(UnityEngine.Playables.PlayableDirector director) { }
        private UnityEngine.Animations.AnimationLayerMixerPlayable CreateGroupMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount) { }
        private UnityEngine.Playables.Playable CreateInfiniteTrackPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.Timeline.AppliedOffsetMode mode) { }
        private UnityEngine.Playables.Playable ApplyTrackOffset(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable root, UnityEngine.GameObject go, UnityEngine.Timeline.AppliedOffsetMode mode) { }
        private System.Void _AddClipIntoTree(UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.Timeline.RuntimeClip clip) { }
        private System.Void GetEvaluationTime(System.Double& outStart, System.Double& outDuration) { }
        private System.Void GetSequenceTime(System.Double& outStart, System.Double& outDuration) { }
        private System.Void AssignAnimationClip(UnityEngine.Timeline.TimelineClip clip, UnityEngine.AnimationClip animClip) { }
        private System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver) { }
        private System.Void GetAnimationClips(System.Collections.Generic.List<UnityEngine.AnimationClip> animClips) { }
        private UnityEngine.Timeline.AppliedOffsetMode GetOffsetMode(UnityEngine.GameObject go, System.Boolean animatesRootTransform) { }
        private System.Boolean IsRootTransformDisabledByMask(UnityEngine.GameObject gameObject, UnityEngine.Transform genericRootNode) { }
        private UnityEngine.Transform GetGenericRootNode(UnityEngine.GameObject gameObject) { }
        private System.Boolean AnimatesRootTransform() { }
        private UnityEngine.Transform FindInHierarchyBreadthFirst(UnityEngine.Transform t, System.String name) { }
        private UnityEngine.Vector3 get_openClipOffsetPosition() { }
        private System.Void set_openClipOffsetPosition(UnityEngine.Vector3 value) { }
        private UnityEngine.Quaternion get_openClipOffsetRotation() { }
        private System.Void set_openClipOffsetRotation(UnityEngine.Quaternion value) { }
        private UnityEngine.Vector3 get_openClipOffsetEulerAngles() { }
        private System.Void set_openClipOffsetEulerAngles(UnityEngine.Vector3 value) { }
        private UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_openClipPreExtrapolation() { }
        private System.Void set_openClipPreExtrapolation(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value) { }
        private UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_openClipPostExtrapolation() { }
        private System.Void set_openClipPostExtrapolation(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value) { }
        private System.Void OnUpgradeFromVersion(System.Int32 oldVersion) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200002C
    public interface ICurvesOwner
    {
        // Methods
        private System.String get_defaultCurvesName() { }
        private UnityEngine.Object get_asset() { }
        private UnityEngine.Object get_assetOwner() { }
        private UnityEngine.Timeline.TrackAsset get_targetTrack() { }

    }

    // TypeToken: 0x200002D
    public class TimelineClip, ICurvesOwner, ISerializationCallbackReceiver
    {
        // Fields
        private static System.Int32 k_LatestVersion;        // 0x0
        private System.Int32 m_Version;        // 0x10
        public static readonly UnityEngine.Timeline.ClipCaps kDefaultClipCaps;        // 0x0
        public static readonly System.Single kDefaultClipDurationInSeconds;        // 0x4
        public static readonly System.Double kTimeScaleMin;        // 0x8
        public static readonly System.Double kTimeScaleMax;        // 0x10
        private static readonly System.String kDefaultCurvesName;        // 0x18
        private static readonly System.Double kMinDuration;        // 0x20
        private static readonly System.Double kMaxTimeValue;        // 0x28
        public System.Int32 optionIndex;        // 0x14
        private System.Double m_Start;        // 0x18
        private System.Double m_ClipIn;        // 0x20
        private UnityEngine.Object m_Asset;        // 0x28
        private System.Double m_Duration;        // 0x30
        private System.Double m_TimeScale;        // 0x38
        private UnityEngine.Timeline.TrackAsset m_ParentTrack;        // 0x40
        private System.Double m_EaseInDuration;        // 0x48
        private System.Double m_EaseOutDuration;        // 0x50
        private System.Double m_BlendInDuration;        // 0x58
        private System.Double m_BlendOutDuration;        // 0x60
        private UnityEngine.AnimationCurve m_MixInCurve;        // 0x68
        private UnityEngine.AnimationCurve m_MixOutCurve;        // 0x70
        private UnityEngine.Timeline.TimelineClip.BlendCurveMode m_BlendInCurveMode;        // 0x78
        private UnityEngine.Timeline.TimelineClip.BlendCurveMode m_BlendOutCurveMode;        // 0x7C
        private System.Collections.Generic.List<System.String> m_ExposedParameterNames;        // 0x80
        private UnityEngine.AnimationClip m_AnimationCurves;        // 0x88
        private System.Boolean m_Recordable;        // 0x90
        private UnityEngine.Timeline.TimelineClip.ClipExtrapolation m_PostExtrapolationMode;        // 0x94
        private UnityEngine.Timeline.TimelineClip.ClipExtrapolation m_PreExtrapolationMode;        // 0x98
        private System.Double m_PostExtrapolationTime;        // 0xA0
        private System.Double m_PreExtrapolationTime;        // 0xA8
        private System.String m_DisplayName;        // 0xB0

        // Methods
        private System.Void UpgradeToLatestVersion() { }
        private System.Void .ctor(UnityEngine.Timeline.TrackAsset parent) { }
        private System.Double get_timeScale() { }
        private System.Double get_start() { }
        private System.Void set_start(System.Double value) { }
        private System.Double get_duration() { }
        private System.Void set_duration(System.Double value) { }
        private System.Double get_end() { }
        private System.Double get_clipIn() { }
        private System.String get_displayName() { }
        private System.Void set_displayName(System.String value) { }
        private System.Double get_clipAssetDuration() { }
        private UnityEngine.AnimationClip get_curves() { }
        private System.String UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName() { }
        private UnityEngine.Object get_asset() { }
        private System.Void set_asset(UnityEngine.Object value) { }
        private UnityEngine.Object UnityEngine.Timeline.ICurvesOwner.get_assetOwner() { }
        private UnityEngine.Timeline.TrackAsset UnityEngine.Timeline.ICurvesOwner.get_targetTrack() { }
        private UnityEngine.Timeline.TrackAsset GetParentTrack() { }
        private System.Void SetParentTrack_Internal(UnityEngine.Timeline.TrackAsset newParentTrack) { }
        private System.Double get_easeInDuration() { }
        private System.Void set_easeInDuration(System.Double value) { }
        private System.Double get_easeOutDuration() { }
        private System.Void set_easeOutDuration(System.Double value) { }
        private System.Double get_blendInDuration() { }
        private System.Double get_blendOutDuration() { }
        private System.Boolean get_hasBlendIn() { }
        private System.Boolean get_hasBlendOut() { }
        private UnityEngine.AnimationCurve get_mixInCurve() { }
        private System.Void set_mixInCurve(UnityEngine.AnimationCurve value) { }
        private System.Double get_mixInDuration() { }
        private UnityEngine.AnimationCurve get_mixOutCurve() { }
        private System.Void set_mixOutCurve(UnityEngine.AnimationCurve value) { }
        private System.Double get_mixOutTime() { }
        private System.Double get_mixOutDuration() { }
        private System.Boolean get_recordable() { }
        private System.Void set_recordable(System.Boolean value) { }
        private UnityEngine.Timeline.ClipCaps get_clipCaps() { }
        private System.Int32 Hash() { }
        private System.Single EvaluateMixOut(System.Double time) { }
        private System.Single EvaluateMixOutAtGivenTime(System.Double time, System.Double mixOutTime, System.Double mixOutDuration) { }
        private System.Single EvaluateMixIn(System.Double time) { }
        private System.Single EvaluateMixInAtGivenTime(System.Double time, System.Double runtimeMixInTime, System.Double mixInDuration) { }
        private UnityEngine.AnimationCurve GetDefaultMixInCurve() { }
        private UnityEngine.AnimationCurve GetDefaultMixOutCurve() { }
        private System.Double ToLocalTime(System.Double time) { }
        private System.Double SanitizeTimeValue(System.Double value, System.Double defaultValue) { }
        private UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_postExtrapolationMode() { }
        private System.Void set_postExtrapolationMode(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value) { }
        private UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_preExtrapolationMode() { }
        private System.Void set_preExtrapolationMode(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value) { }
        private System.Void SetPostExtrapolationTime(System.Double time) { }
        private System.Void SetPreExtrapolationTime(System.Double time) { }
        private System.Boolean IsPreExtrapolatedTime(System.Double sequenceTime) { }
        private System.Boolean IsPostExtrapolatedTime(System.Double sequenceTime) { }
        private System.Double get_extrapolatedStart() { }
        private System.Double get_extrapolatedDuration() { }
        private System.Double GetExtrapolatedTime(System.Double time, UnityEngine.Timeline.TimelineClip.ClipExtrapolation mode, System.Double duration) { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        private System.String ToString() { }
        private System.Void UpdateDirty(System.Double oldValue, System.Double newValue) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000032
    public class TimelineAsset : PlayableAsset, ISerializationCallbackReceiver, ITimelineClipAsset, IPropertyPreview
    {
        // Fields
        private static System.Int32 k_LatestVersion;        // 0x0
        private System.Int32 m_Version;        // 0x18
        private System.Collections.Generic.List<UnityEngine.ScriptableObject> m_Tracks;        // 0x20
        private System.Double m_FixedDuration;        // 0x28
        private UnityEngine.Timeline.TrackAsset[] m_CacheOutputTracks;        // 0x30
        private UnityEngine.Timeline.GroupTrack[] m_CacheGroupTracks;        // 0x38
        private System.Collections.Generic.List<UnityEngine.Timeline.TrackAsset> m_CacheRootTracks;        // 0x40
        private UnityEngine.Timeline.TrackAsset[] m_CacheFlattenedTracks;        // 0x48
        private UnityEngine.Timeline.TimelineAsset.EditorSettings m_EditorSettings;        // 0x50
        private UnityEngine.Timeline.TimelineAsset.DurationMode m_DurationMode;        // 0x58
        private UnityEngine.Timeline.MarkerTrack m_MarkerTrack;        // 0x60

        // Methods
        private System.Void UpgradeToLatestVersion() { }
        private UnityEngine.Timeline.TimelineAsset.EditorSettings get_editorSettings() { }
        private System.Double get_duration() { }
        private System.Double get_fixedDuration() { }
        private System.Void set_fixedDuration(System.Double value) { }
        private UnityEngine.Timeline.TimelineAsset.DurationMode get_durationMode() { }
        private System.Void set_durationMode(UnityEngine.Timeline.TimelineAsset.DurationMode value) { }
        private System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs() { }
        private UnityEngine.Timeline.ClipCaps get_clipCaps() { }
        private System.Int32 get_outputTrackCount() { }
        private System.Int32 get_rootTrackCount() { }
        private System.Void OnValidate() { }
        private UnityEngine.Timeline.TrackAsset GetRootTrack(System.Int32 index) { }
        private System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> GetRootTracks() { }
        private UnityEngine.Timeline.TrackAsset GetOutputTrack(System.Int32 index) { }
        private System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> GetOutputTracks() { }
        private System.Collections.Generic.IEnumerable<UnityEngine.Timeline.GroupTrack> GetGroupTracks() { }
        private System.Double GetValidFrameRate(System.Double frameRate) { }
        private System.Void UpdateRootTrackCache() { }
        private System.Void UpdateOutputTrackCache() { }
        private UnityEngine.Timeline.TrackAsset[] get_flattenedTracks() { }
        private UnityEngine.Timeline.TrackAsset[] GetAllTracks() { }
        private UnityEngine.Timeline.MarkerTrack get_markerTrack() { }
        private System.Collections.Generic.List<UnityEngine.ScriptableObject> get_trackObjects() { }
        private System.Void AddTrackInternal(UnityEngine.Timeline.TrackAsset track) { }
        private System.Void RemoveTrack(UnityEngine.Timeline.TrackAsset track) { }
        private UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go) { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        private System.Void __internalAwake() { }
        private System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver) { }
        private System.Void CreateMarkerTrack() { }
        private System.Void Invalidate() { }
        private System.Void UpdateFixedDurationWithItemsDuration() { }
        private UnityEngine.Timeline.DiscreteTime CalculateItemsDuration() { }
        private System.Void AddSubTracksRecursive(UnityEngine.Timeline.TrackAsset track, System.Collections.Generic.List<UnityEngine.Timeline.TrackAsset>& allTracks) { }
        private UnityEngine.Timeline.TrackAsset CreateTrack(System.Type type, UnityEngine.Timeline.TrackAsset parent, System.String name) { }
        private T CreateTrack(UnityEngine.Timeline.TrackAsset parent, System.String trackName) { }
        private T CreateTrack(System.String trackName) { }
        private T CreateTrack() { }
        private System.Boolean DeleteClip(UnityEngine.Timeline.TimelineClip clip) { }
        private System.Boolean DeleteTrack(UnityEngine.Timeline.TrackAsset track) { }
        private System.Void MoveLastTrackBefore(UnityEngine.Timeline.TrackAsset asset) { }
        private System.Void MoveTrackAfter(UnityEngine.Timeline.TrackAsset trackToMove, UnityEngine.Timeline.TrackAsset targetTrack) { }
        private UnityEngine.Timeline.TrackAsset AllocateTrack(UnityEngine.Timeline.TrackAsset trackAssetParent, System.String trackName, System.Type trackType) { }
        private System.Void DeleteRecordedAnimation(UnityEngine.Timeline.TrackAsset track) { }
        private System.Void DeleteRecordedAnimation(UnityEngine.Timeline.TimelineClip clip) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000039
    public class TrackAsset : PlayableAsset, ISerializationCallbackReceiver, IPropertyPreview, ICurvesOwner, IDynamicBinding
    {
        // Fields
        private static System.Int32 k_LatestVersion;        // 0x0
        private System.Int32 m_Version;        // 0x18
        private UnityEngine.AnimationClip m_AnimClip;        // 0x20
        public System.Boolean useAutoBinding;        // 0x28
        public System.String autoBindingPath;        // 0x30
        public System.String uniqueId;        // 0x38
        private static UnityEngine.Timeline.TrackAsset.TransientBuildData s_BuildData;        // 0x0
        private static System.String kDefaultCurvesName;        // 0x0
        private static System.Action<UnityEngine.Timeline.TimelineClip,UnityEngine.GameObject,UnityEngine.Playables.Playable> OnClipPlayableCreate;        // 0x18
        private static System.Action<UnityEngine.Timeline.TrackAsset,UnityEngine.GameObject,UnityEngine.Playables.Playable> OnTrackAnimationPlayableCreate;        // 0x20
        private System.Boolean m_RuntimeMuted;        // 0x40
        private System.Boolean m_Locked;        // 0x41
        private System.Boolean m_Muted;        // 0x42
        private System.String m_CustomPlayableFullTypename;        // 0x48
        private UnityEngine.AnimationClip m_Curves;        // 0x50
        private UnityEngine.Playables.PlayableAsset m_Parent;        // 0x58
        private System.Collections.Generic.List<UnityEngine.ScriptableObject> m_Children;        // 0x60
        private System.Int32 m_ItemsHash;        // 0x68
        private UnityEngine.Timeline.TimelineClip[] m_ClipsCache;        // 0x70
        private UnityEngine.Timeline.DiscreteTime m_Start;        // 0x78
        private UnityEngine.Timeline.DiscreteTime m_End;        // 0x80
        private System.Boolean m_CacheSorted;        // 0x88
        private System.Nullable<System.Boolean> m_SupportsNotifications;        // 0x89
        private static UnityEngine.Timeline.TrackAsset[] s_EmptyCache;        // 0x28
        private System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> m_ChildTrackCache;        // 0x90
        private static System.Collections.Generic.Dictionary<System.Type,UnityEngine.Timeline.TrackBindingTypeAttribute> s_TrackBindingTypeAttributeCache;        // 0x30
        protected internal System.Collections.Generic.List<UnityEngine.Timeline.TimelineClip> m_Clips;        // 0x98
        private UnityEngine.Timeline.MarkerList m_Markers;        // 0xA0
        public System.Int32 OptionIndex;        // 0xB8
        public System.Boolean useRuntimeMuted;        // 0xBC

        // Methods
        private System.Void OnBeforeTrackSerialize() { }
        private System.Void OnAfterTrackDeserialize() { }
        private System.Void OnUpgradeFromVersion(System.Int32 oldVersion) { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        private System.Void UpgradeToLatestVersion() { }
        private System.Void add_OnClipPlayableCreate(System.Action<UnityEngine.Timeline.TimelineClip,UnityEngine.GameObject,UnityEngine.Playables.Playable> value) { }
        private System.Void remove_OnClipPlayableCreate(System.Action<UnityEngine.Timeline.TimelineClip,UnityEngine.GameObject,UnityEngine.Playables.Playable> value) { }
        private System.Void add_OnTrackAnimationPlayableCreate(System.Action<UnityEngine.Timeline.TrackAsset,UnityEngine.GameObject,UnityEngine.Playables.Playable> value) { }
        private System.Void remove_OnTrackAnimationPlayableCreate(System.Action<UnityEngine.Timeline.TrackAsset,UnityEngine.GameObject,UnityEngine.Playables.Playable> value) { }
        private System.Double get_start() { }
        private System.Double get_end() { }
        private System.Double get_duration() { }
        private System.Boolean get_muted() { }
        private System.Void set_muted(System.Boolean value) { }
        private System.Boolean get_runtimeMuted() { }
        private System.Void set_runtimeMuted(System.Boolean value) { }
        private System.Boolean get_mutedInHierarchy() { }
        private UnityEngine.Timeline.TimelineAsset get_timelineAsset() { }
        private UnityEngine.Playables.PlayableAsset get_parent() { }
        private System.Void set_parent(UnityEngine.Playables.PlayableAsset value) { }
        private System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TimelineClip> GetClips() { }
        private UnityEngine.Timeline.TimelineClip[] get_clips() { }
        private System.Boolean get_isEmpty() { }
        private System.Boolean get_hasClips() { }
        private System.Boolean get_hasCurves() { }
        private System.Boolean get_isSubTrack() { }
        private System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs() { }
        private System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> GetChildTracks() { }
        private System.String get_customPlayableTypename() { }
        private System.Void set_customPlayableTypename(System.String value) { }
        private UnityEngine.AnimationClip get_curves() { }
        private System.Void set_curves(UnityEngine.AnimationClip value) { }
        private System.String UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName() { }
        private UnityEngine.Object UnityEngine.Timeline.ICurvesOwner.get_asset() { }
        private UnityEngine.Object UnityEngine.Timeline.ICurvesOwner.get_assetOwner() { }
        private UnityEngine.Timeline.TrackAsset UnityEngine.Timeline.ICurvesOwner.get_targetTrack() { }
        private System.Collections.Generic.List<UnityEngine.ScriptableObject> get_subTracksObjects() { }
        private System.Boolean get_locked() { }
        private System.Void set_locked(System.Boolean value) { }
        private System.Boolean get_lockedInHierarchy() { }
        private System.Boolean get_supportsNotifications() { }
        private System.Void __internalAwake() { }
        private System.Void CreateCurves(System.String curvesClipName) { }
        private UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount) { }
        private UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go) { }
        private UnityEngine.Timeline.TimelineClip CreateDefaultClip() { }
        private UnityEngine.Timeline.TimelineClip CreateClip() { }
        private System.Boolean DeleteClip(UnityEngine.Timeline.TimelineClip clip) { }
        private UnityEngine.Timeline.IMarker CreateMarker(System.Type type, System.Double time) { }
        private T CreateMarker(System.Double time) { }
        private System.Boolean DeleteMarker(UnityEngine.Timeline.IMarker marker) { }
        private System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> GetMarkers() { }
        private System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> GetClipMarkers() { }
        private System.Int32 GetMarkerCount() { }
        private UnityEngine.Timeline.IMarker GetMarker(System.Int32 idx) { }
        private UnityEngine.Timeline.TimelineClip CreateClip(System.Type requestedType) { }
        private UnityEngine.Timeline.TimelineClip CreateAndAddNewClipOfType(System.Type requestedType) { }
        private UnityEngine.Timeline.TimelineClip CreateClipOfType(System.Type requestedType) { }
        private UnityEngine.Timeline.TimelineClip CreateClipFromPlayableAsset(UnityEngine.Playables.IPlayableAsset asset) { }
        private UnityEngine.Timeline.TimelineClip CreateClipFromAsset(UnityEngine.ScriptableObject playableAsset) { }
        private System.Collections.Generic.IEnumerable<UnityEngine.ScriptableObject> GetMarkersRaw() { }
        private System.Void ClearMarkers() { }
        private System.Void AddMarker(UnityEngine.ScriptableObject e) { }
        private System.Boolean DeleteMarkerRaw(UnityEngine.ScriptableObject marker) { }
        private System.Int32 GetTimeRangeHash() { }
        private System.Void AddClip(UnityEngine.Timeline.TimelineClip newClip) { }
        private UnityEngine.Playables.Playable CreateNotificationsPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable mixerPlayable, UnityEngine.GameObject go, UnityEngine.Playables.Playable timelinePlayable) { }
        private UnityEngine.Playables.Playable CreatePlayableGraph(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.Playables.Playable timelinePlayable) { }
        private UnityEngine.Playables.Playable CompileClips(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Collections.Generic.IList<UnityEngine.Timeline.TimelineClip> timelineClips, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree) { }
        private System.Void GatherCompilableTracks(System.Collections.Generic.IList<UnityEngine.Timeline.TrackAsset> tracks) { }
        private System.Void GatherNotifications(System.Collections.Generic.List<UnityEngine.Timeline.IMarker> markers) { }
        private UnityEngine.Playables.Playable CreateMixerPlayableGraph(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree) { }
        private System.Void ConfigureTrackAnimation(UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.GameObject go, UnityEngine.Playables.Playable blend) { }
        private System.Void SortClips() { }
        private System.Void ClearClipsInternal() { }
        private System.Void ClearSubTracksInternal() { }
        private System.Void OnClipMove() { }
        private UnityEngine.Timeline.TimelineClip CreateNewClipContainerInternal() { }
        private System.Void AddChild(UnityEngine.Timeline.TrackAsset child) { }
        private System.Void MoveLastTrackBefore(UnityEngine.Timeline.TrackAsset asset) { }
        private System.Boolean RemoveSubTrack(UnityEngine.Timeline.TrackAsset child) { }
        private System.Void RemoveClip(UnityEngine.Timeline.TimelineClip clip) { }
        private System.Void GetEvaluationTime(System.Double& outStart, System.Double& outDuration) { }
        private System.Void GetSequenceTime(System.Double& outStart, System.Double& outDuration) { }
        private System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver) { }
        private UnityEngine.GameObject GetGameObjectBinding(UnityEngine.Playables.PlayableDirector director) { }
        private System.Boolean ValidateClipType(System.Type clipType) { }
        private System.Void OnCreateClip(UnityEngine.Timeline.TimelineClip clip) { }
        private System.Void UpdateDuration() { }
        private System.Int32 CalculateItemsHash() { }
        private UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject gameObject, UnityEngine.Timeline.TimelineClip clip) { }
        private System.Void Invalidate() { }
        private System.Double GetNotificationDuration() { }
        private System.Boolean CanCompileClips() { }
        private System.Boolean HasChildTracks() { }
        private System.Boolean CanCreateTrackMixer() { }
        private System.Boolean IsCompilable() { }
        private System.Void UpdateChildTrackCache() { }
        private System.Int32 Hash() { }
        private System.Int32 GetClipsHash() { }
        private System.Int32 GetAnimationClipHash(UnityEngine.AnimationClip clip) { }
        private System.Boolean HasNotifications() { }
        private System.Boolean CanCompileNotifications() { }
        private System.Boolean CanCreateMixerRecursive() { }
        private UnityEngine.Playables.Playable CreateLayerMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200003F
    public class TimelineHelpURLAttribute : Attribute
    {
    }

    // TypeToken: 0x2000040
    public class TrackColorAttribute : Attribute
    {
        // Fields
        private UnityEngine.Color m_Color;        // 0x10

        // Methods
        private System.Void .ctor(System.Single r, System.Single g, System.Single b) { }

    }

    // TypeToken: 0x2000041
    public class AudioClipProperties : PlayableBehaviour
    {
        // Fields
        public System.Single volume;        // 0x10

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000042
    public class AudioMixerProperties : PlayableBehaviour
    {
        // Fields
        public System.Single volume;        // 0x10
        public System.Single stereoPan;        // 0x14
        public System.Single spatialBlend;        // 0x18

        // Methods
        private System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000043
    public class AudioPlayableAsset : PlayableAsset, ITimelineClipAsset
    {
        // Fields
        private UnityEngine.AudioClip m_Clip;        // 0x18
        private System.Boolean m_Loop;        // 0x20
        private System.Single m_bufferingTime;        // 0x24
        private UnityEngine.Timeline.AudioClipProperties m_ClipProperties;        // 0x28

        // Methods
        private System.Single get_bufferingTime() { }
        private System.Void set_bufferingTime(System.Single value) { }
        private UnityEngine.AudioClip get_clip() { }
        private System.Void set_clip(UnityEngine.AudioClip value) { }
        private System.Boolean get_loop() { }
        private System.Void set_loop(System.Boolean value) { }
        private System.Double get_duration() { }
        private System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs() { }
        private UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go) { }
        private UnityEngine.Timeline.ClipCaps get_clipCaps() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000045
    public class AudioTrack : TrackAsset
    {
        // Fields
        private UnityEngine.Timeline.AudioMixerProperties m_TrackProperties;        // 0xC0

        // Methods
        private UnityEngine.Timeline.TimelineClip CreateClip(UnityEngine.AudioClip clip) { }
        private UnityEngine.Playables.Playable CompileClips(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Collections.Generic.IList<UnityEngine.Timeline.TimelineClip> timelineClips, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree) { }
        private System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs() { }
        private System.Void OnValidate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000047
    public struct ACConditionDescriptor
    {
        // Fields
        private System.Int32 m_ConditionMode;        // 0x10
        private System.String m_ConditionEvent;        // 0x18
        private System.Single m_EventTreshold;        // 0x20

    }

    // TypeToken: 0x2000048
    public class ACTransitionDescriptor
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000049
    public class BeyondCommunicator
    {
        // Fields
        public static System.Boolean setAddonLayerAdditive;        // 0x0
        private static System.Action<UnityEngine.Animator,UnityEngine.Animations.AnimationLayerMixerPlayable,UnityEngine.Timeline.AnimationTrack,UnityEngine.ScriptableObject,UnityEngine.Transform,UnityEngine.Timeline.CommunicatorParam> <ConnectToJobSync>k__BackingField;        // 0x8

        // Methods
        private System.Action<UnityEngine.Animator,UnityEngine.Animations.AnimationLayerMixerPlayable,UnityEngine.Timeline.AnimationTrack,UnityEngine.ScriptableObject,UnityEngine.Transform,UnityEngine.Timeline.CommunicatorParam> get_ConnectToJobSync() { }
        private System.Void set_ConnectToJobSync(System.Action<UnityEngine.Animator,UnityEngine.Animations.AnimationLayerMixerPlayable,UnityEngine.Timeline.AnimationTrack,UnityEngine.ScriptableObject,UnityEngine.Transform,UnityEngine.Timeline.CommunicatorParam> value) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200004A
    public class BlendMotionDescriptor
    {
        // Fields
        public UnityEngine.AnimationClip motion;        // 0x10
        public System.String poseTimerParam;        // 0x18
        public System.String blendParam;        // 0x20
        public System.Single threshold;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004B
    public class BlendTreeDescriptor
    {
        // Fields
        public UnityEngine.Timeline.BlendTreeDescriptor.DescriptorBlendTreeType blendType;        // 0x10
        public System.Collections.Generic.List<UnityEngine.Timeline.BlendMotionDescriptor> motionDescriptorList;        // 0x18
        private System.String <speedParameter>k__BackingField;        // 0x20
        private System.Boolean <speedParameterActive>k__BackingField;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004D
    public interface ITimelineRootMarker
    {
        // Methods
        private UnityEngine.Playables.PlayableDirector get_topDirector() { }
        private UnityEngine.GameObject get_rootGo() { }
        private System.Boolean get_useEarlyUpdate() { }
        private System.Void RegisterLoopSegmentRuntimeClip(System.String key, UnityEngine.Timeline.RuntimeClip runtimeClip) { }
        private System.Void UpdateAllVFXFollowBoneTools() { }
        private System.Boolean get_enableLoop() { }
        private System.Boolean get_isOptimizingHolding() { }
        private System.Boolean get_onlyEvaluateTopDirector() { }
        private System.Collections.Generic.Dictionary<UnityEngine.Playables.PlayableDirector,UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.DirectorControlPlayable>> get_director2ControlPlayable() { }
        private System.Void set_director2ControlPlayable(System.Collections.Generic.Dictionary<UnityEngine.Playables.PlayableDirector,UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.DirectorControlPlayable>> value) { }

    }

    // TypeToken: 0x200004E
    public class LayerDescriptor : ScriptableObject
    {
        // Fields
        public System.String layerName;        // 0x18
        public UnityEngine.AvatarMask avatarMask;        // 0x20
        public System.Boolean isAdditive;        // 0x28
        public System.Collections.Generic.List<UnityEngine.Timeline.StateDescriptor> stateDescriptors;        // 0x30

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004F
    public class MotionDescriptor
    {
        // Fields
        public System.String stateName;        // 0x10
        public UnityEngine.AnimationClip motion;        // 0x18
        public System.Single speed;        // 0x20
        public System.String speedParameter;        // 0x28
        public System.Boolean speedParameterActive;        // 0x30
        public System.String mirrorParameter;        // 0x38
        public System.Boolean mirrorParameterActive;        // 0x40
        public System.String timeParameter;        // 0x48
        public System.Boolean timeParameterActive;        // 0x50

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000050
    public class StateDescriptor
    {
        // Fields
        public System.String stateName;        // 0x10
        public System.Boolean isDefaultState;        // 0x18
        public System.String stateWeightParameter;        // 0x20
        public System.Boolean stateWeightParameterActive;        // 0x28
        public System.Boolean isBlendTree;        // 0x29
        public UnityEngine.Timeline.MotionDescriptor motionDescriptor;        // 0x30
        public UnityEngine.Timeline.BlendTreeDescriptor blendTreeDescriptor;        // 0x38

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000051
    public struct ClipCaps
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Timeline.ClipCaps None;        // 0x0
        public static UnityEngine.Timeline.ClipCaps Looping;        // 0x0
        public static UnityEngine.Timeline.ClipCaps Extrapolation;        // 0x0
        public static UnityEngine.Timeline.ClipCaps ClipIn;        // 0x0
        public static UnityEngine.Timeline.ClipCaps SpeedMultiplier;        // 0x0
        public static UnityEngine.Timeline.ClipCaps Blending;        // 0x0
        public static UnityEngine.Timeline.ClipCaps AutoScale;        // 0x0
        public static UnityEngine.Timeline.ClipCaps ClipMarker;        // 0x0
        public static UnityEngine.Timeline.ClipCaps DialogLoopSegment;        // 0x0
        public static UnityEngine.Timeline.ClipCaps IgniteOnce;        // 0x0
        public static UnityEngine.Timeline.ClipCaps OnlyDeltaTime;        // 0x0
        public static UnityEngine.Timeline.ClipCaps DialogJumpSegment;        // 0x0
        public static UnityEngine.Timeline.ClipCaps EvaluateTwiceWhenEnabled;        // 0x0
        public static UnityEngine.Timeline.ClipCaps DynamicLink;        // 0x0
        public static UnityEngine.Timeline.ClipCaps ConditionBlend;        // 0x0
        public static UnityEngine.Timeline.ClipCaps All;        // 0x0

    }

    // TypeToken: 0x2000052
    public class TimelineClipCapsExtensions
    {
        // Methods
        private System.Boolean SupportsExtrapolation(UnityEngine.Timeline.TimelineClip clip) { }
        private System.Boolean HasAny(UnityEngine.Timeline.ClipCaps caps, UnityEngine.Timeline.ClipCaps flags) { }

    }

    // TypeToken: 0x2000053
    public class ControlPlayableAsset : PlayableAsset, IPropertyPreview, ITimelineClipAsset
    {
        // Fields
        private static System.Int32 k_MaxRandInt;        // 0x0
        private static readonly System.Collections.Generic.List<UnityEngine.Playables.PlayableDirector> k_EmptyDirectorsList;        // 0x0
        private static readonly System.Collections.Generic.List<UnityEngine.ParticleSystem> k_EmptyParticlesList;        // 0x8
        private static readonly System.Collections.Generic.HashSet<UnityEngine.ParticleSystem> s_SubEmitterCollector;        // 0x10
        public UnityEngine.ExposedReference<UnityEngine.GameObject> sourceGameObject;        // 0x18
        public UnityEngine.GameObject prefabGameObject;        // 0x28
        public System.Boolean updateParticle;        // 0x30
        public System.UInt32 particleRandomSeed;        // 0x34
        public System.Boolean forceRuntimeSimulate;        // 0x38
        public System.Boolean updateDirector;        // 0x39
        public System.Boolean updateITimeControl;        // 0x3A
        public System.Boolean searchHierarchy;        // 0x3B
        public System.Boolean active;        // 0x3C
        public UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState postPlayback;        // 0x40
        private System.Boolean m_OnlyDeltaTime;        // 0x44
        private System.Boolean m_IgniteOnce;        // 0x45
        private UnityEngine.Playables.PlayableAsset m_ControlDirectorAsset;        // 0x48
        private System.Double m_Duration;        // 0x50
        private System.Boolean m_SupportLoop;        // 0x58
        private static System.Collections.Generic.HashSet<UnityEngine.Playables.PlayableDirector> s_ProcessedDirectors;        // 0x18
        private static System.Collections.Generic.HashSet<UnityEngine.GameObject> s_CreatedPrefabs;        // 0x20
        private System.Boolean <controllingDirectors>k__BackingField;        // 0x59
        private System.Boolean <controllingParticles>k__BackingField;        // 0x5A

        // Methods
        private System.Boolean get_showBaseParam() { }
        private System.Boolean get_controllingDirectors() { }
        private System.Void set_controllingDirectors(System.Boolean value) { }
        private System.Boolean get_controllingParticles() { }
        private System.Void set_controllingParticles(System.Boolean value) { }
        private System.Boolean get_OnlyDeltaTime() { }
        private System.Void set_OnlyDeltaTime(System.Boolean value) { }
        private System.Boolean get_IgniteOnce() { }
        private System.Void set_IgniteOnce(System.Boolean value) { }
        private System.Void OnEnable() { }
        private System.Double get_duration() { }
        private UnityEngine.Timeline.ClipCaps get_clipCaps() { }
        private UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go) { }
        private UnityEngine.Playables.Playable ConnectPlayablesToMixer(UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> playables) { }
        private System.Void CreateActivationPlayable(UnityEngine.GameObject root, UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> outplayables) { }
        private System.Void SearchHierarchyAndConnectParticleSystem(System.Collections.Generic.IEnumerable<UnityEngine.ParticleSystem> particleSystems, System.Single clipIn, System.Single speedMultiplier, UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> outplayables) { }
        private System.Void SearchHierarchyAndConnectDirector(System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableDirector> directors, UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> outplayables, System.Boolean disableSelfReferences) { }
        private System.Void SearchHierarchyAndConnectControlableScripts(System.Collections.Generic.IEnumerable<UnityEngine.MonoBehaviour> controlableScripts, UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> outplayables) { }
        private System.Void ConnectMixerAndPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable mixer, UnityEngine.Playables.Playable playable, System.Int32 portIndex) { }
        private System.Collections.Generic.IList<T> GetComponent(UnityEngine.GameObject gameObject) { }
        private System.Collections.Generic.IEnumerable<UnityEngine.MonoBehaviour> GetControlableScripts(UnityEngine.GameObject root) { }
        private System.Void UpdateDurationAndLoopFlag(System.Collections.Generic.IList<UnityEngine.Playables.PlayableDirector> directors, System.Collections.Generic.IList<UnityEngine.ParticleSystem> particleSystems) { }
        private System.Collections.Generic.IList<UnityEngine.ParticleSystem> GetControllableParticleSystems(UnityEngine.GameObject go) { }
        private System.Void GetControllableParticleSystems(UnityEngine.Transform t, System.Collections.Generic.ICollection<UnityEngine.ParticleSystem> roots, System.Collections.Generic.HashSet<UnityEngine.ParticleSystem> subEmitters) { }
        private System.Void CacheSubEmitters(UnityEngine.ParticleSystem ps, System.Collections.Generic.HashSet<UnityEngine.ParticleSystem> subEmitters) { }
        private System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver) { }
        private System.Void PreviewParticles(UnityEngine.Timeline.IPropertyCollector driver, System.Collections.Generic.IEnumerable<UnityEngine.ParticleSystem> particles) { }
        private System.Void PreviewActivation(UnityEngine.Timeline.IPropertyCollector driver, System.Collections.Generic.IEnumerable<UnityEngine.GameObject> objects) { }
        private System.Void PreviewTimeControl(UnityEngine.Timeline.IPropertyCollector driver, UnityEngine.Playables.PlayableDirector director, System.Collections.Generic.IEnumerable<UnityEngine.MonoBehaviour> scripts) { }
        private System.Void PreviewDirectors(UnityEngine.Timeline.IPropertyCollector driver, System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableDirector> directors) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000055
    public class ControlTrack : TrackAsset
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000056
    public class AdditiveAnimApplyMono : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Timeline.AdditiveAnimApplyMono.TransformAdditive> pendingAdditives;        // 0x18
        private System.Boolean hasnewPendingUpdates;        // 0x20
        private UnityEngine.Timeline.ITimelineRootMarker _parentTimelineRoot;        // 0x28

        // Methods
        private System.Void Awake() { }
        private System.Void RecordAdditiveTransform(UnityEngine.Transform bone, UnityEngine.Vector3 position, UnityEngine.Vector3 rotationEuler, UnityEngine.Vector3 scale) { }
        private System.Void LateUpdate() { }
        private System.Void ApplyPendingTransforms() { }
        private System.Void ClearPendingTransforms() { }
        private System.Void NotifyCutsceneRootToUpdateVFXTools() { }
        private System.Void RegisterRootComponent() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000058
    public class AdditiveAnimMixer : PlayableBehaviour
    {
        // Fields
        public UnityEngine.Timeline.AdditiveAnimTrack track;        // 0x10
        private UnityEngine.GameObject bindingGo;        // 0x18
        private System.Boolean thisFrameAlreadyCalcualted;        // 0x20
        private System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Timeline.AdditiveAnimMixer.TransformAdditive> additiveCache;        // 0x28
        private System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform> bonePaths;        // 0x30
        private System.Collections.Generic.HashSet<System.String> notFoundBonePaths;        // 0x38

        // Methods
        private System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData) { }
        private System.Void _AddToAdditiveCache(UnityEngine.Timeline.AdditiveAnimPlayable additiveAnimPlayable, System.Single clipTime, System.Single weight) { }
        private System.Void _ApplyAdditive() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005A
    public class AdditiveAnimPlayable : PlayableBehaviour
    {
        // Fields
        public System.Collections.Generic.List<UnityEngine.Timeline.AdditiveAnimPlayableAsset.AnimationCurveInfo> extractedCurves;        // 0x10
        private System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<UnityEngine.Timeline.AdditiveAnimPlayableAsset.AnimationCurveInfo>> _curveCache;        // 0x18

        // Methods
        private System.Void OnPlayableCreate(UnityEngine.Playables.Playable playable) { }
        private System.Void InitializeCurveCache() { }
        private UnityEngine.AnimationCurve GetCurve(System.String path, System.String propertyName) { }
        private System.Single EvaluateCurve(System.String path, System.String propertyName, System.Single time) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005B
    public class AdditiveAnimPlayableAsset : PlayableAsset, ITimelineClipAsset
    {
        // Fields
        public UnityEngine.AnimationClip additiveClip;        // 0x18
        private UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.AdditiveAnimPlayable> additiveAnimPlayable;        // 0x20
        public System.Collections.Generic.List<UnityEngine.Timeline.AdditiveAnimPlayableAsset.AnimationCurveInfo> extractedCurves;        // 0x30
        private System.Boolean m_OnlyDeltaTime;        // 0x38
        private System.Boolean m_IgniteOnce;        // 0x39
        private UnityEngine.AnimationClip _lastProcessedClip;        // 0x40

        // Methods
        private System.Boolean get_OnlyDeltaTime() { }
        private System.Void set_OnlyDeltaTime(System.Boolean value) { }
        private System.Boolean get_IgniteOnce() { }
        private System.Void set_IgniteOnce(System.Boolean value) { }
        private UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner) { }
        private System.Void _InitializeBehaviourCurveCache() { }
        private UnityEngine.Timeline.ClipCaps get_clipCaps() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005D
    public class AdditiveAnimTrack : TrackAsset
    {
        // Fields
        private static System.String k_DefaultRecordableClipName;        // 0x0
        private System.Boolean m_InfiniteClip;        // 0xC0
        private UnityEngine.AnimationClip m_RecordableClip;        // 0xC8

        // Methods
        private UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount) { }
        private System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver) { }
        private UnityEngine.Timeline.TimelineClip CreateRecordableClip(System.String animClipName) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005E
    public class CombineToTopPlayableAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005F
    public interface IDynamicBinding
    {
    }

    // TypeToken: 0x2000060
    public class SegmentLoopPlayableBehaviour : PlayableBehaviour
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000061
    public class SegmentLoopPlayableClip : PlayableAsset, ITimelineClipAsset
    {
        // Fields
        public System.String loopSegmentKey;        // 0x18

        // Methods
        private UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner) { }
        private UnityEngine.Timeline.ClipCaps get_clipCaps() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000062
    public class SegmentLoopTrack : TrackAsset
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000063
    public struct DiscreteTime, IComparable
    {
        // Fields
        private static System.Double k_Tick;        // 0x0
        public static readonly UnityEngine.Timeline.DiscreteTime kMaxTime;        // 0x0
        private readonly System.Int64 m_DiscreteTime;        // 0x10

        // Methods
        private System.Double get_tickValue() { }
        private System.Void .ctor(System.Int64 time) { }
        private System.Void .ctor(System.Double time) { }
        private System.Void .ctor(System.Int32 time) { }
        private UnityEngine.Timeline.DiscreteTime OneTickBefore() { }
        private UnityEngine.Timeline.DiscreteTime OneTickAfter() { }
        private UnityEngine.Timeline.DiscreteTime FromTicks(System.Int64 ticks) { }
        private System.Int32 CompareTo(System.Object obj) { }
        private System.Boolean Equals(UnityEngine.Timeline.DiscreteTime other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int64 DoubleToDiscreteTime(System.Double time) { }
        private System.Int64 IntToDiscreteTime(System.Int32 time) { }
        private System.Double ToDouble(System.Int64 time) { }
        private System.Double op_Explicit(UnityEngine.Timeline.DiscreteTime b) { }
        private UnityEngine.Timeline.DiscreteTime op_Explicit(System.Double time) { }
        private UnityEngine.Timeline.DiscreteTime op_Implicit(System.Int32 time) { }
        private System.Boolean op_Equality(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs) { }
        private System.Boolean op_Inequality(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs) { }
        private System.Boolean op_LessThanOrEqual(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs) { }
        private System.Boolean op_GreaterThanOrEqual(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs) { }
        private UnityEngine.Timeline.DiscreteTime op_Subtraction(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs) { }
        private System.String ToString() { }
        private System.Int32 GetHashCode() { }
        private UnityEngine.Timeline.DiscreteTime Max(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs) { }
        private System.Int64 GetNearestTick(System.Double time) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000064
    public class InfiniteRuntimeClip : RuntimeElement
    {
        // Fields
        private UnityEngine.Playables.Playable m_Playable;        // 0x18
        private static readonly System.Int64 kIntervalEnd;        // 0x0
        private System.Int32 <optionIndex>k__BackingField;        // 0x28

        // Methods
        private System.Void .ctor(UnityEngine.Playables.Playable playable) { }
        private System.Int64 get_intervalStart() { }
        private System.Int64 get_intervalEnd() { }
        private System.Int32 get_optionIndex() { }
        private System.Void set_optionIndex(System.Int32 value) { }
        private System.Void set_enable(System.Boolean value) { }
        private System.Void EvaluateAt(System.Double localTime, UnityEngine.Playables.FrameData frameData) { }
        private System.Void DisableAt(System.Double localTime, System.Double rootDuration, UnityEngine.Playables.FrameData frameData) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000065
    public interface IInterval
    {
        // Methods
        private System.Int64 get_intervalStart() { }
        private System.Int64 get_intervalEnd() { }

    }

    // TypeToken: 0x2000066
    public interface IRuntimeReset
    {
        // Methods
        private System.Void RuntimeReset() { }

    }

    // TypeToken: 0x2000067
    public interface IOption
    {
    }

    // TypeToken: 0x2000068
    public struct IntervalTreeNode
    {
        // Fields
        public System.Int64 center;        // 0x10
        public System.Int32 first;        // 0x18
        public System.Int32 last;        // 0x1C
        public System.Int32 left;        // 0x20
        public System.Int32 right;        // 0x24

    }

    // TypeToken: 0x2000069
    public class IntervalTree`1
    {
        // Fields
        private static System.Int32 kMinNodeSize;        // 0x0
        private static System.Int32 kInvalidNode;        // 0x0
        private static System.Int64 kCenterUnknown;        // 0x0
        private readonly System.Collections.Generic.List<UnityEngine.Timeline.IntervalTree.Entry<T>> m_Entries;        // 0x0
        private readonly System.Collections.Generic.List<UnityEngine.Timeline.IntervalTreeNode> m_Nodes;        // 0x0
        private System.Boolean <dirty>k__BackingField;        // 0x0

        // Methods
        private System.Boolean get_dirty() { }
        private System.Void set_dirty(System.Boolean value) { }
        private System.Void Add(T item) { }
        private System.Void IntersectsWith(System.Int64 value, System.Collections.Generic.List<T> results) { }
        private System.Void IntersectsWithRange(System.Int64 start, System.Int64 end, System.Collections.Generic.List<T> results) { }
        private System.Void UpdateIntervals() { }
        private System.Void RuntimeReset() { }
        private System.Void Query(UnityEngine.Timeline.IntervalTreeNode intervalTreeNode, System.Int64 value, System.Collections.Generic.List<T> results) { }
        private System.Void QueryRange(UnityEngine.Timeline.IntervalTreeNode intervalTreeNode, System.Int64 start, System.Int64 end, System.Collections.Generic.List<T> results) { }
        private System.Void Rebuild() { }
        private System.Int32 Rebuild(System.Int32 start, System.Int32 end) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006B
    public class RuntimeClip : RuntimeClipBase
    {
        // Fields
        public System.Double runtimeLocalTimeOffset;        // 0x20
        public System.Double runtimeMixOutTime;        // 0x28
        public System.Double runtimeMixOutDuration;        // 0x30
        public System.Double runtimeMixInTime;        // 0x38
        public System.Double runtimeMixInDuration;        // 0x40
        public System.Boolean runtimeLooping;        // 0x48
        public System.Boolean runtimeLoopingMute;        // 0x49
        private System.Boolean _isInMixIn;        // 0x4A
        private System.Boolean _isMixIn;        // 0x4B
        private System.Boolean _hadIgniteOnce;        // 0x4C
        private System.Double lastTickTime;        // 0x50
        private System.Int32 <optionIndex>k__BackingField;        // 0x58
        private System.Int32 m_originalPort;        // 0x5C
        public System.Boolean isRuntimeJumpExhaust;        // 0x60
        private UnityEngine.Timeline.TimelineClip m_Clip;        // 0x68
        private UnityEngine.Playables.Playable m_Playable;        // 0x70
        private UnityEngine.Playables.Playable m_ParentMixer;        // 0x80
        private UnityEngine.Playables.Playable m_RootPlayable;        // 0x90
        private System.Boolean m_enabled;        // 0xA0

        // Methods
        private System.Int32 get_optionIndex() { }
        private System.Void set_optionIndex(System.Int32 value) { }
        private System.Boolean get_dynamicLink() { }
        private System.Double get_start() { }
        private System.Double get_end() { }
        private System.Double get_duration() { }
        private System.Void .ctor(UnityEngine.Timeline.TimelineClip clip, UnityEngine.Playables.Playable clipPlayable, UnityEngine.Playables.Playable parentMixer, System.Int32 originalPort) { }
        private System.Void Create(UnityEngine.Timeline.TimelineClip clip, UnityEngine.Playables.Playable clipPlayable, UnityEngine.Playables.Playable parentMixer, System.Int32 originalPort) { }
        private UnityEngine.Timeline.TimelineClip get_clip() { }
        private UnityEngine.Playables.Playable get_mixer() { }
        private UnityEngine.Playables.Playable get_playable() { }
        private System.Int64 get_intervalStart() { }
        private System.Int64 get_intervalEnd() { }
        private System.Void set_enable(System.Boolean value) { }
        private System.Boolean get_isEnabling() { }
        private System.Void SetTime(System.Double time) { }
        private System.Void SetDuration(System.Double duration) { }
        private System.Void EvaluateAt(System.Double localTime, UnityEngine.Playables.FrameData frameData) { }
        private System.Single EvaluateMixIn(System.Single localTime) { }
        private System.Single EvaluateMixOut(System.Single localTime) { }
        private System.Double ToLocalTime(System.Double localTime, UnityEngine.Playables.FrameData frameData) { }
        private System.Void DisableAt(System.Double localTime, System.Double rootDuration, UnityEngine.Playables.FrameData frameData) { }
        private System.Boolean CheckIfRuntimeTimeLoop(System.Boolean& canSkip, System.Double& reverseTime) { }
        private System.Boolean CheckIfRuntimeTimeJump(System.Double& jumpTime, System.Boolean& isReverseJump) { }
        private System.Void RuntimeLoopOver() { }
        private System.Void GetRuntimeCrossFadeDuration(System.Double& duration, System.Double& jumpTargetTime) { }
        private System.Void RecalculateRuntimeCrossFadeMixIn(System.Double mixInTime, System.Double mixInDuration) { }
        private System.Void RecalculateRuntimeCrossFadeMixOut(System.Double curTime, System.Double mixStartTime, System.Double mixDuration) { }
        private System.Boolean TryGetJumpClip(Beyond.Gameplay.Core.RuntimeJumpClip& jumpClip) { }
        private System.Void RuntimeReset() { }

    }

    // TypeToken: 0x200006C
    public class RuntimeClipBase : RuntimeElement
    {
        // Fields
        private System.Int32 <optionIndex>k__BackingField;        // 0x18

        // Methods
        private System.Double get_start() { }
        private System.Double get_duration() { }
        private System.Double get_end() { }
        private System.Int32 get_optionIndex() { }
        private System.Void set_optionIndex(System.Int32 value) { }
        private System.Int64 get_intervalStart() { }
        private System.Int64 get_intervalEnd() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006D
    public class RuntimeElement, IInterval, IOption, IRuntimeReset
    {
        // Fields
        private System.Int32 <intervalBit>k__BackingField;        // 0x10
        private System.Boolean <isLooping>k__BackingField;        // 0x14

        // Methods
        private System.Int64 get_intervalStart() { }
        private System.Int64 get_intervalEnd() { }
        private System.Int32 get_optionIndex() { }
        private System.Void set_optionIndex(System.Int32 value) { }
        private System.Int32 get_intervalBit() { }
        private System.Void set_intervalBit(System.Int32 value) { }
        private System.Boolean get_isLooping() { }
        private System.Void set_isLooping(System.Boolean value) { }
        private System.Void set_enable(System.Boolean value) { }
        private System.Void EvaluateAt(System.Double localTime, UnityEngine.Playables.FrameData frameData) { }
        private System.Void DisableAt(System.Double localTime, System.Double rootDuration, UnityEngine.Playables.FrameData frameData) { }
        private System.Boolean CheckIfRuntimeTimeLoop(System.Boolean& canSkip, System.Double& reverseTime) { }
        private System.Boolean CheckIfRuntimeTimeJump(System.Double& jumpTime, System.Boolean& isReverseJump) { }
        private System.Void RuntimeLoopOver() { }
        private System.Void GetRuntimeCrossFadeDuration(System.Double& duration, System.Double& jumpTargetTime) { }
        private System.Void RecalculateRuntimeCrossFadeMixIn(System.Double mixInTime, System.Double mixDuration) { }
        private System.Void RecalculateRuntimeCrossFadeMixOut(System.Double curTime, System.Double mixStartTime, System.Double mixDuration) { }
        private System.Void RuntimeReset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006E
    public class ScheduleRuntimeClip : RuntimeClipBase
    {
        // Fields
        private UnityEngine.Timeline.TimelineClip m_Clip;        // 0x20
        private UnityEngine.Playables.Playable m_Playable;        // 0x28
        private UnityEngine.Playables.Playable m_ParentMixer;        // 0x38
        private System.Double m_StartDelay;        // 0x48
        private System.Double m_FinishTail;        // 0x50
        private System.Boolean m_Started;        // 0x58

        // Methods
        private System.Double get_start() { }
        private System.Double get_duration() { }
        private System.Double get_end() { }
        private UnityEngine.Timeline.TimelineClip get_clip() { }
        private UnityEngine.Playables.Playable get_mixer() { }
        private UnityEngine.Playables.Playable get_playable() { }
        private System.Void .ctor(UnityEngine.Timeline.TimelineClip clip, UnityEngine.Playables.Playable clipPlayable, UnityEngine.Playables.Playable parentMixer, System.Double startDelay, System.Double finishTail) { }
        private System.Void Create(UnityEngine.Timeline.TimelineClip clip, UnityEngine.Playables.Playable clipPlayable, UnityEngine.Playables.Playable parentMixer, System.Double startDelay, System.Double finishTail) { }
        private System.Void set_enable(System.Boolean value) { }
        private System.Void EvaluateAt(System.Double localTime, UnityEngine.Playables.FrameData frameData) { }
        private System.Void DisableAt(System.Double localTime, System.Double rootDuration, UnityEngine.Playables.FrameData frameData) { }

    }

    // TypeToken: 0x200006F
    public interface IMarker
    {
        // Methods
        private System.Double get_time() { }
        private System.Void set_time(System.Double value) { }
        private UnityEngine.Timeline.TrackAsset get_parent() { }
        private System.Void Initialize(UnityEngine.Timeline.TrackAsset parent) { }

    }

    // TypeToken: 0x2000070
    public interface INotificationOptionProvider
    {
        // Methods
        private UnityEngine.Timeline.NotificationFlags get_flags() { }

    }

    // TypeToken: 0x2000071
    public class Marker : ScriptableObject, IMarker
    {
        // Fields
        private System.Double m_Time;        // 0x18
        private UnityEngine.Timeline.TrackAsset <parent>k__BackingField;        // 0x20

        // Methods
        private UnityEngine.Timeline.TrackAsset get_parent() { }
        private System.Void set_parent(UnityEngine.Timeline.TrackAsset value) { }
        private System.Double get_time() { }
        private System.Void set_time(System.Double value) { }
        private System.Void UnityEngine.Timeline.IMarker.Initialize(UnityEngine.Timeline.TrackAsset parentTrack) { }
        private System.Void OnInitialize(UnityEngine.Timeline.TrackAsset aPent) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000072
    public struct MarkerList, ISerializationCallbackReceiver
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.ScriptableObject> m_Objects;        // 0x10
        private System.Collections.Generic.List<UnityEngine.Timeline.IMarker> m_Cache;        // 0x18
        private System.Boolean m_CacheDirty;        // 0x20
        private System.Boolean m_HasNotifications;        // 0x21

        // Methods
        private System.Collections.Generic.List<UnityEngine.Timeline.IMarker> get_markers() { }
        private System.Void .ctor(System.Int32 capacity) { }
        private System.Void Add(UnityEngine.ScriptableObject item) { }
        private System.Boolean Remove(UnityEngine.Timeline.IMarker item) { }
        private System.Boolean Remove(UnityEngine.ScriptableObject item, UnityEngine.Timeline.TimelineAsset timelineAsset, UnityEngine.Playables.PlayableAsset thingToDirty) { }
        private System.Void Clear() { }
        private System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> GetMarkers() { }
        private System.Int32 get_Count() { }
        private UnityEngine.Timeline.IMarker get_Item(System.Int32 idx) { }
        private System.Collections.Generic.List<UnityEngine.ScriptableObject> GetRawMarkerList() { }
        private UnityEngine.Timeline.IMarker CreateMarker(System.Type type, System.Double time, UnityEngine.Timeline.TrackAsset owner) { }
        private System.Boolean HasNotifications() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        private System.Void BuildCache() { }

    }

    // TypeToken: 0x2000073
    public class MarkerTrack : TrackAsset, INotificationTrack
    {
        // Methods
        private System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000074
    public class CustomSignalEventDrawer : PropertyAttribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000075
    public class SignalAsset : ScriptableObject
    {
        // Fields
        private static System.Action<UnityEngine.Timeline.SignalAsset> OnEnableCallback;        // 0x0

        // Methods
        private System.Void add_OnEnableCallback(System.Action<UnityEngine.Timeline.SignalAsset> value) { }
        private System.Void remove_OnEnableCallback(System.Action<UnityEngine.Timeline.SignalAsset> value) { }
        private System.Void OnEnable() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000076
    public class SignalEmitter : Marker, INotification, INotificationOptionProvider
    {
        // Fields
        private System.Boolean m_Retroactive;        // 0x28
        private System.Boolean m_EmitOnce;        // 0x29
        private UnityEngine.Timeline.SignalAsset m_Asset;        // 0x30

        // Methods
        private System.Boolean get_retroactive() { }
        private System.Void set_retroactive(System.Boolean value) { }
        private System.Boolean get_emitOnce() { }
        private System.Void set_emitOnce(System.Boolean value) { }
        private UnityEngine.Timeline.SignalAsset get_asset() { }
        private System.Void set_asset(UnityEngine.Timeline.SignalAsset value) { }
        private UnityEngine.PropertyName UnityEngine.Playables.INotification.get_id() { }
        private UnityEngine.Timeline.NotificationFlags UnityEngine.Timeline.INotificationOptionProvider.get_flags() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000077
    public class SignalReceiver : MonoBehaviour, INotificationReceiver
    {
        // Fields
        private UnityEngine.Timeline.SignalReceiver.EventKeyValue m_Events;        // 0x18

        // Methods
        private System.Void OnNotify(UnityEngine.Playables.Playable origin, UnityEngine.Playables.INotification notification, System.Object context) { }
        private System.Void AddReaction(UnityEngine.Timeline.SignalAsset asset, UnityEngine.Events.UnityEvent reaction) { }
        private System.Int32 AddEmptyReaction(UnityEngine.Events.UnityEvent reaction) { }
        private System.Void Remove(UnityEngine.Timeline.SignalAsset asset) { }
        private System.Collections.Generic.IEnumerable<UnityEngine.Timeline.SignalAsset> GetRegisteredSignals() { }
        private UnityEngine.Events.UnityEvent GetReaction(UnityEngine.Timeline.SignalAsset key) { }
        private System.Int32 Count() { }
        private System.Void ChangeSignalAtIndex(System.Int32 idx, UnityEngine.Timeline.SignalAsset newKey) { }
        private System.Void RemoveAtIndex(System.Int32 idx) { }
        private System.Void ChangeReactionAtIndex(System.Int32 idx, UnityEngine.Events.UnityEvent reaction) { }
        private UnityEngine.Events.UnityEvent GetReactionAtIndex(System.Int32 idx) { }
        private UnityEngine.Timeline.SignalAsset GetSignalAssetAtIndex(System.Int32 idx) { }
        private System.Void OnEnable() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000079
    public class SignalTrack : MarkerTrack
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007A
    public class TrackAssetExtensions
    {
    }

    // TypeToken: 0x200007B
    public class GroupTrack : TrackAsset
    {
        // Fields
        public Beyond.PackageBridge.Timeline.TimelineConditionBase enableOnCondition;        // 0xC0

        // Methods
        private System.Void CalculateRuntimeMuted() { }
        private System.Boolean CanCompileClips() { }
        private System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007C
    public interface ILayerable
    {
        // Methods
        private UnityEngine.Playables.Playable CreateLayerMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount) { }

    }

    // TypeToken: 0x200007D
    public class ActivationControlPlayable : ControlPlayableBehaviour
    {
        // Fields
        public UnityEngine.GameObject gameObject;        // 0x10
        public UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState postPlayback;        // 0x18
        private UnityEngine.Timeline.ActivationControlPlayable.InitialState m_InitialState;        // 0x1C

        // Methods
        private UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.ActivationControlPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject gameObject, UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState postPlaybackState) { }
        private System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object userData) { }
        private System.Void OnGraphStart(UnityEngine.Playables.Playable playable) { }
        private System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable) { }
        private System.Void RuntimeReset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000080
    public class BasicPlayableBehaviour : ScriptableObject, IPlayableAsset, IPlayableBehaviour
    {
        // Methods
        private System.Double get_duration() { }
        private System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs() { }
        private System.Void OnGraphStart(UnityEngine.Playables.Playable playable) { }
        private System.Void OnGraphStop(UnityEngine.Playables.Playable playable) { }
        private System.Void OnPlayableCreate(UnityEngine.Playables.Playable playable) { }
        private System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable) { }
        private System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData) { }
        private UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000081
    public class ControlPlayableBehaviour : PlayableBehaviour, IBehaviourRuntimeReset
    {
        // Methods
        private System.Void RuntimeReset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000082
    public class DirectorControlPlayable : ControlPlayableBehaviour
    {
        // Fields
        public UnityEngine.Playables.PlayableDirector director;        // 0x10
        public UnityEngine.Timeline.ITimelineRootMarker rootMarker;        // 0x18
        private static System.Single SYNC_START_FORBID_THRESHOLD;        // 0x0
        private System.Boolean m_SyncTime;        // 0x20
        private System.Double m_AssetDuration;        // 0x28
        private UnityEngine.Timeline.TimelinePlayable m_TimelinePlayable;        // 0x30

        // Methods
        private UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.DirectorControlPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableDirector director) { }
        private System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable) { }
        private System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData) { }
        private System.Void SyncSpeed(System.Double speed) { }
        private System.Void SyncStart(UnityEngine.Playables.PlayableGraph graph, System.Double time) { }
        private System.Void SyncStop(UnityEngine.Playables.PlayableGraph graph, System.Double time) { }
        private System.Void RuntimeReset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000083
    public interface ITimeControl
    {
        // Methods
        private System.Void SetTime(System.Double time) { }
        private System.Void OnControlTimeStart() { }
        private System.Void OnControlTimeStop() { }

    }

    // TypeToken: 0x2000084
    public struct NotificationFlags
    {
        // Fields
        public System.Int16 value__;        // 0x10
        public static UnityEngine.Timeline.NotificationFlags TriggerInEditMode;        // 0x0
        public static UnityEngine.Timeline.NotificationFlags Retroactive;        // 0x0
        public static UnityEngine.Timeline.NotificationFlags TriggerOnce;        // 0x0

    }

    // TypeToken: 0x2000085
    public class ParticleControlPlayable : ControlPlayableBehaviour
    {
        // Fields
        private System.Single m_LastPlayableTime;        // 0x10
        private System.Single m_LastParticleTime;        // 0x14
        private System.UInt32 m_RandomSeed;        // 0x18
        private System.Boolean m_forceRuntimeSimulate;        // 0x1C
        private System.Single m_clipIn;        // 0x20
        private System.Boolean m_hadInitialized;        // 0x24
        private UnityEngine.ParticleSystem <particleSystem>k__BackingField;        // 0x28
        private System.Boolean m_hadIgnite;        // 0x30
        private System.Boolean m_hadSimulate;        // 0x31

        // Methods
        private UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.ParticleControlPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.ParticleSystem component, System.UInt32 randomSeed, System.Single clipIn, System.Single speedMultiplier, System.Boolean forceRuntimeSimulate) { }
        private UnityEngine.ParticleSystem get_particleSystem() { }
        private System.Void set_particleSystem(UnityEngine.ParticleSystem value) { }
        private System.Boolean get_shouldSimulate() { }
        private System.Void Initialize(UnityEngine.ParticleSystem ps, System.UInt32 randomSeed, System.Single clipIn, System.Single simulateSpeed, System.Boolean forceRuntimeSimulate) { }
        private System.Void SetSimulateSpeed(UnityEngine.ParticleSystem particleSystem, System.Double simulateSpeed) { }
        private System.Void SetRandomSeed(UnityEngine.ParticleSystem particleSystem, System.UInt32 randomSeed) { }
        private System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData data) { }
        private System.Void _SimulateParticle(System.Single time, System.Single particleTime, System.Boolean previewMode) { }
        private System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void _PlayOrQueuedParticleSystem() { }
        private System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void Simulate(System.Single time, System.Boolean restart) { }
        private System.Void RuntimeReset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000086
    public class PrefabControlPlayable : PlayableBehaviour
    {
        // Fields
        private UnityEngine.GameObject m_Instance;        // 0x10

        // Methods
        private UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.PrefabControlPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject prefabGameObject, UnityEngine.Transform parentTransform) { }
        private UnityEngine.GameObject get_prefabInstance() { }
        private UnityEngine.GameObject Initialize(UnityEngine.GameObject prefabGameObject, UnityEngine.Transform parentTransform) { }
        private System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable) { }
        private System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void SetHideFlagsRecursive(UnityEngine.GameObject gameObject) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000087
    public class TimeControlPlayable : ControlPlayableBehaviour
    {
        // Fields
        private UnityEngine.Timeline.ITimeControl m_timeControl;        // 0x10
        private System.Boolean m_started;        // 0x18

        // Methods
        private UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimeControlPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Timeline.ITimeControl timeControl) { }
        private System.Void Initialize(UnityEngine.Timeline.ITimeControl timeControl) { }
        private System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void RuntimeReset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000088
    public class TimeNotificationBehaviour : PlayableBehaviour
    {
        // Fields
        private readonly System.Collections.Generic.List<UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry> m_Notifications;        // 0x10
        private System.Double m_PreviousTime;        // 0x18
        private System.Boolean m_NeedSortNotifications;        // 0x20
        private UnityEngine.Playables.Playable m_TimeSource;        // 0x28

        // Methods
        private System.Void set_timeSource(UnityEngine.Playables.Playable value) { }
        private UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimeNotificationBehaviour> Create(UnityEngine.Playables.PlayableGraph graph, System.Double duration, UnityEngine.Playables.DirectorWrapMode loopMode) { }
        private System.Void AddNotification(System.Double time, UnityEngine.Playables.INotification payload, UnityEngine.Timeline.NotificationFlags flags) { }
        private System.Void OnGraphStart(UnityEngine.Playables.Playable playable) { }
        private System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void SortNotifications() { }
        private System.Boolean CanRestoreNotification(UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry e, UnityEngine.Playables.FrameData info, System.Double currentTime, System.Double previousTime) { }
        private System.Void TriggerNotificationsInRange(System.Double start, System.Double end, UnityEngine.Playables.FrameData info, UnityEngine.Playables.Playable playable, System.Boolean checkState) { }
        private System.Void SyncDurationWithExternalSource(UnityEngine.Playables.Playable playable) { }
        private System.Void Trigger_internal(UnityEngine.Playables.Playable playable, UnityEngine.Playables.PlayableOutput output, UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry& e) { }
        private System.Void Restore_internal(UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry& e) { }
        private System.Double _GetPlayableTime(UnityEngine.Playables.Playable playable) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008B
    public class CommunicatorParam
    {
        // Fields
        public UnityEngine.Timeline.IScriptAnimationJobSync jobSync;        // 0x10
        public System.String uniqueId;        // 0x18
        public System.Boolean lookAtUseAdditive;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008C
    public interface IAutoGenMono
    {
    }

    // TypeToken: 0x200008D
    public interface IBehaviourRuntimeReset
    {
    }

    // TypeToken: 0x200008E
    public interface IScriptAnimationJobSync : IAutoGenMono
    {
        // Methods
        private System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void CalcLayerMainStream(System.Single deltaTime) { }
        private System.Void ResetCloth(System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> activeRuntimeElements, System.Boolean useSoftReset, System.Boolean keepPose, System.Boolean useRelativeTeleport) { }

    }

    // TypeToken: 0x200008F
    public struct TimelineScriptAnimationJob, IAnimationJob
    {
        // Fields
        public UnityEngine.Timeline.IScriptAnimationJobSync bindedScriptAnimationJobSync;        // 0x10
        public UnityEngine.Animator bindedAnimator;        // 0x18

        // Methods
        private System.Void .ctor(UnityEngine.Timeline.IScriptAnimationJobSync job, UnityEngine.Animator animator) { }
        private System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }

    }

    // TypeToken: 0x2000090
    public class PlayableTrack : TrackAsset
    {
        // Methods
        private System.Void OnCreateClip(UnityEngine.Timeline.TimelineClip clip) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000091
    public class TrackMediaType : Attribute
    {
    }

    // TypeToken: 0x2000092
    public class TrackClipTypeAttribute : Attribute
    {
        // Fields
        public readonly System.Type inspectedType;        // 0x10
        public readonly System.Boolean allowAutoCreate;        // 0x18

        // Methods
        private System.Void .ctor(System.Type clipClass) { }
        private System.Void .ctor(System.Type clipClass, System.Boolean allowAutoCreate) { }

    }

    // TypeToken: 0x2000093
    public class NotKeyableAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000094
    public struct TrackBindingFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Timeline.TrackBindingFlags None;        // 0x0
        public static UnityEngine.Timeline.TrackBindingFlags AllowCreateComponent;        // 0x0
        public static UnityEngine.Timeline.TrackBindingFlags All;        // 0x0

    }

    // TypeToken: 0x2000095
    public class TrackBindingTypeAttribute : Attribute
    {
        // Fields
        public readonly System.Type type;        // 0x10
        public readonly UnityEngine.Timeline.TrackBindingFlags flags;        // 0x18

        // Methods
        private System.Void .ctor(System.Type type) { }
        private System.Void .ctor(System.Type type, UnityEngine.Timeline.TrackBindingFlags flags) { }

    }

    // TypeToken: 0x2000096
    public class SupportsChildTracksAttribute : Attribute
    {
        // Fields
        public readonly System.Type childType;        // 0x10
        public readonly System.Int32 levels;        // 0x18

        // Methods
        private System.Void .ctor(System.Type childType, System.Int32 levels) { }

    }

    // TypeToken: 0x2000097
    public class IgnoreOnPlayableTrackAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000098
    public class TimeFieldAttribute : PropertyAttribute
    {
        // Fields
        private readonly UnityEngine.Timeline.TimeFieldAttribute.UseEditMode <useEditMode>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.Timeline.TimeFieldAttribute.UseEditMode useEditMode) { }

    }

    // TypeToken: 0x200009A
    public class FrameRateFieldAttribute : PropertyAttribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009B
    public class HideInMenuAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009C
    public class CustomStyleAttribute : Attribute
    {
        // Fields
        public readonly System.String ussStyle;        // 0x10

        // Methods
        private System.Void .ctor(System.String ussStyle) { }

    }

    // TypeToken: 0x200009D
    public class MenuCategoryAttribute : Attribute
    {
    }

    // TypeToken: 0x200009E
    public interface ITimelineClipAsset
    {
        // Methods
        private UnityEngine.Timeline.ClipCaps get_clipCaps() { }

    }

    // TypeToken: 0x200009F
    public interface ITimelineEvaluateCallback
    {
        // Methods
        private System.Void Evaluate() { }

    }

    // TypeToken: 0x20000A0
    public class TimelinePlayable : PlayableBehaviour
    {
        // Fields
        public System.Double timeOffset;        // 0x10
        public System.Int32 newOptionIndex;        // 0x18
        public System.Int32 curOptionIndex;        // 0x1C
        public System.Int32 lastOptionIndex;        // 0x20
        public System.Boolean checkTimeJumpForNextSeek;        // 0x24
        private UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> m_IntervalTree;        // 0x28
        private System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> m_ActiveClips;        // 0x30
        private System.Collections.Generic.HashSet<UnityEngine.Timeline.RuntimeElement> m_ActiveClipsSet;        // 0x38
        private System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> m_CurrentListOfActiveClips;        // 0x40
        private System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> m_ActiveClipsCalcCache;        // 0x48
        private System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> m_RuntimeResetClipCache;        // 0x50
        private System.Int32 m_ActiveBit;        // 0x58
        private System.Boolean m_needEvaluateTwice;        // 0x5C
        private System.Boolean m_isTimelineEnded;        // 0x5D
        private System.Collections.Generic.List<UnityEngine.Timeline.ITimelineEvaluateCallback> m_EvaluateCallbacks;        // 0x60
        private System.Collections.Generic.Dictionary<UnityEngine.Timeline.TrackAsset,UnityEngine.Playables.Playable> m_PlayableCache;        // 0x68
        private UnityEngine.Playables.PlayableDirector m_TopDirector;        // 0x70
        private System.Collections.Generic.List<UnityEngine.Playables.PlayableDirector> m_AllDirectorUnderRoot;        // 0x78
        private UnityEngine.Playables.PlayableDirector m_DirectorHoldingThisPlayable;        // 0x80
        private UnityEngine.Timeline.ITimelineRootMarker m_RootMarker;        // 0x88
        private System.Collections.Generic.List<UnityEngine.Timeline.IScriptAnimationJobSync> m_ScriptAnimationJobSyncs;        // 0x90
        private static System.Boolean muteAudioScrubbing;        // 0x0
        private System.Double m_timeForNextFrame;        // 0x98

        // Methods
        private System.Double get_timeForNextFrame() { }
        private UnityEngine.Timeline.ITimelineRootMarker get_timelineRootMarker() { }
        private System.Boolean get_enableLoop() { }
        private UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimelinePlayable> Create(UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> tracks, UnityEngine.GameObject go, System.Boolean autoRebalance, System.Boolean createOutputs) { }
        private System.Void Compile(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable timelinePlayable, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> tracks, UnityEngine.GameObject go, System.Boolean autoRebalance, System.Boolean createOutputs) { }
        private System.Void MarkTimelineEnd() { }
        private System.Boolean IsTimelineEnded() { }
        private System.Void CompileCombineTopTopTrackList(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable timelinePlayable, System.Boolean createOutputs) { }
        private System.Void CollectCombineToTopTracksRecursive(UnityEngine.Timeline.TrackAsset track, System.Collections.Generic.List<UnityEngine.Timeline.TrackAsset> combineTracks) { }
        private System.Void CompileTrackList(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable timelinePlayable, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> tracks, UnityEngine.GameObject go, System.Boolean createOutputs, System.Boolean isCompilingCombineToTopTracks) { }
        private System.Void CreateTrackOutput(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Timeline.TrackAsset track, UnityEngine.GameObject go, UnityEngine.Playables.Playable playable, System.Int32 port) { }
        private System.Void EvaluateWeightsForAnimationPlayableOutput(UnityEngine.Timeline.TrackAsset track, UnityEngine.Animations.AnimationPlayableOutput animOutput, UnityEngine.Animator animator) { }
        private UnityEngine.Playables.Playable CreateTrackPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable timelinePlayable, UnityEngine.Timeline.TrackAsset track, UnityEngine.GameObject go, System.Boolean createOutputs) { }
        private System.Void UpdateIntervalTree() { }
        private System.Void RuntimeResetIntervalTree() { }
        private System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void _ResetScriptAnimationJobySyncs() { }
        private System.Void _EvaluateTwice() { }
        private System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> GetCurrentActiveClips() { }
        private System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> GetActiveClipsAtGivenTime(System.Double givenTime, System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> activeClips) { }
        private System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> GetActiveClipsAtGivenTimeRange(System.Double startTime, System.Double endTime, System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> activeClips) { }
        private System.Void Evaluate(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData frameData) { }
        private System.Boolean DoReverseLoop(System.Double reverseTime) { }
        private System.Boolean DoReverseJump(UnityEngine.Timeline.RuntimeClip runtimeClip, System.Double jumpTime) { }
        private System.Boolean DoJump(UnityEngine.Timeline.RuntimeClip runtimeClip, System.Double localTime, System.Double jumpTime) { }
        private System.Boolean _CheckIfTimeJumping(UnityEngine.Playables.FrameData frameData, System.Double localTime) { }
        private System.Void CacheTrack(UnityEngine.Timeline.TrackAsset track, UnityEngine.Playables.Playable playable, System.Int32 port, UnityEngine.Playables.Playable parent) { }
        private System.Void SetTimeForNextFrame(System.Double newTime) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000A1
    public class AnimationPreviewUtilities
    {
    }

    // TypeToken: 0x20000A2
    public class Extrapolation
    {
        // Fields
        private static readonly System.Double kMinExtrapolationTime;        // 0x0

        // Methods
        private System.Void CalculateExtrapolationTimes(UnityEngine.Timeline.TrackAsset asset) { }
        private UnityEngine.Timeline.TimelineClip[] SortClipsByStartTime(UnityEngine.Timeline.TimelineClip[] clips) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000A4
    public class HashUtility
    {
        // Methods
        private System.Int32 CombineHash(System.Int32 h1, System.Int32 h2) { }
        private System.Int32 CombineHash(System.Int32 h1, System.Int32 h2, System.Int32 h3) { }
        private System.Int32 CombineHash(System.Int32 h1, System.Int32 h2, System.Int32 h3, System.Int32 h4) { }
        private System.Int32 CombineHash(System.Int32 h1, System.Int32 h2, System.Int32 h3, System.Int32 h4, System.Int32 h5) { }
        private System.Int32 CombineHash(System.Int32 h1, System.Int32 h2, System.Int32 h3, System.Int32 h4, System.Int32 h5, System.Int32 h6) { }

    }

    // TypeToken: 0x20000A5
    public interface IPropertyCollector
    {
        // Methods
        private System.Void PushActiveGameObject(UnityEngine.GameObject gameObject) { }
        private System.Void PopActiveGameObject() { }
        private System.Void AddFromClip(UnityEngine.AnimationClip clip) { }
        private System.Void AddFromName(System.String name) { }
        private System.Void AddFromName(UnityEngine.GameObject obj, System.String name) { }
        private System.Void AddFromName(UnityEngine.GameObject obj, System.String name) { }
        private System.Void AddFromComponent(UnityEngine.GameObject obj, UnityEngine.Component component) { }
        private System.Void AddObjectProperties(UnityEngine.Object obj, UnityEngine.AnimationClip clip) { }

    }

    // TypeToken: 0x20000A6
    public interface IPropertyPreview
    {
        // Methods
        private System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver) { }

    }

    // TypeToken: 0x20000A7
    public class NotificationUtilities
    {
        // Methods
        private UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimeNotificationBehaviour> CreateNotificationsPlayable(UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> markers, System.Double duration, UnityEngine.Playables.DirectorWrapMode extrapolationMode) { }
        private System.Boolean TrackTypeSupportsNotifications(System.Type type) { }

    }

    // TypeToken: 0x20000A8
    public class PlayableDirectorUtility
    {
        // Methods
        private System.Void SetOptionIndexSingleDirector(UnityEngine.Playables.PlayableDirector director, System.Int32 curOptionIndex, System.Int32 lastOptionIndex) { }
        private UnityEngine.Timeline.TimelinePlayable GetTimelinePlayable(UnityEngine.Playables.PlayableDirector director) { }
        private UnityEngine.Timeline.TimelinePlayable GetTimelinePlayable(UnityEngine.Playables.PlayableGraph graph) { }
        private UnityEngine.Timeline.TimelinePlayable GetTimelinePlayableFromChildPlayable(UnityEngine.Playables.Playable playable) { }
        private System.Boolean CheckIfTimelineFunctional(UnityEngine.Playables.Playable playable) { }

    }

    // TypeToken: 0x20000A9
    public class TimelineClipExtensions
    {
        // Fields
        private static readonly System.String k_UndoSetParentTrackText;        // 0x0

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000AA
    public class TimelineCreateUtilities
    {
        // Methods
        private System.String GenerateUniqueActorName(System.Collections.Generic.List<UnityEngine.ScriptableObject> tracks, System.String name) { }
        private System.Void SaveAssetIntoObject(UnityEngine.Object childAsset, UnityEngine.Object masterAsset) { }
        private UnityEngine.AnimationClip CreateAnimationClipForTrack(System.String name, UnityEngine.Timeline.TrackAsset track, System.Boolean isLegacy) { }
        private System.Boolean ValidateParentTrack(UnityEngine.Timeline.TrackAsset parent, System.Type childType) { }

    }

    // TypeToken: 0x20000AD
    public class TimelineRuntimeUtils
    {
        // Methods
        private System.Boolean CheckWillRuntimeElementEnabled(UnityEngine.Timeline.RuntimeElement element, System.Int32 curOptionIndex, System.Int32 lastOptionIndex, System.Int64 curDiscreteTime) { }
        private System.Void DoReverseJump(UnityEngine.Timeline.RuntimeClip jumpClip, UnityEngine.Timeline.ITimelineRootMarker timelineRoot, System.Double curTime, System.Double jumpTime, System.Double mixDuration, System.Int32 curOptionIndex, System.Int32 lastOptionIndex, System.Boolean needChangeOptionAfterJump, System.Int32 newOptionIndex) { }
        private System.Void DoJump(UnityEngine.Timeline.RuntimeClip jumpClip, UnityEngine.Timeline.ITimelineRootMarker timelineRoot, System.Double curTime, System.Double jumpTime, System.Double mixDuration, System.Int32 curOptionIndex, System.Int32 lastOptionIndex, System.Boolean needChangeOptionAfterJump, System.Int32 optionIndexChangingTo) { }
        private System.Double GetSubDirectorTimeForDirectorControl(UnityEngine.Playables.Playable playable, UnityEngine.Playables.PlayableDirector director) { }
        private System.Void SetNewTimeForCutsceneRoot(UnityEngine.Timeline.ITimelineRootMarker timelineRoot, System.Double newTime, System.Boolean useThisTimeNextFrame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000AE
    public class TimelineUndo
    {
        // Methods
        private System.Void PushDestroyUndo(UnityEngine.Timeline.TimelineAsset timeline, UnityEngine.Object thingToDirty, UnityEngine.Object objectToDestroy) { }

    }

    // TypeToken: 0x20000AF
    public struct StandardFrameRates
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Timeline.StandardFrameRates Fps24;        // 0x0
        public static UnityEngine.Timeline.StandardFrameRates Fps23_97;        // 0x0
        public static UnityEngine.Timeline.StandardFrameRates Fps25;        // 0x0
        public static UnityEngine.Timeline.StandardFrameRates Fps30;        // 0x0
        public static UnityEngine.Timeline.StandardFrameRates Fps29_97;        // 0x0
        public static UnityEngine.Timeline.StandardFrameRates Fps50;        // 0x0
        public static UnityEngine.Timeline.StandardFrameRates Fps60;        // 0x0
        public static UnityEngine.Timeline.StandardFrameRates Fps59_94;        // 0x0

    }

    // TypeToken: 0x20000B0
    public class TimeUtility
    {
        // Fields
        public static readonly System.Double kTimeEpsilon;        // 0x0
        public static readonly System.Double kFrameRateEpsilon;        // 0x8
        public static readonly System.Double k_MaxTimelineDurationInSeconds;        // 0x10
        public static readonly System.Double kFrameRateRounding;        // 0x18

        // Methods
        private System.Double GetAnimationClipLength(UnityEngine.AnimationClip clip) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000B2
    public class WeightUtility
    {
        // Methods
        private System.Single NormalizeMixer(UnityEngine.Playables.Playable mixer) { }

    }

}

namespace UnityEngine.Timeline.Condition
{

    // TypeToken: 0x20000B3
    public class TimelineConditionControlMono : MonoBehaviour
    {
        // Fields
        public Beyond.PackageBridge.Timeline.TimelineConditionBase condition;        // 0x18

        // Methods
        private System.Void RefreshOnCondition() { }
        private System.Void .ctor() { }

    }

}

