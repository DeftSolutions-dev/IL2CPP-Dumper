// ========================================================
// Dumped by @desirepro
// Assembly: VolumetricLightBeam.dll
// Classes:  64
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000002
    public class EditorPrefsStrings
    {
    }

    // TypeToken: 0x200000B
    public class Help
    {
        // Fields
        private static System.String UrlBase;        // 0x0
        private static System.String UrlSuffix;        // 0x0
        public static System.String UrlBeam;        // 0x0
        public static System.String UrlDustParticles;        // 0x0
        public static System.String UrlDynamicOcclusionRaycasting;        // 0x0
        public static System.String UrlDynamicOcclusionDepthBuffer;        // 0x0
        public static System.String UrlTriggerZone;        // 0x0
        public static System.String UrlSkewingHandle;        // 0x0
        public static System.String UrlEffectFlicker;        // 0x0
        public static System.String UrlEffectPulse;        // 0x0
        public static System.String UrlConfig;        // 0x0

    }

    // TypeToken: 0x200000C
    public class Internal
    {
        // Methods
        private UnityEngine.HideFlags get_ProceduralObjectsHideFlags() { }

    }

    // TypeToken: 0x200000D
    public class Beam
    {
        // Fields
        public static VLB.ColorMode ColorModeDefault;        // 0x0
        public static System.Single MultiplierDefault;        // 0x0
        public static System.Single MultiplierMin;        // 0x0
        public static System.Single IntensityDefault;        // 0x0
        public static System.Single IntensityMin;        // 0x0
        public static System.Single HDRPExposureWeightDefault;        // 0x0
        public static System.Single HDRPExposureWeightMin;        // 0x0
        public static System.Single HDRPExposureWeightMax;        // 0x0
        public static System.Single SpotAngleDefault;        // 0x0
        public static System.Single SpotAngleMin;        // 0x0
        public static System.Single SpotAngleMax;        // 0x0
        public static System.Single ConeRadiusStart;        // 0x0
        public static VLB.MeshType GeomMeshType;        // 0x0
        public static System.Int32 GeomSidesDefault;        // 0x0
        public static System.Int32 GeomSidesMin;        // 0x0
        public static System.Int32 GeomSidesMax;        // 0x0
        public static System.Int32 GeomSegmentsDefault;        // 0x0
        public static System.Int32 GeomSegmentsMin;        // 0x0
        public static System.Int32 GeomSegmentsMax;        // 0x0
        public static System.Boolean GeomCap;        // 0x0
        public static VLB.AttenuationEquation AttenuationEquationDefault;        // 0x0
        public static System.Single AttenuationCustomBlendingDefault;        // 0x0
        public static System.Single AttenuationCustomBlendingMin;        // 0x0
        public static System.Single AttenuationCustomBlendingMax;        // 0x0
        public static System.Single FallOffStart;        // 0x0
        public static System.Single FallOffEnd;        // 0x0
        public static System.Single FallOffDistancesMinThreshold;        // 0x0
        public static System.Single DepthBlendDistance;        // 0x0
        public static System.Single CameraClippingDistance;        // 0x0
        public static System.Single FresnelPowMaxValue;        // 0x0
        public static System.Single FresnelPow;        // 0x0
        public static System.Single GlareFrontalDefault;        // 0x0
        public static System.Single GlareBehindDefault;        // 0x0
        public static System.Single GlareMin;        // 0x0
        public static System.Single GlareMax;        // 0x0
        public static VLB.NoiseMode NoiseModeDefault;        // 0x0
        public static System.Single NoiseIntensityMin;        // 0x0
        public static System.Single NoiseIntensityMax;        // 0x0
        public static System.Single NoiseIntensityDefault;        // 0x0
        public static System.Single NoiseScaleMin;        // 0x0
        public static System.Single NoiseScaleMax;        // 0x0
        public static readonly UnityEngine.Vector3 NoiseScalesDefault;        // 0x0
        public static System.Single NoiseScaleDefault;        // 0x0
        public static VLB.BlendingMode BlendingModeDefault;        // 0x0
        public static VLB.ShaderAccuracy ShaderAccuracyDefault;        // 0x0
        public static System.Single FadeOutBeginDefault;        // 0x0
        public static System.Single FadeOutEndDefault;        // 0x0
        public static System.Single FadeOutBeginSecondDefault;        // 0x0
        public static System.Single FadeOutEndSecondDefault;        // 0x0
        public static VLB.Dimensions DimensionsDefault;        // 0x0
        public static UnityEngine.Transform ClippingPlaneTransformDefault;        // 0x0
        public static readonly UnityEngine.Color FlatColor;        // 0xC
        public static readonly UnityEngine.Vector3 NoiseVelocityDefault;        // 0x1C
        public static readonly UnityEngine.Vector2 TiltDefault;        // 0x28
        public static readonly UnityEngine.Vector3 SkewingLocalForwardDirectionDefault;        // 0x30

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000E
    public class DustParticles
    {
        // Fields
        public static System.Single AlphaDefault;        // 0x0
        public static System.Single SizeDefault;        // 0x0
        public static VLB.ParticlesDirection DirectionDefault;        // 0x0
        public static System.Single DensityDefault;        // 0x0
        public static System.Single DensityMin;        // 0x0
        public static System.Single DensityMax;        // 0x0
        public static System.Boolean CullingEnabledDefault;        // 0x0
        public static System.Single CullingMaxDistanceDefault;        // 0x0
        public static System.Single CullingMaxDistanceMin;        // 0x0
        public static readonly UnityEngine.Vector3 VelocityDefault;        // 0x0
        public static readonly VLB.MinMaxRangeFloat SpawnDistanceRangeDefault;        // 0xC

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000F
    public class DynOcclusion
    {
        // Fields
        public static System.Single FadeDistanceToSurfaceDefault;        // 0x0
        public static VLB.DynamicOcclusionUpdateRate UpdateRateDefault;        // 0x0
        public static System.Int32 WaitFramesCountDefault;        // 0x0
        public static VLB.Dimensions RaycastingDimensionsDefault;        // 0x0
        public static System.Boolean RaycastingConsiderTriggersDefault;        // 0x0
        public static System.Single RaycastingMinOccluderAreaDefault;        // 0x0
        public static System.Single RaycastingMinSurfaceRatioDefault;        // 0x0
        public static System.Single RaycastingMinSurfaceRatioMin;        // 0x0
        public static System.Single RaycastingMinSurfaceRatioMax;        // 0x0
        public static System.Single RaycastingMaxSurfaceDotDefault;        // 0x0
        public static System.Single RaycastingMaxSurfaceAngleMin;        // 0x0
        public static System.Single RaycastingMaxSurfaceAngleMax;        // 0x0
        public static VLB.PlaneAlignment RaycastingPlaneAlignmentDefault;        // 0x0
        public static System.Single RaycastingPlaneOffsetDefault;        // 0x0
        public static System.Int32 DepthBufferDepthMapResolutionDefault;        // 0x0
        public static System.Boolean DepthBufferOcclusionCullingDefault;        // 0x0
        public static readonly UnityEngine.LayerMask LayerMaskDefault;        // 0x0

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000010
    public class Config
    {
        // Fields
        public static System.Boolean GeometryOverrideLayerDefault;        // 0x0
        public static System.Int32 GeometryLayerIDDefault;        // 0x0
        public static System.String GeometryTagDefault;        // 0x0
        public static System.String FadeOutCameraTagDefault;        // 0x0
        public static VLB.RenderQueue GeometryRenderQueueDefault;        // 0x0
        public static VLB.RenderPipeline GeometryRenderPipelineDefault;        // 0x0
        public static VLB.RenderingMode GeometryRenderingModeDefault;        // 0x0
        public static System.Int32 Noise3DSizeDefault;        // 0x0
        public static System.Int32 SharedMeshSides;        // 0x0
        public static System.Int32 SharedMeshSegments;        // 0x0
        public static System.Single DitheringFactor;        // 0x0
        public static System.Boolean UseLightColorTemperatureDefault;        // 0x0
        public static System.Boolean FeatureEnabledDefault;        // 0x0
        public static VLB.FeatureEnabledColorGradient FeatureEnabledColorGradientDefault;        // 0x0

    }

    // TypeToken: 0x2000022
    public struct BlendingMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static VLB.MaterialManager.BlendingMode Additive;        // 0x0
        public static VLB.MaterialManager.BlendingMode SoftAdditive;        // 0x0
        public static VLB.MaterialManager.BlendingMode TraditionalTransparency;        // 0x0
        public static VLB.MaterialManager.BlendingMode Count;        // 0x0

    }

    // TypeToken: 0x2000023
    public struct ColorGradient
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static VLB.MaterialManager.ColorGradient Off;        // 0x0
        public static VLB.MaterialManager.ColorGradient MatrixLow;        // 0x0
        public static VLB.MaterialManager.ColorGradient MatrixHigh;        // 0x0
        public static VLB.MaterialManager.ColorGradient Count;        // 0x0

    }

    // TypeToken: 0x2000024
    public struct DepthBlend
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static VLB.MaterialManager.DepthBlend Off;        // 0x0
        public static VLB.MaterialManager.DepthBlend On;        // 0x0
        public static VLB.MaterialManager.DepthBlend Count;        // 0x0

    }

    // TypeToken: 0x2000025
    public struct DynamicOcclusion
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static VLB.MaterialManager.DynamicOcclusion Off;        // 0x0
        public static VLB.MaterialManager.DynamicOcclusion ClippingPlane;        // 0x0
        public static VLB.MaterialManager.DynamicOcclusion DepthTexture;        // 0x0
        public static VLB.MaterialManager.DynamicOcclusion Count;        // 0x0

    }

    // TypeToken: 0x2000026
    public struct MeshSkewing
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static VLB.MaterialManager.MeshSkewing Off;        // 0x0
        public static VLB.MaterialManager.MeshSkewing On;        // 0x0
        public static VLB.MaterialManager.MeshSkewing Count;        // 0x0

    }

    // TypeToken: 0x2000027
    public struct Noise3D
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static VLB.MaterialManager.Noise3D Off;        // 0x0
        public static VLB.MaterialManager.Noise3D On;        // 0x0
        public static VLB.MaterialManager.Noise3D Count;        // 0x0

    }

    // TypeToken: 0x2000028
    public struct ShaderAccuracy
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static VLB.MaterialManager.ShaderAccuracy Fast;        // 0x0
        public static VLB.MaterialManager.ShaderAccuracy High;        // 0x0
        public static VLB.MaterialManager.ShaderAccuracy Count;        // 0x0

    }

    // TypeToken: 0x2000029
    public struct StaticProperties
    {
        // Fields
        public System.Boolean useFog;        // 0x10
        public VLB.MaterialManager.BlendingMode blendingMode;        // 0x14
        public VLB.MaterialManager.Noise3D noise3D;        // 0x18
        public VLB.MaterialManager.DepthBlend depthBlend;        // 0x1C
        public VLB.MaterialManager.ColorGradient colorGradient;        // 0x20
        public VLB.MaterialManager.DynamicOcclusion dynamicOcclusion;        // 0x24
        public VLB.MaterialManager.MeshSkewing meshSkewing;        // 0x28
        public VLB.MaterialManager.ShaderAccuracy shaderAccuracy;        // 0x2C

        // Methods
        private System.Int32 get_blendingModeID() { }
        private System.Int32 get_noise3DID() { }
        private System.Int32 get_depthBlendID() { }
        private System.Int32 get_colorGradientID() { }
        private System.Int32 get_dynamicOcclusionID() { }
        private System.Int32 get_meshSkewingID() { }
        private System.Int32 get_shaderAccuracyID() { }
        private System.Int32 get_materialID() { }
        private System.Void ApplyToMaterial(UnityEngine.Material mat) { }

    }

    // TypeToken: 0x200002A
    public class MaterialsGroup
    {
        // Fields
        public readonly UnityEngine.Material[] materials;        // 0x10

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002C
    public class Callback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(VLB.MaterialModifier.Interface owner) { }
        private System.IAsyncResult BeginInvoke(VLB.MaterialModifier.Interface owner, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200002D
    public interface Interface
    {
        // Methods
        private System.Void SetMaterialProp(System.Int32 nameID, System.Single value) { }
        private System.Void SetMaterialProp(System.Int32 nameID, UnityEngine.Vector4 value) { }
        private System.Void SetMaterialProp(System.Int32 nameID, UnityEngine.Color value) { }
        private System.Void SetMaterialProp(System.Int32 nameID, UnityEngine.Matrix4x4 value) { }
        private System.Void SetMaterialProp(System.Int32 nameID, UnityEngine.Texture value) { }

    }

    // TypeToken: 0x2000032
    public struct Plane2D
    {
        // Fields
        public UnityEngine.Vector2 normal;        // 0x10
        public System.Single distance;        // 0x18

        // Methods
        private System.Single Distance(UnityEngine.Vector2 point) { }
        private UnityEngine.Vector2 ClosestPoint(UnityEngine.Vector2 pt) { }
        private UnityEngine.Vector2 Intersect(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2) { }
        private System.Boolean GetSide(UnityEngine.Vector2 point) { }
        private VLB.PolygonHelper.Plane2D FromPoints(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2) { }
        private VLB.PolygonHelper.Plane2D FromNormalAndPoint(UnityEngine.Vector3 normalizedNormal, UnityEngine.Vector3 p1) { }
        private System.Void Flip() { }
        private UnityEngine.Vector2[] CutConvex(UnityEngine.Vector2[] poly) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000037
    public struct RenderPipeline
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static VLB.SRPHelper.RenderPipeline HGRP;        // 0x0
        public static VLB.SRPHelper.RenderPipeline Undefined;        // 0x0
        public static VLB.SRPHelper.RenderPipeline BuiltIn;        // 0x0
        public static VLB.SRPHelper.RenderPipeline URP;        // 0x0
        public static VLB.SRPHelper.RenderPipeline LWRP;        // 0x0
        public static VLB.SRPHelper.RenderPipeline HDRP;        // 0x0

    }

    // TypeToken: 0x2000039
    public struct Packed
    {
        // Fields
        public UnityEngine.Vector3 position;        // 0x10
        public UnityEngine.Quaternion rotation;        // 0x1C
        public UnityEngine.Vector3 lossyScale;        // 0x2C

        // Methods
        private System.Boolean IsSame(UnityEngine.Transform transf) { }

    }

    // TypeToken: 0x200003B
    public struct FloatPackingPrecision
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static VLB.Utils.FloatPackingPrecision High;        // 0x0
        public static VLB.Utils.FloatPackingPrecision Low;        // 0x0
        public static VLB.Utils.FloatPackingPrecision Undef;        // 0x0

    }

    // TypeToken: 0x200003E
    public struct AttachedLightType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static VLB.VolumetricLightBeam.AttachedLightType NoLight;        // 0x0
        public static VLB.VolumetricLightBeam.AttachedLightType OtherLight;        // 0x0
        public static VLB.VolumetricLightBeam.AttachedLightType SpotLight;        // 0x0

    }

    // TypeToken: 0x2000040
    public struct __StaticArrayInitTypeSize=12
    {
    }

