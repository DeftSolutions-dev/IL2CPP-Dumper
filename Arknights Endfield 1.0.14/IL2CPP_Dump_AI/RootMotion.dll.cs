// ========================================================
// Dumped by @desirepro
// Assembly: RootMotion.dll
// Classes:  226
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: Mode
TYPE:  struct
TOKEN: 0x2000003
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  RootMotion.Baker.Mode           AnimationClips  // 0x0
  public    static  RootMotion.Baker.Mode           AnimationStates  // 0x0
  public    static  RootMotion.Baker.Mode           PlayableDirector  // 0x0
  public    static  RootMotion.Baker.Mode           Realtime  // 0x0
METHODS:
END_CLASS

CLASS: BakerDelegate
TYPE:  class
TOKEN: 0x2000004
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.AnimationClip clip, System.Single time)
  System.IAsyncResult BeginInvoke(UnityEngine.AnimationClip clip, System.Single time, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: BasedUponRotation
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  RootMotion.Baker.ClipSettings.BasedUponRotationOriginal  // 0x0
  public    static  RootMotion.Baker.ClipSettings.BasedUponRotationBodyOrientation  // 0x0
METHODS:
END_CLASS

CLASS: BasedUponY
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  RootMotion.Baker.ClipSettings.BasedUponYOriginal  // 0x0
  public    static  RootMotion.Baker.ClipSettings.BasedUponYCenterOfMass  // 0x0
  public    static  RootMotion.Baker.ClipSettings.BasedUponYFeet  // 0x0
METHODS:
END_CLASS

CLASS: BasedUponXZ
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  RootMotion.Baker.ClipSettings.BasedUponXZOriginal  // 0x0
  public    static  RootMotion.Baker.ClipSettings.BasedUponXZCenterOfMass  // 0x0
METHODS:
END_CLASS

CLASS: ClipSettings
TYPE:  class
TOKEN: 0x2000005
FIELDS:
  public            System.Boolean                  loopTime  // 0x10
  public            System.Boolean                  loopBlend  // 0x11
  public            System.Single                   cycleOffset  // 0x14
  public            System.Boolean                  loopBlendOrientation  // 0x18
  public            RootMotion.Baker.ClipSettings.BasedUponRotationbasedUponRotation  // 0x1C
  public            System.Single                   orientationOffsetY  // 0x20
  public            System.Boolean                  loopBlendPositionY  // 0x24
  public            RootMotion.Baker.ClipSettings.BasedUponYbasedUponY  // 0x28
  public            System.Single                   level  // 0x2C
  public            System.Boolean                  loopBlendPositionXZ  // 0x30
  public            RootMotion.Baker.ClipSettings.BasedUponXZbasedUponXZ  // 0x34
  public            System.Boolean                  mirror  // 0x38
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: LimbOrientation
TYPE:  class
TOKEN: 0x2000014
FIELDS:
  public            UnityEngine.Vector3             upperBoneForwardAxis  // 0x10
  public            UnityEngine.Vector3             lowerBoneForwardAxis  // 0x1C
  public            UnityEngine.Vector3             lastBoneLeftAxis  // 0x28
METHODS:
  System.Void .ctor(UnityEngine.Vector3 upperBoneForwardAxis, UnityEngine.Vector3 lowerBoneForwardAxis, UnityEngine.Vector3 lastBoneLeftAxis)
END_CLASS

CLASS: BoneType
TYPE:  struct
TOKEN: 0x2000016
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  RootMotion.BipedNaming.BoneType Unassigned  // 0x0
  public    static  RootMotion.BipedNaming.BoneType Spine  // 0x0
  public    static  RootMotion.BipedNaming.BoneType Head  // 0x0
  public    static  RootMotion.BipedNaming.BoneType Arm  // 0x0
  public    static  RootMotion.BipedNaming.BoneType Leg  // 0x0
  public    static  RootMotion.BipedNaming.BoneType Tail  // 0x0
  public    static  RootMotion.BipedNaming.BoneType Eye  // 0x0
METHODS:
END_CLASS

CLASS: BoneSide
TYPE:  struct
TOKEN: 0x2000017
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  RootMotion.BipedNaming.BoneSide Center  // 0x0
  public    static  RootMotion.BipedNaming.BoneSide Left  // 0x0
  public    static  RootMotion.BipedNaming.BoneSide Right  // 0x0
METHODS:
END_CLASS

CLASS: AutoDetectParams
TYPE:  struct
TOKEN: 0x2000019
FIELDS:
  public            System.Boolean                  legsParentInSpine  // 0x10
  public            System.Boolean                  includeEyes  // 0x11
METHODS:
  System.Void .ctor(System.Boolean legsParentInSpine, System.Boolean includeEyes)
  RootMotion.BipedReferences.AutoDetectParams get_Default()
END_CLASS

CLASS: Logger
TYPE:  class
TOKEN: 0x200002E
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.String message)
  System.IAsyncResult BeginInvoke(System.String message, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: State
TYPE:  struct
TOKEN: 0x2000030
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  RootMotion.Demos.Navigator.StateIdle  // 0x0
  public    static  RootMotion.Demos.Navigator.StateSeeking  // 0x0
  public    static  RootMotion.Demos.Navigator.StateOnPath  // 0x0
METHODS:
END_CLASS

CLASS: DOF
TYPE:  struct
TOKEN: 0x200003A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  RootMotion.FinalIK.Finger.DOF   One  // 0x0
  public    static  RootMotion.FinalIK.Finger.DOF   Three  // 0x0
METHODS:
END_CLASS

CLASS: GrounderDelegate
TYPE:  class
TOKEN: 0x200003D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
  System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: SpineEffector
TYPE:  class
TOKEN: 0x2000040
FIELDS:
  public            RootMotion.FinalIK.FullBodyBipedEffectoreffectorType  // 0x10
  public            System.Single                   horizontalWeight  // 0x14
  public            System.Single                   verticalWeight  // 0x18
METHODS:
  System.Void .ctor()
  System.Void .ctor(RootMotion.FinalIK.FullBodyBipedEffector effectorType, System.Single horizontalWeight, System.Single verticalWeight)
END_CLASS

CLASS: Foot
TYPE:  struct
TOKEN: 0x2000043
FIELDS:
  public            RootMotion.FinalIK.IKSolver     solver  // 0x10
  public            UnityEngine.Transform           transform  // 0x18
  public            UnityEngine.Quaternion          rotation  // 0x20
  public            RootMotion.FinalIK.Grounding.Legleg  // 0x30
METHODS:
  System.Void .ctor(RootMotion.FinalIK.IKSolver solver, UnityEngine.Transform transform)
END_CLASS

CLASS: Quality
TYPE:  struct
TOKEN: 0x2000045
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  RootMotion.FinalIK.Grounding.QualityFastest  // 0x0
  public    static  RootMotion.FinalIK.Grounding.QualitySimple  // 0x0
  public    static  RootMotion.FinalIK.Grounding.QualityBest  // 0x0
  public    static  RootMotion.FinalIK.Grounding.QualityCustom  // 0x0
METHODS:
END_CLASS

CLASS: OnRaycastDelegate
TYPE:  class
TOKEN: 0x2000046
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.IAsyncResult BeginInvoke(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction, System.AsyncCallback callback, System.Object object)
  System.Boolean EndInvoke(UnityEngine.RaycastHit& hitInfo, System.IAsyncResult result)
END_CLASS

CLASS: OnCapsuleCastDelegate
TYPE:  class
TOKEN: 0x2000047
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.IAsyncResult BeginInvoke(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction, System.AsyncCallback callback, System.Object object)
  System.Boolean EndInvoke(UnityEngine.RaycastHit& hitInfo, System.IAsyncResult result)
END_CLASS

CLASS: OnSphereCastDelegate
TYPE:  class
TOKEN: 0x2000048
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
  System.IAsyncResult BeginInvoke(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction, System.AsyncCallback callback, System.Object object)
  System.Boolean EndInvoke(UnityEngine.RaycastHit& hitInfo, System.IAsyncResult result)
END_CLASS

CLASS: Leg
TYPE:  class
TOKEN: 0x2000049
FIELDS:
  private           System.Boolean                  <isGrounded>k__BackingField  // 0x10
  private           UnityEngine.Vector3             <IKPosition>k__BackingField  // 0x14
  public            UnityEngine.Quaternion          rotationOffset  // 0x20
  private           System.Boolean                  <initiated>k__BackingField  // 0x30
  private           System.Single                   <heightFromGround>k__BackingField  // 0x34
  private           System.Single                   <fowardMoveFromGround>k__BackingField  // 0x38
  private           System.Single                   <rightMoveFromGround>k__BackingField  // 0x3C
  private           UnityEngine.Vector3             <velocity>k__BackingField  // 0x40
  private           UnityEngine.Transform           <transform>k__BackingField  // 0x50
  private           System.Single                   <IKOffset>k__BackingField  // 0x58
  private           System.Single                   <IKOffsetZ>k__BackingField  // 0x5C
  private           System.Single                   <IKOffsetX>k__BackingField  // 0x60
  private           UnityEngine.RaycastHit          <heelHit>k__BackingField  // 0x68
  private           UnityEngine.RaycastHit          <capsuleHit>k__BackingField  // 0xA8
  public            System.Boolean                  invertFootCenter  // 0xE8
  private           UnityEngine.Vector3             m_lastEntityPos  // 0xEC
  private           UnityEngine.Vector3             m_lastFootPos  // 0xF8
  private           UnityEngine.Vector3             m_lastHeelPoint  // 0x104
  private           UnityEngine.Vector3             m_lastToePoint  // 0x110
  private           UnityEngine.Vector3             m_lastSidePoint  // 0x11C
  private           RootMotion.FinalIK.Grounding    grounding  // 0x128
  private           System.Single                   lastTime  // 0x130
  private           System.Single                   deltaTime  // 0x134
  private           UnityEngine.Vector3             lastPosition  // 0x138
  private           UnityEngine.Quaternion          toHitNormal  // 0x144
  private           UnityEngine.Quaternion          r  // 0x154
  private           UnityEngine.Vector3             up  // 0x164
  private           UnityEngine.Vector3             forward  // 0x170
  private           UnityEngine.Vector3             speedDir  // 0x17C
  private           UnityEngine.Vector3             lastTransformPosition  // 0x188
  private           System.Boolean                  doOverrideFootPosition  // 0x194
  private           UnityEngine.Vector3             overrideFootPosition  // 0x198
  public            UnityEngine.Vector3             transformPosition  // 0x1A4
  private   static readonly Unity.Profiling.ProfilerMarker  MARKER_TEMP_PREDICT_FOOT_CAST  // 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  MARKER_TEMP_BUILTIN_BEST_CAST  // 0x8
  public    static  System.Single                   MAX_PREDICTION_DISTANCE  // 0x0
  private           UnityEngine.Vector2             lastFramePredictPos  // 0x1B0
  public            UnityEngine.Vector3             predictOffset  // 0x1B8
  public            UnityEngine.Vector3             lastPredictOffset  // 0x1C4
  public            UnityEngine.Vector3             lastPredictOffsetwithPercent  // 0x1D0
  private           UnityEngine.Vector3             m_predictOffsetwithPercent  // 0x1DC
  private           System.Boolean                  hasPredictThisStep  // 0x1E8
  public            UnityEngine.RaycastHit          curPredictHit  // 0x1F0
  public            System.Single                   curStepTime  // 0x230
  public            UnityEngine.RaycastHit          curCapsuleHit  // 0x238
  public            UnityEngine.Vector3             lastLandFootPos  // 0x278
  private           System.Single                   feetOffsetFromRoot  // 0x284
  public            UnityEngine.Vector3             lastPathPoint  // 0x288
  public            UnityEngine.RaycastHit          m_heelHit  // 0x298
  public            UnityEngine.Vector3             curFeetCalculatePos  // 0x2D8
  private           UnityEngine.Vector3             lastCurHitPoint  // 0x2E4
  public            UnityEngine.Vector3             predictLimitForwardOffset  // 0x2F0
  private           System.Single                   m_maxStep  // 0x2FC
  private           UnityEngine.Vector3             m_lastHitNormal  // 0x300
  private           System.Boolean                  m_isInStair  // 0x30C
  public            System.Single                   footSpeed  // 0x310
  public            System.Single                   heightFromRoot  // 0x314
  public            System.Boolean                  isLastFrameLegStretch  // 0x318
  private           UnityEngine.Vector3             lastCapusuleHitPos  // 0x31C
METHODS:
  System.Boolean get_isGrounded()
  System.Void set_isGrounded(System.Boolean value)
  UnityEngine.Vector3 get_IKPosition()
  System.Void set_IKPosition(UnityEngine.Vector3 value)
  System.Boolean get_initiated()
  System.Void set_initiated(System.Boolean value)
  System.Single get_heightFromGround()
  System.Void set_heightFromGround(System.Single value)
  System.Single get_fowardMoveFromGround()
  System.Void set_fowardMoveFromGround(System.Single value)
  System.Single get_rightMoveFromGround()
  System.Void set_rightMoveFromGround(System.Single value)
  UnityEngine.Vector3 get_velocity()
  System.Void set_velocity(UnityEngine.Vector3 value)
  UnityEngine.Transform get_transform()
  System.Void set_transform(UnityEngine.Transform value)
  System.Single get_IKOffset()
  System.Void set_IKOffset(System.Single value)
  System.Single get_IKOffsetZ()
  System.Void set_IKOffsetZ(System.Single value)
  System.Single get_IKOffsetX()
  System.Void set_IKOffsetX(System.Single value)
  UnityEngine.RaycastHit get_heelHit()
  System.Void set_heelHit(UnityEngine.RaycastHit value)
  UnityEngine.RaycastHit get_capsuleHit()
  System.Void set_capsuleHit(UnityEngine.RaycastHit value)
  UnityEngine.RaycastHit get_GetHitPoint()
  System.Void SetFootPosition(UnityEngine.Vector3 position)
  UnityEngine.Vector3 get_right()
  UnityEngine.Vector3 get_speedRight()
  System.Void Initiate(RootMotion.FinalIK.Grounding grounding, UnityEngine.Transform transform)
  System.Void OnEnable()
  System.Void Reset()
  UnityEngine.Vector3 get_predictOffsetwithPercent()
  System.Void _ResetPredictReference(UnityEngine.RaycastHit curHit)
  System.Void _PredictNextStepHit(UnityEngine.Vector3 prediction, UnityEngine.Vector3 predictVec, System.Boolean canChangeHeight)
  System.Single _CanHitPointLand(UnityEngine.RaycastHit hit, UnityEngine.RaycastHit& predictHit)
  System.Boolean get_isLeft()
  System.Boolean get_isMoving()
  System.Void Process()
  System.Void _UpdateHeelHit(System.Single curStepPercent, UnityEngine.Vector3 prediction)
  UnityEngine.Vector3 _UpdatePredictOffset(System.Single curStepPercent)
  System.Void FinalSetIKPosition(UnityEngine.Vector3 thighPos)
  System.Single get_stepHeightFromGround()
  System.Single get_stepForwardFromGround()
  System.Single get_stepRightFromGround()
  UnityEngine.RaycastHit GetCapsuleHit(UnityEngine.Vector3 offsetFromHeel, UnityEngine.Vector3 predictPos)
  UnityEngine.RaycastHit GetCapsuleHit(UnityEngine.Vector3 offsetFromHeel)
  UnityEngine.RaycastHit GetRaycastHitCustom(UnityEngine.Vector3 offsetFromHeel)
  UnityEngine.RaycastHit GetRaycastHit(UnityEngine.Vector3 offsetFromHeel)
  UnityEngine.Vector3 RotateNormal(UnityEngine.Vector3 normal)
  System.Void SetFootToPoint(UnityEngine.Vector3 normal, UnityEngine.Vector3 point)
  System.Void SetFootToPlane(UnityEngine.Vector3 planeNormal, UnityEngine.Vector3 planePoint, UnityEngine.Vector3 heelHitPoint)
  System.Void SetFootToPoint(UnityEngine.Vector3 normal, UnityEngine.Vector3 pointForXZ, UnityEngine.Vector3 pointForY)
  System.Void SetFootToPlane(UnityEngine.Vector3 planeNormal, UnityEngine.Vector3 planePoint, UnityEngine.Vector3 heelHitPoint, UnityEngine.Vector3 footNormal, System.Boolean isLimitByComplex)
  System.Single GetHeightFromGround(UnityEngine.Vector3 hitPoint)
  System.Void RotateFoot()
  UnityEngine.Quaternion GetRotationOffsetTarget()
  UnityEngine.Vector3 get_animFootGroundPos()
  System.Single get_rootYOffset()
  UnityEngine.Vector3 RotateNormalWithLimit(UnityEngine.Vector3 normal)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Pelvis
TYPE:  class
TOKEN: 0x200004A
FIELDS:
  private           UnityEngine.Vector3             <IKOffset>k__BackingField  // 0x10
  private           System.Single                   <heightOffset>k__BackingField  // 0x1C
  private           System.Single                   forwardOffset  // 0x20
  public            System.Single                   pelivsSpeedY  // 0x24
  private           RootMotion.FinalIK.Grounding    grounding  // 0x28
  private           UnityEngine.Vector3             lastRootPosition  // 0x30
  private           System.Single                   damperF  // 0x3C
  private           System.Boolean                  initiated  // 0x40
  private           System.Single                   lastTime  // 0x44
METHODS:
  UnityEngine.Vector3 get_IKOffset()
  System.Void set_IKOffset(UnityEngine.Vector3 value)
  System.Single get_heightOffset()
  System.Void set_heightOffset(System.Single value)
  System.Void Initiate(RootMotion.FinalIK.Grounding grounding)
  System.Void Reset()
  System.Void OnEnable()
  System.Void Process(System.Single pelivsOffset, System.Single _forwardOffset, System.Boolean isGrounded, System.Boolean islastFrameLegStretch, System.Boolean isSameLegReflastFrame)
  UnityEngine.RaycastHit GetRaycastHitCustom(UnityEngine.Vector3 rayOrigin)
  System.Void .ctor()
END_CLASS

CLASS: References
TYPE:  class
TOKEN: 0x2000058
FIELDS:
  public            UnityEngine.Transform           root  // 0x10
  public            UnityEngine.Transform           pelvis  // 0x18
  public            UnityEngine.Transform           spine  // 0x20
  public            UnityEngine.Transform           chest  // 0x28
  public            UnityEngine.Transform           neck  // 0x30
  public            UnityEngine.Transform           head  // 0x38
  public            UnityEngine.Transform           leftShoulder  // 0x40
  public            UnityEngine.Transform           leftUpperArm  // 0x48
  public            UnityEngine.Transform           leftForearm  // 0x50
  public            UnityEngine.Transform           leftHand  // 0x58
  public            UnityEngine.Transform           rightShoulder  // 0x60
  public            UnityEngine.Transform           rightUpperArm  // 0x68
  public            UnityEngine.Transform           rightForearm  // 0x70
  public            UnityEngine.Transform           rightHand  // 0x78
  public            UnityEngine.Transform           leftThigh  // 0x80
  public            UnityEngine.Transform           leftCalf  // 0x88
  public            UnityEngine.Transform           leftFoot  // 0x90
  public            UnityEngine.Transform           leftToes  // 0x98
  public            UnityEngine.Transform           rightThigh  // 0xA0
  public            UnityEngine.Transform           rightCalf  // 0xA8
  public            UnityEngine.Transform           rightFoot  // 0xB0
  public            UnityEngine.Transform           rightToes  // 0xB8
METHODS:
  System.Void .ctor()
  System.Void .ctor(RootMotion.BipedReferences b)
  UnityEngine.Transform[] GetTransforms()
  System.Boolean get_isFilled()
  System.Boolean get_isEmpty()
  System.Boolean AutoDetectReferences(UnityEngine.Transform root, RootMotion.FinalIK.VRIK.References& references)
END_CLASS

CLASS: BendBone
TYPE:  class
TOKEN: 0x200005C
FIELDS:
  public            UnityEngine.Transform           transform  // 0x10
  public            System.Single                   weight  // 0x18
  private           UnityEngine.Quaternion          defaultLocalRotation  // 0x1C
METHODS:
  System.Void .ctor()
  System.Void .ctor(UnityEngine.Transform transform, System.Single weight)
  System.Void StoreDefaultLocalState()
  System.Void FixTransforms()
END_CLASS

CLASS: ChildConstraint
TYPE:  class
TOKEN: 0x200005E
FIELDS:
  public            System.Single                   pushElasticity  // 0x10
  public            System.Single                   pullElasticity  // 0x14
  private           UnityEngine.Transform           bone1  // 0x18
  private           UnityEngine.Transform           bone2  // 0x20
  private           System.Single                   <nominalDistance>k__BackingField  // 0x28
  private           System.Boolean                  <isRigid>k__BackingField  // 0x2C
  private           System.Single                   crossFade  // 0x30
  private           System.Single                   inverseCrossFade  // 0x34
  private           System.Int32                    chain1Index  // 0x38
  private           System.Int32                    chain2Index  // 0x3C
METHODS:
  System.Single get_nominalDistance()
  System.Void set_nominalDistance(System.Single value)
  System.Boolean get_isRigid()
  System.Void set_isRigid(System.Boolean value)
  System.Void .ctor(UnityEngine.Transform bone1, UnityEngine.Transform bone2, System.Single pushElasticity, System.Single pullElasticity)
  System.Void Initiate(RootMotion.FinalIK.IKSolverFullBody solver)
  System.Void OnPreSolve(RootMotion.FinalIK.IKSolverFullBody solver)
  System.Void Solve(RootMotion.FinalIK.IKSolverFullBody solver)
END_CLASS

CLASS: Smoothing
TYPE:  struct
TOKEN: 0x200005F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  RootMotion.FinalIK.FBIKChain.SmoothingNone  // 0x0
  public    static  RootMotion.FinalIK.FBIKChain.SmoothingExponential  // 0x0
  public    static  RootMotion.FinalIK.FBIKChain.SmoothingCubic  // 0x0
METHODS:
END_CLASS

CLASS: BoneMap
TYPE:  class
TOKEN: 0x2000063
FIELDS:
  public            UnityEngine.Transform           transform  // 0x10
  public            System.Int32                    chainIndex  // 0x18
  public            System.Int32                    nodeIndex  // 0x1C
  public            UnityEngine.Vector3             defaultLocalPosition  // 0x20
  public            UnityEngine.Quaternion          defaultLocalRotation  // 0x2C
  public            UnityEngine.Vector3             localSwingAxis  // 0x3C
  public            UnityEngine.Vector3             localTwistAxis  // 0x48
  public            UnityEngine.Vector3             planePosition  // 0x54
  public            UnityEngine.Vector3             ikPosition  // 0x60
  public            UnityEngine.Quaternion          defaultLocalTargetRotation  // 0x6C
  private           UnityEngine.Quaternion          maintainRotation  // 0x7C
  public            System.Single                   length  // 0x8C
  public            UnityEngine.Quaternion          animatedRotation  // 0x90
  private           UnityEngine.Transform           planeBone1  // 0xA0
  private           UnityEngine.Transform           planeBone2  // 0xA8
  private           UnityEngine.Transform           planeBone3  // 0xB0
  private           System.Int32                    plane1ChainIndex  // 0xB8
  private           System.Int32                    plane1NodeIndex  // 0xBC
  private           System.Int32                    plane2ChainIndex  // 0xC0
  private           System.Int32                    plane2NodeIndex  // 0xC4
  private           System.Int32                    plane3ChainIndex  // 0xC8
  private           System.Int32                    plane3NodeIndex  // 0xCC
METHODS:
  System.Void Initiate(UnityEngine.Transform transform, RootMotion.FinalIK.IKSolverFullBody solver)
  UnityEngine.Vector3 get_swingDirection()
  System.Void StoreDefaultLocalState()
  System.Void FixTransform(System.Boolean position)
  System.Boolean get_isNodeBone()
  System.Void SetLength(RootMotion.FinalIK.IKMapping.BoneMap nextBone)
  System.Void SetLocalSwingAxis(RootMotion.FinalIK.IKMapping.BoneMap swingTarget)
  System.Void SetLocalSwingAxis(RootMotion.FinalIK.IKMapping.BoneMap bone1, RootMotion.FinalIK.IKMapping.BoneMap bone2)
  System.Void SetLocalTwistAxis(UnityEngine.Vector3 twistDirection, UnityEngine.Vector3 normalDirection)
  System.Void SetPlane(RootMotion.FinalIK.IKSolverFullBody solver, UnityEngine.Transform planeBone1, UnityEngine.Transform planeBone2, UnityEngine.Transform planeBone3)
  System.Void UpdatePlane(System.Boolean rotation, System.Boolean position)
  System.Void SetIKPosition()
  System.Void MaintainRotation()
  System.Void SetToIKPosition()
  System.Void FixToNode(RootMotion.FinalIK.IKSolverFullBody solver, System.Single weight, RootMotion.FinalIK.IKSolver.Node fixNode)
  UnityEngine.Vector3 GetPlanePosition(RootMotion.FinalIK.IKSolverFullBody solver)
  System.Void PositionToPlane(RootMotion.FinalIK.IKSolverFullBody solver)
  System.Void RotateToPlane(RootMotion.FinalIK.IKSolverFullBody solver, System.Single weight)
  System.Void Swing(UnityEngine.Vector3 swingTarget, System.Single weight)
  System.Void Swing(UnityEngine.Vector3 pos1, UnityEngine.Vector3 pos2, System.Single weight)
  System.Void Twist(UnityEngine.Vector3 twistDirection, UnityEngine.Vector3 normalDirection, System.Single weight)
  System.Void RotateToMaintain(System.Single weight)
  System.Void RotateToEffector(RootMotion.FinalIK.IKSolverFullBody solver, System.Single weight)
  UnityEngine.Quaternion GetTargetRotation(RootMotion.FinalIK.IKSolverFullBody solver)
  UnityEngine.Quaternion get_lastAnimatedTargetRotation()
  System.Void .ctor()
END_CLASS

CLASS: BoneMapType
TYPE:  struct
TOKEN: 0x2000066
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  RootMotion.FinalIK.IKMappingLimb.BoneMapTypeParent  // 0x0
  public    static  RootMotion.FinalIK.IKMappingLimb.BoneMapTypeBone1  // 0x0
  public    static  RootMotion.FinalIK.IKMappingLimb.BoneMapTypeBone2  // 0x0
  public    static  RootMotion.FinalIK.IKMappingLimb.BoneMapTypeBone3  // 0x0
METHODS:
END_CLASS

CLASS: Point
TYPE:  class
TOKEN: 0x2000069
FIELDS:
  public            UnityEngine.Transform           transform  // 0x10
  public            System.Single                   weight  // 0x18
  public            UnityEngine.Vector3             solverPosition  // 0x1C
  public            UnityEngine.Quaternion          solverRotation  // 0x28
  public            UnityEngine.Vector3             defaultLocalPosition  // 0x38
  public            UnityEngine.Quaternion          defaultLocalRotation  // 0x44
METHODS:
  System.Void StoreDefaultLocalState()
  System.Void FixTransform()
  System.Void UpdateSolverPosition()
  System.Void UpdateSolverLocalPosition()
  System.Void UpdateSolverState()
  System.Void UpdateSolverLocalState()
  System.Void .ctor()
END_CLASS

CLASS: Bone
TYPE:  class
TOKEN: 0x200006A
EXTENDS: Point
FIELDS:
  public            System.Single                   length  // 0x58
  public            System.Single                   sqrMag  // 0x5C
  public            UnityEngine.Vector3             axis  // 0x60
  private           RootMotion.FinalIK.RotationLimit_rotationLimit  // 0x70
  private           System.Boolean                  isLimited  // 0x78
METHODS:
  RootMotion.FinalIK.RotationLimit get_rotationLimit()
  System.Void set_rotationLimit(RootMotion.FinalIK.RotationLimit value)
  System.Void Swing(UnityEngine.Vector3 swingTarget, System.Single weight)
  System.Void SolverSwing(RootMotion.FinalIK.IKSolver.Bone[] bones, System.Int32 index, UnityEngine.Vector3 swingTarget, System.Single weight)
  System.Void Swing2D(UnityEngine.Vector3 swingTarget, System.Single weight)
  System.Void SetToSolverPosition()
  System.Void .ctor()
  System.Void .ctor(UnityEngine.Transform transform)
  System.Void .ctor(UnityEngine.Transform transform, System.Single weight)
END_CLASS

CLASS: Node
TYPE:  class
TOKEN: 0x200006B
EXTENDS: Point
FIELDS:
  public            System.Single                   length  // 0x58
  public            System.Single                   effectorPositionWeight  // 0x5C
  public            System.Single                   effectorRotationWeight  // 0x60
  public            UnityEngine.Vector3             offset  // 0x64
METHODS:
  System.Void .ctor()
  System.Void .ctor(UnityEngine.Transform transform)
  System.Void .ctor(UnityEngine.Transform transform, System.Single weight)
END_CLASS

CLASS: UpdateDelegate
TYPE:  class
TOKEN: 0x200006C
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
  System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: IterationDelegate
TYPE:  class
TOKEN: 0x200006D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Int32 i)
  System.IAsyncResult BeginInvoke(System.Int32 i, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: BendModifier
TYPE:  struct
TOKEN: 0x200007A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  RootMotion.FinalIK.IKSolverLimb.BendModifierAnimation  // 0x0
  public    static  RootMotion.FinalIK.IKSolverLimb.BendModifierTarget  // 0x0
  public    static  RootMotion.FinalIK.IKSolverLimb.BendModifierParent  // 0x0
  public    static  RootMotion.FinalIK.IKSolverLimb.BendModifierArm  // 0x0
  public    static  RootMotion.FinalIK.IKSolverLimb.BendModifierGoal  // 0x0
METHODS:
END_CLASS

CLASS: AxisDirection
TYPE:  struct
TOKEN: 0x200007B
FIELDS:
  public            UnityEngine.Vector3             direction  // 0x10
  public            UnityEngine.Vector3             axis  // 0x1C
  public            System.Single                   dot  // 0x28
METHODS:
  System.Void .ctor(UnityEngine.Vector3 direction, UnityEngine.Vector3 axis)
END_CLASS

CLASS: LookAtBone
TYPE:  class
TOKEN: 0x200007D
EXTENDS: Bone
FIELDS:
  public            UnityEngine.Vector3             positionOffset  // 0x80
  public            UnityEngine.Vector3             baseForwardOffsetEuler  // 0x8C
METHODS:
  System.Void .ctor()
  System.Void .ctor(UnityEngine.Transform transform)
  System.Void Initiate(UnityEngine.Transform root)
  System.Void LookAt(UnityEngine.Vector3 direction, System.Single weight)
  UnityEngine.Quaternion LookAtReturnRotation(UnityEngine.Vector3 direction, System.Single weight)
  UnityEngine.Vector3 get_forward()
END_CLASS

CLASS: TrigonometricBone
TYPE:  class
TOKEN: 0x200007F
EXTENDS: Bone
FIELDS:
  private           UnityEngine.Quaternion          targetToLocalSpace  // 0x80
  private           UnityEngine.Vector3             defaultLocalBendNormal  // 0x90
METHODS:
  System.Void Initiate(UnityEngine.Vector3 childPosition, UnityEngine.Vector3 bendNormal)
  UnityEngine.Quaternion GetRotation(UnityEngine.Vector3 direction, UnityEngine.Vector3 bendNormal)
  UnityEngine.Vector3 GetBendNormalFromCurrentRotation()
  System.Void .ctor()
END_CLASS

CLASS: ShoulderRotationMode
TYPE:  struct
TOKEN: 0x2000082
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  RootMotion.FinalIK.IKSolverVR.Arm.ShoulderRotationModeYawPitch  // 0x0
  public    static  RootMotion.FinalIK.IKSolverVR.Arm.ShoulderRotationModeFromTo  // 0x0
METHODS:
END_CLASS

CLASS: Arm
TYPE:  class
TOKEN: 0x2000081
EXTENDS: BodyPart
FIELDS:
  public            UnityEngine.Transform           target  // 0x48
  public            System.Single                   positionWeight  // 0x50
  public            System.Single                   rotationWeight  // 0x54
  public            System.Single                   shoulderRotationWeight  // 0x58
  public            RootMotion.FinalIK.IKSolverVR.Arm.ShoulderRotationModeshoulderRotationMode  // 0x5C
  public            System.Single                   shoulderTwistWeight  // 0x60
  public            System.Single                   shoulderYawOffset  // 0x64
  public            System.Single                   shoulderPitchOffset  // 0x68
  public            UnityEngine.Transform           bendGoal  // 0x70
  public            System.Single                   bendGoalWeight  // 0x78
  public            System.Single                   swivelOffset  // 0x7C
  public            UnityEngine.Vector3             wristToPalmAxis  // 0x80
  public            UnityEngine.Vector3             palmToThumbAxis  // 0x8C
  public            System.Single                   armLengthMlp  // 0x98
  public            UnityEngine.AnimationCurve      stretchCurve  // 0xA0
  public            UnityEngine.Vector3             IKPosition  // 0xA8
  public            UnityEngine.Quaternion          IKRotation  // 0xB4
  public            UnityEngine.Vector3             bendDirection  // 0xC4
  public            UnityEngine.Vector3             handPositionOffset  // 0xD0
  private           UnityEngine.Vector3             <position>k__BackingField  // 0xDC
  private           UnityEngine.Quaternion          <rotation>k__BackingField  // 0xE8
  private           System.Boolean                  hasShoulder  // 0xF8
  private           UnityEngine.Vector3             chestForwardAxis  // 0xFC
  private           UnityEngine.Vector3             chestUpAxis  // 0x108
  private           UnityEngine.Quaternion          chestRotation  // 0x114
  private           UnityEngine.Vector3             chestForward  // 0x124
  private           UnityEngine.Vector3             chestUp  // 0x130
  private           UnityEngine.Quaternion          forearmRelToUpperArm  // 0x13C
  private           UnityEngine.Vector3             upperArmBendAxis  // 0x14C
METHODS:
  UnityEngine.Vector3 get_position()
  System.Void set_position(UnityEngine.Vector3 value)
  UnityEngine.Quaternion get_rotation()
  System.Void set_rotation(UnityEngine.Quaternion value)
  RootMotion.FinalIK.IKSolverVR.VirtualBone get_shoulder()
  RootMotion.FinalIK.IKSolverVR.VirtualBone get_upperArm()
  RootMotion.FinalIK.IKSolverVR.VirtualBone get_forearm()
  RootMotion.FinalIK.IKSolverVR.VirtualBone get_hand()
  System.Void OnRead(UnityEngine.Vector3[] positions, UnityEngine.Quaternion[] rotations, System.Boolean hasChest, System.Boolean hasNeck, System.Boolean hasShoulders, System.Boolean hasToes, System.Boolean hasLegs, System.Int32 rootIndex, System.Int32 index)
  System.Void PreSolve(System.Single scale)
  System.Void ApplyOffsets(System.Single scale)
  System.Void Stretching()
  System.Void Solve(System.Boolean isLeft)
  System.Void ResetOffsets()
  System.Void Write(UnityEngine.Vector3[]& solvedPositions, UnityEngine.Quaternion[]& solvedRotations)
  System.Single DamperValue(System.Single value, System.Single min, System.Single max, System.Single weight)
  UnityEngine.Vector3 GetBendNormal(UnityEngine.Vector3 dir)
  System.Void Visualize(RootMotion.FinalIK.IKSolverVR.VirtualBone bone1, RootMotion.FinalIK.IKSolverVR.VirtualBone bone2, RootMotion.FinalIK.IKSolverVR.VirtualBone bone3, UnityEngine.Color color)
  System.Void .ctor()
END_CLASS

CLASS: BodyPart
TYPE:  class
TOKEN: 0x2000083
FIELDS:
  private           System.Single                   <sqrMag>k__BackingField  // 0x10
  private           System.Single                   <mag>k__BackingField  // 0x14
  public            RootMotion.FinalIK.IKSolverVR.VirtualBone[]bones  // 0x18
  protected         System.Boolean                  initiated  // 0x20
  protected         UnityEngine.Vector3             rootPosition  // 0x24
  protected         UnityEngine.Quaternion          rootRotation  // 0x30
  protected         System.Int32                    index  // 0x40
  protected         System.Int32                    LOD  // 0x44
METHODS:
  System.Void OnRead(UnityEngine.Vector3[] positions, UnityEngine.Quaternion[] rotations, System.Boolean hasChest, System.Boolean hasNeck, System.Boolean hasShoulders, System.Boolean hasToes, System.Boolean hasLegs, System.Int32 rootIndex, System.Int32 index)
  System.Void PreSolve(System.Single scale)
  System.Void Write(UnityEngine.Vector3[]& solvedPositions, UnityEngine.Quaternion[]& solvedRotations)
  System.Void ApplyOffsets(System.Single scale)
  System.Void ResetOffsets()
  System.Single get_sqrMag()
  System.Void set_sqrMag(System.Single value)
  System.Single get_mag()
  System.Void set_mag(System.Single value)
  System.Void SetLOD(System.Int32 LOD)
  System.Void Read(UnityEngine.Vector3[] positions, UnityEngine.Quaternion[] rotations, System.Boolean hasChest, System.Boolean hasNeck, System.Boolean hasShoulders, System.Boolean hasToes, System.Boolean hasLegs, System.Int32 rootIndex, System.Int32 index)
  System.Void MovePosition(UnityEngine.Vector3 position)
  System.Void MoveRotation(UnityEngine.Quaternion rotation)
  System.Void Translate(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  System.Void TranslateRoot(UnityEngine.Vector3 newRootPos, UnityEngine.Quaternion newRootRot)
  System.Void RotateTo(RootMotion.FinalIK.IKSolverVR.VirtualBone bone, UnityEngine.Quaternion rotation, System.Single weight)
  System.Void Visualize(UnityEngine.Color color)
  System.Void Visualize()
  System.Void .ctor()
END_CLASS

CLASS: Footstep
TYPE:  class
TOKEN: 0x2000084
FIELDS:
  public            System.Single                   stepSpeed  // 0x10
  public            UnityEngine.Vector3             characterSpaceOffset  // 0x14
  public            UnityEngine.Vector3             position  // 0x20
  public            UnityEngine.Quaternion          rotation  // 0x2C
  public            UnityEngine.Quaternion          stepToRootRot  // 0x3C
  public            System.Boolean                  isSupportLeg  // 0x4C
  public            System.Boolean                  relaxFlag  // 0x4D
  private           System.Single                   <stepProgress>k__BackingField  // 0x50
  public            UnityEngine.Vector3             stepFrom  // 0x54
  public            UnityEngine.Vector3             stepTo  // 0x60
  public            UnityEngine.Quaternion          stepFromRot  // 0x6C
  public            UnityEngine.Quaternion          stepToRot  // 0x7C
  private           UnityEngine.Quaternion          footRelativeToRoot  // 0x8C
  private           System.Single                   supportLegW  // 0x9C
  private           System.Single                   supportLegWV  // 0xA0
METHODS:
  System.Boolean get_isStepping()
  System.Single get_stepProgress()
  System.Void set_stepProgress(System.Single value)
  System.Void .ctor(UnityEngine.Quaternion rootRotation, UnityEngine.Vector3 footPosition, UnityEngine.Quaternion footRotation, UnityEngine.Vector3 characterSpaceOffset)
  System.Void Reset(UnityEngine.Quaternion rootRotation, UnityEngine.Vector3 footPosition, UnityEngine.Quaternion footRotation)
  System.Void StepTo(UnityEngine.Vector3 p, UnityEngine.Quaternion rootRotation, System.Single stepThreshold)
  System.Void UpdateStepping(UnityEngine.Vector3 p, UnityEngine.Quaternion rootRotation, System.Single speed, System.Single deltaTime)
  System.Void UpdateStanding(UnityEngine.Quaternion rootRotation, System.Single minAngle, System.Single speed, System.Single deltaTime)
  System.Void Update(RootMotion.InterpolationMode interpolation, UnityEngine.Events.UnityEvent onStep, System.Single deltaTime)
END_CLASS

CLASS: Leg
TYPE:  class
TOKEN: 0x2000085
EXTENDS: BodyPart
FIELDS:
  public            UnityEngine.Transform           target  // 0x48
  public            System.Single                   positionWeight  // 0x50
  public            System.Single                   rotationWeight  // 0x54
  public            UnityEngine.Transform           bendGoal  // 0x58
  public            System.Single                   bendGoalWeight  // 0x60
  public            System.Single                   swivelOffset  // 0x64
  public            System.Single                   bendToTargetWeight  // 0x68
  public            System.Single                   legLengthMlp  // 0x6C
  public            UnityEngine.AnimationCurve      stretchCurve  // 0x70
  public            UnityEngine.Vector3             IKPosition  // 0x78
  public            UnityEngine.Quaternion          IKRotation  // 0x84
  public            UnityEngine.Vector3             footPositionOffset  // 0x94
  public            UnityEngine.Vector3             heelPositionOffset  // 0xA0
  public            UnityEngine.Quaternion          footRotationOffset  // 0xAC
  public            System.Single                   currentMag  // 0xBC
  public            System.Boolean                  useAnimatedBendNormal  // 0xC0
  private           UnityEngine.Vector3             <position>k__BackingField  // 0xC4
  private           UnityEngine.Quaternion          <rotation>k__BackingField  // 0xD0
  private           System.Boolean                  <hasToes>k__BackingField  // 0xE0
  private           UnityEngine.Vector3             <thighRelativeToPelvis>k__BackingField  // 0xE4
  private           UnityEngine.Vector3             footPosition  // 0xF0
  private           UnityEngine.Quaternion          footRotation  // 0xFC
  private           UnityEngine.Vector3             bendNormal  // 0x10C
  private           UnityEngine.Quaternion          calfRelToThigh  // 0x118
  private           UnityEngine.Quaternion          thighRelToFoot  // 0x128
  private           UnityEngine.Vector3             <bendNormalRelToPelvis>k__BackingField  // 0x138
  private           UnityEngine.Vector3             <bendNormalRelToTarget>k__BackingField  // 0x144
METHODS:
  UnityEngine.Vector3 get_position()
  System.Void set_position(UnityEngine.Vector3 value)
  UnityEngine.Quaternion get_rotation()
  System.Void set_rotation(UnityEngine.Quaternion value)
  System.Boolean get_hasToes()
  System.Void set_hasToes(System.Boolean value)
  RootMotion.FinalIK.IKSolverVR.VirtualBone get_thigh()
  RootMotion.FinalIK.IKSolverVR.VirtualBone get_calf()
  RootMotion.FinalIK.IKSolverVR.VirtualBone get_foot()
  RootMotion.FinalIK.IKSolverVR.VirtualBone get_toes()
  RootMotion.FinalIK.IKSolverVR.VirtualBone get_lastBone()
  UnityEngine.Vector3 get_thighRelativeToPelvis()
  System.Void set_thighRelativeToPelvis(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_bendNormalRelToPelvis()
  System.Void set_bendNormalRelToPelvis(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_bendNormalRelToTarget()
  System.Void set_bendNormalRelToTarget(UnityEngine.Vector3 value)
  System.Void OnRead(UnityEngine.Vector3[] positions, UnityEngine.Quaternion[] rotations, System.Boolean hasChest, System.Boolean hasNeck, System.Boolean hasShoulders, System.Boolean hasToes, System.Boolean hasLegs, System.Int32 rootIndex, System.Int32 index)
  System.Void PreSolve(System.Single scale)
  System.Void ApplyOffsets(System.Single scale)
  System.Void ApplyPositionOffset(UnityEngine.Vector3 offset, System.Single weight)
  System.Void ApplyRotationOffset(UnityEngine.Quaternion offset, System.Single weight)
  System.Void Solve(System.Boolean stretch)
  System.Void FixTwistRotations()
  System.Void Stretching()
  System.Void Write(UnityEngine.Vector3[]& solvedPositions, UnityEngine.Quaternion[]& solvedRotations)
  System.Void ResetOffsets()
  System.Void .ctor()
END_CLASS

CLASS: Mode
TYPE:  struct
TOKEN: 0x2000087
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  RootMotion.FinalIK.IKSolverVR.Locomotion.ModeProcedural  // 0x0
  public    static  RootMotion.FinalIK.IKSolverVR.Locomotion.ModeAnimated  // 0x0
METHODS:
END_CLASS

CLASS: Locomotion
TYPE:  class
TOKEN: 0x2000086
FIELDS:
  public            RootMotion.FinalIK.IKSolverVR.Locomotion.Modemode  // 0x10
  public            System.Single                   weight  // 0x14
  public            System.Single                   moveThreshold  // 0x18
  private           System.Byte                     animationHeader  // 0x1C
  public            System.Single                   minAnimationSpeed  // 0x20
  public            System.Single                   maxAnimationSpeed  // 0x24
  public            System.Single                   animationSmoothTime  // 0x28
  private           System.Byte                     rootPositionHeader  // 0x2C
  public            UnityEngine.Vector2             standOffset  // 0x30
  public            System.Single                   rootLerpSpeedWhileMoving  // 0x38
  public            System.Single                   rootLerpSpeedWhileStopping  // 0x3C
  public            System.Single                   rootLerpSpeedWhileTurning  // 0x40
  public            System.Single                   maxRootOffset  // 0x44
  private           System.Byte                     rootRotationHeader  // 0x48
  public            System.Single                   maxRootAngleMoving  // 0x4C
  public            System.Single                   maxRootAngleStanding  // 0x50
  public            System.Single                   stepLengthMlp  // 0x54
  private           UnityEngine.Animator            animator  // 0x58
  private           UnityEngine.Vector3             velocityLocal  // 0x60
  private           UnityEngine.Vector3             velocityLocalV  // 0x6C
  private           UnityEngine.Vector3             lastCorrection  // 0x78
  private           UnityEngine.Vector3             lastHeadTargetPos  // 0x84
  private           UnityEngine.Vector3             lastSpeedRootPos  // 0x90
  private           UnityEngine.Vector3             lastEndRootPos  // 0x9C
  private           System.Single                   rootLerpSpeed  // 0xA8
  private           System.Single                   rootVelocityV  // 0xAC
  private           System.Single                   animSpeed  // 0xB0
  private           System.Single                   animSpeedV  // 0xB4
  private           System.Single                   stopMoveTimer  // 0xB8
  private           System.Single                   turn  // 0xBC
  private           System.Single                   maxRootAngleV  // 0xC0
  private           System.Single                   currentAnimationSmoothTime  // 0xC4
  private           System.Boolean                  isMoving  // 0xC8
  private           System.Boolean                  firstFrame  // 0xC9
  private   static  System.Int32                    VRIK_Horizontal  // 0x0
  private   static  System.Int32                    VRIK_Vertical  // 0x4
  private   static  System.Int32                    VRIK_IsMoving  // 0x8
  private   static  System.Int32                    VRIK_Speed  // 0xC
  private   static  System.Int32                    VRIK_Turn  // 0x10
  private   static  System.Boolean                  isHashed  // 0x14
  private           System.Single                   lastVelLocalMag  // 0xCC
  public            System.Single                   footDistance  // 0xD0
  public            System.Single                   stepThreshold  // 0xD4
  public            System.Single                   angleThreshold  // 0xD8
  public            System.Single                   comAngleMlp  // 0xDC
  public            System.Single                   maxVelocity  // 0xE0
  public            System.Single                   velocityFactor  // 0xE4
  public            System.Single                   maxLegStretch  // 0xE8
  public            System.Single                   rootSpeed  // 0xEC
  public            System.Single                   stepSpeed  // 0xF0
  public            UnityEngine.AnimationCurve      stepHeight  // 0xF8
  public            System.Single                   maxBodyYOffset  // 0x100
  public            UnityEngine.AnimationCurve      heelHeight  // 0x108
  public            System.Single                   relaxLegTwistMinAngle  // 0x110
  public            System.Single                   relaxLegTwistSpeed  // 0x114
  public            RootMotion.InterpolationMode    stepInterpolation  // 0x118
  public            UnityEngine.Vector3             offset  // 0x11C
  public            System.Boolean                  blockingEnabled  // 0x128
  public            UnityEngine.LayerMask           blockingLayers  // 0x12C
  public            System.Single                   raycastRadius  // 0x130
  public            System.Single                   raycastHeight  // 0x134
  public            UnityEngine.Events.UnityEvent   onLeftFootstep  // 0x138
  public            UnityEngine.Events.UnityEvent   onRightFootstep  // 0x140
  private           UnityEngine.Vector3             <centerOfMass>k__BackingField  // 0x148
  private           RootMotion.FinalIK.IKSolverVR.Footstep[]footsteps  // 0x158
  private           UnityEngine.Vector3             lastComPosition  // 0x160
  private           UnityEngine.Vector3             comVelocity  // 0x16C
  private           System.Int32                    leftFootIndex  // 0x178
  private           System.Int32                    rightFootIndex  // 0x17C
METHODS:
  System.Void Initiate(UnityEngine.Animator animator, UnityEngine.Vector3[] positions, UnityEngine.Quaternion[] rotations, System.Boolean hasToes, System.Single scale)
  System.Void Reset(UnityEngine.Vector3[] positions, UnityEngine.Quaternion[] rotations)
  System.Void Relax()
  System.Void AddDeltaRotation(UnityEngine.Quaternion delta, UnityEngine.Vector3 pivot)
  System.Void AddDeltaPosition(UnityEngine.Vector3 delta)
  System.Void Initiate_Animated(UnityEngine.Animator animator, UnityEngine.Vector3[] positions)
  System.Void ResetParams(UnityEngine.Vector3[] positions)
  System.Void Reset_Animated(UnityEngine.Vector3[] positions)
  System.Void AddDeltaRotation_Animated(UnityEngine.Quaternion delta, UnityEngine.Vector3 pivot)
  System.Void AddDeltaPosition_Animated(UnityEngine.Vector3 delta)
  System.Void Solve_Animated(RootMotion.FinalIK.IKSolverVR solver, System.Single scale, System.Single deltaTime)
  UnityEngine.Vector3 get_centerOfMass()
  System.Void set_centerOfMass(UnityEngine.Vector3 value)
  System.Void Initiate_Procedural(UnityEngine.Vector3[] positions, UnityEngine.Quaternion[] rotations, System.Boolean hasToes, System.Single scale)
  System.Void Reset_Procedural(UnityEngine.Vector3[] positions, UnityEngine.Quaternion[] rotations)
  System.Void Relax_Procedural()
  System.Void AddDeltaRotation_Procedural(UnityEngine.Quaternion delta, UnityEngine.Vector3 pivot)
  System.Void AddDeltaPosition_Procedural(UnityEngine.Vector3 delta)
  System.Void Solve_Procedural(RootMotion.FinalIK.IKSolverVR.VirtualBone rootBone, RootMotion.FinalIK.IKSolverVR.Spine spine, RootMotion.FinalIK.IKSolverVR.Leg leftLeg, RootMotion.FinalIK.IKSolverVR.Leg rightLeg, RootMotion.FinalIK.IKSolverVR.Arm leftArm, RootMotion.FinalIK.IKSolverVR.Arm rightArm, System.Int32 supportLegIndex, UnityEngine.Vector3& leftFootPosition, UnityEngine.Vector3& rightFootPosition, UnityEngine.Quaternion& leftFootRotation, UnityEngine.Quaternion& rightFootRotation, System.Single& leftFootOffset, System.Single& rightFootOffset, System.Single& leftHeelOffset, System.Single& rightHeelOffset, System.Single scale, System.Single deltaTime)
  UnityEngine.Vector3 get_leftFootstepPosition()
  UnityEngine.Vector3 get_rightFootstepPosition()
  UnityEngine.Quaternion get_leftFootstepRotation()
  UnityEngine.Quaternion get_rightFootstepRotation()
  System.Boolean StepBlocked(UnityEngine.Vector3 fromPosition, UnityEngine.Vector3 toPosition, UnityEngine.Vector3 rootPosition)
  System.Boolean CanStep()
  System.Boolean GetLineSphereCollision(UnityEngine.Vector3 lineStart, UnityEngine.Vector3 lineEnd, UnityEngine.Vector3 sphereCenter, System.Single sphereRadius)
  System.Void .ctor()
END_CLASS

CLASS: Spine
TYPE:  class
TOKEN: 0x2000088
EXTENDS: BodyPart
FIELDS:
  public            UnityEngine.Transform           headTarget  // 0x48
  public            System.Single                   positionWeight  // 0x50
  public            System.Single                   rotationWeight  // 0x54
  public            System.Single                   headClampWeight  // 0x58
  public            System.Single                   minHeadHeight  // 0x5C
  public            System.Single                   useAnimatedHeadHeightWeight  // 0x60
  public            System.Single                   useAnimatedHeadHeightRange  // 0x64
  public            System.Single                   animatedHeadHeightBlend  // 0x68
  public            UnityEngine.Transform           pelvisTarget  // 0x70
  public            System.Single                   pelvisPositionWeight  // 0x78
  public            System.Single                   pelvisRotationWeight  // 0x7C
  public            System.Single                   maintainPelvisPosition  // 0x80
  public            UnityEngine.Transform           chestGoal  // 0x88
  public            System.Single                   chestGoalWeight  // 0x90
  public            System.Single                   chestClampWeight  // 0x94
  public            System.Single                   rotateChestByHands  // 0x98
  public            System.Single                   bodyPosStiffness  // 0x9C
  public            System.Single                   bodyRotStiffness  // 0xA0
  public            System.Single                   neckStiffness  // 0xA4
  public            System.Single                   moveBodyBackWhenCrouching  // 0xA8
  public            System.Single                   maxRootAngle  // 0xAC
  public            System.Single                   rootHeadingOffset  // 0xB0
  public            UnityEngine.Vector3             IKPositionHead  // 0xB4
  public            UnityEngine.Quaternion          IKRotationHead  // 0xC0
  public            UnityEngine.Vector3             IKPositionPelvis  // 0xD0
  public            UnityEngine.Quaternion          IKRotationPelvis  // 0xDC
  public            UnityEngine.Vector3             goalPositionChest  // 0xEC
  public            UnityEngine.Vector3             pelvisPositionOffset  // 0xF8
  public            UnityEngine.Vector3             chestPositionOffset  // 0x104
  public            UnityEngine.Vector3             headPositionOffset  // 0x110
  public            UnityEngine.Quaternion          pelvisRotationOffset  // 0x11C
  public            UnityEngine.Quaternion          chestRotationOffset  // 0x12C
  public            UnityEngine.Quaternion          headRotationOffset  // 0x13C
  public            UnityEngine.Vector3             faceDirection  // 0x14C
  private           UnityEngine.Vector3             headPosition  // 0x158
  private           UnityEngine.Quaternion          <anchorRotation>k__BackingField  // 0x164
  private           UnityEngine.Quaternion          <anchorRelativeToHead>k__BackingField  // 0x174
  private           UnityEngine.Quaternion          headRotation  // 0x184
  private           UnityEngine.Quaternion          pelvisRotation  // 0x194
  private           UnityEngine.Quaternion          anchorRelativeToPelvis  // 0x1A4
  private           UnityEngine.Quaternion          pelvisRelativeRotation  // 0x1B4
  private           UnityEngine.Quaternion          chestRelativeRotation  // 0x1C4
  private           UnityEngine.Vector3             headDeltaPosition  // 0x1D4
  private           UnityEngine.Quaternion          pelvisDeltaRotation  // 0x1E0
  private           UnityEngine.Quaternion          chestTargetRotation  // 0x1F0
  private           System.Int32                    pelvisIndex  // 0x200
  private           System.Int32                    spineIndex  // 0x204
  private           System.Int32                    chestIndex  // 0x208
  private           System.Int32                    neckIndex  // 0x20C
  private           System.Int32                    headIndex  // 0x210
  private           System.Single                   length  // 0x214
  private           System.Boolean                  hasChest  // 0x218
  private           System.Boolean                  hasNeck  // 0x219
  private           System.Boolean                  hasLegs  // 0x21A
  private           System.Single                   headHeight  // 0x21C
  private           System.Single                   sizeMlp  // 0x220
  private           UnityEngine.Vector3             chestForward  // 0x224
METHODS:
  RootMotion.FinalIK.IKSolverVR.VirtualBone get_pelvis()
  RootMotion.FinalIK.IKSolverVR.VirtualBone get_firstSpineBone()
  RootMotion.FinalIK.IKSolverVR.VirtualBone get_chest()
  RootMotion.FinalIK.IKSolverVR.VirtualBone get_head()
  RootMotion.FinalIK.IKSolverVR.VirtualBone get_neck()
  UnityEngine.Quaternion get_anchorRotation()
  System.Void set_anchorRotation(UnityEngine.Quaternion value)
  UnityEngine.Quaternion get_anchorRelativeToHead()
  System.Void set_anchorRelativeToHead(UnityEngine.Quaternion value)
  System.Void OnRead(UnityEngine.Vector3[] positions, UnityEngine.Quaternion[] rotations, System.Boolean hasChest, System.Boolean hasNeck, System.Boolean hasShoulders, System.Boolean hasToes, System.Boolean hasLegs, System.Int32 rootIndex, System.Int32 index)
  System.Void PreSolve(System.Single scale)
  System.Void ApplyOffsets(System.Single scale)
  System.Void CalculateChestTargetRotation(RootMotion.FinalIK.IKSolverVR.VirtualBone rootBone, RootMotion.FinalIK.IKSolverVR.Arm[] arms)
  System.Void Solve(UnityEngine.Animator animator, RootMotion.FinalIK.IKSolverVR.VirtualBone rootBone, RootMotion.FinalIK.IKSolverVR.Leg[] legs, RootMotion.FinalIK.IKSolverVR.Arm[] arms, System.Single scale)
  System.Void FABRIKPass(UnityEngine.Vector3 animatedPelvisPos, UnityEngine.Vector3 rootUp, System.Single weight)
  System.Void SolvePelvis()
  System.Void Write(UnityEngine.Vector3[]& solvedPositions, UnityEngine.Quaternion[]& solvedRotations)
  System.Void ResetOffsets()
  System.Void AdjustChestByHands(UnityEngine.Quaternion& chestTargetRotation, RootMotion.FinalIK.IKSolverVR.Arm[] arms)
  System.Void InverseTranslateToHead(RootMotion.FinalIK.IKSolverVR.Leg[] legs, System.Boolean limited, System.Boolean useCurrentLegMag, UnityEngine.Vector3 offset, System.Single w)
  System.Void TranslatePelvis(RootMotion.FinalIK.IKSolverVR.Leg[] legs, UnityEngine.Vector3 deltaPosition, UnityEngine.Quaternion deltaRotation, System.Single scale)
  UnityEngine.Vector3 LimitPelvisPosition(RootMotion.FinalIK.IKSolverVR.Leg[] legs, UnityEngine.Vector3 pelvisPosition, System.Boolean useCurrentLegMag, System.Int32 it)
  System.Void Bend(RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones, System.Int32 firstIndex, System.Int32 lastIndex, UnityEngine.Quaternion targetRotation, System.Single clampWeight, System.Boolean uniformWeight, System.Single w)
  System.Void Bend(RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones, System.Int32 firstIndex, System.Int32 lastIndex, UnityEngine.Quaternion targetRotation, UnityEngine.Quaternion rotationOffset, System.Single clampWeight, System.Boolean uniformWeight, System.Single w)
  System.Void .ctor()
END_CLASS

CLASS: PositionOffset
TYPE:  struct
TOKEN: 0x2000089
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  RootMotion.FinalIK.IKSolverVR.PositionOffsetPelvis  // 0x0
  public    static  RootMotion.FinalIK.IKSolverVR.PositionOffsetChest  // 0x0
  public    static  RootMotion.FinalIK.IKSolverVR.PositionOffsetHead  // 0x0
  public    static  RootMotion.FinalIK.IKSolverVR.PositionOffsetLeftHand  // 0x0
  public    static  RootMotion.FinalIK.IKSolverVR.PositionOffsetRightHand  // 0x0
  public    static  RootMotion.FinalIK.IKSolverVR.PositionOffsetLeftFoot  // 0x0
  public    static  RootMotion.FinalIK.IKSolverVR.PositionOffsetRightFoot  // 0x0
  public    static  RootMotion.FinalIK.IKSolverVR.PositionOffsetLeftHeel  // 0x0
  public    static  RootMotion.FinalIK.IKSolverVR.PositionOffsetRightHeel  // 0x0
METHODS:
END_CLASS

CLASS: RotationOffset
TYPE:  struct
TOKEN: 0x200008A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  RootMotion.FinalIK.IKSolverVR.RotationOffsetPelvis  // 0x0
  public    static  RootMotion.FinalIK.IKSolverVR.RotationOffsetChest  // 0x0
  public    static  RootMotion.FinalIK.IKSolverVR.RotationOffsetHead  // 0x0
METHODS:
END_CLASS

CLASS: VirtualBone
TYPE:  class
TOKEN: 0x200008B
FIELDS:
  public            UnityEngine.Vector3             readPosition  // 0x10
  public            UnityEngine.Quaternion          readRotation  // 0x1C
  public            UnityEngine.Vector3             solverPosition  // 0x2C
  public            UnityEngine.Quaternion          solverRotation  // 0x38
  public            System.Single                   length  // 0x48
  public            System.Single                   sqrMag  // 0x4C
  public            UnityEngine.Vector3             axis  // 0x50
METHODS:
  System.Void .ctor(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  System.Void Read(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  System.Void SwingRotation(RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones, System.Int32 index, UnityEngine.Vector3 swingTarget, System.Single weight)
  System.Single PreSolve(RootMotion.FinalIK.IKSolverVR.VirtualBone[]& bones)
  System.Void RotateAroundPoint(RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones, System.Int32 index, UnityEngine.Vector3 point, UnityEngine.Quaternion rotation)
  System.Void RotateBy(RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones, System.Int32 index, UnityEngine.Quaternion rotation)
  System.Void RotateBy(RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones, UnityEngine.Quaternion rotation)
  System.Void RotateTo(RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones, System.Int32 index, UnityEngine.Quaternion rotation)
  System.Void SolveTrigonometric(RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones, System.Int32 first, System.Int32 second, System.Int32 third, UnityEngine.Vector3 targetPosition, UnityEngine.Vector3 bendNormal, System.Single weight)
  UnityEngine.Vector3 GetDirectionToBendPoint(UnityEngine.Vector3 direction, System.Single directionMag, UnityEngine.Vector3 bendDirection, System.Single sqrMag1, System.Single sqrMag2)
  System.Void SolveFABRIK(RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones, UnityEngine.Vector3 startPosition, UnityEngine.Vector3 targetPosition, System.Single weight, System.Single minNormalizedTargetDistance, System.Int32 iterations, System.Single length, UnityEngine.Vector3 startOffset)
  UnityEngine.Vector3 SolveFABRIKJoint(UnityEngine.Vector3 pos1, UnityEngine.Vector3 pos2, System.Single length)
  System.Void SolveCCD(RootMotion.FinalIK.IKSolverVR.VirtualBone[] bones, UnityEngine.Vector3 targetPosition, System.Single weight, System.Int32 iterations)
END_CLASS

CLASS: InteractionEvent
TYPE:  class
TOKEN: 0x2000091
FIELDS:
  public            System.Single                   time  // 0x10
  public            System.Boolean                  pause  // 0x14
  public            System.Boolean                  pickUp  // 0x15
  public            RootMotion.FinalIK.InteractionObject.AnimatorEvent[]animations  // 0x18
  public            RootMotion.FinalIK.InteractionObject.Message[]messages  // 0x20
  public            UnityEngine.Events.UnityEvent   unityEvent  // 0x28
METHODS:
  System.Void Activate(UnityEngine.Transform t)
  System.Void .ctor()
END_CLASS

CLASS: Message
TYPE:  class
TOKEN: 0x2000092
FIELDS:
  public            System.String                   function  // 0x10
  public            UnityEngine.GameObject          recipient  // 0x18
  private   static  System.String                   empty  // 0x0
METHODS:
  System.Void Send(UnityEngine.Transform t)
  System.Void .ctor()
END_CLASS

CLASS: AnimatorEvent
TYPE:  class
TOKEN: 0x2000093
FIELDS:
  public            UnityEngine.Animator            animator  // 0x10
  public            UnityEngine.Animation           animation  // 0x18
  public            System.String                   animationState  // 0x20
  public            System.Single                   crossfadeTime  // 0x28
  public            System.Int32                    layer  // 0x2C
  public            System.Boolean                  resetNormalizedTime  // 0x30
  private   static  System.String                   empty  // 0x0
METHODS:
  System.Void Activate(System.Boolean pickUp)
  System.Void Activate(UnityEngine.Animator animator)
  System.Void Activate(UnityEngine.Animation animation)
  System.Void .ctor()
END_CLASS

CLASS: Type
TYPE:  struct
TOKEN: 0x2000095
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  RootMotion.FinalIK.InteractionObject.WeightCurve.TypePositionWeight  // 0x0
  public    static  RootMotion.FinalIK.InteractionObject.WeightCurve.TypeRotationWeight  // 0x0
  public    static  RootMotion.FinalIK.InteractionObject.WeightCurve.TypePositionOffsetX  // 0x0
  public    static  RootMotion.FinalIK.InteractionObject.WeightCurve.TypePositionOffsetY  // 0x0
  public    static  RootMotion.FinalIK.InteractionObject.WeightCurve.TypePositionOffsetZ  // 0x0
  public    static  RootMotion.FinalIK.InteractionObject.WeightCurve.TypePull  // 0x0
  public    static  RootMotion.FinalIK.InteractionObject.WeightCurve.TypeReach  // 0x0
  public    static  RootMotion.FinalIK.InteractionObject.WeightCurve.TypeRotateBoneWeight  // 0x0
  public    static  RootMotion.FinalIK.InteractionObject.WeightCurve.TypePush  // 0x0
  public    static  RootMotion.FinalIK.InteractionObject.WeightCurve.TypePushParent  // 0x0
  public    static  RootMotion.FinalIK.InteractionObject.WeightCurve.TypePoserWeight  // 0x0
  public    static  RootMotion.FinalIK.InteractionObject.WeightCurve.TypeBendGoalWeight  // 0x0
METHODS:
END_CLASS

CLASS: WeightCurve
TYPE:  class
TOKEN: 0x2000094
FIELDS:
  public            RootMotion.FinalIK.InteractionObject.WeightCurve.Typetype  // 0x10
  public            UnityEngine.AnimationCurve      curve  // 0x18
METHODS:
  System.Single GetValue(System.Single timer)
  System.Void .ctor()
END_CLASS

CLASS: Multiplier
TYPE:  class
TOKEN: 0x2000096
FIELDS:
  public            RootMotion.FinalIK.InteractionObject.WeightCurve.Typecurve  // 0x10
  public            System.Single                   multiplier  // 0x14
  public            RootMotion.FinalIK.InteractionObject.WeightCurve.Typeresult  // 0x18
METHODS:
  System.Single GetValue(RootMotion.FinalIK.InteractionObject.WeightCurve weightCurve, System.Single timer)
  System.Void .ctor()
END_CLASS

CLASS: InteractionDelegate
TYPE:  class
TOKEN: 0x2000098
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(RootMotion.FinalIK.FullBodyBipedEffector effectorType, RootMotion.FinalIK.InteractionObject interactionObject)
  System.IAsyncResult BeginInvoke(RootMotion.FinalIK.FullBodyBipedEffector effectorType, RootMotion.FinalIK.InteractionObject interactionObject, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: InteractionEventDelegate
TYPE:  class
TOKEN: 0x2000099
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(RootMotion.FinalIK.FullBodyBipedEffector effectorType, RootMotion.FinalIK.InteractionObject interactionObject, RootMotion.FinalIK.InteractionObject.InteractionEvent interactionEvent)
  System.IAsyncResult BeginInvoke(RootMotion.FinalIK.FullBodyBipedEffector effectorType, RootMotion.FinalIK.InteractionObject interactionObject, RootMotion.FinalIK.InteractionObject.InteractionEvent interactionEvent, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: RotationMode
TYPE:  struct
TOKEN: 0x200009B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  RootMotion.FinalIK.InteractionTarget.RotationModeTwoDOF  // 0x0
  public    static  RootMotion.FinalIK.InteractionTarget.RotationModeThreeDOF  // 0x0
METHODS:
END_CLASS

CLASS: Multiplier
TYPE:  class
TOKEN: 0x200009C
FIELDS:
  public            RootMotion.FinalIK.InteractionObject.WeightCurve.Typecurve  // 0x10
  public            System.Single                   multiplier  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: CharacterPosition
TYPE:  class
TOKEN: 0x200009E
FIELDS:
  public            System.Boolean                  use  // 0x10
  public            UnityEngine.Vector2             offset  // 0x14
  public            System.Single                   angleOffset  // 0x1C
  public            System.Single                   maxAngle  // 0x20
  public            System.Single                   radius  // 0x24
  public            System.Boolean                  orbit  // 0x28
  public            System.Boolean                  fixYAxis  // 0x29
METHODS:
  UnityEngine.Vector3 get_offset3D()
  UnityEngine.Vector3 get_direction3D()
  System.Boolean IsInRange(UnityEngine.Transform character, UnityEngine.Transform trigger, System.Single& error)
  System.Void .ctor()
END_CLASS

CLASS: CameraPosition
TYPE:  class
TOKEN: 0x200009F
FIELDS:
  public            UnityEngine.Collider            lookAtTarget  // 0x10
  public            UnityEngine.Vector3             direction  // 0x18
  public            System.Single                   maxDistance  // 0x24
  public            System.Single                   maxAngle  // 0x28
  public            System.Boolean                  fixYAxis  // 0x2C
METHODS:
  UnityEngine.Quaternion GetRotation()
  System.Boolean IsInRange(UnityEngine.Transform raycastFrom, UnityEngine.RaycastHit hit, UnityEngine.Transform trigger, System.Single& error)
  System.Void .ctor()
END_CLASS

CLASS: Interaction
TYPE:  class
TOKEN: 0x20000A1
FIELDS:
  public            RootMotion.FinalIK.InteractionObjectinteractionObject  // 0x10
  public            RootMotion.FinalIK.FullBodyBipedEffector[]effectors  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Range
TYPE:  class
TOKEN: 0x20000A0
FIELDS:
  public            System.String                   name  // 0x10
  public            System.Boolean                  show  // 0x18
  public            RootMotion.FinalIK.InteractionTrigger.CharacterPositioncharacterPosition  // 0x20
  public            RootMotion.FinalIK.InteractionTrigger.CameraPositioncameraPosition  // 0x28
  public            RootMotion.FinalIK.InteractionTrigger.Range.Interaction[]interactions  // 0x30
METHODS:
  System.Boolean IsInRange(UnityEngine.Transform character, UnityEngine.Transform raycastFrom, UnityEngine.RaycastHit raycastHit, UnityEngine.Transform trigger, System.Single& maxError)
  System.Void .ctor()
END_CLASS

CLASS: Map
TYPE:  class
TOKEN: 0x20000A3
FIELDS:
  public            UnityEngine.Transform           bone  // 0x10
  public            UnityEngine.Transform           target  // 0x18
  private           UnityEngine.Vector3             defaultLocalPosition  // 0x20
  private           UnityEngine.Quaternion          defaultLocalRotation  // 0x2C
METHODS:
  System.Void .ctor(UnityEngine.Transform bone, UnityEngine.Transform target)
  System.Void StoreDefaultState()
  System.Void FixTransform()
  System.Void Update(System.Single localRotationWeight, System.Single localPositionWeight)
END_CLASS

CLASS: Rigidbone
TYPE:  class
TOKEN: 0x20000A7
FIELDS:
  public            UnityEngine.Rigidbody           r  // 0x10
  public            UnityEngine.Transform           t  // 0x18
  public            UnityEngine.Collider            collider  // 0x20
  public            UnityEngine.Joint               joint  // 0x28
  public            UnityEngine.Rigidbody           c  // 0x30
  public            System.Boolean                  updateAnchor  // 0x38
  public            UnityEngine.Vector3             deltaPosition  // 0x3C
  public            UnityEngine.Quaternion          deltaRotation  // 0x48
  public            System.Single                   deltaTime  // 0x58
  public            UnityEngine.Vector3             lastPosition  // 0x5C
  public            UnityEngine.Quaternion          lastRotation  // 0x68
METHODS:
  System.Void .ctor(UnityEngine.Rigidbody r)
  System.Void RecordVelocity()
  System.Void WakeUp(System.Single velocityWeight, System.Single angularVelocityWeight)
END_CLASS

CLASS: Child
TYPE:  class
TOKEN: 0x20000A8
FIELDS:
  public            UnityEngine.Transform           t  // 0x10
  public            UnityEngine.Vector3             localPosition  // 0x18
  public            UnityEngine.Quaternion          localRotation  // 0x24
METHODS:
  System.Void .ctor(UnityEngine.Transform transform)
  System.Void FixTransform(System.Single weight)
  System.Void StoreLocalState()
END_CLASS

CLASS: ReachCone
TYPE:  class
TOKEN: 0x20000AE
FIELDS:
  public            UnityEngine.Vector3[]           tetrahedron  // 0x10
  public            System.Single                   volume  // 0x18
  public            UnityEngine.Vector3             S  // 0x1C
  public            UnityEngine.Vector3             B  // 0x28
METHODS:
  UnityEngine.Vector3 get_o()
  UnityEngine.Vector3 get_a()
  UnityEngine.Vector3 get_b()
  UnityEngine.Vector3 get_c()
  System.Void .ctor(UnityEngine.Vector3 _o, UnityEngine.Vector3 _a, UnityEngine.Vector3 _b, UnityEngine.Vector3 _c)
  System.Boolean get_isValid()
  System.Void Calculate()
END_CLASS

CLASS: LimitPoint
TYPE:  class
TOKEN: 0x20000AF
FIELDS:
  public            UnityEngine.Vector3             point  // 0x10
  public            System.Single                   tangentWeight  // 0x1C
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Pose
TYPE:  class
TOKEN: 0x20000B4
FIELDS:
  public            System.Boolean                  visualize  // 0x10
  public            System.String                   name  // 0x18
  public            UnityEngine.Vector3             direction  // 0x20
  public            System.Single                   yaw  // 0x2C
  public            System.Single                   pitch  // 0x30
  private           System.Single                   angleBuffer  // 0x34
METHODS:
  System.Boolean IsInDirection(UnityEngine.Vector3 d)
  System.Void SetAngleBuffer(System.Single value)
  System.Void .ctor()
END_CLASS

CLASS: EffectorLink
TYPE:  class
TOKEN: 0x20000B7
FIELDS:
  public            RootMotion.FinalIK.FullBodyBipedEffectoreffector  // 0x10
  public            System.Single                   weight  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Body
TYPE:  class
TOKEN: 0x20000B6
FIELDS:
  public            UnityEngine.Transform           transform  // 0x10
  public            UnityEngine.Transform           relativeTo  // 0x18
  public            RootMotion.FinalIK.Amplifier.Body.EffectorLink[]effectorLinks  // 0x20
  public            System.Single                   verticalWeight  // 0x28
  public            System.Single                   horizontalWeight  // 0x2C
  public            System.Single                   speed  // 0x30
  private           UnityEngine.Vector3             lastRelativePos  // 0x34
  private           UnityEngine.Vector3             smoothDelta  // 0x40
  private           System.Boolean                  firstUpdate  // 0x4C
METHODS:
  System.Void Update(RootMotion.FinalIK.IKSolverFullBodyBiped solver, System.Single w, System.Single deltaTime)
  UnityEngine.Vector3 Multiply(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2)
  System.Void .ctor()
END_CLASS

CLASS: HitPoint
TYPE:  class
TOKEN: 0x20000BD
FIELDS:
  public            System.String                   name  // 0x10
  public            UnityEngine.Collider            collider  // 0x18
  private           System.Single                   crossFadeTime  // 0x20
  private           System.Single                   <crossFader>k__BackingField  // 0x24
  private           System.Single                   <timer>k__BackingField  // 0x28
  private           UnityEngine.Vector3             <force>k__BackingField  // 0x2C
  private           System.Single                   length  // 0x38
  private           System.Single                   crossFadeSpeed  // 0x3C
  private           System.Single                   lastTime  // 0x40
METHODS:
  System.Boolean get_inProgress()
  System.Single get_crossFader()
  System.Void set_crossFader(System.Single value)
  System.Single get_timer()
  System.Void set_timer(System.Single value)
  UnityEngine.Vector3 get_force()
  System.Void set_force(UnityEngine.Vector3 value)
  System.Void Hit(UnityEngine.Vector3 force, UnityEngine.Vector3 point)
  System.Void Apply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, System.Single weight)
  System.Single GetLength()
  System.Void CrossFadeStart()
  System.Void OnApply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, System.Single weight)
  System.Void .ctor()
END_CLASS

CLASS: EffectorLink
TYPE:  class
TOKEN: 0x20000BF
FIELDS:
  public            RootMotion.FinalIK.FullBodyBipedEffectoreffector  // 0x10
  public            System.Single                   weight  // 0x14
  private           UnityEngine.Vector3             lastValue  // 0x18
  private           UnityEngine.Vector3             current  // 0x24
METHODS:
  System.Void Apply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, UnityEngine.Vector3 offset, System.Single crossFader)
  System.Void CrossFadeStart()
  System.Void .ctor()
END_CLASS

CLASS: HitPointEffector
TYPE:  class
TOKEN: 0x20000BE
EXTENDS: HitPoint
FIELDS:
  public            UnityEngine.AnimationCurve      offsetInForceDirection  // 0x48
  public            UnityEngine.AnimationCurve      offsetInUpDirection  // 0x50
  public            RootMotion.FinalIK.HitReaction.HitPointEffector.EffectorLink[]effectorLinks  // 0x58
METHODS:
  System.Single GetLength()
  System.Void CrossFadeStart()
  System.Void OnApply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, System.Single weight)
  System.Void .ctor()
END_CLASS

CLASS: BoneLink
TYPE:  class
TOKEN: 0x20000C1
FIELDS:
  public            UnityEngine.Transform           bone  // 0x10
  public            System.Single                   weight  // 0x18
  private           UnityEngine.Quaternion          lastValue  // 0x1C
  private           UnityEngine.Quaternion          current  // 0x2C
METHODS:
  System.Void Apply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, UnityEngine.Quaternion offset, System.Single crossFader)
  System.Void CrossFadeStart()
  System.Void .ctor()
END_CLASS

CLASS: HitPointBone
TYPE:  class
TOKEN: 0x20000C0
EXTENDS: HitPoint
FIELDS:
  public            UnityEngine.AnimationCurve      aroundCenterOfMass  // 0x48
  public            RootMotion.FinalIK.HitReaction.HitPointBone.BoneLink[]boneLinks  // 0x50
  private           UnityEngine.Rigidbody           rigidbody  // 0x58
  private           UnityEngine.Vector3             comAxis  // 0x60
METHODS:
  System.Void Hit(UnityEngine.Vector3 force, UnityEngine.Vector3 point)
  System.Single GetLength()
  System.Void CrossFadeStart()
  System.Void OnApply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, System.Single weight)
  System.Void .ctor()
END_CLASS

CLASS: Offset
TYPE:  class
TOKEN: 0x20000C3
FIELDS:
  public            System.String                   name  // 0x10
  public            UnityEngine.Collider            collider  // 0x18
  private           System.Single                   crossFadeTime  // 0x20
  private           System.Single                   <crossFader>k__BackingField  // 0x24
  private           System.Single                   <timer>k__BackingField  // 0x28
  private           UnityEngine.Vector3             <force>k__BackingField  // 0x2C
  private           System.Single                   length  // 0x38
  private           System.Single                   crossFadeSpeed  // 0x3C
  private           System.Single                   lastTime  // 0x40
METHODS:
  System.Single get_crossFader()
  System.Void set_crossFader(System.Single value)
  System.Single get_timer()
  System.Void set_timer(System.Single value)
  UnityEngine.Vector3 get_force()
  System.Void set_force(UnityEngine.Vector3 value)
  System.Void Hit(UnityEngine.Vector3 force, UnityEngine.AnimationCurve[] curves, UnityEngine.Vector3 point)
  System.Void Apply(RootMotion.FinalIK.VRIK ik, UnityEngine.AnimationCurve[] curves, System.Single weight)
  System.Single GetLength(UnityEngine.AnimationCurve[] curves)
  System.Void CrossFadeStart()
  System.Void OnApply(RootMotion.FinalIK.VRIK ik, UnityEngine.AnimationCurve[] curves, System.Single weight)
  System.Void .ctor()
END_CLASS

CLASS: PositionOffsetLink
TYPE:  class
TOKEN: 0x20000C5
FIELDS:
  public            RootMotion.FinalIK.IKSolverVR.PositionOffsetpositionOffset  // 0x10
  public            System.Single                   weight  // 0x14
  private           UnityEngine.Vector3             lastValue  // 0x18
  private           UnityEngine.Vector3             current  // 0x24
METHODS:
  System.Void Apply(RootMotion.FinalIK.VRIK ik, UnityEngine.Vector3 offset, System.Single crossFader)
  System.Void CrossFadeStart()
  System.Void .ctor()
END_CLASS

CLASS: PositionOffset
TYPE:  class
TOKEN: 0x20000C4
EXTENDS: Offset
FIELDS:
  public            System.Int32                    forceDirCurveIndex  // 0x48
  public            System.Int32                    upDirCurveIndex  // 0x4C
  public            RootMotion.FinalIK.HitReactionVRIK.PositionOffset.PositionOffsetLink[]offsetLinks  // 0x50
METHODS:
  System.Single GetLength(UnityEngine.AnimationCurve[] curves)
  System.Void CrossFadeStart()
  System.Void OnApply(RootMotion.FinalIK.VRIK ik, UnityEngine.AnimationCurve[] curves, System.Single weight)
  System.Void .ctor()
END_CLASS

CLASS: RotationOffsetLink
TYPE:  class
TOKEN: 0x20000C7
FIELDS:
  public            RootMotion.FinalIK.IKSolverVR.RotationOffsetrotationOffset  // 0x10
  public            System.Single                   weight  // 0x14
  private           UnityEngine.Quaternion          lastValue  // 0x18
  private           UnityEngine.Quaternion          current  // 0x28
METHODS:
  System.Void Apply(RootMotion.FinalIK.VRIK ik, UnityEngine.Quaternion offset, System.Single crossFader)
  System.Void CrossFadeStart()
  System.Void .ctor()
END_CLASS

CLASS: RotationOffset
TYPE:  class
TOKEN: 0x20000C6
EXTENDS: Offset
FIELDS:
  public            System.Int32                    curveIndex  // 0x48
  public            RootMotion.FinalIK.HitReactionVRIK.RotationOffset.RotationOffsetLink[]offsetLinks  // 0x50
  private           UnityEngine.Rigidbody           rigidbody  // 0x58
  private           UnityEngine.Vector3             comAxis  // 0x60
METHODS:
  System.Void Hit(UnityEngine.Vector3 force, UnityEngine.AnimationCurve[] curves, UnityEngine.Vector3 point)
  System.Single GetLength(UnityEngine.AnimationCurve[] curves)
  System.Void CrossFadeStart()
  System.Void OnApply(RootMotion.FinalIK.VRIK ik, UnityEngine.AnimationCurve[] curves, System.Single weight)
  System.Void .ctor()
END_CLASS

CLASS: EffectorLink
TYPE:  class
TOKEN: 0x20000CA
FIELDS:
  public            RootMotion.FinalIK.FullBodyBipedEffectoreffector  // 0x10
  public            System.Single                   weight  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Body
TYPE:  class
TOKEN: 0x20000C9
FIELDS:
  public            UnityEngine.Transform           transform  // 0x10
  public            RootMotion.FinalIK.Inertia.Body.EffectorLink[]effectorLinks  // 0x18
  public            System.Single                   speed  // 0x20
  public            System.Single                   acceleration  // 0x24
  public            System.Single                   matchVelocity  // 0x28
  public            System.Single                   gravity  // 0x2C
  private           UnityEngine.Vector3             delta  // 0x30
  private           UnityEngine.Vector3             lazyPoint  // 0x3C
  private           UnityEngine.Vector3             direction  // 0x48
  private           UnityEngine.Vector3             lastPosition  // 0x54
  private           System.Boolean                  firstUpdate  // 0x60
METHODS:
  System.Void Reset()
  System.Void Update(RootMotion.FinalIK.IKSolverFullBodyBiped solver, System.Single weight, System.Single deltaTime)
  System.Void .ctor()
END_CLASS

CLASS: OffsetLimits
TYPE:  class
TOKEN: 0x20000CD
FIELDS:
  public            RootMotion.FinalIK.FullBodyBipedEffectoreffector  // 0x10
  public            System.Single                   spring  // 0x14
  public            System.Boolean                  x  // 0x18
  public            System.Boolean                  y  // 0x19
  public            System.Boolean                  z  // 0x1A
  public            System.Single                   minX  // 0x1C
  public            System.Single                   maxX  // 0x20
  public            System.Single                   minY  // 0x24
  public            System.Single                   maxY  // 0x28
  public            System.Single                   minZ  // 0x2C
  public            System.Single                   maxZ  // 0x30
METHODS:
  System.Void Apply(RootMotion.FinalIK.IKEffector e, UnityEngine.Quaternion rootRotation)
  System.Single SpringAxis(System.Single value, System.Single min, System.Single max)
  System.Single Spring(System.Single value, System.Single limit, System.Boolean negative)
  System.Void .ctor()
END_CLASS

CLASS: EffectorLink
TYPE:  class
TOKEN: 0x20000D2
FIELDS:
  public            RootMotion.FinalIK.FullBodyBipedEffectoreffector  // 0x10
  public            UnityEngine.Vector3             offset  // 0x14
  public            UnityEngine.Vector3             pin  // 0x20
  public            UnityEngine.Vector3             pinWeight  // 0x2C
METHODS:
  System.Void Apply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, System.Single weight, UnityEngine.Quaternion rotation)
  System.Void .ctor()
END_CLASS

CLASS: EffectorLink
TYPE:  class
TOKEN: 0x20000D5
FIELDS:
  public            RootMotion.FinalIK.FullBodyBipedEffectoreffector  // 0x10
  public            System.Single                   weight  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Avoider
TYPE:  class
TOKEN: 0x20000D4
FIELDS:
  public            UnityEngine.Transform[]         raycastFrom  // 0x10
  public            UnityEngine.Transform           raycastTo  // 0x18
  public            System.Single                   raycastRadius  // 0x20
  public            RootMotion.FinalIK.PenetrationAvoidance.Avoider.EffectorLink[]effectors  // 0x28
  public            System.Single                   smoothTimeIn  // 0x30
  public            System.Single                   smoothTimeOut  // 0x34
  public            UnityEngine.LayerMask           layers  // 0x38
  private           UnityEngine.Vector3             offset  // 0x3C
  private           UnityEngine.Vector3             offsetTarget  // 0x48
  private           UnityEngine.Vector3             offsetV  // 0x54
METHODS:
  System.Void Solve(RootMotion.FinalIK.IKSolverFullBodyBiped solver, System.Single weight)
  UnityEngine.Vector3 GetOffsetTarget(RootMotion.FinalIK.IKSolverFullBodyBiped solver)
  UnityEngine.Vector3 Raycast(UnityEngine.Vector3 from, UnityEngine.Vector3 to)
  System.Void .ctor()
END_CLASS

CLASS: EffectorLink
TYPE:  class
TOKEN: 0x20000D8
FIELDS:
  public            RootMotion.FinalIK.FullBodyBipedEffectoreffector  // 0x10
  public            System.Single                   weight  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: RecoilOffset
TYPE:  class
TOKEN: 0x20000D7
FIELDS:
  public            UnityEngine.Vector3             offset  // 0x10
  public            System.Single                   additivity  // 0x1C
  public            System.Single                   maxAdditiveOffsetMag  // 0x20
  public            RootMotion.FinalIK.Recoil.RecoilOffset.EffectorLink[]effectorLinks  // 0x28
  private           UnityEngine.Vector3             additiveOffset  // 0x30
  private           UnityEngine.Vector3             lastOffset  // 0x3C
METHODS:
  System.Void Start()
  System.Void Apply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, UnityEngine.Quaternion rotation, System.Single masterWeight, System.Single length, System.Single timeLeft)
  System.Void .ctor()
