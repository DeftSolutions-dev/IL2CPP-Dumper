// ========================================================
// Dumped by @desirepro
// Assembly: DOTweenPro.dll
// Classes:  13
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: DG.Tweening.DOTweenVisualManager
TYPE:  class
TOKEN: 0x2000002
EXTENDS: MonoBehaviour
FIELDS:
  public            DG.Tweening.Core.VisualManagerPresetpreset  // 0x18
  public            DG.Tweening.Core.OnEnableBehaviouronEnableBehaviour  // 0x1C
  public            DG.Tweening.Core.OnDisableBehaviouronDisableBehaviour  // 0x20
  private           System.Boolean                  _requiresRestartFromSpawnPoint  // 0x24
  private           DG.Tweening.Core.ABSAnimationComponent_animComponent  // 0x28
METHODS:
  System.Void Awake()
  System.Void Update()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void .ctor()
END_CLASS

CLASS: DG.Tweening.HandlesDrawMode
TYPE:  struct
TOKEN: 0x2000003
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.HandlesDrawMode     Orthographic  // 0x0
  public    static  DG.Tweening.HandlesDrawMode     Perspective  // 0x0
METHODS:
END_CLASS

CLASS: DG.Tweening.HandlesType
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.HandlesType         Free  // 0x0
  public    static  DG.Tweening.HandlesType         Full  // 0x0
METHODS:
END_CLASS

CLASS: DG.Tweening.DOTweenInspectorMode
TYPE:  struct
TOKEN: 0x2000005
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.DOTweenInspectorModeDefault  // 0x0
  public    static  DG.Tweening.DOTweenInspectorModeInfoAndWaypointsOnly  // 0x0
  public    static  DG.Tweening.DOTweenInspectorModeDeveloper  // 0x0
  public    static  DG.Tweening.DOTweenInspectorModeOnlyPath  // 0x0
METHODS:
END_CLASS

CLASS: DG.Tweening.DOTweenPath
TYPE:  class
TOKEN: 0x2000006
EXTENDS: ABSAnimationComponent
FIELDS:
  private   static  System.Action<DG.Tweening.DOTweenPath>OnReset  // 0x0
  public            System.Single                   delay  // 0x68
  public            System.Single                   duration  // 0x6C
  public            DG.Tweening.Ease                easeType  // 0x70
  public            UnityEngine.AnimationCurve      easeCurve  // 0x78
  public            System.Int32                    loops  // 0x80
  public            System.String                   id  // 0x88
  public            DG.Tweening.LoopType            loopType  // 0x90
  public            DG.Tweening.Plugins.Options.OrientTypeorientType  // 0x94
  public            UnityEngine.Transform           lookAtTransform  // 0x98
  public            UnityEngine.Vector3             lookAtPosition  // 0xA0
  public            System.Single                   lookAhead  // 0xAC
  public            System.Boolean                  autoPlay  // 0xB0
  public            System.Boolean                  autoKill  // 0xB1
  public            System.Boolean                  relative  // 0xB2
  public            System.Boolean                  isLocal  // 0xB3
  public            System.Boolean                  isClosedPath  // 0xB4
  public            System.Int32                    pathResolution  // 0xB8
  public            DG.Tweening.PathMode            pathMode  // 0xBC
  public            DG.Tweening.AxisConstraint      lockRotation  // 0xC0
  public            System.Boolean                  assignForwardAndUp  // 0xC4
  public            UnityEngine.Vector3             forwardDirection  // 0xC8
  public            UnityEngine.Vector3             upDirection  // 0xD4
  public            System.Boolean                  tweenRigidbody  // 0xE0
  public            System.Collections.Generic.List<UnityEngine.Vector3>wps  // 0xE8
  public            System.Collections.Generic.List<UnityEngine.Vector3>fullWps  // 0xF0
  public            DG.Tweening.Plugins.Core.PathCore.Pathpath  // 0xF8
  public            DG.Tweening.DOTweenInspectorModeinspectorMode  // 0x100
  public            DG.Tweening.PathType            pathType  // 0x104
  public            DG.Tweening.HandlesType         handlesType  // 0x108
  public            System.Boolean                  livePreview  // 0x10C
  public            DG.Tweening.HandlesDrawMode     handlesDrawMode  // 0x110
  public            System.Single                   perspectiveHandleSize  // 0x114
  public            System.Boolean                  showIndexes  // 0x118
  public            System.Boolean                  showWpLength  // 0x119
  public            UnityEngine.Color               pathColor  // 0x11C
  public            UnityEngine.Vector3             lastSrcPosition  // 0x12C
  public            UnityEngine.Quaternion          lastSrcRotation  // 0x138
  public            System.Boolean                  wpsDropdown  // 0x148
  public            System.Single                   dropToFloorOffset  // 0x14C
  private   static  System.Reflection.MethodInfo    _miCreateTween  // 0x8
METHODS:
  System.Void add_OnReset(System.Action<DG.Tweening.DOTweenPath> value)
  System.Void remove_OnReset(System.Action<DG.Tweening.DOTweenPath> value)
  System.Void Dispatch_OnReset(DG.Tweening.DOTweenPath path)
  System.Void Awake()
  System.Void Reset()
  System.Void OnDestroy()
  System.Void DOPlay()
  System.Void DOPlayById(System.String id)
  System.Void DOPlayAllById(System.String id)
  System.Void DOPlayBackwards()
  System.Void DOPlayForward()
  System.Void DOPause()
  System.Void DOTogglePause()
  System.Void DORewind()
  System.Void DORestart()
  System.Void DORestart(System.Boolean fromHere)
  System.Void DOComplete()
  System.Void DOKill()
  System.Void DOKillAllById(System.String id)
  DG.Tweening.Tween GetTween()
  UnityEngine.Vector3[] GetDrawPoints()
  UnityEngine.Vector3[] GetFullWps()
  System.Void ReEvaluateRelativeTween()
  System.Void .ctor()
  System.Void <Awake>b__44_0()
