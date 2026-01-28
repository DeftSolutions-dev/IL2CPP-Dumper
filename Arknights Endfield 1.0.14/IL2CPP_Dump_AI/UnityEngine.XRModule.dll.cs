// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.XRModule.dll
// Classes:  32
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: TrackingStateEventType
TYPE:  struct
TOKEN: 0x2000005
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.XR.InputTracking.TrackingStateEventTypeNodeAdded  // 0x0
  public    static  UnityEngine.XR.InputTracking.TrackingStateEventTypeNodeRemoved  // 0x0
  public    static  UnityEngine.XR.InputTracking.TrackingStateEventTypeTrackingAcquired  // 0x0
  public    static  UnityEngine.XR.InputTracking.TrackingStateEventTypeTrackingLost  // 0x0
METHODS:
END_CLASS

CLASS: XRRenderPass
TYPE:  struct
TOKEN: 0x2000014
FIELDS:
  private           System.IntPtr                   displaySubsystemInstance  // 0x10
  public            System.Int32                    renderPassIndex  // 0x18
  public            UnityEngine.Rendering.RenderTargetIdentifierrenderTarget  // 0x20
  public            UnityEngine.RenderTextureDescriptorrenderTargetDesc  // 0x48
  public            System.Boolean                  hasMotionVectorPass  // 0x7C
  public            UnityEngine.Rendering.RenderTargetIdentifiermotionVectorRenderTarget  // 0x80
  public            UnityEngine.RenderTextureDescriptormotionVectorRenderTargetDesc  // 0xA8
  public            System.Boolean                  shouldFillOutDepth  // 0xDC
  public            System.Int32                    cullingPassIndex  // 0xE0
METHODS:
END_CLASS

CLASS: XRMirrorViewBlitDesc
TYPE:  struct
TOKEN: 0x2000015
FIELDS:
  private           System.IntPtr                   displaySubsystemInstance  // 0x10
  public            System.Boolean                  nativeBlitAvailable  // 0x18
  public            System.Boolean                  nativeBlitInvalidStates  // 0x19
  public            System.Int32                    blitParamsCount  // 0x1C
METHODS:
END_CLASS

CLASS: MeshTransformList
TYPE:  struct
TOKEN: 0x200001F
FIELDS:
  private   readonly System.IntPtr                   m_Self  // 0x10
METHODS:
  System.Void Dispose()
  System.Void Dispose(System.IntPtr self)
END_CLASS

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

CLASS: UnityEngine.XR.InputTracking
TYPE:  class
TOKEN: 0x2000004
FIELDS:
  private   static  System.Action<UnityEngine.XR.XRNodeState>trackingAcquired  // 0x0
  private   static  System.Action<UnityEngine.XR.XRNodeState>trackingLost  // 0x8
  private   static  System.Action<UnityEngine.XR.XRNodeState>nodeAdded  // 0x10
  private   static  System.Action<UnityEngine.XR.XRNodeState>nodeRemoved  // 0x18
METHODS:
  System.Void InvokeTrackingEvent(UnityEngine.XR.InputTracking.TrackingStateEventType eventType, UnityEngine.XR.XRNode nodeType, System.Int64 uniqueID, System.Boolean tracked)
END_CLASS