END_CLASS

CLASS: Handedness
TYPE:  struct
TOKEN: 0x20000D9
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  RootMotion.FinalIK.Recoil.HandednessRight  // 0x0
  public    static  RootMotion.FinalIK.Recoil.HandednessLeft  // 0x0
METHODS:
END_CLASS

CLASS: Settings
TYPE:  class
TOKEN: 0x20000DC
FIELDS:
  public            System.Single                   scaleMlp  // 0x10
  public            UnityEngine.Vector3             headTrackerForward  // 0x14
  public            UnityEngine.Vector3             headTrackerUp  // 0x20
  public            UnityEngine.Vector3             handTrackerForward  // 0x2C
  public            UnityEngine.Vector3             handTrackerUp  // 0x38
  public            UnityEngine.Vector3             footTrackerForward  // 0x44
  public            UnityEngine.Vector3             footTrackerUp  // 0x50
  public            UnityEngine.Vector3             headOffset  // 0x5C
  public            UnityEngine.Vector3             handOffset  // 0x68
  public            System.Single                   footForwardOffset  // 0x74
  public            System.Single                   footInwardOffset  // 0x78
  public            System.Single                   footHeadingOffset  // 0x7C
  public            System.Single                   pelvisPositionWeight  // 0x80
  public            System.Single                   pelvisRotationWeight  // 0x84
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Target
TYPE:  class
TOKEN: 0x20000DE
FIELDS:
  public            System.Boolean                  used  // 0x10
  public            UnityEngine.Vector3             localPosition  // 0x14
  public            UnityEngine.Quaternion          localRotation  // 0x20
