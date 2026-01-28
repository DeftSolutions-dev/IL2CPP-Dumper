// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.UI.dll
// Classes:  229
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: ButtonClickedEvent
TYPE:  class
TOKEN: 0x2000006
EXTENDS: UnityEvent
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: IFactoryControls
TYPE:  interface
TOKEN: 0x2000012
FIELDS:
METHODS:
  UnityEngine.GameObject CreateGameObject(System.String name, System.Type[] components)
END_CLASS

CLASS: DefaultRuntimeFactory
TYPE:  class
TOKEN: 0x2000013
FIELDS:
  public    static  UnityEngine.UI.DefaultControls.IFactoryControlsDefault  // 0x0
METHODS:
  UnityEngine.GameObject CreateGameObject(System.String name, System.Type[] components)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Resources
TYPE:  struct
TOKEN: 0x2000014
FIELDS:
  public            UnityEngine.Sprite              standard  // 0x10
  public            UnityEngine.Sprite              background  // 0x18
  public            UnityEngine.Sprite              inputField  // 0x20
  public            UnityEngine.Sprite              knob  // 0x28
  public            UnityEngine.Sprite              checkmark  // 0x30
  public            UnityEngine.Sprite              dropdown  // 0x38
  public            UnityEngine.Sprite              mask  // 0x40
METHODS:
END_CLASS

CLASS: DropdownItem
TYPE:  class
TOKEN: 0x2000016
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.UI.Text             m_Text  // 0x18
  private           UnityEngine.UI.Image            m_Image  // 0x20
  private           UnityEngine.RectTransform       m_RectTransform  // 0x28
  private           UnityEngine.UI.Toggle           m_Toggle  // 0x30
METHODS:
  UnityEngine.UI.Text get_text()
  System.Void set_text(UnityEngine.UI.Text value)
  UnityEngine.UI.Image get_image()
  System.Void set_image(UnityEngine.UI.Image value)
  UnityEngine.RectTransform get_rectTransform()
  System.Void set_rectTransform(UnityEngine.RectTransform value)
  UnityEngine.UI.Toggle get_toggle()
  System.Void set_toggle(UnityEngine.UI.Toggle value)
  System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnCancel(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void .ctor()
END_CLASS

CLASS: OptionData
TYPE:  class
TOKEN: 0x2000017
FIELDS:
  private           System.String                   m_Text  // 0x10
  private           UnityEngine.Sprite              m_Image  // 0x18
METHODS:
  System.String get_text()
  System.Void set_text(System.String value)
  UnityEngine.Sprite get_image()
  System.Void set_image(UnityEngine.Sprite value)
  System.Void .ctor()
  System.Void .ctor(System.String text)
  System.Void .ctor(UnityEngine.Sprite image)
  System.Void .ctor(System.String text, UnityEngine.Sprite image)
END_CLASS

CLASS: OptionDataList
TYPE:  class
TOKEN: 0x2000018
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData>m_Options  // 0x10
METHODS:
  System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> get_options()
  System.Void set_options(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> value)
  System.Void .ctor()
END_CLASS

CLASS: DropdownEvent
TYPE:  class
TOKEN: 0x2000019
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: BlockingObjects
TYPE:  struct
TOKEN: 0x2000020
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.GraphicRaycaster.BlockingObjectsNone  // 0x0
  public    static  UnityEngine.UI.GraphicRaycaster.BlockingObjectsTwoD  // 0x0
  public    static  UnityEngine.UI.GraphicRaycaster.BlockingObjectsThreeD  // 0x0
  public    static  UnityEngine.UI.GraphicRaycaster.BlockingObjectsAll  // 0x0
METHODS:
END_CLASS

CLASS: Type
TYPE:  struct
TOKEN: 0x2000025
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.Image.Type       Simple  // 0x0
  public    static  UnityEngine.UI.Image.Type       Sliced  // 0x0
  public    static  UnityEngine.UI.Image.Type       Tiled  // 0x0
  public    static  UnityEngine.UI.Image.Type       Filled  // 0x0
  public    static  UnityEngine.UI.Image.Type       Mirror  // 0x0
  public    static  UnityEngine.UI.Image.Type       Quarter  // 0x0
METHODS:
END_CLASS

CLASS: FillMethod
TYPE:  struct
TOKEN: 0x2000026
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.Image.FillMethod Horizontal  // 0x0
  public    static  UnityEngine.UI.Image.FillMethod Vertical  // 0x0
  public    static  UnityEngine.UI.Image.FillMethod Radial90  // 0x0
  public    static  UnityEngine.UI.Image.FillMethod Radial180  // 0x0
  public    static  UnityEngine.UI.Image.FillMethod Radial360  // 0x0
METHODS:
END_CLASS

CLASS: OriginHorizontal
TYPE:  struct
TOKEN: 0x2000027
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.Image.OriginHorizontalLeft  // 0x0
  public    static  UnityEngine.UI.Image.OriginHorizontalRight  // 0x0
METHODS:
END_CLASS

CLASS: OriginVertical
TYPE:  struct
TOKEN: 0x2000028
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.Image.OriginVerticalBottom  // 0x0
  public    static  UnityEngine.UI.Image.OriginVerticalTop  // 0x0
METHODS:
END_CLASS

CLASS: Origin90
TYPE:  struct
TOKEN: 0x2000029
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.Image.Origin90   BottomLeft  // 0x0
  public    static  UnityEngine.UI.Image.Origin90   TopLeft  // 0x0
  public    static  UnityEngine.UI.Image.Origin90   TopRight  // 0x0
  public    static  UnityEngine.UI.Image.Origin90   BottomRight  // 0x0
METHODS:
END_CLASS

CLASS: Origin180
TYPE:  struct
TOKEN: 0x200002A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.Image.Origin180  Bottom  // 0x0
  public    static  UnityEngine.UI.Image.Origin180  Left  // 0x0
  public    static  UnityEngine.UI.Image.Origin180  Top  // 0x0
  public    static  UnityEngine.UI.Image.Origin180  Right  // 0x0
METHODS:
END_CLASS

CLASS: Origin360
TYPE:  struct
TOKEN: 0x200002B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.Image.Origin360  Bottom  // 0x0
  public    static  UnityEngine.UI.Image.Origin360  Right  // 0x0
  public    static  UnityEngine.UI.Image.Origin360  Top  // 0x0
  public    static  UnityEngine.UI.Image.Origin360  Left  // 0x0
METHODS:
END_CLASS

CLASS: SlicedSpriteParams
TYPE:  struct
TOKEN: 0x200002C
FIELDS:
  public            System.Boolean                  slicedParamNeedUpdate  // 0x10
  public            UnityEngine.Vector2             inner_PosMin  // 0x14
  public            UnityEngine.Vector2             inner_PosMax  // 0x1C
  public            UnityEngine.Vector2             inner_UVMin  // 0x24
  public            UnityEngine.Vector2             inner_UVMax  // 0x2C
METHODS:
  System.Void .ctor(System.Boolean slicedParamNeedUpdate, UnityEngine.Vector2 inner_PosMin, UnityEngine.Vector2 inner_PosMax, UnityEngine.Vector2 inner_UVMin, UnityEngine.Vector2 inner_UVMax)
END_CLASS

CLASS: EDynamicAtlasActiveMode
TYPE:  struct
TOKEN: 0x200002D
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  UnityEngine.UI.Image.EDynamicAtlasActiveModeActiveOnAwake  // 0x0
  public    static  UnityEngine.UI.Image.EDynamicAtlasActiveModeActiveOnEnable  // 0x0
METHODS:
END_CLASS

CLASS: ContentType
TYPE:  struct
TOKEN: 0x2000031
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.InputField.ContentTypeStandard  // 0x0
  public    static  UnityEngine.UI.InputField.ContentTypeAutocorrected  // 0x0
  public    static  UnityEngine.UI.InputField.ContentTypeIntegerNumber  // 0x0
  public    static  UnityEngine.UI.InputField.ContentTypeDecimalNumber  // 0x0
  public    static  UnityEngine.UI.InputField.ContentTypeAlphanumeric  // 0x0
  public    static  UnityEngine.UI.InputField.ContentTypeName  // 0x0
  public    static  UnityEngine.UI.InputField.ContentTypeEmailAddress  // 0x0
  public    static  UnityEngine.UI.InputField.ContentTypePassword  // 0x0
  public    static  UnityEngine.UI.InputField.ContentTypePin  // 0x0
  public    static  UnityEngine.UI.InputField.ContentTypeCustom  // 0x0
METHODS:
END_CLASS

CLASS: InputType
TYPE:  struct
TOKEN: 0x2000032
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.InputField.InputTypeStandard  // 0x0
  public    static  UnityEngine.UI.InputField.InputTypeAutoCorrect  // 0x0
  public    static  UnityEngine.UI.InputField.InputTypePassword  // 0x0
METHODS:
END_CLASS

CLASS: CharacterValidation
TYPE:  struct
TOKEN: 0x2000033
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.InputField.CharacterValidationNone  // 0x0
  public    static  UnityEngine.UI.InputField.CharacterValidationInteger  // 0x0
  public    static  UnityEngine.UI.InputField.CharacterValidationDecimal  // 0x0
  public    static  UnityEngine.UI.InputField.CharacterValidationAlphanumeric  // 0x0
  public    static  UnityEngine.UI.InputField.CharacterValidationName  // 0x0
  public    static  UnityEngine.UI.InputField.CharacterValidationEmailAddress  // 0x0
METHODS:
END_CLASS

CLASS: LineType
TYPE:  struct
TOKEN: 0x2000034
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.InputField.LineTypeSingleLine  // 0x0
  public    static  UnityEngine.UI.InputField.LineTypeMultiLineSubmit  // 0x0
  public    static  UnityEngine.UI.InputField.LineTypeMultiLineNewline  // 0x0
METHODS:
END_CLASS

CLASS: OnValidateInput
TYPE:  class
TOKEN: 0x2000035
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Char Invoke(System.String text, System.Int32 charIndex, System.Char addedChar)
  System.IAsyncResult BeginInvoke(System.String text, System.Int32 charIndex, System.Char addedChar, System.AsyncCallback callback, System.Object object)
  System.Char EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: SubmitEvent
TYPE:  class
TOKEN: 0x2000036
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: EndEditEvent
TYPE:  class
TOKEN: 0x2000037
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: OnChangeEvent
TYPE:  class
TOKEN: 0x2000038
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: EditState
TYPE:  struct
TOKEN: 0x2000039
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.InputField.EditStateContinue  // 0x0
  public    static  UnityEngine.UI.InputField.EditStateFinish  // 0x0
METHODS:
END_CLASS

CLASS: AspectMode
TYPE:  struct
TOKEN: 0x200003D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.AspectRatioFitter.AspectModeNone  // 0x0
  public    static  UnityEngine.UI.AspectRatioFitter.AspectModeWidthControlsHeight  // 0x0
  public    static  UnityEngine.UI.AspectRatioFitter.AspectModeHeightControlsWidth  // 0x0
  public    static  UnityEngine.UI.AspectRatioFitter.AspectModeFitInParent  // 0x0
  public    static  UnityEngine.UI.AspectRatioFitter.AspectModeEnvelopeParent  // 0x0
METHODS:
END_CLASS

CLASS: ScaleMode
TYPE:  struct
TOKEN: 0x200003F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.CanvasScaler.ScaleModeConstantPixelSize  // 0x0
  public    static  UnityEngine.UI.CanvasScaler.ScaleModeScaleWithScreenSize  // 0x0
  public    static  UnityEngine.UI.CanvasScaler.ScaleModeConstantPhysicalSize  // 0x0
METHODS:
END_CLASS

CLASS: ScreenMatchMode
TYPE:  struct
TOKEN: 0x2000040
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.CanvasScaler.ScreenMatchModeMatchWidthOrHeight  // 0x0
  public    static  UnityEngine.UI.CanvasScaler.ScreenMatchModeExpand  // 0x0
  public    static  UnityEngine.UI.CanvasScaler.ScreenMatchModeShrink  // 0x0
METHODS:
END_CLASS

CLASS: Unit
TYPE:  struct
TOKEN: 0x2000041
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.CanvasScaler.UnitCentimeters  // 0x0
  public    static  UnityEngine.UI.CanvasScaler.UnitMillimeters  // 0x0
  public    static  UnityEngine.UI.CanvasScaler.UnitInches  // 0x0
  public    static  UnityEngine.UI.CanvasScaler.UnitPoints  // 0x0
  public    static  UnityEngine.UI.CanvasScaler.UnitPicas  // 0x0
METHODS:
END_CLASS

CLASS: FitMode
TYPE:  struct
TOKEN: 0x2000043
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.ContentSizeFitter.FitModeUnconstrained  // 0x0
  public    static  UnityEngine.UI.ContentSizeFitter.FitModeMinSize  // 0x0
  public    static  UnityEngine.UI.ContentSizeFitter.FitModePreferredSize  // 0x0
METHODS:
END_CLASS

CLASS: Corner
TYPE:  struct
TOKEN: 0x2000045
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.GridLayoutGroup.CornerUpperLeft  // 0x0
  public    static  UnityEngine.UI.GridLayoutGroup.CornerUpperRight  // 0x0
  public    static  UnityEngine.UI.GridLayoutGroup.CornerLowerLeft  // 0x0
  public    static  UnityEngine.UI.GridLayoutGroup.CornerLowerRight  // 0x0
METHODS:
END_CLASS

CLASS: Axis
TYPE:  struct
TOKEN: 0x2000046
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.GridLayoutGroup.AxisHorizontal  // 0x0
  public    static  UnityEngine.UI.GridLayoutGroup.AxisVertical  // 0x0
METHODS:
END_CLASS

CLASS: Constraint
TYPE:  struct
TOKEN: 0x2000047
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.GridLayoutGroup.ConstraintFlexible  // 0x0
  public    static  UnityEngine.UI.GridLayoutGroup.ConstraintFixedColumnCount  // 0x0
  public    static  UnityEngine.UI.GridLayoutGroup.ConstraintFixedRowCount  // 0x0
METHODS:
END_CLASS

CLASS: CullStateChangedEvent
TYPE:  class
TOKEN: 0x2000059
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Mode
TYPE:  struct
TOKEN: 0x200005F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.Navigation.Mode  None  // 0x0
  public    static  UnityEngine.UI.Navigation.Mode  Horizontal  // 0x0
  public    static  UnityEngine.UI.Navigation.Mode  Vertical  // 0x0
  public    static  UnityEngine.UI.Navigation.Mode  Automatic  // 0x0
  public    static  UnityEngine.UI.Navigation.Mode  Explicit  // 0x0
METHODS:
END_CLASS

CLASS: Direction
TYPE:  struct
TOKEN: 0x2000063
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.Scrollbar.DirectionLeftToRight  // 0x0
  public    static  UnityEngine.UI.Scrollbar.DirectionRightToLeft  // 0x0
  public    static  UnityEngine.UI.Scrollbar.DirectionBottomToTop  // 0x0
  public    static  UnityEngine.UI.Scrollbar.DirectionTopToBottom  // 0x0
METHODS:
END_CLASS

CLASS: ScrollEvent
TYPE:  class
TOKEN: 0x2000064
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Axis
TYPE:  struct
TOKEN: 0x2000065
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.Scrollbar.Axis   Horizontal  // 0x0
  public    static  UnityEngine.UI.Scrollbar.Axis   Vertical  // 0x0
METHODS:
END_CLASS

CLASS: MovementType
TYPE:  struct
TOKEN: 0x2000068
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.ScrollRect.MovementTypeUnrestricted  // 0x0
  public    static  UnityEngine.UI.ScrollRect.MovementTypeElastic  // 0x0
  public    static  UnityEngine.UI.ScrollRect.MovementTypeClamped  // 0x0
METHODS:
END_CLASS

CLASS: ScrollbarVisibility
TYPE:  struct
TOKEN: 0x2000069
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.ScrollRect.ScrollbarVisibilityPermanent  // 0x0
  public    static  UnityEngine.UI.ScrollRect.ScrollbarVisibilityAutoHide  // 0x0
  public    static  UnityEngine.UI.ScrollRect.ScrollbarVisibilityAutoHideAndExpandViewport  // 0x0
METHODS:
END_CLASS

CLASS: ScrollRectEvent
TYPE:  class
TOKEN: 0x200006A
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Transition
TYPE:  struct
TOKEN: 0x200006C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.Selectable.TransitionNone  // 0x0
  public    static  UnityEngine.UI.Selectable.TransitionColorTint  // 0x0
  public    static  UnityEngine.UI.Selectable.TransitionSpriteSwap  // 0x0
  public    static  UnityEngine.UI.Selectable.TransitionAnimation  // 0x0
METHODS:
END_CLASS

CLASS: SelectionState
TYPE:  struct
TOKEN: 0x200006D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.Selectable.SelectionStateNormal  // 0x0
  public    static  UnityEngine.UI.Selectable.SelectionStateHighlighted  // 0x0
  public    static  UnityEngine.UI.Selectable.SelectionStatePressed  // 0x0
  public    static  UnityEngine.UI.Selectable.SelectionStateSelected  // 0x0
  public    static  UnityEngine.UI.Selectable.SelectionStateDisabled  // 0x0
METHODS:
END_CLASS

CLASS: Direction
TYPE:  struct
TOKEN: 0x2000074
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.Slider.Direction LeftToRight  // 0x0
  public    static  UnityEngine.UI.Slider.Direction RightToLeft  // 0x0
  public    static  UnityEngine.UI.Slider.Direction BottomToTop  // 0x0
  public    static  UnityEngine.UI.Slider.Direction TopToBottom  // 0x0
METHODS:
END_CLASS

CLASS: SliderEvent
TYPE:  class
TOKEN: 0x2000075
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Axis
TYPE:  struct
TOKEN: 0x2000076
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.Slider.Axis      Horizontal  // 0x0
  public    static  UnityEngine.UI.Slider.Axis      Vertical  // 0x0
METHODS:
END_CLASS

CLASS: MatEntry
TYPE:  class
TOKEN: 0x2000079
FIELDS:
  public            UnityEngine.Material            baseMat  // 0x10
  public            UnityEngine.Material            customMat  // 0x18
  public            System.Int32                    count  // 0x20
  public            System.Int32                    stencilId  // 0x24
  public            UnityEngine.Rendering.StencilOp operation  // 0x28
  public            UnityEngine.Rendering.CompareFunctioncompareFunction  // 0x2C
  public            System.Int32                    readMask  // 0x30
  public            System.Int32                    writeMask  // 0x34
  public            System.Boolean                  useAlphaClip  // 0x38
  public            UnityEngine.Rendering.ColorWriteMaskcolorMask  // 0x3C
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ToggleTransition
TYPE:  struct
TOKEN: 0x200007C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.Toggle.ToggleTransitionNone  // 0x0
  public    static  UnityEngine.UI.Toggle.ToggleTransitionFade  // 0x0
METHODS:
END_CLASS

CLASS: ToggleEvent
TYPE:  class
TOKEN: 0x200007D
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Raycast3DCallback
TYPE:  class
TOKEN: 0x2000081
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(UnityEngine.Ray r, UnityEngine.RaycastHit& hit, System.Single f, System.Int32 i)
  System.IAsyncResult BeginInvoke(UnityEngine.Ray r, UnityEngine.RaycastHit& hit, System.Single f, System.Int32 i, System.AsyncCallback callback, System.Object object)
  System.Boolean EndInvoke(UnityEngine.RaycastHit& hit, System.IAsyncResult result)
END_CLASS

CLASS: RaycastAllCallback
TYPE:  class
TOKEN: 0x2000082
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  UnityEngine.RaycastHit[] Invoke(UnityEngine.Ray r, System.Single f, System.Int32 i)
  System.IAsyncResult BeginInvoke(UnityEngine.Ray r, System.Single f, System.Int32 i, System.AsyncCallback callback, System.Object object)
  UnityEngine.RaycastHit[] EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: GetRaycastNonAllocCallback
TYPE:  class
TOKEN: 0x2000083
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Int32 Invoke(UnityEngine.Ray r, UnityEngine.RaycastHit[] results, System.Single f, System.Int32 i)
  System.IAsyncResult BeginInvoke(UnityEngine.Ray r, UnityEngine.RaycastHit[] results, System.Single f, System.Int32 i, System.AsyncCallback callback, System.Object object)
  System.Int32 EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: Raycast2DCallback
TYPE:  class
TOKEN: 0x2000084
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  UnityEngine.RaycastHit2D Invoke(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, System.Single f, System.Int32 i)
  System.IAsyncResult BeginInvoke(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, System.Single f, System.Int32 i, System.AsyncCallback callback, System.Object object)
  UnityEngine.RaycastHit2D EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: GetRayIntersectionAllCallback
TYPE:  class
TOKEN: 0x2000085
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  UnityEngine.RaycastHit2D[] Invoke(UnityEngine.Ray r, System.Single f, System.Int32 i)
  System.IAsyncResult BeginInvoke(UnityEngine.Ray r, System.Single f, System.Int32 i, System.AsyncCallback callback, System.Object object)
  UnityEngine.RaycastHit2D[] EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: GetRayIntersectionAllNonAllocCallback
TYPE:  class
TOKEN: 0x2000086
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Int32 Invoke(UnityEngine.Ray r, UnityEngine.RaycastHit2D[] results, System.Single f, System.Int32 i)
  System.IAsyncResult BeginInvoke(UnityEngine.Ray r, UnityEngine.RaycastHit2D[] results, System.Single f, System.Int32 i, System.AsyncCallback callback, System.Object object)
  System.Int32 EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: ColorTweenMode
TYPE:  struct
TOKEN: 0x2000092
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenModeAll  // 0x0
  public    static  UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenModeRGB  // 0x0
  public    static  UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenModeAlpha  // 0x0
METHODS:
END_CLASS

CLASS: ColorTweenCallback
TYPE:  class
TOKEN: 0x2000093
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: FloatTweenCallback
TYPE:  class
TOKEN: 0x2000095
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: PointerEventType
TYPE:  struct
TOKEN: 0x2000099
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.PanelEventHandler.PointerEventTypeDefault  // 0x0
  public    static  UnityEngine.UIElements.PanelEventHandler.PointerEventTypeDown  // 0x0
  public    static  UnityEngine.UIElements.PanelEventHandler.PointerEventTypeUp  // 0x0
METHODS:
END_CLASS

CLASS: PointerEvent
TYPE:  class
TOKEN: 0x200009A
FIELDS:
  private           System.Int32                    <pointerId>k__BackingField  // 0x10
  private           System.String                   <pointerType>k__BackingField  // 0x18
  private           System.Boolean                  <isPrimary>k__BackingField  // 0x20
  private           System.Int32                    <button>k__BackingField  // 0x24
  private           System.Int32                    <pressedButtons>k__BackingField  // 0x28
  private           UnityEngine.Vector3             <position>k__BackingField  // 0x2C
  private           UnityEngine.Vector3             <localPosition>k__BackingField  // 0x38
  private           UnityEngine.Vector3             <deltaPosition>k__BackingField  // 0x44
  private           System.Single                   <deltaTime>k__BackingField  // 0x50
  private           System.Int32                    <clickCount>k__BackingField  // 0x54
  private           System.Single                   <pressure>k__BackingField  // 0x58
  private           System.Single                   <tangentialPressure>k__BackingField  // 0x5C
  private           System.Single                   <altitudeAngle>k__BackingField  // 0x60
  private           System.Single                   <azimuthAngle>k__BackingField  // 0x64
  private           System.Single                   <twist>k__BackingField  // 0x68
  private           UnityEngine.Vector2             <radius>k__BackingField  // 0x6C
  private           UnityEngine.Vector2             <radiusVariance>k__BackingField  // 0x74
  private           UnityEngine.EventModifiers      <modifiers>k__BackingField  // 0x7C
METHODS:
  System.Int32 get_pointerId()
  System.Void set_pointerId(System.Int32 value)
  System.String get_pointerType()
  System.Void set_pointerType(System.String value)
  System.Boolean get_isPrimary()
  System.Void set_isPrimary(System.Boolean value)
  System.Int32 get_button()
  System.Void set_button(System.Int32 value)
  System.Int32 get_pressedButtons()
  System.Void set_pressedButtons(System.Int32 value)
  UnityEngine.Vector3 get_position()
  System.Void set_position(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_localPosition()
  System.Void set_localPosition(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_deltaPosition()
  System.Void set_deltaPosition(UnityEngine.Vector3 value)
  System.Single get_deltaTime()
  System.Void set_deltaTime(System.Single value)
  System.Int32 get_clickCount()
  System.Void set_clickCount(System.Int32 value)
  System.Single get_pressure()
  System.Void set_pressure(System.Single value)
  System.Single get_tangentialPressure()
  System.Void set_tangentialPressure(System.Single value)
  System.Single get_altitudeAngle()
  System.Void set_altitudeAngle(System.Single value)
  System.Single get_azimuthAngle()
  System.Void set_azimuthAngle(System.Single value)
  System.Single get_twist()
  System.Void set_twist(System.Single value)
  UnityEngine.Vector2 get_radius()
  System.Void set_radius(UnityEngine.Vector2 value)
  UnityEngine.Vector2 get_radiusVariance()
  System.Void set_radiusVariance(UnityEngine.Vector2 value)
  UnityEngine.EventModifiers get_modifiers()
  System.Void set_modifiers(UnityEngine.EventModifiers value)
  System.Boolean get_shiftKey()
  System.Boolean get_ctrlKey()
  System.Boolean get_commandKey()
  System.Boolean get_altKey()
  System.Boolean get_actionKey()
  System.Void Read(UnityEngine.UIElements.PanelEventHandler self, UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.UIElements.PanelEventHandler.PointerEventType eventType)
  System.Void SetPosition(UnityEngine.Vector3 positionOverride, UnityEngine.Vector3 deltaOverride)
  System.Void .ctor()
  System.Boolean <Read>g__InRange|82_0(System.Int32 i, System.Int32 start, System.Int32 count)
END_CLASS

CLASS: FloatIntBits
TYPE:  struct
TOKEN: 0x200009C
FIELDS:
  public            System.Single                   f  // 0x10
  public            System.Int32                    i  // 0x10
METHODS:
END_CLASS

CLASS: InputButton
TYPE:  struct
TOKEN: 0x20000A1
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.EventSystems.PointerEventData.InputButtonLeft  // 0x0
  public    static  UnityEngine.EventSystems.PointerEventData.InputButtonRight  // 0x0
  public    static  UnityEngine.EventSystems.PointerEventData.InputButtonMiddle  // 0x0
METHODS:
END_CLASS

CLASS: FramePressState
TYPE:  struct
TOKEN: 0x20000A2
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.EventSystems.PointerEventData.FramePressStatePressed  // 0x0
  public    static  UnityEngine.EventSystems.PointerEventData.FramePressStateReleased  // 0x0
  public    static  UnityEngine.EventSystems.PointerEventData.FramePressStatePressedAndReleased  // 0x0
  public    static  UnityEngine.EventSystems.PointerEventData.FramePressStateNotChanged  // 0x0
METHODS:
END_CLASS

CLASS: ProfilerMarkers
TYPE:  class
TOKEN: 0x20000B8
FIELDS:
  public    static readonly Unity.Profiling.ProfilerMarker  Update  // 0x0
  public    static readonly Unity.Profiling.ProfilerMarker  TickModules  // 0x8
  public    static readonly Unity.Profiling.ProfilerMarker  CurrentModuleProcess  // 0x10
  public    static readonly Unity.Profiling.ProfilerMarker  RaycastAll  // 0x18
  public    static readonly Unity.Profiling.ProfilerMarker  RaycastAllSort  // 0x20
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: UIToolkitOverrideConfig
TYPE:  struct
TOKEN: 0x20000B9
FIELDS:
  public            UnityEngine.EventSystems.EventSystemactiveEventSystem  // 0x10
  public            System.Boolean                  sendEvents  // 0x18
  public            System.Boolean                  createPanelGameObjectsOnStart  // 0x19
METHODS:
END_CLASS

CLASS: TriggerEvent
TYPE:  class
TOKEN: 0x20000BC
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Entry
TYPE:  class
TOKEN: 0x20000BD
FIELDS:
  public            UnityEngine.EventSystems.EventTriggerTypeeventID  // 0x10
  public            UnityEngine.EventSystems.EventTrigger.TriggerEventcallback  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: EventFunction`1
TYPE:  class
TOKEN: 0x20000C0
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T1 handler, UnityEngine.EventSystems.BaseEventData eventData)
  System.IAsyncResult BeginInvoke(T1 handler, UnityEngine.EventSystems.BaseEventData eventData, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: ButtonState
TYPE:  class
TOKEN: 0x20000C4
FIELDS:
  private           UnityEngine.EventSystems.PointerEventData.InputButtonm_Button  // 0x10
  private           UnityEngine.EventSystems.PointerInputModule.MouseButtonEventDatam_EventData  // 0x18
METHODS:
  UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData get_eventData()
  System.Void set_eventData(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData value)
  UnityEngine.EventSystems.PointerEventData.InputButton get_button()
  System.Void set_button(UnityEngine.EventSystems.PointerEventData.InputButton value)
  System.Void .ctor()
END_CLASS

CLASS: MouseState
TYPE:  class
TOKEN: 0x20000C5
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.EventSystems.PointerInputModule.ButtonState>m_TrackedButtons  // 0x10
METHODS:
  System.Boolean AnyPressesThisFrame()
  System.Boolean AnyReleasesThisFrame()
  UnityEngine.EventSystems.PointerInputModule.ButtonState GetButtonState(UnityEngine.EventSystems.PointerEventData.InputButton button)
  System.Void SetButtonState(UnityEngine.EventSystems.PointerEventData.InputButton button, UnityEngine.EventSystems.PointerEventData.FramePressState stateForMouseButton, UnityEngine.EventSystems.PointerEventData data)
  System.Void .ctor()
END_CLASS

CLASS: MouseButtonEventData
TYPE:  class
TOKEN: 0x20000C6
FIELDS:
  public            UnityEngine.EventSystems.PointerEventData.FramePressStatebuttonState  // 0x10
  public            UnityEngine.EventSystems.PointerEventDatabuttonData  // 0x18
METHODS:
  System.Boolean PressedThisFrame()
  System.Boolean ReleasedThisFrame()
  System.Void .ctor()
END_CLASS

CLASS: ProfilerMarkers
TYPE:  class
TOKEN: 0x20000C8
FIELDS:
  public    static readonly Unity.Profiling.ProfilerMarker  Process  // 0x0
  public    static readonly Unity.Profiling.ProfilerMarker  ProcessMouseEvent  // 0x8
  public    static readonly Unity.Profiling.ProfilerMarker  ProcessMousePress  // 0x10
  public    static readonly Unity.Profiling.ProfilerMarker  ProcessTouchEvents  // 0x18
  public    static readonly Unity.Profiling.ProfilerMarker  ProcessTouchPress  // 0x20
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: InputMode
TYPE:  struct
TOKEN: 0x20000C9
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.EventSystems.StandaloneInputModule.InputModeMouse  // 0x0
  public    static  UnityEngine.EventSystems.StandaloneInputModule.InputModeButtons  // 0x0
METHODS:
END_CLASS

CLASS: ProfilerMarkers
TYPE:  class
TOKEN: 0x20000CB
FIELDS:
  public    static readonly Unity.Profiling.ProfilerMarker  Process  // 0x0
  public    static readonly Unity.Profiling.ProfilerMarker  ProcessTouchEvents  // 0x8
  public    static readonly Unity.Profiling.ProfilerMarker  ProcessTouchPress  // 0x10
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: RaycastHitComparer
TYPE:  class
TOKEN: 0x20000D1
FIELDS:
  public    static  UnityEngine.EventSystems.PhysicsRaycaster.RaycastHitComparerinstance  // 0x0
METHODS:
  System.Int32 Compare(UnityEngine.RaycastHit x, UnityEngine.RaycastHit y)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: AutoScope
TYPE:  struct
TOKEN: 0x20000D7
FIELDS:
METHODS:
  System.Void .ctor(Unity.Profiling.ProfilerMarker<TP1> marker, TP1 p1)
  System.Void Dispose()
END_CLASS

CLASS: AutoScope
TYPE:  struct
TOKEN: 0x20000D9
FIELDS:
METHODS:
  System.Void .ctor(Unity.Profiling.ProfilerMarker<TP1,TP2> marker, TP1 p1, TP2 p2)
  System.Void Dispose()
END_CLASS

CLASS: AutoScope
TYPE:  struct
TOKEN: 0x20000DB
FIELDS:
METHODS:
  System.Void .ctor(Unity.Profiling.ProfilerMarker<TP1,TP2,TP3> marker, TP1 p1, TP2 p2, TP3 p3)
  System.Void Dispose()
END_CLASS

CLASS: ProfilerMarkerScope
TYPE:  struct
TOKEN: 0x20000DD
FIELDS:
METHODS:
  System.Void .ctor(Unity.Profiling.ProfilerMarker& marker)
  System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, System.Int32 context)
  System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, System.Int64 context)
  System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, System.Single context)
  System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, System.String context)
  System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, System.String context, System.String context2)
  System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, System.Int64 context, System.String context2)
  System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, UnityEngine.Object obj)
  System.Void .ctor(Unity.Profiling.ProfilerMarker& marker, UnityEngine.Transform transform, System.Boolean path)
  System.Void Dispose()
END_CLASS

CLASS: __StaticArrayInitTypeSize=12
TYPE:  struct
TOKEN: 0x20000E5
FIELDS:
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

CLASS: System.Runtime.CompilerServices.IsUnmanagedAttribute
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Profiling.ProfilerCounter`1
TYPE:  struct
TOKEN: 0x20000D4
FIELDS:
METHODS:
  System.Void .ctor(Unity.Profiling.ProfilerCategory category, System.String name, Unity.Profiling.ProfilerMarkerDataUnit dataUnit)
  System.Void Sample(T value)
END_CLASS

CLASS: Unity.Profiling.ProfilerCounterValue`1
TYPE:  struct
TOKEN: 0x20000D5
FIELDS:
METHODS:
  System.Void .ctor(System.String name)
  System.Void .ctor(System.String name, Unity.Profiling.ProfilerMarkerDataUnit dataUnit)
  System.Void .ctor(System.String name, Unity.Profiling.ProfilerMarkerDataUnit dataUnit, Unity.Profiling.ProfilerCounterOptions counterOptions)
  System.Void .ctor(Unity.Profiling.ProfilerCategory category, System.String name, Unity.Profiling.ProfilerMarkerDataUnit dataUnit)
  System.Void .ctor(Unity.Profiling.ProfilerCategory category, System.String name, Unity.Profiling.ProfilerMarkerDataUnit dataUnit, Unity.Profiling.ProfilerCounterOptions counterOptions)
  T get_Value()
  System.Void set_Value(T value)
  System.Void Sample()
END_CLASS

CLASS: Unity.Profiling.ProfilerMarker`1
TYPE:  struct
TOKEN: 0x20000D6
FIELDS:
METHODS:
  System.Void .ctor(System.String name, System.String param1Name)
  System.Void .ctor(Unity.Profiling.ProfilerCategory category, System.String name, System.String param1Name)
  System.Void Begin(TP1 p1)
  System.Void End()
  Unity.Profiling.ProfilerMarker.AutoScope<TP1> Auto(TP1 p1)
END_CLASS

CLASS: Unity.Profiling.ProfilerMarker`2
TYPE:  struct
TOKEN: 0x20000D8
FIELDS:
METHODS:
  System.Void .ctor(System.String name, System.String param1Name, System.String param2Name)
  System.Void .ctor(Unity.Profiling.ProfilerCategory category, System.String name, System.String param1Name, System.String param2Name)
  System.Void Begin(TP1 p1, TP2 p2)
  System.Void End()
  Unity.Profiling.ProfilerMarker.AutoScope<TP1,TP2> Auto(TP1 p1, TP2 p2)
END_CLASS

CLASS: Unity.Profiling.ProfilerMarker`3
TYPE:  struct
TOKEN: 0x20000DA
FIELDS:
METHODS:
  System.Void .ctor(System.String name, System.String param1Name, System.String param2Name, System.String param3Name)
  System.Void .ctor(Unity.Profiling.ProfilerCategory category, System.String name, System.String param1Name, System.String param2Name, System.String param3Name)
  System.Void Begin(TP1 p1, TP2 p2, TP3 p3)
  System.Void End()
  Unity.Profiling.ProfilerMarker.AutoScope<TP1,TP2,TP3> Auto(TP1 p1, TP2 p2, TP3 p3)
END_CLASS

CLASS: Unity.Profiling.ProfilerMarkerExtension
TYPE:  class
TOKEN: 0x20000DC
FIELDS:
METHODS:
  System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.Int32 metadata)
  System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.UInt32 metadata)
  System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.Int64 metadata)
  System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.UInt64 metadata)
  System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.Single metadata)
  System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.Double metadata)
  System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.String metadata)
  System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.String metadata, System.String metadata2)
  System.Void Begin(Unity.Profiling.ProfilerMarker marker, System.Int64 metadata, System.String metadata2)
  Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker)
  Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker, System.Int32 context)
  Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker, System.Int64 context)
  Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker, System.Single context)
  Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker, System.String context)
  Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker, System.String context, System.String context2)
  Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker, System.Int64 context, System.String context2)
  Unity.Profiling.ProfilerMarkerExtension.ProfilerMarkerScope Scope(Unity.Profiling.ProfilerMarker marker, UnityEngine.Transform transform, System.Boolean path)
