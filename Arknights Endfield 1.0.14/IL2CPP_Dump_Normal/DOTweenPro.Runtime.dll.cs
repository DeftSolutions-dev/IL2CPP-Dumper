// ========================================================
// Dumped by @desirepro
// Assembly: DOTweenPro.Runtime.dll
// Classes:  7
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000003
    public struct AnimationType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.DOTweenAnimation.AnimationType None;        // 0x0
        public static DG.Tweening.DOTweenAnimation.AnimationType Move;        // 0x0
        public static DG.Tweening.DOTweenAnimation.AnimationType LocalMove;        // 0x0
        public static DG.Tweening.DOTweenAnimation.AnimationType Rotate;        // 0x0
        public static DG.Tweening.DOTweenAnimation.AnimationType LocalRotate;        // 0x0
        public static DG.Tweening.DOTweenAnimation.AnimationType Scale;        // 0x0
        public static DG.Tweening.DOTweenAnimation.AnimationType Color;        // 0x0
        public static DG.Tweening.DOTweenAnimation.AnimationType Fade;        // 0x0
        public static DG.Tweening.DOTweenAnimation.AnimationType Text;        // 0x0
        public static DG.Tweening.DOTweenAnimation.AnimationType PunchPosition;        // 0x0
        public static DG.Tweening.DOTweenAnimation.AnimationType PunchRotation;        // 0x0
        public static DG.Tweening.DOTweenAnimation.AnimationType PunchScale;        // 0x0
        public static DG.Tweening.DOTweenAnimation.AnimationType ShakePosition;        // 0x0
        public static DG.Tweening.DOTweenAnimation.AnimationType ShakeRotation;        // 0x0
        public static DG.Tweening.DOTweenAnimation.AnimationType ShakeScale;        // 0x0
        public static DG.Tweening.DOTweenAnimation.AnimationType CameraAspect;        // 0x0
        public static DG.Tweening.DOTweenAnimation.AnimationType CameraBackgroundColor;        // 0x0
        public static DG.Tweening.DOTweenAnimation.AnimationType CameraFieldOfView;        // 0x0
        public static DG.Tweening.DOTweenAnimation.AnimationType CameraOrthoSize;        // 0x0
        public static DG.Tweening.DOTweenAnimation.AnimationType CameraPixelRect;        // 0x0
        public static DG.Tweening.DOTweenAnimation.AnimationType CameraRect;        // 0x0
        public static DG.Tweening.DOTweenAnimation.AnimationType UIWidthHeight;        // 0x0

    }

    // TypeToken: 0x2000004
    public struct TargetType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.DOTweenAnimation.TargetType Unset;        // 0x0
        public static DG.Tweening.DOTweenAnimation.TargetType Camera;        // 0x0
        public static DG.Tweening.DOTweenAnimation.TargetType CanvasGroup;        // 0x0
        public static DG.Tweening.DOTweenAnimation.TargetType Image;        // 0x0
        public static DG.Tweening.DOTweenAnimation.TargetType Light;        // 0x0
        public static DG.Tweening.DOTweenAnimation.TargetType RectTransform;        // 0x0
        public static DG.Tweening.DOTweenAnimation.TargetType Renderer;        // 0x0
        public static DG.Tweening.DOTweenAnimation.TargetType SpriteRenderer;        // 0x0
        public static DG.Tweening.DOTweenAnimation.TargetType Rigidbody;        // 0x0
        public static DG.Tweening.DOTweenAnimation.TargetType Rigidbody2D;        // 0x0
        public static DG.Tweening.DOTweenAnimation.TargetType Text;        // 0x0
        public static DG.Tweening.DOTweenAnimation.TargetType Transform;        // 0x0
        public static DG.Tweening.DOTweenAnimation.TargetType tk2dBaseSprite;        // 0x0
        public static DG.Tweening.DOTweenAnimation.TargetType tk2dTextMesh;        // 0x0
        public static DG.Tweening.DOTweenAnimation.TargetType TextMeshPro;        // 0x0
        public static DG.Tweening.DOTweenAnimation.TargetType TextMeshProUGUI;        // 0x0

    }

namespace DG.Tweening
{

