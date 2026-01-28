// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.UI.dll
// Classes:  229
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000006
    public class ButtonClickedEvent : UnityEvent
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000012
    public interface IFactoryControls
    {
        // Methods
        private UnityEngine.GameObject CreateGameObject(System.String name, System.Type[] components) { }

    }

    // TypeToken: 0x2000013
    public class DefaultRuntimeFactory, IFactoryControls
    {
        // Fields
        public static UnityEngine.UI.DefaultControls.IFactoryControls Default;        // 0x0

        // Methods
        private UnityEngine.GameObject CreateGameObject(System.String name, System.Type[] components) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000014
    public struct Resources
    {
        // Fields
        public UnityEngine.Sprite standard;        // 0x10
        public UnityEngine.Sprite background;        // 0x18
        public UnityEngine.Sprite inputField;        // 0x20
        public UnityEngine.Sprite knob;        // 0x28
        public UnityEngine.Sprite checkmark;        // 0x30
        public UnityEngine.Sprite dropdown;        // 0x38
        public UnityEngine.Sprite mask;        // 0x40

    }

    // TypeToken: 0x2000016
    public class DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler
    {
        // Fields
        private UnityEngine.UI.Text m_Text;        // 0x18
        private UnityEngine.UI.Image m_Image;        // 0x20
        private UnityEngine.RectTransform m_RectTransform;        // 0x28
        private UnityEngine.UI.Toggle m_Toggle;        // 0x30

        // Methods
        private UnityEngine.UI.Text get_text() { }
        private System.Void set_text(UnityEngine.UI.Text value) { }
        private UnityEngine.UI.Image get_image() { }
        private System.Void set_image(UnityEngine.UI.Image value) { }
        private UnityEngine.RectTransform get_rectTransform() { }
        private System.Void set_rectTransform(UnityEngine.RectTransform value) { }
        private UnityEngine.UI.Toggle get_toggle() { }
        private System.Void set_toggle(UnityEngine.UI.Toggle value) { }
        private System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnCancel(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000017
    public class OptionData
    {
        // Fields
        private System.String m_Text;        // 0x10
        private UnityEngine.Sprite m_Image;        // 0x18

        // Methods
        private System.String get_text() { }
        private System.Void set_text(System.String value) { }
        private UnityEngine.Sprite get_image() { }
        private System.Void set_image(UnityEngine.Sprite value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String text) { }
        private System.Void .ctor(UnityEngine.Sprite image) { }
        private System.Void .ctor(System.String text, UnityEngine.Sprite image) { }

    }

    // TypeToken: 0x2000018
    public class OptionDataList
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> m_Options;        // 0x10

        // Methods
        private System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> get_options() { }
        private System.Void set_options(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000019
    public class DropdownEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000020
    public struct BlockingObjects
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.GraphicRaycaster.BlockingObjects None;        // 0x0
        public static UnityEngine.UI.GraphicRaycaster.BlockingObjects TwoD;        // 0x0
        public static UnityEngine.UI.GraphicRaycaster.BlockingObjects ThreeD;        // 0x0
        public static UnityEngine.UI.GraphicRaycaster.BlockingObjects All;        // 0x0

    }

    // TypeToken: 0x2000025
    public struct Type
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.Image.Type Simple;        // 0x0
        public static UnityEngine.UI.Image.Type Sliced;        // 0x0
        public static UnityEngine.UI.Image.Type Tiled;        // 0x0
        public static UnityEngine.UI.Image.Type Filled;        // 0x0
        public static UnityEngine.UI.Image.Type Mirror;        // 0x0
        public static UnityEngine.UI.Image.Type Quarter;        // 0x0

    }

    // TypeToken: 0x2000026
    public struct FillMethod
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.Image.FillMethod Horizontal;        // 0x0
        public static UnityEngine.UI.Image.FillMethod Vertical;        // 0x0
        public static UnityEngine.UI.Image.FillMethod Radial90;        // 0x0
        public static UnityEngine.UI.Image.FillMethod Radial180;        // 0x0
        public static UnityEngine.UI.Image.FillMethod Radial360;        // 0x0

    }

    // TypeToken: 0x2000027
    public struct OriginHorizontal
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.Image.OriginHorizontal Left;        // 0x0
        public static UnityEngine.UI.Image.OriginHorizontal Right;        // 0x0

    }

    // TypeToken: 0x2000028
    public struct OriginVertical
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.Image.OriginVertical Bottom;        // 0x0
        public static UnityEngine.UI.Image.OriginVertical Top;        // 0x0

    }

    // TypeToken: 0x2000029
    public struct Origin90
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.Image.Origin90 BottomLeft;        // 0x0
        public static UnityEngine.UI.Image.Origin90 TopLeft;        // 0x0
        public static UnityEngine.UI.Image.Origin90 TopRight;        // 0x0
        public static UnityEngine.UI.Image.Origin90 BottomRight;        // 0x0

    }

    // TypeToken: 0x200002A
    public struct Origin180
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.Image.Origin180 Bottom;        // 0x0
        public static UnityEngine.UI.Image.Origin180 Left;        // 0x0
        public static UnityEngine.UI.Image.Origin180 Top;        // 0x0
        public static UnityEngine.UI.Image.Origin180 Right;        // 0x0

    }

    // TypeToken: 0x200002B
    public struct Origin360
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.Image.Origin360 Bottom;        // 0x0
        public static UnityEngine.UI.Image.Origin360 Right;        // 0x0
        public static UnityEngine.UI.Image.Origin360 Top;        // 0x0
        public static UnityEngine.UI.Image.Origin360 Left;        // 0x0

    }

    // TypeToken: 0x200002C
    public struct SlicedSpriteParams
    {
        // Fields
        public System.Boolean slicedParamNeedUpdate;        // 0x10
        public UnityEngine.Vector2 inner_PosMin;        // 0x14
        public UnityEngine.Vector2 inner_PosMax;        // 0x1C
        public UnityEngine.Vector2 inner_UVMin;        // 0x24
        public UnityEngine.Vector2 inner_UVMax;        // 0x2C

        // Methods
        private System.Void .ctor(System.Boolean slicedParamNeedUpdate, UnityEngine.Vector2 inner_PosMin, UnityEngine.Vector2 inner_PosMax, UnityEngine.Vector2 inner_UVMin, UnityEngine.Vector2 inner_UVMax) { }

    }

    // TypeToken: 0x200002D
    public struct EDynamicAtlasActiveMode
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static UnityEngine.UI.Image.EDynamicAtlasActiveMode ActiveOnAwake;        // 0x0
        public static UnityEngine.UI.Image.EDynamicAtlasActiveMode ActiveOnEnable;        // 0x0

    }

    // TypeToken: 0x2000031
    public struct ContentType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.InputField.ContentType Standard;        // 0x0
        public static UnityEngine.UI.InputField.ContentType Autocorrected;        // 0x0
        public static UnityEngine.UI.InputField.ContentType IntegerNumber;        // 0x0
        public static UnityEngine.UI.InputField.ContentType DecimalNumber;        // 0x0
        public static UnityEngine.UI.InputField.ContentType Alphanumeric;        // 0x0
        public static UnityEngine.UI.InputField.ContentType Name;        // 0x0
        public static UnityEngine.UI.InputField.ContentType EmailAddress;        // 0x0
        public static UnityEngine.UI.InputField.ContentType Password;        // 0x0
        public static UnityEngine.UI.InputField.ContentType Pin;        // 0x0
        public static UnityEngine.UI.InputField.ContentType Custom;        // 0x0

    }

    // TypeToken: 0x2000032
    public struct InputType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.InputField.InputType Standard;        // 0x0
        public static UnityEngine.UI.InputField.InputType AutoCorrect;        // 0x0
        public static UnityEngine.UI.InputField.InputType Password;        // 0x0

    }

    // TypeToken: 0x2000033
    public struct CharacterValidation
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.InputField.CharacterValidation None;        // 0x0
        public static UnityEngine.UI.InputField.CharacterValidation Integer;        // 0x0
        public static UnityEngine.UI.InputField.CharacterValidation Decimal;        // 0x0
        public static UnityEngine.UI.InputField.CharacterValidation Alphanumeric;        // 0x0
        public static UnityEngine.UI.InputField.CharacterValidation Name;        // 0x0
        public static UnityEngine.UI.InputField.CharacterValidation EmailAddress;        // 0x0

    }

    // TypeToken: 0x2000034
    public struct LineType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.InputField.LineType SingleLine;        // 0x0
        public static UnityEngine.UI.InputField.LineType MultiLineSubmit;        // 0x0
        public static UnityEngine.UI.InputField.LineType MultiLineNewline;        // 0x0

    }

    // TypeToken: 0x2000035
    public class OnValidateInput : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Char Invoke(System.String text, System.Int32 charIndex, System.Char addedChar) { }
        private System.IAsyncResult BeginInvoke(System.String text, System.Int32 charIndex, System.Char addedChar, System.AsyncCallback callback, System.Object object) { }
        private System.Char EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000036
    public class SubmitEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000037
    public class EndEditEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000038
    public class OnChangeEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000039
    public struct EditState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.InputField.EditState Continue;        // 0x0
        public static UnityEngine.UI.InputField.EditState Finish;        // 0x0

    }

    // TypeToken: 0x200003D
    public struct AspectMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.AspectRatioFitter.AspectMode None;        // 0x0
        public static UnityEngine.UI.AspectRatioFitter.AspectMode WidthControlsHeight;        // 0x0
        public static UnityEngine.UI.AspectRatioFitter.AspectMode HeightControlsWidth;        // 0x0
        public static UnityEngine.UI.AspectRatioFitter.AspectMode FitInParent;        // 0x0
        public static UnityEngine.UI.AspectRatioFitter.AspectMode EnvelopeParent;        // 0x0

    }

    // TypeToken: 0x200003F
    public struct ScaleMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.CanvasScaler.ScaleMode ConstantPixelSize;        // 0x0
        public static UnityEngine.UI.CanvasScaler.ScaleMode ScaleWithScreenSize;        // 0x0
        public static UnityEngine.UI.CanvasScaler.ScaleMode ConstantPhysicalSize;        // 0x0

    }

    // TypeToken: 0x2000040
    public struct ScreenMatchMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.CanvasScaler.ScreenMatchMode MatchWidthOrHeight;        // 0x0
        public static UnityEngine.UI.CanvasScaler.ScreenMatchMode Expand;        // 0x0
        public static UnityEngine.UI.CanvasScaler.ScreenMatchMode Shrink;        // 0x0

    }

    // TypeToken: 0x2000041
    public struct Unit
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.CanvasScaler.Unit Centimeters;        // 0x0
        public static UnityEngine.UI.CanvasScaler.Unit Millimeters;        // 0x0
        public static UnityEngine.UI.CanvasScaler.Unit Inches;        // 0x0
        public static UnityEngine.UI.CanvasScaler.Unit Points;        // 0x0
        public static UnityEngine.UI.CanvasScaler.Unit Picas;        // 0x0

    }

    // TypeToken: 0x2000043
    public struct FitMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.ContentSizeFitter.FitMode Unconstrained;        // 0x0
        public static UnityEngine.UI.ContentSizeFitter.FitMode MinSize;        // 0x0
        public static UnityEngine.UI.ContentSizeFitter.FitMode PreferredSize;        // 0x0

    }

    // TypeToken: 0x2000045
    public struct Corner
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.GridLayoutGroup.Corner UpperLeft;        // 0x0
        public static UnityEngine.UI.GridLayoutGroup.Corner UpperRight;        // 0x0
        public static UnityEngine.UI.GridLayoutGroup.Corner LowerLeft;        // 0x0
        public static UnityEngine.UI.GridLayoutGroup.Corner LowerRight;        // 0x0

    }

    // TypeToken: 0x2000046
    public struct Axis
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.GridLayoutGroup.Axis Horizontal;        // 0x0
        public static UnityEngine.UI.GridLayoutGroup.Axis Vertical;        // 0x0

    }

    // TypeToken: 0x2000047
    public struct Constraint
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.GridLayoutGroup.Constraint Flexible;        // 0x0
        public static UnityEngine.UI.GridLayoutGroup.Constraint FixedColumnCount;        // 0x0
        public static UnityEngine.UI.GridLayoutGroup.Constraint FixedRowCount;        // 0x0

    }

    // TypeToken: 0x2000059
    public class CullStateChangedEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005F
    public struct Mode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.Navigation.Mode None;        // 0x0
        public static UnityEngine.UI.Navigation.Mode Horizontal;        // 0x0
        public static UnityEngine.UI.Navigation.Mode Vertical;        // 0x0
        public static UnityEngine.UI.Navigation.Mode Automatic;        // 0x0
        public static UnityEngine.UI.Navigation.Mode Explicit;        // 0x0

    }

    // TypeToken: 0x2000063
    public struct Direction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.Scrollbar.Direction LeftToRight;        // 0x0
        public static UnityEngine.UI.Scrollbar.Direction RightToLeft;        // 0x0
        public static UnityEngine.UI.Scrollbar.Direction BottomToTop;        // 0x0
        public static UnityEngine.UI.Scrollbar.Direction TopToBottom;        // 0x0

    }

    // TypeToken: 0x2000064
    public class ScrollEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000065
    public struct Axis
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.Scrollbar.Axis Horizontal;        // 0x0
        public static UnityEngine.UI.Scrollbar.Axis Vertical;        // 0x0

    }

    // TypeToken: 0x2000068
    public struct MovementType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.ScrollRect.MovementType Unrestricted;        // 0x0
        public static UnityEngine.UI.ScrollRect.MovementType Elastic;        // 0x0
        public static UnityEngine.UI.ScrollRect.MovementType Clamped;        // 0x0

    }

    // TypeToken: 0x2000069
    public struct ScrollbarVisibility
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.ScrollRect.ScrollbarVisibility Permanent;        // 0x0
        public static UnityEngine.UI.ScrollRect.ScrollbarVisibility AutoHide;        // 0x0
        public static UnityEngine.UI.ScrollRect.ScrollbarVisibility AutoHideAndExpandViewport;        // 0x0

    }

    // TypeToken: 0x200006A
    public class ScrollRectEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006C
    public struct Transition
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.Selectable.Transition None;        // 0x0
        public static UnityEngine.UI.Selectable.Transition ColorTint;        // 0x0
        public static UnityEngine.UI.Selectable.Transition SpriteSwap;        // 0x0
        public static UnityEngine.UI.Selectable.Transition Animation;        // 0x0

    }

    // TypeToken: 0x200006D
    public struct SelectionState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.Selectable.SelectionState Normal;        // 0x0
        public static UnityEngine.UI.Selectable.SelectionState Highlighted;        // 0x0
        public static UnityEngine.UI.Selectable.SelectionState Pressed;        // 0x0
        public static UnityEngine.UI.Selectable.SelectionState Selected;        // 0x0
        public static UnityEngine.UI.Selectable.SelectionState Disabled;        // 0x0

    }

    // TypeToken: 0x2000074
    public struct Direction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.Slider.Direction LeftToRight;        // 0x0
        public static UnityEngine.UI.Slider.Direction RightToLeft;        // 0x0
        public static UnityEngine.UI.Slider.Direction BottomToTop;        // 0x0
        public static UnityEngine.UI.Slider.Direction TopToBottom;        // 0x0

    }

    // TypeToken: 0x2000075
    public class SliderEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000076
    public struct Axis
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.Slider.Axis Horizontal;        // 0x0
        public static UnityEngine.UI.Slider.Axis Vertical;        // 0x0

    }

    // TypeToken: 0x2000079
    public class MatEntry
    {
        // Fields
        public UnityEngine.Material baseMat;        // 0x10
        public UnityEngine.Material customMat;        // 0x18
        public System.Int32 count;        // 0x20
        public System.Int32 stencilId;        // 0x24
        public UnityEngine.Rendering.StencilOp operation;        // 0x28
        public UnityEngine.Rendering.CompareFunction compareFunction;        // 0x2C
        public System.Int32 readMask;        // 0x30
        public System.Int32 writeMask;        // 0x34
        public System.Boolean useAlphaClip;        // 0x38
        public UnityEngine.Rendering.ColorWriteMask colorMask;        // 0x3C

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007C
    public struct ToggleTransition
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.Toggle.ToggleTransition None;        // 0x0
        public static UnityEngine.UI.Toggle.ToggleTransition Fade;        // 0x0

    }

    // TypeToken: 0x200007D
    public class ToggleEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000081
    public class Raycast3DCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(UnityEngine.Ray r, UnityEngine.RaycastHit& hit, System.Single f, System.Int32 i) { }
        private System.IAsyncResult BeginInvoke(UnityEngine.Ray r, UnityEngine.RaycastHit& hit, System.Single f, System.Int32 i, System.AsyncCallback callback, System.Object object) { }
        private System.Boolean EndInvoke(UnityEngine.RaycastHit& hit, System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000082
    public class RaycastAllCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private UnityEngine.RaycastHit[] Invoke(UnityEngine.Ray r, System.Single f, System.Int32 i) { }
        private System.IAsyncResult BeginInvoke(UnityEngine.Ray r, System.Single f, System.Int32 i, System.AsyncCallback callback, System.Object object) { }
        private UnityEngine.RaycastHit[] EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000083
    public class GetRaycastNonAllocCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Int32 Invoke(UnityEngine.Ray r, UnityEngine.RaycastHit[] results, System.Single f, System.Int32 i) { }
        private System.IAsyncResult BeginInvoke(UnityEngine.Ray r, UnityEngine.RaycastHit[] results, System.Single f, System.Int32 i, System.AsyncCallback callback, System.Object object) { }
        private System.Int32 EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000084
    public class Raycast2DCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private UnityEngine.RaycastHit2D Invoke(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, System.Single f, System.Int32 i) { }
        private System.IAsyncResult BeginInvoke(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, System.Single f, System.Int32 i, System.AsyncCallback callback, System.Object object) { }
        private UnityEngine.RaycastHit2D EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000085
    public class GetRayIntersectionAllCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private UnityEngine.RaycastHit2D[] Invoke(UnityEngine.Ray r, System.Single f, System.Int32 i) { }
        private System.IAsyncResult BeginInvoke(UnityEngine.Ray r, System.Single f, System.Int32 i, System.AsyncCallback callback, System.Object object) { }
        private UnityEngine.RaycastHit2D[] EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000086
    public class GetRayIntersectionAllNonAllocCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Int32 Invoke(UnityEngine.Ray r, UnityEngine.RaycastHit2D[] results, System.Single f, System.Int32 i) { }
        private System.IAsyncResult BeginInvoke(UnityEngine.Ray r, UnityEngine.RaycastHit2D[] results, System.Single f, System.Int32 i, System.AsyncCallback callback, System.Object object) { }
        private System.Int32 EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000092
    public struct ColorTweenMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode All;        // 0x0
        public static UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode RGB;        // 0x0
        public static UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode Alpha;        // 0x0

    }

    // TypeToken: 0x2000093
    public class ColorTweenCallback : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000095
    public class FloatTweenCallback : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000099
    public struct PointerEventType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.PanelEventHandler.PointerEventType Default;        // 0x0
        public static UnityEngine.UIElements.PanelEventHandler.PointerEventType Down;        // 0x0
        public static UnityEngine.UIElements.PanelEventHandler.PointerEventType Up;        // 0x0

    }

    // TypeToken: 0x200009A
    public class PointerEvent, IPointerEvent
    {
        // Fields
        private System.Int32 <pointerId>k__BackingField;        // 0x10
        private System.String <pointerType>k__BackingField;        // 0x18
        private System.Boolean <isPrimary>k__BackingField;        // 0x20
        private System.Int32 <button>k__BackingField;        // 0x24
        private System.Int32 <pressedButtons>k__BackingField;        // 0x28
        private UnityEngine.Vector3 <position>k__BackingField;        // 0x2C
        private UnityEngine.Vector3 <localPosition>k__BackingField;        // 0x38
        private UnityEngine.Vector3 <deltaPosition>k__BackingField;        // 0x44
        private System.Single <deltaTime>k__BackingField;        // 0x50
        private System.Int32 <clickCount>k__BackingField;        // 0x54
        private System.Single <pressure>k__BackingField;        // 0x58
        private System.Single <tangentialPressure>k__BackingField;        // 0x5C
        private System.Single <altitudeAngle>k__BackingField;        // 0x60
        private System.Single <azimuthAngle>k__BackingField;        // 0x64
        private System.Single <twist>k__BackingField;        // 0x68
        private UnityEngine.Vector2 <radius>k__BackingField;        // 0x6C
        private UnityEngine.Vector2 <radiusVariance>k__BackingField;        // 0x74
        private UnityEngine.EventModifiers <modifiers>k__BackingField;        // 0x7C

        // Methods
        private System.Int32 get_pointerId() { }
        private System.Void set_pointerId(System.Int32 value) { }
        private System.String get_pointerType() { }
        private System.Void set_pointerType(System.String value) { }
        private System.Boolean get_isPrimary() { }
        private System.Void set_isPrimary(System.Boolean value) { }
        private System.Int32 get_button() { }
        private System.Void set_button(System.Int32 value) { }
        private System.Int32 get_pressedButtons() { }
        private System.Void set_pressedButtons(System.Int32 value) { }
        private UnityEngine.Vector3 get_position() { }
        private System.Void set_position(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_localPosition() { }
        private System.Void set_localPosition(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_deltaPosition() { }
        private System.Void set_deltaPosition(UnityEngine.Vector3 value) { }
        private System.Single get_deltaTime() { }
        private System.Void set_deltaTime(System.Single value) { }
        private System.Int32 get_clickCount() { }
        private System.Void set_clickCount(System.Int32 value) { }
        private System.Single get_pressure() { }
        private System.Void set_pressure(System.Single value) { }
        private System.Single get_tangentialPressure() { }
        private System.Void set_tangentialPressure(System.Single value) { }
        private System.Single get_altitudeAngle() { }
        private System.Void set_altitudeAngle(System.Single value) { }
        private System.Single get_azimuthAngle() { }
        private System.Void set_azimuthAngle(System.Single value) { }
        private System.Single get_twist() { }
        private System.Void set_twist(System.Single value) { }
        private UnityEngine.Vector2 get_radius() { }
        private System.Void set_radius(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 get_radiusVariance() { }
        private System.Void set_radiusVariance(UnityEngine.Vector2 value) { }
        private UnityEngine.EventModifiers get_modifiers() { }
        private System.Void set_modifiers(UnityEngine.EventModifiers value) { }
        private System.Boolean get_shiftKey() { }
        private System.Boolean get_ctrlKey() { }
        private System.Boolean get_commandKey() { }
        private System.Boolean get_altKey() { }
        private System.Boolean get_actionKey() { }
        private System.Void Read(UnityEngine.UIElements.PanelEventHandler self, UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.UIElements.PanelEventHandler.PointerEventType eventType) { }
        private System.Void SetPosition(UnityEngine.Vector3 positionOverride, UnityEngine.Vector3 deltaOverride) { }
        private System.Void .ctor() { }
        private System.Boolean <Read>g__InRange|82_0(System.Int32 i, System.Int32 start, System.Int32 count) { }

    }

    // TypeToken: 0x200009C
    public struct FloatIntBits
    {
        // Fields
        public System.Single f;        // 0x10
        public System.Int32 i;        // 0x10

    }

    // TypeToken: 0x20000A1
    public struct InputButton
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.EventSystems.PointerEventData.InputButton Left;        // 0x0
        public static UnityEngine.EventSystems.PointerEventData.InputButton Right;        // 0x0
        public static UnityEngine.EventSystems.PointerEventData.InputButton Middle;        // 0x0

    }

    // TypeToken: 0x20000A2
    public struct FramePressState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.EventSystems.PointerEventData.FramePressState Pressed;        // 0x0
        public static UnityEngine.EventSystems.PointerEventData.FramePressState Released;        // 0x0
        public static UnityEngine.EventSystems.PointerEventData.FramePressState PressedAndReleased;        // 0x0
        public static UnityEngine.EventSystems.PointerEventData.FramePressState NotChanged;        // 0x0

    }

    // TypeToken: 0x20000B8
    public class ProfilerMarkers
    {
        // Fields
        public static readonly Unity.Profiling.ProfilerMarker Update;        // 0x0
        public static readonly Unity.Profiling.ProfilerMarker TickModules;        // 0x8
        public static readonly Unity.Profiling.ProfilerMarker CurrentModuleProcess;        // 0x10
        public static readonly Unity.Profiling.ProfilerMarker RaycastAll;        // 0x18
        public static readonly Unity.Profiling.ProfilerMarker RaycastAllSort;        // 0x20

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000B9
    public struct UIToolkitOverrideConfig
    {
        // Fields
        public UnityEngine.EventSystems.EventSystem activeEventSystem;        // 0x10
        public System.Boolean sendEvents;        // 0x18
        public System.Boolean createPanelGameObjectsOnStart;        // 0x19

    }

    // TypeToken: 0x20000BC
    public class TriggerEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BD
    public class Entry
    {
        // Fields
        public UnityEngine.EventSystems.EventTriggerType eventID;        // 0x10
        public UnityEngine.EventSystems.EventTrigger.TriggerEvent callback;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C0
    public class EventFunction`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T1 handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.IAsyncResult BeginInvoke(T1 handler, UnityEngine.EventSystems.BaseEventData eventData, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20000C4
    public class ButtonState
    {
        // Fields
        private UnityEngine.EventSystems.PointerEventData.InputButton m_Button;        // 0x10
        private UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData m_EventData;        // 0x18

        // Methods
        private UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData get_eventData() { }
        private System.Void set_eventData(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData value) { }
        private UnityEngine.EventSystems.PointerEventData.InputButton get_button() { }
        private System.Void set_button(UnityEngine.EventSystems.PointerEventData.InputButton value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C5
    public class MouseState
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.EventSystems.PointerInputModule.ButtonState> m_TrackedButtons;        // 0x10

        // Methods
        private System.Boolean AnyPressesThisFrame() { }
        private System.Boolean AnyReleasesThisFrame() { }
        private UnityEngine.EventSystems.PointerInputModule.ButtonState GetButtonState(UnityEngine.EventSystems.PointerEventData.InputButton button) { }
        private System.Void SetButtonState(UnityEngine.EventSystems.PointerEventData.InputButton button, UnityEngine.EventSystems.PointerEventData.FramePressState stateForMouseButton, UnityEngine.EventSystems.PointerEventData data) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C6
    public class MouseButtonEventData
    {
        // Fields
        public UnityEngine.EventSystems.PointerEventData.FramePressState buttonState;        // 0x10
        public UnityEngine.EventSystems.PointerEventData buttonData;        // 0x18

        // Methods
        private System.Boolean PressedThisFrame() { }
        private System.Boolean ReleasedThisFrame() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C8
    public class ProfilerMarkers
    {
        // Fields
        public static readonly Unity.Profiling.ProfilerMarker Process;        // 0x0
        public static readonly Unity.Profiling.ProfilerMarker ProcessMouseEvent;        // 0x8
        public static readonly Unity.Profiling.ProfilerMarker ProcessMousePress;        // 0x10
        public static readonly Unity.Profiling.ProfilerMarker ProcessTouchEvents;        // 0x18
        public static readonly Unity.Profiling.ProfilerMarker ProcessTouchPress;        // 0x20

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000C9
    public struct InputMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.EventSystems.StandaloneInputModule.InputMode Mouse;        // 0x0
        public static UnityEngine.EventSystems.StandaloneInputModule.InputMode Buttons;        // 0x0

    }

    // TypeToken: 0x20000CB
    public class ProfilerMarkers
    {
        // Fields
        public static readonly Unity.Profiling.ProfilerMarker Process;        // 0x0
        public static readonly Unity.Profiling.ProfilerMarker ProcessTouchEvents;        // 0x8
        public static readonly Unity.Profiling.ProfilerMarker ProcessTouchPress;        // 0x10

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000D1
    public class RaycastHitComparer, IComparer`1
    {
        // Fields
        public static UnityEngine.EventSystems.PhysicsRaycaster.RaycastHitComparer instance;        // 0x0

        // Methods
        private System.Int32 Compare(UnityEngine.RaycastHit x, UnityEngine.RaycastHit y) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000D7
    public struct AutoScope, IDisposable
    {
        // Methods
        private System.Void .ctor(Unity.Profiling.ProfilerMarker<TP1> marker, TP1 p1) { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x20000D9
    public struct AutoScope, IDisposable
    {
        // Methods
        private System.Void .ctor(Unity.Profiling.ProfilerMarker<TP1,TP2> marker, TP1 p1, TP2 p2) { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x20000DB
    public struct AutoScope, IDisposable
    {
        // Methods
        private System.Void .ctor(Unity.Profiling.ProfilerMarker<TP1,TP2,TP3> marker, TP1 p1, TP2 p2, TP3 p3) { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x20000DD
    public struct ProfilerMarkerScope, IDisposable
    {
        // Methods
        private System.Void .ctor(Unity.Profiling.ProfilerMarker& marker) { }
        private System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, System.Int32 context) { }
        private System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, System.Int64 context) { }
        private System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, System.Single context) { }
        private System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, System.String context) { }
        private System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, System.String context, System.String context2) { }
        private System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, System.Int64 context, System.String context2) { }
        private System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, UnityEngine.Object obj) { }
        private System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, UnityEngine.Transform transform, System.Boolean path) { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x20000E5
    public struct __StaticArrayInitTypeSize=12
    {
    }

namespace Microsoft.CodeAnalysis
{

    // TypeToken: 0x2000002
    public class EmbeddedAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace System.Runtime.CompilerServices
{

    // TypeToken: 0x2000003
    public class IsUnmanagedAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace Unity.Profiling
{

    // TypeToken: 0x20000D4
    public struct ProfilerCounter`1
    {
        // Methods
        private System.Void .ctor(Unity.Profiling.ProfilerCategory category, System.String name, Unity.Profiling.ProfilerMarkerDataUnit dataUnit) { }
        private System.Void Sample(T value) { }

    }

    // TypeToken: 0x20000D5
    public struct ProfilerCounterValue`1
    {
        // Methods
        private System.Void .ctor(System.String name) { }
        private System.Void .ctor(System.String name, Unity.Profiling.ProfilerMarkerDataUnit dataUnit) { }
        private System.Void .ctor(System.String name, Unity.Profiling.ProfilerMarkerDataUnit dataUnit, Unity.Profiling.ProfilerCounterOptions counterOptions) { }
        private System.Void .ctor(Unity.Profiling.ProfilerCategory category, System.String name, Unity.Profiling.ProfilerMarkerDataUnit dataUnit) { }
        private System.Void .ctor(Unity.Profiling.ProfilerCategory category, System.String name, Unity.Profiling.ProfilerMarkerDataUnit dataUnit, Unity.Profiling.ProfilerCounterOptions counterOptions) { }
        private T get_Value() { }
        private System.Void set_Value(T value) { }
        private System.Void Sample() { }

    }

    // TypeToken: 0x20000D6
    public struct ProfilerMarker`1
    {
        // Methods
        private System.Void .ctor(System.String name, System.String param1Name) { }
        private System.Void .ctor(Unity.Profiling.ProfilerCategory category, System.String name, System.String param1Name) { }
        private System.Void Begin(TP1 p1) { }
        private System.Void End() { }
        private Unity.Profiling.ProfilerMarker.AutoScope<TP1> Auto(TP1 p1) { }

    }

    // TypeToken: 0x20000D8
    public struct ProfilerMarker`2
    {
        // Methods
        private System.Void .ctor(System.String name, System.String param1Name, System.String param2Name) { }
        private System.Void .ctor(Unity.Profiling.ProfilerCategory category, System.String name, System.String param1Name, System.String param2Name) { }
        private System.Void Begin(TP1 p1, TP2 p2) { }
        private System.Void End() { }
        private Unity.Profiling.ProfilerMarker.AutoScope<TP1,TP2> Auto(TP1 p1, TP2 p2) { }

    }

    // TypeToken: 0x20000DA
    public struct ProfilerMarker`3
    {
        // Methods
        private System.Void .ctor(System.String name, System.String param1Name, System.String param2Name, System.String param3Name) { }
        private System.Void .ctor(Unity.Profiling.ProfilerCategory category, System.String name, System.String param1Name, System.String param2Name, System.String param3Name) { }
        private System.Void Begin(TP1 p1, TP2 p2, TP3 p3) { }
        private System.Void End() { }
        private Unity.Profiling.ProfilerMarker.AutoScope<TP1,TP2,TP3> Auto(TP1 p1, TP2 p2, TP3 p3) { }

    }

    // TypeToken: 0x20000DC
    public class ProfilerMarkerExtension
    {
        // Methods
        private System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.Int32 metadata) { }
        private System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.UInt32 metadata) { }
        private System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.Int64 metadata) { }
        private System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.UInt64 metadata) { }
        private System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.Single metadata) { }
        private System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.Double metadata) { }
        private System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.String metadata) { }
        private System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.String metadata, System.String metadata2) { }
        private System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.Int64 metadata, System.String metadata2) { }
        private Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker) { }
        private Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker, System.Int32 context) { }
        private Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker, System.Int64 context) { }
        private Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker, System.Single context) { }
        private Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker, System.String context) { }
        private Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker, System.String context, System.String context2) { }
        private Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker, System.Int64 context, System.String context2) { }
        private Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker, UnityEngine.Transform transform, System.Boolean path) { }

    }

    // TypeToken: 0x20000DE
    public struct MonoObject_64
    {
        // Fields
        public System.Void* p1;        // 0x10
        public System.Void* p2;        // 0x18

    }

    // TypeToken: 0x20000DF
    public struct MonoObject_32
    {
        // Fields
        public System.Void* p1;        // 0x10
        public System.Void* p2;        // 0x14

    }

    // TypeToken: 0x20000E0
    public struct MonoString_64
    {
        // Fields
        public Unity.Profiling.MonoObject_64 obj;        // 0x10
        public System.Int32 length;        // 0x20
        public System.Char firstChar;        // 0x24

    }

    // TypeToken: 0x20000E1
    public struct MonoString_32
    {
        // Fields
        public Unity.Profiling.MonoObject_32 obj;        // 0x10
        public System.Int32 length;        // 0x18
        public System.Char firstChar;        // 0x1C

    }

    // TypeToken: 0x20000E2
    public class ProfilerString, IDisposable
    {
        // Fields
        private static System.Int32 MAX;        // 0x0
        private System.String m_buffer;        // 0x10
        private System.Int32 m_length;        // 0x18
        private System.Int32* m_strCount;        // 0x20
        private System.UInt64 m_handler;        // 0x28

        // Methods
        private System.Void .ctor(System.Int32 count) { }
        private System.Void Dispose() { }
        private System.String ToString() { }
        private System.String op_Implicit(Unity.Profiling.ProfilerString handle) { }
        private System.Void Append(System.String value) { }

    }

    // TypeToken: 0x20000E3
    public struct ProfilerUtility
    {
        // Methods
        private System.Byte GetProfilerMarkerDataType() { }

    }

}

namespace UnityEngine.EventSystems
{

    // TypeToken: 0x200009D
    public class AxisEventData : BaseEventData
    {
        // Fields
        private UnityEngine.Vector2 <moveVector>k__BackingField;        // 0x20
        private UnityEngine.EventSystems.MoveDirection <moveDir>k__BackingField;        // 0x28

        // Methods
        private UnityEngine.Vector2 get_moveVector() { }
        private System.Void set_moveVector(UnityEngine.Vector2 value) { }
        private UnityEngine.EventSystems.MoveDirection get_moveDir() { }
        private System.Void set_moveDir(UnityEngine.EventSystems.MoveDirection value) { }
        private System.Void .ctor(UnityEngine.EventSystems.EventSystem eventSystem) { }

    }

    // TypeToken: 0x200009E
    public class AbstractEventData
    {
        // Fields
        protected System.Boolean m_Used;        // 0x10

        // Methods
        private System.Void Reset() { }
        private System.Void Use() { }
        private System.Boolean get_used() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009F
    public class BaseEventData : AbstractEventData
    {
        // Fields
        private readonly UnityEngine.EventSystems.EventSystem m_EventSystem;        // 0x18

        // Methods
        private System.Void .ctor(UnityEngine.EventSystems.EventSystem eventSystem) { }
        private UnityEngine.EventSystems.BaseInputModule get_currentInputModule() { }
        private UnityEngine.GameObject get_selectedObject() { }
        private System.Void set_selectedObject(UnityEngine.GameObject value) { }

    }

    // TypeToken: 0x20000A0
    public class PointerEventData : BaseEventData
    {
        // Fields
        private UnityEngine.GameObject <pointerEnter>k__BackingField;        // 0x20
        private UnityEngine.GameObject m_PointerPress;        // 0x28
        private UnityEngine.GameObject <lastPress>k__BackingField;        // 0x30
        private UnityEngine.GameObject <rawPointerPress>k__BackingField;        // 0x38
        private UnityEngine.GameObject <pointerDrag>k__BackingField;        // 0x40
        private UnityEngine.GameObject <pointerClick>k__BackingField;        // 0x48
        private UnityEngine.EventSystems.RaycastResult <pointerCurrentRaycast>k__BackingField;        // 0x50
        private UnityEngine.EventSystems.RaycastResult <pointerPressRaycast>k__BackingField;        // 0x98
        public System.Collections.Generic.List<UnityEngine.GameObject> hovered;        // 0xE0
        private System.Boolean <eligibleForClick>k__BackingField;        // 0xE8
        private System.Int32 <pointerId>k__BackingField;        // 0xEC
        private UnityEngine.Vector2 <position>k__BackingField;        // 0xF0
        private UnityEngine.Vector2 <delta>k__BackingField;        // 0xF8
        private UnityEngine.Vector2 <pressPosition>k__BackingField;        // 0x100
        private UnityEngine.Vector3 <worldPosition>k__BackingField;        // 0x108
        private UnityEngine.Vector3 <worldNormal>k__BackingField;        // 0x114
        private System.Single <clickTime>k__BackingField;        // 0x120
        private System.Int32 <clickCount>k__BackingField;        // 0x124
        private UnityEngine.Vector2 <scrollDelta>k__BackingField;        // 0x128
        private System.Boolean <useDragThreshold>k__BackingField;        // 0x130
        private System.Boolean <dragging>k__BackingField;        // 0x131
        private UnityEngine.EventSystems.PointerEventData.InputButton <button>k__BackingField;        // 0x134
        private System.Single <pressure>k__BackingField;        // 0x138
        private System.Single <tangentialPressure>k__BackingField;        // 0x13C
        private System.Single <altitudeAngle>k__BackingField;        // 0x140
        private System.Single <azimuthAngle>k__BackingField;        // 0x144
        private System.Single <twist>k__BackingField;        // 0x148
        private UnityEngine.Vector2 <radius>k__BackingField;        // 0x14C
        private UnityEngine.Vector2 <radiusVariance>k__BackingField;        // 0x154
        private System.Boolean <fullyExited>k__BackingField;        // 0x15C
        private System.Boolean <reentered>k__BackingField;        // 0x15D

        // Methods
        private UnityEngine.GameObject get_pointerEnter() { }
        private System.Void set_pointerEnter(UnityEngine.GameObject value) { }
        private UnityEngine.GameObject get_lastPress() { }
        private System.Void set_lastPress(UnityEngine.GameObject value) { }
        private UnityEngine.GameObject get_rawPointerPress() { }
        private System.Void set_rawPointerPress(UnityEngine.GameObject value) { }
        private UnityEngine.GameObject get_pointerDrag() { }
        private System.Void set_pointerDrag(UnityEngine.GameObject value) { }
        private UnityEngine.GameObject get_pointerClick() { }
        private System.Void set_pointerClick(UnityEngine.GameObject value) { }
        private UnityEngine.EventSystems.RaycastResult get_pointerCurrentRaycast() { }
        private System.Void set_pointerCurrentRaycast(UnityEngine.EventSystems.RaycastResult value) { }
        private UnityEngine.EventSystems.RaycastResult get_pointerPressRaycast() { }
        private System.Void set_pointerPressRaycast(UnityEngine.EventSystems.RaycastResult value) { }
        private System.Boolean get_eligibleForClick() { }
        private System.Void set_eligibleForClick(System.Boolean value) { }
        private System.Int32 get_pointerId() { }
        private System.Void set_pointerId(System.Int32 value) { }
        private UnityEngine.Vector2 get_position() { }
        private System.Void set_position(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 get_delta() { }
        private System.Void set_delta(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 get_pressPosition() { }
        private System.Void set_pressPosition(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector3 get_worldPosition() { }
        private System.Void set_worldPosition(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_worldNormal() { }
        private System.Void set_worldNormal(UnityEngine.Vector3 value) { }
        private System.Single get_clickTime() { }
        private System.Void set_clickTime(System.Single value) { }
        private System.Int32 get_clickCount() { }
        private System.Void set_clickCount(System.Int32 value) { }
        private UnityEngine.Vector2 get_scrollDelta() { }
        private System.Void set_scrollDelta(UnityEngine.Vector2 value) { }
        private System.Boolean get_useDragThreshold() { }
        private System.Void set_useDragThreshold(System.Boolean value) { }
        private System.Boolean get_dragging() { }
        private System.Void set_dragging(System.Boolean value) { }
        private UnityEngine.EventSystems.PointerEventData.InputButton get_button() { }
        private System.Void set_button(UnityEngine.EventSystems.PointerEventData.InputButton value) { }
        private System.Single get_pressure() { }
        private System.Void set_pressure(System.Single value) { }
        private System.Single get_tangentialPressure() { }
        private System.Void set_tangentialPressure(System.Single value) { }
        private System.Single get_altitudeAngle() { }
        private System.Void set_altitudeAngle(System.Single value) { }
        private System.Single get_azimuthAngle() { }
        private System.Void set_azimuthAngle(System.Single value) { }
        private System.Single get_twist() { }
        private System.Void set_twist(System.Single value) { }
        private UnityEngine.Vector2 get_radius() { }
        private System.Void set_radius(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 get_radiusVariance() { }
        private System.Void set_radiusVariance(UnityEngine.Vector2 value) { }
        private System.Boolean get_fullyExited() { }
        private System.Void set_fullyExited(System.Boolean value) { }
        private System.Boolean get_reentered() { }
        private System.Void set_reentered(System.Boolean value) { }
        private System.Void .ctor(UnityEngine.EventSystems.EventSystem eventSystem) { }
        private System.Boolean IsPointerMoving() { }
        private System.Boolean IsScrolling() { }
        private UnityEngine.Camera get_enterEventCamera() { }
        private UnityEngine.Camera get_pressEventCamera() { }
        private UnityEngine.GameObject get_pointerPress() { }
        private System.Void set_pointerPress(UnityEngine.GameObject value) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x20000A3
    public struct EventHandle
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.EventSystems.EventHandle Unused;        // 0x0
        public static UnityEngine.EventSystems.EventHandle Used;        // 0x0

    }

    // TypeToken: 0x20000A4
    public interface IEventSystemHandler
    {
    }

    // TypeToken: 0x20000A5
    public interface IPointerMoveHandler : IEventSystemHandler
    {
        // Methods
        private System.Void OnPointerMove(UnityEngine.EventSystems.PointerEventData eventData) { }

    }

    // TypeToken: 0x20000A6
    public interface IPointerEnterHandler : IEventSystemHandler
    {
        // Methods
        private System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData) { }

    }

    // TypeToken: 0x20000A7
    public interface IPointerExitHandler : IEventSystemHandler
    {
        // Methods
        private System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData) { }

    }

    // TypeToken: 0x20000A8
    public interface IPointerDownHandler : IEventSystemHandler
    {
        // Methods
        private System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }

    }

    // TypeToken: 0x20000A9
    public interface IPointerUpHandler : IEventSystemHandler
    {
        // Methods
        private System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }

    }

    // TypeToken: 0x20000AA
    public interface IPointerClickHandler : IEventSystemHandler
    {
        // Methods
        private System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }

    }

    // TypeToken: 0x20000AB
    public interface IBeginDragHandler : IEventSystemHandler
    {
        // Methods
        private System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }

    }

    // TypeToken: 0x20000AC
    public interface IInitializePotentialDragHandler : IEventSystemHandler
    {
        // Methods
        private System.Void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData) { }

    }

    // TypeToken: 0x20000AD
    public interface IDragHandler : IEventSystemHandler
    {
        // Methods
        private System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }

    }

    // TypeToken: 0x20000AE
    public interface IEndDragHandler : IEventSystemHandler
    {
        // Methods
        private System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }

    }

    // TypeToken: 0x20000AF
    public interface IDropHandler : IEventSystemHandler
    {
        // Methods
        private System.Void OnDrop(UnityEngine.EventSystems.PointerEventData eventData) { }

    }

    // TypeToken: 0x20000B0
    public interface IScrollHandler : IEventSystemHandler
    {
        // Methods
        private System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData) { }

    }

    // TypeToken: 0x20000B1
    public interface IUpdateSelectedHandler : IEventSystemHandler
    {
        // Methods
        private System.Void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData) { }

    }

    // TypeToken: 0x20000B2
    public interface ISelectHandler : IEventSystemHandler
    {
        // Methods
        private System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData) { }

    }

    // TypeToken: 0x20000B3
    public interface IDeselectHandler : IEventSystemHandler
    {
        // Methods
        private System.Void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData) { }

    }

    // TypeToken: 0x20000B4
    public interface IMoveHandler : IEventSystemHandler
    {
        // Methods
        private System.Void OnMove(UnityEngine.EventSystems.AxisEventData eventData) { }

    }

    // TypeToken: 0x20000B5
    public interface ISubmitHandler : IEventSystemHandler
    {
        // Methods
        private System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData) { }

    }

    // TypeToken: 0x20000B6
    public interface ICancelHandler : IEventSystemHandler
    {
        // Methods
        private System.Void OnCancel(UnityEngine.EventSystems.BaseEventData eventData) { }

    }

    // TypeToken: 0x20000B7
    public class EventSystem : UIBehaviour
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.EventSystems.BaseInputModule> m_SystemInputModules;        // 0x18
        private UnityEngine.EventSystems.BaseInputModule m_CurrentInputModule;        // 0x20
        private static System.Collections.Generic.List<UnityEngine.EventSystems.EventSystem> m_EventSystems;        // 0x0
        private UnityEngine.GameObject m_FirstSelected;        // 0x28
        private System.Boolean m_sendNavigationEvents;        // 0x30
        private System.Int32 m_DragThreshold;        // 0x34
        private UnityEngine.GameObject m_CurrentSelected;        // 0x38
        private System.Boolean m_HasFocus;        // 0x40
        private System.Boolean m_SelectionGuard;        // 0x41
        private UnityEngine.EventSystems.BaseEventData m_DummyData;        // 0x48
        private static readonly System.Comparison<UnityEngine.EventSystems.RaycastResult> s_RaycastComparer;        // 0x8
        private static UnityEngine.EventSystems.EventSystem.UIToolkitOverrideConfig s_UIToolkitOverride;        // 0x10

        // Methods
        private UnityEngine.EventSystems.EventSystem get_current() { }
        private System.Void set_current(UnityEngine.EventSystems.EventSystem value) { }
        private System.Boolean get_sendNavigationEvents() { }
        private System.Void set_sendNavigationEvents(System.Boolean value) { }
        private System.Int32 get_pixelDragThreshold() { }
        private System.Void set_pixelDragThreshold(System.Int32 value) { }
        private UnityEngine.EventSystems.BaseInputModule get_currentInputModule() { }
        private UnityEngine.GameObject get_firstSelectedGameObject() { }
        private System.Void set_firstSelectedGameObject(UnityEngine.GameObject value) { }
        private UnityEngine.GameObject get_currentSelectedGameObject() { }
        private UnityEngine.GameObject get_lastSelectedGameObject() { }
        private System.Boolean get_isFocused() { }
        private System.Void .ctor() { }
        private System.Void UpdateModules() { }
        private System.Boolean get_alreadySelecting() { }
        private System.Void SetSelectedGameObject(UnityEngine.GameObject selected, UnityEngine.EventSystems.BaseEventData pointer) { }
        private UnityEngine.EventSystems.BaseEventData get_baseEventDataCache() { }
        private System.Void SetSelectedGameObject(UnityEngine.GameObject selected) { }
        private System.Int32 RaycastComparer(UnityEngine.EventSystems.RaycastResult lhs, UnityEngine.EventSystems.RaycastResult rhs) { }
        private System.Void RaycastAll(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> raycastResults) { }
        private System.Boolean IsPointerOverGameObject() { }
        private System.Boolean IsPointerOverGameObject(System.Int32 pointerId) { }
        private System.Boolean get_isUIToolkitActiveEventSystem() { }
        private System.Boolean get_sendUIToolkitEvents() { }
        private System.Boolean get_createUIToolkitPanelGameObjectsOnStart() { }
        private System.Void SetUITookitEventSystemOverride(UnityEngine.EventSystems.EventSystem activeEventSystem, System.Boolean sendEvents, System.Boolean createPanelGameObjectsOnStart) { }
        private System.Void CreateUIToolkitPanelGameObject(UnityEngine.UIElements.BaseRuntimePanel panel) { }
        private System.Void Start() { }
        private System.Void OnDestroy() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void TickModules() { }
        private System.Void OnApplicationFocus(System.Boolean hasFocus) { }
        private System.Void Update() { }
        private System.Void ChangeEventModule(UnityEngine.EventSystems.BaseInputModule module) { }
        private System.String ToString() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000BB
    public class EventTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> m_Delegates;        // 0x18

        // Methods
        private System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> get_delegates() { }
        private System.Void set_delegates(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> value) { }
        private System.Void .ctor() { }
        private System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> get_triggers() { }
        private System.Void set_triggers(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> value) { }
        private System.Void Execute(UnityEngine.EventSystems.EventTriggerType id, UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnDrop(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnMove(UnityEngine.EventSystems.AxisEventData eventData) { }
        private System.Void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void OnCancel(UnityEngine.EventSystems.BaseEventData eventData) { }

    }

    // TypeToken: 0x20000BE
    public struct EventTriggerType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.EventSystems.EventTriggerType PointerEnter;        // 0x0
        public static UnityEngine.EventSystems.EventTriggerType PointerExit;        // 0x0
        public static UnityEngine.EventSystems.EventTriggerType PointerDown;        // 0x0
        public static UnityEngine.EventSystems.EventTriggerType PointerUp;        // 0x0
        public static UnityEngine.EventSystems.EventTriggerType PointerClick;        // 0x0
        public static UnityEngine.EventSystems.EventTriggerType Drag;        // 0x0
        public static UnityEngine.EventSystems.EventTriggerType Drop;        // 0x0
        public static UnityEngine.EventSystems.EventTriggerType Scroll;        // 0x0
        public static UnityEngine.EventSystems.EventTriggerType UpdateSelected;        // 0x0
        public static UnityEngine.EventSystems.EventTriggerType Select;        // 0x0
        public static UnityEngine.EventSystems.EventTriggerType Deselect;        // 0x0
        public static UnityEngine.EventSystems.EventTriggerType Move;        // 0x0
        public static UnityEngine.EventSystems.EventTriggerType InitializePotentialDrag;        // 0x0
        public static UnityEngine.EventSystems.EventTriggerType BeginDrag;        // 0x0
        public static UnityEngine.EventSystems.EventTriggerType EndDrag;        // 0x0
        public static UnityEngine.EventSystems.EventTriggerType Submit;        // 0x0
        public static UnityEngine.EventSystems.EventTriggerType Cancel;        // 0x0

    }

    // TypeToken: 0x20000BF
    public class ExecuteEvents
    {
        // Fields
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerMoveHandler> s_PointerMoveHandler;        // 0x0
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler> s_PointerEnterHandler;        // 0x8
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler> s_PointerExitHandler;        // 0x10
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler> s_PointerDownHandler;        // 0x18
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler> s_PointerUpHandler;        // 0x20
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler> s_PointerClickHandler;        // 0x28
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler> s_InitializePotentialDragHandler;        // 0x30
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler> s_BeginDragHandler;        // 0x38
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler> s_DragHandler;        // 0x40
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler> s_EndDragHandler;        // 0x48
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler> s_DropHandler;        // 0x50
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler> s_ScrollHandler;        // 0x58
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler> s_UpdateSelectedHandler;        // 0x60
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler> s_SelectHandler;        // 0x68
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler> s_DeselectHandler;        // 0x70
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler> s_MoveHandler;        // 0x78
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler> s_SubmitHandler;        // 0x80
        private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler> s_CancelHandler;        // 0x88
        private static readonly System.Collections.Generic.List<UnityEngine.Transform> s_InternalTransformList;        // 0x90

        // Methods
        private T ValidateEventData(UnityEngine.EventSystems.BaseEventData data) { }
        private System.Void Execute(UnityEngine.EventSystems.IPointerMoveHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void Execute(UnityEngine.EventSystems.IPointerEnterHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void Execute(UnityEngine.EventSystems.IPointerExitHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void Execute(UnityEngine.EventSystems.IPointerDownHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void Execute(UnityEngine.EventSystems.IPointerUpHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void Execute(UnityEngine.EventSystems.IPointerClickHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void Execute(UnityEngine.EventSystems.IInitializePotentialDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void Execute(UnityEngine.EventSystems.IBeginDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void Execute(UnityEngine.EventSystems.IDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void Execute(UnityEngine.EventSystems.IEndDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void Execute(UnityEngine.EventSystems.IDropHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void Execute(UnityEngine.EventSystems.IScrollHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void Execute(UnityEngine.EventSystems.IUpdateSelectedHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void Execute(UnityEngine.EventSystems.ISelectHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void Execute(UnityEngine.EventSystems.IDeselectHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void Execute(UnityEngine.EventSystems.IMoveHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void Execute(UnityEngine.EventSystems.ISubmitHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void Execute(UnityEngine.EventSystems.ICancelHandler handler, UnityEngine.EventSystems.BaseEventData eventData) { }
        private UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerMoveHandler> get_pointerMoveHandler() { }
        private UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler> get_pointerEnterHandler() { }
        private UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler> get_pointerExitHandler() { }
        private UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler> get_pointerDownHandler() { }
        private UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler> get_pointerUpHandler() { }
        private UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler> get_pointerClickHandler() { }
        private UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler> get_initializePotentialDrag() { }
        private UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler> get_beginDragHandler() { }
        private UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler> get_dragHandler() { }
        private UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler> get_endDragHandler() { }
        private UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler> get_dropHandler() { }
        private UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler> get_scrollHandler() { }
        private UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler> get_updateSelectedHandler() { }
        private UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler> get_selectHandler() { }
        private UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler> get_deselectHandler() { }
        private UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler> get_moveHandler() { }
        private UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler> get_submitHandler() { }
        private UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler> get_cancelHandler() { }
        private System.Void GetEventChain(UnityEngine.GameObject root, System.Collections.Generic.IList<UnityEngine.Transform> eventChain) { }
        private System.Boolean Execute(UnityEngine.GameObject target, UnityEngine.EventSystems.BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> functor) { }
        private UnityEngine.GameObject ExecuteHierarchy(UnityEngine.GameObject root, UnityEngine.EventSystems.BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> callbackFunction) { }
        private System.Boolean ShouldSendToComponent(UnityEngine.Component component) { }
        private System.Void GetEventList(UnityEngine.GameObject go, System.Collections.Generic.IList<UnityEngine.EventSystems.IEventSystemHandler> results) { }
        private System.Boolean CanHandleEvent(UnityEngine.GameObject go) { }
        private UnityEngine.GameObject GetEventHandler(UnityEngine.GameObject root) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000C1
    public class BaseInput : UIBehaviour
    {
        // Methods
        private System.String get_compositionString() { }
        private UnityEngine.IMECompositionMode get_imeCompositionMode() { }
        private System.Void set_imeCompositionMode(UnityEngine.IMECompositionMode value) { }
        private UnityEngine.Vector2 get_compositionCursorPos() { }
        private System.Void set_compositionCursorPos(UnityEngine.Vector2 value) { }
        private System.Boolean get_mousePresent() { }
        private System.Boolean GetMouseButtonDown(System.Int32 button) { }
        private System.Boolean GetMouseButtonUp(System.Int32 button) { }
        private System.Boolean GetMouseButton(System.Int32 button) { }
        private UnityEngine.Vector2 get_mousePosition() { }
        private UnityEngine.Vector2 get_mouseScrollDelta() { }
        private System.Boolean get_touchSupported() { }
        private System.Int32 get_touchCount() { }
        private UnityEngine.Touch GetTouch(System.Int32 index) { }
        private System.Single GetAxisRaw(System.String axisName) { }
        private System.Boolean GetButtonDown(System.String buttonName) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C2
    public class BaseInputModule : UIBehaviour
    {
        // Fields
        protected System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> m_RaycastResultCache;        // 0x18
        private UnityEngine.EventSystems.AxisEventData m_AxisEventData;        // 0x20
        private UnityEngine.EventSystems.EventSystem m_EventSystem;        // 0x28
        private UnityEngine.EventSystems.BaseEventData m_BaseEventData;        // 0x30
        protected UnityEngine.EventSystems.BaseInput m_InputOverride;        // 0x38
        private UnityEngine.EventSystems.BaseInput m_DefaultInput;        // 0x40

        // Methods
        private UnityEngine.EventSystems.BaseInput get_input() { }
        private UnityEngine.EventSystems.BaseInput get_inputOverride() { }
        private System.Void set_inputOverride(UnityEngine.EventSystems.BaseInput value) { }
        private UnityEngine.EventSystems.EventSystem get_eventSystem() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Process() { }
        private UnityEngine.EventSystems.RaycastResult FindFirstRaycast(System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> candidates) { }
        private UnityEngine.EventSystems.MoveDirection DetermineMoveDirection(System.Single x, System.Single y) { }
        private UnityEngine.EventSystems.MoveDirection DetermineMoveDirection(System.Single x, System.Single y, System.Single deadZone) { }
        private UnityEngine.GameObject FindCommonRoot(UnityEngine.GameObject g1, UnityEngine.GameObject g2) { }
        private System.Void HandlePointerExitAndEnter(UnityEngine.EventSystems.PointerEventData currentPointerData, UnityEngine.GameObject newEnterTarget) { }
        private UnityEngine.EventSystems.AxisEventData GetAxisEventData(System.Single x, System.Single y, System.Single moveDeadZone) { }
        private UnityEngine.EventSystems.BaseEventData GetBaseEventData() { }
        private System.Boolean IsPointerOverGameObject(System.Int32 pointerId) { }
        private System.Boolean ShouldActivateModule() { }
        private System.Void DeactivateModule() { }
        private System.Void ActivateModule() { }
        private System.Void UpdateModule() { }
        private System.Boolean IsModuleSupported() { }
        private System.Int32 ConvertUIToolkitPointerId(UnityEngine.EventSystems.PointerEventData sourcePointerData) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C3
    public class PointerInputModule : BaseInputModule
    {
        // Fields
        public static System.Int32 kMouseLeftId;        // 0x0
        public static System.Int32 kMouseRightId;        // 0x0
        public static System.Int32 kMouseMiddleId;        // 0x0
        public static System.Int32 kFakeTouchesId;        // 0x0
        protected System.Collections.Generic.Dictionary<System.Int32,UnityEngine.EventSystems.PointerEventData> m_PointerData;        // 0x48
        private readonly UnityEngine.EventSystems.PointerInputModule.MouseState m_MouseState;        // 0x50

        // Methods
        private System.Boolean GetPointerData(System.Int32 id, UnityEngine.EventSystems.PointerEventData& data, System.Boolean create) { }
        private System.Void RemovePointerData(UnityEngine.EventSystems.PointerEventData data) { }
        private UnityEngine.EventSystems.PointerEventData GetTouchPointerEventData(UnityEngine.Touch input, System.Boolean& pressed, System.Boolean& released) { }
        private System.Void CopyFromTo(UnityEngine.EventSystems.PointerEventData from, UnityEngine.EventSystems.PointerEventData to) { }
        private UnityEngine.EventSystems.PointerEventData.FramePressState StateForMouseButton(System.Int32 buttonId) { }
        private UnityEngine.EventSystems.PointerInputModule.MouseState GetMousePointerEventData() { }
        private UnityEngine.EventSystems.PointerInputModule.MouseState GetMousePointerEventData(System.Int32 id) { }
        private UnityEngine.EventSystems.PointerEventData GetLastPointerEventData(System.Int32 id) { }
        private System.Boolean ShouldStartDrag(UnityEngine.Vector2 pressPos, UnityEngine.Vector2 currentPos, System.Single threshold, System.Boolean useDragThreshold) { }
        private System.Void ProcessMove(UnityEngine.EventSystems.PointerEventData pointerEvent) { }
        private System.Void ProcessDrag(UnityEngine.EventSystems.PointerEventData pointerEvent) { }
        private System.Boolean IsPointerOverGameObject(System.Int32 pointerId) { }
        private System.Void ClearSelection() { }
        private System.String ToString() { }
        private System.Void DeselectIfSelectionChanged(UnityEngine.GameObject currentOverGo, UnityEngine.EventSystems.BaseEventData pointerEvent) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C7
    public class StandaloneInputModule : PointerInputModule
    {
        // Fields
        private System.Single m_PrevActionTime;        // 0x58
        private UnityEngine.Vector2 m_LastMoveVector;        // 0x5C
        private System.Int32 m_ConsecutiveMoveCount;        // 0x64
        private UnityEngine.Vector2 m_LastMousePosition;        // 0x68
        private UnityEngine.Vector2 m_MousePosition;        // 0x70
        private UnityEngine.GameObject m_CurrentFocusedGameObject;        // 0x78
        private UnityEngine.EventSystems.PointerEventData m_InputPointerEvent;        // 0x80
        private System.String m_HorizontalAxis;        // 0x88
        private System.String m_VerticalAxis;        // 0x90
        private System.String m_SubmitButton;        // 0x98
        private System.String m_CancelButton;        // 0xA0
        private System.Single m_InputActionsPerSecond;        // 0xA8
        private System.Single m_RepeatDelay;        // 0xAC
        private System.Boolean m_ForceModuleActive;        // 0xB0

        // Methods
        private System.Void .ctor() { }
        private UnityEngine.EventSystems.StandaloneInputModule.InputMode get_inputMode() { }
        private System.Boolean get_allowActivationOnMobileDevice() { }
        private System.Void set_allowActivationOnMobileDevice(System.Boolean value) { }
        private System.Boolean get_forceModuleActive() { }
        private System.Void set_forceModuleActive(System.Boolean value) { }
        private System.Single get_inputActionsPerSecond() { }
        private System.Void set_inputActionsPerSecond(System.Single value) { }
        private System.Single get_repeatDelay() { }
        private System.Void set_repeatDelay(System.Single value) { }
        private System.String get_horizontalAxis() { }
        private System.Void set_horizontalAxis(System.String value) { }
        private System.String get_verticalAxis() { }
        private System.Void set_verticalAxis(System.String value) { }
        private System.String get_submitButton() { }
        private System.Void set_submitButton(System.String value) { }
        private System.String get_cancelButton() { }
        private System.Void set_cancelButton(System.String value) { }
        private System.Boolean ShouldIgnoreEventsOnNoFocus() { }
        private System.Void UpdateModule() { }
        private System.Void ReleaseMouse(UnityEngine.EventSystems.PointerEventData pointerEvent, UnityEngine.GameObject currentOverGo) { }
        private System.Boolean ShouldActivateModule() { }
        private System.Void ActivateModule() { }
        private System.Void DeactivateModule() { }
        private System.Void Process() { }
        private System.Boolean ProcessTouchEvents() { }
        private System.Void ProcessTouchPress(UnityEngine.EventSystems.PointerEventData pointerEvent, System.Boolean pressed, System.Boolean released) { }
        private System.Boolean SendSubmitEventToSelectedObject() { }
        private UnityEngine.Vector2 GetRawMoveVector() { }
        private System.Boolean SendMoveEventToSelectedObject() { }
        private System.Void ProcessMouseEvent() { }
        private System.Boolean ForceAutoSelect() { }
        private System.Void ProcessMouseEvent(System.Int32 id) { }
        private System.Boolean SendUpdateEventToSelectedObject() { }
        private System.Void ProcessMousePress(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData data) { }
        private UnityEngine.GameObject GetCurrentFocusedGameObject() { }

    }

    // TypeToken: 0x20000CA
    public class TouchInputModule : PointerInputModule
    {
        // Fields
        private UnityEngine.Vector2 m_LastMousePosition;        // 0x58
        private UnityEngine.Vector2 m_MousePosition;        // 0x60
        private UnityEngine.EventSystems.PointerEventData m_InputPointerEvent;        // 0x68
        private System.Boolean m_ForceModuleActive;        // 0x70

        // Methods
        private System.Void .ctor() { }
        private System.Boolean get_allowActivationOnStandalone() { }
        private System.Void set_allowActivationOnStandalone(System.Boolean value) { }
        private System.Boolean get_forceModuleActive() { }
        private System.Void set_forceModuleActive(System.Boolean value) { }
        private System.Void UpdateModule() { }
        private System.Boolean IsModuleSupported() { }
        private System.Boolean ShouldActivateModule() { }
        private System.Boolean UseFakeInput() { }
        private System.Void Process() { }
        private System.Void FakeTouches() { }
        private System.Void ProcessTouchEvents() { }
        private System.Void ProcessTouchPress(UnityEngine.EventSystems.PointerEventData pointerEvent, System.Boolean pressed, System.Boolean released) { }
        private System.Void DeactivateModule() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x20000CC
    public struct MoveDirection
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.EventSystems.MoveDirection Left;        // 0x0
        public static UnityEngine.EventSystems.MoveDirection Up;        // 0x0
        public static UnityEngine.EventSystems.MoveDirection Right;        // 0x0
        public static UnityEngine.EventSystems.MoveDirection Down;        // 0x0
        public static UnityEngine.EventSystems.MoveDirection None;        // 0x0

    }

    // TypeToken: 0x20000CD
    public class RaycasterManager
    {
        // Fields
        private static readonly System.Collections.Generic.List<UnityEngine.EventSystems.BaseRaycaster> s_Raycasters;        // 0x0

        // Methods
        private System.Void AddRaycaster(UnityEngine.EventSystems.BaseRaycaster baseRaycaster) { }
        private System.Collections.Generic.List<UnityEngine.EventSystems.BaseRaycaster> GetRaycasters() { }
        private System.Void RemoveRaycasters(UnityEngine.EventSystems.BaseRaycaster baseRaycaster) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000CE
    public class BaseRaycaster : UIBehaviour
    {
        // Fields
        private UnityEngine.EventSystems.BaseRaycaster m_RootRaycaster;        // 0x18

        // Methods
        private System.Void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }
        private UnityEngine.Camera get_eventCamera() { }
        private System.Int32 get_priority() { }
        private System.Int32 get_sortOrderPriority() { }
        private System.Int32 get_renderOrderPriority() { }
        private UnityEngine.EventSystems.BaseRaycaster get_rootRaycaster() { }
        private System.String ToString() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnCanvasHierarchyChanged() { }
        private System.Void OnTransformParentChanged() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CF
    public class Physics2DRaycaster : PhysicsRaycaster
    {
        // Fields
        private UnityEngine.RaycastHit2D[] m_Hits;        // 0x40

        // Methods
        private System.Void .ctor() { }
        private System.Void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

    }

    // TypeToken: 0x20000D0
    public class PhysicsRaycaster : BaseRaycaster
    {
        // Fields
        protected static System.Int32 kNoEventMaskSet;        // 0x0
        protected UnityEngine.Camera m_EventCamera;        // 0x20
        protected UnityEngine.LayerMask m_EventMask;        // 0x28
        protected System.Int32 m_MaxRayIntersections;        // 0x2C
        protected System.Int32 m_LastMaxRayIntersections;        // 0x30
        private UnityEngine.RaycastHit[] m_Hits;        // 0x38

        // Methods
        private System.Void .ctor() { }
        private UnityEngine.Camera get_eventCamera() { }
        private System.Int32 get_depth() { }
        private System.Int32 get_finalEventMask() { }
        private UnityEngine.LayerMask get_eventMask() { }
        private System.Void set_eventMask(UnityEngine.LayerMask value) { }
        private System.Int32 get_maxRayIntersections() { }
        private System.Void set_maxRayIntersections(System.Int32 value) { }
        private System.Boolean ComputeRayAndDistance(UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.Ray& ray, System.Int32& eventDisplayIndex, System.Single& distanceToClipPlane) { }
        private System.Void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

    }

    // TypeToken: 0x20000D2
    public struct RaycastResult
    {
        // Fields
        private UnityEngine.GameObject m_GameObject;        // 0x10
        public UnityEngine.EventSystems.BaseRaycaster module;        // 0x18
        public System.Single distance;        // 0x20
        public System.Single index;        // 0x24
        public System.Int32 depth;        // 0x28
        public System.Int32 sortingLayer;        // 0x2C
        public System.Int32 sortingOrder;        // 0x30
        public UnityEngine.Vector3 worldPosition;        // 0x34
        public UnityEngine.Vector3 worldNormal;        // 0x40
        public UnityEngine.Vector2 screenPosition;        // 0x4C
        public System.Int32 displayIndex;        // 0x54

        // Methods
        private UnityEngine.GameObject get_gameObject() { }
        private System.Void set_gameObject(UnityEngine.GameObject value) { }
        private System.Boolean get_isValid() { }
        private System.Void Clear() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x20000D3
    public class UIBehaviour : MonoBehaviour
    {
        // Methods
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void Start() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Boolean IsActive() { }
        private System.Void OnRectTransformDimensionsChange() { }
        private System.Void OnBeforeTransformParentChanged() { }
        private System.Void OnTransformParentChanged() { }
        private System.Void OnDidApplyAnimationProperties() { }
        private System.Void OnCanvasHierarchyChanged() { }
        private System.Boolean IsDestroyed() { }
        private System.Void .ctor() { }

    }

}

namespace UnityEngine.UI
{

    // TypeToken: 0x2000004
    public class AnimationTriggers
    {
        // Fields
        private static System.String kDefaultNormalAnimName;        // 0x0
        private static System.String kDefaultHighlightedAnimName;        // 0x0
        private static System.String kDefaultPressedAnimName;        // 0x0
        private static System.String kDefaultSelectedAnimName;        // 0x0
        private static System.String kDefaultDisabledAnimName;        // 0x0
        private System.String m_NormalTrigger;        // 0x10
        private System.String m_HighlightedTrigger;        // 0x18
        private System.String m_PressedTrigger;        // 0x20
        private System.String m_SelectedTrigger;        // 0x28
        private System.String m_DisabledTrigger;        // 0x30

        // Methods
        private System.String get_normalTrigger() { }
        private System.Void set_normalTrigger(System.String value) { }
        private System.String get_highlightedTrigger() { }
        private System.Void set_highlightedTrigger(System.String value) { }
        private System.String get_pressedTrigger() { }
        private System.Void set_pressedTrigger(System.String value) { }
        private System.String get_selectedTrigger() { }
        private System.Void set_selectedTrigger(System.String value) { }
        private System.String get_disabledTrigger() { }
        private System.Void set_disabledTrigger(System.String value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000005
    public class Button : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler
    {
        // Fields
        private UnityEngine.UI.Button.ButtonClickedEvent m_OnClick;        // 0x180

        // Methods
        private System.Void .ctor() { }
        private UnityEngine.UI.Button.ButtonClickedEvent get_onClick() { }
        private System.Void set_onClick(UnityEngine.UI.Button.ButtonClickedEvent value) { }
        private System.Void Press() { }
        private System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Collections.IEnumerator OnFinishSubmit() { }

    }

    // TypeToken: 0x2000008
    public struct CanvasUpdate
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.CanvasUpdate Prelayout;        // 0x0
        public static UnityEngine.UI.CanvasUpdate Layout;        // 0x0
        public static UnityEngine.UI.CanvasUpdate PostLayout;        // 0x0
        public static UnityEngine.UI.CanvasUpdate PreRender;        // 0x0
        public static UnityEngine.UI.CanvasUpdate LatePreRender;        // 0x0
        public static UnityEngine.UI.CanvasUpdate MaxUpdateValue;        // 0x0

    }

    // TypeToken: 0x2000009
    public interface ICanvasElement
    {
        // Methods
        private System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing) { }
        private UnityEngine.Transform get_transform() { }
        private System.Void LayoutComplete() { }
        private System.Void GraphicUpdateComplete() { }
        private System.Boolean IsDestroyed() { }

    }

    // TypeToken: 0x200000A
    public class CanvasUpdateRegistry
    {
        // Fields
        private static UnityEngine.UI.CanvasUpdateRegistry s_Instance;        // 0x0
        private System.Boolean m_PerformingLayoutUpdate;        // 0x10
        private System.Boolean m_PerformingGraphicUpdate;        // 0x11
        private Unity.Profiling.ProfilerMarker[] m_CanvasUpdateProfilerStrings;        // 0x18
        private static System.String m_CullingUpdateProfilerString;        // 0x0
        private readonly UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.ICanvasElement> m_LayoutRebuildQueue;        // 0x20
        private readonly UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.ICanvasElement> m_GraphicRebuildQueue;        // 0x28
        private static readonly System.Comparison<UnityEngine.UI.ICanvasElement> s_SortLayoutFunction;        // 0x8

        // Methods
        private System.Void .ctor() { }
        private UnityEngine.UI.CanvasUpdateRegistry get_instance() { }
        private System.Boolean ObjectValidForUpdate(UnityEngine.UI.ICanvasElement element) { }
        private System.Void CleanInvalidItems() { }
        private System.Void PerformUpdate() { }
        private System.Int32 ParentCount(UnityEngine.Transform child) { }
        private System.Int32 SortLayoutList(UnityEngine.UI.ICanvasElement x, UnityEngine.UI.ICanvasElement y) { }
        private System.Void RegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element) { }
        private System.Boolean TryRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element) { }
        private System.Boolean InternalRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element) { }
        private System.Void RegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element) { }
        private System.Boolean TryRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element) { }
        private System.Boolean InternalRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element) { }
        private System.Void UnRegisterCanvasElementForRebuild(UnityEngine.UI.ICanvasElement element) { }
        private System.Void InternalUnRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element) { }
        private System.Void InternalUnRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element) { }
        private System.Boolean IsRebuildingLayout() { }
        private System.Boolean IsRebuildingGraphics() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000B
    public struct ColorBlock, IEquatable`1
    {
        // Fields
        private UnityEngine.Color m_NormalColor;        // 0x10
        private UnityEngine.Color m_HighlightedColor;        // 0x20
        private UnityEngine.Color m_PressedColor;        // 0x30
        private UnityEngine.Color m_SelectedColor;        // 0x40
        private UnityEngine.Color m_DisabledColor;        // 0x50
        private System.Single m_ColorMultiplier;        // 0x60
        private System.Single m_FadeDuration;        // 0x64
        public static UnityEngine.UI.ColorBlock defaultColorBlock;        // 0x0

        // Methods
        private UnityEngine.Color get_normalColor() { }
        private System.Void set_normalColor(UnityEngine.Color value) { }
        private UnityEngine.Color get_highlightedColor() { }
        private System.Void set_highlightedColor(UnityEngine.Color value) { }
        private UnityEngine.Color get_pressedColor() { }
        private System.Void set_pressedColor(UnityEngine.Color value) { }
        private UnityEngine.Color get_selectedColor() { }
        private System.Void set_selectedColor(UnityEngine.Color value) { }
        private UnityEngine.Color get_disabledColor() { }
        private System.Void set_disabledColor(UnityEngine.Color value) { }
        private System.Single get_colorMultiplier() { }
        private System.Void set_colorMultiplier(System.Single value) { }
        private System.Single get_fadeDuration() { }
        private System.Void set_fadeDuration(System.Single value) { }
        private System.Void .cctor() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(UnityEngine.UI.ColorBlock other) { }
        private System.Boolean op_Equality(UnityEngine.UI.ColorBlock point1, UnityEngine.UI.ColorBlock point2) { }
        private System.Boolean op_Inequality(UnityEngine.UI.ColorBlock point1, UnityEngine.UI.ColorBlock point2) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200000C
    public class ClipperRegistry
    {
        // Fields
        private static UnityEngine.UI.ClipperRegistry s_Instance;        // 0x0
        private readonly UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.IClipper> m_Clippers;        // 0x10
        private readonly Unity.Profiling.ProfilerMarker clippersMarker;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private UnityEngine.UI.ClipperRegistry get_instance() { }
        private System.Void Cull() { }
        private System.Void Register(UnityEngine.UI.IClipper c) { }
        private System.Void Unregister(UnityEngine.UI.IClipper c) { }

    }

    // TypeToken: 0x200000D
    public class Clipping
    {
        // Methods
        private UnityEngine.Rect FindCullAndClipWorldRect(System.Collections.Generic.List<UnityEngine.UI.RectMask2D> rectMaskParents, System.Boolean& validRect) { }

    }

    // TypeToken: 0x200000E
    public interface IClipper
    {
        // Methods
        private System.Void PerformClipping() { }

    }

    // TypeToken: 0x200000F
    public interface IClippable
    {
        // Methods
        private UnityEngine.GameObject get_gameObject() { }
        private System.Void RecalculateClipping() { }
        private UnityEngine.RectTransform get_rectTransform() { }
        private System.Void Cull(UnityEngine.Rect clipRect, System.Boolean validRect) { }
        private System.Void SetClipRect(UnityEngine.Rect value, System.Boolean validRect) { }
        private System.Void SetClipSoftness(UnityEngine.Vector2 clipSoftness) { }
        private System.Void SetHGClipSoftness(UnityEngine.Vector4 hgClipSoftness) { }

    }

    // TypeToken: 0x2000010
    public class RectangularVertexClipper
    {
        // Fields
        private readonly UnityEngine.Vector3[] m_WorldCorners;        // 0x10
        private readonly UnityEngine.Vector3[] m_CanvasCorners;        // 0x18

        // Methods
        private UnityEngine.Rect GetCanvasRect(UnityEngine.RectTransform t, UnityEngine.Canvas c) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000011
    public class DefaultControls
    {
        // Fields
        private static UnityEngine.UI.DefaultControls.IFactoryControls m_CurrentFactory;        // 0x0
        private static System.Single kWidth;        // 0x0
        private static System.Single kThickHeight;        // 0x0
        private static System.Single kThinHeight;        // 0x0
        private static UnityEngine.Vector2 s_ThickElementSize;        // 0x8
        private static UnityEngine.Vector2 s_ThinElementSize;        // 0x10
        private static UnityEngine.Vector2 s_ImageElementSize;        // 0x18
        private static UnityEngine.Color s_DefaultSelectableColor;        // 0x20
        private static UnityEngine.Color s_PanelColor;        // 0x30
        private static UnityEngine.Color s_TextColor;        // 0x40

        // Methods
        private UnityEngine.UI.DefaultControls.IFactoryControls get_factory() { }
        private UnityEngine.GameObject CreateUIElementRoot(System.String name, UnityEngine.Vector2 size, System.Type[] components) { }
        private UnityEngine.GameObject CreateUIObject(System.String name, UnityEngine.GameObject parent, System.Type[] components) { }
        private System.Void SetDefaultTextValues(UnityEngine.UI.Text lbl) { }
        private System.Void SetDefaultColorTransitionValues(UnityEngine.UI.Selectable slider) { }
        private System.Void SetParentAndAlign(UnityEngine.GameObject child, UnityEngine.GameObject parent) { }
        private System.Void SetLayerRecursively(UnityEngine.GameObject go, System.Int32 layer) { }
        private UnityEngine.GameObject CreatePanel(UnityEngine.UI.DefaultControls.Resources resources) { }
        private UnityEngine.GameObject CreateButton(UnityEngine.UI.DefaultControls.Resources resources) { }
        private UnityEngine.GameObject CreateText(UnityEngine.UI.DefaultControls.Resources resources) { }
        private UnityEngine.GameObject CreateImage(UnityEngine.UI.DefaultControls.Resources resources) { }
        private UnityEngine.GameObject CreateRawImage(UnityEngine.UI.DefaultControls.Resources resources) { }
        private UnityEngine.GameObject CreateSlider(UnityEngine.UI.DefaultControls.Resources resources) { }
        private UnityEngine.GameObject CreateScrollbar(UnityEngine.UI.DefaultControls.Resources resources) { }
        private UnityEngine.GameObject CreateToggle(UnityEngine.UI.DefaultControls.Resources resources) { }
        private UnityEngine.GameObject CreateInputField(UnityEngine.UI.DefaultControls.Resources resources) { }
        private UnityEngine.GameObject CreateDropdown(UnityEngine.UI.DefaultControls.Resources resources) { }
        private UnityEngine.GameObject CreateScrollView(UnityEngine.UI.DefaultControls.Resources resources) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000015
    public class Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler
    {
        // Fields
        private UnityEngine.RectTransform m_Template;        // 0x180
        private UnityEngine.UI.Text m_CaptionText;        // 0x188
        private UnityEngine.UI.Image m_CaptionImage;        // 0x190
        private UnityEngine.UI.Text m_ItemText;        // 0x198
        private UnityEngine.UI.Image m_ItemImage;        // 0x1A0
        private System.Int32 m_Value;        // 0x1A8
        private UnityEngine.UI.Dropdown.OptionDataList m_Options;        // 0x1B0
        private UnityEngine.UI.Dropdown.DropdownEvent m_OnValueChanged;        // 0x1B8
        private System.Single m_AlphaFadeSpeed;        // 0x1C0
        private UnityEngine.GameObject m_Dropdown;        // 0x1C8
        private UnityEngine.GameObject m_Blocker;        // 0x1D0
        private System.Collections.Generic.List<UnityEngine.UI.Dropdown.DropdownItem> m_Items;        // 0x1D8
        private UnityEngine.UI.CoroutineTween.TweenRunner<UnityEngine.UI.CoroutineTween.FloatTween> m_AlphaTweenRunner;        // 0x1E0
        private System.Boolean validTemplate;        // 0x1E8
        private static System.Int32 kHighSortingLayer;        // 0x0
        private static UnityEngine.UI.Dropdown.OptionData s_NoOptionData;        // 0x0

        // Methods
        private UnityEngine.RectTransform get_template() { }
        private System.Void set_template(UnityEngine.RectTransform value) { }
        private UnityEngine.UI.Text get_captionText() { }
        private System.Void set_captionText(UnityEngine.UI.Text value) { }
        private UnityEngine.UI.Image get_captionImage() { }
        private System.Void set_captionImage(UnityEngine.UI.Image value) { }
        private UnityEngine.UI.Text get_itemText() { }
        private System.Void set_itemText(UnityEngine.UI.Text value) { }
        private UnityEngine.UI.Image get_itemImage() { }
        private System.Void set_itemImage(UnityEngine.UI.Image value) { }
        private System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> get_options() { }
        private System.Void set_options(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> value) { }
        private UnityEngine.UI.Dropdown.DropdownEvent get_onValueChanged() { }
        private System.Void set_onValueChanged(UnityEngine.UI.Dropdown.DropdownEvent value) { }
        private System.Single get_alphaFadeSpeed() { }
        private System.Void set_alphaFadeSpeed(System.Single value) { }
        private System.Int32 get_value() { }
        private System.Void set_value(System.Int32 value) { }
        private System.Void SetValueWithoutNotify(System.Int32 input) { }
        private System.Void Set(System.Int32 value, System.Boolean sendCallback) { }
        private System.Void .ctor() { }
        private System.Void Awake() { }
        private System.Void Start() { }
        private System.Void OnDisable() { }
        private System.Void RefreshShownValue() { }
        private System.Void AddOptions(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> options) { }
        private System.Void AddOptions(System.Collections.Generic.List<System.String> options) { }
        private System.Void AddOptions(System.Collections.Generic.List<UnityEngine.Sprite> options) { }
        private System.Void ClearOptions() { }
        private System.Void SetupTemplate(UnityEngine.Canvas rootCanvas) { }
        private T GetOrAddComponent(UnityEngine.GameObject go) { }
        private System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void OnCancel(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void Show() { }
        private UnityEngine.GameObject CreateBlocker(UnityEngine.Canvas rootCanvas) { }
        private System.Void DestroyBlocker(UnityEngine.GameObject blocker) { }
        private UnityEngine.GameObject CreateDropdownList(UnityEngine.GameObject template) { }
        private System.Void DestroyDropdownList(UnityEngine.GameObject dropdownList) { }
        private UnityEngine.UI.Dropdown.DropdownItem CreateItem(UnityEngine.UI.Dropdown.DropdownItem itemTemplate) { }
        private System.Void DestroyItem(UnityEngine.UI.Dropdown.DropdownItem item) { }
        private UnityEngine.UI.Dropdown.DropdownItem AddItem(UnityEngine.UI.Dropdown.OptionData data, System.Boolean selected, UnityEngine.UI.Dropdown.DropdownItem itemTemplate, System.Collections.Generic.List<UnityEngine.UI.Dropdown.DropdownItem> items) { }
        private System.Void AlphaFadeList(System.Single duration, System.Single alpha) { }
        private System.Void AlphaFadeList(System.Single duration, System.Single start, System.Single end) { }
        private System.Void SetAlpha(System.Single alpha) { }
        private System.Void Hide() { }
        private System.Collections.IEnumerator DelayedDestroyDropdownList(System.Single delay) { }
        private System.Void ImmediateDestroyDropdownList() { }
        private System.Void OnSelectItem(UnityEngine.UI.Toggle toggle) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200001C
    public class FontData, ISerializationCallbackReceiver
    {
        // Fields
        private UnityEngine.Font m_Font;        // 0x10
        private System.Int32 m_FontSize;        // 0x18
        private UnityEngine.FontStyle m_FontStyle;        // 0x1C
        private System.Boolean m_BestFit;        // 0x20
        private System.Int32 m_MinSize;        // 0x24
        private System.Int32 m_MaxSize;        // 0x28
        private UnityEngine.TextAnchor m_Alignment;        // 0x2C
        private System.Boolean m_AlignByGeometry;        // 0x30
        private System.Boolean m_RichText;        // 0x31
        private UnityEngine.HorizontalWrapMode m_HorizontalOverflow;        // 0x34
        private UnityEngine.VerticalWrapMode m_VerticalOverflow;        // 0x38
        private System.Single m_LineSpacing;        // 0x3C

        // Methods
        private UnityEngine.UI.FontData get_defaultFontData() { }
        private UnityEngine.Font get_font() { }
        private System.Void set_font(UnityEngine.Font value) { }
        private System.Int32 get_fontSize() { }
        private System.Void set_fontSize(System.Int32 value) { }
        private UnityEngine.FontStyle get_fontStyle() { }
        private System.Void set_fontStyle(UnityEngine.FontStyle value) { }
        private System.Boolean get_bestFit() { }
        private System.Void set_bestFit(System.Boolean value) { }
        private System.Int32 get_minSize() { }
        private System.Void set_minSize(System.Int32 value) { }
        private System.Int32 get_maxSize() { }
        private System.Void set_maxSize(System.Int32 value) { }
        private UnityEngine.TextAnchor get_alignment() { }
        private System.Void set_alignment(UnityEngine.TextAnchor value) { }
        private System.Boolean get_alignByGeometry() { }
        private System.Void set_alignByGeometry(System.Boolean value) { }
        private System.Boolean get_richText() { }
        private System.Void set_richText(System.Boolean value) { }
        private UnityEngine.HorizontalWrapMode get_horizontalOverflow() { }
        private System.Void set_horizontalOverflow(UnityEngine.HorizontalWrapMode value) { }
        private UnityEngine.VerticalWrapMode get_verticalOverflow() { }
        private System.Void set_verticalOverflow(UnityEngine.VerticalWrapMode value) { }
        private System.Single get_lineSpacing() { }
        private System.Void set_lineSpacing(System.Single value) { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001D
    public class FontUpdateTracker
    {
        // Fields
        private static System.Collections.Generic.Dictionary<UnityEngine.Font,System.Collections.Generic.HashSet<UnityEngine.UI.Text>> m_Tracked;        // 0x0

        // Methods
        private System.Void TrackText(UnityEngine.UI.Text t) { }
        private System.Void RebuildForFont(UnityEngine.Font f) { }
        private System.Void UntrackText(UnityEngine.UI.Text t) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200001E
    public class Graphic : UIBehaviour, ICanvasElement
    {
        // Fields
        protected static UnityEngine.Material s_DefaultUI;        // 0x0
        protected static UnityEngine.Texture2D s_WhiteTexture;        // 0x8
        private static System.String s_DefaultMaterialName;        // 0x10
        private static System.String s_OverlayShaderKeyword;        // 0x18
        protected UnityEngine.Material m_Material;        // 0x18
        private UnityEngine.Color m_Color;        // 0x20
        protected System.Boolean m_SkipLayoutUpdate;        // 0x30
        protected System.Boolean m_SkipMaterialUpdate;        // 0x31
        private System.Boolean m_RaycastTarget;        // 0x32
        private UnityEngine.Vector4 m_RaycastPadding;        // 0x34
        private System.Boolean m_RaycastIgnoreMask;        // 0x44
        private UnityEngine.RectTransform m_RectTransform;        // 0x48
        private UnityEngine.CanvasRenderer m_CanvasRenderer;        // 0x50
        private UnityEngine.Canvas m_Canvas;        // 0x58
        private System.Boolean m_VertsDirty;        // 0x60
        private System.Boolean m_MaterialDirty;        // 0x61
        protected UnityEngine.Events.UnityAction m_OnDirtyLayoutCallback;        // 0x68
        protected UnityEngine.Events.UnityAction m_OnDirtyVertsCallback;        // 0x70
        protected UnityEngine.Events.UnityAction m_OnDirtyMaterialCallback;        // 0x78
        protected static UnityEngine.Mesh s_Mesh;        // 0x20
        private static readonly UnityEngine.UI.VertexHelper s_VertexHelper;        // 0x28
        protected UnityEngine.Mesh m_CachedMesh;        // 0x80
        protected UnityEngine.Vector2[] m_CachedUvs;        // 0x88
        private UnityEngine.UI.CoroutineTween.TweenRunner<UnityEngine.UI.CoroutineTween.ColorTween> m_ColorTweenRunnerLazy;        // 0x90
        protected System.Boolean m_EnableRuntimeAtlas;        // 0x98
        protected UnityEngine.Texture m_RuntimeAtlasTexture;        // 0xA0
        private System.Boolean <useLegacyMeshGeneration>k__BackingField;        // 0xA8

        // Methods
        private System.String get_defaultMaterialName() { }
        private System.Void set_defaultMaterialName(System.String value) { }
        private UnityEngine.Material get_defaultGraphicMaterial() { }
        private System.String get_overlayShaderKeyword() { }
        private System.Void set_overlayShaderKeyword(System.String value) { }
        private UnityEngine.Color get_color() { }
        private System.Void set_color(UnityEngine.Color value) { }
        private System.Boolean get_raycastTarget() { }
        private System.Void set_raycastTarget(System.Boolean value) { }
        private UnityEngine.Vector4 get_raycastPadding() { }
        private System.Void set_raycastPadding(UnityEngine.Vector4 value) { }
        private UnityEngine.UI.CoroutineTween.TweenRunner<UnityEngine.UI.CoroutineTween.ColorTween> get_m_ColorTweenRunner() { }
        private System.Boolean get_enableRuntimeAtlas() { }
        private System.Void set_enableRuntimeAtlas(System.Boolean value) { }
        private UnityEngine.Texture get_runtimeAtlasTexture() { }
        private System.Void set_runtimeAtlasTexture(UnityEngine.Texture value) { }
        private System.Boolean get_useLegacyMeshGeneration() { }
        private System.Void set_useLegacyMeshGeneration(System.Boolean value) { }
        private System.Void .ctor() { }
        private System.Void SetAllDirty() { }
        private System.Void SetLayoutDirty() { }
        private System.Void SetVerticesDirty() { }
        private System.Void SetMaterialDirty() { }
        private System.Void OnRectTransformDimensionsChange() { }
        private System.Void OnBeforeTransformParentChanged() { }
        private System.Void OnTransformParentChanged() { }
        private System.Int32 get_depth() { }
        private UnityEngine.RectTransform get_rectTransform() { }
        private UnityEngine.Canvas get_canvas() { }
        private System.Void CacheCanvas() { }
        private UnityEngine.CanvasRenderer get_canvasRenderer() { }
        private UnityEngine.Material get_defaultMaterial() { }
        private UnityEngine.Material get_material() { }
        private System.Void set_material(UnityEngine.Material value) { }
        private UnityEngine.Material get_materialForRendering() { }
        private UnityEngine.Texture get_mainTexture() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void OnCanvasHierarchyChanged() { }
        private System.Void OnCullingChanged() { }
        private System.Void Rebuild(UnityEngine.UI.CanvasUpdate update) { }
        private System.Void LayoutComplete() { }
        private System.Void GraphicUpdateComplete() { }
        private System.Void UpdateMaterial() { }
        private System.Void UpdateGeometry() { }
        private System.Void DoMeshGeneration() { }
        private System.Void DoLegacyMeshGeneration() { }
        private UnityEngine.Mesh get_workerMesh() { }
        private System.Void OnFillVBO(System.Collections.Generic.List<UnityEngine.UIVertex> vbo) { }
        private System.Void OnPopulateMesh(UnityEngine.Mesh m) { }
        private System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper vh) { }
        private System.Void OnDidApplyAnimationProperties() { }
        private System.Void SetNativeSize() { }
        private System.Boolean Raycast(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera) { }
        private UnityEngine.Vector2 PixelAdjustPoint(UnityEngine.Vector2 point) { }
        private UnityEngine.Rect GetPixelAdjustedRect() { }
        private System.Void CrossFadeColor(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha) { }
        private System.Void CrossFadeColor(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, System.Boolean useRGB) { }
        private UnityEngine.Color CreateColorFromAlpha(System.Single alpha) { }
        private System.Void CrossFadeAlpha(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale) { }
        private System.Void RegisterDirtyLayoutCallback(UnityEngine.Events.UnityAction action) { }
        private System.Void UnregisterDirtyLayoutCallback(UnityEngine.Events.UnityAction action) { }
        private System.Void RegisterDirtyVerticesCallback(UnityEngine.Events.UnityAction action) { }
        private System.Void UnregisterDirtyVerticesCallback(UnityEngine.Events.UnityAction action) { }
        private System.Void RegisterDirtyMaterialCallback(UnityEngine.Events.UnityAction action) { }
        private System.Void UnregisterDirtyMaterialCallback(UnityEngine.Events.UnityAction action) { }
        private System.Void .cctor() { }
        private UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform() { }

    }

    // TypeToken: 0x200001F
    public class GraphicRaycaster : BaseRaycaster
    {
        // Fields
        protected static System.Int32 kNoEventMaskSet;        // 0x0
        private System.Boolean m_IgnoreReversedGraphics;        // 0x20
        private UnityEngine.UI.GraphicRaycaster.BlockingObjects m_BlockingObjects;        // 0x24
        protected UnityEngine.LayerMask m_BlockingMask;        // 0x28
        private UnityEngine.Canvas m_Canvas;        // 0x30
        private System.Collections.Generic.List<UnityEngine.UI.Graphic> m_RaycastResults;        // 0x38
        private static readonly System.Collections.Generic.List<UnityEngine.UI.Graphic> s_SortedGraphics;        // 0x0

        // Methods
        private System.Int32 get_sortOrderPriority() { }
        private System.Int32 get_renderOrderPriority() { }
        private System.Boolean get_ignoreReversedGraphics() { }
        private System.Void set_ignoreReversedGraphics(System.Boolean value) { }
        private UnityEngine.UI.GraphicRaycaster.BlockingObjects get_blockingObjects() { }
        private System.Void set_blockingObjects(UnityEngine.UI.GraphicRaycaster.BlockingObjects value) { }
        private UnityEngine.LayerMask get_blockingMask() { }
        private System.Void set_blockingMask(UnityEngine.LayerMask value) { }
        private System.Void .ctor() { }
        private UnityEngine.Canvas get_canvas() { }
        private System.Void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }
        private UnityEngine.Camera get_eventCamera() { }
        private System.Void Raycast(UnityEngine.Canvas canvas, UnityEngine.Camera eventCamera, UnityEngine.Vector2 pointerPosition, System.Collections.Generic.IList<UnityEngine.UI.Graphic> foundGraphics, System.Collections.Generic.List<UnityEngine.UI.Graphic> results) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000022
    public class GraphicRegistry
    {
        // Fields
        private static UnityEngine.UI.GraphicRegistry s_Instance;        // 0x0
        private readonly System.Collections.Generic.Dictionary<UnityEngine.Canvas,UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.Graphic>> m_Graphics;        // 0x10
        private readonly System.Collections.Generic.Dictionary<UnityEngine.Canvas,UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.Graphic>> m_RaycastableGraphics;        // 0x18
        private static readonly System.Collections.Generic.List<UnityEngine.UI.Graphic> s_EmptyList;        // 0x8

        // Methods
        private System.Void .ctor() { }
        private UnityEngine.UI.GraphicRegistry get_instance() { }
        private System.Void RegisterGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic) { }
        private System.Void RegisterRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic) { }
        private System.Void UnregisterGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic) { }
        private System.Void UnregisterRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic) { }
        private System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetGraphicsForCanvas(UnityEngine.Canvas canvas) { }
        private System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetRaycastableGraphicsForCanvas(UnityEngine.Canvas canvas) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000023
    public interface IGraphicEnabledDisabled
    {
        // Methods
        private System.Void OnSiblingGraphicEnabledDisabled() { }

    }

    // TypeToken: 0x2000024
    public class Image : MaskableGraphic, ISerializationCallbackReceiver, ILayoutElement, ICanvasRaycastFilter
    {
        // Fields
        protected static UnityEngine.Material s_ETC1DefaultUI;        // 0x0
        private UnityEngine.Sprite m_Sprite;        // 0xE8
        protected UnityEngine.Rect m_RuntimeAtlasRect;        // 0xF0
        protected UnityEngine.Rect m_RuntimeAtlasTextureRect;        // 0x100
        protected UnityEngine.Vector4 m_RuntimeAtlasBorder;        // 0x110
        protected System.Single m_RuntimeAtlasPixelsPerUnit;        // 0x120
        private UnityEngine.Sprite m_OverrideSprite;        // 0x128
        private UnityEngine.UI.Image.Type m_Type;        // 0x130
        private System.Boolean m_PreserveAspect;        // 0x134
        private System.Boolean m_FillCenter;        // 0x135
        private UnityEngine.UI.Image.FillMethod m_FillMethod;        // 0x138
        private System.Single m_FillAmount;        // 0x13C
        private System.Boolean m_FillClockwise;        // 0x140
        private System.Int32 m_FillOrigin;        // 0x144
        private System.Single m_AlphaHitTestMinimumThreshold;        // 0x148
        private System.Boolean m_Tracked;        // 0x14C
        private System.Boolean m_UseSpriteMesh;        // 0x14D
        private System.Single m_PixelsPerUnitMultiplier;        // 0x150
        private System.Single m_CachedReferencePixelsPerUnit;        // 0x154
        public UnityEngine.UI.Image.SlicedSpriteParams slicedSpriteParams;        // 0x158
        private System.Boolean bAwakeOnce;        // 0x17C
        private static readonly UnityEngine.Vector2[] s_VertScratch;        // 0x8
        private static readonly UnityEngine.Vector2[] s_UVScratch;        // 0x10
        private static System.Int32 QuadCount;        // 0x0
        private static readonly UnityEngine.Vector3[] s_Xy;        // 0x18
        private static readonly UnityEngine.Vector3[] s_Uv;        // 0x20
        private static System.Collections.Generic.List<UnityEngine.UI.Image> m_TrackedTexturelessImages;        // 0x28
        private static System.Boolean s_Initialized;        // 0x30
        protected static System.Int32 VALIDATE_MAX_VERT_COUNT;        // 0x0
        private UnityEngine.UI.Image.EDynamicAtlasActiveMode m_DynamicAtlasActiveMode;        // 0x17D
        protected System.Boolean _packIntoRuntimeAtlas;        // 0x17E
        protected System.Int32 m_panelLevel;        // 0x180
        public System.Boolean keepOriginUV;        // 0x184
        private System.Action dynamicAtlasCallBack;        // 0x188
        private static System.Boolean _sDynamicAtlasInitialized;        // 0x31
        private static readonly System.Collections.Generic.List<UnityEngine.UI.Image> s_FreeList;        // 0x38
        private static readonly System.Collections.Generic.HashSet<UnityEngine.UI.Image> s_TrackedDynamicAtlasImages;        // 0x40
        private static readonly System.Collections.Generic.List<UnityEngine.UI.Image> s_FreeListRevert;        // 0x48
        private static readonly System.Collections.Generic.HashSet<UnityEngine.UI.Image> s_TrackedDynamicAtlasSpriteRevert;        // 0x50
        public static System.Boolean s_AtlasV2;        // 0x58

        // Methods
        private UnityEngine.Rect get_runtimeAtlasRect() { }
        private System.Void set_runtimeAtlasRect(UnityEngine.Rect value) { }
        private UnityEngine.Rect get_runtimeAtlasTextureRect() { }
        private System.Void set_runtimeAtlasTextureRect(UnityEngine.Rect value) { }
        private UnityEngine.Vector4 get_runtimeAtlasBorder() { }
        private System.Void set_runtimeAtlasBorder(UnityEngine.Vector4 value) { }
        private System.Single get_runtimeAtlasPixelsPerUnit() { }
        private System.Void set_runtimeAtlasPixelsPerUnit(System.Single value) { }
        private UnityEngine.Sprite get_sprite() { }
        private System.Void set_sprite(UnityEngine.Sprite value) { }
        private System.Boolean get_enableRuntimeAtlasRaw() { }
        private System.Boolean get_enableRuntimeAtlas() { }
        private System.Void set_enableRuntimeAtlas(System.Boolean value) { }
        private System.Void ReleaseSprite() { }
        private System.Void _OnSpriteChanged(UnityEngine.Sprite oldOne) { }
        private System.Void DisableSpriteOptimizations() { }
        private UnityEngine.Sprite get_overrideSprite() { }
        private System.Void set_overrideSprite(UnityEngine.Sprite value) { }
        private UnityEngine.Sprite get_activeSprite() { }
        private UnityEngine.UI.Image.Type get_type() { }
        private System.Void set_type(UnityEngine.UI.Image.Type value) { }
        private System.Boolean get_preserveAspect() { }
        private System.Void set_preserveAspect(System.Boolean value) { }
        private System.Boolean get_fillCenter() { }
        private System.Void set_fillCenter(System.Boolean value) { }
        private UnityEngine.UI.Image.FillMethod get_fillMethod() { }
        private System.Void set_fillMethod(UnityEngine.UI.Image.FillMethod value) { }
        private System.Single get_fillAmount() { }
        private System.Void set_fillAmount(System.Single value) { }
        private System.Boolean get_fillClockwise() { }
        private System.Void set_fillClockwise(System.Boolean value) { }
        private System.Int32 get_fillOrigin() { }
        private System.Void set_fillOrigin(System.Int32 value) { }
        private System.Single get_eventAlphaThreshold() { }
        private System.Void set_eventAlphaThreshold(System.Single value) { }
        private System.Single get_alphaHitTestMinimumThreshold() { }
        private System.Void set_alphaHitTestMinimumThreshold(System.Single value) { }
        private System.Boolean get_useSpriteMesh() { }
        private System.Void set_useSpriteMesh(System.Boolean value) { }
        private System.Void .ctor() { }
        private UnityEngine.Material get_defaultETC1GraphicMaterial() { }
        private UnityEngine.Texture get_mainTexture() { }
        private System.Boolean get_hasBorder() { }
        private System.Single get_pixelsPerUnitMultiplier() { }
        private System.Void set_pixelsPerUnitMultiplier(System.Single value) { }
        private System.Single get_pixelsPerUnit() { }
        private System.Single get_multipliedPixelsPerUnit() { }
        private UnityEngine.Material get_material() { }
        private System.Void set_material(UnityEngine.Material value) { }
        private System.Void OnBeforeSerialize() { }
        private System.Void OnAfterDeserialize() { }
        private System.Void PreserveSpriteAspectRatio(UnityEngine.Rect& rect, UnityEngine.Vector2 spriteSize) { }
        private UnityEngine.Vector4 GetDrawingDimensions(System.Boolean shouldPreserveAspect) { }
        private System.Void SetNativeSize() { }
        private System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper toFill) { }
        private System.Void TrackSprite() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Awake() { }
        private System.Void OnDestroy() { }
        private System.Void UpdateMaterial() { }
        private System.Void OnCanvasHierarchyChanged() { }
        private System.Void GenerateSimpleSprite(UnityEngine.UI.VertexHelper vh, System.Boolean lPreserveAspect) { }
        private System.Void GenerateSprite(UnityEngine.UI.VertexHelper vh, System.Boolean lPreserveAspect) { }
        private System.Void GenerateSlicedSprite(UnityEngine.UI.VertexHelper toFill) { }
        private System.Void GenerateTiledSprite(UnityEngine.UI.VertexHelper toFill) { }
        private System.Void GenerateMirrorSprite(UnityEngine.UI.VertexHelper toFill) { }
        private System.Void GenerateMirrorQuarter(UnityEngine.UI.VertexHelper toFill) { }
        private System.Void AddQuad(UnityEngine.UI.VertexHelper vertexHelper, UnityEngine.Vector3[] quadPositions, UnityEngine.Color32 color, UnityEngine.Vector3[] quadUVs) { }
        private System.Void AddQuad(UnityEngine.UI.VertexHelper vertexHelper, UnityEngine.Vector2 posMin, UnityEngine.Vector2 posMax, UnityEngine.Color32 color, UnityEngine.Vector2 uvMin, UnityEngine.Vector2 uvMax) { }
        private UnityEngine.Vector4 GetAdjustedBorders(UnityEngine.Vector4 border, UnityEngine.Rect adjustedRect) { }
        private System.Void GenerateFilledSprite(UnityEngine.UI.VertexHelper toFill, System.Boolean preserveAspect) { }
        private System.Boolean RadialCut(UnityEngine.Vector3[] xy, UnityEngine.Vector3[] uv, System.Single fill, System.Boolean invert, System.Int32 corner) { }
        private System.Void RadialCut(UnityEngine.Vector3[] xy, System.Single cos, System.Single sin, System.Boolean invert, System.Int32 corner) { }
        private System.Void CalculateLayoutInputHorizontal() { }
        private System.Void CalculateLayoutInputVertical() { }
        private System.Single get_minWidth() { }
        private System.Single get_preferredWidth() { }
        private System.Single get_flexibleWidth() { }
        private System.Single get_minHeight() { }
        private System.Single get_preferredHeight() { }
        private System.Single get_flexibleHeight() { }
        private System.Int32 get_layoutPriority() { }
        private System.Boolean IsRaycastLocationValid(UnityEngine.Vector2 screenPoint, UnityEngine.Camera eventCamera) { }
        private UnityEngine.Vector2 MapCoordinate(UnityEngine.Vector2 local, UnityEngine.Rect rect) { }
        private System.Void RebuildImage(UnityEngine.U2D.SpriteAtlas spriteAtlas) { }
        private System.Void TrackImage(UnityEngine.UI.Image g) { }
        private System.Void UnTrackImage(UnityEngine.UI.Image g) { }
        private System.Void OnDidApplyAnimationProperties() { }
        private UnityEngine.Vector4 GetRuntimeAtlasSpritePadding() { }
        private UnityEngine.Vector4 GetRuntimeAtlasSpriteOuterUV() { }
        private UnityEngine.Vector4 GetRuntimeAtlasSpriteInnerUV() { }
        private System.String GetParticlePath() { }
        private UnityEngine.UI.Image.EDynamicAtlasActiveMode get_DynamicAtlasActiveMode() { }
        private System.Void RegisterDynamicAtlas() { }
        private System.Void UnRegisterDynamicAtlas(UnityEngine.Sprite _sprite) { }
        private System.Void RegisterDynamicAtlasCallBack(System.Action cb) { }
        private System.Void UnRegisterDynamicAtlasCallBack(System.Action cb) { }
        private System.Void _CanvasRreWillRenderCanvases() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200002E
    public interface IMask
    {
        // Methods
        private System.Boolean Enabled() { }
        private UnityEngine.RectTransform get_rectTransform() { }

    }

    // TypeToken: 0x200002F
    public interface IMaskable
    {
        // Methods
        private System.Void RecalculateMasking() { }

    }

    // TypeToken: 0x2000030
    public class InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement
    {
        // Fields
        protected UnityEngine.TouchScreenKeyboard m_Keyboard;        // 0x180
        private static readonly System.Char[] kSeparators;        // 0x0
        private static System.Boolean s_IsQuestDevice;        // 0x8
        protected UnityEngine.UI.Text m_TextComponent;        // 0x188
        protected UnityEngine.UI.Graphic m_Placeholder;        // 0x190
        private UnityEngine.UI.InputField.ContentType m_ContentType;        // 0x198
        private UnityEngine.UI.InputField.InputType m_InputType;        // 0x19C
        private System.Char m_AsteriskChar;        // 0x1A0
        private UnityEngine.TouchScreenKeyboardType m_KeyboardType;        // 0x1A4
        private UnityEngine.UI.InputField.LineType m_LineType;        // 0x1A8
        private System.Boolean m_HideMobileInput;        // 0x1AC
        private UnityEngine.UI.InputField.CharacterValidation m_CharacterValidation;        // 0x1B0
        private System.Int32 m_CharacterLimit;        // 0x1B4
        private UnityEngine.UI.InputField.SubmitEvent m_OnSubmit;        // 0x1B8
        private UnityEngine.UI.InputField.EndEditEvent m_OnDidEndEdit;        // 0x1C0
        private UnityEngine.UI.InputField.OnChangeEvent m_OnValueChanged;        // 0x1C8
        private UnityEngine.UI.InputField.OnValidateInput m_OnValidateInput;        // 0x1D0
        private UnityEngine.Color m_CaretColor;        // 0x1D8
        private System.Boolean m_CustomCaretColor;        // 0x1E8
        private UnityEngine.Color m_SelectionColor;        // 0x1EC
        protected System.String m_Text;        // 0x200
        private System.Single m_CaretBlinkRate;        // 0x208
        private System.Int32 m_CaretWidth;        // 0x20C
        private System.Boolean m_ReadOnly;        // 0x210
        private System.Boolean m_ShouldActivateOnSelect;        // 0x211
        protected System.Int32 m_CaretPosition;        // 0x214
        protected System.Int32 m_CaretSelectPosition;        // 0x218
        private UnityEngine.RectTransform caretRectTrans;        // 0x220
        protected UnityEngine.UIVertex[] m_CursorVerts;        // 0x228
        private UnityEngine.TextGenerator m_InputTextCache;        // 0x230
        private UnityEngine.CanvasRenderer m_CachedInputRenderer;        // 0x238
        private System.Boolean m_PreventFontCallback;        // 0x240
        protected UnityEngine.Mesh m_Mesh;        // 0x248
        private System.Boolean m_AllowInput;        // 0x250
        private System.Boolean m_ShouldActivateNextUpdate;        // 0x251
        private System.Boolean m_UpdateDrag;        // 0x252
        private System.Boolean m_DragPositionOutOfBounds;        // 0x253
        private static System.Single kHScrollSpeed;        // 0x0
        private static System.Single kVScrollSpeed;        // 0x0
        protected System.Boolean m_CaretVisible;        // 0x254
        private UnityEngine.Coroutine m_BlinkCoroutine;        // 0x258
        private System.Single m_BlinkStartTime;        // 0x260
        protected System.Int32 m_DrawStart;        // 0x264
        protected System.Int32 m_DrawEnd;        // 0x268
        private UnityEngine.Coroutine m_DragCoroutine;        // 0x270
        private System.String m_OriginalText;        // 0x278
        private System.Boolean m_WasCanceled;        // 0x280
        private System.Boolean m_HasDoneFocusTransition;        // 0x281
        private UnityEngine.WaitForSecondsRealtime m_WaitForSecondsRealtime;        // 0x288
        private System.Boolean m_TouchKeyboardAllowsInPlaceEditing;        // 0x290
        private System.Boolean m_IsCompositionActive;        // 0x291
        private static System.String kEmailSpecialCharacters;        // 0x0
        private static System.String kOculusQuestDeviceModel;        // 0x0
        private UnityEngine.Event m_ProcessingEvent;        // 0x298
        private static System.Int32 k_MaxTextLength;        // 0x0

        // Methods
        private UnityEngine.EventSystems.BaseInput get_input() { }
        private System.String get_compositionString() { }
        private System.Void .ctor() { }
        private UnityEngine.Mesh get_mesh() { }
        private UnityEngine.TextGenerator get_cachedInputTextGenerator() { }
        private System.Void set_shouldHideMobileInput(System.Boolean value) { }
        private System.Boolean get_shouldHideMobileInput() { }
        private System.Void set_shouldActivateOnSelect(System.Boolean value) { }
        private System.Boolean get_shouldActivateOnSelect() { }
        private System.String get_text() { }
        private System.Void set_text(System.String value) { }
        private System.Void SetTextWithoutNotify(System.String input) { }
        private System.Void SetText(System.String value, System.Boolean sendCallback) { }
        private System.Boolean get_isFocused() { }
        private System.Single get_caretBlinkRate() { }
        private System.Void set_caretBlinkRate(System.Single value) { }
        private System.Int32 get_caretWidth() { }
        private System.Void set_caretWidth(System.Int32 value) { }
        private UnityEngine.UI.Text get_textComponent() { }
        private System.Void set_textComponent(UnityEngine.UI.Text value) { }
        private UnityEngine.UI.Graphic get_placeholder() { }
        private System.Void set_placeholder(UnityEngine.UI.Graphic value) { }
        private UnityEngine.Color get_caretColor() { }
        private System.Void set_caretColor(UnityEngine.Color value) { }
        private System.Boolean get_customCaretColor() { }
        private System.Void set_customCaretColor(System.Boolean value) { }
        private UnityEngine.Color get_selectionColor() { }
        private System.Void set_selectionColor(UnityEngine.Color value) { }
        private UnityEngine.UI.InputField.EndEditEvent get_onEndEdit() { }
        private System.Void set_onEndEdit(UnityEngine.UI.InputField.EndEditEvent value) { }
        private UnityEngine.UI.InputField.SubmitEvent get_onSubmit() { }
        private System.Void set_onSubmit(UnityEngine.UI.InputField.SubmitEvent value) { }
        private UnityEngine.UI.InputField.OnChangeEvent get_onValueChange() { }
        private System.Void set_onValueChange(UnityEngine.UI.InputField.OnChangeEvent value) { }
        private UnityEngine.UI.InputField.OnChangeEvent get_onValueChanged() { }
        private System.Void set_onValueChanged(UnityEngine.UI.InputField.OnChangeEvent value) { }
        private UnityEngine.UI.InputField.OnValidateInput get_onValidateInput() { }
        private System.Void set_onValidateInput(UnityEngine.UI.InputField.OnValidateInput value) { }
        private System.Int32 get_characterLimit() { }
        private System.Void set_characterLimit(System.Int32 value) { }
        private UnityEngine.UI.InputField.ContentType get_contentType() { }
        private System.Void set_contentType(UnityEngine.UI.InputField.ContentType value) { }
        private UnityEngine.UI.InputField.LineType get_lineType() { }
        private System.Void set_lineType(UnityEngine.UI.InputField.LineType value) { }
        private UnityEngine.UI.InputField.InputType get_inputType() { }
        private System.Void set_inputType(UnityEngine.UI.InputField.InputType value) { }
        private UnityEngine.TouchScreenKeyboard get_touchScreenKeyboard() { }
        private UnityEngine.TouchScreenKeyboardType get_keyboardType() { }
        private System.Void set_keyboardType(UnityEngine.TouchScreenKeyboardType value) { }
        private UnityEngine.UI.InputField.CharacterValidation get_characterValidation() { }
        private System.Void set_characterValidation(UnityEngine.UI.InputField.CharacterValidation value) { }
        private System.Boolean get_readOnly() { }
        private System.Void set_readOnly(System.Boolean value) { }
        private System.Boolean get_multiLine() { }
        private System.Char get_asteriskChar() { }
        private System.Void set_asteriskChar(System.Char value) { }
        private System.Boolean get_wasCanceled() { }
        private System.Void ClampPos(System.Int32& pos) { }
        private System.Int32 get_caretPositionInternal() { }
        private System.Void set_caretPositionInternal(System.Int32 value) { }
        private System.Int32 get_caretSelectPositionInternal() { }
        private System.Void set_caretSelectPositionInternal(System.Int32 value) { }
        private System.Boolean get_hasSelection() { }
        private System.Int32 get_caretPosition() { }
        private System.Void set_caretPosition(System.Int32 value) { }
        private System.Int32 get_selectionAnchorPosition() { }
        private System.Void set_selectionAnchorPosition(System.Int32 value) { }
        private System.Int32 get_selectionFocusPosition() { }
        private System.Void set_selectionFocusPosition(System.Int32 value) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Collections.IEnumerator CaretBlink() { }
        private System.Void SetCaretVisible() { }
        private System.Void SetCaretActive() { }
        private System.Void UpdateCaretMaterial() { }
        private System.Void OnFocus() { }
        private System.Void SelectAll() { }
        private System.Void MoveTextEnd(System.Boolean shift) { }
        private System.Void MoveTextStart(System.Boolean shift) { }
        private System.String get_clipboard() { }
        private System.Void set_clipboard(System.String value) { }
        private System.Boolean TouchScreenKeyboardShouldBeUsed() { }
        private System.Boolean InPlaceEditing() { }
        private System.Boolean InPlaceEditingChanged() { }
        private System.Void UpdateCaretFromKeyboard() { }
        private System.Void LateUpdate() { }
        private UnityEngine.Vector2 ScreenToLocal(UnityEngine.Vector2 screen) { }
        private System.Int32 GetUnclampedCharacterLineFromPosition(UnityEngine.Vector2 pos, UnityEngine.TextGenerator generator) { }
        private System.Int32 GetCharacterIndexFromPosition(UnityEngine.Vector2 pos) { }
        private System.Boolean MayDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Collections.IEnumerator MouseDragOutsideRect(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        private UnityEngine.UI.InputField.EditState KeyPressed(UnityEngine.Event evt) { }
        private System.Boolean IsValidChar(System.Char c) { }
        private System.Void ProcessEvent(UnityEngine.Event e) { }
        private System.Void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.String GetSelectedString() { }
        private System.Int32 FindtNextWordBegin() { }
        private System.Void MoveRight(System.Boolean shift, System.Boolean ctrl) { }
        private System.Int32 FindtPrevWordBegin() { }
        private System.Void MoveLeft(System.Boolean shift, System.Boolean ctrl) { }
        private System.Int32 DetermineCharacterLine(System.Int32 charPos, UnityEngine.TextGenerator generator) { }
        private System.Int32 LineUpCharacterPosition(System.Int32 originalPos, System.Boolean goToFirstChar) { }
        private System.Int32 LineDownCharacterPosition(System.Int32 originalPos, System.Boolean goToLastChar) { }
        private System.Void MoveDown(System.Boolean shift) { }
        private System.Void MoveDown(System.Boolean shift, System.Boolean goToLastChar) { }
        private System.Void MoveUp(System.Boolean shift) { }
        private System.Void MoveUp(System.Boolean shift, System.Boolean goToFirstChar) { }
        private System.Void Delete() { }
        private System.Void ForwardSpace() { }
        private System.Void Backspace() { }
        private System.Void Insert(System.Char c) { }
        private System.Void UpdateTouchKeyboardFromEditChanges() { }
        private System.Void SendOnValueChangedAndUpdateLabel() { }
        private System.Void SendOnValueChanged() { }
        private System.Void SendOnEndEdit() { }
        private System.Void SendOnSubmit() { }
        private System.Void Append(System.String input) { }
        private System.Void Append(System.Char input) { }
        private System.Void UpdateLabel() { }
        private System.Boolean IsSelectionVisible() { }
        private System.Int32 GetLineStartPosition(UnityEngine.TextGenerator gen, System.Int32 line) { }
        private System.Int32 GetLineEndPosition(UnityEngine.TextGenerator gen, System.Int32 line) { }
        private System.Void SetDrawRangeToContainCaretPosition(System.Int32 caretPos) { }
        private System.Void ForceLabelUpdate() { }
        private System.Void MarkGeometryAsDirty() { }
        private System.Void Rebuild(UnityEngine.UI.CanvasUpdate update) { }
        private System.Void LayoutComplete() { }
        private System.Void GraphicUpdateComplete() { }
        private System.Void UpdateGeometry() { }
        private System.Void AssignPositioningIfNeeded() { }
        private System.Void OnFillVBO(UnityEngine.Mesh vbo) { }
        private System.Void GenerateCaret(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset) { }
        private System.Void CreateCursorVerts() { }
        private System.Void GenerateHighlight(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset) { }
        private System.Char Validate(System.String text, System.Int32 pos, System.Char ch) { }
        private System.Void ActivateInputField() { }
        private System.Void ActivateInputFieldInternal() { }
        private System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void DeactivateInputField() { }
        private System.Void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void EnforceContentType() { }
        private System.Void EnforceTextHOverflow() { }
        private System.Void SetToCustomIfContentTypeIsNot(UnityEngine.UI.InputField.ContentType[] allowedContentTypes) { }
        private System.Void SetToCustom() { }
        private System.Void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, System.Boolean instant) { }
        private System.Void CalculateLayoutInputHorizontal() { }
        private System.Void CalculateLayoutInputVertical() { }
        private System.Single get_minWidth() { }
        private System.Single get_preferredWidth() { }
        private System.Single get_flexibleWidth() { }
        private System.Single get_minHeight() { }
        private System.Single get_preferredHeight() { }
        private System.Single get_flexibleHeight() { }
        private System.Int32 get_layoutPriority() { }
        private System.Void .cctor() { }
        private UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform() { }

    }

    // TypeToken: 0x200003C
    public class AspectRatioFitter : UIBehaviour, ILayoutSelfController, ILayoutController
    {
        // Fields
        private UnityEngine.UI.AspectRatioFitter.AspectMode m_AspectMode;        // 0x18
        private System.Single m_AspectRatio;        // 0x1C
        private UnityEngine.RectTransform m_Rect;        // 0x20
        private System.Boolean m_DelayedSetDirty;        // 0x28
        private System.Boolean m_DoesParentExist;        // 0x29
        private UnityEngine.DrivenRectTransformTracker m_Tracker;        // 0x2A

        // Methods
        private UnityEngine.UI.AspectRatioFitter.AspectMode get_aspectMode() { }
        private System.Void set_aspectMode(UnityEngine.UI.AspectRatioFitter.AspectMode value) { }
        private System.Single get_aspectRatio() { }
        private System.Void set_aspectRatio(System.Single value) { }
        private UnityEngine.RectTransform get_rectTransform() { }
        private System.Void .ctor() { }
        private System.Void OnEnable() { }
        private System.Void Start() { }
        private System.Void OnDisable() { }
        private System.Void OnTransformParentChanged() { }
        private System.Void Update() { }
        private System.Void OnRectTransformDimensionsChange() { }
        private System.Void UpdateRect() { }
        private System.Single GetSizeDeltaToProduceSize(System.Single size, System.Int32 axis) { }
        private UnityEngine.Vector2 GetParentSize() { }
        private System.Void SetLayoutHorizontal() { }
        private System.Void SetLayoutVertical() { }
        private System.Void SetDirty() { }
        private System.Boolean IsComponentValidOnObject() { }
        private System.Boolean IsAspectModeValid() { }
        private System.Boolean DoesParentExists() { }

    }

    // TypeToken: 0x200003E
    public class CanvasScaler : UIBehaviour
    {
        // Fields
        private UnityEngine.UI.CanvasScaler.ScaleMode m_UiScaleMode;        // 0x18
        protected System.Single m_ReferencePixelsPerUnit;        // 0x1C
        protected System.Single m_ScaleFactor;        // 0x20
        protected UnityEngine.Vector2 m_ReferenceResolution;        // 0x24
        protected UnityEngine.UI.CanvasScaler.ScreenMatchMode m_ScreenMatchMode;        // 0x2C
        protected System.Single m_MatchWidthOrHeight;        // 0x30
        private static System.Single kLogBase;        // 0x0
        protected UnityEngine.UI.CanvasScaler.Unit m_PhysicalUnit;        // 0x34
        protected System.Single m_FallbackScreenDPI;        // 0x38
        protected System.Single m_DefaultSpriteDPI;        // 0x3C
        protected System.Single m_DynamicPixelsPerUnit;        // 0x40
        private UnityEngine.Canvas m_Canvas;        // 0x48
        private System.Single m_PrevScaleFactor;        // 0x50
        private System.Single m_PrevReferencePixelsPerUnit;        // 0x54
        protected System.Boolean m_PresetInfoIsWorld;        // 0x58

        // Methods
        private UnityEngine.UI.CanvasScaler.ScaleMode get_uiScaleMode() { }
        private System.Void set_uiScaleMode(UnityEngine.UI.CanvasScaler.ScaleMode value) { }
        private System.Single get_referencePixelsPerUnit() { }
        private System.Void set_referencePixelsPerUnit(System.Single value) { }
        private System.Single get_scaleFactor() { }
        private System.Void set_scaleFactor(System.Single value) { }
        private UnityEngine.Vector2 get_referenceResolution() { }
        private System.Void set_referenceResolution(UnityEngine.Vector2 value) { }
        private UnityEngine.UI.CanvasScaler.ScreenMatchMode get_screenMatchMode() { }
        private System.Void set_screenMatchMode(UnityEngine.UI.CanvasScaler.ScreenMatchMode value) { }
        private System.Single get_matchWidthOrHeight() { }
        private System.Void set_matchWidthOrHeight(System.Single value) { }
        private UnityEngine.UI.CanvasScaler.Unit get_physicalUnit() { }
        private System.Void set_physicalUnit(UnityEngine.UI.CanvasScaler.Unit value) { }
        private System.Single get_fallbackScreenDPI() { }
        private System.Void set_fallbackScreenDPI(System.Single value) { }
        private System.Single get_defaultSpriteDPI() { }
        private System.Void set_defaultSpriteDPI(System.Single value) { }
        private System.Single get_dynamicPixelsPerUnit() { }
        private System.Void set_dynamicPixelsPerUnit(System.Single value) { }
        private System.Void .ctor() { }
        private System.Void OnEnable() { }
        private System.Void Canvas_preWillRenderCanvases() { }
        private System.Void OnDisable() { }
        private System.Void HandleManually() { }
        private System.Void Handle() { }
        private System.Void HandleWorldCanvas() { }
        private System.Void HandleConstantPixelSize() { }
        private System.Void HandleScaleWithScreenSize() { }
        private System.Void HandleConstantPhysicalSize() { }
        private System.Void SetScaleFactor(System.Single scaleFactor) { }
        private System.Void SetReferencePixelsPerUnit(System.Single referencePixelsPerUnit) { }

    }

    // TypeToken: 0x2000042
    public class ContentSizeFitter : UIBehaviour, ILayoutSelfController, ILayoutController
    {
        // Fields
        protected UnityEngine.UI.ContentSizeFitter.FitMode m_HorizontalFit;        // 0x18
        protected UnityEngine.UI.ContentSizeFitter.FitMode m_VerticalFit;        // 0x1C
        private UnityEngine.RectTransform m_Rect;        // 0x20
        private UnityEngine.DrivenRectTransformTracker m_Tracker;        // 0x28

        // Methods
        private UnityEngine.UI.ContentSizeFitter.FitMode get_horizontalFit() { }
        private System.Void set_horizontalFit(UnityEngine.UI.ContentSizeFitter.FitMode value) { }
        private UnityEngine.UI.ContentSizeFitter.FitMode get_verticalFit() { }
        private System.Void set_verticalFit(UnityEngine.UI.ContentSizeFitter.FitMode value) { }
        private UnityEngine.RectTransform get_rectTransform() { }
        private System.Void .ctor() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnRectTransformDimensionsChange() { }
        private System.Void HandleSelfFittingAlongAxis(System.Int32 axis) { }
        private System.Void SetLayoutHorizontal() { }
        private System.Void SetLayoutVertical() { }
        private System.Void SetDirty() { }

    }

    // TypeToken: 0x2000044
    public class GridLayoutGroup : LayoutGroup
    {
        // Fields
        protected UnityEngine.UI.GridLayoutGroup.Corner m_StartCorner;        // 0x58
        protected UnityEngine.UI.GridLayoutGroup.Axis m_StartAxis;        // 0x5C
        protected UnityEngine.Vector2 m_CellSize;        // 0x60
        protected UnityEngine.Vector2 m_Spacing;        // 0x68
        protected UnityEngine.UI.GridLayoutGroup.Constraint m_Constraint;        // 0x70
        protected System.Int32 m_ConstraintCount;        // 0x74

        // Methods
        private UnityEngine.UI.GridLayoutGroup.Corner get_startCorner() { }
        private System.Void set_startCorner(UnityEngine.UI.GridLayoutGroup.Corner value) { }
        private UnityEngine.UI.GridLayoutGroup.Axis get_startAxis() { }
        private System.Void set_startAxis(UnityEngine.UI.GridLayoutGroup.Axis value) { }
        private UnityEngine.Vector2 get_cellSize() { }
        private System.Void set_cellSize(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 get_spacing() { }
        private System.Void set_spacing(UnityEngine.Vector2 value) { }
        private UnityEngine.UI.GridLayoutGroup.Constraint get_constraint() { }
        private System.Void set_constraint(UnityEngine.UI.GridLayoutGroup.Constraint value) { }
        private System.Int32 get_constraintCount() { }
        private System.Void set_constraintCount(System.Int32 value) { }
        private System.Void .ctor() { }
        private System.Void CalculateLayoutInputHorizontal() { }
        private System.Void CalculateLayoutInputVertical() { }
        private System.Void SetLayoutHorizontal() { }
        private System.Void SetLayoutVertical() { }
        private System.Void SetCellsAlongAxis(System.Int32 axis) { }

    }

    // TypeToken: 0x2000048
    public class HorizontalLayoutGroup : HorizontalOrVerticalLayoutGroup
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void CalculateLayoutInputHorizontal() { }
        private System.Void CalculateLayoutInputVertical() { }
        private System.Void SetLayoutHorizontal() { }
        private System.Void SetLayoutVertical() { }

    }

    // TypeToken: 0x2000049
    public class HorizontalOrVerticalLayoutGroup : LayoutGroup
    {
        // Fields
        protected System.Single m_Spacing;        // 0x58
        protected System.Boolean m_ChildForceExpandWidth;        // 0x5C
        protected System.Boolean m_ChildForceExpandHeight;        // 0x5D
        protected System.Boolean m_ChildControlWidth;        // 0x5E
        protected System.Boolean m_ChildControlHeight;        // 0x5F
        protected System.Boolean m_ChildScaleWidth;        // 0x60
        protected System.Boolean m_ChildScaleHeight;        // 0x61
        protected System.Boolean m_ReverseArrangement;        // 0x62

        // Methods
        private System.Single get_spacing() { }
        private System.Void set_spacing(System.Single value) { }
        private System.Boolean get_childForceExpandWidth() { }
        private System.Void set_childForceExpandWidth(System.Boolean value) { }
        private System.Boolean get_childForceExpandHeight() { }
        private System.Void set_childForceExpandHeight(System.Boolean value) { }
        private System.Boolean get_childControlWidth() { }
        private System.Void set_childControlWidth(System.Boolean value) { }
        private System.Boolean get_childControlHeight() { }
        private System.Void set_childControlHeight(System.Boolean value) { }
        private System.Boolean get_childScaleWidth() { }
        private System.Void set_childScaleWidth(System.Boolean value) { }
        private System.Boolean get_childScaleHeight() { }
        private System.Void set_childScaleHeight(System.Boolean value) { }
        private System.Boolean get_reverseArrangement() { }
        private System.Void set_reverseArrangement(System.Boolean value) { }
        private System.Void CalcAlongAxis(System.Int32 axis, System.Boolean isVertical) { }
        private System.Void SetChildrenAlongAxis(System.Int32 axis, System.Boolean isVertical) { }
        private System.Void GetChildSizes(UnityEngine.RectTransform child, System.Int32 axis, System.Boolean controlSize, System.Boolean childForceExpand, System.Single& min, System.Single& preferred, System.Single& flexible) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004A
    public interface ILayoutElement
    {
        // Methods
        private System.Void CalculateLayoutInputHorizontal() { }
        private System.Void CalculateLayoutInputVertical() { }
        private System.Single get_minWidth() { }
        private System.Single get_preferredWidth() { }
        private System.Single get_flexibleWidth() { }
        private System.Single get_minHeight() { }
        private System.Single get_preferredHeight() { }
        private System.Single get_flexibleHeight() { }
        private System.Int32 get_layoutPriority() { }

    }

    // TypeToken: 0x200004B
    public interface ILayoutController
    {
        // Methods
        private System.Void SetLayoutHorizontal() { }
        private System.Void SetLayoutVertical() { }

    }

    // TypeToken: 0x200004C
    public interface ILayoutGroup : ILayoutController
    {
    }

    // TypeToken: 0x200004D
    public interface ILayoutSelfController : ILayoutController
    {
    }

    // TypeToken: 0x200004E
    public interface ILayoutIgnorer
    {
        // Methods
        private System.Boolean get_ignoreLayout() { }

    }

    // TypeToken: 0x200004F
    public class LayoutElement : UIBehaviour, ILayoutElement, ILayoutIgnorer
    {
        // Fields
        private System.Boolean m_IgnoreLayout;        // 0x18
        private System.Single m_MinWidth;        // 0x1C
        private System.Single m_MinHeight;        // 0x20
        private System.Single m_PreferredWidth;        // 0x24
        private System.Single m_PreferredHeight;        // 0x28
        private System.Single m_FlexibleWidth;        // 0x2C
        private System.Single m_FlexibleHeight;        // 0x30
        private System.Int32 m_LayoutPriority;        // 0x34

        // Methods
        private System.Boolean get_ignoreLayout() { }
        private System.Void set_ignoreLayout(System.Boolean value) { }
        private System.Void CalculateLayoutInputHorizontal() { }
        private System.Void CalculateLayoutInputVertical() { }
        private System.Single get_minWidth() { }
        private System.Void set_minWidth(System.Single value) { }
        private System.Single get_minHeight() { }
        private System.Void set_minHeight(System.Single value) { }
        private System.Single get_preferredWidth() { }
        private System.Void set_preferredWidth(System.Single value) { }
        private System.Single get_preferredHeight() { }
        private System.Void set_preferredHeight(System.Single value) { }
        private System.Single get_flexibleWidth() { }
        private System.Void set_flexibleWidth(System.Single value) { }
        private System.Single get_flexibleHeight() { }
        private System.Void set_flexibleHeight(System.Single value) { }
        private System.Int32 get_layoutPriority() { }
        private System.Void set_layoutPriority(System.Int32 value) { }
        private System.Void .ctor() { }
        private System.Void OnEnable() { }
        private System.Void OnTransformParentChanged() { }
        private System.Void OnDisable() { }
        private System.Void OnDidApplyAnimationProperties() { }
        private System.Void OnBeforeTransformParentChanged() { }
        private System.Void SetDirty() { }

    }

    // TypeToken: 0x2000050
    public class LayoutGroup : UIBehaviour, ILayoutElement, ILayoutGroup, ILayoutController
    {
        // Fields
        protected UnityEngine.RectOffset m_Padding;        // 0x18
        protected UnityEngine.TextAnchor m_ChildAlignment;        // 0x20
        private UnityEngine.RectTransform m_Rect;        // 0x28
        protected UnityEngine.DrivenRectTransformTracker m_Tracker;        // 0x30
        private UnityEngine.Vector2 m_TotalMinSize;        // 0x34
        private UnityEngine.Vector2 m_TotalPreferredSize;        // 0x3C
        private UnityEngine.Vector2 m_TotalFlexibleSize;        // 0x44
        private System.Collections.Generic.List<UnityEngine.RectTransform> m_RectChildren;        // 0x50

        // Methods
        private UnityEngine.RectOffset get_padding() { }
        private System.Void set_padding(UnityEngine.RectOffset value) { }
        private UnityEngine.TextAnchor get_childAlignment() { }
        private System.Void set_childAlignment(UnityEngine.TextAnchor value) { }
        private UnityEngine.RectTransform get_rectTransform() { }
        private System.Collections.Generic.List<UnityEngine.RectTransform> get_rectChildren() { }
        private System.Void CalculateLayoutInputHorizontal() { }
        private System.Void CalculateLayoutInputVertical() { }
        private System.Single get_minWidth() { }
        private System.Single get_preferredWidth() { }
        private System.Single get_flexibleWidth() { }
        private System.Single get_minHeight() { }
        private System.Single get_preferredHeight() { }
        private System.Single get_flexibleHeight() { }
        private System.Int32 get_layoutPriority() { }
        private System.Void SetLayoutHorizontal() { }
        private System.Void SetLayoutVertical() { }
        private System.Void .ctor() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDidApplyAnimationProperties() { }
        private System.Single GetTotalMinSize(System.Int32 axis) { }
        private System.Single GetTotalPreferredSize(System.Int32 axis) { }
        private System.Single GetTotalFlexibleSize(System.Int32 axis) { }
        private System.Single GetStartOffset(System.Int32 axis, System.Single requiredSpaceWithoutPadding) { }
        private System.Single GetAlignmentOnAxis(System.Int32 axis) { }
        private System.Void SetLayoutInputForAxis(System.Single totalMin, System.Single totalPreferred, System.Single totalFlexible, System.Int32 axis) { }
        private System.Void SetChildAlongAxis(UnityEngine.RectTransform rect, System.Int32 axis, System.Single pos) { }
        private System.Void SetChildAlongAxisWithScale(UnityEngine.RectTransform rect, System.Int32 axis, System.Single pos, System.Single scaleFactor) { }
        private System.Void SetChildAlongAxis(UnityEngine.RectTransform rect, System.Int32 axis, System.Single pos, System.Single size) { }
        private System.Void SetChildAlongAxisWithScale(UnityEngine.RectTransform rect, System.Int32 axis, System.Single pos, System.Single size, System.Single scaleFactor) { }
        private System.Boolean get_isRootLayoutGroup() { }
        private System.Void OnRectTransformDimensionsChange() { }
        private System.Void OnTransformChildrenChanged() { }
        private System.Void SetProperty(T& currentValue, T newValue) { }
        private System.Void SetDirty() { }
        private System.Collections.IEnumerator DelayedSetDirty(UnityEngine.RectTransform rectTransform) { }

    }

    // TypeToken: 0x2000052
    public class LayoutRebuilder, ICanvasElement
    {
        // Fields
        private UnityEngine.RectTransform m_ToRebuild;        // 0x10
        private System.Int32 m_CachedHashFromTransform;        // 0x18
        private static UnityEngine.Pool.ObjectPool<UnityEngine.UI.LayoutRebuilder> s_Rebuilders;        // 0x0

        // Methods
        private System.Void Initialize(UnityEngine.RectTransform controller) { }
        private System.Void Clear() { }
        private System.Void .cctor() { }
        private System.Void ReapplyDrivenProperties(UnityEngine.RectTransform driven) { }
        private UnityEngine.Transform get_transform() { }
        private System.Boolean IsDestroyed() { }
        private System.Void StripDisabledBehavioursFromList(System.Collections.Generic.List<UnityEngine.Component> components) { }
        private System.Void ForceRebuildLayoutImmediate(UnityEngine.RectTransform layoutRoot) { }
        private System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing) { }
        private System.Void PerformLayoutControl(UnityEngine.RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action) { }
        private System.Void PerformLayoutCalculation(UnityEngine.RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action) { }
        private System.Void MarkLayoutForRebuild(UnityEngine.RectTransform rect) { }
        private System.Boolean ValidController(UnityEngine.RectTransform layoutRoot, System.Collections.Generic.List<UnityEngine.Component> comps) { }
        private System.Void MarkLayoutRootForRebuild(UnityEngine.RectTransform controller) { }
        private System.Void LayoutComplete() { }
        private System.Void GraphicUpdateComplete() { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.String ToString() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000054
    public class LayoutUtility
    {
        // Methods
        private System.Single GetMinSize(UnityEngine.RectTransform rect, System.Int32 axis) { }
        private System.Single GetPreferredSize(UnityEngine.RectTransform rect, System.Int32 axis) { }
        private System.Single GetFlexibleSize(UnityEngine.RectTransform rect, System.Int32 axis) { }
        private System.Single GetMinWidth(UnityEngine.RectTransform rect) { }
        private System.Single GetPreferredWidth(UnityEngine.RectTransform rect) { }
        private System.Single GetFlexibleWidth(UnityEngine.RectTransform rect) { }
        private System.Single GetMinHeight(UnityEngine.RectTransform rect) { }
        private System.Single GetPreferredHeight(UnityEngine.RectTransform rect) { }
        private System.Single GetFlexibleHeight(UnityEngine.RectTransform rect) { }
        private System.Single GetLayoutProperty(UnityEngine.RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement,System.Single> property, System.Single defaultValue) { }
        private System.Single GetLayoutProperty(UnityEngine.RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement,System.Single> property, System.Single defaultValue, UnityEngine.UI.ILayoutElement& source) { }

    }

    // TypeToken: 0x2000056
    public class VerticalLayoutGroup : HorizontalOrVerticalLayoutGroup
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void CalculateLayoutInputHorizontal() { }
        private System.Void CalculateLayoutInputVertical() { }
        private System.Void SetLayoutHorizontal() { }
        private System.Void SetLayoutVertical() { }

    }

    // TypeToken: 0x2000057
    public class Mask : UIBehaviour, ICanvasRaycastFilter, IMaterialModifier
    {
        // Fields
        private UnityEngine.RectTransform m_RectTransform;        // 0x18
        private System.Boolean m_ShowMaskGraphic;        // 0x20
        private UnityEngine.UI.Graphic m_Graphic;        // 0x28
        private UnityEngine.Material m_MaskMaterial;        // 0x30
        private UnityEngine.Material m_UnmaskMaterial;        // 0x38

        // Methods
        private UnityEngine.RectTransform get_rectTransform() { }
        private System.Boolean get_showMaskGraphic() { }
        private System.Void set_showMaskGraphic(System.Boolean value) { }
        private UnityEngine.UI.Graphic get_graphic() { }
        private System.Void .ctor() { }
        private System.Boolean MaskEnabled() { }
        private System.Void OnSiblingGraphicEnabledDisabled() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Boolean IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera) { }
        private UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial) { }

    }

    // TypeToken: 0x2000058
    public class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier
    {
        // Fields
        protected System.Boolean m_ShouldRecalculateStencil;        // 0xB0
        protected UnityEngine.Material m_MaskMaterial;        // 0xB8
        private UnityEngine.UI.RectMask2D m_ParentMask;        // 0xC0
        private System.Boolean m_Maskable;        // 0xC8
        private System.Boolean m_IsMaskingGraphic;        // 0xC9
        protected System.Boolean m_IncludeForMasking;        // 0xCA
        private UnityEngine.UI.MaskableGraphic.CullStateChangedEvent m_OnCullStateChanged;        // 0xD0
        protected System.Boolean m_ShouldRecalculate;        // 0xD8
        protected System.Int32 m_StencilValue;        // 0xDC
        private readonly UnityEngine.Vector3[] m_Corners;        // 0xE0

        // Methods
        private UnityEngine.UI.MaskableGraphic.CullStateChangedEvent get_onCullStateChanged() { }
        private System.Void set_onCullStateChanged(UnityEngine.UI.MaskableGraphic.CullStateChangedEvent value) { }
        private System.Boolean get_maskable() { }
        private System.Void set_maskable(System.Boolean value) { }
        private System.Boolean get_isMaskingGraphic() { }
        private System.Void set_isMaskingGraphic(System.Boolean value) { }
        private UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial) { }
        private System.Void Cull(UnityEngine.Rect clipRect, System.Boolean validRect) { }
        private System.Void UpdateCull(System.Boolean cull) { }
        private System.Void SetClipRect(UnityEngine.Rect clipRect, System.Boolean validRect) { }
        private System.Void SetClipSoftness(UnityEngine.Vector2 clipSoftness) { }
        private System.Void SetHGClipSoftness(UnityEngine.Vector4 hgClipSoftness) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnTransformParentChanged() { }
        private System.Void ParentMaskStateChanged() { }
        private System.Void OnCanvasHierarchyChanged() { }
        private UnityEngine.Rect get_rootCanvasRect() { }
        private System.Void UpdateClipParent() { }
        private System.Void RecalculateClipping() { }
        private System.Void RecalculateMasking() { }
        private System.Void .ctor() { }
        private UnityEngine.GameObject UnityEngine.UI.IClippable.get_gameObject() { }

    }

    // TypeToken: 0x200005A
    public class MaskUtilities
    {
        // Methods
        private System.Void Notify2DMaskStateChanged(UnityEngine.Component mask) { }
        private System.Void NotifyStencilStateChanged(UnityEngine.Component mask) { }
        private UnityEngine.Transform FindRootSortOverrideCanvas(UnityEngine.Transform start) { }
        private System.Int32 GetStencilDepth(UnityEngine.Transform transform, UnityEngine.Transform stopAfter) { }
        private System.Boolean IsDescendantOrSelf(UnityEngine.Transform father, UnityEngine.Transform child) { }
        private UnityEngine.UI.RectMask2D GetRectMaskForClippable(UnityEngine.UI.IClippable clippable) { }
        private System.Void GetRectMasksForClip(UnityEngine.UI.RectMask2D clipper, System.Collections.Generic.List<UnityEngine.UI.RectMask2D> masks) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005B
    public interface IMaterialModifier
    {
        // Methods
        private UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial) { }

    }

    // TypeToken: 0x200005C
    public class Misc
    {
        // Methods
        private System.Void Destroy(UnityEngine.Object obj) { }
        private System.Void DestroyImmediate(UnityEngine.Object obj) { }

    }

    // TypeToken: 0x200005D
    public class MultipleDisplayUtilities
    {
        // Methods
        private System.Boolean GetRelativeMousePositionForDrag(UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.Vector2& position) { }
        private UnityEngine.Vector3 RelativeMouseAtScaled(UnityEngine.Vector2 position) { }

    }

    // TypeToken: 0x200005E
    public struct Navigation, IEquatable`1
    {
        // Fields
        private UnityEngine.UI.Navigation.Mode m_Mode;        // 0x10
        private System.Boolean m_WrapAround;        // 0x14
        private UnityEngine.UI.Selectable m_SelectOnUp;        // 0x18
        private UnityEngine.UI.Selectable m_SelectOnDown;        // 0x20
        private UnityEngine.UI.Selectable m_SelectOnLeft;        // 0x28
        private UnityEngine.UI.Selectable m_SelectOnRight;        // 0x30

        // Methods
        private UnityEngine.UI.Navigation.Mode get_mode() { }
        private System.Void set_mode(UnityEngine.UI.Navigation.Mode value) { }
        private System.Boolean get_wrapAround() { }
        private System.Void set_wrapAround(System.Boolean value) { }
        private UnityEngine.UI.Selectable get_selectOnUp() { }
        private System.Void set_selectOnUp(UnityEngine.UI.Selectable value) { }
        private UnityEngine.UI.Selectable get_selectOnDown() { }
        private System.Void set_selectOnDown(UnityEngine.UI.Selectable value) { }
        private UnityEngine.UI.Selectable get_selectOnLeft() { }
        private System.Void set_selectOnLeft(UnityEngine.UI.Selectable value) { }
        private UnityEngine.UI.Selectable get_selectOnRight() { }
        private System.Void set_selectOnRight(UnityEngine.UI.Selectable value) { }
        private UnityEngine.UI.Navigation get_defaultNavigation() { }
        private System.Boolean Equals(UnityEngine.UI.Navigation other) { }

    }

    // TypeToken: 0x2000060
    public class RawImage : MaskableGraphic
    {
        // Fields
        private UnityEngine.Texture m_Texture;        // 0xE8
        private UnityEngine.Rect m_UVRect;        // 0xF0

        // Methods
        private System.Void .ctor() { }
        private UnityEngine.Texture get_mainTexture() { }
        private UnityEngine.Texture get_texture() { }
        private System.Void set_texture(UnityEngine.Texture value) { }
        private UnityEngine.Rect get_uvRect() { }
        private System.Void set_uvRect(UnityEngine.Rect value) { }
        private System.Void SetNativeSize() { }
        private System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper vh) { }
        private System.Void OnDidApplyAnimationProperties() { }

    }

    // TypeToken: 0x2000061
    public class RectMask2D : UIBehaviour, IClipper, ICanvasRaycastFilter
    {
        // Fields
        private readonly UnityEngine.UI.RectangularVertexClipper m_VertexClipper;        // 0x18
        private UnityEngine.RectTransform m_RectTransform;        // 0x20
        private System.Collections.Generic.HashSet<UnityEngine.UI.MaskableGraphic> m_MaskableTargets;        // 0x28
        private System.Collections.Generic.HashSet<UnityEngine.UI.IClippable> m_ClipTargets;        // 0x30
        private System.Boolean m_ShouldRecalculateClipRects;        // 0x38
        private System.Collections.Generic.List<UnityEngine.UI.RectMask2D> m_Clippers;        // 0x40
        private UnityEngine.Rect m_LastClipRectCanvasSpace;        // 0x48
        private System.Boolean m_ForceClip;        // 0x58
        private UnityEngine.Vector4 m_Padding;        // 0x5C
        private UnityEngine.Vector2Int m_Softness;        // 0x6C
        private UnityEngine.Vector4 m_HGSoftness;        // 0x74
        private UnityEngine.Canvas m_Canvas;        // 0x88
        private UnityEngine.Vector3[] m_Corners;        // 0x90

        // Methods
        private UnityEngine.Vector4 get_padding() { }
        private System.Void set_padding(UnityEngine.Vector4 value) { }
        private UnityEngine.Vector2Int get_softness() { }
        private System.Void set_softness(UnityEngine.Vector2Int value) { }
        private UnityEngine.Vector4 get_hgSoftness() { }
        private System.Void set_hgSoftness(UnityEngine.Vector4 value) { }
        private UnityEngine.Canvas get_Canvas() { }
        private UnityEngine.Rect get_canvasRect() { }
        private UnityEngine.RectTransform get_rectTransform() { }
        private System.Void .ctor() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Boolean IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera) { }
        private UnityEngine.Rect get_rootCanvasRect() { }
        private System.Void PerformClipping() { }
        private System.Void UpdateClipSoftness() { }
        private System.Void AddClippable(UnityEngine.UI.IClippable clippable) { }
        private System.Void RemoveClippable(UnityEngine.UI.IClippable clippable) { }
        private System.Void OnTransformParentChanged() { }
        private System.Void OnCanvasHierarchyChanged() { }

    }

    // TypeToken: 0x2000062
    public class Scrollbar : Selectable, IBeginDragHandler, IEventSystemHandler, IDragHandler, IInitializePotentialDragHandler, ICanvasElement
    {
        // Fields
        private UnityEngine.RectTransform m_HandleRect;        // 0x180
        private UnityEngine.UI.Scrollbar.Direction m_Direction;        // 0x188
        private System.Single m_Value;        // 0x18C
        private System.Single m_Size;        // 0x190
        private System.Int32 m_NumberOfSteps;        // 0x194
        private UnityEngine.UI.Scrollbar.ScrollEvent m_OnValueChanged;        // 0x198
        private UnityEngine.RectTransform m_ContainerRect;        // 0x1A0
        private UnityEngine.Vector2 m_Offset;        // 0x1A8
        private UnityEngine.DrivenRectTransformTracker m_Tracker;        // 0x1B0
        private UnityEngine.Coroutine m_PointerDownRepeat;        // 0x1B8
        private System.Boolean isPointerDownAndNotDragging;        // 0x1C0
        private System.Boolean m_DelayedUpdateVisuals;        // 0x1C1

        // Methods
        private UnityEngine.RectTransform get_handleRect() { }
        private System.Void set_handleRect(UnityEngine.RectTransform value) { }
        private UnityEngine.UI.Scrollbar.Direction get_direction() { }
        private System.Void set_direction(UnityEngine.UI.Scrollbar.Direction value) { }
        private System.Void .ctor() { }
        private System.Single get_value() { }
        private System.Void set_value(System.Single value) { }
        private System.Void SetValueWithoutNotify(System.Single input) { }
        private System.Single get_size() { }
        private System.Void set_size(System.Single value) { }
        private System.Int32 get_numberOfSteps() { }
        private System.Void set_numberOfSteps(System.Int32 value) { }
        private UnityEngine.UI.Scrollbar.ScrollEvent get_onValueChanged() { }
        private System.Void set_onValueChanged(UnityEngine.UI.Scrollbar.ScrollEvent value) { }
        private System.Single get_stepSize() { }
        private System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing) { }
        private System.Void LayoutComplete() { }
        private System.Void GraphicUpdateComplete() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Update() { }
        private System.Void UpdateCachedReferences() { }
        private System.Void Set(System.Single input, System.Boolean sendCallback) { }
        private System.Void OnRectTransformDimensionsChange() { }
        private UnityEngine.UI.Scrollbar.Axis get_axis() { }
        private System.Boolean get_reverseValue() { }
        private System.Void UpdateVisuals() { }
        private System.Void UpdateDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void DoUpdateDrag(UnityEngine.Vector2 handleCorner, System.Single remainingSize) { }
        private System.Boolean MayDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Collections.IEnumerator ClickRepeat(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Collections.IEnumerator ClickRepeat(UnityEngine.Vector2 screenPosition, UnityEngine.Camera camera) { }
        private System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnMove(UnityEngine.EventSystems.AxisEventData eventData) { }
        private UnityEngine.UI.Selectable FindSelectableOnLeft() { }
        private UnityEngine.UI.Selectable FindSelectableOnRight() { }
        private UnityEngine.UI.Selectable FindSelectableOnUp() { }
        private UnityEngine.UI.Selectable FindSelectableOnDown() { }
        private System.Void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void SetDirection(UnityEngine.UI.Scrollbar.Direction direction, System.Boolean includeRectLayouts) { }
        private UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform() { }

    }

    // TypeToken: 0x2000067
    public class ScrollRect : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController
    {
        // Fields
        private UnityEngine.RectTransform m_Content;        // 0x18
        private System.Boolean m_Horizontal;        // 0x20
        private System.Boolean m_Vertical;        // 0x21
        protected UnityEngine.GameObject m_scrollEnableNode;        // 0x28
        private UnityEngine.UI.ScrollRect.MovementType m_MovementType;        // 0x30
        private System.Single m_Elasticity;        // 0x34
        private System.Boolean m_Inertia;        // 0x38
        private System.Single m_DecelerationRate;        // 0x3C
        private System.Single m_ScrollSensitivity;        // 0x40
        private UnityEngine.RectTransform m_Viewport;        // 0x48
        private UnityEngine.UI.Scrollbar m_HorizontalScrollbar;        // 0x50
        private UnityEngine.UI.Scrollbar m_VerticalScrollbar;        // 0x58
        private UnityEngine.UI.ScrollRect.ScrollbarVisibility m_HorizontalScrollbarVisibility;        // 0x60
        private UnityEngine.UI.ScrollRect.ScrollbarVisibility m_VerticalScrollbarVisibility;        // 0x64
        private System.Single m_HorizontalScrollbarSpacing;        // 0x68
        private System.Single m_VerticalScrollbarSpacing;        // 0x6C
        private UnityEngine.UI.ScrollRect.ScrollRectEvent m_OnValueChanged;        // 0x70
        public System.Boolean disableScroll;        // 0x78
        public UnityEngine.UI.ScrollRect.ScrollRectEvent OnScrollStart;        // 0x80
        public UnityEngine.UI.ScrollRect.ScrollRectEvent OnScrollEnd;        // 0x88
        private UnityEngine.Vector2 m_PointerStartLocalCursor;        // 0x90
        protected UnityEngine.Vector2 m_ContentStartPosition;        // 0x98
        private UnityEngine.RectTransform m_ViewRect;        // 0xA0
        protected UnityEngine.Bounds m_ContentBounds;        // 0xA8
        private UnityEngine.Bounds m_ViewBounds;        // 0xC0
        private UnityEngine.Vector2 m_Velocity;        // 0xD8
        protected System.Boolean m_Dragging;        // 0xE0
        protected System.Boolean m_onScrollEndCbFlag;        // 0xE1
        protected System.Boolean m_Scrolling;        // 0xE2
        private UnityEngine.Vector2 m_PrevPosition;        // 0xE4
        private UnityEngine.Bounds m_PrevContentBounds;        // 0xEC
        private UnityEngine.Bounds m_PrevViewBounds;        // 0x104
        private System.Boolean m_HasRebuiltLayout;        // 0x11C
        private System.Boolean m_HSliderExpand;        // 0x11D
        private System.Boolean m_VSliderExpand;        // 0x11E
        private System.Single m_HSliderHeight;        // 0x120
        private System.Single m_VSliderWidth;        // 0x124
        private UnityEngine.RectTransform m_Rect;        // 0x128
        private UnityEngine.RectTransform m_HorizontalScrollbarRect;        // 0x130
        private UnityEngine.RectTransform m_VerticalScrollbarRect;        // 0x138
        private UnityEngine.DrivenRectTransformTracker m_Tracker;        // 0x140
        private readonly UnityEngine.Vector3[] m_Corners;        // 0x148

        // Methods
        private UnityEngine.RectTransform get_content() { }
        private System.Void set_content(UnityEngine.RectTransform value) { }
        private System.Boolean get_horizontal() { }
        private System.Void set_horizontal(System.Boolean value) { }
        private System.Boolean get_vertical() { }
        private System.Void set_vertical(System.Boolean value) { }
        private UnityEngine.UI.ScrollRect.MovementType get_movementType() { }
        private System.Void set_movementType(UnityEngine.UI.ScrollRect.MovementType value) { }
        private System.Single get_elasticity() { }
        private System.Void set_elasticity(System.Single value) { }
        private System.Boolean get_inertia() { }
        private System.Void set_inertia(System.Boolean value) { }
        private System.Single get_decelerationRate() { }
        private System.Void set_decelerationRate(System.Single value) { }
        private System.Single get_scrollSensitivity() { }
        private System.Void set_scrollSensitivity(System.Single value) { }
        private UnityEngine.RectTransform get_viewport() { }
        private System.Void set_viewport(UnityEngine.RectTransform value) { }
        private UnityEngine.UI.Scrollbar get_horizontalScrollbar() { }
        private System.Void set_horizontalScrollbar(UnityEngine.UI.Scrollbar value) { }
        private UnityEngine.UI.Scrollbar get_verticalScrollbar() { }
        private System.Void set_verticalScrollbar(UnityEngine.UI.Scrollbar value) { }
        private UnityEngine.UI.ScrollRect.ScrollbarVisibility get_horizontalScrollbarVisibility() { }
        private System.Void set_horizontalScrollbarVisibility(UnityEngine.UI.ScrollRect.ScrollbarVisibility value) { }
        private UnityEngine.UI.ScrollRect.ScrollbarVisibility get_verticalScrollbarVisibility() { }
        private System.Void set_verticalScrollbarVisibility(UnityEngine.UI.ScrollRect.ScrollbarVisibility value) { }
        private System.Single get_horizontalScrollbarSpacing() { }
        private System.Void set_horizontalScrollbarSpacing(System.Single value) { }
        private System.Single get_verticalScrollbarSpacing() { }
        private System.Void set_verticalScrollbarSpacing(System.Single value) { }
        private UnityEngine.UI.ScrollRect.ScrollRectEvent get_onValueChanged() { }
        private System.Void set_onValueChanged(UnityEngine.UI.ScrollRect.ScrollRectEvent value) { }
        private UnityEngine.RectTransform get_viewRect() { }
        private UnityEngine.Vector2 get_velocity() { }
        private System.Void set_velocity(UnityEngine.Vector2 value) { }
        private UnityEngine.RectTransform get_rectTransform() { }
        private System.Void .ctor() { }
        private System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing) { }
        private System.Void LayoutComplete() { }
        private System.Void GraphicUpdateComplete() { }
        private System.Void UpdateCachedData() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Boolean IsActive() { }
        private System.Void EnsureLayoutHasRebuilt() { }
        private System.Void StopMovement() { }
        private System.Void OnScroll(UnityEngine.EventSystems.PointerEventData data) { }
        private System.Void _CustomSetPosOnScroll(UnityEngine.Vector2 position) { }
        private System.Void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void SetContentAnchoredPosition(UnityEngine.Vector2 position) { }
        private System.Void LateUpdate() { }
        private System.Void UpdatePrevData() { }
        private System.Void UpdateScrollbars(UnityEngine.Vector2 offset) { }
        private UnityEngine.Vector2 get_normalizedPosition() { }
        private System.Void set_normalizedPosition(UnityEngine.Vector2 value) { }
        private System.Single get_horizontalNormalizedPosition() { }
        private System.Void set_horizontalNormalizedPosition(System.Single value) { }
        private System.Single get_verticalNormalizedPosition() { }
        private System.Void set_verticalNormalizedPosition(System.Single value) { }
        private System.Void SetHorizontalNormalizedPosition(System.Single value) { }
        private System.Void SetVerticalNormalizedPosition(System.Single value) { }
        private System.Void SetNormalizedPosition(System.Single value, System.Int32 axis) { }
        private System.Single RubberDelta(System.Single overStretching, System.Single viewSize) { }
        private System.Void OnRectTransformDimensionsChange() { }
        private System.Boolean get_hScrollingNeeded() { }
        private System.Boolean get_vScrollingNeeded() { }
        private System.Void CalculateLayoutInputHorizontal() { }
        private System.Void CalculateLayoutInputVertical() { }
        private System.Single get_minWidth() { }
        private System.Single get_preferredWidth() { }
        private System.Single get_flexibleWidth() { }
        private System.Single get_minHeight() { }
        private System.Single get_preferredHeight() { }
        private System.Single get_flexibleHeight() { }
        private System.Int32 get_layoutPriority() { }
        private System.Void SetLayoutHorizontal() { }
        private System.Void SetLayoutVertical() { }
        private System.Void UpdateScrollbarVisibility() { }
        private System.Void UpdateOneScrollbarVisibility(System.Boolean xScrollingNeeded, System.Boolean xAxisEnabled, UnityEngine.UI.ScrollRect.ScrollbarVisibility scrollbarVisibility, UnityEngine.UI.Scrollbar scrollbar) { }
        private System.Void UpdateScrollbarLayout() { }
        private System.Void UpdateScrollEnableNode() { }
        private System.Void UpdateBounds() { }
        private System.Void AdjustBounds(UnityEngine.Bounds& viewBounds, UnityEngine.Vector2& contentPivot, UnityEngine.Vector3& contentSize, UnityEngine.Vector3& contentPos) { }
        private UnityEngine.Bounds GetBounds() { }
        private UnityEngine.Bounds InternalGetBounds(UnityEngine.Vector3[] corners, UnityEngine.Matrix4x4& viewWorldToLocalMatrix) { }
        private UnityEngine.Vector2 CalculateOffset(UnityEngine.Vector2 delta) { }
        private UnityEngine.Vector2 InternalCalculateOffset(UnityEngine.Bounds& viewBounds, UnityEngine.Bounds& contentBounds, System.Boolean horizontal, System.Boolean vertical, UnityEngine.UI.ScrollRect.MovementType movementType, UnityEngine.Vector2& delta) { }
        private System.Void SetDirty() { }
        private System.Void SetDirtyCaching() { }
        private UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform() { }

    }

    // TypeToken: 0x200006B
    public class Selectable : UIBehaviour, IMoveHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler
    {
        // Fields
        protected static UnityEngine.UI.Selectable[] s_Selectables;        // 0x0
        protected static System.Int32 s_SelectableCount;        // 0x8
        private System.Boolean m_EnableCalled;        // 0x18
        private UnityEngine.UI.Navigation m_Navigation;        // 0x20
        private UnityEngine.UI.Selectable.Transition m_Transition;        // 0x48
        private UnityEngine.UI.ColorBlock m_Colors;        // 0x4C
        private UnityEngine.UI.SpriteState m_SpriteState;        // 0xA8
        private UnityEngine.UI.AnimationTriggers m_AnimationTriggers;        // 0xC8
        private System.Boolean m_Interactable;        // 0xD0
        private UnityEngine.UI.Graphic m_TargetGraphic;        // 0xD8
        protected System.Boolean m_NotifyHover;        // 0xE0
        protected UnityEngine.GameObject m_HoverEnableNode;        // 0xE8
        protected System.String m_HoverAudioKey;        // 0xF0
        protected System.Boolean _enableUnityNavi;        // 0xF8
        private System.Boolean m_GroupsAllowInteraction;        // 0xF9
        protected System.Int32 m_CurrentIndex;        // 0xFC
        private System.Boolean <isPointerInside>k__BackingField;        // 0x100
        private System.Boolean <isPointerDown>k__BackingField;        // 0x101
        private System.Boolean <hasSelection>k__BackingField;        // 0x102
        private readonly System.Collections.Generic.List<UnityEngine.CanvasGroup> m_CanvasGroupCache;        // 0x108
        public static UnityEngine.Events.UnityEvent<UnityEngine.UI.Selectable,System.Boolean> onAnyHoverChange;        // 0x10
        private readonly UnityEngine.Events.UnityEvent<System.Boolean> <onHoverChange>k__BackingField;        // 0x110
        public System.Boolean enableControllerNavi;        // 0x118
        public UnityEngine.Transform overrideNaviHintRectTransform;        // 0x120
        public System.Single overrideNaviHintRectScale;        // 0x128
        public System.Boolean changeNaviHintParent;        // 0x12C
        public System.Boolean hideNaviHint;        // 0x12D
        public System.Boolean needNaviConfirmKeyHint;        // 0x12E
        public System.Boolean useExplicitNaviSelect;        // 0x12F
        public System.Boolean banExplicitOnLeft;        // 0x130
        public System.Boolean banExplicitOnRight;        // 0x131
        public System.Boolean banExplicitOnUp;        // 0x132
        public System.Boolean banExplicitOnDown;        // 0x133
        private UnityEngine.UI.Selectable m_ExplicitSelectOnLeft;        // 0x138
        private UnityEngine.UI.Selectable m_ExplicitSelectOnRight;        // 0x140
        private UnityEngine.UI.Selectable m_ExplicitSelectOnUp;        // 0x148
        private UnityEngine.UI.Selectable m_ExplicitSelectOnDown;        // 0x150
        private System.Boolean <isNaviTarget>k__BackingField;        // 0x158
        public System.Action<System.Boolean,System.Boolean,System.Boolean> onIsNaviTargetChanged;        // 0x160
        private System.Boolean <isNavigationSilent>k__BackingField;        // 0x168
        public UnityEngine.UI.SelectableNaviGroup naviGroup;        // 0x170
        private System.Boolean m_naviInited;        // 0x178

        // Methods
        private UnityEngine.UI.Selectable[] get_allSelectablesArray() { }
        private System.Int32 get_allSelectableCount() { }
        private System.Collections.Generic.List<UnityEngine.UI.Selectable> get_allSelectables() { }
        private System.Int32 AllSelectablesNoAlloc(UnityEngine.UI.Selectable[] selectables) { }
        private System.String get_hoverAudioKey() { }
        private UnityEngine.UI.Navigation get_navigation() { }
        private System.Void set_navigation(UnityEngine.UI.Navigation value) { }
        private UnityEngine.UI.Selectable.Transition get_transition() { }
        private System.Void set_transition(UnityEngine.UI.Selectable.Transition value) { }
        private UnityEngine.UI.ColorBlock get_colors() { }
        private System.Void set_colors(UnityEngine.UI.ColorBlock value) { }
        private UnityEngine.UI.SpriteState get_spriteState() { }
        private System.Void set_spriteState(UnityEngine.UI.SpriteState value) { }
        private UnityEngine.UI.AnimationTriggers get_animationTriggers() { }
        private System.Void set_animationTriggers(UnityEngine.UI.AnimationTriggers value) { }
        private UnityEngine.UI.Graphic get_targetGraphic() { }
        private System.Void set_targetGraphic(UnityEngine.UI.Graphic value) { }
        private System.Boolean get_interactable() { }
        private System.Void set_interactable(System.Boolean value) { }
        private System.Boolean get_isPointerInside() { }
        private System.Void set_isPointerInside(System.Boolean value) { }
        private System.Boolean get_isPointerDown() { }
        private System.Void set_isPointerDown(System.Boolean value) { }
        private System.Boolean get_hasSelection() { }
        private System.Void set_hasSelection(System.Boolean value) { }
        private System.Void .ctor() { }
        private UnityEngine.UI.Image get_image() { }
        private System.Void set_image(UnityEngine.UI.Image value) { }
        private UnityEngine.Animator get_animator() { }
        private System.Void Awake() { }
        private System.Void OnCanvasGroupChanged() { }
        private System.Boolean IsInteractable() { }
        private System.Void OnDidApplyAnimationProperties() { }
        private System.Void OnEnable() { }
        private System.Void OnTransformParentChanged() { }
        private System.Void OnSetProperty() { }
        private System.Void OnDisable() { }
        private System.Void OnApplicationFocus(System.Boolean hasFocus) { }
        private UnityEngine.UI.Selectable.SelectionState get_currentSelectionState() { }
        private System.Void InstantClearState() { }
        private System.Void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, System.Boolean instant) { }
        private UnityEngine.UI.Selectable FindSelectable(UnityEngine.Vector3 dir) { }
        private UnityEngine.Vector3 GetPointOnRectEdge(UnityEngine.RectTransform rect, UnityEngine.Vector2 dir) { }
        private System.Void Navigate(UnityEngine.EventSystems.AxisEventData eventData, UnityEngine.UI.Selectable sel) { }
        private UnityEngine.UI.Selectable FindSelectableOnLeft() { }
        private UnityEngine.UI.Selectable FindSelectableOnRight() { }
        private UnityEngine.UI.Selectable FindSelectableOnUp() { }
        private UnityEngine.UI.Selectable FindSelectableOnDown() { }
        private System.Void OnMove(UnityEngine.EventSystems.AxisEventData eventData) { }
        private System.Void StartColorTween(UnityEngine.Color targetColor, System.Boolean instant) { }
        private System.Void DoSpriteSwap(UnityEngine.Sprite newSprite) { }
        private System.Void TriggerAnimation(System.String triggername) { }
        private System.Boolean IsHighlighted() { }
        private System.Boolean IsPressed() { }
        private System.Void EvaluateAndTransitionToSelectionState() { }
        private System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void Select() { }
        private System.Void _RefreshHoverEnableNode(System.Boolean active) { }
        private System.Void OnInteractableChanged() { }
        private UnityEngine.Events.UnityEvent<System.Boolean> get_onHoverChange() { }
        private System.Void _NotifyIsHover(System.Boolean isHover) { }
        private System.Void OnDestroy() { }
        private System.Boolean GetMouseActionHints(System.String& clickHintTextId, System.String& longPressHintTextId) { }
        private System.Boolean get_isNaviTarget() { }
        private System.Void set_isNaviTarget(System.Boolean value) { }
        private System.Boolean get_isNavigationSilent() { }
        private System.Void set_isNavigationSilent(System.Boolean value) { }
        private System.Void SetAsNaviTarget(System.Boolean isTarget, System.Boolean silentMode, System.Boolean isGroupChanged) { }
        private System.Void OnNaviTargetEnabledAgain() { }
        private System.Void _OnSetAsNaviTarget(System.Boolean isTarget, System.Boolean silentMode) { }
        private System.Void TryFindNaviGroup() { }
        private UnityEngine.UI.SelectableNaviGroup GetLayerGroup() { }
        private System.Boolean TryFindExplicitNaviTarget(UnityEngine.UI.NaviDirection dir, UnityEngine.UI.Selectable& target) { }
        private System.Boolean banExplicitNavi(UnityEngine.UI.NaviDirection dir) { }
        private System.Void _TryRegisterOnNaviGroup() { }
        private System.Void _TryUnRegisterOnNaviGroup() { }
        private System.Void SetExplicitSelectOnLeft(UnityEngine.UI.Selectable selectable) { }
        private System.Void SetExplicitSelectOnRight(UnityEngine.UI.Selectable selectable) { }
        private System.Void SetExplicitSelectOnUp(UnityEngine.UI.Selectable selectable) { }
        private System.Void SetExplicitSelectOnDown(UnityEngine.UI.Selectable selectable) { }
        private System.Void SetExplicitSelect(UnityEngine.UI.Selectable left, UnityEngine.UI.Selectable right, UnityEngine.UI.Selectable up, UnityEngine.UI.Selectable down) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200006E
    public struct NaviDirection
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.NaviDirection None;        // 0x0
        public static UnityEngine.UI.NaviDirection Up;        // 0x0
        public static UnityEngine.UI.NaviDirection Down;        // 0x0
        public static UnityEngine.UI.NaviDirection Left;        // 0x0
        public static UnityEngine.UI.NaviDirection Right;        // 0x0

    }

    // TypeToken: 0x200006F
    public struct NaviStrategy
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.NaviStrategy Normal;        // 0x0
        public static UnityEngine.UI.NaviStrategy Strict;        // 0x0
        public static UnityEngine.UI.NaviStrategy NotInternalFirst;        // 0x0
        public static UnityEngine.UI.NaviStrategy VerticalOnlyWithInternalWrap;        // 0x0
        public static UnityEngine.UI.NaviStrategy HorizontalOnlyWithInternalWrap;        // 0x0

    }

    // TypeToken: 0x2000070
    public struct NavigationBindingType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UI.NavigationBindingType InValid;        // 0x0
        public static UnityEngine.UI.NavigationBindingType AllDirections;        // 0x0
        public static UnityEngine.UI.NavigationBindingType HorizontalOnly;        // 0x0
        public static UnityEngine.UI.NavigationBindingType VerticalOnly;        // 0x0
        public static UnityEngine.UI.NavigationBindingType ArrowAllDirections;        // 0x0
        public static UnityEngine.UI.NavigationBindingType ArrowHorizontalOnly;        // 0x0
        public static UnityEngine.UI.NavigationBindingType ArrowVerticalOnly;        // 0x0
        public static UnityEngine.UI.NavigationBindingType RightJsAllDirections;        // 0x0
        public static UnityEngine.UI.NavigationBindingType RightJsHorizontalOnly;        // 0x0
        public static UnityEngine.UI.NavigationBindingType RightJsVerticalOnly;        // 0x0
        public static UnityEngine.UI.NavigationBindingType RightJsOnlyAllDirections;        // 0x0
        public static UnityEngine.UI.NavigationBindingType RightJsOnlyHorizontalOnly;        // 0x0
        public static UnityEngine.UI.NavigationBindingType RightJsOnlyVerticalOnly;        // 0x0

    }

    // TypeToken: 0x2000071
    public class SelectableNaviGroup : MonoBehaviour
    {
        // Fields
        public System.Boolean isIsolate;        // 0x18
        public System.Boolean isLayer;        // 0x19
        public System.Boolean removeLayerOnDisable;        // 0x1A
        public UnityEngine.UI.SelectableNaviGroup parentNaviGroup;        // 0x20
        public UnityEngine.UI.NaviStrategy internalNaviStrategy;        // 0x28
        public UnityEngine.UI.NavigationBindingType navigationBindingType;        // 0x2C
        public System.Boolean enablePartner;        // 0x30
        public System.Collections.Generic.List<UnityEngine.UI.SelectableNaviGroup> naviPartnerOnUp;        // 0x38
        public System.Collections.Generic.List<UnityEngine.UI.SelectableNaviGroup> naviPartnerOnDown;        // 0x40
        public System.Collections.Generic.List<UnityEngine.UI.SelectableNaviGroup> naviPartnerOnLeft;        // 0x48
        public System.Collections.Generic.List<UnityEngine.UI.SelectableNaviGroup> naviPartnerOnRight;        // 0x50
        protected System.Boolean m_inited;        // 0x58
        protected UnityEngine.UI.Selectable m_layerSelectedTarget;        // 0x60
        public System.Collections.Generic.HashSet<UnityEngine.UI.Selectable> targets;        // 0x68
        public System.Collections.Generic.HashSet<UnityEngine.UI.SelectableNaviGroup> subGroups;        // 0x70
        public UnityEngine.Events.UnityEvent<UnityEngine.UI.Selectable> onSetLayerSelectedTarget;        // 0x78
        public UnityEngine.Events.UnityEvent<System.Boolean> onIsTopLayerChanged;        // 0x80
        public UnityEngine.Events.UnityEvent<UnityEngine.UI.NaviDirection> onDefaultNaviFailed;        // 0x88
        public UnityEngine.Events.UnityEvent onRemoveFromLayerStack;        // 0x90
        protected System.Boolean m_isTopLayer;        // 0x98

        // Methods
        private UnityEngine.UI.Selectable get_LayerSelectedTarget() { }
        private System.Void Reset() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void _Init() { }
        private System.Void TryFindParentNaviGroup() { }
        private UnityEngine.UI.SelectableNaviGroup GetLayerGroup() { }
        private System.Boolean get_IsTopLayer() { }
        private System.Void set_IsTopLayer(System.Boolean value) { }
        private System.Void SetLayerSelectedTarget(UnityEngine.UI.Selectable value, System.Boolean silentMode) { }
        private System.Void OnRemoveFromLayerStack() { }
        private System.Void _OnIsTopLayerChanged() { }
        private System.Void _OnSelectableNaviGroupInited() { }
        private System.Void _BeforeSelectableNaviGroupDestroy() { }
        private System.Void _OnSelectableNaviGroupDisabled() { }
        private System.Void _OnSetLayerSelectedTarget(UnityEngine.UI.Selectable value) { }
        private System.Void _OnRemoveFromLayerStack() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000072
    public class SetPropertyUtility
    {
        // Methods
        private System.Boolean SetColor(UnityEngine.Color& currentValue, UnityEngine.Color newValue) { }
        private System.Boolean SetStruct(T& currentValue, T newValue) { }
        private System.Boolean SetClass(T& currentValue, T newValue) { }

    }

    // TypeToken: 0x2000073
    public class Slider : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement
    {
        // Fields
        private UnityEngine.RectTransform m_FillRect;        // 0x180
        private UnityEngine.RectTransform m_HandleRect;        // 0x188
        private UnityEngine.UI.Slider.Direction m_Direction;        // 0x190
        private System.Single m_MinValue;        // 0x194
        private System.Single m_MaxValue;        // 0x198
        private System.Boolean m_WholeNumbers;        // 0x19C
        protected System.Single m_Value;        // 0x1A0
        private UnityEngine.UI.Slider.SliderEvent m_OnValueChanged;        // 0x1A8
        private UnityEngine.UI.Image m_FillImage;        // 0x1B0
        private UnityEngine.Transform m_FillTransform;        // 0x1B8
        private UnityEngine.RectTransform m_FillContainerRect;        // 0x1C0
        private UnityEngine.Transform m_HandleTransform;        // 0x1C8
        private UnityEngine.RectTransform m_HandleContainerRect;        // 0x1D0
        private UnityEngine.Vector2 m_Offset;        // 0x1D8
        private UnityEngine.DrivenRectTransformTracker m_Tracker;        // 0x1E0
        private System.Boolean m_DelayedUpdateVisuals;        // 0x1E1

        // Methods
        private UnityEngine.RectTransform get_fillRect() { }
        private System.Void set_fillRect(UnityEngine.RectTransform value) { }
        private UnityEngine.RectTransform get_handleRect() { }
        private System.Void set_handleRect(UnityEngine.RectTransform value) { }
        private UnityEngine.UI.Slider.Direction get_direction() { }
        private System.Void set_direction(UnityEngine.UI.Slider.Direction value) { }
        private System.Single get_minValue() { }
        private System.Void set_minValue(System.Single value) { }
        private System.Single get_maxValue() { }
        private System.Void set_maxValue(System.Single value) { }
        private System.Boolean get_wholeNumbers() { }
        private System.Void set_wholeNumbers(System.Boolean value) { }
        private System.Single get_value() { }
        private System.Void set_value(System.Single value) { }
        private System.Void SetValueWithoutNotify(System.Single input) { }
        private System.Single get_normalizedValue() { }
        private System.Void set_normalizedValue(System.Single value) { }
        private UnityEngine.UI.Slider.SliderEvent get_onValueChanged() { }
        private System.Void set_onValueChanged(UnityEngine.UI.Slider.SliderEvent value) { }
        private System.Single get_stepSize() { }
        private System.Void .ctor() { }
        private System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing) { }
        private System.Void LayoutComplete() { }
        private System.Void GraphicUpdateComplete() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Update() { }
        private System.Void OnDidApplyAnimationProperties() { }
        private System.Void UpdateCachedReferences() { }
        private System.Single ClampValue(System.Single input) { }
        private System.Void Set(System.Single input, System.Boolean sendCallback) { }
        private System.Void OnValueChanged() { }
        private System.Void OnClickSliderBar() { }
        private System.Void OnClickSliderHandle() { }
        private System.Void OnRectTransformDimensionsChange() { }
        private UnityEngine.UI.Slider.Axis get_axis() { }
        private System.Boolean get_reverseValue() { }
        private System.Void UpdateVisuals() { }
        private System.Void UpdateDrag(UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.Camera cam) { }
        private System.Single CustomProcessNormalizedValue(System.Single val) { }
        private System.Boolean MayDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnMove(UnityEngine.EventSystems.AxisEventData eventData) { }
        private UnityEngine.UI.Selectable FindSelectableOnLeft() { }
        private UnityEngine.UI.Selectable FindSelectableOnRight() { }
        private UnityEngine.UI.Selectable FindSelectableOnUp() { }
        private UnityEngine.UI.Selectable FindSelectableOnDown() { }
        private System.Void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void SetDirection(UnityEngine.UI.Slider.Direction direction, System.Boolean includeRectLayouts) { }
        private UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform() { }

    }

    // TypeToken: 0x2000077
    public struct SpriteState, IEquatable`1
    {
        // Fields
        private UnityEngine.Sprite m_HighlightedSprite;        // 0x10
        private UnityEngine.Sprite m_PressedSprite;        // 0x18
        private UnityEngine.Sprite m_SelectedSprite;        // 0x20
        private UnityEngine.Sprite m_DisabledSprite;        // 0x28

        // Methods
        private UnityEngine.Sprite get_highlightedSprite() { }
        private System.Void set_highlightedSprite(UnityEngine.Sprite value) { }
        private UnityEngine.Sprite get_pressedSprite() { }
        private System.Void set_pressedSprite(UnityEngine.Sprite value) { }
        private UnityEngine.Sprite get_selectedSprite() { }
        private System.Void set_selectedSprite(UnityEngine.Sprite value) { }
        private UnityEngine.Sprite get_disabledSprite() { }
        private System.Void set_disabledSprite(UnityEngine.Sprite value) { }
        private System.Boolean Equals(UnityEngine.UI.SpriteState other) { }

    }

    // TypeToken: 0x2000078
    public class StencilMaterial
    {
        // Fields
        private static System.Collections.Generic.List<UnityEngine.UI.StencilMaterial.MatEntry> m_List;        // 0x0
        private static System.Boolean s_EnableStencilMaterialWarning;        // 0x8

        // Methods
        private UnityEngine.Material Add(UnityEngine.Material baseMat, System.Int32 stencilID) { }
        private UnityEngine.Material Add(UnityEngine.Material baseMat, System.Int32 stencilID, UnityEngine.Rendering.StencilOp operation, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.ColorWriteMask colorWriteMask) { }
        private System.Void LogWarningWhenNotInBatchmode(System.String warning, UnityEngine.Object context) { }
        private UnityEngine.Material Add(UnityEngine.Material baseMat, System.Int32 stencilID, UnityEngine.Rendering.StencilOp operation, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.ColorWriteMask colorWriteMask, System.Int32 readMask, System.Int32 writeMask) { }
        private System.Void Remove(UnityEngine.Material customMat) { }
        private System.Void ClearAll() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200007A
    public class Text : MaskableGraphic, ILayoutElement
    {
        // Fields
        private UnityEngine.UI.FontData m_FontData;        // 0xE8
        protected System.String m_Text;        // 0xF0
        private UnityEngine.TextGenerator m_TextCache;        // 0xF8
        private UnityEngine.TextGenerator m_TextCacheForLayout;        // 0x100
        protected static UnityEngine.Material s_DefaultText;        // 0x0
        protected System.Boolean m_DisableFontTextureRebuiltCallback;        // 0x108
        private readonly UnityEngine.UIVertex[] m_TempVerts;        // 0x110

        // Methods
        private System.Void .ctor() { }
        private UnityEngine.TextGenerator get_cachedTextGenerator() { }
        private UnityEngine.TextGenerator get_cachedTextGeneratorForLayout() { }
        private UnityEngine.Texture get_mainTexture() { }
        private System.Void FontTextureChanged() { }
        private UnityEngine.Font get_font() { }
        private System.Void set_font(UnityEngine.Font value) { }
        private System.String get_text() { }
        private System.Void set_text(System.String value) { }
        private System.Boolean get_supportRichText() { }
        private System.Void set_supportRichText(System.Boolean value) { }
        private System.Boolean get_resizeTextForBestFit() { }
        private System.Void set_resizeTextForBestFit(System.Boolean value) { }
        private System.Int32 get_resizeTextMinSize() { }
        private System.Void set_resizeTextMinSize(System.Int32 value) { }
        private System.Int32 get_resizeTextMaxSize() { }
        private System.Void set_resizeTextMaxSize(System.Int32 value) { }
        private UnityEngine.TextAnchor get_alignment() { }
        private System.Void set_alignment(UnityEngine.TextAnchor value) { }
        private System.Boolean get_alignByGeometry() { }
        private System.Void set_alignByGeometry(System.Boolean value) { }
        private System.Int32 get_fontSize() { }
        private System.Void set_fontSize(System.Int32 value) { }
        private UnityEngine.HorizontalWrapMode get_horizontalOverflow() { }
        private System.Void set_horizontalOverflow(UnityEngine.HorizontalWrapMode value) { }
        private UnityEngine.VerticalWrapMode get_verticalOverflow() { }
        private System.Void set_verticalOverflow(UnityEngine.VerticalWrapMode value) { }
        private System.Single get_lineSpacing() { }
        private System.Void set_lineSpacing(System.Single value) { }
        private UnityEngine.FontStyle get_fontStyle() { }
        private System.Void set_fontStyle(UnityEngine.FontStyle value) { }
        private System.Single get_pixelsPerUnit() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void UpdateGeometry() { }
        private System.Void AssignDefaultFont() { }
        private System.Void AssignDefaultFontIfNecessary() { }
        private UnityEngine.TextGenerationSettings GetGenerationSettings(UnityEngine.Vector2 extents) { }
        private UnityEngine.Vector2 GetTextAnchorPivot(UnityEngine.TextAnchor anchor) { }
        private System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper toFill) { }
        private System.Void CalculateLayoutInputHorizontal() { }
        private System.Void CalculateLayoutInputVertical() { }
        private System.Single get_minWidth() { }
        private System.Single get_preferredWidth() { }
        private System.Single get_flexibleWidth() { }
        private System.Single get_minHeight() { }
        private System.Single get_preferredHeight() { }
        private System.Single get_flexibleHeight() { }
        private System.Int32 get_layoutPriority() { }

    }

    // TypeToken: 0x200007B
    public class Toggle : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICanvasElement
    {
        // Fields
        public UnityEngine.UI.Toggle.ToggleTransition toggleTransition;        // 0x180
        public UnityEngine.UI.Graphic graphic;        // 0x188
        private UnityEngine.UI.ToggleGroup m_Group;        // 0x190
        public UnityEngine.UI.Toggle.ToggleEvent onValueChanged;        // 0x198
        private System.Boolean m_IsOn;        // 0x1A0

        // Methods
        private UnityEngine.UI.ToggleGroup get_group() { }
        private System.Void set_group(UnityEngine.UI.ToggleGroup value) { }
        private System.Void .ctor() { }
        private System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing) { }
        private System.Void LayoutComplete() { }
        private System.Void GraphicUpdateComplete() { }
        private System.Void OnDestroy() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDidApplyAnimationProperties() { }
        private System.Void SetToggleGroup(UnityEngine.UI.ToggleGroup newGroup, System.Boolean setMemberValue) { }
        private System.Boolean get_isOn() { }
        private System.Void set_isOn(System.Boolean value) { }
        private System.Void SetIsOnWithoutNotify(System.Boolean value) { }
        private System.Void Set(System.Boolean value, System.Boolean sendCallback) { }
        private System.Void PlayEffect(System.Boolean instant) { }
        private System.Void Start() { }
        private System.Void InternalToggle() { }
        private System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void OnValueChange() { }
        private UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform() { }

    }

    // TypeToken: 0x200007E
    public class ToggleGroup : UIBehaviour
    {
        // Fields
        private System.Boolean m_AllowSwitchOff;        // 0x18
        protected System.Collections.Generic.List<UnityEngine.UI.Toggle> m_Toggles;        // 0x20

        // Methods
        private System.Boolean get_allowSwitchOff() { }
        private System.Void set_allowSwitchOff(System.Boolean value) { }
        private System.Void .ctor() { }
        private System.Void Start() { }
        private System.Void OnEnable() { }
        private System.Void ValidateToggleIsInGroup(UnityEngine.UI.Toggle toggle) { }
        private System.Void NotifyToggleOn(UnityEngine.UI.Toggle toggle, System.Boolean sendCallback) { }
        private System.Void UnregisterToggle(UnityEngine.UI.Toggle toggle) { }
        private System.Void RegisterToggle(UnityEngine.UI.Toggle toggle) { }
        private System.Void EnsureValidState() { }
        private System.Boolean AnyTogglesOn() { }
        private System.Collections.Generic.IEnumerable<UnityEngine.UI.Toggle> ActiveToggles() { }
        private UnityEngine.UI.Toggle GetFirstActiveToggle() { }
        private System.Void SetAllTogglesOff(System.Boolean sendCallback) { }

    }

    // TypeToken: 0x2000080
    public class ReflectionMethodsCache
    {
        // Fields
        public UnityEngine.UI.ReflectionMethodsCache.Raycast3DCallback raycast3D;        // 0x10
        public UnityEngine.UI.ReflectionMethodsCache.RaycastAllCallback raycast3DAll;        // 0x18
        public UnityEngine.UI.ReflectionMethodsCache.GetRaycastNonAllocCallback getRaycastNonAlloc;        // 0x20
        public UnityEngine.UI.ReflectionMethodsCache.Raycast2DCallback raycast2D;        // 0x28
        public UnityEngine.UI.ReflectionMethodsCache.GetRayIntersectionAllCallback getRayIntersectionAll;        // 0x30
        public UnityEngine.UI.ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback getRayIntersectionAllNonAlloc;        // 0x38
        private static UnityEngine.UI.ReflectionMethodsCache s_ReflectionMethodsCache;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private UnityEngine.UI.ReflectionMethodsCache get_Singleton() { }

    }

    // TypeToken: 0x2000087
    public class VertexHelper, IDisposable
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.Vector3> m_Positions;        // 0x10
        private System.Collections.Generic.List<UnityEngine.Color32> m_Colors;        // 0x18
        private System.Collections.Generic.List<UnityEngine.Vector4> m_Uv0S;        // 0x20
        private System.Collections.Generic.List<UnityEngine.Vector4> m_Uv1S;        // 0x28
        private System.Collections.Generic.List<UnityEngine.Vector4> m_Uv2S;        // 0x30
        private System.Collections.Generic.List<UnityEngine.Vector4> m_Uv3S;        // 0x38
        private System.Collections.Generic.List<UnityEngine.Vector3> m_Normals;        // 0x40
        private System.Collections.Generic.List<UnityEngine.Vector4> m_Tangents;        // 0x48
        private System.Collections.Generic.List<System.Int32> m_Indices;        // 0x50
        private static readonly UnityEngine.Vector4 s_DefaultTangent;        // 0x0
        private static readonly UnityEngine.Vector3 s_DefaultNormal;        // 0x10
        private System.Boolean m_ListsInitalized;        // 0x58

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.Mesh m) { }
        private System.Void InitializeListIfRequired() { }
        private System.Void Dispose() { }
        private System.Void Clear() { }
        private System.Int32 get_currentVertCount() { }
        private System.Int32 get_currentIndexCount() { }
        private System.Void PopulateUIVertex(UnityEngine.UIVertex& vertex, System.Int32 i) { }
        private System.Void SetUIVertex(UnityEngine.UIVertex vertex, System.Int32 i) { }
        private System.Void FillMesh(UnityEngine.Mesh mesh) { }
        private System.Void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0, UnityEngine.Vector4 uv1, UnityEngine.Vector4 uv2, UnityEngine.Vector4 uv3, UnityEngine.Vector3 normal, UnityEngine.Vector4 tangent) { }
        private System.Void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0, UnityEngine.Vector4 uv1, UnityEngine.Vector3 normal, UnityEngine.Vector4 tangent) { }
        private System.Void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0) { }
        private System.Void AddVert(UnityEngine.UIVertex v) { }
        private System.Void AddTriangle(System.Int32 idx0, System.Int32 idx1, System.Int32 idx2) { }
        private System.Void AddUIVertexQuad(UnityEngine.UIVertex[] verts) { }
        private System.Void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<System.Int32> indices) { }
        private System.Void AddUIVertexTriangleStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts) { }
        private System.Void GetUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> stream) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000088
    public class BaseVertexEffect
    {
        // Methods
        private System.Void ModifyVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000089
    public class BaseMeshEffect : UIBehaviour, IMeshModifier
    {
        // Fields
        private UnityEngine.UI.Graphic m_Graphic;        // 0x18

        // Methods
        private UnityEngine.UI.Graphic get_graphic() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDidApplyAnimationProperties() { }
        private System.Void ModifyMesh(UnityEngine.Mesh mesh) { }
        private System.Void ModifyMesh(UnityEngine.UI.VertexHelper vh) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008A
    public interface IVertexModifier
    {
        // Methods
        private System.Void ModifyVertices(System.Collections.Generic.List<UnityEngine.UIVertex> verts) { }

    }

    // TypeToken: 0x200008B
    public interface IMeshModifier
    {
        // Methods
        private System.Void ModifyMesh(UnityEngine.Mesh mesh) { }
        private System.Void ModifyMesh(UnityEngine.UI.VertexHelper verts) { }

    }

    // TypeToken: 0x200008C
    public class Outline : Shadow
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void ModifyMesh(UnityEngine.UI.VertexHelper vh) { }

    }

    // TypeToken: 0x200008D
    public class PositionAsUV1 : BaseMeshEffect
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void ModifyMesh(UnityEngine.UI.VertexHelper vh) { }

    }

    // TypeToken: 0x200008E
    public class Shadow : BaseMeshEffect
    {
        // Fields
        private UnityEngine.Color m_EffectColor;        // 0x20
        private UnityEngine.Vector2 m_EffectDistance;        // 0x30
        private System.Boolean m_UseGraphicAlpha;        // 0x38
        private static System.Single kMaxEffectDistance;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private UnityEngine.Color get_effectColor() { }
        private System.Void set_effectColor(UnityEngine.Color value) { }
        private UnityEngine.Vector2 get_effectDistance() { }
        private System.Void set_effectDistance(UnityEngine.Vector2 value) { }
        private System.Boolean get_useGraphicAlpha() { }
        private System.Void set_useGraphicAlpha(System.Boolean value) { }
        private System.Void ApplyShadowZeroAlloc(System.Collections.Generic.List<UnityEngine.UIVertex> verts, UnityEngine.Color32 color, System.Int32 start, System.Int32 end, System.Single x, System.Single y) { }
        private System.Void ApplyShadow(System.Collections.Generic.List<UnityEngine.UIVertex> verts, UnityEngine.Color32 color, System.Int32 start, System.Int32 end, System.Single x, System.Single y) { }
        private System.Void ModifyMesh(UnityEngine.UI.VertexHelper vh) { }

    }

}

