// ========================================================
// Dumped by @desirepro
// Assembly: AbilityUnsafe.Gameplay.Beyond.dll
// Classes:  14
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: KeyframeComparer
TYPE:  struct
TOKEN: 0x2000005
FIELDS:
METHODS:
  System.Int32 Compare(UnityEngine.Keyframe keyframe1, UnityEngine.Keyframe keyframe2)
END_CLASS

CLASS: ENPCUnionAnimationAbilityCommandType
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.NPC.Ability.FNPCUnionAnimationAbilityCommand.ENPCUnionAnimationAbilityCommandTypeDoAnimatorStepBegin  // 0x0
  public    static  Beyond.NPC.Ability.FNPCUnionAnimationAbilityCommand.ENPCUnionAnimationAbilityCommandTypeDoAnimatorStepEnd  // 0x0
METHODS:
END_CLASS

CLASS: DoAnimatorStepEndParams
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            System.Single                   stepEndDegree  // 0x10
METHODS:
END_CLASS

CLASS: DoAnimatorUpdateStepBeginDegreeParams
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  public            System.Single                   stepBeginDegree  // 0x10
METHODS:
END_CLASS

CLASS: Beyond.FPtrAnimNativeCurve
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  private           UnityEngine.Keyframe*           m_values  // 0x10
  private           System.Int32                    m_valuesLength  // 0x18
  private           UnityEngine.WrapMode            m_preWrapMode  // 0x1C
  private           UnityEngine.WrapMode            m_postWrapMode  // 0x20
  private   static  Beyond.FPtrAnimNativeCurve.KeyframeComparers_keyframeComparer  // 0x0
  public    static readonly Unity.Mathematics.float4x4      CURVE_MATRIX  // 0x4
  public    static readonly Unity.Mathematics.float3x3      CURVE_MATRIX_PRIME  // 0x44
METHODS:
  System.Boolean IsValid()
  Unity.Collections.NativeArray<UnityEngine.Keyframe> CreateCurve(UnityEngine.AnimationCurve animationCurve, Unity.Collections.Allocator allocator)
  Unity.Collections.NativeArray<UnityEngine.Keyframe> CreateLine(System.Single val, Unity.Collections.Allocator allocator)
  System.Single Evaluate(System.Single time)
  System.Int32 GetInsertionIndex(UnityEngine.Keyframe* keys, System.Int32 valuesLength, System.Single time)
  System.Single WrapTime(System.Single time)
  System.Single Evaluate(System.Single time, UnityEngine.Keyframe& keyframe, UnityEngine.Keyframe& nextKeyframe)
  System.Single CubicBezier(Unity.Mathematics.float4& curveMatrix, System.Single t)
  System.Single CubicBezier(Unity.Mathematics.float3& curveMatrix, System.Single t)
  System.Single DeCasteljauBezier(System.Int32 degree, Unity.Mathematics.float4 coords, System.Single t)
  System.Void GetTWithBisectionMethod(System.Single time, Unity.Mathematics.float4& curveXCoords, System.Single& t, System.Single& tBottom, System.Single& tTop, System.Single& diff)
  System.Void GetTWithNewtonMethod(System.Single time, Unity.Mathematics.float4& xCoords, Unity.Mathematics.float4& curveXCoords, System.Single& t, System.Single& tBottom, System.Single& tTop, System.Single& diff)
  System.Single UseNewtonMethod(Unity.Mathematics.float4 curveCoords, System.Single coord, System.Single t, Unity.Mathematics.float3 curvePrimeCoords, Unity.Mathematics.float4 primePrimeCoords, System.Single& coordAtT)
  System.Void UpdateTLimits(System.Single x, System.Single time, System.Single t, System.Single& tBottom, System.Single& tTop)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.FPtrNativeCurve
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  private           System.Single*                  m_values  // 0x10
  private           System.Int32                    m_valuesLength  // 0x18
  private           UnityEngine.WrapMode            m_preWrapMode  // 0x1C
  private           UnityEngine.WrapMode            m_postWrapMode  // 0x20
METHODS:
  System.Boolean IsValid()
  Unity.Collections.NativeArray<System.Single> CreateCurve(UnityEngine.AnimationCurve curve, System.Int32 resolution)
  System.Single Evaluate(System.Single t)
  System.Single _Repeat(System.Single t, System.Single length)
  System.Single _Pingpong(System.Single t, System.Single length)
END_CLASS

