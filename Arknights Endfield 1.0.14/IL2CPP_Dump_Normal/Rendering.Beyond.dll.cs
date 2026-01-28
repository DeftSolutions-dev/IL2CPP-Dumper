// ========================================================
// Dumped by @desirepro
// Assembly: Rendering.Beyond.dll
// Classes:  125
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000002
    public class LDstaticObjectLightmappingDataLoader : MonoBehaviour
    {
        // Fields
        public System.Boolean test;        // 0x18
        public System.Boolean recover;        // 0x19
        public UnityEngine.Renderer[] ldLightmappedRenderer;        // 0x20
        public System.Int32[] ldLightmappedRendererLightmapIndex;        // 0x28
        public UnityEngine.Vector4[] ldLightmappedRendererLightmapUvScale;        // 0x30

        // Methods
        private System.Void RecoverLightmapdata() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000E
    public struct WarmUpReason
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Rendering.ShaderWarmupManager.WarmUpReason NoReason;        // 0x0
        public static Beyond.Rendering.ShaderWarmupManager.WarmUpReason FirstEntryGame;        // 0x0
        public static Beyond.Rendering.ShaderWarmupManager.WarmUpReason LodChange;        // 0x0
        public static Beyond.Rendering.ShaderWarmupManager.WarmUpReason AssetUpdate;        // 0x0
        public static Beyond.Rendering.ShaderWarmupManager.WarmUpReason AppUpdate;        // 0x0
        public static Beyond.Rendering.ShaderWarmupManager.WarmUpReason GraphicsAPIChange;        // 0x0
        public static Beyond.Rendering.ShaderWarmupManager.WarmUpReason ShaderCacheSmall;        // 0x0
        public static Beyond.Rendering.ShaderWarmupManager.WarmUpReason ShaderCacheInvalid;        // 0x0
        public static Beyond.Rendering.ShaderWarmupManager.WarmUpReason DevOverride;        // 0x0
        public static Beyond.Rendering.ShaderWarmupManager.WarmUpReason CrashRetry;        // 0x0

    }

    // TypeToken: 0x2000015
    public class ShaderWarmupRemoteBlackDevice
    {
        // Fields
        public System.String deviceModel;        // 0x10
        public System.String graphicsDeviceName;        // 0x18
        public System.String graphicsDeviceVersion;        // 0x20
        public System.String os;        // 0x28
        public System.String cpuName;        // 0x30
        public System.String disableFeature;        // 0x38

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000016
    public class ShaderWarmupRemoteBlacklist
    {
        // Fields
        public System.Collections.Generic.List<Beyond.Rendering.ShaderWarmupManagerRemoteCfg.ShaderWarmupRemoteBlackDevice> devices;        // 0x10

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000019
    public struct ChunkData
    {
        // Fields
        public UnityEngine.Vector3[] centers;        // 0x10
        public UnityEngine.Vector3[] extents;        // 0x18
        public UnityEngine.Vector3[] vertexData;        // 0x20
        public System.Single[] areas;        // 0x28

    }

    // TypeToken: 0x200001A
    public struct SubSceneDataPerSceneState
    {
        // Fields
        public UnityEngine.Vector2Int[] chunkCoords;        // 0x10
        public Beyond.Rendering.HGSOCSubSceneData.ChunkData[] chunkDataArray;        // 0x18

    }

    // TypeToken: 0x200001F
    public class CaptureRenderGameObject
    {
        // Fields
        public UnityEngine.GameObject gameObject;        // 0x10
        public UnityEngine.MeshRenderer meshRenderer;        // 0x18
        public UnityEngine.MeshFilter meshFilter;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000022
    public class RendererInfo
    {
        // Fields
        public UnityEngine.Renderer renderer;        // 0x10
        public Beyond.Rendering.EntityVFXRendererMask typeMask;        // 0x18
        public System.Int32 subMeshCount;        // 0x1C
        public UnityEngine.Rendering.ShadowCastingMode oriShadowCastingMode;        // 0x20
        public UnityEngine.Experimental.Rendering.RayTracingMode oriRayTracingMode;        // 0x24
        public UnityEngine.Material[] sourceMaterials;        // 0x28
        public System.Boolean materialReplacing;        // 0x30
        public UnityEngine.Material[] replacingMaterials;        // 0x38
        public UnityEngine.Vector4 customPerDrawData0;        // 0x40
        public UnityEngine.Vector4 customPerDrawData1;        // 0x50

        // Methods
        private UnityEngine.Material[] get_currentMeshMaterials() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000023
    public struct AddedMaterialInfo
    {
        // Fields
        public UnityEngine.Material material;        // 0x10
        public Beyond.Rendering.EntityVFXRendererMask mask;        // 0x18

    }

    // TypeToken: 0x2000024
    public class AddedMaterialController
    {
        // Fields
        public static System.Int32 MAX_ACTIVE_ADDED_MATERIAL;        // 0x0
        public System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperMaterialController.AddedMaterialInfo> addedMaterialInfos;        // 0x10
        private System.Collections.Generic.Dictionary<System.Int32,System.Single> m_addictiveFloatProperties;        // 0x18
        private System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Vector4> m_addictiveVectorProperties;        // 0x20
        private System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Texture> m_addictiveTextureProperties;        // 0x28

        // Methods
        private System.Void Reset() { }
        private System.Void RequireAddMaterial(UnityEngine.Material material, Beyond.Rendering.EntityVFXRendererMask mask) { }
        private System.Void RequireRemoveMaterial(UnityEngine.Material material, Beyond.Rendering.EntityVFXRendererMask mask) { }
        private System.Void ApplySharedMaterialArray(Beyond.Rendering.EntityRenderHelperMaterialController.RendererInfo rendererInfo) { }
        private System.Void SetAddictiveFloatProperty(System.Int32 propertyId, System.Single value) { }
        private System.Single GetAddictiveFloatProperty(System.Int32 propertyId, System.Single defaultValue) { }
        private System.Void SetAddictiveVectorProperty(System.Int32 propertyId, UnityEngine.Vector4 value) { }
        private UnityEngine.Vector4 GetAddictiveVectorProperty(System.Int32 propertyId, UnityEngine.Vector4 defaultValue) { }
        private System.Void SetAddictiveTextureProperty(System.Int32 propertyId, UnityEngine.Texture value) { }
        private UnityEngine.Texture GetAddictiveTextureProperty(System.Int32 propertyId, UnityEngine.Texture defaultValue) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000025
    public class CustomPerDrawDataController
    {
        // Fields
        private System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperMaterialController.RendererInfo> m_rendererInfos;        // 0x10

        // Methods
        private System.Void Init(System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperMaterialController.RendererInfo> allRendererInfos) { }
        private System.Void Reset() { }
        private System.Void SetFloatToCustomPerDraw(Beyond.Rendering.EntityRenderHelperCustomPerDrawType type, System.Single value, Beyond.Rendering.EntityVFXRendererMask rendererMask) { }
        private System.Void SetVectorToCustomPerDraw(Beyond.Rendering.EntityRenderHelperVectorCustomPerDrawType type, UnityEngine.Vector4 value, Beyond.Rendering.EntityVFXRendererMask rendererMask) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000026
    public class MeshMaterialGroupData
    {
        // Fields
        public Beyond.Rendering.EntityVFXRendererMask mask;        // 0x10
        public System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperMaterialController.RendererInfo> rendererInfos;        // 0x18
        public System.Collections.Generic.Dictionary<System.Int32,System.Single> floatProperties;        // 0x20
        public System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Vector4> vectorProperties;        // 0x28
        public System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Texture> textureProperties;        // 0x30
        public System.Collections.Generic.Dictionary<System.String,System.Boolean> keywordStates;        // 0x38
        public System.Boolean depthOnlyPassControlling;        // 0x40
        public System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material> src2dstMaterialDict;        // 0x48

        // Methods
        private System.Void CopyFrom(Beyond.Rendering.EntityRenderHelperMaterialController.MeshMaterialGroupData src) { }
        private System.Void Clear() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000027
    public class MeshMaterialController
    {
        // Fields
        private System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperMaterialController.MeshMaterialGroupData> m_meshMaterialDatas;        // 0x10
        private static System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperMaterialController.MeshMaterialGroupData> s_cacheMeshMaterialDatas;        // 0x0
        private static readonly System.String VFX_MATERIAL_POSTFIX;        // 0x8

        // Methods
        private System.Void Init(System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperMaterialController.RendererInfo> allRendererInfos) { }
        private System.Void Reset() { }
        private System.Void SetKeywordEnableToAllMaterial(System.String keyword, System.Boolean enable, Beyond.Rendering.EntityVFXRendererMask rendererMask) { }
        private System.Void SetDepthOnlyPassEnableToAllMaterial(System.Boolean enable, Beyond.Rendering.EntityVFXRendererMask rendererMask) { }
        private System.Void SetFloatToAllMaterial(System.Int32 nameId, System.Single value, Beyond.Rendering.EntityVFXRendererMask rendererMask) { }
        private System.Void ReleaseFloatToAllMaterial(System.Int32 nameId, Beyond.Rendering.EntityVFXRendererMask rendererMask) { }
        private System.Void SetVectorToAllMaterial(System.Int32 nameId, UnityEngine.Vector4 value, Beyond.Rendering.EntityVFXRendererMask rendererMask) { }
        private System.Void ReleaseVectorToAllMaterial(System.Int32 nameId, Beyond.Rendering.EntityVFXRendererMask rendererMask) { }
        private System.Void SetTextureToAllMaterial(System.Int32 nameId, UnityEngine.Texture value, Beyond.Rendering.EntityVFXRendererMask rendererMask) { }
        private System.Void ReleaseTextureToAllMaterial(System.Int32 nameId, Beyond.Rendering.EntityVFXRendererMask rendererMask) { }
        private System.Void _CreateReplaceMaterial(Beyond.Rendering.EntityRenderHelperMaterialController.RendererInfo rendererInfo, Beyond.Rendering.EntityRenderHelperMaterialController.MeshMaterialGroupData groupData) { }
        private System.Void _CopyReplaceMaterial(Beyond.Rendering.EntityRenderHelperMaterialController.RendererInfo rendererInfo, Beyond.Rendering.EntityRenderHelperMaterialController.MeshMaterialGroupData groupData) { }
        private System.Void _ReleaseAllReplaceMaterial(Beyond.Rendering.EntityRenderHelperMaterialController.MeshMaterialGroupData groupData) { }
        private System.Void _ReplaceSharedMaterial(Beyond.Rendering.EntityRenderHelperMaterialController.RendererInfo rendererInfo, UnityEngine.Material[] newMaterials) { }
        private System.Void _GetAffectGroupData(Beyond.Rendering.EntityVFXRendererMask rendererMask, System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperMaterialController.MeshMaterialGroupData> result) { }
        private System.Void _SplitRenderers(System.Int32 oldStateIndex, Beyond.Rendering.EntityVFXRendererMask newMask) { }
        private System.Void SetZTestInMaterial(System.String shaderName, System.Boolean enable) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200002B
    public class RendererInfo
    {
        // Fields
        public UnityEngine.Renderer renderer;        // 0x10
        private System.String m_rendererName;        // 0x18
        public System.Boolean oriVisible;        // 0x20
        public System.Boolean curVisible;        // 0x21

        // Methods
        private System.String get_rendererName() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000033
    public struct TimeMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Rendering.EntityVFXAfterImageData.TimeMode Interval;        // 0x0
        public static Beyond.Rendering.EntityVFXAfterImageData.TimeMode Burst;        // 0x0

    }

    // TypeToken: 0x2000041
    public struct State
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Rendering.EntityVFXControllerStateBase.State End;        // 0x0
        public static Beyond.Rendering.EntityVFXControllerStateBase.State Start;        // 0x0
        public static Beyond.Rendering.EntityVFXControllerStateBase.State Loop;        // 0x0
        public static Beyond.Rendering.EntityVFXControllerStateBase.State Ending;        // 0x0

    }

    // TypeToken: 0x2000044
    public struct UVSet
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Rendering.EntityVFXDissolveData.UVSet UV;        // 0x0
        public static Beyond.Rendering.EntityVFXDissolveData.UVSet UV2;        // 0x0

    }

    // TypeToken: 0x2000048
    public class VATData
    {
        // Fields
        public UnityEngine.Texture factoryVATMap;        // 0x10
        public UnityEngine.Vector4 factoryVATMapParams;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000049
    public class AddedMaterialData
    {
        // Fields
        public UnityEngine.Material srcMaterial;        // 0x10
        public UnityEngine.Material[] materialInstancesOfEachVAT;        // 0x18
        public System.Collections.Generic.Dictionary<System.Int32,System.Single> savedFloatProperties;        // 0x20
        public System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Vector4> savedVectorProperties;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004D
    public class VATMaterialData
    {
        // Fields
        public System.Int32 refCount;        // 0x10
        public UnityEngine.Material vatMaterial;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004F
    public struct Type
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Rendering.EntityVFXSetParamsData.Type Character;        // 0x0
        public static Beyond.Rendering.EntityVFXSetParamsData.Type VFX;        // 0x0
        public static Beyond.Rendering.EntityVFXSetParamsData.Type Lit;        // 0x0

    }

    // TypeToken: 0x200005D
    public class PsoInfoWrapperItem
    {
        // Fields
        public System.String infoJson;        // 0x10
        public System.Single time;        // 0x18
        public System.Int32 codeSize;        // 0x1C
        public System.Boolean isMissing;        // 0x20
        public System.String levelId;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005E
    public class PsoInfoWrapper
    {
        // Fields
        public UnityEngine.RuntimePlatform platform;        // 0x10
        public System.String lastCL;        // 0x18
        public System.String lastEngineCl;        // 0x20
        public System.String deviceModel;        // 0x28
        public System.String devVersion;        // 0x30
        public System.String branch;        // 0x38
        public UnityEngine.Rendering.GraphicsDeviceType graphicsDeviceType;        // 0x40
        public System.Int32 shaderLod;        // 0x44
        public System.Int32 infoVersion;        // 0x48
        public System.Boolean isDebug;        // 0x4C
        public System.Collections.Generic.List<Beyond.Rendering.PsoCreateUploadHelper.PsoInfoWrapperItem> psoInfoWrapperItems;        // 0x50

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000067
    public class BoundsUtil
    {
        // Methods
        private System.Void GetTopBottomPoints(UnityEngine.Bounds bounds, UnityEngine.Transform t, UnityEngine.Vector3& topPoint, UnityEngine.Vector3& bottomPoint, System.Nullable<UnityEngine.Vector3> upDir) { }

    }

    // TypeToken: 0x2000069
    public struct Frame
    {
        // Fields
        public UnityEngine.Vector3 origin;        // 0x10
        public UnityEngine.Quaternion rot;        // 0x1C

        // Methods
        private System.Void .ctor(UnityEngine.Vector3 origin, UnityEngine.Quaternion rot) { }
        private UnityEngine.Vector3 WorldToFrame(UnityEngine.Vector3 pWorld) { }
        private UnityEngine.Vector3 FrameToWorld(UnityEngine.Vector3 pFrame) { }

    }

    // TypeToken: 0x200006A
    public struct EdgeMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Rendering.VFXSludgeNavUtils.Spline2DProjectAndSimplify.EdgeMode UseSplineOrder;        // 0x0
        public static Beyond.Rendering.VFXSludgeNavUtils.Spline2DProjectAndSimplify.EdgeMode ConvexHull;        // 0x0

    }

    // TypeToken: 0x200006B
    public class ProcessResult
    {
        // Fields
        public System.Collections.Generic.List<UnityEngine.Vector3> samples3D;        // 0x10
        public System.Collections.Generic.List<UnityEngine.Vector2> projected2D;        // 0x18
        public System.Collections.Generic.List<System.Int32> edgeIndices;        // 0x20
        public System.Collections.Generic.List<System.Int32> simplifiedIndices;        // 0x28
        public System.Single worldMinY;        // 0x30
        public System.Single worldMaxY;        // 0x34
        public System.Single frameMinY;        // 0x38
        public System.Single frameMaxY;        // 0x3C

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000068
    public class Spline2DProjectAndSimplify
    {
        // Methods
        private Beyond.Rendering.VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame MakeFrameFromPlaneNormal(UnityEngine.Vector3 planeOrigin, UnityEngine.Vector3 planeNormal) { }
        private Beyond.Rendering.VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame MakeFrameByYaw(UnityEngine.Vector3 origin, System.Single yawDeg) { }
        private System.Collections.Generic.List<UnityEngine.Vector3> SampleUniformByArcLength(UnityEngine.Splines.SplineContainer container, System.Single stepMeters, System.Int32 splineIndex, System.Boolean closed, System.Single oversample) { }
        private System.Void ProjectWorldToFrameXZ(System.Collections.Generic.List<UnityEngine.Vector3> worldPts, Beyond.Rendering.VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame frame, System.Collections.Generic.List<UnityEngine.Vector2>& projected2D, System.Collections.Generic.List<System.Single>& frameYs, System.Single& worldMinY, System.Single& worldMaxY, System.Single& frameMinY, System.Single& frameMaxY) { }
        private System.Collections.Generic.List<System.Int32> ConvexHullIndices(System.Collections.Generic.List<UnityEngine.Vector2> pts) { }
        private System.Single _AngleDegAt(System.Collections.Generic.List<UnityEngine.Vector2> p, System.Int32 i, System.Boolean closed) { }
        private System.Single _CurvatureAt(System.Collections.Generic.List<UnityEngine.Vector2> p, System.Int32 i, System.Boolean closed) { }
        private System.Single _PointToSegmentDistance2D(UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 p) { }
        private System.Collections.Generic.List<System.Int32> Simplify2D_ByCurvatureAngleDeviation(System.Collections.Generic.List<UnityEngine.Vector2> poly, System.Boolean closed, System.Single angleDegThresh, System.Single deltaKappaThresh, System.Single devEps) { }
        private Beyond.Rendering.VFXSludgeNavUtils.Spline2DProjectAndSimplify.ProcessResult Process(UnityEngine.Splines.SplineContainer container, Beyond.Rendering.VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame frame, System.Single stepMeters, System.Int32 splineIndex, System.Boolean splineClosed, Beyond.Rendering.VFXSludgeNavUtils.Spline2DProjectAndSimplify.EdgeMode edgeMode, System.Single angleDegThresh, System.Single deltaKappaThresh, System.Single devEpsFactor) { }
        private System.Single <ConvexHullIndices>g__Cross|6_1(UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 c) { }

    }

    // TypeToken: 0x200006D
    public class SplineSamplingUtils
    {
        // Methods
        private System.Collections.Generic.List<UnityEngine.Vector2> SampleByArcLength(UnityEngine.Splines.SplineContainer container, System.Single step, System.Int32 splineIndex, System.Int32 lutResolution, System.Boolean closed, System.Boolean worldSpace) { }
        private UnityEngine.Vector3 <SampleByArcLength>g__P|0_0(System.Int32 i, Beyond.Rendering.VFXSludgeNavUtils.SplineSamplingUtils.<>c__DisplayClass0_0& ) { }
        private System.Single <SampleByArcLength>g__WrapLen|0_1(System.Single s, Beyond.Rendering.VFXSludgeNavUtils.SplineSamplingUtils.<>c__DisplayClass0_0& ) { }

    }

    // TypeToken: 0x200006F
    public class PolySimplify
    {
        // Methods
        private System.Collections.Generic.List<UnityEngine.Vector3> SimplifyByAngle(System.Collections.Generic.List<UnityEngine.Vector3> pts, System.Single maxTurnDeg, System.Single minEdgeLen, System.Boolean closed) { }

    }

    // TypeToken: 0x2000079
    public struct __StaticArrayInitTypeSize=20
    {
    }

namespace Beyond.Rendering
{

    // TypeToken: 0x200000A
    public class CustomPerDrawDataChannelUtils
    {
        // Fields
        public static System.Int32 HOUDINI_VAT_INDEX;        // 0x0
        public static System.Int32 HOUDINI_VAT_CHANNEL;        // 0x0
        public static System.Int32 LIT_EMISSIVE_INDEX;        // 0x0
        public static System.Int32 LIT_EMISSIVE_ANIMATION_SWEEP_INDEX;        // 0x0
        public static System.Int32 LIT_EMISSIVE_ALBEDO_INDEX;        // 0x0
        public static System.Int32 UV_ANIMATION_INDEX;        // 0x0
        public static System.Int32 MOVING_BAMBOO_CUR_PARAM_INDEX;        // 0x0
        public static System.Int32 MOVING_BAMBOO_LAST_PARAM_INDEX;        // 0x0
        public static System.Int32 LIT_DISSOLVE_INDEX;        // 0x0
        public static System.Int32 LIT_DISSOLVE_CHANNEL;        // 0x0
        public static System.Int32 CHARACTER_PARAMS_INDEX_WETNESS;        // 0x0
        public static System.Int32 CHARACTER_PARAMS_INDEX_DISSOLVE;        // 0x0
        public static System.Int32 CHARACTER_RAIN_EFFECT_INTENSITY_CHANNEL;        // 0x0
        public static System.Int32 CHARACTER_WET_EFFECT_INTENSITY_CHANNEL;        // 0x0
        public static System.Int32 CHARACTER_WET_EFFECT_WORLD_SPACE_HEIGHT_CHANNEL;        // 0x0
        public static System.Int32 CHARACTER_WET_EFFECT_GLOBAL_INTENSITY_CHANNEL;        // 0x0
        public static System.Int32 CHARACTER_DISSOLVE_SCHEDULE_OFFSET_CHANNEL;        // 0x0
        public static System.Int32 VFX_ALPHA_INDEX;        // 0x0
        public static System.Int32 VFX_ALPHA_DEFAULT_CHANNEL;        // 0x0
        public static System.Int32 LEAF_BLOSSOM_INDEX;        // 0x0

        // Methods
        private System.Void SetPerDrawData_LitDissolve(UnityEngine.Renderer affectRenderer, System.Single dissolve) { }
        private System.Void SetPerDrawData_HoudiniVAT(UnityEngine.Renderer affectRenderer, System.Int32 displayFrame) { }
        private System.Void SetPerDrawData_MovingBamboo(UnityEngine.Renderer affectRenderer, UnityEngine.Vector4 curParam, UnityEngine.Vector4 lastParam) { }
        private System.Void SetPerDrawData_EmissiveColor(UnityEngine.Renderer affectRenderer, UnityEngine.Vector4 emissive) { }
        private System.Void SetPerDrawData_EmissiveAlbedoColor(UnityEngine.Renderer affectRenderer, UnityEngine.Vector4 emissiveAlbedo) { }
        private System.Void SetPerDrawData_SweepLightIntensity(UnityEngine.Renderer affectRenderer, System.Single intensity) { }
        private System.Void SetPerDrawData_UVAnimation(UnityEngine.Renderer affectRenderer, System.Single animationEnable, System.Single customAddTime) { }
        private System.Void SetPerDrawData_CharacterParams(UnityEngine.Renderer affectRenderer, UnityEngine.Vector4 param0, UnityEngine.Vector4 param1) { }
        private System.Void SetPerDrawData_VFXAlpha0(UnityEngine.Renderer affectRenderer, System.Single alpha) { }
        private System.Void SetPerDrawData_LeafBlossom(UnityEngine.Renderer affectRenderer, System.Single alphaClipValue) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000B
    public class PipelineSettingHelper
    {
        // Fields
        public static System.String SETTING_FOLDER;        // 0x0
        public static System.String SETTING_FILE_LIST;        // 0x0

        // Methods
        private System.Void LoadPipelineSettings() { }
        private System.String _LoadSetting(System.String settingName) { }
        private System.String _GetFullSettingPath(System.String settingName) { }

    }

    // TypeToken: 0x200000C
    public class ResourceRouter
    {
        // Fields
        private static System.String DYNAMIC_ENVIRONMENTS_FOLDER;        // 0x0

        // Methods
        private System.String _GetCategoryFolder(Beyond.Resource.RootCategory category) { }
        private System.String GetEnvironmentsFullPath(Beyond.Resource.RootCategory category, System.Boolean isDevOnly) { }
        private System.String GetDecalResourcesPath() { }
        private System.String GetDecalResourcesFullPath(Beyond.Resource.RootCategory category, System.Boolean isDevOnly) { }

    }

    // TypeToken: 0x200000D
    public class ShaderWarmupManager
    {
        // Fields
        public static readonly System.String RUNTIME_PSO_COLLECTION_FOLDER;        // 0x0
        private static System.String WARM_UP_KEY_WORD;        // 0x0
        private static System.String WARM_UP_API_KEY_WORD;        // 0x0
        private static System.String WARM_UP_REASON_KEY_WORD;        // 0x0
        private static System.String WARMUP_RETRY_COUNT;        // 0x0
        private static System.String WARMUP_UNFINISHED_COUNT;        // 0x0
        private static System.String FEATURE_RAYTRACING;        // 0x0
        private static System.String FEATURE_ONE_PASS;        // 0x0
        private static System.Int32 SHADER_COMPILE_WEIGHT;        // 0x0
        public static readonly System.Int32 UNFINISHED_RETRY_COUNT_LIMIT;        // 0x8
        public static readonly System.Int32 CACHE_FAILED_RETRY_COUNT_LIMIT;        // 0xC
        public static System.Boolean s_shouldUseOverride;        // 0x10
        public static System.Boolean s_needWarmupOverride;        // 0x11
        public static System.Int32 s_forceLoginWarmupStartIndex;        // 0x14
        public static System.Int32 s_forceLoginWarmupCount;        // 0x18
        public static System.Int32 s_forceSceneWarmupStartIndex;        // 0x1C
        public static System.Int32 s_forceSceneWarmupCount;        // 0x20
        private static System.String s_disabledFeature;        // 0x28
        private static System.Boolean s_warmupByCacheLoadChecked;        // 0x30
        private static System.Boolean s_isDeviceInBlackList;        // 0x31
        public static System.Int32 s_warmupTotalCount;        // 0x34
        public static System.Int32 s_warmupTotalCountWeighted;        // 0x38
        public static System.Int32 s_warmupRemainCountWeighted;        // 0x3C
        private static System.Int32 s_warmupFinishedCount;        // 0x40
        public static System.Single s_loginWarmUpTime;        // 0x44
        public static Beyond.Rendering.ShaderWarmupManager.WarmUpReason s_loginWarmUpReason;        // 0x48
        public static System.Int64 s_cacheSizeRecompileThreshold;        // 0x50
        public static System.Int32 s_warmupCountPerWorkerMainJobCompile;        // 0x58
        public static System.Int32 s_warmupCountPerStepBackJobCompile;        // 0x5C
        public static System.Int32 s_warmupCountPerStepMainJob;        // 0x60
        public static System.Int32 s_warmupCountPerStepBackJob;        // 0x64
        public static System.Int32 s_warmupCountPerStepBackDispatchLimit;        // 0x68
        public static System.Int32 s_warmupCountToClean;        // 0x6C
        public static System.Int32 s_warmupTimeLimitMobile;        // 0x70
        public static System.Int32 s_warmupTimeLimitPC;        // 0x74
        public static System.String s_vulkanCacheFileName;        // 0x78
        public static System.String s_iosCacheFileName;        // 0x80

        // Methods
        private System.Boolean get_isWarming() { }
        private System.String GetPsoName(UnityEngine.RuntimePlatform platform, UnityEngine.Rendering.GraphicsDeviceType graphicsDeviceType, System.Int32 shaderLod, System.String levelId) { }
        private System.String GetPsoName(UnityEngine.RuntimePlatform platform, UnityEngine.Rendering.GraphicsDeviceType graphicsDeviceType, System.Int32 shaderLod, System.String levelId, System.String feature) { }
        private System.String GetPsoPath(System.String psoName) { }
        private System.String GetLoginWarmupDetail() { }
        private System.Void ProcessRemoteConfig(System.String remoteConfigStr) { }
        private System.Void MarkNeedShaderWarmUp(Beyond.Rendering.ShaderWarmupManager.WarmUpReason reason) { }
        private System.Void MarkWarmUpLoginFinish() { }
        private System.Void CleanLoadedPso() { }
        private System.Void _MarkWarmUpLoginFinish() { }
        private System.Boolean CheckNeedWarmUpLogin() { }
        private System.Collections.IEnumerator WarmupShadersLogin(System.Boolean supportsRaytracing) { }
        private System.Collections.IEnumerator _LoadPsoAssets(System.Collections.Generic.List<Beyond.Resource.StringPathHash> resPathList, System.Collections.Generic.List<Beyond.Resource.FAssetProxyHandle> assetProxyHandles, System.Collections.Generic.List<UnityEngine.HGPsoWarmupCollection> loadedAssets) { }
        private System.Collections.IEnumerator WarmupShadersScene(System.String scene) { }
        private System.Collections.IEnumerator WarmupOnePso(UnityEngine.HGPsoWarmupCollection psoC, System.Int32 startIndex, System.Int32 warmupCount) { }
        private System.Collections.IEnumerator _WarmupOnePsoTimeLimited(UnityEngine.HGPsoWarmupCollection psoC, System.Int32 startIndex, System.Int32 desiredWarmupCount, System.Single timeStart, System.Int32 timeLimitMilliseconds) { }
        private System.Void _StepProgress(System.Int32 newFinishedCount, System.Int32& compileTotalCount) { }
        private System.Boolean _CheckNeedWarmUpByFirstEntry() { }
        private System.Boolean _CheckNeedWarmUpByDeviceState() { }
        private System.Boolean _IsNeedWarmupByGraphicsChange() { }
        private System.Boolean _IsNeedWarmupByCacheOutdated() { }
        private System.Void _SetWarmupRetryCount(System.Int32 count) { }
        private System.Void _SetWarmupUnfinishedCount(System.Int32 count) { }
        private System.Void _MarkWarmupFinishAPI() { }
        private System.Void _ResetWarmUpStats() { }
        private System.Boolean _IsDeviceSupportWarmUp() { }
        private System.Boolean _IsFeatureEnabled(System.String featureKeyword) { }
        private System.Boolean _CheckWarmUpUnfinishedOften() { }
        private System.Int32 _GetLoginTimeLimit() { }
        private System.Int32 _GetCompileStageCount(UnityEngine.HGPsoWarmupCollection psoWarmupCollection) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000014
    public class ShaderWarmupManagerRemoteCfg
    {
        // Fields
        private Beyond.Rendering.ShaderWarmupManagerRemoteCfg.ShaderWarmupRemoteBlacklist m_blacklist;        // 0x10

        // Methods
        private System.Void .ctor(System.String blackListStr) { }
        private System.Boolean IsDeviceInBlackList(System.String& disabledFeature) { }
        private System.String get_cpuNameForWarmUp() { }
        private System.Boolean _CheckDeviceMatch(Beyond.Rendering.ShaderWarmupManagerRemoteCfg.ShaderWarmupRemoteBlackDevice blacklistDevice, System.String currentDeviceModel, System.String currentGraphicsDeviceName, System.String currentGraphicsDeviceVersion, System.String currentProcessorType, System.String currentOS) { }

    }

    // TypeToken: 0x2000017
    public class SOCHelper
    {
        // Fields
        public static readonly System.Int32 CHUNK_SIZE;        // 0x0
        public static System.String SOC_FOLDER_NAME;        // 0x0
        public static System.String SOC_INTERMEDIATE_FILE_NAME;        // 0x0

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000018
    public class HGSOCSubSceneData : ScriptableObject
    {
        // Fields
        public System.UInt32[] stateMasks;        // 0x18
        public Beyond.Rendering.HGSOCSubSceneData.SubSceneDataPerSceneState[] stateDataArray;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001B
    public class HGSOCDataHelper : MonoBehaviour
    {
        // Fields
        public System.Single fallOffStrength;        // 0x18
        public System.Single innerBlendWeight;        // 0x1C
        private System.Boolean <displayQuadOccluders>k__BackingField;        // 0x20
        private System.Boolean <displayHGOccluders>k__BackingField;        // 0x21
        public UnityEngine.Material material;        // 0x28
        public UnityEngine.HGOccluder[] occluders;        // 0x30

        // Methods
        private System.Boolean get_displayQuadOccluders() { }
        private System.Void set_displayQuadOccluders(System.Boolean value) { }
        private System.Boolean get_displayHGOccluders() { }
        private System.Void set_displayHGOccluders(System.Boolean value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001C
    public class EntityRenderAlphaDitherController
    {
        // Fields
        private Beyond.Rendering.IRendererHelper m_owner;        // 0x10
        private System.Single m_ditherAlpha;        // 0x18
        private static System.Int32 s_CharDitherFade;        // 0x0
        private static System.Int32 s_DitherTransparentAlpha;        // 0x4
        private System.Collections.Generic.Dictionary<System.Int32,System.Single> m_alphaPerHandles;        // 0x20
        private System.Boolean m_lastSetAllRendererEnabled;        // 0x28

        // Methods
        private System.Void .ctor(Beyond.Rendering.IRendererHelper owner) { }
        private System.Void ResetDitherAlpha() { }
        private System.Boolean SetDitherAlpha(System.Single alpha, System.Int32 handle) { }
        private System.Single GetDitherAlpha() { }
        private System.Void Reset() { }
        private System.Boolean _ApplyNewAlpha() { }
        private System.Single _GetCurMinAlpha() { }
        private System.Collections.Generic.Dictionary<System.Int32,System.Single> GetAlphaDictionary() { }
        private System.Void _SetMaterialDitherAlpha(System.Single value) { }
        private System.Boolean _SetMaterialDitherEnabled(System.Boolean enabled) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200001D
    public class EntityRenderCapturedEntity
    {
        // Fields
        public UnityEngine.GameObject rootGameObject;        // 0x10
        public System.Collections.Generic.List<UnityEngine.MeshRenderer> meshRenderers;        // 0x18
        public System.Collections.Generic.List<UnityEngine.MeshRenderer> capturedRenderers;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001E
    public class EntityRenderCaptureMeshController
    {
        // Fields
        private Beyond.Rendering.IRendererHelper m_owner;        // 0x10
        private UnityEngine.GameObject m_gameObject;        // 0x18
        private UnityEngine.LODGroup m_lodGroup;        // 0x20
        private System.Collections.Generic.List<Beyond.Rendering.EntityRenderCapturedEntity> m_capturedEntities;        // 0x28

        // Methods
        private System.Void .ctor(Beyond.Rendering.IRendererHelper owner, UnityEngine.GameObject gameObject) { }
        private System.Void Reset() { }
        private Beyond.Rendering.EntityRenderCapturedEntity Capture(UnityEngine.GameObject root) { }
        private System.Void Release(Beyond.Rendering.EntityRenderCapturedEntity mesh) { }

    }

    // TypeToken: 0x2000020
    public class EntityRendererTypeConfig
    {
        // Fields
        public System.String regexString;        // 0x10
        public System.Text.RegularExpressions.Regex regex;        // 0x18
        public Beyond.Rendering.EntityVFXRendererType type;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000021
    public class EntityRenderHelperMaterialController
    {
        // Fields
        private static System.Collections.Generic.List<UnityEngine.Material> s_cachedMaterialList;        // 0x0
        private System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperMaterialController.RendererInfo> m_rendererInfos;        // 0x10
        private Beyond.Rendering.EntityRenderHelperMaterialController.AddedMaterialController m_addedMaterialController;        // 0x18
        private Beyond.Rendering.EntityRenderHelperMaterialController.MeshMaterialController m_meshMaterialController;        // 0x20
        private System.Collections.Generic.Dictionary<Beyond.Rendering.EntityVFXRendererMask,System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperMaterialController.RendererInfo>> m_renderInfoIndexPerMask;        // 0x28
        private Beyond.Rendering.EntityRenderHelperMaterialController.CustomPerDrawDataController m_customPerDrawDataController;        // 0x30
        private static Beyond.PoolCore.ObjectPool<Beyond.Rendering.EntityRenderHelperMaterialController.RendererInfo> s_rendererInfoPool;        // 0x8
        private static Beyond.PoolCore.ObjectPool<System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperMaterialController.RendererInfo>> s_rendererInfoListPool;        // 0x10
        private static System.Int32 s_ZTestGBuffer;        // 0x18
        private static System.Int32 s_OutlineZTest;        // 0x1C
        private static System.String s_AlphaBlendOnKeyword;        // 0x20

        // Methods
        private System.Void Init(System.Collections.Generic.List<UnityEngine.Renderer> allRenderers, System.Collections.Generic.List<Beyond.Rendering.EntityRendererTypeConfig> configs) { }
        private System.Void OnRelease() { }
        private System.Void Reset() { }
        private System.Boolean IsAllRendererValid() { }
        private System.Void StopShadowCasting(System.Boolean stopRayTracing) { }
        private System.Void RevertShadowCastingMode() { }
        private System.Void AddMaterialToAllRenderer(UnityEngine.Material material, Beyond.Rendering.EntityVFXRendererMask rendererMask) { }
        private System.Void SetAddictiveFloatProperty(System.Int32 propertyId, System.Single value) { }
        private System.Single GetAddictiveFloatProperty(System.Int32 propertyId, System.Single defaultValue) { }
        private System.Void SetAddictiveVectorProperty(System.Int32 propertyId, UnityEngine.Vector4 value) { }
        private UnityEngine.Vector4 GetAddictiveVectorProperty(System.Int32 propertyId, UnityEngine.Vector4 defaultValue) { }
        private System.Void SetAddictiveTextureProperty(System.Int32 propertyId, UnityEngine.Texture value) { }
        private UnityEngine.Texture GetAddictiveTextureProperty(System.Int32 propertyId, UnityEngine.Texture defaultValue) { }
        private System.Void RemoveMaterialFromAllRenderer(UnityEngine.Material material, Beyond.Rendering.EntityVFXRendererMask rendererMask) { }
        private System.Void SetKeywordEnableToAllMaterial(System.String keyword, System.Boolean enable, Beyond.Rendering.EntityVFXRendererMask rendererMask) { }
        private System.Void SetDepthOnlyPassEnableToAllMaterial(System.Boolean enable, Beyond.Rendering.EntityVFXRendererMask rendererMask) { }
        private System.Void SetFloatToCustomPerDraw(Beyond.Rendering.EntityRenderHelperCustomPerDrawType type, System.Single value, Beyond.Rendering.EntityVFXRendererMask rendererMask) { }
        private System.Void SetVectorToCustomPerDraw(Beyond.Rendering.EntityRenderHelperVectorCustomPerDrawType type, UnityEngine.Vector4 value, Beyond.Rendering.EntityVFXRendererMask rendererMask) { }
        private System.Void SetFloatToAllMaterial(System.Int32 nameId, System.Single value, Beyond.Rendering.EntityVFXRendererMask rendererMask) { }
        private System.Void SetVectorToAllMaterial(System.Int32 nameId, UnityEngine.Vector4 value, Beyond.Rendering.EntityVFXRendererMask rendererMask) { }
        private System.Void SetTextureToAllMaterial(System.Int32 nameId, UnityEngine.Texture value, Beyond.Rendering.EntityVFXRendererMask rendererMask) { }
        private System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperMaterialController.RendererInfo> _GetRenderersOfRendererMask(Beyond.Rendering.EntityVFXRendererMask rendererMask, System.Boolean affectAll) { }
        private System.Int32 _GetSubMeshCount(UnityEngine.Renderer renderer) { }
        private System.Void SetManualDitherAlphaValue(System.Single value) { }
        private System.Boolean SetManualDitherEnable(System.Boolean enable) { }
        private UnityEngine.Bounds GetRendererBounds() { }
        private System.Void SetZTestInMaterial(System.String shaderName, System.Boolean enable) { }
        private Beyond.Rendering.RenderHelperType GetRenderHelperType() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000028
    public struct EntityRenderHelperCustomPerDrawType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Rendering.EntityRenderHelperCustomPerDrawType RainEffectIntensity;        // 0x0
        public static Beyond.Rendering.EntityRenderHelperCustomPerDrawType WetEffectIntensity;        // 0x0
        public static Beyond.Rendering.EntityRenderHelperCustomPerDrawType WetEffectWorldSpaceHeight;        // 0x0
        public static Beyond.Rendering.EntityRenderHelperCustomPerDrawType WetEffectGlobalIntensity;        // 0x0
        public static Beyond.Rendering.EntityRenderHelperCustomPerDrawType CharacterDissolveScheduleOffset;        // 0x0

    }

    // TypeToken: 0x2000029
    public struct EntityRenderHelperVectorCustomPerDrawType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Rendering.EntityRenderHelperVectorCustomPerDrawType Emissive;        // 0x0

    }

    // TypeToken: 0x200002A
    public class EntityRenderHelperVisibleController
    {
        // Fields
        private System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperVisibleController.RendererInfo> m_rendererInfos;        // 0x10
        private System.Collections.Generic.Dictionary<UnityEngine.Renderer,Beyond.Rendering.EntityRenderHelperVisibleController.RendererInfo> m_dictionary;        // 0x18
        private static Beyond.PoolCore.ObjectPool<System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperVisibleController.RendererInfo>> s_rendererInfoListPool;        // 0x0
        private static Beyond.PoolCore.ObjectPool<System.Collections.Generic.Dictionary<UnityEngine.Renderer,Beyond.Rendering.EntityRenderHelperVisibleController.RendererInfo>> s_rendererInfoDictPool;        // 0x8

        // Methods
        private System.Void Init(System.Collections.Generic.List<UnityEngine.Renderer> allRenderers) { }
        private System.Void _InitDictionary() { }
        private System.Void Release() { }
        private System.Void SetVisibleByNameContainsStr(System.String name, System.Boolean visible) { }
        private System.Void SetVisibleByRenderer(UnityEngine.Renderer renderer, System.Boolean visible) { }
        private System.Void ResetVisibleByNameContainsStr(System.String name) { }
        private System.Void ResetVisibleByRenderer(UnityEngine.Renderer renderer) { }
        private System.Void Reset() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200002C
    public class EntityRenderMaterialManager
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.Int32,System.Single> m_floatProperties;        // 0x10
        private System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Texture> m_textureProperties;        // 0x18
        private System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Vector4> m_vectorProperties;        // 0x20
        private System.Collections.Generic.HashSet<System.String> m_EnabledKeyWords;        // 0x28
        private System.Collections.Generic.HashSet<System.String> m_DisabledKeyWords;        // 0x30
        private System.Boolean m_shaderPassEnabled;        // 0x38
        private System.Collections.Generic.Dictionary<UnityEngine.Material,System.Boolean> m_oriMaterialShaderPassEnabled;        // 0x40
        private static System.Int32 s_ZTestGBuffer;        // 0x0
        private System.Collections.Generic.List<UnityEngine.Material> m_materials;        // 0x48

        // Methods
        private System.Void SetFloat(System.Int32 nameID, System.Single value) { }
        private System.Void SetTexture(System.Int32 nameID, UnityEngine.Texture value) { }
        private System.Void SetVector(System.Int32 nameID, UnityEngine.Vector4 value) { }
        private System.Void AddMaterial(UnityEngine.Material material) { }
        private System.Void RemoveMaterial(UnityEngine.Material material) { }
        private System.Void ClearMaterials() { }
        private System.Void SetKeywordEnable(System.String keyword, System.Boolean enable) { }
        private System.Void SetDepthOnlyEnabled(System.Boolean enable) { }
        private System.Void SetZTestInMaterial(System.String shaderName, System.Boolean enable) { }
        private System.Void _RevertMaterial(UnityEngine.Material material) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200002D
    public class EntityVFXCurve
    {
        // Fields
        public UnityEngine.AnimationCurve curve;        // 0x10
        public UnityEngine.Vector2 rangeEdit;        // 0x18
        public UnityEngine.Vector2 rangeLimit;        // 0x20

        // Methods
        private System.Void .ctor(UnityEngine.AnimationCurve curve) { }

    }

    // TypeToken: 0x200002E
    public struct EntityVFXCurveEvaluateResult
    {
        // Fields
        public UnityEngine.Rendering.ShaderPropertyType propertyType;        // 0x10
        public System.String propertyName;        // 0x18
        public System.Int32 propertyId;        // 0x20
        public System.Single floatValue;        // 0x24
        public UnityEngine.Vector4 vectorValue;        // 0x28
        public UnityEngine.Vector4 textureScaleOffset;        // 0x38

    }

    // TypeToken: 0x200002F
    public class EntityVFXCurveData
    {
        // Fields
        public System.String propertyName;        // 0x10
        public UnityEngine.Rendering.ShaderPropertyType propertyType;        // 0x18
        public Beyond.Rendering.EntityVFXCurve curve;        // 0x20
        public Beyond.Rendering.EntityVFXCurve curveX;        // 0x28
        public Beyond.Rendering.EntityVFXCurve curveY;        // 0x30
        public Beyond.Rendering.EntityVFXCurve curveZ;        // 0x38
        public Beyond.Rendering.EntityVFXCurve curveW;        // 0x40
        public UnityEngine.Gradient gradient;        // 0x48
        public System.Single colorIntensity;        // 0x50

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000030
    public class EntityVFXAddictiveMaterialData
    {
        // Fields
        public Beyond.Rendering.EntityVFXPriorityType priorityType;        // 0x10
        public Beyond.Rendering.EntityVFXRendererMask rendererMask;        // 0x14
        public System.Boolean useScaledTime;        // 0x18
        public System.Boolean enableVertColorIfMeshHasVFXVertColor;        // 0x19
        public UnityEngine.Material material;        // 0x20
        public System.Boolean loop;        // 0x28
        public System.Boolean useDissolveCurve;        // 0x29
        public System.Boolean useScanCurve;        // 0x2A
        public System.Boolean useCutoffPosY;        // 0x2B
        public System.Boolean useCutoffPosYAutoBounds;        // 0x2C
        public System.Single cutoffPosYAbsoluteBounds;        // 0x30
        public System.Boolean useCutoffLocalDirection;        // 0x34
        public UnityEngine.Vector3 cutoffDirection;        // 0x38
        public System.Single duration;        // 0x44
        public System.Boolean useStartCurve;        // 0x48
        public UnityEngine.AnimationCurve opacityCurve;        // 0x50
        public UnityEngine.AnimationCurve dissolveCurve;        // 0x58
        public UnityEngine.AnimationCurve scanCurve;        // 0x60
        public UnityEngine.AnimationCurve cutoffPosYCurve;        // 0x68
        public System.Collections.Generic.List<Beyond.Rendering.EntityVFXCurveData> customCurves;        // 0x70
        public System.Boolean useLoopCurve;        // 0x78
        public System.Single loopDuration;        // 0x7C
        public UnityEngine.AnimationCurve loopCurve;        // 0x80
        public UnityEngine.AnimationCurve dissolveLoopCurve;        // 0x88
        public System.Collections.Generic.List<Beyond.Rendering.EntityVFXCurveData> customLoopCurves;        // 0x90
        public System.Boolean useEndCurve;        // 0x98
        public System.Single endDuration;        // 0x9C
        public UnityEngine.AnimationCurve endCurve;        // 0xA0
        public UnityEngine.AnimationCurve dissolveEndCurve;        // 0xA8
        public System.Collections.Generic.List<Beyond.Rendering.EntityVFXCurveData> customEndCurves;        // 0xB0
        public System.Boolean useAddictiveProperties;        // 0xB8
        public System.Boolean useAddictivePropertiesUpdate;        // 0xB9
        public System.Collections.Generic.List<System.String> addictiveVectorProperties;        // 0xC0

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000031
    public class EntityVFXAddictiveMaterialAsset : EntityVFXAssetBase
    {
        // Fields
        public Beyond.Rendering.EntityVFXAddictiveMaterialData data;        // 0x30

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000032
    public class EntityVFXAfterImageData
    {
        // Fields
        public System.Boolean useScaledTime;        // 0x10
        public Beyond.Rendering.EntityVFXAfterImageData.TimeMode timeMode;        // 0x14
        public System.Boolean loop;        // 0x18
        public System.Single duration;        // 0x1C
        public System.Single timeInterval;        // 0x20
        public System.Collections.Generic.List<System.Single> timeBurst;        // 0x28
        public UnityEngine.Material depthOnlyMaterial;        // 0x30
        public UnityEngine.Material material;        // 0x38
        public UnityEngine.Material materialOutline;        // 0x40
        public System.Single lifeTime;        // 0x48
        public UnityEngine.AnimationCurve opacityCurve;        // 0x50
        public UnityEngine.AnimationCurve dissolveCurve;        // 0x58
        public System.Collections.Generic.List<Beyond.Rendering.EntityVFXCurveData> customCurves;        // 0x60
        public UnityEngine.AnimationCurve opacityCurveOutline;        // 0x68
        public System.Collections.Generic.List<Beyond.Rendering.EntityVFXCurveData> customCurvesOutline;        // 0x70

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000034
    public class EntityVFXAfterImageAsset : EntityVFXAssetBase
    {
        // Fields
        public Beyond.Rendering.EntityVFXAfterImageData data;        // 0x30

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000035
    public struct EntityCustomizeRendererType
    {
        // Fields
        public System.String rendererNameRegex;        // 0x10
        public Beyond.Rendering.EntityVFXRendererType type;        // 0x18

    }

    // TypeToken: 0x2000036
    public class EntityVFXAsset : ScriptableObject
    {
        // Fields
        public System.Boolean useCustomRenderer;        // 0x18
        public System.Collections.Generic.List<Beyond.Rendering.EntityCustomizeRendererType> customRenderers;        // 0x20
        public System.Boolean meshHasVFXVertColor;        // 0x28
        private System.Collections.Generic.List<Beyond.Rendering.EntityRendererTypeConfig> m_rendererTypeConfigs;        // 0x30

        // Methods
        private System.Collections.Generic.List<Beyond.Rendering.EntityRendererTypeConfig> GetRendererTypeConfigs(System.Boolean forceUpdate) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000037
    public struct EntityVFXRendererType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Rendering.EntityVFXRendererType Normal;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererType Body;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererType Cloth;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererType Eyebrow;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererType EyeShadow;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererType Face;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererType Hair;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererType HairShadow;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererType Iris;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererType Weapon1;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererType Weapon2;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererType Part1;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererType Part2;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererType Part3;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererType Part4;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererType Part5;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererType Part6;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererType Part7;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererType Part8;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererType Part9;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererType Part10;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererType Part11;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererType Part12;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererType Part13;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererType Part14;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererType Part15;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererType AlphaQuadAvoidAddMaterial;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererType Count;        // 0x0

    }

    // TypeToken: 0x2000038
    public struct EntityVFXRendererMask
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Rendering.EntityVFXRendererMask Normal;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererMask Body;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererMask Cloth;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererMask Eyebrow;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererMask EyeShadow;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererMask Face;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererMask Hair;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererMask HairShadow;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererMask Iris;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererMask Weapon1;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererMask Weapon2;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererMask Part1;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererMask Part2;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererMask Part3;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererMask Part4;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererMask Part5;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererMask Part6;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererMask Part7;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererMask Part8;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererMask Part9;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererMask Part10;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererMask Part11;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererMask Part12;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererMask Part13;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererMask Part14;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererMask Part15;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererMask AlphaQuadAvoidAddMaterial;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererMask All;        // 0x0
        public static Beyond.Rendering.EntityVFXRendererMask AllWithoutAlphaQuad;        // 0x0

    }

    // TypeToken: 0x2000039
    public struct EntityVFXPriorityType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Rendering.EntityVFXPriorityType Normal;        // 0x0
        public static Beyond.Rendering.EntityVFXPriorityType UltiSkillTimeline;        // 0x0

    }

    // TypeToken: 0x200003A
    public struct SettingLodLevel
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Rendering.SettingLodLevel None;        // 0x0
        public static Beyond.Rendering.SettingLodLevel Low;        // 0x0
        public static Beyond.Rendering.SettingLodLevel Mid;        // 0x0
        public static Beyond.Rendering.SettingLodLevel High;        // 0x0
        public static Beyond.Rendering.SettingLodLevel Highest;        // 0x0

    }

    // TypeToken: 0x200003B
    public struct AssetPlatformLayers
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Rendering.AssetPlatformLayers PC;        // 0x0
        public static Beyond.Rendering.AssetPlatformLayers Mobile;        // 0x0
        public static Beyond.Rendering.AssetPlatformLayers Other;        // 0x0

    }

    // TypeToken: 0x200003C
    public struct EffectTargetLayers
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Rendering.EffectTargetLayers Main;        // 0x0
        public static Beyond.Rendering.EffectTargetLayers Guard;        // 0x0

    }

    // TypeToken: 0x200003D
    public class EntityVFXAssetBase : ScriptableObject
    {
        // Fields
        public System.Boolean useECSRenderer;        // 0x18
        public Beyond.Rendering.SettingLodLevel settingLodLevel;        // 0x1C
        public Beyond.Rendering.AssetPlatformLayers platformLayer;        // 0x20
        public Beyond.Rendering.EffectTargetLayers targetLayer;        // 0x24
        private System.String m_assetName;        // 0x28

        // Methods
        private System.String get_assetName() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003E
    public struct VFXType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Rendering.VFXType Addictive;        // 0x0
        public static Beyond.Rendering.VFXType Dissolve;        // 0x0
        public static Beyond.Rendering.VFXType Max;        // 0x0

    }

    // TypeToken: 0x200003F
    public class EntityVFXControllerBase
    {
        // Fields
        public Beyond.Rendering.SettingLodLevel settingLodLevel;        // 0x10
        public Beyond.Rendering.AssetPlatformLayers platformLayer;        // 0x14
        public Beyond.Rendering.EffectTargetLayers targetLayer;        // 0x18
        protected Beyond.Rendering.IRendererHelper m_owner;        // 0x20
        protected System.Boolean m_isPlaying;        // 0x28
        private System.Boolean m_isHiding;        // 0x29
        protected System.Boolean m_isKeyword;        // 0x2A
        private System.String m_vfxName;        // 0x30
        private System.Single m_destroyTime;        // 0x38
        private System.Single m_lastTickTime;        // 0x3C
        public System.Boolean preload;        // 0x40
        public System.Boolean fromTimeline;        // 0x41

        // Methods
        private System.Boolean get_isPlaying() { }
        private System.Boolean get_isHiding() { }
        private System.Boolean get_isKeyword() { }
        private System.String get_vfxName() { }
        private System.Single get_destroyTime() { }
        private System.Void set_destroyTime(System.Single value) { }
        private System.Single get_lastTickTime() { }
        private System.Void set_lastTickTime(System.Single value) { }
        private System.Void SetOwner(System.String name, Beyond.Rendering.IRendererHelper owner) { }
        private System.Void InitLOD(Beyond.Rendering.EntityVFXAssetBase vfxAssetBase) { }
        private System.Void SetName(System.String name) { }
        private System.Boolean PoolTick() { }
        private System.Void Destroy() { }
        private System.Void OnDestroy() { }
        private System.Void Play() { }
        private System.Void Stop(System.Boolean forceStop) { }
        private System.Void Replay() { }
        private System.Void Tick(System.Single logicDeltaTime) { }
        private System.Void RefreshLastTickTime() { }
        private System.Single GetDeltaTimeFromLastTick(System.Boolean useScaledTime) { }
        private Beyond.Rendering.EntityVFXPriorityType GetPriorityType() { }
        private System.Boolean GetNeedTick() { }
        private System.Void Hide() { }
        private System.Void OnHide() { }
        private System.Void Show() { }
        private System.Void OnShow() { }
        private System.Void Sample(System.Single time, System.Boolean ending) { }
        private System.Void OnSample(System.Single time, System.Boolean ending) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000040
    public class EntityVFXControllerStateBase : EntityVFXControllerBase
    {
        // Fields
        private System.Single <m_passTime>k__BackingField;        // 0x48
        private System.Single <m_loopPassTime>k__BackingField;        // 0x4C
        private System.Single <m_endPassTime>k__BackingField;        // 0x50
        private Beyond.Rendering.EntityVFXControllerStateBase.State m_curState;        // 0x54

        // Methods
        private System.Single get_m_passTime() { }
        private System.Void set_m_passTime(System.Single value) { }
        private System.Single get_m_loopPassTime() { }
        private System.Void set_m_loopPassTime(System.Single value) { }
        private System.Single get_m_endPassTime() { }
        private System.Void set_m_endPassTime(System.Single value) { }
        private System.Void Play() { }
        private System.Void Replay() { }
        private System.Void Stop(System.Boolean forceStop) { }
        private System.Boolean GetNeedTick() { }
        private System.Void Tick(System.Single logicDeltaTime) { }
        private System.Void OnSample(System.Single time, System.Boolean ending) { }
        private System.Boolean get_useScaledTime() { }
        private System.Boolean get_useStartCurve() { }
        private System.Boolean get_useLoopCurve() { }
        private System.Boolean get_useEndCurve() { }
        private System.Boolean get_loop() { }
        private System.Single get_duration() { }
        private System.Single get_loopDuration() { }
        private System.Single get_endDuration() { }
        private System.Void UpdateStart() { }
        private System.Void UpdateLoop() { }
        private System.Void UpdateStop() { }
        private System.Void _FinalStop() { }
        private System.Void OnFinalStop() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Play() { }
        private System.Void <>iFixBaseProxy_Replay() { }
        private System.Void <>iFixBaseProxy_Stop(System.Boolean P0) { }
        private System.Boolean <>iFixBaseProxy_GetNeedTick() { }
        private System.Void <>iFixBaseProxy_Tick(System.Single P0) { }
        private System.Void <>iFixBaseProxy_OnSample(System.Single P0, System.Boolean P1) { }

    }

    // TypeToken: 0x2000042
    public struct EntityVFXKeywordEnum
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Rendering.EntityVFXKeywordEnum None;        // 0x0
        public static Beyond.Rendering.EntityVFXKeywordEnum Dissolve;        // 0x0

    }

    // TypeToken: 0x2000043
    public class EntityVFXDissolveData
    {
        // Fields
        public Beyond.Rendering.EntityVFXPriorityType priorityType;        // 0x10
        public Beyond.Rendering.EntityVFXRendererMask rendererMask;        // 0x14
        public System.Boolean useScaledTime;        // 0x18
        public System.Boolean loop;        // 0x19
        public System.Single duration;        // 0x1C
        public Beyond.Rendering.EntityVFXDissolveData.UVSet uvSet;        // 0x20
        public System.Boolean useCutoffPosY;        // 0x24
        public System.Boolean useCutoffPosYAutoBounds;        // 0x25
        public System.Single cutoffPosYAbsoluteBounds;        // 0x28
        public System.Boolean useCutoffLocalDirection;        // 0x2C
        public UnityEngine.Vector3 cutoffDirection;        // 0x30
        public System.Single cutoffUseDissolve;        // 0x3C
        public System.Boolean stopShadowCasting;        // 0x40
        public System.Boolean stopRayTracingMeanTime;        // 0x41
        public System.Single stopShadowCastingDelay;        // 0x44
        public System.Single revertShadowCastingDelay;        // 0x48
        public UnityEngine.Texture2D dissolveTexture;        // 0x50
        public UnityEngine.Vector4 dissolveTextureTillingOffset;        // 0x58
        public System.Single dissolveEdgeSharp;        // 0x68
        public UnityEngine.Color dissolveEmissiveColor;        // 0x6C
        public System.Single dissolveEmissiveEdge;        // 0x7C
        public System.Boolean useLocalScreenUV;        // 0x80
        public UnityEngine.AnimationCurve dissolveValueCurve;        // 0x88
        public UnityEngine.AnimationCurve cutoffPosYCurve;        // 0x90

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000045
    public class EntityVFXDissolveAsset : EntityVFXAssetBase
    {
        // Fields
        public Beyond.Rendering.EntityVFXDissolveData data;        // 0x30

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000046
    public class EntityFactoryRendererInfo
    {
        // Fields
        public System.Int32 subMeshCount;        // 0x10
        public System.Boolean enableVAT;        // 0x14
        public System.Int32 vatIndex;        // 0x18
        public System.Int32 initMaterialsCount;        // 0x1C

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000047
    public class EntityVFXFactoryAddedMaterialManager
    {
        // Fields
        private static readonly System.Int32 S_ENABLE_FACTORY_VAT;        // 0x0
        private static readonly System.Int32 S_FACTORY_VAT_MAP;        // 0x4
        private static readonly System.Int32 S_FACTORY_VAT_MAP_PARAMS;        // 0x8
        private System.Collections.Generic.List<Beyond.Rendering.EntityFactoryRendererInfo> m_factoryRendererInfos;        // 0x10
        private System.Collections.Generic.List<Beyond.Rendering.EntityVFXFactoryAddedMaterialManager.VATData> m_vatDatas;        // 0x18
        private System.Collections.Generic.List<Beyond.Rendering.EntityVFXFactoryAddedMaterialManager.AddedMaterialData> m_addedMaterialDatas;        // 0x20
        private System.Collections.Generic.Dictionary<UnityEngine.Material,Beyond.Rendering.EntityVFXFactoryAddedMaterialManager.AddedMaterialData> m_addedMaterialDataDict;        // 0x28

        // Methods
        private System.Void Init(System.Collections.Generic.List<Beyond.Rendering.EntityFactoryRendererInfo> factoryRendererInfos) { }
        private System.Void _AddVATMaterial(UnityEngine.Material src) { }
        private UnityEngine.Material _GetVATMaterial(Beyond.Rendering.EntityFactoryRendererInfo rendererInfo, UnityEngine.Material src) { }
        private System.Int32 _GetAddedMaterialIndex(Beyond.Rendering.EntityFactoryRendererInfo rendererInfo, UnityEngine.Material src) { }
        private System.Void _RemoveVATMaterial(UnityEngine.Material src) { }
        private System.Void AddMaterialToAllRenderer(UnityEngine.Material material) { }
        private System.Void RemoveMaterialFromAllRenderer(UnityEngine.Material material) { }
        private System.Void SetFloatToFactoryMaterial(UnityEngine.Material material, System.Int32 nameId, System.Single value) { }
        private System.Void SetVectorToFactoryMaterial(UnityEngine.Material material, System.Int32 nameId, UnityEngine.Vector4 value) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200004C
    public class EntityVFXFactoryMaterialCache
    {
        // Fields
        private static readonly System.Int32 S_FACTORY_VAT_MAP;        // 0x0
        private static readonly System.Int32 S_FACTORY_VAT_MAP_PARAMS;        // 0x4
        private static System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,Beyond.Rendering.EntityVFXFactoryMaterialCache.VATMaterialData>> s_cachedMaterials;        // 0x8

        // Methods
        private UnityEngine.Material GetVATMaterial(UnityEngine.Material srcMaterial, UnityEngine.Texture factoryVATMap, UnityEngine.Vector4 factoryVATMapParams) { }
        private System.Void ReleaseVATMaterial(UnityEngine.Material srcMaterial, UnityEngine.Texture factoryVATMap) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200004E
    public class EntityVFXSetParamsData
    {
        // Fields
        public Beyond.Rendering.EntityVFXPriorityType priorityType;        // 0x10
        public Beyond.Rendering.EntityVFXRendererMask rendererMask;        // 0x14
        public System.Boolean useScaledTime;        // 0x18
        public System.Boolean loop;        // 0x19
        public Beyond.Rendering.EntityVFXSetParamsData.Type type;        // 0x1C
        public System.Single duration;        // 0x20
        public System.Collections.Generic.List<Beyond.Rendering.EntityVFXCurveData> customCurves;        // 0x28
        public System.Boolean useLoopCurve;        // 0x30
        public System.Single loopDuration;        // 0x34
        public System.Collections.Generic.List<Beyond.Rendering.EntityVFXCurveData> customLoopCurves;        // 0x38
        public System.Single endDuration;        // 0x40
        public System.Collections.Generic.List<Beyond.Rendering.EntityVFXCurveData> customEndCurves;        // 0x48

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000050
    public class EntityVFXSetParamsAsset : EntityVFXAssetBase
    {
        // Fields
        public Beyond.Rendering.EntityVFXSetParamsData data;        // 0x30

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000051
    public class EntityVFXUtils
    {
        // Methods
        private Beyond.Rendering.EntityVFXRendererMask ToMask(Beyond.Rendering.EntityVFXRendererType type) { }
        private System.Void CalculateCutOffBounds(Beyond.Rendering.IRendererHelper owner, System.Boolean useCutoffLocalDirection, UnityEngine.Vector3 cutoffDirectionData, System.Boolean useCutoffPosYAutoBounds, System.Single cutoffPosYAbsoluteBounds, System.Single& cutoffMin, System.Single& cutoffMax, UnityEngine.Vector3& cutoffDirection) { }
        private System.ValueTuple<System.Single,System.Single> GetBoundsMinMaxOfDirection(UnityEngine.Bounds bounds, UnityEngine.Vector3 direction) { }
        private System.Void ApplyEntityVFXCurves(UnityEngine.Material material, System.Collections.Generic.List<Beyond.Rendering.EntityVFXCurveData> curveDataList, System.Single schedule) { }
        private Beyond.Rendering.EntityVFXCurveEvaluateResult Evaluate(Beyond.Rendering.EntityVFXCurveData curveData, System.Single schedule) { }
        private System.Void _UpdateCurve(UnityEngine.Material material, Beyond.Rendering.EntityVFXCurveData curveData, System.Single schedule) { }
        private System.Boolean IsCharacterShader(System.String name) { }
        private System.Boolean IsLitShader(System.String name) { }

    }

    // TypeToken: 0x2000052
    public interface ICaptureMesh
    {
        // Methods
        private Beyond.Rendering.EntityRenderCapturedEntity Capture(UnityEngine.GameObject placeRoot) { }
        private System.Void Release(Beyond.Rendering.EntityRenderCapturedEntity mesh) { }

    }

    // TypeToken: 0x2000053
    public struct RenderHelperType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Rendering.RenderHelperType Unknown;        // 0x0
        public static Beyond.Rendering.RenderHelperType Character;        // 0x0
        public static Beyond.Rendering.RenderHelperType Lit;        // 0x0
        public static Beyond.Rendering.RenderHelperType Mix;        // 0x0

    }

    // TypeToken: 0x2000054
    public interface IRendererHelper
    {
        // Methods
        private System.Void Reset() { }
        private System.Void Play(System.String vfxName) { }
        private System.Void Stop(System.String vfxName) { }
        private System.Void ShowAll() { }
        private System.Void HideAll() { }
        private System.Void SetDitherAlpha(System.Single ditherAlpha, System.Int32 handle) { }
        private System.Single GetDitherAlpha() { }
        private System.Void ResetAllDitherAlpha() { }
        private System.Void ClearEffectCache(System.String name) { }
        private System.Void SetVisibleByNameContainsStr(System.String name, System.Boolean visible) { }
        private System.Void SetVisibleByRenderer(UnityEngine.Renderer renderer, System.Boolean visible) { }
        private System.Void AddMaterialToAllRenderer(UnityEngine.Material material, Beyond.Rendering.EntityVFXRendererMask rendererMask) { }
        private System.Void RemoveMaterialFromAllRenderer(UnityEngine.Material material, Beyond.Rendering.EntityVFXRendererMask rendererMask) { }
        private System.Void SetKeywordEnableToAllMaterial(System.String keyword, System.Boolean enable, Beyond.Rendering.EntityVFXRendererMask rendererMask) { }
        private System.Void SetFloatToAllMaterial(System.Int32 nameId, System.Single value, Beyond.Rendering.EntityVFXRendererMask rendererMask) { }
        private System.Void SetFloatToCustomPerDraw(Beyond.Rendering.EntityRenderHelperCustomPerDrawType type, System.Single value, Beyond.Rendering.EntityVFXRendererMask rendererMask) { }
        private System.Void SetTextureToAllMaterial(System.Int32 nameId, UnityEngine.Texture value, Beyond.Rendering.EntityVFXRendererMask rendererMask) { }
        private System.Void SetVectorToAllMaterial(System.Int32 nameId, UnityEngine.Vector4 value, Beyond.Rendering.EntityVFXRendererMask rendererMask) { }
        private System.Void SetFloatToFactoryMaterial(UnityEngine.Material material, System.Int32 nameId, System.Single value) { }
        private System.Void SetVectorToFactoryMaterial(UnityEngine.Material material, System.Int32 nameId, UnityEngine.Vector4 value) { }
        private System.Void SetAddictiveFloatProperty(System.Int32 propertyId, System.Single value) { }
        private System.Single GetAddictiveFloatProperty(System.Int32 propertyId, System.Single defaultValue) { }
        private System.Void SetAddictiveVectorProperty(System.Int32 propertyId, UnityEngine.Vector4 value) { }
        private UnityEngine.Vector4 GetAddictiveVectorProperty(System.Int32 propertyId, UnityEngine.Vector4 defaultValue) { }
        private System.Void SetAddictiveTextureProperty(System.Int32 propertyId, UnityEngine.Texture value) { }
        private UnityEngine.Texture GetAddictiveTextureProperty(System.Int32 propertyId, UnityEngine.Texture defaultValue) { }
        private System.Void StopShadowCasting(System.Boolean stopRayTracing) { }
        private System.Void RevertShadowCastingMode() { }
        private System.Void SetDepthOnlyEnabledToAllMaterial(System.Boolean enable, Beyond.Rendering.EntityVFXRendererMask rendererMask) { }
        private System.Boolean SetManualDitherEnable(System.Boolean enable) { }
        private System.Void SetManualDitherAlphaValue(System.Single value) { }
        private UnityEngine.Bounds GetRendererBounds() { }
        private UnityEngine.Matrix4x4 GetTransform() { }
        private System.Boolean IsFactory() { }
        private Beyond.Rendering.RenderHelperType GetRenderHelperType() { }
        private System.Void SetTimeScale(System.Single timeScale) { }
        private System.Single GetTimeScale() { }
        private System.Boolean GetMeshHasVFXVertColor() { }
        private System.Boolean CanPlay(Beyond.Rendering.SettingLodLevel settingLodLevel, Beyond.Rendering.AssetPlatformLayers platformLayer, Beyond.Rendering.EffectTargetLayers targetLayer) { }

    }

    // TypeToken: 0x2000055
    public class CommonVAT : MonoBehaviour
    {
        // Fields
        private static readonly System.Int32 S_COMMON_VAT_PLAY_PARAMS;        // 0x0
        public Beyond.Rendering.RuntimeVATData data;        // 0x18
        private System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<Beyond.Rendering.RuntimeVATAnimationClip>> m_animDic;        // 0x20
        private System.Collections.Generic.List<Beyond.Rendering.RuntimeVATAnimationClip> m_curClips;        // 0x28
        private Beyond.Rendering.VATPropertySetter m_propertySetter;        // 0x30
        private System.Int32 m_curIndex;        // 0x38
        private System.Int32 m_nextPlayTimerId;        // 0x3C
        private System.Boolean m_hasNextAnimToPlay;        // 0x40
        private System.String m_nextAnimName;        // 0x48

        // Methods
        private System.String get_PropertySetterType() { }
        private System.Void Start() { }
        private System.Void Play(System.String name, System.Boolean playWhenComplete) { }
        private System.Void _DoPlay(System.String name) { }
        private System.Void _NextPlay() { }
        private System.Void _CreateTimer(System.Single time, System.Action func, System.String funcName) { }
        private System.Void _ClearTimer() { }
        private System.Void _UpdateProperty(Beyond.Rendering.RuntimeVATAnimationClip runtimeVatAnimationClip) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000056
    public class FactoryVAT : MonoBehaviour
    {
        // Fields
        public Beyond.Rendering.RuntimeVATData data;        // 0x18
        public System.Single speed;        // 0x20
        public System.Single passTime;        // 0x24
        public System.Int32 lastFrame;        // 0x28
        public System.Int32 curFrame;        // 0x2C
        public System.Boolean preview;        // 0x30
        private UnityEngine.MaterialPropertyBlock m_materialPropertyBlock;        // 0x38
        private System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<Beyond.Rendering.RuntimeVATAnimationClip>> m_animDic;        // 0x40
        private System.Collections.Generic.List<Beyond.Rendering.RuntimeVATAnimationClip> m_curClips;        // 0x48
        private System.Int32 m_curIndex;        // 0x50
        private System.Action m_callBack;        // 0x58
        private System.Boolean m_hasNextAnimToPlay;        // 0x60
        private System.String m_nextAnimName;        // 0x68
        private System.Action m_nextAnimCallBack;        // 0x70
        private static readonly System.Int32 S_FACTORY_VAT_FRAME;        // 0x0
        private static readonly System.Int32 S_FACTORY_VAT_LAST_FRAME;        // 0x4
        private System.Collections.Generic.List<UnityEngine.Renderer> m_allRenderers;        // 0x78
        private System.Collections.Generic.List<UnityEngine.Renderer> m_dynamicRenders;        // 0x80
        private System.Collections.Generic.List<UnityEngine.Renderer> m_staticRenders;        // 0x88

        // Methods
        private System.Void Start() { }
        private System.Void Reset() { }
        private System.Void _UpdateAnim() { }
        private System.Void OnUpdate() { }
        private System.Void Play(System.String name, System.Action callBack, System.Boolean whenComplete) { }
        private System.Void _DoPlay(System.String name, System.Action callBack) { }
        private System.Void _InitRenderer() { }
        private System.Void _InitRenderer_MeshRender(UnityEngine.LODGroup lodGroup) { }
        private System.Void _SetParamsToRenderer() { }
        private System.Void _SetParamsToRenderer_MeshRender() { }
        private System.Void _ReSetParamsToRenderer() { }
        private System.Void _ReSetParamsToRenderer_MeshRender() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000057
    public class RuntimeVATAnimationClip
    {
        // Fields
        public System.String stateName;        // 0x10
        public System.String name;        // 0x18
        public System.Boolean loop;        // 0x20
        public System.Int32 startFrame;        // 0x24
        public System.Int32 endFrame;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000058
    public class RuntimeVATData
    {
        // Fields
        public UnityEngine.Texture vatMap;        // 0x10
        public System.Boolean fullRigidBody;        // 0x18
        public System.Collections.Generic.List<UnityEngine.Matrix4x4> bonePoses;        // 0x20
        public System.Single frameRate;        // 0x28
        public System.Collections.Generic.List<Beyond.Rendering.RuntimeVATAnimationClip> animationClips;        // 0x30

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000059
    public class VATPropertySetter
    {
        // Methods
        private System.Void Init(UnityEngine.GameObject gameObject) { }
        private System.Void SetFloat(System.Int32 id, System.Single value) { }
        private System.Void SetVector(System.Int32 id, UnityEngine.Vector4 value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005A
    public class VATRendererPropertySetter : VATPropertySetter
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.Renderer> m_allRenderers;        // 0x10
        private System.Collections.Generic.List<UnityEngine.Material> m_allMaterials;        // 0x18

        // Methods
        private System.Void Init(UnityEngine.GameObject gameObject) { }
        private System.Void SetFloat(System.Int32 id, System.Single value) { }
        private System.Void SetVector(System.Int32 id, UnityEngine.Vector4 value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005B
    public class VATEntityRendererHelperPropertySetter : VATPropertySetter
    {
        // Fields
        private Beyond.Rendering.IRendererHelper m_rendererHelper;        // 0x10

        // Methods
        private System.Void .ctor(Beyond.Rendering.IRendererHelper rendererHelper) { }
        private System.Void Init(UnityEngine.GameObject gameObject) { }
        private System.Void SetFloat(System.Int32 id, System.Single value) { }
        private System.Void SetVector(System.Int32 id, UnityEngine.Vector4 value) { }

    }

    // TypeToken: 0x200005C
    public class PsoCreateUploadHelper
    {
        // Fields
        protected static System.Int32 PSO_UPLOAD_INFO_VERSION;        // 0x0
        protected static System.Int32 MAX_UPLOAD_COUNT_PER_LOOP;        // 0x0
        protected static Beyond.Rendering.PsoCreateUploadHelper s_instance;        // 0x0
        public static System.Int32 s_enabled;        // 0x8
        public static System.Boolean s_skipUploadFile;        // 0xC
        public static System.Boolean s_isShaderWarming;        // 0xD
        private static System.String s_persistentDataPath;        // 0x10
        private static System.Collections.Concurrent.ConcurrentQueue<System.ValueTuple<System.String,System.Single,System.Int32,System.Boolean,System.String>> s_concurrentQueue;        // 0x18
        private System.Int32 m_timerId;        // 0x10
        private static System.String URL;        // 0x0
        private static System.String TOKEN;        // 0x0
        private static System.Threading.SynchronizationContext s_mainSyncContext;        // 0x20
        private static System.Int32 s_mainThreadId;        // 0x28

        // Methods
        private Beyond.Rendering.PsoCreateUploadHelper get_instance() { }
        private System.Void .cctor() { }
        private System.String get_persistentDataPath() { }
        private System.Void Initialize() { }
        private System.Void Init() { }
        private System.Void Dispose() { }
        private System.Boolean IsPsoRecordEnabled() { }
        private System.Void BeforeWarmUpBegin() { }
        private System.Void AfterWarmUpFinish() { }
        private System.Void _Tick() { }
        private System.Void _PsoUploadProcessOneCallBack(System.String infoJson, UnityEngine.HGPsoExtInfo info) { }
        private System.String _PsoUpdateGameInfoCallBack() { }
        private System.Void _UploadPipelineCreatedInfo() { }
        private System.Void _HandleMessage() { }
        private System.Void _UploadFile(System.String urlPath, System.String rawFilePath, System.String serverFileNameOverride, System.Action<System.Boolean,System.String,System.String> callback) { }
        private System.Void _UploadFileToServer(System.String urlPath, System.String rawFilePath, System.String serverFileNameOverride, System.Action<System.Boolean,System.String,System.String> callback) { }
        private System.Void _Callback(System.Boolean success, System.String msg, System.String url) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000063
    public class VFXSludgeBaker
    {
        // Fields
        public UnityEngine.Splines.SplineContainer splineContainer;        // 0x10
        public UnityEngine.Transform rootTransform;        // 0x18
        public System.Single thickness;        // 0x20
        public System.Single density;        // 0x24
        public System.Single maxHeight;        // 0x28
        public System.Single blurIntensity;        // 0x2C
        public System.Single gridHeightOffset;        // 0x30
        public System.Single topLimit;        // 0x34
        public System.Single bottomLimit;        // 0x38
        public UnityEngine.Texture2D bakedTexture1;        // 0x40
        public UnityEngine.Bounds localBounds;        // 0x48
        public System.Single maxHighPowerZoneSignedDistance;        // 0x60
        public System.Single maxEdgeToHighPowerZoneSignedDistance;        // 0x64
        private System.Collections.Generic.List<UnityEngine.Vector3> m_localPolygon;        // 0x68
        private System.Int32 m_xCount;        // 0x70
        private System.Int32 m_zCount;        // 0x74
        private System.Single[,] m_raycastHeights;        // 0x78
        private System.Single[,] m_topHeights;        // 0x80
        private UnityEngine.Vector3[,] m_normals;        // 0x88
        private System.Single[,] m_edgeSignedDistance;        // 0x90
        private System.Single[,] m_highPowerZoneSignedDistance;        // 0x98
        private System.Boolean[,] m_inPolygon;        // 0xA0
        private System.Boolean[,] m_inHighPowerZone;        // 0xA8
        private static System.Single EXTEND_SIZE;        // 0x0
        public System.Single rayCastPosY;        // 0xB0

        // Methods
        private System.Void .ctor(UnityEngine.Splines.SplineContainer splineContainer, UnityEngine.Transform target, System.Single density, System.Single thickness, System.Single maxHeight, System.Single blurIntensity, System.Single gridHeightOffset) { }
        private System.Void Bake() { }
        private System.Void _CalculatePolygonAndBounds() { }
        private UnityEngine.Vector2Int GetLocalIndex(UnityEngine.Vector3 localPosition) { }
        private UnityEngine.Vector3 GetLocalPosition(UnityEngine.Vector2Int index) { }
        private System.Void _RaycastSceneObjectsHeight() { }
        private System.Void _CalculateInPolygon() { }
        private System.Void _CalculateInHighPowerZone() { }
        private System.Single[] _CreateGaussianKernel(System.Int32 size, System.Single sigma) { }
        private System.Single[,] _Convolution(System.Single[,] src, System.Single[] kernel, UnityEngine.Vector2Int offsetDir) { }
        private System.Void _BlurTopHeight() { }
        private System.Void _CalculateThicknessAndTopHeight() { }
        private System.Void _CalculateNormals() { }
        private System.Void _ForAround(System.Int32 ix, System.Int32 iz, System.Int32 xCount, System.Int32 zCount, System.Action<System.Int32,System.Int32> callback) { }
        private System.Int32 _GetHash(System.Int32 ix, System.Int32 iz) { }
        private System.Int32 _GetHash(System.Int32 ix, System.Int32 iz, System.Int32 xCount) { }
        private System.Void _CalculateEdgeSignedDistance(System.Single[,] sdf) { }
        private System.Void _CalculateEdgeSignedDistance() { }
        private UnityEngine.Color _GetTextureColor1(System.Int32 ix, System.Int32 iz) { }
        private UnityEngine.Color _GetTextureColor2(System.Int32 ix, System.Int32 iz) { }
        private System.Void _CreateTexture() { }

    }

    // TypeToken: 0x2000066
    public class VFXSludgeNavUtils
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000070
    public class VFXSludgeUtils
    {
        // Methods
        private System.Collections.Generic.List<UnityEngine.Vector3> GetPolygonOffSpline(UnityEngine.Splines.SplineContainer splineContainer, System.Single splitDistance, System.Int32 splineIndex) { }
        private System.Void GetPolygonOffSplineWithSimplify(UnityEngine.Splines.SplineContainer container, System.Collections.Generic.List<UnityEngine.Vector2>& points, System.Int32 splineIndex, System.Boolean closed, System.Boolean isDebug) { }
        private System.Collections.Generic.List<UnityEngine.Vector3> GetPolygonOffByPolyLine(System.Collections.Generic.List<UnityEngine.Vector2> polylinePoints, UnityEngine.Transform transform, System.Single splitDistance) { }
        private System.Collections.Generic.List<UnityEngine.Vector3> CalculatePointPolygonHorizonRayCross(System.Collections.Generic.List<UnityEngine.Vector3> polygon, UnityEngine.Vector3 point) { }

    }

    // TypeToken: 0x2000071
    public class HGTerrain : MonoBehaviour
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000072
    public class ToggleFunc : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(Beyond.Rendering.HGTerrainHelper terrainHelper) { }
        private System.IAsyncResult BeginInvoke(Beyond.Rendering.HGTerrainHelper terrainHelper, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000073
    public class HGTerrainHelper : MonoBehaviour
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace Beyond.Rendering.LODLightmapping
{

    // TypeToken: 0x2000075
    public class LightmapInfoTransfer : MonoBehaviour
    {
        // Fields
        private UnityEngine.MeshRenderer _lightmappedRenderer;        // 0x18
        private UnityEngine.MeshRenderer m_currentRenderer;        // 0x20

        // Methods
        private System.Void OnEnable() { }
        private System.Void Awake() { }
        private System.Void _RendererInfoTransfer() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000076
    public struct LodLightmappingMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Rendering.LODLightmapping.LodLightmappingMode AllFromLightProbe;        // 0x0
        public static Beyond.Rendering.LODLightmapping.LodLightmappingMode AllFromLOD0;        // 0x0
        public static Beyond.Rendering.LODLightmapping.LodLightmappingMode UseDifferentLightmapAreaForLODs;        // 0x0

    }

    // TypeToken: 0x2000077
    public class LODLightmapping : MonoBehaviour
    {
        // Fields
        public Beyond.Rendering.LODLightmapping.LodLightmappingMode mode;        // 0x18
        public UnityEngine.Vector4 lightmapScaleOffset;        // 0x1C
        public System.Int32 lightmapIndex;        // 0x2C

        // Methods
        private System.Void RendererInfoTransfer() { }
        private System.Void .ctor() { }

    }

}

namespace Beyond.Rendering.SplineMovingObjects
{

    // TypeToken: 0x2000074
    public class HGSplineMovingObjects : MonoBehaviour, IVFXPlayable
    {
        // Fields
        private UnityEngine.HyperGryph.SplineObjectsDesc desc;        // 0x18
        private UnityEngine.HyperGryph.SplineObjectsKnotData[] knotData;        // 0x258
        private System.Boolean fixedPostion;        // 0x260
        private System.Boolean optimizeCurve;        // 0x261
        private System.UInt32 m_instanceHandle;        // 0x264
        private Unity.Collections.NativeArray<UnityEngine.HyperGryph.SplineObjectsKnotData> m_stonesKnotDataNativeArray;        // 0x268

        // Methods
        private System.Void _CreateInstance() { }
        private System.Void _ExtractSplineData() { }
        private System.Void _DestroyInstance() { }
        private System.Void _Release() { }
        private System.Void Update() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void OnDrawGizmosSelected() { }
        private System.Void Pause() { }
        private System.Void Play() { }
        private System.Void Stop() { }
        private System.Void .ctor() { }

    }

}

namespace Beyond.SourceGenerator
{

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
    public class ECSComponentAttribute : Attribute
    {
        // Fields
        public System.Runtime.InteropServices.LayoutKind layoutKind;        // 0x10
        public System.Boolean isTag;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000008
    public class CameraControlConfigAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000009
    public class AnimatorBlackboardAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace HG.Rendering.Runtime
{

    // TypeToken: 0x2000003
    public class ContainerWaterManager : MonoBehaviour
    {
        // Fields
        private static readonly System.Int32 DISPLACEMENT_TEX;        // 0x0
        private static readonly System.Int32 DISPLACEMENT_TEX_ST;        // 0x4
        private static readonly System.Int32 WATER_MENISCUS_WIDTH;        // 0x8
        private static readonly System.Int32 ICE_POSITION;        // 0xC
        public UnityEngine.Material waveMaterial;        // 0x18
        public UnityEngine.Texture2D waveTexture;        // 0x20
        public UnityEngine.Transform iceBall;        // 0x28
        public UnityEngine.Renderer liquidRenderer;        // 0x30
        private System.Single[][] m_waveN;        // 0x38
        private System.Single[][] m_waveNm1;        // 0x40
        private System.Single[][] m_waveNp1;        // 0x48
        private readonly System.Single m_cylinderRadius;        // 0x50
        private System.Single _dx;        // 0x54
        private System.Int32 m_nx;        // 0x58
        private System.Int32 m_ny;        // 0x5C
        public System.Single CFL;        // 0x60
        public System.Single c;        // 0x64
        private System.Single m_dt;        // 0x68
        private System.Single m_t;        // 0x6C
        public System.Boolean reflectiveBoundary;        // 0x70
        private System.Single _waveMultiplier;        // 0x74
        private System.Single _pulseFrequency;        // 0x78
        private System.Single _pulseMagnitude;        // 0x7C
        private System.Single _elasticity;        // 0x80
        private System.Single _viscosity;        // 0x84
        private System.Single _surfaceTension;        // 0x88
        private System.Boolean _adaptiveQuality;        // 0x8C
        private System.Single _targetFrameTime;        // 0x90
        private System.Single m_lastFrameTime;        // 0x94
        private UnityEngine.UI.RawImage _debugDisplay;        // 0x98
        private System.Int32 _updateFrequency;        // 0xA0
        private System.Int32 m_frameCounter;        // 0xA4
        private System.Single m_currentYRotationSpeed;        // 0xA8
        private System.Boolean m_needsTextureUpdate;        // 0xAC
        private UnityEngine.Vector3 m_lastIceBallPosition;        // 0xB0
        private UnityEngine.Quaternion m_lastIceBallRotation;        // 0xBC
        private readonly System.Single m_iceBallRadius;        // 0xCC
        private System.Single _rippleUpdateInterval;        // 0xD0
        private System.Single _rippleBaseStrength;        // 0xD4
        private System.Single _rippleRadius;        // 0xD8
        private System.Single _rippleWaveLength;        // 0xDC
        private System.Single _rippleSpeed;        // 0xE0
        private System.Single _distanceDecayPower;        // 0xE4
        private System.Single _meltingUniformity;        // 0xE8
        private System.Single _meltingVariation;        // 0xEC
        private System.Single m_lastRippleUpdateTime;        // 0xF0
        private System.Single m_ripplePhase;        // 0xF4
        private System.Single _rotationWaveMultiplier;        // 0xF8
        private System.Single _rotationSensitivity;        // 0xFC
        private System.Boolean[,] m_cylinderMask;        // 0x100
        private System.Collections.Generic.List<UnityEngine.Vector2Int> m_activePoints;        // 0x108
        private UnityEngine.Color32[] m_cachedPixels;        // 0x110
        private System.Single _normalMeniscusWidth;        // 0x118
        private System.Single _vortexDetectionThreshold;        // 0x11C
        private System.Single _vortexTransitionTime;        // 0x120
        private System.Boolean m_isVortexActive;        // 0x124
        private System.Single m_vortexTransitionProgress;        // 0x128
        private System.Single m_lastVortexCheckTime;        // 0x12C
        private System.Single m_lastYAxisStopTime;        // 0x130
        private System.Boolean m_wasYAxisRotating;        // 0x134
        private readonly System.Single m_yAxisStopDelay;        // 0x138
        private static System.Single VORTEX_CHECK_INTERVAL;        // 0x0
        private System.Single _movementDistanceThreshold;        // 0x13C
        private System.Single _movementRecoveryDelay;        // 0x140
        private System.Boolean m_isMovementActive;        // 0x144
        private System.Single m_lastMovementStopTime;        // 0x148
        private System.Boolean m_wasMoving;        // 0x14C
        private System.Single m_currentMeniscusWidth;        // 0x150
        private System.Boolean m_isMeniscusTransitioning;        // 0x154
        private System.Single m_meniscusTransitionStartTime;        // 0x158
        private System.Single m_meniscusTransitionStartValue;        // 0x15C
        private UnityEngine.Vector2Int m_tempTexturePos;        // 0x160
        private UnityEngine.Vector2Int m_tempNearestPoint;        // 0x168

        // Methods
        private System.Single get_dy() { }
        private System.Void Start() { }
        private System.Void _InitializeWaveSystem() { }
        private System.Void _PrecomputeCylinderMask() { }
        private System.Void _UnifiedWaveStep(System.Boolean isEditorUpdate) { }
        private System.Boolean _WorldToTextureCoords(UnityEngine.Vector3 worldPos, UnityEngine.Vector2Int& texturePos) { }
        private System.Boolean _IsInsideCylinder(System.Int32 i, System.Int32 j) { }
        private System.Boolean _IsValidPosition(System.Int32 x, System.Int32 y) { }
        private System.Void _ApplyMatrixToTexture(System.Single[][] state, UnityEngine.Texture2D& tex, System.Single waveMultiplier) { }
        private System.Void _ApplyReflectiveBoundary() { }
        private System.Void _ApplyAbsorptiveBoundary() { }
        private UnityEngine.Vector2Int _FindNearestInsidePoint(System.Int32 x, System.Int32 y) { }
        private System.Void _UpdateVortexState(System.Boolean isEditorUpdate) { }
        private System.Void ResetWaveTexture() { }
        private System.Void Update() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000004
    public class VFXLockTransform : MonoBehaviour
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000005
    public class HGConstantBufferLayoutAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace IFix
{

    // TypeToken: 0x200007A
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10
        private System.Int32 methodId;        // 0x18
        private System.Object anonObj;        // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;        // 0x0

        // Methods
        private System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        private System.Void __Gen_Wrap_0(System.Object P0) { }
        private System.Boolean __Gen_Wrap_1(System.Object P0, System.Int32 P1, System.Int32 P2) { }
        private UnityEngine.Vector2Int __Gen_Wrap_2(System.Object P0, System.Int32 P1, System.Int32 P2) { }
        private System.Boolean __Gen_Wrap_3(System.Object P0, UnityEngine.Vector3 P1, UnityEngine.Vector2Int& P2) { }
        private System.Void __Gen_Wrap_4(System.Object P0, System.Boolean P1) { }
        private System.Void __Gen_Wrap_5(System.Object P0, System.Object P1, UnityEngine.Texture2D& P2, System.Single P3) { }
        private System.Void __Gen_Wrap_6(System.Object P0, System.Single P1) { }
        private System.Void __Gen_Wrap_7(System.Object P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_8(System.Object P0, UnityEngine.Vector4 P1, UnityEngine.Vector4 P2) { }
        private System.Void __Gen_Wrap_9(System.Object P0, UnityEngine.Vector4 P1) { }
        private System.Void __Gen_Wrap_10(System.Object P0, System.Single P1, System.Single P2) { }
        private System.String __Gen_Wrap_11(System.Object P0) { }
        private System.Void __Gen_Wrap_12() { }
        private System.String __Gen_Wrap_13(Beyond.Resource.RootCategory P0) { }
        private System.String __Gen_Wrap_14(Beyond.Resource.RootCategory P0, System.Boolean P1) { }
        private System.String __Gen_Wrap_15() { }
        private System.String __Gen_Wrap_16(UnityEngine.RuntimePlatform P0, UnityEngine.Rendering.GraphicsDeviceType P1, System.Int32 P2, System.Object P3) { }
        private System.String __Gen_Wrap_17(UnityEngine.RuntimePlatform P0, UnityEngine.Rendering.GraphicsDeviceType P1, System.Int32 P2, System.Object P3, System.Object P4) { }
        private System.Boolean __Gen_Wrap_18(System.Object P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4, System.Object P5) { }
        private System.Boolean __Gen_Wrap_19(System.Object P0, System.String& P1) { }
        private System.Void __Gen_Wrap_20(Beyond.Rendering.ShaderWarmupManager.WarmUpReason P0) { }
        private System.Boolean __Gen_Wrap_21() { }
        private System.Void __Gen_Wrap_22(System.Int32 P0) { }
        private System.Collections.IEnumerator __Gen_Wrap_23(System.Object P0, System.Object P1, System.Object P2) { }
        private System.Int32 __Gen_Wrap_24(System.Object P0) { }
        private System.Int32 __Gen_Wrap_25() { }
        private System.Void __Gen_Wrap_26(System.Int32 P0, System.Int32& P1) { }
        private System.Collections.IEnumerator __Gen_Wrap_27(System.Object P0, System.Int32 P1, System.Int32 P2, System.Single P3, System.Int32 P4) { }
        private System.Collections.IEnumerator __Gen_Wrap_28(System.Boolean P0) { }
        private System.Collections.IEnumerator __Gen_Wrap_29(System.Object P0, System.Int32 P1, System.Int32 P2) { }
        private System.Collections.IEnumerator __Gen_Wrap_30(System.Object P0) { }
        private System.Single __Gen_Wrap_31(System.Object P0) { }
        private System.Boolean __Gen_Wrap_32(System.Object P0, System.Boolean P1) { }
        private System.Boolean __Gen_Wrap_33(System.Object P0) { }
        private System.Boolean __Gen_Wrap_34(System.Object P0, System.Single P1, System.Int32 P2) { }
        private System.Collections.Generic.Dictionary<System.Int32,System.Single> __Gen_Wrap_35(System.Object P0) { }
        private System.Void __Gen_Wrap_36(System.Object P0, System.Object P1) { }
        private Beyond.Rendering.EntityRenderCapturedEntity __Gen_Wrap_37(System.Object P0, System.Object P1) { }
        private System.Int32 __Gen_Wrap_38(System.Object P0, System.Object P1) { }
        private Beyond.Rendering.EntityVFXRendererMask __Gen_Wrap_39(Beyond.Rendering.EntityVFXRendererType P0) { }
        private System.Void __Gen_Wrap_40(System.Object P0, System.Object P1, System.Object P2) { }
        private System.Void __Gen_Wrap_41(System.Object P0, System.Object P1, Beyond.Rendering.EntityVFXRendererMask P2) { }
        private System.Collections.Generic.List<Beyond.Rendering.EntityRenderHelperMaterialController.RendererInfo> __Gen_Wrap_42(System.Object P0, Beyond.Rendering.EntityVFXRendererMask P1, System.Boolean P2) { }
        private System.Void __Gen_Wrap_43(System.Object P0, System.Int32 P1, System.Single P2) { }
        private System.Single __Gen_Wrap_44(System.Object P0, System.Int32 P1, System.Single P2) { }
        private System.Void __Gen_Wrap_45(System.Object P0, System.Int32 P1, UnityEngine.Vector4 P2) { }
        private UnityEngine.Vector4 __Gen_Wrap_46(System.Object P0, System.Int32 P1, UnityEngine.Vector4 P2) { }
        private System.Void __Gen_Wrap_47(System.Object P0, System.Int32 P1, System.Object P2) { }
        private UnityEngine.Texture __Gen_Wrap_48(System.Object P0, System.Int32 P1, System.Object P2) { }
        private System.Void __Gen_Wrap_49(System.Object P0, System.Int32 P1, Beyond.Rendering.EntityVFXRendererMask P2) { }
        private System.Void __Gen_Wrap_50(System.Object P0, Beyond.Rendering.EntityVFXRendererMask P1, System.Object P2) { }
        private System.Void __Gen_Wrap_51(System.Object P0, System.Object P1, System.Boolean P2, Beyond.Rendering.EntityVFXRendererMask P3) { }
        private System.Void __Gen_Wrap_52(System.Object P0, System.Boolean P1, Beyond.Rendering.EntityVFXRendererMask P2) { }
        private System.Void __Gen_Wrap_53(System.Object P0, Beyond.Rendering.EntityRenderHelperCustomPerDrawType P1, System.Single P2, Beyond.Rendering.EntityVFXRendererMask P3) { }
        private System.Void __Gen_Wrap_54(System.Object P0, Beyond.Rendering.EntityRenderHelperVectorCustomPerDrawType P1, UnityEngine.Vector4 P2, Beyond.Rendering.EntityVFXRendererMask P3) { }
        private System.Void __Gen_Wrap_55(System.Object P0, System.Int32 P1, System.Single P2, Beyond.Rendering.EntityVFXRendererMask P3) { }
        private System.Void __Gen_Wrap_56(System.Object P0, System.Int32 P1, UnityEngine.Vector4 P2, Beyond.Rendering.EntityVFXRendererMask P3) { }
        private System.Void __Gen_Wrap_57(System.Object P0, System.Int32 P1, System.Object P2, Beyond.Rendering.EntityVFXRendererMask P3) { }
        private UnityEngine.Bounds __Gen_Wrap_58(System.Object P0) { }
        private System.Void __Gen_Wrap_59(System.Object P0, System.Object P1, System.Boolean P2) { }
        private Beyond.Rendering.RenderHelperType __Gen_Wrap_60(System.Object P0) { }
        private System.Collections.Generic.List<Beyond.Rendering.EntityRendererTypeConfig> __Gen_Wrap_61(System.Object P0, System.Boolean P1) { }
        private System.Single __Gen_Wrap_62(System.Object P0, System.Boolean P1) { }
        private Beyond.Rendering.EntityVFXPriorityType __Gen_Wrap_63(System.Object P0) { }
        private System.Void __Gen_Wrap_64(System.Object P0, System.Single P1, System.Boolean P2) { }
        private UnityEngine.Material __Gen_Wrap_65(System.Object P0, System.Object P1, System.Object P2) { }
        private System.Boolean __Gen_Wrap_66(Beyond.Rendering.EntityVFXFactoryAddedMaterialManager.AddedMaterialData P0) { }
        private System.Int32 __Gen_Wrap_67(System.Object P0, System.Object P1, System.Object P2) { }
        private System.Void __Gen_Wrap_68(System.Object P0, System.Object P1, System.Int32 P2, System.Single P3) { }
        private System.Void __Gen_Wrap_69(System.Object P0, System.Object P1, System.Int32 P2, UnityEngine.Vector4 P3) { }
        private UnityEngine.Material __Gen_Wrap_70(System.Object P0, System.Object P1, UnityEngine.Vector4 P2) { }
        private System.ValueTuple<System.Single,System.Single> __Gen_Wrap_71(UnityEngine.Bounds P0, UnityEngine.Vector3 P1) { }
        private System.Void __Gen_Wrap_72(System.Object P0, System.Boolean P1, UnityEngine.Vector3 P2, System.Boolean P3, System.Single P4, System.Single& P5, System.Single& P6, UnityEngine.Vector3& P7) { }
        private Beyond.Rendering.EntityVFXCurveEvaluateResult __Gen_Wrap_73(System.Object P0, System.Single P1) { }
        private System.Void __Gen_Wrap_74(System.Object P0, System.Object P1, System.Single P2) { }
        private System.Void __Gen_Wrap_75(System.Object P0, System.Single P1, System.Object P2, System.Object P3) { }
        private System.Void __Gen_Wrap_76(System.Object P0, System.Object P1, System.Object P2, System.Boolean P3) { }
        private System.Void __Gen_Wrap_77(System.Object P0, UnityEngine.HGPsoExtInfo P1) { }
        private System.Void __Gen_Wrap_78(System.Boolean P0, System.Object P1, System.Object P2) { }
        private System.Void __Gen_Wrap_79(System.Object P0, System.Object P1, System.Object P2, System.Object P3) { }
        private System.Collections.Generic.List<UnityEngine.Vector3> __Gen_Wrap_80(System.Object P0, System.Single P1, System.Int32 P2) { }
        private UnityEngine.Vector3 __Gen_Wrap_81(System.Object P0, UnityEngine.Vector2Int P1) { }
        private System.Collections.Generic.List<UnityEngine.Vector3> __Gen_Wrap_82(System.Object P0, UnityEngine.Vector3 P1) { }
        private UnityEngine.Vector2Int __Gen_Wrap_83(System.Object P0, UnityEngine.Vector3 P1) { }
        private System.Int32 __Gen_Wrap_84(System.Int32 P0, System.Int32 P1, System.Int32 P2) { }
        private System.Void __Gen_Wrap_85(System.Int32 P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_86(System.Int32 P0, System.Int32 P1, System.Int32 P2, System.Int32 P3, System.Object P4) { }
        private UnityEngine.Color __Gen_Wrap_87(System.Object P0, System.Int32 P1, System.Int32 P2) { }
        private System.Single[] __Gen_Wrap_88(System.Int32 P0, System.Single P1) { }
        private System.Single[,] __Gen_Wrap_89(System.Object P0, System.Object P1, UnityEngine.Vector2Int P2) { }
        private System.Int32 __Gen_Wrap_90(System.Object P0, System.Int32 P1, System.Int32 P2) { }
        private System.Void __Gen_Wrap_91(UnityEngine.Bounds P0, System.Object P1, UnityEngine.Vector3& P2, UnityEngine.Vector3& P3, System.Nullable<UnityEngine.Vector3> P4) { }
        private Beyond.Rendering.VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame __Gen_Wrap_92(UnityEngine.Vector3 P0, UnityEngine.Vector3 P1) { }
        private Beyond.Rendering.VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame __Gen_Wrap_93(UnityEngine.Vector3 P0, System.Single P1) { }
        private System.Collections.Generic.List<UnityEngine.Vector3> __Gen_Wrap_94(System.Object P0, System.Single P1, System.Int32 P2, System.Boolean P3, System.Single P4) { }
        private UnityEngine.Vector3 __Gen_Wrap_95(Beyond.Rendering.VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame& P0, UnityEngine.Vector3 P1) { }
        private System.Void __Gen_Wrap_96(System.Object P0, Beyond.Rendering.VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame P1, System.Collections.Generic.List<UnityEngine.Vector2>& P2, System.Collections.Generic.List<System.Single>& P3, System.Single& P4, System.Single& P5, System.Single& P6, System.Single& P7) { }
        private System.Int32 __Gen_Wrap_97(System.Int32 P0, System.Int32 P1) { }
        private System.Collections.Generic.List<System.Int32> __Gen_Wrap_98(System.Object P0) { }
        private System.Single __Gen_Wrap_99(System.Object P0, System.Int32 P1, System.Boolean P2) { }
        private System.Single __Gen_Wrap_100(UnityEngine.Vector2 P0, UnityEngine.Vector2 P1, UnityEngine.Vector2 P2) { }
        private System.Collections.Generic.List<System.Int32> __Gen_Wrap_101(System.Object P0, System.Boolean P1, System.Single P2, System.Single P3, System.Single P4) { }
        private Beyond.Rendering.VFXSludgeNavUtils.Spline2DProjectAndSimplify.ProcessResult __Gen_Wrap_102(System.Object P0, Beyond.Rendering.VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame P1, System.Single P2, System.Int32 P3, System.Boolean P4, Beyond.Rendering.VFXSludgeNavUtils.Spline2DProjectAndSimplify.EdgeMode P5, System.Single P6, System.Single P7, System.Single P8) { }
        private System.Collections.Generic.List<UnityEngine.Vector2> __Gen_Wrap_103(System.Object P0, System.Single P1, System.Int32 P2, System.Int32 P3, System.Boolean P4, System.Boolean P5) { }
        private System.Collections.Generic.List<UnityEngine.Vector3> __Gen_Wrap_104(System.Object P0, System.Single P1, System.Single P2, System.Boolean P3) { }
        private System.Void __Gen_Wrap_105(System.Object P0, System.Collections.Generic.List<UnityEngine.Vector2>& P1, System.Int32 P2, System.Boolean P3, System.Boolean P4) { }
        private System.Collections.Generic.List<UnityEngine.Vector3> __Gen_Wrap_106(System.Object P0, System.Object P1, System.Single P2) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200007B
    public class ILFixInterfaceBridge : AnonymousStorey, IDisposable, IEnumerator, IEnumerator`1, IAsyncStateMachine
    {
        // Fields
        private System.Int32 methodId_0;        // 0x40
        private System.Int32 methodId_1;        // 0x44
        private System.Int32 methodId_2;        // 0x48
        private System.Int32 methodId_3;        // 0x4C
        private System.Int32 methodId_4;        // 0x50
        private System.Int32 methodId_5;        // 0x54
        private System.Int32 methodId_6;        // 0x58

        // Methods
        private System.Void System.IDisposable.Dispose() { }
        private System.Boolean MoveNext() { }
        private System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
        private System.Void System.Collections.IEnumerator.Reset() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void MoveNext() { }
        private System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine P0) { }
        private System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        private System.Void RefAwaitUnsafeOnCompleteMethod() { }
        private System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x200007C
    public class WrappersManagerImpl, WrappersManager
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10

        // Methods
        private System.Void .ctor(IFix.Core.VirtualMachine virtualMachine) { }
        private IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        private System.Boolean IsPatched(System.Int32 id) { }
        private System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon) { }
        private System.Object CreateWrapper(System.Int32 id) { }
        private System.Object InitWrapperArray(System.Int32 len) { }
        private IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine) { }

    }

    // TypeToken: 0x200007D
    public struct IDMAP0
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static IFix.IDMAP0 HG-Rendering-Runtime-ContainerWaterManager-_PrecomputeCylinderMask0;        // 0x0
        public static IFix.IDMAP0 HG-Rendering-Runtime-ContainerWaterManager-_InitializeWaveSystem0;        // 0x0
        public static IFix.IDMAP0 HG-Rendering-Runtime-ContainerWaterManager-Start0;        // 0x0
        public static IFix.IDMAP0 HG-Rendering-Runtime-ContainerWaterManager-_IsInsideCylinder0;        // 0x0
        public static IFix.IDMAP0 HG-Rendering-Runtime-ContainerWaterManager-_ApplyReflectiveBoundary0;        // 0x0
        public static IFix.IDMAP0 HG-Rendering-Runtime-ContainerWaterManager-_FindNearestInsidePoint0;        // 0x0
        public static IFix.IDMAP0 HG-Rendering-Runtime-ContainerWaterManager-_ApplyAbsorptiveBoundary0;        // 0x0
        public static IFix.IDMAP0 HG-Rendering-Runtime-ContainerWaterManager-_WorldToTextureCoords0;        // 0x0
        public static IFix.IDMAP0 HG-Rendering-Runtime-ContainerWaterManager-_IsValidPosition0;        // 0x0
        public static IFix.IDMAP0 HG-Rendering-Runtime-ContainerWaterManager-_UnifiedWaveStep0;        // 0x0
        public static IFix.IDMAP0 HG-Rendering-Runtime-ContainerWaterManager-_ApplyMatrixToTexture0;        // 0x0
        public static IFix.IDMAP0 HG-Rendering-Runtime-ContainerWaterManager-_UpdateVortexState0;        // 0x0
        public static IFix.IDMAP0 HG-Rendering-Runtime-ContainerWaterManager-ResetWaveTexture0;        // 0x0
        public static IFix.IDMAP0 HG-Rendering-Runtime-ContainerWaterManager-Update0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_LitDissolve0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_HoudiniVAT0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_MovingBamboo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_EmissiveColor0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_EmissiveAlbedoColor0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_SweepLightIntensity0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_UVAnimation0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_CharacterParams0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_VFXAlpha00;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_LeafBlossom0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-PipelineSettingHelper-_GetFullSettingPath0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-PipelineSettingHelper-_LoadSetting0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-PipelineSettingHelper-LoadPipelineSettings0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ResourceRouter-_GetCategoryFolder0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ResourceRouter-GetEnvironmentsFullPath0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ResourceRouter-GetDecalResourcesPath0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ResourceRouter-GetDecalResourcesFullPath0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ShaderWarmupManager-GetPsoName0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ShaderWarmupManager-GetPsoName1;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ShaderWarmupManager-GetPsoPath0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ShaderWarmupManager-GetLoginWarmupDetail0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ShaderWarmupManagerRemoteCfg-_CheckDeviceMatch0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ShaderWarmupManagerRemoteCfg-IsDeviceInBlackList0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ShaderWarmupManager-ProcessRemoteConfig0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ShaderWarmupManager-MarkNeedShaderWarmUp0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ShaderWarmupManager-_MarkWarmupFinishAPI0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ShaderWarmupManager-_MarkWarmUpLoginFinish0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ShaderWarmupManager-MarkWarmUpLoginFinish0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ShaderWarmupManager-CleanLoadedPso0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ShaderWarmupManager-_ResetWarmUpStats0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ShaderWarmupManager-_IsDeviceSupportWarmUp0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ShaderWarmupManager-_CheckNeedWarmUpByFirstEntry0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ShaderWarmupManager-_IsNeedWarmupByGraphicsChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ShaderWarmupManager-_SetWarmupRetryCount0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ShaderWarmupManager-_SetWarmupUnfinishedCount0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ShaderWarmupManager-_CheckWarmUpUnfinishedOften0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ShaderWarmupManager-_IsNeedWarmupByCacheOutdated0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ShaderWarmupManager-_CheckNeedWarmUpByDeviceState0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ShaderWarmupManager-CheckNeedWarmUpLogin0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ShaderWarmupManager-_LoadPsoAssets0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ShaderWarmupManager-_GetCompileStageCount0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ShaderWarmupManager-_GetLoginTimeLimit0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-PsoCreateUploadHelper-IsPsoRecordEnabled0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-PsoCreateUploadHelper-BeforeWarmUpBegin0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ShaderWarmupManager-_StepProgress0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-PsoCreateUploadHelper-AfterWarmUpFinish0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ShaderWarmupManager-_WarmupOnePsoTimeLimited0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ShaderWarmupManager-WarmupShadersLogin0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ShaderWarmupManager-WarmupOnePso0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-ShaderWarmupManager-WarmupShadersScene0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderAlphaDitherController-_GetCurMinAlpha0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderAlphaDitherController-_SetMaterialDitherEnabled0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderAlphaDitherController-_SetMaterialDitherAlpha0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderAlphaDitherController-_ApplyNewAlpha0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderAlphaDitherController-ResetDitherAlpha0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderAlphaDitherController-SetDitherAlpha0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderAlphaDitherController-GetDitherAlpha0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderAlphaDitherController-Reset0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderAlphaDitherController-GetAlphaDictionary0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderCaptureMeshController-Release0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderCaptureMeshController-Reset0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderCaptureMeshController-Capture0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-_GetSubMeshCount0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXUtils-ToMask0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-OnRelease0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-Reset0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-ApplySharedMaterialArray0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_ReplaceSharedMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_ReleaseAllReplaceMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialGroupData-Clear0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-Reset0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-CustomPerDrawDataController-Reset0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-Reset0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-IsAllRendererValid0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-StopShadowCasting0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-RevertShadowCastingMode0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-RequireAddMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-_GetRenderersOfRendererMask0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-AddMaterialToAllRenderer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-SetAddictiveFloatProperty0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-SetAddictiveFloatProperty0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-GetAddictiveFloatProperty0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-GetAddictiveFloatProperty0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-SetAddictiveVectorProperty0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-SetAddictiveVectorProperty0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-GetAddictiveVectorProperty0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-GetAddictiveVectorProperty0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-SetAddictiveTextureProperty0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-SetAddictiveTextureProperty0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-GetAddictiveTextureProperty0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-GetAddictiveTextureProperty0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-RequireRemoveMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-RemoveMaterialFromAllRenderer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialGroupData-CopyFrom0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_CopyReplaceMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_SplitRenderers0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_GetAffectGroupData0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_CreateReplaceMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetKeywordEnableToAllMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-SetKeywordEnableToAllMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetDepthOnlyPassEnableToAllMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-SetDepthOnlyPassEnableToAllMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-CustomPerDrawDataController-Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-CustomPerDrawDataController-SetFloatToCustomPerDraw0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-SetFloatToCustomPerDraw0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-CustomPerDrawDataController-SetVectorToCustomPerDraw0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-SetVectorToCustomPerDraw0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetFloatToAllMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-SetFloatToAllMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetVectorToAllMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-SetVectorToAllMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetTextureToAllMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-SetTextureToAllMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-SetManualDitherAlphaValue0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-SetManualDitherEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-GetRendererBounds0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetZTestInMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-SetZTestInMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-GetRenderHelperType0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-ReleaseFloatToAllMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-ReleaseVectorToAllMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-ReleaseTextureToAllMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperVisibleController-Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperVisibleController-_InitDictionary0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperVisibleController-Release0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperVisibleController-RendererInfo-get_rendererName0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperVisibleController-SetVisibleByNameContainsStr0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperVisibleController-SetVisibleByRenderer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperVisibleController-ResetVisibleByNameContainsStr0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperVisibleController-ResetVisibleByRenderer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderHelperVisibleController-Reset0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderMaterialManager-SetFloat0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderMaterialManager-SetTexture0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderMaterialManager-SetVector0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderMaterialManager-AddMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderMaterialManager-_RevertMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderMaterialManager-RemoveMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderMaterialManager-ClearMaterials0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderMaterialManager-SetKeywordEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderMaterialManager-SetDepthOnlyEnabled0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityRenderMaterialManager-SetZTestInMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXAsset-GetRendererTypeConfigs0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXAssetBase-get_assetName0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXControllerBase-SetOwner0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXControllerBase-InitLOD0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXControllerBase-SetName0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXControllerBase-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXControllerBase-Destroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXControllerBase-Play0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXControllerBase-Stop0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXControllerBase-Replay0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXControllerBase-Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXControllerBase-RefreshLastTickTime0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXControllerBase-GetDeltaTimeFromLastTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXControllerBase-GetPriorityType0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXControllerBase-GetNeedTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXControllerBase-OnHide0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXControllerBase-Hide0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXControllerBase-OnShow0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXControllerBase-Show0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXControllerBase-OnSample0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXControllerBase-Sample0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXControllerStateBase-Play0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXControllerStateBase-Replay0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXControllerStateBase-_FinalStop0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXControllerStateBase-Stop0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXControllerStateBase-GetNeedTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXControllerStateBase-Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXControllerStateBase-OnSample0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-_AddVATMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-_GetVATMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-_GetAddedMaterialIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-_RemoveVATMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-AddMaterialToAllRenderer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-RemoveMaterialFromAllRenderer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-SetFloatToFactoryMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-SetVectorToFactoryMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXFactoryMaterialCache-GetVATMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXFactoryMaterialCache-ReleaseVATMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXUtils-GetBoundsMinMaxOfDirection0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXUtils-CalculateCutOffBounds0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXUtils-Evaluate0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXUtils-_UpdateCurve0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-EntityVFXUtils-ApplyEntityVFXCurves0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-CommonVAT-get_PropertySetterType0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-CommonVAT-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-CommonVAT-_ClearTimer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-CommonVAT-_UpdateProperty0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-CommonVAT-_CreateTimer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-CommonVAT-_NextPlay0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-CommonVAT-_DoPlay0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-CommonVAT-Play0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-FactoryVAT-_InitRenderer_MeshRender0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-FactoryVAT-_InitRenderer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-FactoryVAT-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-FactoryVAT-_ReSetParamsToRenderer_MeshRender0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-FactoryVAT-_ReSetParamsToRenderer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-FactoryVAT-Reset0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-FactoryVAT-_SetParamsToRenderer_MeshRender0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-FactoryVAT-_SetParamsToRenderer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-FactoryVAT-_DoPlay0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-FactoryVAT-_UpdateAnim0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-FactoryVAT-OnUpdate0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-FactoryVAT-Play0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VATRendererPropertySetter-Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VATRendererPropertySetter-SetFloat0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VATRendererPropertySetter-SetVector0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VATEntityRendererHelperPropertySetter-Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VATEntityRendererHelperPropertySetter-SetFloat0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VATEntityRendererHelperPropertySetter-SetVector0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-PsoCreateUploadHelper-_PsoUploadProcessOneCallBack0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-PsoCreateUploadHelper-_PsoUpdateGameInfoCallBack0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-PsoCreateUploadHelper-Initialize0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-PsoCreateUploadHelper-_Callback0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-PsoCreateUploadHelper-_UploadFileToServer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-PsoCreateUploadHelper-_UploadFile0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-PsoCreateUploadHelper-_HandleMessage0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-PsoCreateUploadHelper-_UploadPipelineCreatedInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-PsoCreateUploadHelper-_Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-PsoCreateUploadHelper-Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-PsoCreateUploadHelper-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeUtils-GetPolygonOffSpline0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeBaker-_CalculatePolygonAndBounds0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeBaker-GetLocalPosition0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeBaker-_RaycastSceneObjectsHeight0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeUtils-CalculatePointPolygonHorizonRayCross0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeBaker-GetLocalIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeBaker-_CalculateInPolygon0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeBaker-_CalculateInHighPowerZone0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeBaker-_GetHash0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeBaker-_ForAround0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeBaker-_CalculateEdgeSignedDistance0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeBaker-_CalculateEdgeSignedDistance1;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeBaker-_BlurTopHeight0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeBaker-_CalculateThicknessAndTopHeight0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeBaker-_CalculateNormals0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeBaker-_GetTextureColor10;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeBaker-_CreateTexture0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeBaker-Bake0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeBaker-_CreateGaussianKernel0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeBaker-_Convolution0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeBaker-_GetHash1;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeBaker-_GetTextureColor20;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeNavUtils-BoundsUtil-GetTopBottomPoints0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-MakeFrameFromPlaneNormal0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-MakeFrameByYaw0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-SampleUniformByArcLength0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-Frame-WorldToFrame0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-ProjectWorldToFrameXZ0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-ConvexHullIndices0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-_AngleDegAt0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-_CurvatureAt0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-_PointToSegmentDistance2D0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-Simplify2D_ByCurvatureAngleDeviation0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-Process0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-Frame-FrameToWorld0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeNavUtils-SplineSamplingUtils-SampleByArcLength0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeNavUtils-PolySimplify-SimplifyByAngle0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeUtils-GetPolygonOffSplineWithSimplify0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-VFXSludgeUtils-GetPolygonOffByPolyLine0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-_CreateInstance0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-_ExtractSplineData0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-_DestroyInstance0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-_Release0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-Update0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-OnDrawGizmosSelected0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-Pause0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-Play0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-Stop0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-LODLightmapping-LightmapInfoTransfer-_RendererInfoTransfer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-LODLightmapping-LightmapInfoTransfer-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-LODLightmapping-LightmapInfoTransfer-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-Rendering-LODLightmapping-LODLightmapping-RendererInfoTransfer0;        // 0x0

    }

}

