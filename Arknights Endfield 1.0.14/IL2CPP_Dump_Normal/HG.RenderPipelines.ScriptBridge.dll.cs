// ========================================================
// Dumped by @desirepro
// Assembly: HG.RenderPipelines.ScriptBridge.dll
// Classes:  5
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace HG.Rendering.ScriptBridge
{

    // TypeToken: 0x2000002
    public class HGRenderBridgeStatics
    {
        // Methods
        private UnityEngine.Camera AttachHGCamera(UnityEngine.GameObject camObject) { }
        private UnityEngine.Material GetHGDecalProjectorMaterialInChildren(UnityEngine.GameObject go) { }
        private UnityEngine.HGDecalProjector GetHGDecalProjectorInChildren(UnityEngine.GameObject go) { }
        private System.Void SetHGDecalProjectorProgress(UnityEngine.Object component, System.Single progress) { }
        private System.Void SetHGDecalProjectorHollow(UnityEngine.Object component, System.Single hollow) { }
        private System.Void HGCharacterHelperFindRenderers(UnityEngine.GameObject go) { }
        private System.Void SetHGDecalProjectorAngle(UnityEngine.GameObject go, System.Single angle) { }
        private System.Void UpdateCurrentPlayerCenter(UnityEngine.Transform centerTransform) { }
        private System.Void UpdateAnchorBrightParams(UnityEngine.Vector2 anchorPosition, System.Single anchorRadius, System.Single anchorBrightIntensity, System.Boolean anchorBrightFlag) { }
        private System.Void SetVFXPPPriorityFilterCinematic() { }
        private System.Void SetVFXPPPriorityFilterNormal() { }
        private System.Void SetVFXPPPriorityFilterUltiSkillCam() { }
        private System.Void SetVFXPPActive(System.Boolean isActive) { }
        private System.Void SetSceneDarkEnabled(System.Boolean enabled) { }
        private System.String GetWorldUIKeyword() { }
        private System.Void SetCharacterPositionsHeights(System.Collections.Generic.List<UnityEngine.Vector3> characterPositions, System.Collections.Generic.List<System.Single> characterRadiuses, System.Collections.Generic.List<System.Single> characterHeights) { }
        private System.Void SetGameplayTime(System.Double gameplayTime) { }
        private System.Void SetLastGameplayTime(System.Double lastGameplayTime) { }
        private System.Void RequestDisableFrameGenTemporarily(UnityEngine.Camera camera, System.Boolean disable) { }

    }

    // TypeToken: 0x2000003
    public class TAAUControlBridge
    {
        // Methods
        private System.Void SetRenderingScale(UnityEngine.Camera camera, System.Single scale) { }
        private System.Void ToggleTAAU(UnityEngine.Camera camera) { }
        private System.Void ToggleMetalFXSpatial(UnityEngine.Camera camera) { }
        private System.Void ToggleMetalFXTemporal(UnityEngine.Camera camera) { }
        private System.Void ToggleTAAUWithMetalFXSpatial(UnityEngine.Camera camera) { }
        private System.Void ToggleMetalFXTemporalWithMetalFXSpatial(UnityEngine.Camera camera) { }
        private System.Void set_taauFastConverge(System.Boolean value) { }
        private System.Void ChangeHistoryWeight(System.Single val) { }
        private System.Single GetHistoryWeight() { }
        private System.Void ChangeHistoryWeightInMotion(System.Single val) { }
        private System.Void ChangeDepthDiff(System.Single val) { }
        private System.Void MinMVConsideredDynamic(System.Single val) { }
        private System.Void MaxMVConsideredDynamic(System.Single val) { }
        private System.Void CharacterMotionSensitivity(System.Single val) { }
        private System.Void FastConvergeHistoryWeight(System.Single val) { }
        private System.Void InputSampleLumaWeight(System.Single val) { }
        private System.Void ToggleTargetFrameRate(System.Int32 val) { }
        private System.Void NotifyTimeScale(System.Single timeScale) { }
        private System.Void SetDLSSQuality(UnityEngine.Camera camera, System.Int32 quality) { }
        private System.Void ToggleDLSS(UnityEngine.Camera camera) { }
        private System.Void SetDLSSFG(UnityEngine.Camera camera, System.Int32 mode) { }
        private System.Void SetDLSSFGModeGenFrames(System.Int32 numFramesToGenerate) { }
        private System.Void SetDLSSReflex(System.Int32 mode) { }
        private System.Void SetDLSSPCLEnable(System.Boolean enable) { }
        private System.Void SetDLSSSharpenStrength(System.Single sharpenStrength) { }
        private System.Void SetForceJitterPhaseIdx(UnityEngine.Camera camera, System.Int32 idx) { }
        private System.Void UseDLSSExposure(System.Boolean use) { }
        private System.Void .ctor() { }

    }

}

namespace IFix
{

    // TypeToken: 0x2000004
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10
        private System.Int32 methodId;        // 0x18
        private System.Object anonObj;        // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;        // 0x0

        // Methods
        private System.Void __Gen_Wrap_0(System.Boolean P0) { }
        private System.Void __Gen_Wrap_2(System.Object P0, System.Int32 P1) { }
        private UnityEngine.Camera __Gen_Wrap_3(System.Object P0) { }
        private UnityEngine.Material __Gen_Wrap_4(System.Object P0) { }
        private UnityEngine.HGDecalProjector __Gen_Wrap_5(System.Object P0) { }
        private System.Void __Gen_Wrap_6(System.Object P0, System.Single P1) { }
        private System.Void __Gen_Wrap_7(System.Object P0) { }
        private System.Void __Gen_Wrap_8(UnityEngine.Vector2 P0, System.Single P1, System.Single P2, System.Boolean P3) { }
        private System.Void __Gen_Wrap_9() { }
        private System.String __Gen_Wrap_10() { }
        private System.Void __Gen_Wrap_11(System.Object P0, System.Object P1, System.Object P2) { }
        private System.Void __Gen_Wrap_12(System.Double P0) { }
        private System.Void __Gen_Wrap_13(System.Object P0, System.Boolean P1) { }
        private System.Void __Gen_Wrap_14(System.Int32 P0) { }
        private System.Void __Gen_Wrap_15(System.Single P0) { }
        private System.Single __Gen_Wrap_16() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000005
    public class WrappersManagerImpl
    {
        // Methods
        private IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        private System.Boolean IsPatched(System.Int32 id) { }

    }

}