CLASS: Beyond.Gameplay.AbilityUnsafe.ENPCAbilityPathFollowStateType
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Gameplay.AbilityUnsafe.ENPCAbilityPathFollowStateTypeIdle  // 0x0
  public    static  Beyond.Gameplay.AbilityUnsafe.ENPCAbilityPathFollowStateTypeMove  // 0x0
  public    static  Beyond.Gameplay.AbilityUnsafe.ENPCAbilityPathFollowStateTypeMoveStop  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.AbilityUnsafe.FNPCAbilityPathFollowFragment
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
  public    static  System.Int32                    TOTAL_POINT_CAPACITY  // 0x0
  public    static  System.Int32                    ELEMENT_PER_POINT  // 0x0
  private           Beyond.Gameplay.AbilityUnsafe.FNPCAbilityPathFollowFragment.<m_pathPointQueue>e__FixedBufferm_pathPointQueue  // 0x10
  private           System.Int32                    m_front  // 0x390
  private           System.Int32                    m_pointCount  // 0x394
  public            Beyond.Gameplay.AbilityUnsafe.ENPCAbilityPathFollowStateTypestate  // 0x398
  public            UnityEngine.Vector3             passedAim  // 0x39C
  public            System.Int32                    passedAimStyle  // 0x3A8
  public            System.Int32                    passedAimExtInfo  // 0x3AC
  public            System.Single                   passedAimSpeed  // 0x3B0
  public            System.Boolean                  passedPatrolActionPoint  // 0x3B4
  private           UnityEngine.Vector3             m_StartPos  // 0x3B8
  public            UnityEngine.Vector3             forward  // 0x3C4
  public            System.Single                   maxDistance  // 0x3D0
  public            System.Single                   progressDistance  // 0x3D4
  public            System.Boolean                  startMoveProcess  // 0x3D8
  public            System.Boolean                  bPathFollowEnd  // 0x3D9
  public            System.Single                   startMoveStopTime  // 0x3DC
  public            System.Int32                    loopCount  // 0x3E0
  public            System.Int32                    loopCountStartIndex  // 0x3E4
  public            System.Boolean                  bRetargetAim  // 0x3E8
  public            System.Boolean                  pathChanged  // 0x3E9
  private           System.Boolean                  m_passedPoint  // 0x3EA
  public            System.Single                   groundSlopeAngle  // 0x3EC
METHODS:
  System.Int32 get_pointCount()
  UnityEngine.Vector3 get_aim()
  System.Int32 get_aimStyle()
  System.Int32 get_aimExtInfo()
  System.Single get_aimDesiredSpeed()
  UnityEngine.Vector3 get_startPos()
  System.Void set_startPos(UnityEngine.Vector3 value)
  System.Void Init()
  System.Void MarkPathFollowEnd()
  System.Void MarkMoveStop(System.Single time)
  System.Void SetPathIsLoop(System.Boolean bIsLoop)
  System.Boolean GetPathIsLoop()
  System.Boolean PushPoint(UnityEngine.Vector3 point, System.Int32 styleEnum, System.Int32 extPointInfo, System.Single desiredSpeed, System.Boolean patrolActionPoint)
  System.Boolean PopPathPoint()
  System.Boolean _RefreshScope()
  System.Void CalGroundSlope(UnityEngine.Vector3 curPos, UnityEngine.Vector3 steeringPos, System.Single speed, System.Single smoothTime)
  System.Single SlopeAngleDeg(UnityEngine.Vector3 pos, UnityEngine.Vector3 aim)
  System.Boolean ReplaceLastPoint(UnityEngine.Vector3 point, System.Int32 styleEnum, System.Int32 extPointInfo, System.Single desiredSpeed)
  System.Void ClearAllPathPoints()
  UnityEngine.Vector3 GetPathPoint(System.Int32 idx)
  System.Int32 GetPathPointStyle(System.Int32 idx)
  System.Int32 GetPathPointExtInfo(System.Int32 idx)
  System.Single GetPathPointDesiredSpeed(System.Int32 idx)
  System.Void SetAimPointDesiredSpeed(System.Single speed)
  System.Boolean IsSubActionPoint(System.Int32 idx)
  System.Boolean IsPathFull()
  System.Int32 GetPointCount()
  System.Single GetPathLength(UnityEngine.Vector3 currentLocation)
  System.Int32 GetEffectPointCount()
  System.Int32 FloatToInt32Bits(System.Single v)
  System.Single Int32BitsToFloat(System.Int32 v)
END_CLASS

CLASS: Beyond.NPC.Ability.NPCAbilityUnsafeUtils
TYPE:  class
TOKEN: 0x2000007
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.NPC.Ability.FNPCUnionAnimationAbilityCommand
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            Beyond.NPC.Ability.FNPCUnionAnimationAbilityCommand.ENPCUnionAnimationAbilityCommandTypecmdType  // 0x10
  public            Unity.Collections.FixedBytes4094Payload  // 0x14
METHODS:
  System.Void SetData(T& data)
  T GetData()
END_CLASS

CLASS: Microsoft.CodeAnalysis.EmbeddedAttribute
TYPE:  class
TOKEN: 0x2000002
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Runtime.CompilerServices.IsUnmanagedAttribute
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

