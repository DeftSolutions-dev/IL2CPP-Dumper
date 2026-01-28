// ========================================================
// Dumped by @desirepro
// Assembly: Unity.Animation.Rigging.dll
// Classes:  136
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: WorldUpType
TYPE:  struct
TOKEN: 0x200001E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Animations.Rigging.MultiAimConstraintJob.WorldUpTypeNone  // 0x0
  public    static  UnityEngine.Animations.Rigging.MultiAimConstraintJob.WorldUpTypeSceneUp  // 0x0
  public    static  UnityEngine.Animations.Rigging.MultiAimConstraintJob.WorldUpTypeObjectUp  // 0x0
  public    static  UnityEngine.Animations.Rigging.MultiAimConstraintJob.WorldUpTypeObjectRotationUp  // 0x0
  public    static  UnityEngine.Animations.Rigging.MultiAimConstraintJob.WorldUpTypeVector  // 0x0
METHODS:
END_CLASS

CLASS: Space
TYPE:  struct
TOKEN: 0x200002E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Animations.Rigging.OverrideTransformJob.SpaceWorld  // 0x0
  public    static  UnityEngine.Animations.Rigging.OverrideTransformJob.SpaceLocal  // 0x0
  public    static  UnityEngine.Animations.Rigging.OverrideTransformJob.SpacePivot  // 0x0
METHODS:
END_CLASS

CLASS: TransformSyncer
TYPE:  struct
TOKEN: 0x2000032
FIELDS:
  public            Unity.Collections.NativeArray<UnityEngine.Animations.TransformSceneHandle>sceneHandles  // 0x10
  public            Unity.Collections.NativeArray<UnityEngine.Animations.TransformStreamHandle>streamHandles  // 0x20
METHODS:
  UnityEngine.Animations.Rigging.RigSyncSceneToStreamJob.TransformSyncer Create(System.Int32 size)
  System.Void Dispose()
  System.Void BindAt(System.Int32 index, UnityEngine.Animator animator, UnityEngine.Transform transform)
  System.Void Sync(UnityEngine.Animations.AnimationStream& stream)
END_CLASS

CLASS: PropertySyncer
TYPE:  struct
TOKEN: 0x2000033
FIELDS:
  public            Unity.Collections.NativeArray<UnityEngine.Animations.PropertySceneHandle>sceneHandles  // 0x10
  public            Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle>streamHandles  // 0x20
  public            Unity.Collections.NativeArray<System.Single>buffer  // 0x30
METHODS:
  UnityEngine.Animations.Rigging.RigSyncSceneToStreamJob.PropertySyncer Create(System.Int32 size)
  System.Void Dispose()
  System.Void BindAt(System.Int32 index, UnityEngine.Animator animator, UnityEngine.Component component, System.String property)
  System.Void Sync(UnityEngine.Animations.AnimationStream& stream)
  Unity.Collections.NativeArray<System.Single> StreamValues(UnityEngine.Animations.AnimationStream& stream)
END_CLASS

CLASS: Axis
TYPE:  struct
TOKEN: 0x200004A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Animations.Rigging.MultiAimConstraintData.AxisX  // 0x0
  public    static  UnityEngine.Animations.Rigging.MultiAimConstraintData.AxisX_NEG  // 0x0
  public    static  UnityEngine.Animations.Rigging.MultiAimConstraintData.AxisY  // 0x0
  public    static  UnityEngine.Animations.Rigging.MultiAimConstraintData.AxisY_NEG  // 0x0
  public    static  UnityEngine.Animations.Rigging.MultiAimConstraintData.AxisZ  // 0x0
  public    static  UnityEngine.Animations.Rigging.MultiAimConstraintData.AxisZ_NEG  // 0x0
METHODS:
END_CLASS

CLASS: WorldUpType
TYPE:  struct
TOKEN: 0x200004B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Animations.Rigging.MultiAimConstraintData.WorldUpTypeNone  // 0x0
  public    static  UnityEngine.Animations.Rigging.MultiAimConstraintData.WorldUpTypeSceneUp  // 0x0
  public    static  UnityEngine.Animations.Rigging.MultiAimConstraintData.WorldUpTypeObjectUp  // 0x0
  public    static  UnityEngine.Animations.Rigging.MultiAimConstraintData.WorldUpTypeObjectRotationUp  // 0x0
  public    static  UnityEngine.Animations.Rigging.MultiAimConstraintData.WorldUpTypeVector  // 0x0
METHODS:
END_CLASS

CLASS: Space
TYPE:  struct
TOKEN: 0x2000056
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Animations.Rigging.OverrideTransformData.SpaceWorld  // 0x0
  public    static  UnityEngine.Animations.Rigging.OverrideTransformData.SpaceLocal  // 0x0
  public    static  UnityEngine.Animations.Rigging.OverrideTransformData.SpacePivot  // 0x0
METHODS:
END_CLASS

CLASS: Axis
TYPE:  struct
TOKEN: 0x200005B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Animations.Rigging.TwistCorrectionData.AxisX  // 0x0
  public    static  UnityEngine.Animations.Rigging.TwistCorrectionData.AxisY  // 0x0
  public    static  UnityEngine.Animations.Rigging.TwistCorrectionData.AxisZ  // 0x0
METHODS:
END_CLASS

CLASS: OnAddRigBuilderCallback
TYPE:  class
TOKEN: 0x2000065
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Animations.Rigging.RigBuilder rigBuilder)
  System.IAsyncResult BeginInvoke(UnityEngine.Animations.Rigging.RigBuilder rigBuilder, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: OnRemoveRigBuilderCallback
TYPE:  class
TOKEN: 0x2000066
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Animations.Rigging.RigBuilder rigBuilder)
  System.IAsyncResult BeginInvoke(UnityEngine.Animations.Rigging.RigBuilder rigBuilder, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: PlayableChain
TYPE:  struct
TOKEN: 0x2000068
FIELDS:
  public            System.String                   name  // 0x10
  public            UnityEngine.Playables.Playable[]playables  // 0x18
METHODS:
  System.Boolean IsValid()
END_CLASS

CLASS: RigSyncSceneToStreamData
TYPE:  struct
TOKEN: 0x200006D
FIELDS:
  private           UnityEngine.Transform[]         <syncableTransforms>k__BackingField  // 0x10
  private           UnityEngine.Animations.Rigging.SyncableProperties[]<syncableProperties>k__BackingField  // 0x18
  private           System.Boolean[]                <rigStates>k__BackingField  // 0x20
  private   readonly System.Boolean                  m_IsValid  // 0x28
METHODS:
  System.Void .ctor(UnityEngine.Transform[] transforms, UnityEngine.Animations.Rigging.SyncableProperties[] properties, System.Int32 rigCount)
  System.Int32[] UniqueTransformIndices(UnityEngine.Transform[] transforms)
  UnityEngine.Transform[] get_syncableTransforms()
  System.Void set_syncableTransforms(UnityEngine.Transform[] value)
  UnityEngine.Animations.Rigging.SyncableProperties[] get_syncableProperties()
  System.Void set_syncableProperties(UnityEngine.Animations.Rigging.SyncableProperties[] value)
  System.Boolean[] get_rigStates()
  System.Void set_rigStates(System.Boolean[] value)
  System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid()
  System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000074
FIELDS:
  private           UnityEngine.Animations.Rigging.WeightedTransformArraym_Array  // 0x10
  private           System.Int32                    m_Index  // 0x98
METHODS:
  System.Void .ctor(UnityEngine.Animations.Rigging.WeightedTransformArray& array)
  System.Boolean MoveNext()
  System.Void Reset()
  System.Void System.IDisposable.Dispose()
  UnityEngine.Animations.Rigging.WeightedTransform get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: Style
TYPE:  struct
TOKEN: 0x2000080
FIELDS:
  public            UnityEngine.Mesh                shape  // 0x10
  public            UnityEngine.Color               color  // 0x18
  public            System.Single                   size  // 0x28
  public            UnityEngine.Vector3             position  // 0x2C
  public            UnityEngine.Vector3             rotation  // 0x38
METHODS:
END_CLASS

CLASS: BoneShape
TYPE:  struct
TOKEN: 0x2000084
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Animations.Rigging.BoneRenderer.BoneShapeLine  // 0x0
  public    static  UnityEngine.Animations.Rigging.BoneRenderer.BoneShapePyramid  // 0x0
  public    static  UnityEngine.Animations.Rigging.BoneRenderer.BoneShapeBox  // 0x0
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

CLASS: UnityEngine.Animations.Rigging.CacheIndex
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  private           System.Int32                    idx  // 0x10
METHODS:
END_CLASS

CLASS: UnityEngine.Animations.Rigging.AnimationJobCache
TYPE:  struct
TOKEN: 0x2000005
FIELDS:
  private           Unity.Collections.NativeArray<System.Single>m_Data  // 0x10
METHODS:
  System.Void .ctor(System.Single[] data)
  System.Void Dispose()
  System.Single GetRaw(UnityEngine.Animations.Rigging.CacheIndex index, System.Int32 offset)
  System.Void SetRaw(System.Single val, UnityEngine.Animations.Rigging.CacheIndex index, System.Int32 offset)
  T Get(UnityEngine.Animations.Rigging.CacheIndex index, System.Int32 offset)
  System.Void Set(T val, UnityEngine.Animations.Rigging.CacheIndex index, System.Int32 offset)
  System.Void SetArray(T[] v, UnityEngine.Animations.Rigging.CacheIndex index, System.Int32 offset)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.AnimationJobCacheBuilder
TYPE:  class
TOKEN: 0x2000006
FIELDS:
  private           System.Collections.Generic.List<System.Single>m_Data  // 0x10
METHODS:
  System.Void .ctor()
  UnityEngine.Animations.Rigging.CacheIndex Add(System.Single v)
  UnityEngine.Animations.Rigging.CacheIndex Add(UnityEngine.Vector2 v)
  UnityEngine.Animations.Rigging.CacheIndex Add(UnityEngine.Vector3 v)
  UnityEngine.Animations.Rigging.CacheIndex Add(UnityEngine.Vector4 v)
  UnityEngine.Animations.Rigging.CacheIndex Add(UnityEngine.Quaternion v)
  UnityEngine.Animations.Rigging.CacheIndex Add(UnityEngine.Animations.Rigging.AffineTransform tx)
  UnityEngine.Animations.Rigging.CacheIndex AllocateChunk(System.Int32 size)
  System.Void SetValue(UnityEngine.Animations.Rigging.CacheIndex index, System.Int32 offset, System.Single value)
  UnityEngine.Animations.Rigging.AnimationJobCache Build()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.BlendConstraintJob
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  private   static  System.Int32                    k_BlendTranslationMask  // 0x0
  private   static  System.Int32                    k_BlendRotationMask  // 0x0
  public            UnityEngine.Animations.Rigging.ReadWriteTransformHandledriven  // 0x10
  public            UnityEngine.Animations.Rigging.ReadOnlyTransformHandlesourceA  // 0x1C
  public            UnityEngine.Animations.Rigging.ReadOnlyTransformHandlesourceB  // 0x34
  public            UnityEngine.Animations.Rigging.AffineTransformsourceAOffset  // 0x4C
  public            UnityEngine.Animations.Rigging.AffineTransformsourceBOffset  // 0x68
  public            UnityEngine.Animations.Rigging.BoolPropertyblendPosition  // 0x84
  public            UnityEngine.Animations.Rigging.BoolPropertyblendRotation  // 0x94
  public            UnityEngine.Animations.Rigging.FloatPropertypositionWeight  // 0xA4
  public            UnityEngine.Animations.Rigging.FloatPropertyrotationWeight  // 0xB4
  private           UnityEngine.Animations.Rigging.FloatProperty<jobWeight>k__BackingField  // 0xC4
METHODS:
  UnityEngine.Animations.Rigging.FloatProperty get_jobWeight()
  System.Void set_jobWeight(UnityEngine.Animations.Rigging.FloatProperty value)
  System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream)
  System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.IBlendConstraintData
