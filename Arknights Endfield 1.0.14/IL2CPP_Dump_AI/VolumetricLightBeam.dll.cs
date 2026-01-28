// ========================================================
// Dumped by @desirepro
// Assembly: VolumetricLightBeam.dll
// Classes:  64
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: EditorPrefsStrings
TYPE:  class
TOKEN: 0x2000002
FIELDS:
METHODS:
END_CLASS

CLASS: Help
TYPE:  class
TOKEN: 0x200000B
FIELDS:
  private   static  System.String                   UrlBase  // 0x0
  private   static  System.String                   UrlSuffix  // 0x0
  public    static  System.String                   UrlBeam  // 0x0
  public    static  System.String                   UrlDustParticles  // 0x0
  public    static  System.String                   UrlDynamicOcclusionRaycasting  // 0x0
  public    static  System.String                   UrlDynamicOcclusionDepthBuffer  // 0x0
  public    static  System.String                   UrlTriggerZone  // 0x0
  public    static  System.String                   UrlSkewingHandle  // 0x0
  public    static  System.String                   UrlEffectFlicker  // 0x0
  public    static  System.String                   UrlEffectPulse  // 0x0
  public    static  System.String                   UrlConfig  // 0x0
METHODS:
END_CLASS

CLASS: Internal
TYPE:  class
TOKEN: 0x200000C
FIELDS:
METHODS:
  UnityEngine.HideFlags get_ProceduralObjectsHideFlags()
END_CLASS

CLASS: Beam
TYPE:  class
TOKEN: 0x200000D
FIELDS:
  public    static  VLB.ColorMode                   ColorModeDefault  // 0x0
  public    static  System.Single                   MultiplierDefault  // 0x0
  public    static  System.Single                   MultiplierMin  // 0x0
  public    static  System.Single                   IntensityDefault  // 0x0
  public    static  System.Single                   IntensityMin  // 0x0
  public    static  System.Single                   HDRPExposureWeightDefault  // 0x0
  public    static  System.Single                   HDRPExposureWeightMin  // 0x0
  public    static  System.Single                   HDRPExposureWeightMax  // 0x0
  public    static  System.Single                   SpotAngleDefault  // 0x0
  public    static  System.Single                   SpotAngleMin  // 0x0
  public    static  System.Single                   SpotAngleMax  // 0x0
  public    static  System.Single                   ConeRadiusStart  // 0x0
  public    static  VLB.MeshType                    GeomMeshType  // 0x0
  public    static  System.Int32                    GeomSidesDefault  // 0x0
  public    static  System.Int32                    GeomSidesMin  // 0x0
  public    static  System.Int32                    GeomSidesMax  // 0x0
  public    static  System.Int32                    GeomSegmentsDefault  // 0x0
  public    static  System.Int32                    GeomSegmentsMin  // 0x0
  public    static  System.Int32                    GeomSegmentsMax  // 0x0
  public    static  System.Boolean                  GeomCap  // 0x0
  public    static  VLB.AttenuationEquation         AttenuationEquationDefault  // 0x0
  public    static  System.Single                   AttenuationCustomBlendingDefault  // 0x0
  public    static  System.Single                   AttenuationCustomBlendingMin  // 0x0
  public    static  System.Single                   AttenuationCustomBlendingMax  // 0x0
  public    static  System.Single                   FallOffStart  // 0x0
  public    static  System.Single                   FallOffEnd  // 0x0
  public    static  System.Single                   FallOffDistancesMinThreshold  // 0x0
  public    static  System.Single                   DepthBlendDistance  // 0x0
  public    static  System.Single                   CameraClippingDistance  // 0x0
  public    static  System.Single                   FresnelPowMaxValue  // 0x0
  public    static  System.Single                   FresnelPow  // 0x0
  public    static  System.Single                   GlareFrontalDefault  // 0x0
  public    static  System.Single                   GlareBehindDefault  // 0x0
  public    static  System.Single                   GlareMin  // 0x0
  public    static  System.Single                   GlareMax  // 0x0
  public    static  VLB.NoiseMode                   NoiseModeDefault  // 0x0
  public    static  System.Single                   NoiseIntensityMin  // 0x0
  public    static  System.Single                   NoiseIntensityMax  // 0x0
  public    static  System.Single                   NoiseIntensityDefault  // 0x0
  public    static  System.Single                   NoiseScaleMin  // 0x0
  public    static  System.Single                   NoiseScaleMax  // 0x0
  public    static readonly UnityEngine.Vector3             NoiseScalesDefault  // 0x0
  public    static  System.Single                   NoiseScaleDefault  // 0x0
  public    static  VLB.BlendingMode                BlendingModeDefault  // 0x0
  public    static  VLB.ShaderAccuracy              ShaderAccuracyDefault  // 0x0
  public    static  System.Single                   FadeOutBeginDefault  // 0x0
  public    static  System.Single                   FadeOutEndDefault  // 0x0
  public    static  System.Single                   FadeOutBeginSecondDefault  // 0x0
  public    static  System.Single                   FadeOutEndSecondDefault  // 0x0
  public    static  VLB.Dimensions                  DimensionsDefault  // 0x0
  public    static  UnityEngine.Transform           ClippingPlaneTransformDefault  // 0x0
  public    static readonly UnityEngine.Color               FlatColor  // 0xC
  public    static readonly UnityEngine.Vector3             NoiseVelocityDefault  // 0x1C
  public    static readonly UnityEngine.Vector2             TiltDefault  // 0x28
  public    static readonly UnityEngine.Vector3             SkewingLocalForwardDirectionDefault  // 0x30
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: DustParticles
TYPE:  class
TOKEN: 0x200000E
FIELDS:
  public    static  System.Single                   AlphaDefault  // 0x0
  public    static  System.Single                   SizeDefault  // 0x0
  public    static  VLB.ParticlesDirection          DirectionDefault  // 0x0
  public    static  System.Single                   DensityDefault  // 0x0
  public    static  System.Single                   DensityMin  // 0x0
  public    static  System.Single                   DensityMax  // 0x0
  public    static  System.Boolean                  CullingEnabledDefault  // 0x0
  public    static  System.Single                   CullingMaxDistanceDefault  // 0x0
  public    static  System.Single                   CullingMaxDistanceMin  // 0x0
  public    static readonly UnityEngine.Vector3             VelocityDefault  // 0x0
  public    static readonly VLB.MinMaxRangeFloat            SpawnDistanceRangeDefault  // 0xC
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: DynOcclusion
TYPE:  class
TOKEN: 0x200000F
FIELDS:
  public    static  System.Single                   FadeDistanceToSurfaceDefault  // 0x0
  public    static  VLB.DynamicOcclusionUpdateRate  UpdateRateDefault  // 0x0
  public    static  System.Int32                    WaitFramesCountDefault  // 0x0
  public    static  VLB.Dimensions                  RaycastingDimensionsDefault  // 0x0
  public    static  System.Boolean                  RaycastingConsiderTriggersDefault  // 0x0
  public    static  System.Single                   RaycastingMinOccluderAreaDefault  // 0x0
  public    static  System.Single                   RaycastingMinSurfaceRatioDefault  // 0x0
  public    static  System.Single                   RaycastingMinSurfaceRatioMin  // 0x0
  public    static  System.Single                   RaycastingMinSurfaceRatioMax  // 0x0
  public    static  System.Single                   RaycastingMaxSurfaceDotDefault  // 0x0
  public    static  System.Single                   RaycastingMaxSurfaceAngleMin  // 0x0
  public    static  System.Single                   RaycastingMaxSurfaceAngleMax  // 0x0
  public    static  VLB.PlaneAlignment              RaycastingPlaneAlignmentDefault  // 0x0
  public    static  System.Single                   RaycastingPlaneOffsetDefault  // 0x0
  public    static  System.Int32                    DepthBufferDepthMapResolutionDefault  // 0x0
  public    static  System.Boolean                  DepthBufferOcclusionCullingDefault  // 0x0
  public    static readonly UnityEngine.LayerMask           LayerMaskDefault  // 0x0
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: Config
TYPE:  class
TOKEN: 0x2000010
FIELDS:
  public    static  System.Boolean                  GeometryOverrideLayerDefault  // 0x0
  public    static  System.Int32                    GeometryLayerIDDefault  // 0x0
  public    static  System.String                   GeometryTagDefault  // 0x0
  public    static  System.String                   FadeOutCameraTagDefault  // 0x0
  public    static  VLB.RenderQueue                 GeometryRenderQueueDefault  // 0x0
  public    static  VLB.RenderPipeline              GeometryRenderPipelineDefault  // 0x0
  public    static  VLB.RenderingMode               GeometryRenderingModeDefault  // 0x0
  public    static  System.Int32                    Noise3DSizeDefault  // 0x0
  public    static  System.Int32                    SharedMeshSides  // 0x0
  public    static  System.Int32                    SharedMeshSegments  // 0x0
  public    static  System.Single                   DitheringFactor  // 0x0
  public    static  System.Boolean                  UseLightColorTemperatureDefault  // 0x0
  public    static  System.Boolean                  FeatureEnabledDefault  // 0x0
  public    static  VLB.FeatureEnabledColorGradient FeatureEnabledColorGradientDefault  // 0x0
