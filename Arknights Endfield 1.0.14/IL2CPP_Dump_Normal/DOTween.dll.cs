// ========================================================
// Dumped by @desirepro
// Assembly: DOTween.dll
// Classes:  201
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000009
    public class CubicBezier
    {
        // Methods
        private UnityEngine.Vector3 GetPointOnSegment(UnityEngine.Vector3 startPoint, UnityEngine.Vector3 startControlPoint, UnityEngine.Vector3 endPoint, UnityEngine.Vector3 endControlPoint, System.Single factor) { }
        private UnityEngine.Vector3[] GetSegmentPointCloud(UnityEngine.Vector3 startPoint, UnityEngine.Vector3 startControlPoint, UnityEngine.Vector3 endPoint, UnityEngine.Vector3 endControlPoint, System.Int32 resolution) { }
        private System.Void GetSegmentPointCloud(System.Collections.Generic.List<UnityEngine.Vector3> addToList, UnityEngine.Vector3 startPoint, UnityEngine.Vector3 startControlPoint, UnityEngine.Vector3 endPoint, UnityEngine.Vector3 endControlPoint, System.Int32 resolution) { }

    }

    // TypeToken: 0x20000A3
    public class Sequence
    {
        // Methods
        private System.Void LogAddToNullSequence() { }
        private System.Void LogAddToInactiveSequence() { }
        private System.Void LogAddToLockedSequence() { }
        private System.Void LogAddNullTween() { }
        private System.Void LogAddInactiveTween(DG.Tweening.Tween t) { }
        private System.Void LogAddAlreadySequencedTween(DG.Tweening.Tween t) { }

    }

    // TypeToken: 0x20000AC
    public struct SettingsLocation
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.Core.DOTweenSettings.SettingsLocation AssetsDirectory;        // 0x0
        public static DG.Tweening.Core.DOTweenSettings.SettingsLocation DOTweenDirectory;        // 0x0
        public static DG.Tweening.Core.DOTweenSettings.SettingsLocation DemigiantDirectory;        // 0x0

    }

    // TypeToken: 0x20000AD
    public class SafeModeOptions
    {
        // Fields
        public DG.Tweening.Core.Enums.SafeModeLogBehaviour logBehaviour;        // 0x10
        public DG.Tweening.Core.Enums.NestedTweenFailureBehaviour nestedTweenFailureBehaviour;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000AE
    public class ModulesSetup
    {
        // Fields
        public System.Boolean showPanel;        // 0x10
        public System.Boolean audioEnabled;        // 0x11
        public System.Boolean physicsEnabled;        // 0x12
        public System.Boolean physics2DEnabled;        // 0x13
        public System.Boolean spriteEnabled;        // 0x14
        public System.Boolean uiEnabled;        // 0x15
        public System.Boolean textMeshProEnabled;        // 0x16
        public System.Boolean tk2DEnabled;        // 0x17
        public System.Boolean deAudioEnabled;        // 0x18
        public System.Boolean deUnityExtendedEnabled;        // 0x19
        public System.Boolean epoOutlineEnabled;        // 0x1A

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B2
    public struct SafeModeReportType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.Core.SafeModeReport.SafeModeReportType Unset;        // 0x0
        public static DG.Tweening.Core.SafeModeReport.SafeModeReportType TargetOrFieldMissing;        // 0x0
        public static DG.Tweening.Core.SafeModeReport.SafeModeReportType Callback;        // 0x0
        public static DG.Tweening.Core.SafeModeReport.SafeModeReportType StartupFailure;        // 0x0

    }

    // TypeToken: 0x20000B6
    public struct CapacityIncreaseMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.Core.TweenManager.CapacityIncreaseMode TweenersAndSequences;        // 0x0
        public static DG.Tweening.Core.TweenManager.CapacityIncreaseMode TweenersOnly;        // 0x0
        public static DG.Tweening.Core.TweenManager.CapacityIncreaseMode SequencesOnly;        // 0x0

    }

    // TypeToken: 0x20000C7
    public struct __StaticArrayInitTypeSize=20
    {
    }

    // TypeToken: 0x20000C8
    public struct __StaticArrayInitTypeSize=50
    {
    }

    // TypeToken: 0x20000C9
    public struct __StaticArrayInitTypeSize=120
    {
    }

namespace DG.Tweening
{

