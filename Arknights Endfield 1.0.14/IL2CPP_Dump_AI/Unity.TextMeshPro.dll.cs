// ========================================================
// Dumped by @desirepro
// Assembly: Unity.TextMeshPro.dll
// Classes:  180
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: AnchorPositions
TYPE:  struct
TOKEN: 0x200002E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TMP_Compatibility.AnchorPositionsTopLeft  // 0x0
  public    static  TMPro.TMP_Compatibility.AnchorPositionsTop  // 0x0
  public    static  TMPro.TMP_Compatibility.AnchorPositionsTopRight  // 0x0
  public    static  TMPro.TMP_Compatibility.AnchorPositionsLeft  // 0x0
  public    static  TMPro.TMP_Compatibility.AnchorPositionsCenter  // 0x0
  public    static  TMPro.TMP_Compatibility.AnchorPositionsRight  // 0x0
  public    static  TMPro.TMP_Compatibility.AnchorPositionsBottomLeft  // 0x0
  public    static  TMPro.TMP_Compatibility.AnchorPositionsBottom  // 0x0
  public    static  TMPro.TMP_Compatibility.AnchorPositionsBottomRight  // 0x0
  public    static  TMPro.TMP_Compatibility.AnchorPositionsBaseLine  // 0x0
  public    static  TMPro.TMP_Compatibility.AnchorPositionsNone  // 0x0
METHODS:
END_CLASS

CLASS: ColorTweenMode
TYPE:  struct
TOKEN: 0x2000031
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.ColorTween.ColorTweenMode All  // 0x0
  public    static  TMPro.ColorTween.ColorTweenMode RGB  // 0x0
  public    static  TMPro.ColorTween.ColorTweenMode Alpha  // 0x0
METHODS:
END_CLASS

CLASS: ColorTweenCallback
TYPE:  class
TOKEN: 0x2000032
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: FloatTweenCallback
TYPE:  class
TOKEN: 0x2000034
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Resources
TYPE:  struct
TOKEN: 0x2000038
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
TOKEN: 0x200003A
EXTENDS: MonoBehaviour
FIELDS:
  private           TMPro.TMP_Text                  m_Text  // 0x18
  private           UnityEngine.UI.Image            m_Image  // 0x20
  private           UnityEngine.RectTransform       m_RectTransform  // 0x28
  private           UnityEngine.UI.Toggle           m_Toggle  // 0x30
METHODS:
  TMPro.TMP_Text get_text()
  System.Void set_text(TMPro.TMP_Text value)
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
TOKEN: 0x200003B
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
TOKEN: 0x200003C
FIELDS:
  private           System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData>m_Options  // 0x10
METHODS:
  System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> get_options()
  System.Void set_options(System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> value)
  System.Void .ctor()
END_CLASS

CLASS: DropdownEvent
TYPE:  class
TOKEN: 0x200003D
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ContentType
TYPE:  struct
TOKEN: 0x2000059
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TMP_InputField.ContentTypeStandard  // 0x0
  public    static  TMPro.TMP_InputField.ContentTypeAutocorrected  // 0x0
  public    static  TMPro.TMP_InputField.ContentTypeIntegerNumber  // 0x0
  public    static  TMPro.TMP_InputField.ContentTypeDecimalNumber  // 0x0
  public    static  TMPro.TMP_InputField.ContentTypeAlphanumeric  // 0x0
  public    static  TMPro.TMP_InputField.ContentTypeName  // 0x0
  public    static  TMPro.TMP_InputField.ContentTypeEmailAddress  // 0x0
  public    static  TMPro.TMP_InputField.ContentTypePassword  // 0x0
  public    static  TMPro.TMP_InputField.ContentTypePin  // 0x0
  public    static  TMPro.TMP_InputField.ContentTypeCustom  // 0x0
METHODS:
END_CLASS

CLASS: InputType
TYPE:  struct
TOKEN: 0x200005A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TMP_InputField.InputType  Standard  // 0x0
  public    static  TMPro.TMP_InputField.InputType  AutoCorrect  // 0x0
  public    static  TMPro.TMP_InputField.InputType  Password  // 0x0
METHODS:
END_CLASS

CLASS: CharacterValidation
TYPE:  struct
TOKEN: 0x200005B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TMP_InputField.CharacterValidationNone  // 0x0
  public    static  TMPro.TMP_InputField.CharacterValidationDigit  // 0x0
  public    static  TMPro.TMP_InputField.CharacterValidationInteger  // 0x0
  public    static  TMPro.TMP_InputField.CharacterValidationDecimal  // 0x0
  public    static  TMPro.TMP_InputField.CharacterValidationAlphanumeric  // 0x0
  public    static  TMPro.TMP_InputField.CharacterValidationName  // 0x0
  public    static  TMPro.TMP_InputField.CharacterValidationRegex  // 0x0
  public    static  TMPro.TMP_InputField.CharacterValidationEmailAddress  // 0x0
  public    static  TMPro.TMP_InputField.CharacterValidationCustomValidator  // 0x0
METHODS:
END_CLASS

CLASS: LineType
TYPE:  struct
TOKEN: 0x200005C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TMP_InputField.LineType   SingleLine  // 0x0
  public    static  TMPro.TMP_InputField.LineType   MultiLineSubmit  // 0x0
  public    static  TMPro.TMP_InputField.LineType   MultiLineNewline  // 0x0
METHODS:
END_CLASS

CLASS: OnValidateInput
TYPE:  class
TOKEN: 0x200005D
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
TOKEN: 0x200005E
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: OnChangeEvent
TYPE:  class
TOKEN: 0x200005F
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: SelectionEvent
TYPE:  class
TOKEN: 0x2000060
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: TextSelectionEvent
TYPE:  class
TOKEN: 0x2000061
EXTENDS: UnityEvent`3
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: TouchScreenKeyboardEvent
TYPE:  class
TOKEN: 0x2000062
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: EditState
TYPE:  struct
TOKEN: 0x2000063
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TMP_InputField.EditState  Continue  // 0x0
  public    static  TMPro.TMP_InputField.EditState  Finish  // 0x0
METHODS:
END_CLASS

CLASS: FallbackMaterial
TYPE:  class
TOKEN: 0x200006C
FIELDS:
  public            System.Int64                    fallbackID  // 0x10
  public            UnityEngine.Material            sourceMaterial  // 0x18
  private           System.Int32                    sourceMaterialCRC  // 0x20
  public            UnityEngine.Material            fallbackMaterial  // 0x28
  public            System.Int32                    count  // 0x30
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: MaskingMaterial
TYPE:  class
TOKEN: 0x200006D
FIELDS:
  public            UnityEngine.Material            baseMaterial  // 0x10
  public            UnityEngine.Material            stencilMaterial  // 0x18
  public            System.Int32                    count  // 0x20
  public            System.Int32                    stencilID  // 0x24
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: LineBreakingTable
TYPE:  class
TOKEN: 0x200007D
FIELDS:
  public            System.Collections.Generic.Dictionary<System.Int32,System.Char>leadingCharacters  // 0x10
  public            System.Collections.Generic.Dictionary<System.Int32,System.Char>followingCharacters  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: CharacterSubstitution
TYPE:  struct
TOKEN: 0x2000098
FIELDS:
  public            System.Int32                    index  // 0x10
  public            System.UInt32                   unicode  // 0x14
METHODS:
  System.Void .ctor(System.Int32 index, System.UInt32 unicode)
END_CLASS

CLASS: TextInputSources
TYPE:  struct
TOKEN: 0x2000099
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TMP_Text.TextInputSources TextInputBox  // 0x0
  public    static  TMPro.TMP_Text.TextInputSources SetText  // 0x0
  public    static  TMPro.TMP_Text.TextInputSources SetTextArray  // 0x0
  public    static  TMPro.TMP_Text.TextInputSources TextString  // 0x0
METHODS:
END_CLASS

CLASS: UnicodeChar
TYPE:  struct
TOKEN: 0x200009A
FIELDS:
  public            System.Int32                    unicode  // 0x10
  public            System.Int32                    stringIndex  // 0x14
  public            System.Int32                    length  // 0x18
METHODS:
END_CLASS

CLASS: SpecialCharacter
TYPE:  struct
TOKEN: 0x200009B
FIELDS:
  public            TMPro.TMP_Character             character  // 0x10
  public            TMPro.TMP_FontAsset             fontAsset  // 0x18
  public            UnityEngine.Material            material  // 0x20
  public            System.Int32                    materialIndex  // 0x28
METHODS:
  System.Void .ctor(TMPro.TMP_Character character, System.Int32 materialIndex)
END_CLASS

CLASS: TextBackingContainer
TYPE:  struct
TOKEN: 0x200009C
FIELDS:
  private           System.UInt32[]                 m_Array  // 0x10
  private           System.Int32                    m_Count  // 0x18
METHODS:
  System.Int32 get_Capacity()
  System.Int32 get_Count()
  System.Void set_Count(System.Int32 value)
  System.UInt32 get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, System.UInt32 value)
  System.Void .ctor(System.Int32 size)
  System.Void Resize(System.Int32 size)
  System.Void Dispose()
END_CLASS

CLASS: LineSegment
TYPE:  struct
TOKEN: 0x20000A9
FIELDS:
  public            UnityEngine.Vector3             Point1  // 0x10
  public            UnityEngine.Vector3             Point2  // 0x1C
METHODS:
  System.Void .ctor(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2)
END_CLASS

CLASS: SpriteFrame
TYPE:  struct
TOKEN: 0x20000AE
FIELDS:
  public            System.Single                   x  // 0x10
  public            System.Single                   y  // 0x14
  public            System.Single                   w  // 0x18
  public            System.Single                   h  // 0x1C
METHODS:
  System.String ToString()
END_CLASS

CLASS: SpriteSize
TYPE:  struct
TOKEN: 0x20000AF
FIELDS:
  public            System.Single                   w  // 0x10
  public            System.Single                   h  // 0x14
METHODS:
  System.String ToString()
END_CLASS

CLASS: Frame
TYPE:  struct
TOKEN: 0x20000B0
FIELDS:
  public            System.String                   filename  // 0x10
  public            TMPro.SpriteAssetUtilities.TexturePacker_JsonArray.SpriteFrameframe  // 0x18
  public            System.Boolean                  rotated  // 0x28
  public            System.Boolean                  trimmed  // 0x29
  public            TMPro.SpriteAssetUtilities.TexturePacker_JsonArray.SpriteFramespriteSourceSize  // 0x2C
  public            TMPro.SpriteAssetUtilities.TexturePacker_JsonArray.SpriteSizesourceSize  // 0x3C
  public            UnityEngine.Vector2             pivot  // 0x44
METHODS:
END_CLASS

CLASS: Meta
TYPE:  struct
TOKEN: 0x20000B1
FIELDS:
  public            System.String                   app  // 0x10
  public            System.String                   version  // 0x18
  public            System.String                   image  // 0x20
  public            System.String                   format  // 0x28
  public            TMPro.SpriteAssetUtilities.TexturePacker_JsonArray.SpriteSizesize  // 0x30
  public            System.Single                   scale  // 0x38
  public            System.String                   smartupdate  // 0x40
METHODS:
END_CLASS

CLASS: SpriteDataObject
TYPE:  class
TOKEN: 0x20000B2
FIELDS:
  public            System.Collections.Generic.List<TMPro.SpriteAssetUtilities.TexturePacker_JsonArray.Frame>frames  // 0x10
  public            TMPro.SpriteAssetUtilities.TexturePacker_JsonArray.Metameta  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: __StaticArrayInitTypeSize=12
TYPE:  struct
TOKEN: 0x20000B4
FIELDS:
METHODS:
END_CLASS

CLASS: TMPro.FastAction
TYPE:  class
TOKEN: 0x2000002
FIELDS:
  private           System.Collections.Generic.LinkedList<System.Action>delegates  // 0x10
  private           System.Collections.Generic.Dictionary<System.Action,System.Collections.Generic.LinkedListNode<System.Action>>lookup  // 0x18
METHODS:
  System.Void Add(System.Action rhs)
  System.Void Remove(System.Action rhs)
  System.Void Call()
  System.Void .ctor()
END_CLASS

CLASS: TMPro.FastAction`1
TYPE:  class
TOKEN: 0x2000003
FIELDS:
  private           System.Collections.Generic.LinkedList<System.Action<A>>delegates  // 0x0
  private           System.Collections.Generic.Dictionary<System.Action<A>,System.Collections.Generic.LinkedListNode<System.Action<A>>>lookup  // 0x0
METHODS:
  System.Void Add(System.Action<A> rhs)
  System.Void Remove(System.Action<A> rhs)
  System.Void Call(A a)
  System.Void .ctor()
END_CLASS

CLASS: TMPro.FastAction`2
TYPE:  class
TOKEN: 0x2000004
FIELDS:
  private           System.Collections.Generic.LinkedList<System.Action<A,B>>delegates  // 0x0
  private           System.Collections.Generic.Dictionary<System.Action<A,B>,System.Collections.Generic.LinkedListNode<System.Action<A,B>>>lookup  // 0x0
METHODS:
  System.Void Add(System.Action<A,B> rhs)
  System.Void Remove(System.Action<A,B> rhs)
  System.Void Call(A a, B b)
  System.Void .ctor()
END_CLASS

CLASS: TMPro.FastAction`3
TYPE:  class
TOKEN: 0x2000005
FIELDS:
  private           System.Collections.Generic.LinkedList<System.Action<A,B,C>>delegates  // 0x0
  private           System.Collections.Generic.Dictionary<System.Action<A,B,C>,System.Collections.Generic.LinkedListNode<System.Action<A,B,C>>>lookup  // 0x0
METHODS:
  System.Void Add(System.Action<A,B,C> rhs)
  System.Void Remove(System.Action<A,B,C> rhs)
  System.Void Call(A a, B b, C c)
  System.Void .ctor()
END_CLASS

CLASS: TMPro.IFontAssetLoader
TYPE:  interface
TOKEN: 0x2000006
FIELDS:
METHODS:
  System.Boolean TryGetFontAsset(TMPro.TMP_Text refText, System.UInt32 unicode, TMPro.TMP_FontAsset& fontAsset)
  System.Void TryRemoveRefText(TMPro.TMP_Text refText)
END_CLASS

CLASS: TMPro.ITextPreprocessor
TYPE:  interface
TOKEN: 0x2000007
FIELDS:
METHODS:
  System.String PreprocessText(System.String text)
END_CLASS

CLASS: TMPro.MaterialReferenceManager
TYPE:  class
TOKEN: 0x2000008
FIELDS:
  private   static  TMPro.MaterialReferenceManager  s_Instance  // 0x0
  private           System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Material>m_FontMaterialReferenceLookup  // 0x10
  private           System.Collections.Generic.Dictionary<System.Int32,TMPro.TMP_FontAsset>m_FontAssetReferenceLookup  // 0x18
  private           System.Collections.Generic.Dictionary<System.Int32,TMPro.TMP_SpriteAsset>m_SpriteAssetReferenceLookup  // 0x20
  private           System.Collections.Generic.Dictionary<System.Int32,TMPro.TMP_ColorGradient>m_ColorGradientReferenceLookup  // 0x28
METHODS:
  TMPro.MaterialReferenceManager get_instance()
  System.Void AddFontAsset(TMPro.TMP_FontAsset fontAsset)
  System.Void AddFontAssetInternal(TMPro.TMP_FontAsset fontAsset)
  System.Void AddSpriteAsset(TMPro.TMP_SpriteAsset spriteAsset)
  System.Void AddSpriteAssetInternal(TMPro.TMP_SpriteAsset spriteAsset)
  System.Void AddSpriteAsset(System.Int32 hashCode, TMPro.TMP_SpriteAsset spriteAsset)
  System.Void AddSpriteAssetInternal(System.Int32 hashCode, TMPro.TMP_SpriteAsset spriteAsset)
  System.Void AddFontMaterial(System.Int32 hashCode, UnityEngine.Material material)
  System.Void AddFontMaterialInternal(System.Int32 hashCode, UnityEngine.Material material)
  System.Void AddColorGradientPreset(System.Int32 hashCode, TMPro.TMP_ColorGradient spriteAsset)
  System.Void AddColorGradientPreset_Internal(System.Int32 hashCode, TMPro.TMP_ColorGradient spriteAsset)
  System.Boolean Contains(TMPro.TMP_FontAsset font)
  System.Boolean Contains(TMPro.TMP_SpriteAsset sprite)
  System.Boolean TryGetFontAsset(System.Int32 hashCode, TMPro.TMP_FontAsset& fontAsset)
  System.Boolean TryGetFontAssetInternal(System.Int32 hashCode, TMPro.TMP_FontAsset& fontAsset)
  System.Boolean TryGetSpriteAsset(System.Int32 hashCode, TMPro.TMP_SpriteAsset& spriteAsset)
  System.Boolean TryGetSpriteAssetInternal(System.Int32 hashCode, TMPro.TMP_SpriteAsset& spriteAsset)
  System.Boolean TryGetColorGradientPreset(System.Int32 hashCode, TMPro.TMP_ColorGradient& gradientPreset)
  System.Boolean TryGetColorGradientPresetInternal(System.Int32 hashCode, TMPro.TMP_ColorGradient& gradientPreset)
  System.Boolean TryGetMaterial(System.Int32 hashCode, UnityEngine.Material& material)
  System.Boolean TryGetMaterialInternal(System.Int32 hashCode, UnityEngine.Material& material)
  System.Void .ctor()
END_CLASS

CLASS: TMPro.TMP_MaterialReference
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  public            UnityEngine.Material            material  // 0x10
  public            System.Int32                    referenceCount  // 0x18
METHODS:
END_CLASS

CLASS: TMPro.MaterialReference
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            System.Int32                    index  // 0x10
  public            TMPro.TMP_FontAsset             fontAsset  // 0x18
  public            TMPro.TMP_SpriteAsset           spriteAsset  // 0x20
  public            UnityEngine.Material            material  // 0x28
  public            System.Boolean                  isDefaultMaterial  // 0x30
  public            System.Boolean                  isFallbackMaterial  // 0x31
  public            UnityEngine.Material            fallbackMaterial  // 0x38
  public            System.Single                   padding  // 0x40
  public            System.Int32                    referenceCount  // 0x44
METHODS:
  System.Void .ctor(System.Int32 index, TMPro.TMP_FontAsset fontAsset, TMPro.TMP_SpriteAsset spriteAsset, UnityEngine.Material material, System.Single padding)
  System.Boolean Contains(TMPro.MaterialReference[] materialReferences, TMPro.TMP_FontAsset fontAsset)
  System.Int32 AddMaterialReference(UnityEngine.Material material, TMPro.TMP_FontAsset fontAsset, TMPro.MaterialReference[]& materialReferences, System.Collections.Generic.Dictionary<System.Int32,System.Int32> materialReferenceIndexLookup)
  System.Int32 AddMaterialReference(UnityEngine.Material material, TMPro.TMP_SpriteAsset spriteAsset, TMPro.MaterialReference[]& materialReferences, System.Collections.Generic.Dictionary<System.Int32,System.Int32> materialReferenceIndexLookup)
END_CLASS

CLASS: TMPro.TextContainerAnchors
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TextContainerAnchors      TopLeft  // 0x0
  public    static  TMPro.TextContainerAnchors      Top  // 0x0
  public    static  TMPro.TextContainerAnchors      TopRight  // 0x0
  public    static  TMPro.TextContainerAnchors      Left  // 0x0
  public    static  TMPro.TextContainerAnchors      Middle  // 0x0
  public    static  TMPro.TextContainerAnchors      Right  // 0x0
  public    static  TMPro.TextContainerAnchors      BottomLeft  // 0x0
  public    static  TMPro.TextContainerAnchors      Bottom  // 0x0
  public    static  TMPro.TextContainerAnchors      BottomRight  // 0x0
  public    static  TMPro.TextContainerAnchors      Custom  // 0x0
METHODS:
END_CLASS

CLASS: TMPro.TextContainer
TYPE:  class
TOKEN: 0x200000C
EXTENDS: UIBehaviour
FIELDS:
  private           System.Boolean                  m_hasChanged  // 0x18
  private           UnityEngine.Vector2             m_pivot  // 0x1C
  private           TMPro.TextContainerAnchors      m_anchorPosition  // 0x24
  private           UnityEngine.Rect                m_rect  // 0x28
  private           System.Boolean                  m_isDefaultWidth  // 0x38
  private           System.Boolean                  m_isDefaultHeight  // 0x39
  private           System.Boolean                  m_isAutoFitting  // 0x3A
  private           UnityEngine.Vector3[]           m_corners  // 0x40
  private           UnityEngine.Vector3[]           m_worldCorners  // 0x48
  private           UnityEngine.Vector4             m_margins  // 0x50
  private           UnityEngine.RectTransform       m_rectTransform  // 0x60
  private   static  UnityEngine.Vector2             k_defaultSize  // 0x0
  private           TMPro.TextMeshPro               m_textMeshPro  // 0x68
METHODS:
  System.Boolean get_hasChanged()
  System.Void set_hasChanged(System.Boolean value)
  UnityEngine.Vector2 get_pivot()
  System.Void set_pivot(UnityEngine.Vector2 value)
  TMPro.TextContainerAnchors get_anchorPosition()
  System.Void set_anchorPosition(TMPro.TextContainerAnchors value)
  UnityEngine.Rect get_rect()
  System.Void set_rect(UnityEngine.Rect value)
  UnityEngine.Vector2 get_size()
  System.Void set_size(UnityEngine.Vector2 value)
  System.Single get_width()
  System.Void set_width(System.Single value)
  System.Single get_height()
  System.Void set_height(System.Single value)
  System.Boolean get_isDefaultWidth()
  System.Boolean get_isDefaultHeight()
  System.Boolean get_isAutoFitting()
  System.Void set_isAutoFitting(System.Boolean value)
  UnityEngine.Vector3[] get_corners()
  UnityEngine.Vector3[] get_worldCorners()
  UnityEngine.Vector4 get_margins()
  System.Void set_margins(UnityEngine.Vector4 value)
  UnityEngine.RectTransform get_rectTransform()
  TMPro.TextMeshPro get_textMeshPro()
  System.Void Awake()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnContainerChanged()
  System.Void OnRectTransformDimensionsChange()
  System.Void SetRect(UnityEngine.Vector2 size)
  System.Void UpdateCorners()
  UnityEngine.Vector2 GetPivot(TMPro.TextContainerAnchors anchor)
  TMPro.TextContainerAnchors GetAnchorPosition(UnityEngine.Vector2 pivot)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: TMPro.TextMeshPro
TYPE:  class
TOKEN: 0x200000D
EXTENDS: TMP_Text
FIELDS:
  private           System.Int32                    _SortingLayer  // 0xAF8
  private           System.Int32                    _SortingLayerID  // 0xAFC
  private           System.Int32                    _SortingOrder  // 0xB00
  private           System.Action<TMPro.TMP_TextInfo>OnPreRenderText  // 0xB08
  private           System.Boolean                  m_currentAutoSizeMode  // 0xB10
  private           System.Boolean                  m_hasFontAssetChanged  // 0xB11
  private           System.Single                   m_previousLossyScaleY  // 0xB14
  private           UnityEngine.Renderer            m_renderer  // 0xB18
  private           UnityEngine.MeshFilter          m_meshFilter  // 0xB20
  private           System.Boolean                  m_isFirstAllocation  // 0xB28
  private           System.Int32                    m_max_characters  // 0xB2C
  private           System.Int32                    m_max_numberOfLines  // 0xB30
  private           TMPro.TMP_SubMesh[]             m_subTextObjects  // 0xB38
  private           TMPro.MaskingTypes              m_maskType  // 0xB40
  private           UnityEngine.Matrix4x4           m_EnvMapMatrix  // 0xB44
  private           UnityEngine.Vector3[]           m_RectTransformCorners  // 0xB88
  private           System.Boolean                  m_isRegisteredForEvents  // 0xB90
  private   static  Unity.Profiling.ProfilerMarker  k_GenerateTextMarker  // 0x0
  private   static  Unity.Profiling.ProfilerMarker  k_SetArraySizesMarker  // 0x8
  private   static  Unity.Profiling.ProfilerMarker  k_GenerateTextPhaseIMarker  // 0x10
  private   static  Unity.Profiling.ProfilerMarker  k_ParseMarkupTextMarker  // 0x18
  private   static  Unity.Profiling.ProfilerMarker  k_CharacterLookupMarker  // 0x20
  private   static  Unity.Profiling.ProfilerMarker  k_HandleGPOSFeaturesMarker  // 0x28
  private   static  Unity.Profiling.ProfilerMarker  k_CalculateVerticesPositionMarker  // 0x30
  private   static  Unity.Profiling.ProfilerMarker  k_ComputeTextMetricsMarker  // 0x38
  private   static  Unity.Profiling.ProfilerMarker  k_HandleVisibleCharacterMarker  // 0x40
  private   static  Unity.Profiling.ProfilerMarker  k_HandleWhiteSpacesMarker  // 0x48
  private   static  Unity.Profiling.ProfilerMarker  k_HandleHorizontalLineBreakingMarker  // 0x50
  private   static  Unity.Profiling.ProfilerMarker  k_HandleVerticalLineBreakingMarker  // 0x58
  private   static  Unity.Profiling.ProfilerMarker  k_SaveGlyphVertexDataMarker  // 0x60
  private   static  Unity.Profiling.ProfilerMarker  k_ComputeCharacterAdvanceMarker  // 0x68
  private   static  Unity.Profiling.ProfilerMarker  k_HandleCarriageReturnMarker  // 0x70
  private   static  Unity.Profiling.ProfilerMarker  k_HandleLineTerminationMarker  // 0x78
  private   static  Unity.Profiling.ProfilerMarker  k_SavePageInfoMarker  // 0x80
  private   static  Unity.Profiling.ProfilerMarker  k_SaveProcessingStatesMarker  // 0x88
  private   static  Unity.Profiling.ProfilerMarker  k_GenerateTextPhaseIIMarker  // 0x90
  private   static  Unity.Profiling.ProfilerMarker  k_GenerateTextPhaseIIIMarker  // 0x98
METHODS:
  System.Int32 get_sortingLayerID()
  System.Void set_sortingLayerID(System.Int32 value)
  System.Int32 get_sortingOrder()
  System.Void set_sortingOrder(System.Int32 value)
  System.Boolean get_autoSizeTextContainer()
  System.Void set_autoSizeTextContainer(System.Boolean value)
  TMPro.TextContainer get_textContainer()
  UnityEngine.Transform get_transform()
  UnityEngine.Renderer get_renderer()
  UnityEngine.Mesh get_mesh()
  UnityEngine.MeshFilter get_meshFilter()
  TMPro.MaskingTypes get_maskType()
  System.Void set_maskType(TMPro.MaskingTypes value)
  System.Void SetMask(TMPro.MaskingTypes type, UnityEngine.Vector4 maskCoords)
  System.Void SetMask(TMPro.MaskingTypes type, UnityEngine.Vector4 maskCoords, System.Single softnessX, System.Single softnessY)
  System.Void SetVerticesDirty()
  System.Void SetLayoutDirty()
  System.Void SetMaterialDirty()
  System.Void SetAllDirty()
  System.Void Rebuild(UnityEngine.UI.CanvasUpdate update)
  System.Void UpdateMaterial()
  System.Void UpdateMeshPadding()
  System.Void ForceMeshUpdate(System.Boolean ignoreActiveState, System.Boolean forceTextReparsing)
  TMPro.TMP_TextInfo GetTextInfo(System.String text)
  System.Void ClearMesh(System.Boolean updateMesh)
  System.Void add_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value)
  System.Void remove_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value)
  System.Void UpdateGeometry(UnityEngine.Mesh mesh, System.Int32 index)
  System.Void UpdateVertexData(TMPro.TMP_VertexDataUpdateFlags flags)
  System.Void UpdateVertexData()
  System.Void UpdateFontAsset()
  System.Void CalculateLayoutInputHorizontal()
  System.Void CalculateLayoutInputVertical()
  System.Void Awake()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void LoadFontAsset()
  System.Void UpdateEnvMapMatrix()
  System.Void SetMask(TMPro.MaskingTypes maskType)
  System.Void SetMaskCoordinates(UnityEngine.Vector4 coords)
  System.Void SetMaskCoordinates(UnityEngine.Vector4 coords, System.Single softX, System.Single softY)
  System.Void EnableMasking()
  System.Void DisableMasking()
  System.Void UpdateMask()
  UnityEngine.Material GetMaterial(UnityEngine.Material mat)
  UnityEngine.Material[] GetMaterials(UnityEngine.Material[] mats)
  System.Void SetSharedMaterial(UnityEngine.Material mat)
  UnityEngine.Material[] GetSharedMaterials()
  System.Void SetSharedMaterials(UnityEngine.Material[] materials)
  System.Void SetOutlineThickness(System.Single thickness)
  System.Void SetFaceColor(UnityEngine.Color32 color)
  System.Void SetOutlineColor(UnityEngine.Color32 color)
  System.Void CreateMaterialInstance()
  System.Void SetShaderDepth()
  System.Void SetCulling()
  System.Void SetPerspectiveCorrection()
  System.Int32 SetArraySizes(TMPro.TMP_Text.UnicodeChar[] unicodeChars)
  System.Void ComputeMarginSize()
  System.Void OnDidApplyAnimationProperties()
  System.Void OnTransformParentChanged()
  System.Void OnRectTransformDimensionsChange()
  System.Void InternalUpdate()
  System.Void OnPreRenderObject()
  System.Void GenerateTextMesh()
  UnityEngine.Vector3[] GetTextContainerLocalCorners()
  System.Void SetMeshFilters(System.Boolean state)
  System.Void SetActiveSubMeshes(System.Boolean state)
  System.Void SetActiveSubTextObjectRenderers(System.Boolean state)
  System.Void DestroySubMeshObjects()
  System.Void UpdateSubMeshSortingLayerID(System.Int32 id)
  System.Void UpdateSubMeshSortingOrder(System.Int32 order)
  UnityEngine.Bounds GetCompoundBounds()
  System.Void UpdateSDFScale(System.Single scaleDelta)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: TMPro.TextMeshProUGUI
