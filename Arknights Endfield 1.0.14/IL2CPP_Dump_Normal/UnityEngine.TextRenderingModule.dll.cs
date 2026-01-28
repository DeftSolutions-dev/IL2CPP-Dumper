// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.TextRenderingModule.dll
// Classes:  14
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x200000E
    public class FontTextureRebuildCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }

    }

namespace UnityEngine
{

    // TypeToken: 0x2000002
    public struct FontStyle
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.FontStyle Normal;        // 0x0
        public static UnityEngine.FontStyle Bold;        // 0x0
        public static UnityEngine.FontStyle Italic;        // 0x0
        public static UnityEngine.FontStyle BoldAndItalic;        // 0x0

    }

    // TypeToken: 0x2000003
    public struct TextGenerationError
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TextGenerationError None;        // 0x0
        public static UnityEngine.TextGenerationError CustomSizeOnNonDynamicFont;        // 0x0
        public static UnityEngine.TextGenerationError CustomStyleOnNonDynamicFont;        // 0x0
        public static UnityEngine.TextGenerationError NoFont;        // 0x0

    }

    // TypeToken: 0x2000004
    public struct TextGenerationSettings
    {
        // Fields
        public UnityEngine.Font font;        // 0x10
        public UnityEngine.Color color;        // 0x18
        public System.Int32 fontSize;        // 0x28
        public System.Single lineSpacing;        // 0x2C
        public System.Boolean richText;        // 0x30
        public System.Single scaleFactor;        // 0x34
        public UnityEngine.FontStyle fontStyle;        // 0x38
        public UnityEngine.TextAnchor textAnchor;        // 0x3C
        public System.Boolean alignByGeometry;        // 0x40
        public System.Boolean resizeTextForBestFit;        // 0x41
        public System.Int32 resizeTextMinSize;        // 0x44
        public System.Int32 resizeTextMaxSize;        // 0x48
        public System.Boolean updateBounds;        // 0x4C
        public UnityEngine.VerticalWrapMode verticalOverflow;        // 0x50
        public UnityEngine.HorizontalWrapMode horizontalOverflow;        // 0x54
        public UnityEngine.Vector2 generationExtents;        // 0x58
        public UnityEngine.Vector2 pivot;        // 0x60
        public System.Boolean generateOutOfBounds;        // 0x68

        // Methods
        private System.Boolean CompareColors(UnityEngine.Color left, UnityEngine.Color right) { }
        private System.Boolean CompareVector2(UnityEngine.Vector2 left, UnityEngine.Vector2 right) { }
        private System.Boolean Equals(UnityEngine.TextGenerationSettings other) { }

    }

    // TypeToken: 0x2000005
    public class TextGenerator, IDisposable
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10
        private System.String m_LastString;        // 0x18
        private UnityEngine.TextGenerationSettings m_LastSettings;        // 0x20
        private System.Boolean m_HasGenerated;        // 0x80
        private UnityEngine.TextGenerationError m_LastValid;        // 0x84
        private readonly System.Collections.Generic.List<UnityEngine.UIVertex> m_Verts;        // 0x88
        private readonly System.Collections.Generic.List<UnityEngine.UICharInfo> m_Characters;        // 0x90
        private readonly System.Collections.Generic.List<UnityEngine.UILineInfo> m_Lines;        // 0x98
        private System.Boolean m_CachedVerts;        // 0xA0
        private System.Boolean m_CachedCharacters;        // 0xA1
        private System.Boolean m_CachedLines;        // 0xA2

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 initialCapacity) { }
        private System.Void Finalize() { }
        private System.Void System.IDisposable.Dispose() { }
        private System.Int32 get_characterCountVisible() { }
        private UnityEngine.TextGenerationSettings ValidatedSettings(UnityEngine.TextGenerationSettings settings) { }
        private System.Void Invalidate() { }
        private System.Void GetCharacters(System.Collections.Generic.List<UnityEngine.UICharInfo> characters) { }
        private System.Void GetLines(System.Collections.Generic.List<UnityEngine.UILineInfo> lines) { }
        private System.Void GetVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices) { }
        private System.Single GetPreferredWidth(System.String str, UnityEngine.TextGenerationSettings settings) { }
        private System.Single GetPreferredHeight(System.String str, UnityEngine.TextGenerationSettings settings) { }
        private System.Boolean PopulateWithErrors(System.String str, UnityEngine.TextGenerationSettings settings, UnityEngine.GameObject context) { }
        private System.Boolean Populate(System.String str, UnityEngine.TextGenerationSettings settings) { }
        private UnityEngine.TextGenerationError PopulateWithError(System.String str, UnityEngine.TextGenerationSettings settings) { }
        private UnityEngine.TextGenerationError PopulateAlways(System.String str, UnityEngine.TextGenerationSettings settings) { }
        private System.Collections.Generic.IList<UnityEngine.UIVertex> get_verts() { }
        private System.Collections.Generic.IList<UnityEngine.UICharInfo> get_characters() { }
        private System.Collections.Generic.IList<UnityEngine.UILineInfo> get_lines() { }
        private UnityEngine.Rect get_rectExtents() { }
        private System.Int32 get_characterCount() { }
        private System.Int32 get_lineCount() { }
        private System.IntPtr Internal_Create() { }
        private System.Void Internal_Destroy(System.IntPtr ptr) { }
        private System.Boolean Populate_Internal(System.String str, UnityEngine.Font font, UnityEngine.Color color, System.Int32 fontSize, System.Single scaleFactor, System.Single lineSpacing, UnityEngine.FontStyle style, System.Boolean richText, System.Boolean resizeTextForBestFit, System.Int32 resizeTextMinSize, System.Int32 resizeTextMaxSize, System.Int32 verticalOverFlow, System.Int32 horizontalOverflow, System.Boolean updateBounds, UnityEngine.TextAnchor anchor, System.Single extentsX, System.Single extentsY, System.Single pivotX, System.Single pivotY, System.Boolean generateOutOfBounds, System.Boolean alignByGeometry, System.UInt32& error) { }
        private System.Boolean Populate_Internal(System.String str, UnityEngine.Font font, UnityEngine.Color color, System.Int32 fontSize, System.Single scaleFactor, System.Single lineSpacing, UnityEngine.FontStyle style, System.Boolean richText, System.Boolean resizeTextForBestFit, System.Int32 resizeTextMinSize, System.Int32 resizeTextMaxSize, UnityEngine.VerticalWrapMode verticalOverFlow, UnityEngine.HorizontalWrapMode horizontalOverflow, System.Boolean updateBounds, UnityEngine.TextAnchor anchor, UnityEngine.Vector2 extents, UnityEngine.Vector2 pivot, System.Boolean generateOutOfBounds, System.Boolean alignByGeometry, UnityEngine.TextGenerationError& error) { }
        private System.Void GetVerticesInternal(System.Object vertices) { }
        private System.Void GetCharactersInternal(System.Object characters) { }
        private System.Void GetLinesInternal(System.Object lines) { }
        private System.Void get_rectExtents_Injected(UnityEngine.Rect& ret) { }
        private System.Boolean Populate_Internal_Injected(System.String str, UnityEngine.Font font, UnityEngine.Color& color, System.Int32 fontSize, System.Single scaleFactor, System.Single lineSpacing, UnityEngine.FontStyle style, System.Boolean richText, System.Boolean resizeTextForBestFit, System.Int32 resizeTextMinSize, System.Int32 resizeTextMaxSize, System.Int32 verticalOverFlow, System.Int32 horizontalOverflow, System.Boolean updateBounds, UnityEngine.TextAnchor anchor, System.Single extentsX, System.Single extentsY, System.Single pivotX, System.Single pivotY, System.Boolean generateOutOfBounds, System.Boolean alignByGeometry, System.UInt32& error) { }

    }

    // TypeToken: 0x2000006
    public struct TextAlignment
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TextAlignment Left;        // 0x0
        public static UnityEngine.TextAlignment Center;        // 0x0
        public static UnityEngine.TextAlignment Right;        // 0x0

    }

    // TypeToken: 0x2000007
    public struct TextAnchor
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TextAnchor UpperLeft;        // 0x0
        public static UnityEngine.TextAnchor UpperCenter;        // 0x0
        public static UnityEngine.TextAnchor UpperRight;        // 0x0
        public static UnityEngine.TextAnchor MiddleLeft;        // 0x0
        public static UnityEngine.TextAnchor MiddleCenter;        // 0x0
        public static UnityEngine.TextAnchor MiddleRight;        // 0x0
        public static UnityEngine.TextAnchor LowerLeft;        // 0x0
        public static UnityEngine.TextAnchor LowerCenter;        // 0x0
        public static UnityEngine.TextAnchor LowerRight;        // 0x0

    }

    // TypeToken: 0x2000008
    public struct HorizontalWrapMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.HorizontalWrapMode Wrap;        // 0x0
        public static UnityEngine.HorizontalWrapMode Overflow;        // 0x0

    }

    // TypeToken: 0x2000009
    public struct VerticalWrapMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.VerticalWrapMode Truncate;        // 0x0
        public static UnityEngine.VerticalWrapMode Overflow;        // 0x0

    }

    // TypeToken: 0x200000A
    public struct UICharInfo
    {
        // Fields
        public UnityEngine.Vector2 cursorPos;        // 0x10
        public System.Single charWidth;        // 0x18

    }

    // TypeToken: 0x200000B
    public struct UILineInfo
    {
        // Fields
        public System.Int32 startCharIdx;        // 0x10
        public System.Int32 height;        // 0x14
        public System.Single topY;        // 0x18
        public System.Single leading;        // 0x1C

    }

    // TypeToken: 0x200000C
    public struct UIVertex
    {
        // Fields
        public UnityEngine.Vector3 position;        // 0x10
        public UnityEngine.Vector3 normal;        // 0x1C
        public UnityEngine.Vector4 tangent;        // 0x28
        public UnityEngine.Color32 color;        // 0x38
        public UnityEngine.Vector4 uv0;        // 0x3C
        public UnityEngine.Vector4 uv1;        // 0x4C
        public UnityEngine.Vector4 uv2;        // 0x5C
        public UnityEngine.Vector4 uv3;        // 0x6C
        private static readonly UnityEngine.Color32 s_DefaultColor;        // 0x0
        private static readonly UnityEngine.Vector4 s_DefaultTangent;        // 0x4
        public static UnityEngine.UIVertex simpleVert;        // 0x14

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000D
    public class Font
    {
        // Fields
        private static System.Action<UnityEngine.Font> textureRebuilt;        // 0x0
        private UnityEngine.Font.FontTextureRebuildCallback m_FontTextureRebuildCallback;        // 0x18

        // Methods
        private System.Void add_textureRebuilt(System.Action<UnityEngine.Font> value) { }
        private System.Void remove_textureRebuilt(System.Action<UnityEngine.Font> value) { }
        private UnityEngine.Material get_material() { }
        private System.Boolean get_dynamic() { }
        private System.Int32 get_fontSize() { }
        private System.Void .ctor() { }
        private System.Void InvokeTextureRebuilt_Internal(UnityEngine.Font font) { }
        private System.Boolean HasCharacter(System.Char c) { }
        private System.Boolean HasCharacter(System.Int32 c) { }
        private System.Void Internal_CreateFont(UnityEngine.Font self, System.String name) { }

    }

}

