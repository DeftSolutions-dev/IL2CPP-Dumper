// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.IMGUIModule.dll
// Classes:  45
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: WindowFunction
TYPE:  class
TOKEN: 0x200000A
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Int32 id)
END_CLASS

CLASS: ParentClipScope
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  private           System.Boolean                  m_Disposed  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.Matrix4x4 objectTransform, UnityEngine.Rect clipRect)
  System.Void Dispose()
END_CLASS

CLASS: Type
TYPE:  struct
TOKEN: 0x2000012
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.GUILayoutOption.TypefixedWidth  // 0x0
  public    static  UnityEngine.GUILayoutOption.TypefixedHeight  // 0x0
  public    static  UnityEngine.GUILayoutOption.TypeminWidth  // 0x0
  public    static  UnityEngine.GUILayoutOption.TypemaxWidth  // 0x0
  public    static  UnityEngine.GUILayoutOption.TypeminHeight  // 0x0
  public    static  UnityEngine.GUILayoutOption.TypemaxHeight  // 0x0
  public    static  UnityEngine.GUILayoutOption.TypestretchWidth  // 0x0
  public    static  UnityEngine.GUILayoutOption.TypestretchHeight  // 0x0
  public    static  UnityEngine.GUILayoutOption.TypealignStart  // 0x0
  public    static  UnityEngine.GUILayoutOption.TypealignMiddle  // 0x0
  public    static  UnityEngine.GUILayoutOption.TypealignEnd  // 0x0
  public    static  UnityEngine.GUILayoutOption.TypealignJustify  // 0x0
  public    static  UnityEngine.GUILayoutOption.TypeequalSize  // 0x0
  public    static  UnityEngine.GUILayoutOption.Typespacing  // 0x0
METHODS:
END_CLASS

CLASS: LayoutCache
TYPE:  class
TOKEN: 0x2000014
FIELDS:
  private           System.Int32                    <id>k__BackingField  // 0x10
  private           UnityEngine.GUILayoutGroup      topLevel  // 0x18
  private           UnityEngineInternal.GenericStacklayoutGroups  // 0x20
  private           UnityEngine.GUILayoutGroup      windows  // 0x28
METHODS:
  System.Void set_id(System.Int32 value)
  System.Void .ctor(System.Int32 instanceID)
  System.Void ResetCursor()
END_CLASS

CLASS: SkinChangedDelegate
TYPE:  class
TOKEN: 0x2000017
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
END_CLASS

CLASS: DblClickSnapping
TYPE:  struct
TOKEN: 0x2000029
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  UnityEngine.TextEditor.DblClickSnappingWORDS  // 0x0
  public    static  UnityEngine.TextEditor.DblClickSnappingPARAGRAPHS  // 0x0
METHODS:
END_CLASS

CLASS: CharacterType
TYPE:  struct
TOKEN: 0x200002A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextEditor.CharacterTypeLetterLike  // 0x0
  public    static  UnityEngine.TextEditor.CharacterTypeSymbol  // 0x0
  public    static  UnityEngine.TextEditor.CharacterTypeSymbol2  // 0x0
  public    static  UnityEngine.TextEditor.CharacterTypeWhiteSpace  // 0x0
METHODS:
END_CLASS

CLASS: Direction
TYPE:  struct
TOKEN: 0x200002B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextEditor.DirectionForward  // 0x0
  public    static  UnityEngine.TextEditor.DirectionBackward  // 0x0
METHODS:
END_CLASS

CLASS: TextEditOp
TYPE:  struct
TOKEN: 0x200002C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextEditor.TextEditOpMoveLeft  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpMoveRight  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpMoveUp  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpMoveDown  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpMoveLineStart  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpMoveLineEnd  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpMoveTextStart  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpMoveTextEnd  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpMovePageUp  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpMovePageDown  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpMoveGraphicalLineStart  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpMoveGraphicalLineEnd  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpMoveWordLeft  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpMoveWordRight  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpMoveParagraphForward  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpMoveParagraphBackward  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpMoveToStartOfNextWord  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpMoveToEndOfPreviousWord  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpSelectLeft  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpSelectRight  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpSelectUp  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpSelectDown  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpSelectTextStart  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpSelectTextEnd  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpSelectPageUp  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpSelectPageDown  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpExpandSelectGraphicalLineStart  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpExpandSelectGraphicalLineEnd  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpSelectGraphicalLineStart  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpSelectGraphicalLineEnd  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpSelectWordLeft  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpSelectWordRight  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpSelectToEndOfPreviousWord  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpSelectToStartOfNextWord  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpSelectParagraphBackward  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpSelectParagraphForward  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpDelete  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpBackspace  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpDeleteWordBack  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpDeleteWordForward  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpDeleteLineBack  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpCut  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpCopy  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpPaste  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpSelectAll  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpSelectNone  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpScrollStart  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpScrollEnd  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpScrollPageUp  // 0x0
  public    static  UnityEngine.TextEditor.TextEditOpScrollPageDown  // 0x0
METHODS:
END_CLASS

CLASS: Microsoft.CodeAnalysis.EmbeddedAttribute
TYPE:  class
TOKEN: 0x2000002
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Runtime.CompilerServices.IsReadOnlyAttribute
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Event
TYPE:  class
TOKEN: 0x2000004
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
  private   static  UnityEngine.Event               s_Current  // 0x0
  private   static  UnityEngine.Event               s_MasterEvent  // 0x8
METHODS:
  UnityEngine.EventType get_rawType()
  UnityEngine.Vector2 get_mousePosition()
  System.Void set_mousePosition(UnityEngine.Vector2 value)
  UnityEngine.Vector2 get_delta()
  System.Void set_delta(UnityEngine.Vector2 value)
  UnityEngine.PointerType get_pointerType()
  System.Int32 get_button()
  UnityEngine.EventModifiers get_modifiers()
  System.Void set_modifiers(UnityEngine.EventModifiers value)
  System.Single get_pressure()
  System.Int32 get_clickCount()
  System.Char get_character()
  System.Void set_character(System.Char value)
  UnityEngine.KeyCode get_keyCode()
  System.Void set_keyCode(UnityEngine.KeyCode value)
  System.Int32 get_displayIndex()
  System.Void set_displayIndex(System.Int32 value)
  UnityEngine.EventType get_type()
  System.Void set_type(UnityEngine.EventType value)
  System.String get_commandName()
  System.Void set_commandName(System.String value)
  System.Void Internal_Use()
  System.IntPtr Internal_Create(System.Int32 displayIndex)
  System.Void Internal_Destroy(System.IntPtr ptr)
  UnityEngine.EventType GetTypeForControl(System.Int32 controlID)
  System.Void CopyFromPtr(System.IntPtr ptr)
  System.Boolean PopEvent(UnityEngine.Event outEvent)
  System.Void Internal_SetNativeEvent(System.IntPtr ptr)
  System.Void Internal_MakeMasterEventCurrent(System.Int32 displayIndex)
  System.Int32 GetDoubleClickTime()
  System.Void .ctor()
  System.Void .ctor(System.Int32 displayIndex)
  System.Void Finalize()
  System.Void CopyFrom(UnityEngine.Event e)
  System.Boolean get_shift()
  System.Boolean get_control()
  System.Boolean get_alt()
  System.Boolean get_command()
  UnityEngine.Event get_current()
  System.Void set_current(UnityEngine.Event value)
  System.Boolean get_isKey()
  System.Boolean get_isMouse()
  System.Boolean get_isDirectManipulationDevice()
  UnityEngine.Event KeyboardEvent(System.String key)
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object obj)
  System.String ToString()
  System.Void Use()
  System.Void get_mousePosition_Injected(UnityEngine.Vector2& ret)
  System.Void set_mousePosition_Injected(UnityEngine.Vector2& value)
  System.Void get_delta_Injected(UnityEngine.Vector2& ret)
  System.Void set_delta_Injected(UnityEngine.Vector2& value)
END_CLASS

