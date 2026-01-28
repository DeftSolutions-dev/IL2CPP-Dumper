// ========================================================
// Dumped by @desirepro
// Assembly: SkeletalUnsafe.Gameplay.Beyond.dll
// Classes:  24
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: SimpleWriteLock
TYPE:  class
TOKEN: 0x2000006
FIELDS:
METHODS:
  System.Boolean EnterLock(Unity.Collections.NativeArray<System.Int32> lockFlag, System.Int32 maxSpinCount)
  System.Void MainThreadEnterLock(Unity.Collections.NativeArray<System.Int32> lockFlag, System.Int32 millisecondsTimeout, System.Int32 spinBeforeTiming)
  System.Void ExitLock(Unity.Collections.NativeArray<System.Int32> lockFlag)
END_CLASS

CLASS: TrackerLock
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>flag  // 0x10
  public            System.Boolean                  isEnter  // 0x20
METHODS:
  System.Void Execute()
END_CLASS

CLASS: ApplyBoneToAnimatorTransJob
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.Boolean                  runtime_writeNoDirty  // 0x10
  public            System.Single                   runtime_applyWeight  // 0x14
  public            Unity.Collections.NativeArray<Beyond.Gameplay.Core.FBoneRuntimeData>runtime_allBoneBasePose  // 0x18
  public            Unity.Collections.NativeArray<Beyond.Gameplay.Core.FBoneRuntimeData>runtime_allBonePose  // 0x28
  public            UnityEngine.AnimationTransformRWBufferHandleruntime_allBonesTransformRWBufferHandle  // 0x38
METHODS:
  System.Void Execute()
  System.Void CleanAnimatorTransJob(UnityEngine.AnimationTransformRWBufferHandle rwHandler)
  System.Void SetAnimatorTransPhysicsRatioPtr(UnityEngine.AnimationTransformRWBufferHandle rwHandler, System.Single value)
END_CLASS

CLASS: __JobReflectionRegistrationOutput__2314325379
TYPE:  class
TOKEN: 0x2000014
FIELDS:
METHODS:
  System.Void CreateJobReflectionData()
  System.Void EarlyInit()
END_CLASS

CLASS: Beyond.Gameplay.Core.NativeArrayExtensions
TYPE:  class
TOKEN: 0x2000004
FIELDS:
METHODS:
  System.Void FastCopy(Unity.Collections.NativeArray<T> src, Unity.Collections.NativeArray<T> dst)
END_CLASS

CLASS: Beyond.Gameplay.Core.SkeletalMorphUnsafeJobDefines
TYPE:  class
TOKEN: 0x2000005
FIELDS:
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Core.FSkeletalMorphShaderPropMappingData
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  public            System.Int32                    vectorIndex  // 0x10
  public            UnityEngine.Rendering.ShaderPropertyTypepropertyType  // 0x14
  public            System.Int32                    paramNameID  // 0x18
  public            System.Int32                    paramRuntimeIdx  // 0x1C
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Core.FBoneRuntimeData
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            UnityEngine.Vector3             pos  // 0x10
  public            UnityEngine.Vector3             rot  // 0x1C
  public            UnityEngine.Vector3             sca  // 0x28
  public            System.Boolean                  bIsDirty  // 0x34
