// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.IMGUIModule.dll
// Classes:  45
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x200000A
    public class WindowFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Int32 id) { }

    }

    // TypeToken: 0x200000C
    public struct ParentClipScope, IDisposable
    {
        // Fields
        private System.Boolean m_Disposed;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.Matrix4x4 objectTransform, UnityEngine.Rect clipRect) { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x2000012
    public struct Type
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.GUILayoutOption.Type fixedWidth;        // 0x0
        public static UnityEngine.GUILayoutOption.Type fixedHeight;        // 0x0
        public static UnityEngine.GUILayoutOption.Type minWidth;        // 0x0
        public static UnityEngine.GUILayoutOption.Type maxWidth;        // 0x0
        public static UnityEngine.GUILayoutOption.Type minHeight;        // 0x0
        public static UnityEngine.GUILayoutOption.Type maxHeight;        // 0x0
        public static UnityEngine.GUILayoutOption.Type stretchWidth;        // 0x0
        public static UnityEngine.GUILayoutOption.Type stretchHeight;        // 0x0
        public static UnityEngine.GUILayoutOption.Type alignStart;        // 0x0
        public static UnityEngine.GUILayoutOption.Type alignMiddle;        // 0x0
        public static UnityEngine.GUILayoutOption.Type alignEnd;        // 0x0
        public static UnityEngine.GUILayoutOption.Type alignJustify;        // 0x0
        public static UnityEngine.GUILayoutOption.Type equalSize;        // 0x0
        public static UnityEngine.GUILayoutOption.Type spacing;        // 0x0

    }

    // TypeToken: 0x2000014
    public class LayoutCache
    {
        // Fields
        private System.Int32 <id>k__BackingField;        // 0x10
        private UnityEngine.GUILayoutGroup topLevel;        // 0x18
        private UnityEngineInternal.GenericStack layoutGroups;        // 0x20
        private UnityEngine.GUILayoutGroup windows;        // 0x28

        // Methods
        private System.Void set_id(System.Int32 value) { }
        private System.Void .ctor(System.Int32 instanceID) { }
        private System.Void ResetCursor() { }

    }

    // TypeToken: 0x2000017
    public class SkinChangedDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }

    }

    // TypeToken: 0x2000029
    public struct DblClickSnapping
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static UnityEngine.TextEditor.DblClickSnapping WORDS;        // 0x0
        public static UnityEngine.TextEditor.DblClickSnapping PARAGRAPHS;        // 0x0

    }

    // TypeToken: 0x200002A
    public struct CharacterType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TextEditor.CharacterType LetterLike;        // 0x0
        public static UnityEngine.TextEditor.CharacterType Symbol;        // 0x0
        public static UnityEngine.TextEditor.CharacterType Symbol2;        // 0x0
        public static UnityEngine.TextEditor.CharacterType WhiteSpace;        // 0x0

    }

    // TypeToken: 0x200002B
    public struct Direction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TextEditor.Direction Forward;        // 0x0
        public static UnityEngine.TextEditor.Direction Backward;        // 0x0

    }

    // TypeToken: 0x200002C
    public struct TextEditOp
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TextEditor.TextEditOp MoveLeft;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp MoveRight;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp MoveUp;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp MoveDown;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp MoveLineStart;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp MoveLineEnd;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp MoveTextStart;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp MoveTextEnd;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp MovePageUp;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp MovePageDown;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp MoveGraphicalLineStart;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp MoveGraphicalLineEnd;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp MoveWordLeft;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp MoveWordRight;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp MoveParagraphForward;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp MoveParagraphBackward;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp MoveToStartOfNextWord;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp MoveToEndOfPreviousWord;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp SelectLeft;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp SelectRight;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp SelectUp;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp SelectDown;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp SelectTextStart;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp SelectTextEnd;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp SelectPageUp;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp SelectPageDown;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp ExpandSelectGraphicalLineStart;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp ExpandSelectGraphicalLineEnd;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp SelectGraphicalLineStart;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp SelectGraphicalLineEnd;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp SelectWordLeft;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp SelectWordRight;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp SelectToEndOfPreviousWord;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp SelectToStartOfNextWord;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp SelectParagraphBackward;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp SelectParagraphForward;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp Delete;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp Backspace;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp DeleteWordBack;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp DeleteWordForward;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp DeleteLineBack;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp Cut;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp Copy;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp Paste;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp SelectAll;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp SelectNone;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp ScrollStart;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp ScrollEnd;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp ScrollPageUp;        // 0x0
        public static UnityEngine.TextEditor.TextEditOp ScrollPageDown;        // 0x0

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
    public class IsReadOnlyAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace UnityEngine
{

    // TypeToken: 0x2000004
    public class Event
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10
        private static UnityEngine.Event s_Current;        // 0x0
        private static UnityEngine.Event s_MasterEvent;        // 0x8

