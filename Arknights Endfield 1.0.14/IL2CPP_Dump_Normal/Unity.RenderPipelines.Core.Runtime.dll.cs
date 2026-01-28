// ========================================================
// Dumped by @desirepro
// Assembly: Unity.RenderPipelines.Core.Runtime.dll
// Classes:  411
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000004
    public class SceneRenderPipeline : MonoBehaviour
    {
        // Fields
        public UnityEngine.Rendering.RenderPipelineAsset renderPipelineAsset;        // 0x18

        // Methods
        private System.Void OnEnable() { }
        private System.Void OnValidate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000006
    public struct ShaderQuality
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Rendering.HGShaderQualitySettings.ShaderQuality Low;        // 0x0
        public static Beyond.Rendering.HGShaderQualitySettings.ShaderQuality High;        // 0x0

    }

    // TypeToken: 0x2000008
    public struct UpDirection
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.LightAnchor.UpDirection World;        // 0x0
        public static UnityEngine.LightAnchor.UpDirection Local;        // 0x0

    }

    // TypeToken: 0x2000009
    public struct Axes
    {
        // Fields
        public UnityEngine.Vector3 up;        // 0x10
        public UnityEngine.Vector3 right;        // 0x1C
        public UnityEngine.Vector3 forward;        // 0x28

    }

    // TypeToken: 0x200000B
    public struct Brick, IEquatable`1
    {
        // Fields
        public UnityEngine.Vector3Int position;        // 0x10
        public System.Int32 subdivisionLevel;        // 0x1C

        // Methods
        private System.Void .ctor(UnityEngine.Vector3Int position, System.Int32 subdivisionLevel) { }
        private System.Boolean Equals(UnityEngine.Experimental.Rendering.ProbeBrickIndex.Brick other) { }

    }

    // TypeToken: 0x200000C
    public struct ReservedBrick
    {
        // Fields
        public UnityEngine.Experimental.Rendering.ProbeBrickIndex.Brick brick;        // 0x10
        public System.Int32 flattenedIdx;        // 0x20

    }

    // TypeToken: 0x200000D
    public struct VoxelMeta
    {
        // Fields
        public UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId id;        // 0x10
        public System.Collections.Generic.List<System.UInt16> brickIndices;        // 0x18

    }

    // TypeToken: 0x200000E
    public struct BrickMeta
    {
        // Fields
        public System.Collections.Generic.HashSet<UnityEngine.Vector3Int> voxels;        // 0x10
        public System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickIndex.ReservedBrick> bricks;        // 0x18

    }

    // TypeToken: 0x200000F
    public struct CellIndexUpdateInfo
    {
        // Fields
        public System.Int32 firstChunkIndex;        // 0x10
        public System.Int32 numberOfChunks;        // 0x14
        public System.Int32 minSubdivInCell;        // 0x18
        public UnityEngine.Vector3Int minValidBrickIndexForCellAtMaxRes;        // 0x1C
        public UnityEngine.Vector3Int maxValidBrickIndexForCellAtMaxResPlusOne;        // 0x28
        public UnityEngine.Vector3Int cellPositionInBricksAtMaxRes;        // 0x34

    }

    // TypeToken: 0x2000013
    public struct BrickChunkAlloc
    {
        // Fields
        public System.Int32 x;        // 0x10
        public System.Int32 y;        // 0x14
        public System.Int32 z;        // 0x18

        // Methods
        private System.Int32 flattenIndex(System.Int32 sx, System.Int32 sy) { }

    }

    // TypeToken: 0x2000014
    public struct DataLocation
    {
        // Fields
        private UnityEngine.Texture3D TexL0_L1rx;        // 0x10
        private UnityEngine.Texture3D TexL1_G_ry;        // 0x18
        private UnityEngine.Texture3D TexL1_B_rz;        // 0x20
        private UnityEngine.Texture3D TexL2_0;        // 0x28
        private UnityEngine.Texture3D TexL2_1;        // 0x30
        private UnityEngine.Texture3D TexL2_2;        // 0x38
        private UnityEngine.Texture3D TexL2_3;        // 0x40
        private System.Int32 width;        // 0x48
        private System.Int32 height;        // 0x4C
        private System.Int32 depth;        // 0x50

        // Methods
        private System.Void Cleanup() { }

    }

    // TypeToken: 0x2000016
    public struct IndexMetaData
    {
        // Fields
        private UnityEngine.Vector3Int minLocalIdx;        // 0x10
        private UnityEngine.Vector3Int maxLocalIdx;        // 0x1C
        private System.Int32 firstChunkIndex;        // 0x28
        private System.Int32 minSubdiv;        // 0x2C

        // Methods
        private System.Void Pack(System.UInt32[]& vals) { }

    }

    // TypeToken: 0x200001C
    public class Cell
    {
        // Fields
        public System.Int32 index;        // 0x10
        public UnityEngine.Vector3Int position;        // 0x14
        public System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickIndex.Brick> bricks;        // 0x20
        public UnityEngine.Vector3[] probePositions;        // 0x28
        public UnityEngine.Rendering.SphericalHarmonicsL2[] sh;        // 0x30
        public System.Single[] validity;        // 0x38
        public System.Int32 minSubdiv;        // 0x40
        public System.Int32 flatIdxInCellIndices;        // 0x44
        public System.Boolean loaded;        // 0x48

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001D
    public class CellChunkInfo
    {
        // Fields
        public System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc> chunks;        // 0x10

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001E
    public class CellSortInfo, IComparable
    {
        // Fields
        private System.String sourceAsset;        // 0x10
        private UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Cell cell;        // 0x18
        private System.Single distanceToCamera;        // 0x20
        private UnityEngine.Vector3 position;        // 0x24

        // Methods
        private System.Int32 CompareTo(System.Object obj) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001F
    public struct Volume, IEquatable`1
    {
        // Fields
        private UnityEngine.Vector3 corner;        // 0x10
        private UnityEngine.Vector3 X;        // 0x1C
        private UnityEngine.Vector3 Y;        // 0x28
        private UnityEngine.Vector3 Z;        // 0x34
        private System.Single maxSubdivisionMultiplier;        // 0x40
        private System.Single minSubdivisionMultiplier;        // 0x44

        // Methods
        private System.Void .ctor(UnityEngine.Matrix4x4 trs, System.Single maxSubdivision, System.Single minSubdivision) { }
        private System.Void .ctor(UnityEngine.Vector3 corner, UnityEngine.Vector3 X, UnityEngine.Vector3 Y, UnityEngine.Vector3 Z, System.Single maxSubdivision, System.Single minSubdivision) { }
        private System.Void .ctor(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Volume copy) { }
        private UnityEngine.Bounds CalculateAABB() { }
        private System.Void CalculateCenterAndSize(UnityEngine.Vector3& center, UnityEngine.Vector3& size) { }
        private System.Void Transform(UnityEngine.Matrix4x4 trs) { }
        private System.String ToString() { }
        private System.Boolean Equals(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Volume other) { }

    }

    // TypeToken: 0x2000020
    public struct RefVolTransform
    {
        // Fields
        public UnityEngine.Matrix4x4 refSpaceToWS;        // 0x10
        public UnityEngine.Vector3 posWS;        // 0x50
        public UnityEngine.Quaternion rot;        // 0x5C
        public System.Single scale;        // 0x6C

    }

    // TypeToken: 0x2000021
    public struct RuntimeResources
    {
        // Fields
        public UnityEngine.ComputeBuffer index;        // 0x10
        public UnityEngine.ComputeBuffer cellIndices;        // 0x18
        public UnityEngine.Texture3D L0_L1rx;        // 0x20
        public UnityEngine.Texture3D L1_G_ry;        // 0x28
        public UnityEngine.Texture3D L1_B_rz;        // 0x30
        public UnityEngine.Texture3D L2_0;        // 0x38
        public UnityEngine.Texture3D L2_1;        // 0x40
        public UnityEngine.Texture3D L2_2;        // 0x48
        public UnityEngine.Texture3D L2_3;        // 0x50

    }

    // TypeToken: 0x2000022
    public struct RegId
    {
        // Fields
        private System.Int32 id;        // 0x10

        // Methods
        private System.Boolean IsValid() { }
        private System.Void Invalidate() { }
        private System.Boolean op_Equality(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId lhs, UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId rhs) { }
        private System.Boolean op_Inequality(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId lhs, UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId rhs) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000023
    public struct ExtraDataActionInput
    {
    }

    // TypeToken: 0x2000024
    public struct InitInfo
    {
        // Fields
        public UnityEngine.Vector3Int pendingMinCellPosition;        // 0x10
        public UnityEngine.Vector3Int pendingMaxCellPosition;        // 0x1C

    }

    // TypeToken: 0x2000025
    public class CellInstancedDebugProbes
    {
        // Fields
        public System.Collections.Generic.List<UnityEngine.Matrix4x4[]> probeBuffers;        // 0x10
        public System.Collections.Generic.List<UnityEngine.MaterialPropertyBlock> props;        // 0x18
        public UnityEngine.Hash128 cellHash;        // 0x20
        public UnityEngine.Vector3 cellPosition;        // 0x30

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002A
    public struct Version
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Experimental.Rendering.ProbeReferenceVolumeProfile.Version Initial;        // 0x0

    }

    // TypeToken: 0x200002D
    public struct AssetVersion
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Experimental.Rendering.ProbeVolumeAsset.AssetVersion First;        // 0x0
        public static UnityEngine.Experimental.Rendering.ProbeVolumeAsset.AssetVersion AddProbeVolumesAtlasEncodingModes;        // 0x0
        public static UnityEngine.Experimental.Rendering.ProbeVolumeAsset.AssetVersion PV2;        // 0x0
        public static UnityEngine.Experimental.Rendering.ProbeVolumeAsset.AssetVersion ChunkBasedIndex;        // 0x0
        public static UnityEngine.Experimental.Rendering.ProbeVolumeAsset.AssetVersion Max;        // 0x0
        public static UnityEngine.Experimental.Rendering.ProbeVolumeAsset.AssetVersion Current;        // 0x0

    }

    // TypeToken: 0x2000033
    public struct SerializableAssetItem
    {
        // Fields
        public UnityEngine.Experimental.Rendering.ProbeVolumeState state;        // 0x10
        public UnityEngine.Experimental.Rendering.ProbeVolumeAsset asset;        // 0x18

    }

    // TypeToken: 0x2000035
    public struct SerializableBoundItem
    {
        // Fields
        public System.String sceneGUID;        // 0x10
        public UnityEngine.Bounds bounds;        // 0x18

    }

    // TypeToken: 0x2000036
    public struct SerializableHasPVItem
    {
        // Fields
        public System.String sceneGUID;        // 0x10
        public System.Boolean hasProbeVolumes;        // 0x18

    }

    // TypeToken: 0x2000037
    public struct SerializablePVProfile
    {
        // Fields
        public System.String sceneGUID;        // 0x10
        public UnityEngine.Experimental.Rendering.ProbeReferenceVolumeProfile profile;        // 0x18

    }

    // TypeToken: 0x2000038
    public struct SerializablePVBakeSettings
    {
        // Fields
        public System.String sceneGUID;        // 0x10
        public UnityEngine.Experimental.Rendering.ProbeVolumeBakingProcessSettings settings;        // 0x18

    }

    // TypeToken: 0x2000039
    public class BakingSet
    {
        // Fields
        public System.String name;        // 0x10
        public System.Collections.Generic.List<System.String> sceneGUIDs;        // 0x18
        public UnityEngine.Experimental.Rendering.ProbeVolumeBakingProcessSettings settings;        // 0x20
        public UnityEngine.Experimental.Rendering.ProbeReferenceVolumeProfile profile;        // 0x40

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000042
    public class Strings
    {
        // Fields
        public static readonly UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip ClearRenderTargetsAtCreation;        // 0x0
        public static readonly UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip DisablePassCulling;        // 0x10
        public static readonly UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip ImmediateMode;        // 0x20
        public static readonly UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip EnableLogging;        // 0x30
        public static readonly UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip LogFrameInformation;        // 0x40
        public static readonly UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip LogResources;        // 0x50

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000045
    public struct PassDebugData
    {
        // Fields
        public System.String name;        // 0x10
        public System.Collections.Generic.List<System.Int32>[] resourceReadLists;        // 0x18
        public System.Collections.Generic.List<System.Int32>[] resourceWriteLists;        // 0x20
        public System.Boolean culled;        // 0x28
        public System.Boolean generateDebugData;        // 0x29

    }

    // TypeToken: 0x2000046
    public struct ResourceDebugData
    {
        // Fields
        public System.String name;        // 0x10
        public System.Boolean imported;        // 0x18
        public System.Int32 creationPassIndex;        // 0x1C
        public System.Int32 releasePassIndex;        // 0x20
        public System.Collections.Generic.List<System.Int32> consumerList;        // 0x28
        public System.Collections.Generic.List<System.Int32> producerList;        // 0x30

    }

    // TypeToken: 0x2000048
    public struct CompiledResourceInfo
    {
        // Fields
        public System.Collections.Generic.List<System.Int32> producers;        // 0x10
        public System.Collections.Generic.List<System.Int32> consumers;        // 0x18
        public System.Int32 refCount;        // 0x20
        public System.Boolean imported;        // 0x24

        // Methods
        private System.Void Reset() { }

    }

    // TypeToken: 0x2000049
    public struct CompiledPassInfo
    {
        // Fields
        public UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass pass;        // 0x10
        public System.Collections.Generic.List<System.Int32>[] resourceCreateList;        // 0x18
        public System.Collections.Generic.List<System.Int32>[] resourceReleaseList;        // 0x20
        public System.Int32 refCount;        // 0x28
        public System.Boolean culled;        // 0x2C
        public System.Boolean hasSideEffect;        // 0x2D
        public System.Int32 syncToPassIndex;        // 0x30
        public System.Int32 syncFromPassIndex;        // 0x34
        public System.Boolean needGraphicsFence;        // 0x38
        public UnityEngine.Rendering.GraphicsFence fence;        // 0x40
        public System.Boolean enableAsyncCompute;        // 0x50

        // Methods
        private System.Boolean get_allowPassCulling() { }
        private System.Void Reset(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass pass) { }

    }

    // TypeToken: 0x200004A
    public class ProfilingScopePassData
    {
        // Fields
        public UnityEngine.Rendering.ProfilingSampler sampler;        // 0x10

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004B
    public class OnGraphRegisteredDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph graph) { }
        private System.IAsyncResult BeginInvoke(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph graph, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200004C
    public class OnExecutionRegisteredDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph graph, System.String executionName) { }
        private System.IAsyncResult BeginInvoke(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph graph, System.String executionName, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000054
    public class SharedObjectPoolBase
    {
        // Fields
        protected static System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool.SharedObjectPoolBase> s_AllocatedPools;        // 0x0

        // Methods
        private System.Void Clear() { }
        private System.Void ClearAll() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000055
    public class SharedObjectPool`1 : SharedObjectPoolBase
    {
        // Fields
        private System.Collections.Generic.Stack<T> m_Pool;        // 0x0
        private static readonly System.Lazy<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool.SharedObjectPool<T>> s_Instance;        // 0x0

        // Methods
        private T Get() { }
        private System.Void Release(T value) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool.SharedObjectPool<T> AllocatePool() { }
        private System.Void Clear() { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool.SharedObjectPool<T> get_sharedPool() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200005F
    public struct ResourceLogInfo
    {
        // Fields
        public System.String name;        // 0x0
        public System.Int64 size;        // 0x0

    }

    // TypeToken: 0x2000062
    public class ResourceCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext, UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource res) { }
        private System.IAsyncResult BeginInvoke(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext, UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource res, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000063
    public class RenderGraphResourcesData
    {
        // Fields
        public UnityEngine.Rendering.DynamicArray<UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource> resourceArray;        // 0x10
        public System.Int32 sharedResourcesCount;        // 0x18
        public UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResourcePool pool;        // 0x20
        public UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry.ResourceCallback createResourceCallback;        // 0x28
        public UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry.ResourceCallback releaseResourceCallback;        // 0x30

        // Methods
        private System.Void Clear(System.Boolean onException, System.Int32 frameIndex) { }
        private System.Void Cleanup() { }
        private System.Void PurgeUnusedGraphicsResources(System.Int32 frameIndex) { }
        private System.Int32 AddNewRenderGraphResource(ResType& outRes, System.Boolean pooledResource) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007E
    public struct FixedBufferStringQueue
    {
        // Fields
        private System.Byte* m_ReadCursor;        // 0x10
        private System.Byte* m_WriteCursor;        // 0x18
        private readonly System.Byte* m_BufferEnd;        // 0x20
        private readonly System.Byte* m_BufferStart;        // 0x28
        private readonly System.Int32 m_BufferLength;        // 0x30
        private System.Int32 <Count>k__BackingField;        // 0x34

        // Methods
        private System.Int32 get_Count() { }
        private System.Void set_Count(System.Int32 value) { }
        private System.Void .ctor(System.Byte* ptr, System.Int32 length) { }
        private System.Boolean TryPush(System.String v) { }
        private System.Boolean TryPop(System.String& v) { }
        private System.Void Clear() { }

    }

    // TypeToken: 0x200007F
    public interface IKeyGetter`2
    {
        // Methods
        private TKey Get(TValue& v) { }

    }

    // TypeToken: 0x2000080
    public struct DefaultKeyGetter`1, IKeyGetter`2
    {
        // Methods
        private T Get(T& v) { }

    }

    // TypeToken: 0x2000081
    public struct UintKeyGetter, IKeyGetter`2
    {
        // Methods
        private System.UInt32 Get(System.UInt32& v) { }

    }

    // TypeToken: 0x2000088
    public struct ScalerContainer
    {
        // Fields
        public UnityEngine.Rendering.DynamicResScalePolicyType type;        // 0x10
        public UnityEngine.Rendering.PerformDynamicRes method;        // 0x18

    }

    // TypeToken: 0x2000089
    public struct UpsamplerScheduleType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.DynamicResolutionHandler.UpsamplerScheduleType BeforePost;        // 0x0
        public static UnityEngine.Rendering.DynamicResolutionHandler.UpsamplerScheduleType AfterPost;        // 0x0

    }

    // TypeToken: 0x2000092
    public struct PooledObject, IDisposable
    {
        // Fields
        private readonly T m_ToReturn;        // 0x0
        private readonly UnityEngine.Rendering.ObjectPool<T> m_Pool;        // 0x0

        // Methods
        private System.Void .ctor(T value, UnityEngine.Rendering.ObjectPool<T> pool) { }
        private System.Void System.IDisposable.Dispose() { }

    }

    // TypeToken: 0x20000A2
    public struct StereoRenderingMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.XRGraphics.StereoRenderingMode MultiPass;        // 0x0
        public static UnityEngine.Rendering.XRGraphics.StereoRenderingMode SinglePass;        // 0x0
        public static UnityEngine.Rendering.XRGraphics.StereoRenderingMode SinglePassInstanced;        // 0x0
        public static UnityEngine.Rendering.XRGraphics.StereoRenderingMode SinglePassMultiView;        // 0x0

    }

    // TypeToken: 0x20000A9
    public struct DebugActionKeyType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.DebugActionState.DebugActionKeyType Button;        // 0x0
        public static UnityEngine.Rendering.DebugActionState.DebugActionKeyType Axis;        // 0x0
        public static UnityEngine.Rendering.DebugActionState.DebugActionKeyType Key;        // 0x0

    }

    // TypeToken: 0x20000AD
    public class Container : Widget, IContainer
    {
        // Fields
        private UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> <children>k__BackingField;        // 0x48

        // Methods
        private UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> get_children() { }
        private System.Void set_children(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> value) { }
        private UnityEngine.Rendering.DebugUI.Panel get_panel() { }
        private System.Void set_panel(UnityEngine.Rendering.DebugUI.Panel value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String displayName, UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> children) { }
        private System.Void GenerateQueryPath() { }
        private System.Void OnItemAdded(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e) { }
        private System.Void OnItemRemoved(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x20000AF
    public struct ContextMenuItem
    {
        // Fields
        public System.String displayName;        // 0x10
        public System.Action action;        // 0x18

    }

    // TypeToken: 0x20000AE
    public class Foldout : Container, IValueField
    {
        // Fields
        public System.Boolean opened;        // 0x50
        public System.Boolean isHeader;        // 0x51
        public System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Foldout.ContextMenuItem> contextMenuItems;        // 0x58
        private System.String[] <columnLabels>k__BackingField;        // 0x60
        private System.String[] <columnTooltips>k__BackingField;        // 0x68

        // Methods
        private System.Boolean get_isReadOnly() { }
        private System.String[] get_columnLabels() { }
        private System.Void set_columnLabels(System.String[] value) { }
        private System.String[] get_columnTooltips() { }
        private System.Void set_columnTooltips(System.String[] value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String displayName, UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> children, System.String[] columnLabels, System.String[] columnTooltips) { }
        private System.Boolean GetValue() { }
        private System.Object UnityEngine.Rendering.DebugUI.IValueField.GetValue() { }
        private System.Void SetValue(System.Object value) { }
        private System.Object ValidateValue(System.Object value) { }
        private System.Void SetValue(System.Boolean value) { }

    }

    // TypeToken: 0x20000B0
    public class HBox : Container
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B1
    public class VBox : Container
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B3
    public class Row : Foldout
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B2
    public class Table : Container
    {
        // Fields
        public System.Boolean isReadOnly;        // 0x50
        private System.Boolean[] m_Header;        // 0x58

        // Methods
        private System.Void .ctor() { }
        private System.Void SetColumnVisibility(System.Int32 index, System.Boolean visible) { }
        private System.Boolean GetColumnVisibility(System.Int32 index) { }
        private System.Boolean[] get_VisibleColumns() { }
        private System.Void OnItemAdded(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e) { }
        private System.Void OnItemRemoved(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e) { }

    }

    // TypeToken: 0x20000B4
    public struct Flags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.DebugUI.Flags None;        // 0x0
        public static UnityEngine.Rendering.DebugUI.Flags EditorOnly;        // 0x0
        public static UnityEngine.Rendering.DebugUI.Flags RuntimeOnly;        // 0x0
        public static UnityEngine.Rendering.DebugUI.Flags EditorForceUpdate;        // 0x0

    }

    // TypeToken: 0x20000B6
    public struct NameAndTooltip
    {
        // Fields
        public System.String name;        // 0x10
        public System.String tooltip;        // 0x18

    }

    // TypeToken: 0x20000B5
    public class Widget
    {
        // Fields
        protected UnityEngine.Rendering.DebugUI.Panel m_Panel;        // 0x10
        protected UnityEngine.Rendering.DebugUI.IContainer m_Parent;        // 0x18
        private UnityEngine.Rendering.DebugUI.Flags <flags>k__BackingField;        // 0x20
        private System.String <displayName>k__BackingField;        // 0x28
        private System.String <tooltip>k__BackingField;        // 0x30
        private System.String <queryPath>k__BackingField;        // 0x38
        public System.Func<System.Boolean> isHiddenCallback;        // 0x40

        // Methods
        private UnityEngine.Rendering.DebugUI.Panel get_panel() { }
        private System.Void set_panel(UnityEngine.Rendering.DebugUI.Panel value) { }
        private UnityEngine.Rendering.DebugUI.IContainer get_parent() { }
        private System.Void set_parent(UnityEngine.Rendering.DebugUI.IContainer value) { }
        private UnityEngine.Rendering.DebugUI.Flags get_flags() { }
        private System.Void set_flags(UnityEngine.Rendering.DebugUI.Flags value) { }
        private System.String get_displayName() { }
        private System.Void set_displayName(System.String value) { }
        private System.String get_tooltip() { }
        private System.Void set_tooltip(System.String value) { }
        private System.String get_queryPath() { }
        private System.Void set_queryPath(System.String value) { }
        private System.Boolean get_isEditorOnly() { }
        private System.Boolean get_isRuntimeOnly() { }
        private System.Boolean get_isInactiveInEditor() { }
        private System.Boolean get_isHidden() { }
        private System.Void GenerateQueryPath() { }
        private System.Int32 GetHashCode() { }
        private System.Void set_nameAndTooltip(UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B7
    public interface IContainer
    {
        // Methods
        private UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> get_children() { }
        private System.String get_displayName() { }
        private System.Void set_displayName(System.String value) { }
        private System.String get_queryPath() { }

    }

    // TypeToken: 0x20000B8
    public interface IValueField
    {
        // Methods
        private System.Object GetValue() { }
        private System.Void SetValue(System.Object value) { }
        private System.Object ValidateValue(System.Object value) { }

    }

    // TypeToken: 0x20000B9
    public class Button : Widget
    {
        // Fields
        private System.Action <action>k__BackingField;        // 0x48

        // Methods
        private System.Action get_action() { }
        private System.Void set_action(System.Action value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BA
    public class Value : Widget
    {
        // Fields
        private System.Func<System.Object> <getter>k__BackingField;        // 0x48
        public System.Single refreshRate;        // 0x50

        // Methods
        private System.Func<System.Object> get_getter() { }
        private System.Void set_getter(System.Func<System.Object> value) { }
        private System.Void .ctor() { }
        private System.Object GetValue() { }

    }

    // TypeToken: 0x20000BB
    public class Field`1 : Widget, IValueField
    {
        // Fields
        private System.Func<T> <getter>k__BackingField;        // 0x0
        private System.Action<T> <setter>k__BackingField;        // 0x0
        public System.Action<UnityEngine.Rendering.DebugUI.Field<T>,T> onValueChanged;        // 0x0

        // Methods
        private System.Func<T> get_getter() { }
        private System.Void set_getter(System.Func<T> value) { }
        private System.Action<T> get_setter() { }
        private System.Void set_setter(System.Action<T> value) { }
        private System.Object UnityEngine.Rendering.DebugUI.IValueField.ValidateValue(System.Object value) { }
        private T ValidateValue(T value) { }
        private System.Object UnityEngine.Rendering.DebugUI.IValueField.GetValue() { }
        private T GetValue() { }
        private System.Void SetValue(System.Object value) { }
        private System.Void SetValue(T value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BC
    public class BoolField : Field`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BD
    public class HistoryBoolField : BoolField
    {
        // Fields
        private System.Func<System.Boolean>[] <historyGetter>k__BackingField;        // 0x60

        // Methods
        private System.Func<System.Boolean>[] get_historyGetter() { }
        private System.Void set_historyGetter(System.Func<System.Boolean>[] value) { }
        private System.Int32 get_historyDepth() { }
        private System.Boolean GetHistoryValue(System.Int32 historyIndex) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BE
    public class IntField : Field`1
    {
        // Fields
        public System.Func<System.Int32> min;        // 0x60
        public System.Func<System.Int32> max;        // 0x68
        public System.Int32 incStep;        // 0x70
        public System.Int32 intStepMult;        // 0x74

        // Methods
        private System.Int32 ValidateValue(System.Int32 value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BF
    public class UIntField : Field`1
    {
        // Fields
        public System.Func<System.UInt32> min;        // 0x60
        public System.Func<System.UInt32> max;        // 0x68
        public System.UInt32 incStep;        // 0x70
        public System.UInt32 intStepMult;        // 0x74

        // Methods
        private System.UInt32 ValidateValue(System.UInt32 value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C0
    public class FloatField : Field`1
    {
        // Fields
        public System.Func<System.Single> min;        // 0x60
        public System.Func<System.Single> max;        // 0x68
        public System.Single incStep;        // 0x70
        public System.Single incStepMult;        // 0x74
        public System.Int32 decimals;        // 0x78

        // Methods
        private System.Single ValidateValue(System.Single value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C1
    public class EnumUtility
    {
        // Methods
        private UnityEngine.GUIContent[] MakeEnumNames(System.Type enumType) { }
        private System.Int32[] MakeEnumValues(System.Type enumType) { }

    }

    // TypeToken: 0x20000C3
    public class EnumField : Field`1
    {
        // Fields
        public UnityEngine.GUIContent[] enumNames;        // 0x60
        public System.Int32[] enumValues;        // 0x68
        private System.Int32[] quickSeparators;        // 0x70
        private System.Int32[] indexes;        // 0x78
        private System.Func<System.Int32> <getIndex>k__BackingField;        // 0x80
        private System.Action<System.Int32> <setIndex>k__BackingField;        // 0x88

        // Methods
        private System.Func<System.Int32> get_getIndex() { }
        private System.Void set_getIndex(System.Func<System.Int32> value) { }
        private System.Action<System.Int32> get_setIndex() { }
        private System.Void set_setIndex(System.Action<System.Int32> value) { }
        private System.Int32 get_currentIndex() { }
        private System.Void set_currentIndex(System.Int32 value) { }
        private System.Void set_autoEnum(System.Type value) { }
        private System.Void InitQuickSeparators() { }
        private System.Void InitIndexes() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C5
    public class HistoryEnumField : EnumField
    {
        // Fields
        private System.Func<System.Int32>[] <historyIndexGetter>k__BackingField;        // 0x90

        // Methods
        private System.Func<System.Int32>[] get_historyIndexGetter() { }
        private System.Void set_historyIndexGetter(System.Func<System.Int32>[] value) { }
        private System.Int32 get_historyDepth() { }
        private System.Int32 GetHistoryValue(System.Int32 historyIndex) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C6
    public class BitField : Field`1
    {
        // Fields
        private UnityEngine.GUIContent[] <enumNames>k__BackingField;        // 0x60
        private System.Int32[] <enumValues>k__BackingField;        // 0x68
        private System.Type m_EnumType;        // 0x70

        // Methods
        private UnityEngine.GUIContent[] get_enumNames() { }
        private System.Void set_enumNames(UnityEngine.GUIContent[] value) { }
        private System.Int32[] get_enumValues() { }
        private System.Void set_enumValues(System.Int32[] value) { }
        private System.Type get_enumType() { }
        private System.Void set_enumType(System.Type value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C7
    public class ColorField : Field`1
    {
        // Fields
        public System.Boolean hdr;        // 0x60
        public System.Boolean showAlpha;        // 0x61
        public System.Boolean showPicker;        // 0x62
        public System.Single incStep;        // 0x64
        public System.Single incStepMult;        // 0x68
        public System.Int32 decimals;        // 0x6C

        // Methods
        private UnityEngine.Color ValidateValue(UnityEngine.Color value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C8
    public class Vector2Field : Field`1
    {
        // Fields
        public System.Single incStep;        // 0x60
        public System.Single incStepMult;        // 0x64
        public System.Int32 decimals;        // 0x68

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C9
    public class Vector3Field : Field`1
    {
        // Fields
        public System.Single incStep;        // 0x60
        public System.Single incStepMult;        // 0x64
        public System.Int32 decimals;        // 0x68

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CA
    public class Vector4Field : Field`1
    {
        // Fields
        public System.Single incStep;        // 0x60
        public System.Single incStepMult;        // 0x64
        public System.Int32 decimals;        // 0x68

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CC
    public struct Style
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.DebugUI.MessageBox.Style Info;        // 0x0
        public static UnityEngine.Rendering.DebugUI.MessageBox.Style Warning;        // 0x0
        public static UnityEngine.Rendering.DebugUI.MessageBox.Style Error;        // 0x0

    }

    // TypeToken: 0x20000CB
    public class MessageBox : Widget
    {
        // Fields
        public UnityEngine.Rendering.DebugUI.MessageBox.Style style;        // 0x48

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CD
    public class Panel, IContainer, IComparable`1
    {
        // Fields
        private UnityEngine.Rendering.DebugUI.Flags <flags>k__BackingField;        // 0x10
        private System.String <displayName>k__BackingField;        // 0x18
        private System.Int32 <groupIndex>k__BackingField;        // 0x20
        private UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> <children>k__BackingField;        // 0x28
        private System.Action<UnityEngine.Rendering.DebugUI.Panel> onSetDirty;        // 0x30

        // Methods
        private UnityEngine.Rendering.DebugUI.Flags get_flags() { }
        private System.Void set_flags(UnityEngine.Rendering.DebugUI.Flags value) { }
        private System.String get_displayName() { }
        private System.Void set_displayName(System.String value) { }
        private System.Int32 get_groupIndex() { }
        private System.Void set_groupIndex(System.Int32 value) { }
        private System.String get_queryPath() { }
        private System.Boolean get_isEditorOnly() { }
        private System.Boolean get_isRuntimeOnly() { }
        private System.Boolean get_isInactiveInEditor() { }
        private System.Boolean get_editorForceUpdate() { }
        private UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> get_children() { }
        private System.Void set_children(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> value) { }
        private System.Void add_onSetDirty(System.Action<UnityEngine.Rendering.DebugUI.Panel> value) { }
        private System.Void remove_onSetDirty(System.Action<UnityEngine.Rendering.DebugUI.Panel> value) { }
        private System.Void .ctor() { }
        private System.Void OnItemAdded(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e) { }
        private System.Void OnItemRemoved(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e) { }
        private System.Void SetDirty() { }
        private System.Int32 GetHashCode() { }
        private System.Int32 System.IComparable<UnityEngine.Rendering.DebugUI.Panel>.CompareTo(UnityEngine.Rendering.DebugUI.Panel other) { }

    }

    // TypeToken: 0x20000DF
    public struct SunSourceDirLightOverrideLensFlareData
    {
        // Fields
        public System.Boolean enable;        // 0x10
        public UnityEngine.Rendering.LensFlareDataSRP lensFlareData;        // 0x18
        public System.Single intensity;        // 0x20
        public System.Single scale;        // 0x24
        public System.Boolean useOcclusion;        // 0x28
        public System.Single occlusionRadius;        // 0x2C
        public System.UInt32 sampleCount;        // 0x30
        public System.Single occlusionOffset;        // 0x34
        public System.Boolean allowOffScreen;        // 0x38

    }

    // TypeToken: 0x20000E0
    public struct SunSourceDirLightOverrideLightData
    {
        // Fields
        public UnityEngine.Quaternion rotationLensFlare;        // 0x10
        public UnityEngine.Vector3 dirLightFoward;        // 0x20
        public UnityEngine.Color color;        // 0x2C

    }

    // TypeToken: 0x20000E1
    public struct SunSourceDirLightOverrideInfo
    {
        // Fields
        public UnityEngine.GameObject dirLightGameObject;        // 0x10
        public UnityEngine.Rendering.LensFlareCommonSRP.SunSourceDirLightOverrideLensFlareData flareData;        // 0x18
        public UnityEngine.Rendering.LensFlareCommonSRP.SunSourceDirLightOverrideLightData lightData;        // 0x48

    }

    // TypeToken: 0x20000F4
    public struct Hammersley2dSeq16
    {
        // Fields
        public UnityEngine.Rendering.Hammersley.Hammersley2dSeq16.<hammersley2dSeq16>e__FixedBuffer hammersley2dSeq16;        // 0x10

    }

    // TypeToken: 0x20000F6
    public struct Hammersley2dSeq32
    {
        // Fields
        public UnityEngine.Rendering.Hammersley.Hammersley2dSeq32.<hammersley2dSeq32>e__FixedBuffer hammersley2dSeq32;        // 0x10

    }

    // TypeToken: 0x20000F8
    public struct Hammersley2dSeq64
    {
        // Fields
        public UnityEngine.Rendering.Hammersley.Hammersley2dSeq64.<hammersley2dSeq64>e__FixedBuffer hammersley2dSeq64;        // 0x10

    }

    // TypeToken: 0x20000FA
    public struct Hammersley2dSeq256
    {
        // Fields
        public UnityEngine.Rendering.Hammersley.Hammersley2dSeq256.<hammersley2dSeq256>e__FixedBuffer hammersley2dSeq256;        // 0x10

    }

    // TypeToken: 0x2000100
    public struct BlitType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.PowerOfTwoTextureAtlas.BlitType Padding;        // 0x0
        public static UnityEngine.Rendering.PowerOfTwoTextureAtlas.BlitType PaddingMultiply;        // 0x0
        public static UnityEngine.Rendering.PowerOfTwoTextureAtlas.BlitType OctahedralPadding;        // 0x0
        public static UnityEngine.Rendering.PowerOfTwoTextureAtlas.BlitType OctahedralPaddingMultiply;        // 0x0

    }

    // TypeToken: 0x2000106
    public class AtlasNode
    {
        // Fields
        public UnityEngine.Rendering.AtlasAllocator.AtlasNode m_RightChild;        // 0x10
        public UnityEngine.Rendering.AtlasAllocator.AtlasNode m_BottomChild;        // 0x18
        public UnityEngine.Vector4 m_Rect;        // 0x20

        // Methods
        private UnityEngine.Rendering.AtlasAllocator.AtlasNode Allocate(UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.AtlasAllocator.AtlasNode>& pool, System.Int32 width, System.Int32 height, System.Boolean powerOfTwoPadding) { }
        private System.Void Release(UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.AtlasAllocator.AtlasNode>& pool) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000109
    public struct BlitType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.Texture2DAtlas.BlitType Default;        // 0x0
        public static UnityEngine.Rendering.Texture2DAtlas.BlitType CubeTo2DOctahedral;        // 0x0
        public static UnityEngine.Rendering.Texture2DAtlas.BlitType SingleChannel;        // 0x0
        public static UnityEngine.Rendering.Texture2DAtlas.BlitType CubeTo2DOctahedralSingleChannel;        // 0x0

    }

    // TypeToken: 0x200010B
    public class AtlasNodePool
    {
        // Fields
        private UnityEngine.Rendering.AtlasAllocatorDynamic.AtlasNode[] m_Nodes;        // 0x10
        private System.Int16 m_Next;        // 0x18
        private System.Int16 m_FreelistHead;        // 0x1A

        // Methods
        private System.Void .ctor(System.Int16 capacity) { }
        private System.Void Dispose() { }
        private System.Void Clear() { }
        private System.Int16 AtlasNodeCreate(System.Int16 parent) { }
        private System.Void AtlasNodeFree(System.Int16 index) { }

    }

    // TypeToken: 0x200010D
    public struct AtlasNodeFlags
    {
        // Fields
        public System.UInt32 value__;        // 0x10
        public static UnityEngine.Rendering.AtlasAllocatorDynamic.AtlasNode.AtlasNodeFlags IsOccupied;        // 0x0

    }

    // TypeToken: 0x200010C
    public struct AtlasNode
    {
        // Fields
        public System.Int16 m_Self;        // 0x10
        public System.Int16 m_Parent;        // 0x12
        public System.Int16 m_LeftChild;        // 0x14
        public System.Int16 m_RightChild;        // 0x16
        public System.Int16 m_FreelistNext;        // 0x18
        public System.UInt16 m_Flags;        // 0x1A
        public UnityEngine.Vector4 m_Rect;        // 0x20

        // Methods
        private System.Void .ctor(System.Int16 self, System.Int16 parent) { }
        private System.Boolean IsOccupied() { }
        private System.Void SetIsOccupied() { }
        private System.Void ClearIsOccupied() { }
        private System.Boolean IsLeafNode() { }
        private System.Int16 Allocate(UnityEngine.Rendering.AtlasAllocatorDynamic.AtlasNodePool pool, System.Int32 width, System.Int32 height) { }
        private System.Void ReleaseChildren(UnityEngine.Rendering.AtlasAllocatorDynamic.AtlasNodePool pool) { }
        private System.Void ReleaseAndMerge(UnityEngine.Rendering.AtlasAllocatorDynamic.AtlasNodePool pool) { }
        private System.Boolean IsMergeNeeded(UnityEngine.Rendering.AtlasAllocatorDynamic.AtlasNodePool pool) { }

    }

    // TypeToken: 0x200011A
    public class BlitShaderIDs
    {
        // Fields
        public static readonly System.Int32 _BlitTexture;        // 0x0
        public static readonly System.Int32 _BlitCubeTexture;        // 0x4
        public static readonly System.Int32 _BlitScaleBias;        // 0x8
        public static readonly System.Int32 _BlitScaleBiasRt;        // 0xC
        public static readonly System.Int32 _BlitMipLevel;        // 0x10
        public static readonly System.Int32 _BlitTextureSize;        // 0x14
        public static readonly System.Int32 _BlitPaddingSize;        // 0x18
        public static readonly System.Int32 _InputDepth;        // 0x1C

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200011F
    public class Sections
    {
        // Fields
        public static System.Int32 section1;        // 0x0
        public static System.Int32 section2;        // 0x0
        public static System.Int32 section3;        // 0x0
        public static System.Int32 section4;        // 0x0
        public static System.Int32 section5;        // 0x0
        public static System.Int32 section6;        // 0x0
        public static System.Int32 section7;        // 0x0
        public static System.Int32 section8;        // 0x0

    }

    // TypeToken: 0x2000120
    public class Priorities
    {
        // Fields
        public static System.Int32 assetsCreateShaderMenuPriority;        // 0x0
        public static System.Int32 assetsCreateRenderingMenuPriority;        // 0x0
        public static System.Int32 editMenuPriority;        // 0x0
        public static System.Int32 gameObjectMenuPriority;        // 0x0
        public static System.Int32 srpLensFlareMenuPriority;        // 0x0

    }

    // TypeToken: 0x2000125
    public class ShaderConstants
    {
        // Fields
        public static readonly System.Int32 _FsrEasuConstants0;        // 0x0
        public static readonly System.Int32 _FsrEasuConstants1;        // 0x4
        public static readonly System.Int32 _FsrEasuConstants2;        // 0x8
        public static readonly System.Int32 _FsrEasuConstants3;        // 0xC
        public static readonly System.Int32 _FsrRcasConstants;        // 0x10

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000127
    public class Segment
    {
        // Fields
        public System.Single offsetX;        // 0x10
        public System.Single offsetY;        // 0x14
        public System.Single scaleX;        // 0x18
        public System.Single scaleY;        // 0x1C
        public System.Single lnA;        // 0x20
        public System.Single B;        // 0x24

        // Methods
        private System.Single Eval(System.Single x) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000128
    public struct DirectParams
    {
        // Fields
        private System.Single x0;        // 0x10
        private System.Single y0;        // 0x14
        private System.Single x1;        // 0x18
        private System.Single y1;        // 0x1C
        private System.Single W;        // 0x20
        private System.Single overshootX;        // 0x24
        private System.Single overshootY;        // 0x28
        private System.Single gamma;        // 0x2C

    }

    // TypeToken: 0x2000129
    public class Uniforms
    {
        // Fields
        private UnityEngine.Rendering.HableCurve parent;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.Rendering.HableCurve parent) { }
        private UnityEngine.Vector4 get_curve() { }
        private UnityEngine.Vector4 get_toeSegmentA() { }
        private UnityEngine.Vector4 get_toeSegmentB() { }
        private UnityEngine.Vector4 get_midSegmentA() { }
        private UnityEngine.Vector4 get_midSegmentB() { }
        private UnityEngine.Vector4 get_shoSegmentA() { }
        private UnityEngine.Vector4 get_shoSegmentB() { }

    }

    // TypeToken: 0x2000130
    public struct Package
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.ReloadAttribute.Package Builtin;        // 0x0
        public static UnityEngine.Rendering.ReloadAttribute.Package Root;        // 0x0

    }

    // TypeToken: 0x200013D
    public class Indent : PropertyAttribute
    {
        // Fields
        public readonly System.Int32 relativeAmount;        // 0x10

        // Methods
        private System.Void .ctor(System.Int32 relativeAmount) { }

    }

    // TypeToken: 0x2000196
    public struct __StaticArrayInitTypeSize=24
    {
    }

    // TypeToken: 0x2000197
    public struct __StaticArrayInitTypeSize=144
    {
    }

    // TypeToken: 0x2000198
    public struct __StaticArrayInitTypeSize=256
    {
    }

    // TypeToken: 0x2000199
    public struct __StaticArrayInitTypeSize=512
    {
    }

    // TypeToken: 0x200019A
    public struct __StaticArrayInitTypeSize=1024
    {
    }

    // TypeToken: 0x200019B
    public struct __StaticArrayInitTypeSize=4096
    {
    }

namespace Beyond.Rendering
{

    // TypeToken: 0x2000005
    public class HGShaderQualitySettings
    {
        // Fields
        public static Beyond.Rendering.HGShaderQualitySettings.ShaderQuality HgShaderLod;        // 0x0

        // Methods
        private System.Void .cctor() { }

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

namespace UnityEngine
{

    // TypeToken: 0x2000007
    public class LightAnchor : MonoBehaviour
    {
        // Fields
        private static System.Single k_ArcRadius;        // 0x0
        private static System.Single k_AxisLength;        // 0x0
        private static System.Single k_MaxDistance;        // 0x0
        private System.Single m_Distance;        // 0x18
        private UnityEngine.LightAnchor.UpDirection m_FrameSpace;        // 0x1C
        private UnityEngine.Transform m_AnchorPositionOverride;        // 0x20
        private UnityEngine.Vector3 m_AnchorPositionOffset;        // 0x28
        private System.Single m_Yaw;        // 0x34
        private System.Single m_Pitch;        // 0x38
        private System.Single m_Roll;        // 0x3C

        // Methods
        private System.Single get_yaw() { }
        private System.Void set_yaw(System.Single value) { }
        private System.Single get_pitch() { }
        private System.Void set_pitch(System.Single value) { }
        private System.Single get_roll() { }
        private System.Void set_roll(System.Single value) { }
        private System.Single get_distance() { }
        private System.Void set_distance(System.Single value) { }
        private UnityEngine.LightAnchor.UpDirection get_frameSpace() { }
        private System.Void set_frameSpace(UnityEngine.LightAnchor.UpDirection value) { }
        private UnityEngine.Vector3 get_anchorPosition() { }
        private UnityEngine.Transform get_anchorPositionOverride() { }
        private System.Void set_anchorPositionOverride(UnityEngine.Transform value) { }
        private UnityEngine.Vector3 get_anchorPositionOffset() { }
        private System.Void set_anchorPositionOffset(UnityEngine.Vector3 value) { }
        private System.Single NormalizeAngleDegree(System.Single angle) { }
        private System.Void SynchronizeOnTransform(UnityEngine.Camera camera) { }
        private System.Void UpdateTransform(UnityEngine.Camera camera, UnityEngine.Vector3 anchor) { }
        private UnityEngine.LightAnchor.Axes GetWorldSpaceAxes(UnityEngine.Camera camera, UnityEngine.Vector3 anchor) { }
        private System.Void Update() { }
        private System.Void OnDrawGizmosSelected() { }
        private System.Void UpdateTransform(UnityEngine.Vector3 up, UnityEngine.Vector3 right, UnityEngine.Vector3 forward, UnityEngine.Vector3 anchor) { }
        private System.Void .ctor() { }

    }

}

namespace UnityEngine.Experimental.Rendering
{

    // TypeToken: 0x200000A
    public class ProbeBrickIndex
    {
        // Fields
        private static System.Int32 kMaxSubdivisionLevels;        // 0x0
        private static System.Int32 kIndexChunkSize;        // 0x0
        private System.Collections.BitArray m_IndexChunks;        // 0x10
        private System.Int32 m_IndexInChunks;        // 0x18
        private System.Int32 m_NextFreeChunk;        // 0x1C
        private UnityEngine.ComputeBuffer m_PhysicalIndexBuffer;        // 0x20
        private System.Int32[] m_PhysicalIndexBufferData;        // 0x28
        private System.Int32 <estimatedVMemCost>k__BackingField;        // 0x30
        private UnityEngine.Vector3Int m_CenterRS;        // 0x34
        private System.Collections.Generic.Dictionary<UnityEngine.Vector3Int,System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickIndex.VoxelMeta>> m_VoxelToBricks;        // 0x40
        private System.Collections.Generic.Dictionary<UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId,UnityEngine.Experimental.Rendering.ProbeBrickIndex.BrickMeta> m_BricksToVoxels;        // 0x48
        private System.Boolean m_NeedUpdateIndexComputeBuffer;        // 0x50

        // Methods
        private System.Int32 get_estimatedVMemCost() { }
        private System.Void set_estimatedVMemCost(System.Int32 value) { }
        private System.Int32 GetVoxelSubdivLevel() { }
        private System.Int32 SizeOfPhysicalIndexFromBudget(UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget) { }
        private System.Void .ctor(UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget) { }
        private System.Void UploadIndexData() { }
        private System.Void Clear() { }
        private System.Void MapBrickToVoxels(UnityEngine.Experimental.Rendering.ProbeBrickIndex.Brick brick, System.Collections.Generic.HashSet<UnityEngine.Vector3Int> voxels) { }
        private System.Void ClearVoxel(UnityEngine.Vector3Int pos, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellInfo) { }
        private System.Void GetRuntimeResources(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RuntimeResources& rr) { }
        private System.Void Cleanup() { }
        private System.Int32 MergeIndex(System.Int32 index, System.Int32 size) { }
        private System.Boolean AssignIndexChunksToCell(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Cell cell, System.Int32 bricksCount, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo& cellUpdateInfo) { }
        private System.Void AddBricks(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId id, System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickIndex.Brick> bricks, System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc> allocations, System.Int32 allocationSize, System.Int32 poolWidth, System.Int32 poolHeight, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellInfo) { }
        private System.Void RemoveBricks(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId id, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellInfo) { }
        private System.Void UpdateIndexForVoxel(UnityEngine.Vector3Int voxel, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellInfo) { }
        private System.Void UpdatePhysicalIndex(UnityEngine.Vector3Int brickMin, UnityEngine.Vector3Int brickMax, System.Int32 value, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellInfo) { }
        private System.Void ClipToIndexSpace(UnityEngine.Vector3Int pos, System.Int32 subdiv, UnityEngine.Vector3Int& outMinpos, UnityEngine.Vector3Int& outMaxpos, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellInfo) { }
        private System.Void UpdateIndexForVoxel(UnityEngine.Vector3Int voxel, System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickIndex.ReservedBrick> bricks, System.Collections.Generic.List<System.UInt16> indices, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellInfo) { }

    }

    // TypeToken: 0x2000012
    public class ProbeBrickPool
    {
        // Fields
        private static System.Int32 kBrickCellCount;        // 0x0
        private static System.Int32 kBrickProbeCountPerDim;        // 0x0
        private static System.Int32 kBrickProbeCountTotal;        // 0x0
        private System.Int32 <estimatedVMemCost>k__BackingField;        // 0x10
        private static System.Int32 kMaxPoolWidth;        // 0x0
        private System.Int32 m_AllocationSize;        // 0x14
        private UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudget m_MemoryBudget;        // 0x18
        private UnityEngine.Experimental.Rendering.ProbeBrickPool.DataLocation m_Pool;        // 0x20
        private UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc m_NextFreeChunk;        // 0x68
        private System.Collections.Generic.Stack<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc> m_FreeList;        // 0x78
        private UnityEngine.Experimental.Rendering.ProbeVolumeSHBands m_SHBands;        // 0x80

        // Methods
        private System.Int32 get_estimatedVMemCost() { }
        private System.Void set_estimatedVMemCost(System.Int32 value) { }
        private System.Void .ctor(System.Int32 allocationSize, UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget, UnityEngine.Experimental.Rendering.ProbeVolumeSHBands shBands) { }
        private System.Void EnsureTextureValidity() { }
        private System.Int32 GetChunkSize() { }
        private System.Int32 GetChunkSizeInProbeCount() { }
        private System.Int32 GetPoolWidth() { }
        private System.Int32 GetPoolHeight() { }
        private UnityEngine.Vector3Int GetPoolDimensions() { }
        private System.Void GetRuntimeResources(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RuntimeResources& rr) { }
        private System.Void Clear() { }
        private System.Void Allocate(System.Int32 numberOfBrickChunks, System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc> outAllocations) { }
        private System.Void Deallocate(System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc> allocations) { }
        private System.Void Update(UnityEngine.Experimental.Rendering.ProbeBrickPool.DataLocation source, System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc> srcLocations, System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc> dstLocations, UnityEngine.Experimental.Rendering.ProbeVolumeSHBands bands) { }
        private UnityEngine.Vector3Int ProbeCountToDataLocSize(System.Int32 numProbes) { }
        private UnityEngine.Experimental.Rendering.ProbeBrickPool.DataLocation CreateDataLocation(System.Int32 numProbes, System.Boolean compressed, UnityEngine.Experimental.Rendering.ProbeVolumeSHBands bands, System.Int32& allocatedBytes) { }
        private System.Void SetPixel(UnityEngine.Color[]& data, System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 dataLocWidth, System.Int32 dataLocHeight, UnityEngine.Color value) { }
        private System.Void FillDataLocation(UnityEngine.Experimental.Rendering.ProbeBrickPool.DataLocation& loc, UnityEngine.Rendering.SphericalHarmonicsL2[] shl2, UnityEngine.Experimental.Rendering.ProbeVolumeSHBands bands) { }
        private System.Void DerivePoolSizeFromBudget(System.Int32 allocationSize, UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget, System.Int32& width, System.Int32& height, System.Int32& depth) { }
        private System.Void Cleanup() { }

    }

    // TypeToken: 0x2000015
    public class ProbeCellIndices
    {
        // Fields
        private static System.Int32 kUintPerEntry;        // 0x0
        private System.Int32 <estimatedVMemCost>k__BackingField;        // 0x10
        private UnityEngine.ComputeBuffer m_IndexOfIndicesBuffer;        // 0x18
        private System.UInt32[] m_IndexOfIndicesData;        // 0x20
        private UnityEngine.Vector3Int m_CellCount;        // 0x28
        private UnityEngine.Vector3Int m_CellMin;        // 0x34
        private System.Int32 m_CellSizeInMinBricks;        // 0x40
        private System.Boolean m_NeedUpdateComputeBuffer;        // 0x44

        // Methods
        private System.Int32 get_estimatedVMemCost() { }
        private System.Void set_estimatedVMemCost(System.Int32 value) { }
        private UnityEngine.Vector3Int GetCellIndexDimension() { }
        private UnityEngine.Vector3Int GetCellMinPosition() { }
        private System.Int32 GetFlatIndex(UnityEngine.Vector3Int normalizedPos) { }
        private System.Void .ctor(UnityEngine.Vector3Int cellMin, UnityEngine.Vector3Int cellMax, System.Int32 cellSizeInMinBricks) { }
        private System.Int32 GetFlatIdxForCell(UnityEngine.Vector3Int cellPosition) { }
        private System.Void AddCell(System.Int32 cellFlatIdx, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo) { }
        private System.Void MarkCellAsUnloaded(System.Int32 cellFlatIdx) { }
        private System.Void PushComputeData() { }
        private System.Void GetRuntimeResources(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RuntimeResources& rr) { }
        private System.Void Cleanup() { }

    }

    // TypeToken: 0x2000017
    public struct ProbeVolumeSystemParameters
    {
        // Fields
        public UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget;        // 0x10
        public UnityEngine.Mesh probeDebugMesh;        // 0x18
        public UnityEngine.Shader probeDebugShader;        // 0x20
        public UnityEngine.Experimental.Rendering.ProbeVolumeSceneData sceneData;        // 0x28
        public UnityEngine.Experimental.Rendering.ProbeVolumeSHBands shBands;        // 0x30

    }

    // TypeToken: 0x2000018
    public struct ProbeVolumeShadingParameters
    {
        // Fields
        public System.Single normalBias;        // 0x10
        public System.Single viewBias;        // 0x14
        public System.Boolean scaleBiasByMinDistanceBetweenProbes;        // 0x18
        public System.Single samplingNoise;        // 0x1C

    }

    // TypeToken: 0x2000019
    public struct ProbeVolumeTextureMemoryBudget
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudget MemoryBudgetLow;        // 0x0
        public static UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudget MemoryBudgetMedium;        // 0x0
        public static UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudget MemoryBudgetHigh;        // 0x0

    }

    // TypeToken: 0x200001A
    public struct ProbeVolumeSHBands
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Experimental.Rendering.ProbeVolumeSHBands SphericalHarmonicsL1;        // 0x0
        public static UnityEngine.Experimental.Rendering.ProbeVolumeSHBands SphericalHarmonicsL2;        // 0x0

    }

    // TypeToken: 0x200001B
    public class ProbeReferenceVolume
    {
        // Fields
        private static System.Int32 kProbeIndexPoolAllocationSize;        // 0x0
        private System.Boolean m_IsInitialized;        // 0x10
        private System.Int32 m_ID;        // 0x14
        private UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RefVolTransform m_Transform;        // 0x18
        private System.Int32 m_MaxSubdivision;        // 0x78
        private UnityEngine.Experimental.Rendering.ProbeBrickPool m_Pool;        // 0x80
        private UnityEngine.Experimental.Rendering.ProbeBrickIndex m_Index;        // 0x88
        private UnityEngine.Experimental.Rendering.ProbeCellIndices m_CellIndices;        // 0x90
        private System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc> m_TmpSrcChunks;        // 0x98
        private System.Single[] m_PositionOffsets;        // 0xA0
        private System.Collections.Generic.Dictionary<UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId,System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc>> m_Registry;        // 0xA8
        private UnityEngine.Bounds m_CurrGlobalBounds;        // 0xB0
        private System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Cell> cells;        // 0xC8
        private System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Experimental.Rendering.ProbeReferenceVolume.CellChunkInfo> m_ChunkInfo;        // 0xD0
        private UnityEngine.Experimental.Rendering.ProbeVolumeSceneData sceneData;        // 0xD8
        public System.Action<UnityEngine.Experimental.Rendering.ProbeReferenceVolume.ExtraDataActionInput> retrieveExtraDataAction;        // 0xE0
        private System.Boolean m_BricksLoaded;        // 0xE8
        private System.Collections.Generic.Dictionary<UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Cell,UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId> m_CellToBricks;        // 0xF0
        private System.Collections.Generic.Dictionary<UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId,UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo> m_BricksToCellUpdateInfo;        // 0xF8
        private System.Collections.Generic.Dictionary<System.String,UnityEngine.Experimental.Rendering.ProbeVolumeAsset> m_PendingAssetsToBeLoaded;        // 0x100
        private System.Collections.Generic.Dictionary<System.String,UnityEngine.Experimental.Rendering.ProbeVolumeAsset> m_PendingAssetsToBeUnloaded;        // 0x108
        private System.Collections.Generic.Dictionary<System.String,UnityEngine.Experimental.Rendering.ProbeVolumeAsset> m_ActiveAssets;        // 0x110
        private System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeReferenceVolume.CellSortInfo> m_CellsToBeLoaded;        // 0x118
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> m_CellRefCounting;        // 0x120
        private System.Boolean m_NeedLoadAsset;        // 0x128
        private System.Boolean m_ProbeReferenceVolumeInit;        // 0x129
        private System.Boolean m_EnabledBySRP;        // 0x12A
        private UnityEngine.Experimental.Rendering.ProbeReferenceVolume.InitInfo m_PendingInitInfo;        // 0x12C
        private System.Boolean m_NeedsIndexRebuild;        // 0x144
        private System.Boolean m_HasChangedIndex;        // 0x145
        private System.Int32 m_CBShaderID;        // 0x148
        private System.Int32 m_NumberOfCellsLoadedPerFrame;        // 0x14C
        private UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudget m_MemoryBudget;        // 0x150
        private UnityEngine.Experimental.Rendering.ProbeVolumeSHBands m_SHBands;        // 0x154
        private System.Boolean clearAssetsOnVolumeClear;        // 0x158
        private static UnityEngine.Experimental.Rendering.ProbeReferenceVolume _instance;        // 0x0
        private static System.Int32 kProbesPerBatch;        // 0x0
        private readonly UnityEngine.Experimental.Rendering.ProbeVolumeDebug <debugDisplay>k__BackingField;        // 0x160
        private readonly UnityEngine.Color[] <subdivisionDebugColors>k__BackingField;        // 0x168
        private UnityEngine.Rendering.DebugUI.Widget[] m_DebugItems;        // 0x170
        private UnityEngine.Mesh m_DebugMesh;        // 0x178
        private UnityEngine.Material m_DebugMaterial;        // 0x180
        private System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeReferenceVolume.CellInstancedDebugProbes> m_CellDebugData;        // 0x188
        private UnityEngine.Plane[] m_DebugFrustumPlanes;        // 0x190
        private System.Single dilationValidtyThreshold;        // 0x198
        private System.Collections.Generic.Dictionary<UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Volume,System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickIndex.Brick>> realtimeSubdivisionInfo;        // 0x1A0

        // Methods
        private System.Void InvalidateAllCellRefs() { }
        private System.Boolean get_isInitialized() { }
        private System.Boolean get_enabledBySRP() { }
        private UnityEngine.Experimental.Rendering.ProbeVolumeSHBands get_shBands() { }
        private UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudget get_memoryBudget() { }
        private UnityEngine.Experimental.Rendering.ProbeReferenceVolume get_instance() { }
        private System.Void SetNumberOfCellsLoadedPerFrame(System.Int32 numberOfCells) { }
        private System.Void Initialize(UnityEngine.Experimental.Rendering.ProbeVolumeSystemParameters& parameters) { }
        private System.Void SetEnableStateFromSRP(System.Boolean srpEnablesPV) { }
        private System.Void ForceSHBand(UnityEngine.Experimental.Rendering.ProbeVolumeSHBands shBands) { }
        private System.Void Cleanup() { }
        private System.Int32 GetVideoMemoryCost() { }
        private System.Void RemoveCell(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Cell cell) { }
        private System.Void AddCell(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Cell cell, System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc> chunks) { }
        private System.Boolean CheckCompatibilityWithCollection(UnityEngine.Experimental.Rendering.ProbeVolumeAsset asset, System.Collections.Generic.Dictionary<System.String,UnityEngine.Experimental.Rendering.ProbeVolumeAsset> collection) { }
        private System.Void AddPendingAssetLoading(UnityEngine.Experimental.Rendering.ProbeVolumeAsset asset) { }
        private System.Void AddPendingAssetRemoval(UnityEngine.Experimental.Rendering.ProbeVolumeAsset asset) { }
        private System.Void RemovePendingAsset(UnityEngine.Experimental.Rendering.ProbeVolumeAsset asset) { }
        private System.Void PerformPendingIndexChangeAndInit() { }
        private System.Void SetMinBrickAndMaxSubdiv(System.Single minBrickSize, System.Int32 maxSubdiv) { }
        private System.Void LoadAsset(UnityEngine.Experimental.Rendering.ProbeVolumeAsset asset) { }
        private System.Void PerformPendingLoading() { }
        private System.Void PerformPendingDeletion() { }
        private System.Int32 GetNumberOfBricksAtSubdiv(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Cell cell, UnityEngine.Vector3Int& minValidLocalIdxAtMaxRes, UnityEngine.Vector3Int& sizeOfValidIndicesAtMaxRes) { }
        private System.Boolean GetCellIndexUpdate(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Cell cell, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo& cellUpdateInfo) { }
        private System.Void LoadPendingCells(System.Boolean loadAll) { }
        private System.Void PerformPendingOperations(System.Boolean loadAllCells) { }
        private System.Void InitProbeReferenceVolume(System.Int32 allocationSize, UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget, UnityEngine.Experimental.Rendering.ProbeVolumeSHBands shBands) { }
        private System.Void SortPendingCells(UnityEngine.Vector3 cameraPosition) { }
        private System.Void .ctor() { }
        private UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RuntimeResources GetRuntimeResources() { }
        private System.Void SetTRS(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Single minBrickSize) { }
        private System.Void SetMaxSubdivision(System.Int32 maxSubdivision) { }
        private System.Int32 CellSize(System.Int32 subdivisionLevel) { }
        private System.Single BrickSize(System.Int32 subdivisionLevel) { }
        private System.Single MinBrickSize() { }
        private System.Single MaxBrickSize() { }
        private UnityEngine.Matrix4x4 GetRefSpaceToWS() { }
        private UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RefVolTransform GetTransform() { }
        private System.Int32 GetMaxSubdivision() { }
        private System.Int32 GetMaxSubdivision(System.Single multiplier) { }
        private System.Single GetDistanceBetweenProbes(System.Int32 subdivisionLevel) { }
        private System.Single MinDistanceBetweenProbes() { }
        private System.Boolean DataHasBeenLoaded() { }
        private System.Void Clear() { }
        private UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId AddBricks(System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickIndex.Brick> bricks, UnityEngine.Experimental.Rendering.ProbeBrickPool.DataLocation dataloc, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo, System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc>& ch_list) { }
        private System.Void ReleaseBricks(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId id) { }
        private System.Void UpdateConstantBuffer(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Experimental.Rendering.ProbeVolumeShadingParameters parameters) { }
        private System.Void CleanupLoadedData() { }
        private UnityEngine.Experimental.Rendering.ProbeVolumeDebug get_debugDisplay() { }
        private UnityEngine.Color[] get_subdivisionDebugColors() { }
        private System.Void RenderDebug(UnityEngine.Camera camera) { }
        private System.Void InitializeDebug(UnityEngine.Mesh debugProbeMesh, UnityEngine.Shader debugProbeShader) { }
        private System.Void CleanupDebug() { }
        private System.Void RefreshDebug(UnityEngine.Rendering.DebugUI.Field<T> field, T value) { }
        private System.Void DebugCellIndexChanged(UnityEngine.Rendering.DebugUI.Field<T> field, T value) { }
        private System.Void RegisterDebug() { }
        private System.Void UnregisterDebug(System.Boolean destroyPanel) { }
        private System.Boolean ShouldCullCell(UnityEngine.Vector3 cellPosition, UnityEngine.Transform cameraTransform, UnityEngine.Plane[] frustumPlanes) { }
        private System.Void DrawProbeDebug(UnityEngine.Camera camera) { }
        private System.Void ClearDebugData() { }
        private System.Void CreateInstancedProbes() { }
        private System.Void OnClearLightingdata() { }
        private System.Void .cctor() { }
        private System.Boolean <RegisterDebug>b__119_0() { }
        private System.Void <RegisterDebug>b__119_1(System.Boolean value) { }
        private System.Boolean <RegisterDebug>b__119_2() { }
        private System.Void <RegisterDebug>b__119_3(System.Boolean value) { }
        private System.Single <RegisterDebug>b__119_4() { }
        private System.Void <RegisterDebug>b__119_5(System.Single value) { }
        private System.Boolean <RegisterDebug>b__119_7() { }
        private System.Void <RegisterDebug>b__119_8(System.Boolean value) { }
        private System.Int32 <RegisterDebug>b__119_9() { }
        private System.Void <RegisterDebug>b__119_10(System.Int32 value) { }
        private System.Int32 <RegisterDebug>b__119_11() { }
        private System.Void <RegisterDebug>b__119_12(System.Int32 value) { }
        private System.Single <RegisterDebug>b__119_13() { }
        private System.Void <RegisterDebug>b__119_14(System.Single value) { }
        private System.Single <RegisterDebug>b__119_17() { }
        private System.Void <RegisterDebug>b__119_18(System.Single value) { }
        private System.Single <RegisterDebug>b__119_19() { }
        private System.Void <RegisterDebug>b__119_20(System.Single value) { }
        private System.Int32 <RegisterDebug>b__119_22() { }
        private System.Void <RegisterDebug>b__119_23(System.Int32 v) { }

    }

    // TypeToken: 0x2000027
    public struct DebugProbeShadingMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Experimental.Rendering.DebugProbeShadingMode SH;        // 0x0
        public static UnityEngine.Experimental.Rendering.DebugProbeShadingMode Validity;        // 0x0
        public static UnityEngine.Experimental.Rendering.DebugProbeShadingMode ValidityOverDilationThreshold;        // 0x0
        public static UnityEngine.Experimental.Rendering.DebugProbeShadingMode Size;        // 0x0

    }

    // TypeToken: 0x2000028
    public class ProbeVolumeDebug
    {
        // Fields
        public System.Boolean drawProbes;        // 0x10
        public System.Boolean drawBricks;        // 0x11
        public System.Boolean drawCells;        // 0x12
        public System.Boolean realtimeSubdivision;        // 0x13
        public System.Int32 subdivisionCellUpdatePerFrame;        // 0x14
        public System.Single subdivisionDelayInSeconds;        // 0x18
        public UnityEngine.Experimental.Rendering.DebugProbeShadingMode probeShading;        // 0x1C
        public System.Single probeSize;        // 0x20
        public System.Single subdivisionViewCullingDistance;        // 0x24
        public System.Single probeCullingDistance;        // 0x28
        public System.Int32 maxSubdivToVisualize;        // 0x2C
        public System.Single exposureCompensation;        // 0x30

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000029
    public class ProbeReferenceVolumeProfile : ScriptableObject
    {
        // Fields
        private UnityEngine.Experimental.Rendering.ProbeReferenceVolumeProfile.Version version;        // 0x18
        public System.Int32 simplificationLevels;        // 0x1C
        public System.Single minDistanceBetweenProbes;        // 0x20

        // Methods
        private System.Int32 get_cellSizeInBricks() { }
        private System.Int32 get_maxSubdivision() { }
        private System.Single get_minBrickSize() { }
        private System.Single get_cellSizeInMeters() { }
        private System.Void OnEnable() { }
        private System.Boolean IsEquivalent(UnityEngine.Experimental.Rendering.ProbeReferenceVolumeProfile otherProfile) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002B
    public class ProbeVolume : MonoBehaviour
    {
        // Fields
        public System.Boolean globalVolume;        // 0x18
        public UnityEngine.Vector3 size;        // 0x1C
        public System.Single geometryDistanceOffset;        // 0x28
        public UnityEngine.LayerMask objectLayerMask;        // 0x2C
        public System.Int32 lowestSubdivLevelOverride;        // 0x30
        public System.Int32 highestSubdivLevelOverride;        // 0x34
        public System.Boolean overridesSubdivLevels;        // 0x38
        private System.Boolean mightNeedRebaking;        // 0x39
        private UnityEngine.Matrix4x4 cachedTransform;        // 0x3C
        private System.Int32 cachedHashCode;        // 0x7C

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002C
    public class ProbeVolumeAsset : ScriptableObject
    {
        // Fields
        protected internal System.Int32 m_Version;        // 0x18
        private System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Cell> cells;        // 0x20
        private UnityEngine.Vector3Int maxCellPosition;        // 0x28
        private UnityEngine.Vector3Int minCellPosition;        // 0x34
        private UnityEngine.Bounds globalBounds;        // 0x40
        private UnityEngine.Experimental.Rendering.ProbeVolumeSHBands bands;        // 0x58
        private System.String m_AssetFullPath;        // 0x60
        private System.Int32 cellSizeInBricks;        // 0x68
        private System.Single minDistanceBetweenProbes;        // 0x6C
        private System.Int32 simplificationLevels;        // 0x70

        // Methods
        private System.Int32 get_Version() { }
        private System.Int32 get_maxSubdivision() { }
        private System.Single get_minBrickSize() { }
        private System.Boolean CompatibleWith(UnityEngine.Experimental.Rendering.ProbeVolumeAsset otherAsset) { }
        private System.String GetSerializedFullPath() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002E
    public struct ProbeDilationSettings
    {
        // Fields
        public System.Boolean enableDilation;        // 0x10
        public System.Single dilationDistance;        // 0x14
        public System.Single dilationValidityThreshold;        // 0x18
        public System.Int32 dilationIterations;        // 0x1C
        public System.Boolean squaredDistWeighting;        // 0x20

    }

    // TypeToken: 0x200002F
    public struct VirtualOffsetSettings
    {
        // Fields
        public System.Boolean useVirtualOffset;        // 0x10
        public System.Single outOfGeoOffset;        // 0x14
        public System.Single searchMultiplier;        // 0x18

    }

    // TypeToken: 0x2000030
    public struct ProbeVolumeBakingProcessSettings
    {
        // Fields
        public UnityEngine.Experimental.Rendering.ProbeDilationSettings dilationSettings;        // 0x10
        public UnityEngine.Experimental.Rendering.VirtualOffsetSettings virtualOffsetSettings;        // 0x24

    }

    // TypeToken: 0x2000031
    public struct ProbeVolumeState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Experimental.Rendering.ProbeVolumeState Default;        // 0x0
        public static UnityEngine.Experimental.Rendering.ProbeVolumeState Invalid;        // 0x0

    }

    // TypeToken: 0x2000032
    public class ProbeVolumePerSceneData : MonoBehaviour, ISerializationCallbackReceiver
    {
        // Fields
        private System.Collections.Generic.Dictionary<UnityEngine.Experimental.Rendering.ProbeVolumeState,UnityEngine.Experimental.Rendering.ProbeVolumeAsset> assets;        // 0x18
        private System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeVolumePerSceneData.SerializableAssetItem> serializedAssets;        // 0x20
        private UnityEngine.Experimental.Rendering.ProbeVolumeState m_CurrentState;        // 0x28
        private UnityEngine.Experimental.Rendering.ProbeVolumeState m_PreviousState;        // 0x2C

        // Methods
        private System.Void OnAfterDeserialize() { }
        private System.Void OnBeforeSerialize() { }
        private System.Void StoreAssetForState(UnityEngine.Experimental.Rendering.ProbeVolumeState state, UnityEngine.Experimental.Rendering.ProbeVolumeAsset asset) { }
        private System.Void InvalidateAllAssets() { }
        private UnityEngine.Experimental.Rendering.ProbeVolumeAsset GetCurrentStateAsset() { }
        private System.Void QueueAssetLoading() { }
        private System.Void QueueAssetRemoval() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000034
    public class ProbeVolumeSceneData, ISerializationCallbackReceiver
    {
        // Fields
        private static System.Reflection.PropertyInfo s_SceneGUID;        // 0x0
        private System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeVolumeSceneData.SerializableBoundItem> serializedBounds;        // 0x10
        private System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeVolumeSceneData.SerializableHasPVItem> serializedHasVolumes;        // 0x18
        private System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeVolumeSceneData.SerializablePVProfile> serializedProfiles;        // 0x20
        private System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeVolumeSceneData.SerializablePVBakeSettings> serializedBakeSettings;        // 0x28
        private System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeVolumeSceneData.BakingSet> serializedBakingSets;        // 0x30
        private UnityEngine.Object parentAsset;        // 0x38
        private System.String parentSceneDataPropertyName;        // 0x40
        public System.Collections.Generic.Dictionary<System.String,UnityEngine.Bounds> sceneBounds;        // 0x48
        private System.Collections.Generic.Dictionary<System.String,System.Boolean> hasProbeVolumes;        // 0x50
        private System.Collections.Generic.Dictionary<System.String,UnityEngine.Experimental.Rendering.ProbeReferenceVolumeProfile> sceneProfiles;        // 0x58
        private System.Collections.Generic.Dictionary<System.String,UnityEngine.Experimental.Rendering.ProbeVolumeBakingProcessSettings> sceneBakingSettings;        // 0x60
        private System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeVolumeSceneData.BakingSet> bakingSets;        // 0x68

        // Methods
        private System.String GetSceneGUID(UnityEngine.SceneManagement.Scene scene) { }
        private System.Void .ctor(UnityEngine.Object parentAsset, System.String parentSceneDataPropertyName) { }
        private System.Void SetParentObject(UnityEngine.Object parent, System.String parentSceneDataPropertyName) { }
        private System.Void OnAfterDeserialize() { }
        private System.Void UpdateBakingSets() { }
        private System.Void OnBeforeSerialize() { }
        private UnityEngine.Experimental.Rendering.ProbeVolumeSceneData.BakingSet CreateNewBakingSet(System.String name) { }
        private System.Void InitializeBakingSet(UnityEngine.Experimental.Rendering.ProbeVolumeSceneData.BakingSet set, System.String name) { }
        private System.Void SyncBakingSetSettings() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200003B
    public struct RendererList
    {
        // Fields
        private static readonly UnityEngine.Rendering.ShaderTagId s_EmptyName;        // 0x0
        public static readonly UnityEngine.Experimental.Rendering.RendererList nullRendererList;        // 0x8
        private System.Boolean <isValid>k__BackingField;        // 0x10
        public UnityEngine.Rendering.CullingResults cullingResult;        // 0x18
        public UnityEngine.Rendering.DrawingSettings drawSettings;        // 0x28
        public UnityEngine.Rendering.FilteringSettings filteringSettings;        // 0x174
        public System.Nullable<UnityEngine.Rendering.RenderStateBlock> stateBlock;        // 0x194

        // Methods
        private System.Boolean get_isValid() { }
        private System.Void set_isValid(System.Boolean value) { }
        private UnityEngine.Experimental.Rendering.RendererList Create(UnityEngine.Experimental.Rendering.RendererListDesc& desc) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200003C
    public struct RendererListDesc
    {
        // Fields
        public UnityEngine.Rendering.SortingCriteria sortingCriteria;        // 0x10
        public UnityEngine.Rendering.PerObjectData rendererConfiguration;        // 0x14
        public UnityEngine.Rendering.RenderQueueRange renderQueueRange;        // 0x18
        public System.Nullable<UnityEngine.Rendering.RenderStateBlock> stateBlock;        // 0x20
        public UnityEngine.Material overrideMaterial;        // 0x90
        public System.Boolean excludeObjectMotionVectors;        // 0x98
        public System.Int32 layerMask;        // 0x9C
        public System.Int32 overrideMaterialPassIndex;        // 0xA0
        private UnityEngine.Rendering.CullingResults <cullingResult>k__BackingField;        // 0xA8
        private UnityEngine.Camera <camera>k__BackingField;        // 0xB8
        private UnityEngine.Rendering.ShaderTagId <passName>k__BackingField;        // 0xC0
        private UnityEngine.Rendering.ShaderTagId[] <passNames>k__BackingField;        // 0xC8

        // Methods
        private UnityEngine.Rendering.CullingResults get_cullingResult() { }
        private System.Void set_cullingResult(UnityEngine.Rendering.CullingResults value) { }
        private UnityEngine.Camera get_camera() { }
        private System.Void set_camera(UnityEngine.Camera value) { }
        private UnityEngine.Rendering.ShaderTagId get_passName() { }
        private System.Void set_passName(UnityEngine.Rendering.ShaderTagId value) { }
        private UnityEngine.Rendering.ShaderTagId[] get_passNames() { }
        private System.Void set_passNames(UnityEngine.Rendering.ShaderTagId[] value) { }
        private System.Void .ctor(UnityEngine.Rendering.ShaderTagId passName, UnityEngine.Rendering.CullingResults cullingResult, UnityEngine.Camera camera) { }
        private System.Void .ctor(UnityEngine.Rendering.ShaderTagId[] passNames, UnityEngine.Rendering.CullingResults cullingResult, UnityEngine.Camera camera) { }
        private System.Boolean IsValid() { }

    }

}

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{

    // TypeToken: 0x200003D
    public struct DepthAccess
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Experimental.Rendering.RenderGraphModule.DepthAccess Read;        // 0x0
        public static UnityEngine.Experimental.Rendering.RenderGraphModule.DepthAccess Write;        // 0x0
        public static UnityEngine.Experimental.Rendering.RenderGraphModule.DepthAccess ReadWrite;        // 0x0

    }

    // TypeToken: 0x200003E
    public class RenderGraphContext
    {
        // Fields
        public UnityEngine.Rendering.ScriptableRenderContext renderContext;        // 0x10
        public UnityEngine.Rendering.CommandBuffer cmd;        // 0x18
        public UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool renderGraphPool;        // 0x20
        public UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDefaultResources defaultResources;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003F
    public struct RenderGraphParameters
    {
        // Fields
        public System.String executionName;        // 0x10
        public System.Int32 currentFrameIndex;        // 0x18
        public System.Boolean rendererListCulling;        // 0x1C
        public UnityEngine.Rendering.ScriptableRenderContext scriptableRenderContext;        // 0x20
        public UnityEngine.Rendering.CommandBuffer commandBuffer;        // 0x28

    }

    // TypeToken: 0x2000040
    public struct RenderGraphExecution, IDisposable
    {
        // Fields
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph) { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x2000041
    public class RenderGraphDebugParams
    {
        // Fields
        private UnityEngine.Rendering.DebugUI.Widget[] m_DebugItems;        // 0x10
        private UnityEngine.Rendering.DebugUI.Panel m_DebugPanel;        // 0x18
        public System.Boolean clearRenderTargetsAtCreation;        // 0x20
        public System.Boolean clearRenderTargetsAtRelease;        // 0x21
        public System.Boolean disablePassCulling;        // 0x22
        public System.Boolean immediateMode;        // 0x23
        public System.Boolean enableLogging;        // 0x24
        public System.Boolean logFrameInformation;        // 0x25
        public System.Boolean logResources;        // 0x26

        // Methods
        private System.Void RegisterDebug(System.String name, UnityEngine.Rendering.DebugUI.Panel debugPanel) { }
        private System.Void UnRegisterDebug(System.String name) { }
        private System.Void .ctor() { }
        private System.Boolean <RegisterDebug>b__10_0() { }
        private System.Void <RegisterDebug>b__10_1(System.Boolean value) { }
        private System.Boolean <RegisterDebug>b__10_2() { }
        private System.Void <RegisterDebug>b__10_3(System.Boolean value) { }
        private System.Boolean <RegisterDebug>b__10_4() { }
        private System.Void <RegisterDebug>b__10_5(System.Boolean value) { }
        private System.Boolean <RegisterDebug>b__10_6() { }
        private System.Void <RegisterDebug>b__10_7(System.Boolean value) { }
        private System.Void <RegisterDebug>b__10_8() { }
        private System.Void <RegisterDebug>b__10_9() { }

    }

    // TypeToken: 0x2000043
    public class RenderFunc`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext renderGraphContext) { }
        private System.IAsyncResult BeginInvoke(PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext renderGraphContext, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000044
    public class RenderGraphDebugData
    {
        // Fields
        public System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugData.PassDebugData> passList;        // 0x10
        public System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugData.ResourceDebugData>[] resourceLists;        // 0x18

        // Methods
        private System.Void Clear() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000047
    public class RenderGraph
    {
        // Fields
        public static readonly System.Int32 kMaxMRTCount;        // 0x0
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry m_Resources;        // 0x10
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool m_RenderGraphPool;        // 0x18
        private System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass> m_RenderPasses;        // 0x20
        private System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle> m_RendererLists;        // 0x28
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugParams m_DebugParameters;        // 0x30
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger m_FrameInformationLogger;        // 0x38
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDefaultResources m_DefaultResources;        // 0x40
        private System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Rendering.ProfilingSampler> m_DefaultProfilingSamplers;        // 0x48
        private System.Boolean m_ExecutionExceptionWasRaised;        // 0x50
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext m_RenderGraphContext;        // 0x58
        private UnityEngine.Rendering.CommandBuffer m_PreviousCommandBuffer;        // 0x60
        private System.Int32 m_CurrentImmediatePassIndex;        // 0x68
        private System.Collections.Generic.List<System.Int32>[] m_ImmediateModeResourceList;        // 0x70
        private UnityEngine.Rendering.DynamicArray<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo>[] m_CompiledResourcesInfos;        // 0x78
        private UnityEngine.Rendering.DynamicArray<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo> m_CompiledPassInfos;        // 0x80
        private System.Collections.Generic.Stack<System.Int32> m_CullingStack;        // 0x88
        private System.Int32 m_ExecutionCount;        // 0x90
        private System.Int32 m_CurrentFrameIndex;        // 0x94
        private System.Boolean m_HasRenderGraphBegun;        // 0x98
        private System.String m_CurrentExecutionName;        // 0xA0
        private System.Boolean m_RendererListCulling;        // 0xA8
        private System.Collections.Generic.Dictionary<System.String,UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugData> m_DebugData;        // 0xB0
        private static System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph> s_RegisteredGraphs;        // 0x8
        private System.String <name>k__BackingField;        // 0xB8
        private static System.Boolean <requireDebugData>k__BackingField;        // 0x10
        private static UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate onGraphRegistered;        // 0x18
        private static UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate onGraphUnregistered;        // 0x20
        private static UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate onExecutionRegistered;        // 0x28
        private static UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate onExecutionUnregistered;        // 0x30

        // Methods
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private System.Boolean get_requireDebugData() { }
        private System.Void set_requireDebugData(System.Boolean value) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDefaultResources get_defaultResources() { }
        private System.Void .ctor(System.String name) { }
        private System.Void Cleanup() { }
        private System.Void RegisterDebug(UnityEngine.Rendering.DebugUI.Panel panel) { }
        private System.Void UnRegisterDebug() { }
        private System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph> GetRegisteredRenderGraphs() { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugData GetDebugData(System.String executionName) { }
        private System.Void EndFrame() { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle ImportTexture(UnityEngine.Rendering.RTHandle rt) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle ImportBackbuffer(UnityEngine.Rendering.RenderTargetIdentifier rt) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle CreateTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc& desc) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle CreateSharedTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc& desc, System.Boolean explicitRelease) { }
        private System.Void ReleaseSharedTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle CreateTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture) { }
        private System.Void CreateTextureIfInvalid(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc& desc, UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle& texture) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc GetTextureDesc(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle CreateRendererList(UnityEngine.Rendering.RendererUtils.RendererListDesc& desc) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle ImportComputeBuffer(UnityEngine.ComputeBuffer computeBuffer) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle CreateComputeBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferDesc& desc) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle CreateComputeBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle& computeBuffer) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferDesc GetComputeBufferDesc(UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle& computeBuffer) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphBuilder AddRenderPass(System.String passName, PassData& passData, UnityEngine.Rendering.ProfilingSampler sampler) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphBuilder AddRenderPass(System.String passName, PassData& passData) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphExecution RecordAndExecute(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphParameters& parameters) { }
        private System.Void Execute() { }
        private System.Void BeginProfilingSampler(UnityEngine.Rendering.ProfilingSampler sampler) { }
        private System.Void EndProfilingSampler(UnityEngine.Rendering.ProfilingSampler sampler) { }
        private UnityEngine.Rendering.DynamicArray<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo> GetCompiledPassInfos() { }
        private System.Void ClearCompiledGraph() { }
        private System.Void InvalidateContext() { }
        private System.Void OnPassAdded(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass pass) { }
        private System.Void add_onGraphRegistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate value) { }
        private System.Void remove_onGraphRegistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate value) { }
        private System.Void add_onGraphUnregistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate value) { }
        private System.Void remove_onGraphUnregistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate value) { }
        private System.Void add_onExecutionRegistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate value) { }
        private System.Void remove_onExecutionRegistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate value) { }
        private System.Void add_onExecutionUnregistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate value) { }
        private System.Void remove_onExecutionUnregistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate value) { }
        private System.Void InitResourceInfosData(UnityEngine.Rendering.DynamicArray<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo> resourceInfos, System.Int32 count) { }
        private System.Void InitializeCompilationData() { }
        private System.Void CountReferences() { }
        private System.Void CullUnusedPasses() { }
        private System.Void UpdatePassSynchronization(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo& currentPassInfo, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo& producerPassInfo, System.Int32 currentPassIndex, System.Int32 lastProducer, System.Int32& intLastSyncIndex) { }
        private System.Void UpdateResourceSynchronization(System.Int32& lastGraphicsPipeSync, System.Int32& lastComputePipeSync, System.Int32 currentPassIndex, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo& resource) { }
        private System.Int32 GetLatestProducerIndex(System.Int32 passIndex, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo& info) { }
        private System.Int32 GetLatestValidReadIndex(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo& info) { }
        private System.Int32 GetFirstValidWriteIndex(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo& info) { }
        private System.Int32 GetLatestValidWriteIndex(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo& info) { }
        private System.Void CreateRendererLists() { }
        private System.Void UpdateResourceAllocationAndSynchronization() { }
        private System.Boolean AreRendererListsEmpty(System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle> rendererLists) { }
        private System.Void TryCullPassAtIndex(System.Int32 passIndex) { }
        private System.Void CullRendererLists() { }
        private System.Void CompileRenderGraph() { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo& CompilePassImmediatly(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass pass) { }
        private System.Void ExecutePassImmediatly(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass pass) { }
        private System.Void ExecuteCompiledPass(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo& passInfo, System.Int32 passIndex) { }
        private System.Void ExecuteRenderGraph() { }
        private System.Void PreRenderPassSetRenderTargets(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo& passInfo, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext) { }
        private System.Void PreRenderPassExecute(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo& passInfo, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext) { }
        private System.Void PostRenderPassExecute(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo& passInfo, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext) { }
        private System.Void ClearRenderPasses() { }
        private System.Void ReleaseImmediateModeResources() { }
        private System.Void LogFrameInformation() { }
        private System.Void LogRendererListsCreation() { }
        private System.Void LogRenderPassBegin(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo& passInfo) { }
        private System.Void LogCulledPasses() { }
        private UnityEngine.Rendering.ProfilingSampler GetDefaultProfilingSampler(System.String name) { }
        private System.Void UpdateImportedResourceLifeTime(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugData.ResourceDebugData& data, System.Collections.Generic.List<System.Int32> passList) { }
        private System.Void GenerateDebugData() { }
        private System.Void CleanupDebugData() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200004E
    public struct RenderGraphProfilingScope, IDisposable
    {
        // Fields
        private System.Boolean m_Disposed;        // 0x10
        private UnityEngine.Rendering.ProfilingSampler m_Sampler;        // 0x18
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph m_RenderGraph;        // 0x20

        // Methods
        private System.Void .ctor(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ProfilingSampler sampler) { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }

    }

    // TypeToken: 0x200004F
    public struct RenderGraphBuilder, IDisposable
    {
        // Fields
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass m_RenderPass;        // 0x10
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry m_Resources;        // 0x18
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph m_RenderGraph;        // 0x20
        private System.Boolean m_Disposed;        // 0x28

        // Methods
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle UseColorBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle& input, System.Int32 index) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle UseDepthBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle& input, UnityEngine.Experimental.Rendering.RenderGraphModule.DepthAccess flags) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle ReadTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle& input) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle WriteTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle& input) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle ReadWriteTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle& input) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle CreateTransientTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc& desc) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle CreateTransientTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle& texture) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle UseRendererList(UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle& input) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle ReadComputeBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle& input) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle WriteComputeBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle& input) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle CreateTransientComputeBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferDesc& desc) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle CreateTransientComputeBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle& computebuffer) { }
        private System.Void SetRenderFunc(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<PassData> renderFunc) { }
        private System.Void EnableAsyncCompute(System.Boolean value) { }
        private System.Void AllowPassCulling(System.Boolean value) { }
        private System.Void Dispose() { }
        private System.Void AllowRendererListCulling(System.Boolean value) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle DependsOn(UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle& input) { }
        private System.Void .ctor(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass renderPass, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void CheckResource(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle& res, System.Boolean dontCheckTransientReadWrite) { }
        private System.Void GenerateDebugData(System.Boolean value) { }

    }

    // TypeToken: 0x2000050
    public class RenderGraphDefaultResources
    {
        // Fields
        private System.Boolean m_IsValid;        // 0x10
        private UnityEngine.Rendering.RTHandle m_BlackTexture2D;        // 0x18
        private UnityEngine.Rendering.RTHandle m_WhiteTexture2D;        // 0x20
        private UnityEngine.Rendering.RTHandle m_ShadowTexture2D;        // 0x28
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <blackTexture>k__BackingField;        // 0x30
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <whiteTexture>k__BackingField;        // 0x40
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <clearTextureXR>k__BackingField;        // 0x50
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <magentaTextureXR>k__BackingField;        // 0x60
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <blackTextureXR>k__BackingField;        // 0x70
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <blackTextureArrayXR>k__BackingField;        // 0x80
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <blackUIntTextureXR>k__BackingField;        // 0x90
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <blackTexture3DXR>k__BackingField;        // 0xA0
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <whiteTextureXR>k__BackingField;        // 0xB0
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <defaultShadowTexture>k__BackingField;        // 0xC0

        // Methods
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_blackTexture() { }
        private System.Void set_blackTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_whiteTexture() { }
        private System.Void set_whiteTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_clearTextureXR() { }
        private System.Void set_clearTextureXR(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_magentaTextureXR() { }
        private System.Void set_magentaTextureXR(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_blackTextureXR() { }
        private System.Void set_blackTextureXR(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_blackTextureArrayXR() { }
        private System.Void set_blackTextureArrayXR(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_blackUIntTextureXR() { }
        private System.Void set_blackUIntTextureXR(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_blackTexture3DXR() { }
        private System.Void set_blackTexture3DXR(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_whiteTextureXR() { }
        private System.Void set_whiteTextureXR(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_defaultShadowTexture() { }
        private System.Void set_defaultShadowTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value) { }
        private System.Void .ctor() { }
        private System.Void Cleanup() { }
        private System.Void InitializeForRendering(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph) { }

    }

    // TypeToken: 0x2000051
    public struct RenderGraphLogIndent, IDisposable
    {
        // Fields
        private System.Int32 m_Indentation;        // 0x10
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger m_Logger;        // 0x18
        private System.Boolean m_Disposed;        // 0x20

        // Methods
        private System.Void .ctor(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger, System.Int32 indentation) { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }

    }

    // TypeToken: 0x2000052
    public class RenderGraphLogger
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.String,System.Text.StringBuilder> m_LogMap;        // 0x10
        private System.Text.StringBuilder m_CurrentBuilder;        // 0x18
        private System.Int32 m_CurrentIndentation;        // 0x20

        // Methods
        private System.Void Initialize(System.String logName) { }
        private System.Void IncrementIndentation(System.Int32 value) { }
        private System.Void DecrementIndentation(System.Int32 value) { }
        private System.Void LogLine(System.String format, System.Object[] args) { }
        private System.String GetLog(System.String logName) { }
        private System.String GetAllLogs() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000053
    public class RenderGraphObjectPool
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.ValueTuple<System.Type,System.Int32>,System.Collections.Generic.Stack<System.Object>> m_ArrayPool;        // 0x10
        private System.Collections.Generic.List<System.ValueTuple<System.Object,System.ValueTuple<System.Type,System.Int32>>> m_AllocatedArrays;        // 0x18
        private System.Collections.Generic.List<UnityEngine.MaterialPropertyBlock> m_AllocatedMaterialPropertyBlocks;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private T[] GetTempArray(System.Int32 size) { }
        private UnityEngine.MaterialPropertyBlock GetTempMaterialPropertyBlock() { }
        private System.Void ReleaseAllTempAlloc() { }
        private T Get() { }
        private System.Void Release(T value) { }
        private System.Void Cleanup() { }

    }

    // TypeToken: 0x2000056
    public class RenderGraphPass
    {
        // Fields
        private System.String <name>k__BackingField;        // 0x10
        private System.Int32 <index>k__BackingField;        // 0x18
        private UnityEngine.Rendering.ProfilingSampler <customSampler>k__BackingField;        // 0x20
        private System.Boolean <enableAsyncCompute>k__BackingField;        // 0x28
        private System.Boolean <allowPassCulling>k__BackingField;        // 0x29
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <depthBuffer>k__BackingField;        // 0x2C
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle[] <colorBuffers>k__BackingField;        // 0x40
        private System.Int32 <colorBufferMaxIndex>k__BackingField;        // 0x48
        private System.Int32 <refCount>k__BackingField;        // 0x4C
        private System.Boolean <generateDebugData>k__BackingField;        // 0x50
        private System.Boolean <allowRendererListCulling>k__BackingField;        // 0x51
        public System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle>[] resourceReadLists;        // 0x58
        public System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle>[] resourceWriteLists;        // 0x60
        public System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle>[] transientResourceList;        // 0x68
        public System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle> usedRendererListList;        // 0x70
        public System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle> dependsOnRendererListList;        // 0x78

        // Methods
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<PassData> GetExecuteDelegate() { }
        private System.Void Execute(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext renderGraphContext) { }
        private System.Void Release(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool pool) { }
        private System.Boolean HasRenderFunc() { }
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private System.Int32 get_index() { }
        private System.Void set_index(System.Int32 value) { }
        private UnityEngine.Rendering.ProfilingSampler get_customSampler() { }
        private System.Void set_customSampler(UnityEngine.Rendering.ProfilingSampler value) { }
        private System.Boolean get_enableAsyncCompute() { }
        private System.Void set_enableAsyncCompute(System.Boolean value) { }
        private System.Boolean get_allowPassCulling() { }
        private System.Void set_allowPassCulling(System.Boolean value) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_depthBuffer() { }
        private System.Void set_depthBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle[] get_colorBuffers() { }
        private System.Void set_colorBuffers(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle[] value) { }
        private System.Int32 get_colorBufferMaxIndex() { }
        private System.Void set_colorBufferMaxIndex(System.Int32 value) { }
        private System.Int32 get_refCount() { }
        private System.Void set_refCount(System.Int32 value) { }
        private System.Boolean get_generateDebugData() { }
        private System.Void set_generateDebugData(System.Boolean value) { }
        private System.Boolean get_allowRendererListCulling() { }
        private System.Void set_allowRendererListCulling(System.Boolean value) { }
        private System.Void .ctor() { }
        private System.Void Clear() { }
        private System.Void AddResourceWrite(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle& res) { }
        private System.Void AddResourceRead(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle& res) { }
        private System.Void AddTransientResource(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle& res) { }
        private System.Void UseRendererList(UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle rendererList) { }
        private System.Void DependsOnRendererList(UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle rendererList) { }
        private System.Void EnableAsyncCompute(System.Boolean value) { }
        private System.Void AllowPassCulling(System.Boolean value) { }
        private System.Void AllowRendererListCulling(System.Boolean value) { }
        private System.Void GenerateDebugData(System.Boolean value) { }
        private System.Void SetColorBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle resource, System.Int32 index) { }
        private System.Void SetDepthBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle resource, UnityEngine.Experimental.Rendering.RenderGraphModule.DepthAccess flags) { }

    }

    // TypeToken: 0x2000057
    public class RenderGraphPass`1 : RenderGraphPass
    {
        // Fields
        private PassData data;        // 0x0
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<PassData> renderFunc;        // 0x0

        // Methods
        private System.Void Execute(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext renderGraphContext) { }
        private System.Void Initialize(System.Int32 passIndex, PassData passData, System.String passName, UnityEngine.Rendering.ProfilingSampler sampler) { }
        private System.Void Release(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool pool) { }
        private System.Boolean HasRenderFunc() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000058
    public struct RenderGraphProfileId
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphProfileId CompileRenderGraph;        // 0x0
        public static UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphProfileId ExecuteRenderGraph;        // 0x0
        public static UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphProfileId RenderGraphClear;        // 0x0
        public static UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphProfileId RenderGraphClearDebug;        // 0x0

    }

    // TypeToken: 0x2000059
    public struct ComputeBufferHandle
    {
        // Fields
        private static UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle s_NullHandle;        // 0x0
        private UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle handle;        // 0x10

        // Methods
        private UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle get_nullHandle() { }
        private System.Void .ctor(System.Int32 handle, System.Boolean shared) { }
        private UnityEngine.ComputeBuffer op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle buffer) { }
        private System.Boolean IsValid() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200005A
    public struct ComputeBufferDesc
    {
        // Fields
        public System.Int32 count;        // 0x10
        public System.Int32 stride;        // 0x14
        public UnityEngine.ComputeBufferType type;        // 0x18
        public System.String name;        // 0x20

        // Methods
        private System.Void .ctor(System.Int32 count, System.Int32 stride) { }
        private System.Void .ctor(System.Int32 count, System.Int32 stride, UnityEngine.ComputeBufferType type) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200005B
    public class ComputeBufferResource : RenderGraphResource`2
    {
        // Methods
        private System.String GetName() { }
        private System.Void CreatePooledGraphicsResource() { }
        private System.Void ReleasePooledGraphicsResource(System.Int32 frameIndex) { }
        private System.Void CreateGraphicsResource(System.String name) { }
        private System.Void ReleaseGraphicsResource() { }
        private System.Void LogCreation(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger) { }
        private System.Void LogRelease(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005C
    public class ComputeBufferPool : RenderGraphResourcePool`1
    {
        // Methods
        private System.Void ReleaseInternalResource(UnityEngine.ComputeBuffer res) { }
        private System.String GetResourceName(UnityEngine.ComputeBuffer res) { }
        private System.Int64 GetResourceSize(UnityEngine.ComputeBuffer res) { }
        private System.String GetResourceTypeName() { }
        private System.Int32 GetSortIndex(UnityEngine.ComputeBuffer res) { }
        private System.Void PurgeUnusedResources(System.Int32 currentFrameIndex) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005D
    public class IRenderGraphResourcePool
    {
        // Methods
        private System.Void PurgeUnusedResources(System.Int32 currentFrameIndex) { }
        private System.Void Cleanup() { }
        private System.Void CheckFrameAllocation(System.Boolean onException, System.Int32 frameIndex) { }
        private System.Void LogResources(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005E
    public class RenderGraphResourcePool`1 : IRenderGraphResourcePool
    {
        // Fields
        protected System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.SortedList<System.Int32,System.ValueTuple<Type,System.Int32>>> m_ResourcePool;        // 0x0
        protected System.Collections.Generic.List<System.Int32> m_RemoveList;        // 0x0
        private System.Collections.Generic.List<System.ValueTuple<System.Int32,Type>> m_FrameAllocatedResources;        // 0x0
        protected static System.Int32 s_CurrentFrameIndex;        // 0x0
        private static System.Int32 kStaleResourceLifetime;        // 0x0

        // Methods
        private System.Void ReleaseInternalResource(Type res) { }
        private System.String GetResourceName(Type res) { }
        private System.Int64 GetResourceSize(Type res) { }
        private System.String GetResourceTypeName() { }
        private System.Int32 GetSortIndex(Type res) { }
        private System.Void ReleaseResource(System.Int32 hash, Type resource, System.Int32 currentFrameIndex) { }
        private System.Boolean TryGetResource(System.Int32 hashCode, Type& resource) { }
        private System.Void Cleanup() { }
        private System.Void RegisterFrameAllocation(System.Int32 hash, Type value) { }
        private System.Void UnregisterFrameAllocation(System.Int32 hash, Type value) { }
        private System.Void CheckFrameAllocation(System.Boolean onException, System.Int32 frameIndex) { }
        private System.Void LogResources(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger) { }
        private System.Boolean ShouldReleaseResource(System.Int32 lastUsedFrameIndex, System.Int32 currentFrameIndex) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000061
    public class RenderGraphResourceRegistry
    {
        // Fields
        private static System.Int32 kSharedResourceLifetime;        // 0x0
        private static UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry m_CurrentRegistry;        // 0x0
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry.RenderGraphResourcesData[] m_RenderGraphResources;        // 0x10
        private UnityEngine.Rendering.DynamicArray<UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListResource> m_RendererListResources;        // 0x18
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugParams m_RenderGraphDebug;        // 0x20
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger m_ResourceLogger;        // 0x28
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger m_FrameInformationLogger;        // 0x30
        private System.Int32 m_CurrentFrameIndex;        // 0x38
        private System.Int32 m_ExecutionCount;        // 0x3C
        private UnityEngine.Rendering.RTHandle m_CurrentBackbuffer;        // 0x40
        private static System.Int32 kInitialRendererListCount;        // 0x0
        private System.Collections.Generic.List<UnityEngine.Rendering.RendererUtils.RendererList> m_ActiveRendererLists;        // 0x48

        // Methods
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry get_current() { }
        private System.Void set_current(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry value) { }
        private UnityEngine.Rendering.RTHandle GetTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle& handle) { }
        private System.Boolean TextureNeedsFallback(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle& handle) { }
        private UnityEngine.Rendering.RendererUtils.RendererList GetRendererList(UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle& handle) { }
        private UnityEngine.ComputeBuffer GetComputeBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle& handle) { }
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugParams renderGraphDebug, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger frameInformationLogger) { }
        private System.Void BeginRenderGraph(System.Int32 executionCount) { }
        private System.Void BeginExecute(System.Int32 currentFrameIndex) { }
        private System.Void EndExecute() { }
        private System.Void CheckHandleValidity(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle& res) { }
        private System.Void CheckHandleValidity(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType type, System.Int32 index) { }
        private System.Void IncrementWriteCount(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle& res) { }
        private System.String GetRenderGraphResourceName(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle& res) { }
        private System.String GetRenderGraphResourceName(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType type, System.Int32 index) { }
        private System.Boolean IsRenderGraphResourceImported(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle& res) { }
        private System.Boolean IsRenderGraphResourceShared(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType type, System.Int32 index) { }
        private System.Boolean IsGraphicsResourceCreated(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle& res) { }
        private System.Boolean IsRendererListCreated(UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle& res) { }
        private System.Boolean IsRenderGraphResourceImported(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType type, System.Int32 index) { }
        private System.Int32 GetRenderGraphResourceTransientIndex(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle& res) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle ImportTexture(UnityEngine.Rendering.RTHandle rt) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle CreateSharedTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc& desc, System.Boolean explicitRelease) { }
        private System.Void ReleaseSharedTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle ImportBackbuffer(UnityEngine.Rendering.RenderTargetIdentifier rt) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle CreateTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc& desc, System.Int32 transientPassIndex) { }
        private System.Int32 GetTextureResourceCount() { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureResource GetTextureResource(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle& handle) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc GetTextureResourceDesc(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle& handle) { }
        private System.Void ForceTextureClear(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle& handle, UnityEngine.Color clearColor) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle CreateRendererList(UnityEngine.Rendering.RendererUtils.RendererListDesc& desc) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle ImportComputeBuffer(UnityEngine.ComputeBuffer computeBuffer) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle CreateComputeBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferDesc& desc, System.Int32 transientPassIndex) { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferDesc GetComputeBufferResourceDesc(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle& handle) { }
        private System.Int32 GetComputeBufferResourceCount() { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferResource GetComputeBufferResource(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle& handle) { }
        private System.Void UpdateSharedResourceLastFrameIndex(System.Int32 type, System.Int32 index) { }
        private System.Void ManageSharedRenderGraphResources() { }
        private System.Void CreatePooledResource(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext, System.Int32 type, System.Int32 index) { }
        private System.Void CreateTextureCallback(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext, UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource res) { }
        private System.Void ReleasePooledResource(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext, System.Int32 type, System.Int32 index) { }
        private System.Void ReleaseTextureCallback(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext, UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource res) { }
        private System.Void ValidateTextureDesc(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc& desc) { }
        private System.Void ValidateRendererListDesc(UnityEngine.Rendering.RendererUtils.RendererListDesc& desc) { }
        private System.Void ValidateComputeBufferDesc(UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferDesc& desc) { }
        private System.Void CreateRendererLists(System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle> rendererLists, UnityEngine.Rendering.ScriptableRenderContext context, System.Boolean manualDispatch) { }
        private System.Void Clear(System.Boolean onException) { }
        private System.Void PurgeUnusedGraphicsResources() { }
        private System.Void Cleanup() { }
        private System.Void FlushLogs() { }
        private System.Void LogResources() { }

    }

    // TypeToken: 0x2000064
    public struct RendererListHandle
    {
        // Fields
        private System.Boolean m_IsValid;        // 0x10
        private System.Int32 <handle>k__BackingField;        // 0x14

        // Methods
        private System.Int32 get_handle() { }
        private System.Void set_handle(System.Int32 value) { }
        private System.Void .ctor(System.Int32 handle) { }
        private System.Int32 op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle handle) { }
        private UnityEngine.Rendering.RendererUtils.RendererList op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle rendererList) { }
        private System.Boolean IsValid() { }

    }

    // TypeToken: 0x2000065
    public struct RendererListResource
    {
        // Fields
        public UnityEngine.Rendering.RendererUtils.RendererListDesc desc;        // 0x10
        public UnityEngine.Rendering.RendererUtils.RendererList rendererList;        // 0xF0

        // Methods
        private System.Void .ctor(UnityEngine.Rendering.RendererUtils.RendererListDesc& desc) { }

    }

    // TypeToken: 0x2000066
    public struct RenderGraphResourceType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType Texture;        // 0x0
        public static UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType ComputeBuffer;        // 0x0
        public static UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType Count;        // 0x0

    }

    // TypeToken: 0x2000067
    public struct ResourceHandle
    {
        // Fields
        private static System.UInt32 kValidityMask;        // 0x0
        private static System.UInt32 kIndexMask;        // 0x0
        private System.UInt32 m_Value;        // 0x10
        private static System.UInt32 s_CurrentValidBit;        // 0x0
        private static System.UInt32 s_SharedResourceValidBit;        // 0x4
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType <type>k__BackingField;        // 0x14

        // Methods
        private System.Int32 get_index() { }
        private UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType get_type() { }
        private System.Void set_type(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType value) { }
        private System.Int32 get_iType() { }
        private System.Void .ctor(System.Int32 value, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType type, System.Boolean shared) { }
        private System.Int32 op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle handle) { }
        private System.Boolean IsValid() { }
        private System.Void NewFrame(System.Int32 executionIndex) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000068
    public class IRenderGraphResource
    {
        // Fields
        public System.Boolean imported;        // 0x10
        public System.Boolean shared;        // 0x11
        public System.Boolean sharedExplicitRelease;        // 0x12
        public System.Boolean requestFallBack;        // 0x13
        public System.UInt32 writeCount;        // 0x14
        public System.Int32 cachedHash;        // 0x18
        public System.Int32 transientPassIndex;        // 0x1C
        public System.Int32 sharedResourceLastFrameUsed;        // 0x20
        protected UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResourcePool m_Pool;        // 0x28

        // Methods
        private System.Void Reset(UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResourcePool pool) { }
        private System.String GetName() { }
        private System.Boolean IsCreated() { }
        private System.Void IncrementWriteCount() { }
        private System.Boolean NeedsFallBack() { }
        private System.Void CreatePooledGraphicsResource() { }
        private System.Void CreateGraphicsResource(System.String name) { }
        private System.Void ReleasePooledGraphicsResource(System.Int32 frameIndex) { }
        private System.Void ReleaseGraphicsResource() { }
        private System.Void LogCreation(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger) { }
        private System.Void LogRelease(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger) { }
        private System.Int32 GetSortIndex() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000069
    public class RenderGraphResource`2 : IRenderGraphResource
    {
        // Fields
        public DescType desc;        // 0x0
        public ResType graphicsResource;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void Reset(UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResourcePool pool) { }
        private System.Boolean IsCreated() { }
        private System.Void ReleaseGraphicsResource() { }

    }

    // TypeToken: 0x200006A
    public struct TextureHandle
    {
        // Fields
        private static UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle s_NullHandle;        // 0x0
        private UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle handle;        // 0x10
        private UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle fallBackResource;        // 0x18

        // Methods
        private UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_nullHandle() { }
        private System.Void .ctor(System.Int32 handle, System.Boolean shared) { }
        private UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture) { }
        private UnityEngine.Texture op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture) { }
        private UnityEngine.RenderTexture op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture) { }
        private UnityEngine.Rendering.RTHandle op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture) { }
        private System.Boolean IsValid() { }
        private System.Void SetFallBackResource(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200006B
    public struct TextureSizeMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Experimental.Rendering.RenderGraphModule.TextureSizeMode Explicit;        // 0x0
        public static UnityEngine.Experimental.Rendering.RenderGraphModule.TextureSizeMode Scale;        // 0x0
        public static UnityEngine.Experimental.Rendering.RenderGraphModule.TextureSizeMode Functor;        // 0x0

    }

    // TypeToken: 0x200006C
    public struct FastMemoryDesc
    {
        // Fields
        public System.Boolean inFastMemory;        // 0x10
        public UnityEngine.Rendering.FastMemoryFlags flags;        // 0x14
        public System.Single residencyFraction;        // 0x18

    }

    // TypeToken: 0x200006D
    public struct TextureDesc
    {
        // Fields
        public System.Int32 width;        // 0x10
        public System.Int32 height;        // 0x14
        public System.Int32 slices;        // 0x18
        public UnityEngine.Rendering.DepthBits depthBufferBits;        // 0x1C
        public UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat;        // 0x20
        public UnityEngine.FilterMode filterMode;        // 0x24
        public UnityEngine.TextureWrapMode wrapMode;        // 0x28
        public UnityEngine.Rendering.TextureDimension dimension;        // 0x2C
        public System.Boolean enableRandomWrite;        // 0x30
        public System.Boolean useMipMap;        // 0x31
        public System.Boolean autoGenerateMips;        // 0x32
        public System.Boolean isShadowMap;        // 0x33
        public System.Int32 anisoLevel;        // 0x34
        public System.Single mipMapBias;        // 0x38
        public UnityEngine.Rendering.MSAASamples msaaSamples;        // 0x3C
        public System.Boolean bindTextureMS;        // 0x40
        public UnityEngine.RenderTextureMemoryless memoryless;        // 0x44
        public System.String name;        // 0x48
        public UnityEngine.Experimental.Rendering.RenderGraphModule.FastMemoryDesc fastMemoryDesc;        // 0x50
        public System.Boolean fallBackToBlackTexture;        // 0x5C
        public System.Boolean clearBuffer;        // 0x5D
        public UnityEngine.Color clearColor;        // 0x60

        // Methods
        private System.Void InitDefaultValues(System.Boolean xrReady) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, System.Boolean xrReady) { }
        private System.Void .ctor(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc input) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200006E
    public class TextureResource : RenderGraphResource`2
    {
        // Fields
        private static System.Int32 m_TextureCreationIndex;        // 0x0

        // Methods
        private System.String GetName() { }
        private System.Void CreatePooledGraphicsResource() { }
        private System.Void ReleasePooledGraphicsResource(System.Int32 frameIndex) { }
        private System.Void CreateGraphicsResource(System.String name) { }
        private System.Void ReleaseGraphicsResource() { }
        private System.Void LogCreation(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger) { }
        private System.Void LogRelease(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006F
    public class TexturePool : RenderGraphResourcePool`1
    {
        // Methods
        private System.Void ReleaseInternalResource(UnityEngine.Rendering.RTHandle res) { }
        private System.String GetResourceName(UnityEngine.Rendering.RTHandle res) { }
        private System.Int64 GetResourceSize(UnityEngine.Rendering.RTHandle res) { }
        private System.String GetResourceTypeName() { }
        private System.Int32 GetSortIndex(UnityEngine.Rendering.RTHandle res) { }
        private System.Void PurgeUnusedResources(System.Int32 currentFrameIndex) { }
        private System.Void .ctor() { }

    }

}

namespace UnityEngine.Rendering
{

    // TypeToken: 0x2000070
    public class CameraSwitcher : MonoBehaviour
    {
        // Fields
        public UnityEngine.Camera[] m_Cameras;        // 0x18
        private System.Int32 m_CurrentCameraIndex;        // 0x20
        private UnityEngine.Camera m_OriginalCamera;        // 0x28
        private UnityEngine.Vector3 m_OriginalCameraPosition;        // 0x30
        private UnityEngine.Quaternion m_OriginalCameraRotation;        // 0x3C
        private UnityEngine.Camera m_CurrentCamera;        // 0x50
        private UnityEngine.GUIContent[] m_CameraNames;        // 0x58
        private System.Int32[] m_CameraIndices;        // 0x60
        private UnityEngine.Rendering.DebugUI.EnumField m_DebugEntry;        // 0x68
        private System.Int32 m_DebugEntryEnumIndex;        // 0x70

        // Methods
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Int32 GetCameraCount() { }
        private UnityEngine.Camera GetNextCamera() { }
        private System.Void SetCameraIndex(System.Int32 index) { }
        private System.Void .ctor() { }
        private System.Int32 <OnEnable>b__10_0() { }
        private System.Void <OnEnable>b__10_1(System.Int32 value) { }
        private System.Int32 <OnEnable>b__10_2() { }
        private System.Void <OnEnable>b__10_3(System.Int32 value) { }

    }

    // TypeToken: 0x2000071
    public class FreeCamera : MonoBehaviour
    {
        // Fields
        private static System.Single k_MouseSensitivityMultiplier;        // 0x0
        public System.Single m_LookSpeedController;        // 0x18
        public System.Single m_LookSpeedMouse;        // 0x1C
        public System.Single m_MoveSpeed;        // 0x20
        public System.Single m_MoveSpeedIncrement;        // 0x24
        public System.Single m_Turbo;        // 0x28
        private UnityEngine.InputSystem.InputAction lookAction;        // 0x30
        private UnityEngine.InputSystem.InputAction moveAction;        // 0x38
        private UnityEngine.InputSystem.InputAction speedAction;        // 0x40
        private UnityEngine.InputSystem.InputAction yMoveAction;        // 0x48
        private System.Single inputRotateAxisX;        // 0x50
        private System.Single inputRotateAxisY;        // 0x54
        private System.Single inputChangeSpeed;        // 0x58
        private System.Single inputVertical;        // 0x5C
        private System.Single inputHorizontal;        // 0x60
        private System.Single inputYAxis;        // 0x64
        private System.Boolean leftShiftBoost;        // 0x68
        private System.Boolean leftShift;        // 0x69
        private System.Boolean fire1;        // 0x6A

        // Methods
        private System.Void OnEnable() { }
        private System.Void RegisterInputs() { }
        private System.Void UpdateInputs() { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000072
    public class CommandBufferPool
    {
        // Fields
        private static UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.CommandBuffer> s_BufferPool;        // 0x0

        // Methods
        private UnityEngine.Rendering.CommandBuffer Get() { }
        private UnityEngine.Rendering.CommandBuffer Get(System.String name) { }
        private System.Void Release(UnityEngine.Rendering.CommandBuffer buffer) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000074
    public struct ClearFlag
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.ClearFlag None;        // 0x0
        public static UnityEngine.Rendering.ClearFlag Color;        // 0x0
        public static UnityEngine.Rendering.ClearFlag Depth;        // 0x0
        public static UnityEngine.Rendering.ClearFlag Stencil;        // 0x0
        public static UnityEngine.Rendering.ClearFlag DepthStencil;        // 0x0
        public static UnityEngine.Rendering.ClearFlag ColorStencil;        // 0x0
        public static UnityEngine.Rendering.ClearFlag All;        // 0x0

    }

    // TypeToken: 0x2000075
    public class ComponentSingleton`1
    {
        // Fields
        private static TType s_Instance;        // 0x0

        // Methods
        private TType get_instance() { }
        private System.Void Release() { }

    }

    // TypeToken: 0x2000076
    public class ConstantBuffer
    {
        // Fields
        private static System.Collections.Generic.List<UnityEngine.Rendering.ConstantBufferBase> m_RegisteredConstantBuffers;        // 0x0

        // Methods
        private System.Void PushGlobal(UnityEngine.Rendering.CommandBuffer cmd, CBType& data, System.Int32 shaderId) { }
        private System.Void PushGlobal(CBType& data, System.Int32 shaderId) { }
        private System.Void Push(UnityEngine.Rendering.CommandBuffer cmd, CBType& data, UnityEngine.ComputeShader cs, System.Int32 shaderId) { }
        private System.Void Push(CBType& data, UnityEngine.ComputeShader cs, System.Int32 shaderId) { }
        private System.Void Push(UnityEngine.Rendering.CommandBuffer cmd, CBType& data, UnityEngine.Material mat, System.Int32 shaderId) { }
        private System.Void Push(CBType& data, UnityEngine.Material mat, System.Int32 shaderId) { }
        private System.Void UpdateData(UnityEngine.Rendering.CommandBuffer cmd, CBType& data) { }
        private System.Void UpdateData(CBType& data) { }
        private System.Void SetGlobal(UnityEngine.Rendering.CommandBuffer cmd, System.Int32 shaderId) { }
        private System.Void SetGlobal(System.Int32 shaderId) { }
        private System.Void Set(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader cs, System.Int32 shaderId) { }
        private System.Void Set(UnityEngine.ComputeShader cs, System.Int32 shaderId) { }
        private System.Void Set(UnityEngine.Material mat, System.Int32 shaderId) { }
        private System.Void ReleaseAll() { }
        private System.Void Register(UnityEngine.Rendering.ConstantBufferBase cb) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000077
    public class ConstantBufferBase
    {
        // Methods
        private System.Void Release() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000078
    public class ConstantBuffer`1 : ConstantBufferBase
    {
        // Fields
        private System.Collections.Generic.HashSet<System.Int32> m_GlobalBindings;        // 0x0
        private CBType[] m_Data;        // 0x0
        private UnityEngine.ComputeBuffer m_GPUConstantBuffer;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void UpdateData(UnityEngine.Rendering.CommandBuffer cmd, CBType& data) { }
        private System.Void UpdateData(CBType& data) { }
        private System.Void SetGlobal(UnityEngine.Rendering.CommandBuffer cmd, System.Int32 shaderId) { }
        private System.Void SetGlobal(System.Int32 shaderId) { }
        private System.Void Set(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader cs, System.Int32 shaderId) { }
        private System.Void Set(UnityEngine.ComputeShader cs, System.Int32 shaderId) { }
        private System.Void Set(UnityEngine.Material mat, System.Int32 shaderId) { }
        private System.Void PushGlobal(UnityEngine.Rendering.CommandBuffer cmd, CBType& data, System.Int32 shaderId) { }
        private System.Void PushGlobal(CBType& data, System.Int32 shaderId) { }
        private System.Void Release() { }

    }

    // TypeToken: 0x2000079
    public class ConstantBufferSingleton`1 : ConstantBuffer`1
    {
        // Fields
        private static UnityEngine.Rendering.ConstantBufferSingleton<CBType> s_Instance;        // 0x0

        // Methods
        private UnityEngine.Rendering.ConstantBufferSingleton<CBType> get_instance() { }
        private System.Void set_instance(UnityEngine.Rendering.ConstantBufferSingleton<CBType> value) { }
        private System.Void Release() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007A
    public class DisplayInfoAttribute : Attribute
    {
        // Fields
        public System.String name;        // 0x10
        public System.Int32 order;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007B
    public class AdditionalPropertyAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007C
    public struct CoreProfileId
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.CoreProfileId BlitTextureInPotAtlas;        // 0x0

    }

    // TypeToken: 0x200007D
    public class CoreUnsafeUtils
    {
        // Methods
        private System.Void CopyTo(System.Collections.Generic.List<T> list, System.Void* dest, System.Int32 count) { }
        private System.Void CopyTo(T[] list, System.Void* dest, System.Int32 count) { }
        private System.Void CalculateRadixParams(System.Int32 radixBits, System.Int32& bitStates) { }
        private System.Int32 CalculateRadixSupportSize(System.Int32 bitStates, System.Int32 arrayLength) { }
        private System.Void CalculateRadixSortSupportArrays(System.Int32 bitStates, System.Int32 arrayLength, System.UInt32* supportArray, System.UInt32*& bucketIndices, System.UInt32*& bucketSizes, System.UInt32*& bucketPrefix, System.UInt32*& arrayOutput) { }
        private System.Void MergeSort(System.UInt32* array, System.UInt32* support, System.Int32 length) { }
        private System.Void MergeSort(System.UInt32[] arr, System.Int32 sortSize, System.UInt32[]& supportArray) { }
        private System.Void MergeSort(Unity.Collections.NativeArray<System.UInt32> arr, Unity.Collections.Allocator arrAllocator, System.Int32 sortSize, Unity.Collections.NativeArray<System.UInt32>& supportArray) { }
        private System.Void InsertionSort(System.UInt32* arr, System.Int32 length) { }
        private System.Void InsertionSort(System.UInt32[] arr, System.Int32 sortSize) { }
        private System.Void InsertionSort(Unity.Collections.NativeArray<System.UInt32> arr, System.Int32 sortSize) { }
        private System.Void RadixSort(System.UInt32* array, System.UInt32* support, System.Int32 radixBits, System.Int32 bitStates, System.Int32 length) { }
        private System.Void RadixSort(System.UInt32[] arr, System.Int32 sortSize, System.UInt32[]& supportArray, System.Int32 radixBits) { }
        private System.Void RadixSort(Unity.Collections.NativeArray<System.UInt32> array, System.Int32 sortSize, Unity.Collections.NativeArray<System.UInt32>& supportArray, Unity.Collections.Allocator supportArrayAllocator, System.Int32 radixBits) { }
        private System.Void QuickSort(System.UInt32[] arr, System.Int32 left, System.Int32 right) { }
        private System.Void QuickSort(System.Int32 count, System.Void* data) { }
        private System.Void QuickSort(System.Int32 count, System.Void* data) { }
        private System.Void QuickSort(System.Void* data, System.Int32 left, System.Int32 right) { }
        private System.Int32 IndexOf(System.Void* data, System.Int32 count, T v) { }
        private System.Int32 CompareHashes(System.Int32 oldHashCount, System.Void* oldHashes, System.Int32 newHashCount, System.Void* newHashes, System.Int32* addIndices, System.Int32* removeIndices, System.Int32& addCount, System.Int32& remCount) { }
        private System.Int32 CompareHashes(System.Int32 oldHashCount, UnityEngine.Hash128* oldHashes, System.Int32 newHashCount, UnityEngine.Hash128* newHashes, System.Int32* addIndices, System.Int32* removeIndices, System.Int32& addCount, System.Int32& remCount) { }
        private System.Void CombineHashes(System.Int32 count, System.Void* hashes, UnityEngine.Hash128* outHash) { }
        private System.Void CombineHashes(System.Int32 count, UnityEngine.Hash128* hashes, UnityEngine.Hash128* outHash) { }
        private System.Int32 Partition(System.Void* data, System.Int32 left, System.Int32 right) { }
        private System.Boolean HaveDuplicates(System.Int32[] arr) { }

    }

    // TypeToken: 0x2000082
    public class DynamicArray`1
    {
        // Fields
        private T[] m_Array;        // 0x0
        private System.Int32 <size>k__BackingField;        // 0x0

        // Methods
        private System.Int32 get_size() { }
        private System.Void set_size(System.Int32 value) { }
        private System.Int32 get_capacity() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 size) { }
        private System.Void Clear() { }
        private System.Boolean Contains(T item) { }
        private System.Int32 Add(T& value) { }
        private System.Void AddRange(UnityEngine.Rendering.DynamicArray<T> array) { }
        private System.Boolean Remove(T item) { }
        private System.Void RemoveAt(System.Int32 index) { }
        private System.Void RemoveRange(System.Int32 index, System.Int32 count) { }
        private System.Int32 FindIndex(System.Int32 startIndex, System.Int32 count, System.Predicate<T> match) { }
        private System.Int32 IndexOf(T item, System.Int32 index, System.Int32 count) { }
        private System.Int32 IndexOf(T item, System.Int32 index) { }
        private System.Int32 IndexOf(T item) { }
        private System.Void Resize(System.Int32 newSize, System.Boolean keepContent) { }
        private System.Void Reserve(System.Int32 newCapacity, System.Boolean keepContent) { }
        private T& get_Item(System.Int32 index) { }
        private T[] op_Implicit(UnityEngine.Rendering.DynamicArray<T> array) { }

    }

    // TypeToken: 0x2000083
    public class DynamicArrayExtensions
    {
        // Methods
        private System.Int32 Partition(T[] data, System.Int32 left, System.Int32 right) { }
        private System.Void QuickSort(T[] data, System.Int32 left, System.Int32 right) { }
        private System.Void QuickSort(UnityEngine.Rendering.DynamicArray<T> array) { }

    }

    // TypeToken: 0x2000084
    public class PerformDynamicRes : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Single Invoke() { }
        private System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object) { }
        private System.Single EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000085
    public struct DynamicResScalePolicyType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.DynamicResScalePolicyType ReturnsPercentage;        // 0x0
        public static UnityEngine.Rendering.DynamicResScalePolicyType ReturnsMinMaxLerpFactor;        // 0x0

    }

    // TypeToken: 0x2000086
    public struct DynamicResScalerSlot
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.DynamicResScalerSlot User;        // 0x0
        public static UnityEngine.Rendering.DynamicResScalerSlot System;        // 0x0
        public static UnityEngine.Rendering.DynamicResScalerSlot Count;        // 0x0

    }

    // TypeToken: 0x2000087
    public class DynamicResolutionHandler
    {
        // Fields
        private System.Boolean m_Enabled;        // 0x10
        private System.Boolean m_UseMipBias;        // 0x11
        private System.Single m_MinScreenFraction;        // 0x14
        private System.Single m_MaxScreenFraction;        // 0x18
        private System.Single m_CurrentFraction;        // 0x1C
        private System.Boolean m_ForcingRes;        // 0x20
        private System.Boolean m_CurrentCameraRequest;        // 0x21
        private System.Single m_PrevFraction;        // 0x24
        private System.Boolean m_ForceSoftwareFallback;        // 0x28
        private System.Boolean m_RunUpscalerFilterOnFullResolution;        // 0x29
        private System.Single m_PrevHWScaleWidth;        // 0x2C
        private System.Single m_PrevHWScaleHeight;        // 0x30
        private UnityEngine.Vector2Int m_LastScaledSize;        // 0x34
        private static UnityEngine.Rendering.DynamicResScalerSlot s_ActiveScalerSlot;        // 0x0
        private static UnityEngine.Rendering.DynamicResolutionHandler.ScalerContainer[] s_ScalerContainers;        // 0x8
        private UnityEngine.Vector2Int cachedOriginalSize;        // 0x3C
        private UnityEngine.Rendering.DynamicResUpscaleFilter <filter>k__BackingField;        // 0x44
        private static System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Rendering.DynamicResUpscaleFilter> s_CameraUpscaleFilters;        // 0x10
        private UnityEngine.Vector2Int <finalViewport>k__BackingField;        // 0x48
        private UnityEngine.Rendering.DynamicResolutionType type;        // 0x50
        private UnityEngine.Rendering.GlobalDynamicResolutionSettings m_CachedSettings;        // 0x54
        private static System.Int32 CameraDictionaryMaxcCapacity;        // 0x0
        private System.WeakReference m_OwnerCameraWeakRef;        // 0x80
        private static System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Rendering.DynamicResolutionHandler> s_CameraInstances;        // 0x18
        private static UnityEngine.Rendering.DynamicResolutionHandler s_DefaultInstance;        // 0x20
        private static System.Int32 s_ActiveCameraId;        // 0x28
        private static UnityEngine.Rendering.DynamicResolutionHandler s_ActiveInstance;        // 0x30
        private static System.Boolean s_ActiveInstanceDirty;        // 0x38
        private static System.Single s_GlobalHwFraction;        // 0x3C
        private static System.Boolean s_GlobalHwUpresActive;        // 0x40
        private UnityEngine.Rendering.DynamicResolutionHandler.UpsamplerScheduleType m_UpsamplerSchedule;        // 0x88

        // Methods
        private System.Void Reset() { }
        private UnityEngine.Rendering.DynamicResUpscaleFilter get_filter() { }
        private System.Void set_filter(UnityEngine.Rendering.DynamicResUpscaleFilter value) { }
        private UnityEngine.Vector2Int get_finalViewport() { }
        private System.Void set_finalViewport(UnityEngine.Vector2Int value) { }
        private System.Void set_runUpscalerFilterOnFullResolution(System.Boolean value) { }
        private System.Boolean get_runUpscalerFilterOnFullResolution() { }
        private System.Boolean FlushScalableBufferManagerState() { }
        private UnityEngine.Rendering.DynamicResolutionHandler GetOrCreateDrsInstanceHandler(UnityEngine.Camera camera) { }
        private System.Void set_upsamplerSchedule(UnityEngine.Rendering.DynamicResolutionHandler.UpsamplerScheduleType value) { }
        private UnityEngine.Rendering.DynamicResolutionHandler.UpsamplerScheduleType get_upsamplerSchedule() { }
        private UnityEngine.Rendering.DynamicResolutionHandler get_instance() { }
        private System.Void .ctor() { }
        private System.Single DefaultDynamicResMethod() { }
        private System.Void ProcessSettings(UnityEngine.Rendering.GlobalDynamicResolutionSettings settings) { }
        private UnityEngine.Vector2 GetResolvedScale() { }
        private System.Single CalculateMipBias(UnityEngine.Vector2Int inputResolution, UnityEngine.Vector2Int outputResolution, System.Boolean forceApply) { }
        private System.Void SetDynamicResScaler(UnityEngine.Rendering.PerformDynamicRes scaler, UnityEngine.Rendering.DynamicResScalePolicyType scalerType) { }
        private System.Void SetSystemDynamicResScaler(UnityEngine.Rendering.PerformDynamicRes scaler, UnityEngine.Rendering.DynamicResScalePolicyType scalerType) { }
        private System.Void SetActiveDynamicScalerSlot(UnityEngine.Rendering.DynamicResScalerSlot slot) { }
        private System.Void ClearSelectedCamera() { }
        private System.Void SetUpscaleFilter(UnityEngine.Camera camera, UnityEngine.Rendering.DynamicResUpscaleFilter filter) { }
        private System.Void SetCurrentCameraRequest(System.Boolean cameraRequest) { }
        private System.Void UpdateAndUseCamera(UnityEngine.Camera camera, System.Nullable<UnityEngine.Rendering.GlobalDynamicResolutionSettings> settings, System.Action OnResolutionChange) { }
        private System.Void Update(UnityEngine.Rendering.GlobalDynamicResolutionSettings settings, System.Action OnResolutionChange) { }
        private System.Boolean SoftwareDynamicResIsEnabled() { }
        private System.Boolean HardwareDynamicResIsEnabled() { }
        private System.Boolean RequestsHardwareDynamicResolution() { }
        private System.Boolean DynamicResolutionEnabled() { }
        private System.Void ForceSoftwareFallback() { }
        private UnityEngine.Vector2Int GetScaledSize(UnityEngine.Vector2Int size) { }
        private UnityEngine.Vector2Int ApplyScalesOnSize(UnityEngine.Vector2Int size) { }
        private UnityEngine.Vector2Int ApplyScalesOnSize(UnityEngine.Vector2Int size, UnityEngine.Vector2 scales) { }
        private System.Single GetCurrentScale() { }
        private UnityEngine.Vector2Int GetLastScaledSize() { }
        private System.Single GetLowResMultiplier(System.Single targetLowRes) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200008A
    public struct DynamicResolutionType
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static UnityEngine.Rendering.DynamicResolutionType Software;        // 0x0
        public static UnityEngine.Rendering.DynamicResolutionType Hardware;        // 0x0

    }

    // TypeToken: 0x200008B
    public struct DynamicResUpscaleFilter
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static UnityEngine.Rendering.DynamicResUpscaleFilter Bilinear;        // 0x0
        public static UnityEngine.Rendering.DynamicResUpscaleFilter CatmullRom;        // 0x0
        public static UnityEngine.Rendering.DynamicResUpscaleFilter Lanczos;        // 0x0
        public static UnityEngine.Rendering.DynamicResUpscaleFilter ContrastAdaptiveSharpen;        // 0x0
        public static UnityEngine.Rendering.DynamicResUpscaleFilter EdgeAdaptiveScalingUpres;        // 0x0
        public static UnityEngine.Rendering.DynamicResUpscaleFilter TAAU;        // 0x0

    }

    // TypeToken: 0x200008C
    public struct GlobalDynamicResolutionSettings
    {
        // Fields
        public System.Boolean enabled;        // 0x10
        public System.Boolean useMipBias;        // 0x11
        public System.Boolean enableDLSS;        // 0x12
        public System.UInt32 DLSSPerfQualitySetting;        // 0x14
        public System.Boolean DLSSUseOptimalSettings;        // 0x18
        public System.Single DLSSSharpness;        // 0x1C
        public System.Single maxPercentage;        // 0x20
        public System.Single minPercentage;        // 0x24
        public UnityEngine.Rendering.DynamicResolutionType dynResType;        // 0x28
        public UnityEngine.Rendering.DynamicResUpscaleFilter upsampleFilter;        // 0x29
        public System.Boolean forceResolution;        // 0x2A
        public System.Single forcedPercentage;        // 0x2C
        public System.Single lowResTransparencyMinimumThreshold;        // 0x30
        public System.Single rayTracingHalfResThreshold;        // 0x34

        // Methods
        private UnityEngine.Rendering.GlobalDynamicResolutionSettings NewDefault() { }

    }

    // TypeToken: 0x200008D
    public interface IAdditionalData
    {
    }

    // TypeToken: 0x200008E
    public interface IVirtualTexturingEnabledRenderPipeline
    {
        // Methods
        private System.Boolean get_virtualTexturingEnabled() { }

    }

    // TypeToken: 0x200008F
    public struct ListBuffer`1
    {
        // Fields
        private T* m_BufferPtr;        // 0x0
        private System.Int32 m_Capacity;        // 0x0
        private System.Int32* m_CountPtr;        // 0x0

        // Methods
        private T* get_BufferPtr() { }
        private System.Int32 get_Count() { }
        private System.Int32 get_Capacity() { }
        private System.Void .ctor(T* bufferPtr, System.Int32* countPtr, System.Int32 capacity) { }
        private T& get_Item(System.Int32& index) { }
        private T& GetUnchecked(System.Int32& index) { }
        private System.Boolean TryAdd(T& value) { }
        private System.Void CopyTo(T* dstBuffer, System.Int32 startDstIndex, System.Int32 copyCount) { }
        private System.Boolean TryCopyTo(UnityEngine.Rendering.ListBuffer<T> other) { }
        private System.Boolean TryCopyFrom(T* srcPtr, System.Int32 count) { }

    }

    // TypeToken: 0x2000090
    public class ListBufferExtensions
    {
        // Methods
        private System.Void QuickSort(UnityEngine.Rendering.ListBuffer<T> self) { }

    }

    // TypeToken: 0x2000091
    public class ObjectPool`1
    {
        // Fields
        private readonly System.Collections.Generic.Stack<T> m_Stack;        // 0x0
        private readonly UnityEngine.Events.UnityAction<T> m_ActionOnGet;        // 0x0
        private readonly UnityEngine.Events.UnityAction<T> m_ActionOnRelease;        // 0x0
        private readonly System.Boolean m_CollectionCheck;        // 0x0
        private System.Int32 <countAll>k__BackingField;        // 0x0

        // Methods
        private System.Int32 get_countAll() { }
        private System.Void set_countAll(System.Int32 value) { }
        private System.Int32 get_countActive() { }
        private System.Int32 get_countInactive() { }
        private System.Void .ctor(UnityEngine.Events.UnityAction<T> actionOnGet, UnityEngine.Events.UnityAction<T> actionOnRelease, System.Boolean collectionCheck) { }
        private T Get() { }
        private UnityEngine.Rendering.ObjectPool.PooledObject<T> Get(T& v) { }
        private System.Void Release(T element) { }

    }

    // TypeToken: 0x2000093
    public class GenericPool`1
    {
        // Fields
        private static readonly UnityEngine.Rendering.ObjectPool<T> s_Pool;        // 0x0

        // Methods
        private T Get() { }
        private UnityEngine.Rendering.ObjectPool.PooledObject<T> Get(T& value) { }
        private System.Void Release(T toRelease) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000094
    public class UnsafeGenericPool`1
    {
        // Fields
        private static readonly UnityEngine.Rendering.ObjectPool<T> s_Pool;        // 0x0

        // Methods
        private T Get() { }
        private UnityEngine.Rendering.ObjectPool.PooledObject<T> Get(T& value) { }
        private System.Void Release(T toRelease) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000095
    public class ListPool`1
    {
        // Fields
        private static readonly UnityEngine.Rendering.ObjectPool<System.Collections.Generic.List<T>> s_Pool;        // 0x0

        // Methods
        private System.Collections.Generic.List<T> Get() { }
        private UnityEngine.Rendering.ObjectPool.PooledObject<System.Collections.Generic.List<T>> Get(System.Collections.Generic.List<T>& value) { }
        private System.Void Release(System.Collections.Generic.List<T> toRelease) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000097
    public class HashSetPool`1
    {
        // Fields
        private static readonly UnityEngine.Rendering.ObjectPool<System.Collections.Generic.HashSet<T>> s_Pool;        // 0x0

        // Methods
        private System.Collections.Generic.HashSet<T> Get() { }
        private UnityEngine.Rendering.ObjectPool.PooledObject<System.Collections.Generic.HashSet<T>> Get(System.Collections.Generic.HashSet<T>& value) { }
        private System.Void Release(System.Collections.Generic.HashSet<T> toRelease) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000099
    public class DictionaryPool`2
    {
        // Fields
        private static readonly UnityEngine.Rendering.ObjectPool<System.Collections.Generic.Dictionary<TKey,TValue>> s_Pool;        // 0x0

        // Methods
        private System.Collections.Generic.Dictionary<TKey,TValue> Get() { }
        private UnityEngine.Rendering.ObjectPool.PooledObject<System.Collections.Generic.Dictionary<TKey,TValue>> Get(System.Collections.Generic.Dictionary<TKey,TValue>& value) { }
        private System.Void Release(System.Collections.Generic.Dictionary<TKey,TValue> toRelease) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200009B
    public class ListChangedEventArgs`1 : EventArgs
    {
        // Fields
        public readonly System.Int32 index;        // 0x0
        public readonly T item;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 index, T item) { }

    }

    // TypeToken: 0x200009C
    public class ListChangedEventHandler`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Rendering.ObservableList<T> sender, UnityEngine.Rendering.ListChangedEventArgs<T> e) { }
        private System.IAsyncResult BeginInvoke(UnityEngine.Rendering.ObservableList<T> sender, UnityEngine.Rendering.ListChangedEventArgs<T> e, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200009D
    public class ObservableList`1, IList`1, ICollection`1, IEnumerable`1, IEnumerable
    {
        // Fields
        private System.Collections.Generic.IList<T> m_List;        // 0x0
        private UnityEngine.Rendering.ListChangedEventHandler<T> ItemAdded;        // 0x0
        private UnityEngine.Rendering.ListChangedEventHandler<T> ItemRemoved;        // 0x0

        // Methods
        private System.Void add_ItemAdded(UnityEngine.Rendering.ListChangedEventHandler<T> value) { }
        private System.Void remove_ItemAdded(UnityEngine.Rendering.ListChangedEventHandler<T> value) { }
        private System.Void add_ItemRemoved(UnityEngine.Rendering.ListChangedEventHandler<T> value) { }
        private System.Void remove_ItemRemoved(UnityEngine.Rendering.ListChangedEventHandler<T> value) { }
        private T get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, T value) { }
        private System.Int32 get_Count() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 capacity) { }
        private System.Void .ctor(System.Collections.Generic.IEnumerable<T> collection) { }
        private System.Void OnEvent(UnityEngine.Rendering.ListChangedEventHandler<T> e, System.Int32 index, T item) { }
        private System.Boolean Contains(T item) { }
        private System.Int32 IndexOf(T item) { }
        private System.Void Add(T item) { }
        private System.Void Add(T[] items) { }
        private System.Void Insert(System.Int32 index, T item) { }
        private System.Boolean Remove(T item) { }
        private System.Int32 Remove(T[] items) { }
        private System.Void RemoveAt(System.Int32 index) { }
        private System.Void Clear() { }
        private System.Void CopyTo(T[] array, System.Int32 arrayIndex) { }
        private System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x200009E
    public class SerializableEnum
    {
        // Fields
        private System.String m_EnumValueAsString;        // 0x10
        private System.Type m_EnumType;        // 0x18

        // Methods
        private System.Enum get_value() { }
        private System.Void set_value(System.Enum value) { }
        private System.Void .ctor(System.Type enumType) { }

    }

    // TypeToken: 0x200009F
    public class SerializedDictionary`2 : SerializedDictionary`4
    {
        // Methods
        private K SerializeKey(K key) { }
        private V SerializeValue(V val) { }
        private K DeserializeKey(K key) { }
        private V DeserializeValue(V val) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A0
    public class SerializedDictionary`4 : Dictionary`2, ISerializationCallbackReceiver
    {
        // Fields
        private System.Collections.Generic.List<SK> m_Keys;        // 0x0
        private System.Collections.Generic.List<SV> m_Values;        // 0x0

        // Methods
        private SK SerializeKey(K key) { }
        private SV SerializeValue(V value) { }
        private K DeserializeKey(SK serializedKey) { }
        private V DeserializeValue(SV serializedValue) { }
        private System.Void OnBeforeSerialize() { }
        private System.Void OnAfterDeserialize() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A1
    public class XRGraphics
    {
        // Methods
        private System.Single get_eyeTextureResolutionScale() { }
        private System.Void set_eyeTextureResolutionScale(System.Single value) { }
        private System.Single get_renderViewportScale() { }
        private System.Boolean get_enabled() { }
        private System.Boolean get_isDeviceActive() { }
        private System.String get_loadedDeviceName() { }
        private System.String[] get_supportedDevices() { }
        private UnityEngine.Rendering.XRGraphics.StereoRenderingMode get_stereoRenderingMode() { }
        private UnityEngine.RenderTextureDescriptor get_eyeTextureDesc() { }
        private System.Int32 get_eyeTextureWidth() { }
        private System.Int32 get_eyeTextureHeight() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A3
    public struct DebugAction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.DebugAction EnableDebugMenu;        // 0x0
        public static UnityEngine.Rendering.DebugAction PreviousDebugPanel;        // 0x0
        public static UnityEngine.Rendering.DebugAction NextDebugPanel;        // 0x0
        public static UnityEngine.Rendering.DebugAction Action;        // 0x0
        public static UnityEngine.Rendering.DebugAction MakePersistent;        // 0x0
        public static UnityEngine.Rendering.DebugAction MoveVertical;        // 0x0
        public static UnityEngine.Rendering.DebugAction MoveHorizontal;        // 0x0
        public static UnityEngine.Rendering.DebugAction Multiplier;        // 0x0
        public static UnityEngine.Rendering.DebugAction ResetAll;        // 0x0
        public static UnityEngine.Rendering.DebugAction DebugActionCount;        // 0x0

    }

    // TypeToken: 0x20000A4
    public struct DebugActionRepeatMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.DebugActionRepeatMode Never;        // 0x0
        public static UnityEngine.Rendering.DebugActionRepeatMode Delay;        // 0x0

    }

    // TypeToken: 0x20000A5
    public class DebugManager
    {
        // Fields
        private static System.String kEnableDebugBtn1;        // 0x0
        private static System.String kEnableDebugBtn2;        // 0x0
        private static System.String kDebugPreviousBtn;        // 0x0
        private static System.String kDebugNextBtn;        // 0x0
        private static System.String kValidateBtn;        // 0x0
        private static System.String kPersistentBtn;        // 0x0
        private static System.String kDPadVertical;        // 0x0
        private static System.String kDPadHorizontal;        // 0x0
        private static System.String kMultiplierBtn;        // 0x0
        private static System.String kResetBtn;        // 0x0
        private static System.String kEnableDebug;        // 0x0
        private UnityEngine.Rendering.DebugActionDesc[] m_DebugActions;        // 0x10
        private UnityEngine.Rendering.DebugActionState[] m_DebugActionStates;        // 0x18
        private UnityEngine.InputSystem.InputActionMap debugActionMap;        // 0x20
        private static readonly System.Lazy<UnityEngine.Rendering.DebugManager> s_Instance;        // 0x0
        private System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.DebugUI.Panel> m_ReadOnlyPanels;        // 0x28
        private readonly System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Panel> m_Panels;        // 0x30
        private System.Action<System.Boolean> onDisplayRuntimeUIChanged;        // 0x38
        private System.Action onSetDirty;        // 0x40
        private System.Action resetData;        // 0x48
        public System.Boolean refreshEditorRequested;        // 0x50
        private System.Nullable<System.Int32> m_RequestedPanelIndex;        // 0x54
        private UnityEngine.GameObject m_Root;        // 0x60
        private UnityEngine.Rendering.UI.DebugUIHandlerCanvas m_RootUICanvas;        // 0x68
        private UnityEngine.GameObject m_PersistentRoot;        // 0x70
        private UnityEngine.Rendering.UI.DebugUIHandlerPersistentCanvas m_RootUIPersistentCanvas;        // 0x78
        private System.Boolean m_EditorOpen;        // 0x80
        private System.Boolean m_EnableRuntimeUI;        // 0x81

        // Methods
        private System.Void RegisterActions() { }
        private System.Void EnableInputActions() { }
        private System.Void AddAction(UnityEngine.Rendering.DebugAction action, UnityEngine.Rendering.DebugActionDesc desc) { }
        private System.Void SampleAction(System.Int32 actionIndex) { }
        private System.Void UpdateAction(System.Int32 actionIndex) { }
        private System.Void UpdateActions() { }
        private System.Single GetAction(UnityEngine.Rendering.DebugAction action) { }
        private System.Boolean GetActionToggleDebugMenuWithTouch() { }
        private System.Boolean GetActionReleaseScrollTarget() { }
        private System.Void RegisterInputs() { }
        private UnityEngine.Rendering.DebugManager get_instance() { }
        private System.Void UpdateReadOnlyCollection() { }
        private System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.DebugUI.Panel> get_panels() { }
        private System.Void add_onDisplayRuntimeUIChanged(System.Action<System.Boolean> value) { }
        private System.Void remove_onDisplayRuntimeUIChanged(System.Action<System.Boolean> value) { }
        private System.Void add_onSetDirty(System.Action value) { }
        private System.Void remove_onSetDirty(System.Action value) { }
        private System.Void add_resetData(System.Action value) { }
        private System.Void remove_resetData(System.Action value) { }
        private System.Boolean get_displayEditorUI() { }
        private System.Void ToggleEditorUI(System.Boolean open) { }
        private System.Boolean get_enableRuntimeUI() { }
        private System.Void set_enableRuntimeUI(System.Boolean value) { }
        private System.Boolean get_displayRuntimeUI() { }
        private System.Void set_displayRuntimeUI(System.Boolean value) { }
        private System.Boolean get_displayPersistentRuntimeUI() { }
        private System.Void set_displayPersistentRuntimeUI(System.Boolean value) { }
        private System.Void .ctor() { }
        private System.Void RefreshEditor() { }
        private System.Void Reset() { }
        private System.Void ReDrawOnScreenDebug() { }
        private System.Void RegisterData(UnityEngine.Rendering.IDebugData data) { }
        private System.Void UnregisterData(UnityEngine.Rendering.IDebugData data) { }
        private System.Int32 GetState() { }
        private System.Void RegisterRootCanvas(UnityEngine.Rendering.UI.DebugUIHandlerCanvas root) { }
        private System.Void ChangeSelection(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget, System.Boolean fromNext) { }
        private System.Void SetScrollTarget(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget) { }
        private System.Void EnsurePersistentCanvas() { }
        private System.Void TogglePersistent(UnityEngine.Rendering.DebugUI.Widget widget) { }
        private System.Void OnPanelDirty(UnityEngine.Rendering.DebugUI.Panel panel) { }
        private System.Void RequestEditorWindowPanelIndex(System.Int32 index) { }
        private System.Nullable<System.Int32> GetRequestedEditorWindowPanelIndex() { }
        private UnityEngine.Rendering.DebugUI.Panel GetPanel(System.String displayName, System.Boolean createIfNull, System.Int32 groupIndex, System.Boolean overrideIfExist) { }
        private System.Void RemovePanel(System.String displayName) { }
        private System.Void RemovePanel(UnityEngine.Rendering.DebugUI.Panel panel) { }
        private UnityEngine.Rendering.DebugUI.Widget GetItem(System.String queryPath) { }
        private UnityEngine.Rendering.DebugUI.Widget GetItem(System.String queryPath, UnityEngine.Rendering.DebugUI.IContainer container) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000A7
    public class DebugActionDesc
    {
        // Fields
        public UnityEngine.InputSystem.InputAction buttonAction;        // 0x10
        public UnityEngine.Rendering.DebugActionRepeatMode repeatMode;        // 0x18
        public System.Single repeatDelay;        // 0x1C

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A8
    public class DebugActionState
    {
        // Fields
        private UnityEngine.Rendering.DebugActionState.DebugActionKeyType m_Type;        // 0x10
        private UnityEngine.InputSystem.InputAction inputAction;        // 0x18
        private System.Boolean[] m_TriggerPressedUp;        // 0x20
        private System.Single m_Timer;        // 0x28
        private System.Boolean <runningAction>k__BackingField;        // 0x2C
        private System.Single <actionState>k__BackingField;        // 0x30

        // Methods
        private System.Boolean get_runningAction() { }
        private System.Void set_runningAction(System.Boolean value) { }
        private System.Single get_actionState() { }
        private System.Void set_actionState(System.Single value) { }
        private System.Void Trigger(System.Int32 triggerCount, System.Single state) { }
        private System.Void TriggerWithButton(UnityEngine.InputSystem.InputAction action, System.Single state) { }
        private System.Void Reset() { }
        private System.Void Update(UnityEngine.Rendering.DebugActionDesc desc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000AA
    public interface IDebugData
    {
        // Methods
        private System.Action GetReset() { }

    }

    // TypeToken: 0x20000AB
    public class DebugShapes
    {
        // Fields
        private static UnityEngine.Rendering.DebugShapes s_Instance;        // 0x0
        private UnityEngine.Mesh m_sphereMesh;        // 0x10
        private UnityEngine.Mesh m_boxMesh;        // 0x18
        private UnityEngine.Mesh m_coneMesh;        // 0x20
        private UnityEngine.Mesh m_pyramidMesh;        // 0x28

        // Methods
        private UnityEngine.Rendering.DebugShapes get_instance() { }
        private System.Void BuildSphere(UnityEngine.Mesh& outputMesh, System.Single radius, System.UInt32 longSubdiv, System.UInt32 latSubdiv) { }
        private System.Void BuildBox(UnityEngine.Mesh& outputMesh, System.Single length, System.Single width, System.Single height) { }
        private System.Void BuildCone(UnityEngine.Mesh& outputMesh, System.Single height, System.Single topRadius, System.Single bottomRadius, System.Int32 nbSides) { }
        private System.Void BuildPyramid(UnityEngine.Mesh& outputMesh, System.Single width, System.Single height, System.Single depth) { }
        private System.Void BuildShapes() { }
        private System.Void RebuildResources() { }
        private UnityEngine.Mesh RequestSphereMesh() { }
        private UnityEngine.Mesh RequestBoxMesh() { }
        private UnityEngine.Mesh RequestConeMesh() { }
        private UnityEngine.Mesh RequestPyramidMesh() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000AC
    public class DebugUI
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CF
    public class DebugUpdater : MonoBehaviour
    {
        // Fields
        private static UnityEngine.Rendering.DebugUpdater s_Instance;        // 0x0
        private UnityEngine.ScreenOrientation m_Orientation;        // 0x18
        private System.Boolean m_RuntimeUiWasVisibleLastFrame;        // 0x1C

        // Methods
        private System.Void RuntimeInit() { }
        private System.Void SetEnabled(System.Boolean enabled) { }
        private System.Void EnableRuntime() { }
        private System.Void DisableRuntime() { }
        private System.Void HandleInternalEventSystemComponents(System.Boolean uiEnabled) { }
        private System.Void EnsureExactlyOneEventSystem() { }
        private System.Collections.IEnumerator DoAfterInputModuleUpdated(System.Action action) { }
        private System.Void CheckInputModuleExists() { }
        private System.Void AssignDefaultActions() { }
        private System.Void CreateDebugEventSystem() { }
        private System.Void DestroyDebugEventSystem() { }
        private System.Void Update() { }
        private System.Collections.IEnumerator RefreshRuntimeUINextFrame() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D2
    public class MousePositionDebug
    {
        // Fields
        private static UnityEngine.Rendering.MousePositionDebug s_Instance;        // 0x0

        // Methods
        private UnityEngine.Rendering.MousePositionDebug get_instance() { }
        private System.Void Build() { }
        private System.Void Cleanup() { }
        private UnityEngine.Vector2 GetMousePosition(System.Single ScreenHeight, System.Boolean sceneView) { }
        private UnityEngine.Vector2 GetInputMousePosition() { }
        private UnityEngine.Vector2 GetMouseClickPosition(System.Single ScreenHeight) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D3
    public class TProfilingSampler`1 : ProfilingSampler
    {
        // Fields
        private static System.Collections.Generic.Dictionary<TEnum,UnityEngine.Rendering.TProfilingSampler<TEnum>> samples;        // 0x0

        // Methods
        private System.Void .cctor() { }
        private System.Void .ctor(System.String name) { }

    }

    // TypeToken: 0x20000D4
    public class ProfilingSampler
    {
        // Fields
        private UnityEngine.Profiling.CustomSampler <sampler>k__BackingField;        // 0x10
        private UnityEngine.Profiling.CustomSampler <inlineSampler>k__BackingField;        // 0x18
        private System.String <name>k__BackingField;        // 0x20
        private UnityEngine.Profiling.Recorder m_Recorder;        // 0x28
        private UnityEngine.Profiling.Recorder m_InlineRecorder;        // 0x30

        // Methods
        private UnityEngine.Rendering.ProfilingSampler Get(TEnum marker) { }
        private System.Void .ctor(System.String name) { }
        private System.Void Begin(UnityEngine.Rendering.CommandBuffer cmd) { }
        private System.Void End(UnityEngine.Rendering.CommandBuffer cmd) { }
        private System.Boolean IsValid() { }
        private UnityEngine.Profiling.CustomSampler get_sampler() { }
        private System.Void set_sampler(UnityEngine.Profiling.CustomSampler value) { }
        private UnityEngine.Profiling.CustomSampler get_inlineSampler() { }
        private System.Void set_inlineSampler(UnityEngine.Profiling.CustomSampler value) { }
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private System.Void set_enableRecording(System.Boolean value) { }
        private System.Single get_gpuElapsedTime() { }
        private System.Int32 get_gpuSampleCount() { }
        private System.Single get_cpuElapsedTime() { }
        private System.Int32 get_cpuSampleCount() { }
        private System.Single get_inlineCpuElapsedTime() { }
        private System.Int32 get_inlineCpuSampleCount() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D5
    public struct ProfilingScope, IDisposable
    {
        // Methods
        private System.Void .ctor(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ProfilingSampler sampler) { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x20000D6
    public struct ProfilingSample, IDisposable
    {
        // Fields
        private readonly UnityEngine.Rendering.CommandBuffer m_Cmd;        // 0x10
        private readonly System.String m_Name;        // 0x18
        private System.Boolean m_Disposed;        // 0x20
        private UnityEngine.Profiling.CustomSampler m_Sampler;        // 0x28

        // Methods
        private System.Void .ctor(UnityEngine.Rendering.CommandBuffer cmd, System.String name, UnityEngine.Profiling.CustomSampler sampler) { }
        private System.Void .ctor(UnityEngine.Rendering.CommandBuffer cmd, System.String format, System.Object arg) { }
        private System.Void .ctor(UnityEngine.Rendering.CommandBuffer cmd, System.String format, System.Object[] args) { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }

    }

    // TypeToken: 0x20000D7
    public class CoreRPHelpURLAttribute : HelpURLAttribute
    {
        // Methods
        private System.Void .ctor(System.String pageName, System.String packageName) { }

    }

    // TypeToken: 0x20000D8
    public class DocumentationInfo
    {
        // Fields
        private static System.String fallbackVersion;        // 0x0
        private static System.String url;        // 0x0

        // Methods
        private System.String get_version() { }
        private System.String GetPageLink(System.String packageName, System.String pageName) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D9
    public class DocumentationUtils
    {
        // Methods
        private System.String GetHelpURL(TEnum mask) { }

    }

    // TypeToken: 0x20000DA
    public struct APVConstantBufferRegister
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.APVConstantBufferRegister GlobalRegister;        // 0x0

    }

    // TypeToken: 0x20000DB
    public struct ShaderVariablesProbeVolumes
    {
        // Fields
        public UnityEngine.Vector3 _PoolDim;        // 0x10
        public System.Single _ViewBias;        // 0x1C
        public UnityEngine.Vector3 _MinCellPosition;        // 0x20
        public System.Single _PVSamplingNoise;        // 0x2C
        public UnityEngine.Vector3 _CellIndicesDim;        // 0x30
        public System.Single _CellInMeters;        // 0x3C
        public System.Single _CellInMinBricks;        // 0x40
        public System.Single _MinBrickSize;        // 0x44
        public System.Int32 _IndexChunkSize;        // 0x48
        public System.Single _NormalBias;        // 0x4C

    }

    // TypeToken: 0x20000DC
    public struct SphericalHarmonicsL1
    {
        // Fields
        public UnityEngine.Vector4 shAr;        // 0x10
        public UnityEngine.Vector4 shAg;        // 0x20
        public UnityEngine.Vector4 shAb;        // 0x30
        public static readonly UnityEngine.Rendering.SphericalHarmonicsL1 zero;        // 0x0

        // Methods
        private UnityEngine.Rendering.SphericalHarmonicsL1 op_Addition(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, UnityEngine.Rendering.SphericalHarmonicsL1 rhs) { }
        private UnityEngine.Rendering.SphericalHarmonicsL1 op_Subtraction(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, UnityEngine.Rendering.SphericalHarmonicsL1 rhs) { }
        private UnityEngine.Rendering.SphericalHarmonicsL1 op_Multiply(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, System.Single rhs) { }
        private UnityEngine.Rendering.SphericalHarmonicsL1 op_Division(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, System.Single rhs) { }
        private System.Boolean op_Equality(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, UnityEngine.Rendering.SphericalHarmonicsL1 rhs) { }
        private System.Boolean op_Inequality(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, UnityEngine.Rendering.SphericalHarmonicsL1 rhs) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Int32 GetHashCode() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000DD
    public class SphericalHarmonicsL2Utils
    {
        // Methods
        private System.Void GetL1(UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector3& L1_R, UnityEngine.Vector3& L1_G, UnityEngine.Vector3& L1_B) { }
        private System.Void GetL2(UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector3& L2_0, UnityEngine.Vector3& L2_1, UnityEngine.Vector3& L2_2, UnityEngine.Vector3& L2_3, UnityEngine.Vector3& L2_4) { }
        private System.Void SetL0(UnityEngine.Rendering.SphericalHarmonicsL2& sh, UnityEngine.Vector3 L0) { }
        private System.Void SetL1R(UnityEngine.Rendering.SphericalHarmonicsL2& sh, UnityEngine.Vector3 L1_R) { }
        private System.Void SetL1G(UnityEngine.Rendering.SphericalHarmonicsL2& sh, UnityEngine.Vector3 L1_G) { }
        private System.Void SetL1B(UnityEngine.Rendering.SphericalHarmonicsL2& sh, UnityEngine.Vector3 L1_B) { }
        private System.Void SetL1(UnityEngine.Rendering.SphericalHarmonicsL2& sh, UnityEngine.Vector3 L1_R, UnityEngine.Vector3 L1_G, UnityEngine.Vector3 L1_B) { }
        private System.Void SetCoefficient(UnityEngine.Rendering.SphericalHarmonicsL2& sh, System.Int32 index, UnityEngine.Vector3 coefficient) { }
        private UnityEngine.Vector3 GetCoefficient(UnityEngine.Rendering.SphericalHarmonicsL2 sh, System.Int32 index) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DE
    public class LensFlareCommonSRP
    {
        // Fields
        private static UnityEngine.Rendering.LensFlareCommonSRP m_Instance;        // 0x0
        private static readonly System.Object m_Padlock;        // 0x8
        private static System.Collections.Generic.List<UnityEngine.Rendering.LensFlareComponentSRP> m_Data;        // 0x10
        public static System.Int32 maxLensFlareWithOcclusion;        // 0x18
        public static System.Int32 maxLensFlareWithOcclusionTemporalSample;        // 0x1C
        public static System.Int32 mergeNeeded;        // 0x20
        public static UnityEngine.Rendering.RTHandle occlusionRT;        // 0x28
        private static System.Int32 frameIdx;        // 0x30

        // Methods
        private System.Void .ctor() { }
        private System.Void Initialize() { }
        private System.Void Dispose() { }
        private UnityEngine.Rendering.LensFlareCommonSRP get_Instance() { }
        private System.Collections.Generic.List<UnityEngine.Rendering.LensFlareComponentSRP> get_Data() { }
        private System.Collections.Generic.List<UnityEngine.Rendering.LensFlareComponentSRP> GetData() { }
        private System.Boolean IsEmpty() { }
        private System.Void AddData(UnityEngine.Rendering.LensFlareComponentSRP newData) { }
        private System.Single ShapeAttenuationPointLight() { }
        private System.Single ShapeAttenuationDirLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo) { }
        private System.Single ShapeAttenuationSpotConeLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo, System.Single spotAngle, System.Single innerSpotPercent01) { }
        private System.Single ShapeAttenuationSpotBoxLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo) { }
        private System.Single ShapeAttenuationSpotPyramidLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo) { }
        private System.Single ShapeAttenuationAreaTubeLight(UnityEngine.Vector3 lightPositionWS, UnityEngine.Vector3 lightSide, System.Single lightWidth, UnityEngine.Camera cam) { }
        private System.Single ShapeAttenuationAreaRectangleLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo) { }
        private System.Single ShapeAttenuationAreaDiscLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo) { }
        private UnityEngine.Vector4 GetFlareData0(UnityEngine.Vector2 screenPos, UnityEngine.Vector2 translationScale, UnityEngine.Vector2 rayOff0, UnityEngine.Vector2 vLocalScreenRatio, System.Single angleDeg, System.Single position, System.Single angularOffset, UnityEngine.Vector2 positionOffset, System.Boolean autoRotate) { }
        private UnityEngine.Vector2 GetLensFlareRayOffset(UnityEngine.Vector2 screenPos, System.Single position, System.Single globalCos0, System.Single globalSin0) { }
        private UnityEngine.Vector3 WorldToViewport(UnityEngine.Camera camera, System.Boolean isLocalLight, System.Boolean isCameraRelative, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Vector3 positionWS) { }
        private UnityEngine.Vector3 WorldToViewportLocal(System.Boolean isCameraRelative, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Vector3 cameraPosWS, UnityEngine.Vector3 positionWS) { }
        private UnityEngine.Vector3 WorldToViewportDistance(UnityEngine.Camera cam, UnityEngine.Vector3 positionWS) { }
        private System.Void ComputeOcclusion(UnityEngine.Material lensFlareShader, UnityEngine.Rendering.LensFlareCommonSRP lensFlares, UnityEngine.Camera cam, System.Single actualWidth, System.Single actualHeight, System.Boolean usePanini, System.Single paniniDistance, System.Single paniniCropToFit, System.Boolean isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.CommandBuffer cmd, System.Boolean taaEnabled, System.Int32 _FlareOcclusionTex, System.Int32 _FlareOcclusionIndex, System.Int32 _FlareTex, System.Int32 _FlareColorValue, System.Int32 _FlareData0, System.Int32 _FlareData1, System.Int32 _FlareData2, System.Int32 _FlareData3, System.Int32 _FlareData4) { }
        private System.Void DoLensFlareDataDrivenCommon(UnityEngine.Material lensFlareShader, UnityEngine.Rendering.LensFlareCommonSRP lensFlares, UnityEngine.Camera cam, System.Single actualWidth, System.Single actualHeight, System.Boolean usePanini, System.Single paniniDistance, System.Single paniniCropToFit, System.Boolean isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, System.Func<UnityEngine.Light,UnityEngine.Camera,UnityEngine.Vector3,System.Single> GetLensFlareLightAttenuation, System.Int32 _FlareOcclusionTex, System.Int32 _FlareOcclusionIndex, System.Int32 _FlareTex, System.Int32 _FlareColorValue, System.Int32 _FlareData0, System.Int32 _FlareData1, System.Int32 _FlareData2, System.Int32 _FlareData3, System.Int32 _FlareData4, System.Boolean debugFullScreen, UnityEngine.ComputeBuffer debugFullscreenBuffer, UnityEngine.Rendering.LensFlareCommonSRP.SunSourceDirLightOverrideInfo dirLightOverrideInfo) { }
        private System.Void RemoveData(UnityEngine.Rendering.LensFlareComponentSRP data) { }
        private UnityEngine.Vector2 DoPaniniProjection(UnityEngine.Vector2 screenPos, System.Single actualWidth, System.Single actualHeight, System.Single fieldOfView, System.Single paniniProjectionCropToFit, System.Single paniniProjectionDistance) { }
        private UnityEngine.Vector2 CalcViewExtents(System.Single actualWidth, System.Single actualHeight, System.Single fieldOfView) { }
        private UnityEngine.Vector2 CalcCropExtents(System.Single actualWidth, System.Single actualHeight, System.Single fieldOfView, System.Single d) { }
        private UnityEngine.Vector2 Panini_Generic_Inv(UnityEngine.Vector2 projPos, System.Single d) { }
        private System.Void .cctor() { }
        private System.Single <ShapeAttenuationAreaTubeLight>g__Fpo|26_0(System.Single d, System.Single l) { }
        private System.Single <ShapeAttenuationAreaTubeLight>g__Fwt|26_1(System.Single d, System.Single l) { }
        private System.Single <ShapeAttenuationAreaTubeLight>g__DiffLineIntegral|26_2(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2) { }
        private UnityEngine.Vector2 <DoLensFlareDataDrivenCommon>g__ComputeLocalSize|35_0(UnityEngine.Vector2 rayOff, UnityEngine.Vector2 rayOff0, UnityEngine.Vector2 curSize, UnityEngine.AnimationCurve distortionCurve, UnityEngine.Rendering.LensFlareCommonSRP.<>c__DisplayClass35_0& , UnityEngine.Rendering.LensFlareCommonSRP.<>c__DisplayClass35_1& ) { }
        private System.Single <DoLensFlareDataDrivenCommon>g__RandomRange|35_1(System.Single min, System.Single max) { }

    }

    // TypeToken: 0x20000E4
    public class LensFlareComponentSRP : MonoBehaviour
    {
        // Fields
        private UnityEngine.Rendering.LensFlareDataSRP m_LensFlareData;        // 0x18
        public System.Single intensity;        // 0x20
        public System.Single maxAttenuationDistance;        // 0x24
        public System.Single maxAttenuationScale;        // 0x28
        public UnityEngine.AnimationCurve distanceAttenuationCurve;        // 0x30
        public UnityEngine.AnimationCurve scaleByDistanceCurve;        // 0x38
        public System.Boolean attenuationByLightShape;        // 0x40
        public UnityEngine.AnimationCurve radialScreenAttenuationCurve;        // 0x48
        public System.Boolean useOcclusion;        // 0x50
        public System.Single occlusionRadius;        // 0x54
        public System.UInt32 sampleCount;        // 0x58
        public System.Single occlusionOffset;        // 0x5C
        public System.Single scale;        // 0x60
        public System.Boolean allowOffScreen;        // 0x64
        public System.Boolean useCustomForward;        // 0x65
        public UnityEngine.Vector3 customForward;        // 0x68
        private static System.Single sCelestialAngularRadius;        // 0x0

        // Methods
        private UnityEngine.Rendering.LensFlareDataSRP get_lensFlareData() { }
        private System.Void set_lensFlareData(UnityEngine.Rendering.LensFlareDataSRP value) { }
        private System.Single celestialProjectedOcclusionRadius(UnityEngine.Camera mainCam) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnValidate() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000E5
    public struct SRPLensFlareBlendMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.SRPLensFlareBlendMode Additive;        // 0x0
        public static UnityEngine.Rendering.SRPLensFlareBlendMode Screen;        // 0x0
        public static UnityEngine.Rendering.SRPLensFlareBlendMode Premultiply;        // 0x0
        public static UnityEngine.Rendering.SRPLensFlareBlendMode Lerp;        // 0x0

    }

    // TypeToken: 0x20000E6
    public struct SRPLensFlareDistribution
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.SRPLensFlareDistribution Uniform;        // 0x0
        public static UnityEngine.Rendering.SRPLensFlareDistribution Curve;        // 0x0
        public static UnityEngine.Rendering.SRPLensFlareDistribution Random;        // 0x0

    }

    // TypeToken: 0x20000E7
    public struct SRPLensFlareType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.SRPLensFlareType Image;        // 0x0
        public static UnityEngine.Rendering.SRPLensFlareType Circle;        // 0x0
        public static UnityEngine.Rendering.SRPLensFlareType Polygon;        // 0x0

    }

    // TypeToken: 0x20000E8
    public class LensFlareDataElementSRP
    {
        // Fields
        public System.Boolean visible;        // 0x10
        public System.Single position;        // 0x14
        public UnityEngine.Vector2 positionOffset;        // 0x18
        public System.Single angularOffset;        // 0x20
        public UnityEngine.Vector2 translationScale;        // 0x24
        private System.Single m_LocalIntensity;        // 0x2C
        public UnityEngine.Texture lensFlareTexture;        // 0x30
        public System.Single uniformScale;        // 0x38
        public UnityEngine.Vector2 sizeXY;        // 0x3C
        public System.Boolean allowMultipleElement;        // 0x44
        private System.Int32 m_Count;        // 0x48
        public System.Boolean preserveAspectRatio;        // 0x4C
        public System.Single rotation;        // 0x50
        public UnityEngine.Color tint;        // 0x54
        public UnityEngine.Rendering.SRPLensFlareBlendMode blendMode;        // 0x64
        public System.Boolean autoRotate;        // 0x68
        public UnityEngine.Rendering.SRPLensFlareType flareType;        // 0x6C
        public System.Boolean modulateByLightColor;        // 0x70
        private System.Boolean isFoldOpened;        // 0x71
        public UnityEngine.Rendering.SRPLensFlareDistribution distribution;        // 0x74
        public System.Single lengthSpread;        // 0x78
        public UnityEngine.AnimationCurve positionCurve;        // 0x80
        public UnityEngine.AnimationCurve scaleCurve;        // 0x88
        public System.Int32 seed;        // 0x90
        public UnityEngine.Gradient colorGradient;        // 0x98
        private System.Single m_IntensityVariation;        // 0xA0
        public UnityEngine.Vector2 positionVariation;        // 0xA4
        public System.Single scaleVariation;        // 0xAC
        public System.Single rotationVariation;        // 0xB0
        public System.Boolean enableRadialDistortion;        // 0xB4
        public UnityEngine.Vector2 targetSizeDistortion;        // 0xB8
        public UnityEngine.AnimationCurve distortionCurve;        // 0xC0
        public System.Boolean distortionRelativeToCenter;        // 0xC8
        private System.Single m_FallOff;        // 0xCC
        private System.Single m_EdgeOffset;        // 0xD0
        private System.Int32 m_SideCount;        // 0xD4
        private System.Single m_SdfRoundness;        // 0xD8
        public System.Boolean inverseSDF;        // 0xDC
        public System.Single uniformAngle;        // 0xE0
        public UnityEngine.AnimationCurve uniformAngleCurve;        // 0xE8

        // Methods
        private System.Void .ctor() { }
        private System.Single get_localIntensity() { }
        private System.Void set_localIntensity(System.Single value) { }
        private System.Int32 get_count() { }
        private System.Void set_count(System.Int32 value) { }
        private System.Single get_intensityVariation() { }
        private System.Void set_intensityVariation(System.Single value) { }
        private System.Single get_fallOff() { }
        private System.Void set_fallOff(System.Single value) { }
        private System.Single get_edgeOffset() { }
        private System.Void set_edgeOffset(System.Single value) { }
        private System.Int32 get_sideCount() { }
        private System.Void set_sideCount(System.Int32 value) { }
        private System.Single get_sdfRoundness() { }
        private System.Void set_sdfRoundness(System.Single value) { }

    }

    // TypeToken: 0x20000E9
    public class LensFlareDataSRP : ScriptableObject
    {
        // Fields
        public UnityEngine.Rendering.LensFlareDataElementSRP[] elements;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000EA
    public class RenderPipelineResources : ScriptableObject
    {
        // Methods
        private System.String get_packagePath() { }
        private System.String get_packagePath_Internal() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000EB
    public struct PackingRules
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.PackingRules Exact;        // 0x0
        public static UnityEngine.Rendering.PackingRules Aggressive;        // 0x0

    }

    // TypeToken: 0x20000EC
    public struct FieldPacking
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.FieldPacking NoPacking;        // 0x0
        public static UnityEngine.Rendering.FieldPacking R11G11B10;        // 0x0
        public static UnityEngine.Rendering.FieldPacking PackedFloat;        // 0x0
        public static UnityEngine.Rendering.FieldPacking PackedUint;        // 0x0

    }

    // TypeToken: 0x20000ED
    public struct FieldPrecision
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.FieldPrecision Half;        // 0x0
        public static UnityEngine.Rendering.FieldPrecision Real;        // 0x0
        public static UnityEngine.Rendering.FieldPrecision Default;        // 0x0

    }

    // TypeToken: 0x20000EE
    public class GenerateHLSL : Attribute
    {
        // Fields
        public UnityEngine.Rendering.PackingRules packingRules;        // 0x10
        public System.Boolean containsPackedFields;        // 0x14
        public System.Boolean needAccessors;        // 0x15
        public System.Boolean needSetters;        // 0x16
        public System.Boolean needParamDebug;        // 0x17
        public System.Int32 paramDefinesStart;        // 0x18
        public System.Boolean omitStructDeclaration;        // 0x1C
        public System.Boolean generateCBuffer;        // 0x1D
        public System.Int32 constantRegister;        // 0x20
        public System.String sourcePath;        // 0x28

        // Methods
        private System.Void .ctor(UnityEngine.Rendering.PackingRules rules, System.Boolean needAccessors, System.Boolean needSetters, System.Boolean needParamDebug, System.Int32 paramDefinesStart, System.Boolean omitStructDeclaration, System.Boolean containsPackedFields, System.Boolean generateCBuffer, System.Int32 constantRegister, System.String sourcePath) { }

    }

    // TypeToken: 0x20000EF
    public class SurfaceDataAttributes : Attribute
    {
        // Fields
        public System.String[] displayNames;        // 0x10
        public System.Boolean isDirection;        // 0x18
        public System.Boolean sRGBDisplay;        // 0x19
        public UnityEngine.Rendering.FieldPrecision precision;        // 0x1C
        public System.Boolean checkIsNormalized;        // 0x20
        public System.String preprocessor;        // 0x28

        // Methods
        private System.Void .ctor(System.String displayName, System.Boolean isDirection, System.Boolean sRGBDisplay, UnityEngine.Rendering.FieldPrecision precision, System.Boolean checkIsNormalized, System.String preprocessor) { }
        private System.Void .ctor(System.String[] displayNames, System.Boolean isDirection, System.Boolean sRGBDisplay, UnityEngine.Rendering.FieldPrecision precision, System.Boolean checkIsNormalized, System.String preprocessor) { }

    }

    // TypeToken: 0x20000F0
    public class HLSLArray : Attribute
    {
        // Fields
        public System.Int32 arraySize;        // 0x10
        public System.Type elementType;        // 0x18

        // Methods
        private System.Void .ctor(System.Int32 arraySize, System.Type elementType) { }

    }

    // TypeToken: 0x20000F1
    public class PackingAttribute : Attribute
    {
        // Fields
        public System.String[] displayNames;        // 0x10
        public System.Single[] range;        // 0x18
        public UnityEngine.Rendering.FieldPacking packingScheme;        // 0x20
        public System.Int32 offsetInSource;        // 0x24
        public System.Int32 sizeInBits;        // 0x28
        public System.Boolean isDirection;        // 0x2C
        public System.Boolean sRGBDisplay;        // 0x2D
        public System.Boolean checkIsNormalized;        // 0x2E
        public System.String preprocessor;        // 0x30

        // Methods
        private System.Void .ctor(System.String[] displayNames, UnityEngine.Rendering.FieldPacking packingScheme, System.Int32 bitSize, System.Int32 offsetInSource, System.Single minValue, System.Single maxValue, System.Boolean isDirection, System.Boolean sRGBDisplay, System.Boolean checkIsNormalized, System.String preprocessor) { }
        private System.Void .ctor(System.String displayName, UnityEngine.Rendering.FieldPacking packingScheme, System.Int32 bitSize, System.Int32 offsetInSource, System.Single minValue, System.Single maxValue, System.Boolean isDirection, System.Boolean sRGBDisplay, System.Boolean checkIsNormalized, System.String preprocessor) { }

    }

    // TypeToken: 0x20000F2
    public struct ShaderGenUInt4
    {
    }

    // TypeToken: 0x20000F3
    public class Hammersley
    {
        // Fields
        private static System.Single[] k_Hammersley2dSeq16;        // 0x0
        private static System.Single[] k_Hammersley2dSeq32;        // 0x8
        private static System.Single[] k_Hammersley2dSeq64;        // 0x10
        private static System.Single[] k_Hammersley2dSeq256;        // 0x18
        private static readonly System.Int32 s_hammersley2DSeq16Id;        // 0x20
        private static readonly System.Int32 s_hammersley2DSeq32Id;        // 0x24
        private static readonly System.Int32 s_hammersley2DSeq64Id;        // 0x28
        private static readonly System.Int32 s_hammersley2DSeq256Id;        // 0x2C

        // Methods
        private System.Void Initialize() { }
        private System.Void BindConstants(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader cs) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000FC
    public class BufferedRTHandleSystem, IDisposable
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Rendering.RTHandle[]> m_RTHandles;        // 0x10
        private System.Boolean m_DisposedValue;        // 0x18

        // Methods
        private UnityEngine.Rendering.RTHandle GetFrameRT(System.Int32 bufferId, System.Int32 frameIndex) { }
        private System.Void AllocBuffer(System.Int32 bufferId, System.Func<System.Int32,UnityEngine.Rendering.RTHandle> allocator, System.Int32 bufferCount) { }
        private System.Void ReleaseBuffer(System.Int32 bufferId) { }
        private System.Int32 GetNumFramesAllocated(System.Int32 bufferId) { }
        private System.Void Swap() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void Dispose() { }
        private System.Void ReleaseAll() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FD
    public struct DepthBits
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.DepthBits None;        // 0x0
        public static UnityEngine.Rendering.DepthBits Depth8;        // 0x0
        public static UnityEngine.Rendering.DepthBits Depth16;        // 0x0
        public static UnityEngine.Rendering.DepthBits Depth24;        // 0x0
        public static UnityEngine.Rendering.DepthBits Depth32;        // 0x0

    }

    // TypeToken: 0x20000FE
    public struct MSAASamples
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.MSAASamples None;        // 0x0
        public static UnityEngine.Rendering.MSAASamples MSAA2x;        // 0x0
        public static UnityEngine.Rendering.MSAASamples MSAA4x;        // 0x0
        public static UnityEngine.Rendering.MSAASamples MSAA8x;        // 0x0

    }

    // TypeToken: 0x20000FF
    public class PowerOfTwoTextureAtlas : Texture2DAtlas
    {
        // Fields
        private readonly System.Int32 m_MipPadding;        // 0x48
        private static System.Single k_MipmapFactorApprox;        // 0x0
        private System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Vector2Int> m_RequestedTextures;        // 0x50

        // Methods
        private System.Void .ctor(System.Int32 size, System.Int32 mipPadding, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.FilterMode filterMode, System.String name, System.Boolean useMipMap) { }
        private System.Int32 get_mipPadding() { }
        private System.Int32 GetTexturePadding() { }
        private UnityEngine.Vector4 GetPayloadScaleOffset(UnityEngine.Texture texture, UnityEngine.Vector4& scaleOffset) { }
        private UnityEngine.Vector4 GetPayloadScaleOffset(UnityEngine.Vector2& textureSize, UnityEngine.Vector2& paddingSize, UnityEngine.Vector4& scaleOffset) { }
        private System.Void Blit2DTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, System.Boolean blitMips, UnityEngine.Rendering.PowerOfTwoTextureAtlas.BlitType blitType) { }
        private System.Void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, System.Boolean blitMips, System.Int32 overrideInstanceID) { }
        private System.Void BlitTextureMultiply(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, System.Boolean blitMips, System.Int32 overrideInstanceID) { }
        private System.Void BlitOctahedralTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, System.Boolean blitMips, System.Int32 overrideInstanceID) { }
        private System.Void BlitOctahedralTextureMultiply(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, System.Boolean blitMips, System.Int32 overrideInstanceID) { }
        private System.Void TextureSizeToPowerOfTwo(UnityEngine.Texture texture, System.Int32& width, System.Int32& height) { }
        private UnityEngine.Vector2 GetPowerOfTwoTextureSize(UnityEngine.Texture texture) { }
        private System.Boolean AllocateTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4& scaleOffset, UnityEngine.Texture texture, System.Int32 width, System.Int32 height, System.Int32 overrideInstanceID) { }
        private System.Void ResetRequestedTexture() { }
        private System.Boolean ReserveSpace(UnityEngine.Texture texture) { }
        private System.Boolean ReserveSpace(UnityEngine.Texture texture, System.Int32 width, System.Int32 height) { }
        private System.Boolean ReserveSpace(UnityEngine.Texture textureA, UnityEngine.Texture textureB, System.Int32 width, System.Int32 height) { }
        private System.Boolean ReserveSpace(System.Int32 id, System.Int32 width, System.Int32 height) { }
        private System.Boolean RelayoutEntries() { }
        private System.Int64 GetApproxCacheSizeInByte(System.Int32 nbElement, System.Int32 resolution, System.Boolean hasMipmap, UnityEngine.Experimental.Rendering.GraphicsFormat format) { }
        private System.Int32 GetMaxCacheSizeForWeightInByte(System.Int32 weight, System.Boolean hasMipmap, UnityEngine.Experimental.Rendering.GraphicsFormat format) { }

    }

    // TypeToken: 0x2000102
    public class RTHandle
    {
        // Fields
        private UnityEngine.RenderTexture m_RT;        // 0x10
        private UnityEngine.Texture m_ExternalTexture;        // 0x18
        private UnityEngine.Rendering.RenderTargetIdentifier m_NameID;        // 0x20
        private System.Boolean m_EnableMSAA;        // 0x48
        private System.Boolean m_EnableRandomWrite;        // 0x49
        private System.String m_Name;        // 0x50

        // Methods
        private UnityEngine.RenderTexture get_rt() { }
        private UnityEngine.Rendering.RenderTargetIdentifier get_nameID() { }
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private System.Boolean get_isMSAAEnabled() { }
        private UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Rendering.RTHandle handle) { }
        private UnityEngine.Texture op_Implicit(UnityEngine.Rendering.RTHandle handle) { }
        private UnityEngine.RenderTexture op_Implicit(UnityEngine.Rendering.RTHandle handle) { }
        private System.Void SetRenderTexture(UnityEngine.RenderTexture rt) { }
        private System.Void SetTexture(UnityEngine.Texture tex) { }
        private System.Void SetTexture(UnityEngine.Rendering.RenderTargetIdentifier tex) { }
        private System.Int32 GetInstanceID() { }
        private System.Void Release() { }
        private System.Void SwitchToFastMemory(UnityEngine.Rendering.CommandBuffer cmd, System.Single residencyFraction, UnityEngine.Rendering.FastMemoryFlags flags, System.Boolean copyContents) { }
        private System.Void CopyToFastMemory(UnityEngine.Rendering.CommandBuffer cmd, System.Single residencyFraction, UnityEngine.Rendering.FastMemoryFlags flags) { }
        private System.Void SwitchOutFastMemory(UnityEngine.Rendering.CommandBuffer cmd, System.Boolean copyContents) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000103
    public class RTHandles
    {
        // Fields
        private static UnityEngine.Rendering.RTHandleSystem s_DefaultInstance;        // 0x0

        // Methods
        private UnityEngine.Rendering.RTHandle Alloc(System.Int32 width, System.Int32 height, System.Int32 slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, System.Boolean enableRandomWrite, System.Boolean useMipMap, System.Boolean autoGenerateMips, System.Boolean isShadowMap, System.Int32 anisoLevel, System.Single mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, System.Boolean bindTextureMS, UnityEngine.RenderTextureMemoryless memoryless, System.String name) { }
        private UnityEngine.Rendering.RTHandle Alloc(System.Int32 width, System.Int32 height, UnityEngine.TextureWrapMode wrapModeU, UnityEngine.TextureWrapMode wrapModeV, UnityEngine.TextureWrapMode wrapModeW, System.Int32 slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.Rendering.TextureDimension dimension, System.Boolean enableRandomWrite, System.Boolean useMipMap, System.Boolean autoGenerateMips, System.Boolean isShadowMap, System.Int32 anisoLevel, System.Single mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, System.Boolean bindTextureMS, System.Boolean useDynamicScale, UnityEngine.RenderTextureMemoryless memoryless, System.String name) { }
        private UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Texture tex) { }
        private UnityEngine.Rendering.RTHandle Alloc(UnityEngine.RenderTexture tex) { }
        private UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RenderTargetIdentifier tex) { }
        private UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RenderTargetIdentifier tex, System.String name) { }
        private UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RTHandle tex) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000104
    public class RTHandleSystem
    {
        // Methods
        private System.Void Initialize() { }
        private UnityEngine.Rendering.RTHandle Alloc(System.Int32 width, System.Int32 height, System.Int32 slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, System.Boolean enableRandomWrite, System.Boolean useMipMap, System.Boolean autoGenerateMips, System.Boolean isShadowMap, System.Int32 anisoLevel, System.Single mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, System.Boolean bindTextureMS, UnityEngine.RenderTextureMemoryless memoryless, System.String name) { }
        private UnityEngine.Rendering.RTHandle Alloc(System.Int32 width, System.Int32 height, UnityEngine.TextureWrapMode wrapModeU, UnityEngine.TextureWrapMode wrapModeV, UnityEngine.TextureWrapMode wrapModeW, System.Int32 slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.Rendering.TextureDimension dimension, System.Boolean enableRandomWrite, System.Boolean useMipMap, System.Boolean autoGenerateMips, System.Boolean isShadowMap, System.Int32 anisoLevel, System.Single mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, System.Boolean bindTextureMS, UnityEngine.RenderTextureMemoryless memoryless, System.String name) { }
        private UnityEngine.Rendering.RTHandle AllocAutoSizedRenderTexture(System.Int32 width, System.Int32 height, System.Int32 slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, System.Boolean enableRandomWrite, System.Boolean useMipMap, System.Boolean autoGenerateMips, System.Boolean isShadowMap, System.Int32 anisoLevel, System.Single mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, System.Boolean bindTextureMS, UnityEngine.RenderTextureMemoryless memoryless, System.String name) { }
        private UnityEngine.Rendering.RTHandle Alloc(UnityEngine.RenderTexture texture) { }
        private UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Texture texture) { }
        private UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RenderTargetIdentifier texture) { }
        private UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RenderTargetIdentifier texture, System.String name) { }
        private UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RTHandle tex) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000105
    public class AtlasAllocator
    {
        // Fields
        private UnityEngine.Rendering.AtlasAllocator.AtlasNode m_Root;        // 0x10
        private System.Int32 m_Width;        // 0x18
        private System.Int32 m_Height;        // 0x1C
        private System.Boolean powerOfTwoPadding;        // 0x20
        private UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.AtlasAllocator.AtlasNode> m_NodePool;        // 0x28

        // Methods
        private System.Void .ctor(System.Int32 width, System.Int32 height, System.Boolean potPadding) { }
        private System.Boolean Allocate(UnityEngine.Vector4& result, System.Int32 width, System.Int32 height) { }
        private System.Void Reset() { }

    }

    // TypeToken: 0x2000108
    public class Texture2DAtlas
    {
        // Fields
        private static System.Int32 kGPUTexInvalid;        // 0x0
        private static System.Int32 kGPUTexValidMip0;        // 0x0
        private static System.Int32 kGPUTexValidMipAll;        // 0x0
        private UnityEngine.Rendering.RTHandle m_AtlasTexture;        // 0x10
        private System.Int32 m_Width;        // 0x18
        private System.Int32 m_Height;        // 0x1C
        private UnityEngine.Experimental.Rendering.GraphicsFormat m_Format;        // 0x20
        private System.Boolean m_UseMipMaps;        // 0x24
        private System.Boolean m_IsAtlasTextureOwner;        // 0x25
        private UnityEngine.Rendering.AtlasAllocator m_AtlasAllocator;        // 0x28
        private System.Collections.Generic.Dictionary<System.Int32,System.ValueTuple<UnityEngine.Vector4,UnityEngine.Vector2Int>> m_AllocationCache;        // 0x30
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> m_IsGPUTextureUpToDate;        // 0x38
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> m_TextureHashes;        // 0x40
        private static readonly UnityEngine.Vector4 fullScaleOffset;        // 0x0
        private static readonly System.Int32 s_MaxMipLevelPadding;        // 0x10

        // Methods
        private System.Int32 get_maxMipLevelPadding() { }
        private UnityEngine.Rendering.RTHandle get_AtlasTexture() { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.FilterMode filterMode, System.Boolean powerOfTwoPadding, System.String name, System.Boolean useMipMap) { }
        private System.Void Release() { }
        private System.Void ResetAllocator() { }
        private System.Void ClearTarget(UnityEngine.Rendering.CommandBuffer cmd) { }
        private System.Int32 GetTextureMipmapCount(System.Int32 width, System.Int32 height) { }
        private System.Boolean Is2D(UnityEngine.Texture texture) { }
        private System.Boolean IsSingleChannelBlit(UnityEngine.Texture source, UnityEngine.Texture destination) { }
        private System.Void Blit2DTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, System.Boolean blitMips, UnityEngine.Rendering.Texture2DAtlas.BlitType blitType) { }
        private System.Void MarkGPUTextureValid(System.Int32 instanceId, System.Boolean mipAreValid) { }
        private System.Void MarkGPUTextureInvalid(System.Int32 instanceId) { }
        private System.Void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, System.Boolean blitMips, System.Int32 overrideInstanceID) { }
        private System.Void BlitOctahedralTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, System.Boolean blitMips, System.Int32 overrideInstanceID) { }
        private System.Void BlitCubeTexture2D(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, System.Boolean blitMips, System.Int32 overrideInstanceID) { }
        private System.Boolean AllocateTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4& scaleOffset, UnityEngine.Texture texture, System.Int32 width, System.Int32 height, System.Int32 overrideInstanceID) { }
        private System.Boolean AllocateTextureWithoutBlit(UnityEngine.Texture texture, System.Int32 width, System.Int32 height, UnityEngine.Vector4& scaleOffset) { }
        private System.Boolean AllocateTextureWithoutBlit(System.Int32 instanceId, System.Int32 width, System.Int32 height, UnityEngine.Vector4& scaleOffset) { }
        private System.Int32 GetTextureHash(UnityEngine.Texture textureA, UnityEngine.Texture textureB) { }
        private System.Int32 GetTextureID(UnityEngine.Texture texture) { }
        private System.Int32 GetTextureID(UnityEngine.Texture textureA, UnityEngine.Texture textureB) { }
        private System.Boolean IsCached(UnityEngine.Vector4& scaleOffset, UnityEngine.Texture textureA, UnityEngine.Texture textureB) { }
        private System.Boolean IsCached(UnityEngine.Vector4& scaleOffset, UnityEngine.Texture texture) { }
        private System.Boolean IsCached(UnityEngine.Vector4& scaleOffset, System.Int32 id) { }
        private UnityEngine.Vector2Int GetCachedTextureSize(System.Int32 id) { }
        private System.Boolean NeedsUpdate(UnityEngine.Texture texture, System.Boolean needMips) { }
        private System.Boolean NeedsUpdate(UnityEngine.Texture textureA, UnityEngine.Texture textureB, System.Boolean needMips) { }
        private System.Boolean AddTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4& scaleOffset, UnityEngine.Texture texture) { }
        private System.Boolean UpdateTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture oldTexture, UnityEngine.Texture newTexture, UnityEngine.Vector4& scaleOffset, UnityEngine.Vector4 sourceScaleOffset, System.Boolean updateIfNeeded, System.Boolean blitMips) { }
        private System.Boolean UpdateTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture texture, UnityEngine.Vector4& scaleOffset, System.Boolean updateIfNeeded, System.Boolean blitMips) { }
        private System.Boolean EnsureTextureSlot(System.Boolean& isUploadNeeded, UnityEngine.Vector4& scaleBias, System.Int32 key, System.Int32 width, System.Int32 height) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200010A
    public class AtlasAllocatorDynamic
    {
        // Fields
        private System.Int32 m_Width;        // 0x10
        private System.Int32 m_Height;        // 0x14
        private UnityEngine.Rendering.AtlasAllocatorDynamic.AtlasNodePool m_Pool;        // 0x18
        private System.Int16 m_Root;        // 0x20
        private System.Collections.Generic.Dictionary<System.Int32,System.Int16> m_NodeFromID;        // 0x28

        // Methods
        private System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 capacityAllocations) { }
        private System.Boolean Allocate(UnityEngine.Vector4& result, System.Int32 key, System.Int32 width, System.Int32 height) { }
        private System.Void Release(System.Int32 key) { }
        private System.Void Release() { }
        private System.String DebugStringFromRoot(System.Int32 depthMax) { }
        private System.Void DebugStringFromNode(System.String& res, System.Int16 n, System.Int32 depthCurrent, System.Int32 depthMax) { }

    }

    // TypeToken: 0x200010E
    public class Texture2DAtlasDynamic
    {
        // Fields
        private UnityEngine.Rendering.RTHandle m_AtlasTexture;        // 0x10
        private System.Boolean isAtlasTextureOwner;        // 0x18
        private System.Int32 m_Width;        // 0x1C
        private System.Int32 m_Height;        // 0x20
        private UnityEngine.Experimental.Rendering.GraphicsFormat m_Format;        // 0x24
        private UnityEngine.Rendering.AtlasAllocatorDynamic m_AtlasAllocator;        // 0x28
        private System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Vector4> m_AllocationCache;        // 0x30

        // Methods
        private UnityEngine.Rendering.RTHandle get_AtlasTexture() { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 capacity, UnityEngine.Experimental.Rendering.GraphicsFormat format) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 capacity, UnityEngine.Rendering.RTHandle atlasTexture) { }
        private System.Void Release() { }
        private System.Void ResetAllocator() { }
        private System.Boolean AddTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4& scaleOffset, UnityEngine.Texture texture) { }
        private System.Boolean IsCached(UnityEngine.Vector4& scaleOffset, System.Int32 key) { }
        private System.Boolean EnsureTextureSlot(System.Boolean& isUploadNeeded, UnityEngine.Vector4& scaleOffset, System.Int32 key, System.Int32 width, System.Int32 height) { }
        private System.Void ReleaseTextureSlot(System.Int32 key) { }

    }

    // TypeToken: 0x200010F
    public class TextureXR
    {
        // Fields
        private static System.Int32 m_MaxViews;        // 0x0
        private static UnityEngine.Texture m_BlackUIntTexture2DArray;        // 0x8
        private static UnityEngine.Texture m_BlackUIntTexture;        // 0x10
        private static UnityEngine.Rendering.RTHandle m_BlackUIntTexture2DArrayRTH;        // 0x18
        private static UnityEngine.Rendering.RTHandle m_BlackUIntTextureRTH;        // 0x20
        private static UnityEngine.Texture2DArray m_ClearTexture2DArray;        // 0x28
        private static UnityEngine.Texture2D m_ClearTexture;        // 0x30
        private static UnityEngine.Rendering.RTHandle m_ClearTexture2DArrayRTH;        // 0x38
        private static UnityEngine.Rendering.RTHandle m_ClearTextureRTH;        // 0x40
        private static UnityEngine.Texture2DArray m_MagentaTexture2DArray;        // 0x48
        private static UnityEngine.Texture2D m_MagentaTexture;        // 0x50
        private static UnityEngine.Rendering.RTHandle m_MagentaTexture2DArrayRTH;        // 0x58
        private static UnityEngine.Rendering.RTHandle m_MagentaTextureRTH;        // 0x60
        private static UnityEngine.Texture2D m_BlackTexture;        // 0x68
        private static UnityEngine.Texture3D m_BlackTexture3D;        // 0x70
        private static UnityEngine.Texture2DArray m_BlackTexture2DArray;        // 0x78
        private static UnityEngine.Rendering.RTHandle m_BlackTexture2DArrayRTH;        // 0x80
        private static UnityEngine.Rendering.RTHandle m_BlackTextureRTH;        // 0x88
        private static UnityEngine.Rendering.RTHandle m_BlackTexture3DRTH;        // 0x90
        private static UnityEngine.Texture2DArray m_WhiteTexture2DArray;        // 0x98
        private static UnityEngine.Rendering.RTHandle m_WhiteTexture2DArrayRTH;        // 0xA0
        private static UnityEngine.Rendering.RTHandle m_WhiteTextureRTH;        // 0xA8

        // Methods
        private System.Void set_maxViews(System.Int32 value) { }
        private System.Int32 get_slices() { }
        private System.Boolean get_useTexArray() { }
        private UnityEngine.Rendering.TextureDimension get_dimension() { }
        private UnityEngine.Rendering.RTHandle GetBlackUIntTexture() { }
        private UnityEngine.Rendering.RTHandle GetClearTexture() { }
        private UnityEngine.Rendering.RTHandle GetMagentaTexture() { }
        private UnityEngine.Rendering.RTHandle GetBlackTexture() { }
        private UnityEngine.Rendering.RTHandle GetBlackTextureArray() { }
        private UnityEngine.Rendering.RTHandle GetBlackTexture3D() { }
        private UnityEngine.Rendering.RTHandle GetWhiteTexture() { }
        private System.Void Initialize(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader clearR32_UIntShader) { }
        private UnityEngine.Texture2DArray CreateTexture2DArrayFromTexture2D(UnityEngine.Texture2D source, System.String name) { }
        private UnityEngine.Texture CreateBlackUIntTextureArray(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader clearR32_UIntShader) { }
        private UnityEngine.Texture CreateBlackUintTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader clearR32_UIntShader) { }
        private UnityEngine.Texture3D CreateBlackTexture3D(System.String name) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000110
    public class ArrayExtensions
    {
        // Methods
        private System.Void ResizeArray(Unity.Collections.NativeArray<T>& array, System.Int32 capacity, Unity.Collections.Allocator allocator) { }
        private System.Void ResizeArray(UnityEngine.Jobs.TransformAccessArray& array, System.Int32 capacity) { }
        private System.Void ResizeArray(T[]& array, System.Int32 capacity) { }
        private System.Void Grow(T[]& array, System.Int32 targetSize) { }
        private System.Void GrowToNearestPowerOf2(T[]& array, System.Int32 targetSize) { }
        private System.UInt32 RoundUpToPowerOf2(System.UInt32 n) { }

    }

    // TypeToken: 0x2000111
    public interface IBitArray
    {
        // Methods
        private System.UInt32 get_capacity() { }
        private System.Boolean get_allFalse() { }
        private System.Boolean get_allTrue() { }
        private System.Boolean get_Item(System.UInt32 index) { }
        private System.Void set_Item(System.UInt32 index, System.Boolean value) { }
        private System.String get_humanizedData() { }
        private UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other) { }
        private UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other) { }
        private UnityEngine.Rendering.IBitArray BitNot() { }

    }

    // TypeToken: 0x2000112
    public struct BitArray8, IBitArray
    {
        // Fields
        private System.Byte data;        // 0x10

        // Methods
        private System.UInt32 get_capacity() { }
        private System.Boolean get_allFalse() { }
        private System.Boolean get_allTrue() { }
        private System.String get_humanizedData() { }
        private System.Boolean get_Item(System.UInt32 index) { }
        private System.Void set_Item(System.UInt32 index, System.Boolean value) { }
        private System.Void .ctor(System.Byte initValue) { }
        private System.Void .ctor(System.Collections.Generic.IEnumerable<System.UInt32> bitIndexTrue) { }
        private UnityEngine.Rendering.BitArray8 op_OnesComplement(UnityEngine.Rendering.BitArray8 a) { }
        private UnityEngine.Rendering.BitArray8 op_BitwiseOr(UnityEngine.Rendering.BitArray8 a, UnityEngine.Rendering.BitArray8 b) { }
        private UnityEngine.Rendering.BitArray8 op_BitwiseAnd(UnityEngine.Rendering.BitArray8 a, UnityEngine.Rendering.BitArray8 b) { }
        private UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other) { }
        private UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other) { }
        private UnityEngine.Rendering.IBitArray BitNot() { }
        private System.Boolean op_Equality(UnityEngine.Rendering.BitArray8 a, UnityEngine.Rendering.BitArray8 b) { }
        private System.Boolean op_Inequality(UnityEngine.Rendering.BitArray8 a, UnityEngine.Rendering.BitArray8 b) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000113
    public struct BitArray16, IBitArray
    {
        // Fields
        private System.UInt16 data;        // 0x10

        // Methods
        private System.UInt32 get_capacity() { }
        private System.Boolean get_allFalse() { }
        private System.Boolean get_allTrue() { }
        private System.String get_humanizedData() { }
        private System.Boolean get_Item(System.UInt32 index) { }
        private System.Void set_Item(System.UInt32 index, System.Boolean value) { }
        private System.Void .ctor(System.UInt16 initValue) { }
        private System.Void .ctor(System.Collections.Generic.IEnumerable<System.UInt32> bitIndexTrue) { }
        private UnityEngine.Rendering.BitArray16 op_OnesComplement(UnityEngine.Rendering.BitArray16 a) { }
        private UnityEngine.Rendering.BitArray16 op_BitwiseOr(UnityEngine.Rendering.BitArray16 a, UnityEngine.Rendering.BitArray16 b) { }
        private UnityEngine.Rendering.BitArray16 op_BitwiseAnd(UnityEngine.Rendering.BitArray16 a, UnityEngine.Rendering.BitArray16 b) { }
        private UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other) { }
        private UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other) { }
        private UnityEngine.Rendering.IBitArray BitNot() { }
        private System.Boolean op_Equality(UnityEngine.Rendering.BitArray16 a, UnityEngine.Rendering.BitArray16 b) { }
        private System.Boolean op_Inequality(UnityEngine.Rendering.BitArray16 a, UnityEngine.Rendering.BitArray16 b) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000114
    public struct BitArray32, IBitArray
    {
        // Fields
        private System.UInt32 data;        // 0x10

        // Methods
        private System.UInt32 get_capacity() { }
        private System.Boolean get_allFalse() { }
        private System.Boolean get_allTrue() { }
        private System.String get_humanizedVersion() { }
        private System.String get_humanizedData() { }
        private System.Boolean get_Item(System.UInt32 index) { }
        private System.Void set_Item(System.UInt32 index, System.Boolean value) { }
        private System.Void .ctor(System.UInt32 initValue) { }
        private System.Void .ctor(System.Collections.Generic.IEnumerable<System.UInt32> bitIndexTrue) { }
        private UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other) { }
        private UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other) { }
        private UnityEngine.Rendering.IBitArray BitNot() { }
        private UnityEngine.Rendering.BitArray32 op_OnesComplement(UnityEngine.Rendering.BitArray32 a) { }
        private UnityEngine.Rendering.BitArray32 op_BitwiseOr(UnityEngine.Rendering.BitArray32 a, UnityEngine.Rendering.BitArray32 b) { }
        private UnityEngine.Rendering.BitArray32 op_BitwiseAnd(UnityEngine.Rendering.BitArray32 a, UnityEngine.Rendering.BitArray32 b) { }
        private System.Boolean op_Equality(UnityEngine.Rendering.BitArray32 a, UnityEngine.Rendering.BitArray32 b) { }
        private System.Boolean op_Inequality(UnityEngine.Rendering.BitArray32 a, UnityEngine.Rendering.BitArray32 b) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000115
    public struct BitArray64, IBitArray
    {
        // Fields
        private System.UInt64 data;        // 0x10

        // Methods
        private System.UInt32 get_capacity() { }
        private System.Boolean get_allFalse() { }
        private System.Boolean get_allTrue() { }
        private System.String get_humanizedData() { }
        private System.Boolean get_Item(System.UInt32 index) { }
        private System.Void set_Item(System.UInt32 index, System.Boolean value) { }
        private System.Void .ctor(System.UInt64 initValue) { }
        private System.Void .ctor(System.Collections.Generic.IEnumerable<System.UInt32> bitIndexTrue) { }
        private UnityEngine.Rendering.BitArray64 op_OnesComplement(UnityEngine.Rendering.BitArray64 a) { }
        private UnityEngine.Rendering.BitArray64 op_BitwiseOr(UnityEngine.Rendering.BitArray64 a, UnityEngine.Rendering.BitArray64 b) { }
        private UnityEngine.Rendering.BitArray64 op_BitwiseAnd(UnityEngine.Rendering.BitArray64 a, UnityEngine.Rendering.BitArray64 b) { }
        private UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other) { }
        private UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other) { }
        private UnityEngine.Rendering.IBitArray BitNot() { }
        private System.Boolean op_Equality(UnityEngine.Rendering.BitArray64 a, UnityEngine.Rendering.BitArray64 b) { }
        private System.Boolean op_Inequality(UnityEngine.Rendering.BitArray64 a, UnityEngine.Rendering.BitArray64 b) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000116
    public struct BitArray128, IBitArray
    {
        // Fields
        private System.UInt64 data1;        // 0x10
        private System.UInt64 data2;        // 0x18

        // Methods
        private System.UInt64 get_Data1() { }
        private System.UInt64 get_Data2() { }
        private System.UInt32 get_capacity() { }
        private System.Boolean get_allFalse() { }
        private System.Boolean get_allTrue() { }
        private System.String get_humanizedData() { }
        private System.Boolean get_Item(System.UInt32 index) { }
        private System.Void set_Item(System.UInt32 index, System.Boolean value) { }
        private System.Void .ctor(System.UInt64 initValue1, System.UInt64 initValue2) { }
        private System.Void .ctor(System.Collections.Generic.IEnumerable<System.UInt32> bitIndexTrue) { }
        private UnityEngine.Rendering.BitArray128 op_OnesComplement(UnityEngine.Rendering.BitArray128 a) { }
        private UnityEngine.Rendering.BitArray128 op_BitwiseOr(UnityEngine.Rendering.BitArray128 a, UnityEngine.Rendering.BitArray128 b) { }
        private UnityEngine.Rendering.BitArray128 op_BitwiseAnd(UnityEngine.Rendering.BitArray128 a, UnityEngine.Rendering.BitArray128 b) { }
        private UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other) { }
        private UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other) { }
        private UnityEngine.Rendering.IBitArray BitNot() { }
        private System.Boolean op_Equality(UnityEngine.Rendering.BitArray128 a, UnityEngine.Rendering.BitArray128 b) { }
        private System.Boolean op_Inequality(UnityEngine.Rendering.BitArray128 a, UnityEngine.Rendering.BitArray128 b) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000117
    public struct BitArray256, IBitArray
    {
        // Fields
        private System.UInt64 data1;        // 0x10
        private System.UInt64 data2;        // 0x18
        private System.UInt64 data3;        // 0x20
        private System.UInt64 data4;        // 0x28

        // Methods
        private System.UInt32 get_capacity() { }
        private System.Boolean get_allFalse() { }
        private System.Boolean get_allTrue() { }
        private System.String get_humanizedData() { }
        private System.Boolean get_Item(System.UInt32 index) { }
        private System.Void set_Item(System.UInt32 index, System.Boolean value) { }
        private System.Void .ctor(System.UInt64 initValue1, System.UInt64 initValue2, System.UInt64 initValue3, System.UInt64 initValue4) { }
        private System.Void .ctor(System.Collections.Generic.IEnumerable<System.UInt32> bitIndexTrue) { }
        private UnityEngine.Rendering.BitArray256 op_OnesComplement(UnityEngine.Rendering.BitArray256 a) { }
        private UnityEngine.Rendering.BitArray256 op_BitwiseOr(UnityEngine.Rendering.BitArray256 a, UnityEngine.Rendering.BitArray256 b) { }
        private UnityEngine.Rendering.BitArray256 op_BitwiseAnd(UnityEngine.Rendering.BitArray256 a, UnityEngine.Rendering.BitArray256 b) { }
        private UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other) { }
        private UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other) { }
        private UnityEngine.Rendering.IBitArray BitNot() { }
        private System.Boolean op_Equality(UnityEngine.Rendering.BitArray256 a, UnityEngine.Rendering.BitArray256 b) { }
        private System.Boolean op_Inequality(UnityEngine.Rendering.BitArray256 a, UnityEngine.Rendering.BitArray256 b) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000118
    public class BitArrayUtilities
    {
        // Methods
        private System.Boolean Get8(System.UInt32 index, System.Byte data) { }
        private System.Boolean Get16(System.UInt32 index, System.UInt16 data) { }
        private System.Boolean Get32(System.UInt32 index, System.UInt32 data) { }
        private System.Boolean Get64(System.UInt32 index, System.UInt64 data) { }
        private System.Boolean Get128(System.UInt32 index, System.UInt64 data1, System.UInt64 data2) { }
        private System.Boolean Get256(System.UInt32 index, System.UInt64 data1, System.UInt64 data2, System.UInt64 data3, System.UInt64 data4) { }
        private System.Void Set8(System.UInt32 index, System.Byte& data, System.Boolean value) { }
        private System.Void Set16(System.UInt32 index, System.UInt16& data, System.Boolean value) { }
        private System.Void Set32(System.UInt32 index, System.UInt32& data, System.Boolean value) { }
        private System.Void Set64(System.UInt32 index, System.UInt64& data, System.Boolean value) { }
        private System.Void Set128(System.UInt32 index, System.UInt64& data1, System.UInt64& data2, System.Boolean value) { }
        private System.Void Set256(System.UInt32 index, System.UInt64& data1, System.UInt64& data2, System.UInt64& data3, System.UInt64& data4, System.Boolean value) { }

    }

    // TypeToken: 0x2000119
    public class Blitter
    {
        // Fields
        private static UnityEngine.Material s_Blit;        // 0x0
        private static UnityEngine.Material s_BlitTexArray;        // 0x8
        private static UnityEngine.Material s_BlitTexArraySingleSlice;        // 0x10
        private static UnityEngine.Material s_BlitMotionVector;        // 0x18
        private static UnityEngine.Material s_BlitColorAndDepth;        // 0x20
        private static UnityEngine.Material s_LowResBlit;        // 0x28
        private static UnityEngine.MaterialPropertyBlock s_PropertyBlock;        // 0x30
        private static UnityEngine.Mesh s_TriangleMesh;        // 0x38
        private static UnityEngine.Mesh s_QuadMesh;        // 0x40

        // Methods
        private System.Void Initialize(UnityEngine.Shader blitPS, UnityEngine.Shader blitColorAndDepthPS, UnityEngine.Shader blitMotionVectorPS, UnityEngine.Shader lowResBlitPS) { }
        private System.Void Cleanup() { }
        private UnityEngine.Material GetBlitMaterial(System.Boolean isFP32Output, UnityEngine.Rendering.TextureDimension dimension, System.Boolean singleSlice) { }
        private UnityEngine.Material GetBlitColorAndDepth(System.Boolean isFP32Output) { }
        private UnityEngine.Material GetBlitMotionVectorMaterial() { }
        private UnityEngine.Material GetLowResBlitMaterial() { }
        private System.Void DrawTriangle(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Material material, System.Int32 shaderPass) { }
        private System.Void DrawQuad(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Material material, System.Int32 shaderPass) { }
        private System.Void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, System.Single mipLevel, System.Boolean bilinear) { }
        private System.Void BlitTexture2D(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, System.Single mipLevel, System.Boolean bilinear) { }
        private System.Void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, UnityEngine.Material material, System.Int32 pass) { }
        private System.Void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, System.Single mipLevel, System.Boolean bilinear) { }
        private System.Void BlitCameraTexture2D(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, System.Single mipLevel, System.Boolean bilinear) { }
        private System.Void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Material material, System.Int32 pass) { }
        private System.Void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Vector4 scaleBias, System.Single mipLevel, System.Boolean bilinear) { }
        private System.Void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rect destViewport, System.Single mipLevel, System.Boolean bilinear) { }
        private System.Void BlitQuad(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, System.Int32 mipLevelTex, System.Boolean bilinear) { }
        private System.Void BlitQuadWithPadding(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, System.Int32 mipLevelTex, System.Boolean bilinear, System.Int32 paddingInPixels) { }
        private System.Void BlitQuadWithPaddingMultiply(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, System.Int32 mipLevelTex, System.Boolean bilinear, System.Int32 paddingInPixels) { }
        private System.Void BlitOctahedralWithPadding(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, System.Int32 mipLevelTex, System.Boolean bilinear, System.Int32 paddingInPixels) { }
        private System.Void BlitOctahedralWithPaddingMultiply(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, System.Int32 mipLevelTex, System.Boolean bilinear, System.Int32 paddingInPixels) { }
        private System.Void BlitCubeToOctahedral2DQuad(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector4 scaleBiasRT, System.Int32 mipLevelTex) { }
        private System.Void BlitCubeToOctahedral2DQuadSingleChannel(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector4 scaleBiasRT, System.Int32 mipLevelTex) { }
        private System.Void BlitQuadSingleChannel(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, System.Int32 mipLevelTex) { }
        private System.Void .cctor() { }
        private UnityEngine.Vector3[] <Initialize>g__GetFullScreenTriangleVertexPosition|10_0(System.Single z) { }
        private UnityEngine.Vector2[] <Initialize>g__GetFullScreenTriangleTexCoord|10_1() { }
        private UnityEngine.Vector3[] <Initialize>g__GetQuadVertexPosition|10_2(System.Single z) { }
        private UnityEngine.Vector2[] <Initialize>g__GetQuadTexCoord|10_3() { }

    }

    // TypeToken: 0x200011B
    public class CameraCaptureBridge
    {
        // Fields
        private static System.Collections.Generic.Dictionary<UnityEngine.Camera,System.Collections.Generic.HashSet<System.Action<UnityEngine.Rendering.RenderTargetIdentifier,UnityEngine.Rendering.CommandBuffer>>> actionDict;        // 0x0
        private static System.Boolean _enabled;        // 0x8

        // Methods
        private System.Boolean get_enabled() { }
        private System.Void set_enabled(System.Boolean value) { }
        private System.Collections.Generic.IEnumerator<System.Action<UnityEngine.Rendering.RenderTargetIdentifier,UnityEngine.Rendering.CommandBuffer>> GetCaptureActions(UnityEngine.Camera camera) { }
        private System.Void AddCaptureAction(UnityEngine.Camera camera, System.Action<UnityEngine.Rendering.RenderTargetIdentifier,UnityEngine.Rendering.CommandBuffer> action) { }
        private System.Void RemoveCaptureAction(UnityEngine.Camera camera, System.Action<UnityEngine.Rendering.RenderTargetIdentifier,UnityEngine.Rendering.CommandBuffer> action) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200011C
    public class ColorUtils
    {
        // Fields
        public static System.Single s_LightMeterCalibrationConstant;        // 0x0
        public static System.Single s_LensAttenuation;        // 0x4

        // Methods
        private System.Single get_lensImperfectionExposureScale() { }
        private System.Single StandardIlluminantY(System.Single x) { }
        private UnityEngine.Vector3 CIExyToLMS(System.Single x, System.Single y) { }
        private UnityEngine.Vector3 ColorBalanceToLMSCoeffs(System.Single temperature, System.Single tint) { }
        private System.ValueTuple<UnityEngine.Vector4,UnityEngine.Vector4,UnityEngine.Vector4> PrepareShadowsMidtonesHighlights(UnityEngine.Vector4& inShadows, UnityEngine.Vector4& inMidtones, UnityEngine.Vector4& inHighlights) { }
        private System.ValueTuple<UnityEngine.Vector4,UnityEngine.Vector4,UnityEngine.Vector4> PrepareLiftGammaGain(UnityEngine.Vector4& inLift, UnityEngine.Vector4& inGamma, UnityEngine.Vector4& inGain) { }
        private System.ValueTuple<UnityEngine.Vector4,UnityEngine.Vector4> PrepareSplitToning(UnityEngine.Vector4& inShadows, UnityEngine.Vector4& inHighlights, System.Single balance) { }
        private System.Single Luminance(UnityEngine.Color& color) { }
        private System.Single ComputeEV100(System.Single aperture, System.Single shutterSpeed, System.Single ISO) { }
        private System.Single ConvertEV100ToExposure(System.Single EV100) { }
        private System.Single ConvertExposureToEV100(System.Single exposure) { }
        private System.Single ComputeEV100FromAvgLuminance(System.Single avgLuminance) { }
        private System.Single ComputeISO(System.Single aperture, System.Single shutterSpeed, System.Single targetEV100) { }
        private System.UInt32 ToHex(UnityEngine.Color c) { }
        private UnityEngine.Color ToRGBA(System.UInt32 hex) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200011D
    public class CoreMatrixUtils
    {
        // Methods
        private System.Void MatrixTimesTranslation(UnityEngine.Matrix4x4& inOutMatrix, UnityEngine.Vector3 translation) { }
        private System.Void TranslationTimesMatrix(UnityEngine.Matrix4x4& inOutMatrix, UnityEngine.Vector3 translation) { }
        private UnityEngine.Matrix4x4 MultiplyPerspectiveMatrix(UnityEngine.Matrix4x4 perspective, UnityEngine.Matrix4x4 rhs) { }
        private UnityEngine.Matrix4x4 MultiplyOrthoMatrixCentered(UnityEngine.Matrix4x4 ortho, UnityEngine.Matrix4x4 rhs) { }
        private UnityEngine.Matrix4x4 MultiplyGenericOrthoMatrix(UnityEngine.Matrix4x4 ortho, UnityEngine.Matrix4x4 rhs) { }
        private UnityEngine.Matrix4x4 MultiplyOrthoMatrix(UnityEngine.Matrix4x4 ortho, UnityEngine.Matrix4x4 rhs, System.Boolean centered) { }
        private UnityEngine.Matrix4x4 MultiplyProjectionMatrix(UnityEngine.Matrix4x4 projMatrix, UnityEngine.Matrix4x4 rhs, System.Boolean orthoCentered) { }

    }

    // TypeToken: 0x200011E
    public class CoreUtils
    {
        // Fields
        public static readonly UnityEngine.Vector3[] lookAtList;        // 0x0
        public static readonly UnityEngine.Vector3[] upVectorList;        // 0x8
        private static System.String obsoletePriorityMessage;        // 0x0
        public static System.Int32 editMenuPriority1;        // 0x0
        public static System.Int32 editMenuPriority2;        // 0x0
        public static System.Int32 editMenuPriority3;        // 0x0
        public static System.Int32 editMenuPriority4;        // 0x0
        public static System.Int32 assetCreateMenuPriority1;        // 0x0
        public static System.Int32 assetCreateMenuPriority2;        // 0x0
        public static System.Int32 assetCreateMenuPriority3;        // 0x0
        public static System.Int32 gameObjectMenuPriority;        // 0x0
        private static UnityEngine.Cubemap m_BlackCubeTexture;        // 0x10
        private static UnityEngine.Cubemap m_MagentaCubeTexture;        // 0x18
        private static UnityEngine.CubemapArray m_MagentaCubeTextureArray;        // 0x20
        private static UnityEngine.Cubemap m_WhiteCubeTexture;        // 0x28
        private static UnityEngine.RenderTexture m_EmptyUAV;        // 0x30
        private static UnityEngine.Texture3D m_BlackVolumeTexture;        // 0x38
        private static System.Collections.Generic.IEnumerable<System.Type> m_AssemblyTypes;        // 0x40

        // Methods
        private UnityEngine.Cubemap get_blackCubeTexture() { }
        private UnityEngine.Cubemap get_magentaCubeTexture() { }
        private UnityEngine.CubemapArray get_magentaCubeTextureArray() { }
        private UnityEngine.Cubemap get_whiteCubeTexture() { }
        private UnityEngine.RenderTexture get_emptyUAV() { }
        private UnityEngine.Texture3D get_blackVolumeTexture() { }
        private System.Void ClearRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor) { }
        private System.Int32 FixupDepthSlice(System.Int32 depthSlice, UnityEngine.Rendering.RTHandle buffer) { }
        private System.Int32 FixupDepthSlice(System.Int32 depthSlice, UnityEngine.CubemapFace cubemapFace) { }
        private System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, System.Int32 miplevel, UnityEngine.CubemapFace cubemapFace, System.Int32 depthSlice) { }
        private System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.ClearFlag clearFlag, System.Int32 miplevel, UnityEngine.CubemapFace cubemapFace, System.Int32 depthSlice) { }
        private System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, System.Int32 miplevel, UnityEngine.CubemapFace cubemapFace, System.Int32 depthSlice) { }
        private System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, System.Int32 miplevel, UnityEngine.CubemapFace cubemapFace, System.Int32 depthSlice) { }
        private System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, System.Int32 miplevel, UnityEngine.CubemapFace cubemapFace, System.Int32 depthSlice) { }
        private System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer) { }
        private System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag) { }
        private System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor) { }
        private System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor) { }
        private System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Rendering.ClearFlag clearFlag) { }
        private System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor) { }
        private System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor) { }
        private System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlag) { }
        private System.Void SetViewportAndClear(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle buffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor) { }
        private System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle buffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, System.Int32 miplevel, UnityEngine.CubemapFace cubemapFace, System.Int32 depthSlice) { }
        private System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle buffer, UnityEngine.Rendering.ClearFlag clearFlag, System.Int32 miplevel, UnityEngine.CubemapFace cubemapFace, System.Int32 depthSlice) { }
        private System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorBuffer, UnityEngine.Rendering.RTHandle depthBuffer, System.Int32 miplevel, UnityEngine.CubemapFace cubemapFace, System.Int32 depthSlice) { }
        private System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorBuffer, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, System.Int32 miplevel, UnityEngine.CubemapFace cubemapFace, System.Int32 depthSlice) { }
        private System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorBuffer, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, System.Int32 miplevel, UnityEngine.CubemapFace cubemapFace, System.Int32 depthSlice) { }
        private System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RTHandle depthBuffer) { }
        private System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag) { }
        private System.Void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor) { }
        private System.Void SetViewport(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle target) { }
        private System.String GetRenderTargetAutoName(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.RenderTextureFormat format, System.String name, System.Boolean mips, System.Boolean enableMSAA, UnityEngine.Rendering.MSAASamples msaaSamples) { }
        private System.String GetRenderTargetAutoName(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.String name, System.Boolean mips, System.Boolean enableMSAA, UnityEngine.Rendering.MSAASamples msaaSamples) { }
        private System.String GetRenderTargetAutoName(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Rendering.TextureDimension dim, System.String name, System.Boolean mips, System.Boolean enableMSAA, UnityEngine.Rendering.MSAASamples msaaSamples, System.Boolean dynamicRes) { }
        private System.String GetRenderTargetAutoName(System.Int32 width, System.Int32 height, System.Int32 depth, System.String format, UnityEngine.Rendering.TextureDimension dim, System.String name, System.Boolean mips, System.Boolean enableMSAA, UnityEngine.Rendering.MSAASamples msaaSamples, System.Boolean dynamicRes) { }
        private System.String GetTextureAutoName(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat format, UnityEngine.Rendering.TextureDimension dim, System.String name, System.Boolean mips, System.Int32 depth) { }
        private System.String GetTextureAutoName(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Rendering.TextureDimension dim, System.String name, System.Boolean mips, System.Int32 depth) { }
        private System.String GetTextureAutoName(System.Int32 width, System.Int32 height, System.String format, UnityEngine.Rendering.TextureDimension dim, System.String name, System.Boolean mips, System.Int32 depth) { }
        private System.Void ClearCubemap(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTexture renderTexture, UnityEngine.Color clearColor, System.Boolean clearMips) { }
        private System.Void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.MaterialPropertyBlock properties, System.Int32 shaderPassId) { }
        private System.Void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.MaterialPropertyBlock properties, System.Int32 shaderPassId) { }
        private System.Void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderTargetIdentifier depthStencilBuffer, UnityEngine.MaterialPropertyBlock properties, System.Int32 shaderPassId) { }
        private System.Void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RenderTargetIdentifier depthStencilBuffer, UnityEngine.MaterialPropertyBlock properties, System.Int32 shaderPassId) { }
        private System.Void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.MaterialPropertyBlock properties, System.Int32 shaderPassId) { }
        private UnityEngine.Color ConvertSRGBToActiveColorSpace(UnityEngine.Color color) { }
        private UnityEngine.Color ConvertLinearToActiveColorSpace(UnityEngine.Color color) { }
        private UnityEngine.Material CreateEngineMaterial(System.String shaderPath) { }
        private UnityEngine.Material CreateEngineMaterial(UnityEngine.Shader shader, System.Boolean enableInstancing) { }
        private System.Boolean HasFlag(T mask, T flag) { }
        private System.Void Swap(T& a, T& b) { }
        private System.Void SetKeyword(UnityEngine.Rendering.CommandBuffer cmd, System.String keyword, System.Boolean state) { }
        private System.Void SetKeyword(UnityEngine.Material material, System.String keyword, System.Boolean state) { }
        private System.Void SetKeyword(UnityEngine.ComputeShader cs, System.String keyword, System.Boolean state) { }
        private System.Void Destroy(UnityEngine.Object obj) { }
        private System.Collections.Generic.IEnumerable<System.Type> GetAllAssemblyTypes() { }
        private System.Collections.Generic.IEnumerable<System.Type> GetAllTypesDerivedFrom() { }
        private System.Void SafeRelease(UnityEngine.ComputeBuffer buffer) { }
        private UnityEngine.Mesh CreateCubeMesh(UnityEngine.Vector3 min, UnityEngine.Vector3 max) { }
        private System.Boolean ArePostProcessesEnabled(UnityEngine.Camera camera) { }
        private System.Boolean AreAnimatedMaterialsEnabled(UnityEngine.Camera camera) { }
        private System.Boolean IsSceneLightingDisabled(UnityEngine.Camera camera) { }
        private System.Boolean IsLightOverlapDebugEnabled(UnityEngine.Camera camera) { }
        private System.Boolean IsSceneViewFogEnabled(UnityEngine.Camera camera) { }
        private System.Boolean IsSceneFilteringEnabled() { }
        private System.Boolean IsSceneViewPrefabStageContextHidden() { }
        private System.Void DrawRendererList(UnityEngine.Rendering.ScriptableRenderContext renderContext, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Experimental.Rendering.RendererList rendererList) { }
        private System.Void DrawRendererList(UnityEngine.Rendering.ScriptableRenderContext renderContext, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RendererUtils.RendererList rendererList) { }
        private System.Int32 GetTextureHash(UnityEngine.Texture texture) { }
        private System.Int32 PreviousPowerOfTwo(System.Int32 size) { }
        private T GetLastEnumValue() { }
        private System.String GetCorePath() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000123
    public class DelegateUtility
    {
        // Methods
        private System.Delegate Cast(System.Delegate source, System.Type type) { }

    }

    // TypeToken: 0x2000124
    public class FSRUtils
    {
        // Fields
        private static System.Single kMaxSharpnessStops;        // 0x0
        public static System.Single kDefaultSharpnessStops;        // 0x0
        public static System.Single kDefaultSharpnessLinear;        // 0x0

        // Methods
        private System.Void SetEasuConstants(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector2 inputViewportSizeInPixels, UnityEngine.Vector2 inputImageSizeInPixels, UnityEngine.Vector2 outputImageSizeInPixels) { }
        private System.Void SetRcasConstants(UnityEngine.Rendering.CommandBuffer cmd, System.Single sharpnessStops) { }
        private System.Void SetRcasConstantsLinear(UnityEngine.Rendering.CommandBuffer cmd, System.Single sharpnessLinear) { }
        private System.Boolean IsSupported() { }

    }

    // TypeToken: 0x2000126
    public class HableCurve
    {
        // Fields
        private System.Single <whitePoint>k__BackingField;        // 0x10
        private System.Single <inverseWhitePoint>k__BackingField;        // 0x14
        private System.Single <x0>k__BackingField;        // 0x18
        private System.Single <x1>k__BackingField;        // 0x1C
        public readonly UnityEngine.Rendering.HableCurve.Segment[] segments;        // 0x20
        public readonly UnityEngine.Rendering.HableCurve.Uniforms uniforms;        // 0x28

        // Methods
        private System.Single get_whitePoint() { }
        private System.Void set_whitePoint(System.Single value) { }
        private System.Single get_inverseWhitePoint() { }
        private System.Void set_inverseWhitePoint(System.Single value) { }
        private System.Single get_x0() { }
        private System.Void set_x0(System.Single value) { }
        private System.Single get_x1() { }
        private System.Void set_x1(System.Single value) { }
        private System.Void .ctor() { }
        private System.Single Eval(System.Single x) { }
        private System.Void Init(System.Single toeStrength, System.Single toeLength, System.Single shoulderStrength, System.Single shoulderLength, System.Single shoulderAngle, System.Single gamma) { }
        private System.Void InitSegments(UnityEngine.Rendering.HableCurve.DirectParams srcParams) { }
        private System.Void SolveAB(System.Single& lnA, System.Single& B, System.Single x0, System.Single y0, System.Single m) { }
        private System.Void AsSlopeIntercept(System.Single& m, System.Single& b, System.Single x0, System.Single x1, System.Single y0, System.Single y1) { }
        private System.Single EvalDerivativeLinearGamma(System.Single m, System.Single b, System.Single g, System.Single x) { }

    }

    // TypeToken: 0x200012A
    public class HaltonSequence
    {
        // Methods
        private System.Single Get(System.Int32 index, System.Int32 radix) { }

    }

    // TypeToken: 0x200012B
    public struct MaterialQuality
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.MaterialQuality Low;        // 0x0
        public static UnityEngine.Rendering.MaterialQuality Medium;        // 0x0
        public static UnityEngine.Rendering.MaterialQuality High;        // 0x0

    }

    // TypeToken: 0x200012C
    public class MaterialQualityUtilities
    {
        // Fields
        public static System.String[] KeywordNames;        // 0x0
        public static System.String[] EnumNames;        // 0x8
        public static UnityEngine.Rendering.ShaderKeyword[] Keywords;        // 0x10

        // Methods
        private UnityEngine.Rendering.MaterialQuality GetHighestQuality(UnityEngine.Rendering.MaterialQuality levels) { }
        private UnityEngine.Rendering.MaterialQuality GetClosestQuality(UnityEngine.Rendering.MaterialQuality availableLevels, UnityEngine.Rendering.MaterialQuality requestedLevel) { }
        private System.Void SetGlobalShaderKeywords(UnityEngine.Rendering.MaterialQuality level) { }
        private System.Void SetGlobalShaderKeywords(UnityEngine.Rendering.MaterialQuality level, UnityEngine.Rendering.CommandBuffer cmd) { }
        private System.Int32 ToFirstIndex(UnityEngine.Rendering.MaterialQuality level) { }
        private UnityEngine.Rendering.MaterialQuality FromIndex(System.Int32 index) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200012D
    public class MeshGizmo, IDisposable
    {
        // Fields
        public static readonly System.Int32 vertexCountPerCube;        // 0x0
        public UnityEngine.Mesh mesh;        // 0x10
        private System.Collections.Generic.List<UnityEngine.Vector3> vertices;        // 0x18
        private System.Collections.Generic.List<System.Int32> indices;        // 0x20
        private System.Collections.Generic.List<UnityEngine.Color> colors;        // 0x28
        private UnityEngine.Material wireMaterial;        // 0x30
        private UnityEngine.Material dottedWireMaterial;        // 0x38
        private UnityEngine.Material solidMaterial;        // 0x40

        // Methods
        private System.Void .ctor(System.Int32 capacity) { }
        private System.Void Clear() { }
        private System.Void AddWireCube(UnityEngine.Vector3 center, UnityEngine.Vector3 size, UnityEngine.Color color) { }
        private System.Void DrawMesh(UnityEngine.Matrix4x4 trs, UnityEngine.Material mat, UnityEngine.MeshTopology topology, UnityEngine.Rendering.CompareFunction depthTest, System.String gizmoName) { }
        private System.Void RenderWireframe(UnityEngine.Matrix4x4 trs, UnityEngine.Rendering.CompareFunction depthTest, System.String gizmoName) { }
        private System.Void Dispose() { }
        private System.Void .cctor() { }
        private System.Void <AddWireCube>g__AddEdge|10_0(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Rendering.MeshGizmo.<>c__DisplayClass10_0& ) { }

    }

    // TypeToken: 0x200012F
    public class ReloadAttribute : Attribute
    {
        // Methods
        private System.Void .ctor(System.String[] paths, UnityEngine.Rendering.ReloadAttribute.Package package) { }
        private System.Void .ctor(System.String path, UnityEngine.Rendering.ReloadAttribute.Package package) { }
        private System.Void .ctor(System.String pathFormat, System.Int32 rangeMin, System.Int32 rangeMax, UnityEngine.Rendering.ReloadAttribute.Package package) { }

    }

    // TypeToken: 0x2000131
    public class ReloadGroupAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000132
    public class TextureCurve, IDisposable
    {
        // Fields
        private static System.Int32 k_Precision;        // 0x0
        private static System.Single k_Step;        // 0x0
        private System.Int32 <length>k__BackingField;        // 0x10
        private System.Boolean m_Loop;        // 0x14
        private System.Single m_ZeroValue;        // 0x18
        private System.Single m_Range;        // 0x1C
        private UnityEngine.AnimationCurve m_Curve;        // 0x20
        private UnityEngine.AnimationCurve m_LoopingCurve;        // 0x28
        private UnityEngine.Texture2D m_Texture;        // 0x30
        private System.Boolean m_IsCurveDirty;        // 0x38
        private System.Boolean m_IsTextureDirty;        // 0x39
        private System.Int32 m_LastUpdatedFrame;        // 0x3C

        // Methods
        private System.Int32 get_length() { }
        private System.Void set_length(System.Int32 value) { }
        private System.Boolean IsTextureCurveDirty() { }
        private UnityEngine.Keyframe get_Item(System.Int32 index) { }
        private System.Void .ctor(UnityEngine.AnimationCurve baseCurve, System.Single zeroValue, System.Boolean loop, UnityEngine.Vector2& bounds) { }
        private System.Void .ctor(UnityEngine.Keyframe[] keys, System.Single zeroValue, System.Boolean loop, UnityEngine.Vector2& bounds) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Release() { }
        private System.Void SetDirty() { }
        private UnityEngine.Experimental.Rendering.GraphicsFormat GetTextureFormat() { }
        private UnityEngine.Texture2D GetTexture() { }
        private System.Single Evaluate(System.Single time) { }
        private System.Int32 AddKey(System.Single time, System.Single value) { }
        private System.Int32 MoveKey(System.Int32 index, UnityEngine.Keyframe& key) { }
        private System.Void RemoveKey(System.Int32 index) { }
        private System.Void SmoothTangents(System.Int32 index, System.Single weight) { }

    }

    // TypeToken: 0x2000133
    public class TextureCurveParameter : VolumeParameter`1
    {
        // Methods
        private System.Void .ctor(UnityEngine.Rendering.TextureCurve value, System.Boolean overrideState) { }
        private System.Void Release() { }

    }

    // TypeToken: 0x2000134
    public class TileLayoutUtils
    {
        // Methods
        private System.Boolean TryLayoutByTiles(UnityEngine.RectInt src, System.UInt32 tileSize, UnityEngine.RectInt& main, UnityEngine.RectInt& topRow, UnityEngine.RectInt& rightCol, UnityEngine.RectInt& topRight) { }
        private System.Boolean TryLayoutByRow(UnityEngine.RectInt src, System.UInt32 tileSize, UnityEngine.RectInt& main, UnityEngine.RectInt& other) { }
        private System.Boolean TryLayoutByCol(UnityEngine.RectInt src, System.UInt32 tileSize, UnityEngine.RectInt& main, UnityEngine.RectInt& other) { }

    }

    // TypeToken: 0x2000135
    public class XRUtils
    {
        // Methods
        private System.Void DrawOcclusionMesh(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Camera camera, System.Boolean stereoEnabled) { }

    }

    // TypeToken: 0x2000136
    public interface IVolume
    {
        // Methods
        private System.Boolean get_isGlobal() { }
        private System.Void set_isGlobal(System.Boolean value) { }
        private System.Collections.Generic.List<UnityEngine.Collider> get_colliders() { }

    }

    // TypeToken: 0x2000137
    public class Volume : MonoBehaviour, IVolume
    {
        // Fields
        private System.Boolean m_IsGlobal;        // 0x18
        public System.Boolean isLunaPlatform;        // 0x19
        public System.Single priority;        // 0x1C
        public System.Single blendDistance;        // 0x20
        public System.Single weight;        // 0x24
        public UnityEngine.Rendering.VolumeProfile sharedProfile;        // 0x28
        private System.Collections.Generic.List<UnityEngine.Collider> m_Colliders;        // 0x30
        private System.Int32 m_PreviousLayer;        // 0x38
        private System.Single m_PreviousPriority;        // 0x3C
        private UnityEngine.Rendering.VolumeProfile m_InternalProfile;        // 0x40

        // Methods
        private System.Boolean get_isGlobal() { }
        private System.Void set_isGlobal(System.Boolean value) { }
        private UnityEngine.Rendering.VolumeProfile GetInstantiatedProfile() { }
        private System.Void SetInstantiatedProfile(UnityEngine.Rendering.VolumeProfile profile) { }
        private System.Collections.Generic.List<UnityEngine.Collider> get_colliders() { }
        private UnityEngine.Rendering.VolumeProfile get_profileRef() { }
        private System.Boolean HasInstantiatedProfile() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Update() { }
        private System.Void UpdateLayer() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000138
    public class VolumeComponentMenu : Attribute
    {
        // Fields
        public readonly System.String menu;        // 0x10

        // Methods
        private System.Void .ctor(System.String menu) { }

    }

    // TypeToken: 0x2000139
    public class VolumeComponentMenuForRenderPipeline : VolumeComponentMenu
    {
        // Fields
        private readonly System.Type[] <pipelineTypes>k__BackingField;        // 0x18

        // Methods
        private System.Type[] get_pipelineTypes() { }
        private System.Void .ctor(System.String menu, System.Type[] pipelineTypes) { }

    }

    // TypeToken: 0x200013A
    public class VolumeComponentDeprecated : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200013B
    public class MigratingVolumeComponent : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200013C
    public class VolumeComponent : ScriptableObject
    {
        // Fields
        public System.Boolean active;        // 0x18
        private System.String <displayName>k__BackingField;        // 0x20
        private UnityEngine.Rendering.VolumeParameter[] <parameters>k__BackingField;        // 0x28

        // Methods
        private System.String get_displayName() { }
        private System.Void set_displayName(System.String value) { }
        private UnityEngine.Rendering.VolumeParameter[] get_parameters() { }
        private System.Void set_parameters(UnityEngine.Rendering.VolumeParameter[] value) { }
        private System.Void FindParameters(System.Object o, System.Collections.Generic.List<UnityEngine.Rendering.VolumeParameter> parameters, System.Func<System.Reflection.FieldInfo,System.Boolean> filter) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Override(UnityEngine.Rendering.VolumeComponent state, System.Single interpFactor) { }
        private System.Void SetAllOverridesTo(System.Boolean state) { }
        private System.Void SetOverridesTo(System.Collections.Generic.IEnumerable<UnityEngine.Rendering.VolumeParameter> enumerable, System.Boolean state) { }
        private System.Int32 GetHashCode() { }
        private System.Void OnDestroy() { }
        private System.Void Release() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200013F
    public class VolumeManager
    {
        // Fields
        private static readonly System.Lazy<UnityEngine.Rendering.VolumeManager> s_Instance;        // 0x0
        private UnityEngine.Rendering.VolumeStack <stack>k__BackingField;        // 0x10
        private System.Type[] <baseComponentTypeArray>k__BackingField;        // 0x18
        private static System.Int32 k_MaxLayerCount;        // 0x0
        private readonly System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<UnityEngine.Rendering.Volume>> m_SortedVolumes;        // 0x20
        private readonly System.Collections.Generic.List<UnityEngine.Rendering.Volume> m_Volumes;        // 0x28
        private readonly System.Collections.Generic.Dictionary<System.Int32,System.Boolean> m_SortNeeded;        // 0x30
        private readonly System.Collections.Generic.List<UnityEngine.Rendering.VolumeComponent> m_ComponentsDefaultState;        // 0x38
        private readonly System.Collections.Generic.List<UnityEngine.Collider> m_TempColliders;        // 0x40
        private UnityEngine.Rendering.VolumeStack m_DefaultStack;        // 0x48

        // Methods
        private UnityEngine.Rendering.VolumeManager get_instance() { }
        private UnityEngine.Rendering.VolumeStack get_stack() { }
        private System.Void set_stack(UnityEngine.Rendering.VolumeStack value) { }
        private System.Collections.Generic.IEnumerable<System.Type> get_baseComponentTypes() { }
        private System.Void set_baseComponentTypes(System.Collections.Generic.IEnumerable<System.Type> value) { }
        private System.Type[] get_baseComponentTypeArray() { }
        private System.Void set_baseComponentTypeArray(System.Type[] value) { }
        private System.Void .ctor() { }
        private UnityEngine.Rendering.VolumeStack CreateStack() { }
        private System.Void ResetMainStack() { }
        private System.Void DestroyStack(UnityEngine.Rendering.VolumeStack stack) { }
        private System.Void ReloadBaseTypes() { }
        private System.Void Register(UnityEngine.Rendering.Volume volume, System.Int32 layer) { }
        private System.Void Unregister(UnityEngine.Rendering.Volume volume, System.Int32 layer) { }
        private System.Boolean IsComponentActiveInMask(UnityEngine.LayerMask layerMask) { }
        private System.Void SetLayerDirty(System.Int32 layer) { }
        private System.Void UpdateVolumeLayer(UnityEngine.Rendering.Volume volume, System.Int32 prevLayer, System.Int32 newLayer) { }
        private System.Void OverrideData(UnityEngine.Rendering.VolumeStack stack, System.Collections.Generic.List<UnityEngine.Rendering.VolumeComponent> components, System.Single interpFactor) { }
        private System.Void ReplaceData(UnityEngine.Rendering.VolumeStack stack) { }
        private System.Void CheckBaseTypes() { }
        private System.Void CheckStack(UnityEngine.Rendering.VolumeStack stack) { }
        private System.Boolean CheckUpdateRequired(UnityEngine.Rendering.VolumeStack stack) { }
        private System.Void Update(UnityEngine.Transform trigger, UnityEngine.LayerMask layerMask) { }
        private System.Void Update(UnityEngine.Rendering.VolumeStack stack, UnityEngine.Transform trigger, UnityEngine.LayerMask layerMask) { }
        private UnityEngine.Rendering.Volume[] GetVolumes(UnityEngine.LayerMask layerMask) { }
        private System.Collections.Generic.List<UnityEngine.Rendering.Volume> GrabVolumes(UnityEngine.LayerMask mask) { }
        private System.Void SortByPriority(System.Collections.Generic.List<UnityEngine.Rendering.Volume> volumes) { }
        private System.Boolean IsVolumeRenderedByCamera(UnityEngine.Rendering.Volume volume, UnityEngine.Camera camera) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000141
    public struct VolumeIsolationScope, IDisposable
    {
        // Methods
        private System.Void .ctor(System.Boolean unused) { }
        private System.Void System.IDisposable.Dispose() { }

    }

    // TypeToken: 0x2000142
    public class VolumeParameter
    {
        // Fields
        public static System.String k_DebuggerDisplay;        // 0x0
        public System.Boolean overrideState;        // 0x10

        // Methods
        private System.Void Interp(UnityEngine.Rendering.VolumeParameter from, UnityEngine.Rendering.VolumeParameter to, System.Single t) { }
        private T GetValue() { }
        private System.Void SetValue(UnityEngine.Rendering.VolumeParameter parameter) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Release() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000143
    public class VolumeParameter`1 : VolumeParameter, IEquatable`1
    {
        // Fields
        protected T m_Value;        // 0x0

        // Methods
        private T get_value() { }
        private System.Void set_value(T value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(T value, System.Boolean overrideState) { }
        private System.Void Interp(UnityEngine.Rendering.VolumeParameter from, UnityEngine.Rendering.VolumeParameter to, System.Single t) { }
        private System.Void Interp(T from, T to, System.Single t) { }
        private System.Void Override(T x) { }
        private System.Void SetValue(UnityEngine.Rendering.VolumeParameter parameter) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Boolean op_Equality(UnityEngine.Rendering.VolumeParameter<T> lhs, T rhs) { }
        private System.Boolean op_Inequality(UnityEngine.Rendering.VolumeParameter<T> lhs, T rhs) { }
        private System.Boolean Equals(UnityEngine.Rendering.VolumeParameter<T> other) { }
        private System.Boolean Equals(System.Object obj) { }
        private T op_Explicit(UnityEngine.Rendering.VolumeParameter<T> prop) { }

    }

    // TypeToken: 0x2000144
    public class BoolParameter : VolumeParameter`1
    {
        // Methods
        private System.Void .ctor(System.Boolean value, System.Boolean overrideState) { }

    }

    // TypeToken: 0x2000145
    public class LayerMaskParameter : VolumeParameter`1
    {
        // Methods
        private System.Void .ctor(UnityEngine.LayerMask value, System.Boolean overrideState) { }

    }

    // TypeToken: 0x2000146
    public class IntParameter : VolumeParameter`1
    {
        // Methods
        private System.Void .ctor(System.Int32 value, System.Boolean overrideState) { }
        private System.Void Interp(System.Int32 from, System.Int32 to, System.Single t) { }

    }

    // TypeToken: 0x2000147
    public class NoInterpIntParameter : VolumeParameter`1
    {
        // Methods
        private System.Void .ctor(System.Int32 value, System.Boolean overrideState) { }

    }

    // TypeToken: 0x2000148
    public class MinIntParameter : IntParameter
    {
        // Fields
        public System.Int32 min;        // 0x20

        // Methods
        private System.Int32 get_value() { }
        private System.Void set_value(System.Int32 value) { }
        private System.Void .ctor(System.Int32 value, System.Int32 min, System.Boolean overrideState) { }

    }

    // TypeToken: 0x2000149
    public class NoInterpMinIntParameter : VolumeParameter`1
    {
        // Fields
        public System.Int32 min;        // 0x20

        // Methods
        private System.Int32 get_value() { }
        private System.Void set_value(System.Int32 value) { }
        private System.Void .ctor(System.Int32 value, System.Int32 min, System.Boolean overrideState) { }

    }

    // TypeToken: 0x200014A
    public class MaxIntParameter : IntParameter
    {
        // Fields
        public System.Int32 max;        // 0x20

        // Methods
        private System.Int32 get_value() { }
        private System.Void set_value(System.Int32 value) { }
        private System.Void .ctor(System.Int32 value, System.Int32 max, System.Boolean overrideState) { }

    }

    // TypeToken: 0x200014B
    public class NoInterpMaxIntParameter : VolumeParameter`1
    {
        // Fields
        public System.Int32 max;        // 0x20

        // Methods
        private System.Int32 get_value() { }
        private System.Void set_value(System.Int32 value) { }
        private System.Void .ctor(System.Int32 value, System.Int32 max, System.Boolean overrideState) { }

    }

    // TypeToken: 0x200014C
    public class ClampedIntParameter : IntParameter
    {
        // Fields
        public System.Int32 min;        // 0x20
        public System.Int32 max;        // 0x24

        // Methods
        private System.Int32 get_value() { }
        private System.Void set_value(System.Int32 value) { }
        private System.Void .ctor(System.Int32 value, System.Int32 min, System.Int32 max, System.Boolean overrideState) { }

    }

    // TypeToken: 0x200014D
    public class NoInterpClampedIntParameter : VolumeParameter`1
    {
        // Fields
        public System.Int32 min;        // 0x20
        public System.Int32 max;        // 0x24

        // Methods
        private System.Int32 get_value() { }
        private System.Void set_value(System.Int32 value) { }
        private System.Void .ctor(System.Int32 value, System.Int32 min, System.Int32 max, System.Boolean overrideState) { }

    }

    // TypeToken: 0x200014E
    public class FloatParameter : VolumeParameter`1
    {
        // Methods
        private System.Void .ctor(System.Single value, System.Boolean overrideState) { }
        private System.Void Interp(System.Single from, System.Single to, System.Single t) { }

    }

    // TypeToken: 0x200014F
    public class NoInterpFloatParameter : VolumeParameter`1
    {
        // Methods
        private System.Void .ctor(System.Single value, System.Boolean overrideState) { }

    }

    // TypeToken: 0x2000150
    public class MinFloatParameter : FloatParameter
    {
        // Fields
        public System.Single min;        // 0x20

        // Methods
        private System.Single get_value() { }
        private System.Void set_value(System.Single value) { }
        private System.Void .ctor(System.Single value, System.Single min, System.Boolean overrideState) { }

    }

    // TypeToken: 0x2000151
    public class NoInterpMinFloatParameter : VolumeParameter`1
    {
        // Fields
        public System.Single min;        // 0x20

        // Methods
        private System.Single get_value() { }
        private System.Void set_value(System.Single value) { }
        private System.Void .ctor(System.Single value, System.Single min, System.Boolean overrideState) { }

    }

    // TypeToken: 0x2000152
    public class MaxFloatParameter : FloatParameter
    {
        // Fields
        public System.Single max;        // 0x20

        // Methods
        private System.Single get_value() { }
        private System.Void set_value(System.Single value) { }
        private System.Void .ctor(System.Single value, System.Single max, System.Boolean overrideState) { }

    }

    // TypeToken: 0x2000153
    public class NoInterpMaxFloatParameter : VolumeParameter`1
    {
        // Fields
        public System.Single max;        // 0x20

        // Methods
        private System.Single get_value() { }
        private System.Void set_value(System.Single value) { }
        private System.Void .ctor(System.Single value, System.Single max, System.Boolean overrideState) { }

    }

    // TypeToken: 0x2000154
    public class ClampedFloatParameter : FloatParameter
    {
        // Fields
        public System.Single min;        // 0x20
        public System.Single max;        // 0x24
        public System.Single sliderExponent;        // 0x28

        // Methods
        private System.Single get_value() { }
        private System.Void set_value(System.Single value) { }
        private System.Void .ctor(System.Single value, System.Single min, System.Single max, System.Single sliderExponent, System.Boolean overrideState) { }
        private System.Void .ctor(System.Single value, System.Single min, System.Single max, System.Boolean overrideState) { }

    }

    // TypeToken: 0x2000155
    public class NoInterpClampedFloatParameter : VolumeParameter`1
    {
        // Fields
        public System.Single min;        // 0x20
        public System.Single max;        // 0x24
        public System.Single sliderExponent;        // 0x28

        // Methods
        private System.Single get_value() { }
        private System.Void set_value(System.Single value) { }
        private System.Void .ctor(System.Single value, System.Single min, System.Single max, System.Single sliderExponent, System.Boolean overrideState) { }
        private System.Void .ctor(System.Single value, System.Single min, System.Single max, System.Boolean overrideState) { }

    }

    // TypeToken: 0x2000156
    public class UnclampedFloatParameter : FloatParameter
    {
        // Fields
        public System.Single min;        // 0x20
        public System.Single max;        // 0x24
        public System.Single sliderExponent;        // 0x28

        // Methods
        private System.Single get_value() { }
        private System.Void set_value(System.Single value) { }
        private System.Void .ctor(System.Single value, System.Single min, System.Single max, System.Single sliderExponent, System.Boolean overrideState) { }
        private System.Void .ctor(System.Single value, System.Single min, System.Single max, System.Boolean overrideState) { }

    }

    // TypeToken: 0x2000157
    public class NoInterpUnclampedFloatParameter : VolumeParameter`1
    {
        // Fields
        public System.Single min;        // 0x20
        public System.Single max;        // 0x24
        public System.Single sliderExponent;        // 0x28

        // Methods
        private System.Single get_value() { }
        private System.Void set_value(System.Single value) { }
        private System.Void .ctor(System.Single value, System.Single min, System.Single max, System.Single sliderExponent, System.Boolean overrideState) { }
        private System.Void .ctor(System.Single value, System.Single min, System.Single max, System.Boolean overrideState) { }

    }

    // TypeToken: 0x2000158
    public class FloatRangeParameter : VolumeParameter`1
    {
        // Fields
        public System.Single min;        // 0x20
        public System.Single max;        // 0x24

        // Methods
        private UnityEngine.Vector2 get_value() { }
        private System.Void set_value(UnityEngine.Vector2 value) { }
        private System.Void .ctor(UnityEngine.Vector2 value, System.Single min, System.Single max, System.Boolean overrideState) { }
        private System.Void Interp(UnityEngine.Vector2 from, UnityEngine.Vector2 to, System.Single t) { }

    }

    // TypeToken: 0x2000159
    public class NoInterpFloatRangeParameter : VolumeParameter`1
    {
        // Fields
        public System.Single min;        // 0x20
        public System.Single max;        // 0x24

        // Methods
        private UnityEngine.Vector2 get_value() { }
        private System.Void set_value(UnityEngine.Vector2 value) { }
        private System.Void .ctor(UnityEngine.Vector2 value, System.Single min, System.Single max, System.Boolean overrideState) { }

    }

    // TypeToken: 0x200015A
    public class ColorParameter : VolumeParameter`1
    {
        // Fields
        public System.Boolean hdr;        // 0x28
        public System.Boolean showAlpha;        // 0x29
        public System.Boolean showEyeDropper;        // 0x2A

        // Methods
        private System.Void .ctor(UnityEngine.Color value, System.Boolean overrideState) { }
        private System.Void .ctor(UnityEngine.Color value, System.Boolean hdr, System.Boolean showAlpha, System.Boolean showEyeDropper, System.Boolean overrideState) { }
        private System.Void Interp(UnityEngine.Color from, UnityEngine.Color to, System.Single t) { }

    }

    // TypeToken: 0x200015B
    public class NoInterpColorParameter : VolumeParameter`1
    {
        // Fields
        public System.Boolean hdr;        // 0x28
        public System.Boolean showAlpha;        // 0x29
        public System.Boolean showEyeDropper;        // 0x2A

        // Methods
        private System.Void .ctor(UnityEngine.Color value, System.Boolean overrideState) { }
        private System.Void .ctor(UnityEngine.Color value, System.Boolean hdr, System.Boolean showAlpha, System.Boolean showEyeDropper, System.Boolean overrideState) { }

    }

    // TypeToken: 0x200015C
    public class Vector2Parameter : VolumeParameter`1
    {
        // Methods
        private System.Void .ctor(UnityEngine.Vector2 value, System.Boolean overrideState) { }
        private System.Void Interp(UnityEngine.Vector2 from, UnityEngine.Vector2 to, System.Single t) { }

    }

    // TypeToken: 0x200015D
    public class NoInterpVector2Parameter : VolumeParameter`1
    {
        // Methods
        private System.Void .ctor(UnityEngine.Vector2 value, System.Boolean overrideState) { }

    }

    // TypeToken: 0x200015E
    public class Vector3Parameter : VolumeParameter`1
    {
        // Methods
        private System.Void .ctor(UnityEngine.Vector3 value, System.Boolean overrideState) { }
        private System.Void Interp(UnityEngine.Vector3 from, UnityEngine.Vector3 to, System.Single t) { }

    }

    // TypeToken: 0x200015F
    public class NoInterpVector3Parameter : VolumeParameter`1
    {
        // Methods
        private System.Void .ctor(UnityEngine.Vector3 value, System.Boolean overrideState) { }

    }

    // TypeToken: 0x2000160
    public class Vector4Parameter : VolumeParameter`1
    {
        // Methods
        private System.Void .ctor(UnityEngine.Vector4 value, System.Boolean overrideState) { }
        private System.Void Interp(UnityEngine.Vector4 from, UnityEngine.Vector4 to, System.Single t) { }

    }

    // TypeToken: 0x2000161
    public class NoInterpVector4Parameter : VolumeParameter`1
    {
        // Methods
        private System.Void .ctor(UnityEngine.Vector4 value, System.Boolean overrideState) { }

    }

    // TypeToken: 0x2000162
    public class TextureParameter : VolumeParameter`1
    {
        // Fields
        public UnityEngine.Rendering.TextureDimension dimension;        // 0x20

        // Methods
        private System.Void .ctor(UnityEngine.Texture value, System.Boolean overrideState) { }
        private System.Void .ctor(UnityEngine.Texture value, UnityEngine.Rendering.TextureDimension dimension, System.Boolean overrideState) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000163
    public class NoInterpTextureParameter : VolumeParameter`1
    {
        // Methods
        private System.Void .ctor(UnityEngine.Texture value, System.Boolean overrideState) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000164
    public class Texture2DParameter : VolumeParameter`1
    {
        // Methods
        private System.Void .ctor(UnityEngine.Texture value, System.Boolean overrideState) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000165
    public class Texture3DParameter : VolumeParameter`1
    {
        // Methods
        private System.Void .ctor(UnityEngine.Texture value, System.Boolean overrideState) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000166
    public class RenderTextureParameter : VolumeParameter`1
    {
        // Methods
        private System.Void .ctor(UnityEngine.RenderTexture value, System.Boolean overrideState) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000167
    public class NoInterpRenderTextureParameter : VolumeParameter`1
    {
        // Methods
        private System.Void .ctor(UnityEngine.RenderTexture value, System.Boolean overrideState) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000168
    public class CubemapParameter : VolumeParameter`1
    {
        // Methods
        private System.Void .ctor(UnityEngine.Texture value, System.Boolean overrideState) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000169
    public class NoInterpCubemapParameter : VolumeParameter`1
    {
        // Methods
        private System.Void .ctor(UnityEngine.Cubemap value, System.Boolean overrideState) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200016A
    public class AnimationCurveParameter : VolumeParameter`1
    {
        // Methods
        private System.Void .ctor(UnityEngine.AnimationCurve value, System.Boolean overrideState) { }

    }

    // TypeToken: 0x200016B
    public class VolumeProfile : ScriptableObject
    {
        // Fields
        public System.Collections.Generic.List<UnityEngine.Rendering.VolumeComponent> components;        // 0x18
        public System.Boolean isDirty;        // 0x20

        // Methods
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Reset() { }
        private T Add(System.Boolean overrides) { }
        private UnityEngine.Rendering.VolumeComponent Add(System.Type type, System.Boolean overrides) { }
        private System.Void Remove() { }
        private System.Void Remove(System.Type type) { }
        private System.Boolean Has() { }
        private System.Boolean Has(System.Type type) { }
        private System.Boolean HasSubclassOf(System.Type type) { }
        private System.Boolean TryGet(T& component) { }
        private System.Boolean TryGet(System.Type type, T& component) { }
        private System.Boolean TryGetSubclassOf(System.Type type, T& component) { }
        private System.Boolean TryGetAllSubclassOf(System.Type type, System.Collections.Generic.List<T> result) { }
        private System.Int32 GetHashCode() { }
        private System.Int32 GetComponentListHashCode() { }
        private System.Void Sanitize() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200016D
    public class VolumeStack, IDisposable
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<System.Type,UnityEngine.Rendering.VolumeComponent> components;        // 0x10
        public System.ValueTuple<UnityEngine.Rendering.VolumeParameter,UnityEngine.Rendering.VolumeParameter>[] defaultParameters;        // 0x18
        private System.Boolean requiresReset;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.Void Reload(System.Collections.Generic.List<UnityEngine.Rendering.VolumeComponent> componentDefaultStates) { }
        private T GetComponent() { }
        private UnityEngine.Rendering.VolumeComponent GetComponent(System.Type type) { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x200016E
    public class XRGraphicsAutomatedTests
    {
        // Fields
        private static readonly System.Boolean <enabled>k__BackingField;        // 0x0
        public static System.Boolean running;        // 0x1

        // Methods
        private System.Boolean get_activatedFromCommandLine() { }
        private System.Boolean get_enabled() { }
        private System.Void .cctor() { }

    }

}

namespace UnityEngine.Rendering.LookDev
{

    // TypeToken: 0x200016F
    public interface IDataProvider
    {
        // Methods
        private System.Void FirstInitScene(UnityEngine.Rendering.LookDev.StageRuntimeInterface stage) { }
        private System.Void UpdateSky(UnityEngine.Camera camera, UnityEngine.Rendering.LookDev.Sky sky, UnityEngine.Rendering.LookDev.StageRuntimeInterface stage) { }
        private System.Collections.Generic.IEnumerable<System.String> get_supportedDebugModes() { }
        private System.Void UpdateDebugMode(System.Int32 debugIndex) { }
        private System.Void GetShadowMask(UnityEngine.RenderTexture& output, UnityEngine.Rendering.LookDev.StageRuntimeInterface stage) { }
        private System.Void OnBeginRendering(UnityEngine.Rendering.LookDev.StageRuntimeInterface stage) { }
        private System.Void OnEndRendering(UnityEngine.Rendering.LookDev.StageRuntimeInterface stage) { }
        private System.Void Cleanup(UnityEngine.Rendering.LookDev.StageRuntimeInterface SRI) { }

    }

    // TypeToken: 0x2000170
    public struct Sky
    {
        // Fields
        public UnityEngine.Cubemap cubemap;        // 0x10
        public System.Single longitudeOffset;        // 0x18
        public System.Single exposure;        // 0x1C

    }

    // TypeToken: 0x2000171
    public class StageRuntimeInterface
    {
        // Fields
        private System.Func<System.Boolean,UnityEngine.GameObject> m_AddGameObject;        // 0x10
        private System.Func<UnityEngine.Camera> m_GetCamera;        // 0x18
        private System.Func<UnityEngine.Light> m_GetSunLight;        // 0x20
        public System.Object SRPData;        // 0x28

        // Methods
        private System.Void .ctor(System.Func<System.Boolean,UnityEngine.GameObject> AddGameObject, System.Func<UnityEngine.Camera> GetCamera, System.Func<UnityEngine.Light> GetSunLight) { }
        private UnityEngine.GameObject AddGameObject(System.Boolean persistent) { }
        private UnityEngine.Camera get_camera() { }
        private UnityEngine.Light get_sunLight() { }

    }

}

namespace UnityEngine.Rendering.UI
{

    // TypeToken: 0x2000172
    public class DebugUIHandlerBitField : DebugUIHandlerWidget
    {
        // Fields
        public UnityEngine.UI.Text nameLabel;        // 0x58
        public UnityEngine.Rendering.UI.UIFoldout valueToggle;        // 0x60
        public System.Collections.Generic.List<UnityEngine.Rendering.UI.DebugUIHandlerIndirectToggle> toggles;        // 0x68
        private UnityEngine.Rendering.DebugUI.BitField m_Field;        // 0x70
        private UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;        // 0x78

        // Methods
        private System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget) { }
        private System.Boolean GetValue(System.Int32 index) { }
        private System.Void SetValue(System.Int32 index, System.Boolean value) { }
        private System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous) { }
        private System.Void OnDeselection() { }
        private System.Void OnIncrement(System.Boolean fast) { }
        private System.Void OnDecrement(System.Boolean fast) { }
        private System.Void OnAction() { }
        private UnityEngine.Rendering.UI.DebugUIHandlerWidget Next() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000173
    public class DebugUIHandlerButton : DebugUIHandlerWidget
    {
        // Fields
        public UnityEngine.UI.Text nameLabel;        // 0x58
        private UnityEngine.Rendering.DebugUI.Button m_Field;        // 0x60

        // Methods
        private System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget) { }
        private System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous) { }
        private System.Void OnDeselection() { }
        private System.Void OnAction() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000174
    public class DebugUIPrefabBundle
    {
        // Fields
        public System.String type;        // 0x10
        public UnityEngine.RectTransform prefab;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000175
    public class DebugUIHandlerCanvas : MonoBehaviour
    {
        // Fields
        private System.Int32 m_DebugTreeState;        // 0x18
        private System.Collections.Generic.Dictionary<System.Type,UnityEngine.Transform> m_PrefabsMap;        // 0x20
        public UnityEngine.Transform panelPrefab;        // 0x28
        public System.Collections.Generic.List<UnityEngine.Rendering.UI.DebugUIPrefabBundle> prefabs;        // 0x30
        private System.Collections.Generic.List<UnityEngine.Rendering.UI.DebugUIHandlerPanel> m_UIPanels;        // 0x38
        private System.Int32 m_SelectedPanel;        // 0x40
        private UnityEngine.Rendering.UI.DebugUIHandlerWidget m_SelectedWidget;        // 0x48
        private System.String m_CurrentQueryPath;        // 0x50

        // Methods
        private System.Void OnEnable() { }
        private System.Void Update() { }
        private System.Void RequestHierarchyReset() { }
        private System.Void ResetAllHierarchy() { }
        private System.Void Rebuild() { }
        private System.Void Traverse(UnityEngine.Rendering.DebugUI.IContainer container, UnityEngine.Transform parentTransform, UnityEngine.Rendering.UI.DebugUIHandlerWidget parentUIHandler, UnityEngine.Rendering.UI.DebugUIHandlerWidget& selectedHandler) { }
        private UnityEngine.Rendering.UI.DebugUIHandlerWidget GetWidgetFromPath(System.String queryPath) { }
        private System.Void ActivatePanel(System.Int32 index, UnityEngine.Rendering.UI.DebugUIHandlerWidget selectedWidget) { }
        private System.Void ChangeSelection(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget, System.Boolean fromNext) { }
        private System.Void SelectPreviousItem() { }
        private System.Void SelectNextPanel() { }
        private System.Void SelectPreviousPanel() { }
        private System.Void SelectNextItem() { }
        private System.Void ChangeSelectionValue(System.Single multiplier) { }
        private System.Void ActivateSelection() { }
        private System.Void HandleInput() { }
        private System.Void SetScrollTarget(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000178
    public class DebugUIHandlerColor : DebugUIHandlerWidget
    {
        // Fields
        public UnityEngine.UI.Text nameLabel;        // 0x58
        public UnityEngine.Rendering.UI.UIFoldout valueToggle;        // 0x60
        public UnityEngine.UI.Image colorImage;        // 0x68
        public UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldR;        // 0x70
        public UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldG;        // 0x78
        public UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldB;        // 0x80
        public UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldA;        // 0x88
        private UnityEngine.Rendering.DebugUI.ColorField m_Field;        // 0x90
        private UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;        // 0x98

        // Methods
        private System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget) { }
        private System.Void SetValue(System.Single x, System.Boolean r, System.Boolean g, System.Boolean b, System.Boolean a) { }
        private System.Void SetupSettings(UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField field) { }
        private System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous) { }
        private System.Void OnDeselection() { }
        private System.Void OnIncrement(System.Boolean fast) { }
        private System.Void OnDecrement(System.Boolean fast) { }
        private System.Void OnAction() { }
        private System.Void UpdateColor() { }
        private UnityEngine.Rendering.UI.DebugUIHandlerWidget Next() { }
        private System.Void .ctor() { }
        private System.Single <SetWidget>b__9_0() { }
        private System.Void <SetWidget>b__9_1(System.Single x) { }
        private System.Single <SetWidget>b__9_2() { }
        private System.Void <SetWidget>b__9_3(System.Single x) { }
        private System.Single <SetWidget>b__9_4() { }
        private System.Void <SetWidget>b__9_5(System.Single x) { }
        private System.Single <SetWidget>b__9_6() { }
        private System.Void <SetWidget>b__9_7(System.Single x) { }
        private System.Single <SetupSettings>b__11_0() { }
        private System.Single <SetupSettings>b__11_1() { }
        private System.Single <SetupSettings>b__11_2() { }

    }

    // TypeToken: 0x2000179
    public class DebugUIHandlerContainer : MonoBehaviour
    {
        // Fields
        public UnityEngine.RectTransform contentHolder;        // 0x18

        // Methods
        private UnityEngine.Rendering.UI.DebugUIHandlerWidget GetFirstItem() { }
        private UnityEngine.Rendering.UI.DebugUIHandlerWidget GetLastItem() { }
        private System.Boolean IsDirectChild(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget) { }
        private System.Collections.Generic.List<UnityEngine.Rendering.UI.DebugUIHandlerWidget> GetActiveChildren() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200017B
    public class DebugUIHandlerEnumField : DebugUIHandlerWidget
    {
        // Fields
        public UnityEngine.UI.Text nextButtonText;        // 0x58
        public UnityEngine.UI.Text previousButtonText;        // 0x60
        public UnityEngine.UI.Text nameLabel;        // 0x68
        public UnityEngine.UI.Text valueLabel;        // 0x70
        protected internal UnityEngine.Rendering.DebugUI.EnumField m_Field;        // 0x78

        // Methods
        private System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget) { }
        private System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous) { }
        private System.Void OnDeselection() { }
        private System.Void OnAction() { }
        private System.Void OnIncrement(System.Boolean fast) { }
        private System.Void OnDecrement(System.Boolean fast) { }
        private System.Void UpdateValueLabel() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200017C
    public class DebugUIHandlerEnumHistory : DebugUIHandlerEnumField
    {
        // Fields
        private UnityEngine.UI.Text[] historyValues;        // 0x80
        private static System.Single xDecal;        // 0x0

        // Methods
        private System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget) { }
        private System.Void UpdateValueLabel() { }
        private System.Collections.IEnumerator RefreshAfterSanitization() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200017E
    public class DebugUIHandlerFloatField : DebugUIHandlerWidget
    {
        // Fields
        public UnityEngine.UI.Text nameLabel;        // 0x58
        public UnityEngine.UI.Text valueLabel;        // 0x60
        private UnityEngine.Rendering.DebugUI.FloatField m_Field;        // 0x68

        // Methods
        private System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget) { }
        private System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous) { }
        private System.Void OnDeselection() { }
        private System.Void OnIncrement(System.Boolean fast) { }
        private System.Void OnDecrement(System.Boolean fast) { }
        private System.Void ChangeValue(System.Boolean fast, System.Single multiplier) { }
        private System.Void UpdateValueLabel() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200017F
    public class DebugUIHandlerFoldout : DebugUIHandlerWidget
    {
        // Fields
        public UnityEngine.UI.Text nameLabel;        // 0x58
        public UnityEngine.Rendering.UI.UIFoldout valueToggle;        // 0x60
        private UnityEngine.Rendering.DebugUI.Foldout m_Field;        // 0x68
        private UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;        // 0x70
        private static System.Single xDecal;        // 0x0
        private static System.Single xDecalInit;        // 0x0

        // Methods
        private System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget) { }
        private System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous) { }
        private System.Void OnDeselection() { }
        private System.Void OnIncrement(System.Boolean fast) { }
        private System.Void OnDecrement(System.Boolean fast) { }
        private System.Void OnAction() { }
        private System.Void UpdateValue() { }
        private UnityEngine.Rendering.UI.DebugUIHandlerWidget Next() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000180
    public class DebugUIHandlerGroup : DebugUIHandlerWidget
    {
        // Fields
        public UnityEngine.UI.Text nameLabel;        // 0x58
        public UnityEngine.Transform header;        // 0x60
        private UnityEngine.Rendering.DebugUI.Container m_Field;        // 0x68
        private UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;        // 0x70

        // Methods
        private System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget) { }
        private System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous) { }
        private UnityEngine.Rendering.UI.DebugUIHandlerWidget Next() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000181
    public class DebugUIHandlerHBox : DebugUIHandlerWidget
    {
        // Fields
        private UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;        // 0x58

        // Methods
        private System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget) { }
        private System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous) { }
        private UnityEngine.Rendering.UI.DebugUIHandlerWidget Next() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000182
    public class DebugUIHandlerIndirectFloatField : DebugUIHandlerWidget
    {
        // Fields
        public UnityEngine.UI.Text nameLabel;        // 0x58
        public UnityEngine.UI.Text valueLabel;        // 0x60
        public System.Func<System.Single> getter;        // 0x68
        public System.Action<System.Single> setter;        // 0x70
        public System.Func<System.Single> incStepGetter;        // 0x78
        public System.Func<System.Single> incStepMultGetter;        // 0x80
        public System.Func<System.Single> decimalsGetter;        // 0x88

        // Methods
        private System.Void Init() { }
        private System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous) { }
        private System.Void OnDeselection() { }
        private System.Void OnIncrement(System.Boolean fast) { }
        private System.Void OnDecrement(System.Boolean fast) { }
        private System.Void ChangeValue(System.Boolean fast, System.Single multiplier) { }
        private System.Void UpdateValueLabel() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000183
    public class DebugUIHandlerIndirectToggle : DebugUIHandlerWidget
    {
        // Fields
        public UnityEngine.UI.Text nameLabel;        // 0x58
        public UnityEngine.UI.Toggle valueToggle;        // 0x60
        public UnityEngine.UI.Image checkmarkImage;        // 0x68
        public System.Func<System.Int32,System.Boolean> getter;        // 0x70
        public System.Action<System.Int32,System.Boolean> setter;        // 0x78
        private System.Int32 index;        // 0x80

        // Methods
        private System.Void Init() { }
        private System.Void OnToggleValueChanged(System.Boolean value) { }
        private System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous) { }
        private System.Void OnDeselection() { }
        private System.Void OnAction() { }
        private System.Void UpdateValueLabel() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000184
    public class DebugUIHandlerIntField : DebugUIHandlerWidget
    {
        // Fields
        public UnityEngine.UI.Text nameLabel;        // 0x58
        public UnityEngine.UI.Text valueLabel;        // 0x60
        private UnityEngine.Rendering.DebugUI.IntField m_Field;        // 0x68

        // Methods
        private System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget) { }
        private System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous) { }
        private System.Void OnDeselection() { }
        private System.Void OnIncrement(System.Boolean fast) { }
        private System.Void OnDecrement(System.Boolean fast) { }
        private System.Void ChangeValue(System.Boolean fast, System.Int32 multiplier) { }
        private System.Void UpdateValueLabel() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000185
    public class DebugUIHandlerMessageBox : DebugUIHandlerWidget
    {
        // Fields
        public UnityEngine.UI.Text nameLabel;        // 0x58
        private UnityEngine.Rendering.DebugUI.MessageBox m_Field;        // 0x60
        private static UnityEngine.Color32 k_WarningBackgroundColor;        // 0x0
        private static UnityEngine.Color32 k_WarningTextColor;        // 0x4
        private static UnityEngine.Color32 k_ErrorBackgroundColor;        // 0x8
        private static UnityEngine.Color32 k_ErrorTextColor;        // 0xC

        // Methods
        private System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget) { }
        private System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000186
    public class DebugUIHandlerPanel : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Text nameLabel;        // 0x18
        public UnityEngine.UI.ScrollRect scrollRect;        // 0x20
        public UnityEngine.RectTransform viewport;        // 0x28
        public UnityEngine.Rendering.UI.DebugUIHandlerCanvas Canvas;        // 0x30
        private UnityEngine.RectTransform m_ScrollTransform;        // 0x38
        private UnityEngine.RectTransform m_ContentTransform;        // 0x40
        private UnityEngine.RectTransform m_MaskTransform;        // 0x48
        private UnityEngine.Rendering.UI.DebugUIHandlerWidget m_ScrollTarget;        // 0x50
        protected internal UnityEngine.Rendering.DebugUI.Panel m_Panel;        // 0x58

        // Methods
        private System.Void OnEnable() { }
        private System.Void SetPanel(UnityEngine.Rendering.DebugUI.Panel panel) { }
        private UnityEngine.Rendering.DebugUI.Panel GetPanel() { }
        private System.Void SelectNextItem() { }
        private System.Void SelectPreviousItem() { }
        private System.Void OnScrollbarClicked() { }
        private System.Void SetScrollTarget(UnityEngine.Rendering.UI.DebugUIHandlerWidget target) { }
        private System.Void UpdateScroll() { }
        private System.Single GetYPosInScroll(UnityEngine.RectTransform target) { }
        private UnityEngine.Rendering.UI.DebugUIHandlerWidget GetFirstItem() { }
        private System.Void ResetDebugManager() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000187
    public class DebugUIHandlerPersistentCanvas : MonoBehaviour
    {
        // Fields
        public UnityEngine.RectTransform panel;        // 0x18
        public UnityEngine.RectTransform valuePrefab;        // 0x20
        private System.Collections.Generic.List<UnityEngine.Rendering.UI.DebugUIHandlerValue> m_Items;        // 0x28

        // Methods
        private System.Void Toggle(UnityEngine.Rendering.DebugUI.Value widget) { }
        private System.Void Clear() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000189
    public class DebugUIHandlerRow : DebugUIHandlerFoldout
    {
        // Fields
        private System.Single m_Timer;        // 0x78

        // Methods
        private System.Void OnEnable() { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200018A
    public class DebugUIHandlerToggle : DebugUIHandlerWidget
    {
        // Fields
        public UnityEngine.UI.Text nameLabel;        // 0x58
        public UnityEngine.UI.Toggle valueToggle;        // 0x60
        public UnityEngine.UI.Image checkmarkImage;        // 0x68
        protected internal UnityEngine.Rendering.DebugUI.BoolField m_Field;        // 0x70

        // Methods
        private System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget) { }
        private System.Void OnToggleValueChanged(System.Boolean value) { }
        private System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous) { }
        private System.Void OnDeselection() { }
        private System.Void OnAction() { }
        private System.Void UpdateValueLabel() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200018B
    public class DebugUIHandlerToggleHistory : DebugUIHandlerToggle
    {
        // Fields
        private UnityEngine.UI.Toggle[] historyToggles;        // 0x78
        private static System.Single xDecal;        // 0x0

        // Methods
        private System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget) { }
        private System.Void UpdateValueLabel() { }
        private System.Collections.IEnumerator RefreshAfterSanitization() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200018D
    public class DebugUIHandlerUIntField : DebugUIHandlerWidget
    {
        // Fields
        public UnityEngine.UI.Text nameLabel;        // 0x58
        public UnityEngine.UI.Text valueLabel;        // 0x60
        private UnityEngine.Rendering.DebugUI.UIntField m_Field;        // 0x68

        // Methods
        private System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget) { }
        private System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous) { }
        private System.Void OnDeselection() { }
        private System.Void OnIncrement(System.Boolean fast) { }
        private System.Void OnDecrement(System.Boolean fast) { }
        private System.Void ChangeValue(System.Boolean fast, System.Int32 multiplier) { }
        private System.Void UpdateValueLabel() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200018E
    public class DebugUIHandlerValue : DebugUIHandlerWidget
    {
        // Fields
        public UnityEngine.UI.Text nameLabel;        // 0x58
        public UnityEngine.UI.Text valueLabel;        // 0x60
        private UnityEngine.Rendering.DebugUI.Value m_Field;        // 0x68
        private System.Single m_Timer;        // 0x70

        // Methods
        private System.Void OnEnable() { }
        private System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget) { }
        private System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous) { }
        private System.Void OnDeselection() { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200018F
    public class DebugUIHandlerVBox : DebugUIHandlerWidget
    {
        // Fields
        private UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;        // 0x58

        // Methods
        private System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget) { }
        private System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous) { }
        private UnityEngine.Rendering.UI.DebugUIHandlerWidget Next() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000190
    public class DebugUIHandlerVector2 : DebugUIHandlerWidget
    {
        // Fields
        public UnityEngine.UI.Text nameLabel;        // 0x58
        public UnityEngine.Rendering.UI.UIFoldout valueToggle;        // 0x60
        public UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldX;        // 0x68
        public UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldY;        // 0x70
        private UnityEngine.Rendering.DebugUI.Vector2Field m_Field;        // 0x78
        private UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;        // 0x80

        // Methods
        private System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget) { }
        private System.Void SetValue(System.Single v, System.Boolean x, System.Boolean y) { }
        private System.Void SetupSettings(UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField field) { }
        private System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous) { }
        private System.Void OnDeselection() { }
        private System.Void OnIncrement(System.Boolean fast) { }
        private System.Void OnDecrement(System.Boolean fast) { }
        private System.Void OnAction() { }
        private UnityEngine.Rendering.UI.DebugUIHandlerWidget Next() { }
        private System.Void .ctor() { }
        private System.Single <SetWidget>b__6_0() { }
        private System.Void <SetWidget>b__6_1(System.Single x) { }
        private System.Single <SetWidget>b__6_2() { }
        private System.Void <SetWidget>b__6_3(System.Single x) { }
        private System.Single <SetupSettings>b__8_0() { }
        private System.Single <SetupSettings>b__8_1() { }
        private System.Single <SetupSettings>b__8_2() { }

    }

    // TypeToken: 0x2000191
    public class DebugUIHandlerVector3 : DebugUIHandlerWidget
    {
        // Fields
        public UnityEngine.UI.Text nameLabel;        // 0x58
        public UnityEngine.Rendering.UI.UIFoldout valueToggle;        // 0x60
        public UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldX;        // 0x68
        public UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldY;        // 0x70
        public UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldZ;        // 0x78
        private UnityEngine.Rendering.DebugUI.Vector3Field m_Field;        // 0x80
        private UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;        // 0x88

        // Methods
        private System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget) { }
        private System.Void SetValue(System.Single v, System.Boolean x, System.Boolean y, System.Boolean z) { }
        private System.Void SetupSettings(UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField field) { }
        private System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous) { }
        private System.Void OnDeselection() { }
        private System.Void OnIncrement(System.Boolean fast) { }
        private System.Void OnDecrement(System.Boolean fast) { }
        private System.Void OnAction() { }
        private UnityEngine.Rendering.UI.DebugUIHandlerWidget Next() { }
        private System.Void .ctor() { }
        private System.Single <SetWidget>b__7_0() { }
        private System.Void <SetWidget>b__7_1(System.Single v) { }
        private System.Single <SetWidget>b__7_2() { }
        private System.Void <SetWidget>b__7_3(System.Single v) { }
        private System.Single <SetWidget>b__7_4() { }
        private System.Void <SetWidget>b__7_5(System.Single v) { }
        private System.Single <SetupSettings>b__9_0() { }
        private System.Single <SetupSettings>b__9_1() { }
        private System.Single <SetupSettings>b__9_2() { }

    }

    // TypeToken: 0x2000192
    public class DebugUIHandlerVector4 : DebugUIHandlerWidget
    {
        // Fields
        public UnityEngine.UI.Text nameLabel;        // 0x58
        public UnityEngine.Rendering.UI.UIFoldout valueToggle;        // 0x60
        public UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldX;        // 0x68
        public UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldY;        // 0x70
        public UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldZ;        // 0x78
        public UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldW;        // 0x80
        private UnityEngine.Rendering.DebugUI.Vector4Field m_Field;        // 0x88
        private UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;        // 0x90

        // Methods
        private System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget) { }
        private System.Void SetValue(System.Single v, System.Boolean x, System.Boolean y, System.Boolean z, System.Boolean w) { }
        private System.Void SetupSettings(UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField field) { }
        private System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous) { }
        private System.Void OnDeselection() { }
        private System.Void OnIncrement(System.Boolean fast) { }
        private System.Void OnDecrement(System.Boolean fast) { }
        private System.Void OnAction() { }
        private UnityEngine.Rendering.UI.DebugUIHandlerWidget Next() { }
        private System.Void .ctor() { }
        private System.Single <SetWidget>b__8_0() { }
        private System.Void <SetWidget>b__8_1(System.Single x) { }
        private System.Single <SetWidget>b__8_2() { }
        private System.Void <SetWidget>b__8_3(System.Single x) { }
        private System.Single <SetWidget>b__8_4() { }
        private System.Void <SetWidget>b__8_5(System.Single x) { }
        private System.Single <SetWidget>b__8_6() { }
        private System.Void <SetWidget>b__8_7(System.Single x) { }
        private System.Single <SetupSettings>b__10_0() { }
        private System.Single <SetupSettings>b__10_1() { }
        private System.Single <SetupSettings>b__10_2() { }

    }

    // TypeToken: 0x2000193
    public class DebugUIHandlerWidget : MonoBehaviour
    {
        // Fields
        public UnityEngine.Color colorDefault;        // 0x18
        public UnityEngine.Color colorSelected;        // 0x28
        private UnityEngine.Rendering.UI.DebugUIHandlerWidget <parentUIHandler>k__BackingField;        // 0x38
        private UnityEngine.Rendering.UI.DebugUIHandlerWidget <previousUIHandler>k__BackingField;        // 0x40
        private UnityEngine.Rendering.UI.DebugUIHandlerWidget <nextUIHandler>k__BackingField;        // 0x48
        protected UnityEngine.Rendering.DebugUI.Widget m_Widget;        // 0x50

        // Methods
        private UnityEngine.Rendering.UI.DebugUIHandlerWidget get_parentUIHandler() { }
        private System.Void set_parentUIHandler(UnityEngine.Rendering.UI.DebugUIHandlerWidget value) { }
        private UnityEngine.Rendering.UI.DebugUIHandlerWidget get_previousUIHandler() { }
        private System.Void set_previousUIHandler(UnityEngine.Rendering.UI.DebugUIHandlerWidget value) { }
        private UnityEngine.Rendering.UI.DebugUIHandlerWidget get_nextUIHandler() { }
        private System.Void set_nextUIHandler(UnityEngine.Rendering.UI.DebugUIHandlerWidget value) { }
        private System.Void OnEnable() { }
        private System.Void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget) { }
        private UnityEngine.Rendering.DebugUI.Widget GetWidget() { }
        private T CastWidget() { }
        private System.Boolean OnSelection(System.Boolean fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous) { }
        private System.Void OnDeselection() { }
        private System.Void OnAction() { }
        private System.Void OnIncrement(System.Boolean fast) { }
        private System.Void OnDecrement(System.Boolean fast) { }
        private UnityEngine.Rendering.UI.DebugUIHandlerWidget Previous() { }
        private UnityEngine.Rendering.UI.DebugUIHandlerWidget Next() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000194
    public class UIFoldout : Toggle
    {
        // Fields
        public UnityEngine.GameObject content;        // 0x1A8
        public UnityEngine.GameObject arrowOpened;        // 0x1B0
        public UnityEngine.GameObject arrowClosed;        // 0x1B8

        // Methods
        private System.Void Start() { }
        private System.Void OnValidate() { }
        private System.Void SetState(System.Boolean state) { }
        private System.Void SetState(System.Boolean state, System.Boolean rebuildLayout) { }
        private System.Void .ctor() { }

    }

}