METHODS:
  System.String ToString()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: Beyond.Gameplay.Core.FSkeletalMorphBoneData
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  public            System.Int32                    boneNameHash  // 0x10
  public            System.Int32                    boneID  // 0x14
  public            UnityEngine.Vector3             position  // 0x18
  public            UnityEngine.Vector3             rotation  // 0x24
  public            UnityEngine.Vector3             scale  // 0x30
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Core.EMorphPartType
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Gameplay.Core.EMorphPartTypeNone  // 0x0
  public    static  Beyond.Gameplay.Core.EMorphPartTypeREyeMorphs  // 0x0
  public    static  Beyond.Gameplay.Core.EMorphPartTypeLEyeMorphs  // 0x0
  public    static  Beyond.Gameplay.Core.EMorphPartTypeRBrowMorphs  // 0x0
  public    static  Beyond.Gameplay.Core.EMorphPartTypeLBrowMorphs  // 0x0
  public    static  Beyond.Gameplay.Core.EMorphPartTypeMouthMorphs  // 0x0
  public    static  Beyond.Gameplay.Core.EMorphPartTypeOther  // 0x0
  public    static  Beyond.Gameplay.Core.EMorphPartTypeLEar  // 0x0
  public    static  Beyond.Gameplay.Core.EMorphPartTypeREar  // 0x0
  public    static  Beyond.Gameplay.Core.EMorphPartTypeAll  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Core.FSkeletalMorphMappingData
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
  public            System.Int32                    id  // 0x10
  public            System.Int32                    nameHash  // 0x14
  public            System.Int32                    tagHash  // 0x18
  public            Beyond.Gameplay.Core.EMorphPartTypepartType  // 0x1C
  public            System.Int32                    boneOffset  // 0x20
  public            System.Int32                    boneLen  // 0x24
  public            Beyond.Gameplay.Core.FSkeletalMorphBoneData*bones  // 0x28
  public            System.Boolean                  bIsShaderProp  // 0x30
  public    static  Beyond.Gameplay.Core.FSkeletalMorphMappingDatas_defaultMappingData  // 0x0