METHODS:
END_CLASS

CLASS: BlendingMode
TYPE:  struct
TOKEN: 0x2000022
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  VLB.MaterialManager.BlendingModeAdditive  // 0x0
  public    static  VLB.MaterialManager.BlendingModeSoftAdditive  // 0x0
  public    static  VLB.MaterialManager.BlendingModeTraditionalTransparency  // 0x0
  public    static  VLB.MaterialManager.BlendingModeCount  // 0x0
METHODS:
END_CLASS

CLASS: ColorGradient
TYPE:  struct
TOKEN: 0x2000023
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  VLB.MaterialManager.ColorGradientOff  // 0x0
  public    static  VLB.MaterialManager.ColorGradientMatrixLow  // 0x0
  public    static  VLB.MaterialManager.ColorGradientMatrixHigh  // 0x0
  public    static  VLB.MaterialManager.ColorGradientCount  // 0x0
METHODS:
END_CLASS

CLASS: DepthBlend
TYPE:  struct
TOKEN: 0x2000024
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  VLB.MaterialManager.DepthBlend  Off  // 0x0
  public    static  VLB.MaterialManager.DepthBlend  On  // 0x0
  public    static  VLB.MaterialManager.DepthBlend  Count  // 0x0
METHODS:
END_CLASS

CLASS: DynamicOcclusion
TYPE:  struct
TOKEN: 0x2000025
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  VLB.MaterialManager.DynamicOcclusionOff  // 0x0
  public    static  VLB.MaterialManager.DynamicOcclusionClippingPlane  // 0x0
  public    static  VLB.MaterialManager.DynamicOcclusionDepthTexture  // 0x0
  public    static  VLB.MaterialManager.DynamicOcclusionCount  // 0x0
METHODS:
END_CLASS

CLASS: MeshSkewing
TYPE:  struct
TOKEN: 0x2000026
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  VLB.MaterialManager.MeshSkewing Off  // 0x0
  public    static  VLB.MaterialManager.MeshSkewing On  // 0x0
  public    static  VLB.MaterialManager.MeshSkewing Count  // 0x0
METHODS:
END_CLASS

CLASS: Noise3D
TYPE:  struct
TOKEN: 0x2000027
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  VLB.MaterialManager.Noise3D     Off  // 0x0
  public    static  VLB.MaterialManager.Noise3D     On  // 0x0
  public    static  VLB.MaterialManager.Noise3D     Count  // 0x0
METHODS:
END_CLASS

CLASS: ShaderAccuracy
TYPE:  struct
TOKEN: 0x2000028
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  VLB.MaterialManager.ShaderAccuracyFast  // 0x0
  public    static  VLB.MaterialManager.ShaderAccuracyHigh  // 0x0
  public    static  VLB.MaterialManager.ShaderAccuracyCount  // 0x0
METHODS:
END_CLASS

CLASS: StaticProperties
TYPE:  struct
TOKEN: 0x2000029
FIELDS:
  public            System.Boolean                  useFog  // 0x10
  public            VLB.MaterialManager.BlendingModeblendingMode  // 0x14
  public            VLB.MaterialManager.Noise3D     noise3D  // 0x18
  public            VLB.MaterialManager.DepthBlend  depthBlend  // 0x1C
  public            VLB.MaterialManager.ColorGradientcolorGradient  // 0x20
  public            VLB.MaterialManager.DynamicOcclusiondynamicOcclusion  // 0x24
  public            VLB.MaterialManager.MeshSkewing meshSkewing  // 0x28
  public            VLB.MaterialManager.ShaderAccuracyshaderAccuracy  // 0x2C