END_CLASS

CLASS: Unity.Profiling.MonoObject_64
TYPE:  struct
TOKEN: 0x20000DE
FIELDS:
  public            System.Void*                    p1  // 0x10
  public            System.Void*                    p2  // 0x18
METHODS:
END_CLASS

CLASS: Unity.Profiling.MonoObject_32
TYPE:  struct
TOKEN: 0x20000DF
FIELDS:
  public            System.Void*                    p1  // 0x10
  public            System.Void*                    p2  // 0x14
METHODS:
END_CLASS

CLASS: Unity.Profiling.MonoString_64
TYPE:  struct
TOKEN: 0x20000E0
FIELDS:
  public            Unity.Profiling.MonoObject_64   obj  // 0x10
  public            System.Int32                    length  // 0x20
  public            System.Char                     firstChar  // 0x24
METHODS:
END_CLASS

CLASS: Unity.Profiling.MonoString_32
TYPE:  struct
TOKEN: 0x20000E1
FIELDS:
  public            Unity.Profiling.MonoObject_32   obj  // 0x10
  public            System.Int32                    length  // 0x18
  public            System.Char                     firstChar  // 0x1C
METHODS:
END_CLASS

CLASS: Unity.Profiling.ProfilerString
TYPE:  class
TOKEN: 0x20000E2
FIELDS:
  private   static  System.Int32                    MAX  // 0x0
  private           System.String                   m_buffer  // 0x10
  private           System.Int32                    m_length  // 0x18
  private           System.Int32*                   m_strCount  // 0x20
  private           System.UInt64                   m_handler  // 0x28
METHODS:
  System.Void .ctor(System.Int32 count)
  System.Void Dispose()
  System.String ToString()
  System.String op_Implicit(Unity.Profiling.ProfilerString handle)
  System.Void Append(System.String value)
END_CLASS

CLASS: Unity.Profiling.ProfilerUtility
TYPE:  struct
TOKEN: 0x20000E3
FIELDS:
METHODS:
  System.Byte GetProfilerMarkerDataType()
END_CLASS

CLASS: UnityEngine.EventSystems.AxisEventData
TYPE:  class
TOKEN: 0x200009D
EXTENDS: BaseEventData
FIELDS:
  private           UnityEngine.Vector2             <moveVector>k__BackingField  // 0x20
  private           UnityEngine.EventSystems.MoveDirection<moveDir>k__BackingField  // 0x28
METHODS:
  UnityEngine.Vector2 get_moveVector()
  System.Void set_moveVector(UnityEngine.Vector2 value)
  UnityEngine.EventSystems.MoveDirection get_moveDir()
  System.Void set_moveDir(UnityEngine.EventSystems.MoveDirection value)
  System.Void .ctor(UnityEngine.EventSystems.EventSystem eventSystem)
END_CLASS

CLASS: UnityEngine.EventSystems.AbstractEventData
TYPE:  class
TOKEN: 0x200009E
FIELDS:
  protected         System.Boolean                  m_Used  // 0x10
METHODS:
  System.Void Reset()
  System.Void Use()
  System.Boolean get_used()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.EventSystems.BaseEventData
TYPE:  class
TOKEN: 0x200009F
EXTENDS: AbstractEventData
FIELDS:
  private   readonly UnityEngine.EventSystems.EventSystemm_EventSystem  // 0x18
METHODS:
  System.Void .ctor(UnityEngine.EventSystems.EventSystem eventSystem)
  UnityEngine.EventSystems.BaseInputModule get_currentInputModule()
  UnityEngine.GameObject get_selectedObject()
  System.Void set_selectedObject(UnityEngine.GameObject value)
END_CLASS

CLASS: UnityEngine.EventSystems.PointerEventData
TYPE:  class
TOKEN: 0x20000A0
EXTENDS: BaseEventData
FIELDS:
  private           UnityEngine.GameObject          <pointerEnter>k__BackingField  // 0x20
  private           UnityEngine.GameObject          m_PointerPress  // 0x28
  private           UnityEngine.GameObject          <lastPress>k__BackingField  // 0x30
  private           UnityEngine.GameObject          <rawPointerPress>k__BackingField  // 0x38
  private           UnityEngine.GameObject          <pointerDrag>k__BackingField  // 0x40
  private           UnityEngine.GameObject          <pointerClick>k__BackingField  // 0x48
  private           UnityEngine.EventSystems.RaycastResult<pointerCurrentRaycast>k__BackingField  // 0x50
  private           UnityEngine.EventSystems.RaycastResult<pointerPressRaycast>k__BackingField  // 0x98
  public            System.Collections.Generic.List<UnityEngine.GameObject>hovered  // 0xE0
  private           System.Boolean                  <eligibleForClick>k__BackingField  // 0xE8
  private           System.Int32                    <pointerId>k__BackingField  // 0xEC
  private           UnityEngine.Vector2             <position>k__BackingField  // 0xF0
  private           UnityEngine.Vector2             <delta>k__BackingField  // 0xF8
  private           UnityEngine.Vector2             <pressPosition>k__BackingField  // 0x100
  private           UnityEngine.Vector3             <worldPosition>k__BackingField  // 0x108
  private           UnityEngine.Vector3             <worldNormal>k__BackingField  // 0x114
  private           System.Single                   <clickTime>k__BackingField  // 0x120
  private           System.Int32                    <clickCount>k__BackingField  // 0x124
  private           UnityEngine.Vector2             <scrollDelta>k__BackingField  // 0x128
  private           System.Boolean                  <useDragThreshold>k__BackingField  // 0x130
  private           System.Boolean                  <dragging>k__BackingField  // 0x131
  private           UnityEngine.EventSystems.PointerEventData.InputButton<button>k__BackingField  // 0x134
  private           System.Single                   <pressure>k__BackingField  // 0x138
  private           System.Single                   <tangentialPressure>k__BackingField  // 0x13C
  private           System.Single                   <altitudeAngle>k__BackingField  // 0x140
  private           System.Single                   <azimuthAngle>k__BackingField  // 0x144
  private           System.Single                   <twist>k__BackingField  // 0x148
  private           UnityEngine.Vector2             <radius>k__BackingField  // 0x14C
  private           UnityEngine.Vector2             <radiusVariance>k__BackingField  // 0x154
  private           System.Boolean                  <fullyExited>k__BackingField  // 0x15C
  private           System.Boolean                  <reentered>k__BackingField  // 0x15D
