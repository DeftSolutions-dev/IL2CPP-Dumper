// ========================================================
// Dumped by @desirepro
// Assembly: USD.NET.Unity.dll
// Classes:  52
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000004
    public struct CurveType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static USD.NET.Unity.BasisCurvesSample.CurveType Linear;        // 0x0
        public static USD.NET.Unity.BasisCurvesSample.CurveType Cubic;        // 0x0

    }

    // TypeToken: 0x2000005
    public struct Basis
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static USD.NET.Unity.BasisCurvesSample.Basis Bezier;        // 0x0
        public static USD.NET.Unity.BasisCurvesSample.Basis Bspline;        // 0x0
        public static USD.NET.Unity.BasisCurvesSample.Basis CatmullRom;        // 0x0
        public static USD.NET.Unity.BasisCurvesSample.Basis Hermite;        // 0x0
        public static USD.NET.Unity.BasisCurvesSample.Basis Power;        // 0x0

    }

    // TypeToken: 0x2000006
    public struct WrapMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static USD.NET.Unity.BasisCurvesSample.WrapMode Nonperiodic;        // 0x0
        public static USD.NET.Unity.BasisCurvesSample.WrapMode Periodic;        // 0x0

    }

    // TypeToken: 0x2000009
    public struct ProjectionType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static USD.NET.Unity.CameraSample.ProjectionType Perspective;        // 0x0
        public static USD.NET.Unity.CameraSample.ProjectionType Orthographic;        // 0x0

    }

    // TypeToken: 0x200000A
    public struct StereoRole
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static USD.NET.Unity.CameraSample.StereoRole Mono;        // 0x0
        public static USD.NET.Unity.CameraSample.StereoRole Left;        // 0x0
        public static USD.NET.Unity.CameraSample.StereoRole Right;        // 0x0

    }

    // TypeToken: 0x200000B
    public class Shutter : SampleBase
    {
        // Fields
        public System.Double open;        // 0x10
        public System.Double close;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000027
    public class Outputs : SampleBase
    {
        // Fields
        public pxr.TfToken displacement;        // 0x10
        public pxr.TfToken surface;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000029
    public class Outputs : SampleBase
    {
        // Fields
        public System.Nullable<T> result;        // 0x0

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002D
    public struct WrapMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static USD.NET.Unity.TextureReaderSample.WrapMode Black;        // 0x0
        public static USD.NET.Unity.TextureReaderSample.WrapMode Clamp;        // 0x0
        public static USD.NET.Unity.TextureReaderSample.WrapMode Repeat;        // 0x0
        public static USD.NET.Unity.TextureReaderSample.WrapMode Mirror;        // 0x0

    }

    // TypeToken: 0x200002E
    public struct SRGBMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static USD.NET.Unity.TextureReaderSample.SRGBMode Yes;        // 0x0
        public static USD.NET.Unity.TextureReaderSample.SRGBMode No;        // 0x0
        public static USD.NET.Unity.TextureReaderSample.SRGBMode Auto;        // 0x0

    }

    // TypeToken: 0x200002F
    public class Outputs : SampleBase
    {
        // Fields
        public System.Nullable<System.Single> r;        // 0x10
        public System.Nullable<System.Single> g;        // 0x18
        public System.Nullable<System.Single> b;        // 0x20
        public System.Nullable<System.Single> a;        // 0x28
        public System.Nullable<UnityEngine.Vector3> rgb;        // 0x30
        public System.Nullable<UnityEngine.Vector4> rgba;        // 0x40

        // Methods
        private System.Void .ctor() { }

    }

namespace USD.NET.Unity
{

    // TypeToken: 0x2000002
    public class DiagnosticHandler : DiagnosticHandler
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void OnFatalError(System.String msg) { }
        private System.Void OnError(System.String msg) { }
        private System.Void OnWarning(System.String msg) { }
        private System.Void OnInfo(System.String msg) { }

    }

    // TypeToken: 0x2000003
    public class BasisCurvesSample : CurvesSample
    {
        // Fields
        public USD.NET.Unity.BasisCurvesSample.CurveType type;        // 0xB0
        public USD.NET.Unity.BasisCurvesSample.Basis basis;        // 0xB4
        public USD.NET.Unity.BasisCurvesSample.WrapMode wrap;        // 0xB8

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000007
    public class BoundableSample : XformableSample
    {
        // Fields
        public UnityEngine.Bounds extent;        // 0x60

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000008
    public class CameraSample : XformSample
    {
        // Fields
        public USD.NET.Unity.CameraSample.ProjectionType projection;        // 0x60
        public System.Single horizontalAperture;        // 0x64
        public System.Single horizontalApertureOffset;        // 0x68
        public System.Single verticalAperture;        // 0x6C
        public System.Single verticalApertureOffset;        // 0x70
        public System.Single focalLength;        // 0x74
        public UnityEngine.Vector2 clippingRange;        // 0x78
        public UnityEngine.Vector4[] clippingPlanes;        // 0x80
        public System.Single fStop;        // 0x88
        public System.Single focusDistance;        // 0x8C
        public USD.NET.Unity.CameraSample.StereoRole stereoRole;        // 0x90
        public USD.NET.Unity.CameraSample.Shutter shutter;        // 0x98

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.Camera fromCamera) { }
        private System.Void CopyFromCamera(UnityEngine.Camera camera, System.Boolean convertTransformToUsd) { }
        private System.Void CopyToCamera(UnityEngine.Camera camera, System.Boolean setTransform) { }

    }

    // TypeToken: 0x200000C
    public class CubeSample : GprimSample
    {
        // Fields
        private System.Double m_size;        // 0x80

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Double size) { }
        private System.Double get_size() { }
        private System.Void set_size(System.Double value) { }

    }

    // TypeToken: 0x200000D
    public class CurvesSample : PointBasedSample
    {
        // Fields
        public System.Boolean doubleSided;        // 0x80
        public USD.NET.Orientation orientation;        // 0x84
        public UnityEngine.Vector3[] points;        // 0x88
        public UnityEngine.Vector3[] normals;        // 0x90
        public UnityEngine.Vector3[] velocities;        // 0x98
        public System.Int32[] curveVertexCounts;        // 0xA0
        public System.Single[] widths;        // 0xA8

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000E
    public class GprimSample : BoundableSample
    {
        // Fields
        public USD.NET.Primvar<UnityEngine.Color[]> colors;        // 0x78

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000F
    public class ImageableSample : SampleBase
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000010
    public class MeshSample : MeshSampleBase
    {
        // Fields
        public USD.NET.Visibility visibility;        // 0xA8
        public USD.NET.Purpose purpose;        // 0xAC
        public System.Boolean doubleSided;        // 0xB0
        public USD.NET.Orientation orientation;        // 0xB4
        public System.Int32[] faceVertexCounts;        // 0xB8

        // Methods
        private System.Void SetTriangles(System.Int32[] triangleIndices) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000011
    public class MeshSampleBase : PointBasedSample, IArbitraryPrimvars
    {
        // Fields
        public System.Int32[] faceVertexIndices;        // 0x80
        public UnityEngine.Vector3[] points;        // 0x88
        public UnityEngine.Vector3[] normals;        // 0x90
        public USD.NET.Primvar<UnityEngine.Vector4[]> tangents;        // 0x98
        public System.Collections.Generic.Dictionary<System.String,USD.NET.Primvar<System.Object>> ArbitraryPrimvars;        // 0xA0

        // Methods
        private System.Collections.Generic.Dictionary<System.String,USD.NET.Primvar<System.Object>> GetArbitraryPrimvars() { }
        private System.Void .ctor() { }
        private System.Void AddPrimvars(System.Collections.Generic.List<System.String> primvars) { }

    }

    // TypeToken: 0x2000012
    public class PointBasedSample : GprimSample
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000013
    public class PointInstancerPrototypesSample : BoundableSample
    {
        // Fields
        public USD.NET.Relationship prototypes;        // 0x78

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000014
    public class PointInstancerSample : PointInstancerPrototypesSample
    {
        // Fields
        public System.Int32[] protoIndices;        // 0x80
        public System.Int64[] ids;        // 0x88
        public System.Int64[] invisibleIds;        // 0x90
        public UnityEngine.Vector3[] positions;        // 0x98
        public UnityEngine.Quaternion[] rotations;        // 0xA0
        public UnityEngine.Vector3[] scales;        // 0xA8
        public UnityEngine.Vector3[] velocities;        // 0xB0
        public UnityEngine.Vector3[] angularVelocities;        // 0xB8

        // Methods
        private UnityEngine.Matrix4x4[] ComputeInstanceMatrices(USD.NET.Scene scene, System.String primPath) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000015
    public class ScopeSample : ImageableSample
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000016
    public class SphereSample : GprimSample
    {
        // Fields
        private System.Double m_radius;        // 0x80

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Double radius) { }
        private System.Double get_radius() { }
        private System.Void set_radius(System.Double value) { }

    }

    // TypeToken: 0x2000017
    public class XformableSample : ImageableSample
    {
        // Fields
        private readonly System.String[] kXformOpTransform;        // 0x10
        private UnityEngine.Matrix4x4 m_xf;        // 0x18
        public System.String[] xformOpOrder;        // 0x58

        // Methods
        private USD.NET.Unity.XformableSample FromTransform(UnityEngine.Transform transform) { }
        private System.Void .ctor() { }
        private UnityEngine.Matrix4x4 get_transform() { }
        private System.Void set_transform(UnityEngine.Matrix4x4 value) { }
        private System.Void ConvertTransform() { }

    }

    // TypeToken: 0x2000018
    public class XformSample : XformableSample
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000019
    public class MaterialBindingSample : SampleBase
    {
        // Fields
        public USD.NET.Relationship binding;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String materialPath) { }

    }

    // TypeToken: 0x200001A
    public class MaterialSample : SampleBase
    {
        // Fields
        public USD.NET.Connectable<pxr.TfToken> surface;        // 0x10
        public USD.NET.Connectable<pxr.TfToken> displacement;        // 0x18
        public System.String[] requiredKeywords;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String surfacePath) { }
        private System.Void .ctor(System.String surfacePath, System.String displacementPath) { }
        private System.Boolean ReadMaterial(USD.NET.Scene scene, System.String geometryPath, USD.NET.Unity.MaterialSample materialSample, System.String& shaderId) { }
        private System.Void Bind(USD.NET.Scene scene, System.String primPath, System.String materialPath) { }
        private System.Void Unbind(USD.NET.Scene scene, System.String primPath) { }

    }

    // TypeToken: 0x200001B
    public struct ParameterInfo
    {
        // Fields
        public System.Object value;        // 0x10
        public System.String connectedPath;        // 0x18
        public System.String usdName;        // 0x20
        public System.String unityName;        // 0x28
        public System.String[] requiredShaderKeywords;        // 0x30

        // Methods
        private System.String ToString() { }

    }

    // TypeToken: 0x200001C
    public class InputParameterAttribute : UsdNamespaceAttribute
    {
        // Fields
        private System.String <UnityName>k__BackingField;        // 0x18

        // Methods
        private System.String get_UnityName() { }
        private System.Void set_UnityName(System.String value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String unityName) { }

    }

    // TypeToken: 0x200001D
    public class InputTextureAttribute : UsdNamespaceAttribute
    {
        // Fields
        private System.String <UnityName>k__BackingField;        // 0x18

        // Methods
        private System.String get_UnityName() { }
        private System.Void set_UnityName(System.String value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String unityName) { }

    }

    // TypeToken: 0x200001E
    public class RequireShaderKeywordsAttribute : Attribute
    {
        // Fields
        private System.String[] <Keywords>k__BackingField;        // 0x10

        // Methods
        private System.String[] get_Keywords() { }
        private System.Void set_Keywords(System.String[] value) { }
        private System.Void .ctor(System.String keyword) { }
        private System.Void .ctor(System.String[] keywords) { }

    }

    // TypeToken: 0x200001F
    public class ShaderSample : SampleBase
    {
        // Fields
        public pxr.TfToken id;        // 0x10

        // Methods
        private System.Type GetClassType() { }
        private System.Object GetValue(System.Reflection.FieldInfo info) { }
        private System.Collections.Generic.IEnumerable<USD.NET.Unity.ParameterInfo> GetInputParameters() { }
        private System.Collections.Generic.IEnumerable<USD.NET.Unity.ParameterInfo> GetInputTextures() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000024
    public class StandardShaderSample : ShaderSample
    {
        // Fields
        public System.Boolean enableGpuInstancing;        // 0x18
        public USD.NET.Connectable<UnityEngine.Color> albedo;        // 0x20
        public USD.NET.Connectable<UnityEngine.Color> albedoMap;        // 0x28
        public USD.NET.Connectable<System.Single> cutoff;        // 0x30
        public USD.NET.Connectable<System.Single> smoothness;        // 0x38
        public USD.NET.Connectable<System.Single> smoothnessScale;        // 0x40
        public USD.NET.Connectable<System.Single> smoothnessTextureChannel;        // 0x48
        public USD.NET.Connectable<System.Single> metallicMap;        // 0x50
        public USD.NET.Connectable<System.Single> metallicScale;        // 0x58
        public USD.NET.Connectable<System.Boolean> enableSpecularHighlights;        // 0x60
        public USD.NET.Connectable<System.Boolean> enableGlossyReflections;        // 0x68
        public USD.NET.Connectable<UnityEngine.Color> normalMap;        // 0x70
        public USD.NET.Connectable<System.Single> normalMapScale;        // 0x78
        public USD.NET.Connectable<UnityEngine.Color> parallaxMap;        // 0x80
        public USD.NET.Connectable<System.Single> parallaxMapScale;        // 0x88
        public USD.NET.Connectable<System.Single> occlusionMap;        // 0x90
        public USD.NET.Connectable<System.Single> occlusionMapScale;        // 0x98
        public USD.NET.Connectable<UnityEngine.Color> emission;        // 0xA0
        public USD.NET.Connectable<UnityEngine.Color> emissionMap;        // 0xA8
        public USD.NET.Connectable<UnityEngine.Color> detailMask;        // 0xB0
        public USD.NET.Connectable<UnityEngine.Color> detailAlbedoMap;        // 0xB8
        public USD.NET.Connectable<UnityEngine.Color> detailNormalMap;        // 0xC0
        public USD.NET.Connectable<System.Single> detailNormalMapScale;        // 0xC8
        public USD.NET.Connectable<System.Single> uvSetForSecondaryTextures;        // 0xD0
        public USD.NET.Connectable<System.Single> renderingMode;        // 0xD8
        public USD.NET.Connectable<System.Single> srcBlend;        // 0xE0
        public USD.NET.Connectable<System.Single> dstBlend;        // 0xE8
        public USD.NET.Connectable<System.Single> zwrite;        // 0xF0

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000025
    public class Texture2DSample : SampleBase
    {
        // Fields
        public USD.NET.Connectable<System.String> sourceFile;        // 0x10
        public System.Boolean sRgb;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000026
    public class PreviewSurfaceSample : ShaderSample
    {
        // Fields
        public USD.NET.Connectable<UnityEngine.Vector3> diffuseColor;        // 0x18
        public USD.NET.Connectable<UnityEngine.Vector3> emissiveColor;        // 0x20
        public USD.NET.Connectable<System.Int32> useSpecularWorkflow;        // 0x28
        public USD.NET.Connectable<UnityEngine.Vector3> specularColor;        // 0x30
        public USD.NET.Connectable<System.Single> metallic;        // 0x38
        public USD.NET.Connectable<System.Single> roughness;        // 0x40
        public USD.NET.Connectable<System.Single> clearcoat;        // 0x48
        public USD.NET.Connectable<System.Single> clearcoatRoughness;        // 0x50
        public USD.NET.Connectable<System.Single> opacity;        // 0x58
        public USD.NET.Connectable<System.Single> opacityThreshold;        // 0x60
        public USD.NET.Connectable<System.Single> ior;        // 0x68
        public USD.NET.Connectable<UnityEngine.Vector3> normal;        // 0x70
        public USD.NET.Connectable<System.Single> displacement;        // 0x78
        public USD.NET.Connectable<System.Single> occlusion;        // 0x80
        public USD.NET.Unity.PreviewSurfaceSample.Outputs outputs;        // 0x88

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000028
    public class PrimvarReaderSample`1 : ShaderSample
    {
        // Fields
        public USD.NET.Connectable<T> fallback;        // 0x0
        public USD.NET.Unity.PrimvarReaderSample.Outputs<T> outputs;        // 0x0

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002A
    public class PrimvarReaderImportSample`1 : PrimvarReaderSample`1
    {
        // Fields
        public USD.NET.Connectable<System.String> varname;        // 0x0

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002B
    public class PrimvarReaderExportSample`1 : PrimvarReaderSample`1
    {
        // Fields
        public USD.NET.Connectable<pxr.TfToken> varname;        // 0x0

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002C
    public class TextureReaderSample : ShaderSample
    {
        // Fields
        public USD.NET.Connectable<pxr.SdfAssetPath> file;        // 0x18
        public USD.NET.Connectable<UnityEngine.Vector2> st;        // 0x20
        public USD.NET.Connectable<USD.NET.Unity.TextureReaderSample.WrapMode> wrapS;        // 0x28
        public USD.NET.Connectable<USD.NET.Unity.TextureReaderSample.WrapMode> wrapT;        // 0x30
        public USD.NET.Connectable<UnityEngine.Vector4> fallback;        // 0x38
        public USD.NET.Connectable<UnityEngine.Vector4> scale;        // 0x40
        public USD.NET.Connectable<UnityEngine.Vector4> bias;        // 0x48
        public USD.NET.Connectable<USD.NET.Unity.TextureReaderSample.SRGBMode> isSRGB;        // 0x50
        public USD.NET.Unity.TextureReaderSample.Outputs outputs;        // 0x58

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String filePath) { }
        private System.Void .ctor(System.String filePath, System.String stConnectionPath) { }
        private USD.NET.Unity.TextureReaderSample.WrapMode GetWrapMode(UnityEngine.TextureWrapMode wrap) { }

    }

    // TypeToken: 0x2000030
    public class UnityTypeBindings
    {
        // Fields
        private static System.Boolean isInitialized;        // 0x0

        // Methods
        private System.Void .cctor() { }
        private System.Void RegisterTypes() { }

    }

    // TypeToken: 0x2000032
    public class PreserveAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000033
    public class UnityTypeConverter : IntrinsicTypeConverter
    {
        // Fields
        public static UnityEngine.Matrix4x4 basisChange;        // 0x0
        public static UnityEngine.Matrix4x4 inverseBasisChange;        // 0x40

        // Methods
        private UnityEngine.Matrix4x4 ChangeBasis(UnityEngine.Matrix4x4 input) { }
        private UnityEngine.Vector3 ChangeBasis(UnityEngine.Vector3 point) { }
        private System.Void SetTransform(UnityEngine.Matrix4x4 localXf, UnityEngine.Transform transform) { }
        private System.Boolean Decompose(UnityEngine.Matrix4x4 matrix, UnityEngine.Vector3& translation, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale) { }
        private UnityEngine.Vector3 WeightedAvg(UnityEngine.Vector3 a, UnityEngine.Vector3 b, System.Single aWeight, System.Single bWeight) { }
        private System.Void ExtractTrs(UnityEngine.Matrix4x4 transform, UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation, UnityEngine.Vector3& localScale) { }
        private UnityEngine.Quaternion ExtractRotation(UnityEngine.Matrix4x4 mat4) { }
        private UnityEngine.Vector3 ExtractPosition(UnityEngine.Matrix4x4 mat4) { }
        private UnityEngine.Vector3 ExtractScale(UnityEngine.Matrix4x4 mat4) { }
        private System.Boolean HasAnySiblingsWithName(UnityEngine.Transform transform, System.String name) { }
        private System.String GetUniqueName(UnityEngine.Transform transform) { }
        private System.String GetPath(UnityEngine.Transform unityObj) { }
        private System.String GetPath(UnityEngine.Transform unityObj, UnityEngine.Transform unityObjRoot) { }
        private UnityEngine.Matrix4x4 GetLocalToParentXf(UnityEngine.Transform unityXf) { }
        private pxr.GfMatrix4d ToGfMatrix(UnityEngine.Transform unityXf) { }
        private pxr.GfMatrix4d ToGfMatrix(UnityEngine.Matrix4x4 unityMat4) { }
        private UnityEngine.Matrix4x4 FromMatrix(pxr.GfMatrix4d gfMat) { }
        private pxr.VtMatrix4dArray ToVtArray(UnityEngine.Matrix4x4[] input) { }
        private UnityEngine.Matrix4x4[] FromVtArray(pxr.VtMatrix4dArray input) { }
        private pxr.VtMatrix4dArray ListToVtArray(System.Collections.Generic.List<UnityEngine.Matrix4x4> input) { }
        private System.Collections.Generic.List<UnityEngine.Matrix4x4> ListFromVtArray(pxr.VtMatrix4dArray input) { }
        private pxr.GfVec4f Color32ToVec4f(UnityEngine.Color32 c) { }
        private UnityEngine.Color32 Vec4fToColor32(pxr.GfVec4f v) { }
        private pxr.VtVec4fArray ToVtArray(System.Collections.Generic.List<UnityEngine.Color32> input) { }
        private System.Void ToVtArray(System.Collections.Generic.List<UnityEngine.Color32> input, pxr.VtVec3fArray& rgb, pxr.VtFloatArray& alpha) { }
        private pxr.VtVec4fArray ToVtArray(UnityEngine.Color32[] input) { }
        private UnityEngine.Color32[] Color32FromVtArray(pxr.VtVec4fArray input) { }
        private pxr.GfVec4f ColorToVec4f(UnityEngine.Color c) { }
        private UnityEngine.Color Vec4fToColor(pxr.GfVec4f v) { }
        private pxr.VtVec4fArray ToVtArray(System.Collections.Generic.List<UnityEngine.Color> input) { }
        private System.Void ToVtArray(System.Collections.Generic.List<UnityEngine.Color> input, pxr.VtVec3fArray& rgb, pxr.VtFloatArray& alpha) { }
        private pxr.VtVec4fArray ToVtArray(UnityEngine.Color[] input) { }
        private UnityEngine.Color[] ColorFromVtArray(pxr.VtVec4fArray input) { }
        private UnityEngine.Color[] ColorFromVtArray(pxr.VtVec4fArray input, UnityEngine.Color[]& output) { }
        private System.Void ToVtArray(UnityEngine.Color32[] input, pxr.VtVec3fArray& rgb, pxr.VtFloatArray& alpha) { }
        private UnityEngine.Vector3[] ExtractRgb(UnityEngine.Color32[] colors) { }
        private System.Single[] ExtractAlpha(UnityEngine.Color32[] colors) { }
        private System.Void ToVtArray(UnityEngine.Color[] input, pxr.VtVec3fArray& rgb, pxr.VtFloatArray& alpha) { }
        private UnityEngine.Color[] FromVtArray(pxr.VtVec3fArray rgbIn, pxr.VtFloatArray alphaIn) { }
        private UnityEngine.Vector3[] ExtractRgb(UnityEngine.Color[] colors) { }
        private System.Single[] ExtractAlpha(UnityEngine.Color[] colors) { }
        private System.Void SwapQuaternionReal(UnityEngine.Quaternion[]& input) { }
        private pxr.GfQuatf QuaternionToQuatf(UnityEngine.Quaternion quaternion) { }
        private UnityEngine.Quaternion QuatfToQuaternion(pxr.GfQuatf quat) { }
        private pxr.VtQuatfArray ToVtArray(UnityEngine.Quaternion[] input) { }
        private UnityEngine.Quaternion[] FromVtArray(pxr.VtQuatfArray input) { }
        private pxr.VtQuatfArray ListToVtArray(System.Collections.Generic.List<UnityEngine.Quaternion> input) { }
        private System.Collections.Generic.List<UnityEngine.Quaternion> ListFromVtArray(pxr.VtQuatfArray input) { }
        private pxr.VtVec4fArray ToVtArray(UnityEngine.Vector4[] input) { }
        private UnityEngine.Vector4[] FromVtArray(pxr.VtVec4fArray input) { }
        private pxr.VtVec4fArray ListToVtArray(System.Collections.Generic.List<UnityEngine.Vector4> input) { }
        private System.Collections.Generic.List<UnityEngine.Vector4> ListFromVtArray(pxr.VtVec4fArray input) { }
        private pxr.VtVec3fArray BoundsToVtArray(UnityEngine.Bounds input) { }
        private UnityEngine.Bounds BoundsFromVtArray(pxr.VtValue vtBounds) { }
        private UnityEngine.Bounds BoundsFromVtArray(pxr.VtValue vtBounds, UnityEngine.Vector3[] bbox) { }
        private pxr.VtVec3fArray ToVtArray(UnityEngine.Vector3[] input) { }
        private UnityEngine.Vector3[] FromVtArray(pxr.VtVec3fArray input) { }
        private System.Void FromVtArray(pxr.VtVec3fArray input, UnityEngine.Vector3[]& output) { }
        private pxr.VtVec3fArray ListToVtArray(System.Collections.Generic.List<UnityEngine.Vector3> input) { }
        private System.Collections.Generic.List<UnityEngine.Vector3> ListFromVtArray(pxr.VtVec3fArray input) { }
        private pxr.VtVec2fArray ToVtArray(UnityEngine.Vector2[] input) { }
        private UnityEngine.Vector2[] FromVtArray(pxr.VtVec2fArray input) { }
        private pxr.VtVec2fArray ListToVtArray(System.Collections.Generic.List<UnityEngine.Vector2> input) { }
        private System.Collections.Generic.List<UnityEngine.Vector2> ListFromVtArray(pxr.VtVec2fArray input) { }
        private pxr.GfVec2f Vector2ToVec2f(UnityEngine.Vector2 vec2) { }
        private UnityEngine.Vector2 Vec2fToVector2(pxr.GfVec2f value) { }
        private pxr.GfVec3f Vector3ToVec3f(UnityEngine.Vector3 vec3) { }
        private UnityEngine.Vector3 Vec3fToVector3(pxr.GfVec3f v3) { }
        private pxr.GfVec4f Vector4ToVec4f(UnityEngine.Vector4 vector4) { }
        private UnityEngine.Vector4 Vec4fToVector4(pxr.GfVec4f v4) { }
        private pxr.GfVec4f RectToVtVec4(UnityEngine.Rect rect) { }
        private UnityEngine.Rect Vec4fToRect(pxr.GfVec4f v4) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

}