METHODS:
  System.Int32 get_blendingModeID()
  System.Int32 get_noise3DID()
  System.Int32 get_depthBlendID()
  System.Int32 get_colorGradientID()
  System.Int32 get_dynamicOcclusionID()
  System.Int32 get_meshSkewingID()
  System.Int32 get_shaderAccuracyID()
  System.Int32 get_materialID()
  System.Void ApplyToMaterial(UnityEngine.Material mat)
END_CLASS

CLASS: MaterialsGroup
TYPE:  class
TOKEN: 0x200002A
FIELDS:
  public    readonly UnityEngine.Material[]          materials  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Callback
TYPE:  class
TOKEN: 0x200002C
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(VLB.MaterialModifier.Interface owner)
  System.IAsyncResult BeginInvoke(VLB.MaterialModifier.Interface owner, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: Interface
TYPE:  interface
TOKEN: 0x200002D
FIELDS:
METHODS:
  System.Void SetMaterialProp(System.Int32 nameID, System.Single value)
  System.Void SetMaterialProp(System.Int32 nameID, UnityEngine.Vector4 value)
  System.Void SetMaterialProp(System.Int32 nameID, UnityEngine.Color value)
  System.Void SetMaterialProp(System.Int32 nameID, UnityEngine.Matrix4x4 value)
  System.Void SetMaterialProp(System.Int32 nameID, UnityEngine.Texture value)
END_CLASS

CLASS: Plane2D
TYPE:  struct
TOKEN: 0x2000032
FIELDS:
  public            UnityEngine.Vector2             normal  // 0x10
  public            System.Single                   distance  // 0x18
METHODS:
  System.Single Distance(UnityEngine.Vector2 point)
  UnityEngine.Vector2 ClosestPoint(UnityEngine.Vector2 pt)
  UnityEngine.Vector2 Intersect(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2)
  System.Boolean GetSide(UnityEngine.Vector2 point)
  VLB.PolygonHelper.Plane2D FromPoints(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2)
  VLB.PolygonHelper.Plane2D FromNormalAndPoint(UnityEngine.Vector3 normalizedNormal, UnityEngine.Vector3 p1)
  System.Void Flip()
  UnityEngine.Vector2[] CutConvex(UnityEngine.Vector2[] poly)
  System.String ToString()
END_CLASS

CLASS: RenderPipeline
TYPE:  struct
TOKEN: 0x2000037
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  VLB.SRPHelper.RenderPipeline    HGRP  // 0x0
  public    static  VLB.SRPHelper.RenderPipeline    Undefined  // 0x0
  public    static  VLB.SRPHelper.RenderPipeline    BuiltIn  // 0x0
  public    static  VLB.SRPHelper.RenderPipeline    URP  // 0x0
  public    static  VLB.SRPHelper.RenderPipeline    LWRP  // 0x0
  public    static  VLB.SRPHelper.RenderPipeline    HDRP  // 0x0
METHODS:
END_CLASS

CLASS: Packed
TYPE:  struct
TOKEN: 0x2000039
FIELDS:
  public            UnityEngine.Vector3             position  // 0x10
  public            UnityEngine.Quaternion          rotation  // 0x1C
  public            UnityEngine.Vector3             lossyScale  // 0x2C
METHODS:
  System.Boolean IsSame(UnityEngine.Transform transf)
END_CLASS

CLASS: FloatPackingPrecision
TYPE:  struct
TOKEN: 0x200003B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  VLB.Utils.FloatPackingPrecision High  // 0x0
  public    static  VLB.Utils.FloatPackingPrecision Low  // 0x0
  public    static  VLB.Utils.FloatPackingPrecision Undef  // 0x0
METHODS:
END_CLASS

CLASS: AttachedLightType
TYPE:  struct
TOKEN: 0x200003E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  VLB.VolumetricLightBeam.AttachedLightTypeNoLight  // 0x0
  public    static  VLB.VolumetricLightBeam.AttachedLightTypeOtherLight  // 0x0
  public    static  VLB.VolumetricLightBeam.AttachedLightTypeSpotLight  // 0x0
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=12
TYPE:  struct
TOKEN: 0x2000040
FIELDS:
METHODS:
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

CLASS: Beyond.SourceGenerator.CameraControlConfigAttribute
TYPE:  class
TOKEN: 0x2000005
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.DataNAttribute
TYPE:  class
TOKEN: 0x2000006
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
TOKEN: 0x2000007
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HG.Rendering.Runtime.HGConstantBufferLayoutAttribute
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: VLB.BeamGeometry
TYPE:  class
TOKEN: 0x2000008
EXTENDS: MonoBehaviour
FIELDS:
  private           VLB.VolumetricLightBeam         m_Master  // 0x18
  private           UnityEngine.Matrix4x4           m_ColorGradientMatrix  // 0x20
  private           VLB.MeshType                    m_CurrentMeshType  // 0x60
  private           VLB.MaterialModifier.Callback   m_MaterialModifierCallback  // 0x68
  private           UnityEngine.Coroutine           m_CoFadeOut  // 0x70
  private           UnityEngine.MeshRenderer        <meshRenderer>k__BackingField  // 0x78
  private           UnityEngine.MeshFilter          <meshFilter>k__BackingField  // 0x80
  private           UnityEngine.Mesh                <coneMesh>k__BackingField  // 0x88
  public            UnityEngine.Material            m_CustomMaterial  // 0x90
METHODS:
  UnityEngine.MeshRenderer get_meshRenderer()
  System.Void set_meshRenderer(UnityEngine.MeshRenderer value)
  UnityEngine.MeshFilter get_meshFilter()
  System.Void set_meshFilter(UnityEngine.MeshFilter value)
  UnityEngine.Mesh get_coneMesh()
  System.Void set_coneMesh(UnityEngine.Mesh value)
  System.Boolean get_visible()
  System.Void set_visible(System.Boolean value)
  System.Int32 get_sortingLayerID()
  System.Void set_sortingLayerID(System.Int32 value)
  System.Int32 get_sortingOrder()
  System.Void set_sortingOrder(System.Int32 value)
  System.Boolean get__INTERNAL_IsFadeOutCoroutineRunning()
  System.Void RestartFadeOutCoroutine()
  System.Void StopFadeOutCoroutine()
  System.Void SetMaterialProp(System.Int32 nameID, System.Single value)
  System.Void SetMaterialProp(System.Int32 nameID, UnityEngine.Vector4 value)
  System.Void SetMaterialProp(System.Int32 nameID, UnityEngine.Color value)
  System.Void SetMaterialProp(System.Int32 nameID, UnityEngine.Matrix4x4 value)
  System.Void SetMaterialProp(System.Int32 nameID, UnityEngine.Texture value)
  System.Void .ctor()
END_CLASS

CLASS: VLB.Config
TYPE:  class
TOKEN: 0x2000009
EXTENDS: ScriptableObject
FIELDS:
  public    static  System.String                   ClassName  // 0x0
  public    static  System.String                   kAssetName  // 0x0
  public    static  System.String                   kAssetNameExt  // 0x0
  private   static  VLB.Config                      ms_Instance  // 0x0
  public            UnityEngine.Mesh                sharedMesh  // 0x18
  public            System.Boolean                  featureEnabledDustParticles  // 0x20
  public            System.Boolean                  featureEnabledEffect  // 0x21
  public            System.Boolean                  featureEnabledTriggerZone  // 0x22
  public            System.Boolean                  geometryOverrideLayer  // 0x23
  public            System.Int32                    geometryLayerID  // 0x24
  public            System.String                   geometryTag  // 0x28
  public            System.Int32                    geometryRenderQueue  // 0x30
  private           VLB.RenderPipeline              _RenderPipeline  // 0x34
  private           VLB.RenderingMode               _RenderingMode  // 0x38
  public            System.Single                   ditheringFactor  // 0x3C
  public            System.Boolean                  useLightColorTemperature  // 0x40
  public            System.Int32                    sharedMeshSides  // 0x44
  public            System.Int32                    sharedMeshSegments  // 0x48
  public            UnityEngine.Vector3             globalNoisesScale  // 0x4C
  public            UnityEngine.Vector3             globalNoiseVelocity  // 0x58
  public            System.String                   fadeOutCameraTag  // 0x68
  public            UnityEngine.Texture3D           noiseTexture3D  // 0x70
  public            UnityEngine.ParticleSystem      dustParticlesPrefab  // 0x78
  public            UnityEngine.Texture2D           ditheringNoiseTexture  // 0x80
  public            VLB.FeatureEnabledColorGradient featureEnabledColorGradient  // 0x88
  public            System.Boolean                  featureEnabledDepthBlend  // 0x8C
  public            System.Boolean                  featureEnabledNoise3D  // 0x8D
  public            System.Boolean                  featureEnabledDynamicOcclusion  // 0x8E
  public            System.Boolean                  featureEnabledMeshSkewing  // 0x8F
  public            System.Boolean                  featureEnabledShaderAccuracyHigh  // 0x90
  private           UnityEngine.Shader              _BeamShader  // 0x98
  private           UnityEngine.Transform           m_CachedFadeOutCamera  // 0xA0
  private           System.Int32                    pluginVersion  // 0xA8
  private           UnityEngine.Material            _DummyMaterial  // 0xB0
METHODS:
  VLB.RenderPipeline get_renderPipeline()
  VLB.RenderingMode get_renderingMode()
  VLB.RenderingMode get_actualRenderingMode()
  System.Boolean get_useSinglePassShader()
  System.Boolean get_requiresDoubleSidedMesh()
  UnityEngine.Shader get_beamShader()
  UnityEngine.Transform get_fadeOutCameraTransform()
  System.Boolean get_isHDRPExposureWeightSupported()
  System.Boolean get_hasRenderPipelineMismatch()
  VLB.Config get_Instance()
  System.Void Reset()
  System.Void OnEnable()
  System.Boolean IsSRPBatcherSupported()
  System.Void ForceUpdateFadeOutCamera()
  System.Void OnStartup()
  System.Void RefreshGlobalShaderProperties()
  System.Void ResetInternalData()
  UnityEngine.ParticleSystem NewVolumetricDustParticles()
  System.Void HandleBackwardCompatibility(System.Int32 serializedVersion, System.Int32 newVersion)
  VLB.Config LoadAssetInternal(System.String assetName)
  VLB.Config GetInstance(System.Boolean assertIfNotFound)
  System.Void .ctor()
END_CLASS

CLASS: VLB.Consts
TYPE:  class
TOKEN: 0x200000A
FIELDS:
  public    static  System.String                   PluginFolder  // 0x0
METHODS:
END_CLASS

CLASS: VLB.DummyMaterial
TYPE:  class
TOKEN: 0x2000011
FIELDS:
METHODS:
END_CLASS

CLASS: VLB.FeatureEnabledColorGradient
TYPE:  struct
TOKEN: 0x2000012
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  VLB.FeatureEnabledColorGradient Off  // 0x0
  public    static  VLB.FeatureEnabledColorGradient HighOnly  // 0x0
  public    static  VLB.FeatureEnabledColorGradient HighAndLow  // 0x0
METHODS:
END_CLASS

CLASS: VLB.ColorMode
TYPE:  struct
TOKEN: 0x2000013
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  VLB.ColorMode                   Flat  // 0x0
  public    static  VLB.ColorMode                   Gradient  // 0x0
METHODS:
END_CLASS

CLASS: VLB.AttenuationEquation
TYPE:  struct
TOKEN: 0x2000014
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  VLB.AttenuationEquation         Linear  // 0x0
  public    static  VLB.AttenuationEquation         Quadratic  // 0x0
  public    static  VLB.AttenuationEquation         Blend  // 0x0
METHODS:
END_CLASS

CLASS: VLB.BlendingMode
TYPE:  struct
TOKEN: 0x2000015
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  VLB.BlendingMode                Additive  // 0x0
  public    static  VLB.BlendingMode                SoftAdditive  // 0x0
  public    static  VLB.BlendingMode                TraditionalTransparency  // 0x0
METHODS:
END_CLASS

CLASS: VLB.ShaderAccuracy
TYPE:  struct
TOKEN: 0x2000016
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  VLB.ShaderAccuracy              Fast  // 0x0
  public    static  VLB.ShaderAccuracy              High  // 0x0
METHODS:
END_CLASS

CLASS: VLB.NoiseMode
TYPE:  struct
TOKEN: 0x2000017
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  VLB.NoiseMode                   Disabled  // 0x0
  public    static  VLB.NoiseMode                   WorldSpace  // 0x0
  public    static  VLB.NoiseMode                   LocalSpace  // 0x0
METHODS:
END_CLASS

CLASS: VLB.MeshType
TYPE:  struct
TOKEN: 0x2000018
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  VLB.MeshType                    Shared  // 0x0
  public    static  VLB.MeshType                    Custom  // 0x0
METHODS:
END_CLASS

CLASS: VLB.RenderPipeline
TYPE:  struct
TOKEN: 0x2000019
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  VLB.RenderPipeline              HGRP  // 0x0
  public    static  VLB.RenderPipeline              BuiltIn  // 0x0
  public    static  VLB.RenderPipeline              URP  // 0x0
  public    static  VLB.RenderPipeline              HDRP  // 0x0
METHODS:
END_CLASS

CLASS: VLB.RenderingMode
TYPE:  struct
TOKEN: 0x200001A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  VLB.RenderingMode               MultiPass  // 0x0
  public    static  VLB.RenderingMode               SinglePass  // 0x0
  public    static  VLB.RenderingMode               GPUInstancing  // 0x0
  public    static  VLB.RenderingMode               SRPBatcher  // 0x0
METHODS:
END_CLASS

CLASS: VLB.RenderQueue
TYPE:  struct
TOKEN: 0x200001B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  VLB.RenderQueue                 Custom  // 0x0
  public    static  VLB.RenderQueue                 Background  // 0x0
  public    static  VLB.RenderQueue                 Geometry  // 0x0
  public    static  VLB.RenderQueue                 AlphaTest  // 0x0
  public    static  VLB.RenderQueue                 GeometryLast  // 0x0
  public    static  VLB.RenderQueue                 Transparent  // 0x0
  public    static  VLB.RenderQueue                 Overlay  // 0x0
METHODS:
END_CLASS

CLASS: VLB.Dimensions
TYPE:  struct
TOKEN: 0x200001C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  VLB.Dimensions                  Dim3D  // 0x0
  public    static  VLB.Dimensions                  Dim2D  // 0x0
METHODS:
END_CLASS

CLASS: VLB.PlaneAlignment
TYPE:  struct
TOKEN: 0x200001D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  VLB.PlaneAlignment              Surface  // 0x0
  public    static  VLB.PlaneAlignment              Beam  // 0x0
METHODS:
END_CLASS

CLASS: VLB.DynamicOcclusionUpdateRate
TYPE:  struct
TOKEN: 0x200001E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  VLB.DynamicOcclusionUpdateRate  Never  // 0x0
  public    static  VLB.DynamicOcclusionUpdateRate  OnEnable  // 0x0
  public    static  VLB.DynamicOcclusionUpdateRate  OnBeamMove  // 0x0
  public    static  VLB.DynamicOcclusionUpdateRate  EveryXFrames  // 0x0
  public    static  VLB.DynamicOcclusionUpdateRate  OnBeamMoveAndEveryXFrames  // 0x0
METHODS:
END_CLASS

CLASS: VLB.ParticlesDirection
TYPE:  struct
TOKEN: 0x200001F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  VLB.ParticlesDirection          Random  // 0x0
  public    static  VLB.ParticlesDirection          LocalSpace  // 0x0
  public    static  VLB.ParticlesDirection          WorldSpace  // 0x0
METHODS:
END_CLASS

CLASS: VLB.HighlightNullAttribute
TYPE:  class
TOKEN: 0x2000020
EXTENDS: PropertyAttribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: VLB.MaterialManager
TYPE:  class
TOKEN: 0x2000021
FIELDS:
  public    static  System.Int32                    staticPropertiesCount  // 0x0
  public    static  UnityEngine.MaterialPropertyBlockmaterialPropertyBlock  // 0x0
  private   static readonly UnityEngine.Rendering.BlendMode[]BlendingMode_SrcFactor  // 0x8
  private   static readonly UnityEngine.Rendering.BlendMode[]BlendingMode_DstFactor  // 0x10
  private   static readonly System.Boolean[]                BlendingMode_AlphaAsBlack  // 0x18
  private   static readonly System.Collections.Hashtable    ms_MaterialsGroup  // 0x20
METHODS:
  UnityEngine.Material NewMaterialTransient(System.Boolean gpuInstanced)
  UnityEngine.Material NewMaterialPersistent(UnityEngine.Shader shader, System.Boolean gpuInstanced)
  UnityEngine.Material GetInstancedMaterial(System.UInt32 groupID, VLB.MaterialManager.StaticProperties& staticProps)
  System.Void .cctor()
END_CLASS

CLASS: VLB.MaterialModifier
TYPE:  class
TOKEN: 0x200002B
FIELDS:
METHODS:
END_CLASS

CLASS: VLB.MinMaxRangeFloat
TYPE:  struct
TOKEN: 0x200002E
FIELDS:
  private           System.Single                   m_MinValue  // 0x10
  private           System.Single                   m_MaxValue  // 0x14
METHODS:
  System.Void .ctor(System.Single min, System.Single max)
  System.Single get_minValue()
  System.Single get_maxValue()
  System.Single get_randomValue()
  UnityEngine.Vector2 get_asVector2()
  System.Single GetLerpedValue(System.Single lerp01)
END_CLASS

CLASS: VLB.MinMaxRangeAttribute
TYPE:  class
TOKEN: 0x200002F
EXTENDS: Attribute
FIELDS:
  private   readonly System.Single                   <minValue>k__BackingField  // 0x10
  private   readonly System.Single                   <maxValue>k__BackingField  // 0x14
METHODS:
  System.Void .ctor(System.Single min, System.Single max)
  System.Single get_minValue()
  System.Single get_maxValue()
END_CLASS

CLASS: VLB.PlatformHelper
TYPE:  class
TOKEN: 0x2000030
FIELDS:
METHODS:
  System.String GetCurrentPlatformSuffix()
  System.String GetPlatformSuffix(UnityEngine.RuntimePlatform platform)
  System.Void .ctor()
END_CLASS

CLASS: VLB.PolygonHelper
TYPE:  class
TOKEN: 0x2000031
EXTENDS: MonoBehaviour
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: VLB.ShaderKeywords
TYPE:  class
TOKEN: 0x2000033
FIELDS:
  public    static  System.String                   UseFog  // 0x0
  public    static  System.String                   AlphaAsBlack  // 0x0
  public    static  System.String                   ColorGradientMatrixLow  // 0x0
  public    static  System.String                   ColorGradientMatrixHigh  // 0x0
  public    static  System.String                   DepthBlend  // 0x0
  public    static  System.String                   Noise3D  // 0x0
  public    static  System.String                   OcclusionClippingPlane  // 0x0
  public    static  System.String                   OcclusionDepthTexture  // 0x0
  public    static  System.String                   MeshSkewing  // 0x0
  public    static  System.String                   ShaderAccuracyHigh  // 0x0
METHODS:
END_CLASS

CLASS: VLB.ShaderProperties
TYPE:  class
TOKEN: 0x2000034
FIELDS:
  public    static readonly System.Int32                    ConeParams0  // 0x0
  public    static readonly System.Int32                    ConeParams1  // 0x4
  public    static readonly System.Int32                    TiltVectorX  // 0x8
  public    static readonly System.Int32                    TiltVectorY  // 0xC
  public    static readonly System.Int32                    DistanceFadeStart  // 0x10
  public    static readonly System.Int32                    DistanceFadeEnd  // 0x14
  public    static readonly System.Int32                    DistanceFadeStartSecond  // 0x18
  public    static readonly System.Int32                    DistanceFadeEndSecond  // 0x1C
  public    static readonly System.Int32                    NoiseVelocity  // 0x20
  public    static readonly System.Int32                    NoiseScale  // 0x24
  public    static readonly System.Int32                    DepthBlendCapOff  // 0x28
  public    static readonly System.Int32                    BlendMode  // 0x2C
  public    static readonly System.Int32                    FogIntensity  // 0x30
  public    static readonly System.Int32                    ClippingPlaneTransition  // 0x34
  public    static readonly System.Int32                    UseClippingPlane  // 0x38
  public    static readonly System.Int32                    FadeOutFactor  // 0x3C
  public    static readonly System.Int32                    ConeSlopeCosSin  // 0x40
  public    static readonly System.Int32                    ConeRadius  // 0x44
  public    static readonly System.Int32                    ConeGeomProps  // 0x48
  public    static readonly System.Int32                    ColorFlat  // 0x4C
  public    static readonly System.Int32                    AlphaInside  // 0x50
  public    static readonly System.Int32                    AlphaOutside  // 0x54
  public    static readonly System.Int32                    HDRPExposureWeight  // 0x58
  public    static readonly System.Int32                    AttenuationLerpLinearQuad  // 0x5C
  public    static readonly System.Int32                    DistanceFallOff  // 0x60
  public    static readonly System.Int32                    DistanceCamClipping  // 0x64
  public    static readonly System.Int32                    FresnelPow  // 0x68
  public    static readonly System.Int32                    GlareBehind  // 0x6C
  public    static readonly System.Int32                    GlareFrontal  // 0x70
  public    static readonly System.Int32                    DrawCap  // 0x74
  public    static readonly System.Int32                    DepthBlendDistance  // 0x78
  public    static readonly System.Int32                    NoiseVelocityAndScale  // 0x7C
  public    static readonly System.Int32                    NoiseParam  // 0x80
  public    static readonly System.Int32                    CameraParams  // 0x84
  public    static readonly System.Int32                    ColorGradientMatrix  // 0x88
  public    static readonly System.Int32                    LocalToWorldMatrix  // 0x8C
  public    static readonly System.Int32                    WorldToLocalMatrix  // 0x90
  public    static readonly System.Int32                    BlendSrcFactor  // 0x94
  public    static readonly System.Int32                    BlendDstFactor  // 0x98
  public    static readonly System.Int32                    DynamicOcclusionClippingPlaneWS  // 0x9C
  public    static readonly System.Int32                    DynamicOcclusionClippingPlaneProps  // 0xA0
  public    static readonly System.Int32                    DynamicOcclusionDepthTexture  // 0xA4
  public    static readonly System.Int32                    DynamicOcclusionDepthProps  // 0xA8
  public    static readonly System.Int32                    LocalForwardDirection  // 0xAC
  public    static readonly System.Int32                    TiltVector  // 0xB0
  public    static readonly System.Int32                    AdditionalClippingPlaneWS  // 0xB4
  public    static readonly System.Int32                    ParticlesTintColor  // 0xB8
  public    static readonly System.Int32                    GlobalUsesReversedZBuffer  // 0xBC
  public    static readonly System.Int32                    GlobalNoiseTex3D  // 0xC0
  public    static readonly System.Int32                    GlobalNoiseCustomTime  // 0xC4
  public    static readonly System.Int32                    GlobalDitheringFactor  // 0xC8
  public    static readonly System.Int32                    GlobalDitheringNoiseTex  // 0xCC
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: VLB.SpotLightHelper
TYPE:  class
TOKEN: 0x2000035
FIELDS:
METHODS:
  System.Void GetCullingDistance(UnityEngine.Light light, System.Single& cullingDistance, System.Single& falloffDistance)
  System.Single GetIntensity(UnityEngine.Light light)
  System.Single GetSpotAngle(UnityEngine.Light light)
  System.Single GetFallOffEnd(UnityEngine.Light light)
END_CLASS

CLASS: VLB.SRPHelper
TYPE:  class
TOKEN: 0x2000036
FIELDS:
  private   static  VLB.SRPHelper.RenderPipeline    m_RenderPipelineCached  // 0x0
METHODS:
  VLB.SRPHelper.RenderPipeline get_renderPipelineType()
  VLB.SRPHelper.RenderPipeline ComputeRenderPipeline()
  System.Boolean IsUsingCustomRenderPipeline()
  System.Void RegisterOnBeginCameraRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Camera> cb)
  System.Void UnregisterOnBeginCameraRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Camera> cb)
  System.Void .cctor()
