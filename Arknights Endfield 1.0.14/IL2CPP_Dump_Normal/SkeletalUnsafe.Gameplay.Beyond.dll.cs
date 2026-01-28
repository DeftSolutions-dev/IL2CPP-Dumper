// ========================================================
// Dumped by @desirepro
// Assembly: SkeletalUnsafe.Gameplay.Beyond.dll
// Classes:  24
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000006
    public class SimpleWriteLock
    {
        // Methods
        private System.Boolean EnterLock(Unity.Collections.NativeArray<System.Int32> lockFlag, System.Int32 maxSpinCount) { }
        private System.Void MainThreadEnterLock(Unity.Collections.NativeArray<System.Int32> lockFlag, System.Int32 millisecondsTimeout, System.Int32 spinBeforeTiming) { }
        private System.Void ExitLock(Unity.Collections.NativeArray<System.Int32> lockFlag) { }

    }

    // TypeToken: 0x2000007
    public struct TrackerLock, IJob
    {
        // Fields
        public Unity.Collections.NativeArray<System.Int32> flag;        // 0x10
        public System.Boolean isEnter;        // 0x20

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x2000008
    public struct ApplyBoneToAnimatorTransJob, IJob
    {
        // Fields
        public System.Boolean runtime_writeNoDirty;        // 0x10
        public System.Single runtime_applyWeight;        // 0x14
        public Unity.Collections.NativeArray<Beyond.Gameplay.Core.FBoneRuntimeData> runtime_allBoneBasePose;        // 0x18
        public Unity.Collections.NativeArray<Beyond.Gameplay.Core.FBoneRuntimeData> runtime_allBonePose;        // 0x28
        public UnityEngine.AnimationTransformRWBufferHandle runtime_allBonesTransformRWBufferHandle;        // 0x38

        // Methods
        private System.Void Execute() { }
        private System.Void CleanAnimatorTransJob(UnityEngine.AnimationTransformRWBufferHandle rwHandler) { }
        private System.Void SetAnimatorTransPhysicsRatioPtr(UnityEngine.AnimationTransformRWBufferHandle rwHandler, System.Single value) { }

    }

    // TypeToken: 0x2000014
    public class __JobReflectionRegistrationOutput__2314325379
    {
        // Methods
        private System.Void CreateJobReflectionData() { }
        private System.Void EarlyInit() { }

    }

namespace Beyond.Gameplay.Core
{

    // TypeToken: 0x2000004
    public class NativeArrayExtensions
    {
        // Methods
        private System.Void FastCopy(Unity.Collections.NativeArray<T> src, Unity.Collections.NativeArray<T> dst) { }

    }

    // TypeToken: 0x2000005
    public class SkeletalMorphUnsafeJobDefines
    {
    }

    // TypeToken: 0x2000009
    public struct FSkeletalMorphShaderPropMappingData
    {
        // Fields
        public System.Int32 vectorIndex;        // 0x10
        public UnityEngine.Rendering.ShaderPropertyType propertyType;        // 0x14
        public System.Int32 paramNameID;        // 0x18
        public System.Int32 paramRuntimeIdx;        // 0x1C

    }

    // TypeToken: 0x200000A
    public struct FBoneRuntimeData
    {
        // Fields
        public UnityEngine.Vector3 pos;        // 0x10
        public UnityEngine.Vector3 rot;        // 0x1C
        public UnityEngine.Vector3 sca;        // 0x28
        public System.Boolean bIsDirty;        // 0x34

        // Methods
        private System.String ToString() { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x200000B
    public struct FSkeletalMorphBoneData
    {
        // Fields
        public System.Int32 boneNameHash;        // 0x10
        public System.Int32 boneID;        // 0x14
        public UnityEngine.Vector3 position;        // 0x18
        public UnityEngine.Vector3 rotation;        // 0x24
        public UnityEngine.Vector3 scale;        // 0x30

    }

    // TypeToken: 0x200000C
    public struct EMorphPartType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Gameplay.Core.EMorphPartType None;        // 0x0
        public static Beyond.Gameplay.Core.EMorphPartType REyeMorphs;        // 0x0
        public static Beyond.Gameplay.Core.EMorphPartType LEyeMorphs;        // 0x0
        public static Beyond.Gameplay.Core.EMorphPartType RBrowMorphs;        // 0x0
        public static Beyond.Gameplay.Core.EMorphPartType LBrowMorphs;        // 0x0
        public static Beyond.Gameplay.Core.EMorphPartType MouthMorphs;        // 0x0
        public static Beyond.Gameplay.Core.EMorphPartType Other;        // 0x0
        public static Beyond.Gameplay.Core.EMorphPartType LEar;        // 0x0
        public static Beyond.Gameplay.Core.EMorphPartType REar;        // 0x0
        public static Beyond.Gameplay.Core.EMorphPartType All;        // 0x0

    }

    // TypeToken: 0x200000D
    public struct FSkeletalMorphMappingData
    {
        // Fields
        public System.Int32 id;        // 0x10
        public System.Int32 nameHash;        // 0x14
        public System.Int32 tagHash;        // 0x18
        public Beyond.Gameplay.Core.EMorphPartType partType;        // 0x1C
        public System.Int32 boneOffset;        // 0x20
        public System.Int32 boneLen;        // 0x24
        public Beyond.Gameplay.Core.FSkeletalMorphBoneData* bones;        // 0x28
        public System.Boolean bIsShaderProp;        // 0x30
        public static Beyond.Gameplay.Core.FSkeletalMorphMappingData s_defaultMappingData;        // 0x0

        // Methods
        private System.Boolean IsValid() { }
        private Beyond.Gameplay.Core.FSkeletalMorphBoneData GetBoneData(System.Int32 idx) { }
        private System.Void SetMapping(Unity.Collections.NativeArray<Beyond.Gameplay.Core.FSkeletalMorphBoneData> bigList, System.Int32 bonesOffset, System.Int32 bonesLen) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000E
    public struct PtrList`1
    {
        // Fields
        public System.Int32 len;        // 0x0
        public T* data;        // 0x0

    }

    // TypeToken: 0x200000F
    public struct FSkeletalMorphAnim
    {
        // Fields
        public static Beyond.Gameplay.Core.FSkeletalMorphAnim INVALID;        // 0x0
        public System.Int32 animSoTagID;        // 0x10
        public System.Single duration;        // 0x14
        public System.Boolean bIsAdditiveClip;        // 0x18
        public System.Boolean bIsOverride;        // 0x19
        public System.Boolean bIsPauseAutoBlink;        // 0x1A
        public System.Boolean bIsPoseAnim;        // 0x1B
        public Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlCurve> eyeCurveR;        // 0x20
        public Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlCurve> eyeCurveL;        // 0x30
        public Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlCurve> browCurveR;        // 0x40
        public Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlCurve> browCurveL;        // 0x50
        public Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlCurve> mouthCurve;        // 0x60
        public Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlCurve> otherCurve;        // 0x70
        public Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlCurve> lEarCurve;        // 0x80
        public Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlCurve> rEarCurve;        // 0x90

        // Methods
        private System.Boolean IsValid() { }
        private Unity.Collections.NativeArray<Beyond.Gameplay.Core.FMorphCtrlCurve> Create(Beyond.Gameplay.Core.EMorphPartType partType, System.Int32 curveLen) { }
        private System.Boolean GetCurveData(Beyond.Gameplay.Core.EMorphPartType partType, System.Int32 idx, Beyond.Gameplay.Core.FMorphCtrlCurve& curve) { }
        private System.Int32 GetCurveLen(Beyond.Gameplay.Core.EMorphPartType partType) { }
        private System.Void SetCurveData(Beyond.Gameplay.Core.EMorphPartType partType, System.Int32 idx, Beyond.Gameplay.Core.FMorphCtrlCurve& curve) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000010
    public struct FMorphCtrlCurve
    {
        // Fields
        public static System.Int32 RESOLUTION;        // 0x0
        public System.Int32 ctrlNameHash;        // 0x10
        public Beyond.FPtrAnimNativeCurve curve;        // 0x18

        // Methods
        private Unity.Collections.NativeArray<UnityEngine.Keyframe> Create(System.String name, UnityEngine.AnimationCurve animCurve, Unity.Collections.Allocator allocator) { }
        private Unity.Collections.NativeArray<UnityEngine.Keyframe> Create(System.String name, System.Single poseVal, Unity.Collections.Allocator allocator) { }

    }

    // TypeToken: 0x2000011
    public struct FSkeletalMorphPose
    {
        // Fields
        public static Beyond.Gameplay.Core.FSkeletalMorphPose INVALID;        // 0x0
        public Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlValue> eyeValueR;        // 0x10
        public Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlValue> eyeValueL;        // 0x20
        public Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlValue> browValueR;        // 0x30
        public Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlValue> browValueL;        // 0x40
        public Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlValue> mouthValue;        // 0x50
        public Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlValue> otherValue;        // 0x60
        public System.Boolean bIsAdditivePose;        // 0x70

        // Methods
        private System.Boolean IsValid() { }
        private System.Int32 AllCurveNum() { }
        private Unity.Collections.NativeArray<Beyond.Gameplay.Core.FMorphCtrlValue> Create(Beyond.Gameplay.Core.EMorphPartType partType, System.Int32 curveLen) { }
        private System.Boolean GetValueData(Beyond.Gameplay.Core.EMorphPartType partType, System.Int32 idx, Beyond.Gameplay.Core.FMorphCtrlValue& curve) { }
        private System.Int32 GetValueLen(Beyond.Gameplay.Core.EMorphPartType partType) { }
        private System.Void SetValueData(Beyond.Gameplay.Core.EMorphPartType partType, System.Int32 idx, Beyond.Gameplay.Core.FMorphCtrlValue& curve) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000012
    public struct FMorphCtrlValue
    {
        // Fields
        public System.Int32 ctrlNameHash;        // 0x10
        public System.Single value;        // 0x14

    }

    // TypeToken: 0x2000013
    public class SkeletalMorphUnsafeJobUtils
    {
        // Methods
        private T& GetUnsafeElementRef(Unity.Collections.NativeArray<T> array, System.Int32 idx) { }
        private System.Void SetUnsafeElementRef(Unity.Collections.NativeArray<T> array, System.Int32 idx, T& val) { }
        private UnityEngine.Quaternion FromMaya(UnityEngine.Vector3 eulerAngle) { }

    }

}

namespace IFix
{

    // TypeToken: 0x2000015
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10
        private System.Int32 methodId;        // 0x18
        private System.Object anonObj;        // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;        // 0x0

        // Methods
        private System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        private System.Boolean __Gen_Wrap_0(Unity.Collections.NativeArray<System.Int32> P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_1(Unity.Collections.NativeArray<System.Int32> P0, System.Int32 P1, System.Int32 P2) { }
        private System.Void __Gen_Wrap_2(Unity.Collections.NativeArray<System.Int32> P0) { }
        private System.Void __Gen_Wrap_3(Beyond.Gameplay.Core.SkeletalMorphUnsafeJobDefines.TrackerLock& P0) { }
        private UnityEngine.Quaternion __Gen_Wrap_4(UnityEngine.Vector3 P0) { }
        private System.Void __Gen_Wrap_5(Beyond.Gameplay.Core.SkeletalMorphUnsafeJobDefines.ApplyBoneToAnimatorTransJob& P0) { }
        private System.Void __Gen_Wrap_6(UnityEngine.AnimationTransformRWBufferHandle P0) { }
        private System.Void __Gen_Wrap_7(UnityEngine.AnimationTransformRWBufferHandle P0, System.Single P1) { }
        private System.String __Gen_Wrap_8(Beyond.Gameplay.Core.FBoneRuntimeData& P0) { }
        private System.Boolean __Gen_Wrap_9(Beyond.Gameplay.Core.FSkeletalMorphMappingData& P0) { }
        private Beyond.Gameplay.Core.FSkeletalMorphBoneData __Gen_Wrap_10(Beyond.Gameplay.Core.FSkeletalMorphMappingData& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_11(Beyond.Gameplay.Core.FSkeletalMorphMappingData& P0, Unity.Collections.NativeArray<Beyond.Gameplay.Core.FSkeletalMorphBoneData> P1, System.Int32 P2, System.Int32 P3) { }
        private System.Boolean __Gen_Wrap_12(Beyond.Gameplay.Core.FSkeletalMorphAnim& P0) { }
        private Unity.Collections.NativeArray<Beyond.Gameplay.Core.FMorphCtrlCurve> __Gen_Wrap_13(Beyond.Gameplay.Core.FSkeletalMorphAnim& P0, Beyond.Gameplay.Core.EMorphPartType P1, System.Int32 P2) { }
        private System.Boolean __Gen_Wrap_14(Beyond.Gameplay.Core.FSkeletalMorphAnim& P0, Beyond.Gameplay.Core.EMorphPartType P1, System.Int32 P2, Beyond.Gameplay.Core.FMorphCtrlCurve& P3) { }
        private System.Int32 __Gen_Wrap_15(Beyond.Gameplay.Core.FSkeletalMorphAnim& P0, Beyond.Gameplay.Core.EMorphPartType P1) { }
        private System.Void __Gen_Wrap_16(Beyond.Gameplay.Core.FSkeletalMorphAnim& P0, Beyond.Gameplay.Core.EMorphPartType P1, System.Int32 P2, Beyond.Gameplay.Core.FMorphCtrlCurve& P3) { }
        private Unity.Collections.NativeArray<UnityEngine.Keyframe> __Gen_Wrap_17(Beyond.Gameplay.Core.FMorphCtrlCurve& P0, System.Object P1, System.Object P2, Unity.Collections.Allocator P3) { }
        private Unity.Collections.NativeArray<UnityEngine.Keyframe> __Gen_Wrap_18(Beyond.Gameplay.Core.FMorphCtrlCurve& P0, System.Object P1, System.Single P2, Unity.Collections.Allocator P3) { }
        private System.Boolean __Gen_Wrap_19(Beyond.Gameplay.Core.FSkeletalMorphPose& P0) { }
        private System.Int32 __Gen_Wrap_20(Beyond.Gameplay.Core.FSkeletalMorphPose& P0) { }
        private Unity.Collections.NativeArray<Beyond.Gameplay.Core.FMorphCtrlValue> __Gen_Wrap_21(Beyond.Gameplay.Core.FSkeletalMorphPose& P0, Beyond.Gameplay.Core.EMorphPartType P1, System.Int32 P2) { }
        private System.Boolean __Gen_Wrap_22(Beyond.Gameplay.Core.FSkeletalMorphPose& P0, Beyond.Gameplay.Core.EMorphPartType P1, System.Int32 P2, Beyond.Gameplay.Core.FMorphCtrlValue& P3) { }
        private System.Int32 __Gen_Wrap_23(Beyond.Gameplay.Core.FSkeletalMorphPose& P0, Beyond.Gameplay.Core.EMorphPartType P1) { }
        private System.Void __Gen_Wrap_24(Beyond.Gameplay.Core.FSkeletalMorphPose& P0, Beyond.Gameplay.Core.EMorphPartType P1, System.Int32 P2, Beyond.Gameplay.Core.FMorphCtrlValue& P3) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000016
    public class ILFixInterfaceBridge : AnonymousStorey
    {
        // Methods
        private System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        private System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x2000017
    public class WrappersManagerImpl, WrappersManager
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10

        // Methods
        private System.Void .ctor(IFix.Core.VirtualMachine virtualMachine) { }
        private IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        private System.Boolean IsPatched(System.Int32 id) { }
        private System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon) { }
        private System.Object CreateWrapper(System.Int32 id) { }
        private System.Object InitWrapperArray(System.Int32 len) { }
        private IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine) { }

    }

    // TypeToken: 0x2000018
    public struct IDMAP0
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static IFix.IDMAP0 Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-SimpleWriteLock-EnterLock0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-SimpleWriteLock-MainThreadEnterLock0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-SimpleWriteLock-ExitLock0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-TrackerLock-Execute0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-SkeletalMorphUnsafeJobUtils-FromMaya0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-ApplyBoneToAnimatorTransJob-Execute0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-ApplyBoneToAnimatorTransJob-CleanAnimatorTransJob0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-ApplyBoneToAnimatorTransJob-SetAnimatorTransPhysicsRatioPtr0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FBoneRuntimeData-ToString0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FSkeletalMorphMappingData-IsValid0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FSkeletalMorphMappingData-GetBoneData0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FSkeletalMorphMappingData-SetMapping0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FSkeletalMorphAnim-IsValid0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FSkeletalMorphAnim-Create0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FSkeletalMorphAnim-GetCurveData0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FSkeletalMorphAnim-GetCurveLen0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FSkeletalMorphAnim-SetCurveData0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FMorphCtrlCurve-Create0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FMorphCtrlCurve-Create1;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FSkeletalMorphPose-IsValid0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FSkeletalMorphPose-AllCurveNum0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FSkeletalMorphPose-Create0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FSkeletalMorphPose-GetValueData0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FSkeletalMorphPose-GetValueLen0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Core-FSkeletalMorphPose-SetValueData0;        // 0x0

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

