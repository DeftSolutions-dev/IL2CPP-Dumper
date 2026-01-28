// ========================================================
// Dumped by @desirepro
// Assembly: DOTween.dll
// Classes:  201
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: CubicBezier
TYPE:  class
TOKEN: 0x2000009
FIELDS:
METHODS:
  UnityEngine.Vector3 GetPointOnSegment(UnityEngine.Vector3 startPoint, UnityEngine.Vector3 startControlPoint, UnityEngine.Vector3 endPoint, UnityEngine.Vector3 endControlPoint, System.Single factor)
  UnityEngine.Vector3[] GetSegmentPointCloud(UnityEngine.Vector3 startPoint, UnityEngine.Vector3 startControlPoint, UnityEngine.Vector3 endPoint, UnityEngine.Vector3 endControlPoint, System.Int32 resolution)
  System.Void GetSegmentPointCloud(System.Collections.Generic.List<UnityEngine.Vector3> addToList, UnityEngine.Vector3 startPoint, UnityEngine.Vector3 startControlPoint, UnityEngine.Vector3 endPoint, UnityEngine.Vector3 endControlPoint, System.Int32 resolution)
END_CLASS

CLASS: Sequence
TYPE:  class
TOKEN: 0x20000A3
FIELDS:
METHODS:
  System.Void LogAddToNullSequence()
  System.Void LogAddToInactiveSequence()
  System.Void LogAddToLockedSequence()
  System.Void LogAddNullTween()
  System.Void LogAddInactiveTween(DG.Tweening.Tween t)
  System.Void LogAddAlreadySequencedTween(DG.Tweening.Tween t)
END_CLASS

CLASS: SettingsLocation
TYPE:  struct
TOKEN: 0x20000AC
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.Core.DOTweenSettings.SettingsLocationAssetsDirectory  // 0x0
  public    static  DG.Tweening.Core.DOTweenSettings.SettingsLocationDOTweenDirectory  // 0x0
  public    static  DG.Tweening.Core.DOTweenSettings.SettingsLocationDemigiantDirectory  // 0x0
METHODS:
END_CLASS

CLASS: SafeModeOptions
TYPE:  class
TOKEN: 0x20000AD
FIELDS:
  public            DG.Tweening.Core.Enums.SafeModeLogBehaviourlogBehaviour  // 0x10
  public            DG.Tweening.Core.Enums.NestedTweenFailureBehaviournestedTweenFailureBehaviour  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ModulesSetup
TYPE:  class
TOKEN: 0x20000AE
FIELDS:
  public            System.Boolean                  showPanel  // 0x10
  public            System.Boolean                  audioEnabled  // 0x11
  public            System.Boolean                  physicsEnabled  // 0x12
  public            System.Boolean                  physics2DEnabled  // 0x13
  public            System.Boolean                  spriteEnabled  // 0x14
  public            System.Boolean                  uiEnabled  // 0x15
  public            System.Boolean                  textMeshProEnabled  // 0x16
  public            System.Boolean                  tk2DEnabled  // 0x17
  public            System.Boolean                  deAudioEnabled  // 0x18
  public            System.Boolean                  deUnityExtendedEnabled  // 0x19
  public            System.Boolean                  epoOutlineEnabled  // 0x1A
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: SafeModeReportType
TYPE:  struct
TOKEN: 0x20000B2
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.Core.SafeModeReport.SafeModeReportTypeUnset  // 0x0
  public    static  DG.Tweening.Core.SafeModeReport.SafeModeReportTypeTargetOrFieldMissing  // 0x0
  public    static  DG.Tweening.Core.SafeModeReport.SafeModeReportTypeCallback  // 0x0
  public    static  DG.Tweening.Core.SafeModeReport.SafeModeReportTypeStartupFailure  // 0x0
METHODS:
END_CLASS

CLASS: CapacityIncreaseMode
TYPE:  struct
TOKEN: 0x20000B6
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.Core.TweenManager.CapacityIncreaseModeTweenersAndSequences  // 0x0
  public    static  DG.Tweening.Core.TweenManager.CapacityIncreaseModeTweenersOnly  // 0x0
  public    static  DG.Tweening.Core.TweenManager.CapacityIncreaseModeSequencesOnly  // 0x0
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=20
TYPE:  struct
TOKEN: 0x20000C7
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=50
TYPE:  struct
TOKEN: 0x20000C8
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=120
TYPE:  struct
TOKEN: 0x20000C9
FIELDS:
METHODS:
END_CLASS

CLASS: DG.Tweening.AutoPlay
TYPE:  struct
TOKEN: 0x2000002
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.AutoPlay            None  // 0x0
  public    static  DG.Tweening.AutoPlay            AutoPlaySequences  // 0x0
  public    static  DG.Tweening.AutoPlay            AutoPlayTweeners  // 0x0
  public    static  DG.Tweening.AutoPlay            All  // 0x0
METHODS:
END_CLASS

CLASS: DG.Tweening.AxisConstraint
TYPE:  struct
TOKEN: 0x2000003
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.AxisConstraint      None  // 0x0
  public    static  DG.Tweening.AxisConstraint      X  // 0x0
  public    static  DG.Tweening.AxisConstraint      Y  // 0x0
  public    static  DG.Tweening.AxisConstraint      Z  // 0x0
  public    static  DG.Tweening.AxisConstraint      W  // 0x0
METHODS:
END_CLASS

CLASS: DG.Tweening.Color2
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  public            UnityEngine.Color               ca  // 0x10
  public            UnityEngine.Color               cb  // 0x20
METHODS:
  System.Void .ctor(UnityEngine.Color ca, UnityEngine.Color cb)
  DG.Tweening.Color2 op_Addition(DG.Tweening.Color2 c1, DG.Tweening.Color2 c2)
  DG.Tweening.Color2 op_Subtraction(DG.Tweening.Color2 c1, DG.Tweening.Color2 c2)
  DG.Tweening.Color2 op_Multiply(DG.Tweening.Color2 c1, System.Single f)
END_CLASS