CLASS: UnityEngine.EventType
TYPE:  struct
TOKEN: 0x2000005
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.EventType           MouseDown  // 0x0
  public    static  UnityEngine.EventType           MouseUp  // 0x0
  public    static  UnityEngine.EventType           MouseMove  // 0x0
  public    static  UnityEngine.EventType           MouseDrag  // 0x0
  public    static  UnityEngine.EventType           KeyDown  // 0x0
  public    static  UnityEngine.EventType           KeyUp  // 0x0
  public    static  UnityEngine.EventType           ScrollWheel  // 0x0
  public    static  UnityEngine.EventType           Repaint  // 0x0
  public    static  UnityEngine.EventType           Layout  // 0x0
  public    static  UnityEngine.EventType           DragUpdated  // 0x0
  public    static  UnityEngine.EventType           DragPerform  // 0x0
  public    static  UnityEngine.EventType           DragExited  // 0x0
  public    static  UnityEngine.EventType           Ignore  // 0x0
  public    static  UnityEngine.EventType           Used  // 0x0
  public    static  UnityEngine.EventType           ValidateCommand  // 0x0
  public    static  UnityEngine.EventType           ExecuteCommand  // 0x0
  public    static  UnityEngine.EventType           ContextClick  // 0x0
  public    static  UnityEngine.EventType           MouseEnterWindow  // 0x0
  public    static  UnityEngine.EventType           MouseLeaveWindow  // 0x0
  public    static  UnityEngine.EventType           TouchDown  // 0x0
  public    static  UnityEngine.EventType           TouchUp  // 0x0
  public    static  UnityEngine.EventType           TouchMove  // 0x0
  public    static  UnityEngine.EventType           TouchEnter  // 0x0
  public    static  UnityEngine.EventType           TouchLeave  // 0x0
  public    static  UnityEngine.EventType           TouchStationary  // 0x0
  public    static  UnityEngine.EventType           mouseDown  // 0x0
  public    static  UnityEngine.EventType           mouseUp  // 0x0
  public    static  UnityEngine.EventType           mouseMove  // 0x0
  public    static  UnityEngine.EventType           mouseDrag  // 0x0
  public    static  UnityEngine.EventType           keyDown  // 0x0
  public    static  UnityEngine.EventType           keyUp  // 0x0
  public    static  UnityEngine.EventType           scrollWheel  // 0x0
  public    static  UnityEngine.EventType           repaint  // 0x0
  public    static  UnityEngine.EventType           layout  // 0x0
  public    static  UnityEngine.EventType           dragUpdated  // 0x0
  public    static  UnityEngine.EventType           dragPerform  // 0x0
  public    static  UnityEngine.EventType           ignore  // 0x0
  public    static  UnityEngine.EventType           used  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.EventModifiers
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.EventModifiers      None  // 0x0
  public    static  UnityEngine.EventModifiers      Shift  // 0x0
  public    static  UnityEngine.EventModifiers      Control  // 0x0
  public    static  UnityEngine.EventModifiers      Alt  // 0x0
  public    static  UnityEngine.EventModifiers      Command  // 0x0
  public    static  UnityEngine.EventModifiers      Numeric  // 0x0
  public    static  UnityEngine.EventModifiers      CapsLock  // 0x0
  public    static  UnityEngine.EventModifiers      FunctionKey  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.PointerType
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.PointerType         Mouse  // 0x0
  public    static  UnityEngine.PointerType         Touch  // 0x0
  public    static  UnityEngine.PointerType         Pen  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.EventInterests
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  private           System.Boolean                  <wantsMouseMove>k__BackingField  // 0x10
  private           System.Boolean                  <wantsMouseEnterLeaveWindow>k__BackingField  // 0x11
  private           System.Boolean                  <wantsLessLayoutEvents>k__BackingField  // 0x12
METHODS:
  System.Boolean get_wantsMouseMove()
  System.Void set_wantsMouseMove(System.Boolean value)
  System.Boolean get_wantsMouseEnterLeaveWindow()
  System.Void set_wantsMouseEnterLeaveWindow(System.Boolean value)
  System.Boolean get_wantsLessLayoutEvents()
  System.Boolean WantsEvent(UnityEngine.EventType type)
  System.Boolean WantsLayoutPass(UnityEngine.EventType type)
END_CLASS

CLASS: UnityEngine.GUI
TYPE:  class
TOKEN: 0x2000009
FIELDS:
  private   static  System.Int32                    s_ScrollControlId  // 0x0
  private   static  System.Int32                    s_HotTextField  // 0x4
  private   static readonly System.Int32                    s_BoxHash  // 0x8
  private   static readonly System.Int32                    s_ButonHash  // 0xC
  private   static readonly System.Int32                    s_RepeatButtonHash  // 0x10
  private   static readonly System.Int32                    s_ToggleHash  // 0x14
  private   static readonly System.Int32                    s_ButtonGridHash  // 0x18
  private   static readonly System.Int32                    s_SliderHash  // 0x1C
  private   static readonly System.Int32                    s_BeginGroupHash  // 0x20
  private   static readonly System.Int32                    s_ScrollviewHash  // 0x24
  private   static  System.Int32                    <scrollTroughSide>k__BackingField  // 0x28
  private   static  System.DateTime                 <nextScrollStepTime>k__BackingField  // 0x30
  private   static  UnityEngine.GUISkin             s_Skin  // 0x38
  private   static  UnityEngine.Rect                s_ToolTipRect  // 0x40
  private   static  UnityEngineInternal.GenericStack<scrollViewStates>k__BackingField  // 0x50
METHODS:
  UnityEngine.Color get_color()
  System.Void set_color(UnityEngine.Color value)
  UnityEngine.Color get_backgroundColor()
  System.Void set_backgroundColor(UnityEngine.Color value)
  UnityEngine.Color get_contentColor()
  System.Void set_contentColor(UnityEngine.Color value)
  System.Boolean get_changed()
  System.Void set_changed(System.Boolean value)
  System.Boolean get_enabled()
  System.Void set_enabled(System.Boolean value)
  System.Boolean get_usePageScrollbars()
  UnityEngine.Material get_blendMaterial()
  UnityEngine.Material get_blitMaterial()
  UnityEngine.Material get_roundedRectMaterial()
  UnityEngine.Material get_roundedRectWithColorPerBorderMaterial()
  System.Void GrabMouseControl(System.Int32 id)
  System.Boolean HasMouseControl(System.Int32 id)
  System.Void ReleaseMouseControl()
  System.Void InternalRepaintEditorWindow()
  System.Void .cctor()
  System.Int32 get_scrollTroughSide()
  System.Void set_scrollTroughSide(System.Int32 value)
  System.DateTime get_nextScrollStepTime()
  System.Void set_nextScrollStepTime(System.DateTime value)
  System.Void set_skin(UnityEngine.GUISkin value)
  UnityEngine.GUISkin get_skin()
  System.Void DoSetSkin(UnityEngine.GUISkin newSkin)
  UnityEngine.Matrix4x4 get_matrix()
  System.Void set_matrix(UnityEngine.Matrix4x4 value)
  System.Void Label(UnityEngine.Rect position, System.String text)
  System.Void Label(UnityEngine.Rect position, System.String text, UnityEngine.GUIStyle style)
  System.Void Label(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style)
  System.Void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image)
  System.Void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode)
  System.Void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, System.Boolean alphaBlend)
  System.Void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, System.Boolean alphaBlend, System.Single imageAspect)
  System.Void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, System.Boolean alphaBlend, System.Single imageAspect, UnityEngine.Color color, System.Single borderWidth, System.Single borderRadius)
  System.Void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, System.Boolean alphaBlend, System.Single imageAspect, UnityEngine.Color color, UnityEngine.Vector4 borderWidths, System.Single borderRadius)
  System.Void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, System.Boolean alphaBlend, System.Single imageAspect, UnityEngine.Color color, UnityEngine.Vector4 borderWidths, UnityEngine.Vector4 borderRadiuses)
  System.Void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, System.Boolean alphaBlend, System.Single imageAspect, UnityEngine.Color color, UnityEngine.Vector4 borderWidths, UnityEngine.Vector4 borderRadiuses, System.Boolean drawSmoothCorners)
  System.Void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, System.Boolean alphaBlend, System.Single imageAspect, UnityEngine.Color leftColor, UnityEngine.Color topColor, UnityEngine.Color rightColor, UnityEngine.Color bottomColor, UnityEngine.Vector4 borderWidths, UnityEngine.Vector4 borderRadiuses, System.Boolean drawSmoothCorners)
  System.Boolean CalculateScaledTextureRects(UnityEngine.Rect position, UnityEngine.ScaleMode scaleMode, System.Single imageAspect, UnityEngine.Rect& outScreenRect, UnityEngine.Rect& outSourceRect)
  System.Void Box(UnityEngine.Rect position, System.String text)
  System.Void Box(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style)
  System.Boolean DoRepeatButton(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.FocusType focusType)
  System.Boolean Toggle(UnityEngine.Rect position, System.Boolean value, UnityEngine.GUIContent content, UnityEngine.GUIStyle style)
  System.Boolean DoControl(UnityEngine.Rect position, System.Int32 id, System.Boolean on, System.Boolean hover, UnityEngine.GUIContent content, UnityEngine.GUIStyle style)
  System.Void DoLabel(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style)
  System.Boolean DoToggle(UnityEngine.Rect position, System.Int32 id, System.Boolean value, UnityEngine.GUIContent content, UnityEngine.GUIStyle style)
  System.Single Slider(UnityEngine.Rect position, System.Single value, System.Single size, System.Single start, System.Single end, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, System.Boolean horiz, System.Int32 id, UnityEngine.GUIStyle thumbExtent)
  System.Single HorizontalScrollbar(UnityEngine.Rect position, System.Single value, System.Single size, System.Single leftValue, System.Single rightValue, UnityEngine.GUIStyle style)
  System.Boolean ScrollerRepeatButton(System.Int32 scrollerID, UnityEngine.Rect rect, UnityEngine.GUIStyle style)
  System.Single VerticalScrollbar(UnityEngine.Rect position, System.Single value, System.Single size, System.Single topValue, System.Single bottomValue, UnityEngine.GUIStyle style)
  System.Single Scroller(UnityEngine.Rect position, System.Single value, System.Single size, System.Single leftValue, System.Single rightValue, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, UnityEngine.GUIStyle leftButton, UnityEngine.GUIStyle rightButton, System.Boolean horiz)
  System.Void BeginGroup(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style)
  System.Void BeginGroup(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.Vector2 scrollOffset)
  System.Void EndGroup()
  UnityEngineInternal.GenericStack get_scrollViewStates()
  UnityEngine.Vector2 BeginScrollView(UnityEngine.Rect position, UnityEngine.Vector2 scrollPosition, UnityEngine.Rect viewRect)
  UnityEngine.Vector2 BeginScrollView(UnityEngine.Rect position, UnityEngine.Vector2 scrollPosition, UnityEngine.Rect viewRect, System.Boolean alwaysShowHorizontal, System.Boolean alwaysShowVertical, UnityEngine.GUIStyle horizontalScrollbar, UnityEngine.GUIStyle verticalScrollbar, UnityEngine.GUIStyle background)
  System.Void EndScrollView()
  System.Void EndScrollView(System.Boolean handleScrollWheel)
  System.Void CallWindowDelegate(UnityEngine.GUI.WindowFunction func, System.Int32 id, System.Int32 instanceID, UnityEngine.GUISkin _skin, System.Int32 forceRect, System.Single width, System.Single height, UnityEngine.GUIStyle style)
  System.Void get_color_Injected(UnityEngine.Color& ret)
  System.Void set_color_Injected(UnityEngine.Color& value)
  System.Void get_backgroundColor_Injected(UnityEngine.Color& ret)
  System.Void set_backgroundColor_Injected(UnityEngine.Color& value)
  System.Void get_contentColor_Injected(UnityEngine.Color& ret)
  System.Void set_contentColor_Injected(UnityEngine.Color& value)
