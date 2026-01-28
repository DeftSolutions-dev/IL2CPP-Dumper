// ========================================================
// Dumped by @desirepro
// Assembly: DOTween.Modules.dll
// Classes:  62
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000003
    public class Utils
    {
        // Methods
        private UnityEngine.Vector2 SwitchToRectTransform(UnityEngine.RectTransform from, UnityEngine.RectTransform to) { }

    }

    // TypeToken: 0x2000037
    public class WaitForCompletion : CustomYieldInstruction
    {
        // Fields
        private readonly DG.Tweening.Tween t;        // 0x10

        // Methods
        private System.Boolean get_keepWaiting() { }
        private System.Void .ctor(DG.Tweening.Tween tween) { }

    }

    // TypeToken: 0x2000038
    public class WaitForRewind : CustomYieldInstruction
    {
        // Fields
        private readonly DG.Tweening.Tween t;        // 0x10

        // Methods
        private System.Boolean get_keepWaiting() { }
        private System.Void .ctor(DG.Tweening.Tween tween) { }

    }

    // TypeToken: 0x2000039
    public class WaitForKill : CustomYieldInstruction
    {
        // Fields
        private readonly DG.Tweening.Tween t;        // 0x10

        // Methods
        private System.Boolean get_keepWaiting() { }
        private System.Void .ctor(DG.Tweening.Tween tween) { }

    }

    // TypeToken: 0x200003A
    public class WaitForElapsedLoops : CustomYieldInstruction
    {
        // Fields
        private readonly DG.Tweening.Tween t;        // 0x10
        private readonly System.Int32 elapsedLoops;        // 0x18

        // Methods
        private System.Boolean get_keepWaiting() { }
        private System.Void .ctor(DG.Tweening.Tween tween, System.Int32 elapsedLoops) { }

    }

    // TypeToken: 0x200003B
    public class WaitForPosition : CustomYieldInstruction
    {
        // Fields
        private readonly DG.Tweening.Tween t;        // 0x10
        private readonly System.Single position;        // 0x18

        // Methods
        private System.Boolean get_keepWaiting() { }
        private System.Void .ctor(DG.Tweening.Tween tween, System.Single position) { }

    }

    // TypeToken: 0x200003C
    public class WaitForStart : CustomYieldInstruction
    {
        // Fields
        private readonly DG.Tweening.Tween t;        // 0x10

        // Methods
        private System.Boolean get_keepWaiting() { }
        private System.Void .ctor(DG.Tweening.Tween tween) { }

    }

    // TypeToken: 0x200003E
    public class Physics
    {
        // Methods
        private System.Void SetOrientationOnPath(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, UnityEngine.Quaternion newRot, UnityEngine.Transform trans) { }
        private System.Boolean HasRigidbody2D(UnityEngine.Component target) { }
        private System.Boolean HasRigidbody(UnityEngine.Component target) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> CreateDOTweenPathTween(UnityEngine.MonoBehaviour target, System.Boolean tweenRigidbody, System.Boolean isLocal, DG.Tweening.Plugins.Core.PathCore.Path path, System.Single duration, DG.Tweening.PathMode pathMode) { }

    }

namespace DG.Tweening
{