CLASS: DG.Tweening.TweenCallback
TYPE:  class
TOKEN: 0x2000005
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
  System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: DG.Tweening.TweenCallback`1
TYPE:  class
TOKEN: 0x2000006
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T value)
  System.IAsyncResult BeginInvoke(T value, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: DG.Tweening.EaseFunction
TYPE:  class
TOKEN: 0x2000007
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Single Invoke(System.Single time, System.Single duration, System.Single overshootOrAmplitude, System.Single period)
  System.IAsyncResult BeginInvoke(System.Single time, System.Single duration, System.Single overshootOrAmplitude, System.Single period, System.AsyncCallback callback, System.Object object)
  System.Single EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: DG.Tweening.DOCurve
TYPE:  class
TOKEN: 0x2000008
FIELDS:
METHODS:
END_CLASS

CLASS: DG.Tweening.DOTween
TYPE:  class
TOKEN: 0x200000A
FIELDS:
  public    static readonly System.String                   Version  // 0x0
  public    static  System.Boolean                  useSafeMode  // 0x8
  public    static  DG.Tweening.Core.Enums.SafeModeLogBehavioursafeModeLogBehaviour  // 0xC
  public    static  DG.Tweening.Core.Enums.NestedTweenFailureBehaviournestedTweenFailureBehaviour  // 0x10
  public    static  System.Boolean                  showUnityEditorReport  // 0x14
  public    static  System.Single                   timeScale  // 0x18
  public    static  System.Single                   unscaledTimeScale  // 0x1C
  public    static  System.Boolean                  useSmoothDeltaTime  // 0x20
  public    static  System.Single                   maxSmoothUnscaledTime  // 0x24
  private   static  DG.Tweening.Core.Enums.RewindCallbackModerewindCallbackMode  // 0x28
  private   static  DG.Tweening.LogBehaviour        _logBehaviour  // 0x2C
  public    static  System.Func<UnityEngine.LogType,System.Object,System.Boolean>onWillLog  // 0x30
  public    static  System.Boolean                  drawGizmos  // 0x38
  public    static  System.Boolean                  debugMode  // 0x39
  private   static  System.Boolean                  _fooDebugStoreTargetId  // 0x3A
  public    static  DG.Tweening.UpdateType          defaultUpdateType  // 0x3C
  public    static  System.Boolean                  defaultTimeScaleIndependent  // 0x40
  public    static  DG.Tweening.AutoPlay            defaultAutoPlay  // 0x44
  public    static  System.Boolean                  defaultAutoKill  // 0x48
  public    static  DG.Tweening.LoopType            defaultLoopType  // 0x4C
  public    static  System.Boolean                  defaultRecyclable  // 0x50
  public    static  DG.Tweening.Ease                defaultEaseType  // 0x54
  public    static  System.Single                   defaultEaseOvershootOrAmplitude  // 0x58
  public    static  System.Single                   defaultEasePeriod  // 0x5C
  public    static  DG.Tweening.Core.DOTweenComponentinstance  // 0x60
  private   static  System.Boolean                  _foo_isQuitting  // 0x68
  private   static  System.Int32                    maxActiveTweenersReached  // 0x6C
  private   static  System.Int32                    maxActiveSequencesReached  // 0x70
  private   static  DG.Tweening.Core.SafeModeReport safeModeReport  // 0x74
  private   static readonly System.Collections.Generic.List<DG.Tweening.TweenCallback>GizmosDelegates  // 0x88
  private   static  System.Boolean                  initialized  // 0x90
  private   static  System.Int32                    _isQuittingFrame  // 0x94
METHODS:
  DG.Tweening.LogBehaviour get_logBehaviour()
  System.Void set_logBehaviour(DG.Tweening.LogBehaviour value)
  System.Boolean get_debugStoreTargetId()
  System.Void set_debugStoreTargetId(System.Boolean value)
  System.Boolean get_isQuitting()
  System.Void set_isQuitting(System.Boolean value)
  DG.Tweening.IDOTweenInit Init(System.Nullable<System.Boolean> recycleAllByDefault, System.Nullable<System.Boolean> useSafeMode, System.Nullable<DG.Tweening.LogBehaviour> logBehaviour)
  System.Void AutoInit()
  DG.Tweening.IDOTweenInit Init(DG.Tweening.Core.DOTweenSettings settings, System.Nullable<System.Boolean> recycleAllByDefault, System.Nullable<System.Boolean> useSafeMode, System.Nullable<DG.Tweening.LogBehaviour> logBehaviour)
  System.Void SetTweensCapacity(System.Int32 tweenersCapacity, System.Int32 sequencesCapacity)
  System.Void Clear(System.Boolean destroy)
  System.Void Clear(System.Boolean destroy, System.Boolean isApplicationQuitting)
  System.Void ClearCachedTweens()
  System.Int32 Validate()
  System.Void ManualUpdate(System.Single deltaTime, System.Single unscaledDeltaTime)
  DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> To(DG.Tweening.Core.DOGetter<System.Single> getter, DG.Tweening.Core.DOSetter<System.Single> setter, System.Single endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<System.Double,System.Double,DG.Tweening.Plugins.Options.NoOptions> To(DG.Tweening.Core.DOGetter<System.Double> getter, DG.Tweening.Core.DOSetter<System.Double> setter, System.Double endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<System.Int32,System.Int32,DG.Tweening.Plugins.Options.NoOptions> To(DG.Tweening.Core.DOGetter<System.Int32> getter, DG.Tweening.Core.DOSetter<System.Int32> setter, System.Int32 endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<System.UInt32,System.UInt32,DG.Tweening.Plugins.Options.UintOptions> To(DG.Tweening.Core.DOGetter<System.UInt32> getter, DG.Tweening.Core.DOSetter<System.UInt32> setter, System.UInt32 endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<System.Int64,System.Int64,DG.Tweening.Plugins.Options.NoOptions> To(DG.Tweening.Core.DOGetter<System.Int64> getter, DG.Tweening.Core.DOSetter<System.Int64> setter, System.Int64 endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<System.UInt64,System.UInt64,DG.Tweening.Plugins.Options.NoOptions> To(DG.Tweening.Core.DOGetter<System.UInt64> getter, DG.Tweening.Core.DOSetter<System.UInt64> setter, System.UInt64 endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<System.String,System.String,DG.Tweening.Plugins.Options.StringOptions> To(DG.Tweening.Core.DOGetter<System.String> getter, DG.Tweening.Core.DOSetter<System.String> setter, System.String endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Vector2> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector2> setter, UnityEngine.Vector2 endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, UnityEngine.Vector3 endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector4,UnityEngine.Vector4,DG.Tweening.Plugins.Options.VectorOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Vector4> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector4> setter, UnityEngine.Vector4 endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Vector3,DG.Tweening.Plugins.Options.QuaternionOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Quaternion> getter, DG.Tweening.Core.DOSetter<UnityEngine.Quaternion> setter, UnityEngine.Vector3 endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Color> getter, DG.Tweening.Core.DOSetter<UnityEngine.Color> setter, UnityEngine.Color endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<UnityEngine.Rect,UnityEngine.Rect,DG.Tweening.Plugins.Options.RectOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Rect> getter, DG.Tweening.Core.DOSetter<UnityEngine.Rect> setter, UnityEngine.Rect endValue, System.Single duration)
  DG.Tweening.Tweener To(DG.Tweening.Core.DOGetter<UnityEngine.RectOffset> getter, DG.Tweening.Core.DOSetter<UnityEngine.RectOffset> setter, UnityEngine.RectOffset endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> To(DG.Tweening.Plugins.Core.ABSTweenPlugin<T1,T2,TPlugOptions> plugin, DG.Tweening.Core.DOGetter<T1> getter, DG.Tweening.Core.DOSetter<T1> setter, T2 endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> ToAxis(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, System.Single endValue, System.Single duration, DG.Tweening.AxisConstraint axisConstraint)
  DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> ToAlpha(DG.Tweening.Core.DOGetter<UnityEngine.Color> getter, DG.Tweening.Core.DOSetter<UnityEngine.Color> setter, System.Single endValue, System.Single duration)
  DG.Tweening.Tweener To(DG.Tweening.Core.DOSetter<System.Single> setter, System.Single startValue, System.Single endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> Punch(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, UnityEngine.Vector3 direction, System.Single duration, System.Int32 vibrato, System.Single elasticity)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> Shake(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, System.Single duration, System.Single strength, System.Int32 vibrato, System.Single randomness, System.Boolean ignoreZAxis, System.Boolean fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> Shake(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, System.Single duration, UnityEngine.Vector3 strength, System.Int32 vibrato, System.Single randomness, System.Boolean fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> Shake(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, System.Single duration, UnityEngine.Vector3 strength, System.Int32 vibrato, System.Single randomness, System.Boolean ignoreZAxis, System.Boolean vectorBased, System.Boolean fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> ToArray(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, UnityEngine.Vector3[] endValues, System.Single[] durations)
  DG.Tweening.Core.TweenerCore<DG.Tweening.Color2,DG.Tweening.Color2,DG.Tweening.Plugins.Options.ColorOptions> To(DG.Tweening.Core.DOGetter<DG.Tweening.Color2> getter, DG.Tweening.Core.DOSetter<DG.Tweening.Color2> setter, DG.Tweening.Color2 endValue, System.Single duration)
  DG.Tweening.Sequence Sequence()
  DG.Tweening.Sequence Sequence(System.Object target)
  System.Int32 CompleteAll(System.Boolean withCallbacks)
  System.Int32 Complete(System.Object targetOrId, System.Boolean withCallbacks)
  System.Int32 CompleteAndReturnKilledTot()
  System.Int32 CompleteAndReturnKilledTot(System.Object targetOrId)
  System.Int32 CompleteAndReturnKilledTot(System.Object target, System.Object id)
  System.Int32 CompleteAndReturnKilledTotExceptFor(System.Object[] excludeTargetsOrIds)
  System.Int32 FlipAll()
  System.Int32 Flip(System.Object targetOrId)
  System.Int32 GotoAll(System.Single to, System.Boolean andPlay)
  System.Int32 Goto(System.Object targetOrId, System.Single to, System.Boolean andPlay)
  System.Int32 KillAll(System.Boolean complete)
  System.Int32 KillAll(System.Boolean complete, System.Object[] idsOrTargetsToExclude)
  System.Int32 Kill(System.Object targetOrId, System.Boolean complete)
  System.Int32 Kill(System.Object target, System.Object id, System.Boolean complete)
  System.Int32 PauseAll()
  System.Int32 Pause(System.Object targetOrId)
  System.Int32 PlayAll()
  System.Int32 Play(System.Object targetOrId)
  System.Int32 Play(System.Object target, System.Object id)
  System.Int32 PlayBackwardsAll()
  System.Int32 PlayBackwards(System.Object targetOrId)
  System.Int32 PlayBackwards(System.Object target, System.Object id)
  System.Int32 PlayForwardAll()
  System.Int32 PlayForward(System.Object targetOrId)
  System.Int32 PlayForward(System.Object target, System.Object id)
  System.Int32 RestartAll(System.Boolean includeDelay)
  System.Int32 Restart(System.Object targetOrId, System.Boolean includeDelay, System.Single changeDelayTo)
  System.Int32 Restart(System.Object target, System.Object id, System.Boolean includeDelay, System.Single changeDelayTo)
  System.Int32 RewindAll(System.Boolean includeDelay)
  System.Int32 Rewind(System.Object targetOrId, System.Boolean includeDelay)
  System.Int32 SmoothRewindAll()
  System.Int32 SmoothRewind(System.Object targetOrId)
  System.Int32 TogglePauseAll()
  System.Int32 TogglePause(System.Object targetOrId)
  System.Boolean IsTweening(System.Object targetOrId, System.Boolean alsoCheckIfIsPlaying)
  System.Int32 TotalActiveTweens()
  System.Int32 TotalActiveTweeners()
  System.Int32 TotalActiveSequences()
  System.Int32 TotalPlayingTweens()
  System.Int32 TotalTweensById(System.Object id, System.Boolean playingOnly)
  System.Collections.Generic.List<DG.Tweening.Tween> PlayingTweens(System.Collections.Generic.List<DG.Tweening.Tween> fillableList)
  System.Collections.Generic.List<DG.Tweening.Tween> PausedTweens(System.Collections.Generic.List<DG.Tweening.Tween> fillableList)
  System.Collections.Generic.List<DG.Tweening.Tween> TweensById(System.Object id, System.Boolean playingOnly, System.Collections.Generic.List<DG.Tweening.Tween> fillableList)
  System.Collections.Generic.List<DG.Tweening.Tween> TweensByTarget(System.Object target, System.Boolean playingOnly, System.Collections.Generic.List<DG.Tweening.Tween> fillableList)
  System.Void InitCheck()
  DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> ApplyTo(DG.Tweening.Core.DOGetter<T1> getter, DG.Tweening.Core.DOSetter<T1> setter, T2 endValue, System.Single duration, DG.Tweening.Plugins.Core.ABSTweenPlugin<T1,T2,TPlugOptions> plugin)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: DG.Tweening.DOVirtual
TYPE:  class
TOKEN: 0x200000C
FIELDS:
METHODS:
  DG.Tweening.Tweener Float(System.Single from, System.Single to, System.Single duration, DG.Tweening.TweenCallback<System.Single> onVirtualUpdate)
  DG.Tweening.Tweener Int(System.Int32 from, System.Int32 to, System.Single duration, DG.Tweening.TweenCallback<System.Int32> onVirtualUpdate)
  DG.Tweening.Tweener Vector3(UnityEngine.Vector3 from, UnityEngine.Vector3 to, System.Single duration, DG.Tweening.TweenCallback<UnityEngine.Vector3> onVirtualUpdate)
  DG.Tweening.Tweener Color(UnityEngine.Color from, UnityEngine.Color to, System.Single duration, DG.Tweening.TweenCallback<UnityEngine.Color> onVirtualUpdate)
  System.Single EasedValue(System.Single from, System.Single to, System.Single lifetimePercentage, DG.Tweening.Ease easeType)
  System.Single EasedValue(System.Single from, System.Single to, System.Single lifetimePercentage, DG.Tweening.Ease easeType, System.Single overshoot)
  System.Single EasedValue(System.Single from, System.Single to, System.Single lifetimePercentage, DG.Tweening.Ease easeType, System.Single amplitude, System.Single period)
  System.Single EasedValue(System.Single from, System.Single to, System.Single lifetimePercentage, UnityEngine.AnimationCurve easeCurve)
  UnityEngine.Vector3 EasedValue(UnityEngine.Vector3 from, UnityEngine.Vector3 to, System.Single lifetimePercentage, DG.Tweening.Ease easeType)
  UnityEngine.Vector3 EasedValue(UnityEngine.Vector3 from, UnityEngine.Vector3 to, System.Single lifetimePercentage, DG.Tweening.Ease easeType, System.Single overshoot)
  UnityEngine.Vector3 EasedValue(UnityEngine.Vector3 from, UnityEngine.Vector3 to, System.Single lifetimePercentage, DG.Tweening.Ease easeType, System.Single amplitude, System.Single period)
  UnityEngine.Vector3 EasedValue(UnityEngine.Vector3 from, UnityEngine.Vector3 to, System.Single lifetimePercentage, UnityEngine.AnimationCurve easeCurve)
  DG.Tweening.Tween DelayedCall(System.Single delay, DG.Tweening.TweenCallback callback, System.Boolean ignoreTimeScale)
END_CLASS

CLASS: DG.Tweening.Ease
TYPE:  struct
TOKEN: 0x2000011
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.Ease                Unset  // 0x0
  public    static  DG.Tweening.Ease                Linear  // 0x0
  public    static  DG.Tweening.Ease                InSine  // 0x0
  public    static  DG.Tweening.Ease                OutSine  // 0x0
  public    static  DG.Tweening.Ease                InOutSine  // 0x0
  public    static  DG.Tweening.Ease                InQuad  // 0x0
  public    static  DG.Tweening.Ease                OutQuad  // 0x0
  public    static  DG.Tweening.Ease                InOutQuad  // 0x0
  public    static  DG.Tweening.Ease                InCubic  // 0x0
  public    static  DG.Tweening.Ease                OutCubic  // 0x0
  public    static  DG.Tweening.Ease                InOutCubic  // 0x0
  public    static  DG.Tweening.Ease                InQuart  // 0x0
  public    static  DG.Tweening.Ease                OutQuart  // 0x0
  public    static  DG.Tweening.Ease                InOutQuart  // 0x0
  public    static  DG.Tweening.Ease                InQuint  // 0x0
  public    static  DG.Tweening.Ease                OutQuint  // 0x0
  public    static  DG.Tweening.Ease                InOutQuint  // 0x0
  public    static  DG.Tweening.Ease                InExpo  // 0x0
  public    static  DG.Tweening.Ease                OutExpo  // 0x0
  public    static  DG.Tweening.Ease                InOutExpo  // 0x0
  public    static  DG.Tweening.Ease                InCirc  // 0x0
  public    static  DG.Tweening.Ease                OutCirc  // 0x0
  public    static  DG.Tweening.Ease                InOutCirc  // 0x0
  public    static  DG.Tweening.Ease                InElastic  // 0x0
  public    static  DG.Tweening.Ease                OutElastic  // 0x0
  public    static  DG.Tweening.Ease                InOutElastic  // 0x0
  public    static  DG.Tweening.Ease                InBack  // 0x0
  public    static  DG.Tweening.Ease                OutBack  // 0x0
  public    static  DG.Tweening.Ease                InOutBack  // 0x0
  public    static  DG.Tweening.Ease                InBounce  // 0x0
  public    static  DG.Tweening.Ease                OutBounce  // 0x0
  public    static  DG.Tweening.Ease                InOutBounce  // 0x0
  public    static  DG.Tweening.Ease                Flash  // 0x0
  public    static  DG.Tweening.Ease                InFlash  // 0x0
  public    static  DG.Tweening.Ease                OutFlash  // 0x0
  public    static  DG.Tweening.Ease                InOutFlash  // 0x0
  public    static  DG.Tweening.Ease                INTERNAL_Zero  // 0x0
  public    static  DG.Tweening.Ease                INTERNAL_Custom  // 0x0
METHODS:
END_CLASS

CLASS: DG.Tweening.EaseFactory
TYPE:  class
TOKEN: 0x2000012
FIELDS:
METHODS:
  DG.Tweening.EaseFunction StopMotion(System.Int32 motionFps, System.Nullable<DG.Tweening.Ease> ease)
  DG.Tweening.EaseFunction StopMotion(System.Int32 motionFps, UnityEngine.AnimationCurve animCurve)
  DG.Tweening.EaseFunction StopMotion(System.Int32 motionFps, DG.Tweening.EaseFunction customEase)
  System.Void .ctor()
END_CLASS

CLASS: DG.Tweening.IDOTweenInit
TYPE:  interface
TOKEN: 0x2000014
FIELDS:
METHODS:
  DG.Tweening.IDOTweenInit SetCapacity(System.Int32 tweenersCapacity, System.Int32 sequencesCapacity)
END_CLASS

CLASS: DG.Tweening.LinkBehaviour
TYPE:  struct
TOKEN: 0x2000015
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.LinkBehaviour       PauseOnDisable  // 0x0
  public    static  DG.Tweening.LinkBehaviour       PauseOnDisablePlayOnEnable  // 0x0
  public    static  DG.Tweening.LinkBehaviour       PauseOnDisableRestartOnEnable  // 0x0
  public    static  DG.Tweening.LinkBehaviour       PlayOnEnable  // 0x0
  public    static  DG.Tweening.LinkBehaviour       RestartOnEnable  // 0x0
  public    static  DG.Tweening.LinkBehaviour       KillOnDisable  // 0x0
  public    static  DG.Tweening.LinkBehaviour       KillOnDestroy  // 0x0
  public    static  DG.Tweening.LinkBehaviour       CompleteOnDisable  // 0x0
  public    static  DG.Tweening.LinkBehaviour       CompleteAndKillOnDisable  // 0x0
  public    static  DG.Tweening.LinkBehaviour       RewindOnDisable  // 0x0
  public    static  DG.Tweening.LinkBehaviour       RewindAndKillOnDisable  // 0x0
METHODS:
END_CLASS

CLASS: DG.Tweening.PathMode
TYPE:  struct
TOKEN: 0x2000016
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.PathMode            Ignore  // 0x0
  public    static  DG.Tweening.PathMode            Full3D  // 0x0
  public    static  DG.Tweening.PathMode            TopDown2D  // 0x0
  public    static  DG.Tweening.PathMode            Sidescroller2D  // 0x0
METHODS:
END_CLASS

CLASS: DG.Tweening.PathType
TYPE:  struct
TOKEN: 0x2000017
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.PathType            Linear  // 0x0
  public    static  DG.Tweening.PathType            CatmullRom  // 0x0
  public    static  DG.Tweening.PathType            CubicBezier  // 0x0
METHODS:
END_CLASS

CLASS: DG.Tweening.RotateMode
TYPE:  struct
TOKEN: 0x2000018
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.RotateMode          Fast  // 0x0
  public    static  DG.Tweening.RotateMode          FastBeyond360  // 0x0
  public    static  DG.Tweening.RotateMode          WorldAxisAdd  // 0x0
  public    static  DG.Tweening.RotateMode          LocalAxisAdd  // 0x0
METHODS:
END_CLASS

CLASS: DG.Tweening.ScrambleMode
TYPE:  struct
TOKEN: 0x2000019
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.ScrambleMode        None  // 0x0
  public    static  DG.Tweening.ScrambleMode        All  // 0x0
  public    static  DG.Tweening.ScrambleMode        Uppercase  // 0x0
  public    static  DG.Tweening.ScrambleMode        Lowercase  // 0x0
  public    static  DG.Tweening.ScrambleMode        Numerals  // 0x0
  public    static  DG.Tweening.ScrambleMode        Custom  // 0x0
METHODS:
END_CLASS

CLASS: DG.Tweening.ShakeRandomnessMode
TYPE:  struct
TOKEN: 0x200001A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.ShakeRandomnessMode Full  // 0x0
  public    static  DG.Tweening.ShakeRandomnessMode Harmonic  // 0x0
METHODS:
END_CLASS

CLASS: DG.Tweening.TweenExtensions
TYPE:  class
TOKEN: 0x200001B
FIELDS:
METHODS:
  System.Void Complete(DG.Tweening.Tween t)
  System.Void Complete(DG.Tweening.Tween t, System.Boolean withCallbacks)
  System.Void Flip(DG.Tweening.Tween t)
  System.Void ForceInit(DG.Tweening.Tween t)
  System.Void Goto(DG.Tweening.Tween t, System.Single to, System.Boolean andPlay)
  System.Void GotoWithCallbacks(DG.Tweening.Tween t, System.Single to, System.Boolean andPlay)
  System.Void DoGoto(DG.Tweening.Tween t, System.Single to, System.Boolean andPlay, System.Boolean withCallbacks)
  System.Void Kill(DG.Tweening.Tween t, System.Boolean complete)
  System.Void ManualUpdate(DG.Tweening.Tween t, System.Single deltaTime, System.Single unscaledDeltaTime)
  T Pause(T t)
  T Play(T t)
  System.Void PlayBackwards(DG.Tweening.Tween t)
  System.Void PlayForward(DG.Tweening.Tween t)
  System.Void Restart(DG.Tweening.Tween t, System.Boolean includeDelay, System.Single changeDelayTo)
  System.Void Rewind(DG.Tweening.Tween t, System.Boolean includeDelay)
  System.Void SmoothRewind(DG.Tweening.Tween t)
  System.Void TogglePause(DG.Tweening.Tween t)
  System.Void GotoWaypoint(DG.Tweening.Tween t, System.Int32 waypointIndex, System.Boolean andPlay)
  UnityEngine.YieldInstruction WaitForCompletion(DG.Tweening.Tween t)
  UnityEngine.YieldInstruction WaitForRewind(DG.Tweening.Tween t)
  UnityEngine.YieldInstruction WaitForKill(DG.Tweening.Tween t)
  UnityEngine.YieldInstruction WaitForElapsedLoops(DG.Tweening.Tween t, System.Int32 elapsedLoops)
  UnityEngine.YieldInstruction WaitForPosition(DG.Tweening.Tween t, System.Single position)
  UnityEngine.Coroutine WaitForStart(DG.Tweening.Tween t)
  System.Int32 CompletedLoops(DG.Tweening.Tween t)
  System.Single Delay(DG.Tweening.Tween t)
  System.Single ElapsedDelay(DG.Tweening.Tween t)
  System.Single Duration(DG.Tweening.Tween t, System.Boolean includeLoops)
  System.Single Elapsed(DG.Tweening.Tween t, System.Boolean includeLoops)
  System.Single ElapsedPercentage(DG.Tweening.Tween t, System.Boolean includeLoops)
  System.Single ElapsedDirectionalPercentage(DG.Tweening.Tween t)
  System.Boolean IsActive(DG.Tweening.Tween t)
  System.Boolean IsBackwards(DG.Tweening.Tween t)
  System.Boolean IsComplete(DG.Tweening.Tween t)
  System.Boolean IsInitialized(DG.Tweening.Tween t)
  System.Boolean IsPlaying(DG.Tweening.Tween t)
  System.Int32 Loops(DG.Tweening.Tween t)
  UnityEngine.Vector3 PathGetPoint(DG.Tweening.Tween t, System.Single pathPercentage)
  UnityEngine.Vector3[] PathGetDrawPoints(DG.Tweening.Tween t, System.Int32 subdivisionsXSegment)
  System.Single PathLength(DG.Tweening.Tween t)
END_CLASS

CLASS: DG.Tweening.LoopType
TYPE:  struct
TOKEN: 0x200001C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.LoopType            Restart  // 0x0
  public    static  DG.Tweening.LoopType            Yoyo  // 0x0
  public    static  DG.Tweening.LoopType            Incremental  // 0x0
METHODS:
END_CLASS

CLASS: DG.Tweening.Sequence
TYPE:  class
TOKEN: 0x200001D
EXTENDS: Tween
FIELDS:
  private   readonly System.Collections.Generic.List<DG.Tweening.Tween>sequencedTweens  // 0x120
  private   readonly System.Collections.Generic.List<DG.Tweening.Core.ABSSequentiable>_sequencedObjs  // 0x128
  private           System.Single                   lastTweenInsertTime  // 0x130
METHODS:
  System.Void .ctor()
  DG.Tweening.Sequence DoPrepend(DG.Tweening.Sequence inSequence, DG.Tweening.Tween t)
  DG.Tweening.Sequence DoInsert(DG.Tweening.Sequence inSequence, DG.Tweening.Tween t, System.Single atPosition)
  DG.Tweening.Sequence DoAppendInterval(DG.Tweening.Sequence inSequence, System.Single interval)
  DG.Tweening.Sequence DoPrependInterval(DG.Tweening.Sequence inSequence, System.Single interval)
  DG.Tweening.Sequence DoInsertCallback(DG.Tweening.Sequence inSequence, DG.Tweening.TweenCallback callback, System.Single atPosition)
  System.Single UpdateDelay(System.Single elapsed)
  System.Void Reset()
  System.Boolean Validate()
  System.Boolean Startup()
  System.Boolean ApplyTween(System.Single prevPosition, System.Int32 prevCompletedLoops, System.Int32 newCompletedSteps, System.Boolean useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode, DG.Tweening.Core.Enums.UpdateNotice updateNotice)
  System.Void Setup(DG.Tweening.Sequence s)
  System.Boolean DoStartup(DG.Tweening.Sequence s)
  System.Boolean DoApplyTween(DG.Tweening.Sequence s, System.Single prevPosition, System.Int32 prevCompletedLoops, System.Int32 newCompletedSteps, System.Boolean useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode)
  System.Boolean ApplyInternalCycle(DG.Tweening.Sequence s, System.Single fromPos, System.Single toPos, DG.Tweening.Core.Enums.UpdateMode updateMode, System.Boolean useInverse, System.Boolean prevPosIsInverse, System.Boolean multiCycleStep)
  System.Void StableSortSequencedObjs(System.Collections.Generic.List<DG.Tweening.Core.ABSSequentiable> list)
  System.Boolean IsAnyCallbackSet(DG.Tweening.Sequence s)
END_CLASS

CLASS: DG.Tweening.ShortcutExtensions
TYPE:  class
TOKEN: 0x200001E
FIELDS:
METHODS:
  DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> DOAspect(UnityEngine.Camera target, System.Single endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Camera target, UnityEngine.Color endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> DOFarClipPlane(UnityEngine.Camera target, System.Single endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> DOFieldOfView(UnityEngine.Camera target, System.Single endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> DONearClipPlane(UnityEngine.Camera target, System.Single endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> DOOrthoSize(UnityEngine.Camera target, System.Single endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<UnityEngine.Rect,UnityEngine.Rect,DG.Tweening.Plugins.Options.RectOptions> DOPixelRect(UnityEngine.Camera target, UnityEngine.Rect endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<UnityEngine.Rect,UnityEngine.Rect,DG.Tweening.Plugins.Options.RectOptions> DORect(UnityEngine.Camera target, UnityEngine.Rect endValue, System.Single duration)
  DG.Tweening.Tweener DOShakePosition(UnityEngine.Camera target, System.Single duration, System.Single strength, System.Int32 vibrato, System.Single randomness, System.Boolean fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode)
  DG.Tweening.Tweener DOShakePosition(UnityEngine.Camera target, System.Single duration, UnityEngine.Vector3 strength, System.Int32 vibrato, System.Single randomness, System.Boolean fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode)
  DG.Tweening.Tweener DOShakeRotation(UnityEngine.Camera target, System.Single duration, System.Single strength, System.Int32 vibrato, System.Single randomness, System.Boolean fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode)
  DG.Tweening.Tweener DOShakeRotation(UnityEngine.Camera target, System.Single duration, UnityEngine.Vector3 strength, System.Int32 vibrato, System.Single randomness, System.Boolean fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode)
  DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Light target, UnityEngine.Color endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> DOIntensity(UnityEngine.Light target, System.Single endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> DOShadowStrength(UnityEngine.Light target, System.Single endValue, System.Single duration)
  DG.Tweening.Tweener DOColor(UnityEngine.LineRenderer target, DG.Tweening.Color2 startValue, DG.Tweening.Color2 endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Material target, UnityEngine.Color endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Material target, UnityEngine.Color endValue, System.String property, System.Single duration)
  DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Material target, UnityEngine.Color endValue, System.Int32 propertyID, System.Single duration)
  DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.Material target, System.Single endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.Material target, System.Single endValue, System.String property, System.Single duration)
  DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.Material target, System.Single endValue, System.Int32 propertyID, System.Single duration)
  DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> DOFloat(UnityEngine.Material target, System.Single endValue, System.String property, System.Single duration)
  DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> DOFloat(UnityEngine.Material target, System.Single endValue, System.Int32 propertyID, System.Single duration)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> DOOffset(UnityEngine.Material target, UnityEngine.Vector2 endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> DOOffset(UnityEngine.Material target, UnityEngine.Vector2 endValue, System.String property, System.Single duration)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> DOTiling(UnityEngine.Material target, UnityEngine.Vector2 endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> DOTiling(UnityEngine.Material target, UnityEngine.Vector2 endValue, System.String property, System.Single duration)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector4,UnityEngine.Vector4,DG.Tweening.Plugins.Options.VectorOptions> DOVector(UnityEngine.Material target, UnityEngine.Vector4 endValue, System.String property, System.Single duration)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector4,UnityEngine.Vector4,DG.Tweening.Plugins.Options.VectorOptions> DOVector(UnityEngine.Material target, UnityEngine.Vector4 endValue, System.Int32 propertyID, System.Single duration)
  DG.Tweening.Tweener DOResize(UnityEngine.TrailRenderer target, System.Single toStartWidth, System.Single toEndWidth, System.Single duration)
  DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> DOTime(UnityEngine.TrailRenderer target, System.Single endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> DOMove(UnityEngine.Transform target, UnityEngine.Vector3 endValue, System.Single duration, System.Boolean snapping)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> DOMoveX(UnityEngine.Transform target, System.Single endValue, System.Single duration, System.Boolean snapping)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> DOMoveY(UnityEngine.Transform target, System.Single endValue, System.Single duration, System.Boolean snapping)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> DOMoveZ(UnityEngine.Transform target, System.Single endValue, System.Single duration, System.Boolean snapping)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> DOLocalMove(UnityEngine.Transform target, UnityEngine.Vector3 endValue, System.Single duration, System.Boolean snapping)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> DOLocalMoveX(UnityEngine.Transform target, System.Single endValue, System.Single duration, System.Boolean snapping)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> DOLocalMoveY(UnityEngine.Transform target, System.Single endValue, System.Single duration, System.Boolean snapping)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> DOLocalMoveZ(UnityEngine.Transform target, System.Single endValue, System.Single duration, System.Boolean snapping)
  DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Vector3,DG.Tweening.Plugins.Options.QuaternionOptions> DORotate(UnityEngine.Transform target, UnityEngine.Vector3 endValue, System.Single duration, DG.Tweening.RotateMode mode)
  DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Quaternion,DG.Tweening.Plugins.Options.NoOptions> DORotateQuaternion(UnityEngine.Transform target, UnityEngine.Quaternion endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Vector3,DG.Tweening.Plugins.Options.QuaternionOptions> DOLocalRotate(UnityEngine.Transform target, UnityEngine.Vector3 endValue, System.Single duration, DG.Tweening.RotateMode mode)
  DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Quaternion,DG.Tweening.Plugins.Options.NoOptions> DOLocalRotateQuaternion(UnityEngine.Transform target, UnityEngine.Quaternion endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> DOScale(UnityEngine.Transform target, UnityEngine.Vector3 endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> DOScale(UnityEngine.Transform target, System.Single endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> DOScaleX(UnityEngine.Transform target, System.Single endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> DOScaleY(UnityEngine.Transform target, System.Single endValue, System.Single duration)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> DOScaleZ(UnityEngine.Transform target, System.Single endValue, System.Single duration)
  DG.Tweening.Tweener DOLookAt(UnityEngine.Transform target, UnityEngine.Vector3 towards, System.Single duration, DG.Tweening.AxisConstraint axisConstraint, System.Nullable<UnityEngine.Vector3> up)
  DG.Tweening.Tweener DODynamicLookAt(UnityEngine.Transform target, UnityEngine.Vector3 towards, System.Single duration, DG.Tweening.AxisConstraint axisConstraint, System.Nullable<UnityEngine.Vector3> up)
  DG.Tweening.Tweener LookAt(UnityEngine.Transform target, UnityEngine.Vector3 towards, System.Single duration, DG.Tweening.AxisConstraint axisConstraint, System.Nullable<UnityEngine.Vector3> up, System.Boolean dynamic)
  DG.Tweening.Tweener DOPunchPosition(UnityEngine.Transform target, UnityEngine.Vector3 punch, System.Single duration, System.Int32 vibrato, System.Single elasticity, System.Boolean snapping)
  DG.Tweening.Tweener DOPunchScale(UnityEngine.Transform target, UnityEngine.Vector3 punch, System.Single duration, System.Int32 vibrato, System.Single elasticity)
  DG.Tweening.Tweener DOPunchRotation(UnityEngine.Transform target, UnityEngine.Vector3 punch, System.Single duration, System.Int32 vibrato, System.Single elasticity)
  DG.Tweening.Tweener DOShakePosition(UnityEngine.Transform target, System.Single duration, System.Single strength, System.Int32 vibrato, System.Single randomness, System.Boolean snapping, System.Boolean fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode)
  DG.Tweening.Tweener DOShakePosition(UnityEngine.Transform target, System.Single duration, UnityEngine.Vector3 strength, System.Int32 vibrato, System.Single randomness, System.Boolean snapping, System.Boolean fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode)
  DG.Tweening.Tweener DOShakeRotation(UnityEngine.Transform target, System.Single duration, System.Single strength, System.Int32 vibrato, System.Single randomness, System.Boolean fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode)
  DG.Tweening.Tweener DOShakeRotation(UnityEngine.Transform target, System.Single duration, UnityEngine.Vector3 strength, System.Int32 vibrato, System.Single randomness, System.Boolean fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode)
  DG.Tweening.Tweener DOShakeScale(UnityEngine.Transform target, System.Single duration, System.Single strength, System.Int32 vibrato, System.Single randomness, System.Boolean fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode)
  DG.Tweening.Tweener DOShakeScale(UnityEngine.Transform target, System.Single duration, UnityEngine.Vector3 strength, System.Int32 vibrato, System.Single randomness, System.Boolean fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode)
  DG.Tweening.Sequence DOJump(UnityEngine.Transform target, UnityEngine.Vector3 endValue, System.Single jumpPower, System.Int32 numJumps, System.Single duration, System.Boolean snapping)
  DG.Tweening.Sequence DOLocalJump(UnityEngine.Transform target, UnityEngine.Vector3 endValue, System.Single jumpPower, System.Int32 numJumps, System.Single duration, System.Boolean snapping)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Transform target, UnityEngine.Vector3[] path, System.Single duration, DG.Tweening.PathType pathType, DG.Tweening.PathMode pathMode, System.Int32 resolution, System.Nullable<UnityEngine.Color> gizmoColor)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Transform target, UnityEngine.Vector3[] path, System.Single duration, DG.Tweening.PathType pathType, DG.Tweening.PathMode pathMode, System.Int32 resolution, System.Nullable<UnityEngine.Color> gizmoColor)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Transform target, DG.Tweening.Plugins.Core.PathCore.Path path, System.Single duration, DG.Tweening.PathMode pathMode)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Transform target, DG.Tweening.Plugins.Core.PathCore.Path path, System.Single duration, DG.Tweening.PathMode pathMode)
  DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> DOTimeScale(DG.Tweening.Tween target, System.Single endValue, System.Single duration)
  DG.Tweening.Tweener DOBlendableColor(UnityEngine.Light target, UnityEngine.Color endValue, System.Single duration)
  DG.Tweening.Tweener DOBlendableColor(UnityEngine.Material target, UnityEngine.Color endValue, System.Single duration)
  DG.Tweening.Tweener DOBlendableColor(UnityEngine.Material target, UnityEngine.Color endValue, System.String property, System.Single duration)
  DG.Tweening.Tweener DOBlendableColor(UnityEngine.Material target, UnityEngine.Color endValue, System.Int32 propertyID, System.Single duration)
  DG.Tweening.Tweener DOBlendableMoveBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, System.Single duration, System.Boolean snapping)
  DG.Tweening.Tweener DOBlendableLocalMoveBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, System.Single duration, System.Boolean snapping)
  DG.Tweening.Tweener DOBlendableRotateBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, System.Single duration, DG.Tweening.RotateMode mode)
  DG.Tweening.Tweener DOBlendableLocalRotateBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, System.Single duration, DG.Tweening.RotateMode mode)
  DG.Tweening.Tweener DOBlendablePunchRotation(UnityEngine.Transform target, UnityEngine.Vector3 punch, System.Single duration, System.Int32 vibrato, System.Single elasticity)
  DG.Tweening.Tweener DOBlendableScaleBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, System.Single duration)
  System.Int32 DOComplete(UnityEngine.Component target, System.Boolean withCallbacks)
  System.Int32 DOComplete(UnityEngine.Material target, System.Boolean withCallbacks)
  System.Int32 DOKill(UnityEngine.Component target, System.Boolean complete)
  System.Int32 DOKill(UnityEngine.Material target, System.Boolean complete)
  System.Int32 DOFlip(UnityEngine.Component target)
  System.Int32 DOFlip(UnityEngine.Material target)
  System.Int32 DOGoto(UnityEngine.Component target, System.Single to, System.Boolean andPlay)
  System.Int32 DOGoto(UnityEngine.Material target, System.Single to, System.Boolean andPlay)
  System.Int32 DOPause(UnityEngine.Component target)
  System.Int32 DOPause(UnityEngine.Material target)
  System.Int32 DOPlay(UnityEngine.Component target)
  System.Int32 DOPlay(UnityEngine.Material target)
  System.Int32 DOPlayBackwards(UnityEngine.Component target)
  System.Int32 DOPlayBackwards(UnityEngine.Material target)
  System.Int32 DOPlayForward(UnityEngine.Component target)
  System.Int32 DOPlayForward(UnityEngine.Material target)
  System.Int32 DORestart(UnityEngine.Component target, System.Boolean includeDelay)
  System.Int32 DORestart(UnityEngine.Material target, System.Boolean includeDelay)
  System.Int32 DORewind(UnityEngine.Component target, System.Boolean includeDelay)
  System.Int32 DORewind(UnityEngine.Material target, System.Boolean includeDelay)
  System.Int32 DOSmoothRewind(UnityEngine.Component target)
  System.Int32 DOSmoothRewind(UnityEngine.Material target)
  System.Int32 DOTogglePause(UnityEngine.Component target)
  System.Int32 DOTogglePause(UnityEngine.Material target)
END_CLASS

CLASS: DG.Tweening.TweenParams
TYPE:  class
TOKEN: 0x200006B
FIELDS:
  public    static readonly DG.Tweening.TweenParams         Params  // 0x0
  private           System.Object                   id  // 0x10
  private           System.String                   stringId  // 0x18
  private           System.Int32                    intId  // 0x20
  private           System.Object                   target  // 0x28
  private           DG.Tweening.UpdateType          updateType  // 0x30
  private           System.Boolean                  isIndependentUpdate  // 0x34
  private           DG.Tweening.TweenCallback       onStart  // 0x38
  private           DG.Tweening.TweenCallback       onPlay  // 0x40
  private           DG.Tweening.TweenCallback       onRewind  // 0x48
  private           DG.Tweening.TweenCallback       onUpdate  // 0x50
  private           DG.Tweening.TweenCallback       onStepComplete  // 0x58
  private           DG.Tweening.TweenCallback       onComplete  // 0x60
  private           DG.Tweening.TweenCallback       onKill  // 0x68
  private           DG.Tweening.TweenCallback<System.Int32>onWaypointChange  // 0x70
  private           System.Boolean                  isRecyclable  // 0x78
  private           System.Boolean                  isSpeedBased  // 0x79
  private           System.Boolean                  autoKill  // 0x7A
  private           System.Int32                    loops  // 0x7C
  private           DG.Tweening.LoopType            loopType  // 0x80
  private           System.Single                   delay  // 0x84
  private           System.Boolean                  isRelative  // 0x88
  private           DG.Tweening.Ease                easeType  // 0x8C
  private           DG.Tweening.EaseFunction        customEase  // 0x90
  private           System.Single                   easeOvershootOrAmplitude  // 0x98
  private           System.Single                   easePeriod  // 0x9C
METHODS:
  System.Void .ctor()
  DG.Tweening.TweenParams Clear()
  DG.Tweening.TweenParams SetAutoKill(System.Boolean autoKillOnCompletion)
  DG.Tweening.TweenParams SetId(System.Object objectId)
  DG.Tweening.TweenParams SetId(System.String stringId)
  DG.Tweening.TweenParams SetId(System.Int32 intId)
  DG.Tweening.TweenParams SetTarget(System.Object target)
  DG.Tweening.TweenParams SetLoops(System.Int32 loops, System.Nullable<DG.Tweening.LoopType> loopType)
  DG.Tweening.TweenParams SetEase(DG.Tweening.Ease ease, System.Nullable<System.Single> overshootOrAmplitude, System.Nullable<System.Single> period)
  DG.Tweening.TweenParams SetEase(UnityEngine.AnimationCurve animCurve)
  DG.Tweening.TweenParams SetEase(DG.Tweening.EaseFunction customEase)
  DG.Tweening.TweenParams SetRecyclable(System.Boolean recyclable)
  DG.Tweening.TweenParams SetUpdate(System.Boolean isIndependentUpdate)
  DG.Tweening.TweenParams SetUpdate(DG.Tweening.UpdateType updateType, System.Boolean isIndependentUpdate)
  DG.Tweening.TweenParams OnStart(DG.Tweening.TweenCallback action)
  DG.Tweening.TweenParams OnPlay(DG.Tweening.TweenCallback action)
  DG.Tweening.TweenParams OnRewind(DG.Tweening.TweenCallback action)
  DG.Tweening.TweenParams OnUpdate(DG.Tweening.TweenCallback action)
  DG.Tweening.TweenParams OnStepComplete(DG.Tweening.TweenCallback action)
  DG.Tweening.TweenParams OnComplete(DG.Tweening.TweenCallback action)
  DG.Tweening.TweenParams OnKill(DG.Tweening.TweenCallback action)
  DG.Tweening.TweenParams OnWaypointChange(DG.Tweening.TweenCallback<System.Int32> action)
  DG.Tweening.TweenParams SetDelay(System.Single delay)
  DG.Tweening.TweenParams SetRelative(System.Boolean isRelative)
  DG.Tweening.TweenParams SetSpeedBased(System.Boolean isSpeedBased)
  System.Void .cctor()
END_CLASS

CLASS: DG.Tweening.TweenSettingsExtensions
TYPE:  class
TOKEN: 0x200006C
FIELDS:
METHODS:
  T SetAutoKill(T t)
  T SetAutoKill(T t, System.Boolean autoKillOnCompletion)
  T SetId(T t, System.Object objectId)
  T SetId(T t, System.String stringId)
  T SetId(T t, System.Int32 intId)
  T SetLink(T t, UnityEngine.GameObject gameObject)
  T SetLink(T t, UnityEngine.GameObject gameObject, DG.Tweening.LinkBehaviour behaviour)
  T SetTarget(T t, System.Object target)
  T SetLoops(T t, System.Int32 loops)
  T SetLoops(T t, System.Int32 loops, DG.Tweening.LoopType loopType)
  T SetEase(T t, DG.Tweening.Ease ease)
  T SetEase(T t, DG.Tweening.Ease ease, System.Single overshoot)
  T SetEase(T t, DG.Tweening.Ease ease, System.Single amplitude, System.Single period)
  T SetEase(T t, UnityEngine.AnimationCurve animCurve)
  T SetEase(T t, DG.Tweening.EaseFunction customEase)
  T SetRecyclable(T t)
  T SetRecyclable(T t, System.Boolean recyclable)
  T SetUpdate(T t, System.Boolean isIndependentUpdate)
  T SetUpdate(T t, DG.Tweening.UpdateType updateType)
  T SetUpdate(T t, DG.Tweening.UpdateType updateType, System.Boolean isIndependentUpdate)
  T SetInverted(T t)
  T SetInverted(T t, System.Boolean inverted)
  T OnStart(T t, DG.Tweening.TweenCallback action)
  T OnPlay(T t, DG.Tweening.TweenCallback action)
  T OnPause(T t, DG.Tweening.TweenCallback action)
  T OnRewind(T t, DG.Tweening.TweenCallback action)
  T OnUpdate(T t, DG.Tweening.TweenCallback action)
  T OnStepComplete(T t, DG.Tweening.TweenCallback action)
  T OnComplete(T t, DG.Tweening.TweenCallback action)
  T OnKill(T t, DG.Tweening.TweenCallback action)
  T OnWaypointChange(T t, DG.Tweening.TweenCallback<System.Int32> action)
  T SetAs(T t, DG.Tweening.Tween asTween)
  T SetAs(T t, DG.Tweening.TweenParams tweenParams)
  DG.Tweening.Sequence Append(DG.Tweening.Sequence s, DG.Tweening.Tween t)
  DG.Tweening.Sequence Prepend(DG.Tweening.Sequence s, DG.Tweening.Tween t)
  DG.Tweening.Sequence Join(DG.Tweening.Sequence s, DG.Tweening.Tween t)
  DG.Tweening.Sequence Insert(DG.Tweening.Sequence s, System.Single atPosition, DG.Tweening.Tween t)
  DG.Tweening.Sequence AppendInterval(DG.Tweening.Sequence s, System.Single interval)
  DG.Tweening.Sequence PrependInterval(DG.Tweening.Sequence s, System.Single interval)
  DG.Tweening.Sequence AppendCallback(DG.Tweening.Sequence s, DG.Tweening.TweenCallback callback)
  DG.Tweening.Sequence PrependCallback(DG.Tweening.Sequence s, DG.Tweening.TweenCallback callback)
  DG.Tweening.Sequence InsertCallback(DG.Tweening.Sequence s, System.Single atPosition, DG.Tweening.TweenCallback callback)
  System.Boolean ValidateAddToSequence(DG.Tweening.Sequence s, DG.Tweening.Tween t, System.Boolean ignoreTween)
  T From(T t)
  T From(T t, System.Boolean isRelative)
  T From(T t, System.Boolean setImmediately, System.Boolean isRelative)
  DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> From(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t, T2 fromValue, System.Boolean setImmediately, System.Boolean isRelative)
  DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> From(DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> t, System.Single fromAlphaValue, System.Boolean setImmediately, System.Boolean isRelative)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> From(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> t, System.Single fromValue, System.Boolean setImmediately, System.Boolean isRelative)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions> From(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions> t, System.Single fromValueDegrees, System.Boolean setImmediately, System.Boolean isRelative)
  T SetDelay(T t, System.Single delay)
  T SetDelay(T t, System.Single delay, System.Boolean asPrependedIntervalIfSequence)
  T SetRelative(T t)
  T SetRelative(T t, System.Boolean isRelative)
  T SetSpeedBased(T t)
  T SetSpeedBased(T t, System.Boolean isSpeedBased)
  DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> t, System.Boolean snapping)
  DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> t, System.Boolean snapping)
  DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> t, DG.Tweening.AxisConstraint axisConstraint, System.Boolean snapping)
  DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> t, System.Boolean snapping)
  DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> t, DG.Tweening.AxisConstraint axisConstraint, System.Boolean snapping)
  DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4,UnityEngine.Vector4,DG.Tweening.Plugins.Options.VectorOptions> t, System.Boolean snapping)
  DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4,UnityEngine.Vector4,DG.Tweening.Plugins.Options.VectorOptions> t, DG.Tweening.AxisConstraint axisConstraint, System.Boolean snapping)
  DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Vector3,DG.Tweening.Plugins.Options.QuaternionOptions> t, System.Boolean useShortest360Route)
  DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> t, System.Boolean alphaOnly)
  DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Rect,UnityEngine.Rect,DG.Tweening.Plugins.Options.RectOptions> t, System.Boolean snapping)
  DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<System.String,System.String,DG.Tweening.Plugins.Options.StringOptions> t, System.Boolean richTextEnabled, DG.Tweening.ScrambleMode scrambleMode, System.String scrambleChars)
  DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, System.Boolean snapping)
  DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, DG.Tweening.AxisConstraint axisConstraint, System.Boolean snapping)
  DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions> t, System.Single endValueDegrees, System.Boolean relativeCenter, System.Boolean snapping)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t, DG.Tweening.AxisConstraint lockPosition, DG.Tweening.AxisConstraint lockRotation)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t, System.Boolean closePath, DG.Tweening.AxisConstraint lockPosition, DG.Tweening.AxisConstraint lockRotation)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Vector3 lookAtPosition, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Vector3 lookAtPosition, System.Boolean stableZRotation)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Transform lookAtTransform, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Transform lookAtTransform, System.Boolean stableZRotation)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t, System.Single lookAhead, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t, System.Single lookAhead, System.Boolean stableZRotation)
  DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t, DG.Tweening.Plugins.Options.OrientType orientType, UnityEngine.Vector3 lookAtPosition, UnityEngine.Transform lookAtTransform, System.Single lookAhead, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up, System.Boolean stableZRotation)
  System.Void SetPathForwardDirection(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up)
END_CLASS

CLASS: DG.Tweening.LogBehaviour
TYPE:  struct
TOKEN: 0x200006D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.LogBehaviour        Default  // 0x0
  public    static  DG.Tweening.LogBehaviour        Verbose  // 0x0
  public    static  DG.Tweening.LogBehaviour        ErrorsOnly  // 0x0
METHODS:
END_CLASS

CLASS: DG.Tweening.Tween
TYPE:  class
TOKEN: 0x200006E
EXTENDS: ABSSequentiable
FIELDS:
  public            System.Single                   timeScale  // 0x28
  public            System.Boolean                  isBackwards  // 0x2C
  private           System.Boolean                  isInverted  // 0x2D
  public            System.Object                   id  // 0x30
  public            System.String                   stringId  // 0x38
  public            System.Int32                    intId  // 0x40
  public            System.Object                   target  // 0x48
  private           DG.Tweening.UpdateType          updateType  // 0x50
  private           System.Boolean                  isIndependentUpdate  // 0x54
  public            DG.Tweening.TweenCallback       onPlay  // 0x58
  public            DG.Tweening.TweenCallback       onPause  // 0x60
  public            DG.Tweening.TweenCallback       onRewind  // 0x68
  public            DG.Tweening.TweenCallback       onUpdate  // 0x70
  public            DG.Tweening.TweenCallback       onStepComplete  // 0x78
  public            DG.Tweening.TweenCallback       onComplete  // 0x80
  public            DG.Tweening.TweenCallback       onKill  // 0x88
  public            DG.Tweening.TweenCallback<System.Int32>onWaypointChange  // 0x90
  private           System.Boolean                  isFrom  // 0x98
  private           System.Boolean                  isBlendable  // 0x99
  private           System.Boolean                  isRecyclable  // 0x9A
  private           System.Boolean                  isSpeedBased  // 0x9B
  private           System.Boolean                  autoKill  // 0x9C
  private           System.Single                   duration  // 0xA0
  private           System.Int32                    loops  // 0xA4
  private           DG.Tweening.LoopType            loopType  // 0xA8
  private           System.Single                   delay  // 0xAC
  private           System.Boolean                  <isRelative>k__BackingField  // 0xB0
  private           DG.Tweening.Ease                easeType  // 0xB4
  private           DG.Tweening.EaseFunction        customEase  // 0xB8
  public            System.Single                   easeOvershootOrAmplitude  // 0xC0
  public            System.Single                   easePeriod  // 0xC4
  public            System.String                   debugTargetId  // 0xC8
  private           System.Type                     typeofT1  // 0xD0
  private           System.Type                     typeofT2  // 0xD8
  private           System.Type                     typeofTPlugOptions  // 0xE0
  private           System.Boolean                  <active>k__BackingField  // 0xE8
  private           System.Boolean                  isSequenced  // 0xE9
  private           DG.Tweening.Sequence            sequenceParent  // 0xF0
  private           System.Int32                    activeId  // 0xF8
  private           DG.Tweening.Core.Enums.SpecialStartupModespecialStartupMode  // 0xFC
  private           System.Boolean                  creationLocked  // 0x100
  private           System.Boolean                  startupDone  // 0x101
  private           System.Boolean                  <playedOnce>k__BackingField  // 0x102
  private           System.Single                   <position>k__BackingField  // 0x104
  private           System.Single                   fullDuration  // 0x108
  private           System.Int32                    completedLoops  // 0x10C
  private           System.Boolean                  isPlaying  // 0x110
  private           System.Boolean                  isComplete  // 0x111
  private           System.Single                   elapsedDelay  // 0x114
  private           System.Boolean                  delayComplete  // 0x118
  private           System.Int32                    miscInt  // 0x11C
METHODS:
  System.Boolean get_isRelative()
  System.Void set_isRelative(System.Boolean value)
  System.Boolean get_active()
  System.Void set_active(System.Boolean value)
  System.Single get_fullPosition()
  System.Void set_fullPosition(System.Single value)
  System.Boolean get_hasLoops()
  System.Boolean get_playedOnce()
  System.Void set_playedOnce(System.Boolean value)
  System.Single get_position()
  System.Void set_position(System.Single value)
  System.Void Reset()
  System.Boolean Validate()
  System.Single UpdateDelay(System.Single elapsed)
  System.Boolean Startup()
  System.Boolean ApplyTween(System.Single prevPosition, System.Int32 prevCompletedLoops, System.Int32 newCompletedSteps, System.Boolean useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode, DG.Tweening.Core.Enums.UpdateNotice updateNotice)
  System.Boolean DoGoto(DG.Tweening.Tween t, System.Single toPosition, System.Int32 toCompletedLoops, DG.Tweening.Core.Enums.UpdateMode updateMode)
  System.Boolean OnTweenCallback(DG.Tweening.TweenCallback callback, DG.Tweening.Tween t)
  System.Boolean OnTweenCallback(DG.Tweening.TweenCallback<T> callback, DG.Tweening.Tween t, T param)
  System.Void .ctor()
END_CLASS

CLASS: DG.Tweening.Tweener
TYPE:  class
TOKEN: 0x200006F
EXTENDS: Tween
FIELDS:
  private           System.Boolean                  hasManuallySetStartValue  // 0x120
  private           System.Boolean                  isFromAllowed  // 0x121
METHODS:
  System.Void .ctor()
  DG.Tweening.Tweener ChangeStartValue(System.Object newStartValue, System.Single newDuration)
  DG.Tweening.Tweener ChangeEndValue(System.Object newEndValue, System.Single newDuration, System.Boolean snapStartValue)
  DG.Tweening.Tweener ChangeEndValue(System.Object newEndValue, System.Boolean snapStartValue)
  DG.Tweening.Tweener ChangeValues(System.Object newStartValue, System.Object newEndValue, System.Single newDuration)
  DG.Tweening.Tweener SetFrom(System.Boolean relative)
  System.Boolean Setup(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t, DG.Tweening.Core.DOGetter<T1> getter, DG.Tweening.Core.DOSetter<T1> setter, T2 endValue, System.Single duration, DG.Tweening.Plugins.Core.ABSTweenPlugin<T1,T2,TPlugOptions> plugin)
  System.Single DoUpdateDelay(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t, System.Single elapsed)
  System.Boolean DoStartup(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t)
  DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> DoChangeStartValue(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t, T2 newStartValue, System.Single newDuration)
  DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> DoChangeEndValue(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t, T2 newEndValue, System.Single newDuration, System.Boolean snapStartValue)
  DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> DoChangeValues(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t, T2 newStartValue, T2 newEndValue, System.Single newDuration)
  System.Boolean DOStartupSpecials(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t)
  System.Void DOStartupDurationBased(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t)
END_CLASS

CLASS: DG.Tweening.TweenType
TYPE:  struct
TOKEN: 0x2000070
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.TweenType           Tweener  // 0x0
  public    static  DG.Tweening.TweenType           Sequence  // 0x0
  public    static  DG.Tweening.TweenType           Callback  // 0x0
METHODS:
END_CLASS

CLASS: DG.Tweening.UpdateType
TYPE:  struct
TOKEN: 0x2000071
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.UpdateType          Normal  // 0x0
  public    static  DG.Tweening.UpdateType          Late  // 0x0
  public    static  DG.Tweening.UpdateType          Fixed  // 0x0
  public    static  DG.Tweening.UpdateType          Manual  // 0x0
METHODS:
END_CLASS

CLASS: DG.Tweening.Core.ABSSequentiable
TYPE:  class
TOKEN: 0x200009F
FIELDS:
  private           DG.Tweening.TweenType           tweenType  // 0x10
  private           System.Single                   sequencedPosition  // 0x14
  private           System.Single                   sequencedEndPosition  // 0x18
  private           DG.Tweening.TweenCallback       onStart  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: DG.Tweening.Core.DOGetter`1