END_CLASS

CLASS: UnityEngine.GUIClip
TYPE:  class
TOKEN: 0x200000B
FIELDS:
METHODS:
  UnityEngine.Rect get_visibleRect()
  System.Void Internal_Push(UnityEngine.Rect screenRect, UnityEngine.Vector2 scrollOffset, UnityEngine.Vector2 renderOffset, System.Boolean resetOffset)
  System.Void Internal_Pop()
  System.Int32 Internal_GetCount()
  UnityEngine.Vector2 Unclip_Vector2(UnityEngine.Vector2 pos)
  UnityEngine.Vector2 UnclipToWindow_Vector2(UnityEngine.Vector2 pos)
  UnityEngine.Vector2 ClipToWindow_Vector2(UnityEngine.Vector2 absolutePos)
  UnityEngine.Matrix4x4 GetMatrix()
  System.Void SetMatrix(UnityEngine.Matrix4x4 m)
  System.Void Internal_PushParentClip(UnityEngine.Matrix4x4 objectTransform, UnityEngine.Rect clipRect)
  System.Void Internal_PushParentClip(UnityEngine.Matrix4x4 renderTransform, UnityEngine.Matrix4x4 inputTransform, UnityEngine.Rect clipRect)
  System.Void Internal_PopParentClip()
  System.Void Push(UnityEngine.Rect screenRect, UnityEngine.Vector2 scrollOffset, UnityEngine.Vector2 renderOffset, System.Boolean resetOffset)
  System.Void Pop()
  UnityEngine.Vector2 Unclip(UnityEngine.Vector2 pos)
  UnityEngine.Vector2 UnclipToWindow(UnityEngine.Vector2 pos)
  UnityEngine.Vector2 ClipToWindow(UnityEngine.Vector2 absolutePos)
  System.Void get_visibleRect_Injected(UnityEngine.Rect& ret)
  System.Void Internal_Push_Injected(UnityEngine.Rect& screenRect, UnityEngine.Vector2& scrollOffset, UnityEngine.Vector2& renderOffset, System.Boolean resetOffset)
  System.Void Unclip_Vector2_Injected(UnityEngine.Vector2& pos, UnityEngine.Vector2& ret)
  System.Void UnclipToWindow_Vector2_Injected(UnityEngine.Vector2& pos, UnityEngine.Vector2& ret)
  System.Void ClipToWindow_Vector2_Injected(UnityEngine.Vector2& absolutePos, UnityEngine.Vector2& ret)
  System.Void GetMatrix_Injected(UnityEngine.Matrix4x4& ret)
  System.Void SetMatrix_Injected(UnityEngine.Matrix4x4& m)
  System.Void Internal_PushParentClip_Injected(UnityEngine.Matrix4x4& renderTransform, UnityEngine.Matrix4x4& inputTransform, UnityEngine.Rect& clipRect)
END_CLASS

CLASS: UnityEngine.GUIContent
TYPE:  class
TOKEN: 0x200000D
FIELDS:
  private           System.String                   m_Text  // 0x10
  private           UnityEngine.Texture             m_Image  // 0x18
  private           System.String                   m_Tooltip  // 0x20
  private   static readonly UnityEngine.GUIContent          s_Text  // 0x0
  private   static readonly UnityEngine.GUIContent          s_Image  // 0x8
  private   static readonly UnityEngine.GUIContent          s_TextImage  // 0x10
  public    static  UnityEngine.GUIContent          none  // 0x18
METHODS:
  System.String get_text()
  System.Void set_text(System.String value)
  System.Void set_image(UnityEngine.Texture value)
  System.String get_tooltip()
  System.Void set_tooltip(System.String value)
  System.Void .ctor()
  System.Void .ctor(System.String text)
  System.Void .ctor(System.String text, System.String tooltip)
  System.Void .ctor(System.String text, UnityEngine.Texture image, System.String tooltip)
  System.Void .ctor(UnityEngine.GUIContent src)
  System.Int32 get_hash()
  UnityEngine.GUIContent Temp(System.String t)
  System.Void ClearStaticCache()
  System.String ToString()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.ScaleMode
TYPE:  struct
TOKEN: 0x200000E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ScaleMode           StretchToFill  // 0x0
  public    static  UnityEngine.ScaleMode           ScaleAndCrop  // 0x0
  public    static  UnityEngine.ScaleMode           ScaleToFit  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.FocusType
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.FocusType           Native  // 0x0
  public    static  UnityEngine.FocusType           Keyboard  // 0x0
  public    static  UnityEngine.FocusType           Passive  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.GUILayout
TYPE:  class
TOKEN: 0x2000010
FIELDS:
METHODS:
  System.Void Label(System.String text, UnityEngine.GUILayoutOption[] options)
  System.Void Label(System.String text, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options)
  System.Void DoLabel(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options)
  System.Boolean Toggle(System.Boolean value, System.String text, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options)
  System.Boolean Toggle(System.Boolean value, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options)
  System.Boolean DoToggle(System.Boolean value, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options)
  System.Void Space(System.Single pixels)
  System.Void FlexibleSpace()
  System.Void BeginHorizontal(UnityEngine.GUILayoutOption[] options)
  System.Void BeginHorizontal(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options)
  System.Void EndHorizontal()
  System.Void BeginVertical(UnityEngine.GUILayoutOption[] options)
  System.Void BeginVertical(UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options)
  System.Void BeginVertical(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options)
  System.Void EndVertical()
  System.Void BeginArea(UnityEngine.Rect screenRect)
  System.Void BeginArea(UnityEngine.Rect screenRect, UnityEngine.GUIContent content, UnityEngine.GUIStyle style)
  System.Void EndArea()
  UnityEngine.Vector2 BeginScrollView(UnityEngine.Vector2 scrollPosition, UnityEngine.GUILayoutOption[] options)
  UnityEngine.Vector2 BeginScrollView(UnityEngine.Vector2 scrollPosition, System.Boolean alwaysShowHorizontal, System.Boolean alwaysShowVertical, UnityEngine.GUIStyle horizontalScrollbar, UnityEngine.GUIStyle verticalScrollbar, UnityEngine.GUIStyle background, UnityEngine.GUILayoutOption[] options)
  System.Void EndScrollView()
  System.Void EndScrollView(System.Boolean handleScrollWheel)
  UnityEngine.GUILayoutOption Width(System.Single width)
  UnityEngine.GUILayoutOption Height(System.Single height)
  UnityEngine.GUILayoutOption ExpandWidth(System.Boolean expand)
  UnityEngine.GUILayoutOption ExpandHeight(System.Boolean expand)
END_CLASS

CLASS: UnityEngine.GUILayoutOption
TYPE:  class
TOKEN: 0x2000011
FIELDS:
  private           UnityEngine.GUILayoutOption.Typetype  // 0x10
  private           System.Object                   value  // 0x18
METHODS:
  System.Void .ctor(UnityEngine.GUILayoutOption.Type type, System.Object value)
END_CLASS

CLASS: UnityEngine.GUILayoutUtility
TYPE:  class
TOKEN: 0x2000013
FIELDS:
  private   static readonly System.Collections.Generic.Dictionary<System.Int32,UnityEngine.GUILayoutUtility.LayoutCache>s_StoredLayouts  // 0x0
  private   static readonly System.Collections.Generic.Dictionary<System.Int32,UnityEngine.GUILayoutUtility.LayoutCache>s_StoredWindows  // 0x8
  private   static  UnityEngine.GUILayoutUtility.LayoutCachecurrent  // 0x10
  private   static readonly UnityEngine.Rect                kDummyRect  // 0x18
  private   static  System.Int32                    <unbalancedgroupscount>k__BackingField  // 0x28
  private   static  UnityEngine.GUIStyle            s_SpaceStyle  // 0x30