METHODS:
  System.Boolean IsValid()
  Beyond.Gameplay.Core.FSkeletalMorphBoneData GetBoneData(System.Int32 idx)
  System.Void SetMapping(Unity.Collections.NativeArray<Beyond.Gameplay.Core.FSkeletalMorphBoneData> bigList, System.Int32 bonesOffset, System.Int32 bonesLen)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Gameplay.Core.PtrList`1
TYPE:  struct
TOKEN: 0x200000E
FIELDS:
  public            System.Int32                    len  // 0x0
  public            T*                              data  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Core.FSkeletalMorphAnim
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  public    static  Beyond.Gameplay.Core.FSkeletalMorphAnimINVALID  // 0x0
  public            System.Int32                    animSoTagID  // 0x10
  public            System.Single                   duration  // 0x14
  public            System.Boolean                  bIsAdditiveClip  // 0x18
  public            System.Boolean                  bIsOverride  // 0x19
  public            System.Boolean                  bIsPauseAutoBlink  // 0x1A
  public            System.Boolean                  bIsPoseAnim  // 0x1B
  public            Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlCurve>eyeCurveR  // 0x20
  public            Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlCurve>eyeCurveL  // 0x30
  public            Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlCurve>browCurveR  // 0x40
  public            Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlCurve>browCurveL  // 0x50
  public            Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlCurve>mouthCurve  // 0x60
  public            Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlCurve>otherCurve  // 0x70
  public            Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlCurve>lEarCurve  // 0x80
  public            Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlCurve>rEarCurve  // 0x90
METHODS:
  System.Boolean IsValid()
  Unity.Collections.NativeArray<Beyond.Gameplay.Core.FMorphCtrlCurve> Create(Beyond.Gameplay.Core.EMorphPartType partType, System.Int32 curveLen)
  System.Boolean GetCurveData(Beyond.Gameplay.Core.EMorphPartType partType, System.Int32 idx, Beyond.Gameplay.Core.FMorphCtrlCurve& curve)
  System.Int32 GetCurveLen(Beyond.Gameplay.Core.EMorphPartType partType)
  System.Void SetCurveData(Beyond.Gameplay.Core.EMorphPartType partType, System.Int32 idx, Beyond.Gameplay.Core.FMorphCtrlCurve& curve)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Gameplay.Core.FMorphCtrlCurve
TYPE:  struct
TOKEN: 0x2000010
FIELDS:
  public    static  System.Int32                    RESOLUTION  // 0x0
  public            System.Int32                    ctrlNameHash  // 0x10
  public            Beyond.FPtrAnimNativeCurve      curve  // 0x18
METHODS:
  Unity.Collections.NativeArray<UnityEngine.Keyframe> Create(System.String name, UnityEngine.AnimationCurve animCurve, Unity.Collections.Allocator allocator)
  Unity.Collections.NativeArray<UnityEngine.Keyframe> Create(System.String name, System.Single poseVal, Unity.Collections.Allocator allocator)
END_CLASS

CLASS: Beyond.Gameplay.Core.FSkeletalMorphPose
TYPE:  struct
TOKEN: 0x2000011
FIELDS:
  public    static  Beyond.Gameplay.Core.FSkeletalMorphPoseINVALID  // 0x0
  public            Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlValue>eyeValueR  // 0x10
  public            Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlValue>eyeValueL  // 0x20
  public            Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlValue>browValueR  // 0x30
  public            Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlValue>browValueL  // 0x40
  public            Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlValue>mouthValue  // 0x50
  public            Beyond.Gameplay.Core.PtrList<Beyond.Gameplay.Core.FMorphCtrlValue>otherValue  // 0x60
  public            System.Boolean                  bIsAdditivePose  // 0x70
METHODS:
  System.Boolean IsValid()
  System.Int32 AllCurveNum()
  Unity.Collections.NativeArray<Beyond.Gameplay.Core.FMorphCtrlValue> Create(Beyond.Gameplay.Core.EMorphPartType partType, System.Int32 curveLen)
  System.Boolean GetValueData(Beyond.Gameplay.Core.EMorphPartType partType, System.Int32 idx, Beyond.Gameplay.Core.FMorphCtrlValue& curve)
  System.Int32 GetValueLen(Beyond.Gameplay.Core.EMorphPartType partType)
  System.Void SetValueData(Beyond.Gameplay.Core.EMorphPartType partType, System.Int32 idx, Beyond.Gameplay.Core.FMorphCtrlValue& curve)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Gameplay.Core.FMorphCtrlValue
TYPE:  struct
TOKEN: 0x2000012
FIELDS:
  public            System.Int32                    ctrlNameHash  // 0x10
  public            System.Single                   value  // 0x14
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Core.SkeletalMorphUnsafeJobUtils
TYPE:  class
TOKEN: 0x2000013
FIELDS:
METHODS:
  T& GetUnsafeElementRef(Unity.Collections.NativeArray<T> array, System.Int32 idx)
  System.Void SetUnsafeElementRef(Unity.Collections.NativeArray<T> array, System.Int32 idx, T& val)
  UnityEngine.Quaternion FromMaya(UnityEngine.Vector3 eulerAngle)
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x2000015
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // 0x0
METHODS:
  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj)
  System.Boolean __Gen_Wrap_0(Unity.Collections.NativeArray<System.Int32> P0, System.Int32 P1)
  System.Void __Gen_Wrap_1(Unity.Collections.NativeArray<System.Int32> P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_2(Unity.Collections.NativeArray<System.Int32> P0)
  System.Void __Gen_Wrap_3(Beyond.Gameplay.Core.SkeletalMorphUnsafeJobDefines.TrackerLock& P0)
  UnityEngine.Quaternion __Gen_Wrap_4(UnityEngine.Vector3 P0)
  System.Void __Gen_Wrap_5(Beyond.Gameplay.Core.SkeletalMorphUnsafeJobDefines.ApplyBoneToAnimatorTransJob& P0)
  System.Void __Gen_Wrap_6(UnityEngine.AnimationTransformRWBufferHandle P0)
  System.Void __Gen_Wrap_7(UnityEngine.AnimationTransformRWBufferHandle P0, System.Single P1)
  System.String __Gen_Wrap_8(Beyond.Gameplay.Core.FBoneRuntimeData& P0)
  System.Boolean __Gen_Wrap_9(Beyond.Gameplay.Core.FSkeletalMorphMappingData& P0)
  Beyond.Gameplay.Core.FSkeletalMorphBoneData __Gen_Wrap_10(Beyond.Gameplay.Core.FSkeletalMorphMappingData& P0, System.Int32 P1)
  System.Void __Gen_Wrap_11(Beyond.Gameplay.Core.FSkeletalMorphMappingData& P0, Unity.Collections.NativeArray<Beyond.Gameplay.Core.FSkeletalMorphBoneData> P1, System.Int32 P2, System.Int32 P3)
  System.Boolean __Gen_Wrap_12(Beyond.Gameplay.Core.FSkeletalMorphAnim& P0)
  Unity.Collections.NativeArray<Beyond.Gameplay.Core.FMorphCtrlCurve> __Gen_Wrap_13(Beyond.Gameplay.Core.FSkeletalMorphAnim& P0, Beyond.Gameplay.Core.EMorphPartType P1, System.Int32 P2)
  System.Boolean __Gen_Wrap_14(Beyond.Gameplay.Core.FSkeletalMorphAnim& P0, Beyond.Gameplay.Core.EMorphPartType P1, System.Int32 P2, Beyond.Gameplay.Core.FMorphCtrlCurve& P3)
  System.Int32 __Gen_Wrap_15(Beyond.Gameplay.Core.FSkeletalMorphAnim& P0, Beyond.Gameplay.Core.EMorphPartType P1)
  System.Void __Gen_Wrap_16(Beyond.Gameplay.Core.FSkeletalMorphAnim& P0, Beyond.Gameplay.Core.EMorphPartType P1, System.Int32 P2, Beyond.Gameplay.Core.FMorphCtrlCurve& P3)
  Unity.Collections.NativeArray<UnityEngine.Keyframe> __Gen_Wrap_17(Beyond.Gameplay.Core.FMorphCtrlCurve& P0, System.Object P1, System.Object P2, Unity.Collections.Allocator P3)
  Unity.Collections.NativeArray<UnityEngine.Keyframe> __Gen_Wrap_18(Beyond.Gameplay.Core.FMorphCtrlCurve& P0, System.Object P1, System.Single P2, Unity.Collections.Allocator P3)
  System.Boolean __Gen_Wrap_19(Beyond.Gameplay.Core.FSkeletalMorphPose& P0)
  System.Int32 __Gen_Wrap_20(Beyond.Gameplay.Core.FSkeletalMorphPose& P0)
  Unity.Collections.NativeArray<Beyond.Gameplay.Core.FMorphCtrlValue> __Gen_Wrap_21(Beyond.Gameplay.Core.FSkeletalMorphPose& P0, Beyond.Gameplay.Core.EMorphPartType P1, System.Int32 P2)
  System.Boolean __Gen_Wrap_22(Beyond.Gameplay.Core.FSkeletalMorphPose& P0, Beyond.Gameplay.Core.EMorphPartType P1, System.Int32 P2, Beyond.Gameplay.Core.FMorphCtrlValue& P3)
  System.Int32 __Gen_Wrap_23(Beyond.Gameplay.Core.FSkeletalMorphPose& P0, Beyond.Gameplay.Core.EMorphPartType P1)
  System.Void __Gen_Wrap_24(Beyond.Gameplay.Core.FSkeletalMorphPose& P0, Beyond.Gameplay.Core.EMorphPartType P1, System.Int32 P2, Beyond.Gameplay.Core.FMorphCtrlValue& P3)
  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixInterfaceBridge
TYPE:  class
TOKEN: 0x2000016
EXTENDS: AnonymousStorey
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine)
  System.Void RefAsyncBuilderStartMethod()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x2000017
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
METHODS:
  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine)
  IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id)
  System.Boolean IsPatched(System.Int32 id)
  System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon)
  System.Object CreateWrapper(System.Int32 id)
  System.Object InitWrapperArray(System.Int32 len)
  IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine)
END_CLASS

CLASS: IFix.IDMAP0
TYPE:  struct
TOKEN: 0x2000018
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-SimpleWriteLock-EnterLock0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-SimpleWriteLock-MainThreadEnterLock0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-SimpleWriteLock-ExitLock0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-TrackerLock-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-SkeletalMorphUnsafeJobUtils-FromMaya0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-ApplyBoneToAnimatorTransJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-ApplyBoneToAnimatorTransJob-CleanAnimatorTransJob0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-ApplyBoneToAnimatorTransJob-SetAnimatorTransPhysicsRatioPtr0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-FBoneRuntimeData-ToString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-FSkeletalMorphMappingData-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-FSkeletalMorphMappingData-GetBoneData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-FSkeletalMorphMappingData-SetMapping0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-FSkeletalMorphAnim-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-FSkeletalMorphAnim-Create0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-FSkeletalMorphAnim-GetCurveData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-FSkeletalMorphAnim-GetCurveLen0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-FSkeletalMorphAnim-SetCurveData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-FMorphCtrlCurve-Create0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-FMorphCtrlCurve-Create1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-FSkeletalMorphPose-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-FSkeletalMorphPose-AllCurveNum0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-FSkeletalMorphPose-Create0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-FSkeletalMorphPose-GetValueData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-FSkeletalMorphPose-GetValueLen0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Core-FSkeletalMorphPose-SetValueData0  // 0x0
METHODS:
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