CLASS: UnityEngine.XR.XRNode
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.XR.XRNode           LeftEye  // 0x0
  public    static  UnityEngine.XR.XRNode           RightEye  // 0x0
  public    static  UnityEngine.XR.XRNode           CenterEye  // 0x0
  public    static  UnityEngine.XR.XRNode           Head  // 0x0
  public    static  UnityEngine.XR.XRNode           LeftHand  // 0x0
  public    static  UnityEngine.XR.XRNode           RightHand  // 0x0
  public    static  UnityEngine.XR.XRNode           GameController  // 0x0
  public    static  UnityEngine.XR.XRNode           TrackingReference  // 0x0
  public    static  UnityEngine.XR.XRNode           HardwareTracker  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.XR.AvailableTrackingData
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.XR.AvailableTrackingDataNone  // 0x0
  public    static  UnityEngine.XR.AvailableTrackingDataPositionAvailable  // 0x0
  public    static  UnityEngine.XR.AvailableTrackingDataRotationAvailable  // 0x0
  public    static  UnityEngine.XR.AvailableTrackingDataVelocityAvailable  // 0x0
  public    static  UnityEngine.XR.AvailableTrackingDataAngularVelocityAvailable  // 0x0
  public    static  UnityEngine.XR.AvailableTrackingDataAccelerationAvailable  // 0x0
  public    static  UnityEngine.XR.AvailableTrackingDataAngularAccelerationAvailable  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.XR.XRNodeState
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  private           UnityEngine.XR.XRNode           m_Type  // 0x10
  private           UnityEngine.XR.AvailableTrackingDatam_AvailableFields  // 0x14
  private           UnityEngine.Vector3             m_Position  // 0x18
  private           UnityEngine.Quaternion          m_Rotation  // 0x24
  private           UnityEngine.Vector3             m_Velocity  // 0x34
  private           UnityEngine.Vector3             m_AngularVelocity  // 0x40
  private           UnityEngine.Vector3             m_Acceleration  // 0x4C
  private           UnityEngine.Vector3             m_AngularAcceleration  // 0x58
  private           System.Int32                    m_Tracked  // 0x64
  private           System.UInt64                   m_UniqueID  // 0x68
METHODS:
  System.Void set_uniqueID(System.UInt64 value)
  System.Void set_nodeType(UnityEngine.XR.XRNode value)
  System.Void set_tracked(System.Boolean value)
END_CLASS

CLASS: UnityEngine.XR.InputFeatureType
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  UnityEngine.XR.InputFeatureType Custom  // 0x0
  public    static  UnityEngine.XR.InputFeatureType Binary  // 0x0
  public    static  UnityEngine.XR.InputFeatureType DiscreteStates  // 0x0
  public    static  UnityEngine.XR.InputFeatureType Axis1D  // 0x0
  public    static  UnityEngine.XR.InputFeatureType Axis2D  // 0x0
  public    static  UnityEngine.XR.InputFeatureType Axis3D  // 0x0
  public    static  UnityEngine.XR.InputFeatureType Rotation  // 0x0
  public    static  UnityEngine.XR.InputFeatureType Hand  // 0x0
  public    static  UnityEngine.XR.InputFeatureType Bone  // 0x0
  public    static  UnityEngine.XR.InputFeatureType Eyes  // 0x0
  public    static  UnityEngine.XR.InputFeatureType kUnityXRInputFeatureTypeInvalid  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.XR.ConnectionChangeType
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  UnityEngine.XR.ConnectionChangeTypeConnected  // 0x0
  public    static  UnityEngine.XR.ConnectionChangeTypeDisconnected  // 0x0
  public    static  UnityEngine.XR.ConnectionChangeTypeConfigChange  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.XR.InputDeviceCharacteristics
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  UnityEngine.XR.InputDeviceCharacteristicsNone  // 0x0
  public    static  UnityEngine.XR.InputDeviceCharacteristicsHeadMounted  // 0x0
  public    static  UnityEngine.XR.InputDeviceCharacteristicsCamera  // 0x0
  public    static  UnityEngine.XR.InputDeviceCharacteristicsHeldInHand  // 0x0
  public    static  UnityEngine.XR.InputDeviceCharacteristicsHandTracking  // 0x0
  public    static  UnityEngine.XR.InputDeviceCharacteristicsEyeTracking  // 0x0
  public    static  UnityEngine.XR.InputDeviceCharacteristicsTrackedDevice  // 0x0
  public    static  UnityEngine.XR.InputDeviceCharacteristicsController  // 0x0
  public    static  UnityEngine.XR.InputDeviceCharacteristicsTrackingReference  // 0x0
  public    static  UnityEngine.XR.InputDeviceCharacteristicsLeft  // 0x0
  public    static  UnityEngine.XR.InputDeviceCharacteristicsRight  // 0x0
  public    static  UnityEngine.XR.InputDeviceCharacteristicsSimulated6DOF  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.XR.InputTrackingState
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  UnityEngine.XR.InputTrackingStateNone  // 0x0
  public    static  UnityEngine.XR.InputTrackingStatePosition  // 0x0
  public    static  UnityEngine.XR.InputTrackingStateRotation  // 0x0
  public    static  UnityEngine.XR.InputTrackingStateVelocity  // 0x0
  public    static  UnityEngine.XR.InputTrackingStateAngularVelocity  // 0x0
  public    static  UnityEngine.XR.InputTrackingStateAcceleration  // 0x0
  public    static  UnityEngine.XR.InputTrackingStateAngularAcceleration  // 0x0
  public    static  UnityEngine.XR.InputTrackingStateAll  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.XR.InputFeatureUsage
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
  private           System.String                   m_Name  // 0x10
  private           UnityEngine.XR.InputFeatureType m_InternalType  // 0x18