END_CLASS

CLASS: VLB.TransformUtils
TYPE:  class
TOKEN: 0x2000038
FIELDS:
METHODS:
  VLB.TransformUtils.Packed GetWorldPacked(UnityEngine.Transform self)
END_CLASS

CLASS: VLB.Utils
TYPE:  class
TOKEN: 0x200003A
FIELDS:
  private   static  System.Single                   kEpsilon  // 0x0
  private   static  System.Int32                    kFloatPackingHighMinShaderLevel  // 0x0
  private   static  VLB.Utils.FloatPackingPrecision ms_FloatPackingPrecision  // 0x0
METHODS:
  System.Single ComputeConeRadiusEnd(System.Single fallOffEnd, System.Single spotAngle)
  System.Single ComputeSpotAngle(System.Single fallOffEnd, System.Single coneRadiusEnd)
  System.Void Swap(T& a, T& b)
  System.String GetPath(UnityEngine.Transform current)
  T NewWithComponent(System.String name)
  T GetOrAddComponent(UnityEngine.GameObject self)
  T GetOrAddComponent(UnityEngine.MonoBehaviour self)
  System.Void ForeachComponentsOnlyInChildren(UnityEngine.GameObject self, System.Action<T> lambda, System.Boolean includeInactive)
  System.Boolean HasFlag(System.Enum mask, System.Enum flags)
  UnityEngine.Vector2 xy(UnityEngine.Vector3 aVector)
  UnityEngine.Vector2 xz(UnityEngine.Vector3 aVector)
  UnityEngine.Vector2 yz(UnityEngine.Vector3 aVector)
  UnityEngine.Vector2 yx(UnityEngine.Vector3 aVector)
  UnityEngine.Vector2 zx(UnityEngine.Vector3 aVector)
  UnityEngine.Vector2 zy(UnityEngine.Vector3 aVector)
  System.Boolean Approximately(System.Single a, System.Single b, System.Single epsilon)
  System.Boolean Approximately(UnityEngine.Vector2 a, UnityEngine.Vector2 b, System.Single epsilon)
  System.Boolean Approximately(UnityEngine.Vector3 a, UnityEngine.Vector3 b, System.Single epsilon)
  System.Boolean Approximately(UnityEngine.Vector4 a, UnityEngine.Vector4 b, System.Single epsilon)
  UnityEngine.Vector4 AsVector4(UnityEngine.Vector3 vec3, System.Single w)
  UnityEngine.Vector4 PlaneEquation(UnityEngine.Vector3 normalizedNormal, UnityEngine.Vector3 pt)
  System.Single GetVolumeCubic(UnityEngine.Bounds self)
  System.Single GetMaxArea2D(UnityEngine.Bounds self)
  UnityEngine.Color Opaque(UnityEngine.Color self)
  UnityEngine.Color ComputeComplementaryColor(UnityEngine.Color self, System.Boolean blackAndWhite)
  UnityEngine.Plane TranslateCustom(UnityEngine.Plane plane, UnityEngine.Vector3 translation)
  UnityEngine.Vector3 ClosestPointOnPlaneCustom(UnityEngine.Plane plane, UnityEngine.Vector3 point)
  System.Boolean IsAlmostZero(System.Single f)
  System.Boolean IsValid(UnityEngine.Plane plane)
  System.Void SetKeywordEnabled(UnityEngine.Material mat, System.String name, System.Boolean enabled)
  System.Void SetShaderKeywordEnabled(System.String name, System.Boolean enabled)
  UnityEngine.Matrix4x4 SampleInMatrix(UnityEngine.Gradient self, System.Int32 floatPackingPrecision)
  UnityEngine.Color[] SampleInArray(UnityEngine.Gradient self, System.Int32 samplesCount)
  UnityEngine.Vector4 Vector4_Floor(UnityEngine.Vector4 vec)
  System.Single PackToFloat(UnityEngine.Color color, System.Int32 floatPackingPrecision)
  VLB.Utils.FloatPackingPrecision GetFloatPackingPrecision()
  System.Void MarkCurrentSceneDirty()
  System.Void MarkObjectDirty(UnityEngine.Object obj)