namespace UnityEngine.UI.Collections
{

    // TypeToken: 0x200008F
    public class IndexedSet`1, IList`1, ICollection`1, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly System.Collections.Generic.List<T> m_List;        // 0x0
        private System.Collections.Generic.Dictionary<T,System.Int32> m_Dictionary;        // 0x0

        // Methods
        private System.Void Add(T item) { }
        private System.Boolean AddUnique(T item) { }
        private System.Boolean Remove(T item) { }
        private System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void Clear() { }
        private System.Boolean Contains(T item) { }
        private System.Void CopyTo(T[] array, System.Int32 arrayIndex) { }
        private System.Int32 get_Count() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Int32 IndexOf(T item) { }
        private System.Void Insert(System.Int32 index, T item) { }
        private System.Void RemoveAt(System.Int32 index) { }
        private T get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, T value) { }
        private System.Void RemoveAll(System.Predicate<T> match) { }
        private System.Void Sort(System.Comparison<T> sortLayoutFunction) { }
        private System.Void .ctor() { }

    }

}

namespace UnityEngine.UI.CoroutineTween
{

    // TypeToken: 0x2000090
    public interface ITweenValue
    {
        // Methods
        private System.Void TweenValue(System.Single floatPercentage) { }
        private System.Boolean get_ignoreTimeScale() { }
        private System.Single get_duration() { }
        private System.Boolean ValidTarget() { }

    }

    // TypeToken: 0x2000091
    public struct ColorTween, ITweenValue
    {
        // Fields
        private UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenCallback m_Target;        // 0x10
        private UnityEngine.Color m_StartColor;        // 0x18
        private UnityEngine.Color m_TargetColor;        // 0x28
        private UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode m_TweenMode;        // 0x38
        private System.Single m_Duration;        // 0x3C
        private System.Boolean m_IgnoreTimeScale;        // 0x40

        // Methods
        private UnityEngine.Color get_startColor() { }
        private System.Void set_startColor(UnityEngine.Color value) { }
        private UnityEngine.Color get_targetColor() { }
        private System.Void set_targetColor(UnityEngine.Color value) { }
        private UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode get_tweenMode() { }
        private System.Void set_tweenMode(UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode value) { }
        private System.Single get_duration() { }
        private System.Void set_duration(System.Single value) { }
        private System.Boolean get_ignoreTimeScale() { }
        private System.Void set_ignoreTimeScale(System.Boolean value) { }
        private System.Void TweenValue(System.Single floatPercentage) { }
        private System.Void AddOnChangedCallback(UnityEngine.Events.UnityAction<UnityEngine.Color> callback) { }
        private System.Boolean GetIgnoreTimescale() { }
        private System.Single GetDuration() { }
        private System.Boolean ValidTarget() { }

    }

    // TypeToken: 0x2000094
    public struct FloatTween, ITweenValue
    {
        // Fields
        private UnityEngine.UI.CoroutineTween.FloatTween.FloatTweenCallback m_Target;        // 0x10
        private System.Single m_StartValue;        // 0x18
        private System.Single m_TargetValue;        // 0x1C
        private System.Single m_Duration;        // 0x20
        private System.Boolean m_IgnoreTimeScale;        // 0x24

        // Methods
        private System.Single get_startValue() { }
        private System.Void set_startValue(System.Single value) { }
        private System.Single get_targetValue() { }
        private System.Void set_targetValue(System.Single value) { }
        private System.Single get_duration() { }
        private System.Void set_duration(System.Single value) { }
        private System.Boolean get_ignoreTimeScale() { }
        private System.Void set_ignoreTimeScale(System.Boolean value) { }
        private System.Void TweenValue(System.Single floatPercentage) { }
        private System.Void AddOnChangedCallback(UnityEngine.Events.UnityAction<System.Single> callback) { }
        private System.Boolean GetIgnoreTimescale() { }
        private System.Single GetDuration() { }
        private System.Boolean ValidTarget() { }

    }

    // TypeToken: 0x2000096
    public class TweenRunner`1
    {
        // Fields
        protected UnityEngine.MonoBehaviour m_CoroutineContainer;        // 0x0
        protected System.Collections.IEnumerator m_Tween;        // 0x0