TYPE:  class
TOKEN: 0x200000E
EXTENDS: TMP_Text
FIELDS:
  private           System.Boolean                  m_isRebuildingLayout  // 0xAF8
  private           UnityEngine.Coroutine           m_DelayedGraphicRebuild  // 0xB00
  private           UnityEngine.Coroutine           m_DelayedMaterialRebuild  // 0xB08
  private           UnityEngine.Rect                m_ClipRect  // 0xB10
  private           System.Boolean                  m_ValidRect  // 0xB20
  private           System.Action<TMPro.TMP_TextInfo>OnPreRenderText  // 0xB28
  private           System.Boolean                  m_hasFontAssetChanged  // 0xB30
  protected         TMPro.TMP_SubMeshUI[]           m_subTextObjects  // 0xB38
  protected         UnityEngine.Vector3[]           m_RectTransformCorners  // 0xB40
  protected         UnityEngine.CanvasRenderer      m_canvasRenderer  // 0xB48
  protected         UnityEngine.Canvas              m_canvas  // 0xB50
  protected         System.Single                   m_CanvasScaleFactor  // 0xB58
  protected         System.Single                   m_previousLossyScaleY  // 0xB5C
  private           System.Boolean                  m_isFirstAllocation  // 0xB60
  private           System.Int32                    m_max_characters  // 0xB64
  private           UnityEngine.Material            m_baseMaterial  // 0xB68
  private           System.Boolean                  m_isScrollRegionSet  // 0xB70
  private           UnityEngine.Vector4             m_maskOffset  // 0xB74
  private           UnityEngine.Matrix4x4           m_EnvMapMatrix  // 0xB84
  private           System.Boolean                  m_isRegisteredForEvents  // 0xBC4
  private   static  Unity.Profiling.ProfilerMarker  k_GenerateTextMarker  // 0x0
  private   static  Unity.Profiling.ProfilerMarker  k_SetArraySizesMarker  // 0x8
  private   static  Unity.Profiling.ProfilerMarker  k_GenerateTextPhaseIMarker  // 0x10
  private   static  Unity.Profiling.ProfilerMarker  k_ParseMarkupTextMarker  // 0x18
  private   static  Unity.Profiling.ProfilerMarker  k_CharacterLookupMarker  // 0x20
  private   static  Unity.Profiling.ProfilerMarker  k_HandleGPOSFeaturesMarker  // 0x28
  private   static  Unity.Profiling.ProfilerMarker  k_CalculateVerticesPositionMarker  // 0x30
  private   static  Unity.Profiling.ProfilerMarker  k_ComputeTextMetricsMarker  // 0x38
  private   static  Unity.Profiling.ProfilerMarker  k_HandleVisibleCharacterMarker  // 0x40
  private   static  Unity.Profiling.ProfilerMarker  k_HandleWhiteSpacesMarker  // 0x48
  private   static  Unity.Profiling.ProfilerMarker  k_HandleHorizontalLineBreakingMarker  // 0x50
  private   static  Unity.Profiling.ProfilerMarker  k_HandleVerticalLineBreakingMarker  // 0x58
  private   static  Unity.Profiling.ProfilerMarker  k_SaveGlyphVertexDataMarker  // 0x60
  private   static  Unity.Profiling.ProfilerMarker  k_ComputeCharacterAdvanceMarker  // 0x68
  private   static  Unity.Profiling.ProfilerMarker  k_HandleCarriageReturnMarker  // 0x70
  private   static  Unity.Profiling.ProfilerMarker  k_HandleLineTerminationMarker  // 0x78
  private   static  Unity.Profiling.ProfilerMarker  k_SavePageInfoMarker  // 0x80
  private   static  Unity.Profiling.ProfilerMarker  k_SaveProcessingStatesMarker  // 0x88
  private   static  Unity.Profiling.ProfilerMarker  k_GenerateTextPhaseIIMarker  // 0x90
  private   static  Unity.Profiling.ProfilerMarker  k_GenerateTextPhaseIIIMarker  // 0x98
METHODS:
  UnityEngine.Material get_materialForRendering()
  System.Boolean get_autoSizeTextContainer()
  System.Void set_autoSizeTextContainer(System.Boolean value)
  UnityEngine.Mesh get_mesh()
  UnityEngine.CanvasRenderer get_canvasRenderer()
  System.Void CalculateLayoutInputHorizontal()
  System.Void CalculateLayoutInputVertical()
  System.Void SetVerticesDirty()
  System.Void SetLayoutDirty()
  System.Void SetMaterialDirty()
  System.Void SetAllDirty()
  System.Collections.IEnumerator DelayedGraphicRebuild()
  System.Collections.IEnumerator DelayedMaterialRebuild()
  System.Void Rebuild(UnityEngine.UI.CanvasUpdate update)
  System.Void UpdateSubObjectPivot()
  UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial)
  System.Void UpdateMaterial()
  UnityEngine.Vector4 get_maskOffset()
  System.Void set_maskOffset(UnityEngine.Vector4 value)
  System.Void RecalculateClipping()
  System.Void Cull(UnityEngine.Rect clipRect, System.Boolean validRect)
  System.Void UpdateCulling()
  System.Void UpdateMeshPadding()
  System.Void InternalCrossFadeColor(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha)
  System.Void InternalCrossFadeAlpha(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale)
  System.Void ForceMeshUpdate(System.Boolean ignoreActiveState, System.Boolean forceTextReparsing)
  TMPro.TMP_TextInfo GetTextInfo(System.String text)
  System.Void ClearMesh()
  System.Void add_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value)
  System.Void remove_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value)
  System.Void UpdateGeometry(UnityEngine.Mesh mesh, System.Int32 index)
  System.Void UpdateVertexData(TMPro.TMP_VertexDataUpdateFlags flags)
  System.Void UpdateVertexData()
  System.Void UpdateFontAsset()
  System.Void Awake()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void LoadFontAsset()
  UnityEngine.Canvas GetCanvas()
  System.Void UpdateEnvMapMatrix()
  System.Void EnableMasking()
  System.Void DisableMasking()
  System.Void UpdateMask()
  UnityEngine.Material GetMaterial(UnityEngine.Material mat)
  UnityEngine.Material[] GetMaterials(UnityEngine.Material[] mats)
  System.Void SetSharedMaterial(UnityEngine.Material mat)
  UnityEngine.Material[] GetSharedMaterials()
  System.Void SetSharedMaterials(UnityEngine.Material[] materials)
  System.Void SetOutlineThickness(System.Single thickness)
  System.Void SetFaceColor(UnityEngine.Color32 color)
  System.Void SetOutlineColor(UnityEngine.Color32 color)
  System.Void SetShaderDepth()
  System.Void SetCulling()
  System.Void SetPerspectiveCorrection()
  System.Void SetMeshArrays(System.Int32 size)
  System.Int32 SetArraySizes(TMPro.TMP_Text.UnicodeChar[] unicodeChars)
  System.Void ComputeMarginSize()
  System.Void OnDidApplyAnimationProperties()
  System.Void OnCanvasHierarchyChanged()
  System.Void OnTransformParentChanged()
  System.Void OnRectTransformDimensionsChange()
  System.Void InternalUpdate()
  System.Void OnPreRenderCanvas()
  TMPro.TMP_SubMeshUI AddSubTextObject(TMPro.TextMeshProUGUI textComponent, TMPro.MaterialReference materialReference)
  System.Void GenerateTextMesh()
  UnityEngine.Vector3[] GetTextContainerLocalCorners()
  System.Void SetActiveSubMeshes(System.Boolean state)
  System.Void DestroySubMeshObjects()
  UnityEngine.Bounds GetCompoundBounds()
  UnityEngine.Rect GetCanvasSpaceClippingRect()
  System.Void UpdateSDFScale(System.Single scaleDelta)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: TMPro.ThaiTextPreprocessor
TYPE:  class
TOKEN: 0x2000011
FIELDS:
  private   static  TMPro.ThaiTextPreprocessor      _instance  // 0x0
METHODS:
  System.String PreprocessText(System.String text)
  TMPro.ThaiTextPreprocessor get_Instance()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: TMPro.Compute_DistanceTransform_EventTypes
TYPE:  struct
TOKEN: 0x2000012
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.Compute_DistanceTransform_EventTypesProcessing  // 0x0
  public    static  TMPro.Compute_DistanceTransform_EventTypesCompleted  // 0x0
METHODS:
END_CLASS

CLASS: TMPro.TMPro_EventManager
TYPE:  class
TOKEN: 0x2000013
FIELDS:
  public    static readonly TMPro.FastAction<System.Object,TMPro.Compute_DT_EventArgs>COMPUTE_DT_EVENT  // 0x0
  public    static readonly TMPro.FastAction<System.Boolean,UnityEngine.Material>MATERIAL_PROPERTY_EVENT  // 0x8
  public    static readonly TMPro.FastAction<System.Boolean,UnityEngine.Object>FONT_PROPERTY_EVENT  // 0x10
  public    static readonly TMPro.FastAction<System.Boolean,UnityEngine.Object>SPRITE_ASSET_PROPERTY_EVENT  // 0x18
  public    static readonly TMPro.FastAction<System.Boolean,UnityEngine.Object>TEXTMESHPRO_PROPERTY_EVENT  // 0x20
  public    static readonly TMPro.FastAction<UnityEngine.GameObject,UnityEngine.Material,UnityEngine.Material>DRAG_AND_DROP_MATERIAL_EVENT  // 0x28
  public    static readonly TMPro.FastAction<System.Boolean>TEXT_STYLE_PROPERTY_EVENT  // 0x30
  public    static readonly TMPro.FastAction<UnityEngine.Object>COLOR_GRADIENT_PROPERTY_EVENT  // 0x38
  public    static readonly TMPro.FastAction                TMP_SETTINGS_PROPERTY_EVENT  // 0x40
  public    static readonly TMPro.FastAction                RESOURCE_LOAD_EVENT  // 0x48
  public    static readonly TMPro.FastAction<System.Boolean,UnityEngine.Object>TEXTMESHPRO_UGUI_PROPERTY_EVENT  // 0x50
  public    static readonly TMPro.FastAction<UnityEngine.Object>TEXT_CHANGED_EVENT  // 0x58
METHODS:
  System.Void ON_MATERIAL_PROPERTY_CHANGED(System.Boolean isChanged, UnityEngine.Material mat)
  System.Void ON_FONT_PROPERTY_CHANGED(System.Boolean isChanged, UnityEngine.Object obj)
  System.Void ON_SPRITE_ASSET_PROPERTY_CHANGED(System.Boolean isChanged, UnityEngine.Object obj)
  System.Void ON_TEXTMESHPRO_PROPERTY_CHANGED(System.Boolean isChanged, UnityEngine.Object obj)
  System.Void ON_DRAG_AND_DROP_MATERIAL_CHANGED(UnityEngine.GameObject sender, UnityEngine.Material currentMaterial, UnityEngine.Material newMaterial)
  System.Void ON_TEXT_STYLE_PROPERTY_CHANGED(System.Boolean isChanged)
  System.Void ON_COLOR_GRADIENT_PROPERTY_CHANGED(UnityEngine.Object obj)
  System.Void ON_TEXT_CHANGED(UnityEngine.Object obj)
  System.Void ON_TMP_SETTINGS_CHANGED()
  System.Void ON_RESOURCES_LOADED()
  System.Void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(System.Boolean isChanged, UnityEngine.Object obj)
  System.Void ON_COMPUTE_DT_EVENT(System.Object Sender, TMPro.Compute_DT_EventArgs e)
  System.Void .cctor()
END_CLASS

CLASS: TMPro.Compute_DT_EventArgs
TYPE:  class
TOKEN: 0x2000014
FIELDS:
  public            TMPro.Compute_DistanceTransform_EventTypesEventType  // 0x10
  public            System.Single                   ProgressPercentage  // 0x14
  public            UnityEngine.Color[]             Colors  // 0x18
METHODS:
  System.Void .ctor(TMPro.Compute_DistanceTransform_EventTypes type, System.Single progress)
  System.Void .ctor(TMPro.Compute_DistanceTransform_EventTypes type, UnityEngine.Color[] colors)
END_CLASS

CLASS: TMPro.TMPro_ExtensionMethods
TYPE:  class
TOKEN: 0x2000015
FIELDS:
METHODS:
  System.Int32[] ToIntArray(System.String text)
  System.String ArrayToString(System.Char[] chars)
  System.String IntToString(System.Int32[] unicodes)
  System.String UintToString(System.Collections.Generic.List<System.UInt32> unicodes)
  System.String IntToString(System.Int32[] unicodes, System.Int32 start, System.Int32 length)
  System.Int32 FindInstanceID(System.Collections.Generic.List<T> list, T target)
  System.Boolean Compare(UnityEngine.Color32 a, UnityEngine.Color32 b)
  System.Boolean CompareRGB(UnityEngine.Color32 a, UnityEngine.Color32 b)
  System.Boolean Compare(UnityEngine.Color a, UnityEngine.Color b)
  System.Boolean CompareRGB(UnityEngine.Color a, UnityEngine.Color b)
  UnityEngine.Color32 Multiply(UnityEngine.Color32 c1, UnityEngine.Color32 c2)
  UnityEngine.Color32 Tint(UnityEngine.Color32 c1, UnityEngine.Color32 c2)
  UnityEngine.Color32 Tint(UnityEngine.Color32 c1, System.Single tint)
  UnityEngine.Color MinAlpha(UnityEngine.Color c1, UnityEngine.Color c2)
  System.Boolean Compare(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, System.Int32 accuracy)
  System.Boolean Compare(UnityEngine.Quaternion q1, UnityEngine.Quaternion q2, System.Int32 accuracy)
END_CLASS

CLASS: TMPro.TMP_Math
TYPE:  class
TOKEN: 0x2000016
FIELDS:
  public    static  System.Single                   FLOAT_MAX  // 0x0
  public    static  System.Single                   FLOAT_MIN  // 0x0
  public    static  System.Int32                    INT_MAX  // 0x0
  public    static  System.Int32                    INT_MIN  // 0x0
  public    static  System.Single                   FLOAT_UNSET  // 0x0
  public    static  System.Int32                    INT_UNSET  // 0x0
  public    static  UnityEngine.Vector2             MAX_16BIT  // 0x0
  public    static  UnityEngine.Vector2             MIN_16BIT  // 0x8
METHODS:
  System.Boolean Approximately(System.Single a, System.Single b)
  System.Int32 Mod(System.Int32 a, System.Int32 b)
  System.Void .cctor()
END_CLASS

CLASS: TMPro.TMP_VertexDataUpdateFlags
TYPE:  struct
TOKEN: 0x2000017
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TMP_VertexDataUpdateFlags None  // 0x0
  public    static  TMPro.TMP_VertexDataUpdateFlags Vertices  // 0x0
  public    static  TMPro.TMP_VertexDataUpdateFlags Uv0  // 0x0
  public    static  TMPro.TMP_VertexDataUpdateFlags Uv2  // 0x0
  public    static  TMPro.TMP_VertexDataUpdateFlags Uv4  // 0x0
  public    static  TMPro.TMP_VertexDataUpdateFlags Colors32  // 0x0
  public    static  TMPro.TMP_VertexDataUpdateFlags All  // 0x0
METHODS:
END_CLASS

CLASS: TMPro.VertexGradient
TYPE:  struct
TOKEN: 0x2000018
FIELDS:
  public            UnityEngine.Color               topLeft  // 0x10
  public            UnityEngine.Color               topRight  // 0x20
  public            UnityEngine.Color               bottomLeft  // 0x30
  public            UnityEngine.Color               bottomRight  // 0x40
METHODS:
  System.Void .ctor(UnityEngine.Color color)
  System.Void .ctor(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3)
END_CLASS

CLASS: TMPro.TMP_PageInfo
TYPE:  struct
TOKEN: 0x2000019
FIELDS:
  public            System.Int32                    firstCharacterIndex  // 0x10
  public            System.Int32                    lastCharacterIndex  // 0x14
  public            System.Single                   ascender  // 0x18
  public            System.Single                   baseLine  // 0x1C
  public            System.Single                   descender  // 0x20
METHODS:
END_CLASS

CLASS: TMPro.TMP_LinkInfo
TYPE:  struct
TOKEN: 0x200001A
FIELDS:
  public            TMPro.TMP_Text                  textComponent  // 0x10
  public            System.Int32                    hashCode  // 0x18
  public            System.Int32                    linkIdFirstCharacterIndex  // 0x1C
  public            System.Int32                    linkIdLength  // 0x20
  public            System.Int32                    linkTextfirstCharacterIndex  // 0x24
  public            System.Int32                    linkTextLength  // 0x28
  private           System.Char[]                   linkID  // 0x30
METHODS:
  System.Void SetLinkID(System.Char[] text, System.Int32 startIndex, System.Int32 length)
  System.String GetLinkText()
  System.String GetLinkID()
END_CLASS

CLASS: TMPro.TMP_WordInfo
TYPE:  struct
TOKEN: 0x200001B
FIELDS:
  public            TMPro.TMP_Text                  textComponent  // 0x10
  public            System.Int32                    firstCharacterIndex  // 0x18
  public            System.Int32                    lastCharacterIndex  // 0x1C
  public            System.Int32                    characterCount  // 0x20
METHODS:
  System.String GetWord()
END_CLASS

CLASS: TMPro.TMP_SpriteInfo
TYPE:  struct
TOKEN: 0x200001C
FIELDS:
  public            System.Int32                    spriteIndex  // 0x10
  public            System.Int32                    characterIndex  // 0x14
  public            System.Int32                    vertexIndex  // 0x18
METHODS:
END_CLASS

CLASS: TMPro.Extents
TYPE:  struct
TOKEN: 0x200001D
FIELDS:
  private   static  TMPro.Extents                   zero  // 0x0
  private   static  TMPro.Extents                   uninitialized  // 0x10
  public            UnityEngine.Vector2             min  // 0x10
  public            UnityEngine.Vector2             max  // 0x18
METHODS:
  System.Void .ctor(UnityEngine.Vector2 min, UnityEngine.Vector2 max)
  System.String ToString()
  System.Void .cctor()
END_CLASS

CLASS: TMPro.Mesh_Extents
TYPE:  struct
TOKEN: 0x200001E
FIELDS:
  public            UnityEngine.Vector2             min  // 0x10
  public            UnityEngine.Vector2             max  // 0x18
METHODS:
  System.Void .ctor(UnityEngine.Vector2 min, UnityEngine.Vector2 max)
  System.String ToString()
END_CLASS

CLASS: TMPro.WordWrapState
TYPE:  struct
TOKEN: 0x200001F
FIELDS:
  public            System.Int32                    previous_WordBreak  // 0x10
  public            System.Int32                    total_CharacterCount  // 0x14
  public            System.Int32                    visible_CharacterCount  // 0x18
  public            System.Int32                    visible_SpriteCount  // 0x1C
  public            System.Int32                    visible_LinkCount  // 0x20
  public            System.Int32                    firstCharacterIndex  // 0x24
  public            System.Int32                    firstVisibleCharacterIndex  // 0x28
  public            System.Int32                    lastCharacterIndex  // 0x2C
  public            System.Int32                    lastVisibleCharIndex  // 0x30
  public            System.Int32                    lineNumber  // 0x34
  public            System.Single                   maxCapHeight  // 0x38
  public            System.Single                   maxAscender  // 0x3C
  public            System.Single                   maxLineAscenderWithOutImage  // 0x40
  public            System.Single                   maxDescender  // 0x44
  public            System.Single                   startOfLineAscender  // 0x48
  public            System.Single                   maxLineAscender  // 0x4C
  public            System.Single                   maxLineDescender  // 0x50
  public            System.Single                   pageAscender  // 0x54
  public            TMPro.HorizontalAlignmentOptionshorizontalAlignment  // 0x58
  public            System.Single                   marginLeft  // 0x5C
  public            System.Single                   marginRight  // 0x60
  public            System.Single                   xAdvance  // 0x64
  public            System.Single                   preferredWidth  // 0x68
  public            System.Single                   preferredHeight  // 0x6C
  public            System.Single                   previousLineScale  // 0x70
  public            System.Int32                    wordCount  // 0x74
  public            TMPro.FontStyles                fontStyle  // 0x78
  public            System.Int32                    italicAngle  // 0x7C
  public            System.Single                   fontScaleMultiplier  // 0x80
  public            System.Single                   currentFontSize  // 0x84
  public            System.Single                   baselineOffset  // 0x88
  public            System.Single                   lineOffset  // 0x8C
  public            System.Boolean                  isDrivenLineSpacing  // 0x90
  public            System.Single                   glyphHorizontalAdvanceAdjustment  // 0x94
  public            System.Single                   cSpace  // 0x98
  public            System.Single                   mSpace  // 0x9C
  public            TMPro.TMP_TextInfo              textInfo  // 0xA0
  public            TMPro.TMP_LineInfo              lineInfo  // 0xA8
  public            UnityEngine.Color32             vertexColor  // 0x104
  public            UnityEngine.Color32             underlineColor  // 0x108
  public            UnityEngine.Color32             strikethroughColor  // 0x10C
  public            UnityEngine.Color32             highlightColor  // 0x110
  public            TMPro.TMP_FontStyleStack        basicStyleStack  // 0x114
  public            TMPro.TMP_TextProcessingStack<System.Int32>italicAngleStack  // 0x120
  public            TMPro.TMP_TextProcessingStack<UnityEngine.Color32>colorStack  // 0x140
  public            TMPro.TMP_TextProcessingStack<UnityEngine.Color32>underlineColorStack  // 0x160
  public            TMPro.TMP_TextProcessingStack<UnityEngine.Color32>strikethroughColorStack  // 0x180
  public            TMPro.TMP_TextProcessingStack<UnityEngine.Color32>highlightColorStack  // 0x1A0
  public            TMPro.TMP_TextProcessingStack<TMPro.HighlightState>highlightStateStack  // 0x1C0
  public            TMPro.TMP_TextProcessingStack<TMPro.TMP_ColorGradient>colorGradientStack  // 0x1F0
  public            TMPro.TMP_TextProcessingStack<System.Single>sizeStack  // 0x218
  public            TMPro.TMP_TextProcessingStack<System.Single>indentStack  // 0x238
  public            TMPro.TMP_TextProcessingStack<TMPro.FontWeight>fontWeightStack  // 0x258
  public            TMPro.TMP_TextProcessingStack<System.Int32>styleStack  // 0x278
  public            TMPro.TMP_TextProcessingStack<System.Single>baselineStack  // 0x298
  public            TMPro.TMP_TextProcessingStack<System.Int32>actionStack  // 0x2B8
  public            TMPro.TMP_TextProcessingStack<TMPro.MaterialReference>materialReferenceStack  // 0x2D8
  public            TMPro.TMP_TextProcessingStack<TMPro.HorizontalAlignmentOptions>lineJustificationStack  // 0x330
  public            TMPro.TMP_TextProcessingQueue<TMPro.PhoneticData>phoneticQueue  // 0x350
  public            System.Int32                    spriteAnimationID  // 0x370
  public            TMPro.TMP_FontAsset             currentFontAsset  // 0x378
  public            TMPro.TMP_SpriteAsset           currentSpriteAsset  // 0x380
  public            UnityEngine.Material            currentMaterial  // 0x388
  public            System.Int32                    currentMaterialIndex  // 0x390
  public            TMPro.Extents                   meshExtents  // 0x394
  public            System.Boolean                  tagNoParsing  // 0x3A4
  public            System.Boolean                  isNonBreakingSpace  // 0x3A5
METHODS:
END_CLASS

CLASS: TMPro.TagAttribute
TYPE:  struct
TOKEN: 0x2000020
FIELDS:
  public            System.Int32                    startIndex  // 0x10
  public            System.Int32                    length  // 0x14
  public            System.Int32                    hashCode  // 0x18
METHODS:
END_CLASS

CLASS: TMPro.RichTextTagAttribute
TYPE:  struct
TOKEN: 0x2000021
FIELDS:
  public            System.Int32                    nameHashCode  // 0x10
  public            System.Int32                    valueHashCode  // 0x14
  public            TMPro.TagValueType              valueType  // 0x18
  public            System.Int32                    valueStartIndex  // 0x1C
  public            System.Int32                    valueLength  // 0x20
  public            TMPro.TagUnitType               unitType  // 0x24
METHODS:
END_CLASS

CLASS: TMPro.TMP_ArrayObjectPool`1
TYPE:  class
TOKEN: 0x2000022
FIELDS:
  private   readonly System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Stack<T[]>>m_StackDic  // 0x0
  private   readonly UnityEngine.Events.UnityAction<T[]>m_ActionOnGet  // 0x0
  private   readonly UnityEngine.Events.UnityAction<T[]>m_ActionOnRelease  // 0x0
  private           System.Int32                    <countAll>k__BackingField  // 0x0
METHODS:
  System.Int32 get_countAll()
  System.Void set_countAll(System.Int32 value)
  System.Int32 get_countActive()
  System.Int32 get_countInactive()
  System.Void .ctor(UnityEngine.Events.UnityAction<T[]> actionOnGet, UnityEngine.Events.UnityAction<T[]> actionOnRelease)
  T[] Get(System.Int32 count)
  System.Void Release(System.Int32 count, T[] element)
END_CLASS

CLASS: TMPro.TMP_ArrayPool`1
TYPE:  class
TOKEN: 0x2000023
FIELDS:
  private   static readonly TMPro.TMP_ArrayObjectPool<T>    s_ArrayPool  // 0x0
METHODS:
  T[] Get(System.Int32 count)
  System.Void Release(T[] toRelease)
  System.Void Resize(T[]& array, System.Int32 newCount)
  System.Void .cctor()
END_CLASS

CLASS: TMPro.TMP_Asset
TYPE:  class
TOKEN: 0x2000025
EXTENDS: ScriptableObject
FIELDS:
  private           System.Int32                    m_InstanceID  // 0x18
  public            System.Int32                    hashCode  // 0x1C
  public            UnityEngine.Material            material  // 0x20
  public            System.Int32                    materialHashCode  // 0x28
METHODS:
  System.Int32 get_instanceID()
  System.Void .ctor()
END_CLASS

CLASS: TMPro.TMP_Character
TYPE:  class
TOKEN: 0x2000026
EXTENDS: TMP_TextElement
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.UInt32 unicode, UnityEngine.TextCore.Glyph glyph)
  System.Void .ctor(System.UInt32 unicode, TMPro.TMP_FontAsset fontAsset, UnityEngine.TextCore.Glyph glyph)
  System.Void .ctor(System.UInt32 unicode, System.UInt32 glyphIndex)
END_CLASS

CLASS: TMPro.TMP_Vertex
TYPE:  struct
TOKEN: 0x2000027
FIELDS:
  public            UnityEngine.Vector3             position  // 0x10
  public            UnityEngine.Vector2             uv  // 0x1C
  public            UnityEngine.Vector2             uv2  // 0x24
  public            UnityEngine.Vector2             uv4  // 0x2C
  public            UnityEngine.Color32             color  // 0x34
  private   static readonly TMPro.TMP_Vertex                k_Zero  // 0x0
METHODS:
  TMPro.TMP_Vertex get_zero()
  System.Void .cctor()
END_CLASS

CLASS: TMPro.TMP_Offset
TYPE:  struct
TOKEN: 0x2000028
FIELDS:
  private           System.Single                   m_Left  // 0x10
  private           System.Single                   m_Right  // 0x14
  private           System.Single                   m_Top  // 0x18
  private           System.Single                   m_Bottom  // 0x1C
  private   static readonly TMPro.TMP_Offset                k_ZeroOffset  // 0x0
METHODS:
  System.Single get_left()
  System.Void set_left(System.Single value)
  System.Single get_right()
  System.Void set_right(System.Single value)
  System.Single get_top()
  System.Void set_top(System.Single value)
  System.Single get_bottom()
  System.Void set_bottom(System.Single value)
  System.Single get_horizontal()
  System.Void set_horizontal(System.Single value)
  System.Single get_vertical()
  System.Void set_vertical(System.Single value)
  TMPro.TMP_Offset get_zero()
  System.Void .ctor(System.Single left, System.Single right, System.Single top, System.Single bottom)
  System.Void .ctor(System.Single horizontal, System.Single vertical)
  System.Boolean op_Equality(TMPro.TMP_Offset lhs, TMPro.TMP_Offset rhs)
  System.Boolean op_Inequality(TMPro.TMP_Offset lhs, TMPro.TMP_Offset rhs)
  TMPro.TMP_Offset op_Multiply(TMPro.TMP_Offset a, System.Single b)
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(TMPro.TMP_Offset other)
  System.Void .cctor()
END_CLASS

CLASS: TMPro.HighlightState
TYPE:  struct
TOKEN: 0x2000029
FIELDS:
  public            UnityEngine.Color32             color  // 0x10
  public            TMPro.TMP_Offset                padding  // 0x14
