// ========================================================
// Dumped by @desirepro
// Assembly: Cinemachine.dll
// Classes:  204
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000002
    public class CinemachineCameraOffset : CinemachineExtension
    {
        // Fields
        public UnityEngine.Vector3 m_Offset;        // 0x28
        public Cinemachine.CinemachineCore.Stage m_ApplyAfter;        // 0x34
        public System.Boolean m_PreserveComposition;        // 0x38

        // Methods
        private System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000003
    public class CinemachineRecomposer : CinemachineExtension
    {
        // Fields
        public Cinemachine.CinemachineCore.Stage m_ApplyAfter;        // 0x28
        public System.Single m_Tilt;        // 0x2C
        public System.Single m_Pan;        // 0x30
        public System.Single m_Dutch;        // 0x34
        public System.Single m_ZoomScale;        // 0x38
        public System.Single m_FollowAttachment;        // 0x3C
        public System.Single m_LookAtAttachment;        // 0x40

        // Methods
        private System.Void Reset() { }
        private System.Void OnValidate() { }
        private System.Void PrePipelineMutateCameraStateCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CameraState& curState, System.Single deltaTime) { }
        private System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000004
    public class CinemachineBeyondCommunicator
    {
        // Fields
        private static System.Func<Cinemachine.CinemachineVirtualCameraBase> <GetLevelCamera>k__BackingField;        // 0x0

        // Methods
        private System.Func<Cinemachine.CinemachineVirtualCameraBase> get_GetLevelCamera() { }
        private System.Void set_GetLevelCamera(System.Func<Cinemachine.CinemachineVirtualCameraBase> value) { }

    }

    // TypeToken: 0x2000005
    public class CinemachineTouchInputMapper : MonoBehaviour
    {
        // Fields
        public System.Single TouchSensitivityX;        // 0x18
        public System.Single TouchSensitivityY;        // 0x1C
        public System.String TouchXInputMapTo;        // 0x20
        public System.String TouchYInputMapTo;        // 0x28

        // Methods
        private System.Void Start() { }
        private System.Single GetInputAxis(System.String axisName) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000006
    public class CinemachineMixer : PlayableBehaviour
    {
        // Fields
        private Cinemachine.CinemachineBrain mBrain;        // 0x10
        private System.Int32 mBrainOverrideId;        // 0x18
        private System.Boolean mPreviewPlay;        // 0x1C

        // Methods
        private System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable) { }
        private System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData) { }
        private System.Single GetDeltaTime(System.Single deltaTime) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000007
    public class CinemachineShot : PlayableAsset, IPropertyPreview, ITimelineClipAsset
    {
        // Fields
        public System.Boolean DisableEvaluateTwiceWhenEnabled;        // 0x18
        public System.Boolean UseVcamBeforeTimeline;        // 0x19
        public System.Boolean UseLevelCamera;        // 0x1A
        public System.String DisplayName;        // 0x20
        public UnityEngine.ExposedReference<Cinemachine.CinemachineVirtualCameraBase> VirtualCamera;        // 0x28

        // Methods
        private UnityEngine.Timeline.ClipCaps get_clipCaps() { }
        private UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner) { }
        private System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000008
    public class CinemachineShotPlayable : PlayableBehaviour
    {
        // Fields
        public Cinemachine.CinemachineVirtualCameraBase VirtualCamera;        // 0x10

        // Methods
        private System.Boolean get_IsValid() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000009
    public class CinemachineTrack : TrackAsset
    {
        // Methods
        private UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000C
    public struct Instruction
    {
        // Fields
        public Cinemachine.CinemachineVirtualCameraBase m_VirtualCamera;        // 0x10
        public System.Single m_Hold;        // 0x18
        public Cinemachine.CinemachineBlendDefinition m_Blend;        // 0x20

    }

    // TypeToken: 0x200000E
    public struct UpdateMethod
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachineBrain.UpdateMethod FixedUpdate;        // 0x0
        public static Cinemachine.CinemachineBrain.UpdateMethod LateUpdate;        // 0x0
        public static Cinemachine.CinemachineBrain.UpdateMethod SmartUpdate;        // 0x0
        public static Cinemachine.CinemachineBrain.UpdateMethod ManualUpdate;        // 0x0

    }

    // TypeToken: 0x200000F
    public struct BrainUpdateMethod
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachineBrain.BrainUpdateMethod FixedUpdate;        // 0x0
        public static Cinemachine.CinemachineBrain.BrainUpdateMethod LateUpdate;        // 0x0

    }

    // TypeToken: 0x2000010
    public class BrainEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000011
    public class VcamActivatedEvent : UnityEvent`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000012
    public class BrainFrame
    {
        // Fields
        public System.Int32 id;        // 0x10
        public Cinemachine.CinemachineBlend blend;        // 0x18
        public Cinemachine.CinemachineBlend workingBlend;        // 0x20
        public Cinemachine.BlendSourceVirtualCamera workingBlendSource;        // 0x28
        public System.Single deltaTimeOverride;        // 0x30

        // Methods
        private System.Boolean get_Active() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000015
    public struct Pair
    {
        // Fields
        public System.Int32 a;        // 0x10
        public System.Single b;        // 0x14

    }

    // TypeToken: 0x2000018
    public struct ResolutionStrategy
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachineCollider.ResolutionStrategy PullCameraForward;        // 0x0
        public static Cinemachine.CinemachineCollider.ResolutionStrategy PreserveCameraHeight;        // 0x0
        public static Cinemachine.CinemachineCollider.ResolutionStrategy PreserveCameraDistance;        // 0x0

    }

    // TypeToken: 0x2000019
    public class VcamExtraState
    {
        // Fields
        public UnityEngine.Vector3 previousDisplacement;        // 0x10
        public System.Single previousLookAt2DisplacedPosLen;        // 0x1C
        public System.Boolean shouldPerformCollisionDamping;        // 0x20
        public System.Boolean previousHitSomething;        // 0x21
        public System.Boolean targetObscured;        // 0x22
        public System.Single occlusionStartTime;        // 0x24
        public System.Collections.Generic.List<UnityEngine.Vector3> debugResolutionPath;        // 0x28
        private System.Single m_SmoothedDistance;        // 0x30
        private System.Single m_SmoothedTime;        // 0x34

        // Methods
        private System.Void AddPointToDebugPath(UnityEngine.Vector3 p) { }
        private System.Single ApplyDistanceSmoothing(System.Single distance, System.Single smoothingTime) { }
        private System.Void UpdateDistanceSmoothing(System.Single distance) { }
        private System.Void ResetDistanceSmoothing(System.Single smoothingTime) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001B
    public struct Mode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachineConfiner.Mode Confine2D;        // 0x0
        public static Cinemachine.CinemachineConfiner.Mode Confine3D;        // 0x0

    }

    // TypeToken: 0x200001C
    public class VcamExtraState
    {
        // Fields
        public UnityEngine.Vector3 m_previousDisplacement;        // 0x10
        public System.Single confinerDisplacement;        // 0x1C

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001E
    public class VcamExtraState
    {
        // Fields
        public UnityEngine.Vector3 m_PreviousDisplacement;        // 0x10
        public UnityEngine.Vector3 m_DampedDisplacement;        // 0x1C
        public Cinemachine.ConfinerOven.BakedSolution m_BakedSolution;        // 0x28
        public Cinemachine.CinemachineVirtualCameraBase m_vcam;        // 0x30

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001F
    public struct ShapeCache
    {
        // Fields
        public Cinemachine.ConfinerOven m_confinerOven;        // 0x10
        public System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>> m_OriginalPath;        // 0x18
        public UnityEngine.Matrix4x4 m_DeltaWorldToBaked;        // 0x20
        public UnityEngine.Matrix4x4 m_DeltaBakedToWorld;        // 0x60
        private System.Single m_aspectRatio;        // 0xA0
        private System.Single m_maxWindowSize;        // 0xA4
        private System.Single m_maxComputationTimePerFrameInSeconds;        // 0xA8
        private UnityEngine.Matrix4x4 m_bakedToWorld;        // 0xAC
        private UnityEngine.Collider2D m_boundingShape2D;        // 0xF0

        // Methods
        private System.Void Invalidate() { }
        private System.Boolean ValidateCache(UnityEngine.Collider2D boundingShape2D, System.Single maxWindowSize, System.Single aspectRatio, System.Boolean& confinerStateChanged) { }
        private System.Boolean IsValid(UnityEngine.Collider2D& boundingShape2D, System.Single& aspectRatio, System.Single& maxOrthoSize) { }
        private System.Void CalculateDeltaTransformationMatrix() { }

    }

    // TypeToken: 0x2000021
    public struct UpdateMethod
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachineDollyCart.UpdateMethod Update;        // 0x0
        public static Cinemachine.CinemachineDollyCart.UpdateMethod FixedUpdate;        // 0x0
        public static Cinemachine.CinemachineDollyCart.UpdateMethod LateUpdate;        // 0x0

    }

    // TypeToken: 0x2000024
    public class VcamExtraState
    {
        // Fields
        public System.Single m_previousFrameZoom;        // 0x10

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000026
    public struct Orbit
    {
        // Fields
        public System.Single m_Height;        // 0x10
        public System.Single m_Radius;        // 0x14

        // Methods
        private System.Void .ctor(System.Single h, System.Single r) { }

    }

    // TypeToken: 0x2000027
    public class CreateRigDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private Cinemachine.CinemachineVirtualCamera Invoke(Cinemachine.CinemachineFreeLook vcam, System.String name, Cinemachine.CinemachineVirtualCamera copyFrom) { }

    }

    // TypeToken: 0x2000028
    public class DestroyRigDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.GameObject rig) { }

    }

    // TypeToken: 0x200002B
    public struct Waypoint
    {
        // Fields
        public UnityEngine.Vector3 position;        // 0x10
        public UnityEngine.Vector3 tangent;        // 0x1C
        public System.Single roll;        // 0x28

    }

    // TypeToken: 0x200002F
    public struct Waypoint
    {
        // Fields
        public UnityEngine.Vector3 position;        // 0x10
        public System.Single roll;        // 0x1C

        // Methods
        private UnityEngine.Vector4 get_AsVector4() { }
        private Cinemachine.CinemachineSmoothPath.Waypoint FromVector4(UnityEngine.Vector4 v) { }

    }

    // TypeToken: 0x2000031
    public struct Instruction
    {
        // Fields
        public System.Int32 m_FullHash;        // 0x10
        public Cinemachine.CinemachineVirtualCameraBase m_VirtualCamera;        // 0x18
        public System.Single m_ActivateAfter;        // 0x20
        public System.Single m_MinDuration;        // 0x24

    }

    // TypeToken: 0x2000032
    public struct ParentHash
    {
        // Fields
        public System.Int32 m_Hash;        // 0x10
        public System.Int32 m_ParentHash;        // 0x14

    }

    // TypeToken: 0x2000033
    public struct HashPair
    {
        // Fields
        public System.Int32 parentHash;        // 0x10
        public System.Int32 hash;        // 0x14

    }

    // TypeToken: 0x2000035
    public struct FillStrategy
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachineStoryboard.FillStrategy BestFit;        // 0x0
        public static Cinemachine.CinemachineStoryboard.FillStrategy CropImageToFit;        // 0x0
        public static Cinemachine.CinemachineStoryboard.FillStrategy StretchToFit;        // 0x0

    }

    // TypeToken: 0x2000036
    public class CanvasInfo
    {
        // Fields
        public UnityEngine.GameObject mCanvas;        // 0x10
        public UnityEngine.Canvas mCanvasComponent;        // 0x18
        public Cinemachine.CinemachineBrain mCanvasParent;        // 0x20
        public UnityEngine.RectTransform mViewport;        // 0x28
        public UnityEngine.UI.RawImage mRawImage;        // 0x30

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000037
    public struct StoryboardRenderMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachineStoryboard.StoryboardRenderMode ScreenSpaceOverlay;        // 0x0
        public static Cinemachine.CinemachineStoryboard.StoryboardRenderMode ScreenSpaceCamera;        // 0x0

    }

    // TypeToken: 0x200003A
    public struct Target
    {
        // Fields
        public UnityEngine.Transform target;        // 0x10
        public System.Single weight;        // 0x18
        public System.Single radius;        // 0x1C

    }

    // TypeToken: 0x200003B
    public struct PositionMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachineTargetGroup.PositionMode GroupCenter;        // 0x0
        public static Cinemachine.CinemachineTargetGroup.PositionMode GroupAverage;        // 0x0

    }

    // TypeToken: 0x200003C
    public struct RotationMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachineTargetGroup.RotationMode Manual;        // 0x0
        public static Cinemachine.CinemachineTargetGroup.RotationMode GroupAverage;        // 0x0

    }

    // TypeToken: 0x200003D
    public struct UpdateMethod
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachineTargetGroup.UpdateMethod Update;        // 0x0
        public static Cinemachine.CinemachineTargetGroup.UpdateMethod FixedUpdate;        // 0x0
        public static Cinemachine.CinemachineTargetGroup.UpdateMethod LateUpdate;        // 0x0

    }

    // TypeToken: 0x200003F
    public class CreatePipelineDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private UnityEngine.Transform Invoke(Cinemachine.CinemachineVirtualCamera vcam, System.String name, Cinemachine.CinemachineComponentBase[] copyFrom) { }

    }

    // TypeToken: 0x2000040
    public class DestroyPipelineDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.GameObject pipeline) { }

    }

    // TypeToken: 0x2000045
    public struct FovCache
    {
        // Fields
        public UnityEngine.Rect mFovSoftGuideRect;        // 0x10
        public UnityEngine.Rect mFovHardGuideRect;        // 0x20
        public System.Single mFovH;        // 0x30
        public System.Single mFov;        // 0x34
        private System.Single mOrthoSizeOverDistance;        // 0x38
        private System.Single mAspect;        // 0x3C
        private UnityEngine.Rect mSoftGuideRect;        // 0x40
        private UnityEngine.Rect mHardGuideRect;        // 0x50

        // Methods
        private System.Void UpdateCache(Cinemachine.LensSettings lens, UnityEngine.Rect softGuide, UnityEngine.Rect hardGuide, System.Single targetDistance) { }
        private UnityEngine.Rect ScreenToFOV(UnityEngine.Rect rScreen, System.Single fov, System.Single fovH, System.Single aspect) { }

    }

    // TypeToken: 0x2000047
    public struct FramingMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachineFramingTransposer.FramingMode Horizontal;        // 0x0
        public static Cinemachine.CinemachineFramingTransposer.FramingMode Vertical;        // 0x0
        public static Cinemachine.CinemachineFramingTransposer.FramingMode HorizontalAndVertical;        // 0x0
        public static Cinemachine.CinemachineFramingTransposer.FramingMode None;        // 0x0

    }

    // TypeToken: 0x2000048
    public struct AdjustmentMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachineFramingTransposer.AdjustmentMode ZoomOnly;        // 0x0
        public static Cinemachine.CinemachineFramingTransposer.AdjustmentMode DollyOnly;        // 0x0
        public static Cinemachine.CinemachineFramingTransposer.AdjustmentMode DollyThenZoom;        // 0x0

    }

    // TypeToken: 0x200004A
    public struct FramingMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachineGroupComposer.FramingMode Horizontal;        // 0x0
        public static Cinemachine.CinemachineGroupComposer.FramingMode Vertical;        // 0x0
        public static Cinemachine.CinemachineGroupComposer.FramingMode HorizontalAndVertical;        // 0x0

    }

    // TypeToken: 0x200004B
    public struct AdjustmentMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachineGroupComposer.AdjustmentMode ZoomOnly;        // 0x0
        public static Cinemachine.CinemachineGroupComposer.AdjustmentMode DollyOnly;        // 0x0
        public static Cinemachine.CinemachineGroupComposer.AdjustmentMode DollyThenZoom;        // 0x0

    }

    // TypeToken: 0x2000050
    public struct HeadingDefinition
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachineOrbitalTransposer.Heading.HeadingDefinition PositionDelta;        // 0x0
        public static Cinemachine.CinemachineOrbitalTransposer.Heading.HeadingDefinition Velocity;        // 0x0
        public static Cinemachine.CinemachineOrbitalTransposer.Heading.HeadingDefinition TargetForward;        // 0x0
        public static Cinemachine.CinemachineOrbitalTransposer.Heading.HeadingDefinition WorldForward;        // 0x0

    }

    // TypeToken: 0x200004F
    public struct Heading
    {
        // Fields
        public Cinemachine.CinemachineOrbitalTransposer.Heading.HeadingDefinition m_Definition;        // 0x10
        public System.Int32 m_VelocityFilterStrength;        // 0x14
        public System.Single m_Bias;        // 0x18

        // Methods
        private System.Void .ctor(Cinemachine.CinemachineOrbitalTransposer.Heading.HeadingDefinition def, System.Int32 filterStrength, System.Single bias) { }

    }

    // TypeToken: 0x2000051
    public class UpdateHeadingDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Single Invoke(Cinemachine.CinemachineOrbitalTransposer orbital, System.Single deltaTime, UnityEngine.Vector3 up) { }

    }

    // TypeToken: 0x2000054
    public struct RecenterTargetMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachinePOV.RecenterTargetMode None;        // 0x0
        public static Cinemachine.CinemachinePOV.RecenterTargetMode FollowTargetForward;        // 0x0
        public static Cinemachine.CinemachinePOV.RecenterTargetMode LookAtTargetForward;        // 0x0

    }

    // TypeToken: 0x2000057
    public struct CameraUpMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachineTrackedDolly.CameraUpMode Default;        // 0x0
        public static Cinemachine.CinemachineTrackedDolly.CameraUpMode Path;        // 0x0
        public static Cinemachine.CinemachineTrackedDolly.CameraUpMode PathNoRoll;        // 0x0
        public static Cinemachine.CinemachineTrackedDolly.CameraUpMode FollowTarget;        // 0x0
        public static Cinemachine.CinemachineTrackedDolly.CameraUpMode FollowTargetNoRoll;        // 0x0

    }

    // TypeToken: 0x2000058
    public struct AutoDolly
    {
        // Fields
        public System.Boolean m_Enabled;        // 0x10
        public System.Single m_PositionOffset;        // 0x14
        public System.Int32 m_SearchRadius;        // 0x18
        public System.Int32 m_SearchResolution;        // 0x1C

        // Methods
        private System.Void .ctor(System.Boolean enabled, System.Single positionOffset, System.Int32 searchRadius, System.Int32 stepsPerSegment) { }

    }

    // TypeToken: 0x200005A
    public struct BindingMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachineTransposer.BindingMode LockToTargetOnAssign;        // 0x0
        public static Cinemachine.CinemachineTransposer.BindingMode LockToTargetWithWorldUp;        // 0x0
        public static Cinemachine.CinemachineTransposer.BindingMode LockToTargetNoRoll;        // 0x0
        public static Cinemachine.CinemachineTransposer.BindingMode LockToTarget;        // 0x0
        public static Cinemachine.CinemachineTransposer.BindingMode WorldSpace;        // 0x0
        public static Cinemachine.CinemachineTransposer.BindingMode SimpleFollowWithWorldUp;        // 0x0

    }

    // TypeToken: 0x200005B
    public struct AngularDampingMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachineTransposer.AngularDampingMode Euler;        // 0x0
        public static Cinemachine.CinemachineTransposer.AngularDampingMode Quaternion;        // 0x0

    }

    // TypeToken: 0x200005D
    public struct SpeedMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.AxisState.SpeedMode MaxSpeed;        // 0x0
        public static Cinemachine.AxisState.SpeedMode InputValueGain;        // 0x0

    }

    // TypeToken: 0x200005E
    public interface IInputAxisProvider
    {
        // Methods
        private System.Single GetAxisValue(System.Int32 axis) { }

    }

    // TypeToken: 0x200005F
    public struct Recentering
    {
        // Fields
        public System.Boolean m_enabled;        // 0x10
        public System.Single m_WaitTime;        // 0x14
        public System.Single m_RecenteringTime;        // 0x18
        private System.Single mLastAxisInputTime;        // 0x1C
        private System.Single mRecenteringVelocity;        // 0x20
        private System.Int32 m_LegacyHeadingDefinition;        // 0x24
        private System.Int32 m_LegacyVelocityFilterStrength;        // 0x28

        // Methods
        private System.Void .ctor(System.Boolean enabled, System.Single waitTime, System.Single recenteringTime) { }
        private System.Void Validate() { }
        private System.Void CancelRecentering() { }
        private System.Void DoRecentering(Cinemachine.AxisState& axis, System.Single deltaTime, System.Single recenterTarget) { }
        private System.Boolean LegacyUpgrade(System.Int32& heading, System.Int32& velocityFilter) { }

    }

    // TypeToken: 0x2000061
    public struct HGDOFParams
    {
        // Fields
        public System.Boolean enabledForVirtualCamera;        // 0x10
        public System.Boolean enable;        // 0x11
        public System.Single nearRadius;        // 0x14
        public System.Single nearFocusStart;        // 0x18
        public System.Single nearFocusEnd;        // 0x1C
        public System.Single farRadius;        // 0x20
        public System.Single farFocusStart;        // 0x24
        public System.Single farFocusEnd;        // 0x28
        public System.Single temporalFactor;        // 0x2C

    }

    // TypeToken: 0x2000062
    public struct BlendHintValue
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CameraState.BlendHintValue Nothing;        // 0x0
        public static Cinemachine.CameraState.BlendHintValue NoPosition;        // 0x0
        public static Cinemachine.CameraState.BlendHintValue NoOrientation;        // 0x0
        public static Cinemachine.CameraState.BlendHintValue NoTransform;        // 0x0
        public static Cinemachine.CameraState.BlendHintValue SphericalPositionBlend;        // 0x0
        public static Cinemachine.CameraState.BlendHintValue CylindricalPositionBlend;        // 0x0
        public static Cinemachine.CameraState.BlendHintValue RadialAimBlend;        // 0x0
        public static Cinemachine.CameraState.BlendHintValue IgnoreLookAtTarget;        // 0x0
        public static Cinemachine.CameraState.BlendHintValue NoLens;        // 0x0

    }

    // TypeToken: 0x2000063
    public struct CustomBlendable
    {
        // Fields
        public UnityEngine.Object m_Custom;        // 0x10
        public System.Single m_Weight;        // 0x18

        // Methods
        private System.Void .ctor(UnityEngine.Object custom, System.Single weight) { }

    }

    // TypeToken: 0x2000066
    public struct Style
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachineBlendDefinition.Style Cut;        // 0x0
        public static Cinemachine.CinemachineBlendDefinition.Style EaseInOut;        // 0x0
        public static Cinemachine.CinemachineBlendDefinition.Style EaseIn;        // 0x0
        public static Cinemachine.CinemachineBlendDefinition.Style EaseOut;        // 0x0
        public static Cinemachine.CinemachineBlendDefinition.Style HardIn;        // 0x0
        public static Cinemachine.CinemachineBlendDefinition.Style HardOut;        // 0x0
        public static Cinemachine.CinemachineBlendDefinition.Style Linear;        // 0x0
        public static Cinemachine.CinemachineBlendDefinition.Style Custom;        // 0x0

    }

    // TypeToken: 0x200006A
    public struct CustomBlend
    {
        // Fields
        public System.String m_From;        // 0x10
        public System.String m_To;        // 0x18
        public Cinemachine.CinemachineBlendDefinition m_Blend;        // 0x20

    }

    // TypeToken: 0x200006B
    public class CustomBlendGroup
    {
        // Fields
        public System.Collections.Generic.List<System.String> cameras;        // 0x10
        public Cinemachine.CinemachineBlendDefinition fromSameCamera;        // 0x18
        public Cinemachine.CinemachineBlendDefinition insideGroup;        // 0x30
        public Cinemachine.CinemachineBlendDefinition toGroup;        // 0x48
        public Cinemachine.CinemachineBlendDefinition fromGroup;        // 0x60

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006E
    public struct Stage
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachineCore.Stage Body;        // 0x0
        public static Cinemachine.CinemachineCore.Stage Aim;        // 0x0
        public static Cinemachine.CinemachineCore.Stage Noise;        // 0x0
        public static Cinemachine.CinemachineCore.Stage Finalize;        // 0x0

    }

    // TypeToken: 0x200006F
    public class AxisInputDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Single Invoke(System.String axisName) { }

    }

    // TypeToken: 0x2000070
    public class GetBlendOverrideDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private Cinemachine.CinemachineBlendDefinition Invoke(Cinemachine.ICinemachineCamera fromVcam, Cinemachine.ICinemachineCamera toVcam, Cinemachine.CinemachineBlendDefinition defaultBlend, UnityEngine.MonoBehaviour owner) { }

    }

    // TypeToken: 0x2000071
    public class UpdateStatus
    {
        // Fields
        public System.Int32 lastUpdateFrame;        // 0x10
        public System.Int32 lastUpdateFixedFrame;        // 0x14
        public Cinemachine.UpdateTracker.UpdateClock lastUpdateMode;        // 0x18
        public System.Single lastUpdateDeltaTime;        // 0x1C

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000072
    public struct UpdateFilter
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachineCore.UpdateFilter Fixed;        // 0x0
        public static Cinemachine.CinemachineCore.UpdateFilter Late;        // 0x0
        public static Cinemachine.CinemachineCore.UpdateFilter Smart;        // 0x0
        public static Cinemachine.CinemachineCore.UpdateFilter SmartFixed;        // 0x0
        public static Cinemachine.CinemachineCore.UpdateFilter SmartLate;        // 0x0

    }

    // TypeToken: 0x2000076
    public class Appearance
    {
        // Fields
        public UnityEngine.Color pathColor;        // 0x10
        public UnityEngine.Color inactivePathColor;        // 0x20
        public System.Single width;        // 0x30

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000077
    public struct PositionUnits
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachinePathBase.PositionUnits PathUnits;        // 0x0
        public static Cinemachine.CinemachinePathBase.PositionUnits Distance;        // 0x0
        public static Cinemachine.CinemachinePathBase.PositionUnits Normalized;        // 0x0

    }

    // TypeToken: 0x2000082
    public struct Level
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.DocumentationSortingAttribute.Level Undoc;        // 0x0
        public static Cinemachine.DocumentationSortingAttribute.Level API;        // 0x0
        public static Cinemachine.DocumentationSortingAttribute.Level UserRef;        // 0x0

    }

    // TypeToken: 0x2000084
    public struct StandbyUpdateMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachineVirtualCameraBase.StandbyUpdateMode Never;        // 0x0
        public static Cinemachine.CinemachineVirtualCameraBase.StandbyUpdateMode Always;        // 0x0
        public static Cinemachine.CinemachineVirtualCameraBase.StandbyUpdateMode RoundRobin;        // 0x0

    }

    // TypeToken: 0x2000085
    public struct BlendHint
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachineVirtualCameraBase.BlendHint None;        // 0x0
        public static Cinemachine.CinemachineVirtualCameraBase.BlendHint SphericalPosition;        // 0x0
        public static Cinemachine.CinemachineVirtualCameraBase.BlendHint CylindricalPosition;        // 0x0
        public static Cinemachine.CinemachineVirtualCameraBase.BlendHint ScreenSpaceAimWhenTargetsDiffer;        // 0x0

    }

    // TypeToken: 0x2000086
    public struct TransitionParams
    {
        // Fields
        public Cinemachine.CinemachineVirtualCameraBase.BlendHint m_BlendHint;        // 0x10
        public System.Boolean m_InheritPosition;        // 0x14
        public Cinemachine.CinemachineBrain.VcamActivatedEvent m_OnCameraLive;        // 0x18

    }

    // TypeToken: 0x2000089
    public class BakedSolution
    {
        // Fields
        private readonly System.Single <FrustumHeight>k__BackingField;        // 0x10
        private System.Single m_frustumSizeIntSpace;        // 0x14
        private readonly Cinemachine.ConfinerOven.AspectStretcher m_AspectStretcher;        // 0x18
        private readonly System.Boolean m_HasBones;        // 0x24
        private readonly System.Double m_SqrPolygonDiagonal;        // 0x28
        private System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> m_OriginalPolygon;        // 0x30
        public System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> m_Solution;        // 0x38

        // Methods
        private System.Single get_FrustumHeight() { }
        private System.Void .ctor(System.Single aspectRatio, System.Single frustumHeight, System.Boolean hasBones, UnityEngine.Rect polygonBounds, System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> originalPolygon, System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> solution) { }
        private System.Boolean IsValid(System.Single frustumHeight) { }
        private UnityEngine.Vector2 ConfinePoint(UnityEngine.Vector2& pointToConfine) { }
        private System.Boolean IsInsideOriginal(ClipperLib.IntPoint p) { }
        private System.Single ClosestPointOnSegment(ClipperLib.IntPoint p, ClipperLib.IntPoint s0, ClipperLib.IntPoint s1) { }
        private ClipperLib.IntPoint IntPointLerp(ClipperLib.IntPoint a, ClipperLib.IntPoint b, System.Single lerp) { }
        private System.Boolean DoesIntersectOriginal(ClipperLib.IntPoint l1, ClipperLib.IntPoint l2) { }
        private System.Int32 FindIntersection(ClipperLib.IntPoint& p1, ClipperLib.IntPoint& p2, ClipperLib.IntPoint& p3, ClipperLib.IntPoint& p4) { }
        private System.Double IntPointDiffSqrMagnitude(ClipperLib.IntPoint p1, ClipperLib.IntPoint p2) { }

    }

    // TypeToken: 0x200008A
    public struct AspectStretcher
    {
        // Fields
        private readonly System.Single <Aspect>k__BackingField;        // 0x10
        private readonly System.Single m_InverseAspect;        // 0x14
        private readonly System.Single m_CenterX;        // 0x18

        // Methods
        private System.Single get_Aspect() { }
        private System.Void .ctor(System.Single aspect, System.Single centerX) { }
        private UnityEngine.Vector2 Stretch(UnityEngine.Vector2 p) { }
        private UnityEngine.Vector2 Unstretch(UnityEngine.Vector2 p) { }

    }

    // TypeToken: 0x200008B
    public struct PolygonSolution
    {
        // Fields
        public System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> m_Polygons;        // 0x10
        public System.Single m_FrustumHeight;        // 0x18

        // Methods
        private System.Boolean StateChanged(System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>>& paths) { }
        private System.Boolean get_IsEmpty() { }

    }

    // TypeToken: 0x200008C
    public struct BakingState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.ConfinerOven.BakingState BAKING;        // 0x0
        public static Cinemachine.ConfinerOven.BakingState BAKED;        // 0x0
        public static Cinemachine.ConfinerOven.BakingState TIMEOUT;        // 0x0

    }

    // TypeToken: 0x200008D
    public struct BakingStateCache
    {
        // Fields
        public ClipperLib.ClipperOffset offsetter;        // 0x10
        public System.Collections.Generic.List<Cinemachine.ConfinerOven.PolygonSolution> solutions;        // 0x18
        public Cinemachine.ConfinerOven.PolygonSolution rightCandidate;        // 0x20
        public Cinemachine.ConfinerOven.PolygonSolution leftCandidate;        // 0x30
        public System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> maxCandidate;        // 0x40
        public System.Single stepSize;        // 0x48
        public System.Single maxFrustumHeight;        // 0x4C
        public System.Single currentFrustumHeight;        // 0x50
        public System.Single bakeTime;        // 0x54

    }

    // TypeToken: 0x2000090
    public struct OverrideModes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.LensSettings.OverrideModes None;        // 0x0
        public static Cinemachine.LensSettings.OverrideModes Orthographic;        // 0x0
        public static Cinemachine.LensSettings.OverrideModes Perspective;        // 0x0
        public static Cinemachine.LensSettings.OverrideModes Physical;        // 0x0

    }

    // TypeToken: 0x2000092
    public struct NoiseParams
    {
        // Fields
        public System.Single Frequency;        // 0x10
        public System.Single Amplitude;        // 0x14
        public System.Boolean Constant;        // 0x18

        // Methods
        private System.Single GetValueAt(System.Single time, System.Single timeOffset) { }

    }

    // TypeToken: 0x2000093
    public struct TransformNoiseParams
    {
        // Fields
        public Cinemachine.NoiseSettings.NoiseParams X;        // 0x10
        public Cinemachine.NoiseSettings.NoiseParams Y;        // 0x1C
        public Cinemachine.NoiseSettings.NoiseParams Z;        // 0x28

        // Methods
        private UnityEngine.Vector3 GetValueAt(System.Single time, UnityEngine.Vector3 timeOffsets) { }

    }

    // TypeToken: 0x2000095
    public class OverlapSphereNonAllocDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Int32 Invoke(UnityEngine.Vector3 position, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }

    }

    // TypeToken: 0x2000096
    public class RaycastDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(UnityEngine.Ray ray, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }

    }

    // TypeToken: 0x2000097
    public class RaycastNonAllocDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Int32 Invoke(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }

    }

    // TypeToken: 0x2000098
    public class SphereCastNonAllocDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Int32 Invoke(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }

    }

    // TypeToken: 0x2000099
    public class ComputePenetrationDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(UnityEngine.ECSColliderResultProxy colliderA, UnityEngine.Vector3 positionA, UnityEngine.Quaternion rotationA, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance) { }

    }

    // TypeToken: 0x200009D
    public struct Mode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.TargetPositionCache.Mode Disabled;        // 0x0
        public static Cinemachine.TargetPositionCache.Mode Record;        // 0x0
        public static Cinemachine.TargetPositionCache.Mode Playback;        // 0x0

    }

    // TypeToken: 0x200009F
    public struct Item
    {
        // Fields
        public UnityEngine.Vector3 Pos;        // 0x10
        public UnityEngine.Quaternion Rot;        // 0x1C

        // Methods
        private Cinemachine.TargetPositionCache.CacheCurve.Item Lerp(Cinemachine.TargetPositionCache.CacheCurve.Item a, Cinemachine.TargetPositionCache.CacheCurve.Item b, System.Single t) { }
        private Cinemachine.TargetPositionCache.CacheCurve.Item get_Empty() { }

    }

    // TypeToken: 0x200009E
    public class CacheCurve
    {
        // Fields
        public System.Single StartTime;        // 0x10
        public System.Single StepSize;        // 0x14
        private System.Collections.Generic.List<Cinemachine.TargetPositionCache.CacheCurve.Item> m_Cache;        // 0x18

        // Methods
        private Cinemachine.TargetPositionCache.CacheCurve.Item Evaluate(System.Single time) { }

    }

    // TypeToken: 0x20000A1
    public struct RecordingItem
    {
        // Fields
        public System.Single Time;        // 0x10
        public System.Boolean IsCut;        // 0x14
        public Cinemachine.TargetPositionCache.CacheCurve.Item Item;        // 0x18

    }

    // TypeToken: 0x20000A0
    public class CacheEntry
    {
        // Fields
        public Cinemachine.TargetPositionCache.CacheCurve Curve;        // 0x10
        private System.Collections.Generic.List<Cinemachine.TargetPositionCache.CacheEntry.RecordingItem> RawItems;        // 0x18

        // Methods
        private System.Void AddRawItem(System.Single time, System.Boolean isCut, UnityEngine.Transform target) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A2
    public struct TimeRange
    {
        // Fields
        public System.Single Start;        // 0x10
        public System.Single End;        // 0x14

        // Methods
        private System.Boolean get_IsEmpty() { }
        private System.Boolean Contains(System.Single time) { }
        private Cinemachine.TargetPositionCache.TimeRange get_Empty() { }
        private System.Void Include(System.Single time) { }

    }

    // TypeToken: 0x20000A4
    public struct UpdateClock
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.UpdateTracker.UpdateClock Fixed;        // 0x0
        public static Cinemachine.UpdateTracker.UpdateClock Late;        // 0x0

    }

    // TypeToken: 0x20000A5
    public class UpdateStatus
    {
        // Fields
        private System.Int32 windowStart;        // 0x10
        private System.Int32 numWindowLateUpdateMoves;        // 0x14
        private System.Int32 numWindowFixedUpdateMoves;        // 0x18
        private System.Int32 numWindows;        // 0x1C
        private System.Int32 lastFrameUpdated;        // 0x20
        private UnityEngine.Matrix4x4 lastPos;        // 0x24
        private Cinemachine.UpdateTracker.UpdateClock <PreferredUpdate>k__BackingField;        // 0x64

        // Methods
        private Cinemachine.UpdateTracker.UpdateClock get_PreferredUpdate() { }
        private System.Void set_PreferredUpdate(Cinemachine.UpdateTracker.UpdateClock value) { }
        private System.Void .ctor(System.Int32 currentFrame, UnityEngine.Matrix4x4 pos) { }
        private System.Void OnUpdate(System.Int32 currentFrame, Cinemachine.UpdateTracker.UpdateClock currentClock, UnityEngine.Matrix4x4 pos) { }

    }

    // TypeToken: 0x20000AA
    public struct Mode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachineTriggerAction.ActionSettings.Mode Custom;        // 0x0
        public static Cinemachine.CinemachineTriggerAction.ActionSettings.Mode PriorityBoost;        // 0x0
        public static Cinemachine.CinemachineTriggerAction.ActionSettings.Mode Activate;        // 0x0
        public static Cinemachine.CinemachineTriggerAction.ActionSettings.Mode Deactivate;        // 0x0
        public static Cinemachine.CinemachineTriggerAction.ActionSettings.Mode Enable;        // 0x0
        public static Cinemachine.CinemachineTriggerAction.ActionSettings.Mode Disable;        // 0x0
        public static Cinemachine.CinemachineTriggerAction.ActionSettings.Mode Play;        // 0x0
        public static Cinemachine.CinemachineTriggerAction.ActionSettings.Mode Stop;        // 0x0

    }

    // TypeToken: 0x20000AB
    public class TriggerEvent : UnityEvent
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000AC
    public struct TimeMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachineTriggerAction.ActionSettings.TimeMode FromStart;        // 0x0
        public static Cinemachine.CinemachineTriggerAction.ActionSettings.TimeMode FromEnd;        // 0x0
        public static Cinemachine.CinemachineTriggerAction.ActionSettings.TimeMode BeforeNow;        // 0x0
        public static Cinemachine.CinemachineTriggerAction.ActionSettings.TimeMode AfterNow;        // 0x0

    }

    // TypeToken: 0x20000A9
    public struct ActionSettings
    {
        // Fields
        public Cinemachine.CinemachineTriggerAction.ActionSettings.Mode m_Action;        // 0x10
        public UnityEngine.Object m_Target;        // 0x18
        public System.Int32 m_BoostAmount;        // 0x20
        public System.Single m_StartTime;        // 0x24
        public Cinemachine.CinemachineTriggerAction.ActionSettings.TimeMode m_Mode;        // 0x28
        public Cinemachine.CinemachineTriggerAction.ActionSettings.TriggerEvent m_Event;        // 0x30

        // Methods
        private System.Void .ctor(Cinemachine.CinemachineTriggerAction.ActionSettings.Mode action) { }
        private System.Void Invoke() { }

    }

    // TypeToken: 0x20000B1
    public struct ImpulseShapes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachineImpulseDefinition.ImpulseShapes Custom;        // 0x0
        public static Cinemachine.CinemachineImpulseDefinition.ImpulseShapes Recoil;        // 0x0
        public static Cinemachine.CinemachineImpulseDefinition.ImpulseShapes Bump;        // 0x0
        public static Cinemachine.CinemachineImpulseDefinition.ImpulseShapes Explosion;        // 0x0
        public static Cinemachine.CinemachineImpulseDefinition.ImpulseShapes Rumble;        // 0x0

    }

    // TypeToken: 0x20000B2
    public struct ImpulseTypes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachineImpulseDefinition.ImpulseTypes Uniform;        // 0x0
        public static Cinemachine.CinemachineImpulseDefinition.ImpulseTypes Dissipating;        // 0x0
        public static Cinemachine.CinemachineImpulseDefinition.ImpulseTypes Propagating;        // 0x0
        public static Cinemachine.CinemachineImpulseDefinition.ImpulseTypes Legacy;        // 0x0

    }

    // TypeToken: 0x20000B3
    public struct RepeatMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachineImpulseDefinition.RepeatMode Stretch;        // 0x0
        public static Cinemachine.CinemachineImpulseDefinition.RepeatMode Loop;        // 0x0

    }

    // TypeToken: 0x20000B4
    public class SignalSource, ISignalSource6D
    {
        // Fields
        private Cinemachine.CinemachineImpulseDefinition m_Def;        // 0x10
        private UnityEngine.Vector3 m_Velocity;        // 0x18

        // Methods
        private System.Void .ctor(Cinemachine.CinemachineImpulseDefinition def, UnityEngine.Vector3 velocity) { }
        private System.Single get_SignalDuration() { }
        private System.Void GetSignal(System.Single timeSinceSignalStart, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot) { }

    }

    // TypeToken: 0x20000B5
    public class LegacySignalSource, ISignalSource6D
    {
        // Fields
        private Cinemachine.CinemachineImpulseDefinition m_Def;        // 0x10
        private UnityEngine.Vector3 m_Velocity;        // 0x18
        private System.Single m_StartTimeOffset;        // 0x24

        // Methods
        private System.Void .ctor(Cinemachine.CinemachineImpulseDefinition def, UnityEngine.Vector3 velocity) { }
        private System.Single get_SignalDuration() { }
        private System.Void GetSignal(System.Single timeSinceSignalStart, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot) { }

    }

    // TypeToken: 0x20000B7
    public struct ImpulseReaction
    {
        // Fields
        public Cinemachine.NoiseSettings m_SecondaryNoise;        // 0x10
        public System.Single m_AmplitudeGain;        // 0x18
        public System.Single m_FrequencyGain;        // 0x1C
        public System.Single m_Duration;        // 0x20
        private System.Single m_CurrentAmount;        // 0x24
        private System.Single m_CurrentTime;        // 0x28
        private System.Single m_CurrentDamping;        // 0x2C
        private System.Boolean m_Initialized;        // 0x30
        private UnityEngine.Vector3 m_NoiseOffsets;        // 0x34

        // Methods
        private System.Void ReSeed() { }
        private System.Boolean GetReaction(System.Single deltaTime, UnityEngine.Vector3 impulsePos, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot) { }

    }

    // TypeToken: 0x20000BA
    public struct EnvelopeDefinition
    {
        // Fields
        public UnityEngine.AnimationCurve m_AttackShape;        // 0x10
        public UnityEngine.AnimationCurve m_DecayShape;        // 0x18
        public System.Single m_AttackTime;        // 0x20
        public System.Single m_SustainTime;        // 0x24
        public System.Single m_DecayTime;        // 0x28
        public System.Boolean m_ScaleWithImpact;        // 0x2C
        public System.Boolean m_HoldForever;        // 0x2D

        // Methods
        private Cinemachine.CinemachineImpulseManager.EnvelopeDefinition Default() { }
        private System.Single get_Duration() { }
        private System.Single GetValueAt(System.Single offset) { }
        private System.Void ChangeStopTime(System.Single offset, System.Boolean forceNoDecay) { }
        private System.Void Clear() { }
        private System.Void Validate() { }

    }

    // TypeToken: 0x20000BC
    public struct DirectionMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachineImpulseManager.ImpulseEvent.DirectionMode Fixed;        // 0x0
        public static Cinemachine.CinemachineImpulseManager.ImpulseEvent.DirectionMode RotateTowardSource;        // 0x0

    }

    // TypeToken: 0x20000BD
    public struct DissipationMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Cinemachine.CinemachineImpulseManager.ImpulseEvent.DissipationMode LinearDecay;        // 0x0
        public static Cinemachine.CinemachineImpulseManager.ImpulseEvent.DissipationMode SoftDecay;        // 0x0
        public static Cinemachine.CinemachineImpulseManager.ImpulseEvent.DissipationMode ExponentialDecay;        // 0x0

    }

    // TypeToken: 0x20000BB
    public class ImpulseEvent
    {
        // Fields
        public System.Single m_StartTime;        // 0x10
        public Cinemachine.CinemachineImpulseManager.EnvelopeDefinition m_Envelope;        // 0x18
        public Cinemachine.ISignalSource6D m_SignalSource;        // 0x38
        public UnityEngine.Vector3 m_Position;        // 0x40
        public System.Single m_Radius;        // 0x4C
        public Cinemachine.CinemachineImpulseManager.ImpulseEvent.DirectionMode m_DirectionMode;        // 0x50
        public System.Int32 m_Channel;        // 0x54
        public Cinemachine.CinemachineImpulseManager.ImpulseEvent.DissipationMode m_DissipationMode;        // 0x58
        public System.Single m_DissipationDistance;        // 0x5C
        public System.Single m_CustomDissipation;        // 0x60
        public System.Single m_PropagationSpeed;        // 0x64
        public System.Boolean m_IgnoreDistance;        // 0x68

        // Methods
        private System.Boolean get_Expired() { }
        private System.Void Cancel(System.Single time, System.Boolean forceNoDecay) { }
        private System.Single DistanceDecay(System.Single distance) { }
        private System.Boolean GetDecayedSignal(UnityEngine.Vector3 listenerPosition, System.Boolean use2D, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot) { }
        private System.Void Clear() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C3
    public class OnGUIDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }

    }

    // TypeToken: 0x20000C7
    public struct Item
    {
        // Fields
        public UnityEngine.Vector3 velocity;        // 0x10
        public System.Single weight;        // 0x1C
        public System.Single time;        // 0x20

    }

    // TypeToken: 0x20000CC
    public struct __StaticArrayInitTypeSize=12
    {
    }

namespace Cinemachine
{

    // TypeToken: 0x200000A
    public class Cinemachine3rdPersonAim : CinemachineExtension
    {
        // Fields
        public UnityEngine.LayerMask AimCollisionFilter;        // 0x28
        public System.String IgnoreTag;        // 0x30
        public System.Single AimDistance;        // 0x38
        public UnityEngine.RectTransform AimTargetReticle;        // 0x40
        private UnityEngine.Vector3 <AimTarget>k__BackingField;        // 0x48

        // Methods
        private UnityEngine.Vector3 get_AimTarget() { }
        private System.Void set_AimTarget(UnityEngine.Vector3 value) { }
        private System.Void OnValidate() { }
        private System.Void Reset() { }
        private System.Boolean OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        private System.Void DrawReticle(Cinemachine.CinemachineBrain brain) { }
        private UnityEngine.Vector3 ComputeLookAtPoint(UnityEngine.Vector3 camPos, UnityEngine.Transform player) { }
        private UnityEngine.Vector3 ComputeAimTarget(UnityEngine.Vector3 cameraLookAt, UnityEngine.Transform player) { }
        private System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000B
    public class CinemachineBlendListCamera : CinemachineVirtualCameraBase
    {
        // Fields
        public UnityEngine.Transform m_LookAt;        // 0xA8
        public UnityEngine.Transform m_Follow;        // 0xB0
        public System.Boolean m_ShowDebugText;        // 0xB8
        public System.Boolean m_Loop;        // 0xB9
        private Cinemachine.CinemachineVirtualCameraBase[] m_ChildCameras;        // 0xC0
        public Cinemachine.CinemachineBlendListCamera.Instruction[] m_Instructions;        // 0xC8
        private Cinemachine.ICinemachineCamera <LiveChild>k__BackingField;        // 0xD0
        private Cinemachine.ICinemachineCamera m_TransitioningFrom;        // 0xD8
        private Cinemachine.CameraState m_State;        // 0xE0
        private System.Single mActivationTime;        // 0x1F0
        private System.Int32 mCurrentInstruction;        // 0x1F4
        private Cinemachine.CinemachineBlend mActiveBlend;        // 0x1F8

        // Methods
        private System.String get_Description() { }
        private System.Void Reset() { }
        private Cinemachine.ICinemachineCamera get_LiveChild() { }
        private System.Void set_LiveChild(Cinemachine.ICinemachineCamera value) { }
        private System.Boolean IsLiveChild(Cinemachine.ICinemachineCamera vcam, System.Boolean dominantChildOnly) { }
        private Cinemachine.CameraState get_State() { }
        private UnityEngine.Transform get_LookAt() { }
        private System.Void set_LookAt(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_Follow() { }
        private System.Void set_Follow(UnityEngine.Transform value) { }
        private System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta) { }
        private System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        private System.Void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        private System.Void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnTransformChildrenChanged() { }
        private System.Void OnGuiHandler() { }
        private Cinemachine.CinemachineVirtualCameraBase[] get_ChildCameras() { }
        private System.Boolean get_IsBlending() { }
        private System.Void InvalidateListOfChildren() { }
        private System.Void UpdateListOfChildren() { }
        private System.Void ValidateInstructions() { }
        private System.Void AdvanceCurrentInstruction(System.Single deltaTime) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000D
    public class CinemachineBrain : MonoBehaviour
    {
        // Fields
        public System.Boolean m_ShowDebugText;        // 0x18
        public System.Boolean m_ShowCameraFrustum;        // 0x19
        public System.Boolean m_IgnoreTimeScale;        // 0x1A
        public UnityEngine.Transform m_WorldUpOverride;        // 0x20
        public Cinemachine.CinemachineBrain.UpdateMethod m_UpdateMethod;        // 0x28
        public Cinemachine.CinemachineBrain.BrainUpdateMethod m_BlendUpdateMethod;        // 0x2C
        public Cinemachine.CinemachineBlendDefinition m_DefaultBlend;        // 0x30
        public Cinemachine.CinemachineBlenderSettings m_CustomBlends;        // 0x48
        private UnityEngine.Camera m_OutputCamera;        // 0x50
        private HG.Rendering.Runtime.HGDepthOfField m_OutputDOF;        // 0x58
        public Cinemachine.CinemachineBrain.BrainEvent m_CameraCutEvent;        // 0x60
        public Cinemachine.CinemachineBrain.VcamActivatedEvent m_CameraActivatedEvent;        // 0x68
        private static Cinemachine.ICinemachineCamera mSoloCamera;        // 0x0
        private UnityEngine.Coroutine mPhysicsCoroutine;        // 0x70
        private System.Int32 m_LastFrameUpdated;        // 0x78
        private UnityEngine.WaitForFixedUpdate mWaitForFixedUpdate;        // 0x80
        private System.Collections.Generic.List<Cinemachine.CinemachineBrain.BrainFrame> mFrameStack;        // 0x88
        private System.Int32 mNextFrameId;        // 0x90
        private Cinemachine.CinemachineBlend mCurrentLiveCameras;        // 0x98
        private static readonly UnityEngine.AnimationCurve mDefaultLinearAnimationCurve;        // 0x8
        private Cinemachine.ICinemachineCamera mActiveCameraPreviousFrame;        // 0xA0
        private UnityEngine.GameObject mActiveCameraPreviousFrameGameObject;        // 0xA8
        private Cinemachine.CameraState <CurrentCameraState>k__BackingField;        // 0xB0

        // Methods
        private UnityEngine.Camera get_OutputCamera() { }
        private HG.Rendering.Runtime.HGDepthOfField get_OutputDOF() { }
        private Cinemachine.ICinemachineCamera get_SoloCamera() { }
        private System.Void set_SoloCamera(Cinemachine.ICinemachineCamera value) { }
        private UnityEngine.Color GetSoloGUIColor() { }
        private UnityEngine.Vector3 get_DefaultWorldUp() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode) { }
        private System.Void OnSceneUnloaded(UnityEngine.SceneManagement.Scene scene) { }
        private System.Void Start() { }
        private System.Void OnGuiHandler() { }
        private System.Collections.IEnumerator AfterPhysics() { }
        private System.Void LateUpdate() { }
        private System.Void ManualUpdate(System.Single deltaTime) { }
        private System.Single GetEffectiveDeltaTime(System.Boolean fixedDelta) { }
        private System.Void UpdateVirtualCameras(Cinemachine.CinemachineCore.UpdateFilter updateFilter, System.Single deltaTime) { }
        private Cinemachine.ICinemachineCamera get_ActiveVirtualCamera() { }
        private Cinemachine.ICinemachineCamera DeepCamBFromBlend(Cinemachine.CinemachineBlend blend) { }
        private System.Boolean IsLiveInBlend(Cinemachine.ICinemachineCamera vcam) { }
        private System.Boolean get_IsBlending() { }
        private Cinemachine.CinemachineBlend get_ActiveBlend() { }
        private System.Int32 GetBrainFrame(System.Int32 withId) { }
        private System.Int32 SetCameraOverride(System.Int32 overrideId, Cinemachine.ICinemachineCamera camA, Cinemachine.ICinemachineCamera camB, System.Single weightB, System.Single deltaTime) { }
        private System.Void ReleaseCameraOverride(System.Int32 overrideId) { }
        private System.Void ProcessActiveCamera(System.Single deltaTime) { }
        private System.Void UpdateFrame0(System.Single deltaTime) { }
        private System.Void ComputeCurrentBlend(Cinemachine.CinemachineBlend& outputBlend, System.Int32 numTopLayersToExclude) { }
        private System.Boolean IsLive(Cinemachine.ICinemachineCamera vcam, System.Boolean dominantChildOnly) { }
        private Cinemachine.CameraState get_CurrentCameraState() { }
        private System.Void set_CurrentCameraState(Cinemachine.CameraState value) { }
        private Cinemachine.ICinemachineCamera TopCameraFromPriorityQueue() { }
        private Cinemachine.CinemachineBlendDefinition LookupBlend(Cinemachine.ICinemachineCamera fromKey, Cinemachine.ICinemachineCamera toKey) { }
        private System.Void PushStateToUnityCamera(Cinemachine.CameraState& state) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000014
    public class CinemachineClearShot : CinemachineVirtualCameraBase
    {
        // Fields
        public UnityEngine.Transform m_LookAt;        // 0xA8
        public UnityEngine.Transform m_Follow;        // 0xB0
        public System.Boolean m_ShowDebugText;        // 0xB8
        private Cinemachine.CinemachineVirtualCameraBase[] m_ChildCameras;        // 0xC0
        public System.Single m_ActivateAfter;        // 0xC8
        public System.Single m_MinDuration;        // 0xCC
        public System.Boolean m_RandomizeChoice;        // 0xD0
        public Cinemachine.CinemachineBlendDefinition m_DefaultBlend;        // 0xD8
        public Cinemachine.CinemachineBlenderSettings m_CustomBlends;        // 0xF0
        private Cinemachine.ICinemachineCamera <LiveChild>k__BackingField;        // 0xF8
        private Cinemachine.CameraState m_State;        // 0x100
        private System.Single mActivationTime;        // 0x210
        private System.Single mPendingActivationTime;        // 0x214
        private Cinemachine.ICinemachineCamera mPendingCamera;        // 0x218
        private Cinemachine.CinemachineBlend mActiveBlend;        // 0x220
        private System.Boolean mRandomizeNow;        // 0x228
        private Cinemachine.CinemachineVirtualCameraBase[] m_RandomizedChilden;        // 0x230
        private Cinemachine.ICinemachineCamera m_TransitioningFrom;        // 0x238

        // Methods
        private System.String get_Description() { }
        private Cinemachine.ICinemachineCamera get_LiveChild() { }
        private System.Void set_LiveChild(Cinemachine.ICinemachineCamera value) { }
        private Cinemachine.CameraState get_State() { }
        private System.Boolean IsLiveChild(Cinemachine.ICinemachineCamera vcam, System.Boolean dominantChildOnly) { }
        private UnityEngine.Transform get_LookAt() { }
        private System.Void set_LookAt(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_Follow() { }
        private System.Void set_Follow(UnityEngine.Transform value) { }
        private System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta) { }
        private System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        private System.Void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnTransformChildrenChanged() { }
        private System.Void OnGuiHandler() { }
        private System.Boolean get_IsBlending() { }
        private Cinemachine.CinemachineVirtualCameraBase[] get_ChildCameras() { }
        private System.Void InvalidateListOfChildren() { }
        private System.Void ResetRandomization() { }
        private System.Void UpdateListOfChildren() { }
        private Cinemachine.ICinemachineCamera ChooseCurrentCamera(UnityEngine.Vector3 worldUp) { }
        private Cinemachine.CinemachineVirtualCameraBase[] Randomize(Cinemachine.CinemachineVirtualCameraBase[] src) { }
        private Cinemachine.CinemachineBlendDefinition LookupBlend(Cinemachine.ICinemachineCamera fromKey, Cinemachine.ICinemachineCamera toKey) { }
        private System.Void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000017
    public class CinemachineCollider : CinemachineExtension
    {
        // Fields
        public UnityEngine.LayerMask m_CollideAgainst;        // 0x28
        public System.String m_IgnoreTag;        // 0x30
        public UnityEngine.LayerMask m_TransparentLayers;        // 0x38
        public System.Single m_MinimumDistanceFromTarget;        // 0x3C
        public System.Boolean m_AvoidObstacles;        // 0x40
        public System.Single m_DistanceLimit;        // 0x44
        public System.Single m_MinimumOcclusionTime;        // 0x48
        public System.Single m_CameraRadius;        // 0x4C
        public Cinemachine.CinemachineCollider.ResolutionStrategy m_Strategy;        // 0x50
        public System.Boolean m_UseFollowInsteadOfLookAt;        // 0x54
        public System.Int32 m_MaximumEffort;        // 0x58
        public System.Single m_SmoothingTime;        // 0x5C
        public System.Single m_Damping;        // 0x60
        public System.Single m_DampingWhenOccluded;        // 0x64
        public System.Single m_OptimalTargetDistance;        // 0x68
        private static System.Single k_PrecisionSlush;        // 0x0
        private UnityEngine.RaycastHit[] m_CornerBuffer;        // 0x70
        private static System.Single k_AngleThreshold;        // 0x0
        private static UnityEngine.ECSColliderResultProxy[] s_ColliderBuffer;        // 0x0

        // Methods
        private System.Boolean IsTargetObscured(Cinemachine.ICinemachineCamera vcam) { }
        private System.Boolean CameraWasDisplaced(Cinemachine.ICinemachineCamera vcam) { }
        private System.Single GetCameraDisplacementDistance(Cinemachine.ICinemachineCamera vcam) { }
        private System.Void OnValidate() { }
        private System.Void OnDestroy() { }
        private System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector3>> get_DebugPaths() { }
        private System.Single GetMaxDampTime() { }
        private System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime) { }
        private System.Void ResetExtraData(Cinemachine.ICinemachineCamera vcam) { }
        private System.Void GuardedPostPipelineStageCallback(Cinemachine.ICinemachineCamera vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime) { }
        private UnityEngine.Vector3 PreserveLineOfSight(Cinemachine.CameraState& state, Cinemachine.CinemachineCollider.VcamExtraState& extra) { }
        private UnityEngine.Vector3 PullCameraInFrontOfNearestObstacle(UnityEngine.Vector3 cameraPos, UnityEngine.Vector3 lookAtPos, System.Int32 layerMask, UnityEngine.RaycastHit& hitInfo) { }
        private UnityEngine.Vector3 PushCameraBack(UnityEngine.Vector3 currentPos, UnityEngine.Vector3 pushDir, UnityEngine.RaycastHit obstacle, UnityEngine.Vector3 lookAtPos, UnityEngine.Plane startPlane, System.Single targetDistance, System.Int32 iterations, Cinemachine.CinemachineCollider.VcamExtraState& extra) { }
        private System.Boolean GetWalkingDirection(UnityEngine.Vector3 pos, UnityEngine.Vector3 pushDir, UnityEngine.RaycastHit obstacle, UnityEngine.Vector3& outDir) { }
        private System.Single GetPushBackDistance(UnityEngine.Ray ray, UnityEngine.Plane startPlane, System.Single targetDistance, UnityEngine.Vector3 lookAtPos) { }
        private System.Single ClampRayToBounds(UnityEngine.Ray ray, System.Single distance, UnityEngine.Bounds bounds) { }
        private UnityEngine.Vector3 RespectCameraRadius(UnityEngine.Vector3 cameraPos, UnityEngine.Vector3 lookAtPos) { }
        private System.Boolean CheckForTargetObstructions(Cinemachine.CameraState& state) { }
        private System.Boolean IsTargetOffscreen(Cinemachine.CameraState& state) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200001A
    public class CinemachineConfiner : CinemachineExtension
    {
        // Fields
        public Cinemachine.CinemachineConfiner.Mode m_ConfineMode;        // 0x28
        public UnityEngine.Collider m_BoundingVolume;        // 0x30
        public UnityEngine.Collider2D m_BoundingShape2D;        // 0x38
        private UnityEngine.Collider2D m_BoundingShape2DCache;        // 0x40
        public System.Boolean m_ConfineScreenEdges;        // 0x48
        public System.Single m_Damping;        // 0x4C
        private System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>> m_pathCache;        // 0x50
        private System.Int32 m_pathTotalPointCount;        // 0x58

        // Methods
        private System.Boolean CameraWasDisplaced(Cinemachine.CinemachineVirtualCameraBase vcam) { }
        private System.Single GetCameraDisplacementDistance(Cinemachine.CinemachineVirtualCameraBase vcam) { }
        private System.Void OnValidate() { }
        private System.Void ConnectToVcam(System.Boolean connect) { }
        private System.Boolean get_IsValid() { }
        private System.Single GetMaxDampTime() { }
        private System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime) { }
        private System.Void InvalidatePathCache() { }
        private System.Boolean ValidatePathCache() { }
        private UnityEngine.Vector3 ConfinePoint(UnityEngine.Vector3 camPos) { }
        private UnityEngine.Vector3 ConfineScreenEdges(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CameraState& state) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001D
    public class CinemachineConfiner2D : CinemachineExtension
    {
        // Fields
        public UnityEngine.Collider2D m_BoundingShape2D;        // 0x28
        public System.Single m_Damping;        // 0x30
        public System.Single m_MaxWindowSize;        // 0x34
        private System.Single m_MaxComputationTimePerFrameInSeconds;        // 0x38
        private static System.Single k_cornerAngleTreshold;        // 0x0
        private Cinemachine.CinemachineConfiner2D.ShapeCache m_shapeCache;        // 0x40

        // Methods
        private System.Void InvalidateCache() { }
        private System.Boolean ValidateCache(System.Single cameraAspectRatio) { }
        private System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime) { }
        private System.Single CalculateHalfFrustumHeight(Cinemachine.CameraState& state, System.Single& cameraPosLocalZ) { }
        private System.Void OnValidate() { }
        private System.Void Reset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000020
    public class CinemachineDollyCart : MonoBehaviour
    {
        // Fields
        public Cinemachine.CinemachinePathBase m_Path;        // 0x18
        public System.Boolean forbidRotation;        // 0x20
        public Cinemachine.CinemachineDollyCart.UpdateMethod m_UpdateMethod;        // 0x24
        public Cinemachine.CinemachinePathBase.PositionUnits m_PositionUnits;        // 0x28
        public System.Single m_Speed;        // 0x2C
        public System.Single m_Position;        // 0x30

        // Methods
        private System.Void FixedUpdate() { }
        private System.Void Update() { }
        private System.Void LateUpdate() { }
        private System.Void SetCartPosition(System.Single distanceAlongPath) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000022
    public class CinemachineExternalCamera : CinemachineVirtualCameraBase
    {
        // Fields
        public UnityEngine.Transform m_LookAt;        // 0xA8
        private UnityEngine.Camera m_Camera;        // 0xB0
        private Cinemachine.CameraState m_State;        // 0xB8
        private UnityEngine.Transform <Follow>k__BackingField;        // 0x1C8
        public Cinemachine.CinemachineVirtualCameraBase.BlendHint m_BlendHint;        // 0x1D0

        // Methods
        private Cinemachine.CameraState get_State() { }
        private UnityEngine.Transform get_LookAt() { }
        private System.Void set_LookAt(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_Follow() { }
        private System.Void set_Follow(UnityEngine.Transform value) { }
        private System.Void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000023
    public class CinemachineFollowZoom : CinemachineExtension
    {
        // Fields
        public System.Single m_Width;        // 0x28
        public System.Single m_Damping;        // 0x2C
        public System.Single m_MinFOV;        // 0x30
        public System.Single m_MaxFOV;        // 0x34

        // Methods
        private System.Void OnValidate() { }
        private System.Single GetMaxDampTime() { }
        private System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000025
    public class CinemachineFreeLook : CinemachineVirtualCameraBase
    {
        // Fields
        public UnityEngine.Transform m_LookAt;        // 0xA8
        public UnityEngine.Transform m_Follow;        // 0xB0
        public System.Boolean m_CommonLens;        // 0xB8
        public Cinemachine.LensSettings m_Lens;        // 0xBC
        public Cinemachine.CinemachineVirtualCameraBase.TransitionParams m_Transitions;        // 0xF0
        private Cinemachine.CinemachineVirtualCameraBase.BlendHint m_LegacyBlendHint;        // 0x100
        public Cinemachine.AxisState m_YAxis;        // 0x108
        public Cinemachine.AxisState.Recentering m_YAxisRecentering;        // 0x178
        public Cinemachine.AxisState m_XAxis;        // 0x198
        public Cinemachine.CinemachineOrbitalTransposer.Heading m_Heading;        // 0x208
        public Cinemachine.AxisState.Recentering m_RecenterToTargetHeading;        // 0x214
        public Cinemachine.CinemachineTransposer.BindingMode m_BindingMode;        // 0x230
        public System.Single m_SplineCurvature;        // 0x234
        public Cinemachine.CinemachineFreeLook.Orbit[] m_Orbits;        // 0x238
        private System.Single m_LegacyHeadingBias;        // 0x240
        private System.Boolean mUseLegacyRigDefinitions;        // 0x244
        private System.Boolean mIsDestroyed;        // 0x245
        private Cinemachine.CameraState m_State;        // 0x248
        private Cinemachine.CinemachineVirtualCamera[] m_Rigs;        // 0x358
        private Cinemachine.CinemachineOrbitalTransposer[] mOrbitals;        // 0x360
        private Cinemachine.CinemachineBlend mBlendA;        // 0x368
        private Cinemachine.CinemachineBlend mBlendB;        // 0x370
        public static Cinemachine.CinemachineFreeLook.CreateRigDelegate CreateRigOverride;        // 0x0
        public static Cinemachine.CinemachineFreeLook.DestroyRigDelegate DestroyRigOverride;        // 0x8
        private System.Single m_CachedXAxisHeading;        // 0x378
        private Cinemachine.CinemachineFreeLook.Orbit[] m_CachedOrbits;        // 0x380
        private System.Single m_CachedTension;        // 0x388
        private UnityEngine.Vector4[] m_CachedKnots;        // 0x390
        private UnityEngine.Vector4[] m_CachedCtrl1;        // 0x398
        private UnityEngine.Vector4[] m_CachedCtrl2;        // 0x3A0

        // Methods
        private System.Void OnValidate() { }
        private Cinemachine.CinemachineVirtualCamera GetRig(System.Int32 i) { }
        private System.String[] get_RigNames() { }
        private System.Void OnEnable() { }
        private System.Void UpdateInputAxisProvider() { }
        private System.Void OnDestroy() { }
        private System.Void OnTransformChildrenChanged() { }
        private System.Void Reset() { }
        private System.Boolean get_PreviousStateIsValid() { }
        private System.Void set_PreviousStateIsValid(System.Boolean value) { }
        private Cinemachine.CameraState get_State() { }
        private UnityEngine.Transform get_LookAt() { }
        private System.Void set_LookAt(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_Follow() { }
        private System.Void set_Follow(UnityEngine.Transform value) { }
        private System.Boolean IsLiveChild(Cinemachine.ICinemachineCamera vcam, System.Boolean dominantChildOnly) { }
        private System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta) { }
        private System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        private System.Void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        private System.Void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        private System.Boolean RequiresUserInput() { }
        private System.Single GetYAxisClosestValue(UnityEngine.Vector3 cameraPos, UnityEngine.Vector3 up) { }
        private System.Void InvalidateRigCache() { }
        private System.Void DestroyRigs() { }
        private Cinemachine.CinemachineVirtualCamera[] CreateRigs(Cinemachine.CinemachineVirtualCamera[] copyFrom) { }
        private System.Void UpdateRigCache() { }
        private System.Int32 LocateExistingRigs(System.String[] rigNames, System.Boolean forceOrbital) { }
        private System.Single UpdateXAxisHeading(Cinemachine.CinemachineOrbitalTransposer orbital, System.Single deltaTime, UnityEngine.Vector3 up) { }
        private System.Void PushSettingsToRigs() { }
        private System.Single GetYAxisValue() { }
        private Cinemachine.CameraState CalculateNewState(UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        private UnityEngine.Vector3 GetLocalPositionForCameraFromInput(System.Single t) { }
        private System.Void UpdateCachedSpline() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000029
    public class CinemachineMixingCamera : CinemachineVirtualCameraBase
    {
        // Fields
        public static System.Int32 MaxCameras;        // 0x0
        public System.Single m_Weight0;        // 0xA8
        public System.Single m_Weight1;        // 0xAC
        public System.Single m_Weight2;        // 0xB0
        public System.Single m_Weight3;        // 0xB4
        public System.Single m_Weight4;        // 0xB8
        public System.Single m_Weight5;        // 0xBC
        public System.Single m_Weight6;        // 0xC0
        public System.Single m_Weight7;        // 0xC4
        private Cinemachine.CameraState m_State;        // 0xC8
        private Cinemachine.ICinemachineCamera <LiveChild>k__BackingField;        // 0x1D8
        private UnityEngine.Transform <LookAt>k__BackingField;        // 0x1E0
        private UnityEngine.Transform <Follow>k__BackingField;        // 0x1E8
        private Cinemachine.CinemachineVirtualCameraBase[] m_ChildCameras;        // 0x1F0
        private System.Collections.Generic.Dictionary<Cinemachine.CinemachineVirtualCameraBase,System.Int32> m_indexMap;        // 0x1F8

        // Methods
        private System.Single GetWeight(System.Int32 index) { }
        private System.Void SetWeight(System.Int32 index, System.Single w) { }
        private System.Single GetWeight(Cinemachine.CinemachineVirtualCameraBase vcam) { }
        private System.Void SetWeight(Cinemachine.CinemachineVirtualCameraBase vcam, System.Single w) { }
        private Cinemachine.ICinemachineCamera get_LiveChild() { }
        private System.Void set_LiveChild(Cinemachine.ICinemachineCamera value) { }
        private Cinemachine.CameraState get_State() { }
        private UnityEngine.Transform get_LookAt() { }
        private System.Void set_LookAt(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_Follow() { }
        private System.Void set_Follow(UnityEngine.Transform value) { }
        private System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta) { }
        private System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        private System.Void OnEnable() { }
        private System.Void OnTransformChildrenChanged() { }
        private System.Void OnValidate() { }
        private System.Boolean IsLiveChild(Cinemachine.ICinemachineCamera vcam, System.Boolean dominantChildOnly) { }
        private Cinemachine.CinemachineVirtualCameraBase[] get_ChildCameras() { }
        private System.Void InvalidateListOfChildren() { }
        private System.Void ValidateListOfChildren() { }
        private System.Void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        private System.Void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002A
    public class CinemachinePath : CinemachinePathBase
    {
        // Fields
        public System.Boolean m_Looped;        // 0x48
        public Cinemachine.CinemachinePath.Waypoint[] m_Waypoints;        // 0x50

        // Methods
        private System.Single get_MinPos() { }
        private System.Single get_MaxPos() { }
        private System.Boolean get_Looped() { }
        private System.Void Reset() { }
        private System.Int32 get_DistanceCacheSampleStepsPerSegment() { }
        private System.Single GetBoundingIndices(System.Single pos, System.Int32& indexA, System.Int32& indexB) { }
        private UnityEngine.Vector3 EvaluatePosition(System.Single pos) { }
        private UnityEngine.Vector3 EvaluateTangent(System.Single pos) { }
        private UnityEngine.Quaternion EvaluateOrientation(System.Single pos) { }
        private System.Void OnValidate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002C
    public class CinemachinePipeline : MonoBehaviour
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002D
    public class CinemachinePixelPerfect : MonoBehaviour
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002E
    public class CinemachineSmoothPath : CinemachinePathBase
    {
        // Fields
        public System.Boolean m_Looped;        // 0x48
        public Cinemachine.CinemachineSmoothPath.Waypoint[] m_Waypoints;        // 0x50
        private Cinemachine.CinemachineSmoothPath.Waypoint[] m_ControlPoints1;        // 0x58
        private Cinemachine.CinemachineSmoothPath.Waypoint[] m_ControlPoints2;        // 0x60
        private System.Boolean m_IsLoopedCache;        // 0x68

        // Methods
        private System.Single get_MinPos() { }
        private System.Single get_MaxPos() { }
        private System.Boolean get_Looped() { }
        private System.Int32 get_DistanceCacheSampleStepsPerSegment() { }
        private System.Void OnValidate() { }
        private System.Void Reset() { }
        private System.Void InvalidateDistanceCache() { }
        private System.Void UpdateControlPoints() { }
        private System.Single GetBoundingIndices(System.Single pos, System.Int32& indexA, System.Int32& indexB) { }
        private UnityEngine.Vector3 EvaluatePosition(System.Single pos) { }
        private UnityEngine.Vector3 EvaluateTangent(System.Single pos) { }
        private UnityEngine.Quaternion EvaluateOrientation(System.Single pos) { }
        private UnityEngine.Quaternion RollAroundForward(System.Single angle) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000030
    public class CinemachineStateDrivenCamera : CinemachineVirtualCameraBase
    {
        // Fields
        public UnityEngine.Transform m_LookAt;        // 0xA8
        public UnityEngine.Transform m_Follow;        // 0xB0
        public UnityEngine.Animator m_AnimatedTarget;        // 0xB8
        public System.Int32 m_LayerIndex;        // 0xC0
        public System.Boolean m_ShowDebugText;        // 0xC4
        private Cinemachine.CinemachineVirtualCameraBase[] m_ChildCameras;        // 0xC8
        public Cinemachine.CinemachineStateDrivenCamera.Instruction[] m_Instructions;        // 0xD0
        public Cinemachine.CinemachineBlendDefinition m_DefaultBlend;        // 0xD8
        public Cinemachine.CinemachineBlenderSettings m_CustomBlends;        // 0xF0
        private Cinemachine.CinemachineStateDrivenCamera.ParentHash[] m_ParentHash;        // 0xF8
        private Cinemachine.ICinemachineCamera <LiveChild>k__BackingField;        // 0x100
        private Cinemachine.ICinemachineCamera m_TransitioningFrom;        // 0x108
        private Cinemachine.CameraState m_State;        // 0x110
        private System.Collections.Generic.Dictionary<UnityEngine.AnimationClip,System.Collections.Generic.List<Cinemachine.CinemachineStateDrivenCamera.HashPair>> mHashCache;        // 0x220
        private System.Single mActivationTime;        // 0x228
        private Cinemachine.CinemachineStateDrivenCamera.Instruction mActiveInstruction;        // 0x230
        private System.Single mPendingActivationTime;        // 0x248
        private Cinemachine.CinemachineStateDrivenCamera.Instruction mPendingInstruction;        // 0x250
        private Cinemachine.CinemachineBlend mActiveBlend;        // 0x268
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> mInstructionDictionary;        // 0x270
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> mStateParentLookup;        // 0x278
        private System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> m_clipInfoList;        // 0x280

        // Methods
        private System.String get_Description() { }
        private Cinemachine.ICinemachineCamera get_LiveChild() { }
        private System.Void set_LiveChild(Cinemachine.ICinemachineCamera value) { }
        private System.Boolean IsLiveChild(Cinemachine.ICinemachineCamera vcam, System.Boolean dominantChildOnly) { }
        private Cinemachine.CameraState get_State() { }
        private UnityEngine.Transform get_LookAt() { }
        private System.Void set_LookAt(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_Follow() { }
        private System.Void set_Follow(UnityEngine.Transform value) { }
        private System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta) { }
        private System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        private System.Void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        private System.Void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnTransformChildrenChanged() { }
        private System.Void OnGuiHandler() { }
        private Cinemachine.CinemachineVirtualCameraBase[] get_ChildCameras() { }
        private System.Boolean get_IsBlending() { }
        private System.Int32 CreateFakeHash(System.Int32 parentHash, UnityEngine.AnimationClip clip) { }
        private System.Int32 LookupFakeHash(System.Int32 parentHash, UnityEngine.AnimationClip clip) { }
        private System.Void InvalidateListOfChildren() { }
        private System.Void UpdateListOfChildren() { }
        private System.Void ValidateInstructions() { }
        private Cinemachine.CinemachineVirtualCameraBase ChooseCurrentCamera() { }
        private System.Int32 GetClipHash(System.Int32 hash, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips) { }
        private Cinemachine.CinemachineBlendDefinition LookupBlend(Cinemachine.ICinemachineCamera fromKey, Cinemachine.ICinemachineCamera toKey) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000034
    public class CinemachineStoryboard : CinemachineExtension
    {
        // Fields
        public static System.Boolean s_StoryboardGlobalMute;        // 0x0
        public System.Boolean m_ShowImage;        // 0x28
        public UnityEngine.Texture m_Image;        // 0x30
        public Cinemachine.CinemachineStoryboard.FillStrategy m_Aspect;        // 0x38
        public System.Single m_Alpha;        // 0x3C
        public UnityEngine.Vector2 m_Center;        // 0x40
        public UnityEngine.Vector3 m_Rotation;        // 0x48
        public UnityEngine.Vector2 m_Scale;        // 0x54
        public System.Boolean m_SyncScale;        // 0x5C
        public System.Boolean m_MuteCamera;        // 0x5D
        public System.Single m_SplitView;        // 0x60
        public Cinemachine.CinemachineStoryboard.StoryboardRenderMode m_RenderMode;        // 0x64
        public System.Int32 m_SortingOrder;        // 0x68
        public System.Single m_PlaneDistance;        // 0x6C
        private System.Collections.Generic.List<Cinemachine.CinemachineStoryboard.CanvasInfo> mCanvasInfo;        // 0x70

        // Methods
        private System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime) { }
        private System.Void UpdateRenderCanvas() { }
        private System.Void ConnectToVcam(System.Boolean connect) { }
        private System.String get_CanvasName() { }
        private System.Void CameraUpdatedCallback(Cinemachine.CinemachineBrain brain) { }
        private Cinemachine.CinemachineStoryboard.CanvasInfo LocateMyCanvas(Cinemachine.CinemachineBrain parent, System.Boolean createIfNotFound) { }
        private System.Void CreateCanvas(Cinemachine.CinemachineStoryboard.CanvasInfo ci) { }
        private System.Void DestroyCanvas() { }
        private System.Void PlaceImage(Cinemachine.CinemachineStoryboard.CanvasInfo ci, System.Single alpha) { }
        private System.Void StaticBlendingHandler(Cinemachine.CinemachineBrain brain) { }
        private System.Void InitializeModule() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000038
    public interface ICinemachineTargetGroup
    {
        // Methods
        private UnityEngine.BoundingSphere get_Sphere() { }
        private System.Boolean get_IsEmpty() { }
        private UnityEngine.Bounds GetViewSpaceBoundingBox(UnityEngine.Matrix4x4 observer) { }
        private System.Void GetViewSpaceAngularBounds(UnityEngine.Matrix4x4 observer, UnityEngine.Vector2& minAngles, UnityEngine.Vector2& maxAngles, UnityEngine.Vector2& zRange) { }

    }

    // TypeToken: 0x2000039
    public class CinemachineTargetGroup : MonoBehaviour, ICinemachineTargetGroup
    {
        // Fields
        public Cinemachine.CinemachineTargetGroup.PositionMode m_PositionMode;        // 0x18
        public Cinemachine.CinemachineTargetGroup.RotationMode m_RotationMode;        // 0x1C
        public Cinemachine.CinemachineTargetGroup.UpdateMethod m_UpdateMethod;        // 0x20
        public Cinemachine.CinemachineTargetGroup.Target[] m_Targets;        // 0x28
        private UnityEngine.Bounds <BoundingBox>k__BackingField;        // 0x30
        private System.Single m_MaxWeight;        // 0x48
        private UnityEngine.Vector3 m_AveragePos;        // 0x4C
        private UnityEngine.BoundingSphere m_BoundingSphere;        // 0x58

        // Methods
        private UnityEngine.Transform get_Transform() { }
        private UnityEngine.Bounds get_BoundingBox() { }
        private System.Void set_BoundingBox(UnityEngine.Bounds value) { }
        private UnityEngine.BoundingSphere get_Sphere() { }
        private System.Boolean get_IsEmpty() { }
        private System.Void AddMember(UnityEngine.Transform t, System.Single weight, System.Single radius) { }
        private System.Void RemoveMember(UnityEngine.Transform t) { }
        private System.Int32 FindMember(UnityEngine.Transform t) { }
        private UnityEngine.BoundingSphere GetWeightedBoundsForMember(System.Int32 index) { }
        private UnityEngine.Bounds GetViewSpaceBoundingBox(UnityEngine.Matrix4x4 observer) { }
        private UnityEngine.BoundingSphere WeightedMemberBounds(Cinemachine.CinemachineTargetGroup.Target t, UnityEngine.Vector3 avgPos, System.Single maxWeight) { }
        private System.Void DoUpdate() { }
        private UnityEngine.BoundingSphere CalculateBoundingSphere(System.Single maxWeight) { }
        private UnityEngine.Vector3 CalculateAveragePosition(System.Single& maxWeight) { }
        private UnityEngine.Quaternion CalculateAverageOrientation() { }
        private UnityEngine.Bounds CalculateBoundingBox(UnityEngine.Vector3 avgPos, System.Single maxWeight) { }
        private System.Void OnValidate() { }
        private System.Void FixedUpdate() { }
        private System.Void Update() { }
        private System.Void LateUpdate() { }
        private System.Void GetViewSpaceAngularBounds(UnityEngine.Matrix4x4 observer, UnityEngine.Vector2& minAngles, UnityEngine.Vector2& maxAngles, UnityEngine.Vector2& zRange) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003E
    public class CinemachineVirtualCamera : CinemachineVirtualCameraBase
    {
        // Fields
        public UnityEngine.Transform m_LookAt;        // 0xA8
        public UnityEngine.Transform m_Follow;        // 0xB0
        public Cinemachine.LensSettings m_Lens;        // 0xB8
        public Cinemachine.CinemachineVirtualCameraBase.TransitionParams m_Transitions;        // 0xE8
        private Cinemachine.CinemachineVirtualCameraBase.BlendHint m_LegacyBlendHint;        // 0xF8
        public static System.String PipelineName;        // 0x0
        public static Cinemachine.CinemachineVirtualCamera.CreatePipelineDelegate CreatePipelineOverride;        // 0x0
        public static Cinemachine.CinemachineVirtualCamera.DestroyPipelineDelegate DestroyPipelineOverride;        // 0x8
        private System.Boolean m_UserIsDragging;        // 0xFC
        private Cinemachine.CameraState m_State;        // 0x100
        private Cinemachine.CinemachineComponentBase[] m_ComponentPipeline;        // 0x210
        private UnityEngine.Transform m_ComponentOwner;        // 0x218
        private UnityEngine.Transform mCachedLookAtTarget;        // 0x220
        private Cinemachine.CinemachineVirtualCameraBase mCachedLookAtTargetVcam;        // 0x228

        // Methods
        private Cinemachine.CameraState get_State() { }
        private UnityEngine.Transform get_LookAt() { }
        private System.Void set_LookAt(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_Follow() { }
        private System.Void set_Follow(UnityEngine.Transform value) { }
        private System.Void SetFieldOfView(System.Single fov) { }
        private System.Single GetMaxDampTime() { }
        private System.Void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        private System.Void OnEnable() { }
        private System.Void OnDestroy() { }
        private System.Void OnValidate() { }
        private System.Void OnTransformChildrenChanged() { }
        private System.Void Reset() { }
        private System.Void DestroyPipeline() { }
        private UnityEngine.Transform CreatePipeline(Cinemachine.CinemachineVirtualCamera copyFrom) { }
        private System.Void InvalidateComponentPipeline() { }
        private UnityEngine.Transform GetComponentOwner() { }
        private Cinemachine.CinemachineComponentBase[] GetComponentPipeline() { }
        private Cinemachine.CinemachineComponentBase GetCinemachineComponent(Cinemachine.CinemachineCore.Stage stage) { }
        private T GetCinemachineComponent() { }
        private T AddCinemachineComponent() { }
        private System.Void DestroyCinemachineComponent() { }
        private System.Void UpdateComponentPipeline() { }
        private System.Void SetFlagsForHiddenChild(UnityEngine.GameObject child) { }
        private Cinemachine.CameraState CalculateNewState(UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        private System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta) { }
        private System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        private System.Void SetStateRawPosition(UnityEngine.Vector3 pos) { }
        private System.Void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        private System.Boolean RequiresUserInput() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000042
    public class Cinemachine3rdPersonFollow : CinemachineComponentBase
    {
        // Fields
        public UnityEngine.Vector3 Damping;        // 0x20
        public UnityEngine.Vector3 ShoulderOffset;        // 0x2C
        public System.Single VerticalArmLength;        // 0x38
        public System.Single CameraSide;        // 0x3C
        public System.Single CameraDistance;        // 0x40
        public UnityEngine.LayerMask CameraCollisionFilter;        // 0x44
        public System.String IgnoreTag;        // 0x48
        public System.Single CameraRadius;        // 0x50
        public System.Single DampingIntoCollision;        // 0x54
        public System.Single DampingFromCollision;        // 0x58
        public System.Boolean DisableDampingCorrection;        // 0x5C
        private UnityEngine.Vector3 m_PreviousFollowTargetPosition;        // 0x60
        private UnityEngine.Vector3 m_DampingCorrection;        // 0x6C
        private System.Single m_CamPosCollisionCorrection;        // 0x78

        // Methods
        private System.Void OnValidate() { }
        private System.Void Reset() { }
        private System.Void OnDestroy() { }
        private System.Boolean get_IsValid() { }
        private Cinemachine.CinemachineCore.Stage get_Stage() { }
        private System.Single GetMaxDampTime() { }
        private System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        private System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta) { }
        private System.Void PositionCamera(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        private System.Void GetRigPositions(UnityEngine.Vector3& root, UnityEngine.Vector3& shoulder, UnityEngine.Vector3& hand) { }
        private UnityEngine.Quaternion GetHeading(UnityEngine.Quaternion targetRot, UnityEngine.Vector3 up) { }
        private System.Void GetRawRigPositions(UnityEngine.Vector3 root, UnityEngine.Quaternion targetRot, UnityEngine.Quaternion heading, UnityEngine.Vector3& shoulder, UnityEngine.Vector3& hand) { }
        private UnityEngine.Vector3 BeyondResolveCollisions(UnityEngine.Vector3 root, UnityEngine.Vector3 tip, System.Single cameraRadius) { }
        private UnityEngine.Vector3 ResolveCollisions(UnityEngine.Vector3 root, UnityEngine.Vector3 tip, System.Single deltaTime, System.Single cameraRadius, System.Single& collisionCorrection) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000043
    public class CinemachineBasicMultiChannelPerlin : CinemachineComponentBase
    {
        // Fields
        public Cinemachine.NoiseSettings m_NoiseProfile;        // 0x20
        public UnityEngine.Vector3 m_PivotOffset;        // 0x28
        public System.Single m_AmplitudeGain;        // 0x34
        public System.Single m_FrequencyGain;        // 0x38
        private System.Boolean mInitialized;        // 0x3C
        private System.Single mNoiseTime;        // 0x40
        private UnityEngine.Vector3 mNoiseOffsets;        // 0x44

        // Methods
        private System.Boolean get_IsValid() { }
        private Cinemachine.CinemachineCore.Stage get_Stage() { }
        private System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        private System.Void ReSeed() { }
        private System.Void Initialize() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000044
    public class CinemachineComposer : CinemachineComponentBase
    {
        // Fields
        public UnityEngine.Vector3 m_TrackedObjectOffset;        // 0x20
        public System.Single m_LookaheadTime;        // 0x2C
        public System.Single m_LookaheadSmoothing;        // 0x30
        public System.Boolean m_LookaheadIgnoreY;        // 0x34
        public System.Single m_HorizontalDamping;        // 0x38
        public System.Single m_VerticalDamping;        // 0x3C
        public System.Single m_ScreenX;        // 0x40
        public System.Single m_ScreenY;        // 0x44
        public System.Single m_DeadZoneWidth;        // 0x48
        public System.Single m_DeadZoneHeight;        // 0x4C
        public System.Single m_SoftZoneWidth;        // 0x50
        public System.Single m_SoftZoneHeight;        // 0x54
        public System.Single m_BiasX;        // 0x58
        public System.Single m_BiasY;        // 0x5C
        public System.Boolean m_CenterOnActivate;        // 0x60
        private UnityEngine.Vector3 <TrackedPoint>k__BackingField;        // 0x64
        private UnityEngine.Vector3 m_CameraPosPrevFrame;        // 0x70
        private UnityEngine.Vector3 m_LookAtPrevFrame;        // 0x7C
        private UnityEngine.Vector2 m_ScreenOffsetPrevFrame;        // 0x88
        private UnityEngine.Quaternion m_CameraOrientationPrevFrame;        // 0x90
        private Cinemachine.Utility.PositionPredictor m_Predictor;        // 0xA0
        private Cinemachine.CinemachineComposer.FovCache mCache;        // 0xA8
        private UnityEngine.Vector2 _lastExtra;        // 0xF8
        private UnityEngine.Vector2 _lastOriginalRotToRect;        // 0x100
        public UnityEngine.Vector2 deadZoneDampFactor;        // 0x108

        // Methods
        private System.Boolean get_IsValid() { }
        private Cinemachine.CinemachineCore.Stage get_Stage() { }
        private UnityEngine.Vector3 get_TrackedPoint() { }
        private System.Void set_TrackedPoint(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 GetLookAtPointAndSetTrackedPoint(UnityEngine.Vector3 lookAt, UnityEngine.Vector3 up, System.Single deltaTime) { }
        private System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta) { }
        private System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        private System.Single GetMaxDampTime() { }
        private System.Void PrePipelineMutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        private System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        private UnityEngine.Rect get_SoftGuideRect() { }
        private System.Void set_SoftGuideRect(UnityEngine.Rect value) { }
        private UnityEngine.Rect get_HardGuideRect() { }
        private System.Void set_HardGuideRect(UnityEngine.Rect value) { }
        private System.Void ClearOriginalRotToRect() { }
        private System.Void RotateToScreenBounds(Cinemachine.CameraState& state, UnityEngine.Rect screenRect, UnityEngine.Vector3 trackedPoint, UnityEngine.Quaternion& rigOrientation, System.Single fov, System.Single fovH, System.Single deltaTime) { }
        private System.Boolean ClampVerticalBounds(UnityEngine.Rect& r, UnityEngine.Vector3 dir, UnityEngine.Vector3 up, System.Single fov) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000046
    public class CinemachineFramingTransposer : CinemachineComponentBase
    {
        // Fields
        public UnityEngine.Vector3 m_TrackedObjectOffset;        // 0x20
        public System.Single m_LookaheadTime;        // 0x2C
        public System.Single m_LookaheadSmoothing;        // 0x30
        public System.Boolean m_LookaheadIgnoreY;        // 0x34
        public System.Single m_XDamping;        // 0x38
        public System.Single m_YDamping;        // 0x3C
        public System.Single m_ZDamping;        // 0x40
        public System.Boolean m_TargetMovementOnly;        // 0x44
        public System.Single m_ScreenX;        // 0x48
        public System.Single m_ScreenY;        // 0x4C
        public System.Single m_CameraDistance;        // 0x50
        public System.Single m_DeadZoneWidth;        // 0x54
        public System.Single m_DeadZoneHeight;        // 0x58
        public System.Single m_DeadZoneDepth;        // 0x5C
        public System.Boolean m_UnlimitedSoftZone;        // 0x60
        public System.Single m_SoftZoneWidth;        // 0x64
        public System.Single m_SoftZoneHeight;        // 0x68
        public System.Single m_BiasX;        // 0x6C
        public System.Single m_BiasY;        // 0x70
        public System.Boolean m_CenterOnActivate;        // 0x74
        public Cinemachine.CinemachineFramingTransposer.FramingMode m_GroupFramingMode;        // 0x78
        public Cinemachine.CinemachineFramingTransposer.AdjustmentMode m_AdjustmentMode;        // 0x7C
        public System.Single m_GroupFramingSize;        // 0x80
        public System.Single m_MaxDollyIn;        // 0x84
        public System.Single m_MaxDollyOut;        // 0x88
        public System.Single m_MinimumDistance;        // 0x8C
        public System.Single m_MaximumDistance;        // 0x90
        public System.Single m_MinimumFOV;        // 0x94
        public System.Single m_MaximumFOV;        // 0x98
        public System.Single m_MinimumOrthoSize;        // 0x9C
        public System.Single m_MaximumOrthoSize;        // 0xA0
        private static System.Single kMinimumCameraDistance;        // 0x0
        private static System.Single kMinimumGroupSize;        // 0x0
        private UnityEngine.Vector3 m_PreviousCameraPosition;        // 0xA4
        private Cinemachine.Utility.PositionPredictor m_Predictor;        // 0xB0
        private UnityEngine.Vector3 <TrackedPoint>k__BackingField;        // 0xB8
        private System.Boolean m_InheritingPosition;        // 0xC4
        private System.Single m_prevFOV;        // 0xC8
        private UnityEngine.Quaternion m_prevRotation;        // 0xCC
        private UnityEngine.Bounds <LastBounds>k__BackingField;        // 0xDC
        private UnityEngine.Matrix4x4 <LastBoundsMatrix>k__BackingField;        // 0xF4

        // Methods
        private UnityEngine.Rect get_SoftGuideRect() { }
        private System.Void set_SoftGuideRect(UnityEngine.Rect value) { }
        private UnityEngine.Rect get_HardGuideRect() { }
        private System.Void set_HardGuideRect(UnityEngine.Rect value) { }
        private System.Void OnValidate() { }
        private System.Boolean get_IsValid() { }
        private Cinemachine.CinemachineCore.Stage get_Stage() { }
        private System.Boolean get_BodyAppliesAfterAim() { }
        private UnityEngine.Vector3 get_TrackedPoint() { }
        private System.Void set_TrackedPoint(UnityEngine.Vector3 value) { }
        private System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta) { }
        private System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        private System.Single GetMaxDampTime() { }
        private System.Boolean OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime, Cinemachine.CinemachineVirtualCameraBase.TransitionParams& transitionParams) { }
        private UnityEngine.Rect ScreenToOrtho(UnityEngine.Rect rScreen, System.Single orthoSize, System.Single aspect) { }
        private UnityEngine.Vector3 OrthoOffsetToScreenBounds(UnityEngine.Vector3 targetPos2D, UnityEngine.Rect screenRect) { }
        private UnityEngine.Bounds get_LastBounds() { }
        private System.Void set_LastBounds(UnityEngine.Bounds value) { }
        private UnityEngine.Matrix4x4 get_LastBoundsMatrix() { }
        private System.Void set_LastBoundsMatrix(UnityEngine.Matrix4x4 value) { }
        private System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        private System.Single GetTargetHeight(UnityEngine.Vector2 boundsSize) { }
        private UnityEngine.Vector3 ComputeGroupBounds(Cinemachine.ICinemachineTargetGroup group, Cinemachine.CameraState& curState) { }
        private UnityEngine.Bounds GetScreenSpaceGroupBoundingBox(Cinemachine.ICinemachineTargetGroup group, UnityEngine.Vector3& pos, UnityEngine.Quaternion orientation) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000049
    public class CinemachineGroupComposer : CinemachineComposer
    {
        // Fields
        public System.Single m_GroupFramingSize;        // 0x110
        public Cinemachine.CinemachineGroupComposer.FramingMode m_FramingMode;        // 0x114
        public System.Single m_FrameDamping;        // 0x118
        public Cinemachine.CinemachineGroupComposer.AdjustmentMode m_AdjustmentMode;        // 0x11C
        public System.Single m_MaxDollyIn;        // 0x120
        public System.Single m_MaxDollyOut;        // 0x124
        public System.Single m_MinimumDistance;        // 0x128
        public System.Single m_MaximumDistance;        // 0x12C
        public System.Single m_MinimumFOV;        // 0x130
        public System.Single m_MaximumFOV;        // 0x134
        public System.Single m_MinimumOrthoSize;        // 0x138
        public System.Single m_MaximumOrthoSize;        // 0x13C
        private System.Single m_prevFramingDistance;        // 0x140
        private System.Single m_prevFOV;        // 0x144
        private UnityEngine.Bounds <LastBounds>k__BackingField;        // 0x148
        private UnityEngine.Matrix4x4 <LastBoundsMatrix>k__BackingField;        // 0x160

        // Methods
        private System.Void OnValidate() { }
        private UnityEngine.Bounds get_LastBounds() { }
        private System.Void set_LastBounds(UnityEngine.Bounds value) { }
        private UnityEngine.Matrix4x4 get_LastBoundsMatrix() { }
        private System.Void set_LastBoundsMatrix(UnityEngine.Matrix4x4 value) { }
        private System.Single GetMaxDampTime() { }
        private System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        private System.Single GetTargetHeight(UnityEngine.Vector2 boundsSize) { }
        private UnityEngine.Bounds GetScreenSpaceGroupBoundingBox(Cinemachine.ICinemachineTargetGroup group, UnityEngine.Matrix4x4 observer, UnityEngine.Vector3& newFwd) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004C
    public class CinemachineHardLockToTarget : CinemachineComponentBase
    {
        // Fields
        public System.Single m_Damping;        // 0x20
        private UnityEngine.Vector3 m_PreviousTargetPosition;        // 0x24

        // Methods
        private System.Boolean get_IsValid() { }
        private Cinemachine.CinemachineCore.Stage get_Stage() { }
        private System.Single GetMaxDampTime() { }
        private System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004D
    public class CinemachineHardLookAt : CinemachineComponentBase
    {
        // Methods
        private System.Boolean get_IsValid() { }
        private Cinemachine.CinemachineCore.Stage get_Stage() { }
        private System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004E
    public class CinemachineOrbitalTransposer : CinemachineTransposer
    {
        // Fields
        public Cinemachine.CinemachineOrbitalTransposer.Heading m_Heading;        // 0x98
        public Cinemachine.AxisState.Recentering m_RecenterToTargetHeading;        // 0xA4
        public Cinemachine.AxisState m_XAxis;        // 0xC0
        private System.Single m_LegacyRadius;        // 0x130
        private System.Single m_LegacyHeightOffset;        // 0x134
        private System.Single m_LegacyHeadingBias;        // 0x138
        public System.Boolean m_HeadingIsSlave;        // 0x13C
        private Cinemachine.CinemachineOrbitalTransposer.UpdateHeadingDelegate HeadingUpdater;        // 0x140
        private UnityEngine.Vector3 m_LastTargetPosition;        // 0x148
        private Cinemachine.Utility.HeadingTracker mHeadingTracker;        // 0x158
        private UnityEngine.Rigidbody m_TargetRigidBody;        // 0x160
        private UnityEngine.Transform m_PreviousTarget;        // 0x168
        private UnityEngine.Vector3 m_LastCameraPosition;        // 0x170
        private System.Single m_LastHeading;        // 0x17C

        // Methods
        private System.Void OnValidate() { }
        private System.Single UpdateHeading(System.Single deltaTime, UnityEngine.Vector3 up, Cinemachine.AxisState& axis) { }
        private System.Single UpdateHeading(System.Single deltaTime, UnityEngine.Vector3 up, Cinemachine.AxisState& axis, Cinemachine.AxisState.Recentering& recentering, System.Boolean isLive) { }
        private System.Void OnEnable() { }
        private System.Void UpdateInputAxisProvider() { }
        private System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta) { }
        private System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        private System.Boolean OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime, Cinemachine.CinemachineVirtualCameraBase.TransitionParams& transitionParams) { }
        private System.Single GetAxisClosestValue(UnityEngine.Vector3 cameraPos, UnityEngine.Vector3 up) { }
        private System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        private UnityEngine.Vector3 GetTargetCameraPosition(UnityEngine.Vector3 worldUp) { }
        private System.Boolean get_RequiresUserInput() { }
        private System.Single GetTargetHeading(System.Single currentHeading, UnityEngine.Quaternion targetOrientation) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000053
    public class CinemachinePOV : CinemachineComponentBase
    {
        // Fields
        public Cinemachine.CinemachinePOV.RecenterTargetMode m_RecenterTarget;        // 0x20
        public Cinemachine.AxisState m_VerticalAxis;        // 0x28
        public Cinemachine.AxisState.Recentering m_VerticalRecentering;        // 0x98
        public Cinemachine.AxisState m_HorizontalAxis;        // 0xB8
        public Cinemachine.AxisState.Recentering m_HorizontalRecentering;        // 0x128
        public System.Boolean m_ApplyBeforeBody;        // 0x144

        // Methods
        private System.Boolean get_IsValid() { }
        private Cinemachine.CinemachineCore.Stage get_Stage() { }
        private System.Void OnValidate() { }
        private System.Void OnEnable() { }
        private System.Void UpdateInputAxisProvider() { }
        private System.Void PrePipelineMutateCameraState(Cinemachine.CameraState& state, System.Single deltaTime) { }
        private System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        private UnityEngine.Vector2 GetRecenterTarget() { }
        private System.Single NormalizeAngle(System.Single angle) { }
        private System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        private System.Boolean OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime, Cinemachine.CinemachineVirtualCameraBase.TransitionParams& transitionParams) { }
        private System.Boolean get_RequiresUserInput() { }
        private System.Void SetAxesForRotation(UnityEngine.Quaternion targetRot) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000055
    public class CinemachineSameAsFollowTarget : CinemachineComponentBase
    {
        // Fields
        public System.Single m_Damping;        // 0x20
        private UnityEngine.Quaternion m_PreviousReferenceOrientation;        // 0x24

        // Methods
        private System.Boolean get_IsValid() { }
        private Cinemachine.CinemachineCore.Stage get_Stage() { }
        private System.Single GetMaxDampTime() { }
        private System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000056
    public class CinemachineTrackedDolly : CinemachineComponentBase
    {
        // Fields
        public Cinemachine.CinemachinePathBase m_Path;        // 0x20
        public System.Single m_PathPosition;        // 0x28
        public Cinemachine.CinemachinePathBase.PositionUnits m_PositionUnits;        // 0x2C
        public UnityEngine.Vector3 m_PathOffset;        // 0x30
        public System.Single m_XDamping;        // 0x3C
        public System.Single m_YDamping;        // 0x40
        public System.Single m_ZDamping;        // 0x44
        public Cinemachine.CinemachineTrackedDolly.CameraUpMode m_CameraUp;        // 0x48
        public System.Single m_PitchDamping;        // 0x4C
        public System.Single m_YawDamping;        // 0x50
        public System.Single m_RollDamping;        // 0x54
        public Cinemachine.CinemachineTrackedDolly.AutoDolly m_AutoDolly;        // 0x58
        private System.Single m_PreviousPathPosition;        // 0x68
        private UnityEngine.Quaternion m_PreviousOrientation;        // 0x6C
        private UnityEngine.Vector3 m_PreviousCameraPosition;        // 0x7C

        // Methods
        private System.Boolean get_IsValid() { }
        private Cinemachine.CinemachineCore.Stage get_Stage() { }
        private System.Single GetMaxDampTime() { }
        private System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        private UnityEngine.Quaternion GetCameraOrientationAtPathPoint(UnityEngine.Quaternion pathOrientation, UnityEngine.Vector3 up) { }
        private UnityEngine.Vector3 get_AngularDamping() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000059
    public class CinemachineTransposer : CinemachineComponentBase
    {
        // Fields
        public Cinemachine.CinemachineTransposer.BindingMode m_BindingMode;        // 0x20
        public UnityEngine.Vector3 m_FollowOffset;        // 0x24
        public System.Single m_XDamping;        // 0x30
        public System.Single m_YDamping;        // 0x34
        public System.Single m_ZDamping;        // 0x38
        public Cinemachine.CinemachineTransposer.AngularDampingMode m_AngularDampingMode;        // 0x3C
        public System.Single m_PitchDamping;        // 0x40
        public System.Single m_YawDamping;        // 0x44
        public System.Single m_RollDamping;        // 0x48
        public System.Single m_AngularDamping;        // 0x4C
        private System.Boolean <HideOffsetInInspector>k__BackingField;        // 0x50
        private UnityEngine.Vector3 m_PreviousTargetPosition;        // 0x54
        private UnityEngine.Quaternion m_PreviousReferenceOrientation;        // 0x60
        private UnityEngine.Quaternion m_targetOrientationOnAssign;        // 0x70
        private UnityEngine.Vector3 m_PreviousOffset;        // 0x80
        private UnityEngine.Transform m_previousTarget;        // 0x90

        // Methods
        private System.Void OnValidate() { }
        private System.Boolean get_HideOffsetInInspector() { }
        private System.Void set_HideOffsetInInspector(System.Boolean value) { }
        private UnityEngine.Vector3 get_EffectiveOffset() { }
        private System.Boolean get_IsValid() { }
        private Cinemachine.CinemachineCore.Stage get_Stage() { }
        private System.Single GetMaxDampTime() { }
        private System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        private System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta) { }
        private System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        private System.Void InitPrevFrameStateInfo(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        private System.Void TrackTarget(System.Single deltaTime, UnityEngine.Vector3 up, UnityEngine.Vector3 desiredCameraOffset, UnityEngine.Vector3& outTargetPosition, UnityEngine.Quaternion& outTargetOrient) { }
        private UnityEngine.Vector3 GetOffsetForMinimumTargetDistance(UnityEngine.Vector3 dampedTargetPos, UnityEngine.Vector3 cameraOffset, UnityEngine.Vector3 cameraFwd, UnityEngine.Vector3 up, UnityEngine.Vector3 actualTargetPos) { }
        private UnityEngine.Vector3 get_Damping() { }
        private UnityEngine.Vector3 get_AngularDamping() { }
        private UnityEngine.Vector3 GetTargetCameraPosition(UnityEngine.Vector3 worldUp) { }
        private UnityEngine.Quaternion GetReferenceOrientation(UnityEngine.Vector3 worldUp) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005C
    public struct AxisState
    {
        // Fields
        public System.Single Value;        // 0x10
        public Cinemachine.AxisState.SpeedMode m_SpeedMode;        // 0x14
        public System.Single m_MaxSpeed;        // 0x18
        public System.Single m_AccelTime;        // 0x1C
        public System.Single m_DecelTime;        // 0x20
        public System.String m_InputAxisName;        // 0x28
        public System.Single m_InputAxisValue;        // 0x30
        public System.Boolean m_InvertInput;        // 0x34
        public System.Single m_MinValue;        // 0x38
        public System.Single m_MaxValue;        // 0x3C
        public System.Boolean m_Wrap;        // 0x40
        public Cinemachine.AxisState.Recentering m_Recentering;        // 0x44
        private System.Single m_CurrentSpeed;        // 0x60
        private System.Single m_LastUpdateTime;        // 0x64
        private System.Int32 m_LastUpdateFrame;        // 0x68
        private static System.Single Epsilon;        // 0x0
        private Cinemachine.AxisState.IInputAxisProvider m_InputAxisProvider;        // 0x70
        private System.Int32 m_InputAxisIndex;        // 0x78
        private System.Boolean <ValueRangeLocked>k__BackingField;        // 0x7C
        private System.Boolean <HasRecentering>k__BackingField;        // 0x7D

        // Methods
        private System.Void .ctor(System.Single minValue, System.Single maxValue, System.Boolean wrap, System.Boolean rangeLocked, System.Single maxSpeed, System.Single accelTime, System.Single decelTime, System.String name, System.Boolean invert) { }
        private System.Void Validate() { }
        private System.Void Reset() { }
        private System.Void SetInputAxisProvider(System.Int32 axis, Cinemachine.AxisState.IInputAxisProvider provider) { }
        private System.Boolean Update(System.Single deltaTime) { }
        private System.Single ClampValue(System.Single v) { }
        private System.Boolean MaxSpeedUpdate(System.Single input, System.Single deltaTime) { }
        private System.Single GetMaxSpeed() { }
        private System.Void set_ValueRangeLocked(System.Boolean value) { }
        private System.Void set_HasRecentering(System.Boolean value) { }

    }

    // TypeToken: 0x2000060
    public struct CameraState
    {
        // Fields
        public Cinemachine.CameraState.HGDOFParams DofParams;        // 0x10
        public Cinemachine.LensSettings Lens;        // 0x30
        public UnityEngine.Vector3 ReferenceUp;        // 0x60
        public UnityEngine.Vector3 ReferenceLookAt;        // 0x6C
        public UnityEngine.Vector3 Pivot;        // 0x78
        public static UnityEngine.Vector3 kNoPoint;        // 0x0
        public UnityEngine.Vector3 RawPosition;        // 0x84
        public UnityEngine.Quaternion RawOrientation;        // 0x90
        public UnityEngine.Vector3 PositionDampingBypass;        // 0xA0
        public System.Single ShotQuality;        // 0xAC
        public UnityEngine.Vector3 PositionCorrection;        // 0xB0
        public UnityEngine.Quaternion OrientationCorrection;        // 0xBC
        public Cinemachine.CameraState.BlendHintValue BlendHint;        // 0xCC
        private Cinemachine.CameraState.CustomBlendable mCustom0;        // 0xD0
        private Cinemachine.CameraState.CustomBlendable mCustom1;        // 0xE0
        private Cinemachine.CameraState.CustomBlendable mCustom2;        // 0xF0
        private Cinemachine.CameraState.CustomBlendable mCustom3;        // 0x100
        private System.Collections.Generic.List<Cinemachine.CameraState.CustomBlendable> m_CustomOverflow;        // 0x110
        private System.Int32 <NumCustomBlendables>k__BackingField;        // 0x118

        // Methods
        private System.Boolean get_HasLookAt() { }
        private UnityEngine.Vector3 get_CorrectedPosition() { }
        private UnityEngine.Quaternion get_CorrectedOrientation() { }
        private UnityEngine.Vector3 get_FinalPosition() { }
        private UnityEngine.Quaternion get_FinalOrientation() { }
        private Cinemachine.CameraState get_Default() { }
        private System.Int32 get_NumCustomBlendables() { }
        private System.Void set_NumCustomBlendables(System.Int32 value) { }
        private Cinemachine.CameraState.CustomBlendable GetCustomBlendable(System.Int32 index) { }
        private System.Int32 FindCustomBlendable(UnityEngine.Object custom) { }
        private System.Void AddCustomBlendable(Cinemachine.CameraState.CustomBlendable b) { }
        private Cinemachine.CameraState Lerp(Cinemachine.CameraState& stateA, Cinemachine.CameraState& stateB, System.Single t) { }
        private System.Single InterpolateFOV(System.Single fovA, System.Single fovB, System.Single dA, System.Single dB, System.Single t) { }
        private UnityEngine.Vector3 ApplyPosBlendHint(UnityEngine.Vector3 posA, Cinemachine.CameraState.BlendHintValue hintA, UnityEngine.Vector3 posB, Cinemachine.CameraState.BlendHintValue hintB, UnityEngine.Vector3 original, UnityEngine.Vector3 blended) { }
        private UnityEngine.Quaternion ApplyRotBlendHint(UnityEngine.Quaternion rotA, Cinemachine.CameraState.BlendHintValue hintA, UnityEngine.Quaternion rotB, Cinemachine.CameraState.BlendHintValue hintB, UnityEngine.Quaternion original, UnityEngine.Quaternion blended) { }
        private UnityEngine.Vector3 InterpolatePosition(UnityEngine.Vector3 posA, UnityEngine.Vector3 pivotA, UnityEngine.Vector3 posB, UnityEngine.Vector3 pivotB, System.Single t) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000064
    public class CinemachineBlend
    {
        // Fields
        private Cinemachine.ICinemachineCamera m_CamA;        // 0x10
        public Cinemachine.ICinemachineCamera CamB;        // 0x18
        public System.Boolean useSimpleInertialization;        // 0x20
        public System.Boolean InitStateGot;        // 0x21
        public Cinemachine.CameraState InitStateA;        // 0x28
        public Cinemachine.CameraState CurrStateA;        // 0x138
        public Cinemachine.CameraState InitStateB;        // 0x248
        public UnityEngine.AnimationCurve BlendCurve;        // 0x358
        public System.Single TimeInBlend;        // 0x360
        public System.Single Duration;        // 0x364

        // Methods
        private Cinemachine.ICinemachineCamera get_CamA() { }
        private System.Void set_CamA(Cinemachine.ICinemachineCamera value) { }
        private System.Void StartSimpleInertialization() { }
        private System.Single get_BlendWeight() { }
        private System.Boolean get_IsValid() { }
        private System.Boolean get_IsComplete() { }
        private System.String get_Description() { }
        private System.Boolean Uses(Cinemachine.ICinemachineCamera cam) { }
        private System.Void .ctor(Cinemachine.ICinemachineCamera a, Cinemachine.ICinemachineCamera b, UnityEngine.AnimationCurve curve, System.Single duration, System.Single t) { }
        private System.Void UpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        private Cinemachine.CameraState get_State() { }

    }

    // TypeToken: 0x2000065
    public struct CinemachineBlendDefinition
    {
        // Fields
        public Cinemachine.CinemachineBlendDefinition.Style m_Style;        // 0x10
        public System.Single m_Time;        // 0x14
        public UnityEngine.AnimationCurve m_CustomCurve;        // 0x18
        private static UnityEngine.AnimationCurve[] sStandardCurves;        // 0x0
        public System.Boolean m_UseSimpleInertialization;        // 0x20

        // Methods
        private System.Single get_BlendTime() { }
        private System.Void .ctor(Cinemachine.CinemachineBlendDefinition.Style style, System.Single time) { }
        private System.Void CreateStandardCurves() { }
        private UnityEngine.AnimationCurve get_BlendCurve() { }

    }

    // TypeToken: 0x2000067
    public class StaticPointVirtualCamera, ICinemachineCamera
    {
        // Fields
        private System.String <Name>k__BackingField;        // 0x10
        private System.Int32 <Priority>k__BackingField;        // 0x18
        private UnityEngine.Transform <LookAt>k__BackingField;        // 0x20
        private UnityEngine.Transform <Follow>k__BackingField;        // 0x28
        private Cinemachine.CameraState <State>k__BackingField;        // 0x30

        // Methods
        private System.Void .ctor(Cinemachine.CameraState& state, System.String name) { }
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private System.Int32 get_Priority() { }
        private UnityEngine.Transform get_LookAt() { }
        private UnityEngine.Transform get_Follow() { }
        private Cinemachine.CameraState get_State() { }
        private System.Void set_State(Cinemachine.CameraState value) { }
        private UnityEngine.GameObject get_VirtualCameraGameObject() { }
        private System.Boolean get_IsValid() { }
        private Cinemachine.ICinemachineCamera get_ParentCamera() { }
        private System.Boolean IsLiveChild(Cinemachine.ICinemachineCamera vcam, System.Boolean dominantChildOnly) { }
        private System.Void UpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        private System.Void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime) { }

    }

    // TypeToken: 0x2000068
    public class BlendSourceVirtualCamera, ICinemachineCamera
    {
        // Fields
        private Cinemachine.CinemachineBlend <Blend>k__BackingField;        // 0x10
        private System.Int32 <Priority>k__BackingField;        // 0x18
        private UnityEngine.Transform <LookAt>k__BackingField;        // 0x20
        private UnityEngine.Transform <Follow>k__BackingField;        // 0x28
        private Cinemachine.CameraState <State>k__BackingField;        // 0x30

        // Methods
        private System.Void .ctor(Cinemachine.CinemachineBlend blend) { }
        private Cinemachine.CinemachineBlend get_Blend() { }
        private System.Void set_Blend(Cinemachine.CinemachineBlend value) { }
        private System.String get_Name() { }
        private System.Int32 get_Priority() { }
        private UnityEngine.Transform get_LookAt() { }
        private UnityEngine.Transform get_Follow() { }
        private Cinemachine.CameraState get_State() { }
        private System.Void set_State(Cinemachine.CameraState value) { }
        private UnityEngine.GameObject get_VirtualCameraGameObject() { }
        private System.Boolean get_IsValid() { }
        private Cinemachine.ICinemachineCamera get_ParentCamera() { }
        private System.Boolean IsLiveChild(Cinemachine.ICinemachineCamera vcam, System.Boolean dominantChildOnly) { }
        private System.Void UpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        private System.Void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime) { }

    }

    // TypeToken: 0x2000069
    public class CinemachineBlenderSettings : ScriptableObject
    {
        // Fields
        public Cinemachine.CinemachineBlenderSettings.CustomBlend[] m_CustomBlends;        // 0x18
        public Cinemachine.CinemachineBlenderSettings.CustomBlendGroup[] m_CustomBlendGroups;        // 0x20
        public static System.String kBlendFromAnyCameraLabel;        // 0x0

        // Methods
        private Cinemachine.CinemachineBlendDefinition GetBlendForVirtualCameras(System.String fromCameraName, System.String toCameraName, Cinemachine.CinemachineBlendDefinition defaultBlend) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006C
    public class CinemachineComponentBase : MonoBehaviour
    {
        // Fields
        protected static System.Single Epsilon;        // 0x0
        private Cinemachine.CinemachineVirtualCameraBase m_vcamOwner;        // 0x18

        // Methods
        private Cinemachine.CinemachineVirtualCameraBase get_VirtualCamera() { }
        private UnityEngine.Transform get_FollowTarget() { }
        private UnityEngine.Transform get_LookAtTarget() { }
        private Cinemachine.ICinemachineTargetGroup get_AbstractFollowTargetGroup() { }
        private Cinemachine.CinemachineTargetGroup get_FollowTargetGroup() { }
        private UnityEngine.Vector3 get_FollowTargetPosition() { }
        private UnityEngine.Quaternion get_FollowTargetRotation() { }
        private Cinemachine.ICinemachineTargetGroup get_AbstractLookAtTargetGroup() { }
        private Cinemachine.CinemachineTargetGroup get_LookAtTargetGroup() { }
        private UnityEngine.Vector3 get_LookAtTargetPosition() { }
        private UnityEngine.Quaternion get_LookAtTargetRotation() { }
        private Cinemachine.CameraState get_VcamState() { }
        private System.Boolean get_IsValid() { }
        private System.Void PrePipelineMutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        private Cinemachine.CinemachineCore.Stage get_Stage() { }
        private System.Boolean get_BodyAppliesAfterAim() { }
        private System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime) { }
        private System.Boolean OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime, Cinemachine.CinemachineVirtualCameraBase.TransitionParams& transitionParams) { }
        private System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta) { }
        private System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        private System.Single GetMaxDampTime() { }
        private System.Boolean get_RequiresUserInput() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006D
    public class CinemachineCore
    {
        // Fields
        public static readonly System.Int32 kStreamingVersion;        // 0x0
        public static readonly System.String kVersionString;        // 0x8
        private static Cinemachine.CinemachineCore sInstance;        // 0x10
        public static System.Boolean sShowHiddenObjects;        // 0x18
        public static Cinemachine.CinemachineCore.AxisInputDelegate GetInputAxis;        // 0x20
        public static System.Single UniformDeltaTimeOverride;        // 0x28
        public static System.Single CurrentTimeOverride;        // 0x2C
        public static Cinemachine.CinemachineCore.GetBlendOverrideDelegate GetBlendOverride;        // 0x30
        public static Cinemachine.CinemachineBrain.BrainEvent CameraUpdatedEvent;        // 0x38
        public static Cinemachine.CinemachineBrain.BrainEvent CameraCutEvent;        // 0x40
        private System.Collections.Generic.List<Cinemachine.CinemachineBrain> mActiveBrains;        // 0x10
        private System.Collections.Generic.List<Cinemachine.CinemachineVirtualCameraBase> mActiveCameras;        // 0x18
        private System.Boolean m_ActiveCamerasAreSorted;        // 0x20
        private System.Int32 m_ActivationSequence;        // 0x24
        private System.Collections.Generic.List<System.Collections.Generic.List<Cinemachine.CinemachineVirtualCameraBase>> mAllCameras;        // 0x28
        private Cinemachine.CinemachineVirtualCameraBase mRoundRobinVcamLastFrame;        // 0x30
        private static System.Single s_LastUpdateTime;        // 0x48
        private static System.Int32 s_FixedFrameCount;        // 0x4C
        private System.Collections.Generic.Dictionary<Cinemachine.CinemachineVirtualCameraBase,Cinemachine.CinemachineCore.UpdateStatus> mUpdateStatus;        // 0x38
        private Cinemachine.CinemachineCore.UpdateFilter m_CurrentUpdateFilter;        // 0x40

        // Methods
        private Cinemachine.CinemachineCore get_Instance() { }
        private System.Single get_DeltaTime() { }
        private System.Single get_CurrentTime() { }
        private System.Int32 get_BrainCount() { }
        private Cinemachine.CinemachineBrain GetActiveBrain(System.Int32 index) { }
        private System.Void AddActiveBrain(Cinemachine.CinemachineBrain brain) { }
        private System.Void RemoveActiveBrain(Cinemachine.CinemachineBrain brain) { }
        private System.Int32 get_VirtualCameraCount() { }
        private Cinemachine.CinemachineVirtualCameraBase GetVirtualCamera(System.Int32 index) { }
        private System.Void AddActiveCamera(Cinemachine.CinemachineVirtualCameraBase vcam) { }
        private System.Void RemoveActiveCamera(Cinemachine.CinemachineVirtualCameraBase vcam) { }
        private System.Void CameraDestroyed(Cinemachine.CinemachineVirtualCameraBase vcam) { }
        private System.Void CameraEnabled(Cinemachine.CinemachineVirtualCameraBase vcam) { }
        private System.Void CameraDisabled(Cinemachine.CinemachineVirtualCameraBase vcam) { }
        private System.Void UpdateAllActiveVirtualCameras(System.Int32 layerMask, UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        private System.Void UpdateVirtualCamera(Cinemachine.CinemachineVirtualCameraBase vcam, UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        private System.Void InitializeModule() { }
        private UnityEngine.Transform GetUpdateTarget(Cinemachine.CinemachineVirtualCameraBase vcam) { }
        private Cinemachine.UpdateTracker.UpdateClock GetVcamUpdateStatus(Cinemachine.CinemachineVirtualCameraBase vcam) { }
        private System.Boolean IsLive(Cinemachine.ICinemachineCamera vcam) { }
        private System.Boolean IsLiveInBlend(Cinemachine.ICinemachineCamera vcam) { }
        private System.Void GenerateCameraActivationEvent(Cinemachine.ICinemachineCamera vcam, Cinemachine.ICinemachineCamera vcamFrom) { }
        private System.Void GenerateCameraCutEvent(Cinemachine.ICinemachineCamera vcam) { }
        private Cinemachine.CinemachineBrain FindPotentialTargetBrain(Cinemachine.CinemachineVirtualCameraBase vcam) { }
        private System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000074
    public class CinemachineExtension : MonoBehaviour
    {
        // Fields
        protected static System.Single Epsilon;        // 0x0
        private Cinemachine.CinemachineVirtualCameraBase m_vcamOwner;        // 0x18
        private System.Collections.Generic.Dictionary<Cinemachine.ICinemachineCamera,System.Object> mExtraState;        // 0x20

        // Methods
        private Cinemachine.CinemachineVirtualCameraBase get_VirtualCamera() { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnDestroy() { }
        private System.Void EnsureStarted() { }
        private System.Void ConnectToVcam(System.Boolean connect) { }
        private System.Void PrePipelineMutateCameraStateCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CameraState& curState, System.Single deltaTime) { }
        private System.Void InvokePostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime) { }
        private System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime) { }
        private System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta) { }
        private System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        private System.Boolean OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        private System.Single GetMaxDampTime() { }
        private System.Boolean get_RequiresUserInput() { }
        private T GetExtraState(Cinemachine.ICinemachineCamera vcam) { }
        private System.Collections.Generic.List<T> GetAllExtraStates() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000075
    public class CinemachinePathBase : MonoBehaviour
    {
        // Fields
        public System.Int32 m_Resolution;        // 0x18
        public Cinemachine.CinemachinePathBase.Appearance m_Appearance;        // 0x20
        private System.Single[] m_DistanceToPos;        // 0x28
        private System.Single[] m_PosToDistance;        // 0x30
        private System.Int32 m_CachedSampleSteps;        // 0x38
        private System.Single m_PathLength;        // 0x3C
        private System.Single m_cachedPosStepSize;        // 0x40
        private System.Single m_cachedDistanceStepSize;        // 0x44

        // Methods
        private System.Single get_MinPos() { }
        private System.Single get_MaxPos() { }
        private System.Boolean get_Looped() { }
        private System.Single StandardizePos(System.Single pos) { }
        private UnityEngine.Vector3 EvaluatePosition(System.Single pos) { }
        private UnityEngine.Vector3 EvaluateTangent(System.Single pos) { }
        private UnityEngine.Quaternion EvaluateOrientation(System.Single pos) { }
        private System.Single FindClosestPoint(UnityEngine.Vector3 p, System.Int32 startSegment, System.Int32 searchRadius, System.Int32 stepsPerSegment) { }
        private System.Single MinUnit(Cinemachine.CinemachinePathBase.PositionUnits units) { }
        private System.Single MaxUnit(Cinemachine.CinemachinePathBase.PositionUnits units) { }
        private System.Single StandardizeUnit(System.Single pos, Cinemachine.CinemachinePathBase.PositionUnits units) { }
        private UnityEngine.Vector3 EvaluatePositionAtUnit(System.Single pos, Cinemachine.CinemachinePathBase.PositionUnits units) { }
        private UnityEngine.Vector3 EvaluateTangentAtUnit(System.Single pos, Cinemachine.CinemachinePathBase.PositionUnits units) { }
        private UnityEngine.Quaternion EvaluateOrientationAtUnit(System.Single pos, Cinemachine.CinemachinePathBase.PositionUnits units) { }
        private System.Int32 get_DistanceCacheSampleStepsPerSegment() { }
        private System.Void InvalidateDistanceCache() { }
        private System.Boolean DistanceCacheIsValid() { }
        private System.Single get_PathLength() { }
        private System.Single StandardizePathDistance(System.Single distance) { }
        private System.Single ToNativePathUnits(System.Single pos, Cinemachine.CinemachinePathBase.PositionUnits units) { }
        private System.Single FromPathNativeUnits(System.Single pos, Cinemachine.CinemachinePathBase.PositionUnits units) { }
        private System.Void ResamplePath(System.Int32 stepsPerSegment) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000078
    public class AxisStatePropertyAttribute : PropertyAttribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000079
    public class OrbitalTransposerHeadingPropertyAttribute : PropertyAttribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007A
    public class VcamTargetPropertyAttribute : PropertyAttribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007B
    public class CinemachineBlendDefinitionPropertyAttribute : PropertyAttribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007C
    public class SaveDuringPlayAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007D
    public class NoSaveDuringPlayAttribute : PropertyAttribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007E
    public class TagFieldAttribute : PropertyAttribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007F
    public class NoiseSettingsPropertyAttribute : PropertyAttribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000080
    public class CinemachineEmbeddedAssetPropertyAttribute : PropertyAttribute
    {
        // Fields
        public System.Boolean WarnIfNull;        // 0x10

        // Methods
        private System.Void .ctor(System.Boolean warnIfNull) { }

    }

    // TypeToken: 0x2000081
    public class DocumentationSortingAttribute : Attribute
    {
        // Fields
        private Cinemachine.DocumentationSortingAttribute.Level <Category>k__BackingField;        // 0x10

        // Methods
        private System.Void set_Category(Cinemachine.DocumentationSortingAttribute.Level value) { }
        private System.Void .ctor(Cinemachine.DocumentationSortingAttribute.Level category) { }

    }

    // TypeToken: 0x2000083
    public class CinemachineVirtualCameraBase : MonoBehaviour, ICinemachineCamera
    {
        // Fields
        public System.String[] m_ExcludedPropertiesInInspector;        // 0x18
        public Cinemachine.CinemachineCore.Stage[] m_LockStageInInspector;        // 0x20
        private System.Int32 m_ValidatingStreamVersion;        // 0x28
        private System.Boolean m_OnValidateCalled;        // 0x2C
        private System.Int32 m_StreamingVersion;        // 0x30
        public System.Int32 m_Priority;        // 0x34
        private System.Int32 m_ActivationId;        // 0x38
        public System.Single FollowTargetAttachment;        // 0x3C
        public System.Single LookAtTargetAttachment;        // 0x40
        protected System.Boolean _ignoreLookAtBlend;        // 0x44
        public Cinemachine.CinemachineVirtualCameraBase.StandbyUpdateMode m_StandbyUpdate;        // 0x48
        private System.Collections.Generic.List<Cinemachine.CinemachineExtension> <mExtensions>k__BackingField;        // 0x50
        private System.Boolean <PreviousStateIsValid>k__BackingField;        // 0x58
        private System.Boolean m_WasStarted;        // 0x59
        private System.Boolean mSlaveStatusUpdated;        // 0x5A
        private Cinemachine.CinemachineVirtualCameraBase m_parentVcam;        // 0x60
        private System.Int32 m_QueuePriority;        // 0x68
        private UnityEngine.Transform m_CachedFollowTarget;        // 0x70
        private Cinemachine.CinemachineVirtualCameraBase m_CachedFollowTargetVcam;        // 0x78
        private Cinemachine.ICinemachineTargetGroup m_CachedFollowTargetGroup;        // 0x80
        private UnityEngine.Transform m_CachedLookAtTarget;        // 0x88
        private Cinemachine.CinemachineVirtualCameraBase m_CachedLookAtTargetVcam;        // 0x90
        private Cinemachine.ICinemachineTargetGroup m_CachedLookAtTargetGroup;        // 0x98
        private System.Boolean <FollowTargetChanged>k__BackingField;        // 0xA0
        private System.Boolean <LookAtTargetChanged>k__BackingField;        // 0xA1

        // Methods
        private System.Int32 get_ValidatingStreamVersion() { }
        private System.Void set_ValidatingStreamVersion(System.Int32 value) { }
        private System.Single GetMaxDampTime() { }
        private System.Single DetachedFollowTargetDamp(System.Single initial, System.Single dampTime, System.Single deltaTime) { }
        private UnityEngine.Vector3 DetachedFollowTargetDamp(UnityEngine.Vector3 initial, UnityEngine.Vector3 dampTime, System.Single deltaTime) { }
        private UnityEngine.Vector3 DetachedFollowTargetDamp(UnityEngine.Vector3 initial, System.Single dampTime, System.Single deltaTime) { }
        private System.Single DetachedLookAtTargetDamp(System.Single initial, System.Single dampTime, System.Single deltaTime) { }
        private UnityEngine.Vector3 DetachedLookAtTargetDamp(UnityEngine.Vector3 initial, UnityEngine.Vector3 dampTime, System.Single deltaTime) { }
        private UnityEngine.Vector3 DetachedLookAtTargetDamp(UnityEngine.Vector3 initial, System.Single dampTime, System.Single deltaTime) { }
        private System.Void AddExtension(Cinemachine.CinemachineExtension extension) { }
        private System.Void RemoveExtension(Cinemachine.CinemachineExtension extension) { }
        private System.Collections.Generic.List<Cinemachine.CinemachineExtension> get_mExtensions() { }
        private System.Void set_mExtensions(System.Collections.Generic.List<Cinemachine.CinemachineExtension> value) { }
        private System.Void InvokePostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& newState, System.Single deltaTime) { }
        private System.Void InvokePrePipelineMutateCameraStateCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CameraState& newState, System.Single deltaTime) { }
        private System.Boolean InvokeOnTransitionInExtensions(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        private System.String get_Name() { }
        private System.String get_Description() { }
        private System.Int32 get_Priority() { }
        private System.Void set_Priority(System.Int32 value) { }
        private System.Void ApplyPositionBlendMethod(Cinemachine.CameraState& state, Cinemachine.CinemachineVirtualCameraBase.BlendHint hint) { }
        private UnityEngine.GameObject get_VirtualCameraGameObject() { }
        private System.Boolean get_IsValid() { }
        private Cinemachine.CameraState get_State() { }
        private Cinemachine.ICinemachineCamera get_ParentCamera() { }
        private System.Boolean IsLiveChild(Cinemachine.ICinemachineCamera vcam, System.Boolean dominantChildOnly) { }
        private UnityEngine.Transform get_LookAt() { }
        private System.Void set_LookAt(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_Follow() { }
        private System.Void set_Follow(UnityEngine.Transform value) { }
        private System.Boolean get_PreviousStateIsValid() { }
        private System.Void set_PreviousStateIsValid(System.Boolean value) { }
        private System.Void UpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        private System.Void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        private System.Void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        private System.Void OnDestroy() { }
        private System.Void OnTransformParentChanged() { }
        private System.Void Start() { }
        private System.Boolean RequiresUserInput() { }
        private System.Void EnsureStarted() { }
        private Cinemachine.AxisState.IInputAxisProvider GetInputAxisProvider() { }
        private System.Void OnValidate() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Update() { }
        private System.Void UpdateSlaveStatus() { }
        private UnityEngine.Transform ResolveLookAt(UnityEngine.Transform localLookAt) { }
        private UnityEngine.Transform ResolveFollow(UnityEngine.Transform localFollow) { }
        private System.Void UpdateVcamPoolStatus() { }
        private System.Void MoveToTopOfPrioritySubqueue() { }
        private System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta) { }
        private System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        private Cinemachine.CinemachineBlend CreateBlend(Cinemachine.ICinemachineCamera camA, Cinemachine.ICinemachineCamera camB, Cinemachine.CinemachineBlendDefinition blendDef, Cinemachine.CinemachineBlend activeBlend) { }
        private Cinemachine.CameraState PullStateFromVirtualCamera(UnityEngine.Vector3 worldUp, Cinemachine.LensSettings& lens) { }
        private System.Void InvalidateCachedTargets() { }
        private System.Boolean get_FollowTargetChanged() { }
        private System.Void set_FollowTargetChanged(System.Boolean value) { }
        private System.Boolean get_LookAtTargetChanged() { }
        private System.Void set_LookAtTargetChanged(System.Boolean value) { }
        private System.Void UpdateTargetCache() { }
        private Cinemachine.ICinemachineTargetGroup get_AbstractFollowTargetGroup() { }
        private Cinemachine.CinemachineVirtualCameraBase get_FollowTargetAsVcam() { }
        private Cinemachine.ICinemachineTargetGroup get_AbstractLookAtTargetGroup() { }
        private Cinemachine.CinemachineVirtualCameraBase get_LookAtTargetAsVcam() { }
        private System.Object GetCinemachineComponent() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000088
    public class ConfinerOven
    {
        // Fields
        private System.Single m_MinFrustumHeightWithBones;        // 0x10
        private System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> m_OriginalPolygon;        // 0x18
        private System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> m_Skeleton;        // 0x20
        private static System.Int64 k_FloatToIntScaler;        // 0x0
        private static System.Single k_IntToFloatScaler;        // 0x0
        private static System.Single k_MinStepSize;        // 0x0
        private UnityEngine.Rect m_PolygonRect;        // 0x28
        private Cinemachine.ConfinerOven.AspectStretcher m_AspectStretcher;        // 0x38
        private System.Single m_maxComputationTimeForFullSkeletonBakeInSeconds;        // 0x44
        private Cinemachine.ConfinerOven.BakingState <State>k__BackingField;        // 0x48
        public System.Single m_BakeProgress;        // 0x4C
        private Cinemachine.ConfinerOven.BakingStateCache m_Cache;        // 0x50

        // Methods
        private System.Void .ctor(System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>>& inputPath, System.Single& aspectRatio, System.Single maxFrustumHeight) { }
        private Cinemachine.ConfinerOven.BakedSolution GetBakedSolution(System.Single frustumHeight) { }
        private Cinemachine.ConfinerOven.BakingState get_State() { }
        private System.Void set_State(Cinemachine.ConfinerOven.BakingState value) { }
        private System.Void Initialize(System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>>& inputPath, System.Single& aspectRatio, System.Single maxFrustumHeight) { }
        private System.Void BakeConfiner(System.Single maxComputationTimePerFrameInSeconds) { }
        private UnityEngine.Rect GetPolygonBoundingBox(System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>>& polygons) { }
        private System.Void ComputeSkeleton(System.Collections.Generic.List<Cinemachine.ConfinerOven.PolygonSolution>& solutions) { }

    }

    // TypeToken: 0x200008E
    public interface ICinemachineCamera
    {
        // Methods
        private System.String get_Name() { }
        private System.Int32 get_Priority() { }
        private UnityEngine.Transform get_LookAt() { }
        private UnityEngine.Transform get_Follow() { }
        private Cinemachine.CameraState get_State() { }
        private UnityEngine.GameObject get_VirtualCameraGameObject() { }
        private System.Boolean get_IsValid() { }
        private Cinemachine.ICinemachineCamera get_ParentCamera() { }
        private System.Boolean IsLiveChild(Cinemachine.ICinemachineCamera vcam, System.Boolean dominantChildOnly) { }
        private System.Void UpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime) { }
        private System.Void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime) { }

    }

    // TypeToken: 0x200008F
    public struct LensSettings
    {
        // Fields
        public static Cinemachine.LensSettings Default;        // 0x0
        public System.Single FieldOfView;        // 0x10
        public System.Single OrthographicSize;        // 0x14
        public System.Single NearClipPlane;        // 0x18
        public System.Single FarClipPlane;        // 0x1C
        public System.Single Dutch;        // 0x20
        public Cinemachine.LensSettings.OverrideModes ModeOverride;        // 0x24
        public UnityEngine.Vector2 LensShift;        // 0x28
        public UnityEngine.Camera.GateFitMode GateFit;        // 0x30
        private UnityEngine.Vector2 m_SensorSize;        // 0x34
        private System.Boolean m_OrthoFromCamera;        // 0x3C
        private System.Boolean m_PhysicalFromCamera;        // 0x3D

        // Methods
        private System.Boolean get_Orthographic() { }
        private UnityEngine.Vector2 get_SensorSize() { }
        private System.Single get_Aspect() { }
        private System.Boolean get_IsPhysicalCamera() { }
        private Cinemachine.LensSettings FromCamera(UnityEngine.Camera fromCamera) { }
        private System.Void SnapshotCameraReadOnlyProperties(UnityEngine.Camera camera) { }
        private System.Void .ctor(System.Single verticalFOV, System.Single orthographicSize, System.Single nearClip, System.Single farClip, System.Single dutch) { }
        private Cinemachine.LensSettings Lerp(Cinemachine.LensSettings lensA, Cinemachine.LensSettings lensB, System.Single t) { }
        private System.Void Validate() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000091
    public class NoiseSettings : SignalSourceAsset
    {
        // Fields
        public Cinemachine.NoiseSettings.TransformNoiseParams[] PositionNoise;        // 0x18
        public Cinemachine.NoiseSettings.TransformNoiseParams[] OrientationNoise;        // 0x20

        // Methods
        private UnityEngine.Vector3 GetCombinedFilterResults(Cinemachine.NoiseSettings.TransformNoiseParams[] noiseParams, System.Single time, UnityEngine.Vector3 timeOffsets) { }
        private System.Single get_SignalDuration() { }
        private System.Void GetSignal(System.Single timeSinceSignalStart, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000094
    public class RuntimeUtility
    {
        // Fields
        public static Cinemachine.RuntimeUtility.OverlapSphereNonAllocDelegate OverlapSphereNonAlloc;        // 0x0
        public static Cinemachine.RuntimeUtility.RaycastDelegate Raycast;        // 0x8
        public static Cinemachine.RuntimeUtility.RaycastNonAllocDelegate RaycastNonAlloc;        // 0x10
        public static Cinemachine.RuntimeUtility.SphereCastNonAllocDelegate SphereCastNonAlloc;        // 0x18
        public static Cinemachine.RuntimeUtility.ComputePenetrationDelegate ComputePenetration;        // 0x20
        public static System.Int32 ignoreColliderOption;        // 0x28
        private static UnityEngine.RaycastHit[] s_HitBuffer;        // 0x30
        private static System.Int32[] s_PenetrationIndexBuffer;        // 0x38
        private static UnityEngine.SphereCollider s_ScratchCollider;        // 0x40
        private static UnityEngine.GameObject s_ScratchColliderGameObject;        // 0x48

        // Methods
        private System.Void DestroyObject(UnityEngine.Object obj) { }
        private System.Boolean IsPrefab(UnityEngine.GameObject gameObject) { }
        private System.Boolean RaycastIgnoreTag(UnityEngine.Ray ray, UnityEngine.RaycastHit& hitInfo, System.Single rayLength, System.Int32 layerMask, System.String& ignoreTag) { }
        private System.Int32 GetColliderOptionsFromHit(UnityEngine.RaycastHit hit) { }
        private System.Boolean HasIgnoreColliderOptionFromHit(UnityEngine.RaycastHit hit) { }
        private System.Boolean HasIgnoreColliderOptionFromCollider(UnityEngine.ECSColliderResultProxy collider) { }
        private System.Boolean SphereCastIgnoreTag(UnityEngine.Vector3 rayStart, System.Single radius, UnityEngine.Vector3 dir, UnityEngine.RaycastHit& hitInfo, System.Single rayLength, System.Int32 layerMask, System.String& ignoreTag) { }
        private UnityEngine.SphereCollider GetScratchCollider() { }
        private System.Void DestroyScratchCollider() { }
        private UnityEngine.AnimationCurve NormalizeCurve(UnityEngine.AnimationCurve curve, System.Boolean normalizeX, System.Boolean normalizeY) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200009A
    public interface ISignalSource6D
    {
        // Methods
        private System.Void GetSignal(System.Single timeSinceSignalStart, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot) { }

    }

    // TypeToken: 0x200009B
    public class SignalSourceAsset : ScriptableObject, ISignalSource6D
    {
        // Methods
        private System.Single get_SignalDuration() { }
        private System.Void GetSignal(System.Single timeSinceSignalStart, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009C
    public class TargetPositionCache
    {
        // Fields
        public static System.Boolean UseCache;        // 0x0
        private static Cinemachine.TargetPositionCache.Mode m_CacheMode;        // 0x4
        public static System.Single CurrentTime;        // 0x8
        public static System.Int32 CurrentFrame;        // 0xC
        public static System.Boolean IsCameraCut;        // 0x10
        private static System.Collections.Generic.Dictionary<UnityEngine.Transform,Cinemachine.TargetPositionCache.CacheEntry> m_Cache;        // 0x18
        private static Cinemachine.TargetPositionCache.TimeRange m_CacheTimeRange;        // 0x20

        // Methods
        private Cinemachine.TargetPositionCache.Mode get_CacheMode() { }
        private System.Boolean get_HasCurrentTime() { }
        private System.Void ClearCache() { }
        private UnityEngine.Vector3 GetTargetPosition(UnityEngine.Transform target) { }
        private UnityEngine.Quaternion GetTargetRotation(UnityEngine.Transform target) { }

    }

    // TypeToken: 0x20000A3
    public class UpdateTracker
    {
        // Fields
        private static System.Collections.Generic.Dictionary<UnityEngine.Transform,Cinemachine.UpdateTracker.UpdateStatus> mUpdateStatus;        // 0x0
        private static System.Collections.Generic.List<UnityEngine.Transform> sToDelete;        // 0x8
        private static System.Single mLastUpdateTime;        // 0x10

        // Methods
        private System.Void InitializeModule() { }
        private System.Void UpdateTargets(Cinemachine.UpdateTracker.UpdateClock currentClock) { }
        private Cinemachine.UpdateTracker.UpdateClock GetPreferredUpdate(UnityEngine.Transform target) { }
        private System.Void OnUpdate(Cinemachine.UpdateTracker.UpdateClock currentClock) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000A6
    public class CinemachineInputProvider : MonoBehaviour, IInputAxisProvider
    {
        // Fields
        public System.Int32 PlayerIndex;        // 0x18
        public System.Boolean AutoEnableInputs;        // 0x1C
        public UnityEngine.InputSystem.InputActionReference XYAxis;        // 0x20
        public UnityEngine.InputSystem.InputActionReference ZAxis;        // 0x28
        private static System.Int32 NUM_AXES;        // 0x0
        private UnityEngine.InputSystem.InputAction[] m_cachedActions;        // 0x30

        // Methods
        private System.Single GetAxisValue(System.Int32 axis) { }
        private UnityEngine.InputSystem.InputAction ResolveForPlayer(System.Int32 axis, UnityEngine.InputSystem.InputActionReference actionRef) { }
        private System.Void OnDisable() { }
        private System.Void .ctor() { }
        private UnityEngine.InputSystem.InputAction <ResolveForPlayer>g__GetFirstMatch|7_0(UnityEngine.InputSystem.Users.InputUser& user, UnityEngine.InputSystem.InputActionReference aRef) { }

    }

    // TypeToken: 0x20000A8
    public class CinemachineTriggerAction : MonoBehaviour
    {
        // Fields
        public UnityEngine.LayerMask m_LayerMask;        // 0x18
        public System.String m_WithTag;        // 0x20
        public System.String m_WithoutTag;        // 0x28
        public System.Int32 m_SkipFirst;        // 0x30
        public System.Boolean m_Repeating;        // 0x34
        public Cinemachine.CinemachineTriggerAction.ActionSettings m_OnObjectEnter;        // 0x38
        public Cinemachine.CinemachineTriggerAction.ActionSettings m_OnObjectExit;        // 0x60
        private System.Collections.Generic.HashSet<UnityEngine.GameObject> m_ActiveTriggerObjects;        // 0x88

        // Methods
        private System.Boolean Filter(UnityEngine.GameObject other) { }
        private System.Void InternalDoTriggerEnter(UnityEngine.GameObject other) { }
        private System.Void InternalDoTriggerExit(UnityEngine.GameObject other) { }
        private System.Void OnTriggerEnter(UnityEngine.Collider other) { }
        private System.Void OnTriggerExit(UnityEngine.Collider other) { }
        private System.Void OnCollisionEnter(UnityEngine.Collision other) { }
        private System.Void OnCollisionExit(UnityEngine.Collision other) { }
        private System.Void OnTriggerEnter2D(UnityEngine.Collider2D other) { }
        private System.Void OnTriggerExit2D(UnityEngine.Collider2D other) { }
        private System.Void OnCollisionEnter2D(UnityEngine.Collision2D other) { }
        private System.Void OnCollisionExit2D(UnityEngine.Collision2D other) { }
        private System.Void OnEnable() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000AD
    public class GroupWeightManipulator : MonoBehaviour
    {
        // Fields
        public System.Single m_Weight0;        // 0x18
        public System.Single m_Weight1;        // 0x1C
        public System.Single m_Weight2;        // 0x20
        public System.Single m_Weight3;        // 0x24
        public System.Single m_Weight4;        // 0x28
        public System.Single m_Weight5;        // 0x2C
        public System.Single m_Weight6;        // 0x30
        public System.Single m_Weight7;        // 0x34
        private Cinemachine.CinemachineTargetGroup m_group;        // 0x38

        // Methods
        private System.Void Start() { }
        private System.Void OnValidate() { }
        private System.Void Update() { }
        private System.Void UpdateWeights() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000AE
    public class CinemachineCollisionImpulseSource : CinemachineImpulseSource
    {
        // Fields
        public UnityEngine.LayerMask m_LayerMask;        // 0x30
        public System.String m_IgnoreTag;        // 0x38
        public System.Boolean m_UseImpactDirection;        // 0x40
        public System.Boolean m_ScaleImpactWithMass;        // 0x41
        public System.Boolean m_ScaleImpactWithSpeed;        // 0x42
        private UnityEngine.Rigidbody mRigidBody;        // 0x48
        private UnityEngine.Rigidbody2D mRigidBody2D;        // 0x50

        // Methods
        private System.Void Start() { }
        private System.Void OnEnable() { }
        private System.Void OnCollisionEnter(UnityEngine.Collision c) { }
        private System.Void OnTriggerEnter(UnityEngine.Collider c) { }
        private System.Single GetMassAndVelocity(UnityEngine.Collider other, UnityEngine.Vector3& vel) { }
        private System.Void GenerateImpactEvent(UnityEngine.Collider other, UnityEngine.Vector3 vel) { }
        private System.Void OnCollisionEnter2D(UnityEngine.Collision2D c) { }
        private System.Void OnTriggerEnter2D(UnityEngine.Collider2D c) { }
        private System.Single GetMassAndVelocity2D(UnityEngine.Collider2D other2d, UnityEngine.Vector3& vel) { }
        private System.Void GenerateImpactEvent2D(UnityEngine.Collider2D other2d, UnityEngine.Vector3 vel) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000AF
    public class CinemachineFixedSignal : SignalSourceAsset
    {
        // Fields
        public UnityEngine.AnimationCurve m_XCurve;        // 0x18
        public UnityEngine.AnimationCurve m_YCurve;        // 0x20
        public UnityEngine.AnimationCurve m_ZCurve;        // 0x28

        // Methods
        private System.Single get_SignalDuration() { }
        private System.Single AxisDuration(UnityEngine.AnimationCurve axis) { }
        private System.Void GetSignal(System.Single timeSinceSignalStart, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot) { }
        private System.Single AxisValue(UnityEngine.AnimationCurve axis, System.Single time) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B0
    public class CinemachineImpulseDefinition
    {
        // Fields
        public System.Int32 m_ImpulseChannel;        // 0x10
        public Cinemachine.CinemachineImpulseDefinition.ImpulseShapes m_ImpulseShape;        // 0x14
        public UnityEngine.AnimationCurve m_CustomImpulseShape;        // 0x18
        public System.Single m_ImpulseDuration;        // 0x20
        public Cinemachine.CinemachineImpulseDefinition.ImpulseTypes m_ImpulseType;        // 0x24
        public System.Single m_DissipationRate;        // 0x28
        public Cinemachine.SignalSourceAsset m_RawSignal;        // 0x30
        public System.Single m_AmplitudeGain;        // 0x38
        public System.Single m_FrequencyGain;        // 0x3C
        public Cinemachine.CinemachineImpulseDefinition.RepeatMode m_RepeatMode;        // 0x40
        public System.Boolean m_Randomize;        // 0x44
        public Cinemachine.CinemachineImpulseManager.EnvelopeDefinition m_TimeEnvelope;        // 0x48
        public System.Single m_ImpactRadius;        // 0x68
        public Cinemachine.CinemachineImpulseManager.ImpulseEvent.DirectionMode m_DirectionMode;        // 0x6C
        public Cinemachine.CinemachineImpulseManager.ImpulseEvent.DissipationMode m_DissipationMode;        // 0x70
        public System.Single m_DissipationDistance;        // 0x74
        public System.Single m_PropagationSpeed;        // 0x78
        private static UnityEngine.AnimationCurve[] sStandardShapes;        // 0x0

        // Methods
        private System.Void OnValidate() { }
        private System.Void CreateStandardShapes() { }
        private UnityEngine.AnimationCurve GetStandardCurve(Cinemachine.CinemachineImpulseDefinition.ImpulseShapes shape) { }
        private UnityEngine.AnimationCurve get_ImpulseCurve() { }
        private System.Void CreateEvent(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity) { }
        private Cinemachine.CinemachineImpulseManager.ImpulseEvent CreateAndReturnEvent(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity) { }
        private Cinemachine.CinemachineImpulseManager.ImpulseEvent LegacyCreateAndReturnEvent(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B6
    public class CinemachineImpulseListener : CinemachineExtension
    {
        // Fields
        public Cinemachine.CinemachineCore.Stage m_ApplyAfter;        // 0x28
        public System.Int32 m_ChannelMask;        // 0x2C
        public System.Single m_Gain;        // 0x30
        public System.Boolean m_Use2DDistance;        // 0x34
        public System.Boolean m_UseCameraSpace;        // 0x35
        public Cinemachine.CinemachineImpulseListener.ImpulseReaction m_ReactionSettings;        // 0x38

        // Methods
        private System.Void Reset() { }
        private System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B8
    public class CinemachineImpulseChannelPropertyAttribute : PropertyAttribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B9
    public class CinemachineImpulseManager
    {
        // Fields
        private static Cinemachine.CinemachineImpulseManager sInstance;        // 0x0
        private System.Collections.Generic.List<Cinemachine.CinemachineImpulseManager.ImpulseEvent> m_ExpiredEvents;        // 0x10
        private System.Collections.Generic.List<Cinemachine.CinemachineImpulseManager.ImpulseEvent> m_ActiveEvents;        // 0x18
        public System.Boolean IgnoreTimeScale;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private Cinemachine.CinemachineImpulseManager get_Instance() { }
        private System.Void InitializeModule() { }
        private System.Single EvaluateDissipationScale(System.Single spread, System.Single normalizedDistance) { }
        private System.Boolean GetImpulseAt(UnityEngine.Vector3 listenerLocation, System.Boolean distance2D, System.Int32 channelMask, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot) { }
        private System.Single get_CurrentTime() { }
        private Cinemachine.CinemachineImpulseManager.ImpulseEvent NewImpulseEvent() { }
        private System.Void AddImpulseEvent(Cinemachine.CinemachineImpulseManager.ImpulseEvent e) { }
        private System.Void Clear() { }

    }

    // TypeToken: 0x20000BE
    public class CinemachineImpulseSource : MonoBehaviour
    {
        // Fields
        public Cinemachine.CinemachineImpulseDefinition m_ImpulseDefinition;        // 0x18
        public UnityEngine.Vector3 m_DefaultVelocity;        // 0x20

        // Methods
        private System.Void OnValidate() { }
        private System.Void Reset() { }
        private System.Void GenerateImpulseAtPositionWithVelocity(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity) { }
        private System.Void GenerateImpulseWithVelocity(UnityEngine.Vector3 velocity) { }
        private System.Void GenerateImpulseWithForce(System.Single force) { }
        private System.Void GenerateImpulse() { }
        private System.Void GenerateImpulseAt(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity) { }
        private System.Void GenerateImpulse(UnityEngine.Vector3 velocity) { }
        private System.Void GenerateImpulse(System.Single force) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BF
    public class CinemachineIndependentImpulseListener : MonoBehaviour
    {
        // Fields
        private UnityEngine.Vector3 impulsePosLastFrame;        // 0x18
        private UnityEngine.Quaternion impulseRotLastFrame;        // 0x24
        public System.Int32 m_ChannelMask;        // 0x34
        public System.Single m_Gain;        // 0x38
        public System.Boolean m_Use2DDistance;        // 0x3C
        public System.Boolean m_UseLocalSpace;        // 0x3D
        public Cinemachine.CinemachineImpulseListener.ImpulseReaction m_ReactionSettings;        // 0x40

        // Methods
        private System.Void Reset() { }
        private System.Void OnEnable() { }
        private System.Void Update() { }
        private System.Void LateUpdate() { }
        private System.Void .ctor() { }

    }

}

namespace Cinemachine.PostFX
{

    // TypeToken: 0x20000C0
    public class CinemachinePostProcessing : CinemachineExtension
    {
        // Methods
        private System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C1
    public class CinemachineVolumeSettings : MonoBehaviour
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace Cinemachine.Utility
{

    // TypeToken: 0x20000C2
    public class CinemachineDebug
    {
        // Fields
        private static System.Collections.Generic.HashSet<UnityEngine.Object> mClients;        // 0x0
        public static Cinemachine.Utility.CinemachineDebug.OnGUIDelegate OnGUIHandlers;        // 0x8
        private static System.Collections.Generic.List<System.Text.StringBuilder> mAvailableStringBuilders;        // 0x10

        // Methods
        private System.Void ReleaseScreenPos(UnityEngine.Object client) { }
        private UnityEngine.Rect GetScreenPos(UnityEngine.Object client, System.String text, UnityEngine.GUIStyle style) { }
        private System.Text.StringBuilder SBFromPool() { }
        private System.Void ReturnToPool(System.Text.StringBuilder sb) { }

    }

    // TypeToken: 0x20000C4
    public class PositionPredictor
    {
        // Fields
        private UnityEngine.Vector3 m_Velocity;        // 0x10
        private UnityEngine.Vector3 m_SmoothDampVelocity;        // 0x1C
        private UnityEngine.Vector3 m_Pos;        // 0x28
        private System.Boolean m_HavePos;        // 0x34
        public System.Single Smoothing;        // 0x38

        // Methods
        private System.Void ApplyTransformDelta(UnityEngine.Vector3 positionDelta) { }
        private System.Void Reset() { }
        private System.Void AddPosition(UnityEngine.Vector3 pos, System.Single deltaTime, System.Single lookaheadTime) { }
        private UnityEngine.Vector3 PredictPositionDelta(System.Single lookaheadTime) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C5
    public class Damper
    {
        // Methods
        private System.Single Damp(System.Single initial, System.Single dampTime, System.Single deltaTime) { }
        private UnityEngine.Vector3 Damp(UnityEngine.Vector3 initial, UnityEngine.Vector3 dampTime, System.Single deltaTime) { }
        private UnityEngine.Vector3 Damp(UnityEngine.Vector3 initial, System.Single dampTime, System.Single deltaTime) { }

    }

    // TypeToken: 0x20000C6
    public class HeadingTracker
    {
        // Fields
        private Cinemachine.Utility.HeadingTracker.Item[] mHistory;        // 0x10
        private System.Int32 mTop;        // 0x18
        private System.Int32 mBottom;        // 0x1C
        private System.Int32 mCount;        // 0x20
        private UnityEngine.Vector3 mHeadingSum;        // 0x24
        private System.Single mWeightSum;        // 0x30
        private System.Single mWeightTime;        // 0x34
        private UnityEngine.Vector3 mLastGoodHeading;        // 0x38
        private static System.Single mDecayExponent;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 filterSize) { }
        private System.Int32 get_FilterSize() { }
        private System.Void ClearHistory() { }
        private System.Single Decay(System.Single time) { }
        private System.Void Add(UnityEngine.Vector3 velocity) { }
        private System.Void PopBottom() { }
        private System.Void DecayHistory() { }
        private UnityEngine.Vector3 GetReliableHeading() { }

    }

    // TypeToken: 0x20000C8
    public class SplineHelpers
    {
        // Methods
        private UnityEngine.Vector3 Bezier3(System.Single t, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3) { }
        private UnityEngine.Vector3 BezierTangent3(System.Single t, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3) { }
        private System.Single Bezier1(System.Single t, System.Single p0, System.Single p1, System.Single p2, System.Single p3) { }
        private System.Void ComputeSmoothControlPoints(UnityEngine.Vector4[]& knot, UnityEngine.Vector4[]& ctrl1, UnityEngine.Vector4[]& ctrl2) { }
        private System.Void ComputeSmoothControlPointsLooped(UnityEngine.Vector4[]& knot, UnityEngine.Vector4[]& ctrl1, UnityEngine.Vector4[]& ctrl2) { }

    }

    // TypeToken: 0x20000C9
    public class UnityVectorExtensions
    {
        // Methods
        private System.Boolean IsNaN(UnityEngine.Vector3 v) { }
        private System.Single ClosestPointOnSegment(UnityEngine.Vector3 p, UnityEngine.Vector3 s0, UnityEngine.Vector3 s1) { }
        private System.Single ClosestPointOnSegment(UnityEngine.Vector2 p, UnityEngine.Vector2 s0, UnityEngine.Vector2 s1) { }
        private UnityEngine.Vector3 ProjectOntoPlane(UnityEngine.Vector3 vector, UnityEngine.Vector3 planeNormal) { }
        private UnityEngine.Vector2 Abs(UnityEngine.Vector2 v) { }
        private System.Boolean IsUniform(UnityEngine.Vector2 v) { }
        private System.Boolean AlmostZero(UnityEngine.Vector3 v) { }
        private System.Single Angle(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2) { }
        private System.Single SignedAngle(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, UnityEngine.Vector3 up) { }
        private UnityEngine.Quaternion SafeFromToRotation(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, UnityEngine.Vector3 up) { }

    }

    // TypeToken: 0x20000CA
    public class UnityQuaternionExtensions
    {
        // Methods
        private UnityEngine.Quaternion SlerpWithReferenceUp(UnityEngine.Quaternion qA, UnityEngine.Quaternion qB, System.Single t, UnityEngine.Vector3 up) { }
        private UnityEngine.Quaternion Normalized(UnityEngine.Quaternion q) { }
        private UnityEngine.Vector2 GetCameraRotationToTarget(UnityEngine.Quaternion orient, UnityEngine.Vector3 lookAtDir, UnityEngine.Vector3 worldUp) { }
        private UnityEngine.Quaternion ApplyCameraRotation(UnityEngine.Quaternion orient, UnityEngine.Vector2 rot, UnityEngine.Vector3 worldUp) { }

    }

}