        // Methods
        private System.Collections.IEnumerator Start(T tweenInfo) { }
        private System.Void Init(UnityEngine.MonoBehaviour coroutineContainer) { }
        private System.Void StartTween(T info) { }
        private System.Void StopTween() { }
        private System.Void .ctor() { }

    }

}

namespace UnityEngine.UIElements
{

    // TypeToken: 0x2000098
    public class PanelEventHandler : UIBehaviour, IPointerMoveHandler, IEventSystemHandler, IPointerUpHandler, IPointerDownHandler, ISubmitHandler, ICancelHandler, IMoveHandler, IScrollHandler, ISelectHandler, IDeselectHandler, IPointerExitHandler, IPointerEnterHandler, IRuntimePanelComponent
    {
        // Fields
        private UnityEngine.UIElements.BaseRuntimePanel m_Panel;        // 0x18
        private readonly UnityEngine.UIElements.PanelEventHandler.PointerEvent m_PointerEvent;        // 0x20
        private System.Boolean m_Selecting;        // 0x28
        private UnityEngine.Event m_Event;        // 0x30
        private static UnityEngine.EventModifiers s_Modifiers;        // 0x0

        // Methods
        private UnityEngine.UIElements.IPanel get_panel() { }
        private System.Void set_panel(UnityEngine.UIElements.IPanel value) { }
        private UnityEngine.GameObject get_selectableGameObject() { }
        private UnityEngine.EventSystems.EventSystem get_eventSystem() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void RegisterCallbacks() { }
        private System.Void UnregisterCallbacks() { }
        private System.Void OnPanelDestroyed() { }
        private System.Void OnElementFocus(UnityEngine.UIElements.FocusEvent e) { }
        private System.Void OnElementBlur(UnityEngine.UIElements.BlurEvent e) { }
        private System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void OnPointerMove(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void OnCancel(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void OnMove(UnityEngine.EventSystems.AxisEventData eventData) { }
        private System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.EventSystems.BaseEventData sourceEventData) { }
        private System.Void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.Event sourceEvent) { }
        private System.Void Update() { }
        private System.Void LateUpdate() { }
        private System.Void ProcessImguiEvents(System.Boolean isSelected) { }
        private System.Void ProcessKeyboardEvent(UnityEngine.Event e) { }
        private System.Void ProcessTabEvent(UnityEngine.Event e) { }
        private System.Void SendTabEvent(UnityEngine.Event e, System.Int32 direction) { }
        private System.Void SendKeyUpEvent(UnityEngine.Event e, UnityEngine.KeyCode keyCode, UnityEngine.EventModifiers modifiers) { }
        private System.Void SendKeyDownEvent(UnityEngine.Event e, UnityEngine.KeyCode keyCode, UnityEngine.EventModifiers modifiers) { }
        private System.Void SendTextEvent(UnityEngine.Event e, System.Char c, UnityEngine.EventModifiers modifiers) { }
        private System.Boolean ReadPointerData(UnityEngine.UIElements.PanelEventHandler.PointerEvent pe, UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.UIElements.PanelEventHandler.PointerEventType eventType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009B
    public class PanelRaycaster : BaseRaycaster, IRuntimePanelComponent
    {
        // Fields
        private UnityEngine.UIElements.BaseRuntimePanel m_Panel;        // 0x20

        // Methods
        private UnityEngine.UIElements.IPanel get_panel() { }
        private System.Void set_panel(UnityEngine.UIElements.IPanel value) { }
        private System.Void RegisterCallbacks() { }
        private System.Void UnregisterCallbacks() { }
        private System.Void OnPanelDestroyed() { }
        private UnityEngine.GameObject get_selectableGameObject() { }
        private System.Int32 get_sortOrderPriority() { }
        private System.Int32 get_renderOrderPriority() { }
        private System.Void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }
        private UnityEngine.Camera get_eventCamera() { }
        private System.Int32 ConvertFloatBitsToInt(System.Single f) { }
        private System.Void .ctor() { }

    }

}

