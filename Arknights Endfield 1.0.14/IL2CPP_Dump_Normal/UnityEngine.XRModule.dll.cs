// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.XRModule.dll
// Classes:  32
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000005
    public struct TrackingStateEventType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.XR.InputTracking.TrackingStateEventType NodeAdded;        // 0x0
        public static UnityEngine.XR.InputTracking.TrackingStateEventType NodeRemoved;        // 0x0
        public static UnityEngine.XR.InputTracking.TrackingStateEventType TrackingAcquired;        // 0x0
        public static UnityEngine.XR.InputTracking.TrackingStateEventType TrackingLost;        // 0x0

    }

    // TypeToken: 0x2000014
    public struct XRRenderPass
    {
        // Fields
        private System.IntPtr displaySubsystemInstance;        // 0x10
        public System.Int32 renderPassIndex;        // 0x18
        public UnityEngine.Rendering.RenderTargetIdentifier renderTarget;        // 0x20
        public UnityEngine.RenderTextureDescriptor renderTargetDesc;        // 0x48
        public System.Boolean hasMotionVectorPass;        // 0x7C
        public UnityEngine.Rendering.RenderTargetIdentifier motionVectorRenderTarget;        // 0x80
        public UnityEngine.RenderTextureDescriptor motionVectorRenderTargetDesc;        // 0xA8
        public System.Boolean shouldFillOutDepth;        // 0xDC
        public System.Int32 cullingPassIndex;        // 0xE0

    }

    // TypeToken: 0x2000015
    public struct XRMirrorViewBlitDesc
    {
        // Fields
        private System.IntPtr displaySubsystemInstance;        // 0x10
        public System.Boolean nativeBlitAvailable;        // 0x18
        public System.Boolean nativeBlitInvalidStates;        // 0x19
        public System.Int32 blitParamsCount;        // 0x1C

    }

    // TypeToken: 0x200001F
    public struct MeshTransformList, IDisposable
    {
        // Fields
        private readonly System.IntPtr m_Self;        // 0x10

        // Methods
        private System.Void Dispose() { }
        private System.Void Dispose(System.IntPtr self) { }

    }

namespace Microsoft.CodeAnalysis
{

    // TypeToken: 0x2000002
    public class EmbeddedAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace System.Runtime.CompilerServices
{

    // TypeToken: 0x2000003
    public class IsReadOnlyAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace UnityEngine.XR
{

    // TypeToken: 0x2000004
    public class InputTracking
    {
        // Fields
        private static System.Action<UnityEngine.XR.XRNodeState> trackingAcquired;        // 0x0
        private static System.Action<UnityEngine.XR.XRNodeState> trackingLost;        // 0x8
        private static System.Action<UnityEngine.XR.XRNodeState> nodeAdded;        // 0x10
        private static System.Action<UnityEngine.XR.XRNodeState> nodeRemoved;        // 0x18

        // Methods
        private System.Void InvokeTrackingEvent(UnityEngine.XR.InputTracking.TrackingStateEventType eventType, UnityEngine.XR.XRNode nodeType, System.Int64 uniqueID, System.Boolean tracked) { }

    }

    // TypeToken: 0x2000006
    public struct XRNode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.XR.XRNode LeftEye;        // 0x0
        public static UnityEngine.XR.XRNode RightEye;        // 0x0
        public static UnityEngine.XR.XRNode CenterEye;        // 0x0
        public static UnityEngine.XR.XRNode Head;        // 0x0
        public static UnityEngine.XR.XRNode LeftHand;        // 0x0
        public static UnityEngine.XR.XRNode RightHand;        // 0x0
        public static UnityEngine.XR.XRNode GameController;        // 0x0
        public static UnityEngine.XR.XRNode TrackingReference;        // 0x0
        public static UnityEngine.XR.XRNode HardwareTracker;        // 0x0

    }

    // TypeToken: 0x2000007
    public struct AvailableTrackingData
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.XR.AvailableTrackingData None;        // 0x0
        public static UnityEngine.XR.AvailableTrackingData PositionAvailable;        // 0x0
        public static UnityEngine.XR.AvailableTrackingData RotationAvailable;        // 0x0
        public static UnityEngine.XR.AvailableTrackingData VelocityAvailable;        // 0x0
        public static UnityEngine.XR.AvailableTrackingData AngularVelocityAvailable;        // 0x0
        public static UnityEngine.XR.AvailableTrackingData AccelerationAvailable;        // 0x0
        public static UnityEngine.XR.AvailableTrackingData AngularAccelerationAvailable;        // 0x0

    }

