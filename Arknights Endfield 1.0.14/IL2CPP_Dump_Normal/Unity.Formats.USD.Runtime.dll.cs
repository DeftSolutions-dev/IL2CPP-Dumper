// ========================================================
// Dumped by @desirepro
// Assembly: Unity.Formats.USD.Runtime.dll
// Classes:  111
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x200001A
    public class GeometrySubsets
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.String,System.Int32[]> <Subsets>k__BackingField;        // 0x10

        // Methods
        private System.Collections.Generic.Dictionary<System.String,System.Int32[]> get_Subsets() { }
        private System.Void set_Subsets(System.Collections.Generic.Dictionary<System.String,System.Int32[]> value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000026
    public class ExportHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(USD.NET.Scene scene, System.String usdShaderPath, UnityEngine.Material material, Unity.Formats.USD.UnityPreviewSurfaceSample surface, System.String destTexturePath) { }
        private System.IAsyncResult BeginInvoke(USD.NET.Scene scene, System.String usdShaderPath, UnityEngine.Material material, Unity.Formats.USD.UnityPreviewSurfaceSample surface, System.String destTexturePath, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000028
    public class TextureResolver : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private UnityEngine.Texture2D Invoke(pxr.SdfAssetPath textureAssetPath, System.Boolean isNormalMap, Unity.Formats.USD.SceneImportOptions importOptions) { }
        private System.IAsyncResult BeginInvoke(pxr.SdfAssetPath textureAssetPath, System.Boolean isNormalMap, Unity.Formats.USD.SceneImportOptions importOptions, System.AsyncCallback callback, System.Object object) { }
        private UnityEngine.Texture2D EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200002A
    public class MaterialBinder : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(USD.NET.Scene scene, UnityEngine.Material mat, System.Collections.Generic.List<System.String> uvPrimvars) { }
        private System.IAsyncResult BeginInvoke(USD.NET.Scene scene, UnityEngine.Material mat, System.Collections.Generic.List<System.String> uvPrimvars, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200002C
    public struct ConversionType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.Formats.USD.ShaderExporterBase.ConversionType None;        // 0x0
        public static Unity.Formats.USD.ShaderExporterBase.ConversionType SwapRASmoothnessToBGRoughness;        // 0x0
        public static Unity.Formats.USD.ShaderExporterBase.ConversionType InvertAlpha;        // 0x0
        public static Unity.Formats.USD.ShaderExporterBase.ConversionType UnpackNormal;        // 0x0
        public static Unity.Formats.USD.ShaderExporterBase.ConversionType MaskMapToORM;        // 0x0
        public static Unity.Formats.USD.ShaderExporterBase.ConversionType RemoveAlpha;        // 0x0

    }

    // TypeToken: 0x2000030
    public struct StandardShaderBlendMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.Formats.USD.StandardShaderExporter.StandardShaderBlendMode Opaque;        // 0x0
        public static Unity.Formats.USD.StandardShaderExporter.StandardShaderBlendMode Cutout;        // 0x0
        public static Unity.Formats.USD.StandardShaderExporter.StandardShaderBlendMode Fade;        // 0x0
        public static Unity.Formats.USD.StandardShaderExporter.StandardShaderBlendMode Transparent;        // 0x0

    }

    // TypeToken: 0x200003E
    public struct HierInfo
    {
        // Fields
        public System.Boolean isVisible;        // 0x10
        public System.Boolean isInstance;        // 0x11
        public System.Boolean isAssembly;        // 0x12
        public System.Boolean isModel;        // 0x13
        public System.Boolean hasPayload;        // 0x14
        public pxr.UsdPrim prim;        // 0x18
        public pxr.UsdSkelBindingVector skelBindings;        // 0x20
        public pxr.SdfPath[] skelJoints;        // 0x28
        public System.String modelAssetPath;        // 0x30
        public System.String modelName;        // 0x38
        public System.String modelVersion;        // 0x40

    }

    // TypeToken: 0x200003F
    public struct ReadHierJob, IJobParallelFor
    {
        // Fields
        public static Unity.Formats.USD.HierarchyBuilder.HierInfo[] result;        // 0x0
        public static USD.NET.Scene scene;        // 0x8
        public static pxr.UsdSkelCache skelCache;        // 0x10
        public static pxr.SdfPath[] paths;        // 0x18

        // Methods
        private System.Void Run() { }
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x2000041
    public interface IQuery
    {
        // Methods
        private pxr.SdfPath[] Find(USD.NET.Scene scene, pxr.SdfPath usdRoot) { }

    }

    // TypeToken: 0x2000042
    public struct Query`1, IQuery
    {
        // Methods
        private pxr.SdfPath[] Find(USD.NET.Scene scene, pxr.SdfPath usdRoot) { }

    }

    // TypeToken: 0x2000040
    public struct FindPathsJob, IJobParallelFor
    {
        // Fields
        public static pxr.SdfPath usdRoot;        // 0x0
        public static USD.NET.Scene scene;        // 0x8
        public static pxr.SdfPath[][] results;        // 0x10
        public static Unity.Formats.USD.HierarchyBuilder.FindPathsJob.IQuery[] queries;        // 0x18

        // Methods
        private System.Void Run() { }
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x2000049
    public struct InstanceRoot
    {
        // Fields
        public UnityEngine.GameObject gameObject;        // 0x10
        public pxr.SdfPath masterPath;        // 0x18

    }

    // TypeToken: 0x2000055
    public class ImportException : Exception
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String message) { }
        private System.Void .ctor(System.String message, System.Exception innerException) { }

    }

namespace Beyond.SourceGenerator
{

    // TypeToken: 0x2000003
    public class CameraControlConfigAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000004
    public class ECSComponentAttribute : Attribute
    {
        // Fields
        public System.Runtime.InteropServices.LayoutKind layoutKind;        // 0x10
        public System.Boolean isTag;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

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

namespace Unity.Formats.USD
{

    // TypeToken: 0x2000007
    public class UsdAssemblyRoot : MonoBehaviour
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000008
    public class UsdAsset : MonoBehaviour
    {
        // Fields
        private System.String m_usdFile;        // 0x18
        public System.String m_projectAssetPath;        // 0x20
        public System.String m_usdRootPath;        // 0x28
        public System.Single m_usdTimeOffset;        // 0x30
        public Unity.Formats.USD.PayloadPolicy m_payloadPolicy;        // 0x34
        public System.Boolean m_importHierarchy;        // 0x38
        public System.Single m_scale;        // 0x3C
        public Unity.Formats.USD.BasisTransformation m_changeHandedness;        // 0x40
        public USD.NET.Scene.InterpolationMode m_interpolation;        // 0x44
        public System.Boolean m_useOriginalShaderIfAvailable;        // 0x48
        public UnityEngine.Material m_displayColorMaterial;        // 0x50
        public UnityEngine.Material m_specularWorkflowMaterial;        // 0x58
        public UnityEngine.Material m_metallicWorkflowMaterial;        // 0x60
        public System.Boolean m_enableGpuInstancing;        // 0x68
        public Unity.Formats.USD.ImportMode m_points;        // 0x6C
        public Unity.Formats.USD.ImportMode m_topology;        // 0x70
        public Unity.Formats.USD.ImportMode m_boundingBox;        // 0x74
        public Unity.Formats.USD.ImportMode m_color;        // 0x78
        public Unity.Formats.USD.ImportMode m_normals;        // 0x7C
        public Unity.Formats.USD.ImportMode m_tangents;        // 0x80
        public System.Boolean m_generateLightmapUVs;        // 0x84
        public System.Single m_unwrapAngleError;        // 0x88
        public System.Single m_unwrapAreaError;        // 0x8C
        public System.Single m_unwrapHardAngle;        // 0x90
        public System.Int32 m_unwrapPackMargin;        // 0x94
        public Unity.Formats.USD.MaterialImportMode m_materialImportMode;        // 0x98
        public System.Boolean m_importCameras;        // 0x9C
        public System.Boolean m_importMeshes;        // 0x9D
        public System.Boolean m_importSkinning;        // 0x9E
        public System.Boolean m_importTransforms;        // 0x9F
        public System.Boolean m_importSceneInstances;        // 0xA0
        public System.Boolean m_importPointInstances;        // 0xA1
        public System.Boolean m_importMonoBehaviors;        // 0xA2
        public System.Boolean m_debugShowSkeletonBindPose;        // 0xA3
        public System.Boolean m_debugShowSkeletonRestPose;        // 0xA4
        public System.Boolean m_debugPrintVariabilityCache;        // 0xA5
        public System.Boolean m_usdVariabilityCache;        // 0xA6
        public Unity.Formats.USD.BasisTransformation LastHandedness;        // 0xA8
        public System.Single LastScale;        // 0xAC
        private System.Single m_lastTime;        // 0xB0
        private USD.NET.Scene m_lastScene;        // 0xB8
        private Unity.Formats.USD.PrimMap m_lastPrimMap;        // 0xC0
        private USD.NET.AccessMask m_lastAccessMask;        // 0xC8

        // Methods
        private System.Double get_Length() { }
        private System.String get_usdFullPath() { }
        private System.Void set_usdFullPath(System.String value) { }
        private System.Void OnDestroy() { }
        private System.String GetPrefabAssetPath(UnityEngine.GameObject root) { }
        private System.Void OptionsToState(Unity.Formats.USD.SceneImportOptions options) { }
        private System.Void StateToOptions(Unity.Formats.USD.SceneImportOptions& options) { }
        private System.Boolean SceneFileChanged() { }
        private USD.NET.Scene GetScene() { }
        private System.Void OnReload() { }
        private System.Void DestroyComponent(UnityEngine.Component comp) { }
        private System.Void ClearLastData() { }
        private System.Void RemoveAllUsdComponents() { }
        private System.Void DestroyAllImportedObjects() { }
        private System.Void Reload(System.Boolean forceRebuild) { }
        private pxr.UsdPrim GetFirstPrim(USD.NET.Scene scene) { }
        private System.Void ExportOverrides(USD.NET.Scene sceneInWhichToStoreTransforms) { }
        private System.Double ComputeLength() { }
        private System.Void SetTime(System.Double time, Unity.Formats.USD.UsdAsset foreignRoot, System.Boolean saveMeshUpdates) { }
        private System.Void Update() { }
        private System.Void PrepOptionsForTimeChange(Unity.Formats.USD.SceneImportOptions& options) { }
        private System.Void ImportUsdAsCoroutine(UnityEngine.GameObject goRoot, System.String usdFilePath, System.Double time, Unity.Formats.USD.SceneImportOptions importOptions, System.Single targetFrameMilliseconds) { }
        private System.Void SetPayloadState(UnityEngine.GameObject go, System.Boolean isLoaded) { }
        private System.Void ApplyVariantSelectionState(USD.NET.Scene scene, Unity.Formats.USD.UsdVariantSet variants) { }
        private System.Void SetVariantSelection(UnityEngine.GameObject go, System.String usdPrimPath, System.Collections.Generic.Dictionary<System.String,System.String> selections) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000009
    public class UsdLayerStack : MonoBehaviour
    {
        // Fields
        public System.String m_targetLayer;        // 0x18
        public System.String[] m_layerStack;        // 0x20
        public System.String[] m_mutedLayers;        // 0x28

        // Methods
        private System.Void SetupNewSubLayer(USD.NET.Scene parentScene, USD.NET.Scene subLayerScene) { }
        private System.Void SaveLayerStack(USD.NET.Scene scene, System.String[] layerStack) { }
        private System.Void SaveToLayer() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000A
    public class UsdModelRoot : MonoBehaviour
    {
        // Fields
        public System.String m_modelName;        // 0x18
        public System.String m_modelVersion;        // 0x20
        public System.String m_modelAssetPath;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000B
    public class UsdPayload : MonoBehaviour
    {
        // Fields
        private System.Boolean m_isLoaded;        // 0x18
        private System.Boolean m_wasLoaded;        // 0x19

        // Methods
        private System.Boolean get_IsLoaded() { }
        private System.Void Load() { }
        private System.Void Unload() { }
        private System.Void SetInitialState(System.Boolean loaded) { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000C
    public class UsdPrimSource : MonoBehaviour
    {
        // Fields
        public System.String m_usdPrimPath;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000D
    public class UsdVariantSet : MonoBehaviour
    {
        // Fields
        public System.String[] m_variantSetNames;        // 0x18
        public System.String[] m_selected;        // 0x20
        public System.String[] m_variants;        // 0x28
        public System.Int32[] m_variantCounts;        // 0x30
        public System.String m_primPath;        // 0x38

        // Methods
        private System.Void LoadFromUsd(pxr.UsdPrim prim) { }
        private System.Void ApplyVariantSelections() { }
        private System.Collections.Generic.Dictionary<System.String,System.String> GetVariantSelections() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000F
    public class SkinnedMeshUnityDiff : MonoBehaviour
    {
        // Fields
        public UnityEngine.SkinnedMeshRenderer m_usdMesh;        // 0x18
        public UnityEngine.SkinnedMeshRenderer m_unityMesh;        // 0x20

        // Methods
        private System.Void OnEnable() { }
        private System.Boolean Approximately(UnityEngine.Matrix4x4 rhs, UnityEngine.Matrix4x4 lhs) { }
        private System.Boolean WeightsMatch(UnityEngine.BoneWeight w1, UnityEngine.BoneWeight w2) { }
        private System.Boolean IndicesMatch(UnityEngine.BoneWeight w1, UnityEngine.BoneWeight w2) { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000010
    public class SkinnedMeshUsdDiff : MonoBehaviour
    {
        // Fields
        public System.String m_usdFile;        // 0x18
        public System.String m_usdMeshPath;        // 0x20
        public Unity.Formats.USD.BasisTransformation m_basisTransform;        // 0x28

        // Methods
        private System.Void OnEnable() { }
        private System.String GetUsdBoneData(System.Int32 bone, System.Int32 weightIndex, USD.NET.Primvar<T[]> primvar) { }
        private USD.NET.Scene GetScene() { }
        private Unity.Formats.USD.SkelBindingSample ReadUsdWeights(USD.NET.Scene scene) { }
        private Unity.Formats.USD.SkeletonSample ReadUsdSkeleton(USD.NET.Scene scene, System.String& skelRootPath) { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000011
    public class CameraExporter
    {
        // Methods
        private System.Void ExportCamera(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext) { }

    }

    // TypeToken: 0x2000012
    public class CameraImporter
    {
        // Methods
        private System.Void BuildCamera(USD.NET.Unity.CameraSample usdCamera, UnityEngine.GameObject go, Unity.Formats.USD.SceneImportOptions options) { }

    }

    // TypeToken: 0x2000013
    public class CubeImporter
    {
        // Methods
        private System.Void BuildCube(USD.NET.Unity.CubeSample usdCube, UnityEngine.GameObject go, Unity.Formats.USD.SceneImportOptions options, System.Boolean skinnedMesh) { }
        private System.Boolean ShouldImport(Unity.Formats.USD.ImportMode mode) { }
        private System.Boolean ShouldCompute(Unity.Formats.USD.ImportMode mode) { }

    }

    // TypeToken: 0x2000014
    public class InstanceImporter
    {
        // Methods
        private System.Void BuildSceneInstances(Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions options) { }
        private System.Void BuildPointInstances(USD.NET.Scene scene, Unity.Formats.USD.PrimMap primMap, System.String pointInstancerPath, USD.NET.Unity.PointInstancerSample sample, UnityEngine.GameObject root, Unity.Formats.USD.SceneImportOptions options) { }
        private System.Void EnableGpuInstancing(UnityEngine.GameObject go) { }

    }

    // TypeToken: 0x2000015
    public class MeshExporter
    {
        // Fields
        private static pxr.TfToken m_materialBindToken;        // 0x0
        private static pxr.TfToken m_subMeshesToken;        // 0x8

        // Methods
        private System.Void ExportSkinnedMesh(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext) { }
        private System.Void ExportSkelWeights(USD.NET.Scene scene, System.String path, UnityEngine.Mesh unityMesh, UnityEngine.Transform rootBone, UnityEngine.Transform[] bones, System.String skeletonPath) { }
        private System.Void ExportMesh(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext) { }
        private System.Void ExportMesh(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext, UnityEngine.Mesh mesh, UnityEngine.Material sharedMaterial, UnityEngine.Material[] sharedMaterials, System.Boolean exportMeshPose) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000016
    public class MeshImportFunction`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.String path, T sample, Unity.Formats.USD.MeshImporter.GeometrySubsets subsets, UnityEngine.GameObject go, Unity.Formats.USD.SceneImportOptions option, System.Boolean isDynamic, pxr.UsdSkelSkinningQuery query) { }
        private System.IAsyncResult BeginInvoke(System.String path, T sample, Unity.Formats.USD.MeshImporter.GeometrySubsets subsets, UnityEngine.GameObject go, Unity.Formats.USD.SceneImportOptions option, System.Boolean isDynamic, pxr.UsdSkelSkinningQuery query, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000017
    public class MeshImportStrategy, IImporter
    {
        // Fields
        private Unity.Formats.USD.MeshImportFunction<Unity.Formats.USD.SanitizedMeshSample> m_meshImporter;        // 0x10
        private Unity.Formats.USD.MeshImportFunction<Unity.Formats.USD.SanitizedMeshSample> m_skinnedMeshImporter;        // 0x18
        private Unity.Formats.USD.ReadAllJob<Unity.Formats.USD.SanitizedMeshSample> m_readMeshesJob;        // 0x20

        // Methods
        private System.Void .ctor(Unity.Formats.USD.MeshImportFunction<Unity.Formats.USD.SanitizedMeshSample> meshImporter, Unity.Formats.USD.MeshImportFunction<Unity.Formats.USD.SanitizedMeshSample> skinnedMeshImporter) { }
        private System.Void BeginReading(USD.NET.Scene scene, Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions importOptions) { }
        private System.Collections.IEnumerator Import(USD.NET.Scene scene, Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions importOptions) { }

    }

    // TypeToken: 0x2000019
    public class MeshImporter
    {
        // Methods
        private Unity.Formats.USD.MeshImporter.GeometrySubsets ReadGeomSubsets(USD.NET.Scene scene, System.String path) { }
        private System.Void BuildSkinnedMesh(System.String path, Unity.Formats.USD.SanitizedMeshSample usdMesh, Unity.Formats.USD.MeshImporter.GeometrySubsets geomSubsets, UnityEngine.GameObject go, Unity.Formats.USD.SceneImportOptions options, System.Boolean isDynamic, pxr.UsdSkelSkinningQuery skinningQuery) { }
        private System.Void ImportSkinning(System.String path, Unity.Formats.USD.SanitizedMeshSample usdMesh, UnityEngine.Mesh unityMesh, pxr.UsdSkelSkinningQuery skinningQuery) { }
        private System.Void BuildMesh(System.String path, Unity.Formats.USD.SanitizedMeshSample usdMesh, Unity.Formats.USD.MeshImporter.GeometrySubsets geomSubsets, UnityEngine.GameObject go, Unity.Formats.USD.SceneImportOptions options, System.Boolean isDynamic, pxr.UsdSkelSkinningQuery skinQuery) { }
        private System.Void BuildMesh_(System.String path, Unity.Formats.USD.SanitizedMeshSample usdMesh, UnityEngine.Mesh unityMesh, Unity.Formats.USD.MeshImporter.GeometrySubsets geomSubsets, UnityEngine.GameObject go, UnityEngine.Renderer renderer, Unity.Formats.USD.SceneImportOptions options) { }
        private System.Void LoadPrimvars(UnityEngine.Mesh unityMesh, System.String usdMeshPath, System.Collections.Generic.List<System.String> primvars, USD.NET.Unity.MeshSample sample) { }
        private System.Void BindMat(UnityEngine.Mesh unityMesh, UnityEngine.Material mat, UnityEngine.Renderer renderer, System.String usdMeshPath, System.Collections.Generic.List<System.String> primvars, USD.NET.Unity.MeshSample sample) { }
        private System.Void BindMat(UnityEngine.Mesh unityMesh, UnityEngine.Material mat, UnityEngine.Renderer renderer, System.Int32 index, System.String usdMeshPath, System.Collections.Generic.List<System.String> primvars, USD.NET.Unity.MeshSample sample) { }
        private T[] TryGetPrimvarValue(USD.NET.Primvar<System.Object> primvar) { }
        private System.Void ImportUv(UnityEngine.Mesh unityMesh, System.Int32 uvSetIndex, USD.NET.Primvar<System.Object> uv) { }
        private System.Boolean ShouldImport(Unity.Formats.USD.ImportMode mode) { }
        private System.Boolean ShouldCompute(Unity.Formats.USD.ImportMode mode) { }
        private System.String UniqueMeshName(System.String meshName) { }

    }

    // TypeToken: 0x200001D
    public struct ImportMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.Formats.USD.ImportMode Import;        // 0x0
        public static Unity.Formats.USD.ImportMode ImportOrCompute;        // 0x0
        public static Unity.Formats.USD.ImportMode Compute;        // 0x0
        public static Unity.Formats.USD.ImportMode Ignore;        // 0x0

    }

    // TypeToken: 0x200001E
    public class MeshImportOptions
    {
        // Fields
        public System.Boolean debugShowSkeletonRestPose;        // 0x10
        public System.Boolean debugShowSkeletonBindPose;        // 0x11
        public Unity.Formats.USD.ImportMode points;        // 0x14
        public Unity.Formats.USD.ImportMode topology;        // 0x18
        public System.Boolean triangulateMesh;        // 0x1C
        public System.Boolean generateLightmapUVs;        // 0x1D
        public System.Single unwrapAngleError;        // 0x20
        public System.Single unwrapAreaError;        // 0x24
        public System.Single unwrapHardAngle;        // 0x28
        public System.Int32 unwrapPackMargin;        // 0x2C
        public Unity.Formats.USD.ImportMode color;        // 0x30
        public Unity.Formats.USD.ImportMode normals;        // 0x34
        public Unity.Formats.USD.ImportMode tangents;        // 0x38
        public Unity.Formats.USD.ImportMode boundingBox;        // 0x3C

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001F
    public class SphereImporter
    {
        // Methods
        private System.Void BuildSphere(USD.NET.Unity.SphereSample usdSphere, UnityEngine.GameObject go, Unity.Formats.USD.SceneImportOptions options, System.Boolean skinnedMesh) { }
        private System.Boolean ShouldImport(Unity.Formats.USD.ImportMode mode) { }
        private System.Boolean ShouldCompute(Unity.Formats.USD.ImportMode mode) { }

    }

    // TypeToken: 0x2000020
    public class XformExporter
    {
        // Methods
        private System.Void ExportXform(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext) { }
        private System.Void WriteSparseOverrides(USD.NET.Scene scene, Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.BasisTransformation changeHandedness, System.Single tolerance) { }
        private UnityEngine.Matrix4x4 GetLocalTransformMatrix(UnityEngine.Transform tr, System.Boolean correctZUp, System.Boolean isRootPrim, Unity.Formats.USD.BasisTransformation conversionType) { }

    }

    // TypeToken: 0x2000021
    public class XformImporter
    {
        // Methods
        private System.Void BuildXform(pxr.SdfPath path, USD.NET.Unity.XformableSample usdXf, UnityEngine.GameObject go, Unity.Formats.USD.SceneImportOptions options, USD.NET.Scene scene) { }
        private System.Void BuildXform(UnityEngine.Matrix4x4 xf, UnityEngine.GameObject go, Unity.Formats.USD.SceneImportOptions options) { }
        private System.Void ImportXform(UnityEngine.Matrix4x4& mat, Unity.Formats.USD.SceneImportOptions options) { }
        private System.Void BuildSceneRoot(USD.NET.Scene scene, UnityEngine.Transform root, Unity.Formats.USD.SceneImportOptions options) { }
        private System.Void UndoRootTransform(USD.NET.Scene scene, Unity.Formats.USD.UsdAsset stageRoot, UnityEngine.Vector3& localScale, UnityEngine.Quaternion& localRotation) { }

    }

    // TypeToken: 0x2000022
    public class ImporterBase
    {
        // Methods
        private System.String MakeRelativePath(System.String anchorPath, System.String pathToMakeRelative) { }
        private System.Boolean ApproximatelyEqual(UnityEngine.Matrix4x4 lhs, UnityEngine.Matrix4x4 rhs) { }
        private System.Void MoveComponentFirst(UnityEngine.Component comp) { }
        private System.Void MoveComponentLast(UnityEngine.Component comp) { }
        private T GetOrAddComponent(UnityEngine.GameObject go, System.Boolean insertFirst) { }
        private System.String SafeGetDirectoryName(System.String fullPath) { }

    }

    // TypeToken: 0x2000023
    public class HdrpShaderExporter : ShaderExporterBase
    {
        // Methods
        private System.Void ExportLit(USD.NET.Scene scene, System.String usdShaderPath, UnityEngine.Material material, USD.NET.Unity.PreviewSurfaceSample surface, System.String destTexturePath) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000024
    public class HdrpShaderImporter : ShaderImporterBase
    {
        // Fields
        private static UnityEngine.Material ChannelCombinerMat;        // 0x0

        // Methods
        private System.Void .ctor(UnityEngine.Material material) { }
        private System.Void ImportFromUsd() { }
        private UnityEngine.Texture2D BuildMaskMap(UnityEngine.Texture2D red, UnityEngine.Texture2D green, UnityEngine.Texture2D blue, UnityEngine.Texture2D alpha) { }

    }

    // TypeToken: 0x2000025
    public class MaterialExporter
    {
        // Fields
        public static readonly System.String kStandardFallbackHandler;        // 0x0
        public static readonly System.String kHdrpFallbackHandler;        // 0x8
        public static readonly System.String kLwrpFallbackHandler;        // 0x10
        public static System.Collections.Generic.Dictionary<System.String,Unity.Formats.USD.MaterialExporter.ExportHandler> ExportRegistry;        // 0x18

        // Methods
        private System.Void .cctor() { }
        private System.Void ExportMaterial(USD.NET.Scene scene, UnityEngine.Material mat, System.String usdMaterialPath) { }

    }

    // TypeToken: 0x2000027
    public class MaterialImporter
    {
        // Fields
        private static readonly pxr.TfToken materialBindToken;        // 0x0
        private static UnityEngine.Material AlbedoGlossCombiner;        // 0x8
        public static Unity.Formats.USD.MaterialImporter.TextureResolver OnResolveTexture;        // 0x10

        // Methods
        private System.Void ProcessMaterialBindings(USD.NET.Scene scene, Unity.Formats.USD.SceneImportOptions importOptions) { }
        private UnityEngine.Material BuildMaterial(USD.NET.Scene scene, System.String materialPath, USD.NET.Unity.MaterialSample sample, Unity.Formats.USD.SceneImportOptions options) { }
        private UnityEngine.Texture2D ImportConnectedTexture(USD.NET.Scene scene, USD.NET.Connectable<T> connection, System.Boolean isNormalMap, Unity.Formats.USD.SceneImportOptions options, System.String& uvPrimvar) { }
        private UnityEngine.Texture2D DefaultTextureResolver(pxr.SdfAssetPath textureAssetPath, System.Boolean isNormalMap, Unity.Formats.USD.SceneImportOptions options) { }
        private UnityEngine.Texture2D CombineRoughness(UnityEngine.Texture2D rgbTex, UnityEngine.Texture2D roughnessTex, System.String fileNameSuffix) { }
        private Unity.Formats.USD.UnityPreviewSurfaceSample GetSurfaceShaderPrim(USD.NET.Scene scene, System.String primPath) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000029
    public class MaterialMap, IEnumerable`1, IEnumerable
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.String,UnityEngine.Material> m_map;        // 0x10
        private System.Collections.Generic.Dictionary<UnityEngine.Color,UnityEngine.Material> m_colorMap;        // 0x18
        private System.Collections.Generic.Dictionary<System.String,Unity.Formats.USD.MaterialMap.MaterialBinder> m_requestedBindings;        // 0x20
        private System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<System.String>> m_primvars;        // 0x28
        public System.Boolean useOriginalShaderIfAvailable;        // 0x30
        private UnityEngine.Material m_displayColorMaterial;        // 0x38
        private UnityEngine.Material m_specularWorkflowMaterial;        // 0x40
        private UnityEngine.Material m_metallicWorkflowMaterial;        // 0x48

        // Methods
        private UnityEngine.Material get_DisplayColorMaterial() { }
        private System.Void set_DisplayColorMaterial(UnityEngine.Material value) { }
        private UnityEngine.Material get_SpecularWorkflowMaterial() { }
        private System.Void set_SpecularWorkflowMaterial(UnityEngine.Material value) { }
        private UnityEngine.Material get_MetallicWorkflowMaterial() { }
        private System.Void set_MetallicWorkflowMaterial(UnityEngine.Material value) { }
        private System.Void InstantiateMaterials() { }
        private System.Collections.Generic.Dictionary<System.String,Unity.Formats.USD.MaterialMap.MaterialBinder> ClearRequestedBindings() { }
        private System.Void RequestBinding(System.String usdPath, Unity.Formats.USD.MaterialMap.MaterialBinder binder) { }
        private UnityEngine.Material get_Item(System.String path) { }
        private System.Void set_Item(System.String path, UnityEngine.Material value) { }
        private System.Collections.Generic.List<System.String> GetPrimvars(System.String materialPath) { }
        private System.Void SetPrimvars(System.String materialPath, System.Collections.Generic.List<System.String> primvars) { }
        private UnityEngine.Material InstantiateSolidColor(UnityEngine.Color color) { }
        private System.Void AssignColor(UnityEngine.Material material, UnityEngine.Color color) { }
        private System.Collections.IEnumerator GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Material>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Material>>.GetEnumerator() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002B
    public class ShaderExporterBase
    {
        // Fields
        private static UnityEngine.Material _metalGlossChannelSwapMaterial;        // 0x0
        private static UnityEngine.Material _normalChannelMaterial;        // 0x8

        // Methods
        private System.String SetupTexture(USD.NET.Scene scene, System.String usdShaderPath, UnityEngine.Material material, USD.NET.Unity.PreviewSurfaceSample surface, UnityEngine.Vector4 scale, System.String destTexturePath, System.String textureName, System.String textureOutput, Unity.Formats.USD.ShaderExporterBase.ConversionType conversionType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002D
    public class ShaderImporterBase
    {
        // Fields
        private UnityEngine.Material <Material>k__BackingField;        // 0x10
        private System.Boolean <IsSpecularWorkflow>k__BackingField;        // 0x18
        public System.Nullable<UnityEngine.Color> Diffuse;        // 0x1C
        public UnityEngine.Texture2D DiffuseMap;        // 0x30
        public System.Nullable<UnityEngine.Color> Specular;        // 0x38
        public UnityEngine.Texture2D SpecularMap;        // 0x50
        public System.Nullable<UnityEngine.Vector3> Normal;        // 0x58
        public UnityEngine.Texture2D NormalMap;        // 0x68
        public System.Nullable<System.Single> Displacement;        // 0x70
        public UnityEngine.Texture2D DisplacementMap;        // 0x78
        public System.Nullable<System.Single> Occlusion;        // 0x80
        public UnityEngine.Texture2D OcclusionMap;        // 0x88
        public System.Nullable<UnityEngine.Color> Emission;        // 0x90
        public UnityEngine.Texture2D EmissionMap;        // 0xA8
        public System.Nullable<System.Single> Roughness;        // 0xB0
        public UnityEngine.Texture2D RoughnessMap;        // 0xB8
        public System.Nullable<System.Single> Metallic;        // 0xC0
        public UnityEngine.Texture2D MetallicMap;        // 0xC8
        public System.Nullable<System.Single> Clearcoat;        // 0xD0
        public UnityEngine.Texture2D ClearcoatMap;        // 0xD8
        public System.Nullable<System.Single> ClearcoatRoughness;        // 0xE0
        public System.Nullable<System.Single> OpacityThreshold;        // 0xE8
        public System.Nullable<System.Single> Opacity;        // 0xF0
        public UnityEngine.Texture2D OpacityMap;        // 0xF8

        // Methods
        private UnityEngine.Material get_Material() { }
        private System.Void set_Material(UnityEngine.Material value) { }
        private System.Boolean get_IsSpecularWorkflow() { }
        private System.Void set_IsSpecularWorkflow(System.Boolean value) { }
        private System.Void .ctor(UnityEngine.Material material) { }
        private System.Void ImportFromUsd() { }
        private System.Void ImportColorOrMap(USD.NET.Scene scene, USD.NET.Connectable<UnityEngine.Vector3> usdParam, System.Boolean isNormalMap, Unity.Formats.USD.SceneImportOptions options, UnityEngine.Texture2D& map, System.Nullable<UnityEngine.Color>& value, System.String& uvPrimvar) { }
        private System.Void ImportValueOrMap(USD.NET.Scene scene, USD.NET.Connectable<T> usdParam, System.Boolean isNormalMap, Unity.Formats.USD.SceneImportOptions options, UnityEngine.Texture2D& map, System.Nullable<T>& value, System.String& uvPrimvar) { }
        private System.Void MergePrimvars(System.String newPrimvar, System.Collections.Generic.List<System.String> primvars) { }
        private System.Void ImportParametersFromUsd(USD.NET.Scene scene, System.String materialPath, USD.NET.Unity.MaterialSample materialSample, USD.NET.Unity.PreviewSurfaceSample previewSurf, Unity.Formats.USD.SceneImportOptions options) { }

    }

    // TypeToken: 0x200002F
    public class StandardShaderExporter : ShaderExporterBase
    {
        // Methods
        private System.Void ExportStandardSpecular(USD.NET.Scene scene, System.String usdShaderPath, UnityEngine.Material material, Unity.Formats.USD.UnityPreviewSurfaceSample surface, System.String destTexturePath) { }
        private System.Void ExportStandardRoughness(USD.NET.Scene scene, System.String usdShaderPath, UnityEngine.Material material, Unity.Formats.USD.UnityPreviewSurfaceSample surface, System.String destTexturePath) { }
        private System.Void ExportStandard(USD.NET.Scene scene, System.String usdShaderPath, UnityEngine.Material material, Unity.Formats.USD.UnityPreviewSurfaceSample surface, System.String destTexturePath) { }
        private System.Void ExportGeneric(USD.NET.Scene scene, System.String usdShaderPath, UnityEngine.Material material, Unity.Formats.USD.UnityPreviewSurfaceSample surface, System.String destTexturePath) { }
        private System.Void ExportStandardCommon(USD.NET.Scene scene, System.String usdShaderPath, UnityEngine.Material mat, Unity.Formats.USD.UnityPreviewSurfaceSample surface, System.String destTexturePath) { }
        private System.Boolean ShouldUseSpecularWorkflow(UnityEngine.Material material) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000031
    public class StandardShaderImporter : ShaderImporterBase
    {
        // Methods
        private System.Void .ctor(UnityEngine.Material material) { }
        private System.Void ImportFromUsd() { }

    }

    // TypeToken: 0x2000032
    public class UnityMaterialData : SampleBase
    {
        // Fields
        public System.String shaderName;        // 0x10
        public System.String[] shaderKeywords;        // 0x18
        public System.Collections.Generic.Dictionary<System.String,System.Single> floatArgs;        // 0x20
        public System.Collections.Generic.Dictionary<System.String,UnityEngine.Color> colorArgs;        // 0x28
        public System.Collections.Generic.Dictionary<System.String,UnityEngine.Vector4> vectorArgs;        // 0x30

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000033
    public class UnityPreviewSurfaceSample : PreviewSurfaceSample
    {
        // Fields
        public Unity.Formats.USD.UnityMaterialData unity;        // 0x90

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000034
    public class UrpShaderImporter : ShaderImporterBase
    {
        // Methods
        private System.Void .ctor(UnityEngine.Material material) { }
        private System.Void ImportFromUsd() { }

    }

    // TypeToken: 0x2000035
    public struct ReadAllJob`1, IEnumerator`1, IEnumerator, IDisposable, IEnumerable`1, IEnumerable, IJobParallelFor
    {
        // Fields
        private static USD.NET.Scene m_scene;        // 0x0
        private static pxr.SdfPath[] m_paths;        // 0x0
        private static T[] m_results;        // 0x0
        private static System.Object[] m_done;        // 0x0
        private static USD.NET.SampleEnumerator.SampleHolder<T> m_current;        // 0x0
        private static System.Threading.AutoResetEvent m_ready;        // 0x0
        private static Unity.Formats.USD.SceneImportOptions m_importOptions;        // 0x0

        // Methods
        private USD.NET.SampleEnumerator.SampleHolder<T> get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void .ctor(USD.NET.Scene scene, pxr.SdfPath[] paths, Unity.Formats.USD.SceneImportOptions importOptions) { }
        private System.Boolean ShouldReadPath(USD.NET.Scene scene, pxr.SdfPath path) { }
        private System.Void Run() { }
        private System.Void Execute(System.Int32 index) { }
        private System.Void AddPrimvarsFromMaterial(System.Int32 index, USD.NET.IArbitraryPrimvars& sample) { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private System.Void Dispose() { }
        private System.Collections.Generic.IEnumerator<USD.NET.SampleEnumerator.SampleHolder<T>> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000036
    public interface IRestorable
    {
        // Methods
        private System.Boolean IsRestoredFromCachedData() { }
        private System.Void FromCachedData(USD.NET.IRestorableData data) { }
        private USD.NET.IRestorableData ToCachedData() { }

    }

    // TypeToken: 0x2000037
    public interface ISanitizable
    {
        // Methods
        private System.Void Sanitize(USD.NET.Scene scene, Unity.Formats.USD.SceneImportOptions importOptions) { }

    }

    // TypeToken: 0x2000038
    public class MeshStaticPropertiesData, IRestorableData
    {
        // Fields
        private System.Int32[] originalFaceVertexCounts;        // 0x10
        private System.Int32[] originalFaceVertexIndices;        // 0x18
        private System.Boolean arePrimvarsFaceVarying;        // 0x20
        private USD.NET.Orientation orientation;        // 0x24

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000039
    public class SanitizedXformSample : XformSample, ISanitizable
    {
        // Methods
        private System.Void Sanitize(USD.NET.Scene scene, Unity.Formats.USD.SceneImportOptions importOptions) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003A
    public class SanitizedCameraSample : CameraSample, ISanitizable
    {
        // Methods
        private System.Void Sanitize(USD.NET.Scene scene, Unity.Formats.USD.SceneImportOptions importOptions) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003B
    public class SanitizedMeshSample : MeshSample, ISanitizable, IRestorable
    {
        // Fields
        private System.Int32[] originalFaceVertexCounts;        // 0xC0
        private System.Int32[] originalFaceVertexIndices;        // 0xC8
        private System.Boolean arePrimvarsFaceVarying;        // 0xD0
        private System.Int32[] faceMapping;        // 0xD8
        private System.Int32[] triangulatedFaceVertexIndices;        // 0xE0
        private System.Boolean isRestoredFromCachedData;        // 0xE8

        // Methods
        private System.Boolean IsRestoredFromCachedData() { }
        private System.Void FromCachedData(USD.NET.IRestorableData restorableData) { }
        private USD.NET.IRestorableData ToCachedData() { }
        private System.Void BackupTopology() { }
        private System.Boolean IsTopologyBackedUp() { }
        private System.Void Sanitize(USD.NET.Scene scene, Unity.Formats.USD.SceneImportOptions importOptions) { }
        private System.Void Triangulate(System.Boolean changeHandedness) { }
        private System.Boolean ShouldUnweldVertices(System.Boolean bindMaterials) { }
        private System.Boolean AreAnyArbitraryPrimvarsFaceVarying() { }
        private System.Void Flatten(T[]& values, System.Int32[] indices) { }
        private System.Void UnweldPrimvar(USD.NET.Primvar<System.Object> primvar, System.Boolean changeHandedness) { }
        private System.Void FlattenPrimvar(USD.NET.Primvar<System.Object> primvar) { }
        private System.Void TriangulateAttributes(T[]& values, System.Int32[] faceVertexCounts, System.Boolean changeHandedness) { }
        private System.Void ConvertInterpolationToFaceVarying(T[]& values, System.Int32[] vertexIndices, System.Boolean changeHandedness, pxr.TfToken interpolation) { }
        private pxr.TfToken GuessInterpolation(System.Int32 count) { }
        private System.Boolean IsInterpolationValid(pxr.TfToken interpolation, System.Int32 count) { }
        private System.Void UniformToFaceVarying(T[]& values, System.Int32 vertexCount) { }
        private System.Void ComputeNormals(UnityEngine.Vector3[] points, System.Int32[] faceVertexIndices, UnityEngine.Vector3[]& normals) { }
        private System.Boolean ShouldUnwindVertices(System.Boolean changeHandedness) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003C
    public class ExportHelpers
    {
        // Methods
        private USD.NET.Scene InitForSave(System.String filePath) { }
        private System.Void ExportGameObjects(UnityEngine.GameObject[] objects, USD.NET.Scene scene, Unity.Formats.USD.BasisTransformation basisTransform, System.Boolean exportMonoBehaviours) { }

    }

    // TypeToken: 0x200003D
    public class HierarchyBuilder
    {
        // Fields
        private static readonly pxr.SdfPath kAbsoluteRootPath;        // 0x0

        // Methods
        private Unity.Jobs.JobHandle BeginReading(USD.NET.Scene scene, pxr.SdfPath usdRoot, Unity.Formats.USD.PrimMap map, Unity.Formats.USD.SceneImportOptions options) { }
        private Unity.Formats.USD.HierarchyBuilder.HierInfo[] BuildObjectLists(USD.NET.Scene scene, UnityEngine.GameObject unityRoot, pxr.SdfPath usdRoot, Unity.Formats.USD.PrimMap map, Unity.Formats.USD.SceneImportOptions options) { }
        private Unity.Formats.USD.PrimMap BuildGameObjects(USD.NET.Scene scene, UnityEngine.GameObject unityRoot, pxr.SdfPath usdRoot, System.Collections.Generic.IEnumerable<pxr.SdfPath> paths, Unity.Formats.USD.PrimMap map, Unity.Formats.USD.SceneImportOptions options) { }
        private System.Boolean IsVisible(pxr.UsdPrim usdPrim) { }
        private System.Void ApplySelfVisibility(UnityEngine.GameObject go, pxr.UsdPrim usdPrim) { }
        private System.Void CreateAncestors(pxr.SdfPath path, Unity.Formats.USD.PrimMap map, UnityEngine.GameObject unityRoot, pxr.SdfPath usdRoot, Unity.Formats.USD.SceneImportOptions options, UnityEngine.GameObject& parentGo) { }
        private System.Void ProcessPaths(Unity.Formats.USD.HierarchyBuilder.HierInfo[] infos, USD.NET.Scene scene, UnityEngine.GameObject unityRoot, pxr.SdfPath usdRoot, Unity.Formats.USD.PrimMap map, Unity.Formats.USD.SceneImportOptions options) { }
        private System.Void PopulateSkelCache(Unity.Formats.USD.HierarchyBuilder.HierInfo& skelRootInfo, pxr.UsdSkelCache skelCache) { }
        private System.Void ReadSkeletonJoints(Unity.Formats.USD.HierarchyBuilder.HierInfo& skelRootInfo) { }
        private System.Void ExpandSkeleton(Unity.Formats.USD.HierarchyBuilder.HierInfo info, UnityEngine.GameObject unityRoot, pxr.SdfPath usdRoot, pxr.UsdPrim prim, Unity.Formats.USD.PrimMap map, Unity.Formats.USD.SceneImportOptions options) { }
        private System.Void ReadModelInfo(Unity.Formats.USD.HierarchyBuilder.HierInfo& info) { }
        private System.Void AddModelRoot(UnityEngine.GameObject go, Unity.Formats.USD.HierarchyBuilder.HierInfo info) { }
        private System.Void AddPayload(UnityEngine.GameObject go, Unity.Formats.USD.HierarchyBuilder.HierInfo info, Unity.Formats.USD.SceneImportOptions options) { }
        private System.Void AddVariantSet(UnityEngine.GameObject go, pxr.UsdPrim prim) { }
        private UnityEngine.GameObject FindOrCreateGameObject(UnityEngine.Transform parent, pxr.SdfPath path, UnityEngine.Transform unityRoot, Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions options) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000044
    public class ImportHelpers
    {
        // Methods
        private UnityEngine.GameObject ImportSceneAsGameObject(USD.NET.Scene scene, UnityEngine.GameObject parent, Unity.Formats.USD.SceneImportOptions importOptions) { }
        private USD.NET.Scene InitForOpen(System.String path, pxr.UsdStage.InitialLoadSet loadSet) { }
        private pxr.SdfPath GetDefaultRoot(USD.NET.Scene scene) { }
        private UnityEngine.GameObject UsdToGameObject(UnityEngine.GameObject parent, USD.NET.Scene scene, Unity.Formats.USD.SceneImportOptions importOptions) { }
        private System.String GetObjectName(pxr.SdfPath rootPrimName, System.String path) { }
        private System.String GetObjectName(System.String path) { }
        private System.String GetPrefabName(System.String path) { }

    }

    // TypeToken: 0x2000045
    public interface IImportProcessUsd
    {
        // Methods
        private System.Void ProcessUsd(USD.NET.Scene scene, Unity.Formats.USD.SceneImportOptions sceneImportOptions) { }

    }

    // TypeToken: 0x2000046
    public interface IImportPostProcessHierarchy
    {
        // Methods
        private System.Void PostProcessHierarchy(Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions sceneImportOptions) { }

    }

    // TypeToken: 0x2000047
    public interface IImportPostProcessComponents
    {
        // Methods
        private System.Void PostProcessComponents(Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions sceneImportOptions) { }

    }

    // TypeToken: 0x2000048
    public class PrimMap, IEnumerable`1, IEnumerable
    {
        // Fields
        public pxr.UsdSkelCache SkelCache;        // 0x10
        public System.Collections.Generic.Dictionary<pxr.SdfPath,pxr.UsdSkelBindingVector> SkelBindings;        // 0x18
        public System.Collections.Generic.Dictionary<pxr.SdfPath,pxr.UsdSkelSkinningQuery> SkinningQueries;        // 0x20
        public System.Collections.Generic.Dictionary<pxr.SdfPath,Unity.Formats.USD.MeshImporter.GeometrySubsets> MeshSubsets;        // 0x28
        private pxr.SdfPath[] <Cameras>k__BackingField;        // 0x30
        private pxr.SdfPath[] <Meshes>k__BackingField;        // 0x38
        private pxr.SdfPath[] <Cubes>k__BackingField;        // 0x40
        private pxr.SdfPath[] <Spheres>k__BackingField;        // 0x48
        private pxr.SdfPath[] <Xforms>k__BackingField;        // 0x50
        private pxr.SdfPath[] <SkelRoots>k__BackingField;        // 0x58
        private pxr.SdfPath[] <Skeletons>k__BackingField;        // 0x60
        private pxr.SdfPath[] <Materials>k__BackingField;        // 0x68
        private System.Boolean <ContainsPointInstances>k__BackingField;        // 0x70
        private System.Boolean <HasErrors>k__BackingField;        // 0x71
        private System.Collections.Generic.Dictionary<pxr.SdfPath,UnityEngine.GameObject> m_prims;        // 0x78
        private System.Collections.Generic.Dictionary<pxr.SdfPath,Unity.Formats.USD.PrimMap.InstanceRoot> m_instanceRoots;        // 0x80
        private System.Collections.Generic.HashSet<UnityEngine.GameObject> m_instances;        // 0x88
        private System.Collections.Generic.Dictionary<pxr.SdfPath,UnityEngine.GameObject> m_masterRoots;        // 0x90

        // Methods
        private pxr.SdfPath[] get_Cameras() { }
        private System.Void set_Cameras(pxr.SdfPath[] value) { }
        private pxr.SdfPath[] get_Meshes() { }
        private System.Void set_Meshes(pxr.SdfPath[] value) { }
        private pxr.SdfPath[] get_Cubes() { }
        private System.Void set_Cubes(pxr.SdfPath[] value) { }
        private pxr.SdfPath[] get_Spheres() { }
        private System.Void set_Spheres(pxr.SdfPath[] value) { }
        private pxr.SdfPath[] get_Xforms() { }
        private System.Void set_Xforms(pxr.SdfPath[] value) { }
        private pxr.SdfPath[] get_SkelRoots() { }
        private System.Void set_SkelRoots(pxr.SdfPath[] value) { }
        private pxr.SdfPath[] get_Skeletons() { }
        private System.Void set_Skeletons(pxr.SdfPath[] value) { }
        private pxr.SdfPath[] get_Materials() { }
        private System.Void set_Materials(pxr.SdfPath[] value) { }
        private System.Boolean get_ContainsPointInstances() { }
        private System.Void set_ContainsPointInstances(System.Boolean value) { }
        private System.Boolean get_HasErrors() { }
        private System.Void set_HasErrors(System.Boolean value) { }
        private System.Void .ctor() { }
        private UnityEngine.GameObject get_Item(pxr.SdfPath path) { }
        private System.Void set_Item(pxr.SdfPath path, UnityEngine.GameObject value) { }
        private System.Boolean TryGetValue(pxr.SdfPath key, UnityEngine.GameObject& obj) { }
        private System.Collections.IEnumerator GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<pxr.SdfPath,UnityEngine.GameObject>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<pxr.SdfPath,UnityEngine.GameObject>>.GetEnumerator() { }
        private System.Void AddInstance(UnityEngine.GameObject goInst) { }
        private System.Void AddMasterRoot(pxr.SdfPath path, UnityEngine.GameObject go) { }
        private System.Void AddInstanceRoot(pxr.SdfPath instancePath, UnityEngine.GameObject go, pxr.SdfPath masterPath) { }
        private System.Collections.Generic.Dictionary.KeyCollection<pxr.SdfPath,UnityEngine.GameObject> GetMasterRootPaths() { }
        private System.Collections.Generic.Dictionary.ValueCollection<pxr.SdfPath,Unity.Formats.USD.PrimMap.InstanceRoot> GetInstanceRoots() { }
        private System.Void DestroyAll() { }
        private System.Void Clear() { }

    }

    // TypeToken: 0x200004A
    public class ExportFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext) { }
        private System.IAsyncResult BeginInvoke(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200004B
    public class ObjectProcessor : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.GameObject go, Unity.Formats.USD.ExportContext context) { }
        private System.IAsyncResult BeginInvoke(UnityEngine.GameObject go, Unity.Formats.USD.ExportContext context, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200004C
    public struct ObjectContext
    {
        // Fields
        public UnityEngine.GameObject gameObject;        // 0x10
        public System.String path;        // 0x18
        public USD.NET.SampleBase sample;        // 0x20
        public System.Object additionalData;        // 0x28

    }

    // TypeToken: 0x200004D
    public struct ActiveExportPolicy
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.Formats.USD.ActiveExportPolicy ExportAsVisibility;        // 0x0
        public static Unity.Formats.USD.ActiveExportPolicy ExportAsActive;        // 0x0
        public static Unity.Formats.USD.ActiveExportPolicy DoNotExport;        // 0x0
        public static Unity.Formats.USD.ActiveExportPolicy Ignore;        // 0x0

    }

    // TypeToken: 0x200004E
    public class ExportContext
    {
        // Fields
        public USD.NET.Scene scene;        // 0x10
        public UnityEngine.Transform exportRoot;        // 0x18
        public System.Boolean exportMaterials;        // 0x20
        public System.Boolean exportNative;        // 0x21
        public System.Single scale;        // 0x24
        public System.Boolean exportTransformOverrides;        // 0x28
        public Unity.Formats.USD.BasisTransformation basisTransform;        // 0x2C
        public Unity.Formats.USD.ActiveExportPolicy activePolicy;        // 0x30
        public System.Collections.Generic.Dictionary<UnityEngine.GameObject,Unity.Formats.USD.ExportPlan> plans;        // 0x38
        public System.Collections.Generic.Dictionary<UnityEngine.Material,System.String> matMap;        // 0x40
        public System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Transform> meshToSkelRoot;        // 0x48
        public System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Transform[]> meshToBones;        // 0x50
        public System.Collections.Generic.Dictionary<UnityEngine.Transform,System.Collections.Generic.List<System.String>> skelSortedMap;        // 0x58
        public System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform> pathToBone;        // 0x60
        public System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Transform> boneToRoot;        // 0x68
        public System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Matrix4x4> bindPoses;        // 0x70
        public System.Collections.Generic.Dictionary<System.Type,USD.NET.SampleBase> samples;        // 0x78
        public System.Diagnostics.Stopwatch analyticsTotalTimeStopwatch;        // 0x80

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004F
    public class Exporter
    {
        // Fields
        public System.String path;        // 0x10
        public USD.NET.SampleBase sample;        // 0x18
        public Unity.Formats.USD.ExportFunction exportFunc;        // 0x20
        public System.Object data;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000050
    public class ExportPlan
    {
        // Fields
        public System.Collections.Generic.List<Unity.Formats.USD.Exporter> exporters;        // 0x10

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000051
    public class SceneExporter
    {
        // Methods
        private System.Void Export(UnityEngine.GameObject root, USD.NET.Scene scene, Unity.Formats.USD.BasisTransformation basisTransform, System.Boolean exportUnvarying, System.Boolean zeroRootTransform, System.Boolean exportMaterials, System.Boolean exportMonoBehaviours, System.Boolean exportOverrides) { }
        private System.Void Export(UnityEngine.GameObject root, Unity.Formats.USD.ExportContext context, System.Boolean zeroRootTransform) { }
        private System.Void ExportImpl(UnityEngine.GameObject root, Unity.Formats.USD.ExportContext context) { }
        private System.Void Traverse(UnityEngine.GameObject obj, Unity.Formats.USD.ObjectProcessor processor, Unity.Formats.USD.ExportContext context) { }
        private System.Void AccumNestedBones(UnityEngine.Transform curXf, System.Collections.Generic.List<UnityEngine.Transform> children, Unity.Formats.USD.ExportContext ctx) { }
        private T CreateSample(Unity.Formats.USD.ExportContext context) { }
        private System.Void SyncExportContext(UnityEngine.GameObject exportRoot, Unity.Formats.USD.ExportContext context) { }
        private System.Void InitExportableObjects(UnityEngine.GameObject go, Unity.Formats.USD.ExportContext context) { }
        private UnityEngine.Transform MergeBonesBelowAnimator(UnityEngine.Transform animator, Unity.Formats.USD.ExportContext context) { }
        private System.Void MergeBonesSimple(UnityEngine.Transform source, UnityEngine.Transform rootBone, UnityEngine.Transform[] bones, UnityEngine.Matrix4x4[] bindPoses, Unity.Formats.USD.ExportContext context) { }
        private System.Void CreateExportPlan(UnityEngine.GameObject go, USD.NET.SampleBase sample, Unity.Formats.USD.ExportFunction exportFunc, Unity.Formats.USD.ExportContext context, System.String pathSuffix, System.Boolean insertFirst) { }
        private UnityEngine.Matrix4x4 ComputeWorldXf(UnityEngine.Transform curBone, Unity.Formats.USD.ExportContext context) { }

    }

    // TypeToken: 0x2000053
    public interface IImporter
    {
        // Methods
        private System.Void BeginReading(USD.NET.Scene scene, Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions importOptions) { }
        private System.Collections.IEnumerator Import(USD.NET.Scene scene, Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions importOptions) { }

    }

    // TypeToken: 0x2000054
    public class SceneImporter
    {
        // Fields
        public static Unity.Formats.USD.IImporter ActiveMeshImporter;        // 0x0

        // Methods
        private System.Void .cctor() { }
        private System.Void ImportUsd(UnityEngine.GameObject goRoot, USD.NET.Scene scene, Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions importOptions) { }
        private System.Void ImportUsd(UnityEngine.GameObject goRoot, USD.NET.Scene scene, Unity.Formats.USD.PrimMap primMap, System.Boolean composingSubtree, Unity.Formats.USD.SceneImportOptions importOptions) { }
        private Unity.Formats.USD.UsdEditorAnalytics.ImportResult CreateImportResult(System.Boolean success, Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.ImportType importType) { }
        private Unity.Formats.USD.PrimMap BuildScene(USD.NET.Scene scene, UnityEngine.GameObject root, Unity.Formats.USD.SceneImportOptions importOptions, Unity.Formats.USD.PrimMap primMap, System.Boolean composingSubtree) { }
        private System.Void RemoveComponent(UnityEngine.GameObject go) { }
        private System.Collections.IEnumerator BuildScene(USD.NET.Scene scene, UnityEngine.GameObject root, Unity.Formats.USD.SceneImportOptions importOptions, Unity.Formats.USD.PrimMap primMap, System.Single targetFrameMilliseconds, System.Boolean composingSubtree) { }
        private System.Boolean ShouldYield(System.Single targetTime, System.Diagnostics.Stopwatch timer) { }
        private System.Void ResetTimer(System.Diagnostics.Stopwatch timer) { }
        private System.Boolean IsSkinnedMesh(pxr.UsdPrim prim, Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions importOptions) { }

    }

    // TypeToken: 0x2000057
    public struct PayloadPolicy
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.Formats.USD.PayloadPolicy DontLoadPayloads;        // 0x0
        public static Unity.Formats.USD.PayloadPolicy LoadAll;        // 0x0

    }

    // TypeToken: 0x2000058
    public struct BasisTransformation
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.Formats.USD.BasisTransformation FastWithNegativeScale;        // 0x0
        public static Unity.Formats.USD.BasisTransformation SlowAndSafe;        // 0x0
        public static Unity.Formats.USD.BasisTransformation SlowAndSafeAsFBX;        // 0x0
        public static Unity.Formats.USD.BasisTransformation None;        // 0x0

    }

    // TypeToken: 0x2000059
    public struct MaterialImportMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.Formats.USD.MaterialImportMode ImportPreviewSurface;        // 0x0
        public static Unity.Formats.USD.MaterialImportMode ImportDisplayColor;        // 0x0
        public static Unity.Formats.USD.MaterialImportMode None;        // 0x0

    }

    // TypeToken: 0x200005A
    public class SceneImportOptions
    {
        // Fields
        public System.String projectAssetPath;        // 0x10
        public pxr.SdfPath usdRootPath;        // 0x18
        public System.Boolean forceRebuild;        // 0x20
        public Unity.Formats.USD.PayloadPolicy payloadPolicy;        // 0x24
        public System.Boolean importHierarchy;        // 0x28
        public System.Boolean importCameras;        // 0x29
        public System.Boolean importMeshes;        // 0x2A
        public System.Boolean importSkinning;        // 0x2B
        public System.Boolean importSkinWeights;        // 0x2C
        public System.Boolean importTransforms;        // 0x2D
        public System.Boolean importSceneInstances;        // 0x2E
        public System.Boolean importPointInstances;        // 0x2F
        public System.Boolean importMonoBehaviours;        // 0x30
        public Unity.Formats.USD.BasisTransformation changeHandedness;        // 0x34
        public System.Single scale;        // 0x38
        public System.Boolean interpolate;        // 0x3C
        public System.Boolean enableGpuInstancing;        // 0x3D
        public System.Boolean useDisplayColorAsFallbackMaterial;        // 0x3E
        public Unity.Formats.USD.MaterialImportMode materialImportMode;        // 0x40
        public Unity.Formats.USD.MaterialMap materialMap;        // 0x48
        public Unity.Formats.USD.MeshImportOptions meshOptions;        // 0x50
        private Unity.Formats.USD.ImportType <ImportType>k__BackingField;        // 0x58

        // Methods
        private System.Boolean get_ShouldBindMaterials() { }
        private Unity.Formats.USD.ImportType get_ImportType() { }
        private System.Void set_ImportType(Unity.Formats.USD.ImportType value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005B
    public class UsdzExporter
    {
        // Methods
        private System.Void ExportUsdz(System.String usdzFilePath, UnityEngine.GameObject root) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005C
    public class SkeletonExporter
    {
        // Methods
        private System.Void ExportSkeleton(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext) { }
        private System.Void ExportSkelRoot(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext) { }
        private System.Void ExportSkelAnimation(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext) { }

    }

    // TypeToken: 0x200005D
    public class SkeletonImporter
    {
        // Methods
        private System.Void BuildSkeletonBone(System.String skelPath, UnityEngine.GameObject go, UnityEngine.Matrix4x4 restXform, pxr.VtTokenArray joints, Unity.Formats.USD.SceneImportOptions importOptions) { }
        private System.Void BuildDebugBindTransforms(Unity.Formats.USD.SkeletonSample skelSample, UnityEngine.GameObject goSkeleton, Unity.Formats.USD.SceneImportOptions options) { }
        private System.Void BuildBindTransforms(System.String path, Unity.Formats.USD.SkeletonSample skelSample, Unity.Formats.USD.SceneImportOptions options) { }
        private System.Boolean JointsMatch(System.String[] lhs, System.String[] rhs) { }
        private System.Void BuildSkinnedMesh(System.String meshPath, System.String skelPath, Unity.Formats.USD.SkeletonSample skeleton, pxr.UsdSkelSkinningQuery skinningQuery, UnityEngine.GameObject go, Unity.Formats.USD.PrimMap primMap, Unity.Formats.USD.SceneImportOptions options) { }

    }

    // TypeToken: 0x200005E
    public class UnitySkeleton
    {
        // Fields
        public UnityEngine.Transform rootBone;        // 0x10
        public UnityEngine.Transform[] bones;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005F
    public class SkelBindingSample : SampleBase
    {
        // Fields
        public System.String[] blendShapes;        // 0x10
        public USD.NET.Relationship blendShapeTargets;        // 0x18
        public USD.NET.Relationship animationSource;        // 0x20
        public USD.NET.Relationship skeleton;        // 0x28
        public System.String[] joints;        // 0x30
        public USD.NET.Primvar<System.Int32[]> jointIndices;        // 0x38
        public USD.NET.Primvar<UnityEngine.Matrix4x4> geomBindTransform;        // 0x40
        public USD.NET.Primvar<System.Single[]> jointWeights;        // 0x48

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000060
    public class SkelRootSample : BoundableSample
    {
        // Fields
        public USD.NET.Relationship skeleton;        // 0x78
        public USD.NET.Relationship animationSource;        // 0x80

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000061
    public class SkeletonSample : XformableSample
    {
        // Fields
        public System.String[] joints;        // 0x60
        public UnityEngine.Matrix4x4[] bindTransforms;        // 0x68
        public UnityEngine.Matrix4x4[] restTransforms;        // 0x70

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000062
    public class SkelAnimationSample : SampleBase
    {
        // Fields
        public System.String[] joints;        // 0x10
        public UnityEngine.Vector3[] translations;        // 0x18
        public UnityEngine.Quaternion[] rotations;        // 0x20
        public pxr.VtVec3hArray scales;        // 0x28
        public System.String[] blendShapes;        // 0x30
        public System.Single[] blendShapeWeights;        // 0x38

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000063
    public class BlendShapeSample : SampleBase
    {
        // Fields
        public UnityEngine.Vector3[] offsets;        // 0x10
        public System.UInt32[] pointIndices;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000064
    public class SkeletonIo
    {
        // Fields
        private System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Transform[]> m_bindings;        // 0x10

        // Methods
        private UnityEngine.Transform[] GetBones(UnityEngine.Transform rootBone) { }
        private System.Void RegisterSkeleton(UnityEngine.Transform rootBone, UnityEngine.Transform[] bones) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000065
    public class NativeExporter
    {
        // Methods
        private System.Void ExportObject(Unity.Formats.USD.ObjectContext objContext, Unity.Formats.USD.ExportContext exportContext) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000066
    public class NativeImporter
    {
        // Methods
        private System.Void ImportObject(USD.NET.Scene scene, UnityEngine.GameObject go, pxr.UsdPrim usdPrim, Unity.Formats.USD.SceneImportOptions options) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000067
    public class UsdPlayableAsset : PlayableAsset, ITimelineClipAsset
    {
        // Fields
        private Unity.Formats.USD.UsdAsset m_sourceUsdAsset;        // 0x18
        public UnityEngine.ExposedReference<Unity.Formats.USD.UsdAsset> SourceUsdAsset;        // 0x20

        // Methods
        private UnityEngine.Timeline.ClipCaps get_clipCaps() { }
        private Unity.Formats.USD.UsdAsset GetUsdAsset(System.String usdRootPath) { }
        private UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner) { }
        private System.Double get_duration() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000068
    public class UsdPlayableBehaviour : PlayableBehaviour
    {
        // Fields
        public Unity.Formats.USD.UsdPlayableAsset playableAsset;        // 0x10
        private System.Boolean m_errorOnce;        // 0x18

        // Methods
        private System.Void OnGraphStart(UnityEngine.Playables.Playable playable) { }
        private System.Void OnGraphStop(UnityEngine.Playables.Playable playable) { }
        private System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData) { }
        private System.Void PrepareData(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000069
    public class UsdPlayableTrack : TrackAsset
    {
        // Methods
        private System.Void OnCreateClip(UnityEngine.Timeline.TimelineClip clip) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006A
    public class UsdRecorderBehaviour : PlayableBehaviour
    {
        // Fields
        private static System.Int32 kExportFrameRate;        // 0x0
        private System.Boolean m_isPaused;        // 0x10
        public Unity.Formats.USD.UsdRecorderClip Clip;        // 0x18
        private System.String usdcFileName;        // 0x20
        private System.String usdzFileName;        // 0x28
        private System.String usdzFilePath;        // 0x30
        private System.String currentDir;        // 0x38
        private System.IO.DirectoryInfo usdzTemporaryDir;        // 0x40
        private UnityEngine.GameObject _root;        // 0x48

        // Methods
        private System.Void BeginRecording(System.Double currentTime, UnityEngine.GameObject root) { }
        private System.Void StopRecording(System.Double currentTime) { }
        private System.Void ProcessRecording(System.Double currentTime, UnityEngine.GameObject root) { }
        private System.Boolean IsPlaying() { }
        private System.Void OnPlayableCreate(UnityEngine.Playables.Playable playable) { }
        private System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable) { }
        private System.Void OnGraphStart(UnityEngine.Playables.Playable playable) { }
        private System.Void OnGraphStop(UnityEngine.Playables.Playable playable) { }
        private System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData) { }
        private System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void OnFrameEnd(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006C
    public class UsdRecorderClip : PlayableAsset, ITimelineClipAsset
    {
        // Fields
        public UnityEngine.ExposedReference<UnityEngine.GameObject> m_exportRoot;        // 0x18
        private UnityEngine.GameObject[] m_trackedRoots;        // 0x28
        public System.Boolean m_exportMaterials;        // 0x30
        public Unity.Formats.USD.BasisTransformation m_convertHandedness;        // 0x34
        public Unity.Formats.USD.ActiveExportPolicy m_activePolicy;        // 0x38
        public System.String m_usdFile;        // 0x40
        private USD.NET.Scene <UsdScene>k__BackingField;        // 0x48
        private Unity.Formats.USD.ExportContext m_context;        // 0x50

        // Methods
        private USD.NET.Scene get_UsdScene() { }
        private System.Void set_UsdScene(USD.NET.Scene value) { }
        private Unity.Formats.USD.ExportContext get_Context() { }
        private System.Void set_Context(Unity.Formats.USD.ExportContext value) { }
        private UnityEngine.GameObject GetExportRoot(UnityEngine.Playables.PlayableGraph graph) { }
        private UnityEngine.Timeline.ClipCaps get_clipCaps() { }
        private System.Boolean get_IsUSDZ() { }
        private UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner) { }
        private System.Void OnDestroy() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006D
    public class UsdRecorderTrack : TrackAsset
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006E
    public class UsdWaitForEndOfFrame : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<System.Action> m_pending;        // 0x18
        private static Unity.Formats.USD.UsdWaitForEndOfFrame s_instance;        // 0x0

        // Methods
        private Unity.Formats.USD.UsdWaitForEndOfFrame GetInstance() { }
        private System.Void Add(System.Action callback) { }
        private System.Collections.IEnumerator WaitForEndOfFrame() { }
        private System.Void LateUpdate() { }
        private System.Void .ctor() { }

    }

}