METHODS:
  UnityEngine.GameObject get_pointerEnter()
  System.Void set_pointerEnter(UnityEngine.GameObject value)
  UnityEngine.GameObject get_lastPress()
  System.Void set_lastPress(UnityEngine.GameObject value)
  UnityEngine.GameObject get_rawPointerPress()
  System.Void set_rawPointerPress(UnityEngine.GameObject value)
  UnityEngine.GameObject get_pointerDrag()
  System.Void set_pointerDrag(UnityEngine.GameObject value)
  UnityEngine.GameObject get_pointerClick()
  System.Void set_pointerClick(UnityEngine.GameObject value)
  UnityEngine.EventSystems.RaycastResult get_pointerCurrentRaycast()
  System.Void set_pointerCurrentRaycast(UnityEngine.EventSystems.RaycastResult value)
  UnityEngine.EventSystems.RaycastResult get_pointerPressRaycast()
  System.Void set_pointerPressRaycast(UnityEngine.EventSystems.RaycastResult value)
  System.Boolean get_eligibleForClick()
  System.Void set_eligibleForClick(System.Boolean value)
  System.Int32 get_pointerId()
  System.Void set_pointerId(System.Int32 value)
  UnityEngine.Vector2 get_position()
  System.Void set_position(UnityEngine.Vector2 value)
  UnityEngine.Vector2 get_delta()
  System.Void set_delta(UnityEngine.Vector2 value)
  UnityEngine.Vector2 get_pressPosition()
  System.Void set_pressPosition(UnityEngine.Vector2 value)
  UnityEngine.Vector3 get_worldPosition()
  System.Void set_worldPosition(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_worldNormal()
  System.Void set_worldNormal(UnityEngine.Vector3 value)
  System.Single get_clickTime()
  System.Void set_clickTime(System.Single value)
  System.Int32 get_clickCount()
  System.Void set_clickCount(System.Int32 value)
  UnityEngine.Vector2 get_scrollDelta()
  System.Void set_scrollDelta(UnityEngine.Vector2 value)
  System.Boolean get_useDragThreshold()
  System.Void set_useDragThreshold(System.Boolean value)
  System.Boolean get_dragging()
  System.Void set_dragging(System.Boolean value)
  UnityEngine.EventSystems.PointerEventData.InputButton get_button()
  System.Void set_button(UnityEngine.EventSystems.PointerEventData.InputButton value)
  System.Single get_pressure()
  System.Void set_pressure(System.Single value)
  System.Single get_tangentialPressure()
  System.Void set_tangentialPressure(System.Single value)
  System.Single get_altitudeAngle()
  System.Void set_altitudeAngle(System.Single value)
  System.Single get_azimuthAngle()
  System.Void set_azimuthAngle(System.Single value)
  System.Single get_twist()
  System.Void set_twist(System.Single value)
  UnityEngine.Vector2 get_radius()
  System.Void set_radius(UnityEngine.Vector2 value)
  UnityEngine.Vector2 get_radiusVariance()
  System.Void set_radiusVariance(UnityEngine.Vector2 value)
  System.Boolean get_fullyExited()
  System.Void set_fullyExited(System.Boolean value)
  System.Boolean get_reentered()
  System.Void set_reentered(System.Boolean value)
  System.Void .ctor(UnityEngine.EventSystems.EventSystem eventSystem)
  System.Boolean IsPointerMoving()
  System.Boolean IsScrolling()
  UnityEngine.Camera get_enterEventCamera()
  UnityEngine.Camera get_pressEventCamera()
  UnityEngine.GameObject get_pointerPress()
  System.Void set_pointerPress(UnityEngine.GameObject value)
  System.String ToString()
END_CLASS

CLASS: UnityEngine.EventSystems.EventHandle
TYPE:  struct
TOKEN: 0x20000A3
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.EventSystems.EventHandleUnused  // 0x0
  public    static  UnityEngine.EventSystems.EventHandleUsed  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.EventSystems.IEventSystemHandler
TYPE:  interface
TOKEN: 0x20000A4
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.EventSystems.IPointerMoveHandler
TYPE:  interface
TOKEN: 0x20000A5
FIELDS:
METHODS:
  System.Void OnPointerMove(UnityEngine.EventSystems.PointerEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.IPointerEnterHandler
TYPE:  interface
TOKEN: 0x20000A6
FIELDS:
METHODS:
  System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.IPointerExitHandler
TYPE:  interface
TOKEN: 0x20000A7
FIELDS:
METHODS:
  System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.IPointerDownHandler
TYPE:  interface
TOKEN: 0x20000A8
FIELDS:
METHODS:
  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.IPointerUpHandler
TYPE:  interface
TOKEN: 0x20000A9
FIELDS:
METHODS:
  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.IPointerClickHandler
TYPE:  interface
TOKEN: 0x20000AA
FIELDS:
METHODS:
  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.IBeginDragHandler
TYPE:  interface
TOKEN: 0x20000AB
FIELDS:
METHODS:
  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.IInitializePotentialDragHandler
TYPE:  interface
TOKEN: 0x20000AC
FIELDS:
METHODS:
  System.Void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.IDragHandler
TYPE:  interface
TOKEN: 0x20000AD
FIELDS:
METHODS:
  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.IEndDragHandler
TYPE:  interface
TOKEN: 0x20000AE
FIELDS:
METHODS:
  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.IDropHandler
TYPE:  interface
TOKEN: 0x20000AF
FIELDS:
METHODS:
  System.Void OnDrop(UnityEngine.EventSystems.PointerEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.IScrollHandler
TYPE:  interface
TOKEN: 0x20000B0
FIELDS:
METHODS:
  System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.IUpdateSelectedHandler
TYPE:  interface
TOKEN: 0x20000B1
FIELDS:
METHODS:
  System.Void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.ISelectHandler
TYPE:  interface
TOKEN: 0x20000B2
FIELDS:
METHODS:
  System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.IDeselectHandler
TYPE:  interface
TOKEN: 0x20000B3
FIELDS:
METHODS:
  System.Void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.IMoveHandler
TYPE:  interface
TOKEN: 0x20000B4
FIELDS:
METHODS:
  System.Void OnMove(UnityEngine.EventSystems.AxisEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.ISubmitHandler
TYPE:  interface
TOKEN: 0x20000B5
FIELDS:
METHODS:
  System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.ICancelHandler
TYPE:  interface
TOKEN: 0x20000B6
FIELDS:
METHODS:
  System.Void OnCancel(UnityEngine.EventSystems.BaseEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.EventSystem
TYPE:  class
TOKEN: 0x20000B7
EXTENDS: UIBehaviour
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.EventSystems.BaseInputModule>m_SystemInputModules  // 0x18
  private           UnityEngine.EventSystems.BaseInputModulem_CurrentInputModule  // 0x20
  private   static  System.Collections.Generic.List<UnityEngine.EventSystems.EventSystem>m_EventSystems  // 0x0
  private           UnityEngine.GameObject          m_FirstSelected  // 0x28
  private           System.Boolean                  m_sendNavigationEvents  // 0x30
  private           System.Int32                    m_DragThreshold  // 0x34
  private           UnityEngine.GameObject          m_CurrentSelected  // 0x38
  private           System.Boolean                  m_HasFocus  // 0x40
  private           System.Boolean                  m_SelectionGuard  // 0x41
  private           UnityEngine.EventSystems.BaseEventDatam_DummyData  // 0x48
  private   static readonly System.Comparison<UnityEngine.EventSystems.RaycastResult>s_RaycastComparer  // 0x8
  private   static  UnityEngine.EventSystems.EventSystem.UIToolkitOverrideConfigs_UIToolkitOverride  // 0x10
METHODS:
  UnityEngine.EventSystems.EventSystem get_current()
  System.Void set_current(UnityEngine.EventSystems.EventSystem value)
  System.Boolean get_sendNavigationEvents()
  System.Void set_sendNavigationEvents(System.Boolean value)
  System.Int32 get_pixelDragThreshold()
  System.Void set_pixelDragThreshold(System.Int32 value)
  UnityEngine.EventSystems.BaseInputModule get_currentInputModule()
  UnityEngine.GameObject get_firstSelectedGameObject()
  System.Void set_firstSelectedGameObject(UnityEngine.GameObject value)
  UnityEngine.GameObject get_currentSelectedGameObject()
  UnityEngine.GameObject get_lastSelectedGameObject()
  System.Boolean get_isFocused()
  System.Void .ctor()
  System.Void UpdateModules()
  System.Boolean get_alreadySelecting()
  System.Void SetSelectedGameObject(UnityEngine.GameObject selected, UnityEngine.EventSystems.BaseEventData pointer)
  UnityEngine.EventSystems.BaseEventData get_baseEventDataCache()
  System.Void SetSelectedGameObject(UnityEngine.GameObject selected)
  System.Int32 RaycastComparer(UnityEngine.EventSystems.RaycastResult lhs, UnityEngine.EventSystems.RaycastResult rhs)
  System.Void RaycastAll(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> raycastResults)
  System.Boolean IsPointerOverGameObject()
  System.Boolean IsPointerOverGameObject(System.Int32 pointerId)
  System.Boolean get_isUIToolkitActiveEventSystem()
  System.Boolean get_sendUIToolkitEvents()
  System.Boolean get_createUIToolkitPanelGameObjectsOnStart()
  System.Void SetUITookitEventSystemOverride(UnityEngine.EventSystems.EventSystem activeEventSystem, System.Boolean sendEvents, System.Boolean createPanelGameObjectsOnStart)
  System.Void CreateUIToolkitPanelGameObject(UnityEngine.UIElements.BaseRuntimePanel panel)
  System.Void Start()
  System.Void OnDestroy()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void TickModules()
  System.Void OnApplicationFocus(System.Boolean hasFocus)
  System.Void Update()
  System.Void ChangeEventModule(UnityEngine.EventSystems.BaseInputModule module)
  System.String ToString()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.EventSystems.EventTrigger
TYPE:  class
TOKEN: 0x20000BB
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry>m_Delegates  // 0x18
METHODS:
  System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> get_delegates()
  System.Void set_delegates(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> value)
  System.Void .ctor()
  System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> get_triggers()
  System.Void set_triggers(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> value)
  System.Void Execute(UnityEngine.EventSystems.EventTriggerType id, UnityEngine.EventSystems.BaseEventData eventData)
  System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnDrop(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnMove(UnityEngine.EventSystems.AxisEventData eventData)
  System.Void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void OnCancel(UnityEngine.EventSystems.BaseEventData eventData)
END_CLASS

CLASS: UnityEngine.EventSystems.EventTriggerType
TYPE:  struct
TOKEN: 0x20000BE
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.EventSystems.EventTriggerTypePointerEnter  // 0x0
  public    static  UnityEngine.EventSystems.EventTriggerTypePointerExit  // 0x0
  public    static  UnityEngine.EventSystems.EventTriggerTypePointerDown  // 0x0
  public    static  UnityEngine.EventSystems.EventTriggerTypePointerUp  // 0x0
  public    static  UnityEngine.EventSystems.EventTriggerTypePointerClick  // 0x0
  public    static  UnityEngine.EventSystems.EventTriggerTypeDrag  // 0x0
  public    static  UnityEngine.EventSystems.EventTriggerTypeDrop  // 0x0
  public    static  UnityEngine.EventSystems.EventTriggerTypeScroll  // 0x0
  public    static  UnityEngine.EventSystems.EventTriggerTypeUpdateSelected  // 0x0
  public    static  UnityEngine.EventSystems.EventTriggerTypeSelect  // 0x0
  public    static  UnityEngine.EventSystems.EventTriggerTypeDeselect  // 0x0
  public    static  UnityEngine.EventSystems.EventTriggerTypeMove  // 0x0
  public    static  UnityEngine.EventSystems.EventTriggerTypeInitializePotentialDrag  // 0x0
  public    static  UnityEngine.EventSystems.EventTriggerTypeBeginDrag  // 0x0
  public    static  UnityEngine.EventSystems.EventTriggerTypeEndDrag  // 0x0
  public    static  UnityEngine.EventSystems.EventTriggerTypeSubmit  // 0x0
  public    static  UnityEngine.EventSystems.EventTriggerTypeCancel  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.EventSystems.ExecuteEvents
TYPE:  class
TOKEN: 0x20000BF
FIELDS:
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerMoveHandler>s_PointerMoveHandler  // 0x0
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler>s_PointerEnterHandler  // 0x8
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler>s_PointerExitHandler  // 0x10
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler>s_PointerDownHandler  // 0x18
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler>s_PointerUpHandler  // 0x20
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler>s_PointerClickHandler  // 0x28
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler>s_InitializePotentialDragHandler  // 0x30
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler>s_BeginDragHandler  // 0x38
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler>s_DragHandler  // 0x40
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler>s_EndDragHandler  // 0x48
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler>s_DropHandler  // 0x50
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler>s_ScrollHandler  // 0x58
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler>s_UpdateSelectedHandler  // 0x60
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler>s_SelectHandler  // 0x68
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler>s_DeselectHandler  // 0x70
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler>s_MoveHandler  // 0x78
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler>s_SubmitHandler  // 0x80
  private   static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler>s_CancelHandler  // 0x88
  private   static readonly System.Collections.Generic.List<UnityEngine.Transform>s_InternalTransformList  // 0x90
METHODS:
  T ValidateEventData(UnityEngine.EventSystems.BaseEventData data)
  System.Void Execute(UnityEngine.EventSystems.IPointerMoveHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  System.Void Execute(UnityEngine.EventSystems.IPointerEnterHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  System.Void Execute(UnityEngine.EventSystems.IPointerExitHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  System.Void Execute(UnityEngine.EventSystems.IPointerDownHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  System.Void Execute(UnityEngine.EventSystems.IPointerUpHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  System.Void Execute(UnityEngine.EventSystems.IPointerClickHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  System.Void Execute(UnityEngine.EventSystems.IInitializePotentialDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  System.Void Execute(UnityEngine.EventSystems.IBeginDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  System.Void Execute(UnityEngine.EventSystems.IDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  System.Void Execute(UnityEngine.EventSystems.IEndDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  System.Void Execute(UnityEngine.EventSystems.IDropHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  System.Void Execute(UnityEngine.EventSystems.IScrollHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  System.Void Execute(UnityEngine.EventSystems.IUpdateSelectedHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  System.Void Execute(UnityEngine.EventSystems.ISelectHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  System.Void Execute(UnityEngine.EventSystems.IDeselectHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  System.Void Execute(UnityEngine.EventSystems.IMoveHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  System.Void Execute(UnityEngine.EventSystems.ISubmitHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  System.Void Execute(UnityEngine.EventSystems.ICancelHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
  UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerMoveHandler> get_pointerMoveHandler()
  UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler> get_pointerEnterHandler()
  UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler> get_pointerExitHandler()
  UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler> get_pointerDownHandler()
  UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler> get_pointerUpHandler()
  UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler> get_pointerClickHandler()
  UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler> get_initializePotentialDrag()
  UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler> get_beginDragHandler()
  UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler> get_dragHandler()
  UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler> get_endDragHandler()
  UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler> get_dropHandler()
  UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler> get_scrollHandler()
  UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler> get_updateSelectedHandler()
  UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler> get_selectHandler()
  UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler> get_deselectHandler()
  UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler> get_moveHandler()
  UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler> get_submitHandler()
  UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler> get_cancelHandler()
  System.Void GetEventChain(UnityEngine.GameObject root, System.Collections.Generic.IList<UnityEngine.Transform> eventChain)
  System.Boolean Execute(UnityEngine.GameObject target, UnityEngine.EventSystems.BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> functor)
  UnityEngine.GameObject ExecuteHierarchy(UnityEngine.GameObject root, UnityEngine.EventSystems.BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> callbackFunction)
  System.Boolean ShouldSendToComponent(UnityEngine.Component component)
  System.Void GetEventList(UnityEngine.GameObject go, System.Collections.Generic.IList<UnityEngine.EventSystems.IEventSystemHandler> results)
  System.Boolean CanHandleEvent(UnityEngine.GameObject go)
  UnityEngine.GameObject GetEventHandler(UnityEngine.GameObject root)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.EventSystems.BaseInput
TYPE:  class
TOKEN: 0x20000C1
EXTENDS: UIBehaviour
FIELDS:
METHODS:
  System.String get_compositionString()
  UnityEngine.IMECompositionMode get_imeCompositionMode()
  System.Void set_imeCompositionMode(UnityEngine.IMECompositionMode value)
  UnityEngine.Vector2 get_compositionCursorPos()
  System.Void set_compositionCursorPos(UnityEngine.Vector2 value)
  System.Boolean get_mousePresent()
  System.Boolean GetMouseButtonDown(System.Int32 button)
  System.Boolean GetMouseButtonUp(System.Int32 button)
  System.Boolean GetMouseButton(System.Int32 button)
  UnityEngine.Vector2 get_mousePosition()
  UnityEngine.Vector2 get_mouseScrollDelta()
  System.Boolean get_touchSupported()
  System.Int32 get_touchCount()
  UnityEngine.Touch GetTouch(System.Int32 index)
  System.Single GetAxisRaw(System.String axisName)
  System.Boolean GetButtonDown(System.String buttonName)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.EventSystems.BaseInputModule
TYPE:  class
TOKEN: 0x20000C2
EXTENDS: UIBehaviour
FIELDS:
  protected         System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>m_RaycastResultCache  // 0x18
  private           UnityEngine.EventSystems.AxisEventDatam_AxisEventData  // 0x20
  private           UnityEngine.EventSystems.EventSystemm_EventSystem  // 0x28
  private           UnityEngine.EventSystems.BaseEventDatam_BaseEventData  // 0x30
  protected         UnityEngine.EventSystems.BaseInputm_InputOverride  // 0x38
  private           UnityEngine.EventSystems.BaseInputm_DefaultInput  // 0x40
METHODS:
  UnityEngine.EventSystems.BaseInput get_input()
  UnityEngine.EventSystems.BaseInput get_inputOverride()
  System.Void set_inputOverride(UnityEngine.EventSystems.BaseInput value)
  UnityEngine.EventSystems.EventSystem get_eventSystem()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Process()
  UnityEngine.EventSystems.RaycastResult FindFirstRaycast(System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> candidates)
  UnityEngine.EventSystems.MoveDirection DetermineMoveDirection(System.Single x, System.Single y)
  UnityEngine.EventSystems.MoveDirection DetermineMoveDirection(System.Single x, System.Single y, System.Single deadZone)
  UnityEngine.GameObject FindCommonRoot(UnityEngine.GameObject g1, UnityEngine.GameObject g2)
  System.Void HandlePointerExitAndEnter(UnityEngine.EventSystems.PointerEventData currentPointerData, UnityEngine.GameObject newEnterTarget)
  UnityEngine.EventSystems.AxisEventData GetAxisEventData(System.Single x, System.Single y, System.Single moveDeadZone)
  UnityEngine.EventSystems.BaseEventData GetBaseEventData()
  System.Boolean IsPointerOverGameObject(System.Int32 pointerId)
  System.Boolean ShouldActivateModule()
  System.Void DeactivateModule()
  System.Void ActivateModule()
  System.Void UpdateModule()
  System.Boolean IsModuleSupported()
  System.Int32 ConvertUIToolkitPointerId(UnityEngine.EventSystems.PointerEventData sourcePointerData)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.EventSystems.PointerInputModule
TYPE:  class
TOKEN: 0x20000C3
EXTENDS: BaseInputModule
FIELDS:
  public    static  System.Int32                    kMouseLeftId  // 0x0
  public    static  System.Int32                    kMouseRightId  // 0x0
  public    static  System.Int32                    kMouseMiddleId  // 0x0
  public    static  System.Int32                    kFakeTouchesId  // 0x0
  protected         System.Collections.Generic.Dictionary<System.Int32,UnityEngine.EventSystems.PointerEventData>m_PointerData  // 0x48
  private   readonly UnityEngine.EventSystems.PointerInputModule.MouseStatem_MouseState  // 0x50
METHODS:
  System.Boolean GetPointerData(System.Int32 id, UnityEngine.EventSystems.PointerEventData& data, System.Boolean create)
  System.Void RemovePointerData(UnityEngine.EventSystems.PointerEventData data)
  UnityEngine.EventSystems.PointerEventData GetTouchPointerEventData(UnityEngine.Touch input, System.Boolean& pressed, System.Boolean& released)
  System.Void CopyFromTo(UnityEngine.EventSystems.PointerEventData from, UnityEngine.EventSystems.PointerEventData to)
  UnityEngine.EventSystems.PointerEventData.FramePressState StateForMouseButton(System.Int32 buttonId)
  UnityEngine.EventSystems.PointerInputModule.MouseState GetMousePointerEventData()
  UnityEngine.EventSystems.PointerInputModule.MouseState GetMousePointerEventData(System.Int32 id)
  UnityEngine.EventSystems.PointerEventData GetLastPointerEventData(System.Int32 id)
  System.Boolean ShouldStartDrag(UnityEngine.Vector2 pressPos, UnityEngine.Vector2 currentPos, System.Single threshold, System.Boolean useDragThreshold)
  System.Void ProcessMove(UnityEngine.EventSystems.PointerEventData pointerEvent)
  System.Void ProcessDrag(UnityEngine.EventSystems.PointerEventData pointerEvent)
  System.Boolean IsPointerOverGameObject(System.Int32 pointerId)
  System.Void ClearSelection()
  System.String ToString()
  System.Void DeselectIfSelectionChanged(UnityEngine.GameObject currentOverGo, UnityEngine.EventSystems.BaseEventData pointerEvent)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.EventSystems.StandaloneInputModule
TYPE:  class
TOKEN: 0x20000C7
EXTENDS: PointerInputModule
FIELDS:
  private           System.Single                   m_PrevActionTime  // 0x58
  private           UnityEngine.Vector2             m_LastMoveVector  // 0x5C
  private           System.Int32                    m_ConsecutiveMoveCount  // 0x64
  private           UnityEngine.Vector2             m_LastMousePosition  // 0x68
  private           UnityEngine.Vector2             m_MousePosition  // 0x70
  private           UnityEngine.GameObject          m_CurrentFocusedGameObject  // 0x78
  private           UnityEngine.EventSystems.PointerEventDatam_InputPointerEvent  // 0x80
  private           System.String                   m_HorizontalAxis  // 0x88
  private           System.String                   m_VerticalAxis  // 0x90
  private           System.String                   m_SubmitButton  // 0x98
  private           System.String                   m_CancelButton  // 0xA0
  private           System.Single                   m_InputActionsPerSecond  // 0xA8
  private           System.Single                   m_RepeatDelay  // 0xAC
  private           System.Boolean                  m_ForceModuleActive  // 0xB0
METHODS:
  System.Void .ctor()
  UnityEngine.EventSystems.StandaloneInputModule.InputMode get_inputMode()
  System.Boolean get_allowActivationOnMobileDevice()
  System.Void set_allowActivationOnMobileDevice(System.Boolean value)
  System.Boolean get_forceModuleActive()
  System.Void set_forceModuleActive(System.Boolean value)
  System.Single get_inputActionsPerSecond()
  System.Void set_inputActionsPerSecond(System.Single value)
  System.Single get_repeatDelay()
  System.Void set_repeatDelay(System.Single value)
  System.String get_horizontalAxis()
  System.Void set_horizontalAxis(System.String value)
  System.String get_verticalAxis()
  System.Void set_verticalAxis(System.String value)
  System.String get_submitButton()
  System.Void set_submitButton(System.String value)
  System.String get_cancelButton()
  System.Void set_cancelButton(System.String value)
  System.Boolean ShouldIgnoreEventsOnNoFocus()
  System.Void UpdateModule()
  System.Void ReleaseMouse(UnityEngine.EventSystems.PointerEventData pointerEvent, UnityEngine.GameObject currentOverGo)
  System.Boolean ShouldActivateModule()
  System.Void ActivateModule()
  System.Void DeactivateModule()
  System.Void Process()
  System.Boolean ProcessTouchEvents()
  System.Void ProcessTouchPress(UnityEngine.EventSystems.PointerEventData pointerEvent, System.Boolean pressed, System.Boolean released)
  System.Boolean SendSubmitEventToSelectedObject()
  UnityEngine.Vector2 GetRawMoveVector()
  System.Boolean SendMoveEventToSelectedObject()
  System.Void ProcessMouseEvent()
  System.Boolean ForceAutoSelect()
  System.Void ProcessMouseEvent(System.Int32 id)
  System.Boolean SendUpdateEventToSelectedObject()
  System.Void ProcessMousePress(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData data)
  UnityEngine.GameObject GetCurrentFocusedGameObject()
END_CLASS

CLASS: UnityEngine.EventSystems.TouchInputModule
TYPE:  class
TOKEN: 0x20000CA
EXTENDS: PointerInputModule
FIELDS:
  private           UnityEngine.Vector2             m_LastMousePosition  // 0x58
  private           UnityEngine.Vector2             m_MousePosition  // 0x60
  private           UnityEngine.EventSystems.PointerEventDatam_InputPointerEvent  // 0x68
  private           System.Boolean                  m_ForceModuleActive  // 0x70
METHODS:
  System.Void .ctor()
  System.Boolean get_allowActivationOnStandalone()
  System.Void set_allowActivationOnStandalone(System.Boolean value)
  System.Boolean get_forceModuleActive()
  System.Void set_forceModuleActive(System.Boolean value)
  System.Void UpdateModule()
  System.Boolean IsModuleSupported()
  System.Boolean ShouldActivateModule()
  System.Boolean UseFakeInput()
  System.Void Process()
  System.Void FakeTouches()
  System.Void ProcessTouchEvents()
  System.Void ProcessTouchPress(UnityEngine.EventSystems.PointerEventData pointerEvent, System.Boolean pressed, System.Boolean released)
  System.Void DeactivateModule()
  System.String ToString()
END_CLASS

CLASS: UnityEngine.EventSystems.MoveDirection
TYPE:  struct
TOKEN: 0x20000CC
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.EventSystems.MoveDirectionLeft  // 0x0
  public    static  UnityEngine.EventSystems.MoveDirectionUp  // 0x0
  public    static  UnityEngine.EventSystems.MoveDirectionRight  // 0x0
  public    static  UnityEngine.EventSystems.MoveDirectionDown  // 0x0
  public    static  UnityEngine.EventSystems.MoveDirectionNone  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.EventSystems.RaycasterManager
TYPE:  class
TOKEN: 0x20000CD
FIELDS:
  private   static readonly System.Collections.Generic.List<UnityEngine.EventSystems.BaseRaycaster>s_Raycasters  // 0x0
METHODS:
  System.Void AddRaycaster(UnityEngine.EventSystems.BaseRaycaster baseRaycaster)
  System.Collections.Generic.List<UnityEngine.EventSystems.BaseRaycaster> GetRaycasters()
  System.Void RemoveRaycasters(UnityEngine.EventSystems.BaseRaycaster baseRaycaster)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.EventSystems.BaseRaycaster
TYPE:  class
TOKEN: 0x20000CE
EXTENDS: UIBehaviour
FIELDS:
  private           UnityEngine.EventSystems.BaseRaycasterm_RootRaycaster  // 0x18
METHODS:
  System.Void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList)
  UnityEngine.Camera get_eventCamera()
  System.Int32 get_priority()
  System.Int32 get_sortOrderPriority()
  System.Int32 get_renderOrderPriority()
  UnityEngine.EventSystems.BaseRaycaster get_rootRaycaster()
  System.String ToString()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnCanvasHierarchyChanged()
  System.Void OnTransformParentChanged()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.EventSystems.Physics2DRaycaster
TYPE:  class
TOKEN: 0x20000CF
EXTENDS: PhysicsRaycaster
FIELDS:
  private           UnityEngine.RaycastHit2D[]      m_Hits  // 0x40
METHODS:
  System.Void .ctor()
  System.Void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList)
END_CLASS

CLASS: UnityEngine.EventSystems.PhysicsRaycaster
TYPE:  class
TOKEN: 0x20000D0
EXTENDS: BaseRaycaster
FIELDS:
  protected static  System.Int32                    kNoEventMaskSet  // 0x0
  protected         UnityEngine.Camera              m_EventCamera  // 0x20
  protected         UnityEngine.LayerMask           m_EventMask  // 0x28
  protected         System.Int32                    m_MaxRayIntersections  // 0x2C
  protected         System.Int32                    m_LastMaxRayIntersections  // 0x30
  private           UnityEngine.RaycastHit[]        m_Hits  // 0x38
METHODS:
  System.Void .ctor()
  UnityEngine.Camera get_eventCamera()
  System.Int32 get_depth()
  System.Int32 get_finalEventMask()
  UnityEngine.LayerMask get_eventMask()
  System.Void set_eventMask(UnityEngine.LayerMask value)
  System.Int32 get_maxRayIntersections()
  System.Void set_maxRayIntersections(System.Int32 value)
  System.Boolean ComputeRayAndDistance(UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.Ray& ray, System.Int32& eventDisplayIndex, System.Single& distanceToClipPlane)
  System.Void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList)
END_CLASS

CLASS: UnityEngine.EventSystems.RaycastResult
TYPE:  struct
TOKEN: 0x20000D2
FIELDS:
  private           UnityEngine.GameObject          m_GameObject  // 0x10
  public            UnityEngine.EventSystems.BaseRaycastermodule  // 0x18
  public            System.Single                   distance  // 0x20
  public            System.Single                   index  // 0x24
  public            System.Int32                    depth  // 0x28
  public            System.Int32                    sortingLayer  // 0x2C
  public            System.Int32                    sortingOrder  // 0x30
  public            UnityEngine.Vector3             worldPosition  // 0x34
  public            UnityEngine.Vector3             worldNormal  // 0x40
  public            UnityEngine.Vector2             screenPosition  // 0x4C
  public            System.Int32                    displayIndex  // 0x54
METHODS:
  UnityEngine.GameObject get_gameObject()
  System.Void set_gameObject(UnityEngine.GameObject value)
  System.Boolean get_isValid()
  System.Void Clear()
  System.String ToString()
END_CLASS

CLASS: UnityEngine.EventSystems.UIBehaviour
TYPE:  class
TOKEN: 0x20000D3
EXTENDS: MonoBehaviour
FIELDS:
METHODS:
  System.Void Awake()
  System.Void OnEnable()
  System.Void Start()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Boolean IsActive()
  System.Void OnRectTransformDimensionsChange()
  System.Void OnBeforeTransformParentChanged()
  System.Void OnTransformParentChanged()
  System.Void OnDidApplyAnimationProperties()
  System.Void OnCanvasHierarchyChanged()
  System.Boolean IsDestroyed()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UI.AnimationTriggers
TYPE:  class
TOKEN: 0x2000004
FIELDS:
  private   static  System.String                   kDefaultNormalAnimName  // 0x0
  private   static  System.String                   kDefaultHighlightedAnimName  // 0x0
  private   static  System.String                   kDefaultPressedAnimName  // 0x0
  private   static  System.String                   kDefaultSelectedAnimName  // 0x0
  private   static  System.String                   kDefaultDisabledAnimName  // 0x0
  private           System.String                   m_NormalTrigger  // 0x10
  private           System.String                   m_HighlightedTrigger  // 0x18
  private           System.String                   m_PressedTrigger  // 0x20
  private           System.String                   m_SelectedTrigger  // 0x28
  private           System.String                   m_DisabledTrigger  // 0x30
METHODS:
  System.String get_normalTrigger()
  System.Void set_normalTrigger(System.String value)
  System.String get_highlightedTrigger()
  System.Void set_highlightedTrigger(System.String value)
  System.String get_pressedTrigger()
  System.Void set_pressedTrigger(System.String value)
  System.String get_selectedTrigger()
  System.Void set_selectedTrigger(System.String value)
  System.String get_disabledTrigger()
  System.Void set_disabledTrigger(System.String value)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UI.Button
TYPE:  class
TOKEN: 0x2000005
EXTENDS: Selectable
FIELDS:
  private           UnityEngine.UI.Button.ButtonClickedEventm_OnClick  // 0x180
METHODS:
  System.Void .ctor()
  UnityEngine.UI.Button.ButtonClickedEvent get_onClick()
  System.Void set_onClick(UnityEngine.UI.Button.ButtonClickedEvent value)
  System.Void Press()
  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData)
  System.Collections.IEnumerator OnFinishSubmit()
END_CLASS

CLASS: UnityEngine.UI.CanvasUpdate
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.CanvasUpdate     Prelayout  // 0x0
  public    static  UnityEngine.UI.CanvasUpdate     Layout  // 0x0
  public    static  UnityEngine.UI.CanvasUpdate     PostLayout  // 0x0
  public    static  UnityEngine.UI.CanvasUpdate     PreRender  // 0x0
  public    static  UnityEngine.UI.CanvasUpdate     LatePreRender  // 0x0
  public    static  UnityEngine.UI.CanvasUpdate     MaxUpdateValue  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UI.ICanvasElement
TYPE:  interface
TOKEN: 0x2000009
FIELDS:
METHODS:
  System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing)
  UnityEngine.Transform get_transform()
  System.Void LayoutComplete()
  System.Void GraphicUpdateComplete()
  System.Boolean IsDestroyed()
END_CLASS

CLASS: UnityEngine.UI.CanvasUpdateRegistry
TYPE:  class
TOKEN: 0x200000A
FIELDS:
  private   static  UnityEngine.UI.CanvasUpdateRegistrys_Instance  // 0x0
  private           System.Boolean                  m_PerformingLayoutUpdate  // 0x10
  private           System.Boolean                  m_PerformingGraphicUpdate  // 0x11
  private           Unity.Profiling.ProfilerMarker[]m_CanvasUpdateProfilerStrings  // 0x18
  private   static  System.String                   m_CullingUpdateProfilerString  // 0x0
  private   readonly UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.ICanvasElement>m_LayoutRebuildQueue  // 0x20
  private   readonly UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.ICanvasElement>m_GraphicRebuildQueue  // 0x28
  private   static readonly System.Comparison<UnityEngine.UI.ICanvasElement>s_SortLayoutFunction  // 0x8
METHODS:
  System.Void .ctor()
  UnityEngine.UI.CanvasUpdateRegistry get_instance()
  System.Boolean ObjectValidForUpdate(UnityEngine.UI.ICanvasElement element)
  System.Void CleanInvalidItems()
  System.Void PerformUpdate()
  System.Int32 ParentCount(UnityEngine.Transform child)
  System.Int32 SortLayoutList(UnityEngine.UI.ICanvasElement x, UnityEngine.UI.ICanvasElement y)
  System.Void RegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element)
  System.Boolean TryRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element)
  System.Boolean InternalRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element)
  System.Void RegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element)
  System.Boolean TryRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element)
  System.Boolean InternalRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element)
  System.Void UnRegisterCanvasElementForRebuild(UnityEngine.UI.ICanvasElement element)
  System.Void InternalUnRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element)
  System.Void InternalUnRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element)
  System.Boolean IsRebuildingLayout()
  System.Boolean IsRebuildingGraphics()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UI.ColorBlock
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  private           UnityEngine.Color               m_NormalColor  // 0x10
  private           UnityEngine.Color               m_HighlightedColor  // 0x20
  private           UnityEngine.Color               m_PressedColor  // 0x30
  private           UnityEngine.Color               m_SelectedColor  // 0x40
  private           UnityEngine.Color               m_DisabledColor  // 0x50
  private           System.Single                   m_ColorMultiplier  // 0x60
  private           System.Single                   m_FadeDuration  // 0x64
  public    static  UnityEngine.UI.ColorBlock       defaultColorBlock  // 0x0
METHODS:
  UnityEngine.Color get_normalColor()
  System.Void set_normalColor(UnityEngine.Color value)
  UnityEngine.Color get_highlightedColor()
  System.Void set_highlightedColor(UnityEngine.Color value)
  UnityEngine.Color get_pressedColor()
  System.Void set_pressedColor(UnityEngine.Color value)
  UnityEngine.Color get_selectedColor()
  System.Void set_selectedColor(UnityEngine.Color value)
  UnityEngine.Color get_disabledColor()
  System.Void set_disabledColor(UnityEngine.Color value)
  System.Single get_colorMultiplier()
  System.Void set_colorMultiplier(System.Single value)
  System.Single get_fadeDuration()
  System.Void set_fadeDuration(System.Single value)
  System.Void .cctor()
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(UnityEngine.UI.ColorBlock other)
  System.Boolean op_Equality(UnityEngine.UI.ColorBlock point1, UnityEngine.UI.ColorBlock point2)
  System.Boolean op_Inequality(UnityEngine.UI.ColorBlock point1, UnityEngine.UI.ColorBlock point2)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.UI.ClipperRegistry
TYPE:  class
TOKEN: 0x200000C
FIELDS:
  private   static  UnityEngine.UI.ClipperRegistry  s_Instance  // 0x0
  private   readonly UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.IClipper>m_Clippers  // 0x10
  private   readonly Unity.Profiling.ProfilerMarker  clippersMarker  // 0x18
METHODS:
  System.Void .ctor()
  UnityEngine.UI.ClipperRegistry get_instance()
  System.Void Cull()
  System.Void Register(UnityEngine.UI.IClipper c)
  System.Void Unregister(UnityEngine.UI.IClipper c)
END_CLASS

CLASS: UnityEngine.UI.Clipping
TYPE:  class
TOKEN: 0x200000D
FIELDS:
METHODS:
  UnityEngine.Rect FindCullAndClipWorldRect(System.Collections.Generic.List<UnityEngine.UI.RectMask2D> rectMaskParents, System.Boolean& validRect)
END_CLASS

CLASS: UnityEngine.UI.IClipper
TYPE:  interface
TOKEN: 0x200000E
FIELDS:
METHODS:
  System.Void PerformClipping()
END_CLASS

CLASS: UnityEngine.UI.IClippable
TYPE:  interface
TOKEN: 0x200000F
FIELDS:
METHODS:
  UnityEngine.GameObject get_gameObject()
  System.Void RecalculateClipping()
  UnityEngine.RectTransform get_rectTransform()
  System.Void Cull(UnityEngine.Rect clipRect, System.Boolean validRect)
  System.Void SetClipRect(UnityEngine.Rect value, System.Boolean validRect)
  System.Void SetClipSoftness(UnityEngine.Vector2 clipSoftness)
  System.Void SetHGClipSoftness(UnityEngine.Vector4 hgClipSoftness)
END_CLASS

CLASS: UnityEngine.UI.RectangularVertexClipper
TYPE:  class
TOKEN: 0x2000010
FIELDS:
  private   readonly UnityEngine.Vector3[]           m_WorldCorners  // 0x10
  private   readonly UnityEngine.Vector3[]           m_CanvasCorners  // 0x18
METHODS:
  UnityEngine.Rect GetCanvasRect(UnityEngine.RectTransform t, UnityEngine.Canvas c)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UI.DefaultControls
TYPE:  class
TOKEN: 0x2000011
FIELDS:
  private   static  UnityEngine.UI.DefaultControls.IFactoryControlsm_CurrentFactory  // 0x0
  private   static  System.Single                   kWidth  // 0x0
  private   static  System.Single                   kThickHeight  // 0x0
  private   static  System.Single                   kThinHeight  // 0x0
  private   static  UnityEngine.Vector2             s_ThickElementSize  // 0x8
  private   static  UnityEngine.Vector2             s_ThinElementSize  // 0x10
  private   static  UnityEngine.Vector2             s_ImageElementSize  // 0x18
  private   static  UnityEngine.Color               s_DefaultSelectableColor  // 0x20
  private   static  UnityEngine.Color               s_PanelColor  // 0x30
  private   static  UnityEngine.Color               s_TextColor  // 0x40
METHODS:
  UnityEngine.UI.DefaultControls.IFactoryControls get_factory()
  UnityEngine.GameObject CreateUIElementRoot(System.String name, UnityEngine.Vector2 size, System.Type[] components)
  UnityEngine.GameObject CreateUIObject(System.String name, UnityEngine.GameObject parent, System.Type[] components)
  System.Void SetDefaultTextValues(UnityEngine.UI.Text lbl)
  System.Void SetDefaultColorTransitionValues(UnityEngine.UI.Selectable slider)
  System.Void SetParentAndAlign(UnityEngine.GameObject child, UnityEngine.GameObject parent)
  System.Void SetLayerRecursively(UnityEngine.GameObject go, System.Int32 layer)
  UnityEngine.GameObject CreatePanel(UnityEngine.UI.DefaultControls.Resources resources)
  UnityEngine.GameObject CreateButton(UnityEngine.UI.DefaultControls.Resources resources)
  UnityEngine.GameObject CreateText(UnityEngine.UI.DefaultControls.Resources resources)
  UnityEngine.GameObject CreateImage(UnityEngine.UI.DefaultControls.Resources resources)
  UnityEngine.GameObject CreateRawImage(UnityEngine.UI.DefaultControls.Resources resources)
  UnityEngine.GameObject CreateSlider(UnityEngine.UI.DefaultControls.Resources resources)
  UnityEngine.GameObject CreateScrollbar(UnityEngine.UI.DefaultControls.Resources resources)
  UnityEngine.GameObject CreateToggle(UnityEngine.UI.DefaultControls.Resources resources)
  UnityEngine.GameObject CreateInputField(UnityEngine.UI.DefaultControls.Resources resources)
  UnityEngine.GameObject CreateDropdown(UnityEngine.UI.DefaultControls.Resources resources)
  UnityEngine.GameObject CreateScrollView(UnityEngine.UI.DefaultControls.Resources resources)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UI.Dropdown
TYPE:  class
TOKEN: 0x2000015
EXTENDS: Selectable
FIELDS:
  private           UnityEngine.RectTransform       m_Template  // 0x180
  private           UnityEngine.UI.Text             m_CaptionText  // 0x188
  private           UnityEngine.UI.Image            m_CaptionImage  // 0x190
  private           UnityEngine.UI.Text             m_ItemText  // 0x198
  private           UnityEngine.UI.Image            m_ItemImage  // 0x1A0
  private           System.Int32                    m_Value  // 0x1A8
  private           UnityEngine.UI.Dropdown.OptionDataListm_Options  // 0x1B0
  private           UnityEngine.UI.Dropdown.DropdownEventm_OnValueChanged  // 0x1B8
  private           System.Single                   m_AlphaFadeSpeed  // 0x1C0
  private           UnityEngine.GameObject          m_Dropdown  // 0x1C8
  private           UnityEngine.GameObject          m_Blocker  // 0x1D0
  private           System.Collections.Generic.List<UnityEngine.UI.Dropdown.DropdownItem>m_Items  // 0x1D8
  private           UnityEngine.UI.CoroutineTween.TweenRunner<UnityEngine.UI.CoroutineTween.FloatTween>m_AlphaTweenRunner  // 0x1E0
  private           System.Boolean                  validTemplate  // 0x1E8
  private   static  System.Int32                    kHighSortingLayer  // 0x0
  private   static  UnityEngine.UI.Dropdown.OptionDatas_NoOptionData  // 0x0
METHODS:
  UnityEngine.RectTransform get_template()
  System.Void set_template(UnityEngine.RectTransform value)
  UnityEngine.UI.Text get_captionText()
  System.Void set_captionText(UnityEngine.UI.Text value)
  UnityEngine.UI.Image get_captionImage()
  System.Void set_captionImage(UnityEngine.UI.Image value)
  UnityEngine.UI.Text get_itemText()
  System.Void set_itemText(UnityEngine.UI.Text value)
  UnityEngine.UI.Image get_itemImage()
  System.Void set_itemImage(UnityEngine.UI.Image value)
  System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> get_options()
  System.Void set_options(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> value)
  UnityEngine.UI.Dropdown.DropdownEvent get_onValueChanged()
  System.Void set_onValueChanged(UnityEngine.UI.Dropdown.DropdownEvent value)
  System.Single get_alphaFadeSpeed()
  System.Void set_alphaFadeSpeed(System.Single value)
  System.Int32 get_value()
  System.Void set_value(System.Int32 value)
  System.Void SetValueWithoutNotify(System.Int32 input)
  System.Void Set(System.Int32 value, System.Boolean sendCallback)
  System.Void .ctor()
  System.Void Awake()
  System.Void Start()
  System.Void OnDisable()
  System.Void RefreshShownValue()
  System.Void AddOptions(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> options)
  System.Void AddOptions(System.Collections.Generic.List<System.String> options)
  System.Void AddOptions(System.Collections.Generic.List<UnityEngine.Sprite> options)
  System.Void ClearOptions()
  System.Void SetupTemplate(UnityEngine.Canvas rootCanvas)
  T GetOrAddComponent(UnityEngine.GameObject go)
  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void OnCancel(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void Show()
  UnityEngine.GameObject CreateBlocker(UnityEngine.Canvas rootCanvas)
  System.Void DestroyBlocker(UnityEngine.GameObject blocker)
  UnityEngine.GameObject CreateDropdownList(UnityEngine.GameObject template)
  System.Void DestroyDropdownList(UnityEngine.GameObject dropdownList)
  UnityEngine.UI.Dropdown.DropdownItem CreateItem(UnityEngine.UI.Dropdown.DropdownItem itemTemplate)
  System.Void DestroyItem(UnityEngine.UI.Dropdown.DropdownItem item)
  UnityEngine.UI.Dropdown.DropdownItem AddItem(UnityEngine.UI.Dropdown.OptionData data, System.Boolean selected, UnityEngine.UI.Dropdown.DropdownItem itemTemplate, System.Collections.Generic.List<UnityEngine.UI.Dropdown.DropdownItem> items)
  System.Void AlphaFadeList(System.Single duration, System.Single alpha)
  System.Void AlphaFadeList(System.Single duration, System.Single start, System.Single end)
  System.Void SetAlpha(System.Single alpha)
  System.Void Hide()
  System.Collections.IEnumerator DelayedDestroyDropdownList(System.Single delay)
  System.Void ImmediateDestroyDropdownList()
  System.Void OnSelectItem(UnityEngine.UI.Toggle toggle)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UI.FontData
TYPE:  class
TOKEN: 0x200001C
FIELDS:
  private           UnityEngine.Font                m_Font  // 0x10
  private           System.Int32                    m_FontSize  // 0x18
  private           UnityEngine.FontStyle           m_FontStyle  // 0x1C
  private           System.Boolean                  m_BestFit  // 0x20
  private           System.Int32                    m_MinSize  // 0x24
  private           System.Int32                    m_MaxSize  // 0x28
  private           UnityEngine.TextAnchor          m_Alignment  // 0x2C
  private           System.Boolean                  m_AlignByGeometry  // 0x30
  private           System.Boolean                  m_RichText  // 0x31
  private           UnityEngine.HorizontalWrapMode  m_HorizontalOverflow  // 0x34
  private           UnityEngine.VerticalWrapMode    m_VerticalOverflow  // 0x38
  private           System.Single                   m_LineSpacing  // 0x3C
METHODS:
  UnityEngine.UI.FontData get_defaultFontData()
  UnityEngine.Font get_font()
  System.Void set_font(UnityEngine.Font value)
  System.Int32 get_fontSize()
  System.Void set_fontSize(System.Int32 value)
  UnityEngine.FontStyle get_fontStyle()
  System.Void set_fontStyle(UnityEngine.FontStyle value)
  System.Boolean get_bestFit()
  System.Void set_bestFit(System.Boolean value)
  System.Int32 get_minSize()
  System.Void set_minSize(System.Int32 value)
  System.Int32 get_maxSize()
  System.Void set_maxSize(System.Int32 value)
  UnityEngine.TextAnchor get_alignment()
  System.Void set_alignment(UnityEngine.TextAnchor value)
  System.Boolean get_alignByGeometry()
  System.Void set_alignByGeometry(System.Boolean value)
  System.Boolean get_richText()
  System.Void set_richText(System.Boolean value)
  UnityEngine.HorizontalWrapMode get_horizontalOverflow()
  System.Void set_horizontalOverflow(UnityEngine.HorizontalWrapMode value)
  UnityEngine.VerticalWrapMode get_verticalOverflow()
  System.Void set_verticalOverflow(UnityEngine.VerticalWrapMode value)
  System.Single get_lineSpacing()
  System.Void set_lineSpacing(System.Single value)
  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UI.FontUpdateTracker
TYPE:  class
TOKEN: 0x200001D
FIELDS:
  private   static  System.Collections.Generic.Dictionary<UnityEngine.Font,System.Collections.Generic.HashSet<UnityEngine.UI.Text>>m_Tracked  // 0x0
METHODS:
  System.Void TrackText(UnityEngine.UI.Text t)
  System.Void RebuildForFont(UnityEngine.Font f)
  System.Void UntrackText(UnityEngine.UI.Text t)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UI.Graphic
TYPE:  class
TOKEN: 0x200001E
EXTENDS: UIBehaviour
FIELDS:
  protected static  UnityEngine.Material            s_DefaultUI  // 0x0
  protected static  UnityEngine.Texture2D           s_WhiteTexture  // 0x8
  private   static  System.String                   s_DefaultMaterialName  // 0x10
  private   static  System.String                   s_OverlayShaderKeyword  // 0x18
  protected         UnityEngine.Material            m_Material  // 0x18
  private           UnityEngine.Color               m_Color  // 0x20
  protected         System.Boolean                  m_SkipLayoutUpdate  // 0x30
  protected         System.Boolean                  m_SkipMaterialUpdate  // 0x31
  private           System.Boolean                  m_RaycastTarget  // 0x32
  private           UnityEngine.Vector4             m_RaycastPadding  // 0x34
  private           System.Boolean                  m_RaycastIgnoreMask  // 0x44
  private           UnityEngine.RectTransform       m_RectTransform  // 0x48
  private           UnityEngine.CanvasRenderer      m_CanvasRenderer  // 0x50
  private           UnityEngine.Canvas              m_Canvas  // 0x58
  private           System.Boolean                  m_VertsDirty  // 0x60
  private           System.Boolean                  m_MaterialDirty  // 0x61
  protected         UnityEngine.Events.UnityAction  m_OnDirtyLayoutCallback  // 0x68
  protected         UnityEngine.Events.UnityAction  m_OnDirtyVertsCallback  // 0x70
  protected         UnityEngine.Events.UnityAction  m_OnDirtyMaterialCallback  // 0x78
  protected static  UnityEngine.Mesh                s_Mesh  // 0x20
  private   static readonly UnityEngine.UI.VertexHelper     s_VertexHelper  // 0x28
  protected         UnityEngine.Mesh                m_CachedMesh  // 0x80
  protected         UnityEngine.Vector2[]           m_CachedUvs  // 0x88
  private           UnityEngine.UI.CoroutineTween.TweenRunner<UnityEngine.UI.CoroutineTween.ColorTween>m_ColorTweenRunnerLazy  // 0x90
  protected         System.Boolean                  m_EnableRuntimeAtlas  // 0x98
  protected         UnityEngine.Texture             m_RuntimeAtlasTexture  // 0xA0
  private           System.Boolean                  <useLegacyMeshGeneration>k__BackingField  // 0xA8
METHODS:
  System.String get_defaultMaterialName()
  System.Void set_defaultMaterialName(System.String value)
  UnityEngine.Material get_defaultGraphicMaterial()
  System.String get_overlayShaderKeyword()
  System.Void set_overlayShaderKeyword(System.String value)
  UnityEngine.Color get_color()
  System.Void set_color(UnityEngine.Color value)
  System.Boolean get_raycastTarget()
  System.Void set_raycastTarget(System.Boolean value)
  UnityEngine.Vector4 get_raycastPadding()
  System.Void set_raycastPadding(UnityEngine.Vector4 value)
  UnityEngine.UI.CoroutineTween.TweenRunner<UnityEngine.UI.CoroutineTween.ColorTween> get_m_ColorTweenRunner()
  System.Boolean get_enableRuntimeAtlas()
  System.Void set_enableRuntimeAtlas(System.Boolean value)
  UnityEngine.Texture get_runtimeAtlasTexture()
  System.Void set_runtimeAtlasTexture(UnityEngine.Texture value)
  System.Boolean get_useLegacyMeshGeneration()
  System.Void set_useLegacyMeshGeneration(System.Boolean value)
  System.Void .ctor()
  System.Void SetAllDirty()
  System.Void SetLayoutDirty()
  System.Void SetVerticesDirty()
  System.Void SetMaterialDirty()
  System.Void OnRectTransformDimensionsChange()
  System.Void OnBeforeTransformParentChanged()
  System.Void OnTransformParentChanged()
  System.Int32 get_depth()
  UnityEngine.RectTransform get_rectTransform()
  UnityEngine.Canvas get_canvas()
  System.Void CacheCanvas()
  UnityEngine.CanvasRenderer get_canvasRenderer()
  UnityEngine.Material get_defaultMaterial()
  UnityEngine.Material get_material()
  System.Void set_material(UnityEngine.Material value)
  UnityEngine.Material get_materialForRendering()
  UnityEngine.Texture get_mainTexture()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void OnCanvasHierarchyChanged()
  System.Void OnCullingChanged()
  System.Void Rebuild(UnityEngine.UI.CanvasUpdate update)
  System.Void LayoutComplete()
  System.Void GraphicUpdateComplete()
  System.Void UpdateMaterial()
  System.Void UpdateGeometry()
  System.Void DoMeshGeneration()
  System.Void DoLegacyMeshGeneration()
  UnityEngine.Mesh get_workerMesh()
  System.Void OnFillVBO(System.Collections.Generic.List<UnityEngine.UIVertex> vbo)
  System.Void OnPopulateMesh(UnityEngine.Mesh m)
  System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
  System.Void OnDidApplyAnimationProperties()
  System.Void SetNativeSize()
  System.Boolean Raycast(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera)
  UnityEngine.Vector2 PixelAdjustPoint(UnityEngine.Vector2 point)
  UnityEngine.Rect GetPixelAdjustedRect()
  System.Void CrossFadeColor(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha)
  System.Void CrossFadeColor(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, System.Boolean useRGB)
  UnityEngine.Color CreateColorFromAlpha(System.Single alpha)
  System.Void CrossFadeAlpha(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale)
  System.Void RegisterDirtyLayoutCallback(UnityEngine.Events.UnityAction action)
  System.Void UnregisterDirtyLayoutCallback(UnityEngine.Events.UnityAction action)
  System.Void RegisterDirtyVerticesCallback(UnityEngine.Events.UnityAction action)
  System.Void UnregisterDirtyVerticesCallback(UnityEngine.Events.UnityAction action)
  System.Void RegisterDirtyMaterialCallback(UnityEngine.Events.UnityAction action)
  System.Void UnregisterDirtyMaterialCallback(UnityEngine.Events.UnityAction action)
  System.Void .cctor()
  UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform()
END_CLASS

CLASS: UnityEngine.UI.GraphicRaycaster
TYPE:  class
TOKEN: 0x200001F
EXTENDS: BaseRaycaster
FIELDS:
  protected static  System.Int32                    kNoEventMaskSet  // 0x0
  private           System.Boolean                  m_IgnoreReversedGraphics  // 0x20
  private           UnityEngine.UI.GraphicRaycaster.BlockingObjectsm_BlockingObjects  // 0x24
  protected         UnityEngine.LayerMask           m_BlockingMask  // 0x28
  private           UnityEngine.Canvas              m_Canvas  // 0x30
  private           System.Collections.Generic.List<UnityEngine.UI.Graphic>m_RaycastResults  // 0x38
  private   static readonly System.Collections.Generic.List<UnityEngine.UI.Graphic>s_SortedGraphics  // 0x0
METHODS:
  System.Int32 get_sortOrderPriority()
  System.Int32 get_renderOrderPriority()
  System.Boolean get_ignoreReversedGraphics()
  System.Void set_ignoreReversedGraphics(System.Boolean value)
  UnityEngine.UI.GraphicRaycaster.BlockingObjects get_blockingObjects()
  System.Void set_blockingObjects(UnityEngine.UI.GraphicRaycaster.BlockingObjects value)
  UnityEngine.LayerMask get_blockingMask()
  System.Void set_blockingMask(UnityEngine.LayerMask value)
  System.Void .ctor()
  UnityEngine.Canvas get_canvas()
  System.Void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList)
  UnityEngine.Camera get_eventCamera()
  System.Void Raycast(UnityEngine.Canvas canvas, UnityEngine.Camera eventCamera, UnityEngine.Vector2 pointerPosition, System.Collections.Generic.IList<UnityEngine.UI.Graphic> foundGraphics, System.Collections.Generic.List<UnityEngine.UI.Graphic> results)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UI.GraphicRegistry
TYPE:  class
TOKEN: 0x2000022
FIELDS:
  private   static  UnityEngine.UI.GraphicRegistry  s_Instance  // 0x0
  private   readonly System.Collections.Generic.Dictionary<UnityEngine.Canvas,UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.Graphic>>m_Graphics  // 0x10
  private   readonly System.Collections.Generic.Dictionary<UnityEngine.Canvas,UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.Graphic>>m_RaycastableGraphics  // 0x18
  private   static readonly System.Collections.Generic.List<UnityEngine.UI.Graphic>s_EmptyList  // 0x8
METHODS:
  System.Void .ctor()
  UnityEngine.UI.GraphicRegistry get_instance()
  System.Void RegisterGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic)
  System.Void RegisterRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic)
  System.Void UnregisterGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic)
  System.Void UnregisterRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic)
  System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetGraphicsForCanvas(UnityEngine.Canvas canvas)
  System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetRaycastableGraphicsForCanvas(UnityEngine.Canvas canvas)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UI.IGraphicEnabledDisabled
TYPE:  interface
TOKEN: 0x2000023
FIELDS:
METHODS:
  System.Void OnSiblingGraphicEnabledDisabled()
END_CLASS

CLASS: UnityEngine.UI.Image
TYPE:  class
TOKEN: 0x2000024
EXTENDS: MaskableGraphic
FIELDS:
  protected static  UnityEngine.Material            s_ETC1DefaultUI  // 0x0
  private           UnityEngine.Sprite              m_Sprite  // 0xE8
  protected         UnityEngine.Rect                m_RuntimeAtlasRect  // 0xF0
  protected         UnityEngine.Rect                m_RuntimeAtlasTextureRect  // 0x100
  protected         UnityEngine.Vector4             m_RuntimeAtlasBorder  // 0x110
  protected         System.Single                   m_RuntimeAtlasPixelsPerUnit  // 0x120
  private           UnityEngine.Sprite              m_OverrideSprite  // 0x128
  private           UnityEngine.UI.Image.Type       m_Type  // 0x130
  private           System.Boolean                  m_PreserveAspect  // 0x134
  private           System.Boolean                  m_FillCenter  // 0x135
  private           UnityEngine.UI.Image.FillMethod m_FillMethod  // 0x138
  private           System.Single                   m_FillAmount  // 0x13C
  private           System.Boolean                  m_FillClockwise  // 0x140
  private           System.Int32                    m_FillOrigin  // 0x144
  private           System.Single                   m_AlphaHitTestMinimumThreshold  // 0x148
  private           System.Boolean                  m_Tracked  // 0x14C
  private           System.Boolean                  m_UseSpriteMesh  // 0x14D
  private           System.Single                   m_PixelsPerUnitMultiplier  // 0x150
  private           System.Single                   m_CachedReferencePixelsPerUnit  // 0x154
  public            UnityEngine.UI.Image.SlicedSpriteParamsslicedSpriteParams  // 0x158
  private           System.Boolean                  bAwakeOnce  // 0x17C
  private   static readonly UnityEngine.Vector2[]           s_VertScratch  // 0x8
  private   static readonly UnityEngine.Vector2[]           s_UVScratch  // 0x10
  private   static  System.Int32                    QuadCount  // 0x0
  private   static readonly UnityEngine.Vector3[]           s_Xy  // 0x18
  private   static readonly UnityEngine.Vector3[]           s_Uv  // 0x20
  private   static  System.Collections.Generic.List<UnityEngine.UI.Image>m_TrackedTexturelessImages  // 0x28
  private   static  System.Boolean                  s_Initialized  // 0x30
  protected static  System.Int32                    VALIDATE_MAX_VERT_COUNT  // 0x0
  private           UnityEngine.UI.Image.EDynamicAtlasActiveModem_DynamicAtlasActiveMode  // 0x17D
  protected         System.Boolean                  _packIntoRuntimeAtlas  // 0x17E
  protected         System.Int32                    m_panelLevel  // 0x180
  public            System.Boolean                  keepOriginUV  // 0x184
  private           System.Action                   dynamicAtlasCallBack  // 0x188
  private   static  System.Boolean                  _sDynamicAtlasInitialized  // 0x31
  private   static readonly System.Collections.Generic.List<UnityEngine.UI.Image>s_FreeList  // 0x38
  private   static readonly System.Collections.Generic.HashSet<UnityEngine.UI.Image>s_TrackedDynamicAtlasImages  // 0x40
  private   static readonly System.Collections.Generic.List<UnityEngine.UI.Image>s_FreeListRevert  // 0x48
  private   static readonly System.Collections.Generic.HashSet<UnityEngine.UI.Image>s_TrackedDynamicAtlasSpriteRevert  // 0x50
  public    static  System.Boolean                  s_AtlasV2  // 0x58
METHODS:
  UnityEngine.Rect get_runtimeAtlasRect()
  System.Void set_runtimeAtlasRect(UnityEngine.Rect value)
  UnityEngine.Rect get_runtimeAtlasTextureRect()
  System.Void set_runtimeAtlasTextureRect(UnityEngine.Rect value)
  UnityEngine.Vector4 get_runtimeAtlasBorder()
  System.Void set_runtimeAtlasBorder(UnityEngine.Vector4 value)
  System.Single get_runtimeAtlasPixelsPerUnit()
  System.Void set_runtimeAtlasPixelsPerUnit(System.Single value)
  UnityEngine.Sprite get_sprite()
  System.Void set_sprite(UnityEngine.Sprite value)
  System.Boolean get_enableRuntimeAtlasRaw()
  System.Boolean get_enableRuntimeAtlas()
  System.Void set_enableRuntimeAtlas(System.Boolean value)
  System.Void ReleaseSprite()
  System.Void _OnSpriteChanged(UnityEngine.Sprite oldOne)
  System.Void DisableSpriteOptimizations()
  UnityEngine.Sprite get_overrideSprite()
  System.Void set_overrideSprite(UnityEngine.Sprite value)
  UnityEngine.Sprite get_activeSprite()
  UnityEngine.UI.Image.Type get_type()
  System.Void set_type(UnityEngine.UI.Image.Type value)
  System.Boolean get_preserveAspect()
  System.Void set_preserveAspect(System.Boolean value)
  System.Boolean get_fillCenter()
  System.Void set_fillCenter(System.Boolean value)
  UnityEngine.UI.Image.FillMethod get_fillMethod()
  System.Void set_fillMethod(UnityEngine.UI.Image.FillMethod value)
  System.Single get_fillAmount()
  System.Void set_fillAmount(System.Single value)
  System.Boolean get_fillClockwise()
  System.Void set_fillClockwise(System.Boolean value)
  System.Int32 get_fillOrigin()
  System.Void set_fillOrigin(System.Int32 value)
  System.Single get_eventAlphaThreshold()
  System.Void set_eventAlphaThreshold(System.Single value)
  System.Single get_alphaHitTestMinimumThreshold()
  System.Void set_alphaHitTestMinimumThreshold(System.Single value)
  System.Boolean get_useSpriteMesh()
  System.Void set_useSpriteMesh(System.Boolean value)
  System.Void .ctor()
  UnityEngine.Material get_defaultETC1GraphicMaterial()
  UnityEngine.Texture get_mainTexture()
  System.Boolean get_hasBorder()
  System.Single get_pixelsPerUnitMultiplier()
  System.Void set_pixelsPerUnitMultiplier(System.Single value)
  System.Single get_pixelsPerUnit()
  System.Single get_multipliedPixelsPerUnit()
  UnityEngine.Material get_material()
  System.Void set_material(UnityEngine.Material value)
  System.Void OnBeforeSerialize()
  System.Void OnAfterDeserialize()
  System.Void PreserveSpriteAspectRatio(UnityEngine.Rect& rect, UnityEngine.Vector2 spriteSize)
  UnityEngine.Vector4 GetDrawingDimensions(System.Boolean shouldPreserveAspect)
  System.Void SetNativeSize()
  System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper toFill)
  System.Void TrackSprite()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Awake()
  System.Void OnDestroy()
  System.Void UpdateMaterial()
  System.Void OnCanvasHierarchyChanged()
  System.Void GenerateSimpleSprite(UnityEngine.UI.VertexHelper vh, System.Boolean lPreserveAspect)
  System.Void GenerateSprite(UnityEngine.UI.VertexHelper vh, System.Boolean lPreserveAspect)
  System.Void GenerateSlicedSprite(UnityEngine.UI.VertexHelper toFill)
  System.Void GenerateTiledSprite(UnityEngine.UI.VertexHelper toFill)
  System.Void GenerateMirrorSprite(UnityEngine.UI.VertexHelper toFill)
  System.Void GenerateMirrorQuarter(UnityEngine.UI.VertexHelper toFill)
  System.Void AddQuad(UnityEngine.UI.VertexHelper vertexHelper, UnityEngine.Vector3[] quadPositions, UnityEngine.Color32 color, UnityEngine.Vector3[] quadUVs)
  System.Void AddQuad(UnityEngine.UI.VertexHelper vertexHelper, UnityEngine.Vector2 posMin, UnityEngine.Vector2 posMax, UnityEngine.Color32 color, UnityEngine.Vector2 uvMin, UnityEngine.Vector2 uvMax)
  UnityEngine.Vector4 GetAdjustedBorders(UnityEngine.Vector4 border, UnityEngine.Rect adjustedRect)
  System.Void GenerateFilledSprite(UnityEngine.UI.VertexHelper toFill, System.Boolean preserveAspect)
  System.Boolean RadialCut(UnityEngine.Vector3[] xy, UnityEngine.Vector3[] uv, System.Single fill, System.Boolean invert, System.Int32 corner)
  System.Void RadialCut(UnityEngine.Vector3[] xy, System.Single cos, System.Single sin, System.Boolean invert, System.Int32 corner)
  System.Void CalculateLayoutInputHorizontal()
  System.Void CalculateLayoutInputVertical()
  System.Single get_minWidth()
  System.Single get_preferredWidth()
  System.Single get_flexibleWidth()
  System.Single get_minHeight()
  System.Single get_preferredHeight()
  System.Single get_flexibleHeight()
  System.Int32 get_layoutPriority()
  System.Boolean IsRaycastLocationValid(UnityEngine.Vector2 screenPoint, UnityEngine.Camera eventCamera)
  UnityEngine.Vector2 MapCoordinate(UnityEngine.Vector2 local, UnityEngine.Rect rect)
  System.Void RebuildImage(UnityEngine.U2D.SpriteAtlas spriteAtlas)
  System.Void TrackImage(UnityEngine.UI.Image g)
  System.Void UnTrackImage(UnityEngine.UI.Image g)
  System.Void OnDidApplyAnimationProperties()
  UnityEngine.Vector4 GetRuntimeAtlasSpritePadding()
  UnityEngine.Vector4 GetRuntimeAtlasSpriteOuterUV()
  UnityEngine.Vector4 GetRuntimeAtlasSpriteInnerUV()
  System.String GetParticlePath()
  UnityEngine.UI.Image.EDynamicAtlasActiveMode get_DynamicAtlasActiveMode()
  System.Void RegisterDynamicAtlas()
  System.Void UnRegisterDynamicAtlas(UnityEngine.Sprite _sprite)
  System.Void RegisterDynamicAtlasCallBack(System.Action cb)
  System.Void UnRegisterDynamicAtlasCallBack(System.Action cb)
  System.Void _CanvasRreWillRenderCanvases()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UI.IMask
TYPE:  interface
TOKEN: 0x200002E
FIELDS:
METHODS:
  System.Boolean Enabled()
  UnityEngine.RectTransform get_rectTransform()
END_CLASS

CLASS: UnityEngine.UI.IMaskable
TYPE:  interface
TOKEN: 0x200002F
FIELDS:
METHODS:
  System.Void RecalculateMasking()
END_CLASS

CLASS: UnityEngine.UI.InputField
TYPE:  class
TOKEN: 0x2000030
EXTENDS: Selectable
FIELDS:
  protected         UnityEngine.TouchScreenKeyboard m_Keyboard  // 0x180
  private   static readonly System.Char[]                   kSeparators  // 0x0
  private   static  System.Boolean                  s_IsQuestDevice  // 0x8
  protected         UnityEngine.UI.Text             m_TextComponent  // 0x188
  protected         UnityEngine.UI.Graphic          m_Placeholder  // 0x190
  private           UnityEngine.UI.InputField.ContentTypem_ContentType  // 0x198
  private           UnityEngine.UI.InputField.InputTypem_InputType  // 0x19C
  private           System.Char                     m_AsteriskChar  // 0x1A0
  private           UnityEngine.TouchScreenKeyboardTypem_KeyboardType  // 0x1A4
  private           UnityEngine.UI.InputField.LineTypem_LineType  // 0x1A8
  private           System.Boolean                  m_HideMobileInput  // 0x1AC
  private           UnityEngine.UI.InputField.CharacterValidationm_CharacterValidation  // 0x1B0
  private           System.Int32                    m_CharacterLimit  // 0x1B4
  private           UnityEngine.UI.InputField.SubmitEventm_OnSubmit  // 0x1B8
  private           UnityEngine.UI.InputField.EndEditEventm_OnDidEndEdit  // 0x1C0
  private           UnityEngine.UI.InputField.OnChangeEventm_OnValueChanged  // 0x1C8
  private           UnityEngine.UI.InputField.OnValidateInputm_OnValidateInput  // 0x1D0
  private           UnityEngine.Color               m_CaretColor  // 0x1D8
  private           System.Boolean                  m_CustomCaretColor  // 0x1E8
  private           UnityEngine.Color               m_SelectionColor  // 0x1EC
  protected         System.String                   m_Text  // 0x200
  private           System.Single                   m_CaretBlinkRate  // 0x208
  private           System.Int32                    m_CaretWidth  // 0x20C
  private           System.Boolean                  m_ReadOnly  // 0x210
  private           System.Boolean                  m_ShouldActivateOnSelect  // 0x211
  protected         System.Int32                    m_CaretPosition  // 0x214
  protected         System.Int32                    m_CaretSelectPosition  // 0x218
  private           UnityEngine.RectTransform       caretRectTrans  // 0x220
  protected         UnityEngine.UIVertex[]          m_CursorVerts  // 0x228
  private           UnityEngine.TextGenerator       m_InputTextCache  // 0x230
  private           UnityEngine.CanvasRenderer      m_CachedInputRenderer  // 0x238
  private           System.Boolean                  m_PreventFontCallback  // 0x240
  protected         UnityEngine.Mesh                m_Mesh  // 0x248
  private           System.Boolean                  m_AllowInput  // 0x250
  private           System.Boolean                  m_ShouldActivateNextUpdate  // 0x251
  private           System.Boolean                  m_UpdateDrag  // 0x252
  private           System.Boolean                  m_DragPositionOutOfBounds  // 0x253
  private   static  System.Single                   kHScrollSpeed  // 0x0
  private   static  System.Single                   kVScrollSpeed  // 0x0
  protected         System.Boolean                  m_CaretVisible  // 0x254
  private           UnityEngine.Coroutine           m_BlinkCoroutine  // 0x258
  private           System.Single                   m_BlinkStartTime  // 0x260
  protected         System.Int32                    m_DrawStart  // 0x264
  protected         System.Int32                    m_DrawEnd  // 0x268
  private           UnityEngine.Coroutine           m_DragCoroutine  // 0x270
  private           System.String                   m_OriginalText  // 0x278
  private           System.Boolean                  m_WasCanceled  // 0x280
  private           System.Boolean                  m_HasDoneFocusTransition  // 0x281
  private           UnityEngine.WaitForSecondsRealtimem_WaitForSecondsRealtime  // 0x288
  private           System.Boolean                  m_TouchKeyboardAllowsInPlaceEditing  // 0x290
  private           System.Boolean                  m_IsCompositionActive  // 0x291
  private   static  System.String                   kEmailSpecialCharacters  // 0x0
  private   static  System.String                   kOculusQuestDeviceModel  // 0x0
  private           UnityEngine.Event               m_ProcessingEvent  // 0x298
  private   static  System.Int32                    k_MaxTextLength  // 0x0
METHODS:
  UnityEngine.EventSystems.BaseInput get_input()
  System.String get_compositionString()
  System.Void .ctor()
  UnityEngine.Mesh get_mesh()
  UnityEngine.TextGenerator get_cachedInputTextGenerator()
  System.Void set_shouldHideMobileInput(System.Boolean value)
  System.Boolean get_shouldHideMobileInput()
  System.Void set_shouldActivateOnSelect(System.Boolean value)
  System.Boolean get_shouldActivateOnSelect()
  System.String get_text()
  System.Void set_text(System.String value)
  System.Void SetTextWithoutNotify(System.String input)
  System.Void SetText(System.String value, System.Boolean sendCallback)
  System.Boolean get_isFocused()
  System.Single get_caretBlinkRate()
  System.Void set_caretBlinkRate(System.Single value)
  System.Int32 get_caretWidth()
  System.Void set_caretWidth(System.Int32 value)
  UnityEngine.UI.Text get_textComponent()
  System.Void set_textComponent(UnityEngine.UI.Text value)
  UnityEngine.UI.Graphic get_placeholder()
  System.Void set_placeholder(UnityEngine.UI.Graphic value)
  UnityEngine.Color get_caretColor()
  System.Void set_caretColor(UnityEngine.Color value)
  System.Boolean get_customCaretColor()
  System.Void set_customCaretColor(System.Boolean value)
  UnityEngine.Color get_selectionColor()
  System.Void set_selectionColor(UnityEngine.Color value)
  UnityEngine.UI.InputField.EndEditEvent get_onEndEdit()
  System.Void set_onEndEdit(UnityEngine.UI.InputField.EndEditEvent value)
  UnityEngine.UI.InputField.SubmitEvent get_onSubmit()
  System.Void set_onSubmit(UnityEngine.UI.InputField.SubmitEvent value)
  UnityEngine.UI.InputField.OnChangeEvent get_onValueChange()
  System.Void set_onValueChange(UnityEngine.UI.InputField.OnChangeEvent value)
  UnityEngine.UI.InputField.OnChangeEvent get_onValueChanged()
  System.Void set_onValueChanged(UnityEngine.UI.InputField.OnChangeEvent value)
  UnityEngine.UI.InputField.OnValidateInput get_onValidateInput()
  System.Void set_onValidateInput(UnityEngine.UI.InputField.OnValidateInput value)
  System.Int32 get_characterLimit()
  System.Void set_characterLimit(System.Int32 value)
  UnityEngine.UI.InputField.ContentType get_contentType()
  System.Void set_contentType(UnityEngine.UI.InputField.ContentType value)
  UnityEngine.UI.InputField.LineType get_lineType()
  System.Void set_lineType(UnityEngine.UI.InputField.LineType value)
  UnityEngine.UI.InputField.InputType get_inputType()
  System.Void set_inputType(UnityEngine.UI.InputField.InputType value)
  UnityEngine.TouchScreenKeyboard get_touchScreenKeyboard()
  UnityEngine.TouchScreenKeyboardType get_keyboardType()
  System.Void set_keyboardType(UnityEngine.TouchScreenKeyboardType value)
  UnityEngine.UI.InputField.CharacterValidation get_characterValidation()
  System.Void set_characterValidation(UnityEngine.UI.InputField.CharacterValidation value)
  System.Boolean get_readOnly()
  System.Void set_readOnly(System.Boolean value)
  System.Boolean get_multiLine()
  System.Char get_asteriskChar()
  System.Void set_asteriskChar(System.Char value)
  System.Boolean get_wasCanceled()
  System.Void ClampPos(System.Int32& pos)
  System.Int32 get_caretPositionInternal()
  System.Void set_caretPositionInternal(System.Int32 value)
  System.Int32 get_caretSelectPositionInternal()
  System.Void set_caretSelectPositionInternal(System.Int32 value)
  System.Boolean get_hasSelection()
  System.Int32 get_caretPosition()
  System.Void set_caretPosition(System.Int32 value)
  System.Int32 get_selectionAnchorPosition()
  System.Void set_selectionAnchorPosition(System.Int32 value)
  System.Int32 get_selectionFocusPosition()
  System.Void set_selectionFocusPosition(System.Int32 value)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Collections.IEnumerator CaretBlink()
  System.Void SetCaretVisible()
  System.Void SetCaretActive()
  System.Void UpdateCaretMaterial()
  System.Void OnFocus()
  System.Void SelectAll()
  System.Void MoveTextEnd(System.Boolean shift)
  System.Void MoveTextStart(System.Boolean shift)
  System.String get_clipboard()
  System.Void set_clipboard(System.String value)
  System.Boolean TouchScreenKeyboardShouldBeUsed()
  System.Boolean InPlaceEditing()
  System.Boolean InPlaceEditingChanged()
  System.Void UpdateCaretFromKeyboard()
  System.Void LateUpdate()
  UnityEngine.Vector2 ScreenToLocal(UnityEngine.Vector2 screen)
  System.Int32 GetUnclampedCharacterLineFromPosition(UnityEngine.Vector2 pos, UnityEngine.TextGenerator generator)
  System.Int32 GetCharacterIndexFromPosition(UnityEngine.Vector2 pos)
  System.Boolean MayDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Collections.IEnumerator MouseDragOutsideRect(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  UnityEngine.UI.InputField.EditState KeyPressed(UnityEngine.Event evt)
  System.Boolean IsValidChar(System.Char c)
  System.Void ProcessEvent(UnityEngine.Event e)
  System.Void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData)
  System.String GetSelectedString()
  System.Int32 FindtNextWordBegin()
  System.Void MoveRight(System.Boolean shift, System.Boolean ctrl)
  System.Int32 FindtPrevWordBegin()
  System.Void MoveLeft(System.Boolean shift, System.Boolean ctrl)
  System.Int32 DetermineCharacterLine(System.Int32 charPos, UnityEngine.TextGenerator generator)
  System.Int32 LineUpCharacterPosition(System.Int32 originalPos, System.Boolean goToFirstChar)
  System.Int32 LineDownCharacterPosition(System.Int32 originalPos, System.Boolean goToLastChar)
  System.Void MoveDown(System.Boolean shift)
  System.Void MoveDown(System.Boolean shift, System.Boolean goToLastChar)
  System.Void MoveUp(System.Boolean shift)
  System.Void MoveUp(System.Boolean shift, System.Boolean goToFirstChar)
  System.Void Delete()
  System.Void ForwardSpace()
  System.Void Backspace()
  System.Void Insert(System.Char c)
  System.Void UpdateTouchKeyboardFromEditChanges()
  System.Void SendOnValueChangedAndUpdateLabel()
  System.Void SendOnValueChanged()
  System.Void SendOnEndEdit()
  System.Void SendOnSubmit()
  System.Void Append(System.String input)
  System.Void Append(System.Char input)
  System.Void UpdateLabel()
  System.Boolean IsSelectionVisible()
  System.Int32 GetLineStartPosition(UnityEngine.TextGenerator gen, System.Int32 line)
  System.Int32 GetLineEndPosition(UnityEngine.TextGenerator gen, System.Int32 line)
  System.Void SetDrawRangeToContainCaretPosition(System.Int32 caretPos)
  System.Void ForceLabelUpdate()
  System.Void MarkGeometryAsDirty()
  System.Void Rebuild(UnityEngine.UI.CanvasUpdate update)
  System.Void LayoutComplete()
  System.Void GraphicUpdateComplete()
  System.Void UpdateGeometry()
  System.Void AssignPositioningIfNeeded()
  System.Void OnFillVBO(UnityEngine.Mesh vbo)
  System.Void GenerateCaret(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset)
  System.Void CreateCursorVerts()
  System.Void GenerateHighlight(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset)
  System.Char Validate(System.String text, System.Int32 pos, System.Char ch)
  System.Void ActivateInputField()
  System.Void ActivateInputFieldInternal()
  System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void DeactivateInputField()
  System.Void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void EnforceContentType()
  System.Void EnforceTextHOverflow()
  System.Void SetToCustomIfContentTypeIsNot(UnityEngine.UI.InputField.ContentType[] allowedContentTypes)
  System.Void SetToCustom()
  System.Void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, System.Boolean instant)
  System.Void CalculateLayoutInputHorizontal()
  System.Void CalculateLayoutInputVertical()
  System.Single get_minWidth()
  System.Single get_preferredWidth()
  System.Single get_flexibleWidth()
  System.Single get_minHeight()
  System.Single get_preferredHeight()
  System.Single get_flexibleHeight()
  System.Int32 get_layoutPriority()
  System.Void .cctor()
  UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform()
END_CLASS

CLASS: UnityEngine.UI.AspectRatioFitter
TYPE:  class
TOKEN: 0x200003C
EXTENDS: UIBehaviour
FIELDS:
  private           UnityEngine.UI.AspectRatioFitter.AspectModem_AspectMode  // 0x18
  private           System.Single                   m_AspectRatio  // 0x1C
  private           UnityEngine.RectTransform       m_Rect  // 0x20
  private           System.Boolean                  m_DelayedSetDirty  // 0x28
  private           System.Boolean                  m_DoesParentExist  // 0x29
  private           UnityEngine.DrivenRectTransformTrackerm_Tracker  // 0x2A
METHODS:
  UnityEngine.UI.AspectRatioFitter.AspectMode get_aspectMode()
  System.Void set_aspectMode(UnityEngine.UI.AspectRatioFitter.AspectMode value)
  System.Single get_aspectRatio()
  System.Void set_aspectRatio(System.Single value)
  UnityEngine.RectTransform get_rectTransform()
  System.Void .ctor()
  System.Void OnEnable()
  System.Void Start()
  System.Void OnDisable()
  System.Void OnTransformParentChanged()
  System.Void Update()
  System.Void OnRectTransformDimensionsChange()
  System.Void UpdateRect()
  System.Single GetSizeDeltaToProduceSize(System.Single size, System.Int32 axis)
  UnityEngine.Vector2 GetParentSize()
  System.Void SetLayoutHorizontal()
  System.Void SetLayoutVertical()
  System.Void SetDirty()
  System.Boolean IsComponentValidOnObject()
  System.Boolean IsAspectModeValid()
  System.Boolean DoesParentExists()
END_CLASS

CLASS: UnityEngine.UI.CanvasScaler
TYPE:  class
TOKEN: 0x200003E
EXTENDS: UIBehaviour
FIELDS:
  private           UnityEngine.UI.CanvasScaler.ScaleModem_UiScaleMode  // 0x18
  protected         System.Single                   m_ReferencePixelsPerUnit  // 0x1C
  protected         System.Single                   m_ScaleFactor  // 0x20
  protected         UnityEngine.Vector2             m_ReferenceResolution  // 0x24
  protected         UnityEngine.UI.CanvasScaler.ScreenMatchModem_ScreenMatchMode  // 0x2C
  protected         System.Single                   m_MatchWidthOrHeight  // 0x30
  private   static  System.Single                   kLogBase  // 0x0
  protected         UnityEngine.UI.CanvasScaler.Unitm_PhysicalUnit  // 0x34
  protected         System.Single                   m_FallbackScreenDPI  // 0x38
  protected         System.Single                   m_DefaultSpriteDPI  // 0x3C
  protected         System.Single                   m_DynamicPixelsPerUnit  // 0x40
  private           UnityEngine.Canvas              m_Canvas  // 0x48
  private           System.Single                   m_PrevScaleFactor  // 0x50
  private           System.Single                   m_PrevReferencePixelsPerUnit  // 0x54
  protected         System.Boolean                  m_PresetInfoIsWorld  // 0x58
METHODS:
  UnityEngine.UI.CanvasScaler.ScaleMode get_uiScaleMode()
  System.Void set_uiScaleMode(UnityEngine.UI.CanvasScaler.ScaleMode value)
  System.Single get_referencePixelsPerUnit()
  System.Void set_referencePixelsPerUnit(System.Single value)
  System.Single get_scaleFactor()
  System.Void set_scaleFactor(System.Single value)
  UnityEngine.Vector2 get_referenceResolution()
  System.Void set_referenceResolution(UnityEngine.Vector2 value)
  UnityEngine.UI.CanvasScaler.ScreenMatchMode get_screenMatchMode()
  System.Void set_screenMatchMode(UnityEngine.UI.CanvasScaler.ScreenMatchMode value)
  System.Single get_matchWidthOrHeight()
  System.Void set_matchWidthOrHeight(System.Single value)
  UnityEngine.UI.CanvasScaler.Unit get_physicalUnit()
  System.Void set_physicalUnit(UnityEngine.UI.CanvasScaler.Unit value)
  System.Single get_fallbackScreenDPI()
  System.Void set_fallbackScreenDPI(System.Single value)
  System.Single get_defaultSpriteDPI()
  System.Void set_defaultSpriteDPI(System.Single value)
  System.Single get_dynamicPixelsPerUnit()
  System.Void set_dynamicPixelsPerUnit(System.Single value)
  System.Void .ctor()
  System.Void OnEnable()
  System.Void Canvas_preWillRenderCanvases()
  System.Void OnDisable()
  System.Void HandleManually()
  System.Void Handle()
  System.Void HandleWorldCanvas()
  System.Void HandleConstantPixelSize()
  System.Void HandleScaleWithScreenSize()
  System.Void HandleConstantPhysicalSize()
  System.Void SetScaleFactor(System.Single scaleFactor)
  System.Void SetReferencePixelsPerUnit(System.Single referencePixelsPerUnit)
END_CLASS

CLASS: UnityEngine.UI.ContentSizeFitter
TYPE:  class
TOKEN: 0x2000042
EXTENDS: UIBehaviour
FIELDS:
  protected         UnityEngine.UI.ContentSizeFitter.FitModem_HorizontalFit  // 0x18
  protected         UnityEngine.UI.ContentSizeFitter.FitModem_VerticalFit  // 0x1C
  private           UnityEngine.RectTransform       m_Rect  // 0x20
  private           UnityEngine.DrivenRectTransformTrackerm_Tracker  // 0x28
METHODS:
  UnityEngine.UI.ContentSizeFitter.FitMode get_horizontalFit()
  System.Void set_horizontalFit(UnityEngine.UI.ContentSizeFitter.FitMode value)
  UnityEngine.UI.ContentSizeFitter.FitMode get_verticalFit()
  System.Void set_verticalFit(UnityEngine.UI.ContentSizeFitter.FitMode value)
  UnityEngine.RectTransform get_rectTransform()
  System.Void .ctor()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnRectTransformDimensionsChange()
  System.Void HandleSelfFittingAlongAxis(System.Int32 axis)
  System.Void SetLayoutHorizontal()
  System.Void SetLayoutVertical()
  System.Void SetDirty()
END_CLASS

CLASS: UnityEngine.UI.GridLayoutGroup
TYPE:  class
TOKEN: 0x2000044
EXTENDS: LayoutGroup
FIELDS:
  protected         UnityEngine.UI.GridLayoutGroup.Cornerm_StartCorner  // 0x58
  protected         UnityEngine.UI.GridLayoutGroup.Axism_StartAxis  // 0x5C
  protected         UnityEngine.Vector2             m_CellSize  // 0x60
  protected         UnityEngine.Vector2             m_Spacing  // 0x68
  protected         UnityEngine.UI.GridLayoutGroup.Constraintm_Constraint  // 0x70
  protected         System.Int32                    m_ConstraintCount  // 0x74
METHODS:
  UnityEngine.UI.GridLayoutGroup.Corner get_startCorner()
  System.Void set_startCorner(UnityEngine.UI.GridLayoutGroup.Corner value)
  UnityEngine.UI.GridLayoutGroup.Axis get_startAxis()
  System.Void set_startAxis(UnityEngine.UI.GridLayoutGroup.Axis value)
  UnityEngine.Vector2 get_cellSize()
  System.Void set_cellSize(UnityEngine.Vector2 value)
  UnityEngine.Vector2 get_spacing()
  System.Void set_spacing(UnityEngine.Vector2 value)
  UnityEngine.UI.GridLayoutGroup.Constraint get_constraint()
  System.Void set_constraint(UnityEngine.UI.GridLayoutGroup.Constraint value)
  System.Int32 get_constraintCount()
  System.Void set_constraintCount(System.Int32 value)
  System.Void .ctor()
  System.Void CalculateLayoutInputHorizontal()
  System.Void CalculateLayoutInputVertical()
  System.Void SetLayoutHorizontal()
  System.Void SetLayoutVertical()
  System.Void SetCellsAlongAxis(System.Int32 axis)
END_CLASS

CLASS: UnityEngine.UI.HorizontalLayoutGroup
TYPE:  class
TOKEN: 0x2000048
EXTENDS: HorizontalOrVerticalLayoutGroup
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void CalculateLayoutInputHorizontal()
  System.Void CalculateLayoutInputVertical()
  System.Void SetLayoutHorizontal()
  System.Void SetLayoutVertical()
END_CLASS

CLASS: UnityEngine.UI.HorizontalOrVerticalLayoutGroup
TYPE:  class
TOKEN: 0x2000049
EXTENDS: LayoutGroup
FIELDS:
  protected         System.Single                   m_Spacing  // 0x58
  protected         System.Boolean                  m_ChildForceExpandWidth  // 0x5C
  protected         System.Boolean                  m_ChildForceExpandHeight  // 0x5D
  protected         System.Boolean                  m_ChildControlWidth  // 0x5E
  protected         System.Boolean                  m_ChildControlHeight  // 0x5F
  protected         System.Boolean                  m_ChildScaleWidth  // 0x60
  protected         System.Boolean                  m_ChildScaleHeight  // 0x61
  protected         System.Boolean                  m_ReverseArrangement  // 0x62
METHODS:
  System.Single get_spacing()
  System.Void set_spacing(System.Single value)
  System.Boolean get_childForceExpandWidth()
  System.Void set_childForceExpandWidth(System.Boolean value)
  System.Boolean get_childForceExpandHeight()
  System.Void set_childForceExpandHeight(System.Boolean value)
  System.Boolean get_childControlWidth()
  System.Void set_childControlWidth(System.Boolean value)
  System.Boolean get_childControlHeight()
  System.Void set_childControlHeight(System.Boolean value)
  System.Boolean get_childScaleWidth()
  System.Void set_childScaleWidth(System.Boolean value)
  System.Boolean get_childScaleHeight()
  System.Void set_childScaleHeight(System.Boolean value)
  System.Boolean get_reverseArrangement()
  System.Void set_reverseArrangement(System.Boolean value)
  System.Void CalcAlongAxis(System.Int32 axis, System.Boolean isVertical)
  System.Void SetChildrenAlongAxis(System.Int32 axis, System.Boolean isVertical)
  System.Void GetChildSizes(UnityEngine.RectTransform child, System.Int32 axis, System.Boolean controlSize, System.Boolean childForceExpand, System.Single& min, System.Single& preferred, System.Single& flexible)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UI.ILayoutElement
TYPE:  interface
TOKEN: 0x200004A
FIELDS:
METHODS:
  System.Void CalculateLayoutInputHorizontal()
  System.Void CalculateLayoutInputVertical()
  System.Single get_minWidth()
  System.Single get_preferredWidth()
  System.Single get_flexibleWidth()
  System.Single get_minHeight()
  System.Single get_preferredHeight()
  System.Single get_flexibleHeight()
  System.Int32 get_layoutPriority()
END_CLASS

CLASS: UnityEngine.UI.ILayoutController
TYPE:  interface
TOKEN: 0x200004B
FIELDS:
METHODS:
  System.Void SetLayoutHorizontal()
  System.Void SetLayoutVertical()
END_CLASS

CLASS: UnityEngine.UI.ILayoutGroup
TYPE:  interface
TOKEN: 0x200004C
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.UI.ILayoutSelfController
TYPE:  interface
TOKEN: 0x200004D
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.UI.ILayoutIgnorer
TYPE:  interface
TOKEN: 0x200004E
FIELDS:
METHODS:
  System.Boolean get_ignoreLayout()
END_CLASS

CLASS: UnityEngine.UI.LayoutElement
TYPE:  class
TOKEN: 0x200004F
EXTENDS: UIBehaviour
FIELDS:
  private           System.Boolean                  m_IgnoreLayout  // 0x18
  private           System.Single                   m_MinWidth  // 0x1C
  private           System.Single                   m_MinHeight  // 0x20
  private           System.Single                   m_PreferredWidth  // 0x24
  private           System.Single                   m_PreferredHeight  // 0x28
  private           System.Single                   m_FlexibleWidth  // 0x2C
  private           System.Single                   m_FlexibleHeight  // 0x30
  private           System.Int32                    m_LayoutPriority  // 0x34
METHODS:
  System.Boolean get_ignoreLayout()
  System.Void set_ignoreLayout(System.Boolean value)
  System.Void CalculateLayoutInputHorizontal()
  System.Void CalculateLayoutInputVertical()
  System.Single get_minWidth()
  System.Void set_minWidth(System.Single value)
  System.Single get_minHeight()
  System.Void set_minHeight(System.Single value)
  System.Single get_preferredWidth()
  System.Void set_preferredWidth(System.Single value)
  System.Single get_preferredHeight()
  System.Void set_preferredHeight(System.Single value)
  System.Single get_flexibleWidth()
  System.Void set_flexibleWidth(System.Single value)
  System.Single get_flexibleHeight()
  System.Void set_flexibleHeight(System.Single value)
  System.Int32 get_layoutPriority()
  System.Void set_layoutPriority(System.Int32 value)
  System.Void .ctor()
  System.Void OnEnable()
  System.Void OnTransformParentChanged()
  System.Void OnDisable()
  System.Void OnDidApplyAnimationProperties()
  System.Void OnBeforeTransformParentChanged()
  System.Void SetDirty()
END_CLASS

CLASS: UnityEngine.UI.LayoutGroup
TYPE:  class
TOKEN: 0x2000050
EXTENDS: UIBehaviour
FIELDS:
  protected         UnityEngine.RectOffset          m_Padding  // 0x18
  protected         UnityEngine.TextAnchor          m_ChildAlignment  // 0x20
  private           UnityEngine.RectTransform       m_Rect  // 0x28
  protected         UnityEngine.DrivenRectTransformTrackerm_Tracker  // 0x30
  private           UnityEngine.Vector2             m_TotalMinSize  // 0x34
  private           UnityEngine.Vector2             m_TotalPreferredSize  // 0x3C
  private           UnityEngine.Vector2             m_TotalFlexibleSize  // 0x44
  private           System.Collections.Generic.List<UnityEngine.RectTransform>m_RectChildren  // 0x50
METHODS:
  UnityEngine.RectOffset get_padding()
  System.Void set_padding(UnityEngine.RectOffset value)
  UnityEngine.TextAnchor get_childAlignment()
  System.Void set_childAlignment(UnityEngine.TextAnchor value)
  UnityEngine.RectTransform get_rectTransform()
  System.Collections.Generic.List<UnityEngine.RectTransform> get_rectChildren()
  System.Void CalculateLayoutInputHorizontal()
  System.Void CalculateLayoutInputVertical()
  System.Single get_minWidth()
  System.Single get_preferredWidth()
  System.Single get_flexibleWidth()
  System.Single get_minHeight()
  System.Single get_preferredHeight()
  System.Single get_flexibleHeight()
  System.Int32 get_layoutPriority()
  System.Void SetLayoutHorizontal()
  System.Void SetLayoutVertical()
  System.Void .ctor()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDidApplyAnimationProperties()
  System.Single GetTotalMinSize(System.Int32 axis)
  System.Single GetTotalPreferredSize(System.Int32 axis)
  System.Single GetTotalFlexibleSize(System.Int32 axis)
  System.Single GetStartOffset(System.Int32 axis, System.Single requiredSpaceWithoutPadding)
  System.Single GetAlignmentOnAxis(System.Int32 axis)
  System.Void SetLayoutInputForAxis(System.Single totalMin, System.Single totalPreferred, System.Single totalFlexible, System.Int32 axis)
  System.Void SetChildAlongAxis(UnityEngine.RectTransform rect, System.Int32 axis, System.Single pos)
  System.Void SetChildAlongAxisWithScale(UnityEngine.RectTransform rect, System.Int32 axis, System.Single pos, System.Single scaleFactor)
  System.Void SetChildAlongAxis(UnityEngine.RectTransform rect, System.Int32 axis, System.Single pos, System.Single size)
  System.Void SetChildAlongAxisWithScale(UnityEngine.RectTransform rect, System.Int32 axis, System.Single pos, System.Single size, System.Single scaleFactor)
  System.Boolean get_isRootLayoutGroup()
  System.Void OnRectTransformDimensionsChange()
  System.Void OnTransformChildrenChanged()
  System.Void SetProperty(T& currentValue, T newValue)
  System.Void SetDirty()
  System.Collections.IEnumerator DelayedSetDirty(UnityEngine.RectTransform rectTransform)
END_CLASS

CLASS: UnityEngine.UI.LayoutRebuilder
TYPE:  class
TOKEN: 0x2000052
FIELDS:
  private           UnityEngine.RectTransform       m_ToRebuild  // 0x10
  private           System.Int32                    m_CachedHashFromTransform  // 0x18
  private   static  UnityEngine.Pool.ObjectPool<UnityEngine.UI.LayoutRebuilder>s_Rebuilders  // 0x0
METHODS:
  System.Void Initialize(UnityEngine.RectTransform controller)
  System.Void Clear()
  System.Void .cctor()
  System.Void ReapplyDrivenProperties(UnityEngine.RectTransform driven)
  UnityEngine.Transform get_transform()
  System.Boolean IsDestroyed()
  System.Void StripDisabledBehavioursFromList(System.Collections.Generic.List<UnityEngine.Component> components)
  System.Void ForceRebuildLayoutImmediate(UnityEngine.RectTransform layoutRoot)
  System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing)
  System.Void PerformLayoutControl(UnityEngine.RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action)
  System.Void PerformLayoutCalculation(UnityEngine.RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action)
  System.Void MarkLayoutForRebuild(UnityEngine.RectTransform rect)
  System.Boolean ValidController(UnityEngine.RectTransform layoutRoot, System.Collections.Generic.List<UnityEngine.Component> comps)
  System.Void MarkLayoutRootForRebuild(UnityEngine.RectTransform controller)
  System.Void LayoutComplete()
  System.Void GraphicUpdateComplete()
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object obj)
  System.String ToString()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UI.LayoutUtility
TYPE:  class
TOKEN: 0x2000054
FIELDS:
METHODS:
  System.Single GetMinSize(UnityEngine.RectTransform rect, System.Int32 axis)
  System.Single GetPreferredSize(UnityEngine.RectTransform rect, System.Int32 axis)
  System.Single GetFlexibleSize(UnityEngine.RectTransform rect, System.Int32 axis)
  System.Single GetMinWidth(UnityEngine.RectTransform rect)
  System.Single GetPreferredWidth(UnityEngine.RectTransform rect)
  System.Single GetFlexibleWidth(UnityEngine.RectTransform rect)
  System.Single GetMinHeight(UnityEngine.RectTransform rect)
  System.Single GetPreferredHeight(UnityEngine.RectTransform rect)
  System.Single GetFlexibleHeight(UnityEngine.RectTransform rect)
  System.Single GetLayoutProperty(UnityEngine.RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement,System.Single> property, System.Single defaultValue)
  System.Single GetLayoutProperty(UnityEngine.RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement,System.Single> property, System.Single defaultValue, UnityEngine.UI.ILayoutElement& source)
END_CLASS

CLASS: UnityEngine.UI.VerticalLayoutGroup
TYPE:  class
TOKEN: 0x2000056
EXTENDS: HorizontalOrVerticalLayoutGroup
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void CalculateLayoutInputHorizontal()
  System.Void CalculateLayoutInputVertical()
  System.Void SetLayoutHorizontal()
  System.Void SetLayoutVertical()
END_CLASS

CLASS: UnityEngine.UI.Mask
TYPE:  class
TOKEN: 0x2000057
EXTENDS: UIBehaviour
FIELDS:
  private           UnityEngine.RectTransform       m_RectTransform  // 0x18
  private           System.Boolean                  m_ShowMaskGraphic  // 0x20
  private           UnityEngine.UI.Graphic          m_Graphic  // 0x28
  private           UnityEngine.Material            m_MaskMaterial  // 0x30
  private           UnityEngine.Material            m_UnmaskMaterial  // 0x38
METHODS:
  UnityEngine.RectTransform get_rectTransform()
  System.Boolean get_showMaskGraphic()
  System.Void set_showMaskGraphic(System.Boolean value)
  UnityEngine.UI.Graphic get_graphic()
  System.Void .ctor()
  System.Boolean MaskEnabled()
  System.Void OnSiblingGraphicEnabledDisabled()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Boolean IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera)
  UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial)
END_CLASS

CLASS: UnityEngine.UI.MaskableGraphic
TYPE:  class
TOKEN: 0x2000058
EXTENDS: Graphic
FIELDS:
  protected         System.Boolean                  m_ShouldRecalculateStencil  // 0xB0
  protected         UnityEngine.Material            m_MaskMaterial  // 0xB8
  private           UnityEngine.UI.RectMask2D       m_ParentMask  // 0xC0
  private           System.Boolean                  m_Maskable  // 0xC8
  private           System.Boolean                  m_IsMaskingGraphic  // 0xC9
  protected         System.Boolean                  m_IncludeForMasking  // 0xCA
  private           UnityEngine.UI.MaskableGraphic.CullStateChangedEventm_OnCullStateChanged  // 0xD0
  protected         System.Boolean                  m_ShouldRecalculate  // 0xD8
  protected         System.Int32                    m_StencilValue  // 0xDC
  private   readonly UnityEngine.Vector3[]           m_Corners  // 0xE0
METHODS:
  UnityEngine.UI.MaskableGraphic.CullStateChangedEvent get_onCullStateChanged()
  System.Void set_onCullStateChanged(UnityEngine.UI.MaskableGraphic.CullStateChangedEvent value)
  System.Boolean get_maskable()
  System.Void set_maskable(System.Boolean value)
  System.Boolean get_isMaskingGraphic()
  System.Void set_isMaskingGraphic(System.Boolean value)
  UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial)
  System.Void Cull(UnityEngine.Rect clipRect, System.Boolean validRect)
  System.Void UpdateCull(System.Boolean cull)
  System.Void SetClipRect(UnityEngine.Rect clipRect, System.Boolean validRect)
  System.Void SetClipSoftness(UnityEngine.Vector2 clipSoftness)
  System.Void SetHGClipSoftness(UnityEngine.Vector4 hgClipSoftness)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnTransformParentChanged()
  System.Void ParentMaskStateChanged()
  System.Void OnCanvasHierarchyChanged()
  UnityEngine.Rect get_rootCanvasRect()
  System.Void UpdateClipParent()
  System.Void RecalculateClipping()
  System.Void RecalculateMasking()
  System.Void .ctor()
  UnityEngine.GameObject UnityEngine.UI.IClippable.get_gameObject()