TYPE:  class
TOKEN: 0x20000A0
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  T Invoke()
  System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
  T EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: DG.Tweening.Core.DOSetter`1
TYPE:  class
TOKEN: 0x20000A1
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T pNewValue)
  System.IAsyncResult BeginInvoke(T pNewValue, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: DG.Tweening.Core.Debugger
TYPE:  class
TOKEN: 0x20000A2
FIELDS:
  private   static  System.Int32                    _logPriority  // 0x0
  private   static  System.String                   _LogPrefix  // 0x0
METHODS:
  System.Int32 get_logPriority()
  System.Void Log(System.Object message)
  System.Void LogWarning(System.Object message, DG.Tweening.Tween t)
  System.Void LogError(System.Object message, DG.Tweening.Tween t)
  System.Void LogSafeModeCapturedError(System.Object message, DG.Tweening.Tween t)
  System.Void LogReport(System.Object message)
  System.Void LogSafeModeReport(System.Object message)
  System.Void LogInvalidTween(DG.Tweening.Tween t)
  System.Void LogNestedTween(DG.Tweening.Tween t)
  System.Void LogNullTween(DG.Tweening.Tween t)
  System.Void LogNonPathTween(DG.Tweening.Tween t)
  System.Void LogMissingMaterialProperty(System.String propertyName)
  System.Void LogMissingMaterialProperty(System.Int32 propertyId)
  System.Void LogRemoveActiveTweenError(System.String errorInfo, DG.Tweening.Tween t)
  System.Void LogAddActiveTweenError(System.String errorInfo, DG.Tweening.Tween t)
  System.Void SetLogPriority(DG.Tweening.LogBehaviour logBehaviour)
  System.Boolean ShouldLogSafeModeCapturedError()
  System.String GetDebugDataMessage(DG.Tweening.Tween t)
  System.Void AddDebugDataToMessage(System.String& message, DG.Tweening.Tween t)
END_CLASS

CLASS: DG.Tweening.Core.DOTweenComponent
TYPE:  class
TOKEN: 0x20000A4
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Int32                    inspectorUpdater  // 0x18
  private           System.Single                   _unscaledTime  // 0x1C
  private           System.Single                   _unscaledDeltaTime  // 0x20
  private           System.Boolean                  _paused  // 0x24
  private           System.Single                   _pausedTime  // 0x28
  private           System.Boolean                  _isQuitting  // 0x2C
  private           System.Boolean                  _duplicateToDestroy  // 0x2D
METHODS:
  System.Void Awake()
  System.Void Start()
  System.Void Update()
  System.Void LateUpdate()
  System.Void FixedUpdate()
  System.Void OnDrawGizmos()
  System.Void OnDestroy()
  System.Void OnApplicationPause(System.Boolean pauseStatus)
  System.Void OnApplicationQuit()
  DG.Tweening.IDOTweenInit SetCapacity(System.Int32 tweenersCapacity, System.Int32 sequencesCapacity)
  System.Collections.IEnumerator WaitForCompletion(DG.Tweening.Tween t)
  System.Collections.IEnumerator WaitForRewind(DG.Tweening.Tween t)
  System.Collections.IEnumerator WaitForKill(DG.Tweening.Tween t)
  System.Collections.IEnumerator WaitForElapsedLoops(DG.Tweening.Tween t, System.Int32 elapsedLoops)
  System.Collections.IEnumerator WaitForPosition(DG.Tweening.Tween t, System.Single position)
  System.Collections.IEnumerator WaitForStart(DG.Tweening.Tween t)
  System.Void Create()
  System.Void DestroyInstance()
  System.Void .ctor()
END_CLASS

CLASS: DG.Tweening.Core.DOTweenSettings
TYPE:  class
TOKEN: 0x20000AB
EXTENDS: ScriptableObject
FIELDS:
  public    static  System.String                   AssetName  // 0x0
  public    static  System.String                   AssetFullFilename  // 0x0
  public            System.Boolean                  useSafeMode  // 0x18
  public            DG.Tweening.Core.DOTweenSettings.SafeModeOptionssafeModeOptions  // 0x20
  public            System.Single                   timeScale  // 0x28
  public            System.Single                   unscaledTimeScale  // 0x2C
  public            System.Boolean                  useSmoothDeltaTime  // 0x30
  public            System.Single                   maxSmoothUnscaledTime  // 0x34
  public            DG.Tweening.Core.Enums.RewindCallbackModerewindCallbackMode  // 0x38
  public            System.Boolean                  showUnityEditorReport  // 0x3C
  public            DG.Tweening.LogBehaviour        logBehaviour  // 0x40
  public            System.Boolean                  drawGizmos  // 0x44
  public            System.Boolean                  defaultRecyclable  // 0x45
  public            DG.Tweening.AutoPlay            defaultAutoPlay  // 0x48
  public            DG.Tweening.UpdateType          defaultUpdateType  // 0x4C
  public            System.Boolean                  defaultTimeScaleIndependent  // 0x50
  public            DG.Tweening.Ease                defaultEaseType  // 0x54
  public            System.Single                   defaultEaseOvershootOrAmplitude  // 0x58
  public            System.Single                   defaultEasePeriod  // 0x5C
  public            System.Boolean                  defaultAutoKill  // 0x60
  public            DG.Tweening.LoopType            defaultLoopType  // 0x64
  public            System.Boolean                  debugMode  // 0x68
  public            System.Boolean                  debugStoreTargetId  // 0x69
  public            System.Boolean                  showPreviewPanel  // 0x6A
  public            DG.Tweening.Core.DOTweenSettings.SettingsLocationstoreSettingsLocation  // 0x6C
  public            DG.Tweening.Core.DOTweenSettings.ModulesSetupmodules  // 0x70
  public            System.Boolean                  createASMDEF  // 0x78
  public            System.Boolean                  showPlayingTweens  // 0x79
  public            System.Boolean                  showPausedTweens  // 0x7A
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: DG.Tweening.Core.Extensions
TYPE:  class
TOKEN: 0x20000AF
FIELDS:
METHODS:
  T SetSpecialStartupMode(T t, DG.Tweening.Core.Enums.SpecialStartupMode mode)
  DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> Blendable(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t)
  DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> NoFrom(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t)
END_CLASS

CLASS: DG.Tweening.Core.DOTweenExternalCommand
TYPE:  class
TOKEN: 0x20000B0
FIELDS:
  private   static  System.Action<DG.Tweening.Plugins.Options.PathOptions,DG.Tweening.Tween,UnityEngine.Quaternion,UnityEngine.Transform>SetOrientationOnPath  // 0x0
METHODS:
  System.Void add_SetOrientationOnPath(System.Action<DG.Tweening.Plugins.Options.PathOptions,DG.Tweening.Tween,UnityEngine.Quaternion,UnityEngine.Transform> value)
  System.Void remove_SetOrientationOnPath(System.Action<DG.Tweening.Plugins.Options.PathOptions,DG.Tweening.Tween,UnityEngine.Quaternion,UnityEngine.Transform> value)
  System.Void Dispatch_SetOrientationOnPath(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, UnityEngine.Quaternion newRot, UnityEngine.Transform trans)
END_CLASS

CLASS: DG.Tweening.Core.SafeModeReport
TYPE:  struct
TOKEN: 0x20000B1
FIELDS:
  private           System.Int32                    <totMissingTargetOrFieldErrors>k__BackingField  // 0x10
  private           System.Int32                    <totCallbackErrors>k__BackingField  // 0x14
  private           System.Int32                    <totStartupErrors>k__BackingField  // 0x18
  private           System.Int32                    <totUnsetErrors>k__BackingField  // 0x1C
METHODS:
  System.Int32 get_totMissingTargetOrFieldErrors()
  System.Void set_totMissingTargetOrFieldErrors(System.Int32 value)
  System.Int32 get_totCallbackErrors()
  System.Void set_totCallbackErrors(System.Int32 value)
  System.Int32 get_totStartupErrors()
  System.Void set_totStartupErrors(System.Int32 value)
  System.Int32 get_totUnsetErrors()
  System.Void set_totUnsetErrors(System.Int32 value)
  System.Void Add(DG.Tweening.Core.SafeModeReport.SafeModeReportType type)
  System.Int32 GetTotErrors()
END_CLASS

CLASS: DG.Tweening.Core.SequenceCallback
TYPE:  class
TOKEN: 0x20000B3
EXTENDS: ABSSequentiable
FIELDS:
METHODS:
  System.Void .ctor(System.Single sequencedPosition, DG.Tweening.TweenCallback callback)
END_CLASS

CLASS: DG.Tweening.Core.TweenLink
TYPE:  class
TOKEN: 0x20000B4
FIELDS:
  public    readonly UnityEngine.GameObject          target  // 0x10
  public    readonly DG.Tweening.LinkBehaviour       behaviour  // 0x18
  public            System.Boolean                  lastSeenActive  // 0x1C
METHODS:
  System.Void .ctor(UnityEngine.GameObject target, DG.Tweening.LinkBehaviour behaviour)
END_CLASS

CLASS: DG.Tweening.Core.TweenManager
TYPE:  class
TOKEN: 0x20000B5
FIELDS:
  private   static  System.Int32                    _DefaultMaxTweeners  // 0x0
  private   static  System.Int32                    _DefaultMaxSequences  // 0x0
  private   static  System.String                   _MaxTweensReached  // 0x0
  private   static  System.Single                   _EpsilonVsTimeCheck  // 0x0
  private   static  System.Boolean                  isUnityEditor  // 0x0
  private   static  System.Boolean                  isDebugBuild  // 0x1
  private   static  System.Int32                    maxActive  // 0x4
  private   static  System.Int32                    maxTweeners  // 0x8
  private   static  System.Int32                    maxSequences  // 0xC
  private   static  System.Boolean                  hasActiveTweens  // 0x10
  private   static  System.Boolean                  hasActiveDefaultTweens  // 0x11
  private   static  System.Boolean                  hasActiveLateTweens  // 0x12
  private   static  System.Boolean                  hasActiveFixedTweens  // 0x13
  private   static  System.Boolean                  hasActiveManualTweens  // 0x14
  private   static  System.Int32                    totActiveTweens  // 0x18
  private   static  System.Int32                    totActiveDefaultTweens  // 0x1C
  private   static  System.Int32                    totActiveLateTweens  // 0x20
  private   static  System.Int32                    totActiveFixedTweens  // 0x24
  private   static  System.Int32                    totActiveManualTweens  // 0x28
  private   static  System.Int32                    totActiveTweeners  // 0x2C
  private   static  System.Int32                    totActiveSequences  // 0x30
  private   static  System.Int32                    totPooledTweeners  // 0x34
  private   static  System.Int32                    totPooledSequences  // 0x38
  private   static  System.Int32                    totTweeners  // 0x3C
  private   static  System.Int32                    totSequences  // 0x40
  private   static  System.Boolean                  isUpdateLoop  // 0x44
  private   static  DG.Tweening.Tween[]             _activeTweens  // 0x48
  private   static  DG.Tweening.Tween[]             _pooledTweeners  // 0x50
  private   static readonly System.Collections.Generic.Stack<DG.Tweening.Tween>_PooledSequences  // 0x58
  private   static readonly System.Collections.Generic.List<DG.Tweening.Tween>_KillList  // 0x60
  private   static readonly System.Collections.Generic.Dictionary<DG.Tweening.Tween,DG.Tweening.Core.TweenLink>_TweenLinks  // 0x68
  private   static  System.Int32                    _totTweenLinks  // 0x70
  private   static  System.Int32                    _maxActiveLookupId  // 0x74
  private   static  System.Boolean                  _requiresActiveReorganization  // 0x78
  private   static  System.Int32                    _reorganizeFromId  // 0x7C
  private   static  System.Int32                    _minPooledTweenerId  // 0x80
  private   static  System.Int32                    _maxPooledTweenerId  // 0x84
  private   static  System.Boolean                  _despawnAllCalledFromUpdateLoopCallback  // 0x88
METHODS:
  System.Void .cctor()
  DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> GetTweener()
  DG.Tweening.Sequence GetSequence()
  System.Void SetUpdateType(DG.Tweening.Tween t, DG.Tweening.UpdateType updateType, System.Boolean isIndependentUpdate)
  System.Void AddActiveTweenToSequence(DG.Tweening.Tween t)
  System.Int32 DespawnAll()
  System.Void Despawn(DG.Tweening.Tween t, System.Boolean modifyActiveLists)
  System.Void PurgeAll(System.Boolean isApplicationQuitting)
  System.Void PurgePools()
  System.Void AddTweenLink(DG.Tweening.Tween t, DG.Tweening.Core.TweenLink tweenLink)
  System.Void RemoveTweenLink(DG.Tweening.Tween t)
  System.Void ResetCapacities()
  System.Void SetCapacities(System.Int32 tweenersCapacity, System.Int32 sequencesCapacity)
  System.Int32 Validate()
  System.Void Update(DG.Tweening.UpdateType updateType, System.Single deltaTime, System.Single independentTime)
  System.Boolean Update(DG.Tweening.Tween t, System.Single deltaTime, System.Single independentTime, System.Boolean isSingleTweenManualUpdate)
  System.Int32 FilteredOperation(DG.Tweening.Core.Enums.OperationType operationType, DG.Tweening.Core.Enums.FilterType filterType, System.Object id, System.Boolean optionalBool, System.Single optionalFloat, System.Object optionalObj, System.Object[] optionalArray)
  System.Boolean Complete(DG.Tweening.Tween t, System.Boolean modifyActiveLists, DG.Tweening.Core.Enums.UpdateMode updateMode)
  System.Boolean Flip(DG.Tweening.Tween t)
  System.Void ForceInit(DG.Tweening.Tween t, System.Boolean isSequenced)
  System.Boolean Goto(DG.Tweening.Tween t, System.Single to, System.Boolean andPlay, DG.Tweening.Core.Enums.UpdateMode updateMode)
  System.Boolean Pause(DG.Tweening.Tween t)
  System.Boolean Play(DG.Tweening.Tween t)
  System.Boolean PlayBackwards(DG.Tweening.Tween t)
  System.Boolean PlayForward(DG.Tweening.Tween t)
  System.Boolean Restart(DG.Tweening.Tween t, System.Boolean includeDelay, System.Single changeDelayTo)
  System.Boolean Rewind(DG.Tweening.Tween t, System.Boolean includeDelay)
  System.Boolean SmoothRewind(DG.Tweening.Tween t)
  System.Boolean TogglePause(DG.Tweening.Tween t)
  System.Int32 TotalPooledTweens()
  System.Int32 TotalPlayingTweens()
  System.Int32 TotalTweensById(System.Object id, System.Boolean playingOnly)
  System.Collections.Generic.List<DG.Tweening.Tween> GetActiveTweens(System.Boolean playing, System.Collections.Generic.List<DG.Tweening.Tween> fillableList)
  System.Collections.Generic.List<DG.Tweening.Tween> GetTweensById(System.Object id, System.Boolean playingOnly, System.Collections.Generic.List<DG.Tweening.Tween> fillableList)
  System.Int32 DoGetTweensById(System.Object id, System.Boolean playingOnly, System.Boolean addToList, System.Collections.Generic.List<DG.Tweening.Tween> fillableList)
  System.Collections.Generic.List<DG.Tweening.Tween> GetTweensByTarget(System.Object target, System.Boolean playingOnly, System.Collections.Generic.List<DG.Tweening.Tween> fillableList)
  System.Void MarkForKilling(DG.Tweening.Tween t, System.Boolean isSingleTweenManualUpdate)
  System.Void EvaluateTweenLink(DG.Tweening.Tween t)
  System.Void AddActiveTween(DG.Tweening.Tween t)
  System.Void ReorganizeActiveTweens()
  System.Void DespawnActiveTweens(System.Collections.Generic.List<DG.Tweening.Tween> tweens)
  System.Void RemoveActiveTween(DG.Tweening.Tween t)
  System.Void ClearTweenArray(DG.Tweening.Tween[] tweens)
  System.Void IncreaseCapacities(DG.Tweening.Core.TweenManager.CapacityIncreaseMode increaseMode)
  System.Void ManageOnRewindCallbackWhenAlreadyRewinded(DG.Tweening.Tween t, System.Boolean isPlayBackwardsOrSmoothRewind)
END_CLASS

CLASS: DG.Tweening.Core.DOTweenUtils
TYPE:  class
TOKEN: 0x20000B7
FIELDS:
  private   static  System.Reflection.Assembly[]    _loadedAssemblies  // 0x0
  private   static readonly System.String[]                 _defAssembliesToQuery  // 0x8
METHODS:
  UnityEngine.Vector3 Vector3FromAngle(System.Single degrees, System.Single magnitude)
  System.Single Angle2D(UnityEngine.Vector3 from, UnityEngine.Vector3 to)
  UnityEngine.Vector3 RotateAroundPivot(UnityEngine.Vector3 point, UnityEngine.Vector3 pivot, UnityEngine.Quaternion rotation)
  UnityEngine.Vector2 GetPointOnCircle(UnityEngine.Vector2 center, System.Single radius, System.Single degrees)
  System.Boolean Vector3AreApproximatelyEqual(UnityEngine.Vector3 a, UnityEngine.Vector3 b)
  System.Type GetLooseScriptType(System.String typeName)
  System.Void .cctor()
END_CLASS

CLASS: DG.Tweening.Core.TweenerCore`3
TYPE:  class
TOKEN: 0x20000B8
EXTENDS: Tweener
FIELDS:
  public            T2                              startValue  // 0x0
  public            T2                              endValue  // 0x0
  public            T2                              changeValue  // 0x0
  public            TPlugOptions                    plugOptions  // 0x0
  public            DG.Tweening.Core.DOGetter<T1>   getter  // 0x0
  public            DG.Tweening.Core.DOSetter<T1>   setter  // 0x0
  private           DG.Tweening.Plugins.Core.ABSTweenPlugin<T1,T2,TPlugOptions>tweenPlugin  // 0x0
  private   static  System.String                   _TxtCantChangeSequencedValues  // 0x0
  private           System.Type                     _colorType  // 0x0
  private           System.Type                     _color32Type  // 0x0
