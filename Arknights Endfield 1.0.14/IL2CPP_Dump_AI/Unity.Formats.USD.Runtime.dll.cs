// ========================================================
// Dumped by @desirepro
// Assembly: Unity.Formats.USD.Runtime.dll
// Classes:  111
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: GeometrySubsets
TYPE:  class
TOKEN: 0x200001A
FIELDS:
  private           System.Collections.Generic.Dictionary<System.String,System.Int32[]><Subsets>k__BackingField  // 0x10
METHODS:
  System.Collections.Generic.Dictionary<System.String,System.Int32[]> get_Subsets()
  System.Void set_Subsets(System.Collections.Generic.Dictionary<System.String,System.Int32[]> value)
  System.Void .ctor()
END_CLASS

CLASS: ExportHandler
TYPE:  class
TOKEN: 0x2000026
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(USD.NET.Scene scene, System.String usdShaderPath, UnityEngine.Material material, Unity.Formats.USD.UnityPreviewSurfaceSample surface, System.String destTexturePath)
  System.IAsyncResult BeginInvoke(USD.NET.Scene scene, System.String usdShaderPath, UnityEngine.Material material, Unity.Formats.USD.UnityPreviewSurfaceSample surface, System.String destTexturePath, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: TextureResolver
TYPE:  class
TOKEN: 0x2000028
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  UnityEngine.Texture2D Invoke(pxr.SdfAssetPath textureAssetPath, System.Boolean isNormalMap, Unity.Formats.USD.SceneImportOptions importOptions)
  System.IAsyncResult BeginInvoke(pxr.SdfAssetPath textureAssetPath, System.Boolean isNormalMap, Unity.Formats.USD.SceneImportOptions importOptions, System.AsyncCallback callback, System.Object object)
  UnityEngine.Texture2D EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: MaterialBinder
TYPE:  class
TOKEN: 0x200002A
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(USD.NET.Scene scene, UnityEngine.Material mat, System.Collections.Generic.List<System.String> uvPrimvars)
  System.IAsyncResult BeginInvoke(USD.NET.Scene scene, UnityEngine.Material mat, System.Collections.Generic.List<System.String> uvPrimvars, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: ConversionType
TYPE:  struct
TOKEN: 0x200002C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.Formats.USD.ShaderExporterBase.ConversionTypeNone  // 0x0
  public    static  Unity.Formats.USD.ShaderExporterBase.ConversionTypeSwapRASmoothnessToBGRoughness  // 0x0
  public    static  Unity.Formats.USD.ShaderExporterBase.ConversionTypeInvertAlpha  // 0x0
  public    static  Unity.Formats.USD.ShaderExporterBase.ConversionTypeUnpackNormal  // 0x0
  public    static  Unity.Formats.USD.ShaderExporterBase.ConversionTypeMaskMapToORM  // 0x0
  public    static  Unity.Formats.USD.ShaderExporterBase.ConversionTypeRemoveAlpha  // 0x0
METHODS:
END_CLASS

CLASS: StandardShaderBlendMode
TYPE:  struct
TOKEN: 0x2000030
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.Formats.USD.StandardShaderExporter.StandardShaderBlendModeOpaque  // 0x0
  public    static  Unity.Formats.USD.StandardShaderExporter.StandardShaderBlendModeCutout  // 0x0
  public    static  Unity.Formats.USD.StandardShaderExporter.StandardShaderBlendModeFade  // 0x0
  public    static  Unity.Formats.USD.StandardShaderExporter.StandardShaderBlendModeTransparent  // 0x0
METHODS:
END_CLASS

CLASS: HierInfo
TYPE:  struct
TOKEN: 0x200003E
FIELDS:
  public            System.Boolean                  isVisible  // 0x10
  public            System.Boolean                  isInstance  // 0x11
  public            System.Boolean                  isAssembly  // 0x12
  public            System.Boolean                  isModel  // 0x13
  public            System.Boolean                  hasPayload  // 0x14
  public            pxr.UsdPrim                     prim  // 0x18
  public            pxr.UsdSkelBindingVector        skelBindings  // 0x20
  public            pxr.SdfPath[]                   skelJoints  // 0x28
  public            System.String                   modelAssetPath  // 0x30
  public            System.String                   modelName  // 0x38
  public            System.String                   modelVersion  // 0x40
METHODS:
END_CLASS

CLASS: ReadHierJob
TYPE:  struct
TOKEN: 0x200003F
FIELDS:
  public    static  Unity.Formats.USD.HierarchyBuilder.HierInfo[]result  // 0x0
  public    static  USD.NET.Scene                   scene  // 0x8
  public    static  pxr.UsdSkelCache                skelCache  // 0x10
  public    static  pxr.SdfPath[]                   paths  // 0x18
METHODS:
  System.Void Run()
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: IQuery
TYPE:  interface
TOKEN: 0x2000041
FIELDS:
METHODS:
  pxr.SdfPath[] Find(USD.NET.Scene scene, pxr.SdfPath usdRoot)
END_CLASS

CLASS: Query`1
TYPE:  struct
TOKEN: 0x2000042
FIELDS:
METHODS:
  pxr.SdfPath[] Find(USD.NET.Scene scene, pxr.SdfPath usdRoot)
END_CLASS

CLASS: FindPathsJob
TYPE:  struct
TOKEN: 0x2000040
FIELDS:
  public    static  pxr.SdfPath                     usdRoot  // 0x0
  public    static  USD.NET.Scene                   scene  // 0x8
  public    static  pxr.SdfPath[][]                 results  // 0x10
  public    static  Unity.Formats.USD.HierarchyBuilder.FindPathsJob.IQuery[]queries  // 0x18
METHODS:
  System.Void Run()
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: InstanceRoot
TYPE:  struct
TOKEN: 0x2000049
FIELDS:
  public            UnityEngine.GameObject          gameObject  // 0x10
  public            pxr.SdfPath                     masterPath  // 0x18
METHODS:
END_CLASS

CLASS: ImportException
TYPE:  class
TOKEN: 0x2000055
EXTENDS: Exception
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String message)
  System.Void .ctor(System.String message, System.Exception innerException)
END_CLASS

CLASS: Beyond.SourceGenerator.CameraControlConfigAttribute
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.ECSComponentAttribute
TYPE:  class
TOKEN: 0x2000004
EXTENDS: Attribute
FIELDS:
  public            System.Runtime.InteropServices.LayoutKindlayoutKind  // 0x10
  public            System.Boolean                  isTag  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.DataNAttribute
TYPE:  class
TOKEN: 0x2000005
EXTENDS: Attribute
FIELDS:
  public            System.Int32                    capacity  // 0x10
  public            System.Int32                    tSize  // 0x14
  public            System.Boolean                  ring  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.AnimatorBlackboardAttribute
TYPE:  class
TOKEN: 0x2000006
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HG.Rendering.Runtime.HGConstantBufferLayoutAttribute
TYPE:  class
TOKEN: 0x2000002
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.UsdAssemblyRoot
TYPE:  class
TOKEN: 0x2000007
EXTENDS: MonoBehaviour
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.UsdAsset
TYPE:  class
TOKEN: 0x2000008
EXTENDS: MonoBehaviour
FIELDS:
  private           System.String                   m_usdFile  // 0x18
  public            System.String                   m_projectAssetPath  // 0x20
  public            System.String                   m_usdRootPath  // 0x28
  public            System.Single                   m_usdTimeOffset  // 0x30
  public            Unity.Formats.USD.PayloadPolicy m_payloadPolicy  // 0x34
  public            System.Boolean                  m_importHierarchy  // 0x38
  public            System.Single                   m_scale  // 0x3C
  public            Unity.Formats.USD.BasisTransformationm_changeHandedness  // 0x40
  public            USD.NET.Scene.InterpolationMode m_interpolation  // 0x44
  public            System.Boolean                  m_useOriginalShaderIfAvailable  // 0x48
  public            UnityEngine.Material            m_displayColorMaterial  // 0x50
  public            UnityEngine.Material            m_specularWorkflowMaterial  // 0x58
  public            UnityEngine.Material            m_metallicWorkflowMaterial  // 0x60
  public            System.Boolean                  m_enableGpuInstancing  // 0x68
  public            Unity.Formats.USD.ImportMode    m_points  // 0x6C
  public            Unity.Formats.USD.ImportMode    m_topology  // 0x70
  public            Unity.Formats.USD.ImportMode    m_boundingBox  // 0x74
  public            Unity.Formats.USD.ImportMode    m_color  // 0x78
  public            Unity.Formats.USD.ImportMode    m_normals  // 0x7C
  public            Unity.Formats.USD.ImportMode    m_tangents  // 0x80
  public            System.Boolean                  m_generateLightmapUVs  // 0x84
  public            System.Single                   m_unwrapAngleError  // 0x88
  public            System.Single                   m_unwrapAreaError  // 0x8C
  public            System.Single                   m_unwrapHardAngle  // 0x90
  public            System.Int32                    m_unwrapPackMargin  // 0x94
  public            Unity.Formats.USD.MaterialImportModem_materialImportMode  // 0x98
  public            System.Boolean                  m_importCameras  // 0x9C
  public            System.Boolean                  m_importMeshes  // 0x9D
  public            System.Boolean                  m_importSkinning  // 0x9E
  public            System.Boolean                  m_importTransforms  // 0x9F
  public            System.Boolean                  m_importSceneInstances  // 0xA0
  public            System.Boolean                  m_importPointInstances  // 0xA1
  public            System.Boolean                  m_importMonoBehaviors  // 0xA2
  public            System.Boolean                  m_debugShowSkeletonBindPose  // 0xA3
  public            System.Boolean                  m_debugShowSkeletonRestPose  // 0xA4
  public            System.Boolean                  m_debugPrintVariabilityCache  // 0xA5
  public            System.Boolean                  m_usdVariabilityCache  // 0xA6
  public            Unity.Formats.USD.BasisTransformationLastHandedness  // 0xA8
  public            System.Single                   LastScale  // 0xAC
  private           System.Single                   m_lastTime  // 0xB0
  private           USD.NET.Scene                   m_lastScene  // 0xB8
  private           Unity.Formats.USD.PrimMap       m_lastPrimMap  // 0xC0
  private           USD.NET.AccessMask              m_lastAccessMask  // 0xC8
METHODS:
  System.Double get_Length()
  System.String get_usdFullPath()
  System.Void set_usdFullPath(System.String value)
  System.Void OnDestroy()
  System.String GetPrefabAssetPath(UnityEngine.GameObject root)
  System.Void OptionsToState(Unity.Formats.USD.SceneImportOptions options)
  System.Void StateToOptions(Unity.Formats.USD.SceneImportOptions& options)
  System.Boolean SceneFileChanged()
  USD.NET.Scene GetScene()
  System.Void OnReload()
  System.Void DestroyComponent(UnityEngine.Component comp)
  System.Void ClearLastData()
  System.Void RemoveAllUsdComponents()
  System.Void DestroyAllImportedObjects()
  System.Void Reload(System.Boolean forceRebuild)
  pxr.UsdPrim GetFirstPrim(USD.NET.Scene scene)
  System.Void ExportOverrides(USD.NET.Scene sceneInWhichToStoreTransforms)
  System.Double ComputeLength()
  System.Void SetTime(System.Double time, Unity.Formats.USD.UsdAsset foreignRoot, System.Boolean saveMeshUpdates)
  System.Void Update()
  System.Void PrepOptionsForTimeChange(Unity.Formats.USD.SceneImportOptions& options)
  System.Void ImportUsdAsCoroutine(UnityEngine.GameObject goRoot, System.String usdFilePath, System.Double time, Unity.Formats.USD.SceneImportOptions importOptions, System.Single targetFrameMilliseconds)
  System.Void SetPayloadState(UnityEngine.GameObject go, System.Boolean isLoaded)
  System.Void ApplyVariantSelectionState(USD.NET.Scene scene, Unity.Formats.USD.UsdVariantSet variants)
  System.Void SetVariantSelection(UnityEngine.GameObject go, System.String usdPrimPath, System.Collections.Generic.Dictionary<System.String,System.String> selections)
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.UsdLayerStack
TYPE:  class
TOKEN: 0x2000009
EXTENDS: MonoBehaviour
FIELDS:
  public            System.String                   m_targetLayer  // 0x18
  public            System.String[]                 m_layerStack  // 0x20
  public            System.String[]                 m_mutedLayers  // 0x28
METHODS:
  System.Void SetupNewSubLayer(USD.NET.Scene parentScene, USD.NET.Scene subLayerScene)
  System.Void SaveLayerStack(USD.NET.Scene scene, System.String[] layerStack)
  System.Void SaveToLayer()
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.UsdModelRoot
TYPE:  class
TOKEN: 0x200000A
EXTENDS: MonoBehaviour
FIELDS:
  public            System.String                   m_modelName  // 0x18
  public            System.String                   m_modelVersion  // 0x20
  public            System.String                   m_modelAssetPath  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.UsdPayload
TYPE:  class
TOKEN: 0x200000B
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Boolean                  m_isLoaded  // 0x18
  private           System.Boolean                  m_wasLoaded  // 0x19
METHODS:
  System.Boolean get_IsLoaded()
  System.Void Load()
  System.Void Unload()
  System.Void SetInitialState(System.Boolean loaded)
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.UsdPrimSource
TYPE:  class
TOKEN: 0x200000C
EXTENDS: MonoBehaviour
FIELDS:
  public            System.String                   m_usdPrimPath  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.UsdVariantSet
TYPE:  class
TOKEN: 0x200000D
EXTENDS: MonoBehaviour
FIELDS:
  public            System.String[]                 m_variantSetNames  // 0x18
  public            System.String[]                 m_selected  // 0x20
  public            System.String[]                 m_variants  // 0x28
  public            System.Int32[]                  m_variantCounts  // 0x30
  public            System.String                   m_primPath  // 0x38
METHODS:
  System.Void LoadFromUsd(pxr.UsdPrim prim)
  System.Void ApplyVariantSelections()
  System.Collections.Generic.Dictionary<System.String,System.String> GetVariantSelections()
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.SkinnedMeshUnityDiff
TYPE:  class
TOKEN: 0x200000F
EXTENDS: MonoBehaviour
FIELDS:
  public            UnityEngine.SkinnedMeshRenderer m_usdMesh  // 0x18
  public            UnityEngine.SkinnedMeshRenderer m_unityMesh  // 0x20
METHODS:
  System.Void OnEnable()
  System.Boolean Approximately(UnityEngine.Matrix4x4 rhs, UnityEngine.Matrix4x4 lhs)
  System.Boolean WeightsMatch(UnityEngine.BoneWeight w1, UnityEngine.BoneWeight w2)
  System.Boolean IndicesMatch(UnityEngine.BoneWeight w1, UnityEngine.BoneWeight w2)
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.SkinnedMeshUsdDiff
TYPE:  class
TOKEN: 0x2000010
EXTENDS: MonoBehaviour
FIELDS:
  public            System.String                   m_usdFile  // 0x18
  public            System.String                   m_usdMeshPath  // 0x20
  public            Unity.Formats.USD.BasisTransformationm_basisTransform  // 0x28
METHODS:
  System.Void OnEnable()
  System.String GetUsdBoneData(System.Int32 bone, System.Int32 weightIndex, USD.NET.Primvar<T[]> primvar)
  USD.NET.Scene GetScene()
  Unity.Formats.USD.SkelBindingSample ReadUsdWeights(USD.NET.Scene scene)
  Unity.Formats.USD.SkeletonSample ReadUsdSkeleton(USD.NET.Scene scene, System.String& skelRootPath)
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.CameraExporter
TYPE:  class
TOKEN: 0x2000011
FIELDS:
METHODS:
  System.Void ExportCamera(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext)
END_CLASS

CLASS: Unity.Formats.USD.CameraImporter
TYPE:  class
TOKEN: 0x2000012
FIELDS:
METHODS:
  System.Void BuildCamera(USD.NET.Unity.CameraSample usdCamera, UnityEngine.GameObject go, Unity.Formats.USD.SceneImportOptions options)
END_CLASS

CLASS: Unity.Formats.USD.CubeImporter
TYPE:  class
TOKEN: 0x2000013
FIELDS:
METHODS:
  System.Void BuildCube(USD.NET.Unity.CubeSample usdCube, UnityEngine.GameObject go, Unity.Formats.USD.SceneImportOptions options, System.Boolean skinnedMesh)
  System.Boolean ShouldImport(Unity.Formats.USD.ImportMode mode)
  System.Boolean ShouldCompute(Unity.Formats.USD.ImportMode mode)
END_CLASS

CLASS: Unity.Formats.USD.InstanceImporter
TYPE:  class
TOKEN: 0x2000014
FIELDS:
METHODS:
  System.Void BuildSceneInstances(Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions options)
  System.Void BuildPointInstances(USD.NET.Scene scene, Unity.Formats.USD.PrimMap primMap, System.String pointInstancerPath, USD.NET.Unity.PointInstancerSample sample, UnityEngine.GameObject root, Unity.Formats.USD.SceneImportOptions options)
  System.Void EnableGpuInstancing(UnityEngine.GameObject go)
END_CLASS

CLASS: Unity.Formats.USD.MeshExporter
TYPE:  class
TOKEN: 0x2000015
FIELDS:
  private   static  pxr.TfToken                     m_materialBindToken  // 0x0
  private   static  pxr.TfToken                     m_subMeshesToken  // 0x8
METHODS:
  System.Void ExportSkinnedMesh(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext)
  System.Void ExportSkelWeights(USD.NET.Scene scene, System.String path, UnityEngine.Mesh unityMesh, UnityEngine.Transform rootBone, UnityEngine.Transform[] bones, System.String skeletonPath)
  System.Void ExportMesh(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext)
  System.Void ExportMesh(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext, UnityEngine.Mesh mesh, UnityEngine.Material sharedMaterial, UnityEngine.Material[] sharedMaterials, System.Boolean exportMeshPose)
  System.Void .cctor()
END_CLASS

CLASS: Unity.Formats.USD.MeshImportFunction`1
TYPE:  class
TOKEN: 0x2000016
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.String path, T sample, Unity.Formats.USD.MeshImporter.GeometrySubsets subsets, UnityEngine.GameObject go, Unity.Formats.USD.SceneImportOptions option, System.Boolean isDynamic, pxr.UsdSkelSkinningQuery query)
  System.IAsyncResult BeginInvoke(System.String path, T sample, Unity.Formats.USD.MeshImporter.GeometrySubsets subsets, UnityEngine.GameObject go, Unity.Formats.USD.SceneImportOptions option, System.Boolean isDynamic, pxr.UsdSkelSkinningQuery query, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: Unity.Formats.USD.MeshImportStrategy
TYPE:  class
TOKEN: 0x2000017
FIELDS:
  private           Unity.Formats.USD.MeshImportFunction<Unity.Formats.USD.SanitizedMeshSample>m_meshImporter  // 0x10
  private           Unity.Formats.USD.MeshImportFunction<Unity.Formats.USD.SanitizedMeshSample>m_skinnedMeshImporter  // 0x18
  private           Unity.Formats.USD.ReadAllJob<Unity.Formats.USD.SanitizedMeshSample>m_readMeshesJob  // 0x20
METHODS:
  System.Void .ctor(Unity.Formats.USD.MeshImportFunction<Unity.Formats.USD.SanitizedMeshSample> meshImporter, Unity.Formats.USD.MeshImportFunction<Unity.Formats.USD.SanitizedMeshSample> skinnedMeshImporter)
  System.Void BeginReading(USD.NET.Scene scene, Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions importOptions)
  System.Collections.IEnumerator Import(USD.NET.Scene scene, Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions importOptions)
END_CLASS

CLASS: Unity.Formats.USD.MeshImporter
TYPE:  class
TOKEN: 0x2000019
FIELDS:
METHODS:
  Unity.Formats.USD.MeshImporter.GeometrySubsets ReadGeomSubsets(USD.NET.Scene scene, System.String path)
  System.Void BuildSkinnedMesh(System.String path, Unity.Formats.USD.SanitizedMeshSample usdMesh, Unity.Formats.USD.MeshImporter.GeometrySubsets geomSubsets, UnityEngine.GameObject go, Unity.Formats.USD.SceneImportOptions options, System.Boolean isDynamic, pxr.UsdSkelSkinningQuery skinningQuery)
  System.Void ImportSkinning(System.String path, Unity.Formats.USD.SanitizedMeshSample usdMesh, UnityEngine.Mesh unityMesh, pxr.UsdSkelSkinningQuery skinningQuery)
  System.Void BuildMesh(System.String path, Unity.Formats.USD.SanitizedMeshSample usdMesh, Unity.Formats.USD.MeshImporter.GeometrySubsets geomSubsets, UnityEngine.GameObject go, Unity.Formats.USD.SceneImportOptions options, System.Boolean isDynamic, pxr.UsdSkelSkinningQuery skinQuery)
  System.Void BuildMesh_(System.String path, Unity.Formats.USD.SanitizedMeshSample usdMesh, UnityEngine.Mesh unityMesh, Unity.Formats.USD.MeshImporter.GeometrySubsets geomSubsets, UnityEngine.GameObject go, UnityEngine.Renderer renderer, Unity.Formats.USD.SceneImportOptions options)
  System.Void LoadPrimvars(UnityEngine.Mesh unityMesh, System.String usdMeshPath, System.Collections.Generic.List<System.String> primvars, USD.NET.Unity.MeshSample sample)
  System.Void BindMat(UnityEngine.Mesh unityMesh, UnityEngine.Material mat, UnityEngine.Renderer renderer, System.String usdMeshPath, System.Collections.Generic.List<System.String> primvars, USD.NET.Unity.MeshSample sample)
  System.Void BindMat(UnityEngine.Mesh unityMesh, UnityEngine.Material mat, UnityEngine.Renderer renderer, System.Int32 index, System.String usdMeshPath, System.Collections.Generic.List<System.String> primvars, USD.NET.Unity.MeshSample sample)
  T[] TryGetPrimvarValue(USD.NET.Primvar<System.Object> primvar)
  System.Void ImportUv(UnityEngine.Mesh unityMesh, System.Int32 uvSetIndex, USD.NET.Primvar<System.Object> uv)
  System.Boolean ShouldImport(Unity.Formats.USD.ImportMode mode)
  System.Boolean ShouldCompute(Unity.Formats.USD.ImportMode mode)
  System.String UniqueMeshName(System.String meshName)
END_CLASS

CLASS: Unity.Formats.USD.ImportMode
TYPE:  struct
TOKEN: 0x200001D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.Formats.USD.ImportMode    Import  // 0x0
  public    static  Unity.Formats.USD.ImportMode    ImportOrCompute  // 0x0
  public    static  Unity.Formats.USD.ImportMode    Compute  // 0x0
  public    static  Unity.Formats.USD.ImportMode    Ignore  // 0x0
METHODS:
END_CLASS

CLASS: Unity.Formats.USD.MeshImportOptions
TYPE:  class
TOKEN: 0x200001E
FIELDS:
  public            System.Boolean                  debugShowSkeletonRestPose  // 0x10
  public            System.Boolean                  debugShowSkeletonBindPose  // 0x11
  public            Unity.Formats.USD.ImportMode    points  // 0x14
  public            Unity.Formats.USD.ImportMode    topology  // 0x18
  public            System.Boolean                  triangulateMesh  // 0x1C
  public            System.Boolean                  generateLightmapUVs  // 0x1D
  public            System.Single                   unwrapAngleError  // 0x20
  public            System.Single                   unwrapAreaError  // 0x24
  public            System.Single                   unwrapHardAngle  // 0x28
  public            System.Int32                    unwrapPackMargin  // 0x2C
  public            Unity.Formats.USD.ImportMode    color  // 0x30
  public            Unity.Formats.USD.ImportMode    normals  // 0x34
  public            Unity.Formats.USD.ImportMode    tangents  // 0x38
  public            Unity.Formats.USD.ImportMode    boundingBox  // 0x3C
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.SphereImporter
TYPE:  class
TOKEN: 0x200001F
FIELDS:
METHODS:
  System.Void BuildSphere(USD.NET.Unity.SphereSample usdSphere, UnityEngine.GameObject go, Unity.Formats.USD.SceneImportOptions options, System.Boolean skinnedMesh)
  System.Boolean ShouldImport(Unity.Formats.USD.ImportMode mode)
  System.Boolean ShouldCompute(Unity.Formats.USD.ImportMode mode)
END_CLASS

CLASS: Unity.Formats.USD.XformExporter
TYPE:  class
TOKEN: 0x2000020
FIELDS:
METHODS:
  System.Void ExportXform(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext)
  System.Void WriteSparseOverrides(USD.NET.Scene scene, Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.BasisTransformation changeHandedness, System.Single tolerance)
  UnityEngine.Matrix4x4 GetLocalTransformMatrix(UnityEngine.Transform tr, System.Boolean correctZUp, System.Boolean isRootPrim, Unity.Formats.USD.BasisTransformation conversionType)
END_CLASS

CLASS: Unity.Formats.USD.XformImporter
TYPE:  class
TOKEN: 0x2000021
FIELDS:
METHODS:
  System.Void BuildXform(pxr.SdfPath path, USD.NET.Unity.XformableSample usdXf, UnityEngine.GameObject go, Unity.Formats.USD.SceneImportOptions options, USD.NET.Scene scene)
  System.Void BuildXform(UnityEngine.Matrix4x4 xf, UnityEngine.GameObject go, Unity.Formats.USD.SceneImportOptions options)
  System.Void ImportXform(UnityEngine.Matrix4x4& mat, Unity.Formats.USD.SceneImportOptions options)
  System.Void BuildSceneRoot(USD.NET.Scene scene, UnityEngine.Transform root, Unity.Formats.USD.SceneImportOptions options)
  System.Void UndoRootTransform(USD.NET.Scene scene, Unity.Formats.USD.UsdAsset stageRoot, UnityEngine.Vector3& localScale, UnityEngine.Quaternion& localRotation)
END_CLASS

CLASS: Unity.Formats.USD.ImporterBase
TYPE:  class
TOKEN: 0x2000022
FIELDS:
METHODS:
  System.String MakeRelativePath(System.String anchorPath, System.String pathToMakeRelative)
  System.Boolean ApproximatelyEqual(UnityEngine.Matrix4x4 lhs, UnityEngine.Matrix4x4 rhs)
  System.Void MoveComponentFirst(UnityEngine.Component comp)
  System.Void MoveComponentLast(UnityEngine.Component comp)
  T GetOrAddComponent(UnityEngine.GameObject go, System.Boolean insertFirst)
  System.String SafeGetDirectoryName(System.String fullPath)
END_CLASS

CLASS: Unity.Formats.USD.HdrpShaderExporter
TYPE:  class
TOKEN: 0x2000023
EXTENDS: ShaderExporterBase
FIELDS:
METHODS:
  System.Void ExportLit(USD.NET.Scene scene, System.String usdShaderPath, UnityEngine.Material material, USD.NET.Unity.PreviewSurfaceSample surface, System.String destTexturePath)
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.HdrpShaderImporter
TYPE:  class
TOKEN: 0x2000024
EXTENDS: ShaderImporterBase
FIELDS:
  private   static  UnityEngine.Material            ChannelCombinerMat  // 0x0
METHODS:
  System.Void .ctor(UnityEngine.Material material)
  System.Void ImportFromUsd()
  UnityEngine.Texture2D BuildMaskMap(UnityEngine.Texture2D red, UnityEngine.Texture2D green, UnityEngine.Texture2D blue, UnityEngine.Texture2D alpha)
END_CLASS

CLASS: Unity.Formats.USD.MaterialExporter
TYPE:  class
TOKEN: 0x2000025
FIELDS:
  public    static readonly System.String                   kStandardFallbackHandler  // 0x0
  public    static readonly System.String                   kHdrpFallbackHandler  // 0x8
  public    static readonly System.String                   kLwrpFallbackHandler  // 0x10
  public    static  System.Collections.Generic.Dictionary<System.String,Unity.Formats.USD.MaterialExporter.ExportHandler>ExportRegistry  // 0x18
METHODS:
  System.Void .cctor()
  System.Void ExportMaterial(USD.NET.Scene scene, UnityEngine.Material mat, System.String usdMaterialPath)
END_CLASS

CLASS: Unity.Formats.USD.MaterialImporter
TYPE:  class
TOKEN: 0x2000027
FIELDS:
  private   static readonly pxr.TfToken                     materialBindToken  // 0x0
  private   static  UnityEngine.Material            AlbedoGlossCombiner  // 0x8
  public    static  Unity.Formats.USD.MaterialImporter.TextureResolverOnResolveTexture  // 0x10
METHODS:
  System.Void ProcessMaterialBindings(USD.NET.Scene scene, Unity.Formats.USD.SceneImportOptions importOptions)
  UnityEngine.Material BuildMaterial(USD.NET.Scene scene, System.String materialPath, USD.NET.Unity.MaterialSample sample, Unity.Formats.USD.SceneImportOptions options)
  UnityEngine.Texture2D ImportConnectedTexture(USD.NET.Scene scene, USD.NET.Connectable<T> connection, System.Boolean isNormalMap, Unity.Formats.USD.SceneImportOptions options, System.String& uvPrimvar)
  UnityEngine.Texture2D DefaultTextureResolver(pxr.SdfAssetPath textureAssetPath, System.Boolean isNormalMap, Unity.Formats.USD.SceneImportOptions options)
  UnityEngine.Texture2D CombineRoughness(UnityEngine.Texture2D rgbTex, UnityEngine.Texture2D roughnessTex, System.String fileNameSuffix)
  Unity.Formats.USD.UnityPreviewSurfaceSample GetSurfaceShaderPrim(USD.NET.Scene scene, System.String primPath)
  System.Void .cctor()
END_CLASS

CLASS: Unity.Formats.USD.MaterialMap
TYPE:  class
TOKEN: 0x2000029
FIELDS:
  private           System.Collections.Generic.Dictionary<System.String,UnityEngine.Material>m_map  // 0x10
  private           System.Collections.Generic.Dictionary<UnityEngine.Color,UnityEngine.Material>m_colorMap  // 0x18
  private           System.Collections.Generic.Dictionary<System.String,Unity.Formats.USD.MaterialMap.MaterialBinder>m_requestedBindings  // 0x20
  private           System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<System.String>>m_primvars  // 0x28
  public            System.Boolean                  useOriginalShaderIfAvailable  // 0x30
  private           UnityEngine.Material            m_displayColorMaterial  // 0x38
  private           UnityEngine.Material            m_specularWorkflowMaterial  // 0x40
  private           UnityEngine.Material            m_metallicWorkflowMaterial  // 0x48
METHODS:
  UnityEngine.Material get_DisplayColorMaterial()
  System.Void set_DisplayColorMaterial(UnityEngine.Material value)
  UnityEngine.Material get_SpecularWorkflowMaterial()
  System.Void set_SpecularWorkflowMaterial(UnityEngine.Material value)
  UnityEngine.Material get_MetallicWorkflowMaterial()
  System.Void set_MetallicWorkflowMaterial(UnityEngine.Material value)
  System.Void InstantiateMaterials()
  System.Collections.Generic.Dictionary<System.String,Unity.Formats.USD.MaterialMap.MaterialBinder> ClearRequestedBindings()
  System.Void RequestBinding(System.String usdPath, Unity.Formats.USD.MaterialMap.MaterialBinder binder)
  UnityEngine.Material get_Item(System.String path)
  System.Void set_Item(System.String path, UnityEngine.Material value)
  System.Collections.Generic.List<System.String> GetPrimvars(System.String materialPath)
  System.Void SetPrimvars(System.String materialPath, System.Collections.Generic.List<System.String> primvars)
  UnityEngine.Material InstantiateSolidColor(UnityEngine.Color color)
  System.Void AssignColor(UnityEngine.Material material, UnityEngine.Color color)
  System.Collections.IEnumerator GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Material>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Material>>.GetEnumerator()
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.ShaderExporterBase
TYPE:  class
TOKEN: 0x200002B
FIELDS:
  private   static  UnityEngine.Material            _metalGlossChannelSwapMaterial  // 0x0
  private   static  UnityEngine.Material            _normalChannelMaterial  // 0x8
METHODS:
  System.String SetupTexture(USD.NET.Scene scene, System.String usdShaderPath, UnityEngine.Material material, USD.NET.Unity.PreviewSurfaceSample surface, UnityEngine.Vector4 scale, System.String destTexturePath, System.String textureName, System.String textureOutput, Unity.Formats.USD.ShaderExporterBase.ConversionType conversionType)
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.ShaderImporterBase
TYPE:  class
TOKEN: 0x200002D
FIELDS:
  private           UnityEngine.Material            <Material>k__BackingField  // 0x10
  private           System.Boolean                  <IsSpecularWorkflow>k__BackingField  // 0x18
  public            System.Nullable<UnityEngine.Color>Diffuse  // 0x1C
  public            UnityEngine.Texture2D           DiffuseMap  // 0x30
  public            System.Nullable<UnityEngine.Color>Specular  // 0x38
  public            UnityEngine.Texture2D           SpecularMap  // 0x50
  public            System.Nullable<UnityEngine.Vector3>Normal  // 0x58
  public            UnityEngine.Texture2D           NormalMap  // 0x68
  public            System.Nullable<System.Single>  Displacement  // 0x70
  public            UnityEngine.Texture2D           DisplacementMap  // 0x78
  public            System.Nullable<System.Single>  Occlusion  // 0x80
  public            UnityEngine.Texture2D           OcclusionMap  // 0x88
  public            System.Nullable<UnityEngine.Color>Emission  // 0x90
  public            UnityEngine.Texture2D           EmissionMap  // 0xA8
  public            System.Nullable<System.Single>  Roughness  // 0xB0
  public            UnityEngine.Texture2D           RoughnessMap  // 0xB8
  public            System.Nullable<System.Single>  Metallic  // 0xC0
  public            UnityEngine.Texture2D           MetallicMap  // 0xC8
  public            System.Nullable<System.Single>  Clearcoat  // 0xD0
  public            UnityEngine.Texture2D           ClearcoatMap  // 0xD8
  public            System.Nullable<System.Single>  ClearcoatRoughness  // 0xE0
  public            System.Nullable<System.Single>  OpacityThreshold  // 0xE8
  public            System.Nullable<System.Single>  Opacity  // 0xF0
  public            UnityEngine.Texture2D           OpacityMap  // 0xF8
METHODS:
  UnityEngine.Material get_Material()
  System.Void set_Material(UnityEngine.Material value)
  System.Boolean get_IsSpecularWorkflow()
  System.Void set_IsSpecularWorkflow(System.Boolean value)
  System.Void .ctor(UnityEngine.Material material)
  System.Void ImportFromUsd()
  System.Void ImportColorOrMap(USD.NET.Scene scene, USD.NET.Connectable<UnityEngine.Vector3> usdParam, System.Boolean isNormalMap, Unity.Formats.USD.SceneImportOptions options, UnityEngine.Texture2D& map, System.Nullable<UnityEngine.Color>& value, System.String& uvPrimvar)
  System.Void ImportValueOrMap(USD.NET.Scene scene, USD.NET.Connectable<T> usdParam, System.Boolean isNormalMap, Unity.Formats.USD.SceneImportOptions options, UnityEngine.Texture2D& map, System.Nullable<T>& value, System.String& uvPrimvar)
  System.Void MergePrimvars(System.String newPrimvar, System.Collections.Generic.List<System.String> primvars)
  System.Void ImportParametersFromUsd(USD.NET.Scene scene, System.String materialPath, USD.NET.Unity.MaterialSample materialSample, USD.NET.Unity.PreviewSurfaceSample previewSurf, Unity.Formats.USD.SceneImportOptions options)
END_CLASS

CLASS: Unity.Formats.USD.StandardShaderExporter
TYPE:  class
TOKEN: 0x200002F
EXTENDS: ShaderExporterBase
FIELDS:
METHODS:
  System.Void ExportStandardSpecular(USD.NET.Scene scene, System.String usdShaderPath, UnityEngine.Material material, Unity.Formats.USD.UnityPreviewSurfaceSample surface, System.String destTexturePath)
  System.Void ExportStandardRoughness(USD.NET.Scene scene, System.String usdShaderPath, UnityEngine.Material material, Unity.Formats.USD.UnityPreviewSurfaceSample surface, System.String destTexturePath)
  System.Void ExportStandard(USD.NET.Scene scene, System.String usdShaderPath, UnityEngine.Material material, Unity.Formats.USD.UnityPreviewSurfaceSample surface, System.String destTexturePath)
  System.Void ExportGeneric(USD.NET.Scene scene, System.String usdShaderPath, UnityEngine.Material material, Unity.Formats.USD.UnityPreviewSurfaceSample surface, System.String destTexturePath)
  System.Void ExportStandardCommon(USD.NET.Scene scene, System.String usdShaderPath, UnityEngine.Material mat, Unity.Formats.USD.UnityPreviewSurfaceSample surface, System.String destTexturePath)
  System.Boolean ShouldUseSpecularWorkflow(UnityEngine.Material material)
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.StandardShaderImporter
TYPE:  class
TOKEN: 0x2000031
EXTENDS: ShaderImporterBase
FIELDS:
METHODS:
  System.Void .ctor(UnityEngine.Material material)
  System.Void ImportFromUsd()
END_CLASS

CLASS: Unity.Formats.USD.UnityMaterialData
TYPE:  class
TOKEN: 0x2000032
EXTENDS: SampleBase
FIELDS:
  public            System.String                   shaderName  // 0x10
  public            System.String[]                 shaderKeywords  // 0x18
  public            System.Collections.Generic.Dictionary<System.String,System.Single>floatArgs  // 0x20
  public            System.Collections.Generic.Dictionary<System.String,UnityEngine.Color>colorArgs  // 0x28
  public            System.Collections.Generic.Dictionary<System.String,UnityEngine.Vector4>vectorArgs  // 0x30
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.UnityPreviewSurfaceSample
TYPE:  class
TOKEN: 0x2000033
EXTENDS: PreviewSurfaceSample
FIELDS:
  public            Unity.Formats.USD.UnityMaterialDataunity  // 0x90
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.UrpShaderImporter
TYPE:  class
TOKEN: 0x2000034
EXTENDS: ShaderImporterBase
FIELDS:
METHODS:
  System.Void .ctor(UnityEngine.Material material)
  System.Void ImportFromUsd()
END_CLASS

CLASS: Unity.Formats.USD.ReadAllJob`1
TYPE:  struct
TOKEN: 0x2000035
FIELDS:
  private   static  USD.NET.Scene                   m_scene  // 0x0
  private   static  pxr.SdfPath[]                   m_paths  // 0x0
  private   static  T[]                             m_results  // 0x0
  private   static  System.Object[]                 m_done  // 0x0
  private   static  USD.NET.SampleEnumerator.SampleHolder<T>m_current  // 0x0
  private   static  System.Threading.AutoResetEvent m_ready  // 0x0
  private   static  Unity.Formats.USD.SceneImportOptionsm_importOptions  // 0x0
METHODS:
  USD.NET.SampleEnumerator.SampleHolder<T> get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void .ctor(USD.NET.Scene scene, pxr.SdfPath[] paths, Unity.Formats.USD.SceneImportOptions importOptions)
  System.Boolean ShouldReadPath(USD.NET.Scene scene, pxr.SdfPath path)
  System.Void Run()
  System.Void Execute(System.Int32 index)
  System.Void AddPrimvarsFromMaterial(System.Int32 index, USD.NET.IArbitraryPrimvars& sample)
  System.Boolean MoveNext()
  System.Void Reset()
  System.Void Dispose()
  System.Collections.Generic.IEnumerator<USD.NET.SampleEnumerator.SampleHolder<T>> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Unity.Formats.USD.IRestorable
TYPE:  interface
TOKEN: 0x2000036
FIELDS:
METHODS:
  System.Boolean IsRestoredFromCachedData()
  System.Void FromCachedData(USD.NET.IRestorableData data)
  USD.NET.IRestorableData ToCachedData()
END_CLASS

CLASS: Unity.Formats.USD.ISanitizable
TYPE:  interface
TOKEN: 0x2000037
FIELDS:
METHODS:
  System.Void Sanitize(USD.NET.Scene scene, Unity.Formats.USD.SceneImportOptions importOptions)
END_CLASS

CLASS: Unity.Formats.USD.MeshStaticPropertiesData
TYPE:  class
TOKEN: 0x2000038
FIELDS:
  private           System.Int32[]                  originalFaceVertexCounts  // 0x10
  private           System.Int32[]                  originalFaceVertexIndices  // 0x18
  private           System.Boolean                  arePrimvarsFaceVarying  // 0x20
  private           USD.NET.Orientation             orientation  // 0x24
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.SanitizedXformSample
TYPE:  class
TOKEN: 0x2000039
EXTENDS: XformSample
FIELDS:
METHODS:
  System.Void Sanitize(USD.NET.Scene scene, Unity.Formats.USD.SceneImportOptions importOptions)
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.SanitizedCameraSample
TYPE:  class
TOKEN: 0x200003A
EXTENDS: CameraSample
FIELDS:
METHODS:
  System.Void Sanitize(USD.NET.Scene scene, Unity.Formats.USD.SceneImportOptions importOptions)
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.SanitizedMeshSample
TYPE:  class
TOKEN: 0x200003B
EXTENDS: MeshSample
FIELDS:
  private           System.Int32[]                  originalFaceVertexCounts  // 0xC0
  private           System.Int32[]                  originalFaceVertexIndices  // 0xC8
  private           System.Boolean                  arePrimvarsFaceVarying  // 0xD0
  private           System.Int32[]                  faceMapping  // 0xD8
  private           System.Int32[]                  triangulatedFaceVertexIndices  // 0xE0
  private           System.Boolean                  isRestoredFromCachedData  // 0xE8
METHODS:
  System.Boolean IsRestoredFromCachedData()
  System.Void FromCachedData(USD.NET.IRestorableData restorableData)
  USD.NET.IRestorableData ToCachedData()
  System.Void BackupTopology()
  System.Boolean IsTopologyBackedUp()
  System.Void Sanitize(USD.NET.Scene scene, Unity.Formats.USD.SceneImportOptions importOptions)
  System.Void Triangulate(System.Boolean changeHandedness)
  System.Boolean ShouldUnweldVertices(System.Boolean bindMaterials)
  System.Boolean AreAnyArbitraryPrimvarsFaceVarying()
  System.Void Flatten(T[]& values, System.Int32[] indices)
  System.Void UnweldPrimvar(USD.NET.Primvar<System.Object> primvar, System.Boolean changeHandedness)
  System.Void FlattenPrimvar(USD.NET.Primvar<System.Object> primvar)
  System.Void TriangulateAttributes(T[]& values, System.Int32[] faceVertexCounts, System.Boolean changeHandedness)
  System.Void ConvertInterpolationToFaceVarying(T[]& values, System.Int32[] vertexIndices, System.Boolean changeHandedness, pxr.TfToken interpolation)
  pxr.TfToken GuessInterpolation(System.Int32 count)
  System.Boolean IsInterpolationValid(pxr.TfToken interpolation, System.Int32 count)
  System.Void UniformToFaceVarying(T[]& values, System.Int32 vertexCount)
  System.Void ComputeNormals(UnityEngine.Vector3[] points, System.Int32[] faceVertexIndices, UnityEngine.Vector3[]& normals)
  System.Boolean ShouldUnwindVertices(System.Boolean changeHandedness)
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.ExportHelpers
TYPE:  class
TOKEN: 0x200003C
FIELDS:
METHODS:
  USD.NET.Scene InitForSave(System.String filePath)
  System.Void ExportGameObjects(UnityEngine.GameObject[] objects, USD.NET.Scene scene, Unity.Formats.USD.BasisTransformation basisTransform, System.Boolean exportMonoBehaviours)
END_CLASS

CLASS: Unity.Formats.USD.HierarchyBuilder
TYPE:  class
TOKEN: 0x200003D
FIELDS:
  private   static readonly pxr.SdfPath                     kAbsoluteRootPath  // 0x0
METHODS:
  Unity.Jobs.JobHandle BeginReading(USD.NET.Scene scene, pxr.SdfPath usdRoot, Unity.Formats.USD.PrimMap map, Unity.Formats.USD.SceneImportOptions options)
  Unity.Formats.USD.HierarchyBuilder.HierInfo[] BuildObjectLists(USD.NET.Scene scene, UnityEngine.GameObject unityRoot, pxr.SdfPath usdRoot, Unity.Formats.USD.PrimMap map, Unity.Formats.USD.SceneImportOptions options)
  Unity.Formats.USD.PrimMap BuildGameObjects(USD.NET.Scene scene, UnityEngine.GameObject unityRoot, pxr.SdfPath usdRoot, System.Collections.Generic.IEnumerable<pxr.SdfPath> paths, Unity.Formats.USD.PrimMap map, Unity.Formats.USD.SceneImportOptions options)
  System.Boolean IsVisible(pxr.UsdPrim usdPrim)
  System.Void ApplySelfVisibility(UnityEngine.GameObject go, pxr.UsdPrim usdPrim)
  System.Void CreateAncestors(pxr.SdfPath path, Unity.Formats.USD.PrimMap map, UnityEngine.GameObject unityRoot, pxr.SdfPath usdRoot, Unity.Formats.USD.SceneImportOptions options, UnityEngine.GameObject& parentGo)
  System.Void ProcessPaths(Unity.Formats.USD.HierarchyBuilder.HierInfo[] infos, USD.NET.Scene scene, UnityEngine.GameObject unityRoot, pxr.SdfPath usdRoot, Unity.Formats.USD.PrimMap map, Unity.Formats.USD.SceneImportOptions options)
  System.Void PopulateSkelCache(Unity.Formats.USD.HierarchyBuilder.HierInfo& skelRootInfo, pxr.UsdSkelCache skelCache)
  System.Void ReadSkeletonJoints(Unity.Formats.USD.HierarchyBuilder.HierInfo& skelRootInfo)
  System.Void ExpandSkeleton(Unity.Formats.USD.HierarchyBuilder.HierInfo info, UnityEngine.GameObject unityRoot, pxr.SdfPath usdRoot, pxr.UsdPrim prim, Unity.Formats.USD.PrimMap map, Unity.Formats.USD.SceneImportOptions options)
  System.Void ReadModelInfo(Unity.Formats.USD.HierarchyBuilder.HierInfo& info)
  System.Void AddModelRoot(UnityEngine.GameObject go, Unity.Formats.USD.HierarchyBuilder.HierInfo info)
  System.Void AddPayload(UnityEngine.GameObject go, Unity.Formats.USD.HierarchyBuilder.HierInfo info, Unity.Formats.USD.SceneImportOptions options)
  System.Void AddVariantSet(UnityEngine.GameObject go, pxr.UsdPrim prim)
  UnityEngine.GameObject FindOrCreateGameObject(UnityEngine.Transform parent, pxr.SdfPath path, UnityEngine.Transform unityRoot, Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions options)
  System.Void .cctor()
END_CLASS

CLASS: Unity.Formats.USD.ImportHelpers
TYPE:  class
TOKEN: 0x2000044
FIELDS:
METHODS:
  UnityEngine.GameObject ImportSceneAsGameObject(USD.NET.Scene scene, UnityEngine.GameObject parent, Unity.Formats.USD.SceneImportOptions importOptions)
  USD.NET.Scene InitForOpen(System.String path, pxr.UsdStage.InitialLoadSet loadSet)
  pxr.SdfPath GetDefaultRoot(USD.NET.Scene scene)
  UnityEngine.GameObject UsdToGameObject(UnityEngine.GameObject parent, USD.NET.Scene scene, Unity.Formats.USD.SceneImportOptions importOptions)
  System.String GetObjectName(pxr.SdfPath rootPrimName, System.String path)
  System.String GetObjectName(System.String path)
  System.String GetPrefabName(System.String path)
END_CLASS

CLASS: Unity.Formats.USD.IImportProcessUsd
TYPE:  interface
TOKEN: 0x2000045
FIELDS:
METHODS:
  System.Void ProcessUsd(USD.NET.Scene scene, Unity.Formats.USD.SceneImportOptions sceneImportOptions)
END_CLASS

CLASS: Unity.Formats.USD.IImportPostProcessHierarchy
TYPE:  interface
TOKEN: 0x2000046
FIELDS:
METHODS:
  System.Void PostProcessHierarchy(Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions sceneImportOptions)
END_CLASS

CLASS: Unity.Formats.USD.IImportPostProcessComponents
TYPE:  interface
TOKEN: 0x2000047
FIELDS:
METHODS:
  System.Void PostProcessComponents(Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions sceneImportOptions)
END_CLASS

CLASS: Unity.Formats.USD.PrimMap
TYPE:  class
TOKEN: 0x2000048
FIELDS:
  public            pxr.UsdSkelCache                SkelCache  // 0x10
  public            System.Collections.Generic.Dictionary<pxr.SdfPath,pxr.UsdSkelBindingVector>SkelBindings  // 0x18
  public            System.Collections.Generic.Dictionary<pxr.SdfPath,pxr.UsdSkelSkinningQuery>SkinningQueries  // 0x20
  public            System.Collections.Generic.Dictionary<pxr.SdfPath,Unity.Formats.USD.MeshImporter.GeometrySubsets>MeshSubsets  // 0x28
  private           pxr.SdfPath[]                   <Cameras>k__BackingField  // 0x30
  private           pxr.SdfPath[]                   <Meshes>k__BackingField  // 0x38
  private           pxr.SdfPath[]                   <Cubes>k__BackingField  // 0x40
  private           pxr.SdfPath[]                   <Spheres>k__BackingField  // 0x48
  private           pxr.SdfPath[]                   <Xforms>k__BackingField  // 0x50
  private           pxr.SdfPath[]                   <SkelRoots>k__BackingField  // 0x58
  private           pxr.SdfPath[]                   <Skeletons>k__BackingField  // 0x60
  private           pxr.SdfPath[]                   <Materials>k__BackingField  // 0x68
  private           System.Boolean                  <ContainsPointInstances>k__BackingField  // 0x70
  private           System.Boolean                  <HasErrors>k__BackingField  // 0x71
  private           System.Collections.Generic.Dictionary<pxr.SdfPath,UnityEngine.GameObject>m_prims  // 0x78
  private           System.Collections.Generic.Dictionary<pxr.SdfPath,Unity.Formats.USD.PrimMap.InstanceRoot>m_instanceRoots  // 0x80
  private           System.Collections.Generic.HashSet<UnityEngine.GameObject>m_instances  // 0x88
  private           System.Collections.Generic.Dictionary<pxr.SdfPath,UnityEngine.GameObject>m_masterRoots  // 0x90
METHODS:
  pxr.SdfPath[] get_Cameras()
  System.Void set_Cameras(pxr.SdfPath[] value)
  pxr.SdfPath[] get_Meshes()
  System.Void set_Meshes(pxr.SdfPath[] value)
  pxr.SdfPath[] get_Cubes()
  System.Void set_Cubes(pxr.SdfPath[] value)
  pxr.SdfPath[] get_Spheres()
  System.Void set_Spheres(pxr.SdfPath[] value)
  pxr.SdfPath[] get_Xforms()
  System.Void set_Xforms(pxr.SdfPath[] value)
  pxr.SdfPath[] get_SkelRoots()
  System.Void set_SkelRoots(pxr.SdfPath[] value)
  pxr.SdfPath[] get_Skeletons()
  System.Void set_Skeletons(pxr.SdfPath[] value)
  pxr.SdfPath[] get_Materials()
  System.Void set_Materials(pxr.SdfPath[] value)
  System.Boolean get_ContainsPointInstances()
  System.Void set_ContainsPointInstances(System.Boolean value)
  System.Boolean get_HasErrors()
  System.Void set_HasErrors(System.Boolean value)
  System.Void .ctor()
  UnityEngine.GameObject get_Item(pxr.SdfPath path)
  System.Void set_Item(pxr.SdfPath path, UnityEngine.GameObject value)
  System.Boolean TryGetValue(pxr.SdfPath key, UnityEngine.GameObject& obj)
  System.Collections.IEnumerator GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<pxr.SdfPath,UnityEngine.GameObject>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<pxr.SdfPath,UnityEngine.GameObject>>.GetEnumerator()
  System.Void AddInstance(UnityEngine.GameObject goInst)
  System.Void AddMasterRoot(pxr.SdfPath path, UnityEngine.GameObject go)
  System.Void AddInstanceRoot(pxr.SdfPath instancePath, UnityEngine.GameObject go, pxr.SdfPath masterPath)
  System.Collections.Generic.Dictionary.KeyCollection<pxr.SdfPath,UnityEngine.GameObject> GetMasterRootPaths()
  System.Collections.Generic.Dictionary.ValueCollection<pxr.SdfPath,Unity.Formats.USD.PrimMap.InstanceRoot> GetInstanceRoots()
  System.Void DestroyAll()
  System.Void Clear()
END_CLASS

CLASS: Unity.Formats.USD.ExportFunction
TYPE:  class
TOKEN: 0x200004A
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext)
  System.IAsyncResult BeginInvoke(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: Unity.Formats.USD.ObjectProcessor
TYPE:  class
TOKEN: 0x200004B
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.GameObject go, Unity.Formats.USD.ExportContext context)
  System.IAsyncResult BeginInvoke(UnityEngine.GameObject go, Unity.Formats.USD.ExportContext context, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: Unity.Formats.USD.ObjectContext
TYPE:  struct
TOKEN: 0x200004C
FIELDS:
  public            UnityEngine.GameObject          gameObject  // 0x10
  public            System.String                   path  // 0x18
  public            USD.NET.SampleBase              sample  // 0x20
  public            System.Object                   additionalData  // 0x28
METHODS:
END_CLASS

CLASS: Unity.Formats.USD.ActiveExportPolicy
TYPE:  struct
TOKEN: 0x200004D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.Formats.USD.ActiveExportPolicyExportAsVisibility  // 0x0
  public    static  Unity.Formats.USD.ActiveExportPolicyExportAsActive  // 0x0
  public    static  Unity.Formats.USD.ActiveExportPolicyDoNotExport  // 0x0
  public    static  Unity.Formats.USD.ActiveExportPolicyIgnore  // 0x0
METHODS:
END_CLASS

CLASS: Unity.Formats.USD.ExportContext
TYPE:  class
TOKEN: 0x200004E
FIELDS:
  public            USD.NET.Scene                   scene  // 0x10
  public            UnityEngine.Transform           exportRoot  // 0x18
  public            System.Boolean                  exportMaterials  // 0x20
  public            System.Boolean                  exportNative  // 0x21
  public            System.Single                   scale  // 0x24
  public            System.Boolean                  exportTransformOverrides  // 0x28
  public            Unity.Formats.USD.BasisTransformationbasisTransform  // 0x2C
  public            Unity.Formats.USD.ActiveExportPolicyactivePolicy  // 0x30
  public            System.Collections.Generic.Dictionary<UnityEngine.GameObject,Unity.Formats.USD.ExportPlan>plans  // 0x38
  public            System.Collections.Generic.Dictionary<UnityEngine.Material,System.String>matMap  // 0x40
  public            System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Transform>meshToSkelRoot  // 0x48
  public            System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Transform[]>meshToBones  // 0x50
  public            System.Collections.Generic.Dictionary<UnityEngine.Transform,System.Collections.Generic.List<System.String>>skelSortedMap  // 0x58
  public            System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform>pathToBone  // 0x60
  public            System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Transform>boneToRoot  // 0x68
  public            System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Matrix4x4>bindPoses  // 0x70
  public            System.Collections.Generic.Dictionary<System.Type,USD.NET.SampleBase>samples  // 0x78
  public            System.Diagnostics.Stopwatch    analyticsTotalTimeStopwatch  // 0x80
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.Exporter
TYPE:  class
TOKEN: 0x200004F
FIELDS:
  public            System.String                   path  // 0x10
  public            USD.NET.SampleBase              sample  // 0x18
  public            Unity.Formats.USD.ExportFunctionexportFunc  // 0x20
  public            System.Object                   data  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.ExportPlan
TYPE:  class
TOKEN: 0x2000050
FIELDS:
  public            System.Collections.Generic.List<Unity.Formats.USD.Exporter>exporters  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.SceneExporter
TYPE:  class
TOKEN: 0x2000051
FIELDS:
METHODS:
  System.Void Export(UnityEngine.GameObject root, USD.NET.Scene scene, Unity.Formats.USD.BasisTransformation basisTransform, System.Boolean exportUnvarying, System.Boolean zeroRootTransform, System.Boolean exportMaterials, System.Boolean exportMonoBehaviours, System.Boolean exportOverrides)
  System.Void Export(UnityEngine.GameObject root, Unity.Formats.USD.ExportContext context, System.Boolean zeroRootTransform)
  System.Void ExportImpl(UnityEngine.GameObject root, Unity.Formats.USD.ExportContext context)
  System.Void Traverse(UnityEngine.GameObject obj, Unity.Formats.USD.ObjectProcessor processor, Unity.Formats.USD.ExportContext context)
  System.Void AccumNestedBones(UnityEngine.Transform curXf, System.Collections.Generic.List<UnityEngine.Transform> children, Unity.Formats.USD.ExportContext ctx)
  T CreateSample(Unity.Formats.USD.ExportContext context)
  System.Void SyncExportContext(UnityEngine.GameObject exportRoot, Unity.Formats.USD.ExportContext context)
  System.Void InitExportableObjects(UnityEngine.GameObject go, Unity.Formats.USD.ExportContext context)
  UnityEngine.Transform MergeBonesBelowAnimator(UnityEngine.Transform animator, Unity.Formats.USD.ExportContext context)
  System.Void MergeBonesSimple(UnityEngine.Transform source, UnityEngine.Transform rootBone, UnityEngine.Transform[] bones, UnityEngine.Matrix4x4[] bindPoses, Unity.Formats.USD.ExportContext context)
  System.Void CreateExportPlan(UnityEngine.GameObject go, USD.NET.SampleBase sample, Unity.Formats.USD.ExportFunction exportFunc, Unity.Formats.USD.ExportContext context, System.String pathSuffix, System.Boolean insertFirst)
  UnityEngine.Matrix4x4 ComputeWorldXf(UnityEngine.Transform curBone, Unity.Formats.USD.ExportContext context)
END_CLASS

CLASS: Unity.Formats.USD.IImporter
TYPE:  interface
TOKEN: 0x2000053
FIELDS:
METHODS:
  System.Void BeginReading(USD.NET.Scene scene, Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions importOptions)
  System.Collections.IEnumerator Import(USD.NET.Scene scene, Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions importOptions)
END_CLASS

CLASS: Unity.Formats.USD.SceneImporter
TYPE:  class
TOKEN: 0x2000054
FIELDS:
  public    static  Unity.Formats.USD.IImporter     ActiveMeshImporter  // 0x0
METHODS:
  System.Void .cctor()
  System.Void ImportUsd(UnityEngine.GameObject goRoot, USD.NET.Scene scene, Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions importOptions)
  System.Void ImportUsd(UnityEngine.GameObject goRoot, USD.NET.Scene scene, Unity.Formats.USD.PrimMap primMap, System.Boolean composingSubtree, Unity.Formats.USD.SceneImportOptions importOptions)
  Unity.Formats.USD.UsdEditorAnalytics.ImportResult CreateImportResult(System.Boolean success, Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.ImportType importType)
  Unity.Formats.USD.PrimMap BuildScene(USD.NET.Scene scene, UnityEngine.GameObject root, Unity.Formats.USD.SceneImportOptions importOptions, Unity.Formats.USD.PrimMap primMap, System.Boolean composingSubtree)
  System.Void RemoveComponent(UnityEngine.GameObject go)
  System.Collections.IEnumerator BuildScene(USD.NET.Scene scene, UnityEngine.GameObject root, Unity.Formats.USD.SceneImportOptions importOptions, Unity.Formats.USD.PrimMap primMap, System.Single targetFrameMilliseconds, System.Boolean composingSubtree)
  System.Boolean ShouldYield(System.Single targetTime, System.Diagnostics.Stopwatch timer)
  System.Void ResetTimer(System.Diagnostics.Stopwatch timer)
  System.Boolean IsSkinnedMesh(pxr.UsdPrim prim, Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions importOptions)
END_CLASS

CLASS: Unity.Formats.USD.PayloadPolicy
TYPE:  struct
TOKEN: 0x2000057
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.Formats.USD.PayloadPolicy DontLoadPayloads  // 0x0
  public    static  Unity.Formats.USD.PayloadPolicy LoadAll  // 0x0
METHODS:
END_CLASS

CLASS: Unity.Formats.USD.BasisTransformation
TYPE:  struct
TOKEN: 0x2000058
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.Formats.USD.BasisTransformationFastWithNegativeScale  // 0x0
  public    static  Unity.Formats.USD.BasisTransformationSlowAndSafe  // 0x0
  public    static  Unity.Formats.USD.BasisTransformationSlowAndSafeAsFBX  // 0x0
  public    static  Unity.Formats.USD.BasisTransformationNone  // 0x0
METHODS:
END_CLASS

CLASS: Unity.Formats.USD.MaterialImportMode
TYPE:  struct
TOKEN: 0x2000059
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.Formats.USD.MaterialImportModeImportPreviewSurface  // 0x0
  public    static  Unity.Formats.USD.MaterialImportModeImportDisplayColor  // 0x0
  public    static  Unity.Formats.USD.MaterialImportModeNone  // 0x0
METHODS:
END_CLASS

CLASS: Unity.Formats.USD.SceneImportOptions
TYPE:  class
TOKEN: 0x200005A
FIELDS:
  public            System.String                   projectAssetPath  // 0x10
  public            pxr.SdfPath                     usdRootPath  // 0x18
  public            System.Boolean                  forceRebuild  // 0x20
  public            Unity.Formats.USD.PayloadPolicy payloadPolicy  // 0x24
  public            System.Boolean                  importHierarchy  // 0x28
  public            System.Boolean                  importCameras  // 0x29
  public            System.Boolean                  importMeshes  // 0x2A
  public            System.Boolean                  importSkinning  // 0x2B
  public            System.Boolean                  importSkinWeights  // 0x2C
  public            System.Boolean                  importTransforms  // 0x2D
  public            System.Boolean                  importSceneInstances  // 0x2E
  public            System.Boolean                  importPointInstances  // 0x2F
  public            System.Boolean                  importMonoBehaviours  // 0x30
  public            Unity.Formats.USD.BasisTransformationchangeHandedness  // 0x34
  public            System.Single                   scale  // 0x38
  public            System.Boolean                  interpolate  // 0x3C
  public            System.Boolean                  enableGpuInstancing  // 0x3D
  public            System.Boolean                  useDisplayColorAsFallbackMaterial  // 0x3E
  public            Unity.Formats.USD.MaterialImportModematerialImportMode  // 0x40
  public            Unity.Formats.USD.MaterialMap   materialMap  // 0x48
  public            Unity.Formats.USD.MeshImportOptionsmeshOptions  // 0x50
  private           Unity.Formats.USD.ImportType    <ImportType>k__BackingField  // 0x58
METHODS:
  System.Boolean get_ShouldBindMaterials()
  Unity.Formats.USD.ImportType get_ImportType()
  System.Void set_ImportType(Unity.Formats.USD.ImportType value)
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.UsdzExporter
TYPE:  class
TOKEN: 0x200005B
FIELDS:
METHODS:
  System.Void ExportUsdz(System.String usdzFilePath, UnityEngine.GameObject root)
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.SkeletonExporter
TYPE:  class
TOKEN: 0x200005C
FIELDS:
METHODS:
  System.Void ExportSkeleton(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext)
  System.Void ExportSkelRoot(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext)
  System.Void ExportSkelAnimation(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext)
END_CLASS

CLASS: Unity.Formats.USD.SkeletonImporter
TYPE:  class
TOKEN: 0x200005D
FIELDS:
METHODS:
  System.Void BuildSkeletonBone(System.String skelPath, UnityEngine.GameObject go, UnityEngine.Matrix4x4 restXform, pxr.VtTokenArray joints, Unity.Formats.USD.SceneImportOptions importOptions)
  System.Void BuildDebugBindTransforms(Unity.Formats.USD.SkeletonSample skelSample, UnityEngine.GameObject goSkeleton, Unity.Formats.USD.SceneImportOptions options)
  System.Void BuildBindTransforms(System.String path, Unity.Formats.USD.SkeletonSample skelSample, Unity.Formats.USD.SceneImportOptions options)
  System.Boolean JointsMatch(System.String[] lhs, System.String[] rhs)
  System.Void BuildSkinnedMesh(System.String meshPath, System.String skelPath, Unity.Formats.USD.SkeletonSample skeleton, pxr.UsdSkelSkinningQuery skinningQuery, UnityEngine.GameObject go, Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions options)
END_CLASS

CLASS: Unity.Formats.USD.UnitySkeleton
TYPE:  class
TOKEN: 0x200005E
FIELDS:
  public            UnityEngine.Transform           rootBone  // 0x10
  public            UnityEngine.Transform[]         bones  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.SkelBindingSample
TYPE:  class
TOKEN: 0x200005F
EXTENDS: SampleBase
FIELDS:
  public            System.String[]                 blendShapes  // 0x10
  public            USD.NET.Relationship            blendShapeTargets  // 0x18
  public            USD.NET.Relationship            animationSource  // 0x20
  public            USD.NET.Relationship            skeleton  // 0x28
  public            System.String[]                 joints  // 0x30
  public            USD.NET.Primvar<System.Int32[]> jointIndices  // 0x38
  public            USD.NET.Primvar<UnityEngine.Matrix4x4>geomBindTransform  // 0x40
  public            USD.NET.Primvar<System.Single[]>jointWeights  // 0x48
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.SkelRootSample
TYPE:  class
TOKEN: 0x2000060
EXTENDS: BoundableSample
FIELDS:
  public            USD.NET.Relationship            skeleton  // 0x78
  public            USD.NET.Relationship            animationSource  // 0x80
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.SkeletonSample
TYPE:  class
TOKEN: 0x2000061
EXTENDS: XformableSample
FIELDS:
  public            System.String[]                 joints  // 0x60
  public            UnityEngine.Matrix4x4[]         bindTransforms  // 0x68
  public            UnityEngine.Matrix4x4[]         restTransforms  // 0x70
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.SkelAnimationSample
TYPE:  class
TOKEN: 0x2000062
EXTENDS: SampleBase
FIELDS:
  public            System.String[]                 joints  // 0x10
  public            UnityEngine.Vector3[]           translations  // 0x18
  public            UnityEngine.Quaternion[]        rotations  // 0x20
  public            pxr.VtVec3hArray                scales  // 0x28
  public            System.String[]                 blendShapes  // 0x30
  public            System.Single[]                 blendShapeWeights  // 0x38
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.BlendShapeSample
TYPE:  class
TOKEN: 0x2000063
EXTENDS: SampleBase
FIELDS:
  public            UnityEngine.Vector3[]           offsets  // 0x10
  public            System.UInt32[]                 pointIndices  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.SkeletonIo
TYPE:  class
TOKEN: 0x2000064
FIELDS:
  private           System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Transform[]>m_bindings  // 0x10
METHODS:
  UnityEngine.Transform[] GetBones(UnityEngine.Transform rootBone)
  System.Void RegisterSkeleton(UnityEngine.Transform rootBone, UnityEngine.Transform[] bones)
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.NativeExporter
TYPE:  class
TOKEN: 0x2000065
FIELDS:
METHODS:
  System.Void ExportObject(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext)
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.NativeImporter
TYPE:  class
TOKEN: 0x2000066
FIELDS:
METHODS:
  System.Void ImportObject(USD.NET.Scene scene, UnityEngine.GameObject go, pxr.UsdPrim usdPrim, Unity.Formats.USD.SceneImportOptions options)
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.UsdPlayableAsset
TYPE:  class
TOKEN: 0x2000067
EXTENDS: PlayableAsset
FIELDS:
  private           Unity.Formats.USD.UsdAsset      m_sourceUsdAsset  // 0x18
  public            UnityEngine.ExposedReference<Unity.Formats.USD.UsdAsset>SourceUsdAsset  // 0x20
METHODS:
  UnityEngine.Timeline.ClipCaps get_clipCaps()
  Unity.Formats.USD.UsdAsset GetUsdAsset(System.String usdRootPath)
  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner)
  System.Double get_duration()
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.UsdPlayableBehaviour
TYPE:  class
TOKEN: 0x2000068
EXTENDS: PlayableBehaviour
FIELDS:
  public            Unity.Formats.USD.UsdPlayableAssetplayableAsset  // 0x10
  private           System.Boolean                  m_errorOnce  // 0x18
METHODS:
  System.Void OnGraphStart(UnityEngine.Playables.Playable playable)
  System.Void OnGraphStop(UnityEngine.Playables.Playable playable)
  System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData)
  System.Void PrepareData(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.UsdPlayableTrack
TYPE:  class
TOKEN: 0x2000069
EXTENDS: TrackAsset
FIELDS:
METHODS:
  System.Void OnCreateClip(UnityEngine.Timeline.TimelineClip clip)
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.UsdRecorderBehaviour
TYPE:  class
TOKEN: 0x200006A
EXTENDS: PlayableBehaviour
FIELDS:
  private   static  System.Int32                    kExportFrameRate  // 0x0
  private           System.Boolean                  m_isPaused  // 0x10
  public            Unity.Formats.USD.UsdRecorderClipClip  // 0x18
  private           System.String                   usdcFileName  // 0x20
  private           System.String                   usdzFileName  // 0x28
  private           System.String                   usdzFilePath  // 0x30
  private           System.String                   currentDir  // 0x38
  private           System.IO.DirectoryInfo         usdzTemporaryDir  // 0x40
  private           UnityEngine.GameObject          _root  // 0x48
METHODS:
  System.Void BeginRecording(System.Double currentTime, UnityEngine.GameObject root)
  System.Void StopRecording(System.Double currentTime)
  System.Void ProcessRecording(System.Double currentTime, UnityEngine.GameObject root)
  System.Boolean IsPlaying()
  System.Void OnPlayableCreate(UnityEngine.Playables.Playable playable)
  System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable)
  System.Void OnGraphStart(UnityEngine.Playables.Playable playable)
  System.Void OnGraphStop(UnityEngine.Playables.Playable playable)
  System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData)
  System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void OnFrameEnd(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData)
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.UsdRecorderClip
TYPE:  class
TOKEN: 0x200006C
EXTENDS: PlayableAsset
FIELDS:
  public            UnityEngine.ExposedReference<UnityEngine.GameObject>m_exportRoot  // 0x18
  private           UnityEngine.GameObject[]        m_trackedRoots  // 0x28
  public            System.Boolean                  m_exportMaterials  // 0x30
  public            Unity.Formats.USD.BasisTransformationm_convertHandedness  // 0x34
  public            Unity.Formats.USD.ActiveExportPolicym_activePolicy  // 0x38
  public            System.String                   m_usdFile  // 0x40
  private           USD.NET.Scene                   <UsdScene>k__BackingField  // 0x48
  private           Unity.Formats.USD.ExportContext m_context  // 0x50
METHODS:
  USD.NET.Scene get_UsdScene()
  System.Void set_UsdScene(USD.NET.Scene value)
  Unity.Formats.USD.ExportContext get_Context()
  System.Void set_Context(Unity.Formats.USD.ExportContext value)
  UnityEngine.GameObject GetExportRoot(UnityEngine.Playables.PlayableGraph graph)
  UnityEngine.Timeline.ClipCaps get_clipCaps()
  System.Boolean get_IsUSDZ()
  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner)
  System.Void OnDestroy()
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.UsdRecorderTrack
TYPE:  class
TOKEN: 0x200006D
EXTENDS: TrackAsset
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Formats.USD.UsdWaitForEndOfFrame
TYPE:  class
TOKEN: 0x200006E
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Collections.Generic.List<System.Action>m_pending  // 0x18
  private   static  Unity.Formats.USD.UsdWaitForEndOfFrames_instance  // 0x0
METHODS:
  Unity.Formats.USD.UsdWaitForEndOfFrame GetInstance()
  System.Void Add(System.Action callback)
  System.Collections.IEnumerator WaitForEndOfFrame()
  System.Void LateUpdate()
  System.Void .ctor()
END_CLASS