TYPE:  interface
TOKEN: 0x2000008
FIELDS:
METHODS:
  UnityEngine.Transform get_constrainedObject()
  UnityEngine.Transform get_sourceObjectA()
  UnityEngine.Transform get_sourceObjectB()
  System.Boolean get_maintainPositionOffsets()
  System.Boolean get_maintainRotationOffsets()
  System.String get_blendPositionBoolProperty()
  System.String get_blendRotationBoolProperty()
  System.String get_positionWeightFloatProperty()
  System.String get_rotationWeightFloatProperty()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.BlendConstraintJobBinder`1
TYPE:  class
TOKEN: 0x2000009
EXTENDS: AnimationJobBinder`2
FIELDS:
METHODS:
  UnityEngine.Animations.Rigging.BlendConstraintJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component)
  System.Void Destroy(UnityEngine.Animations.Rigging.BlendConstraintJob job)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.ChainIKConstraintJob
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.ReadWriteTransformHandle>chain  // 0x10
  public            UnityEngine.Animations.Rigging.ReadOnlyTransformHandletarget  // 0x20
  public            UnityEngine.Animations.Rigging.AffineTransformtargetOffset  // 0x38
  public            Unity.Collections.NativeArray<System.Single>linkLengths  // 0x58
  public            Unity.Collections.NativeArray<UnityEngine.Vector3>linkPositions  // 0x68
  public            UnityEngine.Animations.Rigging.FloatPropertychainRotationWeight  // 0x78
  public            UnityEngine.Animations.Rigging.FloatPropertytipRotationWeight  // 0x88
  public            UnityEngine.Animations.Rigging.CacheIndextoleranceIdx  // 0x98
  public            UnityEngine.Animations.Rigging.CacheIndexmaxIterationsIdx  // 0x9C
  public            UnityEngine.Animations.Rigging.AnimationJobCachecache  // 0xA0
  public            System.Single                   maxReach  // 0xB0
  private           UnityEngine.Animations.Rigging.FloatProperty<jobWeight>k__BackingField  // 0xB4
METHODS:
  UnityEngine.Animations.Rigging.FloatProperty get_jobWeight()
  System.Void set_jobWeight(UnityEngine.Animations.Rigging.FloatProperty value)
  System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream)
  System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.IChainIKConstraintData
TYPE:  interface
TOKEN: 0x200000B
FIELDS:
METHODS:
  UnityEngine.Transform get_root()
  UnityEngine.Transform get_tip()
  UnityEngine.Transform get_target()
  System.Int32 get_maxIterations()
  System.Single get_tolerance()
  System.Boolean get_maintainTargetPositionOffset()
  System.Boolean get_maintainTargetRotationOffset()
  System.String get_chainRotationWeightFloatProperty()
  System.String get_tipRotationWeightFloatProperty()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.ChainIKConstraintJobBinder`1
TYPE:  class
TOKEN: 0x200000C
EXTENDS: AnimationJobBinder`2
FIELDS:
METHODS:
  UnityEngine.Animations.Rigging.ChainIKConstraintJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component)
  System.Void Destroy(UnityEngine.Animations.Rigging.ChainIKConstraintJob job)
  System.Void Update(UnityEngine.Animations.Rigging.ChainIKConstraintJob job, T& data)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.DampedTransformJob
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
  private   static  System.Single                   k_FixedDt  // 0x0
  private   static  System.Single                   k_DampFactor  // 0x0
  public            UnityEngine.Animations.Rigging.ReadWriteTransformHandledriven  // 0x10
  public            UnityEngine.Animations.Rigging.ReadOnlyTransformHandlesource  // 0x1C
  public            UnityEngine.Animations.Rigging.AffineTransformlocalBindTx  // 0x34
  public            UnityEngine.Vector3             aimBindAxis  // 0x50
  public            UnityEngine.Animations.Rigging.AffineTransformprevDrivenTx  // 0x5C
  public            UnityEngine.Animations.Rigging.FloatPropertydampPosition  // 0x78
  public            UnityEngine.Animations.Rigging.FloatPropertydampRotation  // 0x88
  private           UnityEngine.Animations.Rigging.FloatProperty<jobWeight>k__BackingField  // 0x98
METHODS:
  UnityEngine.Animations.Rigging.FloatProperty get_jobWeight()
  System.Void set_jobWeight(UnityEngine.Animations.Rigging.FloatProperty value)
  System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream)
  System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.IDampedTransformData
TYPE:  interface
TOKEN: 0x200000E
FIELDS:
METHODS:
  UnityEngine.Transform get_constrainedObject()
  UnityEngine.Transform get_sourceObject()
  System.Boolean get_maintainAim()
  System.String get_dampPositionFloatProperty()
  System.String get_dampRotationFloatProperty()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.DampedTransformJobBinder`1
TYPE:  class
TOKEN: 0x200000F
EXTENDS: AnimationJobBinder`2
FIELDS:
METHODS:
  UnityEngine.Animations.Rigging.DampedTransformJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component)
  System.Void Destroy(UnityEngine.Animations.Rigging.DampedTransformJob job)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.IAnimatableProperty`1
TYPE:  interface
TOKEN: 0x2000010
FIELDS:
METHODS:
  T Get(UnityEngine.Animations.AnimationStream stream)
  System.Void Set(UnityEngine.Animations.AnimationStream stream, T value)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.BoolProperty
TYPE:  struct
TOKEN: 0x2000011
FIELDS:
  public            UnityEngine.Animations.PropertyStreamHandlevalue  // 0x10
METHODS:
  UnityEngine.Animations.Rigging.BoolProperty Bind(UnityEngine.Animator animator, UnityEngine.Component component, System.String name)
  UnityEngine.Animations.Rigging.BoolProperty BindCustom(UnityEngine.Animator animator, System.String property)
  System.Boolean Get(UnityEngine.Animations.AnimationStream stream)
  System.Void Set(UnityEngine.Animations.AnimationStream stream, System.Boolean v)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.IntProperty
TYPE:  struct
TOKEN: 0x2000012
FIELDS:
  public            UnityEngine.Animations.PropertyStreamHandlevalue  // 0x10
METHODS:
  UnityEngine.Animations.Rigging.IntProperty Bind(UnityEngine.Animator animator, UnityEngine.Component component, System.String name)
  UnityEngine.Animations.Rigging.IntProperty BindCustom(UnityEngine.Animator animator, System.String property)
  System.Int32 Get(UnityEngine.Animations.AnimationStream stream)
  System.Void Set(UnityEngine.Animations.AnimationStream stream, System.Int32 v)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.FloatProperty
TYPE:  struct
TOKEN: 0x2000013
FIELDS:
  public            UnityEngine.Animations.PropertyStreamHandlevalue  // 0x10
METHODS:
  UnityEngine.Animations.Rigging.FloatProperty Bind(UnityEngine.Animator animator, UnityEngine.Component component, System.String name)
  UnityEngine.Animations.Rigging.FloatProperty BindCustom(UnityEngine.Animator animator, System.String property)
  System.Single Get(UnityEngine.Animations.AnimationStream stream)
  System.Void Set(UnityEngine.Animations.AnimationStream stream, System.Single v)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.Vector2Property
TYPE:  struct
TOKEN: 0x2000014
FIELDS:
  public            UnityEngine.Animations.PropertyStreamHandlex  // 0x10
  public            UnityEngine.Animations.PropertyStreamHandley  // 0x20
METHODS:
  UnityEngine.Animations.Rigging.Vector2Property Bind(UnityEngine.Animator animator, UnityEngine.Component component, System.String name)
  UnityEngine.Animations.Rigging.Vector2Property BindCustom(UnityEngine.Animator animator, System.String name)
  UnityEngine.Vector2 Get(UnityEngine.Animations.AnimationStream stream)
  System.Void Set(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector2 value)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.Vector3Property
TYPE:  struct
TOKEN: 0x2000015
FIELDS:
  public            UnityEngine.Animations.PropertyStreamHandlex  // 0x10
  public            UnityEngine.Animations.PropertyStreamHandley  // 0x20
  public            UnityEngine.Animations.PropertyStreamHandlez  // 0x30
METHODS:
  UnityEngine.Animations.Rigging.Vector3Property Bind(UnityEngine.Animator animator, UnityEngine.Component component, System.String name)
  UnityEngine.Animations.Rigging.Vector3Property BindCustom(UnityEngine.Animator animator, System.String name)
  UnityEngine.Vector3 Get(UnityEngine.Animations.AnimationStream stream)
  System.Void Set(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 value)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.Vector3IntProperty
TYPE:  struct
TOKEN: 0x2000016
FIELDS:
  public            UnityEngine.Animations.PropertyStreamHandlex  // 0x10
  public            UnityEngine.Animations.PropertyStreamHandley  // 0x20
  public            UnityEngine.Animations.PropertyStreamHandlez  // 0x30
METHODS:
  UnityEngine.Animations.Rigging.Vector3IntProperty Bind(UnityEngine.Animator animator, UnityEngine.Component component, System.String name)
  UnityEngine.Animations.Rigging.Vector3IntProperty BindCustom(UnityEngine.Animator animator, System.String name)
  UnityEngine.Vector3Int Get(UnityEngine.Animations.AnimationStream stream)
  System.Void Set(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3Int value)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.Vector3BoolProperty
TYPE:  struct
TOKEN: 0x2000017
FIELDS:
  public            UnityEngine.Animations.PropertyStreamHandlex  // 0x10
  public            UnityEngine.Animations.PropertyStreamHandley  // 0x20
  public            UnityEngine.Animations.PropertyStreamHandlez  // 0x30
METHODS:
  UnityEngine.Animations.Rigging.Vector3BoolProperty Bind(UnityEngine.Animator animator, UnityEngine.Component component, System.String name)
  UnityEngine.Animations.Rigging.Vector3BoolProperty BindCustom(UnityEngine.Animator animator, System.String name)
  UnityEngine.Animations.Rigging.Vector3Bool Get(UnityEngine.Animations.AnimationStream stream)
  System.Void Set(UnityEngine.Animations.AnimationStream stream, UnityEngine.Animations.Rigging.Vector3Bool value)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.Vector4Property
TYPE:  struct
TOKEN: 0x2000018
FIELDS:
  public            UnityEngine.Animations.PropertyStreamHandlex  // 0x10
  public            UnityEngine.Animations.PropertyStreamHandley  // 0x20
  public            UnityEngine.Animations.PropertyStreamHandlez  // 0x30
  public            UnityEngine.Animations.PropertyStreamHandlew  // 0x40
METHODS:
  UnityEngine.Animations.Rigging.Vector4Property Bind(UnityEngine.Animator animator, UnityEngine.Component component, System.String name)
  UnityEngine.Animations.Rigging.Vector4Property BindCustom(UnityEngine.Animator animator, System.String name)
  UnityEngine.Vector4 Get(UnityEngine.Animations.AnimationStream stream)
  System.Void Set(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector4 value)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.IAnimationJobBinder
TYPE:  interface
TOKEN: 0x2000019
FIELDS:
METHODS:
  UnityEngine.Animations.IAnimationJob Create(UnityEngine.Animator animator, UnityEngine.Animations.Rigging.IAnimationJobData data, UnityEngine.Component component)
  System.Void Destroy(UnityEngine.Animations.IAnimationJob job)
  System.Void Update(UnityEngine.Animations.IAnimationJob job, UnityEngine.Animations.Rigging.IAnimationJobData data)
  UnityEngine.Animations.AnimationScriptPlayable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animations.IAnimationJob job)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.AnimationJobBinder`2
TYPE:  class
TOKEN: 0x200001A
FIELDS:
METHODS:
  TJob Create(UnityEngine.Animator animator, TData& data, UnityEngine.Component component)
  System.Void Destroy(TJob job)
  System.Void Update(TJob job, TData& data)
  UnityEngine.Animations.IAnimationJob UnityEngine.Animations.Rigging.IAnimationJobBinder.Create(UnityEngine.Animator animator, UnityEngine.Animations.Rigging.IAnimationJobData data, UnityEngine.Component component)
  System.Void UnityEngine.Animations.Rigging.IAnimationJobBinder.Destroy(UnityEngine.Animations.IAnimationJob job)
  System.Void UnityEngine.Animations.Rigging.IAnimationJobBinder.Update(UnityEngine.Animations.IAnimationJob job, UnityEngine.Animations.Rigging.IAnimationJobData data)
  UnityEngine.Animations.AnimationScriptPlayable UnityEngine.Animations.Rigging.IAnimationJobBinder.CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animations.IAnimationJob job)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.IAnimationJobData
TYPE:  interface
TOKEN: 0x200001B
FIELDS:
METHODS:
  System.Boolean IsValid()
  System.Void SetDefaultValues()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.IWeightedAnimationJob
TYPE:  interface
TOKEN: 0x200001C
FIELDS:
METHODS:
  UnityEngine.Animations.Rigging.FloatProperty get_jobWeight()
  System.Void set_jobWeight(UnityEngine.Animations.Rigging.FloatProperty value)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.MultiAimConstraintJob