METHODS:
  System.Void .ctor()
  DG.Tweening.Tweener ChangeStartValue(System.Object newStartValue, System.Single newDuration)
  DG.Tweening.Tweener ChangeEndValue(System.Object newEndValue, System.Boolean snapStartValue)
  DG.Tweening.Tweener ChangeEndValue(System.Object newEndValue, System.Single newDuration, System.Boolean snapStartValue)
  DG.Tweening.Tweener ChangeValues(System.Object newStartValue, System.Object newEndValue, System.Single newDuration)
  DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> ChangeStartValue(T2 newStartValue, System.Single newDuration)
  DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> ChangeEndValue(T2 newEndValue, System.Boolean snapStartValue)
  DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> ChangeEndValue(T2 newEndValue, System.Single newDuration, System.Boolean snapStartValue)
  DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> ChangeValues(T2 newStartValue, T2 newEndValue, System.Single newDuration)
  DG.Tweening.Tweener SetFrom(System.Boolean relative)
  DG.Tweening.Tweener SetFrom(T2 fromValue, System.Boolean setImmediately, System.Boolean relative)
  System.Void Reset()
  System.Boolean Validate()
  System.Boolean ValidateChangeValueType(System.Type newType, System.Boolean& isColor32ToColor)
  System.Single UpdateDelay(System.Single elapsed)
  System.Boolean Startup()
  System.Boolean ApplyTween(System.Single prevPosition, System.Int32 prevCompletedLoops, System.Int32 newCompletedSteps, System.Boolean useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode, DG.Tweening.Core.Enums.UpdateNotice updateNotice)