METHODS:
  System.Void .ctor(UnityEngine.Color32 color, TMPro.TMP_Offset padding)
  System.Boolean op_Equality(TMPro.HighlightState lhs, TMPro.HighlightState rhs)
  System.Boolean op_Inequality(TMPro.HighlightState lhs, TMPro.HighlightState rhs)
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(TMPro.HighlightState other)
END_CLASS

CLASS: TMPro.TMP_CharacterInfo
TYPE:  struct
TOKEN: 0x200002A
FIELDS:
  public            System.Char                     character  // 0x10
  public            System.Int32                    index  // 0x14
  public            System.Int32                    stringLength  // 0x18
  public            TMPro.TMP_TextElementType       elementType  // 0x1C
  public            TMPro.TMP_TextElement           textElement  // 0x20
  public            TMPro.TMP_FontAsset             fontAsset  // 0x28
  public            TMPro.TMP_SpriteAsset           spriteAsset  // 0x30
  public            System.Int32                    spriteIndex  // 0x38
  public            UnityEngine.Material            material  // 0x40
  public            System.Int32                    materialReferenceIndex  // 0x48
  public            System.Boolean                  isUsingAlternateTypeface  // 0x4C
  public            System.Single                   pointSize  // 0x50
  public            System.Int32                    lineNumber  // 0x54
  public            System.Int32                    pageNumber  // 0x58
  public            System.Int32                    vertexIndex  // 0x5C
  public            TMPro.TMP_Vertex                vertex_BL  // 0x60
  public            TMPro.TMP_Vertex                vertex_TL  // 0x88
  public            TMPro.TMP_Vertex                vertex_TR  // 0xB0
  public            TMPro.TMP_Vertex                vertex_BR  // 0xD8
  public            UnityEngine.Vector3             topLeft  // 0x100
  public            UnityEngine.Vector3             bottomLeft  // 0x10C
  public            UnityEngine.Vector3             topRight  // 0x118
  public            UnityEngine.Vector3             bottomRight  // 0x124
  public            System.Single                   origin  // 0x130
  public            System.Single                   xAdvance  // 0x134
  public            System.Single                   ascender  // 0x138
  public            System.Single                   baseLine  // 0x13C
  public            System.Single                   descender  // 0x140
  public            System.Single                   adjustedAscender  // 0x144
  public            System.Single                   adjustedDescender  // 0x148
  public            System.Single                   aspectRatio  // 0x14C
  public            System.Single                   scale  // 0x150
  public            UnityEngine.Color32             color  // 0x154
  public            UnityEngine.Color32             underlineColor  // 0x158
  public            System.Int32                    underlineVertexIndex  // 0x15C
  public            UnityEngine.Color32             strikethroughColor  // 0x160
  public            System.Int32                    strikethroughVertexIndex  // 0x164
  public            UnityEngine.Color32             highlightColor  // 0x168
  public            TMPro.HighlightState            highlightState  // 0x16C
  public            TMPro.FontStyles                style  // 0x180
  public            System.Boolean                  isVisible  // 0x184
METHODS:
END_CLASS

CLASS: TMPro.ColorMode
TYPE:  struct
TOKEN: 0x200002B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.ColorMode                 Single  // 0x0
  public    static  TMPro.ColorMode                 HorizontalGradient  // 0x0
  public    static  TMPro.ColorMode                 VerticalGradient  // 0x0
  public    static  TMPro.ColorMode                 FourCornersGradient  // 0x0
METHODS:
END_CLASS

CLASS: TMPro.TMP_ColorGradient
TYPE:  class
TOKEN: 0x200002C
EXTENDS: ScriptableObject
FIELDS:
  public            TMPro.ColorMode                 colorMode  // 0x18
  public            UnityEngine.Color               topLeft  // 0x1C
  public            UnityEngine.Color               topRight  // 0x2C
  public            UnityEngine.Color               bottomLeft  // 0x3C
  public            UnityEngine.Color               bottomRight  // 0x4C
  private   static  TMPro.ColorMode                 k_DefaultColorMode  // 0x0
  private   static readonly UnityEngine.Color               k_DefaultColor  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(UnityEngine.Color color)
  System.Void .ctor(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3)
  System.Void .cctor()
END_CLASS

CLASS: TMPro.TMP_Compatibility
TYPE:  class
TOKEN: 0x200002D
FIELDS:
METHODS:
  TMPro.TextAlignmentOptions ConvertTextAlignmentEnumValues(TMPro.TextAlignmentOptions oldValue)
END_CLASS

CLASS: TMPro.ITweenValue
TYPE:  interface
TOKEN: 0x200002F
FIELDS:
METHODS:
  System.Void TweenValue(System.Single floatPercentage)
  System.Boolean get_ignoreTimeScale()
  System.Single get_duration()
  System.Boolean ValidTarget()
END_CLASS

CLASS: TMPro.ColorTween
TYPE:  struct
TOKEN: 0x2000030
FIELDS:
  private           TMPro.ColorTween.ColorTweenCallbackm_Target  // 0x10
  private           UnityEngine.Color               m_StartColor  // 0x18
  private           UnityEngine.Color               m_TargetColor  // 0x28
  private           TMPro.ColorTween.ColorTweenMode m_TweenMode  // 0x38
  private           System.Single                   m_Duration  // 0x3C
  private           System.Boolean                  m_IgnoreTimeScale  // 0x40
METHODS:
  UnityEngine.Color get_startColor()
  System.Void set_startColor(UnityEngine.Color value)
  UnityEngine.Color get_targetColor()
  System.Void set_targetColor(UnityEngine.Color value)
  TMPro.ColorTween.ColorTweenMode get_tweenMode()
  System.Void set_tweenMode(TMPro.ColorTween.ColorTweenMode value)
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

CLASS: TMPro.FloatTween
TYPE:  struct
TOKEN: 0x2000033
FIELDS:
  private           TMPro.FloatTween.FloatTweenCallbackm_Target  // 0x10
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

