// ========================================================
// Dumped by @desirepro
// Assembly: USD.NET.Unity.dll
// Classes:  52
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: CurveType
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  USD.NET.Unity.BasisCurvesSample.CurveTypeLinear  // 0x0
  public    static  USD.NET.Unity.BasisCurvesSample.CurveTypeCubic  // 0x0
METHODS:
END_CLASS

CLASS: Basis
TYPE:  struct
TOKEN: 0x2000005
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  USD.NET.Unity.BasisCurvesSample.BasisBezier  // 0x0
  public    static  USD.NET.Unity.BasisCurvesSample.BasisBspline  // 0x0
  public    static  USD.NET.Unity.BasisCurvesSample.BasisCatmullRom  // 0x0
  public    static  USD.NET.Unity.BasisCurvesSample.BasisHermite  // 0x0
  public    static  USD.NET.Unity.BasisCurvesSample.BasisPower  // 0x0
METHODS:
END_CLASS

CLASS: WrapMode
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  USD.NET.Unity.BasisCurvesSample.WrapModeNonperiodic  // 0x0
  public    static  USD.NET.Unity.BasisCurvesSample.WrapModePeriodic  // 0x0
METHODS:
END_CLASS

CLASS: ProjectionType
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  USD.NET.Unity.CameraSample.ProjectionTypePerspective  // 0x0
  public    static  USD.NET.Unity.CameraSample.ProjectionTypeOrthographic  // 0x0
METHODS:
END_CLASS

CLASS: StereoRole
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  USD.NET.Unity.CameraSample.StereoRoleMono  // 0x0
  public    static  USD.NET.Unity.CameraSample.StereoRoleLeft  // 0x0
  public    static  USD.NET.Unity.CameraSample.StereoRoleRight  // 0x0
METHODS:
END_CLASS

CLASS: Shutter
TYPE:  class
TOKEN: 0x200000B
EXTENDS: SampleBase
FIELDS:
  public            System.Double                   open  // 0x10
  public            System.Double                   close  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Outputs
TYPE:  class
TOKEN: 0x2000027
EXTENDS: SampleBase
FIELDS:
  public            pxr.TfToken                     displacement  // 0x10
  public            pxr.TfToken                     surface  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Outputs
TYPE:  class
TOKEN: 0x2000029
EXTENDS: SampleBase
FIELDS:
  public            System.Nullable<T>              result  // 0x0
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: WrapMode
TYPE:  struct
TOKEN: 0x200002D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  USD.NET.Unity.TextureReaderSample.WrapModeBlack  // 0x0
  public    static  USD.NET.Unity.TextureReaderSample.WrapModeClamp  // 0x0
  public    static  USD.NET.Unity.TextureReaderSample.WrapModeRepeat  // 0x0
  public    static  USD.NET.Unity.TextureReaderSample.WrapModeMirror  // 0x0
METHODS:
END_CLASS

CLASS: SRGBMode
TYPE:  struct
TOKEN: 0x200002E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  USD.NET.Unity.TextureReaderSample.SRGBModeYes  // 0x0
  public    static  USD.NET.Unity.TextureReaderSample.SRGBModeNo  // 0x0
  public    static  USD.NET.Unity.TextureReaderSample.SRGBModeAuto  // 0x0
METHODS:
END_CLASS

CLASS: Outputs
TYPE:  class
TOKEN: 0x200002F
EXTENDS: SampleBase
FIELDS:
  public            System.Nullable<System.Single>  r  // 0x10
  public            System.Nullable<System.Single>  g  // 0x18
  public            System.Nullable<System.Single>  b  // 0x20
  public            System.Nullable<System.Single>  a  // 0x28
  public            System.Nullable<UnityEngine.Vector3>rgb  // 0x30
  public            System.Nullable<UnityEngine.Vector4>rgba  // 0x40
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: USD.NET.Unity.DiagnosticHandler
TYPE:  class
TOKEN: 0x2000002
EXTENDS: DiagnosticHandler
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void OnFatalError(System.String msg)
  System.Void OnError(System.String msg)
  System.Void OnWarning(System.String msg)
  System.Void OnInfo(System.String msg)
END_CLASS

