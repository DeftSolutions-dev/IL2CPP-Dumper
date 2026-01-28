// ========================================================
// Dumped by @desirepro
// Assembly: DOTweenPro.Runtime.dll
// Classes:  7
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: AnimationType
TYPE:  struct
TOKEN: 0x2000003
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.DOTweenAnimation.AnimationTypeNone  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.AnimationTypeMove  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.AnimationTypeLocalMove  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.AnimationTypeRotate  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.AnimationTypeLocalRotate  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.AnimationTypeScale  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.AnimationTypeColor  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.AnimationTypeFade  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.AnimationTypeText  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.AnimationTypePunchPosition  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.AnimationTypePunchRotation  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.AnimationTypePunchScale  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.AnimationTypeShakePosition  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.AnimationTypeShakeRotation  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.AnimationTypeShakeScale  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.AnimationTypeCameraAspect  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.AnimationTypeCameraBackgroundColor  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.AnimationTypeCameraFieldOfView  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.AnimationTypeCameraOrthoSize  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.AnimationTypeCameraPixelRect  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.AnimationTypeCameraRect  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.AnimationTypeUIWidthHeight  // 0x0
METHODS:
END_CLASS

CLASS: TargetType
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  DG.Tweening.DOTweenAnimation.TargetTypeUnset  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.TargetTypeCamera  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.TargetTypeCanvasGroup  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.TargetTypeImage  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.TargetTypeLight  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.TargetTypeRectTransform  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.TargetTypeRenderer  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.TargetTypeSpriteRenderer  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.TargetTypeRigidbody  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.TargetTypeRigidbody2D  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.TargetTypeText  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.TargetTypeTransform  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.TargetTypetk2dBaseSprite  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.TargetTypetk2dTextMesh  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.TargetTypeTextMeshPro  // 0x0
  public    static  DG.Tweening.DOTweenAnimation.TargetTypeTextMeshProUGUI  // 0x0
METHODS:
END_CLASS

CLASS: DG.Tweening.DOTweenAnimation
TYPE:  class
TOKEN: 0x2000002
EXTENDS: ABSAnimationComponent
FIELDS:
  private   static  System.Action<DG.Tweening.DOTweenAnimation>OnReset  // 0x0
  public            System.Boolean                  targetIsSelf  // 0x68
  public            UnityEngine.GameObject          targetGO  // 0x70
  public            System.Boolean                  tweenTargetIsTargetGO  // 0x78
  public            System.Single                   delay  // 0x7C
  public            System.Single                   duration  // 0x80
  public            DG.Tweening.Ease                easeType  // 0x84
  public            UnityEngine.AnimationCurve      easeCurve  // 0x88
  public            DG.Tweening.LoopType            loopType  // 0x90
  public            System.Int32                    loops  // 0x94
  public            System.String                   id  // 0x98
  public            System.Boolean                  isRelative  // 0xA0
  public            System.Boolean                  isFrom  // 0xA1
  public            System.Boolean                  isIndependentUpdate  // 0xA2
  public            System.Boolean                  autoKill  // 0xA3
  public            System.Boolean                  autoGenerate  // 0xA4
  public            System.Boolean                  isActive  // 0xA5
  public            System.Boolean                  isValid  // 0xA6
  public            UnityEngine.Component           target  // 0xA8
  public            DG.Tweening.DOTweenAnimation.AnimationTypeanimationType  // 0xB0
  public            DG.Tweening.DOTweenAnimation.TargetTypetargetType  // 0xB4
  public            DG.Tweening.DOTweenAnimation.TargetTypeforcedTargetType  // 0xB8
  public            System.Boolean                  autoPlay  // 0xBC
  public            System.Boolean                  useTargetAsV3  // 0xBD
  public            System.Single                   endValueFloat  // 0xC0
  public            UnityEngine.Vector3             endValueV3  // 0xC4
  public            UnityEngine.Vector2             endValueV2  // 0xD0
  public            UnityEngine.Color               endValueColor  // 0xD8
  public            System.String                   endValueString  // 0xE8
  public            UnityEngine.Rect                endValueRect  // 0xF0
  public            UnityEngine.Transform           endValueTransform  // 0x100
  public            System.Boolean                  optionalBool0  // 0x108
  public            System.Boolean                  optionalBool1  // 0x109
  public            System.Single                   optionalFloat0  // 0x10C
  public            System.Int32                    optionalInt0  // 0x110
  public            DG.Tweening.RotateMode          optionalRotationMode  // 0x114
  public            DG.Tweening.ScrambleMode        optionalScrambleMode  // 0x118
  public            DG.Tweening.ShakeRandomnessMode optionalShakeRandomnessMode  // 0x11C
  public            System.String                   optionalString  // 0x120
  private           System.Boolean                  _tweenAutoGenerationCalled  // 0x128
  private           System.Int32                    _playCount  // 0x12C
METHODS:
  System.Void add_OnReset(System.Action<DG.Tweening.DOTweenAnimation> value)
  System.Void remove_OnReset(System.Action<DG.Tweening.DOTweenAnimation> value)
  System.Void Dispatch_OnReset(DG.Tweening.DOTweenAnimation anim)
  System.Void Awake()
  System.Void Start()
  System.Void Reset()
  System.Void OnDestroy()
  System.Void RewindThenRecreateTween()
  System.Void RewindThenRecreateTweenAndPlay()
  System.Void RecreateTween()
  System.Void RecreateTweenAndPlay()
  System.Void CreateTween(System.Boolean regenerateIfExists, System.Boolean andPlay)
  System.Collections.Generic.List<DG.Tweening.Tween> GetTweens()
  System.Void SetAnimationTarget(UnityEngine.Component tweenTarget, System.Boolean useTweenTargetGameObjectForGroupOperations)
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
  System.Void DOPlayById(System.String id)
  System.Void DOPlayAllById(System.String id)
  System.Void DOPauseAllById(System.String id)
  System.Void DOPlayBackwardsById(System.String id)
  System.Void DOPlayBackwardsAllById(System.String id)
  System.Void DOPlayForwardById(System.String id)
  System.Void DOPlayForwardAllById(System.String id)
  System.Void DOPlayNext()
  System.Void DORewindAndPlayNext()
  System.Void DORewindAllById(System.String id)
  System.Void DORestartById(System.String id)
  System.Void DORestartAllById(System.String id)
  System.Void DOKillById(System.String id)
  System.Void DOKillAllById(System.String id)
  DG.Tweening.DOTweenAnimation.TargetType TypeToDOTargetType(System.Type t)
  DG.Tweening.Tween CreateEditorPreview()
  UnityEngine.GameObject GetTweenGO()
  UnityEngine.GameObject GetTweenTarget()
  System.Void ReEvaluateRelativeTween()
  System.Void .ctor()
  System.Void <CreateTween>b__54_0()
END_CLASS

CLASS: DG.Tweening.DOTweenAnimationExtensions
TYPE:  class
TOKEN: 0x2000005
FIELDS:
METHODS:
  System.Boolean IsSameOrSubclassOf(UnityEngine.Component t)
END_CLASS

CLASS: DG.Tweening.DOTweenProShortcuts
TYPE:  class
TOKEN: 0x2000006
FIELDS:
METHODS:
  System.Void .cctor()
  DG.Tweening.Tweener DOSpiral(UnityEngine.Transform target, System.Single duration, System.Nullable<UnityEngine.Vector3> axis, DG.Tweening.SpiralMode mode, System.Single speed, System.Single frequency, System.Single depth, System.Boolean snapping)
END_CLASS

