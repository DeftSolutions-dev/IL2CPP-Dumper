// ========================================================
// Dumped by @desirepro
// Assembly: HG.RenderPipelines.ScriptBridge.dll
// Classes:  5
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: HG.Rendering.ScriptBridge.HGRenderBridgeStatics
TYPE:  class
TOKEN: 0x2000002
FIELDS:
METHODS:
  UnityEngine.Camera AttachHGCamera(UnityEngine.GameObject camObject)
  UnityEngine.Material GetHGDecalProjectorMaterialInChildren(UnityEngine.GameObject go)
  UnityEngine.HGDecalProjector GetHGDecalProjectorInChildren(UnityEngine.GameObject go)
  System.Void SetHGDecalProjectorProgress(UnityEngine.Object component, System.Single progress)
  System.Void SetHGDecalProjectorHollow(UnityEngine.Object component, System.Single hollow)
  System.Void HGCharacterHelperFindRenderers(UnityEngine.GameObject go)
  System.Void SetHGDecalProjectorAngle(UnityEngine.GameObject go, System.Single angle)
  System.Void UpdateCurrentPlayerCenter(UnityEngine.Transform centerTransform)
  System.Void UpdateAnchorBrightParams(UnityEngine.Vector2 anchorPosition, System.Single anchorRadius, System.Single anchorBrightIntensity, System.Boolean anchorBrightFlag)
  System.Void SetVFXPPPriorityFilterCinematic()
  System.Void SetVFXPPPriorityFilterNormal()
  System.Void SetVFXPPPriorityFilterUltiSkillCam()
  System.Void SetVFXPPActive(System.Boolean isActive)
  System.Void SetSceneDarkEnabled(System.Boolean enabled)
  System.String GetWorldUIKeyword()
  System.Void SetCharacterPositionsHeights(System.Collections.Generic.List<UnityEngine.Vector3> characterPositions, System.Collections.Generic.List<System.Single> characterRadiuses, System.Collections.Generic.List<System.Single> characterHeights)
  System.Void SetGameplayTime(System.Double gameplayTime)
  System.Void SetLastGameplayTime(System.Double lastGameplayTime)
  System.Void RequestDisableFrameGenTemporarily(UnityEngine.Camera camera, System.Boolean disable)
END_CLASS

CLASS: HG.Rendering.ScriptBridge.TAAUControlBridge
TYPE:  class
TOKEN: 0x2000003
FIELDS:
METHODS:
  System.Void SetRenderingScale(UnityEngine.Camera camera, System.Single scale)
  System.Void ToggleTAAU(UnityEngine.Camera camera)
  System.Void ToggleMetalFXSpatial(UnityEngine.Camera camera)
  System.Void ToggleMetalFXTemporal(UnityEngine.Camera camera)
  System.Void ToggleTAAUWithMetalFXSpatial(UnityEngine.Camera camera)
  System.Void ToggleMetalFXTemporalWithMetalFXSpatial(UnityEngine.Camera camera)
  System.Void set_taauFastConverge(System.Boolean value)
  System.Void ChangeHistoryWeight(System.Single val)
  System.Single GetHistoryWeight()
  System.Void ChangeHistoryWeightInMotion(System.Single val)
  System.Void ChangeDepthDiff(System.Single val)
  System.Void MinMVConsideredDynamic(System.Single val)
  System.Void MaxMVConsideredDynamic(System.Single val)
  System.Void CharacterMotionSensitivity(System.Single val)
  System.Void FastConvergeHistoryWeight(System.Single val)
  System.Void InputSampleLumaWeight(System.Single val)
  System.Void ToggleTargetFrameRate(System.Int32 val)
  System.Void NotifyTimeScale(System.Single timeScale)
  System.Void SetDLSSQuality(UnityEngine.Camera camera, System.Int32 quality)
  System.Void ToggleDLSS(UnityEngine.Camera camera)
  System.Void SetDLSSFG(UnityEngine.Camera camera, System.Int32 mode)
  System.Void SetDLSSFGModeGenFrames(System.Int32 numFramesToGenerate)
  System.Void SetDLSSReflex(System.Int32 mode)
  System.Void SetDLSSPCLEnable(System.Boolean enable)
  System.Void SetDLSSSharpenStrength(System.Single sharpenStrength)
  System.Void SetForceJitterPhaseIdx(UnityEngine.Camera camera, System.Int32 idx)
  System.Void UseDLSSExposure(System.Boolean use)
  System.Void .ctor()
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x2000004
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // 0x0
METHODS:
  System.Void __Gen_Wrap_0(System.Boolean P0)
  System.Void __Gen_Wrap_2(System.Object P0, System.Int32 P1)
  UnityEngine.Camera __Gen_Wrap_3(System.Object P0)
  UnityEngine.Material __Gen_Wrap_4(System.Object P0)
  UnityEngine.HGDecalProjector __Gen_Wrap_5(System.Object P0)
  System.Void __Gen_Wrap_6(System.Object P0, System.Single P1)
  System.Void __Gen_Wrap_7(System.Object P0)
  System.Void __Gen_Wrap_8(UnityEngine.Vector2 P0, System.Single P1, System.Single P2, System.Boolean P3)
  System.Void __Gen_Wrap_9()
  System.String __Gen_Wrap_10()
  System.Void __Gen_Wrap_11(System.Object P0, System.Object P1, System.Object P2)
  System.Void __Gen_Wrap_12(System.Double P0)
  System.Void __Gen_Wrap_13(System.Object P0, System.Boolean P1)
  System.Void __Gen_Wrap_14(System.Int32 P0)
  System.Void __Gen_Wrap_15(System.Single P0)
  System.Single __Gen_Wrap_16()
  System.Void .cctor()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x2000005
FIELDS:
METHODS:
  IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id)
  System.Boolean IsPatched(System.Int32 id)
END_CLASS

