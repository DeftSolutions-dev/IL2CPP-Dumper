// ========================================================
// Dumped by @desirepro
// Assembly: DOTweenPro.dll
// Classes:  13
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace DG.Tweening
{

    // TypeToken: 0x2000002
    public class DOTweenVisualManager : MonoBehaviour
    {
        // Fields
        public DG.Tweening.Core.VisualManagerPreset preset;        // 0x18
        public DG.Tweening.Core.OnEnableBehaviour onEnableBehaviour;        // 0x1C
        public DG.Tweening.Core.OnDisableBehaviour onDisableBehaviour;        // 0x20
        private System.Boolean _requiresRestartFromSpawnPoint;        // 0x24
        private DG.Tweening.Core.ABSAnimationComponent _animComponent;        // 0x28

        // Methods
        private System.Void Awake() { }
        private System.Void Update() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000003
    public struct HandlesDrawMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.HandlesDrawMode Orthographic;        // 0x0
        public static DG.Tweening.HandlesDrawMode Perspective;        // 0x0

    }

    // TypeToken: 0x2000004
    public struct HandlesType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.HandlesType Free;        // 0x0
        public static DG.Tweening.HandlesType Full;        // 0x0

    }

    // TypeToken: 0x2000005
    public struct DOTweenInspectorMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.DOTweenInspectorMode Default;        // 0x0
        public static DG.Tweening.DOTweenInspectorMode InfoAndWaypointsOnly;        // 0x0
        public static DG.Tweening.DOTweenInspectorMode Developer;        // 0x0
        public static DG.Tweening.DOTweenInspectorMode OnlyPath;        // 0x0

    }

    // TypeToken: 0x2000006
    public class DOTweenPath : ABSAnimationComponent
    {
        // Fields
        private static System.Action<DG.Tweening.DOTweenPath> OnReset;        // 0x0
        public System.Single delay;        // 0x68
        public System.Single duration;        // 0x6C
        public DG.Tweening.Ease easeType;        // 0x70
        public UnityEngine.AnimationCurve easeCurve;        // 0x78
        public System.Int32 loops;        // 0x80
        public System.String id;        // 0x88
        public DG.Tweening.LoopType loopType;        // 0x90
        public DG.Tweening.Plugins.Options.OrientType orientType;        // 0x94
        public UnityEngine.Transform lookAtTransform;        // 0x98
        public UnityEngine.Vector3 lookAtPosition;        // 0xA0
        public System.Single lookAhead;        // 0xAC
        public System.Boolean autoPlay;        // 0xB0
        public System.Boolean autoKill;        // 0xB1
        public System.Boolean relative;        // 0xB2
        public System.Boolean isLocal;        // 0xB3
        public System.Boolean isClosedPath;        // 0xB4
        public System.Int32 pathResolution;        // 0xB8
        public DG.Tweening.PathMode pathMode;        // 0xBC
        public DG.Tweening.AxisConstraint lockRotation;        // 0xC0
        public System.Boolean assignForwardAndUp;        // 0xC4
        public UnityEngine.Vector3 forwardDirection;        // 0xC8
        public UnityEngine.Vector3 upDirection;        // 0xD4
        public System.Boolean tweenRigidbody;        // 0xE0
        public System.Collections.Generic.List<UnityEngine.Vector3> wps;        // 0xE8
        public System.Collections.Generic.List<UnityEngine.Vector3> fullWps;        // 0xF0
        public DG.Tweening.Plugins.Core.PathCore.Path path;        // 0xF8
        public DG.Tweening.DOTweenInspectorMode inspectorMode;        // 0x100
        public DG.Tweening.PathType pathType;        // 0x104
        public DG.Tweening.HandlesType handlesType;        // 0x108
        public System.Boolean livePreview;        // 0x10C
        public DG.Tweening.HandlesDrawMode handlesDrawMode;        // 0x110
        public System.Single perspectiveHandleSize;        // 0x114
        public System.Boolean showIndexes;        // 0x118
        public System.Boolean showWpLength;        // 0x119
        public UnityEngine.Color pathColor;        // 0x11C
        public UnityEngine.Vector3 lastSrcPosition;        // 0x12C
        public UnityEngine.Quaternion lastSrcRotation;        // 0x138
        public System.Boolean wpsDropdown;        // 0x148
        public System.Single dropToFloorOffset;        // 0x14C
        private static System.Reflection.MethodInfo _miCreateTween;        // 0x8

        // Methods
        private System.Void add_OnReset(System.Action<DG.Tweening.DOTweenPath> value) { }
        private System.Void remove_OnReset(System.Action<DG.Tweening.DOTweenPath> value) { }
        private System.Void Dispatch_OnReset(DG.Tweening.DOTweenPath path) { }
        private System.Void Awake() { }
        private System.Void Reset() { }
        private System.Void OnDestroy() { }
        private System.Void DOPlay() { }
        private System.Void DOPlayById(System.String id) { }
        private System.Void DOPlayAllById(System.String id) { }
        private System.Void DOPlayBackwards() { }
        private System.Void DOPlayForward() { }
        private System.Void DOPause() { }
        private System.Void DOTogglePause() { }
        private System.Void DORewind() { }
        private System.Void DORestart() { }
        private System.Void DORestart(System.Boolean fromHere) { }
        private System.Void DOComplete() { }
        private System.Void DOKill() { }
        private System.Void DOKillAllById(System.String id) { }
        private DG.Tweening.Tween GetTween() { }
        private UnityEngine.Vector3[] GetDrawPoints() { }
        private UnityEngine.Vector3[] GetFullWps() { }
        private System.Void ReEvaluateRelativeTween() { }
        private System.Void .ctor() { }
        private System.Void <Awake>b__44_0() { }

    }

    // TypeToken: 0x2000007
    public struct SpiralMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.SpiralMode Expand;        // 0x0
        public static DG.Tweening.SpiralMode ExpandThenContract;        // 0x0

    }

}