END_CLASS

CLASS: VLB.Version
TYPE:  class
TOKEN: 0x200003C
FIELDS:
  public    static  System.Int32                    Current  // 0x0
METHODS:
END_CLASS

CLASS: VLB.VolumetricLightBeam
TYPE:  class
TOKEN: 0x200003D
EXTENDS: MonoBehaviour
FIELDS:
  public            UnityEngine.PlatformLayers      platformLayers  // 0x18
  public    static  System.String                   ClassName  // 0x0
  public            System.Boolean                  colorFromLight  // 0x1C
  public            VLB.ColorMode                   colorMode  // 0x20
  public            UnityEngine.Color               color  // 0x24
  public            UnityEngine.Gradient            colorGradient  // 0x38
  public            System.Boolean                  intensityFromLight  // 0x40
  public            System.Boolean                  intensityModeAdvanced  // 0x41
  public            System.Single                   intensityInside  // 0x44
  public            System.Single                   intensityOutside  // 0x48
  public            System.Single                   intensityMultiplier  // 0x4C
  public            System.Single                   hdrpExposureWeight  // 0x50
  public            VLB.BlendingMode                blendingMode  // 0x54
  public            System.Boolean                  spotAngleFromLight  // 0x58
  public            System.Single                   spotAngle  // 0x5C
  public            System.Single                   spotAngleMultiplier  // 0x60
  public            System.Single                   coneRadiusStart  // 0x64
  public            VLB.ShaderAccuracy              shaderAccuracy  // 0x68
  public            VLB.MeshType                    geomMeshType  // 0x6C
  public            System.Int32                    geomCustomSides  // 0x70
  public            System.Int32                    geomCustomSegments  // 0x74
  public            UnityEngine.Vector3             skewingLocalForwardDirection  // 0x78
  public            System.Boolean                  useAdditionalClippingPlane  // 0x84
  public            UnityEngine.Transform           clippingPlaneTransform  // 0x88
  public            UnityEngine.Vector3             clippingPlanePosition  // 0x90
  public            UnityEngine.Quaternion          clippingPlaneRotation  // 0x9C
  public            System.Single                   clippingPlaneTransition  // 0xAC
  public            System.Boolean                  geomCap  // 0xB0
  public            VLB.AttenuationEquation         attenuationEquation  // 0xB4
  public            System.Single                   attenuationCustomBlending  // 0xB8
  public            System.Single                   fallOffStart  // 0xBC
  public            System.Single                   fallOffEnd  // 0xC0
  public            System.Boolean                  fallOffEndFromLight  // 0xC4
  private           UnityEngine.Light               m_CachedLightSpot  // 0xC8
  public            System.Single                   fallOffCap  // 0xD0
  public            System.Single                   fallOffEndMultiplier  // 0xD4
  public            System.Boolean                  depthBlendCapOff  // 0xD8
  public            System.Single                   depthBlendDistance  // 0xDC
  public            System.Single                   cameraClippingDistance  // 0xE0
  public            System.Single                   glareFrontal  // 0xE4
  public            System.Single                   glareBehind  // 0xE8
  public            System.Single                   fresnelPow  // 0xEC
  public            VLB.NoiseMode                   noiseMode  // 0xF0
  public            System.Single                   noiseIntensity  // 0xF4
  public            System.Boolean                  noiseScaleUseGlobal  // 0xF8
  public            System.Boolean                  noiseScaleUseSeparateAxis  // 0xF9
  public            UnityEngine.Vector3             noiseScalesLocal  // 0xFC
  public            System.Single                   noiseScaleLocal  // 0x108
  public            System.Boolean                  noiseVelocityUseGlobal  // 0x10C
  public            UnityEngine.Vector3             noiseVelocityLocal  // 0x110
  public            System.Boolean                  fadeOutFromLight  // 0x11C
  public            System.Single                   fadeOutBeginSecond  // 0x120
  public            System.Single                   fadeOutEndSecond  // 0x124
  public            System.Boolean                  useFog  // 0x128
  public            System.Single                   fogIntensity  // 0x12C
  public            VLB.Dimensions                  dimensions  // 0x130
  public            UnityEngine.Vector2             tiltFactor  // 0x134
  private           System.Int32                    pluginVersion  // 0x13C
  private           System.Boolean                  _TrackChangesDuringPlaytime  // 0x140
  private           System.Int32                    _SortingLayerID  // 0x144
  private           System.Int32                    _SortingOrder  // 0x148
  private           System.Single                   _FadeOutBegin  // 0x14C
  private           System.Single                   _FadeOutEnd  // 0x150
  private           System.UInt32                   <_INTERNAL_InstancedMaterialGroupID>k__BackingField  // 0x154
  public            VLB.BeamGeometry                m_BeamGeom  // 0x158
  public            System.Boolean                  matIsPersistent  // 0x160
  private           UnityEngine.Coroutine           m_CoPlaytimeUpdate  // 0x168