TYPE:  struct
TOKEN: 0x200001D
FIELDS:
  private   static  System.Single                   k_Epsilon  // 0x0
  public            UnityEngine.Animations.Rigging.ReadWriteTransformHandledriven  // 0x10
  public            UnityEngine.Animations.Rigging.ReadOnlyTransformHandledrivenParent  // 0x1C
  public            UnityEngine.Animations.Rigging.Vector3PropertydrivenOffset  // 0x34
  public            Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.ReadOnlyTransformHandle>sourceTransforms  // 0x68
  public            Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle>sourceWeights  // 0x78
  public            Unity.Collections.NativeArray<UnityEngine.Quaternion>sourceOffsets  // 0x88
  public            Unity.Collections.NativeArray<System.Single>weightBuffer  // 0x98
  public            UnityEngine.Vector3             aimAxis  // 0xA8
  public            UnityEngine.Vector3             upAxis  // 0xB4
  public            UnityEngine.Animations.Rigging.MultiAimConstraintJob.WorldUpTypeworldUpType  // 0xC0
  public            UnityEngine.Vector3             worldUpAxis  // 0xC4
  public            UnityEngine.Animations.Rigging.ReadOnlyTransformHandleworldUpObject  // 0xD0
  public            UnityEngine.Vector3             axesMask  // 0xE8
  public            UnityEngine.Animations.Rigging.FloatPropertyminLimit  // 0xF4
  public            UnityEngine.Animations.Rigging.FloatPropertymaxLimit  // 0x104
  private           UnityEngine.Animations.Rigging.FloatProperty<jobWeight>k__BackingField  // 0x114
METHODS:
  UnityEngine.Animations.Rigging.FloatProperty get_jobWeight()
  System.Void set_jobWeight(UnityEngine.Animations.Rigging.FloatProperty value)
  System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream)
  System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream)
  UnityEngine.Vector3 ComputeWorldUpVector(UnityEngine.Animations.AnimationStream stream)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.IMultiAimConstraintData
TYPE:  interface
TOKEN: 0x200001F
FIELDS:
METHODS:
  UnityEngine.Transform get_constrainedObject()
  UnityEngine.Animations.Rigging.WeightedTransformArray get_sourceObjects()
  System.Boolean get_maintainOffset()
  UnityEngine.Vector3 get_aimAxis()
  UnityEngine.Vector3 get_upAxis()
  System.Int32 get_worldUpType()
  UnityEngine.Vector3 get_worldUpAxis()
  UnityEngine.Transform get_worldUpObject()
  System.Boolean get_constrainedXAxis()
  System.Boolean get_constrainedYAxis()
  System.Boolean get_constrainedZAxis()
  System.String get_offsetVector3Property()
  System.String get_minLimitFloatProperty()
  System.String get_maxLimitFloatProperty()
  System.String get_sourceObjectsProperty()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.MultiAimConstraintJobBinder`1
TYPE:  class
TOKEN: 0x2000020
EXTENDS: AnimationJobBinder`2
FIELDS:
METHODS:
  UnityEngine.Animations.Rigging.MultiAimConstraintJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component)
  System.Void Destroy(UnityEngine.Animations.Rigging.MultiAimConstraintJob job)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.MultiParentConstraintJob
TYPE:  struct
TOKEN: 0x2000021
FIELDS:
  private   static  System.Single                   k_Epsilon  // 0x0
  public            UnityEngine.Animations.Rigging.ReadWriteTransformHandledriven  // 0x10
  public            UnityEngine.Animations.Rigging.ReadOnlyTransformHandledrivenParent  // 0x1C
  public            Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.ReadOnlyTransformHandle>sourceTransforms  // 0x38
  public            Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle>sourceWeights  // 0x48
  public            Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.AffineTransform>sourceOffsets  // 0x58
  public            Unity.Collections.NativeArray<System.Single>weightBuffer  // 0x68
  public            UnityEngine.Vector3             positionAxesMask  // 0x78
  public            UnityEngine.Vector3             rotationAxesMask  // 0x84
  private           UnityEngine.Animations.Rigging.FloatProperty<jobWeight>k__BackingField  // 0x90
METHODS:
  UnityEngine.Animations.Rigging.FloatProperty get_jobWeight()
  System.Void set_jobWeight(UnityEngine.Animations.Rigging.FloatProperty value)
  System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream)
  System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.IMultiParentConstraintData
TYPE:  interface
TOKEN: 0x2000022
FIELDS:
METHODS:
  UnityEngine.Transform get_constrainedObject()
  UnityEngine.Animations.Rigging.WeightedTransformArray get_sourceObjects()
  System.Boolean get_maintainPositionOffset()
  System.Boolean get_maintainRotationOffset()
  System.Boolean get_constrainedPositionXAxis()
  System.Boolean get_constrainedPositionYAxis()
  System.Boolean get_constrainedPositionZAxis()
  System.Boolean get_constrainedRotationXAxis()
  System.Boolean get_constrainedRotationYAxis()
  System.Boolean get_constrainedRotationZAxis()
  System.String get_sourceObjectsProperty()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.MultiParentConstraintJobBinder`1
TYPE:  class
TOKEN: 0x2000023
EXTENDS: AnimationJobBinder`2
FIELDS:
METHODS:
  UnityEngine.Animations.Rigging.MultiParentConstraintJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component)
  System.Void Destroy(UnityEngine.Animations.Rigging.MultiParentConstraintJob job)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.MultiPositionConstraintJob
TYPE:  struct
TOKEN: 0x2000024
FIELDS:
  private   static  System.Single                   k_Epsilon  // 0x0
  public            UnityEngine.Animations.Rigging.ReadWriteTransformHandledriven  // 0x10
  public            UnityEngine.Animations.Rigging.ReadOnlyTransformHandledrivenParent  // 0x1C
  public            UnityEngine.Animations.Rigging.Vector3PropertydrivenOffset  // 0x34
  public            Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.ReadOnlyTransformHandle>sourceTransforms  // 0x68
  public            Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle>sourceWeights  // 0x78
  public            Unity.Collections.NativeArray<UnityEngine.Vector3>sourceOffsets  // 0x88
  public            Unity.Collections.NativeArray<System.Single>weightBuffer  // 0x98
  public            UnityEngine.Vector3             axesMask  // 0xA8
  private           UnityEngine.Animations.Rigging.FloatProperty<jobWeight>k__BackingField  // 0xB4
METHODS:
  UnityEngine.Animations.Rigging.FloatProperty get_jobWeight()
  System.Void set_jobWeight(UnityEngine.Animations.Rigging.FloatProperty value)
  System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream)
  System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.IMultiPositionConstraintData
TYPE:  interface
TOKEN: 0x2000025
FIELDS:
METHODS:
  UnityEngine.Transform get_constrainedObject()
  UnityEngine.Animations.Rigging.WeightedTransformArray get_sourceObjects()
  System.Boolean get_maintainOffset()
  System.String get_offsetVector3Property()
  System.String get_sourceObjectsProperty()
  System.Boolean get_constrainedXAxis()
  System.Boolean get_constrainedYAxis()
  System.Boolean get_constrainedZAxis()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.MultiPositionConstraintJobBinder`1
TYPE:  class
TOKEN: 0x2000026
EXTENDS: AnimationJobBinder`2
FIELDS:
METHODS:
  UnityEngine.Animations.Rigging.MultiPositionConstraintJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component)
  System.Void Destroy(UnityEngine.Animations.Rigging.MultiPositionConstraintJob job)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.MultiReferentialConstraintJob
TYPE:  struct
TOKEN: 0x2000027
FIELDS:
  public            UnityEngine.Animations.Rigging.IntPropertydriver  // 0x10
  public            Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.ReadWriteTransformHandle>sources  // 0x20
  public            Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.AffineTransform>sourceBindTx  // 0x30
  public            Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.AffineTransform>offsetTx  // 0x40
  private           System.Int32                    m_PrevDriverIdx  // 0x50
  private           UnityEngine.Animations.Rigging.FloatProperty<jobWeight>k__BackingField  // 0x54
METHODS:
  UnityEngine.Animations.Rigging.FloatProperty get_jobWeight()
  System.Void set_jobWeight(UnityEngine.Animations.Rigging.FloatProperty value)
  System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream)
  System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream)
  System.Void UpdateOffsets(System.Int32 driver)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.IMultiReferentialConstraintData
TYPE:  interface
TOKEN: 0x2000028
FIELDS:
METHODS:
  System.Int32 get_driverValue()
  System.String get_driverIntProperty()
  UnityEngine.Transform[] get_sourceObjects()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.MultiReferentialConstraintJobBinder`1
TYPE:  class
TOKEN: 0x2000029
EXTENDS: AnimationJobBinder`2
FIELDS:
METHODS:
  UnityEngine.Animations.Rigging.MultiReferentialConstraintJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component)
  System.Void Destroy(UnityEngine.Animations.Rigging.MultiReferentialConstraintJob job)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.MultiRotationConstraintJob
TYPE:  struct
TOKEN: 0x200002A
FIELDS:
  private   static  System.Single                   k_Epsilon  // 0x0
  public            UnityEngine.Animations.Rigging.ReadWriteTransformHandledriven  // 0x10
  public            UnityEngine.Animations.Rigging.ReadOnlyTransformHandledrivenParent  // 0x1C
  public            UnityEngine.Animations.Rigging.Vector3PropertydrivenOffset  // 0x34
  public            Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.ReadOnlyTransformHandle>sourceTransforms  // 0x68
  public            Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle>sourceWeights  // 0x78
  public            Unity.Collections.NativeArray<UnityEngine.Quaternion>sourceOffsets  // 0x88
  public            Unity.Collections.NativeArray<System.Single>weightBuffer  // 0x98
  public            UnityEngine.Vector3             axesMask  // 0xA8
  private           UnityEngine.Animations.Rigging.FloatProperty<jobWeight>k__BackingField  // 0xB4
METHODS:
  UnityEngine.Animations.Rigging.FloatProperty get_jobWeight()
  System.Void set_jobWeight(UnityEngine.Animations.Rigging.FloatProperty value)
  System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream)
  System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.IMultiRotationConstraintData
TYPE:  interface
TOKEN: 0x200002B
FIELDS:
METHODS:
  UnityEngine.Transform get_constrainedObject()
  UnityEngine.Animations.Rigging.WeightedTransformArray get_sourceObjects()
  System.Boolean get_maintainOffset()
  System.String get_offsetVector3Property()
  System.String get_sourceObjectsProperty()
  System.Boolean get_constrainedXAxis()
  System.Boolean get_constrainedYAxis()
  System.Boolean get_constrainedZAxis()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.MultiRotationConstraintJobBinder`1
TYPE:  class
TOKEN: 0x200002C
EXTENDS: AnimationJobBinder`2
FIELDS:
METHODS:
  UnityEngine.Animations.Rigging.MultiRotationConstraintJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component)
  System.Void Destroy(UnityEngine.Animations.Rigging.MultiRotationConstraintJob job)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.OverrideTransformJob
TYPE:  struct
TOKEN: 0x200002D
FIELDS:
  public            UnityEngine.Animations.Rigging.ReadWriteTransformHandledriven  // 0x10
  public            UnityEngine.Animations.Rigging.ReadOnlyTransformHandlesource  // 0x1C
  public            UnityEngine.Animations.Rigging.AffineTransformsourceInvLocalBindTx  // 0x34
  public            UnityEngine.Quaternion          sourceToWorldRot  // 0x50
  public            UnityEngine.Quaternion          sourceToLocalRot  // 0x60
  public            UnityEngine.Quaternion          sourceToPivotRot  // 0x70
  public            UnityEngine.Animations.Rigging.CacheIndexspaceIdx  // 0x80
  public            UnityEngine.Animations.Rigging.CacheIndexsourceToCurrSpaceRotIdx  // 0x84
  public            UnityEngine.Animations.Rigging.Vector3Propertyposition  // 0x88
  public            UnityEngine.Animations.Rigging.Vector3Propertyrotation  // 0xB8
  public            UnityEngine.Animations.Rigging.FloatPropertypositionWeight  // 0xE8
  public            UnityEngine.Animations.Rigging.FloatPropertyrotationWeight  // 0xF8
  public            UnityEngine.Animations.Rigging.AnimationJobCachecache  // 0x108
  private           UnityEngine.Animations.Rigging.FloatProperty<jobWeight>k__BackingField  // 0x118
METHODS:
  UnityEngine.Animations.Rigging.FloatProperty get_jobWeight()
  System.Void set_jobWeight(UnityEngine.Animations.Rigging.FloatProperty value)
  System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream)
  System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream)
  System.Void UpdateSpace(System.Int32 space)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.IOverrideTransformData
