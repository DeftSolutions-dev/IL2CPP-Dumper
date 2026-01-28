// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.InputModule.dll
// Classes:  7
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace UnityEngineInternal.Input
{

    // TypeToken: 0x2000002
    public class NativeUpdateCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngineInternal.Input.NativeInputUpdateType updateType, UnityEngineInternal.Input.NativeInputEventBuffer* buffer) { }

    }

    // TypeToken: 0x2000003
    public struct NativeInputEventType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngineInternal.Input.NativeInputEventType DeviceRemoved;        // 0x0
        public static UnityEngineInternal.Input.NativeInputEventType DeviceConfigChanged;        // 0x0
        public static UnityEngineInternal.Input.NativeInputEventType Text;        // 0x0
        public static UnityEngineInternal.Input.NativeInputEventType State;        // 0x0
        public static UnityEngineInternal.Input.NativeInputEventType Delta;        // 0x0

    }

    // TypeToken: 0x2000004
    public struct NativeInputEventBuffer
    {
        // Fields
        public System.Void* eventBuffer;        // 0x10
        public System.Int32 eventCount;        // 0x18
        public System.Int32 sizeInBytes;        // 0x1C
        public System.Int32 capacityInBytes;        // 0x20

    }

    // TypeToken: 0x2000005
    public struct NativeInputEvent
    {
        // Fields
        public static System.Int32 structSize;        // 0x0
        public UnityEngineInternal.Input.NativeInputEventType type;        // 0x10
        public System.UInt16 sizeInBytes;        // 0x14
        public System.UInt16 deviceId;        // 0x16
        public System.Double time;        // 0x18
        public System.Int32 eventId;        // 0x20

    }

    // TypeToken: 0x2000006
    public struct NativeInputUpdateType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngineInternal.Input.NativeInputUpdateType Dynamic;        // 0x0
        public static UnityEngineInternal.Input.NativeInputUpdateType Fixed;        // 0x0
        public static UnityEngineInternal.Input.NativeInputUpdateType BeforeRender;        // 0x0
        public static UnityEngineInternal.Input.NativeInputUpdateType Editor;        // 0x0
        public static UnityEngineInternal.Input.NativeInputUpdateType IgnoreFocus;        // 0x0

    }

    // TypeToken: 0x2000007
    public class NativeInputSystem
    {
        // Fields
        public static UnityEngineInternal.Input.NativeUpdateCallback onUpdate;        // 0x0
        public static System.Action<UnityEngineInternal.Input.NativeInputUpdateType> onBeforeUpdate;        // 0x8
        public static System.Func<UnityEngineInternal.Input.NativeInputUpdateType,System.Boolean> onShouldRunUpdate;        // 0x10
        private static System.Action<System.Int32,System.String> s_OnDeviceDiscoveredCallback;        // 0x18

        // Methods
        private System.Action<System.Int32,System.String> get_onDeviceDiscovered() { }
        private System.Void set_onDeviceDiscovered(System.Action<System.Int32,System.String> value) { }
        private System.Void .cctor() { }
        private System.Void NotifyBeforeUpdate(UnityEngineInternal.Input.NativeInputUpdateType updateType) { }
        private System.Void NotifyUpdate(UnityEngineInternal.Input.NativeInputUpdateType updateType, System.IntPtr eventBuffer) { }
        private System.Void NotifyDeviceDiscovered(System.Int32 deviceId, System.String deviceDescriptor) { }
        private System.Void ShouldRunUpdate(UnityEngineInternal.Input.NativeInputUpdateType updateType, System.Boolean& retval) { }
        private System.Void set_hasDeviceDiscoveredCallback(System.Boolean value) { }
        private System.Double get_currentTime() { }
        private System.Double get_currentTimeOffsetToRealtimeSinceStartup() { }
        private System.Int32 AllocateDeviceId() { }
        private System.Void QueueInputEvent(System.IntPtr inputEvent) { }
        private System.Int64 IOCTL(System.Int32 deviceId, System.Int32 code, System.IntPtr data, System.Int32 sizeInBytes) { }
        private System.Void SetPollingFrequency(System.Single hertz) { }
        private System.Void Update(UnityEngineInternal.Input.NativeInputUpdateType updateType) { }

    }

}