METHODS:
  UnityEngine.Rect Internal_GetWindowRect(System.Int32 windowID)
  System.Void Internal_MoveWindow(System.Int32 windowID, UnityEngine.Rect r)
  System.Int32 get_unbalancedgroupscount()
  System.Void set_unbalancedgroupscount(System.Int32 value)
  UnityEngine.GUILayoutUtility.LayoutCache SelectIDList(System.Int32 instanceID, System.Boolean isWindow)
  System.Void Begin(System.Int32 instanceID)
  System.Void BeginContainer(UnityEngine.GUILayoutUtility.LayoutCache cache)
  System.Void BeginWindow(System.Int32 windowID, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options)
  System.Void Layout()
  System.Void LayoutFromEditorWindow()
  System.Void LayoutFromContainer(System.Single w, System.Single h)
  System.Void LayoutFreeGroup(UnityEngine.GUILayoutGroup toplevel)
  System.Void LayoutSingleGroup(UnityEngine.GUILayoutGroup i)
  UnityEngine.GUILayoutGroup CreateGUILayoutGroupInstanceOfType(System.Type LayoutType)
  UnityEngine.GUILayoutGroup BeginLayoutGroup(UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options, System.Type layoutType)
  System.Void EndLayoutGroup()
  UnityEngine.GUILayoutGroup BeginLayoutArea(UnityEngine.GUIStyle style, System.Type layoutType)
  UnityEngine.Rect GetRect(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options)
  UnityEngine.Rect DoGetRect(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options)
  UnityEngine.Rect GetRect(System.Single width, System.Single height, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options)
  UnityEngine.Rect DoGetRect(System.Single minWidth, System.Single maxWidth, System.Single minHeight, System.Single maxHeight, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options)
  UnityEngine.Rect GetLastRect()
  UnityEngine.GUIStyle get_spaceStyle()
  System.Void .cctor()
  System.Void Internal_GetWindowRect_Injected(System.Int32 windowID, UnityEngine.Rect& ret)
  System.Void Internal_MoveWindow_Injected(System.Int32 windowID, UnityEngine.Rect& r)
END_CLASS

CLASS: UnityEngine.GUISettings
TYPE:  class
TOKEN: 0x2000015
FIELDS:
  private           System.Boolean                  m_DoubleClickSelectsWord  // 0x10
  private           System.Boolean                  m_TripleClickSelectsLine  // 0x11
  private           UnityEngine.Color               m_CursorColor  // 0x14
  private           System.Single                   m_CursorFlashSpeed  // 0x24
  private           UnityEngine.Color               m_SelectionColor  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.GUISkin
TYPE:  class
TOKEN: 0x2000016
EXTENDS: ScriptableObject
FIELDS:
  private           UnityEngine.Font                m_Font  // 0x18
  private           UnityEngine.GUIStyle            m_box  // 0x20
  private           UnityEngine.GUIStyle            m_button  // 0x28
  private           UnityEngine.GUIStyle            m_toggle  // 0x30
  private           UnityEngine.GUIStyle            m_label  // 0x38
  private           UnityEngine.GUIStyle            m_textField  // 0x40
  private           UnityEngine.GUIStyle            m_textArea  // 0x48
  private           UnityEngine.GUIStyle            m_window  // 0x50
  private           UnityEngine.GUIStyle            m_horizontalSlider  // 0x58
  private           UnityEngine.GUIStyle            m_horizontalSliderThumb  // 0x60
  private           UnityEngine.GUIStyle            m_horizontalSliderThumbExtent  // 0x68
  private           UnityEngine.GUIStyle            m_verticalSlider  // 0x70
  private           UnityEngine.GUIStyle            m_verticalSliderThumb  // 0x78
  private           UnityEngine.GUIStyle            m_verticalSliderThumbExtent  // 0x80
  private           UnityEngine.GUIStyle            m_SliderMixed  // 0x88
  private           UnityEngine.GUIStyle            m_horizontalScrollbar  // 0x90
  private           UnityEngine.GUIStyle            m_horizontalScrollbarThumb  // 0x98
  private           UnityEngine.GUIStyle            m_horizontalScrollbarLeftButton  // 0xA0
  private           UnityEngine.GUIStyle            m_horizontalScrollbarRightButton  // 0xA8
  private           UnityEngine.GUIStyle            m_verticalScrollbar  // 0xB0
  private           UnityEngine.GUIStyle            m_verticalScrollbarThumb  // 0xB8
  private           UnityEngine.GUIStyle            m_verticalScrollbarUpButton  // 0xC0
  private           UnityEngine.GUIStyle            m_verticalScrollbarDownButton  // 0xC8
  private           UnityEngine.GUIStyle            m_ScrollView  // 0xD0
  private           UnityEngine.GUIStyle[]          m_CustomStyles  // 0xD8
  private           UnityEngine.GUISettings         m_Settings  // 0xE0
  private   static  UnityEngine.GUIStyle            ms_Error  // 0x0
  private           System.Collections.Generic.Dictionary<System.String,UnityEngine.GUIStyle>m_Styles  // 0xE8
  private   static  UnityEngine.GUISkin.SkinChangedDelegatem_SkinChanged  // 0x8
  private   static  UnityEngine.GUISkin             current  // 0x10
METHODS:
  System.Void .ctor()
  System.Void OnEnable()
  System.Void CleanupRoots()
  UnityEngine.Font get_font()
  System.Void set_font(UnityEngine.Font value)
  UnityEngine.GUIStyle get_box()
  System.Void set_box(UnityEngine.GUIStyle value)
  UnityEngine.GUIStyle get_label()
  System.Void set_label(UnityEngine.GUIStyle value)
  UnityEngine.GUIStyle get_textField()
  System.Void set_textField(UnityEngine.GUIStyle value)
  UnityEngine.GUIStyle get_textArea()
  System.Void set_textArea(UnityEngine.GUIStyle value)
  UnityEngine.GUIStyle get_button()
  System.Void set_button(UnityEngine.GUIStyle value)
  UnityEngine.GUIStyle get_toggle()
  System.Void set_toggle(UnityEngine.GUIStyle value)
  UnityEngine.GUIStyle get_window()
  System.Void set_window(UnityEngine.GUIStyle value)
  UnityEngine.GUIStyle get_horizontalSlider()
  System.Void set_horizontalSlider(UnityEngine.GUIStyle value)
  UnityEngine.GUIStyle get_horizontalSliderThumb()
  System.Void set_horizontalSliderThumb(UnityEngine.GUIStyle value)
  UnityEngine.GUIStyle get_horizontalSliderThumbExtent()
  System.Void set_horizontalSliderThumbExtent(UnityEngine.GUIStyle value)
  UnityEngine.GUIStyle get_sliderMixed()
  System.Void set_sliderMixed(UnityEngine.GUIStyle value)
  UnityEngine.GUIStyle get_verticalSlider()
  System.Void set_verticalSlider(UnityEngine.GUIStyle value)
  UnityEngine.GUIStyle get_verticalSliderThumb()
  System.Void set_verticalSliderThumb(UnityEngine.GUIStyle value)
  UnityEngine.GUIStyle get_verticalSliderThumbExtent()
  System.Void set_verticalSliderThumbExtent(UnityEngine.GUIStyle value)
  UnityEngine.GUIStyle get_horizontalScrollbar()
  System.Void set_horizontalScrollbar(UnityEngine.GUIStyle value)
  UnityEngine.GUIStyle get_horizontalScrollbarThumb()
  System.Void set_horizontalScrollbarThumb(UnityEngine.GUIStyle value)
  UnityEngine.GUIStyle get_horizontalScrollbarLeftButton()
  System.Void set_horizontalScrollbarLeftButton(UnityEngine.GUIStyle value)
  UnityEngine.GUIStyle get_horizontalScrollbarRightButton()
  System.Void set_horizontalScrollbarRightButton(UnityEngine.GUIStyle value)
  UnityEngine.GUIStyle get_verticalScrollbar()
  System.Void set_verticalScrollbar(UnityEngine.GUIStyle value)
  UnityEngine.GUIStyle get_verticalScrollbarThumb()
  System.Void set_verticalScrollbarThumb(UnityEngine.GUIStyle value)
  UnityEngine.GUIStyle get_verticalScrollbarUpButton()
  System.Void set_verticalScrollbarUpButton(UnityEngine.GUIStyle value)
  UnityEngine.GUIStyle get_verticalScrollbarDownButton()
  System.Void set_verticalScrollbarDownButton(UnityEngine.GUIStyle value)
  UnityEngine.GUIStyle get_scrollView()
  System.Void set_scrollView(UnityEngine.GUIStyle value)
  UnityEngine.GUIStyle[] get_customStyles()
  System.Void set_customStyles(UnityEngine.GUIStyle[] value)
  UnityEngine.GUISettings get_settings()
  UnityEngine.GUIStyle get_error()
  System.Void Apply()
  System.Void BuildStyleCache()
  UnityEngine.GUIStyle GetStyle(System.String styleName)
  UnityEngine.GUIStyle FindStyle(System.String styleName)
  System.Void MakeCurrent()
  System.Collections.IEnumerator GetEnumerator()