    // TypeToken: 0x2000002
    public class DOTweenAnimation : ABSAnimationComponent
    {
        // Fields
        private static System.Action<DG.Tweening.DOTweenAnimation> OnReset;        // 0x0
        public System.Boolean targetIsSelf;        // 0x68
        public UnityEngine.GameObject targetGO;        // 0x70
        public System.Boolean tweenTargetIsTargetGO;        // 0x78
        public System.Single delay;        // 0x7C
        public System.Single duration;        // 0x80
        public DG.Tweening.Ease easeType;        // 0x84
        public UnityEngine.AnimationCurve easeCurve;        // 0x88
        public DG.Tweening.LoopType loopType;        // 0x90
        public System.Int32 loops;        // 0x94
        public System.String id;        // 0x98
        public System.Boolean isRelative;        // 0xA0
        public System.Boolean isFrom;        // 0xA1
        public System.Boolean isIndependentUpdate;        // 0xA2
        public System.Boolean autoKill;        // 0xA3
        public System.Boolean autoGenerate;        // 0xA4
        public System.Boolean isActive;        // 0xA5
        public System.Boolean isValid;        // 0xA6
        public UnityEngine.Component target;        // 0xA8
        public DG.Tweening.DOTweenAnimation.AnimationType animationType;        // 0xB0
        public DG.Tweening.DOTweenAnimation.TargetType targetType;        // 0xB4
        public DG.Tweening.DOTweenAnimation.TargetType forcedTargetType;        // 0xB8
        public System.Boolean autoPlay;        // 0xBC
        public System.Boolean useTargetAsV3;        // 0xBD
        public System.Single endValueFloat;        // 0xC0
        public UnityEngine.Vector3 endValueV3;        // 0xC4
        public UnityEngine.Vector2 endValueV2;        // 0xD0
        public UnityEngine.Color endValueColor;        // 0xD8
        public System.String endValueString;        // 0xE8
        public UnityEngine.Rect endValueRect;        // 0xF0
        public UnityEngine.Transform endValueTransform;        // 0x100
        public System.Boolean optionalBool0;        // 0x108
        public System.Boolean optionalBool1;        // 0x109
        public System.Single optionalFloat0;        // 0x10C
        public System.Int32 optionalInt0;        // 0x110
        public DG.Tweening.RotateMode optionalRotationMode;        // 0x114
        public DG.Tweening.ScrambleMode optionalScrambleMode;        // 0x118
        public DG.Tweening.ShakeRandomnessMode optionalShakeRandomnessMode;        // 0x11C
        public System.String optionalString;        // 0x120
        private System.Boolean _tweenAutoGenerationCalled;        // 0x128
        private System.Int32 _playCount;        // 0x12C

        // Methods
        private System.Void add_OnReset(System.Action<DG.Tweening.DOTweenAnimation> value) { }
        private System.Void remove_OnReset(System.Action<DG.Tweening.DOTweenAnimation> value) { }
        private System.Void Dispatch_OnReset(DG.Tweening.DOTweenAnimation anim) { }
        private System.Void Awake() { }
        private System.Void Start() { }
        private System.Void Reset() { }
        private System.Void OnDestroy() { }
        private System.Void RewindThenRecreateTween() { }
        private System.Void RewindThenRecreateTweenAndPlay() { }
        private System.Void RecreateTween() { }
        private System.Void RecreateTweenAndPlay() { }
        private System.Void CreateTween(System.Boolean regenerateIfExists, System.Boolean andPlay) { }
        private System.Collections.Generic.List<DG.Tweening.Tween> GetTweens() { }
        private System.Void SetAnimationTarget(UnityEngine.Component tweenTarget, System.Boolean useTweenTargetGameObjectForGroupOperations) { }
        private System.Void DOPlay() { }
        private System.Void DOPlayBackwards() { }
        private System.Void DOPlayForward() { }
        private System.Void DOPause() { }
        private System.Void DOTogglePause() { }
        private System.Void DORewind() { }
        private System.Void DORestart() { }
        private System.Void DORestart(System.Boolean fromHere) { }
        private System.Void DOComplete() { }
        private System.Void DOKill() { }
        private System.Void DOPlayById(System.String id) { }
        private System.Void DOPlayAllById(System.String id) { }
        private System.Void DOPauseAllById(System.String id) { }
        private System.Void DOPlayBackwardsById(System.String id) { }
        private System.Void DOPlayBackwardsAllById(System.String id) { }
        private System.Void DOPlayForwardById(System.String id) { }
        private System.Void DOPlayForwardAllById(System.String id) { }
        private System.Void DOPlayNext() { }
        private System.Void DORewindAndPlayNext() { }
        private System.Void DORewindAllById(System.String id) { }
        private System.Void DORestartById(System.String id) { }
        private System.Void DORestartAllById(System.String id) { }
        private System.Void DOKillById(System.String id) { }
        private System.Void DOKillAllById(System.String id) { }
        private DG.Tweening.DOTweenAnimation.TargetType TypeToDOTargetType(System.Type t) { }
        private DG.Tweening.Tween CreateEditorPreview() { }
        private UnityEngine.GameObject GetTweenGO() { }
        private UnityEngine.GameObject GetTweenTarget() { }
        private System.Void ReEvaluateRelativeTween() { }
        private System.Void .ctor() { }
        private System.Void <CreateTween>b__54_0() { }

    }

    // TypeToken: 0x2000005
    public class DOTweenAnimationExtensions
    {
        // Methods
        private System.Boolean IsSameOrSubclassOf(UnityEngine.Component t) { }

    }

    // TypeToken: 0x2000006
    public class DOTweenProShortcuts
    {
        // Methods
        private System.Void .cctor() { }
        private DG.Tweening.Tweener DOSpiral(UnityEngine.Transform target, System.Single duration, System.Nullable<UnityEngine.Vector3> axis, DG.Tweening.SpiralMode mode, System.Single speed, System.Single frequency, System.Single depth, System.Boolean snapping) { }

    }

}