TYPE:  interface
TOKEN: 0x200002F
FIELDS:
METHODS:
  UnityEngine.Transform get_constrainedObject()
  UnityEngine.Transform get_sourceObject()
  System.Int32 get_space()
  System.String get_positionWeightFloatProperty()
  System.String get_rotationWeightFloatProperty()
  System.String get_positionVector3Property()
  System.String get_rotationVector3Property()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.OverrideTransformJobBinder`1
TYPE:  class
TOKEN: 0x2000030
EXTENDS: AnimationJobBinder`2
FIELDS:
METHODS:
  UnityEngine.Animations.Rigging.OverrideTransformJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component)
  System.Void Destroy(UnityEngine.Animations.Rigging.OverrideTransformJob job)
  System.Void Update(UnityEngine.Animations.Rigging.OverrideTransformJob job, T& data)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.RigSyncSceneToStreamJob
TYPE:  struct
TOKEN: 0x2000031
FIELDS:
  public            UnityEngine.Animations.Rigging.RigSyncSceneToStreamJob.TransformSyncertransformSyncer  // 0x10
  public            UnityEngine.Animations.Rigging.RigSyncSceneToStreamJob.PropertySyncerpropertySyncer  // 0x30
  public            UnityEngine.Animations.Rigging.RigSyncSceneToStreamJob.PropertySyncerrigWeightSyncer  // 0x60
  public            UnityEngine.Animations.Rigging.RigSyncSceneToStreamJob.PropertySyncerconstraintWeightSyncer  // 0x90
  public            Unity.Collections.NativeArray<System.Single>rigStates  // 0xC0
  public            Unity.Collections.NativeArray<System.Int32>rigConstraintEndIdx  // 0xD0
  public            Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle>modulatedConstraintWeights  // 0xE0
METHODS:
  System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream)
  System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.SyncableProperties
TYPE:  struct
TOKEN: 0x2000034
FIELDS:
  public            UnityEngine.Animations.Rigging.RigPropertiesrig  // 0x10
  public            UnityEngine.Animations.Rigging.ConstraintProperties[]constraints  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.Animations.Rigging.IRigSyncSceneToStreamData
TYPE:  interface
TOKEN: 0x2000035
FIELDS:
METHODS:
  UnityEngine.Transform[] get_syncableTransforms()
  UnityEngine.Animations.Rigging.SyncableProperties[] get_syncableProperties()
  System.Boolean[] get_rigStates()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.RigSyncSceneToStreamJobBinder`1
TYPE:  class
TOKEN: 0x2000036
EXTENDS: AnimationJobBinder`2
FIELDS:
  private   static  System.String[]                 s_PropertyElementNames  // 0x0
METHODS:
  UnityEngine.Animations.Rigging.RigSyncSceneToStreamJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component)
  System.Void Destroy(UnityEngine.Animations.Rigging.RigSyncSceneToStreamJob job)
  System.Void Update(UnityEngine.Animations.Rigging.RigSyncSceneToStreamJob job, T& data)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.ReadWriteTransformHandle
TYPE:  struct
TOKEN: 0x2000037
FIELDS:
  private           UnityEngine.Animations.TransformStreamHandlem_Handle  // 0x10
METHODS:
  UnityEngine.Vector3 GetLocalPosition(UnityEngine.Animations.AnimationStream stream)
  UnityEngine.Quaternion GetLocalRotation(UnityEngine.Animations.AnimationStream stream)
  UnityEngine.Vector3 GetLocalScale(UnityEngine.Animations.AnimationStream stream)
  System.Void GetLocalTRS(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale)
  System.Void SetLocalPosition(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position)
  System.Void SetLocalRotation(UnityEngine.Animations.AnimationStream stream, UnityEngine.Quaternion rotation)
  System.Void SetLocalScale(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 scale)
  System.Void SetLocalTRS(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale, System.Boolean useMask)
  UnityEngine.Vector3 GetPosition(UnityEngine.Animations.AnimationStream stream)
  UnityEngine.Quaternion GetRotation(UnityEngine.Animations.AnimationStream stream)
  System.Void GetGlobalTR(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation)
  System.Void SetPosition(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position)
  System.Void SetRotation(UnityEngine.Animations.AnimationStream stream, UnityEngine.Quaternion rotation)
  System.Void SetGlobalTR(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Boolean useMask)
  System.Boolean IsResolved(UnityEngine.Animations.AnimationStream stream)
  System.Boolean IsValid(UnityEngine.Animations.AnimationStream stream)
  System.Void Resolve(UnityEngine.Animations.AnimationStream stream)
  UnityEngine.Animations.Rigging.ReadWriteTransformHandle Bind(UnityEngine.Animator animator, UnityEngine.Transform transform)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.ReadOnlyTransformHandle
TYPE:  struct
TOKEN: 0x2000038
FIELDS:
  private           UnityEngine.Animations.TransformStreamHandlem_StreamHandle  // 0x10
  private           UnityEngine.Animations.TransformSceneHandlem_SceneHandle  // 0x1C
  private           System.Byte                     m_InStream  // 0x24
METHODS:
  UnityEngine.Vector3 GetLocalPosition(UnityEngine.Animations.AnimationStream stream)
  UnityEngine.Quaternion GetLocalRotation(UnityEngine.Animations.AnimationStream stream)
  UnityEngine.Vector3 GetLocalScale(UnityEngine.Animations.AnimationStream stream)
  System.Void GetLocalTRS(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale)
  UnityEngine.Vector3 GetPosition(UnityEngine.Animations.AnimationStream stream)
  UnityEngine.Quaternion GetRotation(UnityEngine.Animations.AnimationStream stream)
  System.Void GetGlobalTR(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation)
  System.Boolean IsResolved(UnityEngine.Animations.AnimationStream stream)
  System.Boolean IsValid(UnityEngine.Animations.AnimationStream stream)
  System.Void Resolve(UnityEngine.Animations.AnimationStream stream)
  UnityEngine.Animations.Rigging.ReadOnlyTransformHandle Bind(UnityEngine.Animator animator, UnityEngine.Transform transform)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.TwistChainConstraintJob
TYPE:  struct
TOKEN: 0x2000039
FIELDS:
  public            UnityEngine.Animations.Rigging.ReadWriteTransformHandlerootTarget  // 0x10
  public            UnityEngine.Animations.Rigging.ReadWriteTransformHandletipTarget  // 0x1C
  public            Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.ReadWriteTransformHandle>chain  // 0x28
  public            Unity.Collections.NativeArray<System.Single>steps  // 0x38
  public            Unity.Collections.NativeArray<System.Single>weights  // 0x48
  public            Unity.Collections.NativeArray<UnityEngine.Quaternion>rotations  // 0x58
  private           UnityEngine.Animations.Rigging.FloatProperty<jobWeight>k__BackingField  // 0x68
METHODS:
  UnityEngine.Animations.Rigging.FloatProperty get_jobWeight()
  System.Void set_jobWeight(UnityEngine.Animations.Rigging.FloatProperty value)
  System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream)
  System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.ITwistChainConstraintData
TYPE:  interface
TOKEN: 0x200003A
FIELDS:
METHODS:
  UnityEngine.Transform get_root()
  UnityEngine.Transform get_tip()
  UnityEngine.Transform get_rootTarget()
  UnityEngine.Transform get_tipTarget()
  UnityEngine.AnimationCurve get_curve()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.TwistChainConstraintJobBinder`1
TYPE:  class
TOKEN: 0x200003B
EXTENDS: AnimationJobBinder`2
FIELDS:
METHODS:
  UnityEngine.Animations.Rigging.TwistChainConstraintJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component)
  System.Void Destroy(UnityEngine.Animations.Rigging.TwistChainConstraintJob job)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.TwistCorrectionJob
TYPE:  struct
TOKEN: 0x200003C
FIELDS:
  public            UnityEngine.Animations.Rigging.ReadOnlyTransformHandlesource  // 0x10
  public            UnityEngine.Quaternion          sourceInverseBindRotation  // 0x28
  public            UnityEngine.Vector3             axisMask  // 0x38
  public            Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.ReadWriteTransformHandle>twistTransforms  // 0x48
  public            Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle>twistWeights  // 0x58
  public            Unity.Collections.NativeArray<UnityEngine.Quaternion>twistBindRotations  // 0x68
  public            Unity.Collections.NativeArray<System.Single>weightBuffer  // 0x78
  private           UnityEngine.Animations.Rigging.FloatProperty<jobWeight>k__BackingField  // 0x88
METHODS:
  UnityEngine.Animations.Rigging.FloatProperty get_jobWeight()
  System.Void set_jobWeight(UnityEngine.Animations.Rigging.FloatProperty value)
  System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream)
  System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream)
  UnityEngine.Quaternion TwistRotation(UnityEngine.Vector3 axis, UnityEngine.Quaternion rot)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.ITwistCorrectionData
TYPE:  interface
TOKEN: 0x200003D
FIELDS:
METHODS:
  UnityEngine.Transform get_source()
  UnityEngine.Animations.Rigging.WeightedTransformArray get_twistNodes()
  UnityEngine.Vector3 get_twistAxis()
  System.String get_twistNodesProperty()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.TwistCorrectionJobBinder`1
TYPE:  class
TOKEN: 0x200003E
EXTENDS: AnimationJobBinder`2
FIELDS:
METHODS:
  UnityEngine.Animations.Rigging.TwistCorrectionJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component)
  System.Void Destroy(UnityEngine.Animations.Rigging.TwistCorrectionJob job)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.TwoBoneIKConstraintJob
TYPE:  struct
TOKEN: 0x200003F
FIELDS:
  public            UnityEngine.Animations.Rigging.ReadWriteTransformHandleroot  // 0x10
  public            UnityEngine.Animations.Rigging.ReadWriteTransformHandlemid  // 0x1C
  public            UnityEngine.Animations.Rigging.ReadWriteTransformHandletip  // 0x28
  public            UnityEngine.Animations.Rigging.ReadOnlyTransformHandlehint  // 0x34
  public            UnityEngine.Animations.Rigging.ReadOnlyTransformHandletarget  // 0x4C
  public            UnityEngine.Animations.Rigging.AffineTransformtargetOffset  // 0x64
  public            UnityEngine.Animations.Rigging.FloatPropertytargetPositionWeight  // 0x80
  public            UnityEngine.Animations.Rigging.FloatPropertytargetRotationWeight  // 0x90
  public            UnityEngine.Animations.Rigging.FloatPropertyhintWeight  // 0xA0
  private           UnityEngine.Animations.Rigging.FloatProperty<jobWeight>k__BackingField  // 0xB0
METHODS:
  UnityEngine.Animations.Rigging.FloatProperty get_jobWeight()
  System.Void set_jobWeight(UnityEngine.Animations.Rigging.FloatProperty value)
  System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream)
  System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.ITwoBoneIKConstraintData
TYPE:  interface
TOKEN: 0x2000040
FIELDS:
METHODS:
  UnityEngine.Transform get_root()
  UnityEngine.Transform get_mid()
  UnityEngine.Transform get_tip()
  UnityEngine.Transform get_target()
  UnityEngine.Transform get_hint()
  System.Boolean get_maintainTargetPositionOffset()
  System.Boolean get_maintainTargetRotationOffset()
  System.String get_targetPositionWeightFloatProperty()
  System.String get_targetRotationWeightFloatProperty()
  System.String get_hintWeightFloatProperty()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.TwoBoneIKConstraintJobBinder`1
TYPE:  class
TOKEN: 0x2000041
EXTENDS: AnimationJobBinder`2
FIELDS:
METHODS:
  UnityEngine.Animations.Rigging.TwoBoneIKConstraintJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component)
  System.Void Destroy(UnityEngine.Animations.Rigging.TwoBoneIKConstraintJob job)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.WeightedTransformArrayBinder
TYPE:  class
TOKEN: 0x2000042
FIELDS:
METHODS:
  System.Void BindReadOnlyTransforms(UnityEngine.Animator animator, UnityEngine.Component component, UnityEngine.Animations.Rigging.WeightedTransformArray weightedTransformArray, Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.ReadOnlyTransformHandle>& transforms)
  System.Void BindReadWriteTransforms(UnityEngine.Animator animator, UnityEngine.Component component, UnityEngine.Animations.Rigging.WeightedTransformArray weightedTransformArray, Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.ReadWriteTransformHandle>& transforms)
  System.Void BindWeights(UnityEngine.Animator animator, UnityEngine.Component component, UnityEngine.Animations.Rigging.WeightedTransformArray weightedTransformArray, System.String name, Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle>& weights)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.BlendConstraintData