END_CLASS

CLASS: UnityEngine.GUIStateObjects
TYPE:  class
TOKEN: 0x2000018
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.Int32,System.Object>s_StateCache  // 0x0
METHODS:
  System.Object GetStateObject(System.Type t, System.Int32 controlID)
  System.Object QueryStateObject(System.Type t, System.Int32 controlID)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.GUIStyleState
TYPE:  class
TOKEN: 0x2000019
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
  private   readonly UnityEngine.GUIStyle            m_SourceStyle  // 0x18
METHODS:
  UnityEngine.Texture2D get_background()
  System.Void set_background(UnityEngine.Texture2D value)
  UnityEngine.Color get_textColor()
  System.Void set_textColor(UnityEngine.Color value)
  System.IntPtr Init()
  System.Void Cleanup()
  System.Void .ctor()
  System.Void .ctor(UnityEngine.GUIStyle sourceStyle, System.IntPtr source)
  UnityEngine.GUIStyleState GetGUIStyleState(UnityEngine.GUIStyle sourceStyle, System.IntPtr source)
  System.Void Finalize()
  System.Void get_textColor_Injected(UnityEngine.Color& ret)
  System.Void set_textColor_Injected(UnityEngine.Color& value)
END_CLASS

CLASS: UnityEngine.GUIStyle
TYPE:  class
TOKEN: 0x200001A
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
  private           UnityEngine.GUIStyleState       m_Normal  // 0x18
  private           UnityEngine.GUIStyleState       m_Hover  // 0x20
  private           UnityEngine.GUIStyleState       m_Active  // 0x28
  private           UnityEngine.GUIStyleState       m_Focused  // 0x30
  private           UnityEngine.GUIStyleState       m_OnNormal  // 0x38
  private           UnityEngine.GUIStyleState       m_OnHover  // 0x40
  private           UnityEngine.GUIStyleState       m_OnActive  // 0x48
  private           UnityEngine.GUIStyleState       m_OnFocused  // 0x50
  private           UnityEngine.RectOffset          m_Border  // 0x58
  private           UnityEngine.RectOffset          m_Padding  // 0x60
  private           UnityEngine.RectOffset          m_Margin  // 0x68
  private           UnityEngine.RectOffset          m_Overflow  // 0x70
  private           System.String                   m_Name  // 0x78
  private   static  System.Boolean                  showKeyboardFocus  // 0x0
  private   static  UnityEngine.GUIStyle            s_None  // 0x8
METHODS:
  System.String get_rawName()
  System.Void set_rawName(System.String value)
  UnityEngine.Font get_font()
  System.Void set_font(UnityEngine.Font value)
  UnityEngine.ImagePosition get_imagePosition()
  System.Void set_imagePosition(UnityEngine.ImagePosition value)
  UnityEngine.TextAnchor get_alignment()
  System.Void set_alignment(UnityEngine.TextAnchor value)
  System.Boolean get_wordWrap()
  System.Void set_wordWrap(System.Boolean value)
  UnityEngine.TextClipping get_clipping()
  System.Void set_clipping(UnityEngine.TextClipping value)
  UnityEngine.Vector2 get_contentOffset()
  System.Void set_contentOffset(UnityEngine.Vector2 value)
  System.Single get_fixedWidth()
  System.Void set_fixedWidth(System.Single value)
  System.Single get_fixedHeight()
  System.Void set_fixedHeight(System.Single value)
  System.Boolean get_stretchWidth()
  System.Void set_stretchWidth(System.Boolean value)
  System.Boolean get_stretchHeight()
  System.Void set_stretchHeight(System.Boolean value)
  System.Int32 get_fontSize()
  System.Void set_fontSize(System.Int32 value)
  UnityEngine.FontStyle get_fontStyle()
  System.Void set_fontStyle(UnityEngine.FontStyle value)
  System.Boolean get_richText()
  System.Void set_richText(System.Boolean value)
  System.IntPtr Internal_Create(UnityEngine.GUIStyle self)
  System.IntPtr Internal_Copy(UnityEngine.GUIStyle self, UnityEngine.GUIStyle other)
  System.Void Internal_Destroy(System.IntPtr self)
  System.IntPtr GetStyleStatePtr(System.Int32 idx)
  System.Void AssignStyleState(System.Int32 idx, System.IntPtr srcStyleState)
  System.IntPtr GetRectOffsetPtr(System.Int32 idx)
  System.Void AssignRectOffset(System.Int32 idx, System.IntPtr srcRectOffset)
  System.Single Internal_GetLineHeight(System.IntPtr target)
  System.Void Internal_Draw(UnityEngine.Rect screenRect, UnityEngine.GUIContent content, System.Boolean isHover, System.Boolean isActive, System.Boolean on, System.Boolean hasKeyboardFocus)
  System.Void Internal_Draw2(UnityEngine.Rect position, UnityEngine.GUIContent content, System.Int32 controlID, System.Boolean on)
  UnityEngine.Vector2 Internal_GetCursorPixelPosition(UnityEngine.Rect position, UnityEngine.GUIContent content, System.Int32 cursorStringIndex)
  System.Int32 Internal_GetCursorStringIndex(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.Vector2 cursorPixelPosition)
  System.String Internal_GetSelectedRenderedText(UnityEngine.Rect localPosition, UnityEngine.GUIContent mContent, System.Int32 selectIndex, System.Int32 cursorIndex)
  UnityEngine.Vector2 Internal_CalcSize(UnityEngine.GUIContent content)
  UnityEngine.Vector2 Internal_CalcSizeWithConstraints(UnityEngine.GUIContent content, UnityEngine.Vector2 maxSize)
  System.Single Internal_CalcHeight(UnityEngine.GUIContent content, System.Single width)
  UnityEngine.Vector2 Internal_CalcMinMaxWidth(UnityEngine.GUIContent content)
  System.Void SetMouseTooltip(System.String tooltip, UnityEngine.Rect screenRect)
  System.Boolean IsTooltipActive(System.String tooltip)
  System.Void SetDefaultFont(UnityEngine.Font font)
  System.Void .ctor()
  System.Void .ctor(UnityEngine.GUIStyle other)
  System.Void Finalize()
  System.String get_name()
  System.Void set_name(System.String value)
  UnityEngine.GUIStyleState get_normal()
  System.Void set_normal(UnityEngine.GUIStyleState value)
  UnityEngine.GUIStyleState get_hover()
  System.Void set_hover(UnityEngine.GUIStyleState value)
  UnityEngine.GUIStyleState get_active()
  System.Void set_active(UnityEngine.GUIStyleState value)
  UnityEngine.GUIStyleState get_onNormal()
  System.Void set_onNormal(UnityEngine.GUIStyleState value)
  UnityEngine.GUIStyleState get_onHover()
  System.Void set_onHover(UnityEngine.GUIStyleState value)
  UnityEngine.GUIStyleState get_onActive()
  System.Void set_onActive(UnityEngine.GUIStyleState value)
  UnityEngine.GUIStyleState get_focused()
  System.Void set_focused(UnityEngine.GUIStyleState value)
  UnityEngine.GUIStyleState get_onFocused()
  System.Void set_onFocused(UnityEngine.GUIStyleState value)
  UnityEngine.RectOffset get_border()
  System.Void set_border(UnityEngine.RectOffset value)
  UnityEngine.RectOffset get_margin()
  System.Void set_margin(UnityEngine.RectOffset value)
  UnityEngine.RectOffset get_padding()
  System.Void set_padding(UnityEngine.RectOffset value)
  UnityEngine.RectOffset get_overflow()
  System.Void set_overflow(UnityEngine.RectOffset value)
  System.Single get_lineHeight()
  System.Void Draw(UnityEngine.Rect position, System.Boolean isHover, System.Boolean isActive, System.Boolean on, System.Boolean hasKeyboardFocus)
  System.Void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, System.Boolean isHover, System.Boolean isActive, System.Boolean on, System.Boolean hasKeyboardFocus)
  System.Void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, System.Int32 controlID)
  System.Void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, System.Int32 controlID, System.Boolean on, System.Boolean hover)
  System.Void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, System.Int32 controlId, System.Boolean isHover, System.Boolean isActive, System.Boolean on, System.Boolean hasKeyboardFocus)
  UnityEngine.GUIStyle get_none()
  UnityEngine.Vector2 GetCursorPixelPosition(UnityEngine.Rect position, UnityEngine.GUIContent content, System.Int32 cursorStringIndex)
  System.Int32 GetCursorStringIndex(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.Vector2 cursorPixelPosition)
  UnityEngine.Vector2 CalcSize(UnityEngine.GUIContent content)
  UnityEngine.Vector2 CalcSizeWithConstraints(UnityEngine.GUIContent content, UnityEngine.Vector2 constraints)
  System.Single CalcHeight(UnityEngine.GUIContent content, System.Single width)
  System.Boolean get_isHeightDependantOnWidth()
  System.Void CalcMinMaxWidth(UnityEngine.GUIContent content, System.Single& minWidth, System.Single& maxWidth)
  System.String ToString()
  System.Void .cctor()
  System.Void get_contentOffset_Injected(UnityEngine.Vector2& ret)
  System.Void set_contentOffset_Injected(UnityEngine.Vector2& value)
  System.Void Internal_Draw_Injected(UnityEngine.Rect& screenRect, UnityEngine.GUIContent content, System.Boolean isHover, System.Boolean isActive, System.Boolean on, System.Boolean hasKeyboardFocus)
  System.Void Internal_Draw2_Injected(UnityEngine.Rect& position, UnityEngine.GUIContent content, System.Int32 controlID, System.Boolean on)
  System.Void Internal_GetCursorPixelPosition_Injected(UnityEngine.Rect& position, UnityEngine.GUIContent content, System.Int32 cursorStringIndex, UnityEngine.Vector2& ret)
  System.Int32 Internal_GetCursorStringIndex_Injected(UnityEngine.Rect& position, UnityEngine.GUIContent content, UnityEngine.Vector2& cursorPixelPosition)
  System.String Internal_GetSelectedRenderedText_Injected(UnityEngine.Rect& localPosition, UnityEngine.GUIContent mContent, System.Int32 selectIndex, System.Int32 cursorIndex)
  System.Void Internal_CalcSize_Injected(UnityEngine.GUIContent content, UnityEngine.Vector2& ret)
  System.Void Internal_CalcSizeWithConstraints_Injected(UnityEngine.GUIContent content, UnityEngine.Vector2& maxSize, UnityEngine.Vector2& ret)
  System.Void Internal_CalcMinMaxWidth_Injected(UnityEngine.GUIContent content, UnityEngine.Vector2& ret)
  System.Void SetMouseTooltip_Injected(System.String tooltip, UnityEngine.Rect& screenRect)