namespace DG.Tweening.Core
{

    // TypeToken: 0x200000A
    public class ABSAnimationComponent : MonoBehaviour
    {
        // Fields
        public DG.Tweening.UpdateType updateType;        // 0x18
        public System.Boolean isSpeedBased;        // 0x1C
        public System.Boolean hasOnStart;        // 0x1D
        public System.Boolean hasOnPlay;        // 0x1E
        public System.Boolean hasOnUpdate;        // 0x1F
        public System.Boolean hasOnStepComplete;        // 0x20
        public System.Boolean hasOnComplete;        // 0x21
        public System.Boolean hasOnTweenCreated;        // 0x22
        public System.Boolean hasOnRewind;        // 0x23
        public UnityEngine.Events.UnityEvent onStart;        // 0x28
        public UnityEngine.Events.UnityEvent onPlay;        // 0x30
        public UnityEngine.Events.UnityEvent onUpdate;        // 0x38
        public UnityEngine.Events.UnityEvent onStepComplete;        // 0x40
        public UnityEngine.Events.UnityEvent onComplete;        // 0x48
        public UnityEngine.Events.UnityEvent onTweenCreated;        // 0x50
        public UnityEngine.Events.UnityEvent onRewind;        // 0x58
        public DG.Tweening.Tween tween;        // 0x60

        // Methods
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
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000B
    public struct OnDisableBehaviour
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.Core.OnDisableBehaviour None;        // 0x0
        public static DG.Tweening.Core.OnDisableBehaviour Pause;        // 0x0
        public static DG.Tweening.Core.OnDisableBehaviour Rewind;        // 0x0
        public static DG.Tweening.Core.OnDisableBehaviour Kill;        // 0x0
        public static DG.Tweening.Core.OnDisableBehaviour KillAndComplete;        // 0x0
        public static DG.Tweening.Core.OnDisableBehaviour DestroyGameObject;        // 0x0

    }

    // TypeToken: 0x200000C
    public struct OnEnableBehaviour
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.Core.OnEnableBehaviour None;        // 0x0
        public static DG.Tweening.Core.OnEnableBehaviour Play;        // 0x0
        public static DG.Tweening.Core.OnEnableBehaviour Restart;        // 0x0
        public static DG.Tweening.Core.OnEnableBehaviour RestartFromSpawnPoint;        // 0x0

    }

    // TypeToken: 0x200000D
    public struct VisualManagerPreset
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static DG.Tweening.Core.VisualManagerPreset Custom;        // 0x0
        public static DG.Tweening.Core.VisualManagerPreset PoolingSystem;        // 0x0

    }

}

namespace DG.Tweening.Plugins
{

    // TypeToken: 0x2000008
    public struct SpiralOptions, IPlugOptions
    {
        // Fields
        public System.Single depth;        // 0x10
        public System.Single frequency;        // 0x14
        public System.Single speed;        // 0x18
        public DG.Tweening.SpiralMode mode;        // 0x1C
        public System.Boolean snapping;        // 0x20
        private System.Single unit;        // 0x24
        private UnityEngine.Quaternion axisQ;        // 0x28

        // Methods
        private System.Void Reset() { }

    }

    // TypeToken: 0x2000009
    public class SpiralPlugin : ABSTweenPlugin`3
    {
        // Fields
        public static readonly UnityEngine.Vector3 DefaultDirection;        // 0x0

        // Methods
        private System.Void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.SpiralOptions> t) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.SpiralOptions> t, System.Boolean isRelative) { }
        private System.Void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.SpiralOptions> t, UnityEngine.Vector3 fromValue, System.Boolean setImmediately, System.Boolean isRelative) { }
        private DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.SpiralOptions> Get() { }
        private UnityEngine.Vector3 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.SpiralOptions> t, UnityEngine.Vector3 value) { }
        private System.Void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.SpiralOptions> t) { }
        private System.Void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.SpiralOptions> t) { }
        private System.Single GetSpeedBasedDuration(DG.Tweening.Plugins.SpiralOptions options, System.Single unitsXSecond, UnityEngine.Vector3 changeValue) { }
        private System.Void EvaluateAndApply(DG.Tweening.Plugins.SpiralOptions options, DG.Tweening.Tween t, System.Boolean isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, System.Single elapsed, UnityEngine.Vector3 startValue, UnityEngine.Vector3 changeValue, System.Single duration, System.Boolean usingInversePosition, System.Int32 newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

}