TYPE:  struct
TOKEN: 0x2000043
FIELDS:
  private           UnityEngine.Transform           m_ConstrainedObject  // 0x10
  private           UnityEngine.Transform           m_SourceA  // 0x18
  private           UnityEngine.Transform           m_SourceB  // 0x20
  private           System.Boolean                  m_BlendPosition  // 0x28
  private           System.Boolean                  m_BlendRotation  // 0x29
  private           System.Single                   m_PositionWeight  // 0x2C
  private           System.Single                   m_RotationWeight  // 0x30
  private           System.Boolean                  m_MaintainPositionOffsets  // 0x34
  private           System.Boolean                  m_MaintainRotationOffsets  // 0x35
METHODS:
  UnityEngine.Transform get_constrainedObject()
  System.Void set_constrainedObject(UnityEngine.Transform value)
  UnityEngine.Transform get_sourceObjectA()
  System.Void set_sourceObjectA(UnityEngine.Transform value)
  UnityEngine.Transform get_sourceObjectB()
  System.Void set_sourceObjectB(UnityEngine.Transform value)
  System.Boolean get_blendPosition()
  System.Void set_blendPosition(System.Boolean value)
  System.Boolean get_blendRotation()
  System.Void set_blendRotation(System.Boolean value)
  System.Single get_positionWeight()
  System.Void set_positionWeight(System.Single value)
  System.Single get_rotationWeight()
  System.Void set_rotationWeight(System.Single value)
  System.Boolean get_maintainPositionOffsets()
  System.Void set_maintainPositionOffsets(System.Boolean value)
  System.Boolean get_maintainRotationOffsets()
  System.Void set_maintainRotationOffsets(System.Boolean value)
  System.String UnityEngine.Animations.Rigging.IBlendConstraintData.get_blendPositionBoolProperty()
  System.String UnityEngine.Animations.Rigging.IBlendConstraintData.get_blendRotationBoolProperty()
  System.String UnityEngine.Animations.Rigging.IBlendConstraintData.get_positionWeightFloatProperty()
  System.String UnityEngine.Animations.Rigging.IBlendConstraintData.get_rotationWeightFloatProperty()
  System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid()
  System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.BlendConstraint
TYPE:  class
TOKEN: 0x2000044
EXTENDS: RigConstraint`3
FIELDS:
METHODS:
  System.Void OnValidate()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.ChainIKConstraintData
TYPE:  struct
TOKEN: 0x2000045
FIELDS:
  private   static  System.Int32                    k_MinIterations  // 0x0
  private   static  System.Int32                    k_MaxIterations  // 0x0
  private   static  System.Single                   k_MinTolerance  // 0x0
  private   static  System.Single                   k_MaxTolerance  // 0x0
  private           UnityEngine.Transform           m_Root  // 0x10
  private           UnityEngine.Transform           m_Tip  // 0x18
  private           UnityEngine.Transform           m_Target  // 0x20
  private           System.Single                   m_ChainRotationWeight  // 0x28
  private           System.Single                   m_TipRotationWeight  // 0x2C
  private           System.Int32                    m_MaxIterations  // 0x30
  private           System.Single                   m_Tolerance  // 0x34
  private           System.Boolean                  m_MaintainTargetPositionOffset  // 0x38
  private           System.Boolean                  m_MaintainTargetRotationOffset  // 0x39
METHODS:
  UnityEngine.Transform get_root()
  System.Void set_root(UnityEngine.Transform value)
  UnityEngine.Transform get_tip()
  System.Void set_tip(UnityEngine.Transform value)
  UnityEngine.Transform get_target()
  System.Void set_target(UnityEngine.Transform value)
  System.Single get_chainRotationWeight()
  System.Void set_chainRotationWeight(System.Single value)
  System.Single get_tipRotationWeight()
  System.Void set_tipRotationWeight(System.Single value)
  System.Int32 get_maxIterations()
  System.Void set_maxIterations(System.Int32 value)
  System.Single get_tolerance()
  System.Void set_tolerance(System.Single value)
  System.Boolean get_maintainTargetPositionOffset()
  System.Void set_maintainTargetPositionOffset(System.Boolean value)
  System.Boolean get_maintainTargetRotationOffset()
  System.Void set_maintainTargetRotationOffset(System.Boolean value)
  System.String UnityEngine.Animations.Rigging.IChainIKConstraintData.get_chainRotationWeightFloatProperty()
  System.String UnityEngine.Animations.Rigging.IChainIKConstraintData.get_tipRotationWeightFloatProperty()
  System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid()
  System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.ChainIKConstraint
TYPE:  class
TOKEN: 0x2000046
EXTENDS: RigConstraint`3
FIELDS:
METHODS:
  System.Void OnValidate()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.DampedTransformData
TYPE:  struct
TOKEN: 0x2000047
FIELDS:
  private           UnityEngine.Transform           m_ConstrainedObject  // 0x10
  private           UnityEngine.Transform           m_Source  // 0x18
  private           System.Single                   m_DampPosition  // 0x20
  private           System.Single                   m_DampRotation  // 0x24
  private           System.Boolean                  m_MaintainAim  // 0x28
METHODS:
  UnityEngine.Transform get_constrainedObject()
  System.Void set_constrainedObject(UnityEngine.Transform value)
  UnityEngine.Transform get_sourceObject()
  System.Void set_sourceObject(UnityEngine.Transform value)
  System.Single get_dampPosition()
  System.Void set_dampPosition(System.Single value)
  System.Single get_dampRotation()
  System.Void set_dampRotation(System.Single value)
  System.Boolean get_maintainAim()
  System.Void set_maintainAim(System.Boolean value)
  System.String UnityEngine.Animations.Rigging.IDampedTransformData.get_dampPositionFloatProperty()
  System.String UnityEngine.Animations.Rigging.IDampedTransformData.get_dampRotationFloatProperty()
  System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid()
  System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.DampedTransform
TYPE:  class
TOKEN: 0x2000048
EXTENDS: RigConstraint`3
FIELDS:
METHODS:
  System.Void OnValidate()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.MultiAimConstraintData
TYPE:  struct
TOKEN: 0x2000049
FIELDS:
  private   static  System.Single                   k_MinAngularLimit  // 0x0
  private   static  System.Single                   k_MaxAngularLimit  // 0x0
  private           UnityEngine.Transform           m_ConstrainedObject  // 0x10
  private           UnityEngine.Animations.Rigging.WeightedTransformArraym_SourceObjects  // 0x18
  private           UnityEngine.Vector3             m_Offset  // 0xA0
  private           System.Single                   m_MinLimit  // 0xAC
  private           System.Single                   m_MaxLimit  // 0xB0
  private           UnityEngine.Animations.Rigging.MultiAimConstraintData.Axism_AimAxis  // 0xB4
  private           UnityEngine.Animations.Rigging.MultiAimConstraintData.Axism_UpAxis  // 0xB8
  private           UnityEngine.Animations.Rigging.MultiAimConstraintData.WorldUpTypem_WorldUpType  // 0xBC
  private           UnityEngine.Transform           m_WorldUpObject  // 0xC0
  private           UnityEngine.Animations.Rigging.MultiAimConstraintData.Axism_WorldUpAxis  // 0xC8
  private           System.Boolean                  m_MaintainOffset  // 0xCC
  private           UnityEngine.Animations.Rigging.Vector3Boolm_ConstrainedAxes  // 0xCD
METHODS:
  UnityEngine.Transform get_constrainedObject()
  System.Void set_constrainedObject(UnityEngine.Transform value)
  UnityEngine.Animations.Rigging.WeightedTransformArray get_sourceObjects()
  System.Void set_sourceObjects(UnityEngine.Animations.Rigging.WeightedTransformArray value)
  System.Boolean get_maintainOffset()
  System.Void set_maintainOffset(System.Boolean value)
  UnityEngine.Vector3 get_offset()
  System.Void set_offset(UnityEngine.Vector3 value)
  UnityEngine.Vector2 get_limits()
  System.Void set_limits(UnityEngine.Vector2 value)
  UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis get_aimAxis()
  System.Void set_aimAxis(UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis value)
  UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis get_upAxis()
  System.Void set_upAxis(UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis value)
  UnityEngine.Animations.Rigging.MultiAimConstraintData.WorldUpType get_worldUpType()
  System.Void set_worldUpType(UnityEngine.Animations.Rigging.MultiAimConstraintData.WorldUpType value)
  UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis get_worldUpAxis()
  System.Void set_worldUpAxis(UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis value)
  UnityEngine.Transform get_worldUpObject()
  System.Void set_worldUpObject(UnityEngine.Transform value)
  System.Boolean get_constrainedXAxis()
  System.Void set_constrainedXAxis(System.Boolean value)
  System.Boolean get_constrainedYAxis()
  System.Void set_constrainedYAxis(System.Boolean value)
  System.Boolean get_constrainedZAxis()
  System.Void set_constrainedZAxis(System.Boolean value)
  UnityEngine.Vector3 UnityEngine.Animations.Rigging.IMultiAimConstraintData.get_aimAxis()
  UnityEngine.Vector3 UnityEngine.Animations.Rigging.IMultiAimConstraintData.get_upAxis()
  System.Int32 UnityEngine.Animations.Rigging.IMultiAimConstraintData.get_worldUpType()
  UnityEngine.Vector3 UnityEngine.Animations.Rigging.IMultiAimConstraintData.get_worldUpAxis()
  System.String UnityEngine.Animations.Rigging.IMultiAimConstraintData.get_offsetVector3Property()
  System.String UnityEngine.Animations.Rigging.IMultiAimConstraintData.get_minLimitFloatProperty()
  System.String UnityEngine.Animations.Rigging.IMultiAimConstraintData.get_maxLimitFloatProperty()
  System.String UnityEngine.Animations.Rigging.IMultiAimConstraintData.get_sourceObjectsProperty()
  System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid()
  System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues()
  UnityEngine.Vector3 Convert(UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis axis)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.MultiAimConstraint
TYPE:  class
TOKEN: 0x200004C
EXTENDS: RigConstraint`3
FIELDS:
METHODS:
  System.Void OnValidate()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.MultiParentConstraintData
TYPE:  struct
TOKEN: 0x200004D
FIELDS:
  private           UnityEngine.Transform           m_ConstrainedObject  // 0x10
  private           UnityEngine.Animations.Rigging.WeightedTransformArraym_SourceObjects  // 0x18
  private           UnityEngine.Animations.Rigging.Vector3Boolm_ConstrainedPositionAxes  // 0xA0
  private           UnityEngine.Animations.Rigging.Vector3Boolm_ConstrainedRotationAxes  // 0xA3
  private           System.Boolean                  m_MaintainPositionOffset  // 0xA6
  private           System.Boolean                  m_MaintainRotationOffset  // 0xA7
METHODS:
  UnityEngine.Transform get_constrainedObject()
  System.Void set_constrainedObject(UnityEngine.Transform value)
  UnityEngine.Animations.Rigging.WeightedTransformArray get_sourceObjects()
  System.Void set_sourceObjects(UnityEngine.Animations.Rigging.WeightedTransformArray value)
  System.Boolean get_maintainPositionOffset()
  System.Void set_maintainPositionOffset(System.Boolean value)
  System.Boolean get_maintainRotationOffset()
  System.Void set_maintainRotationOffset(System.Boolean value)
  System.Boolean get_constrainedPositionXAxis()
  System.Void set_constrainedPositionXAxis(System.Boolean value)
  System.Boolean get_constrainedPositionYAxis()
  System.Void set_constrainedPositionYAxis(System.Boolean value)
  System.Boolean get_constrainedPositionZAxis()
  System.Void set_constrainedPositionZAxis(System.Boolean value)
  System.Boolean get_constrainedRotationXAxis()
  System.Void set_constrainedRotationXAxis(System.Boolean value)
  System.Boolean get_constrainedRotationYAxis()
  System.Void set_constrainedRotationYAxis(System.Boolean value)
  System.Boolean get_constrainedRotationZAxis()
  System.Void set_constrainedRotationZAxis(System.Boolean value)
  System.String UnityEngine.Animations.Rigging.IMultiParentConstraintData.get_sourceObjectsProperty()
  System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid()
  System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.MultiParentConstraint