    // TypeToken: 0x2000002
    public struct AutoPlay
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.AutoPlay None;        // 0x0
        public static DG.Tweening.AutoPlay AutoPlaySequences;        // 0x0
        public static DG.Tweening.AutoPlay AutoPlayTweeners;        // 0x0
        public static DG.Tweening.AutoPlay All;        // 0x0

    }

    // TypeToken: 0x2000003
    public struct AxisConstraint
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.AxisConstraint None;        // 0x0
        public static DG.Tweening.AxisConstraint X;        // 0x0
        public static DG.Tweening.AxisConstraint Y;        // 0x0
        public static DG.Tweening.AxisConstraint Z;        // 0x0
        public static DG.Tweening.AxisConstraint W;        // 0x0

    }

    // TypeToken: 0x2000004
    public struct Color2
    {
        // Fields
        public UnityEngine.Color ca;        // 0x10
        public UnityEngine.Color cb;        // 0x20

        // Methods
        private System.Void .ctor(UnityEngine.Color ca, UnityEngine.Color cb) { }
        private DG.Tweening.Color2 op_Addition(DG.Tweening.Color2 c1, DG.Tweening.Color2 c2) { }
        private DG.Tweening.Color2 op_Subtraction(DG.Tweening.Color2 c1, DG.Tweening.Color2 c2) { }
        private DG.Tweening.Color2 op_Multiply(DG.Tweening.Color2 c1, System.Single f) { }

    }

    // TypeToken: 0x2000005
    public class TweenCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }
        private System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000006
    public class TweenCallback`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T value) { }
        private System.IAsyncResult BeginInvoke(T value, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000007
    public class EaseFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Single Invoke(System.Single time, System.Single duration, System.Single overshootOrAmplitude, System.Single period) { }
        private System.IAsyncResult BeginInvoke(System.Single time, System.Single duration, System.Single overshootOrAmplitude, System.Single period, System.AsyncCallback callback, System.Object object) { }
        private System.Single EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000008
    public class DOCurve
    {
    }

    // TypeToken: 0x200000A
    public class DOTween
    {
        // Fields
        public static readonly System.String Version;        // 0x0
        public static System.Boolean useSafeMode;        // 0x8
        public static DG.Tweening.Core.Enums.SafeModeLogBehaviour safeModeLogBehaviour;        // 0xC
        public static DG.Tweening.Core.Enums.NestedTweenFailureBehaviour nestedTweenFailureBehaviour;        // 0x10
        public static System.Boolean showUnityEditorReport;        // 0x14
        public static System.Single timeScale;        // 0x18
        public static System.Single unscaledTimeScale;        // 0x1C
        public static System.Boolean useSmoothDeltaTime;        // 0x20
        public static System.Single maxSmoothUnscaledTime;        // 0x24
        private static DG.Tweening.Core.Enums.RewindCallbackMode rewindCallbackMode;        // 0x28
        private static DG.Tweening.LogBehaviour _logBehaviour;        // 0x2C
        public static System.Func<UnityEngine.LogType,System.Object,System.Boolean> onWillLog;        // 0x30
        public static System.Boolean drawGizmos;        // 0x38
        public static System.Boolean debugMode;        // 0x39
        private static System.Boolean _fooDebugStoreTargetId;        // 0x3A
        public static DG.Tweening.UpdateType defaultUpdateType;        // 0x3C
        public static System.Boolean defaultTimeScaleIndependent;        // 0x40
        public static DG.Tweening.AutoPlay defaultAutoPlay;        // 0x44
        public static System.Boolean defaultAutoKill;        // 0x48
        public static DG.Tweening.LoopType defaultLoopType;        // 0x4C
        public static System.Boolean defaultRecyclable;        // 0x50
        public static DG.Tweening.Ease defaultEaseType;        // 0x54
        public static System.Single defaultEaseOvershootOrAmplitude;        // 0x58
        public static System.Single defaultEasePeriod;        // 0x5C
        public static DG.Tweening.Core.DOTweenComponent instance;        // 0x60
        private static System.Boolean _foo_isQuitting;        // 0x68
        private static System.Int32 maxActiveTweenersReached;        // 0x6C
        private static System.Int32 maxActiveSequencesReached;        // 0x70
        private static DG.Tweening.Core.SafeModeReport safeModeReport;        // 0x74
        private static readonly System.Collections.Generic.List<DG.Tweening.TweenCallback> GizmosDelegates;        // 0x88
        private static System.Boolean initialized;        // 0x90
        private static System.Int32 _isQuittingFrame;        // 0x94

        // Methods
        private DG.Tweening.LogBehaviour get_logBehaviour() { }
        private System.Void set_logBehaviour(DG.Tweening.LogBehaviour value) { }
        private System.Boolean get_debugStoreTargetId() { }
        private System.Void set_debugStoreTargetId(System.Boolean value) { }
        private System.Boolean get_isQuitting() { }
        private System.Void set_isQuitting(System.Boolean value) { }
        private DG.Tweening.IDOTweenInit Init(System.Nullable<System.Boolean> recycleAllByDefault, System.Nullable<System.Boolean> useSafeMode, System.Nullable<DG.Tweening.LogBehaviour> logBehaviour) { }
        private System.Void AutoInit() { }
        private DG.Tweening.IDOTweenInit Init(DG.Tweening.Core.DOTweenSettings settings, System.Nullable<System.Boolean> recycleAllByDefault, System.Nullable<System.Boolean> useSafeMode, System.Nullable<DG.Tweening.LogBehaviour> logBehaviour) { }
        private System.Void SetTweensCapacity(System.Int32 tweenersCapacity, System.Int32 sequencesCapacity) { }
        private System.Void Clear(System.Boolean destroy) { }
        private System.Void Clear(System.Boolean destroy, System.Boolean isApplicationQuitting) { }
        private System.Void ClearCachedTweens() { }
        private System.Int32 Validate() { }
        private System.Void ManualUpdate(System.Single deltaTime, System.Single unscaledDeltaTime) { }
        private DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> To(DG.Tweening.Core.DOGetter<System.Single> getter, DG.Tweening.Core.DOSetter<System.Single> setter, System.Single endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<System.Double,System.Double,DG.Tweening.Plugins.Options.NoOptions> To(DG.Tweening.Core.DOGetter<System.Double> getter, DG.Tweening.Core.DOSetter<System.Double> setter, System.Double endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<System.Int32,System.Int32,DG.Tweening.Plugins.Options.NoOptions> To(DG.Tweening.Core.DOGetter<System.Int32> getter, DG.Tweening.Core.DOSetter<System.Int32> setter, System.Int32 endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<System.UInt32,System.UInt32,DG.Tweening.Plugins.Options.UintOptions> To(DG.Tweening.Core.DOGetter<System.UInt32> getter, DG.Tweening.Core.DOSetter<System.UInt32> setter, System.UInt32 endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<System.Int64,System.Int64,DG.Tweening.Plugins.Options.NoOptions> To(DG.Tweening.Core.DOGetter<System.Int64> getter, DG.Tweening.Core.DOSetter<System.Int64> setter, System.Int64 endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<System.UInt64,System.UInt64,DG.Tweening.Plugins.Options.NoOptions> To(DG.Tweening.Core.DOGetter<System.UInt64> getter, DG.Tweening.Core.DOSetter<System.UInt64> setter, System.UInt64 endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<System.String,System.String,DG.Tweening.Plugins.Options.StringOptions> To(DG.Tweening.Core.DOGetter<System.String> getter, DG.Tweening.Core.DOSetter<System.String> setter, System.String endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Vector2> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector2> setter, UnityEngine.Vector2 endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, UnityEngine.Vector3 endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector4,UnityEngine.Vector4,DG.Tweening.Plugins.Options.VectorOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Vector4> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector4> setter, UnityEngine.Vector4 endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Vector3,DG.Tweening.Plugins.Options.QuaternionOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Quaternion> getter, DG.Tweening.Core.DOSetter<UnityEngine.Quaternion> setter, UnityEngine.Vector3 endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Color> getter, DG.Tweening.Core.DOSetter<UnityEngine.Color> setter, UnityEngine.Color endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Rect,UnityEngine.Rect,DG.Tweening.Plugins.Options.RectOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Rect> getter, DG.Tweening.Core.DOSetter<UnityEngine.Rect> setter, UnityEngine.Rect endValue, System.Single duration) { }
        private DG.Tweening.Tweener To(DG.Tweening.Core.DOGetter<UnityEngine.RectOffset> getter, DG.Tweening.Core.DOSetter<UnityEngine.RectOffset> setter, UnityEngine.RectOffset endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> To(DG.Tweening.Plugins.Core.ABSTweenPlugin<T1,T2,TPlugOptions> plugin, DG.Tweening.Core.DOGetter<T1> getter, DG.Tweening.Core.DOSetter<T1> setter, T2 endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> ToAxis(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, System.Single endValue, System.Single duration, DG.Tweening.AxisConstraint axisConstraint) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> ToAlpha(DG.Tweening.Core.DOGetter<UnityEngine.Color> getter, DG.Tweening.Core.DOSetter<UnityEngine.Color> setter, System.Single endValue, System.Single duration) { }
        private DG.Tweening.Tweener To(DG.Tweening.Core.DOSetter<System.Single> setter, System.Single startValue, System.Single endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> Punch(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, UnityEngine.Vector3 direction, System.Single duration, System.Int32 vibrato, System.Single elasticity) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> Shake(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, System.Single duration, System.Single strength, System.Int32 vibrato, System.Single randomness, System.Boolean ignoreZAxis, System.Boolean fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> Shake(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, System.Single duration, UnityEngine.Vector3 strength, System.Int32 vibrato, System.Single randomness, System.Boolean fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> Shake(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, System.Single duration, UnityEngine.Vector3 strength, System.Int32 vibrato, System.Single randomness, System.Boolean ignoreZAxis, System.Boolean vectorBased, System.Boolean fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> ToArray(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, UnityEngine.Vector3[] endValues, System.Single[] durations) { }
        private DG.Tweening.Core.TweenerCore<DG.Tweening.Color2,DG.Tweening.Color2,DG.Tweening.Plugins.Options.ColorOptions> To(DG.Tweening.Core.DOGetter<DG.Tweening.Color2> getter, DG.Tweening.Core.DOSetter<DG.Tweening.Color2> setter, DG.Tweening.Color2 endValue, System.Single duration) { }
        private DG.Tweening.Sequence Sequence() { }
        private DG.Tweening.Sequence Sequence(System.Object target) { }
        private System.Int32 CompleteAll(System.Boolean withCallbacks) { }
        private System.Int32 Complete(System.Object targetOrId, System.Boolean withCallbacks) { }
        private System.Int32 CompleteAndReturnKilledTot() { }
        private System.Int32 CompleteAndReturnKilledTot(System.Object targetOrId) { }
        private System.Int32 CompleteAndReturnKilledTot(System.Object target, System.Object id) { }
        private System.Int32 CompleteAndReturnKilledTotExceptFor(System.Object[] excludeTargetsOrIds) { }
        private System.Int32 FlipAll() { }
        private System.Int32 Flip(System.Object targetOrId) { }
        private System.Int32 GotoAll(System.Single to, System.Boolean andPlay) { }
        private System.Int32 Goto(System.Object targetOrId, System.Single to, System.Boolean andPlay) { }
        private System.Int32 KillAll(System.Boolean complete) { }
        private System.Int32 KillAll(System.Boolean complete, System.Object[] idsOrTargetsToExclude) { }
        private System.Int32 Kill(System.Object targetOrId, System.Boolean complete) { }
        private System.Int32 Kill(System.Object target, System.Object id, System.Boolean complete) { }
        private System.Int32 PauseAll() { }
        private System.Int32 Pause(System.Object targetOrId) { }
        private System.Int32 PlayAll() { }
        private System.Int32 Play(System.Object targetOrId) { }
        private System.Int32 Play(System.Object target, System.Object id) { }
        private System.Int32 PlayBackwardsAll() { }
        private System.Int32 PlayBackwards(System.Object targetOrId) { }
        private System.Int32 PlayBackwards(System.Object target, System.Object id) { }
        private System.Int32 PlayForwardAll() { }
        private System.Int32 PlayForward(System.Object targetOrId) { }
        private System.Int32 PlayForward(System.Object target, System.Object id) { }
        private System.Int32 RestartAll(System.Boolean includeDelay) { }
        private System.Int32 Restart(System.Object targetOrId, System.Boolean includeDelay, System.Single changeDelayTo) { }
        private System.Int32 Restart(System.Object target, System.Object id, System.Boolean includeDelay, System.Single changeDelayTo) { }
        private System.Int32 RewindAll(System.Boolean includeDelay) { }
        private System.Int32 Rewind(System.Object targetOrId, System.Boolean includeDelay) { }
        private System.Int32 SmoothRewindAll() { }
        private System.Int32 SmoothRewind(System.Object targetOrId) { }
        private System.Int32 TogglePauseAll() { }
        private System.Int32 TogglePause(System.Object targetOrId) { }
        private System.Boolean IsTweening(System.Object targetOrId, System.Boolean alsoCheckIfIsPlaying) { }
        private System.Int32 TotalActiveTweens() { }
        private System.Int32 TotalActiveTweeners() { }
        private System.Int32 TotalActiveSequences() { }
        private System.Int32 TotalPlayingTweens() { }
        private System.Int32 TotalTweensById(System.Object id, System.Boolean playingOnly) { }
        private System.Collections.Generic.List<DG.Tweening.Tween> PlayingTweens(System.Collections.Generic.List<DG.Tweening.Tween> fillableList) { }
        private System.Collections.Generic.List<DG.Tweening.Tween> PausedTweens(System.Collections.Generic.List<DG.Tweening.Tween> fillableList) { }
        private System.Collections.Generic.List<DG.Tweening.Tween> TweensById(System.Object id, System.Boolean playingOnly, System.Collections.Generic.List<DG.Tweening.Tween> fillableList) { }
        private System.Collections.Generic.List<DG.Tweening.Tween> TweensByTarget(System.Object target, System.Boolean playingOnly, System.Collections.Generic.List<DG.Tweening.Tween> fillableList) { }
        private System.Void InitCheck() { }
        private DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> ApplyTo(DG.Tweening.Core.DOGetter<T1> getter, DG.Tweening.Core.DOSetter<T1> setter, T2 endValue, System.Single duration, DG.Tweening.Plugins.Core.ABSTweenPlugin<T1,T2,TPlugOptions> plugin) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000C
    public class DOVirtual
    {
        // Methods
        private DG.Tweening.Tweener Float(System.Single from, System.Single to, System.Single duration, DG.Tweening.TweenCallback<System.Single> onVirtualUpdate) { }
        private DG.Tweening.Tweener Int(System.Int32 from, System.Int32 to, System.Single duration, DG.Tweening.TweenCallback<System.Int32> onVirtualUpdate) { }
        private DG.Tweening.Tweener Vector3(UnityEngine.Vector3 from, UnityEngine.Vector3 to, System.Single duration, DG.Tweening.TweenCallback<UnityEngine.Vector3> onVirtualUpdate) { }
        private DG.Tweening.Tweener Color(UnityEngine.Color from, UnityEngine.Color to, System.Single duration, DG.Tweening.TweenCallback<UnityEngine.Color> onVirtualUpdate) { }
        private System.Single EasedValue(System.Single from, System.Single to, System.Single lifetimePercentage, DG.Tweening.Ease easeType) { }
        private System.Single EasedValue(System.Single from, System.Single to, System.Single lifetimePercentage, DG.Tweening.Ease easeType, System.Single overshoot) { }
        private System.Single EasedValue(System.Single from, System.Single to, System.Single lifetimePercentage, DG.Tweening.Ease easeType, System.Single amplitude, System.Single period) { }
        private System.Single EasedValue(System.Single from, System.Single to, System.Single lifetimePercentage, UnityEngine.AnimationCurve easeCurve) { }
        private UnityEngine.Vector3 EasedValue(UnityEngine.Vector3 from, UnityEngine.Vector3 to, System.Single lifetimePercentage, DG.Tweening.Ease easeType) { }
        private UnityEngine.Vector3 EasedValue(UnityEngine.Vector3 from, UnityEngine.Vector3 to, System.Single lifetimePercentage, DG.Tweening.Ease easeType, System.Single overshoot) { }
        private UnityEngine.Vector3 EasedValue(UnityEngine.Vector3 from, UnityEngine.Vector3 to, System.Single lifetimePercentage, DG.Tweening.Ease easeType, System.Single amplitude, System.Single period) { }
        private UnityEngine.Vector3 EasedValue(UnityEngine.Vector3 from, UnityEngine.Vector3 to, System.Single lifetimePercentage, UnityEngine.AnimationCurve easeCurve) { }
        private DG.Tweening.Tween DelayedCall(System.Single delay, DG.Tweening.TweenCallback callback, System.Boolean ignoreTimeScale) { }

    }

    // TypeToken: 0x2000011
    public struct Ease
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.Ease Unset;        // 0x0
        public static DG.Tweening.Ease Linear;        // 0x0
        public static DG.Tweening.Ease InSine;        // 0x0
        public static DG.Tweening.Ease OutSine;        // 0x0
        public static DG.Tweening.Ease InOutSine;        // 0x0
        public static DG.Tweening.Ease InQuad;        // 0x0
        public static DG.Tweening.Ease OutQuad;        // 0x0
        public static DG.Tweening.Ease InOutQuad;        // 0x0
        public static DG.Tweening.Ease InCubic;        // 0x0
        public static DG.Tweening.Ease OutCubic;        // 0x0
        public static DG.Tweening.Ease InOutCubic;        // 0x0
        public static DG.Tweening.Ease InQuart;        // 0x0
        public static DG.Tweening.Ease OutQuart;        // 0x0
        public static DG.Tweening.Ease InOutQuart;        // 0x0
        public static DG.Tweening.Ease InQuint;        // 0x0
        public static DG.Tweening.Ease OutQuint;        // 0x0
        public static DG.Tweening.Ease InOutQuint;        // 0x0
        public static DG.Tweening.Ease InExpo;        // 0x0
        public static DG.Tweening.Ease OutExpo;        // 0x0
        public static DG.Tweening.Ease InOutExpo;        // 0x0
        public static DG.Tweening.Ease InCirc;        // 0x0
        public static DG.Tweening.Ease OutCirc;        // 0x0
        public static DG.Tweening.Ease InOutCirc;        // 0x0
        public static DG.Tweening.Ease InElastic;        // 0x0
        public static DG.Tweening.Ease OutElastic;        // 0x0
        public static DG.Tweening.Ease InOutElastic;        // 0x0
        public static DG.Tweening.Ease InBack;        // 0x0
        public static DG.Tweening.Ease OutBack;        // 0x0
        public static DG.Tweening.Ease InOutBack;        // 0x0
        public static DG.Tweening.Ease InBounce;        // 0x0
        public static DG.Tweening.Ease OutBounce;        // 0x0
        public static DG.Tweening.Ease InOutBounce;        // 0x0
        public static DG.Tweening.Ease Flash;        // 0x0
        public static DG.Tweening.Ease InFlash;        // 0x0
        public static DG.Tweening.Ease OutFlash;        // 0x0
        public static DG.Tweening.Ease InOutFlash;        // 0x0
        public static DG.Tweening.Ease INTERNAL_Zero;        // 0x0
        public static DG.Tweening.Ease INTERNAL_Custom;        // 0x0

    }

    // TypeToken: 0x2000012
    public class EaseFactory
    {
        // Methods
        private DG.Tweening.EaseFunction StopMotion(System.Int32 motionFps, System.Nullable<DG.Tweening.Ease> ease) { }
        private DG.Tweening.EaseFunction StopMotion(System.Int32 motionFps, UnityEngine.AnimationCurve animCurve) { }
        private DG.Tweening.EaseFunction StopMotion(System.Int32 motionFps, DG.Tweening.EaseFunction customEase) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000014
    public interface IDOTweenInit
    {
        // Methods
        private DG.Tweening.IDOTweenInit SetCapacity(System.Int32 tweenersCapacity, System.Int32 sequencesCapacity) { }

    }

    // TypeToken: 0x2000015
    public struct LinkBehaviour
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.LinkBehaviour PauseOnDisable;        // 0x0
        public static DG.Tweening.LinkBehaviour PauseOnDisablePlayOnEnable;        // 0x0
        public static DG.Tweening.LinkBehaviour PauseOnDisableRestartOnEnable;        // 0x0
        public static DG.Tweening.LinkBehaviour PlayOnEnable;        // 0x0
        public static DG.Tweening.LinkBehaviour RestartOnEnable;        // 0x0
        public static DG.Tweening.LinkBehaviour KillOnDisable;        // 0x0
        public static DG.Tweening.LinkBehaviour KillOnDestroy;        // 0x0
        public static DG.Tweening.LinkBehaviour CompleteOnDisable;        // 0x0
        public static DG.Tweening.LinkBehaviour CompleteAndKillOnDisable;        // 0x0
        public static DG.Tweening.LinkBehaviour RewindOnDisable;        // 0x0
        public static DG.Tweening.LinkBehaviour RewindAndKillOnDisable;        // 0x0

    }

    // TypeToken: 0x2000016
    public struct PathMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.PathMode Ignore;        // 0x0
        public static DG.Tweening.PathMode Full3D;        // 0x0
        public static DG.Tweening.PathMode TopDown2D;        // 0x0
        public static DG.Tweening.PathMode Sidescroller2D;        // 0x0

    }

    // TypeToken: 0x2000017
    public struct PathType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.PathType Linear;        // 0x0
        public static DG.Tweening.PathType CatmullRom;        // 0x0
        public static DG.Tweening.PathType CubicBezier;        // 0x0

    }

    // TypeToken: 0x2000018
    public struct RotateMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.RotateMode Fast;        // 0x0
        public static DG.Tweening.RotateMode FastBeyond360;        // 0x0
        public static DG.Tweening.RotateMode WorldAxisAdd;        // 0x0
        public static DG.Tweening.RotateMode LocalAxisAdd;        // 0x0

    }

    // TypeToken: 0x2000019
    public struct ScrambleMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.ScrambleMode None;        // 0x0
        public static DG.Tweening.ScrambleMode All;        // 0x0
        public static DG.Tweening.ScrambleMode Uppercase;        // 0x0
        public static DG.Tweening.ScrambleMode Lowercase;        // 0x0
        public static DG.Tweening.ScrambleMode Numerals;        // 0x0
        public static DG.Tweening.ScrambleMode Custom;        // 0x0

    }

    // TypeToken: 0x200001A
    public struct ShakeRandomnessMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.ShakeRandomnessMode Full;        // 0x0
        public static DG.Tweening.ShakeRandomnessMode Harmonic;        // 0x0

    }

    // TypeToken: 0x200001B
    public class TweenExtensions
    {
        // Methods
        private System.Void Complete(DG.Tweening.Tween t) { }
        private System.Void Complete(DG.Tweening.Tween t, System.Boolean withCallbacks) { }
        private System.Void Flip(DG.Tweening.Tween t) { }
        private System.Void ForceInit(DG.Tweening.Tween t) { }
        private System.Void Goto(DG.Tweening.Tween t, System.Single to, System.Boolean andPlay) { }
        private System.Void GotoWithCallbacks(DG.Tweening.Tween t, System.Single to, System.Boolean andPlay) { }
        private System.Void DoGoto(DG.Tweening.Tween t, System.Single to, System.Boolean andPlay, System.Boolean withCallbacks) { }
        private System.Void Kill(DG.Tweening.Tween t, System.Boolean complete) { }
        private System.Void ManualUpdate(DG.Tweening.Tween t, System.Single deltaTime, System.Single unscaledDeltaTime) { }
        private T Pause(T t) { }
        private T Play(T t) { }
        private System.Void PlayBackwards(DG.Tweening.Tween t) { }
        private System.Void PlayForward(DG.Tweening.Tween t) { }
        private System.Void Restart(DG.Tweening.Tween t, System.Boolean includeDelay, System.Single changeDelayTo) { }
        private System.Void Rewind(DG.Tweening.Tween t, System.Boolean includeDelay) { }
        private System.Void SmoothRewind(DG.Tweening.Tween t) { }
        private System.Void TogglePause(DG.Tweening.Tween t) { }
        private System.Void GotoWaypoint(DG.Tweening.Tween t, System.Int32 waypointIndex, System.Boolean andPlay) { }
        private UnityEngine.YieldInstruction WaitForCompletion(DG.Tweening.Tween t) { }
        private UnityEngine.YieldInstruction WaitForRewind(DG.Tweening.Tween t) { }
        private UnityEngine.YieldInstruction WaitForKill(DG.Tweening.Tween t) { }
        private UnityEngine.YieldInstruction WaitForElapsedLoops(DG.Tweening.Tween t, System.Int32 elapsedLoops) { }
        private UnityEngine.YieldInstruction WaitForPosition(DG.Tweening.Tween t, System.Single position) { }
        private UnityEngine.Coroutine WaitForStart(DG.Tweening.Tween t) { }
        private System.Int32 CompletedLoops(DG.Tweening.Tween t) { }
        private System.Single Delay(DG.Tweening.Tween t) { }
        private System.Single ElapsedDelay(DG.Tweening.Tween t) { }
        private System.Single Duration(DG.Tweening.Tween t, System.Boolean includeLoops) { }
        private System.Single Elapsed(DG.Tweening.Tween t, System.Boolean includeLoops) { }
        private System.Single ElapsedPercentage(DG.Tweening.Tween t, System.Boolean includeLoops) { }
        private System.Single ElapsedDirectionalPercentage(DG.Tweening.Tween t) { }
        private System.Boolean IsActive(DG.Tweening.Tween t) { }
        private System.Boolean IsBackwards(DG.Tweening.Tween t) { }
        private System.Boolean IsComplete(DG.Tweening.Tween t) { }
        private System.Boolean IsInitialized(DG.Tweening.Tween t) { }
        private System.Boolean IsPlaying(DG.Tweening.Tween t) { }
        private System.Int32 Loops(DG.Tweening.Tween t) { }
        private UnityEngine.Vector3 PathGetPoint(DG.Tweening.Tween t, System.Single pathPercentage) { }
        private UnityEngine.Vector3[] PathGetDrawPoints(DG.Tweening.Tween t, System.Int32 subdivisionsXSegment) { }
        private System.Single PathLength(DG.Tweening.Tween t) { }

    }

    // TypeToken: 0x200001C
    public struct LoopType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.LoopType Restart;        // 0x0
        public static DG.Tweening.LoopType Yoyo;        // 0x0
        public static DG.Tweening.LoopType Incremental;        // 0x0

    }

    // TypeToken: 0x200001D
    public class Sequence : Tween
    {
        // Fields
        private readonly System.Collections.Generic.List<DG.Tweening.Tween> sequencedTweens;        // 0x120
        private readonly System.Collections.Generic.List<DG.Tweening.Core.ABSSequentiable> _sequencedObjs;        // 0x128
        private System.Single lastTweenInsertTime;        // 0x130

        // Methods
        private System.Void .ctor() { }
        private DG.Tweening.Sequence DoPrepend(DG.Tweening.Sequence inSequence, DG.Tweening.Tween t) { }
        private DG.Tweening.Sequence DoInsert(DG.Tweening.Sequence inSequence, DG.Tweening.Tween t, System.Single atPosition) { }
        private DG.Tweening.Sequence DoAppendInterval(DG.Tweening.Sequence inSequence, System.Single interval) { }
        private DG.Tweening.Sequence DoPrependInterval(DG.Tweening.Sequence inSequence, System.Single interval) { }
        private DG.Tweening.Sequence DoInsertCallback(DG.Tweening.Sequence inSequence, DG.Tweening.TweenCallback callback, System.Single atPosition) { }
        private System.Single UpdateDelay(System.Single elapsed) { }
        private System.Void Reset() { }
        private System.Boolean Validate() { }
        private System.Boolean Startup() { }
        private System.Boolean ApplyTween(System.Single prevPosition, System.Int32 prevCompletedLoops, System.Int32 newCompletedSteps, System.Boolean useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode, DG.Tweening.Core.Enums.UpdateNotice updateNotice) { }
        private System.Void Setup(DG.Tweening.Sequence s) { }
        private System.Boolean DoStartup(DG.Tweening.Sequence s) { }
        private System.Boolean DoApplyTween(DG.Tweening.Sequence s, System.Single prevPosition, System.Int32 prevCompletedLoops, System.Int32 newCompletedSteps, System.Boolean useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode) { }
        private System.Boolean ApplyInternalCycle(DG.Tweening.Sequence s, System.Single fromPos, System.Single toPos, DG.Tweening.Core.Enums.UpdateMode updateMode, System.Boolean useInverse, System.Boolean prevPosIsInverse, System.Boolean multiCycleStep) { }
        private System.Void StableSortSequencedObjs(System.Collections.Generic.List<DG.Tweening.Core.ABSSequentiable> list) { }
        private System.Boolean IsAnyCallbackSet(DG.Tweening.Sequence s) { }

    }

    // TypeToken: 0x200001E
    public class ShortcutExtensions
    {
        // Methods
        private DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> DOAspect(UnityEngine.Camera target, System.Single endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Camera target, UnityEngine.Color endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> DOFarClipPlane(UnityEngine.Camera target, System.Single endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> DOFieldOfView(UnityEngine.Camera target, System.Single endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> DONearClipPlane(UnityEngine.Camera target, System.Single endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> DOOrthoSize(UnityEngine.Camera target, System.Single endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Rect,UnityEngine.Rect,DG.Tweening.Plugins.Options.RectOptions> DOPixelRect(UnityEngine.Camera target, UnityEngine.Rect endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Rect,UnityEngine.Rect,DG.Tweening.Plugins.Options.RectOptions> DORect(UnityEngine.Camera target, UnityEngine.Rect endValue, System.Single duration) { }
        private DG.Tweening.Tweener DOShakePosition(UnityEngine.Camera target, System.Single duration, System.Single strength, System.Int32 vibrato, System.Single randomness, System.Boolean fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode) { }
        private DG.Tweening.Tweener DOShakePosition(UnityEngine.Camera target, System.Single duration, UnityEngine.Vector3 strength, System.Int32 vibrato, System.Single randomness, System.Boolean fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode) { }
        private DG.Tweening.Tweener DOShakeRotation(UnityEngine.Camera target, System.Single duration, System.Single strength, System.Int32 vibrato, System.Single randomness, System.Boolean fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode) { }
        private DG.Tweening.Tweener DOShakeRotation(UnityEngine.Camera target, System.Single duration, UnityEngine.Vector3 strength, System.Int32 vibrato, System.Single randomness, System.Boolean fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Light target, UnityEngine.Color endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> DOIntensity(UnityEngine.Light target, System.Single endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> DOShadowStrength(UnityEngine.Light target, System.Single endValue, System.Single duration) { }
        private DG.Tweening.Tweener DOColor(UnityEngine.LineRenderer target, DG.Tweening.Color2 startValue, DG.Tweening.Color2 endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Material target, UnityEngine.Color endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Material target, UnityEngine.Color endValue, System.String property, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Material target, UnityEngine.Color endValue, System.Int32 propertyID, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.Material target, System.Single endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.Material target, System.Single endValue, System.String property, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.Material target, System.Single endValue, System.Int32 propertyID, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> DOFloat(UnityEngine.Material target, System.Single endValue, System.String property, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> DOFloat(UnityEngine.Material target, System.Single endValue, System.Int32 propertyID, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> DOOffset(UnityEngine.Material target, UnityEngine.Vector2 endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> DOOffset(UnityEngine.Material target, UnityEngine.Vector2 endValue, System.String property, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> DOTiling(UnityEngine.Material target, UnityEngine.Vector2 endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> DOTiling(UnityEngine.Material target, UnityEngine.Vector2 endValue, System.String property, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector4,UnityEngine.Vector4,DG.Tweening.Plugins.Options.VectorOptions> DOVector(UnityEngine.Material target, UnityEngine.Vector4 endValue, System.String property, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector4,UnityEngine.Vector4,DG.Tweening.Plugins.Options.VectorOptions> DOVector(UnityEngine.Material target, UnityEngine.Vector4 endValue, System.Int32 propertyID, System.Single duration) { }
        private DG.Tweening.Tweener DOResize(UnityEngine.TrailRenderer target, System.Single toStartWidth, System.Single toEndWidth, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> DOTime(UnityEngine.TrailRenderer target, System.Single endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> DOMove(UnityEngine.Transform target, UnityEngine.Vector3 endValue, System.Single duration, System.Boolean snapping) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> DOMoveX(UnityEngine.Transform target, System.Single endValue, System.Single duration, System.Boolean snapping) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> DOMoveY(UnityEngine.Transform target, System.Single endValue, System.Single duration, System.Boolean snapping) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> DOMoveZ(UnityEngine.Transform target, System.Single endValue, System.Single duration, System.Boolean snapping) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> DOLocalMove(UnityEngine.Transform target, UnityEngine.Vector3 endValue, System.Single duration, System.Boolean snapping) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> DOLocalMoveX(UnityEngine.Transform target, System.Single endValue, System.Single duration, System.Boolean snapping) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> DOLocalMoveY(UnityEngine.Transform target, System.Single endValue, System.Single duration, System.Boolean snapping) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> DOLocalMoveZ(UnityEngine.Transform target, System.Single endValue, System.Single duration, System.Boolean snapping) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Vector3,DG.Tweening.Plugins.Options.QuaternionOptions> DORotate(UnityEngine.Transform target, UnityEngine.Vector3 endValue, System.Single duration, DG.Tweening.RotateMode mode) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Quaternion,DG.Tweening.Plugins.Options.NoOptions> DORotateQuaternion(UnityEngine.Transform target, UnityEngine.Quaternion endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Vector3,DG.Tweening.Plugins.Options.QuaternionOptions> DOLocalRotate(UnityEngine.Transform target, UnityEngine.Vector3 endValue, System.Single duration, DG.Tweening.RotateMode mode) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Quaternion,DG.Tweening.Plugins.Options.NoOptions> DOLocalRotateQuaternion(UnityEngine.Transform target, UnityEngine.Quaternion endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> DOScale(UnityEngine.Transform target, UnityEngine.Vector3 endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> DOScale(UnityEngine.Transform target, System.Single endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> DOScaleX(UnityEngine.Transform target, System.Single endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> DOScaleY(UnityEngine.Transform target, System.Single endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> DOScaleZ(UnityEngine.Transform target, System.Single endValue, System.Single duration) { }
        private DG.Tweening.Tweener DOLookAt(UnityEngine.Transform target, UnityEngine.Vector3 towards, System.Single duration, DG.Tweening.AxisConstraint axisConstraint, System.Nullable<UnityEngine.Vector3> up) { }
        private DG.Tweening.Tweener DODynamicLookAt(UnityEngine.Transform target, UnityEngine.Vector3 towards, System.Single duration, DG.Tweening.AxisConstraint axisConstraint, System.Nullable<UnityEngine.Vector3> up) { }
        private DG.Tweening.Tweener LookAt(UnityEngine.Transform target, UnityEngine.Vector3 towards, System.Single duration, DG.Tweening.AxisConstraint axisConstraint, System.Nullable<UnityEngine.Vector3> up, System.Boolean dynamic) { }
        private DG.Tweening.Tweener DOPunchPosition(UnityEngine.Transform target, UnityEngine.Vector3 punch, System.Single duration, System.Int32 vibrato, System.Single elasticity, System.Boolean snapping) { }
        private DG.Tweening.Tweener DOPunchScale(UnityEngine.Transform target, UnityEngine.Vector3 punch, System.Single duration, System.Int32 vibrato, System.Single elasticity) { }
        private DG.Tweening.Tweener DOPunchRotation(UnityEngine.Transform target, UnityEngine.Vector3 punch, System.Single duration, System.Int32 vibrato, System.Single elasticity) { }
        private DG.Tweening.Tweener DOShakePosition(UnityEngine.Transform target, System.Single duration, System.Single strength, System.Int32 vibrato, System.Single randomness, System.Boolean snapping, System.Boolean fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode) { }
        private DG.Tweening.Tweener DOShakePosition(UnityEngine.Transform target, System.Single duration, UnityEngine.Vector3 strength, System.Int32 vibrato, System.Single randomness, System.Boolean snapping, System.Boolean fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode) { }
        private DG.Tweening.Tweener DOShakeRotation(UnityEngine.Transform target, System.Single duration, System.Single strength, System.Int32 vibrato, System.Single randomness, System.Boolean fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode) { }
        private DG.Tweening.Tweener DOShakeRotation(UnityEngine.Transform target, System.Single duration, UnityEngine.Vector3 strength, System.Int32 vibrato, System.Single randomness, System.Boolean fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode) { }
        private DG.Tweening.Tweener DOShakeScale(UnityEngine.Transform target, System.Single duration, System.Single strength, System.Int32 vibrato, System.Single randomness, System.Boolean fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode) { }
        private DG.Tweening.Tweener DOShakeScale(UnityEngine.Transform target, System.Single duration, UnityEngine.Vector3 strength, System.Int32 vibrato, System.Single randomness, System.Boolean fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode) { }
        private DG.Tweening.Sequence DOJump(UnityEngine.Transform target, UnityEngine.Vector3 endValue, System.Single jumpPower, System.Int32 numJumps, System.Single duration, System.Boolean snapping) { }
        private DG.Tweening.Sequence DOLocalJump(UnityEngine.Transform target, UnityEngine.Vector3 endValue, System.Single jumpPower, System.Int32 numJumps, System.Single duration, System.Boolean snapping) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Transform target, UnityEngine.Vector3[] path, System.Single duration, DG.Tweening.PathType pathType, DG.Tweening.PathMode pathMode, System.Int32 resolution, System.Nullable<UnityEngine.Color> gizmoColor) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Transform target, UnityEngine.Vector3[] path, System.Single duration, DG.Tweening.PathType pathType, DG.Tweening.PathMode pathMode, System.Int32 resolution, System.Nullable<UnityEngine.Color> gizmoColor) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Transform target, DG.Tweening.Plugins.Core.PathCore.Path path, System.Single duration, DG.Tweening.PathMode pathMode) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Transform target, DG.Tweening.Plugins.Core.PathCore.Path path, System.Single duration, DG.Tweening.PathMode pathMode) { }
        private DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> DOTimeScale(DG.Tweening.Tween target, System.Single endValue, System.Single duration) { }
        private DG.Tweening.Tweener DOBlendableColor(UnityEngine.Light target, UnityEngine.Color endValue, System.Single duration) { }
        private DG.Tweening.Tweener DOBlendableColor(UnityEngine.Material target, UnityEngine.Color endValue, System.Single duration) { }
        private DG.Tweening.Tweener DOBlendableColor(UnityEngine.Material target, UnityEngine.Color endValue, System.String property, System.Single duration) { }
        private DG.Tweening.Tweener DOBlendableColor(UnityEngine.Material target, UnityEngine.Color endValue, System.Int32 propertyID, System.Single duration) { }
        private DG.Tweening.Tweener DOBlendableMoveBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, System.Single duration, System.Boolean snapping) { }
        private DG.Tweening.Tweener DOBlendableLocalMoveBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, System.Single duration, System.Boolean snapping) { }
        private DG.Tweening.Tweener DOBlendableRotateBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, System.Single duration, DG.Tweening.RotateMode mode) { }
        private DG.Tweening.Tweener DOBlendableLocalRotateBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, System.Single duration, DG.Tweening.RotateMode mode) { }
        private DG.Tweening.Tweener DOBlendablePunchRotation(UnityEngine.Transform target, UnityEngine.Vector3 punch, System.Single duration, System.Int32 vibrato, System.Single elasticity) { }
        private DG.Tweening.Tweener DOBlendableScaleBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, System.Single duration) { }
        private System.Int32 DOComplete(UnityEngine.Component target, System.Boolean withCallbacks) { }
        private System.Int32 DOComplete(UnityEngine.Material target, System.Boolean withCallbacks) { }
        private System.Int32 DOKill(UnityEngine.Component target, System.Boolean complete) { }
        private System.Int32 DOKill(UnityEngine.Material target, System.Boolean complete) { }
        private System.Int32 DOFlip(UnityEngine.Component target) { }
        private System.Int32 DOFlip(UnityEngine.Material target) { }
        private System.Int32 DOGoto(UnityEngine.Component target, System.Single to, System.Boolean andPlay) { }
        private System.Int32 DOGoto(UnityEngine.Material target, System.Single to, System.Boolean andPlay) { }
        private System.Int32 DOPause(UnityEngine.Component target) { }
        private System.Int32 DOPause(UnityEngine.Material target) { }
        private System.Int32 DOPlay(UnityEngine.Component target) { }
        private System.Int32 DOPlay(UnityEngine.Material target) { }
        private System.Int32 DOPlayBackwards(UnityEngine.Component target) { }
        private System.Int32 DOPlayBackwards(UnityEngine.Material target) { }
        private System.Int32 DOPlayForward(UnityEngine.Component target) { }
        private System.Int32 DOPlayForward(UnityEngine.Material target) { }
        private System.Int32 DORestart(UnityEngine.Component target, System.Boolean includeDelay) { }
        private System.Int32 DORestart(UnityEngine.Material target, System.Boolean includeDelay) { }
        private System.Int32 DORewind(UnityEngine.Component target, System.Boolean includeDelay) { }
        private System.Int32 DORewind(UnityEngine.Material target, System.Boolean includeDelay) { }
        private System.Int32 DOSmoothRewind(UnityEngine.Component target) { }
        private System.Int32 DOSmoothRewind(UnityEngine.Material target) { }
        private System.Int32 DOTogglePause(UnityEngine.Component target) { }
        private System.Int32 DOTogglePause(UnityEngine.Material target) { }

    }

    // TypeToken: 0x200006B
    public class TweenParams
    {
        // Fields
        public static readonly DG.Tweening.TweenParams Params;        // 0x0
        private System.Object id;        // 0x10
        private System.String stringId;        // 0x18
        private System.Int32 intId;        // 0x20
        private System.Object target;        // 0x28
        private DG.Tweening.UpdateType updateType;        // 0x30
        private System.Boolean isIndependentUpdate;        // 0x34
        private DG.Tweening.TweenCallback onStart;        // 0x38
        private DG.Tweening.TweenCallback onPlay;        // 0x40
        private DG.Tweening.TweenCallback onRewind;        // 0x48
        private DG.Tweening.TweenCallback onUpdate;        // 0x50
        private DG.Tweening.TweenCallback onStepComplete;        // 0x58
        private DG.Tweening.TweenCallback onComplete;        // 0x60
        private DG.Tweening.TweenCallback onKill;        // 0x68
        private DG.Tweening.TweenCallback<System.Int32> onWaypointChange;        // 0x70
        private System.Boolean isRecyclable;        // 0x78
        private System.Boolean isSpeedBased;        // 0x79
        private System.Boolean autoKill;        // 0x7A
        private System.Int32 loops;        // 0x7C
        private DG.Tweening.LoopType loopType;        // 0x80
        private System.Single delay;        // 0x84
        private System.Boolean isRelative;        // 0x88
        private DG.Tweening.Ease easeType;        // 0x8C
        private DG.Tweening.EaseFunction customEase;        // 0x90
        private System.Single easeOvershootOrAmplitude;        // 0x98
        private System.Single easePeriod;        // 0x9C

        // Methods
        private System.Void .ctor() { }
        private DG.Tweening.TweenParams Clear() { }
        private DG.Tweening.TweenParams SetAutoKill(System.Boolean autoKillOnCompletion) { }
        private DG.Tweening.TweenParams SetId(System.Object objectId) { }
        private DG.Tweening.TweenParams SetId(System.String stringId) { }
        private DG.Tweening.TweenParams SetId(System.Int32 intId) { }
        private DG.Tweening.TweenParams SetTarget(System.Object target) { }
        private DG.Tweening.TweenParams SetLoops(System.Int32 loops, System.Nullable<DG.Tweening.LoopType> loopType) { }
        private DG.Tweening.TweenParams SetEase(DG.Tweening.Ease ease, System.Nullable<System.Single> overshootOrAmplitude, System.Nullable<System.Single> period) { }
        private DG.Tweening.TweenParams SetEase(UnityEngine.AnimationCurve animCurve) { }
        private DG.Tweening.TweenParams SetEase(DG.Tweening.EaseFunction customEase) { }
        private DG.Tweening.TweenParams SetRecyclable(System.Boolean recyclable) { }
        private DG.Tweening.TweenParams SetUpdate(System.Boolean isIndependentUpdate) { }
        private DG.Tweening.TweenParams SetUpdate(DG.Tweening.UpdateType updateType, System.Boolean isIndependentUpdate) { }
        private DG.Tweening.TweenParams OnStart(DG.Tweening.TweenCallback action) { }
        private DG.Tweening.TweenParams OnPlay(DG.Tweening.TweenCallback action) { }
        private DG.Tweening.TweenParams OnRewind(DG.Tweening.TweenCallback action) { }
        private DG.Tweening.TweenParams OnUpdate(DG.Tweening.TweenCallback action) { }
        private DG.Tweening.TweenParams OnStepComplete(DG.Tweening.TweenCallback action) { }
        private DG.Tweening.TweenParams OnComplete(DG.Tweening.TweenCallback action) { }
        private DG.Tweening.TweenParams OnKill(DG.Tweening.TweenCallback action) { }
        private DG.Tweening.TweenParams OnWaypointChange(DG.Tweening.TweenCallback<System.Int32> action) { }
        private DG.Tweening.TweenParams SetDelay(System.Single delay) { }
        private DG.Tweening.TweenParams SetRelative(System.Boolean isRelative) { }
        private DG.Tweening.TweenParams SetSpeedBased(System.Boolean isSpeedBased) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200006C
    public class TweenSettingsExtensions
    {
        // Methods
        private T SetAutoKill(T t) { }
        private T SetAutoKill(T t, System.Boolean autoKillOnCompletion) { }
        private T SetId(T t, System.Object objectId) { }
        private T SetId(T t, System.String stringId) { }
        private T SetId(T t, System.Int32 intId) { }
        private T SetLink(T t, UnityEngine.GameObject gameObject) { }
        private T SetLink(T t, UnityEngine.GameObject gameObject, DG.Tweening.LinkBehaviour behaviour) { }
        private T SetTarget(T t, System.Object target) { }
        private T SetLoops(T t, System.Int32 loops) { }
        private T SetLoops(T t, System.Int32 loops, DG.Tweening.LoopType loopType) { }
        private T SetEase(T t, DG.Tweening.Ease ease) { }
        private T SetEase(T t, DG.Tweening.Ease ease, System.Single overshoot) { }
        private T SetEase(T t, DG.Tweening.Ease ease, System.Single amplitude, System.Single period) { }
        private T SetEase(T t, UnityEngine.AnimationCurve animCurve) { }
        private T SetEase(T t, DG.Tweening.EaseFunction customEase) { }
        private T SetRecyclable(T t) { }
        private T SetRecyclable(T t, System.Boolean recyclable) { }
        private T SetUpdate(T t, System.Boolean isIndependentUpdate) { }
        private T SetUpdate(T t, DG.Tweening.UpdateType updateType) { }
        private T SetUpdate(T t, DG.Tweening.UpdateType updateType, System.Boolean isIndependentUpdate) { }
        private T SetInverted(T t) { }
        private T SetInverted(T t, System.Boolean inverted) { }
        private T OnStart(T t, DG.Tweening.TweenCallback action) { }
        private T OnPlay(T t, DG.Tweening.TweenCallback action) { }
        private T OnPause(T t, DG.Tweening.TweenCallback action) { }
        private T OnRewind(T t, DG.Tweening.TweenCallback action) { }
        private T OnUpdate(T t, DG.Tweening.TweenCallback action) { }
        private T OnStepComplete(T t, DG.Tweening.TweenCallback action) { }
        private T OnComplete(T t, DG.Tweening.TweenCallback action) { }
        private T OnKill(T t, DG.Tweening.TweenCallback action) { }
        private T OnWaypointChange(T t, DG.Tweening.TweenCallback<System.Int32> action) { }
        private T SetAs(T t, DG.Tweening.Tween asTween) { }
        private T SetAs(T t, DG.Tweening.TweenParams tweenParams) { }
        private DG.Tweening.Sequence Append(DG.Tweening.Sequence s, DG.Tweening.Tween t) { }
        private DG.Tweening.Sequence Prepend(DG.Tweening.Sequence s, DG.Tweening.Tween t) { }
        private DG.Tweening.Sequence Join(DG.Tweening.Sequence s, DG.Tweening.Tween t) { }
        private DG.Tweening.Sequence Insert(DG.Tweening.Sequence s, System.Single atPosition, DG.Tweening.Tween t) { }
        private DG.Tweening.Sequence AppendInterval(DG.Tweening.Sequence s, System.Single interval) { }
        private DG.Tweening.Sequence PrependInterval(DG.Tweening.Sequence s, System.Single interval) { }
        private DG.Tweening.Sequence AppendCallback(DG.Tweening.Sequence s, DG.Tweening.TweenCallback callback) { }
        private DG.Tweening.Sequence PrependCallback(DG.Tweening.Sequence s, DG.Tweening.TweenCallback callback) { }
        private DG.Tweening.Sequence InsertCallback(DG.Tweening.Sequence s, System.Single atPosition, DG.Tweening.TweenCallback callback) { }
        private System.Boolean ValidateAddToSequence(DG.Tweening.Sequence s, DG.Tweening.Tween t, System.Boolean ignoreTween) { }
        private T From(T t) { }
        private T From(T t, System.Boolean isRelative) { }
        private T From(T t, System.Boolean setImmediately, System.Boolean isRelative) { }
        private DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> From(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t, T2 fromValue, System.Boolean setImmediately, System.Boolean isRelative) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> From(DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> t, System.Single fromAlphaValue, System.Boolean setImmediately, System.Boolean isRelative) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> From(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> t, System.Single fromValue, System.Boolean setImmediately, System.Boolean isRelative) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions> From(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions> t, System.Single fromValueDegrees, System.Boolean setImmediately, System.Boolean isRelative) { }
        private T SetDelay(T t, System.Single delay) { }
        private T SetDelay(T t, System.Single delay, System.Boolean asPrependedIntervalIfSequence) { }
        private T SetRelative(T t) { }
        private T SetRelative(T t, System.Boolean isRelative) { }
        private T SetSpeedBased(T t) { }
        private T SetSpeedBased(T t, System.Boolean isSpeedBased) { }
        private DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> t, System.Boolean snapping) { }
        private DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> t, System.Boolean snapping) { }
        private DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> t, DG.Tweening.AxisConstraint axisConstraint, System.Boolean snapping) { }
        private DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> t, System.Boolean snapping) { }
        private DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> t, DG.Tweening.AxisConstraint axisConstraint, System.Boolean snapping) { }
        private DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4,UnityEngine.Vector4,DG.Tweening.Plugins.Options.VectorOptions> t, System.Boolean snapping) { }
        private DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4,UnityEngine.Vector4,DG.Tweening.Plugins.Options.VectorOptions> t, DG.Tweening.AxisConstraint axisConstraint, System.Boolean snapping) { }
        private DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Vector3,DG.Tweening.Plugins.Options.QuaternionOptions> t, System.Boolean useShortest360Route) { }
        private DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> t, System.Boolean alphaOnly) { }
        private DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Rect,UnityEngine.Rect,DG.Tweening.Plugins.Options.RectOptions> t, System.Boolean snapping) { }
        private DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<System.String,System.String,DG.Tweening.Plugins.Options.StringOptions> t, System.Boolean richTextEnabled, DG.Tweening.ScrambleMode scrambleMode, System.String scrambleChars) { }
        private DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, System.Boolean snapping) { }
        private DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, DG.Tweening.AxisConstraint axisConstraint, System.Boolean snapping) { }
        private DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions> t, System.Single endValueDegrees, System.Boolean relativeCenter, System.Boolean snapping) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t, DG.Tweening.AxisConstraint lockPosition, DG.Tweening.AxisConstraint lockRotation) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t, System.Boolean closePath, DG.Tweening.AxisConstraint lockPosition, DG.Tweening.AxisConstraint lockRotation) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Vector3 lookAtPosition, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Vector3 lookAtPosition, System.Boolean stableZRotation) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Transform lookAtTransform, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Transform lookAtTransform, System.Boolean stableZRotation) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t, System.Single lookAhead, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t, System.Single lookAhead, System.Boolean stableZRotation) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t, DG.Tweening.Plugins.Options.OrientType orientType, UnityEngine.Vector3 lookAtPosition, UnityEngine.Transform lookAtTransform, System.Single lookAhead, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up, System.Boolean stableZRotation) { }
        private System.Void SetPathForwardDirection(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up) { }

    }

    // TypeToken: 0x200006D
    public struct LogBehaviour
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.LogBehaviour Default;        // 0x0
        public static DG.Tweening.LogBehaviour Verbose;        // 0x0
        public static DG.Tweening.LogBehaviour ErrorsOnly;        // 0x0

    }

    // TypeToken: 0x200006E
    public class Tween : ABSSequentiable
    {
        // Fields
        public System.Single timeScale;        // 0x28
        public System.Boolean isBackwards;        // 0x2C
        private System.Boolean isInverted;        // 0x2D
        public System.Object id;        // 0x30
        public System.String stringId;        // 0x38
        public System.Int32 intId;        // 0x40
        public System.Object target;        // 0x48
        private DG.Tweening.UpdateType updateType;        // 0x50
        private System.Boolean isIndependentUpdate;        // 0x54
        public DG.Tweening.TweenCallback onPlay;        // 0x58
        public DG.Tweening.TweenCallback onPause;        // 0x60
        public DG.Tweening.TweenCallback onRewind;        // 0x68
        public DG.Tweening.TweenCallback onUpdate;        // 0x70
        public DG.Tweening.TweenCallback onStepComplete;        // 0x78
        public DG.Tweening.TweenCallback onComplete;        // 0x80
        public DG.Tweening.TweenCallback onKill;        // 0x88
        public DG.Tweening.TweenCallback<System.Int32> onWaypointChange;        // 0x90
        private System.Boolean isFrom;        // 0x98
        private System.Boolean isBlendable;        // 0x99
        private System.Boolean isRecyclable;        // 0x9A
        private System.Boolean isSpeedBased;        // 0x9B
        private System.Boolean autoKill;        // 0x9C
        private System.Single duration;        // 0xA0
        private System.Int32 loops;        // 0xA4
        private DG.Tweening.LoopType loopType;        // 0xA8
        private System.Single delay;        // 0xAC
        private System.Boolean <isRelative>k__BackingField;        // 0xB0
        private DG.Tweening.Ease easeType;        // 0xB4
        private DG.Tweening.EaseFunction customEase;        // 0xB8
        public System.Single easeOvershootOrAmplitude;        // 0xC0
        public System.Single easePeriod;        // 0xC4
        public System.String debugTargetId;        // 0xC8
        private System.Type typeofT1;        // 0xD0
        private System.Type typeofT2;        // 0xD8
        private System.Type typeofTPlugOptions;        // 0xE0
        private System.Boolean <active>k__BackingField;        // 0xE8
        private System.Boolean isSequenced;        // 0xE9
        private DG.Tweening.Sequence sequenceParent;        // 0xF0
        private System.Int32 activeId;        // 0xF8
        private DG.Tweening.Core.Enums.SpecialStartupMode specialStartupMode;        // 0xFC
        private System.Boolean creationLocked;        // 0x100
        private System.Boolean startupDone;        // 0x101
        private System.Boolean <playedOnce>k__BackingField;        // 0x102
        private System.Single <position>k__BackingField;        // 0x104
        private System.Single fullDuration;        // 0x108
        private System.Int32 completedLoops;        // 0x10C
        private System.Boolean isPlaying;        // 0x110
        private System.Boolean isComplete;        // 0x111
        private System.Single elapsedDelay;        // 0x114
        private System.Boolean delayComplete;        // 0x118
        private System.Int32 miscInt;        // 0x11C

        // Methods
        private System.Boolean get_isRelative() { }
        private System.Void set_isRelative(System.Boolean value) { }
        private System.Boolean get_active() { }
        private System.Void set_active(System.Boolean value) { }
        private System.Single get_fullPosition() { }
        private System.Void set_fullPosition(System.Single value) { }
        private System.Boolean get_hasLoops() { }
        private System.Boolean get_playedOnce() { }
        private System.Void set_playedOnce(System.Boolean value) { }
        private System.Single get_position() { }
        private System.Void set_position(System.Single value) { }
        private System.Void Reset() { }
        private System.Boolean Validate() { }
        private System.Single UpdateDelay(System.Single elapsed) { }
        private System.Boolean Startup() { }
        private System.Boolean ApplyTween(System.Single prevPosition, System.Int32 prevCompletedLoops, System.Int32 newCompletedSteps, System.Boolean useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode, DG.Tweening.Core.Enums.UpdateNotice updateNotice) { }
        private System.Boolean DoGoto(DG.Tweening.Tween t, System.Single toPosition, System.Int32 toCompletedLoops, DG.Tweening.Core.Enums.UpdateMode updateMode) { }
        private System.Boolean OnTweenCallback(DG.Tweening.TweenCallback callback, DG.Tweening.Tween t) { }
        private System.Boolean OnTweenCallback(DG.Tweening.TweenCallback<T> callback, DG.Tweening.Tween t, T param) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006F
    public class Tweener : Tween
    {
        // Fields
        private System.Boolean hasManuallySetStartValue;        // 0x120
        private System.Boolean isFromAllowed;        // 0x121

        // Methods
        private System.Void .ctor() { }
        private DG.Tweening.Tweener ChangeStartValue(System.Object newStartValue, System.Single newDuration) { }
        private DG.Tweening.Tweener ChangeEndValue(System.Object newEndValue, System.Single newDuration, System.Boolean snapStartValue) { }
        private DG.Tweening.Tweener ChangeEndValue(System.Object newEndValue, System.Boolean snapStartValue) { }
        private DG.Tweening.Tweener ChangeValues(System.Object newStartValue, System.Object newEndValue, System.Single newDuration) { }
        private DG.Tweening.Tweener SetFrom(System.Boolean relative) { }
        private System.Boolean Setup(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t, DG.Tweening.Core.DOGetter<T1> getter, DG.Tweening.Core.DOSetter<T1> setter, T2 endValue, System.Single duration, DG.Tweening.Plugins.Core.ABSTweenPlugin<T1,T2,TPlugOptions> plugin) { }
        private System.Single DoUpdateDelay(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t, System.Single elapsed) { }
        private System.Boolean DoStartup(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t) { }
        private DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> DoChangeStartValue(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t, T2 newStartValue, System.Single newDuration) { }
        private DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> DoChangeEndValue(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t, T2 newEndValue, System.Single newDuration, System.Boolean snapStartValue) { }
        private DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> DoChangeValues(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t, T2 newStartValue, T2 newEndValue, System.Single newDuration) { }
        private System.Boolean DOStartupSpecials(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t) { }
        private System.Void DOStartupDurationBased(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t) { }

    }

    // TypeToken: 0x2000070
    public struct TweenType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.TweenType Tweener;        // 0x0
        public static DG.Tweening.TweenType Sequence;        // 0x0
        public static DG.Tweening.TweenType Callback;        // 0x0

    }

    // TypeToken: 0x2000071
    public struct UpdateType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.UpdateType Normal;        // 0x0
        public static DG.Tweening.UpdateType Late;        // 0x0
        public static DG.Tweening.UpdateType Fixed;        // 0x0
        public static DG.Tweening.UpdateType Manual;        // 0x0

    }

}

namespace DG.Tweening.Core
{

    // TypeToken: 0x200009F
    public class ABSSequentiable
    {
        // Fields
        private DG.Tweening.TweenType tweenType;        // 0x10
        private System.Single sequencedPosition;        // 0x14
        private System.Single sequencedEndPosition;        // 0x18
        private DG.Tweening.TweenCallback onStart;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A0
    public class DOGetter`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private T Invoke() { }
        private System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object) { }
        private T EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20000A1
    public class DOSetter`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T pNewValue) { }
        private System.IAsyncResult BeginInvoke(T pNewValue, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20000A2
    public class Debugger
    {
        // Fields
        private static System.Int32 _logPriority;        // 0x0
        private static System.String _LogPrefix;        // 0x0

        // Methods
        private System.Int32 get_logPriority() { }
        private System.Void Log(System.Object message) { }
        private System.Void LogWarning(System.Object message, DG.Tweening.Tween t) { }
        private System.Void LogError(System.Object message, DG.Tweening.Tween t) { }
        private System.Void LogSafeModeCapturedError(System.Object message, DG.Tweening.Tween t) { }
        private System.Void LogReport(System.Object message) { }
        private System.Void LogSafeModeReport(System.Object message) { }
        private System.Void LogInvalidTween(DG.Tweening.Tween t) { }
        private System.Void LogNestedTween(DG.Tweening.Tween t) { }
        private System.Void LogNullTween(DG.Tweening.Tween t) { }
        private System.Void LogNonPathTween(DG.Tweening.Tween t) { }
        private System.Void LogMissingMaterialProperty(System.String propertyName) { }
        private System.Void LogMissingMaterialProperty(System.Int32 propertyId) { }
        private System.Void LogRemoveActiveTweenError(System.String errorInfo, DG.Tweening.Tween t) { }
        private System.Void LogAddActiveTweenError(System.String errorInfo, DG.Tweening.Tween t) { }
        private System.Void SetLogPriority(DG.Tweening.LogBehaviour logBehaviour) { }
        private System.Boolean ShouldLogSafeModeCapturedError() { }
        private System.String GetDebugDataMessage(DG.Tweening.Tween t) { }
        private System.Void AddDebugDataToMessage(System.String& message, DG.Tweening.Tween t) { }

    }

    // TypeToken: 0x20000A4
    public class DOTweenComponent : MonoBehaviour, IDOTweenInit
    {
        // Fields
        public System.Int32 inspectorUpdater;        // 0x18
        private System.Single _unscaledTime;        // 0x1C
        private System.Single _unscaledDeltaTime;        // 0x20
        private System.Boolean _paused;        // 0x24
        private System.Single _pausedTime;        // 0x28
        private System.Boolean _isQuitting;        // 0x2C
        private System.Boolean _duplicateToDestroy;        // 0x2D

        // Methods
        private System.Void Awake() { }
        private System.Void Start() { }
        private System.Void Update() { }
        private System.Void LateUpdate() { }
        private System.Void FixedUpdate() { }
        private System.Void OnDrawGizmos() { }
        private System.Void OnDestroy() { }
        private System.Void OnApplicationPause(System.Boolean pauseStatus) { }
        private System.Void OnApplicationQuit() { }
        private DG.Tweening.IDOTweenInit SetCapacity(System.Int32 tweenersCapacity, System.Int32 sequencesCapacity) { }
        private System.Collections.IEnumerator WaitForCompletion(DG.Tweening.Tween t) { }
        private System.Collections.IEnumerator WaitForRewind(DG.Tweening.Tween t) { }
        private System.Collections.IEnumerator WaitForKill(DG.Tweening.Tween t) { }
        private System.Collections.IEnumerator WaitForElapsedLoops(DG.Tweening.Tween t, System.Int32 elapsedLoops) { }
        private System.Collections.IEnumerator WaitForPosition(DG.Tweening.Tween t, System.Single position) { }
        private System.Collections.IEnumerator WaitForStart(DG.Tweening.Tween t) { }
        private System.Void Create() { }
        private System.Void DestroyInstance() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000AB
    public class DOTweenSettings : ScriptableObject
    {
        // Fields
        public static System.String AssetName;        // 0x0
        public static System.String AssetFullFilename;        // 0x0
        public System.Boolean useSafeMode;        // 0x18
        public DG.Tweening.Core.DOTweenSettings.SafeModeOptions safeModeOptions;        // 0x20
        public System.Single timeScale;        // 0x28
        public System.Single unscaledTimeScale;        // 0x2C
        public System.Boolean useSmoothDeltaTime;        // 0x30
        public System.Single maxSmoothUnscaledTime;        // 0x34
        public DG.Tweening.Core.Enums.RewindCallbackMode rewindCallbackMode;        // 0x38
        public System.Boolean showUnityEditorReport;        // 0x3C
        public DG.Tweening.LogBehaviour logBehaviour;        // 0x40
        public System.Boolean drawGizmos;        // 0x44
        public System.Boolean defaultRecyclable;        // 0x45
        public DG.Tweening.AutoPlay defaultAutoPlay;        // 0x48
        public DG.Tweening.UpdateType defaultUpdateType;        // 0x4C
        public System.Boolean defaultTimeScaleIndependent;        // 0x50
        public DG.Tweening.Ease defaultEaseType;        // 0x54
        public System.Single defaultEaseOvershootOrAmplitude;        // 0x58
        public System.Single defaultEasePeriod;        // 0x5C
        public System.Boolean defaultAutoKill;        // 0x60
        public DG.Tweening.LoopType defaultLoopType;        // 0x64
        public System.Boolean debugMode;        // 0x68
        public System.Boolean debugStoreTargetId;        // 0x69
        public System.Boolean showPreviewPanel;        // 0x6A
        public DG.Tweening.Core.DOTweenSettings.SettingsLocation storeSettingsLocation;        // 0x6C
        public DG.Tweening.Core.DOTweenSettings.ModulesSetup modules;        // 0x70
        public System.Boolean createASMDEF;        // 0x78
        public System.Boolean showPlayingTweens;        // 0x79
        public System.Boolean showPausedTweens;        // 0x7A

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000AF
    public class Extensions
    {
        // Methods
        private T SetSpecialStartupMode(T t, DG.Tweening.Core.Enums.SpecialStartupMode mode) { }
        private DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> Blendable(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t) { }
        private DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> NoFrom(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t) { }

    }

    // TypeToken: 0x20000B0
    public class DOTweenExternalCommand
    {
        // Fields
        private static System.Action<DG.Tweening.Plugins.Options.PathOptions,DG.Tweening.Tween,UnityEngine.Quaternion,UnityEngine.Transform> SetOrientationOnPath;        // 0x0

        // Methods
        private System.Void add_SetOrientationOnPath(System.Action<DG.Tweening.Plugins.Options.PathOptions,DG.Tweening.Tween,UnityEngine.Quaternion,UnityEngine.Transform> value) { }
        private System.Void remove_SetOrientationOnPath(System.Action<DG.Tweening.Plugins.Options.PathOptions,DG.Tweening.Tween,UnityEngine.Quaternion,UnityEngine.Transform> value) { }
        private System.Void Dispatch_SetOrientationOnPath(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, UnityEngine.Quaternion newRot, UnityEngine.Transform trans) { }

    }

    // TypeToken: 0x20000B1
    public struct SafeModeReport
    {
        // Fields
        private System.Int32 <totMissingTargetOrFieldErrors>k__BackingField;        // 0x10
        private System.Int32 <totCallbackErrors>k__BackingField;        // 0x14
        private System.Int32 <totStartupErrors>k__BackingField;        // 0x18
        private System.Int32 <totUnsetErrors>k__BackingField;        // 0x1C

        // Methods
        private System.Int32 get_totMissingTargetOrFieldErrors() { }
        private System.Void set_totMissingTargetOrFieldErrors(System.Int32 value) { }
        private System.Int32 get_totCallbackErrors() { }
        private System.Void set_totCallbackErrors(System.Int32 value) { }
        private System.Int32 get_totStartupErrors() { }
        private System.Void set_totStartupErrors(System.Int32 value) { }
        private System.Int32 get_totUnsetErrors() { }
        private System.Void set_totUnsetErrors(System.Int32 value) { }
        private System.Void Add(DG.Tweening.Core.SafeModeReport.SafeModeReportType type) { }
        private System.Int32 GetTotErrors() { }

    }

    // TypeToken: 0x20000B3
    public class SequenceCallback : ABSSequentiable
    {
        // Methods
        private System.Void .ctor(System.Single sequencedPosition, DG.Tweening.TweenCallback callback) { }

    }

    // TypeToken: 0x20000B4
    public class TweenLink
    {
        // Fields
        public readonly UnityEngine.GameObject target;        // 0x10
        public readonly DG.Tweening.LinkBehaviour behaviour;        // 0x18
        public System.Boolean lastSeenActive;        // 0x1C

        // Methods
        private System.Void .ctor(UnityEngine.GameObject target, DG.Tweening.LinkBehaviour behaviour) { }

    }

    // TypeToken: 0x20000B5
    public class TweenManager
    {
        // Fields
        private static System.Int32 _DefaultMaxTweeners;        // 0x0
        private static System.Int32 _DefaultMaxSequences;        // 0x0
        private static System.String _MaxTweensReached;        // 0x0
        private static System.Single _EpsilonVsTimeCheck;        // 0x0
        private static System.Boolean isUnityEditor;        // 0x0
        private static System.Boolean isDebugBuild;        // 0x1
        private static System.Int32 maxActive;        // 0x4
        private static System.Int32 maxTweeners;        // 0x8
        private static System.Int32 maxSequences;        // 0xC
        private static System.Boolean hasActiveTweens;        // 0x10
        private static System.Boolean hasActiveDefaultTweens;        // 0x11
        private static System.Boolean hasActiveLateTweens;        // 0x12
        private static System.Boolean hasActiveFixedTweens;        // 0x13
        private static System.Boolean hasActiveManualTweens;        // 0x14
        private static System.Int32 totActiveTweens;        // 0x18
        private static System.Int32 totActiveDefaultTweens;        // 0x1C
        private static System.Int32 totActiveLateTweens;        // 0x20
        private static System.Int32 totActiveFixedTweens;        // 0x24
        private static System.Int32 totActiveManualTweens;        // 0x28
        private static System.Int32 totActiveTweeners;        // 0x2C
        private static System.Int32 totActiveSequences;        // 0x30
        private static System.Int32 totPooledTweeners;        // 0x34
        private static System.Int32 totPooledSequences;        // 0x38
        private static System.Int32 totTweeners;        // 0x3C
        private static System.Int32 totSequences;        // 0x40
        private static System.Boolean isUpdateLoop;        // 0x44
        private static DG.Tweening.Tween[] _activeTweens;        // 0x48
        private static DG.Tweening.Tween[] _pooledTweeners;        // 0x50
        private static readonly System.Collections.Generic.Stack<DG.Tweening.Tween> _PooledSequences;        // 0x58
        private static readonly System.Collections.Generic.List<DG.Tweening.Tween> _KillList;        // 0x60
        private static readonly System.Collections.Generic.Dictionary<DG.Tweening.Tween,DG.Tweening.Core.TweenLink> _TweenLinks;        // 0x68
        private static System.Int32 _totTweenLinks;        // 0x70
        private static System.Int32 _maxActiveLookupId;        // 0x74
        private static System.Boolean _requiresActiveReorganization;        // 0x78
        private static System.Int32 _reorganizeFromId;        // 0x7C
        private static System.Int32 _minPooledTweenerId;        // 0x80
        private static System.Int32 _maxPooledTweenerId;        // 0x84
        private static System.Boolean _despawnAllCalledFromUpdateLoopCallback;        // 0x88

        // Methods
        private System.Void .cctor() { }
        private DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> GetTweener() { }
        private DG.Tweening.Sequence GetSequence() { }
        private System.Void SetUpdateType(DG.Tweening.Tween t, DG.Tweening.UpdateType updateType, System.Boolean isIndependentUpdate) { }
        private System.Void AddActiveTweenToSequence(DG.Tweening.Tween t) { }
        private System.Int32 DespawnAll() { }
        private System.Void Despawn(DG.Tweening.Tween t, System.Boolean modifyActiveLists) { }
        private System.Void PurgeAll(System.Boolean isApplicationQuitting) { }
        private System.Void PurgePools() { }
        private System.Void AddTweenLink(DG.Tweening.Tween t, DG.Tweening.Core.TweenLink tweenLink) { }
        private System.Void RemoveTweenLink(DG.Tweening.Tween t) { }
        private System.Void ResetCapacities() { }
        private System.Void SetCapacities(System.Int32 tweenersCapacity, System.Int32 sequencesCapacity) { }
        private System.Int32 Validate() { }
        private System.Void Update(DG.Tweening.UpdateType updateType, System.Single deltaTime, System.Single independentTime) { }
        private System.Boolean Update(DG.Tweening.Tween t, System.Single deltaTime, System.Single independentTime, System.Boolean isSingleTweenManualUpdate) { }
        private System.Int32 FilteredOperation(DG.Tweening.Core.Enums.OperationType operationType, DG.Tweening.Core.Enums.FilterType filterType, System.Object id, System.Boolean optionalBool, System.Single optionalFloat, System.Object optionalObj, System.Object[] optionalArray) { }
        private System.Boolean Complete(DG.Tweening.Tween t, System.Boolean modifyActiveLists, DG.Tweening.Core.Enums.UpdateMode updateMode) { }
        private System.Boolean Flip(DG.Tweening.Tween t) { }
        private System.Void ForceInit(DG.Tweening.Tween t, System.Boolean isSequenced) { }
        private System.Boolean Goto(DG.Tweening.Tween t, System.Single to, System.Boolean andPlay, DG.Tweening.Core.Enums.UpdateMode updateMode) { }
        private System.Boolean Pause(DG.Tweening.Tween t) { }
        private System.Boolean Play(DG.Tweening.Tween t) { }
        private System.Boolean PlayBackwards(DG.Tweening.Tween t) { }
        private System.Boolean PlayForward(DG.Tweening.Tween t) { }
        private System.Boolean Restart(DG.Tweening.Tween t, System.Boolean includeDelay, System.Single changeDelayTo) { }
        private System.Boolean Rewind(DG.Tweening.Tween t, System.Boolean includeDelay) { }
        private System.Boolean SmoothRewind(DG.Tweening.Tween t) { }
        private System.Boolean TogglePause(DG.Tweening.Tween t) { }
        private System.Int32 TotalPooledTweens() { }
        private System.Int32 TotalPlayingTweens() { }
        private System.Int32 TotalTweensById(System.Object id, System.Boolean playingOnly) { }
        private System.Collections.Generic.List<DG.Tweening.Tween> GetActiveTweens(System.Boolean playing, System.Collections.Generic.List<DG.Tweening.Tween> fillableList) { }
        private System.Collections.Generic.List<DG.Tweening.Tween> GetTweensById(System.Object id, System.Boolean playingOnly, System.Collections.Generic.List<DG.Tweening.Tween> fillableList) { }
        private System.Int32 DoGetTweensById(System.Object id, System.Boolean playingOnly, System.Boolean addToList, System.Collections.Generic.List<DG.Tweening.Tween> fillableList) { }
        private System.Collections.Generic.List<DG.Tweening.Tween> GetTweensByTarget(System.Object target, System.Boolean playingOnly, System.Collections.Generic.List<DG.Tweening.Tween> fillableList) { }
        private System.Void MarkForKilling(DG.Tweening.Tween t, System.Boolean isSingleTweenManualUpdate) { }
        private System.Void EvaluateTweenLink(DG.Tweening.Tween t) { }
        private System.Void AddActiveTween(DG.Tweening.Tween t) { }
        private System.Void ReorganizeActiveTweens() { }
        private System.Void DespawnActiveTweens(System.Collections.Generic.List<DG.Tweening.Tween> tweens) { }
        private System.Void RemoveActiveTween(DG.Tweening.Tween t) { }
        private System.Void ClearTweenArray(DG.Tweening.Tween[] tweens) { }
        private System.Void IncreaseCapacities(DG.Tweening.Core.TweenManager.CapacityIncreaseMode increaseMode) { }
        private System.Void ManageOnRewindCallbackWhenAlreadyRewinded(DG.Tweening.Tween t, System.Boolean isPlayBackwardsOrSmoothRewind) { }

    }

    // TypeToken: 0x20000B7
    public class DOTweenUtils
    {
        // Fields
        private static System.Reflection.Assembly[] _loadedAssemblies;        // 0x0
        private static readonly System.String[] _defAssembliesToQuery;        // 0x8

        // Methods
        private UnityEngine.Vector3 Vector3FromAngle(System.Single degrees, System.Single magnitude) { }
        private System.Single Angle2D(UnityEngine.Vector3 from, UnityEngine.Vector3 to) { }
        private UnityEngine.Vector3 RotateAroundPivot(UnityEngine.Vector3 point, UnityEngine.Vector3 pivot, UnityEngine.Quaternion rotation) { }
        private UnityEngine.Vector2 GetPointOnCircle(UnityEngine.Vector2 center, System.Single radius, System.Single degrees) { }
        private System.Boolean Vector3AreApproximatelyEqual(UnityEngine.Vector3 a, UnityEngine.Vector3 b) { }
        private System.Type GetLooseScriptType(System.String typeName) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000B8
    public class TweenerCore`3 : Tweener
    {
        // Fields
        public T2 startValue;        // 0x0
        public T2 endValue;        // 0x0
        public T2 changeValue;        // 0x0
        public TPlugOptions plugOptions;        // 0x0
        public DG.Tweening.Core.DOGetter<T1> getter;        // 0x0
        public DG.Tweening.Core.DOSetter<T1> setter;        // 0x0
        private DG.Tweening.Plugins.Core.ABSTweenPlugin<T1,T2,TPlugOptions> tweenPlugin;        // 0x0
        private static System.String _TxtCantChangeSequencedValues;        // 0x0
        private System.Type _colorType;        // 0x0
        private System.Type _color32Type;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private DG.Tweening.Tweener ChangeStartValue(System.Object newStartValue, System.Single newDuration) { }
        private DG.Tweening.Tweener ChangeEndValue(System.Object newEndValue, System.Boolean snapStartValue) { }
        private DG.Tweening.Tweener ChangeEndValue(System.Object newEndValue, System.Single newDuration, System.Boolean snapStartValue) { }
        private DG.Tweening.Tweener ChangeValues(System.Object newStartValue, System.Object newEndValue, System.Single newDuration) { }
        private DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> ChangeStartValue(T2 newStartValue, System.Single newDuration) { }
        private DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> ChangeEndValue(T2 newEndValue, System.Boolean snapStartValue) { }
        private DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> ChangeEndValue(T2 newEndValue, System.Single newDuration, System.Boolean snapStartValue) { }
        private DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> ChangeValues(T2 newStartValue, T2 newEndValue, System.Single newDuration) { }
        private DG.Tweening.Tweener SetFrom(System.Boolean relative) { }
        private DG.Tweening.Tweener SetFrom(T2 fromValue, System.Boolean setImmediately, System.Boolean relative) { }
        private System.Void Reset() { }
        private System.Boolean Validate() { }
        private System.Boolean ValidateChangeValueType(System.Type newType, System.Boolean& isColor32ToColor) { }
        private System.Single UpdateDelay(System.Single elapsed) { }
        private System.Boolean Startup() { }
        private System.Boolean ApplyTween(System.Single prevPosition, System.Int32 prevCompletedLoops, System.Int32 newCompletedSteps, System.Boolean useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode, DG.Tweening.Core.Enums.UpdateNotice updateNotice) { }

    }

}

