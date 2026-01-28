// ========================================================
// Dumped by @desirepro
// Assembly: Unity.Animation.Rigging.dll
// Classes:  136
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x200001E
    public struct WorldUpType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Animations.Rigging.MultiAimConstraintJob.WorldUpType None;        // 0x0
        public static UnityEngine.Animations.Rigging.MultiAimConstraintJob.WorldUpType SceneUp;        // 0x0
        public static UnityEngine.Animations.Rigging.MultiAimConstraintJob.WorldUpType ObjectUp;        // 0x0
        public static UnityEngine.Animations.Rigging.MultiAimConstraintJob.WorldUpType ObjectRotationUp;        // 0x0
        public static UnityEngine.Animations.Rigging.MultiAimConstraintJob.WorldUpType Vector;        // 0x0

    }

    // TypeToken: 0x200002E
    public struct Space
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Animations.Rigging.OverrideTransformJob.Space World;        // 0x0
        public static UnityEngine.Animations.Rigging.OverrideTransformJob.Space Local;        // 0x0
        public static UnityEngine.Animations.Rigging.OverrideTransformJob.Space Pivot;        // 0x0

    }

    // TypeToken: 0x2000032
    public struct TransformSyncer, IDisposable
    {
        // Fields
        public Unity.Collections.NativeArray<UnityEngine.Animations.TransformSceneHandle> sceneHandles;        // 0x10
        public Unity.Collections.NativeArray<UnityEngine.Animations.TransformStreamHandle> streamHandles;        // 0x20

        // Methods
        private UnityEngine.Animations.Rigging.RigSyncSceneToStreamJob.TransformSyncer Create(System.Int32 size) { }
        private System.Void Dispose() { }
        private System.Void BindAt(System.Int32 index, UnityEngine.Animator animator, UnityEngine.Transform transform) { }
        private System.Void Sync(UnityEngine.Animations.AnimationStream& stream) { }

    }

    // TypeToken: 0x2000033
    public struct PropertySyncer, IDisposable
    {
        // Fields
        public Unity.Collections.NativeArray<UnityEngine.Animations.PropertySceneHandle> sceneHandles;        // 0x10
        public Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle> streamHandles;        // 0x20
        public Unity.Collections.NativeArray<System.Single> buffer;        // 0x30

        // Methods
        private UnityEngine.Animations.Rigging.RigSyncSceneToStreamJob.PropertySyncer Create(System.Int32 size) { }
        private System.Void Dispose() { }
        private System.Void BindAt(System.Int32 index, UnityEngine.Animator animator, UnityEngine.Component component, System.String property) { }
        private System.Void Sync(UnityEngine.Animations.AnimationStream& stream) { }
        private Unity.Collections.NativeArray<System.Single> StreamValues(UnityEngine.Animations.AnimationStream& stream) { }

    }

    // TypeToken: 0x200004A
    public struct Axis
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis X;        // 0x0
        public static UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis X_NEG;        // 0x0
        public static UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis Y;        // 0x0
        public static UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis Y_NEG;        // 0x0
        public static UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis Z;        // 0x0
        public static UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis Z_NEG;        // 0x0

    }

    // TypeToken: 0x200004B
    public struct WorldUpType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Animations.Rigging.MultiAimConstraintData.WorldUpType None;        // 0x0
        public static UnityEngine.Animations.Rigging.MultiAimConstraintData.WorldUpType SceneUp;        // 0x0
        public static UnityEngine.Animations.Rigging.MultiAimConstraintData.WorldUpType ObjectUp;        // 0x0
        public static UnityEngine.Animations.Rigging.MultiAimConstraintData.WorldUpType ObjectRotationUp;        // 0x0
        public static UnityEngine.Animations.Rigging.MultiAimConstraintData.WorldUpType Vector;        // 0x0

    }

    // TypeToken: 0x2000056
    public struct Space
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Animations.Rigging.OverrideTransformData.Space World;        // 0x0
        public static UnityEngine.Animations.Rigging.OverrideTransformData.Space Local;        // 0x0
        public static UnityEngine.Animations.Rigging.OverrideTransformData.Space Pivot;        // 0x0

    }

    // TypeToken: 0x200005B
    public struct Axis
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Animations.Rigging.TwistCorrectionData.Axis X;        // 0x0
        public static UnityEngine.Animations.Rigging.TwistCorrectionData.Axis Y;        // 0x0
        public static UnityEngine.Animations.Rigging.TwistCorrectionData.Axis Z;        // 0x0

    }

    // TypeToken: 0x2000065
    public class OnAddRigBuilderCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Animations.Rigging.RigBuilder rigBuilder) { }
        private System.IAsyncResult BeginInvoke(UnityEngine.Animations.Rigging.RigBuilder rigBuilder, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000066
    public class OnRemoveRigBuilderCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Animations.Rigging.RigBuilder rigBuilder) { }
        private System.IAsyncResult BeginInvoke(UnityEngine.Animations.Rigging.RigBuilder rigBuilder, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000068
    public struct PlayableChain
    {
        // Fields
        public System.String name;        // 0x10
        public UnityEngine.Playables.Playable[] playables;        // 0x18

        // Methods
        private System.Boolean IsValid() { }

    }

    // TypeToken: 0x200006D
    public struct RigSyncSceneToStreamData, IAnimationJobData, IRigSyncSceneToStreamData
    {
        // Fields
        private UnityEngine.Transform[] <syncableTransforms>k__BackingField;        // 0x10
        private UnityEngine.Animations.Rigging.SyncableProperties[] <syncableProperties>k__BackingField;        // 0x18
        private System.Boolean[] <rigStates>k__BackingField;        // 0x20
        private readonly System.Boolean m_IsValid;        // 0x28

        // Methods
        private System.Void .ctor(UnityEngine.Transform[] transforms, UnityEngine.Animations.Rigging.SyncableProperties[] properties, System.Int32 rigCount) { }
        private System.Int32[] UniqueTransformIndices(UnityEngine.Transform[] transforms) { }
        private UnityEngine.Transform[] get_syncableTransforms() { }
        private System.Void set_syncableTransforms(UnityEngine.Transform[] value) { }
        private UnityEngine.Animations.Rigging.SyncableProperties[] get_syncableProperties() { }
        private System.Void set_syncableProperties(UnityEngine.Animations.Rigging.SyncableProperties[] value) { }
        private System.Boolean[] get_rigStates() { }
        private System.Void set_rigStates(System.Boolean[] value) { }
        private System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }
        private System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

    }

    // TypeToken: 0x2000074
    public struct Enumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private UnityEngine.Animations.Rigging.WeightedTransformArray m_Array;        // 0x10
        private System.Int32 m_Index;        // 0x98

        // Methods
        private System.Void .ctor(UnityEngine.Animations.Rigging.WeightedTransformArray& array) { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private System.Void System.IDisposable.Dispose() { }
        private UnityEngine.Animations.Rigging.WeightedTransform get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }

    }

    // TypeToken: 0x2000080
    public struct Style
    {
        // Fields
        public UnityEngine.Mesh shape;        // 0x10
        public UnityEngine.Color color;        // 0x18
        public System.Single size;        // 0x28
        public UnityEngine.Vector3 position;        // 0x2C
        public UnityEngine.Vector3 rotation;        // 0x38

    }

    // TypeToken: 0x2000084
    public struct BoneShape
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Animations.Rigging.BoneRenderer.BoneShape Line;        // 0x0
        public static UnityEngine.Animations.Rigging.BoneRenderer.BoneShape Pyramid;        // 0x0
        public static UnityEngine.Animations.Rigging.BoneRenderer.BoneShape Box;        // 0x0

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

namespace UnityEngine.Animations.Rigging
{

    // TypeToken: 0x2000004
    public struct CacheIndex
    {
        // Fields
        private System.Int32 idx;        // 0x10

    }

    // TypeToken: 0x2000005
    public struct AnimationJobCache, IDisposable
    {
        // Fields
        private Unity.Collections.NativeArray<System.Single> m_Data;        // 0x10

        // Methods
        private System.Void .ctor(System.Single[] data) { }
        private System.Void Dispose() { }
        private System.Single GetRaw(UnityEngine.Animations.Rigging.CacheIndex index, System.Int32 offset) { }
        private System.Void SetRaw(System.Single val, UnityEngine.Animations.Rigging.CacheIndex index, System.Int32 offset) { }
        private T Get(UnityEngine.Animations.Rigging.CacheIndex index, System.Int32 offset) { }
        private System.Void Set(T val, UnityEngine.Animations.Rigging.CacheIndex index, System.Int32 offset) { }
        private System.Void SetArray(T[] v, UnityEngine.Animations.Rigging.CacheIndex index, System.Int32 offset) { }

    }

    // TypeToken: 0x2000006
    public class AnimationJobCacheBuilder
    {
        // Fields
        private System.Collections.Generic.List<System.Single> m_Data;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private UnityEngine.Animations.Rigging.CacheIndex Add(System.Single v) { }
        private UnityEngine.Animations.Rigging.CacheIndex Add(UnityEngine.Vector2 v) { }
        private UnityEngine.Animations.Rigging.CacheIndex Add(UnityEngine.Vector3 v) { }
        private UnityEngine.Animations.Rigging.CacheIndex Add(UnityEngine.Vector4 v) { }
        private UnityEngine.Animations.Rigging.CacheIndex Add(UnityEngine.Quaternion v) { }
        private UnityEngine.Animations.Rigging.CacheIndex Add(UnityEngine.Animations.Rigging.AffineTransform tx) { }
        private UnityEngine.Animations.Rigging.CacheIndex AllocateChunk(System.Int32 size) { }
        private System.Void SetValue(UnityEngine.Animations.Rigging.CacheIndex index, System.Int32 offset, System.Single value) { }
        private UnityEngine.Animations.Rigging.AnimationJobCache Build() { }

    }

    // TypeToken: 0x2000007
    public struct BlendConstraintJob, IWeightedAnimationJob, IAnimationJob
    {
        // Fields
        private static System.Int32 k_BlendTranslationMask;        // 0x0
        private static System.Int32 k_BlendRotationMask;        // 0x0
        public UnityEngine.Animations.Rigging.ReadWriteTransformHandle driven;        // 0x10
        public UnityEngine.Animations.Rigging.ReadOnlyTransformHandle sourceA;        // 0x1C
        public UnityEngine.Animations.Rigging.ReadOnlyTransformHandle sourceB;        // 0x34
        public UnityEngine.Animations.Rigging.AffineTransform sourceAOffset;        // 0x4C
        public UnityEngine.Animations.Rigging.AffineTransform sourceBOffset;        // 0x68
        public UnityEngine.Animations.Rigging.BoolProperty blendPosition;        // 0x84
        public UnityEngine.Animations.Rigging.BoolProperty blendRotation;        // 0x94
        public UnityEngine.Animations.Rigging.FloatProperty positionWeight;        // 0xA4
        public UnityEngine.Animations.Rigging.FloatProperty rotationWeight;        // 0xB4
        private UnityEngine.Animations.Rigging.FloatProperty <jobWeight>k__BackingField;        // 0xC4