METHODS:
  System.Void .ctor(UnityEngine.Transform t)
  System.Void SetTo(UnityEngine.Transform t)
END_CLASS

CLASS: CalibrationData
TYPE:  class
TOKEN: 0x20000DD
FIELDS:
  public            System.Single                   scale  // 0x10
  public            RootMotion.FinalIK.VRIKCalibrator.CalibrationData.Targethead  // 0x18
  public            RootMotion.FinalIK.VRIKCalibrator.CalibrationData.TargetleftHand  // 0x20
  public            RootMotion.FinalIK.VRIKCalibrator.CalibrationData.TargetrightHand  // 0x28
  public            RootMotion.FinalIK.VRIKCalibrator.CalibrationData.Targetpelvis  // 0x30
  public            RootMotion.FinalIK.VRIKCalibrator.CalibrationData.TargetleftFoot  // 0x38
  public            RootMotion.FinalIK.VRIKCalibrator.CalibrationData.TargetrightFoot  // 0x40
  public            RootMotion.FinalIK.VRIKCalibrator.CalibrationData.TargetleftLegGoal  // 0x48
  public            RootMotion.FinalIK.VRIKCalibrator.CalibrationData.TargetrightLegGoal  // 0x50
  public            UnityEngine.Vector3             pelvisTargetRight  // 0x58
  public            System.Single                   pelvisPositionWeight  // 0x64
  public            System.Single                   pelvisRotationWeight  // 0x68
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: __StaticArrayInitTypeSize=16
TYPE:  struct
TOKEN: 0x20000E2
FIELDS:
METHODS:
END_CLASS

CLASS: RootMotion.Baker
TYPE:  class
TOKEN: 0x2000002
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Int32                    frameRate  // 0x18
  public            System.Single                   keyReductionError  // 0x1C
  public            RootMotion.Baker.Mode           mode  // 0x20
  public            UnityEngine.AnimationClip[]     animationClips  // 0x28
  public            System.String[]                 animationStates  // 0x30
  public            System.String                   saveToFolder  // 0x38
  public            System.String                   appendName  // 0x40
  public            System.String                   saveName  // 0x48
  private           System.Boolean                  <isBaking>k__BackingField  // 0x50
  private           System.Single                   <bakingProgress>k__BackingField  // 0x54
  public            UnityEngine.Animator            animator  // 0x58
  public            UnityEngine.Playables.PlayableDirectordirector  // 0x60
  public            RootMotion.Baker.BakerDelegate  OnStartClip  // 0x68
  public            RootMotion.Baker.BakerDelegate  OnUpdateClip  // 0x70
  public            System.Boolean                  inheritClipSettings  // 0x78
  public            RootMotion.Baker.ClipSettings   clipSettings  // 0x80
  private           System.Single                   <clipLength>k__BackingField  // 0x88
  protected         System.Boolean                  addLoopFrame  // 0x8C
METHODS:
  System.Void OpenUserManual()
  System.Void OpenScriptReference()
  System.Void SupportGroup()
  System.Void ASThread()
  System.Boolean get_isBaking()
  System.Void set_isBaking(System.Boolean value)
  System.Single get_bakingProgress()
  System.Void set_bakingProgress(System.Single value)
  UnityEngine.Transform GetCharacterRoot()
  System.Void OnStartBaking()
  System.Void OnSetLoopFrame(System.Single time)
  System.Void OnSetCurves(UnityEngine.AnimationClip& clip)
  System.Void OnSetKeyframes(System.Single time, System.Boolean lastFrame)
  System.Single get_clipLength()
  System.Void set_clipLength(System.Single value)
  System.Void BakeClip()
  System.Void StartBaking()
  System.Void StopBaking()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.GenericBaker
TYPE:  class
TOKEN: 0x2000009
EXTENDS: Baker
FIELDS:
  public            System.Boolean                  markAsLegacy  // 0x90
  public            UnityEngine.Transform           root  // 0x98
  public            UnityEngine.Transform           rootNode  // 0xA0
  public            UnityEngine.Transform[]         ignoreList  // 0xA8
  public            UnityEngine.Transform[]         bakePositionList  // 0xB0
  private           RootMotion.BakerTransform[]     children  // 0xB8
  private           RootMotion.BakerTransform       rootChild  // 0xC0
  private           System.Int32                    rootChildIndex  // 0xC8
METHODS:
  System.Void Awake()
  UnityEngine.Transform GetCharacterRoot()
  System.Void OnStartBaking()
  System.Void OnSetLoopFrame(System.Single time)
  System.Void OnSetCurves(UnityEngine.AnimationClip& clip)
  System.Void OnSetKeyframes(System.Single time, System.Boolean lastFrame)
  System.Boolean IsIgnored(UnityEngine.Transform t)
  System.Boolean BakePosition(UnityEngine.Transform t)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.TQ
TYPE:  class
TOKEN: 0x200000A
FIELDS:
  public            UnityEngine.Vector3             t  // 0x10
  public            UnityEngine.Quaternion          q  // 0x1C
METHODS:
  System.Void .ctor()
  System.Void .ctor(UnityEngine.Vector3 translation, UnityEngine.Quaternion rotation)
END_CLASS

CLASS: RootMotion.AvatarUtility
TYPE:  class
TOKEN: 0x200000B
FIELDS:
METHODS:
  UnityEngine.Quaternion GetPostRotation(UnityEngine.Avatar avatar, UnityEngine.AvatarIKGoal avatarIKGoal)
  RootMotion.TQ GetIKGoalTQ(UnityEngine.Avatar avatar, System.Single humanScale, UnityEngine.AvatarIKGoal avatarIKGoal, RootMotion.TQ bodyPositionRotation, RootMotion.TQ boneTQ)
  RootMotion.TQ WorldSpaceIKGoalToBone(RootMotion.TQ goalTQ, UnityEngine.Avatar avatar, UnityEngine.AvatarIKGoal avatarIKGoal)
  RootMotion.TQ GetWorldSpaceIKGoal(RootMotion.BakerHumanoidQT ikQT, RootMotion.BakerHumanoidQT rootQT, System.Single time, System.Single humanScale)
  UnityEngine.HumanBodyBones HumanIDFromAvatarIKGoal(UnityEngine.AvatarIKGoal avatarIKGoal)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.BakerUtilities
TYPE:  class
TOKEN: 0x200000C
FIELDS:
METHODS:
  System.Void ReduceKeyframes(UnityEngine.AnimationCurve curve, System.Single maxError)
  UnityEngine.Keyframe[] GetReducedKeyframes(UnityEngine.AnimationCurve curve, System.Single maxError)
  System.Void SetLoopFrame(System.Single time, UnityEngine.AnimationCurve curve)
  System.Void SetTangentMode(UnityEngine.AnimationCurve curve)
  UnityEngine.Quaternion EnsureQuaternionContinuity(UnityEngine.Quaternion lastQ, UnityEngine.Quaternion q)
END_CLASS

CLASS: RootMotion.BakerHumanoidQT
TYPE:  class
TOKEN: 0x200000D
FIELDS:
  private           UnityEngine.Transform           transform  // 0x10
  private           System.String                   Qx  // 0x18
  private           System.String                   Qy  // 0x20
  private           System.String                   Qz  // 0x28
  private           System.String                   Qw  // 0x30
  private           System.String                   Tx  // 0x38
  private           System.String                   Ty  // 0x40
  private           System.String                   Tz  // 0x48
  public            UnityEngine.AnimationCurve      rotX  // 0x50
  public            UnityEngine.AnimationCurve      rotY  // 0x58
  public            UnityEngine.AnimationCurve      rotZ  // 0x60
  public            UnityEngine.AnimationCurve      rotW  // 0x68
  public            UnityEngine.AnimationCurve      posX  // 0x70
  public            UnityEngine.AnimationCurve      posY  // 0x78
  public            UnityEngine.AnimationCurve      posZ  // 0x80
  private           UnityEngine.AvatarIKGoal        goal  // 0x88
  private           UnityEngine.Quaternion          lastQ  // 0x8C
  private           System.Boolean                  lastQSet  // 0x9C