METHODS:
  VLB.ColorMode get_usedColorMode()
  System.Boolean get_useColorFromAttachedLightSpot()
  System.Boolean get_useColorTemperatureFromAttachedLightSpot()
  System.Single get_alphaInside()
  System.Void set_alphaInside(System.Single value)
  System.Single get_alphaOutside()
  System.Void set_alphaOutside(System.Single value)
  System.Single get_intensityGlobal()
  System.Void set_intensityGlobal(System.Single value)
  System.Boolean get_useIntensityFromAttachedLightSpot()
  System.Void GetInsideAndOutsideIntensity(System.Single& inside, System.Single& outside)
  System.Boolean get_useSpotAngleFromAttachedLightSpot()
  System.Single get_coneAngle()
  System.Single get_coneRadiusEnd()
  System.Void set_coneRadiusEnd(System.Single value)
  System.Single get_coneVolume()
  System.Single get_coneApexOffsetZ()
  UnityEngine.Vector3 get_coneApexPositionLocal()
  UnityEngine.Vector3 get_coneApexPositionGlobal()
  System.Int32 get_geomSides()
  System.Void set_geomSides(System.Int32 value)
  System.Int32 get_geomSegments()
  System.Void set_geomSegments(System.Int32 value)
  UnityEngine.Vector3 get_skewingLocalForwardDirectionNormalized()
  System.Boolean get_canHaveMeshSkewing()
  System.Boolean get_hasMeshSkewing()
  UnityEngine.Vector4 get_additionalClippingPlane()
  System.Single get_attenuationLerpLinearQuad()
  System.Single get_fadeStart()
  System.Void set_fadeStart(System.Single value)
  System.Single get_fadeEnd()
  System.Void set_fadeEnd(System.Single value)
  System.Boolean get_fadeEndFromLight()
  System.Void set_fadeEndFromLight(System.Boolean value)
  UnityEngine.Light get_lightSpotAttached()
  System.Boolean get_useFallOffEndFromAttachedLightSpot()
  System.Single get_maxGeometryDistance()
  System.Boolean get_isNoiseEnabled()
  System.Boolean get_noiseEnabled()
  System.Void set_noiseEnabled(System.Boolean value)
  System.Single get_cullingDistance()
  System.Single get_fadeOutBegin()
  System.Void set_fadeOutBegin(System.Single value)
  System.Single get_fadeOutEnd()
  System.Void set_fadeOutEnd(System.Single value)
  System.Boolean get_isFadeOutEnabled()
  System.Boolean get_isTilted()
  System.Int32 get_sortingLayerID()
  System.Void set_sortingLayerID(System.Int32 value)
  System.String get_sortingLayerName()
  System.Void set_sortingLayerName(System.String value)
  System.Int32 get_sortingOrder()
  System.Void set_sortingOrder(System.Int32 value)
  System.Boolean get_trackChangesDuringPlaytime()
  System.Void set_trackChangesDuringPlaytime(System.Boolean value)
  System.Boolean get_isCurrentlyTrackingChanges()
  System.Boolean get_hasGeometry()
  UnityEngine.Bounds get_bounds()
  System.Int32 get_blendingModeAsInt()
  UnityEngine.Quaternion get_beamInternalLocalRotation()
  UnityEngine.Vector3 get_beamLocalForward()
  UnityEngine.Vector3 get_beamGlobalForward()
  UnityEngine.Vector3 get_lossyScale()
  System.Single get_raycastDistance()
  UnityEngine.Vector3 ComputeRaycastGlobalVector(UnityEngine.Vector3 localVec)
  UnityEngine.Vector3 get_raycastGlobalForward()
  UnityEngine.Vector3 get_raycastGlobalUp()
  UnityEngine.Vector3 get_raycastGlobalRight()
  System.Int32 get__INTERNAL_pluginVersion()
  System.Void SetFadeOutValue(System.Single& propToChange, System.Single value)
  System.UInt32 get__INTERNAL_InstancedMaterialGroupID()
  System.Void set__INTERNAL_InstancedMaterialGroupID(System.UInt32 value)
  System.String get_meshStats()
  System.Int32 get_meshVerticesCount()
  System.Int32 get_meshTrianglesCount()
  System.Void .ctor()
END_CLASS