CLASS: USD.NET.Unity.BasisCurvesSample
TYPE:  class
TOKEN: 0x2000003
EXTENDS: CurvesSample
FIELDS:
  public            USD.NET.Unity.BasisCurvesSample.CurveTypetype  // 0xB0
  public            USD.NET.Unity.BasisCurvesSample.Basisbasis  // 0xB4
  public            USD.NET.Unity.BasisCurvesSample.WrapModewrap  // 0xB8
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: USD.NET.Unity.BoundableSample
TYPE:  class
TOKEN: 0x2000007
EXTENDS: XformableSample
FIELDS:
  public            UnityEngine.Bounds              extent  // 0x60
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: USD.NET.Unity.CameraSample
TYPE:  class
TOKEN: 0x2000008
EXTENDS: XformSample
FIELDS:
  public            USD.NET.Unity.CameraSample.ProjectionTypeprojection  // 0x60
  public            System.Single                   horizontalAperture  // 0x64
  public            System.Single                   horizontalApertureOffset  // 0x68
  public            System.Single                   verticalAperture  // 0x6C
  public            System.Single                   verticalApertureOffset  // 0x70
  public            System.Single                   focalLength  // 0x74
  public            UnityEngine.Vector2             clippingRange  // 0x78
  public            UnityEngine.Vector4[]           clippingPlanes  // 0x80
  public            System.Single                   fStop  // 0x88
  public            System.Single                   focusDistance  // 0x8C
  public            USD.NET.Unity.CameraSample.StereoRolestereoRole  // 0x90
  public            USD.NET.Unity.CameraSample.Shuttershutter  // 0x98
METHODS:
  System.Void .ctor()
  System.Void .ctor(UnityEngine.Camera fromCamera)
  System.Void CopyFromCamera(UnityEngine.Camera camera, System.Boolean convertTransformToUsd)
  System.Void CopyToCamera(UnityEngine.Camera camera, System.Boolean setTransform)
END_CLASS

CLASS: USD.NET.Unity.CubeSample
TYPE:  class
TOKEN: 0x200000C
EXTENDS: GprimSample
FIELDS:
  private           System.Double                   m_size  // 0x80
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Double size)
  System.Double get_size()
  System.Void set_size(System.Double value)
END_CLASS

CLASS: USD.NET.Unity.CurvesSample
TYPE:  class
TOKEN: 0x200000D
EXTENDS: PointBasedSample
FIELDS:
  public            System.Boolean                  doubleSided  // 0x80
  public            USD.NET.Orientation             orientation  // 0x84
  public            UnityEngine.Vector3[]           points  // 0x88
  public            UnityEngine.Vector3[]           normals  // 0x90
  public            UnityEngine.Vector3[]           velocities  // 0x98
  public            System.Int32[]                  curveVertexCounts  // 0xA0
  public            System.Single[]                 widths  // 0xA8
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: USD.NET.Unity.GprimSample
TYPE:  class
TOKEN: 0x200000E
EXTENDS: BoundableSample
FIELDS:
  public            USD.NET.Primvar<UnityEngine.Color[]>colors  // 0x78
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: USD.NET.Unity.ImageableSample
TYPE:  class
TOKEN: 0x200000F
EXTENDS: SampleBase
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: USD.NET.Unity.MeshSample
TYPE:  class
TOKEN: 0x2000010
EXTENDS: MeshSampleBase
FIELDS:
  public            USD.NET.Visibility              visibility  // 0xA8
  public            USD.NET.Purpose                 purpose  // 0xAC
  public            System.Boolean                  doubleSided  // 0xB0
  public            USD.NET.Orientation             orientation  // 0xB4
  public            System.Int32[]                  faceVertexCounts  // 0xB8
METHODS:
  System.Void SetTriangles(System.Int32[] triangleIndices)
  System.Void .ctor()
END_CLASS

CLASS: USD.NET.Unity.MeshSampleBase
TYPE:  class
TOKEN: 0x2000011
EXTENDS: PointBasedSample
FIELDS:
  public            System.Int32[]                  faceVertexIndices  // 0x80
  public            UnityEngine.Vector3[]           points  // 0x88
  public            UnityEngine.Vector3[]           normals  // 0x90
  public            USD.NET.Primvar<UnityEngine.Vector4[]>tangents  // 0x98
  public            System.Collections.Generic.Dictionary<System.String,USD.NET.Primvar<System.Object>>ArbitraryPrimvars  // 0xA0