METHODS:
  System.Void .ctor(System.String name)
  System.Void .ctor(UnityEngine.Transform transform, UnityEngine.AvatarIKGoal goal, System.String name)
  UnityEngine.Quaternion EvaluateRotation(System.Single time)
  UnityEngine.Vector3 EvaluatePosition(System.Single time)
  RootMotion.TQ Evaluate(System.Single time)
  System.Void GetCurvesFromClip(UnityEngine.AnimationClip clip, UnityEngine.Animator animator)
  System.Void Reset()
  System.Void SetIKKeyframes(System.Single time, UnityEngine.Avatar avatar, UnityEngine.Transform root, System.Single humanScale, UnityEngine.Vector3 bodyPosition, UnityEngine.Quaternion bodyRotation)
  System.Void SetKeyframes(System.Single time, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
  System.Void MoveLastKeyframes(System.Single time)
  System.Void SetLoopFrame(System.Single time)
  System.Void SetRootLoopFrame(System.Single time)
  System.Void MoveLastKeyframe(System.Single time, UnityEngine.AnimationCurve curve)
  System.Void MultiplyLength(UnityEngine.AnimationCurve curve, System.Single mlp)
  System.Void SetCurves(UnityEngine.AnimationClip& clip, System.Single maxError, System.Single lengthMlp)
END_CLASS

CLASS: RootMotion.BakerMuscle
TYPE:  class
TOKEN: 0x200000E
FIELDS:
  public            UnityEngine.AnimationCurve      curve  // 0x10
  private           System.Int32                    muscleIndex  // 0x18
  private           System.String                   propertyName  // 0x20
METHODS:
  System.Void .ctor(System.Int32 muscleIndex)
  System.String MuscleNameToPropertyName(System.String n)
  System.Void MultiplyLength(UnityEngine.AnimationCurve curve, System.Single mlp)
  System.Void SetCurves(UnityEngine.AnimationClip& clip, System.Single maxError, System.Single lengthMlp)
  System.Void Reset()
  System.Void SetKeyframe(System.Single time, System.Single[] muscles)
  System.Void SetLoopFrame(System.Single time)
END_CLASS

CLASS: RootMotion.BakerTransform
TYPE:  class
TOKEN: 0x200000F
FIELDS:
  public            UnityEngine.Transform           transform  // 0x10
  public            UnityEngine.AnimationCurve      posX  // 0x18
  public            UnityEngine.AnimationCurve      posY  // 0x20
  public            UnityEngine.AnimationCurve      posZ  // 0x28
  public            UnityEngine.AnimationCurve      rotX  // 0x30
  public            UnityEngine.AnimationCurve      rotY  // 0x38
  public            UnityEngine.AnimationCurve      rotZ  // 0x40
  public            UnityEngine.AnimationCurve      rotW  // 0x48
  private           System.String                   relativePath  // 0x50
  private           System.Boolean                  recordPosition  // 0x58
  private           UnityEngine.Vector3             relativePosition  // 0x5C
  private           System.Boolean                  isRootNode  // 0x68
  private           UnityEngine.Quaternion          relativeRotation  // 0x6C
METHODS:
  System.Void .ctor(UnityEngine.Transform transform, UnityEngine.Transform root, System.Boolean recordPosition, System.Boolean isRootNode)
  System.Void SetRelativeSpace(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  System.Void SetCurves(UnityEngine.AnimationClip& clip)
  System.Void AddRootMotionCurves(UnityEngine.AnimationClip& clip)
  System.Void Reset()
  System.Void ReduceKeyframes(System.Single maxError)
  System.Void SetKeyframes(System.Single time)
  System.Void AddLoopFrame(System.Single time)
END_CLASS

CLASS: RootMotion.HumanoidBaker
TYPE:  class
TOKEN: 0x2000010
EXTENDS: Baker
FIELDS:
  public            System.Boolean                  bakeHandIK  // 0x90
  public            System.Single                   IKKeyReductionError  // 0x94
  public            System.Int32                    muscleFrameRateDiv  // 0x98
  private           RootMotion.BakerMuscle[]        bakerMuscles  // 0xA0
  private           RootMotion.BakerHumanoidQT      rootQT  // 0xA8
  private           RootMotion.BakerHumanoidQT      leftFootQT  // 0xB0
  private           RootMotion.BakerHumanoidQT      rightFootQT  // 0xB8
  private           RootMotion.BakerHumanoidQT      leftHandQT  // 0xC0
  private           RootMotion.BakerHumanoidQT      rightHandQT  // 0xC8
  private           System.Single[]                 muscles  // 0xD0
  private           UnityEngine.HumanPose           pose  // 0xD8
  private           UnityEngine.HumanPoseHandler    handler  // 0x100
  private           UnityEngine.Vector3             bodyPosition  // 0x108
  private           UnityEngine.Quaternion          bodyRotation  // 0x114
  private           System.Int32                    mN  // 0x124
  private           UnityEngine.Quaternion          lastBodyRotation  // 0x128
METHODS:
  System.Void Awake()
  UnityEngine.Transform GetCharacterRoot()
  System.Void OnStartBaking()
  System.Void OnSetLoopFrame(System.Single time)
  System.Void OnSetCurves(UnityEngine.AnimationClip& clip)
  System.Void OnSetKeyframes(System.Single time, System.Boolean lastFrame)
  System.Void UpdateHumanPose()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.Axis
TYPE:  struct
TOKEN: 0x2000011
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  RootMotion.Axis                 X  // 0x0
  public    static  RootMotion.Axis                 Y  // 0x0
  public    static  RootMotion.Axis                 Z  // 0x0
METHODS:
END_CLASS

CLASS: RootMotion.AxisTools
TYPE:  class
TOKEN: 0x2000012
FIELDS:
METHODS:
  UnityEngine.Vector3 ToVector3(RootMotion.Axis axis)
  RootMotion.Axis ToAxis(UnityEngine.Vector3 v)
  RootMotion.Axis GetAxisToPoint(UnityEngine.Transform t, UnityEngine.Vector3 worldPosition)
  RootMotion.Axis GetAxisToDirection(UnityEngine.Transform t, UnityEngine.Vector3 direction)
  UnityEngine.Vector3 GetAxisVectorToPoint(UnityEngine.Transform t, UnityEngine.Vector3 worldPosition)
  UnityEngine.Vector3 GetAxisVectorToDirection(UnityEngine.Transform t, UnityEngine.Vector3 direction)
  UnityEngine.Vector3 GetAxisVectorToDirection(UnityEngine.Quaternion r, UnityEngine.Vector3 direction)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.BipedLimbOrientations
TYPE:  class
TOKEN: 0x2000013
FIELDS:
  public            RootMotion.BipedLimbOrientations.LimbOrientationleftArm  // 0x10
  public            RootMotion.BipedLimbOrientations.LimbOrientationrightArm  // 0x18
  public            RootMotion.BipedLimbOrientations.LimbOrientationleftLeg  // 0x20
  public            RootMotion.BipedLimbOrientations.LimbOrientationrightLeg  // 0x28
METHODS:
  System.Void .ctor(RootMotion.BipedLimbOrientations.LimbOrientation leftArm, RootMotion.BipedLimbOrientations.LimbOrientation rightArm, RootMotion.BipedLimbOrientations.LimbOrientation leftLeg, RootMotion.BipedLimbOrientations.LimbOrientation rightLeg)
  RootMotion.BipedLimbOrientations get_UMA()
  RootMotion.BipedLimbOrientations get_MaxBiped()
END_CLASS

CLASS: RootMotion.BipedNaming
TYPE:  class
TOKEN: 0x2000015
FIELDS:
  public    static  System.String[]                 typeLeft  // 0x0
  public    static  System.String[]                 typeRight  // 0x8
  public    static  System.String[]                 typeSpine  // 0x10
  public    static  System.String[]                 typeHead  // 0x18
  public    static  System.String[]                 typeArm  // 0x20
  public    static  System.String[]                 typeLeg  // 0x28
  public    static  System.String[]                 typeTail  // 0x30
  public    static  System.String[]                 typeEye  // 0x38
  public    static  System.String[]                 typeExclude  // 0x40
  public    static  System.String[]                 typeExcludeSpine  // 0x48
  public    static  System.String[]                 typeExcludeHead  // 0x50
  public    static  System.String[]                 typeExcludeArm  // 0x58
  public    static  System.String[]                 typeExcludeLeg  // 0x60
  public    static  System.String[]                 typeExcludeTail  // 0x68
  public    static  System.String[]                 typeExcludeEye  // 0x70
  public    static  System.String[]                 pelvis  // 0x78
  public    static  System.String[]                 hand  // 0x80
  public    static  System.String[]                 foot  // 0x88
METHODS:
  UnityEngine.Transform[] GetBonesOfType(RootMotion.BipedNaming.BoneType boneType, UnityEngine.Transform[] bones)
  UnityEngine.Transform[] GetBonesOfSide(RootMotion.BipedNaming.BoneSide boneSide, UnityEngine.Transform[] bones)
  UnityEngine.Transform[] GetBonesOfTypeAndSide(RootMotion.BipedNaming.BoneType boneType, RootMotion.BipedNaming.BoneSide boneSide, UnityEngine.Transform[] bones)
  UnityEngine.Transform GetFirstBoneOfTypeAndSide(RootMotion.BipedNaming.BoneType boneType, RootMotion.BipedNaming.BoneSide boneSide, UnityEngine.Transform[] bones)
  UnityEngine.Transform GetNamingMatch(UnityEngine.Transform[] transforms, System.String[][] namings)
  RootMotion.BipedNaming.BoneType GetBoneType(System.String boneName)
  RootMotion.BipedNaming.BoneSide GetBoneSide(System.String boneName)
  UnityEngine.Transform GetBone(UnityEngine.Transform[] transforms, RootMotion.BipedNaming.BoneType boneType, RootMotion.BipedNaming.BoneSide boneSide, System.String[][] namings)
  System.Boolean isLeft(System.String boneName)
  System.Boolean isRight(System.String boneName)
  System.Boolean isSpine(System.String boneName)
  System.Boolean isHead(System.String boneName)
  System.Boolean isArm(System.String boneName)
  System.Boolean isLeg(System.String boneName)
  System.Boolean isTail(System.String boneName)
  System.Boolean isEye(System.String boneName)
  System.Boolean isTypeExclude(System.String boneName)
  System.Boolean matchesNaming(System.String boneName, System.String[] namingConvention)
  System.Boolean excludesNaming(System.String boneName, System.String[] namingConvention)
  System.Boolean matchesLastLetter(System.String boneName, System.String[] namingConvention)
  System.Boolean LastLetterIs(System.String boneName, System.String letter)
  System.String firstLetter(System.String boneName)
  System.String lastLetter(System.String boneName)
  System.Void .cctor()
END_CLASS

CLASS: RootMotion.BipedReferences
TYPE:  class
TOKEN: 0x2000018
FIELDS:
  public            UnityEngine.Transform           root  // 0x10
  public            UnityEngine.Transform           pelvis  // 0x18
  public            UnityEngine.Transform           leftThigh  // 0x20
  public            UnityEngine.Transform           leftCalf  // 0x28
  public            UnityEngine.Transform           leftFoot  // 0x30
  public            UnityEngine.Transform           rightThigh  // 0x38
  public            UnityEngine.Transform           rightCalf  // 0x40
  public            UnityEngine.Transform           rightFoot  // 0x48
  public            UnityEngine.Transform           leftUpperArm  // 0x50
  public            UnityEngine.Transform           leftForearm  // 0x58
  public            UnityEngine.Transform           leftHand  // 0x60
  public            UnityEngine.Transform           rightUpperArm  // 0x68
  public            UnityEngine.Transform           rightForearm  // 0x70
  public            UnityEngine.Transform           rightHand  // 0x78
  public            UnityEngine.Transform           head  // 0x80
  public            UnityEngine.Transform[]         spine  // 0x88
  public            UnityEngine.Transform[]         eyes  // 0x90
METHODS:
  System.Boolean get_isFilled()
  System.Boolean get_isEmpty()
  System.Boolean IsEmpty(System.Boolean includeRoot)
  System.Boolean Contains(UnityEngine.Transform t, System.Boolean ignoreRoot)
  System.Boolean AutoDetectReferences(RootMotion.BipedReferences& references, UnityEngine.Transform root, RootMotion.BipedReferences.AutoDetectParams autoDetectParams)
  System.Void DetectReferencesByNaming(RootMotion.BipedReferences& references, UnityEngine.Transform root, RootMotion.BipedReferences.AutoDetectParams autoDetectParams)
  System.Void AssignHumanoidReferences(RootMotion.BipedReferences& references, UnityEngine.Animator animator, RootMotion.BipedReferences.AutoDetectParams autoDetectParams)
  System.Boolean SetupError(RootMotion.BipedReferences references, System.String& errorMessage)
  System.Boolean SetupWarning(RootMotion.BipedReferences references, System.String& warningMessage)
  System.Boolean IsNeckBone(UnityEngine.Transform bone, UnityEngine.Transform leftUpperArm)
  System.Boolean AddBoneToEyes(UnityEngine.Transform bone, RootMotion.BipedReferences& references, RootMotion.BipedReferences.AutoDetectParams autoDetectParams)
  System.Boolean AddBoneToSpine(UnityEngine.Transform bone, RootMotion.BipedReferences& references, RootMotion.BipedReferences.AutoDetectParams autoDetectParams)
  System.Void DetectLimb(RootMotion.BipedNaming.BoneType boneType, RootMotion.BipedNaming.BoneSide boneSide, UnityEngine.Transform& firstBone, UnityEngine.Transform& secondBone, UnityEngine.Transform& lastBone, UnityEngine.Transform[] transforms)
  System.Void AddBoneToHierarchy(UnityEngine.Transform[]& bones, UnityEngine.Transform transform)
  System.Boolean LimbError(UnityEngine.Transform bone1, UnityEngine.Transform bone2, UnityEngine.Transform bone3, System.String& errorMessage)
  System.Boolean LimbWarning(UnityEngine.Transform bone1, UnityEngine.Transform bone2, UnityEngine.Transform bone3, System.String& warningMessage)
  System.Boolean SpineError(RootMotion.BipedReferences references, System.String& errorMessage)
  System.Boolean SpineWarning(RootMotion.BipedReferences references, System.String& warningMessage)
  System.Boolean EyesError(RootMotion.BipedReferences references, System.String& errorMessage)
  System.Boolean EyesWarning(RootMotion.BipedReferences references, System.String& warningMessage)
  System.Boolean RootHeightWarning(RootMotion.BipedReferences references, System.String& warningMessage)
  System.Boolean FacingAxisWarning(RootMotion.BipedReferences references, System.String& warningMessage)
  System.Single GetVerticalOffset(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Quaternion rotation)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.Comments
TYPE:  class
TOKEN: 0x200001A
EXTENDS: MonoBehaviour
FIELDS:
  public            System.String                   text  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.DemoGUIMessage
TYPE:  class
TOKEN: 0x200001B
EXTENDS: MonoBehaviour
FIELDS:
  public            System.String                   text  // 0x18
  public            UnityEngine.Color               color  // 0x20
METHODS:
  System.Void OnGUI()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.Hierarchy
TYPE:  class
TOKEN: 0x200001C
FIELDS:
METHODS:
  System.Boolean HierarchyIsValid(UnityEngine.Transform[] bones)
  UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
  System.Boolean IsAncestor(UnityEngine.Transform transform, UnityEngine.Transform ancestor)
  System.Boolean ContainsChild(UnityEngine.Transform transform, UnityEngine.Transform child)
  System.Void AddAncestors(UnityEngine.Transform transform, UnityEngine.Transform blocker, UnityEngine.Transform[]& array)
  UnityEngine.Transform GetAncestor(UnityEngine.Transform transform, System.Int32 minChildCount)
  UnityEngine.Transform GetFirstCommonAncestor(UnityEngine.Transform t1, UnityEngine.Transform t2)
  UnityEngine.Transform GetFirstCommonAncestor(UnityEngine.Transform[] transforms)
  UnityEngine.Transform GetFirstCommonAncestorRecursive(UnityEngine.Transform transform, UnityEngine.Transform[] transforms)
  System.Boolean IsCommonAncestor(UnityEngine.Transform transform, UnityEngine.Transform[] transforms)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.InspectorComment
TYPE:  class
TOKEN: 0x200001D
EXTENDS: PropertyAttribute
FIELDS:
  public            System.String                   name  // 0x10
  public            System.String                   color  // 0x18
METHODS:
  System.Void .ctor(System.String name)
  System.Void .ctor(System.String name, System.String color)
END_CLASS

CLASS: RootMotion.InterpolationMode
TYPE:  struct
TOKEN: 0x200001E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  RootMotion.InterpolationMode    None  // 0x0
  public    static  RootMotion.InterpolationMode    InOutCubic  // 0x0
  public    static  RootMotion.InterpolationMode    InOutQuintic  // 0x0
  public    static  RootMotion.InterpolationMode    InOutSine  // 0x0
  public    static  RootMotion.InterpolationMode    InQuintic  // 0x0
  public    static  RootMotion.InterpolationMode    InQuartic  // 0x0
  public    static  RootMotion.InterpolationMode    InCubic  // 0x0
  public    static  RootMotion.InterpolationMode    InQuadratic  // 0x0
  public    static  RootMotion.InterpolationMode    InElastic  // 0x0
  public    static  RootMotion.InterpolationMode    InElasticSmall  // 0x0
  public    static  RootMotion.InterpolationMode    InElasticBig  // 0x0
  public    static  RootMotion.InterpolationMode    InSine  // 0x0
  public    static  RootMotion.InterpolationMode    InBack  // 0x0
  public    static  RootMotion.InterpolationMode    OutQuintic  // 0x0
  public    static  RootMotion.InterpolationMode    OutQuartic  // 0x0
  public    static  RootMotion.InterpolationMode    OutCubic  // 0x0
  public    static  RootMotion.InterpolationMode    OutInCubic  // 0x0
  public    static  RootMotion.InterpolationMode    OutInQuartic  // 0x0
  public    static  RootMotion.InterpolationMode    OutElastic  // 0x0
  public    static  RootMotion.InterpolationMode    OutElasticSmall  // 0x0
  public    static  RootMotion.InterpolationMode    OutElasticBig  // 0x0
  public    static  RootMotion.InterpolationMode    OutSine  // 0x0
  public    static  RootMotion.InterpolationMode    OutBack  // 0x0
  public    static  RootMotion.InterpolationMode    OutBackCubic  // 0x0
  public    static  RootMotion.InterpolationMode    OutBackQuartic  // 0x0
  public    static  RootMotion.InterpolationMode    BackInCubic  // 0x0
  public    static  RootMotion.InterpolationMode    BackInQuartic  // 0x0
METHODS:
END_CLASS

CLASS: RootMotion.Interp
TYPE:  class
TOKEN: 0x200001F
FIELDS:
METHODS:
  System.Single Float(System.Single t, RootMotion.InterpolationMode mode)
  UnityEngine.Vector3 V3(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, System.Single t, RootMotion.InterpolationMode mode)
  System.Single LerpValue(System.Single value, System.Single target, System.Single increaseSpeed, System.Single decreaseSpeed)
  System.Single None(System.Single t, System.Single b, System.Single c)
  System.Single InOutCubic(System.Single t, System.Single b, System.Single c)
  System.Single InOutQuintic(System.Single t, System.Single b, System.Single c)
  System.Single InQuintic(System.Single t, System.Single b, System.Single c)
  System.Single InQuartic(System.Single t, System.Single b, System.Single c)
  System.Single InCubic(System.Single t, System.Single b, System.Single c)
  System.Single InQuadratic(System.Single t, System.Single b, System.Single c)
  System.Single OutQuintic(System.Single t, System.Single b, System.Single c)
  System.Single OutQuartic(System.Single t, System.Single b, System.Single c)
  System.Single OutCubic(System.Single t, System.Single b, System.Single c)
  System.Single OutInCubic(System.Single t, System.Single b, System.Single c)
  System.Single OutInQuartic(System.Single t, System.Single b, System.Single c)
  System.Single BackInCubic(System.Single t, System.Single b, System.Single c)
  System.Single BackInQuartic(System.Single t, System.Single b, System.Single c)
  System.Single OutBackCubic(System.Single t, System.Single b, System.Single c)
  System.Single OutBackQuartic(System.Single t, System.Single b, System.Single c)
  System.Single OutElasticSmall(System.Single t, System.Single b, System.Single c)
  System.Single OutElasticBig(System.Single t, System.Single b, System.Single c)
  System.Single InElasticSmall(System.Single t, System.Single b, System.Single c)
  System.Single InElasticBig(System.Single t, System.Single b, System.Single c)
  System.Single InSine(System.Single t, System.Single b, System.Single c)
  System.Single OutSine(System.Single t, System.Single b, System.Single c)
  System.Single InOutSine(System.Single t, System.Single b, System.Single c)
  System.Single InElastic(System.Single t, System.Single b, System.Single c)
  System.Single OutElastic(System.Single t, System.Single b, System.Single c)
  System.Single InBack(System.Single t, System.Single b, System.Single c)
  System.Single OutBack(System.Single t, System.Single b, System.Single c)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.LayerMaskExtensions
TYPE:  class
TOKEN: 0x2000020
FIELDS:
METHODS:
  System.Boolean Contains(UnityEngine.LayerMask mask, System.Int32 layer)
  UnityEngine.LayerMask Create(System.String[] layerNames)
  UnityEngine.LayerMask Create(System.Int32[] layerNumbers)
  UnityEngine.LayerMask NamesToMask(System.String[] layerNames)
  UnityEngine.LayerMask LayerNumbersToMask(System.Int32[] layerNumbers)
  UnityEngine.LayerMask Inverse(UnityEngine.LayerMask original)
  UnityEngine.LayerMask AddToMask(UnityEngine.LayerMask original, System.String[] layerNames)
  UnityEngine.LayerMask RemoveFromMask(UnityEngine.LayerMask original, System.String[] layerNames)
  System.String[] MaskToNames(UnityEngine.LayerMask original)
  System.Int32[] MaskToNumbers(UnityEngine.LayerMask original)
  System.String MaskToString(UnityEngine.LayerMask original)
  System.String MaskToString(UnityEngine.LayerMask original, System.String delimiter)
END_CLASS

CLASS: RootMotion.LazySingleton`1
TYPE:  class
TOKEN: 0x2000021
EXTENDS: MonoBehaviour
FIELDS:
  private   static  T                               sInstance  // 0x0
METHODS:
  System.Boolean get_hasInstance()
  T get_instance()
  System.Void Awake()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.ShowIfMode
TYPE:  struct
TOKEN: 0x2000022
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  RootMotion.ShowIfMode           Disabled  // 0x0
  public    static  RootMotion.ShowIfMode           Hidden  // 0x0
METHODS:
END_CLASS

CLASS: RootMotion.ShowIfAttribute
TYPE:  class
TOKEN: 0x2000023
EXTENDS: PropertyAttribute
FIELDS:
  private           System.String                   <propName>k__BackingField  // 0x10
  private           System.Object                   <propValue>k__BackingField  // 0x18
  private           System.Object                   <otherPropValue>k__BackingField  // 0x20
  private           System.Boolean                  <indent>k__BackingField  // 0x28
  private           RootMotion.ShowIfMode           <mode>k__BackingField  // 0x2C
METHODS:
  System.String get_propName()
  System.Void set_propName(System.String value)
  System.Object get_propValue()
  System.Void set_propValue(System.Object value)
  System.Object get_otherPropValue()
  System.Void set_otherPropValue(System.Object value)
  System.Boolean get_indent()
  System.Void set_indent(System.Boolean value)
  RootMotion.ShowIfMode get_mode()
  System.Void set_mode(RootMotion.ShowIfMode value)
  System.Void .ctor(System.String propertyName, System.Object propertyValue, System.Object otherPropertyValue, System.Boolean indent, RootMotion.ShowIfMode mode)
END_CLASS

CLASS: RootMotion.ShowRangeIfAttribute
TYPE:  class
TOKEN: 0x2000024
EXTENDS: ShowIfAttribute
FIELDS:
  private           System.Single                   <min>k__BackingField  // 0x30
  private           System.Single                   <max>k__BackingField  // 0x34
METHODS:
  System.Single get_min()
  System.Void set_min(System.Single value)
  System.Single get_max()
  System.Void set_max(System.Single value)
  System.Void .ctor(System.Single min, System.Single max, System.String propertyName, System.Object propertyValue, System.Object otherPropertyValue, System.Boolean indent, RootMotion.ShowIfMode mode)
END_CLASS

CLASS: RootMotion.ShowLargeHeaderIf
TYPE:  class
TOKEN: 0x2000025
EXTENDS: ShowIfAttribute
FIELDS:
  public            System.String                   name  // 0x30
  public            System.String                   color  // 0x38
METHODS:
  System.Void .ctor(System.String name, System.String propertyName, System.Object propertyValue, System.Object otherPropertyValue, System.Boolean indent, RootMotion.ShowIfMode mode)
  System.Void .ctor(System.String name, System.String color, System.String propertyName, System.Object propertyValue, System.Object otherPropertyValue, System.Boolean indent, RootMotion.ShowIfMode mode)
END_CLASS

CLASS: RootMotion.LargeHeader
TYPE:  class
TOKEN: 0x2000026
EXTENDS: PropertyAttribute
FIELDS:
  public            System.String                   name  // 0x10
  public            System.String                   color  // 0x18
METHODS:
  System.Void .ctor(System.String name)
  System.Void .ctor(System.String name, System.String color)
END_CLASS

CLASS: RootMotion.QuaTools
TYPE:  class
TOKEN: 0x2000027
FIELDS:
METHODS:
  System.Single GetYaw(UnityEngine.Quaternion space, UnityEngine.Vector3 forward)
  System.Single GetPitch(UnityEngine.Quaternion space, UnityEngine.Vector3 forward)
  System.Single GetBank(UnityEngine.Quaternion space, UnityEngine.Vector3 forward, UnityEngine.Vector3 up)
  System.Single GetYaw(UnityEngine.Quaternion space, UnityEngine.Quaternion rotation)
  System.Single GetPitch(UnityEngine.Quaternion space, UnityEngine.Quaternion rotation)
  System.Single GetBank(UnityEngine.Quaternion space, UnityEngine.Quaternion rotation)
  UnityEngine.Quaternion Lerp(UnityEngine.Quaternion fromRotation, UnityEngine.Quaternion toRotation, System.Single weight)
  UnityEngine.Quaternion Slerp(UnityEngine.Quaternion fromRotation, UnityEngine.Quaternion toRotation, System.Single weight)
  UnityEngine.Quaternion LinearBlend(UnityEngine.Quaternion q, System.Single weight)
  UnityEngine.Quaternion SphericalBlend(UnityEngine.Quaternion q, System.Single weight)
  UnityEngine.Quaternion FromToAroundAxis(UnityEngine.Vector3 fromDirection, UnityEngine.Vector3 toDirection, UnityEngine.Vector3 axis)
  UnityEngine.Quaternion RotationToLocalSpace(UnityEngine.Quaternion space, UnityEngine.Quaternion rotation)
  UnityEngine.Quaternion FromToRotation(UnityEngine.Quaternion from, UnityEngine.Quaternion to)
  UnityEngine.Vector3 GetAxis(UnityEngine.Vector3 v)
  UnityEngine.Quaternion ClampRotation(UnityEngine.Quaternion rotation, System.Single clampWeight, System.Int32 clampSmoothing)
  System.Single ClampAngle(System.Single angle, System.Single clampWeight, System.Int32 clampSmoothing)
  UnityEngine.Quaternion MatchRotation(UnityEngine.Quaternion targetRotation, UnityEngine.Vector3 targetAxis1, UnityEngine.Vector3 targetAxis2, UnityEngine.Vector3 axis1, UnityEngine.Vector3 axis2)
  UnityEngine.Vector3 ToBiPolar(UnityEngine.Vector3 euler)
  System.Single ToBiPolar(System.Single angle)
  UnityEngine.Quaternion MirrorYZ(UnityEngine.Quaternion r, UnityEngine.Quaternion space)
  UnityEngine.Quaternion MirrorYZ(UnityEngine.Quaternion r)
END_CLASS

CLASS: RootMotion.Singleton`1
TYPE:  class
TOKEN: 0x2000028
EXTENDS: MonoBehaviour
FIELDS:
  private   static  T                               sInstance  // 0x0
METHODS:
  T get_instance()
  System.Void Clear()
  System.Void Awake()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.SolverManager
TYPE:  class
TOKEN: 0x2000029
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Boolean                  fixTransforms  // 0x18
  private           UnityEngine.Animator            animator  // 0x20
  private           UnityEngine.Animation           legacy  // 0x28
  private           System.Boolean                  updateFrame  // 0x30
  private           System.Boolean                  componentInitiated  // 0x31
  private           System.Boolean                  skipSolverUpdate  // 0x32
METHODS:
  System.Void Disable()
  System.Void InitiateSolver()
  System.Void UpdateSolver()
  System.Void FixTransforms()
  System.Void OnDisable()
  System.Void Start()
  System.Boolean get_animatePhysics()
  System.Void Initiate()
  System.Void Update()
  System.Void FindAnimatorRecursive(UnityEngine.Transform t, System.Boolean findInChildren)
  System.Boolean get_isAnimated()
  System.Void FixedUpdate()
  System.Void LateUpdate()
  System.Void UpdateSolverExternal()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.TriggerEventBroadcaster
TYPE:  class
TOKEN: 0x200002A
EXTENDS: MonoBehaviour
FIELDS:
  public            UnityEngine.GameObject          target  // 0x18
METHODS:
  System.Void OnTriggerEnter(UnityEngine.Collider collider)
  System.Void OnTriggerStay(UnityEngine.Collider collider)
  System.Void OnTriggerExit(UnityEngine.Collider collider)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.V2Tools
TYPE:  class
TOKEN: 0x200002B
FIELDS:
METHODS:
  UnityEngine.Vector2 XZ(UnityEngine.Vector3 v)
  System.Single DeltaAngle(UnityEngine.Vector2 dir1, UnityEngine.Vector2 dir2)
  System.Single DeltaAngleXZ(UnityEngine.Vector3 dir1, UnityEngine.Vector3 dir2)
  System.Boolean LineCircleIntersect(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 c, System.Single r)
  System.Boolean RayCircleIntersect(UnityEngine.Vector2 p1, UnityEngine.Vector2 dir, UnityEngine.Vector2 c, System.Single r)
END_CLASS

CLASS: RootMotion.V3Tools
TYPE:  class
TOKEN: 0x200002C
FIELDS:
METHODS:
  System.Single GetYaw(UnityEngine.Vector3 forward)
  System.Single GetPitch(UnityEngine.Vector3 forward)
  System.Single GetBank(UnityEngine.Vector3 forward, UnityEngine.Vector3 up)
  System.Single GetYaw(UnityEngine.Vector3 spaceForward, UnityEngine.Vector3 spaceUp, UnityEngine.Vector3 forward)
  System.Single GetPitch(UnityEngine.Vector3 spaceForward, UnityEngine.Vector3 spaceUp, UnityEngine.Vector3 forward)
  System.Single GetBank(UnityEngine.Vector3 spaceForward, UnityEngine.Vector3 spaceUp, UnityEngine.Vector3 forward, UnityEngine.Vector3 up)
  UnityEngine.Vector3 Lerp(UnityEngine.Vector3 fromVector, UnityEngine.Vector3 toVector, System.Single weight)
  UnityEngine.Vector3 Slerp(UnityEngine.Vector3 fromVector, UnityEngine.Vector3 toVector, System.Single weight)
  UnityEngine.Vector3 ExtractVertical(UnityEngine.Vector3 v, UnityEngine.Vector3 verticalAxis, System.Single weight)
  UnityEngine.Vector3 ExtractHorizontal(UnityEngine.Vector3 v, UnityEngine.Vector3 normal, System.Single weight)
  UnityEngine.Vector3 Flatten(UnityEngine.Vector3 v, UnityEngine.Vector3 normal)
  UnityEngine.Vector3 ClampDirection(UnityEngine.Vector3 direction, UnityEngine.Vector3 normalDirection, System.Single clampWeight, System.Int32 clampSmoothing)
  UnityEngine.Vector3 ClampDirection(UnityEngine.Vector3 direction, UnityEngine.Vector3 normalDirection, System.Single clampWeight, System.Int32 clampSmoothing, System.Boolean& changed)
  UnityEngine.Vector3 ClampDirection(UnityEngine.Vector3 direction, UnityEngine.Vector3 normalDirection, System.Single clampWeight, System.Int32 clampSmoothing, System.Single& clampValue)
  UnityEngine.Vector3 LineToPlane(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.Vector3 planeNormal, UnityEngine.Vector3 planePoint)
  UnityEngine.Vector3 PointToPlane(UnityEngine.Vector3 point, UnityEngine.Vector3 planePosition, UnityEngine.Vector3 planeNormal)
  UnityEngine.Vector3 TransformPointUnscaled(UnityEngine.Transform t, UnityEngine.Vector3 point)
  UnityEngine.Vector3 InverseTransformPointUnscaled(UnityEngine.Transform t, UnityEngine.Vector3 point)
  UnityEngine.Vector3 InverseTransformPoint(UnityEngine.Vector3 tPos, UnityEngine.Quaternion tRot, UnityEngine.Vector3 tScale, UnityEngine.Vector3 point)
  UnityEngine.Vector3 TransformPoint(UnityEngine.Vector3 tPos, UnityEngine.Quaternion tRot, UnityEngine.Vector3 tScale, UnityEngine.Vector3 point)
  UnityEngine.Vector3 Div(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2)
END_CLASS

CLASS: RootMotion.Warning
TYPE:  class
TOKEN: 0x200002D
FIELDS:
  public    static  System.Boolean                  logged  // 0x0
METHODS:
  System.Void Log(System.String message, RootMotion.Warning.Logger logger, System.Boolean logInEditMode)
  System.Void Log(System.String message, UnityEngine.Transform context, System.Boolean logInEditMode)
END_CLASS

CLASS: RootMotion.Demos.Navigator
TYPE:  class
TOKEN: 0x200002F
FIELDS:
  public            System.Boolean                  activeTargetSeeking  // 0x10
  public            System.Single                   cornerRadius  // 0x14
  public            System.Single                   recalculateOnPathDistance  // 0x18
  public            System.Single                   maxSampleDistance  // 0x1C
  public            System.Single                   nextPathInterval  // 0x20
  private           UnityEngine.Vector3             <normalizedDeltaPosition>k__BackingField  // 0x24
  private           RootMotion.Demos.Navigator.State<state>k__BackingField  // 0x30
  private           UnityEngine.Transform           transform  // 0x38
  private           System.Int32                    cornerIndex  // 0x40
  private           UnityEngine.Vector3[]           corners  // 0x48
  private           UnityEngine.AI.NavMeshPath      path  // 0x50
  private           UnityEngine.Vector3             lastTargetPosition  // 0x58
  private           System.Boolean                  initiated  // 0x64
  private           System.Single                   nextPathTime  // 0x68
METHODS:
  UnityEngine.Vector3 get_normalizedDeltaPosition()
  System.Void set_normalizedDeltaPosition(UnityEngine.Vector3 value)
  RootMotion.Demos.Navigator.State get_state()
  System.Void set_state(RootMotion.Demos.Navigator.State value)
  System.Void Initiate(UnityEngine.Transform transform)
  System.Void Update(UnityEngine.Vector3 targetPosition)
  System.Void CalculatePath(UnityEngine.Vector3 targetPosition)
  System.Boolean Find(UnityEngine.Vector3 targetPosition)
  System.Void Stop()
  System.Single HorDistance(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2)
  System.Void Visualize()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.BipedIK
TYPE:  class
TOKEN: 0x2000031
EXTENDS: SolverManager
FIELDS:
  public            RootMotion.BipedReferences      references  // 0x38
  public            RootMotion.FinalIK.BipedIKSolverssolvers  // 0x40
METHODS:
  System.Void OpenUserManual()
  System.Void OpenScriptReference()
  System.Void SupportGroup()
  System.Void ASThread()
  System.Single GetIKPositionWeight(UnityEngine.AvatarIKGoal goal)
  System.Single GetIKRotationWeight(UnityEngine.AvatarIKGoal goal)
  System.Void SetIKPositionWeight(UnityEngine.AvatarIKGoal goal, System.Single weight)
  System.Void SetIKRotationWeight(UnityEngine.AvatarIKGoal goal, System.Single weight)
  System.Void SetIKPosition(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3 IKPosition)
  System.Void SetIKRotation(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion IKRotation)
  UnityEngine.Vector3 GetIKPosition(UnityEngine.AvatarIKGoal goal)
  UnityEngine.Quaternion GetIKRotation(UnityEngine.AvatarIKGoal goal)
  System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight, System.Single clampWeight, System.Single clampWeightHead, System.Single clampWeightEyes)
  System.Void SetLookAtPosition(UnityEngine.Vector3 lookAtPosition)
  System.Void SetSpinePosition(UnityEngine.Vector3 spinePosition)
  System.Void SetSpineWeight(System.Single weight)
  RootMotion.FinalIK.IKSolverLimb GetGoalIK(UnityEngine.AvatarIKGoal goal)
  System.Void InitiateBipedIK()
  System.Void UpdateBipedIK()
  System.Void SetToDefaults()
  System.Void FixTransforms()
  System.Void InitiateSolver()
  System.Void UpdateSolver()
  System.Void LogWarning(System.String message)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.BipedIKSolvers
TYPE:  class
TOKEN: 0x2000032
FIELDS:
  public            RootMotion.FinalIK.IKSolverLimb leftFoot  // 0x10
  public            RootMotion.FinalIK.IKSolverLimb rightFoot  // 0x18
  public            RootMotion.FinalIK.IKSolverLimb leftHand  // 0x20
  public            RootMotion.FinalIK.IKSolverLimb rightHand  // 0x28
  public            RootMotion.FinalIK.IKSolverFABRIKspine  // 0x30
  public            RootMotion.FinalIK.IKSolverLookAtlookAt  // 0x38
  public            RootMotion.FinalIK.IKSolverAim  aim  // 0x40
  public            RootMotion.FinalIK.Constraints  pelvis  // 0x48
  private           RootMotion.FinalIK.IKSolverLimb[]_limbs  // 0x50
  private           RootMotion.FinalIK.IKSolver[]   _ikSolvers  // 0x58
METHODS:
  RootMotion.FinalIK.IKSolverLimb[] get_limbs()
  RootMotion.FinalIK.IKSolver[] get_ikSolvers()
  System.Void AssignReferences(RootMotion.BipedReferences references)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.Constraint
TYPE:  class
TOKEN: 0x2000033
FIELDS:
  public            UnityEngine.Transform           transform  // 0x10
  public            System.Single                   weight  // 0x18
METHODS:
  System.Boolean get_isValid()
  System.Void UpdateConstraint()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.ConstraintPosition
TYPE:  class
TOKEN: 0x2000034
EXTENDS: Constraint
FIELDS:
  public            UnityEngine.Vector3             position  // 0x20
METHODS:
  System.Void UpdateConstraint()
  System.Void .ctor()
  System.Void .ctor(UnityEngine.Transform transform)
END_CLASS

CLASS: RootMotion.FinalIK.ConstraintPositionOffset
TYPE:  class
TOKEN: 0x2000035
EXTENDS: Constraint
FIELDS:
  public            UnityEngine.Vector3             offset  // 0x20
  private           UnityEngine.Vector3             defaultLocalPosition  // 0x2C
  private           UnityEngine.Vector3             lastLocalPosition  // 0x38
  private           System.Boolean                  initiated  // 0x44
METHODS:
  System.Void UpdateConstraint()
  System.Void .ctor()
  System.Void .ctor(UnityEngine.Transform transform)
  System.Boolean get_positionChanged()
END_CLASS

CLASS: RootMotion.FinalIK.ConstraintRotation
TYPE:  class
TOKEN: 0x2000036
EXTENDS: Constraint
FIELDS:
  public            UnityEngine.Quaternion          rotation  // 0x20
METHODS:
  System.Void UpdateConstraint()
  System.Void .ctor()
  System.Void .ctor(UnityEngine.Transform transform)
END_CLASS

CLASS: RootMotion.FinalIK.ConstraintRotationOffset
TYPE:  class
TOKEN: 0x2000037
EXTENDS: Constraint
FIELDS:
  public            UnityEngine.Quaternion          offset  // 0x20
  private           UnityEngine.Quaternion          defaultRotation  // 0x30
  private           UnityEngine.Quaternion          defaultLocalRotation  // 0x40
  private           UnityEngine.Quaternion          lastLocalRotation  // 0x50
  private           UnityEngine.Quaternion          defaultTargetLocalRotation  // 0x60
  private           System.Boolean                  initiated  // 0x70
METHODS:
  System.Void UpdateConstraint()
  System.Void .ctor()
  System.Void .ctor(UnityEngine.Transform transform)
  System.Boolean get_rotationChanged()
END_CLASS

CLASS: RootMotion.FinalIK.Constraints
TYPE:  class
TOKEN: 0x2000038
FIELDS:
  public            UnityEngine.Transform           transform  // 0x10
  public            UnityEngine.Transform           target  // 0x18
  public            UnityEngine.Vector3             positionOffset  // 0x20
  public            UnityEngine.Vector3             position  // 0x2C
  public            System.Single                   positionWeight  // 0x38
  public            UnityEngine.Vector3             rotationOffset  // 0x3C
  public            UnityEngine.Vector3             rotation  // 0x48
  public            System.Single                   rotationWeight  // 0x54
METHODS:
  System.Boolean IsValid()
  System.Void Initiate(UnityEngine.Transform transform)
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.Finger
TYPE:  class
TOKEN: 0x2000039
FIELDS:
  public            System.Single                   weight  // 0x10
  public            System.Single                   rotationWeight  // 0x14
  public            RootMotion.FinalIK.Finger.DOF   rotationDOF  // 0x18
  public            System.Boolean                  fixBone1Twist  // 0x1C
  public            UnityEngine.Transform           bone1  // 0x20
  public            UnityEngine.Transform           bone2  // 0x28
  public            UnityEngine.Transform           bone3  // 0x30
  public            UnityEngine.Transform           tip  // 0x38
  public            UnityEngine.Transform           target  // 0x40
  private           System.Boolean                  <initiated>k__BackingField  // 0x48
  private           RootMotion.FinalIK.IKSolverLimb solver  // 0x50
  private           UnityEngine.Quaternion          bone3RelativeToTarget  // 0x58
  private           UnityEngine.Vector3             bone3DefaultLocalPosition  // 0x68
  private           UnityEngine.Quaternion          bone3DefaultLocalRotation  // 0x74
  private           UnityEngine.Vector3             bone1Axis  // 0x84
  private           UnityEngine.Vector3             tipAxis  // 0x90
  private           UnityEngine.Vector3             bone1TwistAxis  // 0x9C
  private           UnityEngine.Vector3             defaultBendNormal  // 0xA8
METHODS:
  System.Boolean get_initiated()
  System.Void set_initiated(System.Boolean value)
  UnityEngine.Vector3 get_IKPosition()
  System.Void set_IKPosition(UnityEngine.Vector3 value)
  UnityEngine.Quaternion get_IKRotation()
  System.Void set_IKRotation(UnityEngine.Quaternion value)
  System.Boolean IsValid(System.String& errorMessage)
  System.Void Initiate(UnityEngine.Transform hand, System.Int32 index)
  System.Void FixTransforms()
  System.Void StoreDefaultLocalState()
  System.Void Update(System.Single masterWeight)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.FingerRig
TYPE:  class
TOKEN: 0x200003B
EXTENDS: SolverManager
FIELDS:
  public            System.Single                   weight  // 0x38
  public            RootMotion.FinalIK.Finger[]     fingers  // 0x40
  private           System.Boolean                  <initiated>k__BackingField  // 0x48
METHODS:
  System.Boolean get_initiated()
  System.Void set_initiated(System.Boolean value)
  System.Boolean IsValid(System.String& errorMessage)
  System.Void AutoDetect()
  System.Void AddFinger(UnityEngine.Transform bone1, UnityEngine.Transform bone2, UnityEngine.Transform bone3, UnityEngine.Transform tip, UnityEngine.Transform target)
  System.Void RemoveFinger(System.Int32 index)
  System.Void AddChildrenRecursive(UnityEngine.Transform parent, UnityEngine.Transform[]& array)
  System.Void InitiateSolver()
  System.Void UpdateFingerSolvers()
  System.Void FixFingerTransforms()
  System.Void StoreDefaultLocalState()
  System.Void UpdateSolver()
  System.Void FixTransforms()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.Grounder
TYPE:  class
TOKEN: 0x200003C
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Single                   weight  // 0x18
  public            System.Single                   maintianPelvisFootWeight  // 0x1C
  public            System.Single                   footAdsorbWeight  // 0x20
  public            RootMotion.FinalIK.Grounding    solver  // 0x28
  public            RootMotion.FinalIK.Grounder.GrounderDelegateOnPreGrounder  // 0x30
  public            RootMotion.FinalIK.Grounder.GrounderDelegateOnPostGrounder  // 0x38
  public            RootMotion.FinalIK.Grounder.GrounderDelegateOnPostIK  // 0x40
  private           System.Boolean                  <initiated>k__BackingField  // 0x48
METHODS:
  System.Void ResetPosition()
  System.Boolean get_initiated()
  System.Void set_initiated(System.Boolean value)
  UnityEngine.Vector3 GetSpineOffsetTarget()
  System.Void LogWarning(System.String message)
  UnityEngine.Vector3 GetLegSpineBendVector(RootMotion.FinalIK.Grounding.Leg leg)
  UnityEngine.Vector3 GetLegSpineTangent(RootMotion.FinalIK.Grounding.Leg leg)
  System.Void OpenUserManual()
  System.Void OpenScriptReference()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.GrounderBipedIK
TYPE:  class
TOKEN: 0x200003E
EXTENDS: Grounder
FIELDS:
  public            RootMotion.FinalIK.BipedIK      ik  // 0x50
  public            System.Single                   spineBend  // 0x58
  public            System.Single                   spineSpeed  // 0x5C
  private           UnityEngine.Transform[]         feet  // 0x60
  private           UnityEngine.Quaternion[]        footRotations  // 0x68
  private           UnityEngine.Vector3             animatedPelvisLocalPosition  // 0x70
  private           UnityEngine.Vector3             solvedPelvisLocalPosition  // 0x7C
  private           UnityEngine.Vector3             spineOffset  // 0x88
  private           System.Single                   lastWeight  // 0x94
  private           System.Single                   lastAdsorbWeight  // 0x98
  private           System.Single                   rightFootOffsetY  // 0x9C
  private           System.Single                   leftFootOffsetY  // 0xA0
  private           System.Single                   rightFootOri  // 0xA4
  private           System.Single                   leftFootOri  // 0xA8
  public            UnityEngine.Transform           ikOriReferenceBone  // 0xB0
METHODS:
  System.Void OpenUserManual()
  System.Void OpenScriptReference()
  System.Void ResetPosition()
  System.Single get_RightFootOffsetY()
  System.Single get_LeftFootOffsetY()
  System.Single get_RightFootOri()
  System.Single get_LeftFootOri()
  System.Boolean IsReadyToInitiate()
  System.Void Update()
  System.Void Initiate()
  System.Void OnDisable()
  System.Void OnSolverUpdate()
  System.Void SetLegIK(RootMotion.FinalIK.IKSolverLimb limb, System.Int32 index)
  System.Void OnPostSolverUpdate()
  System.Void OnDestroy()
  UnityEngine.Quaternion ClampPitchAndRollAroundForward(UnityEngine.Quaternion Q, UnityEngine.Quaternion calfQ, System.Single minPitch, System.Single maxPitch, System.Single minRoll, System.Single maxRoll)
  System.Single NormalizeAngle(System.Single angle)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.GrounderFBBIK
TYPE:  class
TOKEN: 0x200003F
EXTENDS: Grounder
FIELDS:
  public            RootMotion.FinalIK.FullBodyBipedIKik  // 0x50
  public            System.Single                   spineBend  // 0x58
  public            System.Single                   spineSpeed  // 0x5C
  public            RootMotion.FinalIK.GrounderFBBIK.SpineEffector[]spine  // 0x60
  private           UnityEngine.Transform[]         feet  // 0x68
  private           UnityEngine.Vector3             spineOffset  // 0x70
  private           System.Boolean                  firstSolve  // 0x7C
METHODS:
  System.Void OpenTutorial()
  System.Void OpenUserManual()
  System.Void OpenScriptReference()
  System.Void ResetPosition()
  System.Boolean IsReadyToInitiate()
  System.Void Update()
  System.Void FixedUpdate()
  System.Void LateUpdate()
  System.Void Initiate()
  System.Void OnSolverUpdate()
  System.Void SetLegIK(RootMotion.FinalIK.IKEffector effector, RootMotion.FinalIK.Grounding.Leg leg)
  System.Void OnDrawGizmosSelected()
  System.Void OnPostSolverUpdate()
  System.Void OnDestroy()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.GrounderIK
TYPE:  class
TOKEN: 0x2000041
EXTENDS: Grounder
FIELDS:
  public            RootMotion.FinalIK.IK[]         legs  // 0x50
  public            UnityEngine.Transform           pelvis  // 0x58
  public            UnityEngine.Transform           characterRoot  // 0x60
  public            System.Single                   rootRotationWeight  // 0x68
  public            System.Single                   rootRotationSpeed  // 0x6C
  public            System.Single                   maxRootRotationAngle  // 0x70
  private           UnityEngine.Transform[]         feet  // 0x78
  private           UnityEngine.Quaternion[]        footRotations  // 0x80
  private           UnityEngine.Vector3             animatedPelvisLocalPosition  // 0x88
  private           UnityEngine.Vector3             solvedPelvisLocalPosition  // 0x94
  private           System.Int32                    solvedFeet  // 0xA0
  private           System.Boolean                  solved  // 0xA4
  private           System.Single                   lastWeight  // 0xA8
  private           UnityEngine.Rigidbody           characterRootRigidbody  // 0xB0
METHODS:
  System.Void OpenUserManual()
  System.Void OpenScriptReference()
  System.Void ResetPosition()
  System.Boolean IsReadyToInitiate()
  System.Void OnDisable()
  System.Void Update()
  System.Void Initiate()
  System.Void OnSolverUpdate()
  System.Void SetLegIK(System.Int32 index)
  System.Void OnPostSolverUpdate()
  System.Void OnDestroy()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.GrounderQuadruped
TYPE:  class
TOKEN: 0x2000042
EXTENDS: Grounder
FIELDS:
  public            RootMotion.FinalIK.Grounding    forelegSolver  // 0x50
  public            System.Single                   rootRotationWeight  // 0x58
  public            System.Single                   minRootRotation  // 0x5C
  public            System.Single                   maxRootRotation  // 0x60
  public            System.Single                   rootRotationSpeed  // 0x64
  public            System.Single                   maxLegOffset  // 0x68
  public            System.Single                   maxForeLegOffset  // 0x6C
  public            System.Single                   maintainHeadRotationWeight  // 0x70
  public            UnityEngine.Transform           characterRoot  // 0x78
  public            UnityEngine.Transform           pelvis  // 0x80
  public            UnityEngine.Transform           lastSpineBone  // 0x88
  public            UnityEngine.Transform           head  // 0x90
  public            RootMotion.FinalIK.IK[]         legs  // 0x98
  public            RootMotion.FinalIK.IK[]         forelegs  // 0xA0
  public            UnityEngine.Vector3             gravity  // 0xA8
  private           RootMotion.FinalIK.GrounderQuadruped.Foot[]feet  // 0xB8
  private           UnityEngine.Vector3             animatedPelvisLocalPosition  // 0xC0
  private           UnityEngine.Quaternion          animatedPelvisLocalRotation  // 0xCC
  private           UnityEngine.Quaternion          animatedHeadLocalRotation  // 0xDC
  private           UnityEngine.Vector3             solvedPelvisLocalPosition  // 0xEC
  private           UnityEngine.Quaternion          solvedPelvisLocalRotation  // 0xF8
  private           UnityEngine.Quaternion          solvedHeadLocalRotation  // 0x108
  private           System.Int32                    solvedFeet  // 0x118
  private           System.Boolean                  solved  // 0x11C
  private           System.Single                   angle  // 0x120
  private           UnityEngine.Transform           forefeetRoot  // 0x128
  private           UnityEngine.Quaternion          headRotation  // 0x130
  private           System.Single                   lastWeight  // 0x140
  private           UnityEngine.Rigidbody           characterRootRigidbody  // 0x148
METHODS:
  System.Void OpenUserManual()
  System.Void OpenScriptReference()
  System.Void ResetPosition()
  System.Boolean IsReadyToInitiate()
  System.Boolean IsReadyToInitiateLegs(RootMotion.FinalIK.IK[] ikComponents)
  System.Void OnDisable()
  System.Void Update()
  System.Void Initiate()
  UnityEngine.Transform[] InitiateFeet(RootMotion.FinalIK.IK[] ikComponents, RootMotion.FinalIK.GrounderQuadruped.Foot[]& f, System.Int32 indexOffset)
  System.Void LateUpdate()
  System.Void RootRotation()
  System.Void OnSolverUpdate()
  System.Void UpdateForefeetRoot()
  System.Void SetFootIK(RootMotion.FinalIK.GrounderQuadruped.Foot foot, System.Single maxOffset)
  System.Void OnPostSolverUpdate()
  System.Void OnDestroy()
  System.Void DestroyLegs(RootMotion.FinalIK.IK[] ikComponents)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.Grounding
TYPE:  class
TOKEN: 0x2000044
FIELDS:
  public            UnityEngine.Transform           IKFootBoneL  // 0x10
  public            UnityEngine.Transform           IKFootBoneR  // 0x18
  public            System.Single                   floorLogicTheta  // 0x20
  public            System.Single                   floorAnimTheta  // 0x24
  public            System.Single                   floorPredictTheta  // 0x28
  public            System.Single                   floorFeetThetaByFoot  // 0x2C
  public            System.Single                   floorFeetThetaByRoot  // 0x30
  public            System.Single                   floorFeetThetaByLogic  // 0x34
  public            System.Single                   betweenFeetDistance  // 0x38
  public            System.Boolean                  isMoving  // 0x3C
  public            System.Boolean                  isAccelerating  // 0x3D
  public            System.Boolean                  isPlayingMontage  // 0x3E
  public            System.Single                   SG_timeRef  // 0x40
  public            System.Single                   gait  // 0x44
  public            System.Single                   startAnimWeight  // 0x48
  public            UnityEngine.Vector3             playerSpeed  // 0x4C
  private           System.Boolean                  m_isAcceleratingLastFrame  // 0x58
  public            System.Boolean                  isLastFrameInvalid  // 0x59
  public            System.Single                   maxLegLength  // 0x5C
  public            System.Single                   maxFeetOffset  // 0x60
  public            System.Single                   minPelvisHeight  // 0x64
  public            UnityEngine.LayerMask           layers  // 0x68
  public            System.Single                   maxStep  // 0x6C
  public            System.Single                   heightOffset  // 0x70
  public            System.Single                   footSpeed  // 0x74
  public            System.Single                   footRadius  // 0x78
  public            System.Single                   footCenterOffset  // 0x7C
  public            System.Single                   prediction  // 0x80
  public            System.Single                   footRotationWeight  // 0x84
  public            System.Single                   footRotationSpeed  // 0x88
  public            System.Single                   maxFootRotationAngleFore  // 0x8C
  public            System.Single                   maxFootRotationAngleBack  // 0x90
  public            System.Single                   maxFootRotationAngleIn  // 0x94
  public            System.Single                   maxFootRotationAngleOut  // 0x98
  public            System.Boolean                  rotateSolver  // 0x9C
  public            System.Single                   pelvisSpeed  // 0xA0
  public            System.Single                   pelvisSpeedXZ  // 0xA4
  public            System.Single                   pelvisDamper  // 0xA8
  public            System.Single                   lowerPelvisWeight  // 0xAC
  public            System.Single                   liftPelvisWeight  // 0xB0
  public            System.Single                   rootSphereCastRadius  // 0xB4
  public            System.Boolean                  overstepFallsDown  // 0xB8
  public            RootMotion.FinalIK.Grounding.Qualityquality  // 0xBC
  private           RootMotion.BipedReferences      <references>k__BackingField  // 0xC0
  private           RootMotion.FinalIK.Grounding.Leg[]<legs>k__BackingField  // 0xC8
  private           RootMotion.FinalIK.Grounding.Pelvis<pelvis>k__BackingField  // 0xD0
  private           System.Boolean                  <isGrounded>k__BackingField  // 0xD8
  private           UnityEngine.Transform           <root>k__BackingField  // 0xE0
  private           UnityEngine.RaycastHit          <rootHit>k__BackingField  // 0xE8
  public            RootMotion.FinalIK.Grounding.OnRaycastDelegateRaycast  // 0x128
  public            RootMotion.FinalIK.Grounding.OnCapsuleCastDelegateCapsuleCast  // 0x130
  public            RootMotion.FinalIK.Grounding.OnSphereCastDelegateSphereCast  // 0x138
  private           UnityEngine.Transform           <entityTransform>k__BackingField  // 0x140
  private           System.Boolean                  <entityIsOnMovableBase>k__BackingField  // 0x148
  private           UnityEngine.Vector3             <entityRelativePosition>k__BackingField  // 0x14C
  private           UnityEngine.Quaternion          <entityRelativeRotation>k__BackingField  // 0x158
  private           System.Boolean                  lastIsDependingLeftLeg  // 0x168
  private           System.Boolean                  isSameLegWithLastFrame  // 0x169
  private           System.Single                   rootDeltaAngle  // 0x16C
  private           System.Single                   pelvisForwardOffset  // 0x170
  private           UnityEngine.Vector3             m_lastFrameForwardVec  // 0x174
  private           System.Boolean                  lastIsUsingLoswest  // 0x180
  private           System.Single                   m_actualMaxFootOffset  // 0x184
  public            System.Single                   forwardFeetOffset  // 0x188
  public            System.Boolean                  isUsingLoswest  // 0x18C
  public            System.Boolean                  isDependingLeftLeg  // 0x18D
  private           System.Boolean                  initiated  // 0x18E
METHODS:
  System.Void _UpdateFloorPredictTheta()
  System.Void _UpdateFloorFeetThetaByFoot()
  System.Void _UpdateFloorFeetThetaByRoot()
  RootMotion.BipedReferences get_references()
  System.Void set_references(RootMotion.BipedReferences value)
  RootMotion.FinalIK.Grounding.Leg[] get_legs()
  System.Void set_legs(RootMotion.FinalIK.Grounding.Leg[] value)
  RootMotion.FinalIK.Grounding.Pelvis get_pelvis()
  System.Void set_pelvis(RootMotion.FinalIK.Grounding.Pelvis value)
  System.Boolean get_isGrounded()
  System.Void set_isGrounded(System.Boolean value)
  UnityEngine.Transform get_root()
  System.Void set_root(UnityEngine.Transform value)
  UnityEngine.RaycastHit get_rootHit()
  System.Void set_rootHit(UnityEngine.RaycastHit value)
  System.Boolean get_rootGrounded()
  UnityEngine.Transform get_entityTransform()
  System.Void set_entityTransform(UnityEngine.Transform value)
  System.Boolean get_entityIsOnMovableBase()
  System.Void set_entityIsOnMovableBase(System.Boolean value)
  UnityEngine.Vector3 get_entityRelativePosition()
  System.Void set_entityRelativePosition(UnityEngine.Vector3 value)
  UnityEngine.Quaternion get_entityRelativeRotation()
  System.Void set_entityRelativeRotation(UnityEngine.Quaternion value)
  UnityEngine.RaycastHit GetRootHit(System.Single maxDistanceMlp)
  System.Boolean IsValid(System.String& errorMessage)
  System.Void Initiate(UnityEngine.Transform root, UnityEngine.Transform[] feet, RootMotion.BipedReferences references)
  System.Void Update()
  UnityEngine.Vector3 GetLegsPlaneNormal()
  System.Void Reset()
  System.Void LogWarning(System.String message)
  UnityEngine.Vector3 get_up()
  UnityEngine.Vector3 get_forward()
  System.Single GetVerticalOffset(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2)
  UnityEngine.Vector3 Flatten(UnityEngine.Vector3 v)
  System.Boolean get_useRootRotation()
  UnityEngine.Vector3 GetFootCenterOffset()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.AimIK
TYPE:  class
TOKEN: 0x200004B
EXTENDS: IK
FIELDS:
  public            RootMotion.FinalIK.IKSolverAim  solver  // 0x38
METHODS:
  System.Void OpenUserManual()
  System.Void OpenScriptReference()
  System.Void OpenSetupTutorial()
  System.Void SupportGroup()
  System.Void ASThread()
  RootMotion.FinalIK.IKSolver GetIKSolver()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.ArmIK
TYPE:  class
TOKEN: 0x200004C
EXTENDS: IK
FIELDS:
  public            RootMotion.FinalIK.IKSolverArm  solver  // 0x38
METHODS:
  System.Void OpenUserManual()
  System.Void OpenScriptReference()
  System.Void SupportGroup()
  System.Void ASThread()
  RootMotion.FinalIK.IKSolver GetIKSolver()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.CCDIK
TYPE:  class
TOKEN: 0x200004D
EXTENDS: IK
FIELDS:
  public            RootMotion.FinalIK.IKSolverCCD  solver  // 0x38
METHODS:
  System.Void OpenUserManual()
  System.Void OpenScriptReference()
  System.Void SupportGroup()
  System.Void ASThread()
  RootMotion.FinalIK.IKSolver GetIKSolver()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.FABRIK
TYPE:  class
TOKEN: 0x200004E
EXTENDS: IK
FIELDS:
  public            RootMotion.FinalIK.IKSolverFABRIKsolver  // 0x38
METHODS:
  System.Void OpenUserManual()
  System.Void OpenScriptReference()
  System.Void SupportGroup()
  System.Void ASThread()
  RootMotion.FinalIK.IKSolver GetIKSolver()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.FABRIKRoot
TYPE:  class
TOKEN: 0x200004F
EXTENDS: IK
FIELDS:
  public            RootMotion.FinalIK.IKSolverFABRIKRootsolver  // 0x38
METHODS:
  System.Void OpenUserManual()
  System.Void OpenScriptReference()
  System.Void SupportGroup()
  System.Void ASThread()
  RootMotion.FinalIK.IKSolver GetIKSolver()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.FullBodyBipedIK
TYPE:  class
TOKEN: 0x2000050
EXTENDS: IK
FIELDS:
  public            RootMotion.BipedReferences      references  // 0x38
  public            RootMotion.FinalIK.IKSolverFullBodyBipedsolver  // 0x40
METHODS:
  System.Void OpenUserManual()
  System.Void OpenScriptReference()
  System.Void OpenSetupTutorial()
  System.Void OpenInspectorTutorial()
  System.Void SupportGroup()
  System.Void ASThread()
  System.Void SetReferences(RootMotion.BipedReferences references, UnityEngine.Transform rootNode)
  RootMotion.FinalIK.IKSolver GetIKSolver()
  System.Boolean ReferencesError(System.String& errorMessage)
  System.Boolean ReferencesWarning(System.String& warningMessage)
  System.Void Reinitiate()
  System.Void AutoDetectReferences()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.IK
TYPE:  class
TOKEN: 0x2000051
EXTENDS: SolverManager
FIELDS:
METHODS:
  RootMotion.FinalIK.IKSolver GetIKSolver()
  System.Void UpdateSolver()
  System.Void InitiateSolver()
  System.Void FixTransforms()
  System.Void OpenUserManual()
  System.Void OpenScriptReference()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.IKExecutionOrder
TYPE:  class
TOKEN: 0x2000052
EXTENDS: MonoBehaviour
FIELDS:
  public            RootMotion.FinalIK.IK[]         IKComponents  // 0x18
  public            UnityEngine.Animator            animator  // 0x20
  private           System.Boolean                  fixedFrame  // 0x28
METHODS:
  System.Boolean get_animatePhysics()
  System.Void Start()
  System.Void Update()
  System.Void FixedUpdate()
  System.Void LateUpdate()
  System.Void FixTransforms()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.LegIK
TYPE:  class
TOKEN: 0x2000053
EXTENDS: IK
FIELDS:
  public            RootMotion.FinalIK.IKSolverLeg  solver  // 0x38
METHODS:
  System.Void OpenUserManual()
  System.Void OpenScriptReference()
  System.Void SupportGroup()
  System.Void ASThread()
  RootMotion.FinalIK.IKSolver GetIKSolver()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.LimbIK
TYPE:  class
TOKEN: 0x2000054
EXTENDS: IK
FIELDS:
  public            RootMotion.FinalIK.IKSolverLimb solver  // 0x38
METHODS:
  System.Void OpenUserManual()
  System.Void OpenScriptReference()
  System.Void SupportGroup()
  System.Void ASThread()
  RootMotion.FinalIK.IKSolver GetIKSolver()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.LookAtIK
TYPE:  class
TOKEN: 0x2000055
EXTENDS: IK
FIELDS:
  public            RootMotion.FinalIK.IKSolverLookAtsolver  // 0x38
METHODS:
  System.Void OpenUserManual()
  System.Void OpenScriptReference()
  System.Void SupportGroup()
  System.Void ASThread()
  RootMotion.FinalIK.IKSolver GetIKSolver()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.TrigonometricIK
TYPE:  class
TOKEN: 0x2000056
EXTENDS: IK
FIELDS:
  public            RootMotion.FinalIK.IKSolverTrigonometricsolver  // 0x38
METHODS:
  System.Void OpenUserManual()
  System.Void OpenScriptReference()
  System.Void SupportGroup()
  System.Void ASThread()
  RootMotion.FinalIK.IKSolver GetIKSolver()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.VRIK
TYPE:  class
TOKEN: 0x2000057
EXTENDS: IK
FIELDS:
  public            RootMotion.FinalIK.VRIK.Referencesreferences  // 0x38
  public            RootMotion.FinalIK.IKSolverVR   solver  // 0x40
METHODS:
  System.Void OpenUserManual()
  System.Void OpenScriptReference()
  System.Void OpenSetupTutorial()
  System.Void AutoDetectReferences()
  System.Void GuessHandOrientations()
  RootMotion.FinalIK.IKSolver GetIKSolver()
  System.Void InitiateSolver()
  System.Void UpdateSolver()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.FABRIKChain
TYPE:  class
TOKEN: 0x2000059
FIELDS:
  public            RootMotion.FinalIK.FABRIK       ik  // 0x10
  public            System.Single                   pull  // 0x18
  public            System.Single                   pin  // 0x1C
  public            System.Int32[]                  children  // 0x20
METHODS:
  System.Boolean IsValid(System.String& message)
  System.Void Initiate()
  System.Void Stage1(RootMotion.FinalIK.FABRIKChain[] chain)
  System.Void Stage2(UnityEngine.Vector3 rootPosition, RootMotion.FinalIK.FABRIKChain[] chain)
  UnityEngine.Vector3 GetCentroid(RootMotion.FinalIK.FABRIKChain[] chain)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.FBBIKArmBending
TYPE:  class
TOKEN: 0x200005A
EXTENDS: MonoBehaviour
FIELDS:
  public            RootMotion.FinalIK.FullBodyBipedIKik  // 0x18
  public            UnityEngine.Vector3             bendDirectionOffsetLeft  // 0x20
  public            UnityEngine.Vector3             bendDirectionOffsetRight  // 0x2C
  public            UnityEngine.Vector3             characterSpaceBendOffsetLeft  // 0x38
  public            UnityEngine.Vector3             characterSpaceBendOffsetRight  // 0x44
  private           UnityEngine.Quaternion          leftHandTargetRotation  // 0x50
  private           UnityEngine.Quaternion          rightHandTargetRotation  // 0x60
  private           System.Boolean                  initiated  // 0x70
METHODS:
  System.Void LateUpdate()
  System.Void OnPostFBBIK()
  System.Void OnDestroy()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.FBBIKHeadEffector
TYPE:  class
TOKEN: 0x200005B
EXTENDS: MonoBehaviour
FIELDS:
  public            RootMotion.FinalIK.FullBodyBipedIKik  // 0x18
  public            System.Single                   positionWeight  // 0x20
  public            System.Single                   bodyWeight  // 0x24
  public            System.Single                   thighWeight  // 0x28
  public            System.Boolean                  handsPullBody  // 0x2C
  public            System.Single                   rotationWeight  // 0x30
  public            System.Single                   bodyClampWeight  // 0x34
  public            System.Single                   headClampWeight  // 0x38
  public            System.Single                   bendWeight  // 0x3C
  public            RootMotion.FinalIK.FBBIKHeadEffector.BendBone[]bendBones  // 0x40
  public            System.Single                   CCDWeight  // 0x48
  public            System.Single                   roll  // 0x4C
  public            System.Single                   damper  // 0x50
  public            UnityEngine.Transform[]         CCDBones  // 0x58
  public            System.Single                   postStretchWeight  // 0x60
  public            System.Single                   maxStretch  // 0x64
  public            System.Single                   stretchDamper  // 0x68
  public            System.Boolean                  fixHead  // 0x6C
  public            UnityEngine.Transform[]         stretchBones  // 0x70
  public            UnityEngine.Vector3             chestDirection  // 0x78
  public            System.Single                   chestDirectionWeight  // 0x84
  public            UnityEngine.Transform[]         chestBones  // 0x88
  public            RootMotion.FinalIK.IKSolver.UpdateDelegateOnPostHeadEffectorFK  // 0x90
  private           UnityEngine.Vector3             offset  // 0x98
  private           UnityEngine.Vector3             headToBody  // 0xA4
  private           UnityEngine.Vector3             shoulderCenterToHead  // 0xB0
  private           UnityEngine.Vector3             headToLeftThigh  // 0xBC
  private           UnityEngine.Vector3             headToRightThigh  // 0xC8
  private           UnityEngine.Vector3             leftShoulderPos  // 0xD4
  private           UnityEngine.Vector3             rightShoulderPos  // 0xE0
  private           System.Single                   shoulderDist  // 0xEC
  private           System.Single                   leftShoulderDist  // 0xF0
  private           System.Single                   rightShoulderDist  // 0xF4
  private           UnityEngine.Quaternion          chestRotation  // 0xF8
  private           UnityEngine.Quaternion          headRotationRelativeToRoot  // 0x108
  private           UnityEngine.Quaternion[]        ccdDefaultLocalRotations  // 0x118
  private           UnityEngine.Vector3             headLocalPosition  // 0x120
  private           UnityEngine.Quaternion          headLocalRotation  // 0x12C
  private           UnityEngine.Vector3[]           stretchLocalPositions  // 0x140
  private           UnityEngine.Quaternion[]        stretchLocalRotations  // 0x148
  private           UnityEngine.Vector3[]           chestLocalPositions  // 0x150
  private           UnityEngine.Quaternion[]        chestLocalRotations  // 0x158
  private           System.Int32                    bendBonesCount  // 0x160
  private           System.Int32                    ccdBonesCount  // 0x164
  private           System.Int32                    stretchBonesCount  // 0x168
  private           System.Int32                    chestBonesCount  // 0x16C
METHODS:
  System.Void Start()
  System.Void OnStoreDefaultLocalState()
  System.Void OnFixTransforms()
  System.Void OnPreRead()
  System.Void SpineBend()
  System.Void CCDPass()
  System.Void Iterate(System.Int32 iteration)
  System.Void OnPostUpdate()
  System.Void ChestDirection()
  System.Void PostStretching()
  System.Void LerpSolverPosition(RootMotion.FinalIK.IKEffector effector, UnityEngine.Vector3 position, System.Single weight, UnityEngine.Vector3 offset)
  System.Void Solve(UnityEngine.Vector3& pos1, UnityEngine.Vector3& pos2, System.Single nominalDistance)
  System.Void OnDestroy()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.FBIKChain
TYPE:  class
TOKEN: 0x200005D
FIELDS:
  public            System.Single                   pin  // 0x10
  public            System.Single                   pull  // 0x14
  public            System.Single                   push  // 0x18
  public            System.Single                   pushParent  // 0x1C
  public            System.Single                   reach  // 0x20
  public            RootMotion.FinalIK.FBIKChain.SmoothingreachSmoothing  // 0x24
  public            RootMotion.FinalIK.FBIKChain.SmoothingpushSmoothing  // 0x28
  public            RootMotion.FinalIK.IKSolver.Node[]nodes  // 0x30
  public            System.Int32[]                  children  // 0x38
  public            RootMotion.FinalIK.FBIKChain.ChildConstraint[]childConstraints  // 0x40
  public            RootMotion.FinalIK.IKConstraintBendbendConstraint  // 0x48
  private           System.Single                   rootLength  // 0x50
  private           System.Boolean                  initiated  // 0x54
  private           System.Single                   length  // 0x58
  private           System.Single                   distance  // 0x5C
  private           RootMotion.FinalIK.IKSolver.Pointp  // 0x60
  private           System.Single                   reachForce  // 0x68
  private           System.Single                   pullParentSum  // 0x6C
  private           System.Single[]                 crossFades  // 0x70
  private           System.Single                   sqrMag1  // 0x78
  private           System.Single                   sqrMag2  // 0x7C
  private           System.Single                   sqrMagDif  // 0x80
  private   static  System.Single                   maxLimbLength  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Single pin, System.Single pull, UnityEngine.Transform[] nodeTransforms)
  System.Void SetNodes(UnityEngine.Transform[] boneTransforms)
  System.Int32 GetNodeIndex(UnityEngine.Transform boneTransform)
  System.Boolean IsValid(System.String& message)
  System.Void Initiate(RootMotion.FinalIK.IKSolverFullBody solver)
  System.Void ReadPose(RootMotion.FinalIK.IKSolverFullBody solver, System.Boolean fullBody)
  System.Void CalculateBoneLengths(RootMotion.FinalIK.IKSolverFullBody solver)
  System.Void Reach(RootMotion.FinalIK.IKSolverFullBody solver)
  UnityEngine.Vector3 Push(RootMotion.FinalIK.IKSolverFullBody solver)
  System.Void SolveTrigonometric(RootMotion.FinalIK.IKSolverFullBody solver, System.Boolean calculateBendDirection)
  System.Void Stage1(RootMotion.FinalIK.IKSolverFullBody solver)
  System.Void Stage2(RootMotion.FinalIK.IKSolverFullBody solver, UnityEngine.Vector3 position)
  System.Void SolveConstraintSystems(RootMotion.FinalIK.IKSolverFullBody solver)
  UnityEngine.Vector3 SolveFABRIKJoint(UnityEngine.Vector3 pos1, UnityEngine.Vector3 pos2, System.Single length)
  UnityEngine.Vector3 GetDirToBendPoint(UnityEngine.Vector3 direction, UnityEngine.Vector3 bendDirection, System.Single directionMagnitude)
  System.Void SolveChildConstraints(RootMotion.FinalIK.IKSolverFullBody solver)
  System.Void SolveLinearConstraint(RootMotion.FinalIK.IKSolver.Node node1, RootMotion.FinalIK.IKSolver.Node node2, System.Single crossFade, System.Single distance)
  System.Void ForwardReach(UnityEngine.Vector3 position)
  System.Void BackwardReach(UnityEngine.Vector3 position)