namespace Beyond.SourceGenerator
{

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
    public class CameraControlConfigAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000006
    public class DataNAttribute : Attribute
    {
        // Fields
        public System.Int32 capacity;        // 0x10
        public System.Int32 tSize;        // 0x14
        public System.Boolean ring;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000007
    public class AnimatorBlackboardAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace HG.Rendering.Runtime
{

    // TypeToken: 0x2000003
    public class HGConstantBufferLayoutAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace VLB
{

    // TypeToken: 0x2000008
    public class BeamGeometry : MonoBehaviour, Interface
    {
        // Fields
        private VLB.VolumetricLightBeam m_Master;        // 0x18
        private UnityEngine.Matrix4x4 m_ColorGradientMatrix;        // 0x20
        private VLB.MeshType m_CurrentMeshType;        // 0x60
        private VLB.MaterialModifier.Callback m_MaterialModifierCallback;        // 0x68
        private UnityEngine.Coroutine m_CoFadeOut;        // 0x70
        private UnityEngine.MeshRenderer <meshRenderer>k__BackingField;        // 0x78
        private UnityEngine.MeshFilter <meshFilter>k__BackingField;        // 0x80
        private UnityEngine.Mesh <coneMesh>k__BackingField;        // 0x88
        public UnityEngine.Material m_CustomMaterial;        // 0x90