CLASS: TMPro.TweenRunner`1
TYPE:  class
TOKEN: 0x2000035
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

CLASS: TMPro.TMP_DefaultControls
TYPE:  class
TOKEN: 0x2000037
FIELDS:
  private   static  System.Single                   kWidth  // 0x0
  private   static  System.Single                   kThickHeight  // 0x0
  private   static  System.Single                   kThinHeight  // 0x0
  private   static  UnityEngine.Vector2             s_TextElementSize  // 0x0
  private   static  UnityEngine.Vector2             s_ThickElementSize  // 0x8
  private   static  UnityEngine.Vector2             s_ThinElementSize  // 0x10
  private   static  UnityEngine.Color               s_DefaultSelectableColor  // 0x18
  private   static  UnityEngine.Color               s_TextColor  // 0x28
METHODS:
  UnityEngine.GameObject CreateUIElementRoot(System.String name, UnityEngine.Vector2 size)
  UnityEngine.GameObject CreateUIObject(System.String name, UnityEngine.GameObject parent)
  System.Void SetDefaultTextValues(TMPro.TMP_Text lbl)
  System.Void SetDefaultColorTransitionValues(UnityEngine.UI.Selectable slider)
  System.Void SetParentAndAlign(UnityEngine.GameObject child, UnityEngine.GameObject parent)
  System.Void SetLayerRecursively(UnityEngine.GameObject go, System.Int32 layer)
  UnityEngine.GameObject CreateScrollbar(TMPro.TMP_DefaultControls.Resources resources)
  UnityEngine.GameObject CreateButton(TMPro.TMP_DefaultControls.Resources resources)
  UnityEngine.GameObject CreateText(TMPro.TMP_DefaultControls.Resources resources)
  UnityEngine.GameObject CreateInputField(TMPro.TMP_DefaultControls.Resources resources)
  UnityEngine.GameObject CreateDropdown(TMPro.TMP_DefaultControls.Resources resources)
  System.Void .cctor()
END_CLASS

CLASS: TMPro.TMP_Dropdown
TYPE:  class
TOKEN: 0x2000039
EXTENDS: Selectable
FIELDS:
  private           UnityEngine.RectTransform       m_Template  // 0x180
  private           TMPro.TMP_Text                  m_CaptionText  // 0x188
  private           UnityEngine.UI.Image            m_CaptionImage  // 0x190
  private           UnityEngine.UI.Graphic          m_Placeholder  // 0x198
  private           TMPro.TMP_Text                  m_ItemText  // 0x1A0
  private           UnityEngine.UI.Image            m_ItemImage  // 0x1A8
  private           System.Int32                    m_Value  // 0x1B0
  private           TMPro.TMP_Dropdown.OptionDataListm_Options  // 0x1B8
  private           TMPro.TMP_Dropdown.DropdownEventm_OnValueChanged  // 0x1C0
  private           System.Single                   m_AlphaFadeSpeed  // 0x1C8
  private           UnityEngine.GameObject          m_Dropdown  // 0x1D0
  private           UnityEngine.GameObject          m_Blocker  // 0x1D8
  private           System.Collections.Generic.List<TMPro.TMP_Dropdown.DropdownItem>m_Items  // 0x1E0
  private           TMPro.TweenRunner<TMPro.FloatTween>m_AlphaTweenRunner  // 0x1E8
  private           System.Boolean                  validTemplate  // 0x1F0
  private           UnityEngine.Coroutine           m_Coroutine  // 0x1F8
  private   static  TMPro.TMP_Dropdown.OptionData   s_NoOptionData  // 0x0
METHODS:
  UnityEngine.RectTransform get_template()
  System.Void set_template(UnityEngine.RectTransform value)
  TMPro.TMP_Text get_captionText()
  System.Void set_captionText(TMPro.TMP_Text value)
  UnityEngine.UI.Image get_captionImage()
  System.Void set_captionImage(UnityEngine.UI.Image value)
  UnityEngine.UI.Graphic get_placeholder()
  System.Void set_placeholder(UnityEngine.UI.Graphic value)
  TMPro.TMP_Text get_itemText()
  System.Void set_itemText(TMPro.TMP_Text value)
  UnityEngine.UI.Image get_itemImage()
  System.Void set_itemImage(UnityEngine.UI.Image value)
  System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> get_options()
  System.Void set_options(System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> value)
  TMPro.TMP_Dropdown.DropdownEvent get_onValueChanged()
  System.Void set_onValueChanged(TMPro.TMP_Dropdown.DropdownEvent value)
  System.Single get_alphaFadeSpeed()
  System.Void set_alphaFadeSpeed(System.Single value)
  System.Int32 get_value()
  System.Void set_value(System.Int32 value)
  System.Void SetValueWithoutNotify(System.Int32 input)
  System.Void SetValue(System.Int32 value, System.Boolean sendCallback)
  System.Boolean get_IsExpanded()
  System.Void .ctor()
  System.Void Awake()
  System.Void Start()
  System.Void OnDisable()
  System.Void RefreshShownValue()
  System.Void AddOptions(System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> options)
  System.Void AddOptions(System.Collections.Generic.List<System.String> options)
  System.Void AddOptions(System.Collections.Generic.List<UnityEngine.Sprite> options)
  System.Void ClearOptions()
  System.Void SetupTemplate()
  T GetOrAddComponent(UnityEngine.GameObject go)
  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void OnCancel(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void Show()
  UnityEngine.GameObject CreateBlocker(UnityEngine.Canvas rootCanvas)
  System.Void DestroyBlocker(UnityEngine.GameObject blocker)
  UnityEngine.GameObject CreateDropdownList(UnityEngine.GameObject template)
  System.Void DestroyDropdownList(UnityEngine.GameObject dropdownList)
  TMPro.TMP_Dropdown.DropdownItem CreateItem(TMPro.TMP_Dropdown.DropdownItem itemTemplate)
  System.Void DestroyItem(TMPro.TMP_Dropdown.DropdownItem item)
  TMPro.TMP_Dropdown.DropdownItem AddItem(TMPro.TMP_Dropdown.OptionData data, System.Boolean selected, TMPro.TMP_Dropdown.DropdownItem itemTemplate, System.Collections.Generic.List<TMPro.TMP_Dropdown.DropdownItem> items)
  System.Void AlphaFadeList(System.Single duration, System.Single alpha)
  System.Void AlphaFadeList(System.Single duration, System.Single start, System.Single end)
  System.Void SetAlpha(System.Single alpha)
  System.Void Hide()
  System.Collections.IEnumerator DelayedDestroyDropdownList(System.Single delay)
  System.Void ImmediateDestroyDropdownList()
  System.Void OnSelectItem(UnityEngine.UI.Toggle toggle)
  System.Void .cctor()
END_CLASS

CLASS: TMPro.AtlasPopulationMode
TYPE:  struct
TOKEN: 0x2000040
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.AtlasPopulationMode       Static  // 0x0
  public    static  TMPro.AtlasPopulationMode       Dynamic  // 0x0
METHODS:
END_CLASS

CLASS: TMPro.TMP_FontAsset
TYPE:  class
TOKEN: 0x2000041
EXTENDS: TMP_Asset
FIELDS:
  private           System.String                   m_Version  // 0x30
  private           System.String                   m_SourceFontFileGUID  // 0x38
  private           UnityEngine.Font                m_SourceFontFile  // 0x40
  private           System.Single                   m_ThaiBiasConsonantsValue  // 0x48
  private           System.String                   m_prefixMaterialSearchPatternValue  // 0x50
  private           TMPro.AtlasPopulationMode       m_AtlasPopulationMode  // 0x58
  public            UnityEngine.TextCore.FaceInfo   m_FaceInfo  // 0x60
  private           System.Collections.Generic.List<UnityEngine.TextCore.Glyph>m_GlyphTable  // 0xC0
  private           System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Glyph>m_GlyphLookupDictionary  // 0xC8
  private           System.Collections.Generic.List<TMPro.TMP_Character>m_CharacterTable  // 0xD0
  public            System.Collections.Generic.Dictionary<System.UInt32,TMPro.TMP_Character>m_CharacterLookupDictionary  // 0xD8
  private           UnityEngine.Texture2D           m_AtlasTexture  // 0xE0
  private           UnityEngine.Texture2D[]         m_AtlasTextures  // 0xE8
  private           System.Int32                    m_AtlasTextureIndex  // 0xF0
  private           System.Boolean                  m_IsMultiAtlasTexturesEnabled  // 0xF4
  private           System.Boolean                  m_ClearDynamicDataOnBuild  // 0xF5
  private           System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect>m_UsedGlyphRects  // 0xF8
  private           System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect>m_FreeGlyphRects  // 0x100
  private           TMPro.FaceInfo_Legacy           m_fontInfo  // 0x108
  public            UnityEngine.Texture2D           atlas  // 0x110
  private           System.Int32                    m_AtlasWidth  // 0x118
  private           System.Int32                    m_AtlasHeight  // 0x11C
  private           System.Int32                    m_AtlasPadding  // 0x120
  private           UnityEngine.TextCore.LowLevel.GlyphRenderModem_AtlasRenderMode  // 0x124
  private           System.Collections.Generic.List<TMPro.TMP_Glyph>m_glyphInfoList  // 0x128
  private           TMPro.KerningTable              m_KerningTable  // 0x130
  public            TMPro.TMP_FontFeatureTable      m_FontFeatureTable  // 0x138
  private           System.Collections.Generic.List<TMPro.TMP_FontAsset>fallbackFontAssets  // 0x140
  private           System.Collections.Generic.List<TMPro.TMP_FontAsset>m_FallbackFontAssetTable  // 0x148
  private           TMPro.FontAssetCreationSettings m_CreationSettings  // 0x150
  private           TMPro.TMP_FontWeightPair[]      m_FontWeightTable  // 0x1A8
  private           TMPro.TMP_FontWeightPair[]      fontWeights  // 0x1B0
  public            System.Single                   normalStyle  // 0x1B8
  public            System.Single                   normalSpacingOffset  // 0x1BC
  public            System.Single                   boldStyle  // 0x1C0
  public            System.Single                   boldSpacing  // 0x1C4
  public            System.Byte                     italicStyle  // 0x1C8
  public            System.Byte                     tabSize  // 0x1C9
  public            System.Boolean                  isUsedBySoftLink  // 0x1CA
  private           System.Boolean                  IsFontAssetLookupTablesDirty  // 0x1CB
  private   static  Unity.Profiling.ProfilerMarker  k_ReadFontAssetDefinitionMarker  // 0x0
  private   static  Unity.Profiling.ProfilerMarker  k_AddSynthesizedCharactersMarker  // 0x8
  private   static  Unity.Profiling.ProfilerMarker<System.UInt32>k_TryAddCharacterMarker  // 0x10
  private   static  Unity.Profiling.ProfilerMarker  k_TryAddCharactersMarker  // 0x18
  private   static  Unity.Profiling.ProfilerMarker  k_UpdateGlyphAdjustmentRecordsMarker  // 0x20
  private   static  Unity.Profiling.ProfilerMarker  k_ClearFontAssetDataMarker  // 0x28
  private   static  Unity.Profiling.ProfilerMarker  k_UpdateFontAssetDataMarker  // 0x30
  private   static  System.String                   s_DefaultMaterialSuffix  // 0x38
  private           System.Collections.Generic.HashSet<System.Int32>FallbackSearchQueryLookup  // 0x1D0
  private   static  System.Collections.Generic.HashSet<System.Int32>k_SearchedFontAssetLookup  // 0x40
  private   static  System.Collections.Generic.List<TMPro.TMP_FontAsset>k_FontAssets_FontFeaturesUpdateQueue  // 0x48
  private   static  System.Collections.Generic.HashSet<System.Int32>k_FontAssets_FontFeaturesUpdateQueueLookup  // 0x50
  private   static  System.Collections.Generic.List<TMPro.TMP_FontAsset>k_FontAssets_AtlasTexturesUpdateQueue  // 0x58
  private   static  System.Collections.Generic.HashSet<System.Int32>k_FontAssets_AtlasTexturesUpdateQueueLookup  // 0x60
  private           System.Collections.Generic.List<UnityEngine.TextCore.Glyph>m_GlyphsToRender  // 0x1D8
  private           System.Collections.Generic.List<UnityEngine.TextCore.Glyph>m_GlyphsRendered  // 0x1E0
  private           System.Collections.Generic.List<System.UInt32>m_GlyphIndexList  // 0x1E8
  private           System.Collections.Generic.List<System.UInt32>m_GlyphIndexListNewlyAdded  // 0x1F0
  private           System.Collections.Generic.List<System.UInt32>m_GlyphsToAdd  // 0x1F8
  private           System.Collections.Generic.HashSet<System.UInt32>m_GlyphsToAddLookup  // 0x200
  private           System.Collections.Generic.List<TMPro.TMP_Character>m_CharactersToAdd  // 0x208
  private           System.Collections.Generic.HashSet<System.UInt32>m_CharactersToAddLookup  // 0x210
  private           System.Collections.Generic.List<System.UInt32>s_MissingCharacterList  // 0x218
  private           System.Collections.Generic.HashSet<System.UInt32>m_MissingUnicodesFromFontFile  // 0x220
  private   static  System.UInt32[]                 k_GlyphIndexArray  // 0x68
METHODS:
  System.String get_version()
  System.Void set_version(System.String value)
  UnityEngine.Font get_sourceFontFile()
  System.Void set_sourceFontFile(UnityEngine.Font value)
  System.Single get_thaiBiasConsonantsValue()
  System.Void set_thaiBiasConsonantsValue(System.Single value)
  System.String get_prefixMaterialSearchPatternValue()
  System.Void set_prefixMaterialSearchPatternValue(System.String value)
  TMPro.AtlasPopulationMode get_atlasPopulationMode()
  System.Void set_atlasPopulationMode(TMPro.AtlasPopulationMode value)
  UnityEngine.TextCore.FaceInfo get_faceInfo()
  System.Void set_faceInfo(UnityEngine.TextCore.FaceInfo value)
  System.Collections.Generic.List<UnityEngine.TextCore.Glyph> get_glyphTable()
  System.Void set_glyphTable(System.Collections.Generic.List<UnityEngine.TextCore.Glyph> value)
  System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Glyph> get_glyphLookupTable()
  System.Collections.Generic.List<TMPro.TMP_Character> get_characterTable()
  System.Void set_characterTable(System.Collections.Generic.List<TMPro.TMP_Character> value)
  System.Collections.Generic.Dictionary<System.UInt32,TMPro.TMP_Character> get_characterLookupTable()
  UnityEngine.Texture2D get_atlasTexture()
  UnityEngine.Texture2D[] get_atlasTextures()
  System.Void set_atlasTextures(UnityEngine.Texture2D[] value)
  System.Int32 get_atlasTextureCount()
  System.Boolean get_isMultiAtlasTexturesEnabled()
  System.Void set_isMultiAtlasTexturesEnabled(System.Boolean value)
  System.Boolean get_clearDynamicDataOnBuild()
  System.Void set_clearDynamicDataOnBuild(System.Boolean value)
  System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> get_usedGlyphRects()
  System.Void set_usedGlyphRects(System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> value)
  System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> get_freeGlyphRects()
  System.Void set_freeGlyphRects(System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> value)
  TMPro.FaceInfo_Legacy get_fontInfo()
  System.Int32 get_atlasWidth()
  System.Void set_atlasWidth(System.Int32 value)
  System.Int32 get_atlasHeight()
  System.Void set_atlasHeight(System.Int32 value)
  System.Int32 get_atlasPadding()
  System.Void set_atlasPadding(System.Int32 value)
  UnityEngine.TextCore.LowLevel.GlyphRenderMode get_atlasRenderMode()
  System.Void set_atlasRenderMode(UnityEngine.TextCore.LowLevel.GlyphRenderMode value)
  TMPro.TMP_FontFeatureTable get_fontFeatureTable()
  System.Void set_fontFeatureTable(TMPro.TMP_FontFeatureTable value)
  System.Collections.Generic.List<TMPro.TMP_FontAsset> get_fallbackFontAssetTable()
  System.Void set_fallbackFontAssetTable(System.Collections.Generic.List<TMPro.TMP_FontAsset> value)
  TMPro.FontAssetCreationSettings get_creationSettings()
  System.Void set_creationSettings(TMPro.FontAssetCreationSettings value)
  TMPro.TMP_FontWeightPair[] get_fontWeightTable()
  System.Void set_fontWeightTable(TMPro.TMP_FontWeightPair[] value)
  TMPro.TMP_FontAsset CreateFontAsset(UnityEngine.Font font)
  TMPro.TMP_FontAsset CreateFontAsset(UnityEngine.Font font, System.Int32 samplingPointSize, System.Int32 atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, System.Int32 atlasWidth, System.Int32 atlasHeight, TMPro.AtlasPopulationMode atlasPopulationMode, System.Boolean enableMultiAtlasSupport)
  System.Void Awake()
  System.Void ReadFontAssetDefinition()
  System.Void InitializeDictionaryLookupTables()
  System.Void InitializeGlyphLookupDictionary()
  System.Void InitializeCharacterLookupDictionary()
  System.Void InitializeGlyphPaidAdjustmentRecordsLookupDictionary()
  System.Void AddSynthesizedCharactersAndFaceMetrics()
  System.Void AddSynthesizedCharacter(System.UInt32 unicode, System.Boolean isFontFaceLoaded, System.Boolean addImmediately)
  System.Void AddCharacterToLookupCache(System.UInt32 unicode, TMPro.TMP_Character character)
  System.Void SortCharacterTable()
  System.Void SortGlyphTable()
  System.Void SortFontFeatureTable()
  System.Void SortAllTables()
  System.Boolean HasCharacter(System.Int32 character)
  System.Boolean HasCharacter(System.Char character, System.Boolean searchFallbacks, System.Boolean tryAddCharacter)
  System.Boolean HasCharacter_Internal(System.UInt32 character, System.Boolean searchFallbacks, System.Boolean tryAddCharacter)
  System.Boolean HasCharacters(System.String text, System.Collections.Generic.List<System.Char>& missingCharacters)
  System.Boolean HasCharacters(System.String text, System.UInt32[]& missingCharacters, System.Boolean searchFallbacks, System.Boolean tryAddCharacter)
  System.Boolean HasCharacters(System.String text)
  System.String GetCharacters(TMPro.TMP_FontAsset fontAsset)
  System.Int32[] GetCharactersArray(TMPro.TMP_FontAsset fontAsset)
  System.UInt32 GetGlyphIndex(System.UInt32 unicode)
  System.Void RegisterFontAssetForFontFeatureUpdate(TMPro.TMP_FontAsset fontAsset)
  System.Void UpdateFontFeaturesForFontAssetsInQueue()
  System.Void RegisterFontAssetForAtlasTextureUpdate(TMPro.TMP_FontAsset fontAsset)
  System.Void UpdateAtlasTexturesForFontAssetsInQueue()
  System.Boolean TryAddCharacters(System.UInt32[] unicodes, System.Boolean includeFontFeatures)
  System.Boolean TryAddCharacters(System.UInt32[] unicodes, System.UInt32[]& missingUnicodes, System.Boolean includeFontFeatures)
  System.Boolean TryAddCharacters(System.String characters, System.Boolean includeFontFeatures)
  System.Boolean TryAddCharacters(System.String characters, System.String& missingCharacters, System.Boolean includeFontFeatures)
  System.Void AddCharacters(System.String characters)
  System.Boolean TryAddCharacterInternal(System.UInt32 unicode, TMPro.TMP_Character& character)
  System.Boolean TryGetCharacter_and_QueueRenderToTexture(System.UInt32 unicode, TMPro.TMP_Character& character)
  System.Void TryAddGlyphsToAtlasTextures()
  System.Boolean TryAddGlyphsToNewAtlasTexture()
  System.Void SetupNewAtlasTexture()
  System.Void UpdateAtlasTexture()
  System.Void UpdateGlyphAdjustmentRecords()
  System.Void UpdateGlyphAdjustmentRecords(System.UInt32[] glyphIndexes)
  System.Void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List<System.UInt32> glyphIndexes)
  System.Void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List<System.UInt32> newGlyphIndexes, System.Collections.Generic.List<System.UInt32> allGlyphIndexes)
  System.Void CopyListDataToArray(System.Collections.Generic.List<T> srcList, T[]& dstArray)
  System.Void ClearFontAssetData(System.Boolean setAtlasSizeToZero)
  System.Void ClearFontAssetData()
  System.Void ClearFontAssetDataInternal()
  System.Void UpdateFontAssetData()
  System.Void ClearFontAssetTables()
  System.Void ClearAtlasTextures(System.Boolean setAtlasSizeToZero)
  System.Void UpgradeFontAsset()
  System.Void UpgradeGlyphAdjustmentTableToFontFeatureTable()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: TMPro.FaceInfo_Legacy
TYPE:  class
TOKEN: 0x2000043
FIELDS:
  public            System.String                   Name  // 0x10
  public            System.Single                   PointSize  // 0x18
  public            System.Single                   Scale  // 0x1C
  public            System.Int32                    CharacterCount  // 0x20
  public            System.Single                   LineHeight  // 0x24
  public            System.Single                   Baseline  // 0x28
  public            System.Single                   Ascender  // 0x2C
  public            System.Single                   CapHeight  // 0x30
  public            System.Single                   Descender  // 0x34
  public            System.Single                   CenterLine  // 0x38
  public            System.Single                   SuperscriptOffset  // 0x3C
  public            System.Single                   SubscriptOffset  // 0x40
  public            System.Single                   SubSize  // 0x44
  public            System.Single                   Underline  // 0x48
  public            System.Single                   UnderlineThickness  // 0x4C
  public            System.Single                   strikethrough  // 0x50
  public            System.Single                   strikethroughThickness  // 0x54
  public            System.Single                   TabWidth  // 0x58
  public            System.Single                   Padding  // 0x5C
  public            System.Single                   AtlasWidth  // 0x60
  public            System.Single                   AtlasHeight  // 0x64
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: TMPro.TMP_Glyph
TYPE:  class
TOKEN: 0x2000044
EXTENDS: TMP_TextElement_Legacy
FIELDS:
METHODS:
  TMPro.TMP_Glyph Clone(TMPro.TMP_Glyph source)
  System.Void .ctor()
END_CLASS

CLASS: TMPro.FontAssetCreationSettings
TYPE:  struct
TOKEN: 0x2000045
FIELDS:
  public            System.String                   sourceFontFileName  // 0x10
  public            System.String                   sourceFontFileGUID  // 0x18
  public            System.Int32                    pointSizeSamplingMode  // 0x20
  public            System.Int32                    pointSize  // 0x24
  public            System.Int32                    padding  // 0x28
  public            System.Int32                    packingMode  // 0x2C
  public            System.Int32                    atlasWidth  // 0x30
  public            System.Int32                    atlasHeight  // 0x34
  public            System.Int32                    characterSetSelectionMode  // 0x38
  public            System.String                   characterSequence  // 0x40
  public            System.String                   referencedFontAssetGUID  // 0x48
  public            System.String                   referencedTextAssetGUID  // 0x50
  public            System.Int32                    fontStyle  // 0x58
  public            System.Single                   fontStyleModifier  // 0x5C
  public            System.Int32                    renderMode  // 0x60
  public            System.Boolean                  includeFontFeatures  // 0x64
METHODS:
  System.Void .ctor(System.String sourceFontFileGUID, System.Int32 pointSize, System.Int32 pointSizeSamplingMode, System.Int32 padding, System.Int32 packingMode, System.Int32 atlasWidth, System.Int32 atlasHeight, System.Int32 characterSelectionMode, System.String characterSet, System.Int32 renderMode)
END_CLASS

CLASS: TMPro.TMP_FontWeightPair
TYPE:  struct
TOKEN: 0x2000046
FIELDS:
  public            TMPro.TMP_FontAsset             regularTypeface  // 0x10
  public            TMPro.TMP_FontAsset             italicTypeface  // 0x18
METHODS:
END_CLASS

CLASS: TMPro.KerningPairKey
TYPE:  struct
TOKEN: 0x2000047
FIELDS:
  public            System.UInt32                   ascii_Left  // 0x10
  public            System.UInt32                   ascii_Right  // 0x14
  public            System.UInt32                   key  // 0x18
METHODS:
  System.Void .ctor(System.UInt32 ascii_left, System.UInt32 ascii_right)
END_CLASS

CLASS: TMPro.GlyphValueRecord_Legacy
TYPE:  struct
TOKEN: 0x2000048
FIELDS:
  public            System.Single                   xPlacement  // 0x10
  public            System.Single                   yPlacement  // 0x14
  public            System.Single                   xAdvance  // 0x18
  public            System.Single                   yAdvance  // 0x1C
METHODS:
  System.Void .ctor(UnityEngine.TextCore.LowLevel.GlyphValueRecord valueRecord)
  TMPro.GlyphValueRecord_Legacy op_Addition(TMPro.GlyphValueRecord_Legacy a, TMPro.GlyphValueRecord_Legacy b)
END_CLASS

CLASS: TMPro.KerningPair
TYPE:  class
TOKEN: 0x2000049
FIELDS:
  private           System.UInt32                   m_FirstGlyph  // 0x10
  private           TMPro.GlyphValueRecord_Legacy   m_FirstGlyphAdjustments  // 0x14
  private           System.UInt32                   m_SecondGlyph  // 0x24
  private           TMPro.GlyphValueRecord_Legacy   m_SecondGlyphAdjustments  // 0x28
  public            System.Single                   xOffset  // 0x38
  private   static  TMPro.KerningPair               empty  // 0x0
  private           System.Boolean                  m_IgnoreSpacingAdjustments  // 0x3C
METHODS:
  System.UInt32 get_firstGlyph()
  System.Void set_firstGlyph(System.UInt32 value)
  TMPro.GlyphValueRecord_Legacy get_firstGlyphAdjustments()
  System.UInt32 get_secondGlyph()
  System.Void set_secondGlyph(System.UInt32 value)
  TMPro.GlyphValueRecord_Legacy get_secondGlyphAdjustments()
  System.Boolean get_ignoreSpacingAdjustments()
  System.Void .ctor()
  System.Void .ctor(System.UInt32 left, System.UInt32 right, System.Single offset)
  System.Void .ctor(System.UInt32 firstGlyph, TMPro.GlyphValueRecord_Legacy firstGlyphAdjustments, System.UInt32 secondGlyph, TMPro.GlyphValueRecord_Legacy secondGlyphAdjustments)
  System.Void ConvertLegacyKerningData()
  System.Void .cctor()
END_CLASS

CLASS: TMPro.KerningTable
TYPE:  class
TOKEN: 0x200004A
FIELDS:
  public            System.Collections.Generic.List<TMPro.KerningPair>kerningPairs  // 0x10
METHODS:
  System.Void .ctor()
  System.Void AddKerningPair()
  System.Int32 AddKerningPair(System.UInt32 first, System.UInt32 second, System.Single offset)
  System.Int32 AddGlyphPairAdjustmentRecord(System.UInt32 first, TMPro.GlyphValueRecord_Legacy firstAdjustments, System.UInt32 second, TMPro.GlyphValueRecord_Legacy secondAdjustments)
  System.Void RemoveKerningPair(System.Int32 left, System.Int32 right)
  System.Void RemoveKerningPair(System.Int32 index)
  System.Void SortKerningPairs()
END_CLASS

CLASS: TMPro.TMP_FontUtilities
TYPE:  class
TOKEN: 0x200004F
FIELDS:
  private   static  System.Collections.Generic.List<System.Int32>k_searchedFontAssets  // 0x0
METHODS:
  TMPro.TMP_FontAsset SearchForCharacter(TMPro.TMP_FontAsset font, System.UInt32 unicode, TMPro.TMP_Character& character)
  TMPro.TMP_FontAsset SearchForCharacter(System.Collections.Generic.List<TMPro.TMP_FontAsset> fonts, System.UInt32 unicode, TMPro.TMP_Character& character)
  TMPro.TMP_FontAsset SearchForCharacterInternal(TMPro.TMP_FontAsset font, System.UInt32 unicode, TMPro.TMP_Character& character)
  TMPro.TMP_FontAsset SearchForCharacterInternal(System.Collections.Generic.List<TMPro.TMP_FontAsset> fonts, System.UInt32 unicode, TMPro.TMP_Character& character)
END_CLASS

CLASS: TMPro.TMP_FontAssetUtilities
TYPE:  class
TOKEN: 0x2000050
FIELDS:
  private   static readonly TMPro.TMP_FontAssetUtilities    s_Instance  // 0x0
  private   static  System.Collections.Generic.HashSet<System.Int32>k_SearchedAssets  // 0x8
  private   static  System.Boolean                  k_IsFontEngineInitialized  // 0x10
METHODS:
  System.Void .cctor()
  TMPro.TMP_FontAssetUtilities get_instance()
  TMPro.TMP_Character GetCharacterFromFontAsset(System.UInt32 unicode, TMPro.TMP_FontAsset sourceFontAsset, System.Boolean includeFallbacks, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, System.Boolean& isAlternativeTypeface)
  TMPro.TMP_Character GetCharacterFromFontAsset_Internal(System.UInt32 unicode, TMPro.TMP_FontAsset sourceFontAsset, System.Boolean includeFallbacks, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, System.Boolean& isAlternativeTypeface)
  TMPro.TMP_Character GetCharacterFromFontAssets(System.UInt32 unicode, TMPro.TMP_FontAsset sourceFontAsset, System.Collections.Generic.List<TMPro.TMP_FontAsset> fontAssets, System.Boolean includeFallbacks, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, System.Boolean& isAlternativeTypeface)
  TMPro.TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset(System.UInt32 unicode, TMPro.TMP_SpriteAsset spriteAsset, System.Boolean includeFallbacks)
  TMPro.TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(System.UInt32 unicode, TMPro.TMP_SpriteAsset spriteAsset, System.Boolean includeFallbacks)
  System.Void .ctor()
END_CLASS

CLASS: TMPro.FontFeatureLookupFlags
TYPE:  struct
TOKEN: 0x2000051
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.FontFeatureLookupFlags    None  // 0x0
  public    static  TMPro.FontFeatureLookupFlags    IgnoreLigatures  // 0x0
  public    static  TMPro.FontFeatureLookupFlags    IgnoreSpacingAdjustments  // 0x0
METHODS:
END_CLASS

CLASS: TMPro.TMP_GlyphValueRecord
TYPE:  struct
TOKEN: 0x2000052
FIELDS:
  private           System.Single                   m_XPlacement  // 0x10
  private           System.Single                   m_YPlacement  // 0x14
  private           System.Single                   m_XAdvance  // 0x18
  private           System.Single                   m_YAdvance  // 0x1C
METHODS:
  System.Single get_xPlacement()
  System.Void set_xPlacement(System.Single value)
  System.Single get_yPlacement()
  System.Void set_yPlacement(System.Single value)
  System.Single get_xAdvance()
  System.Void set_xAdvance(System.Single value)
  System.Single get_yAdvance()
  System.Void set_yAdvance(System.Single value)
  System.Void .ctor(System.Single xPlacement, System.Single yPlacement, System.Single xAdvance, System.Single yAdvance)
  System.Void .ctor(TMPro.GlyphValueRecord_Legacy valueRecord)
  System.Void .ctor(UnityEngine.TextCore.LowLevel.GlyphValueRecord valueRecord)
  TMPro.TMP_GlyphValueRecord op_Addition(TMPro.TMP_GlyphValueRecord a, TMPro.TMP_GlyphValueRecord b)
END_CLASS

CLASS: TMPro.TMP_GlyphAdjustmentRecord
TYPE:  struct
TOKEN: 0x2000053
FIELDS:
  private           System.UInt32                   m_GlyphIndex  // 0x10
  private           TMPro.TMP_GlyphValueRecord      m_GlyphValueRecord  // 0x14
METHODS:
  System.UInt32 get_glyphIndex()
  System.Void set_glyphIndex(System.UInt32 value)
  TMPro.TMP_GlyphValueRecord get_glyphValueRecord()
  System.Void set_glyphValueRecord(TMPro.TMP_GlyphValueRecord value)
  System.Void .ctor(System.UInt32 glyphIndex, TMPro.TMP_GlyphValueRecord glyphValueRecord)
  System.Void .ctor(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord adjustmentRecord)
END_CLASS

CLASS: TMPro.TMP_GlyphPairAdjustmentRecord
TYPE:  class
TOKEN: 0x2000054
FIELDS:
  public            TMPro.TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord  // 0x10
  public            TMPro.TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord  // 0x24
  public            TMPro.FontFeatureLookupFlags    m_FeatureLookupFlags  // 0x38
METHODS:
  TMPro.TMP_GlyphAdjustmentRecord get_firstAdjustmentRecord()
  System.Void set_firstAdjustmentRecord(TMPro.TMP_GlyphAdjustmentRecord value)
  TMPro.TMP_GlyphAdjustmentRecord get_secondAdjustmentRecord()
  System.Void set_secondAdjustmentRecord(TMPro.TMP_GlyphAdjustmentRecord value)
  TMPro.FontFeatureLookupFlags get_featureLookupFlags()
  System.Void set_featureLookupFlags(TMPro.FontFeatureLookupFlags value)
  System.Void .ctor(TMPro.TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMPro.TMP_GlyphAdjustmentRecord secondAdjustmentRecord)
  System.Void .ctor(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord glyphPairAdjustmentRecord)
END_CLASS

CLASS: TMPro.GlyphPairKey
TYPE:  struct
TOKEN: 0x2000055
FIELDS:
  public            System.UInt32                   firstGlyphIndex  // 0x10
  public            System.UInt32                   secondGlyphIndex  // 0x14
  public            System.UInt32                   key  // 0x18
METHODS:
  System.Void .ctor(System.UInt32 firstGlyphIndex, System.UInt32 secondGlyphIndex)
  System.Void .ctor(TMPro.TMP_GlyphPairAdjustmentRecord record)
END_CLASS

CLASS: TMPro.TMP_FontFeatureTable
TYPE:  class
TOKEN: 0x2000056
FIELDS:
  private           System.Collections.Generic.List<TMPro.TMP_GlyphPairAdjustmentRecord>m_GlyphPairAdjustmentRecords  // 0x10
  public            System.Collections.Generic.Dictionary<System.UInt32,TMPro.TMP_GlyphPairAdjustmentRecord>m_GlyphPairAdjustmentRecordLookupDictionary  // 0x18
METHODS:
  System.Collections.Generic.List<TMPro.TMP_GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords()
  System.Void set_glyphPairAdjustmentRecords(System.Collections.Generic.List<TMPro.TMP_GlyphPairAdjustmentRecord> value)
  System.Void .ctor()
  System.Void SortGlyphPairAdjustmentRecords()
END_CLASS

CLASS: TMPro.TMP_InputField
TYPE:  class
TOKEN: 0x2000058
EXTENDS: Selectable
FIELDS:
  protected         UnityEngine.TouchScreenKeyboard m_SoftKeyboard  // 0x180
  private   static readonly System.Char[]                   kSeparators  // 0x0
  protected         UnityEngine.RectTransform       m_RectTransform  // 0x188
  protected         UnityEngine.RectTransform       m_TextViewport  // 0x190
  protected         UnityEngine.UI.RectMask2D       m_TextComponentRectMask  // 0x198
  protected         UnityEngine.UI.RectMask2D       m_TextViewportRectMask  // 0x1A0
  private           UnityEngine.Rect                m_CachedViewportRect  // 0x1A8
  protected         TMPro.TMP_Text                  m_TextComponent  // 0x1B8
  protected         UnityEngine.RectTransform       m_TextComponentRectTransform  // 0x1C0
  protected         UnityEngine.UI.Graphic          m_Placeholder  // 0x1C8
  protected         UnityEngine.UI.Scrollbar        m_VerticalScrollbar  // 0x1D0
  protected         TMPro.TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler  // 0x1D8
  private           System.Boolean                  m_IsDrivenByLayoutComponents  // 0x1E0
  private           UnityEngine.UI.LayoutGroup      m_LayoutGroup  // 0x1E8
  private           UnityEngine.EventSystems.IScrollHandlerm_IScrollHandlerParent  // 0x1F0
  private           System.Single                   m_ScrollPosition  // 0x1F8
  protected         System.Single                   m_ScrollSensitivity  // 0x1FC
  private           TMPro.TMP_InputField.ContentTypem_ContentType  // 0x200
  private           TMPro.TMP_InputField.InputType  m_InputType  // 0x204
  private           System.Char                     m_AsteriskChar  // 0x208
  private           UnityEngine.TouchScreenKeyboardTypem_KeyboardType  // 0x20C
  private           TMPro.TMP_InputField.LineType   m_LineType  // 0x210
  private           System.Boolean                  m_HideMobileInput  // 0x214
  private           System.Boolean                  m_HideSoftKeyboard  // 0x215
  private           TMPro.TMP_InputField.CharacterValidationm_CharacterValidation  // 0x218
  private           System.String                   m_RegexValue  // 0x220
  private           System.Single                   m_GlobalPointSize  // 0x228
  private           System.Int32                    m_CharacterLimit  // 0x22C
  private           TMPro.TMP_InputField.SubmitEventm_OnEndEdit  // 0x230
  private           TMPro.TMP_InputField.SubmitEventm_OnSubmit  // 0x238
  private           TMPro.TMP_InputField.SelectionEventm_OnSelect  // 0x240
  private           TMPro.TMP_InputField.SelectionEventm_OnDeselect  // 0x248
  private           TMPro.TMP_InputField.TextSelectionEventm_OnTextSelection  // 0x250
  private           TMPro.TMP_InputField.TextSelectionEventm_OnEndTextSelection  // 0x258
  private           TMPro.TMP_InputField.OnChangeEventm_OnValueChanged  // 0x260
  private           TMPro.TMP_InputField.TouchScreenKeyboardEventm_OnTouchScreenKeyboardStatusChanged  // 0x268
  private           TMPro.TMP_InputField.OnValidateInputm_OnValidateInput  // 0x270
  private           UnityEngine.Events.UnityEvent   m_OnFocused  // 0x278
  private           UnityEngine.Color               m_CaretColor  // 0x280
  private           System.Boolean                  m_CustomCaretColor  // 0x290
  private           UnityEngine.Color               m_SelectionColor  // 0x294
  protected         System.String                   m_Text  // 0x2A8
  private           System.Single                   m_CaretBlinkRate  // 0x2B0
  private           System.Int32                    m_CaretWidth  // 0x2B4
  private           System.Boolean                  m_ReadOnly  // 0x2B8
  private           System.Boolean                  m_RichText  // 0x2B9
  private           System.Boolean                  m_disableUpDownArrowKeyMovingCaret  // 0x2BA
  private           System.Boolean                  m_disableLeftRightArrowKeyMovingCaret  // 0x2BB
  protected         System.Int32                    m_StringPosition  // 0x2BC
  protected         System.Int32                    m_StringSelectPosition  // 0x2C0
  protected         System.Int32                    m_CaretPosition  // 0x2C4
  protected         System.Int32                    m_CaretSelectPosition  // 0x2C8
  private           UnityEngine.RectTransform       caretRectTrans  // 0x2D0
  protected         UnityEngine.UIVertex[]          m_CursorVerts  // 0x2D8
  private           UnityEngine.CanvasRenderer      m_CachedInputRenderer  // 0x2E0
  private           UnityEngine.Vector2             m_LastPosition  // 0x2E8
  protected         UnityEngine.Mesh                m_Mesh  // 0x2F0
  private           System.Boolean                  m_AllowInput  // 0x2F8
  private           System.Boolean                  m_ShouldActivateNextUpdate  // 0x2F9
  private           System.Boolean                  m_UpdateDrag  // 0x2FA
  private           System.Boolean                  m_DragPositionOutOfBounds  // 0x2FB
  private   static  System.Single                   kHScrollSpeed  // 0x0
  private   static  System.Single                   kVScrollSpeed  // 0x0
  protected         System.Boolean                  m_CaretVisible  // 0x2FC
  private           UnityEngine.Coroutine           m_BlinkCoroutine  // 0x300
  private           System.Single                   m_BlinkStartTime  // 0x308
  private           UnityEngine.Coroutine           m_DragCoroutine  // 0x310
  private           System.String                   m_OriginalText  // 0x318
  private           System.Boolean                  m_WasCanceled  // 0x320
  private           System.Boolean                  m_HasDoneFocusTransition  // 0x321
  private           UnityEngine.WaitForSecondsRealtimem_WaitForSecondsRealtime  // 0x328
  private           System.Boolean                  m_PreventCallback  // 0x330
  private           System.Boolean                  m_TouchKeyboardAllowsInPlaceEditing  // 0x331
  private           System.Boolean                  m_IsTextComponentUpdateRequired  // 0x332
  private           System.Boolean                  m_isLastKeyBackspace  // 0x333
  private           System.Single                   m_PointerDownClickStartTime  // 0x334
  private           System.Single                   m_KeyDownStartTime  // 0x338
  private           System.Single                   m_DoubleClickDelay  // 0x33C
  private   static  System.String                   kEmailSpecialCharacters  // 0x0
  private           System.Boolean                  m_IsCompositionActive  // 0x340
  private           System.Boolean                  m_ShouldUpdateIMEWindowPosition  // 0x341
  private           System.Int32                    m_PreviousIMEInsertionLine  // 0x344
  public            System.Func<System.String,System.Int32,System.String>onValidateCharacterLimit  // 0x348
  public            System.Func<System.String,System.Int32>onGetTextLength  // 0x350
  protected         TMPro.TMP_FontAsset             m_GlobalFontAsset  // 0x358
  protected         System.Boolean                  m_OnFocusSelectAll  // 0x360
  protected         System.Boolean                  m_isSelectAll  // 0x361
  protected         System.Boolean                  m_ResetOnDeActivation  // 0x362
  private           System.Boolean                  m_SelectionStillActive  // 0x363
  private           System.Boolean                  m_ReleaseSelection  // 0x364
  private           UnityEngine.GameObject          m_PreviouslySelectedObject  // 0x368
  private           System.Boolean                  m_RestoreOriginalTextOnEscape  // 0x370
  private           System.Boolean                  m_WontReleaseSelectionOnEscape  // 0x371
  protected         System.Boolean                  m_isRichTextEditingAllowed  // 0x372
  protected         System.Int32                    m_LineLimit  // 0x374
  protected         TMPro.TMP_InputValidator        m_InputValidator  // 0x378
  private           System.Boolean                  m_isSelected  // 0x380
  private           System.Boolean                  m_IsStringPositionDirty  // 0x381
  private           System.Boolean                  m_IsCaretPositionDirty  // 0x382
  private           System.Boolean                  m_forceRectTransformAdjustment  // 0x383
  private           UnityEngine.Event               m_ProcessingEvent  // 0x388
METHODS:
  System.Boolean get_isLastKeyBackspace()
  System.Void set_isLastKeyBackspace(System.Boolean value)
  UnityEngine.EventSystems.BaseInput get_inputSystem()
  System.String get_compositionString()
  System.Int32 get_compositionLength()
  System.Void .ctor()
  UnityEngine.Mesh get_mesh()
  System.Boolean get_shouldHideMobileInput()
  System.Void set_shouldHideMobileInput(System.Boolean value)
  System.Boolean get_shouldHideSoftKeyboard()
  System.Void set_shouldHideSoftKeyboard(System.Boolean value)
  System.Boolean isKeyboardUsingEvents()
  System.String get_text()
  System.Void set_text(System.String value)
  System.Void SetTextWithoutNotify(System.String input)
  System.Void SetText(System.String value, System.Boolean sendCallback)
  System.Boolean get_isFocused()
  System.Single get_caretBlinkRate()
  System.Void set_caretBlinkRate(System.Single value)
  System.Int32 get_caretWidth()
  System.Void set_caretWidth(System.Int32 value)
  UnityEngine.RectTransform get_textViewport()
  System.Void set_textViewport(UnityEngine.RectTransform value)
  TMPro.TMP_Text get_textComponent()
  System.Void set_textComponent(TMPro.TMP_Text value)
  UnityEngine.UI.Graphic get_placeholder()
  System.Void set_placeholder(UnityEngine.UI.Graphic value)
  UnityEngine.UI.Scrollbar get_verticalScrollbar()
  System.Void set_verticalScrollbar(UnityEngine.UI.Scrollbar value)
  System.Single get_scrollSensitivity()
  System.Void set_scrollSensitivity(System.Single value)
  UnityEngine.Color get_caretColor()
  System.Void set_caretColor(UnityEngine.Color value)
  System.Boolean get_customCaretColor()
  System.Void set_customCaretColor(System.Boolean value)
  UnityEngine.Color get_selectionColor()
  System.Void set_selectionColor(UnityEngine.Color value)
  TMPro.TMP_InputField.SubmitEvent get_onEndEdit()
  System.Void set_onEndEdit(TMPro.TMP_InputField.SubmitEvent value)
  TMPro.TMP_InputField.SubmitEvent get_onSubmit()
  System.Void set_onSubmit(TMPro.TMP_InputField.SubmitEvent value)
  TMPro.TMP_InputField.SelectionEvent get_onSelect()
  System.Void set_onSelect(TMPro.TMP_InputField.SelectionEvent value)
  TMPro.TMP_InputField.SelectionEvent get_onDeselect()
  System.Void set_onDeselect(TMPro.TMP_InputField.SelectionEvent value)
  TMPro.TMP_InputField.TextSelectionEvent get_onTextSelection()
  System.Void set_onTextSelection(TMPro.TMP_InputField.TextSelectionEvent value)
  TMPro.TMP_InputField.TextSelectionEvent get_onEndTextSelection()
  System.Void set_onEndTextSelection(TMPro.TMP_InputField.TextSelectionEvent value)
  TMPro.TMP_InputField.OnChangeEvent get_onValueChanged()
  System.Void set_onValueChanged(TMPro.TMP_InputField.OnChangeEvent value)
  TMPro.TMP_InputField.TouchScreenKeyboardEvent get_onTouchScreenKeyboardStatusChanged()
  System.Void set_onTouchScreenKeyboardStatusChanged(TMPro.TMP_InputField.TouchScreenKeyboardEvent value)
  TMPro.TMP_InputField.OnValidateInput get_onValidateInput()
  System.Void set_onValidateInput(TMPro.TMP_InputField.OnValidateInput value)
  UnityEngine.Events.UnityEvent get_onFocused()
  System.Void set_onFocused(UnityEngine.Events.UnityEvent value)
  System.Int32 get_characterLimit()
  System.Void set_characterLimit(System.Int32 value)
  System.Single get_pointSize()
  System.Void set_pointSize(System.Single value)
  TMPro.TMP_FontAsset get_fontAsset()
  System.Void set_fontAsset(TMPro.TMP_FontAsset value)
  System.Boolean get_onFocusSelectAll()
  System.Void set_onFocusSelectAll(System.Boolean value)
  System.Boolean get_resetOnDeActivation()
  System.Void set_resetOnDeActivation(System.Boolean value)
  System.Boolean get_restoreOriginalTextOnEscape()
  System.Void set_restoreOriginalTextOnEscape(System.Boolean value)
  System.Boolean get_wontReleaseSelectionOnEscape()
  System.Void set_wontReleaseSelectionOnEscape(System.Boolean value)
  System.Boolean get_disableArrowKeyMoveCaret()
  System.Void set_disableArrowKeyMoveCaret(System.Boolean value)
  System.Boolean get_isRichTextEditingAllowed()
  System.Void set_isRichTextEditingAllowed(System.Boolean value)
  TMPro.TMP_InputField.ContentType get_contentType()
  System.Void set_contentType(TMPro.TMP_InputField.ContentType value)
  TMPro.TMP_InputField.LineType get_lineType()
  System.Void set_lineType(TMPro.TMP_InputField.LineType value)
  System.Int32 get_lineLimit()
  System.Void set_lineLimit(System.Int32 value)
  TMPro.TMP_InputField.InputType get_inputType()
  System.Void set_inputType(TMPro.TMP_InputField.InputType value)
  UnityEngine.TouchScreenKeyboardType get_keyboardType()
  System.Void set_keyboardType(UnityEngine.TouchScreenKeyboardType value)
  TMPro.TMP_InputField.CharacterValidation get_characterValidation()
  System.Void set_characterValidation(TMPro.TMP_InputField.CharacterValidation value)
  TMPro.TMP_InputValidator get_inputValidator()
  System.Void set_inputValidator(TMPro.TMP_InputValidator value)
  System.Boolean get_readOnly()
  System.Void set_readOnly(System.Boolean value)
  System.Boolean get_richText()
  System.Void set_richText(System.Boolean value)
  System.Boolean get_multiLine()
  System.Char get_asteriskChar()
  System.Void set_asteriskChar(System.Char value)
  System.Boolean get_wasCanceled()
  System.Void ClampStringPos(System.Int32& pos)
  System.Void ClampCaretPos(System.Int32& pos)
  System.Int32 get_caretPositionInternal()
  System.Void set_caretPositionInternal(System.Int32 value)
  System.Int32 get_stringPositionInternal()
  System.Void set_stringPositionInternal(System.Int32 value)
  System.Int32 get_caretSelectPositionInternal()
  System.Void set_caretSelectPositionInternal(System.Int32 value)
  System.Int32 get_stringSelectPositionInternal()
  System.Void set_stringSelectPositionInternal(System.Int32 value)
  System.Boolean get_hasSelection()
  System.Int32 get_caretPosition()
  System.Void set_caretPosition(System.Int32 value)
  System.Int32 get_selectionAnchorPosition()
  System.Void set_selectionAnchorPosition(System.Int32 value)
  System.Int32 get_selectionFocusPosition()
  System.Void set_selectionFocusPosition(System.Int32 value)
  System.Int32 get_stringPosition()
  System.Void set_stringPosition(System.Int32 value)
  System.Int32 get_selectionStringAnchorPosition()
  System.Void set_selectionStringAnchorPosition(System.Int32 value)
  System.Int32 get_selectionStringFocusPosition()
  System.Void set_selectionStringFocusPosition(System.Int32 value)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void ON_TEXT_CHANGED(UnityEngine.Object obj)
  System.Collections.IEnumerator CaretBlink()
  System.Void SetCaretVisible()
  System.Void SetCaretActive()
  System.Void OnFocus()
  System.Void SelectAll()
  System.Void MoveTextEnd(System.Boolean shift)
  System.Void MoveTextStart(System.Boolean shift)
  System.Void MoveToEndOfLine(System.Boolean shift, System.Boolean ctrl)
  System.Void MoveToStartOfLine(System.Boolean shift, System.Boolean ctrl)
  System.String get_clipboard()
  System.Void set_clipboard(System.String value)
  System.Boolean InPlaceEditing()
  System.Void UpdateStringPositionFromKeyboard()
  System.Void LateUpdate()
  System.Boolean MayDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Collections.IEnumerator MouseDragOutsideRect(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  TMPro.TMP_InputField.EditState KeyPressed(UnityEngine.Event evt)
  System.Boolean IsValidChar(System.Char c)
  System.Void ProcessEvent(UnityEngine.Event e)
  System.Void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData)
  System.Single GetScrollPositionRelativeToViewport()
  System.String GetSelectedString()
  System.Int32 FindNextWordBegin()
  System.Void MoveRight(System.Boolean shift, System.Boolean ctrl)
  System.Int32 FindPrevWordBegin()
  System.Void MoveLeft(System.Boolean shift, System.Boolean ctrl)
  System.Int32 LineUpCharacterPosition(System.Int32 originalPos, System.Boolean goToFirstChar)
  System.Int32 LineDownCharacterPosition(System.Int32 originalPos, System.Boolean goToLastChar)
  System.Int32 PageUpCharacterPosition(System.Int32 originalPos, System.Boolean goToFirstChar)
  System.Int32 PageDownCharacterPosition(System.Int32 originalPos, System.Boolean goToLastChar)
  System.Void MoveDown(System.Boolean shift)
  System.Void MoveDown(System.Boolean shift, System.Boolean goToLastChar)
  System.Void MoveUp(System.Boolean shift)
  System.Void MoveUp(System.Boolean shift, System.Boolean goToFirstChar)
  System.Void MovePageUp(System.Boolean shift)
  System.Void MovePageUp(System.Boolean shift, System.Boolean goToFirstChar)
  System.Void MovePageDown(System.Boolean shift)
  System.Void MovePageDown(System.Boolean shift, System.Boolean goToLastChar)
  System.Void Delete()
  System.Void DeleteKey()
  System.Void Backspace()
  System.Void Append(System.String input)
  System.Void Append(System.Char input)
  System.Void Insert(System.Char c)
  System.Void UpdateTouchKeyboardFromEditChanges()
  System.Void SendOnValueChangedAndUpdateLabel()
  System.Void SendOnValueChanged()
  System.Void SendOnEndEdit()
  System.Void SendOnSubmit()
  System.Void SendOnFocus()
  System.Void SendOnFocusLost()
  System.Void SendOnTextSelection()
  System.Void SendOnEndTextSelection()
  System.Void SendTouchScreenKeyboardStatusChanged()
  System.Void UpdateLabel()
  System.Void UpdateScrollbar()
  System.Void OnScrollbarValueChange(System.Single value)
  System.Void UpdateMaskRegions()
  System.Void AdjustTextPositionRelativeToViewport(System.Single relativePosition)
  System.Int32 GetCaretPositionFromStringIndex(System.Int32 stringIndex)
  System.Int32 GetMinCaretPositionFromStringIndex(System.Int32 stringIndex)
  System.Int32 GetMaxCaretPositionFromStringIndex(System.Int32 stringIndex)
  System.Int32 GetStringIndexFromCaretPosition(System.Int32 caretPosition)
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
  System.Void GenerateHightlight(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset)
  System.Void AdjustRectTransformRelativeToViewport(UnityEngine.Vector2 startPosition, System.Single height, System.Boolean isCharVisible)
  System.Char Validate(System.String text, System.Int32 pos, System.Char ch)
  System.Void ActivateInputField()
  System.Void ActivateInputFieldInternal()
  System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnControlClick()
  System.Void ReleaseSelection()
  System.Void DeactivateInputField(System.Boolean clearSelection)
  System.Void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void EnforceContentType()
  System.Void SetTextComponentWrapMode()
  System.Void SetTextComponentRichTextMode()
  System.Void SetToCustomIfContentTypeIsNot(TMPro.TMP_InputField.ContentType[] allowedContentTypes)
  System.Void SetToCustom()
  System.Void SetToCustom(TMPro.TMP_InputField.CharacterValidation characterValidation)
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
  System.Void SetGlobalPointSize(System.Single pointSize)
  System.Void SetGlobalFontAsset(TMPro.TMP_FontAsset fontAsset)
  System.Void .cctor()
  UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform()
END_CLASS

CLASS: TMPro.SetPropertyUtility
TYPE:  class
TOKEN: 0x2000066
FIELDS:
METHODS:
  System.Boolean SetColor(UnityEngine.Color& currentValue, UnityEngine.Color newValue)
  System.Boolean SetEquatableStruct(T& currentValue, T newValue)
  System.Boolean SetStruct(T& currentValue, T newValue)
  System.Boolean SetClass(T& currentValue, T newValue)
END_CLASS

CLASS: TMPro.TMP_InputValidator
TYPE:  class
TOKEN: 0x2000067
EXTENDS: ScriptableObject
FIELDS:
METHODS:
  System.Char Validate(System.String& text, System.Int32& pos, System.Char ch)
  System.Void .ctor()
END_CLASS

CLASS: TMPro.TMP_LineInfo
TYPE:  struct
TOKEN: 0x2000068
FIELDS:
  public            System.Int32                    controlCharacterCount  // 0x10
  public            System.Int32                    characterCount  // 0x14
  public            System.Int32                    visibleCharacterCount  // 0x18
  public            System.Int32                    spaceCount  // 0x1C
  public            System.Int32                    wordCount  // 0x20
  public            System.Int32                    firstCharacterIndex  // 0x24
  public            System.Int32                    firstVisibleCharacterIndex  // 0x28
  public            System.Int32                    lastCharacterIndex  // 0x2C
  public            System.Int32                    lastVisibleCharacterIndex  // 0x30
  public            System.Single                   length  // 0x34
  public            System.Single                   lineHeight  // 0x38
  public            System.Single                   ascender  // 0x3C
  public            System.Single                   baseline  // 0x40
  public            System.Single                   descender  // 0x44
  public            System.Single                   maxAdvance  // 0x48
  public            System.Single                   width  // 0x4C
  public            System.Single                   marginLeft  // 0x50
  public            System.Single                   marginRight  // 0x54
  public            TMPro.HorizontalAlignmentOptionsalignment  // 0x58
  public            TMPro.Extents                   lineExtents  // 0x5C
METHODS:
END_CLASS

CLASS: TMPro.TMP_ListPool`1
TYPE:  class
TOKEN: 0x2000069
FIELDS:
  private   static readonly TMPro.TMP_ObjectPool<System.Collections.Generic.List<T>>s_ListPool  // 0x0
