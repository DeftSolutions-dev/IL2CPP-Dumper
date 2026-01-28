// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.VRModule.dll
// Classes:  4
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000003
    public struct StereoRenderingMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.XR.XRSettings.StereoRenderingMode MultiPass;        // 0x0
        public static UnityEngine.XR.XRSettings.StereoRenderingMode SinglePass;        // 0x0
        public static UnityEngine.XR.XRSettings.StereoRenderingMode SinglePassInstanced;        // 0x0
        public static UnityEngine.XR.XRSettings.StereoRenderingMode SinglePassMultiview;        // 0x0

    }

namespace UnityEngine.XR
{

    // TypeToken: 0x2000002
    public class XRSettings
    {
        // Methods
        private System.Boolean get_enabled() { }
        private System.Boolean get_isDeviceActive() { }
        private System.Single get_eyeTextureResolutionScale() { }
        private System.Void set_eyeTextureResolutionScale(System.Single value) { }
        private System.Int32 get_eyeTextureWidth() { }
        private System.Int32 get_eyeTextureHeight() { }
        private UnityEngine.RenderTextureDescriptor get_eyeTextureDesc() { }
        private System.Single get_renderViewportScale() { }
        private System.Single get_renderViewportScaleInternal() { }
        private System.String get_loadedDeviceName() { }
        private System.String[] get_supportedDevices() { }
        private UnityEngine.XR.XRSettings.StereoRenderingMode get_stereoRenderingMode() { }
        private System.Void get_eyeTextureDesc_Injected(UnityEngine.RenderTextureDescriptor& ret) { }

    }

    // TypeToken: 0x2000004
    public class XRDevice
    {
        // Fields
        private static System.Action<System.String> deviceLoaded;        // 0x0

        // Methods
        private System.Void DisableAutoXRCameraTracking(UnityEngine.Camera camera, System.Boolean disabled) { }
        private System.Void InvokeDeviceLoaded(System.String loadedDeviceName) { }

    }

}