END_CLASS

CLASS: DG.Tweening.Core.Easing.Bounce
TYPE:  class
TOKEN: 0x20000C1
FIELDS:
METHODS:
  System.Single EaseIn(System.Single time, System.Single duration, System.Single unusedOvershootOrAmplitude, System.Single unusedPeriod)
  System.Single EaseOut(System.Single time, System.Single duration, System.Single unusedOvershootOrAmplitude, System.Single unusedPeriod)
  System.Single EaseInOut(System.Single time, System.Single duration, System.Single unusedOvershootOrAmplitude, System.Single unusedPeriod)
END_CLASS

CLASS: DG.Tweening.Core.Easing.EaseManager
TYPE:  class
TOKEN: 0x20000C2
FIELDS:
  private   static  System.Single                   _PiOver2  // 0x0
  private   static  System.Single                   _TwoPi  // 0x0
METHODS:
  System.Single Evaluate(DG.Tweening.Tween t, System.Single time, System.Single duration, System.Single overshootOrAmplitude, System.Single period)
  System.Single Evaluate(DG.Tweening.Ease easeType, DG.Tweening.EaseFunction customEase, System.Single time, System.Single duration, System.Single overshootOrAmplitude, System.Single period)
  DG.Tweening.EaseFunction ToEaseFunction(DG.Tweening.Ease ease)
  System.Boolean IsFlashEase(DG.Tweening.Ease ease)