METHODS:
  System.Collections.Generic.Dictionary<System.String,USD.NET.Primvar<System.Object>> GetArbitraryPrimvars()
  System.Void .ctor()
  System.Void AddPrimvars(System.Collections.Generic.List<System.String> primvars)
END_CLASS

CLASS: USD.NET.Unity.PointBasedSample
TYPE:  class
TOKEN: 0x2000012
EXTENDS: GprimSample
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: USD.NET.Unity.PointInstancerPrototypesSample
TYPE:  class
TOKEN: 0x2000013
EXTENDS: BoundableSample
FIELDS:
  public            USD.NET.Relationship            prototypes  // 0x78
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: USD.NET.Unity.PointInstancerSample
TYPE:  class
TOKEN: 0x2000014
EXTENDS: PointInstancerPrototypesSample
FIELDS:
  public            System.Int32[]                  protoIndices  // 0x80
  public            System.Int64[]                  ids  // 0x88
  public            System.Int64[]                  invisibleIds  // 0x90
  public            UnityEngine.Vector3[]           positions  // 0x98
  public            UnityEngine.Quaternion[]        rotations  // 0xA0
  public            UnityEngine.Vector3[]           scales  // 0xA8
  public            UnityEngine.Vector3[]           velocities  // 0xB0
  public            UnityEngine.Vector3[]           angularVelocities  // 0xB8
METHODS:
  UnityEngine.Matrix4x4[] ComputeInstanceMatrices(USD.NET.Scene scene, System.String primPath)
  System.Void .ctor()
END_CLASS

CLASS: USD.NET.Unity.ScopeSample
TYPE:  class
TOKEN: 0x2000015
EXTENDS: ImageableSample
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: USD.NET.Unity.SphereSample
TYPE:  class
TOKEN: 0x2000016
EXTENDS: GprimSample
FIELDS:
  private           System.Double                   m_radius  // 0x80
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Double radius)
  System.Double get_radius()
  System.Void set_radius(System.Double value)
END_CLASS

CLASS: USD.NET.Unity.XformableSample
TYPE:  class
TOKEN: 0x2000017
EXTENDS: ImageableSample
FIELDS:
  private   readonly System.String[]                 kXformOpTransform  // 0x10
  private           UnityEngine.Matrix4x4           m_xf  // 0x18
  public            System.String[]                 xformOpOrder  // 0x58
METHODS:
  USD.NET.Unity.XformableSample FromTransform(UnityEngine.Transform transform)
  System.Void .ctor()
  UnityEngine.Matrix4x4 get_transform()
  System.Void set_transform(UnityEngine.Matrix4x4 value)
  System.Void ConvertTransform()
END_CLASS

CLASS: USD.NET.Unity.XformSample
TYPE:  class
TOKEN: 0x2000018
EXTENDS: XformableSample
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: USD.NET.Unity.MaterialBindingSample
TYPE:  class
TOKEN: 0x2000019
EXTENDS: SampleBase
FIELDS:
  public            USD.NET.Relationship            binding  // 0x10
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String materialPath)
END_CLASS

CLASS: USD.NET.Unity.MaterialSample
TYPE:  class
TOKEN: 0x200001A
EXTENDS: SampleBase
FIELDS:
  public            USD.NET.Connectable<pxr.TfToken>surface  // 0x10
  public            USD.NET.Connectable<pxr.TfToken>displacement  // 0x18
  public            System.String[]                 requiredKeywords  // 0x20
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String surfacePath)
  System.Void .ctor(System.String surfacePath, System.String displacementPath)
  System.Boolean ReadMaterial(USD.NET.Scene scene, System.String geometryPath, USD.NET.Unity.MaterialSample materialSample, System.String& shaderId)
  System.Void Bind(USD.NET.Scene scene, System.String primPath, System.String materialPath)
  System.Void Unbind(USD.NET.Scene scene, System.String primPath)
END_CLASS

CLASS: USD.NET.Unity.ParameterInfo
TYPE:  struct
TOKEN: 0x200001B
FIELDS:
  public            System.Object                   value  // 0x10
  public            System.String                   connectedPath  // 0x18
  public            System.String                   usdName  // 0x20
  public            System.String                   unityName  // 0x28
  public            System.String[]                 requiredShaderKeywords  // 0x30