END_CLASS

CLASS: RootMotion.FinalIK.IKConstraintBend
TYPE:  class
TOKEN: 0x2000060
FIELDS:
  public            UnityEngine.Transform           bone1  // 0x10
  public            UnityEngine.Transform           bone2  // 0x18
  public            UnityEngine.Transform           bone3  // 0x20
  public            UnityEngine.Transform           bendGoal  // 0x28
  public            UnityEngine.Vector3             direction  // 0x30
  public            UnityEngine.Quaternion          rotationOffset  // 0x3C
  public            System.Single                   weight  // 0x4C
  public            UnityEngine.Vector3             defaultLocalDirection  // 0x50
  public            UnityEngine.Vector3             defaultChildDirection  // 0x5C
  public            System.Single                   clampF  // 0x68
  private           System.Int32                    chainIndex1  // 0x6C
  private           System.Int32                    nodeIndex1  // 0x70
  private           System.Int32                    chainIndex2  // 0x74
  private           System.Int32                    nodeIndex2  // 0x78
  private           System.Int32                    chainIndex3  // 0x7C
  private           System.Int32                    nodeIndex3  // 0x80
  private           System.Boolean                  <initiated>k__BackingField  // 0x84
  private           System.Boolean                  limbOrientationsSet  // 0x85
