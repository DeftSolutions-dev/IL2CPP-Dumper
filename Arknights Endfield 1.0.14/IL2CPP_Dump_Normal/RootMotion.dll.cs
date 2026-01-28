// ========================================================
// Dumped by @desirepro
// Assembly: RootMotion.dll
// Classes:  226
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000003
    public struct Mode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static RootMotion.Baker.Mode AnimationClips;        // 0x0
        public static RootMotion.Baker.Mode AnimationStates;        // 0x0
        public static RootMotion.Baker.Mode PlayableDirector;        // 0x0
        public static RootMotion.Baker.Mode Realtime;        // 0x0

    }

    // TypeToken: 0x2000004
    public class BakerDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.AnimationClip clip, System.Single time) { }
        private System.IAsyncResult BeginInvoke(UnityEngine.AnimationClip clip, System.Single time, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000006
    public struct BasedUponRotation
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static RootMotion.Baker.ClipSettings.BasedUponRotation Original;        // 0x0
        public static RootMotion.Baker.ClipSettings.BasedUponRotation BodyOrientation;        // 0x0

    }

    // TypeToken: 0x2000007
    public struct BasedUponY
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static RootMotion.Baker.ClipSettings.BasedUponY Original;        // 0x0
        public static RootMotion.Baker.ClipSettings.BasedUponY CenterOfMass;        // 0x0
        public static RootMotion.Baker.ClipSettings.BasedUponY Feet;        // 0x0

    }

    // TypeToken: 0x2000008
    public struct BasedUponXZ
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static RootMotion.Baker.ClipSettings.BasedUponXZ Original;        // 0x0
        public static RootMotion.Baker.ClipSettings.BasedUponXZ CenterOfMass;        // 0x0

    }

    // TypeToken: 0x2000005
    public class ClipSettings
    {
        // Fields
        public System.Boolean loopTime;        // 0x10
        public System.Boolean loopBlend;        // 0x11
        public System.Single cycleOffset;        // 0x14
        public System.Boolean loopBlendOrientation;        // 0x18
        public RootMotion.Baker.ClipSettings.BasedUponRotation basedUponRotation;        // 0x1C
        public System.Single orientationOffsetY;        // 0x20
        public System.Boolean loopBlendPositionY;        // 0x24
        public RootMotion.Baker.ClipSettings.BasedUponY basedUponY;        // 0x28
        public System.Single level;        // 0x2C
        public System.Boolean loopBlendPositionXZ;        // 0x30
        public RootMotion.Baker.ClipSettings.BasedUponXZ basedUponXZ;        // 0x34
        public System.Boolean mirror;        // 0x38

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000014
    public class LimbOrientation
    {
        // Fields
        public UnityEngine.Vector3 upperBoneForwardAxis;        // 0x10
        public UnityEngine.Vector3 lowerBoneForwardAxis;        // 0x1C
        public UnityEngine.Vector3 lastBoneLeftAxis;        // 0x28

        // Methods
        private System.Void .ctor(UnityEngine.Vector3 upperBoneForwardAxis, UnityEngine.Vector3 lowerBoneForwardAxis, UnityEngine.Vector3 lastBoneLeftAxis) { }

    }

    // TypeToken: 0x2000016
    public struct BoneType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static RootMotion.BipedNaming.BoneType Unassigned;        // 0x0
        public static RootMotion.BipedNaming.BoneType Spine;        // 0x0
        public static RootMotion.BipedNaming.BoneType Head;        // 0x0
        public static RootMotion.BipedNaming.BoneType Arm;        // 0x0
        public static RootMotion.BipedNaming.BoneType Leg;        // 0x0
        public static RootMotion.BipedNaming.BoneType Tail;        // 0x0
        public static RootMotion.BipedNaming.BoneType Eye;        // 0x0

    }

    // TypeToken: 0x2000017
    public struct BoneSide
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static RootMotion.BipedNaming.BoneSide Center;        // 0x0
        public static RootMotion.BipedNaming.BoneSide Left;        // 0x0
        public static RootMotion.BipedNaming.BoneSide Right;        // 0x0

    }

    // TypeToken: 0x2000019
    public struct AutoDetectParams
    {
        // Fields
        public System.Boolean legsParentInSpine;        // 0x10
        public System.Boolean includeEyes;        // 0x11

        // Methods
        private System.Void .ctor(System.Boolean legsParentInSpine, System.Boolean includeEyes) { }
        private RootMotion.BipedReferences.AutoDetectParams get_Default() { }

    }

    // TypeToken: 0x200002E
    public class Logger : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.String message) { }
        private System.IAsyncResult BeginInvoke(System.String message, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000030
    public struct State
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static RootMotion.Demos.Navigator.State Idle;        // 0x0
        public static RootMotion.Demos.Navigator.State Seeking;        // 0x0
        public static RootMotion.Demos.Navigator.State OnPath;        // 0x0

    }

    // TypeToken: 0x200003A
    public struct DOF
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static RootMotion.FinalIK.Finger.DOF One;        // 0x0
        public static RootMotion.FinalIK.Finger.DOF Three;        // 0x0

    }

    // TypeToken: 0x200003D
    public class GrounderDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }
        private System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000040
    public class SpineEffector
    {
        // Fields
        public RootMotion.FinalIK.FullBodyBipedEffector effectorType;        // 0x10
        public System.Single horizontalWeight;        // 0x14
        public System.Single verticalWeight;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(RootMotion.FinalIK.FullBodyBipedEffector effectorType, System.Single horizontalWeight, System.Single verticalWeight) { }

    }

    // TypeToken: 0x2000043
    public struct Foot
    {
        // Fields
        public RootMotion.FinalIK.IKSolver solver;        // 0x10
        public UnityEngine.Transform transform;        // 0x18
        public UnityEngine.Quaternion rotation;        // 0x20
        public RootMotion.FinalIK.Grounding.Leg leg;        // 0x30

        // Methods
        private System.Void .ctor(RootMotion.FinalIK.IKSolver solver, UnityEngine.Transform transform) { }

    }

    // TypeToken: 0x2000045
    public struct Quality
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static RootMotion.FinalIK.Grounding.Quality Fastest;        // 0x0
        public static RootMotion.FinalIK.Grounding.Quality Simple;        // 0x0
        public static RootMotion.FinalIK.Grounding.Quality Best;        // 0x0
        public static RootMotion.FinalIK.Grounding.Quality Custom;        // 0x0

    }

    // TypeToken: 0x2000046
    public class OnRaycastDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.IAsyncResult BeginInvoke(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction, System.AsyncCallback callback, System.Object object) { }
        private System.Boolean EndInvoke(UnityEngine.RaycastHit& hitInfo, System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000047
    public class OnCapsuleCastDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.IAsyncResult BeginInvoke(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction, System.AsyncCallback callback, System.Object object) { }
        private System.Boolean EndInvoke(UnityEngine.RaycastHit& hitInfo, System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000048
    public class OnSphereCastDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) { }
        private System.IAsyncResult BeginInvoke(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction, System.AsyncCallback callback, System.Object object) { }
        private System.Boolean EndInvoke(UnityEngine.RaycastHit& hitInfo, System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000049
    public class Leg
    {
        // Fields
        private System.Boolean <isGrounded>k__BackingField;        // 0x10
        private UnityEngine.Vector3 <IKPosition>k__BackingField;        // 0x14
        public UnityEngine.Quaternion rotationOffset;        // 0x20
        private System.Boolean <initiated>k__BackingField;        // 0x30
        private System.Single <heightFromGround>k__BackingField;        // 0x34
        private System.Single <fowardMoveFromGround>k__BackingField;        // 0x38
        private System.Single <rightMoveFromGround>k__BackingField;        // 0x3C
        private UnityEngine.Vector3 <velocity>k__BackingField;        // 0x40
        private UnityEngine.Transform <transform>k__BackingField;        // 0x50
        private System.Single <IKOffset>k__BackingField;        // 0x58
        private System.Single <IKOffsetZ>k__BackingField;        // 0x5C
        private System.Single <IKOffsetX>k__BackingField;        // 0x60
        private UnityEngine.RaycastHit <heelHit>k__BackingField;        // 0x68
        private UnityEngine.RaycastHit <capsuleHit>k__BackingField;        // 0xA8
        public System.Boolean invertFootCenter;        // 0xE8
        private UnityEngine.Vector3 m_lastEntityPos;        // 0xEC
        private UnityEngine.Vector3 m_lastFootPos;        // 0xF8
        private UnityEngine.Vector3 m_lastHeelPoint;        // 0x104
        private UnityEngine.Vector3 m_lastToePoint;        // 0x110
        private UnityEngine.Vector3 m_lastSidePoint;        // 0x11C
        private RootMotion.FinalIK.Grounding grounding;        // 0x128
        private System.Single lastTime;        // 0x130
        private System.Single deltaTime;        // 0x134
        private UnityEngine.Vector3 lastPosition;        // 0x138
        private UnityEngine.Quaternion toHitNormal;        // 0x144
        private UnityEngine.Quaternion r;        // 0x154
        private UnityEngine.Vector3 up;        // 0x164
        private UnityEngine.Vector3 forward;        // 0x170
        private UnityEngine.Vector3 speedDir;        // 0x17C
        private UnityEngine.Vector3 lastTransformPosition;        // 0x188
        private System.Boolean doOverrideFootPosition;        // 0x194
        private UnityEngine.Vector3 overrideFootPosition;        // 0x198
        public UnityEngine.Vector3 transformPosition;        // 0x1A4
        private static readonly Unity.Profiling.ProfilerMarker MARKER_TEMP_PREDICT_FOOT_CAST;        // 0x0
        private static readonly Unity.Profiling.ProfilerMarker MARKER_TEMP_BUILTIN_BEST_CAST;        // 0x8
        public static System.Single MAX_PREDICTION_DISTANCE;        // 0x0
        private UnityEngine.Vector2 lastFramePredictPos;        // 0x1B0
        public UnityEngine.Vector3 predictOffset;        // 0x1B8
        public UnityEngine.Vector3 lastPredictOffset;        // 0x1C4
        public UnityEngine.Vector3 lastPredictOffsetwithPercent;        // 0x1D0
        private UnityEngine.Vector3 m_predictOffsetwithPercent;        // 0x1DC
        private System.Boolean hasPredictThisStep;        // 0x1E8
        public UnityEngine.RaycastHit curPredictHit;        // 0x1F0
        public System.Single curStepTime;        // 0x230
        public UnityEngine.RaycastHit curCapsuleHit;        // 0x238
        public UnityEngine.Vector3 lastLandFootPos;        // 0x278
        private System.Single feetOffsetFromRoot;        // 0x284
        public UnityEngine.Vector3 lastPathPoint;        // 0x288
        public UnityEngine.RaycastHit m_heelHit;        // 0x298
        public UnityEngine.Vector3 curFeetCalculatePos;        // 0x2D8
        private UnityEngine.Vector3 lastCurHitPoint;        // 0x2E4
        public UnityEngine.Vector3 predictLimitForwardOffset;        // 0x2F0
        private System.Single m_maxStep;        // 0x2FC
        private UnityEngine.Vector3 m_lastHitNormal;        // 0x300
        private System.Boolean m_isInStair;        // 0x30C
        public System.Single footSpeed;        // 0x310
        public System.Single heightFromRoot;        // 0x314
        public System.Boolean isLastFrameLegStretch;        // 0x318
        private UnityEngine.Vector3 lastCapusuleHitPos;        // 0x31C

        // Methods
        private System.Boolean get_isGrounded() { }
        private System.Void set_isGrounded(System.Boolean value) { }
        private UnityEngine.Vector3 get_IKPosition() { }
        private System.Void set_IKPosition(UnityEngine.Vector3 value) { }
        private System.Boolean get_initiated() { }
        private System.Void set_initiated(System.Boolean value) { }
        private System.Single get_heightFromGround() { }
        private System.Void set_heightFromGround(System.Single value) { }
        private System.Single get_fowardMoveFromGround() { }
        private System.Void set_fowardMoveFromGround(System.Single value) { }
        private System.Single get_rightMoveFromGround() { }
        private System.Void set_rightMoveFromGround(System.Single value) { }
        private UnityEngine.Vector3 get_velocity() { }
        private System.Void set_velocity(UnityEngine.Vector3 value) { }
        private UnityEngine.Transform get_transform() { }
        private System.Void set_transform(UnityEngine.Transform value) { }
        private System.Single get_IKOffset() { }
        private System.Void set_IKOffset(System.Single value) { }
        private System.Single get_IKOffsetZ() { }
        private System.Void set_IKOffsetZ(System.Single value) { }
        private System.Single get_IKOffsetX() { }
        private System.Void set_IKOffsetX(System.Single value) { }
        private UnityEngine.RaycastHit get_heelHit() { }
        private System.Void set_heelHit(UnityEngine.RaycastHit value) { }
        private UnityEngine.RaycastHit get_capsuleHit() { }
        private System.Void set_capsuleHit(UnityEngine.RaycastHit value) { }
        private UnityEngine.RaycastHit get_GetHitPoint() { }
        private System.Void SetFootPosition(UnityEngine.Vector3 position) { }
        private UnityEngine.Vector3 get_right() { }
        private UnityEngine.Vector3 get_speedRight() { }
        private System.Void Initiate(RootMotion.FinalIK.Grounding grounding, UnityEngine.Transform transform) { }
        private System.Void OnEnable() { }
        private System.Void Reset() { }
        private UnityEngine.Vector3 get_predictOffsetwithPercent() { }
        private System.Void _ResetPredictReference(UnityEngine.RaycastHit curHit) { }
        private System.Void _PredictNextStepHit(UnityEngine.Vector3 prediction, UnityEngine.Vector3 predictVec, System.Boolean canChangeHeight) { }
        private System.Single _CanHitPointLand(UnityEngine.RaycastHit hit, UnityEngine.RaycastHit& predictHit) { }
        private System.Boolean get_isLeft() { }
        private System.Boolean get_isMoving() { }
        private System.Void Process() { }
        private System.Void _UpdateHeelHit(System.Single curStepPercent, UnityEngine.Vector3 prediction) { }
        private UnityEngine.Vector3 _UpdatePredictOffset(System.Single curStepPercent) { }
        private System.Void FinalSetIKPosition(UnityEngine.Vector3 thighPos) { }
        private System.Single get_stepHeightFromGround() { }
        private System.Single get_stepForwardFromGround() { }
        private System.Single get_stepRightFromGround() { }
        private UnityEngine.RaycastHit GetCapsuleHit(UnityEngine.Vector3 offsetFromHeel, UnityEngine.Vector3 predictPos) { }
        private UnityEngine.RaycastHit GetCapsuleHit(UnityEngine.Vector3 offsetFromHeel) { }
        private UnityEngine.RaycastHit GetRaycastHitCustom(UnityEngine.Vector3 offsetFromHeel) { }
        private UnityEngine.RaycastHit GetRaycastHit(UnityEngine.Vector3 offsetFromHeel) { }
        private UnityEngine.Vector3 RotateNormal(UnityEngine.Vector3 normal) { }
        private System.Void SetFootToPoint(UnityEngine.Vector3 normal, UnityEngine.Vector3 point) { }
        private System.Void SetFootToPlane(UnityEngine.Vector3 planeNormal, UnityEngine.Vector3 planePoint, UnityEngine.Vector3 heelHitPoint) { }
        private System.Void SetFootToPoint(UnityEngine.Vector3 normal, UnityEngine.Vector3 pointForXZ, UnityEngine.Vector3 pointForY) { }
        private System.Void SetFootToPlane(UnityEngine.Vector3 planeNormal, UnityEngine.Vector3 planePoint, UnityEngine.Vector3 heelHitPoint, UnityEngine.Vector3 footNormal, System.Boolean isLimitByComplex) { }
        private System.Single GetHeightFromGround(UnityEngine.Vector3 hitPoint) { }
        private System.Void RotateFoot() { }
        private UnityEngine.Quaternion GetRotationOffsetTarget() { }
        private UnityEngine.Vector3 get_animFootGroundPos() { }
        private System.Single get_rootYOffset() { }
        private UnityEngine.Vector3 RotateNormalWithLimit(UnityEngine.Vector3 normal) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200004A
    public class Pelvis
    {
        // Fields
        private UnityEngine.Vector3 <IKOffset>k__BackingField;        // 0x10
        private System.Single <heightOffset>k__BackingField;        // 0x1C
        private System.Single forwardOffset;        // 0x20
        public System.Single pelivsSpeedY;        // 0x24
        private RootMotion.FinalIK.Grounding grounding;        // 0x28
        private UnityEngine.Vector3 lastRootPosition;        // 0x30
        private System.Single damperF;        // 0x3C
        private System.Boolean initiated;        // 0x40
        private System.Single lastTime;        // 0x44

        // Methods
        private UnityEngine.Vector3 get_IKOffset() { }
        private System.Void set_IKOffset(UnityEngine.Vector3 value) { }
        private System.Single get_heightOffset() { }
        private System.Void set_heightOffset(System.Single value) { }
        private System.Void Initiate(RootMotion.FinalIK.Grounding grounding) { }
        private System.Void Reset() { }
        private System.Void OnEnable() { }
        private System.Void Process(System.Single pelivsOffset, System.Single _forwardOffset, System.Boolean isGrounded, System.Boolean islastFrameLegStretch, System.Boolean isSameLegReflastFrame) { }
        private UnityEngine.RaycastHit GetRaycastHitCustom(UnityEngine.Vector3 rayOrigin) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000058
    public class References
    {
        // Fields
        public UnityEngine.Transform root;        // 0x10
        public UnityEngine.Transform pelvis;        // 0x18
        public UnityEngine.Transform spine;        // 0x20
        public UnityEngine.Transform chest;        // 0x28
        public UnityEngine.Transform neck;        // 0x30
        public UnityEngine.Transform head;        // 0x38
        public UnityEngine.Transform leftShoulder;        // 0x40
        public UnityEngine.Transform leftUpperArm;        // 0x48
        public UnityEngine.Transform leftForearm;        // 0x50
        public UnityEngine.Transform leftHand;        // 0x58
        public UnityEngine.Transform rightShoulder;        // 0x60
        public UnityEngine.Transform rightUpperArm;        // 0x68
        public UnityEngine.Transform rightForearm;        // 0x70
        public UnityEngine.Transform rightHand;        // 0x78
        public UnityEngine.Transform leftThigh;        // 0x80
        public UnityEngine.Transform leftCalf;        // 0x88
        public UnityEngine.Transform leftFoot;        // 0x90
        public UnityEngine.Transform leftToes;        // 0x98
        public UnityEngine.Transform rightThigh;        // 0xA0
        public UnityEngine.Transform rightCalf;        // 0xA8
        public UnityEngine.Transform rightFoot;        // 0xB0
        public UnityEngine.Transform rightToes;        // 0xB8

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(RootMotion.BipedReferences b) { }
        private UnityEngine.Transform[] GetTransforms() { }
        private System.Boolean get_isFilled() { }
        private System.Boolean get_isEmpty() { }
        private System.Boolean AutoDetectReferences(UnityEngine.Transform root, RootMotion.FinalIK.VRIK.References& references) { }

    }

    // TypeToken: 0x200005C
    public class BendBone
    {
        // Fields
        public UnityEngine.Transform transform;        // 0x10
        public System.Single weight;        // 0x18
        private UnityEngine.Quaternion defaultLocalRotation;        // 0x1C

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.Transform transform, System.Single weight) { }
        private System.Void StoreDefaultLocalState() { }
        private System.Void FixTransforms() { }

    }

    // TypeToken: 0x200005E
    public class ChildConstraint
    {
        // Fields
        public System.Single pushElasticity;        // 0x10
        public System.Single pullElasticity;        // 0x14
        private UnityEngine.Transform bone1;        // 0x18
        private UnityEngine.Transform bone2;        // 0x20
        private System.Single <nominalDistance>k__BackingField;        // 0x28
        private System.Boolean <isRigid>k__BackingField;        // 0x2C
        private System.Single crossFade;        // 0x30
        private System.Single inverseCrossFade;        // 0x34
        private System.Int32 chain1Index;        // 0x38
        private System.Int32 chain2Index;        // 0x3C

        // Methods
        private System.Single get_nominalDistance() { }
        private System.Void set_nominalDistance(System.Single value) { }
        private System.Boolean get_isRigid() { }
        private System.Void set_isRigid(System.Boolean value) { }
        private System.Void .ctor(UnityEngine.Transform bone1, UnityEngine.Transform bone2, System.Single pushElasticity, System.Single pullElasticity) { }
        private System.Void Initiate(RootMotion.FinalIK.IKSolverFullBody solver) { }
        private System.Void OnPreSolve(RootMotion.FinalIK.IKSolverFullBody solver) { }
        private System.Void Solve(RootMotion.FinalIK.IKSolverFullBody solver) { }

    }

    // TypeToken: 0x200005F
    public struct Smoothing
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static RootMotion.FinalIK.FBIKChain.Smoothing None;        // 0x0
        public static RootMotion.FinalIK.FBIKChain.Smoothing Exponential;        // 0x0
        public static RootMotion.FinalIK.FBIKChain.Smoothing Cubic;        // 0x0

    }

    // TypeToken: 0x2000063
    public class BoneMap
    {
        // Fields
        public UnityEngine.Transform transform;        // 0x10
        public System.Int32 chainIndex;        // 0x18
        public System.Int32 nodeIndex;        // 0x1C
        public UnityEngine.Vector3 defaultLocalPosition;        // 0x20
        public UnityEngine.Quaternion defaultLocalRotation;        // 0x2C
        public UnityEngine.Vector3 localSwingAxis;        // 0x3C
        public UnityEngine.Vector3 localTwistAxis;        // 0x48
        public UnityEngine.Vector3 planePosition;        // 0x54
        public UnityEngine.Vector3 ikPosition;        // 0x60
        public UnityEngine.Quaternion defaultLocalTargetRotation;        // 0x6C
        private UnityEngine.Quaternion maintainRotation;        // 0x7C
        public System.Single length;        // 0x8C
        public UnityEngine.Quaternion animatedRotation;        // 0x90
        private UnityEngine.Transform planeBone1;        // 0xA0
        private UnityEngine.Transform planeBone2;        // 0xA8
        private UnityEngine.Transform planeBone3;        // 0xB0
        private System.Int32 plane1ChainIndex;        // 0xB8
        private System.Int32 plane1NodeIndex;        // 0xBC
        private System.Int32 plane2ChainIndex;        // 0xC0
        private System.Int32 plane2NodeIndex;        // 0xC4
        private System.Int32 plane3ChainIndex;        // 0xC8
        private System.Int32 plane3NodeIndex;        // 0xCC

        // Methods
        private System.Void Initiate(UnityEngine.Transform transform, RootMotion.FinalIK.IKSolverFullBody solver) { }
        private UnityEngine.Vector3 get_swingDirection() { }
        private System.Void StoreDefaultLocalState() { }
        private System.Void FixTransform(System.Boolean position) { }
        private System.Boolean get_isNodeBone() { }
        private System.Void SetLength(RootMotion.FinalIK.IKMapping.BoneMap nextBone) { }
        private System.Void SetLocalSwingAxis(RootMotion.FinalIK.IKMapping.BoneMap swingTarget) { }
        private System.Void SetLocalSwingAxis(RootMotion.FinalIK.IKMapping.BoneMap bone1, RootMotion.FinalIK.IKMapping.BoneMap bone2) { }
        private System.Void SetLocalTwistAxis(UnityEngine.Vector3 twistDirection, UnityEngine.Vector3 normalDirection) { }
        private System.Void SetPlane(RootMotion.FinalIK.IKSolverFullBody solver, UnityEngine.Transform planeBone1, UnityEngine.Transform planeBone2, UnityEngine.Transform planeBone3) { }
        private System.Void UpdatePlane(System.Boolean rotation, System.Boolean position) { }
        private System.Void SetIKPosition() { }
        private System.Void MaintainRotation() { }
        private System.Void SetToIKPosition() { }
        private System.Void FixToNode(RootMotion.FinalIK.IKSolverFullBody solver, System.Single weight, RootMotion.FinalIK.IKSolver.Node fixNode) { }
        private UnityEngine.Vector3 GetPlanePosition(RootMotion.FinalIK.IKSolverFullBody solver) { }
        private System.Void PositionToPlane(RootMotion.FinalIK.IKSolverFullBody solver) { }
        private System.Void RotateToPlane(RootMotion.FinalIK.IKSolverFullBody solver, System.Single weight) { }
        private System.Void Swing(UnityEngine.Vector3 swingTarget, System.Single weight) { }
        private System.Void Swing(UnityEngine.Vector3 pos1, UnityEngine.Vector3 pos2, System.Single weight) { }
        private System.Void Twist(UnityEngine.Vector3 twistDirection, UnityEngine.Vector3 normalDirection, System.Single weight) { }
        private System.Void RotateToMaintain(System.Single weight) { }
        private System.Void RotateToEffector(RootMotion.FinalIK.IKSolverFullBody solver, System.Single weight) { }
        private UnityEngine.Quaternion GetTargetRotation(RootMotion.FinalIK.IKSolverFullBody solver) { }
        private UnityEngine.Quaternion get_lastAnimatedTargetRotation() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000066
    public struct BoneMapType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static RootMotion.FinalIK.IKMappingLimb.BoneMapType Parent;        // 0x0
        public static RootMotion.FinalIK.IKMappingLimb.BoneMapType Bone1;        // 0x0
        public static RootMotion.FinalIK.IKMappingLimb.BoneMapType Bone2;        // 0x0
        public static RootMotion.FinalIK.IKMappingLimb.BoneMapType Bone3;        // 0x0

    }

    // TypeToken: 0x2000069
    public class Point
    {
        // Fields
        public UnityEngine.Transform transform;        // 0x10
        public System.Single weight;        // 0x18
        public UnityEngine.Vector3 solverPosition;        // 0x1C
        public UnityEngine.Quaternion solverRotation;        // 0x28
        public UnityEngine.Vector3 defaultLocalPosition;        // 0x38
        public UnityEngine.Quaternion defaultLocalRotation;        // 0x44

        // Methods
        private System.Void StoreDefaultLocalState() { }
        private System.Void FixTransform() { }
        private System.Void UpdateSolverPosition() { }
        private System.Void UpdateSolverLocalPosition() { }
        private System.Void UpdateSolverState() { }
        private System.Void UpdateSolverLocalState() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006A
    public class Bone : Point
    {
        // Fields
        public System.Single length;        // 0x58
        public System.Single sqrMag;        // 0x5C
        public UnityEngine.Vector3 axis;        // 0x60
        private RootMotion.FinalIK.RotationLimit _rotationLimit;        // 0x70
        private System.Boolean isLimited;        // 0x78

        // Methods
        private RootMotion.FinalIK.RotationLimit get_rotationLimit() { }
        private System.Void set_rotationLimit(RootMotion.FinalIK.RotationLimit value) { }
        private System.Void Swing(UnityEngine.Vector3 swingTarget, System.Single weight) { }
        private System.Void SolverSwing(RootMotion.FinalIK.IKSolver.Bone[] bones, System.Int32 index, UnityEngine.Vector3 swingTarget, System.Single weight) { }
        private System.Void Swing2D(UnityEngine.Vector3 swingTarget, System.Single weight) { }
        private System.Void SetToSolverPosition() { }
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.Transform transform) { }
        private System.Void .ctor(UnityEngine.Transform transform, System.Single weight) { }

    }

    // TypeToken: 0x200006B
    public class Node : Point
    {
        // Fields
        public System.Single length;        // 0x58
        public System.Single effectorPositionWeight;        // 0x5C
        public System.Single effectorRotationWeight;        // 0x60
        public UnityEngine.Vector3 offset;        // 0x64

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.Transform transform) { }
        private System.Void .ctor(UnityEngine.Transform transform, System.Single weight) { }

    }

    // TypeToken: 0x200006C
    public class UpdateDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }
        private System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200006D
    public class IterationDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Int32 i) { }
        private System.IAsyncResult BeginInvoke(System.Int32 i, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200007A
    public struct BendModifier
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static RootMotion.FinalIK.IKSolverLimb.BendModifier Animation;        // 0x0
        public static RootMotion.FinalIK.IKSolverLimb.BendModifier Target;        // 0x0
        public static RootMotion.FinalIK.IKSolverLimb.BendModifier Parent;        // 0x0
        public static RootMotion.FinalIK.IKSolverLimb.BendModifier Arm;        // 0x0
        public static RootMotion.FinalIK.IKSolverLimb.BendModifier Goal;        // 0x0

    }

    // TypeToken: 0x200007B
    public struct AxisDirection
    {
        // Fields
        public UnityEngine.Vector3 direction;        // 0x10
        public UnityEngine.Vector3 axis;        // 0x1C
        public System.Single dot;        // 0x28

        // Methods
        private System.Void .ctor(UnityEngine.Vector3 direction, UnityEngine.Vector3 axis) { }

    }

    // TypeToken: 0x200007D
    public class LookAtBone : Bone
    {
        // Fields
        public UnityEngine.Vector3 positionOffset;        // 0x80
        public UnityEngine.Vector3 baseForwardOffsetEuler;        // 0x8C

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.Transform transform) { }
        private System.Void Initiate(UnityEngine.Transform root) { }
        private System.Void LookAt(UnityEngine.Vector3 direction, System.Single weight) { }
        private UnityEngine.Quaternion LookAtReturnRotation(UnityEngine.Vector3 direction, System.Single weight) { }
        private UnityEngine.Vector3 get_forward() { }

    }

    // TypeToken: 0x200007F
    public class TrigonometricBone : Bone
    {
        // Fields
        private UnityEngine.Quaternion targetToLocalSpace;        // 0x80
        private UnityEngine.Vector3 defaultLocalBendNormal;        // 0x90

        // Methods
        private System.Void Initiate(UnityEngine.Vector3 childPosition, UnityEngine.Vector3 bendNormal) { }
        private UnityEngine.Quaternion GetRotation(UnityEngine.Vector3 direction, UnityEngine.Vector3 bendNormal) { }
        private UnityEngine.Vector3 GetBendNormalFromCurrentRotation() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000082
    public struct ShoulderRotationMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static RootMotion.FinalIK.IKSolverVR.Arm.ShoulderRotationMode YawPitch;        // 0x0
        public static RootMotion.FinalIK.IKSolverVR.Arm.ShoulderRotationMode FromTo;        // 0x0

    }

    // TypeToken: 0x2000081
    public class Arm : BodyPart
    {
        // Fields
        public UnityEngine.Transform target;        // 0x48
        public System.Single positionWeight;        // 0x50
        public System.Single rotationWeight;        // 0x54
        public System.Single shoulderRotationWeight;        // 0x58
        public RootMotion.FinalIK.IKSolverVR.Arm.ShoulderRotationMode shoulderRotationMode;        // 0x5C
        public System.Single shoulderTwistWeight;        // 0x60
        public System.Single shoulderYawOffset;        // 0x64
        public System.Single shoulderPitchOffset;        // 0x68
        public UnityEngine.Transform bendGoal;        // 0x70
        public System.Single bendGoalWeight;        // 0x78
        public System.Single swivelOffset;        // 0x7C
        public UnityEngine.Vector3 wristToPalmAxis;        // 0x80
        public UnityEngine.Vector3 palmToThumbAxis;        // 0x8C
        public System.Single armLengthMlp;        // 0x98
        public UnityEngine.AnimationCurve stretchCurve;        // 0xA0
        public UnityEngine.Vector3 IKPosition;        // 0xA8
        public UnityEngine.Quaternion IKRotation;        // 0xB4
        public UnityEngine.Vector3 bendDirection;        // 0xC4
        public UnityEngine.Vector3 handPositionOffset;        // 0xD0
        private UnityEngine.Vector3 <position>k__BackingField;        // 0xDC
        private UnityEngine.Quaternion <rotation>k__BackingField;        // 0xE8
        private System.Boolean hasShoulder;        // 0xF8
        private UnityEngine.Vector3 chestForwardAxis;        // 0xFC
        private UnityEngine.Vector3 chestUpAxis;        // 0x108
        private UnityEngine.Quaternion chestRotation;        // 0x114
        private UnityEngine.Vector3 chestForward;        // 0x124
        private UnityEngine.Vector3 chestUp;        // 0x130
        private UnityEngine.Quaternion forearmRelToUpperArm;        // 0x13C
        private UnityEngine.Vector3 upperArmBendAxis;        // 0x14C

        // Methods
        private UnityEngine.Vector3 get_position() { }
        private System.Void set_position(UnityEngine.Vector3 value) { }
        private UnityEngine.Quaternion get_rotation() { }
        private System.Void set_rotation(UnityEngine.Quaternion value) { }
        private RootMotion.FinalIK.IKSolverVR.VirtualBone get_shoulder() { }
        private RootMotion.FinalIK.IKSolverVR.VirtualBone get_upperArm() { }
        private RootMotion.FinalIK.IKSolverVR.VirtualBone get_forearm() { }
        private RootMotion.FinalIK.IKSolverVR.VirtualBone get_hand() { }
        private System.Void OnRead(UnityEngine.Vector3[] positions, UnityEngine.Quaternion[] rotations, System.Boolean hasChest, System.Boolean hasNeck, System.Boolean hasShoulders, System.Boolean hasToes, System.Boolean hasLegs, System.Int32 rootIndex, System.Int32 index) { }
        private System.Void PreSolve(System.Single scale) { }
        private System.Void ApplyOffsets(System.Single scale) { }
        private System.Void Stretching() { }
        private System.Void Solve(System.Boolean isLeft) { }
        private System.Void ResetOffsets() { }
        private System.Void Write(UnityEngine.Vector3[]& solvedPositions, UnityEngine.Quaternion[]& solvedRotations) { }
        private System.Single DamperValue(System.Single value, System.Single min, System.Single max, System.Single weight) { }
        private UnityEngine.Vector3 GetBendNormal(UnityEngine.Vector3 dir) { }
        private System.Void Visualize(RootMotion.FinalIK.IKSolverVR.VirtualBone bone1, RootMotion.FinalIK.IKSolverVR.VirtualBone bone2, RootMotion.FinalIK.IKSolverVR.VirtualBone bone3, UnityEngine.Color color) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000083
    public class BodyPart
    {
        // Fields
        private System.Single <sqrMag>k__BackingField;        // 0x10
        private System.Single <mag>k__BackingField;        // 0x14
        public RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones;        // 0x18
        protected System.Boolean initiated;        // 0x20
        protected UnityEngine.Vector3 rootPosition;        // 0x24
        protected UnityEngine.Quaternion rootRotation;        // 0x30
        protected System.Int32 index;        // 0x40
        protected System.Int32 LOD;        // 0x44

        // Methods
        private System.Void OnRead(UnityEngine.Vector3[] positions, UnityEngine.Quaternion[] rotations, System.Boolean hasChest, System.Boolean hasNeck, System.Boolean hasShoulders, System.Boolean hasToes, System.Boolean hasLegs, System.Int32 rootIndex, System.Int32 index) { }
        private System.Void PreSolve(System.Single scale) { }
        private System.Void Write(UnityEngine.Vector3[]& solvedPositions, UnityEngine.Quaternion[]& solvedRotations) { }
        private System.Void ApplyOffsets(System.Single scale) { }
        private System.Void ResetOffsets() { }
        private System.Single get_sqrMag() { }
        private System.Void set_sqrMag(System.Single value) { }
        private System.Single get_mag() { }
        private System.Void set_mag(System.Single value) { }
        private System.Void SetLOD(System.Int32 LOD) { }
        private System.Void Read(UnityEngine.Vector3[] positions, UnityEngine.Quaternion[] rotations, System.Boolean hasChest, System.Boolean hasNeck, System.Boolean hasShoulders, System.Boolean hasToes, System.Boolean hasLegs, System.Int32 rootIndex, System.Int32 index) { }
        private System.Void MovePosition(UnityEngine.Vector3 position) { }
        private System.Void MoveRotation(UnityEngine.Quaternion rotation) { }
        private System.Void Translate(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        private System.Void TranslateRoot(UnityEngine.Vector3 newRootPos, UnityEngine.Quaternion newRootRot) { }
        private System.Void RotateTo(RootMotion.FinalIK.IKSolverVR.VirtualBone bone, UnityEngine.Quaternion rotation, System.Single weight) { }
        private System.Void Visualize(UnityEngine.Color color) { }
        private System.Void Visualize() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000084
    public class Footstep
    {
        // Fields
        public System.Single stepSpeed;        // 0x10
        public UnityEngine.Vector3 characterSpaceOffset;        // 0x14
        public UnityEngine.Vector3 position;        // 0x20
        public UnityEngine.Quaternion rotation;        // 0x2C
        public UnityEngine.Quaternion stepToRootRot;        // 0x3C
        public System.Boolean isSupportLeg;        // 0x4C
        public System.Boolean relaxFlag;        // 0x4D
        private System.Single <stepProgress>k__BackingField;        // 0x50
        public UnityEngine.Vector3 stepFrom;        // 0x54
        public UnityEngine.Vector3 stepTo;        // 0x60
        public UnityEngine.Quaternion stepFromRot;        // 0x6C
        public UnityEngine.Quaternion stepToRot;        // 0x7C
        private UnityEngine.Quaternion footRelativeToRoot;        // 0x8C
        private System.Single supportLegW;        // 0x9C
        private System.Single supportLegWV;        // 0xA0

        // Methods
        private System.Boolean get_isStepping() { }
        private System.Single get_stepProgress() { }
        private System.Void set_stepProgress(System.Single value) { }
        private System.Void .ctor(UnityEngine.Quaternion rootRotation, UnityEngine.Vector3 footPosition, UnityEngine.Quaternion footRotation, UnityEngine.Vector3 characterSpaceOffset) { }
        private System.Void Reset(UnityEngine.Quaternion rootRotation, UnityEngine.Vector3 footPosition, UnityEngine.Quaternion footRotation) { }
        private System.Void StepTo(UnityEngine.Vector3 p, UnityEngine.Quaternion rootRotation, System.Single stepThreshold) { }
        private System.Void UpdateStepping(UnityEngine.Vector3 p, UnityEngine.Quaternion rootRotation, System.Single speed, System.Single deltaTime) { }
        private System.Void UpdateStanding(UnityEngine.Quaternion rootRotation, System.Single minAngle, System.Single speed, System.Single deltaTime) { }
        private System.Void Update(RootMotion.InterpolationMode interpolation, UnityEngine.Events.UnityEvent onStep, System.Single deltaTime) { }

    }

    // TypeToken: 0x2000085
    public class Leg : BodyPart
    {
        // Fields
        public UnityEngine.Transform target;        // 0x48
        public System.Single positionWeight;        // 0x50
        public System.Single rotationWeight;        // 0x54
        public UnityEngine.Transform bendGoal;        // 0x58
        public System.Single bendGoalWeight;        // 0x60
        public System.Single swivelOffset;        // 0x64
        public System.Single bendToTargetWeight;        // 0x68
        public System.Single legLengthMlp;        // 0x6C
        public UnityEngine.AnimationCurve stretchCurve;        // 0x70
        public UnityEngine.Vector3 IKPosition;        // 0x78
        public UnityEngine.Quaternion IKRotation;        // 0x84
        public UnityEngine.Vector3 footPositionOffset;        // 0x94
        public UnityEngine.Vector3 heelPositionOffset;        // 0xA0
        public UnityEngine.Quaternion footRotationOffset;        // 0xAC
        public System.Single currentMag;        // 0xBC
        public System.Boolean useAnimatedBendNormal;        // 0xC0
        private UnityEngine.Vector3 <position>k__BackingField;        // 0xC4
        private UnityEngine.Quaternion <rotation>k__BackingField;        // 0xD0
        private System.Boolean <hasToes>k__BackingField;        // 0xE0
        private UnityEngine.Vector3 <thighRelativeToPelvis>k__BackingField;        // 0xE4
        private UnityEngine.Vector3 footPosition;        // 0xF0
        private UnityEngine.Quaternion footRotation;        // 0xFC
        private UnityEngine.Vector3 bendNormal;        // 0x10C
        private UnityEngine.Quaternion calfRelToThigh;        // 0x118
        private UnityEngine.Quaternion thighRelToFoot;        // 0x128
        private UnityEngine.Vector3 <bendNormalRelToPelvis>k__BackingField;        // 0x138
        private UnityEngine.Vector3 <bendNormalRelToTarget>k__BackingField;        // 0x144

        // Methods
        private UnityEngine.Vector3 get_position() { }
        private System.Void set_position(UnityEngine.Vector3 value) { }
        private UnityEngine.Quaternion get_rotation() { }
        private System.Void set_rotation(UnityEngine.Quaternion value) { }
        private System.Boolean get_hasToes() { }
        private System.Void set_hasToes(System.Boolean value) { }
        private RootMotion.FinalIK.IKSolverVR.VirtualBone get_thigh() { }
        private RootMotion.FinalIK.IKSolverVR.VirtualBone get_calf() { }
        private RootMotion.FinalIK.IKSolverVR.VirtualBone get_foot() { }
        private RootMotion.FinalIK.IKSolverVR.VirtualBone get_toes() { }
        private RootMotion.FinalIK.IKSolverVR.VirtualBone get_lastBone() { }
        private UnityEngine.Vector3 get_thighRelativeToPelvis() { }
        private System.Void set_thighRelativeToPelvis(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_bendNormalRelToPelvis() { }
        private System.Void set_bendNormalRelToPelvis(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_bendNormalRelToTarget() { }
        private System.Void set_bendNormalRelToTarget(UnityEngine.Vector3 value) { }
        private System.Void OnRead(UnityEngine.Vector3[] positions, UnityEngine.Quaternion[] rotations, System.Boolean hasChest, System.Boolean hasNeck, System.Boolean hasShoulders, System.Boolean hasToes, System.Boolean hasLegs, System.Int32 rootIndex, System.Int32 index) { }
        private System.Void PreSolve(System.Single scale) { }
        private System.Void ApplyOffsets(System.Single scale) { }
        private System.Void ApplyPositionOffset(UnityEngine.Vector3 offset, System.Single weight) { }
        private System.Void ApplyRotationOffset(UnityEngine.Quaternion offset, System.Single weight) { }
        private System.Void Solve(System.Boolean stretch) { }
        private System.Void FixTwistRotations() { }
        private System.Void Stretching() { }
        private System.Void Write(UnityEngine.Vector3[]& solvedPositions, UnityEngine.Quaternion[]& solvedRotations) { }
        private System.Void ResetOffsets() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000087
    public struct Mode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static RootMotion.FinalIK.IKSolverVR.Locomotion.Mode Procedural;        // 0x0
        public static RootMotion.FinalIK.IKSolverVR.Locomotion.Mode Animated;        // 0x0

    }

    // TypeToken: 0x2000086
    public class Locomotion
    {
        // Fields
        public RootMotion.FinalIK.IKSolverVR.Locomotion.Mode mode;        // 0x10
        public System.Single weight;        // 0x14
        public System.Single moveThreshold;        // 0x18
        private System.Byte animationHeader;        // 0x1C
        public System.Single minAnimationSpeed;        // 0x20
        public System.Single maxAnimationSpeed;        // 0x24
        public System.Single animationSmoothTime;        // 0x28
        private System.Byte rootPositionHeader;        // 0x2C
        public UnityEngine.Vector2 standOffset;        // 0x30
        public System.Single rootLerpSpeedWhileMoving;        // 0x38
        public System.Single rootLerpSpeedWhileStopping;        // 0x3C
        public System.Single rootLerpSpeedWhileTurning;        // 0x40
        public System.Single maxRootOffset;        // 0x44
        private System.Byte rootRotationHeader;        // 0x48
        public System.Single maxRootAngleMoving;        // 0x4C
        public System.Single maxRootAngleStanding;        // 0x50
        public System.Single stepLengthMlp;        // 0x54
        private UnityEngine.Animator animator;        // 0x58
        private UnityEngine.Vector3 velocityLocal;        // 0x60
        private UnityEngine.Vector3 velocityLocalV;        // 0x6C
        private UnityEngine.Vector3 lastCorrection;        // 0x78
        private UnityEngine.Vector3 lastHeadTargetPos;        // 0x84
        private UnityEngine.Vector3 lastSpeedRootPos;        // 0x90
        private UnityEngine.Vector3 lastEndRootPos;        // 0x9C
        private System.Single rootLerpSpeed;        // 0xA8
        private System.Single rootVelocityV;        // 0xAC
        private System.Single animSpeed;        // 0xB0
        private System.Single animSpeedV;        // 0xB4
        private System.Single stopMoveTimer;        // 0xB8
        private System.Single turn;        // 0xBC
        private System.Single maxRootAngleV;        // 0xC0
        private System.Single currentAnimationSmoothTime;        // 0xC4
        private System.Boolean isMoving;        // 0xC8
        private System.Boolean firstFrame;        // 0xC9
        private static System.Int32 VRIK_Horizontal;        // 0x0
        private static System.Int32 VRIK_Vertical;        // 0x4
        private static System.Int32 VRIK_IsMoving;        // 0x8
        private static System.Int32 VRIK_Speed;        // 0xC
        private static System.Int32 VRIK_Turn;        // 0x10
        private static System.Boolean isHashed;        // 0x14
        private System.Single lastVelLocalMag;        // 0xCC
        public System.Single footDistance;        // 0xD0
        public System.Single stepThreshold;        // 0xD4
        public System.Single angleThreshold;        // 0xD8
        public System.Single comAngleMlp;        // 0xDC
        public System.Single maxVelocity;        // 0xE0
        public System.Single velocityFactor;        // 0xE4
        public System.Single maxLegStretch;        // 0xE8
        public System.Single rootSpeed;        // 0xEC
        public System.Single stepSpeed;        // 0xF0
        public UnityEngine.AnimationCurve stepHeight;        // 0xF8
        public System.Single maxBodyYOffset;        // 0x100
        public UnityEngine.AnimationCurve heelHeight;        // 0x108
        public System.Single relaxLegTwistMinAngle;        // 0x110
        public System.Single relaxLegTwistSpeed;        // 0x114
        public RootMotion.InterpolationMode stepInterpolation;        // 0x118
        public UnityEngine.Vector3 offset;        // 0x11C
        public System.Boolean blockingEnabled;        // 0x128
        public UnityEngine.LayerMask blockingLayers;        // 0x12C
        public System.Single raycastRadius;        // 0x130
        public System.Single raycastHeight;        // 0x134
        public UnityEngine.Events.UnityEvent onLeftFootstep;        // 0x138
        public UnityEngine.Events.UnityEvent onRightFootstep;        // 0x140
        private UnityEngine.Vector3 <centerOfMass>k__BackingField;        // 0x148
        private RootMotion.FinalIK.IKSolverVR.Footstep[] footsteps;        // 0x158
        private UnityEngine.Vector3 lastComPosition;        // 0x160
        private UnityEngine.Vector3 comVelocity;        // 0x16C
        private System.Int32 leftFootIndex;        // 0x178
        private System.Int32 rightFootIndex;        // 0x17C

        // Methods
        private System.Void Initiate(UnityEngine.Animator animator, UnityEngine.Vector3[] positions, UnityEngine.Quaternion[] rotations, System.Boolean hasToes, System.Single scale) { }
        private System.Void Reset(UnityEngine.Vector3[] positions, UnityEngine.Quaternion[] rotations) { }
        private System.Void Relax() { }
        private System.Void AddDeltaRotation(UnityEngine.Quaternion delta, UnityEngine.Vector3 pivot) { }
        private System.Void AddDeltaPosition(UnityEngine.Vector3 delta) { }
        private System.Void Initiate_Animated(UnityEngine.Animator animator, UnityEngine.Vector3[] positions) { }
        private System.Void ResetParams(UnityEngine.Vector3[] positions) { }
        private System.Void Reset_Animated(UnityEngine.Vector3[] positions) { }
        private System.Void AddDeltaRotation_Animated(UnityEngine.Quaternion delta, UnityEngine.Vector3 pivot) { }
        private System.Void AddDeltaPosition_Animated(UnityEngine.Vector3 delta) { }
        private System.Void Solve_Animated(RootMotion.FinalIK.IKSolverVR solver, System.Single scale, System.Single deltaTime) { }
        private UnityEngine.Vector3 get_centerOfMass() { }
        private System.Void set_centerOfMass(UnityEngine.Vector3 value) { }
        private System.Void Initiate_Procedural(UnityEngine.Vector3[] positions, UnityEngine.Quaternion[] rotations, System.Boolean hasToes, System.Single scale) { }
        private System.Void Reset_Procedural(UnityEngine.Vector3[] positions, UnityEngine.Quaternion[] rotations) { }
        private System.Void Relax_Procedural() { }
        private System.Void AddDeltaRotation_Procedural(UnityEngine.Quaternion delta, UnityEngine.Vector3 pivot) { }
        private System.Void AddDeltaPosition_Procedural(UnityEngine.Vector3 delta) { }
        private System.Void Solve_Procedural(RootMotion.FinalIK.IKSolverVR.VirtualBone rootBone, RootMotion.FinalIK.IKSolverVR.Spine spine, RootMotion.FinalIK.IKSolverVR.Leg leftLeg, RootMotion.FinalIK.IKSolverVR.Leg rightLeg, RootMotion.FinalIK.IKSolverVR.Arm leftArm, RootMotion.FinalIK.IKSolverVR.Arm rightArm, System.Int32 supportLegIndex, UnityEngine.Vector3& leftFootPosition, UnityEngine.Vector3& rightFootPosition, UnityEngine.Quaternion& leftFootRotation, UnityEngine.Quaternion& rightFootRotation, System.Single& leftFootOffset, System.Single& rightFootOffset, System.Single& leftHeelOffset, System.Single& rightHeelOffset, System.Single scale, System.Single deltaTime) { }
        private UnityEngine.Vector3 get_leftFootstepPosition() { }
        private UnityEngine.Vector3 get_rightFootstepPosition() { }
        private UnityEngine.Quaternion get_leftFootstepRotation() { }
        private UnityEngine.Quaternion get_rightFootstepRotation() { }
        private System.Boolean StepBlocked(UnityEngine.Vector3 fromPosition, UnityEngine.Vector3 toPosition, UnityEngine.Vector3 rootPosition) { }
        private System.Boolean CanStep() { }
        private System.Boolean GetLineSphereCollision(UnityEngine.Vector3 lineStart, UnityEngine.Vector3 lineEnd, UnityEngine.Vector3 sphereCenter, System.Single sphereRadius) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000088
    public class Spine : BodyPart
    {
        // Fields
        public UnityEngine.Transform headTarget;        // 0x48
        public System.Single positionWeight;        // 0x50
        public System.Single rotationWeight;        // 0x54
        public System.Single headClampWeight;        // 0x58
        public System.Single minHeadHeight;        // 0x5C
        public System.Single useAnimatedHeadHeightWeight;        // 0x60
        public System.Single useAnimatedHeadHeightRange;        // 0x64
        public System.Single animatedHeadHeightBlend;        // 0x68
        public UnityEngine.Transform pelvisTarget;        // 0x70
        public System.Single pelvisPositionWeight;        // 0x78
        public System.Single pelvisRotationWeight;        // 0x7C
        public System.Single maintainPelvisPosition;        // 0x80
        public UnityEngine.Transform chestGoal;        // 0x88
        public System.Single chestGoalWeight;        // 0x90
        public System.Single chestClampWeight;        // 0x94
        public System.Single rotateChestByHands;        // 0x98
        public System.Single bodyPosStiffness;        // 0x9C
        public System.Single bodyRotStiffness;        // 0xA0
        public System.Single neckStiffness;        // 0xA4
        public System.Single moveBodyBackWhenCrouching;        // 0xA8
        public System.Single maxRootAngle;        // 0xAC
        public System.Single rootHeadingOffset;        // 0xB0
        public UnityEngine.Vector3 IKPositionHead;        // 0xB4
        public UnityEngine.Quaternion IKRotationHead;        // 0xC0
        public UnityEngine.Vector3 IKPositionPelvis;        // 0xD0
        public UnityEngine.Quaternion IKRotationPelvis;        // 0xDC
        public UnityEngine.Vector3 goalPositionChest;        // 0xEC
        public UnityEngine.Vector3 pelvisPositionOffset;        // 0xF8
        public UnityEngine.Vector3 chestPositionOffset;        // 0x104
        public UnityEngine.Vector3 headPositionOffset;        // 0x110
        public UnityEngine.Quaternion pelvisRotationOffset;        // 0x11C
        public UnityEngine.Quaternion chestRotationOffset;        // 0x12C
        public UnityEngine.Quaternion headRotationOffset;        // 0x13C
        public UnityEngine.Vector3 faceDirection;        // 0x14C
        private UnityEngine.Vector3 headPosition;        // 0x158
        private UnityEngine.Quaternion <anchorRotation>k__BackingField;        // 0x164
        private UnityEngine.Quaternion <anchorRelativeToHead>k__BackingField;        // 0x174
        private UnityEngine.Quaternion headRotation;        // 0x184
        private UnityEngine.Quaternion pelvisRotation;        // 0x194
        private UnityEngine.Quaternion anchorRelativeToPelvis;        // 0x1A4
        private UnityEngine.Quaternion pelvisRelativeRotation;        // 0x1B4
        private UnityEngine.Quaternion chestRelativeRotation;        // 0x1C4
        private UnityEngine.Vector3 headDeltaPosition;        // 0x1D4
        private UnityEngine.Quaternion pelvisDeltaRotation;        // 0x1E0
        private UnityEngine.Quaternion chestTargetRotation;        // 0x1F0
        private System.Int32 pelvisIndex;        // 0x200
        private System.Int32 spineIndex;        // 0x204
        private System.Int32 chestIndex;        // 0x208
        private System.Int32 neckIndex;        // 0x20C
        private System.Int32 headIndex;        // 0x210
        private System.Single length;        // 0x214
        private System.Boolean hasChest;        // 0x218
        private System.Boolean hasNeck;        // 0x219
        private System.Boolean hasLegs;        // 0x21A
        private System.Single headHeight;        // 0x21C
        private System.Single sizeMlp;        // 0x220
        private UnityEngine.Vector3 chestForward;        // 0x224

        // Methods
        private RootMotion.FinalIK.IKSolverVR.VirtualBone get_pelvis() { }
        private RootMotion.FinalIK.IKSolverVR.VirtualBone get_firstSpineBone() { }
        private RootMotion.FinalIK.IKSolverVR.VirtualBone get_chest() { }
        private RootMotion.FinalIK.IKSolverVR.VirtualBone get_head() { }
        private RootMotion.FinalIK.IKSolverVR.VirtualBone get_neck() { }
        private UnityEngine.Quaternion get_anchorRotation() { }
        private System.Void set_anchorRotation(UnityEngine.Quaternion value) { }
        private UnityEngine.Quaternion get_anchorRelativeToHead() { }
        private System.Void set_anchorRelativeToHead(UnityEngine.Quaternion value) { }
        private System.Void OnRead(UnityEngine.Vector3[] positions, UnityEngine.Quaternion[] rotations, System.Boolean hasChest, System.Boolean hasNeck, System.Boolean hasShoulders, System.Boolean hasToes, System.Boolean hasLegs, System.Int32 rootIndex, System.Int32 index) { }
        private System.Void PreSolve(System.Single scale) { }
        private System.Void ApplyOffsets(System.Single scale) { }
        private System.Void CalculateChestTargetRotation(RootMotion.FinalIK.IKSolverVR.VirtualBone rootBone, RootMotion.FinalIK.IKSolverVR.Arm[] arms) { }
        private System.Void Solve(UnityEngine.Animator animator, RootMotion.FinalIK.IKSolverVR.VirtualBone rootBone, RootMotion.FinalIK.IKSolverVR.Leg[] legs, RootMotion.FinalIK.IKSolverVR.Arm[] arms, System.Single scale) { }
        private System.Void FABRIKPass(UnityEngine.Vector3 animatedPelvisPos, UnityEngine.Vector3 rootUp, System.Single weight) { }
        private System.Void SolvePelvis() { }
        private System.Void Write(UnityEngine.Vector3[]& solvedPositions, UnityEngine.Quaternion[]& solvedRotations) { }
        private System.Void ResetOffsets() { }
        private System.Void AdjustChestByHands(UnityEngine.Quaternion& chestTargetRotation, RootMotion.FinalIK.IKSolverVR.Arm[] arms) { }
        private System.Void InverseTranslateToHead(RootMotion.FinalIK.IKSolverVR.Leg[] legs, System.Boolean limited, System.Boolean useCurrentLegMag, UnityEngine.Vector3 offset, System.Single w) { }
        private System.Void TranslatePelvis(RootMotion.FinalIK.IKSolverVR.Leg[] legs, UnityEngine.Vector3 deltaPosition, UnityEngine.Quaternion deltaRotation, System.Single scale) { }
        private UnityEngine.Vector3 LimitPelvisPosition(RootMotion.FinalIK.IKSolverVR.Leg[] legs, UnityEngine.Vector3 pelvisPosition, System.Boolean useCurrentLegMag, System.Int32 it) { }
        private System.Void Bend(RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones, System.Int32 firstIndex, System.Int32 lastIndex, UnityEngine.Quaternion targetRotation, System.Single clampWeight, System.Boolean uniformWeight, System.Single w) { }
        private System.Void Bend(RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones, System.Int32 firstIndex, System.Int32 lastIndex, UnityEngine.Quaternion targetRotation, UnityEngine.Quaternion rotationOffset, System.Single clampWeight, System.Boolean uniformWeight, System.Single w) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000089
    public struct PositionOffset
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static RootMotion.FinalIK.IKSolverVR.PositionOffset Pelvis;        // 0x0
        public static RootMotion.FinalIK.IKSolverVR.PositionOffset Chest;        // 0x0
        public static RootMotion.FinalIK.IKSolverVR.PositionOffset Head;        // 0x0
        public static RootMotion.FinalIK.IKSolverVR.PositionOffset LeftHand;        // 0x0
        public static RootMotion.FinalIK.IKSolverVR.PositionOffset RightHand;        // 0x0
        public static RootMotion.FinalIK.IKSolverVR.PositionOffset LeftFoot;        // 0x0
        public static RootMotion.FinalIK.IKSolverVR.PositionOffset RightFoot;        // 0x0
        public static RootMotion.FinalIK.IKSolverVR.PositionOffset LeftHeel;        // 0x0
        public static RootMotion.FinalIK.IKSolverVR.PositionOffset RightHeel;        // 0x0

    }

    // TypeToken: 0x200008A
    public struct RotationOffset
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static RootMotion.FinalIK.IKSolverVR.RotationOffset Pelvis;        // 0x0
        public static RootMotion.FinalIK.IKSolverVR.RotationOffset Chest;        // 0x0
        public static RootMotion.FinalIK.IKSolverVR.RotationOffset Head;        // 0x0

    }

    // TypeToken: 0x200008B
    public class VirtualBone
    {
        // Fields
        public UnityEngine.Vector3 readPosition;        // 0x10
        public UnityEngine.Quaternion readRotation;        // 0x1C
        public UnityEngine.Vector3 solverPosition;        // 0x2C
        public UnityEngine.Quaternion solverRotation;        // 0x38
        public System.Single length;        // 0x48
        public System.Single sqrMag;        // 0x4C
        public UnityEngine.Vector3 axis;        // 0x50

        // Methods
        private System.Void .ctor(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        private System.Void Read(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        private System.Void SwingRotation(RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones, System.Int32 index, UnityEngine.Vector3 swingTarget, System.Single weight) { }
        private System.Single PreSolve(RootMotion.FinalIK.IKSolverVR.VirtualBone[]& bones) { }
        private System.Void RotateAroundPoint(RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones, System.Int32 index, UnityEngine.Vector3 point, UnityEngine.Quaternion rotation) { }
        private System.Void RotateBy(RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones, System.Int32 index, UnityEngine.Quaternion rotation) { }
        private System.Void RotateBy(RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones, UnityEngine.Quaternion rotation) { }
        private System.Void RotateTo(RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones, System.Int32 index, UnityEngine.Quaternion rotation) { }
        private System.Void SolveTrigonometric(RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones, System.Int32 first, System.Int32 second, System.Int32 third, UnityEngine.Vector3 targetPosition, UnityEngine.Vector3 bendNormal, System.Single weight) { }
        private UnityEngine.Vector3 GetDirectionToBendPoint(UnityEngine.Vector3 direction, System.Single directionMag, UnityEngine.Vector3 bendDirection, System.Single sqrMag1, System.Single sqrMag2) { }
        private System.Void SolveFABRIK(RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones, UnityEngine.Vector3 startPosition, UnityEngine.Vector3 targetPosition, System.Single weight, System.Single minNormalizedTargetDistance, System.Int32 iterations, System.Single length, UnityEngine.Vector3 startOffset) { }
        private UnityEngine.Vector3 SolveFABRIKJoint(UnityEngine.Vector3 pos1, UnityEngine.Vector3 pos2, System.Single length) { }
        private System.Void SolveCCD(RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones, UnityEngine.Vector3 targetPosition, System.Single weight, System.Int32 iterations) { }

    }

    // TypeToken: 0x2000091
    public class InteractionEvent
    {
        // Fields
        public System.Single time;        // 0x10
        public System.Boolean pause;        // 0x14
        public System.Boolean pickUp;        // 0x15
        public RootMotion.FinalIK.InteractionObject.AnimatorEvent[] animations;        // 0x18
        public RootMotion.FinalIK.InteractionObject.Message[] messages;        // 0x20
        public UnityEngine.Events.UnityEvent unityEvent;        // 0x28

        // Methods
        private System.Void Activate(UnityEngine.Transform t) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000092
    public class Message
    {
        // Fields
        public System.String function;        // 0x10
        public UnityEngine.GameObject recipient;        // 0x18
        private static System.String empty;        // 0x0

        // Methods
        private System.Void Send(UnityEngine.Transform t) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000093
    public class AnimatorEvent
    {
        // Fields
        public UnityEngine.Animator animator;        // 0x10
        public UnityEngine.Animation animation;        // 0x18
        public System.String animationState;        // 0x20
        public System.Single crossfadeTime;        // 0x28
        public System.Int32 layer;        // 0x2C
        public System.Boolean resetNormalizedTime;        // 0x30
        private static System.String empty;        // 0x0

        // Methods
        private System.Void Activate(System.Boolean pickUp) { }
        private System.Void Activate(UnityEngine.Animator animator) { }
        private System.Void Activate(UnityEngine.Animation animation) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000095
    public struct Type
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static RootMotion.FinalIK.InteractionObject.WeightCurve.Type PositionWeight;        // 0x0
        public static RootMotion.FinalIK.InteractionObject.WeightCurve.Type RotationWeight;        // 0x0
        public static RootMotion.FinalIK.InteractionObject.WeightCurve.Type PositionOffsetX;        // 0x0
        public static RootMotion.FinalIK.InteractionObject.WeightCurve.Type PositionOffsetY;        // 0x0
        public static RootMotion.FinalIK.InteractionObject.WeightCurve.Type PositionOffsetZ;        // 0x0
        public static RootMotion.FinalIK.InteractionObject.WeightCurve.Type Pull;        // 0x0
        public static RootMotion.FinalIK.InteractionObject.WeightCurve.Type Reach;        // 0x0
        public static RootMotion.FinalIK.InteractionObject.WeightCurve.Type RotateBoneWeight;        // 0x0
        public static RootMotion.FinalIK.InteractionObject.WeightCurve.Type Push;        // 0x0
        public static RootMotion.FinalIK.InteractionObject.WeightCurve.Type PushParent;        // 0x0
        public static RootMotion.FinalIK.InteractionObject.WeightCurve.Type PoserWeight;        // 0x0
        public static RootMotion.FinalIK.InteractionObject.WeightCurve.Type BendGoalWeight;        // 0x0

    }

    // TypeToken: 0x2000094
    public class WeightCurve
    {
        // Fields
        public RootMotion.FinalIK.InteractionObject.WeightCurve.Type type;        // 0x10
        public UnityEngine.AnimationCurve curve;        // 0x18

        // Methods
        private System.Single GetValue(System.Single timer) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000096
    public class Multiplier
    {
        // Fields
        public RootMotion.FinalIK.InteractionObject.WeightCurve.Type curve;        // 0x10
        public System.Single multiplier;        // 0x14
        public RootMotion.FinalIK.InteractionObject.WeightCurve.Type result;        // 0x18

        // Methods
        private System.Single GetValue(RootMotion.FinalIK.InteractionObject.WeightCurve weightCurve, System.Single timer) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000098
    public class InteractionDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(RootMotion.FinalIK.FullBodyBipedEffector effectorType, RootMotion.FinalIK.InteractionObject interactionObject) { }
        private System.IAsyncResult BeginInvoke(RootMotion.FinalIK.FullBodyBipedEffector effectorType, RootMotion.FinalIK.InteractionObject interactionObject, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000099
    public class InteractionEventDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(RootMotion.FinalIK.FullBodyBipedEffector effectorType, RootMotion.FinalIK.InteractionObject interactionObject, RootMotion.FinalIK.InteractionObject.InteractionEvent interactionEvent) { }
        private System.IAsyncResult BeginInvoke(RootMotion.FinalIK.FullBodyBipedEffector effectorType, RootMotion.FinalIK.InteractionObject interactionObject, RootMotion.FinalIK.InteractionObject.InteractionEvent interactionEvent, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200009B
    public struct RotationMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static RootMotion.FinalIK.InteractionTarget.RotationMode TwoDOF;        // 0x0
        public static RootMotion.FinalIK.InteractionTarget.RotationMode ThreeDOF;        // 0x0

    }

    // TypeToken: 0x200009C
    public class Multiplier
    {
        // Fields
        public RootMotion.FinalIK.InteractionObject.WeightCurve.Type curve;        // 0x10
        public System.Single multiplier;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009E
    public class CharacterPosition
    {
        // Fields
        public System.Boolean use;        // 0x10
        public UnityEngine.Vector2 offset;        // 0x14
        public System.Single angleOffset;        // 0x1C
        public System.Single maxAngle;        // 0x20
        public System.Single radius;        // 0x24
        public System.Boolean orbit;        // 0x28
        public System.Boolean fixYAxis;        // 0x29

        // Methods
        private UnityEngine.Vector3 get_offset3D() { }
        private UnityEngine.Vector3 get_direction3D() { }
        private System.Boolean IsInRange(UnityEngine.Transform character, UnityEngine.Transform trigger, System.Single& error) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009F
    public class CameraPosition
    {
        // Fields
        public UnityEngine.Collider lookAtTarget;        // 0x10
        public UnityEngine.Vector3 direction;        // 0x18
        public System.Single maxDistance;        // 0x24
        public System.Single maxAngle;        // 0x28
        public System.Boolean fixYAxis;        // 0x2C

        // Methods
        private UnityEngine.Quaternion GetRotation() { }
        private System.Boolean IsInRange(UnityEngine.Transform raycastFrom, UnityEngine.RaycastHit hit, UnityEngine.Transform trigger, System.Single& error) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A1
    public class Interaction
    {
        // Fields
        public RootMotion.FinalIK.InteractionObject interactionObject;        // 0x10
        public RootMotion.FinalIK.FullBodyBipedEffector[] effectors;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A0
    public class Range
    {
        // Fields
        public System.String name;        // 0x10
        public System.Boolean show;        // 0x18
        public RootMotion.FinalIK.InteractionTrigger.CharacterPosition characterPosition;        // 0x20
        public RootMotion.FinalIK.InteractionTrigger.CameraPosition cameraPosition;        // 0x28
        public RootMotion.FinalIK.InteractionTrigger.Range.Interaction[] interactions;        // 0x30

        // Methods
        private System.Boolean IsInRange(UnityEngine.Transform character, UnityEngine.Transform raycastFrom, UnityEngine.RaycastHit raycastHit, UnityEngine.Transform trigger, System.Single& maxError) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A3
    public class Map
    {
        // Fields
        public UnityEngine.Transform bone;        // 0x10
        public UnityEngine.Transform target;        // 0x18
        private UnityEngine.Vector3 defaultLocalPosition;        // 0x20
        private UnityEngine.Quaternion defaultLocalRotation;        // 0x2C

        // Methods
        private System.Void .ctor(UnityEngine.Transform bone, UnityEngine.Transform target) { }
        private System.Void StoreDefaultState() { }
        private System.Void FixTransform() { }
        private System.Void Update(System.Single localRotationWeight, System.Single localPositionWeight) { }

    }

    // TypeToken: 0x20000A7
    public class Rigidbone
    {
        // Fields
        public UnityEngine.Rigidbody r;        // 0x10
        public UnityEngine.Transform t;        // 0x18
        public UnityEngine.Collider collider;        // 0x20
        public UnityEngine.Joint joint;        // 0x28
        public UnityEngine.Rigidbody c;        // 0x30
        public System.Boolean updateAnchor;        // 0x38
        public UnityEngine.Vector3 deltaPosition;        // 0x3C
        public UnityEngine.Quaternion deltaRotation;        // 0x48
        public System.Single deltaTime;        // 0x58
        public UnityEngine.Vector3 lastPosition;        // 0x5C
        public UnityEngine.Quaternion lastRotation;        // 0x68

        // Methods
        private System.Void .ctor(UnityEngine.Rigidbody r) { }
        private System.Void RecordVelocity() { }
        private System.Void WakeUp(System.Single velocityWeight, System.Single angularVelocityWeight) { }

    }

    // TypeToken: 0x20000A8
    public class Child
    {
        // Fields
        public UnityEngine.Transform t;        // 0x10
        public UnityEngine.Vector3 localPosition;        // 0x18
        public UnityEngine.Quaternion localRotation;        // 0x24

        // Methods
        private System.Void .ctor(UnityEngine.Transform transform) { }
        private System.Void FixTransform(System.Single weight) { }
        private System.Void StoreLocalState() { }

    }

    // TypeToken: 0x20000AE
    public class ReachCone
    {
        // Fields
        public UnityEngine.Vector3[] tetrahedron;        // 0x10
        public System.Single volume;        // 0x18
        public UnityEngine.Vector3 S;        // 0x1C
        public UnityEngine.Vector3 B;        // 0x28

        // Methods
        private UnityEngine.Vector3 get_o() { }
        private UnityEngine.Vector3 get_a() { }
        private UnityEngine.Vector3 get_b() { }
        private UnityEngine.Vector3 get_c() { }
        private System.Void .ctor(UnityEngine.Vector3 _o, UnityEngine.Vector3 _a, UnityEngine.Vector3 _b, UnityEngine.Vector3 _c) { }
        private System.Boolean get_isValid() { }
        private System.Void Calculate() { }

    }

    // TypeToken: 0x20000AF
    public class LimitPoint
    {
        // Fields
        public UnityEngine.Vector3 point;        // 0x10
        public System.Single tangentWeight;        // 0x1C

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B4
    public class Pose
    {
        // Fields
        public System.Boolean visualize;        // 0x10
        public System.String name;        // 0x18
        public UnityEngine.Vector3 direction;        // 0x20
        public System.Single yaw;        // 0x2C
        public System.Single pitch;        // 0x30
        private System.Single angleBuffer;        // 0x34

        // Methods
        private System.Boolean IsInDirection(UnityEngine.Vector3 d) { }
        private System.Void SetAngleBuffer(System.Single value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B7
    public class EffectorLink
    {
        // Fields
        public RootMotion.FinalIK.FullBodyBipedEffector effector;        // 0x10
        public System.Single weight;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B6
    public class Body
    {
        // Fields
        public UnityEngine.Transform transform;        // 0x10
        public UnityEngine.Transform relativeTo;        // 0x18
        public RootMotion.FinalIK.Amplifier.Body.EffectorLink[] effectorLinks;        // 0x20
        public System.Single verticalWeight;        // 0x28
        public System.Single horizontalWeight;        // 0x2C
        public System.Single speed;        // 0x30
        private UnityEngine.Vector3 lastRelativePos;        // 0x34
        private UnityEngine.Vector3 smoothDelta;        // 0x40
        private System.Boolean firstUpdate;        // 0x4C

        // Methods
        private System.Void Update(RootMotion.FinalIK.IKSolverFullBodyBiped solver, System.Single w, System.Single deltaTime) { }
        private UnityEngine.Vector3 Multiply(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BD
    public class HitPoint
    {
        // Fields
        public System.String name;        // 0x10
        public UnityEngine.Collider collider;        // 0x18
        private System.Single crossFadeTime;        // 0x20
        private System.Single <crossFader>k__BackingField;        // 0x24
        private System.Single <timer>k__BackingField;        // 0x28
        private UnityEngine.Vector3 <force>k__BackingField;        // 0x2C
        private System.Single length;        // 0x38
        private System.Single crossFadeSpeed;        // 0x3C
        private System.Single lastTime;        // 0x40

        // Methods
        private System.Boolean get_inProgress() { }
        private System.Single get_crossFader() { }
        private System.Void set_crossFader(System.Single value) { }
        private System.Single get_timer() { }
        private System.Void set_timer(System.Single value) { }
        private UnityEngine.Vector3 get_force() { }
        private System.Void set_force(UnityEngine.Vector3 value) { }
        private System.Void Hit(UnityEngine.Vector3 force, UnityEngine.Vector3 point) { }
        private System.Void Apply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, System.Single weight) { }
        private System.Single GetLength() { }
        private System.Void CrossFadeStart() { }
        private System.Void OnApply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, System.Single weight) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BF
    public class EffectorLink
    {
        // Fields
        public RootMotion.FinalIK.FullBodyBipedEffector effector;        // 0x10
        public System.Single weight;        // 0x14
        private UnityEngine.Vector3 lastValue;        // 0x18
        private UnityEngine.Vector3 current;        // 0x24

        // Methods
        private System.Void Apply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, UnityEngine.Vector3 offset, System.Single crossFader) { }
        private System.Void CrossFadeStart() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BE
    public class HitPointEffector : HitPoint
    {
        // Fields
        public UnityEngine.AnimationCurve offsetInForceDirection;        // 0x48
        public UnityEngine.AnimationCurve offsetInUpDirection;        // 0x50
        public RootMotion.FinalIK.HitReaction.HitPointEffector.EffectorLink[] effectorLinks;        // 0x58

        // Methods
        private System.Single GetLength() { }
        private System.Void CrossFadeStart() { }
        private System.Void OnApply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, System.Single weight) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C1
    public class BoneLink
    {
        // Fields
        public UnityEngine.Transform bone;        // 0x10
        public System.Single weight;        // 0x18
        private UnityEngine.Quaternion lastValue;        // 0x1C
        private UnityEngine.Quaternion current;        // 0x2C

        // Methods
        private System.Void Apply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, UnityEngine.Quaternion offset, System.Single crossFader) { }
        private System.Void CrossFadeStart() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C0
    public class HitPointBone : HitPoint
    {
        // Fields
        public UnityEngine.AnimationCurve aroundCenterOfMass;        // 0x48
        public RootMotion.FinalIK.HitReaction.HitPointBone.BoneLink[] boneLinks;        // 0x50
        private UnityEngine.Rigidbody rigidbody;        // 0x58
        private UnityEngine.Vector3 comAxis;        // 0x60

        // Methods
        private System.Void Hit(UnityEngine.Vector3 force, UnityEngine.Vector3 point) { }
        private System.Single GetLength() { }
        private System.Void CrossFadeStart() { }
        private System.Void OnApply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, System.Single weight) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C3
    public class Offset
    {
        // Fields
        public System.String name;        // 0x10
        public UnityEngine.Collider collider;        // 0x18
        private System.Single crossFadeTime;        // 0x20
        private System.Single <crossFader>k__BackingField;        // 0x24
        private System.Single <timer>k__BackingField;        // 0x28
        private UnityEngine.Vector3 <force>k__BackingField;        // 0x2C
        private System.Single length;        // 0x38
        private System.Single crossFadeSpeed;        // 0x3C
        private System.Single lastTime;        // 0x40

        // Methods
        private System.Single get_crossFader() { }
        private System.Void set_crossFader(System.Single value) { }
        private System.Single get_timer() { }
        private System.Void set_timer(System.Single value) { }
        private UnityEngine.Vector3 get_force() { }
        private System.Void set_force(UnityEngine.Vector3 value) { }
        private System.Void Hit(UnityEngine.Vector3 force, UnityEngine.AnimationCurve[] curves, UnityEngine.Vector3 point) { }
        private System.Void Apply(RootMotion.FinalIK.VRIK ik, UnityEngine.AnimationCurve[] curves, System.Single weight) { }
        private System.Single GetLength(UnityEngine.AnimationCurve[] curves) { }
        private System.Void CrossFadeStart() { }
        private System.Void OnApply(RootMotion.FinalIK.VRIK ik, UnityEngine.AnimationCurve[] curves, System.Single weight) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C5
    public class PositionOffsetLink
    {
        // Fields
        public RootMotion.FinalIK.IKSolverVR.PositionOffset positionOffset;        // 0x10
        public System.Single weight;        // 0x14
        private UnityEngine.Vector3 lastValue;        // 0x18
        private UnityEngine.Vector3 current;        // 0x24

        // Methods
        private System.Void Apply(RootMotion.FinalIK.VRIK ik, UnityEngine.Vector3 offset, System.Single crossFader) { }
        private System.Void CrossFadeStart() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C4
    public class PositionOffset : Offset
    {
        // Fields
        public System.Int32 forceDirCurveIndex;        // 0x48
        public System.Int32 upDirCurveIndex;        // 0x4C
        public RootMotion.FinalIK.HitReactionVRIK.PositionOffset.PositionOffsetLink[] offsetLinks;        // 0x50

        // Methods
        private System.Single GetLength(UnityEngine.AnimationCurve[] curves) { }
        private System.Void CrossFadeStart() { }
        private System.Void OnApply(RootMotion.FinalIK.VRIK ik, UnityEngine.AnimationCurve[] curves, System.Single weight) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C7
    public class RotationOffsetLink
    {
        // Fields
        public RootMotion.FinalIK.IKSolverVR.RotationOffset rotationOffset;        // 0x10
        public System.Single weight;        // 0x14
        private UnityEngine.Quaternion lastValue;        // 0x18
        private UnityEngine.Quaternion current;        // 0x28

        // Methods
        private System.Void Apply(RootMotion.FinalIK.VRIK ik, UnityEngine.Quaternion offset, System.Single crossFader) { }
        private System.Void CrossFadeStart() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C6
    public class RotationOffset : Offset
    {
        // Fields
        public System.Int32 curveIndex;        // 0x48
        public RootMotion.FinalIK.HitReactionVRIK.RotationOffset.RotationOffsetLink[] offsetLinks;        // 0x50
        private UnityEngine.Rigidbody rigidbody;        // 0x58
        private UnityEngine.Vector3 comAxis;        // 0x60

        // Methods
        private System.Void Hit(UnityEngine.Vector3 force, UnityEngine.AnimationCurve[] curves, UnityEngine.Vector3 point) { }
        private System.Single GetLength(UnityEngine.AnimationCurve[] curves) { }
        private System.Void CrossFadeStart() { }
        private System.Void OnApply(RootMotion.FinalIK.VRIK ik, UnityEngine.AnimationCurve[] curves, System.Single weight) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CA
    public class EffectorLink
    {
        // Fields
        public RootMotion.FinalIK.FullBodyBipedEffector effector;        // 0x10
        public System.Single weight;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C9
    public class Body
    {
        // Fields
        public UnityEngine.Transform transform;        // 0x10
        public RootMotion.FinalIK.Inertia.Body.EffectorLink[] effectorLinks;        // 0x18
        public System.Single speed;        // 0x20
        public System.Single acceleration;        // 0x24
        public System.Single matchVelocity;        // 0x28
        public System.Single gravity;        // 0x2C
        private UnityEngine.Vector3 delta;        // 0x30
        private UnityEngine.Vector3 lazyPoint;        // 0x3C
        private UnityEngine.Vector3 direction;        // 0x48
        private UnityEngine.Vector3 lastPosition;        // 0x54
        private System.Boolean firstUpdate;        // 0x60

        // Methods
        private System.Void Reset() { }
        private System.Void Update(RootMotion.FinalIK.IKSolverFullBodyBiped solver, System.Single weight, System.Single deltaTime) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CD
    public class OffsetLimits
    {
        // Fields
        public RootMotion.FinalIK.FullBodyBipedEffector effector;        // 0x10
        public System.Single spring;        // 0x14
        public System.Boolean x;        // 0x18
        public System.Boolean y;        // 0x19
        public System.Boolean z;        // 0x1A
        public System.Single minX;        // 0x1C
        public System.Single maxX;        // 0x20
        public System.Single minY;        // 0x24
        public System.Single maxY;        // 0x28
        public System.Single minZ;        // 0x2C
        public System.Single maxZ;        // 0x30

        // Methods
        private System.Void Apply(RootMotion.FinalIK.IKEffector e, UnityEngine.Quaternion rootRotation) { }
        private System.Single SpringAxis(System.Single value, System.Single min, System.Single max) { }
        private System.Single Spring(System.Single value, System.Single limit, System.Boolean negative) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D2
    public class EffectorLink
    {
        // Fields
        public RootMotion.FinalIK.FullBodyBipedEffector effector;        // 0x10
        public UnityEngine.Vector3 offset;        // 0x14
        public UnityEngine.Vector3 pin;        // 0x20
        public UnityEngine.Vector3 pinWeight;        // 0x2C

        // Methods
        private System.Void Apply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, System.Single weight, UnityEngine.Quaternion rotation) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D5
    public class EffectorLink
    {
        // Fields
        public RootMotion.FinalIK.FullBodyBipedEffector effector;        // 0x10
        public System.Single weight;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D4
    public class Avoider
    {
        // Fields
        public UnityEngine.Transform[] raycastFrom;        // 0x10
        public UnityEngine.Transform raycastTo;        // 0x18
        public System.Single raycastRadius;        // 0x20
        public RootMotion.FinalIK.PenetrationAvoidance.Avoider.EffectorLink[] effectors;        // 0x28
        public System.Single smoothTimeIn;        // 0x30
        public System.Single smoothTimeOut;        // 0x34
        public UnityEngine.LayerMask layers;        // 0x38
        private UnityEngine.Vector3 offset;        // 0x3C
        private UnityEngine.Vector3 offsetTarget;        // 0x48
        private UnityEngine.Vector3 offsetV;        // 0x54

        // Methods
        private System.Void Solve(RootMotion.FinalIK.IKSolverFullBodyBiped solver, System.Single weight) { }
        private UnityEngine.Vector3 GetOffsetTarget(RootMotion.FinalIK.IKSolverFullBodyBiped solver) { }
        private UnityEngine.Vector3 Raycast(UnityEngine.Vector3 from, UnityEngine.Vector3 to) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D8
    public class EffectorLink
    {
        // Fields
        public RootMotion.FinalIK.FullBodyBipedEffector effector;        // 0x10
        public System.Single weight;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D7
    public class RecoilOffset
    {
        // Fields
        public UnityEngine.Vector3 offset;        // 0x10
        public System.Single additivity;        // 0x1C
        public System.Single maxAdditiveOffsetMag;        // 0x20
        public RootMotion.FinalIK.Recoil.RecoilOffset.EffectorLink[] effectorLinks;        // 0x28
        private UnityEngine.Vector3 additiveOffset;        // 0x30
        private UnityEngine.Vector3 lastOffset;        // 0x3C

        // Methods
        private System.Void Start() { }
        private System.Void Apply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, UnityEngine.Quaternion rotation, System.Single masterWeight, System.Single length, System.Single timeLeft) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D9
    public struct Handedness
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static RootMotion.FinalIK.Recoil.Handedness Right;        // 0x0
        public static RootMotion.FinalIK.Recoil.Handedness Left;        // 0x0

    }

    // TypeToken: 0x20000DC
    public class Settings
    {
        // Fields
        public System.Single scaleMlp;        // 0x10
        public UnityEngine.Vector3 headTrackerForward;        // 0x14
        public UnityEngine.Vector3 headTrackerUp;        // 0x20
        public UnityEngine.Vector3 handTrackerForward;        // 0x2C
        public UnityEngine.Vector3 handTrackerUp;        // 0x38
        public UnityEngine.Vector3 footTrackerForward;        // 0x44
        public UnityEngine.Vector3 footTrackerUp;        // 0x50
        public UnityEngine.Vector3 headOffset;        // 0x5C
        public UnityEngine.Vector3 handOffset;        // 0x68
        public System.Single footForwardOffset;        // 0x74
        public System.Single footInwardOffset;        // 0x78
        public System.Single footHeadingOffset;        // 0x7C
        public System.Single pelvisPositionWeight;        // 0x80
        public System.Single pelvisRotationWeight;        // 0x84

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DE
    public class Target
    {
        // Fields
        public System.Boolean used;        // 0x10
        public UnityEngine.Vector3 localPosition;        // 0x14
        public UnityEngine.Quaternion localRotation;        // 0x20

        // Methods
        private System.Void .ctor(UnityEngine.Transform t) { }
        private System.Void SetTo(UnityEngine.Transform t) { }

    }

    // TypeToken: 0x20000DD
    public class CalibrationData
    {
        // Fields
        public System.Single scale;        // 0x10
        public RootMotion.FinalIK.VRIKCalibrator.CalibrationData.Target head;        // 0x18
        public RootMotion.FinalIK.VRIKCalibrator.CalibrationData.Target leftHand;        // 0x20
        public RootMotion.FinalIK.VRIKCalibrator.CalibrationData.Target rightHand;        // 0x28
        public RootMotion.FinalIK.VRIKCalibrator.CalibrationData.Target pelvis;        // 0x30
        public RootMotion.FinalIK.VRIKCalibrator.CalibrationData.Target leftFoot;        // 0x38
        public RootMotion.FinalIK.VRIKCalibrator.CalibrationData.Target rightFoot;        // 0x40
        public RootMotion.FinalIK.VRIKCalibrator.CalibrationData.Target leftLegGoal;        // 0x48
        public RootMotion.FinalIK.VRIKCalibrator.CalibrationData.Target rightLegGoal;        // 0x50
        public UnityEngine.Vector3 pelvisTargetRight;        // 0x58
        public System.Single pelvisPositionWeight;        // 0x64
        public System.Single pelvisRotationWeight;        // 0x68

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E2
    public struct __StaticArrayInitTypeSize=16
    {
    }

namespace RootMotion
{

    // TypeToken: 0x2000002
    public class Baker : MonoBehaviour
    {
        // Fields
        public System.Int32 frameRate;        // 0x18
        public System.Single keyReductionError;        // 0x1C
        public RootMotion.Baker.Mode mode;        // 0x20
        public UnityEngine.AnimationClip[] animationClips;        // 0x28
        public System.String[] animationStates;        // 0x30
        public System.String saveToFolder;        // 0x38
        public System.String appendName;        // 0x40
        public System.String saveName;        // 0x48
        private System.Boolean <isBaking>k__BackingField;        // 0x50
        private System.Single <bakingProgress>k__BackingField;        // 0x54
        public UnityEngine.Animator animator;        // 0x58
        public UnityEngine.Playables.PlayableDirector director;        // 0x60
        public RootMotion.Baker.BakerDelegate OnStartClip;        // 0x68
        public RootMotion.Baker.BakerDelegate OnUpdateClip;        // 0x70
        public System.Boolean inheritClipSettings;        // 0x78
        public RootMotion.Baker.ClipSettings clipSettings;        // 0x80
        private System.Single <clipLength>k__BackingField;        // 0x88
        protected System.Boolean addLoopFrame;        // 0x8C

        // Methods
        private System.Void OpenUserManual() { }
        private System.Void OpenScriptReference() { }
        private System.Void SupportGroup() { }
        private System.Void ASThread() { }
        private System.Boolean get_isBaking() { }
        private System.Void set_isBaking(System.Boolean value) { }
        private System.Single get_bakingProgress() { }
        private System.Void set_bakingProgress(System.Single value) { }
        private UnityEngine.Transform GetCharacterRoot() { }
        private System.Void OnStartBaking() { }
        private System.Void OnSetLoopFrame(System.Single time) { }
        private System.Void OnSetCurves(UnityEngine.AnimationClip& clip) { }
        private System.Void OnSetKeyframes(System.Single time, System.Boolean lastFrame) { }
        private System.Single get_clipLength() { }
        private System.Void set_clipLength(System.Single value) { }
        private System.Void BakeClip() { }
        private System.Void StartBaking() { }
        private System.Void StopBaking() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000009
    public class GenericBaker : Baker
    {
        // Fields
        public System.Boolean markAsLegacy;        // 0x90
        public UnityEngine.Transform root;        // 0x98
        public UnityEngine.Transform rootNode;        // 0xA0
        public UnityEngine.Transform[] ignoreList;        // 0xA8
        public UnityEngine.Transform[] bakePositionList;        // 0xB0
        private RootMotion.BakerTransform[] children;        // 0xB8
        private RootMotion.BakerTransform rootChild;        // 0xC0
        private System.Int32 rootChildIndex;        // 0xC8

        // Methods
        private System.Void Awake() { }
        private UnityEngine.Transform GetCharacterRoot() { }
        private System.Void OnStartBaking() { }
        private System.Void OnSetLoopFrame(System.Single time) { }
        private System.Void OnSetCurves(UnityEngine.AnimationClip& clip) { }
        private System.Void OnSetKeyframes(System.Single time, System.Boolean lastFrame) { }
        private System.Boolean IsIgnored(UnityEngine.Transform t) { }
        private System.Boolean BakePosition(UnityEngine.Transform t) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000A
    public class TQ
    {
        // Fields
        public UnityEngine.Vector3 t;        // 0x10
        public UnityEngine.Quaternion q;        // 0x1C

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.Vector3 translation, UnityEngine.Quaternion rotation) { }

    }

    // TypeToken: 0x200000B
    public class AvatarUtility
    {
        // Methods
        private UnityEngine.Quaternion GetPostRotation(UnityEngine.Avatar avatar, UnityEngine.AvatarIKGoal avatarIKGoal) { }
        private RootMotion.TQ GetIKGoalTQ(UnityEngine.Avatar avatar, System.Single humanScale, UnityEngine.AvatarIKGoal avatarIKGoal, RootMotion.TQ bodyPositionRotation, RootMotion.TQ boneTQ) { }
        private RootMotion.TQ WorldSpaceIKGoalToBone(RootMotion.TQ goalTQ, UnityEngine.Avatar avatar, UnityEngine.AvatarIKGoal avatarIKGoal) { }
        private RootMotion.TQ GetWorldSpaceIKGoal(RootMotion.BakerHumanoidQT ikQT, RootMotion.BakerHumanoidQT rootQT, System.Single time, System.Single humanScale) { }
        private UnityEngine.HumanBodyBones HumanIDFromAvatarIKGoal(UnityEngine.AvatarIKGoal avatarIKGoal) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000C
    public class BakerUtilities
    {
        // Methods
        private System.Void ReduceKeyframes(UnityEngine.AnimationCurve curve, System.Single maxError) { }
        private UnityEngine.Keyframe[] GetReducedKeyframes(UnityEngine.AnimationCurve curve, System.Single maxError) { }
        private System.Void SetLoopFrame(System.Single time, UnityEngine.AnimationCurve curve) { }
        private System.Void SetTangentMode(UnityEngine.AnimationCurve curve) { }
        private UnityEngine.Quaternion EnsureQuaternionContinuity(UnityEngine.Quaternion lastQ, UnityEngine.Quaternion q) { }

    }

    // TypeToken: 0x200000D
    public class BakerHumanoidQT
    {
        // Fields
        private UnityEngine.Transform transform;        // 0x10
        private System.String Qx;        // 0x18
        private System.String Qy;        // 0x20
        private System.String Qz;        // 0x28
        private System.String Qw;        // 0x30
        private System.String Tx;        // 0x38
        private System.String Ty;        // 0x40
        private System.String Tz;        // 0x48
        public UnityEngine.AnimationCurve rotX;        // 0x50
        public UnityEngine.AnimationCurve rotY;        // 0x58
        public UnityEngine.AnimationCurve rotZ;        // 0x60
        public UnityEngine.AnimationCurve rotW;        // 0x68
        public UnityEngine.AnimationCurve posX;        // 0x70
        public UnityEngine.AnimationCurve posY;        // 0x78
        public UnityEngine.AnimationCurve posZ;        // 0x80
        private UnityEngine.AvatarIKGoal goal;        // 0x88
        private UnityEngine.Quaternion lastQ;        // 0x8C
        private System.Boolean lastQSet;        // 0x9C

        // Methods
        private System.Void .ctor(System.String name) { }
        private System.Void .ctor(UnityEngine.Transform transform, UnityEngine.AvatarIKGoal goal, System.String name) { }
        private UnityEngine.Quaternion EvaluateRotation(System.Single time) { }
        private UnityEngine.Vector3 EvaluatePosition(System.Single time) { }
        private RootMotion.TQ Evaluate(System.Single time) { }
        private System.Void GetCurvesFromClip(UnityEngine.AnimationClip clip, UnityEngine.Animator animator) { }
        private System.Void Reset() { }
        private System.Void SetIKKeyframes(System.Single time, UnityEngine.Avatar avatar, UnityEngine.Transform root, System.Single humanScale, UnityEngine.Vector3 bodyPosition, UnityEngine.Quaternion bodyRotation) { }
        private System.Void SetKeyframes(System.Single time, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        private System.Void MoveLastKeyframes(System.Single time) { }
        private System.Void SetLoopFrame(System.Single time) { }
        private System.Void SetRootLoopFrame(System.Single time) { }
        private System.Void MoveLastKeyframe(System.Single time, UnityEngine.AnimationCurve curve) { }
        private System.Void MultiplyLength(UnityEngine.AnimationCurve curve, System.Single mlp) { }
        private System.Void SetCurves(UnityEngine.AnimationClip& clip, System.Single maxError, System.Single lengthMlp) { }

    }

    // TypeToken: 0x200000E
    public class BakerMuscle
    {
        // Fields
        public UnityEngine.AnimationCurve curve;        // 0x10
        private System.Int32 muscleIndex;        // 0x18
        private System.String propertyName;        // 0x20

        // Methods
        private System.Void .ctor(System.Int32 muscleIndex) { }
        private System.String MuscleNameToPropertyName(System.String n) { }
        private System.Void MultiplyLength(UnityEngine.AnimationCurve curve, System.Single mlp) { }
        private System.Void SetCurves(UnityEngine.AnimationClip& clip, System.Single maxError, System.Single lengthMlp) { }
        private System.Void Reset() { }
        private System.Void SetKeyframe(System.Single time, System.Single[] muscles) { }
        private System.Void SetLoopFrame(System.Single time) { }

    }

    // TypeToken: 0x200000F
    public class BakerTransform
    {
        // Fields
        public UnityEngine.Transform transform;        // 0x10
        public UnityEngine.AnimationCurve posX;        // 0x18
        public UnityEngine.AnimationCurve posY;        // 0x20
        public UnityEngine.AnimationCurve posZ;        // 0x28
        public UnityEngine.AnimationCurve rotX;        // 0x30
        public UnityEngine.AnimationCurve rotY;        // 0x38
        public UnityEngine.AnimationCurve rotZ;        // 0x40
        public UnityEngine.AnimationCurve rotW;        // 0x48
        private System.String relativePath;        // 0x50
        private System.Boolean recordPosition;        // 0x58
        private UnityEngine.Vector3 relativePosition;        // 0x5C
        private System.Boolean isRootNode;        // 0x68
        private UnityEngine.Quaternion relativeRotation;        // 0x6C

        // Methods
        private System.Void .ctor(UnityEngine.Transform transform, UnityEngine.Transform root, System.Boolean recordPosition, System.Boolean isRootNode) { }
        private System.Void SetRelativeSpace(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        private System.Void SetCurves(UnityEngine.AnimationClip& clip) { }
        private System.Void AddRootMotionCurves(UnityEngine.AnimationClip& clip) { }
        private System.Void Reset() { }
        private System.Void ReduceKeyframes(System.Single maxError) { }
        private System.Void SetKeyframes(System.Single time) { }
        private System.Void AddLoopFrame(System.Single time) { }

    }

    // TypeToken: 0x2000010
    public class HumanoidBaker : Baker
    {
        // Fields
        public System.Boolean bakeHandIK;        // 0x90
        public System.Single IKKeyReductionError;        // 0x94
        public System.Int32 muscleFrameRateDiv;        // 0x98
        private RootMotion.BakerMuscle[] bakerMuscles;        // 0xA0
        private RootMotion.BakerHumanoidQT rootQT;        // 0xA8
        private RootMotion.BakerHumanoidQT leftFootQT;        // 0xB0
        private RootMotion.BakerHumanoidQT rightFootQT;        // 0xB8
        private RootMotion.BakerHumanoidQT leftHandQT;        // 0xC0
        private RootMotion.BakerHumanoidQT rightHandQT;        // 0xC8
        private System.Single[] muscles;        // 0xD0
        private UnityEngine.HumanPose pose;        // 0xD8
        private UnityEngine.HumanPoseHandler handler;        // 0x100
        private UnityEngine.Vector3 bodyPosition;        // 0x108
        private UnityEngine.Quaternion bodyRotation;        // 0x114
        private System.Int32 mN;        // 0x124
        private UnityEngine.Quaternion lastBodyRotation;        // 0x128

        // Methods
        private System.Void Awake() { }
        private UnityEngine.Transform GetCharacterRoot() { }
        private System.Void OnStartBaking() { }
        private System.Void OnSetLoopFrame(System.Single time) { }
        private System.Void OnSetCurves(UnityEngine.AnimationClip& clip) { }
        private System.Void OnSetKeyframes(System.Single time, System.Boolean lastFrame) { }
        private System.Void UpdateHumanPose() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000011
    public struct Axis
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static RootMotion.Axis X;        // 0x0
        public static RootMotion.Axis Y;        // 0x0
        public static RootMotion.Axis Z;        // 0x0

    }

    // TypeToken: 0x2000012
    public class AxisTools
    {
        // Methods
        private UnityEngine.Vector3 ToVector3(RootMotion.Axis axis) { }
        private RootMotion.Axis ToAxis(UnityEngine.Vector3 v) { }
        private RootMotion.Axis GetAxisToPoint(UnityEngine.Transform t, UnityEngine.Vector3 worldPosition) { }
        private RootMotion.Axis GetAxisToDirection(UnityEngine.Transform t, UnityEngine.Vector3 direction) { }
        private UnityEngine.Vector3 GetAxisVectorToPoint(UnityEngine.Transform t, UnityEngine.Vector3 worldPosition) { }
        private UnityEngine.Vector3 GetAxisVectorToDirection(UnityEngine.Transform t, UnityEngine.Vector3 direction) { }
        private UnityEngine.Vector3 GetAxisVectorToDirection(UnityEngine.Quaternion r, UnityEngine.Vector3 direction) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000013
    public class BipedLimbOrientations
    {
        // Fields
        public RootMotion.BipedLimbOrientations.LimbOrientation leftArm;        // 0x10
        public RootMotion.BipedLimbOrientations.LimbOrientation rightArm;        // 0x18
        public RootMotion.BipedLimbOrientations.LimbOrientation leftLeg;        // 0x20
        public RootMotion.BipedLimbOrientations.LimbOrientation rightLeg;        // 0x28

        // Methods
        private System.Void .ctor(RootMotion.BipedLimbOrientations.LimbOrientation leftArm, RootMotion.BipedLimbOrientations.LimbOrientation rightArm, RootMotion.BipedLimbOrientations.LimbOrientation leftLeg, RootMotion.BipedLimbOrientations.LimbOrientation rightLeg) { }
        private RootMotion.BipedLimbOrientations get_UMA() { }
        private RootMotion.BipedLimbOrientations get_MaxBiped() { }

    }

    // TypeToken: 0x2000015
    public class BipedNaming
    {
        // Fields
        public static System.String[] typeLeft;        // 0x0
        public static System.String[] typeRight;        // 0x8
        public static System.String[] typeSpine;        // 0x10
        public static System.String[] typeHead;        // 0x18
        public static System.String[] typeArm;        // 0x20
        public static System.String[] typeLeg;        // 0x28
        public static System.String[] typeTail;        // 0x30
        public static System.String[] typeEye;        // 0x38
        public static System.String[] typeExclude;        // 0x40
        public static System.String[] typeExcludeSpine;        // 0x48
        public static System.String[] typeExcludeHead;        // 0x50
        public static System.String[] typeExcludeArm;        // 0x58
        public static System.String[] typeExcludeLeg;        // 0x60
        public static System.String[] typeExcludeTail;        // 0x68
        public static System.String[] typeExcludeEye;        // 0x70
        public static System.String[] pelvis;        // 0x78
        public static System.String[] hand;        // 0x80
        public static System.String[] foot;        // 0x88

        // Methods
        private UnityEngine.Transform[] GetBonesOfType(RootMotion.BipedNaming.BoneType boneType, UnityEngine.Transform[] bones) { }
        private UnityEngine.Transform[] GetBonesOfSide(RootMotion.BipedNaming.BoneSide boneSide, UnityEngine.Transform[] bones) { }
        private UnityEngine.Transform[] GetBonesOfTypeAndSide(RootMotion.BipedNaming.BoneType boneType, RootMotion.BipedNaming.BoneSide boneSide, UnityEngine.Transform[] bones) { }
        private UnityEngine.Transform GetFirstBoneOfTypeAndSide(RootMotion.BipedNaming.BoneType boneType, RootMotion.BipedNaming.BoneSide boneSide, UnityEngine.Transform[] bones) { }
        private UnityEngine.Transform GetNamingMatch(UnityEngine.Transform[] transforms, System.String[][] namings) { }
        private RootMotion.BipedNaming.BoneType GetBoneType(System.String boneName) { }
        private RootMotion.BipedNaming.BoneSide GetBoneSide(System.String boneName) { }
        private UnityEngine.Transform GetBone(UnityEngine.Transform[] transforms, RootMotion.BipedNaming.BoneType boneType, RootMotion.BipedNaming.BoneSide boneSide, System.String[][] namings) { }
        private System.Boolean isLeft(System.String boneName) { }
        private System.Boolean isRight(System.String boneName) { }
        private System.Boolean isSpine(System.String boneName) { }
        private System.Boolean isHead(System.String boneName) { }
        private System.Boolean isArm(System.String boneName) { }
        private System.Boolean isLeg(System.String boneName) { }
        private System.Boolean isTail(System.String boneName) { }
        private System.Boolean isEye(System.String boneName) { }
        private System.Boolean isTypeExclude(System.String boneName) { }
        private System.Boolean matchesNaming(System.String boneName, System.String[] namingConvention) { }
        private System.Boolean excludesNaming(System.String boneName, System.String[] namingConvention) { }
        private System.Boolean matchesLastLetter(System.String boneName, System.String[] namingConvention) { }
        private System.Boolean LastLetterIs(System.String boneName, System.String letter) { }
        private System.String firstLetter(System.String boneName) { }
        private System.String lastLetter(System.String boneName) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000018
    public class BipedReferences
    {
        // Fields
        public UnityEngine.Transform root;        // 0x10
        public UnityEngine.Transform pelvis;        // 0x18
        public UnityEngine.Transform leftThigh;        // 0x20
        public UnityEngine.Transform leftCalf;        // 0x28
        public UnityEngine.Transform leftFoot;        // 0x30
        public UnityEngine.Transform rightThigh;        // 0x38
        public UnityEngine.Transform rightCalf;        // 0x40
        public UnityEngine.Transform rightFoot;        // 0x48
        public UnityEngine.Transform leftUpperArm;        // 0x50
        public UnityEngine.Transform leftForearm;        // 0x58
        public UnityEngine.Transform leftHand;        // 0x60
        public UnityEngine.Transform rightUpperArm;        // 0x68
        public UnityEngine.Transform rightForearm;        // 0x70
        public UnityEngine.Transform rightHand;        // 0x78
        public UnityEngine.Transform head;        // 0x80
        public UnityEngine.Transform[] spine;        // 0x88
        public UnityEngine.Transform[] eyes;        // 0x90

        // Methods
        private System.Boolean get_isFilled() { }
        private System.Boolean get_isEmpty() { }
        private System.Boolean IsEmpty(System.Boolean includeRoot) { }
        private System.Boolean Contains(UnityEngine.Transform t, System.Boolean ignoreRoot) { }
        private System.Boolean AutoDetectReferences(RootMotion.BipedReferences& references, UnityEngine.Transform root, RootMotion.BipedReferences.AutoDetectParams autoDetectParams) { }
        private System.Void DetectReferencesByNaming(RootMotion.BipedReferences& references, UnityEngine.Transform root, RootMotion.BipedReferences.AutoDetectParams autoDetectParams) { }
        private System.Void AssignHumanoidReferences(RootMotion.BipedReferences& references, UnityEngine.Animator animator, RootMotion.BipedReferences.AutoDetectParams autoDetectParams) { }
        private System.Boolean SetupError(RootMotion.BipedReferences references, System.String& errorMessage) { }
        private System.Boolean SetupWarning(RootMotion.BipedReferences references, System.String& warningMessage) { }
        private System.Boolean IsNeckBone(UnityEngine.Transform bone, UnityEngine.Transform leftUpperArm) { }
        private System.Boolean AddBoneToEyes(UnityEngine.Transform bone, RootMotion.BipedReferences& references, RootMotion.BipedReferences.AutoDetectParams autoDetectParams) { }
        private System.Boolean AddBoneToSpine(UnityEngine.Transform bone, RootMotion.BipedReferences& references, RootMotion.BipedReferences.AutoDetectParams autoDetectParams) { }
        private System.Void DetectLimb(RootMotion.BipedNaming.BoneType boneType, RootMotion.BipedNaming.BoneSide boneSide, UnityEngine.Transform& firstBone, UnityEngine.Transform& secondBone, UnityEngine.Transform& lastBone, UnityEngine.Transform[] transforms) { }
        private System.Void AddBoneToHierarchy(UnityEngine.Transform[]& bones, UnityEngine.Transform transform) { }
        private System.Boolean LimbError(UnityEngine.Transform bone1, UnityEngine.Transform bone2, UnityEngine.Transform bone3, System.String& errorMessage) { }
        private System.Boolean LimbWarning(UnityEngine.Transform bone1, UnityEngine.Transform bone2, UnityEngine.Transform bone3, System.String& warningMessage) { }
        private System.Boolean SpineError(RootMotion.BipedReferences references, System.String& errorMessage) { }
        private System.Boolean SpineWarning(RootMotion.BipedReferences references, System.String& warningMessage) { }
        private System.Boolean EyesError(RootMotion.BipedReferences references, System.String& errorMessage) { }
        private System.Boolean EyesWarning(RootMotion.BipedReferences references, System.String& warningMessage) { }
        private System.Boolean RootHeightWarning(RootMotion.BipedReferences references, System.String& warningMessage) { }
        private System.Boolean FacingAxisWarning(RootMotion.BipedReferences references, System.String& warningMessage) { }
        private System.Single GetVerticalOffset(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Quaternion rotation) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001A
    public class Comments : MonoBehaviour
    {
        // Fields
        public System.String text;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001B
    public class DemoGUIMessage : MonoBehaviour
    {
        // Fields
        public System.String text;        // 0x18
        public UnityEngine.Color color;        // 0x20

        // Methods
        private System.Void OnGUI() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001C
    public class Hierarchy
    {
        // Methods
        private System.Boolean HierarchyIsValid(UnityEngine.Transform[] bones) { }
        private UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects) { }
        private System.Boolean IsAncestor(UnityEngine.Transform transform, UnityEngine.Transform ancestor) { }
        private System.Boolean ContainsChild(UnityEngine.Transform transform, UnityEngine.Transform child) { }
        private System.Void AddAncestors(UnityEngine.Transform transform, UnityEngine.Transform blocker, UnityEngine.Transform[]& array) { }
        private UnityEngine.Transform GetAncestor(UnityEngine.Transform transform, System.Int32 minChildCount) { }
        private UnityEngine.Transform GetFirstCommonAncestor(UnityEngine.Transform t1, UnityEngine.Transform t2) { }
        private UnityEngine.Transform GetFirstCommonAncestor(UnityEngine.Transform[] transforms) { }
        private UnityEngine.Transform GetFirstCommonAncestorRecursive(UnityEngine.Transform transform, UnityEngine.Transform[] transforms) { }
        private System.Boolean IsCommonAncestor(UnityEngine.Transform transform, UnityEngine.Transform[] transforms) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001D
    public class InspectorComment : PropertyAttribute
    {
        // Fields
        public System.String name;        // 0x10
        public System.String color;        // 0x18

        // Methods
        private System.Void .ctor(System.String name) { }
        private System.Void .ctor(System.String name, System.String color) { }

    }

    // TypeToken: 0x200001E
    public struct InterpolationMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static RootMotion.InterpolationMode None;        // 0x0
        public static RootMotion.InterpolationMode InOutCubic;        // 0x0
        public static RootMotion.InterpolationMode InOutQuintic;        // 0x0
        public static RootMotion.InterpolationMode InOutSine;        // 0x0
        public static RootMotion.InterpolationMode InQuintic;        // 0x0
        public static RootMotion.InterpolationMode InQuartic;        // 0x0
        public static RootMotion.InterpolationMode InCubic;        // 0x0
        public static RootMotion.InterpolationMode InQuadratic;        // 0x0
        public static RootMotion.InterpolationMode InElastic;        // 0x0
        public static RootMotion.InterpolationMode InElasticSmall;        // 0x0
        public static RootMotion.InterpolationMode InElasticBig;        // 0x0
        public static RootMotion.InterpolationMode InSine;        // 0x0
        public static RootMotion.InterpolationMode InBack;        // 0x0
        public static RootMotion.InterpolationMode OutQuintic;        // 0x0
        public static RootMotion.InterpolationMode OutQuartic;        // 0x0
        public static RootMotion.InterpolationMode OutCubic;        // 0x0
        public static RootMotion.InterpolationMode OutInCubic;        // 0x0
        public static RootMotion.InterpolationMode OutInQuartic;        // 0x0
        public static RootMotion.InterpolationMode OutElastic;        // 0x0
        public static RootMotion.InterpolationMode OutElasticSmall;        // 0x0
        public static RootMotion.InterpolationMode OutElasticBig;        // 0x0
        public static RootMotion.InterpolationMode OutSine;        // 0x0
        public static RootMotion.InterpolationMode OutBack;        // 0x0
        public static RootMotion.InterpolationMode OutBackCubic;        // 0x0
        public static RootMotion.InterpolationMode OutBackQuartic;        // 0x0
        public static RootMotion.InterpolationMode BackInCubic;        // 0x0
        public static RootMotion.InterpolationMode BackInQuartic;        // 0x0

    }

    // TypeToken: 0x200001F
    public class Interp
    {
        // Methods
        private System.Single Float(System.Single t, RootMotion.InterpolationMode mode) { }
        private UnityEngine.Vector3 V3(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, System.Single t, RootMotion.InterpolationMode mode) { }
        private System.Single LerpValue(System.Single value, System.Single target, System.Single increaseSpeed, System.Single decreaseSpeed) { }
        private System.Single None(System.Single t, System.Single b, System.Single c) { }
        private System.Single InOutCubic(System.Single t, System.Single b, System.Single c) { }
        private System.Single InOutQuintic(System.Single t, System.Single b, System.Single c) { }
        private System.Single InQuintic(System.Single t, System.Single b, System.Single c) { }
        private System.Single InQuartic(System.Single t, System.Single b, System.Single c) { }
        private System.Single InCubic(System.Single t, System.Single b, System.Single c) { }
        private System.Single InQuadratic(System.Single t, System.Single b, System.Single c) { }
        private System.Single OutQuintic(System.Single t, System.Single b, System.Single c) { }
        private System.Single OutQuartic(System.Single t, System.Single b, System.Single c) { }
        private System.Single OutCubic(System.Single t, System.Single b, System.Single c) { }
        private System.Single OutInCubic(System.Single t, System.Single b, System.Single c) { }
        private System.Single OutInQuartic(System.Single t, System.Single b, System.Single c) { }
        private System.Single BackInCubic(System.Single t, System.Single b, System.Single c) { }
        private System.Single BackInQuartic(System.Single t, System.Single b, System.Single c) { }
        private System.Single OutBackCubic(System.Single t, System.Single b, System.Single c) { }
        private System.Single OutBackQuartic(System.Single t, System.Single b, System.Single c) { }
        private System.Single OutElasticSmall(System.Single t, System.Single b, System.Single c) { }
        private System.Single OutElasticBig(System.Single t, System.Single b, System.Single c) { }
        private System.Single InElasticSmall(System.Single t, System.Single b, System.Single c) { }
        private System.Single InElasticBig(System.Single t, System.Single b, System.Single c) { }
        private System.Single InSine(System.Single t, System.Single b, System.Single c) { }
        private System.Single OutSine(System.Single t, System.Single b, System.Single c) { }
        private System.Single InOutSine(System.Single t, System.Single b, System.Single c) { }
        private System.Single InElastic(System.Single t, System.Single b, System.Single c) { }
        private System.Single OutElastic(System.Single t, System.Single b, System.Single c) { }
        private System.Single InBack(System.Single t, System.Single b, System.Single c) { }
        private System.Single OutBack(System.Single t, System.Single b, System.Single c) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000020
    public class LayerMaskExtensions
    {
        // Methods
        private System.Boolean Contains(UnityEngine.LayerMask mask, System.Int32 layer) { }
        private UnityEngine.LayerMask Create(System.String[] layerNames) { }
        private UnityEngine.LayerMask Create(System.Int32[] layerNumbers) { }
        private UnityEngine.LayerMask NamesToMask(System.String[] layerNames) { }
        private UnityEngine.LayerMask LayerNumbersToMask(System.Int32[] layerNumbers) { }
        private UnityEngine.LayerMask Inverse(UnityEngine.LayerMask original) { }
        private UnityEngine.LayerMask AddToMask(UnityEngine.LayerMask original, System.String[] layerNames) { }
        private UnityEngine.LayerMask RemoveFromMask(UnityEngine.LayerMask original, System.String[] layerNames) { }
        private System.String[] MaskToNames(UnityEngine.LayerMask original) { }
        private System.Int32[] MaskToNumbers(UnityEngine.LayerMask original) { }
        private System.String MaskToString(UnityEngine.LayerMask original) { }
        private System.String MaskToString(UnityEngine.LayerMask original, System.String delimiter) { }

    }

    // TypeToken: 0x2000021
    public class LazySingleton`1 : MonoBehaviour
    {
        // Fields
        private static T sInstance;        // 0x0

        // Methods
        private System.Boolean get_hasInstance() { }
        private T get_instance() { }
        private System.Void Awake() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000022
    public struct ShowIfMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static RootMotion.ShowIfMode Disabled;        // 0x0
        public static RootMotion.ShowIfMode Hidden;        // 0x0

    }

    // TypeToken: 0x2000023
    public class ShowIfAttribute : PropertyAttribute
    {
        // Fields
        private System.String <propName>k__BackingField;        // 0x10
        private System.Object <propValue>k__BackingField;        // 0x18
        private System.Object <otherPropValue>k__BackingField;        // 0x20
        private System.Boolean <indent>k__BackingField;        // 0x28
        private RootMotion.ShowIfMode <mode>k__BackingField;        // 0x2C

        // Methods
        private System.String get_propName() { }
        private System.Void set_propName(System.String value) { }
        private System.Object get_propValue() { }
        private System.Void set_propValue(System.Object value) { }
        private System.Object get_otherPropValue() { }
        private System.Void set_otherPropValue(System.Object value) { }
        private System.Boolean get_indent() { }
        private System.Void set_indent(System.Boolean value) { }
        private RootMotion.ShowIfMode get_mode() { }
        private System.Void set_mode(RootMotion.ShowIfMode value) { }
        private System.Void .ctor(System.String propertyName, System.Object propertyValue, System.Object otherPropertyValue, System.Boolean indent, RootMotion.ShowIfMode mode) { }

    }

    // TypeToken: 0x2000024
    public class ShowRangeIfAttribute : ShowIfAttribute
    {
        // Fields
        private System.Single <min>k__BackingField;        // 0x30
        private System.Single <max>k__BackingField;        // 0x34

        // Methods
        private System.Single get_min() { }
        private System.Void set_min(System.Single value) { }
        private System.Single get_max() { }
        private System.Void set_max(System.Single value) { }
        private System.Void .ctor(System.Single min, System.Single max, System.String propertyName, System.Object propertyValue, System.Object otherPropertyValue, System.Boolean indent, RootMotion.ShowIfMode mode) { }

    }

    // TypeToken: 0x2000025
    public class ShowLargeHeaderIf : ShowIfAttribute
    {
        // Fields
        public System.String name;        // 0x30
        public System.String color;        // 0x38

        // Methods
        private System.Void .ctor(System.String name, System.String propertyName, System.Object propertyValue, System.Object otherPropertyValue, System.Boolean indent, RootMotion.ShowIfMode mode) { }
        private System.Void .ctor(System.String name, System.String color, System.String propertyName, System.Object propertyValue, System.Object otherPropertyValue, System.Boolean indent, RootMotion.ShowIfMode mode) { }

    }

    // TypeToken: 0x2000026
    public class LargeHeader : PropertyAttribute
    {
        // Fields
        public System.String name;        // 0x10
        public System.String color;        // 0x18

        // Methods
        private System.Void .ctor(System.String name) { }
        private System.Void .ctor(System.String name, System.String color) { }

    }

    // TypeToken: 0x2000027
    public class QuaTools
    {
        // Methods
        private System.Single GetYaw(UnityEngine.Quaternion space, UnityEngine.Vector3 forward) { }
        private System.Single GetPitch(UnityEngine.Quaternion space, UnityEngine.Vector3 forward) { }
        private System.Single GetBank(UnityEngine.Quaternion space, UnityEngine.Vector3 forward, UnityEngine.Vector3 up) { }
        private System.Single GetYaw(UnityEngine.Quaternion space, UnityEngine.Quaternion rotation) { }
        private System.Single GetPitch(UnityEngine.Quaternion space, UnityEngine.Quaternion rotation) { }
        private System.Single GetBank(UnityEngine.Quaternion space, UnityEngine.Quaternion rotation) { }
        private UnityEngine.Quaternion Lerp(UnityEngine.Quaternion fromRotation, UnityEngine.Quaternion toRotation, System.Single weight) { }
        private UnityEngine.Quaternion Slerp(UnityEngine.Quaternion fromRotation, UnityEngine.Quaternion toRotation, System.Single weight) { }
        private UnityEngine.Quaternion LinearBlend(UnityEngine.Quaternion q, System.Single weight) { }
        private UnityEngine.Quaternion SphericalBlend(UnityEngine.Quaternion q, System.Single weight) { }
        private UnityEngine.Quaternion FromToAroundAxis(UnityEngine.Vector3 fromDirection, UnityEngine.Vector3 toDirection, UnityEngine.Vector3 axis) { }
        private UnityEngine.Quaternion RotationToLocalSpace(UnityEngine.Quaternion space, UnityEngine.Quaternion rotation) { }
        private UnityEngine.Quaternion FromToRotation(UnityEngine.Quaternion from, UnityEngine.Quaternion to) { }
        private UnityEngine.Vector3 GetAxis(UnityEngine.Vector3 v) { }
        private UnityEngine.Quaternion ClampRotation(UnityEngine.Quaternion rotation, System.Single clampWeight, System.Int32 clampSmoothing) { }
        private System.Single ClampAngle(System.Single angle, System.Single clampWeight, System.Int32 clampSmoothing) { }
        private UnityEngine.Quaternion MatchRotation(UnityEngine.Quaternion targetRotation, UnityEngine.Vector3 targetAxis1, UnityEngine.Vector3 targetAxis2, UnityEngine.Vector3 axis1, UnityEngine.Vector3 axis2) { }
        private UnityEngine.Vector3 ToBiPolar(UnityEngine.Vector3 euler) { }
        private System.Single ToBiPolar(System.Single angle) { }
        private UnityEngine.Quaternion MirrorYZ(UnityEngine.Quaternion r, UnityEngine.Quaternion space) { }
        private UnityEngine.Quaternion MirrorYZ(UnityEngine.Quaternion r) { }

    }

    // TypeToken: 0x2000028
    public class Singleton`1 : MonoBehaviour
    {
        // Fields
        private static T sInstance;        // 0x0

        // Methods
        private T get_instance() { }
        private System.Void Clear() { }
        private System.Void Awake() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000029
    public class SolverManager : MonoBehaviour
    {
        // Fields
        public System.Boolean fixTransforms;        // 0x18
        private UnityEngine.Animator animator;        // 0x20
        private UnityEngine.Animation legacy;        // 0x28
        private System.Boolean updateFrame;        // 0x30
        private System.Boolean componentInitiated;        // 0x31
        private System.Boolean skipSolverUpdate;        // 0x32

        // Methods
        private System.Void Disable() { }
        private System.Void InitiateSolver() { }
        private System.Void UpdateSolver() { }
        private System.Void FixTransforms() { }
        private System.Void OnDisable() { }
        private System.Void Start() { }
        private System.Boolean get_animatePhysics() { }
        private System.Void Initiate() { }
        private System.Void Update() { }
        private System.Void FindAnimatorRecursive(UnityEngine.Transform t, System.Boolean findInChildren) { }
        private System.Boolean get_isAnimated() { }
        private System.Void FixedUpdate() { }
        private System.Void LateUpdate() { }
        private System.Void UpdateSolverExternal() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002A
    public class TriggerEventBroadcaster : MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject target;        // 0x18

        // Methods
        private System.Void OnTriggerEnter(UnityEngine.Collider collider) { }
        private System.Void OnTriggerStay(UnityEngine.Collider collider) { }
        private System.Void OnTriggerExit(UnityEngine.Collider collider) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002B
    public class V2Tools
    {
        // Methods
        private UnityEngine.Vector2 XZ(UnityEngine.Vector3 v) { }
        private System.Single DeltaAngle(UnityEngine.Vector2 dir1, UnityEngine.Vector2 dir2) { }
        private System.Single DeltaAngleXZ(UnityEngine.Vector3 dir1, UnityEngine.Vector3 dir2) { }
        private System.Boolean LineCircleIntersect(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 c, System.Single r) { }
        private System.Boolean RayCircleIntersect(UnityEngine.Vector2 p1, UnityEngine.Vector2 dir, UnityEngine.Vector2 c, System.Single r) { }

    }

    // TypeToken: 0x200002C
    public class V3Tools
    {
        // Methods
        private System.Single GetYaw(UnityEngine.Vector3 forward) { }
        private System.Single GetPitch(UnityEngine.Vector3 forward) { }
        private System.Single GetBank(UnityEngine.Vector3 forward, UnityEngine.Vector3 up) { }
        private System.Single GetYaw(UnityEngine.Vector3 spaceForward, UnityEngine.Vector3 spaceUp, UnityEngine.Vector3 forward) { }
        private System.Single GetPitch(UnityEngine.Vector3 spaceForward, UnityEngine.Vector3 spaceUp, UnityEngine.Vector3 forward) { }
        private System.Single GetBank(UnityEngine.Vector3 spaceForward, UnityEngine.Vector3 spaceUp, UnityEngine.Vector3 forward, UnityEngine.Vector3 up) { }
        private UnityEngine.Vector3 Lerp(UnityEngine.Vector3 fromVector, UnityEngine.Vector3 toVector, System.Single weight) { }
        private UnityEngine.Vector3 Slerp(UnityEngine.Vector3 fromVector, UnityEngine.Vector3 toVector, System.Single weight) { }
        private UnityEngine.Vector3 ExtractVertical(UnityEngine.Vector3 v, UnityEngine.Vector3 verticalAxis, System.Single weight) { }
        private UnityEngine.Vector3 ExtractHorizontal(UnityEngine.Vector3 v, UnityEngine.Vector3 normal, System.Single weight) { }
        private UnityEngine.Vector3 Flatten(UnityEngine.Vector3 v, UnityEngine.Vector3 normal) { }
        private UnityEngine.Vector3 ClampDirection(UnityEngine.Vector3 direction, UnityEngine.Vector3 normalDirection, System.Single clampWeight, System.Int32 clampSmoothing) { }
        private UnityEngine.Vector3 ClampDirection(UnityEngine.Vector3 direction, UnityEngine.Vector3 normalDirection, System.Single clampWeight, System.Int32 clampSmoothing, System.Boolean& changed) { }
        private UnityEngine.Vector3 ClampDirection(UnityEngine.Vector3 direction, UnityEngine.Vector3 normalDirection, System.Single clampWeight, System.Int32 clampSmoothing, System.Single& clampValue) { }
        private UnityEngine.Vector3 LineToPlane(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.Vector3 planeNormal, UnityEngine.Vector3 planePoint) { }
        private UnityEngine.Vector3 PointToPlane(UnityEngine.Vector3 point, UnityEngine.Vector3 planePosition, UnityEngine.Vector3 planeNormal) { }
        private UnityEngine.Vector3 TransformPointUnscaled(UnityEngine.Transform t, UnityEngine.Vector3 point) { }
        private UnityEngine.Vector3 InverseTransformPointUnscaled(UnityEngine.Transform t, UnityEngine.Vector3 point) { }
        private UnityEngine.Vector3 InverseTransformPoint(UnityEngine.Vector3 tPos, UnityEngine.Quaternion tRot, UnityEngine.Vector3 tScale, UnityEngine.Vector3 point) { }
        private UnityEngine.Vector3 TransformPoint(UnityEngine.Vector3 tPos, UnityEngine.Quaternion tRot, UnityEngine.Vector3 tScale, UnityEngine.Vector3 point) { }
        private UnityEngine.Vector3 Div(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2) { }

    }

    // TypeToken: 0x200002D
    public class Warning
    {
        // Fields
        public static System.Boolean logged;        // 0x0

        // Methods
        private System.Void Log(System.String message, RootMotion.Warning.Logger logger, System.Boolean logInEditMode) { }
        private System.Void Log(System.String message, UnityEngine.Transform context, System.Boolean logInEditMode) { }

    }

}

namespace RootMotion.Demos
{

    // TypeToken: 0x200002F
    public class Navigator
    {
        // Fields
        public System.Boolean activeTargetSeeking;        // 0x10
        public System.Single cornerRadius;        // 0x14
        public System.Single recalculateOnPathDistance;        // 0x18
        public System.Single maxSampleDistance;        // 0x1C
        public System.Single nextPathInterval;        // 0x20
        private UnityEngine.Vector3 <normalizedDeltaPosition>k__BackingField;        // 0x24
        private RootMotion.Demos.Navigator.State <state>k__BackingField;        // 0x30
        private UnityEngine.Transform transform;        // 0x38
        private System.Int32 cornerIndex;        // 0x40
        private UnityEngine.Vector3[] corners;        // 0x48
        private UnityEngine.AI.NavMeshPath path;        // 0x50
        private UnityEngine.Vector3 lastTargetPosition;        // 0x58
        private System.Boolean initiated;        // 0x64
        private System.Single nextPathTime;        // 0x68

        // Methods
        private UnityEngine.Vector3 get_normalizedDeltaPosition() { }
        private System.Void set_normalizedDeltaPosition(UnityEngine.Vector3 value) { }
        private RootMotion.Demos.Navigator.State get_state() { }
        private System.Void set_state(RootMotion.Demos.Navigator.State value) { }
        private System.Void Initiate(UnityEngine.Transform transform) { }
        private System.Void Update(UnityEngine.Vector3 targetPosition) { }
        private System.Void CalculatePath(UnityEngine.Vector3 targetPosition) { }
        private System.Boolean Find(UnityEngine.Vector3 targetPosition) { }
        private System.Void Stop() { }
        private System.Single HorDistance(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2) { }
        private System.Void Visualize() { }
        private System.Void .ctor() { }

    }

}

namespace RootMotion.FinalIK
{

    // TypeToken: 0x2000031
    public class BipedIK : SolverManager
    {
        // Fields
        public RootMotion.BipedReferences references;        // 0x38
        public RootMotion.FinalIK.BipedIKSolvers solvers;        // 0x40

        // Methods
        private System.Void OpenUserManual() { }
        private System.Void OpenScriptReference() { }
        private System.Void SupportGroup() { }
        private System.Void ASThread() { }
        private System.Single GetIKPositionWeight(UnityEngine.AvatarIKGoal goal) { }
        private System.Single GetIKRotationWeight(UnityEngine.AvatarIKGoal goal) { }
        private System.Void SetIKPositionWeight(UnityEngine.AvatarIKGoal goal, System.Single weight) { }
        private System.Void SetIKRotationWeight(UnityEngine.AvatarIKGoal goal, System.Single weight) { }
        private System.Void SetIKPosition(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3 IKPosition) { }
        private System.Void SetIKRotation(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion IKRotation) { }
        private UnityEngine.Vector3 GetIKPosition(UnityEngine.AvatarIKGoal goal) { }
        private UnityEngine.Quaternion GetIKRotation(UnityEngine.AvatarIKGoal goal) { }
        private System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight, System.Single clampWeight, System.Single clampWeightHead, System.Single clampWeightEyes) { }
        private System.Void SetLookAtPosition(UnityEngine.Vector3 lookAtPosition) { }
        private System.Void SetSpinePosition(UnityEngine.Vector3 spinePosition) { }
        private System.Void SetSpineWeight(System.Single weight) { }
        private RootMotion.FinalIK.IKSolverLimb GetGoalIK(UnityEngine.AvatarIKGoal goal) { }
        private System.Void InitiateBipedIK() { }
        private System.Void UpdateBipedIK() { }
        private System.Void SetToDefaults() { }
        private System.Void FixTransforms() { }
        private System.Void InitiateSolver() { }
        private System.Void UpdateSolver() { }
        private System.Void LogWarning(System.String message) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000032
    public class BipedIKSolvers
    {
        // Fields
        public RootMotion.FinalIK.IKSolverLimb leftFoot;        // 0x10
        public RootMotion.FinalIK.IKSolverLimb rightFoot;        // 0x18
        public RootMotion.FinalIK.IKSolverLimb leftHand;        // 0x20
        public RootMotion.FinalIK.IKSolverLimb rightHand;        // 0x28
        public RootMotion.FinalIK.IKSolverFABRIK spine;        // 0x30
        public RootMotion.FinalIK.IKSolverLookAt lookAt;        // 0x38
        public RootMotion.FinalIK.IKSolverAim aim;        // 0x40
        public RootMotion.FinalIK.Constraints pelvis;        // 0x48
        private RootMotion.FinalIK.IKSolverLimb[] _limbs;        // 0x50
        private RootMotion.FinalIK.IKSolver[] _ikSolvers;        // 0x58

        // Methods
        private RootMotion.FinalIK.IKSolverLimb[] get_limbs() { }
        private RootMotion.FinalIK.IKSolver[] get_ikSolvers() { }
        private System.Void AssignReferences(RootMotion.BipedReferences references) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000033
    public class Constraint
    {
        // Fields
        public UnityEngine.Transform transform;        // 0x10
        public System.Single weight;        // 0x18

        // Methods
        private System.Boolean get_isValid() { }
        private System.Void UpdateConstraint() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000034
    public class ConstraintPosition : Constraint
    {
        // Fields
        public UnityEngine.Vector3 position;        // 0x20

        // Methods
        private System.Void UpdateConstraint() { }
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.Transform transform) { }

    }

    // TypeToken: 0x2000035
    public class ConstraintPositionOffset : Constraint
    {
        // Fields
        public UnityEngine.Vector3 offset;        // 0x20
        private UnityEngine.Vector3 defaultLocalPosition;        // 0x2C
        private UnityEngine.Vector3 lastLocalPosition;        // 0x38
        private System.Boolean initiated;        // 0x44

        // Methods
        private System.Void UpdateConstraint() { }
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.Transform transform) { }
        private System.Boolean get_positionChanged() { }

    }

    // TypeToken: 0x2000036
    public class ConstraintRotation : Constraint
    {
        // Fields
        public UnityEngine.Quaternion rotation;        // 0x20

        // Methods
        private System.Void UpdateConstraint() { }
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.Transform transform) { }

    }

    // TypeToken: 0x2000037
    public class ConstraintRotationOffset : Constraint
    {
        // Fields
        public UnityEngine.Quaternion offset;        // 0x20
        private UnityEngine.Quaternion defaultRotation;        // 0x30
        private UnityEngine.Quaternion defaultLocalRotation;        // 0x40
        private UnityEngine.Quaternion lastLocalRotation;        // 0x50
        private UnityEngine.Quaternion defaultTargetLocalRotation;        // 0x60
        private System.Boolean initiated;        // 0x70

        // Methods
        private System.Void UpdateConstraint() { }
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.Transform transform) { }
        private System.Boolean get_rotationChanged() { }

    }

    // TypeToken: 0x2000038
    public class Constraints
    {
        // Fields
        public UnityEngine.Transform transform;        // 0x10
        public UnityEngine.Transform target;        // 0x18
        public UnityEngine.Vector3 positionOffset;        // 0x20
        public UnityEngine.Vector3 position;        // 0x2C
        public System.Single positionWeight;        // 0x38
        public UnityEngine.Vector3 rotationOffset;        // 0x3C
        public UnityEngine.Vector3 rotation;        // 0x48
        public System.Single rotationWeight;        // 0x54

        // Methods
        private System.Boolean IsValid() { }
        private System.Void Initiate(UnityEngine.Transform transform) { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000039
    public class Finger
    {
        // Fields
        public System.Single weight;        // 0x10
        public System.Single rotationWeight;        // 0x14
        public RootMotion.FinalIK.Finger.DOF rotationDOF;        // 0x18
        public System.Boolean fixBone1Twist;        // 0x1C
        public UnityEngine.Transform bone1;        // 0x20
        public UnityEngine.Transform bone2;        // 0x28
        public UnityEngine.Transform bone3;        // 0x30
        public UnityEngine.Transform tip;        // 0x38
        public UnityEngine.Transform target;        // 0x40
        private System.Boolean <initiated>k__BackingField;        // 0x48
        private RootMotion.FinalIK.IKSolverLimb solver;        // 0x50
        private UnityEngine.Quaternion bone3RelativeToTarget;        // 0x58
        private UnityEngine.Vector3 bone3DefaultLocalPosition;        // 0x68
        private UnityEngine.Quaternion bone3DefaultLocalRotation;        // 0x74
        private UnityEngine.Vector3 bone1Axis;        // 0x84
        private UnityEngine.Vector3 tipAxis;        // 0x90
        private UnityEngine.Vector3 bone1TwistAxis;        // 0x9C
        private UnityEngine.Vector3 defaultBendNormal;        // 0xA8

        // Methods
        private System.Boolean get_initiated() { }
        private System.Void set_initiated(System.Boolean value) { }
        private UnityEngine.Vector3 get_IKPosition() { }
        private System.Void set_IKPosition(UnityEngine.Vector3 value) { }
        private UnityEngine.Quaternion get_IKRotation() { }
        private System.Void set_IKRotation(UnityEngine.Quaternion value) { }
        private System.Boolean IsValid(System.String& errorMessage) { }
        private System.Void Initiate(UnityEngine.Transform hand, System.Int32 index) { }
        private System.Void FixTransforms() { }
        private System.Void StoreDefaultLocalState() { }
        private System.Void Update(System.Single masterWeight) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003B
    public class FingerRig : SolverManager
    {
        // Fields
        public System.Single weight;        // 0x38
        public RootMotion.FinalIK.Finger[] fingers;        // 0x40
        private System.Boolean <initiated>k__BackingField;        // 0x48

        // Methods
        private System.Boolean get_initiated() { }
        private System.Void set_initiated(System.Boolean value) { }
        private System.Boolean IsValid(System.String& errorMessage) { }
        private System.Void AutoDetect() { }
        private System.Void AddFinger(UnityEngine.Transform bone1, UnityEngine.Transform bone2, UnityEngine.Transform bone3, UnityEngine.Transform tip, UnityEngine.Transform target) { }
        private System.Void RemoveFinger(System.Int32 index) { }
        private System.Void AddChildrenRecursive(UnityEngine.Transform parent, UnityEngine.Transform[]& array) { }
        private System.Void InitiateSolver() { }
        private System.Void UpdateFingerSolvers() { }
        private System.Void FixFingerTransforms() { }
        private System.Void StoreDefaultLocalState() { }
        private System.Void UpdateSolver() { }
        private System.Void FixTransforms() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003C
    public class Grounder : MonoBehaviour
    {
        // Fields
        public System.Single weight;        // 0x18
        public System.Single maintianPelvisFootWeight;        // 0x1C
        public System.Single footAdsorbWeight;        // 0x20
        public RootMotion.FinalIK.Grounding solver;        // 0x28
        public RootMotion.FinalIK.Grounder.GrounderDelegate OnPreGrounder;        // 0x30
        public RootMotion.FinalIK.Grounder.GrounderDelegate OnPostGrounder;        // 0x38
        public RootMotion.FinalIK.Grounder.GrounderDelegate OnPostIK;        // 0x40
        private System.Boolean <initiated>k__BackingField;        // 0x48

        // Methods
        private System.Void ResetPosition() { }
        private System.Boolean get_initiated() { }
        private System.Void set_initiated(System.Boolean value) { }
        private UnityEngine.Vector3 GetSpineOffsetTarget() { }
        private System.Void LogWarning(System.String message) { }
        private UnityEngine.Vector3 GetLegSpineBendVector(RootMotion.FinalIK.Grounding.Leg leg) { }
        private UnityEngine.Vector3 GetLegSpineTangent(RootMotion.FinalIK.Grounding.Leg leg) { }
        private System.Void OpenUserManual() { }
        private System.Void OpenScriptReference() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003E
    public class GrounderBipedIK : Grounder
    {
        // Fields
        public RootMotion.FinalIK.BipedIK ik;        // 0x50
        public System.Single spineBend;        // 0x58
        public System.Single spineSpeed;        // 0x5C
        private UnityEngine.Transform[] feet;        // 0x60
        private UnityEngine.Quaternion[] footRotations;        // 0x68
        private UnityEngine.Vector3 animatedPelvisLocalPosition;        // 0x70
        private UnityEngine.Vector3 solvedPelvisLocalPosition;        // 0x7C
        private UnityEngine.Vector3 spineOffset;        // 0x88
        private System.Single lastWeight;        // 0x94
        private System.Single lastAdsorbWeight;        // 0x98
        private System.Single rightFootOffsetY;        // 0x9C
        private System.Single leftFootOffsetY;        // 0xA0
        private System.Single rightFootOri;        // 0xA4
        private System.Single leftFootOri;        // 0xA8
        public UnityEngine.Transform ikOriReferenceBone;        // 0xB0

        // Methods
        private System.Void OpenUserManual() { }
        private System.Void OpenScriptReference() { }
        private System.Void ResetPosition() { }
        private System.Single get_RightFootOffsetY() { }
        private System.Single get_LeftFootOffsetY() { }
        private System.Single get_RightFootOri() { }
        private System.Single get_LeftFootOri() { }
        private System.Boolean IsReadyToInitiate() { }
        private System.Void Update() { }
        private System.Void Initiate() { }
        private System.Void OnDisable() { }
        private System.Void OnSolverUpdate() { }
        private System.Void SetLegIK(RootMotion.FinalIK.IKSolverLimb limb, System.Int32 index) { }
        private System.Void OnPostSolverUpdate() { }
        private System.Void OnDestroy() { }
        private UnityEngine.Quaternion ClampPitchAndRollAroundForward(UnityEngine.Quaternion Q, UnityEngine.Quaternion calfQ, System.Single minPitch, System.Single maxPitch, System.Single minRoll, System.Single maxRoll) { }
        private System.Single NormalizeAngle(System.Single angle) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003F
    public class GrounderFBBIK : Grounder
    {
        // Fields
        public RootMotion.FinalIK.FullBodyBipedIK ik;        // 0x50
        public System.Single spineBend;        // 0x58
        public System.Single spineSpeed;        // 0x5C
        public RootMotion.FinalIK.GrounderFBBIK.SpineEffector[] spine;        // 0x60
        private UnityEngine.Transform[] feet;        // 0x68
        private UnityEngine.Vector3 spineOffset;        // 0x70
        private System.Boolean firstSolve;        // 0x7C

        // Methods
        private System.Void OpenTutorial() { }
        private System.Void OpenUserManual() { }
        private System.Void OpenScriptReference() { }
        private System.Void ResetPosition() { }
        private System.Boolean IsReadyToInitiate() { }
        private System.Void Update() { }
        private System.Void FixedUpdate() { }
        private System.Void LateUpdate() { }
        private System.Void Initiate() { }
        private System.Void OnSolverUpdate() { }
        private System.Void SetLegIK(RootMotion.FinalIK.IKEffector effector, RootMotion.FinalIK.Grounding.Leg leg) { }
        private System.Void OnDrawGizmosSelected() { }
        private System.Void OnPostSolverUpdate() { }
        private System.Void OnDestroy() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000041
    public class GrounderIK : Grounder
    {
        // Fields
        public RootMotion.FinalIK.IK[] legs;        // 0x50
        public UnityEngine.Transform pelvis;        // 0x58
        public UnityEngine.Transform characterRoot;        // 0x60
        public System.Single rootRotationWeight;        // 0x68
        public System.Single rootRotationSpeed;        // 0x6C
        public System.Single maxRootRotationAngle;        // 0x70
        private UnityEngine.Transform[] feet;        // 0x78
        private UnityEngine.Quaternion[] footRotations;        // 0x80
        private UnityEngine.Vector3 animatedPelvisLocalPosition;        // 0x88
        private UnityEngine.Vector3 solvedPelvisLocalPosition;        // 0x94
        private System.Int32 solvedFeet;        // 0xA0
        private System.Boolean solved;        // 0xA4
        private System.Single lastWeight;        // 0xA8
        private UnityEngine.Rigidbody characterRootRigidbody;        // 0xB0

        // Methods
        private System.Void OpenUserManual() { }
        private System.Void OpenScriptReference() { }
        private System.Void ResetPosition() { }
        private System.Boolean IsReadyToInitiate() { }
        private System.Void OnDisable() { }
        private System.Void Update() { }
        private System.Void Initiate() { }
        private System.Void OnSolverUpdate() { }
        private System.Void SetLegIK(System.Int32 index) { }
        private System.Void OnPostSolverUpdate() { }
        private System.Void OnDestroy() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000042
    public class GrounderQuadruped : Grounder
    {
        // Fields
        public RootMotion.FinalIK.Grounding forelegSolver;        // 0x50
        public System.Single rootRotationWeight;        // 0x58
        public System.Single minRootRotation;        // 0x5C
        public System.Single maxRootRotation;        // 0x60
        public System.Single rootRotationSpeed;        // 0x64
        public System.Single maxLegOffset;        // 0x68
        public System.Single maxForeLegOffset;        // 0x6C
        public System.Single maintainHeadRotationWeight;        // 0x70
        public UnityEngine.Transform characterRoot;        // 0x78
        public UnityEngine.Transform pelvis;        // 0x80
        public UnityEngine.Transform lastSpineBone;        // 0x88
        public UnityEngine.Transform head;        // 0x90
        public RootMotion.FinalIK.IK[] legs;        // 0x98
        public RootMotion.FinalIK.IK[] forelegs;        // 0xA0
        public UnityEngine.Vector3 gravity;        // 0xA8
        private RootMotion.FinalIK.GrounderQuadruped.Foot[] feet;        // 0xB8
        private UnityEngine.Vector3 animatedPelvisLocalPosition;        // 0xC0
        private UnityEngine.Quaternion animatedPelvisLocalRotation;        // 0xCC
        private UnityEngine.Quaternion animatedHeadLocalRotation;        // 0xDC
        private UnityEngine.Vector3 solvedPelvisLocalPosition;        // 0xEC
        private UnityEngine.Quaternion solvedPelvisLocalRotation;        // 0xF8
        private UnityEngine.Quaternion solvedHeadLocalRotation;        // 0x108
        private System.Int32 solvedFeet;        // 0x118
        private System.Boolean solved;        // 0x11C
        private System.Single angle;        // 0x120
        private UnityEngine.Transform forefeetRoot;        // 0x128
        private UnityEngine.Quaternion headRotation;        // 0x130
        private System.Single lastWeight;        // 0x140
        private UnityEngine.Rigidbody characterRootRigidbody;        // 0x148

        // Methods
        private System.Void OpenUserManual() { }
        private System.Void OpenScriptReference() { }
        private System.Void ResetPosition() { }
        private System.Boolean IsReadyToInitiate() { }
        private System.Boolean IsReadyToInitiateLegs(RootMotion.FinalIK.IK[] ikComponents) { }
        private System.Void OnDisable() { }
        private System.Void Update() { }
        private System.Void Initiate() { }
        private UnityEngine.Transform[] InitiateFeet(RootMotion.FinalIK.IK[] ikComponents, RootMotion.FinalIK.GrounderQuadruped.Foot[]& f, System.Int32 indexOffset) { }
        private System.Void LateUpdate() { }
        private System.Void RootRotation() { }
        private System.Void OnSolverUpdate() { }
        private System.Void UpdateForefeetRoot() { }
        private System.Void SetFootIK(RootMotion.FinalIK.GrounderQuadruped.Foot foot, System.Single maxOffset) { }
        private System.Void OnPostSolverUpdate() { }
        private System.Void OnDestroy() { }
        private System.Void DestroyLegs(RootMotion.FinalIK.IK[] ikComponents) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000044
    public class Grounding
    {
        // Fields
        public UnityEngine.Transform IKFootBoneL;        // 0x10
        public UnityEngine.Transform IKFootBoneR;        // 0x18
        public System.Single floorLogicTheta;        // 0x20
        public System.Single floorAnimTheta;        // 0x24
        public System.Single floorPredictTheta;        // 0x28
        public System.Single floorFeetThetaByFoot;        // 0x2C
        public System.Single floorFeetThetaByRoot;        // 0x30
        public System.Single floorFeetThetaByLogic;        // 0x34
        public System.Single betweenFeetDistance;        // 0x38
        public System.Boolean isMoving;        // 0x3C
        public System.Boolean isAccelerating;        // 0x3D
        public System.Boolean isPlayingMontage;        // 0x3E
        public System.Single SG_timeRef;        // 0x40
        public System.Single gait;        // 0x44
        public System.Single startAnimWeight;        // 0x48
        public UnityEngine.Vector3 playerSpeed;        // 0x4C
        private System.Boolean m_isAcceleratingLastFrame;        // 0x58
        public System.Boolean isLastFrameInvalid;        // 0x59
        public System.Single maxLegLength;        // 0x5C
        public System.Single maxFeetOffset;        // 0x60
        public System.Single minPelvisHeight;        // 0x64
        public UnityEngine.LayerMask layers;        // 0x68
        public System.Single maxStep;        // 0x6C
        public System.Single heightOffset;        // 0x70
        public System.Single footSpeed;        // 0x74
        public System.Single footRadius;        // 0x78
        public System.Single footCenterOffset;        // 0x7C
        public System.Single prediction;        // 0x80
        public System.Single footRotationWeight;        // 0x84
        public System.Single footRotationSpeed;        // 0x88
        public System.Single maxFootRotationAngleFore;        // 0x8C
        public System.Single maxFootRotationAngleBack;        // 0x90
        public System.Single maxFootRotationAngleIn;        // 0x94
        public System.Single maxFootRotationAngleOut;        // 0x98
        public System.Boolean rotateSolver;        // 0x9C
        public System.Single pelvisSpeed;        // 0xA0
        public System.Single pelvisSpeedXZ;        // 0xA4
        public System.Single pelvisDamper;        // 0xA8
        public System.Single lowerPelvisWeight;        // 0xAC
        public System.Single liftPelvisWeight;        // 0xB0
        public System.Single rootSphereCastRadius;        // 0xB4
        public System.Boolean overstepFallsDown;        // 0xB8
        public RootMotion.FinalIK.Grounding.Quality quality;        // 0xBC
        private RootMotion.BipedReferences <references>k__BackingField;        // 0xC0
        private RootMotion.FinalIK.Grounding.Leg[] <legs>k__BackingField;        // 0xC8
        private RootMotion.FinalIK.Grounding.Pelvis <pelvis>k__BackingField;        // 0xD0
        private System.Boolean <isGrounded>k__BackingField;        // 0xD8
        private UnityEngine.Transform <root>k__BackingField;        // 0xE0
        private UnityEngine.RaycastHit <rootHit>k__BackingField;        // 0xE8
        public RootMotion.FinalIK.Grounding.OnRaycastDelegate Raycast;        // 0x128
        public RootMotion.FinalIK.Grounding.OnCapsuleCastDelegate CapsuleCast;        // 0x130
        public RootMotion.FinalIK.Grounding.OnSphereCastDelegate SphereCast;        // 0x138
        private UnityEngine.Transform <entityTransform>k__BackingField;        // 0x140
        private System.Boolean <entityIsOnMovableBase>k__BackingField;        // 0x148
        private UnityEngine.Vector3 <entityRelativePosition>k__BackingField;        // 0x14C
        private UnityEngine.Quaternion <entityRelativeRotation>k__BackingField;        // 0x158
        private System.Boolean lastIsDependingLeftLeg;        // 0x168
        private System.Boolean isSameLegWithLastFrame;        // 0x169
        private System.Single rootDeltaAngle;        // 0x16C
        private System.Single pelvisForwardOffset;        // 0x170
        private UnityEngine.Vector3 m_lastFrameForwardVec;        // 0x174
        private System.Boolean lastIsUsingLoswest;        // 0x180
        private System.Single m_actualMaxFootOffset;        // 0x184
        public System.Single forwardFeetOffset;        // 0x188
        public System.Boolean isUsingLoswest;        // 0x18C
        public System.Boolean isDependingLeftLeg;        // 0x18D
        private System.Boolean initiated;        // 0x18E

        // Methods
        private System.Void _UpdateFloorPredictTheta() { }
        private System.Void _UpdateFloorFeetThetaByFoot() { }
        private System.Void _UpdateFloorFeetThetaByRoot() { }
        private RootMotion.BipedReferences get_references() { }
        private System.Void set_references(RootMotion.BipedReferences value) { }
        private RootMotion.FinalIK.Grounding.Leg[] get_legs() { }
        private System.Void set_legs(RootMotion.FinalIK.Grounding.Leg[] value) { }
        private RootMotion.FinalIK.Grounding.Pelvis get_pelvis() { }
        private System.Void set_pelvis(RootMotion.FinalIK.Grounding.Pelvis value) { }
        private System.Boolean get_isGrounded() { }
        private System.Void set_isGrounded(System.Boolean value) { }
        private UnityEngine.Transform get_root() { }
        private System.Void set_root(UnityEngine.Transform value) { }
        private UnityEngine.RaycastHit get_rootHit() { }
        private System.Void set_rootHit(UnityEngine.RaycastHit value) { }
        private System.Boolean get_rootGrounded() { }
        private UnityEngine.Transform get_entityTransform() { }
        private System.Void set_entityTransform(UnityEngine.Transform value) { }
        private System.Boolean get_entityIsOnMovableBase() { }
        private System.Void set_entityIsOnMovableBase(System.Boolean value) { }
        private UnityEngine.Vector3 get_entityRelativePosition() { }
        private System.Void set_entityRelativePosition(UnityEngine.Vector3 value) { }
        private UnityEngine.Quaternion get_entityRelativeRotation() { }
        private System.Void set_entityRelativeRotation(UnityEngine.Quaternion value) { }
        private UnityEngine.RaycastHit GetRootHit(System.Single maxDistanceMlp) { }
        private System.Boolean IsValid(System.String& errorMessage) { }
        private System.Void Initiate(UnityEngine.Transform root, UnityEngine.Transform[] feet, RootMotion.BipedReferences references) { }
        private System.Void Update() { }
        private UnityEngine.Vector3 GetLegsPlaneNormal() { }
        private System.Void Reset() { }
        private System.Void LogWarning(System.String message) { }
        private UnityEngine.Vector3 get_up() { }
        private UnityEngine.Vector3 get_forward() { }
        private System.Single GetVerticalOffset(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2) { }
        private UnityEngine.Vector3 Flatten(UnityEngine.Vector3 v) { }
        private System.Boolean get_useRootRotation() { }
        private UnityEngine.Vector3 GetFootCenterOffset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004B
    public class AimIK : IK
    {
        // Fields
        public RootMotion.FinalIK.IKSolverAim solver;        // 0x38

        // Methods
        private System.Void OpenUserManual() { }
        private System.Void OpenScriptReference() { }
        private System.Void OpenSetupTutorial() { }
        private System.Void SupportGroup() { }
        private System.Void ASThread() { }
        private RootMotion.FinalIK.IKSolver GetIKSolver() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004C
    public class ArmIK : IK
    {
        // Fields
        public RootMotion.FinalIK.IKSolverArm solver;        // 0x38

        // Methods
        private System.Void OpenUserManual() { }
        private System.Void OpenScriptReference() { }
        private System.Void SupportGroup() { }
        private System.Void ASThread() { }
        private RootMotion.FinalIK.IKSolver GetIKSolver() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004D
    public class CCDIK : IK
    {
        // Fields
        public RootMotion.FinalIK.IKSolverCCD solver;        // 0x38

        // Methods
        private System.Void OpenUserManual() { }
        private System.Void OpenScriptReference() { }
        private System.Void SupportGroup() { }
        private System.Void ASThread() { }
        private RootMotion.FinalIK.IKSolver GetIKSolver() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004E
    public class FABRIK : IK
    {
        // Fields
        public RootMotion.FinalIK.IKSolverFABRIK solver;        // 0x38

        // Methods
        private System.Void OpenUserManual() { }
        private System.Void OpenScriptReference() { }
        private System.Void SupportGroup() { }
        private System.Void ASThread() { }
        private RootMotion.FinalIK.IKSolver GetIKSolver() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004F
    public class FABRIKRoot : IK
    {
        // Fields
        public RootMotion.FinalIK.IKSolverFABRIKRoot solver;        // 0x38

        // Methods
        private System.Void OpenUserManual() { }
        private System.Void OpenScriptReference() { }
        private System.Void SupportGroup() { }
        private System.Void ASThread() { }
        private RootMotion.FinalIK.IKSolver GetIKSolver() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000050
    public class FullBodyBipedIK : IK
    {
        // Fields
        public RootMotion.BipedReferences references;        // 0x38
        public RootMotion.FinalIK.IKSolverFullBodyBiped solver;        // 0x40

        // Methods
        private System.Void OpenUserManual() { }
        private System.Void OpenScriptReference() { }
        private System.Void OpenSetupTutorial() { }
        private System.Void OpenInspectorTutorial() { }
        private System.Void SupportGroup() { }
        private System.Void ASThread() { }
        private System.Void SetReferences(RootMotion.BipedReferences references, UnityEngine.Transform rootNode) { }
        private RootMotion.FinalIK.IKSolver GetIKSolver() { }
        private System.Boolean ReferencesError(System.String& errorMessage) { }
        private System.Boolean ReferencesWarning(System.String& warningMessage) { }
        private System.Void Reinitiate() { }
        private System.Void AutoDetectReferences() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000051
    public class IK : SolverManager
    {
        // Methods
        private RootMotion.FinalIK.IKSolver GetIKSolver() { }
        private System.Void UpdateSolver() { }
        private System.Void InitiateSolver() { }
        private System.Void FixTransforms() { }
        private System.Void OpenUserManual() { }
        private System.Void OpenScriptReference() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000052
    public class IKExecutionOrder : MonoBehaviour
    {
        // Fields
        public RootMotion.FinalIK.IK[] IKComponents;        // 0x18
        public UnityEngine.Animator animator;        // 0x20
        private System.Boolean fixedFrame;        // 0x28

        // Methods
        private System.Boolean get_animatePhysics() { }
        private System.Void Start() { }
        private System.Void Update() { }
        private System.Void FixedUpdate() { }
        private System.Void LateUpdate() { }
        private System.Void FixTransforms() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000053
    public class LegIK : IK
    {
        // Fields
        public RootMotion.FinalIK.IKSolverLeg solver;        // 0x38

        // Methods
        private System.Void OpenUserManual() { }
        private System.Void OpenScriptReference() { }
        private System.Void SupportGroup() { }
        private System.Void ASThread() { }
        private RootMotion.FinalIK.IKSolver GetIKSolver() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000054
    public class LimbIK : IK
    {
        // Fields
        public RootMotion.FinalIK.IKSolverLimb solver;        // 0x38

        // Methods
        private System.Void OpenUserManual() { }
        private System.Void OpenScriptReference() { }
        private System.Void SupportGroup() { }
        private System.Void ASThread() { }
        private RootMotion.FinalIK.IKSolver GetIKSolver() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000055
    public class LookAtIK : IK
    {
        // Fields
        public RootMotion.FinalIK.IKSolverLookAt solver;        // 0x38

        // Methods
        private System.Void OpenUserManual() { }
        private System.Void OpenScriptReference() { }
        private System.Void SupportGroup() { }
        private System.Void ASThread() { }
        private RootMotion.FinalIK.IKSolver GetIKSolver() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000056
    public class TrigonometricIK : IK
    {
        // Fields
        public RootMotion.FinalIK.IKSolverTrigonometric solver;        // 0x38

        // Methods
        private System.Void OpenUserManual() { }
        private System.Void OpenScriptReference() { }
        private System.Void SupportGroup() { }
        private System.Void ASThread() { }
        private RootMotion.FinalIK.IKSolver GetIKSolver() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000057
    public class VRIK : IK
    {
        // Fields
        public RootMotion.FinalIK.VRIK.References references;        // 0x38
        public RootMotion.FinalIK.IKSolverVR solver;        // 0x40

        // Methods
        private System.Void OpenUserManual() { }
        private System.Void OpenScriptReference() { }
        private System.Void OpenSetupTutorial() { }
        private System.Void AutoDetectReferences() { }
        private System.Void GuessHandOrientations() { }
        private RootMotion.FinalIK.IKSolver GetIKSolver() { }
        private System.Void InitiateSolver() { }
        private System.Void UpdateSolver() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000059
    public class FABRIKChain
    {
        // Fields
        public RootMotion.FinalIK.FABRIK ik;        // 0x10
        public System.Single pull;        // 0x18
        public System.Single pin;        // 0x1C
        public System.Int32[] children;        // 0x20

        // Methods
        private System.Boolean IsValid(System.String& message) { }
        private System.Void Initiate() { }
        private System.Void Stage1(RootMotion.FinalIK.FABRIKChain[] chain) { }
        private System.Void Stage2(UnityEngine.Vector3 rootPosition, RootMotion.FinalIK.FABRIKChain[] chain) { }
        private UnityEngine.Vector3 GetCentroid(RootMotion.FinalIK.FABRIKChain[] chain) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005A
    public class FBBIKArmBending : MonoBehaviour
    {
        // Fields
        public RootMotion.FinalIK.FullBodyBipedIK ik;        // 0x18
        public UnityEngine.Vector3 bendDirectionOffsetLeft;        // 0x20
        public UnityEngine.Vector3 bendDirectionOffsetRight;        // 0x2C
        public UnityEngine.Vector3 characterSpaceBendOffsetLeft;        // 0x38
        public UnityEngine.Vector3 characterSpaceBendOffsetRight;        // 0x44
        private UnityEngine.Quaternion leftHandTargetRotation;        // 0x50
        private UnityEngine.Quaternion rightHandTargetRotation;        // 0x60
        private System.Boolean initiated;        // 0x70

        // Methods
        private System.Void LateUpdate() { }
        private System.Void OnPostFBBIK() { }
        private System.Void OnDestroy() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005B
    public class FBBIKHeadEffector : MonoBehaviour
    {
        // Fields
        public RootMotion.FinalIK.FullBodyBipedIK ik;        // 0x18
        public System.Single positionWeight;        // 0x20
        public System.Single bodyWeight;        // 0x24
        public System.Single thighWeight;        // 0x28
        public System.Boolean handsPullBody;        // 0x2C
        public System.Single rotationWeight;        // 0x30
        public System.Single bodyClampWeight;        // 0x34
        public System.Single headClampWeight;        // 0x38
        public System.Single bendWeight;        // 0x3C
        public RootMotion.FinalIK.FBBIKHeadEffector.BendBone[] bendBones;        // 0x40
        public System.Single CCDWeight;        // 0x48
        public System.Single roll;        // 0x4C
        public System.Single damper;        // 0x50
        public UnityEngine.Transform[] CCDBones;        // 0x58
        public System.Single postStretchWeight;        // 0x60
        public System.Single maxStretch;        // 0x64
        public System.Single stretchDamper;        // 0x68
        public System.Boolean fixHead;        // 0x6C
        public UnityEngine.Transform[] stretchBones;        // 0x70
        public UnityEngine.Vector3 chestDirection;        // 0x78
        public System.Single chestDirectionWeight;        // 0x84
        public UnityEngine.Transform[] chestBones;        // 0x88
        public RootMotion.FinalIK.IKSolver.UpdateDelegate OnPostHeadEffectorFK;        // 0x90
        private UnityEngine.Vector3 offset;        // 0x98
        private UnityEngine.Vector3 headToBody;        // 0xA4
        private UnityEngine.Vector3 shoulderCenterToHead;        // 0xB0
        private UnityEngine.Vector3 headToLeftThigh;        // 0xBC
        private UnityEngine.Vector3 headToRightThigh;        // 0xC8
        private UnityEngine.Vector3 leftShoulderPos;        // 0xD4
        private UnityEngine.Vector3 rightShoulderPos;        // 0xE0
        private System.Single shoulderDist;        // 0xEC
        private System.Single leftShoulderDist;        // 0xF0
        private System.Single rightShoulderDist;        // 0xF4
        private UnityEngine.Quaternion chestRotation;        // 0xF8
        private UnityEngine.Quaternion headRotationRelativeToRoot;        // 0x108
        private UnityEngine.Quaternion[] ccdDefaultLocalRotations;        // 0x118
        private UnityEngine.Vector3 headLocalPosition;        // 0x120
        private UnityEngine.Quaternion headLocalRotation;        // 0x12C
        private UnityEngine.Vector3[] stretchLocalPositions;        // 0x140
        private UnityEngine.Quaternion[] stretchLocalRotations;        // 0x148
        private UnityEngine.Vector3[] chestLocalPositions;        // 0x150
        private UnityEngine.Quaternion[] chestLocalRotations;        // 0x158
        private System.Int32 bendBonesCount;        // 0x160
        private System.Int32 ccdBonesCount;        // 0x164
        private System.Int32 stretchBonesCount;        // 0x168
        private System.Int32 chestBonesCount;        // 0x16C

        // Methods
        private System.Void Start() { }
        private System.Void OnStoreDefaultLocalState() { }
        private System.Void OnFixTransforms() { }
        private System.Void OnPreRead() { }
        private System.Void SpineBend() { }
        private System.Void CCDPass() { }
        private System.Void Iterate(System.Int32 iteration) { }
        private System.Void OnPostUpdate() { }
        private System.Void ChestDirection() { }
        private System.Void PostStretching() { }
        private System.Void LerpSolverPosition(RootMotion.FinalIK.IKEffector effector, UnityEngine.Vector3 position, System.Single weight, UnityEngine.Vector3 offset) { }
        private System.Void Solve(UnityEngine.Vector3& pos1, UnityEngine.Vector3& pos2, System.Single nominalDistance) { }
        private System.Void OnDestroy() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005D
    public class FBIKChain
    {
        // Fields
        public System.Single pin;        // 0x10
        public System.Single pull;        // 0x14
        public System.Single push;        // 0x18
        public System.Single pushParent;        // 0x1C
        public System.Single reach;        // 0x20
        public RootMotion.FinalIK.FBIKChain.Smoothing reachSmoothing;        // 0x24
        public RootMotion.FinalIK.FBIKChain.Smoothing pushSmoothing;        // 0x28
        public RootMotion.FinalIK.IKSolver.Node[] nodes;        // 0x30
        public System.Int32[] children;        // 0x38
        public RootMotion.FinalIK.FBIKChain.ChildConstraint[] childConstraints;        // 0x40
        public RootMotion.FinalIK.IKConstraintBend bendConstraint;        // 0x48
        private System.Single rootLength;        // 0x50
        private System.Boolean initiated;        // 0x54
        private System.Single length;        // 0x58
        private System.Single distance;        // 0x5C
        private RootMotion.FinalIK.IKSolver.Point p;        // 0x60
        private System.Single reachForce;        // 0x68
        private System.Single pullParentSum;        // 0x6C
        private System.Single[] crossFades;        // 0x70
        private System.Single sqrMag1;        // 0x78
        private System.Single sqrMag2;        // 0x7C
        private System.Single sqrMagDif;        // 0x80
        private static System.Single maxLimbLength;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Single pin, System.Single pull, UnityEngine.Transform[] nodeTransforms) { }
        private System.Void SetNodes(UnityEngine.Transform[] boneTransforms) { }
        private System.Int32 GetNodeIndex(UnityEngine.Transform boneTransform) { }
        private System.Boolean IsValid(System.String& message) { }
        private System.Void Initiate(RootMotion.FinalIK.IKSolverFullBody solver) { }
        private System.Void ReadPose(RootMotion.FinalIK.IKSolverFullBody solver, System.Boolean fullBody) { }
        private System.Void CalculateBoneLengths(RootMotion.FinalIK.IKSolverFullBody solver) { }
        private System.Void Reach(RootMotion.FinalIK.IKSolverFullBody solver) { }
        private UnityEngine.Vector3 Push(RootMotion.FinalIK.IKSolverFullBody solver) { }
        private System.Void SolveTrigonometric(RootMotion.FinalIK.IKSolverFullBody solver, System.Boolean calculateBendDirection) { }
        private System.Void Stage1(RootMotion.FinalIK.IKSolverFullBody solver) { }
        private System.Void Stage2(RootMotion.FinalIK.IKSolverFullBody solver, UnityEngine.Vector3 position) { }
        private System.Void SolveConstraintSystems(RootMotion.FinalIK.IKSolverFullBody solver) { }
        private UnityEngine.Vector3 SolveFABRIKJoint(UnityEngine.Vector3 pos1, UnityEngine.Vector3 pos2, System.Single length) { }
        private UnityEngine.Vector3 GetDirToBendPoint(UnityEngine.Vector3 direction, UnityEngine.Vector3 bendDirection, System.Single directionMagnitude) { }
        private System.Void SolveChildConstraints(RootMotion.FinalIK.IKSolverFullBody solver) { }
        private System.Void SolveLinearConstraint(RootMotion.FinalIK.IKSolver.Node node1, RootMotion.FinalIK.IKSolver.Node node2, System.Single crossFade, System.Single distance) { }
        private System.Void ForwardReach(UnityEngine.Vector3 position) { }
        private System.Void BackwardReach(UnityEngine.Vector3 position) { }

    }

    // TypeToken: 0x2000060
    public class IKConstraintBend
    {
        // Fields
        public UnityEngine.Transform bone1;        // 0x10
        public UnityEngine.Transform bone2;        // 0x18
        public UnityEngine.Transform bone3;        // 0x20
        public UnityEngine.Transform bendGoal;        // 0x28
        public UnityEngine.Vector3 direction;        // 0x30
        public UnityEngine.Quaternion rotationOffset;        // 0x3C
        public System.Single weight;        // 0x4C
        public UnityEngine.Vector3 defaultLocalDirection;        // 0x50
        public UnityEngine.Vector3 defaultChildDirection;        // 0x5C
        public System.Single clampF;        // 0x68
        private System.Int32 chainIndex1;        // 0x6C
        private System.Int32 nodeIndex1;        // 0x70
        private System.Int32 chainIndex2;        // 0x74
        private System.Int32 nodeIndex2;        // 0x78
        private System.Int32 chainIndex3;        // 0x7C
        private System.Int32 nodeIndex3;        // 0x80
        private System.Boolean <initiated>k__BackingField;        // 0x84
        private System.Boolean limbOrientationsSet;        // 0x85

        // Methods
        private System.Boolean IsValid(RootMotion.FinalIK.IKSolverFullBody solver, RootMotion.Warning.Logger logger) { }
        private System.Boolean get_initiated() { }
        private System.Void set_initiated(System.Boolean value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.Transform bone1, UnityEngine.Transform bone2, UnityEngine.Transform bone3) { }
        private System.Void SetBones(UnityEngine.Transform bone1, UnityEngine.Transform bone2, UnityEngine.Transform bone3) { }
        private System.Void Initiate(RootMotion.FinalIK.IKSolverFullBody solver) { }
        private System.Void SetLimbOrientation(UnityEngine.Vector3 upper, UnityEngine.Vector3 lower, UnityEngine.Vector3 last) { }
        private System.Void LimitBend(System.Single solverWeight, System.Single positionWeight) { }
        private UnityEngine.Vector3 GetDir(RootMotion.FinalIK.IKSolverFullBody solver) { }
        private UnityEngine.Vector3 OrthoToLimb(RootMotion.FinalIK.IKSolverFullBody solver, UnityEngine.Vector3 tangent) { }
        private UnityEngine.Vector3 OrthoToBone1(RootMotion.FinalIK.IKSolverFullBody solver, UnityEngine.Vector3 tangent) { }

    }

    // TypeToken: 0x2000061
    public class IKEffector
    {
        // Fields
        public UnityEngine.Transform bone;        // 0x10
        public UnityEngine.Transform target;        // 0x18
        public System.Single positionWeight;        // 0x20
        public System.Single rotationWeight;        // 0x24
        public UnityEngine.Vector3 position;        // 0x28
        public UnityEngine.Quaternion rotation;        // 0x34
        public UnityEngine.Vector3 positionOffset;        // 0x44
        private System.Boolean <isEndEffector>k__BackingField;        // 0x50
        public System.Boolean effectChildNodes;        // 0x51
        public System.Single maintainRelativePositionWeight;        // 0x54
        public UnityEngine.Transform[] childBones;        // 0x58
        public UnityEngine.Transform planeBone1;        // 0x60
        public UnityEngine.Transform planeBone2;        // 0x68
        public UnityEngine.Transform planeBone3;        // 0x70
        public UnityEngine.Quaternion planeRotationOffset;        // 0x78
        private System.Single posW;        // 0x88
        private System.Single rotW;        // 0x8C
        private UnityEngine.Vector3[] localPositions;        // 0x90
        private System.Boolean usePlaneNodes;        // 0x98
        private UnityEngine.Quaternion animatedPlaneRotation;        // 0x9C
        private UnityEngine.Vector3 animatedPosition;        // 0xAC
        private System.Boolean firstUpdate;        // 0xB8
        private System.Int32 chainIndex;        // 0xBC
        private System.Int32 nodeIndex;        // 0xC0
        private System.Int32 plane1ChainIndex;        // 0xC4
        private System.Int32 plane1NodeIndex;        // 0xC8
        private System.Int32 plane2ChainIndex;        // 0xCC
        private System.Int32 plane2NodeIndex;        // 0xD0
        private System.Int32 plane3ChainIndex;        // 0xD4
        private System.Int32 plane3NodeIndex;        // 0xD8
        private System.Int32[] childChainIndexes;        // 0xE0
        private System.Int32[] childNodeIndexes;        // 0xE8

        // Methods
        private RootMotion.FinalIK.IKSolver.Node GetNode(RootMotion.FinalIK.IKSolverFullBody solver) { }
        private System.Boolean get_isEndEffector() { }
        private System.Void set_isEndEffector(System.Boolean value) { }
        private System.Void PinToBone(System.Single positionWeight, System.Single rotationWeight) { }
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.Transform bone, UnityEngine.Transform[] childBones) { }
        private System.Boolean IsValid(RootMotion.FinalIK.IKSolver solver, System.String& message) { }
        private System.Void Initiate(RootMotion.FinalIK.IKSolverFullBody solver) { }
        private System.Void ResetOffset(RootMotion.FinalIK.IKSolverFullBody solver) { }
        private System.Void SetToTarget() { }
        private System.Void OnPreSolve(RootMotion.FinalIK.IKSolverFullBody solver) { }
        private System.Void OnPostWrite() { }
        private UnityEngine.Quaternion GetPlaneRotation(RootMotion.FinalIK.IKSolverFullBody solver) { }
        private System.Void Update(RootMotion.FinalIK.IKSolverFullBody solver) { }
        private UnityEngine.Vector3 GetPosition(RootMotion.FinalIK.IKSolverFullBody solver, UnityEngine.Quaternion& planeRotationOffset) { }

    }

    // TypeToken: 0x2000062
    public class IKMapping
    {
        // Methods
        private System.Boolean IsValid(RootMotion.FinalIK.IKSolver solver, System.String& message) { }
        private System.Void Initiate(RootMotion.FinalIK.IKSolverFullBody solver) { }
        private System.Boolean BoneIsValid(UnityEngine.Transform bone, RootMotion.FinalIK.IKSolver solver, System.String& message, RootMotion.Warning.Logger logger) { }
        private UnityEngine.Vector3 SolveFABRIKJoint(UnityEngine.Vector3 pos1, UnityEngine.Vector3 pos2, System.Single length) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000064
    public class IKMappingBone : IKMapping
    {
        // Fields
        public UnityEngine.Transform bone;        // 0x10
        public System.Single maintainRotationWeight;        // 0x18
        private RootMotion.FinalIK.IKMapping.BoneMap boneMap;        // 0x20

        // Methods
        private System.Boolean IsValid(RootMotion.FinalIK.IKSolver solver, System.String& message) { }
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.Transform bone) { }
        private System.Void StoreDefaultLocalState() { }
        private System.Void FixTransforms() { }
        private System.Void Initiate(RootMotion.FinalIK.IKSolverFullBody solver) { }
        private System.Void ReadPose() { }
        private System.Void WritePose(System.Single solverWeight) { }

    }

    // TypeToken: 0x2000065
    public class IKMappingLimb : IKMapping
    {
        // Fields
        public UnityEngine.Transform parentBone;        // 0x10
        public UnityEngine.Transform bone1;        // 0x18
        public UnityEngine.Transform bone2;        // 0x20
        public UnityEngine.Transform bone3;        // 0x28
        public System.Single maintainRotationWeight;        // 0x30
        public System.Single weight;        // 0x34
        public System.Boolean updatePlaneRotations;        // 0x38
        private RootMotion.FinalIK.IKMapping.BoneMap boneMapParent;        // 0x40
        private RootMotion.FinalIK.IKMapping.BoneMap boneMap1;        // 0x48
        private RootMotion.FinalIK.IKMapping.BoneMap boneMap2;        // 0x50
        private RootMotion.FinalIK.IKMapping.BoneMap boneMap3;        // 0x58

        // Methods
        private System.Boolean IsValid(RootMotion.FinalIK.IKSolver solver, System.String& message) { }
        private RootMotion.FinalIK.IKMapping.BoneMap GetBoneMap(RootMotion.FinalIK.IKMappingLimb.BoneMapType boneMap) { }
        private System.Void SetLimbOrientation(UnityEngine.Vector3 upper, UnityEngine.Vector3 lower) { }
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.Transform bone1, UnityEngine.Transform bone2, UnityEngine.Transform bone3, UnityEngine.Transform parentBone) { }
        private System.Void SetBones(UnityEngine.Transform bone1, UnityEngine.Transform bone2, UnityEngine.Transform bone3, UnityEngine.Transform parentBone) { }
        private System.Void StoreDefaultLocalState() { }
        private System.Void FixTransforms() { }
        private System.Void Initiate(RootMotion.FinalIK.IKSolverFullBody solver) { }
        private System.Void ReadPose() { }
        private System.Void WritePose(RootMotion.FinalIK.IKSolverFullBody solver, System.Boolean fullBody) { }

    }

    // TypeToken: 0x2000067
    public class IKMappingSpine : IKMapping
    {
        // Fields
        public UnityEngine.Transform[] spineBones;        // 0x10
        public UnityEngine.Transform leftUpperArmBone;        // 0x18
        public UnityEngine.Transform rightUpperArmBone;        // 0x20
        public UnityEngine.Transform leftThighBone;        // 0x28
        public UnityEngine.Transform rightThighBone;        // 0x30
        public System.Int32 iterations;        // 0x38
        public System.Single twistWeight;        // 0x3C
        private System.Int32 rootNodeIndex;        // 0x40
        private RootMotion.FinalIK.IKMapping.BoneMap[] spine;        // 0x48
        private RootMotion.FinalIK.IKMapping.BoneMap leftUpperArm;        // 0x50
        private RootMotion.FinalIK.IKMapping.BoneMap rightUpperArm;        // 0x58
        private RootMotion.FinalIK.IKMapping.BoneMap leftThigh;        // 0x60
        private RootMotion.FinalIK.IKMapping.BoneMap rightThigh;        // 0x68
        private System.Boolean useFABRIK;        // 0x70

        // Methods
        private System.Boolean IsValid(RootMotion.FinalIK.IKSolver solver, System.String& message) { }
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.Transform[] spineBones, UnityEngine.Transform leftUpperArmBone, UnityEngine.Transform rightUpperArmBone, UnityEngine.Transform leftThighBone, UnityEngine.Transform rightThighBone) { }
        private System.Void SetBones(UnityEngine.Transform[] spineBones, UnityEngine.Transform leftUpperArmBone, UnityEngine.Transform rightUpperArmBone, UnityEngine.Transform leftThighBone, UnityEngine.Transform rightThighBone) { }
        private System.Void StoreDefaultLocalState() { }
        private System.Void FixTransforms() { }
        private System.Void Initiate(RootMotion.FinalIK.IKSolverFullBody solver) { }
        private System.Boolean UseFABRIK() { }
        private System.Void ReadPose() { }
        private System.Void WritePose(RootMotion.FinalIK.IKSolverFullBody solver) { }
        private System.Void ForwardReach(UnityEngine.Vector3 position) { }
        private System.Void BackwardReach(UnityEngine.Vector3 position) { }
        private System.Void MapToSolverPositions(RootMotion.FinalIK.IKSolverFullBody solver) { }

    }

    // TypeToken: 0x2000068
    public class IKSolver
    {
        // Fields
        public System.Boolean executedInEditor;        // 0x10
        public UnityEngine.Vector3 IKPosition;        // 0x14
        public System.Single IKPositionWeight;        // 0x20
        private System.Boolean <initiated>k__BackingField;        // 0x24
        public RootMotion.FinalIK.IKSolver.UpdateDelegate OnPreInitiate;        // 0x28
        public RootMotion.FinalIK.IKSolver.UpdateDelegate OnPostInitiate;        // 0x30
        public RootMotion.FinalIK.IKSolver.UpdateDelegate OnPreUpdate;        // 0x38
        public RootMotion.FinalIK.IKSolver.UpdateDelegate OnPostUpdate;        // 0x40
        protected System.Boolean firstInitiation;        // 0x48
        protected UnityEngine.Transform root;        // 0x50

        // Methods
        private System.Boolean IsValid() { }
        private System.Boolean IsValid(System.String& message) { }
        private System.Void Initiate(UnityEngine.Transform root) { }
        private System.Void Update() { }
        private UnityEngine.Vector3 GetIKPosition() { }
        private System.Void SetIKPosition(UnityEngine.Vector3 position) { }
        private System.Single GetIKPositionWeight() { }
        private System.Void SetIKPositionWeight(System.Single weight) { }
        private UnityEngine.Transform GetRoot() { }
        private System.Boolean get_initiated() { }
        private System.Void set_initiated(System.Boolean value) { }
        private RootMotion.FinalIK.IKSolver.Point[] GetPoints() { }
        private RootMotion.FinalIK.IKSolver.Point GetPoint(UnityEngine.Transform transform) { }
        private System.Void FixTransforms() { }
        private System.Void StoreDefaultLocalState() { }
        private System.Void OnInitiate() { }
        private System.Void OnUpdate() { }
        private System.Void LogWarning(System.String message) { }
        private UnityEngine.Transform ContainsDuplicateBone(RootMotion.FinalIK.IKSolver.Bone[] bones) { }
        private System.Boolean HierarchyIsValid(RootMotion.FinalIK.IKSolver.Bone[] bones) { }
        private System.Single PreSolveBones(RootMotion.FinalIK.IKSolver.Bone[]& bones) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006E
    public class IKSolverAim : IKSolverHeuristic
    {
        // Fields
        public UnityEngine.Transform transform;        // 0x88
        public UnityEngine.Vector3 axis;        // 0x90
        public UnityEngine.Vector3 poleAxis;        // 0x9C
        public UnityEngine.Vector3 polePosition;        // 0xA8
        public System.Single poleWeight;        // 0xB4
        public UnityEngine.Transform poleTarget;        // 0xB8
        public System.Single clampWeight;        // 0xC0
        public System.Int32 clampSmoothing;        // 0xC4
        public RootMotion.FinalIK.IKSolver.IterationDelegate OnPreIteration;        // 0xC8
        private System.Single step;        // 0xD0
        private UnityEngine.Vector3 clampedIKPosition;        // 0xD4
        private RootMotion.FinalIK.RotationLimit transformLimit;        // 0xE0
        private UnityEngine.Transform lastTransform;        // 0xE8

        // Methods
        private System.Single GetAngle() { }
        private UnityEngine.Vector3 get_transformAxis() { }
        private UnityEngine.Vector3 get_transformPoleAxis() { }
        private System.Void OnInitiate() { }
        private System.Void OnUpdate() { }
        private System.Int32 get_minBones() { }
        private System.Void Solve() { }
        private UnityEngine.Vector3 GetClampedIKPosition() { }
        private System.Void RotateToTarget(UnityEngine.Vector3 targetPosition, RootMotion.FinalIK.IKSolver.Bone bone, System.Single weight) { }
        private UnityEngine.Vector3 get_localDirection() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006F
    public class IKSolverArm : IKSolver
    {
        // Fields
        public System.Single IKRotationWeight;        // 0x58
        public UnityEngine.Quaternion IKRotation;        // 0x5C
        public RootMotion.FinalIK.IKSolver.Point chest;        // 0x70
        public RootMotion.FinalIK.IKSolver.Point shoulder;        // 0x78
        public RootMotion.FinalIK.IKSolver.Point upperArm;        // 0x80
        public RootMotion.FinalIK.IKSolver.Point forearm;        // 0x88
        public RootMotion.FinalIK.IKSolver.Point hand;        // 0x90
        public System.Boolean isLeft;        // 0x98
        public RootMotion.FinalIK.IKSolverVR.Arm arm;        // 0xA0
        private UnityEngine.Vector3[] positions;        // 0xA8
        private UnityEngine.Quaternion[] rotations;        // 0xB0

        // Methods
        private System.Boolean IsValid(System.String& message) { }
        private System.Boolean SetChain(UnityEngine.Transform chest, UnityEngine.Transform shoulder, UnityEngine.Transform upperArm, UnityEngine.Transform forearm, UnityEngine.Transform hand, UnityEngine.Transform root) { }
        private RootMotion.FinalIK.IKSolver.Point[] GetPoints() { }
        private RootMotion.FinalIK.IKSolver.Point GetPoint(UnityEngine.Transform transform) { }
        private System.Void StoreDefaultLocalState() { }
        private System.Void FixTransforms() { }
        private System.Void OnInitiate() { }
        private System.Void OnUpdate() { }
        private System.Void Solve() { }
        private System.Void Read() { }
        private System.Void Write() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000070
    public class IKSolverCCD : IKSolverHeuristic
    {
        // Fields
        public RootMotion.FinalIK.IKSolver.IterationDelegate OnPreIteration;        // 0x88

        // Methods
        private System.Void FadeOutBoneWeights() { }
        private System.Void OnInitiate() { }
        private System.Void OnUpdate() { }
        private System.Void Solve(UnityEngine.Vector3 targetPosition) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000071
    public class IKSolverFABRIK : IKSolverHeuristic
    {
        // Fields
        public RootMotion.FinalIK.IKSolver.IterationDelegate OnPreIteration;        // 0x88
        private System.Boolean[] limitedBones;        // 0x90
        private UnityEngine.Vector3[] solverLocalPositions;        // 0x98

        // Methods
        private System.Void SolveForward(UnityEngine.Vector3 position) { }
        private System.Void SolveBackward(UnityEngine.Vector3 position) { }
        private UnityEngine.Vector3 GetIKPosition() { }
        private System.Void OnInitiate() { }
        private System.Void OnUpdate() { }
        private System.Boolean get_boneLengthCanBeZero() { }
        private UnityEngine.Vector3 SolveJoint(UnityEngine.Vector3 pos1, UnityEngine.Vector3 pos2, System.Single length) { }
        private System.Void OnPreSolve() { }
        private System.Void OnPostSolve() { }
        private System.Void Solve(UnityEngine.Vector3 targetPosition) { }
        private System.Void ForwardReach(UnityEngine.Vector3 position) { }
        private System.Void SolverMove(System.Int32 index, UnityEngine.Vector3 offset) { }
        private System.Void SolverRotate(System.Int32 index, UnityEngine.Quaternion rotation, System.Boolean recursive) { }
        private System.Void SolverRotateChildren(System.Int32 index, UnityEngine.Quaternion rotation) { }
        private System.Void SolverMoveChildrenAroundPoint(System.Int32 index, UnityEngine.Quaternion rotation) { }
        private UnityEngine.Quaternion GetParentSolverRotation(System.Int32 index) { }
        private UnityEngine.Vector3 GetParentSolverPosition(System.Int32 index) { }
        private UnityEngine.Quaternion GetLimitedRotation(System.Int32 index, UnityEngine.Quaternion q, System.Boolean& changed) { }
        private System.Void LimitForward(System.Int32 rotateBone, System.Int32 limitBone) { }
        private System.Void BackwardReach(UnityEngine.Vector3 position) { }
        private System.Void BackwardReachUnlimited(UnityEngine.Vector3 position) { }
        private System.Void BackwardReachLimited(UnityEngine.Vector3 position) { }
        private System.Void MapToSolverPositions() { }
        private System.Void MapToSolverPositionsLimited() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000072
    public class IKSolverFABRIKRoot : IKSolver
    {
        // Fields
        public System.Int32 iterations;        // 0x58
        public System.Single rootPin;        // 0x5C
        public RootMotion.FinalIK.FABRIKChain[] chains;        // 0x60
        private System.Boolean zeroWeightApplied;        // 0x68
        private System.Boolean[] isRoot;        // 0x70
        private UnityEngine.Vector3 rootDefaultPosition;        // 0x78

        // Methods
        private System.Boolean IsValid(System.String& message) { }
        private System.Void StoreDefaultLocalState() { }
        private System.Void FixTransforms() { }
        private System.Void OnInitiate() { }
        private System.Boolean IsRoot(System.Int32 index) { }
        private System.Void OnUpdate() { }
        private RootMotion.FinalIK.IKSolver.Point[] GetPoints() { }
        private RootMotion.FinalIK.IKSolver.Point GetPoint(UnityEngine.Transform transform) { }
        private System.Void AddPointsToArray(RootMotion.FinalIK.IKSolver.Point[]& array, RootMotion.FinalIK.FABRIKChain chain) { }
        private UnityEngine.Vector3 GetCentroid() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000073
    public class IKSolverFullBody : IKSolver
    {
        // Fields
        public System.Int32 iterations;        // 0x58
        public RootMotion.FinalIK.FBIKChain[] chain;        // 0x60
        public RootMotion.FinalIK.IKEffector[] effectors;        // 0x68
        public RootMotion.FinalIK.IKMappingSpine spineMapping;        // 0x70
        public RootMotion.FinalIK.IKMappingBone[] boneMappings;        // 0x78
        public RootMotion.FinalIK.IKMappingLimb[] limbMappings;        // 0x80
        public System.Boolean FABRIKPass;        // 0x88
        public RootMotion.FinalIK.IKSolver.UpdateDelegate OnPreRead;        // 0x90
        public RootMotion.FinalIK.IKSolver.UpdateDelegate OnPreSolve;        // 0x98
        public RootMotion.FinalIK.IKSolver.IterationDelegate OnPreIteration;        // 0xA0
        public RootMotion.FinalIK.IKSolver.IterationDelegate OnPostIteration;        // 0xA8
        public RootMotion.FinalIK.IKSolver.UpdateDelegate OnPreBend;        // 0xB0
        public RootMotion.FinalIK.IKSolver.UpdateDelegate OnPostSolve;        // 0xB8
        public RootMotion.FinalIK.IKSolver.UpdateDelegate OnStoreDefaultLocalState;        // 0xC0
        public RootMotion.FinalIK.IKSolver.UpdateDelegate OnFixTransforms;        // 0xC8

        // Methods
        private RootMotion.FinalIK.IKEffector GetEffector(UnityEngine.Transform t) { }
        private RootMotion.FinalIK.FBIKChain GetChain(UnityEngine.Transform transform) { }
        private System.Int32 GetChainIndex(UnityEngine.Transform transform) { }
        private RootMotion.FinalIK.IKSolver.Node GetNode(System.Int32 chainIndex, System.Int32 nodeIndex) { }
        private System.Void GetChainAndNodeIndexes(UnityEngine.Transform transform, System.Int32& chainIndex, System.Int32& nodeIndex) { }
        private RootMotion.FinalIK.IKSolver.Point[] GetPoints() { }
        private RootMotion.FinalIK.IKSolver.Point GetPoint(UnityEngine.Transform transform) { }
        private System.Boolean IsValid(System.String& message) { }
        private System.Void StoreDefaultLocalState() { }
        private System.Void FixTransforms() { }
        private System.Void OnInitiate() { }
        private System.Void OnUpdate() { }
        private System.Void ReadPose() { }
        private System.Void Solve() { }
        private System.Void ApplyBendConstraints() { }
        private System.Void WritePose() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000074
    public struct FullBodyBipedEffector
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static RootMotion.FinalIK.FullBodyBipedEffector Body;        // 0x0
        public static RootMotion.FinalIK.FullBodyBipedEffector LeftShoulder;        // 0x0
        public static RootMotion.FinalIK.FullBodyBipedEffector RightShoulder;        // 0x0
        public static RootMotion.FinalIK.FullBodyBipedEffector LeftThigh;        // 0x0
        public static RootMotion.FinalIK.FullBodyBipedEffector RightThigh;        // 0x0
        public static RootMotion.FinalIK.FullBodyBipedEffector LeftHand;        // 0x0
        public static RootMotion.FinalIK.FullBodyBipedEffector RightHand;        // 0x0
        public static RootMotion.FinalIK.FullBodyBipedEffector LeftFoot;        // 0x0
        public static RootMotion.FinalIK.FullBodyBipedEffector RightFoot;        // 0x0

    }

    // TypeToken: 0x2000075
    public struct FullBodyBipedChain
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static RootMotion.FinalIK.FullBodyBipedChain LeftArm;        // 0x0
        public static RootMotion.FinalIK.FullBodyBipedChain RightArm;        // 0x0
        public static RootMotion.FinalIK.FullBodyBipedChain LeftLeg;        // 0x0
        public static RootMotion.FinalIK.FullBodyBipedChain RightLeg;        // 0x0

    }

    // TypeToken: 0x2000076
    public class IKSolverFullBodyBiped : IKSolverFullBody
    {
        // Fields
        public UnityEngine.Transform rootNode;        // 0xD0
        public System.Single spineStiffness;        // 0xD8
        public System.Single pullBodyVertical;        // 0xDC
        public System.Single pullBodyHorizontal;        // 0xE0
        private UnityEngine.Vector3 <pullBodyOffset>k__BackingField;        // 0xE4
        private UnityEngine.Vector3 offset;        // 0xF0

        // Methods
        private RootMotion.FinalIK.IKEffector get_bodyEffector() { }
        private RootMotion.FinalIK.IKEffector get_leftShoulderEffector() { }
        private RootMotion.FinalIK.IKEffector get_rightShoulderEffector() { }
        private RootMotion.FinalIK.IKEffector get_leftThighEffector() { }
        private RootMotion.FinalIK.IKEffector get_rightThighEffector() { }
        private RootMotion.FinalIK.IKEffector get_leftHandEffector() { }
        private RootMotion.FinalIK.IKEffector get_rightHandEffector() { }
        private RootMotion.FinalIK.IKEffector get_leftFootEffector() { }
        private RootMotion.FinalIK.IKEffector get_rightFootEffector() { }
        private RootMotion.FinalIK.FBIKChain get_leftArmChain() { }
        private RootMotion.FinalIK.FBIKChain get_rightArmChain() { }
        private RootMotion.FinalIK.FBIKChain get_leftLegChain() { }
        private RootMotion.FinalIK.FBIKChain get_rightLegChain() { }
        private RootMotion.FinalIK.IKMappingLimb get_leftArmMapping() { }
        private RootMotion.FinalIK.IKMappingLimb get_rightArmMapping() { }
        private RootMotion.FinalIK.IKMappingLimb get_leftLegMapping() { }
        private RootMotion.FinalIK.IKMappingLimb get_rightLegMapping() { }
        private RootMotion.FinalIK.IKMappingBone get_headMapping() { }
        private System.Void SetChainWeights(RootMotion.FinalIK.FullBodyBipedChain c, System.Single pull, System.Single reach) { }
        private System.Void SetEffectorWeights(RootMotion.FinalIK.FullBodyBipedEffector effector, System.Single positionWeight, System.Single rotationWeight) { }
        private RootMotion.FinalIK.FBIKChain GetChain(RootMotion.FinalIK.FullBodyBipedChain c) { }
        private RootMotion.FinalIK.FBIKChain GetChain(RootMotion.FinalIK.FullBodyBipedEffector effector) { }
        private RootMotion.FinalIK.IKEffector GetEffector(RootMotion.FinalIK.FullBodyBipedEffector effector) { }
        private RootMotion.FinalIK.IKEffector GetEndEffector(RootMotion.FinalIK.FullBodyBipedChain c) { }
        private RootMotion.FinalIK.IKMappingLimb GetLimbMapping(RootMotion.FinalIK.FullBodyBipedChain chain) { }
        private RootMotion.FinalIK.IKMappingLimb GetLimbMapping(RootMotion.FinalIK.FullBodyBipedEffector effector) { }
        private RootMotion.FinalIK.IKMappingSpine GetSpineMapping() { }
        private RootMotion.FinalIK.IKMappingBone GetHeadMapping() { }
        private RootMotion.FinalIK.IKConstraintBend GetBendConstraint(RootMotion.FinalIK.FullBodyBipedChain limb) { }
        private System.Boolean IsValid(System.String& message) { }
        private System.Void SetToReferences(RootMotion.BipedReferences references, UnityEngine.Transform rootNode) { }
        private UnityEngine.Transform DetectRootNodeBone(RootMotion.BipedReferences references) { }
        private System.Void SetLimbOrientations(RootMotion.BipedLimbOrientations o) { }
        private UnityEngine.Vector3 get_pullBodyOffset() { }
        private System.Void set_pullBodyOffset(UnityEngine.Vector3 value) { }
        private System.Void SetLimbOrientation(RootMotion.FinalIK.FullBodyBipedChain chain, RootMotion.BipedLimbOrientations.LimbOrientation limbOrientation) { }
        private UnityEngine.Transform GetLeftClavicle(RootMotion.BipedReferences references) { }
        private UnityEngine.Transform GetRightClavicle(RootMotion.BipedReferences references) { }
        private System.Boolean Contains(UnityEngine.Transform[] array, UnityEngine.Transform transform) { }
        private System.Void ReadPose() { }
        private System.Void PullBody() { }
        private UnityEngine.Vector3 GetBodyOffset() { }
        private UnityEngine.Vector3 GetHandBodyPull(RootMotion.FinalIK.IKEffector effector, RootMotion.FinalIK.FBIKChain arm, UnityEngine.Vector3 offset) { }
        private System.Void ApplyBendConstraints() { }
        private System.Void WritePose() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000077
    public class IKSolverHeuristic : IKSolver
    {
        // Fields
        public UnityEngine.Transform target;        // 0x58
        public System.Single tolerance;        // 0x60
        public System.Int32 maxIterations;        // 0x64
        public System.Boolean useRotationLimits;        // 0x68
        public System.Boolean XY;        // 0x69
        public RootMotion.FinalIK.IKSolver.Bone[] bones;        // 0x70
        protected UnityEngine.Vector3 lastLocalDirection;        // 0x78
        protected System.Single chainLength;        // 0x84

        // Methods
        private System.Boolean SetChain(UnityEngine.Transform[] hierarchy, UnityEngine.Transform root) { }
        private System.Void AddBone(UnityEngine.Transform bone) { }
        private System.Void StoreDefaultLocalState() { }
        private System.Void FixTransforms() { }
        private System.Boolean IsValid(System.String& message) { }
        private RootMotion.FinalIK.IKSolver.Point[] GetPoints() { }
        private RootMotion.FinalIK.IKSolver.Point GetPoint(UnityEngine.Transform transform) { }
        private System.Int32 get_minBones() { }
        private System.Boolean get_boneLengthCanBeZero() { }
        private System.Boolean get_allowCommonParent() { }
        private System.Void OnInitiate() { }
        private System.Void OnUpdate() { }
        private System.Void InitiateBones() { }
        private UnityEngine.Vector3 get_localDirection() { }
        private System.Single get_positionOffset() { }
        private UnityEngine.Vector3 GetSingularityOffset() { }
        private System.Boolean SingularityDetected() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000078
    public class IKSolverLeg : IKSolver
    {
        // Fields
        public System.Single IKRotationWeight;        // 0x58
        public UnityEngine.Quaternion IKRotation;        // 0x5C
        public RootMotion.FinalIK.IKSolver.Point pelvis;        // 0x70
        public RootMotion.FinalIK.IKSolver.Point thigh;        // 0x78
        public RootMotion.FinalIK.IKSolver.Point calf;        // 0x80
        public RootMotion.FinalIK.IKSolver.Point foot;        // 0x88
        public RootMotion.FinalIK.IKSolver.Point toe;        // 0x90
        public RootMotion.FinalIK.IKSolverVR.Leg leg;        // 0x98
        public UnityEngine.Vector3 heelOffset;        // 0xA0
        private UnityEngine.Vector3[] positions;        // 0xB0
        private UnityEngine.Quaternion[] rotations;        // 0xB8

        // Methods
        private System.Boolean IsValid(System.String& message) { }
        private System.Boolean SetChain(UnityEngine.Transform pelvis, UnityEngine.Transform thigh, UnityEngine.Transform calf, UnityEngine.Transform foot, UnityEngine.Transform toe, UnityEngine.Transform root) { }
        private RootMotion.FinalIK.IKSolver.Point[] GetPoints() { }
        private RootMotion.FinalIK.IKSolver.Point GetPoint(UnityEngine.Transform transform) { }
        private System.Void StoreDefaultLocalState() { }
        private System.Void FixTransforms() { }
        private System.Void OnInitiate() { }
        private System.Void OnUpdate() { }
        private System.Void Solve() { }
        private System.Void Read() { }
        private System.Void Write() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000079
    public class IKSolverLimb : IKSolverTrigonometric
    {
        // Fields
        public UnityEngine.AvatarIKGoal goal;        // 0xA8
        public RootMotion.FinalIK.IKSolverLimb.BendModifier bendModifier;        // 0xAC
        public System.Single maintainRotationWeight;        // 0xB0
        public System.Single bendModifierWeight;        // 0xB4
        public UnityEngine.Transform bendGoal;        // 0xB8
        private System.Boolean maintainBendFor1Frame;        // 0xC0
        private System.Boolean maintainRotationFor1Frame;        // 0xC1
        private UnityEngine.Quaternion defaultRootRotation;        // 0xC4
        private UnityEngine.Quaternion parentDefaultRotation;        // 0xD4
        private UnityEngine.Quaternion bone3RotationBeforeSolve;        // 0xE4
        private UnityEngine.Quaternion maintainRotation;        // 0xF4
        private UnityEngine.Quaternion bone3DefaultRotation;        // 0x104
        private UnityEngine.Vector3 _bendNormal;        // 0x114
        private UnityEngine.Vector3 animationNormal;        // 0x120
        private RootMotion.FinalIK.IKSolverLimb.AxisDirection[] axisDirectionsLeft;        // 0x130
        private RootMotion.FinalIK.IKSolverLimb.AxisDirection[] axisDirectionsRight;        // 0x138

        // Methods
        private System.Void MaintainRotation() { }
        private System.Void MaintainBend() { }
        private System.Void OnInitiateVirtual() { }
        private System.Void OnUpdateVirtual() { }
        private System.Void OnPostSolveVirtual() { }
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.AvatarIKGoal goal) { }
        private RootMotion.FinalIK.IKSolverLimb.AxisDirection[] get_axisDirections() { }
        private System.Void StoreAxisDirections(RootMotion.FinalIK.IKSolverLimb.AxisDirection[]& axisDirections) { }
        private UnityEngine.Vector3 GetModifiedBendNormal() { }

    }

    // TypeToken: 0x200007C
    public class IKSolverLookAt : IKSolver
    {
        // Fields
        public UnityEngine.Transform target;        // 0x58
        public RootMotion.FinalIK.IKSolverLookAt.LookAtBone[] spine;        // 0x60
        private UnityEngine.Quaternion[] m_spineVirtualBones;        // 0x68
        public RootMotion.FinalIK.IKSolverLookAt.LookAtBone head;        // 0x70
        private UnityEngine.Quaternion m_headVirtualBones;        // 0x78
        public RootMotion.FinalIK.IKSolverLookAt.LookAtBone[] eyes;        // 0x88
        private UnityEngine.Quaternion m_eyeVirtualBone;        // 0x90
        public System.Single bodyWeight;        // 0xA0
        public System.Single headWeight;        // 0xA4
        public System.Single eyesWeight;        // 0xA8
        public System.Single clampWeight;        // 0xAC
        public System.Single clampWeightHead;        // 0xB0
        public System.Single clampWeightEyes;        // 0xB4
        public System.Int32 clampSmoothing;        // 0xB8
        public UnityEngine.AnimationCurve spineWeightCurve;        // 0xC0
        public UnityEngine.Vector3 spineTargetOffset;        // 0xC8
        protected UnityEngine.Vector3[] spineForwards;        // 0xD8
        protected UnityEngine.Vector3[] headForwards;        // 0xE0
        protected UnityEngine.Vector3[] eyeForward;        // 0xE8
        private System.Boolean isDirty;        // 0xF0

        // Methods
        private UnityEngine.Quaternion[] get_spineVirtualBone() { }
        private System.Void set_spineVirtualBone(UnityEngine.Quaternion[] value) { }
        private UnityEngine.Quaternion get_headVirtualBones() { }
        private System.Void set_headVirtualBones(UnityEngine.Quaternion value) { }
        private UnityEngine.Quaternion get_eyeVirtualBone() { }
        private System.Void set_eyeVirtualBone(UnityEngine.Quaternion value) { }
        private System.Void SetLookAtWeight(System.Single weight) { }
        private System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight) { }
        private System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight) { }
        private System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight) { }
        private System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight, System.Single clampWeight) { }
        private System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight, System.Single clampWeight, System.Single clampWeightHead, System.Single clampWeightEyes) { }
        private System.Void StoreDefaultLocalState() { }
        private System.Void SetDirty() { }
        private System.Void FixTransforms() { }
        private System.Boolean IsValid(System.String& message) { }
        private RootMotion.FinalIK.IKSolver.Point[] GetPoints() { }
        private RootMotion.FinalIK.IKSolver.Point GetPoint(UnityEngine.Transform transform) { }
        private System.Boolean SetChain(UnityEngine.Transform[] spine, UnityEngine.Transform head, UnityEngine.Transform[] eyes, UnityEngine.Transform root) { }
        private System.Void OnInitiate() { }
        private System.Void OnUpdate() { }
        private System.Boolean get_spineIsValid() { }
        private System.Boolean get_spineIsEmpty() { }
        private System.Void SolveSpine() { }
        private System.Boolean get_headIsValid() { }
        private System.Boolean get_headIsEmpty() { }
        private System.Void SolveHead() { }
        private System.Boolean get_eyesIsValid() { }
        private System.Boolean get_eyesIsEmpty() { }
        private System.Void SolveEyes() { }
        private UnityEngine.Vector3[] GetForwards(UnityEngine.Vector3[]& forwards, UnityEngine.Vector3 baseForward, UnityEngine.Vector3 targetForward, System.Int32 bones, System.Single clamp) { }
        private System.Void SetBones(UnityEngine.Transform[] array, RootMotion.FinalIK.IKSolverLookAt.LookAtBone[]& bones) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007E
    public class IKSolverTrigonometric : IKSolver
    {
        // Fields
        public UnityEngine.Transform target;        // 0x58
        public System.Single IKRotationWeight;        // 0x60
        public UnityEngine.Quaternion IKRotation;        // 0x64
        public UnityEngine.Vector3 bendNormal;        // 0x74
        public RootMotion.FinalIK.IKSolverTrigonometric.TrigonometricBone bone1;        // 0x80
        public RootMotion.FinalIK.IKSolverTrigonometric.TrigonometricBone bone2;        // 0x88
        public RootMotion.FinalIK.IKSolverTrigonometric.TrigonometricBone bone3;        // 0x90
        protected UnityEngine.Vector3 weightIKPosition;        // 0x98
        protected System.Boolean directHierarchy;        // 0xA4

        // Methods
        private System.Void SetBendGoalPosition(UnityEngine.Vector3 goalPosition, System.Single weight) { }
        private System.Void SetBendPlaneToCurrent() { }
        private System.Void SetIKRotation(UnityEngine.Quaternion rotation) { }
        private System.Void SetIKRotationWeight(System.Single weight) { }
        private UnityEngine.Quaternion GetIKRotation() { }
        private System.Single GetIKRotationWeight() { }
        private RootMotion.FinalIK.IKSolver.Point[] GetPoints() { }
        private RootMotion.FinalIK.IKSolver.Point GetPoint(UnityEngine.Transform transform) { }
        private System.Void StoreDefaultLocalState() { }
        private System.Void FixTransforms() { }
        private System.Boolean IsValid(System.String& message) { }
        private System.Boolean SetChain(UnityEngine.Transform bone1, UnityEngine.Transform bone2, UnityEngine.Transform bone3, UnityEngine.Transform root) { }
        private System.Void Solve(UnityEngine.Transform bone1, UnityEngine.Transform bone2, UnityEngine.Transform bone3, UnityEngine.Vector3 targetPosition, UnityEngine.Vector3 bendNormal, System.Single weight) { }
        private UnityEngine.Vector3 GetDirectionToBendPoint(UnityEngine.Vector3 direction, System.Single directionMag, UnityEngine.Vector3 bendDirection, System.Single sqrMag1, System.Single sqrMag2) { }
        private System.Void OnInitiate() { }
        private System.Boolean IsDirectHierarchy() { }
        private System.Void InitiateBones() { }
        private System.Void OnUpdate() { }
        private System.Void OnInitiateVirtual() { }
        private System.Void OnUpdateVirtual() { }
        private System.Void OnPostSolveVirtual() { }
        private UnityEngine.Vector3 GetBendDirection(UnityEngine.Vector3 IKPosition, UnityEngine.Vector3 bendNormal) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000080
    public class IKSolverVR : IKSolver
    {
        // Fields
        private UnityEngine.Animator <animator>k__BackingField;        // 0x58
        private UnityEngine.Transform[] solverTransforms;        // 0x60
        private System.Boolean hasChest;        // 0x68
        private System.Boolean hasNeck;        // 0x69
        private System.Boolean hasShoulders;        // 0x6A
        private System.Boolean hasToes;        // 0x6B
        private System.Boolean hasLegs;        // 0x6C
        private System.Boolean hasArms;        // 0x6D
        private UnityEngine.Vector3[] readPositions;        // 0x70
        private UnityEngine.Quaternion[] readRotations;        // 0x78
        private UnityEngine.Vector3[] solvedPositions;        // 0x80
        private UnityEngine.Quaternion[] solvedRotations;        // 0x88
        private UnityEngine.Quaternion[] defaultLocalRotations;        // 0x90
        private UnityEngine.Vector3[] defaultLocalPositions;        // 0x98
        private UnityEngine.Vector3 rootV;        // 0xA0
        private UnityEngine.Vector3 rootVelocity;        // 0xAC
        private UnityEngine.Vector3 bodyOffset;        // 0xB8
        private System.Int32 supportLegIndex;        // 0xC4
        private System.Int32 lastLOD;        // 0xC8
        private System.Single lastLocomotionWeight;        // 0xCC
        public System.Int32 LOD;        // 0xD0
        public System.Single scale;        // 0xD4
        public System.Boolean plantFeet;        // 0xD8
        private RootMotion.FinalIK.IKSolverVR.VirtualBone <rootBone>k__BackingField;        // 0xE0
        public RootMotion.FinalIK.IKSolverVR.Spine spine;        // 0xE8
        public RootMotion.FinalIK.IKSolverVR.Arm leftArm;        // 0xF0
        public RootMotion.FinalIK.IKSolverVR.Arm rightArm;        // 0xF8
        public RootMotion.FinalIK.IKSolverVR.Leg leftLeg;        // 0x100
        public RootMotion.FinalIK.IKSolverVR.Leg rightLeg;        // 0x108
        public RootMotion.FinalIK.IKSolverVR.Locomotion locomotion;        // 0x110
        private RootMotion.FinalIK.IKSolverVR.Leg[] legs;        // 0x118
        private RootMotion.FinalIK.IKSolverVR.Arm[] arms;        // 0x120
        private UnityEngine.Vector3 headPosition;        // 0x128
        private UnityEngine.Vector3 headDeltaPosition;        // 0x134
        private UnityEngine.Vector3 raycastOriginPelvis;        // 0x140
        private UnityEngine.Vector3 lastOffset;        // 0x14C
        private UnityEngine.Vector3 debugPos1;        // 0x158
        private UnityEngine.Vector3 debugPos2;        // 0x164
        private UnityEngine.Vector3 debugPos3;        // 0x170
        private UnityEngine.Vector3 debugPos4;        // 0x17C

        // Methods
        private UnityEngine.Animator get_animator() { }
        private System.Void set_animator(UnityEngine.Animator value) { }
        private System.Void SetToReferences(RootMotion.FinalIK.VRIK.References references) { }
        private System.Void GuessHandOrientations(RootMotion.FinalIK.VRIK.References references, System.Boolean onlyIfZero) { }
        private System.Void DefaultAnimationCurves() { }
        private System.Void AddPositionOffset(RootMotion.FinalIK.IKSolverVR.PositionOffset positionOffset, UnityEngine.Vector3 value) { }
        private System.Void AddRotationOffset(RootMotion.FinalIK.IKSolverVR.RotationOffset rotationOffset, UnityEngine.Vector3 value) { }
        private System.Void AddRotationOffset(RootMotion.FinalIK.IKSolverVR.RotationOffset rotationOffset, UnityEngine.Quaternion value) { }
        private System.Void AddPlatformMotion(UnityEngine.Vector3 deltaPosition, UnityEngine.Quaternion deltaRotation, UnityEngine.Vector3 platformPivot) { }
        private System.Void Reset() { }
        private System.Void StoreDefaultLocalState() { }
        private System.Void FixTransforms() { }
        private RootMotion.FinalIK.IKSolver.Point[] GetPoints() { }
        private RootMotion.FinalIK.IKSolver.Point GetPoint(UnityEngine.Transform transform) { }
        private System.Boolean IsValid(System.String& message) { }
        private UnityEngine.Vector3 GetNormal(UnityEngine.Transform[] transforms) { }
        private UnityEngine.Keyframe[] GetSineKeyframes(System.Single mag) { }
        private System.Void UpdateSolverTransforms() { }
        private System.Void OnInitiate() { }
        private System.Void OnUpdate() { }
        private System.Void WriteTransforms() { }
        private System.Void Read(UnityEngine.Vector3[] positions, UnityEngine.Quaternion[] rotations, System.Boolean hasChest, System.Boolean hasNeck, System.Boolean hasShoulders, System.Boolean hasToes, System.Boolean hasLegs, System.Boolean hasArms) { }
        private System.Void Solve() { }
        private UnityEngine.Vector3 GetPosition(System.Int32 index) { }
        private UnityEngine.Quaternion GetRotation(System.Int32 index) { }
        private RootMotion.FinalIK.IKSolverVR.VirtualBone get_rootBone() { }
        private System.Void set_rootBone(RootMotion.FinalIK.IKSolverVR.VirtualBone value) { }
        private System.Void Write() { }
        private UnityEngine.Vector3 GetPelvisOffset(System.Single deltaTime) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008C
    public class TwistRelaxer : MonoBehaviour
    {
        // Fields
        public RootMotion.FinalIK.IK ik;        // 0x18
        public RootMotion.FinalIK.TwistSolver[] twistSolvers;        // 0x20

        // Methods
        private System.Void Start() { }
        private System.Void Update() { }
        private System.Void OnPostUpdate() { }
        private System.Void LateUpdate() { }
        private System.Void OnDestroy() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008D
    public class TwistSolver
    {
        // Fields
        public UnityEngine.Transform transform;        // 0x10
        public UnityEngine.Transform parent;        // 0x18
        public UnityEngine.Transform[] children;        // 0x20
        public System.Single weight;        // 0x28
        public System.Single parentChildCrossfade;        // 0x2C
        public System.Single twistAngleOffset;        // 0x30
        private UnityEngine.Vector3 twistAxis;        // 0x34
        private UnityEngine.Vector3 axis;        // 0x40
        private UnityEngine.Vector3 axisRelativeToParentDefault;        // 0x4C
        private UnityEngine.Vector3 axisRelativeToChildDefault;        // 0x58
        private UnityEngine.Quaternion[] childRotations;        // 0x68
        private System.Boolean inititated;        // 0x70
        private UnityEngine.Quaternion defaultLocalRotation;        // 0x74
        private UnityEngine.Quaternion[] defaultChildLocalRotations;        // 0x88

        // Methods
        private System.Void .ctor() { }
        private System.Void Initiate() { }
        private System.Void FixTransforms() { }
        private System.Void Relax() { }

    }

    // TypeToken: 0x200008E
    public class InteractionEffector
    {
        // Fields
        private RootMotion.FinalIK.FullBodyBipedEffector <effectorType>k__BackingField;        // 0x10
        private System.Boolean <isPaused>k__BackingField;        // 0x14
        private RootMotion.FinalIK.InteractionObject <interactionObject>k__BackingField;        // 0x18
        private RootMotion.FinalIK.Poser poser;        // 0x20
        private RootMotion.FinalIK.IKEffector effector;        // 0x28
        private System.Single timer;        // 0x30
        private System.Single length;        // 0x34
        private System.Single weight;        // 0x38
        private System.Single fadeInSpeed;        // 0x3C
        private System.Single defaultPositionWeight;        // 0x40
        private System.Single defaultRotationWeight;        // 0x44
        private System.Single defaultPull;        // 0x48
        private System.Single defaultReach;        // 0x4C
        private System.Single defaultPush;        // 0x50
        private System.Single defaultPushParent;        // 0x54
        private System.Single defaultBendGoalWeight;        // 0x58
        private System.Single resetTimer;        // 0x5C
        private System.Boolean positionWeightUsed;        // 0x60
        private System.Boolean rotationWeightUsed;        // 0x61
        private System.Boolean pullUsed;        // 0x62
        private System.Boolean reachUsed;        // 0x63
        private System.Boolean pushUsed;        // 0x64
        private System.Boolean pushParentUsed;        // 0x65
        private System.Boolean bendGoalWeightUsed;        // 0x66
        private System.Boolean pickedUp;        // 0x67
        private System.Boolean defaults;        // 0x68
        private System.Boolean pickUpOnPostFBBIK;        // 0x69
        private UnityEngine.Vector3 pickUpPosition;        // 0x6C
        private UnityEngine.Vector3 pausePositionRelative;        // 0x78
        private UnityEngine.Quaternion pickUpRotation;        // 0x84
        private UnityEngine.Quaternion pauseRotationRelative;        // 0x94
        private RootMotion.FinalIK.InteractionTarget interactionTarget;        // 0xA8
        private UnityEngine.Transform target;        // 0xB0
        private System.Collections.Generic.List<System.Boolean> triggered;        // 0xB8
        private RootMotion.FinalIK.InteractionSystem interactionSystem;        // 0xC0
        private System.Boolean started;        // 0xC8

        // Methods
        private RootMotion.FinalIK.FullBodyBipedEffector get_effectorType() { }
        private System.Void set_effectorType(RootMotion.FinalIK.FullBodyBipedEffector value) { }
        private System.Boolean get_isPaused() { }
        private System.Void set_isPaused(System.Boolean value) { }
        private RootMotion.FinalIK.InteractionObject get_interactionObject() { }
        private System.Void set_interactionObject(RootMotion.FinalIK.InteractionObject value) { }
        private System.Boolean get_inInteraction() { }
        private System.Void .ctor(RootMotion.FinalIK.FullBodyBipedEffector effectorType) { }
        private System.Void Initiate(RootMotion.FinalIK.InteractionSystem interactionSystem) { }
        private System.Void StoreDefaults() { }
        private System.Boolean ResetToDefaults(System.Single speed, System.Single deltaTime) { }
        private System.Boolean Pause() { }
        private System.Boolean Resume() { }
        private System.Boolean Start(RootMotion.FinalIK.InteractionObject interactionObject, System.String tag, System.Single fadeInTime, System.Boolean interrupt) { }
        private System.Boolean Start(RootMotion.FinalIK.InteractionObject interactionObject, RootMotion.FinalIK.InteractionTarget interactionTarget, System.Single fadeInTime, System.Boolean interrupt) { }
        private System.Void Update(UnityEngine.Transform root, System.Single speed, System.Single deltaTime) { }
        private System.Single get_progress() { }
        private System.Void TriggerUntriggeredEvents(System.Boolean checkTime, System.Boolean& pickUp, System.Boolean& pause) { }
        private System.Void PickUp(UnityEngine.Transform root) { }
        private System.Boolean Stop() { }
        private System.Void OnPostFBBIK() { }

    }

    // TypeToken: 0x200008F
    public class InteractionLookAt
    {
        // Fields
        public RootMotion.FinalIK.LookAtIK ik;        // 0x10
        public System.Single lerpSpeed;        // 0x18
        public System.Single weightSpeed;        // 0x1C
        public System.Boolean isPaused;        // 0x20
        private UnityEngine.Transform lookAtTarget;        // 0x28
        private System.Single stopLookTime;        // 0x30
        private System.Single weight;        // 0x34
        private System.Boolean firstFBBIKSolve;        // 0x38

        // Methods
        private System.Void Look(UnityEngine.Transform target, System.Single time) { }
        private System.Void OnFixTransforms() { }
        private System.Void Update() { }
        private System.Void SolveSpine() { }
        private System.Void SolveHead() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000090
    public class InteractionObject : MonoBehaviour
    {
        // Fields
        public UnityEngine.Transform otherLookAtTarget;        // 0x18
        public UnityEngine.Transform otherTargetsRoot;        // 0x20
        public UnityEngine.Transform positionOffsetSpace;        // 0x28
        public RootMotion.FinalIK.InteractionObject.WeightCurve[] weightCurves;        // 0x30
        public RootMotion.FinalIK.InteractionObject.Multiplier[] multipliers;        // 0x38
        public RootMotion.FinalIK.InteractionObject.InteractionEvent[] events;        // 0x40
        private System.Single <length>k__BackingField;        // 0x48
        private RootMotion.FinalIK.InteractionSystem <lastUsedInteractionSystem>k__BackingField;        // 0x50
        private RootMotion.FinalIK.InteractionTarget[] targets;        // 0x58

        // Methods
        private System.Void OpenUserManual() { }
        private System.Void OpenScriptReference() { }
        private System.Void OpenTutorial1() { }
        private System.Void OpenTutorial2() { }
        private System.Void OpenTutorial3() { }
        private System.Void OpenTutorial4() { }
        private System.Void SupportGroup() { }
        private System.Void ASThread() { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private RootMotion.FinalIK.InteractionSystem get_lastUsedInteractionSystem() { }
        private System.Void set_lastUsedInteractionSystem(RootMotion.FinalIK.InteractionSystem value) { }
        private System.Void Initiate() { }
        private UnityEngine.Transform get_lookAtTarget() { }
        private RootMotion.FinalIK.InteractionTarget GetTarget(RootMotion.FinalIK.FullBodyBipedEffector effectorType, RootMotion.FinalIK.InteractionSystem interactionSystem) { }
        private System.Boolean CurveUsed(RootMotion.FinalIK.InteractionObject.WeightCurve.Type type) { }
        private RootMotion.FinalIK.InteractionTarget[] GetTargets() { }
        private UnityEngine.Transform GetTarget(RootMotion.FinalIK.FullBodyBipedEffector effectorType, System.String tag) { }
        private System.Void OnStartInteraction(RootMotion.FinalIK.InteractionSystem interactionSystem) { }
        private System.Void Apply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, RootMotion.FinalIK.FullBodyBipedEffector effector, RootMotion.FinalIK.InteractionTarget target, System.Single timer, System.Single weight) { }
        private System.Single GetValue(RootMotion.FinalIK.InteractionObject.WeightCurve.Type weightCurveType, RootMotion.FinalIK.InteractionTarget target, System.Single timer) { }
        private UnityEngine.Transform get_targetsRoot() { }
        private System.Void Start() { }
        private System.Void Apply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, RootMotion.FinalIK.FullBodyBipedEffector effector, RootMotion.FinalIK.InteractionObject.WeightCurve.Type type, System.Single value, System.Single weight) { }
        private UnityEngine.Transform GetTarget(RootMotion.FinalIK.FullBodyBipedEffector effectorType) { }
        private System.Int32 GetWeightCurveIndex(RootMotion.FinalIK.InteractionObject.WeightCurve.Type weightCurveType) { }
        private System.Int32 GetMultiplierIndex(RootMotion.FinalIK.InteractionObject.WeightCurve.Type weightCurveType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000097
    public class InteractionSystem : MonoBehaviour
    {
        // Fields
        public System.String targetTag;        // 0x18
        public System.Single fadeInTime;        // 0x20
        public System.Single speed;        // 0x24
        public System.Single resetToDefaultsSpeed;        // 0x28
        public UnityEngine.Collider characterCollider;        // 0x30
        public UnityEngine.Transform FPSCamera;        // 0x38
        public UnityEngine.LayerMask camRaycastLayers;        // 0x40
        public System.Single camRaycastDistance;        // 0x44
        private System.Collections.Generic.List<RootMotion.FinalIK.InteractionTrigger> <triggersInRange>k__BackingField;        // 0x48
        private System.Collections.Generic.List<RootMotion.FinalIK.InteractionTrigger> inContact;        // 0x50
        private System.Collections.Generic.List<System.Int32> bestRangeIndexes;        // 0x58
        public RootMotion.FinalIK.InteractionSystem.InteractionDelegate OnInteractionStart;        // 0x60
        public RootMotion.FinalIK.InteractionSystem.InteractionDelegate OnInteractionPause;        // 0x68
        public RootMotion.FinalIK.InteractionSystem.InteractionDelegate OnInteractionPickUp;        // 0x70
        public RootMotion.FinalIK.InteractionSystem.InteractionDelegate OnInteractionResume;        // 0x78
        public RootMotion.FinalIK.InteractionSystem.InteractionDelegate OnInteractionStop;        // 0x80
        public RootMotion.FinalIK.InteractionSystem.InteractionEventDelegate OnInteractionEvent;        // 0x88
        public UnityEngine.RaycastHit raycastHit;        // 0x90
        private RootMotion.FinalIK.FullBodyBipedIK fullBody;        // 0xD0
        public RootMotion.FinalIK.InteractionLookAt lookAt;        // 0xD8
        private RootMotion.FinalIK.InteractionEffector[] interactionEffectors;        // 0xE0
        private System.Boolean <initiated>k__BackingField;        // 0xE8
        private UnityEngine.Collider lastCollider;        // 0xF0
        private UnityEngine.Collider c;        // 0xF8
        private System.Single lastTime;        // 0x100

        // Methods
        private System.Void OpenUserManual() { }
        private System.Void OpenScriptReference() { }
        private System.Void OpenTutorial1() { }
        private System.Void OpenTutorial2() { }
        private System.Void OpenTutorial3() { }
        private System.Void OpenTutorial4() { }
        private System.Void SupportGroup() { }
        private System.Void ASThread() { }
        private System.Boolean get_inInteraction() { }
        private System.Boolean IsInInteraction(RootMotion.FinalIK.FullBodyBipedEffector effectorType) { }
        private System.Boolean IsPaused(RootMotion.FinalIK.FullBodyBipedEffector effectorType) { }
        private System.Boolean IsPaused() { }
        private System.Boolean IsInSync() { }
        private System.Boolean StartInteraction(RootMotion.FinalIK.FullBodyBipedEffector effectorType, RootMotion.FinalIK.InteractionObject interactionObject, System.Boolean interrupt) { }
        private System.Boolean StartInteraction(RootMotion.FinalIK.FullBodyBipedEffector effectorType, RootMotion.FinalIK.InteractionObject interactionObject, RootMotion.FinalIK.InteractionTarget target, System.Boolean interrupt) { }
        private System.Boolean PauseInteraction(RootMotion.FinalIK.FullBodyBipedEffector effectorType) { }
        private System.Boolean ResumeInteraction(RootMotion.FinalIK.FullBodyBipedEffector effectorType) { }
        private System.Boolean StopInteraction(RootMotion.FinalIK.FullBodyBipedEffector effectorType) { }
        private System.Void PauseAll() { }
        private System.Void ResumeAll() { }
        private System.Void StopAll() { }
        private RootMotion.FinalIK.InteractionObject GetInteractionObject(RootMotion.FinalIK.FullBodyBipedEffector effectorType) { }
        private System.Single GetProgress(RootMotion.FinalIK.FullBodyBipedEffector effectorType) { }
        private System.Single GetMinActiveProgress() { }
        private System.Boolean TriggerInteraction(System.Int32 index, System.Boolean interrupt) { }
        private System.Boolean TriggerInteraction(System.Int32 index, System.Boolean interrupt, RootMotion.FinalIK.InteractionObject& interactionObject) { }
        private System.Boolean TriggerInteraction(System.Int32 index, System.Boolean interrupt, RootMotion.FinalIK.InteractionTarget& interactionTarget) { }
        private RootMotion.FinalIK.InteractionTrigger.Range GetClosestInteractionRange() { }
        private RootMotion.FinalIK.InteractionObject GetClosestInteractionObjectInRange() { }
        private RootMotion.FinalIK.InteractionTarget GetClosestInteractionTargetInRange() { }
        private RootMotion.FinalIK.InteractionObject[] GetClosestInteractionObjectsInRange() { }
        private RootMotion.FinalIK.InteractionTarget[] GetClosestInteractionTargetsInRange() { }
        private System.Boolean TriggerEffectorsReady(System.Int32 index) { }
        private RootMotion.FinalIK.InteractionTrigger.Range GetTriggerRange(System.Int32 index) { }
        private System.Int32 GetClosestTriggerIndex() { }
        private RootMotion.FinalIK.FullBodyBipedIK get_ik() { }
        private System.Void set_ik(RootMotion.FinalIK.FullBodyBipedIK value) { }
        private System.Collections.Generic.List<RootMotion.FinalIK.InteractionTrigger> get_triggersInRange() { }
        private System.Void set_triggersInRange(System.Collections.Generic.List<RootMotion.FinalIK.InteractionTrigger> value) { }
        private System.Boolean get_initiated() { }
        private System.Void set_initiated(System.Boolean value) { }
        private System.Void Start() { }
        private System.Void InteractionPause(RootMotion.FinalIK.FullBodyBipedEffector effector, RootMotion.FinalIK.InteractionObject interactionObject) { }
        private System.Void InteractionResume(RootMotion.FinalIK.FullBodyBipedEffector effector, RootMotion.FinalIK.InteractionObject interactionObject) { }
        private System.Void InteractionStop(RootMotion.FinalIK.FullBodyBipedEffector effector, RootMotion.FinalIK.InteractionObject interactionObject) { }
        private System.Void LookAtInteraction(RootMotion.FinalIK.FullBodyBipedEffector effector, RootMotion.FinalIK.InteractionObject interactionObject) { }
        private System.Void OnTriggerEnter(UnityEngine.Collider c) { }
        private System.Void OnTriggerExit(UnityEngine.Collider c) { }
        private System.Boolean ContactIsInRange(System.Int32 index, System.Int32& bestRangeIndex) { }
        private System.Void OnDrawGizmosSelected() { }
        private System.Void Update() { }
        private System.Void Raycasting() { }
        private System.Void UpdateTriggerEventBroadcasting() { }
        private System.Void OnEnable() { }
        private System.Void UpdateEffectors() { }
        private System.Void OnPreFBBIK() { }
        private System.Void OnPostFBBIK() { }
        private System.Void OnFixTransforms() { }
        private System.Void OnDestroy() { }
        private System.Boolean IsValid(System.Boolean log) { }
        private System.Boolean TriggerIndexIsValid(System.Int32 index) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009A
    public class InteractionTarget : MonoBehaviour
    {
        // Fields
        public RootMotion.FinalIK.FullBodyBipedEffector effectorType;        // 0x18
        public RootMotion.FinalIK.InteractionTarget.Multiplier[] multipliers;        // 0x20
        public System.Single interactionSpeedMlp;        // 0x28
        public UnityEngine.Transform pivot;        // 0x30
        public RootMotion.FinalIK.InteractionTarget.RotationMode rotationMode;        // 0x38
        public UnityEngine.Vector3 twistAxis;        // 0x3C
        public System.Single twistWeight;        // 0x48
        public System.Single swingWeight;        // 0x4C
        public System.Single threeDOFWeight;        // 0x50
        public System.Boolean rotateOnce;        // 0x54
        private UnityEngine.Quaternion defaultLocalRotation;        // 0x58
        private UnityEngine.Transform lastPivot;        // 0x68

        // Methods
        private System.Void OpenUserManual() { }
        private System.Void OpenScriptReference() { }
        private System.Void OpenTutorial1() { }
        private System.Void OpenTutorial2() { }
        private System.Void OpenTutorial3() { }
        private System.Void OpenTutorial4() { }
        private System.Void SupportGroup() { }
        private System.Void ASThread() { }
        private System.Single GetValue(RootMotion.FinalIK.InteractionObject.WeightCurve.Type curveType) { }
        private System.Void ResetRotation() { }
        private System.Void RotateTo(UnityEngine.Transform bone) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009D
    public class InteractionTrigger : MonoBehaviour
    {
        // Fields
        public RootMotion.FinalIK.InteractionTrigger.Range[] ranges;        // 0x18

        // Methods
        private System.Void OpenUserManual() { }
        private System.Void OpenScriptReference() { }
        private System.Void OpenTutorial4() { }
        private System.Void SupportGroup() { }
        private System.Void ASThread() { }
        private System.Int32 GetBestRangeIndex(UnityEngine.Transform character, UnityEngine.Transform raycastFrom, UnityEngine.RaycastHit raycastHit) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A2
    public class GenericPoser : Poser
    {
        // Fields
        public RootMotion.FinalIK.GenericPoser.Map[] maps;        // 0x50

        // Methods
        private System.Void AutoMapping() { }
        private System.Void InitiatePoser() { }
        private System.Void UpdatePoser() { }
        private System.Void FixPoserTransforms() { }
        private System.Void StoreDefaultState() { }
        private UnityEngine.Transform GetTargetNamed(System.String tName, UnityEngine.Transform[] array) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A4
    public class HandPoser : Poser
    {
        // Fields
        protected UnityEngine.Transform[] children;        // 0x50
        private UnityEngine.Transform _poseRoot;        // 0x58
        private UnityEngine.Transform[] poseChildren;        // 0x60
        private UnityEngine.Vector3[] defaultLocalPositions;        // 0x68
        private UnityEngine.Quaternion[] defaultLocalRotations;        // 0x70

        // Methods
        private System.Void AutoMapping() { }
        private System.Void InitiatePoser() { }
        private System.Void FixPoserTransforms() { }
        private System.Void UpdatePoser() { }
        private System.Void StoreDefaultState() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A5
    public class Poser : SolverManager
    {
        // Fields
        public UnityEngine.Transform poseRoot;        // 0x38
        public System.Single weight;        // 0x40
        public System.Single localRotationWeight;        // 0x44
        public System.Single localPositionWeight;        // 0x48
        private System.Boolean initiated;        // 0x4C

        // Methods
        private System.Void AutoMapping() { }
        private System.Void UpdateManual() { }
        private System.Void InitiatePoser() { }
        private System.Void UpdatePoser() { }
        private System.Void FixPoserTransforms() { }
        private System.Void UpdateSolver() { }
        private System.Void InitiateSolver() { }
        private System.Void FixTransforms() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A6
    public class RagdollUtility : MonoBehaviour
    {
        // Fields
        public RootMotion.FinalIK.IK ik;        // 0x18
        public System.Single ragdollToAnimationTime;        // 0x20
        public System.Boolean applyIkOnRagdoll;        // 0x24
        public System.Single applyVelocity;        // 0x28
        public System.Single applyAngularVelocity;        // 0x2C
        private UnityEngine.Animator animator;        // 0x30
        private RootMotion.FinalIK.RagdollUtility.Rigidbone[] rigidbones;        // 0x38
        private RootMotion.FinalIK.RagdollUtility.Child[] children;        // 0x40
        private System.Boolean enableRagdollFlag;        // 0x48
        private UnityEngine.AnimatorUpdateMode animatorUpdateMode;        // 0x4C
        private RootMotion.FinalIK.IK[] allIKComponents;        // 0x50
        private System.Boolean[] fixTransforms;        // 0x58
        private System.Single ragdollWeight;        // 0x60
        private System.Single ragdollWeightV;        // 0x64
        private System.Boolean fixedFrame;        // 0x68
        private System.Boolean[] disabledIKComponents;        // 0x70

        // Methods
        private System.Void EnableRagdoll() { }
        private System.Void DisableRagdoll() { }
        private System.Void Start() { }
        private System.Collections.IEnumerator DisableRagdollSmooth() { }
        private System.Void Update() { }
        private System.Void FixedUpdate() { }
        private System.Void LateUpdate() { }
        private System.Void AfterLastIK() { }
        private System.Void AfterAnimation() { }
        private System.Void OnFinalPose() { }
        private System.Void RagdollEnabler() { }
        private System.Boolean get_isRagdoll() { }
        private System.Void RecordVelocities() { }
        private System.Boolean get_ikUsed() { }
        private System.Void StoreLocalState() { }
        private System.Void FixTransforms(System.Single weight) { }
        private System.Void OnDestroy() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000AA
    public class RotationLimit : MonoBehaviour
    {
        // Fields
        public UnityEngine.Vector3 axis;        // 0x18
        public UnityEngine.Quaternion defaultLocalRotation;        // 0x24
        private System.Boolean <defaultLocalRotationOverride>k__BackingField;        // 0x34
        private System.Boolean initiated;        // 0x35
        private System.Boolean applicationQuit;        // 0x36
        private System.Boolean defaultLocalRotationSet;        // 0x37

        // Methods
        private System.Void SetDefaultLocalRotation() { }
        private System.Void SetDefaultLocalRotation(UnityEngine.Quaternion localRotation) { }
        private UnityEngine.Quaternion GetLimitedLocalRotation(UnityEngine.Quaternion localRotation, System.Boolean& changed) { }
        private System.Boolean Apply() { }
        private System.Void Disable() { }
        private UnityEngine.Vector3 get_secondaryAxis() { }
        private UnityEngine.Vector3 get_crossAxis() { }
        private System.Boolean get_defaultLocalRotationOverride() { }
        private System.Void set_defaultLocalRotationOverride(System.Boolean value) { }
        private UnityEngine.Quaternion LimitRotation(UnityEngine.Quaternion rotation) { }
        private System.Void Awake() { }
        private System.Void LateUpdate() { }
        private System.Void LogWarning(System.String message) { }
        private UnityEngine.Quaternion Limit1DOF(UnityEngine.Quaternion rotation, UnityEngine.Vector3 axis) { }
        private UnityEngine.Quaternion LimitTwist(UnityEngine.Quaternion rotation, UnityEngine.Vector3 axis, UnityEngine.Vector3 orthoAxis, System.Single twistLimit) { }
        private System.Single GetOrthogonalAngle(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, UnityEngine.Vector3 normal) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000AB
    public class RotationLimitAngle : RotationLimit
    {
        // Fields
        public System.Single limit;        // 0x38
        public System.Single twistLimit;        // 0x3C

        // Methods
        private System.Void OpenUserManual() { }
        private System.Void OpenScriptReference() { }
        private System.Void SupportGroup() { }
        private System.Void ASThread() { }
        private UnityEngine.Quaternion LimitRotation(UnityEngine.Quaternion rotation) { }
        private UnityEngine.Quaternion LimitSwing(UnityEngine.Quaternion rotation) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000AC
    public class RotationLimitHinge : RotationLimit
    {
        // Fields
        public System.Boolean useLimits;        // 0x38
        public System.Single min;        // 0x3C
        public System.Single max;        // 0x40
        public System.Single zeroAxisDisplayOffset;        // 0x44
        private System.Single lastAngle;        // 0x48

        // Methods
        private System.Void OpenUserManual() { }
        private System.Void OpenScriptReference() { }
        private System.Void SupportGroup() { }
        private System.Void ASThread() { }
        private UnityEngine.Quaternion LimitRotation(UnityEngine.Quaternion rotation) { }
        private UnityEngine.Quaternion LimitHinge(UnityEngine.Quaternion rotation) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000AD
    public class RotationLimitPolygonal : RotationLimit
    {
        // Fields
        public System.Single twistLimit;        // 0x38
        public System.Int32 smoothIterations;        // 0x3C
        public RootMotion.FinalIK.RotationLimitPolygonal.LimitPoint[] points;        // 0x40
        public UnityEngine.Vector3[] P;        // 0x48
        public RootMotion.FinalIK.RotationLimitPolygonal.ReachCone[] reachCones;        // 0x50

        // Methods
        private System.Void OpenUserManual() { }
        private System.Void OpenScriptReference() { }
        private System.Void SupportGroup() { }
        private System.Void ASThread() { }
        private System.Void SetLimitPoints(RootMotion.FinalIK.RotationLimitPolygonal.LimitPoint[] points) { }
        private UnityEngine.Quaternion LimitRotation(UnityEngine.Quaternion rotation) { }
        private System.Void Start() { }
        private System.Void ResetToDefault() { }
        private System.Void BuildReachCones() { }
        private UnityEngine.Vector3[] SmoothPoints() { }
        private System.Single GetScalar(System.Int32 k) { }
        private UnityEngine.Vector3 PointToTangentPlane(UnityEngine.Vector3 p, System.Single r) { }
        private UnityEngine.Vector3 TangentPointToSphere(UnityEngine.Vector3 q, System.Single r) { }
        private UnityEngine.Quaternion LimitSwing(UnityEngine.Quaternion rotation) { }
        private System.Int32 GetReachCone(UnityEngine.Vector3 L) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B0
    public class RotationLimitSpline : RotationLimit
    {
        // Fields
        public System.Single twistLimit;        // 0x38
        public UnityEngine.AnimationCurve spline;        // 0x40

        // Methods
        private System.Void OpenUserManual() { }
        private System.Void OpenScriptReference() { }
        private System.Void SupportGroup() { }
        private System.Void ASThread() { }
        private System.Void SetSpline(UnityEngine.Keyframe[] keyframes) { }
        private UnityEngine.Quaternion LimitRotation(UnityEngine.Quaternion rotation) { }
        private UnityEngine.Quaternion LimitSwing(UnityEngine.Quaternion rotation) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B1
    public class AimController : MonoBehaviour
    {
        // Fields
        public RootMotion.FinalIK.AimIK ik;        // 0x18
        public System.Single weight;        // 0x20
        public UnityEngine.Transform target;        // 0x28
        public System.Single targetSwitchSmoothTime;        // 0x30
        public System.Single weightSmoothTime;        // 0x34
        public System.Boolean smoothTurnTowardsTarget;        // 0x38
        public System.Single maxRadiansDelta;        // 0x3C
        public System.Single maxMagnitudeDelta;        // 0x40
        public System.Single slerpSpeed;        // 0x44
        public System.Single smoothDampTime;        // 0x48
        public UnityEngine.Vector3 pivotOffsetFromRoot;        // 0x4C
        public System.Single minDistance;        // 0x58
        public UnityEngine.Vector3 offset;        // 0x5C
        public System.Single maxRootAngle;        // 0x68
        public System.Boolean turnToTarget;        // 0x6C
        public System.Single turnToTargetTime;        // 0x70
        public System.Boolean useAnimatedAimDirection;        // 0x74
        public UnityEngine.Vector3 animatedAimDirection;        // 0x78
        private UnityEngine.Transform lastTarget;        // 0x88
        private System.Single switchWeight;        // 0x90
        private System.Single switchWeightV;        // 0x94
        private System.Single weightV;        // 0x98
        private UnityEngine.Vector3 lastPosition;        // 0x9C
        private UnityEngine.Vector3 dir;        // 0xA8
        private System.Boolean lastSmoothTowardsTarget;        // 0xB4
        private System.Boolean turningToTarget;        // 0xB5
        private System.Single turnToTargetMlp;        // 0xB8
        private System.Single turnToTargetMlpV;        // 0xBC
        private System.Single yawV;        // 0xC0
        private System.Single pitchV;        // 0xC4
        private System.Single dirMagV;        // 0xC8

        // Methods
        private System.Void Start() { }
        private System.Void LateUpdate() { }
        private UnityEngine.Vector3 get_pivot() { }
        private System.Void ApplyMinDistance() { }
        private System.Void RootRotation() { }
        private System.Collections.IEnumerator TurnToTarget() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B3
    public class AimPoser : MonoBehaviour
    {
        // Fields
        public System.Single angleBuffer;        // 0x18
        public RootMotion.FinalIK.AimPoser.Pose[] poses;        // 0x20

        // Methods
        private RootMotion.FinalIK.AimPoser.Pose GetPose(UnityEngine.Vector3 localDirection) { }
        private System.Void SetPoseActive(RootMotion.FinalIK.AimPoser.Pose pose) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B5
    public class Amplifier : OffsetModifier
    {
        // Fields
        public RootMotion.FinalIK.Amplifier.Body[] bodies;        // 0x30

        // Methods
        private System.Void OnModifyOffset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B8
    public class BodyTilt : OffsetModifier
    {
        // Fields
        public System.Single tiltSpeed;        // 0x30
        public System.Single tiltSensitivity;        // 0x34
        public RootMotion.FinalIK.OffsetPose poseLeft;        // 0x38
        public RootMotion.FinalIK.OffsetPose poseRight;        // 0x40
        private System.Single tiltAngle;        // 0x48
        private UnityEngine.Vector3 lastForward;        // 0x4C

        // Methods
        private System.Void Start() { }
        private System.Void OnModifyOffset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B9
    public class CCDBendGoal : MonoBehaviour
    {
        // Fields
        public RootMotion.FinalIK.CCDIK ik;        // 0x18
        public System.Single weight;        // 0x20

        // Methods
        private System.Void Start() { }
        private System.Void BeforeIK() { }
        private System.Void OnDestroy() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BA
    public class EditorIK : MonoBehaviour
    {
        // Fields
        public UnityEngine.Animator animator;        // 0x18
        public RootMotion.FinalIK.EditorIKPose defaultPose;        // 0x20
        public UnityEngine.Transform[] bones;        // 0x28
        private RootMotion.FinalIK.IK <ik>k__BackingField;        // 0x30

        // Methods
        private RootMotion.FinalIK.IK get_ik() { }
        private System.Void set_ik(RootMotion.FinalIK.IK value) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void StoreDefaultPose() { }
        private System.Boolean Initiate() { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BB
    public class EditorIKPose : ScriptableObject
    {
        // Fields
        public UnityEngine.Vector3[] localPositions;        // 0x18
        public UnityEngine.Quaternion[] localRotations;        // 0x20

        // Methods
        private System.Boolean get_poseStored() { }
        private System.Void Store(UnityEngine.Transform[] T) { }
        private System.Boolean Restore(UnityEngine.Transform[] T) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BC
    public class HitReaction : OffsetModifier
    {
        // Fields
        public RootMotion.FinalIK.HitReaction.HitPointEffector[] effectorHitPoints;        // 0x30
        public RootMotion.FinalIK.HitReaction.HitPointBone[] boneHitPoints;        // 0x38

        // Methods
        private System.Boolean get_inProgress() { }
        private System.Void OnModifyOffset() { }
        private System.Void Hit(UnityEngine.Collider collider, UnityEngine.Vector3 force, UnityEngine.Vector3 point) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C2
    public class HitReactionVRIK : OffsetModifierVRIK
    {
        // Fields
        public UnityEngine.AnimationCurve[] offsetCurves;        // 0x30
        public RootMotion.FinalIK.HitReactionVRIK.PositionOffset[] positionOffsets;        // 0x38
        public RootMotion.FinalIK.HitReactionVRIK.RotationOffset[] rotationOffsets;        // 0x40

        // Methods
        private System.Void OnModifyOffset() { }
        private System.Void Hit(UnityEngine.Collider collider, UnityEngine.Vector3 force, UnityEngine.Vector3 point) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C8
    public class Inertia : OffsetModifier
    {
        // Fields
        public RootMotion.FinalIK.Inertia.Body[] bodies;        // 0x30
        public RootMotion.FinalIK.OffsetModifier.OffsetLimits[] limits;        // 0x38

        // Methods
        private System.Void ResetBodies() { }
        private System.Void OnModifyOffset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CB
    public class LookAtController : MonoBehaviour
    {
        // Fields
        public RootMotion.FinalIK.LookAtIK ik;        // 0x18
        public UnityEngine.Transform target;        // 0x20
        public System.Single weight;        // 0x28
        public UnityEngine.Vector3 offset;        // 0x2C
        public System.Single targetSwitchSmoothTime;        // 0x38
        public System.Single weightSmoothTime;        // 0x3C
        public System.Boolean smoothTurnTowardsTarget;        // 0x40
        public System.Single maxRadiansDelta;        // 0x44
        public System.Single maxMagnitudeDelta;        // 0x48
        public System.Single slerpSpeed;        // 0x4C
        public UnityEngine.Vector3 pivotOffsetFromRoot;        // 0x50
        public System.Single minDistance;        // 0x5C
        public System.Single maxRootAngle;        // 0x60
        private UnityEngine.Transform lastTarget;        // 0x68
        private System.Single switchWeight;        // 0x70
        private System.Single switchWeightV;        // 0x74
        private System.Single weightV;        // 0x78
        private UnityEngine.Vector3 lastPosition;        // 0x7C
        private UnityEngine.Vector3 dir;        // 0x88
        private System.Boolean lastSmoothTowardsTarget;        // 0x94

        // Methods
        private System.Void Start() { }
        private System.Void LateUpdate() { }
        private UnityEngine.Vector3 get_pivot() { }
        private System.Void ApplyMinDistance() { }
        private System.Void RootRotation() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CC
    public class OffsetModifier : MonoBehaviour
    {
        // Fields
        public System.Single weight;        // 0x18
        public RootMotion.FinalIK.FullBodyBipedIK ik;        // 0x20
        protected System.Single lastTime;        // 0x28

        // Methods
        private System.Single get_deltaTime() { }
        private System.Void OnModifyOffset() { }
        private System.Void Start() { }
        private System.Collections.IEnumerator Initiate() { }
        private System.Void ModifyOffset() { }
        private System.Void ApplyLimits(RootMotion.FinalIK.OffsetModifier.OffsetLimits[] limits) { }
        private System.Void OnDestroy() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CF
    public class OffsetModifierVRIK : MonoBehaviour
    {
        // Fields
        public System.Single weight;        // 0x18
        public RootMotion.FinalIK.VRIK ik;        // 0x20
        private System.Single lastTime;        // 0x28

        // Methods
        private System.Single get_deltaTime() { }
        private System.Void OnModifyOffset() { }
        private System.Void Start() { }
        private System.Collections.IEnumerator Initiate() { }
        private System.Void ModifyOffset() { }
        private System.Void OnDestroy() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D1
    public class OffsetPose : MonoBehaviour
    {
        // Fields
        public RootMotion.FinalIK.OffsetPose.EffectorLink[] effectorLinks;        // 0x18

        // Methods
        private System.Void Apply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, System.Single weight) { }
        private System.Void Apply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, System.Single weight, UnityEngine.Quaternion rotation) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D3
    public class PenetrationAvoidance : OffsetModifier
    {
        // Fields
        public RootMotion.FinalIK.PenetrationAvoidance.Avoider[] avoiders;        // 0x30

        // Methods
        private System.Void OnModifyOffset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D6
    public class Recoil : OffsetModifier
    {
        // Fields
        public RootMotion.FinalIK.AimIK aimIK;        // 0x30
        public RootMotion.FinalIK.AimIK headIK;        // 0x38
        public System.Boolean aimIKSolvedLast;        // 0x40
        public RootMotion.FinalIK.Recoil.Handedness handedness;        // 0x44
        public System.Boolean twoHanded;        // 0x48
        public UnityEngine.AnimationCurve recoilWeight;        // 0x50
        public System.Single magnitudeRandom;        // 0x58
        public UnityEngine.Vector3 rotationRandom;        // 0x5C
        public UnityEngine.Vector3 handRotationOffset;        // 0x68
        public System.Single blendTime;        // 0x74
        public RootMotion.FinalIK.Recoil.RecoilOffset[] offsets;        // 0x78
        public UnityEngine.Quaternion rotationOffset;        // 0x80
        private System.Single magnitudeMlp;        // 0x90
        private System.Single endTime;        // 0x94
        private UnityEngine.Quaternion handRotation;        // 0x98
        private UnityEngine.Quaternion secondaryHandRelativeRotation;        // 0xA8
        private UnityEngine.Quaternion randomRotation;        // 0xB8
        private System.Single length;        // 0xC8
        private System.Boolean initiated;        // 0xCC
        private System.Single blendWeight;        // 0xD0
        private System.Single w;        // 0xD4
        private UnityEngine.Quaternion primaryHandRotation;        // 0xD8
        private System.Boolean handRotationsSet;        // 0xE8
        private UnityEngine.Vector3 aimIKAxis;        // 0xEC

        // Methods
        private System.Boolean get_isFinished() { }
        private System.Void SetHandRotations(UnityEngine.Quaternion leftHandRotation, UnityEngine.Quaternion rightHandRotation) { }
        private System.Void Fire(System.Single magnitude) { }
        private System.Void OnModifyOffset() { }
        private System.Void AfterFBBIK() { }
        private System.Void AfterAimIK() { }
        private RootMotion.FinalIK.IKEffector get_primaryHandEffector() { }
        private RootMotion.FinalIK.IKEffector get_secondaryHandEffector() { }
        private UnityEngine.Transform get_primaryHand() { }
        private UnityEngine.Transform get_secondaryHand() { }
        private System.Void OnDestroy() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DA
    public class ShoulderRotator : MonoBehaviour
    {
        // Fields
        public System.Single weight;        // 0x18
        public System.Single offset;        // 0x1C
        private RootMotion.FinalIK.FullBodyBipedIK ik;        // 0x20
        private System.Boolean skip;        // 0x28

        // Methods
        private System.Void Start() { }
        private System.Void RotateShoulders() { }
        private System.Void RotateShoulder(RootMotion.FinalIK.FullBodyBipedChain chain, System.Single weight, System.Single offset) { }
        private RootMotion.FinalIK.IKMapping.BoneMap GetParentBoneMap(RootMotion.FinalIK.FullBodyBipedChain chain) { }
        private System.Void OnDestroy() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DB
    public class VRIKCalibrator
    {
        // Methods
        private System.Void RecalibrateScale(RootMotion.FinalIK.VRIK ik, RootMotion.FinalIK.VRIKCalibrator.CalibrationData data, RootMotion.FinalIK.VRIKCalibrator.Settings settings) { }
        private System.Void RecalibrateScale(RootMotion.FinalIK.VRIK ik, RootMotion.FinalIK.VRIKCalibrator.CalibrationData data, System.Single scaleMlp) { }
        private System.Void CalibrateScale(RootMotion.FinalIK.VRIK ik, RootMotion.FinalIK.VRIKCalibrator.Settings settings) { }
        private System.Void CalibrateScale(RootMotion.FinalIK.VRIK ik, System.Single scaleMlp) { }
        private RootMotion.FinalIK.VRIKCalibrator.CalibrationData Calibrate(RootMotion.FinalIK.VRIK ik, RootMotion.FinalIK.VRIKCalibrator.Settings settings, UnityEngine.Transform headTracker, UnityEngine.Transform bodyTracker, UnityEngine.Transform leftHandTracker, UnityEngine.Transform rightHandTracker, UnityEngine.Transform leftFootTracker, UnityEngine.Transform rightFootTracker) { }
        private System.Void CalibrateLeg(RootMotion.FinalIK.VRIKCalibrator.Settings settings, UnityEngine.Transform tracker, RootMotion.FinalIK.IKSolverVR.Leg leg, UnityEngine.Transform lastBone, UnityEngine.Vector3 rootForward, System.Boolean isLeft) { }
        private System.Void Calibrate(RootMotion.FinalIK.VRIK ik, RootMotion.FinalIK.VRIKCalibrator.CalibrationData data, UnityEngine.Transform headTracker, UnityEngine.Transform bodyTracker, UnityEngine.Transform leftHandTracker, UnityEngine.Transform rightHandTracker, UnityEngine.Transform leftFootTracker, UnityEngine.Transform rightFootTracker) { }
        private System.Void CalibrateLeg(RootMotion.FinalIK.VRIKCalibrator.CalibrationData data, UnityEngine.Transform tracker, RootMotion.FinalIK.IKSolverVR.Leg leg, UnityEngine.Transform lastBone, UnityEngine.Vector3 rootForward, System.Boolean isLeft) { }
        private RootMotion.FinalIK.VRIKCalibrator.CalibrationData Calibrate(RootMotion.FinalIK.VRIK ik, UnityEngine.Transform centerEyeAnchor, UnityEngine.Transform leftHandAnchor, UnityEngine.Transform rightHandAnchor, UnityEngine.Vector3 centerEyePositionOffset, UnityEngine.Vector3 centerEyeRotationOffset, UnityEngine.Vector3 handPositionOffset, UnityEngine.Vector3 handRotationOffset, System.Single scaleMlp) { }
        private System.Void CalibrateHead(RootMotion.FinalIK.VRIK ik, UnityEngine.Transform centerEyeAnchor, UnityEngine.Vector3 anchorPositionOffset, UnityEngine.Vector3 anchorRotationOffset) { }
        private System.Void CalibrateBody(RootMotion.FinalIK.VRIK ik, UnityEngine.Transform pelvisTracker, UnityEngine.Vector3 trackerPositionOffset, UnityEngine.Vector3 trackerRotationOffset) { }
        private System.Void CalibrateHands(RootMotion.FinalIK.VRIK ik, UnityEngine.Transform leftHandAnchor, UnityEngine.Transform rightHandAnchor, UnityEngine.Vector3 anchorPositionOffset, UnityEngine.Vector3 anchorRotationOffset) { }
        private System.Void CalibrateHand(RootMotion.FinalIK.VRIK ik, UnityEngine.Transform anchor, UnityEngine.Vector3 positionOffset, UnityEngine.Vector3 rotationOffset, System.Boolean isLeft) { }
        private UnityEngine.Vector3 GuessWristToPalmAxis(UnityEngine.Transform hand, UnityEngine.Transform forearm) { }
        private UnityEngine.Vector3 GuessPalmToThumbAxis(UnityEngine.Transform hand, UnityEngine.Transform forearm) { }

    }

    // TypeToken: 0x20000DF
    public class VRIKLODController : MonoBehaviour
    {
        // Fields
        public UnityEngine.Renderer LODRenderer;        // 0x18
        public System.Single LODDistance;        // 0x20
        public System.Boolean allowCulled;        // 0x24
        private RootMotion.FinalIK.VRIK ik;        // 0x28

        // Methods
        private System.Void Start() { }
        private System.Void Update() { }
        private System.Int32 GetLODLevel() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E0
    public class VRIKRootController : MonoBehaviour
    {
        // Fields
        private UnityEngine.Vector3 <pelvisTargetRight>k__BackingField;        // 0x18
        private UnityEngine.Transform pelvisTarget;        // 0x28
        private UnityEngine.Transform leftFootTarget;        // 0x30
        private UnityEngine.Transform rightFootTarget;        // 0x38
        private RootMotion.FinalIK.VRIK ik;        // 0x40

        // Methods
        private UnityEngine.Vector3 get_pelvisTargetRight() { }
        private System.Void set_pelvisTargetRight(UnityEngine.Vector3 value) { }
        private System.Void Awake() { }
        private System.Void Calibrate() { }
        private System.Void Calibrate(RootMotion.FinalIK.VRIKCalibrator.CalibrationData data) { }
        private System.Void OnPreUpdate() { }
        private System.Void OnDestroy() { }
        private System.Void .ctor() { }

    }

}