TYPE:  class
TOKEN: 0x200004E
EXTENDS: RigConstraint`3
FIELDS:
METHODS:
  System.Void OnValidate()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.MultiPositionConstraintData
TYPE:  struct
TOKEN: 0x200004F
FIELDS:
  private           UnityEngine.Transform           m_ConstrainedObject  // 0x10
  private           UnityEngine.Animations.Rigging.WeightedTransformArraym_SourceObjects  // 0x18
  private           UnityEngine.Vector3             m_Offset  // 0xA0
  private           UnityEngine.Animations.Rigging.Vector3Boolm_ConstrainedAxes  // 0xAC
  private           System.Boolean                  m_MaintainOffset  // 0xAF
METHODS:
  UnityEngine.Transform get_constrainedObject()
  System.Void set_constrainedObject(UnityEngine.Transform value)
  UnityEngine.Animations.Rigging.WeightedTransformArray get_sourceObjects()
  System.Void set_sourceObjects(UnityEngine.Animations.Rigging.WeightedTransformArray value)
  System.Boolean get_maintainOffset()
  System.Void set_maintainOffset(System.Boolean value)
  UnityEngine.Vector3 get_offset()
  System.Void set_offset(UnityEngine.Vector3 value)
  System.Boolean get_constrainedXAxis()
  System.Void set_constrainedXAxis(System.Boolean value)
  System.Boolean get_constrainedYAxis()
  System.Void set_constrainedYAxis(System.Boolean value)
  System.Boolean get_constrainedZAxis()
  System.Void set_constrainedZAxis(System.Boolean value)
  System.String UnityEngine.Animations.Rigging.IMultiPositionConstraintData.get_offsetVector3Property()
  System.String UnityEngine.Animations.Rigging.IMultiPositionConstraintData.get_sourceObjectsProperty()
  System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid()
  System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.MultiPositionConstraint
TYPE:  class
TOKEN: 0x2000050
EXTENDS: RigConstraint`3
FIELDS:
METHODS:
  System.Void OnValidate()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.MultiReferentialConstraintData
TYPE:  struct
TOKEN: 0x2000051
FIELDS:
  private           System.Int32                    m_Driver  // 0x10
  private           System.Collections.Generic.List<UnityEngine.Transform>m_SourceObjects  // 0x18
METHODS:
  System.Int32 get_driver()
  System.Void set_driver(System.Int32 value)
  System.Collections.Generic.List<UnityEngine.Transform> get_sourceObjects()
  System.Void set_sourceObjects(System.Collections.Generic.List<UnityEngine.Transform> value)
  UnityEngine.Transform[] UnityEngine.Animations.Rigging.IMultiReferentialConstraintData.get_sourceObjects()
  System.Int32 UnityEngine.Animations.Rigging.IMultiReferentialConstraintData.get_driverValue()
  System.String UnityEngine.Animations.Rigging.IMultiReferentialConstraintData.get_driverIntProperty()
  System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid()
  System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues()
  System.Void UpdateDriver()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.MultiReferentialConstraint
TYPE:  class
TOKEN: 0x2000052
EXTENDS: RigConstraint`3
FIELDS:
METHODS:
  System.Void OnValidate()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.MultiRotationConstraintData
TYPE:  struct
TOKEN: 0x2000053
FIELDS:
  private           UnityEngine.Transform           m_ConstrainedObject  // 0x10
  private           UnityEngine.Animations.Rigging.WeightedTransformArraym_SourceObjects  // 0x18
  private           UnityEngine.Vector3             m_Offset  // 0xA0
  private           UnityEngine.Animations.Rigging.Vector3Boolm_ConstrainedAxes  // 0xAC
  private           System.Boolean                  m_MaintainOffset  // 0xAF
METHODS:
  UnityEngine.Transform get_constrainedObject()
  System.Void set_constrainedObject(UnityEngine.Transform value)
  UnityEngine.Animations.Rigging.WeightedTransformArray get_sourceObjects()
  System.Void set_sourceObjects(UnityEngine.Animations.Rigging.WeightedTransformArray value)
  System.Boolean get_maintainOffset()
  System.Void set_maintainOffset(System.Boolean value)
  UnityEngine.Vector3 get_offset()
  System.Void set_offset(UnityEngine.Vector3 value)
  System.Boolean get_constrainedXAxis()
  System.Void set_constrainedXAxis(System.Boolean value)
  System.Boolean get_constrainedYAxis()
  System.Void set_constrainedYAxis(System.Boolean value)
  System.Boolean get_constrainedZAxis()
  System.Void set_constrainedZAxis(System.Boolean value)
  System.String UnityEngine.Animations.Rigging.IMultiRotationConstraintData.get_offsetVector3Property()
  System.String UnityEngine.Animations.Rigging.IMultiRotationConstraintData.get_sourceObjectsProperty()
  System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid()
  System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.MultiRotationConstraint
TYPE:  class
TOKEN: 0x2000054
EXTENDS: RigConstraint`3
FIELDS:
METHODS:
  System.Void OnValidate()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.OverrideTransformData
TYPE:  struct
TOKEN: 0x2000055
FIELDS:
  private           UnityEngine.Transform           m_ConstrainedObject  // 0x10
  private           UnityEngine.Transform           m_OverrideSource  // 0x18
  private           UnityEngine.Vector3             m_OverridePosition  // 0x20
  private           UnityEngine.Vector3             m_OverrideRotation  // 0x2C
  private           System.Single                   m_PositionWeight  // 0x38
  private           System.Single                   m_RotationWeight  // 0x3C
  private           UnityEngine.Animations.Rigging.OverrideTransformData.Spacem_Space  // 0x40