METHODS:
  System.Boolean IsValid(RootMotion.FinalIK.IKSolverFullBody solver, RootMotion.Warning.Logger logger)
  System.Boolean get_initiated()
  System.Void set_initiated(System.Boolean value)
  System.Void .ctor()
  System.Void .ctor(UnityEngine.Transform bone1, UnityEngine.Transform bone2, UnityEngine.Transform bone3)
  System.Void SetBones(UnityEngine.Transform bone1, UnityEngine.Transform bone2, UnityEngine.Transform bone3)
  System.Void Initiate(RootMotion.FinalIK.IKSolverFullBody solver)
  System.Void SetLimbOrientation(UnityEngine.Vector3 upper, UnityEngine.Vector3 lower, UnityEngine.Vector3 last)
  System.Void LimitBend(System.Single solverWeight, System.Single positionWeight)
  UnityEngine.Vector3 GetDir(RootMotion.FinalIK.IKSolverFullBody solver)
  UnityEngine.Vector3 OrthoToLimb(RootMotion.FinalIK.IKSolverFullBody solver, UnityEngine.Vector3 tangent)
  UnityEngine.Vector3 OrthoToBone1(RootMotion.FinalIK.IKSolverFullBody solver, UnityEngine.Vector3 tangent)
END_CLASS

CLASS: RootMotion.FinalIK.IKEffector
TYPE:  class
TOKEN: 0x2000061
FIELDS:
  public            UnityEngine.Transform           bone  // 0x10
  public            UnityEngine.Transform           target  // 0x18
  public            System.Single                   positionWeight  // 0x20
  public            System.Single                   rotationWeight  // 0x24
  public            UnityEngine.Vector3             position  // 0x28
  public            UnityEngine.Quaternion          rotation  // 0x34
  public            UnityEngine.Vector3             positionOffset  // 0x44
  private           System.Boolean                  <isEndEffector>k__BackingField  // 0x50
  public            System.Boolean                  effectChildNodes  // 0x51
  public            System.Single                   maintainRelativePositionWeight  // 0x54
  public            UnityEngine.Transform[]         childBones  // 0x58
  public            UnityEngine.Transform           planeBone1  // 0x60
  public            UnityEngine.Transform           planeBone2  // 0x68
  public            UnityEngine.Transform           planeBone3  // 0x70
  public            UnityEngine.Quaternion          planeRotationOffset  // 0x78
  private           System.Single                   posW  // 0x88
  private           System.Single                   rotW  // 0x8C
  private           UnityEngine.Vector3[]           localPositions  // 0x90
  private           System.Boolean                  usePlaneNodes  // 0x98
  private           UnityEngine.Quaternion          animatedPlaneRotation  // 0x9C
  private           UnityEngine.Vector3             animatedPosition  // 0xAC
  private           System.Boolean                  firstUpdate  // 0xB8
  private           System.Int32                    chainIndex  // 0xBC
  private           System.Int32                    nodeIndex  // 0xC0
  private           System.Int32                    plane1ChainIndex  // 0xC4
  private           System.Int32                    plane1NodeIndex  // 0xC8
  private           System.Int32                    plane2ChainIndex  // 0xCC
  private           System.Int32                    plane2NodeIndex  // 0xD0
  private           System.Int32                    plane3ChainIndex  // 0xD4
  private           System.Int32                    plane3NodeIndex  // 0xD8
  private           System.Int32[]                  childChainIndexes  // 0xE0
  private           System.Int32[]                  childNodeIndexes  // 0xE8
METHODS:
  RootMotion.FinalIK.IKSolver.Node GetNode(RootMotion.FinalIK.IKSolverFullBody solver)
  System.Boolean get_isEndEffector()
  System.Void set_isEndEffector(System.Boolean value)
  System.Void PinToBone(System.Single positionWeight, System.Single rotationWeight)
  System.Void .ctor()
  System.Void .ctor(UnityEngine.Transform bone, UnityEngine.Transform[] childBones)
  System.Boolean IsValid(RootMotion.FinalIK.IKSolver solver, System.String& message)
  System.Void Initiate(RootMotion.FinalIK.IKSolverFullBody solver)
  System.Void ResetOffset(RootMotion.FinalIK.IKSolverFullBody solver)
  System.Void SetToTarget()
  System.Void OnPreSolve(RootMotion.FinalIK.IKSolverFullBody solver)
  System.Void OnPostWrite()
  UnityEngine.Quaternion GetPlaneRotation(RootMotion.FinalIK.IKSolverFullBody solver)
  System.Void Update(RootMotion.FinalIK.IKSolverFullBody solver)
  UnityEngine.Vector3 GetPosition(RootMotion.FinalIK.IKSolverFullBody solver, UnityEngine.Quaternion& planeRotationOffset)
END_CLASS

CLASS: RootMotion.FinalIK.IKMapping
TYPE:  class
TOKEN: 0x2000062
FIELDS:
METHODS:
  System.Boolean IsValid(RootMotion.FinalIK.IKSolver solver, System.String& message)
  System.Void Initiate(RootMotion.FinalIK.IKSolverFullBody solver)
  System.Boolean BoneIsValid(UnityEngine.Transform bone, RootMotion.FinalIK.IKSolver solver, System.String& message, RootMotion.Warning.Logger logger)
  UnityEngine.Vector3 SolveFABRIKJoint(UnityEngine.Vector3 pos1, UnityEngine.Vector3 pos2, System.Single length)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.IKMappingBone
TYPE:  class
TOKEN: 0x2000064
EXTENDS: IKMapping
FIELDS:
  public            UnityEngine.Transform           bone  // 0x10
  public            System.Single                   maintainRotationWeight  // 0x18
  private           RootMotion.FinalIK.IKMapping.BoneMapboneMap  // 0x20
METHODS:
  System.Boolean IsValid(RootMotion.FinalIK.IKSolver solver, System.String& message)
  System.Void .ctor()
  System.Void .ctor(UnityEngine.Transform bone)
  System.Void StoreDefaultLocalState()
  System.Void FixTransforms()
  System.Void Initiate(RootMotion.FinalIK.IKSolverFullBody solver)
  System.Void ReadPose()
  System.Void WritePose(System.Single solverWeight)
END_CLASS

CLASS: RootMotion.FinalIK.IKMappingLimb
TYPE:  class
TOKEN: 0x2000065
EXTENDS: IKMapping
FIELDS:
  public            UnityEngine.Transform           parentBone  // 0x10
  public            UnityEngine.Transform           bone1  // 0x18
  public            UnityEngine.Transform           bone2  // 0x20
  public            UnityEngine.Transform           bone3  // 0x28
  public            System.Single                   maintainRotationWeight  // 0x30
  public            System.Single                   weight  // 0x34
  public            System.Boolean                  updatePlaneRotations  // 0x38
  private           RootMotion.FinalIK.IKMapping.BoneMapboneMapParent  // 0x40
  private           RootMotion.FinalIK.IKMapping.BoneMapboneMap1  // 0x48
  private           RootMotion.FinalIK.IKMapping.BoneMapboneMap2  // 0x50
  private           RootMotion.FinalIK.IKMapping.BoneMapboneMap3  // 0x58
METHODS:
  System.Boolean IsValid(RootMotion.FinalIK.IKSolver solver, System.String& message)
  RootMotion.FinalIK.IKMapping.BoneMap GetBoneMap(RootMotion.FinalIK.IKMappingLimb.BoneMapType boneMap)
  System.Void SetLimbOrientation(UnityEngine.Vector3 upper, UnityEngine.Vector3 lower)
  System.Void .ctor()
  System.Void .ctor(UnityEngine.Transform bone1, UnityEngine.Transform bone2, UnityEngine.Transform bone3, UnityEngine.Transform parentBone)
  System.Void SetBones(UnityEngine.Transform bone1, UnityEngine.Transform bone2, UnityEngine.Transform bone3, UnityEngine.Transform parentBone)
  System.Void StoreDefaultLocalState()
  System.Void FixTransforms()
  System.Void Initiate(RootMotion.FinalIK.IKSolverFullBody solver)
  System.Void ReadPose()
  System.Void WritePose(RootMotion.FinalIK.IKSolverFullBody solver, System.Boolean fullBody)
END_CLASS

CLASS: RootMotion.FinalIK.IKMappingSpine
TYPE:  class
TOKEN: 0x2000067
EXTENDS: IKMapping
FIELDS:
  public            UnityEngine.Transform[]         spineBones  // 0x10
  public            UnityEngine.Transform           leftUpperArmBone  // 0x18
  public            UnityEngine.Transform           rightUpperArmBone  // 0x20
  public            UnityEngine.Transform           leftThighBone  // 0x28
  public            UnityEngine.Transform           rightThighBone  // 0x30
  public            System.Int32                    iterations  // 0x38
  public            System.Single                   twistWeight  // 0x3C
  private           System.Int32                    rootNodeIndex  // 0x40
  private           RootMotion.FinalIK.IKMapping.BoneMap[]spine  // 0x48
  private           RootMotion.FinalIK.IKMapping.BoneMapleftUpperArm  // 0x50
  private           RootMotion.FinalIK.IKMapping.BoneMaprightUpperArm  // 0x58
  private           RootMotion.FinalIK.IKMapping.BoneMapleftThigh  // 0x60
  private           RootMotion.FinalIK.IKMapping.BoneMaprightThigh  // 0x68
  private           System.Boolean                  useFABRIK  // 0x70
METHODS:
  System.Boolean IsValid(RootMotion.FinalIK.IKSolver solver, System.String& message)
  System.Void .ctor()
  System.Void .ctor(UnityEngine.Transform[] spineBones, UnityEngine.Transform leftUpperArmBone, UnityEngine.Transform rightUpperArmBone, UnityEngine.Transform leftThighBone, UnityEngine.Transform rightThighBone)
  System.Void SetBones(UnityEngine.Transform[] spineBones, UnityEngine.Transform leftUpperArmBone, UnityEngine.Transform rightUpperArmBone, UnityEngine.Transform leftThighBone, UnityEngine.Transform rightThighBone)
  System.Void StoreDefaultLocalState()
  System.Void FixTransforms()
  System.Void Initiate(RootMotion.FinalIK.IKSolverFullBody solver)
  System.Boolean UseFABRIK()
  System.Void ReadPose()
  System.Void WritePose(RootMotion.FinalIK.IKSolverFullBody solver)
  System.Void ForwardReach(UnityEngine.Vector3 position)
  System.Void BackwardReach(UnityEngine.Vector3 position)
  System.Void MapToSolverPositions(RootMotion.FinalIK.IKSolverFullBody solver)
END_CLASS

CLASS: RootMotion.FinalIK.IKSolver
TYPE:  class
TOKEN: 0x2000068
FIELDS:
  public            System.Boolean                  executedInEditor  // 0x10
  public            UnityEngine.Vector3             IKPosition  // 0x14
  public            System.Single                   IKPositionWeight  // 0x20
  private           System.Boolean                  <initiated>k__BackingField  // 0x24
  public            RootMotion.FinalIK.IKSolver.UpdateDelegateOnPreInitiate  // 0x28
  public            RootMotion.FinalIK.IKSolver.UpdateDelegateOnPostInitiate  // 0x30
  public            RootMotion.FinalIK.IKSolver.UpdateDelegateOnPreUpdate  // 0x38
  public            RootMotion.FinalIK.IKSolver.UpdateDelegateOnPostUpdate  // 0x40
  protected         System.Boolean                  firstInitiation  // 0x48
  protected         UnityEngine.Transform           root  // 0x50
METHODS:
  System.Boolean IsValid()
  System.Boolean IsValid(System.String& message)
  System.Void Initiate(UnityEngine.Transform root)
  System.Void Update()
  UnityEngine.Vector3 GetIKPosition()
  System.Void SetIKPosition(UnityEngine.Vector3 position)
  System.Single GetIKPositionWeight()
  System.Void SetIKPositionWeight(System.Single weight)
  UnityEngine.Transform GetRoot()
  System.Boolean get_initiated()
  System.Void set_initiated(System.Boolean value)
  RootMotion.FinalIK.IKSolver.Point[] GetPoints()
  RootMotion.FinalIK.IKSolver.Point GetPoint(UnityEngine.Transform transform)
  System.Void FixTransforms()
  System.Void StoreDefaultLocalState()
  System.Void OnInitiate()
  System.Void OnUpdate()
  System.Void LogWarning(System.String message)
  UnityEngine.Transform ContainsDuplicateBone(RootMotion.FinalIK.IKSolver.Bone[] bones)
  System.Boolean HierarchyIsValid(RootMotion.FinalIK.IKSolver.Bone[] bones)
  System.Single PreSolveBones(RootMotion.FinalIK.IKSolver.Bone[]& bones)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.IKSolverAim
TYPE:  class
TOKEN: 0x200006E
EXTENDS: IKSolverHeuristic
FIELDS:
  public            UnityEngine.Transform           transform  // 0x88
  public            UnityEngine.Vector3             axis  // 0x90
  public            UnityEngine.Vector3             poleAxis  // 0x9C
  public            UnityEngine.Vector3             polePosition  // 0xA8
  public            System.Single                   poleWeight  // 0xB4
  public            UnityEngine.Transform           poleTarget  // 0xB8
  public            System.Single                   clampWeight  // 0xC0
  public            System.Int32                    clampSmoothing  // 0xC4
  public            RootMotion.FinalIK.IKSolver.IterationDelegateOnPreIteration  // 0xC8
  private           System.Single                   step  // 0xD0
  private           UnityEngine.Vector3             clampedIKPosition  // 0xD4
  private           RootMotion.FinalIK.RotationLimittransformLimit  // 0xE0
  private           UnityEngine.Transform           lastTransform  // 0xE8
METHODS:
  System.Single GetAngle()
  UnityEngine.Vector3 get_transformAxis()
  UnityEngine.Vector3 get_transformPoleAxis()
  System.Void OnInitiate()
  System.Void OnUpdate()
  System.Int32 get_minBones()
  System.Void Solve()
  UnityEngine.Vector3 GetClampedIKPosition()
  System.Void RotateToTarget(UnityEngine.Vector3 targetPosition, RootMotion.FinalIK.IKSolver.Bone bone, System.Single weight)
  UnityEngine.Vector3 get_localDirection()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.IKSolverArm
TYPE:  class
TOKEN: 0x200006F
EXTENDS: IKSolver
FIELDS:
  public            System.Single                   IKRotationWeight  // 0x58
  public            UnityEngine.Quaternion          IKRotation  // 0x5C
  public            RootMotion.FinalIK.IKSolver.Pointchest  // 0x70
  public            RootMotion.FinalIK.IKSolver.Pointshoulder  // 0x78
  public            RootMotion.FinalIK.IKSolver.PointupperArm  // 0x80
  public            RootMotion.FinalIK.IKSolver.Pointforearm  // 0x88
  public            RootMotion.FinalIK.IKSolver.Pointhand  // 0x90
  public            System.Boolean                  isLeft  // 0x98
  public            RootMotion.FinalIK.IKSolverVR.Armarm  // 0xA0
  private           UnityEngine.Vector3[]           positions  // 0xA8
  private           UnityEngine.Quaternion[]        rotations  // 0xB0
METHODS:
  System.Boolean IsValid(System.String& message)
  System.Boolean SetChain(UnityEngine.Transform chest, UnityEngine.Transform shoulder, UnityEngine.Transform upperArm, UnityEngine.Transform forearm, UnityEngine.Transform hand, UnityEngine.Transform root)
  RootMotion.FinalIK.IKSolver.Point[] GetPoints()
  RootMotion.FinalIK.IKSolver.Point GetPoint(UnityEngine.Transform transform)
  System.Void StoreDefaultLocalState()
  System.Void FixTransforms()
  System.Void OnInitiate()
  System.Void OnUpdate()
  System.Void Solve()
  System.Void Read()
  System.Void Write()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.IKSolverCCD
TYPE:  class
TOKEN: 0x2000070
EXTENDS: IKSolverHeuristic
FIELDS:
  public            RootMotion.FinalIK.IKSolver.IterationDelegateOnPreIteration  // 0x88
METHODS:
  System.Void FadeOutBoneWeights()
  System.Void OnInitiate()
  System.Void OnUpdate()
  System.Void Solve(UnityEngine.Vector3 targetPosition)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.IKSolverFABRIK
TYPE:  class
TOKEN: 0x2000071
EXTENDS: IKSolverHeuristic
FIELDS:
  public            RootMotion.FinalIK.IKSolver.IterationDelegateOnPreIteration  // 0x88
  private           System.Boolean[]                limitedBones  // 0x90
  private           UnityEngine.Vector3[]           solverLocalPositions  // 0x98
METHODS:
  System.Void SolveForward(UnityEngine.Vector3 position)
  System.Void SolveBackward(UnityEngine.Vector3 position)
  UnityEngine.Vector3 GetIKPosition()
  System.Void OnInitiate()
  System.Void OnUpdate()
  System.Boolean get_boneLengthCanBeZero()
  UnityEngine.Vector3 SolveJoint(UnityEngine.Vector3 pos1, UnityEngine.Vector3 pos2, System.Single length)
  System.Void OnPreSolve()
  System.Void OnPostSolve()
  System.Void Solve(UnityEngine.Vector3 targetPosition)
  System.Void ForwardReach(UnityEngine.Vector3 position)
  System.Void SolverMove(System.Int32 index, UnityEngine.Vector3 offset)
  System.Void SolverRotate(System.Int32 index, UnityEngine.Quaternion rotation, System.Boolean recursive)
  System.Void SolverRotateChildren(System.Int32 index, UnityEngine.Quaternion rotation)
  System.Void SolverMoveChildrenAroundPoint(System.Int32 index, UnityEngine.Quaternion rotation)
  UnityEngine.Quaternion GetParentSolverRotation(System.Int32 index)
  UnityEngine.Vector3 GetParentSolverPosition(System.Int32 index)
  UnityEngine.Quaternion GetLimitedRotation(System.Int32 index, UnityEngine.Quaternion q, System.Boolean& changed)
  System.Void LimitForward(System.Int32 rotateBone, System.Int32 limitBone)
  System.Void BackwardReach(UnityEngine.Vector3 position)
  System.Void BackwardReachUnlimited(UnityEngine.Vector3 position)
  System.Void BackwardReachLimited(UnityEngine.Vector3 position)
  System.Void MapToSolverPositions()
  System.Void MapToSolverPositionsLimited()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.IKSolverFABRIKRoot
TYPE:  class
TOKEN: 0x2000072
EXTENDS: IKSolver
FIELDS:
  public            System.Int32                    iterations  // 0x58
  public            System.Single                   rootPin  // 0x5C
  public            RootMotion.FinalIK.FABRIKChain[]chains  // 0x60
  private           System.Boolean                  zeroWeightApplied  // 0x68
  private           System.Boolean[]                isRoot  // 0x70
  private           UnityEngine.Vector3             rootDefaultPosition  // 0x78
METHODS:
  System.Boolean IsValid(System.String& message)
  System.Void StoreDefaultLocalState()
  System.Void FixTransforms()
  System.Void OnInitiate()
  System.Boolean IsRoot(System.Int32 index)
  System.Void OnUpdate()
  RootMotion.FinalIK.IKSolver.Point[] GetPoints()
  RootMotion.FinalIK.IKSolver.Point GetPoint(UnityEngine.Transform transform)
  System.Void AddPointsToArray(RootMotion.FinalIK.IKSolver.Point[]& array, RootMotion.FinalIK.FABRIKChain chain)
  UnityEngine.Vector3 GetCentroid()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.IKSolverFullBody
TYPE:  class
TOKEN: 0x2000073
EXTENDS: IKSolver
FIELDS:
  public            System.Int32                    iterations  // 0x58
  public            RootMotion.FinalIK.FBIKChain[]  chain  // 0x60
  public            RootMotion.FinalIK.IKEffector[] effectors  // 0x68
  public            RootMotion.FinalIK.IKMappingSpinespineMapping  // 0x70
  public            RootMotion.FinalIK.IKMappingBone[]boneMappings  // 0x78
  public            RootMotion.FinalIK.IKMappingLimb[]limbMappings  // 0x80
  public            System.Boolean                  FABRIKPass  // 0x88
  public            RootMotion.FinalIK.IKSolver.UpdateDelegateOnPreRead  // 0x90
  public            RootMotion.FinalIK.IKSolver.UpdateDelegateOnPreSolve  // 0x98
  public            RootMotion.FinalIK.IKSolver.IterationDelegateOnPreIteration  // 0xA0
  public            RootMotion.FinalIK.IKSolver.IterationDelegateOnPostIteration  // 0xA8
  public            RootMotion.FinalIK.IKSolver.UpdateDelegateOnPreBend  // 0xB0
  public            RootMotion.FinalIK.IKSolver.UpdateDelegateOnPostSolve  // 0xB8
  public            RootMotion.FinalIK.IKSolver.UpdateDelegateOnStoreDefaultLocalState  // 0xC0
  public            RootMotion.FinalIK.IKSolver.UpdateDelegateOnFixTransforms  // 0xC8
METHODS:
  RootMotion.FinalIK.IKEffector GetEffector(UnityEngine.Transform t)
  RootMotion.FinalIK.FBIKChain GetChain(UnityEngine.Transform transform)
  System.Int32 GetChainIndex(UnityEngine.Transform transform)
  RootMotion.FinalIK.IKSolver.Node GetNode(System.Int32 chainIndex, System.Int32 nodeIndex)
  System.Void GetChainAndNodeIndexes(UnityEngine.Transform transform, System.Int32& chainIndex, System.Int32& nodeIndex)
  RootMotion.FinalIK.IKSolver.Point[] GetPoints()
  RootMotion.FinalIK.IKSolver.Point GetPoint(UnityEngine.Transform transform)
  System.Boolean IsValid(System.String& message)
  System.Void StoreDefaultLocalState()
  System.Void FixTransforms()
  System.Void OnInitiate()
  System.Void OnUpdate()
  System.Void ReadPose()
  System.Void Solve()
  System.Void ApplyBendConstraints()
  System.Void WritePose()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.FullBodyBipedEffector
TYPE:  struct
TOKEN: 0x2000074
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  RootMotion.FinalIK.FullBodyBipedEffectorBody  // 0x0
  public    static  RootMotion.FinalIK.FullBodyBipedEffectorLeftShoulder  // 0x0
  public    static  RootMotion.FinalIK.FullBodyBipedEffectorRightShoulder  // 0x0
  public    static  RootMotion.FinalIK.FullBodyBipedEffectorLeftThigh  // 0x0
  public    static  RootMotion.FinalIK.FullBodyBipedEffectorRightThigh  // 0x0
  public    static  RootMotion.FinalIK.FullBodyBipedEffectorLeftHand  // 0x0
  public    static  RootMotion.FinalIK.FullBodyBipedEffectorRightHand  // 0x0
  public    static  RootMotion.FinalIK.FullBodyBipedEffectorLeftFoot  // 0x0
  public    static  RootMotion.FinalIK.FullBodyBipedEffectorRightFoot  // 0x0
METHODS:
END_CLASS

CLASS: RootMotion.FinalIK.FullBodyBipedChain
TYPE:  struct
TOKEN: 0x2000075
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  RootMotion.FinalIK.FullBodyBipedChainLeftArm  // 0x0
  public    static  RootMotion.FinalIK.FullBodyBipedChainRightArm  // 0x0
  public    static  RootMotion.FinalIK.FullBodyBipedChainLeftLeg  // 0x0
  public    static  RootMotion.FinalIK.FullBodyBipedChainRightLeg  // 0x0
METHODS:
END_CLASS