namespace DG.Tweening.Core.Easing
{

    // TypeToken: 0x20000C1
    public class Bounce
    {
        // Methods
        private System.Single EaseIn(System.Single time, System.Single duration, System.Single unusedOvershootOrAmplitude, System.Single unusedPeriod) { }
        private System.Single EaseOut(System.Single time, System.Single duration, System.Single unusedOvershootOrAmplitude, System.Single unusedPeriod) { }
        private System.Single EaseInOut(System.Single time, System.Single duration, System.Single unusedOvershootOrAmplitude, System.Single unusedPeriod) { }

    }

    // TypeToken: 0x20000C2
    public class EaseManager
    {
        // Fields
        private static System.Single _PiOver2;        // 0x0
        private static System.Single _TwoPi;        // 0x0

        // Methods
        private System.Single Evaluate(DG.Tweening.Tween t, System.Single time, System.Single duration, System.Single overshootOrAmplitude, System.Single period) { }
        private System.Single Evaluate(DG.Tweening.Ease easeType, DG.Tweening.EaseFunction customEase, System.Single time, System.Single duration, System.Single overshootOrAmplitude, System.Single period) { }
        private DG.Tweening.EaseFunction ToEaseFunction(DG.Tweening.Ease ease) { }
        private System.Boolean IsFlashEase(DG.Tweening.Ease ease) { }

    }

