// ========================================================
// Dumped by @desirepro
// Assembly: AbilityUnsafe.Gameplay.Beyond.dll
// Classes:  14
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000005
    public struct KeyframeComparer, IComparer`1
    {
        // Methods
        private System.Int32 Compare(UnityEngine.Keyframe keyframe1, UnityEngine.Keyframe keyframe2) { }

    }

    // TypeToken: 0x2000009
    public struct ENPCUnionAnimationAbilityCommandType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.NPC.Ability.FNPCUnionAnimationAbilityCommand.ENPCUnionAnimationAbilityCommandType DoAnimatorStepBegin;        // 0x0
        public static Beyond.NPC.Ability.FNPCUnionAnimationAbilityCommand.ENPCUnionAnimationAbilityCommandType DoAnimatorStepEnd;        // 0x0

    }

    // TypeToken: 0x200000A
    public struct DoAnimatorStepEndParams
    {
        // Fields
        public System.Single stepEndDegree;        // 0x10

    }

    // TypeToken: 0x200000B
    public struct DoAnimatorUpdateStepBeginDegreeParams
    {
        // Fields
        public System.Single stepBeginDegree;        // 0x10

    }

namespace Beyond
{

    // TypeToken: 0x2000004
    public struct FPtrAnimNativeCurve
    {
        // Fields
        private UnityEngine.Keyframe* m_values;        // 0x10
        private System.Int32 m_valuesLength;        // 0x18
        private UnityEngine.WrapMode m_preWrapMode;        // 0x1C
        private UnityEngine.WrapMode m_postWrapMode;        // 0x20
        private static Beyond.FPtrAnimNativeCurve.KeyframeComparer s_keyframeComparer;        // 0x0
        public static readonly Unity.Mathematics.float4x4 CURVE_MATRIX;        // 0x4
        public static readonly Unity.Mathematics.float3x3 CURVE_MATRIX_PRIME;        // 0x44

        // Methods
        private System.Boolean IsValid() { }
        private Unity.Collections.NativeArray<UnityEngine.Keyframe> CreateCurve(UnityEngine.AnimationCurve animationCurve, Unity.Collections.Allocator allocator) { }
        private Unity.Collections.NativeArray<UnityEngine.Keyframe> CreateLine(System.Single val, Unity.Collections.Allocator allocator) { }
        private System.Single Evaluate(System.Single time) { }
        private System.Int32 GetInsertionIndex(UnityEngine.Keyframe* keys, System.Int32 valuesLength, System.Single time) { }
        private System.Single WrapTime(System.Single time) { }
        private System.Single Evaluate(System.Single time, UnityEngine.Keyframe& keyframe, UnityEngine.Keyframe& nextKeyframe) { }
        private System.Single CubicBezier(Unity.Mathematics.float4& curveMatrix, System.Single t) { }
        private System.Single CubicBezier(Unity.Mathematics.float3& curveMatrix, System.Single t) { }
        private System.Single DeCasteljauBezier(System.Int32 degree, Unity.Mathematics.float4 coords, System.Single t) { }
        private System.Void GetTWithBisectionMethod(System.Single time, Unity.Mathematics.float4& curveXCoords, System.Single& t, System.Single& tBottom, System.Single& tTop, System.Single& diff) { }
        private System.Void GetTWithNewtonMethod(System.Single time, Unity.Mathematics.float4& xCoords, Unity.Mathematics.float4& curveXCoords, System.Single& t, System.Single& tBottom, System.Single& tTop, System.Single& diff) { }
        private System.Single UseNewtonMethod(Unity.Mathematics.float4 curveCoords, System.Single coord, System.Single t, Unity.Mathematics.float3 curvePrimeCoords, Unity.Mathematics.float4 primePrimeCoords, System.Single& coordAtT) { }
        private System.Void UpdateTLimits(System.Single x, System.Single time, System.Single t, System.Single& tBottom, System.Single& tTop) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000006
    public struct FPtrNativeCurve
    {
        // Fields
        private System.Single* m_values;        // 0x10
        private System.Int32 m_valuesLength;        // 0x18
        private UnityEngine.WrapMode m_preWrapMode;        // 0x1C
        private UnityEngine.WrapMode m_postWrapMode;        // 0x20

        // Methods
        private System.Boolean IsValid() { }
        private Unity.Collections.NativeArray<System.Single> CreateCurve(UnityEngine.AnimationCurve curve, System.Int32 resolution) { }
        private System.Single Evaluate(System.Single t) { }
        private System.Single _Repeat(System.Single t, System.Single length) { }
        private System.Single _Pingpong(System.Single t, System.Single length) { }

    }

}

namespace Beyond.Gameplay.AbilityUnsafe
{

    // TypeToken: 0x200000C
    public struct ENPCAbilityPathFollowStateType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Gameplay.AbilityUnsafe.ENPCAbilityPathFollowStateType Idle;        // 0x0
        public static Beyond.Gameplay.AbilityUnsafe.ENPCAbilityPathFollowStateType Move;        // 0x0
        public static Beyond.Gameplay.AbilityUnsafe.ENPCAbilityPathFollowStateType MoveStop;        // 0x0

    }

    // TypeToken: 0x200000D
    public struct FNPCAbilityPathFollowFragment
    {
        // Fields
        public static System.Int32 TOTAL_POINT_CAPACITY;        // 0x0
        public static System.Int32 ELEMENT_PER_POINT;        // 0x0
        private Beyond.Gameplay.AbilityUnsafe.FNPCAbilityPathFollowFragment.<m_pathPointQueue>e__FixedBuffer m_pathPointQueue;        // 0x10
        private System.Int32 m_front;        // 0x390
        private System.Int32 m_pointCount;        // 0x394
        public Beyond.Gameplay.AbilityUnsafe.ENPCAbilityPathFollowStateType state;        // 0x398
        public UnityEngine.Vector3 passedAim;        // 0x39C
        public System.Int32 passedAimStyle;        // 0x3A8
        public System.Int32 passedAimExtInfo;        // 0x3AC
        public System.Single passedAimSpeed;        // 0x3B0
        public System.Boolean passedPatrolActionPoint;        // 0x3B4
        private UnityEngine.Vector3 m_StartPos;        // 0x3B8
        public UnityEngine.Vector3 forward;        // 0x3C4
        public System.Single maxDistance;        // 0x3D0
        public System.Single progressDistance;        // 0x3D4
        public System.Boolean startMoveProcess;        // 0x3D8
        public System.Boolean bPathFollowEnd;        // 0x3D9
        public System.Single startMoveStopTime;        // 0x3DC
        public System.Int32 loopCount;        // 0x3E0
        public System.Int32 loopCountStartIndex;        // 0x3E4
        public System.Boolean bRetargetAim;        // 0x3E8
        public System.Boolean pathChanged;        // 0x3E9
        private System.Boolean m_passedPoint;        // 0x3EA
        public System.Single groundSlopeAngle;        // 0x3EC

        // Methods
        private System.Int32 get_pointCount() { }
        private UnityEngine.Vector3 get_aim() { }
        private System.Int32 get_aimStyle() { }
        private System.Int32 get_aimExtInfo() { }
        private System.Single get_aimDesiredSpeed() { }
        private UnityEngine.Vector3 get_startPos() { }
        private System.Void set_startPos(UnityEngine.Vector3 value) { }
        private System.Void Init() { }
        private System.Void MarkPathFollowEnd() { }
        private System.Void MarkMoveStop(System.Single time) { }
        private System.Void SetPathIsLoop(System.Boolean bIsLoop) { }
        private System.Boolean GetPathIsLoop() { }
        private System.Boolean PushPoint(UnityEngine.Vector3 point, System.Int32 styleEnum, System.Int32 extPointInfo, System.Single desiredSpeed, System.Boolean patrolActionPoint) { }
        private System.Boolean PopPathPoint() { }
        private System.Boolean _RefreshScope() { }
        private System.Void CalGroundSlope(UnityEngine.Vector3 curPos, UnityEngine.Vector3 steeringPos, System.Single speed, System.Single smoothTime) { }
        private System.Single SlopeAngleDeg(UnityEngine.Vector3 pos, UnityEngine.Vector3 aim) { }
        private System.Boolean ReplaceLastPoint(UnityEngine.Vector3 point, System.Int32 styleEnum, System.Int32 extPointInfo, System.Single desiredSpeed) { }
        private System.Void ClearAllPathPoints() { }
        private UnityEngine.Vector3 GetPathPoint(System.Int32 idx) { }
        private System.Int32 GetPathPointStyle(System.Int32 idx) { }
        private System.Int32 GetPathPointExtInfo(System.Int32 idx) { }
        private System.Single GetPathPointDesiredSpeed(System.Int32 idx) { }
        private System.Void SetAimPointDesiredSpeed(System.Single speed) { }
        private System.Boolean IsSubActionPoint(System.Int32 idx) { }
        private System.Boolean IsPathFull() { }
        private System.Int32 GetPointCount() { }
        private System.Single GetPathLength(UnityEngine.Vector3 currentLocation) { }
        private System.Int32 GetEffectPointCount() { }
        private System.Int32 FloatToInt32Bits(System.Single v) { }
        private System.Single Int32BitsToFloat(System.Int32 v) { }

    }

}

namespace Beyond.NPC.Ability
{

    // TypeToken: 0x2000007
    public class NPCAbilityUnsafeUtils
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000008
    public struct FNPCUnionAnimationAbilityCommand
    {
        // Fields
        public Beyond.NPC.Ability.FNPCUnionAnimationAbilityCommand.ENPCUnionAnimationAbilityCommandType cmdType;        // 0x10
        public Unity.Collections.FixedBytes4094 Payload;        // 0x14

        // Methods
        private System.Void SetData(T& data) { }
        private T GetData() { }

    }

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
    public class IsUnmanagedAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