CLASS: RootMotion.FinalIK.IKSolverFullBodyBiped
TYPE:  class
TOKEN: 0x2000076
EXTENDS: IKSolverFullBody
FIELDS:
  public            UnityEngine.Transform           rootNode  // 0xD0
  public            System.Single                   spineStiffness  // 0xD8
  public            System.Single                   pullBodyVertical  // 0xDC
  public            System.Single                   pullBodyHorizontal  // 0xE0
  private           UnityEngine.Vector3             <pullBodyOffset>k__BackingField  // 0xE4
  private           UnityEngine.Vector3             offset  // 0xF0
METHODS:
  RootMotion.FinalIK.IKEffector get_bodyEffector()
  RootMotion.FinalIK.IKEffector get_leftShoulderEffector()
  RootMotion.FinalIK.IKEffector get_rightShoulderEffector()
  RootMotion.FinalIK.IKEffector get_leftThighEffector()
  RootMotion.FinalIK.IKEffector get_rightThighEffector()
  RootMotion.FinalIK.IKEffector get_leftHandEffector()
  RootMotion.FinalIK.IKEffector get_rightHandEffector()
  RootMotion.FinalIK.IKEffector get_leftFootEffector()
  RootMotion.FinalIK.IKEffector get_rightFootEffector()
  RootMotion.FinalIK.FBIKChain get_leftArmChain()
  RootMotion.FinalIK.FBIKChain get_rightArmChain()
  RootMotion.FinalIK.FBIKChain get_leftLegChain()
  RootMotion.FinalIK.FBIKChain get_rightLegChain()
  RootMotion.FinalIK.IKMappingLimb get_leftArmMapping()
  RootMotion.FinalIK.IKMappingLimb get_rightArmMapping()
  RootMotion.FinalIK.IKMappingLimb get_leftLegMapping()
  RootMotion.FinalIK.IKMappingLimb get_rightLegMapping()
  RootMotion.FinalIK.IKMappingBone get_headMapping()
  System.Void SetChainWeights(RootMotion.FinalIK.FullBodyBipedChain c, System.Single pull, System.Single reach)
  System.Void SetEffectorWeights(RootMotion.FinalIK.FullBodyBipedEffector effector, System.Single positionWeight, System.Single rotationWeight)
  RootMotion.FinalIK.FBIKChain GetChain(RootMotion.FinalIK.FullBodyBipedChain c)
  RootMotion.FinalIK.FBIKChain GetChain(RootMotion.FinalIK.FullBodyBipedEffector effector)
  RootMotion.FinalIK.IKEffector GetEffector(RootMotion.FinalIK.FullBodyBipedEffector effector)
  RootMotion.FinalIK.IKEffector GetEndEffector(RootMotion.FinalIK.FullBodyBipedChain c)
  RootMotion.FinalIK.IKMappingLimb GetLimbMapping(RootMotion.FinalIK.FullBodyBipedChain chain)
  RootMotion.FinalIK.IKMappingLimb GetLimbMapping(RootMotion.FinalIK.FullBodyBipedEffector effector)
  RootMotion.FinalIK.IKMappingSpine GetSpineMapping()
  RootMotion.FinalIK.IKMappingBone GetHeadMapping()
  RootMotion.FinalIK.IKConstraintBend GetBendConstraint(RootMotion.FinalIK.FullBodyBipedChain limb)
  System.Boolean IsValid(System.String& message)
  System.Void SetToReferences(RootMotion.BipedReferences references, UnityEngine.Transform rootNode)
  UnityEngine.Transform DetectRootNodeBone(RootMotion.BipedReferences references)
  System.Void SetLimbOrientations(RootMotion.BipedLimbOrientations o)
  UnityEngine.Vector3 get_pullBodyOffset()
  System.Void set_pullBodyOffset(UnityEngine.Vector3 value)
  System.Void SetLimbOrientation(RootMotion.FinalIK.FullBodyBipedChain chain, RootMotion.BipedLimbOrientations.LimbOrientation limbOrientation)
  UnityEngine.Transform GetLeftClavicle(RootMotion.BipedReferences references)
  UnityEngine.Transform GetRightClavicle(RootMotion.BipedReferences references)
  System.Boolean Contains(UnityEngine.Transform[] array, UnityEngine.Transform transform)
  System.Void ReadPose()
  System.Void PullBody()
  UnityEngine.Vector3 GetBodyOffset()
  UnityEngine.Vector3 GetHandBodyPull(RootMotion.FinalIK.IKEffector effector, RootMotion.FinalIK.FBIKChain arm, UnityEngine.Vector3 offset)
  System.Void ApplyBendConstraints()
  System.Void WritePose()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.IKSolverHeuristic
TYPE:  class
TOKEN: 0x2000077
EXTENDS: IKSolver
FIELDS:
  public            UnityEngine.Transform           target  // 0x58
  public            System.Single                   tolerance  // 0x60
  public            System.Int32                    maxIterations  // 0x64
  public            System.Boolean                  useRotationLimits  // 0x68
  public            System.Boolean                  XY  // 0x69
  public            RootMotion.FinalIK.IKSolver.Bone[]bones  // 0x70
  protected         UnityEngine.Vector3             lastLocalDirection  // 0x78
  protected         System.Single                   chainLength  // 0x84
METHODS:
  System.Boolean SetChain(UnityEngine.Transform[] hierarchy, UnityEngine.Transform root)
  System.Void AddBone(UnityEngine.Transform bone)
  System.Void StoreDefaultLocalState()
  System.Void FixTransforms()
  System.Boolean IsValid(System.String& message)
  RootMotion.FinalIK.IKSolver.Point[] GetPoints()
  RootMotion.FinalIK.IKSolver.Point GetPoint(UnityEngine.Transform transform)
  System.Int32 get_minBones()
  System.Boolean get_boneLengthCanBeZero()
  System.Boolean get_allowCommonParent()
  System.Void OnInitiate()
  System.Void OnUpdate()
  System.Void InitiateBones()
  UnityEngine.Vector3 get_localDirection()
  System.Single get_positionOffset()
  UnityEngine.Vector3 GetSingularityOffset()
  System.Boolean SingularityDetected()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.IKSolverLeg
TYPE:  class
TOKEN: 0x2000078
EXTENDS: IKSolver
FIELDS:
  public            System.Single                   IKRotationWeight  // 0x58
  public            UnityEngine.Quaternion          IKRotation  // 0x5C
  public            RootMotion.FinalIK.IKSolver.Pointpelvis  // 0x70
  public            RootMotion.FinalIK.IKSolver.Pointthigh  // 0x78
  public            RootMotion.FinalIK.IKSolver.Pointcalf  // 0x80
  public            RootMotion.FinalIK.IKSolver.Pointfoot  // 0x88
  public            RootMotion.FinalIK.IKSolver.Pointtoe  // 0x90
  public            RootMotion.FinalIK.IKSolverVR.Legleg  // 0x98
  public            UnityEngine.Vector3             heelOffset  // 0xA0
  private           UnityEngine.Vector3[]           positions  // 0xB0
  private           UnityEngine.Quaternion[]        rotations  // 0xB8
METHODS:
  System.Boolean IsValid(System.String& message)
  System.Boolean SetChain(UnityEngine.Transform pelvis, UnityEngine.Transform thigh, UnityEngine.Transform calf, UnityEngine.Transform foot, UnityEngine.Transform toe, UnityEngine.Transform root)
  RootMotion.FinalIK.IKSolver.Point[] GetPoints()
  RootMotion.FinalIK.IKSolver.Point GetPoint(UnityEngine.Transform transform)
  System.Void StoreDefaultLocalState()
  System.Void FixTransforms()
  System.Void OnInitiate()
  System.Void OnUpdate()
  System.Void Solve()
  System.Void Read()
  System.Void Write()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.IKSolverLimb
TYPE:  class
TOKEN: 0x2000079
EXTENDS: IKSolverTrigonometric
FIELDS:
  public            UnityEngine.AvatarIKGoal        goal  // 0xA8
  public            RootMotion.FinalIK.IKSolverLimb.BendModifierbendModifier  // 0xAC
  public            System.Single                   maintainRotationWeight  // 0xB0
  public            System.Single                   bendModifierWeight  // 0xB4
  public            UnityEngine.Transform           bendGoal  // 0xB8
  private           System.Boolean                  maintainBendFor1Frame  // 0xC0
  private           System.Boolean                  maintainRotationFor1Frame  // 0xC1
  private           UnityEngine.Quaternion          defaultRootRotation  // 0xC4
  private           UnityEngine.Quaternion          parentDefaultRotation  // 0xD4
  private           UnityEngine.Quaternion          bone3RotationBeforeSolve  // 0xE4
  private           UnityEngine.Quaternion          maintainRotation  // 0xF4
  private           UnityEngine.Quaternion          bone3DefaultRotation  // 0x104
  private           UnityEngine.Vector3             _bendNormal  // 0x114
  private           UnityEngine.Vector3             animationNormal  // 0x120
  private           RootMotion.FinalIK.IKSolverLimb.AxisDirection[]axisDirectionsLeft  // 0x130
  private           RootMotion.FinalIK.IKSolverLimb.AxisDirection[]axisDirectionsRight  // 0x138
METHODS:
  System.Void MaintainRotation()
  System.Void MaintainBend()
  System.Void OnInitiateVirtual()
  System.Void OnUpdateVirtual()
  System.Void OnPostSolveVirtual()
  System.Void .ctor()
  System.Void .ctor(UnityEngine.AvatarIKGoal goal)
  RootMotion.FinalIK.IKSolverLimb.AxisDirection[] get_axisDirections()
  System.Void StoreAxisDirections(RootMotion.FinalIK.IKSolverLimb.AxisDirection[]& axisDirections)
  UnityEngine.Vector3 GetModifiedBendNormal()
END_CLASS

CLASS: RootMotion.FinalIK.IKSolverLookAt
TYPE:  class
TOKEN: 0x200007C
EXTENDS: IKSolver
FIELDS:
  public            UnityEngine.Transform           target  // 0x58
  public            RootMotion.FinalIK.IKSolverLookAt.LookAtBone[]spine  // 0x60
  private           UnityEngine.Quaternion[]        m_spineVirtualBones  // 0x68
  public            RootMotion.FinalIK.IKSolverLookAt.LookAtBonehead  // 0x70
  private           UnityEngine.Quaternion          m_headVirtualBones  // 0x78
  public            RootMotion.FinalIK.IKSolverLookAt.LookAtBone[]eyes  // 0x88
  private           UnityEngine.Quaternion          m_eyeVirtualBone  // 0x90
  public            System.Single                   bodyWeight  // 0xA0
  public            System.Single                   headWeight  // 0xA4
  public            System.Single                   eyesWeight  // 0xA8
  public            System.Single                   clampWeight  // 0xAC
  public            System.Single                   clampWeightHead  // 0xB0
  public            System.Single                   clampWeightEyes  // 0xB4
  public            System.Int32                    clampSmoothing  // 0xB8
  public            UnityEngine.AnimationCurve      spineWeightCurve  // 0xC0
  public            UnityEngine.Vector3             spineTargetOffset  // 0xC8
  protected         UnityEngine.Vector3[]           spineForwards  // 0xD8
  protected         UnityEngine.Vector3[]           headForwards  // 0xE0
  protected         UnityEngine.Vector3[]           eyeForward  // 0xE8
  private           System.Boolean                  isDirty  // 0xF0
METHODS:
  UnityEngine.Quaternion[] get_spineVirtualBone()
  System.Void set_spineVirtualBone(UnityEngine.Quaternion[] value)
  UnityEngine.Quaternion get_headVirtualBones()
  System.Void set_headVirtualBones(UnityEngine.Quaternion value)
  UnityEngine.Quaternion get_eyeVirtualBone()
  System.Void set_eyeVirtualBone(UnityEngine.Quaternion value)
  System.Void SetLookAtWeight(System.Single weight)
  System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight)
  System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight)
  System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight)
  System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight, System.Single clampWeight)
  System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight, System.Single clampWeight, System.Single clampWeightHead, System.Single clampWeightEyes)
  System.Void StoreDefaultLocalState()
  System.Void SetDirty()
  System.Void FixTransforms()
  System.Boolean IsValid(System.String& message)
  RootMotion.FinalIK.IKSolver.Point[] GetPoints()
  RootMotion.FinalIK.IKSolver.Point GetPoint(UnityEngine.Transform transform)
  System.Boolean SetChain(UnityEngine.Transform[] spine, UnityEngine.Transform head, UnityEngine.Transform[] eyes, UnityEngine.Transform root)
  System.Void OnInitiate()
  System.Void OnUpdate()
  System.Boolean get_spineIsValid()
  System.Boolean get_spineIsEmpty()
  System.Void SolveSpine()
  System.Boolean get_headIsValid()
  System.Boolean get_headIsEmpty()
  System.Void SolveHead()
  System.Boolean get_eyesIsValid()
  System.Boolean get_eyesIsEmpty()
  System.Void SolveEyes()
  UnityEngine.Vector3[] GetForwards(UnityEngine.Vector3[]& forwards, UnityEngine.Vector3 baseForward, UnityEngine.Vector3 targetForward, System.Int32 bones, System.Single clamp)
  System.Void SetBones(UnityEngine.Transform[] array, RootMotion.FinalIK.IKSolverLookAt.LookAtBone[]& bones)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.IKSolverTrigonometric
TYPE:  class
TOKEN: 0x200007E
EXTENDS: IKSolver
FIELDS:
  public            UnityEngine.Transform           target  // 0x58
  public            System.Single                   IKRotationWeight  // 0x60
  public            UnityEngine.Quaternion          IKRotation  // 0x64
  public            UnityEngine.Vector3             bendNormal  // 0x74
  public            RootMotion.FinalIK.IKSolverTrigonometric.TrigonometricBonebone1  // 0x80
  public            RootMotion.FinalIK.IKSolverTrigonometric.TrigonometricBonebone2  // 0x88
  public            RootMotion.FinalIK.IKSolverTrigonometric.TrigonometricBonebone3  // 0x90
  protected         UnityEngine.Vector3             weightIKPosition  // 0x98
  protected         System.Boolean                  directHierarchy  // 0xA4
METHODS:
  System.Void SetBendGoalPosition(UnityEngine.Vector3 goalPosition, System.Single weight)
  System.Void SetBendPlaneToCurrent()
  System.Void SetIKRotation(UnityEngine.Quaternion rotation)
  System.Void SetIKRotationWeight(System.Single weight)
  UnityEngine.Quaternion GetIKRotation()
  System.Single GetIKRotationWeight()
  RootMotion.FinalIK.IKSolver.Point[] GetPoints()
  RootMotion.FinalIK.IKSolver.Point GetPoint(UnityEngine.Transform transform)
  System.Void StoreDefaultLocalState()
  System.Void FixTransforms()
  System.Boolean IsValid(System.String& message)
  System.Boolean SetChain(UnityEngine.Transform bone1, UnityEngine.Transform bone2, UnityEngine.Transform bone3, UnityEngine.Transform root)
  System.Void Solve(UnityEngine.Transform bone1, UnityEngine.Transform bone2, UnityEngine.Transform bone3, UnityEngine.Vector3 targetPosition, UnityEngine.Vector3 bendNormal, System.Single weight)
  UnityEngine.Vector3 GetDirectionToBendPoint(UnityEngine.Vector3 direction, System.Single directionMag, UnityEngine.Vector3 bendDirection, System.Single sqrMag1, System.Single sqrMag2)
  System.Void OnInitiate()
  System.Boolean IsDirectHierarchy()
  System.Void InitiateBones()
  System.Void OnUpdate()
  System.Void OnInitiateVirtual()
  System.Void OnUpdateVirtual()
  System.Void OnPostSolveVirtual()
  UnityEngine.Vector3 GetBendDirection(UnityEngine.Vector3 IKPosition, UnityEngine.Vector3 bendNormal)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.IKSolverVR
TYPE:  class
TOKEN: 0x2000080
EXTENDS: IKSolver
FIELDS:
  private           UnityEngine.Animator            <animator>k__BackingField  // 0x58
  private           UnityEngine.Transform[]         solverTransforms  // 0x60
  private           System.Boolean                  hasChest  // 0x68
  private           System.Boolean                  hasNeck  // 0x69
  private           System.Boolean                  hasShoulders  // 0x6A
  private           System.Boolean                  hasToes  // 0x6B
  private           System.Boolean                  hasLegs  // 0x6C
  private           System.Boolean                  hasArms  // 0x6D
  private           UnityEngine.Vector3[]           readPositions  // 0x70
  private           UnityEngine.Quaternion[]        readRotations  // 0x78
  private           UnityEngine.Vector3[]           solvedPositions  // 0x80
  private           UnityEngine.Quaternion[]        solvedRotations  // 0x88
  private           UnityEngine.Quaternion[]        defaultLocalRotations  // 0x90
  private           UnityEngine.Vector3[]           defaultLocalPositions  // 0x98
  private           UnityEngine.Vector3             rootV  // 0xA0
  private           UnityEngine.Vector3             rootVelocity  // 0xAC
  private           UnityEngine.Vector3             bodyOffset  // 0xB8
  private           System.Int32                    supportLegIndex  // 0xC4
  private           System.Int32                    lastLOD  // 0xC8
  private           System.Single                   lastLocomotionWeight  // 0xCC
  public            System.Int32                    LOD  // 0xD0
  public            System.Single                   scale  // 0xD4
  public            System.Boolean                  plantFeet  // 0xD8
  private           RootMotion.FinalIK.IKSolverVR.VirtualBone<rootBone>k__BackingField  // 0xE0
  public            RootMotion.FinalIK.IKSolverVR.Spinespine  // 0xE8
  public            RootMotion.FinalIK.IKSolverVR.ArmleftArm  // 0xF0
  public            RootMotion.FinalIK.IKSolverVR.ArmrightArm  // 0xF8
  public            RootMotion.FinalIK.IKSolverVR.LegleftLeg  // 0x100
  public            RootMotion.FinalIK.IKSolverVR.LegrightLeg  // 0x108
  public            RootMotion.FinalIK.IKSolverVR.Locomotionlocomotion  // 0x110
  private           RootMotion.FinalIK.IKSolverVR.Leg[]legs  // 0x118
  private           RootMotion.FinalIK.IKSolverVR.Arm[]arms  // 0x120
  private           UnityEngine.Vector3             headPosition  // 0x128
  private           UnityEngine.Vector3             headDeltaPosition  // 0x134
  private           UnityEngine.Vector3             raycastOriginPelvis  // 0x140
  private           UnityEngine.Vector3             lastOffset  // 0x14C
  private           UnityEngine.Vector3             debugPos1  // 0x158
  private           UnityEngine.Vector3             debugPos2  // 0x164
  private           UnityEngine.Vector3             debugPos3  // 0x170
  private           UnityEngine.Vector3             debugPos4  // 0x17C
METHODS:
  UnityEngine.Animator get_animator()
  System.Void set_animator(UnityEngine.Animator value)
  System.Void SetToReferences(RootMotion.FinalIK.VRIK.References references)
  System.Void GuessHandOrientations(RootMotion.FinalIK.VRIK.References references, System.Boolean onlyIfZero)
  System.Void DefaultAnimationCurves()
  System.Void AddPositionOffset(RootMotion.FinalIK.IKSolverVR.PositionOffset positionOffset, UnityEngine.Vector3 value)
  System.Void AddRotationOffset(RootMotion.FinalIK.IKSolverVR.RotationOffset rotationOffset, UnityEngine.Vector3 value)
  System.Void AddRotationOffset(RootMotion.FinalIK.IKSolverVR.RotationOffset rotationOffset, UnityEngine.Quaternion value)
  System.Void AddPlatformMotion(UnityEngine.Vector3 deltaPosition, UnityEngine.Quaternion deltaRotation, UnityEngine.Vector3 platformPivot)
  System.Void Reset()
  System.Void StoreDefaultLocalState()
  System.Void FixTransforms()
  RootMotion.FinalIK.IKSolver.Point[] GetPoints()
  RootMotion.FinalIK.IKSolver.Point GetPoint(UnityEngine.Transform transform)
  System.Boolean IsValid(System.String& message)
  UnityEngine.Vector3 GetNormal(UnityEngine.Transform[] transforms)
  UnityEngine.Keyframe[] GetSineKeyframes(System.Single mag)
  System.Void UpdateSolverTransforms()
  System.Void OnInitiate()
  System.Void OnUpdate()
  System.Void WriteTransforms()
  System.Void Read(UnityEngine.Vector3[] positions, UnityEngine.Quaternion[] rotations, System.Boolean hasChest, System.Boolean hasNeck, System.Boolean hasShoulders, System.Boolean hasToes, System.Boolean hasLegs, System.Boolean hasArms)
  System.Void Solve()
  UnityEngine.Vector3 GetPosition(System.Int32 index)
  UnityEngine.Quaternion GetRotation(System.Int32 index)
  RootMotion.FinalIK.IKSolverVR.VirtualBone get_rootBone()
  System.Void set_rootBone(RootMotion.FinalIK.IKSolverVR.VirtualBone value)
  System.Void Write()
  UnityEngine.Vector3 GetPelvisOffset(System.Single deltaTime)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.TwistRelaxer
TYPE:  class
TOKEN: 0x200008C
EXTENDS: MonoBehaviour
FIELDS:
  public            RootMotion.FinalIK.IK           ik  // 0x18
  public            RootMotion.FinalIK.TwistSolver[]twistSolvers  // 0x20
METHODS:
  System.Void Start()
  System.Void Update()
  System.Void OnPostUpdate()
  System.Void LateUpdate()
  System.Void OnDestroy()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.TwistSolver
TYPE:  class
TOKEN: 0x200008D
FIELDS:
  public            UnityEngine.Transform           transform  // 0x10
  public            UnityEngine.Transform           parent  // 0x18
  public            UnityEngine.Transform[]         children  // 0x20
  public            System.Single                   weight  // 0x28
  public            System.Single                   parentChildCrossfade  // 0x2C
  public            System.Single                   twistAngleOffset  // 0x30
  private           UnityEngine.Vector3             twistAxis  // 0x34
  private           UnityEngine.Vector3             axis  // 0x40
  private           UnityEngine.Vector3             axisRelativeToParentDefault  // 0x4C
  private           UnityEngine.Vector3             axisRelativeToChildDefault  // 0x58
  private           UnityEngine.Quaternion[]        childRotations  // 0x68
  private           System.Boolean                  inititated  // 0x70
  private           UnityEngine.Quaternion          defaultLocalRotation  // 0x74
  private           UnityEngine.Quaternion[]        defaultChildLocalRotations  // 0x88
METHODS:
  System.Void .ctor()
  System.Void Initiate()
  System.Void FixTransforms()
  System.Void Relax()
END_CLASS

CLASS: RootMotion.FinalIK.InteractionEffector
TYPE:  class
TOKEN: 0x200008E
FIELDS:
  private           RootMotion.FinalIK.FullBodyBipedEffector<effectorType>k__BackingField  // 0x10
  private           System.Boolean                  <isPaused>k__BackingField  // 0x14
  private           RootMotion.FinalIK.InteractionObject<interactionObject>k__BackingField  // 0x18
  private           RootMotion.FinalIK.Poser        poser  // 0x20
  private           RootMotion.FinalIK.IKEffector   effector  // 0x28
  private           System.Single                   timer  // 0x30
  private           System.Single                   length  // 0x34
  private           System.Single                   weight  // 0x38
  private           System.Single                   fadeInSpeed  // 0x3C
  private           System.Single                   defaultPositionWeight  // 0x40
  private           System.Single                   defaultRotationWeight  // 0x44
  private           System.Single                   defaultPull  // 0x48
  private           System.Single                   defaultReach  // 0x4C
  private           System.Single                   defaultPush  // 0x50
  private           System.Single                   defaultPushParent  // 0x54
  private           System.Single                   defaultBendGoalWeight  // 0x58
  private           System.Single                   resetTimer  // 0x5C
  private           System.Boolean                  positionWeightUsed  // 0x60
  private           System.Boolean                  rotationWeightUsed  // 0x61
  private           System.Boolean                  pullUsed  // 0x62
  private           System.Boolean                  reachUsed  // 0x63
  private           System.Boolean                  pushUsed  // 0x64
  private           System.Boolean                  pushParentUsed  // 0x65
  private           System.Boolean                  bendGoalWeightUsed  // 0x66
  private           System.Boolean                  pickedUp  // 0x67
  private           System.Boolean                  defaults  // 0x68
  private           System.Boolean                  pickUpOnPostFBBIK  // 0x69
  private           UnityEngine.Vector3             pickUpPosition  // 0x6C
  private           UnityEngine.Vector3             pausePositionRelative  // 0x78
  private           UnityEngine.Quaternion          pickUpRotation  // 0x84
  private           UnityEngine.Quaternion          pauseRotationRelative  // 0x94
  private           RootMotion.FinalIK.InteractionTargetinteractionTarget  // 0xA8
  private           UnityEngine.Transform           target  // 0xB0
  private           System.Collections.Generic.List<System.Boolean>triggered  // 0xB8
  private           RootMotion.FinalIK.InteractionSysteminteractionSystem  // 0xC0
  private           System.Boolean                  started  // 0xC8
METHODS:
  RootMotion.FinalIK.FullBodyBipedEffector get_effectorType()
  System.Void set_effectorType(RootMotion.FinalIK.FullBodyBipedEffector value)
  System.Boolean get_isPaused()
  System.Void set_isPaused(System.Boolean value)
  RootMotion.FinalIK.InteractionObject get_interactionObject()
  System.Void set_interactionObject(RootMotion.FinalIK.InteractionObject value)
  System.Boolean get_inInteraction()
  System.Void .ctor(RootMotion.FinalIK.FullBodyBipedEffector effectorType)
  System.Void Initiate(RootMotion.FinalIK.InteractionSystem interactionSystem)
  System.Void StoreDefaults()
  System.Boolean ResetToDefaults(System.Single speed, System.Single deltaTime)
  System.Boolean Pause()
  System.Boolean Resume()
  System.Boolean Start(RootMotion.FinalIK.InteractionObject interactionObject, System.String tag, System.Single fadeInTime, System.Boolean interrupt)
  System.Boolean Start(RootMotion.FinalIK.InteractionObject interactionObject, RootMotion.FinalIK.InteractionTarget interactionTarget, System.Single fadeInTime, System.Boolean interrupt)
  System.Void Update(UnityEngine.Transform root, System.Single speed, System.Single deltaTime)
  System.Single get_progress()
  System.Void TriggerUntriggeredEvents(System.Boolean checkTime, System.Boolean& pickUp, System.Boolean& pause)
  System.Void PickUp(UnityEngine.Transform root)
  System.Boolean Stop()
  System.Void OnPostFBBIK()
END_CLASS

CLASS: RootMotion.FinalIK.InteractionLookAt
TYPE:  class
TOKEN: 0x200008F
FIELDS:
  public            RootMotion.FinalIK.LookAtIK     ik  // 0x10
  public            System.Single                   lerpSpeed  // 0x18
  public            System.Single                   weightSpeed  // 0x1C
  public            System.Boolean                  isPaused  // 0x20
  private           UnityEngine.Transform           lookAtTarget  // 0x28
  private           System.Single                   stopLookTime  // 0x30
  private           System.Single                   weight  // 0x34
  private           System.Boolean                  firstFBBIKSolve  // 0x38
METHODS:
  System.Void Look(UnityEngine.Transform target, System.Single time)
  System.Void OnFixTransforms()
  System.Void Update()
  System.Void SolveSpine()
  System.Void SolveHead()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.InteractionObject
TYPE:  class
TOKEN: 0x2000090
EXTENDS: MonoBehaviour
FIELDS:
  public            UnityEngine.Transform           otherLookAtTarget  // 0x18
  public            UnityEngine.Transform           otherTargetsRoot  // 0x20
  public            UnityEngine.Transform           positionOffsetSpace  // 0x28
  public            RootMotion.FinalIK.InteractionObject.WeightCurve[]weightCurves  // 0x30
  public            RootMotion.FinalIK.InteractionObject.Multiplier[]multipliers  // 0x38
  public            RootMotion.FinalIK.InteractionObject.InteractionEvent[]events  // 0x40
  private           System.Single                   <length>k__BackingField  // 0x48
  private           RootMotion.FinalIK.InteractionSystem<lastUsedInteractionSystem>k__BackingField  // 0x50
  private           RootMotion.FinalIK.InteractionTarget[]targets  // 0x58
METHODS:
  System.Void OpenUserManual()
  System.Void OpenScriptReference()
  System.Void OpenTutorial1()
  System.Void OpenTutorial2()
  System.Void OpenTutorial3()
  System.Void OpenTutorial4()
  System.Void SupportGroup()
  System.Void ASThread()
  System.Single get_length()
  System.Void set_length(System.Single value)
  RootMotion.FinalIK.InteractionSystem get_lastUsedInteractionSystem()
  System.Void set_lastUsedInteractionSystem(RootMotion.FinalIK.InteractionSystem value)
  System.Void Initiate()
  UnityEngine.Transform get_lookAtTarget()
  RootMotion.FinalIK.InteractionTarget GetTarget(RootMotion.FinalIK.FullBodyBipedEffector effectorType, RootMotion.FinalIK.InteractionSystem interactionSystem)
  System.Boolean CurveUsed(RootMotion.FinalIK.InteractionObject.WeightCurve.Type type)
  RootMotion.FinalIK.InteractionTarget[] GetTargets()
  UnityEngine.Transform GetTarget(RootMotion.FinalIK.FullBodyBipedEffector effectorType, System.String tag)
  System.Void OnStartInteraction(RootMotion.FinalIK.InteractionSystem interactionSystem)
  System.Void Apply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, RootMotion.FinalIK.FullBodyBipedEffector effector, RootMotion.FinalIK.InteractionTarget target, System.Single timer, System.Single weight)
  System.Single GetValue(RootMotion.FinalIK.InteractionObject.WeightCurve.Type weightCurveType, RootMotion.FinalIK.InteractionTarget target, System.Single timer)
  UnityEngine.Transform get_targetsRoot()
  System.Void Start()
  System.Void Apply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, RootMotion.FinalIK.FullBodyBipedEffector effector, RootMotion.FinalIK.InteractionObject.WeightCurve.Type type, System.Single value, System.Single weight)
  UnityEngine.Transform GetTarget(RootMotion.FinalIK.FullBodyBipedEffector effectorType)
  System.Int32 GetWeightCurveIndex(RootMotion.FinalIK.InteractionObject.WeightCurve.Type weightCurveType)
  System.Int32 GetMultiplierIndex(RootMotion.FinalIK.InteractionObject.WeightCurve.Type weightCurveType)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.InteractionSystem
TYPE:  class
TOKEN: 0x2000097
EXTENDS: MonoBehaviour
FIELDS:
  public            System.String                   targetTag  // 0x18
  public            System.Single                   fadeInTime  // 0x20
  public            System.Single                   speed  // 0x24
  public            System.Single                   resetToDefaultsSpeed  // 0x28
  public            UnityEngine.Collider            characterCollider  // 0x30
  public            UnityEngine.Transform           FPSCamera  // 0x38
  public            UnityEngine.LayerMask           camRaycastLayers  // 0x40
  public            System.Single                   camRaycastDistance  // 0x44
  private           System.Collections.Generic.List<RootMotion.FinalIK.InteractionTrigger><triggersInRange>k__BackingField  // 0x48
  private           System.Collections.Generic.List<RootMotion.FinalIK.InteractionTrigger>inContact  // 0x50
  private           System.Collections.Generic.List<System.Int32>bestRangeIndexes  // 0x58
  public            RootMotion.FinalIK.InteractionSystem.InteractionDelegateOnInteractionStart  // 0x60
  public            RootMotion.FinalIK.InteractionSystem.InteractionDelegateOnInteractionPause  // 0x68
  public            RootMotion.FinalIK.InteractionSystem.InteractionDelegateOnInteractionPickUp  // 0x70
  public            RootMotion.FinalIK.InteractionSystem.InteractionDelegateOnInteractionResume  // 0x78
  public            RootMotion.FinalIK.InteractionSystem.InteractionDelegateOnInteractionStop  // 0x80
  public            RootMotion.FinalIK.InteractionSystem.InteractionEventDelegateOnInteractionEvent  // 0x88
  public            UnityEngine.RaycastHit          raycastHit  // 0x90
  private           RootMotion.FinalIK.FullBodyBipedIKfullBody  // 0xD0
  public            RootMotion.FinalIK.InteractionLookAtlookAt  // 0xD8
  private           RootMotion.FinalIK.InteractionEffector[]interactionEffectors  // 0xE0
  private           System.Boolean                  <initiated>k__BackingField  // 0xE8
  private           UnityEngine.Collider            lastCollider  // 0xF0
  private           UnityEngine.Collider            c  // 0xF8
  private           System.Single                   lastTime  // 0x100