    // TypeToken: 0x20000C4
    public class EaseCurve
    {
        // Fields
        private readonly UnityEngine.AnimationCurve _animCurve;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.AnimationCurve animCurve) { }
        private System.Single Evaluate(System.Single time, System.Single duration, System.Single unusedOvershoot, System.Single unusedPeriod) { }

    }

    // TypeToken: 0x20000C5
    public class Flash
    {
        // Methods
        private System.Single Ease(System.Single time, System.Single duration, System.Single overshootOrAmplitude, System.Single period) { }
        private System.Single EaseIn(System.Single time, System.Single duration, System.Single overshootOrAmplitude, System.Single period) { }
        private System.Single EaseOut(System.Single time, System.Single duration, System.Single overshootOrAmplitude, System.Single period) { }
        private System.Single EaseInOut(System.Single time, System.Single duration, System.Single overshootOrAmplitude, System.Single period) { }
        private System.Single WeightedEase(System.Single overshootOrAmplitude, System.Single period, System.Int32 stepIndex, System.Single stepDuration, System.Single dir, System.Single res) { }

    }

}

namespace DG.Tweening.Core.Enums
{

    // TypeToken: 0x20000B9
    public struct FilterType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.Core.Enums.FilterType All;        // 0x0
        public static DG.Tweening.Core.Enums.FilterType TargetOrId;        // 0x0
        public static DG.Tweening.Core.Enums.FilterType TargetAndId;        // 0x0
        public static DG.Tweening.Core.Enums.FilterType AllExceptTargetsOrIds;        // 0x0
        public static DG.Tweening.Core.Enums.FilterType DOGetter;        // 0x0

    }

    // TypeToken: 0x20000BA
    public struct NestedTweenFailureBehaviour
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.Core.Enums.NestedTweenFailureBehaviour TryToPreserveSequence;        // 0x0
        public static DG.Tweening.Core.Enums.NestedTweenFailureBehaviour KillWholeSequence;        // 0x0

    }

    // TypeToken: 0x20000BB
    public struct OperationType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.Core.Enums.OperationType Complete;        // 0x0
        public static DG.Tweening.Core.Enums.OperationType Despawn;        // 0x0
        public static DG.Tweening.Core.Enums.OperationType Flip;        // 0x0
        public static DG.Tweening.Core.Enums.OperationType Goto;        // 0x0
        public static DG.Tweening.Core.Enums.OperationType Pause;        // 0x0
        public static DG.Tweening.Core.Enums.OperationType Play;        // 0x0
        public static DG.Tweening.Core.Enums.OperationType PlayForward;        // 0x0
        public static DG.Tweening.Core.Enums.OperationType PlayBackwards;        // 0x0
        public static DG.Tweening.Core.Enums.OperationType Rewind;        // 0x0
        public static DG.Tweening.Core.Enums.OperationType SmoothRewind;        // 0x0
        public static DG.Tweening.Core.Enums.OperationType Restart;        // 0x0
        public static DG.Tweening.Core.Enums.OperationType TogglePause;        // 0x0
        public static DG.Tweening.Core.Enums.OperationType IsTweening;        // 0x0

    }

    // TypeToken: 0x20000BC
    public struct SafeModeLogBehaviour
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.Core.Enums.SafeModeLogBehaviour None;        // 0x0
        public static DG.Tweening.Core.Enums.SafeModeLogBehaviour Normal;        // 0x0
        public static DG.Tweening.Core.Enums.SafeModeLogBehaviour Warning;        // 0x0
        public static DG.Tweening.Core.Enums.SafeModeLogBehaviour Error;        // 0x0

    }

    // TypeToken: 0x20000BD
    public struct SpecialStartupMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.Core.Enums.SpecialStartupMode None;        // 0x0
        public static DG.Tweening.Core.Enums.SpecialStartupMode SetLookAt;        // 0x0
        public static DG.Tweening.Core.Enums.SpecialStartupMode SetShake;        // 0x0
        public static DG.Tweening.Core.Enums.SpecialStartupMode SetPunch;        // 0x0
        public static DG.Tweening.Core.Enums.SpecialStartupMode SetCameraShakePosition;        // 0x0

    }

    // TypeToken: 0x20000BE
    public struct UpdateNotice
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.Core.Enums.UpdateNotice None;        // 0x0
        public static DG.Tweening.Core.Enums.UpdateNotice RewindStep;        // 0x0

    }

    // TypeToken: 0x20000BF
    public struct UpdateMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.Core.Enums.UpdateMode Update;        // 0x0
        public static DG.Tweening.Core.Enums.UpdateMode Goto;        // 0x0
        public static DG.Tweening.Core.Enums.UpdateMode IgnoreOnUpdate;        // 0x0
        public static DG.Tweening.Core.Enums.UpdateMode IgnoreOnComplete;        // 0x0

    }

    // TypeToken: 0x20000C0
    public struct RewindCallbackMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.Core.Enums.RewindCallbackMode FireIfPositionChanged;        // 0x0
        public static DG.Tweening.Core.Enums.RewindCallbackMode FireAlwaysWithRewind;        // 0x0
        public static DG.Tweening.Core.Enums.RewindCallbackMode FireAlways;        // 0x0

    }

}