END_CLASS

CLASS: DG.Tweening.Core.Easing.EaseCurve
TYPE:  class
TOKEN: 0x20000C4
FIELDS:
  private   readonly UnityEngine.AnimationCurve      _animCurve  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.AnimationCurve animCurve)
  System.Single Evaluate(System.Single time, System.Single duration, System.Single unusedOvershoot, System.Single unusedPeriod)
END_CLASS

CLASS: DG.Tweening.Core.Easing.Flash
TYPE:  class
TOKEN: 0x20000C5
FIELDS:
METHODS:
  System.Single Ease(System.Single time, System.Single duration, System.Single overshootOrAmplitude, System.Single period)
  System.Single EaseIn(System.Single time, System.Single duration, System.Single overshootOrAmplitude, System.Single period)
  System.Single EaseOut(System.Single time, System.Single duration, System.Single overshootOrAmplitude, System.Single period)
  System.Single EaseInOut(System.Single time, System.Single duration, System.Single overshootOrAmplitude, System.Single period)
  System.Single WeightedEase(System.Single overshootOrAmplitude, System.Single period, System.Int32 stepIndex, System.Single stepDuration, System.Single dir, System.Single res)
END_CLASS

CLASS: DG.Tweening.Core.Enums.FilterType
TYPE:  struct
TOKEN: 0x20000B9
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.Core.Enums.FilterTypeAll  // 0x0
  public    static  DG.Tweening.Core.Enums.FilterTypeTargetOrId  // 0x0
  public    static  DG.Tweening.Core.Enums.FilterTypeTargetAndId  // 0x0
  public    static  DG.Tweening.Core.Enums.FilterTypeAllExceptTargetsOrIds  // 0x0
  public    static  DG.Tweening.Core.Enums.FilterTypeDOGetter  // 0x0
METHODS:
END_CLASS

CLASS: DG.Tweening.Core.Enums.NestedTweenFailureBehaviour
TYPE:  struct
TOKEN: 0x20000BA
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.Core.Enums.NestedTweenFailureBehaviourTryToPreserveSequence  // 0x0
  public    static  DG.Tweening.Core.Enums.NestedTweenFailureBehaviourKillWholeSequence  // 0x0
METHODS:
END_CLASS

CLASS: DG.Tweening.Core.Enums.OperationType
TYPE:  struct
TOKEN: 0x20000BB
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.Core.Enums.OperationTypeComplete  // 0x0
  public    static  DG.Tweening.Core.Enums.OperationTypeDespawn  // 0x0
  public    static  DG.Tweening.Core.Enums.OperationTypeFlip  // 0x0
  public    static  DG.Tweening.Core.Enums.OperationTypeGoto  // 0x0
  public    static  DG.Tweening.Core.Enums.OperationTypePause  // 0x0
  public    static  DG.Tweening.Core.Enums.OperationTypePlay  // 0x0
  public    static  DG.Tweening.Core.Enums.OperationTypePlayForward  // 0x0
  public    static  DG.Tweening.Core.Enums.OperationTypePlayBackwards  // 0x0
  public    static  DG.Tweening.Core.Enums.OperationTypeRewind  // 0x0
  public    static  DG.Tweening.Core.Enums.OperationTypeSmoothRewind  // 0x0
  public    static  DG.Tweening.Core.Enums.OperationTypeRestart  // 0x0
  public    static  DG.Tweening.Core.Enums.OperationTypeTogglePause  // 0x0
  public    static  DG.Tweening.Core.Enums.OperationTypeIsTweening  // 0x0
METHODS:
END_CLASS

CLASS: DG.Tweening.Core.Enums.SafeModeLogBehaviour
TYPE:  struct
TOKEN: 0x20000BC
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.Core.Enums.SafeModeLogBehaviourNone  // 0x0
  public    static  DG.Tweening.Core.Enums.SafeModeLogBehaviourNormal  // 0x0
  public    static  DG.Tweening.Core.Enums.SafeModeLogBehaviourWarning  // 0x0
  public    static  DG.Tweening.Core.Enums.SafeModeLogBehaviourError  // 0x0
METHODS:
END_CLASS

CLASS: DG.Tweening.Core.Enums.SpecialStartupMode
TYPE:  struct
TOKEN: 0x20000BD
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.Core.Enums.SpecialStartupModeNone  // 0x0
  public    static  DG.Tweening.Core.Enums.SpecialStartupModeSetLookAt  // 0x0
  public    static  DG.Tweening.Core.Enums.SpecialStartupModeSetShake  // 0x0
  public    static  DG.Tweening.Core.Enums.SpecialStartupModeSetPunch  // 0x0
  public    static  DG.Tweening.Core.Enums.SpecialStartupModeSetCameraShakePosition  // 0x0
METHODS:
END_CLASS

CLASS: DG.Tweening.Core.Enums.UpdateNotice
TYPE:  struct
TOKEN: 0x20000BE
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.Core.Enums.UpdateNoticeNone  // 0x0
  public    static  DG.Tweening.Core.Enums.UpdateNoticeRewindStep  // 0x0
METHODS:
END_CLASS

CLASS: DG.Tweening.Core.Enums.UpdateMode
TYPE:  struct
TOKEN: 0x20000BF
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.Core.Enums.UpdateModeUpdate  // 0x0
  public    static  DG.Tweening.Core.Enums.UpdateModeGoto  // 0x0
  public    static  DG.Tweening.Core.Enums.UpdateModeIgnoreOnUpdate  // 0x0
  public    static  DG.Tweening.Core.Enums.UpdateModeIgnoreOnComplete  // 0x0
METHODS:
END_CLASS

CLASS: DG.Tweening.Core.Enums.RewindCallbackMode
TYPE:  struct
TOKEN: 0x20000C0
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.Core.Enums.RewindCallbackModeFireIfPositionChanged  // 0x0
  public    static  DG.Tweening.Core.Enums.RewindCallbackModeFireAlwaysWithRewind  // 0x0
  public    static  DG.Tweening.Core.Enums.RewindCallbackModeFireAlways  // 0x0
METHODS:
END_CLASS

CLASS: DG.Tweening.CustomPlugins.PureQuaternionPlugin
TYPE:  class
TOKEN: 0x200009E
EXTENDS: ABSTweenPlugin`3
FIELDS:
  private   static  DG.Tweening.CustomPlugins.PureQuaternionPlugin_plug  // 0x0
METHODS:
  DG.Tweening.CustomPlugins.PureQuaternionPlugin Plug()
  System.Void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Quaternion,DG.Tweening.Plugins.Options.NoOptions> t)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Quaternion,DG.Tweening.Plugins.Options.NoOptions> t, System.Boolean isRelative)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Quaternion,DG.Tweening.Plugins.Options.NoOptions> t, UnityEngine.Quaternion fromValue, System.Boolean setImmediately, System.Boolean isRelative)
  UnityEngine.Quaternion ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Quaternion,DG.Tweening.Plugins.Options.NoOptions> t, UnityEngine.Quaternion value)
  System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Quaternion,DG.Tweening.Plugins.Options.NoOptions> t)
  System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Quaternion,DG.Tweening.Plugins.Options.NoOptions> t)
  System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, System.Single unitsXSecond, UnityEngine.Quaternion changeValue)
  System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Quaternion> getter, DG.Tweening.Core.DOSetter<UnityEngine.Quaternion> setter, System.Single elapsed, UnityEngine.Quaternion startValue, UnityEngine.Quaternion changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice)
  System.Void .ctor()
END_CLASS

CLASS: DG.Tweening.Plugins.CircleOptions
TYPE:  struct
TOKEN: 0x2000072
FIELDS:
  public            System.Single                   endValueDegrees  // 0x10
  public            System.Boolean                  relativeCenter  // 0x14
  public            System.Boolean                  snapping  // 0x15
  private           UnityEngine.Vector2             center  // 0x18
  private           System.Single                   radius  // 0x20
  private           System.Single                   startValueDegrees  // 0x24
  private           System.Boolean                  initialized  // 0x28
METHODS:
  System.Void Reset()
  System.Void Initialize(UnityEngine.Vector2 startValue, UnityEngine.Vector2 endValue)
END_CLASS

CLASS: DG.Tweening.Plugins.CirclePlugin
TYPE:  class
TOKEN: 0x2000073
EXTENDS: ABSTweenPlugin`3
FIELDS:
METHODS:
  System.Void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions> t)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions> t, System.Boolean isRelative)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions> t, UnityEngine.Vector2 fromValue, System.Boolean setImmediately, System.Boolean isRelative)
  DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions> Get()
  UnityEngine.Vector2 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions> t, UnityEngine.Vector2 value)
  System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions> t)
  System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions> t)
  System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.CircleOptions options, System.Single unitsXSecond, UnityEngine.Vector2 changeValue)
  System.Void EvaluateAndApply(DG.Tweening.Plugins.CircleOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector2> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector2> setter, System.Single elapsed, UnityEngine.Vector2 startValue, UnityEngine.Vector2 changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice)
  UnityEngine.Vector2 GetPositionOnCircle(DG.Tweening.Plugins.CircleOptions options, System.Single degrees)
  System.Void .ctor()
END_CLASS

CLASS: DG.Tweening.Plugins.Color2Plugin
TYPE:  class
TOKEN: 0x2000074
EXTENDS: ABSTweenPlugin`3
FIELDS:
METHODS:
  System.Void Reset(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2,DG.Tweening.Color2,DG.Tweening.Plugins.Options.ColorOptions> t)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2,DG.Tweening.Color2,DG.Tweening.Plugins.Options.ColorOptions> t, System.Boolean isRelative)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2,DG.Tweening.Color2,DG.Tweening.Plugins.Options.ColorOptions> t, DG.Tweening.Color2 fromValue, System.Boolean setImmediately, System.Boolean isRelative)
  DG.Tweening.Color2 ConvertToStartValue(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2,DG.Tweening.Color2,DG.Tweening.Plugins.Options.ColorOptions> t, DG.Tweening.Color2 value)
  System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2,DG.Tweening.Color2,DG.Tweening.Plugins.Options.ColorOptions> t)
  System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2,DG.Tweening.Color2,DG.Tweening.Plugins.Options.ColorOptions> t)
  System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.ColorOptions options, System.Single unitsXSecond, DG.Tweening.Color2 changeValue)
  System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.ColorOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<DG.Tweening.Color2> getter, DG.Tweening.Core.DOSetter<DG.Tweening.Color2> setter, System.Single elapsed, DG.Tweening.Color2 startValue, DG.Tweening.Color2 changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice)
  System.Void .ctor()
END_CLASS

CLASS: DG.Tweening.Plugins.DoublePlugin
TYPE:  class
TOKEN: 0x2000075
EXTENDS: ABSTweenPlugin`3
FIELDS:
METHODS:
  System.Void Reset(DG.Tweening.Core.TweenerCore<System.Double,System.Double,DG.Tweening.Plugins.Options.NoOptions> t)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<System.Double,System.Double,DG.Tweening.Plugins.Options.NoOptions> t, System.Boolean isRelative)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<System.Double,System.Double,DG.Tweening.Plugins.Options.NoOptions> t, System.Double fromValue, System.Boolean setImmediately, System.Boolean isRelative)
  System.Double ConvertToStartValue(DG.Tweening.Core.TweenerCore<System.Double,System.Double,DG.Tweening.Plugins.Options.NoOptions> t, System.Double value)
  System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<System.Double,System.Double,DG.Tweening.Plugins.Options.NoOptions> t)
  System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<System.Double,System.Double,DG.Tweening.Plugins.Options.NoOptions> t)
  System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, System.Single unitsXSecond, System.Double changeValue)
  System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<System.Double> getter, DG.Tweening.Core.DOSetter<System.Double> setter, System.Single elapsed, System.Double startValue, System.Double changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice)
  System.Void .ctor()
END_CLASS

CLASS: DG.Tweening.Plugins.LongPlugin
TYPE:  class
TOKEN: 0x2000076
EXTENDS: ABSTweenPlugin`3
FIELDS:
METHODS:
  System.Void Reset(DG.Tweening.Core.TweenerCore<System.Int64,System.Int64,DG.Tweening.Plugins.Options.NoOptions> t)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<System.Int64,System.Int64,DG.Tweening.Plugins.Options.NoOptions> t, System.Boolean isRelative)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<System.Int64,System.Int64,DG.Tweening.Plugins.Options.NoOptions> t, System.Int64 fromValue, System.Boolean setImmediately, System.Boolean isRelative)
  System.Int64 ConvertToStartValue(DG.Tweening.Core.TweenerCore<System.Int64,System.Int64,DG.Tweening.Plugins.Options.NoOptions> t, System.Int64 value)
  System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<System.Int64,System.Int64,DG.Tweening.Plugins.Options.NoOptions> t)
  System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<System.Int64,System.Int64,DG.Tweening.Plugins.Options.NoOptions> t)
  System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, System.Single unitsXSecond, System.Int64 changeValue)
  System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<System.Int64> getter, DG.Tweening.Core.DOSetter<System.Int64> setter, System.Single elapsed, System.Int64 startValue, System.Int64 changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice)
  System.Void .ctor()
END_CLASS

CLASS: DG.Tweening.Plugins.UlongPlugin
TYPE:  class
TOKEN: 0x2000077
EXTENDS: ABSTweenPlugin`3
FIELDS:
METHODS:
  System.Void Reset(DG.Tweening.Core.TweenerCore<System.UInt64,System.UInt64,DG.Tweening.Plugins.Options.NoOptions> t)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<System.UInt64,System.UInt64,DG.Tweening.Plugins.Options.NoOptions> t, System.Boolean isRelative)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<System.UInt64,System.UInt64,DG.Tweening.Plugins.Options.NoOptions> t, System.UInt64 fromValue, System.Boolean setImmediately, System.Boolean isRelative)
  System.UInt64 ConvertToStartValue(DG.Tweening.Core.TweenerCore<System.UInt64,System.UInt64,DG.Tweening.Plugins.Options.NoOptions> t, System.UInt64 value)
  System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<System.UInt64,System.UInt64,DG.Tweening.Plugins.Options.NoOptions> t)
  System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<System.UInt64,System.UInt64,DG.Tweening.Plugins.Options.NoOptions> t)
  System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, System.Single unitsXSecond, System.UInt64 changeValue)
  System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<System.UInt64> getter, DG.Tweening.Core.DOSetter<System.UInt64> setter, System.Single elapsed, System.UInt64 startValue, System.UInt64 changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice)
  System.Void .ctor()
