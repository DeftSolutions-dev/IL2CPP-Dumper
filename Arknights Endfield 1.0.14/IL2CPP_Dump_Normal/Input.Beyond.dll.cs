// ========================================================
// Dumped by @desirepro
// Assembly: Input.Beyond.dll
// Classes:  70
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000004
    public struct CursorMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.UI.DebugVirtualMouseInput.CursorMode SoftwareCursor;        // 0x0
        public static UnityEngine.InputSystem.UI.DebugVirtualMouseInput.CursorMode HardwareCursorIfAvailable;        // 0x0

    }

    // TypeToken: 0x2000012
    public class Binding
    {
        // Fields
        public Beyond.Input.InputBindingInfo info;        // 0x10
        public System.Single pressDownTime;        // 0x18
        public System.Boolean isUsedForBlock;        // 0x1C
        public System.Int32 longPressTimerId;        // 0x20
        public System.Single longPressTime;        // 0x24
        public System.Boolean enableContinuousTrigger;        // 0x28
        public Beyond.Input.InputContinuousTriggerType continuousTriggerType;        // 0x2C

        // Methods
        private System.Void .ctor(Beyond.Input.GamepadInput input, Beyond.Input.InputBindingInfo info, System.Boolean isUsedForBlock) { }

    }

    // TypeToken: 0x200001A
    public class CursorSpeedPhase
    {
        // Fields
        public System.Single maxJsValue;        // 0x10
        public System.Single minSpeed;        // 0x14
        public System.Single maxSpeed;        // 0x18
        public System.Single acceleration;        // 0x1C
        public System.Single accelerationSpeed;        // 0x20
        public System.Single maxAcceleration;        // 0x24

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000025
    public class KeyCaches
    {
        // Fields
        public System.Boolean escapeKeyDown;        // 0x10
        public System.Boolean mouse0KeyDown;        // 0x11
        public System.Boolean mouse1KeyDown;        // 0x12
        public System.Boolean escapeKeyUp;        // 0x13
        public System.Boolean mouse0KeyUp;        // 0x14
        public System.Boolean mouse1KeyUp;        // 0x15
        public System.Boolean escapeKey;        // 0x16
        public System.Boolean mouse0Key;        // 0x17
        public System.Boolean mouse1Key;        // 0x18

        // Methods
        private System.Void UpdateKeyStat() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000026
    public struct KeyCodeState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Input.InputManager.KeyCodeState Pressed;        // 0x0
        public static Beyond.Input.InputManager.KeyCodeState OnPress;        // 0x0
        public static Beyond.Input.InputManager.KeyCodeState OnRelease;        // 0x0

    }

    // TypeToken: 0x2000027
    public class ControllerHintInfo, IComparable`1, IReusable
    {
        // Fields
        public System.String actionId;        // 0x10
        public System.Int32 priority;        // 0x18
        public Beyond.Input.InputBindingInfo bind;        // 0x20
        public Beyond.Input.IBindingView hintView;        // 0x28

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(Beyond.Input.IBindingView hintView, Beyond.Input.InputBindingInfo bind) { }
        private System.Void .ctor(System.String actionId) { }
        private System.Void Reset(Beyond.Input.IBindingView newHintView, Beyond.Input.InputBindingInfo newBind) { }
        private System.Void Reset(System.String resetActionId) { }
        private System.Int32 CompareTo(Beyond.Input.InputManager.ControllerHintInfo other) { }
        private System.Void OnAllocate() { }
        private System.Void OnRecycle() { }

    }

    // TypeToken: 0x2000028
    public struct SkillButtonState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Input.InputManager.SkillButtonState None;        // 0x0
        public static Beyond.Input.InputManager.SkillButtonState JustPressed;        // 0x0

    }

    // TypeToken: 0x2000030
    public class Binding
    {
        // Fields
        public Beyond.Input.InputBindingInfo info;        // 0x10
        public System.Single pressDownTime;        // 0x18
        public System.Boolean isUsedForBlock;        // 0x1C
        public System.Int32 longPressTimerId;        // 0x20
        public System.Single longPressTime;        // 0x24
        public System.Boolean enableContinuousTrigger;        // 0x28
        public Beyond.Input.InputContinuousTriggerType continuousTriggerType;        // 0x2C

        // Methods
        private System.Void .ctor(Beyond.Input.KeyboardInput input, Beyond.Input.InputBindingInfo info, System.Boolean isUsedForBlock) { }

    }

    // TypeToken: 0x2000042
    public struct __StaticArrayInitTypeSize=32
    {
    }

namespace Beyond.Input
{

    // TypeToken: 0x2000009
    public class ControllerNaviManager
    {
        // Fields
        public System.Collections.Generic.LinkedList<UnityEngine.UI.SelectableNaviGroup> layerStackList;        // 0x10
        public UnityEngine.UI.Selectable curTarget;        // 0x18
        private readonly System.Collections.Generic.HashSet<System.String> m_naviLockSet;        // 0x20
        private System.Int32 m_targetInputBindingGroupId;        // 0x28
        private System.Int32 m_naviInputBindingGroupId;        // 0x2C
        private UnityEngine.UI.Selectable m_lastEnableNaviTarget;        // 0x30
        private UnityEngine.UI.NavigationBindingType <navigationBindingType>k__BackingField;        // 0x38
        private System.Collections.Generic.Dictionary<UnityEngine.UI.NavigationBindingType,System.Int32> m_naviBindingGroupIds;        // 0x40
        private Beyond.Input.InputManager m_inputManager;        // 0x48
        private static System.Single SCORE_OFFSET;        // 0x0
        private System.Boolean <forceEnableNaviForGuide>k__BackingField;        // 0x50

        // Methods
        private UnityEngine.UI.NavigationBindingType get_navigationBindingType() { }
        private System.Void set_navigationBindingType(UnityEngine.UI.NavigationBindingType value) { }
        private System.Void .ctor(Beyond.Input.InputManager inputManager) { }
        private System.Void SetNaviBindingType(UnityEngine.UI.NavigationBindingType bindingType) { }
        private System.Void Tick() { }
        private System.Boolean _RemoveLayer(UnityEngine.UI.SelectableNaviGroup group, UnityEngine.UI.SelectableNaviGroup curLayer) { }
        private System.Void _RemoveLayerFromStack(UnityEngine.UI.SelectableNaviGroup group, System.Boolean silentMode) { }
        private System.Void _SetTarget(UnityEngine.UI.Selectable target) { }
        private System.Void _OnLayerSelected(UnityEngine.UI.SelectableNaviGroup topLayer) { }
        private System.Boolean _DefaultNavigate(UnityEngine.UI.NaviDirection dir) { }
        private UnityEngine.UI.Selectable _TryFindBestNaviTargetInGroup(UnityEngine.UI.SelectableNaviGroup group, UnityEngine.Vector3 pos, UnityEngine.Vector3 dir, System.Double curMaxScore, System.Double& maxScore) { }
        private UnityEngine.UI.Selectable _TryFindBestNaviTarget(System.Collections.Generic.HashSet<UnityEngine.UI.Selectable> targets, UnityEngine.Vector3 curPos, UnityEngine.Vector3 dir, UnityEngine.UI.NaviStrategy strategy, System.Double curMaxScore, System.Double& maxScore) { }
        private UnityEngine.Vector3 _GetPointOnRectEdge(UnityEngine.RectTransform rectTransform, UnityEngine.Vector2 dir) { }
        private System.Boolean get_forceEnableNaviForGuide() { }
        private System.Void set_forceEnableNaviForGuide(System.Boolean value) { }
        private System.Void SetForceEnableNavi(System.Boolean enable) { }
        private System.Void UpdateNaviInputBindingState() { }
        private System.Boolean IsNavigationBindingEnabled() { }
        private System.Void TryRemoveLayer(UnityEngine.UI.SelectableNaviGroup group) { }
        private System.Boolean IsLayerInStack(UnityEngine.UI.SelectableNaviGroup group) { }
        private System.Boolean IsTopLayer(UnityEngine.UI.SelectableNaviGroup group) { }
        private System.Void ChangeAndTrySetNaviBindingType(UnityEngine.UI.SelectableNaviGroup naviGroup, UnityEngine.UI.NavigationBindingType naviBindingType) { }
        private System.Void TryAutoSetTarget() { }
        private System.Void SetTarget(UnityEngine.UI.Selectable target) { }
        private System.Void SetTargetInSilentModeIfNecessary(UnityEngine.UI.SelectableNaviGroup naviGroup, UnityEngine.UI.Selectable selectable) { }
        private System.Boolean IsNaviTarget(UnityEngine.UI.Selectable target) { }
        private UnityEngine.Vector3 GetNaviVector(UnityEngine.UI.NaviDirection dir) { }
        private System.Void Navigate(UnityEngine.UI.NaviDirection dir) { }
        private System.Void ToggleNavigation(System.String key, System.Boolean active) { }
        private System.Void <.ctor>b__12_0() { }
        private System.Void <.ctor>b__12_1() { }
        private System.Void <.ctor>b__12_2() { }
        private System.Void <.ctor>b__12_3() { }
        private System.Void <.ctor>b__12_4() { }
        private System.Void <.ctor>b__12_5() { }
        private System.Void <.ctor>b__12_6() { }
        private System.Void <.ctor>b__12_7() { }
        private System.Void <.ctor>b__12_8() { }
        private System.Void <.ctor>b__12_9() { }
        private System.Void <.ctor>b__12_10() { }
        private System.Void <.ctor>b__12_11() { }
        private System.Void <.ctor>b__12_12() { }
        private System.Void <.ctor>b__12_13() { }
        private System.Void <.ctor>b__12_14() { }
        private System.Void <.ctor>b__12_15() { }
        private System.Void <.ctor>b__12_16() { }
        private System.Void <.ctor>b__12_17() { }
        private System.Void <.ctor>b__12_18() { }
        private System.Void <.ctor>b__12_19() { }
        private System.Void <.ctor>b__12_20() { }
        private System.Void <.ctor>b__12_21() { }
        private System.Void <.ctor>b__12_22() { }
        private System.Void <.ctor>b__12_23() { }
        private System.Void <.ctor>b__12_24() { }
        private System.Void <.ctor>b__12_25() { }
        private System.Void <.ctor>b__12_26() { }
        private System.Void <.ctor>b__12_27() { }
        private System.Void <.ctor>b__12_28() { }
        private System.Void <.ctor>b__12_29() { }
        private System.Void <.ctor>b__12_30() { }
        private System.Void <.ctor>b__12_31() { }

    }

    // TypeToken: 0x200000A
    public struct ActionOnSetNaviTarget
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Input.ActionOnSetNaviTarget None;        // 0x0
        public static Beyond.Input.ActionOnSetNaviTarget AutoTriggerOnClick;        // 0x0
        public static Beyond.Input.ActionOnSetNaviTarget PressConfirmTriggerOnClick;        // 0x0

    }

    // TypeToken: 0x200000B
    public class ControllerNaviUtils
    {
    }

    // TypeToken: 0x200000C
    public class PSTriggerEffectCfg : MonoBehaviour
    {
        // Fields
        public System.Collections.Generic.List<Plugins.LibScePad.TriggerEffectCommandUnion> commands;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000D
    public struct KeyboardKeyCode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Input.KeyboardKeyCode None;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Backspace;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Tab;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Clear;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Return;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Pause;        // 0x0
        public static Beyond.Input.KeyboardKeyCode EscapeOnly;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Space;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Exclaim;        // 0x0
        public static Beyond.Input.KeyboardKeyCode DoubleQuote;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Hash;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Dollar;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Percent;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Ampersand;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Quote;        // 0x0
        public static Beyond.Input.KeyboardKeyCode LeftParen;        // 0x0
        public static Beyond.Input.KeyboardKeyCode RightParen;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Asterisk;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Plus;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Comma;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Minus;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Period;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Slash;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Alpha0;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Alpha1;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Alpha2;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Alpha3;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Alpha4;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Alpha5;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Alpha6;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Alpha7;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Alpha8;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Alpha9;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Colon;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Semicolon;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Less;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Equals;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Greater;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Question;        // 0x0
        public static Beyond.Input.KeyboardKeyCode At;        // 0x0
        public static Beyond.Input.KeyboardKeyCode LeftBracket;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Backslash;        // 0x0
        public static Beyond.Input.KeyboardKeyCode RightBracket;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Caret;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Underscore;        // 0x0
        public static Beyond.Input.KeyboardKeyCode BackQuote;        // 0x0
        public static Beyond.Input.KeyboardKeyCode A;        // 0x0
        public static Beyond.Input.KeyboardKeyCode B;        // 0x0
        public static Beyond.Input.KeyboardKeyCode C;        // 0x0
        public static Beyond.Input.KeyboardKeyCode D;        // 0x0
        public static Beyond.Input.KeyboardKeyCode E;        // 0x0
        public static Beyond.Input.KeyboardKeyCode F;        // 0x0
        public static Beyond.Input.KeyboardKeyCode G;        // 0x0
        public static Beyond.Input.KeyboardKeyCode H;        // 0x0
        public static Beyond.Input.KeyboardKeyCode I;        // 0x0
        public static Beyond.Input.KeyboardKeyCode J;        // 0x0
        public static Beyond.Input.KeyboardKeyCode K;        // 0x0
        public static Beyond.Input.KeyboardKeyCode L;        // 0x0
        public static Beyond.Input.KeyboardKeyCode M;        // 0x0
        public static Beyond.Input.KeyboardKeyCode N;        // 0x0
        public static Beyond.Input.KeyboardKeyCode O;        // 0x0
        public static Beyond.Input.KeyboardKeyCode P;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Q;        // 0x0
        public static Beyond.Input.KeyboardKeyCode R;        // 0x0
        public static Beyond.Input.KeyboardKeyCode S;        // 0x0
        public static Beyond.Input.KeyboardKeyCode T;        // 0x0
        public static Beyond.Input.KeyboardKeyCode U;        // 0x0
        public static Beyond.Input.KeyboardKeyCode V;        // 0x0
        public static Beyond.Input.KeyboardKeyCode W;        // 0x0
        public static Beyond.Input.KeyboardKeyCode X;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Y;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Z;        // 0x0
        public static Beyond.Input.KeyboardKeyCode LeftCurlyBracket;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Pipe;        // 0x0
        public static Beyond.Input.KeyboardKeyCode RightCurlyBracket;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Tilde;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Delete;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Keypad0;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Keypad1;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Keypad2;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Keypad3;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Keypad4;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Keypad5;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Keypad6;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Keypad7;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Keypad8;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Keypad9;        // 0x0
        public static Beyond.Input.KeyboardKeyCode KeypadPeriod;        // 0x0
        public static Beyond.Input.KeyboardKeyCode KeypadDivide;        // 0x0
        public static Beyond.Input.KeyboardKeyCode KeypadMultiply;        // 0x0
        public static Beyond.Input.KeyboardKeyCode KeypadMinus;        // 0x0
        public static Beyond.Input.KeyboardKeyCode KeypadPlus;        // 0x0
        public static Beyond.Input.KeyboardKeyCode KeypadEnter;        // 0x0
        public static Beyond.Input.KeyboardKeyCode KeypadEquals;        // 0x0
        public static Beyond.Input.KeyboardKeyCode UpArrow;        // 0x0
        public static Beyond.Input.KeyboardKeyCode DownArrow;        // 0x0
        public static Beyond.Input.KeyboardKeyCode RightArrow;        // 0x0
        public static Beyond.Input.KeyboardKeyCode LeftArrow;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Insert;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Home;        // 0x0
        public static Beyond.Input.KeyboardKeyCode End;        // 0x0
        public static Beyond.Input.KeyboardKeyCode PageUp;        // 0x0
        public static Beyond.Input.KeyboardKeyCode PageDown;        // 0x0
        public static Beyond.Input.KeyboardKeyCode F1;        // 0x0
        public static Beyond.Input.KeyboardKeyCode F2;        // 0x0
        public static Beyond.Input.KeyboardKeyCode F3;        // 0x0
        public static Beyond.Input.KeyboardKeyCode F4;        // 0x0
        public static Beyond.Input.KeyboardKeyCode F5;        // 0x0
        public static Beyond.Input.KeyboardKeyCode F6;        // 0x0
        public static Beyond.Input.KeyboardKeyCode F7;        // 0x0
        public static Beyond.Input.KeyboardKeyCode F8;        // 0x0
        public static Beyond.Input.KeyboardKeyCode F9;        // 0x0
        public static Beyond.Input.KeyboardKeyCode F10;        // 0x0
        public static Beyond.Input.KeyboardKeyCode F11;        // 0x0
        public static Beyond.Input.KeyboardKeyCode F12;        // 0x0
        public static Beyond.Input.KeyboardKeyCode F13;        // 0x0
        public static Beyond.Input.KeyboardKeyCode F14;        // 0x0
        public static Beyond.Input.KeyboardKeyCode F15;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Numlock;        // 0x0
        public static Beyond.Input.KeyboardKeyCode CapsLock;        // 0x0
        public static Beyond.Input.KeyboardKeyCode ScrollLock;        // 0x0
        public static Beyond.Input.KeyboardKeyCode RightShift;        // 0x0
        public static Beyond.Input.KeyboardKeyCode LeftShift;        // 0x0
        public static Beyond.Input.KeyboardKeyCode RightControl;        // 0x0
        public static Beyond.Input.KeyboardKeyCode LeftControl;        // 0x0
        public static Beyond.Input.KeyboardKeyCode RightAlt;        // 0x0
        public static Beyond.Input.KeyboardKeyCode LeftAlt;        // 0x0
        public static Beyond.Input.KeyboardKeyCode RightApple;        // 0x0
        public static Beyond.Input.KeyboardKeyCode RightCommand;        // 0x0
        public static Beyond.Input.KeyboardKeyCode RightMeta;        // 0x0
        public static Beyond.Input.KeyboardKeyCode LeftApple;        // 0x0
        public static Beyond.Input.KeyboardKeyCode LeftCommand;        // 0x0
        public static Beyond.Input.KeyboardKeyCode LeftMeta;        // 0x0
        public static Beyond.Input.KeyboardKeyCode LeftWindows;        // 0x0
        public static Beyond.Input.KeyboardKeyCode RightWindows;        // 0x0
        public static Beyond.Input.KeyboardKeyCode AltGr;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Help;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Print;        // 0x0
        public static Beyond.Input.KeyboardKeyCode SysReq;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Break;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Menu;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Mouse0;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Mouse1;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Mouse2;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Mouse3;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Mouse4;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Mouse5;        // 0x0
        public static Beyond.Input.KeyboardKeyCode Mouse6;        // 0x0
        public static Beyond.Input.KeyboardKeyCode EscapeWithRightMouse;        // 0x0

    }

    // TypeToken: 0x200000E
    public struct GamepadKeyCode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Input.GamepadKeyCode None;        // 0x0
        public static Beyond.Input.GamepadKeyCode LeftStickX;        // 0x0
        public static Beyond.Input.GamepadKeyCode LeftStickY;        // 0x0
        public static Beyond.Input.GamepadKeyCode LeftStickBtn;        // 0x0
        public static Beyond.Input.GamepadKeyCode RightStickX;        // 0x0
        public static Beyond.Input.GamepadKeyCode RightStickY;        // 0x0
        public static Beyond.Input.GamepadKeyCode RightStickBtn;        // 0x0
        public static Beyond.Input.GamepadKeyCode ArrowUp;        // 0x0
        public static Beyond.Input.GamepadKeyCode ArrowDown;        // 0x0
        public static Beyond.Input.GamepadKeyCode ArrowLeft;        // 0x0
        public static Beyond.Input.GamepadKeyCode ArrowRight;        // 0x0
        public static Beyond.Input.GamepadKeyCode A;        // 0x0
        public static Beyond.Input.GamepadKeyCode B;        // 0x0
        public static Beyond.Input.GamepadKeyCode X;        // 0x0
        public static Beyond.Input.GamepadKeyCode Y;        // 0x0
        public static Beyond.Input.GamepadKeyCode LB;        // 0x0
        public static Beyond.Input.GamepadKeyCode LT;        // 0x0
        public static Beyond.Input.GamepadKeyCode RB;        // 0x0
        public static Beyond.Input.GamepadKeyCode RT;        // 0x0
        public static Beyond.Input.GamepadKeyCode LeftMenuBtn;        // 0x0
        public static Beyond.Input.GamepadKeyCode RightMenuBtn;        // 0x0
        public static Beyond.Input.GamepadKeyCode Home;        // 0x0
        public static Beyond.Input.GamepadKeyCode TouchPanel;        // 0x0
        public static Beyond.Input.GamepadKeyCode LeftStickUp;        // 0x0
        public static Beyond.Input.GamepadKeyCode LeftStickDown;        // 0x0
        public static Beyond.Input.GamepadKeyCode LeftStickLeft;        // 0x0
        public static Beyond.Input.GamepadKeyCode LeftStickRight;        // 0x0
        public static Beyond.Input.GamepadKeyCode RightStickUp;        // 0x0
        public static Beyond.Input.GamepadKeyCode RightStickDown;        // 0x0
        public static Beyond.Input.GamepadKeyCode RightStickLeft;        // 0x0
        public static Beyond.Input.GamepadKeyCode RightStickRight;        // 0x0

    }

    // TypeToken: 0x200000F
    public struct InputTimingType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Input.InputTimingType OnPress;        // 0x0
        public static Beyond.Input.InputTimingType OnRelease;        // 0x0
        public static Beyond.Input.InputTimingType OnClick;        // 0x0
        public static Beyond.Input.InputTimingType OnLongPress;        // 0x0

    }

    // TypeToken: 0x2000010
    public struct InputContinuousTriggerType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Input.InputContinuousTriggerType NormalDelayAndLoopTime;        // 0x0
        public static Beyond.Input.InputContinuousTriggerType EveryTick;        // 0x0

    }

    // TypeToken: 0x2000011
    public class GamepadCheckerBase
    {
        // Fields
        protected Beyond.Input.InputManager m_inputManager;        // 0x10
        protected Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>> m_normalBindingInfos;        // 0x18
        protected Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>>> m_modifyBindingInfos;        // 0x20
        protected System.Collections.Generic.HashSet<Beyond.Input.GamepadKeyCode> m_usedKeyCache;        // 0x28
        protected System.Collections.Generic.List<System.Action> m_tmpNeedTriggerCallbacks;        // 0x30

        // Methods
        private Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>> get_normalBindingInfos() { }
        private Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>>> get_modifyBindingInfos() { }
        private System.Void .ctor(Beyond.Input.InputManager inputManager) { }
        private Beyond.Input.GamepadCheckerBase.Binding OnCreateBinding(Beyond.Input.GamepadInput input, Beyond.Input.InputBindingInfo info, System.Boolean isUsedForBlock) { }
        private Beyond.Input.GamepadCheckerBase.Binding OnDeleteBinding(Beyond.Input.GamepadInput input, Beyond.Input.InputBindingInfo info) { }
        private Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>> GetInputDic(Beyond.Input.GamepadInput input) { }
        private System.Void CheckGamepadInput() { }
        private System.Void CheckDic(Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>> dic, Beyond.Input.GamepadKeyCode modifyKey) { }
        private System.Void TriggerActions() { }

    }

    // TypeToken: 0x2000013
    public class GamepadChecker : GamepadCheckerBase
    {
        // Fields
        private System.Func<Beyond.Input.GamepadKeyCode,System.Boolean> m_checkFunc;        // 0x38
        private System.Boolean <isPressChecker>k__BackingField;        // 0x40

        // Methods
        private System.Boolean get_isPressChecker() { }
        private System.Void set_isPressChecker(System.Boolean value) { }
        private System.Void .ctor(System.Func<Beyond.Input.GamepadKeyCode,System.Boolean> checkFunc, System.Boolean isPress, Beyond.Input.InputManager inputManager) { }
        private System.Void CheckDic(Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>> dic, Beyond.Input.GamepadKeyCode modifyKey) { }
        private System.Void <>iFixBaseProxy_CheckDic(Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>> P0, Beyond.Input.GamepadKeyCode P1) { }

    }

    // TypeToken: 0x2000015
    public class GamepadOnClickChecker : GamepadCheckerBase
    {
        // Methods
        private System.Void .ctor(Beyond.Input.InputManager inputManager) { }
        private System.Void CheckDic(Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>> dic, Beyond.Input.GamepadKeyCode modifyKey) { }
        private System.Void ClearKeyPressed(Beyond.Input.GamepadKeyCode keyCode) { }
        private System.Void <>iFixBaseProxy_CheckDic(Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>> P0, Beyond.Input.GamepadKeyCode P1) { }

    }

    // TypeToken: 0x2000016
    public class GamepadOnLongPressChecker : GamepadCheckerBase
    {
        // Fields
        private System.Action<Beyond.Input.GamepadKeyCode> m_onTriggerOnLongPress;        // 0x38
        private System.Collections.Generic.Dictionary<Beyond.Input.GamepadInput,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>> m_bindings;        // 0x40

        // Methods
        private System.Void .ctor(System.Action<Beyond.Input.GamepadKeyCode> onTriggerOnLongPress, Beyond.Input.InputManager inputManager) { }
        private System.Action CreateTriggerBindingAction(Beyond.Input.GamepadCheckerBase.Binding binding, Beyond.Input.GamepadKeyCode keyCode) { }
        private System.Void CheckDic(Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>> dic, Beyond.Input.GamepadKeyCode modifyKey) { }
        private System.Void _OnTriggerBinding(Beyond.Input.GamepadCheckerBase.Binding binding, Beyond.Input.GamepadKeyCode keyCode) { }
        private Beyond.Input.GamepadCheckerBase.Binding OnCreateBinding(Beyond.Input.GamepadInput input, Beyond.Input.InputBindingInfo info, System.Boolean isUsedForBlock) { }
        private Beyond.Input.GamepadCheckerBase.Binding OnDeleteBinding(Beyond.Input.GamepadInput input, Beyond.Input.InputBindingInfo info) { }
        private System.Single GetInputLongPressStartTime(Beyond.Input.GamepadInput input, System.Int32 bindingId) { }
        private System.Void <>iFixBaseProxy_CheckDic(Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>> P0, Beyond.Input.GamepadKeyCode P1) { }
        private Beyond.Input.GamepadCheckerBase.Binding <>iFixBaseProxy_OnCreateBinding(Beyond.Input.GamepadInput P0, Beyond.Input.InputBindingInfo P1, System.Boolean P2) { }
        private Beyond.Input.GamepadCheckerBase.Binding <>iFixBaseProxy_OnDeleteBinding(Beyond.Input.GamepadInput P0, Beyond.Input.InputBindingInfo P1) { }

    }

    // TypeToken: 0x2000018
    public class GamepadOnReleaseChecker : GamepadCheckerBase
    {
        // Fields
        private readonly System.Func<Beyond.Input.GamepadKeyCode,System.Boolean> m_checkFunc;        // 0x38
        private readonly System.Collections.Generic.Dictionary<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadKeyCode>> m_modifyBindingPressedDic;        // 0x40

        // Methods
        private System.Void .ctor(System.Func<Beyond.Input.GamepadKeyCode,System.Boolean> checkFunc, Beyond.Input.InputManager inputManager) { }
        private System.Void CheckGamepadInput() { }
        private System.Void CheckDic(Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>> dic, Beyond.Input.GamepadKeyCode modifyKey) { }
        private System.Boolean <CheckGamepadInput>b__3_0(Beyond.Input.GamepadKeyCode keyCode) { }
        private System.Void <>iFixBaseProxy_CheckGamepadInput() { }
        private System.Void <>iFixBaseProxy_CheckDic(Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>> P0, Beyond.Input.GamepadKeyCode P1) { }

    }

    // TypeToken: 0x2000019
    public class HGVirtualMouse : MonoBehaviour
    {
        // Fields
        private static System.Single STANDARD_SCREEN_WIDTH;        // 0x0
        public System.Boolean keepMousePosOnEnable;        // 0x18
        private UnityEngine.RectTransform m_CursorTransform;        // 0x20
        private UnityEngine.Animator m_animator;        // 0x28
        public System.Single currentCursorSpeed;        // 0x30
        public System.Single currentCursorAcc;        // 0x34
        public System.Collections.Generic.List<Beyond.Input.HGVirtualMouse.CursorSpeedPhase> speedPhaseList;        // 0x38
        public System.Collections.Generic.List<Beyond.Input.HGVirtualMouse.CursorSpeedPhase> hoverSpeedPhaseList;        // 0x40
        public System.Collections.Generic.List<Beyond.Input.HGVirtualMouse.CursorSpeedPhase> secondHoverSpeedPhaseList;        // 0x48
        private System.Single m_ScrollSpeed;        // 0x50
        private UnityEngine.InputSystem.InputActionProperty m_StickAction;        // 0x58
        private UnityEngine.InputSystem.InputActionProperty m_LeftButtonAction;        // 0x70
        private UnityEngine.InputSystem.InputActionProperty m_MiddleButtonAction;        // 0x88
        private UnityEngine.InputSystem.InputActionProperty m_RightButtonAction;        // 0xA0
        private UnityEngine.InputSystem.InputActionProperty m_ForwardButtonAction;        // 0xB8
        private UnityEngine.InputSystem.InputActionProperty m_BackButtonAction;        // 0xD0
        private UnityEngine.InputSystem.InputActionProperty m_ScrollWheelAction;        // 0xE8
        private UnityEngine.RectTransform _canvasTransform;        // 0x100
        private UnityEngine.InputSystem.Mouse m_VirtualMouse;        // 0x108
        private UnityEngine.InputSystem.Mouse m_SystemMouse;        // 0x110
        private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_ButtonActionTriggeredDelegate;        // 0x118
        private System.Double m_LastTime;        // 0x120
        private UnityEngine.Vector2 m_LastStickValue;        // 0x128
        private System.Single m_lastDisabledTime;        // 0x130
        private System.Single _resetCursorPosMinInterval;        // 0x134
        public System.Int32 leftBtnBindingGroupId;        // 0x138
        public System.Int32 leftBtnPressBindingId;        // 0x13C
        public System.Int32 leftBtnReleaseBindingId;        // 0x140
        private System.Collections.Generic.HashSet<UnityEngine.UI.Selectable> m_hoverTargets;        // 0x148
        private System.Boolean <isHoverOn>k__BackingField;        // 0x150
        private System.Boolean m_usingHoverSpd;        // 0x151
        private System.Int32 m_encounterHoverCount;        // 0x154
        private System.Single m_animatorHoverValue;        // 0x158
        private System.Boolean m_isIdle;        // 0x15C
        private System.Single _hoverAnimationChangeSpeed;        // 0x160
        private System.Boolean <mouseIconVisible>k__BackingField;        // 0x164
        private UnityEngine.CanvasGroup m_iconCanvasGroup;        // 0x168

        // Methods
        private UnityEngine.RectTransform get_cursorTransform() { }
        private System.Void set_cursorTransform(UnityEngine.RectTransform value) { }
        private System.Single get_scrollSpeed() { }
        private System.Void set_scrollSpeed(System.Single value) { }
        private UnityEngine.InputSystem.Mouse get_virtualMouse() { }
        private UnityEngine.InputSystem.InputActionProperty get_stickAction() { }
        private System.Void set_stickAction(UnityEngine.InputSystem.InputActionProperty value) { }
        private UnityEngine.InputSystem.InputActionProperty get_leftButtonAction() { }
        private System.Void set_leftButtonAction(UnityEngine.InputSystem.InputActionProperty value) { }
        private UnityEngine.InputSystem.InputActionProperty get_rightButtonAction() { }
        private System.Void set_rightButtonAction(UnityEngine.InputSystem.InputActionProperty value) { }
        private UnityEngine.InputSystem.InputActionProperty get_middleButtonAction() { }
        private System.Void set_middleButtonAction(UnityEngine.InputSystem.InputActionProperty value) { }
        private UnityEngine.InputSystem.InputActionProperty get_forwardButtonAction() { }
        private System.Void set_forwardButtonAction(UnityEngine.InputSystem.InputActionProperty value) { }
        private UnityEngine.InputSystem.InputActionProperty get_backButtonAction() { }
        private System.Void set_backButtonAction(UnityEngine.InputSystem.InputActionProperty value) { }
        private UnityEngine.InputSystem.InputActionProperty get_scrollWheelAction() { }
        private System.Void set_scrollWheelAction(UnityEngine.InputSystem.InputActionProperty value) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void _UpdateMotion() { }
        private System.Void _OnButtonActionTriggered(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void TriggerLeftButton(System.Boolean isPressed) { }
        private System.Void ClearLeftButtonState() { }
        private System.Void _SetActionCallback(UnityEngine.InputSystem.InputActionProperty field, System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> callback, System.Boolean install) { }
        private System.Void _SetAction(UnityEngine.InputSystem.InputActionProperty& field, UnityEngine.InputSystem.InputActionProperty value) { }
        private System.Void OnAfterInputUpdate() { }
        private System.Boolean get_isHoverOn() { }
        private System.Void set_isHoverOn(System.Boolean value) { }
        private System.Void Update() { }
        private System.Void ChangeHoverState(UnityEngine.UI.Selectable target, System.Boolean isHoverOn) { }
        private System.Void _ChangeHoverState(System.Boolean isHoverOn) { }
        private UnityEngine.UI.Selectable GetCurHoverSelectable() { }
        private System.Void OnDestroy() { }
        private System.Void _SyncScale() { }
        private System.Boolean get_mouseIconVisible() { }
        private System.Void set_mouseIconVisible(System.Boolean value) { }
        private System.Void Awake() { }
        private System.Void SetMouseIconVisible(System.Boolean active) { }
        private System.Void .ctor() { }
        private System.Void <OnEnable>b__32_0() { }
        private System.Void <OnEnable>b__32_1() { }

    }

    // TypeToken: 0x200001C
    public class InputBindingInfo
    {
        // Fields
        private static System.UInt32 s_nextEnabledPriority;        // 0x0
        private readonly System.Int32 <id>k__BackingField;        // 0x10
        private System.Action m_callback;        // 0x18
        private Beyond.Input.InputBindingGroup <group>k__BackingField;        // 0x20
        public System.String playerActionId;        // 0x28
        private System.Boolean <shouldShowControllerHint>k__BackingField;        // 0x30
        private System.Int32 <controllerHintPriority>k__BackingField;        // 0x34
        private System.Boolean <selfEnabled>k__BackingField;        // 0x38
        private System.Boolean <groupEnabled>k__BackingField;        // 0x39
        private System.Boolean <parentIgnored>k__BackingField;        // 0x3A
        public System.Boolean forceKeyhintToGrayState;        // 0x3B
        private System.UInt32 <enabledPriority>k__BackingField;        // 0x3C
        private System.Int32 <actionPriority>k__BackingField;        // 0x40
        private Beyond.Input.IBindingView m_bindingView;        // 0x48
        private System.String m_text;        // 0x50
        public static System.Single s_continuousTriggerFirstDelayTime;        // 0x4
        public static System.Single s_continuousTriggerLoopDelayTime;        // 0x8
        public static System.Single s_continuousTriggerLoopQuickDelayTime;        // 0xC
        private System.Int32 m_continuousTriggerTimerId;        // 0x58

        // Methods
        private System.UInt32 _GetNextEnabledPriority() { }
        private System.Int32 get_id() { }
        private Beyond.Input.InputBindingGroup get_group() { }
        private System.Void set_group(Beyond.Input.InputBindingGroup value) { }
        private System.Boolean get_shouldShowControllerHint() { }
        private System.Void set_shouldShowControllerHint(System.Boolean value) { }
        private System.Int32 get_controllerHintPriority() { }
        private System.Void set_controllerHintPriority(System.Int32 value) { }
        private System.Boolean get_selfEnabled() { }
        private System.Void set_selfEnabled(System.Boolean value) { }
        private System.Boolean get_groupEnabled() { }
        private System.Void set_groupEnabled(System.Boolean value) { }
        private System.Boolean get_enabled() { }
        private System.Boolean get_parentIgnored() { }
        private System.Void set_parentIgnored(System.Boolean value) { }
        private System.UInt32 get_enabledPriority() { }
        private System.Void set_enabledPriority(System.UInt32 value) { }
        private System.Int32 get_actionPriority() { }
        private System.Void set_actionPriority(System.Int32 value) { }
        private Beyond.Input.IBindingView get_bindingView() { }
        private System.Void set_bindingView(Beyond.Input.IBindingView value) { }
        private System.String get_text() { }
        private System.Void set_text(System.String value) { }
        private System.Void .ctor(System.Int32 id, Beyond.Input.InputBindingGroup group, System.Action callback, System.String playerActionId, Beyond.Input.PlayerActionInfo actionInfo) { }
        private System.Void ChangeGroup(Beyond.Input.InputBindingGroup newGroup) { }
        private System.Void SetSelfEnabled(System.Boolean value) { }
        private System.Void OnGroupEnabledChanged(System.Boolean value) { }
        private System.Void SetParentIgnored(System.Boolean value) { }
        private System.Void Trigger() { }
        private System.Void StartContinuousTrigger(Beyond.Input.InputContinuousTriggerType continuousTriggerType) { }
        private System.Void _TryContinuousTrigger() { }
        private System.Void StopContinuousTrigger() { }
        private System.Void _RealTriggerCallback() { }
        private System.Void OnDelete() { }
        private System.Object GetCallbackTarget() { }
        private System.Void .cctor() { }
        private System.Void <StartContinuousTrigger>b__60_0() { }
        private System.Void <StartContinuousTrigger>b__60_1() { }
        private System.Void <StartContinuousTrigger>b__60_2() { }

    }

    // TypeToken: 0x200001D
    public class InputBindingGroup
    {
        // Fields
        private readonly System.Int32 <id>k__BackingField;        // 0x10
        private System.Boolean <selfEnabled>k__BackingField;        // 0x14
        private System.Boolean <parentEnabled>k__BackingField;        // 0x15
        private System.Boolean <parentIgnored>k__BackingField;        // 0x16
        private Beyond.Input.InputBindingGroup <parent>k__BackingField;        // 0x18
        private readonly System.Collections.Generic.LinkedList<Beyond.Input.InputBindingGroup> <subGroups>k__BackingField;        // 0x20
        private readonly System.Collections.Generic.LinkedList<Beyond.Input.InputBindingInfo> <subInfos>k__BackingField;        // 0x28
        private Beyond.Input.IBindingView m_groupView;        // 0x30

        // Methods
        private System.Int32 get_id() { }
        private System.Boolean get_selfEnabled() { }
        private System.Void set_selfEnabled(System.Boolean value) { }
        private System.Boolean get_parentEnabled() { }
        private System.Void set_parentEnabled(System.Boolean value) { }
        private System.Boolean get_enabled() { }
        private System.Boolean get_parentIgnored() { }
        private System.Void set_parentIgnored(System.Boolean value) { }
        private Beyond.Input.InputBindingGroup get_parent() { }
        private System.Void set_parent(Beyond.Input.InputBindingGroup value) { }
        private System.Collections.Generic.LinkedList<Beyond.Input.InputBindingGroup> get_subGroups() { }
        private System.Collections.Generic.LinkedList<Beyond.Input.InputBindingInfo> get_subInfos() { }
        private Beyond.Input.IBindingView get_groupView() { }
        private System.Void set_groupView(Beyond.Input.IBindingView value) { }
        private System.Void .ctor(System.Int32 id, Beyond.Input.InputBindingGroup parent) { }
        private System.Void ChangeParent(Beyond.Input.InputBindingGroup newParent) { }
        private System.Void SetSelfEnabled(System.Boolean value) { }
        private System.Void SetParentIgnored(System.Boolean value) { }
        private System.Void OnParentEnabledChanged(System.Boolean value) { }
        private System.Void _OnBindingGroupStateChanged() { }

    }

    // TypeToken: 0x200001E
    public class InputBindingGroupMonoTarget : MonoBehaviour, IBindingGroupTarget
    {
        // Fields
        private System.Int32 m_groupId;        // 0x18
        private System.Boolean m_init;        // 0x1C
        private System.Boolean m_internalEnabled;        // 0x1D
        private Beyond.Input.InputBindingGroupMonoTarget <parent>k__BackingField;        // 0x20

        // Methods
        private System.Int32 get_groupId() { }
        private System.Boolean get_groupEnabled() { }
        private Beyond.Input.InputBindingGroupMonoTarget get_parent() { }
        private System.Void set_parent(Beyond.Input.InputBindingGroupMonoTarget value) { }
        private Beyond.Input.IBindingGroupTarget get_parentTarget() { }
        private System.Boolean get_internalEnabled() { }
        private System.Void set_internalEnabled(System.Boolean value) { }
        private System.Void Init() { }
        private System.Void UpdateState() { }
        private System.Void DeleteGroup() { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001F
    public interface IBindingGroupTarget
    {
        // Methods
        private System.Int32 get_groupId() { }
        private Beyond.Input.IBindingGroupTarget get_parentTarget() { }
        private System.Boolean get_groupEnabled() { }

    }

    // TypeToken: 0x2000020
    public interface IBindingTarget
    {
        // Methods
        private System.Int32 get_bindingId() { }
        private Beyond.Input.IBindingGroupTarget get_parentTarget() { }
        private System.Boolean get_bindingEnabled() { }

    }

    // TypeToken: 0x2000021
    public struct BindingViewState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Input.BindingViewState Normal;        // 0x0
        public static Beyond.Input.BindingViewState Disabled;        // 0x0
        public static Beyond.Input.BindingViewState Hide;        // 0x0

    }

    // TypeToken: 0x2000022
    public struct BindingViewActionType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Input.BindingViewActionType Default;        // 0x0
        public static Beyond.Input.BindingViewActionType ButtonClick;        // 0x0
        public static Beyond.Input.BindingViewActionType ButtonLongPress;        // 0x0
        public static Beyond.Input.BindingViewActionType ButtonPressStart;        // 0x0
        public static Beyond.Input.BindingViewActionType ButtonPressEnd;        // 0x0
        public static Beyond.Input.BindingViewActionType ButtonDoubleClick;        // 0x0
        public static Beyond.Input.BindingViewActionType SliderAdd;        // 0x0
        public static Beyond.Input.BindingViewActionType SliderReduce;        // 0x0
        public static Beyond.Input.BindingViewActionType SliderStick;        // 0x0

    }

    // TypeToken: 0x2000023
    public interface IBindingView
    {
        // Methods
        private System.String get_bindingViewActionId() { }
        private System.String get_bindingViewLabelText() { }
        private Beyond.DisposedUnityEvent get_bindingViewUpdateEvent() { }
        private System.Boolean get_interactable() { }
        private UnityEngine.RectTransform get_redDotTrans() { }
        private System.Boolean get_bindingEnabled() { }
        private Beyond.Input.BindingViewState get_bindingViewState() { }
        private System.String GetBindingViewActionId(Beyond.Input.BindingViewActionType actionType) { }
        private System.Void OnInputKeyDown() { }
        private System.Void OnInputKeyUp() { }

    }

    // TypeToken: 0x2000024
    public class InputManager : Singleton`1, IDisposable
    {
        // Fields
        public static System.Single s_longPressTime;        // 0x0
        private static System.Collections.Generic.Dictionary<Beyond.Input.KeyboardKeyCode,System.String> s_keyboardKeyCode2StringDict;        // 0x8
        private static System.Collections.Generic.Dictionary<Beyond.Input.GamepadKeyCode,System.String> s_gamepadKeyCode2StringDict;        // 0x10
        public System.Boolean enableController;        // 0x10
        public System.Boolean enableMarketingCamera;        // 0x11
        private System.Int32 m_nextInputId;        // 0x14
        private System.Int32 m_nextGroupId;        // 0x18
        private Beyond.Input.InputBindingGroup m_rootGroup;        // 0x20
        private System.Collections.Generic.Dictionary<System.Int32,Beyond.Input.InputBindingGroup> m_groups;        // 0x28
        private System.Collections.Generic.Dictionary<System.Int32,Beyond.Input.InputBindingInfo> m_bindingInfos;        // 0x30
        private System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.HashSet<System.Int32>> m_action2BindingDic;        // 0x38
        private Beyond.Input.KeyboardChecker m_onPressKeyboardChecker;        // 0x40
        private Beyond.Input.KeyboardChecker m_onReleaseKeyboardChecker;        // 0x48
        private Beyond.Input.KeyboardOnClickChecker m_onClickKeyboardChecker;        // 0x50
        private Beyond.Input.KeyboardOnLongPressChecker m_onLongPressKeyboardChecker;        // 0x58
        private Beyond.Input.GamepadChecker m_onPressGamepadChecker;        // 0x60
        private Beyond.Input.GamepadOnReleaseChecker m_onReleaseGamepadChecker;        // 0x68
        private Beyond.Input.GamepadOnClickChecker m_onClickGamepadChecker;        // 0x70
        private Beyond.Input.GamepadOnLongPressChecker m_onLongPressGamepadChecker;        // 0x78
        private Beyond.Input.RealCursorManager m_realCursorManager;        // 0x80
        public static Beyond.MultiAction<Rewired.Joystick,Beyond.DeviceInfo.ControllerType> onJoystickChanged;        // 0x18
        private Rewired.Joystick <joystick>k__BackingField;        // 0x88
        private Rewired.IGamepadTemplate <gamepadTemplate>k__BackingField;        // 0x90
        private Rewired.ControllerExtensions.IDualShock4Extension <gamepadDualShock4Extension>k__BackingField;        // 0x98
        private System.Int32 m_touchPanelBtnIndex;        // 0xA0
        private System.Int32 m_leftMenuBtnIndex;        // 0xA4
        private Beyond.Input.InputManager.KeyCaches m_keyCaches;        // 0xA8
        private Beyond.TickFunction m_lateTickFunction;        // 0xB0
        public Beyond.MultiAction onInputLateTick;        // 0xB8
        public System.Action beforeCheckInput;        // 0xC0
        public System.Action afterCheckInput;        // 0xC8
        public System.Boolean trimNonTargetInputChecks;        // 0xD0
        private static System.Boolean s_isNonSupportPsController;        // 0x20
        public System.Boolean needProcessTryChange;        // 0xD1
        public System.Boolean disableChangeInputDeviceCheck;        // 0xD2
        private System.Boolean <inChangingInputDevice>k__BackingField;        // 0xD3
        private System.Boolean m_lastAnyOtherDeviceKey;        // 0xD4
        private System.Int32 m_controllerForbidClickBindingId;        // 0xD8
        private System.Boolean m_ignoreFirstMouseUpOnFocusBack;        // 0xDC
        private static readonly Beyond.Input.KeyboardKeyCode[] S_CACHED_KEYBOARD_KEY_CODES;        // 0x28
        private System.Boolean m_hasFocusedInputFiled;        // 0xDD
        private static System.Single STICK_DEAD_ZONE_MAGNITUDE;        // 0x0
        private static System.Single STICK_MIN_VALUE;        // 0x0
        private static System.Single STICK_DEAD_ZONE_SQRT_MAGNITUDE;        // 0x0
        private Beyond.Resource.IAssetLoader m_assetLoader;        // 0xE0
        private Beyond.SerializeFieldDictionary<System.String,Beyond.Input.PlayerActionInfo> m_defaultSetting;        // 0xE8
        private Beyond.SerializeFieldDictionary<System.String,Beyond.Input.PlayerActionInfo> m_customSetting;        // 0xF0
        private Beyond.SerializeFieldDictionary<System.String,Beyond.Input.PlayerActionInfo> m_pendingSetting;        // 0xF8
        private Beyond.Input.InputRebindConfig m_rebindConfig;        // 0x100
        private System.Collections.Generic.Dictionary<System.String,Beyond.Input.InputRebindActionScopeConfig> m_rebindActionScopeConfigs;        // 0x108
        private System.Collections.Generic.Dictionary<System.String,Beyond.Input.PlayerActionInfo> m_anonymousActionInfos;        // 0x110
        private System.Int32 m_nextAnonymousPlayerActionId;        // 0x118
        private static System.String INPUT_MANAGER_CANVAS_PREFAB;        // 0x0
        private Beyond.Input.HGVirtualMouse <virtualMouse>k__BackingField;        // 0x120
        private UnityEngine.InputSystem.UI.DebugVirtualMouseInput <debugVirtualMouse>k__BackingField;        // 0x128
        private UnityEngine.Transform <canvasRoot>k__BackingField;        // 0x130
        private UnityEngine.Transform <controllerMask>k__BackingField;        // 0x138
        private System.Boolean <usingVirtualMouse>k__BackingField;        // 0x140
        private System.Int32 m_virtualMouseBindingGroupId;        // 0x144
        private UnityEngine.Transform <customControllerMouseTrans>k__BackingField;        // 0x148
        private UnityEngine.Camera <customControllerMouseUICamera>k__BackingField;        // 0x150
        private System.Collections.Generic.List<Beyond.Input.InputManager.ControllerHintInfo> m_tmpControllerHintInfoList;        // 0x158
        private static Beyond.Input.GamepadKeyCode s_controllerIndicatorKey;        // 0x30
        private static readonly Beyond.Input.GamepadKeyCode[] s_skillGamepadKeyCodes;        // 0x38
        public static Beyond.Input.GamepadKeyCode s_comboSkillButtonKey;        // 0x40
        private System.Single m_skillIndicatorPressTime;        // 0x160
        private System.Int32 m_skillIndicatorReleaseFrame;        // 0x164
        private readonly Beyond.Input.InputManager.SkillButtonState[] m_lastFrameSkillButtonStates;        // 0x168
        private static Unity.Profiling.ProfilerMarker s_updateControllerIndicatorMarker;        // 0x48
        public readonly System.Collections.Generic.HashSet<System.String> guideUseActionIds;        // 0x170
        private static System.Single DEFAULT_VIBRATE_LEVEL;        // 0x0
        private static System.Text.RegularExpressions.Regex s_actIdRegex;        // 0x50
        private static System.String TEXT_SPRITE_FORMAT;        // 0x0
        private static System.Single TEXT_SPRITE_SCALE;        // 0x0
        public static System.String LONG_PRESS_KEY_ICON_POSTFIX;        // 0x0
        private static System.String KEY_HINT_ICON_COMMON_FOLDER;        // 0x0
        private static System.String KEYBOARD_KEY_HINT_ICON_PATH;        // 0x0
        private static System.String GAMEPAD_KEY_HINT_ICON_PATH_PS5;        // 0x0
        private static System.String GAMEPAD_KEY_HINT_ICON_PATH_PS4;        // 0x0
        private static System.String GAMEPAD_KEY_HINT_ICON_PATH_XBOX;        // 0x0
        private static System.String GAMEPAD_KEY_HINT_ICON_PATH_FALLBACK;        // 0x0
        public static System.String s_virtualMouseClickHintActionId;        // 0x58
        public static System.String s_virtualMouseLongPressHintActionId;        // 0x60
        public Beyond.MultiAction<UnityEngine.Vector2> onStartSwipeTouchPanel;        // 0x178
        public Beyond.MultiAction<UnityEngine.Vector2,UnityEngine.Vector2> onSwipeTouchPanel;        // 0x180
        public Beyond.MultiAction onEndSwipeTouchPanel;        // 0x188
        private System.Boolean <isSwipingTouchPanel>k__BackingField;        // 0x190
        private UnityEngine.Vector2 m_lastTouchPanelPos;        // 0x194
        public Beyond.Input.ControllerNaviManager controllerNaviManager;        // 0x1A0
        public System.Boolean disableCheckInputForNetMask;        // 0x1A8

        // Methods
        private System.Boolean get_inHideCursorMode() { }
        private System.Boolean get_needShowCursor() { }
        private System.Boolean get_cursorVisible() { }
        private System.Boolean get_anyKeyDown() { }
        private UnityEngine.Vector2 get_mouseScrollDelta() { }
        private System.Boolean get_multiTouchEnabled() { }
        private System.Void set_multiTouchEnabled(System.Boolean value) { }
        private System.Boolean get_usingController() { }
        private System.Void set_usingController(System.Boolean value) { }
        private System.Boolean get_virtualMouseIconVisible() { }
        private System.Int32 get_invalidID() { }
        private Rewired.Joystick get_joystick() { }
        private System.Void set_joystick(Rewired.Joystick value) { }
        private Rewired.IGamepadTemplate get_gamepadTemplate() { }
        private System.Void set_gamepadTemplate(Rewired.IGamepadTemplate value) { }
        private Rewired.ControllerExtensions.IDualShock4Extension get_gamepadDualShock4Extension() { }
        private System.Void set_gamepadDualShock4Extension(Rewired.ControllerExtensions.IDualShock4Extension value) { }
        private System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.HashSet<System.Int32>> get_action2BindingDic() { }
        private System.Int32 get_rootGroupId() { }
        private System.Void .ctor() { }
        private System.Void LateTick(System.Single deltaTime) { }
        private System.Void _Init() { }
        private System.Void Release() { }
        private System.Void _ClearTickFunction() { }
        private System.Void OnApplicationQuit() { }
        private System.Void _ClearEvents() { }
        private System.Void _OnAfterInputUpdate() { }
        private System.Void _OnControllerConnected(Rewired.ControllerStatusChangedEventArgs args) { }
        private System.Void _OnControllerDisconnected(Rewired.ControllerStatusChangedEventArgs args) { }
        private System.Void _TryFindGamepad() { }
        private System.Void _SetJoystick(Rewired.Joystick js) { }
        private System.Void _CheckInput() { }
        private System.Boolean get_isNonSupportPsController() { }
        private Beyond.DeviceInfo.ControllerType _GetControllerType(Rewired.Joystick js) { }
        private System.Void OnApplicationFocus(System.Boolean hasFocus) { }
        private System.Boolean get_inChangingInputDevice() { }
        private System.Void set_inChangingInputDevice(System.Boolean value) { }
        private System.Void _InitDeviceChangeBinding() { }
        private System.Void _RefreshDeviceChangeBinding() { }
        private System.Void CheckUsingController() { }
        private System.Boolean _CheckAnyKeyForTouchChangeDevice() { }
        private System.Boolean _CheckAnyKeyForKeyboardChangeDevice() { }
        private System.Boolean _AnyKeyDownForKeyboardChangeDevice() { }
        private System.Void _TryChangeInputDeviceType(Beyond.DeviceInfo.InputType inputType) { }
        private System.Void _SyncUsingControllerState() { }
        private System.Void ToggleInputDeviceChangeMode(System.Boolean inChanging) { }
        private System.Void ToggleForceShowRealCursor(System.Boolean forceShow) { }
        private System.Void ChangeInputTypeAndSyncState(Beyond.DeviceInfo.InputType inputType) { }
        private System.Void _OnFocusedInputFieldChanged(Beyond.EventData<System.Boolean>& v) { }
        private System.Void _CreateTickFunction() { }
        private System.Void _RemovePlayerActionCheck(Beyond.Input.InputBindingInfo info) { }
        private System.Void _AddPlayerActionCheck(Beyond.Input.InputBindingInfo info) { }
        private System.Void _AddPlayerActionCheck(Beyond.Input.KeyboardInput input, Beyond.Input.InputBindingInfo info) { }
        private System.Void _AddPlayerActionCheck(Beyond.Input.GamepadInput input, Beyond.Input.InputBindingInfo info) { }
        private System.Void _RemovePlayerActionCheck(Beyond.Input.KeyboardInput input, Beyond.Input.InputBindingInfo info) { }
        private System.Void _RemovePlayerActionCheck(Beyond.Input.GamepadInput input, Beyond.Input.InputBindingInfo info) { }
        private System.Boolean GetKey(Beyond.Input.KeyboardKeyCode keyCode) { }
        private System.Boolean GetKeyDown(Beyond.Input.KeyboardKeyCode keyCode) { }
        private System.Boolean GetKeyUp(Beyond.Input.KeyboardKeyCode keyCode) { }
        private UnityEngine.Vector2 GetGamepadStickValue(System.Boolean isLeft, System.Boolean checkDeadZone) { }
        private System.Boolean CheckGamepadStickInDeadZone(UnityEngine.Vector2 stickValue) { }
        private System.Boolean CheckGamepadStickInDeadZone(System.Single stickAxisValue) { }
        private System.Single GetGamepadTriggerValue(System.Boolean isLeft) { }
        private System.Boolean GetKey(Beyond.Input.GamepadKeyCode keyCode) { }
        private System.Boolean GetKeyDown(Beyond.Input.GamepadKeyCode keyCode) { }
        private System.Boolean GetKeyUp(Beyond.Input.GamepadKeyCode keyCode) { }
        private System.Boolean AnyKeyboardKey(System.String[] actionScopes, Beyond.Input.KeyboardKeyCode& keyCode, System.Boolean& isBlackList) { }
        private System.Boolean _AnyKeyboardKey(Beyond.Input.KeyboardKeyCode[] keyCodes, Beyond.Input.KeyboardKeyCode& keyCode) { }
        private System.Boolean AnyGamepadKey() { }
        private System.Boolean AnyMouseKey() { }
        private System.Boolean AnyMouseKeyUp() { }
        private System.Boolean AnyKeyDown() { }
        private System.Boolean _CheckGamepadKeyCode(Beyond.Input.GamepadKeyCode keyCode, Beyond.Input.InputManager.KeyCodeState state) { }
        private System.Int32 CreateBinding(Beyond.Input.PlayerActionInfo actionInfo, System.Action callback, System.Int32 groupId, System.String& actionId) { }
        private System.Int32 CreateBinding(System.String actionId, System.Action callback, System.Int32 groupId) { }
        private System.Int32 CreateBinding(Beyond.Input.KeyboardKeyCode key, System.String modifyKeys, Beyond.Input.InputTimingType timing, System.Action callback, System.Int32 groupId) { }
        private System.Int32 CreateBindingByActionId(System.String actionId, System.Action callback, System.Int32 groupId) { }
        private System.Void DeleteBinding(System.Int32 id) { }
        private System.Void ToggleBinding(System.Int32 id, System.Boolean active) { }
        private System.Int32 CreateGroup(System.Int32 parentGroupId) { }
        private System.Void DeleteGroup(System.Int32 id) { }
        private System.Void DeleteInGroup(System.Int32 groupId) { }
        private System.Void ToggleGroup(System.Int32 id, System.Boolean active) { }
        private System.Boolean IsBindingEnabled(System.Int32 id, System.Boolean needLogError) { }
        private System.Void ForceBindingKeyhintToGray(System.Int32 id, System.Boolean grayState) { }
        private System.Boolean IsBindingKeyhintGray(System.Int32 id) { }
        private System.Boolean IsGroupEnabled(System.Int32 id) { }
        private System.Void ToggleHideCursor() { }
        private System.Void ResetCursorInHideCursorMode() { }
        private System.Void ToggleCursorInHideCursorMode(System.String key, System.Boolean showCursor) { }
        private System.Void ToggleAllInput(System.Boolean active) { }
        private System.Void SetBindingView(System.Int32 bindingId, Beyond.Input.IBindingView bindingView) { }
        private System.Void SetGroupView(System.Int32 groupId, Beyond.Input.IBindingView groupView) { }
        private System.Void ChangeParent(System.Boolean isGroup, System.Int32 id, System.Int32 newParentGroupId) { }
        private System.Int32 GetGroupParentId(System.Boolean isGroup, System.Int32 id) { }
        private System.Void IgnoreBindingGroupParent(System.Int32 groupId, System.Boolean parentIgnored) { }
        private System.Void IgnoreBindingParent(System.Int32 bindingId, System.Boolean parentIgnored) { }
        private Beyond.Input.KeyboardKeyCode GetActionKeyboardKeyCode(System.String actionId, System.Boolean isModifyKey, System.Boolean isPrimary) { }
        private System.Void DeleteCustomBinding(System.String actionId, Beyond.Input.InputDeviceFlags deviceFlags) { }
        private System.Void DeleteAllCustomBindings(Beyond.Input.InputDeviceFlags deviceFlags) { }
        private System.Void SetBindingText(System.Int32 id, System.String text) { }
        private System.String GetBindingText(System.Int32 id) { }
        private System.Boolean HasBinding(System.Int32 id) { }
        private System.String GetActionText(System.String actionId) { }
        private System.String GetActionText(Beyond.Input.PlayerActionInfo info, System.String actionId) { }
        private System.Boolean CheckActionKeyCodeConflict(System.String actionId, Beyond.Input.KeyboardKeyCode keyCode, System.Boolean& isPrimary) { }
        private System.Void _DeleteGroup(Beyond.Input.InputBindingGroup group, System.Boolean isRootCall) { }
        private System.Void _DeleteInGroup(Beyond.Input.InputBindingGroup group) { }
        private System.Void _RealRemoveBindingInfo(Beyond.Input.InputBindingInfo info) { }
        private System.Single GetAxis(System.String name) { }
        private System.Void GetBindingInfo(System.Int32 bindingId, System.String& actionId, Beyond.Input.IBindingView& bindingView) { }
        private System.Void _LoadSetting() { }
        private System.Void LoadSetting() { }
        private System.Boolean IsPlayerActionIdValid(System.String id) { }
        private Beyond.Input.PlayerActionInfo GetPlayerActionInfo(System.String id) { }
        private System.Void ChangePlayerAction(System.String id, Beyond.Input.PlayerActionInfo actionInfo) { }
        private System.String AddAnonymousPlayerAction(Beyond.Input.PlayerActionInfo actionInfo) { }
        private System.Void _LoadCustomInputSetting() { }
        private Beyond.Input.PlayerActionInfo _GetOrCreatePendingActionInfo(System.String actionId) { }
        private System.Boolean CustomizeActionKey(System.String actionId, Beyond.Input.KeyboardKeyCode key, System.Boolean isPrimary) { }
        private System.Boolean CustomizeActionKey(System.String actionId, System.Nullable<Beyond.Input.GamepadKeyCode> modifyKey, System.Nullable<Beyond.Input.GamepadKeyCode> key, System.Boolean isPrimary) { }
        private System.Void ClearPendingInputSetting() { }
        private System.Void SaveCustomInputSetting() { }
        private Beyond.Input.HGVirtualMouse get_virtualMouse() { }
        private System.Void set_virtualMouse(Beyond.Input.HGVirtualMouse value) { }
        private UnityEngine.InputSystem.UI.DebugVirtualMouseInput get_debugVirtualMouse() { }
        private System.Void set_debugVirtualMouse(UnityEngine.InputSystem.UI.DebugVirtualMouseInput value) { }
        private UnityEngine.Transform get_canvasRoot() { }
        private System.Void set_canvasRoot(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_controllerMask() { }
        private System.Void set_controllerMask(UnityEngine.Transform value) { }
        private System.Boolean get_usingVirtualMouse() { }
        private System.Void set_usingVirtualMouse(System.Boolean value) { }
        private System.Void _CreateCanvas() { }
        private System.Void _CreateDebugVirtualMouse() { }
        private System.Void _CreateVirtualMouse() { }
        private System.Void _ToggleVirtualMouse(System.Boolean active, System.Boolean forceUpdate) { }
        private System.Void _CheckVirtualMouseState() { }
        private UnityEngine.Vector3 get_mousePosition() { }
        private UnityEngine.Vector3 GetMousePos() { }
        private System.Void SetOnlyVirtualMousePos(UnityEngine.Vector2 newPos) { }
        private System.Void SetMousePos(UnityEngine.Vector2 newPos, System.Boolean hideVirtualMouse) { }
        private System.Boolean GetMouseButton(System.Int32 button) { }
        private System.Boolean IsLeftMouseDown() { }
        private System.Boolean GetMouseButtonDown(System.Int32 button) { }
        private System.Boolean GetMouseButtonUp(System.Int32 button) { }
        private UnityEngine.Transform get_customControllerMouseTrans() { }
        private System.Void set_customControllerMouseTrans(UnityEngine.Transform value) { }
        private UnityEngine.Camera get_customControllerMouseUICamera() { }
        private System.Void set_customControllerMouseUICamera(UnityEngine.Camera value) { }
        private System.Void SetCustomControllerMouse(UnityEngine.Transform trans, UnityEngine.Camera uiCamera) { }
        private System.Collections.Generic.List<Beyond.Input.InputManager.ControllerHintInfo> GetEmptyControllerHintInfoList() { }
        private System.Void GetControllerHintInfos(System.Int32 groupId, System.Boolean ignoreRootEnabled, System.Collections.Generic.List<Beyond.Input.InputManager.ControllerHintInfo>& infoList) { }
        private System.Void GetControllerHintInfos(System.Collections.Generic.List<System.String> actionIdList, System.Collections.Generic.List<Beyond.Input.InputManager.ControllerHintInfo>& infoList) { }
        private System.Void _GetControllerHintInfos(Beyond.Input.InputBindingGroup group, System.Boolean ignoreRootEnabled, System.Collections.Generic.List<Beyond.Input.InputManager.ControllerHintInfo>& infoList) { }
        private System.Void _GetControllerHintInfos(System.Collections.Generic.List<System.String> actionIdList, System.Collections.Generic.List<Beyond.Input.InputManager.ControllerHintInfo>& infoList) { }
        private System.Single GetPlayerActionLongPressStartTime(System.String actionId, System.Single& longPressTime) { }
        private System.Single GetActionBindingLongPressStartTime(System.Int32 bindingId, System.Single& longPressTime) { }
        private System.Boolean GetControllerIndicatorState() { }
        private System.Void _UpdateControllerIndicator(System.Single deltaTime) { }
        private System.Int32 TryPressControllerIndicatorWhenSkillButtonJustPressed() { }
        private System.Void TryClickSkillButtonWhenControllerIndicatorJustRelease(System.Int32 charIndex) { }
        private System.Void _RefreshControllerBattleButton() { }
        private System.Void AddGuideUseActionId(System.String actionId) { }
        private System.Void RemoveGuideUseActionId(System.String actionId) { }
        private System.Void ClearGuideUseActionIds() { }
        private System.Void VibrateController(System.Single time, System.Single level) { }
        private System.String _GetGamepadKeyIconFolderPath() { }
        private System.String GetStringByKeyboardKeyCode(Beyond.Input.KeyboardKeyCode code) { }
        private System.String GetStringByGamepadKeyCode(Beyond.Input.GamepadKeyCode code) { }
        private System.String GetKeyIconPath(Beyond.Input.GamepadInput inputInfo, System.Boolean isModifyKey, System.Boolean isFullPath, System.Boolean ignoreOverrideKeyIcon) { }
        private System.String GetGamepadKeyIconPath(System.String keyStr, System.Boolean isLongPress, System.Boolean isFullPath) { }
        private System.String GetKeyIconPath(Beyond.Input.KeyboardInput inputInfo, System.Boolean isModifyKey, System.Boolean isFullPath) { }
        private System.String GetKeyIconPath(Beyond.Input.KeyboardInput inputInfo, System.Boolean isModifyKey, System.Boolean isLongPress, System.Boolean isFullPath) { }
        private System.String _GetKeyIconPath(System.String path, System.String keyStr, System.Boolean isLongPress, System.Boolean isFullPath) { }
        private System.String ParseTextActionId(System.String text) { }
        private System.Void MoveMouseTo(UnityEngine.RectTransform target, UnityEngine.Camera uiCamera) { }
        private System.Void MoveVirtualMouseTo(UnityEngine.RectTransform target, UnityEngine.Camera uiCamera, System.Boolean hideVirtualMouse) { }
        private System.Void SetVirtualMouseIconVisible(System.Boolean active) { }
        private System.Boolean get_isSwipingTouchPanel() { }
        private System.Void set_isSwipingTouchPanel(System.Boolean value) { }
        private System.Void _ControllerTouchPanelTick() { }
        private System.Int32 GetTouchId(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Boolean GetPressPosByTouchId(System.Int32 touchId, UnityEngine.Vector2& position) { }
        private System.Void Dispose() { }
        private System.Void RemoveUnusedInput() { }
        private System.Void _OnNetMaskChanged(Beyond.EventData<System.Boolean>& v) { }
        private System.String GetCurJsInfos() { }
        private System.Void .cctor() { }
        private System.Void <_Init>b__65_0(Beyond.Input.KeyboardKeyCode key) { }
        private System.Void <_Init>b__65_1(Beyond.Input.GamepadKeyCode key) { }
        private System.Void <_Init>b__65_2() { }
        private System.Void <_Init>b__65_3() { }

    }

    // TypeToken: 0x200002A
    public class InputRebindConfig : ScriptableObject
    {
        // Fields
        public static System.String INPUT_REBIND_CONFIG_PATH;        // 0x0
        public Beyond.Input.InputRebindActionScopeConfig[] actionScopeConfigs;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002B
    public class InputRebindActionScopeConfig
    {
        // Fields
        public System.String name;        // 0x10
        public Beyond.Input.KeyboardKeyCode[] keyboardKeyCodeWhiteList;        // 0x18
        public Beyond.Input.KeyboardKeyCode[] keyboardKeyCodeBlackList;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002C
    public class InputSetting : ScriptableObject
    {
        // Fields
        public static System.String CUSTOM_SETTING_DIRECTORY_NAME;        // 0x0
        public static System.String CUSTOM_SETTING_JSON_FILE_NAME;        // 0x0
        public Beyond.SerializeFieldDictionaryPaired<System.String,Beyond.Input.PlayerActionInfo> actionInfos;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002D
    public class InputSettingConfig : ScriptableObject
    {
        // Fields
        public static System.String INPUT_SETTING_CONFIG_PATH;        // 0x0
        public System.Collections.Generic.List<Beyond.Input.InputSetting> inputSettingList;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002E
    public class InputUtils
    {
        // Methods
        private System.Void IgnoreBindingParent(Beyond.Input.IBindingTarget target, System.Boolean active) { }
        private System.Void IgnoreBindingGroupParent(Beyond.Input.IBindingGroupTarget target, System.Boolean active) { }
        private System.Boolean HasFlag(Beyond.Input.InputDeviceFlags value, Beyond.Input.InputDeviceFlags target) { }

    }

    // TypeToken: 0x200002F
    public class KeyboardCheckerBase
    {
        // Fields
        protected Beyond.Input.InputManager m_inputManager;        // 0x10
        protected static System.Int32 CTRL;        // 0x0
        protected static System.Int32 SHIFT;        // 0x0
        protected static System.Int32 ALT;        // 0x0
        protected static System.Int32 MAX_INDEX;        // 0x0
        protected static System.Int32[] s_checkPriority;        // 0x0
        protected System.Collections.Generic.List<Beyond.DynamicFastLookupCollection<Beyond.Input.KeyboardKeyCode,System.Collections.Generic.HashSet<Beyond.Input.KeyboardCheckerBase.Binding>>> m_bindingInfos;        // 0x18

        // Methods
        private System.Collections.Generic.List<Beyond.DynamicFastLookupCollection<Beyond.Input.KeyboardKeyCode,System.Collections.Generic.HashSet<Beyond.Input.KeyboardCheckerBase.Binding>>> get_bindingInfos() { }
        private System.Void .ctor(Beyond.Input.InputManager inputManager) { }
        private System.Int32 GetModifyIndex(Beyond.Input.KeyboardInput input) { }
        private Beyond.Input.KeyboardCheckerBase.Binding OnCreateBinding(Beyond.Input.KeyboardInput input, Beyond.Input.InputBindingInfo info, System.Boolean isUsedForBlock) { }
        private Beyond.Input.KeyboardCheckerBase.Binding OnDeleteBinding(Beyond.Input.KeyboardInput input, Beyond.Input.InputBindingInfo info) { }
        private System.Void CheckKeyboardInput() { }
        private System.Void TriggerActions() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000031
    public class KeyboardChecker : KeyboardCheckerBase
    {
        // Fields
        private System.Func<Beyond.Input.KeyboardKeyCode,System.Boolean> m_checkFunc;        // 0x20
        private System.Boolean <isPressChecker>k__BackingField;        // 0x28
        private System.Collections.Generic.HashSet<Beyond.Input.KeyboardKeyCode> m_usedKeyCache;        // 0x30
        private System.Collections.Generic.List<System.Action> m_tmpNeedTriggerCallbacks;        // 0x38

        // Methods
        private System.Boolean get_isPressChecker() { }
        private System.Void set_isPressChecker(System.Boolean value) { }
        private System.Void .ctor(System.Func<Beyond.Input.KeyboardKeyCode,System.Boolean> checkFunc, System.Boolean isPress, Beyond.Input.InputManager inputManager) { }
        private System.Void CheckKeyboardInput() { }
        private System.Void TriggerActions() { }
        private System.Void <>iFixBaseProxy_CheckKeyboardInput() { }
        private System.Void <>iFixBaseProxy_TriggerActions() { }

    }

    // TypeToken: 0x2000033
    public class KeyboardOnClickChecker : KeyboardCheckerBase
    {
        // Fields
        private System.Collections.Generic.HashSet<Beyond.Input.KeyboardKeyCode> m_usedKeyCache;        // 0x20
        private System.Collections.Generic.List<System.Action> m_tmpNeedTriggerCallbacks;        // 0x28
        private System.Collections.Generic.List<Beyond.ListSet<Beyond.Input.KeyboardKeyCode>> m_combinationKeyPressedInfo;        // 0x30

        // Methods
        private System.Void .ctor(Beyond.Input.InputManager inputManager) { }
        private System.Void CheckKeyboardInput() { }
        private System.Void TriggerActions() { }
        private System.Void ClearKeyPressed(Beyond.Input.KeyboardKeyCode keyCode) { }
        private System.Void <>iFixBaseProxy_CheckKeyboardInput() { }
        private System.Void <>iFixBaseProxy_TriggerActions() { }

    }

    // TypeToken: 0x2000034
    public class KeyboardOnLongPressChecker : KeyboardCheckerBase
    {
        // Fields
        private System.Action<Beyond.Input.KeyboardKeyCode> m_onTriggerOnLongPress;        // 0x20
        private System.Collections.Generic.Dictionary<Beyond.Input.KeyboardInput,System.Collections.Generic.HashSet<Beyond.Input.KeyboardCheckerBase.Binding>> m_bindings;        // 0x28
        private System.Collections.Generic.HashSet<Beyond.Input.KeyboardKeyCode> m_usedKeyCache;        // 0x30

        // Methods
        private System.Void .ctor(System.Action<Beyond.Input.KeyboardKeyCode> onTriggerOnLongPress, Beyond.Input.InputManager inputManager) { }
        private System.Void CheckKeyboardInput() { }
        private System.Void _OnTriggerBinding(Beyond.Input.KeyboardCheckerBase.Binding binding, Beyond.Input.KeyboardKeyCode keyCode) { }
        private Beyond.Input.KeyboardCheckerBase.Binding OnCreateBinding(Beyond.Input.KeyboardInput input, Beyond.Input.InputBindingInfo info, System.Boolean isUsedForBlock) { }
        private Beyond.Input.KeyboardCheckerBase.Binding OnDeleteBinding(Beyond.Input.KeyboardInput input, Beyond.Input.InputBindingInfo info) { }
        private System.Single GetInputLongPressStartTime(Beyond.Input.KeyboardInput input, System.Int32 bindingId) { }
        private System.Void <>iFixBaseProxy_CheckKeyboardInput() { }
        private Beyond.Input.KeyboardCheckerBase.Binding <>iFixBaseProxy_OnCreateBinding(Beyond.Input.KeyboardInput P0, Beyond.Input.InputBindingInfo P1, System.Boolean P2) { }
        private Beyond.Input.KeyboardCheckerBase.Binding <>iFixBaseProxy_OnDeleteBinding(Beyond.Input.KeyboardInput P0, Beyond.Input.InputBindingInfo P1) { }

    }

    // TypeToken: 0x2000036
    public class PlayerActionIdAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000037
    public struct InputDeviceFlags
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static Beyond.Input.InputDeviceFlags None;        // 0x0
        public static Beyond.Input.InputDeviceFlags Keyboard;        // 0x0
        public static Beyond.Input.InputDeviceFlags Gamepad;        // 0x0
        public static Beyond.Input.InputDeviceFlags All;        // 0x0

    }

    // TypeToken: 0x2000038
    public class PlayerActionInfo
    {
        // Fields
        public Beyond.Input.KeyboardInput primaryKeyboardInput;        // 0x10
        public Beyond.Input.GamepadInput primaryGamepadInput;        // 0x18
        public System.Int32 priority;        // 0x20
        public System.Boolean needShowControllerHint;        // 0x24
        public System.Int32 controllerHintPriority;        // 0x28
        public System.String overrideTextId;        // 0x30
        public System.Boolean needSecond;        // 0x38
        public System.Boolean hideSecondInKeyHint;        // 0x39
        public Beyond.Input.KeyboardInput secondaryKeyboardInput;        // 0x40
        public Beyond.Input.GamepadInput secondaryGamepadInput;        // 0x48

        // Methods
        private System.Void ResetHintProority() { }
        private System.Boolean DeviceInputEquals(Beyond.Input.PlayerActionInfo other, Beyond.Input.InputDeviceFlags deviceFlags) { }
        private System.Void DeviceInputCopyFrom(Beyond.Input.PlayerActionInfo other, Beyond.Input.InputDeviceFlags deviceFlags) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000039
    public class DeviceInput`1, IEquatable`1
    {
        // Fields
        public Beyond.Input.InputTimingType timingType;        // 0x0
        public System.Boolean blockOtherTiming;        // 0x0
        public System.Single longPressTime;        // 0x0
        public System.Boolean enableContinuousTrigger;        // 0x0
        public Beyond.Input.InputContinuousTriggerType continuousTriggerType;        // 0x0
        public System.String overrideKeyIconName;        // 0x0

        // Methods
        private System.String GetModifyText() { }
        private System.String GetKeyCodeText() { }
        private System.Int32 GetKeyCodeEnumIntValue() { }
        private System.Void SetKeyCodeEnumByIntValue(System.Int32 value) { }
        private System.Void ClearKeyCode() { }
        private System.Boolean IsValid() { }
        private System.Void CopyFrom(T other) { }
        private System.Boolean Equals(T other) { }
        private System.String ToString() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003A
    public class KeyboardInput : DeviceInput`1
    {
        // Fields
        public Beyond.Input.KeyboardKeyCode key;        // 0x30
        public System.Boolean useCtrl;        // 0x34
        public System.Boolean useShift;        // 0x35
        public System.Boolean useAlt;        // 0x36

        // Methods
        private System.String GetModifyText() { }
        private System.String GetKeyCodeText() { }
        private System.Int32 GetKeyCodeEnumIntValue() { }
        private System.Void SetKeyCodeEnumByIntValue(System.Int32 value) { }
        private System.String get_modifyString() { }
        private System.Void ClearKeyCode() { }
        private System.Boolean IsValid() { }
        private System.Void CopyFrom(Beyond.Input.KeyboardInput other) { }
        private System.Boolean Equals(Beyond.Input.KeyboardInput other) { }
        private System.Void .ctor() { }
        private System.String <>iFixBaseProxy_GetModifyText() { }
        private System.String <>iFixBaseProxy_GetKeyCodeText() { }
        private System.Int32 <>iFixBaseProxy_GetKeyCodeEnumIntValue() { }
        private System.Void <>iFixBaseProxy_SetKeyCodeEnumByIntValue(System.Int32 P0) { }
        private System.Void <>iFixBaseProxy_ClearKeyCode() { }
        private System.Boolean <>iFixBaseProxy_IsValid() { }

    }

    // TypeToken: 0x200003B
    public class GamepadInput : DeviceInput`1
    {
        // Fields
        public Beyond.Input.GamepadKeyCode key;        // 0x30
        public Beyond.Input.GamepadKeyCode modifyKey;        // 0x34

        // Methods
        private System.String GetModifyText() { }
        private System.String GetKeyCodeText() { }
        private System.Int32 GetKeyCodeEnumIntValue() { }
        private System.Void SetKeyCodeEnumByIntValue(System.Int32 value) { }
        private System.Void ClearKeyCode() { }
        private System.Boolean IsValid() { }
        private System.Void CopyFrom(Beyond.Input.GamepadInput other) { }
        private System.Boolean Equals(Beyond.Input.GamepadInput other) { }
        private System.Void .ctor() { }
        private System.String <>iFixBaseProxy_GetModifyText() { }
        private System.String <>iFixBaseProxy_GetKeyCodeText() { }
        private System.Int32 <>iFixBaseProxy_GetKeyCodeEnumIntValue() { }
        private System.Void <>iFixBaseProxy_SetKeyCodeEnumByIntValue(System.Int32 P0) { }
        private System.Void <>iFixBaseProxy_ClearKeyCode() { }
        private System.Boolean <>iFixBaseProxy_IsValid() { }

    }

    // TypeToken: 0x200003C
    public class RealCursorManager
    {
        // Fields
        private System.Boolean <forceShowCursorForF5>k__BackingField;        // 0x10
        private System.Boolean <forceHideCursorForUsingController>k__BackingField;        // 0x11
        private System.Boolean <isUsingVirtualMouse>k__BackingField;        // 0x12
        private System.Boolean <forceShowRealCursorForChangeInput>k__BackingField;        // 0x13
        private System.Collections.Generic.Dictionary<System.String,System.Boolean> m_internalCursorState;        // 0x18

        // Methods
        private System.Boolean get_forceShowCursorForF5() { }
        private System.Void set_forceShowCursorForF5(System.Boolean value) { }
        private System.Boolean get_forceHideCursorForUsingController() { }
        private System.Void set_forceHideCursorForUsingController(System.Boolean value) { }
        private System.Boolean get_isUsingVirtualMouse() { }
        private System.Void set_isUsingVirtualMouse(System.Boolean value) { }
        private System.Boolean get_forceShowRealCursorForChangeInput() { }
        private System.Void set_forceShowRealCursorForChangeInput(System.Boolean value) { }
        private System.Void .ctor() { }
        private System.Void SetForceHideCursorForController(System.Boolean forceHide, System.Boolean isUsingVirtualMouse) { }
        private System.Void SetDebugShowCursorMode(System.Boolean enableDebug) { }
        private System.Void ToggleForceShowRealCursorForChangeInput(System.Boolean forceShow) { }
        private System.Boolean IsNeedShowCursor() { }
        private System.Void ResetCursorInHideCursorMode() { }
        private System.Void ToggleCursorInHideCursorMode(System.String operationKey, System.Boolean showCursor) { }
        private System.Void CalcState(System.Boolean forceUpdate) { }
        private System.Void _ToggleCursorInternal(System.Boolean enable, System.Boolean forceUpdate) { }

    }

    // TypeToken: 0x200003D
    public class TextIdAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003E
    public class UIEvent : UnityEvent, IBindingTarget
    {
        // Fields
        private System.Boolean m_bindingInit;        // 0x30
        public System.Boolean useBindingAction;        // 0x31
        public System.String playerActionId;        // 0x38
        public Beyond.Input.PlayerActionInfo anonymousPlayerActionInfo;        // 0x40
        public System.String anonymousPlayerActionId;        // 0x48
        private System.Int32 <bindingId>k__BackingField;        // 0x50
        private Beyond.Input.IBindingGroupTarget <parentTarget>k__BackingField;        // 0x58
        private System.Action m_bindAct;        // 0x60
        private System.Action m_onUpdateKeyAct;        // 0x68
        private System.Collections.Generic.List<UnityEngine.Events.UnityAction> m_calls;        // 0x70

        // Methods
        private System.Boolean get_bindingEnabled() { }
        private System.Int32 get_bindingId() { }
        private System.Void set_bindingId(System.Int32 value) { }
        private Beyond.Input.IBindingGroupTarget get_parentTarget() { }
        private System.Void set_parentTarget(Beyond.Input.IBindingGroupTarget value) { }
        private System.Void _CreatePlayerActionBinding() { }
        private System.Void InitBinding(Beyond.Input.IBindingGroupTarget parent, System.Action bindAct, System.Action onUpdateKeyAct) { }
        private System.Void Invoke() { }
        private System.Void UpdateKeys() { }
        private System.Void ChangeBindingPlayerAction(System.String actionId) { }
        private System.Int32 get_count() { }
        private System.Void AddListener(UnityEngine.Events.UnityAction call) { }
        private System.Void RemoveListener(UnityEngine.Events.UnityAction call) { }
        private System.Void RemoveAllListeners() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003F
    public class UIEvent`1 : UnityEvent`1, IBindingTarget
    {
        // Fields
        private System.Boolean m_bindingInit;        // 0x0
        public System.Boolean useBindingAction;        // 0x0
        public System.String playerActionId;        // 0x0
        public Beyond.Input.PlayerActionInfo anonymousPlayerActionInfo;        // 0x0
        public System.String anonymousPlayerActionId;        // 0x0
        public System.Boolean useAnonymousAction;        // 0x0
        public System.Boolean tempForceEnable;        // 0x0
        private System.Int32 <bindingId>k__BackingField;        // 0x0
        private Beyond.Input.IBindingGroupTarget <parentTarget>k__BackingField;        // 0x0
        private System.Action m_bindAct;        // 0x0
        private System.Action m_onUpdateKeyAct;        // 0x0
        private System.Collections.Generic.List<UnityEngine.Events.UnityAction<T0>> m_calls;        // 0x0

        // Methods
        private System.Boolean get_bindingEnabled() { }
        private System.Int32 get_bindingId() { }
        private System.Void set_bindingId(System.Int32 value) { }
        private Beyond.Input.IBindingGroupTarget get_parentTarget() { }
        private System.Void set_parentTarget(Beyond.Input.IBindingGroupTarget value) { }
        private System.Void _CreatePlayerActionBinding() { }
        private System.Void InitBinding(Beyond.Input.IBindingGroupTarget parent, System.Action bindAct, System.Action onUpdateKeyAct) { }
        private System.Void Invoke(T0 arg0) { }
        private Beyond.Input.PlayerActionInfo GetEventPlayerActionInfo() { }
        private System.Void UpdateKeys() { }
        private System.Void ChangeBindingPlayerAction(System.String actionId) { }
        private System.Void StopUseBinding() { }
        private System.String GetActionId() { }
        private System.Int32 get_count() { }
        private System.Void AddListener(UnityEngine.Events.UnityAction<T0> call) { }
        private System.Void RemoveListener(UnityEngine.Events.UnityAction<T0> call) { }
        private System.Void RemoveAllListeners() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000040
    public class UIEvent`2 : UnityEvent`2, IBindingTarget
    {
        // Fields
        private System.Boolean m_bindingInit;        // 0x0
        public System.Boolean useBindingAction;        // 0x0
        public System.String playerActionId;        // 0x0
        public Beyond.Input.PlayerActionInfo anonymousPlayerActionInfo;        // 0x0
        public System.String anonymousPlayerActionId;        // 0x0
        private System.Int32 <bindingId>k__BackingField;        // 0x0
        private Beyond.Input.IBindingGroupTarget <parentTarget>k__BackingField;        // 0x0
        private System.Action m_bindAct;        // 0x0
        private System.Action m_onUpdateKeyAct;        // 0x0
        private System.Collections.Generic.List<UnityEngine.Events.UnityAction<T0,T1>> m_calls;        // 0x0

        // Methods
        private System.Boolean get_bindingEnabled() { }
        private System.Int32 get_bindingId() { }
        private System.Void set_bindingId(System.Int32 value) { }
        private Beyond.Input.IBindingGroupTarget get_parentTarget() { }
        private System.Void set_parentTarget(Beyond.Input.IBindingGroupTarget value) { }
        private System.Void _CreatePlayerActionBinding() { }
        private System.Void InitBinding(Beyond.Input.IBindingGroupTarget parent, System.Action bindAct, System.Action onUpdateKeyAct) { }
        private System.Void Invoke(T0 arg0, T1 arg1) { }
        private System.Void UpdateKeys() { }
        private System.Void ChangeBindingPlayerAction(System.String actionId) { }
        private System.Int32 get_count() { }
        private System.Void AddListener(UnityEngine.Events.UnityAction<T0,T1> call) { }
        private System.Void RemoveListener(UnityEngine.Events.UnityAction<T0,T1> call) { }
        private System.Void RemoveAllListeners() { }
        private System.Void .ctor() { }

    }

}

namespace Beyond.SourceGenerator
{

    // TypeToken: 0x2000005
    public class DataNAttribute : Attribute
    {
        // Fields
        public System.Int32 capacity;        // 0x10
        public System.Int32 tSize;        // 0x14
        public System.Boolean ring;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000006
    public class AnimatorBlackboardAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000007
    public class ECSComponentAttribute : Attribute
    {
        // Fields
        public System.Runtime.InteropServices.LayoutKind layoutKind;        // 0x10
        public System.Boolean isTag;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000008
    public class CameraControlConfigAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

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

namespace IFix
{

    // TypeToken: 0x2000043
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10
        private System.Int32 methodId;        // 0x18
        private System.Object anonObj;        // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;        // 0x0

        // Methods
        private System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        private System.Boolean __Gen_Wrap_0(System.Object P0) { }
        private System.UInt32 __Gen_Wrap_1() { }
        private System.Void __Gen_Wrap_2(System.Object P0) { }
        private System.Void __Gen_Wrap_3(System.Object P0, System.Boolean P1) { }
        private System.Void __Gen_Wrap_4(System.Object P0, System.Int32 P1, System.Boolean P2) { }
        private System.Void __Gen_Wrap_5(System.Object P0, UnityEngine.UI.NavigationBindingType P1) { }
        private System.Boolean __Gen_Wrap_6(System.Object P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_7(System.Object P0, System.Object P1, System.Boolean P2) { }
        private System.Boolean __Gen_Wrap_8(System.Object P0, System.Object P1, System.Object P2) { }
        private System.Void __Gen_Wrap_9(System.Object P0, System.Object P1) { }
        private UnityEngine.Vector3 __Gen_Wrap_10(System.Object P0, UnityEngine.UI.NaviDirection P1) { }
        private UnityEngine.Vector3 __Gen_Wrap_11(System.Object P0, UnityEngine.Vector2 P1) { }
        private UnityEngine.UI.Selectable __Gen_Wrap_12(System.Object P0, System.Object P1, UnityEngine.Vector3 P2, UnityEngine.Vector3 P3, UnityEngine.UI.NaviStrategy P4, System.Double P5, System.Double& P6) { }
        private UnityEngine.UI.Selectable __Gen_Wrap_13(System.Object P0, System.Object P1, UnityEngine.Vector3 P2, UnityEngine.Vector3 P3, System.Double P4, System.Double& P5) { }
        private System.Boolean __Gen_Wrap_14(System.Object P0, UnityEngine.UI.NaviDirection P1) { }
        private System.Boolean __Gen_Wrap_15(System.Object P0, System.Object P1) { }
        private System.Void __Gen_Wrap_16(System.Object P0, System.Object P1, UnityEngine.UI.NavigationBindingType P2) { }
        private System.Void __Gen_Wrap_17(System.Object P0, System.Object P1, System.Object P2) { }
        private System.Void __Gen_Wrap_18(System.Object P0, UnityEngine.UI.NaviDirection P1) { }
        private Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>> __Gen_Wrap_19(System.Object P0) { }
        private Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>>> __Gen_Wrap_20(System.Object P0) { }
        private Beyond.DynamicFastLookupCollection<Beyond.Input.GamepadKeyCode,System.Collections.Generic.HashSet<Beyond.Input.GamepadCheckerBase.Binding>> __Gen_Wrap_21(System.Object P0, System.Object P1) { }
        private Beyond.Input.GamepadCheckerBase.Binding __Gen_Wrap_22(System.Object P0, System.Object P1, System.Object P2, System.Boolean P3) { }
        private Beyond.Input.GamepadCheckerBase.Binding __Gen_Wrap_23(System.Object P0, System.Object P1, System.Object P2) { }
        private System.Void __Gen_Wrap_24(System.Object P0, System.Object P1, Beyond.Input.GamepadKeyCode P2) { }
        private System.Void __Gen_Wrap_25() { }
        private System.Void __Gen_Wrap_26(System.Object P0, Beyond.Input.InputContinuousTriggerType P1) { }
        private System.Void __Gen_Wrap_27(System.Object P0, Beyond.Input.GamepadKeyCode P1) { }
        private System.Action __Gen_Wrap_28(System.Object P0, System.Object P1, Beyond.Input.GamepadKeyCode P2) { }
        private System.Single __Gen_Wrap_29(System.Object P0, System.Object P1, System.Int32 P2) { }
        private System.Boolean __Gen_Wrap_30(Beyond.Input.GamepadKeyCode P0) { }
        private System.Void __Gen_Wrap_31(UnityEngine.InputSystem.InputActionProperty P0, System.Object P1, System.Boolean P2) { }
        private System.Void __Gen_Wrap_32(UnityEngine.InputSystem.InputActionProperty& P0, UnityEngine.InputSystem.InputActionProperty P1) { }
        private System.Void __Gen_Wrap_33(System.Object P0, UnityEngine.InputSystem.InputActionProperty P1) { }
        private System.Void __Gen_Wrap_34(System.Object P0, UnityEngine.InputSystem.InputAction.CallbackContext P1) { }
        private System.Int32 __Gen_Wrap_35(System.Object P0, System.Int32 P1) { }
        private Beyond.Input.PlayerActionInfo __Gen_Wrap_36(System.Object P0, System.Object P1) { }
        private System.Int32 __Gen_Wrap_37(System.Object P0) { }
        private Beyond.Input.KeyboardCheckerBase.Binding __Gen_Wrap_38(System.Object P0, System.Object P1, System.Object P2, System.Boolean P3) { }
        private System.Int32 __Gen_Wrap_39(System.Object P0, System.Object P1, System.Object P2, System.Int32 P3) { }
        private System.Boolean __Gen_Wrap_40(UnityEngine.UI.Selectable P0) { }
        private UnityEngine.UI.Selectable __Gen_Wrap_41(System.Object P0) { }
        private Beyond.Input.KeyboardCheckerBase.Binding __Gen_Wrap_42(System.Object P0, System.Object P1, System.Object P2) { }
        private System.Void __Gen_Wrap_43(System.Object P0, System.Int32 P1) { }
        private System.String __Gen_Wrap_44(System.Object P0, System.Object P1) { }
        private System.String __Gen_Wrap_45(System.Object P0) { }
        private System.Object __Gen_Wrap_46(System.Object P0) { }
        private Beyond.Input.IBindingView __Gen_Wrap_47(System.Object P0) { }
        private System.Boolean __Gen_Wrap_48() { }
        private UnityEngine.Vector2 __Gen_Wrap_49(System.Object P0, System.Boolean P1, System.Boolean P2) { }
        private UnityEngine.Vector2 __Gen_Wrap_50() { }
        private System.Void __Gen_Wrap_51(System.Boolean P0) { }
        private System.Void __Gen_Wrap_52(System.Object P0, System.Boolean P1, System.Boolean P2) { }
        private System.Void __Gen_Wrap_53(System.Object P0, Beyond.DeviceInfo.InputType P1) { }
        private System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.HashSet<System.Int32>> __Gen_Wrap_54(System.Object P0) { }
        private System.Void __Gen_Wrap_55(System.Object P0, System.Single P1) { }
        private System.Void __Gen_Wrap_56(System.Object P0, Beyond.Input.KeyboardKeyCode P1) { }
        private System.Void __Gen_Wrap_57(Beyond.Input.KeyboardKeyCode P0) { }
        private System.Void __Gen_Wrap_58(Beyond.Input.GamepadKeyCode P0) { }
        private Beyond.DeviceInfo.ControllerType __Gen_Wrap_59(System.Object P0, System.Object P1) { }
        private System.String __Gen_Wrap_60(Beyond.Input.GamepadKeyCode P0) { }
        private System.String __Gen_Wrap_61() { }
        private System.String __Gen_Wrap_62(System.Object P0, System.Object P1, System.Boolean P2, System.Boolean P3) { }
        private System.String __Gen_Wrap_63(System.Object P0, System.Boolean P1, System.Boolean P2) { }
        private System.String __Gen_Wrap_64(System.Object P0, System.Boolean P1, System.Boolean P2, System.Boolean P3) { }
        private System.String __Gen_Wrap_65(Beyond.Input.KeyboardKeyCode P0) { }
        private System.Single __Gen_Wrap_66(System.Object P0, System.Boolean P1) { }
        private System.Void __Gen_Wrap_67(System.Object P0, Beyond.EventData<System.Boolean>& P1) { }
        private System.Boolean __Gen_Wrap_68(System.Object P0, System.Object P1, Beyond.Input.KeyboardKeyCode& P2) { }
        private System.Boolean __Gen_Wrap_69(System.Object P0, System.Object P1, Beyond.Input.KeyboardKeyCode& P2, System.Boolean& P3) { }
        private System.Boolean __Gen_Wrap_70(System.Object P0, Beyond.Input.GamepadKeyCode P1, Beyond.Input.InputManager.KeyCodeState P2) { }
        private System.Int32 __Gen_Wrap_71(System.Object P0, System.Object P1, System.Object P2, System.Int32 P3, System.String& P4) { }
        private System.Int32 __Gen_Wrap_72(System.Object P0, Beyond.Input.KeyboardKeyCode P1, System.Object P2, Beyond.Input.InputTimingType P3, System.Object P4, System.Int32 P5) { }
        private System.Boolean __Gen_Wrap_73(System.Object P0, System.Int32 P1, System.Boolean P2) { }
        private System.Void __Gen_Wrap_74(System.Object P0, System.Int32 P1, System.Object P2) { }
        private System.Void __Gen_Wrap_75(System.Object P0, System.Boolean P1, System.Int32 P2, System.Int32 P3) { }
        private System.Int32 __Gen_Wrap_76(System.Object P0, System.Boolean P1, System.Int32 P2) { }
        private Beyond.Input.KeyboardKeyCode __Gen_Wrap_77(System.Object P0, System.Object P1, System.Boolean P2, System.Boolean P3) { }
        private System.Boolean __Gen_Wrap_78(Beyond.Input.InputDeviceFlags P0, Beyond.Input.InputDeviceFlags P1) { }
        private System.Boolean __Gen_Wrap_79(System.Object P0, System.Object P1, Beyond.Input.InputDeviceFlags P2) { }
        private System.Void __Gen_Wrap_80(System.Object P0, System.Object P1, Beyond.Input.InputDeviceFlags P2) { }
        private System.Void __Gen_Wrap_81(System.Object P0, Beyond.Input.InputDeviceFlags P1) { }
        private System.String __Gen_Wrap_82(System.Object P0, System.Int32 P1) { }
        private System.Boolean __Gen_Wrap_83(System.Object P0, System.Object P1, Beyond.Input.KeyboardKeyCode P2, System.Boolean& P3) { }
        private System.Single __Gen_Wrap_84(System.Object P0, System.Object P1) { }
        private System.Void __Gen_Wrap_85(System.Object P0, System.Int32 P1, System.String& P2, Beyond.Input.IBindingView& P3) { }
        private System.Boolean __Gen_Wrap_86(System.Object P0, System.Object P1, Beyond.Input.KeyboardKeyCode P2, System.Boolean P3) { }
        private System.Boolean __Gen_Wrap_87(System.Object P0, System.Object P1, System.Nullable<Beyond.Input.GamepadKeyCode> P2, System.Nullable<Beyond.Input.GamepadKeyCode> P3, System.Boolean P4) { }
        private UnityEngine.Vector3 __Gen_Wrap_88() { }
        private System.Void __Gen_Wrap_89(UnityEngine.Vector2 P0, System.Boolean P1) { }
        private System.Void __Gen_Wrap_90(System.Object P0, UnityEngine.Vector2 P1) { }
        private System.Boolean __Gen_Wrap_91(System.Int32 P0) { }
        private System.Collections.Generic.List<Beyond.Input.InputManager.ControllerHintInfo> __Gen_Wrap_92(System.Object P0) { }
        private System.Void __Gen_Wrap_93(System.Object P0, System.Object P1, System.Boolean P2, System.Collections.Generic.List<Beyond.Input.InputManager.ControllerHintInfo>& P3) { }
        private System.Void __Gen_Wrap_94(System.Object P0, System.Int32 P1, System.Boolean P2, System.Collections.Generic.List<Beyond.Input.InputManager.ControllerHintInfo>& P3) { }
        private System.Void __Gen_Wrap_95(System.Object P0, System.Object P1, System.Collections.Generic.List<Beyond.Input.InputManager.ControllerHintInfo>& P2) { }
        private System.Single __Gen_Wrap_96(System.Object P0, System.Object P1, System.Single& P2) { }
        private System.Single __Gen_Wrap_97(System.Object P0, System.Int32 P1, System.Single& P2) { }
        private System.Void __Gen_Wrap_98(System.Object P0, System.Single P1, System.Single P2) { }
        private System.String __Gen_Wrap_99(System.Text.RegularExpressions.Match P0) { }
        private System.Void __Gen_Wrap_100(System.Object P0, System.Object P1, System.Object P2, System.Boolean P3) { }
        private System.Boolean __Gen_Wrap_101(System.Int32 P0, UnityEngine.Vector2& P1) { }
        private System.Int32 __Gen_Wrap_102(System.Object P0, System.Object P1) { }
        private System.Collections.Generic.List<Beyond.DynamicFastLookupCollection<Beyond.Input.KeyboardKeyCode,System.Collections.Generic.HashSet<Beyond.Input.KeyboardCheckerBase.Binding>>> __Gen_Wrap_103(System.Object P0) { }
        private System.Void __Gen_Wrap_104(System.Object P0, System.Object P1, Beyond.Input.KeyboardKeyCode P2) { }
        private System.Void __Gen_Wrap_105(System.Object P0, System.Object P1, System.Object P2, System.Object P3) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000044
    public class ILFixInterfaceBridge : AnonymousStorey
    {
        // Methods
        private System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        private System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x2000045
    public class WrappersManagerImpl, WrappersManager
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10

        // Methods
        private System.Void .ctor(IFix.Core.VirtualMachine virtualMachine) { }
        private IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        private System.Boolean IsPatched(System.Int32 id) { }
        private System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon) { }
        private System.Object CreateWrapper(System.Int32 id) { }
        private System.Object InitWrapperArray(System.Int32 len) { }
        private IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine) { }

    }

    // TypeToken: 0x2000046
    public struct IDMAP0
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static IFix.IDMAP0 Beyond-Input-InputBindingGroup-get_enabled0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputBindingInfo-_GetNextEnabledPriority0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputBindingInfo-StopContinuousTrigger0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputBindingInfo-OnGroupEnabledChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputBindingGroup-OnParentEnabledChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputBindingGroup-_OnBindingGroupStateChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputBindingGroup-SetSelfEnabled0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-ToggleGroup0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-SetNaviBindingType0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-IsGroupEnabled0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-IsNavigationBindingEnabled0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-UpdateNaviInputBindingState0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-_RemoveLayerFromStack0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-_RemoveLayer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-_OnLayerSelected0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-_SetTarget0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-GetNaviVector0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-_GetPointOnRectEdge0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-_TryFindBestNaviTarget0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-_TryFindBestNaviTargetInGroup0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-SetTarget0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-_DefaultNavigate0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-SetForceEnableNavi0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-TryAutoSetTarget0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-TryRemoveLayer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-IsLayerInStack0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-IsTopLayer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-ChangeAndTrySetNaviBindingType0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-SetTargetInSilentModeIfNecessary0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-IsNaviTarget0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-Navigate0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-ControllerNaviManager-ToggleNavigation0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-GamepadCheckerBase-get_normalBindingInfos0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-GamepadCheckerBase-get_modifyBindingInfos0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-GamepadCheckerBase-GetInputDic0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-GamepadCheckerBase-OnCreateBinding0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-GamepadCheckerBase-OnDeleteBinding0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-GamepadCheckerBase-CheckDic0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-GamepadCheckerBase-CheckGamepadInput0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-GamepadCheckerBase-TriggerActions0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputBindingInfo-get_enabled0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputBindingInfo-_RealTriggerCallback0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputBindingInfo-_TryContinuousTrigger0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputBindingInfo-StartContinuousTrigger0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputBindingInfo-Trigger0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-GamepadChecker-CheckDic0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-GamepadOnClickChecker-CheckDic0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-GamepadOnClickChecker-ClearKeyPressed0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-GamepadOnLongPressChecker-_OnTriggerBinding0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-GamepadOnLongPressChecker-CreateTriggerBindingAction0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-GamepadOnLongPressChecker-CheckDic0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-GamepadOnLongPressChecker-OnCreateBinding0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-GamepadOnLongPressChecker-OnDeleteBinding0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-GamepadOnLongPressChecker-GetInputLongPressStartTime0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-GamepadOnReleaseChecker-CheckGamepadInput0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-GamepadOnReleaseChecker-CheckDic0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-_SetActionCallback0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-_SetAction0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-set_leftButtonAction0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-set_rightButtonAction0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-set_middleButtonAction0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-set_forwardButtonAction0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-set_backButtonAction0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-SetMouseIconVisible0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-_OnButtonActionTriggered0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-CreateGroup0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-TriggerLeftButton0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetPlayerActionInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-KeyboardCheckerBase-GetModifyIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-KeyboardCheckerBase-OnCreateBinding0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_AddPlayerActionCheck0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_AddPlayerActionCheck1;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_AddPlayerActionCheck2;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-CreateBindingByActionId0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-_ChangeHoverState0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-ChangeHoverState0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-_SyncScale0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-_UpdateMotion0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-ClearLeftButtonState0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-OnAfterInputUpdate0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-Update0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-GetCurHoverSelectable0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-KeyboardCheckerBase-OnDeleteBinding0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_RemovePlayerActionCheck0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_RemovePlayerActionCheck1;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_RemovePlayerActionCheck2;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputBindingInfo-OnDelete0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_RealRemoveBindingInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_DeleteInGroup0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_DeleteGroup0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-DeleteGroup0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-HGVirtualMouse-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetActionText0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetActionText1;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputBindingInfo-get_text0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputBindingInfo-ChangeGroup0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputBindingInfo-SetSelfEnabled0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputBindingInfo-SetParentIgnored0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputBindingInfo-GetCallbackTarget0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputBindingGroup-get_groupView0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputBindingGroup-ChangeParent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputBindingGroup-SetParentIgnored0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputBindingGroupMonoTarget-get_groupEnabled0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputBindingGroupMonoTarget-UpdateState0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputBindingGroupMonoTarget-Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputBindingGroupMonoTarget-DeleteGroup0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputBindingGroupMonoTarget-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputBindingGroupMonoTarget-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputBindingGroupMonoTarget-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputBindingGroupMonoTarget-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-get_cursorVisible0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetGamepadStickValue0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-get_mouseScrollDelta0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-get_multiTouchEnabled0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-set_multiTouchEnabled0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-RealCursorManager-_ToggleCursorInternal0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-RealCursorManager-IsNeedShowCursor0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-RealCursorManager-CalcState0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-RealCursorManager-SetForceHideCursorForController0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_ToggleVirtualMouse0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_CheckVirtualMouseState0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-ToggleBinding0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_RefreshDeviceChangeBinding0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_SyncUsingControllerState0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-RealCursorManager-ToggleCursorInHideCursorMode0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-ToggleCursorInHideCursorMode0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-ChangeInputTypeAndSyncState0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_TryChangeInputDeviceType0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-set_usingController0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-get_action2BindingDic0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-TryClickSkillButtonWhenControllerIndicatorJustRelease0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_UpdateControllerIndicator0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-LateTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_CreateTickFunction0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-KeyboardOnClickChecker-ClearKeyPressed0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_LoadCustomInputSetting0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_LoadSetting0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_GetControllerType0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_SetJoystick0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_OnControllerConnected0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_TryFindGamepad0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_OnControllerDisconnected0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_CreateDebugVirtualMouse0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetStringByGamepadKeyCode0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_GetGamepadKeyIconFolderPath0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_GetKeyIconPath0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetGamepadKeyIconPath0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetKeyIconPath0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetStringByKeyboardKeyCode0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetKeyIconPath1;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetKeyIconPath2;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_CreateVirtualMouse0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_CreateCanvas0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_InitDeviceChangeBinding0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-KeyCaches-UpdateKeyStat0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetGamepadTriggerValue0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-AnyGamepadKey0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_CheckAnyKeyForTouchChangeDevice0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-AnyMouseKeyUp0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_AnyKeyDownForKeyboardChangeDevice0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_CheckAnyKeyForKeyboardChangeDevice0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-CheckUsingController0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-KeyboardCheckerBase-CheckKeyboardInput0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-KeyboardCheckerBase-TriggerActions0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_ControllerTouchPanelTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_CheckInput0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_OnAfterInputUpdate0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_OnNetMaskChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_OnFocusedInputFieldChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_ClearTickFunction0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-Release0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_ClearEvents0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-OnApplicationQuit0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-OnApplicationFocus0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-RealCursorManager-ResetCursorInHideCursorMode0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-ResetCursorInHideCursorMode0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-ToggleInputDeviceChangeMode0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-RealCursorManager-ToggleForceShowRealCursorForChangeInput0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-ToggleForceShowRealCursor0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_AnyKeyboardKey0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-AnyKeyboardKey0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-AnyMouseKey0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-AnyKeyDown0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_CheckGamepadKeyCode0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-AddAnonymousPlayerAction0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-CreateBinding0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-CreateBinding1;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-CreateBinding2;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-DeleteBinding0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-DeleteInGroup0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-IsBindingEnabled0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-ForceBindingKeyhintToGray0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-IsBindingKeyhintGray0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-RealCursorManager-SetDebugShowCursorMode0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-ToggleHideCursor0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-ToggleAllInput0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-SetBindingView0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-SetGroupView0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-ChangeParent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetGroupParentId0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-IgnoreBindingGroupParent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-IgnoreBindingParent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetActionKeyboardKeyCode0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputUtils-HasFlag0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-PlayerActionInfo-DeviceInputEquals0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-PlayerActionInfo-DeviceInputCopyFrom0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-DeleteCustomBinding0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-DeleteAllCustomBindings0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-SetBindingText0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetBindingText0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-HasBinding0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-CheckActionKeyCodeConflict0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetAxis0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetBindingInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_RefreshControllerBattleButton0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-LoadSetting0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-IsPlayerActionIdValid0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-ChangePlayerAction0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_GetOrCreatePendingActionInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-CustomizeActionKey0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-CustomizeActionKey1;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-ClearPendingInputSetting0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-SaveCustomInputSetting0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetMousePos0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-SetVirtualMouseIconVisible0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-SetMousePos0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-SetOnlyVirtualMousePos0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetMouseButton0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-IsLeftMouseDown0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetMouseButtonDown0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetMouseButtonUp0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-SetCustomControllerMouse0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetEmptyControllerHintInfoList0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-ControllerHintInfo-Reset0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_GetControllerHintInfos0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetControllerHintInfos0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-ControllerHintInfo-Reset1;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-_GetControllerHintInfos1;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetControllerHintInfos1;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-KeyboardOnLongPressChecker-GetInputLongPressStartTime0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetPlayerActionLongPressStartTime0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetActionBindingLongPressStartTime0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetControllerIndicatorState0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-TryPressControllerIndicatorWhenSkillButtonJustPressed0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-AddGuideUseActionId0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-RemoveGuideUseActionId0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-ClearGuideUseActionIds0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-VibrateController0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-ParseTextActionId0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-MoveMouseTo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-MoveVirtualMouseTo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetTouchId0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetPressPosByTouchId0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-RemoveUnusedInput0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-GetCurJsInfos0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-ControllerHintInfo-CompareTo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-ControllerHintInfo-OnAllocate0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputManager-ControllerHintInfo-OnRecycle0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputUtils-IgnoreBindingParent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-InputUtils-IgnoreBindingGroupParent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-KeyboardCheckerBase-get_bindingInfos0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-KeyboardChecker-CheckKeyboardInput0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-KeyboardChecker-TriggerActions0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-KeyboardOnClickChecker-CheckKeyboardInput0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-KeyboardOnClickChecker-TriggerActions0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-KeyboardOnLongPressChecker-_OnTriggerBinding0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-KeyboardOnLongPressChecker-CheckKeyboardInput0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-KeyboardOnLongPressChecker-OnCreateBinding0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-KeyboardOnLongPressChecker-OnDeleteBinding0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-PlayerActionInfo-ResetHintProority0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-KeyboardInput-GetModifyText0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-KeyboardInput-GetKeyCodeText0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-KeyboardInput-GetKeyCodeEnumIntValue0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-KeyboardInput-SetKeyCodeEnumByIntValue0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-KeyboardInput-get_modifyString0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-KeyboardInput-ClearKeyCode0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-KeyboardInput-IsValid0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-KeyboardInput-CopyFrom0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-KeyboardInput-Equals0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-GamepadInput-GetModifyText0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-GamepadInput-GetKeyCodeText0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-GamepadInput-GetKeyCodeEnumIntValue0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-GamepadInput-SetKeyCodeEnumByIntValue0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-GamepadInput-ClearKeyCode0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-GamepadInput-IsValid0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-GamepadInput-CopyFrom0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-GamepadInput-Equals0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-UIEvent-get_bindingEnabled0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-UIEvent-_CreatePlayerActionBinding0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-UIEvent-InitBinding0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-UIEvent-Invoke0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-UIEvent-UpdateKeys0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-UIEvent-ChangeBindingPlayerAction0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-UIEvent-AddListener0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-UIEvent-RemoveListener0;        // 0x0
        public static IFix.IDMAP0 Beyond-Input-UIEvent-RemoveAllListeners0;        // 0x0

    }

}

namespace UnityEngine.InputSystem.UI
{

    // TypeToken: 0x2000003
    public class DebugVirtualMouseInput : MonoBehaviour
    {
        // Fields
        private UnityEngine.InputSystem.UI.DebugVirtualMouseInput.CursorMode m_CursorMode;        // 0x18
        private UnityEngine.UI.Graphic m_CursorGraphic;        // 0x20
        private UnityEngine.RectTransform m_CursorTransform;        // 0x28
        private UnityEngine.RectTransform _canvasTransform;        // 0x30
        private UnityEngine.Canvas m_Canvas;        // 0x38
        private System.Single m_CursorSpeed;        // 0x40
        private System.Single m_ScrollSpeed;        // 0x44
        private UnityEngine.InputSystem.InputActionProperty m_StickAction;        // 0x48
        private UnityEngine.InputSystem.InputActionProperty m_LeftButtonAction;        // 0x60
        private UnityEngine.InputSystem.InputActionProperty m_MiddleButtonAction;        // 0x78
        private UnityEngine.InputSystem.InputActionProperty m_RightButtonAction;        // 0x90
        private UnityEngine.InputSystem.InputActionProperty m_ForwardButtonAction;        // 0xA8
        private UnityEngine.InputSystem.InputActionProperty m_BackButtonAction;        // 0xC0
        private UnityEngine.InputSystem.InputActionProperty m_ScrollWheelAction;        // 0xD8
        private UnityEngine.InputSystem.Mouse m_VirtualMouse;        // 0xF0
        private UnityEngine.InputSystem.Mouse m_SystemMouse;        // 0xF8
        private System.Action m_AfterInputUpdateDelegate;        // 0x100
        private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_ButtonActionTriggeredDelegate;        // 0x108
        private System.Double m_LastTime;        // 0x110
        private UnityEngine.Vector2 m_LastStickValue;        // 0x118
        private System.Single m_canvasScale;        // 0x120

        // Methods
        private UnityEngine.RectTransform get_cursorTransform() { }
        private System.Void set_cursorTransform(UnityEngine.RectTransform value) { }
        private System.Single get_cursorSpeed() { }
        private System.Void set_cursorSpeed(System.Single value) { }
        private UnityEngine.InputSystem.UI.DebugVirtualMouseInput.CursorMode get_cursorMode() { }
        private System.Void set_cursorMode(UnityEngine.InputSystem.UI.DebugVirtualMouseInput.CursorMode value) { }
        private UnityEngine.UI.Graphic get_cursorGraphic() { }
        private System.Void set_cursorGraphic(UnityEngine.UI.Graphic value) { }
        private System.Single get_scrollSpeed() { }
        private System.Void set_scrollSpeed(System.Single value) { }
        private UnityEngine.InputSystem.Mouse get_virtualMouse() { }
        private UnityEngine.InputSystem.InputActionProperty get_stickAction() { }
        private System.Void set_stickAction(UnityEngine.InputSystem.InputActionProperty value) { }
        private UnityEngine.InputSystem.InputActionProperty get_leftButtonAction() { }
        private System.Void set_leftButtonAction(UnityEngine.InputSystem.InputActionProperty value) { }
        private UnityEngine.InputSystem.InputActionProperty get_rightButtonAction() { }
        private System.Void set_rightButtonAction(UnityEngine.InputSystem.InputActionProperty value) { }
        private UnityEngine.InputSystem.InputActionProperty get_middleButtonAction() { }
        private System.Void set_middleButtonAction(UnityEngine.InputSystem.InputActionProperty value) { }
        private UnityEngine.InputSystem.InputActionProperty get_forwardButtonAction() { }
        private System.Void set_forwardButtonAction(UnityEngine.InputSystem.InputActionProperty value) { }
        private UnityEngine.InputSystem.InputActionProperty get_backButtonAction() { }
        private System.Void set_backButtonAction(UnityEngine.InputSystem.InputActionProperty value) { }
        private UnityEngine.InputSystem.InputActionProperty get_scrollWheelAction() { }
        private System.Void set_scrollWheelAction(UnityEngine.InputSystem.InputActionProperty value) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void _TryFindCanvas() { }
        private System.Void _TryEnableHardwareCursor() { }
        private System.Void _SyncScale() { }
        private System.Void _UpdateMotion() { }
        private System.Void _OnButtonActionTriggered(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void _SetActionCallback(UnityEngine.InputSystem.InputActionProperty field, System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> callback, System.Boolean install) { }
        private System.Void _SetAction(UnityEngine.InputSystem.InputActionProperty& field, UnityEngine.InputSystem.InputActionProperty value) { }
        private System.Void _OnAfterInputUpdate() { }
        private System.Void .ctor() { }

    }

}