        // Methods
        private UnityEngine.MeshRenderer get_meshRenderer() { }
        private System.Void set_meshRenderer(UnityEngine.MeshRenderer value) { }
        private UnityEngine.MeshFilter get_meshFilter() { }
        private System.Void set_meshFilter(UnityEngine.MeshFilter value) { }
        private UnityEngine.Mesh get_coneMesh() { }
        private System.Void set_coneMesh(UnityEngine.Mesh value) { }
        private System.Boolean get_visible() { }
        private System.Void set_visible(System.Boolean value) { }
        private System.Int32 get_sortingLayerID() { }
        private System.Void set_sortingLayerID(System.Int32 value) { }
        private System.Int32 get_sortingOrder() { }
        private System.Void set_sortingOrder(System.Int32 value) { }
        private System.Boolean get__INTERNAL_IsFadeOutCoroutineRunning() { }
        private System.Void RestartFadeOutCoroutine() { }
        private System.Void StopFadeOutCoroutine() { }
        private System.Void SetMaterialProp(System.Int32 nameID, System.Single value) { }
        private System.Void SetMaterialProp(System.Int32 nameID, UnityEngine.Vector4 value) { }
        private System.Void SetMaterialProp(System.Int32 nameID, UnityEngine.Color value) { }
        private System.Void SetMaterialProp(System.Int32 nameID, UnityEngine.Matrix4x4 value) { }
        private System.Void SetMaterialProp(System.Int32 nameID, UnityEngine.Texture value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000009
    public class Config : ScriptableObject
    {
        // Fields
        public static System.String ClassName;        // 0x0
        public static System.String kAssetName;        // 0x0
        public static System.String kAssetNameExt;        // 0x0
        private static VLB.Config ms_Instance;        // 0x0
        public UnityEngine.Mesh sharedMesh;        // 0x18
        public System.Boolean featureEnabledDustParticles;        // 0x20
        public System.Boolean featureEnabledEffect;        // 0x21
        public System.Boolean featureEnabledTriggerZone;        // 0x22
        public System.Boolean geometryOverrideLayer;        // 0x23
        public System.Int32 geometryLayerID;        // 0x24
        public System.String geometryTag;        // 0x28
        public System.Int32 geometryRenderQueue;        // 0x30
        private VLB.RenderPipeline _RenderPipeline;        // 0x34
        private VLB.RenderingMode _RenderingMode;        // 0x38
        public System.Single ditheringFactor;        // 0x3C
        public System.Boolean useLightColorTemperature;        // 0x40
        public System.Int32 sharedMeshSides;        // 0x44
        public System.Int32 sharedMeshSegments;        // 0x48
        public UnityEngine.Vector3 globalNoisesScale;        // 0x4C
        public UnityEngine.Vector3 globalNoiseVelocity;        // 0x58
        public System.String fadeOutCameraTag;        // 0x68
        public UnityEngine.Texture3D noiseTexture3D;        // 0x70
        public UnityEngine.ParticleSystem dustParticlesPrefab;        // 0x78
        public UnityEngine.Texture2D ditheringNoiseTexture;        // 0x80
        public VLB.FeatureEnabledColorGradient featureEnabledColorGradient;        // 0x88
        public System.Boolean featureEnabledDepthBlend;        // 0x8C
        public System.Boolean featureEnabledNoise3D;        // 0x8D
        public System.Boolean featureEnabledDynamicOcclusion;        // 0x8E
        public System.Boolean featureEnabledMeshSkewing;        // 0x8F
        public System.Boolean featureEnabledShaderAccuracyHigh;        // 0x90
        private UnityEngine.Shader _BeamShader;        // 0x98
        private UnityEngine.Transform m_CachedFadeOutCamera;        // 0xA0
        private System.Int32 pluginVersion;        // 0xA8
        private UnityEngine.Material _DummyMaterial;        // 0xB0

        // Methods
        private VLB.RenderPipeline get_renderPipeline() { }
        private VLB.RenderingMode get_renderingMode() { }
        private VLB.RenderingMode get_actualRenderingMode() { }
        private System.Boolean get_useSinglePassShader() { }
        private System.Boolean get_requiresDoubleSidedMesh() { }
        private UnityEngine.Shader get_beamShader() { }
        private UnityEngine.Transform get_fadeOutCameraTransform() { }
        private System.Boolean get_isHDRPExposureWeightSupported() { }
        private System.Boolean get_hasRenderPipelineMismatch() { }
        private VLB.Config get_Instance() { }
        private System.Void Reset() { }
        private System.Void OnEnable() { }
        private System.Boolean IsSRPBatcherSupported() { }
        private System.Void ForceUpdateFadeOutCamera() { }
        private System.Void OnStartup() { }
        private System.Void RefreshGlobalShaderProperties() { }
        private System.Void ResetInternalData() { }
        private UnityEngine.ParticleSystem NewVolumetricDustParticles() { }
        private System.Void HandleBackwardCompatibility(System.Int32 serializedVersion, System.Int32 newVersion) { }
        private VLB.Config LoadAssetInternal(System.String assetName) { }
        private VLB.Config GetInstance(System.Boolean assertIfNotFound) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000A
    public class Consts
    {
        // Fields
        public static System.String PluginFolder;        // 0x0

    }

    // TypeToken: 0x2000011
    public class DummyMaterial
    {
    }

    // TypeToken: 0x2000012
    public struct FeatureEnabledColorGradient
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static VLB.FeatureEnabledColorGradient Off;        // 0x0
        public static VLB.FeatureEnabledColorGradient HighOnly;        // 0x0
        public static VLB.FeatureEnabledColorGradient HighAndLow;        // 0x0

    }

    // TypeToken: 0x2000013
    public struct ColorMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static VLB.ColorMode Flat;        // 0x0
        public static VLB.ColorMode Gradient;        // 0x0

    }