METHODS:
  System.String ToString()
END_CLASS

CLASS: USD.NET.Unity.InputParameterAttribute
TYPE:  class
TOKEN: 0x200001C
EXTENDS: UsdNamespaceAttribute
FIELDS:
  private           System.String                   <UnityName>k__BackingField  // 0x18
METHODS:
  System.String get_UnityName()
  System.Void set_UnityName(System.String value)
  System.Void .ctor()
  System.Void .ctor(System.String unityName)
END_CLASS

CLASS: USD.NET.Unity.InputTextureAttribute
TYPE:  class
TOKEN: 0x200001D
EXTENDS: UsdNamespaceAttribute
FIELDS:
  private           System.String                   <UnityName>k__BackingField  // 0x18
METHODS:
  System.String get_UnityName()
  System.Void set_UnityName(System.String value)
  System.Void .ctor()
  System.Void .ctor(System.String unityName)
END_CLASS

CLASS: USD.NET.Unity.RequireShaderKeywordsAttribute
TYPE:  class
TOKEN: 0x200001E
EXTENDS: Attribute
FIELDS:
  private           System.String[]                 <Keywords>k__BackingField  // 0x10
METHODS:
  System.String[] get_Keywords()
  System.Void set_Keywords(System.String[] value)
  System.Void .ctor(System.String keyword)
  System.Void .ctor(System.String[] keywords)
END_CLASS

CLASS: USD.NET.Unity.ShaderSample
TYPE:  class
TOKEN: 0x200001F
EXTENDS: SampleBase
FIELDS:
  public            pxr.TfToken                     id  // 0x10
METHODS:
  System.Type GetClassType()
  System.Object GetValue(System.Reflection.FieldInfo info)
  System.Collections.Generic.IEnumerable<USD.NET.Unity.ParameterInfo> GetInputParameters()
  System.Collections.Generic.IEnumerable<USD.NET.Unity.ParameterInfo> GetInputTextures()
  System.Void .ctor()
END_CLASS

CLASS: USD.NET.Unity.StandardShaderSample
TYPE:  class
TOKEN: 0x2000024
EXTENDS: ShaderSample
FIELDS:
  public            System.Boolean                  enableGpuInstancing  // 0x18
  public            USD.NET.Connectable<UnityEngine.Color>albedo  // 0x20
  public            USD.NET.Connectable<UnityEngine.Color>albedoMap  // 0x28
  public            USD.NET.Connectable<System.Single>cutoff  // 0x30
  public            USD.NET.Connectable<System.Single>smoothness  // 0x38
  public            USD.NET.Connectable<System.Single>smoothnessScale  // 0x40
  public            USD.NET.Connectable<System.Single>smoothnessTextureChannel  // 0x48
  public            USD.NET.Connectable<System.Single>metallicMap  // 0x50
  public            USD.NET.Connectable<System.Single>metallicScale  // 0x58
  public            USD.NET.Connectable<System.Boolean>enableSpecularHighlights  // 0x60
  public            USD.NET.Connectable<System.Boolean>enableGlossyReflections  // 0x68
  public            USD.NET.Connectable<UnityEngine.Color>normalMap  // 0x70
  public            USD.NET.Connectable<System.Single>normalMapScale  // 0x78
  public            USD.NET.Connectable<UnityEngine.Color>parallaxMap  // 0x80
  public            USD.NET.Connectable<System.Single>parallaxMapScale  // 0x88
  public            USD.NET.Connectable<System.Single>occlusionMap  // 0x90
  public            USD.NET.Connectable<System.Single>occlusionMapScale  // 0x98
  public            USD.NET.Connectable<UnityEngine.Color>emission  // 0xA0
  public            USD.NET.Connectable<UnityEngine.Color>emissionMap  // 0xA8
  public            USD.NET.Connectable<UnityEngine.Color>detailMask  // 0xB0
  public            USD.NET.Connectable<UnityEngine.Color>detailAlbedoMap  // 0xB8
  public            USD.NET.Connectable<UnityEngine.Color>detailNormalMap  // 0xC0
  public            USD.NET.Connectable<System.Single>detailNormalMapScale  // 0xC8
  public            USD.NET.Connectable<System.Single>uvSetForSecondaryTextures  // 0xD0
  public            USD.NET.Connectable<System.Single>renderingMode  // 0xD8
  public            USD.NET.Connectable<System.Single>srcBlend  // 0xE0
  public            USD.NET.Connectable<System.Single>dstBlend  // 0xE8
  public            USD.NET.Connectable<System.Single>zwrite  // 0xF0
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: USD.NET.Unity.Texture2DSample
TYPE:  class
TOKEN: 0x2000025
EXTENDS: SampleBase
FIELDS:
  public            USD.NET.Connectable<System.String>sourceFile  // 0x10
  public            System.Boolean                  sRgb  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: USD.NET.Unity.PreviewSurfaceSample