END_CLASS

CLASS: UnityEngine.UI.MaskUtilities
TYPE:  class
TOKEN: 0x200005A
FIELDS:
METHODS:
  System.Void Notify2DMaskStateChanged(UnityEngine.Component mask)
  System.Void NotifyStencilStateChanged(UnityEngine.Component mask)
  UnityEngine.Transform FindRootSortOverrideCanvas(UnityEngine.Transform start)
  System.Int32 GetStencilDepth(UnityEngine.Transform transform, UnityEngine.Transform stopAfter)
  System.Boolean IsDescendantOrSelf(UnityEngine.Transform father, UnityEngine.Transform child)
  UnityEngine.UI.RectMask2D GetRectMaskForClippable(UnityEngine.UI.IClippable clippable)
  System.Void GetRectMasksForClip(UnityEngine.UI.RectMask2D clipper, System.Collections.Generic.List<UnityEngine.UI.RectMask2D> masks)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UI.IMaterialModifier
TYPE:  interface
TOKEN: 0x200005B
FIELDS:
METHODS:
  UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial)
END_CLASS

CLASS: UnityEngine.UI.Misc
TYPE:  class
TOKEN: 0x200005C
FIELDS:
METHODS:
  System.Void Destroy(UnityEngine.Object obj)
  System.Void DestroyImmediate(UnityEngine.Object obj)