END_CLASS

CLASS: UnityEngine.ImagePosition
TYPE:  struct
TOKEN: 0x200001B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ImagePosition       ImageLeft  // 0x0
  public    static  UnityEngine.ImagePosition       ImageAbove  // 0x0
  public    static  UnityEngine.ImagePosition       ImageOnly  // 0x0
  public    static  UnityEngine.ImagePosition       TextOnly  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.TextClipping
TYPE:  struct
TOKEN: 0x200001C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextClipping        Overflow  // 0x0
  public    static  UnityEngine.TextClipping        Clip  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.GUITargetAttribute
TYPE:  class
TOKEN: 0x200001D
EXTENDS: Attribute
FIELDS:
  private           System.Int32                    displayMask  // 0x10
METHODS:
  System.Int32 GetGUITargetAttrValue(System.Type klass, System.String methodName)
END_CLASS

CLASS: UnityEngine.GUIUtility
TYPE:  class
TOKEN: 0x200001E
FIELDS:
  private   static  System.Int32                    s_ControlCount  // 0x0
  private   static  System.Int32                    s_SkinMode  // 0x4
  private   static  System.Int32                    s_OriginalID  // 0x8
  private   static  System.Action                   takeCapture  // 0x10
  private   static  System.Action                   releaseCapture  // 0x18
  private   static  System.Func<System.Int32,System.IntPtr,System.Boolean>processEvent  // 0x20
  private   static  System.Action                   cleanupRoots  // 0x28
  private   static  System.Func<System.Exception,System.Boolean>endContainerGUIFromException  // 0x30
  private   static  System.Action                   guiChanged  // 0x38
  private   static  System.Boolean                  <guiIsExiting>k__BackingField  // 0x40
  private   static  System.Func<System.Boolean>     s_HasCurrentWindowKeyFocusFunc  // 0x48
METHODS:
  System.Boolean get_hasModalWindow()
  System.Single get_pixelsPerPoint()
  System.Int32 get_guiDepth()
  UnityEngine.Vector2 get_s_EditorScreenPointOffset()
  System.Void set_s_EditorScreenPointOffset(UnityEngine.Vector2 value)
  System.Boolean get_mouseUsed()
  System.Void set_mouseUsed(System.Boolean value)
  System.Boolean get_textFieldInput()
  System.Void set_textFieldInput(System.Boolean value)
  System.Boolean get_manualTex2SRGBEnabled()
  System.Void set_manualTex2SRGBEnabled(System.Boolean value)
  System.String get_systemCopyBuffer()
  System.Void set_systemCopyBuffer(System.String value)
  System.Int32 Internal_GetControlID(System.Int32 hint, UnityEngine.FocusType focusType, UnityEngine.Rect rect)
  System.Int32 GetControlID(System.Int32 hint, UnityEngine.FocusType focusType, UnityEngine.Rect rect)
  System.Void BeginContainerFromOwner(UnityEngine.ScriptableObject owner)
  System.Void BeginContainer(UnityEngine.ObjectGUIState objectGUIState)
  System.Void Internal_EndContainer()
  System.Int32 GetPermanentControlID()
  System.Int32 CheckForTabEvent(UnityEngine.Event evt)
  System.Void SetKeyboardControlToFirstControlId()
  System.Void SetKeyboardControlToLastControlId()
  System.Boolean HasFocusableControls()
  System.Boolean OwnsId(System.Int32 id)
  UnityEngine.Rect AlignRectToDevice(UnityEngine.Rect rect, System.Int32& widthInPixels, System.Int32& heightInPixels)
  System.String get_compositionString()
  UnityEngine.IMECompositionMode get_imeCompositionMode()
  System.Void set_imeCompositionMode(UnityEngine.IMECompositionMode value)
  UnityEngine.Vector2 get_compositionCursorPos()
  System.Void set_compositionCursorPos(UnityEngine.Vector2 value)
  UnityEngine.Vector3 Internal_MultiplyPoint(UnityEngine.Vector3 point, UnityEngine.Matrix4x4 transform)
  System.Boolean GetChanged()
  System.Void SetChanged(System.Boolean changed)
  System.Void SetDidGUIWindowsEatLastEvent(System.Boolean value)
  System.Int32 Internal_GetHotControl()
  System.Int32 Internal_GetKeyboardControl()
  System.Void Internal_SetHotControl(System.Int32 value)
  System.Void Internal_SetKeyboardControl(System.Int32 value)
  System.Object Internal_GetDefaultSkin(System.Int32 skinMode)
  UnityEngine.Object Internal_GetBuiltinSkin(System.Int32 skin)
  System.Void Internal_ExitGUI()
  UnityEngine.Vector2 InternalWindowToScreenPoint(UnityEngine.Vector2 windowPoint)
  UnityEngine.Vector2 InternalScreenToWindowPoint(UnityEngine.Vector2 screenPoint)
  System.Void MarkGUIChanged()
  System.Int32 GetControlID(UnityEngine.FocusType focus)
  System.Int32 GetControlID(UnityEngine.GUIContent contents, UnityEngine.FocusType focus)
  System.Int32 GetControlID(UnityEngine.FocusType focus, UnityEngine.Rect position)
  System.Int32 GetControlID(UnityEngine.GUIContent contents, UnityEngine.FocusType focus, UnityEngine.Rect position)
  System.Int32 GetControlID(System.Int32 hint, UnityEngine.FocusType focus)
  System.Object GetStateObject(System.Type t, System.Int32 controlID)
  System.Object QueryStateObject(System.Type t, System.Int32 controlID)
  System.Boolean get_guiIsExiting()
  System.Void set_guiIsExiting(System.Boolean value)
  System.Int32 get_hotControl()
  System.Void set_hotControl(System.Int32 value)
  System.Void TakeCapture()
  System.Void RemoveCapture()
  System.Int32 get_keyboardControl()
  System.Void set_keyboardControl(System.Int32 value)
  System.Boolean HasKeyFocus(System.Int32 controlID)
  System.Void ExitGUI()
  UnityEngine.GUISkin GetDefaultSkin(System.Int32 skinMode)
  UnityEngine.GUISkin GetDefaultSkin()
  UnityEngine.GUISkin GetBuiltinSkin(System.Int32 skin)
  System.Void ProcessEvent(System.Int32 instanceID, System.IntPtr nativeEventPtr, System.Boolean& result)
  System.Void EndContainer()
  System.Void CleanupRoots()
  System.Void BeginGUI(System.Int32 skinMode, System.Int32 instanceID, System.Int32 useGUILayout)
  System.Void EndGUI(System.Int32 layoutType)
  System.Boolean EndGUIFromException(System.Exception exception)
  System.Boolean EndContainerGUIFromException(System.Exception exception)
  System.Void ResetGlobalState()
  System.Boolean IsExitGUIException(System.Exception exception)
  System.Boolean ShouldRethrowException(System.Exception exception)
  System.Void CheckOnGUI()
  System.Single RoundToPixelGrid(System.Single v)
  UnityEngine.Vector2 GUIToScreenPoint(UnityEngine.Vector2 guiPoint)
  UnityEngine.Rect GUIToScreenRect(UnityEngine.Rect guiRect)
  UnityEngine.Vector2 ScreenToGUIPoint(UnityEngine.Vector2 screenPoint)
  UnityEngine.Rect ScreenToGUIRect(UnityEngine.Rect screenRect)
  System.Void RotateAroundPivot(System.Single angle, UnityEngine.Vector2 pivotPoint)
  System.Void ScaleAroundPivot(UnityEngine.Vector2 scale, UnityEngine.Vector2 pivotPoint)
  UnityEngine.Rect AlignRectToDevice(UnityEngine.Rect rect)
  System.Boolean HitTest(UnityEngine.Rect rect, UnityEngine.Vector2 point, System.Int32 offset)
  System.Boolean HitTest(UnityEngine.Rect rect, UnityEngine.Vector2 point, System.Boolean isDirectManipulationDevice)
  System.Boolean HitTest(UnityEngine.Rect rect, UnityEngine.Event evt)
  System.Void .ctor()
  System.Void get_s_EditorScreenPointOffset_Injected(UnityEngine.Vector2& ret)
  System.Void set_s_EditorScreenPointOffset_Injected(UnityEngine.Vector2& value)
  System.Int32 Internal_GetControlID_Injected(System.Int32 hint, UnityEngine.FocusType focusType, UnityEngine.Rect& rect)
  System.Void AlignRectToDevice_Injected(UnityEngine.Rect& rect, System.Int32& widthInPixels, System.Int32& heightInPixels, UnityEngine.Rect& ret)
  System.Void get_compositionCursorPos_Injected(UnityEngine.Vector2& ret)
  System.Void set_compositionCursorPos_Injected(UnityEngine.Vector2& value)
  System.Void Internal_MultiplyPoint_Injected(UnityEngine.Vector3& point, UnityEngine.Matrix4x4& transform, UnityEngine.Vector3& ret)
  System.Void InternalWindowToScreenPoint_Injected(UnityEngine.Vector2& windowPoint, UnityEngine.Vector2& ret)
  System.Void InternalScreenToWindowPoint_Injected(UnityEngine.Vector2& screenPoint, UnityEngine.Vector2& ret)