    // TypeToken: 0x2000002
    public class DOTweenModuleUI
    {
        // Methods
        private DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> DOFade(UnityEngine.CanvasGroup target, System.Single endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.UI.Graphic target, UnityEngine.Color endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.UI.Graphic target, System.Single endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.UI.Image target, UnityEngine.Color endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.UI.Image target, System.Single endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> DOFillAmount(UnityEngine.UI.Image target, System.Single endValue, System.Single duration) { }
        private DG.Tweening.Sequence DOGradientColor(UnityEngine.UI.Image target, UnityEngine.Gradient gradient, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> DOFlexibleSize(UnityEngine.UI.LayoutElement target, UnityEngine.Vector2 endValue, System.Single duration, System.Boolean snapping) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> DOMinSize(UnityEngine.UI.LayoutElement target, UnityEngine.Vector2 endValue, System.Single duration, System.Boolean snapping) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> DOPreferredSize(UnityEngine.UI.LayoutElement target, UnityEngine.Vector2 endValue, System.Single duration, System.Boolean snapping) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.UI.Outline target, UnityEngine.Color endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.UI.Outline target, System.Single endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> DOScale(UnityEngine.UI.Outline target, UnityEngine.Vector2 endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, System.Single duration, System.Boolean snapping) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPosX(UnityEngine.RectTransform target, System.Single endValue, System.Single duration, System.Boolean snapping) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPosY(UnityEngine.RectTransform target, System.Single endValue, System.Single duration, System.Boolean snapping) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos3D(UnityEngine.RectTransform target, UnityEngine.Vector3 endValue, System.Single duration, System.Boolean snapping) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos3DX(UnityEngine.RectTransform target, System.Single endValue, System.Single duration, System.Boolean snapping) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos3DY(UnityEngine.RectTransform target, System.Single endValue, System.Single duration, System.Boolean snapping) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos3DZ(UnityEngine.RectTransform target, System.Single endValue, System.Single duration, System.Boolean snapping) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> DOAnchorMax(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, System.Single duration, System.Boolean snapping) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> DOAnchorMin(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, System.Single duration, System.Boolean snapping) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> DOPivot(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> DOPivotX(UnityEngine.RectTransform target, System.Single endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> DOPivotY(UnityEngine.RectTransform target, System.Single endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> DOSizeDelta(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, System.Single duration, System.Boolean snapping) { }
        private DG.Tweening.Tweener DOPunchAnchorPos(UnityEngine.RectTransform target, UnityEngine.Vector2 punch, System.Single duration, System.Int32 vibrato, System.Single elasticity, System.Boolean snapping) { }
        private DG.Tweening.Tweener DOShakeAnchorPos(UnityEngine.RectTransform target, System.Single duration, System.Single strength, System.Int32 vibrato, System.Single randomness, System.Boolean snapping, System.Boolean fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode) { }
        private DG.Tweening.Tweener DOShakeAnchorPos(UnityEngine.RectTransform target, System.Single duration, UnityEngine.Vector2 strength, System.Int32 vibrato, System.Single randomness, System.Boolean snapping, System.Boolean fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode) { }
        private DG.Tweening.Sequence DOJumpAnchorPos(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, System.Single jumpPower, System.Int32 numJumps, System.Single duration, System.Boolean snapping) { }
        private DG.Tweening.Tweener DONormalizedPos(UnityEngine.UI.ScrollRect target, UnityEngine.Vector2 endValue, System.Single duration, System.Boolean snapping) { }
        private DG.Tweening.Tweener DOHorizontalNormalizedPos(UnityEngine.UI.ScrollRect target, System.Single endValue, System.Single duration, System.Boolean snapping) { }
        private DG.Tweening.Tweener DOVerticalNormalizedPos(UnityEngine.UI.ScrollRect target, System.Single endValue, System.Single duration, System.Boolean snapping) { }
        private DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> DOValue(UnityEngine.UI.Slider target, System.Single endValue, System.Single duration, System.Boolean snapping) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.UI.Text target, UnityEngine.Color endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<System.Int32,System.Int32,DG.Tweening.Plugins.Options.NoOptions> DOCounter(UnityEngine.UI.Text target, System.Int32 fromValue, System.Int32 endValue, System.Single duration, System.Boolean addThousandsSeparator, System.Globalization.CultureInfo culture) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.UI.Text target, System.Single endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<System.String,System.String,DG.Tweening.Plugins.Options.StringOptions> DOText(UnityEngine.UI.Text target, System.String endValue, System.Single duration, System.Boolean richTextEnabled, DG.Tweening.ScrambleMode scrambleMode, System.String scrambleChars) { }
        private DG.Tweening.Tweener DOBlendableColor(UnityEngine.UI.Graphic target, UnityEngine.Color endValue, System.Single duration) { }
        private DG.Tweening.Tweener DOBlendableColor(UnityEngine.UI.Image target, UnityEngine.Color endValue, System.Single duration) { }
        private DG.Tweening.Tweener DOBlendableColor(UnityEngine.UI.Text target, UnityEngine.Color endValue, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions> DOShapeCircle(UnityEngine.RectTransform target, UnityEngine.Vector2 center, System.Single endValueDegrees, System.Single duration, System.Boolean relativeCenter, System.Boolean snapping) { }

    }

    // TypeToken: 0x200002D
    public class DOTweenModuleUnityVersion
    {
        // Methods
        private DG.Tweening.Sequence DOGradientColor(UnityEngine.Material target, UnityEngine.Gradient gradient, System.Single duration) { }
        private DG.Tweening.Sequence DOGradientColor(UnityEngine.Material target, UnityEngine.Gradient gradient, System.String property, System.Single duration) { }
        private UnityEngine.CustomYieldInstruction WaitForCompletion(DG.Tweening.Tween t, System.Boolean returnCustomYieldInstruction) { }
        private UnityEngine.CustomYieldInstruction WaitForRewind(DG.Tweening.Tween t, System.Boolean returnCustomYieldInstruction) { }
        private UnityEngine.CustomYieldInstruction WaitForKill(DG.Tweening.Tween t, System.Boolean returnCustomYieldInstruction) { }
        private UnityEngine.CustomYieldInstruction WaitForElapsedLoops(DG.Tweening.Tween t, System.Int32 elapsedLoops, System.Boolean returnCustomYieldInstruction) { }
        private UnityEngine.CustomYieldInstruction WaitForPosition(DG.Tweening.Tween t, System.Single position, System.Boolean returnCustomYieldInstruction) { }
        private UnityEngine.CustomYieldInstruction WaitForStart(DG.Tweening.Tween t, System.Boolean returnCustomYieldInstruction) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> DOOffset(UnityEngine.Material target, UnityEngine.Vector2 endValue, System.Int32 propertyID, System.Single duration) { }
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> DOTiling(UnityEngine.Material target, UnityEngine.Vector2 endValue, System.Int32 propertyID, System.Single duration) { }
        private System.Threading.Tasks.Task AsyncWaitForCompletion(DG.Tweening.Tween t) { }
        private System.Threading.Tasks.Task AsyncWaitForRewind(DG.Tweening.Tween t) { }
        private System.Threading.Tasks.Task AsyncWaitForKill(DG.Tweening.Tween t) { }
        private System.Threading.Tasks.Task AsyncWaitForElapsedLoops(DG.Tweening.Tween t, System.Int32 elapsedLoops) { }
        private System.Threading.Tasks.Task AsyncWaitForPosition(DG.Tweening.Tween t, System.Single position) { }
        private System.Threading.Tasks.Task AsyncWaitForStart(DG.Tweening.Tween t) { }

    }

    // TypeToken: 0x2000036
    public class DOTweenCYInstruction
    {
    }

    // TypeToken: 0x200003D
    public class DOTweenModuleUtils
    {
        // Fields
        private static System.Boolean _initialized;        // 0x0

        // Methods
        private System.Void Init() { }
        private System.Void Preserver() { }

    }

}