    // TypeToken: 0x2000008
    public struct XRNodeState
    {
        // Fields
        private UnityEngine.XR.XRNode m_Type;        // 0x10
        private UnityEngine.XR.AvailableTrackingData m_AvailableFields;        // 0x14
        private UnityEngine.Vector3 m_Position;        // 0x18
        private UnityEngine.Quaternion m_Rotation;        // 0x24
        private UnityEngine.Vector3 m_Velocity;        // 0x34
        private UnityEngine.Vector3 m_AngularVelocity;        // 0x40
        private UnityEngine.Vector3 m_Acceleration;        // 0x4C
        private UnityEngine.Vector3 m_AngularAcceleration;        // 0x58
        private System.Int32 m_Tracked;        // 0x64
        private System.UInt64 m_UniqueID;        // 0x68

        // Methods
        private System.Void set_uniqueID(System.UInt64 value) { }
        private System.Void set_nodeType(UnityEngine.XR.XRNode value) { }
        private System.Void set_tracked(System.Boolean value) { }

    }

    // TypeToken: 0x2000009
    public struct InputFeatureType
    {
        // Fields
        public System.UInt32 value__;        // 0x10
        public static UnityEngine.XR.InputFeatureType Custom;        // 0x0
        public static UnityEngine.XR.InputFeatureType Binary;        // 0x0
        public static UnityEngine.XR.InputFeatureType DiscreteStates;        // 0x0
        public static UnityEngine.XR.InputFeatureType Axis1D;        // 0x0
        public static UnityEngine.XR.InputFeatureType Axis2D;        // 0x0
        public static UnityEngine.XR.InputFeatureType Axis3D;        // 0x0
        public static UnityEngine.XR.InputFeatureType Rotation;        // 0x0
        public static UnityEngine.XR.InputFeatureType Hand;        // 0x0
        public static UnityEngine.XR.InputFeatureType Bone;        // 0x0
        public static UnityEngine.XR.InputFeatureType Eyes;        // 0x0
        public static UnityEngine.XR.InputFeatureType kUnityXRInputFeatureTypeInvalid;        // 0x0

    }

    // TypeToken: 0x200000A
    public struct ConnectionChangeType
    {
        // Fields
        public System.UInt32 value__;        // 0x10
        public static UnityEngine.XR.ConnectionChangeType Connected;        // 0x0
        public static UnityEngine.XR.ConnectionChangeType Disconnected;        // 0x0
        public static UnityEngine.XR.ConnectionChangeType ConfigChange;        // 0x0

    }

    // TypeToken: 0x200000B
    public struct InputDeviceCharacteristics
    {
        // Fields
        public System.UInt32 value__;        // 0x10
        public static UnityEngine.XR.InputDeviceCharacteristics None;        // 0x0
        public static UnityEngine.XR.InputDeviceCharacteristics HeadMounted;        // 0x0
        public static UnityEngine.XR.InputDeviceCharacteristics Camera;        // 0x0
        public static UnityEngine.XR.InputDeviceCharacteristics HeldInHand;        // 0x0
        public static UnityEngine.XR.InputDeviceCharacteristics HandTracking;        // 0x0
        public static UnityEngine.XR.InputDeviceCharacteristics EyeTracking;        // 0x0
        public static UnityEngine.XR.InputDeviceCharacteristics TrackedDevice;        // 0x0
        public static UnityEngine.XR.InputDeviceCharacteristics Controller;        // 0x0
        public static UnityEngine.XR.InputDeviceCharacteristics TrackingReference;        // 0x0
        public static UnityEngine.XR.InputDeviceCharacteristics Left;        // 0x0
        public static UnityEngine.XR.InputDeviceCharacteristics Right;        // 0x0
        public static UnityEngine.XR.InputDeviceCharacteristics Simulated6DOF;        // 0x0

    }