namespace DG.Tweening.CustomPlugins
{

    // TypeToken: 0x200009E
    public class PureQuaternionPlugin : ABSTweenPlugin`3
    {
        // Fields
        private static DG.Tweening.CustomPlugins.PureQuaternionPlugin _plug;        // 0x0

        // Methods
        private DG.Tweening.CustomPlugins.PureQuaternionPlugin Plug() { }
        private System.Void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Quaternion,DG.Tweening.Plugins.Options.NoOptions> t) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Quaternion,DG.Tweening.Plugins.Options.NoOptions> t, System.Boolean isRelative) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Quaternion,DG.Tweening.Plugins.Options.NoOptions> t, UnityEngine.Quaternion fromValue, System.Boolean setImmediately, System.Boolean isRelative) { }
        private UnityEngine.Quaternion ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Quaternion,DG.Tweening.Plugins.Options.NoOptions> t, UnityEngine.Quaternion value) { }
        private System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Quaternion,DG.Tweening.Plugins.Options.NoOptions> t) { }
        private System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Quaternion,DG.Tweening.Plugins.Options.NoOptions> t) { }
        private System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, System.Single unitsXSecond, UnityEngine.Quaternion changeValue) { }
        private System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Quaternion> getter, DG.Tweening.Core.DOSetter<UnityEngine.Quaternion> setter, System.Single elapsed, UnityEngine.Quaternion startValue, UnityEngine.Quaternion changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice) { }
        private System.Void .ctor() { }

    }

}

namespace DG.Tweening.Plugins
{

    // TypeToken: 0x2000072
    public struct CircleOptions, IPlugOptions
    {
        // Fields
        public System.Single endValueDegrees;        // 0x10
        public System.Boolean relativeCenter;        // 0x14
        public System.Boolean snapping;        // 0x15
        private UnityEngine.Vector2 center;        // 0x18
        private System.Single radius;        // 0x20
        private System.Single startValueDegrees;        // 0x24
        private System.Boolean initialized;        // 0x28

        // Methods
        private System.Void Reset() { }
        private System.Void Initialize(UnityEngine.Vector2 startValue, UnityEngine.Vector2 endValue) { }

    }

    // TypeToken: 0x2000073
    public class CirclePlugin : ABSTweenPlugin`3
    {
        // Methods
        private System.Void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions> t) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions> t, System.Boolean isRelative) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions> t, UnityEngine.Vector2 fromValue, System.Boolean setImmediately, System.Boolean isRelative) { }
        private DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions> Get() { }
        private UnityEngine.Vector2 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions> t, UnityEngine.Vector2 value) { }
        private System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions> t) { }
        private System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions> t) { }
        private System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.CircleOptions options, System.Single unitsXSecond, UnityEngine.Vector2 changeValue) { }
        private System.Void EvaluateAndApply(DG.Tweening.Plugins.CircleOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector2> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector2> setter, System.Single elapsed, UnityEngine.Vector2 startValue, UnityEngine.Vector2 changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice) { }
        private UnityEngine.Vector2 GetPositionOnCircle(DG.Tweening.Plugins.CircleOptions options, System.Single degrees) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000074
    public class Color2Plugin : ABSTweenPlugin`3
    {
        // Methods
        private System.Void Reset(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2,DG.Tweening.Color2,DG.Tweening.Plugins.Options.ColorOptions> t) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2,DG.Tweening.Color2,DG.Tweening.Plugins.Options.ColorOptions> t, System.Boolean isRelative) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2,DG.Tweening.Color2,DG.Tweening.Plugins.Options.ColorOptions> t, DG.Tweening.Color2 fromValue, System.Boolean setImmediately, System.Boolean isRelative) { }
        private DG.Tweening.Color2 ConvertToStartValue(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2,DG.Tweening.Color2,DG.Tweening.Plugins.Options.ColorOptions> t, DG.Tweening.Color2 value) { }
        private System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2,DG.Tweening.Color2,DG.Tweening.Plugins.Options.ColorOptions> t) { }
        private System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2,DG.Tweening.Color2,DG.Tweening.Plugins.Options.ColorOptions> t) { }
        private System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.ColorOptions options, System.Single unitsXSecond, DG.Tweening.Color2 changeValue) { }
        private System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.ColorOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<DG.Tweening.Color2> getter, DG.Tweening.Core.DOSetter<DG.Tweening.Color2> setter, System.Single elapsed, DG.Tweening.Color2 startValue, DG.Tweening.Color2 changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000075
    public class DoublePlugin : ABSTweenPlugin`3
    {
        // Methods
        private System.Void Reset(DG.Tweening.Core.TweenerCore<System.Double,System.Double,DG.Tweening.Plugins.Options.NoOptions> t) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<System.Double,System.Double,DG.Tweening.Plugins.Options.NoOptions> t, System.Boolean isRelative) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<System.Double,System.Double,DG.Tweening.Plugins.Options.NoOptions> t, System.Double fromValue, System.Boolean setImmediately, System.Boolean isRelative) { }
        private System.Double ConvertToStartValue(DG.Tweening.Core.TweenerCore<System.Double,System.Double,DG.Tweening.Plugins.Options.NoOptions> t, System.Double value) { }
        private System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<System.Double,System.Double,DG.Tweening.Plugins.Options.NoOptions> t) { }
        private System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<System.Double,System.Double,DG.Tweening.Plugins.Options.NoOptions> t) { }
        private System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, System.Single unitsXSecond, System.Double changeValue) { }
        private System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<System.Double> getter, DG.Tweening.Core.DOSetter<System.Double> setter, System.Single elapsed, System.Double startValue, System.Double changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000076
    public class LongPlugin : ABSTweenPlugin`3
    {
        // Methods
        private System.Void Reset(DG.Tweening.Core.TweenerCore<System.Int64,System.Int64,DG.Tweening.Plugins.Options.NoOptions> t) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<System.Int64,System.Int64,DG.Tweening.Plugins.Options.NoOptions> t, System.Boolean isRelative) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<System.Int64,System.Int64,DG.Tweening.Plugins.Options.NoOptions> t, System.Int64 fromValue, System.Boolean setImmediately, System.Boolean isRelative) { }
        private System.Int64 ConvertToStartValue(DG.Tweening.Core.TweenerCore<System.Int64,System.Int64,DG.Tweening.Plugins.Options.NoOptions> t, System.Int64 value) { }
        private System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<System.Int64,System.Int64,DG.Tweening.Plugins.Options.NoOptions> t) { }
        private System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<System.Int64,System.Int64,DG.Tweening.Plugins.Options.NoOptions> t) { }
        private System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, System.Single unitsXSecond, System.Int64 changeValue) { }
        private System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<System.Int64> getter, DG.Tweening.Core.DOSetter<System.Int64> setter, System.Single elapsed, System.Int64 startValue, System.Int64 changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000077
    public class UlongPlugin : ABSTweenPlugin`3
    {
        // Methods
        private System.Void Reset(DG.Tweening.Core.TweenerCore<System.UInt64,System.UInt64,DG.Tweening.Plugins.Options.NoOptions> t) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<System.UInt64,System.UInt64,DG.Tweening.Plugins.Options.NoOptions> t, System.Boolean isRelative) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<System.UInt64,System.UInt64,DG.Tweening.Plugins.Options.NoOptions> t, System.UInt64 fromValue, System.Boolean setImmediately, System.Boolean isRelative) { }
        private System.UInt64 ConvertToStartValue(DG.Tweening.Core.TweenerCore<System.UInt64,System.UInt64,DG.Tweening.Plugins.Options.NoOptions> t, System.UInt64 value) { }
        private System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<System.UInt64,System.UInt64,DG.Tweening.Plugins.Options.NoOptions> t) { }
        private System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<System.UInt64,System.UInt64,DG.Tweening.Plugins.Options.NoOptions> t) { }
        private System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, System.Single unitsXSecond, System.UInt64 changeValue) { }
        private System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<System.UInt64> getter, DG.Tweening.Core.DOSetter<System.UInt64> setter, System.Single elapsed, System.UInt64 startValue, System.UInt64 changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000078
    public class Vector3ArrayPlugin : ABSTweenPlugin`3
    {
        // Methods
        private System.Void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> t) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, System.Boolean isRelative) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, UnityEngine.Vector3[] fromValue, System.Boolean setImmediately, System.Boolean isRelative) { }
        private UnityEngine.Vector3[] ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, UnityEngine.Vector3 value) { }
        private System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> t) { }
        private System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> t) { }
        private System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.Vector3ArrayOptions options, System.Single unitsXSecond, UnityEngine.Vector3[] changeValue) { }
        private System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.Vector3ArrayOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, System.Single elapsed, UnityEngine.Vector3[] startValue, UnityEngine.Vector3[] changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000079
    public class PathPlugin : ABSTweenPlugin`3
    {
        // Fields
        public static System.Single MinLookAhead;        // 0x0

        // Methods
        private System.Void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t, System.Boolean isRelative) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t, DG.Tweening.Plugins.Core.PathCore.Path fromValue, System.Boolean setImmediately, System.Boolean isRelative) { }
        private DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> Get() { }
        private DG.Tweening.Plugins.Core.PathCore.Path ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Vector3 value) { }
        private System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t) { }
        private System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t) { }
        private System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.PathOptions options, System.Single unitsXSecond, DG.Tweening.Plugins.Core.PathCore.Path changeValue) { }
        private System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, System.Single elapsed, DG.Tweening.Plugins.Core.PathCore.Path startValue, DG.Tweening.Plugins.Core.PathCore.Path changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice) { }
        private System.Void SetOrientation(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, DG.Tweening.Plugins.Core.PathCore.Path path, System.Single pathPerc, UnityEngine.Vector3 tPos, DG.Tweening.Core.Enums.UpdateNotice updateNotice) { }
        private UnityEngine.Vector3 DivideVectorByVector(UnityEngine.Vector3 vector, UnityEngine.Vector3 byVector) { }
        private UnityEngine.Vector3 MultiplyVectorByVector(UnityEngine.Vector3 vector, UnityEngine.Vector3 byVector) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007A
    public class ColorPlugin : ABSTweenPlugin`3
    {
        // Methods
        private System.Void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> t) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> t, System.Boolean isRelative) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> t, UnityEngine.Color fromValue, System.Boolean setImmediately, System.Boolean isRelative) { }
        private UnityEngine.Color ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> t, UnityEngine.Color value) { }
        private System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> t) { }
        private System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> t) { }
        private System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.ColorOptions options, System.Single unitsXSecond, UnityEngine.Color changeValue) { }
        private System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.ColorOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Color> getter, DG.Tweening.Core.DOSetter<UnityEngine.Color> setter, System.Single elapsed, UnityEngine.Color startValue, UnityEngine.Color changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007B
    public class IntPlugin : ABSTweenPlugin`3
    {
        // Methods
        private System.Void Reset(DG.Tweening.Core.TweenerCore<System.Int32,System.Int32,DG.Tweening.Plugins.Options.NoOptions> t) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<System.Int32,System.Int32,DG.Tweening.Plugins.Options.NoOptions> t, System.Boolean isRelative) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<System.Int32,System.Int32,DG.Tweening.Plugins.Options.NoOptions> t, System.Int32 fromValue, System.Boolean setImmediately, System.Boolean isRelative) { }
        private System.Int32 ConvertToStartValue(DG.Tweening.Core.TweenerCore<System.Int32,System.Int32,DG.Tweening.Plugins.Options.NoOptions> t, System.Int32 value) { }
        private System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<System.Int32,System.Int32,DG.Tweening.Plugins.Options.NoOptions> t) { }
        private System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<System.Int32,System.Int32,DG.Tweening.Plugins.Options.NoOptions> t) { }
        private System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, System.Single unitsXSecond, System.Int32 changeValue) { }
        private System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<System.Int32> getter, DG.Tweening.Core.DOSetter<System.Int32> setter, System.Single elapsed, System.Int32 startValue, System.Int32 changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007C
    public class QuaternionPlugin : ABSTweenPlugin`3
    {
        // Methods
        private System.Void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Vector3,DG.Tweening.Plugins.Options.QuaternionOptions> t) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Vector3,DG.Tweening.Plugins.Options.QuaternionOptions> t, System.Boolean isRelative) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Vector3,DG.Tweening.Plugins.Options.QuaternionOptions> t, UnityEngine.Vector3 fromValue, System.Boolean setImmediately, System.Boolean isRelative) { }
        private UnityEngine.Vector3 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Vector3,DG.Tweening.Plugins.Options.QuaternionOptions> t, UnityEngine.Quaternion value) { }
        private System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Vector3,DG.Tweening.Plugins.Options.QuaternionOptions> t) { }
        private System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Vector3,DG.Tweening.Plugins.Options.QuaternionOptions> t) { }
        private System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.QuaternionOptions options, System.Single unitsXSecond, UnityEngine.Vector3 changeValue) { }
        private System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.QuaternionOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Quaternion> getter, DG.Tweening.Core.DOSetter<UnityEngine.Quaternion> setter, System.Single elapsed, UnityEngine.Vector3 startValue, UnityEngine.Vector3 changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice) { }
        private UnityEngine.Vector3 GetEulerValForCalculations(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Vector3,DG.Tweening.Plugins.Options.QuaternionOptions> t, UnityEngine.Vector3 val, UnityEngine.Vector3 counterVal) { }
        private UnityEngine.Vector3 FlipEulerAngles(UnityEngine.Vector3 euler) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007D
    public class RectOffsetPlugin : ABSTweenPlugin`3
    {
        // Fields
        private static UnityEngine.RectOffset _r;        // 0x0

        // Methods
        private System.Void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset,UnityEngine.RectOffset,DG.Tweening.Plugins.Options.NoOptions> t) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset,UnityEngine.RectOffset,DG.Tweening.Plugins.Options.NoOptions> t, System.Boolean isRelative) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset,UnityEngine.RectOffset,DG.Tweening.Plugins.Options.NoOptions> t, UnityEngine.RectOffset fromValue, System.Boolean setImmediately, System.Boolean isRelative) { }
        private UnityEngine.RectOffset ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset,UnityEngine.RectOffset,DG.Tweening.Plugins.Options.NoOptions> t, UnityEngine.RectOffset value) { }
        private System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset,UnityEngine.RectOffset,DG.Tweening.Plugins.Options.NoOptions> t) { }
        private System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset,UnityEngine.RectOffset,DG.Tweening.Plugins.Options.NoOptions> t) { }
        private System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, System.Single unitsXSecond, UnityEngine.RectOffset changeValue) { }
        private System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<UnityEngine.RectOffset> getter, DG.Tweening.Core.DOSetter<UnityEngine.RectOffset> setter, System.Single elapsed, UnityEngine.RectOffset startValue, UnityEngine.RectOffset changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200007E
    public class RectPlugin : ABSTweenPlugin`3
    {
        // Methods
        private System.Void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Rect,UnityEngine.Rect,DG.Tweening.Plugins.Options.RectOptions> t) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Rect,UnityEngine.Rect,DG.Tweening.Plugins.Options.RectOptions> t, System.Boolean isRelative) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Rect,UnityEngine.Rect,DG.Tweening.Plugins.Options.RectOptions> t, UnityEngine.Rect fromValue, System.Boolean setImmediately, System.Boolean isRelative) { }
        private UnityEngine.Rect ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Rect,UnityEngine.Rect,DG.Tweening.Plugins.Options.RectOptions> t, UnityEngine.Rect value) { }
        private System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Rect,UnityEngine.Rect,DG.Tweening.Plugins.Options.RectOptions> t) { }
        private System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Rect,UnityEngine.Rect,DG.Tweening.Plugins.Options.RectOptions> t) { }
        private System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.RectOptions options, System.Single unitsXSecond, UnityEngine.Rect changeValue) { }
        private System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.RectOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Rect> getter, DG.Tweening.Core.DOSetter<UnityEngine.Rect> setter, System.Single elapsed, UnityEngine.Rect startValue, UnityEngine.Rect changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007F
    public class UintPlugin : ABSTweenPlugin`3
    {
        // Methods
        private System.Void Reset(DG.Tweening.Core.TweenerCore<System.UInt32,System.UInt32,DG.Tweening.Plugins.Options.UintOptions> t) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<System.UInt32,System.UInt32,DG.Tweening.Plugins.Options.UintOptions> t, System.Boolean isRelative) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<System.UInt32,System.UInt32,DG.Tweening.Plugins.Options.UintOptions> t, System.UInt32 fromValue, System.Boolean setImmediately, System.Boolean isRelative) { }
        private System.UInt32 ConvertToStartValue(DG.Tweening.Core.TweenerCore<System.UInt32,System.UInt32,DG.Tweening.Plugins.Options.UintOptions> t, System.UInt32 value) { }
        private System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<System.UInt32,System.UInt32,DG.Tweening.Plugins.Options.UintOptions> t) { }
        private System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<System.UInt32,System.UInt32,DG.Tweening.Plugins.Options.UintOptions> t) { }
        private System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.UintOptions options, System.Single unitsXSecond, System.UInt32 changeValue) { }
        private System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.UintOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<System.UInt32> getter, DG.Tweening.Core.DOSetter<System.UInt32> setter, System.Single elapsed, System.UInt32 startValue, System.UInt32 changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000080
    public class Vector2Plugin : ABSTweenPlugin`3
    {
        // Methods
        private System.Void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> t) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> t, System.Boolean isRelative) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector2 fromValue, System.Boolean setImmediately, System.Boolean isRelative) { }
        private UnityEngine.Vector2 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector2 value) { }
        private System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> t) { }
        private System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> t) { }
        private System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.VectorOptions options, System.Single unitsXSecond, UnityEngine.Vector2 changeValue) { }
        private System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.VectorOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector2> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector2> setter, System.Single elapsed, UnityEngine.Vector2 startValue, UnityEngine.Vector2 changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000081
    public class Vector4Plugin : ABSTweenPlugin`3
    {
        // Methods
        private System.Void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4,UnityEngine.Vector4,DG.Tweening.Plugins.Options.VectorOptions> t) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4,UnityEngine.Vector4,DG.Tweening.Plugins.Options.VectorOptions> t, System.Boolean isRelative) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4,UnityEngine.Vector4,DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector4 fromValue, System.Boolean setImmediately, System.Boolean isRelative) { }
        private UnityEngine.Vector4 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4,UnityEngine.Vector4,DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector4 value) { }
        private System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4,UnityEngine.Vector4,DG.Tweening.Plugins.Options.VectorOptions> t) { }
        private System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4,UnityEngine.Vector4,DG.Tweening.Plugins.Options.VectorOptions> t) { }
        private System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.VectorOptions options, System.Single unitsXSecond, UnityEngine.Vector4 changeValue) { }
        private System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.VectorOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector4> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector4> setter, System.Single elapsed, UnityEngine.Vector4 startValue, UnityEngine.Vector4 changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000082
    public class StringPlugin : ABSTweenPlugin`3
    {
        // Fields
        private static readonly System.Text.StringBuilder _Buffer;        // 0x0
        private static readonly System.Collections.Generic.List<System.Char> _OpenedTags;        // 0x8

        // Methods
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<System.String,System.String,DG.Tweening.Plugins.Options.StringOptions> t, System.Boolean isRelative) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<System.String,System.String,DG.Tweening.Plugins.Options.StringOptions> t, System.String fromValue, System.Boolean setImmediately, System.Boolean isRelative) { }
        private System.Void Reset(DG.Tweening.Core.TweenerCore<System.String,System.String,DG.Tweening.Plugins.Options.StringOptions> t) { }
        private System.String ConvertToStartValue(DG.Tweening.Core.TweenerCore<System.String,System.String,DG.Tweening.Plugins.Options.StringOptions> t, System.String value) { }
        private System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<System.String,System.String,DG.Tweening.Plugins.Options.StringOptions> t) { }
        private System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<System.String,System.String,DG.Tweening.Plugins.Options.StringOptions> t) { }
        private System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.StringOptions options, System.Single unitsXSecond, System.String changeValue) { }
        private System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.StringOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<System.String> getter, DG.Tweening.Core.DOSetter<System.String> setter, System.Single elapsed, System.String startValue, System.String changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice) { }
        private System.Text.StringBuilder Append(System.String value, System.Int32 startIndex, System.Int32 length, System.Boolean richTextEnabled) { }
        private System.Char[] ScrambledCharsToUse(DG.Tweening.Plugins.Options.StringOptions options) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000083
    public class StringPluginExtensions
    {
        // Fields
        public static readonly System.Char[] ScrambledCharsAll;        // 0x0
        public static readonly System.Char[] ScrambledCharsUppercase;        // 0x8
        public static readonly System.Char[] ScrambledCharsLowercase;        // 0x10
        public static readonly System.Char[] ScrambledCharsNumerals;        // 0x18
        private static System.Int32 _lastRndSeed;        // 0x20

        // Methods
        private System.Void .cctor() { }
        private System.Void ScrambleChars(System.Char[] chars) { }
        private System.Text.StringBuilder AppendScrambledChars(System.Text.StringBuilder buffer, System.Int32 length, System.Char[] chars) { }

    }

    // TypeToken: 0x2000084
    public class FloatPlugin : ABSTweenPlugin`3
    {
        // Methods
        private System.Void Reset(DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> t) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> t, System.Boolean isRelative) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> t, System.Single fromValue, System.Boolean setImmediately, System.Boolean isRelative) { }
        private System.Single ConvertToStartValue(DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> t, System.Single value) { }
        private System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> t) { }
        private System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> t) { }
        private System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.FloatOptions options, System.Single unitsXSecond, System.Single changeValue) { }
        private System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.FloatOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<System.Single> getter, DG.Tweening.Core.DOSetter<System.Single> setter, System.Single elapsed, System.Single startValue, System.Single changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000085
    public class Vector3Plugin : ABSTweenPlugin`3
    {
        // Methods
        private System.Void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> t) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> t, System.Boolean isRelative) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector3 fromValue, System.Boolean setImmediately, System.Boolean isRelative) { }
        private UnityEngine.Vector3 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector3 value) { }
        private System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> t) { }
        private System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> t) { }
        private System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.VectorOptions options, System.Single unitsXSecond, UnityEngine.Vector3 changeValue) { }
        private System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.VectorOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, System.Single elapsed, UnityEngine.Vector3 startValue, UnityEngine.Vector3 changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice) { }
        private System.Void .ctor() { }

    }

}

namespace DG.Tweening.Plugins.Core
{

    // TypeToken: 0x2000092
    public interface ITPlugin`4
    {
    }

    // TypeToken: 0x2000093
    public class SpecialPluginsUtils
    {
        // Methods
        private System.Boolean SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Vector3,DG.Tweening.Plugins.Options.QuaternionOptions> t) { }
        private System.Boolean SetPunch(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> t) { }
        private System.Boolean SetShake(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> t) { }
        private System.Boolean SetCameraShakePosition(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> t) { }

    }

    // TypeToken: 0x2000094
    public interface IPlugSetter`4
    {
        // Methods
        private DG.Tweening.Core.DOGetter<T1> Getter() { }
        private DG.Tweening.Core.DOSetter<T1> Setter() { }
        private T2 EndValue() { }
        private TPlugOptions GetOptions() { }

    }

    // TypeToken: 0x2000095
    public interface ITweenPlugin
    {
    }

    // TypeToken: 0x2000096
    public class ABSTweenPlugin`3, ITweenPlugin
    {
        // Methods
        private System.Void Reset(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t, System.Boolean isRelative) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t, T2 fromValue, System.Boolean setImmediately, System.Boolean isRelative) { }
        private T2 ConvertToStartValue(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t, T1 value) { }
        private System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t) { }
        private System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t) { }
        private System.Single GetSpeedBasedDuration(TPlugOptions options, System.Single unitsXSecond, T2 changeValue) { }
        private System.Void EvaluateAndApply(TPlugOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<T1> getter, DG.Tweening.Core.DOSetter<T1> setter, System.Single elapsed, T2 startValue, T2 changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000097
    public class PluginsManager
    {
        // Fields
        private static DG.Tweening.Plugins.Core.ITweenPlugin _floatPlugin;        // 0x0
        private static DG.Tweening.Plugins.Core.ITweenPlugin _doublePlugin;        // 0x8
        private static DG.Tweening.Plugins.Core.ITweenPlugin _intPlugin;        // 0x10
        private static DG.Tweening.Plugins.Core.ITweenPlugin _uintPlugin;        // 0x18
        private static DG.Tweening.Plugins.Core.ITweenPlugin _longPlugin;        // 0x20
        private static DG.Tweening.Plugins.Core.ITweenPlugin _ulongPlugin;        // 0x28
        private static DG.Tweening.Plugins.Core.ITweenPlugin _vector2Plugin;        // 0x30
        private static DG.Tweening.Plugins.Core.ITweenPlugin _vector3Plugin;        // 0x38
        private static DG.Tweening.Plugins.Core.ITweenPlugin _vector4Plugin;        // 0x40
        private static DG.Tweening.Plugins.Core.ITweenPlugin _quaternionPlugin;        // 0x48
        private static DG.Tweening.Plugins.Core.ITweenPlugin _colorPlugin;        // 0x50
        private static DG.Tweening.Plugins.Core.ITweenPlugin _rectPlugin;        // 0x58
        private static DG.Tweening.Plugins.Core.ITweenPlugin _rectOffsetPlugin;        // 0x60
        private static DG.Tweening.Plugins.Core.ITweenPlugin _stringPlugin;        // 0x68
        private static DG.Tweening.Plugins.Core.ITweenPlugin _vector3ArrayPlugin;        // 0x70
        private static DG.Tweening.Plugins.Core.ITweenPlugin _color2Plugin;        // 0x78
        private static System.Int32 _MaxCustomPlugins;        // 0x0
        private static System.Collections.Generic.Dictionary<System.Type,DG.Tweening.Plugins.Core.ITweenPlugin> _customPlugins;        // 0x80

        // Methods
        private DG.Tweening.Plugins.Core.ABSTweenPlugin<T1,T2,TPlugOptions> GetDefaultPlugin() { }
        private DG.Tweening.Plugins.Core.ABSTweenPlugin<T1,T2,TPlugOptions> GetCustomPlugin() { }
        private System.Void PurgeAll() { }

    }

}