TYPE:  class
TOKEN: 0x2000026
EXTENDS: ShaderSample
FIELDS:
  public            USD.NET.Connectable<UnityEngine.Vector3>diffuseColor  // 0x18
  public            USD.NET.Connectable<UnityEngine.Vector3>emissiveColor  // 0x20
  public            USD.NET.Connectable<System.Int32>useSpecularWorkflow  // 0x28
  public            USD.NET.Connectable<UnityEngine.Vector3>specularColor  // 0x30
  public            USD.NET.Connectable<System.Single>metallic  // 0x38
  public            USD.NET.Connectable<System.Single>roughness  // 0x40
  public            USD.NET.Connectable<System.Single>clearcoat  // 0x48
  public            USD.NET.Connectable<System.Single>clearcoatRoughness  // 0x50
  public            USD.NET.Connectable<System.Single>opacity  // 0x58
  public            USD.NET.Connectable<System.Single>opacityThreshold  // 0x60
  public            USD.NET.Connectable<System.Single>ior  // 0x68
  public            USD.NET.Connectable<UnityEngine.Vector3>normal  // 0x70
  public            USD.NET.Connectable<System.Single>displacement  // 0x78
  public            USD.NET.Connectable<System.Single>occlusion  // 0x80
  public            USD.NET.Unity.PreviewSurfaceSample.Outputsoutputs  // 0x88
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: USD.NET.Unity.PrimvarReaderSample`1
TYPE:  class
TOKEN: 0x2000028
EXTENDS: ShaderSample
FIELDS:
  public            USD.NET.Connectable<T>          fallback  // 0x0
  public            USD.NET.Unity.PrimvarReaderSample.Outputs<T>outputs  // 0x0
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: USD.NET.Unity.PrimvarReaderImportSample`1
TYPE:  class
TOKEN: 0x200002A
EXTENDS: PrimvarReaderSample`1
FIELDS:
  public            USD.NET.Connectable<System.String>varname  // 0x0
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: USD.NET.Unity.PrimvarReaderExportSample`1
TYPE:  class
TOKEN: 0x200002B
EXTENDS: PrimvarReaderSample`1
FIELDS:
  public            USD.NET.Connectable<pxr.TfToken>varname  // 0x0
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: USD.NET.Unity.TextureReaderSample
TYPE:  class
TOKEN: 0x200002C
EXTENDS: ShaderSample
FIELDS:
  public            USD.NET.Connectable<pxr.SdfAssetPath>file  // 0x18
  public            USD.NET.Connectable<UnityEngine.Vector2>st  // 0x20
  public            USD.NET.Connectable<USD.NET.Unity.TextureReaderSample.WrapMode>wrapS  // 0x28
  public            USD.NET.Connectable<USD.NET.Unity.TextureReaderSample.WrapMode>wrapT  // 0x30
  public            USD.NET.Connectable<UnityEngine.Vector4>fallback  // 0x38
  public            USD.NET.Connectable<UnityEngine.Vector4>scale  // 0x40
  public            USD.NET.Connectable<UnityEngine.Vector4>bias  // 0x48
  public            USD.NET.Connectable<USD.NET.Unity.TextureReaderSample.SRGBMode>isSRGB  // 0x50
  public            USD.NET.Unity.TextureReaderSample.Outputsoutputs  // 0x58
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String filePath)
  System.Void .ctor(System.String filePath, System.String stConnectionPath)
  USD.NET.Unity.TextureReaderSample.WrapMode GetWrapMode(UnityEngine.TextureWrapMode wrap)
END_CLASS

CLASS: USD.NET.Unity.UnityTypeBindings
TYPE:  class
TOKEN: 0x2000030
FIELDS:
  private   static  System.Boolean                  isInitialized  // 0x0
METHODS:
  System.Void .cctor()
  System.Void RegisterTypes()
END_CLASS

CLASS: USD.NET.Unity.PreserveAttribute
TYPE:  class
TOKEN: 0x2000032
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: USD.NET.Unity.UnityTypeConverter
TYPE:  class
TOKEN: 0x2000033
EXTENDS: IntrinsicTypeConverter
FIELDS:
  public    static  UnityEngine.Matrix4x4           basisChange  // 0x0
  public    static  UnityEngine.Matrix4x4           inverseBasisChange  // 0x40
METHODS:
  UnityEngine.Matrix4x4 ChangeBasis(UnityEngine.Matrix4x4 input)
  UnityEngine.Vector3 ChangeBasis(UnityEngine.Vector3 point)
  System.Void SetTransform(UnityEngine.Matrix4x4 localXf, UnityEngine.Transform transform)
  System.Boolean Decompose(UnityEngine.Matrix4x4 matrix, UnityEngine.Vector3& translation, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale)
  UnityEngine.Vector3 WeightedAvg(UnityEngine.Vector3 a, UnityEngine.Vector3 b, System.Single aWeight, System.Single bWeight)
  System.Void ExtractTrs(UnityEngine.Matrix4x4 transform, UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation, UnityEngine.Vector3& localScale)
  UnityEngine.Quaternion ExtractRotation(UnityEngine.Matrix4x4 mat4)
  UnityEngine.Vector3 ExtractPosition(UnityEngine.Matrix4x4 mat4)
  UnityEngine.Vector3 ExtractScale(UnityEngine.Matrix4x4 mat4)
  System.Boolean HasAnySiblingsWithName(UnityEngine.Transform transform, System.String name)
  System.String GetUniqueName(UnityEngine.Transform transform)
  System.String GetPath(UnityEngine.Transform unityObj)
  System.String GetPath(UnityEngine.Transform unityObj, UnityEngine.Transform unityObjRoot)
  UnityEngine.Matrix4x4 GetLocalToParentXf(UnityEngine.Transform unityXf)
  pxr.GfMatrix4d ToGfMatrix(UnityEngine.Transform unityXf)
  pxr.GfMatrix4d ToGfMatrix(UnityEngine.Matrix4x4 unityMat4)
  UnityEngine.Matrix4x4 FromMatrix(pxr.GfMatrix4d gfMat)
  pxr.VtMatrix4dArray ToVtArray(UnityEngine.Matrix4x4[] input)
  UnityEngine.Matrix4x4[] FromVtArray(pxr.VtMatrix4dArray input)
  pxr.VtMatrix4dArray ListToVtArray(System.Collections.Generic.List<UnityEngine.Matrix4x4> input)
  System.Collections.Generic.List<UnityEngine.Matrix4x4> ListFromVtArray(pxr.VtMatrix4dArray input)
  pxr.GfVec4f Color32ToVec4f(UnityEngine.Color32 c)
  UnityEngine.Color32 Vec4fToColor32(pxr.GfVec4f v)
  pxr.VtVec4fArray ToVtArray(System.Collections.Generic.List<UnityEngine.Color32> input)
  System.Void ToVtArray(System.Collections.Generic.List<UnityEngine.Color32> input, pxr.VtVec3fArray& rgb, pxr.VtFloatArray& alpha)
  pxr.VtVec4fArray ToVtArray(UnityEngine.Color32[] input)
  UnityEngine.Color32[] Color32FromVtArray(pxr.VtVec4fArray input)
  pxr.GfVec4f ColorToVec4f(UnityEngine.Color c)
  UnityEngine.Color Vec4fToColor(pxr.GfVec4f v)
  pxr.VtVec4fArray ToVtArray(System.Collections.Generic.List<UnityEngine.Color> input)
  System.Void ToVtArray(System.Collections.Generic.List<UnityEngine.Color> input, pxr.VtVec3fArray& rgb, pxr.VtFloatArray& alpha)
  pxr.VtVec4fArray ToVtArray(UnityEngine.Color[] input)
  UnityEngine.Color[] ColorFromVtArray(pxr.VtVec4fArray input)
  UnityEngine.Color[] ColorFromVtArray(pxr.VtVec4fArray input, UnityEngine.Color[]& output)
  System.Void ToVtArray(UnityEngine.Color32[] input, pxr.VtVec3fArray& rgb, pxr.VtFloatArray& alpha)
  UnityEngine.Vector3[] ExtractRgb(UnityEngine.Color32[] colors)
  System.Single[] ExtractAlpha(UnityEngine.Color32[] colors)
  System.Void ToVtArray(UnityEngine.Color[] input, pxr.VtVec3fArray& rgb, pxr.VtFloatArray& alpha)
  UnityEngine.Color[] FromVtArray(pxr.VtVec3fArray rgbIn, pxr.VtFloatArray alphaIn)
  UnityEngine.Vector3[] ExtractRgb(UnityEngine.Color[] colors)
  System.Single[] ExtractAlpha(UnityEngine.Color[] colors)
  System.Void SwapQuaternionReal(UnityEngine.Quaternion[]& input)
  pxr.GfQuatf QuaternionToQuatf(UnityEngine.Quaternion quaternion)
  UnityEngine.Quaternion QuatfToQuaternion(pxr.GfQuatf quat)
  pxr.VtQuatfArray ToVtArray(UnityEngine.Quaternion[] input)
  UnityEngine.Quaternion[] FromVtArray(pxr.VtQuatfArray input)
  pxr.VtQuatfArray ListToVtArray(System.Collections.Generic.List<UnityEngine.Quaternion> input)
  System.Collections.Generic.List<UnityEngine.Quaternion> ListFromVtArray(pxr.VtQuatfArray input)
  pxr.VtVec4fArray ToVtArray(UnityEngine.Vector4[] input)
  UnityEngine.Vector4[] FromVtArray(pxr.VtVec4fArray input)
  pxr.VtVec4fArray ListToVtArray(System.Collections.Generic.List<UnityEngine.Vector4> input)
  System.Collections.Generic.List<UnityEngine.Vector4> ListFromVtArray(pxr.VtVec4fArray input)
  pxr.VtVec3fArray BoundsToVtArray(UnityEngine.Bounds input)
  UnityEngine.Bounds BoundsFromVtArray(pxr.VtValue vtBounds)
  UnityEngine.Bounds BoundsFromVtArray(pxr.VtValue vtBounds, UnityEngine.Vector3[] bbox)
  pxr.VtVec3fArray ToVtArray(UnityEngine.Vector3[] input)
  UnityEngine.Vector3[] FromVtArray(pxr.VtVec3fArray input)
  System.Void FromVtArray(pxr.VtVec3fArray input, UnityEngine.Vector3[]& output)
  pxr.VtVec3fArray ListToVtArray(System.Collections.Generic.List<UnityEngine.Vector3> input)
  System.Collections.Generic.List<UnityEngine.Vector3> ListFromVtArray(pxr.VtVec3fArray input)
  pxr.VtVec2fArray ToVtArray(UnityEngine.Vector2[] input)
  UnityEngine.Vector2[] FromVtArray(pxr.VtVec2fArray input)
  pxr.VtVec2fArray ListToVtArray(System.Collections.Generic.List<UnityEngine.Vector2> input)
  System.Collections.Generic.List<UnityEngine.Vector2> ListFromVtArray(pxr.VtVec2fArray input)
  pxr.GfVec2f Vector2ToVec2f(UnityEngine.Vector2 vec2)
  UnityEngine.Vector2 Vec2fToVector2(pxr.GfVec2f value)
  pxr.GfVec3f Vector3ToVec3f(UnityEngine.Vector3 vec3)
  UnityEngine.Vector3 Vec3fToVector3(pxr.GfVec3f v3)
  pxr.GfVec4f Vector4ToVec4f(UnityEngine.Vector4 vector4)
  UnityEngine.Vector4 Vec4fToVector4(pxr.GfVec4f v4)
  pxr.GfVec4f RectToVtVec4(UnityEngine.Rect rect)
  UnityEngine.Rect Vec4fToRect(pxr.GfVec4f v4)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