END_CLASS

CLASS: DG.Tweening.Plugins.Vector3ArrayPlugin
TYPE:  class
TOKEN: 0x2000078
EXTENDS: ABSTweenPlugin`3
FIELDS:
METHODS:
  System.Void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> t)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, System.Boolean isRelative)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, UnityEngine.Vector3[] fromValue, System.Boolean setImmediately, System.Boolean isRelative)
  UnityEngine.Vector3[] ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, UnityEngine.Vector3 value)
  System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> t)
  System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> t)
  System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.Vector3ArrayOptions options, System.Single unitsXSecond, UnityEngine.Vector3[] changeValue)
  System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.Vector3ArrayOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, System.Single elapsed, UnityEngine.Vector3[] startValue, UnityEngine.Vector3[] changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice)
  System.Void .ctor()
END_CLASS

CLASS: DG.Tweening.Plugins.PathPlugin
TYPE:  class
TOKEN: 0x2000079
EXTENDS: ABSTweenPlugin`3
FIELDS:
  public    static  System.Single                   MinLookAhead  // 0x0
METHODS:
  System.Void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t, System.Boolean isRelative)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t, DG.Tweening.Plugins.Core.PathCore.Path fromValue, System.Boolean setImmediately, System.Boolean isRelative)
  DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> Get()
  DG.Tweening.Plugins.Core.PathCore.Path ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Vector3 value)
  System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t)
  System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> t)
  System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.PathOptions options, System.Single unitsXSecond, DG.Tweening.Plugins.Core.PathCore.Path changeValue)
  System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, System.Single elapsed, DG.Tweening.Plugins.Core.PathCore.Path startValue, DG.Tweening.Plugins.Core.PathCore.Path changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice)
  System.Void SetOrientation(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, DG.Tweening.Plugins.Core.PathCore.Path path, System.Single pathPerc, UnityEngine.Vector3 tPos, DG.Tweening.Core.Enums.UpdateNotice updateNotice)
  UnityEngine.Vector3 DivideVectorByVector(UnityEngine.Vector3 vector, UnityEngine.Vector3 byVector)
  UnityEngine.Vector3 MultiplyVectorByVector(UnityEngine.Vector3 vector, UnityEngine.Vector3 byVector)
  System.Void .ctor()
END_CLASS

CLASS: DG.Tweening.Plugins.ColorPlugin
TYPE:  class
TOKEN: 0x200007A
EXTENDS: ABSTweenPlugin`3
FIELDS:
METHODS:
  System.Void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> t)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> t, System.Boolean isRelative)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> t, UnityEngine.Color fromValue, System.Boolean setImmediately, System.Boolean isRelative)
  UnityEngine.Color ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> t, UnityEngine.Color value)
  System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> t)
  System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> t)
  System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.ColorOptions options, System.Single unitsXSecond, UnityEngine.Color changeValue)
  System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.ColorOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Color> getter, DG.Tweening.Core.DOSetter<UnityEngine.Color> setter, System.Single elapsed, UnityEngine.Color startValue, UnityEngine.Color changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice)
  System.Void .ctor()
END_CLASS

CLASS: DG.Tweening.Plugins.IntPlugin
TYPE:  class
TOKEN: 0x200007B
EXTENDS: ABSTweenPlugin`3
FIELDS:
METHODS:
  System.Void Reset(DG.Tweening.Core.TweenerCore<System.Int32,System.Int32,DG.Tweening.Plugins.Options.NoOptions> t)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<System.Int32,System.Int32,DG.Tweening.Plugins.Options.NoOptions> t, System.Boolean isRelative)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<System.Int32,System.Int32,DG.Tweening.Plugins.Options.NoOptions> t, System.Int32 fromValue, System.Boolean setImmediately, System.Boolean isRelative)
  System.Int32 ConvertToStartValue(DG.Tweening.Core.TweenerCore<System.Int32,System.Int32,DG.Tweening.Plugins.Options.NoOptions> t, System.Int32 value)
  System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<System.Int32,System.Int32,DG.Tweening.Plugins.Options.NoOptions> t)
  System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<System.Int32,System.Int32,DG.Tweening.Plugins.Options.NoOptions> t)
  System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, System.Single unitsXSecond, System.Int32 changeValue)
  System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<System.Int32> getter, DG.Tweening.Core.DOSetter<System.Int32> setter, System.Single elapsed, System.Int32 startValue, System.Int32 changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice)
  System.Void .ctor()
END_CLASS

CLASS: DG.Tweening.Plugins.QuaternionPlugin
TYPE:  class
TOKEN: 0x200007C
EXTENDS: ABSTweenPlugin`3
FIELDS:
METHODS:
  System.Void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Vector3,DG.Tweening.Plugins.Options.QuaternionOptions> t)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Vector3,DG.Tweening.Plugins.Options.QuaternionOptions> t, System.Boolean isRelative)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Vector3,DG.Tweening.Plugins.Options.QuaternionOptions> t, UnityEngine.Vector3 fromValue, System.Boolean setImmediately, System.Boolean isRelative)
  UnityEngine.Vector3 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Vector3,DG.Tweening.Plugins.Options.QuaternionOptions> t, UnityEngine.Quaternion value)
  System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Vector3,DG.Tweening.Plugins.Options.QuaternionOptions> t)
  System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Vector3,DG.Tweening.Plugins.Options.QuaternionOptions> t)
  System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.QuaternionOptions options, System.Single unitsXSecond, UnityEngine.Vector3 changeValue)
  System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.QuaternionOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Quaternion> getter, DG.Tweening.Core.DOSetter<UnityEngine.Quaternion> setter, System.Single elapsed, UnityEngine.Vector3 startValue, UnityEngine.Vector3 changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice)
  UnityEngine.Vector3 GetEulerValForCalculations(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Vector3,DG.Tweening.Plugins.Options.QuaternionOptions> t, UnityEngine.Vector3 val, UnityEngine.Vector3 counterVal)
  UnityEngine.Vector3 FlipEulerAngles(UnityEngine.Vector3 euler)
  System.Void .ctor()
END_CLASS

CLASS: DG.Tweening.Plugins.RectOffsetPlugin
TYPE:  class
TOKEN: 0x200007D
EXTENDS: ABSTweenPlugin`3
FIELDS:
  private   static  UnityEngine.RectOffset          _r  // 0x0
METHODS:
  System.Void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset,UnityEngine.RectOffset,DG.Tweening.Plugins.Options.NoOptions> t)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset,UnityEngine.RectOffset,DG.Tweening.Plugins.Options.NoOptions> t, System.Boolean isRelative)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset,UnityEngine.RectOffset,DG.Tweening.Plugins.Options.NoOptions> t, UnityEngine.RectOffset fromValue, System.Boolean setImmediately, System.Boolean isRelative)
  UnityEngine.RectOffset ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset,UnityEngine.RectOffset,DG.Tweening.Plugins.Options.NoOptions> t, UnityEngine.RectOffset value)
  System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset,UnityEngine.RectOffset,DG.Tweening.Plugins.Options.NoOptions> t)
  System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset,UnityEngine.RectOffset,DG.Tweening.Plugins.Options.NoOptions> t)
  System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, System.Single unitsXSecond, UnityEngine.RectOffset changeValue)
  System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<UnityEngine.RectOffset> getter, DG.Tweening.Core.DOSetter<UnityEngine.RectOffset> setter, System.Single elapsed, UnityEngine.RectOffset startValue, UnityEngine.RectOffset changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: DG.Tweening.Plugins.RectPlugin
TYPE:  class
TOKEN: 0x200007E
EXTENDS: ABSTweenPlugin`3
FIELDS:
METHODS:
  System.Void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Rect,UnityEngine.Rect,DG.Tweening.Plugins.Options.RectOptions> t)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Rect,UnityEngine.Rect,DG.Tweening.Plugins.Options.RectOptions> t, System.Boolean isRelative)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Rect,UnityEngine.Rect,DG.Tweening.Plugins.Options.RectOptions> t, UnityEngine.Rect fromValue, System.Boolean setImmediately, System.Boolean isRelative)
  UnityEngine.Rect ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Rect,UnityEngine.Rect,DG.Tweening.Plugins.Options.RectOptions> t, UnityEngine.Rect value)
  System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Rect,UnityEngine.Rect,DG.Tweening.Plugins.Options.RectOptions> t)
  System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Rect,UnityEngine.Rect,DG.Tweening.Plugins.Options.RectOptions> t)
  System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.RectOptions options, System.Single unitsXSecond, UnityEngine.Rect changeValue)
  System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.RectOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Rect> getter, DG.Tweening.Core.DOSetter<UnityEngine.Rect> setter, System.Single elapsed, UnityEngine.Rect startValue, UnityEngine.Rect changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice)
  System.Void .ctor()
END_CLASS

CLASS: DG.Tweening.Plugins.UintPlugin
TYPE:  class
TOKEN: 0x200007F
EXTENDS: ABSTweenPlugin`3
FIELDS:
METHODS:
  System.Void Reset(DG.Tweening.Core.TweenerCore<System.UInt32,System.UInt32,DG.Tweening.Plugins.Options.UintOptions> t)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<System.UInt32,System.UInt32,DG.Tweening.Plugins.Options.UintOptions> t, System.Boolean isRelative)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<System.UInt32,System.UInt32,DG.Tweening.Plugins.Options.UintOptions> t, System.UInt32 fromValue, System.Boolean setImmediately, System.Boolean isRelative)
  System.UInt32 ConvertToStartValue(DG.Tweening.Core.TweenerCore<System.UInt32,System.UInt32,DG.Tweening.Plugins.Options.UintOptions> t, System.UInt32 value)
  System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<System.UInt32,System.UInt32,DG.Tweening.Plugins.Options.UintOptions> t)
  System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<System.UInt32,System.UInt32,DG.Tweening.Plugins.Options.UintOptions> t)
  System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.UintOptions options, System.Single unitsXSecond, System.UInt32 changeValue)
  System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.UintOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<System.UInt32> getter, DG.Tweening.Core.DOSetter<System.UInt32> setter, System.Single elapsed, System.UInt32 startValue, System.UInt32 changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice)
  System.Void .ctor()
END_CLASS

CLASS: DG.Tweening.Plugins.Vector2Plugin
TYPE:  class
TOKEN: 0x2000080
EXTENDS: ABSTweenPlugin`3
FIELDS:
METHODS:
  System.Void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> t)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> t, System.Boolean isRelative)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector2 fromValue, System.Boolean setImmediately, System.Boolean isRelative)
  UnityEngine.Vector2 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector2 value)
  System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> t)
  System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> t)
  System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.VectorOptions options, System.Single unitsXSecond, UnityEngine.Vector2 changeValue)
  System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.VectorOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector2> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector2> setter, System.Single elapsed, UnityEngine.Vector2 startValue, UnityEngine.Vector2 changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice)
  System.Void .ctor()
END_CLASS

CLASS: DG.Tweening.Plugins.Vector4Plugin
TYPE:  class
TOKEN: 0x2000081
EXTENDS: ABSTweenPlugin`3
FIELDS:
METHODS:
  System.Void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4,UnityEngine.Vector4,DG.Tweening.Plugins.Options.VectorOptions> t)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4,UnityEngine.Vector4,DG.Tweening.Plugins.Options.VectorOptions> t, System.Boolean isRelative)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4,UnityEngine.Vector4,DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector4 fromValue, System.Boolean setImmediately, System.Boolean isRelative)
  UnityEngine.Vector4 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4,UnityEngine.Vector4,DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector4 value)
  System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4,UnityEngine.Vector4,DG.Tweening.Plugins.Options.VectorOptions> t)
  System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4,UnityEngine.Vector4,DG.Tweening.Plugins.Options.VectorOptions> t)
  System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.VectorOptions options, System.Single unitsXSecond, UnityEngine.Vector4 changeValue)
  System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.VectorOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector4> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector4> setter, System.Single elapsed, UnityEngine.Vector4 startValue, UnityEngine.Vector4 changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice)
  System.Void .ctor()
END_CLASS

CLASS: DG.Tweening.Plugins.StringPlugin
TYPE:  class
TOKEN: 0x2000082
EXTENDS: ABSTweenPlugin`3
FIELDS:
  private   static readonly System.Text.StringBuilder       _Buffer  // 0x0
  private   static readonly System.Collections.Generic.List<System.Char>_OpenedTags  // 0x8
METHODS:
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<System.String,System.String,DG.Tweening.Plugins.Options.StringOptions> t, System.Boolean isRelative)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<System.String,System.String,DG.Tweening.Plugins.Options.StringOptions> t, System.String fromValue, System.Boolean setImmediately, System.Boolean isRelative)
  System.Void Reset(DG.Tweening.Core.TweenerCore<System.String,System.String,DG.Tweening.Plugins.Options.StringOptions> t)
  System.String ConvertToStartValue(DG.Tweening.Core.TweenerCore<System.String,System.String,DG.Tweening.Plugins.Options.StringOptions> t, System.String value)
  System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<System.String,System.String,DG.Tweening.Plugins.Options.StringOptions> t)
  System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<System.String,System.String,DG.Tweening.Plugins.Options.StringOptions> t)
  System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.StringOptions options, System.Single unitsXSecond, System.String changeValue)
  System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.StringOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<System.String> getter, DG.Tweening.Core.DOSetter<System.String> setter, System.Single elapsed, System.String startValue, System.String changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice)
  System.Text.StringBuilder Append(System.String value, System.Int32 startIndex, System.Int32 length, System.Boolean richTextEnabled)
  System.Char[] ScrambledCharsToUse(DG.Tweening.Plugins.Options.StringOptions options)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: DG.Tweening.Plugins.StringPluginExtensions
TYPE:  class
TOKEN: 0x2000083
FIELDS:
  public    static readonly System.Char[]                   ScrambledCharsAll  // 0x0
  public    static readonly System.Char[]                   ScrambledCharsUppercase  // 0x8
  public    static readonly System.Char[]                   ScrambledCharsLowercase  // 0x10
  public    static readonly System.Char[]                   ScrambledCharsNumerals  // 0x18
  private   static  System.Int32                    _lastRndSeed  // 0x20
METHODS:
  System.Void .cctor()
  System.Void ScrambleChars(System.Char[] chars)
  System.Text.StringBuilder AppendScrambledChars(System.Text.StringBuilder buffer, System.Int32 length, System.Char[] chars)
END_CLASS

CLASS: DG.Tweening.Plugins.FloatPlugin
TYPE:  class
TOKEN: 0x2000084
EXTENDS: ABSTweenPlugin`3
FIELDS:
METHODS:
  System.Void Reset(DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> t)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> t, System.Boolean isRelative)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> t, System.Single fromValue, System.Boolean setImmediately, System.Boolean isRelative)
  System.Single ConvertToStartValue(DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> t, System.Single value)
  System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> t)
  System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> t)
  System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.FloatOptions options, System.Single unitsXSecond, System.Single changeValue)
  System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.FloatOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<System.Single> getter, DG.Tweening.Core.DOSetter<System.Single> setter, System.Single elapsed, System.Single startValue, System.Single changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice)
  System.Void .ctor()
END_CLASS

CLASS: DG.Tweening.Plugins.Vector3Plugin
TYPE:  class
TOKEN: 0x2000085
EXTENDS: ABSTweenPlugin`3
FIELDS:
METHODS:
  System.Void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> t)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> t, System.Boolean isRelative)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector3 fromValue, System.Boolean setImmediately, System.Boolean isRelative)
  UnityEngine.Vector3 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector3 value)
  System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> t)
  System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> t)
  System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.Options.VectorOptions options, System.Single unitsXSecond, UnityEngine.Vector3 changeValue)
  System.Void EvaluateAndApply(DG.Tweening.Plugins.Options.VectorOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, System.Single elapsed, UnityEngine.Vector3 startValue, UnityEngine.Vector3 changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice)
  System.Void .ctor()
END_CLASS

CLASS: DG.Tweening.Plugins.Core.ITPlugin`4
TYPE:  interface
TOKEN: 0x2000092
FIELDS:
METHODS:
END_CLASS

CLASS: DG.Tweening.Plugins.Core.SpecialPluginsUtils
TYPE:  class
TOKEN: 0x2000093
FIELDS:
METHODS:
  System.Boolean SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Vector3,DG.Tweening.Plugins.Options.QuaternionOptions> t)
  System.Boolean SetPunch(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> t)
  System.Boolean SetShake(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> t)
  System.Boolean SetCameraShakePosition(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> t)
END_CLASS

