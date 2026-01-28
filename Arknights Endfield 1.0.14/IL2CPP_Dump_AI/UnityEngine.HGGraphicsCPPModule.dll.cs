// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.HGGraphicsCPPModule.dll
// Classes:  155
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: Microsoft.CodeAnalysis.EmbeddedAttribute
TYPE:  class
TOKEN: 0x2000002
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Runtime.CompilerServices.IsReadOnlyAttribute
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Runtime.CompilerServices.IsUnmanagedAttribute
TYPE:  class
TOKEN: 0x2000004
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP
TYPE:  struct
TOKEN: 0x2000005
FIELDS:
  public            System.Boolean                  enabled  // 0x10
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_float
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Boolean                  overriding  // 0x10
  public            System.Single                   value  // 0x14
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_int
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            System.Boolean                  overriding  // 0x10
  public            System.Int32                    value  // 0x14
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_bool
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.Boolean                  overriding  // 0x10
  public            System.Boolean                  value  // 0x11
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGDebugFeaturesManagerCPP
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPcppRenderPath  // 0x10
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPshadows  // 0x11
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPcsm  // 0x12
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPasmShadow  // 0x13
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPcloudShadow  // 0x14
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPcharacterShadow  // 0x15
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPpunctualLightShadow  // 0x16
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPcontactShadow  // 0x17
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_floatcsmFarDistance  // 0x18
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_intcsmCascadeCount  // 0x20
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_intpunctualLightShadowResolution  // 0x28
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_intdirectionalShadowResolution  // 0x30
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_intcharacterShadowResolution  // 0x38
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPshadowNoAlphaTest  // 0x40
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPshadowProxy  // 0x41
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPvisibilitySH  // 0x42
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPmergeShadowCullingView  // 0x43
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_floatcullingViewScreenSizeMin  // 0x44
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_floatshadowViewScreenSizeMin  // 0x4C
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_floatfogCullingFarClipPlane  // 0x54
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPocclusionCulling  // 0x5C
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_boolocclusionCullingCSM  // 0x5D
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPhizCulling  // 0x5F
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPoptimizedChunkCulling  // 0x60
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPskipAllDrawCommands  // 0x61
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPkeepDisabledPassCPUUsages  // 0x62
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPskipRender  // 0x63
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPpreZ  // 0x64
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPdeferred  // 0x65
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPcharacterPrePass  // 0x66
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPcustomDepthPass  // 0x67
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPdeferredOpaque  // 0x68
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPdeferredOpaquePreZ  // 0x69
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPdeferredOpaqueEqual  // 0x6A
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPdeferredGrassPreZ  // 0x6B
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPdeferredGrass  // 0x6C
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPdeferredDecal  // 0x6D
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPdeferredErosion  // 0x6E
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPdeferredSludge  // 0x6F
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPdeferredSludgeDecal  // 0x70
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPforward  // 0x71
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPskipForwardTransparent  // 0x72
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPforwardTransparent  // 0x73
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPforwardOpaque  // 0x74
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPforwardOpaquePreZ  // 0x75
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPforwardOpaqueEqual  // 0x76
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPforwardDecal  // 0x77
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPforwardCharacter  // 0x78
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPcharacterOutlineOpaque  // 0x79
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPcharacterOutlineOpaquePreZ  // 0x7A
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPcharacterOutlineOpaqueEqual  // 0x7B
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPvfxDecal  // 0x7C
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPdistortion  // 0x7D
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPdistortionOpaque  // 0x7E
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPdistortionTransparent  // 0x7F
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPUI  // 0x80
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPUISprite  // 0x81
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPUIWorld  // 0x82
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPUIDistorion  // 0x83
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPUIFrostedGlass  // 0x84
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_floatchunkLoadRadius  // 0x88
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_floatdefaultLayerLoadRadius  // 0x90
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_floathlod0LayerLoadRadius  // 0x98
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_floathlod1LayerLoadRadius  // 0xA0
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_floathlod2LayerLoadRadius  // 0xA8
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_floatcolliderLayerLoadRadius  // 0xB0
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_floattinyLayerLoadRadius  // 0xB8
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPdeferredShading  // 0xC0
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPdeferredShadingDefaultLit  // 0xC1
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPdeferredShadingTwoSidedFoliage  // 0xC2
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPdeferredShadingSubsurface  // 0xC3
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPsplitDeferredShadingStage  // 0xC4
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPusePerLightDynamicLighting  // 0xC5
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPdeferredShadingDirectionalLightStage  // 0xC6
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPdeferredShadingDynamicLightStage  // 0xC7
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPdeferredShadingIndirectStage  // 0xC8
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPdeferredShadingForceSplitOnePass  // 0xC9
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPusePerTileDeferredLighting  // 0xCA
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPdirectionalLight  // 0xCB
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPpunctualLights  // 0xCC
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_intpunctualLightsMaxCount  // 0xD0
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPirradianceVolume  // 0xD8
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPirradianceVolumeSample  // 0xD9
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPgtao  // 0xDA
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPirradianceVolumeV2  // 0xDB
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPirradianceVolumeV3  // 0xDC
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPpostProcess  // 0xDD
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPlightShaft  // 0xDE
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPbloom  // 0xDF
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPvignette  // 0xE0
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPradialBlur  // 0xE1
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPchromaticAbberation  // 0xE2
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPdirtyLens  // 0xE3
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPtoneMapping  // 0xE4
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPsharpen  // 0xE5
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPautoExposure  // 0xE6
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPmotionBlur  // 0xE7
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPfrostedGlass  // 0xE8
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPlensFlare  // 0xE9
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPdepthOfField  // 0xEA
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_intdepthOfFieldQuality  // 0xEC
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_floatdepthOfFieldScale  // 0xF4
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_floatdepthOfFieldMaxRadius  // 0xFC
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPfog  // 0x104
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPatmosphereFog  // 0x105
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPheightFog  // 0x106
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPvolumetricFog  // 0x107
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPssr  // 0x108
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_intssrRayMarchingSampleCount  // 0x10C
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_boolssrImportanceSample  // 0x114
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_boolssrV2  // 0x116
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_boolssrV2Upsample  // 0x118
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPreflectionProbe  // 0x11A
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPreflectionProbeNormalization  // 0x11B
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPreflectionProbeTextureDebugInfo  // 0x11C
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPreflectionProbeSlotDebugInfo  // 0x11D
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPreflectionProbeTextureArrayReset  // 0x11E
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_boolreflectionProbeTextureArrayDebugLog  // 0x11F
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPwaterRendering  // 0x121
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPwaterSSROnMobile  // 0x122
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPwaterSector  // 0x123
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPwaterInteraction  // 0x124
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPunderWaterWetness  // 0x125
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPwaterSectorDebug  // 0x126
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_boolwaterIndirect  // 0x127
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_floatwaterCameraFoVInc  // 0x12C
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_floatwaterCameraPosOffset  // 0x134
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_intwaterLODMeshRadius  // 0x13C
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_intwaterLODOrthHeight  // 0x144
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_intwaterLODMeshOffset  // 0x14C
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_intwaterLODMeshPerSize  // 0x154
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_floatwaterDisplacementWeight  // 0x15C
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_floatwaterDisplacementDistance  // 0x164
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPrain  // 0x16C
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPwetness  // 0x16D
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPrainWetnessHighQuality  // 0x16E
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPrainOcclusion  // 0x16F
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPrainOcclusionSamplePosJitter  // 0x170
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPrainSplash  // 0x171
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPterrainDeform  // 0x172
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPterrainDeformCCD  // 0x173
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPterrain  // 0x174
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPterrainPreDepth  // 0x175
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPterrainScreenSpace  // 0x176
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPterrainPostGBuffer  // 0x177
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPterrainVTBake  // 0x178
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPterrainIndirectionUpdate  // 0x179
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPterrainDepthPrepass  // 0x17A
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPterrainSimpleSubsurface  // 0x17B
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPterrainSubdivision  // 0x17C
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPterrainSubdivisionV2  // 0x17D
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPterrainSubdivisionHZBCulling  // 0x17E
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPterrainNewEditorRendering  // 0x17F
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPterrainDecalInteraction  // 0x180
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPentity  // 0x181
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPcharacter  // 0x182
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPenemy  // 0x183
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPnpc  // 0x184
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPsky  // 0x185
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPskyBox  // 0x186
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPskyCloud  // 0x187
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPskyCelestial  // 0x188
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPskyOctahedron  // 0x189
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_floatgrassGlobalSparsity  // 0x18C
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPfoliageInteractive  // 0x194
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPfoliageOccluder  // 0x195
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPgpuCloth  // 0x196
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPparticleLighting  // 0x197
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_boolshaderLOD  // 0x198
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_boolshaderLODWhiteKeyword  // 0x19A
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_boolrayTracingReflectionEnable  // 0x19C
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_intrayTracingReflectionMode  // 0x1A0
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPrayTracingReflectionGlossy  // 0x1A8
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPrayTracingReflectionRTOnly  // 0x1A9
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPPrayTracingReflectionDebugVariable  // 0x1AA
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_floatrayTracingReflectionSSQuality0  // 0x1AC
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_floatrayTracingReflectionSSQuality1  // 0x1B4
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_floatrayTracingReflectionSSQuality2  // 0x1BC
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_floatrayTracingReflectionSSQuality3  // 0x1C4
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_floatrayTracingReflectionRTQuality0  // 0x1CC
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_floatrayTracingReflectionRTQuality1  // 0x1D4
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_floatrayTracingReflectionRTQuality2  // 0x1DC
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeatureCPP_floatrayTracingReflectionRTQuality3  // 0x1E4
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGDebugRenderManagerCPP
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            System.Boolean                  enableAOVOutput  // 0x10
  public            System.Boolean                  enableAOVRenderMatte  // 0x11
  public            System.Single                   ppCompareScaleValue  // 0x14
  public            System.Boolean                  enableAlbedoTexelDetection  // 0x18
  public            System.Single                   albedoMinLuminance  // 0x1C
  public            System.Single                   albedoMaxLuminance  // 0x20
  public            System.Single                   baseColorAlpha  // 0x24
  public            System.Single                   checkerSize  // 0x28
  public            System.Boolean                  leafBackFaceRed  // 0x2C
  public            System.Int32                    triangleCountMin  // 0x30
  public            System.Int32                    triangleCountMax  // 0x34
  public            System.Boolean                  autoExposureEnabled  // 0x38
  public            System.Boolean                  centerMode  // 0x39
  public            System.Boolean                  autoModeEnabled  // 0x3A
  public            System.Single                   currentExposureValue  // 0x3C
  public            System.Single                   targetExposureValue  // 0x40
  public            System.Single                   avgLogLuminance  // 0x44
  public            System.Single                   ev100Compensation  // 0x48
  public            System.Single                   directEV100  // 0x4C
  public            System.Boolean                  displayPPResult  // 0x50
  public            UnityEngine.Vector4             overrideBaseColor  // 0x54
  public            System.Boolean                  disableNormalMap  // 0x64
  public            System.Single                   debugDisplayEV  // 0x68
  public            System.Boolean                  displayPBRColorChart  // 0x6C
  public            System.Single                   debugXRayDistance  // 0x70
  public            System.Boolean                  displayIVVoxelSize  // 0x74
  public            System.Boolean                  debugSkyAO  // 0x75
  public            System.Single                   m_fetchedAverageQuadOverdraw  // 0x78
  public            System.Boolean                  ignoreZeroValuePixels  // 0x7C
  public            System.Int32                    quadOverdrawDetectionMode  // 0x80
  public            System.Boolean                  isQuadOverdrawPreDepthMode  // 0x84
  public            UnityEngine.Vector2             m_sceneViewSelectionPos  // 0x88
  public            UnityEngine.HyperGryphEngineCode.HGDebugRenderManagerCPP.<m_fetchedData>e__FixedBufferm_fetchedData  // 0x90
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGVolumetricFogSettingParametersV2
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  public            System.Boolean                  enableVolumetricFog  // 0x10
  public            System.Int32                    gridPixelSize  // 0x14
  public            System.Int32                    gridSizeZ  // 0x18
  public            System.Int32                    maxSourceRTWidth  // 0x1C
  public            System.Int32                    maxSourceRTHeight  // 0x20
  public            System.Int32                    depthDistributionScale  // 0x24
  public            System.Int32                    historyMissSuperSampleCount  // 0x28
  public            System.Single                   fogHistoryWeight  // 0x2C
  public            System.Single                   lightScatteringSampleJitterMultiplier  // 0x30
  public            System.Single                   upsampleJitterMultiplier  // 0x34
  public            System.Boolean                  enableTemporalReprojection  // 0x38
  public            System.Boolean                  enablePunctualLightShadow  // 0x39
  public            System.Boolean                  enableEmissiveVBufferB  // 0x3A
  public            System.Boolean                  enableScalarizeDynamicLightLoop  // 0x3B
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGAtmosphereSettingParameters
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
  public            System.Single                   transmittanceLutSampleCount  // 0x10
  public            System.Int32                    transmittanceLutWidth  // 0x14
  public            System.Int32                    transmittanceLutHeight  // 0x18
  public            System.Single                   multiScatteredLuminanceLutSampleCount  // 0x1C
  public            System.Boolean                  multiScatteredLuminanceLutHighQuality  // 0x20
  public            System.Int32                    multiScatteredLuminanceLutWidth  // 0x24
  public            System.Int32                    multiScatteredLuminanceLutHeight  // 0x28
  public            System.Single                   skyViewLutSampleCountMin  // 0x2C
  public            System.Single                   skyViewLutSampleCountMax  // 0x30
  public            System.Single                   skyViewLutDistanceToSampleCountMax  // 0x34
  public            System.Int32                    skyViewLutWidth  // 0x38
  public            System.Int32                    skyViewLutHeight  // 0x3C
  public            System.Boolean                  skyAtmosphereLutUseSmallFormat  // 0x40
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGSettingParametersCpp
TYPE:  struct
TOKEN: 0x200000E
FIELDS:
  public            System.Boolean                  taauEnable  // 0x10
  public            System.Int32                    taauQuality  // 0x14
  public            System.Single                   historyWeight  // 0x18
  public            System.Single                   historyWeightInMotion  // 0x1C
  public            System.Single                   fastConvergeHistoryWeight  // 0x20
  public            System.Single                   responsiveAAWeight  // 0x24
  public            System.Single                   minMotion  // 0x28
  public            System.Single                   maxMotion  // 0x2C
  public            System.Single                   characterMotionSensitivity  // 0x30
  public            System.Single                   occlusionDepthDiff  // 0x34
  public            System.Single                   inputLumaWeight  // 0x38
  public            System.Single                   sharpenStrength1K  // 0x3C
  public            System.Single                   sharpenStrength2K  // 0x40
  public            System.Single                   sharpenStrength4K  // 0x44
  public            System.Boolean                  pssrEnable  // 0x48
  public            System.Boolean                  pssrPassThrough  // 0x49
  public            System.Boolean                  dlssEnable  // 0x4A
  public            UnityEngine.HyperGryphEngineCode.DLSSQualitydlssQuality  // 0x4C
  public            System.Boolean                  dlssUseAutoExposure  // 0x50
  public            UnityEngine.HyperGryphEngineCode.StreamlineDLSSFGModedlssFGMode  // 0x54
  public            System.UInt32                   dlssFGGenFrames  // 0x58
  public            UnityEngine.HyperGryphEngineCode.StreamlineReflexModedlssReflexMode  // 0x5C
  public            System.Boolean                  dlssPCLEnable  // 0x60
  public            System.Single                   dlssSharpenStrength  // 0x64
  public            System.Boolean                  dlssUseUIHint  // 0x68
  public            System.Single                   dlssUIHintAlphaThreshold  // 0x6C
  public            UnityEngine.HyperGryphEngineCode.BloomQualitybloomQuality  // 0x70
  public            System.Boolean                  bloomUseComputeShader  // 0x74
  public            System.Int32                    lutSize  // 0x78
  public            UnityEngine.Experimental.Rendering.GraphicsFormatlutFormat  // 0x7C
  public            UnityEngine.Experimental.Rendering.GraphicsFormatppBufferFormat  // 0x80
  public            UnityEngine.Experimental.Rendering.GraphicsFormatuiPPBufferFormat  // 0x84
  public            System.Boolean                  frostedGlassUseComputeShader  // 0x88
  public            System.Int32                    depthOfFieldQuality  // 0x8C
  public            System.Single                   depthOfFieldMaxRadius  // 0x90
  public            System.Boolean                  motionBlurEnable  // 0x94
  public            System.Boolean                  bloomEnabled  // 0x95
  public            System.Boolean                  vignetteEnabled  // 0x96
  public            System.Boolean                  radialBlurEnabled  // 0x97
  public            System.Boolean                  chromaticAberrationEnabled  // 0x98
  public            System.Boolean                  dirtyLensEnabled  // 0x99
  public            System.Boolean                  sharpenEnabled  // 0x9A
  public            System.Boolean                  frostedGlassEnabled  // 0x9B
  public            System.Boolean                  cutsceneEffectEnabled  // 0x9C
  public            System.Boolean                  fisheyeEffectEnabled  // 0x9D
  public            System.Boolean                  lensFlareEnabled  // 0x9E
  public            System.Int32                    punctualLightMaxCount  // 0xA0
  public            System.Boolean                  enableShadowProxy  // 0xA4
  public            System.Int32                    shadowDepthBits  // 0xA8
  public            System.Boolean                  enableScreenSpaceShadowMask  // 0xAC
  public            System.Boolean                  csmEnabled  // 0xAD
  public            System.Int32                    csmShadowMapTileResolution  // 0xB0
  public            System.Single                   csmMaxDistance  // 0xB4
  public            System.Single                   csmFadeInnerDistance  // 0xB8
  public            System.Int32                    csmSplitCount  // 0xBC
  public            System.Single                   csmSplit0  // 0xC0
  public            System.Single                   csmSplit1  // 0xC4
  public            System.Single                   csmSplit2  // 0xC8
  public            System.Single                   csmSplit3  // 0xCC
  public            System.Boolean                  csmUseShadowmapCache  // 0xD0
  public            System.Int32                    csmCachedFrame0  // 0xD4
  public            System.Int32                    csmCachedFrame1  // 0xD8
  public            System.Int32                    csmCachedFrame2  // 0xDC
  public            System.Int32                    csmCachedFrame3  // 0xE0
  public            System.Single                   csmScreenSizeMin0  // 0xE4
  public            System.Single                   csmScreenSizeMin1  // 0xE8
  public            System.Single                   csmScreenSizeMin2  // 0xEC
  public            System.Single                   csmScreenSizeMin3  // 0xF0
  public            System.Boolean                  csmEnableOcclusionCulling0  // 0xF4
  public            System.Boolean                  csmEnableOcclusionCulling1  // 0xF5
  public            System.Boolean                  csmEnableOcclusionCulling2  // 0xF6
  public            System.Boolean                  csmEnableOcclusionCulling3  // 0xF7
  public            System.Int32                    csmOcclusionDepthSize  // 0xF8
  public            System.Int32                    csmStopRenderCharacterCascade  // 0xFC
  public            System.Single                   csmNearPlaneOffset  // 0x100
  public            System.Single                   csmHardwareBias  // 0x104
  public            System.Single                   csmHardwareNormalBias  // 0x108
  public            System.Boolean                  characterShadowEnabled  // 0x10C
  public            System.Int32                    characterShadowMapResolution  // 0x110
  public            System.Single                   characterShadowHardwareBias  // 0x114
  public            System.Single                   characterShadowHardwareNormalBias  // 0x118
  public            System.Single                   characterShadowShaderBias  // 0x11C
  public            System.Single                   characterShadowShaderNormalBias  // 0x120
  public            System.Boolean                  punctualLightShadowEnabled  // 0x124
  public            System.Int32                    punctualLightTileMaxSize  // 0x128
  public            System.Single                   punctualLightForceCullDistance  // 0x12C
  public            System.Int32                    punctualLightDynamicCasterCount  // 0x130
  public            System.Single                   punctualLightShadowScreenSizeMin  // 0x134
  public            System.Boolean                  asmEnabled  // 0x138
  public            System.Int32                    asmShadowMapTileResolution  // 0x13C
  public            System.Single                   asmMaxDistance  // 0x140
  public            System.Int32                    asmMaxTileRenderCountPerFrame  // 0x144
  public            System.Single                   asmDepthBias  // 0x148
  public            System.Single                   asmNormalBias  // 0x14C
  public            System.Single                   asmScreenSizeMin  // 0x150
  public            System.Boolean                  transientGBuffer  // 0x154
  public            System.Int32                    depthBitsGBuffer  // 0x158
  public            System.Boolean                  depthCombinedWithStencil  // 0x15C
  public            System.Single                   copySceneRTScale  // 0x160
  public            System.Int32                    taauResolveResolutionHeight  // 0x164
  public            System.Single                   renderingScale  // 0x168
  public            System.Int32                    backBufferResolutionHeight  // 0x16C
  public            System.Boolean                  textureStreamingEnable  // 0x170
  public            System.Int32                    textureStreamingBudget  // 0x174
  public            System.Int32                    textureStreamingMaxBudget  // 0x178
  public            System.Int32                    reservedMemoryForNonTextureStreaming  // 0x17C
  public            System.Single                   textureStreamingMobileBudgetPercent  // 0x180
  public            System.Int32                    textureStreamingRendererPerFrame  // 0x184
  public            System.Int32                    textureStreamingMaxFileIORequests  // 0x188
  public            System.Boolean                  contactShadowEnableParam  // 0x18C
  public            System.Boolean                  gtaoEnable  // 0x18D
  public            System.Int32                    gtaoQualityLevel  // 0x190
  public            System.Boolean                  ssrEnable  // 0x194
  public            System.Int32                    ssrRayMarchingSampleCount  // 0x198
  public            System.Boolean                  ssrV2  // 0x19C
  public            System.Boolean                  ssrV2Upsample  // 0x19D
  public            System.Boolean                  terrainFallbackGBuffer  // 0x19E
  public            System.Int32                    terrainLODFactor  // 0x1A0
  public            System.Boolean                  terrainDeformEnable  // 0x1A4
  public            System.Int32                    terrainDeformSubdMode  // 0x1A8
  public            System.Int32                    terrainDeformSubdModeV2  // 0x1AC
  public            System.Int32                    terrainDeformGpuSubd  // 0x1B0
  public            System.Int32                    terrainDeformPrimitivePixelLengthTargetLog2  // 0x1B4
  public            System.Boolean                  erosionEnable  // 0x1B8
  public            System.Boolean                  enableLightShaft  // 0x1B9
  public            System.Int32                    lightShaftSampleNum  // 0x1BC
  public            System.Single                   lightShaftDownSampleFactor  // 0x1C0
  public            System.Int32                    lightShaftBlurPassCount  // 0x1C4
  public            System.Boolean                  lightWeightUICamera  // 0x1C8
  public            System.Boolean                  enableRainWetnessHighQuality  // 0x1C9
  public            System.Int32                    rainOcclusionMapSize  // 0x1CC
  public            System.Int32                    rainOcclusionMapOverrideRange  // 0x1D0
  public            System.Boolean                  rainSplashEnabled  // 0x1D4
  public            System.Int32                    rainSplashMaxCount  // 0x1D8
  public            System.Single                   screenRainDropPercent  // 0x1DC
  public            System.Boolean                  enableMiddleDistRain  // 0x1E0
  public            System.Boolean                  enableRainWave  // 0x1E1
  public            System.Int32                    depthOcclusionMapSize  // 0x1E4
  public            System.Int32                    depthOcclusionMapRange  // 0x1E8
  public            UnityEngine.HyperGryphEngineCode.HGAtmosphereSettingParametersatmosphereParams  // 0x1EC
  public            System.Single                   waterPrepassTextureSize  // 0x220
  public            System.Boolean                  waterInteractiveEnable  // 0x224
  public            System.Boolean                  waterIndirectEnable  // 0x225
  public            System.Int32                    waterVRRx  // 0x228
  public            System.Int32                    waterVRRy  // 0x22C
  public            System.Int32                    waterLODMeshRadius  // 0x230
  public            System.Int32                    waterLODOrthHeight  // 0x234
  public            System.Int32                    waterLODMeshOffset  // 0x238
  public            System.Int32                    waterLODMeshPerSize  // 0x23C
  public            System.Single                   waterDisplacementWeight  // 0x240
  public            System.Single                   waterDisplacementDistance  // 0x244
  public            System.Single                   artTagLODBiasAll  // 0x248
  public            UnityEngine.HyperGryphEngineCode.HGSettingParametersCpp.<artTagLODBias>e__FixedBufferartTagLODBias  // 0x24C
  public            System.Boolean                  shouldSplitOnePass  // 0x34C
  public            UnityEngine.HyperGryphEngineCode.HGVolumetricFogSettingParametersV2volumetricFogParams  // 0x350
  public            System.Boolean                  reflectionProbeUseRGBAHalf  // 0x37C
  public            System.Int32                    reflectionProbeOctTextureSize  // 0x380
  public            System.Int32                    reflectionProbeMaxSampleMip  // 0x384
  public            System.Int32                    reflectionProbeMaxBlitCountPerFrame  // 0x388
  public            System.Boolean                  transparentLowResOffscreenEnable  // 0x38C
  public            System.Boolean                  transparentLowResVRSEnable  // 0x38D
  public            System.Int32                    transparentVRRx  // 0x390
  public            System.Int32                    transparentVRRy  // 0x394
  public            System.Boolean                  rayTracingReflectionEnable  // 0x398
  public            System.Int32                    rayTracingReflectionMode  // 0x39C
  public            System.Single                   rayTracingReflectionSSQuality0  // 0x3A0
  public            System.Single                   rayTracingReflectionSSQuality1  // 0x3A4
  public            System.Single                   rayTracingReflectionSSQuality2  // 0x3A8
  public            System.Single                   rayTracingReflectionSSQuality3  // 0x3AC
  public            System.Single                   rayTracingReflectionRTQuality0  // 0x3B0
  public            System.Single                   rayTracingReflectionRTQuality1  // 0x3B4
  public            System.Single                   rayTracingReflectionRTQuality2  // 0x3B8
  public            System.Single                   rayTracingReflectionRTQuality3  // 0x3BC
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGRenderPathConstants
TYPE:  struct
TOKEN: 0x2000010
FIELDS:
  public            System.Single                   _RenderPathInjected  // 0x10
  public            System.Single                   _HGFlipX  // 0x14
  public            System.Single                   _HGFlipY  // 0x18
  public            System.Single                   _HGOrientationType  // 0x1C
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.BasicTransformConstants
TYPE:  struct
TOKEN: 0x2000011
FIELDS:
  public            UnityEngine.Matrix4x4           _ViewMatrix  // 0x10
  public            UnityEngine.Matrix4x4           _InvViewMatrix  // 0x50
  public            UnityEngine.Matrix4x4           _ProjMatrix  // 0x90
  public            UnityEngine.Matrix4x4           _InvProjMatrix  // 0xD0
  public            UnityEngine.Matrix4x4           _ViewProjMatrix  // 0x110
  public            UnityEngine.Matrix4x4           _ViewNoTransProjMatrix  // 0x150
  public            UnityEngine.Matrix4x4           _InvViewProjMatrix  // 0x190
  public            UnityEngine.Matrix4x4           _NonJitteredViewProjMatrix  // 0x1D0
  public            UnityEngine.Matrix4x4           _NonJitteredViewNoTransProjMatrix  // 0x210
  public            UnityEngine.Matrix4x4           _InvNonJitteredViewProjMatrix  // 0x250
  public            UnityEngine.Matrix4x4           _InvPretransformMatrix  // 0x290
  public            UnityEngine.Vector4             _WorldSpaceCameraPos_Internal  // 0x2D0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.ShaderVariablesGlobal