namespace DG.Tweening.Plugins.Core.PathCore
{

    // TypeToken: 0x2000098
    public class CubicBezierDecoder : ABSPathDecoder
    {
        // Fields
        private static readonly DG.Tweening.Plugins.Core.PathCore.ControlPoint[] _PartialControlPs;        // 0x0
        private static readonly UnityEngine.Vector3[] _PartialWps;        // 0x8

        // Methods
        private System.Int32 get_minInputWaypoints() { }
        private System.Void FinalizePath(DG.Tweening.Plugins.Core.PathCore.Path p, UnityEngine.Vector3[] wps, System.Boolean isClosedPath) { }
        private UnityEngine.Vector3 GetPoint(System.Single perc, UnityEngine.Vector3[] wps, DG.Tweening.Plugins.Core.PathCore.Path p, DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints) { }
        private System.Void SetTimeToLengthTables(DG.Tweening.Plugins.Core.PathCore.Path p, System.Int32 subdivisions) { }
        private System.Void SetWaypointsLengths(DG.Tweening.Plugins.Core.PathCore.Path p, System.Int32 subdivisions) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000099
    public struct ControlPoint
    {
        // Fields
        public UnityEngine.Vector3 a;        // 0x10
        public UnityEngine.Vector3 b;        // 0x1C