METHODS:
  System.String get_name()
  UnityEngine.XR.InputFeatureType get_internalType()
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(UnityEngine.XR.InputFeatureUsage other)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.XR.InputDevice
TYPE:  struct
TOKEN: 0x200000E
FIELDS:
  private           System.UInt64                   m_DeviceId  // 0x10
  private           System.Boolean                  m_Initialized  // 0x18
METHODS:
  System.Void .ctor(System.UInt64 deviceId)
  System.UInt64 get_deviceId()
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(UnityEngine.XR.InputDevice other)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.XR.Hand
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  private           System.UInt64                   m_DeviceId  // 0x10
  private           System.UInt32                   m_FeatureIndex  // 0x18
METHODS:
  System.UInt64 get_deviceId()
  System.UInt32 get_featureIndex()
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(UnityEngine.XR.Hand other)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.XR.Eyes
TYPE:  struct
TOKEN: 0x2000010
FIELDS:
  private           System.UInt64                   m_DeviceId  // 0x10
  private           System.UInt32                   m_FeatureIndex  // 0x18
METHODS:
  System.UInt64 get_deviceId()
  System.UInt32 get_featureIndex()
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(UnityEngine.XR.Eyes other)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.XR.Bone
TYPE:  struct
TOKEN: 0x2000011
FIELDS:
  private           System.UInt64                   m_DeviceId  // 0x10
  private           System.UInt32                   m_FeatureIndex  // 0x18
METHODS:
  System.UInt64 get_deviceId()
  System.UInt32 get_featureIndex()
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(UnityEngine.XR.Bone other)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.XR.InputDevices
TYPE:  class
TOKEN: 0x2000012
FIELDS:
  private   static  System.Action<UnityEngine.XR.InputDevice>deviceConnected  // 0x0
  private   static  System.Action<UnityEngine.XR.InputDevice>deviceDisconnected  // 0x8
  private   static  System.Action<UnityEngine.XR.InputDevice>deviceConfigChanged  // 0x10
METHODS:
  System.Void InvokeConnectionEvent(System.UInt64 deviceId, UnityEngine.XR.ConnectionChangeType change)
END_CLASS

CLASS: UnityEngine.XR.XRDisplaySubsystem
TYPE:  class
TOKEN: 0x2000013
EXTENDS: IntegratedSubsystem`1
FIELDS:
  private           System.Action<System.Boolean>   displayFocusChanged  // 0x20
METHODS:
  System.Void InvokeDisplayFocusChanged(System.Boolean focus)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.XR.XRDisplaySubsystemDescriptor
TYPE:  class
TOKEN: 0x2000016
EXTENDS: IntegratedSubsystemDescriptor`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.XR.XRInputSubsystem
TYPE:  class
TOKEN: 0x2000017
EXTENDS: IntegratedSubsystem`1
FIELDS:
  private           System.Action<UnityEngine.XR.XRInputSubsystem>trackingOriginUpdated  // 0x20
  private           System.Action<UnityEngine.XR.XRInputSubsystem>boundaryChanged  // 0x28
METHODS:
  System.Void InvokeTrackingOriginUpdatedEvent(System.IntPtr internalPtr)
  System.Void InvokeBoundaryChangedEvent(System.IntPtr internalPtr)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.XR.XRInputSubsystemDescriptor
TYPE:  class
TOKEN: 0x2000018
EXTENDS: IntegratedSubsystemDescriptor`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.XR.MeshId
TYPE:  struct
TOKEN: 0x2000019
FIELDS:
  private   static  UnityEngine.XR.MeshId           s_InvalidId  // 0x0
  private           System.UInt64                   m_SubId1  // 0x10
  private           System.UInt64                   m_SubId2  // 0x18