CLASS: DG.Tweening.Plugins.Core.IPlugSetter`4
TYPE:  interface
TOKEN: 0x2000094
FIELDS:
METHODS:
  DG.Tweening.Core.DOGetter<T1> Getter()
  DG.Tweening.Core.DOSetter<T1> Setter()
  T2 EndValue()
  TPlugOptions GetOptions()
END_CLASS

CLASS: DG.Tweening.Plugins.Core.ITweenPlugin
TYPE:  interface
TOKEN: 0x2000095
FIELDS:
METHODS:
END_CLASS

CLASS: DG.Tweening.Plugins.Core.ABSTweenPlugin`3
TYPE:  class
TOKEN: 0x2000096
FIELDS:
METHODS:
  System.Void Reset(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t, System.Boolean isRelative)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t, T2 fromValue, System.Boolean setImmediately, System.Boolean isRelative)
  T2 ConvertToStartValue(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t, T1 value)
  System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t)
  System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<T1,T2,TPlugOptions> t)
  System.Single GetSpeedBasedDuration(TPlugOptions options, System.Single unitsXSecond, T2 changeValue)
  System.Void EvaluateAndApply(TPlugOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<T1> getter, DG.Tweening.Core.DOSetter<T1> setter, System.Single elapsed, T2 startValue, T2 changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice)
  System.Void .ctor()
END_CLASS

CLASS: DG.Tweening.Plugins.Core.PluginsManager
TYPE:  class
TOKEN: 0x2000097
FIELDS:
  private   static  DG.Tweening.Plugins.Core.ITweenPlugin_floatPlugin  // 0x0
  private   static  DG.Tweening.Plugins.Core.ITweenPlugin_doublePlugin  // 0x8
  private   static  DG.Tweening.Plugins.Core.ITweenPlugin_intPlugin  // 0x10
  private   static  DG.Tweening.Plugins.Core.ITweenPlugin_uintPlugin  // 0x18
  private   static  DG.Tweening.Plugins.Core.ITweenPlugin_longPlugin  // 0x20
  private   static  DG.Tweening.Plugins.Core.ITweenPlugin_ulongPlugin  // 0x28
  private   static  DG.Tweening.Plugins.Core.ITweenPlugin_vector2Plugin  // 0x30
  private   static  DG.Tweening.Plugins.Core.ITweenPlugin_vector3Plugin  // 0x38
  private   static  DG.Tweening.Plugins.Core.ITweenPlugin_vector4Plugin  // 0x40
  private   static  DG.Tweening.Plugins.Core.ITweenPlugin_quaternionPlugin  // 0x48
  private   static  DG.Tweening.Plugins.Core.ITweenPlugin_colorPlugin  // 0x50
  private   static  DG.Tweening.Plugins.Core.ITweenPlugin_rectPlugin  // 0x58
  private   static  DG.Tweening.Plugins.Core.ITweenPlugin_rectOffsetPlugin  // 0x60
  private   static  DG.Tweening.Plugins.Core.ITweenPlugin_stringPlugin  // 0x68
  private   static  DG.Tweening.Plugins.Core.ITweenPlugin_vector3ArrayPlugin  // 0x70
  private   static  DG.Tweening.Plugins.Core.ITweenPlugin_color2Plugin  // 0x78
  private   static  System.Int32                    _MaxCustomPlugins  // 0x0
  private   static  System.Collections.Generic.Dictionary<System.Type,DG.Tweening.Plugins.Core.ITweenPlugin>_customPlugins  // 0x80
METHODS:
  DG.Tweening.Plugins.Core.ABSTweenPlugin<T1,T2,TPlugOptions> GetDefaultPlugin()
  DG.Tweening.Plugins.Core.ABSTweenPlugin<T1,T2,TPlugOptions> GetCustomPlugin()
  System.Void PurgeAll()
END_CLASS

CLASS: DG.Tweening.Plugins.Core.PathCore.CubicBezierDecoder
TYPE:  class
TOKEN: 0x2000098
EXTENDS: ABSPathDecoder
FIELDS:
  private   static readonly DG.Tweening.Plugins.Core.PathCore.ControlPoint[]_PartialControlPs  // 0x0
  private   static readonly UnityEngine.Vector3[]           _PartialWps  // 0x8
METHODS:
  System.Int32 get_minInputWaypoints()
  System.Void FinalizePath(DG.Tweening.Plugins.Core.PathCore.Path p, UnityEngine.Vector3[] wps, System.Boolean isClosedPath)
  UnityEngine.Vector3 GetPoint(System.Single perc, UnityEngine.Vector3[] wps, DG.Tweening.Plugins.Core.PathCore.Path p, DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints)
  System.Void SetTimeToLengthTables(DG.Tweening.Plugins.Core.PathCore.Path p, System.Int32 subdivisions)
  System.Void SetWaypointsLengths(DG.Tweening.Plugins.Core.PathCore.Path p, System.Int32 subdivisions)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: DG.Tweening.Plugins.Core.PathCore.ControlPoint
TYPE:  struct
TOKEN: 0x2000099
FIELDS:
  public            UnityEngine.Vector3             a  // 0x10
  public            UnityEngine.Vector3             b  // 0x1C
METHODS:
  System.Void .ctor(UnityEngine.Vector3 a, UnityEngine.Vector3 b)
  DG.Tweening.Plugins.Core.PathCore.ControlPoint op_Addition(DG.Tweening.Plugins.Core.PathCore.ControlPoint cp, UnityEngine.Vector3 v)
  System.String ToString()
END_CLASS

CLASS: DG.Tweening.Plugins.Core.PathCore.ABSPathDecoder
TYPE:  class
TOKEN: 0x200009A
FIELDS:
METHODS:
  System.Void FinalizePath(DG.Tweening.Plugins.Core.PathCore.Path p, UnityEngine.Vector3[] wps, System.Boolean isClosedPath)
  UnityEngine.Vector3 GetPoint(System.Single perc, UnityEngine.Vector3[] wps, DG.Tweening.Plugins.Core.PathCore.Path p, DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints)
  System.Int32 get_minInputWaypoints()
  System.Void .ctor()
END_CLASS

CLASS: DG.Tweening.Plugins.Core.PathCore.CatmullRomDecoder
TYPE:  class
TOKEN: 0x200009B
EXTENDS: ABSPathDecoder
FIELDS:
  private   static readonly DG.Tweening.Plugins.Core.PathCore.ControlPoint[]_PartialControlPs  // 0x0
  private   static readonly UnityEngine.Vector3[]           _PartialWps  // 0x8
METHODS:
  System.Int32 get_minInputWaypoints()
  System.Void FinalizePath(DG.Tweening.Plugins.Core.PathCore.Path p, UnityEngine.Vector3[] wps, System.Boolean isClosedPath)
  UnityEngine.Vector3 GetPoint(System.Single perc, UnityEngine.Vector3[] wps, DG.Tweening.Plugins.Core.PathCore.Path p, DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints)
  System.Void SetTimeToLengthTables(DG.Tweening.Plugins.Core.PathCore.Path p, System.Int32 subdivisions)
  System.Void SetWaypointsLengths(DG.Tweening.Plugins.Core.PathCore.Path p, System.Int32 subdivisions)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: DG.Tweening.Plugins.Core.PathCore.LinearDecoder
TYPE:  class
TOKEN: 0x200009C
EXTENDS: ABSPathDecoder
FIELDS:
METHODS:
  System.Int32 get_minInputWaypoints()
  System.Void FinalizePath(DG.Tweening.Plugins.Core.PathCore.Path p, UnityEngine.Vector3[] wps, System.Boolean isClosedPath)
  UnityEngine.Vector3 GetPoint(System.Single perc, UnityEngine.Vector3[] wps, DG.Tweening.Plugins.Core.PathCore.Path p, DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints)
  System.Void SetTimeToLengthTables(DG.Tweening.Plugins.Core.PathCore.Path p, System.Int32 subdivisions)
  System.Void SetWaypointsLengths(DG.Tweening.Plugins.Core.PathCore.Path p, System.Int32 subdivisions)
  System.Void .ctor()
END_CLASS

CLASS: DG.Tweening.Plugins.Core.PathCore.Path
TYPE:  class
TOKEN: 0x200009D
FIELDS:
  private   static  DG.Tweening.Plugins.Core.PathCore.CatmullRomDecoder_catmullRomDecoder  // 0x0
  private   static  DG.Tweening.Plugins.Core.PathCore.LinearDecoder_linearDecoder  // 0x8
  private   static  DG.Tweening.Plugins.Core.PathCore.CubicBezierDecoder_cubicBezierDecoder  // 0x10
  public            System.Single[]                 wpLengths  // 0x10
  public            UnityEngine.Vector3[]           wps  // 0x18
  private           DG.Tweening.PathType            type  // 0x20
  private           System.Int32                    subdivisionsXSegment  // 0x24
  private           System.Int32                    subdivisions  // 0x28
  private           DG.Tweening.Plugins.Core.PathCore.ControlPoint[]controlPoints  // 0x30
  private           System.Single                   length  // 0x38
  private           System.Boolean                  isFinalized  // 0x3C
  private           System.Single[]                 timesTable  // 0x40
  private           System.Single[]                 lengthsTable  // 0x48
  private           System.Int32                    linearWPIndex  // 0x50
  private           System.Boolean                  addedExtraStartWp  // 0x54
  private           System.Boolean                  addedExtraEndWp  // 0x55
  private           DG.Tweening.Plugins.Options.PathOptionsplugOptions  // 0x58
  private           DG.Tweening.Plugins.Core.PathCore.Path_incrementalClone  // 0xC8
  private           System.Int32                    _incrementalIndex  // 0xD0
  private           DG.Tweening.Plugins.Core.PathCore.ABSPathDecoder_decoder  // 0xD8
  private           System.Boolean                  _changed  // 0xE0
  private           UnityEngine.Vector3[]           nonLinearDrawWps  // 0xE8
  private           UnityEngine.Vector3             targetPosition  // 0xF0
  private           System.Nullable<UnityEngine.Vector3>lookAtPosition  // 0xFC
  private           UnityEngine.Color               gizmoColor  // 0x10C
METHODS:
  System.Int32 get_minInputWaypoints()
  System.Void .ctor(DG.Tweening.PathType type, UnityEngine.Vector3[] waypoints, System.Int32 subdivisionsXSegment, System.Nullable<UnityEngine.Color> gizmoColor)
  System.Void .ctor()
  System.Void FinalizePath(System.Boolean isClosedPath, DG.Tweening.AxisConstraint lockPositionAxes, UnityEngine.Vector3 currTargetVal)
  UnityEngine.Vector3 GetPoint(System.Single perc, System.Boolean convertToConstantPerc)
  System.Single ConvertToConstantPathPerc(System.Single perc)
  System.Int32 GetWaypointIndexFromPerc(System.Single perc, System.Boolean isMovingForward)
  UnityEngine.Vector3[] GetDrawPoints(DG.Tweening.Plugins.Core.PathCore.Path p, System.Int32 drawSubdivisionsXSegment)
  System.Void RefreshNonLinearDrawWps(DG.Tweening.Plugins.Core.PathCore.Path p)
  System.Void Destroy()
  DG.Tweening.Plugins.Core.PathCore.Path CloneIncremental(System.Int32 loopIncrement)
  System.Void AssignWaypoints(UnityEngine.Vector3[] newWps, System.Boolean cloneWps)
  System.Void AssignDecoder(DG.Tweening.PathType pathType)
  System.Void Draw()
  System.Void Draw(DG.Tweening.Plugins.Core.PathCore.Path p)
  UnityEngine.Vector3 ConvertToDrawPoint(UnityEngine.Vector3 wp, DG.Tweening.Plugins.Options.PathOptions plugOptions)
END_CLASS

CLASS: DG.Tweening.Plugins.Options.IPlugOptions
TYPE:  interface
TOKEN: 0x2000086
FIELDS:
METHODS:
  System.Void Reset()
END_CLASS

CLASS: DG.Tweening.Plugins.Options.OrientType
TYPE:  struct
TOKEN: 0x2000087
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.Plugins.Options.OrientTypeNone  // 0x0
  public    static  DG.Tweening.Plugins.Options.OrientTypeToPath  // 0x0
  public    static  DG.Tweening.Plugins.Options.OrientTypeLookAtTransform  // 0x0
  public    static  DG.Tweening.Plugins.Options.OrientTypeLookAtPosition  // 0x0
METHODS:
END_CLASS

CLASS: DG.Tweening.Plugins.Options.PathOptions
TYPE:  struct
TOKEN: 0x2000088
FIELDS:
  public            DG.Tweening.PathMode            mode  // 0x10
  public            DG.Tweening.Plugins.Options.OrientTypeorientType  // 0x14
  public            DG.Tweening.AxisConstraint      lockPositionAxis  // 0x18
  public            DG.Tweening.AxisConstraint      lockRotationAxis  // 0x1C
  public            System.Boolean                  isClosedPath  // 0x20
  public            UnityEngine.Vector3             lookAtPosition  // 0x24
  public            UnityEngine.Transform           lookAtTransform  // 0x30
  public            System.Single                   lookAhead  // 0x38
  public            System.Boolean                  hasCustomForwardDirection  // 0x3C
  public            UnityEngine.Quaternion          forward  // 0x40
  public            System.Boolean                  useLocalPosition  // 0x50
  public            UnityEngine.Transform           parent  // 0x58
  public            System.Boolean                  isRigidbody  // 0x60
  public            System.Boolean                  isRigidbody2D  // 0x61
  public            System.Boolean                  stableZRotation  // 0x62
  private           UnityEngine.Quaternion          startupRot  // 0x64
  private           System.Single                   startupZRot  // 0x74
  private           System.Boolean                  addedExtraStartWp  // 0x78
  private           System.Boolean                  addedExtraEndWp  // 0x79
METHODS:
  System.Void Reset()
END_CLASS

CLASS: DG.Tweening.Plugins.Options.QuaternionOptions
TYPE:  struct
TOKEN: 0x2000089
FIELDS:
  public            DG.Tweening.RotateMode          rotateMode  // 0x10
  public            DG.Tweening.AxisConstraint      axisConstraint  // 0x14
  public            UnityEngine.Vector3             up  // 0x18
  public            System.Boolean                  dynamicLookAt  // 0x24
  public            UnityEngine.Vector3             dynamicLookAtWorldPosition  // 0x28
METHODS:
  System.Void Reset()
END_CLASS

CLASS: DG.Tweening.Plugins.Options.UintOptions
TYPE:  struct
TOKEN: 0x200008A
FIELDS:
  public            System.Boolean                  isNegativeChangeValue  // 0x10
METHODS:
  System.Void Reset()
END_CLASS

CLASS: DG.Tweening.Plugins.Options.Vector3ArrayOptions
TYPE:  struct
TOKEN: 0x200008B
FIELDS:
  public            DG.Tweening.AxisConstraint      axisConstraint  // 0x10
  public            System.Boolean                  snapping  // 0x14
  private           System.Single[]                 durations  // 0x18
METHODS:
  System.Void Reset()
END_CLASS

CLASS: DG.Tweening.Plugins.Options.NoOptions
TYPE:  struct
TOKEN: 0x200008C
FIELDS:
METHODS:
  System.Void Reset()
END_CLASS

CLASS: DG.Tweening.Plugins.Options.ColorOptions
TYPE:  struct
TOKEN: 0x200008D
FIELDS:
  public            System.Boolean                  alphaOnly  // 0x10
METHODS:
  System.Void Reset()
END_CLASS

CLASS: DG.Tweening.Plugins.Options.FloatOptions
TYPE:  struct
TOKEN: 0x200008E
FIELDS:
  public            System.Boolean                  snapping  // 0x10
METHODS:
  System.Void Reset()
END_CLASS

CLASS: DG.Tweening.Plugins.Options.RectOptions
TYPE:  struct
TOKEN: 0x200008F
FIELDS:
  public            System.Boolean                  snapping  // 0x10
METHODS:
  System.Void Reset()
END_CLASS

CLASS: DG.Tweening.Plugins.Options.StringOptions
TYPE:  struct
TOKEN: 0x2000090
FIELDS:
  public            System.Boolean                  richTextEnabled  // 0x10
  public            DG.Tweening.ScrambleMode        scrambleMode  // 0x14
  public            System.Char[]                   scrambledChars  // 0x18
  private           System.Int32                    startValueStrippedLength  // 0x20
  private           System.Int32                    changeValueStrippedLength  // 0x24
METHODS:
  System.Void Reset()
END_CLASS

CLASS: DG.Tweening.Plugins.Options.VectorOptions
TYPE:  struct
TOKEN: 0x2000091
FIELDS:
  public            DG.Tweening.AxisConstraint      axisConstraint  // 0x10
  public            System.Boolean                  snapping  // 0x14
METHODS:
  System.Void Reset()
END_CLASS