        // Methods
        private UnityEngine.EventType get_rawType() { }
        private UnityEngine.Vector2 get_mousePosition() { }
        private System.Void set_mousePosition(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 get_delta() { }
        private System.Void set_delta(UnityEngine.Vector2 value) { }
        private UnityEngine.PointerType get_pointerType() { }
        private System.Int32 get_button() { }
        private UnityEngine.EventModifiers get_modifiers() { }
        private System.Void set_modifiers(UnityEngine.EventModifiers value) { }
        private System.Single get_pressure() { }
        private System.Int32 get_clickCount() { }
        private System.Char get_character() { }
        private System.Void set_character(System.Char value) { }
        private UnityEngine.KeyCode get_keyCode() { }
        private System.Void set_keyCode(UnityEngine.KeyCode value) { }
        private System.Int32 get_displayIndex() { }
        private System.Void set_displayIndex(System.Int32 value) { }
        private UnityEngine.EventType get_type() { }
        private System.Void set_type(UnityEngine.EventType value) { }
        private System.String get_commandName() { }
        private System.Void set_commandName(System.String value) { }
        private System.Void Internal_Use() { }
        private System.IntPtr Internal_Create(System.Int32 displayIndex) { }
        private System.Void Internal_Destroy(System.IntPtr ptr) { }
        private UnityEngine.EventType GetTypeForControl(System.Int32 controlID) { }
        private System.Void CopyFromPtr(System.IntPtr ptr) { }
        private System.Boolean PopEvent(UnityEngine.Event outEvent) { }
        private System.Void Internal_SetNativeEvent(System.IntPtr ptr) { }
        private System.Void Internal_MakeMasterEventCurrent(System.Int32 displayIndex) { }
        private System.Int32 GetDoubleClickTime() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 displayIndex) { }
        private System.Void Finalize() { }
        private System.Void CopyFrom(UnityEngine.Event e) { }
        private System.Boolean get_shift() { }
        private System.Boolean get_control() { }
        private System.Boolean get_alt() { }
        private System.Boolean get_command() { }
        private UnityEngine.Event get_current() { }
        private System.Void set_current(UnityEngine.Event value) { }
        private System.Boolean get_isKey() { }
        private System.Boolean get_isMouse() { }
        private System.Boolean get_isDirectManipulationDevice() { }
        private UnityEngine.Event KeyboardEvent(System.String key) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.String ToString() { }
        private System.Void Use() { }
        private System.Void get_mousePosition_Injected(UnityEngine.Vector2& ret) { }
        private System.Void set_mousePosition_Injected(UnityEngine.Vector2& value) { }
        private System.Void get_delta_Injected(UnityEngine.Vector2& ret) { }
        private System.Void set_delta_Injected(UnityEngine.Vector2& value) { }

    }

    // TypeToken: 0x2000005
    public struct EventType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.EventType MouseDown;        // 0x0
        public static UnityEngine.EventType MouseUp;        // 0x0
        public static UnityEngine.EventType MouseMove;        // 0x0
        public static UnityEngine.EventType MouseDrag;        // 0x0
        public static UnityEngine.EventType KeyDown;        // 0x0
        public static UnityEngine.EventType KeyUp;        // 0x0
        public static UnityEngine.EventType ScrollWheel;        // 0x0
        public static UnityEngine.EventType Repaint;        // 0x0
        public static UnityEngine.EventType Layout;        // 0x0
        public static UnityEngine.EventType DragUpdated;        // 0x0
        public static UnityEngine.EventType DragPerform;        // 0x0
        public static UnityEngine.EventType DragExited;        // 0x0
        public static UnityEngine.EventType Ignore;        // 0x0
        public static UnityEngine.EventType Used;        // 0x0
        public static UnityEngine.EventType ValidateCommand;        // 0x0
        public static UnityEngine.EventType ExecuteCommand;        // 0x0
        public static UnityEngine.EventType ContextClick;        // 0x0
        public static UnityEngine.EventType MouseEnterWindow;        // 0x0
        public static UnityEngine.EventType MouseLeaveWindow;        // 0x0
        public static UnityEngine.EventType TouchDown;        // 0x0
        public static UnityEngine.EventType TouchUp;        // 0x0
        public static UnityEngine.EventType TouchMove;        // 0x0
        public static UnityEngine.EventType TouchEnter;        // 0x0
        public static UnityEngine.EventType TouchLeave;        // 0x0
        public static UnityEngine.EventType TouchStationary;        // 0x0
        public static UnityEngine.EventType mouseDown;        // 0x0
        public static UnityEngine.EventType mouseUp;        // 0x0
        public static UnityEngine.EventType mouseMove;        // 0x0
        public static UnityEngine.EventType mouseDrag;        // 0x0
        public static UnityEngine.EventType keyDown;        // 0x0
        public static UnityEngine.EventType keyUp;        // 0x0
        public static UnityEngine.EventType scrollWheel;        // 0x0
        public static UnityEngine.EventType repaint;        // 0x0
        public static UnityEngine.EventType layout;        // 0x0
        public static UnityEngine.EventType dragUpdated;        // 0x0
        public static UnityEngine.EventType dragPerform;        // 0x0
        public static UnityEngine.EventType ignore;        // 0x0
        public static UnityEngine.EventType used;        // 0x0

    }

    // TypeToken: 0x2000006
    public struct EventModifiers
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.EventModifiers None;        // 0x0
        public static UnityEngine.EventModifiers Shift;        // 0x0
        public static UnityEngine.EventModifiers Control;        // 0x0
        public static UnityEngine.EventModifiers Alt;        // 0x0
        public static UnityEngine.EventModifiers Command;        // 0x0
        public static UnityEngine.EventModifiers Numeric;        // 0x0
        public static UnityEngine.EventModifiers CapsLock;        // 0x0
        public static UnityEngine.EventModifiers FunctionKey;        // 0x0

    }

    // TypeToken: 0x2000007
    public struct PointerType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.PointerType Mouse;        // 0x0
        public static UnityEngine.PointerType Touch;        // 0x0
        public static UnityEngine.PointerType Pen;        // 0x0

    }

    // TypeToken: 0x2000008
    public struct EventInterests
    {
        // Fields
        private System.Boolean <wantsMouseMove>k__BackingField;        // 0x10
        private System.Boolean <wantsMouseEnterLeaveWindow>k__BackingField;        // 0x11
        private System.Boolean <wantsLessLayoutEvents>k__BackingField;        // 0x12

        // Methods
        private System.Boolean get_wantsMouseMove() { }
        private System.Void set_wantsMouseMove(System.Boolean value) { }
        private System.Boolean get_wantsMouseEnterLeaveWindow() { }
        private System.Void set_wantsMouseEnterLeaveWindow(System.Boolean value) { }
        private System.Boolean get_wantsLessLayoutEvents() { }
        private System.Boolean WantsEvent(UnityEngine.EventType type) { }
        private System.Boolean WantsLayoutPass(UnityEngine.EventType type) { }

    }

    // TypeToken: 0x2000009
    public class GUI
    {
        // Fields
        private static System.Int32 s_ScrollControlId;        // 0x0
        private static System.Int32 s_HotTextField;        // 0x4
        private static readonly System.Int32 s_BoxHash;        // 0x8
        private static readonly System.Int32 s_ButonHash;        // 0xC
        private static readonly System.Int32 s_RepeatButtonHash;        // 0x10
        private static readonly System.Int32 s_ToggleHash;        // 0x14
        private static readonly System.Int32 s_ButtonGridHash;        // 0x18
        private static readonly System.Int32 s_SliderHash;        // 0x1C
        private static readonly System.Int32 s_BeginGroupHash;        // 0x20
        private static readonly System.Int32 s_ScrollviewHash;        // 0x24
        private static System.Int32 <scrollTroughSide>k__BackingField;        // 0x28
        private static System.DateTime <nextScrollStepTime>k__BackingField;        // 0x30
        private static UnityEngine.GUISkin s_Skin;        // 0x38
        private static UnityEngine.Rect s_ToolTipRect;        // 0x40
        private static UnityEngineInternal.GenericStack <scrollViewStates>k__BackingField;        // 0x50

        // Methods
        private UnityEngine.Color get_color() { }
        private System.Void set_color(UnityEngine.Color value) { }
        private UnityEngine.Color get_backgroundColor() { }
        private System.Void set_backgroundColor(UnityEngine.Color value) { }
        private UnityEngine.Color get_contentColor() { }
        private System.Void set_contentColor(UnityEngine.Color value) { }
        private System.Boolean get_changed() { }
        private System.Void set_changed(System.Boolean value) { }
        private System.Boolean get_enabled() { }
        private System.Void set_enabled(System.Boolean value) { }
        private System.Boolean get_usePageScrollbars() { }
        private UnityEngine.Material get_blendMaterial() { }
        private UnityEngine.Material get_blitMaterial() { }
        private UnityEngine.Material get_roundedRectMaterial() { }
        private UnityEngine.Material get_roundedRectWithColorPerBorderMaterial() { }
        private System.Void GrabMouseControl(System.Int32 id) { }
        private System.Boolean HasMouseControl(System.Int32 id) { }
        private System.Void ReleaseMouseControl() { }
        private System.Void InternalRepaintEditorWindow() { }
        private System.Void .cctor() { }
        private System.Int32 get_scrollTroughSide() { }
        private System.Void set_scrollTroughSide(System.Int32 value) { }
        private System.DateTime get_nextScrollStepTime() { }
        private System.Void set_nextScrollStepTime(System.DateTime value) { }
        private System.Void set_skin(UnityEngine.GUISkin value) { }
        private UnityEngine.GUISkin get_skin() { }
        private System.Void DoSetSkin(UnityEngine.GUISkin newSkin) { }
        private UnityEngine.Matrix4x4 get_matrix() { }
        private System.Void set_matrix(UnityEngine.Matrix4x4 value) { }
        private System.Void Label(UnityEngine.Rect position, System.String text) { }
        private System.Void Label(UnityEngine.Rect position, System.String text, UnityEngine.GUIStyle style) { }
        private System.Void Label(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style) { }
        private System.Void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image) { }
        private System.Void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode) { }
        private System.Void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, System.Boolean alphaBlend) { }
        private System.Void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, System.Boolean alphaBlend, System.Single imageAspect) { }
        private System.Void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, System.Boolean alphaBlend, System.Single imageAspect, UnityEngine.Color color, System.Single borderWidth, System.Single borderRadius) { }
        private System.Void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, System.Boolean alphaBlend, System.Single imageAspect, UnityEngine.Color color, UnityEngine.Vector4 borderWidths, System.Single borderRadius) { }
        private System.Void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, System.Boolean alphaBlend, System.Single imageAspect, UnityEngine.Color color, UnityEngine.Vector4 borderWidths, UnityEngine.Vector4 borderRadiuses) { }
        private System.Void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, System.Boolean alphaBlend, System.Single imageAspect, UnityEngine.Color color, UnityEngine.Vector4 borderWidths, UnityEngine.Vector4 borderRadiuses, System.Boolean drawSmoothCorners) { }
        private System.Void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, System.Boolean alphaBlend, System.Single imageAspect, UnityEngine.Color leftColor, UnityEngine.Color topColor, UnityEngine.Color rightColor, UnityEngine.Color bottomColor, UnityEngine.Vector4 borderWidths, UnityEngine.Vector4 borderRadiuses, System.Boolean drawSmoothCorners) { }
        private System.Boolean CalculateScaledTextureRects(UnityEngine.Rect position, UnityEngine.ScaleMode scaleMode, System.Single imageAspect, UnityEngine.Rect& outScreenRect, UnityEngine.Rect& outSourceRect) { }
        private System.Void Box(UnityEngine.Rect position, System.String text) { }
        private System.Void Box(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style) { }
        private System.Boolean DoRepeatButton(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.FocusType focusType) { }
        private System.Boolean Toggle(UnityEngine.Rect position, System.Boolean value, UnityEngine.GUIContent content, UnityEngine.GUIStyle style) { }
        private System.Boolean DoControl(UnityEngine.Rect position, System.Int32 id, System.Boolean on, System.Boolean hover, UnityEngine.GUIContent content, UnityEngine.GUIStyle style) { }
        private System.Void DoLabel(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style) { }
        private System.Boolean DoToggle(UnityEngine.Rect position, System.Int32 id, System.Boolean value, UnityEngine.GUIContent content, UnityEngine.GUIStyle style) { }
        private System.Single Slider(UnityEngine.Rect position, System.Single value, System.Single size, System.Single start, System.Single end, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, System.Boolean horiz, System.Int32 id, UnityEngine.GUIStyle thumbExtent) { }
        private System.Single HorizontalScrollbar(UnityEngine.Rect position, System.Single value, System.Single size, System.Single leftValue, System.Single rightValue, UnityEngine.GUIStyle style) { }
        private System.Boolean ScrollerRepeatButton(System.Int32 scrollerID, UnityEngine.Rect rect, UnityEngine.GUIStyle style) { }
        private System.Single VerticalScrollbar(UnityEngine.Rect position, System.Single value, System.Single size, System.Single topValue, System.Single bottomValue, UnityEngine.GUIStyle style) { }
        private System.Single Scroller(UnityEngine.Rect position, System.Single value, System.Single size, System.Single leftValue, System.Single rightValue, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, UnityEngine.GUIStyle leftButton, UnityEngine.GUIStyle rightButton, System.Boolean horiz) { }
        private System.Void BeginGroup(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style) { }
        private System.Void BeginGroup(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.Vector2 scrollOffset) { }
        private System.Void EndGroup() { }
        private UnityEngineInternal.GenericStack get_scrollViewStates() { }
        private UnityEngine.Vector2 BeginScrollView(UnityEngine.Rect position, UnityEngine.Vector2 scrollPosition, UnityEngine.Rect viewRect) { }
        private UnityEngine.Vector2 BeginScrollView(UnityEngine.Rect position, UnityEngine.Vector2 scrollPosition, UnityEngine.Rect viewRect, System.Boolean alwaysShowHorizontal, System.Boolean alwaysShowVertical, UnityEngine.GUIStyle horizontalScrollbar, UnityEngine.GUIStyle verticalScrollbar, UnityEngine.GUIStyle background) { }
        private System.Void EndScrollView() { }
        private System.Void EndScrollView(System.Boolean handleScrollWheel) { }
        private System.Void CallWindowDelegate(UnityEngine.GUI.WindowFunction func, System.Int32 id, System.Int32 instanceID, UnityEngine.GUISkin _skin, System.Int32 forceRect, System.Single width, System.Single height, UnityEngine.GUIStyle style) { }
        private System.Void get_color_Injected(UnityEngine.Color& ret) { }
        private System.Void set_color_Injected(UnityEngine.Color& value) { }
        private System.Void get_backgroundColor_Injected(UnityEngine.Color& ret) { }
        private System.Void set_backgroundColor_Injected(UnityEngine.Color& value) { }
        private System.Void get_contentColor_Injected(UnityEngine.Color& ret) { }
        private System.Void set_contentColor_Injected(UnityEngine.Color& value) { }

    }

    // TypeToken: 0x200000B
    public class GUIClip
    {
        // Methods
        private UnityEngine.Rect get_visibleRect() { }
        private System.Void Internal_Push(UnityEngine.Rect screenRect, UnityEngine.Vector2 scrollOffset, UnityEngine.Vector2 renderOffset, System.Boolean resetOffset) { }
        private System.Void Internal_Pop() { }
        private System.Int32 Internal_GetCount() { }
        private UnityEngine.Vector2 Unclip_Vector2(UnityEngine.Vector2 pos) { }
        private UnityEngine.Vector2 UnclipToWindow_Vector2(UnityEngine.Vector2 pos) { }
        private UnityEngine.Vector2 ClipToWindow_Vector2(UnityEngine.Vector2 absolutePos) { }
        private UnityEngine.Matrix4x4 GetMatrix() { }
        private System.Void SetMatrix(UnityEngine.Matrix4x4 m) { }
        private System.Void Internal_PushParentClip(UnityEngine.Matrix4x4 objectTransform, UnityEngine.Rect clipRect) { }
        private System.Void Internal_PushParentClip(UnityEngine.Matrix4x4 renderTransform, UnityEngine.Matrix4x4 inputTransform, UnityEngine.Rect clipRect) { }
        private System.Void Internal_PopParentClip() { }
        private System.Void Push(UnityEngine.Rect screenRect, UnityEngine.Vector2 scrollOffset, UnityEngine.Vector2 renderOffset, System.Boolean resetOffset) { }
        private System.Void Pop() { }
        private UnityEngine.Vector2 Unclip(UnityEngine.Vector2 pos) { }
        private UnityEngine.Vector2 UnclipToWindow(UnityEngine.Vector2 pos) { }
        private UnityEngine.Vector2 ClipToWindow(UnityEngine.Vector2 absolutePos) { }
        private System.Void get_visibleRect_Injected(UnityEngine.Rect& ret) { }
        private System.Void Internal_Push_Injected(UnityEngine.Rect& screenRect, UnityEngine.Vector2& scrollOffset, UnityEngine.Vector2& renderOffset, System.Boolean resetOffset) { }
        private System.Void Unclip_Vector2_Injected(UnityEngine.Vector2& pos, UnityEngine.Vector2& ret) { }
        private System.Void UnclipToWindow_Vector2_Injected(UnityEngine.Vector2& pos, UnityEngine.Vector2& ret) { }
        private System.Void ClipToWindow_Vector2_Injected(UnityEngine.Vector2& absolutePos, UnityEngine.Vector2& ret) { }
        private System.Void GetMatrix_Injected(UnityEngine.Matrix4x4& ret) { }
        private System.Void SetMatrix_Injected(UnityEngine.Matrix4x4& m) { }
        private System.Void Internal_PushParentClip_Injected(UnityEngine.Matrix4x4& renderTransform, UnityEngine.Matrix4x4& inputTransform, UnityEngine.Rect& clipRect) { }

    }

    // TypeToken: 0x200000D
    public class GUIContent
    {
        // Fields
        private System.String m_Text;        // 0x10
        private UnityEngine.Texture m_Image;        // 0x18
        private System.String m_Tooltip;        // 0x20
        private static readonly UnityEngine.GUIContent s_Text;        // 0x0
        private static readonly UnityEngine.GUIContent s_Image;        // 0x8
        private static readonly UnityEngine.GUIContent s_TextImage;        // 0x10
        public static UnityEngine.GUIContent none;        // 0x18

        // Methods
        private System.String get_text() { }
        private System.Void set_text(System.String value) { }
        private System.Void set_image(UnityEngine.Texture value) { }
        private System.String get_tooltip() { }
        private System.Void set_tooltip(System.String value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String text) { }
        private System.Void .ctor(System.String text, System.String tooltip) { }
        private System.Void .ctor(System.String text, UnityEngine.Texture image, System.String tooltip) { }
        private System.Void .ctor(UnityEngine.GUIContent src) { }
        private System.Int32 get_hash() { }
        private UnityEngine.GUIContent Temp(System.String t) { }
        private System.Void ClearStaticCache() { }
        private System.String ToString() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000E
    public struct ScaleMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.ScaleMode StretchToFill;        // 0x0
        public static UnityEngine.ScaleMode ScaleAndCrop;        // 0x0
        public static UnityEngine.ScaleMode ScaleToFit;        // 0x0

    }

    // TypeToken: 0x200000F
    public struct FocusType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.FocusType Native;        // 0x0
        public static UnityEngine.FocusType Keyboard;        // 0x0
        public static UnityEngine.FocusType Passive;        // 0x0

    }

    // TypeToken: 0x2000010
    public class GUILayout
    {
        // Methods
        private System.Void Label(System.String text, UnityEngine.GUILayoutOption[] options) { }
        private System.Void Label(System.String text, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options) { }
        private System.Void DoLabel(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options) { }
        private System.Boolean Toggle(System.Boolean value, System.String text, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options) { }
        private System.Boolean Toggle(System.Boolean value, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options) { }
        private System.Boolean DoToggle(System.Boolean value, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options) { }
        private System.Void Space(System.Single pixels) { }
        private System.Void FlexibleSpace() { }
        private System.Void BeginHorizontal(UnityEngine.GUILayoutOption[] options) { }
        private System.Void BeginHorizontal(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options) { }
        private System.Void EndHorizontal() { }
        private System.Void BeginVertical(UnityEngine.GUILayoutOption[] options) { }
        private System.Void BeginVertical(UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options) { }
        private System.Void BeginVertical(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options) { }
        private System.Void EndVertical() { }
        private System.Void BeginArea(UnityEngine.Rect screenRect) { }
        private System.Void BeginArea(UnityEngine.Rect screenRect, UnityEngine.GUIContent content, UnityEngine.GUIStyle style) { }
        private System.Void EndArea() { }
        private UnityEngine.Vector2 BeginScrollView(UnityEngine.Vector2 scrollPosition, UnityEngine.GUILayoutOption[] options) { }
        private UnityEngine.Vector2 BeginScrollView(UnityEngine.Vector2 scrollPosition, System.Boolean alwaysShowHorizontal, System.Boolean alwaysShowVertical, UnityEngine.GUIStyle horizontalScrollbar, UnityEngine.GUIStyle verticalScrollbar, UnityEngine.GUIStyle background, UnityEngine.GUILayoutOption[] options) { }
        private System.Void EndScrollView() { }
        private System.Void EndScrollView(System.Boolean handleScrollWheel) { }
        private UnityEngine.GUILayoutOption Width(System.Single width) { }
        private UnityEngine.GUILayoutOption Height(System.Single height) { }
        private UnityEngine.GUILayoutOption ExpandWidth(System.Boolean expand) { }
        private UnityEngine.GUILayoutOption ExpandHeight(System.Boolean expand) { }

    }

    // TypeToken: 0x2000011
    public class GUILayoutOption
    {
        // Fields
        private UnityEngine.GUILayoutOption.Type type;        // 0x10
        private System.Object value;        // 0x18

        // Methods
        private System.Void .ctor(UnityEngine.GUILayoutOption.Type type, System.Object value) { }

    }

    // TypeToken: 0x2000013
    public class GUILayoutUtility
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<System.Int32,UnityEngine.GUILayoutUtility.LayoutCache> s_StoredLayouts;        // 0x0
        private static readonly System.Collections.Generic.Dictionary<System.Int32,UnityEngine.GUILayoutUtility.LayoutCache> s_StoredWindows;        // 0x8
        private static UnityEngine.GUILayoutUtility.LayoutCache current;        // 0x10
        private static readonly UnityEngine.Rect kDummyRect;        // 0x18
        private static System.Int32 <unbalancedgroupscount>k__BackingField;        // 0x28
        private static UnityEngine.GUIStyle s_SpaceStyle;        // 0x30

        // Methods
        private UnityEngine.Rect Internal_GetWindowRect(System.Int32 windowID) { }
        private System.Void Internal_MoveWindow(System.Int32 windowID, UnityEngine.Rect r) { }
        private System.Int32 get_unbalancedgroupscount() { }
        private System.Void set_unbalancedgroupscount(System.Int32 value) { }
        private UnityEngine.GUILayoutUtility.LayoutCache SelectIDList(System.Int32 instanceID, System.Boolean isWindow) { }
        private System.Void Begin(System.Int32 instanceID) { }
        private System.Void BeginContainer(UnityEngine.GUILayoutUtility.LayoutCache cache) { }
        private System.Void BeginWindow(System.Int32 windowID, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options) { }
        private System.Void Layout() { }
        private System.Void LayoutFromEditorWindow() { }
        private System.Void LayoutFromContainer(System.Single w, System.Single h) { }
        private System.Void LayoutFreeGroup(UnityEngine.GUILayoutGroup toplevel) { }
        private System.Void LayoutSingleGroup(UnityEngine.GUILayoutGroup i) { }
        private UnityEngine.GUILayoutGroup CreateGUILayoutGroupInstanceOfType(System.Type LayoutType) { }
        private UnityEngine.GUILayoutGroup BeginLayoutGroup(UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options, System.Type layoutType) { }
        private System.Void EndLayoutGroup() { }
        private UnityEngine.GUILayoutGroup BeginLayoutArea(UnityEngine.GUIStyle style, System.Type layoutType) { }
        private UnityEngine.Rect GetRect(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options) { }
        private UnityEngine.Rect DoGetRect(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options) { }
        private UnityEngine.Rect GetRect(System.Single width, System.Single height, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options) { }
        private UnityEngine.Rect DoGetRect(System.Single minWidth, System.Single maxWidth, System.Single minHeight, System.Single maxHeight, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options) { }
        private UnityEngine.Rect GetLastRect() { }
        private UnityEngine.GUIStyle get_spaceStyle() { }
        private System.Void .cctor() { }
        private System.Void Internal_GetWindowRect_Injected(System.Int32 windowID, UnityEngine.Rect& ret) { }
        private System.Void Internal_MoveWindow_Injected(System.Int32 windowID, UnityEngine.Rect& r) { }

    }

    // TypeToken: 0x2000015
    public class GUISettings
    {
        // Fields
        private System.Boolean m_DoubleClickSelectsWord;        // 0x10
        private System.Boolean m_TripleClickSelectsLine;        // 0x11
        private UnityEngine.Color m_CursorColor;        // 0x14
        private System.Single m_CursorFlashSpeed;        // 0x24
        private UnityEngine.Color m_SelectionColor;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000016
    public class GUISkin : ScriptableObject
    {
        // Fields
        private UnityEngine.Font m_Font;        // 0x18
        private UnityEngine.GUIStyle m_box;        // 0x20
        private UnityEngine.GUIStyle m_button;        // 0x28
        private UnityEngine.GUIStyle m_toggle;        // 0x30
        private UnityEngine.GUIStyle m_label;        // 0x38
        private UnityEngine.GUIStyle m_textField;        // 0x40
        private UnityEngine.GUIStyle m_textArea;        // 0x48
        private UnityEngine.GUIStyle m_window;        // 0x50
        private UnityEngine.GUIStyle m_horizontalSlider;        // 0x58
        private UnityEngine.GUIStyle m_horizontalSliderThumb;        // 0x60
        private UnityEngine.GUIStyle m_horizontalSliderThumbExtent;        // 0x68
        private UnityEngine.GUIStyle m_verticalSlider;        // 0x70
        private UnityEngine.GUIStyle m_verticalSliderThumb;        // 0x78
        private UnityEngine.GUIStyle m_verticalSliderThumbExtent;        // 0x80
        private UnityEngine.GUIStyle m_SliderMixed;        // 0x88
        private UnityEngine.GUIStyle m_horizontalScrollbar;        // 0x90
        private UnityEngine.GUIStyle m_horizontalScrollbarThumb;        // 0x98
        private UnityEngine.GUIStyle m_horizontalScrollbarLeftButton;        // 0xA0
        private UnityEngine.GUIStyle m_horizontalScrollbarRightButton;        // 0xA8
        private UnityEngine.GUIStyle m_verticalScrollbar;        // 0xB0
        private UnityEngine.GUIStyle m_verticalScrollbarThumb;        // 0xB8
        private UnityEngine.GUIStyle m_verticalScrollbarUpButton;        // 0xC0
        private UnityEngine.GUIStyle m_verticalScrollbarDownButton;        // 0xC8
        private UnityEngine.GUIStyle m_ScrollView;        // 0xD0
        private UnityEngine.GUIStyle[] m_CustomStyles;        // 0xD8
        private UnityEngine.GUISettings m_Settings;        // 0xE0
        private static UnityEngine.GUIStyle ms_Error;        // 0x0
        private System.Collections.Generic.Dictionary<System.String,UnityEngine.GUIStyle> m_Styles;        // 0xE8
        private static UnityEngine.GUISkin.SkinChangedDelegate m_SkinChanged;        // 0x8
        private static UnityEngine.GUISkin current;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void OnEnable() { }
        private System.Void CleanupRoots() { }
        private UnityEngine.Font get_font() { }
        private System.Void set_font(UnityEngine.Font value) { }
        private UnityEngine.GUIStyle get_box() { }
        private System.Void set_box(UnityEngine.GUIStyle value) { }
        private UnityEngine.GUIStyle get_label() { }
        private System.Void set_label(UnityEngine.GUIStyle value) { }
        private UnityEngine.GUIStyle get_textField() { }
        private System.Void set_textField(UnityEngine.GUIStyle value) { }
        private UnityEngine.GUIStyle get_textArea() { }
        private System.Void set_textArea(UnityEngine.GUIStyle value) { }
        private UnityEngine.GUIStyle get_button() { }
        private System.Void set_button(UnityEngine.GUIStyle value) { }
        private UnityEngine.GUIStyle get_toggle() { }
        private System.Void set_toggle(UnityEngine.GUIStyle value) { }
        private UnityEngine.GUIStyle get_window() { }
        private System.Void set_window(UnityEngine.GUIStyle value) { }
        private UnityEngine.GUIStyle get_horizontalSlider() { }
        private System.Void set_horizontalSlider(UnityEngine.GUIStyle value) { }
        private UnityEngine.GUIStyle get_horizontalSliderThumb() { }
        private System.Void set_horizontalSliderThumb(UnityEngine.GUIStyle value) { }
        private UnityEngine.GUIStyle get_horizontalSliderThumbExtent() { }
        private System.Void set_horizontalSliderThumbExtent(UnityEngine.GUIStyle value) { }
        private UnityEngine.GUIStyle get_sliderMixed() { }
        private System.Void set_sliderMixed(UnityEngine.GUIStyle value) { }
        private UnityEngine.GUIStyle get_verticalSlider() { }
        private System.Void set_verticalSlider(UnityEngine.GUIStyle value) { }
        private UnityEngine.GUIStyle get_verticalSliderThumb() { }
        private System.Void set_verticalSliderThumb(UnityEngine.GUIStyle value) { }
        private UnityEngine.GUIStyle get_verticalSliderThumbExtent() { }
        private System.Void set_verticalSliderThumbExtent(UnityEngine.GUIStyle value) { }
        private UnityEngine.GUIStyle get_horizontalScrollbar() { }
        private System.Void set_horizontalScrollbar(UnityEngine.GUIStyle value) { }
        private UnityEngine.GUIStyle get_horizontalScrollbarThumb() { }
        private System.Void set_horizontalScrollbarThumb(UnityEngine.GUIStyle value) { }
        private UnityEngine.GUIStyle get_horizontalScrollbarLeftButton() { }
        private System.Void set_horizontalScrollbarLeftButton(UnityEngine.GUIStyle value) { }
        private UnityEngine.GUIStyle get_horizontalScrollbarRightButton() { }
        private System.Void set_horizontalScrollbarRightButton(UnityEngine.GUIStyle value) { }
        private UnityEngine.GUIStyle get_verticalScrollbar() { }
        private System.Void set_verticalScrollbar(UnityEngine.GUIStyle value) { }
        private UnityEngine.GUIStyle get_verticalScrollbarThumb() { }
        private System.Void set_verticalScrollbarThumb(UnityEngine.GUIStyle value) { }
        private UnityEngine.GUIStyle get_verticalScrollbarUpButton() { }
        private System.Void set_verticalScrollbarUpButton(UnityEngine.GUIStyle value) { }
        private UnityEngine.GUIStyle get_verticalScrollbarDownButton() { }
        private System.Void set_verticalScrollbarDownButton(UnityEngine.GUIStyle value) { }
        private UnityEngine.GUIStyle get_scrollView() { }
        private System.Void set_scrollView(UnityEngine.GUIStyle value) { }
        private UnityEngine.GUIStyle[] get_customStyles() { }
        private System.Void set_customStyles(UnityEngine.GUIStyle[] value) { }
        private UnityEngine.GUISettings get_settings() { }
        private UnityEngine.GUIStyle get_error() { }
        private System.Void Apply() { }
        private System.Void BuildStyleCache() { }
        private UnityEngine.GUIStyle GetStyle(System.String styleName) { }
        private UnityEngine.GUIStyle FindStyle(System.String styleName) { }
        private System.Void MakeCurrent() { }
        private System.Collections.IEnumerator GetEnumerator() { }

    }

    // TypeToken: 0x2000018
    public class GUIStateObjects
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.Int32,System.Object> s_StateCache;        // 0x0

        // Methods
        private System.Object GetStateObject(System.Type t, System.Int32 controlID) { }
        private System.Object QueryStateObject(System.Type t, System.Int32 controlID) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000019
    public class GUIStyleState
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10
        private readonly UnityEngine.GUIStyle m_SourceStyle;        // 0x18

        // Methods
        private UnityEngine.Texture2D get_background() { }
        private System.Void set_background(UnityEngine.Texture2D value) { }
        private UnityEngine.Color get_textColor() { }
        private System.Void set_textColor(UnityEngine.Color value) { }
        private System.IntPtr Init() { }
        private System.Void Cleanup() { }
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.GUIStyle sourceStyle, System.IntPtr source) { }
        private UnityEngine.GUIStyleState GetGUIStyleState(UnityEngine.GUIStyle sourceStyle, System.IntPtr source) { }
        private System.Void Finalize() { }
        private System.Void get_textColor_Injected(UnityEngine.Color& ret) { }
        private System.Void set_textColor_Injected(UnityEngine.Color& value) { }

    }

    // TypeToken: 0x200001A
    public class GUIStyle
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10
        private UnityEngine.GUIStyleState m_Normal;        // 0x18
        private UnityEngine.GUIStyleState m_Hover;        // 0x20
        private UnityEngine.GUIStyleState m_Active;        // 0x28
        private UnityEngine.GUIStyleState m_Focused;        // 0x30
        private UnityEngine.GUIStyleState m_OnNormal;        // 0x38
        private UnityEngine.GUIStyleState m_OnHover;        // 0x40
        private UnityEngine.GUIStyleState m_OnActive;        // 0x48
        private UnityEngine.GUIStyleState m_OnFocused;        // 0x50
        private UnityEngine.RectOffset m_Border;        // 0x58
        private UnityEngine.RectOffset m_Padding;        // 0x60
        private UnityEngine.RectOffset m_Margin;        // 0x68
        private UnityEngine.RectOffset m_Overflow;        // 0x70
        private System.String m_Name;        // 0x78
        private static System.Boolean showKeyboardFocus;        // 0x0
        private static UnityEngine.GUIStyle s_None;        // 0x8

        // Methods
        private System.String get_rawName() { }
        private System.Void set_rawName(System.String value) { }
        private UnityEngine.Font get_font() { }
        private System.Void set_font(UnityEngine.Font value) { }
        private UnityEngine.ImagePosition get_imagePosition() { }
        private System.Void set_imagePosition(UnityEngine.ImagePosition value) { }
        private UnityEngine.TextAnchor get_alignment() { }
        private System.Void set_alignment(UnityEngine.TextAnchor value) { }
        private System.Boolean get_wordWrap() { }
        private System.Void set_wordWrap(System.Boolean value) { }
        private UnityEngine.TextClipping get_clipping() { }
        private System.Void set_clipping(UnityEngine.TextClipping value) { }
        private UnityEngine.Vector2 get_contentOffset() { }
        private System.Void set_contentOffset(UnityEngine.Vector2 value) { }
        private System.Single get_fixedWidth() { }
        private System.Void set_fixedWidth(System.Single value) { }
        private System.Single get_fixedHeight() { }
        private System.Void set_fixedHeight(System.Single value) { }
        private System.Boolean get_stretchWidth() { }
        private System.Void set_stretchWidth(System.Boolean value) { }
        private System.Boolean get_stretchHeight() { }
        private System.Void set_stretchHeight(System.Boolean value) { }
        private System.Int32 get_fontSize() { }
        private System.Void set_fontSize(System.Int32 value) { }
        private UnityEngine.FontStyle get_fontStyle() { }
        private System.Void set_fontStyle(UnityEngine.FontStyle value) { }
        private System.Boolean get_richText() { }
        private System.Void set_richText(System.Boolean value) { }
        private System.IntPtr Internal_Create(UnityEngine.GUIStyle self) { }
        private System.IntPtr Internal_Copy(UnityEngine.GUIStyle self, UnityEngine.GUIStyle other) { }
        private System.Void Internal_Destroy(System.IntPtr self) { }
        private System.IntPtr GetStyleStatePtr(System.Int32 idx) { }
        private System.Void AssignStyleState(System.Int32 idx, System.IntPtr srcStyleState) { }
        private System.IntPtr GetRectOffsetPtr(System.Int32 idx) { }
        private System.Void AssignRectOffset(System.Int32 idx, System.IntPtr srcRectOffset) { }
        private System.Single Internal_GetLineHeight(System.IntPtr target) { }
        private System.Void Internal_Draw(UnityEngine.Rect screenRect, UnityEngine.GUIContent content, System.Boolean isHover, System.Boolean isActive, System.Boolean on, System.Boolean hasKeyboardFocus) { }
        private System.Void Internal_Draw2(UnityEngine.Rect position, UnityEngine.GUIContent content, System.Int32 controlID, System.Boolean on) { }
        private UnityEngine.Vector2 Internal_GetCursorPixelPosition(UnityEngine.Rect position, UnityEngine.GUIContent content, System.Int32 cursorStringIndex) { }
        private System.Int32 Internal_GetCursorStringIndex(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.Vector2 cursorPixelPosition) { }
        private System.String Internal_GetSelectedRenderedText(UnityEngine.Rect localPosition, UnityEngine.GUIContent mContent, System.Int32 selectIndex, System.Int32 cursorIndex) { }
        private UnityEngine.Vector2 Internal_CalcSize(UnityEngine.GUIContent content) { }
        private UnityEngine.Vector2 Internal_CalcSizeWithConstraints(UnityEngine.GUIContent content, UnityEngine.Vector2 maxSize) { }
        private System.Single Internal_CalcHeight(UnityEngine.GUIContent content, System.Single width) { }
        private UnityEngine.Vector2 Internal_CalcMinMaxWidth(UnityEngine.GUIContent content) { }
        private System.Void SetMouseTooltip(System.String tooltip, UnityEngine.Rect screenRect) { }
        private System.Boolean IsTooltipActive(System.String tooltip) { }
        private System.Void SetDefaultFont(UnityEngine.Font font) { }
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.GUIStyle other) { }
        private System.Void Finalize() { }
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private UnityEngine.GUIStyleState get_normal() { }
        private System.Void set_normal(UnityEngine.GUIStyleState value) { }
        private UnityEngine.GUIStyleState get_hover() { }
        private System.Void set_hover(UnityEngine.GUIStyleState value) { }
        private UnityEngine.GUIStyleState get_active() { }
        private System.Void set_active(UnityEngine.GUIStyleState value) { }
        private UnityEngine.GUIStyleState get_onNormal() { }
        private System.Void set_onNormal(UnityEngine.GUIStyleState value) { }
        private UnityEngine.GUIStyleState get_onHover() { }
        private System.Void set_onHover(UnityEngine.GUIStyleState value) { }
        private UnityEngine.GUIStyleState get_onActive() { }
        private System.Void set_onActive(UnityEngine.GUIStyleState value) { }
        private UnityEngine.GUIStyleState get_focused() { }
        private System.Void set_focused(UnityEngine.GUIStyleState value) { }
        private UnityEngine.GUIStyleState get_onFocused() { }
        private System.Void set_onFocused(UnityEngine.GUIStyleState value) { }
        private UnityEngine.RectOffset get_border() { }
        private System.Void set_border(UnityEngine.RectOffset value) { }
        private UnityEngine.RectOffset get_margin() { }
        private System.Void set_margin(UnityEngine.RectOffset value) { }
        private UnityEngine.RectOffset get_padding() { }
        private System.Void set_padding(UnityEngine.RectOffset value) { }
        private UnityEngine.RectOffset get_overflow() { }
        private System.Void set_overflow(UnityEngine.RectOffset value) { }
        private System.Single get_lineHeight() { }
        private System.Void Draw(UnityEngine.Rect position, System.Boolean isHover, System.Boolean isActive, System.Boolean on, System.Boolean hasKeyboardFocus) { }
        private System.Void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, System.Boolean isHover, System.Boolean isActive, System.Boolean on, System.Boolean hasKeyboardFocus) { }
        private System.Void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, System.Int32 controlID) { }
        private System.Void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, System.Int32 controlID, System.Boolean on, System.Boolean hover) { }
        private System.Void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, System.Int32 controlId, System.Boolean isHover, System.Boolean isActive, System.Boolean on, System.Boolean hasKeyboardFocus) { }
        private UnityEngine.GUIStyle get_none() { }
        private UnityEngine.Vector2 GetCursorPixelPosition(UnityEngine.Rect position, UnityEngine.GUIContent content, System.Int32 cursorStringIndex) { }
        private System.Int32 GetCursorStringIndex(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.Vector2 cursorPixelPosition) { }
        private UnityEngine.Vector2 CalcSize(UnityEngine.GUIContent content) { }
        private UnityEngine.Vector2 CalcSizeWithConstraints(UnityEngine.GUIContent content, UnityEngine.Vector2 constraints) { }
        private System.Single CalcHeight(UnityEngine.GUIContent content, System.Single width) { }
        private System.Boolean get_isHeightDependantOnWidth() { }
        private System.Void CalcMinMaxWidth(UnityEngine.GUIContent content, System.Single& minWidth, System.Single& maxWidth) { }
        private System.String ToString() { }
        private System.Void .cctor() { }
        private System.Void get_contentOffset_Injected(UnityEngine.Vector2& ret) { }
        private System.Void set_contentOffset_Injected(UnityEngine.Vector2& value) { }
        private System.Void Internal_Draw_Injected(UnityEngine.Rect& screenRect, UnityEngine.GUIContent content, System.Boolean isHover, System.Boolean isActive, System.Boolean on, System.Boolean hasKeyboardFocus) { }
        private System.Void Internal_Draw2_Injected(UnityEngine.Rect& position, UnityEngine.GUIContent content, System.Int32 controlID, System.Boolean on) { }
        private System.Void Internal_GetCursorPixelPosition_Injected(UnityEngine.Rect& position, UnityEngine.GUIContent content, System.Int32 cursorStringIndex, UnityEngine.Vector2& ret) { }
        private System.Int32 Internal_GetCursorStringIndex_Injected(UnityEngine.Rect& position, UnityEngine.GUIContent content, UnityEngine.Vector2& cursorPixelPosition) { }
        private System.String Internal_GetSelectedRenderedText_Injected(UnityEngine.Rect& localPosition, UnityEngine.GUIContent mContent, System.Int32 selectIndex, System.Int32 cursorIndex) { }
        private System.Void Internal_CalcSize_Injected(UnityEngine.GUIContent content, UnityEngine.Vector2& ret) { }
        private System.Void Internal_CalcSizeWithConstraints_Injected(UnityEngine.GUIContent content, UnityEngine.Vector2& maxSize, UnityEngine.Vector2& ret) { }
        private System.Void Internal_CalcMinMaxWidth_Injected(UnityEngine.GUIContent content, UnityEngine.Vector2& ret) { }
        private System.Void SetMouseTooltip_Injected(System.String tooltip, UnityEngine.Rect& screenRect) { }

    }

    // TypeToken: 0x200001B
    public struct ImagePosition
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.ImagePosition ImageLeft;        // 0x0
        public static UnityEngine.ImagePosition ImageAbove;        // 0x0
        public static UnityEngine.ImagePosition ImageOnly;        // 0x0
        public static UnityEngine.ImagePosition TextOnly;        // 0x0

    }

    // TypeToken: 0x200001C
    public struct TextClipping
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TextClipping Overflow;        // 0x0
        public static UnityEngine.TextClipping Clip;        // 0x0

    }

    // TypeToken: 0x200001D
    public class GUITargetAttribute : Attribute
    {
        // Fields
        private System.Int32 displayMask;        // 0x10

        // Methods
        private System.Int32 GetGUITargetAttrValue(System.Type klass, System.String methodName) { }

    }

    // TypeToken: 0x200001E
    public class GUIUtility
    {
        // Fields
        private static System.Int32 s_ControlCount;        // 0x0
        private static System.Int32 s_SkinMode;        // 0x4
        private static System.Int32 s_OriginalID;        // 0x8
        private static System.Action takeCapture;        // 0x10
        private static System.Action releaseCapture;        // 0x18
        private static System.Func<System.Int32,System.IntPtr,System.Boolean> processEvent;        // 0x20
        private static System.Action cleanupRoots;        // 0x28
        private static System.Func<System.Exception,System.Boolean> endContainerGUIFromException;        // 0x30
        private static System.Action guiChanged;        // 0x38
        private static System.Boolean <guiIsExiting>k__BackingField;        // 0x40
        private static System.Func<System.Boolean> s_HasCurrentWindowKeyFocusFunc;        // 0x48

        // Methods
        private System.Boolean get_hasModalWindow() { }
        private System.Single get_pixelsPerPoint() { }
        private System.Int32 get_guiDepth() { }
        private UnityEngine.Vector2 get_s_EditorScreenPointOffset() { }
        private System.Void set_s_EditorScreenPointOffset(UnityEngine.Vector2 value) { }
        private System.Boolean get_mouseUsed() { }
        private System.Void set_mouseUsed(System.Boolean value) { }
        private System.Boolean get_textFieldInput() { }
        private System.Void set_textFieldInput(System.Boolean value) { }
        private System.Boolean get_manualTex2SRGBEnabled() { }
        private System.Void set_manualTex2SRGBEnabled(System.Boolean value) { }
        private System.String get_systemCopyBuffer() { }
        private System.Void set_systemCopyBuffer(System.String value) { }
        private System.Int32 Internal_GetControlID(System.Int32 hint, UnityEngine.FocusType focusType, UnityEngine.Rect rect) { }
        private System.Int32 GetControlID(System.Int32 hint, UnityEngine.FocusType focusType, UnityEngine.Rect rect) { }
        private System.Void BeginContainerFromOwner(UnityEngine.ScriptableObject owner) { }
        private System.Void BeginContainer(UnityEngine.ObjectGUIState objectGUIState) { }
        private System.Void Internal_EndContainer() { }
        private System.Int32 GetPermanentControlID() { }
        private System.Int32 CheckForTabEvent(UnityEngine.Event evt) { }
        private System.Void SetKeyboardControlToFirstControlId() { }
        private System.Void SetKeyboardControlToLastControlId() { }
        private System.Boolean HasFocusableControls() { }
        private System.Boolean OwnsId(System.Int32 id) { }
        private UnityEngine.Rect AlignRectToDevice(UnityEngine.Rect rect, System.Int32& widthInPixels, System.Int32& heightInPixels) { }
        private System.String get_compositionString() { }
        private UnityEngine.IMECompositionMode get_imeCompositionMode() { }
        private System.Void set_imeCompositionMode(UnityEngine.IMECompositionMode value) { }
        private UnityEngine.Vector2 get_compositionCursorPos() { }
        private System.Void set_compositionCursorPos(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector3 Internal_MultiplyPoint(UnityEngine.Vector3 point, UnityEngine.Matrix4x4 transform) { }
        private System.Boolean GetChanged() { }
        private System.Void SetChanged(System.Boolean changed) { }
        private System.Void SetDidGUIWindowsEatLastEvent(System.Boolean value) { }
        private System.Int32 Internal_GetHotControl() { }
        private System.Int32 Internal_GetKeyboardControl() { }
        private System.Void Internal_SetHotControl(System.Int32 value) { }
        private System.Void Internal_SetKeyboardControl(System.Int32 value) { }
        private System.Object Internal_GetDefaultSkin(System.Int32 skinMode) { }
        private UnityEngine.Object Internal_GetBuiltinSkin(System.Int32 skin) { }
        private System.Void Internal_ExitGUI() { }
        private UnityEngine.Vector2 InternalWindowToScreenPoint(UnityEngine.Vector2 windowPoint) { }
        private UnityEngine.Vector2 InternalScreenToWindowPoint(UnityEngine.Vector2 screenPoint) { }
        private System.Void MarkGUIChanged() { }
        private System.Int32 GetControlID(UnityEngine.FocusType focus) { }
        private System.Int32 GetControlID(UnityEngine.GUIContent contents, UnityEngine.FocusType focus) { }
        private System.Int32 GetControlID(UnityEngine.FocusType focus, UnityEngine.Rect position) { }
        private System.Int32 GetControlID(UnityEngine.GUIContent contents, UnityEngine.FocusType focus, UnityEngine.Rect position) { }
        private System.Int32 GetControlID(System.Int32 hint, UnityEngine.FocusType focus) { }
        private System.Object GetStateObject(System.Type t, System.Int32 controlID) { }
        private System.Object QueryStateObject(System.Type t, System.Int32 controlID) { }
        private System.Boolean get_guiIsExiting() { }
        private System.Void set_guiIsExiting(System.Boolean value) { }
        private System.Int32 get_hotControl() { }
        private System.Void set_hotControl(System.Int32 value) { }
        private System.Void TakeCapture() { }
        private System.Void RemoveCapture() { }
        private System.Int32 get_keyboardControl() { }
        private System.Void set_keyboardControl(System.Int32 value) { }
        private System.Boolean HasKeyFocus(System.Int32 controlID) { }
        private System.Void ExitGUI() { }
        private UnityEngine.GUISkin GetDefaultSkin(System.Int32 skinMode) { }
        private UnityEngine.GUISkin GetDefaultSkin() { }
        private UnityEngine.GUISkin GetBuiltinSkin(System.Int32 skin) { }
        private System.Void ProcessEvent(System.Int32 instanceID, System.IntPtr nativeEventPtr, System.Boolean& result) { }
        private System.Void EndContainer() { }
        private System.Void CleanupRoots() { }
        private System.Void BeginGUI(System.Int32 skinMode, System.Int32 instanceID, System.Int32 useGUILayout) { }
        private System.Void EndGUI(System.Int32 layoutType) { }
        private System.Boolean EndGUIFromException(System.Exception exception) { }
        private System.Boolean EndContainerGUIFromException(System.Exception exception) { }
        private System.Void ResetGlobalState() { }
        private System.Boolean IsExitGUIException(System.Exception exception) { }
        private System.Boolean ShouldRethrowException(System.Exception exception) { }
        private System.Void CheckOnGUI() { }
        private System.Single RoundToPixelGrid(System.Single v) { }
        private UnityEngine.Vector2 GUIToScreenPoint(UnityEngine.Vector2 guiPoint) { }
        private UnityEngine.Rect GUIToScreenRect(UnityEngine.Rect guiRect) { }
        private UnityEngine.Vector2 ScreenToGUIPoint(UnityEngine.Vector2 screenPoint) { }
        private UnityEngine.Rect ScreenToGUIRect(UnityEngine.Rect screenRect) { }
        private System.Void RotateAroundPivot(System.Single angle, UnityEngine.Vector2 pivotPoint) { }
        private System.Void ScaleAroundPivot(UnityEngine.Vector2 scale, UnityEngine.Vector2 pivotPoint) { }
        private UnityEngine.Rect AlignRectToDevice(UnityEngine.Rect rect) { }
        private System.Boolean HitTest(UnityEngine.Rect rect, UnityEngine.Vector2 point, System.Int32 offset) { }
        private System.Boolean HitTest(UnityEngine.Rect rect, UnityEngine.Vector2 point, System.Boolean isDirectManipulationDevice) { }
        private System.Boolean HitTest(UnityEngine.Rect rect, UnityEngine.Event evt) { }
        private System.Void .ctor() { }
        private System.Void get_s_EditorScreenPointOffset_Injected(UnityEngine.Vector2& ret) { }
        private System.Void set_s_EditorScreenPointOffset_Injected(UnityEngine.Vector2& value) { }
        private System.Int32 Internal_GetControlID_Injected(System.Int32 hint, UnityEngine.FocusType focusType, UnityEngine.Rect& rect) { }
        private System.Void AlignRectToDevice_Injected(UnityEngine.Rect& rect, System.Int32& widthInPixels, System.Int32& heightInPixels, UnityEngine.Rect& ret) { }
        private System.Void get_compositionCursorPos_Injected(UnityEngine.Vector2& ret) { }
        private System.Void set_compositionCursorPos_Injected(UnityEngine.Vector2& value) { }
        private System.Void Internal_MultiplyPoint_Injected(UnityEngine.Vector3& point, UnityEngine.Matrix4x4& transform, UnityEngine.Vector3& ret) { }
        private System.Void InternalWindowToScreenPoint_Injected(UnityEngine.Vector2& windowPoint, UnityEngine.Vector2& ret) { }
        private System.Void InternalScreenToWindowPoint_Injected(UnityEngine.Vector2& screenPoint, UnityEngine.Vector2& ret) { }

    }

    // TypeToken: 0x200001F
    public class ExitGUIException : Exception
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String message) { }

    }

    // TypeToken: 0x2000020
    public class GUILayoutEntry
    {
        // Fields
        public System.Single minWidth;        // 0x10
        public System.Single maxWidth;        // 0x14
        public System.Single minHeight;        // 0x18
        public System.Single maxHeight;        // 0x1C
        public UnityEngine.Rect rect;        // 0x20
        public System.Int32 stretchWidth;        // 0x30
        public System.Int32 stretchHeight;        // 0x34
        public System.Boolean consideredForMargin;        // 0x38
        private UnityEngine.GUIStyle m_Style;        // 0x40
        private static UnityEngine.Rect kDummyRect;        // 0x0
        protected static System.Int32 indent;        // 0x10

        // Methods
        private UnityEngine.GUIStyle get_style() { }
        private System.Void set_style(UnityEngine.GUIStyle value) { }
        private System.Int32 get_marginLeft() { }
        private System.Int32 get_marginRight() { }
        private System.Int32 get_marginTop() { }
        private System.Int32 get_marginBottom() { }
        private System.Int32 get_marginHorizontal() { }
        private System.Int32 get_marginVertical() { }
        private System.Void .ctor(System.Single _minWidth, System.Single _maxWidth, System.Single _minHeight, System.Single _maxHeight, UnityEngine.GUIStyle _style) { }
        private System.Void .ctor(System.Single _minWidth, System.Single _maxWidth, System.Single _minHeight, System.Single _maxHeight, UnityEngine.GUIStyle _style, UnityEngine.GUILayoutOption[] options) { }
        private System.Void CalcWidth() { }
        private System.Void CalcHeight() { }
        private System.Void SetHorizontal(System.Single x, System.Single width) { }
        private System.Void SetVertical(System.Single y, System.Single height) { }
        private System.Void ApplyStyleSettings(UnityEngine.GUIStyle style) { }
        private System.Void ApplyOptions(UnityEngine.GUILayoutOption[] options) { }
        private System.String ToString() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000021
    public class GUIWordWrapSizer : GUILayoutEntry
    {
        // Fields
        private readonly UnityEngine.GUIContent m_Content;        // 0x48
        private readonly System.Single m_ForcedMinHeight;        // 0x50
        private readonly System.Single m_ForcedMaxHeight;        // 0x54

        // Methods
        private System.Void .ctor(UnityEngine.GUIStyle style, UnityEngine.GUIContent content, UnityEngine.GUILayoutOption[] options) { }
        private System.Void CalcWidth() { }
        private System.Void CalcHeight() { }

    }

    // TypeToken: 0x2000022
    public class GUILayoutGroup : GUILayoutEntry
    {
        // Fields
        public System.Collections.Generic.List<UnityEngine.GUILayoutEntry> entries;        // 0x48
        public System.Boolean isVertical;        // 0x50
        public System.Boolean resetCoords;        // 0x51
        public System.Single spacing;        // 0x54
        public System.Boolean sameSize;        // 0x58
        public System.Boolean isWindow;        // 0x59
        public System.Int32 windowID;        // 0x5C
        private System.Int32 m_Cursor;        // 0x60
        protected System.Int32 m_StretchableCountX;        // 0x64
        protected System.Int32 m_StretchableCountY;        // 0x68
        protected System.Boolean m_UserSpecifiedWidth;        // 0x6C
        protected System.Boolean m_UserSpecifiedHeight;        // 0x6D
        protected System.Single m_ChildMinWidth;        // 0x70
        protected System.Single m_ChildMaxWidth;        // 0x74
        protected System.Single m_ChildMinHeight;        // 0x78
        protected System.Single m_ChildMaxHeight;        // 0x7C
        protected System.Int32 m_MarginLeft;        // 0x80
        protected System.Int32 m_MarginRight;        // 0x84
        protected System.Int32 m_MarginTop;        // 0x88
        protected System.Int32 m_MarginBottom;        // 0x8C
        private static readonly UnityEngine.GUILayoutEntry none;        // 0x0

        // Methods
        private System.Int32 get_marginLeft() { }
        private System.Int32 get_marginRight() { }
        private System.Int32 get_marginTop() { }
        private System.Int32 get_marginBottom() { }
        private System.Void .ctor() { }
        private System.Void ApplyOptions(UnityEngine.GUILayoutOption[] options) { }
        private System.Void ApplyStyleSettings(UnityEngine.GUIStyle style) { }
        private System.Void ResetCursor() { }
        private UnityEngine.GUILayoutEntry GetNext() { }
        private UnityEngine.Rect GetLast() { }
        private System.Void Add(UnityEngine.GUILayoutEntry e) { }
        private System.Void CalcWidth() { }
        private System.Void SetHorizontal(System.Single x, System.Single width) { }
        private System.Void CalcHeight() { }
        private System.Void SetVertical(System.Single y, System.Single height) { }
        private System.String ToString() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000023
    public class GUIScrollGroup : GUILayoutGroup
    {
        // Fields
        public System.Single calcMinWidth;        // 0x90
        public System.Single calcMaxWidth;        // 0x94
        public System.Single calcMinHeight;        // 0x98
        public System.Single calcMaxHeight;        // 0x9C
        public System.Single clientWidth;        // 0xA0
        public System.Single clientHeight;        // 0xA4
        public System.Boolean allowHorizontalScroll;        // 0xA8
        public System.Boolean allowVerticalScroll;        // 0xA9
        public System.Boolean needsHorizontalScrollbar;        // 0xAA
        public System.Boolean needsVerticalScrollbar;        // 0xAB
        public UnityEngine.GUIStyle horizontalScrollbar;        // 0xB0
        public UnityEngine.GUIStyle verticalScrollbar;        // 0xB8

        // Methods
        private System.Void .ctor() { }
        private System.Void CalcWidth() { }
        private System.Void SetHorizontal(System.Single x, System.Single width) { }
        private System.Void CalcHeight() { }
        private System.Void SetVertical(System.Single y, System.Single height) { }

    }

    // TypeToken: 0x2000024
    public class ObjectGUIState, IDisposable
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void Dispose() { }
        private System.Void Finalize() { }
        private System.Void Destroy() { }
        private System.IntPtr Internal_Create() { }
        private System.Void Internal_Destroy(System.IntPtr ptr) { }

    }

    // TypeToken: 0x2000025
    public class ScrollViewState
    {
        // Fields
        public UnityEngine.Rect position;        // 0x10
        public UnityEngine.Rect visibleRect;        // 0x20
        public UnityEngine.Rect viewRect;        // 0x30
        public UnityEngine.Vector2 scrollPosition;        // 0x40
        public System.Boolean apply;        // 0x48
        public System.Boolean isDuringTouchScroll;        // 0x49
        public UnityEngine.Vector2 touchScrollStartMousePosition;        // 0x4C
        public UnityEngine.Vector2 touchScrollStartPosition;        // 0x54
        public UnityEngine.Vector2 velocity;        // 0x5C
        public System.Single previousTimeSinceStartup;        // 0x64

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000026
    public class SliderState
    {
        // Fields
        public System.Single dragStartPos;        // 0x10
        public System.Single dragStartValue;        // 0x14
        public System.Boolean isDragging;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000027
    public struct SliderHandler
    {
        // Fields
        private readonly UnityEngine.Rect position;        // 0x10
        private readonly System.Single currentValue;        // 0x20
        private readonly System.Single size;        // 0x24
        private readonly System.Single start;        // 0x28
        private readonly System.Single end;        // 0x2C
        private readonly UnityEngine.GUIStyle slider;        // 0x30
        private readonly UnityEngine.GUIStyle thumb;        // 0x38
        private readonly UnityEngine.GUIStyle thumbExtent;        // 0x40
        private readonly System.Boolean horiz;        // 0x48
        private readonly System.Int32 id;        // 0x4C

        // Methods
        private System.Void .ctor(UnityEngine.Rect position, System.Single currentValue, System.Single size, System.Single start, System.Single end, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, System.Boolean horiz, System.Int32 id, UnityEngine.GUIStyle thumbExtent) { }
        private System.Single Handle() { }
        private System.Single OnMouseDown() { }
        private System.Single OnMouseDrag() { }
        private System.Single OnMouseUp() { }
        private System.Single OnRepaint() { }
        private UnityEngine.EventType CurrentEventType() { }
        private System.Int32 CurrentScrollTroughSide() { }
        private System.Boolean IsEmptySlider() { }
        private System.Boolean SupportsPageMovements() { }
        private System.Single PageMovementValue() { }
        private System.Single PageUpMovementBound() { }
        private UnityEngine.Event CurrentEvent() { }
        private System.Single ValueForCurrentMousePosition() { }
        private System.Single Clamp(System.Single value) { }
        private UnityEngine.Rect ThumbSelectionRect() { }
        private System.Void StartDraggingWithValue(System.Single dragStartValue) { }
        private UnityEngine.SliderState SliderState() { }
        private UnityEngine.Rect ThumbExtRect() { }
        private UnityEngine.Rect ThumbRect() { }
        private UnityEngine.Rect VerticalThumbRect() { }
        private UnityEngine.Rect HorizontalThumbRect() { }
        private System.Single ClampedCurrentValue() { }
        private System.Single MousePosition() { }
        private System.Single ValuesPerPixel() { }
        private System.Single ThumbSize() { }
        private System.Single MaxValue() { }
        private System.Single MinValue() { }

    }

    // TypeToken: 0x2000028
    public class TextEditor
    {
        // Fields
        public UnityEngine.TouchScreenKeyboard keyboardOnScreen;        // 0x10
        public System.Int32 controlID;        // 0x18
        public UnityEngine.GUIStyle style;        // 0x20
        public System.Boolean multiline;        // 0x28
        public System.Boolean hasHorizontalCursorPos;        // 0x29
        public System.Boolean isPasswordField;        // 0x2A
        private System.Boolean m_HasFocus;        // 0x2B
        public UnityEngine.Vector2 scrollOffset;        // 0x2C
        private UnityEngine.GUIContent m_Content;        // 0x38
        private UnityEngine.Rect m_Position;        // 0x40
        private System.Int32 m_CursorIndex;        // 0x50
        private System.Int32 m_SelectIndex;        // 0x54
        private System.Boolean m_RevealCursor;        // 0x58
        public UnityEngine.Vector2 graphicalCursorPos;        // 0x5C
        public UnityEngine.Vector2 graphicalSelectCursorPos;        // 0x64
        private System.Boolean m_MouseDragSelectsWholeWords;        // 0x6C
        private System.Int32 m_DblClickInitPos;        // 0x70
        private UnityEngine.TextEditor.DblClickSnapping m_DblClickSnap;        // 0x74
        private System.Boolean m_bJustSelected;        // 0x75
        private System.Int32 m_iAltCursorPos;        // 0x78
        private System.String oldText;        // 0x80
        private System.Int32 oldPos;        // 0x88
        private System.Int32 oldSelectPos;        // 0x8C
        private static System.Collections.Generic.Dictionary<UnityEngine.Event,UnityEngine.TextEditor.TextEditOp> s_Keyactions;        // 0x0

        // Methods
        private System.String get_text() { }
        private System.Void set_text(System.String value) { }
        private UnityEngine.Rect get_position() { }
        private System.Void set_position(UnityEngine.Rect value) { }
        private UnityEngine.Rect get_localPosition() { }
        private System.Int32 get_cursorIndex() { }
        private System.Void set_cursorIndex(System.Int32 value) { }
        private System.Int32 get_selectIndex() { }
        private System.Void set_selectIndex(System.Int32 value) { }
        private System.Void ClearCursorPos() { }
        private System.Int32 get_altCursorPosition() { }
        private System.Void .ctor() { }
        private System.Void OnFocus() { }
        private System.Void OnLostFocus() { }
        private System.Void GrabGraphicalCursorPos() { }
        private System.Boolean HandleKeyEvent(UnityEngine.Event e, System.Boolean textIsReadOnly) { }
        private System.Boolean DeleteLineBack() { }
        private System.Boolean DeleteWordBack() { }
        private System.Boolean DeleteWordForward() { }
        private System.Boolean Delete() { }
        private System.Boolean CanPaste() { }
        private System.Boolean Backspace() { }
        private System.Void SelectAll() { }
        private System.Void SelectNone() { }
        private System.Boolean get_hasSelection() { }
        private System.String get_SelectedText() { }
        private System.Boolean DeleteSelection() { }
        private System.Void ReplaceSelection(System.String replace) { }
        private System.Void Insert(System.Char c) { }
        private System.Void MoveSelectionToAltCursor() { }
        private System.Void MoveRight() { }
        private System.Void MoveLeft() { }
        private System.Void MoveUp() { }
        private System.Void MoveDown() { }
        private System.Void MoveLineStart() { }
        private System.Void MoveLineEnd() { }
        private System.Void MoveGraphicalLineStart() { }
        private System.Void MoveGraphicalLineEnd() { }
        private System.Void MoveTextStart() { }
        private System.Void MoveTextEnd() { }
        private System.Int32 IndexOfEndOfLine(System.Int32 startIndex) { }
        private System.Void MoveParagraphForward() { }
        private System.Void MoveParagraphBackward() { }
        private System.Void MoveCursorToPosition_Internal(UnityEngine.Vector2 cursorPosition, System.Boolean shift) { }
        private System.Void MoveAltCursorToPosition(UnityEngine.Vector2 cursorPosition) { }
        private System.Void SelectToPosition(UnityEngine.Vector2 cursorPosition) { }
        private System.Void SelectLeft() { }
        private System.Void SelectRight() { }
        private System.Void SelectUp() { }
        private System.Void SelectDown() { }
        private System.Void SelectTextEnd() { }
        private System.Void SelectTextStart() { }
        private System.Void MouseDragSelectsWholeWords(System.Boolean on) { }
        private System.Void DblClickSnap(UnityEngine.TextEditor.DblClickSnapping snapping) { }
        private System.Int32 GetGraphicalLineStart(System.Int32 p) { }
        private System.Int32 GetGraphicalLineEnd(System.Int32 p) { }
        private System.Int32 FindNextSeperator(System.Int32 startPos) { }
        private System.Int32 FindPrevSeperator(System.Int32 startPos) { }
        private System.Void MoveWordRight() { }
        private System.Void MoveToStartOfNextWord() { }
        private System.Void MoveToEndOfPreviousWord() { }
        private System.Void SelectToStartOfNextWord() { }
        private System.Void SelectToEndOfPreviousWord() { }
        private UnityEngine.TextEditor.CharacterType ClassifyChar(System.Int32 index) { }
        private System.Int32 FindStartOfNextWord(System.Int32 p) { }
        private System.Int32 FindEndOfPreviousWord(System.Int32 p) { }
        private System.Void MoveWordLeft() { }
        private System.Void SelectWordRight() { }
        private System.Void SelectWordLeft() { }
        private System.Void ExpandSelectGraphicalLineStart() { }
        private System.Void ExpandSelectGraphicalLineEnd() { }
        private System.Void SelectGraphicalLineStart() { }
        private System.Void SelectGraphicalLineEnd() { }
        private System.Void SelectParagraphForward() { }
        private System.Void SelectParagraphBackward() { }
        private System.Void SelectCurrentWord() { }
        private System.Int32 FindEndOfClassification(System.Int32 p, UnityEngine.TextEditor.Direction dir) { }
        private System.Void SelectCurrentParagraph() { }
        private System.Void UpdateScrollOffset() { }
        private System.Boolean PerformOperation(UnityEngine.TextEditor.TextEditOp operation, System.Boolean textIsReadOnly) { }
        private System.Void SaveBackup() { }
        private System.Boolean Cut() { }
        private System.Void Copy() { }
        private System.String ReplaceNewlinesWithSpaces(System.String value) { }
        private System.Boolean Paste() { }
        private System.Void MapKey(System.String key, UnityEngine.TextEditor.TextEditOp action) { }
        private System.Void InitKeyActions() { }
        private System.Void DetectFocusChange() { }
        private System.Void OnDetectFocusChange() { }
        private System.Void OnCursorIndexChange() { }
        private System.Void OnSelectIndexChange() { }
        private System.Void ClampTextIndex(System.Int32& index) { }
        private System.Void EnsureValidCodePointIndex(System.Int32& index) { }
        private System.Boolean IsValidCodePointIndex(System.Int32 index) { }
        private System.Int32 PreviousCodePointIndex(System.Int32 index) { }
        private System.Int32 NextCodePointIndex(System.Int32 index) { }

    }

}