    // TypeToken: 0x200000C
    public struct InputTrackingState
    {
        // Fields
        public System.UInt32 value__;        // 0x10
        public static UnityEngine.XR.InputTrackingState None;        // 0x0
        public static UnityEngine.XR.InputTrackingState Position;        // 0x0
        public static UnityEngine.XR.InputTrackingState Rotation;        // 0x0
        public static UnityEngine.XR.InputTrackingState Velocity;        // 0x0
        public static UnityEngine.XR.InputTrackingState AngularVelocity;        // 0x0
        public static UnityEngine.XR.InputTrackingState Acceleration;        // 0x0
        public static UnityEngine.XR.InputTrackingState AngularAcceleration;        // 0x0
        public static UnityEngine.XR.InputTrackingState All;        // 0x0

    }

    // TypeToken: 0x200000D
    public struct InputFeatureUsage, IEquatable`1
    {
        // Fields
        private System.String m_Name;        // 0x10
        private UnityEngine.XR.InputFeatureType m_InternalType;        // 0x18

        // Methods
        private System.String get_name() { }
        private UnityEngine.XR.InputFeatureType get_internalType() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(UnityEngine.XR.InputFeatureUsage other) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200000E
    public struct InputDevice, IEquatable`1
    {
        // Fields
        private System.UInt64 m_DeviceId;        // 0x10
        private System.Boolean m_Initialized;        // 0x18

        // Methods
        private System.Void .ctor(System.UInt64 deviceId) { }
        private System.UInt64 get_deviceId() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(UnityEngine.XR.InputDevice other) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200000F
    public struct Hand, IEquatable`1
    {
        // Fields
        private System.UInt64 m_DeviceId;        // 0x10
        private System.UInt32 m_FeatureIndex;        // 0x18

        // Methods
        private System.UInt64 get_deviceId() { }
        private System.UInt32 get_featureIndex() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(UnityEngine.XR.Hand other) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000010
    public struct Eyes, IEquatable`1
    {
        // Fields
        private System.UInt64 m_DeviceId;        // 0x10
        private System.UInt32 m_FeatureIndex;        // 0x18

        // Methods
        private System.UInt64 get_deviceId() { }
        private System.UInt32 get_featureIndex() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(UnityEngine.XR.Eyes other) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000011
    public struct Bone, IEquatable`1
    {
        // Fields
        private System.UInt64 m_DeviceId;        // 0x10
        private System.UInt32 m_FeatureIndex;        // 0x18

        // Methods
        private System.UInt64 get_deviceId() { }
        private System.UInt32 get_featureIndex() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(UnityEngine.XR.Bone other) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000012
    public class InputDevices
    {
        // Fields
        private static System.Action<UnityEngine.XR.InputDevice> deviceConnected;        // 0x0
        private static System.Action<UnityEngine.XR.InputDevice> deviceDisconnected;        // 0x8
        private static System.Action<UnityEngine.XR.InputDevice> deviceConfigChanged;        // 0x10

        // Methods
        private System.Void InvokeConnectionEvent(System.UInt64 deviceId, UnityEngine.XR.ConnectionChangeType change) { }

    }

    // TypeToken: 0x2000013
    public class XRDisplaySubsystem : IntegratedSubsystem`1
    {
        // Fields
        private System.Action<System.Boolean> displayFocusChanged;        // 0x20

        // Methods
        private System.Void InvokeDisplayFocusChanged(System.Boolean focus) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000016
    public class XRDisplaySubsystemDescriptor : IntegratedSubsystemDescriptor`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000017
    public class XRInputSubsystem : IntegratedSubsystem`1
    {
        // Fields
        private System.Action<UnityEngine.XR.XRInputSubsystem> trackingOriginUpdated;        // 0x20
        private System.Action<UnityEngine.XR.XRInputSubsystem> boundaryChanged;        // 0x28

        // Methods
        private System.Void InvokeTrackingOriginUpdatedEvent(System.IntPtr internalPtr) { }
        private System.Void InvokeBoundaryChangedEvent(System.IntPtr internalPtr) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000018
    public class XRInputSubsystemDescriptor : IntegratedSubsystemDescriptor`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000019
    public struct MeshId, IEquatable`1
    {
        // Fields
        private static UnityEngine.XR.MeshId s_InvalidId;        // 0x0
        private System.UInt64 m_SubId1;        // 0x10
        private System.UInt64 m_SubId2;        // 0x18