METHODS:
  System.Void OpenUserManual()
  System.Void OpenScriptReference()
  System.Void OpenTutorial1()
  System.Void OpenTutorial2()
  System.Void OpenTutorial3()
  System.Void OpenTutorial4()
  System.Void SupportGroup()
  System.Void ASThread()
  System.Boolean get_inInteraction()
  System.Boolean IsInInteraction(RootMotion.FinalIK.FullBodyBipedEffector effectorType)
  System.Boolean IsPaused(RootMotion.FinalIK.FullBodyBipedEffector effectorType)
  System.Boolean IsPaused()
  System.Boolean IsInSync()
  System.Boolean StartInteraction(RootMotion.FinalIK.FullBodyBipedEffector effectorType, RootMotion.FinalIK.InteractionObject interactionObject, System.Boolean interrupt)
  System.Boolean StartInteraction(RootMotion.FinalIK.FullBodyBipedEffector effectorType, RootMotion.FinalIK.InteractionObject interactionObject, RootMotion.FinalIK.InteractionTarget target, System.Boolean interrupt)
  System.Boolean PauseInteraction(RootMotion.FinalIK.FullBodyBipedEffector effectorType)
  System.Boolean ResumeInteraction(RootMotion.FinalIK.FullBodyBipedEffector effectorType)
  System.Boolean StopInteraction(RootMotion.FinalIK.FullBodyBipedEffector effectorType)
  System.Void PauseAll()
  System.Void ResumeAll()
  System.Void StopAll()
  RootMotion.FinalIK.InteractionObject GetInteractionObject(RootMotion.FinalIK.FullBodyBipedEffector effectorType)
  System.Single GetProgress(RootMotion.FinalIK.FullBodyBipedEffector effectorType)
  System.Single GetMinActiveProgress()
  System.Boolean TriggerInteraction(System.Int32 index, System.Boolean interrupt)
  System.Boolean TriggerInteraction(System.Int32 index, System.Boolean interrupt, RootMotion.FinalIK.InteractionObject& interactionObject)
  System.Boolean TriggerInteraction(System.Int32 index, System.Boolean interrupt, RootMotion.FinalIK.InteractionTarget& interactionTarget)
  RootMotion.FinalIK.InteractionTrigger.Range GetClosestInteractionRange()
  RootMotion.FinalIK.InteractionObject GetClosestInteractionObjectInRange()
  RootMotion.FinalIK.InteractionTarget GetClosestInteractionTargetInRange()
  RootMotion.FinalIK.InteractionObject[] GetClosestInteractionObjectsInRange()
  RootMotion.FinalIK.InteractionTarget[] GetClosestInteractionTargetsInRange()
  System.Boolean TriggerEffectorsReady(System.Int32 index)
  RootMotion.FinalIK.InteractionTrigger.Range GetTriggerRange(System.Int32 index)
  System.Int32 GetClosestTriggerIndex()
  RootMotion.FinalIK.FullBodyBipedIK get_ik()
  System.Void set_ik(RootMotion.FinalIK.FullBodyBipedIK value)
  System.Collections.Generic.List<RootMotion.FinalIK.InteractionTrigger> get_triggersInRange()
  System.Void set_triggersInRange(System.Collections.Generic.List<RootMotion.FinalIK.InteractionTrigger> value)
  System.Boolean get_initiated()
  System.Void set_initiated(System.Boolean value)
  System.Void Start()
  System.Void InteractionPause(RootMotion.FinalIK.FullBodyBipedEffector effector, RootMotion.FinalIK.InteractionObject interactionObject)
  System.Void InteractionResume(RootMotion.FinalIK.FullBodyBipedEffector effector, RootMotion.FinalIK.InteractionObject interactionObject)
  System.Void InteractionStop(RootMotion.FinalIK.FullBodyBipedEffector effector, RootMotion.FinalIK.InteractionObject interactionObject)
  System.Void LookAtInteraction(RootMotion.FinalIK.FullBodyBipedEffector effector, RootMotion.FinalIK.InteractionObject interactionObject)
  System.Void OnTriggerEnter(UnityEngine.Collider c)
  System.Void OnTriggerExit(UnityEngine.Collider c)
  System.Boolean ContactIsInRange(System.Int32 index, System.Int32& bestRangeIndex)
  System.Void OnDrawGizmosSelected()
  System.Void Update()
  System.Void Raycasting()
  System.Void UpdateTriggerEventBroadcasting()
  System.Void OnEnable()
  System.Void UpdateEffectors()
  System.Void OnPreFBBIK()
  System.Void OnPostFBBIK()
  System.Void OnFixTransforms()
  System.Void OnDestroy()
  System.Boolean IsValid(System.Boolean log)
  System.Boolean TriggerIndexIsValid(System.Int32 index)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.InteractionTarget
TYPE:  class
TOKEN: 0x200009A
EXTENDS: MonoBehaviour
FIELDS:
  public            RootMotion.FinalIK.FullBodyBipedEffectoreffectorType  // 0x18
  public            RootMotion.FinalIK.InteractionTarget.Multiplier[]multipliers  // 0x20
  public            System.Single                   interactionSpeedMlp  // 0x28
  public            UnityEngine.Transform           pivot  // 0x30
  public            RootMotion.FinalIK.InteractionTarget.RotationModerotationMode  // 0x38
  public            UnityEngine.Vector3             twistAxis  // 0x3C
  public            System.Single                   twistWeight  // 0x48
  public            System.Single                   swingWeight  // 0x4C
  public            System.Single                   threeDOFWeight  // 0x50
  public            System.Boolean                  rotateOnce  // 0x54
  private           UnityEngine.Quaternion          defaultLocalRotation  // 0x58
  private           UnityEngine.Transform           lastPivot  // 0x68
METHODS:
  System.Void OpenUserManual()
  System.Void OpenScriptReference()
  System.Void OpenTutorial1()
  System.Void OpenTutorial2()
  System.Void OpenTutorial3()
  System.Void OpenTutorial4()
  System.Void SupportGroup()
  System.Void ASThread()
  System.Single GetValue(RootMotion.FinalIK.InteractionObject.WeightCurve.Type curveType)
  System.Void ResetRotation()
  System.Void RotateTo(UnityEngine.Transform bone)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.InteractionTrigger
TYPE:  class
TOKEN: 0x200009D
EXTENDS: MonoBehaviour
FIELDS:
  public            RootMotion.FinalIK.InteractionTrigger.Range[]ranges  // 0x18
METHODS:
  System.Void OpenUserManual()
  System.Void OpenScriptReference()
  System.Void OpenTutorial4()
  System.Void SupportGroup()
  System.Void ASThread()
  System.Int32 GetBestRangeIndex(UnityEngine.Transform character, UnityEngine.Transform raycastFrom, UnityEngine.RaycastHit raycastHit)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.GenericPoser
TYPE:  class
TOKEN: 0x20000A2
EXTENDS: Poser
FIELDS:
  public            RootMotion.FinalIK.GenericPoser.Map[]maps  // 0x50
METHODS:
  System.Void AutoMapping()
  System.Void InitiatePoser()
  System.Void UpdatePoser()
  System.Void FixPoserTransforms()
  System.Void StoreDefaultState()
  UnityEngine.Transform GetTargetNamed(System.String tName, UnityEngine.Transform[] array)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.HandPoser
TYPE:  class
TOKEN: 0x20000A4
EXTENDS: Poser
FIELDS:
  protected         UnityEngine.Transform[]         children  // 0x50
  private           UnityEngine.Transform           _poseRoot  // 0x58
  private           UnityEngine.Transform[]         poseChildren  // 0x60
  private           UnityEngine.Vector3[]           defaultLocalPositions  // 0x68
  private           UnityEngine.Quaternion[]        defaultLocalRotations  // 0x70
METHODS:
  System.Void AutoMapping()
  System.Void InitiatePoser()
  System.Void FixPoserTransforms()
  System.Void UpdatePoser()
  System.Void StoreDefaultState()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.Poser
TYPE:  class
TOKEN: 0x20000A5
EXTENDS: SolverManager
FIELDS:
  public            UnityEngine.Transform           poseRoot  // 0x38
  public            System.Single                   weight  // 0x40
  public            System.Single                   localRotationWeight  // 0x44
  public            System.Single                   localPositionWeight  // 0x48
  private           System.Boolean                  initiated  // 0x4C
METHODS:
  System.Void AutoMapping()
  System.Void UpdateManual()
  System.Void InitiatePoser()
  System.Void UpdatePoser()
  System.Void FixPoserTransforms()
  System.Void UpdateSolver()
  System.Void InitiateSolver()
  System.Void FixTransforms()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.RagdollUtility
TYPE:  class
TOKEN: 0x20000A6
EXTENDS: MonoBehaviour
FIELDS:
  public            RootMotion.FinalIK.IK           ik  // 0x18
  public            System.Single                   ragdollToAnimationTime  // 0x20
  public            System.Boolean                  applyIkOnRagdoll  // 0x24
  public            System.Single                   applyVelocity  // 0x28
  public            System.Single                   applyAngularVelocity  // 0x2C
  private           UnityEngine.Animator            animator  // 0x30
  private           RootMotion.FinalIK.RagdollUtility.Rigidbone[]rigidbones  // 0x38
  private           RootMotion.FinalIK.RagdollUtility.Child[]children  // 0x40
  private           System.Boolean                  enableRagdollFlag  // 0x48
  private           UnityEngine.AnimatorUpdateMode  animatorUpdateMode  // 0x4C
  private           RootMotion.FinalIK.IK[]         allIKComponents  // 0x50
  private           System.Boolean[]                fixTransforms  // 0x58
  private           System.Single                   ragdollWeight  // 0x60
  private           System.Single                   ragdollWeightV  // 0x64
  private           System.Boolean                  fixedFrame  // 0x68
  private           System.Boolean[]                disabledIKComponents  // 0x70
METHODS:
  System.Void EnableRagdoll()
  System.Void DisableRagdoll()
  System.Void Start()
  System.Collections.IEnumerator DisableRagdollSmooth()
  System.Void Update()
  System.Void FixedUpdate()
  System.Void LateUpdate()
  System.Void AfterLastIK()
  System.Void AfterAnimation()
  System.Void OnFinalPose()
  System.Void RagdollEnabler()
  System.Boolean get_isRagdoll()
  System.Void RecordVelocities()
  System.Boolean get_ikUsed()
  System.Void StoreLocalState()
  System.Void FixTransforms(System.Single weight)
  System.Void OnDestroy()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.RotationLimit
TYPE:  class
TOKEN: 0x20000AA
EXTENDS: MonoBehaviour
FIELDS:
  public            UnityEngine.Vector3             axis  // 0x18
  public            UnityEngine.Quaternion          defaultLocalRotation  // 0x24
  private           System.Boolean                  <defaultLocalRotationOverride>k__BackingField  // 0x34
  private           System.Boolean                  initiated  // 0x35
  private           System.Boolean                  applicationQuit  // 0x36
  private           System.Boolean                  defaultLocalRotationSet  // 0x37
METHODS:
  System.Void SetDefaultLocalRotation()
  System.Void SetDefaultLocalRotation(UnityEngine.Quaternion localRotation)
  UnityEngine.Quaternion GetLimitedLocalRotation(UnityEngine.Quaternion localRotation, System.Boolean& changed)
  System.Boolean Apply()
  System.Void Disable()
  UnityEngine.Vector3 get_secondaryAxis()
  UnityEngine.Vector3 get_crossAxis()
  System.Boolean get_defaultLocalRotationOverride()
  System.Void set_defaultLocalRotationOverride(System.Boolean value)
  UnityEngine.Quaternion LimitRotation(UnityEngine.Quaternion rotation)
  System.Void Awake()
  System.Void LateUpdate()
  System.Void LogWarning(System.String message)
  UnityEngine.Quaternion Limit1DOF(UnityEngine.Quaternion rotation, UnityEngine.Vector3 axis)
  UnityEngine.Quaternion LimitTwist(UnityEngine.Quaternion rotation, UnityEngine.Vector3 axis, UnityEngine.Vector3 orthoAxis, System.Single twistLimit)
  System.Single GetOrthogonalAngle(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, UnityEngine.Vector3 normal)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.RotationLimitAngle
TYPE:  class
TOKEN: 0x20000AB
EXTENDS: RotationLimit
FIELDS:
  public            System.Single                   limit  // 0x38
  public            System.Single                   twistLimit  // 0x3C
METHODS:
  System.Void OpenUserManual()
  System.Void OpenScriptReference()
  System.Void SupportGroup()
  System.Void ASThread()
  UnityEngine.Quaternion LimitRotation(UnityEngine.Quaternion rotation)
  UnityEngine.Quaternion LimitSwing(UnityEngine.Quaternion rotation)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.RotationLimitHinge
TYPE:  class
TOKEN: 0x20000AC
EXTENDS: RotationLimit
FIELDS:
  public            System.Boolean                  useLimits  // 0x38
  public            System.Single                   min  // 0x3C
  public            System.Single                   max  // 0x40
  public            System.Single                   zeroAxisDisplayOffset  // 0x44
  private           System.Single                   lastAngle  // 0x48
METHODS:
  System.Void OpenUserManual()
  System.Void OpenScriptReference()
  System.Void SupportGroup()
  System.Void ASThread()
  UnityEngine.Quaternion LimitRotation(UnityEngine.Quaternion rotation)
  UnityEngine.Quaternion LimitHinge(UnityEngine.Quaternion rotation)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.RotationLimitPolygonal
TYPE:  class
TOKEN: 0x20000AD
EXTENDS: RotationLimit
FIELDS:
  public            System.Single                   twistLimit  // 0x38
  public            System.Int32                    smoothIterations  // 0x3C
  public            RootMotion.FinalIK.RotationLimitPolygonal.LimitPoint[]points  // 0x40
  public            UnityEngine.Vector3[]           P  // 0x48
  public            RootMotion.FinalIK.RotationLimitPolygonal.ReachCone[]reachCones  // 0x50
METHODS:
  System.Void OpenUserManual()
  System.Void OpenScriptReference()
  System.Void SupportGroup()
  System.Void ASThread()
  System.Void SetLimitPoints(RootMotion.FinalIK.RotationLimitPolygonal.LimitPoint[] points)
  UnityEngine.Quaternion LimitRotation(UnityEngine.Quaternion rotation)
  System.Void Start()
  System.Void ResetToDefault()
  System.Void BuildReachCones()
  UnityEngine.Vector3[] SmoothPoints()
  System.Single GetScalar(System.Int32 k)
  UnityEngine.Vector3 PointToTangentPlane(UnityEngine.Vector3 p, System.Single r)
  UnityEngine.Vector3 TangentPointToSphere(UnityEngine.Vector3 q, System.Single r)
  UnityEngine.Quaternion LimitSwing(UnityEngine.Quaternion rotation)
  System.Int32 GetReachCone(UnityEngine.Vector3 L)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.RotationLimitSpline
TYPE:  class
TOKEN: 0x20000B0
EXTENDS: RotationLimit
FIELDS:
  public            System.Single                   twistLimit  // 0x38
  public            UnityEngine.AnimationCurve      spline  // 0x40
METHODS:
  System.Void OpenUserManual()
  System.Void OpenScriptReference()
  System.Void SupportGroup()
  System.Void ASThread()
  System.Void SetSpline(UnityEngine.Keyframe[] keyframes)
  UnityEngine.Quaternion LimitRotation(UnityEngine.Quaternion rotation)
  UnityEngine.Quaternion LimitSwing(UnityEngine.Quaternion rotation)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.AimController
TYPE:  class
TOKEN: 0x20000B1
EXTENDS: MonoBehaviour
FIELDS:
  public            RootMotion.FinalIK.AimIK        ik  // 0x18
  public            System.Single                   weight  // 0x20
  public            UnityEngine.Transform           target  // 0x28
  public            System.Single                   targetSwitchSmoothTime  // 0x30
  public            System.Single                   weightSmoothTime  // 0x34
  public            System.Boolean                  smoothTurnTowardsTarget  // 0x38
  public            System.Single                   maxRadiansDelta  // 0x3C
  public            System.Single                   maxMagnitudeDelta  // 0x40
  public            System.Single                   slerpSpeed  // 0x44
  public            System.Single                   smoothDampTime  // 0x48
  public            UnityEngine.Vector3             pivotOffsetFromRoot  // 0x4C
  public            System.Single                   minDistance  // 0x58
  public            UnityEngine.Vector3             offset  // 0x5C
  public            System.Single                   maxRootAngle  // 0x68
  public            System.Boolean                  turnToTarget  // 0x6C
  public            System.Single                   turnToTargetTime  // 0x70
  public            System.Boolean                  useAnimatedAimDirection  // 0x74
  public            UnityEngine.Vector3             animatedAimDirection  // 0x78
  private           UnityEngine.Transform           lastTarget  // 0x88
  private           System.Single                   switchWeight  // 0x90
  private           System.Single                   switchWeightV  // 0x94
  private           System.Single                   weightV  // 0x98
  private           UnityEngine.Vector3             lastPosition  // 0x9C
  private           UnityEngine.Vector3             dir  // 0xA8
  private           System.Boolean                  lastSmoothTowardsTarget  // 0xB4
  private           System.Boolean                  turningToTarget  // 0xB5
  private           System.Single                   turnToTargetMlp  // 0xB8
  private           System.Single                   turnToTargetMlpV  // 0xBC
  private           System.Single                   yawV  // 0xC0
  private           System.Single                   pitchV  // 0xC4
  private           System.Single                   dirMagV  // 0xC8
METHODS:
  System.Void Start()
  System.Void LateUpdate()
  UnityEngine.Vector3 get_pivot()
  System.Void ApplyMinDistance()
  System.Void RootRotation()
  System.Collections.IEnumerator TurnToTarget()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.AimPoser
TYPE:  class
TOKEN: 0x20000B3
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Single                   angleBuffer  // 0x18
  public            RootMotion.FinalIK.AimPoser.Pose[]poses  // 0x20
METHODS:
  RootMotion.FinalIK.AimPoser.Pose GetPose(UnityEngine.Vector3 localDirection)
  System.Void SetPoseActive(RootMotion.FinalIK.AimPoser.Pose pose)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.Amplifier
TYPE:  class
TOKEN: 0x20000B5
EXTENDS: OffsetModifier
FIELDS:
  public            RootMotion.FinalIK.Amplifier.Body[]bodies  // 0x30
METHODS:
  System.Void OnModifyOffset()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.BodyTilt
TYPE:  class
TOKEN: 0x20000B8
EXTENDS: OffsetModifier
FIELDS:
  public            System.Single                   tiltSpeed  // 0x30
  public            System.Single                   tiltSensitivity  // 0x34
  public            RootMotion.FinalIK.OffsetPose   poseLeft  // 0x38
  public            RootMotion.FinalIK.OffsetPose   poseRight  // 0x40
  private           System.Single                   tiltAngle  // 0x48
  private           UnityEngine.Vector3             lastForward  // 0x4C
METHODS:
  System.Void Start()
  System.Void OnModifyOffset()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.CCDBendGoal
TYPE:  class
TOKEN: 0x20000B9
EXTENDS: MonoBehaviour
FIELDS:
  public            RootMotion.FinalIK.CCDIK        ik  // 0x18
  public            System.Single                   weight  // 0x20
METHODS:
  System.Void Start()
  System.Void BeforeIK()
  System.Void OnDestroy()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.EditorIK
TYPE:  class
TOKEN: 0x20000BA
EXTENDS: MonoBehaviour
FIELDS:
  public            UnityEngine.Animator            animator  // 0x18
  public            RootMotion.FinalIK.EditorIKPose defaultPose  // 0x20
  public            UnityEngine.Transform[]         bones  // 0x28
  private           RootMotion.FinalIK.IK           <ik>k__BackingField  // 0x30
METHODS:
  RootMotion.FinalIK.IK get_ik()
  System.Void set_ik(RootMotion.FinalIK.IK value)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void StoreDefaultPose()
  System.Boolean Initiate()
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.EditorIKPose
TYPE:  class
TOKEN: 0x20000BB
EXTENDS: ScriptableObject
FIELDS:
  public            UnityEngine.Vector3[]           localPositions  // 0x18
  public            UnityEngine.Quaternion[]        localRotations  // 0x20
METHODS:
  System.Boolean get_poseStored()
  System.Void Store(UnityEngine.Transform[] T)
  System.Boolean Restore(UnityEngine.Transform[] T)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.HitReaction
TYPE:  class
TOKEN: 0x20000BC
EXTENDS: OffsetModifier
FIELDS:
  public            RootMotion.FinalIK.HitReaction.HitPointEffector[]effectorHitPoints  // 0x30
  public            RootMotion.FinalIK.HitReaction.HitPointBone[]boneHitPoints  // 0x38
METHODS:
  System.Boolean get_inProgress()
  System.Void OnModifyOffset()
  System.Void Hit(UnityEngine.Collider collider, UnityEngine.Vector3 force, UnityEngine.Vector3 point)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.HitReactionVRIK
TYPE:  class
TOKEN: 0x20000C2
EXTENDS: OffsetModifierVRIK
FIELDS:
  public            UnityEngine.AnimationCurve[]    offsetCurves  // 0x30
  public            RootMotion.FinalIK.HitReactionVRIK.PositionOffset[]positionOffsets  // 0x38
  public            RootMotion.FinalIK.HitReactionVRIK.RotationOffset[]rotationOffsets  // 0x40
METHODS:
  System.Void OnModifyOffset()
  System.Void Hit(UnityEngine.Collider collider, UnityEngine.Vector3 force, UnityEngine.Vector3 point)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.Inertia
TYPE:  class
TOKEN: 0x20000C8
EXTENDS: OffsetModifier
FIELDS:
  public            RootMotion.FinalIK.Inertia.Body[]bodies  // 0x30
  public            RootMotion.FinalIK.OffsetModifier.OffsetLimits[]limits  // 0x38
METHODS:
  System.Void ResetBodies()
  System.Void OnModifyOffset()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.LookAtController
TYPE:  class
TOKEN: 0x20000CB
EXTENDS: MonoBehaviour
FIELDS:
  public            RootMotion.FinalIK.LookAtIK     ik  // 0x18
  public            UnityEngine.Transform           target  // 0x20
  public            System.Single                   weight  // 0x28
  public            UnityEngine.Vector3             offset  // 0x2C
  public            System.Single                   targetSwitchSmoothTime  // 0x38
  public            System.Single                   weightSmoothTime  // 0x3C
  public            System.Boolean                  smoothTurnTowardsTarget  // 0x40
  public            System.Single                   maxRadiansDelta  // 0x44
  public            System.Single                   maxMagnitudeDelta  // 0x48
  public            System.Single                   slerpSpeed  // 0x4C
  public            UnityEngine.Vector3             pivotOffsetFromRoot  // 0x50
  public            System.Single                   minDistance  // 0x5C
  public            System.Single                   maxRootAngle  // 0x60
  private           UnityEngine.Transform           lastTarget  // 0x68
  private           System.Single                   switchWeight  // 0x70
  private           System.Single                   switchWeightV  // 0x74
  private           System.Single                   weightV  // 0x78
  private           UnityEngine.Vector3             lastPosition  // 0x7C
  private           UnityEngine.Vector3             dir  // 0x88
  private           System.Boolean                  lastSmoothTowardsTarget  // 0x94
METHODS:
  System.Void Start()
  System.Void LateUpdate()
  UnityEngine.Vector3 get_pivot()
  System.Void ApplyMinDistance()
  System.Void RootRotation()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.OffsetModifier
TYPE:  class
TOKEN: 0x20000CC
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Single                   weight  // 0x18
  public            RootMotion.FinalIK.FullBodyBipedIKik  // 0x20
  protected         System.Single                   lastTime  // 0x28
METHODS:
  System.Single get_deltaTime()
  System.Void OnModifyOffset()
  System.Void Start()
  System.Collections.IEnumerator Initiate()
  System.Void ModifyOffset()
  System.Void ApplyLimits(RootMotion.FinalIK.OffsetModifier.OffsetLimits[] limits)
  System.Void OnDestroy()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.OffsetModifierVRIK
TYPE:  class
TOKEN: 0x20000CF
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Single                   weight  // 0x18
  public            RootMotion.FinalIK.VRIK         ik  // 0x20
  private           System.Single                   lastTime  // 0x28
METHODS:
  System.Single get_deltaTime()
  System.Void OnModifyOffset()
  System.Void Start()
  System.Collections.IEnumerator Initiate()
  System.Void ModifyOffset()
  System.Void OnDestroy()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.OffsetPose
TYPE:  class
TOKEN: 0x20000D1
EXTENDS: MonoBehaviour
FIELDS:
  public            RootMotion.FinalIK.OffsetPose.EffectorLink[]effectorLinks  // 0x18
METHODS:
  System.Void Apply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, System.Single weight)
  System.Void Apply(RootMotion.FinalIK.IKSolverFullBodyBiped solver, System.Single weight, UnityEngine.Quaternion rotation)
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.PenetrationAvoidance
TYPE:  class
TOKEN: 0x20000D3
EXTENDS: OffsetModifier
FIELDS:
  public            RootMotion.FinalIK.PenetrationAvoidance.Avoider[]avoiders  // 0x30
METHODS:
  System.Void OnModifyOffset()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.Recoil
TYPE:  class
TOKEN: 0x20000D6
EXTENDS: OffsetModifier
FIELDS:
  public            RootMotion.FinalIK.AimIK        aimIK  // 0x30
  public            RootMotion.FinalIK.AimIK        headIK  // 0x38
  public            System.Boolean                  aimIKSolvedLast  // 0x40
  public            RootMotion.FinalIK.Recoil.Handednesshandedness  // 0x44
  public            System.Boolean                  twoHanded  // 0x48
  public            UnityEngine.AnimationCurve      recoilWeight  // 0x50
  public            System.Single                   magnitudeRandom  // 0x58
  public            UnityEngine.Vector3             rotationRandom  // 0x5C
  public            UnityEngine.Vector3             handRotationOffset  // 0x68
  public            System.Single                   blendTime  // 0x74
  public            RootMotion.FinalIK.Recoil.RecoilOffset[]offsets  // 0x78
  public            UnityEngine.Quaternion          rotationOffset  // 0x80
  private           System.Single                   magnitudeMlp  // 0x90
  private           System.Single                   endTime  // 0x94
  private           UnityEngine.Quaternion          handRotation  // 0x98
  private           UnityEngine.Quaternion          secondaryHandRelativeRotation  // 0xA8
  private           UnityEngine.Quaternion          randomRotation  // 0xB8
  private           System.Single                   length  // 0xC8
  private           System.Boolean                  initiated  // 0xCC
  private           System.Single                   blendWeight  // 0xD0
  private           System.Single                   w  // 0xD4
  private           UnityEngine.Quaternion          primaryHandRotation  // 0xD8
  private           System.Boolean                  handRotationsSet  // 0xE8
  private           UnityEngine.Vector3             aimIKAxis  // 0xEC
METHODS:
  System.Boolean get_isFinished()
  System.Void SetHandRotations(UnityEngine.Quaternion leftHandRotation, UnityEngine.Quaternion rightHandRotation)
  System.Void Fire(System.Single magnitude)
  System.Void OnModifyOffset()
  System.Void AfterFBBIK()
  System.Void AfterAimIK()
  RootMotion.FinalIK.IKEffector get_primaryHandEffector()
  RootMotion.FinalIK.IKEffector get_secondaryHandEffector()
  UnityEngine.Transform get_primaryHand()
  UnityEngine.Transform get_secondaryHand()
  System.Void OnDestroy()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.ShoulderRotator
TYPE:  class
TOKEN: 0x20000DA
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Single                   weight  // 0x18
  public            System.Single                   offset  // 0x1C
  private           RootMotion.FinalIK.FullBodyBipedIKik  // 0x20
  private           System.Boolean                  skip  // 0x28
METHODS:
  System.Void Start()
  System.Void RotateShoulders()
  System.Void RotateShoulder(RootMotion.FinalIK.FullBodyBipedChain chain, System.Single weight, System.Single offset)
  RootMotion.FinalIK.IKMapping.BoneMap GetParentBoneMap(RootMotion.FinalIK.FullBodyBipedChain chain)
  System.Void OnDestroy()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.VRIKCalibrator
TYPE:  class
TOKEN: 0x20000DB
FIELDS:
METHODS:
  System.Void RecalibrateScale(RootMotion.FinalIK.VRIK ik, RootMotion.FinalIK.VRIKCalibrator.CalibrationData data, RootMotion.FinalIK.VRIKCalibrator.Settings settings)
  System.Void RecalibrateScale(RootMotion.FinalIK.VRIK ik, RootMotion.FinalIK.VRIKCalibrator.CalibrationData data, System.Single scaleMlp)
  System.Void CalibrateScale(RootMotion.FinalIK.VRIK ik, RootMotion.FinalIK.VRIKCalibrator.Settings settings)
  System.Void CalibrateScale(RootMotion.FinalIK.VRIK ik, System.Single scaleMlp)
  RootMotion.FinalIK.VRIKCalibrator.CalibrationData Calibrate(RootMotion.FinalIK.VRIK ik, RootMotion.FinalIK.VRIKCalibrator.Settings settings, UnityEngine.Transform headTracker, UnityEngine.Transform bodyTracker, UnityEngine.Transform leftHandTracker, UnityEngine.Transform rightHandTracker, UnityEngine.Transform leftFootTracker, UnityEngine.Transform rightFootTracker)
  System.Void CalibrateLeg(RootMotion.FinalIK.VRIKCalibrator.Settings settings, UnityEngine.Transform tracker, RootMotion.FinalIK.IKSolverVR.Leg leg, UnityEngine.Transform lastBone, UnityEngine.Vector3 rootForward, System.Boolean isLeft)
  System.Void Calibrate(RootMotion.FinalIK.VRIK ik, RootMotion.FinalIK.VRIKCalibrator.CalibrationData data, UnityEngine.Transform headTracker, UnityEngine.Transform bodyTracker, UnityEngine.Transform leftHandTracker, UnityEngine.Transform rightHandTracker, UnityEngine.Transform leftFootTracker, UnityEngine.Transform rightFootTracker)
  System.Void CalibrateLeg(RootMotion.FinalIK.VRIKCalibrator.CalibrationData data, UnityEngine.Transform tracker, RootMotion.FinalIK.IKSolverVR.Leg leg, UnityEngine.Transform lastBone, UnityEngine.Vector3 rootForward, System.Boolean isLeft)
  RootMotion.FinalIK.VRIKCalibrator.CalibrationData Calibrate(RootMotion.FinalIK.VRIK ik, UnityEngine.Transform centerEyeAnchor, UnityEngine.Transform leftHandAnchor, UnityEngine.Transform rightHandAnchor, UnityEngine.Vector3 centerEyePositionOffset, UnityEngine.Vector3 centerEyeRotationOffset, UnityEngine.Vector3 handPositionOffset, UnityEngine.Vector3 handRotationOffset, System.Single scaleMlp)
  System.Void CalibrateHead(RootMotion.FinalIK.VRIK ik, UnityEngine.Transform centerEyeAnchor, UnityEngine.Vector3 anchorPositionOffset, UnityEngine.Vector3 anchorRotationOffset)
  System.Void CalibrateBody(RootMotion.FinalIK.VRIK ik, UnityEngine.Transform pelvisTracker, UnityEngine.Vector3 trackerPositionOffset, UnityEngine.Vector3 trackerRotationOffset)
  System.Void CalibrateHands(RootMotion.FinalIK.VRIK ik, UnityEngine.Transform leftHandAnchor, UnityEngine.Transform rightHandAnchor, UnityEngine.Vector3 anchorPositionOffset, UnityEngine.Vector3 anchorRotationOffset)
  System.Void CalibrateHand(RootMotion.FinalIK.VRIK ik, UnityEngine.Transform anchor, UnityEngine.Vector3 positionOffset, UnityEngine.Vector3 rotationOffset, System.Boolean isLeft)
  UnityEngine.Vector3 GuessWristToPalmAxis(UnityEngine.Transform hand, UnityEngine.Transform forearm)
  UnityEngine.Vector3 GuessPalmToThumbAxis(UnityEngine.Transform hand, UnityEngine.Transform forearm)
END_CLASS

CLASS: RootMotion.FinalIK.VRIKLODController
TYPE:  class
TOKEN: 0x20000DF
EXTENDS: MonoBehaviour
FIELDS:
  public            UnityEngine.Renderer            LODRenderer  // 0x18
  public            System.Single                   LODDistance  // 0x20
  public            System.Boolean                  allowCulled  // 0x24
  private           RootMotion.FinalIK.VRIK         ik  // 0x28
METHODS:
  System.Void Start()
  System.Void Update()
  System.Int32 GetLODLevel()
  System.Void .ctor()
END_CLASS

CLASS: RootMotion.FinalIK.VRIKRootController
TYPE:  class
TOKEN: 0x20000E0
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.Vector3             <pelvisTargetRight>k__BackingField  // 0x18
  private           UnityEngine.Transform           pelvisTarget  // 0x28
  private           UnityEngine.Transform           leftFootTarget  // 0x30
  private           UnityEngine.Transform           rightFootTarget  // 0x38
  private           RootMotion.FinalIK.VRIK         ik  // 0x40
METHODS:
  UnityEngine.Vector3 get_pelvisTargetRight()
  System.Void set_pelvisTargetRight(UnityEngine.Vector3 value)
  System.Void Awake()
  System.Void Calibrate()
  System.Void Calibrate(RootMotion.FinalIK.VRIKCalibrator.CalibrationData data)
  System.Void OnPreUpdate()
  System.Void OnDestroy()
  System.Void .ctor()
END_CLASS