METHODS:
  UnityEngine.Transform get_constrainedObject()
  System.Void set_constrainedObject(UnityEngine.Transform value)
  UnityEngine.Transform get_sourceObject()
  System.Void set_sourceObject(UnityEngine.Transform value)
  UnityEngine.Animations.Rigging.OverrideTransformData.Space get_space()
  System.Void set_space(UnityEngine.Animations.Rigging.OverrideTransformData.Space value)
  UnityEngine.Vector3 get_position()
  System.Void set_position(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_rotation()
  System.Void set_rotation(UnityEngine.Vector3 value)
  System.Single get_positionWeight()
  System.Void set_positionWeight(System.Single value)
  System.Single get_rotationWeight()
  System.Void set_rotationWeight(System.Single value)
  System.Int32 UnityEngine.Animations.Rigging.IOverrideTransformData.get_space()
  System.String UnityEngine.Animations.Rigging.IOverrideTransformData.get_positionWeightFloatProperty()
  System.String UnityEngine.Animations.Rigging.IOverrideTransformData.get_rotationWeightFloatProperty()
  System.String UnityEngine.Animations.Rigging.IOverrideTransformData.get_positionVector3Property()
  System.String UnityEngine.Animations.Rigging.IOverrideTransformData.get_rotationVector3Property()
  System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid()
  System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.OverrideTransform
TYPE:  class
TOKEN: 0x2000057
EXTENDS: RigConstraint`3
FIELDS:
METHODS:
  System.Void OnValidate()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.TwistChainConstraintData
TYPE:  struct
TOKEN: 0x2000058
FIELDS:
  private           UnityEngine.Transform           m_Root  // 0x10
  private           UnityEngine.Transform           m_Tip  // 0x18
  private           UnityEngine.Transform           m_RootTarget  // 0x20
  private           UnityEngine.Transform           m_TipTarget  // 0x28
  private           UnityEngine.AnimationCurve      m_Curve  // 0x30
METHODS:
  UnityEngine.Transform get_root()
  System.Void set_root(UnityEngine.Transform value)
  UnityEngine.Transform get_tip()
  System.Void set_tip(UnityEngine.Transform value)
  UnityEngine.Transform get_rootTarget()
  System.Void set_rootTarget(UnityEngine.Transform value)
  UnityEngine.Transform get_tipTarget()
  System.Void set_tipTarget(UnityEngine.Transform value)
  UnityEngine.AnimationCurve get_curve()
  System.Void set_curve(UnityEngine.AnimationCurve value)
  System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid()
  System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.TwistChainConstraint
TYPE:  class
TOKEN: 0x2000059
EXTENDS: RigConstraint`3
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.TwistCorrectionData
TYPE:  struct
TOKEN: 0x200005A
FIELDS:
  private           UnityEngine.Transform           m_Source  // 0x10
  private           UnityEngine.Animations.Rigging.TwistCorrectionData.Axism_TwistAxis  // 0x18
  private           UnityEngine.Animations.Rigging.WeightedTransformArraym_TwistNodes  // 0x20
METHODS:
  UnityEngine.Transform get_sourceObject()
  System.Void set_sourceObject(UnityEngine.Transform value)
  UnityEngine.Animations.Rigging.WeightedTransformArray get_twistNodes()
  System.Void set_twistNodes(UnityEngine.Animations.Rigging.WeightedTransformArray value)
  UnityEngine.Animations.Rigging.TwistCorrectionData.Axis get_twistAxis()
  System.Void set_twistAxis(UnityEngine.Animations.Rigging.TwistCorrectionData.Axis value)
  UnityEngine.Transform UnityEngine.Animations.Rigging.ITwistCorrectionData.get_source()
  UnityEngine.Vector3 UnityEngine.Animations.Rigging.ITwistCorrectionData.get_twistAxis()
  System.String UnityEngine.Animations.Rigging.ITwistCorrectionData.get_twistNodesProperty()
  UnityEngine.Vector3 Convert(UnityEngine.Animations.Rigging.TwistCorrectionData.Axis axis)
  System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid()
  System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.TwistCorrection
TYPE:  class
TOKEN: 0x200005C
EXTENDS: RigConstraint`3
FIELDS:
METHODS:
  System.Void OnValidate()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.TwoBoneIKConstraintData
TYPE:  struct
TOKEN: 0x200005D
FIELDS:
  private           UnityEngine.Transform           m_Root  // 0x10
  private           UnityEngine.Transform           m_Mid  // 0x18
  private           UnityEngine.Transform           m_Tip  // 0x20
  private           UnityEngine.Transform           m_Target  // 0x28
  private           UnityEngine.Transform           m_Hint  // 0x30
  private           System.Single                   m_TargetPositionWeight  // 0x38
  private           System.Single                   m_TargetRotationWeight  // 0x3C
  private           System.Single                   m_HintWeight  // 0x40
  private           System.Boolean                  m_MaintainTargetPositionOffset  // 0x44
  private           System.Boolean                  m_MaintainTargetRotationOffset  // 0x45
METHODS:
  UnityEngine.Transform get_root()
  System.Void set_root(UnityEngine.Transform value)
  UnityEngine.Transform get_mid()
  System.Void set_mid(UnityEngine.Transform value)
  UnityEngine.Transform get_tip()
  System.Void set_tip(UnityEngine.Transform value)
  UnityEngine.Transform get_target()
  System.Void set_target(UnityEngine.Transform value)
  UnityEngine.Transform get_hint()
  System.Void set_hint(UnityEngine.Transform value)
  System.Single get_targetPositionWeight()
  System.Void set_targetPositionWeight(System.Single value)
  System.Single get_targetRotationWeight()
  System.Void set_targetRotationWeight(System.Single value)
  System.Single get_hintWeight()
  System.Void set_hintWeight(System.Single value)
  System.Boolean get_maintainTargetPositionOffset()
  System.Void set_maintainTargetPositionOffset(System.Boolean value)
  System.Boolean get_maintainTargetRotationOffset()
  System.Void set_maintainTargetRotationOffset(System.Boolean value)
  System.String UnityEngine.Animations.Rigging.ITwoBoneIKConstraintData.get_targetPositionWeightFloatProperty()
  System.String UnityEngine.Animations.Rigging.ITwoBoneIKConstraintData.get_targetRotationWeightFloatProperty()
  System.String UnityEngine.Animations.Rigging.ITwoBoneIKConstraintData.get_hintWeightFloatProperty()
  System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid()
  System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.TwoBoneIKConstraint
TYPE:  class
TOKEN: 0x200005E
EXTENDS: RigConstraint`3
FIELDS:
METHODS:
  System.Void OnValidate()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.IRigConstraint
TYPE:  interface
TOKEN: 0x200005F
FIELDS:
METHODS:
  System.Boolean IsValid()
  UnityEngine.Animations.IAnimationJob CreateJob(UnityEngine.Animator animator)
  System.Void UpdateJob(UnityEngine.Animations.IAnimationJob job)
  System.Void DestroyJob(UnityEngine.Animations.IAnimationJob job)
  UnityEngine.Animations.Rigging.IAnimationJobData get_data()
  UnityEngine.Animations.Rigging.IAnimationJobBinder get_binder()
  UnityEngine.Component get_component()
  System.Single get_weight()
  System.Void set_weight(System.Single value)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.IRigLayer
TYPE:  interface
TOKEN: 0x2000060
FIELDS:
METHODS:
  UnityEngine.Animations.Rigging.Rig get_rig()
  UnityEngine.Animations.Rigging.IRigConstraint[] get_constraints()
  UnityEngine.Animations.IAnimationJob[] get_jobs()
  System.Boolean get_active()
  System.String get_name()
  System.Boolean Initialize(UnityEngine.Animator animator)
  System.Void Update()
  System.Void Reset()
  System.Boolean IsValid()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.OverrideRigConstraint`4
TYPE:  class
TOKEN: 0x2000061
FIELDS:
  protected         TConstraint                     m_Constraint  // 0x0
  private   static readonly TBinder                         s_Binder  // 0x0
METHODS:
  System.Void .ctor(TConstraint baseConstraint)
  UnityEngine.Animations.IAnimationJob CreateJob(UnityEngine.Animator animator)
  System.Void DestroyJob(UnityEngine.Animations.IAnimationJob job)
  System.Void UpdateJob(UnityEngine.Animations.IAnimationJob job)
  System.Boolean IsValid()
  UnityEngine.Animations.Rigging.IAnimationJobBinder UnityEngine.Animations.Rigging.IRigConstraint.get_binder()
  UnityEngine.Animations.Rigging.IAnimationJobData UnityEngine.Animations.Rigging.IRigConstraint.get_data()
  UnityEngine.Component UnityEngine.Animations.Rigging.IRigConstraint.get_component()
  System.Single get_weight()
  System.Void set_weight(System.Single value)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.OverrideRigLayer
TYPE:  class
TOKEN: 0x2000062
FIELDS:
  private           UnityEngine.Animations.Rigging.Rigm_Rig  // 0x10
  private           System.Boolean                  m_Active  // 0x18
  private           UnityEngine.Animations.Rigging.IRigConstraint[]m_Constraints  // 0x20
  private           UnityEngine.Animations.IAnimationJob[]m_Jobs  // 0x28
  private           System.Boolean                  <isInitialized>k__BackingField  // 0x30
METHODS:
  UnityEngine.Animations.Rigging.Rig get_rig()
  System.Void set_rig(UnityEngine.Animations.Rigging.Rig value)
  System.Boolean get_active()
  System.Void set_active(System.Boolean value)
  System.String get_name()
  UnityEngine.Animations.Rigging.IRigConstraint[] get_constraints()
  UnityEngine.Animations.IAnimationJob[] get_jobs()
  System.Boolean get_isInitialized()
  System.Void set_isInitialized(System.Boolean value)
  System.Void .ctor(UnityEngine.Animations.Rigging.Rig rig, UnityEngine.Animations.Rigging.IRigConstraint[] constraints, System.Boolean active)
  System.Boolean Initialize(UnityEngine.Animator animator)
  System.Void Update()
  System.Void Reset()
  System.Boolean IsValid()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.Rig
TYPE:  class
TOKEN: 0x2000063
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Single                   m_Weight  // 0x18
  private           System.Collections.Generic.List<UnityEngine.Animations.Rigging.RigEffectorData>m_Effectors  // 0x20
METHODS:
  System.Single get_weight()
  System.Void set_weight(System.Single value)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.RigBuilder
TYPE:  class
TOKEN: 0x2000064
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.Animations.Rigging.RigLayer>m_RigLayers  // 0x18
  private           UnityEngine.Animations.Rigging.IRigLayer[]m_RuntimeRigLayers  // 0x20
  private           UnityEngine.Animations.Rigging.SyncSceneToStreamLayerm_SyncSceneToStreamLayer  // 0x28
  private           System.Collections.Generic.List<UnityEngine.Animations.Rigging.RigEffectorData>m_Effectors  // 0x30
  public    static  UnityEngine.Animations.Rigging.RigBuilder.OnAddRigBuilderCallbackonAddRigBuilder  // 0x0
  public    static  UnityEngine.Animations.Rigging.RigBuilder.OnRemoveRigBuilderCallbackonRemoveRigBuilder  // 0x8
  private           UnityEngine.Playables.PlayableGraph<graph>k__BackingField  // 0x38
METHODS:
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void Update()
  System.Boolean Build()
  System.Void Clear()
  System.Void StartPreview()
  System.Void StopPreview()
  System.Void UpdatePreviewGraph(UnityEngine.Playables.PlayableGraph graph)
  UnityEngine.Playables.Playable BuildPreviewGraph(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable inputPlayable)
  System.Collections.Generic.List<UnityEngine.Animations.Rigging.RigLayer> get_layers()
  System.Void set_layers(System.Collections.Generic.List<UnityEngine.Animations.Rigging.RigLayer> value)
  UnityEngine.Animations.Rigging.SyncSceneToStreamLayer get_syncSceneToStreamLayer()
  System.Void set_syncSceneToStreamLayer(UnityEngine.Animations.Rigging.SyncSceneToStreamLayer value)
  UnityEngine.Playables.PlayableGraph get_graph()
  System.Void set_graph(UnityEngine.Playables.PlayableGraph value)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.RigBuilderUtils
TYPE:  class
TOKEN: 0x2000067
FIELDS:
  private   static readonly System.UInt16                   k_AnimationOutputPriority  // 0x0
METHODS:
  UnityEngine.Playables.Playable[] BuildRigPlayables(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animations.Rigging.IRigLayer layer)
  System.Collections.Generic.IEnumerable<UnityEngine.Animations.Rigging.RigBuilderUtils.PlayableChain> BuildPlayables(UnityEngine.Animator animator, UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.IList<UnityEngine.Animations.Rigging.IRigLayer> layers, UnityEngine.Animations.Rigging.SyncSceneToStreamLayer syncSceneToStreamLayer)
  UnityEngine.Playables.PlayableGraph BuildPlayableGraph(UnityEngine.Animator animator, System.Collections.Generic.IList<UnityEngine.Animations.Rigging.IRigLayer> layers, UnityEngine.Animations.Rigging.SyncSceneToStreamLayer syncSceneToStreamLayer)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.RigConstraint`3
TYPE:  class
TOKEN: 0x2000069
EXTENDS: MonoBehaviour
FIELDS:
  protected         System.Single                   m_Weight  // 0x0
  protected         TData                           m_Data  // 0x0
  private   static readonly TBinder                         s_Binder  // 0x0
METHODS:
  System.Void Reset()
  System.Boolean IsValid()
  System.Void OnValidate()
  TData& get_data()
  System.Single get_weight()
  System.Void set_weight(System.Single value)
  UnityEngine.Animations.IAnimationJob CreateJob(UnityEngine.Animator animator)
  System.Void DestroyJob(UnityEngine.Animations.IAnimationJob job)
  System.Void UpdateJob(UnityEngine.Animations.IAnimationJob job)
  UnityEngine.Animations.Rigging.IAnimationJobBinder UnityEngine.Animations.Rigging.IRigConstraint.get_binder()
  UnityEngine.Animations.Rigging.IAnimationJobData UnityEngine.Animations.Rigging.IRigConstraint.get_data()
  UnityEngine.Component UnityEngine.Animations.Rigging.IRigConstraint.get_component()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.RigLayer
TYPE:  class
TOKEN: 0x200006A
FIELDS:
  private           UnityEngine.Animations.Rigging.Rigm_Rig  // 0x10
  private           System.Boolean                  m_Active  // 0x18
  private           UnityEngine.Animations.Rigging.IRigConstraint[]m_Constraints  // 0x20
  private           UnityEngine.Animations.IAnimationJob[]m_Jobs  // 0x28
  private           System.Boolean                  <isInitialized>k__BackingField  // 0x30
METHODS:
  UnityEngine.Animations.Rigging.Rig get_rig()
  System.Void set_rig(UnityEngine.Animations.Rigging.Rig value)
  System.Boolean get_active()
  System.Void set_active(System.Boolean value)
  System.String get_name()
  UnityEngine.Animations.Rigging.IRigConstraint[] get_constraints()
  UnityEngine.Animations.IAnimationJob[] get_jobs()
  System.Boolean get_isInitialized()
  System.Void set_isInitialized(System.Boolean value)
  System.Void .ctor(UnityEngine.Animations.Rigging.Rig rig, System.Boolean active)
  System.Boolean Initialize(UnityEngine.Animator animator)
  System.Void Update()
  System.Void Reset()
  System.Boolean IsValid()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.RigTransform
TYPE:  class
TOKEN: 0x200006B
EXTENDS: MonoBehaviour
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.RigUtils
TYPE:  class
TOKEN: 0x200006C
FIELDS:
  private   static readonly System.Collections.Generic.Dictionary<System.Type,UnityEngine.Animations.Rigging.PropertyDescriptor>s_SupportedPropertyTypeToDescriptor  // 0x0
  private   static readonly UnityEngine.Animations.Rigging.IAnimationJobBinder<syncSceneToStreamBinder>k__BackingField  // 0x8
METHODS:
  UnityEngine.Animations.Rigging.IRigConstraint[] GetConstraints(UnityEngine.Animations.Rigging.Rig rig)
  UnityEngine.Transform[] GetSyncableRigTransforms(UnityEngine.Animator animator)
  System.Boolean ExtractTransformType(UnityEngine.Animator animator, System.Reflection.FieldInfo field, System.Object data, System.Collections.Generic.List<UnityEngine.Transform> syncableTransforms)
  System.Boolean ExtractPropertyType(System.Reflection.FieldInfo field, System.Object data, System.Collections.Generic.List<UnityEngine.Animations.Rigging.Property> syncableProperties, System.String namePrefix)
  System.Boolean ExtractWeightedTransforms(UnityEngine.Animator animator, System.Reflection.FieldInfo field, System.Object data, System.Collections.Generic.List<UnityEngine.Transform> syncableTransforms, System.Collections.Generic.List<UnityEngine.Animations.Rigging.Property> syncableProperties)
  System.Boolean ExtractNestedPropertyType(UnityEngine.Animator animator, System.Reflection.FieldInfo field, System.Object data, System.Collections.Generic.List<UnityEngine.Transform> syncableTransforms, System.Collections.Generic.List<UnityEngine.Animations.Rigging.Property> syncableProperties, System.String namePrefix)
  System.Void ExtractAllSyncableData(UnityEngine.Animator animator, System.Collections.Generic.IList<UnityEngine.Animations.Rigging.IRigLayer> layers, System.Collections.Generic.List<UnityEngine.Transform>& syncableTransforms, System.Collections.Generic.List<UnityEngine.Animations.Rigging.SyncableProperties>& syncableProperties)
  UnityEngine.Animations.IAnimationJob[] CreateAnimationJobs(UnityEngine.Animator animator, UnityEngine.Animations.Rigging.IRigConstraint[] constraints)
  System.Void DestroyAnimationJobs(UnityEngine.Animations.Rigging.IRigConstraint[] constraints, UnityEngine.Animations.IAnimationJob[] jobs)
  UnityEngine.Animations.Rigging.IAnimationJobData CreateSyncSceneToStreamData(UnityEngine.Animator animator, System.Collections.Generic.IList<UnityEngine.Animations.Rigging.IRigLayer> layers)
  UnityEngine.Animations.Rigging.IAnimationJobBinder get_syncSceneToStreamBinder()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.SyncSceneToStreamLayer
TYPE:  class
TOKEN: 0x200006F
FIELDS:
  private           System.Boolean                  <isInitialized>k__BackingField  // 0x10
  public            UnityEngine.Animations.IAnimationJobjob  // 0x18
  private           UnityEngine.Animations.Rigging.IAnimationJobDatam_Data  // 0x20
  private           System.Collections.Generic.List<System.Int32>m_RigIndices  // 0x28
METHODS:
  System.Boolean Initialize(UnityEngine.Animator animator, System.Collections.Generic.IList<UnityEngine.Animations.Rigging.IRigLayer> layers)
  System.Void Update(System.Collections.Generic.IList<UnityEngine.Animations.Rigging.IRigLayer> layers)
  System.Void Reset()
  System.Boolean IsValid()
  System.Boolean get_isInitialized()
  System.Void set_isInitialized(System.Boolean value)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.ITransformProvider
TYPE:  interface
TOKEN: 0x2000070
FIELDS:
METHODS:
  UnityEngine.Transform get_transform()
  System.Void set_transform(UnityEngine.Transform value)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.IWeightProvider
TYPE:  interface
TOKEN: 0x2000071
FIELDS:
METHODS:
  System.Single get_weight()
  System.Void set_weight(System.Single value)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.WeightedTransform
TYPE:  struct
TOKEN: 0x2000072
FIELDS:
  public            UnityEngine.Transform           transform  // 0x10
  public            System.Single                   weight  // 0x18
METHODS:
  System.Void .ctor(UnityEngine.Transform transform, System.Single weight)
  UnityEngine.Animations.Rigging.WeightedTransform Default(System.Single weight)
  System.Boolean Equals(UnityEngine.Animations.Rigging.WeightedTransform other)
  UnityEngine.Transform UnityEngine.Animations.Rigging.ITransformProvider.get_transform()
  System.Void UnityEngine.Animations.Rigging.ITransformProvider.set_transform(UnityEngine.Transform value)
  System.Single UnityEngine.Animations.Rigging.IWeightProvider.get_weight()
  System.Void UnityEngine.Animations.Rigging.IWeightProvider.set_weight(System.Single value)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.WeightedTransformArray
TYPE:  struct
TOKEN: 0x2000073
FIELDS:
  public    static readonly System.Int32                    k_MaxLength  // 0x0
  private           System.Int32                    m_Length  // 0x10
  private           UnityEngine.Animations.Rigging.WeightedTransformm_Item0  // 0x18
  private           UnityEngine.Animations.Rigging.WeightedTransformm_Item1  // 0x28
  private           UnityEngine.Animations.Rigging.WeightedTransformm_Item2  // 0x38
  private           UnityEngine.Animations.Rigging.WeightedTransformm_Item3  // 0x48
  private           UnityEngine.Animations.Rigging.WeightedTransformm_Item4  // 0x58
  private           UnityEngine.Animations.Rigging.WeightedTransformm_Item5  // 0x68
  private           UnityEngine.Animations.Rigging.WeightedTransformm_Item6  // 0x78
  private           UnityEngine.Animations.Rigging.WeightedTransformm_Item7  // 0x88
METHODS:
  System.Void .ctor(System.Int32 size)
  System.Collections.Generic.IEnumerator<UnityEngine.Animations.Rigging.WeightedTransform> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Int32 System.Collections.IList.Add(System.Object value)
  System.Void Add(UnityEngine.Animations.Rigging.WeightedTransform value)
  System.Void Clear()
  System.Int32 System.Collections.IList.IndexOf(System.Object value)
  System.Int32 IndexOf(UnityEngine.Animations.Rigging.WeightedTransform value)
  System.Boolean System.Collections.IList.Contains(System.Object value)
  System.Boolean Contains(UnityEngine.Animations.Rigging.WeightedTransform value)
  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 arrayIndex)
  System.Void CopyTo(UnityEngine.Animations.Rigging.WeightedTransform[] array, System.Int32 arrayIndex)
  System.Void System.Collections.IList.Remove(System.Object value)
  System.Boolean Remove(UnityEngine.Animations.Rigging.WeightedTransform value)
  System.Void RemoveAt(System.Int32 index)
  System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value)
  System.Void Insert(System.Int32 index, UnityEngine.Animations.Rigging.WeightedTransform value)
  System.Int32 ClampSize(System.Int32 size)
  System.Void CheckOutOfRangeIndex(System.Int32 index)
  UnityEngine.Animations.Rigging.WeightedTransform Get(System.Int32 index)
  System.Void Set(System.Int32 index, UnityEngine.Animations.Rigging.WeightedTransform value)
  System.Void SetWeight(System.Int32 index, System.Single weight)
  System.Single GetWeight(System.Int32 index)
  System.Void SetTransform(System.Int32 index, UnityEngine.Transform transform)
  UnityEngine.Transform GetTransform(System.Int32 index)
  System.Void OnValidate(UnityEngine.Animations.Rigging.WeightedTransformArray& array, System.Single min, System.Single max)
  System.Object System.Collections.IList.get_Item(System.Int32 index)
  System.Void System.Collections.IList.set_Item(System.Int32 index, System.Object value)
  UnityEngine.Animations.Rigging.WeightedTransform get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, UnityEngine.Animations.Rigging.WeightedTransform value)
  System.Int32 get_Count()
  System.Boolean get_IsReadOnly()
  System.Boolean get_IsFixedSize()
  System.Boolean System.Collections.ICollection.get_IsSynchronized()
  System.Object System.Collections.ICollection.get_SyncRoot()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.ExpandChildrenAttribute