END_CLASS

CLASS: UnityEngine.UI.MultipleDisplayUtilities
TYPE:  class
TOKEN: 0x200005D
FIELDS:
METHODS:
  System.Boolean GetRelativeMousePositionForDrag(UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.Vector2& position)
  UnityEngine.Vector3 RelativeMouseAtScaled(UnityEngine.Vector2 position)
END_CLASS

CLASS: UnityEngine.UI.Navigation
TYPE:  struct
TOKEN: 0x200005E
FIELDS:
  private           UnityEngine.UI.Navigation.Mode  m_Mode  // 0x10
  private           System.Boolean                  m_WrapAround  // 0x14
  private           UnityEngine.UI.Selectable       m_SelectOnUp  // 0x18
  private           UnityEngine.UI.Selectable       m_SelectOnDown  // 0x20
  private           UnityEngine.UI.Selectable       m_SelectOnLeft  // 0x28
  private           UnityEngine.UI.Selectable       m_SelectOnRight  // 0x30
METHODS:
  UnityEngine.UI.Navigation.Mode get_mode()
  System.Void set_mode(UnityEngine.UI.Navigation.Mode value)
  System.Boolean get_wrapAround()
  System.Void set_wrapAround(System.Boolean value)
  UnityEngine.UI.Selectable get_selectOnUp()
  System.Void set_selectOnUp(UnityEngine.UI.Selectable value)
  UnityEngine.UI.Selectable get_selectOnDown()
  System.Void set_selectOnDown(UnityEngine.UI.Selectable value)
  UnityEngine.UI.Selectable get_selectOnLeft()
  System.Void set_selectOnLeft(UnityEngine.UI.Selectable value)
  UnityEngine.UI.Selectable get_selectOnRight()
  System.Void set_selectOnRight(UnityEngine.UI.Selectable value)
  UnityEngine.UI.Navigation get_defaultNavigation()
  System.Boolean Equals(UnityEngine.UI.Navigation other)