METHODS:
  System.String ToString()
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(UnityEngine.XR.MeshId other)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.XR.MeshGenerationStatus
TYPE:  struct
TOKEN: 0x200001A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.XR.MeshGenerationStatusSuccess  // 0x0
  public    static  UnityEngine.XR.MeshGenerationStatusInvalidMeshId  // 0x0
  public    static  UnityEngine.XR.MeshGenerationStatusGenerationAlreadyInProgress  // 0x0
  public    static  UnityEngine.XR.MeshGenerationStatusCanceled  // 0x0
  public    static  UnityEngine.XR.MeshGenerationStatusUnknownError  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.XR.HashCodeHelper
TYPE:  class
TOKEN: 0x200001B
FIELDS:
METHODS:
  System.Int32 Combine(System.Int32 hash1, System.Int32 hash2)
  System.Int32 Combine(System.Int32 hash1, System.Int32 hash2, System.Int32 hash3)
  System.Int32 Combine(System.Int32 hash1, System.Int32 hash2, System.Int32 hash3, System.Int32 hash4)
  System.Int32 Combine(System.Int32 hash1, System.Int32 hash2, System.Int32 hash3, System.Int32 hash4, System.Int32 hash5)
  System.Int32 Combine(System.Int32 hash1, System.Int32 hash2, System.Int32 hash3, System.Int32 hash4, System.Int32 hash5, System.Int32 hash6)
  System.Int32 Combine(System.Int32 hash1, System.Int32 hash2, System.Int32 hash3, System.Int32 hash4, System.Int32 hash5, System.Int32 hash6, System.Int32 hash7)
  System.Int32 Combine(System.Int32 hash1, System.Int32 hash2, System.Int32 hash3, System.Int32 hash4, System.Int32 hash5, System.Int32 hash6, System.Int32 hash7, System.Int32 hash8)
END_CLASS

CLASS: UnityEngine.XR.MeshGenerationResult
TYPE:  struct
TOKEN: 0x200001C
FIELDS:
  private   readonly UnityEngine.XR.MeshId           <MeshId>k__BackingField  // 0x10
  private   readonly UnityEngine.Mesh                <Mesh>k__BackingField  // 0x20
  private   readonly UnityEngine.MeshCollider        <MeshCollider>k__BackingField  // 0x28
  private   readonly UnityEngine.XR.MeshGenerationStatus<Status>k__BackingField  // 0x30
  private   readonly UnityEngine.XR.MeshVertexAttributes<Attributes>k__BackingField  // 0x34
  private   readonly System.UInt64                   <Timestamp>k__BackingField  // 0x38
  private   readonly UnityEngine.Vector3             <Position>k__BackingField  // 0x40
  private   readonly UnityEngine.Quaternion          <Rotation>k__BackingField  // 0x4C
  private   readonly UnityEngine.Vector3             <Scale>k__BackingField  // 0x5C
METHODS:
  UnityEngine.XR.MeshId get_MeshId()
  UnityEngine.Mesh get_Mesh()
  UnityEngine.MeshCollider get_MeshCollider()
  UnityEngine.XR.MeshGenerationStatus get_Status()
  UnityEngine.XR.MeshVertexAttributes get_Attributes()
  UnityEngine.Vector3 get_Position()
  UnityEngine.Quaternion get_Rotation()
  UnityEngine.Vector3 get_Scale()
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(UnityEngine.XR.MeshGenerationResult other)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.XR.MeshVertexAttributes
TYPE:  struct
TOKEN: 0x200001D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.XR.MeshVertexAttributesNone  // 0x0
  public    static  UnityEngine.XR.MeshVertexAttributesNormals  // 0x0
  public    static  UnityEngine.XR.MeshVertexAttributesTangents  // 0x0
  public    static  UnityEngine.XR.MeshVertexAttributesUVs  // 0x0
  public    static  UnityEngine.XR.MeshVertexAttributesColors  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.XR.XRMeshSubsystem
TYPE:  class
TOKEN: 0x200001E
EXTENDS: IntegratedSubsystem`1
FIELDS:
METHODS:
  System.Void InvokeMeshReadyDelegate(UnityEngine.XR.MeshGenerationResult result, System.Action<UnityEngine.XR.MeshGenerationResult> onMeshGenerationComplete)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.XR.XRMeshSubsystemDescriptor
TYPE:  class
TOKEN: 0x2000020
EXTENDS: IntegratedSubsystemDescriptor`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