        // Methods
        private UnityEngine.Animations.Rigging.FloatProperty get_jobWeight() { }
        private System.Void set_jobWeight(UnityEngine.Animations.Rigging.FloatProperty value) { }
        private System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream) { }

    }

    // TypeToken: 0x2000008
    public interface IBlendConstraintData
    {
        // Methods
        private UnityEngine.Transform get_constrainedObject() { }
        private UnityEngine.Transform get_sourceObjectA() { }
        private UnityEngine.Transform get_sourceObjectB() { }
        private System.Boolean get_maintainPositionOffsets() { }
        private System.Boolean get_maintainRotationOffsets() { }
        private System.String get_blendPositionBoolProperty() { }
        private System.String get_blendRotationBoolProperty() { }
        private System.String get_positionWeightFloatProperty() { }
        private System.String get_rotationWeightFloatProperty() { }

    }

    // TypeToken: 0x2000009
    public class BlendConstraintJobBinder`1 : AnimationJobBinder`2
    {
        // Methods
        private UnityEngine.Animations.Rigging.BlendConstraintJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component) { }
        private System.Void Destroy(UnityEngine.Animations.Rigging.BlendConstraintJob job) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000A
    public struct ChainIKConstraintJob, IWeightedAnimationJob, IAnimationJob
    {
        // Fields
        public Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.ReadWriteTransformHandle> chain;        // 0x10
        public UnityEngine.Animations.Rigging.ReadOnlyTransformHandle target;        // 0x20
        public UnityEngine.Animations.Rigging.AffineTransform targetOffset;        // 0x38
        public Unity.Collections.NativeArray<System.Single> linkLengths;        // 0x58
        public Unity.Collections.NativeArray<UnityEngine.Vector3> linkPositions;        // 0x68
        public UnityEngine.Animations.Rigging.FloatProperty chainRotationWeight;        // 0x78
        public UnityEngine.Animations.Rigging.FloatProperty tipRotationWeight;        // 0x88
        public UnityEngine.Animations.Rigging.CacheIndex toleranceIdx;        // 0x98
        public UnityEngine.Animations.Rigging.CacheIndex maxIterationsIdx;        // 0x9C
        public UnityEngine.Animations.Rigging.AnimationJobCache cache;        // 0xA0
        public System.Single maxReach;        // 0xB0
        private UnityEngine.Animations.Rigging.FloatProperty <jobWeight>k__BackingField;        // 0xB4

        // Methods
        private UnityEngine.Animations.Rigging.FloatProperty get_jobWeight() { }
        private System.Void set_jobWeight(UnityEngine.Animations.Rigging.FloatProperty value) { }
        private System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream) { }

    }

    // TypeToken: 0x200000B
    public interface IChainIKConstraintData
    {
        // Methods
        private UnityEngine.Transform get_root() { }
        private UnityEngine.Transform get_tip() { }
        private UnityEngine.Transform get_target() { }
        private System.Int32 get_maxIterations() { }
        private System.Single get_tolerance() { }
        private System.Boolean get_maintainTargetPositionOffset() { }
        private System.Boolean get_maintainTargetRotationOffset() { }
        private System.String get_chainRotationWeightFloatProperty() { }
        private System.String get_tipRotationWeightFloatProperty() { }

    }

    // TypeToken: 0x200000C
    public class ChainIKConstraintJobBinder`1 : AnimationJobBinder`2
    {
        // Methods
        private UnityEngine.Animations.Rigging.ChainIKConstraintJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component) { }
        private System.Void Destroy(UnityEngine.Animations.Rigging.ChainIKConstraintJob job) { }
        private System.Void Update(UnityEngine.Animations.Rigging.ChainIKConstraintJob job, T& data) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000D
    public struct DampedTransformJob, IWeightedAnimationJob, IAnimationJob
    {
        // Fields
        private static System.Single k_FixedDt;        // 0x0
        private static System.Single k_DampFactor;        // 0x0
        public UnityEngine.Animations.Rigging.ReadWriteTransformHandle driven;        // 0x10
        public UnityEngine.Animations.Rigging.ReadOnlyTransformHandle source;        // 0x1C
        public UnityEngine.Animations.Rigging.AffineTransform localBindTx;        // 0x34
        public UnityEngine.Vector3 aimBindAxis;        // 0x50
        public UnityEngine.Animations.Rigging.AffineTransform prevDrivenTx;        // 0x5C
        public UnityEngine.Animations.Rigging.FloatProperty dampPosition;        // 0x78
        public UnityEngine.Animations.Rigging.FloatProperty dampRotation;        // 0x88
        private UnityEngine.Animations.Rigging.FloatProperty <jobWeight>k__BackingField;        // 0x98

        // Methods
        private UnityEngine.Animations.Rigging.FloatProperty get_jobWeight() { }
        private System.Void set_jobWeight(UnityEngine.Animations.Rigging.FloatProperty value) { }
        private System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream) { }

    }

    // TypeToken: 0x200000E
    public interface IDampedTransformData
    {
        // Methods
        private UnityEngine.Transform get_constrainedObject() { }
        private UnityEngine.Transform get_sourceObject() { }
        private System.Boolean get_maintainAim() { }
        private System.String get_dampPositionFloatProperty() { }
        private System.String get_dampRotationFloatProperty() { }

    }

    // TypeToken: 0x200000F
    public class DampedTransformJobBinder`1 : AnimationJobBinder`2
    {
        // Methods
        private UnityEngine.Animations.Rigging.DampedTransformJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component) { }
        private System.Void Destroy(UnityEngine.Animations.Rigging.DampedTransformJob job) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000010
    public interface IAnimatableProperty`1
    {
        // Methods
        private T Get(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void Set(UnityEngine.Animations.AnimationStream stream, T value) { }

    }

    // TypeToken: 0x2000011
    public struct BoolProperty, IAnimatableProperty`1
    {
        // Fields
        public UnityEngine.Animations.PropertyStreamHandle value;        // 0x10

        // Methods
        private UnityEngine.Animations.Rigging.BoolProperty Bind(UnityEngine.Animator animator, UnityEngine.Component component, System.String name) { }
        private UnityEngine.Animations.Rigging.BoolProperty BindCustom(UnityEngine.Animator animator, System.String property) { }
        private System.Boolean Get(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void Set(UnityEngine.Animations.AnimationStream stream, System.Boolean v) { }

    }

    // TypeToken: 0x2000012
    public struct IntProperty, IAnimatableProperty`1
    {
        // Fields
        public UnityEngine.Animations.PropertyStreamHandle value;        // 0x10

        // Methods
        private UnityEngine.Animations.Rigging.IntProperty Bind(UnityEngine.Animator animator, UnityEngine.Component component, System.String name) { }
        private UnityEngine.Animations.Rigging.IntProperty BindCustom(UnityEngine.Animator animator, System.String property) { }
        private System.Int32 Get(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void Set(UnityEngine.Animations.AnimationStream stream, System.Int32 v) { }

    }

    // TypeToken: 0x2000013
    public struct FloatProperty, IAnimatableProperty`1
    {
        // Fields
        public UnityEngine.Animations.PropertyStreamHandle value;        // 0x10

        // Methods
        private UnityEngine.Animations.Rigging.FloatProperty Bind(UnityEngine.Animator animator, UnityEngine.Component component, System.String name) { }
        private UnityEngine.Animations.Rigging.FloatProperty BindCustom(UnityEngine.Animator animator, System.String property) { }
        private System.Single Get(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void Set(UnityEngine.Animations.AnimationStream stream, System.Single v) { }

    }

    // TypeToken: 0x2000014
    public struct Vector2Property, IAnimatableProperty`1
    {
        // Fields
        public UnityEngine.Animations.PropertyStreamHandle x;        // 0x10
        public UnityEngine.Animations.PropertyStreamHandle y;        // 0x20

        // Methods
        private UnityEngine.Animations.Rigging.Vector2Property Bind(UnityEngine.Animator animator, UnityEngine.Component component, System.String name) { }
        private UnityEngine.Animations.Rigging.Vector2Property BindCustom(UnityEngine.Animator animator, System.String name) { }
        private UnityEngine.Vector2 Get(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void Set(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector2 value) { }

    }

    // TypeToken: 0x2000015
    public struct Vector3Property, IAnimatableProperty`1
    {
        // Fields
        public UnityEngine.Animations.PropertyStreamHandle x;        // 0x10
        public UnityEngine.Animations.PropertyStreamHandle y;        // 0x20
        public UnityEngine.Animations.PropertyStreamHandle z;        // 0x30

        // Methods
        private UnityEngine.Animations.Rigging.Vector3Property Bind(UnityEngine.Animator animator, UnityEngine.Component component, System.String name) { }
        private UnityEngine.Animations.Rigging.Vector3Property BindCustom(UnityEngine.Animator animator, System.String name) { }
        private UnityEngine.Vector3 Get(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void Set(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 value) { }

    }

    // TypeToken: 0x2000016
    public struct Vector3IntProperty, IAnimatableProperty`1
    {
        // Fields
        public UnityEngine.Animations.PropertyStreamHandle x;        // 0x10
        public UnityEngine.Animations.PropertyStreamHandle y;        // 0x20
        public UnityEngine.Animations.PropertyStreamHandle z;        // 0x30

        // Methods
        private UnityEngine.Animations.Rigging.Vector3IntProperty Bind(UnityEngine.Animator animator, UnityEngine.Component component, System.String name) { }
        private UnityEngine.Animations.Rigging.Vector3IntProperty BindCustom(UnityEngine.Animator animator, System.String name) { }
        private UnityEngine.Vector3Int Get(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void Set(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3Int value) { }

    }

    // TypeToken: 0x2000017
    public struct Vector3BoolProperty, IAnimatableProperty`1
    {
        // Fields
        public UnityEngine.Animations.PropertyStreamHandle x;        // 0x10
        public UnityEngine.Animations.PropertyStreamHandle y;        // 0x20
        public UnityEngine.Animations.PropertyStreamHandle z;        // 0x30

        // Methods
        private UnityEngine.Animations.Rigging.Vector3BoolProperty Bind(UnityEngine.Animator animator, UnityEngine.Component component, System.String name) { }
        private UnityEngine.Animations.Rigging.Vector3BoolProperty BindCustom(UnityEngine.Animator animator, System.String name) { }
        private UnityEngine.Animations.Rigging.Vector3Bool Get(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void Set(UnityEngine.Animations.AnimationStream stream, UnityEngine.Animations.Rigging.Vector3Bool value) { }

    }

    // TypeToken: 0x2000018
    public struct Vector4Property, IAnimatableProperty`1
    {
        // Fields
        public UnityEngine.Animations.PropertyStreamHandle x;        // 0x10
        public UnityEngine.Animations.PropertyStreamHandle y;        // 0x20
        public UnityEngine.Animations.PropertyStreamHandle z;        // 0x30
        public UnityEngine.Animations.PropertyStreamHandle w;        // 0x40

        // Methods
        private UnityEngine.Animations.Rigging.Vector4Property Bind(UnityEngine.Animator animator, UnityEngine.Component component, System.String name) { }
        private UnityEngine.Animations.Rigging.Vector4Property BindCustom(UnityEngine.Animator animator, System.String name) { }
        private UnityEngine.Vector4 Get(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void Set(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector4 value) { }

    }

    // TypeToken: 0x2000019
    public interface IAnimationJobBinder
    {
        // Methods
        private UnityEngine.Animations.IAnimationJob Create(UnityEngine.Animator animator, UnityEngine.Animations.Rigging.IAnimationJobData data, UnityEngine.Component component) { }
        private System.Void Destroy(UnityEngine.Animations.IAnimationJob job) { }
        private System.Void Update(UnityEngine.Animations.IAnimationJob job, UnityEngine.Animations.Rigging.IAnimationJobData data) { }
        private UnityEngine.Animations.AnimationScriptPlayable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animations.IAnimationJob job) { }

    }

    // TypeToken: 0x200001A
    public class AnimationJobBinder`2, IAnimationJobBinder
    {
        // Methods
        private TJob Create(UnityEngine.Animator animator, TData& data, UnityEngine.Component component) { }
        private System.Void Destroy(TJob job) { }
        private System.Void Update(TJob job, TData& data) { }
        private UnityEngine.Animations.IAnimationJob UnityEngine.Animations.Rigging.IAnimationJobBinder.Create(UnityEngine.Animator animator, UnityEngine.Animations.Rigging.IAnimationJobData data, UnityEngine.Component component) { }
        private System.Void UnityEngine.Animations.Rigging.IAnimationJobBinder.Destroy(UnityEngine.Animations.IAnimationJob job) { }
        private System.Void UnityEngine.Animations.Rigging.IAnimationJobBinder.Update(UnityEngine.Animations.IAnimationJob job, UnityEngine.Animations.Rigging.IAnimationJobData data) { }
        private UnityEngine.Animations.AnimationScriptPlayable UnityEngine.Animations.Rigging.IAnimationJobBinder.CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animations.IAnimationJob job) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001B
    public interface IAnimationJobData
    {
        // Methods
        private System.Boolean IsValid() { }
        private System.Void SetDefaultValues() { }

    }

    // TypeToken: 0x200001C
    public interface IWeightedAnimationJob : IAnimationJob
    {
        // Methods
        private UnityEngine.Animations.Rigging.FloatProperty get_jobWeight() { }
        private System.Void set_jobWeight(UnityEngine.Animations.Rigging.FloatProperty value) { }

    }

    // TypeToken: 0x200001D
    public struct MultiAimConstraintJob, IWeightedAnimationJob, IAnimationJob
    {
        // Fields
        private static System.Single k_Epsilon;        // 0x0
        public UnityEngine.Animations.Rigging.ReadWriteTransformHandle driven;        // 0x10
        public UnityEngine.Animations.Rigging.ReadOnlyTransformHandle drivenParent;        // 0x1C
        public UnityEngine.Animations.Rigging.Vector3Property drivenOffset;        // 0x34
        public Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.ReadOnlyTransformHandle> sourceTransforms;        // 0x68
        public Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle> sourceWeights;        // 0x78
        public Unity.Collections.NativeArray<UnityEngine.Quaternion> sourceOffsets;        // 0x88
        public Unity.Collections.NativeArray<System.Single> weightBuffer;        // 0x98
        public UnityEngine.Vector3 aimAxis;        // 0xA8
        public UnityEngine.Vector3 upAxis;        // 0xB4
        public UnityEngine.Animations.Rigging.MultiAimConstraintJob.WorldUpType worldUpType;        // 0xC0
        public UnityEngine.Vector3 worldUpAxis;        // 0xC4
        public UnityEngine.Animations.Rigging.ReadOnlyTransformHandle worldUpObject;        // 0xD0
        public UnityEngine.Vector3 axesMask;        // 0xE8
        public UnityEngine.Animations.Rigging.FloatProperty minLimit;        // 0xF4
        public UnityEngine.Animations.Rigging.FloatProperty maxLimit;        // 0x104
        private UnityEngine.Animations.Rigging.FloatProperty <jobWeight>k__BackingField;        // 0x114

        // Methods
        private UnityEngine.Animations.Rigging.FloatProperty get_jobWeight() { }
        private System.Void set_jobWeight(UnityEngine.Animations.Rigging.FloatProperty value) { }
        private System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream) { }
        private UnityEngine.Vector3 ComputeWorldUpVector(UnityEngine.Animations.AnimationStream stream) { }

    }

    // TypeToken: 0x200001F
    public interface IMultiAimConstraintData
    {
        // Methods
        private UnityEngine.Transform get_constrainedObject() { }
        private UnityEngine.Animations.Rigging.WeightedTransformArray get_sourceObjects() { }
        private System.Boolean get_maintainOffset() { }
        private UnityEngine.Vector3 get_aimAxis() { }
        private UnityEngine.Vector3 get_upAxis() { }
        private System.Int32 get_worldUpType() { }
        private UnityEngine.Vector3 get_worldUpAxis() { }
        private UnityEngine.Transform get_worldUpObject() { }
        private System.Boolean get_constrainedXAxis() { }
        private System.Boolean get_constrainedYAxis() { }
        private System.Boolean get_constrainedZAxis() { }
        private System.String get_offsetVector3Property() { }
        private System.String get_minLimitFloatProperty() { }
        private System.String get_maxLimitFloatProperty() { }
        private System.String get_sourceObjectsProperty() { }

    }

    // TypeToken: 0x2000020
    public class MultiAimConstraintJobBinder`1 : AnimationJobBinder`2
    {
        // Methods
        private UnityEngine.Animations.Rigging.MultiAimConstraintJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component) { }
        private System.Void Destroy(UnityEngine.Animations.Rigging.MultiAimConstraintJob job) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000021
    public struct MultiParentConstraintJob, IWeightedAnimationJob, IAnimationJob
    {
        // Fields
        private static System.Single k_Epsilon;        // 0x0
        public UnityEngine.Animations.Rigging.ReadWriteTransformHandle driven;        // 0x10
        public UnityEngine.Animations.Rigging.ReadOnlyTransformHandle drivenParent;        // 0x1C
        public Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.ReadOnlyTransformHandle> sourceTransforms;        // 0x38
        public Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle> sourceWeights;        // 0x48
        public Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.AffineTransform> sourceOffsets;        // 0x58
        public Unity.Collections.NativeArray<System.Single> weightBuffer;        // 0x68
        public UnityEngine.Vector3 positionAxesMask;        // 0x78
        public UnityEngine.Vector3 rotationAxesMask;        // 0x84
        private UnityEngine.Animations.Rigging.FloatProperty <jobWeight>k__BackingField;        // 0x90

        // Methods
        private UnityEngine.Animations.Rigging.FloatProperty get_jobWeight() { }
        private System.Void set_jobWeight(UnityEngine.Animations.Rigging.FloatProperty value) { }
        private System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream) { }

    }

    // TypeToken: 0x2000022
    public interface IMultiParentConstraintData
    {
        // Methods
        private UnityEngine.Transform get_constrainedObject() { }
        private UnityEngine.Animations.Rigging.WeightedTransformArray get_sourceObjects() { }
        private System.Boolean get_maintainPositionOffset() { }
        private System.Boolean get_maintainRotationOffset() { }
        private System.Boolean get_constrainedPositionXAxis() { }
        private System.Boolean get_constrainedPositionYAxis() { }
        private System.Boolean get_constrainedPositionZAxis() { }
        private System.Boolean get_constrainedRotationXAxis() { }
        private System.Boolean get_constrainedRotationYAxis() { }
        private System.Boolean get_constrainedRotationZAxis() { }
        private System.String get_sourceObjectsProperty() { }

    }

    // TypeToken: 0x2000023
    public class MultiParentConstraintJobBinder`1 : AnimationJobBinder`2
    {
        // Methods
        private UnityEngine.Animations.Rigging.MultiParentConstraintJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component) { }
        private System.Void Destroy(UnityEngine.Animations.Rigging.MultiParentConstraintJob job) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000024
    public struct MultiPositionConstraintJob, IWeightedAnimationJob, IAnimationJob
    {
        // Fields
        private static System.Single k_Epsilon;        // 0x0
        public UnityEngine.Animations.Rigging.ReadWriteTransformHandle driven;        // 0x10
        public UnityEngine.Animations.Rigging.ReadOnlyTransformHandle drivenParent;        // 0x1C
        public UnityEngine.Animations.Rigging.Vector3Property drivenOffset;        // 0x34
        public Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.ReadOnlyTransformHandle> sourceTransforms;        // 0x68
        public Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle> sourceWeights;        // 0x78
        public Unity.Collections.NativeArray<UnityEngine.Vector3> sourceOffsets;        // 0x88
        public Unity.Collections.NativeArray<System.Single> weightBuffer;        // 0x98
        public UnityEngine.Vector3 axesMask;        // 0xA8
        private UnityEngine.Animations.Rigging.FloatProperty <jobWeight>k__BackingField;        // 0xB4

        // Methods
        private UnityEngine.Animations.Rigging.FloatProperty get_jobWeight() { }
        private System.Void set_jobWeight(UnityEngine.Animations.Rigging.FloatProperty value) { }
        private System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream) { }

    }

    // TypeToken: 0x2000025
    public interface IMultiPositionConstraintData
    {
        // Methods
        private UnityEngine.Transform get_constrainedObject() { }
        private UnityEngine.Animations.Rigging.WeightedTransformArray get_sourceObjects() { }
        private System.Boolean get_maintainOffset() { }
        private System.String get_offsetVector3Property() { }
        private System.String get_sourceObjectsProperty() { }
        private System.Boolean get_constrainedXAxis() { }
        private System.Boolean get_constrainedYAxis() { }
        private System.Boolean get_constrainedZAxis() { }

    }

    // TypeToken: 0x2000026
    public class MultiPositionConstraintJobBinder`1 : AnimationJobBinder`2
    {
        // Methods
        private UnityEngine.Animations.Rigging.MultiPositionConstraintJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component) { }
        private System.Void Destroy(UnityEngine.Animations.Rigging.MultiPositionConstraintJob job) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000027
    public struct MultiReferentialConstraintJob, IWeightedAnimationJob, IAnimationJob
    {
        // Fields
        public UnityEngine.Animations.Rigging.IntProperty driver;        // 0x10
        public Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.ReadWriteTransformHandle> sources;        // 0x20
        public Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.AffineTransform> sourceBindTx;        // 0x30
        public Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.AffineTransform> offsetTx;        // 0x40
        private System.Int32 m_PrevDriverIdx;        // 0x50
        private UnityEngine.Animations.Rigging.FloatProperty <jobWeight>k__BackingField;        // 0x54

        // Methods
        private UnityEngine.Animations.Rigging.FloatProperty get_jobWeight() { }
        private System.Void set_jobWeight(UnityEngine.Animations.Rigging.FloatProperty value) { }
        private System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void UpdateOffsets(System.Int32 driver) { }

    }

    // TypeToken: 0x2000028
    public interface IMultiReferentialConstraintData
    {
        // Methods
        private System.Int32 get_driverValue() { }
        private System.String get_driverIntProperty() { }
        private UnityEngine.Transform[] get_sourceObjects() { }

    }

    // TypeToken: 0x2000029
    public class MultiReferentialConstraintJobBinder`1 : AnimationJobBinder`2
    {
        // Methods
        private UnityEngine.Animations.Rigging.MultiReferentialConstraintJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component) { }
        private System.Void Destroy(UnityEngine.Animations.Rigging.MultiReferentialConstraintJob job) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002A
    public struct MultiRotationConstraintJob, IWeightedAnimationJob, IAnimationJob
    {
        // Fields
        private static System.Single k_Epsilon;        // 0x0
        public UnityEngine.Animations.Rigging.ReadWriteTransformHandle driven;        // 0x10
        public UnityEngine.Animations.Rigging.ReadOnlyTransformHandle drivenParent;        // 0x1C
        public UnityEngine.Animations.Rigging.Vector3Property drivenOffset;        // 0x34
        public Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.ReadOnlyTransformHandle> sourceTransforms;        // 0x68
        public Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle> sourceWeights;        // 0x78
        public Unity.Collections.NativeArray<UnityEngine.Quaternion> sourceOffsets;        // 0x88
        public Unity.Collections.NativeArray<System.Single> weightBuffer;        // 0x98
        public UnityEngine.Vector3 axesMask;        // 0xA8
        private UnityEngine.Animations.Rigging.FloatProperty <jobWeight>k__BackingField;        // 0xB4

        // Methods
        private UnityEngine.Animations.Rigging.FloatProperty get_jobWeight() { }
        private System.Void set_jobWeight(UnityEngine.Animations.Rigging.FloatProperty value) { }
        private System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream) { }

    }

    // TypeToken: 0x200002B
    public interface IMultiRotationConstraintData
    {
        // Methods
        private UnityEngine.Transform get_constrainedObject() { }
        private UnityEngine.Animations.Rigging.WeightedTransformArray get_sourceObjects() { }
        private System.Boolean get_maintainOffset() { }
        private System.String get_offsetVector3Property() { }
        private System.String get_sourceObjectsProperty() { }
        private System.Boolean get_constrainedXAxis() { }
        private System.Boolean get_constrainedYAxis() { }
        private System.Boolean get_constrainedZAxis() { }

    }

    // TypeToken: 0x200002C
    public class MultiRotationConstraintJobBinder`1 : AnimationJobBinder`2
    {
        // Methods
        private UnityEngine.Animations.Rigging.MultiRotationConstraintJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component) { }
        private System.Void Destroy(UnityEngine.Animations.Rigging.MultiRotationConstraintJob job) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002D
    public struct OverrideTransformJob, IWeightedAnimationJob, IAnimationJob
    {
        // Fields
        public UnityEngine.Animations.Rigging.ReadWriteTransformHandle driven;        // 0x10
        public UnityEngine.Animations.Rigging.ReadOnlyTransformHandle source;        // 0x1C
        public UnityEngine.Animations.Rigging.AffineTransform sourceInvLocalBindTx;        // 0x34
        public UnityEngine.Quaternion sourceToWorldRot;        // 0x50
        public UnityEngine.Quaternion sourceToLocalRot;        // 0x60
        public UnityEngine.Quaternion sourceToPivotRot;        // 0x70
        public UnityEngine.Animations.Rigging.CacheIndex spaceIdx;        // 0x80
        public UnityEngine.Animations.Rigging.CacheIndex sourceToCurrSpaceRotIdx;        // 0x84
        public UnityEngine.Animations.Rigging.Vector3Property position;        // 0x88
        public UnityEngine.Animations.Rigging.Vector3Property rotation;        // 0xB8
        public UnityEngine.Animations.Rigging.FloatProperty positionWeight;        // 0xE8
        public UnityEngine.Animations.Rigging.FloatProperty rotationWeight;        // 0xF8
        public UnityEngine.Animations.Rigging.AnimationJobCache cache;        // 0x108
        private UnityEngine.Animations.Rigging.FloatProperty <jobWeight>k__BackingField;        // 0x118

        // Methods
        private UnityEngine.Animations.Rigging.FloatProperty get_jobWeight() { }
        private System.Void set_jobWeight(UnityEngine.Animations.Rigging.FloatProperty value) { }
        private System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void UpdateSpace(System.Int32 space) { }

    }

    // TypeToken: 0x200002F
    public interface IOverrideTransformData
    {
        // Methods
        private UnityEngine.Transform get_constrainedObject() { }
        private UnityEngine.Transform get_sourceObject() { }
        private System.Int32 get_space() { }
        private System.String get_positionWeightFloatProperty() { }
        private System.String get_rotationWeightFloatProperty() { }
        private System.String get_positionVector3Property() { }
        private System.String get_rotationVector3Property() { }

    }

    // TypeToken: 0x2000030
    public class OverrideTransformJobBinder`1 : AnimationJobBinder`2
    {
        // Methods
        private UnityEngine.Animations.Rigging.OverrideTransformJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component) { }
        private System.Void Destroy(UnityEngine.Animations.Rigging.OverrideTransformJob job) { }
        private System.Void Update(UnityEngine.Animations.Rigging.OverrideTransformJob job, T& data) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000031
    public struct RigSyncSceneToStreamJob, IAnimationJob
    {
        // Fields
        public UnityEngine.Animations.Rigging.RigSyncSceneToStreamJob.TransformSyncer transformSyncer;        // 0x10
        public UnityEngine.Animations.Rigging.RigSyncSceneToStreamJob.PropertySyncer propertySyncer;        // 0x30
        public UnityEngine.Animations.Rigging.RigSyncSceneToStreamJob.PropertySyncer rigWeightSyncer;        // 0x60
        public UnityEngine.Animations.Rigging.RigSyncSceneToStreamJob.PropertySyncer constraintWeightSyncer;        // 0x90
        public Unity.Collections.NativeArray<System.Single> rigStates;        // 0xC0
        public Unity.Collections.NativeArray<System.Int32> rigConstraintEndIdx;        // 0xD0
        public Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle> modulatedConstraintWeights;        // 0xE0

        // Methods
        private System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream) { }

    }

    // TypeToken: 0x2000034
    public struct SyncableProperties
    {
        // Fields
        public UnityEngine.Animations.Rigging.RigProperties rig;        // 0x10
        public UnityEngine.Animations.Rigging.ConstraintProperties[] constraints;        // 0x18

    }

    // TypeToken: 0x2000035
    public interface IRigSyncSceneToStreamData
    {
        // Methods
        private UnityEngine.Transform[] get_syncableTransforms() { }
        private UnityEngine.Animations.Rigging.SyncableProperties[] get_syncableProperties() { }
        private System.Boolean[] get_rigStates() { }

    }

    // TypeToken: 0x2000036
    public class RigSyncSceneToStreamJobBinder`1 : AnimationJobBinder`2
    {
        // Fields
        private static System.String[] s_PropertyElementNames;        // 0x0

        // Methods
        private UnityEngine.Animations.Rigging.RigSyncSceneToStreamJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component) { }
        private System.Void Destroy(UnityEngine.Animations.Rigging.RigSyncSceneToStreamJob job) { }
        private System.Void Update(UnityEngine.Animations.Rigging.RigSyncSceneToStreamJob job, T& data) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000037
    public struct ReadWriteTransformHandle
    {
        // Fields
        private UnityEngine.Animations.TransformStreamHandle m_Handle;        // 0x10

        // Methods
        private UnityEngine.Vector3 GetLocalPosition(UnityEngine.Animations.AnimationStream stream) { }
        private UnityEngine.Quaternion GetLocalRotation(UnityEngine.Animations.AnimationStream stream) { }
        private UnityEngine.Vector3 GetLocalScale(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void GetLocalTRS(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale) { }
        private System.Void SetLocalPosition(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position) { }
        private System.Void SetLocalRotation(UnityEngine.Animations.AnimationStream stream, UnityEngine.Quaternion rotation) { }
        private System.Void SetLocalScale(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 scale) { }
        private System.Void SetLocalTRS(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale, System.Boolean useMask) { }
        private UnityEngine.Vector3 GetPosition(UnityEngine.Animations.AnimationStream stream) { }
        private UnityEngine.Quaternion GetRotation(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void GetGlobalTR(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation) { }
        private System.Void SetPosition(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position) { }
        private System.Void SetRotation(UnityEngine.Animations.AnimationStream stream, UnityEngine.Quaternion rotation) { }
        private System.Void SetGlobalTR(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Boolean useMask) { }
        private System.Boolean IsResolved(UnityEngine.Animations.AnimationStream stream) { }
        private System.Boolean IsValid(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void Resolve(UnityEngine.Animations.AnimationStream stream) { }
        private UnityEngine.Animations.Rigging.ReadWriteTransformHandle Bind(UnityEngine.Animator animator, UnityEngine.Transform transform) { }

    }

    // TypeToken: 0x2000038
    public struct ReadOnlyTransformHandle
    {
        // Fields
        private UnityEngine.Animations.TransformStreamHandle m_StreamHandle;        // 0x10
        private UnityEngine.Animations.TransformSceneHandle m_SceneHandle;        // 0x1C
        private System.Byte m_InStream;        // 0x24

        // Methods
        private UnityEngine.Vector3 GetLocalPosition(UnityEngine.Animations.AnimationStream stream) { }
        private UnityEngine.Quaternion GetLocalRotation(UnityEngine.Animations.AnimationStream stream) { }
        private UnityEngine.Vector3 GetLocalScale(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void GetLocalTRS(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale) { }
        private UnityEngine.Vector3 GetPosition(UnityEngine.Animations.AnimationStream stream) { }
        private UnityEngine.Quaternion GetRotation(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void GetGlobalTR(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation) { }
        private System.Boolean IsResolved(UnityEngine.Animations.AnimationStream stream) { }
        private System.Boolean IsValid(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void Resolve(UnityEngine.Animations.AnimationStream stream) { }
        private UnityEngine.Animations.Rigging.ReadOnlyTransformHandle Bind(UnityEngine.Animator animator, UnityEngine.Transform transform) { }

    }

    // TypeToken: 0x2000039
    public struct TwistChainConstraintJob, IWeightedAnimationJob, IAnimationJob
    {
        // Fields
        public UnityEngine.Animations.Rigging.ReadWriteTransformHandle rootTarget;        // 0x10
        public UnityEngine.Animations.Rigging.ReadWriteTransformHandle tipTarget;        // 0x1C
        public Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.ReadWriteTransformHandle> chain;        // 0x28
        public Unity.Collections.NativeArray<System.Single> steps;        // 0x38
        public Unity.Collections.NativeArray<System.Single> weights;        // 0x48
        public Unity.Collections.NativeArray<UnityEngine.Quaternion> rotations;        // 0x58
        private UnityEngine.Animations.Rigging.FloatProperty <jobWeight>k__BackingField;        // 0x68

        // Methods
        private UnityEngine.Animations.Rigging.FloatProperty get_jobWeight() { }
        private System.Void set_jobWeight(UnityEngine.Animations.Rigging.FloatProperty value) { }
        private System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream) { }

    }

    // TypeToken: 0x200003A
    public interface ITwistChainConstraintData
    {
        // Methods
        private UnityEngine.Transform get_root() { }
        private UnityEngine.Transform get_tip() { }
        private UnityEngine.Transform get_rootTarget() { }
        private UnityEngine.Transform get_tipTarget() { }
        private UnityEngine.AnimationCurve get_curve() { }

    }

    // TypeToken: 0x200003B
    public class TwistChainConstraintJobBinder`1 : AnimationJobBinder`2
    {
        // Methods
        private UnityEngine.Animations.Rigging.TwistChainConstraintJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component) { }
        private System.Void Destroy(UnityEngine.Animations.Rigging.TwistChainConstraintJob job) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003C
    public struct TwistCorrectionJob, IWeightedAnimationJob, IAnimationJob
    {
        // Fields
        public UnityEngine.Animations.Rigging.ReadOnlyTransformHandle source;        // 0x10
        public UnityEngine.Quaternion sourceInverseBindRotation;        // 0x28
        public UnityEngine.Vector3 axisMask;        // 0x38
        public Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.ReadWriteTransformHandle> twistTransforms;        // 0x48
        public Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle> twistWeights;        // 0x58
        public Unity.Collections.NativeArray<UnityEngine.Quaternion> twistBindRotations;        // 0x68
        public Unity.Collections.NativeArray<System.Single> weightBuffer;        // 0x78
        private UnityEngine.Animations.Rigging.FloatProperty <jobWeight>k__BackingField;        // 0x88

        // Methods
        private UnityEngine.Animations.Rigging.FloatProperty get_jobWeight() { }
        private System.Void set_jobWeight(UnityEngine.Animations.Rigging.FloatProperty value) { }
        private System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream) { }
        private UnityEngine.Quaternion TwistRotation(UnityEngine.Vector3 axis, UnityEngine.Quaternion rot) { }

    }

    // TypeToken: 0x200003D
    public interface ITwistCorrectionData
    {
        // Methods
        private UnityEngine.Transform get_source() { }
        private UnityEngine.Animations.Rigging.WeightedTransformArray get_twistNodes() { }
        private UnityEngine.Vector3 get_twistAxis() { }
        private System.String get_twistNodesProperty() { }

    }

    // TypeToken: 0x200003E
    public class TwistCorrectionJobBinder`1 : AnimationJobBinder`2
    {
        // Methods
        private UnityEngine.Animations.Rigging.TwistCorrectionJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component) { }
        private System.Void Destroy(UnityEngine.Animations.Rigging.TwistCorrectionJob job) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003F
    public struct TwoBoneIKConstraintJob, IWeightedAnimationJob, IAnimationJob
    {
        // Fields
        public UnityEngine.Animations.Rigging.ReadWriteTransformHandle root;        // 0x10
        public UnityEngine.Animations.Rigging.ReadWriteTransformHandle mid;        // 0x1C
        public UnityEngine.Animations.Rigging.ReadWriteTransformHandle tip;        // 0x28
        public UnityEngine.Animations.Rigging.ReadOnlyTransformHandle hint;        // 0x34
        public UnityEngine.Animations.Rigging.ReadOnlyTransformHandle target;        // 0x4C
        public UnityEngine.Animations.Rigging.AffineTransform targetOffset;        // 0x64
        public UnityEngine.Animations.Rigging.FloatProperty targetPositionWeight;        // 0x80
        public UnityEngine.Animations.Rigging.FloatProperty targetRotationWeight;        // 0x90
        public UnityEngine.Animations.Rigging.FloatProperty hintWeight;        // 0xA0
        private UnityEngine.Animations.Rigging.FloatProperty <jobWeight>k__BackingField;        // 0xB0

        // Methods
        private UnityEngine.Animations.Rigging.FloatProperty get_jobWeight() { }
        private System.Void set_jobWeight(UnityEngine.Animations.Rigging.FloatProperty value) { }
        private System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream) { }

    }

    // TypeToken: 0x2000040
    public interface ITwoBoneIKConstraintData
    {
        // Methods
        private UnityEngine.Transform get_root() { }
        private UnityEngine.Transform get_mid() { }
        private UnityEngine.Transform get_tip() { }
        private UnityEngine.Transform get_target() { }
        private UnityEngine.Transform get_hint() { }
        private System.Boolean get_maintainTargetPositionOffset() { }
        private System.Boolean get_maintainTargetRotationOffset() { }
        private System.String get_targetPositionWeightFloatProperty() { }
        private System.String get_targetRotationWeightFloatProperty() { }
        private System.String get_hintWeightFloatProperty() { }

    }

    // TypeToken: 0x2000041
    public class TwoBoneIKConstraintJobBinder`1 : AnimationJobBinder`2
    {
        // Methods
        private UnityEngine.Animations.Rigging.TwoBoneIKConstraintJob Create(UnityEngine.Animator animator, T& data, UnityEngine.Component component) { }
        private System.Void Destroy(UnityEngine.Animations.Rigging.TwoBoneIKConstraintJob job) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000042
    public class WeightedTransformArrayBinder
    {
        // Methods
        private System.Void BindReadOnlyTransforms(UnityEngine.Animator animator, UnityEngine.Component component, UnityEngine.Animations.Rigging.WeightedTransformArray weightedTransformArray, Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.ReadOnlyTransformHandle>& transforms) { }
        private System.Void BindReadWriteTransforms(UnityEngine.Animator animator, UnityEngine.Component component, UnityEngine.Animations.Rigging.WeightedTransformArray weightedTransformArray, Unity.Collections.NativeArray<UnityEngine.Animations.Rigging.ReadWriteTransformHandle>& transforms) { }
        private System.Void BindWeights(UnityEngine.Animator animator, UnityEngine.Component component, UnityEngine.Animations.Rigging.WeightedTransformArray weightedTransformArray, System.String name, Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle>& weights) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000043
    public struct BlendConstraintData, IAnimationJobData, IBlendConstraintData
    {
        // Fields
        private UnityEngine.Transform m_ConstrainedObject;        // 0x10
        private UnityEngine.Transform m_SourceA;        // 0x18
        private UnityEngine.Transform m_SourceB;        // 0x20
        private System.Boolean m_BlendPosition;        // 0x28
        private System.Boolean m_BlendRotation;        // 0x29
        private System.Single m_PositionWeight;        // 0x2C
        private System.Single m_RotationWeight;        // 0x30
        private System.Boolean m_MaintainPositionOffsets;        // 0x34
        private System.Boolean m_MaintainRotationOffsets;        // 0x35

        // Methods
        private UnityEngine.Transform get_constrainedObject() { }
        private System.Void set_constrainedObject(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_sourceObjectA() { }
        private System.Void set_sourceObjectA(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_sourceObjectB() { }
        private System.Void set_sourceObjectB(UnityEngine.Transform value) { }
        private System.Boolean get_blendPosition() { }
        private System.Void set_blendPosition(System.Boolean value) { }
        private System.Boolean get_blendRotation() { }
        private System.Void set_blendRotation(System.Boolean value) { }
        private System.Single get_positionWeight() { }
        private System.Void set_positionWeight(System.Single value) { }
        private System.Single get_rotationWeight() { }
        private System.Void set_rotationWeight(System.Single value) { }
        private System.Boolean get_maintainPositionOffsets() { }
        private System.Void set_maintainPositionOffsets(System.Boolean value) { }
        private System.Boolean get_maintainRotationOffsets() { }
        private System.Void set_maintainRotationOffsets(System.Boolean value) { }
        private System.String UnityEngine.Animations.Rigging.IBlendConstraintData.get_blendPositionBoolProperty() { }
        private System.String UnityEngine.Animations.Rigging.IBlendConstraintData.get_blendRotationBoolProperty() { }
        private System.String UnityEngine.Animations.Rigging.IBlendConstraintData.get_positionWeightFloatProperty() { }
        private System.String UnityEngine.Animations.Rigging.IBlendConstraintData.get_rotationWeightFloatProperty() { }
        private System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }
        private System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

    }

    // TypeToken: 0x2000044
    public class BlendConstraint : RigConstraint`3
    {
        // Methods
        private System.Void OnValidate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000045
    public struct ChainIKConstraintData, IAnimationJobData, IChainIKConstraintData
    {
        // Fields
        private static System.Int32 k_MinIterations;        // 0x0
        private static System.Int32 k_MaxIterations;        // 0x0
        private static System.Single k_MinTolerance;        // 0x0
        private static System.Single k_MaxTolerance;        // 0x0
        private UnityEngine.Transform m_Root;        // 0x10
        private UnityEngine.Transform m_Tip;        // 0x18
        private UnityEngine.Transform m_Target;        // 0x20
        private System.Single m_ChainRotationWeight;        // 0x28
        private System.Single m_TipRotationWeight;        // 0x2C
        private System.Int32 m_MaxIterations;        // 0x30
        private System.Single m_Tolerance;        // 0x34
        private System.Boolean m_MaintainTargetPositionOffset;        // 0x38
        private System.Boolean m_MaintainTargetRotationOffset;        // 0x39

        // Methods
        private UnityEngine.Transform get_root() { }
        private System.Void set_root(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_tip() { }
        private System.Void set_tip(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_target() { }
        private System.Void set_target(UnityEngine.Transform value) { }
        private System.Single get_chainRotationWeight() { }
        private System.Void set_chainRotationWeight(System.Single value) { }
        private System.Single get_tipRotationWeight() { }
        private System.Void set_tipRotationWeight(System.Single value) { }
        private System.Int32 get_maxIterations() { }
        private System.Void set_maxIterations(System.Int32 value) { }
        private System.Single get_tolerance() { }
        private System.Void set_tolerance(System.Single value) { }
        private System.Boolean get_maintainTargetPositionOffset() { }
        private System.Void set_maintainTargetPositionOffset(System.Boolean value) { }
        private System.Boolean get_maintainTargetRotationOffset() { }
        private System.Void set_maintainTargetRotationOffset(System.Boolean value) { }
        private System.String UnityEngine.Animations.Rigging.IChainIKConstraintData.get_chainRotationWeightFloatProperty() { }
        private System.String UnityEngine.Animations.Rigging.IChainIKConstraintData.get_tipRotationWeightFloatProperty() { }
        private System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }
        private System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

    }

    // TypeToken: 0x2000046
    public class ChainIKConstraint : RigConstraint`3
    {
        // Methods
        private System.Void OnValidate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000047
    public struct DampedTransformData, IAnimationJobData, IDampedTransformData
    {
        // Fields
        private UnityEngine.Transform m_ConstrainedObject;        // 0x10
        private UnityEngine.Transform m_Source;        // 0x18
        private System.Single m_DampPosition;        // 0x20
        private System.Single m_DampRotation;        // 0x24
        private System.Boolean m_MaintainAim;        // 0x28

        // Methods
        private UnityEngine.Transform get_constrainedObject() { }
        private System.Void set_constrainedObject(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_sourceObject() { }
        private System.Void set_sourceObject(UnityEngine.Transform value) { }
        private System.Single get_dampPosition() { }
        private System.Void set_dampPosition(System.Single value) { }
        private System.Single get_dampRotation() { }
        private System.Void set_dampRotation(System.Single value) { }
        private System.Boolean get_maintainAim() { }
        private System.Void set_maintainAim(System.Boolean value) { }
        private System.String UnityEngine.Animations.Rigging.IDampedTransformData.get_dampPositionFloatProperty() { }
        private System.String UnityEngine.Animations.Rigging.IDampedTransformData.get_dampRotationFloatProperty() { }
        private System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }
        private System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

    }

    // TypeToken: 0x2000048
    public class DampedTransform : RigConstraint`3
    {
        // Methods
        private System.Void OnValidate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000049
    public struct MultiAimConstraintData, IAnimationJobData, IMultiAimConstraintData
    {
        // Fields
        private static System.Single k_MinAngularLimit;        // 0x0
        private static System.Single k_MaxAngularLimit;        // 0x0
        private UnityEngine.Transform m_ConstrainedObject;        // 0x10
        private UnityEngine.Animations.Rigging.WeightedTransformArray m_SourceObjects;        // 0x18
        private UnityEngine.Vector3 m_Offset;        // 0xA0
        private System.Single m_MinLimit;        // 0xAC
        private System.Single m_MaxLimit;        // 0xB0
        private UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis m_AimAxis;        // 0xB4
        private UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis m_UpAxis;        // 0xB8
        private UnityEngine.Animations.Rigging.MultiAimConstraintData.WorldUpType m_WorldUpType;        // 0xBC
        private UnityEngine.Transform m_WorldUpObject;        // 0xC0
        private UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis m_WorldUpAxis;        // 0xC8
        private System.Boolean m_MaintainOffset;        // 0xCC
        private UnityEngine.Animations.Rigging.Vector3Bool m_ConstrainedAxes;        // 0xCD

        // Methods
        private UnityEngine.Transform get_constrainedObject() { }
        private System.Void set_constrainedObject(UnityEngine.Transform value) { }
        private UnityEngine.Animations.Rigging.WeightedTransformArray get_sourceObjects() { }
        private System.Void set_sourceObjects(UnityEngine.Animations.Rigging.WeightedTransformArray value) { }
        private System.Boolean get_maintainOffset() { }
        private System.Void set_maintainOffset(System.Boolean value) { }
        private UnityEngine.Vector3 get_offset() { }
        private System.Void set_offset(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector2 get_limits() { }
        private System.Void set_limits(UnityEngine.Vector2 value) { }
        private UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis get_aimAxis() { }
        private System.Void set_aimAxis(UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis value) { }
        private UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis get_upAxis() { }
        private System.Void set_upAxis(UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis value) { }
        private UnityEngine.Animations.Rigging.MultiAimConstraintData.WorldUpType get_worldUpType() { }
        private System.Void set_worldUpType(UnityEngine.Animations.Rigging.MultiAimConstraintData.WorldUpType value) { }
        private UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis get_worldUpAxis() { }
        private System.Void set_worldUpAxis(UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis value) { }
        private UnityEngine.Transform get_worldUpObject() { }
        private System.Void set_worldUpObject(UnityEngine.Transform value) { }
        private System.Boolean get_constrainedXAxis() { }
        private System.Void set_constrainedXAxis(System.Boolean value) { }
        private System.Boolean get_constrainedYAxis() { }
        private System.Void set_constrainedYAxis(System.Boolean value) { }
        private System.Boolean get_constrainedZAxis() { }
        private System.Void set_constrainedZAxis(System.Boolean value) { }
        private UnityEngine.Vector3 UnityEngine.Animations.Rigging.IMultiAimConstraintData.get_aimAxis() { }
        private UnityEngine.Vector3 UnityEngine.Animations.Rigging.IMultiAimConstraintData.get_upAxis() { }
        private System.Int32 UnityEngine.Animations.Rigging.IMultiAimConstraintData.get_worldUpType() { }
        private UnityEngine.Vector3 UnityEngine.Animations.Rigging.IMultiAimConstraintData.get_worldUpAxis() { }
        private System.String UnityEngine.Animations.Rigging.IMultiAimConstraintData.get_offsetVector3Property() { }
        private System.String UnityEngine.Animations.Rigging.IMultiAimConstraintData.get_minLimitFloatProperty() { }
        private System.String UnityEngine.Animations.Rigging.IMultiAimConstraintData.get_maxLimitFloatProperty() { }
        private System.String UnityEngine.Animations.Rigging.IMultiAimConstraintData.get_sourceObjectsProperty() { }
        private System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }
        private System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }
        private UnityEngine.Vector3 Convert(UnityEngine.Animations.Rigging.MultiAimConstraintData.Axis axis) { }

    }

    // TypeToken: 0x200004C
    public class MultiAimConstraint : RigConstraint`3
    {
        // Methods
        private System.Void OnValidate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004D
    public struct MultiParentConstraintData, IAnimationJobData, IMultiParentConstraintData
    {
        // Fields
        private UnityEngine.Transform m_ConstrainedObject;        // 0x10
        private UnityEngine.Animations.Rigging.WeightedTransformArray m_SourceObjects;        // 0x18
        private UnityEngine.Animations.Rigging.Vector3Bool m_ConstrainedPositionAxes;        // 0xA0
        private UnityEngine.Animations.Rigging.Vector3Bool m_ConstrainedRotationAxes;        // 0xA3
        private System.Boolean m_MaintainPositionOffset;        // 0xA6
        private System.Boolean m_MaintainRotationOffset;        // 0xA7

        // Methods
        private UnityEngine.Transform get_constrainedObject() { }
        private System.Void set_constrainedObject(UnityEngine.Transform value) { }
        private UnityEngine.Animations.Rigging.WeightedTransformArray get_sourceObjects() { }
        private System.Void set_sourceObjects(UnityEngine.Animations.Rigging.WeightedTransformArray value) { }
        private System.Boolean get_maintainPositionOffset() { }
        private System.Void set_maintainPositionOffset(System.Boolean value) { }
        private System.Boolean get_maintainRotationOffset() { }
        private System.Void set_maintainRotationOffset(System.Boolean value) { }
        private System.Boolean get_constrainedPositionXAxis() { }
        private System.Void set_constrainedPositionXAxis(System.Boolean value) { }
        private System.Boolean get_constrainedPositionYAxis() { }
        private System.Void set_constrainedPositionYAxis(System.Boolean value) { }
        private System.Boolean get_constrainedPositionZAxis() { }
        private System.Void set_constrainedPositionZAxis(System.Boolean value) { }
        private System.Boolean get_constrainedRotationXAxis() { }
        private System.Void set_constrainedRotationXAxis(System.Boolean value) { }
        private System.Boolean get_constrainedRotationYAxis() { }
        private System.Void set_constrainedRotationYAxis(System.Boolean value) { }
        private System.Boolean get_constrainedRotationZAxis() { }
        private System.Void set_constrainedRotationZAxis(System.Boolean value) { }
        private System.String UnityEngine.Animations.Rigging.IMultiParentConstraintData.get_sourceObjectsProperty() { }
        private System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }
        private System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

    }

    // TypeToken: 0x200004E
    public class MultiParentConstraint : RigConstraint`3
    {
        // Methods
        private System.Void OnValidate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004F
    public struct MultiPositionConstraintData, IAnimationJobData, IMultiPositionConstraintData
    {
        // Fields
        private UnityEngine.Transform m_ConstrainedObject;        // 0x10
        private UnityEngine.Animations.Rigging.WeightedTransformArray m_SourceObjects;        // 0x18
        private UnityEngine.Vector3 m_Offset;        // 0xA0
        private UnityEngine.Animations.Rigging.Vector3Bool m_ConstrainedAxes;        // 0xAC
        private System.Boolean m_MaintainOffset;        // 0xAF

        // Methods
        private UnityEngine.Transform get_constrainedObject() { }
        private System.Void set_constrainedObject(UnityEngine.Transform value) { }
        private UnityEngine.Animations.Rigging.WeightedTransformArray get_sourceObjects() { }
        private System.Void set_sourceObjects(UnityEngine.Animations.Rigging.WeightedTransformArray value) { }
        private System.Boolean get_maintainOffset() { }
        private System.Void set_maintainOffset(System.Boolean value) { }
        private UnityEngine.Vector3 get_offset() { }
        private System.Void set_offset(UnityEngine.Vector3 value) { }
        private System.Boolean get_constrainedXAxis() { }
        private System.Void set_constrainedXAxis(System.Boolean value) { }
        private System.Boolean get_constrainedYAxis() { }
        private System.Void set_constrainedYAxis(System.Boolean value) { }
        private System.Boolean get_constrainedZAxis() { }
        private System.Void set_constrainedZAxis(System.Boolean value) { }
        private System.String UnityEngine.Animations.Rigging.IMultiPositionConstraintData.get_offsetVector3Property() { }
        private System.String UnityEngine.Animations.Rigging.IMultiPositionConstraintData.get_sourceObjectsProperty() { }
        private System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }
        private System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

    }

    // TypeToken: 0x2000050
    public class MultiPositionConstraint : RigConstraint`3
    {
        // Methods
        private System.Void OnValidate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000051
    public struct MultiReferentialConstraintData, IAnimationJobData, IMultiReferentialConstraintData
    {
        // Fields
        private System.Int32 m_Driver;        // 0x10
        private System.Collections.Generic.List<UnityEngine.Transform> m_SourceObjects;        // 0x18

        // Methods
        private System.Int32 get_driver() { }
        private System.Void set_driver(System.Int32 value) { }
        private System.Collections.Generic.List<UnityEngine.Transform> get_sourceObjects() { }
        private System.Void set_sourceObjects(System.Collections.Generic.List<UnityEngine.Transform> value) { }
        private UnityEngine.Transform[] UnityEngine.Animations.Rigging.IMultiReferentialConstraintData.get_sourceObjects() { }
        private System.Int32 UnityEngine.Animations.Rigging.IMultiReferentialConstraintData.get_driverValue() { }
        private System.String UnityEngine.Animations.Rigging.IMultiReferentialConstraintData.get_driverIntProperty() { }
        private System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }
        private System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }
        private System.Void UpdateDriver() { }

    }

    // TypeToken: 0x2000052
    public class MultiReferentialConstraint : RigConstraint`3
    {
        // Methods
        private System.Void OnValidate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000053
    public struct MultiRotationConstraintData, IAnimationJobData, IMultiRotationConstraintData
    {
        // Fields
        private UnityEngine.Transform m_ConstrainedObject;        // 0x10
        private UnityEngine.Animations.Rigging.WeightedTransformArray m_SourceObjects;        // 0x18
        private UnityEngine.Vector3 m_Offset;        // 0xA0
        private UnityEngine.Animations.Rigging.Vector3Bool m_ConstrainedAxes;        // 0xAC
        private System.Boolean m_MaintainOffset;        // 0xAF

        // Methods
        private UnityEngine.Transform get_constrainedObject() { }
        private System.Void set_constrainedObject(UnityEngine.Transform value) { }
        private UnityEngine.Animations.Rigging.WeightedTransformArray get_sourceObjects() { }
        private System.Void set_sourceObjects(UnityEngine.Animations.Rigging.WeightedTransformArray value) { }
        private System.Boolean get_maintainOffset() { }
        private System.Void set_maintainOffset(System.Boolean value) { }
        private UnityEngine.Vector3 get_offset() { }
        private System.Void set_offset(UnityEngine.Vector3 value) { }
        private System.Boolean get_constrainedXAxis() { }
        private System.Void set_constrainedXAxis(System.Boolean value) { }
        private System.Boolean get_constrainedYAxis() { }
        private System.Void set_constrainedYAxis(System.Boolean value) { }
        private System.Boolean get_constrainedZAxis() { }
        private System.Void set_constrainedZAxis(System.Boolean value) { }
        private System.String UnityEngine.Animations.Rigging.IMultiRotationConstraintData.get_offsetVector3Property() { }
        private System.String UnityEngine.Animations.Rigging.IMultiRotationConstraintData.get_sourceObjectsProperty() { }
        private System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }
        private System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

    }

    // TypeToken: 0x2000054
    public class MultiRotationConstraint : RigConstraint`3
    {
        // Methods
        private System.Void OnValidate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000055
    public struct OverrideTransformData, IAnimationJobData, IOverrideTransformData
    {
        // Fields
        private UnityEngine.Transform m_ConstrainedObject;        // 0x10
        private UnityEngine.Transform m_OverrideSource;        // 0x18
        private UnityEngine.Vector3 m_OverridePosition;        // 0x20
        private UnityEngine.Vector3 m_OverrideRotation;        // 0x2C
        private System.Single m_PositionWeight;        // 0x38
        private System.Single m_RotationWeight;        // 0x3C
        private UnityEngine.Animations.Rigging.OverrideTransformData.Space m_Space;        // 0x40

        // Methods
        private UnityEngine.Transform get_constrainedObject() { }
        private System.Void set_constrainedObject(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_sourceObject() { }
        private System.Void set_sourceObject(UnityEngine.Transform value) { }
        private UnityEngine.Animations.Rigging.OverrideTransformData.Space get_space() { }
        private System.Void set_space(UnityEngine.Animations.Rigging.OverrideTransformData.Space value) { }
        private UnityEngine.Vector3 get_position() { }
        private System.Void set_position(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_rotation() { }
        private System.Void set_rotation(UnityEngine.Vector3 value) { }
        private System.Single get_positionWeight() { }
        private System.Void set_positionWeight(System.Single value) { }
        private System.Single get_rotationWeight() { }
        private System.Void set_rotationWeight(System.Single value) { }
        private System.Int32 UnityEngine.Animations.Rigging.IOverrideTransformData.get_space() { }
        private System.String UnityEngine.Animations.Rigging.IOverrideTransformData.get_positionWeightFloatProperty() { }
        private System.String UnityEngine.Animations.Rigging.IOverrideTransformData.get_rotationWeightFloatProperty() { }
        private System.String UnityEngine.Animations.Rigging.IOverrideTransformData.get_positionVector3Property() { }
        private System.String UnityEngine.Animations.Rigging.IOverrideTransformData.get_rotationVector3Property() { }
        private System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }
        private System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

    }

    // TypeToken: 0x2000057
    public class OverrideTransform : RigConstraint`3
    {
        // Methods
        private System.Void OnValidate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000058
    public struct TwistChainConstraintData, IAnimationJobData, ITwistChainConstraintData
    {
        // Fields
        private UnityEngine.Transform m_Root;        // 0x10
        private UnityEngine.Transform m_Tip;        // 0x18
        private UnityEngine.Transform m_RootTarget;        // 0x20
        private UnityEngine.Transform m_TipTarget;        // 0x28
        private UnityEngine.AnimationCurve m_Curve;        // 0x30

        // Methods
        private UnityEngine.Transform get_root() { }
        private System.Void set_root(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_tip() { }
        private System.Void set_tip(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_rootTarget() { }
        private System.Void set_rootTarget(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_tipTarget() { }
        private System.Void set_tipTarget(UnityEngine.Transform value) { }
        private UnityEngine.AnimationCurve get_curve() { }
        private System.Void set_curve(UnityEngine.AnimationCurve value) { }
        private System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }
        private System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

    }

    // TypeToken: 0x2000059
    public class TwistChainConstraint : RigConstraint`3
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005A
    public struct TwistCorrectionData, IAnimationJobData, ITwistCorrectionData
    {
        // Fields
        private UnityEngine.Transform m_Source;        // 0x10
        private UnityEngine.Animations.Rigging.TwistCorrectionData.Axis m_TwistAxis;        // 0x18
        private UnityEngine.Animations.Rigging.WeightedTransformArray m_TwistNodes;        // 0x20

        // Methods
        private UnityEngine.Transform get_sourceObject() { }
        private System.Void set_sourceObject(UnityEngine.Transform value) { }
        private UnityEngine.Animations.Rigging.WeightedTransformArray get_twistNodes() { }
        private System.Void set_twistNodes(UnityEngine.Animations.Rigging.WeightedTransformArray value) { }
        private UnityEngine.Animations.Rigging.TwistCorrectionData.Axis get_twistAxis() { }
        private System.Void set_twistAxis(UnityEngine.Animations.Rigging.TwistCorrectionData.Axis value) { }
        private UnityEngine.Transform UnityEngine.Animations.Rigging.ITwistCorrectionData.get_source() { }
        private UnityEngine.Vector3 UnityEngine.Animations.Rigging.ITwistCorrectionData.get_twistAxis() { }
        private System.String UnityEngine.Animations.Rigging.ITwistCorrectionData.get_twistNodesProperty() { }
        private UnityEngine.Vector3 Convert(UnityEngine.Animations.Rigging.TwistCorrectionData.Axis axis) { }
        private System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }
        private System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

    }

    // TypeToken: 0x200005C
    public class TwistCorrection : RigConstraint`3
    {
        // Methods
        private System.Void OnValidate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005D
    public struct TwoBoneIKConstraintData, IAnimationJobData, ITwoBoneIKConstraintData
    {
        // Fields
        private UnityEngine.Transform m_Root;        // 0x10
        private UnityEngine.Transform m_Mid;        // 0x18
        private UnityEngine.Transform m_Tip;        // 0x20
        private UnityEngine.Transform m_Target;        // 0x28
        private UnityEngine.Transform m_Hint;        // 0x30
        private System.Single m_TargetPositionWeight;        // 0x38
        private System.Single m_TargetRotationWeight;        // 0x3C
        private System.Single m_HintWeight;        // 0x40
        private System.Boolean m_MaintainTargetPositionOffset;        // 0x44
        private System.Boolean m_MaintainTargetRotationOffset;        // 0x45

        // Methods
        private UnityEngine.Transform get_root() { }
        private System.Void set_root(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_mid() { }
        private System.Void set_mid(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_tip() { }
        private System.Void set_tip(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_target() { }
        private System.Void set_target(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_hint() { }
        private System.Void set_hint(UnityEngine.Transform value) { }
        private System.Single get_targetPositionWeight() { }
        private System.Void set_targetPositionWeight(System.Single value) { }
        private System.Single get_targetRotationWeight() { }
        private System.Void set_targetRotationWeight(System.Single value) { }
        private System.Single get_hintWeight() { }
        private System.Void set_hintWeight(System.Single value) { }
        private System.Boolean get_maintainTargetPositionOffset() { }
        private System.Void set_maintainTargetPositionOffset(System.Boolean value) { }
        private System.Boolean get_maintainTargetRotationOffset() { }
        private System.Void set_maintainTargetRotationOffset(System.Boolean value) { }
        private System.String UnityEngine.Animations.Rigging.ITwoBoneIKConstraintData.get_targetPositionWeightFloatProperty() { }
        private System.String UnityEngine.Animations.Rigging.ITwoBoneIKConstraintData.get_targetRotationWeightFloatProperty() { }
        private System.String UnityEngine.Animations.Rigging.ITwoBoneIKConstraintData.get_hintWeightFloatProperty() { }
        private System.Boolean UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }
        private System.Void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

    }

    // TypeToken: 0x200005E
    public class TwoBoneIKConstraint : RigConstraint`3
    {
        // Methods
        private System.Void OnValidate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005F
    public interface IRigConstraint
    {
        // Methods
        private System.Boolean IsValid() { }
        private UnityEngine.Animations.IAnimationJob CreateJob(UnityEngine.Animator animator) { }
        private System.Void UpdateJob(UnityEngine.Animations.IAnimationJob job) { }
        private System.Void DestroyJob(UnityEngine.Animations.IAnimationJob job) { }
        private UnityEngine.Animations.Rigging.IAnimationJobData get_data() { }
        private UnityEngine.Animations.Rigging.IAnimationJobBinder get_binder() { }
        private UnityEngine.Component get_component() { }
        private System.Single get_weight() { }
        private System.Void set_weight(System.Single value) { }

    }

    // TypeToken: 0x2000060
    public interface IRigLayer
    {
        // Methods
        private UnityEngine.Animations.Rigging.Rig get_rig() { }
        private UnityEngine.Animations.Rigging.IRigConstraint[] get_constraints() { }
        private UnityEngine.Animations.IAnimationJob[] get_jobs() { }
        private System.Boolean get_active() { }
        private System.String get_name() { }
        private System.Boolean Initialize(UnityEngine.Animator animator) { }
        private System.Void Update() { }
        private System.Void Reset() { }
        private System.Boolean IsValid() { }

    }

    // TypeToken: 0x2000061
    public class OverrideRigConstraint`4, IRigConstraint
    {
        // Fields
        protected TConstraint m_Constraint;        // 0x0
        private static readonly TBinder s_Binder;        // 0x0

        // Methods
        private System.Void .ctor(TConstraint baseConstraint) { }
        private UnityEngine.Animations.IAnimationJob CreateJob(UnityEngine.Animator animator) { }
        private System.Void DestroyJob(UnityEngine.Animations.IAnimationJob job) { }
        private System.Void UpdateJob(UnityEngine.Animations.IAnimationJob job) { }
        private System.Boolean IsValid() { }
        private UnityEngine.Animations.Rigging.IAnimationJobBinder UnityEngine.Animations.Rigging.IRigConstraint.get_binder() { }
        private UnityEngine.Animations.Rigging.IAnimationJobData UnityEngine.Animations.Rigging.IRigConstraint.get_data() { }
        private UnityEngine.Component UnityEngine.Animations.Rigging.IRigConstraint.get_component() { }
        private System.Single get_weight() { }
        private System.Void set_weight(System.Single value) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000062
    public class OverrideRigLayer, IRigLayer
    {
        // Fields
        private UnityEngine.Animations.Rigging.Rig m_Rig;        // 0x10
        private System.Boolean m_Active;        // 0x18
        private UnityEngine.Animations.Rigging.IRigConstraint[] m_Constraints;        // 0x20
        private UnityEngine.Animations.IAnimationJob[] m_Jobs;        // 0x28
        private System.Boolean <isInitialized>k__BackingField;        // 0x30

        // Methods
        private UnityEngine.Animations.Rigging.Rig get_rig() { }
        private System.Void set_rig(UnityEngine.Animations.Rigging.Rig value) { }
        private System.Boolean get_active() { }
        private System.Void set_active(System.Boolean value) { }
        private System.String get_name() { }
        private UnityEngine.Animations.Rigging.IRigConstraint[] get_constraints() { }
        private UnityEngine.Animations.IAnimationJob[] get_jobs() { }
        private System.Boolean get_isInitialized() { }
        private System.Void set_isInitialized(System.Boolean value) { }
        private System.Void .ctor(UnityEngine.Animations.Rigging.Rig rig, UnityEngine.Animations.Rigging.IRigConstraint[] constraints, System.Boolean active) { }
        private System.Boolean Initialize(UnityEngine.Animator animator) { }
        private System.Void Update() { }
        private System.Void Reset() { }
        private System.Boolean IsValid() { }

    }

    // TypeToken: 0x2000063
    public class Rig : MonoBehaviour, IRigEffectorHolder
    {
        // Fields
        private System.Single m_Weight;        // 0x18
        private System.Collections.Generic.List<UnityEngine.Animations.Rigging.RigEffectorData> m_Effectors;        // 0x20

        // Methods
        private System.Single get_weight() { }
        private System.Void set_weight(System.Single value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000064
    public class RigBuilder : MonoBehaviour, IAnimationWindowPreview, IRigEffectorHolder
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.Animations.Rigging.RigLayer> m_RigLayers;        // 0x18
        private UnityEngine.Animations.Rigging.IRigLayer[] m_RuntimeRigLayers;        // 0x20
        private UnityEngine.Animations.Rigging.SyncSceneToStreamLayer m_SyncSceneToStreamLayer;        // 0x28
        private System.Collections.Generic.List<UnityEngine.Animations.Rigging.RigEffectorData> m_Effectors;        // 0x30
        public static UnityEngine.Animations.Rigging.RigBuilder.OnAddRigBuilderCallback onAddRigBuilder;        // 0x0
        public static UnityEngine.Animations.Rigging.RigBuilder.OnRemoveRigBuilderCallback onRemoveRigBuilder;        // 0x8
        private UnityEngine.Playables.PlayableGraph <graph>k__BackingField;        // 0x38

        // Methods
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void Update() { }
        private System.Boolean Build() { }
        private System.Void Clear() { }
        private System.Void StartPreview() { }
        private System.Void StopPreview() { }
        private System.Void UpdatePreviewGraph(UnityEngine.Playables.PlayableGraph graph) { }
        private UnityEngine.Playables.Playable BuildPreviewGraph(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable inputPlayable) { }
        private System.Collections.Generic.List<UnityEngine.Animations.Rigging.RigLayer> get_layers() { }
        private System.Void set_layers(System.Collections.Generic.List<UnityEngine.Animations.Rigging.RigLayer> value) { }
        private UnityEngine.Animations.Rigging.SyncSceneToStreamLayer get_syncSceneToStreamLayer() { }
        private System.Void set_syncSceneToStreamLayer(UnityEngine.Animations.Rigging.SyncSceneToStreamLayer value) { }
        private UnityEngine.Playables.PlayableGraph get_graph() { }
        private System.Void set_graph(UnityEngine.Playables.PlayableGraph value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000067
    public class RigBuilderUtils
    {
        // Fields
        private static readonly System.UInt16 k_AnimationOutputPriority;        // 0x0

        // Methods
        private UnityEngine.Playables.Playable[] BuildRigPlayables(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animations.Rigging.IRigLayer layer) { }
        private System.Collections.Generic.IEnumerable<UnityEngine.Animations.Rigging.RigBuilderUtils.PlayableChain> BuildPlayables(UnityEngine.Animator animator, UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.IList<UnityEngine.Animations.Rigging.IRigLayer> layers, UnityEngine.Animations.Rigging.SyncSceneToStreamLayer syncSceneToStreamLayer) { }
        private UnityEngine.Playables.PlayableGraph BuildPlayableGraph(UnityEngine.Animator animator, System.Collections.Generic.IList<UnityEngine.Animations.Rigging.IRigLayer> layers, UnityEngine.Animations.Rigging.SyncSceneToStreamLayer syncSceneToStreamLayer) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000069
    public class RigConstraint`3 : MonoBehaviour, IRigConstraint
    {
        // Fields
        protected System.Single m_Weight;        // 0x0
        protected TData m_Data;        // 0x0
        private static readonly TBinder s_Binder;        // 0x0

        // Methods
        private System.Void Reset() { }
        private System.Boolean IsValid() { }
        private System.Void OnValidate() { }
        private TData& get_data() { }
        private System.Single get_weight() { }
        private System.Void set_weight(System.Single value) { }
        private UnityEngine.Animations.IAnimationJob CreateJob(UnityEngine.Animator animator) { }
        private System.Void DestroyJob(UnityEngine.Animations.IAnimationJob job) { }
        private System.Void UpdateJob(UnityEngine.Animations.IAnimationJob job) { }
        private UnityEngine.Animations.Rigging.IAnimationJobBinder UnityEngine.Animations.Rigging.IRigConstraint.get_binder() { }
        private UnityEngine.Animations.Rigging.IAnimationJobData UnityEngine.Animations.Rigging.IRigConstraint.get_data() { }
        private UnityEngine.Component UnityEngine.Animations.Rigging.IRigConstraint.get_component() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200006A
    public class RigLayer, IRigLayer
    {
        // Fields
        private UnityEngine.Animations.Rigging.Rig m_Rig;        // 0x10
        private System.Boolean m_Active;        // 0x18
        private UnityEngine.Animations.Rigging.IRigConstraint[] m_Constraints;        // 0x20
        private UnityEngine.Animations.IAnimationJob[] m_Jobs;        // 0x28
        private System.Boolean <isInitialized>k__BackingField;        // 0x30

        // Methods
        private UnityEngine.Animations.Rigging.Rig get_rig() { }
        private System.Void set_rig(UnityEngine.Animations.Rigging.Rig value) { }
        private System.Boolean get_active() { }
        private System.Void set_active(System.Boolean value) { }
        private System.String get_name() { }
        private UnityEngine.Animations.Rigging.IRigConstraint[] get_constraints() { }
        private UnityEngine.Animations.IAnimationJob[] get_jobs() { }
        private System.Boolean get_isInitialized() { }
        private System.Void set_isInitialized(System.Boolean value) { }
        private System.Void .ctor(UnityEngine.Animations.Rigging.Rig rig, System.Boolean active) { }
        private System.Boolean Initialize(UnityEngine.Animator animator) { }
        private System.Void Update() { }
        private System.Void Reset() { }
        private System.Boolean IsValid() { }

    }

    // TypeToken: 0x200006B
    public class RigTransform : MonoBehaviour
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006C
    public class RigUtils
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<System.Type,UnityEngine.Animations.Rigging.PropertyDescriptor> s_SupportedPropertyTypeToDescriptor;        // 0x0
        private static readonly UnityEngine.Animations.Rigging.IAnimationJobBinder <syncSceneToStreamBinder>k__BackingField;        // 0x8

        // Methods
        private UnityEngine.Animations.Rigging.IRigConstraint[] GetConstraints(UnityEngine.Animations.Rigging.Rig rig) { }
        private UnityEngine.Transform[] GetSyncableRigTransforms(UnityEngine.Animator animator) { }
        private System.Boolean ExtractTransformType(UnityEngine.Animator animator, System.Reflection.FieldInfo field, System.Object data, System.Collections.Generic.List<UnityEngine.Transform> syncableTransforms) { }
        private System.Boolean ExtractPropertyType(System.Reflection.FieldInfo field, System.Object data, System.Collections.Generic.List<UnityEngine.Animations.Rigging.Property> syncableProperties, System.String namePrefix) { }
        private System.Boolean ExtractWeightedTransforms(UnityEngine.Animator animator, System.Reflection.FieldInfo field, System.Object data, System.Collections.Generic.List<UnityEngine.Transform> syncableTransforms, System.Collections.Generic.List<UnityEngine.Animations.Rigging.Property> syncableProperties) { }
        private System.Boolean ExtractNestedPropertyType(UnityEngine.Animator animator, System.Reflection.FieldInfo field, System.Object data, System.Collections.Generic.List<UnityEngine.Transform> syncableTransforms, System.Collections.Generic.List<UnityEngine.Animations.Rigging.Property> syncableProperties, System.String namePrefix) { }
        private System.Void ExtractAllSyncableData(UnityEngine.Animator animator, System.Collections.Generic.IList<UnityEngine.Animations.Rigging.IRigLayer> layers, System.Collections.Generic.List<UnityEngine.Transform>& syncableTransforms, System.Collections.Generic.List<UnityEngine.Animations.Rigging.SyncableProperties>& syncableProperties) { }
        private UnityEngine.Animations.IAnimationJob[] CreateAnimationJobs(UnityEngine.Animator animator, UnityEngine.Animations.Rigging.IRigConstraint[] constraints) { }
        private System.Void DestroyAnimationJobs(UnityEngine.Animations.Rigging.IRigConstraint[] constraints, UnityEngine.Animations.IAnimationJob[] jobs) { }
        private UnityEngine.Animations.Rigging.IAnimationJobData CreateSyncSceneToStreamData(UnityEngine.Animator animator, System.Collections.Generic.IList<UnityEngine.Animations.Rigging.IRigLayer> layers) { }
        private UnityEngine.Animations.Rigging.IAnimationJobBinder get_syncSceneToStreamBinder() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200006F
    public class SyncSceneToStreamLayer
    {
        // Fields
        private System.Boolean <isInitialized>k__BackingField;        // 0x10
        public UnityEngine.Animations.IAnimationJob job;        // 0x18
        private UnityEngine.Animations.Rigging.IAnimationJobData m_Data;        // 0x20
        private System.Collections.Generic.List<System.Int32> m_RigIndices;        // 0x28

        // Methods
        private System.Boolean Initialize(UnityEngine.Animator animator, System.Collections.Generic.IList<UnityEngine.Animations.Rigging.IRigLayer> layers) { }
        private System.Void Update(System.Collections.Generic.IList<UnityEngine.Animations.Rigging.IRigLayer> layers) { }
        private System.Void Reset() { }
        private System.Boolean IsValid() { }
        private System.Boolean get_isInitialized() { }
        private System.Void set_isInitialized(System.Boolean value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000070
    public interface ITransformProvider
    {
        // Methods
        private UnityEngine.Transform get_transform() { }
        private System.Void set_transform(UnityEngine.Transform value) { }

    }

    // TypeToken: 0x2000071
    public interface IWeightProvider
    {
        // Methods
        private System.Single get_weight() { }
        private System.Void set_weight(System.Single value) { }

    }

    // TypeToken: 0x2000072
    public struct WeightedTransform, ITransformProvider, IWeightProvider, IEquatable`1
    {
        // Fields
        public UnityEngine.Transform transform;        // 0x10
        public System.Single weight;        // 0x18

        // Methods
        private System.Void .ctor(UnityEngine.Transform transform, System.Single weight) { }
        private UnityEngine.Animations.Rigging.WeightedTransform Default(System.Single weight) { }
        private System.Boolean Equals(UnityEngine.Animations.Rigging.WeightedTransform other) { }
        private UnityEngine.Transform UnityEngine.Animations.Rigging.ITransformProvider.get_transform() { }
        private System.Void UnityEngine.Animations.Rigging.ITransformProvider.set_transform(UnityEngine.Transform value) { }
        private System.Single UnityEngine.Animations.Rigging.IWeightProvider.get_weight() { }
        private System.Void UnityEngine.Animations.Rigging.IWeightProvider.set_weight(System.Single value) { }

    }

    // TypeToken: 0x2000073
    public struct WeightedTransformArray, IList`1, ICollection`1, IEnumerable`1, IEnumerable, IList, ICollection
    {
        // Fields
        public static readonly System.Int32 k_MaxLength;        // 0x0
        private System.Int32 m_Length;        // 0x10
        private UnityEngine.Animations.Rigging.WeightedTransform m_Item0;        // 0x18
        private UnityEngine.Animations.Rigging.WeightedTransform m_Item1;        // 0x28
        private UnityEngine.Animations.Rigging.WeightedTransform m_Item2;        // 0x38
        private UnityEngine.Animations.Rigging.WeightedTransform m_Item3;        // 0x48
        private UnityEngine.Animations.Rigging.WeightedTransform m_Item4;        // 0x58
        private UnityEngine.Animations.Rigging.WeightedTransform m_Item5;        // 0x68
        private UnityEngine.Animations.Rigging.WeightedTransform m_Item6;        // 0x78
        private UnityEngine.Animations.Rigging.WeightedTransform m_Item7;        // 0x88

        // Methods
        private System.Void .ctor(System.Int32 size) { }
        private System.Collections.Generic.IEnumerator<UnityEngine.Animations.Rigging.WeightedTransform> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Int32 System.Collections.IList.Add(System.Object value) { }
        private System.Void Add(UnityEngine.Animations.Rigging.WeightedTransform value) { }
        private System.Void Clear() { }
        private System.Int32 System.Collections.IList.IndexOf(System.Object value) { }
        private System.Int32 IndexOf(UnityEngine.Animations.Rigging.WeightedTransform value) { }
        private System.Boolean System.Collections.IList.Contains(System.Object value) { }
        private System.Boolean Contains(UnityEngine.Animations.Rigging.WeightedTransform value) { }
        private System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 arrayIndex) { }
        private System.Void CopyTo(UnityEngine.Animations.Rigging.WeightedTransform[] array, System.Int32 arrayIndex) { }
        private System.Void System.Collections.IList.Remove(System.Object value) { }
        private System.Boolean Remove(UnityEngine.Animations.Rigging.WeightedTransform value) { }
        private System.Void RemoveAt(System.Int32 index) { }
        private System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value) { }
        private System.Void Insert(System.Int32 index, UnityEngine.Animations.Rigging.WeightedTransform value) { }
        private System.Int32 ClampSize(System.Int32 size) { }
        private System.Void CheckOutOfRangeIndex(System.Int32 index) { }
        private UnityEngine.Animations.Rigging.WeightedTransform Get(System.Int32 index) { }
        private System.Void Set(System.Int32 index, UnityEngine.Animations.Rigging.WeightedTransform value) { }
        private System.Void SetWeight(System.Int32 index, System.Single weight) { }
        private System.Single GetWeight(System.Int32 index) { }
        private System.Void SetTransform(System.Int32 index, UnityEngine.Transform transform) { }
        private UnityEngine.Transform GetTransform(System.Int32 index) { }
        private System.Void OnValidate(UnityEngine.Animations.Rigging.WeightedTransformArray& array, System.Single min, System.Single max) { }
        private System.Object System.Collections.IList.get_Item(System.Int32 index) { }
        private System.Void System.Collections.IList.set_Item(System.Int32 index, System.Object value) { }
        private UnityEngine.Animations.Rigging.WeightedTransform get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, UnityEngine.Animations.Rigging.WeightedTransform value) { }
        private System.Int32 get_Count() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Boolean get_IsFixedSize() { }
        private System.Boolean System.Collections.ICollection.get_IsSynchronized() { }
        private System.Object System.Collections.ICollection.get_SyncRoot() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000075
    public class ExpandChildrenAttribute : PropertyAttribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000076
    public class SyncSceneToStreamAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000077
    public struct PropertyType
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static UnityEngine.Animations.Rigging.PropertyType Bool;        // 0x0
        public static UnityEngine.Animations.Rigging.PropertyType Int;        // 0x0
        public static UnityEngine.Animations.Rigging.PropertyType Float;        // 0x0

    }

    // TypeToken: 0x2000078
    public struct PropertyDescriptor
    {
        // Fields
        public System.Int32 size;        // 0x10
        public UnityEngine.Animations.Rigging.PropertyType type;        // 0x14

    }

    // TypeToken: 0x2000079
    public struct Property
    {
        // Fields
        public System.String name;        // 0x10
        public UnityEngine.Animations.Rigging.PropertyDescriptor descriptor;        // 0x18

    }

    // TypeToken: 0x200007A
    public struct RigProperties
    {
        // Fields
        public static System.String s_Weight;        // 0x0
        public UnityEngine.Component component;        // 0x10

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200007B
    public struct ConstraintProperties
    {
        // Fields
        public static System.String s_Weight;        // 0x0
        public UnityEngine.Component component;        // 0x10
        public UnityEngine.Animations.Rigging.Property[] properties;        // 0x18

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200007C
    public class PropertyUtils
    {
        // Methods
        private System.String ConstructConstraintDataPropertyName(System.String property) { }
        private System.String ConstructCustomPropertyName(UnityEngine.Component component, System.String property) { }

    }

    // TypeToken: 0x200007D
    public class WeightRangeAttribute : PropertyAttribute
    {
        // Fields
        public readonly System.Single min;        // 0x10
        public readonly System.Single max;        // 0x14

        // Methods
        private System.Void .ctor(System.Single min, System.Single max) { }

    }

    // TypeToken: 0x200007E
    public interface IRigEffectorHolder
    {
    }

    // TypeToken: 0x200007F
    public class RigEffectorData
    {
        // Fields
        private UnityEngine.Transform m_Transform;        // 0x10
        private UnityEngine.Animations.Rigging.RigEffectorData.Style m_Style;        // 0x18
        private System.Boolean m_Visible;        // 0x50

        // Methods
        private UnityEngine.Transform get_transform() { }
        private UnityEngine.Animations.Rigging.RigEffectorData.Style get_style() { }
        private System.Boolean get_visible() { }
        private System.Void set_visible(System.Boolean value) { }
        private System.Void Initialize(UnityEngine.Transform transform, UnityEngine.Animations.Rigging.RigEffectorData.Style style) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000081
    public struct AffineTransform
    {
        // Fields
        public UnityEngine.Vector3 translation;        // 0x10
        public UnityEngine.Quaternion rotation;        // 0x1C
        private static readonly UnityEngine.Animations.Rigging.AffineTransform <identity>k__BackingField;        // 0x0

        // Methods
        private System.Void .ctor(UnityEngine.Vector3 t, UnityEngine.Quaternion r) { }
        private System.Void Set(UnityEngine.Vector3 t, UnityEngine.Quaternion r) { }
        private UnityEngine.Vector3 Transform(UnityEngine.Vector3 p) { }
        private UnityEngine.Vector3 InverseTransform(UnityEngine.Vector3 p) { }
        private UnityEngine.Animations.Rigging.AffineTransform Inverse() { }
        private UnityEngine.Animations.Rigging.AffineTransform InverseMul(UnityEngine.Animations.Rigging.AffineTransform transform) { }
        private UnityEngine.Vector3 op_Multiply(UnityEngine.Animations.Rigging.AffineTransform lhs, UnityEngine.Vector3 rhs) { }
        private UnityEngine.Animations.Rigging.AffineTransform op_Multiply(UnityEngine.Animations.Rigging.AffineTransform lhs, UnityEngine.Animations.Rigging.AffineTransform rhs) { }
        private UnityEngine.Animations.Rigging.AffineTransform op_Multiply(UnityEngine.Quaternion lhs, UnityEngine.Animations.Rigging.AffineTransform rhs) { }
        private UnityEngine.Animations.Rigging.AffineTransform op_Multiply(UnityEngine.Animations.Rigging.AffineTransform lhs, UnityEngine.Quaternion rhs) { }
        private UnityEngine.Animations.Rigging.AffineTransform get_identity() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000082
    public class AnimationRuntimeUtils
    {
        // Fields
        private static System.Single k_SqrEpsilon;        // 0x0

        // Methods
        private System.Void SolveTwoBoneIK(UnityEngine.Animations.AnimationStream stream, UnityEngine.Animations.Rigging.ReadWriteTransformHandle root, UnityEngine.Animations.Rigging.ReadWriteTransformHandle mid, UnityEngine.Animations.Rigging.ReadWriteTransformHandle tip, UnityEngine.Animations.Rigging.ReadOnlyTransformHandle target, UnityEngine.Animations.Rigging.ReadOnlyTransformHandle hint, System.Single posWeight, System.Single rotWeight, System.Single hintWeight, UnityEngine.Animations.Rigging.AffineTransform targetOffset) { }
        private System.Single TriangleAngle(System.Single aLen, System.Single aLen1, System.Single aLen2) { }
        private System.Boolean SolveFABRIK(Unity.Collections.NativeArray<UnityEngine.Vector3>& linkPositions, Unity.Collections.NativeArray<System.Single>& linkLengths, UnityEngine.Vector3 target, System.Single tolerance, System.Single maxReach, System.Int32 maxIterations) { }
        private System.Single SqrDistance(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs) { }
        private System.Single Square(System.Single value) { }
        private UnityEngine.Vector3 Lerp(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 t) { }
        private System.Single Select(System.Single a, System.Single b, System.Single c) { }
        private UnityEngine.Vector3 Select(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c) { }
        private UnityEngine.Vector3 ProjectOnPlane(UnityEngine.Vector3 vector, UnityEngine.Vector3 planeNormal) { }
        private System.Single Sum(UnityEngine.Animations.Rigging.AnimationJobCache cache, UnityEngine.Animations.Rigging.CacheIndex index, System.Int32 count) { }
        private System.Single Sum(Unity.Collections.NativeArray<System.Single> floatBuffer) { }
        private System.Void PassThrough(UnityEngine.Animations.AnimationStream stream, UnityEngine.Animations.Rigging.ReadWriteTransformHandle handle) { }

    }

    // TypeToken: 0x2000083
    public class BoneRenderer : MonoBehaviour
    {
        // Fields
        public UnityEngine.Animations.Rigging.BoneRenderer.BoneShape boneShape;        // 0x18
        public System.Boolean drawBones;        // 0x1C
        public System.Boolean drawTripods;        // 0x1D
        public System.Single boneSize;        // 0x20
        public System.Single tripodSize;        // 0x24
        public UnityEngine.Color boneColor;        // 0x28
        private UnityEngine.Transform[] m_Transforms;        // 0x38

        // Methods
        private UnityEngine.Transform[] get_transforms() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000085
    public class ConstraintsUtils
    {
        // Methods
        private UnityEngine.Transform[] ExtractChain(UnityEngine.Transform root, UnityEngine.Transform tip) { }
        private System.Single[] ExtractLengths(UnityEngine.Transform[] chain) { }
        private System.Single[] ExtractSteps(UnityEngine.Transform[] chain) { }
        private System.String ConstructConstraintDataPropertyName(System.String property) { }
        private System.String ConstructCustomPropertyName(UnityEngine.Component component, System.String property) { }

    }

    // TypeToken: 0x2000087
    public class QuaternionExt
    {
        // Fields
        private static System.Single k_FloatMin;        // 0x0
        public static readonly UnityEngine.Quaternion zero;        // 0x0

        // Methods
        private UnityEngine.Quaternion FromToRotation(UnityEngine.Vector3 from, UnityEngine.Vector3 to) { }
        private UnityEngine.Quaternion Add(UnityEngine.Quaternion rhs, UnityEngine.Quaternion lhs) { }
        private UnityEngine.Quaternion Scale(UnityEngine.Quaternion q, System.Single scale) { }
        private UnityEngine.Quaternion NormalizeSafe(UnityEngine.Quaternion q) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000088
    public struct Vector3Bool
    {
        // Fields
        public System.Boolean x;        // 0x10
        public System.Boolean y;        // 0x11
        public System.Boolean z;        // 0x12

        // Methods
        private System.Void .ctor(System.Boolean val) { }
        private System.Void .ctor(System.Boolean x, System.Boolean y, System.Boolean z) { }

    }

}