END_CLASS

CLASS: UnityEngine.UI.RawImage
TYPE:  class
TOKEN: 0x2000060
EXTENDS: MaskableGraphic
FIELDS:
  private           UnityEngine.Texture             m_Texture  // 0xE8
  private           UnityEngine.Rect                m_UVRect  // 0xF0
METHODS:
  System.Void .ctor()
  UnityEngine.Texture get_mainTexture()
  UnityEngine.Texture get_texture()
  System.Void set_texture(UnityEngine.Texture value)
  UnityEngine.Rect get_uvRect()
  System.Void set_uvRect(UnityEngine.Rect value)
  System.Void SetNativeSize()
  System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
  System.Void OnDidApplyAnimationProperties()
END_CLASS

CLASS: UnityEngine.UI.RectMask2D
TYPE:  class
TOKEN: 0x2000061
EXTENDS: UIBehaviour
FIELDS:
  private   readonly UnityEngine.UI.RectangularVertexClipperm_VertexClipper  // 0x18
  private           UnityEngine.RectTransform       m_RectTransform  // 0x20
  private           System.Collections.Generic.HashSet<UnityEngine.UI.MaskableGraphic>m_MaskableTargets  // 0x28
  private           System.Collections.Generic.HashSet<UnityEngine.UI.IClippable>m_ClipTargets  // 0x30
  private           System.Boolean                  m_ShouldRecalculateClipRects  // 0x38
  private           System.Collections.Generic.List<UnityEngine.UI.RectMask2D>m_Clippers  // 0x40
  private           UnityEngine.Rect                m_LastClipRectCanvasSpace  // 0x48
  private           System.Boolean                  m_ForceClip  // 0x58
  private           UnityEngine.Vector4             m_Padding  // 0x5C
  private           UnityEngine.Vector2Int          m_Softness  // 0x6C
  private           UnityEngine.Vector4             m_HGSoftness  // 0x74
  private           UnityEngine.Canvas              m_Canvas  // 0x88
  private           UnityEngine.Vector3[]           m_Corners  // 0x90
METHODS:
  UnityEngine.Vector4 get_padding()
  System.Void set_padding(UnityEngine.Vector4 value)
  UnityEngine.Vector2Int get_softness()
  System.Void set_softness(UnityEngine.Vector2Int value)
  UnityEngine.Vector4 get_hgSoftness()
  System.Void set_hgSoftness(UnityEngine.Vector4 value)
  UnityEngine.Canvas get_Canvas()
  UnityEngine.Rect get_canvasRect()
  UnityEngine.RectTransform get_rectTransform()
  System.Void .ctor()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Boolean IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera)
  UnityEngine.Rect get_rootCanvasRect()
  System.Void PerformClipping()
  System.Void UpdateClipSoftness()
  System.Void AddClippable(UnityEngine.UI.IClippable clippable)
  System.Void RemoveClippable(UnityEngine.UI.IClippable clippable)
  System.Void OnTransformParentChanged()
  System.Void OnCanvasHierarchyChanged()
END_CLASS