TYPE:  struct
TOKEN: 0x2000012
FIELDS:
  public            UnityEngine.Matrix4x4           _PrevViewProjMatrix  // 0x10
  public            UnityEngine.Matrix4x4           _PrevViewNoTransProjMatrix  // 0x50
  public            UnityEngine.Matrix4x4           _PrevNonJitteredViewProjMatrix  // 0x90
  public            UnityEngine.Matrix4x4           _PrevNonJitteredViewNoTransProjMatrix  // 0xD0
  public            UnityEngine.Matrix4x4           _PrevInvViewProjMatrix  // 0x110
  public            UnityEngine.Matrix4x4           _PrevNonJitteredInvViewProjMatrix  // 0x150
  public            UnityEngine.Matrix4x4           _ReprojectionMatrix  // 0x190
  public            UnityEngine.Matrix4x4           _WiderFoVViewProjMatrix  // 0x1D0
  public            UnityEngine.Matrix4x4           _WiderFoVInvViewProjMatrix  // 0x210
  public            UnityEngine.Vector4             _PrevCamPosRWS_Internal  // 0x250
  public            UnityEngine.Vector4             _ScreenSize  // 0x260
  public            UnityEngine.Vector4             _BackBufferSize  // 0x270
  public            UnityEngine.Vector4             _ZBufferParams  // 0x280
  public            UnityEngine.Vector4             _ProjectionParams  // 0x290
  public            UnityEngine.Vector4             unity_OrthoParams  // 0x2A0
  public            UnityEngine.Vector4             _ScreenParams  // 0x2B0
  public            UnityEngine.HyperGryphEngineCode.ShaderVariablesGlobal.<_FrustumPlanes>e__FixedBuffer_FrustumPlanes  // 0x2C0
  public            UnityEngine.HyperGryphEngineCode.ShaderVariablesGlobal.<_ShadowFrustumPlanes>e__FixedBuffer_ShadowFrustumPlanes  // 0x320
  public            UnityEngine.Vector4             _TaaFrameInfo  // 0x380
  public            UnityEngine.Vector4             _TaaJitterStrength  // 0x390
  public            UnityEngine.Vector4             _Time  // 0x3A0
  public            UnityEngine.Vector4             _SinTime  // 0x3B0
  public            UnityEngine.Vector4             _CosTime  // 0x3C0
  public            UnityEngine.Vector4             unity_DeltaTime  // 0x3D0
  public            UnityEngine.Vector4             _TimeParameters  // 0x3E0
  public            UnityEngine.Vector4             _LastTimeParameters  // 0x3F0
  public            System.Single                   _GlobalMipBias  // 0x400
  public            System.Single                   _GlobalMipBiasPow2  // 0x404
  public            System.Single                   _ProbeExposureScale  // 0x408
  public            System.UInt32                   _FrameCount  // 0x40C
  public            UnityEngine.Vector4             _ExposureParams  // 0x410
  public            UnityEngine.Vector4Int          _BinningBufferOffsets  // 0x420
  public            UnityEngine.Vector4             _EnvironmentGlobalParams0  // 0x430
  public            UnityEngine.Vector4             _GraphicsFeaturesGlobalParam0  // 0x440
  public            UnityEngine.Vector4             _GraphicsFeaturesGlobalParam1  // 0x450
  public            UnityEngine.Vector4             _WindGlobalParams0  // 0x460
  public            UnityEngine.Vector4             _WindGlobalParams2  // 0x470
  public            UnityEngine.Vector4             _CharacterPositionParams0  // 0x480
  public            UnityEngine.Vector4             _CharacterPositionParams1  // 0x490
  public            UnityEngine.Vector4             _CharacterPositionParams2  // 0x4A0
  public            UnityEngine.Vector4             _CharacterPositionParams3  // 0x4B0
  public            UnityEngine.Vector4             _CharacterHeightParams  // 0x4C0
  public            UnityEngine.HyperGryphEngineCode.ShaderVariablesGlobal.<_WindMotorParams0>e__FixedBuffer_WindMotorParams0  // 0x4D0
  public            UnityEngine.HyperGryphEngineCode.ShaderVariablesGlobal.<_WindMotorParams1>e__FixedBuffer_WindMotorParams1  // 0x510
  public            UnityEngine.HyperGryphEngineCode.ShaderVariablesGlobal.<_WindMotorParams2>e__FixedBuffer_WindMotorParams2  // 0x550
  public            UnityEngine.HyperGryphEngineCode.ShaderVariablesGlobal.<_WindMotorParams3>e__FixedBuffer_WindMotorParams3  // 0x590
  public            UnityEngine.Vector4             _WindMotorCount  // 0x5D0
  public            UnityEngine.Vector4             _LastWindGlobalParams0  // 0x5E0
  public            UnityEngine.HyperGryphEngineCode.ShaderVariablesGlobal.<_LastWindMotorParams0>e__FixedBuffer_LastWindMotorParams0  // 0x5F0
  public            UnityEngine.HyperGryphEngineCode.ShaderVariablesGlobal.<_LastWindMotorParams1>e__FixedBuffer_LastWindMotorParams1  // 0x630
  public            UnityEngine.HyperGryphEngineCode.ShaderVariablesGlobal.<_LastWindMotorParams3>e__FixedBuffer_LastWindMotorParams3  // 0x670
  public            UnityEngine.Vector4             _FoliageInteractiveParams0  // 0x6B0
  public            UnityEngine.Vector4             _PrevFoliageInteractiveParams0  // 0x6C0
  public            UnityEngine.Vector4             _AtmosphereFogParams0  // 0x6D0
  public            UnityEngine.Vector4             _AtmosphereFogParams1  // 0x6E0
  public            UnityEngine.Vector4             _AtmosphereFogParams2  // 0x6F0
  public            UnityEngine.Vector4             _AtmosphereFogParams3  // 0x700
  public            UnityEngine.Vector4             _AtmosphereFogParams4  // 0x710
  public            UnityEngine.Vector4             _AtmosphereFogParams5  // 0x720
  public            UnityEngine.Vector4             _ExponentialFogParams0  // 0x730
  public            UnityEngine.Vector4             _ExponentialFogParams1  // 0x740
  public            UnityEngine.Vector4             _ExponentialFogParams2  // 0x750
  public            UnityEngine.Vector4             _ExponentialFogParams3  // 0x760
  public            UnityEngine.Vector4             _VolumetricFogParams0  // 0x770
  public            UnityEngine.Vector4             _VolumetricFogParams1  // 0x780
  public            UnityEngine.Vector4             _VolumetricFogParams2  // 0x790
  public            UnityEngine.Vector4             _VolumetricFogParams3  // 0x7A0
  public            UnityEngine.Vector4             _VolumetricFogParams4  // 0x7B0
  public            UnityEngine.Vector4             _HeightFogFlowNoiseParams0  // 0x7C0
  public            UnityEngine.Vector4             _HeightFogFlowNoiseParams1  // 0x7D0
  public            UnityEngine.Vector4             _FogBakeLutRescaleParams  // 0x7E0
  public            UnityEngine.Vector4             _FogBakeLutEncodeParams  // 0x7F0
  public            UnityEngine.Vector4             _FogBakeLutYawParams  // 0x800
  public            UnityEngine.Vector4             _CloudShadowParams0  // 0x810
  public            UnityEngine.Vector4             _CloudShadowParams1  // 0x820
  public            UnityEngine.Vector4             _CloudShadowParams2  // 0x830
  public            UnityEngine.Vector4             _CloudShadowParams3  // 0x840
  public            UnityEngine.Vector4             _Style_MatDistCoef  // 0x850
  public            UnityEngine.Vector4             _Style_MatFarAlb0  // 0x860
  public            UnityEngine.Vector4             _Style_MatFarAlb1  // 0x870
  public            UnityEngine.Vector4             _Style_GbFarEms  // 0x880
  public            UnityEngine.Vector4             _Style_GbFarDir  // 0x890
  public            UnityEngine.Vector4             _Style_GbCoef  // 0x8A0
  public            UnityEngine.Vector4             _VFXParams0  // 0x8B0
  public            UnityEngine.Vector4             _VFXParams1  // 0x8C0
  public            UnityEngine.Vector4             _VFXParams2  // 0x8D0
  public            UnityEngine.Vector4             _CharacterParams0  // 0x8E0
  public            UnityEngine.Vector4             _CharacterParams1  // 0x8F0
  public            UnityEngine.Vector4             _CharacterParams2  // 0x900
  public            UnityEngine.Vector4             _CharacterParams3  // 0x910
  public            UnityEngine.Vector4             _CharacterParams4  // 0x920
  public            UnityEngine.Vector4             _CharacterParams5  // 0x930
  public            UnityEngine.Vector4             _CharacterParams6  // 0x940
  public            UnityEngine.Vector4             _CharacterParams7  // 0x950
  public            UnityEngine.Vector4             _CharacterParams8  // 0x960
  public            UnityEngine.Vector4             _CharacterParams9  // 0x970
  public            UnityEngine.Vector4             _CharacterParams10  // 0x980
  public            UnityEngine.Vector4             _CharacterParams11  // 0x990
  public            UnityEngine.Vector4             _CharacterParams12  // 0x9A0
  public            UnityEngine.Vector4             _CharacterParams13  // 0x9B0
  public            UnityEngine.Vector4             _CharacterParams14  // 0x9C0
  public            UnityEngine.Vector4             _CharacterParams15  // 0x9D0
  public            UnityEngine.Vector4             _InkSimulationWorldToUV  // 0x9E0
  public            UnityEngine.Vector4             _TerrainDeformParams0  // 0x9F0
  public            UnityEngine.Vector4             _TerrainDeformParams1  // 0xA00
  public            UnityEngine.HyperGryphEngineCode.ShaderVariablesGlobal.<_TerrainClipmapParams0>e__FixedBuffer_TerrainClipmapParams0  // 0xA10
  public            UnityEngine.HyperGryphEngineCode.ShaderVariablesGlobal.<_TerrainClipmapParams1>e__FixedBuffer_TerrainClipmapParams1  // 0xA30
  public            System.Single                   _G_EnableFeatureErosionBlend  // 0xA50
  public            System.Single                   _G_EnableFeatureB  // 0xA54
  public            System.Single                   _G_EnableFeatureC  // 0xA58
  public            System.Single                   _G_EnableFeatureD  // 0xA5C
  public            UnityEngine.Vector4             _IVParam0  // 0xA60
  public            UnityEngine.Vector4             _IVParam1  // 0xA70
  public            UnityEngine.Vector4             _IVParam2  // 0xA80
  public            UnityEngine.Vector4             _IVDefaultSHAr  // 0xA90
  public            UnityEngine.Vector4             _IVDefaultshAg  // 0xAA0
  public            UnityEngine.Vector4             _IVDefaultshAb  // 0xAB0
  public            UnityEngine.Vector4             _IVV2Param0  // 0xAC0
  public            UnityEngine.Vector4             _IVV2Param1  // 0xAD0
  public            UnityEngine.Vector4             _IVV2Param2  // 0xAE0
  public            UnityEngine.Vector4             _IVV2Param3  // 0xAF0
  public            UnityEngine.Vector4             _WaterInteractionParams0  // 0xB00
  public            UnityEngine.Vector4             _WaterInteractionParams1  // 0xB10
  public            UnityEngine.Vector4             _RainWetnessGlobalParam0  // 0xB20
  public            UnityEngine.Vector4             _RainWetnessGlobalParam1  // 0xB30
  public            UnityEngine.Vector4             _RainWetnessGlobalParam2  // 0xB40
  public            UnityEngine.Vector4             _RainWetnessGlobalParam3  // 0xB50
  public            UnityEngine.Vector4             _RainWetnessGlobalParam4  // 0xB60
  public            UnityEngine.Vector4             _RainWetnessGlobalParam5  // 0xB70
  public            UnityEngine.Vector4             _RainWetnessGlobalParam6  // 0xB80
  public            UnityEngine.Vector4             _RainWetnessGlobalParam7  // 0xB90
  public            UnityEngine.Vector4             _RainWetnessGlobalParam8  // 0xBA0
  public            UnityEngine.Vector4             _RainWetnessGlobalParam9  // 0xBB0
  public            UnityEngine.Vector4             _RainWetnessGlobalParam10  // 0xBC0
  public            UnityEngine.Vector4             _VerticalOcclusionMapParam0  // 0xBD0
  public            UnityEngine.Vector4             _WaterWetnessMaskParam0  // 0xBE0
  public            UnityEngine.Vector4             _GpuClothParams  // 0xBF0
  public            UnityEngine.Vector4             _FoliageOccluderParams0  // 0xC00
  public            UnityEngine.Vector4             _FoliageOccluderCameraPosParam  // 0xC10
  public            UnityEngine.Vector4             _InteractRaftParams0  // 0xC20
  public            UnityEngine.Vector4             _InteractRaftParams1  // 0xC30
  public            UnityEngine.Matrix4x4           _FakePlanarReflectionViewProjMatrix  // 0xC40
  public            UnityEngine.Vector4             _FakeSphericalLightSource  // 0xC80
  public            UnityEngine.Vector4             _VolumetricComposeParams  // 0xC90
  public            UnityEngine.HyperGryphEngineCode.ShaderVariablesGlobal.<_HackTempDataBeforeCPPPlugin>e__FixedBuffer_HackTempDataBeforeCPPPlugin  // 0xCA0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.DLSSQuality