        // Methods
        private System.Void .ctor(UnityEngine.Vector3 a, UnityEngine.Vector3 b) { }
        private DG.Tweening.Plugins.Core.PathCore.ControlPoint op_Addition(DG.Tweening.Plugins.Core.PathCore.ControlPoint cp, UnityEngine.Vector3 v) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200009A
    public class ABSPathDecoder
    {
        // Methods
        private System.Void FinalizePath(DG.Tweening.Plugins.Core.PathCore.Path p, UnityEngine.Vector3[] wps, System.Boolean isClosedPath) { }
        private UnityEngine.Vector3 GetPoint(System.Single perc, UnityEngine.Vector3[] wps, DG.Tweening.Plugins.Core.PathCore.Path p, DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints) { }
        private System.Int32 get_minInputWaypoints() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009B
    public class CatmullRomDecoder : ABSPathDecoder
    {
        // Fields
        private static readonly DG.Tweening.Plugins.Core.PathCore.ControlPoint[] _PartialControlPs;        // 0x0
        private static readonly UnityEngine.Vector3[] _PartialWps;        // 0x8

        // Methods
        private System.Int32 get_minInputWaypoints() { }
        private System.Void FinalizePath(DG.Tweening.Plugins.Core.PathCore.Path p, UnityEngine.Vector3[] wps, System.Boolean isClosedPath) { }
        private UnityEngine.Vector3 GetPoint(System.Single perc, UnityEngine.Vector3[] wps, DG.Tweening.Plugins.Core.PathCore.Path p, DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints) { }
        private System.Void SetTimeToLengthTables(DG.Tweening.Plugins.Core.PathCore.Path p, System.Int32 subdivisions) { }
        private System.Void SetWaypointsLengths(DG.Tweening.Plugins.Core.PathCore.Path p, System.Int32 subdivisions) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200009C
    public class LinearDecoder : ABSPathDecoder
    {
        // Methods
        private System.Int32 get_minInputWaypoints() { }
        private System.Void FinalizePath(DG.Tweening.Plugins.Core.PathCore.Path p, UnityEngine.Vector3[] wps, System.Boolean isClosedPath) { }
        private UnityEngine.Vector3 GetPoint(System.Single perc, UnityEngine.Vector3[] wps, DG.Tweening.Plugins.Core.PathCore.Path p, DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints) { }
        private System.Void SetTimeToLengthTables(DG.Tweening.Plugins.Core.PathCore.Path p, System.Int32 subdivisions) { }
        private System.Void SetWaypointsLengths(DG.Tweening.Plugins.Core.PathCore.Path p, System.Int32 subdivisions) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009D
    public class Path
    {
        // Fields
        private static DG.Tweening.Plugins.Core.PathCore.CatmullRomDecoder _catmullRomDecoder;        // 0x0
        private static DG.Tweening.Plugins.Core.PathCore.LinearDecoder _linearDecoder;        // 0x8
        private static DG.Tweening.Plugins.Core.PathCore.CubicBezierDecoder _cubicBezierDecoder;        // 0x10
        public System.Single[] wpLengths;        // 0x10
        public UnityEngine.Vector3[] wps;        // 0x18
        private DG.Tweening.PathType type;        // 0x20
        private System.Int32 subdivisionsXSegment;        // 0x24
        private System.Int32 subdivisions;        // 0x28
        private DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints;        // 0x30
        private System.Single length;        // 0x38
        private System.Boolean isFinalized;        // 0x3C
        private System.Single[] timesTable;        // 0x40
        private System.Single[] lengthsTable;        // 0x48
        private System.Int32 linearWPIndex;        // 0x50
        private System.Boolean addedExtraStartWp;        // 0x54
        private System.Boolean addedExtraEndWp;        // 0x55
        private DG.Tweening.Plugins.Options.PathOptions plugOptions;        // 0x58
        private DG.Tweening.Plugins.Core.PathCore.Path _incrementalClone;        // 0xC8
        private System.Int32 _incrementalIndex;        // 0xD0
        private DG.Tweening.Plugins.Core.PathCore.ABSPathDecoder _decoder;        // 0xD8
        private System.Boolean _changed;        // 0xE0
        private UnityEngine.Vector3[] nonLinearDrawWps;        // 0xE8
        private UnityEngine.Vector3 targetPosition;        // 0xF0
        private System.Nullable<UnityEngine.Vector3> lookAtPosition;        // 0xFC
        private UnityEngine.Color gizmoColor;        // 0x10C