        // Methods
        private System.String ToString() { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(UnityEngine.XR.MeshId other) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200001A
    public struct MeshGenerationStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.XR.MeshGenerationStatus Success;        // 0x0
        public static UnityEngine.XR.MeshGenerationStatus InvalidMeshId;        // 0x0
        public static UnityEngine.XR.MeshGenerationStatus GenerationAlreadyInProgress;        // 0x0
        public static UnityEngine.XR.MeshGenerationStatus Canceled;        // 0x0
        public static UnityEngine.XR.MeshGenerationStatus UnknownError;        // 0x0

    }

    // TypeToken: 0x200001B
    public class HashCodeHelper
    {
        // Methods
        private System.Int32 Combine(System.Int32 hash1, System.Int32 hash2) { }
        private System.Int32 Combine(System.Int32 hash1, System.Int32 hash2, System.Int32 hash3) { }
        private System.Int32 Combine(System.Int32 hash1, System.Int32 hash2, System.Int32 hash3, System.Int32 hash4) { }
        private System.Int32 Combine(System.Int32 hash1, System.Int32 hash2, System.Int32 hash3, System.Int32 hash4, System.Int32 hash5) { }
        private System.Int32 Combine(System.Int32 hash1, System.Int32 hash2, System.Int32 hash3, System.Int32 hash4, System.Int32 hash5, System.Int32 hash6) { }
        private System.Int32 Combine(System.Int32 hash1, System.Int32 hash2, System.Int32 hash3, System.Int32 hash4, System.Int32 hash5, System.Int32 hash6, System.Int32 hash7) { }
        private System.Int32 Combine(System.Int32 hash1, System.Int32 hash2, System.Int32 hash3, System.Int32 hash4, System.Int32 hash5, System.Int32 hash6, System.Int32 hash7, System.Int32 hash8) { }

    }

    // TypeToken: 0x200001C
    public struct MeshGenerationResult, IEquatable`1
    {
        // Fields
        private readonly UnityEngine.XR.MeshId <MeshId>k__BackingField;        // 0x10
        private readonly UnityEngine.Mesh <Mesh>k__BackingField;        // 0x20
        private readonly UnityEngine.MeshCollider <MeshCollider>k__BackingField;        // 0x28
        private readonly UnityEngine.XR.MeshGenerationStatus <Status>k__BackingField;        // 0x30
        private readonly UnityEngine.XR.MeshVertexAttributes <Attributes>k__BackingField;        // 0x34
        private readonly System.UInt64 <Timestamp>k__BackingField;        // 0x38
        private readonly UnityEngine.Vector3 <Position>k__BackingField;        // 0x40
        private readonly UnityEngine.Quaternion <Rotation>k__BackingField;        // 0x4C
        private readonly UnityEngine.Vector3 <Scale>k__BackingField;        // 0x5C

        // Methods
        private UnityEngine.XR.MeshId get_MeshId() { }
        private UnityEngine.Mesh get_Mesh() { }
        private UnityEngine.MeshCollider get_MeshCollider() { }
        private UnityEngine.XR.MeshGenerationStatus get_Status() { }
        private UnityEngine.XR.MeshVertexAttributes get_Attributes() { }
        private UnityEngine.Vector3 get_Position() { }
        private UnityEngine.Quaternion get_Rotation() { }
        private UnityEngine.Vector3 get_Scale() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(UnityEngine.XR.MeshGenerationResult other) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200001D
    public struct MeshVertexAttributes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.XR.MeshVertexAttributes None;        // 0x0
        public static UnityEngine.XR.MeshVertexAttributes Normals;        // 0x0
        public static UnityEngine.XR.MeshVertexAttributes Tangents;        // 0x0
        public static UnityEngine.XR.MeshVertexAttributes UVs;        // 0x0
        public static UnityEngine.XR.MeshVertexAttributes Colors;        // 0x0

    }

    // TypeToken: 0x200001E
    public class XRMeshSubsystem : IntegratedSubsystem`1
    {
        // Methods
        private System.Void InvokeMeshReadyDelegate(UnityEngine.XR.MeshGenerationResult result, System.Action<UnityEngine.XR.MeshGenerationResult> onMeshGenerationComplete) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000020
    public class XRMeshSubsystemDescriptor : IntegratedSubsystemDescriptor`1
    {
        // Methods
        private System.Void .ctor() { }

    }

}