    // TypeToken: 0x2000014
    public struct AttenuationEquation
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static VLB.AttenuationEquation Linear;        // 0x0
        public static VLB.AttenuationEquation Quadratic;        // 0x0
        public static VLB.AttenuationEquation Blend;        // 0x0

    }

    // TypeToken: 0x2000015
    public struct BlendingMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static VLB.BlendingMode Additive;        // 0x0
        public static VLB.BlendingMode SoftAdditive;        // 0x0
        public static VLB.BlendingMode TraditionalTransparency;        // 0x0

    }

    // TypeToken: 0x2000016
    public struct ShaderAccuracy
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static VLB.ShaderAccuracy Fast;        // 0x0
        public static VLB.ShaderAccuracy High;        // 0x0

    }

    // TypeToken: 0x2000017
    public struct NoiseMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static VLB.NoiseMode Disabled;        // 0x0
        public static VLB.NoiseMode WorldSpace;        // 0x0
        public static VLB.NoiseMode LocalSpace;        // 0x0

    }

    // TypeToken: 0x2000018
    public struct MeshType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static VLB.MeshType Shared;        // 0x0
        public static VLB.MeshType Custom;        // 0x0

    }

    // TypeToken: 0x2000019
    public struct RenderPipeline
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static VLB.RenderPipeline HGRP;        // 0x0
        public static VLB.RenderPipeline BuiltIn;        // 0x0
        public static VLB.RenderPipeline URP;        // 0x0
        public static VLB.RenderPipeline HDRP;        // 0x0

    }

    // TypeToken: 0x200001A
    public struct RenderingMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static VLB.RenderingMode MultiPass;        // 0x0
        public static VLB.RenderingMode SinglePass;        // 0x0
        public static VLB.RenderingMode GPUInstancing;        // 0x0
        public static VLB.RenderingMode SRPBatcher;        // 0x0

    }

    // TypeToken: 0x200001B
    public struct RenderQueue
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static VLB.RenderQueue Custom;        // 0x0
        public static VLB.RenderQueue Background;        // 0x0
        public static VLB.RenderQueue Geometry;        // 0x0
        public static VLB.RenderQueue AlphaTest;        // 0x0
        public static VLB.RenderQueue GeometryLast;        // 0x0
        public static VLB.RenderQueue Transparent;        // 0x0
        public static VLB.RenderQueue Overlay;        // 0x0

    }

    // TypeToken: 0x200001C
    public struct Dimensions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static VLB.Dimensions Dim3D;        // 0x0
        public static VLB.Dimensions Dim2D;        // 0x0

    }

    // TypeToken: 0x200001D
    public struct PlaneAlignment
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static VLB.PlaneAlignment Surface;        // 0x0
        public static VLB.PlaneAlignment Beam;        // 0x0

    }

    // TypeToken: 0x200001E
    public struct DynamicOcclusionUpdateRate
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static VLB.DynamicOcclusionUpdateRate Never;        // 0x0
        public static VLB.DynamicOcclusionUpdateRate OnEnable;        // 0x0
        public static VLB.DynamicOcclusionUpdateRate OnBeamMove;        // 0x0
        public static VLB.DynamicOcclusionUpdateRate EveryXFrames;        // 0x0
        public static VLB.DynamicOcclusionUpdateRate OnBeamMoveAndEveryXFrames;        // 0x0

    }

    // TypeToken: 0x200001F
    public struct ParticlesDirection
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static VLB.ParticlesDirection Random;        // 0x0
        public static VLB.ParticlesDirection LocalSpace;        // 0x0
        public static VLB.ParticlesDirection WorldSpace;        // 0x0

    }

    // TypeToken: 0x2000020
    public class HighlightNullAttribute : PropertyAttribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000021
    public class MaterialManager
    {
        // Fields
        public static System.Int32 staticPropertiesCount;        // 0x0
        public static UnityEngine.MaterialPropertyBlock materialPropertyBlock;        // 0x0
        private static readonly UnityEngine.Rendering.BlendMode[] BlendingMode_SrcFactor;        // 0x8
        private static readonly UnityEngine.Rendering.BlendMode[] BlendingMode_DstFactor;        // 0x10
        private static readonly System.Boolean[] BlendingMode_AlphaAsBlack;        // 0x18
        private static readonly System.Collections.Hashtable ms_MaterialsGroup;        // 0x20

        // Methods
        private UnityEngine.Material NewMaterialTransient(System.Boolean gpuInstanced) { }
        private UnityEngine.Material NewMaterialPersistent(UnityEngine.Shader shader, System.Boolean gpuInstanced) { }
        private UnityEngine.Material GetInstancedMaterial(System.UInt32 groupID, VLB.MaterialManager.StaticProperties& staticProps) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200002B
    public class MaterialModifier
    {
    }

    // TypeToken: 0x200002E
    public struct MinMaxRangeFloat
    {
        // Fields
        private System.Single m_MinValue;        // 0x10
        private System.Single m_MaxValue;        // 0x14

        // Methods
        private System.Void .ctor(System.Single min, System.Single max) { }
        private System.Single get_minValue() { }
        private System.Single get_maxValue() { }
        private System.Single get_randomValue() { }
        private UnityEngine.Vector2 get_asVector2() { }
        private System.Single GetLerpedValue(System.Single lerp01) { }

    }

    // TypeToken: 0x200002F
    public class MinMaxRangeAttribute : Attribute
    {
        // Fields
        private readonly System.Single <minValue>k__BackingField;        // 0x10
        private readonly System.Single <maxValue>k__BackingField;        // 0x14

        // Methods
        private System.Void .ctor(System.Single min, System.Single max) { }
        private System.Single get_minValue() { }
        private System.Single get_maxValue() { }

    }

    // TypeToken: 0x2000030
    public class PlatformHelper
    {
        // Methods
        private System.String GetCurrentPlatformSuffix() { }
        private System.String GetPlatformSuffix(UnityEngine.RuntimePlatform platform) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000031
    public class PolygonHelper : MonoBehaviour
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000033
    public class ShaderKeywords
    {
        // Fields
        public static System.String UseFog;        // 0x0
        public static System.String AlphaAsBlack;        // 0x0
        public static System.String ColorGradientMatrixLow;        // 0x0
        public static System.String ColorGradientMatrixHigh;        // 0x0
        public static System.String DepthBlend;        // 0x0
        public static System.String Noise3D;        // 0x0
        public static System.String OcclusionClippingPlane;        // 0x0
        public static System.String OcclusionDepthTexture;        // 0x0
        public static System.String MeshSkewing;        // 0x0
        public static System.String ShaderAccuracyHigh;        // 0x0

    }

    // TypeToken: 0x2000034
    public class ShaderProperties
    {
        // Fields
        public static readonly System.Int32 ConeParams0;        // 0x0
        public static readonly System.Int32 ConeParams1;        // 0x4
        public static readonly System.Int32 TiltVectorX;        // 0x8
        public static readonly System.Int32 TiltVectorY;        // 0xC
        public static readonly System.Int32 DistanceFadeStart;        // 0x10
        public static readonly System.Int32 DistanceFadeEnd;        // 0x14
        public static readonly System.Int32 DistanceFadeStartSecond;        // 0x18
        public static readonly System.Int32 DistanceFadeEndSecond;        // 0x1C
        public static readonly System.Int32 NoiseVelocity;        // 0x20
        public static readonly System.Int32 NoiseScale;        // 0x24
        public static readonly System.Int32 DepthBlendCapOff;        // 0x28
        public static readonly System.Int32 BlendMode;        // 0x2C
        public static readonly System.Int32 FogIntensity;        // 0x30
        public static readonly System.Int32 ClippingPlaneTransition;        // 0x34
        public static readonly System.Int32 UseClippingPlane;        // 0x38
        public static readonly System.Int32 FadeOutFactor;        // 0x3C
        public static readonly System.Int32 ConeSlopeCosSin;        // 0x40
        public static readonly System.Int32 ConeRadius;        // 0x44
        public static readonly System.Int32 ConeGeomProps;        // 0x48
        public static readonly System.Int32 ColorFlat;        // 0x4C
        public static readonly System.Int32 AlphaInside;        // 0x50
        public static readonly System.Int32 AlphaOutside;        // 0x54
        public static readonly System.Int32 HDRPExposureWeight;        // 0x58
        public static readonly System.Int32 AttenuationLerpLinearQuad;        // 0x5C
        public static readonly System.Int32 DistanceFallOff;        // 0x60
        public static readonly System.Int32 DistanceCamClipping;        // 0x64
        public static readonly System.Int32 FresnelPow;        // 0x68
        public static readonly System.Int32 GlareBehind;        // 0x6C
        public static readonly System.Int32 GlareFrontal;        // 0x70
        public static readonly System.Int32 DrawCap;        // 0x74
        public static readonly System.Int32 DepthBlendDistance;        // 0x78
        public static readonly System.Int32 NoiseVelocityAndScale;        // 0x7C
        public static readonly System.Int32 NoiseParam;        // 0x80
        public static readonly System.Int32 CameraParams;        // 0x84
        public static readonly System.Int32 ColorGradientMatrix;        // 0x88
        public static readonly System.Int32 LocalToWorldMatrix;        // 0x8C
        public static readonly System.Int32 WorldToLocalMatrix;        // 0x90
        public static readonly System.Int32 BlendSrcFactor;        // 0x94
        public static readonly System.Int32 BlendDstFactor;        // 0x98
        public static readonly System.Int32 DynamicOcclusionClippingPlaneWS;        // 0x9C
        public static readonly System.Int32 DynamicOcclusionClippingPlaneProps;        // 0xA0
        public static readonly System.Int32 DynamicOcclusionDepthTexture;        // 0xA4
        public static readonly System.Int32 DynamicOcclusionDepthProps;        // 0xA8
        public static readonly System.Int32 LocalForwardDirection;        // 0xAC
        public static readonly System.Int32 TiltVector;        // 0xB0
        public static readonly System.Int32 AdditionalClippingPlaneWS;        // 0xB4
        public static readonly System.Int32 ParticlesTintColor;        // 0xB8
        public static readonly System.Int32 GlobalUsesReversedZBuffer;        // 0xBC
        public static readonly System.Int32 GlobalNoiseTex3D;        // 0xC0
        public static readonly System.Int32 GlobalNoiseCustomTime;        // 0xC4
        public static readonly System.Int32 GlobalDitheringFactor;        // 0xC8
        public static readonly System.Int32 GlobalDitheringNoiseTex;        // 0xCC

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000035
    public class SpotLightHelper
    {
        // Methods
        private System.Void GetCullingDistance(UnityEngine.Light light, System.Single& cullingDistance, System.Single& falloffDistance) { }
        private System.Single GetIntensity(UnityEngine.Light light) { }
        private System.Single GetSpotAngle(UnityEngine.Light light) { }
        private System.Single GetFallOffEnd(UnityEngine.Light light) { }

    }

    // TypeToken: 0x2000036
    public class SRPHelper
    {
        // Fields
        private static VLB.SRPHelper.RenderPipeline m_RenderPipelineCached;        // 0x0

        // Methods
        private VLB.SRPHelper.RenderPipeline get_renderPipelineType() { }
        private VLB.SRPHelper.RenderPipeline ComputeRenderPipeline() { }
        private System.Boolean IsUsingCustomRenderPipeline() { }
        private System.Void RegisterOnBeginCameraRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Camera> cb) { }
        private System.Void UnregisterOnBeginCameraRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Camera> cb) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000038
    public class TransformUtils
    {
        // Methods
        private VLB.TransformUtils.Packed GetWorldPacked(UnityEngine.Transform self) { }

    }

    // TypeToken: 0x200003A
    public class Utils
    {
        // Fields
        private static System.Single kEpsilon;        // 0x0
        private static System.Int32 kFloatPackingHighMinShaderLevel;        // 0x0
        private static VLB.Utils.FloatPackingPrecision ms_FloatPackingPrecision;        // 0x0

        // Methods
        private System.Single ComputeConeRadiusEnd(System.Single fallOffEnd, System.Single spotAngle) { }
        private System.Single ComputeSpotAngle(System.Single fallOffEnd, System.Single coneRadiusEnd) { }
        private System.Void Swap(T& a, T& b) { }
        private System.String GetPath(UnityEngine.Transform current) { }
        private T NewWithComponent(System.String name) { }
        private T GetOrAddComponent(UnityEngine.GameObject self) { }
        private T GetOrAddComponent(UnityEngine.MonoBehaviour self) { }
        private System.Void ForeachComponentsOnlyInChildren(UnityEngine.GameObject self, System.Action<T> lambda, System.Boolean includeInactive) { }
        private System.Boolean HasFlag(System.Enum mask, System.Enum flags) { }
        private UnityEngine.Vector2 xy(UnityEngine.Vector3 aVector) { }
        private UnityEngine.Vector2 xz(UnityEngine.Vector3 aVector) { }
        private UnityEngine.Vector2 yz(UnityEngine.Vector3 aVector) { }
        private UnityEngine.Vector2 yx(UnityEngine.Vector3 aVector) { }
        private UnityEngine.Vector2 zx(UnityEngine.Vector3 aVector) { }
        private UnityEngine.Vector2 zy(UnityEngine.Vector3 aVector) { }
        private System.Boolean Approximately(System.Single a, System.Single b, System.Single epsilon) { }
        private System.Boolean Approximately(UnityEngine.Vector2 a, UnityEngine.Vector2 b, System.Single epsilon) { }
        private System.Boolean Approximately(UnityEngine.Vector3 a, UnityEngine.Vector3 b, System.Single epsilon) { }
        private System.Boolean Approximately(UnityEngine.Vector4 a, UnityEngine.Vector4 b, System.Single epsilon) { }
        private UnityEngine.Vector4 AsVector4(UnityEngine.Vector3 vec3, System.Single w) { }
        private UnityEngine.Vector4 PlaneEquation(UnityEngine.Vector3 normalizedNormal, UnityEngine.Vector3 pt) { }
        private System.Single GetVolumeCubic(UnityEngine.Bounds self) { }
        private System.Single GetMaxArea2D(UnityEngine.Bounds self) { }
        private UnityEngine.Color Opaque(UnityEngine.Color self) { }
        private UnityEngine.Color ComputeComplementaryColor(UnityEngine.Color self, System.Boolean blackAndWhite) { }
        private UnityEngine.Plane TranslateCustom(UnityEngine.Plane plane, UnityEngine.Vector3 translation) { }
        private UnityEngine.Vector3 ClosestPointOnPlaneCustom(UnityEngine.Plane plane, UnityEngine.Vector3 point) { }
        private System.Boolean IsAlmostZero(System.Single f) { }
        private System.Boolean IsValid(UnityEngine.Plane plane) { }
        private System.Void SetKeywordEnabled(UnityEngine.Material mat, System.String name, System.Boolean enabled) { }
        private System.Void SetShaderKeywordEnabled(System.String name, System.Boolean enabled) { }
        private UnityEngine.Matrix4x4 SampleInMatrix(UnityEngine.Gradient self, System.Int32 floatPackingPrecision) { }
        private UnityEngine.Color[] SampleInArray(UnityEngine.Gradient self, System.Int32 samplesCount) { }
        private UnityEngine.Vector4 Vector4_Floor(UnityEngine.Vector4 vec) { }
        private System.Single PackToFloat(UnityEngine.Color color, System.Int32 floatPackingPrecision) { }
        private VLB.Utils.FloatPackingPrecision GetFloatPackingPrecision() { }
        private System.Void MarkCurrentSceneDirty() { }
        private System.Void MarkObjectDirty(UnityEngine.Object obj) { }

    }

    // TypeToken: 0x200003C
    public class Version
    {
        // Fields
        public static System.Int32 Current;        // 0x0

    }

    // TypeToken: 0x200003D
    public class VolumetricLightBeam : MonoBehaviour
    {
        // Fields
        public UnityEngine.PlatformLayers platformLayers;        // 0x18
        public static System.String ClassName;        // 0x0
        public System.Boolean colorFromLight;        // 0x1C
        public VLB.ColorMode colorMode;        // 0x20
        public UnityEngine.Color color;        // 0x24
        public UnityEngine.Gradient colorGradient;        // 0x38
        public System.Boolean intensityFromLight;        // 0x40
        public System.Boolean intensityModeAdvanced;        // 0x41
        public System.Single intensityInside;        // 0x44
        public System.Single intensityOutside;        // 0x48
        public System.Single intensityMultiplier;        // 0x4C
        public System.Single hdrpExposureWeight;        // 0x50
        public VLB.BlendingMode blendingMode;        // 0x54
        public System.Boolean spotAngleFromLight;        // 0x58
        public System.Single spotAngle;        // 0x5C
        public System.Single spotAngleMultiplier;        // 0x60
        public System.Single coneRadiusStart;        // 0x64
        public VLB.ShaderAccuracy shaderAccuracy;        // 0x68
        public VLB.MeshType geomMeshType;        // 0x6C
        public System.Int32 geomCustomSides;        // 0x70
        public System.Int32 geomCustomSegments;        // 0x74
        public UnityEngine.Vector3 skewingLocalForwardDirection;        // 0x78
        public System.Boolean useAdditionalClippingPlane;        // 0x84
        public UnityEngine.Transform clippingPlaneTransform;        // 0x88
        public UnityEngine.Vector3 clippingPlanePosition;        // 0x90
        public UnityEngine.Quaternion clippingPlaneRotation;        // 0x9C
        public System.Single clippingPlaneTransition;        // 0xAC
        public System.Boolean geomCap;        // 0xB0
        public VLB.AttenuationEquation attenuationEquation;        // 0xB4
        public System.Single attenuationCustomBlending;        // 0xB8
        public System.Single fallOffStart;        // 0xBC
        public System.Single fallOffEnd;        // 0xC0
        public System.Boolean fallOffEndFromLight;        // 0xC4
        private UnityEngine.Light m_CachedLightSpot;        // 0xC8
        public System.Single fallOffCap;        // 0xD0
        public System.Single fallOffEndMultiplier;        // 0xD4
        public System.Boolean depthBlendCapOff;        // 0xD8
        public System.Single depthBlendDistance;        // 0xDC
        public System.Single cameraClippingDistance;        // 0xE0
        public System.Single glareFrontal;        // 0xE4
        public System.Single glareBehind;        // 0xE8
        public System.Single fresnelPow;        // 0xEC
        public VLB.NoiseMode noiseMode;        // 0xF0
        public System.Single noiseIntensity;        // 0xF4
        public System.Boolean noiseScaleUseGlobal;        // 0xF8
        public System.Boolean noiseScaleUseSeparateAxis;        // 0xF9
        public UnityEngine.Vector3 noiseScalesLocal;        // 0xFC
        public System.Single noiseScaleLocal;        // 0x108
        public System.Boolean noiseVelocityUseGlobal;        // 0x10C
        public UnityEngine.Vector3 noiseVelocityLocal;        // 0x110
        public System.Boolean fadeOutFromLight;        // 0x11C
        public System.Single fadeOutBeginSecond;        // 0x120
        public System.Single fadeOutEndSecond;        // 0x124
        public System.Boolean useFog;        // 0x128
        public System.Single fogIntensity;        // 0x12C
        public VLB.Dimensions dimensions;        // 0x130
        public UnityEngine.Vector2 tiltFactor;        // 0x134
        private System.Int32 pluginVersion;        // 0x13C
        private System.Boolean _TrackChangesDuringPlaytime;        // 0x140
        private System.Int32 _SortingLayerID;        // 0x144
        private System.Int32 _SortingOrder;        // 0x148
        private System.Single _FadeOutBegin;        // 0x14C
        private System.Single _FadeOutEnd;        // 0x150
        private System.UInt32 <_INTERNAL_InstancedMaterialGroupID>k__BackingField;        // 0x154
        public VLB.BeamGeometry m_BeamGeom;        // 0x158
        public System.Boolean matIsPersistent;        // 0x160
        private UnityEngine.Coroutine m_CoPlaytimeUpdate;        // 0x168

        // Methods
        private VLB.ColorMode get_usedColorMode() { }
        private System.Boolean get_useColorFromAttachedLightSpot() { }
        private System.Boolean get_useColorTemperatureFromAttachedLightSpot() { }
        private System.Single get_alphaInside() { }
        private System.Void set_alphaInside(System.Single value) { }
        private System.Single get_alphaOutside() { }
        private System.Void set_alphaOutside(System.Single value) { }
        private System.Single get_intensityGlobal() { }
        private System.Void set_intensityGlobal(System.Single value) { }
        private System.Boolean get_useIntensityFromAttachedLightSpot() { }
        private System.Void GetInsideAndOutsideIntensity(System.Single& inside, System.Single& outside) { }
        private System.Boolean get_useSpotAngleFromAttachedLightSpot() { }
        private System.Single get_coneAngle() { }
        private System.Single get_coneRadiusEnd() { }
        private System.Void set_coneRadiusEnd(System.Single value) { }
        private System.Single get_coneVolume() { }
        private System.Single get_coneApexOffsetZ() { }
        private UnityEngine.Vector3 get_coneApexPositionLocal() { }
        private UnityEngine.Vector3 get_coneApexPositionGlobal() { }
        private System.Int32 get_geomSides() { }
        private System.Void set_geomSides(System.Int32 value) { }
        private System.Int32 get_geomSegments() { }
        private System.Void set_geomSegments(System.Int32 value) { }
        private UnityEngine.Vector3 get_skewingLocalForwardDirectionNormalized() { }
        private System.Boolean get_canHaveMeshSkewing() { }
        private System.Boolean get_hasMeshSkewing() { }
        private UnityEngine.Vector4 get_additionalClippingPlane() { }
        private System.Single get_attenuationLerpLinearQuad() { }
        private System.Single get_fadeStart() { }
        private System.Void set_fadeStart(System.Single value) { }
        private System.Single get_fadeEnd() { }
        private System.Void set_fadeEnd(System.Single value) { }
        private System.Boolean get_fadeEndFromLight() { }
        private System.Void set_fadeEndFromLight(System.Boolean value) { }
        private UnityEngine.Light get_lightSpotAttached() { }
        private System.Boolean get_useFallOffEndFromAttachedLightSpot() { }
        private System.Single get_maxGeometryDistance() { }
        private System.Boolean get_isNoiseEnabled() { }
        private System.Boolean get_noiseEnabled() { }
        private System.Void set_noiseEnabled(System.Boolean value) { }
        private System.Single get_cullingDistance() { }
        private System.Single get_fadeOutBegin() { }
        private System.Void set_fadeOutBegin(System.Single value) { }
        private System.Single get_fadeOutEnd() { }
        private System.Void set_fadeOutEnd(System.Single value) { }
        private System.Boolean get_isFadeOutEnabled() { }
        private System.Boolean get_isTilted() { }
        private System.Int32 get_sortingLayerID() { }
        private System.Void set_sortingLayerID(System.Int32 value) { }
        private System.String get_sortingLayerName() { }
        private System.Void set_sortingLayerName(System.String value) { }
        private System.Int32 get_sortingOrder() { }
        private System.Void set_sortingOrder(System.Int32 value) { }
        private System.Boolean get_trackChangesDuringPlaytime() { }
        private System.Void set_trackChangesDuringPlaytime(System.Boolean value) { }
        private System.Boolean get_isCurrentlyTrackingChanges() { }
        private System.Boolean get_hasGeometry() { }
        private UnityEngine.Bounds get_bounds() { }
        private System.Int32 get_blendingModeAsInt() { }
        private UnityEngine.Quaternion get_beamInternalLocalRotation() { }
        private UnityEngine.Vector3 get_beamLocalForward() { }
        private UnityEngine.Vector3 get_beamGlobalForward() { }
        private UnityEngine.Vector3 get_lossyScale() { }
        private System.Single get_raycastDistance() { }
        private UnityEngine.Vector3 ComputeRaycastGlobalVector(UnityEngine.Vector3 localVec) { }
        private UnityEngine.Vector3 get_raycastGlobalForward() { }
        private UnityEngine.Vector3 get_raycastGlobalUp() { }
        private UnityEngine.Vector3 get_raycastGlobalRight() { }
        private System.Int32 get__INTERNAL_pluginVersion() { }
        private System.Void SetFadeOutValue(System.Single& propToChange, System.Single value) { }
        private System.UInt32 get__INTERNAL_InstancedMaterialGroupID() { }
        private System.Void set__INTERNAL_InstancedMaterialGroupID(System.UInt32 value) { }
        private System.String get_meshStats() { }
        private System.Int32 get_meshVerticesCount() { }
        private System.Int32 get_meshTrianglesCount() { }
        private System.Void .ctor() { }

    }

}

