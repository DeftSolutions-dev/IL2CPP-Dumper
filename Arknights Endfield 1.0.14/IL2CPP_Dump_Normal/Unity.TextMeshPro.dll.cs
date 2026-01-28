// ========================================================
// Dumped by @desirepro
// Assembly: Unity.TextMeshPro.dll
// Classes:  180
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x200002E
    public struct AnchorPositions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.TMP_Compatibility.AnchorPositions TopLeft;        // 0x0
        public static TMPro.TMP_Compatibility.AnchorPositions Top;        // 0x0
        public static TMPro.TMP_Compatibility.AnchorPositions TopRight;        // 0x0
        public static TMPro.TMP_Compatibility.AnchorPositions Left;        // 0x0
        public static TMPro.TMP_Compatibility.AnchorPositions Center;        // 0x0
        public static TMPro.TMP_Compatibility.AnchorPositions Right;        // 0x0
        public static TMPro.TMP_Compatibility.AnchorPositions BottomLeft;        // 0x0
        public static TMPro.TMP_Compatibility.AnchorPositions Bottom;        // 0x0
        public static TMPro.TMP_Compatibility.AnchorPositions BottomRight;        // 0x0
        public static TMPro.TMP_Compatibility.AnchorPositions BaseLine;        // 0x0
        public static TMPro.TMP_Compatibility.AnchorPositions None;        // 0x0

    }

    // TypeToken: 0x2000031
    public struct ColorTweenMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.ColorTween.ColorTweenMode All;        // 0x0
        public static TMPro.ColorTween.ColorTweenMode RGB;        // 0x0
        public static TMPro.ColorTween.ColorTweenMode Alpha;        // 0x0

    }

    // TypeToken: 0x2000032
    public class ColorTweenCallback : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000034
    public class FloatTweenCallback : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000038
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

    // TypeToken: 0x200003A
    public class DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler
    {
        // Fields
        private TMPro.TMP_Text m_Text;        // 0x18
        private UnityEngine.UI.Image m_Image;        // 0x20
        private UnityEngine.RectTransform m_RectTransform;        // 0x28
        private UnityEngine.UI.Toggle m_Toggle;        // 0x30

        // Methods
        private TMPro.TMP_Text get_text() { }
        private System.Void set_text(TMPro.TMP_Text value) { }
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

    // TypeToken: 0x200003B
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

    // TypeToken: 0x200003C
    public class OptionDataList
    {
        // Fields
        private System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> m_Options;        // 0x10

        // Methods
        private System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> get_options() { }
        private System.Void set_options(System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003D
    public class DropdownEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000059
    public struct ContentType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.TMP_InputField.ContentType Standard;        // 0x0
        public static TMPro.TMP_InputField.ContentType Autocorrected;        // 0x0
        public static TMPro.TMP_InputField.ContentType IntegerNumber;        // 0x0
        public static TMPro.TMP_InputField.ContentType DecimalNumber;        // 0x0
        public static TMPro.TMP_InputField.ContentType Alphanumeric;        // 0x0
        public static TMPro.TMP_InputField.ContentType Name;        // 0x0
        public static TMPro.TMP_InputField.ContentType EmailAddress;        // 0x0
        public static TMPro.TMP_InputField.ContentType Password;        // 0x0
        public static TMPro.TMP_InputField.ContentType Pin;        // 0x0
        public static TMPro.TMP_InputField.ContentType Custom;        // 0x0

    }

    // TypeToken: 0x200005A
    public struct InputType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.TMP_InputField.InputType Standard;        // 0x0
        public static TMPro.TMP_InputField.InputType AutoCorrect;        // 0x0
        public static TMPro.TMP_InputField.InputType Password;        // 0x0

    }

    // TypeToken: 0x200005B
    public struct CharacterValidation
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.TMP_InputField.CharacterValidation None;        // 0x0
        public static TMPro.TMP_InputField.CharacterValidation Digit;        // 0x0
        public static TMPro.TMP_InputField.CharacterValidation Integer;        // 0x0
        public static TMPro.TMP_InputField.CharacterValidation Decimal;        // 0x0
        public static TMPro.TMP_InputField.CharacterValidation Alphanumeric;        // 0x0
        public static TMPro.TMP_InputField.CharacterValidation Name;        // 0x0
        public static TMPro.TMP_InputField.CharacterValidation Regex;        // 0x0
        public static TMPro.TMP_InputField.CharacterValidation EmailAddress;        // 0x0
        public static TMPro.TMP_InputField.CharacterValidation CustomValidator;        // 0x0

    }

    // TypeToken: 0x200005C
    public struct LineType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.TMP_InputField.LineType SingleLine;        // 0x0
        public static TMPro.TMP_InputField.LineType MultiLineSubmit;        // 0x0
        public static TMPro.TMP_InputField.LineType MultiLineNewline;        // 0x0

    }

    // TypeToken: 0x200005D
    public class OnValidateInput : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Char Invoke(System.String text, System.Int32 charIndex, System.Char addedChar) { }
        private System.IAsyncResult BeginInvoke(System.String text, System.Int32 charIndex, System.Char addedChar, System.AsyncCallback callback, System.Object object) { }
        private System.Char EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200005E
    public class SubmitEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005F
    public class OnChangeEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000060
    public class SelectionEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000061
    public class TextSelectionEvent : UnityEvent`3
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000062
    public class TouchScreenKeyboardEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000063
    public struct EditState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.TMP_InputField.EditState Continue;        // 0x0
        public static TMPro.TMP_InputField.EditState Finish;        // 0x0

    }

    // TypeToken: 0x200006C
    public class FallbackMaterial
    {
        // Fields
        public System.Int64 fallbackID;        // 0x10
        public UnityEngine.Material sourceMaterial;        // 0x18
        private System.Int32 sourceMaterialCRC;        // 0x20
        public UnityEngine.Material fallbackMaterial;        // 0x28
        public System.Int32 count;        // 0x30

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006D
    public class MaskingMaterial
    {
        // Fields
        public UnityEngine.Material baseMaterial;        // 0x10
        public UnityEngine.Material stencilMaterial;        // 0x18
        public System.Int32 count;        // 0x20
        public System.Int32 stencilID;        // 0x24

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007D
    public class LineBreakingTable
    {
        // Fields
        public System.Collections.Generic.Dictionary<System.Int32,System.Char> leadingCharacters;        // 0x10
        public System.Collections.Generic.Dictionary<System.Int32,System.Char> followingCharacters;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000098
    public struct CharacterSubstitution
    {
        // Fields
        public System.Int32 index;        // 0x10
        public System.UInt32 unicode;        // 0x14

        // Methods
        private System.Void .ctor(System.Int32 index, System.UInt32 unicode) { }

    }

    // TypeToken: 0x2000099
    public struct TextInputSources
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.TMP_Text.TextInputSources TextInputBox;        // 0x0
        public static TMPro.TMP_Text.TextInputSources SetText;        // 0x0
        public static TMPro.TMP_Text.TextInputSources SetTextArray;        // 0x0
        public static TMPro.TMP_Text.TextInputSources TextString;        // 0x0

    }

    // TypeToken: 0x200009A
    public struct UnicodeChar
    {
        // Fields
        public System.Int32 unicode;        // 0x10
        public System.Int32 stringIndex;        // 0x14
        public System.Int32 length;        // 0x18

    }

    // TypeToken: 0x200009B
    public struct SpecialCharacter
    {
        // Fields
        public TMPro.TMP_Character character;        // 0x10
        public TMPro.TMP_FontAsset fontAsset;        // 0x18
        public UnityEngine.Material material;        // 0x20
        public System.Int32 materialIndex;        // 0x28

        // Methods
        private System.Void .ctor(TMPro.TMP_Character character, System.Int32 materialIndex) { }

    }

    // TypeToken: 0x200009C
    public struct TextBackingContainer, IDisposable
    {
        // Fields
        private System.UInt32[] m_Array;        // 0x10
        private System.Int32 m_Count;        // 0x18

        // Methods
        private System.Int32 get_Capacity() { }
        private System.Int32 get_Count() { }
        private System.Void set_Count(System.Int32 value) { }
        private System.UInt32 get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, System.UInt32 value) { }
        private System.Void .ctor(System.Int32 size) { }
        private System.Void Resize(System.Int32 size) { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x20000A9
    public struct LineSegment
    {
        // Fields
        public UnityEngine.Vector3 Point1;        // 0x10
        public UnityEngine.Vector3 Point2;        // 0x1C

        // Methods
        private System.Void .ctor(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2) { }

    }

    // TypeToken: 0x20000AE
    public struct SpriteFrame
    {
        // Fields
        public System.Single x;        // 0x10
        public System.Single y;        // 0x14
        public System.Single w;        // 0x18
        public System.Single h;        // 0x1C

        // Methods
        private System.String ToString() { }

    }

    // TypeToken: 0x20000AF
    public struct SpriteSize
    {
        // Fields
        public System.Single w;        // 0x10
        public System.Single h;        // 0x14

        // Methods
        private System.String ToString() { }

    }

    // TypeToken: 0x20000B0
    public struct Frame
    {
        // Fields
        public System.String filename;        // 0x10
        public TMPro.SpriteAssetUtilities.TexturePacker_JsonArray.SpriteFrame frame;        // 0x18
        public System.Boolean rotated;        // 0x28
        public System.Boolean trimmed;        // 0x29
        public TMPro.SpriteAssetUtilities.TexturePacker_JsonArray.SpriteFrame spriteSourceSize;        // 0x2C
        public TMPro.SpriteAssetUtilities.TexturePacker_JsonArray.SpriteSize sourceSize;        // 0x3C
        public UnityEngine.Vector2 pivot;        // 0x44

    }

    // TypeToken: 0x20000B1
    public struct Meta
    {
        // Fields
        public System.String app;        // 0x10
        public System.String version;        // 0x18
        public System.String image;        // 0x20
        public System.String format;        // 0x28
        public TMPro.SpriteAssetUtilities.TexturePacker_JsonArray.SpriteSize size;        // 0x30
        public System.Single scale;        // 0x38
        public System.String smartupdate;        // 0x40

    }

    // TypeToken: 0x20000B2
    public class SpriteDataObject
    {
        // Fields
        public System.Collections.Generic.List<TMPro.SpriteAssetUtilities.TexturePacker_JsonArray.Frame> frames;        // 0x10
        public TMPro.SpriteAssetUtilities.TexturePacker_JsonArray.Meta meta;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B4
    public struct __StaticArrayInitTypeSize=12
    {
    }

namespace TMPro
{

    // TypeToken: 0x2000002
    public class FastAction
    {
        // Fields
        private System.Collections.Generic.LinkedList<System.Action> delegates;        // 0x10
        private System.Collections.Generic.Dictionary<System.Action,System.Collections.Generic.LinkedListNode<System.Action>> lookup;        // 0x18

        // Methods
        private System.Void Add(System.Action rhs) { }
        private System.Void Remove(System.Action rhs) { }
        private System.Void Call() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000003
    public class FastAction`1
    {
        // Fields
        private System.Collections.Generic.LinkedList<System.Action<A>> delegates;        // 0x0
        private System.Collections.Generic.Dictionary<System.Action<A>,System.Collections.Generic.LinkedListNode<System.Action<A>>> lookup;        // 0x0

        // Methods
        private System.Void Add(System.Action<A> rhs) { }
        private System.Void Remove(System.Action<A> rhs) { }
        private System.Void Call(A a) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000004
    public class FastAction`2
    {
        // Fields
        private System.Collections.Generic.LinkedList<System.Action<A,B>> delegates;        // 0x0
        private System.Collections.Generic.Dictionary<System.Action<A,B>,System.Collections.Generic.LinkedListNode<System.Action<A,B>>> lookup;        // 0x0

        // Methods
        private System.Void Add(System.Action<A,B> rhs) { }
        private System.Void Remove(System.Action<A,B> rhs) { }
        private System.Void Call(A a, B b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000005
    public class FastAction`3
    {
        // Fields
        private System.Collections.Generic.LinkedList<System.Action<A,B,C>> delegates;        // 0x0
        private System.Collections.Generic.Dictionary<System.Action<A,B,C>,System.Collections.Generic.LinkedListNode<System.Action<A,B,C>>> lookup;        // 0x0

        // Methods
        private System.Void Add(System.Action<A,B,C> rhs) { }
        private System.Void Remove(System.Action<A,B,C> rhs) { }
        private System.Void Call(A a, B b, C c) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000006
    public interface IFontAssetLoader
    {
        // Methods
        private System.Boolean TryGetFontAsset(TMPro.TMP_Text refText, System.UInt32 unicode, TMPro.TMP_FontAsset& fontAsset) { }
        private System.Void TryRemoveRefText(TMPro.TMP_Text refText) { }

    }

    // TypeToken: 0x2000007
    public interface ITextPreprocessor
    {
        // Methods
        private System.String PreprocessText(System.String text) { }

    }

    // TypeToken: 0x2000008
    public class MaterialReferenceManager
    {
        // Fields
        private static TMPro.MaterialReferenceManager s_Instance;        // 0x0
        private System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Material> m_FontMaterialReferenceLookup;        // 0x10
        private System.Collections.Generic.Dictionary<System.Int32,TMPro.TMP_FontAsset> m_FontAssetReferenceLookup;        // 0x18
        private System.Collections.Generic.Dictionary<System.Int32,TMPro.TMP_SpriteAsset> m_SpriteAssetReferenceLookup;        // 0x20
        private System.Collections.Generic.Dictionary<System.Int32,TMPro.TMP_ColorGradient> m_ColorGradientReferenceLookup;        // 0x28

        // Methods
        private TMPro.MaterialReferenceManager get_instance() { }
        private System.Void AddFontAsset(TMPro.TMP_FontAsset fontAsset) { }
        private System.Void AddFontAssetInternal(TMPro.TMP_FontAsset fontAsset) { }
        private System.Void AddSpriteAsset(TMPro.TMP_SpriteAsset spriteAsset) { }
        private System.Void AddSpriteAssetInternal(TMPro.TMP_SpriteAsset spriteAsset) { }
        private System.Void AddSpriteAsset(System.Int32 hashCode, TMPro.TMP_SpriteAsset spriteAsset) { }
        private System.Void AddSpriteAssetInternal(System.Int32 hashCode, TMPro.TMP_SpriteAsset spriteAsset) { }
        private System.Void AddFontMaterial(System.Int32 hashCode, UnityEngine.Material material) { }
        private System.Void AddFontMaterialInternal(System.Int32 hashCode, UnityEngine.Material material) { }
        private System.Void AddColorGradientPreset(System.Int32 hashCode, TMPro.TMP_ColorGradient spriteAsset) { }
        private System.Void AddColorGradientPreset_Internal(System.Int32 hashCode, TMPro.TMP_ColorGradient spriteAsset) { }
        private System.Boolean Contains(TMPro.TMP_FontAsset font) { }
        private System.Boolean Contains(TMPro.TMP_SpriteAsset sprite) { }
        private System.Boolean TryGetFontAsset(System.Int32 hashCode, TMPro.TMP_FontAsset& fontAsset) { }
        private System.Boolean TryGetFontAssetInternal(System.Int32 hashCode, TMPro.TMP_FontAsset& fontAsset) { }
        private System.Boolean TryGetSpriteAsset(System.Int32 hashCode, TMPro.TMP_SpriteAsset& spriteAsset) { }
        private System.Boolean TryGetSpriteAssetInternal(System.Int32 hashCode, TMPro.TMP_SpriteAsset& spriteAsset) { }
        private System.Boolean TryGetColorGradientPreset(System.Int32 hashCode, TMPro.TMP_ColorGradient& gradientPreset) { }
        private System.Boolean TryGetColorGradientPresetInternal(System.Int32 hashCode, TMPro.TMP_ColorGradient& gradientPreset) { }
        private System.Boolean TryGetMaterial(System.Int32 hashCode, UnityEngine.Material& material) { }
        private System.Boolean TryGetMaterialInternal(System.Int32 hashCode, UnityEngine.Material& material) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000009
    public struct TMP_MaterialReference
    {
        // Fields
        public UnityEngine.Material material;        // 0x10
        public System.Int32 referenceCount;        // 0x18

    }

    // TypeToken: 0x200000A
    public struct MaterialReference
    {
        // Fields
        public System.Int32 index;        // 0x10
        public TMPro.TMP_FontAsset fontAsset;        // 0x18
        public TMPro.TMP_SpriteAsset spriteAsset;        // 0x20
        public UnityEngine.Material material;        // 0x28
        public System.Boolean isDefaultMaterial;        // 0x30
        public System.Boolean isFallbackMaterial;        // 0x31
        public UnityEngine.Material fallbackMaterial;        // 0x38
        public System.Single padding;        // 0x40
        public System.Int32 referenceCount;        // 0x44

        // Methods
        private System.Void .ctor(System.Int32 index, TMPro.TMP_FontAsset fontAsset, TMPro.TMP_SpriteAsset spriteAsset, UnityEngine.Material material, System.Single padding) { }
        private System.Boolean Contains(TMPro.MaterialReference[] materialReferences, TMPro.TMP_FontAsset fontAsset) { }
        private System.Int32 AddMaterialReference(UnityEngine.Material material, TMPro.TMP_FontAsset fontAsset, TMPro.MaterialReference[]& materialReferences, System.Collections.Generic.Dictionary<System.Int32,System.Int32> materialReferenceIndexLookup) { }
        private System.Int32 AddMaterialReference(UnityEngine.Material material, TMPro.TMP_SpriteAsset spriteAsset, TMPro.MaterialReference[]& materialReferences, System.Collections.Generic.Dictionary<System.Int32,System.Int32> materialReferenceIndexLookup) { }

    }

    // TypeToken: 0x200000B
    public struct TextContainerAnchors
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.TextContainerAnchors TopLeft;        // 0x0
        public static TMPro.TextContainerAnchors Top;        // 0x0
        public static TMPro.TextContainerAnchors TopRight;        // 0x0
        public static TMPro.TextContainerAnchors Left;        // 0x0
        public static TMPro.TextContainerAnchors Middle;        // 0x0
        public static TMPro.TextContainerAnchors Right;        // 0x0
        public static TMPro.TextContainerAnchors BottomLeft;        // 0x0
        public static TMPro.TextContainerAnchors Bottom;        // 0x0
        public static TMPro.TextContainerAnchors BottomRight;        // 0x0
        public static TMPro.TextContainerAnchors Custom;        // 0x0

    }

    // TypeToken: 0x200000C
    public class TextContainer : UIBehaviour
    {
        // Fields
        private System.Boolean m_hasChanged;        // 0x18
        private UnityEngine.Vector2 m_pivot;        // 0x1C
        private TMPro.TextContainerAnchors m_anchorPosition;        // 0x24
        private UnityEngine.Rect m_rect;        // 0x28
        private System.Boolean m_isDefaultWidth;        // 0x38
        private System.Boolean m_isDefaultHeight;        // 0x39
        private System.Boolean m_isAutoFitting;        // 0x3A
        private UnityEngine.Vector3[] m_corners;        // 0x40
        private UnityEngine.Vector3[] m_worldCorners;        // 0x48
        private UnityEngine.Vector4 m_margins;        // 0x50
        private UnityEngine.RectTransform m_rectTransform;        // 0x60
        private static UnityEngine.Vector2 k_defaultSize;        // 0x0
        private TMPro.TextMeshPro m_textMeshPro;        // 0x68

        // Methods
        private System.Boolean get_hasChanged() { }
        private System.Void set_hasChanged(System.Boolean value) { }
        private UnityEngine.Vector2 get_pivot() { }
        private System.Void set_pivot(UnityEngine.Vector2 value) { }
        private TMPro.TextContainerAnchors get_anchorPosition() { }
        private System.Void set_anchorPosition(TMPro.TextContainerAnchors value) { }
        private UnityEngine.Rect get_rect() { }
        private System.Void set_rect(UnityEngine.Rect value) { }
        private UnityEngine.Vector2 get_size() { }
        private System.Void set_size(UnityEngine.Vector2 value) { }
        private System.Single get_width() { }
        private System.Void set_width(System.Single value) { }
        private System.Single get_height() { }
        private System.Void set_height(System.Single value) { }
        private System.Boolean get_isDefaultWidth() { }
        private System.Boolean get_isDefaultHeight() { }
        private System.Boolean get_isAutoFitting() { }
        private System.Void set_isAutoFitting(System.Boolean value) { }
        private UnityEngine.Vector3[] get_corners() { }
        private UnityEngine.Vector3[] get_worldCorners() { }
        private UnityEngine.Vector4 get_margins() { }
        private System.Void set_margins(UnityEngine.Vector4 value) { }
        private UnityEngine.RectTransform get_rectTransform() { }
        private TMPro.TextMeshPro get_textMeshPro() { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnContainerChanged() { }
        private System.Void OnRectTransformDimensionsChange() { }
        private System.Void SetRect(UnityEngine.Vector2 size) { }
        private System.Void UpdateCorners() { }
        private UnityEngine.Vector2 GetPivot(TMPro.TextContainerAnchors anchor) { }
        private TMPro.TextContainerAnchors GetAnchorPosition(UnityEngine.Vector2 pivot) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000D
    public class TextMeshPro : TMP_Text, ILayoutElement
    {
        // Fields
        private System.Int32 _SortingLayer;        // 0xAF8
        private System.Int32 _SortingLayerID;        // 0xAFC
        private System.Int32 _SortingOrder;        // 0xB00
        private System.Action<TMPro.TMP_TextInfo> OnPreRenderText;        // 0xB08
        private System.Boolean m_currentAutoSizeMode;        // 0xB10
        private System.Boolean m_hasFontAssetChanged;        // 0xB11
        private System.Single m_previousLossyScaleY;        // 0xB14
        private UnityEngine.Renderer m_renderer;        // 0xB18
        private UnityEngine.MeshFilter m_meshFilter;        // 0xB20
        private System.Boolean m_isFirstAllocation;        // 0xB28
        private System.Int32 m_max_characters;        // 0xB2C
        private System.Int32 m_max_numberOfLines;        // 0xB30
        private TMPro.TMP_SubMesh[] m_subTextObjects;        // 0xB38
        private TMPro.MaskingTypes m_maskType;        // 0xB40
        private UnityEngine.Matrix4x4 m_EnvMapMatrix;        // 0xB44
        private UnityEngine.Vector3[] m_RectTransformCorners;        // 0xB88
        private System.Boolean m_isRegisteredForEvents;        // 0xB90
        private static Unity.Profiling.ProfilerMarker k_GenerateTextMarker;        // 0x0
        private static Unity.Profiling.ProfilerMarker k_SetArraySizesMarker;        // 0x8
        private static Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIMarker;        // 0x10
        private static Unity.Profiling.ProfilerMarker k_ParseMarkupTextMarker;        // 0x18
        private static Unity.Profiling.ProfilerMarker k_CharacterLookupMarker;        // 0x20
        private static Unity.Profiling.ProfilerMarker k_HandleGPOSFeaturesMarker;        // 0x28
        private static Unity.Profiling.ProfilerMarker k_CalculateVerticesPositionMarker;        // 0x30
        private static Unity.Profiling.ProfilerMarker k_ComputeTextMetricsMarker;        // 0x38
        private static Unity.Profiling.ProfilerMarker k_HandleVisibleCharacterMarker;        // 0x40
        private static Unity.Profiling.ProfilerMarker k_HandleWhiteSpacesMarker;        // 0x48
        private static Unity.Profiling.ProfilerMarker k_HandleHorizontalLineBreakingMarker;        // 0x50
        private static Unity.Profiling.ProfilerMarker k_HandleVerticalLineBreakingMarker;        // 0x58
        private static Unity.Profiling.ProfilerMarker k_SaveGlyphVertexDataMarker;        // 0x60
        private static Unity.Profiling.ProfilerMarker k_ComputeCharacterAdvanceMarker;        // 0x68
        private static Unity.Profiling.ProfilerMarker k_HandleCarriageReturnMarker;        // 0x70
        private static Unity.Profiling.ProfilerMarker k_HandleLineTerminationMarker;        // 0x78
        private static Unity.Profiling.ProfilerMarker k_SavePageInfoMarker;        // 0x80
        private static Unity.Profiling.ProfilerMarker k_SaveProcessingStatesMarker;        // 0x88
        private static Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIIMarker;        // 0x90
        private static Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIIIMarker;        // 0x98

        // Methods
        private System.Int32 get_sortingLayerID() { }
        private System.Void set_sortingLayerID(System.Int32 value) { }
        private System.Int32 get_sortingOrder() { }
        private System.Void set_sortingOrder(System.Int32 value) { }
        private System.Boolean get_autoSizeTextContainer() { }
        private System.Void set_autoSizeTextContainer(System.Boolean value) { }
        private TMPro.TextContainer get_textContainer() { }
        private UnityEngine.Transform get_transform() { }
        private UnityEngine.Renderer get_renderer() { }
        private UnityEngine.Mesh get_mesh() { }
        private UnityEngine.MeshFilter get_meshFilter() { }
        private TMPro.MaskingTypes get_maskType() { }
        private System.Void set_maskType(TMPro.MaskingTypes value) { }
        private System.Void SetMask(TMPro.MaskingTypes type, UnityEngine.Vector4 maskCoords) { }
        private System.Void SetMask(TMPro.MaskingTypes type, UnityEngine.Vector4 maskCoords, System.Single softnessX, System.Single softnessY) { }
        private System.Void SetVerticesDirty() { }
        private System.Void SetLayoutDirty() { }
        private System.Void SetMaterialDirty() { }
        private System.Void SetAllDirty() { }
        private System.Void Rebuild(UnityEngine.UI.CanvasUpdate update) { }
        private System.Void UpdateMaterial() { }
        private System.Void UpdateMeshPadding() { }
        private System.Void ForceMeshUpdate(System.Boolean ignoreActiveState, System.Boolean forceTextReparsing) { }
        private TMPro.TMP_TextInfo GetTextInfo(System.String text) { }
        private System.Void ClearMesh(System.Boolean updateMesh) { }
        private System.Void add_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value) { }
        private System.Void remove_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value) { }
        private System.Void UpdateGeometry(UnityEngine.Mesh mesh, System.Int32 index) { }
        private System.Void UpdateVertexData(TMPro.TMP_VertexDataUpdateFlags flags) { }
        private System.Void UpdateVertexData() { }
        private System.Void UpdateFontAsset() { }
        private System.Void CalculateLayoutInputHorizontal() { }
        private System.Void CalculateLayoutInputVertical() { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void LoadFontAsset() { }
        private System.Void UpdateEnvMapMatrix() { }
        private System.Void SetMask(TMPro.MaskingTypes maskType) { }
        private System.Void SetMaskCoordinates(UnityEngine.Vector4 coords) { }
        private System.Void SetMaskCoordinates(UnityEngine.Vector4 coords, System.Single softX, System.Single softY) { }
        private System.Void EnableMasking() { }
        private System.Void DisableMasking() { }
        private System.Void UpdateMask() { }
        private UnityEngine.Material GetMaterial(UnityEngine.Material mat) { }
        private UnityEngine.Material[] GetMaterials(UnityEngine.Material[] mats) { }
        private System.Void SetSharedMaterial(UnityEngine.Material mat) { }
        private UnityEngine.Material[] GetSharedMaterials() { }
        private System.Void SetSharedMaterials(UnityEngine.Material[] materials) { }
        private System.Void SetOutlineThickness(System.Single thickness) { }
        private System.Void SetFaceColor(UnityEngine.Color32 color) { }
        private System.Void SetOutlineColor(UnityEngine.Color32 color) { }
        private System.Void CreateMaterialInstance() { }
        private System.Void SetShaderDepth() { }
        private System.Void SetCulling() { }
        private System.Void SetPerspectiveCorrection() { }
        private System.Int32 SetArraySizes(TMPro.TMP_Text.UnicodeChar[] unicodeChars) { }
        private System.Void ComputeMarginSize() { }
        private System.Void OnDidApplyAnimationProperties() { }
        private System.Void OnTransformParentChanged() { }
        private System.Void OnRectTransformDimensionsChange() { }
        private System.Void InternalUpdate() { }
        private System.Void OnPreRenderObject() { }
        private System.Void GenerateTextMesh() { }
        private UnityEngine.Vector3[] GetTextContainerLocalCorners() { }
        private System.Void SetMeshFilters(System.Boolean state) { }
        private System.Void SetActiveSubMeshes(System.Boolean state) { }
        private System.Void SetActiveSubTextObjectRenderers(System.Boolean state) { }
        private System.Void DestroySubMeshObjects() { }
        private System.Void UpdateSubMeshSortingLayerID(System.Int32 id) { }
        private System.Void UpdateSubMeshSortingOrder(System.Int32 order) { }
        private UnityEngine.Bounds GetCompoundBounds() { }
        private System.Void UpdateSDFScale(System.Single scaleDelta) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000E
    public class TextMeshProUGUI : TMP_Text, ILayoutElement
    {
        // Fields
        private System.Boolean m_isRebuildingLayout;        // 0xAF8
        private UnityEngine.Coroutine m_DelayedGraphicRebuild;        // 0xB00
        private UnityEngine.Coroutine m_DelayedMaterialRebuild;        // 0xB08
        private UnityEngine.Rect m_ClipRect;        // 0xB10
        private System.Boolean m_ValidRect;        // 0xB20
        private System.Action<TMPro.TMP_TextInfo> OnPreRenderText;        // 0xB28
        private System.Boolean m_hasFontAssetChanged;        // 0xB30
        protected TMPro.TMP_SubMeshUI[] m_subTextObjects;        // 0xB38
        protected UnityEngine.Vector3[] m_RectTransformCorners;        // 0xB40
        protected UnityEngine.CanvasRenderer m_canvasRenderer;        // 0xB48
        protected UnityEngine.Canvas m_canvas;        // 0xB50
        protected System.Single m_CanvasScaleFactor;        // 0xB58
        protected System.Single m_previousLossyScaleY;        // 0xB5C
        private System.Boolean m_isFirstAllocation;        // 0xB60
        private System.Int32 m_max_characters;        // 0xB64
        private UnityEngine.Material m_baseMaterial;        // 0xB68
        private System.Boolean m_isScrollRegionSet;        // 0xB70
        private UnityEngine.Vector4 m_maskOffset;        // 0xB74
        private UnityEngine.Matrix4x4 m_EnvMapMatrix;        // 0xB84
        private System.Boolean m_isRegisteredForEvents;        // 0xBC4
        private static Unity.Profiling.ProfilerMarker k_GenerateTextMarker;        // 0x0
        private static Unity.Profiling.ProfilerMarker k_SetArraySizesMarker;        // 0x8
        private static Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIMarker;        // 0x10
        private static Unity.Profiling.ProfilerMarker k_ParseMarkupTextMarker;        // 0x18
        private static Unity.Profiling.ProfilerMarker k_CharacterLookupMarker;        // 0x20
        private static Unity.Profiling.ProfilerMarker k_HandleGPOSFeaturesMarker;        // 0x28
        private static Unity.Profiling.ProfilerMarker k_CalculateVerticesPositionMarker;        // 0x30
        private static Unity.Profiling.ProfilerMarker k_ComputeTextMetricsMarker;        // 0x38
        private static Unity.Profiling.ProfilerMarker k_HandleVisibleCharacterMarker;        // 0x40
        private static Unity.Profiling.ProfilerMarker k_HandleWhiteSpacesMarker;        // 0x48
        private static Unity.Profiling.ProfilerMarker k_HandleHorizontalLineBreakingMarker;        // 0x50
        private static Unity.Profiling.ProfilerMarker k_HandleVerticalLineBreakingMarker;        // 0x58
        private static Unity.Profiling.ProfilerMarker k_SaveGlyphVertexDataMarker;        // 0x60
        private static Unity.Profiling.ProfilerMarker k_ComputeCharacterAdvanceMarker;        // 0x68
        private static Unity.Profiling.ProfilerMarker k_HandleCarriageReturnMarker;        // 0x70
        private static Unity.Profiling.ProfilerMarker k_HandleLineTerminationMarker;        // 0x78
        private static Unity.Profiling.ProfilerMarker k_SavePageInfoMarker;        // 0x80
        private static Unity.Profiling.ProfilerMarker k_SaveProcessingStatesMarker;        // 0x88
        private static Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIIMarker;        // 0x90
        private static Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIIIMarker;        // 0x98

        // Methods
        private UnityEngine.Material get_materialForRendering() { }
        private System.Boolean get_autoSizeTextContainer() { }
        private System.Void set_autoSizeTextContainer(System.Boolean value) { }
        private UnityEngine.Mesh get_mesh() { }
        private UnityEngine.CanvasRenderer get_canvasRenderer() { }
        private System.Void CalculateLayoutInputHorizontal() { }
        private System.Void CalculateLayoutInputVertical() { }
        private System.Void SetVerticesDirty() { }
        private System.Void SetLayoutDirty() { }
        private System.Void SetMaterialDirty() { }
        private System.Void SetAllDirty() { }
        private System.Collections.IEnumerator DelayedGraphicRebuild() { }
        private System.Collections.IEnumerator DelayedMaterialRebuild() { }
        private System.Void Rebuild(UnityEngine.UI.CanvasUpdate update) { }
        private System.Void UpdateSubObjectPivot() { }
        private UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial) { }
        private System.Void UpdateMaterial() { }
        private UnityEngine.Vector4 get_maskOffset() { }
        private System.Void set_maskOffset(UnityEngine.Vector4 value) { }
        private System.Void RecalculateClipping() { }
        private System.Void Cull(UnityEngine.Rect clipRect, System.Boolean validRect) { }
        private System.Void UpdateCulling() { }
        private System.Void UpdateMeshPadding() { }
        private System.Void InternalCrossFadeColor(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha) { }
        private System.Void InternalCrossFadeAlpha(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale) { }
        private System.Void ForceMeshUpdate(System.Boolean ignoreActiveState, System.Boolean forceTextReparsing) { }
        private TMPro.TMP_TextInfo GetTextInfo(System.String text) { }
        private System.Void ClearMesh() { }
        private System.Void add_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value) { }
        private System.Void remove_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value) { }
        private System.Void UpdateGeometry(UnityEngine.Mesh mesh, System.Int32 index) { }
        private System.Void UpdateVertexData(TMPro.TMP_VertexDataUpdateFlags flags) { }
        private System.Void UpdateVertexData() { }
        private System.Void UpdateFontAsset() { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void LoadFontAsset() { }
        private UnityEngine.Canvas GetCanvas() { }
        private System.Void UpdateEnvMapMatrix() { }
        private System.Void EnableMasking() { }
        private System.Void DisableMasking() { }
        private System.Void UpdateMask() { }
        private UnityEngine.Material GetMaterial(UnityEngine.Material mat) { }
        private UnityEngine.Material[] GetMaterials(UnityEngine.Material[] mats) { }
        private System.Void SetSharedMaterial(UnityEngine.Material mat) { }
        private UnityEngine.Material[] GetSharedMaterials() { }
        private System.Void SetSharedMaterials(UnityEngine.Material[] materials) { }
        private System.Void SetOutlineThickness(System.Single thickness) { }
        private System.Void SetFaceColor(UnityEngine.Color32 color) { }
        private System.Void SetOutlineColor(UnityEngine.Color32 color) { }
        private System.Void SetShaderDepth() { }
        private System.Void SetCulling() { }
        private System.Void SetPerspectiveCorrection() { }
        private System.Void SetMeshArrays(System.Int32 size) { }
        private System.Int32 SetArraySizes(TMPro.TMP_Text.UnicodeChar[] unicodeChars) { }
        private System.Void ComputeMarginSize() { }
        private System.Void OnDidApplyAnimationProperties() { }
        private System.Void OnCanvasHierarchyChanged() { }
        private System.Void OnTransformParentChanged() { }
        private System.Void OnRectTransformDimensionsChange() { }
        private System.Void InternalUpdate() { }
        private System.Void OnPreRenderCanvas() { }
        private TMPro.TMP_SubMeshUI AddSubTextObject(TMPro.TextMeshProUGUI textComponent, TMPro.MaterialReference materialReference) { }
        private System.Void GenerateTextMesh() { }
        private UnityEngine.Vector3[] GetTextContainerLocalCorners() { }
        private System.Void SetActiveSubMeshes(System.Boolean state) { }
        private System.Void DestroySubMeshObjects() { }
        private UnityEngine.Bounds GetCompoundBounds() { }
        private UnityEngine.Rect GetCanvasSpaceClippingRect() { }
        private System.Void UpdateSDFScale(System.Single scaleDelta) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000011
    public class ThaiTextPreprocessor, ITextPreprocessor
    {
        // Fields
        private static TMPro.ThaiTextPreprocessor _instance;        // 0x0

        // Methods
        private System.String PreprocessText(System.String text) { }
        private TMPro.ThaiTextPreprocessor get_Instance() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000012
    public struct Compute_DistanceTransform_EventTypes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.Compute_DistanceTransform_EventTypes Processing;        // 0x0
        public static TMPro.Compute_DistanceTransform_EventTypes Completed;        // 0x0

    }

    // TypeToken: 0x2000013
    public class TMPro_EventManager
    {
        // Fields
        public static readonly TMPro.FastAction<System.Object,TMPro.Compute_DT_EventArgs> COMPUTE_DT_EVENT;        // 0x0
        public static readonly TMPro.FastAction<System.Boolean,UnityEngine.Material> MATERIAL_PROPERTY_EVENT;        // 0x8
        public static readonly TMPro.FastAction<System.Boolean,UnityEngine.Object> FONT_PROPERTY_EVENT;        // 0x10
        public static readonly TMPro.FastAction<System.Boolean,UnityEngine.Object> SPRITE_ASSET_PROPERTY_EVENT;        // 0x18
        public static readonly TMPro.FastAction<System.Boolean,UnityEngine.Object> TEXTMESHPRO_PROPERTY_EVENT;        // 0x20
        public static readonly TMPro.FastAction<UnityEngine.GameObject,UnityEngine.Material,UnityEngine.Material> DRAG_AND_DROP_MATERIAL_EVENT;        // 0x28
        public static readonly TMPro.FastAction<System.Boolean> TEXT_STYLE_PROPERTY_EVENT;        // 0x30
        public static readonly TMPro.FastAction<UnityEngine.Object> COLOR_GRADIENT_PROPERTY_EVENT;        // 0x38
        public static readonly TMPro.FastAction TMP_SETTINGS_PROPERTY_EVENT;        // 0x40
        public static readonly TMPro.FastAction RESOURCE_LOAD_EVENT;        // 0x48
        public static readonly TMPro.FastAction<System.Boolean,UnityEngine.Object> TEXTMESHPRO_UGUI_PROPERTY_EVENT;        // 0x50
        public static readonly TMPro.FastAction<UnityEngine.Object> TEXT_CHANGED_EVENT;        // 0x58

        // Methods
        private System.Void ON_MATERIAL_PROPERTY_CHANGED(System.Boolean isChanged, UnityEngine.Material mat) { }
        private System.Void ON_FONT_PROPERTY_CHANGED(System.Boolean isChanged, UnityEngine.Object obj) { }
        private System.Void ON_SPRITE_ASSET_PROPERTY_CHANGED(System.Boolean isChanged, UnityEngine.Object obj) { }
        private System.Void ON_TEXTMESHPRO_PROPERTY_CHANGED(System.Boolean isChanged, UnityEngine.Object obj) { }
        private System.Void ON_DRAG_AND_DROP_MATERIAL_CHANGED(UnityEngine.GameObject sender, UnityEngine.Material currentMaterial, UnityEngine.Material newMaterial) { }
        private System.Void ON_TEXT_STYLE_PROPERTY_CHANGED(System.Boolean isChanged) { }
        private System.Void ON_COLOR_GRADIENT_PROPERTY_CHANGED(UnityEngine.Object obj) { }
        private System.Void ON_TEXT_CHANGED(UnityEngine.Object obj) { }
        private System.Void ON_TMP_SETTINGS_CHANGED() { }
        private System.Void ON_RESOURCES_LOADED() { }
        private System.Void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(System.Boolean isChanged, UnityEngine.Object obj) { }
        private System.Void ON_COMPUTE_DT_EVENT(System.Object Sender, TMPro.Compute_DT_EventArgs e) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000014
    public class Compute_DT_EventArgs
    {
        // Fields
        public TMPro.Compute_DistanceTransform_EventTypes EventType;        // 0x10
        public System.Single ProgressPercentage;        // 0x14
        public UnityEngine.Color[] Colors;        // 0x18

        // Methods
        private System.Void .ctor(TMPro.Compute_DistanceTransform_EventTypes type, System.Single progress) { }
        private System.Void .ctor(TMPro.Compute_DistanceTransform_EventTypes type, UnityEngine.Color[] colors) { }

    }

    // TypeToken: 0x2000015
    public class TMPro_ExtensionMethods
    {
        // Methods
        private System.Int32[] ToIntArray(System.String text) { }
        private System.String ArrayToString(System.Char[] chars) { }
        private System.String IntToString(System.Int32[] unicodes) { }
        private System.String UintToString(System.Collections.Generic.List<System.UInt32> unicodes) { }
        private System.String IntToString(System.Int32[] unicodes, System.Int32 start, System.Int32 length) { }
        private System.Int32 FindInstanceID(System.Collections.Generic.List<T> list, T target) { }
        private System.Boolean Compare(UnityEngine.Color32 a, UnityEngine.Color32 b) { }
        private System.Boolean CompareRGB(UnityEngine.Color32 a, UnityEngine.Color32 b) { }
        private System.Boolean Compare(UnityEngine.Color a, UnityEngine.Color b) { }
        private System.Boolean CompareRGB(UnityEngine.Color a, UnityEngine.Color b) { }
        private UnityEngine.Color32 Multiply(UnityEngine.Color32 c1, UnityEngine.Color32 c2) { }
        private UnityEngine.Color32 Tint(UnityEngine.Color32 c1, UnityEngine.Color32 c2) { }
        private UnityEngine.Color32 Tint(UnityEngine.Color32 c1, System.Single tint) { }
        private UnityEngine.Color MinAlpha(UnityEngine.Color c1, UnityEngine.Color c2) { }
        private System.Boolean Compare(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, System.Int32 accuracy) { }
        private System.Boolean Compare(UnityEngine.Quaternion q1, UnityEngine.Quaternion q2, System.Int32 accuracy) { }

    }

    // TypeToken: 0x2000016
    public class TMP_Math
    {
        // Fields
        public static System.Single FLOAT_MAX;        // 0x0
        public static System.Single FLOAT_MIN;        // 0x0
        public static System.Int32 INT_MAX;        // 0x0
        public static System.Int32 INT_MIN;        // 0x0
        public static System.Single FLOAT_UNSET;        // 0x0
        public static System.Int32 INT_UNSET;        // 0x0
        public static UnityEngine.Vector2 MAX_16BIT;        // 0x0
        public static UnityEngine.Vector2 MIN_16BIT;        // 0x8

        // Methods
        private System.Boolean Approximately(System.Single a, System.Single b) { }
        private System.Int32 Mod(System.Int32 a, System.Int32 b) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000017
    public struct TMP_VertexDataUpdateFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.TMP_VertexDataUpdateFlags None;        // 0x0
        public static TMPro.TMP_VertexDataUpdateFlags Vertices;        // 0x0
        public static TMPro.TMP_VertexDataUpdateFlags Uv0;        // 0x0
        public static TMPro.TMP_VertexDataUpdateFlags Uv2;        // 0x0
        public static TMPro.TMP_VertexDataUpdateFlags Uv4;        // 0x0
        public static TMPro.TMP_VertexDataUpdateFlags Colors32;        // 0x0
        public static TMPro.TMP_VertexDataUpdateFlags All;        // 0x0

    }

    // TypeToken: 0x2000018
    public struct VertexGradient
    {
        // Fields
        public UnityEngine.Color topLeft;        // 0x10
        public UnityEngine.Color topRight;        // 0x20
        public UnityEngine.Color bottomLeft;        // 0x30
        public UnityEngine.Color bottomRight;        // 0x40

        // Methods
        private System.Void .ctor(UnityEngine.Color color) { }
        private System.Void .ctor(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3) { }

    }

    // TypeToken: 0x2000019
    public struct TMP_PageInfo
    {
        // Fields
        public System.Int32 firstCharacterIndex;        // 0x10
        public System.Int32 lastCharacterIndex;        // 0x14
        public System.Single ascender;        // 0x18
        public System.Single baseLine;        // 0x1C
        public System.Single descender;        // 0x20

    }

    // TypeToken: 0x200001A
    public struct TMP_LinkInfo
    {
        // Fields
        public TMPro.TMP_Text textComponent;        // 0x10
        public System.Int32 hashCode;        // 0x18
        public System.Int32 linkIdFirstCharacterIndex;        // 0x1C
        public System.Int32 linkIdLength;        // 0x20
        public System.Int32 linkTextfirstCharacterIndex;        // 0x24
        public System.Int32 linkTextLength;        // 0x28
        private System.Char[] linkID;        // 0x30

        // Methods
        private System.Void SetLinkID(System.Char[] text, System.Int32 startIndex, System.Int32 length) { }
        private System.String GetLinkText() { }
        private System.String GetLinkID() { }

    }

    // TypeToken: 0x200001B
    public struct TMP_WordInfo
    {
        // Fields
        public TMPro.TMP_Text textComponent;        // 0x10
        public System.Int32 firstCharacterIndex;        // 0x18
        public System.Int32 lastCharacterIndex;        // 0x1C
        public System.Int32 characterCount;        // 0x20

        // Methods
        private System.String GetWord() { }

    }

    // TypeToken: 0x200001C
    public struct TMP_SpriteInfo
    {
        // Fields
        public System.Int32 spriteIndex;        // 0x10
        public System.Int32 characterIndex;        // 0x14
        public System.Int32 vertexIndex;        // 0x18

    }

    // TypeToken: 0x200001D
    public struct Extents
    {
        // Fields
        private static TMPro.Extents zero;        // 0x0
        private static TMPro.Extents uninitialized;        // 0x10
        public UnityEngine.Vector2 min;        // 0x10
        public UnityEngine.Vector2 max;        // 0x18

        // Methods
        private System.Void .ctor(UnityEngine.Vector2 min, UnityEngine.Vector2 max) { }
        private System.String ToString() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200001E
    public struct Mesh_Extents
    {
        // Fields
        public UnityEngine.Vector2 min;        // 0x10
        public UnityEngine.Vector2 max;        // 0x18

        // Methods
        private System.Void .ctor(UnityEngine.Vector2 min, UnityEngine.Vector2 max) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200001F
    public struct WordWrapState
    {
        // Fields
        public System.Int32 previous_WordBreak;        // 0x10
        public System.Int32 total_CharacterCount;        // 0x14
        public System.Int32 visible_CharacterCount;        // 0x18
        public System.Int32 visible_SpriteCount;        // 0x1C
        public System.Int32 visible_LinkCount;        // 0x20
        public System.Int32 firstCharacterIndex;        // 0x24
        public System.Int32 firstVisibleCharacterIndex;        // 0x28
        public System.Int32 lastCharacterIndex;        // 0x2C
        public System.Int32 lastVisibleCharIndex;        // 0x30
        public System.Int32 lineNumber;        // 0x34
        public System.Single maxCapHeight;        // 0x38
        public System.Single maxAscender;        // 0x3C
        public System.Single maxLineAscenderWithOutImage;        // 0x40
        public System.Single maxDescender;        // 0x44
        public System.Single startOfLineAscender;        // 0x48
        public System.Single maxLineAscender;        // 0x4C
        public System.Single maxLineDescender;        // 0x50
        public System.Single pageAscender;        // 0x54
        public TMPro.HorizontalAlignmentOptions horizontalAlignment;        // 0x58
        public System.Single marginLeft;        // 0x5C
        public System.Single marginRight;        // 0x60
        public System.Single xAdvance;        // 0x64
        public System.Single preferredWidth;        // 0x68
        public System.Single preferredHeight;        // 0x6C
        public System.Single previousLineScale;        // 0x70
        public System.Int32 wordCount;        // 0x74
        public TMPro.FontStyles fontStyle;        // 0x78
        public System.Int32 italicAngle;        // 0x7C
        public System.Single fontScaleMultiplier;        // 0x80
        public System.Single currentFontSize;        // 0x84
        public System.Single baselineOffset;        // 0x88
        public System.Single lineOffset;        // 0x8C
        public System.Boolean isDrivenLineSpacing;        // 0x90
        public System.Single glyphHorizontalAdvanceAdjustment;        // 0x94
        public System.Single cSpace;        // 0x98
        public System.Single mSpace;        // 0x9C
        public TMPro.TMP_TextInfo textInfo;        // 0xA0
        public TMPro.TMP_LineInfo lineInfo;        // 0xA8
        public UnityEngine.Color32 vertexColor;        // 0x104
        public UnityEngine.Color32 underlineColor;        // 0x108
        public UnityEngine.Color32 strikethroughColor;        // 0x10C
        public UnityEngine.Color32 highlightColor;        // 0x110
        public TMPro.TMP_FontStyleStack basicStyleStack;        // 0x114
        public TMPro.TMP_TextProcessingStack<System.Int32> italicAngleStack;        // 0x120
        public TMPro.TMP_TextProcessingStack<UnityEngine.Color32> colorStack;        // 0x140
        public TMPro.TMP_TextProcessingStack<UnityEngine.Color32> underlineColorStack;        // 0x160
        public TMPro.TMP_TextProcessingStack<UnityEngine.Color32> strikethroughColorStack;        // 0x180
        public TMPro.TMP_TextProcessingStack<UnityEngine.Color32> highlightColorStack;        // 0x1A0
        public TMPro.TMP_TextProcessingStack<TMPro.HighlightState> highlightStateStack;        // 0x1C0
        public TMPro.TMP_TextProcessingStack<TMPro.TMP_ColorGradient> colorGradientStack;        // 0x1F0
        public TMPro.TMP_TextProcessingStack<System.Single> sizeStack;        // 0x218
        public TMPro.TMP_TextProcessingStack<System.Single> indentStack;        // 0x238
        public TMPro.TMP_TextProcessingStack<TMPro.FontWeight> fontWeightStack;        // 0x258
        public TMPro.TMP_TextProcessingStack<System.Int32> styleStack;        // 0x278
        public TMPro.TMP_TextProcessingStack<System.Single> baselineStack;        // 0x298
        public TMPro.TMP_TextProcessingStack<System.Int32> actionStack;        // 0x2B8
        public TMPro.TMP_TextProcessingStack<TMPro.MaterialReference> materialReferenceStack;        // 0x2D8
        public TMPro.TMP_TextProcessingStack<TMPro.HorizontalAlignmentOptions> lineJustificationStack;        // 0x330
        public TMPro.TMP_TextProcessingQueue<TMPro.PhoneticData> phoneticQueue;        // 0x350
        public System.Int32 spriteAnimationID;        // 0x370
        public TMPro.TMP_FontAsset currentFontAsset;        // 0x378
        public TMPro.TMP_SpriteAsset currentSpriteAsset;        // 0x380
        public UnityEngine.Material currentMaterial;        // 0x388
        public System.Int32 currentMaterialIndex;        // 0x390
        public TMPro.Extents meshExtents;        // 0x394
        public System.Boolean tagNoParsing;        // 0x3A4
        public System.Boolean isNonBreakingSpace;        // 0x3A5

    }

    // TypeToken: 0x2000020
    public struct TagAttribute
    {
        // Fields
        public System.Int32 startIndex;        // 0x10
        public System.Int32 length;        // 0x14
        public System.Int32 hashCode;        // 0x18

    }

    // TypeToken: 0x2000021
    public struct RichTextTagAttribute
    {
        // Fields
        public System.Int32 nameHashCode;        // 0x10
        public System.Int32 valueHashCode;        // 0x14
        public TMPro.TagValueType valueType;        // 0x18
        public System.Int32 valueStartIndex;        // 0x1C
        public System.Int32 valueLength;        // 0x20
        public TMPro.TagUnitType unitType;        // 0x24

    }

    // TypeToken: 0x2000022
    public class TMP_ArrayObjectPool`1
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Stack<T[]>> m_StackDic;        // 0x0
        private readonly UnityEngine.Events.UnityAction<T[]> m_ActionOnGet;        // 0x0
        private readonly UnityEngine.Events.UnityAction<T[]> m_ActionOnRelease;        // 0x0
        private System.Int32 <countAll>k__BackingField;        // 0x0

        // Methods
        private System.Int32 get_countAll() { }
        private System.Void set_countAll(System.Int32 value) { }
        private System.Int32 get_countActive() { }
        private System.Int32 get_countInactive() { }
        private System.Void .ctor(UnityEngine.Events.UnityAction<T[]> actionOnGet, UnityEngine.Events.UnityAction<T[]> actionOnRelease) { }
        private T[] Get(System.Int32 count) { }
        private System.Void Release(System.Int32 count, T[] element) { }

    }

    // TypeToken: 0x2000023
    public class TMP_ArrayPool`1
    {
        // Fields
        private static readonly TMPro.TMP_ArrayObjectPool<T> s_ArrayPool;        // 0x0

        // Methods
        private T[] Get(System.Int32 count) { }
        private System.Void Release(T[] toRelease) { }
        private System.Void Resize(T[]& array, System.Int32 newCount) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000025
    public class TMP_Asset : ScriptableObject
    {
        // Fields
        private System.Int32 m_InstanceID;        // 0x18
        public System.Int32 hashCode;        // 0x1C
        public UnityEngine.Material material;        // 0x20
        public System.Int32 materialHashCode;        // 0x28

        // Methods
        private System.Int32 get_instanceID() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000026
    public class TMP_Character : TMP_TextElement
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.UInt32 unicode, UnityEngine.TextCore.Glyph glyph) { }
        private System.Void .ctor(System.UInt32 unicode, TMPro.TMP_FontAsset fontAsset, UnityEngine.TextCore.Glyph glyph) { }
        private System.Void .ctor(System.UInt32 unicode, System.UInt32 glyphIndex) { }

    }

    // TypeToken: 0x2000027
    public struct TMP_Vertex
    {
        // Fields
        public UnityEngine.Vector3 position;        // 0x10
        public UnityEngine.Vector2 uv;        // 0x1C
        public UnityEngine.Vector2 uv2;        // 0x24
        public UnityEngine.Vector2 uv4;        // 0x2C
        public UnityEngine.Color32 color;        // 0x34
        private static readonly TMPro.TMP_Vertex k_Zero;        // 0x0

        // Methods
        private TMPro.TMP_Vertex get_zero() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000028
    public struct TMP_Offset
    {
        // Fields
        private System.Single m_Left;        // 0x10
        private System.Single m_Right;        // 0x14
        private System.Single m_Top;        // 0x18
        private System.Single m_Bottom;        // 0x1C
        private static readonly TMPro.TMP_Offset k_ZeroOffset;        // 0x0

        // Methods
        private System.Single get_left() { }
        private System.Void set_left(System.Single value) { }
        private System.Single get_right() { }
        private System.Void set_right(System.Single value) { }
        private System.Single get_top() { }
        private System.Void set_top(System.Single value) { }
        private System.Single get_bottom() { }
        private System.Void set_bottom(System.Single value) { }
        private System.Single get_horizontal() { }
        private System.Void set_horizontal(System.Single value) { }
        private System.Single get_vertical() { }
        private System.Void set_vertical(System.Single value) { }
        private TMPro.TMP_Offset get_zero() { }
        private System.Void .ctor(System.Single left, System.Single right, System.Single top, System.Single bottom) { }
        private System.Void .ctor(System.Single horizontal, System.Single vertical) { }
        private System.Boolean op_Equality(TMPro.TMP_Offset lhs, TMPro.TMP_Offset rhs) { }
        private System.Boolean op_Inequality(TMPro.TMP_Offset lhs, TMPro.TMP_Offset rhs) { }
        private TMPro.TMP_Offset op_Multiply(TMPro.TMP_Offset a, System.Single b) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(TMPro.TMP_Offset other) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000029
    public struct HighlightState
    {
        // Fields
        public UnityEngine.Color32 color;        // 0x10
        public TMPro.TMP_Offset padding;        // 0x14

        // Methods
        private System.Void .ctor(UnityEngine.Color32 color, TMPro.TMP_Offset padding) { }
        private System.Boolean op_Equality(TMPro.HighlightState lhs, TMPro.HighlightState rhs) { }
        private System.Boolean op_Inequality(TMPro.HighlightState lhs, TMPro.HighlightState rhs) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(TMPro.HighlightState other) { }

    }

    // TypeToken: 0x200002A
    public struct TMP_CharacterInfo
    {
        // Fields
        public System.Char character;        // 0x10
        public System.Int32 index;        // 0x14
        public System.Int32 stringLength;        // 0x18
        public TMPro.TMP_TextElementType elementType;        // 0x1C
        public TMPro.TMP_TextElement textElement;        // 0x20
        public TMPro.TMP_FontAsset fontAsset;        // 0x28
        public TMPro.TMP_SpriteAsset spriteAsset;        // 0x30
        public System.Int32 spriteIndex;        // 0x38
        public UnityEngine.Material material;        // 0x40
        public System.Int32 materialReferenceIndex;        // 0x48
        public System.Boolean isUsingAlternateTypeface;        // 0x4C
        public System.Single pointSize;        // 0x50
        public System.Int32 lineNumber;        // 0x54
        public System.Int32 pageNumber;        // 0x58
        public System.Int32 vertexIndex;        // 0x5C
        public TMPro.TMP_Vertex vertex_BL;        // 0x60
        public TMPro.TMP_Vertex vertex_TL;        // 0x88
        public TMPro.TMP_Vertex vertex_TR;        // 0xB0
        public TMPro.TMP_Vertex vertex_BR;        // 0xD8
        public UnityEngine.Vector3 topLeft;        // 0x100
        public UnityEngine.Vector3 bottomLeft;        // 0x10C
        public UnityEngine.Vector3 topRight;        // 0x118
        public UnityEngine.Vector3 bottomRight;        // 0x124
        public System.Single origin;        // 0x130
        public System.Single xAdvance;        // 0x134
        public System.Single ascender;        // 0x138
        public System.Single baseLine;        // 0x13C
        public System.Single descender;        // 0x140
        public System.Single adjustedAscender;        // 0x144
        public System.Single adjustedDescender;        // 0x148
        public System.Single aspectRatio;        // 0x14C
        public System.Single scale;        // 0x150
        public UnityEngine.Color32 color;        // 0x154
        public UnityEngine.Color32 underlineColor;        // 0x158
        public System.Int32 underlineVertexIndex;        // 0x15C
        public UnityEngine.Color32 strikethroughColor;        // 0x160
        public System.Int32 strikethroughVertexIndex;        // 0x164
        public UnityEngine.Color32 highlightColor;        // 0x168
        public TMPro.HighlightState highlightState;        // 0x16C
        public TMPro.FontStyles style;        // 0x180
        public System.Boolean isVisible;        // 0x184

    }

    // TypeToken: 0x200002B
    public struct ColorMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.ColorMode Single;        // 0x0
        public static TMPro.ColorMode HorizontalGradient;        // 0x0
        public static TMPro.ColorMode VerticalGradient;        // 0x0
        public static TMPro.ColorMode FourCornersGradient;        // 0x0

    }

    // TypeToken: 0x200002C
    public class TMP_ColorGradient : ScriptableObject
    {
        // Fields
        public TMPro.ColorMode colorMode;        // 0x18
        public UnityEngine.Color topLeft;        // 0x1C
        public UnityEngine.Color topRight;        // 0x2C
        public UnityEngine.Color bottomLeft;        // 0x3C
        public UnityEngine.Color bottomRight;        // 0x4C
        private static TMPro.ColorMode k_DefaultColorMode;        // 0x0
        private static readonly UnityEngine.Color k_DefaultColor;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.Color color) { }
        private System.Void .ctor(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200002D
    public class TMP_Compatibility
    {
        // Methods
        private TMPro.TextAlignmentOptions ConvertTextAlignmentEnumValues(TMPro.TextAlignmentOptions oldValue) { }

    }

    // TypeToken: 0x200002F
    public interface ITweenValue
    {
        // Methods
        private System.Void TweenValue(System.Single floatPercentage) { }
        private System.Boolean get_ignoreTimeScale() { }
        private System.Single get_duration() { }
        private System.Boolean ValidTarget() { }

    }

    // TypeToken: 0x2000030
    public struct ColorTween, ITweenValue
    {
        // Fields
        private TMPro.ColorTween.ColorTweenCallback m_Target;        // 0x10
        private UnityEngine.Color m_StartColor;        // 0x18
        private UnityEngine.Color m_TargetColor;        // 0x28
        private TMPro.ColorTween.ColorTweenMode m_TweenMode;        // 0x38
        private System.Single m_Duration;        // 0x3C
        private System.Boolean m_IgnoreTimeScale;        // 0x40

        // Methods
        private UnityEngine.Color get_startColor() { }
        private System.Void set_startColor(UnityEngine.Color value) { }
        private UnityEngine.Color get_targetColor() { }
        private System.Void set_targetColor(UnityEngine.Color value) { }
        private TMPro.ColorTween.ColorTweenMode get_tweenMode() { }
        private System.Void set_tweenMode(TMPro.ColorTween.ColorTweenMode value) { }
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

    // TypeToken: 0x2000033
    public struct FloatTween, ITweenValue
    {
        // Fields
        private TMPro.FloatTween.FloatTweenCallback m_Target;        // 0x10
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

    // TypeToken: 0x2000035
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

    // TypeToken: 0x2000037
    public class TMP_DefaultControls
    {
        // Fields
        private static System.Single kWidth;        // 0x0
        private static System.Single kThickHeight;        // 0x0
        private static System.Single kThinHeight;        // 0x0
        private static UnityEngine.Vector2 s_TextElementSize;        // 0x0
        private static UnityEngine.Vector2 s_ThickElementSize;        // 0x8
        private static UnityEngine.Vector2 s_ThinElementSize;        // 0x10
        private static UnityEngine.Color s_DefaultSelectableColor;        // 0x18
        private static UnityEngine.Color s_TextColor;        // 0x28

        // Methods
        private UnityEngine.GameObject CreateUIElementRoot(System.String name, UnityEngine.Vector2 size) { }
        private UnityEngine.GameObject CreateUIObject(System.String name, UnityEngine.GameObject parent) { }
        private System.Void SetDefaultTextValues(TMPro.TMP_Text lbl) { }
        private System.Void SetDefaultColorTransitionValues(UnityEngine.UI.Selectable slider) { }
        private System.Void SetParentAndAlign(UnityEngine.GameObject child, UnityEngine.GameObject parent) { }
        private System.Void SetLayerRecursively(UnityEngine.GameObject go, System.Int32 layer) { }
        private UnityEngine.GameObject CreateScrollbar(TMPro.TMP_DefaultControls.Resources resources) { }
        private UnityEngine.GameObject CreateButton(TMPro.TMP_DefaultControls.Resources resources) { }
        private UnityEngine.GameObject CreateText(TMPro.TMP_DefaultControls.Resources resources) { }
        private UnityEngine.GameObject CreateInputField(TMPro.TMP_DefaultControls.Resources resources) { }
        private UnityEngine.GameObject CreateDropdown(TMPro.TMP_DefaultControls.Resources resources) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000039
    public class TMP_Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler
    {
        // Fields
        private UnityEngine.RectTransform m_Template;        // 0x180
        private TMPro.TMP_Text m_CaptionText;        // 0x188
        private UnityEngine.UI.Image m_CaptionImage;        // 0x190
        private UnityEngine.UI.Graphic m_Placeholder;        // 0x198
        private TMPro.TMP_Text m_ItemText;        // 0x1A0
        private UnityEngine.UI.Image m_ItemImage;        // 0x1A8
        private System.Int32 m_Value;        // 0x1B0
        private TMPro.TMP_Dropdown.OptionDataList m_Options;        // 0x1B8
        private TMPro.TMP_Dropdown.DropdownEvent m_OnValueChanged;        // 0x1C0
        private System.Single m_AlphaFadeSpeed;        // 0x1C8
        private UnityEngine.GameObject m_Dropdown;        // 0x1D0
        private UnityEngine.GameObject m_Blocker;        // 0x1D8
        private System.Collections.Generic.List<TMPro.TMP_Dropdown.DropdownItem> m_Items;        // 0x1E0
        private TMPro.TweenRunner<TMPro.FloatTween> m_AlphaTweenRunner;        // 0x1E8
        private System.Boolean validTemplate;        // 0x1F0
        private UnityEngine.Coroutine m_Coroutine;        // 0x1F8
        private static TMPro.TMP_Dropdown.OptionData s_NoOptionData;        // 0x0

        // Methods
        private UnityEngine.RectTransform get_template() { }
        private System.Void set_template(UnityEngine.RectTransform value) { }
        private TMPro.TMP_Text get_captionText() { }
        private System.Void set_captionText(TMPro.TMP_Text value) { }
        private UnityEngine.UI.Image get_captionImage() { }
        private System.Void set_captionImage(UnityEngine.UI.Image value) { }
        private UnityEngine.UI.Graphic get_placeholder() { }
        private System.Void set_placeholder(UnityEngine.UI.Graphic value) { }
        private TMPro.TMP_Text get_itemText() { }
        private System.Void set_itemText(TMPro.TMP_Text value) { }
        private UnityEngine.UI.Image get_itemImage() { }
        private System.Void set_itemImage(UnityEngine.UI.Image value) { }
        private System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> get_options() { }
        private System.Void set_options(System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> value) { }
        private TMPro.TMP_Dropdown.DropdownEvent get_onValueChanged() { }
        private System.Void set_onValueChanged(TMPro.TMP_Dropdown.DropdownEvent value) { }
        private System.Single get_alphaFadeSpeed() { }
        private System.Void set_alphaFadeSpeed(System.Single value) { }
        private System.Int32 get_value() { }
        private System.Void set_value(System.Int32 value) { }
        private System.Void SetValueWithoutNotify(System.Int32 input) { }
        private System.Void SetValue(System.Int32 value, System.Boolean sendCallback) { }
        private System.Boolean get_IsExpanded() { }
        private System.Void .ctor() { }
        private System.Void Awake() { }
        private System.Void Start() { }
        private System.Void OnDisable() { }
        private System.Void RefreshShownValue() { }
        private System.Void AddOptions(System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> options) { }
        private System.Void AddOptions(System.Collections.Generic.List<System.String> options) { }
        private System.Void AddOptions(System.Collections.Generic.List<UnityEngine.Sprite> options) { }
        private System.Void ClearOptions() { }
        private System.Void SetupTemplate() { }
        private T GetOrAddComponent(UnityEngine.GameObject go) { }
        private System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void OnCancel(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void Show() { }
        private UnityEngine.GameObject CreateBlocker(UnityEngine.Canvas rootCanvas) { }
        private System.Void DestroyBlocker(UnityEngine.GameObject blocker) { }
        private UnityEngine.GameObject CreateDropdownList(UnityEngine.GameObject template) { }
        private System.Void DestroyDropdownList(UnityEngine.GameObject dropdownList) { }
        private TMPro.TMP_Dropdown.DropdownItem CreateItem(TMPro.TMP_Dropdown.DropdownItem itemTemplate) { }
        private System.Void DestroyItem(TMPro.TMP_Dropdown.DropdownItem item) { }
        private TMPro.TMP_Dropdown.DropdownItem AddItem(TMPro.TMP_Dropdown.OptionData data, System.Boolean selected, TMPro.TMP_Dropdown.DropdownItem itemTemplate, System.Collections.Generic.List<TMPro.TMP_Dropdown.DropdownItem> items) { }
        private System.Void AlphaFadeList(System.Single duration, System.Single alpha) { }
        private System.Void AlphaFadeList(System.Single duration, System.Single start, System.Single end) { }
        private System.Void SetAlpha(System.Single alpha) { }
        private System.Void Hide() { }
        private System.Collections.IEnumerator DelayedDestroyDropdownList(System.Single delay) { }
        private System.Void ImmediateDestroyDropdownList() { }
        private System.Void OnSelectItem(UnityEngine.UI.Toggle toggle) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000040
    public struct AtlasPopulationMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.AtlasPopulationMode Static;        // 0x0
        public static TMPro.AtlasPopulationMode Dynamic;        // 0x0

    }

    // TypeToken: 0x2000041
    public class TMP_FontAsset : TMP_Asset
    {
        // Fields
        private System.String m_Version;        // 0x30
        private System.String m_SourceFontFileGUID;        // 0x38
        private UnityEngine.Font m_SourceFontFile;        // 0x40
        private System.Single m_ThaiBiasConsonantsValue;        // 0x48
        private System.String m_prefixMaterialSearchPatternValue;        // 0x50
        private TMPro.AtlasPopulationMode m_AtlasPopulationMode;        // 0x58
        public UnityEngine.TextCore.FaceInfo m_FaceInfo;        // 0x60
        private System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphTable;        // 0xC0
        private System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Glyph> m_GlyphLookupDictionary;        // 0xC8
        private System.Collections.Generic.List<TMPro.TMP_Character> m_CharacterTable;        // 0xD0
        public System.Collections.Generic.Dictionary<System.UInt32,TMPro.TMP_Character> m_CharacterLookupDictionary;        // 0xD8
        private UnityEngine.Texture2D m_AtlasTexture;        // 0xE0
        private UnityEngine.Texture2D[] m_AtlasTextures;        // 0xE8
        private System.Int32 m_AtlasTextureIndex;        // 0xF0
        private System.Boolean m_IsMultiAtlasTexturesEnabled;        // 0xF4
        private System.Boolean m_ClearDynamicDataOnBuild;        // 0xF5
        private System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> m_UsedGlyphRects;        // 0xF8
        private System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> m_FreeGlyphRects;        // 0x100
        private TMPro.FaceInfo_Legacy m_fontInfo;        // 0x108
        public UnityEngine.Texture2D atlas;        // 0x110
        private System.Int32 m_AtlasWidth;        // 0x118
        private System.Int32 m_AtlasHeight;        // 0x11C
        private System.Int32 m_AtlasPadding;        // 0x120
        private UnityEngine.TextCore.LowLevel.GlyphRenderMode m_AtlasRenderMode;        // 0x124
        private System.Collections.Generic.List<TMPro.TMP_Glyph> m_glyphInfoList;        // 0x128
        private TMPro.KerningTable m_KerningTable;        // 0x130
        public TMPro.TMP_FontFeatureTable m_FontFeatureTable;        // 0x138
        private System.Collections.Generic.List<TMPro.TMP_FontAsset> fallbackFontAssets;        // 0x140
        private System.Collections.Generic.List<TMPro.TMP_FontAsset> m_FallbackFontAssetTable;        // 0x148
        private TMPro.FontAssetCreationSettings m_CreationSettings;        // 0x150
        private TMPro.TMP_FontWeightPair[] m_FontWeightTable;        // 0x1A8
        private TMPro.TMP_FontWeightPair[] fontWeights;        // 0x1B0
        public System.Single normalStyle;        // 0x1B8
        public System.Single normalSpacingOffset;        // 0x1BC
        public System.Single boldStyle;        // 0x1C0
        public System.Single boldSpacing;        // 0x1C4
        public System.Byte italicStyle;        // 0x1C8
        public System.Byte tabSize;        // 0x1C9
        public System.Boolean isUsedBySoftLink;        // 0x1CA
        private System.Boolean IsFontAssetLookupTablesDirty;        // 0x1CB
        private static Unity.Profiling.ProfilerMarker k_ReadFontAssetDefinitionMarker;        // 0x0
        private static Unity.Profiling.ProfilerMarker k_AddSynthesizedCharactersMarker;        // 0x8
        private static Unity.Profiling.ProfilerMarker<System.UInt32> k_TryAddCharacterMarker;        // 0x10
        private static Unity.Profiling.ProfilerMarker k_TryAddCharactersMarker;        // 0x18
        private static Unity.Profiling.ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker;        // 0x20
        private static Unity.Profiling.ProfilerMarker k_ClearFontAssetDataMarker;        // 0x28
        private static Unity.Profiling.ProfilerMarker k_UpdateFontAssetDataMarker;        // 0x30
        private static System.String s_DefaultMaterialSuffix;        // 0x38
        private System.Collections.Generic.HashSet<System.Int32> FallbackSearchQueryLookup;        // 0x1D0
        private static System.Collections.Generic.HashSet<System.Int32> k_SearchedFontAssetLookup;        // 0x40
        private static System.Collections.Generic.List<TMPro.TMP_FontAsset> k_FontAssets_FontFeaturesUpdateQueue;        // 0x48
        private static System.Collections.Generic.HashSet<System.Int32> k_FontAssets_FontFeaturesUpdateQueueLookup;        // 0x50
        private static System.Collections.Generic.List<TMPro.TMP_FontAsset> k_FontAssets_AtlasTexturesUpdateQueue;        // 0x58
        private static System.Collections.Generic.HashSet<System.Int32> k_FontAssets_AtlasTexturesUpdateQueueLookup;        // 0x60
        private System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphsToRender;        // 0x1D8
        private System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphsRendered;        // 0x1E0
        private System.Collections.Generic.List<System.UInt32> m_GlyphIndexList;        // 0x1E8
        private System.Collections.Generic.List<System.UInt32> m_GlyphIndexListNewlyAdded;        // 0x1F0
        private System.Collections.Generic.List<System.UInt32> m_GlyphsToAdd;        // 0x1F8
        private System.Collections.Generic.HashSet<System.UInt32> m_GlyphsToAddLookup;        // 0x200
        private System.Collections.Generic.List<TMPro.TMP_Character> m_CharactersToAdd;        // 0x208
        private System.Collections.Generic.HashSet<System.UInt32> m_CharactersToAddLookup;        // 0x210
        private System.Collections.Generic.List<System.UInt32> s_MissingCharacterList;        // 0x218
        private System.Collections.Generic.HashSet<System.UInt32> m_MissingUnicodesFromFontFile;        // 0x220
        private static System.UInt32[] k_GlyphIndexArray;        // 0x68

        // Methods
        private System.String get_version() { }
        private System.Void set_version(System.String value) { }
        private UnityEngine.Font get_sourceFontFile() { }
        private System.Void set_sourceFontFile(UnityEngine.Font value) { }
        private System.Single get_thaiBiasConsonantsValue() { }
        private System.Void set_thaiBiasConsonantsValue(System.Single value) { }
        private System.String get_prefixMaterialSearchPatternValue() { }
        private System.Void set_prefixMaterialSearchPatternValue(System.String value) { }
        private TMPro.AtlasPopulationMode get_atlasPopulationMode() { }
        private System.Void set_atlasPopulationMode(TMPro.AtlasPopulationMode value) { }
        private UnityEngine.TextCore.FaceInfo get_faceInfo() { }
        private System.Void set_faceInfo(UnityEngine.TextCore.FaceInfo value) { }
        private System.Collections.Generic.List<UnityEngine.TextCore.Glyph> get_glyphTable() { }
        private System.Void set_glyphTable(System.Collections.Generic.List<UnityEngine.TextCore.Glyph> value) { }
        private System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Glyph> get_glyphLookupTable() { }
        private System.Collections.Generic.List<TMPro.TMP_Character> get_characterTable() { }
        private System.Void set_characterTable(System.Collections.Generic.List<TMPro.TMP_Character> value) { }
        private System.Collections.Generic.Dictionary<System.UInt32,TMPro.TMP_Character> get_characterLookupTable() { }
        private UnityEngine.Texture2D get_atlasTexture() { }
        private UnityEngine.Texture2D[] get_atlasTextures() { }
        private System.Void set_atlasTextures(UnityEngine.Texture2D[] value) { }
        private System.Int32 get_atlasTextureCount() { }
        private System.Boolean get_isMultiAtlasTexturesEnabled() { }
        private System.Void set_isMultiAtlasTexturesEnabled(System.Boolean value) { }
        private System.Boolean get_clearDynamicDataOnBuild() { }
        private System.Void set_clearDynamicDataOnBuild(System.Boolean value) { }
        private System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> get_usedGlyphRects() { }
        private System.Void set_usedGlyphRects(System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> value) { }
        private System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> get_freeGlyphRects() { }
        private System.Void set_freeGlyphRects(System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> value) { }
        private TMPro.FaceInfo_Legacy get_fontInfo() { }
        private System.Int32 get_atlasWidth() { }
        private System.Void set_atlasWidth(System.Int32 value) { }
        private System.Int32 get_atlasHeight() { }
        private System.Void set_atlasHeight(System.Int32 value) { }
        private System.Int32 get_atlasPadding() { }
        private System.Void set_atlasPadding(System.Int32 value) { }
        private UnityEngine.TextCore.LowLevel.GlyphRenderMode get_atlasRenderMode() { }
        private System.Void set_atlasRenderMode(UnityEngine.TextCore.LowLevel.GlyphRenderMode value) { }
        private TMPro.TMP_FontFeatureTable get_fontFeatureTable() { }
        private System.Void set_fontFeatureTable(TMPro.TMP_FontFeatureTable value) { }
        private System.Collections.Generic.List<TMPro.TMP_FontAsset> get_fallbackFontAssetTable() { }
        private System.Void set_fallbackFontAssetTable(System.Collections.Generic.List<TMPro.TMP_FontAsset> value) { }
        private TMPro.FontAssetCreationSettings get_creationSettings() { }
        private System.Void set_creationSettings(TMPro.FontAssetCreationSettings value) { }
        private TMPro.TMP_FontWeightPair[] get_fontWeightTable() { }
        private System.Void set_fontWeightTable(TMPro.TMP_FontWeightPair[] value) { }
        private TMPro.TMP_FontAsset CreateFontAsset(UnityEngine.Font font) { }
        private TMPro.TMP_FontAsset CreateFontAsset(UnityEngine.Font font, System.Int32 samplingPointSize, System.Int32 atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, System.Int32 atlasWidth, System.Int32 atlasHeight, TMPro.AtlasPopulationMode atlasPopulationMode, System.Boolean enableMultiAtlasSupport) { }
        private System.Void Awake() { }
        private System.Void ReadFontAssetDefinition() { }
        private System.Void InitializeDictionaryLookupTables() { }
        private System.Void InitializeGlyphLookupDictionary() { }
        private System.Void InitializeCharacterLookupDictionary() { }
        private System.Void InitializeGlyphPaidAdjustmentRecordsLookupDictionary() { }
        private System.Void AddSynthesizedCharactersAndFaceMetrics() { }
        private System.Void AddSynthesizedCharacter(System.UInt32 unicode, System.Boolean isFontFaceLoaded, System.Boolean addImmediately) { }
        private System.Void AddCharacterToLookupCache(System.UInt32 unicode, TMPro.TMP_Character character) { }
        private System.Void SortCharacterTable() { }
        private System.Void SortGlyphTable() { }
        private System.Void SortFontFeatureTable() { }
        private System.Void SortAllTables() { }
        private System.Boolean HasCharacter(System.Int32 character) { }
        private System.Boolean HasCharacter(System.Char character, System.Boolean searchFallbacks, System.Boolean tryAddCharacter) { }
        private System.Boolean HasCharacter_Internal(System.UInt32 character, System.Boolean searchFallbacks, System.Boolean tryAddCharacter) { }
        private System.Boolean HasCharacters(System.String text, System.Collections.Generic.List<System.Char>& missingCharacters) { }
        private System.Boolean HasCharacters(System.String text, System.UInt32[]& missingCharacters, System.Boolean searchFallbacks, System.Boolean tryAddCharacter) { }
        private System.Boolean HasCharacters(System.String text) { }
        private System.String GetCharacters(TMPro.TMP_FontAsset fontAsset) { }
        private System.Int32[] GetCharactersArray(TMPro.TMP_FontAsset fontAsset) { }
        private System.UInt32 GetGlyphIndex(System.UInt32 unicode) { }
        private System.Void RegisterFontAssetForFontFeatureUpdate(TMPro.TMP_FontAsset fontAsset) { }
        private System.Void UpdateFontFeaturesForFontAssetsInQueue() { }
        private System.Void RegisterFontAssetForAtlasTextureUpdate(TMPro.TMP_FontAsset fontAsset) { }
        private System.Void UpdateAtlasTexturesForFontAssetsInQueue() { }
        private System.Boolean TryAddCharacters(System.UInt32[] unicodes, System.Boolean includeFontFeatures) { }
        private System.Boolean TryAddCharacters(System.UInt32[] unicodes, System.UInt32[]& missingUnicodes, System.Boolean includeFontFeatures) { }
        private System.Boolean TryAddCharacters(System.String characters, System.Boolean includeFontFeatures) { }
        private System.Boolean TryAddCharacters(System.String characters, System.String& missingCharacters, System.Boolean includeFontFeatures) { }
        private System.Void AddCharacters(System.String characters) { }
        private System.Boolean TryAddCharacterInternal(System.UInt32 unicode, TMPro.TMP_Character& character) { }
        private System.Boolean TryGetCharacter_and_QueueRenderToTexture(System.UInt32 unicode, TMPro.TMP_Character& character) { }
        private System.Void TryAddGlyphsToAtlasTextures() { }
        private System.Boolean TryAddGlyphsToNewAtlasTexture() { }
        private System.Void SetupNewAtlasTexture() { }
        private System.Void UpdateAtlasTexture() { }
        private System.Void UpdateGlyphAdjustmentRecords() { }
        private System.Void UpdateGlyphAdjustmentRecords(System.UInt32[] glyphIndexes) { }
        private System.Void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List<System.UInt32> glyphIndexes) { }
        private System.Void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List<System.UInt32> newGlyphIndexes, System.Collections.Generic.List<System.UInt32> allGlyphIndexes) { }
        private System.Void CopyListDataToArray(System.Collections.Generic.List<T> srcList, T[]& dstArray) { }
        private System.Void ClearFontAssetData(System.Boolean setAtlasSizeToZero) { }
        private System.Void ClearFontAssetData() { }
        private System.Void ClearFontAssetDataInternal() { }
        private System.Void UpdateFontAssetData() { }
        private System.Void ClearFontAssetTables() { }
        private System.Void ClearAtlasTextures(System.Boolean setAtlasSizeToZero) { }
        private System.Void UpgradeFontAsset() { }
        private System.Void UpgradeGlyphAdjustmentTableToFontFeatureTable() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000043
    public class FaceInfo_Legacy
    {
        // Fields
        public System.String Name;        // 0x10
        public System.Single PointSize;        // 0x18
        public System.Single Scale;        // 0x1C
        public System.Int32 CharacterCount;        // 0x20
        public System.Single LineHeight;        // 0x24
        public System.Single Baseline;        // 0x28
        public System.Single Ascender;        // 0x2C
        public System.Single CapHeight;        // 0x30
        public System.Single Descender;        // 0x34
        public System.Single CenterLine;        // 0x38
        public System.Single SuperscriptOffset;        // 0x3C
        public System.Single SubscriptOffset;        // 0x40
        public System.Single SubSize;        // 0x44
        public System.Single Underline;        // 0x48
        public System.Single UnderlineThickness;        // 0x4C
        public System.Single strikethrough;        // 0x50
        public System.Single strikethroughThickness;        // 0x54
        public System.Single TabWidth;        // 0x58
        public System.Single Padding;        // 0x5C
        public System.Single AtlasWidth;        // 0x60
        public System.Single AtlasHeight;        // 0x64

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000044
    public class TMP_Glyph : TMP_TextElement_Legacy
    {
        // Methods
        private TMPro.TMP_Glyph Clone(TMPro.TMP_Glyph source) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000045
    public struct FontAssetCreationSettings
    {
        // Fields
        public System.String sourceFontFileName;        // 0x10
        public System.String sourceFontFileGUID;        // 0x18
        public System.Int32 pointSizeSamplingMode;        // 0x20
        public System.Int32 pointSize;        // 0x24
        public System.Int32 padding;        // 0x28
        public System.Int32 packingMode;        // 0x2C
        public System.Int32 atlasWidth;        // 0x30
        public System.Int32 atlasHeight;        // 0x34
        public System.Int32 characterSetSelectionMode;        // 0x38
        public System.String characterSequence;        // 0x40
        public System.String referencedFontAssetGUID;        // 0x48
        public System.String referencedTextAssetGUID;        // 0x50
        public System.Int32 fontStyle;        // 0x58
        public System.Single fontStyleModifier;        // 0x5C
        public System.Int32 renderMode;        // 0x60
        public System.Boolean includeFontFeatures;        // 0x64

        // Methods
        private System.Void .ctor(System.String sourceFontFileGUID, System.Int32 pointSize, System.Int32 pointSizeSamplingMode, System.Int32 padding, System.Int32 packingMode, System.Int32 atlasWidth, System.Int32 atlasHeight, System.Int32 characterSelectionMode, System.String characterSet, System.Int32 renderMode) { }

    }

    // TypeToken: 0x2000046
    public struct TMP_FontWeightPair
    {
        // Fields
        public TMPro.TMP_FontAsset regularTypeface;        // 0x10
        public TMPro.TMP_FontAsset italicTypeface;        // 0x18

    }

    // TypeToken: 0x2000047
    public struct KerningPairKey
    {
        // Fields
        public System.UInt32 ascii_Left;        // 0x10
        public System.UInt32 ascii_Right;        // 0x14
        public System.UInt32 key;        // 0x18

        // Methods
        private System.Void .ctor(System.UInt32 ascii_left, System.UInt32 ascii_right) { }

    }

    // TypeToken: 0x2000048
    public struct GlyphValueRecord_Legacy
    {
        // Fields
        public System.Single xPlacement;        // 0x10
        public System.Single yPlacement;        // 0x14
        public System.Single xAdvance;        // 0x18
        public System.Single yAdvance;        // 0x1C

        // Methods
        private System.Void .ctor(UnityEngine.TextCore.LowLevel.GlyphValueRecord valueRecord) { }
        private TMPro.GlyphValueRecord_Legacy op_Addition(TMPro.GlyphValueRecord_Legacy a, TMPro.GlyphValueRecord_Legacy b) { }

    }

    // TypeToken: 0x2000049
    public class KerningPair
    {
        // Fields
        private System.UInt32 m_FirstGlyph;        // 0x10
        private TMPro.GlyphValueRecord_Legacy m_FirstGlyphAdjustments;        // 0x14
        private System.UInt32 m_SecondGlyph;        // 0x24
        private TMPro.GlyphValueRecord_Legacy m_SecondGlyphAdjustments;        // 0x28
        public System.Single xOffset;        // 0x38
        private static TMPro.KerningPair empty;        // 0x0
        private System.Boolean m_IgnoreSpacingAdjustments;        // 0x3C

        // Methods
        private System.UInt32 get_firstGlyph() { }
        private System.Void set_firstGlyph(System.UInt32 value) { }
        private TMPro.GlyphValueRecord_Legacy get_firstGlyphAdjustments() { }
        private System.UInt32 get_secondGlyph() { }
        private System.Void set_secondGlyph(System.UInt32 value) { }
        private TMPro.GlyphValueRecord_Legacy get_secondGlyphAdjustments() { }
        private System.Boolean get_ignoreSpacingAdjustments() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.UInt32 left, System.UInt32 right, System.Single offset) { }
        private System.Void .ctor(System.UInt32 firstGlyph, TMPro.GlyphValueRecord_Legacy firstGlyphAdjustments, System.UInt32 secondGlyph, TMPro.GlyphValueRecord_Legacy secondGlyphAdjustments) { }
        private System.Void ConvertLegacyKerningData() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200004A
    public class KerningTable
    {
        // Fields
        public System.Collections.Generic.List<TMPro.KerningPair> kerningPairs;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void AddKerningPair() { }
        private System.Int32 AddKerningPair(System.UInt32 first, System.UInt32 second, System.Single offset) { }
        private System.Int32 AddGlyphPairAdjustmentRecord(System.UInt32 first, TMPro.GlyphValueRecord_Legacy firstAdjustments, System.UInt32 second, TMPro.GlyphValueRecord_Legacy secondAdjustments) { }
        private System.Void RemoveKerningPair(System.Int32 left, System.Int32 right) { }
        private System.Void RemoveKerningPair(System.Int32 index) { }
        private System.Void SortKerningPairs() { }

    }

    // TypeToken: 0x200004F
    public class TMP_FontUtilities
    {
        // Fields
        private static System.Collections.Generic.List<System.Int32> k_searchedFontAssets;        // 0x0

        // Methods
        private TMPro.TMP_FontAsset SearchForCharacter(TMPro.TMP_FontAsset font, System.UInt32 unicode, TMPro.TMP_Character& character) { }
        private TMPro.TMP_FontAsset SearchForCharacter(System.Collections.Generic.List<TMPro.TMP_FontAsset> fonts, System.UInt32 unicode, TMPro.TMP_Character& character) { }
        private TMPro.TMP_FontAsset SearchForCharacterInternal(TMPro.TMP_FontAsset font, System.UInt32 unicode, TMPro.TMP_Character& character) { }
        private TMPro.TMP_FontAsset SearchForCharacterInternal(System.Collections.Generic.List<TMPro.TMP_FontAsset> fonts, System.UInt32 unicode, TMPro.TMP_Character& character) { }

    }

    // TypeToken: 0x2000050
    public class TMP_FontAssetUtilities
    {
        // Fields
        private static readonly TMPro.TMP_FontAssetUtilities s_Instance;        // 0x0
        private static System.Collections.Generic.HashSet<System.Int32> k_SearchedAssets;        // 0x8
        private static System.Boolean k_IsFontEngineInitialized;        // 0x10

        // Methods
        private System.Void .cctor() { }
        private TMPro.TMP_FontAssetUtilities get_instance() { }
        private TMPro.TMP_Character GetCharacterFromFontAsset(System.UInt32 unicode, TMPro.TMP_FontAsset sourceFontAsset, System.Boolean includeFallbacks, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, System.Boolean& isAlternativeTypeface) { }
        private TMPro.TMP_Character GetCharacterFromFontAsset_Internal(System.UInt32 unicode, TMPro.TMP_FontAsset sourceFontAsset, System.Boolean includeFallbacks, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, System.Boolean& isAlternativeTypeface) { }
        private TMPro.TMP_Character GetCharacterFromFontAssets(System.UInt32 unicode, TMPro.TMP_FontAsset sourceFontAsset, System.Collections.Generic.List<TMPro.TMP_FontAsset> fontAssets, System.Boolean includeFallbacks, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, System.Boolean& isAlternativeTypeface) { }
        private TMPro.TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset(System.UInt32 unicode, TMPro.TMP_SpriteAsset spriteAsset, System.Boolean includeFallbacks) { }
        private TMPro.TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(System.UInt32 unicode, TMPro.TMP_SpriteAsset spriteAsset, System.Boolean includeFallbacks) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000051
    public struct FontFeatureLookupFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.FontFeatureLookupFlags None;        // 0x0
        public static TMPro.FontFeatureLookupFlags IgnoreLigatures;        // 0x0
        public static TMPro.FontFeatureLookupFlags IgnoreSpacingAdjustments;        // 0x0

    }

    // TypeToken: 0x2000052
    public struct TMP_GlyphValueRecord
    {
        // Fields
        private System.Single m_XPlacement;        // 0x10
        private System.Single m_YPlacement;        // 0x14
        private System.Single m_XAdvance;        // 0x18
        private System.Single m_YAdvance;        // 0x1C

        // Methods
        private System.Single get_xPlacement() { }
        private System.Void set_xPlacement(System.Single value) { }
        private System.Single get_yPlacement() { }
        private System.Void set_yPlacement(System.Single value) { }
        private System.Single get_xAdvance() { }
        private System.Void set_xAdvance(System.Single value) { }
        private System.Single get_yAdvance() { }
        private System.Void set_yAdvance(System.Single value) { }
        private System.Void .ctor(System.Single xPlacement, System.Single yPlacement, System.Single xAdvance, System.Single yAdvance) { }
        private System.Void .ctor(TMPro.GlyphValueRecord_Legacy valueRecord) { }
        private System.Void .ctor(UnityEngine.TextCore.LowLevel.GlyphValueRecord valueRecord) { }
        private TMPro.TMP_GlyphValueRecord op_Addition(TMPro.TMP_GlyphValueRecord a, TMPro.TMP_GlyphValueRecord b) { }

    }

    // TypeToken: 0x2000053
    public struct TMP_GlyphAdjustmentRecord
    {
        // Fields
        private System.UInt32 m_GlyphIndex;        // 0x10
        private TMPro.TMP_GlyphValueRecord m_GlyphValueRecord;        // 0x14

        // Methods
        private System.UInt32 get_glyphIndex() { }
        private System.Void set_glyphIndex(System.UInt32 value) { }
        private TMPro.TMP_GlyphValueRecord get_glyphValueRecord() { }
        private System.Void set_glyphValueRecord(TMPro.TMP_GlyphValueRecord value) { }
        private System.Void .ctor(System.UInt32 glyphIndex, TMPro.TMP_GlyphValueRecord glyphValueRecord) { }
        private System.Void .ctor(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord adjustmentRecord) { }

    }

    // TypeToken: 0x2000054
    public class TMP_GlyphPairAdjustmentRecord
    {
        // Fields
        public TMPro.TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord;        // 0x10
        public TMPro.TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord;        // 0x24
        public TMPro.FontFeatureLookupFlags m_FeatureLookupFlags;        // 0x38

        // Methods
        private TMPro.TMP_GlyphAdjustmentRecord get_firstAdjustmentRecord() { }
        private System.Void set_firstAdjustmentRecord(TMPro.TMP_GlyphAdjustmentRecord value) { }
        private TMPro.TMP_GlyphAdjustmentRecord get_secondAdjustmentRecord() { }
        private System.Void set_secondAdjustmentRecord(TMPro.TMP_GlyphAdjustmentRecord value) { }
        private TMPro.FontFeatureLookupFlags get_featureLookupFlags() { }
        private System.Void set_featureLookupFlags(TMPro.FontFeatureLookupFlags value) { }
        private System.Void .ctor(TMPro.TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMPro.TMP_GlyphAdjustmentRecord secondAdjustmentRecord) { }
        private System.Void .ctor(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord glyphPairAdjustmentRecord) { }

    }

    // TypeToken: 0x2000055
    public struct GlyphPairKey
    {
        // Fields
        public System.UInt32 firstGlyphIndex;        // 0x10
        public System.UInt32 secondGlyphIndex;        // 0x14
        public System.UInt32 key;        // 0x18

        // Methods
        private System.Void .ctor(System.UInt32 firstGlyphIndex, System.UInt32 secondGlyphIndex) { }
        private System.Void .ctor(TMPro.TMP_GlyphPairAdjustmentRecord record) { }

    }

    // TypeToken: 0x2000056
    public class TMP_FontFeatureTable
    {
        // Fields
        private System.Collections.Generic.List<TMPro.TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords;        // 0x10
        public System.Collections.Generic.Dictionary<System.UInt32,TMPro.TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookupDictionary;        // 0x18

        // Methods
        private System.Collections.Generic.List<TMPro.TMP_GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords() { }
        private System.Void set_glyphPairAdjustmentRecords(System.Collections.Generic.List<TMPro.TMP_GlyphPairAdjustmentRecord> value) { }
        private System.Void .ctor() { }
        private System.Void SortGlyphPairAdjustmentRecords() { }

    }

    // TypeToken: 0x2000058
    public class TMP_InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement, IScrollHandler
    {
        // Fields
        protected UnityEngine.TouchScreenKeyboard m_SoftKeyboard;        // 0x180
        private static readonly System.Char[] kSeparators;        // 0x0
        protected UnityEngine.RectTransform m_RectTransform;        // 0x188
        protected UnityEngine.RectTransform m_TextViewport;        // 0x190
        protected UnityEngine.UI.RectMask2D m_TextComponentRectMask;        // 0x198
        protected UnityEngine.UI.RectMask2D m_TextViewportRectMask;        // 0x1A0
        private UnityEngine.Rect m_CachedViewportRect;        // 0x1A8
        protected TMPro.TMP_Text m_TextComponent;        // 0x1B8
        protected UnityEngine.RectTransform m_TextComponentRectTransform;        // 0x1C0
        protected UnityEngine.UI.Graphic m_Placeholder;        // 0x1C8
        protected UnityEngine.UI.Scrollbar m_VerticalScrollbar;        // 0x1D0
        protected TMPro.TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler;        // 0x1D8
        private System.Boolean m_IsDrivenByLayoutComponents;        // 0x1E0
        private UnityEngine.UI.LayoutGroup m_LayoutGroup;        // 0x1E8
        private UnityEngine.EventSystems.IScrollHandler m_IScrollHandlerParent;        // 0x1F0
        private System.Single m_ScrollPosition;        // 0x1F8
        protected System.Single m_ScrollSensitivity;        // 0x1FC
        private TMPro.TMP_InputField.ContentType m_ContentType;        // 0x200
        private TMPro.TMP_InputField.InputType m_InputType;        // 0x204
        private System.Char m_AsteriskChar;        // 0x208
        private UnityEngine.TouchScreenKeyboardType m_KeyboardType;        // 0x20C
        private TMPro.TMP_InputField.LineType m_LineType;        // 0x210
        private System.Boolean m_HideMobileInput;        // 0x214
        private System.Boolean m_HideSoftKeyboard;        // 0x215
        private TMPro.TMP_InputField.CharacterValidation m_CharacterValidation;        // 0x218
        private System.String m_RegexValue;        // 0x220
        private System.Single m_GlobalPointSize;        // 0x228
        private System.Int32 m_CharacterLimit;        // 0x22C
        private TMPro.TMP_InputField.SubmitEvent m_OnEndEdit;        // 0x230
        private TMPro.TMP_InputField.SubmitEvent m_OnSubmit;        // 0x238
        private TMPro.TMP_InputField.SelectionEvent m_OnSelect;        // 0x240
        private TMPro.TMP_InputField.SelectionEvent m_OnDeselect;        // 0x248
        private TMPro.TMP_InputField.TextSelectionEvent m_OnTextSelection;        // 0x250
        private TMPro.TMP_InputField.TextSelectionEvent m_OnEndTextSelection;        // 0x258
        private TMPro.TMP_InputField.OnChangeEvent m_OnValueChanged;        // 0x260
        private TMPro.TMP_InputField.TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged;        // 0x268
        private TMPro.TMP_InputField.OnValidateInput m_OnValidateInput;        // 0x270
        private UnityEngine.Events.UnityEvent m_OnFocused;        // 0x278
        private UnityEngine.Color m_CaretColor;        // 0x280
        private System.Boolean m_CustomCaretColor;        // 0x290
        private UnityEngine.Color m_SelectionColor;        // 0x294
        protected System.String m_Text;        // 0x2A8
        private System.Single m_CaretBlinkRate;        // 0x2B0
        private System.Int32 m_CaretWidth;        // 0x2B4
        private System.Boolean m_ReadOnly;        // 0x2B8
        private System.Boolean m_RichText;        // 0x2B9
        private System.Boolean m_disableUpDownArrowKeyMovingCaret;        // 0x2BA
        private System.Boolean m_disableLeftRightArrowKeyMovingCaret;        // 0x2BB
        protected System.Int32 m_StringPosition;        // 0x2BC
        protected System.Int32 m_StringSelectPosition;        // 0x2C0
        protected System.Int32 m_CaretPosition;        // 0x2C4
        protected System.Int32 m_CaretSelectPosition;        // 0x2C8
        private UnityEngine.RectTransform caretRectTrans;        // 0x2D0
        protected UnityEngine.UIVertex[] m_CursorVerts;        // 0x2D8
        private UnityEngine.CanvasRenderer m_CachedInputRenderer;        // 0x2E0
        private UnityEngine.Vector2 m_LastPosition;        // 0x2E8
        protected UnityEngine.Mesh m_Mesh;        // 0x2F0
        private System.Boolean m_AllowInput;        // 0x2F8
        private System.Boolean m_ShouldActivateNextUpdate;        // 0x2F9
        private System.Boolean m_UpdateDrag;        // 0x2FA
        private System.Boolean m_DragPositionOutOfBounds;        // 0x2FB
        private static System.Single kHScrollSpeed;        // 0x0
        private static System.Single kVScrollSpeed;        // 0x0
        protected System.Boolean m_CaretVisible;        // 0x2FC
        private UnityEngine.Coroutine m_BlinkCoroutine;        // 0x300
        private System.Single m_BlinkStartTime;        // 0x308
        private UnityEngine.Coroutine m_DragCoroutine;        // 0x310
        private System.String m_OriginalText;        // 0x318
        private System.Boolean m_WasCanceled;        // 0x320
        private System.Boolean m_HasDoneFocusTransition;        // 0x321
        private UnityEngine.WaitForSecondsRealtime m_WaitForSecondsRealtime;        // 0x328
        private System.Boolean m_PreventCallback;        // 0x330
        private System.Boolean m_TouchKeyboardAllowsInPlaceEditing;        // 0x331
        private System.Boolean m_IsTextComponentUpdateRequired;        // 0x332
        private System.Boolean m_isLastKeyBackspace;        // 0x333
        private System.Single m_PointerDownClickStartTime;        // 0x334
        private System.Single m_KeyDownStartTime;        // 0x338
        private System.Single m_DoubleClickDelay;        // 0x33C
        private static System.String kEmailSpecialCharacters;        // 0x0
        private System.Boolean m_IsCompositionActive;        // 0x340
        private System.Boolean m_ShouldUpdateIMEWindowPosition;        // 0x341
        private System.Int32 m_PreviousIMEInsertionLine;        // 0x344
        public System.Func<System.String,System.Int32,System.String> onValidateCharacterLimit;        // 0x348
        public System.Func<System.String,System.Int32> onGetTextLength;        // 0x350
        protected TMPro.TMP_FontAsset m_GlobalFontAsset;        // 0x358
        protected System.Boolean m_OnFocusSelectAll;        // 0x360
        protected System.Boolean m_isSelectAll;        // 0x361
        protected System.Boolean m_ResetOnDeActivation;        // 0x362
        private System.Boolean m_SelectionStillActive;        // 0x363
        private System.Boolean m_ReleaseSelection;        // 0x364
        private UnityEngine.GameObject m_PreviouslySelectedObject;        // 0x368
        private System.Boolean m_RestoreOriginalTextOnEscape;        // 0x370
        private System.Boolean m_WontReleaseSelectionOnEscape;        // 0x371
        protected System.Boolean m_isRichTextEditingAllowed;        // 0x372
        protected System.Int32 m_LineLimit;        // 0x374
        protected TMPro.TMP_InputValidator m_InputValidator;        // 0x378
        private System.Boolean m_isSelected;        // 0x380
        private System.Boolean m_IsStringPositionDirty;        // 0x381
        private System.Boolean m_IsCaretPositionDirty;        // 0x382
        private System.Boolean m_forceRectTransformAdjustment;        // 0x383
        private UnityEngine.Event m_ProcessingEvent;        // 0x388

        // Methods
        private System.Boolean get_isLastKeyBackspace() { }
        private System.Void set_isLastKeyBackspace(System.Boolean value) { }
        private UnityEngine.EventSystems.BaseInput get_inputSystem() { }
        private System.String get_compositionString() { }
        private System.Int32 get_compositionLength() { }
        private System.Void .ctor() { }
        private UnityEngine.Mesh get_mesh() { }
        private System.Boolean get_shouldHideMobileInput() { }
        private System.Void set_shouldHideMobileInput(System.Boolean value) { }
        private System.Boolean get_shouldHideSoftKeyboard() { }
        private System.Void set_shouldHideSoftKeyboard(System.Boolean value) { }
        private System.Boolean isKeyboardUsingEvents() { }
        private System.String get_text() { }
        private System.Void set_text(System.String value) { }
        private System.Void SetTextWithoutNotify(System.String input) { }
        private System.Void SetText(System.String value, System.Boolean sendCallback) { }
        private System.Boolean get_isFocused() { }
        private System.Single get_caretBlinkRate() { }
        private System.Void set_caretBlinkRate(System.Single value) { }
        private System.Int32 get_caretWidth() { }
        private System.Void set_caretWidth(System.Int32 value) { }
        private UnityEngine.RectTransform get_textViewport() { }
        private System.Void set_textViewport(UnityEngine.RectTransform value) { }
        private TMPro.TMP_Text get_textComponent() { }
        private System.Void set_textComponent(TMPro.TMP_Text value) { }
        private UnityEngine.UI.Graphic get_placeholder() { }
        private System.Void set_placeholder(UnityEngine.UI.Graphic value) { }
        private UnityEngine.UI.Scrollbar get_verticalScrollbar() { }
        private System.Void set_verticalScrollbar(UnityEngine.UI.Scrollbar value) { }
        private System.Single get_scrollSensitivity() { }
        private System.Void set_scrollSensitivity(System.Single value) { }
        private UnityEngine.Color get_caretColor() { }
        private System.Void set_caretColor(UnityEngine.Color value) { }
        private System.Boolean get_customCaretColor() { }
        private System.Void set_customCaretColor(System.Boolean value) { }
        private UnityEngine.Color get_selectionColor() { }
        private System.Void set_selectionColor(UnityEngine.Color value) { }
        private TMPro.TMP_InputField.SubmitEvent get_onEndEdit() { }
        private System.Void set_onEndEdit(TMPro.TMP_InputField.SubmitEvent value) { }
        private TMPro.TMP_InputField.SubmitEvent get_onSubmit() { }
        private System.Void set_onSubmit(TMPro.TMP_InputField.SubmitEvent value) { }
        private TMPro.TMP_InputField.SelectionEvent get_onSelect() { }
        private System.Void set_onSelect(TMPro.TMP_InputField.SelectionEvent value) { }
        private TMPro.TMP_InputField.SelectionEvent get_onDeselect() { }
        private System.Void set_onDeselect(TMPro.TMP_InputField.SelectionEvent value) { }
        private TMPro.TMP_InputField.TextSelectionEvent get_onTextSelection() { }
        private System.Void set_onTextSelection(TMPro.TMP_InputField.TextSelectionEvent value) { }
        private TMPro.TMP_InputField.TextSelectionEvent get_onEndTextSelection() { }
        private System.Void set_onEndTextSelection(TMPro.TMP_InputField.TextSelectionEvent value) { }
        private TMPro.TMP_InputField.OnChangeEvent get_onValueChanged() { }
        private System.Void set_onValueChanged(TMPro.TMP_InputField.OnChangeEvent value) { }
        private TMPro.TMP_InputField.TouchScreenKeyboardEvent get_onTouchScreenKeyboardStatusChanged() { }
        private System.Void set_onTouchScreenKeyboardStatusChanged(TMPro.TMP_InputField.TouchScreenKeyboardEvent value) { }
        private TMPro.TMP_InputField.OnValidateInput get_onValidateInput() { }
        private System.Void set_onValidateInput(TMPro.TMP_InputField.OnValidateInput value) { }
        private UnityEngine.Events.UnityEvent get_onFocused() { }
        private System.Void set_onFocused(UnityEngine.Events.UnityEvent value) { }
        private System.Int32 get_characterLimit() { }
        private System.Void set_characterLimit(System.Int32 value) { }
        private System.Single get_pointSize() { }
        private System.Void set_pointSize(System.Single value) { }
        private TMPro.TMP_FontAsset get_fontAsset() { }
        private System.Void set_fontAsset(TMPro.TMP_FontAsset value) { }
        private System.Boolean get_onFocusSelectAll() { }
        private System.Void set_onFocusSelectAll(System.Boolean value) { }
        private System.Boolean get_resetOnDeActivation() { }
        private System.Void set_resetOnDeActivation(System.Boolean value) { }
        private System.Boolean get_restoreOriginalTextOnEscape() { }
        private System.Void set_restoreOriginalTextOnEscape(System.Boolean value) { }
        private System.Boolean get_wontReleaseSelectionOnEscape() { }
        private System.Void set_wontReleaseSelectionOnEscape(System.Boolean value) { }
        private System.Boolean get_disableArrowKeyMoveCaret() { }
        private System.Void set_disableArrowKeyMoveCaret(System.Boolean value) { }
        private System.Boolean get_isRichTextEditingAllowed() { }
        private System.Void set_isRichTextEditingAllowed(System.Boolean value) { }
        private TMPro.TMP_InputField.ContentType get_contentType() { }
        private System.Void set_contentType(TMPro.TMP_InputField.ContentType value) { }
        private TMPro.TMP_InputField.LineType get_lineType() { }
        private System.Void set_lineType(TMPro.TMP_InputField.LineType value) { }
        private System.Int32 get_lineLimit() { }
        private System.Void set_lineLimit(System.Int32 value) { }
        private TMPro.TMP_InputField.InputType get_inputType() { }
        private System.Void set_inputType(TMPro.TMP_InputField.InputType value) { }
        private UnityEngine.TouchScreenKeyboardType get_keyboardType() { }
        private System.Void set_keyboardType(UnityEngine.TouchScreenKeyboardType value) { }
        private TMPro.TMP_InputField.CharacterValidation get_characterValidation() { }
        private System.Void set_characterValidation(TMPro.TMP_InputField.CharacterValidation value) { }
        private TMPro.TMP_InputValidator get_inputValidator() { }
        private System.Void set_inputValidator(TMPro.TMP_InputValidator value) { }
        private System.Boolean get_readOnly() { }
        private System.Void set_readOnly(System.Boolean value) { }
        private System.Boolean get_richText() { }
        private System.Void set_richText(System.Boolean value) { }
        private System.Boolean get_multiLine() { }
        private System.Char get_asteriskChar() { }
        private System.Void set_asteriskChar(System.Char value) { }
        private System.Boolean get_wasCanceled() { }
        private System.Void ClampStringPos(System.Int32& pos) { }
        private System.Void ClampCaretPos(System.Int32& pos) { }
        private System.Int32 get_caretPositionInternal() { }
        private System.Void set_caretPositionInternal(System.Int32 value) { }
        private System.Int32 get_stringPositionInternal() { }
        private System.Void set_stringPositionInternal(System.Int32 value) { }
        private System.Int32 get_caretSelectPositionInternal() { }
        private System.Void set_caretSelectPositionInternal(System.Int32 value) { }
        private System.Int32 get_stringSelectPositionInternal() { }
        private System.Void set_stringSelectPositionInternal(System.Int32 value) { }
        private System.Boolean get_hasSelection() { }
        private System.Int32 get_caretPosition() { }
        private System.Void set_caretPosition(System.Int32 value) { }
        private System.Int32 get_selectionAnchorPosition() { }
        private System.Void set_selectionAnchorPosition(System.Int32 value) { }
        private System.Int32 get_selectionFocusPosition() { }
        private System.Void set_selectionFocusPosition(System.Int32 value) { }
        private System.Int32 get_stringPosition() { }
        private System.Void set_stringPosition(System.Int32 value) { }
        private System.Int32 get_selectionStringAnchorPosition() { }
        private System.Void set_selectionStringAnchorPosition(System.Int32 value) { }
        private System.Int32 get_selectionStringFocusPosition() { }
        private System.Void set_selectionStringFocusPosition(System.Int32 value) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void ON_TEXT_CHANGED(UnityEngine.Object obj) { }
        private System.Collections.IEnumerator CaretBlink() { }
        private System.Void SetCaretVisible() { }
        private System.Void SetCaretActive() { }
        private System.Void OnFocus() { }
        private System.Void SelectAll() { }
        private System.Void MoveTextEnd(System.Boolean shift) { }
        private System.Void MoveTextStart(System.Boolean shift) { }
        private System.Void MoveToEndOfLine(System.Boolean shift, System.Boolean ctrl) { }
        private System.Void MoveToStartOfLine(System.Boolean shift, System.Boolean ctrl) { }
        private System.String get_clipboard() { }
        private System.Void set_clipboard(System.String value) { }
        private System.Boolean InPlaceEditing() { }
        private System.Void UpdateStringPositionFromKeyboard() { }
        private System.Void LateUpdate() { }
        private System.Boolean MayDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Collections.IEnumerator MouseDragOutsideRect(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        private TMPro.TMP_InputField.EditState KeyPressed(UnityEngine.Event evt) { }
        private System.Boolean IsValidChar(System.Char c) { }
        private System.Void ProcessEvent(UnityEngine.Event e) { }
        private System.Void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Single GetScrollPositionRelativeToViewport() { }
        private System.String GetSelectedString() { }
        private System.Int32 FindNextWordBegin() { }
        private System.Void MoveRight(System.Boolean shift, System.Boolean ctrl) { }
        private System.Int32 FindPrevWordBegin() { }
        private System.Void MoveLeft(System.Boolean shift, System.Boolean ctrl) { }
        private System.Int32 LineUpCharacterPosition(System.Int32 originalPos, System.Boolean goToFirstChar) { }
        private System.Int32 LineDownCharacterPosition(System.Int32 originalPos, System.Boolean goToLastChar) { }
        private System.Int32 PageUpCharacterPosition(System.Int32 originalPos, System.Boolean goToFirstChar) { }
        private System.Int32 PageDownCharacterPosition(System.Int32 originalPos, System.Boolean goToLastChar) { }
        private System.Void MoveDown(System.Boolean shift) { }
        private System.Void MoveDown(System.Boolean shift, System.Boolean goToLastChar) { }
        private System.Void MoveUp(System.Boolean shift) { }
        private System.Void MoveUp(System.Boolean shift, System.Boolean goToFirstChar) { }
        private System.Void MovePageUp(System.Boolean shift) { }
        private System.Void MovePageUp(System.Boolean shift, System.Boolean goToFirstChar) { }
        private System.Void MovePageDown(System.Boolean shift) { }
        private System.Void MovePageDown(System.Boolean shift, System.Boolean goToLastChar) { }
        private System.Void Delete() { }
        private System.Void DeleteKey() { }
        private System.Void Backspace() { }
        private System.Void Append(System.String input) { }
        private System.Void Append(System.Char input) { }
        private System.Void Insert(System.Char c) { }
        private System.Void UpdateTouchKeyboardFromEditChanges() { }
        private System.Void SendOnValueChangedAndUpdateLabel() { }
        private System.Void SendOnValueChanged() { }
        private System.Void SendOnEndEdit() { }
        private System.Void SendOnSubmit() { }
        private System.Void SendOnFocus() { }
        private System.Void SendOnFocusLost() { }
        private System.Void SendOnTextSelection() { }
        private System.Void SendOnEndTextSelection() { }
        private System.Void SendTouchScreenKeyboardStatusChanged() { }
        private System.Void UpdateLabel() { }
        private System.Void UpdateScrollbar() { }
        private System.Void OnScrollbarValueChange(System.Single value) { }
        private System.Void UpdateMaskRegions() { }
        private System.Void AdjustTextPositionRelativeToViewport(System.Single relativePosition) { }
        private System.Int32 GetCaretPositionFromStringIndex(System.Int32 stringIndex) { }
        private System.Int32 GetMinCaretPositionFromStringIndex(System.Int32 stringIndex) { }
        private System.Int32 GetMaxCaretPositionFromStringIndex(System.Int32 stringIndex) { }
        private System.Int32 GetStringIndexFromCaretPosition(System.Int32 caretPosition) { }
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
        private System.Void GenerateHightlight(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset) { }
        private System.Void AdjustRectTransformRelativeToViewport(UnityEngine.Vector2 startPosition, System.Single height, System.Boolean isCharVisible) { }
        private System.Char Validate(System.String text, System.Int32 pos, System.Char ch) { }
        private System.Void ActivateInputField() { }
        private System.Void ActivateInputFieldInternal() { }
        private System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnControlClick() { }
        private System.Void ReleaseSelection() { }
        private System.Void DeactivateInputField(System.Boolean clearSelection) { }
        private System.Void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void EnforceContentType() { }
        private System.Void SetTextComponentWrapMode() { }
        private System.Void SetTextComponentRichTextMode() { }
        private System.Void SetToCustomIfContentTypeIsNot(TMPro.TMP_InputField.ContentType[] allowedContentTypes) { }
        private System.Void SetToCustom() { }
        private System.Void SetToCustom(TMPro.TMP_InputField.CharacterValidation characterValidation) { }
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
        private System.Void SetGlobalPointSize(System.Single pointSize) { }
        private System.Void SetGlobalFontAsset(TMPro.TMP_FontAsset fontAsset) { }
        private System.Void .cctor() { }
        private UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform() { }

    }

    // TypeToken: 0x2000066
    public class SetPropertyUtility
    {
        // Methods
        private System.Boolean SetColor(UnityEngine.Color& currentValue, UnityEngine.Color newValue) { }
        private System.Boolean SetEquatableStruct(T& currentValue, T newValue) { }
        private System.Boolean SetStruct(T& currentValue, T newValue) { }
        private System.Boolean SetClass(T& currentValue, T newValue) { }

    }

    // TypeToken: 0x2000067
    public class TMP_InputValidator : ScriptableObject
    {
        // Methods
        private System.Char Validate(System.String& text, System.Int32& pos, System.Char ch) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000068
    public struct TMP_LineInfo
    {
        // Fields
        public System.Int32 controlCharacterCount;        // 0x10
        public System.Int32 characterCount;        // 0x14
        public System.Int32 visibleCharacterCount;        // 0x18
        public System.Int32 spaceCount;        // 0x1C
        public System.Int32 wordCount;        // 0x20
        public System.Int32 firstCharacterIndex;        // 0x24
        public System.Int32 firstVisibleCharacterIndex;        // 0x28
        public System.Int32 lastCharacterIndex;        // 0x2C
        public System.Int32 lastVisibleCharacterIndex;        // 0x30
        public System.Single length;        // 0x34
        public System.Single lineHeight;        // 0x38
        public System.Single ascender;        // 0x3C
        public System.Single baseline;        // 0x40
        public System.Single descender;        // 0x44
        public System.Single maxAdvance;        // 0x48
        public System.Single width;        // 0x4C
        public System.Single marginLeft;        // 0x50
        public System.Single marginRight;        // 0x54
        public TMPro.HorizontalAlignmentOptions alignment;        // 0x58
        public TMPro.Extents lineExtents;        // 0x5C

    }

    // TypeToken: 0x2000069
    public class TMP_ListPool`1
    {
        // Fields
        private static readonly TMPro.TMP_ObjectPool<System.Collections.Generic.List<T>> s_ListPool;        // 0x0

        // Methods
        private System.Collections.Generic.List<T> Get() { }
        private System.Void Release(System.Collections.Generic.List<T> toRelease) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200006B
    public class TMP_MaterialManager
    {
        // Fields
        private static System.Collections.Generic.List<TMPro.TMP_MaterialManager.MaskingMaterial> m_materialList;        // 0x0
        private static System.Collections.Generic.Dictionary<System.Int64,TMPro.TMP_MaterialManager.FallbackMaterial> m_fallbackMaterials;        // 0x8
        private static System.Collections.Generic.Dictionary<System.Int32,System.Int64> m_fallbackMaterialLookup;        // 0x10
        private static System.Collections.Generic.List<TMPro.TMP_MaterialManager.FallbackMaterial> m_fallbackCleanupList;        // 0x18
        private static System.Boolean isFallbackListDirty;        // 0x20
        private static System.String s_overlayShaderKeyword;        // 0x28

        // Methods
        private System.Void .cctor() { }
        private System.Void OnPreRender() { }
        private System.String get_overlayShaderKeyword() { }
        private System.Void set_overlayShaderKeyword(System.String value) { }
        private UnityEngine.Material GetStencilMaterial(UnityEngine.Material baseMaterial, System.Int32 stencilID) { }
        private System.Void ReleaseStencilMaterial(UnityEngine.Material stencilMaterial) { }
        private UnityEngine.Material GetBaseMaterial(UnityEngine.Material stencilMaterial) { }
        private UnityEngine.Material SetStencil(UnityEngine.Material material, System.Int32 stencilID) { }
        private System.Void AddMaskingMaterial(UnityEngine.Material baseMaterial, UnityEngine.Material stencilMaterial, System.Int32 stencilID) { }
        private System.Void RemoveStencilMaterial(UnityEngine.Material stencilMaterial) { }
        private System.Void ReleaseBaseMaterial(UnityEngine.Material baseMaterial) { }
        private System.Void ClearMaterials() { }
        private System.Int32 GetStencilID(UnityEngine.GameObject obj) { }
        private UnityEngine.Material GetMaterialForRendering(UnityEngine.UI.MaskableGraphic graphic, UnityEngine.Material baseMaterial) { }
        private UnityEngine.Transform FindRootSortOverrideCanvas(UnityEngine.Transform start) { }
        private UnityEngine.Material GetFallbackMaterial(TMPro.TMP_FontAsset fontAsset, UnityEngine.Material sourceMaterial, System.Int32 atlasIndex) { }
        private UnityEngine.Material GetFallbackMaterial(UnityEngine.Material sourceMaterial, UnityEngine.Material targetMaterial) { }
        private System.Void AddFallbackMaterialReference(UnityEngine.Material targetMaterial) { }
        private System.Void RemoveFallbackMaterialReference(UnityEngine.Material targetMaterial) { }
        private System.Void CleanupFallbackMaterials() { }
        private System.Void ReleaseFallbackMaterial(UnityEngine.Material fallbackMaterial) { }
        private System.Void CopyMaterialPresetProperties(UnityEngine.Material source, UnityEngine.Material destination) { }

    }

    // TypeToken: 0x2000072
    public struct VertexSortingOrder
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.VertexSortingOrder Normal;        // 0x0
        public static TMPro.VertexSortingOrder Reverse;        // 0x0

    }

    // TypeToken: 0x2000073
    public struct TMP_MeshInfo, IDisposable
    {
        // Fields
        private static readonly UnityEngine.Color32 s_DefaultColor;        // 0x0
        private static readonly UnityEngine.Vector3 s_DefaultNormal;        // 0x4
        private static readonly UnityEngine.Vector4 s_DefaultTangent;        // 0x10
        private static readonly UnityEngine.Bounds s_DefaultBounds;        // 0x20
        public UnityEngine.Mesh mesh;        // 0x10
        public System.Int32 vertexCount;        // 0x18
        public UnityEngine.Vector3[] vertices;        // 0x20
        public UnityEngine.Vector3[] normals;        // 0x28
        public UnityEngine.Vector4[] tangents;        // 0x30
        public UnityEngine.Vector2[] uvs0;        // 0x38
        public UnityEngine.Vector2[] uvs2;        // 0x40
        public UnityEngine.Color32[] colors32;        // 0x48
        public System.Int32[] triangles;        // 0x50
        public UnityEngine.Material material;        // 0x58

        // Methods
        private System.Void .ctor(UnityEngine.Mesh mesh, System.Int32 size) { }
        private System.Void .ctor(UnityEngine.Mesh mesh, System.Int32 size, System.Boolean isVolumetric) { }
        private System.Void ResizeMeshInfo(System.Int32 size) { }
        private System.Void ResizeMeshInfo(System.Int32 size, System.Boolean isVolumetric) { }
        private System.Void Clear() { }
        private System.Void Clear(System.Boolean uploadChanges) { }
        private System.Void ClearUnusedVertices() { }
        private System.Void ClearUnusedVertices(System.Int32 startIndex) { }
        private System.Void ClearUnusedVertices(System.Int32 startIndex, System.Boolean updateMesh) { }
        private System.Void SortGeometry(TMPro.VertexSortingOrder order) { }
        private System.Void SortGeometry(System.Collections.Generic.IList<System.Int32> sortingOrder) { }
        private System.Void SwapVertexData(System.Int32 src, System.Int32 dst) { }
        private System.Void Dispose() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000074
    public class TMP_ObjectPool`1
    {
        // Fields
        private readonly System.Collections.Generic.Stack<T> m_Stack;        // 0x0
        private readonly UnityEngine.Events.UnityAction<T> m_ActionOnGet;        // 0x0
        private readonly UnityEngine.Events.UnityAction<T> m_ActionOnRelease;        // 0x0
        private System.Int32 <countAll>k__BackingField;        // 0x0

        // Methods
        private System.Int32 get_countAll() { }
        private System.Void set_countAll(System.Int32 value) { }
        private System.Int32 get_countActive() { }
        private System.Int32 get_countInactive() { }
        private System.Void .ctor(UnityEngine.Events.UnityAction<T> actionOnGet, UnityEngine.Events.UnityAction<T> actionOnRelease) { }
        private T Get() { }
        private System.Void Release(T element) { }

    }

    // TypeToken: 0x2000075
    public class TMP_ResourceManager
    {
        // Fields
        private static readonly TMPro.TMP_ResourceManager s_instance;        // 0x0
        private static TMPro.TMP_Settings s_TextSettings;        // 0x8
        private static readonly System.Collections.Generic.List<TMPro.TMP_FontAsset> s_FontAssetReferences;        // 0x10
        private static readonly System.Collections.Generic.Dictionary<System.Int32,TMPro.TMP_FontAsset> s_FontAssetReferenceLookup;        // 0x18

        // Methods
        private System.Void .cctor() { }
        private TMPro.TMP_Settings GetTextSettings() { }
        private System.Void AddFontAsset(TMPro.TMP_FontAsset fontAsset) { }
        private System.Boolean TryGetFontAsset(System.Int32 hashcode, TMPro.TMP_FontAsset& fontAsset) { }
        private System.Void RebuildFontAssetCache(System.Int32 instanceID) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000076
    public struct MarkupTag
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.MarkupTag BOLD;        // 0x0
        public static TMPro.MarkupTag SLASH_BOLD;        // 0x0
        public static TMPro.MarkupTag ITALIC;        // 0x0
        public static TMPro.MarkupTag SLASH_ITALIC;        // 0x0
        public static TMPro.MarkupTag UNDERLINE;        // 0x0
        public static TMPro.MarkupTag SLASH_UNDERLINE;        // 0x0
        public static TMPro.MarkupTag STRIKETHROUGH;        // 0x0
        public static TMPro.MarkupTag SLASH_STRIKETHROUGH;        // 0x0
        public static TMPro.MarkupTag MARK;        // 0x0
        public static TMPro.MarkupTag SLASH_MARK;        // 0x0
        public static TMPro.MarkupTag SUBSCRIPT;        // 0x0
        public static TMPro.MarkupTag SLASH_SUBSCRIPT;        // 0x0
        public static TMPro.MarkupTag SUPERSCRIPT;        // 0x0
        public static TMPro.MarkupTag SLASH_SUPERSCRIPT;        // 0x0
        public static TMPro.MarkupTag COLOR;        // 0x0
        public static TMPro.MarkupTag SLASH_COLOR;        // 0x0
        public static TMPro.MarkupTag ALPHA;        // 0x0
        public static TMPro.MarkupTag A;        // 0x0
        public static TMPro.MarkupTag SLASH_A;        // 0x0
        public static TMPro.MarkupTag SIZE;        // 0x0
        public static TMPro.MarkupTag SLASH_SIZE;        // 0x0
        public static TMPro.MarkupTag SPRITE;        // 0x0
        public static TMPro.MarkupTag NO_BREAK;        // 0x0
        public static TMPro.MarkupTag SLASH_NO_BREAK;        // 0x0
        public static TMPro.MarkupTag STYLE;        // 0x0
        public static TMPro.MarkupTag SLASH_STYLE;        // 0x0
        public static TMPro.MarkupTag FONT;        // 0x0
        public static TMPro.MarkupTag SLASH_FONT;        // 0x0
        public static TMPro.MarkupTag SLASH_MATERIAL;        // 0x0
        public static TMPro.MarkupTag LINK;        // 0x0
        public static TMPro.MarkupTag SLASH_LINK;        // 0x0
        public static TMPro.MarkupTag FONT_WEIGHT;        // 0x0
        public static TMPro.MarkupTag SLASH_FONT_WEIGHT;        // 0x0
        public static TMPro.MarkupTag NO_PARSE;        // 0x0
        public static TMPro.MarkupTag SLASH_NO_PARSE;        // 0x0
        public static TMPro.MarkupTag POSITION;        // 0x0
        public static TMPro.MarkupTag SLASH_POSITION;        // 0x0
        public static TMPro.MarkupTag VERTICAL_OFFSET;        // 0x0
        public static TMPro.MarkupTag SLASH_VERTICAL_OFFSET;        // 0x0
        public static TMPro.MarkupTag SPACE;        // 0x0
        public static TMPro.MarkupTag SLASH_SPACE;        // 0x0
        public static TMPro.MarkupTag PAGE;        // 0x0
        public static TMPro.MarkupTag SLASH_PAGE;        // 0x0
        public static TMPro.MarkupTag ALIGN;        // 0x0
        public static TMPro.MarkupTag SLASH_ALIGN;        // 0x0
        public static TMPro.MarkupTag WIDTH;        // 0x0
        public static TMPro.MarkupTag SLASH_WIDTH;        // 0x0
        public static TMPro.MarkupTag GRADIENT;        // 0x0
        public static TMPro.MarkupTag SLASH_GRADIENT;        // 0x0
        public static TMPro.MarkupTag CHARACTER_SPACE;        // 0x0
        public static TMPro.MarkupTag SLASH_CHARACTER_SPACE;        // 0x0
        public static TMPro.MarkupTag MONOSPACE;        // 0x0
        public static TMPro.MarkupTag SLASH_MONOSPACE;        // 0x0
        public static TMPro.MarkupTag CLASS;        // 0x0
        public static TMPro.MarkupTag INDENT;        // 0x0
        public static TMPro.MarkupTag SLASH_INDENT;        // 0x0
        public static TMPro.MarkupTag LINE_INDENT;        // 0x0
        public static TMPro.MarkupTag SLASH_LINE_INDENT;        // 0x0
        public static TMPro.MarkupTag MARGIN;        // 0x0
        public static TMPro.MarkupTag SLASH_MARGIN;        // 0x0
        public static TMPro.MarkupTag MARGIN_LEFT;        // 0x0
        public static TMPro.MarkupTag MARGIN_RIGHT;        // 0x0
        public static TMPro.MarkupTag LINE_HEIGHT;        // 0x0
        public static TMPro.MarkupTag SLASH_LINE_HEIGHT;        // 0x0
        public static TMPro.MarkupTag ACTION;        // 0x0
        public static TMPro.MarkupTag SLASH_ACTION;        // 0x0
        public static TMPro.MarkupTag SCALE;        // 0x0
        public static TMPro.MarkupTag SLASH_SCALE;        // 0x0
        public static TMPro.MarkupTag ROTATE;        // 0x0
        public static TMPro.MarkupTag SLASH_ROTATE;        // 0x0
        public static TMPro.MarkupTag LOWERCASE;        // 0x0
        public static TMPro.MarkupTag SLASH_LOWERCASE;        // 0x0
        public static TMPro.MarkupTag ALLCAPS;        // 0x0
        public static TMPro.MarkupTag SLASH_ALLCAPS;        // 0x0
        public static TMPro.MarkupTag UPPERCASE;        // 0x0
        public static TMPro.MarkupTag SLASH_UPPERCASE;        // 0x0
        public static TMPro.MarkupTag SMALLCAPS;        // 0x0
        public static TMPro.MarkupTag SLASH_SMALLCAPS;        // 0x0
        public static TMPro.MarkupTag LIGA;        // 0x0
        public static TMPro.MarkupTag SLASH_LIGA;        // 0x0
        public static TMPro.MarkupTag FRAC;        // 0x0
        public static TMPro.MarkupTag SLASH_FRAC;        // 0x0
        public static TMPro.MarkupTag NAME;        // 0x0
        public static TMPro.MarkupTag INDEX;        // 0x0
        public static TMPro.MarkupTag TINT;        // 0x0
        public static TMPro.MarkupTag ANIM;        // 0x0
        public static TMPro.MarkupTag MATERIAL;        // 0x0
        public static TMPro.MarkupTag HREF;        // 0x0
        public static TMPro.MarkupTag ANGLE;        // 0x0
        public static TMPro.MarkupTag RED;        // 0x0
        public static TMPro.MarkupTag GREEN;        // 0x0
        public static TMPro.MarkupTag BLUE;        // 0x0
        public static TMPro.MarkupTag YELLOW;        // 0x0
        public static TMPro.MarkupTag ORANGE;        // 0x0
        public static TMPro.MarkupTag BLACK;        // 0x0
        public static TMPro.MarkupTag WHITE;        // 0x0
        public static TMPro.MarkupTag PURPLE;        // 0x0
        public static TMPro.MarkupTag BR;        // 0x0
        public static TMPro.MarkupTag ZWSP;        // 0x0
        public static TMPro.MarkupTag NBSP;        // 0x0
        public static TMPro.MarkupTag SHY;        // 0x0
        public static TMPro.MarkupTag LEFT;        // 0x0
        public static TMPro.MarkupTag RIGHT;        // 0x0
        public static TMPro.MarkupTag CENTER;        // 0x0
        public static TMPro.MarkupTag JUSTIFIED;        // 0x0
        public static TMPro.MarkupTag FLUSH;        // 0x0
        public static TMPro.MarkupTag NONE;        // 0x0
        public static TMPro.MarkupTag PLUS;        // 0x0
        public static TMPro.MarkupTag MINUS;        // 0x0
        public static TMPro.MarkupTag PX;        // 0x0
        public static TMPro.MarkupTag PLUS_PX;        // 0x0
        public static TMPro.MarkupTag MINUS_PX;        // 0x0
        public static TMPro.MarkupTag EM;        // 0x0
        public static TMPro.MarkupTag PLUS_EM;        // 0x0
        public static TMPro.MarkupTag MINUS_EM;        // 0x0
        public static TMPro.MarkupTag PCT;        // 0x0
        public static TMPro.MarkupTag PLUS_PCT;        // 0x0
        public static TMPro.MarkupTag MINUS_PCT;        // 0x0
        public static TMPro.MarkupTag PERCENTAGE;        // 0x0
        public static TMPro.MarkupTag PLUS_PERCENTAGE;        // 0x0
        public static TMPro.MarkupTag MINUS_PERCENTAGE;        // 0x0
        public static TMPro.MarkupTag TRUE;        // 0x0
        public static TMPro.MarkupTag FALSE;        // 0x0
        public static TMPro.MarkupTag INVALID;        // 0x0
        public static TMPro.MarkupTag NORMAL;        // 0x0
        public static TMPro.MarkupTag DEFAULT;        // 0x0

    }

    // TypeToken: 0x2000077
    public struct TagValueType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.TagValueType None;        // 0x0
        public static TMPro.TagValueType NumericalValue;        // 0x0
        public static TMPro.TagValueType StringValue;        // 0x0
        public static TMPro.TagValueType ColorValue;        // 0x0

    }

    // TypeToken: 0x2000078
    public struct TagUnitType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.TagUnitType Pixels;        // 0x0
        public static TMPro.TagUnitType FontUnits;        // 0x0
        public static TMPro.TagUnitType Percentage;        // 0x0

    }

    // TypeToken: 0x2000079
    public class CodePoint
    {
        // Fields
        public static System.UInt32 SPACE;        // 0x0
        public static System.UInt32 DOUBLE_QUOTE;        // 0x0
        public static System.UInt32 NUMBER_SIGN;        // 0x0
        public static System.UInt32 PERCENTAGE;        // 0x0
        public static System.UInt32 PLUS;        // 0x0
        public static System.UInt32 MINUS;        // 0x0
        public static System.UInt32 PERIOD;        // 0x0
        public static System.UInt32 HYPHEN_MINUS;        // 0x0
        public static System.UInt32 SOFT_HYPHEN;        // 0x0
        public static System.UInt32 HYPHEN;        // 0x0
        public static System.UInt32 NON_BREAKING_HYPHEN;        // 0x0
        public static System.UInt32 ZERO_WIDTH_SPACE;        // 0x0
        public static System.UInt32 RIGHT_SINGLE_QUOTATION;        // 0x0
        public static System.UInt32 APOSTROPHE;        // 0x0
        public static System.UInt32 WORD_JOINER;        // 0x0
        public static System.UInt32 HIGH_SURROGATE_START;        // 0x0
        public static System.UInt32 HIGH_SURROGATE_END;        // 0x0
        public static System.UInt32 LOW_SURROGATE_START;        // 0x0
        public static System.UInt32 LOW_SURROGATE_END;        // 0x0
        public static System.UInt32 UNICODE_PLANE01_START;        // 0x0

    }

    // TypeToken: 0x200007A
    public class TMP_ScrollbarEventHandler : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, ISelectHandler, IDeselectHandler
    {
        // Fields
        public System.Boolean isSelected;        // 0x18

        // Methods
        private System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007B
    public class TMP_SelectionCaret : MaskableGraphic
    {
        // Methods
        private System.Void Cull(UnityEngine.Rect clipRect, System.Boolean validRect) { }
        private System.Void UpdateGeometry() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007C
    public class TMP_Settings : ScriptableObject
    {
        // Fields
        private static TMPro.TMP_Settings s_Instance;        // 0x0
        private System.Boolean m_enableWordWrapping;        // 0x18
        private System.Boolean m_enableKerning;        // 0x19
        private System.Boolean m_enableExtraPadding;        // 0x1A
        private System.Boolean m_enableTintAllSprites;        // 0x1B
        private System.Boolean m_enableParseEscapeCharacters;        // 0x1C
        private System.Boolean m_EnableRaycastTarget;        // 0x1D
        private System.Boolean m_GetFontFeaturesAtRuntime;        // 0x1E
        private System.Int32 m_missingGlyphCharacter;        // 0x20
        private System.Boolean m_warningsDisabled;        // 0x24
        private TMPro.TMP_FontAsset m_defaultFontAsset;        // 0x28
        private System.String m_defaultFontAssetPath;        // 0x30
        private System.Single m_defaultFontSize;        // 0x38
        private System.Single m_defaultAutoSizeMinRatio;        // 0x3C
        private System.Single m_defaultAutoSizeMaxRatio;        // 0x40
        private UnityEngine.Vector2 m_defaultTextMeshProTextContainerSize;        // 0x44
        private UnityEngine.Vector2 m_defaultTextMeshProUITextContainerSize;        // 0x4C
        private System.Boolean m_autoSizeTextContainer;        // 0x54
        private System.Boolean m_IsTextObjectScaleStatic;        // 0x55
        private System.Collections.Generic.List<TMPro.TMP_FontAsset> m_fallbackFontAssets;        // 0x58
        private System.Boolean m_matchMaterialPreset;        // 0x60
        private TMPro.TMP_SpriteAsset m_defaultSpriteAsset;        // 0x68
        private System.String m_defaultSpriteAssetPath;        // 0x70
        private System.Boolean m_enableEmojiSupport;        // 0x78
        private System.UInt32 m_MissingCharacterSpriteUnicode;        // 0x7C
        private System.String m_defaultColorGradientPresetsPath;        // 0x80
        private TMPro.TMP_StyleSheet m_defaultStyleSheet;        // 0x88
        private System.String m_StyleSheetsResourcePath;        // 0x90
        private UnityEngine.TextAsset m_leadingCharacters;        // 0x98
        private UnityEngine.TextAsset m_followingCharacters;        // 0xA0
        private TMPro.TMP_Settings.LineBreakingTable m_linebreakingRules;        // 0xA8
        private System.Boolean m_UseModernHangulLineBreakingRules;        // 0xB0
        public TMPro.IFontAssetLoader dynamicFontAssetLoader;        // 0xB8

        // Methods
        private System.String get_version() { }
        private System.Boolean get_enableWordWrapping() { }
        private System.Boolean get_enableKerning() { }
        private System.Boolean get_enableExtraPadding() { }
        private System.Boolean get_enableTintAllSprites() { }
        private System.Boolean get_enableParseEscapeCharacters() { }
        private System.Boolean get_enableRaycastTarget() { }
        private System.Boolean get_getFontFeaturesAtRuntime() { }
        private System.Int32 get_missingGlyphCharacter() { }
        private System.Void set_missingGlyphCharacter(System.Int32 value) { }
        private System.Boolean get_warningsDisabled() { }
        private TMPro.TMP_FontAsset get_defaultFontAsset() { }
        private System.String get_defaultFontAssetPath() { }
        private System.Single get_defaultFontSize() { }
        private System.Single get_defaultTextAutoSizingMinRatio() { }
        private System.Single get_defaultTextAutoSizingMaxRatio() { }
        private UnityEngine.Vector2 get_defaultTextMeshProTextContainerSize() { }
        private UnityEngine.Vector2 get_defaultTextMeshProUITextContainerSize() { }
        private System.Boolean get_autoSizeTextContainer() { }
        private System.Boolean get_isTextObjectScaleStatic() { }
        private System.Void set_isTextObjectScaleStatic(System.Boolean value) { }
        private System.Collections.Generic.List<TMPro.TMP_FontAsset> get_fallbackFontAssets() { }
        private System.Boolean get_matchMaterialPreset() { }
        private TMPro.TMP_SpriteAsset get_defaultSpriteAsset() { }
        private System.String get_defaultSpriteAssetPath() { }
        private System.Boolean get_enableEmojiSupport() { }
        private System.Void set_enableEmojiSupport(System.Boolean value) { }
        private System.UInt32 get_missingCharacterSpriteUnicode() { }
        private System.Void set_missingCharacterSpriteUnicode(System.UInt32 value) { }
        private System.String get_defaultColorGradientPresetsPath() { }
        private TMPro.TMP_StyleSheet get_defaultStyleSheet() { }
        private System.String get_styleSheetsResourcePath() { }
        private UnityEngine.TextAsset get_leadingCharacters() { }
        private UnityEngine.TextAsset get_followingCharacters() { }
        private TMPro.TMP_Settings.LineBreakingTable get_linebreakingRules() { }
        private System.Boolean get_useModernHangulLineBreakingRules() { }
        private System.Void set_useModernHangulLineBreakingRules(System.Boolean value) { }
        private TMPro.TMP_Settings get_instance() { }
        private TMPro.TMP_Settings LoadDefaultSettings() { }
        private TMPro.TMP_Settings GetSettings() { }
        private TMPro.TMP_FontAsset GetFontAsset() { }
        private System.Void ClearDefaultFontAsset() { }
        private TMPro.TMP_SpriteAsset GetSpriteAsset() { }
        private TMPro.TMP_StyleSheet GetStyleSheet() { }
        private System.Void LoadLinebreakingRules() { }
        private TMPro.IFontAssetLoader GetDynamicFallbackFontAssetLoader() { }
        private System.Collections.Generic.Dictionary<System.Int32,System.Char> GetCharacters(UnityEngine.TextAsset file) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007E
    public class ShaderUtilities
    {
        // Fields
        public static System.Int32 ID_MainTex;        // 0x0
        public static System.Int32 ID_FaceTex;        // 0x4
        public static System.Int32 ID_FaceColor;        // 0x8
        public static System.Int32 ID_FaceDilate;        // 0xC
        public static System.Int32 ID_Shininess;        // 0x10
        public static System.Int32 ID_UnderlayColor;        // 0x14
        public static System.Int32 ID_UnderlayOffsetX;        // 0x18
        public static System.Int32 ID_UnderlayOffsetY;        // 0x1C
        public static System.Int32 ID_UnderlayDilate;        // 0x20
        public static System.Int32 ID_UnderlaySoftness;        // 0x24
        public static System.Int32 ID_UnderlayOffset;        // 0x28
        public static System.Int32 ID_UnderlayIsoPerimeter;        // 0x2C
        public static System.Int32 ID_WeightNormal;        // 0x30
        public static System.Int32 ID_WeightBold;        // 0x34
        public static System.Int32 ID_OutlineTex;        // 0x38
        public static System.Int32 ID_OutlineWidth;        // 0x3C
        public static System.Int32 ID_OutlineSoftness;        // 0x40
        public static System.Int32 ID_OutlineColor;        // 0x44
        public static System.Int32 ID_Outline2Color;        // 0x48
        public static System.Int32 ID_Outline2Width;        // 0x4C
        public static System.Int32 ID_Padding;        // 0x50
        public static System.Int32 ID_GradientScale;        // 0x54
        public static System.Int32 ID_ScaleX;        // 0x58
        public static System.Int32 ID_ScaleY;        // 0x5C
        public static System.Int32 ID_PerspectiveFilter;        // 0x60
        public static System.Int32 ID_Sharpness;        // 0x64
        public static System.Int32 ID_TextureWidth;        // 0x68
        public static System.Int32 ID_TextureHeight;        // 0x6C
        public static System.Int32 ID_BevelAmount;        // 0x70
        public static System.Int32 ID_GlowColor;        // 0x74
        public static System.Int32 ID_GlowOffset;        // 0x78
        public static System.Int32 ID_GlowPower;        // 0x7C
        public static System.Int32 ID_GlowOuter;        // 0x80
        public static System.Int32 ID_GlowInner;        // 0x84
        public static System.Int32 ID_LightAngle;        // 0x88
        public static System.Int32 ID_EnvMap;        // 0x8C
        public static System.Int32 ID_EnvMatrix;        // 0x90
        public static System.Int32 ID_EnvMatrixRotation;        // 0x94
        public static System.Int32 ID_MaskCoord;        // 0x98
        public static System.Int32 ID_ClipRect;        // 0x9C
        public static System.Int32 ID_MaskSoftnessX;        // 0xA0
        public static System.Int32 ID_MaskSoftnessY;        // 0xA4
        public static System.Int32 ID_VertexOffsetX;        // 0xA8
        public static System.Int32 ID_VertexOffsetY;        // 0xAC
        public static System.Int32 ID_UseClipRect;        // 0xB0
        public static System.Int32 ID_StencilID;        // 0xB4
        public static System.Int32 ID_StencilOp;        // 0xB8
        public static System.Int32 ID_StencilComp;        // 0xBC
        public static System.Int32 ID_StencilReadMask;        // 0xC0
        public static System.Int32 ID_StencilWriteMask;        // 0xC4
        public static System.Int32 ID_ShaderFlags;        // 0xC8
        public static System.Int32 ID_ScaleRatio_A;        // 0xCC
        public static System.Int32 ID_ScaleRatio_B;        // 0xD0
        public static System.Int32 ID_ScaleRatio_C;        // 0xD4
        public static System.Int32 ID_UseClipSceneDepth;        // 0xD8
        public static System.Int32 ID_UsedForWorldUI;        // 0xDC
        public static System.String Keyword_ClipSceneDepth;        // 0xE0
        public static System.String Keyword_UsedForWorldUI;        // 0xE8
        public static System.String Keyword_Bevel;        // 0xF0
        public static System.String Keyword_Glow;        // 0xF8
        public static System.String Keyword_Underlay;        // 0x100
        public static System.String Keyword_Ratios;        // 0x108
        public static System.String Keyword_MASK_SOFT;        // 0x110
        public static System.String Keyword_MASK_HARD;        // 0x118
        public static System.String Keyword_MASK_TEX;        // 0x120
        public static System.String Keyword_Outline;        // 0x128
        public static System.String ShaderTag_ZTestMode;        // 0x130
        public static System.String ShaderTag_CullMode;        // 0x138
        private static System.Single m_clamp;        // 0x140
        public static System.Boolean isInitialized;        // 0x144
        private static UnityEngine.Shader k_ShaderRef_MobileSDF;        // 0x148
        private static UnityEngine.Shader k_ShaderRef_MobileBitmap;        // 0x150

        // Methods
        private UnityEngine.Shader get_ShaderRef_MobileSDF() { }
        private UnityEngine.Shader get_ShaderRef_MobileBitmap() { }
        private System.Void .cctor() { }
        private System.Void GetShaderPropertyIDs() { }
        private System.Void UpdateShaderRatios(UnityEngine.Material mat) { }
        private UnityEngine.Vector4 GetFontExtent(UnityEngine.Material material) { }
        private System.Boolean IsMaskingEnabled(UnityEngine.Material material) { }
        private System.Single GetPadding(UnityEngine.Material material, System.Boolean enableExtraPadding, System.Boolean isBold) { }
        private System.Single GetPadding(UnityEngine.Material[] materials, System.Boolean enableExtraPadding, System.Boolean isBold) { }

    }

    // TypeToken: 0x200007F
    public class TMP_Sprite : TMP_TextElement_Legacy
    {
        // Fields
        public System.String name;        // 0x38
        public System.Int32 hashCode;        // 0x40
        public System.Int32 unicode;        // 0x44
        public UnityEngine.Vector2 pivot;        // 0x48
        public UnityEngine.Sprite sprite;        // 0x50

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000080
    public class TMP_SpriteAnimator : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.Int32,System.Boolean> m_animations;        // 0x18
        private TMPro.TMP_Text m_TextComponent;        // 0x20

        // Methods
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void StopAllAnimations() { }
        private System.Void DoSpriteAnimation(System.Int32 currentCharacter, TMPro.TMP_SpriteAsset spriteAsset, System.Int32 start, System.Int32 end, System.Int32 framerate) { }
        private System.Collections.IEnumerator DoSpriteAnimationInternal(System.Int32 currentCharacter, TMPro.TMP_SpriteAsset spriteAsset, System.Int32 start, System.Int32 end, System.Int32 framerate) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000082
    public class TMP_SpriteAsset : TMP_Asset
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> m_NameLookup;        // 0x30
        private System.Collections.Generic.Dictionary<System.UInt32,System.Int32> m_GlyphIndexLookup;        // 0x38
        private System.String m_Version;        // 0x40
        private UnityEngine.TextCore.FaceInfo m_FaceInfo;        // 0x48
        public UnityEngine.Texture spriteSheet;        // 0xA8
        private System.Collections.Generic.List<TMPro.TMP_SpriteCharacter> m_SpriteCharacterTable;        // 0xB0
        private System.Collections.Generic.Dictionary<System.UInt32,TMPro.TMP_SpriteCharacter> m_SpriteCharacterLookup;        // 0xB8
        private System.Collections.Generic.List<TMPro.TMP_SpriteGlyph> m_SpriteGlyphTable;        // 0xC0
        private System.Collections.Generic.Dictionary<System.UInt32,TMPro.TMP_SpriteGlyph> m_SpriteGlyphLookup;        // 0xC8
        public System.Collections.Generic.List<TMPro.TMP_Sprite> spriteInfoList;        // 0xD0
        public System.Collections.Generic.List<TMPro.TMP_SpriteAsset> fallbackSpriteAssets;        // 0xD8
        private System.Boolean m_IsSpriteAssetLookupTablesDirty;        // 0xE0
        private static System.Collections.Generic.HashSet<System.Int32> k_searchedSpriteAssets;        // 0x0

        // Methods
        private System.String get_version() { }
        private System.Void set_version(System.String value) { }
        private UnityEngine.TextCore.FaceInfo get_faceInfo() { }
        private System.Void set_faceInfo(UnityEngine.TextCore.FaceInfo value) { }
        private System.Collections.Generic.List<TMPro.TMP_SpriteCharacter> get_spriteCharacterTable() { }
        private System.Void set_spriteCharacterTable(System.Collections.Generic.List<TMPro.TMP_SpriteCharacter> value) { }
        private System.Collections.Generic.Dictionary<System.UInt32,TMPro.TMP_SpriteCharacter> get_spriteCharacterLookupTable() { }
        private System.Void set_spriteCharacterLookupTable(System.Collections.Generic.Dictionary<System.UInt32,TMPro.TMP_SpriteCharacter> value) { }
        private System.Collections.Generic.List<TMPro.TMP_SpriteGlyph> get_spriteGlyphTable() { }
        private System.Void set_spriteGlyphTable(System.Collections.Generic.List<TMPro.TMP_SpriteGlyph> value) { }
        private System.Void Awake() { }
        private UnityEngine.Material GetDefaultSpriteMaterial() { }
        private System.Void UpdateLookupTables() { }
        private System.Int32 GetSpriteIndexFromHashcode(System.Int32 hashCode) { }
        private System.Int32 GetSpriteIndexFromUnicode(System.UInt32 unicode) { }
        private System.Int32 GetSpriteIndexFromName(System.String name) { }
        private TMPro.TMP_SpriteAsset SearchForSpriteByUnicode(TMPro.TMP_SpriteAsset spriteAsset, System.UInt32 unicode, System.Boolean includeFallbacks, System.Int32& spriteIndex) { }
        private TMPro.TMP_SpriteAsset SearchForSpriteByUnicodeInternal(System.Collections.Generic.List<TMPro.TMP_SpriteAsset> spriteAssets, System.UInt32 unicode, System.Boolean includeFallbacks, System.Int32& spriteIndex) { }
        private TMPro.TMP_SpriteAsset SearchForSpriteByUnicodeInternal(TMPro.TMP_SpriteAsset spriteAsset, System.UInt32 unicode, System.Boolean includeFallbacks, System.Int32& spriteIndex) { }
        private TMPro.TMP_SpriteAsset SearchForSpriteByHashCode(TMPro.TMP_SpriteAsset spriteAsset, System.Int32 hashCode, System.Boolean includeFallbacks, System.Int32& spriteIndex) { }
        private TMPro.TMP_SpriteAsset SearchForSpriteByHashCodeInternal(System.Collections.Generic.List<TMPro.TMP_SpriteAsset> spriteAssets, System.Int32 hashCode, System.Boolean searchFallbacks, System.Int32& spriteIndex) { }
        private TMPro.TMP_SpriteAsset SearchForSpriteByHashCodeInternal(TMPro.TMP_SpriteAsset spriteAsset, System.Int32 hashCode, System.Boolean searchFallbacks, System.Int32& spriteIndex) { }
        private System.Void SortGlyphTable() { }
        private System.Void SortCharacterTable() { }
        private System.Void SortGlyphAndCharacterTables() { }
        private System.Void UpgradeSpriteAsset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000084
    public class TMP_SpriteCharacter : TMP_TextElement
    {
        // Fields
        private System.String m_Name;        // 0x30
        private System.Int32 m_HashCode;        // 0x38

        // Methods
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private System.Int32 get_hashCode() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.UInt32 unicode, TMPro.TMP_SpriteGlyph glyph) { }
        private System.Void .ctor(System.UInt32 unicode, TMPro.TMP_SpriteAsset spriteAsset, TMPro.TMP_SpriteGlyph glyph) { }
        private System.Void .ctor(System.UInt32 unicode, System.UInt32 glyphIndex) { }

    }

    // TypeToken: 0x2000085
    public class TMP_SpriteGlyph : Glyph
    {
        // Fields
        public UnityEngine.Sprite sprite;        // 0x48

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.UInt32 index, UnityEngine.TextCore.GlyphMetrics metrics, UnityEngine.TextCore.GlyphRect glyphRect, System.Single scale, System.Int32 atlasIndex) { }
        private System.Void .ctor(System.UInt32 index, UnityEngine.TextCore.GlyphMetrics metrics, UnityEngine.TextCore.GlyphRect glyphRect, System.Single scale, System.Int32 atlasIndex, UnityEngine.Sprite sprite) { }

    }

    // TypeToken: 0x2000086
    public class TMP_Style
    {
        // Fields
        private static TMPro.TMP_Style k_NormalStyle;        // 0x0
        private System.String m_Name;        // 0x10
        private System.Int32 m_HashCode;        // 0x18
        private System.String m_OpeningDefinition;        // 0x20
        private System.String m_ClosingDefinition;        // 0x28
        private System.Int32[] m_OpeningTagArray;        // 0x30
        private System.Int32[] m_ClosingTagArray;        // 0x38
        private System.UInt32[] m_OpeningTagUnicodeArray;        // 0x40
        private System.UInt32[] m_ClosingTagUnicodeArray;        // 0x48

        // Methods
        private TMPro.TMP_Style get_NormalStyle() { }
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private System.Int32 get_hashCode() { }
        private System.Void set_hashCode(System.Int32 value) { }
        private System.String get_styleOpeningDefinition() { }
        private System.String get_styleClosingDefinition() { }
        private System.Int32[] get_styleOpeningTagArray() { }
        private System.Int32[] get_styleClosingTagArray() { }
        private System.Void .ctor(System.String styleName, System.String styleOpeningDefinition, System.String styleClosingDefinition) { }
        private System.Void RefreshStyle() { }

    }

    // TypeToken: 0x2000087
    public class TMP_StyleSheet : ScriptableObject
    {
        // Fields
        private System.Collections.Generic.List<TMPro.TMP_Style> m_StyleList;        // 0x18
        private System.Collections.Generic.Dictionary<System.Int32,TMPro.TMP_Style> m_StyleLookupDictionary;        // 0x20

        // Methods
        private System.Collections.Generic.List<TMPro.TMP_Style> get_styles() { }
        private System.Void Reset() { }
        private TMPro.TMP_Style GetStyle(System.Int32 hashCode) { }
        private TMPro.TMP_Style GetStyle(System.String name) { }
        private System.Void RefreshStyles() { }
        private System.Void LoadStyleDictionaryInternal() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000088
    public class TMP_SubMesh : MonoBehaviour
    {
        // Fields
        private TMPro.TMP_FontAsset m_fontAsset;        // 0x18
        private TMPro.TMP_SpriteAsset m_spriteAsset;        // 0x20
        private UnityEngine.Material m_material;        // 0x28
        private UnityEngine.Material m_sharedMaterial;        // 0x30
        private UnityEngine.Material m_fallbackMaterial;        // 0x38
        private UnityEngine.Material m_fallbackSourceMaterial;        // 0x40
        private System.Boolean m_isDefaultMaterial;        // 0x48
        private System.Single m_padding;        // 0x4C
        private UnityEngine.Renderer m_renderer;        // 0x50
        private UnityEngine.MeshFilter m_meshFilter;        // 0x58
        private UnityEngine.Mesh m_mesh;        // 0x60
        private TMPro.TextMeshPro m_TextComponent;        // 0x68
        private System.Boolean m_isRegisteredForEvents;        // 0x70

        // Methods
        private TMPro.TMP_FontAsset get_fontAsset() { }
        private System.Void set_fontAsset(TMPro.TMP_FontAsset value) { }
        private TMPro.TMP_SpriteAsset get_spriteAsset() { }
        private System.Void set_spriteAsset(TMPro.TMP_SpriteAsset value) { }
        private UnityEngine.Material get_material() { }
        private System.Void set_material(UnityEngine.Material value) { }
        private UnityEngine.Material get_sharedMaterial() { }
        private System.Void set_sharedMaterial(UnityEngine.Material value) { }
        private UnityEngine.Material get_fallbackMaterial() { }
        private System.Void set_fallbackMaterial(UnityEngine.Material value) { }
        private UnityEngine.Material get_fallbackSourceMaterial() { }
        private System.Void set_fallbackSourceMaterial(UnityEngine.Material value) { }
        private System.Boolean get_isDefaultMaterial() { }
        private System.Void set_isDefaultMaterial(System.Boolean value) { }
        private System.Single get_padding() { }
        private System.Void set_padding(System.Single value) { }
        private UnityEngine.Renderer get_renderer() { }
        private UnityEngine.MeshFilter get_meshFilter() { }
        private UnityEngine.Mesh get_mesh() { }
        private System.Void set_mesh(UnityEngine.Mesh value) { }
        private TMPro.TMP_Text get_textComponent() { }
        private TMPro.TMP_SubMesh AddSubTextObject(TMPro.TextMeshPro textComponent, TMPro.MaterialReference materialReference) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void DestroySelf() { }
        private UnityEngine.Material GetMaterial(UnityEngine.Material mat) { }
        private UnityEngine.Material CreateMaterialInstance(UnityEngine.Material source) { }
        private UnityEngine.Material GetSharedMaterial() { }
        private System.Void SetSharedMaterial(UnityEngine.Material mat) { }
        private System.Single GetPaddingForMaterial() { }
        private System.Void UpdateMeshPadding(System.Boolean isExtraPadding, System.Boolean isUsingBold) { }
        private System.Void SetVerticesDirty() { }
        private System.Void SetMaterialDirty() { }
        private System.Void UpdateMaterial() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000089
    public class TMP_SubMeshUI : MaskableGraphic
    {
        // Fields
        private TMPro.TMP_FontAsset m_fontAsset;        // 0xE8
        private TMPro.TMP_SpriteAsset m_spriteAsset;        // 0xF0
        private UnityEngine.Material m_material;        // 0xF8
        private UnityEngine.Material m_sharedMaterial;        // 0x100
        private UnityEngine.Material m_fallbackMaterial;        // 0x108
        private UnityEngine.Material m_fallbackSourceMaterial;        // 0x110
        private System.Boolean m_isDefaultMaterial;        // 0x118
        private System.Single m_padding;        // 0x11C
        private UnityEngine.Mesh m_mesh;        // 0x120
        private TMPro.TextMeshProUGUI m_TextComponent;        // 0x128
        private System.Boolean m_isRegisteredForEvents;        // 0x130
        private System.Boolean m_materialDirty;        // 0x131
        private System.Int32 m_materialReferenceIndex;        // 0x134
        private UnityEngine.Transform m_RootCanvasTransform;        // 0x138

        // Methods
        private TMPro.TMP_FontAsset get_fontAsset() { }
        private System.Void set_fontAsset(TMPro.TMP_FontAsset value) { }
        private TMPro.TMP_SpriteAsset get_spriteAsset() { }
        private System.Void set_spriteAsset(TMPro.TMP_SpriteAsset value) { }
        private UnityEngine.Texture get_mainTexture() { }
        private UnityEngine.Material get_material() { }
        private System.Void set_material(UnityEngine.Material value) { }
        private UnityEngine.Material get_sharedMaterial() { }
        private System.Void set_sharedMaterial(UnityEngine.Material value) { }
        private UnityEngine.Material get_fallbackMaterial() { }
        private System.Void set_fallbackMaterial(UnityEngine.Material value) { }
        private UnityEngine.Material get_fallbackSourceMaterial() { }
        private System.Void set_fallbackSourceMaterial(UnityEngine.Material value) { }
        private UnityEngine.Material get_materialForRendering() { }
        private System.Boolean get_isDefaultMaterial() { }
        private System.Void set_isDefaultMaterial(System.Boolean value) { }
        private System.Single get_padding() { }
        private System.Void set_padding(System.Single value) { }
        private UnityEngine.Mesh get_mesh() { }
        private System.Void set_mesh(UnityEngine.Mesh value) { }
        private TMPro.TMP_Text get_textComponent() { }
        private TMPro.TMP_SubMeshUI AddSubTextObject(TMPro.TextMeshProUGUI textComponent, TMPro.MaterialReference materialReference) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void OnTransformParentChanged() { }
        private UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial) { }
        private System.Single GetPaddingForMaterial() { }
        private System.Single GetPaddingForMaterial(UnityEngine.Material mat) { }
        private System.Void UpdateMeshPadding(System.Boolean isExtraPadding, System.Boolean isUsingBold) { }
        private System.Void SetAllDirty() { }
        private System.Void SetVerticesDirty() { }
        private System.Void SetLayoutDirty() { }
        private System.Void SetMaterialDirty() { }
        private System.Void SetPivotDirty() { }
        private UnityEngine.Transform GetRootCanvasTransform() { }
        private System.Void Cull(UnityEngine.Rect clipRect, System.Boolean validRect) { }
        private System.Void UpdateGeometry() { }
        private System.Void Rebuild(UnityEngine.UI.CanvasUpdate update) { }
        private System.Void RefreshMaterial() { }
        private System.Void UpdateMaterial() { }
        private System.Void RecalculateClipping() { }
        private UnityEngine.Material GetMaterial() { }
        private UnityEngine.Material GetMaterial(UnityEngine.Material mat) { }
        private UnityEngine.Material CreateMaterialInstance(UnityEngine.Material source) { }
        private UnityEngine.Material GetSharedMaterial() { }
        private System.Void SetSharedMaterial(UnityEngine.Material mat) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008A
    public interface ITextElement
    {
        // Methods
        private UnityEngine.Material get_sharedMaterial() { }
        private System.Void Rebuild(UnityEngine.UI.CanvasUpdate update) { }
        private System.Int32 GetInstanceID() { }

    }

    // TypeToken: 0x200008B
    public struct TextAlignmentOptions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.TextAlignmentOptions TopLeft;        // 0x0
        public static TMPro.TextAlignmentOptions Top;        // 0x0
        public static TMPro.TextAlignmentOptions TopRight;        // 0x0
        public static TMPro.TextAlignmentOptions TopJustified;        // 0x0
        public static TMPro.TextAlignmentOptions TopFlush;        // 0x0
        public static TMPro.TextAlignmentOptions TopGeoAligned;        // 0x0
        public static TMPro.TextAlignmentOptions Left;        // 0x0
        public static TMPro.TextAlignmentOptions Center;        // 0x0
        public static TMPro.TextAlignmentOptions Right;        // 0x0
        public static TMPro.TextAlignmentOptions Justified;        // 0x0
        public static TMPro.TextAlignmentOptions Flush;        // 0x0
        public static TMPro.TextAlignmentOptions CenterGeoAligned;        // 0x0
        public static TMPro.TextAlignmentOptions BottomLeft;        // 0x0
        public static TMPro.TextAlignmentOptions Bottom;        // 0x0
        public static TMPro.TextAlignmentOptions BottomRight;        // 0x0
        public static TMPro.TextAlignmentOptions BottomJustified;        // 0x0
        public static TMPro.TextAlignmentOptions BottomFlush;        // 0x0
        public static TMPro.TextAlignmentOptions BottomGeoAligned;        // 0x0
        public static TMPro.TextAlignmentOptions BaselineLeft;        // 0x0
        public static TMPro.TextAlignmentOptions Baseline;        // 0x0
        public static TMPro.TextAlignmentOptions BaselineRight;        // 0x0
        public static TMPro.TextAlignmentOptions BaselineJustified;        // 0x0
        public static TMPro.TextAlignmentOptions BaselineFlush;        // 0x0
        public static TMPro.TextAlignmentOptions BaselineGeoAligned;        // 0x0
        public static TMPro.TextAlignmentOptions MidlineLeft;        // 0x0
        public static TMPro.TextAlignmentOptions Midline;        // 0x0
        public static TMPro.TextAlignmentOptions MidlineRight;        // 0x0
        public static TMPro.TextAlignmentOptions MidlineJustified;        // 0x0
        public static TMPro.TextAlignmentOptions MidlineFlush;        // 0x0
        public static TMPro.TextAlignmentOptions MidlineGeoAligned;        // 0x0
        public static TMPro.TextAlignmentOptions CaplineLeft;        // 0x0
        public static TMPro.TextAlignmentOptions Capline;        // 0x0
        public static TMPro.TextAlignmentOptions CaplineRight;        // 0x0
        public static TMPro.TextAlignmentOptions CaplineJustified;        // 0x0
        public static TMPro.TextAlignmentOptions CaplineFlush;        // 0x0
        public static TMPro.TextAlignmentOptions CaplineGeoAligned;        // 0x0
        public static TMPro.TextAlignmentOptions Converted;        // 0x0

    }

    // TypeToken: 0x200008C
    public struct HorizontalAlignmentOptions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.HorizontalAlignmentOptions Left;        // 0x0
        public static TMPro.HorizontalAlignmentOptions Center;        // 0x0
        public static TMPro.HorizontalAlignmentOptions Right;        // 0x0
        public static TMPro.HorizontalAlignmentOptions Justified;        // 0x0
        public static TMPro.HorizontalAlignmentOptions Flush;        // 0x0
        public static TMPro.HorizontalAlignmentOptions Geometry;        // 0x0

    }

    // TypeToken: 0x200008D
    public struct VerticalAlignmentOptions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.VerticalAlignmentOptions Top;        // 0x0
        public static TMPro.VerticalAlignmentOptions Middle;        // 0x0
        public static TMPro.VerticalAlignmentOptions Bottom;        // 0x0
        public static TMPro.VerticalAlignmentOptions Baseline;        // 0x0
        public static TMPro.VerticalAlignmentOptions Geometry;        // 0x0
        public static TMPro.VerticalAlignmentOptions Capline;        // 0x0

    }

    // TypeToken: 0x200008E
    public struct TextRenderFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.TextRenderFlags DontRender;        // 0x0
        public static TMPro.TextRenderFlags Render;        // 0x0

    }

    // TypeToken: 0x200008F
    public struct TMP_TextElementType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.TMP_TextElementType Character;        // 0x0
        public static TMPro.TMP_TextElementType Sprite;        // 0x0
        public static TMPro.TMP_TextElementType Image;        // 0x0

    }

    // TypeToken: 0x2000090
    public struct MaskingTypes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.MaskingTypes MaskOff;        // 0x0
        public static TMPro.MaskingTypes MaskHard;        // 0x0
        public static TMPro.MaskingTypes MaskSoft;        // 0x0

    }

    // TypeToken: 0x2000091
    public struct TextOverflowModes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.TextOverflowModes Overflow;        // 0x0
        public static TMPro.TextOverflowModes Ellipsis;        // 0x0
        public static TMPro.TextOverflowModes Masking;        // 0x0
        public static TMPro.TextOverflowModes Truncate;        // 0x0
        public static TMPro.TextOverflowModes ScrollRect;        // 0x0
        public static TMPro.TextOverflowModes Page;        // 0x0
        public static TMPro.TextOverflowModes Linked;        // 0x0

    }

    // TypeToken: 0x2000092
    public struct MaskingOffsetMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.MaskingOffsetMode Percentage;        // 0x0
        public static TMPro.MaskingOffsetMode Pixel;        // 0x0

    }

    // TypeToken: 0x2000093
    public struct TextureMappingOptions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.TextureMappingOptions Character;        // 0x0
        public static TMPro.TextureMappingOptions Line;        // 0x0
        public static TMPro.TextureMappingOptions Paragraph;        // 0x0
        public static TMPro.TextureMappingOptions MatchAspect;        // 0x0

    }

    // TypeToken: 0x2000094
    public struct FontStyles
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.FontStyles Normal;        // 0x0
        public static TMPro.FontStyles Bold;        // 0x0
        public static TMPro.FontStyles Italic;        // 0x0
        public static TMPro.FontStyles Underline;        // 0x0
        public static TMPro.FontStyles LowerCase;        // 0x0
        public static TMPro.FontStyles UpperCase;        // 0x0
        public static TMPro.FontStyles SmallCaps;        // 0x0
        public static TMPro.FontStyles Strikethrough;        // 0x0
        public static TMPro.FontStyles Superscript;        // 0x0
        public static TMPro.FontStyles Subscript;        // 0x0
        public static TMPro.FontStyles Highlight;        // 0x0
        public static TMPro.FontStyles Phonetic;        // 0x0

    }

    // TypeToken: 0x2000095
    public struct FontWeight
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.FontWeight Thin;        // 0x0
        public static TMPro.FontWeight ExtraLight;        // 0x0
        public static TMPro.FontWeight Light;        // 0x0
        public static TMPro.FontWeight Regular;        // 0x0
        public static TMPro.FontWeight Medium;        // 0x0
        public static TMPro.FontWeight SemiBold;        // 0x0
        public static TMPro.FontWeight Bold;        // 0x0
        public static TMPro.FontWeight Heavy;        // 0x0
        public static TMPro.FontWeight Black;        // 0x0

    }

    // TypeToken: 0x2000096
    public class PhoneticData
    {
        // Fields
        public static TMPro.PhoneticData Default;        // 0x0
        public System.String m_phonetic;        // 0x10
        public System.Boolean m_autoSize;        // 0x18
        public System.Boolean m_padding;        // 0x19
        public System.Boolean m_justify;        // 0x1A
        public System.Int32 m_length;        // 0x1C
        public System.Int32 m_startIndex;        // 0x20
        public System.Int32 m_startCharCount;        // 0x24

        // Methods
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000097
    public class TMP_Text : MaskableGraphic
    {
        // Fields
        protected System.String m_textForPopulate;        // 0xE8
        protected System.String m_text;        // 0xF0
        private System.Boolean m_IsTextBackingStringDirty;        // 0xF8
        protected TMPro.ITextPreprocessor m_TextPreprocessor;        // 0x100
        protected System.Boolean m_isRightToLeft;        // 0x108
        protected TMPro.TMP_FontAsset m_serializedFontAsset;        // 0x110
        protected TMPro.TMP_FontAsset m_currentFontAsset;        // 0x118
        protected System.Boolean m_isSDFShader;        // 0x120
        protected UnityEngine.Material m_sharedMaterial;        // 0x128
        protected UnityEngine.Material m_currentMaterial;        // 0x130
        protected static TMPro.MaterialReference[] m_materialReferences;        // 0x0
        protected static System.Collections.Generic.Dictionary<System.Int32,System.Int32> m_materialReferenceIndexLookup;        // 0x8
        protected static TMPro.TMP_TextProcessingStack<TMPro.MaterialReference> m_materialReferenceStack;        // 0x10
        protected System.Int32 m_currentMaterialIndex;        // 0x138
        protected UnityEngine.Material[] m_fontSharedMaterials;        // 0x140
        protected UnityEngine.Material m_fontMaterial;        // 0x148
        protected UnityEngine.Material[] m_fontMaterials;        // 0x150
        protected System.Boolean m_isMaterialDirty;        // 0x158
        protected UnityEngine.Color32 m_fontColor32;        // 0x15C
        protected UnityEngine.Color m_fontColor;        // 0x160
        protected static UnityEngine.Color32 s_colorWhite;        // 0x68
        protected UnityEngine.Color32 m_underlineColor;        // 0x170
        protected UnityEngine.Color32 m_strikethroughColor;        // 0x174
        protected System.Boolean m_enableVertexGradient;        // 0x178
        protected TMPro.ColorMode m_colorMode;        // 0x17C
        protected TMPro.VertexGradient m_fontColorGradient;        // 0x180
        protected TMPro.TMP_ColorGradient m_fontColorGradientPreset;        // 0x1C0
        protected TMPro.TMP_SpriteAsset m_spriteAsset;        // 0x1C8
        protected System.Boolean m_tintAllSprites;        // 0x1D0
        protected System.Boolean m_tintSprite;        // 0x1D1
        protected UnityEngine.Color32 m_spriteColor;        // 0x1D4
        protected TMPro.TMP_StyleSheet m_StyleSheet;        // 0x1D8
        private TMPro.TMP_Style m_TextStyle;        // 0x1E0
        protected System.Int32 m_TextStyleHashCode;        // 0x1E8
        protected System.Boolean m_overrideHtmlColors;        // 0x1EC
        protected UnityEngine.Color32 m_faceColor;        // 0x1F0
        protected UnityEngine.Color32 m_outlineColor;        // 0x1F4
        protected System.Single m_outlineWidth;        // 0x1F8
        protected System.Single m_fontSize;        // 0x1FC
        protected System.Single m_currentFontSize;        // 0x200
        protected System.Single m_fontSizeBase;        // 0x204
        protected TMPro.TMP_TextProcessingStack<System.Single> m_sizeStack;        // 0x208
        protected System.Single m_imageWidth;        // 0x228
        protected System.Single m_imageHeight;        // 0x22C
        protected System.Single m_maxLineAscenderWithImage;        // 0x230
        protected static System.Single m_basePhoneticElementScale;        // 0x0
        protected TMPro.FontStyles m_phoneticFontStyle;        // 0x234
        protected TMPro.FontWeight m_phoneticFontWeight;        // 0x238
        protected TMPro.WordWrapState m_phoneticWordWarpState;        // 0x240
        protected System.Int32 m_phoneticStartCharIndex;        // 0x5D8
        protected System.Int32 m_phoneticStartIndex;        // 0x5DC
        protected System.Int32 m_phoneticEndIndex;        // 0x5E0
        protected System.Boolean m_isPhoneticOverLength;        // 0x5E4
        protected System.Collections.Generic.List<System.Single> m_phoneticSizeList;        // 0x5E8
        protected TMPro.TMP_TextProcessingQueue<TMPro.PhoneticData> m_phoneticDataQueue;        // 0x5F0
        protected TMPro.PhoneticData m_currentPhoneticData;        // 0x610
        protected System.Int32 m_phoneticCount;        // 0x618
        protected System.Single m_phoneticFontSize;        // 0x61C
        protected System.Boolean m_showPhonetic;        // 0x620
        protected System.Int32 m_phoneticIndex;        // 0x624
        protected System.Boolean m_needParseActionId;        // 0x628
        protected TMPro.FontWeight m_fontWeight;        // 0x62C
        protected TMPro.FontWeight m_FontWeightInternal;        // 0x630
        protected TMPro.TMP_TextProcessingStack<TMPro.FontWeight> m_FontWeightStack;        // 0x638
        protected System.Boolean m_enableAutoSizing;        // 0x658
        protected System.Single m_maxFontSize;        // 0x65C
        protected System.Single m_minFontSize;        // 0x660
        protected System.Int32 m_AutoSizeIterationCount;        // 0x664
        protected System.Int32 m_AutoSizeMaxIterationCount;        // 0x668
        protected System.Boolean m_IsAutoSizePointSizeSet;        // 0x66C
        protected System.Single m_fontSizeMin;        // 0x670
        protected System.Single m_fontSizeMax;        // 0x674
        protected TMPro.FontStyles m_fontStyle;        // 0x678
        protected TMPro.FontStyles m_FontStyleInternal;        // 0x67C
        protected TMPro.TMP_FontStyleStack m_fontStyleStack;        // 0x680
        protected System.Boolean m_isUsingBold;        // 0x68A
        protected TMPro.HorizontalAlignmentOptions m_HorizontalAlignment;        // 0x68C
        protected TMPro.VerticalAlignmentOptions m_VerticalAlignment;        // 0x690
        protected TMPro.TextAlignmentOptions m_textAlignment;        // 0x694
        protected TMPro.HorizontalAlignmentOptions m_lineJustification;        // 0x698
        protected TMPro.TMP_TextProcessingStack<TMPro.HorizontalAlignmentOptions> m_lineJustificationStack;        // 0x6A0
        protected UnityEngine.Vector3[] m_textContainerLocalCorners;        // 0x6C0
        protected System.Single m_characterSpacing;        // 0x6C8
        protected System.Single m_cSpacing;        // 0x6CC
        protected System.Single m_monoSpacing;        // 0x6D0
        protected System.Single m_wordSpacing;        // 0x6D4
        protected System.Single m_lineSpacing;        // 0x6D8
        protected System.Single m_lineSpacingDelta;        // 0x6DC
        protected System.Single m_lineHeight;        // 0x6E0
        protected System.Boolean m_IsDrivenLineSpacing;        // 0x6E4
        protected System.Single m_lineSpacingMax;        // 0x6E8
        protected System.Single m_paragraphSpacing;        // 0x6EC
        protected System.Single m_charWidthMaxAdj;        // 0x6F0
        protected System.Single m_charWidthAdjDelta;        // 0x6F4
        protected System.Boolean m_enableWordWrapping;        // 0x6F8
        protected System.Boolean m_isCharacterWrappingEnabled;        // 0x6F9
        protected System.Boolean m_isNonBreakingSpace;        // 0x6FA
        protected System.Boolean m_isIgnoringAlignment;        // 0x6FB
        protected System.Single m_wordWrappingRatios;        // 0x6FC
        protected TMPro.TextOverflowModes m_overflowMode;        // 0x700
        protected System.Int32 m_firstOverflowCharacterIndex;        // 0x704
        protected TMPro.TMP_Text m_linkedTextComponent;        // 0x708
        private TMPro.TMP_Text parentLinkedComponent;        // 0x710
        protected System.Boolean m_isTextTruncated;        // 0x718
        protected System.Boolean m_enableKerning;        // 0x719
        protected System.Single m_GlyphHorizontalAdvanceAdjustment;        // 0x71C
        protected System.Boolean m_enableExtraPadding;        // 0x720
        protected System.Boolean checkPaddingRequired;        // 0x721
        protected System.Boolean m_isRichText;        // 0x722
        protected System.Boolean m_enableHyperlink;        // 0x723
        protected System.Single m_richTextColorBlend;        // 0x724
        protected System.Boolean m_parseCtrlCharacters;        // 0x728
        protected System.Boolean m_isOverlay;        // 0x729
        protected System.Boolean m_isOrthographic;        // 0x72A
        protected System.Boolean m_isCullingEnabled;        // 0x72B
        protected System.Boolean m_isMaskingEnabled;        // 0x72C
        protected System.Boolean isMaskUpdateRequired;        // 0x72D
        protected System.Boolean m_ignoreCulling;        // 0x72E
        protected TMPro.TextureMappingOptions m_horizontalMapping;        // 0x730
        protected TMPro.TextureMappingOptions m_verticalMapping;        // 0x734
        protected System.Single m_uvLineOffset;        // 0x738
        protected TMPro.TextRenderFlags m_renderMode;        // 0x73C
        protected TMPro.VertexSortingOrder m_geometrySortingOrder;        // 0x740
        protected System.Boolean m_IsTextObjectScaleStatic;        // 0x744
        protected System.Boolean m_VertexBufferAutoSizeReduction;        // 0x745
        protected System.Int32 m_firstVisibleCharacter;        // 0x748
        protected System.Int32 m_maxVisibleCharacters;        // 0x74C
        protected System.Int32 m_maxVisibleWords;        // 0x750
        protected System.Int32 m_maxVisibleLines;        // 0x754
        protected System.Boolean m_useMaxVisibleDescender;        // 0x758
        protected System.Int32 m_pageToDisplay;        // 0x75C
        protected System.Boolean m_isNewPage;        // 0x760
        protected UnityEngine.Vector4 m_margin;        // 0x764
        protected System.Single m_marginLeft;        // 0x774
        protected System.Single m_marginRight;        // 0x778
        protected System.Single m_marginWidth;        // 0x77C
        protected System.Single m_marginHeight;        // 0x780
        protected System.Single m_width;        // 0x784
        protected TMPro.TMP_TextInfo m_textInfo;        // 0x788
        protected System.Boolean m_havePropertiesChanged;        // 0x790
        protected System.Boolean m_isUsingLegacyAnimationComponent;        // 0x791
        protected UnityEngine.Transform m_transform;        // 0x798
        protected UnityEngine.RectTransform m_rectTransform;        // 0x7A0
        protected UnityEngine.Vector2 m_PreviousRectTransformSize;        // 0x7A8
        protected UnityEngine.Vector2 m_PreviousPivotPosition;        // 0x7B0
        private System.Boolean <autoSizeTextContainer>k__BackingField;        // 0x7B8
        protected System.Boolean m_autoSizeTextContainer;        // 0x7B9
        protected UnityEngine.Mesh m_mesh;        // 0x7C0
        protected System.Boolean m_isVolumetricText;        // 0x7C8
        private static System.Func<System.Int32,System.String,TMPro.TMP_FontAsset> OnFontAssetRequest;        // 0x70
        private static System.Func<System.Int32,System.String,TMPro.TMP_SpriteAsset> OnSpriteAssetRequest;        // 0x78
        private System.Action<TMPro.TMP_TextInfo> OnPreRenderText;        // 0x7D0
        protected TMPro.TMP_SpriteAnimator m_spriteAnimator;        // 0x7D8
        protected System.Single m_flexibleHeight;        // 0x7E0
        protected System.Single m_flexibleWidth;        // 0x7E4
        protected System.Single m_minWidth;        // 0x7E8
        protected System.Single m_minHeight;        // 0x7EC
        protected System.Single m_maxWidth;        // 0x7F0
        protected System.Single m_maxHeight;        // 0x7F4
        protected UnityEngine.UI.LayoutElement m_LayoutElement;        // 0x7F8
        protected System.Single m_preferredWidth;        // 0x800
        protected System.Single m_renderedWidth;        // 0x804
        protected System.Boolean m_isPreferredWidthDirty;        // 0x808
        protected System.Single m_preferredHeight;        // 0x80C
        protected System.Single m_renderedHeight;        // 0x810
        protected System.Boolean m_isPreferredHeightDirty;        // 0x814
        protected System.Boolean m_isCalculatingPreferredValues;        // 0x815
        protected System.Int32 m_layoutPriority;        // 0x818
        protected System.Boolean m_isLayoutDirty;        // 0x81C
        protected System.Boolean m_isAwake;        // 0x81D
        private System.Boolean m_isWaitingOnResourceLoad;        // 0x81E
        protected System.Boolean m_isInit;        // 0x81F
        private TMPro.TMP_Text.TextInputSources m_inputSource;        // 0x820
        protected System.Single m_fontScaleMultiplier;        // 0x824
        private static System.Char[] m_htmlTag;        // 0x80
        protected static TMPro.RichTextTagAttribute[] m_xmlAttribute;        // 0x88
        private static System.Single[] m_attributeParameterValues;        // 0x90
        protected System.Single tag_LineIndent;        // 0x828
        protected System.Single tag_Indent;        // 0x82C
        protected TMPro.TMP_TextProcessingStack<System.Single> m_indentStack;        // 0x830
        protected System.Boolean tag_NoParsing;        // 0x850
        protected System.Boolean m_isParsingText;        // 0x851
        protected UnityEngine.Matrix4x4 m_FXMatrix;        // 0x854
        protected System.Boolean m_isFXMatrixSet;        // 0x894
        protected TMPro.TMP_Text.UnicodeChar[] m_TextProcessingArray;        // 0x898
        private System.Int32 m_InternalTextProcessingArraySize;        // 0x8A0
        private TMPro.TMP_CharacterInfo[] m_internalCharacterInfo;        // 0x8A8
        protected System.Int32 m_totalCharacterCount;        // 0x8B0
        protected static TMPro.WordWrapState m_SavedWordWrapState;        // 0x98
        protected static TMPro.WordWrapState m_SavedLineState;        // 0x430
        protected static TMPro.WordWrapState m_SavedEllipsisState;        // 0x7C8
        protected static TMPro.WordWrapState m_SavedLastValidState;        // 0xB60
        protected static TMPro.WordWrapState m_SavedSoftLineBreakState;        // 0xEF8
        protected static TMPro.TMP_TextProcessingStack<TMPro.WordWrapState> m_EllipsisInsertionCandidateStack;        // 0x1290
        protected System.Int32 m_characterCount;        // 0x8B4
        protected System.Int32 m_firstCharacterOfLine;        // 0x8B8
        protected System.Int32 m_firstVisibleCharacterOfLine;        // 0x8BC
        protected System.Int32 m_lastCharacterOfLine;        // 0x8C0
        protected System.Int32 m_lastVisibleCharacterOfLine;        // 0x8C4
        protected System.Int32 m_lineNumber;        // 0x8C8
        protected System.Int32 m_lineVisibleCharacterCount;        // 0x8CC
        protected System.Int32 m_pageNumber;        // 0x8D0
        protected System.Single m_PageAscender;        // 0x8D4
        protected System.Single m_maxTextAscender;        // 0x8D8
        protected System.Single m_maxCapHeight;        // 0x8DC
        protected System.Single m_ElementAscender;        // 0x8E0
        protected System.Single m_ElementDescender;        // 0x8E4
        protected System.Single m_maxLineAscender;        // 0x8E8
        protected System.Single m_maxLineDescender;        // 0x8EC
        protected System.Single m_startOfLineAscender;        // 0x8F0
        protected System.Single m_startOfLineDescender;        // 0x8F4
        protected System.Single m_lineOffset;        // 0x8F8
        protected TMPro.Extents m_meshExtents;        // 0x8FC
        protected UnityEngine.Color32 m_htmlColor;        // 0x90C
        protected TMPro.TMP_TextProcessingStack<UnityEngine.Color32> m_colorStack;        // 0x910
        protected TMPro.TMP_TextProcessingStack<UnityEngine.Color32> m_underlineColorStack;        // 0x930
        protected TMPro.TMP_TextProcessingStack<UnityEngine.Color32> m_strikethroughColorStack;        // 0x950
        protected TMPro.TMP_TextProcessingStack<TMPro.HighlightState> m_HighlightStateStack;        // 0x970
        protected TMPro.TMP_TextProcessingStack<TMPro.TMP_ColorGradient> m_colorGradientStack;        // 0x9A0
        protected TMPro.TMP_ColorGradient m_colorGradientPreset;        // 0x9C8
        protected System.Boolean m_colorGradientPresetIsTinted;        // 0x9D0
        protected System.Single m_tabSpacing;        // 0x9D4
        protected System.Single m_spacing;        // 0x9D8
        protected TMPro.TMP_TextProcessingStack<System.Int32>[] m_TextStyleStacks;        // 0x9E0
        protected TMPro.TMP_TextProcessingStack<System.Int32> m_ItalicAngleStack;        // 0x9E8
        protected TMPro.TMP_TextProcessingStack<System.Int32> m_actionStack;        // 0xA08
        protected TMPro.TMP_TextProcessingStack<System.Single> m_baselineOffsetStack;        // 0xA28
        protected System.Int32 m_TextStyleStackDepth;        // 0xA48
        protected System.Int32 m_ItalicAngle;        // 0xA4C
        protected System.Single m_padding;        // 0xA50
        protected System.Single m_baselineOffset;        // 0xA54
        protected System.Single m_xAdvance;        // 0xA58
        protected System.Single m_lastCharAdvance;        // 0xA5C
        protected System.Boolean m_lastIsUpVowels;        // 0xA60
        protected System.Boolean m_lastIsAscender;        // 0xA61
        protected System.Boolean m_lastIsDescender;        // 0xA62
        protected System.Single m_lastHeight;        // 0xA64
        protected static System.Boolean s_forceLeftAlign;        // 0x1648
        protected TMPro.TMP_TextElementType m_textElementType;        // 0xA68
        protected TMPro.TMP_TextElement m_cached_TextElement;        // 0xA70
        protected TMPro.TMP_Text.SpecialCharacter m_Ellipsis;        // 0xA78
        protected TMPro.TMP_Text.SpecialCharacter m_Underline;        // 0xA98
        protected TMPro.TMP_SpriteAsset m_defaultSpriteAsset;        // 0xAB8
        protected TMPro.TMP_SpriteAsset m_currentSpriteAsset;        // 0xAC0
        protected System.Int32 m_spriteCount;        // 0xAC8
        protected System.Int32 m_spriteIndex;        // 0xACC
        protected System.Int32 m_spriteAnimationID;        // 0xAD0
        private static Unity.Profiling.ProfilerMarker k_ParseTextMarker;        // 0x1650
        private static Unity.Profiling.ProfilerMarker k_InsertNewLineMarker;        // 0x1658
        protected System.Boolean m_ignoreActiveState;        // 0xAD4
        private TMPro.TMP_Text.TextBackingContainer m_TextBackingArray;        // 0xAD8
        private readonly System.Decimal[] k_Power;        // 0xAE8
        protected static UnityEngine.Vector2 k_LargePositiveVector2;        // 0x1660
        protected static UnityEngine.Vector2 k_LargeNegativeVector2;        // 0x1668
        protected static System.Single k_LargePositiveFloat;        // 0x1670
        protected static System.Single k_LargeNegativeFloat;        // 0x1674
        protected static System.Int32 k_LargePositiveInt;        // 0x1678
        protected static System.Int32 k_LargeNegativeInt;        // 0x167C
        private System.Boolean m_dynamicFontAssetUsed;        // 0xAF0

        // Methods
        private System.String get_text() { }
        private System.Void set_text(System.String value) { }
        private System.String get_textForPopulate() { }
        private System.Void ResetTextForPopulate() { }
        private System.Void RefreshPopulateText() { }
        private TMPro.ITextPreprocessor get_textPreprocessor() { }
        private System.Void set_textPreprocessor(TMPro.ITextPreprocessor value) { }
        private System.Boolean get_isRightToLeftText() { }
        private System.Void set_isRightToLeftText(System.Boolean value) { }
        private TMPro.TMP_FontAsset get_font() { }
        private System.Void set_font(TMPro.TMP_FontAsset value) { }
        private UnityEngine.Material LoadMaterial(System.String path) { }
        private TMPro.TMP_FontAsset get_m_fontAsset() { }
        private System.Void set_m_fontAsset(TMPro.TMP_FontAsset value) { }
        private UnityEngine.Material get_fontSharedMaterial() { }
        private System.Void set_fontSharedMaterial(UnityEngine.Material value) { }
        private UnityEngine.Material[] get_fontSharedMaterials() { }
        private System.Void set_fontSharedMaterials(UnityEngine.Material[] value) { }
        private UnityEngine.Material get_fontMaterial() { }
        private System.Void set_fontMaterial(UnityEngine.Material value) { }
        private UnityEngine.Material[] get_fontMaterials() { }
        private System.Void set_fontMaterials(UnityEngine.Material[] value) { }
        private UnityEngine.Color get_color() { }
        private System.Void set_color(UnityEngine.Color value) { }
        private System.Single get_alpha() { }
        private System.Void set_alpha(System.Single value) { }
        private System.Boolean get_enableVertexGradient() { }
        private System.Void set_enableVertexGradient(System.Boolean value) { }
        private TMPro.VertexGradient get_colorGradient() { }
        private System.Void set_colorGradient(TMPro.VertexGradient value) { }
        private TMPro.TMP_ColorGradient get_colorGradientPreset() { }
        private System.Void set_colorGradientPreset(TMPro.TMP_ColorGradient value) { }
        private TMPro.TMP_SpriteAsset get_spriteAsset() { }
        private System.Void set_spriteAsset(TMPro.TMP_SpriteAsset value) { }
        private System.Boolean get_tintAllSprites() { }
        private System.Void set_tintAllSprites(System.Boolean value) { }
        private TMPro.TMP_StyleSheet get_styleSheet() { }
        private System.Void set_styleSheet(TMPro.TMP_StyleSheet value) { }
        private TMPro.TMP_Style get_textStyle() { }
        private System.Void set_textStyle(TMPro.TMP_Style value) { }
        private System.Boolean get_overrideColorTags() { }
        private System.Void set_overrideColorTags(System.Boolean value) { }
        private UnityEngine.Color32 get_faceColor() { }
        private System.Void set_faceColor(UnityEngine.Color32 value) { }
        private UnityEngine.Color32 get_outlineColor() { }
        private System.Void set_outlineColor(UnityEngine.Color32 value) { }
        private System.Single get_outlineWidth() { }
        private System.Void set_outlineWidth(System.Single value) { }
        private System.Single get_fontSize() { }
        private System.Void set_fontSize(System.Single value) { }
        private System.Single get_PhoneticElementScale() { }
        private System.String get_m_currentPhonetic() { }
        private System.Boolean get_m_currentEnablePhoneticAutoPadding() { }
        private System.Boolean get_m_currentEnablePhoneticAutoSize() { }
        private System.Boolean get_m_currentEnablePhoneticAutoJustify() { }
        private TMPro.FontWeight get_fontWeight() { }
        private System.Void set_fontWeight(TMPro.FontWeight value) { }
        private System.Single get_pixelsPerUnit() { }
        private System.Boolean get_enableAutoSizing() { }
        private System.Void set_enableAutoSizing(System.Boolean value) { }
        private System.Single get_fontSizeMin() { }
        private System.Void set_fontSizeMin(System.Single value) { }
        private System.Single get_fontSizeMax() { }
        private System.Void set_fontSizeMax(System.Single value) { }
        private TMPro.FontStyles get_fontStyle() { }
        private System.Void set_fontStyle(TMPro.FontStyles value) { }
        private System.Boolean get_isUsingBold() { }
        private TMPro.HorizontalAlignmentOptions get_horizontalAlignment() { }
        private System.Void set_horizontalAlignment(TMPro.HorizontalAlignmentOptions value) { }
        private TMPro.VerticalAlignmentOptions get_verticalAlignment() { }
        private System.Void set_verticalAlignment(TMPro.VerticalAlignmentOptions value) { }
        private TMPro.TextAlignmentOptions get_alignment() { }
        private System.Void set_alignment(TMPro.TextAlignmentOptions value) { }
        private System.Single get_characterSpacing() { }
        private System.Void set_characterSpacing(System.Single value) { }
        private System.Single get_wordSpacing() { }
        private System.Void set_wordSpacing(System.Single value) { }
        private System.Single get_lineSpacing() { }
        private System.Void set_lineSpacing(System.Single value) { }
        private System.Single get_lineSpacingAdjustment() { }
        private System.Void set_lineSpacingAdjustment(System.Single value) { }
        private System.Single get_paragraphSpacing() { }
        private System.Void set_paragraphSpacing(System.Single value) { }
        private System.Single get_characterWidthAdjustment() { }
        private System.Void set_characterWidthAdjustment(System.Single value) { }
        private System.Boolean get_enableWordWrapping() { }
        private System.Void set_enableWordWrapping(System.Boolean value) { }
        private System.Single get_wordWrappingRatios() { }
        private System.Void set_wordWrappingRatios(System.Single value) { }
        private TMPro.TextOverflowModes get_overflowMode() { }
        private System.Void set_overflowMode(TMPro.TextOverflowModes value) { }
        private System.Boolean get_isTextOverflowing() { }
        private System.Int32 get_firstOverflowCharacterIndex() { }
        private TMPro.TMP_Text get_linkedTextComponent() { }
        private System.Void set_linkedTextComponent(TMPro.TMP_Text value) { }
        private System.Boolean get_isTextTruncated() { }
        private System.Boolean get_enableKerning() { }
        private System.Void set_enableKerning(System.Boolean value) { }
        private System.Boolean get_extraPadding() { }
        private System.Void set_extraPadding(System.Boolean value) { }
        private System.Boolean get_richText() { }
        private System.Void set_richText(System.Boolean value) { }
        private System.Boolean get_enableHyperlink() { }
        private System.Void set_enableHyperlink(System.Boolean value) { }
        private System.Single get_richTextColorBlend() { }
        private System.Void set_richTextColorBlend(System.Single value) { }
        private System.Boolean get_parseCtrlCharacters() { }
        private System.Void set_parseCtrlCharacters(System.Boolean value) { }
        private System.Boolean get_isOverlay() { }
        private System.Void set_isOverlay(System.Boolean value) { }
        private System.Boolean get_isOrthographic() { }
        private System.Void set_isOrthographic(System.Boolean value) { }
        private System.Boolean get_enableCulling() { }
        private System.Void set_enableCulling(System.Boolean value) { }
        private System.Boolean get_ignoreVisibility() { }
        private System.Void set_ignoreVisibility(System.Boolean value) { }
        private TMPro.TextureMappingOptions get_horizontalMapping() { }
        private System.Void set_horizontalMapping(TMPro.TextureMappingOptions value) { }
        private TMPro.TextureMappingOptions get_verticalMapping() { }
        private System.Void set_verticalMapping(TMPro.TextureMappingOptions value) { }
        private System.Single get_mappingUvLineOffset() { }
        private System.Void set_mappingUvLineOffset(System.Single value) { }
        private TMPro.TextRenderFlags get_renderMode() { }
        private System.Void set_renderMode(TMPro.TextRenderFlags value) { }
        private TMPro.VertexSortingOrder get_geometrySortingOrder() { }
        private System.Void set_geometrySortingOrder(TMPro.VertexSortingOrder value) { }
        private System.Boolean get_isTextObjectScaleStatic() { }
        private System.Void set_isTextObjectScaleStatic(System.Boolean value) { }
        private System.Boolean get_vertexBufferAutoSizeReduction() { }
        private System.Void set_vertexBufferAutoSizeReduction(System.Boolean value) { }
        private System.Int32 get_firstVisibleCharacter() { }
        private System.Void set_firstVisibleCharacter(System.Int32 value) { }
        private System.Int32 get_maxVisibleCharacters() { }
        private System.Void set_maxVisibleCharacters(System.Int32 value) { }
        private System.Int32 get_maxVisibleWords() { }
        private System.Void set_maxVisibleWords(System.Int32 value) { }
        private System.Int32 get_maxVisibleLines() { }
        private System.Void set_maxVisibleLines(System.Int32 value) { }
        private System.Boolean get_useMaxVisibleDescender() { }
        private System.Void set_useMaxVisibleDescender(System.Boolean value) { }
        private System.Int32 get_pageToDisplay() { }
        private System.Void set_pageToDisplay(System.Int32 value) { }
        private UnityEngine.Vector4 get_margin() { }
        private System.Void set_margin(UnityEngine.Vector4 value) { }
        private TMPro.TMP_TextInfo get_textInfo() { }
        private System.Boolean get_havePropertiesChanged() { }
        private System.Void set_havePropertiesChanged(System.Boolean value) { }
        private System.Boolean get_isUsingLegacyAnimationComponent() { }
        private System.Void set_isUsingLegacyAnimationComponent(System.Boolean value) { }
        private UnityEngine.Transform get_transform() { }
        private UnityEngine.RectTransform get_rectTransform() { }
        private System.Boolean get_autoSizeTextContainer() { }
        private System.Void set_autoSizeTextContainer(System.Boolean value) { }
        private UnityEngine.Mesh get_mesh() { }
        private System.Boolean get_isVolumetricText() { }
        private System.Void set_isVolumetricText(System.Boolean value) { }
        private UnityEngine.Bounds get_bounds() { }
        private UnityEngine.Bounds get_textBounds() { }
        private System.Void add_OnFontAssetRequest(System.Func<System.Int32,System.String,TMPro.TMP_FontAsset> value) { }
        private System.Void remove_OnFontAssetRequest(System.Func<System.Int32,System.String,TMPro.TMP_FontAsset> value) { }
        private System.Void add_OnSpriteAssetRequest(System.Func<System.Int32,System.String,TMPro.TMP_SpriteAsset> value) { }
        private System.Void remove_OnSpriteAssetRequest(System.Func<System.Int32,System.String,TMPro.TMP_SpriteAsset> value) { }
        private System.Void add_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value) { }
        private System.Void remove_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value) { }
        private TMPro.TMP_SpriteAnimator get_spriteAnimator() { }
        private System.Single get_flexibleHeight() { }
        private System.Single get_flexibleWidth() { }
        private System.Single get_minWidth() { }
        private System.Single get_minHeight() { }
        private System.Single get_maxWidth() { }
        private System.Single get_maxHeight() { }
        private UnityEngine.UI.LayoutElement get_layoutElement() { }
        private System.Single get_preferredWidth() { }
        private System.Single get_preferredHeight() { }
        private System.Single get_renderedWidth() { }
        private System.Single get_renderedHeight() { }
        private System.Int32 get_layoutPriority() { }
        private System.Void Awake() { }
        private System.Void InitDataFromPool() { }
        private System.Void OnDestroy() { }
        private System.Void LoadFontAsset() { }
        private System.Void SetSharedMaterial(UnityEngine.Material mat) { }
        private UnityEngine.Material GetMaterial(UnityEngine.Material mat) { }
        private System.Void SetFontBaseMaterial(UnityEngine.Material mat) { }
        private UnityEngine.Material[] GetSharedMaterials() { }
        private System.Void SetSharedMaterials(UnityEngine.Material[] materials) { }
        private UnityEngine.Material[] GetMaterials(UnityEngine.Material[] mats) { }
        private UnityEngine.Material CreateMaterialInstance(UnityEngine.Material source) { }
        private System.Void SetVertexColorGradient(TMPro.TMP_ColorGradient gradient) { }
        private System.Void SetTextSortingOrder(TMPro.VertexSortingOrder order) { }
        private System.Void SetTextSortingOrder(System.Int32[] order) { }
        private System.Void SetFaceColor(UnityEngine.Color32 color) { }
        private System.Void SetOutlineColor(UnityEngine.Color32 color) { }
        private System.Void SetOutlineThickness(System.Single thickness) { }
        private System.Void SetShaderDepth() { }
        private System.Void SetCulling() { }
        private System.Void UpdateCulling() { }
        private System.Single GetPaddingForMaterial() { }
        private System.Single GetPaddingForMaterial(UnityEngine.Material mat) { }
        private UnityEngine.Vector3[] GetTextContainerLocalCorners() { }
        private System.Void ForceMeshUpdate(System.Boolean ignoreActiveState, System.Boolean forceTextReparsing) { }
        private System.Void UpdateGeometry(UnityEngine.Mesh mesh, System.Int32 index) { }
        private System.Void UpdateVertexData(TMPro.TMP_VertexDataUpdateFlags flags) { }
        private System.Void UpdateVertexData() { }
        private System.Void SetVertices(UnityEngine.Vector3[] vertices) { }
        private System.Void UpdateMeshPadding() { }
        private System.Void CrossFadeColor(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha) { }
        private System.Void CrossFadeAlpha(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale) { }
        private System.Void InternalCrossFadeColor(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha) { }
        private System.Void InternalCrossFadeAlpha(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale) { }
        private System.Void ParseInputText() { }
        private System.Void PopulateTextBackingArray(System.String sourceText) { }
        private System.Void PopulateTextBackingArray(System.String sourceText, System.Int32 start, System.Int32 length) { }
        private System.Void PopulateTextBackingArray(System.Text.StringBuilder sourceText, System.Int32 start, System.Int32 length) { }
        private System.Void PopulateTextBackingArray(System.Char[] sourceText, System.Int32 start, System.Int32 length) { }
        private System.Void PopulateTextProcessingArray() { }
        private System.Void SetTextInternal(System.String sourceText) { }
        private System.Void SetText(System.String sourceText, System.Boolean syncTextInputBox) { }
        private System.Void SetText(System.String sourceText, System.Single arg0) { }
        private System.Void SetText(System.String sourceText, System.Single arg0, System.Single arg1) { }
        private System.Void SetText(System.String sourceText, System.Single arg0, System.Single arg1, System.Single arg2) { }
        private System.Void SetText(System.String sourceText, System.Single arg0, System.Single arg1, System.Single arg2, System.Single arg3) { }
        private System.Void SetText(System.String sourceText, System.Single arg0, System.Single arg1, System.Single arg2, System.Single arg3, System.Single arg4) { }
        private System.Void SetText(System.String sourceText, System.Single arg0, System.Single arg1, System.Single arg2, System.Single arg3, System.Single arg4, System.Single arg5) { }
        private System.Void SetText(System.String sourceText, System.Single arg0, System.Single arg1, System.Single arg2, System.Single arg3, System.Single arg4, System.Single arg5, System.Single arg6) { }
        private System.Void SetText(System.String sourceText, System.Single arg0, System.Single arg1, System.Single arg2, System.Single arg3, System.Single arg4, System.Single arg5, System.Single arg6, System.Single arg7) { }
        private System.Void SetText(System.Text.StringBuilder sourceText) { }
        private System.Void SetText(System.Text.StringBuilder sourceText, System.Int32 start, System.Int32 length) { }
        private System.Void SetText(System.Char[] sourceText) { }
        private System.Void SetText(System.Char[] sourceText, System.Int32 start, System.Int32 length) { }
        private System.Void SetCharArray(System.Char[] sourceText) { }
        private System.Void SetCharArray(System.Char[] sourceText, System.Int32 start, System.Int32 length) { }
        private TMPro.TMP_Style GetStyle(System.Int32 hashCode) { }
        private System.Boolean ReplaceOpeningStyleTag(TMPro.TMP_Text.TextBackingContainer& sourceText, System.Int32 srcIndex, System.Int32& srcOffset, TMPro.TMP_Text.UnicodeChar[]& charBuffer, System.Int32& writeIndex) { }
        private System.Boolean ReplaceOpeningStyleTag(System.Int32[]& sourceText, System.Int32 srcIndex, System.Int32& srcOffset, TMPro.TMP_Text.UnicodeChar[]& charBuffer, System.Int32& writeIndex) { }
        private System.Void ReplaceClosingStyleTag(TMPro.TMP_Text.TextBackingContainer& sourceText, System.Int32 srcIndex, TMPro.TMP_Text.UnicodeChar[]& charBuffer, System.Int32& writeIndex) { }
        private System.Void ReplaceClosingStyleTag(System.Int32[]& sourceText, System.Int32 srcIndex, TMPro.TMP_Text.UnicodeChar[]& charBuffer, System.Int32& writeIndex) { }
        private System.Boolean InsertOpeningStyleTag(TMPro.TMP_Style style, System.Int32 srcIndex, TMPro.TMP_Text.UnicodeChar[]& charBuffer, System.Int32& writeIndex) { }
        private System.Void InsertClosingStyleTag(TMPro.TMP_Text.UnicodeChar[]& charBuffer, System.Int32& writeIndex) { }
        private System.Int32 GetMarkupTagHashCode(System.Int32[] tagDefinition, System.Int32 readIndex) { }
        private System.Int32 GetMarkupTagHashCode(TMPro.TMP_Text.TextBackingContainer tagDefinition, System.Int32 readIndex) { }
        private System.Int32 GetStyleHashCode(System.Int32[]& text, System.Int32 index, System.Int32& closeIndex) { }
        private System.Int32 GetStyleHashCode(TMPro.TMP_Text.TextBackingContainer& text, System.Int32 index, System.Int32& closeIndex) { }
        private System.Void ResizeInternalArray(T[]& array) { }
        private System.Void ResizeInternalArray(T[]& array, System.Int32 size) { }
        private System.Void AddFloatToInternalTextBackingArray(System.Single value, System.Int32 padding, System.Int32 precision, System.Int32& writeIndex) { }
        private System.Void AddIntegerToInternalTextBackingArray(System.Double number, System.Int32 padding, System.Int32& writeIndex) { }
        private System.String InternalTextBackingArrayToString() { }
        private System.Int32 SetArraySizes(TMPro.TMP_Text.UnicodeChar[] unicodeChars) { }
        private UnityEngine.Vector2 GetPreferredValues() { }
        private UnityEngine.Vector2 GetPreferredValues(System.Single width, System.Single height) { }
        private UnityEngine.Vector2 GetPreferredValues(System.String text) { }
        private UnityEngine.Vector2 GetPreferredValues(System.String text, System.Single width, System.Single height) { }
        private System.Single GetPreferredWidth() { }
        private System.Single GetPreferredWidth(UnityEngine.Vector2 margin) { }
        private System.Single GetPreferredHeight() { }
        private System.Single GetPreferredHeight(UnityEngine.Vector2 margin) { }
        private UnityEngine.Vector2 GetRenderedValues() { }
        private UnityEngine.Vector2 GetRenderedValues(System.Boolean onlyVisibleCharacters) { }
        private System.Single GetRenderedWidth() { }
        private System.Single GetRenderedWidth(System.Boolean onlyVisibleCharacters) { }
        private System.Single GetRenderedHeight() { }
        private System.Single GetRenderedHeight(System.Boolean onlyVisibleCharacters) { }
        private UnityEngine.Vector2 CalculatePreferredValues(System.Single& fontSize, UnityEngine.Vector2 marginSize, System.Boolean isTextAutoSizingEnabled, System.Boolean isWordWrappingEnabled) { }
        private UnityEngine.Bounds GetCompoundBounds() { }
        private UnityEngine.Rect GetCanvasSpaceClippingRect() { }
        private UnityEngine.Bounds GetTextBounds() { }
        private UnityEngine.Bounds GetTextBounds(System.Boolean onlyVisibleCharacters) { }
        private System.Void AdjustLineOffset(System.Int32 startIndex, System.Int32 endIndex, System.Single offset) { }
        private System.Void ResizeLineExtents(System.Int32 size) { }
        private TMPro.TMP_TextInfo GetTextInfo(System.String text) { }
        private System.Void ComputeMarginSize() { }
        private System.Void InsertNewLine(System.Int32 i, System.Single baseScale, System.Single currentElementScale, System.Single currentEmScale, System.Single glyphAdjustment, System.Single boldSpacingAdjustment, System.Single characterSpacingAdjustment, System.Single width, System.Single lineGap, System.Boolean& isMaxVisibleDescenderSet, System.Single& maxVisibleDescender) { }
        private System.Void SaveWordWrappingState(TMPro.WordWrapState& state, System.Int32 index, System.Int32 count) { }
        private System.Int32 RestoreWordWrappingState(TMPro.WordWrapState& state) { }
        private System.Void SaveGlyphVertexInfo(System.Single padding, System.Single style_padding, UnityEngine.Color32 vertexColor) { }
        private System.Void SaveSpriteVertexInfo(UnityEngine.Color32 vertexColor) { }
        private System.Void FillCharacterVertexBuffers(System.Int32 i, System.Int32 index_X4) { }
        private System.Void FillCharacterVertexBuffers(System.Int32 i, System.Int32 index_X4, System.Boolean isVolumetric) { }
        private System.Void FillSpriteVertexBuffers(System.Int32 i, System.Int32 index_X4) { }
        private System.Void DrawUnderlineMesh(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Int32& index, System.Single startScale, System.Single endScale, System.Single maxScale, System.Single sdfScale, UnityEngine.Color32 underlineColor) { }
        private System.Single PhoneticWidth(System.String str, System.Int32 materialIndex, System.Single padding, System.Single style_padding) { }
        private System.Boolean DrawPhoneticMesh(UnityEngine.Rect rect, System.String str, System.Int32 materialIndex, System.Single padding, System.Single style_padding, System.Boolean autoSize, System.Int32 phoneticIndex, System.Boolean justify, System.Single lossyScale) { }
        private System.Void DrawTextHighlight(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Int32& index, UnityEngine.Color32 highlightColor) { }
        private System.Void LoadDefaultSettings() { }
        private System.Void GetSpecialCharacters(TMPro.TMP_FontAsset fontAsset) { }
        private System.Void GetEllipsisSpecialCharacter(TMPro.TMP_FontAsset fontAsset) { }
        private System.Void GetUnderlineSpecialCharacter(TMPro.TMP_FontAsset fontAsset) { }
        private System.Void ReplaceTagWithCharacter(System.Int32[] chars, System.Int32 insertionIndex, System.Int32 tagLength, System.Char c) { }
        private TMPro.TMP_FontAsset GetFontAssetForWeight(System.Int32 fontWeight) { }
        private TMPro.TMP_TextElement GetTextElement(System.UInt32 unicode, TMPro.TMP_FontAsset fontAsset, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, System.Boolean& isUsingAlternativeTypeface) { }
        private System.Void TryRemoveDynamicFallbackFontAssetTextRef() { }
        private System.Void SetActiveSubMeshes(System.Boolean state) { }
        private System.Void DestroySubMeshObjects() { }
        private System.Void ClearMesh() { }
        private System.Void ClearMesh(System.Boolean uploadGeometry) { }
        private System.String GetParsedText() { }
        private System.Boolean IsSelfOrLinkedAncestor(TMPro.TMP_Text targetTextComponent) { }
        private System.Void ReleaseLinkedTextComponent(TMPro.TMP_Text targetTextComponent) { }
        private UnityEngine.Vector2 PackUV(System.Single x, System.Single y, System.Single scale) { }
        private System.Single PackUV(System.Single x, System.Single y) { }
        private System.Void InternalUpdate() { }
        private System.Int32 HexToInt(System.Char hex) { }
        private System.Int32 GetUTF16(System.String text, System.Int32 i) { }
        private System.Int32 GetUTF16(System.Int32[] text, System.Int32 i) { }
        private System.Int32 GetUTF16(System.UInt32[] text, System.Int32 i) { }
        private System.Int32 GetUTF16(System.Text.StringBuilder text, System.Int32 i) { }
        private System.Int32 GetUTF16(TMPro.TMP_Text.TextBackingContainer text, System.Int32 i) { }
        private System.Int32 GetUTF32(System.String text, System.Int32 i) { }
        private System.Int32 GetUTF32(System.Int32[] text, System.Int32 i) { }
        private System.Int32 GetUTF32(System.UInt32[] text, System.Int32 i) { }
        private System.Int32 GetUTF32(System.Text.StringBuilder text, System.Int32 i) { }
        private System.Int32 GetUTF32(TMPro.TMP_Text.TextBackingContainer text, System.Int32 i) { }
        private UnityEngine.Color32 HexCharsToColor(System.Char[] hexChars, System.Int32 tagCount) { }
        private UnityEngine.Color32 HexCharsToColor(System.Char[] hexChars, System.Int32 startIndex, System.Int32 length) { }
        private System.Int32 GetAttributeParameters(System.Char[] chars, System.Int32 startIndex, System.Int32 length, System.Single[]& parameters) { }
        private System.Single ConvertToFloat(System.Char[] chars, System.Int32 startIndex, System.Int32 length) { }
        private System.Single ConvertToFloat(System.Char[] chars, System.Int32 startIndex, System.Int32 length, System.Int32& lastIndex) { }
        private System.Boolean CheckIfEndPhonetic(TMPro.TMP_Text.UnicodeChar[] chars, System.Int32 startIndex) { }
        private System.Boolean ValidateHtmlTag(TMPro.TMP_Text.UnicodeChar[] chars, System.Int32 startIndex, System.Int32& endIndex) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200009E
    public struct TextElementType
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static TMPro.TextElementType Character;        // 0x0
        public static TMPro.TextElementType Sprite;        // 0x0

    }

    // TypeToken: 0x200009F
    public class TMP_TextElement
    {
        // Fields
        protected TMPro.TextElementType m_ElementType;        // 0x10
        private System.UInt32 m_Unicode;        // 0x14
        private TMPro.TMP_Asset m_TextAsset;        // 0x18
        private UnityEngine.TextCore.Glyph m_Glyph;        // 0x20
        private System.UInt32 m_GlyphIndex;        // 0x28
        private System.Single m_Scale;        // 0x2C

        // Methods
        private TMPro.TextElementType get_elementType() { }
        private System.UInt32 get_unicode() { }
        private System.Void set_unicode(System.UInt32 value) { }
        private TMPro.TMP_Asset get_textAsset() { }
        private System.Void set_textAsset(TMPro.TMP_Asset value) { }
        private UnityEngine.TextCore.Glyph get_glyph() { }
        private System.Void set_glyph(UnityEngine.TextCore.Glyph value) { }
        private System.UInt32 get_glyphIndex() { }
        private System.Void set_glyphIndex(System.UInt32 value) { }
        private System.Single get_scale() { }
        private System.Void set_scale(System.Single value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A0
    public class TMP_TextElement_Legacy
    {
        // Fields
        public System.Int32 id;        // 0x10
        public System.Single x;        // 0x14
        public System.Single y;        // 0x18
        public System.Single width;        // 0x1C
        public System.Single height;        // 0x20
        public System.Single xOffset;        // 0x24
        public System.Single yOffset;        // 0x28
        public System.Single xAdvance;        // 0x2C
        public System.Single scale;        // 0x30

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A1
    public class TMP_TextInfo, IDisposable
    {
        // Fields
        private static UnityEngine.Vector2 k_InfinityVectorPositive;        // 0x0
        private static UnityEngine.Vector2 k_InfinityVectorNegative;        // 0x8
        public TMPro.TMP_Text textComponent;        // 0x10
        public System.Int32 characterCount;        // 0x18
        public System.Int32 spriteCount;        // 0x1C
        public System.Int32 spaceCount;        // 0x20
        public System.Int32 wordCount;        // 0x24
        public System.Int32 linkCount;        // 0x28
        public System.Int32 lineCount;        // 0x2C
        public System.Int32 pageCount;        // 0x30
        public System.Int32 materialCount;        // 0x34
        public System.Int32 characterToSubstituteIndex;        // 0x38
        public TMPro.TMP_CharacterInfo[] characterInfo;        // 0x40
        public TMPro.TMP_WordInfo[] wordInfo;        // 0x48
        public TMPro.TMP_LinkInfo[] linkInfo;        // 0x50
        public TMPro.TMP_LineInfo[] lineInfo;        // 0x58
        public TMPro.TMP_PageInfo[] pageInfo;        // 0x60
        public TMPro.TMP_MeshInfo[] meshInfo;        // 0x68
        private TMPro.TMP_MeshInfo[] m_CachedMeshInfo;        // 0x70

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 characterCount) { }
        private System.Void .ctor(TMPro.TMP_Text textComponent) { }
        private System.Void Clear() { }
        private System.Void ClearAllData() { }
        private System.Void ClearMeshInfo(System.Boolean updateMesh) { }
        private System.Void ClearAllMeshInfo() { }
        private System.Void ResetVertexLayout(System.Boolean isVolumetric) { }
        private System.Void ClearUnusedVertices(TMPro.MaterialReference[] materials) { }
        private System.Void ClearLineInfo() { }
        private System.Void ClearPageInfo() { }
        private TMPro.TMP_MeshInfo[] CopyMeshInfoVertexData() { }
        private System.Void Resize(T[]& array, System.Int32 size) { }
        private System.Void Resize(T[]& array, System.Int32 size, System.Boolean isBlockAllocated) { }
        private System.Void Dispose() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000A2
    public class TMP_TextParsingUtilities
    {
        // Fields
        private static readonly TMPro.TMP_TextParsingUtilities s_Instance;        // 0x0
        private static System.String k_LookupStringL;        // 0x0
        private static System.String k_LookupStringU;        // 0x0

        // Methods
        private System.Void .cctor() { }
        private TMPro.TMP_TextParsingUtilities get_instance() { }
        private System.Int32 GetHashCode(System.String s) { }
        private System.Int32 GetHashCodeCaseSensitive(System.String s) { }
        private System.Char ToLowerASCIIFast(System.Char c) { }
        private System.Char ToUpperASCIIFast(System.Char c) { }
        private System.UInt32 ToUpperASCIIFast(System.UInt32 c) { }
        private System.UInt32 ToLowerASCIIFast(System.UInt32 c) { }
        private System.Boolean IsHighSurrogate(System.UInt32 c) { }
        private System.Boolean IsLowSurrogate(System.UInt32 c) { }
        private System.UInt32 ConvertToUTF32(System.UInt32 highSurrogate, System.UInt32 lowSurrogate) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A3
    public struct TMP_FontStyleStack
    {
        // Fields
        public System.Byte bold;        // 0x10
        public System.Byte italic;        // 0x11
        public System.Byte underline;        // 0x12
        public System.Byte strikethrough;        // 0x13
        public System.Byte highlight;        // 0x14
        public System.Byte superscript;        // 0x15
        public System.Byte subscript;        // 0x16
        public System.Byte uppercase;        // 0x17
        public System.Byte lowercase;        // 0x18
        public System.Byte smallcaps;        // 0x19

        // Methods
        private System.Void Clear() { }
        private System.Byte Add(TMPro.FontStyles style) { }
        private System.Byte Remove(TMPro.FontStyles style) { }

    }

    // TypeToken: 0x20000A4
    public struct TMP_TextProcessingStack`1, IDisposable
    {
        // Fields
        public T[] itemStack;        // 0x0
        public System.Int32 index;        // 0x0
        private T m_DefaultItem;        // 0x0
        private System.Int32 m_Capacity;        // 0x0
        private System.Int32 m_RolloverSize;        // 0x0
        private System.Int32 m_Count;        // 0x0
        private static System.Int32 k_DefaultCapacity;        // 0x0

        // Methods
        private System.Void .ctor(T[] stack) { }
        private System.Void .ctor(System.Int32 capacity) { }
        private System.Void .ctor(System.Int32 capacity, System.Int32 rolloverSize) { }
        private System.Int32 get_Count() { }
        private T get_current() { }
        private System.Int32 get_rolloverSize() { }
        private System.Void set_rolloverSize(System.Int32 value) { }
        private System.Void SetDefault(TMPro.TMP_TextProcessingStack<T>[] stack, T item) { }
        private System.Void Clear() { }
        private System.Void SetDefault(T item) { }
        private System.Void Add(T item) { }
        private T Remove() { }
        private System.Void Push(T item) { }
        private T Pop() { }
        private T Peek() { }
        private T CurrentItem() { }
        private T PreviousItem() { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x20000A5
    public struct TMP_TextProcessingQueue`1, IDisposable
    {
        // Fields
        public T[] itemQueue;        // 0x0
        private System.Int32 m_Head;        // 0x0
        private System.Int32 m_Tail;        // 0x0
        private System.Int32 m_Capacity;        // 0x0
        private System.Int32 m_Count;        // 0x0
        private T m_DefaultItem;        // 0x0
        private static System.Int32 k_DefaultCapacity;        // 0x0

        // Methods
        private System.Void .ctor(T[] queue) { }
        private System.Void .ctor(System.Int32 capacity) { }
        private System.Int32 get_Count() { }
        private System.Void Clear() { }
        private System.Void SetDefault(T item) { }
        private System.Void Enqueue(T item) { }
        private T Dequeue() { }
        private T Peek() { }
        private System.Void Resize(System.Int32 newCapacity) { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x20000A6
    public struct CaretPosition
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.CaretPosition None;        // 0x0
        public static TMPro.CaretPosition Left;        // 0x0
        public static TMPro.CaretPosition Right;        // 0x0

    }

    // TypeToken: 0x20000A7
    public struct CaretInfo
    {
        // Fields
        public System.Int32 index;        // 0x10
        public TMPro.CaretPosition position;        // 0x14

        // Methods
        private System.Void .ctor(System.Int32 index, TMPro.CaretPosition position) { }

    }

    // TypeToken: 0x20000A8
    public class TMP_TextUtilities
    {
        // Fields
        private static UnityEngine.Vector3[] m_rectWorldCorners;        // 0x0
        private static System.String k_lookupStringL;        // 0x0
        private static System.String k_lookupStringU;        // 0x0

        // Methods
        private System.Int32 GetCursorIndexFromPosition(TMPro.TMP_Text textComponent, UnityEngine.Vector3 position, UnityEngine.Camera camera) { }
        private System.Int32 GetCursorIndexFromPosition(TMPro.TMP_Text textComponent, UnityEngine.Vector3 position, UnityEngine.Camera camera, TMPro.CaretPosition& cursor) { }
        private System.Int32 FindNearestLine(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera) { }
        private System.Int32 FindNearestCharacterOnLine(TMPro.TMP_Text text, UnityEngine.Vector3 position, System.Int32 line, UnityEngine.Camera camera, System.Boolean visibleOnly) { }
        private System.Boolean IsIntersectingRectTransform(UnityEngine.RectTransform rectTransform, UnityEngine.Vector3 position, UnityEngine.Camera camera) { }
        private System.Int32 FindIntersectingCharacter(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera, System.Boolean visibleOnly) { }
        private System.Int32 FindNearestCharacter(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera, System.Boolean visibleOnly) { }
        private System.Int32 FindIntersectingWord(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera) { }
        private System.Int32 FindNearestWord(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera) { }
        private System.Int32 FindIntersectingLine(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera) { }
        private System.Int32 FindIntersectingLink(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera) { }
        private System.Int32 FindNearestLink(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera) { }
        private System.Boolean PointIntersectRectangle(UnityEngine.Vector3 m, UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c, UnityEngine.Vector3 d) { }
        private System.Boolean ScreenPointToWorldPointInRectangle(UnityEngine.Transform transform, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, UnityEngine.Vector3& worldPoint) { }
        private System.Boolean IntersectLinePlane(TMPro.TMP_TextUtilities.LineSegment line, UnityEngine.Vector3 point, UnityEngine.Vector3 normal, UnityEngine.Vector3& intersectingPoint) { }
        private System.Single DistanceToLine(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 point) { }
        private System.Char ToLowerFast(System.Char c) { }
        private System.Char ToUpperFast(System.Char c) { }
        private System.UInt32 ToUpperASCIIFast(System.UInt32 c) { }
        private System.Int32 GetHashCode(System.String s) { }
        private System.Int32 GetSimpleHashCode(System.String s) { }
        private System.UInt32 GetSimpleHashCodeLowercase(System.String s) { }
        private System.Int32 HexToInt(System.Char hex) { }
        private System.Int32 StringHexToInt(System.String s) { }
        private System.Boolean IsUpVowel(System.Char c) { }
        private System.Boolean IsLowVowel(System.Char c) { }
        private System.Boolean IsToneMark(System.Char c) { }
        private System.Boolean IsAscenderThai(System.Char c) { }
        private System.Boolean IsDescenderThai(System.Char c) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000AA
    public class TMP_UpdateManager
    {
        // Fields
        private static TMPro.TMP_UpdateManager s_Instance;        // 0x0
        private readonly System.Collections.Generic.HashSet<System.Int32> m_LayoutQueueLookup;        // 0x10
        private readonly System.Collections.Generic.List<TMPro.TMP_Text> m_LayoutRebuildQueue;        // 0x18
        private readonly System.Collections.Generic.HashSet<System.Int32> m_GraphicQueueLookup;        // 0x20
        private readonly System.Collections.Generic.List<TMPro.TMP_Text> m_GraphicRebuildQueue;        // 0x28
        private readonly System.Collections.Generic.HashSet<System.Int32> m_InternalUpdateLookup;        // 0x30
        private readonly System.Collections.Generic.List<TMPro.TMP_Text> m_InternalUpdateQueue;        // 0x38
        private readonly System.Collections.Generic.HashSet<System.Int32> m_CullingUpdateLookup;        // 0x40
        private readonly System.Collections.Generic.List<TMPro.TMP_Text> m_CullingUpdateQueue;        // 0x48
        private static Unity.Profiling.ProfilerMarker k_RegisterTextObjectForUpdateMarker;        // 0x8
        private static Unity.Profiling.ProfilerMarker k_RegisterTextElementForGraphicRebuildMarker;        // 0x10
        private static Unity.Profiling.ProfilerMarker k_RegisterTextElementForCullingUpdateMarker;        // 0x18
        private static Unity.Profiling.ProfilerMarker k_UnregisterTextObjectForUpdateMarker;        // 0x20
        private static Unity.Profiling.ProfilerMarker k_UnregisterTextElementForGraphicRebuildMarker;        // 0x28

        // Methods
        private TMPro.TMP_UpdateManager get_instance() { }
        private System.Void .ctor() { }
        private System.Void RegisterTextObjectForUpdate(TMPro.TMP_Text textObject) { }
        private System.Void InternalRegisterTextObjectForUpdate(TMPro.TMP_Text textObject) { }
        private System.Void RegisterTextElementForLayoutRebuild(TMPro.TMP_Text element) { }
        private System.Void InternalRegisterTextElementForLayoutRebuild(TMPro.TMP_Text element) { }
        private System.Void RegisterTextElementForGraphicRebuild(TMPro.TMP_Text element) { }
        private System.Void InternalRegisterTextElementForGraphicRebuild(TMPro.TMP_Text element) { }
        private System.Void RegisterTextElementForCullingUpdate(TMPro.TMP_Text element) { }
        private System.Void InternalRegisterTextElementForCullingUpdate(TMPro.TMP_Text element) { }
        private System.Void OnCameraPreCull() { }
        private System.Void DoRebuilds() { }
        private System.Void UnRegisterTextObjectForUpdate(TMPro.TMP_Text textObject) { }
        private System.Void UnRegisterTextElementForRebuild(TMPro.TMP_Text element) { }
        private System.Void InternalUnRegisterTextElementForGraphicRebuild(TMPro.TMP_Text element) { }
        private System.Void InternalUnRegisterTextElementForLayoutRebuild(TMPro.TMP_Text element) { }
        private System.Void InternalUnRegisterTextObjectForUpdate(TMPro.TMP_Text textObject) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000AB
    public class TMP_UpdateRegistry
    {
        // Fields
        private static TMPro.TMP_UpdateRegistry s_Instance;        // 0x0
        private readonly System.Collections.Generic.List<UnityEngine.UI.ICanvasElement> m_LayoutRebuildQueue;        // 0x10
        private System.Collections.Generic.HashSet<System.Int32> m_LayoutQueueLookup;        // 0x18
        private readonly System.Collections.Generic.List<UnityEngine.UI.ICanvasElement> m_GraphicRebuildQueue;        // 0x20
        private System.Collections.Generic.HashSet<System.Int32> m_GraphicQueueLookup;        // 0x28

        // Methods
        private TMPro.TMP_UpdateRegistry get_instance() { }
        private System.Void .ctor() { }
        private System.Void RegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element) { }
        private System.Boolean InternalRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element) { }
        private System.Void RegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element) { }
        private System.Boolean InternalRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element) { }
        private System.Void PerformUpdateForCanvasRendererObjects() { }
        private System.Void PerformUpdateForMeshRendererObjects() { }
        private System.Void UnRegisterCanvasElementForRebuild(UnityEngine.UI.ICanvasElement element) { }
        private System.Void InternalUnRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element) { }
        private System.Void InternalUnRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element) { }

    }

}

namespace TMPro.SpriteAssetUtilities
{

    // TypeToken: 0x20000AC
    public struct SpriteAssetImportFormats
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static TMPro.SpriteAssetUtilities.SpriteAssetImportFormats None;        // 0x0
        public static TMPro.SpriteAssetUtilities.SpriteAssetImportFormats TexturePackerJsonArray;        // 0x0

    }

    // TypeToken: 0x20000AD
    public class TexturePacker_JsonArray
    {
        // Methods
        private System.Void .ctor() { }

    }

}