END_CLASS

CLASS: DG.Tweening.SpiralMode
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.SpiralMode          Expand  // 0x0
  public    static  DG.Tweening.SpiralMode          ExpandThenContract  // 0x0
METHODS:
END_CLASS

CLASS: DG.Tweening.Core.ABSAnimationComponent
TYPE:  class
TOKEN: 0x200000A
EXTENDS: MonoBehaviour
FIELDS:
  public            DG.Tweening.UpdateType          updateType  // 0x18
  public            System.Boolean                  isSpeedBased  // 0x1C
  public            System.Boolean                  hasOnStart  // 0x1D
  public            System.Boolean                  hasOnPlay  // 0x1E
  public            System.Boolean                  hasOnUpdate  // 0x1F
  public            System.Boolean                  hasOnStepComplete  // 0x20
  public            System.Boolean                  hasOnComplete  // 0x21
  public            System.Boolean                  hasOnTweenCreated  // 0x22
  public            System.Boolean                  hasOnRewind  // 0x23
  public            UnityEngine.Events.UnityEvent   onStart  // 0x28
  public            UnityEngine.Events.UnityEvent   onPlay  // 0x30
  public            UnityEngine.Events.UnityEvent   onUpdate  // 0x38
  public            UnityEngine.Events.UnityEvent   onStepComplete  // 0x40
  public            UnityEngine.Events.UnityEvent   onComplete  // 0x48
  public            UnityEngine.Events.UnityEvent   onTweenCreated  // 0x50
  public            UnityEngine.Events.UnityEvent   onRewind  // 0x58
  public            DG.Tweening.Tween               tween  // 0x60
METHODS:
  System.Void DOPlay()
  System.Void DOPlayBackwards()
  System.Void DOPlayForward()
  System.Void DOPause()
  System.Void DOTogglePause()
  System.Void DORewind()
  System.Void DORestart()
  System.Void DORestart(System.Boolean fromHere)
  System.Void DOComplete()
  System.Void DOKill()
  System.Void .ctor()
END_CLASS

CLASS: DG.Tweening.Core.OnDisableBehaviour
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.Core.OnDisableBehaviourNone  // 0x0
  public    static  DG.Tweening.Core.OnDisableBehaviourPause  // 0x0
  public    static  DG.Tweening.Core.OnDisableBehaviourRewind  // 0x0
  public    static  DG.Tweening.Core.OnDisableBehaviourKill  // 0x0
  public    static  DG.Tweening.Core.OnDisableBehaviourKillAndComplete  // 0x0
  public    static  DG.Tweening.Core.OnDisableBehaviourDestroyGameObject  // 0x0
METHODS:
END_CLASS

CLASS: DG.Tweening.Core.OnEnableBehaviour
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.Core.OnEnableBehaviourNone  // 0x0
  public    static  DG.Tweening.Core.OnEnableBehaviourPlay  // 0x0
  public    static  DG.Tweening.Core.OnEnableBehaviourRestart  // 0x0
  public    static  DG.Tweening.Core.OnEnableBehaviourRestartFromSpawnPoint  // 0x0
METHODS:
END_CLASS

CLASS: DG.Tweening.Core.VisualManagerPreset
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.Core.VisualManagerPresetCustom  // 0x0
  public    static  DG.Tweening.Core.VisualManagerPresetPoolingSystem  // 0x0
METHODS:
END_CLASS

CLASS: DG.Tweening.Plugins.SpiralOptions
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.Single                   depth  // 0x10
  public            System.Single                   frequency  // 0x14
  public            System.Single                   speed  // 0x18
  public            DG.Tweening.SpiralMode          mode  // 0x1C
  public            System.Boolean                  snapping  // 0x20
  private           System.Single                   unit  // 0x24
  private           UnityEngine.Quaternion          axisQ  // 0x28
METHODS:
  System.Void Reset()
END_CLASS

CLASS: DG.Tweening.Plugins.SpiralPlugin
TYPE:  class
TOKEN: 0x2000009
EXTENDS: ABSTweenPlugin`3
FIELDS:
  public    static readonly UnityEngine.Vector3             DefaultDirection  // 0x0
METHODS:
  System.Void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.SpiralOptions> t)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.SpiralOptions> t, System.Boolean isRelative)
  System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.SpiralOptions> t, UnityEngine.Vector3 fromValue, System.Boolean setImmediately, System.Boolean isRelative)
  DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.SpiralOptions> Get()
  UnityEngine.Vector3 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.SpiralOptions> t, UnityEngine.Vector3 value)
  System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.SpiralOptions> t)
  System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.SpiralOptions> t)
  System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.SpiralOptions options, System.Single unitsXSecond, UnityEngine.Vector3 changeValue)
  System.Void EvaluateAndApply(DG.Tweening.Plugins.SpiralOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, System.Single elapsed, UnityEngine.Vector3 startValue, UnityEngine.Vector3 changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