END_CLASS

CLASS: UnityEngine.ExitGUIException
TYPE:  class
TOKEN: 0x200001F
EXTENDS: Exception
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String message)
END_CLASS

CLASS: UnityEngine.GUILayoutEntry
TYPE:  class
TOKEN: 0x2000020
FIELDS:
  public            System.Single                   minWidth  // 0x10
  public            System.Single                   maxWidth  // 0x14
  public            System.Single                   minHeight  // 0x18
  public            System.Single                   maxHeight  // 0x1C
  public            UnityEngine.Rect                rect  // 0x20
  public            System.Int32                    stretchWidth  // 0x30
  public            System.Int32                    stretchHeight  // 0x34
  public            System.Boolean                  consideredForMargin  // 0x38
  private           UnityEngine.GUIStyle            m_Style  // 0x40
  private   static  UnityEngine.Rect                kDummyRect  // 0x0
  protected static  System.Int32                    indent  // 0x10
METHODS:
  UnityEngine.GUIStyle get_style()
  System.Void set_style(UnityEngine.GUIStyle value)
  System.Int32 get_marginLeft()
  System.Int32 get_marginRight()
  System.Int32 get_marginTop()
  System.Int32 get_marginBottom()
  System.Int32 get_marginHorizontal()
  System.Int32 get_marginVertical()
  System.Void .ctor(System.Single _minWidth, System.Single _maxWidth, System.Single _minHeight, System.Single _maxHeight, UnityEngine.GUIStyle _style)
  System.Void .ctor(System.Single _minWidth, System.Single _maxWidth, System.Single _minHeight, System.Single _maxHeight, UnityEngine.GUIStyle _style, UnityEngine.GUILayoutOption[] options)
  System.Void CalcWidth()
  System.Void CalcHeight()
  System.Void SetHorizontal(System.Single x, System.Single width)
  System.Void SetVertical(System.Single y, System.Single height)
  System.Void ApplyStyleSettings(UnityEngine.GUIStyle style)
  System.Void ApplyOptions(UnityEngine.GUILayoutOption[] options)
  System.String ToString()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.GUIWordWrapSizer
TYPE:  class
TOKEN: 0x2000021
EXTENDS: GUILayoutEntry
FIELDS:
  private   readonly UnityEngine.GUIContent          m_Content  // 0x48
  private   readonly System.Single                   m_ForcedMinHeight  // 0x50
  private   readonly System.Single                   m_ForcedMaxHeight  // 0x54
METHODS:
  System.Void .ctor(UnityEngine.GUIStyle style, UnityEngine.GUIContent content, UnityEngine.GUILayoutOption[] options)
  System.Void CalcWidth()
  System.Void CalcHeight()
END_CLASS

CLASS: UnityEngine.GUILayoutGroup
TYPE:  class
TOKEN: 0x2000022
EXTENDS: GUILayoutEntry
FIELDS:
  public            System.Collections.Generic.List<UnityEngine.GUILayoutEntry>entries  // 0x48
  public            System.Boolean                  isVertical  // 0x50
  public            System.Boolean                  resetCoords  // 0x51
  public            System.Single                   spacing  // 0x54
  public            System.Boolean                  sameSize  // 0x58
  public            System.Boolean                  isWindow  // 0x59
  public            System.Int32                    windowID  // 0x5C
  private           System.Int32                    m_Cursor  // 0x60
  protected         System.Int32                    m_StretchableCountX  // 0x64
  protected         System.Int32                    m_StretchableCountY  // 0x68
  protected         System.Boolean                  m_UserSpecifiedWidth  // 0x6C
  protected         System.Boolean                  m_UserSpecifiedHeight  // 0x6D
  protected         System.Single                   m_ChildMinWidth  // 0x70
  protected         System.Single                   m_ChildMaxWidth  // 0x74
  protected         System.Single                   m_ChildMinHeight  // 0x78
  protected         System.Single                   m_ChildMaxHeight  // 0x7C
  protected         System.Int32                    m_MarginLeft  // 0x80
  protected         System.Int32                    m_MarginRight  // 0x84
  protected         System.Int32                    m_MarginTop  // 0x88
  protected         System.Int32                    m_MarginBottom  // 0x8C
  private   static readonly UnityEngine.GUILayoutEntry      none  // 0x0
METHODS:
  System.Int32 get_marginLeft()
  System.Int32 get_marginRight()
  System.Int32 get_marginTop()
  System.Int32 get_marginBottom()
  System.Void .ctor()
  System.Void ApplyOptions(UnityEngine.GUILayoutOption[] options)
  System.Void ApplyStyleSettings(UnityEngine.GUIStyle style)
  System.Void ResetCursor()
  UnityEngine.GUILayoutEntry GetNext()
  UnityEngine.Rect GetLast()
  System.Void Add(UnityEngine.GUILayoutEntry e)
  System.Void CalcWidth()
  System.Void SetHorizontal(System.Single x, System.Single width)
  System.Void CalcHeight()
  System.Void SetVertical(System.Single y, System.Single height)
  System.String ToString()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.GUIScrollGroup
TYPE:  class
TOKEN: 0x2000023
EXTENDS: GUILayoutGroup
FIELDS:
  public            System.Single                   calcMinWidth  // 0x90
  public            System.Single                   calcMaxWidth  // 0x94
  public            System.Single                   calcMinHeight  // 0x98
  public            System.Single                   calcMaxHeight  // 0x9C
  public            System.Single                   clientWidth  // 0xA0
  public            System.Single                   clientHeight  // 0xA4
  public            System.Boolean                  allowHorizontalScroll  // 0xA8
  public            System.Boolean                  allowVerticalScroll  // 0xA9
  public            System.Boolean                  needsHorizontalScrollbar  // 0xAA
  public            System.Boolean                  needsVerticalScrollbar  // 0xAB
  public            UnityEngine.GUIStyle            horizontalScrollbar  // 0xB0
  public            UnityEngine.GUIStyle            verticalScrollbar  // 0xB8
METHODS:
  System.Void .ctor()
  System.Void CalcWidth()
  System.Void SetHorizontal(System.Single x, System.Single width)
  System.Void CalcHeight()
  System.Void SetVertical(System.Single y, System.Single height)
END_CLASS

CLASS: UnityEngine.ObjectGUIState
TYPE:  class
TOKEN: 0x2000024
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
METHODS:
  System.Void .ctor()
  System.Void Dispose()
  System.Void Finalize()
  System.Void Destroy()
  System.IntPtr Internal_Create()
  System.Void Internal_Destroy(System.IntPtr ptr)
END_CLASS

CLASS: UnityEngine.ScrollViewState
TYPE:  class
TOKEN: 0x2000025
FIELDS:
  public            UnityEngine.Rect                position  // 0x10
  public            UnityEngine.Rect                visibleRect  // 0x20
  public            UnityEngine.Rect                viewRect  // 0x30
  public            UnityEngine.Vector2             scrollPosition  // 0x40
  public            System.Boolean                  apply  // 0x48
  public            System.Boolean                  isDuringTouchScroll  // 0x49
  public            UnityEngine.Vector2             touchScrollStartMousePosition  // 0x4C
  public            UnityEngine.Vector2             touchScrollStartPosition  // 0x54
  public            UnityEngine.Vector2             velocity  // 0x5C
  public            System.Single                   previousTimeSinceStartup  // 0x64
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.SliderState
TYPE:  class
TOKEN: 0x2000026
FIELDS:
  public            System.Single                   dragStartPos  // 0x10
  public            System.Single                   dragStartValue  // 0x14
  public            System.Boolean                  isDragging  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.SliderHandler