CLASS: UnityEngine.UI.Scrollbar
TYPE:  class
TOKEN: 0x2000062
EXTENDS: Selectable
FIELDS:
  private           UnityEngine.RectTransform       m_HandleRect  // 0x180
  private           UnityEngine.UI.Scrollbar.Directionm_Direction  // 0x188
  private           System.Single                   m_Value  // 0x18C
  private           System.Single                   m_Size  // 0x190
  private           System.Int32                    m_NumberOfSteps  // 0x194
  private           UnityEngine.UI.Scrollbar.ScrollEventm_OnValueChanged  // 0x198
  private           UnityEngine.RectTransform       m_ContainerRect  // 0x1A0
  private           UnityEngine.Vector2             m_Offset  // 0x1A8
  private           UnityEngine.DrivenRectTransformTrackerm_Tracker  // 0x1B0
  private           UnityEngine.Coroutine           m_PointerDownRepeat  // 0x1B8
  private           System.Boolean                  isPointerDownAndNotDragging  // 0x1C0
  private           System.Boolean                  m_DelayedUpdateVisuals  // 0x1C1
METHODS:
  UnityEngine.RectTransform get_handleRect()
  System.Void set_handleRect(UnityEngine.RectTransform value)
  UnityEngine.UI.Scrollbar.Direction get_direction()
  System.Void set_direction(UnityEngine.UI.Scrollbar.Direction value)
  System.Void .ctor()
  System.Single get_value()
  System.Void set_value(System.Single value)
  System.Void SetValueWithoutNotify(System.Single input)
  System.Single get_size()
  System.Void set_size(System.Single value)
  System.Int32 get_numberOfSteps()
  System.Void set_numberOfSteps(System.Int32 value)
  UnityEngine.UI.Scrollbar.ScrollEvent get_onValueChanged()
  System.Void set_onValueChanged(UnityEngine.UI.Scrollbar.ScrollEvent value)
  System.Single get_stepSize()
  System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing)
  System.Void LayoutComplete()
  System.Void GraphicUpdateComplete()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Update()
  System.Void UpdateCachedReferences()
  System.Void Set(System.Single input, System.Boolean sendCallback)
  System.Void OnRectTransformDimensionsChange()
  UnityEngine.UI.Scrollbar.Axis get_axis()
  System.Boolean get_reverseValue()
  System.Void UpdateVisuals()
  System.Void UpdateDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void DoUpdateDrag(UnityEngine.Vector2 handleCorner, System.Single remainingSize)
  System.Boolean MayDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  System.Collections.IEnumerator ClickRepeat(UnityEngine.EventSystems.PointerEventData eventData)
  System.Collections.IEnumerator ClickRepeat(UnityEngine.Vector2 screenPosition, UnityEngine.Camera camera)
  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnMove(UnityEngine.EventSystems.AxisEventData eventData)
  UnityEngine.UI.Selectable FindSelectableOnLeft()
  UnityEngine.UI.Selectable FindSelectableOnRight()
  UnityEngine.UI.Selectable FindSelectableOnUp()
  UnityEngine.UI.Selectable FindSelectableOnDown()
  System.Void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void SetDirection(UnityEngine.UI.Scrollbar.Direction direction, System.Boolean includeRectLayouts)
  UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform()
END_CLASS

CLASS: UnityEngine.UI.ScrollRect
TYPE:  class
TOKEN: 0x2000067
EXTENDS: UIBehaviour
FIELDS:
  private           UnityEngine.RectTransform       m_Content  // 0x18
  private           System.Boolean                  m_Horizontal  // 0x20
  private           System.Boolean                  m_Vertical  // 0x21
  protected         UnityEngine.GameObject          m_scrollEnableNode  // 0x28
  private           UnityEngine.UI.ScrollRect.MovementTypem_MovementType  // 0x30
  private           System.Single                   m_Elasticity  // 0x34
  private           System.Boolean                  m_Inertia  // 0x38
  private           System.Single                   m_DecelerationRate  // 0x3C
  private           System.Single                   m_ScrollSensitivity  // 0x40
  private           UnityEngine.RectTransform       m_Viewport  // 0x48
  private           UnityEngine.UI.Scrollbar        m_HorizontalScrollbar  // 0x50
  private           UnityEngine.UI.Scrollbar        m_VerticalScrollbar  // 0x58
  private           UnityEngine.UI.ScrollRect.ScrollbarVisibilitym_HorizontalScrollbarVisibility  // 0x60
  private           UnityEngine.UI.ScrollRect.ScrollbarVisibilitym_VerticalScrollbarVisibility  // 0x64
  private           System.Single                   m_HorizontalScrollbarSpacing  // 0x68
  private           System.Single                   m_VerticalScrollbarSpacing  // 0x6C
  private           UnityEngine.UI.ScrollRect.ScrollRectEventm_OnValueChanged  // 0x70
  public            System.Boolean                  disableScroll  // 0x78
  public            UnityEngine.UI.ScrollRect.ScrollRectEventOnScrollStart  // 0x80
  public            UnityEngine.UI.ScrollRect.ScrollRectEventOnScrollEnd  // 0x88
  private           UnityEngine.Vector2             m_PointerStartLocalCursor  // 0x90
  protected         UnityEngine.Vector2             m_ContentStartPosition  // 0x98
  private           UnityEngine.RectTransform       m_ViewRect  // 0xA0
  protected         UnityEngine.Bounds              m_ContentBounds  // 0xA8
  private           UnityEngine.Bounds              m_ViewBounds  // 0xC0
  private           UnityEngine.Vector2             m_Velocity  // 0xD8
  protected         System.Boolean                  m_Dragging  // 0xE0
  protected         System.Boolean                  m_onScrollEndCbFlag  // 0xE1
  protected         System.Boolean                  m_Scrolling  // 0xE2
  private           UnityEngine.Vector2             m_PrevPosition  // 0xE4
  private           UnityEngine.Bounds              m_PrevContentBounds  // 0xEC
  private           UnityEngine.Bounds              m_PrevViewBounds  // 0x104
  private           System.Boolean                  m_HasRebuiltLayout  // 0x11C
  private           System.Boolean                  m_HSliderExpand  // 0x11D
  private           System.Boolean                  m_VSliderExpand  // 0x11E
  private           System.Single                   m_HSliderHeight  // 0x120
  private           System.Single                   m_VSliderWidth  // 0x124
  private           UnityEngine.RectTransform       m_Rect  // 0x128
  private           UnityEngine.RectTransform       m_HorizontalScrollbarRect  // 0x130
  private           UnityEngine.RectTransform       m_VerticalScrollbarRect  // 0x138
  private           UnityEngine.DrivenRectTransformTrackerm_Tracker  // 0x140
  private   readonly UnityEngine.Vector3[]           m_Corners  // 0x148
METHODS:
  UnityEngine.RectTransform get_content()
  System.Void set_content(UnityEngine.RectTransform value)
  System.Boolean get_horizontal()
  System.Void set_horizontal(System.Boolean value)
  System.Boolean get_vertical()
  System.Void set_vertical(System.Boolean value)
  UnityEngine.UI.ScrollRect.MovementType get_movementType()
  System.Void set_movementType(UnityEngine.UI.ScrollRect.MovementType value)
  System.Single get_elasticity()
  System.Void set_elasticity(System.Single value)
  System.Boolean get_inertia()
  System.Void set_inertia(System.Boolean value)
  System.Single get_decelerationRate()
  System.Void set_decelerationRate(System.Single value)
  System.Single get_scrollSensitivity()
  System.Void set_scrollSensitivity(System.Single value)
  UnityEngine.RectTransform get_viewport()
  System.Void set_viewport(UnityEngine.RectTransform value)
  UnityEngine.UI.Scrollbar get_horizontalScrollbar()
  System.Void set_horizontalScrollbar(UnityEngine.UI.Scrollbar value)
  UnityEngine.UI.Scrollbar get_verticalScrollbar()
  System.Void set_verticalScrollbar(UnityEngine.UI.Scrollbar value)
  UnityEngine.UI.ScrollRect.ScrollbarVisibility get_horizontalScrollbarVisibility()
  System.Void set_horizontalScrollbarVisibility(UnityEngine.UI.ScrollRect.ScrollbarVisibility value)
  UnityEngine.UI.ScrollRect.ScrollbarVisibility get_verticalScrollbarVisibility()
  System.Void set_verticalScrollbarVisibility(UnityEngine.UI.ScrollRect.ScrollbarVisibility value)
  System.Single get_horizontalScrollbarSpacing()
  System.Void set_horizontalScrollbarSpacing(System.Single value)
  System.Single get_verticalScrollbarSpacing()
  System.Void set_verticalScrollbarSpacing(System.Single value)
  UnityEngine.UI.ScrollRect.ScrollRectEvent get_onValueChanged()
  System.Void set_onValueChanged(UnityEngine.UI.ScrollRect.ScrollRectEvent value)
  UnityEngine.RectTransform get_viewRect()
  UnityEngine.Vector2 get_velocity()
  System.Void set_velocity(UnityEngine.Vector2 value)
  UnityEngine.RectTransform get_rectTransform()
  System.Void .ctor()
  System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing)
  System.Void LayoutComplete()
  System.Void GraphicUpdateComplete()
  System.Void UpdateCachedData()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Boolean IsActive()
  System.Void EnsureLayoutHasRebuilt()
  System.Void StopMovement()
  System.Void OnScroll(UnityEngine.EventSystems.PointerEventData data)
  System.Void _CustomSetPosOnScroll(UnityEngine.Vector2 position)
  System.Void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void SetContentAnchoredPosition(UnityEngine.Vector2 position)
  System.Void LateUpdate()
  System.Void UpdatePrevData()
  System.Void UpdateScrollbars(UnityEngine.Vector2 offset)
  UnityEngine.Vector2 get_normalizedPosition()
  System.Void set_normalizedPosition(UnityEngine.Vector2 value)
  System.Single get_horizontalNormalizedPosition()
  System.Void set_horizontalNormalizedPosition(System.Single value)
  System.Single get_verticalNormalizedPosition()
  System.Void set_verticalNormalizedPosition(System.Single value)
  System.Void SetHorizontalNormalizedPosition(System.Single value)
  System.Void SetVerticalNormalizedPosition(System.Single value)
  System.Void SetNormalizedPosition(System.Single value, System.Int32 axis)
  System.Single RubberDelta(System.Single overStretching, System.Single viewSize)
  System.Void OnRectTransformDimensionsChange()
  System.Boolean get_hScrollingNeeded()
  System.Boolean get_vScrollingNeeded()
  System.Void CalculateLayoutInputHorizontal()
  System.Void CalculateLayoutInputVertical()
  System.Single get_minWidth()
  System.Single get_preferredWidth()
  System.Single get_flexibleWidth()
  System.Single get_minHeight()
  System.Single get_preferredHeight()
  System.Single get_flexibleHeight()
  System.Int32 get_layoutPriority()
  System.Void SetLayoutHorizontal()
  System.Void SetLayoutVertical()
  System.Void UpdateScrollbarVisibility()
  System.Void UpdateOneScrollbarVisibility(System.Boolean xScrollingNeeded, System.Boolean xAxisEnabled, UnityEngine.UI.ScrollRect.ScrollbarVisibility scrollbarVisibility, UnityEngine.UI.Scrollbar scrollbar)
  System.Void UpdateScrollbarLayout()
  System.Void UpdateScrollEnableNode()
  System.Void UpdateBounds()
  System.Void AdjustBounds(UnityEngine.Bounds& viewBounds, UnityEngine.Vector2& contentPivot, UnityEngine.Vector3& contentSize, UnityEngine.Vector3& contentPos)
  UnityEngine.Bounds GetBounds()
  UnityEngine.Bounds InternalGetBounds(UnityEngine.Vector3[] corners, UnityEngine.Matrix4x4& viewWorldToLocalMatrix)
  UnityEngine.Vector2 CalculateOffset(UnityEngine.Vector2 delta)
  UnityEngine.Vector2 InternalCalculateOffset(UnityEngine.Bounds& viewBounds, UnityEngine.Bounds& contentBounds, System.Boolean horizontal, System.Boolean vertical, UnityEngine.UI.ScrollRect.MovementType movementType, UnityEngine.Vector2& delta)
  System.Void SetDirty()
  System.Void SetDirtyCaching()
  UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform()
END_CLASS

CLASS: UnityEngine.UI.Selectable
TYPE:  class
TOKEN: 0x200006B
EXTENDS: UIBehaviour
FIELDS:
  protected static  UnityEngine.UI.Selectable[]     s_Selectables  // 0x0
  protected static  System.Int32                    s_SelectableCount  // 0x8
  private           System.Boolean                  m_EnableCalled  // 0x18
  private           UnityEngine.UI.Navigation       m_Navigation  // 0x20
  private           UnityEngine.UI.Selectable.Transitionm_Transition  // 0x48
  private           UnityEngine.UI.ColorBlock       m_Colors  // 0x4C
  private           UnityEngine.UI.SpriteState      m_SpriteState  // 0xA8
  private           UnityEngine.UI.AnimationTriggersm_AnimationTriggers  // 0xC8
  private           System.Boolean                  m_Interactable  // 0xD0
  private           UnityEngine.UI.Graphic          m_TargetGraphic  // 0xD8
  protected         System.Boolean                  m_NotifyHover  // 0xE0
  protected         UnityEngine.GameObject          m_HoverEnableNode  // 0xE8
  protected         System.String                   m_HoverAudioKey  // 0xF0
  protected         System.Boolean                  _enableUnityNavi  // 0xF8
  private           System.Boolean                  m_GroupsAllowInteraction  // 0xF9
  protected         System.Int32                    m_CurrentIndex  // 0xFC
  private           System.Boolean                  <isPointerInside>k__BackingField  // 0x100
  private           System.Boolean                  <isPointerDown>k__BackingField  // 0x101
  private           System.Boolean                  <hasSelection>k__BackingField  // 0x102
  private   readonly System.Collections.Generic.List<UnityEngine.CanvasGroup>m_CanvasGroupCache  // 0x108
  public    static  UnityEngine.Events.UnityEvent<UnityEngine.UI.Selectable,System.Boolean>onAnyHoverChange  // 0x10
  private   readonly UnityEngine.Events.UnityEvent<System.Boolean><onHoverChange>k__BackingField  // 0x110
  public            System.Boolean                  enableControllerNavi  // 0x118
  public            UnityEngine.Transform           overrideNaviHintRectTransform  // 0x120
  public            System.Single                   overrideNaviHintRectScale  // 0x128
  public            System.Boolean                  changeNaviHintParent  // 0x12C
  public            System.Boolean                  hideNaviHint  // 0x12D
  public            System.Boolean                  needNaviConfirmKeyHint  // 0x12E
  public            System.Boolean                  useExplicitNaviSelect  // 0x12F
  public            System.Boolean                  banExplicitOnLeft  // 0x130
  public            System.Boolean                  banExplicitOnRight  // 0x131
  public            System.Boolean                  banExplicitOnUp  // 0x132
  public            System.Boolean                  banExplicitOnDown  // 0x133
  private           UnityEngine.UI.Selectable       m_ExplicitSelectOnLeft  // 0x138
  private           UnityEngine.UI.Selectable       m_ExplicitSelectOnRight  // 0x140
  private           UnityEngine.UI.Selectable       m_ExplicitSelectOnUp  // 0x148
  private           UnityEngine.UI.Selectable       m_ExplicitSelectOnDown  // 0x150
  private           System.Boolean                  <isNaviTarget>k__BackingField  // 0x158
  public            System.Action<System.Boolean,System.Boolean,System.Boolean>onIsNaviTargetChanged  // 0x160
  private           System.Boolean                  <isNavigationSilent>k__BackingField  // 0x168
  public            UnityEngine.UI.SelectableNaviGroupnaviGroup  // 0x170
  private           System.Boolean                  m_naviInited  // 0x178
METHODS:
  UnityEngine.UI.Selectable[] get_allSelectablesArray()
  System.Int32 get_allSelectableCount()
  System.Collections.Generic.List<UnityEngine.UI.Selectable> get_allSelectables()
  System.Int32 AllSelectablesNoAlloc(UnityEngine.UI.Selectable[] selectables)
  System.String get_hoverAudioKey()
  UnityEngine.UI.Navigation get_navigation()
  System.Void set_navigation(UnityEngine.UI.Navigation value)
  UnityEngine.UI.Selectable.Transition get_transition()
  System.Void set_transition(UnityEngine.UI.Selectable.Transition value)
  UnityEngine.UI.ColorBlock get_colors()
  System.Void set_colors(UnityEngine.UI.ColorBlock value)
  UnityEngine.UI.SpriteState get_spriteState()
  System.Void set_spriteState(UnityEngine.UI.SpriteState value)
  UnityEngine.UI.AnimationTriggers get_animationTriggers()
  System.Void set_animationTriggers(UnityEngine.UI.AnimationTriggers value)
  UnityEngine.UI.Graphic get_targetGraphic()
  System.Void set_targetGraphic(UnityEngine.UI.Graphic value)
  System.Boolean get_interactable()
  System.Void set_interactable(System.Boolean value)
  System.Boolean get_isPointerInside()
  System.Void set_isPointerInside(System.Boolean value)
  System.Boolean get_isPointerDown()
  System.Void set_isPointerDown(System.Boolean value)
  System.Boolean get_hasSelection()
  System.Void set_hasSelection(System.Boolean value)
  System.Void .ctor()
  UnityEngine.UI.Image get_image()
  System.Void set_image(UnityEngine.UI.Image value)
  UnityEngine.Animator get_animator()
  System.Void Awake()
  System.Void OnCanvasGroupChanged()
  System.Boolean IsInteractable()
  System.Void OnDidApplyAnimationProperties()
  System.Void OnEnable()
  System.Void OnTransformParentChanged()
  System.Void OnSetProperty()
  System.Void OnDisable()
  System.Void OnApplicationFocus(System.Boolean hasFocus)
  UnityEngine.UI.Selectable.SelectionState get_currentSelectionState()
  System.Void InstantClearState()
  System.Void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, System.Boolean instant)
  UnityEngine.UI.Selectable FindSelectable(UnityEngine.Vector3 dir)
  UnityEngine.Vector3 GetPointOnRectEdge(UnityEngine.RectTransform rect, UnityEngine.Vector2 dir)
  System.Void Navigate(UnityEngine.EventSystems.AxisEventData eventData, UnityEngine.UI.Selectable sel)
  UnityEngine.UI.Selectable FindSelectableOnLeft()
  UnityEngine.UI.Selectable FindSelectableOnRight()
  UnityEngine.UI.Selectable FindSelectableOnUp()
  UnityEngine.UI.Selectable FindSelectableOnDown()
  System.Void OnMove(UnityEngine.EventSystems.AxisEventData eventData)
  System.Void StartColorTween(UnityEngine.Color targetColor, System.Boolean instant)
  System.Void DoSpriteSwap(UnityEngine.Sprite newSprite)
  System.Void TriggerAnimation(System.String triggername)
  System.Boolean IsHighlighted()
  System.Boolean IsPressed()
  System.Void EvaluateAndTransitionToSelectionState()
  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void Select()
  System.Void _RefreshHoverEnableNode(System.Boolean active)
  System.Void OnInteractableChanged()
  UnityEngine.Events.UnityEvent<System.Boolean> get_onHoverChange()
  System.Void _NotifyIsHover(System.Boolean isHover)
  System.Void OnDestroy()
  System.Boolean GetMouseActionHints(System.String& clickHintTextId, System.String& longPressHintTextId)
  System.Boolean get_isNaviTarget()
  System.Void set_isNaviTarget(System.Boolean value)
  System.Boolean get_isNavigationSilent()
  System.Void set_isNavigationSilent(System.Boolean value)
  System.Void SetAsNaviTarget(System.Boolean isTarget, System.Boolean silentMode, System.Boolean isGroupChanged)
  System.Void OnNaviTargetEnabledAgain()
  System.Void _OnSetAsNaviTarget(System.Boolean isTarget, System.Boolean silentMode)
  System.Void TryFindNaviGroup()
  UnityEngine.UI.SelectableNaviGroup GetLayerGroup()
  System.Boolean TryFindExplicitNaviTarget(UnityEngine.UI.NaviDirection dir, UnityEngine.UI.Selectable& target)
  System.Boolean banExplicitNavi(UnityEngine.UI.NaviDirection dir)
  System.Void _TryRegisterOnNaviGroup()
  System.Void _TryUnRegisterOnNaviGroup()
  System.Void SetExplicitSelectOnLeft(UnityEngine.UI.Selectable selectable)
  System.Void SetExplicitSelectOnRight(UnityEngine.UI.Selectable selectable)
  System.Void SetExplicitSelectOnUp(UnityEngine.UI.Selectable selectable)
  System.Void SetExplicitSelectOnDown(UnityEngine.UI.Selectable selectable)
  System.Void SetExplicitSelect(UnityEngine.UI.Selectable left, UnityEngine.UI.Selectable right, UnityEngine.UI.Selectable up, UnityEngine.UI.Selectable down)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UI.NaviDirection
TYPE:  struct
TOKEN: 0x200006E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.NaviDirection    None  // 0x0
  public    static  UnityEngine.UI.NaviDirection    Up  // 0x0
  public    static  UnityEngine.UI.NaviDirection    Down  // 0x0
  public    static  UnityEngine.UI.NaviDirection    Left  // 0x0
  public    static  UnityEngine.UI.NaviDirection    Right  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UI.NaviStrategy
TYPE:  struct
TOKEN: 0x200006F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.NaviStrategy     Normal  // 0x0
  public    static  UnityEngine.UI.NaviStrategy     Strict  // 0x0
  public    static  UnityEngine.UI.NaviStrategy     NotInternalFirst  // 0x0
  public    static  UnityEngine.UI.NaviStrategy     VerticalOnlyWithInternalWrap  // 0x0
  public    static  UnityEngine.UI.NaviStrategy     HorizontalOnlyWithInternalWrap  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UI.NavigationBindingType
TYPE:  struct
TOKEN: 0x2000070
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UI.NavigationBindingTypeInValid  // 0x0
  public    static  UnityEngine.UI.NavigationBindingTypeAllDirections  // 0x0
  public    static  UnityEngine.UI.NavigationBindingTypeHorizontalOnly  // 0x0
  public    static  UnityEngine.UI.NavigationBindingTypeVerticalOnly  // 0x0
  public    static  UnityEngine.UI.NavigationBindingTypeArrowAllDirections  // 0x0
  public    static  UnityEngine.UI.NavigationBindingTypeArrowHorizontalOnly  // 0x0
  public    static  UnityEngine.UI.NavigationBindingTypeArrowVerticalOnly  // 0x0
  public    static  UnityEngine.UI.NavigationBindingTypeRightJsAllDirections  // 0x0
  public    static  UnityEngine.UI.NavigationBindingTypeRightJsHorizontalOnly  // 0x0
  public    static  UnityEngine.UI.NavigationBindingTypeRightJsVerticalOnly  // 0x0
  public    static  UnityEngine.UI.NavigationBindingTypeRightJsOnlyAllDirections  // 0x0
  public    static  UnityEngine.UI.NavigationBindingTypeRightJsOnlyHorizontalOnly  // 0x0
  public    static  UnityEngine.UI.NavigationBindingTypeRightJsOnlyVerticalOnly  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UI.SelectableNaviGroup
TYPE:  class
TOKEN: 0x2000071
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Boolean                  isIsolate  // 0x18
  public            System.Boolean                  isLayer  // 0x19
  public            System.Boolean                  removeLayerOnDisable  // 0x1A
  public            UnityEngine.UI.SelectableNaviGroupparentNaviGroup  // 0x20
  public            UnityEngine.UI.NaviStrategy     internalNaviStrategy  // 0x28
  public            UnityEngine.UI.NavigationBindingTypenavigationBindingType  // 0x2C
  public            System.Boolean                  enablePartner  // 0x30
  public            System.Collections.Generic.List<UnityEngine.UI.SelectableNaviGroup>naviPartnerOnUp  // 0x38
  public            System.Collections.Generic.List<UnityEngine.UI.SelectableNaviGroup>naviPartnerOnDown  // 0x40
  public            System.Collections.Generic.List<UnityEngine.UI.SelectableNaviGroup>naviPartnerOnLeft  // 0x48
  public            System.Collections.Generic.List<UnityEngine.UI.SelectableNaviGroup>naviPartnerOnRight  // 0x50
  protected         System.Boolean                  m_inited  // 0x58
  protected         UnityEngine.UI.Selectable       m_layerSelectedTarget  // 0x60
  public            System.Collections.Generic.HashSet<UnityEngine.UI.Selectable>targets  // 0x68
  public            System.Collections.Generic.HashSet<UnityEngine.UI.SelectableNaviGroup>subGroups  // 0x70
  public            UnityEngine.Events.UnityEvent<UnityEngine.UI.Selectable>onSetLayerSelectedTarget  // 0x78
  public            UnityEngine.Events.UnityEvent<System.Boolean>onIsTopLayerChanged  // 0x80
  public            UnityEngine.Events.UnityEvent<UnityEngine.UI.NaviDirection>onDefaultNaviFailed  // 0x88
  public            UnityEngine.Events.UnityEvent   onRemoveFromLayerStack  // 0x90
  protected         System.Boolean                  m_isTopLayer  // 0x98
METHODS:
  UnityEngine.UI.Selectable get_LayerSelectedTarget()
  System.Void Reset()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void _Init()
  System.Void TryFindParentNaviGroup()
  UnityEngine.UI.SelectableNaviGroup GetLayerGroup()
  System.Boolean get_IsTopLayer()
  System.Void set_IsTopLayer(System.Boolean value)
  System.Void SetLayerSelectedTarget(UnityEngine.UI.Selectable value, System.Boolean silentMode)
  System.Void OnRemoveFromLayerStack()
  System.Void _OnIsTopLayerChanged()
  System.Void _OnSelectableNaviGroupInited()
  System.Void _BeforeSelectableNaviGroupDestroy()
  System.Void _OnSelectableNaviGroupDisabled()
  System.Void _OnSetLayerSelectedTarget(UnityEngine.UI.Selectable value)
  System.Void _OnRemoveFromLayerStack()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UI.SetPropertyUtility