METHODS:
  System.Collections.Generic.List<T> Get()
  System.Void Release(System.Collections.Generic.List<T> toRelease)
  System.Void .cctor()
END_CLASS

CLASS: TMPro.TMP_MaterialManager
TYPE:  class
TOKEN: 0x200006B
FIELDS:
  private   static  System.Collections.Generic.List<TMPro.TMP_MaterialManager.MaskingMaterial>m_materialList  // 0x0
  private   static  System.Collections.Generic.Dictionary<System.Int64,TMPro.TMP_MaterialManager.FallbackMaterial>m_fallbackMaterials  // 0x8
  private   static  System.Collections.Generic.Dictionary<System.Int32,System.Int64>m_fallbackMaterialLookup  // 0x10
  private   static  System.Collections.Generic.List<TMPro.TMP_MaterialManager.FallbackMaterial>m_fallbackCleanupList  // 0x18
  private   static  System.Boolean                  isFallbackListDirty  // 0x20
  private   static  System.String                   s_overlayShaderKeyword  // 0x28
METHODS:
  System.Void .cctor()
  System.Void OnPreRender()
  System.String get_overlayShaderKeyword()
  System.Void set_overlayShaderKeyword(System.String value)
  UnityEngine.Material GetStencilMaterial(UnityEngine.Material baseMaterial, System.Int32 stencilID)
  System.Void ReleaseStencilMaterial(UnityEngine.Material stencilMaterial)
  UnityEngine.Material GetBaseMaterial(UnityEngine.Material stencilMaterial)
  UnityEngine.Material SetStencil(UnityEngine.Material material, System.Int32 stencilID)
  System.Void AddMaskingMaterial(UnityEngine.Material baseMaterial, UnityEngine.Material stencilMaterial, System.Int32 stencilID)
  System.Void RemoveStencilMaterial(UnityEngine.Material stencilMaterial)
  System.Void ReleaseBaseMaterial(UnityEngine.Material baseMaterial)
  System.Void ClearMaterials()
  System.Int32 GetStencilID(UnityEngine.GameObject obj)
  UnityEngine.Material GetMaterialForRendering(UnityEngine.UI.MaskableGraphic graphic, UnityEngine.Material baseMaterial)
  UnityEngine.Transform FindRootSortOverrideCanvas(UnityEngine.Transform start)
  UnityEngine.Material GetFallbackMaterial(TMPro.TMP_FontAsset fontAsset, UnityEngine.Material sourceMaterial, System.Int32 atlasIndex)
  UnityEngine.Material GetFallbackMaterial(UnityEngine.Material sourceMaterial, UnityEngine.Material targetMaterial)
  System.Void AddFallbackMaterialReference(UnityEngine.Material targetMaterial)
  System.Void RemoveFallbackMaterialReference(UnityEngine.Material targetMaterial)
  System.Void CleanupFallbackMaterials()
  System.Void ReleaseFallbackMaterial(UnityEngine.Material fallbackMaterial)
  System.Void CopyMaterialPresetProperties(UnityEngine.Material source, UnityEngine.Material destination)
END_CLASS

CLASS: TMPro.VertexSortingOrder
TYPE:  struct
TOKEN: 0x2000072
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.VertexSortingOrder        Normal  // 0x0
  public    static  TMPro.VertexSortingOrder        Reverse  // 0x0
METHODS:
END_CLASS

CLASS: TMPro.TMP_MeshInfo
TYPE:  struct
TOKEN: 0x2000073
FIELDS:
  private   static readonly UnityEngine.Color32             s_DefaultColor  // 0x0
  private   static readonly UnityEngine.Vector3             s_DefaultNormal  // 0x4
  private   static readonly UnityEngine.Vector4             s_DefaultTangent  // 0x10
  private   static readonly UnityEngine.Bounds              s_DefaultBounds  // 0x20
  public            UnityEngine.Mesh                mesh  // 0x10
  public            System.Int32                    vertexCount  // 0x18
  public            UnityEngine.Vector3[]           vertices  // 0x20
  public            UnityEngine.Vector3[]           normals  // 0x28
  public            UnityEngine.Vector4[]           tangents  // 0x30
  public            UnityEngine.Vector2[]           uvs0  // 0x38
  public            UnityEngine.Vector2[]           uvs2  // 0x40
  public            UnityEngine.Color32[]           colors32  // 0x48
  public            System.Int32[]                  triangles  // 0x50
  public            UnityEngine.Material            material  // 0x58
METHODS:
  System.Void .ctor(UnityEngine.Mesh mesh, System.Int32 size)
  System.Void .ctor(UnityEngine.Mesh mesh, System.Int32 size, System.Boolean isVolumetric)
  System.Void ResizeMeshInfo(System.Int32 size)
  System.Void ResizeMeshInfo(System.Int32 size, System.Boolean isVolumetric)
  System.Void Clear()
  System.Void Clear(System.Boolean uploadChanges)
  System.Void ClearUnusedVertices()
  System.Void ClearUnusedVertices(System.Int32 startIndex)
  System.Void ClearUnusedVertices(System.Int32 startIndex, System.Boolean updateMesh)
  System.Void SortGeometry(TMPro.VertexSortingOrder order)
  System.Void SortGeometry(System.Collections.Generic.IList<System.Int32> sortingOrder)
  System.Void SwapVertexData(System.Int32 src, System.Int32 dst)
  System.Void Dispose()
  System.Void .cctor()
END_CLASS