TYPE:  class
TOKEN: 0x2000075
EXTENDS: PropertyAttribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.SyncSceneToStreamAttribute
TYPE:  class
TOKEN: 0x2000076
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.PropertyType
TYPE:  struct
TOKEN: 0x2000077
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  UnityEngine.Animations.Rigging.PropertyTypeBool  // 0x0
  public    static  UnityEngine.Animations.Rigging.PropertyTypeInt  // 0x0
  public    static  UnityEngine.Animations.Rigging.PropertyTypeFloat  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Animations.Rigging.PropertyDescriptor
TYPE:  struct
TOKEN: 0x2000078
FIELDS:
  public            System.Int32                    size  // 0x10
  public            UnityEngine.Animations.Rigging.PropertyTypetype  // 0x14
METHODS:
END_CLASS

CLASS: UnityEngine.Animations.Rigging.Property
TYPE:  struct
TOKEN: 0x2000079
FIELDS:
  public            System.String                   name  // 0x10
  public            UnityEngine.Animations.Rigging.PropertyDescriptordescriptor  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.Animations.Rigging.RigProperties
TYPE:  struct
TOKEN: 0x200007A
FIELDS:
  public    static  System.String                   s_Weight  // 0x0
  public            UnityEngine.Component           component  // 0x10
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.ConstraintProperties
TYPE:  struct
TOKEN: 0x200007B
FIELDS:
  public    static  System.String                   s_Weight  // 0x0
  public            UnityEngine.Component           component  // 0x10
  public            UnityEngine.Animations.Rigging.Property[]properties  // 0x18
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.PropertyUtils
TYPE:  class
TOKEN: 0x200007C
FIELDS:
METHODS:
  System.String ConstructConstraintDataPropertyName(System.String property)
  System.String ConstructCustomPropertyName(UnityEngine.Component component, System.String property)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.WeightRangeAttribute
TYPE:  class
TOKEN: 0x200007D
EXTENDS: PropertyAttribute
FIELDS:
  public    readonly System.Single                   min  // 0x10
  public    readonly System.Single                   max  // 0x14
METHODS:
  System.Void .ctor(System.Single min, System.Single max)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.IRigEffectorHolder
TYPE:  interface
TOKEN: 0x200007E
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Animations.Rigging.RigEffectorData
TYPE:  class
TOKEN: 0x200007F
FIELDS:
  private           UnityEngine.Transform           m_Transform  // 0x10
  private           UnityEngine.Animations.Rigging.RigEffectorData.Stylem_Style  // 0x18
  private           System.Boolean                  m_Visible  // 0x50
METHODS:
  UnityEngine.Transform get_transform()
  UnityEngine.Animations.Rigging.RigEffectorData.Style get_style()
  System.Boolean get_visible()
  System.Void set_visible(System.Boolean value)
  System.Void Initialize(UnityEngine.Transform transform, UnityEngine.Animations.Rigging.RigEffectorData.Style style)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.AffineTransform
TYPE:  struct
TOKEN: 0x2000081
FIELDS:
  public            UnityEngine.Vector3             translation  // 0x10
  public            UnityEngine.Quaternion          rotation  // 0x1C
  private   static readonly UnityEngine.Animations.Rigging.AffineTransform<identity>k__BackingField  // 0x0
METHODS:
  System.Void .ctor(UnityEngine.Vector3 t, UnityEngine.Quaternion r)
  System.Void Set(UnityEngine.Vector3 t, UnityEngine.Quaternion r)
  UnityEngine.Vector3 Transform(UnityEngine.Vector3 p)
  UnityEngine.Vector3 InverseTransform(UnityEngine.Vector3 p)
  UnityEngine.Animations.Rigging.AffineTransform Inverse()
  UnityEngine.Animations.Rigging.AffineTransform InverseMul(UnityEngine.Animations.Rigging.AffineTransform transform)
  UnityEngine.Vector3 op_Multiply(UnityEngine.Animations.Rigging.AffineTransform lhs, UnityEngine.Vector3 rhs)
  UnityEngine.Animations.Rigging.AffineTransform op_Multiply(UnityEngine.Animations.Rigging.AffineTransform lhs, UnityEngine.Animations.Rigging.AffineTransform rhs)
  UnityEngine.Animations.Rigging.AffineTransform op_Multiply(UnityEngine.Quaternion lhs, UnityEngine.Animations.Rigging.AffineTransform rhs)
  UnityEngine.Animations.Rigging.AffineTransform op_Multiply(UnityEngine.Animations.Rigging.AffineTransform lhs, UnityEngine.Quaternion rhs)
  UnityEngine.Animations.Rigging.AffineTransform get_identity()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.AnimationRuntimeUtils
TYPE:  class
TOKEN: 0x2000082
FIELDS:
  private   static  System.Single                   k_SqrEpsilon  // 0x0
METHODS:
  System.Void SolveTwoBoneIK(UnityEngine.Animations.AnimationStream stream, UnityEngine.Animations.Rigging.ReadWriteTransformHandle root, UnityEngine.Animations.Rigging.ReadWriteTransformHandle mid, UnityEngine.Animations.Rigging.ReadWriteTransformHandle tip, UnityEngine.Animations.Rigging.ReadOnlyTransformHandle target, UnityEngine.Animations.Rigging.ReadOnlyTransformHandle hint, System.Single posWeight, System.Single rotWeight, System.Single hintWeight, UnityEngine.Animations.Rigging.AffineTransform targetOffset)
  System.Single TriangleAngle(System.Single aLen, System.Single aLen1, System.Single aLen2)
  System.Boolean SolveFABRIK(Unity.Collections.NativeArray<UnityEngine.Vector3>& linkPositions, Unity.Collections.NativeArray<System.Single>& linkLengths, UnityEngine.Vector3 target, System.Single tolerance, System.Single maxReach, System.Int32 maxIterations)
  System.Single SqrDistance(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs)
  System.Single Square(System.Single value)
  UnityEngine.Vector3 Lerp(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 t)
  System.Single Select(System.Single a, System.Single b, System.Single c)
  UnityEngine.Vector3 Select(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c)
  UnityEngine.Vector3 ProjectOnPlane(UnityEngine.Vector3 vector, UnityEngine.Vector3 planeNormal)
  System.Single Sum(UnityEngine.Animations.Rigging.AnimationJobCache cache, UnityEngine.Animations.Rigging.CacheIndex index, System.Int32 count)
  System.Single Sum(Unity.Collections.NativeArray<System.Single> floatBuffer)
  System.Void PassThrough(UnityEngine.Animations.AnimationStream stream, UnityEngine.Animations.Rigging.ReadWriteTransformHandle handle)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.BoneRenderer
TYPE:  class
TOKEN: 0x2000083
EXTENDS: MonoBehaviour
FIELDS:
  public            UnityEngine.Animations.Rigging.BoneRenderer.BoneShapeboneShape  // 0x18
  public            System.Boolean                  drawBones  // 0x1C
  public            System.Boolean                  drawTripods  // 0x1D
  public            System.Single                   boneSize  // 0x20
  public            System.Single                   tripodSize  // 0x24
  public            UnityEngine.Color               boneColor  // 0x28
  private           UnityEngine.Transform[]         m_Transforms  // 0x38
METHODS:
  UnityEngine.Transform[] get_transforms()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.ConstraintsUtils
TYPE:  class
TOKEN: 0x2000085
FIELDS:
METHODS:
  UnityEngine.Transform[] ExtractChain(UnityEngine.Transform root, UnityEngine.Transform tip)
  System.Single[] ExtractLengths(UnityEngine.Transform[] chain)
  System.Single[] ExtractSteps(UnityEngine.Transform[] chain)
  System.String ConstructConstraintDataPropertyName(System.String property)
  System.String ConstructCustomPropertyName(UnityEngine.Component component, System.String property)
END_CLASS

CLASS: UnityEngine.Animations.Rigging.QuaternionExt
TYPE:  class
TOKEN: 0x2000087
FIELDS:
  private   static  System.Single                   k_FloatMin  // 0x0
  public    static readonly UnityEngine.Quaternion          zero  // 0x0
METHODS:
  UnityEngine.Quaternion FromToRotation(UnityEngine.Vector3 from, UnityEngine.Vector3 to)
  UnityEngine.Quaternion Add(UnityEngine.Quaternion rhs, UnityEngine.Quaternion lhs)
  UnityEngine.Quaternion Scale(UnityEngine.Quaternion q, System.Single scale)
  UnityEngine.Quaternion NormalizeSafe(UnityEngine.Quaternion q)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Animations.Rigging.Vector3Bool
TYPE:  struct
TOKEN: 0x2000088
FIELDS:
  public            System.Boolean                  x  // 0x10
  public            System.Boolean                  y  // 0x11
  public            System.Boolean                  z  // 0x12
METHODS:
  System.Void .ctor(System.Boolean val)
  System.Void .ctor(System.Boolean x, System.Boolean y, System.Boolean z)
END_CLASS

