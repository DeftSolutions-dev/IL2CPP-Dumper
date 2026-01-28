// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.VRModule.dll
// Classes:  4
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: StereoRenderingMode
TYPE:  struct
TOKEN: 0x2000003
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.XR.XRSettings.StereoRenderingModeMultiPass  // 0x0
  public    static  UnityEngine.XR.XRSettings.StereoRenderingModeSinglePass  // 0x0
  public    static  UnityEngine.XR.XRSettings.StereoRenderingModeSinglePassInstanced  // 0x0
  public    static  UnityEngine.XR.XRSettings.StereoRenderingModeSinglePassMultiview  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.XR.XRSettings
TYPE:  class
TOKEN: 0x2000002
FIELDS:
METHODS:
  System.Boolean get_enabled()
  System.Boolean get_isDeviceActive()
  System.Single get_eyeTextureResolutionScale()
  System.Void set_eyeTextureResolutionScale(System.Single value)
  System.Int32 get_eyeTextureWidth()
  System.Int32 get_eyeTextureHeight()
  UnityEngine.RenderTextureDescriptor get_eyeTextureDesc()
  System.Single get_renderViewportScale()
  System.Single get_renderViewportScaleInternal()
  System.String get_loadedDeviceName()
  System.String[] get_supportedDevices()
  UnityEngine.XR.XRSettings.StereoRenderingMode get_stereoRenderingMode()
  System.Void get_eyeTextureDesc_Injected(UnityEngine.RenderTextureDescriptor& ret)
END_CLASS

CLASS: UnityEngine.XR.XRDevice
TYPE:  class
TOKEN: 0x2000004
FIELDS:
  private   static  System.Action<System.String>    deviceLoaded  // 0x0
METHODS:
  System.Void DisableAutoXRCameraTracking(UnityEngine.Camera camera, System.Boolean disabled)
  System.Void InvokeDeviceLoaded(System.String loadedDeviceName)
END_CLASS