TYPE:  struct
TOKEN: 0x2000027
FIELDS:
  private   readonly UnityEngine.Rect                position  // 0x10
  private   readonly System.Single                   currentValue  // 0x20
  private   readonly System.Single                   size  // 0x24
  private   readonly System.Single                   start  // 0x28
  private   readonly System.Single                   end  // 0x2C
  private   readonly UnityEngine.GUIStyle            slider  // 0x30
  private   readonly UnityEngine.GUIStyle            thumb  // 0x38
  private   readonly UnityEngine.GUIStyle            thumbExtent  // 0x40
  private   readonly System.Boolean                  horiz  // 0x48
  private   readonly System.Int32                    id  // 0x4C
METHODS:
  System.Void .ctor(UnityEngine.Rect position, System.Single currentValue, System.Single size, System.Single start, System.Single end, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, System.Boolean horiz, System.Int32 id, UnityEngine.GUIStyle thumbExtent)
  System.Single Handle()
  System.Single OnMouseDown()
  System.Single OnMouseDrag()
  System.Single OnMouseUp()
  System.Single OnRepaint()
  UnityEngine.EventType CurrentEventType()
  System.Int32 CurrentScrollTroughSide()
  System.Boolean IsEmptySlider()
  System.Boolean SupportsPageMovements()
  System.Single PageMovementValue()
  System.Single PageUpMovementBound()
  UnityEngine.Event CurrentEvent()
  System.Single ValueForCurrentMousePosition()
  System.Single Clamp(System.Single value)
  UnityEngine.Rect ThumbSelectionRect()
  System.Void StartDraggingWithValue(System.Single dragStartValue)
  UnityEngine.SliderState SliderState()
  UnityEngine.Rect ThumbExtRect()
  UnityEngine.Rect ThumbRect()
  UnityEngine.Rect VerticalThumbRect()
  UnityEngine.Rect HorizontalThumbRect()
  System.Single ClampedCurrentValue()
  System.Single MousePosition()
  System.Single ValuesPerPixel()
  System.Single ThumbSize()
  System.Single MaxValue()
  System.Single MinValue()
END_CLASS

CLASS: UnityEngine.TextEditor
TYPE:  class
TOKEN: 0x2000028
FIELDS:
  public            UnityEngine.TouchScreenKeyboard keyboardOnScreen  // 0x10
  public            System.Int32                    controlID  // 0x18
  public            UnityEngine.GUIStyle            style  // 0x20
  public            System.Boolean                  multiline  // 0x28
  public            System.Boolean                  hasHorizontalCursorPos  // 0x29
  public            System.Boolean                  isPasswordField  // 0x2A
  private           System.Boolean                  m_HasFocus  // 0x2B
  public            UnityEngine.Vector2             scrollOffset  // 0x2C
  private           UnityEngine.GUIContent          m_Content  // 0x38
  private           UnityEngine.Rect                m_Position  // 0x40
  private           System.Int32                    m_CursorIndex  // 0x50
  private           System.Int32                    m_SelectIndex  // 0x54
  private           System.Boolean                  m_RevealCursor  // 0x58
  public            UnityEngine.Vector2             graphicalCursorPos  // 0x5C
  public            UnityEngine.Vector2             graphicalSelectCursorPos  // 0x64
  private           System.Boolean                  m_MouseDragSelectsWholeWords  // 0x6C
  private           System.Int32                    m_DblClickInitPos  // 0x70
  private           UnityEngine.TextEditor.DblClickSnappingm_DblClickSnap  // 0x74
  private           System.Boolean                  m_bJustSelected  // 0x75
  private           System.Int32                    m_iAltCursorPos  // 0x78
  private           System.String                   oldText  // 0x80
  private           System.Int32                    oldPos  // 0x88
  private           System.Int32                    oldSelectPos  // 0x8C
  private   static  System.Collections.Generic.Dictionary<UnityEngine.Event,UnityEngine.TextEditor.TextEditOp>s_Keyactions  // 0x0
METHODS:
  System.String get_text()
  System.Void set_text(System.String value)
  UnityEngine.Rect get_position()
  System.Void set_position(UnityEngine.Rect value)
  UnityEngine.Rect get_localPosition()
  System.Int32 get_cursorIndex()
  System.Void set_cursorIndex(System.Int32 value)
  System.Int32 get_selectIndex()
  System.Void set_selectIndex(System.Int32 value)
  System.Void ClearCursorPos()
  System.Int32 get_altCursorPosition()
  System.Void .ctor()
  System.Void OnFocus()
  System.Void OnLostFocus()
  System.Void GrabGraphicalCursorPos()
  System.Boolean HandleKeyEvent(UnityEngine.Event e, System.Boolean textIsReadOnly)
  System.Boolean DeleteLineBack()
  System.Boolean DeleteWordBack()
  System.Boolean DeleteWordForward()
  System.Boolean Delete()
  System.Boolean CanPaste()
  System.Boolean Backspace()
  System.Void SelectAll()
  System.Void SelectNone()
  System.Boolean get_hasSelection()
  System.String get_SelectedText()
  System.Boolean DeleteSelection()
  System.Void ReplaceSelection(System.String replace)
  System.Void Insert(System.Char c)
  System.Void MoveSelectionToAltCursor()
  System.Void MoveRight()
  System.Void MoveLeft()
  System.Void MoveUp()
  System.Void MoveDown()
  System.Void MoveLineStart()
  System.Void MoveLineEnd()
  System.Void MoveGraphicalLineStart()
  System.Void MoveGraphicalLineEnd()
  System.Void MoveTextStart()
  System.Void MoveTextEnd()
  System.Int32 IndexOfEndOfLine(System.Int32 startIndex)
  System.Void MoveParagraphForward()
  System.Void MoveParagraphBackward()
  System.Void MoveCursorToPosition_Internal(UnityEngine.Vector2 cursorPosition, System.Boolean shift)
  System.Void MoveAltCursorToPosition(UnityEngine.Vector2 cursorPosition)
  System.Void SelectToPosition(UnityEngine.Vector2 cursorPosition)
  System.Void SelectLeft()
  System.Void SelectRight()
  System.Void SelectUp()
  System.Void SelectDown()
  System.Void SelectTextEnd()
  System.Void SelectTextStart()
  System.Void MouseDragSelectsWholeWords(System.Boolean on)
  System.Void DblClickSnap(UnityEngine.TextEditor.DblClickSnapping snapping)
  System.Int32 GetGraphicalLineStart(System.Int32 p)
  System.Int32 GetGraphicalLineEnd(System.Int32 p)
  System.Int32 FindNextSeperator(System.Int32 startPos)
  System.Int32 FindPrevSeperator(System.Int32 startPos)
  System.Void MoveWordRight()
  System.Void MoveToStartOfNextWord()
  System.Void MoveToEndOfPreviousWord()
  System.Void SelectToStartOfNextWord()
  System.Void SelectToEndOfPreviousWord()
  UnityEngine.TextEditor.CharacterType ClassifyChar(System.Int32 index)
  System.Int32 FindStartOfNextWord(System.Int32 p)
  System.Int32 FindEndOfPreviousWord(System.Int32 p)
  System.Void MoveWordLeft()
  System.Void SelectWordRight()
  System.Void SelectWordLeft()
  System.Void ExpandSelectGraphicalLineStart()
  System.Void ExpandSelectGraphicalLineEnd()
  System.Void SelectGraphicalLineStart()
  System.Void SelectGraphicalLineEnd()
  System.Void SelectParagraphForward()
  System.Void SelectParagraphBackward()
  System.Void SelectCurrentWord()
  System.Int32 FindEndOfClassification(System.Int32 p, UnityEngine.TextEditor.Direction dir)
  System.Void SelectCurrentParagraph()
  System.Void UpdateScrollOffset()
  System.Boolean PerformOperation(UnityEngine.TextEditor.TextEditOp operation, System.Boolean textIsReadOnly)
  System.Void SaveBackup()
  System.Boolean Cut()
  System.Void Copy()
  System.String ReplaceNewlinesWithSpaces(System.String value)
  System.Boolean Paste()
  System.Void MapKey(System.String key, UnityEngine.TextEditor.TextEditOp action)
  System.Void InitKeyActions()
  System.Void DetectFocusChange()
  System.Void OnDetectFocusChange()
  System.Void OnCursorIndexChange()
  System.Void OnSelectIndexChange()
  System.Void ClampTextIndex(System.Int32& index)
  System.Void EnsureValidCodePointIndex(System.Int32& index)
  System.Boolean IsValidCodePointIndex(System.Int32 index)
  System.Int32 PreviousCodePointIndex(System.Int32 index)
  System.Int32 NextCodePointIndex(System.Int32 index)
END_CLASS