CLASS: TMPro.TMP_ObjectPool`1
TYPE:  class
TOKEN: 0x2000074
FIELDS:
  private   readonly System.Collections.Generic.Stack<T>m_Stack  // 0x0
  private   readonly UnityEngine.Events.UnityAction<T>m_ActionOnGet  // 0x0
  private   readonly UnityEngine.Events.UnityAction<T>m_ActionOnRelease  // 0x0
  private           System.Int32                    <countAll>k__BackingField  // 0x0
METHODS:
  System.Int32 get_countAll()
  System.Void set_countAll(System.Int32 value)
  System.Int32 get_countActive()
  System.Int32 get_countInactive()
  System.Void .ctor(UnityEngine.Events.UnityAction<T> actionOnGet, UnityEngine.Events.UnityAction<T> actionOnRelease)
  T Get()
  System.Void Release(T element)
END_CLASS

CLASS: TMPro.TMP_ResourceManager
TYPE:  class
TOKEN: 0x2000075
FIELDS:
  private   static readonly TMPro.TMP_ResourceManager       s_instance  // 0x0
  private   static  TMPro.TMP_Settings              s_TextSettings  // 0x8
  private   static readonly System.Collections.Generic.List<TMPro.TMP_FontAsset>s_FontAssetReferences  // 0x10
  private   static readonly System.Collections.Generic.Dictionary<System.Int32,TMPro.TMP_FontAsset>s_FontAssetReferenceLookup  // 0x18
METHODS:
  System.Void .cctor()
  TMPro.TMP_Settings GetTextSettings()
  System.Void AddFontAsset(TMPro.TMP_FontAsset fontAsset)
  System.Boolean TryGetFontAsset(System.Int32 hashcode, TMPro.TMP_FontAsset& fontAsset)
  System.Void RebuildFontAssetCache(System.Int32 instanceID)
  System.Void .ctor()
END_CLASS

CLASS: TMPro.MarkupTag
TYPE:  struct
TOKEN: 0x2000076
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.MarkupTag                 BOLD  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_BOLD  // 0x0
  public    static  TMPro.MarkupTag                 ITALIC  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_ITALIC  // 0x0
  public    static  TMPro.MarkupTag                 UNDERLINE  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_UNDERLINE  // 0x0
  public    static  TMPro.MarkupTag                 STRIKETHROUGH  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_STRIKETHROUGH  // 0x0
  public    static  TMPro.MarkupTag                 MARK  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_MARK  // 0x0
  public    static  TMPro.MarkupTag                 SUBSCRIPT  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_SUBSCRIPT  // 0x0
  public    static  TMPro.MarkupTag                 SUPERSCRIPT  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_SUPERSCRIPT  // 0x0
  public    static  TMPro.MarkupTag                 COLOR  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_COLOR  // 0x0
  public    static  TMPro.MarkupTag                 ALPHA  // 0x0
  public    static  TMPro.MarkupTag                 A  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_A  // 0x0
  public    static  TMPro.MarkupTag                 SIZE  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_SIZE  // 0x0
  public    static  TMPro.MarkupTag                 SPRITE  // 0x0
  public    static  TMPro.MarkupTag                 NO_BREAK  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_NO_BREAK  // 0x0
  public    static  TMPro.MarkupTag                 STYLE  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_STYLE  // 0x0
  public    static  TMPro.MarkupTag                 FONT  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_FONT  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_MATERIAL  // 0x0
  public    static  TMPro.MarkupTag                 LINK  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_LINK  // 0x0
  public    static  TMPro.MarkupTag                 FONT_WEIGHT  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_FONT_WEIGHT  // 0x0
  public    static  TMPro.MarkupTag                 NO_PARSE  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_NO_PARSE  // 0x0
  public    static  TMPro.MarkupTag                 POSITION  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_POSITION  // 0x0
  public    static  TMPro.MarkupTag                 VERTICAL_OFFSET  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_VERTICAL_OFFSET  // 0x0
  public    static  TMPro.MarkupTag                 SPACE  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_SPACE  // 0x0
  public    static  TMPro.MarkupTag                 PAGE  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_PAGE  // 0x0
  public    static  TMPro.MarkupTag                 ALIGN  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_ALIGN  // 0x0
  public    static  TMPro.MarkupTag                 WIDTH  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_WIDTH  // 0x0
  public    static  TMPro.MarkupTag                 GRADIENT  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_GRADIENT  // 0x0
  public    static  TMPro.MarkupTag                 CHARACTER_SPACE  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_CHARACTER_SPACE  // 0x0
  public    static  TMPro.MarkupTag                 MONOSPACE  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_MONOSPACE  // 0x0
  public    static  TMPro.MarkupTag                 CLASS  // 0x0
  public    static  TMPro.MarkupTag                 INDENT  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_INDENT  // 0x0
  public    static  TMPro.MarkupTag                 LINE_INDENT  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_LINE_INDENT  // 0x0
  public    static  TMPro.MarkupTag                 MARGIN  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_MARGIN  // 0x0
  public    static  TMPro.MarkupTag                 MARGIN_LEFT  // 0x0
  public    static  TMPro.MarkupTag                 MARGIN_RIGHT  // 0x0
  public    static  TMPro.MarkupTag                 LINE_HEIGHT  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_LINE_HEIGHT  // 0x0
  public    static  TMPro.MarkupTag                 ACTION  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_ACTION  // 0x0
  public    static  TMPro.MarkupTag                 SCALE  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_SCALE  // 0x0
  public    static  TMPro.MarkupTag                 ROTATE  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_ROTATE  // 0x0
  public    static  TMPro.MarkupTag                 LOWERCASE  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_LOWERCASE  // 0x0
  public    static  TMPro.MarkupTag                 ALLCAPS  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_ALLCAPS  // 0x0
  public    static  TMPro.MarkupTag                 UPPERCASE  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_UPPERCASE  // 0x0
  public    static  TMPro.MarkupTag                 SMALLCAPS  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_SMALLCAPS  // 0x0
  public    static  TMPro.MarkupTag                 LIGA  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_LIGA  // 0x0
  public    static  TMPro.MarkupTag                 FRAC  // 0x0
  public    static  TMPro.MarkupTag                 SLASH_FRAC  // 0x0
  public    static  TMPro.MarkupTag                 NAME  // 0x0
  public    static  TMPro.MarkupTag                 INDEX  // 0x0
  public    static  TMPro.MarkupTag                 TINT  // 0x0
  public    static  TMPro.MarkupTag                 ANIM  // 0x0
  public    static  TMPro.MarkupTag                 MATERIAL  // 0x0
  public    static  TMPro.MarkupTag                 HREF  // 0x0
  public    static  TMPro.MarkupTag                 ANGLE  // 0x0
  public    static  TMPro.MarkupTag                 RED  // 0x0
  public    static  TMPro.MarkupTag                 GREEN  // 0x0
  public    static  TMPro.MarkupTag                 BLUE  // 0x0
  public    static  TMPro.MarkupTag                 YELLOW  // 0x0
  public    static  TMPro.MarkupTag                 ORANGE  // 0x0
  public    static  TMPro.MarkupTag                 BLACK  // 0x0
  public    static  TMPro.MarkupTag                 WHITE  // 0x0
  public    static  TMPro.MarkupTag                 PURPLE  // 0x0
  public    static  TMPro.MarkupTag                 BR  // 0x0
  public    static  TMPro.MarkupTag                 ZWSP  // 0x0
  public    static  TMPro.MarkupTag                 NBSP  // 0x0
  public    static  TMPro.MarkupTag                 SHY  // 0x0
  public    static  TMPro.MarkupTag                 LEFT  // 0x0
  public    static  TMPro.MarkupTag                 RIGHT  // 0x0
  public    static  TMPro.MarkupTag                 CENTER  // 0x0
  public    static  TMPro.MarkupTag                 JUSTIFIED  // 0x0
  public    static  TMPro.MarkupTag                 FLUSH  // 0x0
  public    static  TMPro.MarkupTag                 NONE  // 0x0
  public    static  TMPro.MarkupTag                 PLUS  // 0x0
  public    static  TMPro.MarkupTag                 MINUS  // 0x0
  public    static  TMPro.MarkupTag                 PX  // 0x0
  public    static  TMPro.MarkupTag                 PLUS_PX  // 0x0
  public    static  TMPro.MarkupTag                 MINUS_PX  // 0x0
  public    static  TMPro.MarkupTag                 EM  // 0x0
  public    static  TMPro.MarkupTag                 PLUS_EM  // 0x0
  public    static  TMPro.MarkupTag                 MINUS_EM  // 0x0
  public    static  TMPro.MarkupTag                 PCT  // 0x0
  public    static  TMPro.MarkupTag                 PLUS_PCT  // 0x0
  public    static  TMPro.MarkupTag                 MINUS_PCT  // 0x0
  public    static  TMPro.MarkupTag                 PERCENTAGE  // 0x0
  public    static  TMPro.MarkupTag                 PLUS_PERCENTAGE  // 0x0
  public    static  TMPro.MarkupTag                 MINUS_PERCENTAGE  // 0x0
  public    static  TMPro.MarkupTag                 TRUE  // 0x0
  public    static  TMPro.MarkupTag                 FALSE  // 0x0
  public    static  TMPro.MarkupTag                 INVALID  // 0x0
  public    static  TMPro.MarkupTag                 NORMAL  // 0x0
  public    static  TMPro.MarkupTag                 DEFAULT  // 0x0
METHODS:
END_CLASS

CLASS: TMPro.TagValueType
TYPE:  struct
TOKEN: 0x2000077
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TagValueType              None  // 0x0
  public    static  TMPro.TagValueType              NumericalValue  // 0x0
  public    static  TMPro.TagValueType              StringValue  // 0x0
  public    static  TMPro.TagValueType              ColorValue  // 0x0
METHODS:
END_CLASS

CLASS: TMPro.TagUnitType
TYPE:  struct
TOKEN: 0x2000078
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TagUnitType               Pixels  // 0x0
  public    static  TMPro.TagUnitType               FontUnits  // 0x0
  public    static  TMPro.TagUnitType               Percentage  // 0x0
METHODS:
END_CLASS

CLASS: TMPro.CodePoint
TYPE:  class
TOKEN: 0x2000079
FIELDS:
  public    static  System.UInt32                   SPACE  // 0x0
  public    static  System.UInt32                   DOUBLE_QUOTE  // 0x0
  public    static  System.UInt32                   NUMBER_SIGN  // 0x0
  public    static  System.UInt32                   PERCENTAGE  // 0x0
  public    static  System.UInt32                   PLUS  // 0x0
  public    static  System.UInt32                   MINUS  // 0x0
  public    static  System.UInt32                   PERIOD  // 0x0
  public    static  System.UInt32                   HYPHEN_MINUS  // 0x0
  public    static  System.UInt32                   SOFT_HYPHEN  // 0x0
  public    static  System.UInt32                   HYPHEN  // 0x0
  public    static  System.UInt32                   NON_BREAKING_HYPHEN  // 0x0
  public    static  System.UInt32                   ZERO_WIDTH_SPACE  // 0x0
  public    static  System.UInt32                   RIGHT_SINGLE_QUOTATION  // 0x0
  public    static  System.UInt32                   APOSTROPHE  // 0x0
  public    static  System.UInt32                   WORD_JOINER  // 0x0
  public    static  System.UInt32                   HIGH_SURROGATE_START  // 0x0
  public    static  System.UInt32                   HIGH_SURROGATE_END  // 0x0
  public    static  System.UInt32                   LOW_SURROGATE_START  // 0x0
  public    static  System.UInt32                   LOW_SURROGATE_END  // 0x0
  public    static  System.UInt32                   UNICODE_PLANE01_START  // 0x0
METHODS:
END_CLASS

CLASS: TMPro.TMP_ScrollbarEventHandler
TYPE:  class
TOKEN: 0x200007A
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Boolean                  isSelected  // 0x18
METHODS:
  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void .ctor()
END_CLASS

CLASS: TMPro.TMP_SelectionCaret
TYPE:  class
TOKEN: 0x200007B
EXTENDS: MaskableGraphic
FIELDS:
METHODS:
  System.Void Cull(UnityEngine.Rect clipRect, System.Boolean validRect)
  System.Void UpdateGeometry()
  System.Void .ctor()
END_CLASS

CLASS: TMPro.TMP_Settings
TYPE:  class
TOKEN: 0x200007C
EXTENDS: ScriptableObject
FIELDS:
  private   static  TMPro.TMP_Settings              s_Instance  // 0x0
  private           System.Boolean                  m_enableWordWrapping  // 0x18
  private           System.Boolean                  m_enableKerning  // 0x19
  private           System.Boolean                  m_enableExtraPadding  // 0x1A
  private           System.Boolean                  m_enableTintAllSprites  // 0x1B
  private           System.Boolean                  m_enableParseEscapeCharacters  // 0x1C
  private           System.Boolean                  m_EnableRaycastTarget  // 0x1D
  private           System.Boolean                  m_GetFontFeaturesAtRuntime  // 0x1E
  private           System.Int32                    m_missingGlyphCharacter  // 0x20
  private           System.Boolean                  m_warningsDisabled  // 0x24
  private           TMPro.TMP_FontAsset             m_defaultFontAsset  // 0x28
  private           System.String                   m_defaultFontAssetPath  // 0x30
  private           System.Single                   m_defaultFontSize  // 0x38
  private           System.Single                   m_defaultAutoSizeMinRatio  // 0x3C
  private           System.Single                   m_defaultAutoSizeMaxRatio  // 0x40
  private           UnityEngine.Vector2             m_defaultTextMeshProTextContainerSize  // 0x44
  private           UnityEngine.Vector2             m_defaultTextMeshProUITextContainerSize  // 0x4C
  private           System.Boolean                  m_autoSizeTextContainer  // 0x54
  private           System.Boolean                  m_IsTextObjectScaleStatic  // 0x55
  private           System.Collections.Generic.List<TMPro.TMP_FontAsset>m_fallbackFontAssets  // 0x58
  private           System.Boolean                  m_matchMaterialPreset  // 0x60
  private           TMPro.TMP_SpriteAsset           m_defaultSpriteAsset  // 0x68
  private           System.String                   m_defaultSpriteAssetPath  // 0x70
  private           System.Boolean                  m_enableEmojiSupport  // 0x78
  private           System.UInt32                   m_MissingCharacterSpriteUnicode  // 0x7C
  private           System.String                   m_defaultColorGradientPresetsPath  // 0x80
  private           TMPro.TMP_StyleSheet            m_defaultStyleSheet  // 0x88
  private           System.String                   m_StyleSheetsResourcePath  // 0x90
  private           UnityEngine.TextAsset           m_leadingCharacters  // 0x98
  private           UnityEngine.TextAsset           m_followingCharacters  // 0xA0
  private           TMPro.TMP_Settings.LineBreakingTablem_linebreakingRules  // 0xA8
  private           System.Boolean                  m_UseModernHangulLineBreakingRules  // 0xB0
  public            TMPro.IFontAssetLoader          dynamicFontAssetLoader  // 0xB8
METHODS:
  System.String get_version()
  System.Boolean get_enableWordWrapping()
  System.Boolean get_enableKerning()
  System.Boolean get_enableExtraPadding()
  System.Boolean get_enableTintAllSprites()
  System.Boolean get_enableParseEscapeCharacters()
  System.Boolean get_enableRaycastTarget()
  System.Boolean get_getFontFeaturesAtRuntime()
  System.Int32 get_missingGlyphCharacter()
  System.Void set_missingGlyphCharacter(System.Int32 value)
  System.Boolean get_warningsDisabled()
  TMPro.TMP_FontAsset get_defaultFontAsset()
  System.String get_defaultFontAssetPath()
  System.Single get_defaultFontSize()
  System.Single get_defaultTextAutoSizingMinRatio()
  System.Single get_defaultTextAutoSizingMaxRatio()
  UnityEngine.Vector2 get_defaultTextMeshProTextContainerSize()
  UnityEngine.Vector2 get_defaultTextMeshProUITextContainerSize()
  System.Boolean get_autoSizeTextContainer()
  System.Boolean get_isTextObjectScaleStatic()
  System.Void set_isTextObjectScaleStatic(System.Boolean value)
  System.Collections.Generic.List<TMPro.TMP_FontAsset> get_fallbackFontAssets()
  System.Boolean get_matchMaterialPreset()
  TMPro.TMP_SpriteAsset get_defaultSpriteAsset()
  System.String get_defaultSpriteAssetPath()
  System.Boolean get_enableEmojiSupport()
  System.Void set_enableEmojiSupport(System.Boolean value)
  System.UInt32 get_missingCharacterSpriteUnicode()
  System.Void set_missingCharacterSpriteUnicode(System.UInt32 value)
  System.String get_defaultColorGradientPresetsPath()
  TMPro.TMP_StyleSheet get_defaultStyleSheet()
  System.String get_styleSheetsResourcePath()
  UnityEngine.TextAsset get_leadingCharacters()
  UnityEngine.TextAsset get_followingCharacters()
  TMPro.TMP_Settings.LineBreakingTable get_linebreakingRules()
  System.Boolean get_useModernHangulLineBreakingRules()
  System.Void set_useModernHangulLineBreakingRules(System.Boolean value)
  TMPro.TMP_Settings get_instance()
  TMPro.TMP_Settings LoadDefaultSettings()
  TMPro.TMP_Settings GetSettings()
  TMPro.TMP_FontAsset GetFontAsset()
  System.Void ClearDefaultFontAsset()
  TMPro.TMP_SpriteAsset GetSpriteAsset()
  TMPro.TMP_StyleSheet GetStyleSheet()
  System.Void LoadLinebreakingRules()
  TMPro.IFontAssetLoader GetDynamicFallbackFontAssetLoader()
  System.Collections.Generic.Dictionary<System.Int32,System.Char> GetCharacters(UnityEngine.TextAsset file)
  System.Void .ctor()
END_CLASS

CLASS: TMPro.ShaderUtilities
TYPE:  class
TOKEN: 0x200007E
FIELDS:
  public    static  System.Int32                    ID_MainTex  // 0x0
  public    static  System.Int32                    ID_FaceTex  // 0x4
  public    static  System.Int32                    ID_FaceColor  // 0x8
  public    static  System.Int32                    ID_FaceDilate  // 0xC
  public    static  System.Int32                    ID_Shininess  // 0x10
  public    static  System.Int32                    ID_UnderlayColor  // 0x14
  public    static  System.Int32                    ID_UnderlayOffsetX  // 0x18
  public    static  System.Int32                    ID_UnderlayOffsetY  // 0x1C
  public    static  System.Int32                    ID_UnderlayDilate  // 0x20
  public    static  System.Int32                    ID_UnderlaySoftness  // 0x24
  public    static  System.Int32                    ID_UnderlayOffset  // 0x28
  public    static  System.Int32                    ID_UnderlayIsoPerimeter  // 0x2C
  public    static  System.Int32                    ID_WeightNormal  // 0x30
  public    static  System.Int32                    ID_WeightBold  // 0x34
  public    static  System.Int32                    ID_OutlineTex  // 0x38
  public    static  System.Int32                    ID_OutlineWidth  // 0x3C
  public    static  System.Int32                    ID_OutlineSoftness  // 0x40
  public    static  System.Int32                    ID_OutlineColor  // 0x44
  public    static  System.Int32                    ID_Outline2Color  // 0x48
  public    static  System.Int32                    ID_Outline2Width  // 0x4C
  public    static  System.Int32                    ID_Padding  // 0x50
  public    static  System.Int32                    ID_GradientScale  // 0x54
  public    static  System.Int32                    ID_ScaleX  // 0x58
  public    static  System.Int32                    ID_ScaleY  // 0x5C
  public    static  System.Int32                    ID_PerspectiveFilter  // 0x60
  public    static  System.Int32                    ID_Sharpness  // 0x64
  public    static  System.Int32                    ID_TextureWidth  // 0x68
  public    static  System.Int32                    ID_TextureHeight  // 0x6C
  public    static  System.Int32                    ID_BevelAmount  // 0x70
  public    static  System.Int32                    ID_GlowColor  // 0x74
  public    static  System.Int32                    ID_GlowOffset  // 0x78
  public    static  System.Int32                    ID_GlowPower  // 0x7C
  public    static  System.Int32                    ID_GlowOuter  // 0x80
  public    static  System.Int32                    ID_GlowInner  // 0x84
  public    static  System.Int32                    ID_LightAngle  // 0x88
  public    static  System.Int32                    ID_EnvMap  // 0x8C
  public    static  System.Int32                    ID_EnvMatrix  // 0x90
  public    static  System.Int32                    ID_EnvMatrixRotation  // 0x94
  public    static  System.Int32                    ID_MaskCoord  // 0x98
  public    static  System.Int32                    ID_ClipRect  // 0x9C
  public    static  System.Int32                    ID_MaskSoftnessX  // 0xA0
  public    static  System.Int32                    ID_MaskSoftnessY  // 0xA4
  public    static  System.Int32                    ID_VertexOffsetX  // 0xA8
  public    static  System.Int32                    ID_VertexOffsetY  // 0xAC
  public    static  System.Int32                    ID_UseClipRect  // 0xB0
  public    static  System.Int32                    ID_StencilID  // 0xB4
  public    static  System.Int32                    ID_StencilOp  // 0xB8
  public    static  System.Int32                    ID_StencilComp  // 0xBC
  public    static  System.Int32                    ID_StencilReadMask  // 0xC0
  public    static  System.Int32                    ID_StencilWriteMask  // 0xC4
  public    static  System.Int32                    ID_ShaderFlags  // 0xC8
  public    static  System.Int32                    ID_ScaleRatio_A  // 0xCC
  public    static  System.Int32                    ID_ScaleRatio_B  // 0xD0
  public    static  System.Int32                    ID_ScaleRatio_C  // 0xD4
  public    static  System.Int32                    ID_UseClipSceneDepth  // 0xD8
  public    static  System.Int32                    ID_UsedForWorldUI  // 0xDC
  public    static  System.String                   Keyword_ClipSceneDepth  // 0xE0
  public    static  System.String                   Keyword_UsedForWorldUI  // 0xE8
  public    static  System.String                   Keyword_Bevel  // 0xF0
  public    static  System.String                   Keyword_Glow  // 0xF8
  public    static  System.String                   Keyword_Underlay  // 0x100
  public    static  System.String                   Keyword_Ratios  // 0x108
  public    static  System.String                   Keyword_MASK_SOFT  // 0x110
  public    static  System.String                   Keyword_MASK_HARD  // 0x118
  public    static  System.String                   Keyword_MASK_TEX  // 0x120
  public    static  System.String                   Keyword_Outline  // 0x128
  public    static  System.String                   ShaderTag_ZTestMode  // 0x130
  public    static  System.String                   ShaderTag_CullMode  // 0x138
  private   static  System.Single                   m_clamp  // 0x140
  public    static  System.Boolean                  isInitialized  // 0x144
  private   static  UnityEngine.Shader              k_ShaderRef_MobileSDF  // 0x148
  private   static  UnityEngine.Shader              k_ShaderRef_MobileBitmap  // 0x150
METHODS:
  UnityEngine.Shader get_ShaderRef_MobileSDF()
  UnityEngine.Shader get_ShaderRef_MobileBitmap()
  System.Void .cctor()
  System.Void GetShaderPropertyIDs()
  System.Void UpdateShaderRatios(UnityEngine.Material mat)
  UnityEngine.Vector4 GetFontExtent(UnityEngine.Material material)
  System.Boolean IsMaskingEnabled(UnityEngine.Material material)
  System.Single GetPadding(UnityEngine.Material material, System.Boolean enableExtraPadding, System.Boolean isBold)
  System.Single GetPadding(UnityEngine.Material[] materials, System.Boolean enableExtraPadding, System.Boolean isBold)
END_CLASS

CLASS: TMPro.TMP_Sprite
TYPE:  class
TOKEN: 0x200007F
EXTENDS: TMP_TextElement_Legacy
FIELDS:
  public            System.String                   name  // 0x38
  public            System.Int32                    hashCode  // 0x40
  public            System.Int32                    unicode  // 0x44
  public            UnityEngine.Vector2             pivot  // 0x48
  public            UnityEngine.Sprite              sprite  // 0x50
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: TMPro.TMP_SpriteAnimator
TYPE:  class
TOKEN: 0x2000080
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Collections.Generic.Dictionary<System.Int32,System.Boolean>m_animations  // 0x18
  private           TMPro.TMP_Text                  m_TextComponent  // 0x20
METHODS:
  System.Void Awake()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void StopAllAnimations()
  System.Void DoSpriteAnimation(System.Int32 currentCharacter, TMPro.TMP_SpriteAsset spriteAsset, System.Int32 start, System.Int32 end, System.Int32 framerate)
  System.Collections.IEnumerator DoSpriteAnimationInternal(System.Int32 currentCharacter, TMPro.TMP_SpriteAsset spriteAsset, System.Int32 start, System.Int32 end, System.Int32 framerate)
  System.Void .ctor()
END_CLASS

CLASS: TMPro.TMP_SpriteAsset
TYPE:  class
TOKEN: 0x2000082
EXTENDS: TMP_Asset
FIELDS:
  private           System.Collections.Generic.Dictionary<System.Int32,System.Int32>m_NameLookup  // 0x30
  private           System.Collections.Generic.Dictionary<System.UInt32,System.Int32>m_GlyphIndexLookup  // 0x38
  private           System.String                   m_Version  // 0x40
  private           UnityEngine.TextCore.FaceInfo   m_FaceInfo  // 0x48
  public            UnityEngine.Texture             spriteSheet  // 0xA8
  private           System.Collections.Generic.List<TMPro.TMP_SpriteCharacter>m_SpriteCharacterTable  // 0xB0
  private           System.Collections.Generic.Dictionary<System.UInt32,TMPro.TMP_SpriteCharacter>m_SpriteCharacterLookup  // 0xB8
  private           System.Collections.Generic.List<TMPro.TMP_SpriteGlyph>m_SpriteGlyphTable  // 0xC0
  private           System.Collections.Generic.Dictionary<System.UInt32,TMPro.TMP_SpriteGlyph>m_SpriteGlyphLookup  // 0xC8
  public            System.Collections.Generic.List<TMPro.TMP_Sprite>spriteInfoList  // 0xD0
  public            System.Collections.Generic.List<TMPro.TMP_SpriteAsset>fallbackSpriteAssets  // 0xD8
  private           System.Boolean                  m_IsSpriteAssetLookupTablesDirty  // 0xE0
  private   static  System.Collections.Generic.HashSet<System.Int32>k_searchedSpriteAssets  // 0x0
METHODS:
  System.String get_version()
  System.Void set_version(System.String value)
  UnityEngine.TextCore.FaceInfo get_faceInfo()
  System.Void set_faceInfo(UnityEngine.TextCore.FaceInfo value)
  System.Collections.Generic.List<TMPro.TMP_SpriteCharacter> get_spriteCharacterTable()
  System.Void set_spriteCharacterTable(System.Collections.Generic.List<TMPro.TMP_SpriteCharacter> value)
  System.Collections.Generic.Dictionary<System.UInt32,TMPro.TMP_SpriteCharacter> get_spriteCharacterLookupTable()
  System.Void set_spriteCharacterLookupTable(System.Collections.Generic.Dictionary<System.UInt32,TMPro.TMP_SpriteCharacter> value)
  System.Collections.Generic.List<TMPro.TMP_SpriteGlyph> get_spriteGlyphTable()
  System.Void set_spriteGlyphTable(System.Collections.Generic.List<TMPro.TMP_SpriteGlyph> value)
  System.Void Awake()
  UnityEngine.Material GetDefaultSpriteMaterial()
  System.Void UpdateLookupTables()
  System.Int32 GetSpriteIndexFromHashcode(System.Int32 hashCode)
  System.Int32 GetSpriteIndexFromUnicode(System.UInt32 unicode)
  System.Int32 GetSpriteIndexFromName(System.String name)
  TMPro.TMP_SpriteAsset SearchForSpriteByUnicode(TMPro.TMP_SpriteAsset spriteAsset, System.UInt32 unicode, System.Boolean includeFallbacks, System.Int32& spriteIndex)
  TMPro.TMP_SpriteAsset SearchForSpriteByUnicodeInternal(System.Collections.Generic.List<TMPro.TMP_SpriteAsset> spriteAssets, System.UInt32 unicode, System.Boolean includeFallbacks, System.Int32& spriteIndex)
  TMPro.TMP_SpriteAsset SearchForSpriteByUnicodeInternal(TMPro.TMP_SpriteAsset spriteAsset, System.UInt32 unicode, System.Boolean includeFallbacks, System.Int32& spriteIndex)
  TMPro.TMP_SpriteAsset SearchForSpriteByHashCode(TMPro.TMP_SpriteAsset spriteAsset, System.Int32 hashCode, System.Boolean includeFallbacks, System.Int32& spriteIndex)
  TMPro.TMP_SpriteAsset SearchForSpriteByHashCodeInternal(System.Collections.Generic.List<TMPro.TMP_SpriteAsset> spriteAssets, System.Int32 hashCode, System.Boolean searchFallbacks, System.Int32& spriteIndex)
  TMPro.TMP_SpriteAsset SearchForSpriteByHashCodeInternal(TMPro.TMP_SpriteAsset spriteAsset, System.Int32 hashCode, System.Boolean searchFallbacks, System.Int32& spriteIndex)
  System.Void SortGlyphTable()
  System.Void SortCharacterTable()
  System.Void SortGlyphAndCharacterTables()
  System.Void UpgradeSpriteAsset()
  System.Void .ctor()
END_CLASS

CLASS: TMPro.TMP_SpriteCharacter
TYPE:  class
TOKEN: 0x2000084
EXTENDS: TMP_TextElement
FIELDS:
  private           System.String                   m_Name  // 0x30
  private           System.Int32                    m_HashCode  // 0x38
METHODS:
  System.String get_name()
  System.Void set_name(System.String value)
  System.Int32 get_hashCode()
  System.Void .ctor()
  System.Void .ctor(System.UInt32 unicode, TMPro.TMP_SpriteGlyph glyph)
  System.Void .ctor(System.UInt32 unicode, TMPro.TMP_SpriteAsset spriteAsset, TMPro.TMP_SpriteGlyph glyph)
  System.Void .ctor(System.UInt32 unicode, System.UInt32 glyphIndex)
END_CLASS

CLASS: TMPro.TMP_SpriteGlyph
TYPE:  class
TOKEN: 0x2000085
EXTENDS: Glyph
FIELDS:
  public            UnityEngine.Sprite              sprite  // 0x48
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.UInt32 index, UnityEngine.TextCore.GlyphMetrics metrics, UnityEngine.TextCore.GlyphRect glyphRect, System.Single scale, System.Int32 atlasIndex)
  System.Void .ctor(System.UInt32 index, UnityEngine.TextCore.GlyphMetrics metrics, UnityEngine.TextCore.GlyphRect glyphRect, System.Single scale, System.Int32 atlasIndex, UnityEngine.Sprite sprite)
END_CLASS

CLASS: TMPro.TMP_Style
TYPE:  class
TOKEN: 0x2000086
FIELDS:
  private   static  TMPro.TMP_Style                 k_NormalStyle  // 0x0
  private           System.String                   m_Name  // 0x10
  private           System.Int32                    m_HashCode  // 0x18
  private           System.String                   m_OpeningDefinition  // 0x20
  private           System.String                   m_ClosingDefinition  // 0x28
  private           System.Int32[]                  m_OpeningTagArray  // 0x30
  private           System.Int32[]                  m_ClosingTagArray  // 0x38
  private           System.UInt32[]                 m_OpeningTagUnicodeArray  // 0x40
  private           System.UInt32[]                 m_ClosingTagUnicodeArray  // 0x48
METHODS:
  TMPro.TMP_Style get_NormalStyle()
  System.String get_name()
  System.Void set_name(System.String value)
  System.Int32 get_hashCode()
  System.Void set_hashCode(System.Int32 value)
  System.String get_styleOpeningDefinition()
  System.String get_styleClosingDefinition()
  System.Int32[] get_styleOpeningTagArray()
  System.Int32[] get_styleClosingTagArray()
  System.Void .ctor(System.String styleName, System.String styleOpeningDefinition, System.String styleClosingDefinition)
  System.Void RefreshStyle()
END_CLASS

CLASS: TMPro.TMP_StyleSheet
TYPE:  class
TOKEN: 0x2000087
EXTENDS: ScriptableObject
FIELDS:
  private           System.Collections.Generic.List<TMPro.TMP_Style>m_StyleList  // 0x18
  private           System.Collections.Generic.Dictionary<System.Int32,TMPro.TMP_Style>m_StyleLookupDictionary  // 0x20
METHODS:
  System.Collections.Generic.List<TMPro.TMP_Style> get_styles()
  System.Void Reset()
  TMPro.TMP_Style GetStyle(System.Int32 hashCode)
  TMPro.TMP_Style GetStyle(System.String name)
  System.Void RefreshStyles()
  System.Void LoadStyleDictionaryInternal()
  System.Void .ctor()
END_CLASS

CLASS: TMPro.TMP_SubMesh
TYPE:  class
TOKEN: 0x2000088
EXTENDS: MonoBehaviour
FIELDS:
  private           TMPro.TMP_FontAsset             m_fontAsset  // 0x18
  private           TMPro.TMP_SpriteAsset           m_spriteAsset  // 0x20
  private           UnityEngine.Material            m_material  // 0x28
  private           UnityEngine.Material            m_sharedMaterial  // 0x30
  private           UnityEngine.Material            m_fallbackMaterial  // 0x38
  private           UnityEngine.Material            m_fallbackSourceMaterial  // 0x40
  private           System.Boolean                  m_isDefaultMaterial  // 0x48
  private           System.Single                   m_padding  // 0x4C
  private           UnityEngine.Renderer            m_renderer  // 0x50
  private           UnityEngine.MeshFilter          m_meshFilter  // 0x58
  private           UnityEngine.Mesh                m_mesh  // 0x60
  private           TMPro.TextMeshPro               m_TextComponent  // 0x68
  private           System.Boolean                  m_isRegisteredForEvents  // 0x70
METHODS:
  TMPro.TMP_FontAsset get_fontAsset()
  System.Void set_fontAsset(TMPro.TMP_FontAsset value)
  TMPro.TMP_SpriteAsset get_spriteAsset()
  System.Void set_spriteAsset(TMPro.TMP_SpriteAsset value)
  UnityEngine.Material get_material()
  System.Void set_material(UnityEngine.Material value)
  UnityEngine.Material get_sharedMaterial()
  System.Void set_sharedMaterial(UnityEngine.Material value)
  UnityEngine.Material get_fallbackMaterial()
  System.Void set_fallbackMaterial(UnityEngine.Material value)
  UnityEngine.Material get_fallbackSourceMaterial()
  System.Void set_fallbackSourceMaterial(UnityEngine.Material value)
  System.Boolean get_isDefaultMaterial()
  System.Void set_isDefaultMaterial(System.Boolean value)
  System.Single get_padding()
  System.Void set_padding(System.Single value)
  UnityEngine.Renderer get_renderer()
  UnityEngine.MeshFilter get_meshFilter()
  UnityEngine.Mesh get_mesh()
  System.Void set_mesh(UnityEngine.Mesh value)
  TMPro.TMP_Text get_textComponent()
  TMPro.TMP_SubMesh AddSubTextObject(TMPro.TextMeshPro textComponent, TMPro.MaterialReference materialReference)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void DestroySelf()
  UnityEngine.Material GetMaterial(UnityEngine.Material mat)
  UnityEngine.Material CreateMaterialInstance(UnityEngine.Material source)
  UnityEngine.Material GetSharedMaterial()
  System.Void SetSharedMaterial(UnityEngine.Material mat)
  System.Single GetPaddingForMaterial()
  System.Void UpdateMeshPadding(System.Boolean isExtraPadding, System.Boolean isUsingBold)
  System.Void SetVerticesDirty()
  System.Void SetMaterialDirty()
  System.Void UpdateMaterial()
  System.Void .ctor()
END_CLASS

CLASS: TMPro.TMP_SubMeshUI
TYPE:  class
TOKEN: 0x2000089
EXTENDS: MaskableGraphic
FIELDS:
  private           TMPro.TMP_FontAsset             m_fontAsset  // 0xE8
  private           TMPro.TMP_SpriteAsset           m_spriteAsset  // 0xF0
  private           UnityEngine.Material            m_material  // 0xF8
  private           UnityEngine.Material            m_sharedMaterial  // 0x100
  private           UnityEngine.Material            m_fallbackMaterial  // 0x108
  private           UnityEngine.Material            m_fallbackSourceMaterial  // 0x110
  private           System.Boolean                  m_isDefaultMaterial  // 0x118
  private           System.Single                   m_padding  // 0x11C
  private           UnityEngine.Mesh                m_mesh  // 0x120
  private           TMPro.TextMeshProUGUI           m_TextComponent  // 0x128
  private           System.Boolean                  m_isRegisteredForEvents  // 0x130
  private           System.Boolean                  m_materialDirty  // 0x131
  private           System.Int32                    m_materialReferenceIndex  // 0x134
  private           UnityEngine.Transform           m_RootCanvasTransform  // 0x138
METHODS:
  TMPro.TMP_FontAsset get_fontAsset()
  System.Void set_fontAsset(TMPro.TMP_FontAsset value)
  TMPro.TMP_SpriteAsset get_spriteAsset()
  System.Void set_spriteAsset(TMPro.TMP_SpriteAsset value)
  UnityEngine.Texture get_mainTexture()
  UnityEngine.Material get_material()
  System.Void set_material(UnityEngine.Material value)
  UnityEngine.Material get_sharedMaterial()
  System.Void set_sharedMaterial(UnityEngine.Material value)
  UnityEngine.Material get_fallbackMaterial()
  System.Void set_fallbackMaterial(UnityEngine.Material value)
  UnityEngine.Material get_fallbackSourceMaterial()
  System.Void set_fallbackSourceMaterial(UnityEngine.Material value)
  UnityEngine.Material get_materialForRendering()
  System.Boolean get_isDefaultMaterial()
  System.Void set_isDefaultMaterial(System.Boolean value)
  System.Single get_padding()
  System.Void set_padding(System.Single value)
  UnityEngine.Mesh get_mesh()
  System.Void set_mesh(UnityEngine.Mesh value)
  TMPro.TMP_Text get_textComponent()
  TMPro.TMP_SubMeshUI AddSubTextObject(TMPro.TextMeshProUGUI textComponent, TMPro.MaterialReference materialReference)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void OnTransformParentChanged()
  UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial)
  System.Single GetPaddingForMaterial()
  System.Single GetPaddingForMaterial(UnityEngine.Material mat)
  System.Void UpdateMeshPadding(System.Boolean isExtraPadding, System.Boolean isUsingBold)
  System.Void SetAllDirty()
  System.Void SetVerticesDirty()
  System.Void SetLayoutDirty()
  System.Void SetMaterialDirty()
  System.Void SetPivotDirty()
  UnityEngine.Transform GetRootCanvasTransform()
  System.Void Cull(UnityEngine.Rect clipRect, System.Boolean validRect)
  System.Void UpdateGeometry()
  System.Void Rebuild(UnityEngine.UI.CanvasUpdate update)
  System.Void RefreshMaterial()
  System.Void UpdateMaterial()
  System.Void RecalculateClipping()
  UnityEngine.Material GetMaterial()
  UnityEngine.Material GetMaterial(UnityEngine.Material mat)
  UnityEngine.Material CreateMaterialInstance(UnityEngine.Material source)
  UnityEngine.Material GetSharedMaterial()
  System.Void SetSharedMaterial(UnityEngine.Material mat)
  System.Void .ctor()
END_CLASS

CLASS: TMPro.ITextElement
TYPE:  interface
TOKEN: 0x200008A
FIELDS:
METHODS:
  UnityEngine.Material get_sharedMaterial()
  System.Void Rebuild(UnityEngine.UI.CanvasUpdate update)
  System.Int32 GetInstanceID()
END_CLASS

CLASS: TMPro.TextAlignmentOptions
TYPE:  struct
TOKEN: 0x200008B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TextAlignmentOptions      TopLeft  // 0x0
  public    static  TMPro.TextAlignmentOptions      Top  // 0x0
  public    static  TMPro.TextAlignmentOptions      TopRight  // 0x0
  public    static  TMPro.TextAlignmentOptions      TopJustified  // 0x0
  public    static  TMPro.TextAlignmentOptions      TopFlush  // 0x0
  public    static  TMPro.TextAlignmentOptions      TopGeoAligned  // 0x0
  public    static  TMPro.TextAlignmentOptions      Left  // 0x0
  public    static  TMPro.TextAlignmentOptions      Center  // 0x0
  public    static  TMPro.TextAlignmentOptions      Right  // 0x0
  public    static  TMPro.TextAlignmentOptions      Justified  // 0x0
  public    static  TMPro.TextAlignmentOptions      Flush  // 0x0
  public    static  TMPro.TextAlignmentOptions      CenterGeoAligned  // 0x0
  public    static  TMPro.TextAlignmentOptions      BottomLeft  // 0x0
  public    static  TMPro.TextAlignmentOptions      Bottom  // 0x0
  public    static  TMPro.TextAlignmentOptions      BottomRight  // 0x0
  public    static  TMPro.TextAlignmentOptions      BottomJustified  // 0x0
  public    static  TMPro.TextAlignmentOptions      BottomFlush  // 0x0
  public    static  TMPro.TextAlignmentOptions      BottomGeoAligned  // 0x0
  public    static  TMPro.TextAlignmentOptions      BaselineLeft  // 0x0
  public    static  TMPro.TextAlignmentOptions      Baseline  // 0x0
  public    static  TMPro.TextAlignmentOptions      BaselineRight  // 0x0
  public    static  TMPro.TextAlignmentOptions      BaselineJustified  // 0x0
  public    static  TMPro.TextAlignmentOptions      BaselineFlush  // 0x0
  public    static  TMPro.TextAlignmentOptions      BaselineGeoAligned  // 0x0
  public    static  TMPro.TextAlignmentOptions      MidlineLeft  // 0x0
  public    static  TMPro.TextAlignmentOptions      Midline  // 0x0
  public    static  TMPro.TextAlignmentOptions      MidlineRight  // 0x0
  public    static  TMPro.TextAlignmentOptions      MidlineJustified  // 0x0
  public    static  TMPro.TextAlignmentOptions      MidlineFlush  // 0x0
  public    static  TMPro.TextAlignmentOptions      MidlineGeoAligned  // 0x0
  public    static  TMPro.TextAlignmentOptions      CaplineLeft  // 0x0
  public    static  TMPro.TextAlignmentOptions      Capline  // 0x0
  public    static  TMPro.TextAlignmentOptions      CaplineRight  // 0x0
  public    static  TMPro.TextAlignmentOptions      CaplineJustified  // 0x0
  public    static  TMPro.TextAlignmentOptions      CaplineFlush  // 0x0
  public    static  TMPro.TextAlignmentOptions      CaplineGeoAligned  // 0x0
  public    static  TMPro.TextAlignmentOptions      Converted  // 0x0
METHODS:
END_CLASS

CLASS: TMPro.HorizontalAlignmentOptions
TYPE:  struct
TOKEN: 0x200008C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.HorizontalAlignmentOptionsLeft  // 0x0
  public    static  TMPro.HorizontalAlignmentOptionsCenter  // 0x0
  public    static  TMPro.HorizontalAlignmentOptionsRight  // 0x0
  public    static  TMPro.HorizontalAlignmentOptionsJustified  // 0x0
  public    static  TMPro.HorizontalAlignmentOptionsFlush  // 0x0
  public    static  TMPro.HorizontalAlignmentOptionsGeometry  // 0x0
METHODS:
END_CLASS

CLASS: TMPro.VerticalAlignmentOptions
TYPE:  struct
TOKEN: 0x200008D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.VerticalAlignmentOptions  Top  // 0x0
  public    static  TMPro.VerticalAlignmentOptions  Middle  // 0x0
  public    static  TMPro.VerticalAlignmentOptions  Bottom  // 0x0
  public    static  TMPro.VerticalAlignmentOptions  Baseline  // 0x0
  public    static  TMPro.VerticalAlignmentOptions  Geometry  // 0x0
  public    static  TMPro.VerticalAlignmentOptions  Capline  // 0x0
METHODS:
END_CLASS

CLASS: TMPro.TextRenderFlags
TYPE:  struct
TOKEN: 0x200008E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TextRenderFlags           DontRender  // 0x0
  public    static  TMPro.TextRenderFlags           Render  // 0x0
METHODS:
END_CLASS

CLASS: TMPro.TMP_TextElementType
TYPE:  struct
TOKEN: 0x200008F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TMP_TextElementType       Character  // 0x0
  public    static  TMPro.TMP_TextElementType       Sprite  // 0x0
  public    static  TMPro.TMP_TextElementType       Image  // 0x0
METHODS:
END_CLASS

CLASS: TMPro.MaskingTypes
TYPE:  struct
TOKEN: 0x2000090
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.MaskingTypes              MaskOff  // 0x0
  public    static  TMPro.MaskingTypes              MaskHard  // 0x0
  public    static  TMPro.MaskingTypes              MaskSoft  // 0x0
METHODS:
END_CLASS

CLASS: TMPro.TextOverflowModes
TYPE:  struct
TOKEN: 0x2000091
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TextOverflowModes         Overflow  // 0x0
  public    static  TMPro.TextOverflowModes         Ellipsis  // 0x0
  public    static  TMPro.TextOverflowModes         Masking  // 0x0
  public    static  TMPro.TextOverflowModes         Truncate  // 0x0
  public    static  TMPro.TextOverflowModes         ScrollRect  // 0x0
  public    static  TMPro.TextOverflowModes         Page  // 0x0
  public    static  TMPro.TextOverflowModes         Linked  // 0x0
METHODS:
END_CLASS

CLASS: TMPro.MaskingOffsetMode
TYPE:  struct
TOKEN: 0x2000092
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.MaskingOffsetMode         Percentage  // 0x0
  public    static  TMPro.MaskingOffsetMode         Pixel  // 0x0
METHODS:
END_CLASS

CLASS: TMPro.TextureMappingOptions
TYPE:  struct
TOKEN: 0x2000093
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.TextureMappingOptions     Character  // 0x0
  public    static  TMPro.TextureMappingOptions     Line  // 0x0
  public    static  TMPro.TextureMappingOptions     Paragraph  // 0x0
  public    static  TMPro.TextureMappingOptions     MatchAspect  // 0x0
METHODS:
END_CLASS

CLASS: TMPro.FontStyles
TYPE:  struct
TOKEN: 0x2000094
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.FontStyles                Normal  // 0x0
  public    static  TMPro.FontStyles                Bold  // 0x0
  public    static  TMPro.FontStyles                Italic  // 0x0
  public    static  TMPro.FontStyles                Underline  // 0x0
  public    static  TMPro.FontStyles                LowerCase  // 0x0
  public    static  TMPro.FontStyles                UpperCase  // 0x0
  public    static  TMPro.FontStyles                SmallCaps  // 0x0
  public    static  TMPro.FontStyles                Strikethrough  // 0x0
  public    static  TMPro.FontStyles                Superscript  // 0x0
  public    static  TMPro.FontStyles                Subscript  // 0x0
  public    static  TMPro.FontStyles                Highlight  // 0x0
  public    static  TMPro.FontStyles                Phonetic  // 0x0
METHODS:
END_CLASS

CLASS: TMPro.FontWeight
TYPE:  struct
TOKEN: 0x2000095
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.FontWeight                Thin  // 0x0
  public    static  TMPro.FontWeight                ExtraLight  // 0x0
  public    static  TMPro.FontWeight                Light  // 0x0
  public    static  TMPro.FontWeight                Regular  // 0x0
  public    static  TMPro.FontWeight                Medium  // 0x0
  public    static  TMPro.FontWeight                SemiBold  // 0x0
  public    static  TMPro.FontWeight                Bold  // 0x0
  public    static  TMPro.FontWeight                Heavy  // 0x0
  public    static  TMPro.FontWeight                Black  // 0x0
METHODS:
END_CLASS

CLASS: TMPro.PhoneticData
TYPE:  class
TOKEN: 0x2000096
FIELDS:
  public    static  TMPro.PhoneticData              Default  // 0x0
  public            System.String                   m_phonetic  // 0x10
  public            System.Boolean                  m_autoSize  // 0x18
  public            System.Boolean                  m_padding  // 0x19
  public            System.Boolean                  m_justify  // 0x1A
  public            System.Int32                    m_length  // 0x1C
  public            System.Int32                    m_startIndex  // 0x20
  public            System.Int32                    m_startCharCount  // 0x24
METHODS:
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: TMPro.TMP_Text
TYPE:  class
TOKEN: 0x2000097
EXTENDS: MaskableGraphic
FIELDS:
  protected         System.String                   m_textForPopulate  // 0xE8
  protected         System.String                   m_text  // 0xF0
  private           System.Boolean                  m_IsTextBackingStringDirty  // 0xF8
  protected         TMPro.ITextPreprocessor         m_TextPreprocessor  // 0x100
  protected         System.Boolean                  m_isRightToLeft  // 0x108
  protected         TMPro.TMP_FontAsset             m_serializedFontAsset  // 0x110
  protected         TMPro.TMP_FontAsset             m_currentFontAsset  // 0x118
  protected         System.Boolean                  m_isSDFShader  // 0x120
  protected         UnityEngine.Material            m_sharedMaterial  // 0x128
  protected         UnityEngine.Material            m_currentMaterial  // 0x130
  protected static  TMPro.MaterialReference[]       m_materialReferences  // 0x0
  protected static  System.Collections.Generic.Dictionary<System.Int32,System.Int32>m_materialReferenceIndexLookup  // 0x8
  protected static  TMPro.TMP_TextProcessingStack<TMPro.MaterialReference>m_materialReferenceStack  // 0x10
  protected         System.Int32                    m_currentMaterialIndex  // 0x138
  protected         UnityEngine.Material[]          m_fontSharedMaterials  // 0x140
  protected         UnityEngine.Material            m_fontMaterial  // 0x148
  protected         UnityEngine.Material[]          m_fontMaterials  // 0x150
  protected         System.Boolean                  m_isMaterialDirty  // 0x158
  protected         UnityEngine.Color32             m_fontColor32  // 0x15C
  protected         UnityEngine.Color               m_fontColor  // 0x160
  protected static  UnityEngine.Color32             s_colorWhite  // 0x68
  protected         UnityEngine.Color32             m_underlineColor  // 0x170
  protected         UnityEngine.Color32             m_strikethroughColor  // 0x174
  protected         System.Boolean                  m_enableVertexGradient  // 0x178
  protected         TMPro.ColorMode                 m_colorMode  // 0x17C
  protected         TMPro.VertexGradient            m_fontColorGradient  // 0x180
  protected         TMPro.TMP_ColorGradient         m_fontColorGradientPreset  // 0x1C0
  protected         TMPro.TMP_SpriteAsset           m_spriteAsset  // 0x1C8
  protected         System.Boolean                  m_tintAllSprites  // 0x1D0
  protected         System.Boolean                  m_tintSprite  // 0x1D1
  protected         UnityEngine.Color32             m_spriteColor  // 0x1D4
  protected         TMPro.TMP_StyleSheet            m_StyleSheet  // 0x1D8
  private           TMPro.TMP_Style                 m_TextStyle  // 0x1E0
  protected         System.Int32                    m_TextStyleHashCode  // 0x1E8
  protected         System.Boolean                  m_overrideHtmlColors  // 0x1EC
  protected         UnityEngine.Color32             m_faceColor  // 0x1F0
  protected         UnityEngine.Color32             m_outlineColor  // 0x1F4
  protected         System.Single                   m_outlineWidth  // 0x1F8
  protected         System.Single                   m_fontSize  // 0x1FC
  protected         System.Single                   m_currentFontSize  // 0x200
  protected         System.Single                   m_fontSizeBase  // 0x204
  protected         TMPro.TMP_TextProcessingStack<System.Single>m_sizeStack  // 0x208
  protected         System.Single                   m_imageWidth  // 0x228
  protected         System.Single                   m_imageHeight  // 0x22C
  protected         System.Single                   m_maxLineAscenderWithImage  // 0x230
  protected static  System.Single                   m_basePhoneticElementScale  // 0x0
  protected         TMPro.FontStyles                m_phoneticFontStyle  // 0x234
  protected         TMPro.FontWeight                m_phoneticFontWeight  // 0x238
  protected         TMPro.WordWrapState             m_phoneticWordWarpState  // 0x240
  protected         System.Int32                    m_phoneticStartCharIndex  // 0x5D8
  protected         System.Int32                    m_phoneticStartIndex  // 0x5DC
  protected         System.Int32                    m_phoneticEndIndex  // 0x5E0
  protected         System.Boolean                  m_isPhoneticOverLength  // 0x5E4
  protected         System.Collections.Generic.List<System.Single>m_phoneticSizeList  // 0x5E8
  protected         TMPro.TMP_TextProcessingQueue<TMPro.PhoneticData>m_phoneticDataQueue  // 0x5F0
  protected         TMPro.PhoneticData              m_currentPhoneticData  // 0x610
  protected         System.Int32                    m_phoneticCount  // 0x618
  protected         System.Single                   m_phoneticFontSize  // 0x61C
  protected         System.Boolean                  m_showPhonetic  // 0x620
  protected         System.Int32                    m_phoneticIndex  // 0x624
  protected         System.Boolean                  m_needParseActionId  // 0x628
  protected         TMPro.FontWeight                m_fontWeight  // 0x62C
  protected         TMPro.FontWeight                m_FontWeightInternal  // 0x630
  protected         TMPro.TMP_TextProcessingStack<TMPro.FontWeight>m_FontWeightStack  // 0x638
  protected         System.Boolean                  m_enableAutoSizing  // 0x658
  protected         System.Single                   m_maxFontSize  // 0x65C
  protected         System.Single                   m_minFontSize  // 0x660
  protected         System.Int32                    m_AutoSizeIterationCount  // 0x664
  protected         System.Int32                    m_AutoSizeMaxIterationCount  // 0x668
  protected         System.Boolean                  m_IsAutoSizePointSizeSet  // 0x66C
  protected         System.Single                   m_fontSizeMin  // 0x670
  protected         System.Single                   m_fontSizeMax  // 0x674
  protected         TMPro.FontStyles                m_fontStyle  // 0x678
  protected         TMPro.FontStyles                m_FontStyleInternal  // 0x67C
  protected         TMPro.TMP_FontStyleStack        m_fontStyleStack  // 0x680
  protected         System.Boolean                  m_isUsingBold  // 0x68A
  protected         TMPro.HorizontalAlignmentOptionsm_HorizontalAlignment  // 0x68C
  protected         TMPro.VerticalAlignmentOptions  m_VerticalAlignment  // 0x690
  protected         TMPro.TextAlignmentOptions      m_textAlignment  // 0x694
  protected         TMPro.HorizontalAlignmentOptionsm_lineJustification  // 0x698
  protected         TMPro.TMP_TextProcessingStack<TMPro.HorizontalAlignmentOptions>m_lineJustificationStack  // 0x6A0
  protected         UnityEngine.Vector3[]           m_textContainerLocalCorners  // 0x6C0
  protected         System.Single                   m_characterSpacing  // 0x6C8
  protected         System.Single                   m_cSpacing  // 0x6CC
  protected         System.Single                   m_monoSpacing  // 0x6D0
  protected         System.Single                   m_wordSpacing  // 0x6D4
  protected         System.Single                   m_lineSpacing  // 0x6D8
  protected         System.Single                   m_lineSpacingDelta  // 0x6DC
  protected         System.Single                   m_lineHeight  // 0x6E0
  protected         System.Boolean                  m_IsDrivenLineSpacing  // 0x6E4
  protected         System.Single                   m_lineSpacingMax  // 0x6E8
  protected         System.Single                   m_paragraphSpacing  // 0x6EC
  protected         System.Single                   m_charWidthMaxAdj  // 0x6F0
  protected         System.Single                   m_charWidthAdjDelta  // 0x6F4
  protected         System.Boolean                  m_enableWordWrapping  // 0x6F8
  protected         System.Boolean                  m_isCharacterWrappingEnabled  // 0x6F9
  protected         System.Boolean                  m_isNonBreakingSpace  // 0x6FA
  protected         System.Boolean                  m_isIgnoringAlignment  // 0x6FB
  protected         System.Single                   m_wordWrappingRatios  // 0x6FC
  protected         TMPro.TextOverflowModes         m_overflowMode  // 0x700
  protected         System.Int32                    m_firstOverflowCharacterIndex  // 0x704
  protected         TMPro.TMP_Text                  m_linkedTextComponent  // 0x708
  private           TMPro.TMP_Text                  parentLinkedComponent  // 0x710
  protected         System.Boolean                  m_isTextTruncated  // 0x718
  protected         System.Boolean                  m_enableKerning  // 0x719
  protected         System.Single                   m_GlyphHorizontalAdvanceAdjustment  // 0x71C
  protected         System.Boolean                  m_enableExtraPadding  // 0x720
  protected         System.Boolean                  checkPaddingRequired  // 0x721
  protected         System.Boolean                  m_isRichText  // 0x722
  protected         System.Boolean                  m_enableHyperlink  // 0x723
  protected         System.Single                   m_richTextColorBlend  // 0x724
  protected         System.Boolean                  m_parseCtrlCharacters  // 0x728
  protected         System.Boolean                  m_isOverlay  // 0x729
  protected         System.Boolean                  m_isOrthographic  // 0x72A
  protected         System.Boolean                  m_isCullingEnabled  // 0x72B
  protected         System.Boolean                  m_isMaskingEnabled  // 0x72C
  protected         System.Boolean                  isMaskUpdateRequired  // 0x72D
  protected         System.Boolean                  m_ignoreCulling  // 0x72E
  protected         TMPro.TextureMappingOptions     m_horizontalMapping  // 0x730
  protected         TMPro.TextureMappingOptions     m_verticalMapping  // 0x734
  protected         System.Single                   m_uvLineOffset  // 0x738
  protected         TMPro.TextRenderFlags           m_renderMode  // 0x73C
  protected         TMPro.VertexSortingOrder        m_geometrySortingOrder  // 0x740
  protected         System.Boolean                  m_IsTextObjectScaleStatic  // 0x744
  protected         System.Boolean                  m_VertexBufferAutoSizeReduction  // 0x745
  protected         System.Int32                    m_firstVisibleCharacter  // 0x748
  protected         System.Int32                    m_maxVisibleCharacters  // 0x74C
  protected         System.Int32                    m_maxVisibleWords  // 0x750
  protected         System.Int32                    m_maxVisibleLines  // 0x754
  protected         System.Boolean                  m_useMaxVisibleDescender  // 0x758
  protected         System.Int32                    m_pageToDisplay  // 0x75C
  protected         System.Boolean                  m_isNewPage  // 0x760
  protected         UnityEngine.Vector4             m_margin  // 0x764
  protected         System.Single                   m_marginLeft  // 0x774
  protected         System.Single                   m_marginRight  // 0x778
  protected         System.Single                   m_marginWidth  // 0x77C
  protected         System.Single                   m_marginHeight  // 0x780
  protected         System.Single                   m_width  // 0x784
  protected         TMPro.TMP_TextInfo              m_textInfo  // 0x788
  protected         System.Boolean                  m_havePropertiesChanged  // 0x790
  protected         System.Boolean                  m_isUsingLegacyAnimationComponent  // 0x791
  protected         UnityEngine.Transform           m_transform  // 0x798
  protected         UnityEngine.RectTransform       m_rectTransform  // 0x7A0
  protected         UnityEngine.Vector2             m_PreviousRectTransformSize  // 0x7A8
  protected         UnityEngine.Vector2             m_PreviousPivotPosition  // 0x7B0
  private           System.Boolean                  <autoSizeTextContainer>k__BackingField  // 0x7B8
  protected         System.Boolean                  m_autoSizeTextContainer  // 0x7B9
  protected         UnityEngine.Mesh                m_mesh  // 0x7C0
  protected         System.Boolean                  m_isVolumetricText  // 0x7C8
  private   static  System.Func<System.Int32,System.String,TMPro.TMP_FontAsset>OnFontAssetRequest  // 0x70
  private   static  System.Func<System.Int32,System.String,TMPro.TMP_SpriteAsset>OnSpriteAssetRequest  // 0x78
  private           System.Action<TMPro.TMP_TextInfo>OnPreRenderText  // 0x7D0
  protected         TMPro.TMP_SpriteAnimator        m_spriteAnimator  // 0x7D8
  protected         System.Single                   m_flexibleHeight  // 0x7E0
  protected         System.Single                   m_flexibleWidth  // 0x7E4
  protected         System.Single                   m_minWidth  // 0x7E8
  protected         System.Single                   m_minHeight  // 0x7EC
  protected         System.Single                   m_maxWidth  // 0x7F0
  protected         System.Single                   m_maxHeight  // 0x7F4
  protected         UnityEngine.UI.LayoutElement    m_LayoutElement  // 0x7F8
  protected         System.Single                   m_preferredWidth  // 0x800
  protected         System.Single                   m_renderedWidth  // 0x804
  protected         System.Boolean                  m_isPreferredWidthDirty  // 0x808
  protected         System.Single                   m_preferredHeight  // 0x80C
  protected         System.Single                   m_renderedHeight  // 0x810
  protected         System.Boolean                  m_isPreferredHeightDirty  // 0x814
  protected         System.Boolean                  m_isCalculatingPreferredValues  // 0x815
  protected         System.Int32                    m_layoutPriority  // 0x818
  protected         System.Boolean                  m_isLayoutDirty  // 0x81C
  protected         System.Boolean                  m_isAwake  // 0x81D
  private           System.Boolean                  m_isWaitingOnResourceLoad  // 0x81E
  protected         System.Boolean                  m_isInit  // 0x81F
  private           TMPro.TMP_Text.TextInputSources m_inputSource  // 0x820
  protected         System.Single                   m_fontScaleMultiplier  // 0x824
  private   static  System.Char[]                   m_htmlTag  // 0x80
  protected static  TMPro.RichTextTagAttribute[]    m_xmlAttribute  // 0x88
  private   static  System.Single[]                 m_attributeParameterValues  // 0x90
  protected         System.Single                   tag_LineIndent  // 0x828
  protected         System.Single                   tag_Indent  // 0x82C
  protected         TMPro.TMP_TextProcessingStack<System.Single>m_indentStack  // 0x830
  protected         System.Boolean                  tag_NoParsing  // 0x850
  protected         System.Boolean                  m_isParsingText  // 0x851
  protected         UnityEngine.Matrix4x4           m_FXMatrix  // 0x854
  protected         System.Boolean                  m_isFXMatrixSet  // 0x894
  protected         TMPro.TMP_Text.UnicodeChar[]    m_TextProcessingArray  // 0x898
  private           System.Int32                    m_InternalTextProcessingArraySize  // 0x8A0
  private           TMPro.TMP_CharacterInfo[]       m_internalCharacterInfo  // 0x8A8
  protected         System.Int32                    m_totalCharacterCount  // 0x8B0
  protected static  TMPro.WordWrapState             m_SavedWordWrapState  // 0x98
  protected static  TMPro.WordWrapState             m_SavedLineState  // 0x430
  protected static  TMPro.WordWrapState             m_SavedEllipsisState  // 0x7C8
  protected static  TMPro.WordWrapState             m_SavedLastValidState  // 0xB60
  protected static  TMPro.WordWrapState             m_SavedSoftLineBreakState  // 0xEF8
  protected static  TMPro.TMP_TextProcessingStack<TMPro.WordWrapState>m_EllipsisInsertionCandidateStack  // 0x1290
  protected         System.Int32                    m_characterCount  // 0x8B4
  protected         System.Int32                    m_firstCharacterOfLine  // 0x8B8
  protected         System.Int32                    m_firstVisibleCharacterOfLine  // 0x8BC
  protected         System.Int32                    m_lastCharacterOfLine  // 0x8C0
  protected         System.Int32                    m_lastVisibleCharacterOfLine  // 0x8C4
  protected         System.Int32                    m_lineNumber  // 0x8C8
  protected         System.Int32                    m_lineVisibleCharacterCount  // 0x8CC
  protected         System.Int32                    m_pageNumber  // 0x8D0
  protected         System.Single                   m_PageAscender  // 0x8D4
  protected         System.Single                   m_maxTextAscender  // 0x8D8
  protected         System.Single                   m_maxCapHeight  // 0x8DC
  protected         System.Single                   m_ElementAscender  // 0x8E0
  protected         System.Single                   m_ElementDescender  // 0x8E4
  protected         System.Single                   m_maxLineAscender  // 0x8E8
  protected         System.Single                   m_maxLineDescender  // 0x8EC
  protected         System.Single                   m_startOfLineAscender  // 0x8F0
  protected         System.Single                   m_startOfLineDescender  // 0x8F4
  protected         System.Single                   m_lineOffset  // 0x8F8
  protected         TMPro.Extents                   m_meshExtents  // 0x8FC
  protected         UnityEngine.Color32             m_htmlColor  // 0x90C
  protected         TMPro.TMP_TextProcessingStack<UnityEngine.Color32>m_colorStack  // 0x910
  protected         TMPro.TMP_TextProcessingStack<UnityEngine.Color32>m_underlineColorStack  // 0x930
  protected         TMPro.TMP_TextProcessingStack<UnityEngine.Color32>m_strikethroughColorStack  // 0x950
  protected         TMPro.TMP_TextProcessingStack<TMPro.HighlightState>m_HighlightStateStack  // 0x970
  protected         TMPro.TMP_TextProcessingStack<TMPro.TMP_ColorGradient>m_colorGradientStack  // 0x9A0
  protected         TMPro.TMP_ColorGradient         m_colorGradientPreset  // 0x9C8
  protected         System.Boolean                  m_colorGradientPresetIsTinted  // 0x9D0
  protected         System.Single                   m_tabSpacing  // 0x9D4
  protected         System.Single                   m_spacing  // 0x9D8
  protected         TMPro.TMP_TextProcessingStack<System.Int32>[]m_TextStyleStacks  // 0x9E0
  protected         TMPro.TMP_TextProcessingStack<System.Int32>m_ItalicAngleStack  // 0x9E8
  protected         TMPro.TMP_TextProcessingStack<System.Int32>m_actionStack  // 0xA08
  protected         TMPro.TMP_TextProcessingStack<System.Single>m_baselineOffsetStack  // 0xA28
  protected         System.Int32                    m_TextStyleStackDepth  // 0xA48
  protected         System.Int32                    m_ItalicAngle  // 0xA4C
  protected         System.Single                   m_padding  // 0xA50
  protected         System.Single                   m_baselineOffset  // 0xA54
  protected         System.Single                   m_xAdvance  // 0xA58
  protected         System.Single                   m_lastCharAdvance  // 0xA5C
  protected         System.Boolean                  m_lastIsUpVowels  // 0xA60
  protected         System.Boolean                  m_lastIsAscender  // 0xA61
  protected         System.Boolean                  m_lastIsDescender  // 0xA62
  protected         System.Single                   m_lastHeight  // 0xA64
  protected static  System.Boolean                  s_forceLeftAlign  // 0x1648
  protected         TMPro.TMP_TextElementType       m_textElementType  // 0xA68
  protected         TMPro.TMP_TextElement           m_cached_TextElement  // 0xA70
  protected         TMPro.TMP_Text.SpecialCharacter m_Ellipsis  // 0xA78
  protected         TMPro.TMP_Text.SpecialCharacter m_Underline  // 0xA98
  protected         TMPro.TMP_SpriteAsset           m_defaultSpriteAsset  // 0xAB8
  protected         TMPro.TMP_SpriteAsset           m_currentSpriteAsset  // 0xAC0
  protected         System.Int32                    m_spriteCount  // 0xAC8
  protected         System.Int32                    m_spriteIndex  // 0xACC
  protected         System.Int32                    m_spriteAnimationID  // 0xAD0
  private   static  Unity.Profiling.ProfilerMarker  k_ParseTextMarker  // 0x1650
  private   static  Unity.Profiling.ProfilerMarker  k_InsertNewLineMarker  // 0x1658
  protected         System.Boolean                  m_ignoreActiveState  // 0xAD4
  private           TMPro.TMP_Text.TextBackingContainerm_TextBackingArray  // 0xAD8
  private   readonly System.Decimal[]                k_Power  // 0xAE8
  protected static  UnityEngine.Vector2             k_LargePositiveVector2  // 0x1660
  protected static  UnityEngine.Vector2             k_LargeNegativeVector2  // 0x1668
  protected static  System.Single                   k_LargePositiveFloat  // 0x1670
  protected static  System.Single                   k_LargeNegativeFloat  // 0x1674
  protected static  System.Int32                    k_LargePositiveInt  // 0x1678
  protected static  System.Int32                    k_LargeNegativeInt  // 0x167C
  private           System.Boolean                  m_dynamicFontAssetUsed  // 0xAF0
METHODS:
  System.String get_text()
  System.Void set_text(System.String value)
  System.String get_textForPopulate()
  System.Void ResetTextForPopulate()
  System.Void RefreshPopulateText()
  TMPro.ITextPreprocessor get_textPreprocessor()
  System.Void set_textPreprocessor(TMPro.ITextPreprocessor value)
  System.Boolean get_isRightToLeftText()
  System.Void set_isRightToLeftText(System.Boolean value)
  TMPro.TMP_FontAsset get_font()
  System.Void set_font(TMPro.TMP_FontAsset value)
  UnityEngine.Material LoadMaterial(System.String path)
  TMPro.TMP_FontAsset get_m_fontAsset()
  System.Void set_m_fontAsset(TMPro.TMP_FontAsset value)
  UnityEngine.Material get_fontSharedMaterial()
  System.Void set_fontSharedMaterial(UnityEngine.Material value)
  UnityEngine.Material[] get_fontSharedMaterials()
  System.Void set_fontSharedMaterials(UnityEngine.Material[] value)
  UnityEngine.Material get_fontMaterial()
  System.Void set_fontMaterial(UnityEngine.Material value)
  UnityEngine.Material[] get_fontMaterials()
  System.Void set_fontMaterials(UnityEngine.Material[] value)
  UnityEngine.Color get_color()
  System.Void set_color(UnityEngine.Color value)
  System.Single get_alpha()
  System.Void set_alpha(System.Single value)
  System.Boolean get_enableVertexGradient()
  System.Void set_enableVertexGradient(System.Boolean value)
  TMPro.VertexGradient get_colorGradient()
  System.Void set_colorGradient(TMPro.VertexGradient value)
  TMPro.TMP_ColorGradient get_colorGradientPreset()
  System.Void set_colorGradientPreset(TMPro.TMP_ColorGradient value)
  TMPro.TMP_SpriteAsset get_spriteAsset()
  System.Void set_spriteAsset(TMPro.TMP_SpriteAsset value)
  System.Boolean get_tintAllSprites()
  System.Void set_tintAllSprites(System.Boolean value)
  TMPro.TMP_StyleSheet get_styleSheet()
  System.Void set_styleSheet(TMPro.TMP_StyleSheet value)
  TMPro.TMP_Style get_textStyle()
  System.Void set_textStyle(TMPro.TMP_Style value)
  System.Boolean get_overrideColorTags()
  System.Void set_overrideColorTags(System.Boolean value)
  UnityEngine.Color32 get_faceColor()
  System.Void set_faceColor(UnityEngine.Color32 value)
  UnityEngine.Color32 get_outlineColor()
  System.Void set_outlineColor(UnityEngine.Color32 value)
  System.Single get_outlineWidth()
  System.Void set_outlineWidth(System.Single value)
  System.Single get_fontSize()
  System.Void set_fontSize(System.Single value)
  System.Single get_PhoneticElementScale()
  System.String get_m_currentPhonetic()
  System.Boolean get_m_currentEnablePhoneticAutoPadding()
  System.Boolean get_m_currentEnablePhoneticAutoSize()
  System.Boolean get_m_currentEnablePhoneticAutoJustify()
  TMPro.FontWeight get_fontWeight()
  System.Void set_fontWeight(TMPro.FontWeight value)
  System.Single get_pixelsPerUnit()
  System.Boolean get_enableAutoSizing()
  System.Void set_enableAutoSizing(System.Boolean value)
  System.Single get_fontSizeMin()
  System.Void set_fontSizeMin(System.Single value)
  System.Single get_fontSizeMax()
  System.Void set_fontSizeMax(System.Single value)
  TMPro.FontStyles get_fontStyle()
  System.Void set_fontStyle(TMPro.FontStyles value)
  System.Boolean get_isUsingBold()
  TMPro.HorizontalAlignmentOptions get_horizontalAlignment()
  System.Void set_horizontalAlignment(TMPro.HorizontalAlignmentOptions value)
  TMPro.VerticalAlignmentOptions get_verticalAlignment()
  System.Void set_verticalAlignment(TMPro.VerticalAlignmentOptions value)
  TMPro.TextAlignmentOptions get_alignment()
  System.Void set_alignment(TMPro.TextAlignmentOptions value)
  System.Single get_characterSpacing()
  System.Void set_characterSpacing(System.Single value)
  System.Single get_wordSpacing()
  System.Void set_wordSpacing(System.Single value)
  System.Single get_lineSpacing()
  System.Void set_lineSpacing(System.Single value)
  System.Single get_lineSpacingAdjustment()
  System.Void set_lineSpacingAdjustment(System.Single value)
  System.Single get_paragraphSpacing()
  System.Void set_paragraphSpacing(System.Single value)
  System.Single get_characterWidthAdjustment()
  System.Void set_characterWidthAdjustment(System.Single value)
  System.Boolean get_enableWordWrapping()
  System.Void set_enableWordWrapping(System.Boolean value)
  System.Single get_wordWrappingRatios()
  System.Void set_wordWrappingRatios(System.Single value)
  TMPro.TextOverflowModes get_overflowMode()
  System.Void set_overflowMode(TMPro.TextOverflowModes value)
  System.Boolean get_isTextOverflowing()
  System.Int32 get_firstOverflowCharacterIndex()
  TMPro.TMP_Text get_linkedTextComponent()
  System.Void set_linkedTextComponent(TMPro.TMP_Text value)
  System.Boolean get_isTextTruncated()
  System.Boolean get_enableKerning()
  System.Void set_enableKerning(System.Boolean value)
  System.Boolean get_extraPadding()
  System.Void set_extraPadding(System.Boolean value)
  System.Boolean get_richText()
  System.Void set_richText(System.Boolean value)
  System.Boolean get_enableHyperlink()
  System.Void set_enableHyperlink(System.Boolean value)
  System.Single get_richTextColorBlend()
  System.Void set_richTextColorBlend(System.Single value)
  System.Boolean get_parseCtrlCharacters()
  System.Void set_parseCtrlCharacters(System.Boolean value)
  System.Boolean get_isOverlay()
  System.Void set_isOverlay(System.Boolean value)
  System.Boolean get_isOrthographic()
  System.Void set_isOrthographic(System.Boolean value)
  System.Boolean get_enableCulling()
  System.Void set_enableCulling(System.Boolean value)
  System.Boolean get_ignoreVisibility()
  System.Void set_ignoreVisibility(System.Boolean value)
  TMPro.TextureMappingOptions get_horizontalMapping()
  System.Void set_horizontalMapping(TMPro.TextureMappingOptions value)
  TMPro.TextureMappingOptions get_verticalMapping()
  System.Void set_verticalMapping(TMPro.TextureMappingOptions value)
  System.Single get_mappingUvLineOffset()
  System.Void set_mappingUvLineOffset(System.Single value)
  TMPro.TextRenderFlags get_renderMode()
  System.Void set_renderMode(TMPro.TextRenderFlags value)
  TMPro.VertexSortingOrder get_geometrySortingOrder()
  System.Void set_geometrySortingOrder(TMPro.VertexSortingOrder value)
  System.Boolean get_isTextObjectScaleStatic()
  System.Void set_isTextObjectScaleStatic(System.Boolean value)
  System.Boolean get_vertexBufferAutoSizeReduction()
  System.Void set_vertexBufferAutoSizeReduction(System.Boolean value)
  System.Int32 get_firstVisibleCharacter()
  System.Void set_firstVisibleCharacter(System.Int32 value)
  System.Int32 get_maxVisibleCharacters()
  System.Void set_maxVisibleCharacters(System.Int32 value)
  System.Int32 get_maxVisibleWords()
  System.Void set_maxVisibleWords(System.Int32 value)
  System.Int32 get_maxVisibleLines()
  System.Void set_maxVisibleLines(System.Int32 value)
  System.Boolean get_useMaxVisibleDescender()
  System.Void set_useMaxVisibleDescender(System.Boolean value)
  System.Int32 get_pageToDisplay()
  System.Void set_pageToDisplay(System.Int32 value)
  UnityEngine.Vector4 get_margin()
  System.Void set_margin(UnityEngine.Vector4 value)
  TMPro.TMP_TextInfo get_textInfo()
  System.Boolean get_havePropertiesChanged()
  System.Void set_havePropertiesChanged(System.Boolean value)
  System.Boolean get_isUsingLegacyAnimationComponent()
  System.Void set_isUsingLegacyAnimationComponent(System.Boolean value)
  UnityEngine.Transform get_transform()
  UnityEngine.RectTransform get_rectTransform()
  System.Boolean get_autoSizeTextContainer()
  System.Void set_autoSizeTextContainer(System.Boolean value)
  UnityEngine.Mesh get_mesh()
  System.Boolean get_isVolumetricText()
  System.Void set_isVolumetricText(System.Boolean value)
  UnityEngine.Bounds get_bounds()
  UnityEngine.Bounds get_textBounds()
  System.Void add_OnFontAssetRequest(System.Func<System.Int32,System.String,TMPro.TMP_FontAsset> value)
  System.Void remove_OnFontAssetRequest(System.Func<System.Int32,System.String,TMPro.TMP_FontAsset> value)
  System.Void add_OnSpriteAssetRequest(System.Func<System.Int32,System.String,TMPro.TMP_SpriteAsset> value)
  System.Void remove_OnSpriteAssetRequest(System.Func<System.Int32,System.String,TMPro.TMP_SpriteAsset> value)
  System.Void add_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value)
  System.Void remove_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value)
  TMPro.TMP_SpriteAnimator get_spriteAnimator()
  System.Single get_flexibleHeight()
  System.Single get_flexibleWidth()
  System.Single get_minWidth()
  System.Single get_minHeight()
  System.Single get_maxWidth()
  System.Single get_maxHeight()
  UnityEngine.UI.LayoutElement get_layoutElement()
  System.Single get_preferredWidth()
  System.Single get_preferredHeight()
  System.Single get_renderedWidth()
  System.Single get_renderedHeight()
  System.Int32 get_layoutPriority()
  System.Void Awake()
  System.Void InitDataFromPool()
  System.Void OnDestroy()
  System.Void LoadFontAsset()
  System.Void SetSharedMaterial(UnityEngine.Material mat)
  UnityEngine.Material GetMaterial(UnityEngine.Material mat)
  System.Void SetFontBaseMaterial(UnityEngine.Material mat)
  UnityEngine.Material[] GetSharedMaterials()
  System.Void SetSharedMaterials(UnityEngine.Material[] materials)
  UnityEngine.Material[] GetMaterials(UnityEngine.Material[] mats)
  UnityEngine.Material CreateMaterialInstance(UnityEngine.Material source)
  System.Void SetVertexColorGradient(TMPro.TMP_ColorGradient gradient)
  System.Void SetTextSortingOrder(TMPro.VertexSortingOrder order)
  System.Void SetTextSortingOrder(System.Int32[] order)
  System.Void SetFaceColor(UnityEngine.Color32 color)
  System.Void SetOutlineColor(UnityEngine.Color32 color)
  System.Void SetOutlineThickness(System.Single thickness)
  System.Void SetShaderDepth()
  System.Void SetCulling()
  System.Void UpdateCulling()
  System.Single GetPaddingForMaterial()
  System.Single GetPaddingForMaterial(UnityEngine.Material mat)
  UnityEngine.Vector3[] GetTextContainerLocalCorners()
  System.Void ForceMeshUpdate(System.Boolean ignoreActiveState, System.Boolean forceTextReparsing)
  System.Void UpdateGeometry(UnityEngine.Mesh mesh, System.Int32 index)
  System.Void UpdateVertexData(TMPro.TMP_VertexDataUpdateFlags flags)
  System.Void UpdateVertexData()
  System.Void SetVertices(UnityEngine.Vector3[] vertices)
  System.Void UpdateMeshPadding()
  System.Void CrossFadeColor(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha)
  System.Void CrossFadeAlpha(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale)
  System.Void InternalCrossFadeColor(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha)
  System.Void InternalCrossFadeAlpha(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale)
  System.Void ParseInputText()
  System.Void PopulateTextBackingArray(System.String sourceText)
  System.Void PopulateTextBackingArray(System.String sourceText, System.Int32 start, System.Int32 length)
  System.Void PopulateTextBackingArray(System.Text.StringBuilder sourceText, System.Int32 start, System.Int32 length)
  System.Void PopulateTextBackingArray(System.Char[] sourceText, System.Int32 start, System.Int32 length)
  System.Void PopulateTextProcessingArray()
  System.Void SetTextInternal(System.String sourceText)
  System.Void SetText(System.String sourceText, System.Boolean syncTextInputBox)
  System.Void SetText(System.String sourceText, System.Single arg0)
  System.Void SetText(System.String sourceText, System.Single arg0, System.Single arg1)
  System.Void SetText(System.String sourceText, System.Single arg0, System.Single arg1, System.Single arg2)
  System.Void SetText(System.String sourceText, System.Single arg0, System.Single arg1, System.Single arg2, System.Single arg3)
  System.Void SetText(System.String sourceText, System.Single arg0, System.Single arg1, System.Single arg2, System.Single arg3, System.Single arg4)
  System.Void SetText(System.String sourceText, System.Single arg0, System.Single arg1, System.Single arg2, System.Single arg3, System.Single arg4, System.Single arg5)
  System.Void SetText(System.String sourceText, System.Single arg0, System.Single arg1, System.Single arg2, System.Single arg3, System.Single arg4, System.Single arg5, System.Single arg6)
  System.Void SetText(System.String sourceText, System.Single arg0, System.Single arg1, System.Single arg2, System.Single arg3, System.Single arg4, System.Single arg5, System.Single arg6, System.Single arg7)
  System.Void SetText(System.Text.StringBuilder sourceText)
  System.Void SetText(System.Text.StringBuilder sourceText, System.Int32 start, System.Int32 length)
  System.Void SetText(System.Char[] sourceText)
  System.Void SetText(System.Char[] sourceText, System.Int32 start, System.Int32 length)
  System.Void SetCharArray(System.Char[] sourceText)
  System.Void SetCharArray(System.Char[] sourceText, System.Int32 start, System.Int32 length)
  TMPro.TMP_Style GetStyle(System.Int32 hashCode)
  System.Boolean ReplaceOpeningStyleTag(TMPro.TMP_Text.TextBackingContainer& sourceText, System.Int32 srcIndex, System.Int32& srcOffset, TMPro.TMP_Text.UnicodeChar[]& charBuffer, System.Int32& writeIndex)
  System.Boolean ReplaceOpeningStyleTag(System.Int32[]& sourceText, System.Int32 srcIndex, System.Int32& srcOffset, TMPro.TMP_Text.UnicodeChar[]& charBuffer, System.Int32& writeIndex)
  System.Void ReplaceClosingStyleTag(TMPro.TMP_Text.TextBackingContainer& sourceText, System.Int32 srcIndex, TMPro.TMP_Text.UnicodeChar[]& charBuffer, System.Int32& writeIndex)
  System.Void ReplaceClosingStyleTag(System.Int32[]& sourceText, System.Int32 srcIndex, TMPro.TMP_Text.UnicodeChar[]& charBuffer, System.Int32& writeIndex)
  System.Boolean InsertOpeningStyleTag(TMPro.TMP_Style style, System.Int32 srcIndex, TMPro.TMP_Text.UnicodeChar[]& charBuffer, System.Int32& writeIndex)
  System.Void InsertClosingStyleTag(TMPro.TMP_Text.UnicodeChar[]& charBuffer, System.Int32& writeIndex)
  System.Int32 GetMarkupTagHashCode(System.Int32[] tagDefinition, System.Int32 readIndex)
  System.Int32 GetMarkupTagHashCode(TMPro.TMP_Text.TextBackingContainer tagDefinition, System.Int32 readIndex)
  System.Int32 GetStyleHashCode(System.Int32[]& text, System.Int32 index, System.Int32& closeIndex)
  System.Int32 GetStyleHashCode(TMPro.TMP_Text.TextBackingContainer& text, System.Int32 index, System.Int32& closeIndex)
  System.Void ResizeInternalArray(T[]& array)
  System.Void ResizeInternalArray(T[]& array, System.Int32 size)
  System.Void AddFloatToInternalTextBackingArray(System.Single value, System.Int32 padding, System.Int32 precision, System.Int32& writeIndex)
  System.Void AddIntegerToInternalTextBackingArray(System.Double number, System.Int32 padding, System.Int32& writeIndex)
  System.String InternalTextBackingArrayToString()
  System.Int32 SetArraySizes(TMPro.TMP_Text.UnicodeChar[] unicodeChars)
  UnityEngine.Vector2 GetPreferredValues()
  UnityEngine.Vector2 GetPreferredValues(System.Single width, System.Single height)
  UnityEngine.Vector2 GetPreferredValues(System.String text)
  UnityEngine.Vector2 GetPreferredValues(System.String text, System.Single width, System.Single height)
  System.Single GetPreferredWidth()
  System.Single GetPreferredWidth(UnityEngine.Vector2 margin)
  System.Single GetPreferredHeight()
  System.Single GetPreferredHeight(UnityEngine.Vector2 margin)
  UnityEngine.Vector2 GetRenderedValues()
  UnityEngine.Vector2 GetRenderedValues(System.Boolean onlyVisibleCharacters)
  System.Single GetRenderedWidth()
  System.Single GetRenderedWidth(System.Boolean onlyVisibleCharacters)
  System.Single GetRenderedHeight()
  System.Single GetRenderedHeight(System.Boolean onlyVisibleCharacters)
  UnityEngine.Vector2 CalculatePreferredValues(System.Single& fontSize, UnityEngine.Vector2 marginSize, System.Boolean isTextAutoSizingEnabled, System.Boolean isWordWrappingEnabled)
  UnityEngine.Bounds GetCompoundBounds()
  UnityEngine.Rect GetCanvasSpaceClippingRect()
  UnityEngine.Bounds GetTextBounds()
  UnityEngine.Bounds GetTextBounds(System.Boolean onlyVisibleCharacters)
  System.Void AdjustLineOffset(System.Int32 startIndex, System.Int32 endIndex, System.Single offset)
  System.Void ResizeLineExtents(System.Int32 size)
  TMPro.TMP_TextInfo GetTextInfo(System.String text)
  System.Void ComputeMarginSize()
  System.Void InsertNewLine(System.Int32 i, System.Single baseScale, System.Single currentElementScale, System.Single currentEmScale, System.Single glyphAdjustment, System.Single boldSpacingAdjustment, System.Single characterSpacingAdjustment, System.Single width, System.Single lineGap, System.Boolean& isMaxVisibleDescenderSet, System.Single& maxVisibleDescender)
  System.Void SaveWordWrappingState(TMPro.WordWrapState& state, System.Int32 index, System.Int32 count)
  System.Int32 RestoreWordWrappingState(TMPro.WordWrapState& state)
  System.Void SaveGlyphVertexInfo(System.Single padding, System.Single style_padding, UnityEngine.Color32 vertexColor)
  System.Void SaveSpriteVertexInfo(UnityEngine.Color32 vertexColor)
  System.Void FillCharacterVertexBuffers(System.Int32 i, System.Int32 index_X4)
  System.Void FillCharacterVertexBuffers(System.Int32 i, System.Int32 index_X4, System.Boolean isVolumetric)
  System.Void FillSpriteVertexBuffers(System.Int32 i, System.Int32 index_X4)
  System.Void DrawUnderlineMesh(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Int32& index, System.Single startScale, System.Single endScale, System.Single maxScale, System.Single sdfScale, UnityEngine.Color32 underlineColor)
  System.Single PhoneticWidth(System.String str, System.Int32 materialIndex, System.Single padding, System.Single style_padding)
  System.Boolean DrawPhoneticMesh(UnityEngine.Rect rect, System.String str, System.Int32 materialIndex, System.Single padding, System.Single style_padding, System.Boolean autoSize, System.Int32 phoneticIndex, System.Boolean justify, System.Single lossyScale)
  System.Void DrawTextHighlight(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Int32& index, UnityEngine.Color32 highlightColor)
  System.Void LoadDefaultSettings()
  System.Void GetSpecialCharacters(TMPro.TMP_FontAsset fontAsset)
  System.Void GetEllipsisSpecialCharacter(TMPro.TMP_FontAsset fontAsset)
  System.Void GetUnderlineSpecialCharacter(TMPro.TMP_FontAsset fontAsset)
  System.Void ReplaceTagWithCharacter(System.Int32[] chars, System.Int32 insertionIndex, System.Int32 tagLength, System.Char c)
  TMPro.TMP_FontAsset GetFontAssetForWeight(System.Int32 fontWeight)
  TMPro.TMP_TextElement GetTextElement(System.UInt32 unicode, TMPro.TMP_FontAsset fontAsset, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, System.Boolean& isUsingAlternativeTypeface)
  System.Void TryRemoveDynamicFallbackFontAssetTextRef()
  System.Void SetActiveSubMeshes(System.Boolean state)
  System.Void DestroySubMeshObjects()
  System.Void ClearMesh()
  System.Void ClearMesh(System.Boolean uploadGeometry)
  System.String GetParsedText()
  System.Boolean IsSelfOrLinkedAncestor(TMPro.TMP_Text targetTextComponent)
  System.Void ReleaseLinkedTextComponent(TMPro.TMP_Text targetTextComponent)
  UnityEngine.Vector2 PackUV(System.Single x, System.Single y, System.Single scale)
  System.Single PackUV(System.Single x, System.Single y)
  System.Void InternalUpdate()
  System.Int32 HexToInt(System.Char hex)
  System.Int32 GetUTF16(System.String text, System.Int32 i)
  System.Int32 GetUTF16(System.Int32[] text, System.Int32 i)
  System.Int32 GetUTF16(System.UInt32[] text, System.Int32 i)
  System.Int32 GetUTF16(System.Text.StringBuilder text, System.Int32 i)
  System.Int32 GetUTF16(TMPro.TMP_Text.TextBackingContainer text, System.Int32 i)
  System.Int32 GetUTF32(System.String text, System.Int32 i)
  System.Int32 GetUTF32(System.Int32[] text, System.Int32 i)
  System.Int32 GetUTF32(System.UInt32[] text, System.Int32 i)
  System.Int32 GetUTF32(System.Text.StringBuilder text, System.Int32 i)
  System.Int32 GetUTF32(TMPro.TMP_Text.TextBackingContainer text, System.Int32 i)
  UnityEngine.Color32 HexCharsToColor(System.Char[] hexChars, System.Int32 tagCount)
  UnityEngine.Color32 HexCharsToColor(System.Char[] hexChars, System.Int32 startIndex, System.Int32 length)
  System.Int32 GetAttributeParameters(System.Char[] chars, System.Int32 startIndex, System.Int32 length, System.Single[]& parameters)
  System.Single ConvertToFloat(System.Char[] chars, System.Int32 startIndex, System.Int32 length)
  System.Single ConvertToFloat(System.Char[] chars, System.Int32 startIndex, System.Int32 length, System.Int32& lastIndex)
  System.Boolean CheckIfEndPhonetic(TMPro.TMP_Text.UnicodeChar[] chars, System.Int32 startIndex)
  System.Boolean ValidateHtmlTag(TMPro.TMP_Text.UnicodeChar[] chars, System.Int32 startIndex, System.Int32& endIndex)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: TMPro.TextElementType
TYPE:  struct
TOKEN: 0x200009E
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  TMPro.TextElementType           Character  // 0x0
  public    static  TMPro.TextElementType           Sprite  // 0x0
METHODS:
END_CLASS

CLASS: TMPro.TMP_TextElement
TYPE:  class
TOKEN: 0x200009F
FIELDS:
  protected         TMPro.TextElementType           m_ElementType  // 0x10
  private           System.UInt32                   m_Unicode  // 0x14
  private           TMPro.TMP_Asset                 m_TextAsset  // 0x18
  private           UnityEngine.TextCore.Glyph      m_Glyph  // 0x20
  private           System.UInt32                   m_GlyphIndex  // 0x28
  private           System.Single                   m_Scale  // 0x2C
METHODS:
  TMPro.TextElementType get_elementType()
  System.UInt32 get_unicode()
  System.Void set_unicode(System.UInt32 value)
  TMPro.TMP_Asset get_textAsset()
  System.Void set_textAsset(TMPro.TMP_Asset value)
  UnityEngine.TextCore.Glyph get_glyph()
  System.Void set_glyph(UnityEngine.TextCore.Glyph value)
  System.UInt32 get_glyphIndex()
  System.Void set_glyphIndex(System.UInt32 value)
  System.Single get_scale()
  System.Void set_scale(System.Single value)
  System.Void .ctor()
END_CLASS

CLASS: TMPro.TMP_TextElement_Legacy
TYPE:  class
TOKEN: 0x20000A0
FIELDS:
  public            System.Int32                    id  // 0x10
  public            System.Single                   x  // 0x14
  public            System.Single                   y  // 0x18
  public            System.Single                   width  // 0x1C
  public            System.Single                   height  // 0x20
  public            System.Single                   xOffset  // 0x24
  public            System.Single                   yOffset  // 0x28
  public            System.Single                   xAdvance  // 0x2C
  public            System.Single                   scale  // 0x30
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: TMPro.TMP_TextInfo
TYPE:  class
TOKEN: 0x20000A1
FIELDS:
  private   static  UnityEngine.Vector2             k_InfinityVectorPositive  // 0x0
  private   static  UnityEngine.Vector2             k_InfinityVectorNegative  // 0x8
  public            TMPro.TMP_Text                  textComponent  // 0x10
  public            System.Int32                    characterCount  // 0x18
  public            System.Int32                    spriteCount  // 0x1C
  public            System.Int32                    spaceCount  // 0x20
  public            System.Int32                    wordCount  // 0x24
  public            System.Int32                    linkCount  // 0x28
  public            System.Int32                    lineCount  // 0x2C
  public            System.Int32                    pageCount  // 0x30
  public            System.Int32                    materialCount  // 0x34
  public            System.Int32                    characterToSubstituteIndex  // 0x38
  public            TMPro.TMP_CharacterInfo[]       characterInfo  // 0x40
  public            TMPro.TMP_WordInfo[]            wordInfo  // 0x48
  public            TMPro.TMP_LinkInfo[]            linkInfo  // 0x50
  public            TMPro.TMP_LineInfo[]            lineInfo  // 0x58
  public            TMPro.TMP_PageInfo[]            pageInfo  // 0x60
  public            TMPro.TMP_MeshInfo[]            meshInfo  // 0x68
  private           TMPro.TMP_MeshInfo[]            m_CachedMeshInfo  // 0x70
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Int32 characterCount)
  System.Void .ctor(TMPro.TMP_Text textComponent)
  System.Void Clear()
  System.Void ClearAllData()
  System.Void ClearMeshInfo(System.Boolean updateMesh)
  System.Void ClearAllMeshInfo()
  System.Void ResetVertexLayout(System.Boolean isVolumetric)
  System.Void ClearUnusedVertices(TMPro.MaterialReference[] materials)
  System.Void ClearLineInfo()
  System.Void ClearPageInfo()
  TMPro.TMP_MeshInfo[] CopyMeshInfoVertexData()
  System.Void Resize(T[]& array, System.Int32 size)
  System.Void Resize(T[]& array, System.Int32 size, System.Boolean isBlockAllocated)
  System.Void Dispose()
  System.Void .cctor()
END_CLASS

CLASS: TMPro.TMP_TextParsingUtilities
TYPE:  class
TOKEN: 0x20000A2
FIELDS:
  private   static readonly TMPro.TMP_TextParsingUtilities  s_Instance  // 0x0
  private   static  System.String                   k_LookupStringL  // 0x0
  private   static  System.String                   k_LookupStringU  // 0x0
METHODS:
  System.Void .cctor()
  TMPro.TMP_TextParsingUtilities get_instance()
  System.Int32 GetHashCode(System.String s)
  System.Int32 GetHashCodeCaseSensitive(System.String s)
  System.Char ToLowerASCIIFast(System.Char c)
  System.Char ToUpperASCIIFast(System.Char c)
  System.UInt32 ToUpperASCIIFast(System.UInt32 c)
  System.UInt32 ToLowerASCIIFast(System.UInt32 c)
  System.Boolean IsHighSurrogate(System.UInt32 c)
  System.Boolean IsLowSurrogate(System.UInt32 c)
  System.UInt32 ConvertToUTF32(System.UInt32 highSurrogate, System.UInt32 lowSurrogate)
  System.Void .ctor()
END_CLASS

CLASS: TMPro.TMP_FontStyleStack
TYPE:  struct
TOKEN: 0x20000A3
FIELDS:
  public            System.Byte                     bold  // 0x10
  public            System.Byte                     italic  // 0x11
  public            System.Byte                     underline  // 0x12
  public            System.Byte                     strikethrough  // 0x13
  public            System.Byte                     highlight  // 0x14
  public            System.Byte                     superscript  // 0x15
  public            System.Byte                     subscript  // 0x16
  public            System.Byte                     uppercase  // 0x17
  public            System.Byte                     lowercase  // 0x18
  public            System.Byte                     smallcaps  // 0x19
METHODS:
  System.Void Clear()
  System.Byte Add(TMPro.FontStyles style)
  System.Byte Remove(TMPro.FontStyles style)
END_CLASS

CLASS: TMPro.TMP_TextProcessingStack`1
TYPE:  struct
TOKEN: 0x20000A4
FIELDS:
  public            T[]                             itemStack  // 0x0
  public            System.Int32                    index  // 0x0
  private           T                               m_DefaultItem  // 0x0
  private           System.Int32                    m_Capacity  // 0x0
  private           System.Int32                    m_RolloverSize  // 0x0
  private           System.Int32                    m_Count  // 0x0
  private   static  System.Int32                    k_DefaultCapacity  // 0x0
