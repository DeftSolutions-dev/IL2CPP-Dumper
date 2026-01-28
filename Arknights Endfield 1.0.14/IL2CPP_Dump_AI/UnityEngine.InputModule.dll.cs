// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.InputModule.dll
// Classes:  7
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: UnityEngineInternal.Input.NativeUpdateCallback
TYPE:  class
TOKEN: 0x2000002
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngineInternal.Input.NativeInputUpdateType updateType, UnityEngineInternal.Input.NativeInputEventBuffer* buffer)
END_CLASS

CLASS: UnityEngineInternal.Input.NativeInputEventType
TYPE:  struct
TOKEN: 0x2000003
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngineInternal.Input.NativeInputEventTypeDeviceRemoved  // 0x0
  public    static  UnityEngineInternal.Input.NativeInputEventTypeDeviceConfigChanged  // 0x0
  public    static  UnityEngineInternal.Input.NativeInputEventTypeText  // 0x0
  public    static  UnityEngineInternal.Input.NativeInputEventTypeState  // 0x0
  public    static  UnityEngineInternal.Input.NativeInputEventTypeDelta  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngineInternal.Input.NativeInputEventBuffer
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  public            System.Void*                    eventBuffer  // 0x10
  public            System.Int32                    eventCount  // 0x18
  public            System.Int32                    sizeInBytes  // 0x1C
  public            System.Int32                    capacityInBytes  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngineInternal.Input.NativeInputEvent
TYPE:  struct
TOKEN: 0x2000005
FIELDS:
  public    static  System.Int32                    structSize  // 0x0
  public            UnityEngineInternal.Input.NativeInputEventTypetype  // 0x10
  public            System.UInt16                   sizeInBytes  // 0x14
  public            System.UInt16                   deviceId  // 0x16
  public            System.Double                   time  // 0x18
  public            System.Int32                    eventId  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngineInternal.Input.NativeInputUpdateType
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngineInternal.Input.NativeInputUpdateTypeDynamic  // 0x0
  public    static  UnityEngineInternal.Input.NativeInputUpdateTypeFixed  // 0x0
  public    static  UnityEngineInternal.Input.NativeInputUpdateTypeBeforeRender  // 0x0
  public    static  UnityEngineInternal.Input.NativeInputUpdateTypeEditor  // 0x0
  public    static  UnityEngineInternal.Input.NativeInputUpdateTypeIgnoreFocus  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngineInternal.Input.NativeInputSystem
TYPE:  class
TOKEN: 0x2000007
FIELDS:
  public    static  UnityEngineInternal.Input.NativeUpdateCallbackonUpdate  // 0x0
  public    static  System.Action<UnityEngineInternal.Input.NativeInputUpdateType>onBeforeUpdate  // 0x8
  public    static  System.Func<UnityEngineInternal.Input.NativeInputUpdateType,System.Boolean>onShouldRunUpdate  // 0x10
  private   static  System.Action<System.Int32,System.String>s_OnDeviceDiscoveredCallback  // 0x18
METHODS:
  System.Action<System.Int32,System.String> get_onDeviceDiscovered()
  System.Void set_onDeviceDiscovered(System.Action<System.Int32,System.String> value)
  System.Void .cctor()
  System.Void NotifyBeforeUpdate(UnityEngineInternal.Input.NativeInputUpdateType updateType)
  System.Void NotifyUpdate(UnityEngineInternal.Input.NativeInputUpdateType updateType, System.IntPtr eventBuffer)
  System.Void NotifyDeviceDiscovered(System.Int32 deviceId, System.String deviceDescriptor)
  System.Void ShouldRunUpdate(UnityEngineInternal.Input.NativeInputUpdateType updateType, System.Boolean& retval)
  System.Void set_hasDeviceDiscoveredCallback(System.Boolean value)
  System.Double get_currentTime()
  System.Double get_currentTimeOffsetToRealtimeSinceStartup()
  System.Int32 AllocateDeviceId()
  System.Void QueueInputEvent(System.IntPtr inputEvent)
  System.Int64 IOCTL(System.Int32 deviceId, System.Int32 code, System.IntPtr data, System.Int32 sizeInBytes)
  System.Void SetPollingFrequency(System.Single hertz)
  System.Void Update(UnityEngineInternal.Input.NativeInputUpdateType updateType)
END_CLASS