        // Methods
        private System.Int32 get_minInputWaypoints() { }
        private System.Void .ctor(DG.Tweening.PathType type, UnityEngine.Vector3[] waypoints, System.Int32 subdivisionsXSegment, System.Nullable<UnityEngine.Color> gizmoColor) { }
        private System.Void .ctor() { }
        private System.Void FinalizePath(System.Boolean isClosedPath, DG.Tweening.AxisConstraint lockPositionAxes, UnityEngine.Vector3 currTargetVal) { }
        private UnityEngine.Vector3 GetPoint(System.Single perc, System.Boolean convertToConstantPerc) { }
        private System.Single ConvertToConstantPathPerc(System.Single perc) { }
        private System.Int32 GetWaypointIndexFromPerc(System.Single perc, System.Boolean isMovingForward) { }
        private UnityEngine.Vector3[] GetDrawPoints(DG.Tweening.Plugins.Core.PathCore.Path p, System.Int32 drawSubdivisionsXSegment) { }
        private System.Void RefreshNonLinearDrawWps(DG.Tweening.Plugins.Core.PathCore.Path p) { }
        private System.Void Destroy() { }
        private DG.Tweening.Plugins.Core.PathCore.Path CloneIncremental(System.Int32 loopIncrement) { }
        private System.Void AssignWaypoints(UnityEngine.Vector3[] newWps, System.Boolean cloneWps) { }
        private System.Void AssignDecoder(DG.Tweening.PathType pathType) { }
        private System.Void Draw() { }
        private System.Void Draw(DG.Tweening.Plugins.Core.PathCore.Path p) { }
        private UnityEngine.Vector3 ConvertToDrawPoint(UnityEngine.Vector3 wp, DG.Tweening.Plugins.Options.PathOptions plugOptions) { }

    }

}

namespace DG.Tweening.Plugins.Options
{

    // TypeToken: 0x2000086
    public interface IPlugOptions
    {
        // Methods
        private System.Void Reset() { }

    }

    // TypeToken: 0x2000087
    public struct OrientType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.Plugins.Options.OrientType None;        // 0x0
        public static DG.Tweening.Plugins.Options.OrientType ToPath;        // 0x0
        public static DG.Tweening.Plugins.Options.OrientType LookAtTransform;        // 0x0
        public static DG.Tweening.Plugins.Options.OrientType LookAtPosition;        // 0x0

    }

    // TypeToken: 0x2000088
    public struct PathOptions, IPlugOptions
    {
        // Fields
        public DG.Tweening.PathMode mode;        // 0x10
        public DG.Tweening.Plugins.Options.OrientType orientType;        // 0x14
        public DG.Tweening.AxisConstraint lockPositionAxis;        // 0x18
        public DG.Tweening.AxisConstraint lockRotationAxis;        // 0x1C
        public System.Boolean isClosedPath;        // 0x20
        public UnityEngine.Vector3 lookAtPosition;        // 0x24
        public UnityEngine.Transform lookAtTransform;        // 0x30
        public System.Single lookAhead;        // 0x38
        public System.Boolean hasCustomForwardDirection;        // 0x3C
        public UnityEngine.Quaternion forward;        // 0x40
        public System.Boolean useLocalPosition;        // 0x50
        public UnityEngine.Transform parent;        // 0x58
        public System.Boolean isRigidbody;        // 0x60
        public System.Boolean isRigidbody2D;        // 0x61
        public System.Boolean stableZRotation;        // 0x62
        private UnityEngine.Quaternion startupRot;        // 0x64
        private System.Single startupZRot;        // 0x74
        private System.Boolean addedExtraStartWp;        // 0x78
        private System.Boolean addedExtraEndWp;        // 0x79

        // Methods
        private System.Void Reset() { }

    }

    // TypeToken: 0x2000089
    public struct QuaternionOptions, IPlugOptions
    {
        // Fields
        public DG.Tweening.RotateMode rotateMode;        // 0x10
        public DG.Tweening.AxisConstraint axisConstraint;        // 0x14
        public UnityEngine.Vector3 up;        // 0x18
        public System.Boolean dynamicLookAt;        // 0x24
        public UnityEngine.Vector3 dynamicLookAtWorldPosition;        // 0x28

        // Methods
        private System.Void Reset() { }

    }

    // TypeToken: 0x200008A
    public struct UintOptions, IPlugOptions
    {
        // Fields
        public System.Boolean isNegativeChangeValue;        // 0x10

        // Methods
        private System.Void Reset() { }

    }

    // TypeToken: 0x200008B
    public struct Vector3ArrayOptions, IPlugOptions
    {
        // Fields
        public DG.Tweening.AxisConstraint axisConstraint;        // 0x10
        public System.Boolean snapping;        // 0x14
        private System.Single[] durations;        // 0x18

        // Methods
        private System.Void Reset() { }

    }

    // TypeToken: 0x200008C
    public struct NoOptions, IPlugOptions
    {
        // Methods
        private System.Void Reset() { }

    }

    // TypeToken: 0x200008D
    public struct ColorOptions, IPlugOptions
    {
        // Fields
        public System.Boolean alphaOnly;        // 0x10

        // Methods
        private System.Void Reset() { }

    }

    // TypeToken: 0x200008E
    public struct FloatOptions, IPlugOptions
    {
        // Fields
        public System.Boolean snapping;        // 0x10

        // Methods
        private System.Void Reset() { }

    }

    // TypeToken: 0x200008F
    public struct RectOptions, IPlugOptions
    {
        // Fields
        public System.Boolean snapping;        // 0x10

        // Methods
        private System.Void Reset() { }

    }

    // TypeToken: 0x2000090
    public struct StringOptions, IPlugOptions
    {
        // Fields
        public System.Boolean richTextEnabled;        // 0x10
        public DG.Tweening.ScrambleMode scrambleMode;        // 0x14
        public System.Char[] scrambledChars;        // 0x18
        private System.Int32 startValueStrippedLength;        // 0x20
        private System.Int32 changeValueStrippedLength;        // 0x24

        // Methods
        private System.Void Reset() { }

    }

    // TypeToken: 0x2000091
    public struct VectorOptions, IPlugOptions
    {
        // Fields
        public DG.Tweening.AxisConstraint axisConstraint;        // 0x10
        public System.Boolean snapping;        // 0x14

        // Methods
        private System.Void Reset() { }

    }

}