TYPE:  class
TOKEN: 0x2000072
FIELDS:
METHODS:
  System.Boolean SetColor(UnityEngine.Color& currentValue, UnityEngine.Color newValue)
  System.Boolean SetStruct(T& currentValue, T newValue)
  System.Boolean SetClass(T& currentValue, T newValue)
END_CLASS

CLASS: UnityEngine.UI.Slider
TYPE:  class
TOKEN: 0x2000073
EXTENDS: Selectable
FIELDS:
  private           UnityEngine.RectTransform       m_FillRect  // 0x180
  private           UnityEngine.RectTransform       m_HandleRect  // 0x188
  private           UnityEngine.UI.Slider.Direction m_Direction  // 0x190
  private           System.Single                   m_MinValue  // 0x194
  private           System.Single                   m_MaxValue  // 0x198
  private           System.Boolean                  m_WholeNumbers  // 0x19C
  protected         System.Single                   m_Value  // 0x1A0
  private           UnityEngine.UI.Slider.SliderEventm_OnValueChanged  // 0x1A8
  private           UnityEngine.UI.Image            m_FillImage  // 0x1B0
  private           UnityEngine.Transform           m_FillTransform  // 0x1B8
  private           UnityEngine.RectTransform       m_FillContainerRect  // 0x1C0
  private           UnityEngine.Transform           m_HandleTransform  // 0x1C8
  private           UnityEngine.RectTransform       m_HandleContainerRect  // 0x1D0
  private           UnityEngine.Vector2             m_Offset  // 0x1D8
  private           UnityEngine.DrivenRectTransformTrackerm_Tracker  // 0x1E0
  private           System.Boolean                  m_DelayedUpdateVisuals  // 0x1E1
METHODS:
  UnityEngine.RectTransform get_fillRect()
  System.Void set_fillRect(UnityEngine.RectTransform value)
  UnityEngine.RectTransform get_handleRect()
  System.Void set_handleRect(UnityEngine.RectTransform value)
  UnityEngine.UI.Slider.Direction get_direction()
  System.Void set_direction(UnityEngine.UI.Slider.Direction value)
  System.Single get_minValue()
  System.Void set_minValue(System.Single value)
  System.Single get_maxValue()
  System.Void set_maxValue(System.Single value)
  System.Boolean get_wholeNumbers()
  System.Void set_wholeNumbers(System.Boolean value)
  System.Single get_value()
  System.Void set_value(System.Single value)
  System.Void SetValueWithoutNotify(System.Single input)
  System.Single get_normalizedValue()
  System.Void set_normalizedValue(System.Single value)
  UnityEngine.UI.Slider.SliderEvent get_onValueChanged()
  System.Void set_onValueChanged(UnityEngine.UI.Slider.SliderEvent value)
  System.Single get_stepSize()
  System.Void .ctor()
  System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing)
  System.Void LayoutComplete()
  System.Void GraphicUpdateComplete()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Update()
  System.Void OnDidApplyAnimationProperties()
  System.Void UpdateCachedReferences()
  System.Single ClampValue(System.Single input)
  System.Void Set(System.Single input, System.Boolean sendCallback)
  System.Void OnValueChanged()
  System.Void OnClickSliderBar()
  System.Void OnClickSliderHandle()
  System.Void OnRectTransformDimensionsChange()
  UnityEngine.UI.Slider.Axis get_axis()
  System.Boolean get_reverseValue()
  System.Void UpdateVisuals()
  System.Void UpdateDrag(UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.Camera cam)
  System.Single CustomProcessNormalizedValue(System.Single val)
  System.Boolean MayDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnMove(UnityEngine.EventSystems.AxisEventData eventData)
  UnityEngine.UI.Selectable FindSelectableOnLeft()
  UnityEngine.UI.Selectable FindSelectableOnRight()
  UnityEngine.UI.Selectable FindSelectableOnUp()
  UnityEngine.UI.Selectable FindSelectableOnDown()
  System.Void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void SetDirection(UnityEngine.UI.Slider.Direction direction, System.Boolean includeRectLayouts)
  UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform()
END_CLASS

CLASS: UnityEngine.UI.SpriteState
TYPE:  struct
TOKEN: 0x2000077
FIELDS:
  private           UnityEngine.Sprite              m_HighlightedSprite  // 0x10
  private           UnityEngine.Sprite              m_PressedSprite  // 0x18
  private           UnityEngine.Sprite              m_SelectedSprite  // 0x20
  private           UnityEngine.Sprite              m_DisabledSprite  // 0x28
METHODS:
  UnityEngine.Sprite get_highlightedSprite()
  System.Void set_highlightedSprite(UnityEngine.Sprite value)
  UnityEngine.Sprite get_pressedSprite()
  System.Void set_pressedSprite(UnityEngine.Sprite value)
  UnityEngine.Sprite get_selectedSprite()
  System.Void set_selectedSprite(UnityEngine.Sprite value)
  UnityEngine.Sprite get_disabledSprite()
  System.Void set_disabledSprite(UnityEngine.Sprite value)
  System.Boolean Equals(UnityEngine.UI.SpriteState other)
END_CLASS

CLASS: UnityEngine.UI.StencilMaterial
TYPE:  class
TOKEN: 0x2000078
FIELDS:
  private   static  System.Collections.Generic.List<UnityEngine.UI.StencilMaterial.MatEntry>m_List  // 0x0
  private   static  System.Boolean                  s_EnableStencilMaterialWarning  // 0x8
METHODS:
  UnityEngine.Material Add(UnityEngine.Material baseMat, System.Int32 stencilID)
  UnityEngine.Material Add(UnityEngine.Material baseMat, System.Int32 stencilID, UnityEngine.Rendering.StencilOp operation, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.ColorWriteMask colorWriteMask)
  System.Void LogWarningWhenNotInBatchmode(System.String warning, UnityEngine.Object context)
  UnityEngine.Material Add(UnityEngine.Material baseMat, System.Int32 stencilID, UnityEngine.Rendering.StencilOp operation, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.ColorWriteMask colorWriteMask, System.Int32 readMask, System.Int32 writeMask)
  System.Void Remove(UnityEngine.Material customMat)
  System.Void ClearAll()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UI.Text
TYPE:  class
TOKEN: 0x200007A
EXTENDS: MaskableGraphic
FIELDS:
  private           UnityEngine.UI.FontData         m_FontData  // 0xE8
  protected         System.String                   m_Text  // 0xF0
  private           UnityEngine.TextGenerator       m_TextCache  // 0xF8
  private           UnityEngine.TextGenerator       m_TextCacheForLayout  // 0x100
  protected static  UnityEngine.Material            s_DefaultText  // 0x0
  protected         System.Boolean                  m_DisableFontTextureRebuiltCallback  // 0x108
  private   readonly UnityEngine.UIVertex[]          m_TempVerts  // 0x110
METHODS:
  System.Void .ctor()
  UnityEngine.TextGenerator get_cachedTextGenerator()
  UnityEngine.TextGenerator get_cachedTextGeneratorForLayout()
  UnityEngine.Texture get_mainTexture()
  System.Void FontTextureChanged()
  UnityEngine.Font get_font()
  System.Void set_font(UnityEngine.Font value)
  System.String get_text()
  System.Void set_text(System.String value)
  System.Boolean get_supportRichText()
  System.Void set_supportRichText(System.Boolean value)
  System.Boolean get_resizeTextForBestFit()
  System.Void set_resizeTextForBestFit(System.Boolean value)
  System.Int32 get_resizeTextMinSize()
  System.Void set_resizeTextMinSize(System.Int32 value)
  System.Int32 get_resizeTextMaxSize()
  System.Void set_resizeTextMaxSize(System.Int32 value)
  UnityEngine.TextAnchor get_alignment()
  System.Void set_alignment(UnityEngine.TextAnchor value)
  System.Boolean get_alignByGeometry()
  System.Void set_alignByGeometry(System.Boolean value)
  System.Int32 get_fontSize()
  System.Void set_fontSize(System.Int32 value)
  UnityEngine.HorizontalWrapMode get_horizontalOverflow()
  System.Void set_horizontalOverflow(UnityEngine.HorizontalWrapMode value)
  UnityEngine.VerticalWrapMode get_verticalOverflow()
  System.Void set_verticalOverflow(UnityEngine.VerticalWrapMode value)
  System.Single get_lineSpacing()
  System.Void set_lineSpacing(System.Single value)
  UnityEngine.FontStyle get_fontStyle()
  System.Void set_fontStyle(UnityEngine.FontStyle value)
  System.Single get_pixelsPerUnit()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void UpdateGeometry()
  System.Void AssignDefaultFont()
  System.Void AssignDefaultFontIfNecessary()
  UnityEngine.TextGenerationSettings GetGenerationSettings(UnityEngine.Vector2 extents)
  UnityEngine.Vector2 GetTextAnchorPivot(UnityEngine.TextAnchor anchor)
  System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper toFill)
  System.Void CalculateLayoutInputHorizontal()
  System.Void CalculateLayoutInputVertical()
  System.Single get_minWidth()
  System.Single get_preferredWidth()
  System.Single get_flexibleWidth()
  System.Single get_minHeight()
  System.Single get_preferredHeight()
  System.Single get_flexibleHeight()
  System.Int32 get_layoutPriority()
END_CLASS

CLASS: UnityEngine.UI.Toggle
TYPE:  class
TOKEN: 0x200007B
EXTENDS: Selectable
FIELDS:
  public            UnityEngine.UI.Toggle.ToggleTransitiontoggleTransition  // 0x180
  public            UnityEngine.UI.Graphic          graphic  // 0x188
  private           UnityEngine.UI.ToggleGroup      m_Group  // 0x190
  public            UnityEngine.UI.Toggle.ToggleEventonValueChanged  // 0x198
  private           System.Boolean                  m_IsOn  // 0x1A0
METHODS:
  UnityEngine.UI.ToggleGroup get_group()
  System.Void set_group(UnityEngine.UI.ToggleGroup value)
  System.Void .ctor()
  System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing)
  System.Void LayoutComplete()
  System.Void GraphicUpdateComplete()
  System.Void OnDestroy()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDidApplyAnimationProperties()
  System.Void SetToggleGroup(UnityEngine.UI.ToggleGroup newGroup, System.Boolean setMemberValue)
  System.Boolean get_isOn()
  System.Void set_isOn(System.Boolean value)
  System.Void SetIsOnWithoutNotify(System.Boolean value)
  System.Void Set(System.Boolean value, System.Boolean sendCallback)
  System.Void PlayEffect(System.Boolean instant)
  System.Void Start()
  System.Void InternalToggle()
  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void OnValueChange()
  UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform()
END_CLASS

CLASS: UnityEngine.UI.ToggleGroup
TYPE:  class
TOKEN: 0x200007E
EXTENDS: UIBehaviour
FIELDS:
  private           System.Boolean                  m_AllowSwitchOff  // 0x18
  protected         System.Collections.Generic.List<UnityEngine.UI.Toggle>m_Toggles  // 0x20
METHODS:
  System.Boolean get_allowSwitchOff()
  System.Void set_allowSwitchOff(System.Boolean value)
  System.Void .ctor()
  System.Void Start()
  System.Void OnEnable()
  System.Void ValidateToggleIsInGroup(UnityEngine.UI.Toggle toggle)
  System.Void NotifyToggleOn(UnityEngine.UI.Toggle toggle, System.Boolean sendCallback)
  System.Void UnregisterToggle(UnityEngine.UI.Toggle toggle)
  System.Void RegisterToggle(UnityEngine.UI.Toggle toggle)
  System.Void EnsureValidState()
  System.Boolean AnyTogglesOn()
  System.Collections.Generic.IEnumerable<UnityEngine.UI.Toggle> ActiveToggles()
  UnityEngine.UI.Toggle GetFirstActiveToggle()
  System.Void SetAllTogglesOff(System.Boolean sendCallback)
END_CLASS

CLASS: UnityEngine.UI.ReflectionMethodsCache
TYPE:  class
TOKEN: 0x2000080
FIELDS:
  public            UnityEngine.UI.ReflectionMethodsCache.Raycast3DCallbackraycast3D  // 0x10
  public            UnityEngine.UI.ReflectionMethodsCache.RaycastAllCallbackraycast3DAll  // 0x18
  public            UnityEngine.UI.ReflectionMethodsCache.GetRaycastNonAllocCallbackgetRaycastNonAlloc  // 0x20
  public            UnityEngine.UI.ReflectionMethodsCache.Raycast2DCallbackraycast2D  // 0x28
  public            UnityEngine.UI.ReflectionMethodsCache.GetRayIntersectionAllCallbackgetRayIntersectionAll  // 0x30
  public            UnityEngine.UI.ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallbackgetRayIntersectionAllNonAlloc  // 0x38
  private   static  UnityEngine.UI.ReflectionMethodsCaches_ReflectionMethodsCache  // 0x0
METHODS:
  System.Void .ctor()
  UnityEngine.UI.ReflectionMethodsCache get_Singleton()
END_CLASS

CLASS: UnityEngine.UI.VertexHelper
TYPE:  class
TOKEN: 0x2000087
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.Vector3>m_Positions  // 0x10
  private           System.Collections.Generic.List<UnityEngine.Color32>m_Colors  // 0x18
  private           System.Collections.Generic.List<UnityEngine.Vector4>m_Uv0S  // 0x20
  private           System.Collections.Generic.List<UnityEngine.Vector4>m_Uv1S  // 0x28
  private           System.Collections.Generic.List<UnityEngine.Vector4>m_Uv2S  // 0x30
  private           System.Collections.Generic.List<UnityEngine.Vector4>m_Uv3S  // 0x38
  private           System.Collections.Generic.List<UnityEngine.Vector3>m_Normals  // 0x40
  private           System.Collections.Generic.List<UnityEngine.Vector4>m_Tangents  // 0x48
  private           System.Collections.Generic.List<System.Int32>m_Indices  // 0x50
  private   static readonly UnityEngine.Vector4             s_DefaultTangent  // 0x0
  private   static readonly UnityEngine.Vector3             s_DefaultNormal  // 0x10
  private           System.Boolean                  m_ListsInitalized  // 0x58
METHODS:
  System.Void .ctor()
  System.Void .ctor(UnityEngine.Mesh m)
  System.Void InitializeListIfRequired()
  System.Void Dispose()
  System.Void Clear()
  System.Int32 get_currentVertCount()
  System.Int32 get_currentIndexCount()
  System.Void PopulateUIVertex(UnityEngine.UIVertex& vertex, System.Int32 i)
  System.Void SetUIVertex(UnityEngine.UIVertex vertex, System.Int32 i)
  System.Void FillMesh(UnityEngine.Mesh mesh)
  System.Void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0, UnityEngine.Vector4 uv1, UnityEngine.Vector4 uv2, UnityEngine.Vector4 uv3, UnityEngine.Vector3 normal, UnityEngine.Vector4 tangent)
  System.Void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0, UnityEngine.Vector4 uv1, UnityEngine.Vector3 normal, UnityEngine.Vector4 tangent)
  System.Void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0)
  System.Void AddVert(UnityEngine.UIVertex v)
  System.Void AddTriangle(System.Int32 idx0, System.Int32 idx1, System.Int32 idx2)
  System.Void AddUIVertexQuad(UnityEngine.UIVertex[] verts)
  System.Void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<System.Int32> indices)
  System.Void AddUIVertexTriangleStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts)
  System.Void GetUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> stream)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UI.BaseVertexEffect
TYPE:  class
TOKEN: 0x2000088
FIELDS:
METHODS:
  System.Void ModifyVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UI.BaseMeshEffect
TYPE:  class
TOKEN: 0x2000089
EXTENDS: UIBehaviour
FIELDS:
  private           UnityEngine.UI.Graphic          m_Graphic  // 0x18
METHODS:
  UnityEngine.UI.Graphic get_graphic()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDidApplyAnimationProperties()
  System.Void ModifyMesh(UnityEngine.Mesh mesh)
  System.Void ModifyMesh(UnityEngine.UI.VertexHelper vh)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UI.IVertexModifier
TYPE:  interface
TOKEN: 0x200008A
FIELDS:
METHODS:
  System.Void ModifyVertices(System.Collections.Generic.List<UnityEngine.UIVertex> verts)
END_CLASS

CLASS: UnityEngine.UI.IMeshModifier
TYPE:  interface
TOKEN: 0x200008B
FIELDS:
METHODS:
  System.Void ModifyMesh(UnityEngine.Mesh mesh)
  System.Void ModifyMesh(UnityEngine.UI.VertexHelper verts)
END_CLASS

CLASS: UnityEngine.UI.Outline
TYPE:  class
TOKEN: 0x200008C
EXTENDS: Shadow
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void ModifyMesh(UnityEngine.UI.VertexHelper vh)
END_CLASS

CLASS: UnityEngine.UI.PositionAsUV1
TYPE:  class
TOKEN: 0x200008D
EXTENDS: BaseMeshEffect
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void ModifyMesh(UnityEngine.UI.VertexHelper vh)
END_CLASS

CLASS: UnityEngine.UI.Shadow
TYPE:  class
TOKEN: 0x200008E
EXTENDS: BaseMeshEffect
FIELDS:
  private           UnityEngine.Color               m_EffectColor  // 0x20
  private           UnityEngine.Vector2             m_EffectDistance  // 0x30
  private           System.Boolean                  m_UseGraphicAlpha  // 0x38
  private   static  System.Single                   kMaxEffectDistance  // 0x0
METHODS:
  System.Void .ctor()
  UnityEngine.Color get_effectColor()
  System.Void set_effectColor(UnityEngine.Color value)
  UnityEngine.Vector2 get_effectDistance()
  System.Void set_effectDistance(UnityEngine.Vector2 value)
  System.Boolean get_useGraphicAlpha()
  System.Void set_useGraphicAlpha(System.Boolean value)
  System.Void ApplyShadowZeroAlloc(System.Collections.Generic.List<UnityEngine.UIVertex> verts, UnityEngine.Color32 color, System.Int32 start, System.Int32 end, System.Single x, System.Single y)
  System.Void ApplyShadow(System.Collections.Generic.List<UnityEngine.UIVertex> verts, UnityEngine.Color32 color, System.Int32 start, System.Int32 end, System.Single x, System.Single y)
  System.Void ModifyMesh(UnityEngine.UI.VertexHelper vh)
END_CLASS

CLASS: UnityEngine.UI.Collections.IndexedSet`1
TYPE:  class
TOKEN: 0x200008F
FIELDS:
  private   readonly System.Collections.Generic.List<T>m_List  // 0x0
  private           System.Collections.Generic.Dictionary<T,System.Int32>m_Dictionary  // 0x0
METHODS:
  System.Void Add(T item)
  System.Boolean AddUnique(T item)
  System.Boolean Remove(T item)
  System.Collections.Generic.IEnumerator<T> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void Clear()
  System.Boolean Contains(T item)
  System.Void CopyTo(T[] array, System.Int32 arrayIndex)
  System.Int32 get_Count()
  System.Boolean get_IsReadOnly()
  System.Int32 IndexOf(T item)
  System.Void Insert(System.Int32 index, T item)
  System.Void RemoveAt(System.Int32 index)
  T get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, T value)
  System.Void RemoveAll(System.Predicate<T> match)
  System.Void Sort(System.Comparison<T> sortLayoutFunction)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UI.CoroutineTween.ITweenValue
TYPE:  interface
TOKEN: 0x2000090
FIELDS:
METHODS:
  System.Void TweenValue(System.Single floatPercentage)
  System.Boolean get_ignoreTimeScale()
  System.Single get_duration()
  System.Boolean ValidTarget()
END_CLASS

CLASS: UnityEngine.UI.CoroutineTween.ColorTween
TYPE:  struct
TOKEN: 0x2000091
FIELDS:
  private           UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenCallbackm_Target  // 0x10
  private           UnityEngine.Color               m_StartColor  // 0x18
  private           UnityEngine.Color               m_TargetColor  // 0x28
  private           UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenModem_TweenMode  // 0x38
  private           System.Single                   m_Duration  // 0x3C
  private           System.Boolean                  m_IgnoreTimeScale  // 0x40
METHODS:
  UnityEngine.Color get_startColor()
  System.Void set_startColor(UnityEngine.Color value)
  UnityEngine.Color get_targetColor()
  System.Void set_targetColor(UnityEngine.Color value)
  UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode get_tweenMode()
  System.Void set_tweenMode(UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode value)
  System.Single get_duration()
  System.Void set_duration(System.Single value)
  System.Boolean get_ignoreTimeScale()
  System.Void set_ignoreTimeScale(System.Boolean value)
  System.Void TweenValue(System.Single floatPercentage)
  System.Void AddOnChangedCallback(UnityEngine.Events.UnityAction<UnityEngine.Color> callback)
  System.Boolean GetIgnoreTimescale()
  System.Single GetDuration()
  System.Boolean ValidTarget()
END_CLASS

CLASS: UnityEngine.UI.CoroutineTween.FloatTween
TYPE:  struct
TOKEN: 0x2000094
FIELDS:
  private           UnityEngine.UI.CoroutineTween.FloatTween.FloatTweenCallbackm_Target  // 0x10
  private           System.Single                   m_StartValue  // 0x18
  private           System.Single                   m_TargetValue  // 0x1C
  private           System.Single                   m_Duration  // 0x20
  private           System.Boolean                  m_IgnoreTimeScale  // 0x24
METHODS:
  System.Single get_startValue()
  System.Void set_startValue(System.Single value)
  System.Single get_targetValue()
  System.Void set_targetValue(System.Single value)
  System.Single get_duration()
  System.Void set_duration(System.Single value)
  System.Boolean get_ignoreTimeScale()
  System.Void set_ignoreTimeScale(System.Boolean value)
  System.Void TweenValue(System.Single floatPercentage)
  System.Void AddOnChangedCallback(UnityEngine.Events.UnityAction<System.Single> callback)
  System.Boolean GetIgnoreTimescale()
  System.Single GetDuration()
  System.Boolean ValidTarget()
END_CLASS

CLASS: UnityEngine.UI.CoroutineTween.TweenRunner`1
TYPE:  class
TOKEN: 0x2000096
FIELDS:
  protected         UnityEngine.MonoBehaviour       m_CoroutineContainer  // 0x0
  protected         System.Collections.IEnumerator  m_Tween  // 0x0
METHODS:
  System.Collections.IEnumerator Start(T tweenInfo)
  System.Void Init(UnityEngine.MonoBehaviour coroutineContainer)
  System.Void StartTween(T info)
  System.Void StopTween()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PanelEventHandler
TYPE:  class
TOKEN: 0x2000098
EXTENDS: UIBehaviour
FIELDS:
  private           UnityEngine.UIElements.BaseRuntimePanelm_Panel  // 0x18
  private   readonly UnityEngine.UIElements.PanelEventHandler.PointerEventm_PointerEvent  // 0x20
  private           System.Boolean                  m_Selecting  // 0x28
  private           UnityEngine.Event               m_Event  // 0x30
  private   static  UnityEngine.EventModifiers      s_Modifiers  // 0x0
METHODS:
  UnityEngine.UIElements.IPanel get_panel()
  System.Void set_panel(UnityEngine.UIElements.IPanel value)
  UnityEngine.GameObject get_selectableGameObject()
  UnityEngine.EventSystems.EventSystem get_eventSystem()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void RegisterCallbacks()
  System.Void UnregisterCallbacks()
  System.Void OnPanelDestroyed()
  System.Void OnElementFocus(UnityEngine.UIElements.FocusEvent e)
  System.Void OnElementBlur(UnityEngine.UIElements.BlurEvent e)
  System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void OnPointerMove(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void OnCancel(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void OnMove(UnityEngine.EventSystems.AxisEventData eventData)
  System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.EventSystems.BaseEventData sourceEventData)
  System.Void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.Event sourceEvent)
  System.Void Update()
  System.Void LateUpdate()
  System.Void ProcessImguiEvents(System.Boolean isSelected)
  System.Void ProcessKeyboardEvent(UnityEngine.Event e)
  System.Void ProcessTabEvent(UnityEngine.Event e)
  System.Void SendTabEvent(UnityEngine.Event e, System.Int32 direction)
  System.Void SendKeyUpEvent(UnityEngine.Event e, UnityEngine.KeyCode keyCode, UnityEngine.EventModifiers modifiers)
  System.Void SendKeyDownEvent(UnityEngine.Event e, UnityEngine.KeyCode keyCode, UnityEngine.EventModifiers modifiers)
  System.Void SendTextEvent(UnityEngine.Event e, System.Char c, UnityEngine.EventModifiers modifiers)
  System.Boolean ReadPointerData(UnityEngine.UIElements.PanelEventHandler.PointerEvent pe, UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.UIElements.PanelEventHandler.PointerEventType eventType)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PanelRaycaster
TYPE:  class
TOKEN: 0x200009B
EXTENDS: BaseRaycaster
FIELDS:
  private           UnityEngine.UIElements.BaseRuntimePanelm_Panel  // 0x20
METHODS:
  UnityEngine.UIElements.IPanel get_panel()
  System.Void set_panel(UnityEngine.UIElements.IPanel value)
  System.Void RegisterCallbacks()
  System.Void UnregisterCallbacks()
  System.Void OnPanelDestroyed()
  UnityEngine.GameObject get_selectableGameObject()
  System.Int32 get_sortOrderPriority()
  System.Int32 get_renderOrderPriority()
  System.Void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList)
  UnityEngine.Camera get_eventCamera()
  System.Int32 ConvertFloatBitsToInt(System.Single f)
  System.Void .ctor()
END_CLASS