METHODS:
  System.Void .ctor(T[] stack)
  System.Void .ctor(System.Int32 capacity)
  System.Void .ctor(System.Int32 capacity, System.Int32 rolloverSize)
  System.Int32 get_Count()
  T get_current()
  System.Int32 get_rolloverSize()
  System.Void set_rolloverSize(System.Int32 value)
  System.Void SetDefault(TMPro.TMP_TextProcessingStack<T>[] stack, T item)
  System.Void Clear()
  System.Void SetDefault(T item)
  System.Void Add(T item)
  T Remove()
  System.Void Push(T item)
  T Pop()
  T Peek()
  T CurrentItem()
  T PreviousItem()
  System.Void Dispose()
END_CLASS

CLASS: TMPro.TMP_TextProcessingQueue`1
TYPE:  struct
TOKEN: 0x20000A5
FIELDS:
  public            T[]                             itemQueue  // 0x0
  private           System.Int32                    m_Head  // 0x0
  private           System.Int32                    m_Tail  // 0x0
  private           System.Int32                    m_Capacity  // 0x0
  private           System.Int32                    m_Count  // 0x0
  private           T                               m_DefaultItem  // 0x0
  private   static  System.Int32                    k_DefaultCapacity  // 0x0
METHODS:
  System.Void .ctor(T[] queue)
  System.Void .ctor(System.Int32 capacity)
  System.Int32 get_Count()
  System.Void Clear()
  System.Void SetDefault(T item)
  System.Void Enqueue(T item)
  T Dequeue()
  T Peek()
  System.Void Resize(System.Int32 newCapacity)
  System.Void Dispose()
END_CLASS

CLASS: TMPro.CaretPosition
TYPE:  struct
TOKEN: 0x20000A6
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.CaretPosition             None  // 0x0
  public    static  TMPro.CaretPosition             Left  // 0x0
  public    static  TMPro.CaretPosition             Right  // 0x0
METHODS:
END_CLASS

CLASS: TMPro.CaretInfo
TYPE:  struct
TOKEN: 0x20000A7
FIELDS:
  public            System.Int32                    index  // 0x10
  public            TMPro.CaretPosition             position  // 0x14
METHODS:
  System.Void .ctor(System.Int32 index, TMPro.CaretPosition position)
END_CLASS

CLASS: TMPro.TMP_TextUtilities
TYPE:  class
TOKEN: 0x20000A8
FIELDS:
  private   static  UnityEngine.Vector3[]           m_rectWorldCorners  // 0x0
  private   static  System.String                   k_lookupStringL  // 0x0
  private   static  System.String                   k_lookupStringU  // 0x0
METHODS:
  System.Int32 GetCursorIndexFromPosition(TMPro.TMP_Text textComponent, UnityEngine.Vector3 position, UnityEngine.Camera camera)
  System.Int32 GetCursorIndexFromPosition(TMPro.TMP_Text textComponent, UnityEngine.Vector3 position, UnityEngine.Camera camera, TMPro.CaretPosition& cursor)
  System.Int32 FindNearestLine(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera)
  System.Int32 FindNearestCharacterOnLine(TMPro.TMP_Text text, UnityEngine.Vector3 position, System.Int32 line, UnityEngine.Camera camera, System.Boolean visibleOnly)
  System.Boolean IsIntersectingRectTransform(UnityEngine.RectTransform rectTransform, UnityEngine.Vector3 position, UnityEngine.Camera camera)
  System.Int32 FindIntersectingCharacter(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera, System.Boolean visibleOnly)
  System.Int32 FindNearestCharacter(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera, System.Boolean visibleOnly)
  System.Int32 FindIntersectingWord(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera)
  System.Int32 FindNearestWord(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera)
  System.Int32 FindIntersectingLine(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera)
  System.Int32 FindIntersectingLink(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera)
  System.Int32 FindNearestLink(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera)
  System.Boolean PointIntersectRectangle(UnityEngine.Vector3 m, UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c, UnityEngine.Vector3 d)
  System.Boolean ScreenPointToWorldPointInRectangle(UnityEngine.Transform transform, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, UnityEngine.Vector3& worldPoint)
  System.Boolean IntersectLinePlane(TMPro.TMP_TextUtilities.LineSegment line, UnityEngine.Vector3 point, UnityEngine.Vector3 normal, UnityEngine.Vector3& intersectingPoint)
  System.Single DistanceToLine(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 point)
  System.Char ToLowerFast(System.Char c)
  System.Char ToUpperFast(System.Char c)
  System.UInt32 ToUpperASCIIFast(System.UInt32 c)
  System.Int32 GetHashCode(System.String s)
  System.Int32 GetSimpleHashCode(System.String s)
  System.UInt32 GetSimpleHashCodeLowercase(System.String s)
  System.Int32 HexToInt(System.Char hex)
  System.Int32 StringHexToInt(System.String s)
  System.Boolean IsUpVowel(System.Char c)
  System.Boolean IsLowVowel(System.Char c)
  System.Boolean IsToneMark(System.Char c)
  System.Boolean IsAscenderThai(System.Char c)
  System.Boolean IsDescenderThai(System.Char c)
  System.Void .cctor()
END_CLASS

CLASS: TMPro.TMP_UpdateManager
TYPE:  class
TOKEN: 0x20000AA
FIELDS:
  private   static  TMPro.TMP_UpdateManager         s_Instance  // 0x0
  private   readonly System.Collections.Generic.HashSet<System.Int32>m_LayoutQueueLookup  // 0x10
  private   readonly System.Collections.Generic.List<TMPro.TMP_Text>m_LayoutRebuildQueue  // 0x18
  private   readonly System.Collections.Generic.HashSet<System.Int32>m_GraphicQueueLookup  // 0x20
  private   readonly System.Collections.Generic.List<TMPro.TMP_Text>m_GraphicRebuildQueue  // 0x28
  private   readonly System.Collections.Generic.HashSet<System.Int32>m_InternalUpdateLookup  // 0x30
  private   readonly System.Collections.Generic.List<TMPro.TMP_Text>m_InternalUpdateQueue  // 0x38
  private   readonly System.Collections.Generic.HashSet<System.Int32>m_CullingUpdateLookup  // 0x40
  private   readonly System.Collections.Generic.List<TMPro.TMP_Text>m_CullingUpdateQueue  // 0x48
  private   static  Unity.Profiling.ProfilerMarker  k_RegisterTextObjectForUpdateMarker  // 0x8
  private   static  Unity.Profiling.ProfilerMarker  k_RegisterTextElementForGraphicRebuildMarker  // 0x10
  private   static  Unity.Profiling.ProfilerMarker  k_RegisterTextElementForCullingUpdateMarker  // 0x18
  private   static  Unity.Profiling.ProfilerMarker  k_UnregisterTextObjectForUpdateMarker  // 0x20
  private   static  Unity.Profiling.ProfilerMarker  k_UnregisterTextElementForGraphicRebuildMarker  // 0x28
METHODS:
  TMPro.TMP_UpdateManager get_instance()
  System.Void .ctor()
  System.Void RegisterTextObjectForUpdate(TMPro.TMP_Text textObject)
  System.Void InternalRegisterTextObjectForUpdate(TMPro.TMP_Text textObject)
  System.Void RegisterTextElementForLayoutRebuild(TMPro.TMP_Text element)
  System.Void InternalRegisterTextElementForLayoutRebuild(TMPro.TMP_Text element)
  System.Void RegisterTextElementForGraphicRebuild(TMPro.TMP_Text element)
  System.Void InternalRegisterTextElementForGraphicRebuild(TMPro.TMP_Text element)
  System.Void RegisterTextElementForCullingUpdate(TMPro.TMP_Text element)
  System.Void InternalRegisterTextElementForCullingUpdate(TMPro.TMP_Text element)
  System.Void OnCameraPreCull()
  System.Void DoRebuilds()
  System.Void UnRegisterTextObjectForUpdate(TMPro.TMP_Text textObject)
  System.Void UnRegisterTextElementForRebuild(TMPro.TMP_Text element)
  System.Void InternalUnRegisterTextElementForGraphicRebuild(TMPro.TMP_Text element)
  System.Void InternalUnRegisterTextElementForLayoutRebuild(TMPro.TMP_Text element)
  System.Void InternalUnRegisterTextObjectForUpdate(TMPro.TMP_Text textObject)
  System.Void .cctor()
END_CLASS

CLASS: TMPro.TMP_UpdateRegistry
TYPE:  class
TOKEN: 0x20000AB
FIELDS:
  private   static  TMPro.TMP_UpdateRegistry        s_Instance  // 0x0
  private   readonly System.Collections.Generic.List<UnityEngine.UI.ICanvasElement>m_LayoutRebuildQueue  // 0x10
  private           System.Collections.Generic.HashSet<System.Int32>m_LayoutQueueLookup  // 0x18
  private   readonly System.Collections.Generic.List<UnityEngine.UI.ICanvasElement>m_GraphicRebuildQueue  // 0x20
  private           System.Collections.Generic.HashSet<System.Int32>m_GraphicQueueLookup  // 0x28
METHODS:
  TMPro.TMP_UpdateRegistry get_instance()
  System.Void .ctor()
  System.Void RegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element)
  System.Boolean InternalRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element)
  System.Void RegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element)
  System.Boolean InternalRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element)
  System.Void PerformUpdateForCanvasRendererObjects()
  System.Void PerformUpdateForMeshRendererObjects()
  System.Void UnRegisterCanvasElementForRebuild(UnityEngine.UI.ICanvasElement element)
  System.Void InternalUnRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element)
  System.Void InternalUnRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element)
END_CLASS

CLASS: TMPro.SpriteAssetUtilities.SpriteAssetImportFormats
TYPE:  struct
TOKEN: 0x20000AC
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  TMPro.SpriteAssetUtilities.SpriteAssetImportFormatsNone  // 0x0
  public    static  TMPro.SpriteAssetUtilities.SpriteAssetImportFormatsTexturePackerJsonArray  // 0x0
METHODS:
END_CLASS

CLASS: TMPro.SpriteAssetUtilities.TexturePacker_JsonArray
TYPE:  class
TOKEN: 0x20000AD
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