TYPE:  struct
TOKEN: 0x200001F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryphEngineCode.DLSSQualityUltraPerformance  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.DLSSQualityPerformance  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.DLSSQualityBalanced  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.DLSSQualityQuality  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.DLSSQualityDLAA  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.StreamlineReflexMode
TYPE:  struct
TOKEN: 0x2000020
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryphEngineCode.StreamlineReflexModeOff  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.StreamlineReflexModeLowLatency  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.StreamlineReflexModeLowLatencyWithBoost  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.StreamlineDLSSFGMode
TYPE:  struct
TOKEN: 0x2000021
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryphEngineCode.StreamlineDLSSFGModeOff  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.StreamlineDLSSFGModeOn  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.StreamlineDLSSFGModeAuto  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.DLSSOptimalSettings
TYPE:  struct
TOKEN: 0x2000022
FIELDS:
  public            System.UInt32                   optimalRenderWidth  // 0x10
  public            System.UInt32                   optimalRenderHeight  // 0x14
  public            System.Single                   optimalSharpness  // 0x18
  public            System.UInt32                   renderWidthMin  // 0x1C
  public            System.UInt32                   renderHeightMin  // 0x20
  public            System.UInt32                   renderWidthMax  // 0x24
  public            System.UInt32                   renderHeightMax  // 0x28
METHODS:
  UnityEngine.HyperGryphEngineCode.DLSSOptimalSettings GetDLSSOptimalSetting(UnityEngine.HyperGryphEngineCode.DLSSQuality quality, UnityEngine.Vector2Int nonScaledViewport)
  System.Void GetDLSSOptimalSetting_Injected(UnityEngine.HyperGryphEngineCode.DLSSQuality quality, UnityEngine.Vector2Int& nonScaledViewport, UnityEngine.HyperGryphEngineCode.DLSSOptimalSettings& ret)
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGCPPDLSSUtil
TYPE:  struct
TOKEN: 0x2000023
FIELDS:
METHODS:
  System.Void SetStreamlineDLSSGMode(UnityEngine.HyperGryphEngineCode.StreamlineDLSSFGMode frameGenMode)
  UnityEngine.Vector2Int GetStreamlineDLSSGMinMaxFrameGen()
  System.Int32 CalcStreamlineDLSSGVRAMUsage(UnityEngine.Vector2Int taauSize, UnityEngine.Vector2Int finalRTSize)
  System.Void GetStreamlineDLSSGMinMaxFrameGen_Injected(UnityEngine.Vector2Int& ret)
  System.Int32 CalcStreamlineDLSSGVRAMUsage_Injected(UnityEngine.Vector2Int& taauSize, UnityEngine.Vector2Int& finalRTSize)
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGLightConfigPitchYawModeCPP
TYPE:  struct
TOKEN: 0x2000024
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryphEngineCode.HGLightConfigPitchYawModeCPPDirLight  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGLightConfigPitchYawModeCPPCustom  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGLightConfigCPP
TYPE:  struct
TOKEN: 0x2000025
FIELDS:
  public            System.Single                   preExposure  // 0x10
  public            UnityEngine.Color               directColor  // 0x14
  public            System.Single                   directIntensity  // 0x24
  public            System.Single                   directSpecularIntensity  // 0x28
  public            System.Single                   directSoftSourceRadius  // 0x2C
  public            UnityEngine.Vector2             directPitchYaw  // 0x30
  public            System.Single                   indirectDiffuseFactor  // 0x38
  public            System.Single                   indirectSpecularFactor  // 0x3C
  public            UnityEngine.Quaternion          rotationDirect  // 0x40
  public            UnityEngine.Vector3             forwardDirect  // 0x50
  public            UnityEngine.Matrix4x4           localToWorld  // 0x5C
  public            UnityEngine.Quaternion          rotationAtmosphere  // 0x9C
  public            UnityEngine.Quaternion          rotationLightShaft  // 0xAC
  public            UnityEngine.Quaternion          rotationSunDisc  // 0xBC
  public            UnityEngine.Quaternion          rotationLensFlare  // 0xCC
  public            UnityEngine.Quaternion          rotationCloudShadow  // 0xDC
  public            UnityEngine.HyperGryphEngineCode.HGLightConfigPitchYawModeCPPcloudShadowPitchYawMode  // 0xEC
  public            UnityEngine.Vector2             cloudShadowPitchYaw  // 0xF0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGSkyConfigSkyMaterialTypeCPP
TYPE:  struct
TOKEN: 0x2000026
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryphEngineCode.HGSkyConfigSkyMaterialTypeCPPProceduralSky  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGSkyConfigSkyMaterialTypeCPPSkybox  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGSkyConfigReflectionTypeCPP
TYPE:  struct
TOKEN: 0x2000027
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryphEngineCode.HGSkyConfigReflectionTypeCPPFromSky  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGSkyConfigReflectionTypeCPPCustom  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGSkyConfigCPP
TYPE:  struct
TOKEN: 0x2000028
FIELDS:
  public            System.Single                   skyDistance  // 0x10
  public            System.Single                   skyBakedIndirectIntensity  // 0x14
  public            System.Single                   skyDirectIntensity  // 0x18
  public            System.Boolean                  useCustomIVDefaultSH  // 0x1C
  public            UnityEngine.Rendering.SphericalHarmonicsL2customIVDefaultSH  // 0x20
  public            UnityEngine.HyperGryphEngineCode.HGSkyConfigSkyMaterialTypeCPPskyMaterialType  // 0x8C
  public            System.Single                   proceduralSkyLuxFactor  // 0x90
  public            System.Boolean                  enableSunDisc  // 0x94
  public            System.Single                   sunDiscRadius  // 0x98
  public            System.Single                   sunDiscRampIntensity  // 0x9C
  public            UnityEngine.Color               sunDiscColor  // 0xA0
  public            System.Single                   skyboxBrightness  // 0xB0
  public            UnityEngine.Color               skyboxTintColor  // 0xB4
  public            System.Single                   skyboxRotation  // 0xC4
  public            UnityEngine.Vector3             visibleBox  // 0xC8
  public            UnityEngine.HyperGryphEngineCode.HGSkyConfigReflectionTypeCPPreflectionType  // 0xD4
  public            System.IntPtr                   reflectionMap  // 0xD8
  public            System.Single                   culloff  // 0xE0
  public            UnityEngine.Rendering.SphericalHarmonicsL2skyAmbientSH  // 0xE4
  public            System.IntPtr                   skyboxCubeMap  // 0x150
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGAtmosphereConfigCPP
TYPE:  struct
TOKEN: 0x2000029
FIELDS:
  public            System.Single                   groundRadius  // 0x10
  public            UnityEngine.Color               groundAlbedo  // 0x14
  public            UnityEngine.Color               outerSunIrradianceColor  // 0x24
  public            System.Single                   atmosphereHeight  // 0x34
  public            System.Single                   multiScatteringFactor  // 0x38
  public            System.Single                   rayleighScatteringScale  // 0x3C
  public            UnityEngine.Color               rayleighScattering  // 0x40
  public            System.Single                   rayleighExponentialDistribution  // 0x50
  public            System.Single                   mieScatteringScale  // 0x54
  public            UnityEngine.Color               mieScattering  // 0x58
  public            System.Single                   mieAbsorptionScale  // 0x68
  public            UnityEngine.Color               mieAbsorption  // 0x6C
  public            System.Single                   mieAnisotropy  // 0x7C
  public            System.Single                   mieExponentialDistribution  // 0x80
  public            System.Single                   ozoneAbsorptionScale  // 0x84
  public            UnityEngine.Color               ozoneAbsorption  // 0x88
  public            System.Single                   tentTipAltitude  // 0x98
  public            System.Single                   tentTipValue  // 0x9C
  public            System.Single                   tentWidth  // 0xA0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGFogConfigCPP
TYPE:  struct
TOKEN: 0x200002A
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            System.Single                   startDistance  // 0x14
  public            System.Single                   startHeight  // 0x18
  public            System.Single                   fallOffHeight  // 0x1C
  public            System.Single                   fallOffDistance  // 0x20
  public            UnityEngine.Color               mieScattering  // 0x24
  public            System.Single                   mieScatteringScale  // 0x34
  public            System.Single                   mieAnisotropy  // 0x38
  public            UnityEngine.Color               rayleighScattering  // 0x3C
  public            System.Single                   rayleighScatteringScale  // 0x4C
  public            UnityEngine.Color               inscatterAmbientColor  // 0x50
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGHeightFogConfigCPP
TYPE:  struct
TOKEN: 0x200002B
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            System.Single                   heightFogStartHeight  // 0x14
  public            System.Single                   heightFogDensity  // 0x18
  public            System.Single                   heightFogFalloff  // 0x1C
  public            System.Single                   heightFogStartHeightSecond  // 0x20
  public            System.Single                   heightFogDensitySecond  // 0x24
  public            System.Single                   heightFogFalloffSecond  // 0x28
  public            UnityEngine.Color               heightFogInscatter  // 0x2C
  public            System.Single                   heightFogMaxOpacity  // 0x3C
  public            System.Single                   heightFogStartDistance  // 0x40
  public            System.Single                   heightFogStartTransition  // 0x44
  public            System.Single                   heightFogCutoffDistance  // 0x48
  public            System.Single                   heightFogCutoffTransition  // 0x4C
  public            System.Single                   heightFogCullingFarClipPlane  // 0x50
  public            System.Boolean                  enableVolumetricFog  // 0x54
  public            System.Single                   volumetricFogScatteringDistribution  // 0x58
  public            UnityEngine.Color               volumetricFogAlbedo  // 0x5C
  public            UnityEngine.Color               volumetricFogEmissive  // 0x6C
  public            System.Single                   volumetricFogExtinctionScale  // 0x7C
  public            System.Single                   volumetricFogDistance  // 0x80
  public            System.Single                   volumetricFogStartDistance  // 0x84
  public            System.Single                   volumetricFogNearFadeInDistance  // 0x88
  public            System.Single                   volumetricFogDirectLightingScatteringIntensity  // 0x8C
  public            System.Single                   volumetricFogSkyLightingScatteringIntensity  // 0x90
  public            System.Boolean                  enableFlowNoise  // 0x94
  public            System.Single                   flowNoiseIntensity  // 0x98
  public            System.Single                   flowNoiseDistance  // 0x9C
  public            System.Single                   flowNoiseTilling  // 0xA0
  public            System.Single                   flowNoiseHorizontalDirAngle  // 0xA4
  public            System.Single                   flowNoiseVerticalDirAngle  // 0xA8
  public            UnityEngine.Vector3             flowNoiseDir  // 0xAC
  public            System.Single                   flowNoiseSpeed  // 0xB8
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGVolumetricFogConfigCPP
TYPE:  struct
TOKEN: 0x200002C
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            System.Single                   heightFogStartHeight  // 0x14
  public            System.Single                   heightFogDensity  // 0x18
  public            System.Single                   heightFogFalloff  // 0x1C
  public            System.Single                   heightFogStartHeightSecond  // 0x20
  public            System.Single                   heightFogDensitySecond  // 0x24
  public            System.Single                   heightFogFalloffSecond  // 0x28
  public            UnityEngine.Color               heightFogInscatter  // 0x2C
  public            System.Single                   heightFogMaxOpacity  // 0x3C
  public            System.Single                   heightFogStartDistance  // 0x40
  public            System.Single                   heightFogStartTransition  // 0x44
  public            System.Single                   heightFogCutoffDistance  // 0x48
  public            System.Single                   heightFogCutoffTransition  // 0x4C
  public            System.Single                   volumetricFogScatteringDistribution  // 0x50
  public            UnityEngine.Color               volumetricFogAlbedo  // 0x54
  public            UnityEngine.Color               volumetricFogEmissive  // 0x64
  public            System.Single                   volumetricFogExtinctionScale  // 0x74
  public            System.Single                   volumetricFogDistance  // 0x78
  public            System.Single                   volumetricFogStartDistance  // 0x7C
  public            System.Single                   volumetricFogNearFadeInDistance  // 0x80
  public            System.Single                   volumetricFogDirectLightingScatteringIntensity  // 0x84
  public            System.Single                   volumetricFogSkyLightingScatteringIntensity  // 0x88
  public            System.Boolean                  enableFlowNoise  // 0x8C
  public            System.Single                   flowNoiseIntensity  // 0x90
  public            System.Single                   flowNoiseDistance  // 0x94
  public            System.Single                   flowNoiseTilling  // 0x98
  public            System.Single                   flowNoiseHorizontalDirAngle  // 0x9C
  public            System.Single                   flowNoiseVerticalDirAngle  // 0xA0
  public            UnityEngine.Vector3             flowNoiseDir  // 0xA4
  public            System.Single                   flowNoiseSpeed  // 0xB0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGCloudShadowConfigCPP
TYPE:  struct
TOKEN: 0x200002D
FIELDS:
  public            System.IntPtr                   cloudShadowTexture  // 0x10
  public            UnityEngine.Vector3             cloudShadowEnvCenter  // 0x18
  public            System.Single                   cloudShadowCoverage  // 0x24
  public            System.Single                   cloudShadowFlowSpeed  // 0x28
  public            UnityEngine.Vector2             cloudShadowFlowDirection  // 0x2C
  public            System.Single                   cloudShadowAlpha  // 0x34
  public            System.Single                   cloudShadowDistanceScale  // 0x38
  public            System.Single                   cloudShadowScaleStartDistance  // 0x3C
  public            System.Single                   cloudShadowScaleEndDistance  // 0x40
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGCloudConfigCloudFlowTypeCPP
TYPE:  struct
TOKEN: 0x200002E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryphEngineCode.HGCloudConfigCloudFlowTypeCPPNone  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGCloudConfigCloudFlowTypeCPPProcedural  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGCloudConfigCloudFlowTypeCPPFlowMap  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGCloudConfigCloudTextureModeCPP
TYPE:  struct
TOKEN: 0x200002F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryphEngineCode.HGCloudConfigCloudTextureModeCPPSingleChannelRG  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGCloudConfigCloudTextureModeCPPColorRGB  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGCloudConfigCPP
TYPE:  struct
TOKEN: 0x2000030
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            System.Boolean                  enableCloudShadow  // 0x11
  public            UnityEngine.HyperGryphEngineCode.HGCloudShadowConfigCPPcloudShadowConfig  // 0x18
  public            System.IntPtr                   cloudTexture  // 0x50
  public            UnityEngine.Color               cloudTint  // 0x58
  public            System.Single                   cloudFadeAlpha  // 0x68
  public            System.Single                   cloudContrast  // 0x6C
  public            System.Boolean                  lightAffectCloud  // 0x70
  public            System.Single                   cloudBrightness  // 0x74
  public            System.Single                   cloudAbsoluteBrightness  // 0x78
  public            System.Boolean                  brightnessAffectCloudAlpha  // 0x7C
  public            System.Boolean                  drawCloudAfterPlanet  // 0x7D
  public            UnityEngine.HyperGryphEngineCode.HGCloudConfigCloudFlowTypeCPPcloudTextureMode  // 0x80
  public            System.Single                   cloudOpacityR  // 0x84
  public            System.Single                   cloudOpacityG  // 0x88
  public            UnityEngine.HyperGryphEngineCode.HGCloudConfigCloudTextureModeCPPcloudFlowType  // 0x8C
  public            System.Int32                    rotation  // 0x90
  public            System.IntPtr                   cloudFlowMap  // 0x98
  public            System.Single                   flowSpeed  // 0xA0
  public            System.Single                   flowDirectionX  // 0xA4
  public            System.Single                   flowDirectionY  // 0xA8
  public            System.Boolean                  enableLightShaftCloudMask  // 0xAC
  public            System.IntPtr                   lightShaftCloudMaskTexture  // 0xB0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGRingPropertyCPP
TYPE:  struct
TOKEN: 0x2000031
FIELDS:
  public            System.Single                   outerRadius  // 0x10
  public            System.Single                   width  // 0x14
  public            UnityEngine.Color               ringColor  // 0x18
  public            System.IntPtr                   planetRingMap  // 0x28
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGCelestialObjectConfigCPP
TYPE:  struct
TOKEN: 0x2000032
FIELDS:
  public            System.Single                   radius  // 0x10
  public            System.Single                   orbitRadius  // 0x14
  public            System.Boolean                  enableRing  // 0x18
  public            System.Single                   drawPlanetBelowHorizon  // 0x1C
  public            System.Single                   worldLongitude  // 0x20
  public            System.Single                   worldLatitude  // 0x24
  public            System.Single                   rotationAroundUp  // 0x28
  public            UnityEngine.HyperGryphEngineCode.HGRingPropertyCPPring  // 0x30
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGCelestialObjectPropertyCPP
TYPE:  struct
TOKEN: 0x2000033
FIELDS:
  public            System.Single                   radius  // 0x10
  public            System.Single                   selfTiltX  // 0x14
  public            System.Single                   selfTiltZ  // 0x18
  public            System.Single                   selfRotationY  // 0x1C
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGCelestialDrawerDrawModeCPP
TYPE:  struct
TOKEN: 0x2000034
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryphEngineCode.HGCelestialDrawerDrawModeCPPTexture  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGCelestialDrawerDrawModeCPPSimulated  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGCelestialDrawerCPP
TYPE:  struct
TOKEN: 0x2000035
FIELDS:
  public            UnityEngine.HyperGryphEngineCode.HGCelestialDrawerDrawModeCPPdrawMode  // 0x10
  public            System.IntPtr                   drawMaterial  // 0x18
  public            UnityEngine.Vector2             pitchYaw  // 0x20
  public            UnityEngine.Vector2             incidentLightingPitchYaw  // 0x28
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGAtmospherePropertyCPP
TYPE:  struct
TOKEN: 0x2000036
FIELDS:
  public            System.Single                   bakeFaceVisibility  // 0x10
  public            System.Single                   atmosphereHeight  // 0x14
  public            System.Int32                    numInscatteredSamplePoints  // 0x18
  public            System.Int32                    numOpticalDepthSamplePoints  // 0x1C
  public            System.Single                   coff_R  // 0x20
  public            System.Single                   heightScale_R  // 0x24
  public            System.Single                   atmosphereBrightness  // 0x28
  public            System.Single                   atmosphereHueshift  // 0x2C
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGCelestialAtmosphereObjectConfigCPP
TYPE:  struct
TOKEN: 0x2000037
FIELDS:
  public            System.Boolean                  drawPlanetInSkydome  // 0x10
  public            System.Single                   drawPlanetBelowHorizon  // 0x14
  public            UnityEngine.HyperGryphEngineCode.HGCelestialObjectPropertyCPPobjectProperty  // 0x18
  public            UnityEngine.HyperGryphEngineCode.HGCelestialDrawerCPPskydomeDrawer  // 0x28
  public            System.Boolean                  enableRing  // 0x48
  public            UnityEngine.HyperGryphEngineCode.HGRingPropertyCPPring  // 0x50
  public            System.Boolean                  enableAtmosphere  // 0x70
  public            UnityEngine.HyperGryphEngineCode.HGAtmospherePropertyCPPatmosphere  // 0x74
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGCelestialAdvancedObjectConfigCPP
TYPE:  struct
TOKEN: 0x2000038
FIELDS:
  public            System.Boolean                  drawAdvancedPlanet  // 0x10
  public            System.IntPtr                   advancedPlanetMat  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGCelestialConfigCPP
TYPE:  struct
TOKEN: 0x2000039
FIELDS:
  public            UnityEngine.HyperGryphEngineCode.HGCelestialObjectConfigCPPmoonConfig  // 0x10
  public            UnityEngine.HyperGryphEngineCode.HGCelestialAtmosphereObjectConfigCPPtalosAlphaConfig  // 0x50
  public            UnityEngine.HyperGryphEngineCode.HGCelestialAtmosphereObjectConfigCPPplanetConfig  // 0xD8
  public            UnityEngine.HyperGryphEngineCode.HGCelestialAdvancedObjectConfigCPPadvancedPlanetConfig  // 0x160
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGLightShaftConfigCPP
TYPE:  struct
TOKEN: 0x200003A
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            System.Single                   bloomScale  // 0x14
  public            System.Single                   bloomThreshold  // 0x18
  public            System.Single                   bloomMaxBrightness  // 0x1C
  public            UnityEngine.Color               bloomTint  // 0x20
  public            System.Single                   blurIntensity  // 0x30
  public            System.Single                   occlusionDepthRange  // 0x34
  public            System.Boolean                  enableOcclusion  // 0x38
  public            System.Single                   occlusionMaskDarkness  // 0x3C
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGStarConfigStarTypeCPP
TYPE:  struct
TOKEN: 0x200003B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryphEngineCode.HGStarConfigStarTypeCPPRealTimeNoise  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGStarConfigStarTypeCPPBakedMap  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGStarConfigDebugModeCPP
TYPE:  struct
TOKEN: 0x200003C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryphEngineCode.HGStarConfigDebugModeCPPMaterial  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGStarConfigDebugModeCPPRChannel  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGStarConfigDebugModeCPPGChannel  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGStarConfigDebugModeCPPBChannel  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGStarConfigDebugModeCPPRGBChannel  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGStarConfigStarLayerViewModeCPP
TYPE:  struct
TOKEN: 0x200003D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryphEngineCode.HGStarConfigStarLayerViewModeCPPFullLayer  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGStarConfigStarLayerViewModeCPPRLayer  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGStarConfigStarLayerViewModeCPPGLayer  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGStarConfigStarLayerViewModeCPPBLayer  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGStarConfigCPP
TYPE:  struct
TOKEN: 0x200003E
FIELDS:
  public            System.Boolean                  enableStars  // 0x10
  public            UnityEngine.HyperGryphEngineCode.HGStarConfigStarTypeCPPstarType  // 0x14
  public            System.IntPtr                   noiseRenderTex  // 0x18
  public            System.Single                   starsSize  // 0x20
  public            System.Single                   starsFlickerSpeed  // 0x24
  public            UnityEngine.Color               starsTint  // 0x28
  public            System.Single                   starsOffset0  // 0x38
  public            System.Single                   starsDensityR  // 0x3C
  public            System.Single                   starsDensity  // 0x40
  public            System.Single                   starsExposure  // 0x44
  public            UnityEngine.Color               starsTint1  // 0x48
  public            System.Single                   starsOffset1  // 0x58
  public            System.Single                   starsDensityG  // 0x5C
  public            System.Single                   starsDensity1  // 0x60
  public            System.Single                   starsExposure1  // 0x64
  public            UnityEngine.Color               starsTint2  // 0x68
  public            System.Single                   starsOffset2  // 0x78
  public            System.Single                   starsDensityB  // 0x7C
  public            System.Single                   starsDensity2  // 0x80
  public            System.Single                   starsExposure2  // 0x84
  public            UnityEngine.HyperGryphEngineCode.HGStarConfigStarLayerViewModeCPPstarLayerViewMode  // 0x88
  public            System.IntPtr                   skyboxStarNoiseMap  // 0x90
  public            System.IntPtr                   skyBoxStarRangeMap  // 0x98
  public            System.Single                   skyBoxStarDensityMapRotation  // 0xA0
  public            UnityEngine.HyperGryphEngineCode.HGStarConfigDebugModeCPPdebugMode  // 0xA4
  public            System.Boolean                  enableNebula  // 0xA8
  public            System.IntPtr                   nebulaMap  // 0xB0
  public            UnityEngine.Color               nebulaTint  // 0xB8
  public            System.Single                   nebulaMapRotation  // 0xC8
  public            System.Single                   nebulaStarConverage  // 0xCC
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.ScreenSpaceReflectionVolumeCPP
TYPE:  struct
TOKEN: 0x200003F
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            System.Single                   fadenessOnScreen  // 0x14
  public            System.Single                   fadenessOnDepth  // 0x18
  public            System.Single                   fadenessOnDepthFactor  // 0x1C
  public            System.Single                   fadenessOnMirrorMul  // 0x20
  public            System.Single                   fadenessOnMirrorAdd  // 0x24
  public            System.Single                   mipThreshold  // 0x28
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGAutoExposureConfigCPP
TYPE:  struct
TOKEN: 0x2000040
FIELDS:
  public            System.Boolean                  autoMode  // 0x10
  public            System.Boolean                  centerMode  // 0x11
  public            System.Boolean                  curveEditModeEnabled  // 0x12
  public            UnityEngine.Vector2             ev100Range  // 0x14
  public            UnityEngine.Vector2             ev100HistogramRange  // 0x1C
  public            UnityEngine.Vector2             pixelLuminanceRange  // 0x24
  public            System.Single                   centerPixelWeight  // 0x2C
  public            System.Single                   evCompensationManual  // 0x30
  public            System.Single                   evCompensationAuto  // 0x34
  public            UnityEngine.Vector2             evClampRange  // 0x38
  public            System.Single                   lerpDownSpeed  // 0x40
  public            System.Single                   lerpUpSpeed  // 0x44
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGToneMappingModeCPP
TYPE:  struct
TOKEN: 0x2000041
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryphEngineCode.HGToneMappingModeCPPNone  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGToneMappingModeCPPNeutral  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGToneMappingModeCPPACES  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGToneMappingModeCPPCustom  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGToneMappingModeCPPExternal  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGToneMappingModeCPPACES_Modified  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGToneMappingModeCPPCount  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGColorGradingConfigCPP
TYPE:  struct
TOKEN: 0x2000042
FIELDS:
  public            System.Boolean                  active  // 0x10
  public            System.Boolean                  colorLookupEnabled  // 0x11
  public            System.IntPtr                   colorLookupTexture  // 0x18
  public            System.Single                   colorLookupContribution  // 0x20
  public            System.Boolean                  colorAdjustmentsEnabled  // 0x24
  public            System.Single                   colorAdjustmentsPostExposure  // 0x28
  public            System.Boolean                  colorCurveDirty  // 0x2C
  public            UnityEngine.HyperGryphEngineCode.HGToneMappingModeCPPToneMappingMode  // 0x30
  public            System.Single                   whiteBalanceTemperature  // 0x34
  public            System.Single                   whiteBalanceTint  // 0x38
  public            System.Single                   colorAdjustmentsHueShift  // 0x3C
  public            System.Single                   colorAdjustmentsSaturation  // 0x40
  public            System.Single                   colorAdjustmentsContrast  // 0x44
  public            System.Single                   channelMixerRedOutRedIn  // 0x48
  public            System.Single                   channelMixerRedOutGreenIn  // 0x4C
  public            System.Single                   channelMixerRedOutBlueIn  // 0x50
  public            System.Single                   channelMixerGreenOutRedIn  // 0x54
  public            System.Single                   channelMixerGreenOutGreenIn  // 0x58
  public            System.Single                   channelMixerGreenOutBlueIn  // 0x5C
  public            System.Single                   channelMixerBlueOutRedIn  // 0x60
  public            System.Single                   channelMixerBlueOutGreenIn  // 0x64
  public            System.Single                   channelMixerBlueOutBlueIn  // 0x68
  public            UnityEngine.Vector4             shadows  // 0x6C
  public            UnityEngine.Vector4             midTones  // 0x7C
  public            UnityEngine.Vector4             highLights  // 0x8C
  public            System.Single                   shadowsStart  // 0x9C
  public            System.Single                   shadowsEnd  // 0xA0
  public            System.Single                   highLightsStart  // 0xA4
  public            System.Single                   highLightsEnd  // 0xA8
  public            UnityEngine.Vector4             lift  // 0xAC
  public            UnityEngine.Vector4             gamma  // 0xBC
  public            UnityEngine.Vector4             gain  // 0xCC
  public            UnityEngine.Vector3             splitShadows  // 0xDC
  public            UnityEngine.Vector3             splitToneHighLights  // 0xE8
  public            System.Single                   splitToningBalance  // 0xF4
  public            System.Int32                    masterCurve  // 0xF8
  public            System.Int32                    redCurve  // 0xFC
  public            System.Int32                    greenCurve  // 0x100
  public            System.Int32                    blueCurve  // 0x104
  public            System.Int32                    hueVsHueCurve  // 0x108
  public            System.Int32                    hueVsSatCurve  // 0x10C
  public            System.Int32                    lumVsSatCurve  // 0x110
  public            System.Int32                    satVsSatCurve  // 0x114
  public            UnityEngine.Vector4             colorFilter  // 0x118
  public            UnityEngine.Vector4             miscPrams  // 0x128
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGContactShadowConfigCPP
TYPE:  struct
TOKEN: 0x2000043
FIELDS:
  public            System.Boolean                  ignoreEdgePixels  // 0x10
  public            System.Boolean                  disableTerrainContactShadow  // 0x11
  public            System.Single                   intensity  // 0x14
  public            System.Single                   surfaceThickness  // 0x18
  public            System.Single                   bilinearThreshold  // 0x1C
  public            System.Int32                    contract  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGShadowConfigCPP
TYPE:  struct
TOKEN: 0x2000044
FIELDS:
  public            System.Single                   csmDepthBias  // 0x10
  public            System.Single                   csmNormalBias  // 0x14
  public            System.Single                   csmIntensity  // 0x18
  public            System.IntPtr                   csmRampTexture  // 0x20
  public            System.Single                   csmShadowSoftness  // 0x28
  public            System.Single                   asmCasterMinY  // 0x2C
  public            System.Single                   asmCasterMaxY  // 0x30
  public            System.Single                   contactShadowIntensity  // 0x34
  public            System.Single                   contactShadowSurfaceThickness  // 0x38
  public            System.Single                   contactShadowBilinearThreshold  // 0x3C
  public            System.Single                   contactShadowContract  // 0x40
  public            System.Boolean                  contactShadowIgnoreEdgePixels  // 0x44
  public            System.Boolean                  overrideCsmFarDistanceEnabled  // 0x45
  public            System.Single                   overrideCsmFarDistance  // 0x48
  public            System.Boolean                  manualOverrideCsmRendering  // 0x4C
  public            UnityEngine.Vector3             overrideCsmSpherePosition  // 0x50
  public            System.Single                   overrideCsmSphereRadius  // 0x5C
  public            System.Boolean                  disableCsm  // 0x60
  public            System.Single                   disableCsmBlendFactor  // 0x64
  public            System.Single                   csmSimulatedAttenuation  // 0x68
  public            System.Boolean                  disableAsm  // 0x6C
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGEnvironmentPhaseCPP
TYPE:  struct
TOKEN: 0x2000045
FIELDS:
  public            UnityEngine.HyperGryphEngineCode.HGLightConfigCPP*lightConfig  // 0x10
  public            UnityEngine.HyperGryphEngineCode.HGSkyConfigCPP*skyConfig  // 0x18
  public            UnityEngine.HyperGryphEngineCode.HGAtmosphereConfigCPP*atmosphereConfig  // 0x20
  public            UnityEngine.HyperGryphEngineCode.HGFogConfigCPP*fogConfig  // 0x28
  public            UnityEngine.HyperGryphEngineCode.HGHeightFogConfigCPP*heightFogConfig  // 0x30
  public            UnityEngine.HyperGryphEngineCode.HGVolumetricFogConfigCPP*volumetricFogConfig  // 0x38
  public            UnityEngine.HyperGryphEngineCode.HGCloudConfigCPP*cloudConfig  // 0x40
  public            UnityEngine.HyperGryphEngineCode.HGCelestialConfigCPP*celestialConfig  // 0x48
  public            UnityEngine.HyperGryphEngineCode.HGLightShaftConfigCPP*lightShaftConfig  // 0x50
  public            UnityEngine.HyperGryphEngineCode.HGStarConfigCPP*starConfig  // 0x58
  public            UnityEngine.HyperGryphEngineCode.HGAutoExposureConfigCPP*autoExposureConfig  // 0x60
  public            UnityEngine.HyperGryphEngineCode.HGColorGradingConfigCPP*colorGradingConfig  // 0x68
  public            UnityEngine.HyperGryphEngineCode.HGContactShadowConfigCPP*contactShadowConfig  // 0x70
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.FishEyeEffectVolumeCPP
TYPE:  struct
TOKEN: 0x2000046
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            System.Single                   distortion  // 0x14
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.BloomQuality
TYPE:  struct
TOKEN: 0x2000047
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryphEngineCode.BloomQualityLow  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.BloomQualityMedium  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.BloomQualityHigh  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.BloomResolution
TYPE:  struct
TOKEN: 0x2000048
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryphEngineCode.BloomResolutionQuarter  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.BloomResolutionHalf  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.BloomBlendMode
TYPE:  struct
TOKEN: 0x2000049
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryphEngineCode.BloomBlendModeAdd  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.BloomBlendModeEnergyConservation  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.BloomVolumeCPP
TYPE:  struct
TOKEN: 0x200004A
FIELDS:
  public            System.Single                   intensity  // 0x10
  public            UnityEngine.Color               tint  // 0x14
  public            System.IntPtr                   dirtTexture  // 0x28
  public            System.Single                   dirtIntensity  // 0x30
  public            UnityEngine.HyperGryphEngineCode.BloomBlendModeblendMode  // 0x34
  public            System.Single                   anamorphic  // 0x38
  public            System.Single                   scatter  // 0x3C
  public            System.Single                   threshold  // 0x40
  public            System.Single                   characterThreshold  // 0x44
  public            System.Single                   characterSoftness  // 0x48
  public            System.Single                   characterIntensity  // 0x4C
  public            UnityEngine.HyperGryphEngineCode.BloomResolutionresolution  // 0x50
  public            System.Boolean                  enableBloomDirt  // 0x54
  public            System.Boolean                  enableCharacterBloomControl  // 0x55
  public            System.Boolean                  enableAlpha  // 0x56
  public            System.Boolean                  enableAnamorphic  // 0x57
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGSharpenMode
TYPE:  struct
TOKEN: 0x200004B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryphEngineCode.HGSharpenModeOff  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGSharpenModeFilter1  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGSharpenModeFilter2  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGSharpenModeFilter4  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.VignetteMode
TYPE:  struct
TOKEN: 0x200004C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryphEngineCode.VignetteModeProcedural  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.VignetteModeMasked  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.VignetteCPP
TYPE:  struct
TOKEN: 0x200004D
FIELDS:
  public            UnityEngine.HyperGryphEngineCode.VignetteModemode  // 0x10
  public            UnityEngine.Color               color  // 0x14
  public            UnityEngine.Vector2             center  // 0x24
  public            System.Single                   intensity  // 0x2C
  public            System.Single                   smoothness  // 0x30
  public            System.Single                   roundness  // 0x34
  public            System.Boolean                  rounded  // 0x38
  public            System.Boolean                  blink  // 0x39
  public            System.IntPtr                   mask  // 0x40
  public            System.Single                   opacity  // 0x48
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGVignetteCPP
TYPE:  struct
TOKEN: 0x200004E
FIELDS:
  public            UnityEngine.Color               color  // 0x10
  public            System.Single                   intensity  // 0x20
  public            System.Single                   smoothness  // 0x24
  public            System.Boolean                  rounded  // 0x28
  public            System.Boolean                  blink  // 0x29
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGDirtyLensCPP
TYPE:  struct
TOKEN: 0x200004F
FIELDS:
  public            System.IntPtr                   dirtyTex  // 0x10
  public            System.Single                   intensity  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGRadialBlurCPP
TYPE:  struct
TOKEN: 0x2000050
FIELDS:
  public            System.Boolean                  enabled  // 0x10
  public            UnityEngine.Vector2             center  // 0x14
  public            System.Single                   intensity  // 0x1C
  public            System.Single                   power  // 0x20
  public            System.Boolean                  averageSteps  // 0x24
  public            System.Boolean                  enableGlobalCenter  // 0x25
  public            UnityEngine.Vector3             globalCenter  // 0x28
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGChromaticAbberationCPP
TYPE:  struct
TOKEN: 0x2000051
FIELDS:
  public            System.Boolean                  enabled  // 0x10
  public            UnityEngine.Vector2             center  // 0x14
  public            System.Single                   intensity  // 0x1C
  public            System.Boolean                  averageStep  // 0x20
  public            System.Boolean                  enableGlobalCenter  // 0x21
  public            UnityEngine.Vector3             globalCenter  // 0x24
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGBWFlashCPP
TYPE:  struct
TOKEN: 0x2000052
FIELDS:
  public            System.Boolean                  enabled  // 0x10
  public            UnityEngine.Vector2             centerPosition  // 0x14
  public            System.Single                   bwThreshold  // 0x1C
  public            System.Single                   colorBias  // 0x20
  public            System.Boolean                  inverse  // 0x24
  public            System.Boolean                  useFlashTex  // 0x25
  public            System.IntPtr                   flashTexture  // 0x28
  public            UnityEngine.Vector2             flashTexTiling  // 0x30
  public            UnityEngine.Vector2             flashTexOffset  // 0x38
  public            UnityEngine.Vector2             flashTexSpeed  // 0x40
  public            UnityEngine.Vector2             flashIntensity  // 0x48
  public            System.Boolean                  useMaskTex  // 0x50
  public            System.IntPtr                   maskTexture  // 0x58
  public            System.Single                   maskIntensity  // 0x60
  public            System.Boolean                  maskUsePolarUV  // 0x64
  public            UnityEngine.Vector2             maskTexTiling  // 0x68
  public            UnityEngine.Vector2             maskTexOffset  // 0x70
  public            UnityEngine.Color               flashColor  // 0x78
  public            UnityEngine.Color               backGroundColor  // 0x88
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.SharpenVolumeCPP
TYPE:  struct
TOKEN: 0x2000053
FIELDS:
  public            System.Boolean                  isActive  // 0x10
  public            UnityEngine.HyperGryphEngineCode.HGSharpenModesharpenMode  // 0x14
  public            System.Single                   sharpenRange  // 0x18
  public            System.Single                   sharpenIntensity  // 0x1C
  public            System.Single                   sharpenThreshold  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGVolumeComponentsDataCPP
TYPE:  struct
TOKEN: 0x2000054
FIELDS:
  public            UnityEngine.HyperGryphEngineCode.BloomVolumeCPP*m_bloomVolume  // 0x10
  public            UnityEngine.HyperGryphEngineCode.VignetteCPP*m_vignette  // 0x18
  public            UnityEngine.HyperGryphEngineCode.HGVignetteCPP*m_hgVignette  // 0x20
  public            UnityEngine.HyperGryphEngineCode.HGDirtyLensCPP*m_hgDirtyLens  // 0x28
  public            UnityEngine.HyperGryphEngineCode.SharpenVolumeCPP*m_sharpenVolume  // 0x30
  public            UnityEngine.HyperGryphEngineCode.HGRadialBlurCPP*m_radialBlur  // 0x38
  public            UnityEngine.HyperGryphEngineCode.HGBWFlashCPP*m_bwFlash  // 0x40
  public            UnityEngine.HyperGryphEngineCode.FishEyeEffectVolumeCPP*m_fishEyeVolume  // 0x48
  public            UnityEngine.HyperGryphEngineCode.HGChromaticAbberationCPP*m_chromaticAbberation  // 0x50
  public            UnityEngine.HyperGryphEngineCode.ScreenSpaceReflectionVolumeCPP*m_hgssrVolume  // 0x58
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGLensFlareBlendMode
TYPE:  struct
TOKEN: 0x2000055
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryphEngineCode.HGLensFlareBlendModeAdditive  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGLensFlareBlendModeScreen  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGLensFlareBlendModePremultiply  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGLensFlareBlendModeLerp  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGLensFlareDistribution
TYPE:  struct
TOKEN: 0x2000056
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryphEngineCode.HGLensFlareDistributionUniform  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGLensFlareDistributionCurve  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGLensFlareDistributionRandom  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGLensFlareType
TYPE:  struct
TOKEN: 0x2000057
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryphEngineCode.HGLensFlareTypeImage  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGLensFlareTypeCircle  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGLensFlareTypePolygon  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGLensFlareDrawData
TYPE:  struct
TOKEN: 0x2000058
FIELDS:
  public            System.Boolean                  useOcclusion  // 0x10
  public            System.Boolean                  allowMultipleElement  // 0x11
  public            System.Boolean                  inverseSDF  // 0x12
  public            System.Int32                    elementCount  // 0x14
  public            UnityEngine.HyperGryphEngineCode.HGLensFlareBlendModeblendMode  // 0x18
  public            UnityEngine.HyperGryphEngineCode.HGLensFlareDistributiondistribution  // 0x1C
  public            UnityEngine.HyperGryphEngineCode.HGLensFlareTypeflareType  // 0x20
  public            UnityEngine.Rendering.CBHandle  lensFlareCBHandle  // 0x28
  public            System.IntPtr                   flareOcclusionTexture  // 0x40
  public            System.IntPtr                   flareTexture  // 0x48
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGRenderPipelineDebugResourcesShaderResourcesCPP
TYPE:  struct
TOKEN: 0x2000059
FIELDS:
  public            System.Int32                    debugFullScreenClearBufferCS  // 0x10
  public            System.Int32                    debugFetchPixelDataCS  // 0x14
  public            System.Int32                    debugFetchQuadOverdrawDataCS  // 0x18
  public            System.Int32                    debugReflectionProbeCS  // 0x1C
  public            System.Int32                    debugDepthPyramidReadbackCS  // 0x20
  public            System.Int32                    debugReflectionProbePS  // 0x24
  public            System.Int32                    debugDisplayPS  // 0x28
  public            System.Int32                    debugGizmosShapePS  // 0x2C
  public            System.Int32                    debugGizmosDecalPS  // 0x30
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGRenderPipelineDebugResourcesMaterialResourcesCPP
TYPE:  struct
TOKEN: 0x200005A
FIELDS:
  public            System.Int32                    debugGizmosMat  // 0x10
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGRenderPipelineDebugResourcesTextureResourcesCPP
TYPE:  struct
TOKEN: 0x200005B
FIELDS:
  public            System.Int32                    debugTexelDensityTexArray  // 0x10
  public            System.Int32                    debugAlbedoTex  // 0x14
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGRenderPipelineDebugResourcesCPP
TYPE:  struct
TOKEN: 0x200005C
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            UnityEngine.HyperGryphEngineCode.HGRenderPipelineDebugResourcesShaderResourcesCPPshaders  // 0x14
  public            UnityEngine.HyperGryphEngineCode.HGRenderPipelineDebugResourcesMaterialResourcesCPPmaterials  // 0x38
  public            UnityEngine.HyperGryphEngineCode.HGRenderPipelineDebugResourcesTextureResourcesCPPtextures  // 0x3C
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGRenderPipelineRuntimeResourcesShaderResourcesCPP
TYPE:  struct
TOKEN: 0x200005D
FIELDS:
  public            System.Int32                    defaultPS  // 0x10
  public            System.Int32                    defaultUnlitPS  // 0x14
  public            System.Int32                    inkSimulationPS  // 0x18
  public            System.Int32                    characterLitPS  // 0x1C
  public            System.Int32                    characterLitHairPS  // 0x20
  public            System.Int32                    characterLitSkinPS  // 0x24
  public            System.Int32                    deferredPS  // 0x28
  public            System.Int32                    deferredWriteAlphaPS  // 0x2C
  public            System.Int32                    deferredPerLightPS  // 0x30
  public            System.Int32                    colorPyramidPS  // 0x34
  public            System.Int32                    depthPyramidCS  // 0x38
  public            System.Int32                    buildHZBCS  // 0x3C
  public            System.Int32                    maxZCS  // 0x40
  public            System.Int32                    lightBinningXYCS  // 0x44
  public            System.Int32                    lightBinningZCS  // 0x48
  public            System.Int32                    singleColorPS  // 0x4C
  public            System.Int32                    particleCleanupCS  // 0x50
  public            System.Int32                    particleInitCS  // 0x54
  public            System.Int32                    particleCullCS  // 0x58
  public            System.Int32                    particleSortCS  // 0x5C
  public            System.Int32                    particleIndirectArgsCS  // 0x60
  public            System.Int32                    physicalParticleEmitCS  // 0x64
  public            System.Int32                    senderParticleEmitCS  // 0x68
  public            System.Int32                    recieverParticleEmitCS  // 0x6C
  public            System.Int32                    physicalParticleSimulateCS  // 0x70
  public            System.Int32                    senderParticleSimulateCS  // 0x74
  public            System.Int32                    recieverParticleSimulateCS  // 0x78
  public            System.Int32                    physicalParticleRenderPS  // 0x7C
  public            System.Int32                    reflectionProbeBinningCS  // 0x80
  public            System.Int32                    GTAmbientOcclusionCS  // 0x84
  public            System.Int32                    copyChannelCS  // 0x88
  public            System.Int32                    clearStencilBufferPS  // 0x8C
  public            System.Int32                    copyStencilBufferPS  // 0x90
  public            System.Int32                    copyDepthBufferPS  // 0x94
  public            System.Int32                    blitPS  // 0x98
  public            System.Int32                    blitColorAndDepthPS  // 0x9C
  public            System.Int32                    blitMotionVectorPS  // 0xA0
  public            System.Int32                    vsmPassPS  // 0xA4
  public            System.Int32                    blurPS  // 0xA8
  public            System.Int32                    lowResBlitPS  // 0xAC
  public            System.Int32                    copyBufferCS  // 0xB0
  public            System.Int32                    taauDilationPS  // 0xB4
  public            System.Int32                    taauMaskDilationPS  // 0xB8
  public            System.Int32                    taauResolvePS  // 0xBC
  public            System.Int32                    encodeBC6HCS  // 0xC0
  public            System.Int32                    cubeToPanoPS  // 0xC4
  public            System.Int32                    blitCubeTextureFacePS  // 0xC8
  public            System.Int32                    clearUIntTextureCS  // 0xCC
  public            System.Int32                    texture3DAtlasCS  // 0xD0
  public            System.Int32                    shadowClearPS  // 0xD4
  public            System.Int32                    shadowBlitPS  // 0xD8
  public            System.Int32                    shadowBlurPS  // 0xDC
  public            System.Int32                    lowResDirectionalShadowPS  // 0xE0
  public            System.Int32                    screenSpaceShadowResolvePS  // 0xE4
  public            System.Int32                    capsuleShadowCasterPS  // 0xE8
  public            System.Int32                    hizDownSampleCS  // 0xEC
  public            System.Int32                    renderAtmosphereLutPS  // 0xF0
  public            System.Int32                    renderAtmosphereLutCS  // 0xF4
  public            System.Int32                    proceduralSkyPS  // 0xF8
  public            System.Int32                    skyBoxCubemapPS  // 0xFC
  public            System.Int32                    volumetricFogGridInjectionCS  // 0x100
  public            System.Int32                    volumetricFogLightScatteringCS  // 0x104
  public            System.Int32                    volumetricFogFinalIntegrationCS  // 0x108
  public            System.Int32                    bakeFogLutPS  // 0x10C
  public            System.Int32                    clothDataUploadCS  // 0x110
  public            System.Int32                    clothSingleDispatchCS  // 0x114
  public            System.Int32                    drawInteractionNodePS  // 0x118
  public            System.Int32                    terrainRenderCS  // 0x11C
  public            System.Int32                    terrainRenderPS  // 0x120
  public            System.Int32                    terrainDeformEditorGenerateCS  // 0x124
  public            System.Int32                    terrainDeformEditorGroundLayerCS  // 0x128
  public            System.Int32                    terrainDeformGenerateV2CS  // 0x12C
  public            System.Int32                    terrainDeformGenerateCS  // 0x130
  public            System.Int32                    terrainDeformReprojectHistoryCS  // 0x134
  public            System.Int32                    terrainDeformSpatialFilterCS  // 0x138
  public            System.Int32                    terrainDeformGenerateNormalCS  // 0x13C
  public            System.Int32                    terrainDeformGenerateDensityCS  // 0x140
  public            System.Int32                    terrainDeformEdgeDetectionCS  // 0x144
  public            System.Int32                    terrainGroundLayerClipmapCS  // 0x148
  public            System.Int32                    lutBuilder3DCS  // 0x14C
  public            System.Int32                    lutBuilder2DPS  // 0x150
  public            System.Int32                    hgAutoExposureHistogramCS  // 0x154
  public            System.Int32                    uberPostPS  // 0x158
  public            System.Int32                    CutsceneEffectPS  // 0x15C
  public            System.Int32                    bloomPS  // 0x160
  public            System.Int32                    sharpenPS  // 0x164
  public            System.Int32                    finalPassPS  // 0x168
  public            System.Int32                    blitBackBufferPS  // 0x16C
  public            System.Int32                    bloomPrefilterCS  // 0x170
  public            System.Int32                    bloomBlurCS  // 0x174
  public            System.Int32                    bloomBlurNonOptCS  // 0x178
  public            System.Int32                    bloomUpsampleCS  // 0x17C
  public            System.Int32                    skillScanLinePS  // 0x180
  public            System.Int32                    sceneColorAdjustmentPS  // 0x184
  public            System.Int32                    frostedGlassBlurCS  // 0x188
  public            System.Int32                    frostedGlassBlurPS  // 0x18C
  public            System.Int32                    lensFlareDataDrivenPS  // 0x190
  public            System.Int32                    uiImageBlurPS  // 0x194
  public            System.Int32                    smaaPS  // 0x198
  public            System.Int32                    lightShaftPS  // 0x19C
  public            System.Int32                    depthOfFieldPS  // 0x1A0
  public            System.Int32                    depthOfFieldMobilePS  // 0x1A4
  public            System.Int32                    depthOfFieldHexagonalPS  // 0x1A8
  public            System.Int32                    circleDepthOfFieldCS  // 0x1AC
  public            System.Int32                    motionBlurCS  // 0x1B0
  public            System.Int32                    screenSpaceReflectionCS  // 0x1B4
  public            System.Int32                    screenSpaceReflectionPS  // 0x1B8
  public            System.Int32                    ssprCS  // 0x1BC
  public            System.Int32                    contactShadowCS  // 0x1C0
  public            System.Int32                    foliageOccluderPS  // 0x1C4
  public            System.Int32                    foliageOccluderBlitPS  // 0x1C8
  public            System.Int32                    foliageInteractiveBlitPS  // 0x1CC
  public            System.Int32                    foliageInteractiveColliderPS  // 0x1D0
  public            System.Int32                    sludgeBlitPS  // 0x1D4
  public            System.Int32                    sludgePS  // 0x1D8
  public            System.Int32                    waterRenderingPS  // 0x1DC
  public            System.Int32                    waterOcclusionCS  // 0x1E0
  public            System.Int32                    rippleRangePS  // 0x1E4
  public            System.Int32                    rippleSimulationPS  // 0x1E8
  public            System.Int32                    rippleHeightConvertPS  // 0x1EC
  public            System.Int32                    waterProxyPS  // 0x1F0
  public            System.Int32                    waterForwardRenderingPS  // 0x1F4
  public            System.Int32                    waterTextureProcessPS  // 0x1F8
  public            System.Int32                    ivBakeV2CS  // 0x1FC
  public            System.Int32                    ivIndirectV2CS  // 0x200
  public            System.Int32                    ivBakeV3CS  // 0x204
  public            System.Int32                    ivClipmapUpdateCS  // 0x208
  public            System.Int32                    ivUpdateV3CS  // 0x20C
  public            System.Int32                    ivCopyBufferCS  // 0x210
  public            System.Int32                    volumetricCloudMSBakePS  // 0x214
  public            System.Int32                    volumetricCloudEmptySkipPS  // 0x218
  public            System.Int32                    volumetricComposePS  // 0x21C
  public            System.Int32                    farRainPS  // 0x220
  public            System.Int32                    sceneEffectRainPS  // 0x224
  public            System.Int32                    screenRainDropFXShader  // 0x228
  public            System.Int32                    rainSplashShader  // 0x22C
  public            System.Int32                    scanLineHighlightShader  // 0x230
  public            System.Int32                    fakeVolumeFogPS  // 0x234
  public            System.Int32                    clearDepth  // 0x238
  public            System.Int32                    particleLightingCS  // 0x23C
  public            System.Int32                    shaderLODPS  // 0x240
  public            System.Int32                    visibilitySHPS  // 0x244
  public            System.Int32                    visibilitySHCS  // 0x248
  public            System.Int32                    dlssVelocityCombineCS  // 0x24C
  public            System.Int32                    dlssGFlipBlitCS  // 0x250
  public            System.Int32                    dlssGUIHintCS  // 0x254
  public            System.Int32                    rayTracingReflectionPS  // 0x258
  public            System.Int32                    rayTracingReflectionCS  // 0x25C
  public            System.Int32                    rayTracingBinningCS  // 0x260
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGRenderPipelineRuntimeResourcesTextureResourcesCPP
TYPE:  struct
TOKEN: 0x200005E
FIELDS:
  public            System.Int32                    HeightFogNoise3DTex  // 0x10
  public            System.Int32                    GlintCellNoiseTex  // 0x14
  public            System.Int32                    PerlinNoiseTex  // 0x18
  public            System.Int32                    SnowDetailNormal  // 0x1C
  public            System.Int32                    VisibilityABLut  // 0x20
  public            System.Int32                    VisibilitySHLut  // 0x24
  public            System.Int32                    WindGlobalNoiseTex  // 0x28
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGRenderPipelineRuntimeResourcesAssetResourcesCPP
TYPE:  struct
TOKEN: 0x200005F
FIELDS:
  public            System.Int32                    simpleSphereMesh  // 0x10
  public            System.Int32                    defaultCapsuleMesh  // 0x14
  public            System.Int32                    defaultCubeMesh  // 0x18
  public            System.Int32                    defaultConeMesh  // 0x1C
  public            System.Int32                    defaultQuadMesh  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGRenderPipelineRuntimeResourcesCPP
TYPE:  struct
TOKEN: 0x2000060
FIELDS:
  public            UnityEngine.HyperGryphEngineCode.HGRenderPipelineRuntimeResourcesShaderResourcesCPPshaders  // 0x10
  public            UnityEngine.HyperGryphEngineCode.HGRenderPipelineRuntimeResourcesTextureResourcesCPPtextures  // 0x264
  public            UnityEngine.HyperGryphEngineCode.HGRenderPipelineRuntimeResourcesAssetResourcesCPPassets  // 0x280
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.InkSimulationPassInput
TYPE:  struct
TOKEN: 0x2000061
FIELDS:
  public            System.IntPtr                   material  // 0x10
  public            System.Single                   influence  // 0x18
  public            UnityEngine.Vector3             center  // 0x1C
  public            System.Single                   deltaTime  // 0x28
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.TerrainDeformPassInput
TYPE:  struct
TOKEN: 0x2000062
FIELDS:
  public            System.IntPtr                   drawInteractionNodeMaterial  // 0x10
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.TerrainDepthPrepassInput
TYPE:  struct
TOKEN: 0x2000063
FIELDS:
  public            System.Boolean                  enableTerrainTessellation  // 0x10
  public            System.Boolean                  enableTerrainSubdivision  // 0x11
  public            System.Boolean                  enableTerrainSubdivisionV2  // 0x12
  public            System.Boolean                  enableTerrainDecalDeform  // 0x13
  public            System.Boolean                  enableTerrainWetRipple  // 0x14
  public            UnityEngine.HyperGryphEngineCode.HGTerrainLayerTypeData*layerTypeData  // 0x18
  public            System.Int32                    subdivisionHandle  // 0x20
  public            System.UInt32                   terrainCullViewHandle  // 0x24
  public            System.UInt32                   editorTerrainCullViewHandle  // 0x28
  public            System.Int32                    vtFeedbackId  // 0x2C
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGViewConstantsCPP
TYPE:  struct
TOKEN: 0x2000064
FIELDS:
  public            UnityEngine.Matrix4x4           viewMatrix  // 0x10
  public            UnityEngine.Matrix4x4           invViewMatrix  // 0x50
  public            UnityEngine.Matrix4x4           projMatrix  // 0x90
  public            UnityEngine.Matrix4x4           nonJitteredProjMatrix  // 0xD0
  public            UnityEngine.Matrix4x4           invProjMatrix  // 0x110
  public            UnityEngine.Matrix4x4           viewProjMatrix  // 0x150
  public            UnityEngine.Matrix4x4           viewNoTransProjMatrix  // 0x190
  public            UnityEngine.Matrix4x4           invViewProjMatrix  // 0x1D0
  public            UnityEngine.Matrix4x4           nonJitteredViewProjMatrix  // 0x210
  public            UnityEngine.Matrix4x4           nonJitteredViewNoTransProjMatrix  // 0x250
  public            UnityEngine.Matrix4x4           invNonJitteredViewProjMatrix  // 0x290
  public            UnityEngine.Matrix4x4           prevViewMatrix  // 0x2D0
  public            UnityEngine.Matrix4x4           prevViewProjMatrix  // 0x310
  public            UnityEngine.Matrix4x4           prevViewNoTransProjMatrix  // 0x350
  public            UnityEngine.Matrix4x4           prevNonJitteredViewProjMatrix  // 0x390
  public            UnityEngine.Matrix4x4           prevNonJitteredViewNoTransProjMatrix  // 0x3D0
  public            UnityEngine.Matrix4x4           prevInvViewProjMatrix  // 0x410
  public            UnityEngine.Matrix4x4           prevNonJitteredInvViewProjMatrix  // 0x450
  public            UnityEngine.Matrix4x4           reprojectionMatrix  // 0x490
  public            UnityEngine.Matrix4x4           widerFoVViewProjMatrix  // 0x4D0
  public            UnityEngine.Matrix4x4           widerFoVInvViewProjMatrix  // 0x510
  public            UnityEngine.Matrix4x4           pixelCoordToViewDirWS  // 0x550
  public            UnityEngine.Matrix4x4           cullingMatrix  // 0x590
  public            UnityEngine.Vector3             worldSpaceCameraPos  // 0x5D0
  public            System.Single                   pad0  // 0x5DC
  public            UnityEngine.Vector3             worldSpaceCameraPosViewOffset  // 0x5E0
  public            System.Single                   pad1  // 0x5EC
  public            UnityEngine.Vector3             prevWorldSpaceCameraPos  // 0x5F0
  public            System.Single                   pad2  // 0x5FC
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGRenderPathOtherData
TYPE:  struct
TOKEN: 0x2000065
FIELDS:
  public            System.Boolean                  taaEnabled  // 0x10
  public            System.Single                   taaSharpenStrength  // 0x14
  public            System.Int32                    taaFrameIndex  // 0x18
  public            UnityEngine.Vector4             taaJitter  // 0x1C
  public            System.Single                   globalMipBias  // 0x2C
  public            System.Single                   exposureAdaptation  // 0x30
  public            System.Single                   characterLightSmoothFactor  // 0x34
  public            System.Single                   time  // 0x38
  public            System.Single                   lastTime  // 0x3C
  public            System.Single                   gameplayTime  // 0x40
  public            System.Single                   lastGameplayTime  // 0x44
  public            System.Single                   deltaTime  // 0x48
  public            System.Single                   smoothDeltaTime  // 0x4C
  public            System.UInt32                   frameCount  // 0x50
  public            UnityEngine.Vector4             _Style_MatDistCoef  // 0x54
  public            UnityEngine.Vector4             _Style_MatFarAlb0  // 0x64
  public            UnityEngine.Vector4             _Style_MatFarAlb1  // 0x74
  public            UnityEngine.Vector4             _Style_GbFarEms  // 0x84
  public            UnityEngine.Vector4             _Style_GbFarDir  // 0x94
  public            UnityEngine.Vector4             _Style_GbCoef  // 0xA4
  public            UnityEngine.Vector4             _VFXParams0  // 0xB4
  public            UnityEngine.Vector4             _VFXParams1  // 0xC4
  public            UnityEngine.Vector4             _VFXParams2  // 0xD4
  public            UnityEngine.Vector4             _CharacterParams0  // 0xE4
  public            UnityEngine.Vector4             _CharacterParams1  // 0xF4
  public            UnityEngine.Vector4             _CharacterParams2  // 0x104
  public            UnityEngine.Vector4             _CharacterParams3  // 0x114
  public            UnityEngine.Vector4             _CharacterParams4  // 0x124
  public            UnityEngine.Vector4             _CharacterParams5  // 0x134
  public            UnityEngine.Vector4             _CharacterParams6  // 0x144
  public            UnityEngine.Vector4             _CharacterParams7  // 0x154
  public            UnityEngine.Vector4             _CharacterParams8  // 0x164
  public            UnityEngine.Vector4             _CharacterParams9  // 0x174
  public            UnityEngine.Vector4             _CharacterParams10  // 0x184
  public            UnityEngine.Vector4             _CharacterParams11  // 0x194
  public            UnityEngine.Vector4             _CharacterParams12  // 0x1A4
  public            UnityEngine.Vector4             _CharacterParams13  // 0x1B4
  public            UnityEngine.Vector4             _CharacterParams14  // 0x1C4
  public            UnityEngine.Vector4             _CharacterParams15  // 0x1D4
  public            UnityEngine.Vector4             _IVParam0  // 0x1E4
  public            UnityEngine.Vector4             _IVParam1  // 0x1F4
  public            UnityEngine.Vector4             _IVParam2  // 0x204
  public            UnityEngine.Vector4             _IVDefaultSHAr  // 0x214
  public            UnityEngine.Vector4             _IVDefaultshAg  // 0x224
  public            UnityEngine.Vector4             _IVDefaultshAb  // 0x234
  public            System.IntPtr                   indirectionTexture  // 0x248
  public            System.IntPtr                   physicalTexture0  // 0x250
  public            System.IntPtr                   physicalTexture1  // 0x258
  public            UnityEngine.Vector4             _IVV2Param0  // 0x260
  public            UnityEngine.Vector4             _IVV2Param1  // 0x270
  public            UnityEngine.Vector4             _IVV2Param2  // 0x280
  public            UnityEngine.Vector4             _IVV2Param3  // 0x290
  public            System.IntPtr                   clipmapTextureALod0  // 0x2A0
  public            System.IntPtr                   clipmapTextureBLod0  // 0x2A8
  public            System.IntPtr                   clipmapTextureALod1  // 0x2B0
  public            System.IntPtr                   clipmapTextureBLod1  // 0x2B8
  public            System.IntPtr                   clipmapTextureALod3  // 0x2C0
  public            System.IntPtr                   clipmapTextureBLod3  // 0x2C8
  public            System.IntPtr                   _CharMaxCubemap  // 0x2D0
  public            System.IntPtr                   _CharacterRainEffectTex  // 0x2D8
  public            System.IntPtr                   _CharacterRainStreakTex  // 0x2E0
  public            System.IntPtr                   _CharacterRainFaceDripTex  // 0x2E8
  public            System.IntPtr                   _CharacterRainFaceDropletTex  // 0x2F0
  public            UnityEngine.Vector4             _WindGlobalParams0  // 0x2F8
  public            UnityEngine.Vector4             _WindGlobalParams2  // 0x308
  public            UnityEngine.Vector4             _CharacterPositionParams0  // 0x318
  public            UnityEngine.Vector4             _CharacterPositionParams1  // 0x328
  public            UnityEngine.Vector4             _CharacterPositionParams2  // 0x338
  public            UnityEngine.Vector4             _CharacterPositionParams3  // 0x348
  public            UnityEngine.Vector4             _CharacterHeightParams  // 0x358
  public            UnityEngine.HyperGryphEngineCode.HGRenderPathOtherData.<_WindMotorParams0>e__FixedBuffer_WindMotorParams0  // 0x368
  public            UnityEngine.HyperGryphEngineCode.HGRenderPathOtherData.<_WindMotorParams1>e__FixedBuffer_WindMotorParams1  // 0x3A8
  public            UnityEngine.HyperGryphEngineCode.HGRenderPathOtherData.<_WindMotorParams2>e__FixedBuffer_WindMotorParams2  // 0x3E8
  public            UnityEngine.HyperGryphEngineCode.HGRenderPathOtherData.<_WindMotorParams3>e__FixedBuffer_WindMotorParams3  // 0x428
  public            UnityEngine.Vector4             _WindMotorCount  // 0x468
  public            UnityEngine.Vector4             _LastWindGlobalParams0  // 0x478
  public            UnityEngine.HyperGryphEngineCode.HGRenderPathOtherData.<_LastWindMotorParams0>e__FixedBuffer_LastWindMotorParams0  // 0x488
  public            UnityEngine.HyperGryphEngineCode.HGRenderPathOtherData.<_LastWindMotorParams1>e__FixedBuffer_LastWindMotorParams1  // 0x4C8
  public            UnityEngine.HyperGryphEngineCode.HGRenderPathOtherData.<_LastWindMotorParams3>e__FixedBuffer_LastWindMotorParams3  // 0x508
  public            UnityEngine.Vector4             _WaterInteractionParams0  // 0x548
  public            UnityEngine.Vector4             _WaterInteractionParams1  // 0x558
  public            UnityEngine.Vector4             _RainWetnessGlobalParam0  // 0x568
  public            UnityEngine.Vector4             _RainWetnessGlobalParam1  // 0x578
  public            UnityEngine.Vector4             _RainWetnessGlobalParam2  // 0x588
  public            UnityEngine.Vector4             _RainWetnessGlobalParam3  // 0x598
  public            UnityEngine.Vector4             _RainWetnessGlobalParam4  // 0x5A8
  public            UnityEngine.Vector4             _RainWetnessGlobalParam5  // 0x5B8
  public            UnityEngine.Vector4             _RainWetnessGlobalParam6  // 0x5C8
  public            UnityEngine.Vector4             _RainWetnessGlobalParam7  // 0x5D8
  public            UnityEngine.Vector4             _RainWetnessGlobalParam8  // 0x5E8
  public            UnityEngine.Vector4             _RainWetnessGlobalParam9  // 0x5F8
  public            UnityEngine.Vector4             _RainWetnessGlobalParam10  // 0x608
  public            System.IntPtr                   verticalFlowTexture  // 0x618
  public            System.IntPtr                   rippleTexture  // 0x620
  public            System.IntPtr                   rainOcclusionSampleJitterNoise  // 0x628
  public            System.Boolean                  enableWetness  // 0x630
  public            System.Boolean                  enableWetnessHighQuality  // 0x631
  public            System.Boolean                  rainRendererUpdateSuccess  // 0x632
  public            UnityEngine.Vector4             _VerticalOcclusionMapParam0  // 0x634
  public            System.Boolean                  enabledVerticalOcclusion  // 0x644
  public            UnityEngine.Vector4             _InteractRaftParams0  // 0x648
  public            UnityEngine.Vector4             _InteractRaftParams1  // 0x658
  public            UnityEngine.HyperGryphEngineCode.HGRenderPathOtherData.<_HackTempDataBeforeCPPPlugin>e__FixedBuffer_HackTempDataBeforeCPPPlugin  // 0x668
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGReflectionProbeBinningInput
TYPE:  struct
TOKEN: 0x200006E
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            System.Boolean                  reset  // 0x11
  public            System.Boolean                  alwaysBlend  // 0x12
  public            System.Boolean                  enableFadeness  // 0x13
  public            System.UInt32                   viewHandle  // 0x14
  public            System.Single                   dt  // 0x18
  public            System.Int32                    defaultTextureCount  // 0x1C
  public            System.Int32*                   defaultTextureInstanceIDs  // 0x20
  public            System.Single*                  defaultTextureFactors  // 0x28
  public            UnityEngine.Vector4             defaultTextureSHLuminance  // 0x30
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.SkyRendererInput
TYPE:  struct
TOKEN: 0x200006F
FIELDS:
  public            System.Boolean                  isSkyBoxRenderingEnabled  // 0x10
  public            System.Boolean                  shouldRenderSkybox  // 0x11
  public            System.Boolean                  shouldRenderSkyCelestial  // 0x12
  public            System.Boolean                  shouldRenderSkyCloud  // 0x13
  public            System.Boolean                  forceHideSunDisc  // 0x14
  public            UnityEngine.Vector3             skyCelestialPos  // 0x18
  public            UnityEngine.Matrix4x4           skyboxMatrix  // 0x24
  public            UnityEngine.Matrix4x4           skyCloudMatrix  // 0x64
  public            System.IntPtr                   skyboxMaterial  // 0xA8
  public            System.IntPtr                   skyCloudMaterial  // 0xB0
  public            System.IntPtr                   icosphereMesh  // 0xB8
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGWaterSectorRenderingInput
TYPE:  struct
TOKEN: 0x2000070
FIELDS:
  public            System.Boolean                  enable  // 0x10
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGWaterInteractionRenderingInput
TYPE:  struct
TOKEN: 0x2000071
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            UnityEngine.Rendering.CBHandle  waterInteractiveCB  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGWaterRenderingInput
TYPE:  struct
TOKEN: 0x2000072
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            System.Boolean                  enableUnlit  // 0x11
  public            System.Boolean                  enableRain  // 0x12
  public            System.Boolean                  enableInk  // 0x13
  public            System.UInt32                   waterProxyCullHandle  // 0x14
  public            System.UInt32                   waterProxyVisibleCount  // 0x18
  public            System.UInt32                   waterDecalCullHandle  // 0x1C
  public            System.UInt32                   waterDecalVisibleCount  // 0x20
  public            System.Int32                    frameShadingRateX  // 0x24
  public            System.Int32                    frameShadingRateY  // 0x28
  public            System.Int32                    prepassTextureSize  // 0x2C
  public            UnityEngine.Rendering.CBHandle  waterDataCB  // 0x30
  public            UnityEngine.Matrix4x4           widerFoVViewProjMatrix  // 0x48
  public            UnityEngine.Matrix4x4           widerFoVInvViewProjMatrix  // 0x88
  public            UnityEngine.Matrix4x4           orthoViewProj  // 0xC8
  public            UnityEngine.Matrix4x4           orthoDeviceViewProj  // 0x108
  public            UnityEngine.Matrix4x4           orthoDeviceInvViewProj  // 0x148
  public            System.IntPtr                   globalFlowmapTexture  // 0x188
  public            System.IntPtr                   globalSmallWaveTexture  // 0x190
  public            System.IntPtr                   globalLargeWaveTexture  // 0x198
  public            System.IntPtr                   globalCausticTexture  // 0x1A0
  public            System.IntPtr                   globalRainTexture  // 0x1A8
  public            System.IntPtr                   screenSpaceMesh  // 0x1B0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGRenderPathBeforeCullingParamsCPP
TYPE:  struct
TOKEN: 0x2000073
FIELDS:
  public            System.Int32                    currentDeviceType  // 0x10
  public            UnityEngine.Vector2Int          sceneRTSize  // 0x14
  public            System.IntPtr                   visibleLights  // 0x20
  public            System.Int32                    visibleLightCount  // 0x28
  public            System.UInt32                   COMPOUND_CHARACTER_LAYER_MASK  // 0x2C
  public            UnityEngine.HyperGryph.LODCrossFadeConfig*lodCrossFadeConfig  // 0x30
  public            UnityEngine.HyperGryphEngineCode.HGSettingParametersCpp*settingParameters  // 0x38
  public            UnityEngine.HyperGryphEngineCode.HGLightConfigCPP*lightConfig  // 0x40
  public            UnityEngine.HyperGryphEngineCode.HGShadowConfigCPP*shadowConfig  // 0x48
  public            System.Single                   heightFogCullingFarClipPlane  // 0x50
  public            System.Single                   overrideCsmMaxDistanceValue  // 0x54
  public            System.Boolean                  overrideCsmShadowDistance  // 0x58
  public            System.Boolean                  enableShadowCulling  // 0x59
  public            System.Boolean                  forceRegenerateAsm  // 0x5A
  public            System.Boolean                  isInIsolatedDisplayMode  // 0x5B
  public            System.Boolean                  renderPathMobile  // 0x5C
  public            System.IntPtr                   uiCamera  // 0x60
  public            UnityEngine.HyperGryphEngineCode.HGCharacterShadowInputsCPP*characterShadowInputs  // 0x68
  public            System.IntPtr                   lightManager  // 0x70
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeaturesManagerCPP*debugFeaturesManager  // 0x78
  public            System.IntPtr                   cullingSystem  // 0x80
  public            System.IntPtr                   rendererSystem  // 0x88
  public            System.IntPtr                   customDepthOnlyRequestManager  // 0x90
  public            System.IntPtr                   foliageOccluderManager  // 0x98
  public            System.Boolean                  bSkipRender  // 0xA0
  public            System.IntPtr                   lightClusteringBeforeCullingOutput  // 0xA8
  public            System.IntPtr                   shadowPassBeforeCullingOutput  // 0xB0
  public            System.IntPtr                   customDepthOnlyBeforeCullingOutput  // 0xB8
  public            System.UInt32                   foliageOccluderCullViewHandle  // 0xC0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGRenderPathParamsCPP
TYPE:  struct
TOKEN: 0x2000074
FIELDS:
  public            System.Int32                    currentDeviceType  // 0x10
  public            System.Int32                    fogLayer  // 0x14
  public            System.UInt32                   COMPOUND_CHARACTER_LAYER_MASK  // 0x18
  public            System.Int32                    sizeofShaderVariablesGlobal  // 0x1C
  public            System.Int32                    sizeBasicTransformConstants  // 0x20
  public            System.Int32                    sizePerPassConstants  // 0x24
  public            UnityEngine.HyperGryphEngineCode.HGRenderPathOtherData*otherData  // 0x28
  public            UnityEngine.HyperGryphEngineCode.HGSettingParametersCpp*settingParameters  // 0x30
  public            UnityEngine.HyperGryphEngineCode.HGViewConstantsCPP*mainViewConstants  // 0x38
  public            System.Boolean                  didResetPostProcessingHistoryInLastFrame  // 0x40
  public            System.Single                   enableResponsiveTransparency  // 0x44
  public            System.Boolean                  enableTAAU  // 0x48
  public            System.Boolean                  fastConvergeState  // 0x49
  public            System.Boolean                  enableDLSS  // 0x4A
  public            System.Boolean                  disableFrameGenTemporarily  // 0x4B
  public            System.Boolean                  ssrEnable  // 0x4C
  public            System.Boolean                  shouldRenderPostProcess  // 0x4D
  public            System.Boolean                  shouldRenderAtmosphereFog  // 0x4E
  public            System.Boolean                  shouldRenderHeightFog  // 0x4F
  public            System.Boolean                  shouldRenderVolumetricFog  // 0x50
  public            System.Boolean                  shouldBakeFogLut  // 0x51
  public            System.Boolean                  enableAOVOutput  // 0x52
  public            System.Boolean                  characterOutlineEnabled  // 0x53
  public            System.Boolean                  renderWithAlpha  // 0x54
  public            System.Boolean                  sceneViewVolumetricFogEnable  // 0x55
  public            System.Boolean                  isInIsolatedDisplayMode  // 0x56
  public            System.Boolean                  isFirstFrame  // 0x57
  public            System.Boolean                  prevTransformReset  // 0x58
  public            System.Boolean                  enableWetness  // 0x59
  public            System.Boolean                  shouldRenderRippleState  // 0x5A
  public            System.Boolean                  enableEditorMacros  // 0x5B
  public            System.UInt32                   cameraFrameCount  // 0x5C
  public            System.UInt32                   debugRenderMode  // 0x60
  public            System.UInt32                   cullingViewHandle  // 0x64
  public            System.Single                   screenCullingRatio  // 0x68
  public            System.Single                   screenCullingRatioDistance  // 0x6C
  public            System.UInt32                   screenCullingLayerMask  // 0x70
  public            System.UInt32                   rayTracingTLASHandle  // 0x74
  public            UnityEngine.HyperGryphEngineCode.HGEnvironmentPhaseCPP*envPhase  // 0x78
  public            UnityEngine.HyperGryphEngineCode.HGVolumeComponentsDataCPP*volumeComponentsData  // 0x80
  public            UnityEngine.HyperGryphEngineCode.HGVolumeComponentsDataCPP*uiVolumeComponentsData  // 0x88
  public            System.UInt64                   frameSettingsData0  // 0x90
  public            System.UInt64                   frameSettingsData1  // 0x98
  public            System.Int32                    lutSize  // 0xA0
  public            UnityEngine.Experimental.Rendering.GraphicsFormatlutFormat  // 0xA4
  public            UnityEngine.Vector2Int          sceneRTSize  // 0xA8
  public            UnityEngine.Experimental.Rendering.GraphicsFormatsceneRTColorFormat  // 0xB0
  public            UnityEngine.Experimental.Rendering.GraphicsFormatsceneRTDepthFormat  // 0xB4
  public            UnityEngine.Vector2Int          taauRTSize  // 0xB8
  public            UnityEngine.Vector2Int          finalRTSize  // 0xC0
  public            System.IntPtr                   cullingResults  // 0xC8
  public            System.IntPtr                   visibleLights  // 0xD0
  public            System.Int32                    visibleLightCount  // 0xD8
  public            System.IntPtr                   uiCamera  // 0xE0
  public            System.UInt32                   uiCullingViewHandle  // 0xE8
  public            System.Int32                    sortingOrdersToBlurInternalCount  // 0xEC
  public            System.Int32*                   sortingOrdersToBlurInternal  // 0xF0
  public            System.Boolean                  render3DUI  // 0xF8
  public            System.IntPtr                   lightManager  // 0x100
  public            UnityEngine.HyperGryphEngineCode.HGDebugRenderManagerCPP*debugRenderManager  // 0x108
  public            UnityEngine.HyperGryphEngineCode.HGDebugFeaturesManagerCPP*debugFeaturesManager  // 0x110
  public            System.IntPtr                   graphicsFeatureManager  // 0x118
  public            System.IntPtr                   ivManager  // 0x120
  public            System.IntPtr                   terrainDeformManager  // 0x128
  public            System.IntPtr                   interactionManager  // 0x130
  public            System.IntPtr                   terrainManager  // 0x138
  public            System.IntPtr                   editorTerrainManager  // 0x140
  public            System.IntPtr                   sludgeRender  // 0x148
  public            System.IntPtr                   decalRender  // 0x150
  public            System.IntPtr                   meshRender  // 0x158
  public            System.IntPtr                   grassRender  // 0x160
  public            System.IntPtr                   reflectionProbeSystem  // 0x168
  public            System.IntPtr                   clothManager  // 0x170
  public            System.IntPtr                   uiRender  // 0x178
  public            System.IntPtr                   capsuleShadowManager  // 0x180
  public            System.IntPtr                   foliageOccluderRenderer  // 0x188
  public            System.IntPtr                   foliageInteractiveManager  // 0x190
  public            System.IntPtr                   foliageOccluderManager  // 0x198
  public            System.IntPtr                   waterRender  // 0x1A0
  public            System.IntPtr                   cullingSystem  // 0x1A8
  public            System.IntPtr                   rendererSystem  // 0x1B0
  public            System.IntPtr                   subsurfaceManager  // 0x1B8
  public            System.IntPtr                   subsurfaceProfileManager  // 0x1C0
  public            System.IntPtr                   shadingStateSystem  // 0x1C8
  public            System.IntPtr                   geometrySystem  // 0x1D0
  public            System.IntPtr                   resourceManager  // 0x1D8
  public            System.IntPtr                   customDepthOnlyRequestManager  // 0x1E0
  public            System.IntPtr                   dlssRender  // 0x1E8
  public            System.IntPtr                   customDrawRTManager  // 0x1F0
  public            System.IntPtr                   rayTracingRender  // 0x1F8
  public            UnityEngine.HyperGryphEngineCode.UIImageBlurPassInputV2*uiImageBlurPassInput  // 0x200
  public            System.Boolean                  isPlaying  // 0x208
  public            System.Boolean                  isSkyRenderingEnabled  // 0x209
  public            System.Boolean                  forceRenderAtmosphereLutEveryFrame  // 0x20A
  public            System.Boolean                  renderAtmosphereLutUsingCompute  // 0x20B
  public            UnityEngine.HyperGryphEngineCode.InkSimulationPassInput*inkSimulationPassInput  // 0x210
  public            UnityEngine.HyperGryphEngineCode.HGReflectionProbeBinningInput*reflectionProbeBinningInput  // 0x218
  public            System.Boolean                  renderPathMobile  // 0x220
  public            System.Boolean                  lightsUseLinearIntensity  // 0x221
  public            System.Boolean                  isActiveColorSpaceGamma  // 0x222
  public            System.Int64                    ivTargetID  // 0x228
  public            UnityEngine.HyperGryphEngineCode.TerrainDeformPassInput*terrainDeformPassInput  // 0x230
  public            UnityEngine.HyperGryphEngineCode.TerrainDepthPrepassInput*terrainDepthPrepassInput  // 0x238
  public            UnityEngine.HyperGryphEngineCode.HGWaterSectorRenderingInput*waterSectorRenderingInput  // 0x240
  public            UnityEngine.HyperGryphEngineCode.HGWaterInteractionRenderingInput*waterInteractionRenderingInput  // 0x248
  public            UnityEngine.HyperGryphEngineCode.HGWaterRenderingInput*waterRenderingInput  // 0x250
  public            UnityEngine.HyperGryphEngineCode.HGGTAmbientOcclusionSettingParameters*gtaoSettingParameters  // 0x258
  public            UnityEngine.HyperGryphEngineCode.HGFakePlanarReflectionRenderingInput*fakePlanarReflectionRenderingInput  // 0x260
  public            System.Boolean                  flowNoiseEnabled  // 0x268
  public            System.Boolean                  hasTerrainSimpleSubsurface  // 0x269
  public            UnityEngine.HyperGryphEngineCode.HGDepthOfFieldParameters*dofParameters  // 0x270
  public            UnityEngine.HyperGryphEngineCode.HGMotionBlurParametersV2*motionBlurParameters  // 0x278
  public            UnityEngine.HyperGryphEngineCode.LensFlareRenderingInput*lensFlareRenderingInput  // 0x280
  public            UnityEngine.HyperGryphEngineCode.ParafinRenderingInput*parafinRenderingInput  // 0x288
  public            UnityEngine.HyperGryphEngineCode.VFXScreenMaterialData*vfxScreenMaterialData  // 0x290
  public            UnityEngine.HyperGryphEngineCode.VFXPPScanLinePassInput*vfxPPScanLinePassInput  // 0x298
  public            UnityEngine.HyperGryphEngineCode.SkyRendererInput*skyRendererInput  // 0x2A0
  public            UnityEngine.HyperGryphEngineCode.VisibilitySHRPInput*visibilitySHRPInput  // 0x2A8
  public            UnityEngine.HyperGryphEngineCode.FrostedGlassPassRPInput*frostedGlassPassRPInput  // 0x2B0
  public            UnityEngine.HyperGryphEngineCode.FishEyeEffectInput*fishEyeEffectInput  // 0x2B8
  public            UnityEngine.HyperGryphEngineCode.CutsceneEffectPassRPInput*cutsceneEffectPassRPInput  // 0x2C0
  public            UnityEngine.HyperGryphEngineCode.VolumetricCloudInput*volumetricCloudInput  // 0x2C8
  public            System.Int32*                   rtExtractionSceneColorLS  // 0x2D0
  public            System.Int32*                   rtExtractionBlurredSceneColorPS  // 0x2D8
  public            System.Int32*                   rtExtractionSceneColorPS  // 0x2E0
  public            System.Int32*                   rtExtractionFinalResult  // 0x2E8
  public            System.Int32                    rtExtractionSceneColorLSCount  // 0x2F0
  public            System.Int32                    rtExtractionBlurredSceneColorPSCount  // 0x2F4
  public            System.Int32                    rtExtractionSceneColorPSCount  // 0x2F8
  public            System.Int32                    rtExtractionFinalResultCount  // 0x2FC
  public            System.Int32                    waterMarkRTCount  // 0x300
  public            System.Int32*                   waterMarkSrcRTs  // 0x308
  public            System.Int32*                   waterMarkDstRTs  // 0x310
  public            System.Single*                  waterMarkHeightScales  // 0x318
  public            System.Boolean                  forceRegenerateAsm  // 0x320
  public            UnityEngine.HyperGryph.LODCrossFadeConfig*lodCrossFadeConfig  // 0x328
  public            System.Boolean                  bSkipRender  // 0x330
  public            System.IntPtr                   lightClusteringBeforeCullingOutput  // 0x338
  public            System.IntPtr                   shadowPassBeforeCullingOutput  // 0x340
  public            System.IntPtr                   customDepthOnlyBeforeCullingOutput  // 0x348
  public            System.UInt32                   foliageOccluderCullViewHandle  // 0x350
  public            System.Single                   rayTracingReflectionVolumeBlend  // 0x354
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGRenderPathInternalCPP
TYPE:  struct
TOKEN: 0x2000075
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryphEngineCode.HGRenderPathInternalCPPForward  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGRenderPathInternalCPPUI  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGRenderPathInternalCPPUI3D  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGRenderPathInternalCPPDefaultDeferred  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGRenderPathInternalCPPOnePassDeferredSubpass  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGRenderPathInternalCPPDebugFullScreen  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGRenderPathInternalCPPDebugRegularDefaultDeferred  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGRenderPathInternalCPPDebugRegularOnePassDeferredSubpass  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGRenderPathInternalCPPCount  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGGTAmbientOcclusionSettingParameters
TYPE:  struct
TOKEN: 0x2000076
FIELDS:
  public            System.Boolean                  enableAO  // 0x10
  public            System.Boolean                  enableFP32Depths  // 0x11
  public            System.Boolean                  enableBentNormals  // 0x12
  public            System.Int32                    screenWidth  // 0x14
  public            System.Int32                    screenHeight  // 0x18
  public            System.Int32                    qualityLevel  // 0x1C
  public            System.Int32                    denoisePasses  // 0x20
  public            System.Int32                    cameraFrameCount  // 0x24
  public            System.Single                   finalValuePower  // 0x28
  public            System.Single                   depthMIPSamplingOffset  // 0x2C
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGMotionBlurParametersV2
TYPE:  struct
TOKEN: 0x2000077
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            System.Single                   shutterAngle  // 0x14
  public            System.Single                   sampleCount  // 0x18
  public            System.Single                   blendFrame  // 0x1C
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.LensFlareRenderingInput
TYPE:  struct
TOKEN: 0x2000078
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            UnityEngine.HyperGryphEngineCode.HGLensFlareDrawData*drawDataList  // 0x18
  public            System.Int32                    drawDataCount  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.ParafinRenderingInput
TYPE:  struct
TOKEN: 0x2000079
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            System.Int32                    parafinMaterialCount  // 0x14
  public            System.Int32*                   parafinMaterialIDs  // 0x18
  public            System.IntPtr                   parafinMesh  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGDepthOfFieldParameters
TYPE:  struct
TOKEN: 0x200007A
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            System.Single                   focusDistance  // 0x14
  public            System.Single                   aperture  // 0x18
  public            System.Single                   nearFocusStart  // 0x1C
  public            System.Single                   nearFocusEnd  // 0x20
  public            System.Single                   nearRadius  // 0x24
  public            System.Single                   farFocusStart  // 0x28
  public            System.Single                   farFocusEnd  // 0x2C
  public            System.Single                   farRadius  // 0x30
  public            System.Single                   temporalFactor  // 0x34
  public            System.Single                   scale  // 0x38
  public            System.Int32                    camera  // 0x3C
  public            UnityEngine.Vector4             nearStartColor  // 0x40
  public            UnityEngine.Vector4             nearEndColor  // 0x50
  public            UnityEngine.Vector4             farStartColor  // 0x60
  public            UnityEngine.Vector4             farEndColor  // 0x70
  public            System.Boolean                  debug  // 0x80
  public            System.Boolean                  usePhysicalCamera  // 0x81
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.VFXScreenMaterialData
TYPE:  struct
TOKEN: 0x200007B
FIELDS:
  public            System.Boolean                  enableFullScreenVFXData  // 0x10
  public            System.IntPtr                   vfxFullScreenMesh  // 0x18
  public            System.IntPtr                   vfxFullScreenMaterial  // 0x20
  public            System.IntPtr                   vfxFullScreenMaterialPropertyBlock  // 0x28
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.CustomDepthOnlySystemRequest
TYPE:  struct
TOKEN: 0x200007C
FIELDS:
  public            UnityEngine.Vector3             rootPosition  // 0x10
  public            UnityEngine.Vector3             frustumSize  // 0x1C
  public            UnityEngine.Vector2Int          rtSize  // 0x28
  public            UnityEngine.Vector2Int          pageSize  // 0x30
  public            System.UInt32                   depthBits  // 0x38
  public            UnityEngine.Experimental.Rendering.GraphicsFormatformat  // 0x3C
  public            System.Int32                    depthRTShaderID  // 0x40
  public            System.Int32                    transformCBShaderID  // 0x44
  public            System.Boolean                  includeDynamicObjects  // 0x48
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGFakePlanarReflectionRenderingInput
TYPE:  struct
TOKEN: 0x200007D
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            System.Boolean                  enableCharacterOutline  // 0x11
  public            System.Boolean                  enableScreenSpaceShadowMask  // 0x12
  public            System.Boolean                  useRGBAHalf  // 0x13
  public            System.Single                   blurRadius  // 0x14
  public            UnityEngine.Vector3             normalWS  // 0x18
  public            UnityEngine.Vector3             pivot  // 0x24
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGTerrainGlintData
TYPE:  struct
TOKEN: 0x200007E
FIELDS:
  public            System.Boolean                  m_enableFakeGlint  // 0x10
  public            System.Single                   m_glintTopBlendSmoothness  // 0x14
  public            System.Single                   m_glintTopBlendThreshold  // 0x18
  public            System.Single                   m_glintStrength  // 0x1C
  public            System.Single                   m_glintScale  // 0x20
  public            System.Single                   m_glintThreshold  // 0x24
  public            System.Single                   m_glintFadeDistance  // 0x28
  public            UnityEngine.Color               m_glintColor  // 0x2C
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGTerrainSubsurfaceData
TYPE:  struct
TOKEN: 0x200007F
FIELDS:
  public            System.Boolean                  m_useSubsurfaceProfile  // 0x10
  public            System.Single                   m_subsurfaceCurvatureScale  // 0x14
  public            System.Single                   m_subsurfaceCurvatureOffset  // 0x18
  public            System.Boolean                  m_enableSubsurfaceProfileKeyword  // 0x1C
  public            System.Int32                    m_terrainStencil  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGTerrainFakeVolumeData
TYPE:  struct
TOKEN: 0x2000080
FIELDS:
  public            System.Boolean                  m_enableFakeVolume  // 0x10
  public            System.Single                   m_fakeVolumeIoR  // 0x14
  public            System.Single                   m_fakeVolumeFresnelStrength  // 0x18
  public            System.Int32                    m_fakeVolumeMode  // 0x1C
  public            System.Single                   m_fakeVolumeOpacityTiling  // 0x20
  public            System.Single                   m_fakeCrackLayerTiling  // 0x24
  public            UnityEngine.Color               m_fakeCrackTint  // 0x28
  public            System.Single                   m_fakeCrackHeightScale  // 0x38
  public            System.Single                   m_fakeCrackDepth  // 0x3C
  public            System.Single                   m_fakeCrackMarchSteps  // 0x40
  public            UnityEngine.Color               m_fakeRefractionTint  // 0x44
  public            System.Single                   m_fakeRefractionLayerTiling  // 0x54
  public            UnityEngine.Color               m_fakeVolumeScatterExtinction  // 0x58
  public            UnityEngine.Color               m_fakeVolumeScatterAlbedo  // 0x68
  public            System.Single                   m_fakeRefractionHeightScale  // 0x78
  public            System.Single                   m_fakeRefractionDepth  // 0x7C
  public            System.Single                   m_fakeRefractionMarchSteps  // 0x80
  public            System.Single                   m_fakeDustLayerTiling  // 0x84
  public            System.Single                   m_fakeDustDepth  // 0x88
  public            UnityEngine.Vector4             m_fakeDustFlowSpeed  // 0x8C
  public            UnityEngine.Color               m_fakeDustTint  // 0x9C
  public            System.Int32                    m_fakeVolumeOpacityMask  // 0xAC
  public            System.Int32                    m_fakeVolumeMask  // 0xB0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGTerrainFakeShadowData
TYPE:  struct
TOKEN: 0x2000081
FIELDS:
  public            System.Boolean                  m_enableFakeShadow  // 0x10
  public            System.Single                   m_fakeShadowPenumbra  // 0x14
  public            System.Single                   m_fakeShadowStrength  // 0x18
  public            System.Single                   m_fakeShadowMarchSteps  // 0x1C
  public            System.Single                   m_fakeShadowDistanceLerp  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGTerrainLayerTypeData
TYPE:  struct
TOKEN: 0x2000082
FIELDS:
  public            System.Boolean                  m_bHasLayerTypeData  // 0x10
  public            UnityEngine.Matrix4x4           m_localToWorldMatrix  // 0x14
  public            UnityEngine.Matrix4x4           m_worldToLocalMatrix  // 0x54
  public            System.Int32                    m_heightmapTexture  // 0x94
  public            UnityEngine.Vector4             m_heightmapScale  // 0x98
  public            UnityEngine.HyperGryphEngineCode.HGTerrainGlintDatam_glintData  // 0xA8
  public            UnityEngine.HyperGryphEngineCode.HGTerrainSubsurfaceDatam_subsurfaceData  // 0xD4
  public            UnityEngine.HyperGryphEngineCode.HGTerrainFakeVolumeDatam_fakeVolumeData  // 0xE8
  public            UnityEngine.HyperGryphEngineCode.HGTerrainFakeShadowDatam_fakeShadowData  // 0x18C
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGTerrainFeatures
TYPE:  struct
TOKEN: 0x2000083
FIELDS:
  public            System.Boolean                  enableDeformBlend  // 0x10
  public            System.Boolean                  enableWetRipple  // 0x11
  public            UnityEngine.HyperGryphEngineCode.HGTerrainLayerTypeData*layerTypeData  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGVolumetricBounds
TYPE:  struct
TOKEN: 0x2000084
FIELDS:
  public            System.Boolean                  enableBounds  // 0x10
  public            UnityEngine.Bounds              worldBounds  // 0x14
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGVolumetricRenderItem
TYPE:  struct
TOKEN: 0x2000085
FIELDS:
  public            System.Int32                    material  // 0x10
  public            System.Int32                    mesh  // 0x14
  public            UnityEngine.Matrix4x4           localToWorldMatrix  // 0x18
  public            System.IntPtr                   propertySheet  // 0x58
  public            UnityEngine.HyperGryphEngineCode.HGVolumetricBoundsbounds  // 0x60
  public            System.Boolean                  enableFraming  // 0x7C
  public            System.Boolean                  enableTAA  // 0x7D
  public            System.Int32                    sortingOrder  // 0x80
  public            System.Int32                    renderQueue  // 0x84
  public            System.Single                   distToCamera  // 0x88
  public            System.Int32                    composePriority  // 0x8C
  public            System.Boolean                  pureBlit  // 0x90
  public            System.Boolean                  fullScreen  // 0x91
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.EFramingQuality
TYPE:  struct
TOKEN: 0x2000086
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryphEngineCode.EFramingQualityCheckerboard  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.EFramingQualityQuarter  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.EDownResFilter
TYPE:  struct
TOKEN: 0x2000087
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryphEngineCode.EDownResFilterDepthFade  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.EDownResFilterNearest  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.EDownResFilterBilateal  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.EDownResFilterNoisy  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGDownResQualityPack
TYPE:  struct
TOKEN: 0x2000088
FIELDS:
  public            System.Boolean                  enableDownRes  // 0x10
  public            System.Single                   downResRatio  // 0x14
  public            UnityEngine.HyperGryphEngineCode.EDownResFilterdownResFilter  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGFramingQualityPack
TYPE:  struct
TOKEN: 0x2000089
FIELDS:
  public            System.Boolean                  enableFraming  // 0x10
  public            UnityEngine.HyperGryphEngineCode.EFramingQualityframingLevel  // 0x14
  public            System.Single                   framingComposeRatio  // 0x18
  public            System.Boolean                  enableFramingCubicSample  // 0x1C
  public            System.Boolean                  enableFramingMotionVector  // 0x1D
  public            System.Boolean                  enableFramingDepthOpt  // 0x1E
  public            System.Boolean                  enableFramingColorAABB  // 0x1F
  public            System.Boolean                  enableFramingNeighborAvg  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGTAAQualityPack
TYPE:  struct
TOKEN: 0x200008A
FIELDS:
  public            System.Boolean                  enableTAA  // 0x10
  public            System.Boolean                  enableTAACubicSample  // 0x11
  public            System.Boolean                  enableTAAMotionVector  // 0x12
  public            System.Boolean                  enableTAADepthOpt  // 0x13
  public            System.Boolean                  enableTAAColorAABB  // 0x14
  public            System.Boolean                  enableTAANeighborAvg  // 0x15
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.EFarCloudFramingQuality
TYPE:  struct
TOKEN: 0x200008B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryphEngineCode.EFarCloudFramingQualityNone  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.EFarCloudFramingQualityCheckerboard  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.EFarCloudFramingQualityQuarter  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.EFarCloudFramingQualityFraming4x2  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.EFarCloudFramingQualityFraming4x4  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGCloudQualityPack
TYPE:  struct
TOKEN: 0x200008C
FIELDS:
  public            System.Single                   marchStepScale  // 0x10
  public            System.Single                   godRayStepScale  // 0x14
  public            System.Single                   emptySkipSizeScale  // 0x18
  public            System.Single                   dynamicStepRange  // 0x1C
  public            System.Single                   dynamicStepScale  // 0x20
  public            System.Boolean                  enableFarCloud  // 0x24
  public            System.Int32                    panoramicSizeX  // 0x28
  public            System.Int32                    panoramicSizeY  // 0x2C
  public            System.Int32                    octahedronSize  // 0x30
  public            System.Single                   octahedronHeightScale  // 0x34
  public            System.Boolean                  octahedronEnableSlicing  // 0x38
  public            System.Int32                    octahedronSlicingCountX  // 0x3C
  public            System.Int32                    octahedronSlicingCountY  // 0x40
  public            System.Int32                    semicircularSize  // 0x44
  public            System.Single                   semicircularZScale  // 0x48
  public            UnityEngine.HyperGryphEngineCode.EFarCloudFramingQualityfarCloudFramingLevel  // 0x4C
  public            System.Single                   farCloudFramingComposeRatio  // 0x50
  public            System.Boolean                  farCloudFramingCubicSample  // 0x54
  public            System.Boolean                  farCloudEnableTAA  // 0x55
  public            System.Single                   farCloudTAABlendRatio  // 0x58
  public            System.Boolean                  farCloudTAACubicSample  // 0x5C
  public            System.Single                   farCloudMarchStepScale  // 0x60
  public            System.Single                   farCloudEmptySkipSizeScale  // 0x64
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGVolumetricQualitySettings
TYPE:  struct
TOKEN: 0x200008D
FIELDS:
  public            UnityEngine.HyperGryphEngineCode.HGDownResQualityPackdownResQualityPack  // 0x10
  public            UnityEngine.HyperGryphEngineCode.HGFramingQualityPackframingQualityPack  // 0x1C
  public            UnityEngine.HyperGryphEngineCode.HGTAAQualityPacktaaQualityPack  // 0x30
  public            UnityEngine.HyperGryphEngineCode.HGCloudQualityPackcloudQualityPack  // 0x38
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGRainDrawCmdType
TYPE:  struct
TOKEN: 0x200008E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryphEngineCode.HGRainDrawCmdTypeDrawMesh  // 0x0
  public    static  UnityEngine.HyperGryphEngineCode.HGRainDrawCmdTypeDrawMeshInstancedProcedural  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGRainParams
TYPE:  struct
TOKEN: 0x200008F
FIELDS:
  public            System.Int32                    mesh  // 0x10
  public            System.Int32                    material  // 0x14
  public            System.IntPtr                   shaderPropertySheet  // 0x18
  public            UnityEngine.Matrix4x4           matrix  // 0x20
  public            System.Int32                    subMeshIndex  // 0x60
  public            System.Int32                    shaderPass  // 0x64
  public            System.Int32                    instanceCount  // 0x68
  public            UnityEngine.HyperGryphEngineCode.HGRainDrawCmdTypetype  // 0x6C
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.ScanLineDataPack
TYPE:  struct
TOKEN: 0x2000090
FIELDS:
  public            UnityEngine.Vector4             blackBoxCenterPos  // 0x10
  public            UnityEngine.Color               blackBoxBackground  // 0x20
  public            UnityEngine.Color               blackBoxContourColor  // 0x30
  public            UnityEngine.Vector4             blackBoxParams1  // 0x40
  public            UnityEngine.Vector4             blackBoxParams2  // 0x50
  public            UnityEngine.Vector4             blackBoxParams3  // 0x60
  public            UnityEngine.Vector4             blackBoxParams4  // 0x70
  public            UnityEngine.Vector4             blackBoxParams5  // 0x80
  public            UnityEngine.Vector4             scanLineCenterPos  // 0x90
  public            UnityEngine.Vector4             scanlineParams1  // 0xA0
  public            UnityEngine.Vector4             scanlineParams2  // 0xB0
  public            UnityEngine.Vector4             scanlineParams3  // 0xC0
  public            UnityEngine.Vector4             scanlineParams4  // 0xD0
  public            UnityEngine.Vector4             scanlineParams5  // 0xE0
  public            UnityEngine.Color               scanlineTint  // 0xF0
  public            UnityEngine.Vector4             scanlineParams6  // 0x100
  public            UnityEngine.Vector4             scanlineParams7  // 0x110
  public            UnityEngine.Vector4             scanlineParams8  // 0x120
  public            UnityEngine.Vector4             scanlineParams9  // 0x130
  public            UnityEngine.Vector4             scanlineParams10  // 0x140
  public            UnityEngine.Color               scanlineHighlightTint  // 0x150
  public            UnityEngine.Color               scanlineHighlightBeamTint  // 0x160
  public            UnityEngine.Vector4             boxPosition1  // 0x170
  public            UnityEngine.Vector4             boxPosition2  // 0x180
  public            UnityEngine.Vector4             boxPosition3  // 0x190
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HighlightDataPack
TYPE:  struct
TOKEN: 0x2000091
FIELDS:
  public            UnityEngine.Vector4             detectDistance  // 0x10
  public            UnityEngine.Vector3             beamHeight  // 0x20
  public            System.Single                   meshHeight  // 0x2C
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.VFXPPScanLinePassInput
TYPE:  struct
TOKEN: 0x2000092
FIELDS:
  public            System.Boolean                  useScanLine  // 0x10
  public            System.Boolean                  useBlackBox  // 0x11
  public            System.Boolean                  scanLineUseMask  // 0x12
  public            System.Boolean                  shouldDrawScanLineHighlight  // 0x13
  public            System.IntPtr                   scanLineDataPack  // 0x18
  public            System.IntPtr                   scanlineMaskTex  // 0x20
  public            System.IntPtr                   blackBoxContourTex  // 0x28
  public            System.IntPtr                   highlightDataPack  // 0x30
  public            System.IntPtr                   highlightMaterial  // 0x38
  public            System.IntPtr                   highlightMesh  // 0x40
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.UIImageBlurPassInputV2
TYPE:  struct
TOKEN: 0x2000093
FIELDS:
  public            System.IntPtr                   source  // 0x10
  public            System.IntPtr                   target  // 0x18
  public            UnityEngine.Vector2Int          rectOffset  // 0x20
  public            UnityEngine.Vector2Int          rectSize  // 0x28
  public            UnityEngine.Vector2Int          srcSize  // 0x30
  public            System.Single                   scale  // 0x38
  public            System.Int32                    material  // 0x3C
  public            UnityEngine.Experimental.Rendering.GraphicsFormatformat  // 0x40
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.VisibilitySHRPInput
TYPE:  struct
TOKEN: 0x2000094
FIELDS:
  public            System.Int32                    passIdx  // 0x10
  public            System.Int32                    indirectPassIdx  // 0x14
  public            System.UInt32                   cullViewHandle  // 0x18
  public            System.Boolean                  enabled  // 0x1C
  public            System.Single                   sphereIntervalScale  // 0x20
  public            System.Single                   sphereRangeScale  // 0x24
  public            System.Boolean                  enableHalfRez  // 0x28
  public            System.Boolean                  useTileRendering  // 0x29
  public            System.UInt32                   tileSize  // 0x2C
  public            System.Int32                    visibilitySHMaterial  // 0x30
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.FrostedGlassPassRPInput
TYPE:  struct
TOKEN: 0x2000095
FIELDS:
  public            System.Boolean                  isEnabled  // 0x10
  public            System.Boolean                  useCachedTex  // 0x11
  public            System.Boolean                  enableUserLut  // 0x12
  public            System.Int32                    userLut  // 0x14
  public            UnityEngine.Vector4             userLogLutSettings  // 0x18
  public            UnityEngine.Vector4             logLutSettings  // 0x28
  public            UnityEngine.Experimental.Rendering.GraphicsFormatoutputFormat  // 0x38
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.FishEyeEffectInput
TYPE:  struct
TOKEN: 0x2000096
FIELDS:
  public            System.Int32                    colorPassIndex  // 0x10
  public            System.Int32                    depthPassIndex  // 0x14
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.CutsceneEffectPassRPInput
TYPE:  struct
TOKEN: 0x2000097
FIELDS:
  public            System.Boolean                  isEnabled  // 0x10
  public            System.Int32                    cutsceneEffectMeshID  // 0x14
  public            System.Int32                    blitMaterialID  // 0x18
  public            System.Int32                    cutsceneEffectMaterialNum  // 0x1C
  public            System.Int32*                   cutsceneEffectMaterialIDs  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.VolumetricCloudInput
TYPE:  struct
TOKEN: 0x2000098
FIELDS:
  public            System.IntPtr                   defaultVolumetricMat  // 0x10
  public            System.UInt32                   renderSizeX  // 0x18
  public            System.UInt32                   renderSizeY  // 0x1C
  public            UnityEngine.Matrix4x4           volumeMatrixVP  // 0x20
  public            UnityEngine.HyperGryphEngineCode.HGVolumetricRenderItem*renderItems  // 0x60
  public            System.Int32                    renderItemsCount  // 0x68
  public            UnityEngine.HyperGryphEngineCode.HGVolumetricQualitySettingsqualitySetting  // 0x6C
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGCharacterShadowInputsCPP
TYPE:  struct
TOKEN: 0x2000099
FIELDS:
  public            System.Int32                    characterCount  // 0x10
  public            UnityEngine.Bounds*             bounds  // 0x18
  public            System.UInt32*                  shadowLayers  // 0x20
  public            System.Boolean                  characterVolumeEnabled  // 0x28
  public            System.Boolean                  characterVolume_shadowPassEnabledState  // 0x29
  public            System.Int32                    characterVolume_selfShadowMode  // 0x2C
  public            System.Int32                    characterVolume_charMainLightMode  // 0x30
  public            UnityEngine.Vector2             characterVolume_charCameraFollowMainLightBias  // 0x34
  public            UnityEngine.Vector2             characterVolume_charCustomMainLightDir  // 0x3C
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.ParticleLightingIVInput
TYPE:  struct
TOKEN: 0x200009A
FIELDS:
  public            UnityEngine.Matrix4x4           invViewMatrix  // 0x10
  public            UnityEngine.Vector4             IVParam0  // 0x50
  public            UnityEngine.Vector4             IVParam1  // 0x60
  public            UnityEngine.Vector4             IVParam2  // 0x70
  public            UnityEngine.Vector4             IVDefaultSHAr  // 0x80
  public            UnityEngine.Vector4             IVDefaultSHAg  // 0x90
  public            UnityEngine.Vector4             IVDefaultSHAb  // 0xA0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP
TYPE:  class
TOKEN: 0x200009B
FIELDS:
METHODS:
  System.IntPtr AllocateTempFromCSharp(System.Int64 size)
  T* AllocateTempFromCSharp()
  System.Int64 HGRenderPath_Create(UnityEngine.HyperGryphEngineCode.HGRenderPathInternalCPP renderPath, UnityEngine.HyperGryphEngineCode.HGRenderPipelineRuntimeResourcesCPP* defaultResources, UnityEngine.HyperGryphEngineCode.HGRenderPipelineDebugResourcesCPP* debugResources)
  System.Void HGRenderPath_BeforeCulling(System.Int64 _ptr, UnityEngine.HyperGryphEngineCode.HGRenderPathBeforeCullingParamsCPP* renderPathBeforeCullingParams, System.IntPtr camera)
  System.Void HGRenderPath_Render(System.Int64 _ptr, UnityEngine.HyperGryphEngineCode.HGRenderPathParamsCPP* renderPathParams, UnityEngine.HyperGryphEngineCode.HGRenderPathBeforeCullingParamsCPP* renderPathBeforeCullingParams, System.IntPtr camera, System.IntPtr renderContext, System.IntPtr _cmd)
  System.Void HGRenderPath_Destroy(System.Int64 _ptr)
  System.IntPtr HGGetBackbufferColorSurface()
  System.IntPtr HGGetBackbufferDepthSurface()
  System.Int64 Create(System.IntPtr renderContext)
  System.Void Destroy(System.Int64 _ptr)
  System.Void Execute(System.Int64 _ptr, System.IntPtr cmd)
  System.IntPtr AllocateTemp(System.Int64 _ptr, System.Int64 size)
  Unity.Collections.NativeArray<T> AllocateTempNativeArray(System.Int64 _ptr, System.Int32 length)
  System.Int64 ImportTextureRefFromCSharp(System.Int64 ptr)
  System.Int64 ImportRenderSurfaceFromCSharp(System.Int64 ptr)
  System.Int64 ImportComputeBufferFromCSharp(System.Int64 ptr)
  System.Void ResolveCSharpImportTextureRef(System.Int64 ptr, System.Int64 res, System.IntPtr tex)
  System.Void ResolveCSharpImport(System.Int64 ptr, System.Int64 res, UnityEngine.RenderBuffer rbColorOrDepth, System.UInt32 stencilTextureID)
  System.Void ResolveCSharpImportComputeBuffer(System.Int64 ptr, System.Int64 res, System.IntPtr buffer)
  System.Int64 CustomDepthRequestManager_Create()
  System.Void CustomDepthRequestManager_Remove(System.Int64 mgr)
  System.UInt32 CustomDepthRequestManager_RequestSystem(System.Int64 mgr, UnityEngine.HyperGryphEngineCode.CustomDepthOnlySystemRequest* request)
  System.Void CustomDepthRequestManager_RemoveSystem(System.Int64 mgr, System.UInt32 idx)
  System.Void CustomDepthRequestManager_UpdateSystem(System.Int64 mgr, System.UInt32 idx, UnityEngine.Vector3 position)
  System.Void CustomDepthRequestManager_ToggleSystem(System.Int64 mgr, System.UInt32 idx, System.Boolean flag)
  System.Int64 CustomDrawRTManager_Create()
  System.Void CustomDrawRTManager_Destroy(System.Int64 ptr)
  UnityEngine.RenderTexture CustomDrawRTManager_AllocateRenderTexture(System.Int64 manager, System.Int32 width, System.Int32 height, System.Int32 depth, System.Int32 mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat)
  System.Void CustomDrawRTManager_ReleaseRenderTexture(System.Int64 manager, UnityEngine.RenderTexture rt)
  System.Void CustomDrawRTManager_DrawTexture(System.Int64 manager, UnityEngine.RenderTexture rt, UnityEngine.Rect& rect, UnityEngine.Texture texture, UnityEngine.Material material, System.Int32 pass)
  System.Void CustomDrawRTManager_ClearTexture(System.Int64 manager, UnityEngine.RenderTexture rt, UnityEngine.Color& color)
  System.Int64 InkSimulationPass_Create()
  System.Void InkSimulationPass_Destroy(System.Int64 _ptr)
  System.Void InkSimulationPass_ConstructPass(System.Int64 _ptr, System.Int64 _rg, System.IntPtr material, System.Single influence, System.Int32 resolution, System.Single worldSize, UnityEngine.Vector3 center, System.Double deltaTime)
  System.Void InkSimulationPass_GetWorldToUV(UnityEngine.Vector4* ret, System.Int64 _ptr, System.IntPtr material, System.Single influence, System.Int32 resolution, System.Single worldSize, UnityEngine.Vector3 center)
  System.Void ResolveCSharpImport_Injected(System.Int64 ptr, System.Int64 res, UnityEngine.RenderBuffer& rbColorOrDepth, System.UInt32 stencilTextureID)
  System.Void CustomDepthRequestManager_UpdateSystem_Injected(System.Int64 mgr, System.UInt32 idx, UnityEngine.Vector3& position)
  System.Void InkSimulationPass_ConstructPass_Injected(System.Int64 _ptr, System.Int64 _rg, System.IntPtr material, System.Single influence, System.Int32 resolution, System.Single worldSize, UnityEngine.Vector3& center, System.Double deltaTime)
  System.Void InkSimulationPass_GetWorldToUV_Injected(UnityEngine.Vector4* ret, System.Int64 _ptr, System.IntPtr material, System.Single influence, System.Int32 resolution, System.Single worldSize, UnityEngine.Vector3& center)
END_CLASS

