// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.CoreModule.dll
// Classes:  937
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x200000D
    public struct AutoScope, IDisposable
    {
        // Fields
        private readonly System.IntPtr m_Ptr;        // 0x10

        // Methods
        private System.Void .ctor(System.IntPtr markerPtr) { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x2000013
    public struct ControlOptions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.Profiling.ProfilerRecorder.ControlOptions Start;        // 0x0
        public static Unity.Profiling.ProfilerRecorder.ControlOptions Stop;        // 0x0
        public static Unity.Profiling.ProfilerRecorder.ControlOptions Reset;        // 0x0
        public static Unity.Profiling.ProfilerRecorder.ControlOptions Release;        // 0x0
        public static Unity.Profiling.ProfilerRecorder.ControlOptions SetFilterToCurrentThread;        // 0x0
        public static Unity.Profiling.ProfilerRecorder.ControlOptions SetToCollectFromAllThreads;        // 0x0

    }

    // TypeToken: 0x2000014
    public struct CountOptions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.Profiling.ProfilerRecorder.CountOptions Count;        // 0x0
        public static Unity.Profiling.ProfilerRecorder.CountOptions MaxCount;        // 0x0

    }

    // TypeToken: 0x2000020
    public class ExecuteJobFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T& data, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex) { }

    }

    // TypeToken: 0x200001F
    public struct JobStruct`1
    {
        // Fields
        private static readonly Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<System.IntPtr> jobReflectionData;        // 0x0

        // Methods
        private System.Void Initialize() { }
        private System.Void Execute(T& data, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000024
    public class ExecuteJobFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T& data, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex) { }

    }

    // TypeToken: 0x2000023
    public struct ForJobStruct`1
    {
        // Fields
        private static readonly Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<System.IntPtr> jobReflectionData;        // 0x0

        // Methods
        private System.Void Initialize() { }
        private System.Void Execute(T& jobData, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000028
    public class ExecuteJobFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T& data, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex) { }

    }

    // TypeToken: 0x2000027
    public struct ParallelForJobStruct`1
    {
        // Fields
        public static readonly System.IntPtr jobReflectionData;        // 0x0

        // Methods
        private System.Void Execute(T& jobData, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000031
    public struct JobScheduleParameters
    {
        // Fields
        public Unity.Jobs.JobHandle Dependency;        // 0x10
        public System.Int32 ScheduleMode;        // 0x20
        public System.IntPtr ReflectionData;        // 0x28
        public System.IntPtr JobDataPtr;        // 0x30

        // Methods
        private System.Void .ctor(System.Void* i_jobData, System.IntPtr i_reflectionData, Unity.Jobs.JobHandle i_dependency, Unity.Jobs.LowLevel.Unsafe.ScheduleMode i_scheduleMode) { }

    }

    // TypeToken: 0x2000032
    public class PanicFunction_ : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }

    }

    // TypeToken: 0x200004A
    public struct Enumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private Unity.Collections.NativeArray<T> m_Array;        // 0x0
        private System.Int32 m_Index;        // 0x0
        private T value;        // 0x0

        // Methods
        private System.Void .ctor(Unity.Collections.NativeArray<T>& array) { }
        private System.Void Dispose() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private T get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }

    }

    // TypeToken: 0x200004C
    public struct Enumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private Unity.Collections.NativeArray.ReadOnly<T> m_Array;        // 0x0
        private System.Int32 m_Index;        // 0x0
        private T value;        // 0x0

        // Methods
        private System.Void .ctor(Unity.Collections.NativeArray.ReadOnly<T>& array) { }
        private System.Void Dispose() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private T get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }

    }

    // TypeToken: 0x200004B
    public struct ReadOnly, IEnumerable`1, IEnumerable
    {
        // Fields
        private System.Void* m_Buffer;        // 0x0
        private System.Int32 m_Length;        // 0x0

        // Methods
        private System.Void .ctor(System.Void* buffer, System.Int32 length) { }
        private T get_Item(System.Int32 index) { }
        private Unity.Collections.NativeArray.ReadOnly.Enumerator<T> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000053
    public struct Enumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private Unity.Collections.NativeSlice<T> m_Array;        // 0x0
        private System.Int32 m_Index;        // 0x0

        // Methods
        private System.Void .ctor(Unity.Collections.NativeSlice<T>& array) { }
        private System.Void Dispose() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private T get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }

    }

    // TypeToken: 0x2000056
    public struct SharedStatic`1
    {
        // Fields
        private readonly System.Void* _buffer;        // 0x0

        // Methods
        private System.Void .ctor(System.Void* buffer) { }
        private T& get_Data() { }
        private Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<T> GetOrCreate(System.UInt32 alignment) { }

    }

    // TypeToken: 0x2000057
    public class SharedStatic
    {
        // Methods
        private System.Void* GetOrCreateSharedStaticInternal(System.Int64 getHashCode64, System.Int64 getSubHashCode64, System.UInt32 sizeOf, System.UInt32 alignment) { }

    }

    // TypeToken: 0x2000059
    public struct HashCode64`1
    {
        // Fields
        public static readonly System.Int64 Value;        // 0x0

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000069
    public struct IsUnmanagedCache`1
    {
        // Fields
        private static System.Int32 value;        // 0x0

    }

    // TypeToken: 0x200006A
    public struct AlignOfHelper`1
    {
        // Fields
        public System.Byte dummy;        // 0x0
        public T data;        // 0x0

    }

    // TypeToken: 0x200006E
    public struct BurstLogType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.Burst.LowLevel.BurstCompilerService.BurstLogType Info;        // 0x0
        public static Unity.Burst.LowLevel.BurstCompilerService.BurstLogType Warning;        // 0x0
        public static Unity.Burst.LowLevel.BurstCompilerService.BurstLogType Error;        // 0x0

    }

    // TypeToken: 0x2000085
    public class AdvertisingIdentifierCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.String advertisingId, System.Boolean trackingEnabled, System.String errorMsg) { }

    }

    // TypeToken: 0x2000086
    public class LowMemoryCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }

    }

    // TypeToken: 0x2000087
    public class LogCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.String condition, System.String stackTrace, UnityEngine.LogType type) { }

    }

    // TypeToken: 0x2000093
    public struct ProjectionMatrixMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Camera.ProjectionMatrixMode Explicit;        // 0x0
        public static UnityEngine.Camera.ProjectionMatrixMode Implicit;        // 0x0
        public static UnityEngine.Camera.ProjectionMatrixMode PhysicalPropertiesBased;        // 0x0

    }

    // TypeToken: 0x2000094
    public struct GateFitMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Camera.GateFitMode Vertical;        // 0x0
        public static UnityEngine.Camera.GateFitMode Horizontal;        // 0x0
        public static UnityEngine.Camera.GateFitMode Fill;        // 0x0
        public static UnityEngine.Camera.GateFitMode Overscan;        // 0x0
        public static UnityEngine.Camera.GateFitMode None;        // 0x0

    }

    // TypeToken: 0x2000095
    public struct FieldOfViewAxis
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Camera.FieldOfViewAxis Vertical;        // 0x0
        public static UnityEngine.Camera.FieldOfViewAxis Horizontal;        // 0x0

    }

    // TypeToken: 0x2000096
    public struct GateFitParameters
    {
        // Fields
        private UnityEngine.Camera.GateFitMode <mode>k__BackingField;        // 0x10
        private System.Single <aspect>k__BackingField;        // 0x14

        // Methods
        private UnityEngine.Camera.GateFitMode get_mode() { }
        private System.Void set_mode(UnityEngine.Camera.GateFitMode value) { }
        private System.Single get_aspect() { }
        private System.Void set_aspect(System.Single value) { }
        private System.Void .ctor(UnityEngine.Camera.GateFitMode mode, System.Single aspect) { }

    }

    // TypeToken: 0x2000097
    public struct StereoscopicEye
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Camera.StereoscopicEye Left;        // 0x0
        public static UnityEngine.Camera.StereoscopicEye Right;        // 0x0

    }

    // TypeToken: 0x2000098
    public struct MonoOrStereoscopicEye
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Camera.MonoOrStereoscopicEye Left;        // 0x0
        public static UnityEngine.Camera.MonoOrStereoscopicEye Right;        // 0x0
        public static UnityEngine.Camera.MonoOrStereoscopicEye Mono;        // 0x0

    }

    // TypeToken: 0x2000099
    public struct SceneViewFilterMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Camera.SceneViewFilterMode Off;        // 0x0
        public static UnityEngine.Camera.SceneViewFilterMode ShowFiltered;        // 0x0

    }

    // TypeToken: 0x200009A
    public struct RenderRequestMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Camera.RenderRequestMode None;        // 0x0
        public static UnityEngine.Camera.RenderRequestMode ObjectId;        // 0x0
        public static UnityEngine.Camera.RenderRequestMode Depth;        // 0x0
        public static UnityEngine.Camera.RenderRequestMode VertexNormal;        // 0x0
        public static UnityEngine.Camera.RenderRequestMode WorldPosition;        // 0x0
        public static UnityEngine.Camera.RenderRequestMode EntityId;        // 0x0
        public static UnityEngine.Camera.RenderRequestMode BaseColor;        // 0x0
        public static UnityEngine.Camera.RenderRequestMode SpecularColor;        // 0x0
        public static UnityEngine.Camera.RenderRequestMode Metallic;        // 0x0
        public static UnityEngine.Camera.RenderRequestMode Emission;        // 0x0
        public static UnityEngine.Camera.RenderRequestMode Normal;        // 0x0
        public static UnityEngine.Camera.RenderRequestMode Smoothness;        // 0x0
        public static UnityEngine.Camera.RenderRequestMode Occlusion;        // 0x0
        public static UnityEngine.Camera.RenderRequestMode DiffuseColor;        // 0x0

    }

    // TypeToken: 0x200009B
    public struct RenderRequestOutputSpace
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Camera.RenderRequestOutputSpace ScreenSpace;        // 0x0
        public static UnityEngine.Camera.RenderRequestOutputSpace UV0;        // 0x0
        public static UnityEngine.Camera.RenderRequestOutputSpace UV1;        // 0x0
        public static UnityEngine.Camera.RenderRequestOutputSpace UV2;        // 0x0
        public static UnityEngine.Camera.RenderRequestOutputSpace UV3;        // 0x0
        public static UnityEngine.Camera.RenderRequestOutputSpace UV4;        // 0x0
        public static UnityEngine.Camera.RenderRequestOutputSpace UV5;        // 0x0
        public static UnityEngine.Camera.RenderRequestOutputSpace UV6;        // 0x0
        public static UnityEngine.Camera.RenderRequestOutputSpace UV7;        // 0x0
        public static UnityEngine.Camera.RenderRequestOutputSpace UV8;        // 0x0

    }

    // TypeToken: 0x200009C
    public struct RenderRequest
    {
        // Fields
        private readonly UnityEngine.Camera.RenderRequestMode m_CameraRenderMode;        // 0x10
        private readonly UnityEngine.RenderTexture m_ResultRT;        // 0x18
        private readonly UnityEngine.Camera.RenderRequestOutputSpace m_OutputSpace;        // 0x20

        // Methods
        private System.Void .ctor(UnityEngine.Camera.RenderRequestMode mode, UnityEngine.RenderTexture rt) { }
        private System.Void .ctor(UnityEngine.Camera.RenderRequestMode mode, UnityEngine.Camera.RenderRequestOutputSpace space, UnityEngine.RenderTexture rt) { }
        private System.Boolean get_isValid() { }
        private UnityEngine.Camera.RenderRequestMode get_mode() { }
        private UnityEngine.RenderTexture get_result() { }
        private UnityEngine.Camera.RenderRequestOutputSpace get_outputSpace() { }

    }

    // TypeToken: 0x200009D
    public class CameraCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Camera cam) { }

    }

    // TypeToken: 0x20000A1
    public class StateChanged : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.CullingGroupEvent sphere) { }

    }

    // TypeToken: 0x20000A4
    public struct ReflectionProbeEvent
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.ReflectionProbe.ReflectionProbeEvent ReflectionProbeAdded;        // 0x0
        public static UnityEngine.ReflectionProbe.ReflectionProbeEvent ReflectionProbeRemoved;        // 0x0
        public static UnityEngine.ReflectionProbe.ReflectionProbeEvent ReflectionProbeTextureChanged;        // 0x0

    }

    // TypeToken: 0x20000AC
    public struct PositionEnumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private readonly UnityEngine.Vector3Int _min;        // 0x10
        private readonly UnityEngine.Vector3Int _max;        // 0x1C
        private UnityEngine.Vector3Int _current;        // 0x28

        // Methods
        private System.Void .ctor(UnityEngine.Vector3Int min, UnityEngine.Vector3Int max) { }
        private UnityEngine.BoundsInt.PositionEnumerator GetEnumerator() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private UnityEngine.Vector3Int get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void System.IDisposable.Dispose() { }

    }

    // TypeToken: 0x20000B3
    public struct PositionEnumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private readonly UnityEngine.Vector2Int _min;        // 0x10
        private readonly UnityEngine.Vector2Int _max;        // 0x18
        private UnityEngine.Vector2Int _current;        // 0x20

        // Methods
        private System.Void .ctor(UnityEngine.Vector2Int min, UnityEngine.Vector2Int max) { }
        private UnityEngine.RectInt.PositionEnumerator GetEnumerator() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private UnityEngine.Vector2Int get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void System.IDisposable.Dispose() { }

    }

    // TypeToken: 0x20000B9
    public struct OrderBlock
    {
        // Fields
        private System.Int32 order;        // 0x10
        private UnityEngine.Events.UnityAction callback;        // 0x18

    }

    // TypeToken: 0x20000BC
    public struct PreTransform
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Display.PreTransform PreTransformIdentity;        // 0x0
        public static UnityEngine.Display.PreTransform PreTransformRotate90;        // 0x0
        public static UnityEngine.Display.PreTransform PreTransformRotate180;        // 0x0
        public static UnityEngine.Display.PreTransform PreTransformRotate270;        // 0x0

    }

    // TypeToken: 0x20000BD
    public class DisplaysUpdatedDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }

    }

    // TypeToken: 0x20000DA
    public struct Target
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.GraphicsBuffer.Target Vertex;        // 0x0
        public static UnityEngine.GraphicsBuffer.Target Index;        // 0x0
        public static UnityEngine.GraphicsBuffer.Target CopySource;        // 0x0
        public static UnityEngine.GraphicsBuffer.Target CopyDestination;        // 0x0
        public static UnityEngine.GraphicsBuffer.Target Structured;        // 0x0
        public static UnityEngine.GraphicsBuffer.Target Raw;        // 0x0
        public static UnityEngine.GraphicsBuffer.Target Append;        // 0x0
        public static UnityEngine.GraphicsBuffer.Target Counter;        // 0x0
        public static UnityEngine.GraphicsBuffer.Target IndirectArguments;        // 0x0
        public static UnityEngine.GraphicsBuffer.Target Constant;        // 0x0

    }

    // TypeToken: 0x2000120
    public struct MeshData
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10

        // Methods
        private System.Boolean HasVertexAttribute(System.IntPtr self, UnityEngine.Rendering.VertexAttribute attr) { }
        private System.Int32 GetVertexCount(System.IntPtr self) { }
        private System.Void CopyAttributeIntoPtr(System.IntPtr self, UnityEngine.Rendering.VertexAttribute attr, UnityEngine.Rendering.VertexAttributeFormat format, System.Int32 dim, System.IntPtr dst) { }
        private System.Void CopyIndicesIntoPtr(System.IntPtr self, System.Int32 submesh, System.Boolean applyBaseVertex, System.Int32 dstStride, System.IntPtr dst) { }
        private System.Int32 GetIndexCount(System.IntPtr self, System.Int32 submesh) { }
        private System.Int32 GetSubMeshCount(System.IntPtr self) { }
        private UnityEngine.Rendering.SubMeshDescriptor GetSubMesh(System.IntPtr self, System.Int32 index) { }
        private System.Int32 get_vertexCount() { }
        private System.Boolean HasVertexAttribute(UnityEngine.Rendering.VertexAttribute attr) { }
        private System.Void GetVertices(Unity.Collections.NativeArray<UnityEngine.Vector3> outVertices) { }
        private System.Void GetNormals(Unity.Collections.NativeArray<UnityEngine.Vector3> outNormals) { }
        private System.Void GetTangents(Unity.Collections.NativeArray<UnityEngine.Vector4> outTangents) { }
        private System.Void GetUVs(System.Int32 channel, Unity.Collections.NativeArray<UnityEngine.Vector2> outUVs) { }
        private System.Void CopyAttributeInto(Unity.Collections.NativeArray<T> buffer, UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, System.Int32 dim) { }
        private System.Void GetIndices(Unity.Collections.NativeArray<System.Int32> outIndices, System.Int32 submesh, System.Boolean applyBaseVertex) { }
        private System.Int32 get_subMeshCount() { }
        private UnityEngine.Rendering.SubMeshDescriptor GetSubMesh(System.Int32 index) { }
        private System.Void GetSubMesh_Injected(System.IntPtr self, System.Int32 index, UnityEngine.Rendering.SubMeshDescriptor& ret) { }

    }

    // TypeToken: 0x2000121
    public struct MeshDataArray, IDisposable
    {
        // Fields
        private System.IntPtr* m_Ptrs;        // 0x10
        private System.Int32 m_Length;        // 0x18

        // Methods
        private System.Void AcquireReadOnlyMeshData(UnityEngine.Mesh mesh, System.IntPtr* datas) { }
        private System.Void ReleaseMeshDatas(System.IntPtr* datas, System.Int32 count) { }
        private System.Int32 get_Length() { }
        private UnityEngine.Mesh.MeshData get_Item(System.Int32 index) { }
        private System.Void Dispose() { }
        private System.Void .ctor(UnityEngine.Mesh mesh, System.Boolean checkReadWrite) { }

    }

    // TypeToken: 0x2000127
    public struct EXRFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Texture2D.EXRFlags None;        // 0x0
        public static UnityEngine.Texture2D.EXRFlags OutputAsFloat;        // 0x0
        public static UnityEngine.Texture2D.EXRFlags CompressZIP;        // 0x0
        public static UnityEngine.Texture2D.EXRFlags CompressRLE;        // 0x0
        public static UnityEngine.Texture2D.EXRFlags CompressPIZ;        // 0x0

    }

    // TypeToken: 0x2000133
    public struct U
    {
        // Fields
        public System.Byte* p8;        // 0x10
        public System.UInt32* p32;        // 0x10
        public System.UInt64* p64;        // 0x10
        public System.UInt64 i;        // 0x10

        // Methods
        private System.Void .ctor(System.UInt16* p8) { }

    }

    // TypeToken: 0x2000160
    public struct State
    {
        // Fields
        private System.Int32 s0;        // 0x10
        private System.Int32 s1;        // 0x14
        private System.Int32 s2;        // 0x18
        private System.Int32 s3;        // 0x1C

    }

    // TypeToken: 0x2000165
    public struct ResourcesCPUAffinity
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Resources.ResourcesCPUAffinity kPCoreAffinity;        // 0x0
        public static UnityEngine.Resources.ResourcesCPUAffinity kECoreAffinity;        // 0x0

    }

    // TypeToken: 0x200018E
    public struct TestClass
    {
        // Fields
        public System.Int32 value;        // 0x10

    }

    // TypeToken: 0x2000194
    public struct CreateOptions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TextAsset.CreateOptions None;        // 0x0
        public static UnityEngine.TextAsset.CreateOptions CreateNativeObject;        // 0x0

    }

    // TypeToken: 0x2000195
    public class EncodingUtility
    {
        // Fields
        private static readonly System.Collections.Generic.KeyValuePair<System.Byte[],System.Text.Encoding>[] encodingLookup;        // 0x0
        private static readonly System.Text.Encoding targetEncoding;        // 0x8

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200019F
    public struct WorkRequest
    {
        // Fields
        private readonly System.Threading.SendOrPostCallback m_DelagateCallback;        // 0x10
        private readonly System.Object m_DelagateState;        // 0x18
        private readonly System.Threading.ManualResetEvent m_WaitHandle;        // 0x20

        // Methods
        private System.Void .ctor(System.Threading.SendOrPostCallback callback, System.Object state, System.Threading.ManualResetEvent waitHandle) { }
        private System.Void Invoke() { }

    }

    // TypeToken: 0x20001AF
    public class GetLevelIdDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.String Invoke() { }

    }

    // TypeToken: 0x20001B1
    public class AutoDispatcher, IDisposable
    {
        // Fields
        private UnityEngine.HGPsoWarmupCollection m_Psoc;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.HGPsoWarmupCollection psoc) { }
        private UnityEngine.HGPsoWarmupCollection.AutoDispatcher Create(UnityEngine.HGPsoWarmupCollection psoc) { }
        private System.Void ScheduleIndex(System.Int32 index, System.Boolean background) { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x20001BD
    public struct Status
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TouchScreenKeyboard.Status Visible;        // 0x0
        public static UnityEngine.TouchScreenKeyboard.Status Done;        // 0x0
        public static UnityEngine.TouchScreenKeyboard.Status Canceled;        // 0x0
        public static UnityEngine.TouchScreenKeyboard.Status LostFocus;        // 0x0

    }

    // TypeToken: 0x20001C3
    public struct Edge
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.RectTransform.Edge Left;        // 0x0
        public static UnityEngine.RectTransform.Edge Right;        // 0x0
        public static UnityEngine.RectTransform.Edge Top;        // 0x0
        public static UnityEngine.RectTransform.Edge Bottom;        // 0x0

    }

    // TypeToken: 0x20001C4
    public struct Axis
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.RectTransform.Axis Horizontal;        // 0x0
        public static UnityEngine.RectTransform.Axis Vertical;        // 0x0

    }

    // TypeToken: 0x20001C5
    public class ReapplyDrivenProperties : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.RectTransform driven) { }

    }

    // TypeToken: 0x20001C8
    public class Enumerator, IEnumerator
    {
        // Fields
        private UnityEngine.Transform outer;        // 0x10
        private System.Int32 currentIndex;        // 0x18

        // Methods
        private System.Void .ctor(UnityEngine.Transform outer) { }
        private System.Object get_Current() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }

    }

    // TypeToken: 0x20001D7
    public class FinishFrameCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Double frameTimeMS, System.Boolean overflow, System.IntPtr frameDataPtr, System.Int32 size) { }

    }

    // TypeToken: 0x20001E2
    public struct TransformJobData
    {
        // Fields
        public System.IntPtr TransformAccessArray;        // 0x0
        public System.Int32 IsReadOnly;        // 0x0

    }

    // TypeToken: 0x20001E3
    public class ExecuteJobFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T& jobData, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex) { }

    }

    // TypeToken: 0x20001E1
    public struct TransformCrossFrameStruct`1
    {
        // Fields
        public static System.IntPtr jobReflectionData;        // 0x0

        // Methods
        private System.IntPtr Initialize() { }
        private System.Void Execute(T& jobData, System.IntPtr jobData2, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex) { }

    }

    // TypeToken: 0x20001E5
    public struct TransformJobData
    {
        // Fields
        public System.IntPtr TransformAccessArray;        // 0x0
        public System.Int32 IsReadOnly;        // 0x0

    }

    // TypeToken: 0x20001E6
    public class ExecuteJobFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T& jobData, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex) { }

    }

    // TypeToken: 0x20001E4
    public struct TransformParallelForLoopStruct`1
    {
        // Fields
        public static System.IntPtr jobReflectionData;        // 0x0

        // Methods
        private System.IntPtr Initialize() { }
        private System.Void Execute(T& jobData, System.IntPtr jobData2, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex) { }

    }

    // TypeToken: 0x20001EB
    public class ErrorDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Windows.Speech.SpeechError errorCode) { }

    }

    // TypeToken: 0x20001EC
    public class StatusDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Windows.Speech.SpeechSystemStatus status) { }

    }

    // TypeToken: 0x20001EE
    public class PhraseRecognizedDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Windows.Speech.PhraseRecognizedEventArgs args) { }

    }

    // TypeToken: 0x20001F0
    public class DictationHypothesisDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.String text) { }

    }

    // TypeToken: 0x20001F1
    public class DictationResultDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.String text, UnityEngine.Windows.Speech.ConfidenceLevel confidence) { }

    }

    // TypeToken: 0x20001F2
    public class DictationCompletedDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Windows.Speech.DictationCompletionCause cause) { }

    }

    // TypeToken: 0x20001F3
    public class DictationErrorHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.String error, System.Int32 hresult) { }

    }

    // TypeToken: 0x20001FB
    public struct CaptureResultType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Windows.WebCam.PhotoCapture.CaptureResultType Success;        // 0x0
        public static UnityEngine.Windows.WebCam.PhotoCapture.CaptureResultType UnknownError;        // 0x0

    }

    // TypeToken: 0x20001FC
    public struct PhotoCaptureResult
    {
        // Fields
        public UnityEngine.Windows.WebCam.PhotoCapture.CaptureResultType resultType;        // 0x10
        public System.Int64 hResult;        // 0x18

    }

    // TypeToken: 0x20001FD
    public class OnCaptureResourceCreatedCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Windows.WebCam.PhotoCapture captureObject) { }

    }

    // TypeToken: 0x20001FE
    public class OnPhotoModeStartedCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Windows.WebCam.PhotoCapture.PhotoCaptureResult result) { }

    }

    // TypeToken: 0x20001FF
    public class OnPhotoModeStoppedCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Windows.WebCam.PhotoCapture.PhotoCaptureResult result) { }

    }

    // TypeToken: 0x2000200
    public class OnCapturedToDiskCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Windows.WebCam.PhotoCapture.PhotoCaptureResult result) { }

    }

    // TypeToken: 0x2000201
    public class OnCapturedToMemoryCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Windows.WebCam.PhotoCapture.PhotoCaptureResult result, UnityEngine.Windows.WebCam.PhotoCaptureFrame photoCaptureFrame) { }

    }

    // TypeToken: 0x2000204
    public struct CaptureResultType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Windows.WebCam.VideoCapture.CaptureResultType Success;        // 0x0
        public static UnityEngine.Windows.WebCam.VideoCapture.CaptureResultType UnknownError;        // 0x0

    }

    // TypeToken: 0x2000205
    public struct VideoCaptureResult
    {
        // Fields
        public UnityEngine.Windows.WebCam.VideoCapture.CaptureResultType resultType;        // 0x10
        public System.Int64 hResult;        // 0x18

    }

    // TypeToken: 0x2000206
    public class OnVideoCaptureResourceCreatedCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Windows.WebCam.VideoCapture captureObject) { }

    }

    // TypeToken: 0x2000207
    public class OnVideoModeStartedCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Windows.WebCam.VideoCapture.VideoCaptureResult result) { }

    }

    // TypeToken: 0x2000208
    public class OnVideoModeStoppedCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Windows.WebCam.VideoCapture.VideoCaptureResult result) { }

    }

    // TypeToken: 0x2000209
    public class OnStartedRecordingVideoCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Windows.WebCam.VideoCapture.VideoCaptureResult result) { }

    }

    // TypeToken: 0x200020A
    public class OnStoppedRecordingVideoCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Windows.WebCam.VideoCapture.VideoCaptureResult result) { }

    }

    // TypeToken: 0x200022B
    public struct LoadingState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.SceneManagement.Scene.LoadingState NotLoaded;        // 0x0
        public static UnityEngine.SceneManagement.Scene.LoadingState Loading;        // 0x0
        public static UnityEngine.SceneManagement.Scene.LoadingState Loaded;        // 0x0
        public static UnityEngine.SceneManagement.Scene.LoadingState Unloading;        // 0x0

    }

    // TypeToken: 0x2000236
    public class UpdateFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }

    }

    // TypeToken: 0x2000239
    public struct WaitForLastPresentationAndUpdateTime
    {
    }

    // TypeToken: 0x200023B
    public struct ProfilerStartFrame
    {
    }

    // TypeToken: 0x200023C
    public struct UpdateCameraMotionVectors
    {
    }

    // TypeToken: 0x200023D
    public struct DirectorSampleTime
    {
    }

    // TypeToken: 0x200023E
    public struct AsyncUploadTimeSlicedUpdate
    {
    }

    // TypeToken: 0x200023F
    public struct SynchronizeState
    {
    }

    // TypeToken: 0x2000240
    public struct SynchronizeInputs
    {
    }

    // TypeToken: 0x2000241
    public struct XREarlyUpdate
    {
    }

    // TypeToken: 0x2000243
    public struct PollPlayerConnection
    {
    }

    // TypeToken: 0x2000244
    public struct PollHtcsPlayerConnection
    {
    }

    // TypeToken: 0x2000245
    public struct GpuTimestamp
    {
    }

    // TypeToken: 0x2000246
    public struct AnalyticsCoreStatsUpdate
    {
    }

    // TypeToken: 0x2000247
    public struct UnityWebRequestUpdate
    {
    }

    // TypeToken: 0x2000248
    public struct UpdateStreamingManager
    {
    }

    // TypeToken: 0x2000249
    public struct ExecuteMainThreadJobs
    {
    }

    // TypeToken: 0x200024A
    public struct ProcessMouseInWindow
    {
    }

    // TypeToken: 0x200024B
    public struct ClearIntermediateRenderers
    {
    }

    // TypeToken: 0x200024C
    public struct ClearLines
    {
    }

    // TypeToken: 0x200024D
    public struct PresentBeforeUpdate
    {
    }

    // TypeToken: 0x200024E
    public struct ResetFrameStatsAfterPresent
    {
    }

    // TypeToken: 0x200024F
    public struct UpdateAsyncReadbackManager
    {
    }

    // TypeToken: 0x2000250
    public struct UpdateTextureStreamingManager
    {
    }

    // TypeToken: 0x2000251
    public struct HGGlobalGameManagerEarlyUpdate
    {
    }

    // TypeToken: 0x2000252
    public struct UpdatePreloading
    {
    }

    // TypeToken: 0x2000253
    public struct UpdateAsyncInstantiate
    {
    }

    // TypeToken: 0x2000254
    public struct RendererNotifyInvisible
    {
    }

    // TypeToken: 0x2000255
    public struct PlayerCleanupCachedData
    {
    }

    // TypeToken: 0x2000256
    public struct UpdateMainGameViewRect
    {
    }

    // TypeToken: 0x2000257
    public struct UpdateCanvasRectTransform
    {
    }

    // TypeToken: 0x2000258
    public struct UpdateInputManager
    {
    }

    // TypeToken: 0x2000259
    public struct ProcessRemoteInput
    {
    }

    // TypeToken: 0x200025A
    public struct XRUpdate
    {
    }

    // TypeToken: 0x200025B
    public struct ScriptRunDelayedStartupFrame
    {
    }

    // TypeToken: 0x200025C
    public struct UpdateKinect
    {
    }

    // TypeToken: 0x200025D
    public struct DeliverIosPlatformEvents
    {
    }

    // TypeToken: 0x200025E
    public struct DispatchEventQueueEvents
    {
    }

    // TypeToken: 0x200025F
    public struct PhysicsResetInterpolatedTransformPosition
    {
    }

    // TypeToken: 0x2000260
    public struct SpriteAtlasManagerUpdate
    {
    }

    // TypeToken: 0x2000261
    public struct TangoUpdate
    {
    }

    // TypeToken: 0x2000262
    public struct ARCoreUpdate
    {
    }

    // TypeToken: 0x2000263
    public struct PerformanceAnalyticsUpdate
    {
    }

    // TypeToken: 0x2000265
    public struct ClearLines
    {
    }

    // TypeToken: 0x2000266
    public struct DirectorFixedSampleTime
    {
    }

    // TypeToken: 0x2000267
    public struct AudioFixedUpdate
    {
    }

    // TypeToken: 0x2000268
    public struct ScriptRunBehaviourFixedUpdate
    {
    }

    // TypeToken: 0x2000269
    public struct DirectorFixedUpdate
    {
    }

    // TypeToken: 0x200026A
    public struct LegacyFixedAnimationUpdate
    {
    }

    // TypeToken: 0x200026B
    public struct XRFixedUpdate
    {
    }

    // TypeToken: 0x200026C
    public struct PhysicsFixedUpdate
    {
    }

    // TypeToken: 0x200026D
    public struct Physics2DFixedUpdate
    {
    }

    // TypeToken: 0x200026E
    public struct PhysicsClothFixedUpdate
    {
    }

    // TypeToken: 0x200026F
    public struct DirectorFixedUpdatePostPhysics
    {
    }

    // TypeToken: 0x2000270
    public struct ScriptRunDelayedFixedFrameRate
    {
    }

    // TypeToken: 0x2000271
    public struct NewInputFixedUpdate
    {
    }

    // TypeToken: 0x2000273
    public struct PhysicsUpdate
    {
    }

    // TypeToken: 0x2000274
    public struct Physics2DUpdate
    {
    }

    // TypeToken: 0x2000275
    public struct HGGlobalGameManagerPreGameplayUpdate
    {
    }

    // TypeToken: 0x2000276
    public struct CheckTexFieldInput
    {
    }

    // TypeToken: 0x2000277
    public struct IMGUISendQueuedEvents
    {
    }

    // TypeToken: 0x2000278
    public struct SendMouseEvents
    {
    }

    // TypeToken: 0x2000279
    public struct AIUpdate
    {
    }

    // TypeToken: 0x200027A
    public struct WindUpdate
    {
    }

    // TypeToken: 0x200027B
    public struct UpdateVideo
    {
    }

    // TypeToken: 0x200027C
    public struct NewInputUpdate
    {
    }

    // TypeToken: 0x200027D
    public struct DirectorPreUpdate
    {
    }

    // TypeToken: 0x200027F
    public struct ScriptRunBehaviourUpdate
    {
    }

    // TypeToken: 0x2000280
    public struct HGGlobalGameManagerGameplayUpdate
    {
    }

    // TypeToken: 0x2000281
    public struct DirectorUpdate
    {
    }

    // TypeToken: 0x2000282
    public struct ScriptRunDelayedDynamicFrameRate
    {
    }

    // TypeToken: 0x2000283
    public struct ScriptRunDelayedTasks
    {
    }

    // TypeToken: 0x2000285
    public struct HGGlobalGameManagerPreLateUpdate
    {
    }

    // TypeToken: 0x2000286
    public struct Physics2DLateUpdate
    {
    }

    // TypeToken: 0x2000287
    public struct AIUpdatePostScript
    {
    }

    // TypeToken: 0x2000288
    public struct DirectorUpdateAnimationBegin
    {
    }

    // TypeToken: 0x2000289
    public struct LegacyAnimationUpdate
    {
    }

    // TypeToken: 0x200028A
    public struct DirectorUpdateAnimationEnd
    {
    }

    // TypeToken: 0x200028B
    public struct DirectorDeferredEvaluate
    {
    }

    // TypeToken: 0x200028C
    public struct UIElementsUpdatePanels
    {
    }

    // TypeToken: 0x200028D
    public struct UpdateNetworkManager
    {
    }

    // TypeToken: 0x200028E
    public struct UpdateMasterServerInterface
    {
    }

    // TypeToken: 0x200028F
    public struct UNetUpdate
    {
    }

    // TypeToken: 0x2000290
    public struct EndGraphicsJobsAfterScriptUpdate
    {
    }

    // TypeToken: 0x2000291
    public struct ParticleSystemBeginUpdateAll
    {
    }

    // TypeToken: 0x2000292
    public struct ScriptRunBehaviourLateUpdate
    {
    }

    // TypeToken: 0x2000293
    public struct UIAtlasManagerUpdate
    {
    }

    // TypeToken: 0x2000294
    public struct ConstraintManagerUpdate
    {
    }

    // TypeToken: 0x2000296
    public struct PlayerSendFrameStarted
    {
    }

    // TypeToken: 0x2000297
    public struct UpdateRectTransform
    {
    }

    // TypeToken: 0x2000298
    public struct UpdateCanvasRectTransform
    {
    }

    // TypeToken: 0x2000299
    public struct PlayerUpdateCanvases
    {
    }

    // TypeToken: 0x200029A
    public struct UpdateAudio
    {
    }

    // TypeToken: 0x200029B
    public struct UpdateVideo
    {
    }

    // TypeToken: 0x200029C
    public struct DirectorLateUpdate
    {
    }

    // TypeToken: 0x200029D
    public struct ScriptRunDelayedDynamicFrameRate
    {
    }

    // TypeToken: 0x200029E
    public struct VFXUpdate
    {
    }

    // TypeToken: 0x200029F
    public struct ParticleSystemEndUpdateAll
    {
    }

    // TypeToken: 0x20002A0
    public struct EndGraphicsJobsAfterScriptLateUpdate
    {
    }

    // TypeToken: 0x20002A1
    public struct UpdateSubstance
    {
    }

    // TypeToken: 0x20002A2
    public struct UpdateCustomRenderTextures
    {
    }

    // TypeToken: 0x20002A3
    public struct XRPostLateUpdate
    {
    }

    // TypeToken: 0x20002A4
    public struct UpdateAllRenderers
    {
    }

    // TypeToken: 0x20002A5
    public struct HGGlobalGameManagerLateUpdate
    {
    }

    // TypeToken: 0x20002A6
    public struct HGGlobalGameManagerPostLateUpdate
    {
    }

    // TypeToken: 0x20002A7
    public struct HGGlobalGameManagerPipelineUpdate
    {
    }

    // TypeToken: 0x20002A8
    public struct HGGlobalGameManagerUpdateAfterTransformSyncToEcs
    {
    }

    // TypeToken: 0x20002A9
    public struct UpdateLightProbeProxyVolumes
    {
    }

    // TypeToken: 0x20002AA
    public struct EnlightenRuntimeUpdate
    {
    }

    // TypeToken: 0x20002AB
    public struct UpdateAllSkinnedMeshes
    {
    }

    // TypeToken: 0x20002AC
    public struct ProcessWebSendMessages
    {
    }

    // TypeToken: 0x20002AD
    public struct SortingGroupsUpdate
    {
    }

    // TypeToken: 0x20002AE
    public struct UpdateVideoTextures
    {
    }

    // TypeToken: 0x20002AF
    public struct DirectorRenderImage
    {
    }

    // TypeToken: 0x20002B0
    public struct PlayerEmitCanvasGeometry
    {
    }

    // TypeToken: 0x20002B1
    public struct PlayerRenderUIEBatchModeOffscreen
    {
    }

    // TypeToken: 0x20002B2
    public struct FinishFrameRendering
    {
    }

    // TypeToken: 0x20002B3
    public struct BatchModeUpdate
    {
    }

    // TypeToken: 0x20002B4
    public struct PlayerSendFrameComplete
    {
    }

    // TypeToken: 0x20002B5
    public struct UpdateCaptureScreenshot
    {
    }

    // TypeToken: 0x20002B6
    public struct PresentAfterDraw
    {
    }

    // TypeToken: 0x20002B7
    public struct ClearImmediateRenderers
    {
    }

    // TypeToken: 0x20002B8
    public struct XRPostPresent
    {
    }

    // TypeToken: 0x20002B9
    public struct UpdateResolution
    {
    }

    // TypeToken: 0x20002BA
    public struct InputEndFrame
    {
    }

    // TypeToken: 0x20002BB
    public struct GUIClearEvents
    {
    }

    // TypeToken: 0x20002BC
    public struct ShaderHandleErrors
    {
    }

    // TypeToken: 0x20002BD
    public struct ResetInputAxis
    {
    }

    // TypeToken: 0x20002BE
    public struct ThreadedLoadingDebug
    {
    }

    // TypeToken: 0x20002BF
    public struct ProfilerSynchronizeStats
    {
    }

    // TypeToken: 0x20002C0
    public struct MemoryFrameMaintenance
    {
    }

    // TypeToken: 0x20002C1
    public struct ExecuteGameCenterCallbacks
    {
    }

    // TypeToken: 0x20002C2
    public struct XRPreEndFrame
    {
    }

    // TypeToken: 0x20002C3
    public struct ProfilerEndFrame
    {
    }

    // TypeToken: 0x20002C4
    public struct GraphicsWarmupPreloadedShaders
    {
    }

    // TypeToken: 0x20002C5
    public struct PlayerSendFramePostPresent
    {
    }

    // TypeToken: 0x20002C6
    public struct PhysicsSkinnedClothBeginUpdate
    {
    }

    // TypeToken: 0x20002C7
    public struct PhysicsSkinnedClothFinishUpdate
    {
    }

    // TypeToken: 0x20002C8
    public struct DirectorManagerNextFrameEnd
    {
    }

    // TypeToken: 0x20002C9
    public struct TriggerEndOfFrameCallbacks
    {
    }

    // TypeToken: 0x20002CA
    public struct WaitForLastPresentationAndUpdateTimeAfterFrame
    {
    }

    // TypeToken: 0x20002CB
    public struct HGGlobalGameManagerPreParticleUpdate
    {
    }

    // TypeToken: 0x20002D8
    public class MessageEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002D9
    public class ConnectionChangeEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002DA
    public class MessageTypeSubscribers
    {
        // Fields
        private System.String m_messageTypeId;        // 0x10
        public System.Int32 subscriberCount;        // 0x18
        public UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageEvent messageCallback;        // 0x20

        // Methods
        private System.Guid get_MessageTypeId() { }
        private System.Void set_MessageTypeId(System.Guid value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200032C
    public class OnPerformCulling : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private Unity.Jobs.JobHandle Invoke(UnityEngine.Rendering.BatchRendererGroup rendererGroup, UnityEngine.Rendering.BatchCullingContext cullingContext) { }

    }

    // TypeToken: 0x2000358
    public struct ReflectionProbeModes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.SupportedRenderingFeatures.ReflectionProbeModes None;        // 0x0
        public static UnityEngine.Rendering.SupportedRenderingFeatures.ReflectionProbeModes Rotation;        // 0x0

    }

    // TypeToken: 0x2000359
    public struct LightmapMixedBakeModes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes None;        // 0x0
        public static UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes IndirectOnly;        // 0x0
        public static UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes Subtractive;        // 0x0
        public static UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes Shadowmask;        // 0x0

    }

    // TypeToken: 0x2000368
    public struct Flags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Playables.FrameData.Flags Evaluate;        // 0x0
        public static UnityEngine.Playables.FrameData.Flags SeekOccured;        // 0x0
        public static UnityEngine.Playables.FrameData.Flags Loop;        // 0x0
        public static UnityEngine.Playables.FrameData.Flags Hold;        // 0x0
        public static UnityEngine.Playables.FrameData.Flags EffectivePlayStateDelayed;        // 0x0
        public static UnityEngine.Playables.FrameData.Flags EffectivePlayStatePlaying;        // 0x0

    }

    // TypeToken: 0x2000369
    public struct EvaluationType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Playables.FrameData.EvaluationType Evaluate;        // 0x0
        public static UnityEngine.Playables.FrameData.EvaluationType Playback;        // 0x0

    }

    // TypeToken: 0x2000376
    public class CreateOutputMethod : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private UnityEngine.Playables.PlayableOutput Invoke(UnityEngine.Playables.PlayableGraph graph, System.String name) { }

    }

    // TypeToken: 0x2000397
    public class RequestLightsDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Light[] requests, Unity.Collections.NativeArray<UnityEngine.Experimental.GlobalIllumination.LightDataGI> lightsOutput) { }

    }

namespace AOT
{

    // TypeToken: 0x2000005
    public class MonoPInvokeCallbackAttribute : Attribute
    {
        // Methods
        private System.Void .ctor(System.Type type) { }

    }

}

namespace JetBrains.Annotations
{

    // TypeToken: 0x200006F
    public class CanBeNullAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000070
    public class NotNullAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000071
    public class MeansImplicitUseAttribute : Attribute
    {
        // Fields
        private readonly JetBrains.Annotations.ImplicitUseKindFlags <UseKindFlags>k__BackingField;        // 0x10
        private readonly JetBrains.Annotations.ImplicitUseTargetFlags <TargetFlags>k__BackingField;        // 0x14

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(JetBrains.Annotations.ImplicitUseKindFlags useKindFlags, JetBrains.Annotations.ImplicitUseTargetFlags targetFlags) { }

    }

    // TypeToken: 0x2000072
    public struct ImplicitUseKindFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static JetBrains.Annotations.ImplicitUseKindFlags Default;        // 0x0
        public static JetBrains.Annotations.ImplicitUseKindFlags Access;        // 0x0
        public static JetBrains.Annotations.ImplicitUseKindFlags Assign;        // 0x0
        public static JetBrains.Annotations.ImplicitUseKindFlags InstantiatedWithFixedConstructorSignature;        // 0x0
        public static JetBrains.Annotations.ImplicitUseKindFlags InstantiatedNoFixedConstructorSignature;        // 0x0

    }

    // TypeToken: 0x2000073
    public struct ImplicitUseTargetFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static JetBrains.Annotations.ImplicitUseTargetFlags Default;        // 0x0
        public static JetBrains.Annotations.ImplicitUseTargetFlags Itself;        // 0x0
        public static JetBrains.Annotations.ImplicitUseTargetFlags Members;        // 0x0
        public static JetBrains.Annotations.ImplicitUseTargetFlags WithMembers;        // 0x0

    }

    // TypeToken: 0x2000074
    public class PureAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000075
    public class MustUseReturnValueAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000076
    public class NoEnumerationAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

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
    public class IsReadOnlyAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000004
    public class IsUnmanagedAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace Unity.Burst
{

    // TypeToken: 0x200006B
    public class BurstAuthorizedExternalMethodAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006C
    public class BurstDiscardAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace Unity.Burst.LowLevel
{

    // TypeToken: 0x200006D
    public class BurstCompilerService
    {
        // Methods
        private System.Int32 CompileAsyncDelegateMethod(System.Object delegateMethod, System.String compilerOptions) { }
        private System.Void* GetAsyncCompiledAsyncDelegateMethod(System.Int32 userID) { }
        private System.Void* GetOrCreateSharedMemory(UnityEngine.Hash128& key, System.UInt32 size_of, System.UInt32 alignment) { }
        private System.Void Log(System.Void* userData, Unity.Burst.LowLevel.BurstCompilerService.BurstLogType logType, System.Byte* message, System.Byte* filename, System.Int32 lineNumber) { }

    }

}

namespace Unity.Collections
{

    // TypeToken: 0x200003F
    public class ReadOnlyAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000040
    public class WriteOnlyAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000041
    public class DeallocateOnJobCompletionAttribute : Attribute
    {
    }

    // TypeToken: 0x2000042
    public class NativeFixedLengthAttribute : Attribute
    {
    }

    // TypeToken: 0x2000043
    public class NativeMatchesParallelForLengthAttribute : Attribute
    {
    }

    // TypeToken: 0x2000044
    public class NativeDisableParallelForRestrictionAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000045
    public struct Allocator
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.Collections.Allocator Invalid;        // 0x0
        public static Unity.Collections.Allocator None;        // 0x0
        public static Unity.Collections.Allocator Temp;        // 0x0
        public static Unity.Collections.Allocator TempJob;        // 0x0
        public static Unity.Collections.Allocator Persistent;        // 0x0
        public static Unity.Collections.Allocator AudioKernel;        // 0x0

    }

    // TypeToken: 0x2000046
    public struct LeakCategory
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.Collections.LeakCategory Invalid;        // 0x0
        public static Unity.Collections.LeakCategory Malloc;        // 0x0
        public static Unity.Collections.LeakCategory TempJob;        // 0x0
        public static Unity.Collections.LeakCategory Persistent;        // 0x0
        public static Unity.Collections.LeakCategory LightProbesQuery;        // 0x0
        public static Unity.Collections.LeakCategory NativeTest;        // 0x0
        public static Unity.Collections.LeakCategory MeshDataArray;        // 0x0
        public static Unity.Collections.LeakCategory TransformAccessArray;        // 0x0
        public static Unity.Collections.LeakCategory NavMeshQuery;        // 0x0

    }

    // TypeToken: 0x2000047
    public class NativeLeakDetection
    {
        // Fields
        private static System.Int32 s_NativeLeakDetectionMode;        // 0x0

        // Methods
        private System.Void Initialize() { }

    }

    // TypeToken: 0x2000048
    public struct NativeArrayOptions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.Collections.NativeArrayOptions UninitializedMemory;        // 0x0
        public static Unity.Collections.NativeArrayOptions ClearMemory;        // 0x0

    }

    // TypeToken: 0x2000049
    public struct NativeArray`1, IDisposable, IEnumerable`1, IEnumerable, IEquatable`1
    {
        // Fields
        private System.Void* m_Buffer;        // 0x0
        private System.Int32 m_Length;        // 0x0
        private Unity.Collections.Allocator m_AllocatorLabel;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 length, Unity.Collections.Allocator allocator, Unity.Collections.NativeArrayOptions options) { }
        private System.Void .ctor(T[] array, Unity.Collections.Allocator allocator) { }
        private System.Void .ctor(Unity.Collections.NativeArray<T> array, Unity.Collections.Allocator allocator) { }
        private System.Void Allocate(System.Int32 length, Unity.Collections.Allocator allocator, Unity.Collections.NativeArray<T>& array) { }
        private System.Int32 get_Length() { }
        private T get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, T value) { }
        private System.Boolean get_IsCreated() { }
        private System.Void Dispose() { }
        private Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps) { }
        private System.Void CopyFrom(T[] array) { }
        private System.Void CopyFrom(Unity.Collections.NativeArray<T> array) { }
        private T[] ToArray() { }
        private Unity.Collections.NativeArray.Enumerator<T> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Boolean Equals(Unity.Collections.NativeArray<T> other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Void Copy(Unity.Collections.NativeArray<T> src, Unity.Collections.NativeArray<T> dst) { }
        private System.Void Copy(T[] src, Unity.Collections.NativeArray<T> dst) { }
        private System.Void Copy(Unity.Collections.NativeArray<T> src, T[] dst) { }
        private System.Void Copy(Unity.Collections.NativeArray<T> src, Unity.Collections.NativeArray<T> dst, System.Int32 length) { }
        private System.Void Copy(Unity.Collections.NativeArray<T> src, T[] dst, System.Int32 length) { }
        private System.Void Copy(Unity.Collections.NativeArray<T> src, System.Int32 srcIndex, Unity.Collections.NativeArray<T> dst, System.Int32 dstIndex, System.Int32 length) { }
        private System.Void Copy(T[] src, System.Int32 srcIndex, Unity.Collections.NativeArray<T> dst, System.Int32 dstIndex, System.Int32 length) { }
        private System.Void Copy(Unity.Collections.NativeArray<T> src, System.Int32 srcIndex, T[] dst, System.Int32 dstIndex, System.Int32 length) { }
        private System.Void ReinterpretStore(System.Int32 destIndex, U data) { }
        private Unity.Collections.NativeArray<U> InternalReinterpret(System.Int32 length) { }
        private Unity.Collections.NativeArray<U> Reinterpret() { }
        private Unity.Collections.NativeArray<T> GetSubArray(System.Int32 start, System.Int32 length) { }
        private Unity.Collections.NativeArray.ReadOnly<T> AsReadOnly() { }

    }

    // TypeToken: 0x200004D
    public struct NativeArrayDispose
    {
        // Fields
        private System.Void* m_Buffer;        // 0x10
        private Unity.Collections.Allocator m_AllocatorLabel;        // 0x18

        // Methods
        private System.Void Dispose() { }

    }

    // TypeToken: 0x200004E
    public struct NativeArrayDisposeJob, IJob
    {
        // Fields
        private Unity.Collections.NativeArrayDispose Data;        // 0x10

        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x200004F
    public class NativeArrayDebugView`1
    {
    }

    // TypeToken: 0x2000050
    public class NativeArrayReadOnlyDebugView`1
    {
    }

    // TypeToken: 0x2000051
    public class NativeSliceExtensions
    {
        // Methods
        private Unity.Collections.NativeSlice<T> Slice(Unity.Collections.NativeArray<T> thisArray, System.Int32 start, System.Int32 length) { }
        private Unity.Collections.NativeSlice<T> Slice(Unity.Collections.NativeSlice<T> thisSlice, System.Int32 start, System.Int32 length) { }

    }

    // TypeToken: 0x2000052
    public struct NativeSlice`1, IEnumerable`1, IEnumerable, IEquatable`1
    {
        // Fields
        private System.Byte* m_Buffer;        // 0x0
        private System.Int32 m_Stride;        // 0x0
        private System.Int32 m_Length;        // 0x0

        // Methods
        private System.Void .ctor(Unity.Collections.NativeSlice<T> slice, System.Int32 start, System.Int32 length) { }
        private System.Void .ctor(Unity.Collections.NativeArray<T> array) { }
        private Unity.Collections.NativeSlice<T> op_Implicit(Unity.Collections.NativeArray<T> array) { }
        private System.Void .ctor(Unity.Collections.NativeArray<T> array, System.Int32 start, System.Int32 length) { }
        private Unity.Collections.NativeSlice<U> SliceConvert() { }
        private T get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, T value) { }
        private System.Void CopyFrom(Unity.Collections.NativeSlice<T> slice) { }
        private System.Void CopyFrom(T[] array) { }
        private System.Void CopyTo(Unity.Collections.NativeArray<T> array) { }
        private System.Void CopyTo(T[] array) { }
        private System.Int32 get_Stride() { }
        private System.Int32 get_Length() { }
        private Unity.Collections.NativeSlice.Enumerator<T> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Boolean Equals(Unity.Collections.NativeSlice<T> other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean op_Inequality(Unity.Collections.NativeSlice<T> left, Unity.Collections.NativeSlice<T> right) { }

    }

    // TypeToken: 0x2000054
    public class NativeSliceDebugView`1
    {
    }

}

namespace Unity.Collections.LowLevel.Unsafe
{

    // TypeToken: 0x2000055
    public class BurstLike
    {
    }

    // TypeToken: 0x2000058
    public class BurstRuntime
    {
        // Methods
        private System.Int64 GetHashCode64() { }
        private System.Int64 HashStringWithFNV1A64(System.String text) { }

    }

    // TypeToken: 0x200005A
    public class NativeContainerAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005B
    public class NativeContainerIsReadOnlyAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005C
    public class NativeContainerIsAtomicWriteOnlyAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005D
    public class NativeContainerSupportsMinMaxWriteRestrictionAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005E
    public class NativeContainerSupportsDeallocateOnJobCompletionAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005F
    public class NativeContainerSupportsDeferredConvertListToArray : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000060
    public class NativeSetThreadIndexAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000061
    public class NativeContainerNeedsThreadIndexAttribute : Attribute
    {
    }

    // TypeToken: 0x2000062
    public class WriteAccessRequiredAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000063
    public class NativeDisableUnsafePtrRestrictionAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000064
    public class NativeDisableContainerSafetyRestrictionAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000065
    public class NativeSetClassTypeToNullOnScheduleAttribute : Attribute
    {
    }

    // TypeToken: 0x2000066
    public class NativeArrayUnsafeUtility
    {
        // Methods
        private Unity.Collections.NativeArray<T> ConvertExistingDataToNativeArray(System.Void* dataPointer, System.Int32 length, Unity.Collections.Allocator allocator) { }
        private System.Void* GetUnsafePtr(Unity.Collections.NativeArray<T> nativeArray) { }
        private System.Void* GetUnsafeReadOnlyPtr(Unity.Collections.NativeArray<T> nativeArray) { }
        private System.Void* GetUnsafeBufferPointerWithoutChecks(Unity.Collections.NativeArray<T> nativeArray) { }

    }

    // TypeToken: 0x2000067
    public class NativeSliceUnsafeUtility
    {
        // Methods
        private Unity.Collections.NativeSlice<T> ConvertExistingDataToNativeSlice(System.Void* dataPointer, System.Int32 stride, System.Int32 length) { }
        private System.Void* GetUnsafePtr(Unity.Collections.NativeSlice<T> nativeSlice) { }
        private System.Void* GetUnsafeReadOnlyPtr(Unity.Collections.NativeSlice<T> nativeSlice) { }

    }

    // TypeToken: 0x2000068
    public class UnsafeUtility
    {
        // Methods
        private System.Int32 GetFieldOffsetInStruct(System.Reflection.FieldInfo field) { }
        private System.Int32 GetFieldOffsetInClass(System.Reflection.FieldInfo field) { }
        private System.Int32 GetFieldOffset(System.Reflection.FieldInfo field) { }
        private System.Void* PinGCObjectAndGetAddress(System.Object target, System.UInt64& gcHandle) { }
        private System.Void* PinGCArrayAndGetDataAddress(System.Array target, System.UInt64& gcHandle) { }
        private System.Void* PinSystemArrayAndGetAddress(System.Object target, System.UInt64& gcHandle) { }
        private System.Void* PinSystemObjectAndGetAddress(System.Object target, System.UInt64& gcHandle) { }
        private System.Void ReleaseGCObject(System.UInt64 gcHandle) { }
        private System.Boolean IsBlittable() { }
        private System.Int32 LeakRecord(System.IntPtr handle, Unity.Collections.LeakCategory category, System.Int32 callstacksToSkip) { }
        private System.Int32 LeakErase(System.IntPtr handle, Unity.Collections.LeakCategory category) { }
        private System.Void* MallocTracked(System.Int64 size, System.Int32 alignment, Unity.Collections.Allocator allocator, System.Int32 callstacksToSkip) { }
        private System.Void FreeTracked(System.Void* memory, Unity.Collections.Allocator allocator) { }
        private System.Void* Malloc(System.Int64 size, System.Int32 alignment, Unity.Collections.Allocator allocator) { }
        private System.Void Free(System.Void* memory, Unity.Collections.Allocator allocator) { }
        private System.Void MemCpy(System.Void* destination, System.Void* source, System.Int64 size) { }
        private System.Void MemCpyStride(System.Void* destination, System.Int32 destinationStride, System.Void* source, System.Int32 sourceStride, System.Int32 elementSize, System.Int32 count) { }
        private System.Void MemMove(System.Void* destination, System.Void* source, System.Int64 size) { }
        private System.Void MemSet(System.Void* destination, System.Byte value, System.Int64 size) { }
        private System.Void MemClear(System.Void* destination, System.Int64 size) { }
        private System.Int32 MemCmp(System.Void* ptr1, System.Void* ptr2, System.Int64 size) { }
        private System.Int32 SizeOf(System.Type type) { }
        private System.Boolean IsBlittable(System.Type type) { }
        private System.Boolean IsUnmanaged(System.Type type) { }
        private System.Boolean IsBlittableValueType(System.Type t) { }
        private System.String GetReasonForTypeNonBlittableImpl(System.Type t, System.String name) { }
        private System.Boolean IsArrayBlittable(System.Array arr) { }
        private System.Boolean IsGenericListBlittable() { }
        private System.String GetReasonForArrayNonBlittable(System.Array arr) { }
        private System.String GetReasonForGenericListNonBlittable() { }
        private System.Boolean IsUnmanaged() { }
        private System.Int32 AlignOf() { }
        private System.Void CopyPtrToStructure(System.Void* ptr, T& output) { }
        private System.Void InternalCopyPtrToStructure(System.Void* ptr, T& output) { }
        private System.Void CopyStructureToPtr(T& input, System.Void* ptr) { }
        private System.Void InternalCopyStructureToPtr(T& input, System.Void* ptr) { }
        private T ReadArrayElement(System.Void* source, System.Int32 index) { }
        private T ReadArrayElementWithStride(System.Void* source, System.Int32 index, System.Int32 stride) { }
        private System.Void WriteArrayElement(System.Void* destination, System.Int32 index, T value) { }
        private System.Void WriteArrayElementWithStride(System.Void* destination, System.Int32 index, System.Int32 stride, T value) { }
        private System.Void* AddressOf(T& output) { }
        private System.Int32 SizeOf() { }
        private T& As(U& from) { }
        private T& AsRef(System.Void* ptr) { }
        private T& ArrayElementAsRef(System.Void* ptr, System.Int32 index) { }
        private System.Int32 EnumToInt(T enumValue) { }
        private System.Void InternalEnumToInt(T& enumValue, System.Int32& intValue) { }
        private System.Boolean EnumEquals(T lhs, T rhs) { }

    }

}

namespace Unity.IL2CPP.CompilerServices
{

    // TypeToken: 0x2000033
    public class Il2CppEagerStaticClassConstructionAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace Unity.IO.LowLevel.Unsafe
{

    // TypeToken: 0x2000034
    public struct ReadCommand
    {
        // Fields
        public System.Void* Buffer;        // 0x10
        public System.Int64 Offset;        // 0x18
        public System.Int64 Size;        // 0x20

    }

    // TypeToken: 0x2000035
    public struct FileState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.IO.LowLevel.Unsafe.FileState Absent;        // 0x0
        public static Unity.IO.LowLevel.Unsafe.FileState Exists;        // 0x0

    }

    // TypeToken: 0x2000036
    public struct AssetLoadingSubsystem
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem Other;        // 0x0
        public static Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem Texture;        // 0x0
        public static Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem VirtualTexture;        // 0x0
        public static Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem Mesh;        // 0x0
        public static Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem Audio;        // 0x0
        public static Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem Scripts;        // 0x0
        public static Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem EntitiesScene;        // 0x0
        public static Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem EntitiesStreamBinaryReader;        // 0x0
        public static Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem FileInfo;        // 0x0

    }

    // TypeToken: 0x2000037
    public struct ReadStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.IO.LowLevel.Unsafe.ReadStatus Complete;        // 0x0
        public static Unity.IO.LowLevel.Unsafe.ReadStatus InProgress;        // 0x0
        public static Unity.IO.LowLevel.Unsafe.ReadStatus Failed;        // 0x0
        public static Unity.IO.LowLevel.Unsafe.ReadStatus Truncated;        // 0x0
        public static Unity.IO.LowLevel.Unsafe.ReadStatus Canceled;        // 0x0

    }

    // TypeToken: 0x2000038
    public struct Priority
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.IO.LowLevel.Unsafe.Priority PriorityLow;        // 0x0
        public static Unity.IO.LowLevel.Unsafe.Priority PriorityHigh;        // 0x0

    }

    // TypeToken: 0x2000039
    public struct ReadHandle, IDisposable
    {
        // Fields
        private System.IntPtr ptr;        // 0x10
        private System.Int32 version;        // 0x18

        // Methods
        private System.Boolean IsValid() { }
        private System.Void Dispose() { }
        private Unity.Jobs.JobHandle get_JobHandle() { }
        private Unity.IO.LowLevel.Unsafe.ReadStatus get_Status() { }
        private Unity.IO.LowLevel.Unsafe.ReadStatus GetReadStatus(Unity.IO.LowLevel.Unsafe.ReadHandle handle) { }
        private System.Void ReleaseReadHandle(Unity.IO.LowLevel.Unsafe.ReadHandle handle) { }
        private System.Boolean IsReadHandleValid(Unity.IO.LowLevel.Unsafe.ReadHandle handle) { }
        private Unity.Jobs.JobHandle GetJobHandle(Unity.IO.LowLevel.Unsafe.ReadHandle handle) { }
        private Unity.IO.LowLevel.Unsafe.ReadStatus GetReadStatus_Injected(Unity.IO.LowLevel.Unsafe.ReadHandle& handle) { }
        private System.Void ReleaseReadHandle_Injected(Unity.IO.LowLevel.Unsafe.ReadHandle& handle) { }
        private System.Boolean IsReadHandleValid_Injected(Unity.IO.LowLevel.Unsafe.ReadHandle& handle) { }
        private System.Void GetJobHandle_Injected(Unity.IO.LowLevel.Unsafe.ReadHandle& handle, Unity.Jobs.JobHandle& ret) { }

    }

    // TypeToken: 0x200003A
    public class AsyncReadManager
    {
        // Methods
        private Unity.IO.LowLevel.Unsafe.ReadHandle ReadInternal(System.String filename, System.Void* cmds, System.UInt32 cmdCount, System.String assetName, System.UInt64 typeID, Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem subsystem) { }
        private Unity.IO.LowLevel.Unsafe.ReadHandle Read(System.String filename, Unity.IO.LowLevel.Unsafe.ReadCommand* readCmds, System.UInt32 readCmdCount, System.String assetName, System.UInt64 typeID, Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem subsystem) { }
        private System.Void ReadInternal_Injected(System.String filename, System.Void* cmds, System.UInt32 cmdCount, System.String assetName, System.UInt64 typeID, Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem subsystem, Unity.IO.LowLevel.Unsafe.ReadHandle& ret) { }

    }

    // TypeToken: 0x200003B
    public struct ProcessingState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.IO.LowLevel.Unsafe.ProcessingState Unknown;        // 0x0
        public static Unity.IO.LowLevel.Unsafe.ProcessingState InQueue;        // 0x0
        public static Unity.IO.LowLevel.Unsafe.ProcessingState Reading;        // 0x0
        public static Unity.IO.LowLevel.Unsafe.ProcessingState Completed;        // 0x0
        public static Unity.IO.LowLevel.Unsafe.ProcessingState Failed;        // 0x0
        public static Unity.IO.LowLevel.Unsafe.ProcessingState Canceled;        // 0x0

    }

    // TypeToken: 0x200003C
    public struct FileReadType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.IO.LowLevel.Unsafe.FileReadType Sync;        // 0x0
        public static Unity.IO.LowLevel.Unsafe.FileReadType Async;        // 0x0

    }

    // TypeToken: 0x200003D
    public struct AsyncReadManagerRequestMetric
    {
        // Fields
        private readonly System.String <AssetName>k__BackingField;        // 0x10
        private readonly System.String <FileName>k__BackingField;        // 0x18
        private readonly System.UInt64 <OffsetBytes>k__BackingField;        // 0x20
        private readonly System.UInt64 <SizeBytes>k__BackingField;        // 0x28
        private readonly System.UInt64 <AssetTypeId>k__BackingField;        // 0x30
        private readonly System.UInt64 <CurrentBytesRead>k__BackingField;        // 0x38
        private readonly System.UInt32 <BatchReadCount>k__BackingField;        // 0x40
        private readonly System.Boolean <IsBatchRead>k__BackingField;        // 0x44
        private readonly Unity.IO.LowLevel.Unsafe.ProcessingState <State>k__BackingField;        // 0x48
        private readonly Unity.IO.LowLevel.Unsafe.FileReadType <ReadType>k__BackingField;        // 0x4C
        private readonly Unity.IO.LowLevel.Unsafe.Priority <PriorityLevel>k__BackingField;        // 0x50
        private readonly Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem <Subsystem>k__BackingField;        // 0x54
        private readonly System.Double <RequestTimeMicroseconds>k__BackingField;        // 0x58
        private readonly System.Double <TimeInQueueMicroseconds>k__BackingField;        // 0x60
        private readonly System.Double <TotalTimeMicroseconds>k__BackingField;        // 0x68

    }

    // TypeToken: 0x200003E
    public class AsyncReadManagerMetricsFilters
    {
        // Fields
        private System.UInt64[] TypeIDs;        // 0x10
        private Unity.IO.LowLevel.Unsafe.ProcessingState[] States;        // 0x18
        private Unity.IO.LowLevel.Unsafe.FileReadType[] ReadTypes;        // 0x20
        private Unity.IO.LowLevel.Unsafe.Priority[] PriorityLevels;        // 0x28
        private Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem[] Subsystems;        // 0x30

    }

}

namespace Unity.Jobs
{

    // TypeToken: 0x200001D
    public interface IJob
    {
        // Methods
        private System.Void Execute() { }

    }

    // TypeToken: 0x200001E
    public class IJobExtensions
    {
        // Methods
        private System.Void EarlyJobInit() { }
        private System.IntPtr GetReflectionData() { }
        private Unity.Jobs.JobHandle Schedule(T jobData, Unity.Jobs.JobHandle dependsOn) { }
        private System.Void Run(T jobData) { }
        private Unity.Jobs.JobHandle ScheduleManagedCrossFrameJob(T jobData, Unity.Jobs.LowLevel.Unsafe.JobQueuePriority priority, Unity.Jobs.JobHandle dependsOn) { }

    }

    // TypeToken: 0x2000021
    public interface IJobFor
    {
        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x2000022
    public class IJobForExtensions
    {
        // Methods
        private System.Void EarlyJobInit() { }
        private System.IntPtr GetReflectionData() { }
        private Unity.Jobs.JobHandle ScheduleParallel(T jobData, System.Int32 arrayLength, System.Int32 innerloopBatchCount, Unity.Jobs.JobHandle dependency) { }

    }

    // TypeToken: 0x2000025
    public interface IJobParallelFor
    {
        // Methods
        private System.Void Execute(System.Int32 index) { }

    }

    // TypeToken: 0x2000026
    public class IJobParallelForExtensions
    {
        // Methods
        private Unity.Jobs.JobHandle Schedule(T jobData, System.Int32 arrayLength, System.Int32 innerloopBatchCount, Unity.Jobs.JobHandle dependsOn) { }
        private System.Void Run(T jobData, System.Int32 arrayLength) { }

    }

    // TypeToken: 0x2000029
    public struct JobHandle, IEquatable`1
    {
        // Fields
        private System.UInt64 jobGroup;        // 0x10
        private System.Int32 jobType;        // 0x18

        // Methods
        private System.Void Complete() { }
        private System.Void CrossFrameComplete() { }
        private System.Boolean IsValid() { }
        private System.Void CompleteAll(Unity.Collections.NativeArray<Unity.Jobs.JobHandle> jobs) { }
        private System.Boolean get_IsCompleted() { }
        private System.Void ScheduleBatchedJobs() { }
        private System.Void ScheduleBatchedJobsAndComplete(Unity.Jobs.JobHandle& job) { }
        private System.Void ScheduleBatchedCrossFrameJobsAndComplete(Unity.Jobs.JobHandle& job) { }
        private System.Boolean ScheduleBatchedJobsAndIsCompleted(Unity.Jobs.JobHandle& job) { }
        private System.Void ScheduleBatchedJobsAndCompleteAll(System.Void* jobs, System.Int32 count) { }
        private Unity.Jobs.JobHandle CombineDependencies(Unity.Jobs.JobHandle job0, Unity.Jobs.JobHandle job1) { }
        private Unity.Jobs.JobHandle CombineDependencies(Unity.Jobs.JobHandle job0, Unity.Jobs.JobHandle job1, Unity.Jobs.JobHandle job2) { }
        private Unity.Jobs.JobHandle CombineDependencies(Unity.Collections.NativeArray<Unity.Jobs.JobHandle> jobs) { }
        private Unity.Jobs.JobHandle CombineDependenciesInternal2(Unity.Jobs.JobHandle& job0, Unity.Jobs.JobHandle& job1) { }
        private Unity.Jobs.JobHandle CombineDependenciesInternal3(Unity.Jobs.JobHandle& job0, Unity.Jobs.JobHandle& job1, Unity.Jobs.JobHandle& job2) { }
        private Unity.Jobs.JobHandle CombineDependenciesInternalPtr(System.Void* jobs, System.Int32 count) { }
        private System.Boolean Equals(Unity.Jobs.JobHandle other) { }
        private System.Void CombineDependenciesInternal2_Injected(Unity.Jobs.JobHandle& job0, Unity.Jobs.JobHandle& job1, Unity.Jobs.JobHandle& ret) { }
        private System.Void CombineDependenciesInternal3_Injected(Unity.Jobs.JobHandle& job0, Unity.Jobs.JobHandle& job1, Unity.Jobs.JobHandle& job2, Unity.Jobs.JobHandle& ret) { }
        private System.Void CombineDependenciesInternalPtr_Injected(System.Void* jobs, System.Int32 count, Unity.Jobs.JobHandle& ret) { }

    }

}

namespace Unity.Jobs.LowLevel.Unsafe
{

    // TypeToken: 0x200002A
    public struct BatchQueryJob`2
    {
        // Fields
        private Unity.Collections.NativeArray<CommandT> commands;        // 0x0
        private Unity.Collections.NativeArray<ResultT> results;        // 0x0

        // Methods
        private System.Void .ctor(Unity.Collections.NativeArray<CommandT> commands, Unity.Collections.NativeArray<ResultT> results) { }

    }

    // TypeToken: 0x200002B
    public struct BatchQueryJobStruct`1
    {
        // Fields
        private static System.IntPtr jobReflectionData;        // 0x0

        // Methods
        private System.IntPtr Initialize() { }

    }

    // TypeToken: 0x200002C
    public class JobProducerTypeAttribute : Attribute
    {
        // Fields
        private readonly System.Type <ProducerType>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor(System.Type producerType) { }

    }

    // TypeToken: 0x200002D
    public struct JobRanges
    {
        // Fields
        private System.Int32 BatchSize;        // 0x10
        private System.Int32 NumJobs;        // 0x14
        public System.Int32 TotalIterationCount;        // 0x18
        private System.IntPtr StartEndIndex;        // 0x20

    }

    // TypeToken: 0x200002E
    public struct ScheduleMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.Jobs.LowLevel.Unsafe.ScheduleMode Run;        // 0x0
        public static Unity.Jobs.LowLevel.Unsafe.ScheduleMode Batched;        // 0x0
        public static Unity.Jobs.LowLevel.Unsafe.ScheduleMode Parallel;        // 0x0
        public static Unity.Jobs.LowLevel.Unsafe.ScheduleMode Single;        // 0x0

    }

    // TypeToken: 0x200002F
    public struct JobQueuePriority
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.Jobs.LowLevel.Unsafe.JobQueuePriority NormalJobPriority;        // 0x0
        public static Unity.Jobs.LowLevel.Unsafe.JobQueuePriority HighJobPriority;        // 0x0

    }

    // TypeToken: 0x2000030
    public class JobsUtility
    {
        // Fields
        private static Unity.Jobs.LowLevel.Unsafe.JobsUtility.PanicFunction_ PanicFunction;        // 0x0

        // Methods
        private System.Void GetJobRange(Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex, System.Int32& beginIndex, System.Int32& endIndex) { }
        private System.Boolean GetWorkStealingRange(Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex, System.Int32& beginIndex, System.Int32& endIndex) { }
        private Unity.Jobs.JobHandle Schedule(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters) { }
        private Unity.Jobs.JobHandle ScheduleCrossFrameJob(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, Unity.Jobs.LowLevel.Unsafe.JobQueuePriority priority) { }
        private Unity.Jobs.JobHandle ScheduleJobCrossFrameJobTransformReadOnly(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.IntPtr transfromAccesssArray) { }
        private Unity.Jobs.JobHandle ScheduleJobCrossFrameJobTransform(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.IntPtr transfromAccesssArray) { }
        private Unity.Jobs.JobHandle ScheduleParallelFor(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.Int32 arrayLength, System.Int32 innerloopBatchCount) { }
        private Unity.Jobs.JobHandle ScheduleParallelForDeferArraySize(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.Int32 innerloopBatchCount, System.Void* listData, System.Void* listDataAtomicSafetyHandle) { }
        private Unity.Jobs.JobHandle ScheduleParallelForTransform(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.IntPtr transfromAccesssArray) { }
        private Unity.Jobs.JobHandle ScheduleParallelForTransformReadOnly(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.IntPtr transfromAccesssArray, System.Int32 innerloopBatchCount) { }
        private System.IntPtr CreateJobReflectionData(System.Type wrapperJobType, System.Type userJobType, System.Object managedJobFunction0, System.Object managedJobFunction1, System.Object managedJobFunction2) { }
        private System.IntPtr CreateJobReflectionData(System.Type type, System.Object managedJobFunction0, System.Object managedJobFunction1, System.Object managedJobFunction2) { }
        private System.IntPtr CreateJobReflectionData(System.Type wrapperJobType, System.Type userJobType, System.Object managedJobFunction0) { }
        private System.Boolean get_IsExecutingJob() { }
        private System.Void set_JobCompilerEnabled(System.Boolean value) { }
        private System.Int32 GetJobQueueWorkerThreadCount() { }
        private System.Int32 get_JobWorkerMaximumCount() { }
        private System.Int32 get_JobWorkerCount() { }
        private System.Void InvokePanicFunction() { }
        private System.Void Schedule_Injected(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, Unity.Jobs.JobHandle& ret) { }
        private System.Void ScheduleCrossFrameJob_Injected(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, Unity.Jobs.LowLevel.Unsafe.JobQueuePriority priority, Unity.Jobs.JobHandle& ret) { }
        private System.Void ScheduleJobCrossFrameJobTransformReadOnly_Injected(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.IntPtr transfromAccesssArray, Unity.Jobs.JobHandle& ret) { }
        private System.Void ScheduleJobCrossFrameJobTransform_Injected(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.IntPtr transfromAccesssArray, Unity.Jobs.JobHandle& ret) { }
        private System.Void ScheduleParallelFor_Injected(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.Int32 arrayLength, System.Int32 innerloopBatchCount, Unity.Jobs.JobHandle& ret) { }
        private System.Void ScheduleParallelForDeferArraySize_Injected(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.Int32 innerloopBatchCount, System.Void* listData, System.Void* listDataAtomicSafetyHandle, Unity.Jobs.JobHandle& ret) { }
        private System.Void ScheduleParallelForTransform_Injected(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.IntPtr transfromAccesssArray, Unity.Jobs.JobHandle& ret) { }
        private System.Void ScheduleParallelForTransformReadOnly_Injected(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.IntPtr transfromAccesssArray, System.Int32 innerloopBatchCount, Unity.Jobs.JobHandle& ret) { }

    }

}

namespace Unity.Profiling
{

    // TypeToken: 0x200000B
    public struct ProfilerCategory
    {
        // Fields
        private readonly System.UInt16 m_CategoryId;        // 0x10

        // Methods
        private System.Void .ctor(System.UInt16 category) { }
        private System.String get_Name() { }
        private System.String ToString() { }
        private Unity.Profiling.ProfilerCategory get_Scripts() { }
        private Unity.Profiling.ProfilerCategory get_Audio() { }
        private System.UInt16 op_Implicit(Unity.Profiling.ProfilerCategory category) { }

    }

    // TypeToken: 0x200000C
    public struct ProfilerMarker
    {
        // Fields
        private readonly System.IntPtr m_Ptr;        // 0x10

        // Methods
        private System.IntPtr get_Handle() { }
        private System.Void .ctor(System.String name) { }
        private System.Void .ctor(Unity.Profiling.ProfilerCategory category, System.String name) { }
        private System.Void Begin() { }
        private System.Void End() { }
        private Unity.Profiling.ProfilerMarker.AutoScope Auto() { }

    }

    // TypeToken: 0x200000E
    public struct ProfilerMarkerDataUnit
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static Unity.Profiling.ProfilerMarkerDataUnit Undefined;        // 0x0
        public static Unity.Profiling.ProfilerMarkerDataUnit TimeNanoseconds;        // 0x0
        public static Unity.Profiling.ProfilerMarkerDataUnit Bytes;        // 0x0
        public static Unity.Profiling.ProfilerMarkerDataUnit Count;        // 0x0
        public static Unity.Profiling.ProfilerMarkerDataUnit Percent;        // 0x0
        public static Unity.Profiling.ProfilerMarkerDataUnit FrequencyHz;        // 0x0

    }

    // TypeToken: 0x200000F
    public struct ProfilerCounterOptions
    {
        // Fields
        public System.UInt16 value__;        // 0x10
        public static Unity.Profiling.ProfilerCounterOptions None;        // 0x0
        public static Unity.Profiling.ProfilerCounterOptions FlushOnEndOfFrame;        // 0x0
        public static Unity.Profiling.ProfilerCounterOptions ResetToZeroOnFlush;        // 0x0

    }

    // TypeToken: 0x2000010
    public struct ProfilerRecorderOptions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.Profiling.ProfilerRecorderOptions None;        // 0x0
        public static Unity.Profiling.ProfilerRecorderOptions StartImmediately;        // 0x0
        public static Unity.Profiling.ProfilerRecorderOptions KeepAliveDuringDomainReload;        // 0x0
        public static Unity.Profiling.ProfilerRecorderOptions CollectOnlyOnCurrentThread;        // 0x0
        public static Unity.Profiling.ProfilerRecorderOptions WrapAroundWhenCapacityReached;        // 0x0
        public static Unity.Profiling.ProfilerRecorderOptions SumAllSamplesInFrame;        // 0x0
        public static Unity.Profiling.ProfilerRecorderOptions GpuRecorder;        // 0x0
        public static Unity.Profiling.ProfilerRecorderOptions Default;        // 0x0

    }

    // TypeToken: 0x2000011
    public struct ProfilerRecorderSample
    {
        // Fields
        private System.Int64 value;        // 0x10
        private System.Int64 count;        // 0x18
        private System.Int64 refValue;        // 0x20

        // Methods
        private System.Int64 get_Count() { }

    }

    // TypeToken: 0x2000012
    public struct ProfilerRecorder, IDisposable
    {
        // Fields
        private System.UInt64 handle;        // 0x10
        private static Unity.Profiling.ProfilerRecorderOptions SharedRecorder;        // 0x0

        // Methods
        private System.Void .ctor(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle statHandle, System.Int32 capacity, Unity.Profiling.ProfilerRecorderOptions options) { }
        private System.Boolean get_Valid() { }
        private System.Void Start() { }
        private System.Void Stop() { }
        private System.Int64 get_LastValue() { }
        private System.Int32 get_Count() { }
        private System.Boolean get_IsRunning() { }
        private Unity.Profiling.ProfilerRecorderSample GetSample(System.Int32 index) { }
        private Unity.Profiling.ProfilerRecorder Create(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle statHandle, System.Int32 maxSampleCount, Unity.Profiling.ProfilerRecorderOptions options) { }
        private System.Void Control(Unity.Profiling.ProfilerRecorder handle, Unity.Profiling.ProfilerRecorder.ControlOptions options) { }
        private System.Int64 GetLastValue(Unity.Profiling.ProfilerRecorder handle) { }
        private System.Int32 GetCount(Unity.Profiling.ProfilerRecorder handle, Unity.Profiling.ProfilerRecorder.CountOptions countOptions) { }
        private System.Boolean GetValid(Unity.Profiling.ProfilerRecorder handle) { }
        private System.Boolean GetRunning(Unity.Profiling.ProfilerRecorder handle) { }
        private Unity.Profiling.ProfilerRecorderSample GetSampleInternal(Unity.Profiling.ProfilerRecorder handle, System.Int32 index) { }
        private System.Void Dispose() { }
        private System.Void CheckInitializedAndThrow() { }
        private System.Void Create_Injected(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle& statHandle, System.Int32 maxSampleCount, Unity.Profiling.ProfilerRecorderOptions options, Unity.Profiling.ProfilerRecorder& ret) { }
        private System.Void Control_Injected(Unity.Profiling.ProfilerRecorder& handle, Unity.Profiling.ProfilerRecorder.ControlOptions options) { }
        private System.Int64 GetLastValue_Injected(Unity.Profiling.ProfilerRecorder& handle) { }
        private System.Int32 GetCount_Injected(Unity.Profiling.ProfilerRecorder& handle, Unity.Profiling.ProfilerRecorder.CountOptions countOptions) { }
        private System.Boolean GetValid_Injected(Unity.Profiling.ProfilerRecorder& handle) { }
        private System.Boolean GetRunning_Injected(Unity.Profiling.ProfilerRecorder& handle) { }
        private System.Void GetSampleInternal_Injected(Unity.Profiling.ProfilerRecorder& handle, System.Int32 index, Unity.Profiling.ProfilerRecorderSample& ret) { }

    }

    // TypeToken: 0x2000015
    public class ProfilerRecorderDebugView
    {
    }

}

namespace Unity.Profiling.LowLevel
{

    // TypeToken: 0x2000016
    public struct MarkerFlags
    {
        // Fields
        public System.UInt16 value__;        // 0x10
        public static Unity.Profiling.LowLevel.MarkerFlags Default;        // 0x0
        public static Unity.Profiling.LowLevel.MarkerFlags Script;        // 0x0
        public static Unity.Profiling.LowLevel.MarkerFlags ScriptInvoke;        // 0x0
        public static Unity.Profiling.LowLevel.MarkerFlags ScriptDeepProfiler;        // 0x0
        public static Unity.Profiling.LowLevel.MarkerFlags AvailabilityEditor;        // 0x0
        public static Unity.Profiling.LowLevel.MarkerFlags AvailabilityNonDevelopment;        // 0x0
        public static Unity.Profiling.LowLevel.MarkerFlags Warning;        // 0x0
        public static Unity.Profiling.LowLevel.MarkerFlags Counter;        // 0x0
        public static Unity.Profiling.LowLevel.MarkerFlags SampleGPU;        // 0x0

    }

    // TypeToken: 0x2000017
    public struct ProfilerMarkerDataType
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static Unity.Profiling.LowLevel.ProfilerMarkerDataType Int32;        // 0x0
        public static Unity.Profiling.LowLevel.ProfilerMarkerDataType UInt32;        // 0x0
        public static Unity.Profiling.LowLevel.ProfilerMarkerDataType Int64;        // 0x0
        public static Unity.Profiling.LowLevel.ProfilerMarkerDataType UInt64;        // 0x0
        public static Unity.Profiling.LowLevel.ProfilerMarkerDataType Float;        // 0x0
        public static Unity.Profiling.LowLevel.ProfilerMarkerDataType Double;        // 0x0
        public static Unity.Profiling.LowLevel.ProfilerMarkerDataType String16;        // 0x0
        public static Unity.Profiling.LowLevel.ProfilerMarkerDataType Blob8;        // 0x0

    }

}

namespace Unity.Profiling.LowLevel.Unsafe
{

    // TypeToken: 0x2000018
    public struct ProfilerRecorderDescription
    {
        // Fields
        private readonly Unity.Profiling.ProfilerCategory category;        // 0x10
        private readonly Unity.Profiling.LowLevel.MarkerFlags flags;        // 0x12
        private readonly Unity.Profiling.LowLevel.ProfilerMarkerDataType dataType;        // 0x14
        private readonly Unity.Profiling.ProfilerMarkerDataUnit unitType;        // 0x15
        private readonly System.Int32 reserved0;        // 0x18
        private readonly System.Int32 nameUtf8Len;        // 0x1C
        private readonly System.Byte* nameUtf8;        // 0x20

        // Methods
        private Unity.Profiling.LowLevel.MarkerFlags get_Flags() { }

    }

    // TypeToken: 0x2000019
    public struct ProfilerRecorderHandle
    {
        // Fields
        private readonly System.UInt64 handle;        // 0x10

        // Methods
        private System.Void .ctor(System.UInt64 handle) { }
        private System.Boolean get_Valid() { }
        private Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription GetDescription(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle handle) { }
        private Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription GetDescriptionInternal(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle handle) { }
        private System.Void GetDescriptionInternal_Injected(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle& handle, Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription& ret) { }

    }

    // TypeToken: 0x200001A
    public struct ProfilerMarkerData
    {
        // Fields
        public System.Byte Type;        // 0x10
        private readonly System.Byte reserved0;        // 0x11
        private readonly System.UInt16 reserved1;        // 0x12
        public System.UInt32 Size;        // 0x14
        public System.Void* Ptr;        // 0x18

    }

    // TypeToken: 0x200001B
    public struct ProfilerCategoryDescription
    {
        // Fields
        public readonly System.UInt16 Id;        // 0x10
        public readonly System.UInt16 Flags;        // 0x12
        public readonly UnityEngine.Color32 Color;        // 0x14
        private readonly System.Int32 reserved0;        // 0x18
        public readonly System.Int32 NameUtf8Len;        // 0x1C
        public readonly System.Byte* NameUtf8;        // 0x20

    }

    // TypeToken: 0x200001C
    public class ProfilerUnsafeUtility
    {
        // Methods
        private Unity.Profiling.LowLevel.Unsafe.ProfilerCategoryDescription GetCategoryDescription(System.UInt16 categoryId) { }
        private System.IntPtr CreateMarker(System.String name, System.UInt16 categoryId, Unity.Profiling.LowLevel.MarkerFlags flags, System.Int32 metadataCount) { }
        private System.Void BeginSample(System.IntPtr markerPtr) { }
        private System.Void BeginSampleWithMetadata(System.IntPtr markerPtr, System.Int32 metadataCount, System.Void* metadata) { }
        private System.Void EndSample(System.IntPtr markerPtr) { }
        private System.String Utf8ToString(System.Byte* chars, System.Int32 charsLen) { }
        private System.Void GetCategoryDescription_Injected(System.UInt16 categoryId, Unity.Profiling.LowLevel.Unsafe.ProfilerCategoryDescription& ret) { }

    }

}

namespace UnityEngine
{

    // TypeToken: 0x2000077
    public struct SendMessageOptions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.SendMessageOptions RequireReceiver;        // 0x0
        public static UnityEngine.SendMessageOptions DontRequireReceiver;        // 0x0

    }

    // TypeToken: 0x2000078
    public struct PrimitiveType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.PrimitiveType Sphere;        // 0x0
        public static UnityEngine.PrimitiveType Capsule;        // 0x0
        public static UnityEngine.PrimitiveType Cylinder;        // 0x0
        public static UnityEngine.PrimitiveType Cube;        // 0x0
        public static UnityEngine.PrimitiveType Plane;        // 0x0
        public static UnityEngine.PrimitiveType Quad;        // 0x0

    }

    // TypeToken: 0x2000079
    public struct Space
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Space World;        // 0x0
        public static UnityEngine.Space Self;        // 0x0

    }

    // TypeToken: 0x200007A
    public struct RuntimePlatform
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.RuntimePlatform OSXEditor;        // 0x0
        public static UnityEngine.RuntimePlatform OSXPlayer;        // 0x0
        public static UnityEngine.RuntimePlatform WindowsPlayer;        // 0x0
        public static UnityEngine.RuntimePlatform OSXWebPlayer;        // 0x0
        public static UnityEngine.RuntimePlatform OSXDashboardPlayer;        // 0x0
        public static UnityEngine.RuntimePlatform WindowsWebPlayer;        // 0x0
        public static UnityEngine.RuntimePlatform WindowsEditor;        // 0x0
        public static UnityEngine.RuntimePlatform IPhonePlayer;        // 0x0
        public static UnityEngine.RuntimePlatform XBOX360;        // 0x0
        public static UnityEngine.RuntimePlatform PS3;        // 0x0
        public static UnityEngine.RuntimePlatform Android;        // 0x0
        public static UnityEngine.RuntimePlatform NaCl;        // 0x0
        public static UnityEngine.RuntimePlatform FlashPlayer;        // 0x0
        public static UnityEngine.RuntimePlatform LinuxPlayer;        // 0x0
        public static UnityEngine.RuntimePlatform LinuxEditor;        // 0x0
        public static UnityEngine.RuntimePlatform WebGLPlayer;        // 0x0
        public static UnityEngine.RuntimePlatform MetroPlayerX86;        // 0x0
        public static UnityEngine.RuntimePlatform WSAPlayerX86;        // 0x0
        public static UnityEngine.RuntimePlatform MetroPlayerX64;        // 0x0
        public static UnityEngine.RuntimePlatform WSAPlayerX64;        // 0x0
        public static UnityEngine.RuntimePlatform MetroPlayerARM;        // 0x0
        public static UnityEngine.RuntimePlatform WSAPlayerARM;        // 0x0
        public static UnityEngine.RuntimePlatform WP8Player;        // 0x0
        public static UnityEngine.RuntimePlatform BlackBerryPlayer;        // 0x0
        public static UnityEngine.RuntimePlatform TizenPlayer;        // 0x0
        public static UnityEngine.RuntimePlatform PSP2;        // 0x0
        public static UnityEngine.RuntimePlatform PS4;        // 0x0
        public static UnityEngine.RuntimePlatform PSM;        // 0x0
        public static UnityEngine.RuntimePlatform XboxOne;        // 0x0
        public static UnityEngine.RuntimePlatform SamsungTVPlayer;        // 0x0
        public static UnityEngine.RuntimePlatform WiiU;        // 0x0
        public static UnityEngine.RuntimePlatform tvOS;        // 0x0
        public static UnityEngine.RuntimePlatform Switch;        // 0x0
        public static UnityEngine.RuntimePlatform Lumin;        // 0x0
        public static UnityEngine.RuntimePlatform Stadia;        // 0x0
        public static UnityEngine.RuntimePlatform CloudRendering;        // 0x0
        public static UnityEngine.RuntimePlatform GameCoreScarlett;        // 0x0
        public static UnityEngine.RuntimePlatform GameCoreXboxSeries;        // 0x0
        public static UnityEngine.RuntimePlatform GameCoreXboxOne;        // 0x0
        public static UnityEngine.RuntimePlatform PS5;        // 0x0
        public static UnityEngine.RuntimePlatform EmbeddedLinuxArm64;        // 0x0
        public static UnityEngine.RuntimePlatform EmbeddedLinuxArm32;        // 0x0
        public static UnityEngine.RuntimePlatform EmbeddedLinuxX64;        // 0x0
        public static UnityEngine.RuntimePlatform EmbeddedLinuxX86;        // 0x0
        public static UnityEngine.RuntimePlatform LinuxServer;        // 0x0
        public static UnityEngine.RuntimePlatform WindowsServer;        // 0x0
        public static UnityEngine.RuntimePlatform OSXServer;        // 0x0

    }

    // TypeToken: 0x200007B
    public struct SystemLanguage
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.SystemLanguage Afrikaans;        // 0x0
        public static UnityEngine.SystemLanguage Arabic;        // 0x0
        public static UnityEngine.SystemLanguage Basque;        // 0x0
        public static UnityEngine.SystemLanguage Belarusian;        // 0x0
        public static UnityEngine.SystemLanguage Bulgarian;        // 0x0
        public static UnityEngine.SystemLanguage Catalan;        // 0x0
        public static UnityEngine.SystemLanguage Chinese;        // 0x0
        public static UnityEngine.SystemLanguage Czech;        // 0x0
        public static UnityEngine.SystemLanguage Danish;        // 0x0
        public static UnityEngine.SystemLanguage Dutch;        // 0x0
        public static UnityEngine.SystemLanguage English;        // 0x0
        public static UnityEngine.SystemLanguage Estonian;        // 0x0
        public static UnityEngine.SystemLanguage Faroese;        // 0x0
        public static UnityEngine.SystemLanguage Finnish;        // 0x0
        public static UnityEngine.SystemLanguage French;        // 0x0
        public static UnityEngine.SystemLanguage German;        // 0x0
        public static UnityEngine.SystemLanguage Greek;        // 0x0
        public static UnityEngine.SystemLanguage Hebrew;        // 0x0
        public static UnityEngine.SystemLanguage Icelandic;        // 0x0
        public static UnityEngine.SystemLanguage Indonesian;        // 0x0
        public static UnityEngine.SystemLanguage Italian;        // 0x0
        public static UnityEngine.SystemLanguage Japanese;        // 0x0
        public static UnityEngine.SystemLanguage Korean;        // 0x0
        public static UnityEngine.SystemLanguage Latvian;        // 0x0
        public static UnityEngine.SystemLanguage Lithuanian;        // 0x0
        public static UnityEngine.SystemLanguage Norwegian;        // 0x0
        public static UnityEngine.SystemLanguage Polish;        // 0x0
        public static UnityEngine.SystemLanguage Portuguese;        // 0x0
        public static UnityEngine.SystemLanguage Romanian;        // 0x0
        public static UnityEngine.SystemLanguage Russian;        // 0x0
        public static UnityEngine.SystemLanguage SerboCroatian;        // 0x0
        public static UnityEngine.SystemLanguage Slovak;        // 0x0
        public static UnityEngine.SystemLanguage Slovenian;        // 0x0
        public static UnityEngine.SystemLanguage Spanish;        // 0x0
        public static UnityEngine.SystemLanguage Swedish;        // 0x0
        public static UnityEngine.SystemLanguage Thai;        // 0x0
        public static UnityEngine.SystemLanguage Turkish;        // 0x0
        public static UnityEngine.SystemLanguage Ukrainian;        // 0x0
        public static UnityEngine.SystemLanguage Vietnamese;        // 0x0
        public static UnityEngine.SystemLanguage ChineseSimplified;        // 0x0
        public static UnityEngine.SystemLanguage ChineseTraditional;        // 0x0
        public static UnityEngine.SystemLanguage Unknown;        // 0x0
        public static UnityEngine.SystemLanguage Hungarian;        // 0x0

    }

    // TypeToken: 0x200007C
    public struct LogType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.LogType Critical;        // 0x0
        public static UnityEngine.LogType Error;        // 0x0
        public static UnityEngine.LogType Assert;        // 0x0
        public static UnityEngine.LogType Warning;        // 0x0
        public static UnityEngine.LogType Log;        // 0x0
        public static UnityEngine.LogType Exception;        // 0x0

    }

    // TypeToken: 0x200007D
    public struct LogOption
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.LogOption None;        // 0x0
        public static UnityEngine.LogOption NoStacktrace;        // 0x0

    }

    // TypeToken: 0x200007E
    public struct ThreadPriority
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.ThreadPriority Low;        // 0x0
        public static UnityEngine.ThreadPriority BelowNormal;        // 0x0
        public static UnityEngine.ThreadPriority Normal;        // 0x0
        public static UnityEngine.ThreadPriority High;        // 0x0

    }

    // TypeToken: 0x200007F
    public struct SortingLayer
    {
        // Fields
        private System.Int32 m_Id;        // 0x10

        // Methods
        private System.String get_name() { }
        private UnityEngine.SortingLayer[] get_layers() { }
        private System.Int32[] GetSortingLayerIDsInternal() { }
        private System.Int32 GetLayerValueFromID(System.Int32 id) { }
        private System.Int32 NameToID(System.String name) { }
        private System.String IDToName(System.Int32 id) { }
        private System.Boolean IsValid(System.Int32 id) { }

    }

    // TypeToken: 0x2000080
    public struct WeightedMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.WeightedMode None;        // 0x0
        public static UnityEngine.WeightedMode In;        // 0x0
        public static UnityEngine.WeightedMode Out;        // 0x0
        public static UnityEngine.WeightedMode Both;        // 0x0

    }

    // TypeToken: 0x2000081
    public struct Keyframe
    {
        // Fields
        private System.Single m_Time;        // 0x10
        private System.Single m_Value;        // 0x14
        private System.Single m_InTangent;        // 0x18
        private System.Single m_OutTangent;        // 0x1C
        private System.Int32 m_WeightedMode;        // 0x20
        private System.Single m_InWeight;        // 0x24
        private System.Single m_OutWeight;        // 0x28

        // Methods
        private System.Void .ctor(System.Single time, System.Single value) { }
        private System.Void .ctor(System.Single time, System.Single value, System.Single inTangent, System.Single outTangent) { }
        private System.Void .ctor(System.Single time, System.Single value, System.Single inTangent, System.Single outTangent, System.Single inWeight, System.Single outWeight) { }
        private System.Single get_time() { }
        private System.Void set_time(System.Single value) { }
        private System.Single get_value() { }
        private System.Void set_value(System.Single value) { }
        private System.Single get_inTangent() { }
        private System.Void set_inTangent(System.Single value) { }
        private System.Single get_outTangent() { }
        private System.Void set_outTangent(System.Single value) { }
        private System.Single get_inWeight() { }
        private System.Void set_inWeight(System.Single value) { }
        private System.Single get_outWeight() { }
        private System.Void set_outWeight(System.Single value) { }
        private UnityEngine.WeightedMode get_weightedMode() { }
        private System.Void set_weightedMode(UnityEngine.WeightedMode value) { }
        private System.Int32 get_tangentMode() { }
        private System.Void set_tangentMode(System.Int32 value) { }
        private System.Int32 get_tangentModeInternal() { }
        private System.Void set_tangentModeInternal(System.Int32 value) { }

    }

    // TypeToken: 0x2000082
    public struct WrapMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.WrapMode Once;        // 0x0
        public static UnityEngine.WrapMode Loop;        // 0x0
        public static UnityEngine.WrapMode PingPong;        // 0x0
        public static UnityEngine.WrapMode Default;        // 0x0
        public static UnityEngine.WrapMode ClampForever;        // 0x0
        public static UnityEngine.WrapMode Clamp;        // 0x0

    }

    // TypeToken: 0x2000083
    public class AnimationCurve, IEquatable`1
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10

        // Methods
        private System.Void Internal_Destroy(System.IntPtr ptr) { }
        private System.IntPtr Internal_Create(UnityEngine.Keyframe[] keys) { }
        private System.Boolean Internal_Equals(System.IntPtr other) { }
        private System.Void Finalize() { }
        private System.Single Evaluate(System.Single time) { }
        private UnityEngine.Keyframe[] get_keys() { }
        private System.Void set_keys(UnityEngine.Keyframe[] value) { }
        private System.Int32 AddKey(System.Single time, System.Single value) { }
        private System.Int32 AddKey(UnityEngine.Keyframe key) { }
        private System.Int32 AddKey_Internal(UnityEngine.Keyframe key) { }
        private System.Int32 MoveKey(System.Int32 index, UnityEngine.Keyframe key) { }
        private System.Void RemoveKey(System.Int32 index) { }
        private UnityEngine.Keyframe get_Item(System.Int32 index) { }
        private System.Int32 get_length() { }
        private System.Void SetKeys(UnityEngine.Keyframe[] keys) { }
        private System.Void SetKeys(Unity.Collections.NativeArray<UnityEngine.Keyframe> keys, System.Int32 count) { }
        private System.Void Internal_SetKeysNoGC(System.IntPtr keys, System.Int32 count) { }
        private UnityEngine.Keyframe GetKey(System.Int32 index) { }
        private UnityEngine.Keyframe[] GetKeys() { }
        private System.Void SmoothTangents(System.Int32 index, System.Single weight) { }
        private UnityEngine.AnimationCurve Constant(System.Single timeStart, System.Single timeEnd, System.Single value) { }
        private UnityEngine.AnimationCurve Linear(System.Single timeStart, System.Single valueStart, System.Single timeEnd, System.Single valueEnd) { }
        private UnityEngine.AnimationCurve EaseInOut(System.Single timeStart, System.Single valueStart, System.Single timeEnd, System.Single valueEnd) { }
        private UnityEngine.WrapMode get_preWrapMode() { }
        private System.Void set_preWrapMode(UnityEngine.WrapMode value) { }
        private UnityEngine.WrapMode get_postWrapMode() { }
        private System.Void set_postWrapMode(UnityEngine.WrapMode value) { }
        private System.Void .ctor(UnityEngine.Keyframe[] keys) { }
        private System.Void .ctor() { }
        private System.Boolean Equals(System.Object o) { }
        private System.Boolean Equals(UnityEngine.AnimationCurve other) { }
        private System.Int32 GetHashCode() { }
        private System.Int32 AddKey_Internal_Injected(UnityEngine.Keyframe& key) { }
        private System.Int32 MoveKey_Injected(System.Int32 index, UnityEngine.Keyframe& key) { }
        private System.Void GetKey_Injected(System.Int32 index, UnityEngine.Keyframe& ret) { }

    }

    // TypeToken: 0x2000084
    public class Application
    {
        // Fields
        private static UnityEngine.Application.LowMemoryCallback lowMemory;        // 0x0
        private static UnityEngine.Application.LogCallback s_LogCallbackHandler;        // 0x8
        private static UnityEngine.Application.LogCallback s_LogCallbackHandlerThreaded;        // 0x10
        private static UnityEngine.Application.AdvertisingIdentifierCallback OnAdvertisingIdentifierCallback;        // 0x18
        private static System.Action<System.Boolean> focusChanged;        // 0x20
        private static System.Action<System.String> deepLinkActivated;        // 0x28
        private static System.Func<System.Boolean> wantsToQuit;        // 0x30
        private static System.Action quitting;        // 0x38
        private static System.Action unloading;        // 0x40
        private static UnityEngine.Application.LogCallback s_RegisterLogCallbackDeprecated;        // 0x48

        // Methods
        private System.Void Quit(System.Int32 exitCode) { }
        private System.Void Quit() { }
        private System.Void CancelQuit() { }
        private System.Void Unload() { }
        private System.Boolean get_isLoadingLevel() { }
        private System.Single GetStreamProgressForLevel(System.Int32 levelIndex) { }
        private System.Single GetStreamProgressForLevel(System.String levelName) { }
        private System.Int32 get_streamedBytes() { }
        private System.Boolean get_webSecurityEnabled() { }
        private System.Boolean CanStreamedLevelBeLoaded(System.Int32 levelIndex) { }
        private System.Boolean CanStreamedLevelBeLoaded(System.String levelName) { }
        private System.Boolean get_isPlaying() { }
        private System.Boolean IsPlaying(UnityEngine.Object obj) { }
        private System.Boolean get_isFocused() { }
        private System.String[] GetBuildTags() { }
        private System.Void SetBuildTags(System.String[] buildTags) { }
        private System.String get_buildGUID() { }
        private System.Boolean get_runInBackground() { }
        private System.Void set_runInBackground(System.Boolean value) { }
        private System.Boolean HasProLicense() { }
        private System.Boolean get_isBatchMode() { }
        private System.Boolean get_isTestRun() { }
        private System.Boolean get_isHumanControllingUs() { }
        private System.Boolean HasARGV(System.String name) { }
        private System.String GetValueForARGV(System.String name) { }
        private System.String get_dataPath() { }
        private System.String get_streamingAssetsPath() { }
        private System.String get_persistentDataPath() { }
        private System.String get_temporaryCachePath() { }
        private System.String get_absoluteURL() { }
        private System.Void ExternalEval(System.String script) { }
        private System.Void Internal_ExternalCall(System.String script) { }
        private System.String get_unityVersion() { }
        private System.String get_unityBuildVersion() { }
        private System.String get_unityBuildBranch() { }
        private System.String get_unityBuildDate() { }
        private System.String get_unityBuildChangeList() { }
        private System.String get_unityCacheServerNamespace() { }
        private System.String get_unityRemoteShaderCacheNamespace() { }
        private System.Int32 get_unityVersionVer() { }
        private System.Int32 get_unityVersionMaj() { }
        private System.Int32 get_unityVersionMin() { }
        private System.String get_version() { }
        private System.String get_installerName() { }
        private System.String get_identifier() { }
        private UnityEngine.ApplicationInstallMode get_installMode() { }
        private UnityEngine.ApplicationSandboxType get_sandboxType() { }
        private System.String get_productName() { }
        private System.String get_companyName() { }
        private System.Boolean get_isRemoveSerializedFileExternalRef() { }
        private System.Void set_isRemoveSerializedFileExternalRef(System.Boolean value) { }
        private System.Boolean get_isRemoveABPreloadData() { }
        private System.Void set_isRemoveABPreloadData(System.Boolean value) { }
        private System.Boolean get_obsoletePhysicsAPI() { }
        private System.Void set_obsoletePhysicsAPI(System.Boolean value) { }
        private System.String get_cloudProjectId() { }
        private System.Boolean RequestAdvertisingIdentifierAsync(UnityEngine.Application.AdvertisingIdentifierCallback delegateMethod) { }
        private System.Void OpenURL(System.String url) { }
        private System.Void ForceCrash(System.Int32 mode) { }
        private System.Int32 get_targetFrameRate() { }
        private System.Void set_targetFrameRate(System.Int32 value) { }
        private System.Void SetLogCallbackDefined(System.Boolean defined) { }
        private UnityEngine.StackTraceLogType get_stackTraceLogType() { }
        private System.Void set_stackTraceLogType(UnityEngine.StackTraceLogType value) { }
        private UnityEngine.StackTraceLogType GetStackTraceLogType(UnityEngine.LogType logType) { }
        private System.Void SetStackTraceLogType(UnityEngine.LogType logType, UnityEngine.StackTraceLogType stackTraceType) { }
        private System.String get_consoleLogPath() { }
        private UnityEngine.ThreadPriority get_backgroundLoadingPriority() { }
        private System.Void set_backgroundLoadingPriority(UnityEngine.ThreadPriority value) { }
        private System.Boolean get_genuine() { }
        private System.Boolean get_genuineCheckAvailable() { }
        private UnityEngine.AsyncOperation RequestUserAuthorization(UnityEngine.UserAuthorization mode) { }
        private System.Boolean HasUserAuthorization(UnityEngine.UserAuthorization mode) { }
        private System.Boolean get_submitAnalytics() { }
        private System.Boolean get_isShowingSplashScreen() { }
        private UnityEngine.RuntimePlatform get_platform() { }
        private System.Boolean get_isMobilePlatform() { }
        private System.Boolean get_isConsolePlatform() { }
        private UnityEngine.SystemLanguage get_systemLanguage() { }
        private UnityEngine.NetworkReachability get_internetReachability() { }
        private System.Boolean get_enableHGFramePacing() { }
        private System.Void add_lowMemory(UnityEngine.Application.LowMemoryCallback value) { }
        private System.Void remove_lowMemory(UnityEngine.Application.LowMemoryCallback value) { }
        private System.Void CallLowMemory() { }
        private System.Void add_logMessageReceived(UnityEngine.Application.LogCallback value) { }
        private System.Void remove_logMessageReceived(UnityEngine.Application.LogCallback value) { }
        private System.Void add_logMessageReceivedThreaded(UnityEngine.Application.LogCallback value) { }
        private System.Void remove_logMessageReceivedThreaded(UnityEngine.Application.LogCallback value) { }
        private System.Void CallLogCallback(System.String logString, System.String stackTrace, UnityEngine.LogType type, System.Boolean invokedOnMainThread) { }
        private System.Void InvokeOnAdvertisingIdentifierCallback(System.String advertisingId, System.Boolean trackingEnabled) { }
        private System.String ObjectToJSString(System.Object o) { }
        private System.Void ExternalCall(System.String functionName, System.Object[] args) { }
        private System.String BuildInvocationForArguments(System.String functionName, System.Object[] args) { }
        private System.Boolean get_isPlayer() { }
        private System.Void DontDestroyOnLoad(UnityEngine.Object o) { }
        private System.Void CaptureScreenshot(System.String filename, System.Int32 superSize) { }
        private System.Void CaptureScreenshot(System.String filename) { }
        private System.Void add_onBeforeRender(UnityEngine.Events.UnityAction value) { }
        private System.Void remove_onBeforeRender(UnityEngine.Events.UnityAction value) { }
        private System.Void add_focusChanged(System.Action<System.Boolean> value) { }
        private System.Void remove_focusChanged(System.Action<System.Boolean> value) { }
        private System.Void add_deepLinkActivated(System.Action<System.String> value) { }
        private System.Void remove_deepLinkActivated(System.Action<System.String> value) { }
        private System.Void add_wantsToQuit(System.Func<System.Boolean> value) { }
        private System.Void remove_wantsToQuit(System.Func<System.Boolean> value) { }
        private System.Void add_quitting(System.Action value) { }
        private System.Void remove_quitting(System.Action value) { }
        private System.Void add_unloading(System.Action value) { }
        private System.Void remove_unloading(System.Action value) { }
        private System.Boolean Internal_ApplicationWantsToQuit() { }
        private System.Void Internal_ApplicationQuit() { }
        private System.Void Internal_ApplicationUnload() { }
        private System.Void InvokeOnBeforeRender() { }
        private System.Void InvokeFocusChanged(System.Boolean focus) { }
        private System.Void InvokeDeepLinkActivated(System.String url) { }
        private System.Void RegisterLogCallback(UnityEngine.Application.LogCallback handler) { }
        private System.Void RegisterLogCallbackThreaded(UnityEngine.Application.LogCallback handler) { }
        private System.Void RegisterLogCallback(UnityEngine.Application.LogCallback handler, System.Boolean threaded) { }
        private System.Int32 get_levelCount() { }
        private System.Int32 get_loadedLevel() { }
        private System.String get_loadedLevelName() { }
        private System.Void LoadLevel(System.Int32 index) { }
        private System.Void LoadLevel(System.String name) { }
        private System.Void LoadLevelAdditive(System.Int32 index) { }
        private System.Void LoadLevelAdditive(System.String name) { }
        private UnityEngine.AsyncOperation LoadLevelAsync(System.Int32 index) { }
        private UnityEngine.AsyncOperation LoadLevelAsync(System.String levelName) { }
        private UnityEngine.AsyncOperation LoadLevelAdditiveAsync(System.Int32 index) { }
        private UnityEngine.AsyncOperation LoadLevelAdditiveAsync(System.String levelName) { }
        private System.Boolean UnloadLevel(System.Int32 index) { }
        private System.Boolean UnloadLevel(System.String scenePath) { }
        private System.Boolean get_isEditor() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000088
    public struct StackTraceLogType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.StackTraceLogType None;        // 0x0
        public static UnityEngine.StackTraceLogType ScriptOnly;        // 0x0
        public static UnityEngine.StackTraceLogType Full;        // 0x0

    }

    // TypeToken: 0x2000089
    public struct NetworkReachability
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.NetworkReachability NotReachable;        // 0x0
        public static UnityEngine.NetworkReachability ReachableViaCarrierDataNetwork;        // 0x0
        public static UnityEngine.NetworkReachability ReachableViaLocalAreaNetwork;        // 0x0

    }

    // TypeToken: 0x200008A
    public struct UserAuthorization
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UserAuthorization WebCam;        // 0x0
        public static UnityEngine.UserAuthorization Microphone;        // 0x0

    }

    // TypeToken: 0x200008B
    public struct ApplicationInstallMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.ApplicationInstallMode Unknown;        // 0x0
        public static UnityEngine.ApplicationInstallMode Store;        // 0x0
        public static UnityEngine.ApplicationInstallMode DeveloperBuild;        // 0x0
        public static UnityEngine.ApplicationInstallMode Adhoc;        // 0x0
        public static UnityEngine.ApplicationInstallMode Enterprise;        // 0x0
        public static UnityEngine.ApplicationInstallMode Editor;        // 0x0

    }

    // TypeToken: 0x200008C
    public struct ApplicationSandboxType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.ApplicationSandboxType Unknown;        // 0x0
        public static UnityEngine.ApplicationSandboxType NotSandboxed;        // 0x0
        public static UnityEngine.ApplicationSandboxType Sandboxed;        // 0x0
        public static UnityEngine.ApplicationSandboxType SandboxBroken;        // 0x0

    }

    // TypeToken: 0x200008D
    public struct AudioType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.AudioType UNKNOWN;        // 0x0
        public static UnityEngine.AudioType ACC;        // 0x0
        public static UnityEngine.AudioType AIFF;        // 0x0
        public static UnityEngine.AudioType IT;        // 0x0
        public static UnityEngine.AudioType MOD;        // 0x0
        public static UnityEngine.AudioType MPEG;        // 0x0
        public static UnityEngine.AudioType OGGVORBIS;        // 0x0
        public static UnityEngine.AudioType S3M;        // 0x0
        public static UnityEngine.AudioType WAV;        // 0x0
        public static UnityEngine.AudioType XM;        // 0x0
        public static UnityEngine.AudioType XMA;        // 0x0
        public static UnityEngine.AudioType VAG;        // 0x0
        public static UnityEngine.AudioType AUDIOQUEUE;        // 0x0

    }

    // TypeToken: 0x200008E
    public class BootConfigData
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10

        // Methods
        private UnityEngine.BootConfigData WrapBootConfigData(System.IntPtr nativeHandle) { }
        private System.Void .ctor(System.IntPtr nativeHandle) { }

    }

    // TypeToken: 0x200008F
    public struct CachedAssetBundle
    {
        // Fields
        private System.String m_Name;        // 0x10
        private UnityEngine.Hash128 m_Hash;        // 0x18

    }

    // TypeToken: 0x2000090
    public struct Cache, IEquatable`1
    {
        // Fields
        private System.Int32 m_Handle;        // 0x10

        // Methods
        private System.Int32 get_handle() { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(UnityEngine.Cache other) { }
        private System.String get_path() { }
        private System.String Cache_GetPath(System.Int32 handle) { }

    }

    // TypeToken: 0x2000091
    public class Caching
    {
        // Methods
        private UnityEngine.Cache get_currentCacheForWriting() { }
        private System.Void get_currentCacheForWriting_Injected(UnityEngine.Cache& ret) { }

    }

    // TypeToken: 0x2000092
    public class Camera : Behaviour
    {
        // Fields
        public static UnityEngine.Camera.CameraCallback onPreCull;        // 0x0
        public static UnityEngine.Camera.CameraCallback onPreRender;        // 0x8
        public static UnityEngine.Camera.CameraCallback onPostRender;        // 0x10

        // Methods
        private System.IntPtr HGGetPtrUnchecked_Camera(System.Int32 instanceID) { }
        private System.IntPtr HGGetPtrUnchecked() { }
        private System.Void .ctor() { }
        private System.Single get_nearClipPlane() { }
        private System.Void set_nearClipPlane(System.Single value) { }
        private System.Single get_farClipPlane() { }
        private System.Void set_farClipPlane(System.Single value) { }
        private System.Single get_fieldOfView() { }
        private System.Void set_fieldOfView(System.Single value) { }
        private UnityEngine.RenderingPath get_renderingPath() { }
        private System.Void set_renderingPath(UnityEngine.RenderingPath value) { }
        private UnityEngine.RenderingPath get_actualRenderingPath() { }
        private System.Void Reset() { }
        private System.Boolean get_allowHDR() { }
        private System.Void set_allowHDR(System.Boolean value) { }
        private System.Boolean get_allowMSAA() { }
        private System.Void set_allowMSAA(System.Boolean value) { }
        private System.Boolean get_allowDynamicResolution() { }
        private System.Void set_allowDynamicResolution(System.Boolean value) { }
        private System.Boolean get_forceIntoRenderTexture() { }
        private System.Void set_forceIntoRenderTexture(System.Boolean value) { }
        private System.Single get_orthographicSize() { }
        private System.Void set_orthographicSize(System.Single value) { }
        private System.Boolean get_orthographic() { }
        private System.Void set_orthographic(System.Boolean value) { }
        private UnityEngine.Rendering.OpaqueSortMode get_opaqueSortMode() { }
        private System.Void set_opaqueSortMode(UnityEngine.Rendering.OpaqueSortMode value) { }
        private UnityEngine.TransparencySortMode get_transparencySortMode() { }
        private System.Void set_transparencySortMode(UnityEngine.TransparencySortMode value) { }
        private UnityEngine.Vector3 get_transparencySortAxis() { }
        private System.Void set_transparencySortAxis(UnityEngine.Vector3 value) { }
        private System.Void ResetTransparencySortSettings() { }
        private System.Single get_depth() { }
        private System.Void set_depth(System.Single value) { }
        private System.Single get_aspect() { }
        private System.Void set_aspect(System.Single value) { }
        private System.Void ResetAspect() { }
        private UnityEngine.Vector3 get_velocity() { }
        private System.Int32 get_cullingMask() { }
        private System.Void set_cullingMask(System.Int32 value) { }
        private System.Int32 get_eventMask() { }
        private System.Void set_eventMask(System.Int32 value) { }
        private System.Boolean get_layerCullSpherical() { }
        private System.Void set_layerCullSpherical(System.Boolean value) { }
        private UnityEngine.CameraType get_cameraType() { }
        private System.Void set_cameraType(UnityEngine.CameraType value) { }
        private UnityEngine.Material get_skyboxMaterial() { }
        private System.UInt64 get_overrideSceneCullingMask() { }
        private System.Void set_overrideSceneCullingMask(System.UInt64 value) { }
        private System.UInt64 get_sceneCullingMask() { }
        private System.Single[] GetLayerCullDistances() { }
        private System.Void SetLayerCullDistances(System.Single[] d) { }
        private System.Single[] get_layerCullDistances() { }
        private System.Void set_layerCullDistances(System.Single[] value) { }
        private System.Int32 get_PreviewCullingLayer() { }
        private System.Boolean get_useOcclusionCulling() { }
        private System.Void set_useOcclusionCulling(System.Boolean value) { }
        private UnityEngine.Matrix4x4 get_cullingMatrix() { }
        private System.Void set_cullingMatrix(UnityEngine.Matrix4x4 value) { }
        private System.Void ResetCullingMatrix() { }
        private UnityEngine.Color get_backgroundColor() { }
        private System.Void set_backgroundColor(UnityEngine.Color value) { }
        private UnityEngine.CameraClearFlags get_clearFlags() { }
        private System.Void set_clearFlags(UnityEngine.CameraClearFlags value) { }
        private UnityEngine.DepthTextureMode get_depthTextureMode() { }
        private System.Void set_depthTextureMode(UnityEngine.DepthTextureMode value) { }
        private System.Boolean get_clearStencilAfterLightingPass() { }
        private System.Void set_clearStencilAfterLightingPass(System.Boolean value) { }
        private System.Void SetReplacementShader(UnityEngine.Shader shader, System.String replacementTag) { }
        private System.Void ResetReplacementShader() { }
        private UnityEngine.Camera.ProjectionMatrixMode get_projectionMatrixMode() { }
        private System.Boolean get_usePhysicalProperties() { }
        private System.Void set_usePhysicalProperties(System.Boolean value) { }
        private UnityEngine.Vector2 get_sensorSize() { }
        private System.Void set_sensorSize(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 get_lensShift() { }
        private System.Void set_lensShift(UnityEngine.Vector2 value) { }
        private System.Single get_focalLength() { }
        private System.Void set_focalLength(System.Single value) { }
        private UnityEngine.Camera.GateFitMode get_gateFit() { }
        private System.Void set_gateFit(UnityEngine.Camera.GateFitMode value) { }
        private System.Single GetGateFittedFieldOfView() { }
        private UnityEngine.Vector2 GetGateFittedLensShift() { }
        private UnityEngine.Vector3 GetLocalSpaceAim() { }
        private UnityEngine.Rect get_rect() { }
        private System.Void set_rect(UnityEngine.Rect value) { }
        private UnityEngine.Rect get_pixelRect() { }
        private System.Void set_pixelRect(UnityEngine.Rect value) { }
        private UnityEngine.RectInt get_pixelRectInt() { }
        private System.Int32 get_pixelWidth() { }
        private System.Int32 get_pixelHeight() { }
        private System.Int32 get_scaledPixelWidth() { }
        private System.Int32 get_scaledPixelHeight() { }
        private UnityEngine.RenderTexture get_targetTexture() { }
        private System.Void set_targetTexture(UnityEngine.RenderTexture value) { }
        private UnityEngine.RenderTexture get_activeTexture() { }
        private System.Int32 get_targetDisplay() { }
        private System.Void set_targetDisplay(System.Int32 value) { }
        private System.Void SetTargetBuffersImpl(UnityEngine.RenderBuffer color, UnityEngine.RenderBuffer depth) { }
        private System.Void SetTargetBuffers(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer) { }
        private System.Void SetTargetBuffersMRTImpl(UnityEngine.RenderBuffer[] color, UnityEngine.RenderBuffer depth) { }
        private System.Void SetTargetBuffers(UnityEngine.RenderBuffer[] colorBuffer, UnityEngine.RenderBuffer depthBuffer) { }
        private System.String[] GetCameraBufferWarnings() { }
        private UnityEngine.Matrix4x4 get_cameraToWorldMatrix() { }
        private UnityEngine.Matrix4x4 get_worldToCameraMatrix() { }
        private System.Void set_worldToCameraMatrix(UnityEngine.Matrix4x4 value) { }
        private UnityEngine.Matrix4x4 get_projectionMatrix() { }
        private System.Void set_projectionMatrix(UnityEngine.Matrix4x4 value) { }
        private UnityEngine.Matrix4x4 get_nonJitteredProjectionMatrix() { }
        private System.Void set_nonJitteredProjectionMatrix(UnityEngine.Matrix4x4 value) { }
        private System.Boolean get_useJitteredProjectionMatrixForTransparentRendering() { }
        private System.Void set_useJitteredProjectionMatrixForTransparentRendering(System.Boolean value) { }
        private UnityEngine.Matrix4x4 get_previousViewProjectionMatrix() { }
        private System.Void ResetWorldToCameraMatrix() { }
        private System.Void ResetProjectionMatrix() { }
        private UnityEngine.Matrix4x4 CalculateObliqueMatrix(UnityEngine.Vector4 clipPlane) { }
        private UnityEngine.Vector3 WorldToScreenPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye) { }
        private UnityEngine.Vector3 WorldToViewportPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye) { }
        private UnityEngine.Vector3 ViewportToWorldPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye) { }
        private UnityEngine.Vector3 ScreenToWorldPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye) { }
        private UnityEngine.Vector3 WorldToScreenPoint(UnityEngine.Vector3 position) { }
        private UnityEngine.Vector3 WorldToViewportPoint(UnityEngine.Vector3 position) { }
        private UnityEngine.Vector3 ViewportToWorldPoint(UnityEngine.Vector3 position) { }
        private UnityEngine.Vector3 ScreenToWorldPoint(UnityEngine.Vector3 position) { }
        private UnityEngine.Vector3 ScreenToViewportPoint(UnityEngine.Vector3 position) { }
        private UnityEngine.Vector3 ViewportToScreenPoint(UnityEngine.Vector3 position) { }
        private UnityEngine.Vector2 GetFrustumPlaneSizeAt(System.Single distance) { }
        private UnityEngine.Ray ViewportPointToRay(UnityEngine.Vector2 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye) { }
        private UnityEngine.Ray ViewportPointToRay(UnityEngine.Vector3 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye) { }
        private UnityEngine.Ray ViewportPointToRay(UnityEngine.Vector3 pos) { }
        private UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector2 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye) { }
        private UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector3 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye) { }
        private UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector3 pos) { }
        private System.Void CalculateFrustumCornersInternal(UnityEngine.Rect viewport, System.Single z, UnityEngine.Camera.MonoOrStereoscopicEye eye, UnityEngine.Vector3[] outCorners) { }
        private System.Void CalculateFrustumCorners(UnityEngine.Rect viewport, System.Single z, UnityEngine.Camera.MonoOrStereoscopicEye eye, UnityEngine.Vector3[] outCorners) { }
        private System.Void CalculateProjectionMatrixFromPhysicalPropertiesInternal(UnityEngine.Matrix4x4& output, System.Single focalLength, UnityEngine.Vector2 sensorSize, UnityEngine.Vector2 lensShift, System.Single nearClip, System.Single farClip, System.Single gateAspect, UnityEngine.Camera.GateFitMode gateFitMode) { }
        private System.Void CalculateProjectionMatrixFromPhysicalProperties(UnityEngine.Matrix4x4& output, System.Single focalLength, UnityEngine.Vector2 sensorSize, UnityEngine.Vector2 lensShift, System.Single nearClip, System.Single farClip, UnityEngine.Camera.GateFitParameters gateFitParameters) { }
        private System.Single FocalLengthToFieldOfView(System.Single focalLength, System.Single sensorSize) { }
        private System.Single FieldOfViewToFocalLength(System.Single fieldOfView, System.Single sensorSize) { }
        private System.Single HorizontalToVerticalFieldOfView(System.Single horizontalFieldOfView, System.Single aspectRatio) { }
        private System.Single VerticalToHorizontalFieldOfView(System.Single verticalFieldOfView, System.Single aspectRatio) { }
        private UnityEngine.Camera get_main() { }
        private UnityEngine.Camera get_current() { }
        private UnityEngine.Camera GetLightWeightCamera() { }
        private System.Void SetLightWeight(System.Boolean flag) { }
        private UnityEngine.SceneManagement.Scene get_scene() { }
        private System.Void set_scene(UnityEngine.SceneManagement.Scene value) { }
        private System.Boolean get_stereoEnabled() { }
        private System.Single get_stereoSeparation() { }
        private System.Void set_stereoSeparation(System.Single value) { }
        private System.Single get_stereoConvergence() { }
        private System.Void set_stereoConvergence(System.Single value) { }
        private System.Boolean get_areVRStereoViewMatricesWithinSingleCullTolerance() { }
        private UnityEngine.StereoTargetEyeMask get_stereoTargetEye() { }
        private System.Void set_stereoTargetEye(UnityEngine.StereoTargetEyeMask value) { }
        private UnityEngine.Camera.MonoOrStereoscopicEye get_stereoActiveEye() { }
        private UnityEngine.Matrix4x4 GetStereoNonJitteredProjectionMatrix(UnityEngine.Camera.StereoscopicEye eye) { }
        private UnityEngine.Matrix4x4 GetStereoViewMatrix(UnityEngine.Camera.StereoscopicEye eye) { }
        private System.Void CopyStereoDeviceProjectionMatrixToNonJittered(UnityEngine.Camera.StereoscopicEye eye) { }
        private UnityEngine.Matrix4x4 GetStereoProjectionMatrix(UnityEngine.Camera.StereoscopicEye eye) { }
        private System.Void SetStereoProjectionMatrix(UnityEngine.Camera.StereoscopicEye eye, UnityEngine.Matrix4x4 matrix) { }
        private System.Void ResetStereoProjectionMatrices() { }
        private System.Void SetStereoViewMatrix(UnityEngine.Camera.StereoscopicEye eye, UnityEngine.Matrix4x4 matrix) { }
        private System.Void ResetStereoViewMatrices() { }
        private System.Int32 GetAllCamerasCount() { }
        private System.Int32 GetAllCamerasImpl(UnityEngine.Camera[] cam) { }
        private System.Int32 get_allCamerasCount() { }
        private UnityEngine.Camera[] get_allCameras() { }
        private System.Int32 GetAllCameras(UnityEngine.Camera[] cameras) { }
        private System.Int32 HGGetAllCamerasCountImpl(System.Boolean includeEditorCameras) { }
        private System.Int32 HGGetAllCamerasImpl(UnityEngine.Camera[] cam, System.Boolean includeEditorCameras) { }
        private System.Int32 HGGetAllCamerasCount(System.Boolean includeEditorCameras) { }
        private System.Int32 HGGetAllCameras(UnityEngine.Camera[] cameras, System.Boolean includeEditorCameras) { }
        private System.Boolean RenderToCubemapImpl(UnityEngine.Texture tex, System.Int32 faceMask) { }
        private System.Boolean RenderToCubemap(UnityEngine.Cubemap cubemap, System.Int32 faceMask) { }
        private System.Boolean RenderToCubemap(UnityEngine.Cubemap cubemap) { }
        private System.Boolean RenderToCubemap(UnityEngine.RenderTexture cubemap, System.Int32 faceMask) { }
        private System.Boolean RenderToCubemap(UnityEngine.RenderTexture cubemap) { }
        private System.Int32 GetFilterMode() { }
        private UnityEngine.Camera.SceneViewFilterMode get_sceneViewFilterMode() { }
        private System.Boolean RenderToCubemapEyeImpl(UnityEngine.RenderTexture cubemap, System.Int32 faceMask, UnityEngine.Camera.MonoOrStereoscopicEye stereoEye) { }
        private System.Boolean RenderToCubemap(UnityEngine.RenderTexture cubemap, System.Int32 faceMask, UnityEngine.Camera.MonoOrStereoscopicEye stereoEye) { }
        private System.Void Render() { }
        private System.Void RenderWithShader(UnityEngine.Shader shader, System.String replacementTag) { }
        private System.Void RenderDontRestore() { }
        private System.Void SubmitRenderRequests(System.Collections.Generic.List<UnityEngine.Camera.RenderRequest> renderRequests) { }
        private System.Void SubmitRenderRequestsInternal(System.Object requests) { }
        private System.Void SetupCurrent(UnityEngine.Camera cur) { }
        private System.Void CopyFrom(UnityEngine.Camera other) { }
        private System.Int32 get_commandBufferCount() { }
        private System.Void RemoveCommandBuffers(UnityEngine.Rendering.CameraEvent evt) { }
        private System.Void RemoveAllCommandBuffers() { }
        private System.Void AddCommandBufferImpl(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer) { }
        private System.Void AddCommandBufferAsyncImpl(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType) { }
        private System.Void RemoveCommandBufferImpl(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer) { }
        private System.Void AddCommandBuffer(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer) { }
        private System.Void AddCommandBufferAsync(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType) { }
        private System.Void RemoveCommandBuffer(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer) { }
        private UnityEngine.Rendering.CommandBuffer[] GetCommandBuffers(UnityEngine.Rendering.CameraEvent evt) { }
        private System.Void FireOnPreCull(UnityEngine.Camera cam) { }
        private System.Void FireOnPreRender(UnityEngine.Camera cam) { }
        private System.Void FireOnPostRender(UnityEngine.Camera cam) { }
        private System.Void OnlyUsedForTesting1() { }
        private System.Void OnlyUsedForTesting2() { }
        private System.Boolean TryGetCullingParameters(UnityEngine.Rendering.ScriptableCullingParameters& cullingParameters) { }
        private System.Boolean TryGetCullingParameters(System.Boolean stereoAware, UnityEngine.Rendering.ScriptableCullingParameters& cullingParameters) { }
        private System.Boolean GetCullingParameters_Internal(UnityEngine.Camera camera, System.Boolean stereoAware, UnityEngine.Rendering.ScriptableCullingParameters& cullingParameters, System.Int32 managedCullingParametersSize) { }
        private System.Void get_transparencySortAxis_Injected(UnityEngine.Vector3& ret) { }
        private System.Void set_transparencySortAxis_Injected(UnityEngine.Vector3& value) { }
        private System.Void get_velocity_Injected(UnityEngine.Vector3& ret) { }
        private System.Void get_cullingMatrix_Injected(UnityEngine.Matrix4x4& ret) { }
        private System.Void set_cullingMatrix_Injected(UnityEngine.Matrix4x4& value) { }
        private System.Void get_backgroundColor_Injected(UnityEngine.Color& ret) { }
        private System.Void set_backgroundColor_Injected(UnityEngine.Color& value) { }
        private System.Void get_sensorSize_Injected(UnityEngine.Vector2& ret) { }
        private System.Void set_sensorSize_Injected(UnityEngine.Vector2& value) { }
        private System.Void get_lensShift_Injected(UnityEngine.Vector2& ret) { }
        private System.Void set_lensShift_Injected(UnityEngine.Vector2& value) { }
        private System.Void GetGateFittedLensShift_Injected(UnityEngine.Vector2& ret) { }
        private System.Void GetLocalSpaceAim_Injected(UnityEngine.Vector3& ret) { }
        private System.Void get_rect_Injected(UnityEngine.Rect& ret) { }
        private System.Void set_rect_Injected(UnityEngine.Rect& value) { }
        private System.Void get_pixelRect_Injected(UnityEngine.Rect& ret) { }
        private System.Void set_pixelRect_Injected(UnityEngine.Rect& value) { }
        private System.Void get_pixelRectInt_Injected(UnityEngine.RectInt& ret) { }
        private System.Void SetTargetBuffersImpl_Injected(UnityEngine.RenderBuffer& color, UnityEngine.RenderBuffer& depth) { }
        private System.Void SetTargetBuffersMRTImpl_Injected(UnityEngine.RenderBuffer[] color, UnityEngine.RenderBuffer& depth) { }
        private System.Void get_cameraToWorldMatrix_Injected(UnityEngine.Matrix4x4& ret) { }
        private System.Void get_worldToCameraMatrix_Injected(UnityEngine.Matrix4x4& ret) { }
        private System.Void set_worldToCameraMatrix_Injected(UnityEngine.Matrix4x4& value) { }
        private System.Void get_projectionMatrix_Injected(UnityEngine.Matrix4x4& ret) { }
        private System.Void set_projectionMatrix_Injected(UnityEngine.Matrix4x4& value) { }
        private System.Void get_nonJitteredProjectionMatrix_Injected(UnityEngine.Matrix4x4& ret) { }
        private System.Void set_nonJitteredProjectionMatrix_Injected(UnityEngine.Matrix4x4& value) { }
        private System.Void get_previousViewProjectionMatrix_Injected(UnityEngine.Matrix4x4& ret) { }
        private System.Void CalculateObliqueMatrix_Injected(UnityEngine.Vector4& clipPlane, UnityEngine.Matrix4x4& ret) { }
        private System.Void WorldToScreenPoint_Injected(UnityEngine.Vector3& position, UnityEngine.Camera.MonoOrStereoscopicEye eye, UnityEngine.Vector3& ret) { }
        private System.Void WorldToViewportPoint_Injected(UnityEngine.Vector3& position, UnityEngine.Camera.MonoOrStereoscopicEye eye, UnityEngine.Vector3& ret) { }
        private System.Void ViewportToWorldPoint_Injected(UnityEngine.Vector3& position, UnityEngine.Camera.MonoOrStereoscopicEye eye, UnityEngine.Vector3& ret) { }
        private System.Void ScreenToWorldPoint_Injected(UnityEngine.Vector3& position, UnityEngine.Camera.MonoOrStereoscopicEye eye, UnityEngine.Vector3& ret) { }
        private System.Void ScreenToViewportPoint_Injected(UnityEngine.Vector3& position, UnityEngine.Vector3& ret) { }
        private System.Void ViewportToScreenPoint_Injected(UnityEngine.Vector3& position, UnityEngine.Vector3& ret) { }
        private System.Void GetFrustumPlaneSizeAt_Injected(System.Single distance, UnityEngine.Vector2& ret) { }
        private System.Void ViewportPointToRay_Injected(UnityEngine.Vector2& pos, UnityEngine.Camera.MonoOrStereoscopicEye eye, UnityEngine.Ray& ret) { }
        private System.Void ScreenPointToRay_Injected(UnityEngine.Vector2& pos, UnityEngine.Camera.MonoOrStereoscopicEye eye, UnityEngine.Ray& ret) { }
        private System.Void CalculateFrustumCornersInternal_Injected(UnityEngine.Rect& viewport, System.Single z, UnityEngine.Camera.MonoOrStereoscopicEye eye, UnityEngine.Vector3[] outCorners) { }
        private System.Void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(UnityEngine.Matrix4x4& output, System.Single focalLength, UnityEngine.Vector2& sensorSize, UnityEngine.Vector2& lensShift, System.Single nearClip, System.Single farClip, System.Single gateAspect, UnityEngine.Camera.GateFitMode gateFitMode) { }
        private System.Void get_scene_Injected(UnityEngine.SceneManagement.Scene& ret) { }
        private System.Void set_scene_Injected(UnityEngine.SceneManagement.Scene& value) { }
        private System.Void GetStereoNonJitteredProjectionMatrix_Injected(UnityEngine.Camera.StereoscopicEye eye, UnityEngine.Matrix4x4& ret) { }
        private System.Void GetStereoViewMatrix_Injected(UnityEngine.Camera.StereoscopicEye eye, UnityEngine.Matrix4x4& ret) { }
        private System.Void GetStereoProjectionMatrix_Injected(UnityEngine.Camera.StereoscopicEye eye, UnityEngine.Matrix4x4& ret) { }
        private System.Void SetStereoProjectionMatrix_Injected(UnityEngine.Camera.StereoscopicEye eye, UnityEngine.Matrix4x4& matrix) { }
        private System.Void SetStereoViewMatrix_Injected(UnityEngine.Camera.StereoscopicEye eye, UnityEngine.Matrix4x4& matrix) { }

    }

    // TypeToken: 0x200009E
    public struct BoundingSphere
    {
        // Fields
        public UnityEngine.Vector3 position;        // 0x10
        public System.Single radius;        // 0x1C

        // Methods
        private System.Void .ctor(UnityEngine.Vector3 pos, System.Single rad) { }

    }

    // TypeToken: 0x200009F
    public struct CullingGroupEvent
    {
        // Fields
        private System.Int32 m_Index;        // 0x10
        private System.Byte m_PrevState;        // 0x14
        private System.Byte m_ThisState;        // 0x15

    }

    // TypeToken: 0x20000A0
    public class CullingGroup, IDisposable
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10
        private UnityEngine.CullingGroup.StateChanged m_OnStateChanged;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void Finalize() { }
        private System.Void DisposeInternal() { }
        private System.Void Dispose() { }
        private System.Void SendEvents(UnityEngine.CullingGroup cullingGroup, System.IntPtr eventsPtr, System.Int32 count) { }
        private System.IntPtr Init(System.Object scripting) { }
        private System.Void FinalizerFailure() { }

    }

    // TypeToken: 0x20000A2
    public class FlareLayer : Behaviour
    {
    }

    // TypeToken: 0x20000A3
    public class ReflectionProbe : Behaviour
    {
        // Fields
        private static System.Action<UnityEngine.ReflectionProbe,UnityEngine.ReflectionProbe.ReflectionProbeEvent> reflectionProbeChanged;        // 0x0
        private static System.Action<UnityEngine.Cubemap> defaultReflectionSet;        // 0x8
        private static System.Action<UnityEngine.Texture> defaultReflectionTexture;        // 0x10

        // Methods
        private UnityEngine.Rendering.ReflectionProbeType get_type() { }
        private System.Void set_type(UnityEngine.Rendering.ReflectionProbeType value) { }
        private UnityEngine.Vector3 get_size() { }
        private System.Void set_size(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_center() { }
        private System.Void set_center(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_rotatedExtents() { }
        private System.Void set_rotatedExtents(UnityEngine.Vector3 value) { }
        private System.Void UpdateRotatedExtentsAndTRS() { }
        private UnityEngine.Vector3 get_boxRotation() { }
        private System.Void set_boxRotation(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_boxInfluenceScale() { }
        private System.Void set_boxInfluenceScale(UnityEngine.Vector3 value) { }
        private UnityEngine.Matrix4x4 get_TRS() { }
        private System.Void set_TRS(UnityEngine.Matrix4x4 value) { }
        private UnityEngine.Matrix4x4 get_TRInverse() { }
        private System.Void set_TRInverse(UnityEngine.Matrix4x4 value) { }
        private System.Single get_falloffDistance() { }
        private System.Void set_falloffDistance(System.Single value) { }
        private System.Single get_cullingDistance() { }
        private System.Void set_cullingDistance(System.Single value) { }
        private System.Single get_nearClipPlane() { }
        private System.Void set_nearClipPlane(System.Single value) { }
        private System.Single get_farClipPlane() { }
        private System.Void set_farClipPlane(System.Single value) { }
        private System.Single get_intensity() { }
        private System.Void set_intensity(System.Single value) { }
        private UnityEngine.Bounds get_bounds() { }
        private System.Boolean get_hdr() { }
        private System.Void set_hdr(System.Boolean value) { }
        private System.Boolean get_renderDynamicObjects() { }
        private System.Void set_renderDynamicObjects(System.Boolean value) { }
        private System.Single get_shadowDistance() { }
        private System.Void set_shadowDistance(System.Single value) { }
        private System.Int32 get_resolution() { }
        private System.Void set_resolution(System.Int32 value) { }
        private System.Int32 get_cullingMask() { }
        private System.Void set_cullingMask(System.Int32 value) { }
        private UnityEngine.Rendering.ReflectionProbeClearFlags get_clearFlags() { }
        private System.Void set_clearFlags(UnityEngine.Rendering.ReflectionProbeClearFlags value) { }
        private UnityEngine.Color get_backgroundColor() { }
        private System.Void set_backgroundColor(UnityEngine.Color value) { }
        private System.Single get_blendDistance() { }
        private System.Void set_blendDistance(System.Single value) { }
        private UnityEngine.Rendering.ReflectionProbeOrientedMode get_oriented() { }
        private System.Void set_oriented(UnityEngine.Rendering.ReflectionProbeOrientedMode value) { }
        private UnityEngine.Rendering.ReflectionProbeShapeType get_shapeType() { }
        private System.Void set_shapeType(UnityEngine.Rendering.ReflectionProbeShapeType value) { }
        private System.Single get_sphereRadius() { }
        private System.Void set_sphereRadius(System.Single value) { }
        private System.Single get_sphereInfluenceScale() { }
        private System.Void set_sphereInfluenceScale(System.Single value) { }
        private UnityEngine.Rendering.ReflectionProbeScopeType get_scopeType() { }
        private System.Void set_scopeType(UnityEngine.Rendering.ReflectionProbeScopeType value) { }
        private System.Int64 get_serializedIdentifier() { }
        private System.Void set_serializedIdentifier(System.Int64 value) { }
        private System.Boolean get_boxProjection() { }
        private System.Void set_boxProjection(System.Boolean value) { }
        private UnityEngine.Rendering.ReflectionProbeMode get_mode() { }
        private System.Void set_mode(UnityEngine.Rendering.ReflectionProbeMode value) { }
        private System.Int32 get_importance() { }
        private System.Void set_importance(System.Int32 value) { }
        private UnityEngine.Rendering.ReflectionProbeRefreshMode get_refreshMode() { }
        private System.Void set_refreshMode(UnityEngine.Rendering.ReflectionProbeRefreshMode value) { }
        private UnityEngine.Rendering.ReflectionProbeTimeSlicingMode get_timeSlicingMode() { }
        private System.Void set_timeSlicingMode(UnityEngine.Rendering.ReflectionProbeTimeSlicingMode value) { }
        private UnityEngine.Texture get_bakedTexture() { }
        private System.Void set_bakedTexture(UnityEngine.Texture value) { }
        private UnityEngine.Texture get_customBakedTexture() { }
        private System.Void set_customBakedTexture(UnityEngine.Texture value) { }
        private UnityEngine.RenderTexture get_realtimeTexture() { }
        private System.Void set_realtimeTexture(UnityEngine.RenderTexture value) { }
        private UnityEngine.Texture get_texture() { }
        private UnityEngine.Rendering.SphericalHarmonicsL2 get_bakedProbeSH() { }
        private System.Void set_bakedProbeSH(UnityEngine.Rendering.SphericalHarmonicsL2 value) { }
        private UnityEngine.Rendering.SphericalHarmonicsL2 get_customBakedProbeSH() { }
        private System.Void set_customBakedProbeSH(UnityEngine.Rendering.SphericalHarmonicsL2 value) { }
        private UnityEngine.Rendering.SphericalHarmonicsL2 get_probeSH() { }
        private UnityEngine.Vector4 get_textureHDRDecodeValues() { }
        private System.String get_texturePath() { }
        private UnityEngine.Hash128 get_probeHash() { }
        private System.Void set_probeHash(UnityEngine.Hash128 value) { }
        private System.Void SetTexturePathWithoutUpdate(System.String texturePath) { }
        private System.Void Reset() { }
        private System.Int32 RenderProbe() { }
        private System.Int32 RenderProbe(UnityEngine.RenderTexture targetTexture) { }
        private System.Boolean IsFinishedRendering(System.Int32 renderId) { }
        private System.Int32 ScheduleRender(UnityEngine.Rendering.ReflectionProbeTimeSlicingMode timeSlicingMode, UnityEngine.RenderTexture targetTexture) { }
        private System.Boolean BlendCubemap(UnityEngine.Texture src, UnityEngine.Texture dst, System.Single blend, UnityEngine.RenderTexture target) { }
        private System.Void UpdateCachedState() { }
        private System.Int32 get_minBakedCubemapResolution() { }
        private System.Int32 get_maxBakedCubemapResolution() { }
        private UnityEngine.Vector4 get_defaultTextureHDRDecodeValues() { }
        private UnityEngine.Texture get_defaultTexture() { }
        private UnityEngine.Rendering.SphericalHarmonicsL2 get_defaultProbeSH() { }
        private System.Void add_reflectionProbeChanged(System.Action<UnityEngine.ReflectionProbe,UnityEngine.ReflectionProbe.ReflectionProbeEvent> value) { }
        private System.Void remove_reflectionProbeChanged(System.Action<UnityEngine.ReflectionProbe,UnityEngine.ReflectionProbe.ReflectionProbeEvent> value) { }
        private System.Void add_defaultReflectionSet(System.Action<UnityEngine.Cubemap> value) { }
        private System.Void remove_defaultReflectionSet(System.Action<UnityEngine.Cubemap> value) { }
        private System.Void add_defaultReflectionTexture(System.Action<UnityEngine.Texture> value) { }
        private System.Void remove_defaultReflectionTexture(System.Action<UnityEngine.Texture> value) { }
        private System.Void CallReflectionProbeEvent(UnityEngine.ReflectionProbe probe, UnityEngine.ReflectionProbe.ReflectionProbeEvent probeEvent) { }
        private System.Void CallSetDefaultReflection(UnityEngine.Texture defaultReflectionCubemap) { }
        private System.Void .ctor() { }
        private System.Void get_size_Injected(UnityEngine.Vector3& ret) { }
        private System.Void set_size_Injected(UnityEngine.Vector3& value) { }
        private System.Void get_center_Injected(UnityEngine.Vector3& ret) { }
        private System.Void set_center_Injected(UnityEngine.Vector3& value) { }
        private System.Void get_rotatedExtents_Injected(UnityEngine.Vector3& ret) { }
        private System.Void set_rotatedExtents_Injected(UnityEngine.Vector3& value) { }
        private System.Void get_boxRotation_Injected(UnityEngine.Vector3& ret) { }
        private System.Void set_boxRotation_Injected(UnityEngine.Vector3& value) { }
        private System.Void get_boxInfluenceScale_Injected(UnityEngine.Vector3& ret) { }
        private System.Void set_boxInfluenceScale_Injected(UnityEngine.Vector3& value) { }
        private System.Void get_TRS_Injected(UnityEngine.Matrix4x4& ret) { }
        private System.Void set_TRS_Injected(UnityEngine.Matrix4x4& value) { }
        private System.Void get_TRInverse_Injected(UnityEngine.Matrix4x4& ret) { }
        private System.Void set_TRInverse_Injected(UnityEngine.Matrix4x4& value) { }
        private System.Void get_bounds_Injected(UnityEngine.Bounds& ret) { }
        private System.Void get_backgroundColor_Injected(UnityEngine.Color& ret) { }
        private System.Void set_backgroundColor_Injected(UnityEngine.Color& value) { }
        private System.Void get_bakedProbeSH_Injected(UnityEngine.Rendering.SphericalHarmonicsL2& ret) { }
        private System.Void set_bakedProbeSH_Injected(UnityEngine.Rendering.SphericalHarmonicsL2& value) { }
        private System.Void get_customBakedProbeSH_Injected(UnityEngine.Rendering.SphericalHarmonicsL2& ret) { }
        private System.Void set_customBakedProbeSH_Injected(UnityEngine.Rendering.SphericalHarmonicsL2& value) { }
        private System.Void get_probeSH_Injected(UnityEngine.Rendering.SphericalHarmonicsL2& ret) { }
        private System.Void get_textureHDRDecodeValues_Injected(UnityEngine.Vector4& ret) { }
        private System.Void get_probeHash_Injected(UnityEngine.Hash128& ret) { }
        private System.Void set_probeHash_Injected(UnityEngine.Hash128& value) { }
        private System.Void get_defaultTextureHDRDecodeValues_Injected(UnityEngine.Vector4& ret) { }
        private System.Void get_defaultProbeSH_Injected(UnityEngine.Rendering.SphericalHarmonicsL2& ret) { }

    }

    // TypeToken: 0x20000A5
    public class DebugLogHandler, ILogHandler
    {
        // Methods
        private System.Void Internal_Log(UnityEngine.LogType level, UnityEngine.LogOption options, System.String msg, UnityEngine.Object obj) { }
        private System.Void Internal_LogException(System.Exception ex, UnityEngine.Object obj) { }
        private System.Void LogFormat(UnityEngine.LogType logType, UnityEngine.Object context, System.String format, System.Object[] args) { }
        private System.Void LogFormat(UnityEngine.LogType logType, UnityEngine.LogOption logOptions, UnityEngine.Object context, System.String format, System.Object[] args) { }
        private System.Void LogException(System.Exception exception, UnityEngine.Object context) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A6
    public class Debug
    {
        // Fields
        private static readonly UnityEngine.ILogger s_DefaultLogger;        // 0x0
        private static UnityEngine.ILogger s_Logger;        // 0x8

        // Methods
        private UnityEngine.ILogger get_unityLogger() { }
        private System.Void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Color color, System.Single duration) { }
        private System.Void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Color color) { }
        private System.Void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end) { }
        private System.Void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Color color, System.Single duration, System.Boolean depthTest) { }
        private System.Void DrawRay(UnityEngine.Vector3 start, UnityEngine.Vector3 dir, UnityEngine.Color color, System.Single duration) { }
        private System.Void DrawRay(UnityEngine.Vector3 start, UnityEngine.Vector3 dir, UnityEngine.Color color) { }
        private System.Void DrawRay(UnityEngine.Vector3 start, UnityEngine.Vector3 dir) { }
        private System.Void DrawRay(UnityEngine.Vector3 start, UnityEngine.Vector3 dir, UnityEngine.Color color, System.Single duration, System.Boolean depthTest) { }
        private System.Void Break() { }
        private System.Void DebugBreak() { }
        private System.Int32 ExtractStackTraceNoAlloc(System.Byte* buffer, System.Int32 bufferMax, System.String projectFolder) { }
        private System.Void Log(System.Object message) { }
        private System.Void Log(System.Object message, UnityEngine.Object context) { }
        private System.Void LogFormat(System.String format, System.Object[] args) { }
        private System.Void LogFormat(UnityEngine.Object context, System.String format, System.Object[] args) { }
        private System.Void LogFormat(UnityEngine.LogType logType, UnityEngine.LogOption logOptions, UnityEngine.Object context, System.String format, System.Object[] args) { }
        private System.Void LogError(System.Object message) { }
        private System.Void LogError(System.Object message, UnityEngine.Object context) { }
        private System.Void LogErrorFormat(System.String format, System.Object[] args) { }
        private System.Void LogErrorFormat(UnityEngine.Object context, System.String format, System.Object[] args) { }
        private System.Void LogCritical(System.Object message) { }
        private System.Void LogCritical(System.Object message, UnityEngine.Object context) { }
        private System.Void LogCriticalFormat(System.String format, System.Object[] args) { }
        private System.Void LogCriticalFormat(UnityEngine.Object context, System.String format, System.Object[] args) { }
        private System.Void ClearDeveloperConsole() { }
        private System.Boolean get_developerConsoleEnabled() { }
        private System.Void set_developerConsoleEnabled(System.Boolean value) { }
        private System.Void set_developerConsoleLogType(UnityEngine.LogType value) { }
        private UnityEngine.LogType get_developerConsoleLogType() { }
        private System.Int32 get_developerConsoleLoggingLevel() { }
        private System.Void set_developerConsoleLoggingLevel(System.Int32 value) { }
        private System.Boolean get_developerConsoleVisible() { }
        private System.Void set_developerConsoleVisible(System.Boolean value) { }
        private System.Void LogException(System.Exception exception) { }
        private System.Void LogException(System.Exception exception, UnityEngine.Object context) { }
        private System.Void LogWarning(System.Object message) { }
        private System.Void LogWarning(System.Object message, UnityEngine.Object context) { }
        private System.Void LogWarningFormat(System.String format, System.Object[] args) { }
        private System.Void LogWarningFormat(UnityEngine.Object context, System.String format, System.Object[] args) { }
        private System.Void Assert(System.Boolean condition) { }
        private System.Void Assert(System.Boolean condition, UnityEngine.Object context) { }
        private System.Void Assert(System.Boolean condition, System.Object message) { }
        private System.Void Assert(System.Boolean condition, System.String message) { }
        private System.Void Assert(System.Boolean condition, System.Object message, UnityEngine.Object context) { }
        private System.Void Assert(System.Boolean condition, System.String message, UnityEngine.Object context) { }
        private System.Void AssertFormat(System.Boolean condition, System.String format, System.Object[] args) { }
        private System.Void AssertFormat(System.Boolean condition, UnityEngine.Object context, System.String format, System.Object[] args) { }
        private System.Void LogAssertion(System.Object message) { }
        private System.Void LogAssertion(System.Object message, UnityEngine.Object context) { }
        private System.Void LogAssertionFormat(System.String format, System.Object[] args) { }
        private System.Void LogAssertionFormat(UnityEngine.Object context, System.String format, System.Object[] args) { }
        private System.Boolean get_isDebugBuild() { }
        private System.Void OpenConsoleFile() { }
        private UnityEngine.DiagnosticSwitch[] get_diagnosticSwitches() { }
        private UnityEngine.DiagnosticSwitch GetDiagnosticSwitch(System.String name) { }
        private System.Boolean CallOverridenDebugHandler(System.Exception exception, UnityEngine.Object obj) { }
        private System.Boolean IsLoggingEnabled() { }
        private System.Void SetStripLogInRelease(System.Boolean enable) { }
        private System.Void Assert(System.Boolean condition, System.String format, System.Object[] args) { }
        private UnityEngine.ILogger get_logger() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }
        private System.Void DrawLine_Injected(UnityEngine.Vector3& start, UnityEngine.Vector3& end, UnityEngine.Color& color, System.Single duration, System.Boolean depthTest) { }

    }

    // TypeToken: 0x20000A7
    public class DiagnosticSwitch
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.String get_name() { }

    }

    // TypeToken: 0x20000A8
    public struct ExposedReference`1
    {
        // Fields
        public UnityEngine.PropertyName exposedName;        // 0x0
        public UnityEngine.Object defaultValue;        // 0x0

        // Methods
        private T Resolve(UnityEngine.IExposedPropertyTable resolver) { }

    }

    // TypeToken: 0x20000A9
    public interface IExposedPropertyTable
    {
        // Methods
        private UnityEngine.Object GetReferenceValue(UnityEngine.PropertyName id, System.Boolean& idValid) { }

    }

    // TypeToken: 0x20000AA
    public struct Bounds, IEquatable`1, IFormattable
    {
        // Fields
        private UnityEngine.Vector3 m_Center;        // 0x10
        private UnityEngine.Vector3 m_Extents;        // 0x1C

        // Methods
        private System.Void .ctor(UnityEngine.Vector3 center, UnityEngine.Vector3 size) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(UnityEngine.Bounds other) { }
        private UnityEngine.Vector3 get_center() { }
        private System.Void set_center(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_size() { }
        private System.Void set_size(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_extents() { }
        private System.Void set_extents(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_min() { }
        private System.Void set_min(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_max() { }
        private System.Void set_max(UnityEngine.Vector3 value) { }
        private System.Boolean op_Equality(UnityEngine.Bounds lhs, UnityEngine.Bounds rhs) { }
        private System.Boolean op_Inequality(UnityEngine.Bounds lhs, UnityEngine.Bounds rhs) { }
        private System.Void SetMinMax(UnityEngine.Vector3 min, UnityEngine.Vector3 max) { }
        private System.Void Encapsulate(UnityEngine.Vector3 point) { }
        private System.Void Encapsulate(UnityEngine.Bounds bounds) { }
        private System.Void Expand(System.Single amount) { }
        private System.Void Expand(UnityEngine.Vector3 amount) { }
        private System.Boolean Intersects(UnityEngine.Bounds bounds) { }
        private System.Boolean IntersectRay(UnityEngine.Ray ray) { }
        private System.Boolean IntersectRay(UnityEngine.Ray ray, System.Single& distance) { }
        private System.String ToString() { }
        private System.String ToString(System.String format) { }
        private System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        private System.Boolean Contains(UnityEngine.Vector3 point) { }
        private System.Single SqrDistance(UnityEngine.Vector3 point) { }
        private System.Boolean IntersectRayAABB(UnityEngine.Ray ray, UnityEngine.Bounds bounds, System.Single& dist) { }
        private UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 point) { }
        private System.Boolean Contains_Injected(UnityEngine.Bounds& _unity_self, UnityEngine.Vector3& point) { }
        private System.Single SqrDistance_Injected(UnityEngine.Bounds& _unity_self, UnityEngine.Vector3& point) { }
        private System.Boolean IntersectRayAABB_Injected(UnityEngine.Ray& ray, UnityEngine.Bounds& bounds, System.Single& dist) { }
        private System.Void ClosestPoint_Injected(UnityEngine.Bounds& _unity_self, UnityEngine.Vector3& point, UnityEngine.Vector3& ret) { }

    }

    // TypeToken: 0x20000AB
    public struct BoundsInt, IEquatable`1, IFormattable
    {
        // Fields
        private UnityEngine.Vector3Int m_Position;        // 0x10
        private UnityEngine.Vector3Int m_Size;        // 0x1C

        // Methods
        private UnityEngine.Vector3Int get_min() { }
        private System.Void set_min(UnityEngine.Vector3Int value) { }
        private UnityEngine.Vector3Int get_max() { }
        private System.Void set_max(UnityEngine.Vector3Int value) { }
        private System.Int32 get_xMin() { }
        private System.Void set_xMin(System.Int32 value) { }
        private System.Int32 get_yMin() { }
        private System.Void set_yMin(System.Int32 value) { }
        private System.Int32 get_zMin() { }
        private System.Void set_zMin(System.Int32 value) { }
        private System.Int32 get_xMax() { }
        private System.Void set_xMax(System.Int32 value) { }
        private System.Int32 get_yMax() { }
        private System.Void set_yMax(System.Int32 value) { }
        private System.Int32 get_zMax() { }
        private System.Void set_zMax(System.Int32 value) { }
        private UnityEngine.Vector3Int get_size() { }
        private System.Void .ctor(UnityEngine.Vector3Int position, UnityEngine.Vector3Int size) { }
        private System.String ToString() { }
        private System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(UnityEngine.BoundsInt other) { }
        private System.Int32 GetHashCode() { }
        private UnityEngine.BoundsInt.PositionEnumerator get_allPositionsWithin() { }

    }

    // TypeToken: 0x20000AD
    public class GeometryUtility
    {
        // Methods
        private System.Void CalculateFrustumPlanes(UnityEngine.Camera camera, UnityEngine.Plane[] planes) { }
        private System.Void CalculateFrustumPlanes(UnityEngine.Matrix4x4 worldToProjectionMatrix, UnityEngine.Plane[] planes) { }
        private System.Void SPMDCullAABB(UnityEngine.Matrix4x4 viewProj, Unity.Collections.NativeArray<System.Single> centerXs, Unity.Collections.NativeArray<System.Single> centerYs, Unity.Collections.NativeArray<System.Single> centerZs, Unity.Collections.NativeArray<System.Single> halfExtentXs, Unity.Collections.NativeArray<System.Single> halfExtentYs, Unity.Collections.NativeArray<System.Single> halfExtentZs, Unity.Collections.NativeArray<System.Int32> visibilityOut) { }
        private System.Void SPMDCullAABBNoFar(UnityEngine.Matrix4x4 viewProj, Unity.Collections.NativeArray<System.Single> centerXs, Unity.Collections.NativeArray<System.Single> centerYs, Unity.Collections.NativeArray<System.Single> centerZs, Unity.Collections.NativeArray<System.Single> halfExtentXs, Unity.Collections.NativeArray<System.Single> halfExtentYs, Unity.Collections.NativeArray<System.Single> halfExtentZs, Unity.Collections.NativeArray<System.Int32> visibilityOut) { }
        private System.Boolean TestPlanesAABB(UnityEngine.Plane[] planes, UnityEngine.Bounds bounds) { }
        private System.Void Internal_SPMDCullAABB(UnityEngine.Matrix4x4 viewProj, System.UInt32 aabbCount, System.UIntPtr centerXs, System.UIntPtr centerYs, System.UIntPtr centerZs, System.UIntPtr halfExtentXs, System.UIntPtr halfExtentYs, System.UIntPtr halfExtentZs, System.IntPtr visibilityOut) { }
        private System.Void Internal_SPMDCullAABBNoFar(UnityEngine.Matrix4x4 viewProj, System.UInt32 aabbCount, System.UIntPtr centerXs, System.UIntPtr centerYs, System.UIntPtr centerZs, System.UIntPtr halfExtentXs, System.UIntPtr halfExtentYs, System.UIntPtr halfExtentZs, System.IntPtr visibilityOut) { }
        private System.Single DistFromAABBToPoint(UnityEngine.Vector3 bCenter, UnityEngine.Vector3 bExtent, UnityEngine.Vector3 point) { }
        private System.Void Internal_ExtractPlanes(UnityEngine.Plane[] planes, UnityEngine.Matrix4x4 worldToProjectionMatrix) { }
        private System.Boolean TestPlanesAABB_Injected(UnityEngine.Plane[] planes, UnityEngine.Bounds& bounds) { }
        private System.Void Internal_SPMDCullAABB_Injected(UnityEngine.Matrix4x4& viewProj, System.UInt32 aabbCount, System.UIntPtr centerXs, System.UIntPtr centerYs, System.UIntPtr centerZs, System.UIntPtr halfExtentXs, System.UIntPtr halfExtentYs, System.UIntPtr halfExtentZs, System.IntPtr visibilityOut) { }
        private System.Void Internal_SPMDCullAABBNoFar_Injected(UnityEngine.Matrix4x4& viewProj, System.UInt32 aabbCount, System.UIntPtr centerXs, System.UIntPtr centerYs, System.UIntPtr centerZs, System.UIntPtr halfExtentXs, System.UIntPtr halfExtentYs, System.UIntPtr halfExtentZs, System.IntPtr visibilityOut) { }
        private System.Single DistFromAABBToPoint_Injected(UnityEngine.Vector3& bCenter, UnityEngine.Vector3& bExtent, UnityEngine.Vector3& point) { }
        private System.Void Internal_ExtractPlanes_Injected(UnityEngine.Plane[] planes, UnityEngine.Matrix4x4& worldToProjectionMatrix) { }

    }

    // TypeToken: 0x20000AE
    public struct Plane, IFormattable
    {
        // Fields
        private static System.Int32 size;        // 0x0
        private UnityEngine.Vector3 m_Normal;        // 0x10
        private System.Single m_Distance;        // 0x1C

        // Methods
        private UnityEngine.Vector3 get_normal() { }
        private System.Void set_normal(UnityEngine.Vector3 value) { }
        private System.Single get_distance() { }
        private System.Void set_distance(System.Single value) { }
        private System.Void .ctor(UnityEngine.Vector3 inNormal, UnityEngine.Vector3 inPoint) { }
        private System.Void .ctor(UnityEngine.Vector3 inNormal, System.Single d) { }
        private System.Void .ctor(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c) { }
        private System.Void SetNormalAndPosition(UnityEngine.Vector3 inNormal, UnityEngine.Vector3 inPoint) { }
        private System.Single GetDistanceToPoint(UnityEngine.Vector3 point) { }
        private System.Boolean GetSide(UnityEngine.Vector3 point) { }
        private System.Boolean SameSide(UnityEngine.Vector3 inPt0, UnityEngine.Vector3 inPt1) { }
        private System.Boolean Raycast(UnityEngine.Ray ray, System.Single& enter) { }
        private System.String ToString() { }
        private System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x20000AF
    public struct Ray, IFormattable
    {
        // Fields
        private UnityEngine.Vector3 m_Origin;        // 0x10
        private UnityEngine.Vector3 m_Direction;        // 0x1C

        // Methods
        private System.Void .ctor(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction) { }
        private UnityEngine.Vector3 get_origin() { }
        private System.Void set_origin(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_direction() { }
        private System.Void set_direction(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 GetPoint(System.Single distance) { }
        private System.String ToString() { }
        private System.String ToString(System.String format) { }
        private System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x20000B0
    public struct Ray2D, IFormattable
    {
        // Fields
        private UnityEngine.Vector2 m_Origin;        // 0x10
        private UnityEngine.Vector2 m_Direction;        // 0x18

        // Methods
        private System.Void .ctor(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction) { }
        private UnityEngine.Vector2 get_origin() { }
        private System.Void set_origin(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 get_direction() { }
        private System.Void set_direction(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 GetPoint(System.Single distance) { }
        private System.String ToString() { }
        private System.String ToString(System.String format) { }
        private System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x20000B1
    public struct Rect, IEquatable`1, IFormattable
    {
        // Fields
        private System.Single m_XMin;        // 0x10
        private System.Single m_YMin;        // 0x14
        private System.Single m_Width;        // 0x18
        private System.Single m_Height;        // 0x1C

        // Methods
        private System.Void .ctor(System.Single x, System.Single y, System.Single width, System.Single height) { }
        private System.Void .ctor(UnityEngine.Vector2 position, UnityEngine.Vector2 size) { }
        private System.Void .ctor(UnityEngine.Rect source) { }
        private UnityEngine.Rect get_zero() { }
        private UnityEngine.Rect MinMaxRect(System.Single xmin, System.Single ymin, System.Single xmax, System.Single ymax) { }
        private System.Void Set(System.Single x, System.Single y, System.Single width, System.Single height) { }
        private System.Single get_x() { }
        private System.Void set_x(System.Single value) { }
        private System.Single get_y() { }
        private System.Void set_y(System.Single value) { }
        private UnityEngine.Vector2 get_position() { }
        private System.Void set_position(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 get_center() { }
        private System.Void set_center(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 get_min() { }
        private System.Void set_min(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 get_max() { }
        private System.Void set_max(UnityEngine.Vector2 value) { }
        private System.Single get_width() { }
        private System.Void set_width(System.Single value) { }
        private System.Single get_height() { }
        private System.Void set_height(System.Single value) { }
        private UnityEngine.Vector2 get_size() { }
        private System.Void set_size(UnityEngine.Vector2 value) { }
        private System.Single get_xMin() { }
        private System.Void set_xMin(System.Single value) { }
        private System.Single get_yMin() { }
        private System.Void set_yMin(System.Single value) { }
        private System.Single get_xMax() { }
        private System.Void set_xMax(System.Single value) { }
        private System.Single get_yMax() { }
        private System.Void set_yMax(System.Single value) { }
        private System.Boolean Contains(UnityEngine.Vector2 point) { }
        private System.Boolean Contains(UnityEngine.Vector3 point) { }
        private System.Boolean Contains(UnityEngine.Vector3 point, System.Boolean allowInverse) { }
        private UnityEngine.Rect OrderMinMax(UnityEngine.Rect rect) { }
        private System.Boolean Overlaps(UnityEngine.Rect other) { }
        private System.Boolean Overlaps(UnityEngine.Rect other, System.Boolean allowInverse) { }
        private UnityEngine.Vector2 NormalizedToPoint(UnityEngine.Rect rectangle, UnityEngine.Vector2 normalizedRectCoordinates) { }
        private UnityEngine.Vector2 PointToNormalized(UnityEngine.Rect rectangle, UnityEngine.Vector2 point) { }
        private System.Boolean op_Inequality(UnityEngine.Rect lhs, UnityEngine.Rect rhs) { }
        private System.Boolean op_Equality(UnityEngine.Rect lhs, UnityEngine.Rect rhs) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(UnityEngine.Rect other) { }
        private System.String ToString() { }
        private System.String ToString(System.String format) { }
        private System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        private System.Single get_left() { }
        private System.Single get_right() { }
        private System.Single get_top() { }
        private System.Single get_bottom() { }

    }

    // TypeToken: 0x20000B2
    public struct RectInt, IEquatable`1, IFormattable
    {
        // Fields
        private System.Int32 m_XMin;        // 0x10
        private System.Int32 m_YMin;        // 0x14
        private System.Int32 m_Width;        // 0x18
        private System.Int32 m_Height;        // 0x1C

        // Methods
        private System.Int32 get_x() { }
        private System.Void set_x(System.Int32 value) { }
        private System.Int32 get_y() { }
        private System.Void set_y(System.Int32 value) { }
        private UnityEngine.Vector2 get_center() { }
        private UnityEngine.Vector2Int get_min() { }
        private System.Void set_min(UnityEngine.Vector2Int value) { }
        private UnityEngine.Vector2Int get_max() { }
        private System.Void set_max(UnityEngine.Vector2Int value) { }
        private System.Int32 get_width() { }
        private System.Void set_width(System.Int32 value) { }
        private System.Int32 get_height() { }
        private System.Void set_height(System.Int32 value) { }
        private System.Int32 get_xMin() { }
        private System.Void set_xMin(System.Int32 value) { }
        private System.Int32 get_yMin() { }
        private System.Void set_yMin(System.Int32 value) { }
        private System.Int32 get_xMax() { }
        private System.Void set_xMax(System.Int32 value) { }
        private System.Int32 get_yMax() { }
        private System.Void set_yMax(System.Int32 value) { }
        private UnityEngine.Vector2Int get_position() { }
        private System.Void set_position(UnityEngine.Vector2Int value) { }
        private UnityEngine.Vector2Int get_size() { }
        private System.Void set_size(UnityEngine.Vector2Int value) { }
        private System.Void SetMinMax(UnityEngine.Vector2Int minPosition, UnityEngine.Vector2Int maxPosition) { }
        private System.Void .ctor(System.Int32 xMin, System.Int32 yMin, System.Int32 width, System.Int32 height) { }
        private System.Void .ctor(UnityEngine.Vector2Int position, UnityEngine.Vector2Int size) { }
        private System.Void ClampToBounds(UnityEngine.RectInt bounds) { }
        private System.Boolean Contains(UnityEngine.Vector2Int position) { }
        private System.Boolean Overlaps(UnityEngine.RectInt other) { }
        private System.String ToString() { }
        private System.String ToString(System.String format) { }
        private System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        private System.Boolean Equals(UnityEngine.RectInt other) { }
        private UnityEngine.RectInt.PositionEnumerator get_allPositionsWithin() { }

    }

    // TypeToken: 0x20000B4
    public class RectOffset, IFormattable
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10
        private readonly System.Object m_SourceStyle;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Object sourceStyle, System.IntPtr source) { }
        private System.Void Finalize() { }
        private System.Void .ctor(System.Int32 left, System.Int32 right, System.Int32 top, System.Int32 bottom) { }
        private System.String ToString() { }
        private System.String ToString(System.String format) { }
        private System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        private System.Void Destroy() { }
        private System.IntPtr InternalCreate() { }
        private System.Void InternalDestroy(System.IntPtr ptr) { }
        private System.Int32 get_left() { }
        private System.Void set_left(System.Int32 value) { }
        private System.Int32 get_right() { }
        private System.Void set_right(System.Int32 value) { }
        private System.Int32 get_top() { }
        private System.Void set_top(System.Int32 value) { }
        private System.Int32 get_bottom() { }
        private System.Void set_bottom(System.Int32 value) { }
        private System.Int32 get_horizontal() { }
        private System.Int32 get_vertical() { }
        private UnityEngine.Rect Add(UnityEngine.Rect rect) { }
        private UnityEngine.Rect Remove(UnityEngine.Rect rect) { }
        private System.Void Add_Injected(UnityEngine.Rect& rect, UnityEngine.Rect& ret) { }
        private System.Void Remove_Injected(UnityEngine.Rect& rect, UnityEngine.Rect& ret) { }

    }

    // TypeToken: 0x20000B5
    public class LightingSettings
    {
        // Methods
        private System.Void LightingSettingsDontStripMe() { }

    }

    // TypeToken: 0x20000B6
    public class Gizmos
    {
        // Methods
        private System.Void DrawLine(UnityEngine.Vector3 from, UnityEngine.Vector3 to) { }
        private System.Void DrawWireSphere(UnityEngine.Vector3 center, System.Single radius) { }
        private System.Void DrawSphere(UnityEngine.Vector3 center, System.Single radius) { }
        private System.Void DrawWireCube(UnityEngine.Vector3 center, UnityEngine.Vector3 size) { }
        private System.Void DrawCube(UnityEngine.Vector3 center, UnityEngine.Vector3 size) { }
        private System.Void DrawMesh(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale) { }
        private System.Void DrawWireMesh(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale) { }
        private System.Void DrawMeshWithMaterial(UnityEngine.Mesh mesh, UnityEngine.Material material, System.Int32 submeshIndex, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale) { }
        private System.Void set_color(UnityEngine.Color value) { }
        private System.Void set_matrix(UnityEngine.Matrix4x4 value) { }
        private System.Void DrawFrustum(UnityEngine.Vector3 center, System.Single fov, System.Single maxRange, System.Single minRange, System.Single aspect) { }
        private System.Void DrawRay(UnityEngine.Vector3 from, UnityEngine.Vector3 direction) { }
        private System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale) { }
        private System.Void DrawWireMesh(UnityEngine.Mesh mesh) { }
        private System.Void DrawWireMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale) { }
        private System.Void DrawLine_Injected(UnityEngine.Vector3& from, UnityEngine.Vector3& to) { }
        private System.Void DrawWireSphere_Injected(UnityEngine.Vector3& center, System.Single radius) { }
        private System.Void DrawSphere_Injected(UnityEngine.Vector3& center, System.Single radius) { }
        private System.Void DrawWireCube_Injected(UnityEngine.Vector3& center, UnityEngine.Vector3& size) { }
        private System.Void DrawCube_Injected(UnityEngine.Vector3& center, UnityEngine.Vector3& size) { }
        private System.Void DrawMesh_Injected(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale) { }
        private System.Void DrawWireMesh_Injected(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale) { }
        private System.Void DrawMeshWithMaterial_Injected(UnityEngine.Mesh mesh, UnityEngine.Material material, System.Int32 submeshIndex, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale) { }
        private System.Void set_color_Injected(UnityEngine.Color& value) { }
        private System.Void set_matrix_Injected(UnityEngine.Matrix4x4& value) { }
        private System.Void DrawFrustum_Injected(UnityEngine.Vector3& center, System.Single fov, System.Single maxRange, System.Single minRange, System.Single aspect) { }

    }

    // TypeToken: 0x20000B7
    public class BeforeRenderOrderAttribute : Attribute
    {
        // Fields
        private System.Int32 <order>k__BackingField;        // 0x10

        // Methods
        private System.Int32 get_order() { }

    }

    // TypeToken: 0x20000B8
    public class BeforeRenderHelper
    {
        // Fields
        private static System.Collections.Generic.List<UnityEngine.BeforeRenderHelper.OrderBlock> s_OrderBlocks;        // 0x0

        // Methods
        private System.Int32 GetUpdateOrder(UnityEngine.Events.UnityAction callback) { }
        private System.Void RegisterCallback(UnityEngine.Events.UnityAction callback) { }
        private System.Void UnregisterCallback(UnityEngine.Events.UnityAction callback) { }
        private System.Void Invoke() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000BA
    public class CustomRenderTextureManager
    {
        // Fields
        private static System.Action<UnityEngine.CustomRenderTexture> textureLoaded;        // 0x0
        private static System.Action<UnityEngine.CustomRenderTexture> textureUnloaded;        // 0x8

        // Methods
        private System.Void InvokeOnTextureLoaded_Internal(UnityEngine.CustomRenderTexture source) { }
        private System.Void InvokeOnTextureUnloaded_Internal(UnityEngine.CustomRenderTexture source) { }

    }

    // TypeToken: 0x20000BB
    public class Display
    {
        // Fields
        private System.IntPtr nativeDisplay;        // 0x10
        public static UnityEngine.Display[] displays;        // 0x0
        private static UnityEngine.Display _mainDisplay;        // 0x8
        private static System.Int32 m_ActiveEditorGameViewTarget;        // 0x10
        private static UnityEngine.Display.DisplaysUpdatedDelegate onDisplaysUpdated;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.IntPtr nativeDisplay) { }
        private System.Int32 get_renderingWidth() { }
        private System.Int32 get_renderingHeight() { }
        private System.Int32 get_systemWidth() { }
        private System.Int32 get_systemHeight() { }
        private UnityEngine.Display.PreTransform get_preTransform() { }
        private System.Void SetRenderingResolution(System.Int32 w, System.Int32 h) { }
        private UnityEngine.Vector3 RelativeMouseAt(UnityEngine.Vector3 inputMouseCoordinates) { }
        private UnityEngine.Display get_main() { }
        private System.Void RecreateDisplayList(System.IntPtr[] nativeDisplay) { }
        private System.Void FireDisplaysUpdated() { }
        private System.Void GetSystemExtImpl(System.IntPtr nativeDisplay, System.Int32& w, System.Int32& h) { }
        private System.Void GetRenderingExtImpl(System.IntPtr nativeDisplay, System.Int32& w, System.Int32& h) { }
        private System.Void SetRenderingResolutionImpl(System.IntPtr nativeDisplay, System.Int32 w, System.Int32 h) { }
        private System.Int32 RelativeMouseAtImpl(System.Int32 x, System.Int32 y, System.Int32& rx, System.Int32& ry) { }
        private System.UInt32 GetPreTransform() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000BE
    public struct EnabledOrientation
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.EnabledOrientation kAutorotateToPortrait;        // 0x0
        public static UnityEngine.EnabledOrientation kAutorotateToPortraitUpsideDown;        // 0x0
        public static UnityEngine.EnabledOrientation kAutorotateToLandscapeLeft;        // 0x0
        public static UnityEngine.EnabledOrientation kAutorotateToLandscapeRight;        // 0x0

    }

    // TypeToken: 0x20000BF
    public struct FullScreenMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.FullScreenMode ExclusiveFullScreen;        // 0x0
        public static UnityEngine.FullScreenMode FullScreenWindow;        // 0x0
        public static UnityEngine.FullScreenMode MaximizedWindow;        // 0x0
        public static UnityEngine.FullScreenMode Windowed;        // 0x0

    }

    // TypeToken: 0x20000C0
    public struct RefreshRate, IEquatable`1
    {
        // Fields
        public System.UInt32 numerator;        // 0x10
        public System.UInt32 denominator;        // 0x14

        // Methods
        private System.Boolean Equals(UnityEngine.RefreshRate other) { }

    }

    // TypeToken: 0x20000C1
    public struct DisplayInfo, IEquatable`1
    {
        // Fields
        private System.UInt64 handle;        // 0x10
        public System.Int32 width;        // 0x18
        public System.Int32 height;        // 0x1C
        public UnityEngine.RefreshRate refreshRate;        // 0x20
        public UnityEngine.RectInt workArea;        // 0x28
        public System.String name;        // 0x38

        // Methods
        private System.Boolean Equals(UnityEngine.DisplayInfo other) { }

    }

    // TypeToken: 0x20000C2
    public class Screen
    {
        // Methods
        private System.Int32 get_width() { }
        private System.Int32 get_height() { }
        private System.Single get_dpi() { }
        private System.Void RequestOrientation(UnityEngine.ScreenOrientation orient) { }
        private UnityEngine.ScreenOrientation GetScreenOrientation() { }
        private UnityEngine.ScreenOrientation get_orientation() { }
        private System.Void set_orientation(UnityEngine.ScreenOrientation value) { }
        private System.Int32 get_sleepTimeout() { }
        private System.Void set_sleepTimeout(System.Int32 value) { }
        private System.Boolean IsOrientationEnabled(UnityEngine.EnabledOrientation orient) { }
        private System.Void SetOrientationEnabled(UnityEngine.EnabledOrientation orient, System.Boolean enabled) { }
        private System.Boolean get_autorotateToPortrait() { }
        private System.Void set_autorotateToPortrait(System.Boolean value) { }
        private System.Boolean get_autorotateToPortraitUpsideDown() { }
        private System.Void set_autorotateToPortraitUpsideDown(System.Boolean value) { }
        private System.Boolean get_autorotateToLandscapeLeft() { }
        private System.Void set_autorotateToLandscapeLeft(System.Boolean value) { }
        private System.Boolean get_autorotateToLandscapeRight() { }
        private System.Void set_autorotateToLandscapeRight(System.Boolean value) { }
        private UnityEngine.Resolution get_currentResolution() { }
        private System.Boolean get_fullScreen() { }
        private System.Void set_fullScreen(System.Boolean value) { }
        private UnityEngine.FullScreenMode get_fullScreenMode() { }
        private System.Void set_fullScreenMode(UnityEngine.FullScreenMode value) { }
        private UnityEngine.Rect get_safeArea() { }
        private UnityEngine.Rect[] get_cutouts() { }
        private System.Void SetResolution(System.Int32 width, System.Int32 height, UnityEngine.FullScreenMode fullscreenMode, System.Int32 preferredRefreshRate) { }
        private System.Void SetResolution(System.Int32 width, System.Int32 height, UnityEngine.FullScreenMode fullscreenMode) { }
        private System.Void SetResolution(System.Int32 width, System.Int32 height, System.Boolean fullscreen, System.Int32 preferredRefreshRate) { }
        private System.Void SetResolution(System.Int32 width, System.Int32 height, System.Boolean fullscreen) { }
        private UnityEngine.Vector2Int get_mainWindowPosition() { }
        private UnityEngine.DisplayInfo get_mainWindowDisplayInfo() { }
        private System.Void GetDisplayLayout(System.Collections.Generic.List<UnityEngine.DisplayInfo> displayLayout) { }
        private UnityEngine.AsyncOperation MoveMainWindowTo(UnityEngine.DisplayInfo& display, UnityEngine.Vector2Int position) { }
        private UnityEngine.Vector2Int GetMainWindowPosition() { }
        private UnityEngine.DisplayInfo GetMainWindowDisplayInfo() { }
        private System.Void GetDisplayLayoutImpl(System.Collections.Generic.List<UnityEngine.DisplayInfo> displayLayout) { }
        private UnityEngine.AsyncOperation MoveMainWindowImpl(UnityEngine.DisplayInfo& display, UnityEngine.Vector2Int position) { }
        private UnityEngine.Resolution[] get_resolutions() { }
        private System.Single get_brightness() { }
        private System.Void set_brightness(System.Single value) { }
        private System.Boolean get_lockCursor() { }
        private System.Void set_lockCursor(System.Boolean value) { }
        private System.Void .ctor() { }
        private System.Void get_currentResolution_Injected(UnityEngine.Resolution& ret) { }
        private System.Void get_safeArea_Injected(UnityEngine.Rect& ret) { }
        private System.Void GetMainWindowPosition_Injected(UnityEngine.Vector2Int& ret) { }
        private System.Void GetMainWindowDisplayInfo_Injected(UnityEngine.DisplayInfo& ret) { }
        private UnityEngine.AsyncOperation MoveMainWindowImpl_Injected(UnityEngine.DisplayInfo& display, UnityEngine.Vector2Int& position) { }

    }

    // TypeToken: 0x20000C3
    public struct RenderBuffer
    {
        // Fields
        public System.Int32 m_RenderTextureInstanceID;        // 0x10
        public System.IntPtr m_BufferPtr;        // 0x18

    }

    // TypeToken: 0x20000C4
    public struct ComputeBufferMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.ComputeBufferMode Immutable;        // 0x0
        public static UnityEngine.ComputeBufferMode Dynamic;        // 0x0
        public static UnityEngine.ComputeBufferMode Circular;        // 0x0
        public static UnityEngine.ComputeBufferMode StreamOut;        // 0x0
        public static UnityEngine.ComputeBufferMode SubUpdates;        // 0x0

    }

    // TypeToken: 0x20000C5
    public class Graphics
    {
        // Fields
        private static readonly System.Int32 kMaxDrawMeshInstanceCount;        // 0x0
        private static System.Collections.Generic.Dictionary<System.Int32,UnityEngine.RenderInstancedDataLayout> s_RenderInstancedDataLayouts;        // 0x8

        // Methods
        private System.Int32 Internal_GetMaxDrawMeshInstanceCount() { }
        private UnityEngine.ColorGamut GetActiveColorGamut() { }
        private UnityEngine.ColorGamut get_activeColorGamut() { }
        private UnityEngine.Rendering.GraphicsTier get_activeTier() { }
        private System.Void set_activeTier(UnityEngine.Rendering.GraphicsTier value) { }
        private System.Int32 get_totalBufferCount() { }
        private System.Int32 get_totalBufferBytes() { }
        private System.Int32 get_totalInternalBufferCount() { }
        private System.Int32 get_totalInternalBufferBytes() { }
        private System.Boolean GetPreserveFramebufferAlpha() { }
        private System.Boolean get_preserveFramebufferAlpha() { }
        private UnityEngine.Rendering.OpenGLESVersion GetMinOpenGLESVersion() { }
        private UnityEngine.Rendering.OpenGLESVersion get_minOpenGLESVersion() { }
        private UnityEngine.RenderBuffer GetActiveColorBuffer() { }
        private UnityEngine.RenderBuffer GetActiveDepthBuffer() { }
        private System.Void Internal_SetNullRT() { }
        private System.Void Internal_SetRTSimple(UnityEngine.RenderBuffer color, UnityEngine.RenderBuffer depth, System.Int32 mip, UnityEngine.CubemapFace face, System.Int32 depthSlice) { }
        private System.Void Internal_SetMRTSimple(UnityEngine.RenderBuffer[] color, UnityEngine.RenderBuffer depth, System.Int32 mip, UnityEngine.CubemapFace face, System.Int32 depthSlice) { }
        private System.Void Internal_SetMRTFullSetup(UnityEngine.RenderBuffer[] color, UnityEngine.RenderBuffer depth, System.Int32 mip, UnityEngine.CubemapFace face, System.Int32 depthSlice, UnityEngine.Rendering.RenderBufferLoadAction[] colorLA, UnityEngine.Rendering.RenderBufferStoreAction[] colorSA, UnityEngine.Rendering.RenderBufferLoadAction depthLA, UnityEngine.Rendering.RenderBufferStoreAction depthSA) { }
        private System.Void Internal_SetRandomWriteTargetRT(System.Int32 index, UnityEngine.RenderTexture uav) { }
        private System.Void Internal_SetRandomWriteTargetBuffer(System.Int32 index, UnityEngine.ComputeBuffer uav, System.Boolean preserveCounterValue) { }
        private System.Void Internal_SetRandomWriteTargetGraphicsBuffer(System.Int32 index, UnityEngine.GraphicsBuffer uav, System.Boolean preserveCounterValue) { }
        private System.Void ClearRandomWriteTargets() { }
        private System.Void CopyTexture_Full(UnityEngine.Texture src, UnityEngine.Texture dst) { }
        private System.Void CopyTexture_Slice_AllMips(UnityEngine.Texture src, System.Int32 srcElement, UnityEngine.Texture dst, System.Int32 dstElement) { }
        private System.Void CopyTexture_Slice(UnityEngine.Texture src, System.Int32 srcElement, System.Int32 srcMip, UnityEngine.Texture dst, System.Int32 dstElement, System.Int32 dstMip) { }
        private System.Void CopyTexture_Region(UnityEngine.Texture src, System.Int32 srcElement, System.Int32 srcMip, System.Int32 srcX, System.Int32 srcY, System.Int32 srcWidth, System.Int32 srcHeight, UnityEngine.Texture dst, System.Int32 dstElement, System.Int32 dstMip, System.Int32 dstX, System.Int32 dstY) { }
        private System.Boolean ConvertTexture_Full(UnityEngine.Texture src, UnityEngine.Texture dst) { }
        private System.Boolean ConvertTexture_Slice(UnityEngine.Texture src, System.Int32 srcElement, UnityEngine.Texture dst, System.Int32 dstElement) { }
        private System.Void CopyBufferImpl(UnityEngine.GraphicsBuffer source, UnityEngine.GraphicsBuffer dest) { }
        private System.Void CopyBufferOffsetImpl(UnityEngine.GraphicsBuffer source, System.Int32 srcOffset, UnityEngine.GraphicsBuffer dest, System.Int32 dstOffset, System.Int32 size) { }
        private System.Void CopyComputeBufferImpl(UnityEngine.ComputeBuffer source, UnityEngine.ComputeBuffer dest) { }
        private System.Void CopyComputeBufferOffsetImpl(UnityEngine.ComputeBuffer source, System.Int32 srcOffset, UnityEngine.ComputeBuffer dest, System.Int32 dstOffset, System.Int32 size) { }
        private System.Void Internal_DrawMeshNow1(UnityEngine.Mesh mesh, System.Int32 subsetIndex, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        private System.Void Internal_DrawMeshNow2(UnityEngine.Mesh mesh, System.Int32 subsetIndex, UnityEngine.Matrix4x4 matrix) { }
        private System.Void Internal_DrawTexture(UnityEngine.Internal_DrawTextureArguments& args) { }
        private System.Void Internal_RenderMesh(UnityEngine.RenderParams rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Matrix4x4 objectToWorld, UnityEngine.Matrix4x4* prevObjectToWorld) { }
        private System.Void Internal_RenderMeshInstanced(UnityEngine.RenderParams rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, System.IntPtr instanceData, UnityEngine.RenderInstancedDataLayout layout, System.UInt32 instanceCount) { }
        private System.Void Internal_RenderMeshIndirect(UnityEngine.RenderParams rparams, UnityEngine.Mesh mesh, UnityEngine.GraphicsBuffer commandBuffer, System.Int32 commandCount, System.Int32 startCommand) { }
        private System.Void Internal_RenderMeshPrimitives(UnityEngine.RenderParams rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, System.Int32 instanceCount) { }
        private System.Void Internal_RenderPrimitives(UnityEngine.RenderParams rparams, UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount) { }
        private System.Void Internal_RenderPrimitivesIndexed(UnityEngine.RenderParams rparams, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, System.Int32 indexCount, System.Int32 startIndex, System.Int32 instanceCount) { }
        private System.Void Internal_RenderPrimitivesIndirect(UnityEngine.RenderParams rparams, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer commandBuffer, System.Int32 commandCount, System.Int32 startCommand) { }
        private System.Void Internal_RenderPrimitivesIndexedIndirect(UnityEngine.RenderParams rparams, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.GraphicsBuffer commandBuffer, System.Int32 commandCount, System.Int32 startCommand) { }
        private System.Void Internal_DrawMesh(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, UnityEngine.Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume) { }
        private System.Void Internal_DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume) { }
        private System.Void Internal_DrawMeshInstancedProcedural(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds bounds, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume) { }
        private System.Void Internal_DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume) { }
        private System.Void Internal_DrawMeshInstancedIndirectGraphicsBuffer(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume) { }
        private System.Void Internal_DrawProceduralNow(UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount) { }
        private System.Void Internal_DrawProceduralIndexedNow(UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, System.Int32 indexCount, System.Int32 instanceCount) { }
        private System.Void Internal_DrawProceduralIndirectNow(UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset) { }
        private System.Void Internal_DrawProceduralIndexedIndirectNow(UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset) { }
        private System.Void Internal_DrawProceduralIndirectNowGraphicsBuffer(UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset) { }
        private System.Void Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer(UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset) { }
        private System.Void Internal_DrawProcedural(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer) { }
        private System.Void Internal_DrawProceduralIndexed(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, System.Int32 indexCount, System.Int32 instanceCount, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer) { }
        private System.Void Internal_DrawProceduralIndirect(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer) { }
        private System.Void Internal_DrawProceduralIndirectGraphicsBuffer(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer) { }
        private System.Void Internal_DrawProceduralIndexedIndirect(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer) { }
        private System.Void Internal_DrawProceduralIndexedIndirectGraphicsBuffer(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer) { }
        private System.Void Internal_BlitMaterial5(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat, System.Int32 pass, System.Boolean setRT) { }
        private System.Void Internal_BlitMaterial6(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat, System.Int32 pass, System.Boolean setRT, System.Int32 destDepthSlice) { }
        private System.Void Internal_BlitMultiTap4(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat, UnityEngine.Vector2[] offsets) { }
        private System.Void Internal_BlitMultiTap5(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat, UnityEngine.Vector2[] offsets, System.Int32 destDepthSlice) { }
        private System.Void Blit2(UnityEngine.Texture source, UnityEngine.RenderTexture dest) { }
        private System.Void Blit3(UnityEngine.Texture source, UnityEngine.RenderTexture dest, System.Int32 sourceDepthSlice, System.Int32 destDepthSlice) { }
        private System.Void Blit4(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset) { }
        private System.Void Blit5(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, System.Int32 sourceDepthSlice, System.Int32 destDepthSlice) { }
        private System.IntPtr CreateGPUFenceImpl(UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage) { }
        private System.Void WaitOnGPUFenceImpl(System.IntPtr fencePtr, UnityEngine.Rendering.SynchronisationStageFlags stage) { }
        private System.Void ExecuteCommandBuffer(UnityEngine.Rendering.CommandBuffer buffer) { }
        private System.Void ExecuteCommandBufferAsync(UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType) { }
        private System.Int32 GetGfxBufferCount() { }
        private System.Void GetGfxBufferStats(System.Collections.Generic.List<System.Int32> bufferSizes, System.Collections.Generic.List<System.String> bufferNames) { }
        private System.Int64 GetTotalPsoCreationTimeInCPUCycles() { }
        private UnityEngine.PipelineCacheLoadResult GetPipelineCacheLoadResult() { }
        private System.Void DebugRecordRenderGraph(System.UInt32 frameOffset, System.UInt32 count) { }
        private System.Void CheckLoadActionValid(UnityEngine.Rendering.RenderBufferLoadAction load, System.String bufferType) { }
        private System.Void CheckStoreActionValid(UnityEngine.Rendering.RenderBufferStoreAction store, System.String bufferType) { }
        private System.Void SetRenderTargetImpl(UnityEngine.RenderTargetSetup setup) { }
        private System.Void SetRenderTargetImpl(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer, System.Int32 mipLevel, UnityEngine.CubemapFace face, System.Int32 depthSlice) { }
        private System.Void SetRenderTargetImpl(UnityEngine.RenderTexture rt, System.Int32 mipLevel, UnityEngine.CubemapFace face, System.Int32 depthSlice) { }
        private System.Void SetRenderTargetImpl(UnityEngine.RenderBuffer[] colorBuffers, UnityEngine.RenderBuffer depthBuffer, System.Int32 mipLevel, UnityEngine.CubemapFace face, System.Int32 depthSlice) { }
        private System.Void SetRenderTarget(UnityEngine.RenderTexture rt, System.Int32 mipLevel, UnityEngine.CubemapFace face, System.Int32 depthSlice) { }
        private System.Void SetRenderTarget(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer, System.Int32 mipLevel, UnityEngine.CubemapFace face, System.Int32 depthSlice) { }
        private System.Void SetRenderTarget(UnityEngine.RenderBuffer[] colorBuffers, UnityEngine.RenderBuffer depthBuffer) { }
        private System.Void SetRenderTarget(UnityEngine.RenderTargetSetup setup) { }
        private UnityEngine.RenderBuffer get_activeColorBuffer() { }
        private UnityEngine.RenderBuffer get_activeDepthBuffer() { }
        private System.Void SetRandomWriteTarget(System.Int32 index, UnityEngine.RenderTexture uav) { }
        private System.Void SetRandomWriteTarget(System.Int32 index, UnityEngine.ComputeBuffer uav, System.Boolean preserveCounterValue) { }
        private System.Void SetRandomWriteTarget(System.Int32 index, UnityEngine.GraphicsBuffer uav, System.Boolean preserveCounterValue) { }
        private System.Void CopyTexture(UnityEngine.Texture src, UnityEngine.Texture dst) { }
        private System.Void CopyTexture(UnityEngine.Texture src, System.Int32 srcElement, UnityEngine.Texture dst, System.Int32 dstElement) { }
        private System.Void CopyTexture(UnityEngine.Texture src, System.Int32 srcElement, System.Int32 srcMip, UnityEngine.Texture dst, System.Int32 dstElement, System.Int32 dstMip) { }
        private System.Void CopyTexture(UnityEngine.Texture src, System.Int32 srcElement, System.Int32 srcMip, System.Int32 srcX, System.Int32 srcY, System.Int32 srcWidth, System.Int32 srcHeight, UnityEngine.Texture dst, System.Int32 dstElement, System.Int32 dstMip, System.Int32 dstX, System.Int32 dstY) { }
        private System.Boolean ConvertTexture(UnityEngine.Texture src, UnityEngine.Texture dst) { }
        private System.Boolean ConvertTexture(UnityEngine.Texture src, System.Int32 srcElement, UnityEngine.Texture dst, System.Int32 dstElement) { }
        private UnityEngine.Rendering.GraphicsFence CreateAsyncGraphicsFence(UnityEngine.Rendering.SynchronisationStage stage) { }
        private UnityEngine.Rendering.GraphicsFence CreateAsyncGraphicsFence() { }
        private UnityEngine.Rendering.GraphicsFence CreateGraphicsFence(UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage) { }
        private System.Void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence fence) { }
        private System.Void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence fence, UnityEngine.Rendering.SynchronisationStage stage) { }
        private System.Void ValidateCopyBuffer(UnityEngine.GraphicsBuffer source, UnityEngine.GraphicsBuffer dest) { }
        private System.Void ValidateCopyBuffer(UnityEngine.GraphicsBuffer source, System.Int32 srcOffset, UnityEngine.GraphicsBuffer dest, System.Int32 dstOffset, System.Int32 size) { }
        private System.Void ValidateCopyBuffer(UnityEngine.ComputeBuffer source, UnityEngine.ComputeBuffer dest) { }
        private System.Void ValidateCopyBuffer(UnityEngine.ComputeBuffer source, System.Int32 srcOffset, UnityEngine.ComputeBuffer dest, System.Int32 dstOffset, System.Int32 size) { }
        private System.Void CopyBuffer(UnityEngine.GraphicsBuffer source, UnityEngine.GraphicsBuffer dest) { }
        private System.Void CopyBuffer(UnityEngine.GraphicsBuffer source, System.Int32 srcOffset, UnityEngine.GraphicsBuffer dest, System.Int32 dstOffset, System.Int32 size) { }
        private System.Void CopyBuffer(UnityEngine.ComputeBuffer source, UnityEngine.ComputeBuffer dest) { }
        private System.Void CopyBuffer(UnityEngine.ComputeBuffer source, System.Int32 srcOffset, UnityEngine.ComputeBuffer dest, System.Int32 dstOffset, System.Int32 size) { }
        private System.Void DrawTextureImpl(UnityEngine.Rect screenRect, UnityEngine.Texture texture, UnityEngine.Rect sourceRect, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, UnityEngine.Color color, UnityEngine.Material mat, System.Int32 pass) { }
        private System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, UnityEngine.Rect sourceRect, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, UnityEngine.Color color, UnityEngine.Material mat, System.Int32 pass) { }
        private System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, UnityEngine.Rect sourceRect, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, UnityEngine.Material mat, System.Int32 pass) { }
        private System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, UnityEngine.Material mat, System.Int32 pass) { }
        private System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, UnityEngine.Material mat, System.Int32 pass) { }
        private System.Void RenderMesh(UnityEngine.RenderParams& rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Matrix4x4 objectToWorld, System.Nullable<UnityEngine.Matrix4x4> prevObjectToWorld) { }
        private UnityEngine.RenderInstancedDataLayout GetCachedRenderInstancedDataLayout(System.Type type) { }
        private System.Void RenderMeshInstanced(UnityEngine.RenderParams& rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, T[] instanceData, System.Int32 instanceCount, System.Int32 startInstance) { }
        private System.Void RenderMeshInstanced(UnityEngine.RenderParams& rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, System.Collections.Generic.List<T> instanceData, System.Int32 instanceCount, System.Int32 startInstance) { }
        private System.Void RenderMeshInstanced(UnityEngine.RenderParams rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, Unity.Collections.NativeArray<T> instanceData, System.Int32 instanceCount, System.Int32 startInstance) { }
        private System.Void RenderMeshIndirect(UnityEngine.RenderParams& rparams, UnityEngine.Mesh mesh, UnityEngine.GraphicsBuffer commandBuffer, System.Int32 commandCount, System.Int32 startCommand) { }
        private System.Void RenderMeshPrimitives(UnityEngine.RenderParams& rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, System.Int32 instanceCount) { }
        private System.Void RenderPrimitives(UnityEngine.RenderParams& rparams, UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount) { }
        private System.Void RenderPrimitivesIndexed(UnityEngine.RenderParams& rparams, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, System.Int32 indexCount, System.Int32 startIndex, System.Int32 instanceCount) { }
        private System.Void RenderPrimitivesIndirect(UnityEngine.RenderParams& rparams, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer commandBuffer, System.Int32 commandCount, System.Int32 startCommand) { }
        private System.Void RenderPrimitivesIndexedIndirect(UnityEngine.RenderParams& rparams, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.GraphicsBuffer commandBuffer, System.Int32 commandCount, System.Int32 startCommand) { }
        private System.Void DrawMeshNow(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Int32 materialIndex) { }
        private System.Void DrawMeshNow(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, System.Int32 materialIndex) { }
        private System.Void DrawMeshNow(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        private System.Void DrawMeshNow(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix) { }
        private System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, System.Boolean castShadows, System.Boolean receiveShadows, System.Boolean useLightProbes) { }
        private System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, UnityEngine.Transform probeAnchor, System.Boolean useLightProbes) { }
        private System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, System.Boolean castShadows, System.Boolean receiveShadows, System.Boolean useLightProbes) { }
        private System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, UnityEngine.Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume) { }
        private System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume) { }
        private System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume) { }
        private System.Void DrawMeshInstancedProcedural(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds bounds, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume) { }
        private System.Void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume) { }
        private System.Void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume) { }
        private System.Void DrawProceduralNow(UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount) { }
        private System.Void DrawProceduralNow(UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, System.Int32 indexCount, System.Int32 instanceCount) { }
        private System.Void DrawProceduralIndirectNow(UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset) { }
        private System.Void DrawProceduralIndirectNow(UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset) { }
        private System.Void DrawProceduralIndirectNow(UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset) { }
        private System.Void DrawProceduralIndirectNow(UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset) { }
        private System.Void DrawProcedural(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer) { }
        private System.Void DrawProcedural(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, System.Int32 indexCount, System.Int32 instanceCount, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer) { }
        private System.Void DrawProceduralIndirect(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer) { }
        private System.Void DrawProceduralIndirect(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer) { }
        private System.Void DrawProceduralIndirect(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer) { }
        private System.Void DrawProceduralIndirect(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer) { }
        private System.Void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest) { }
        private System.Void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest, System.Int32 sourceDepthSlice, System.Int32 destDepthSlice) { }
        private System.Void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset) { }
        private System.Void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, System.Int32 sourceDepthSlice, System.Int32 destDepthSlice) { }
        private System.Void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat, System.Int32 pass) { }
        private System.Void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat, System.Int32 pass, System.Int32 destDepthSlice) { }
        private System.Void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat) { }
        private System.Void Blit(UnityEngine.Texture source, UnityEngine.Material mat, System.Int32 pass) { }
        private System.Void Blit(UnityEngine.Texture source, UnityEngine.Material mat, System.Int32 pass, System.Int32 destDepthSlice) { }
        private System.Void Blit(UnityEngine.Texture source, UnityEngine.Material mat) { }
        private System.Void BlitMultiTap(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat, UnityEngine.Vector2[] offsets) { }
        private System.Void BlitMultiTap(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat, System.Int32 destDepthSlice, UnityEngine.Vector2[] offsets) { }
        private System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer) { }
        private System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera) { }
        private System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex) { }
        private System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties) { }
        private System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, System.Boolean castShadows) { }
        private System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, System.Boolean castShadows, System.Boolean receiveShadows) { }
        private System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows) { }
        private System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows) { }
        private System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, UnityEngine.Transform probeAnchor) { }
        private System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer) { }
        private System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera) { }
        private System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex) { }
        private System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties) { }
        private System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, System.Boolean castShadows) { }
        private System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, System.Boolean castShadows, System.Boolean receiveShadows) { }
        private System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows) { }
        private System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows) { }
        private System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, UnityEngine.Transform probeAnchor) { }
        private System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, UnityEngine.Transform probeAnchor, System.Boolean useLightProbes) { }
        private System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, UnityEngine.Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage) { }
        private System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices) { }
        private System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, System.Int32 count) { }
        private System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, System.Int32 count, UnityEngine.MaterialPropertyBlock properties) { }
        private System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows) { }
        private System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows) { }
        private System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer) { }
        private System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera) { }
        private System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage) { }
        private System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices) { }
        private System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices, UnityEngine.MaterialPropertyBlock properties) { }
        private System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows) { }
        private System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows) { }
        private System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer) { }
        private System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera) { }
        private System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage) { }
        private System.Void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage) { }
        private System.Void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage) { }
        private System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, UnityEngine.Rect sourceRect, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, UnityEngine.Color color, UnityEngine.Material mat) { }
        private System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, UnityEngine.Rect sourceRect, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, UnityEngine.Color color) { }
        private System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, UnityEngine.Rect sourceRect, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, UnityEngine.Material mat) { }
        private System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, UnityEngine.Rect sourceRect, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder) { }
        private System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, UnityEngine.Material mat) { }
        private System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder) { }
        private System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, UnityEngine.Material mat) { }
        private System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture) { }
        private System.Void SetRenderTarget(UnityEngine.RenderTexture rt) { }
        private System.Void SetRenderTarget(UnityEngine.RenderTexture rt, System.Int32 mipLevel) { }
        private System.Void SetRenderTarget(UnityEngine.RenderTexture rt, System.Int32 mipLevel, UnityEngine.CubemapFace face) { }
        private System.Void SetRenderTarget(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer) { }
        private System.Void SetRenderTarget(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer, System.Int32 mipLevel) { }
        private System.Void SetRenderTarget(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer, System.Int32 mipLevel, UnityEngine.CubemapFace face) { }
        private System.Void SetRandomWriteTarget(System.Int32 index, UnityEngine.ComputeBuffer uav) { }
        private System.Void SetRandomWriteTarget(System.Int32 index, UnityEngine.GraphicsBuffer uav) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }
        private System.Void GetActiveColorBuffer_Injected(UnityEngine.RenderBuffer& ret) { }
        private System.Void GetActiveDepthBuffer_Injected(UnityEngine.RenderBuffer& ret) { }
        private System.Void Internal_SetRTSimple_Injected(UnityEngine.RenderBuffer& color, UnityEngine.RenderBuffer& depth, System.Int32 mip, UnityEngine.CubemapFace face, System.Int32 depthSlice) { }
        private System.Void Internal_SetMRTSimple_Injected(UnityEngine.RenderBuffer[] color, UnityEngine.RenderBuffer& depth, System.Int32 mip, UnityEngine.CubemapFace face, System.Int32 depthSlice) { }
        private System.Void Internal_SetMRTFullSetup_Injected(UnityEngine.RenderBuffer[] color, UnityEngine.RenderBuffer& depth, System.Int32 mip, UnityEngine.CubemapFace face, System.Int32 depthSlice, UnityEngine.Rendering.RenderBufferLoadAction[] colorLA, UnityEngine.Rendering.RenderBufferStoreAction[] colorSA, UnityEngine.Rendering.RenderBufferLoadAction depthLA, UnityEngine.Rendering.RenderBufferStoreAction depthSA) { }
        private System.Void Internal_DrawMeshNow1_Injected(UnityEngine.Mesh mesh, System.Int32 subsetIndex, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation) { }
        private System.Void Internal_DrawMeshNow2_Injected(UnityEngine.Mesh mesh, System.Int32 subsetIndex, UnityEngine.Matrix4x4& matrix) { }
        private System.Void Internal_RenderMesh_Injected(UnityEngine.RenderParams& rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Matrix4x4& objectToWorld, UnityEngine.Matrix4x4* prevObjectToWorld) { }
        private System.Void Internal_RenderMeshInstanced_Injected(UnityEngine.RenderParams& rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, System.IntPtr instanceData, UnityEngine.RenderInstancedDataLayout& layout, System.UInt32 instanceCount) { }
        private System.Void Internal_RenderMeshIndirect_Injected(UnityEngine.RenderParams& rparams, UnityEngine.Mesh mesh, UnityEngine.GraphicsBuffer commandBuffer, System.Int32 commandCount, System.Int32 startCommand) { }
        private System.Void Internal_RenderMeshPrimitives_Injected(UnityEngine.RenderParams& rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, System.Int32 instanceCount) { }
        private System.Void Internal_RenderPrimitives_Injected(UnityEngine.RenderParams& rparams, UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount) { }
        private System.Void Internal_RenderPrimitivesIndexed_Injected(UnityEngine.RenderParams& rparams, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, System.Int32 indexCount, System.Int32 startIndex, System.Int32 instanceCount) { }
        private System.Void Internal_RenderPrimitivesIndirect_Injected(UnityEngine.RenderParams& rparams, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer commandBuffer, System.Int32 commandCount, System.Int32 startCommand) { }
        private System.Void Internal_RenderPrimitivesIndexedIndirect_Injected(UnityEngine.RenderParams& rparams, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.GraphicsBuffer commandBuffer, System.Int32 commandCount, System.Int32 startCommand) { }
        private System.Void Internal_DrawMesh_Injected(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Matrix4x4& matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, UnityEngine.Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume) { }
        private System.Void Internal_DrawMeshInstancedProcedural_Injected(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds& bounds, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume) { }
        private System.Void Internal_DrawMeshInstancedIndirect_Injected(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds& bounds, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume) { }
        private System.Void Internal_DrawMeshInstancedIndirectGraphicsBuffer_Injected(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds& bounds, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume) { }
        private System.Void Internal_DrawProcedural_Injected(UnityEngine.Material material, UnityEngine.Bounds& bounds, UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer) { }
        private System.Void Internal_DrawProceduralIndexed_Injected(UnityEngine.Material material, UnityEngine.Bounds& bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, System.Int32 indexCount, System.Int32 instanceCount, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer) { }
        private System.Void Internal_DrawProceduralIndirect_Injected(UnityEngine.Material material, UnityEngine.Bounds& bounds, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer) { }
        private System.Void Internal_DrawProceduralIndirectGraphicsBuffer_Injected(UnityEngine.Material material, UnityEngine.Bounds& bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer) { }
        private System.Void Internal_DrawProceduralIndexedIndirect_Injected(UnityEngine.Material material, UnityEngine.Bounds& bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer) { }
        private System.Void Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected(UnityEngine.Material material, UnityEngine.Bounds& bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer) { }
        private System.Void Blit4_Injected(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Vector2& scale, UnityEngine.Vector2& offset) { }
        private System.Void Blit5_Injected(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Vector2& scale, UnityEngine.Vector2& offset, System.Int32 sourceDepthSlice, System.Int32 destDepthSlice) { }

    }

    // TypeToken: 0x20000C6
    public class GL
    {
        // Methods
        private System.Void Vertex3(System.Single x, System.Single y, System.Single z) { }
        private System.Void TexCoord3(System.Single x, System.Single y, System.Single z) { }
        private System.Void TexCoord2(System.Single x, System.Single y) { }
        private System.Void ImmediateColor(System.Single r, System.Single g, System.Single b, System.Single a) { }
        private System.Void Color(UnityEngine.Color c) { }
        private System.Boolean get_wireframe() { }
        private System.Void set_sRGBWrite(System.Boolean value) { }
        private System.Void SetViewMatrix(UnityEngine.Matrix4x4 m) { }
        private System.Void set_modelview(UnityEngine.Matrix4x4 value) { }
        private System.Void PushMatrix() { }
        private System.Void PopMatrix() { }
        private System.Void LoadOrtho() { }
        private System.Void LoadProjectionMatrix(UnityEngine.Matrix4x4 mat) { }
        private UnityEngine.Matrix4x4 GetGPUProjectionMatrix(UnityEngine.Matrix4x4 proj, System.Boolean renderIntoTexture) { }
        private System.Void GLLoadPixelMatrixScript(System.Single left, System.Single right, System.Single bottom, System.Single top) { }
        private System.Void LoadPixelMatrix(System.Single left, System.Single right, System.Single bottom, System.Single top) { }
        private System.Void GLIssuePluginEvent(System.IntPtr callback, System.Int32 eventID) { }
        private System.Void IssuePluginEvent(System.IntPtr callback, System.Int32 eventID) { }
        private System.Void Begin(System.Int32 mode) { }
        private System.Void End() { }
        private System.Void GLClear(System.Boolean clearDepth, System.Boolean clearColor, UnityEngine.Color backgroundColor, System.Single depth) { }
        private System.Void Clear(System.Boolean clearDepth, System.Boolean clearColor, UnityEngine.Color backgroundColor, System.Single depth) { }
        private System.Void Clear(System.Boolean clearDepth, System.Boolean clearColor, UnityEngine.Color backgroundColor) { }
        private System.Void Viewport(UnityEngine.Rect pixelRect) { }
        private System.Void SetViewMatrix_Injected(UnityEngine.Matrix4x4& m) { }
        private System.Void LoadProjectionMatrix_Injected(UnityEngine.Matrix4x4& mat) { }
        private System.Void GetGPUProjectionMatrix_Injected(UnityEngine.Matrix4x4& proj, System.Boolean renderIntoTexture, UnityEngine.Matrix4x4& ret) { }
        private System.Void GLClear_Injected(System.Boolean clearDepth, System.Boolean clearColor, UnityEngine.Color& backgroundColor, System.Single depth) { }
        private System.Void Viewport_Injected(UnityEngine.Rect& pixelRect) { }

    }

    // TypeToken: 0x20000C7
    public class ScalableBufferManager
    {
        // Methods
        private System.Single get_widthScaleFactor() { }
        private System.Single get_heightScaleFactor() { }
        private System.Void ResizeBuffers(System.Single widthScale, System.Single heightScale) { }

    }

    // TypeToken: 0x20000C8
    public class LightmapData
    {
        // Fields
        private UnityEngine.Texture2D m_Light;        // 0x10
        private UnityEngine.Texture2D m_Dir;        // 0x18
        private UnityEngine.Texture2D m_ShadowMask;        // 0x20

        // Methods
        private UnityEngine.Texture2D get_lightmapColor() { }
        private System.Void set_lightmapColor(UnityEngine.Texture2D value) { }
        private UnityEngine.Texture2D get_lightmapDir() { }
        private System.Void set_lightmapDir(UnityEngine.Texture2D value) { }
        private UnityEngine.Texture2D get_shadowMask() { }
        private System.Void set_shadowMask(UnityEngine.Texture2D value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C9
    public class LightmapSettings
    {
        // Methods
        private System.Void set_lightmaps(UnityEngine.LightmapData[] value) { }

    }

    // TypeToken: 0x20000CA
    public class LightProbes
    {
        // Fields
        private static System.Action tetrahedralizationCompleted;        // 0x0
        private static System.Action needsRetetrahedralization;        // 0x8

        // Methods
        private System.Void .ctor() { }
        private System.Void add_tetrahedralizationCompleted(System.Action value) { }
        private System.Void remove_tetrahedralizationCompleted(System.Action value) { }
        private System.Void Internal_CallTetrahedralizationCompletedFunction() { }
        private System.Void add_needsRetetrahedralization(System.Action value) { }
        private System.Void remove_needsRetetrahedralization(System.Action value) { }
        private System.Void Internal_CallNeedsRetetrahedralizationFunction() { }
        private System.Void Tetrahedralize() { }
        private System.Void TetrahedralizeAsync() { }
        private System.Void GetInterpolatedProbe(UnityEngine.Vector3 position, UnityEngine.Renderer renderer, UnityEngine.Rendering.SphericalHarmonicsL2& probe) { }
        private System.Boolean AreLightProbesAllowed(UnityEngine.Renderer renderer) { }
        private System.Void CalculateInterpolatedLightAndOcclusionProbes(UnityEngine.Vector3[] positions, UnityEngine.Rendering.SphericalHarmonicsL2[] lightProbes, UnityEngine.Vector4[] occlusionProbes) { }
        private System.Void CalculateInterpolatedLightAndOcclusionProbes(UnityEngine.Vector3[] positions, System.Int32 count, UnityEngine.Rendering.SphericalHarmonicsL2[] lightProbes, UnityEngine.Vector4[] occlusionProbes) { }
        private System.Void CalculateInterpolatedLightAndOcclusionProbes(System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Rendering.SphericalHarmonicsL2> lightProbes, System.Collections.Generic.List<UnityEngine.Vector4> occlusionProbes) { }
        private System.Void CalculateInterpolatedLightAndOcclusionProbes(System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Int32 count, System.Collections.Generic.List<UnityEngine.Rendering.SphericalHarmonicsL2> lightProbes, System.Collections.Generic.List<UnityEngine.Vector4> occlusionProbes) { }
        private System.Void CalculateInterpolatedLightAndOcclusionProbes_Internal(UnityEngine.Vector3[] positions, System.Int32 positionsCount, UnityEngine.Rendering.SphericalHarmonicsL2[] lightProbes, UnityEngine.Vector4[] occlusionProbes) { }
        private UnityEngine.Vector3[] get_positions() { }
        private UnityEngine.Rendering.SphericalHarmonicsL2[] get_bakedProbes() { }
        private System.Void set_bakedProbes(UnityEngine.Rendering.SphericalHarmonicsL2[] value) { }
        private System.Int32 get_count() { }
        private System.Int32 get_cellCount() { }
        private System.Int32 GetCount() { }
        private System.Void GetInterpolatedLightProbe(UnityEngine.Vector3 position, UnityEngine.Renderer renderer, System.Single[] coefficients) { }
        private System.Single[] get_coefficients() { }
        private System.Void set_coefficients(System.Single[] value) { }
        private System.Void GetInterpolatedProbe_Injected(UnityEngine.Vector3& position, UnityEngine.Renderer renderer, UnityEngine.Rendering.SphericalHarmonicsL2& probe) { }

    }

    // TypeToken: 0x20000CB
    public class HDROutputSettings
    {
        // Fields
        private System.Int32 m_DisplayIndex;        // 0x10
        public static UnityEngine.HDROutputSettings[] displays;        // 0x0
        private static UnityEngine.HDROutputSettings _mainDisplay;        // 0x8

        // Methods
        private System.Void .ctor() { }
        private UnityEngine.HDROutputSettings get_main() { }
        private System.Boolean get_active() { }
        private System.Boolean GetActive(System.Int32 displayIndex) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000CC
    public struct Resolution
    {
        // Fields
        private System.Int32 m_Width;        // 0x10
        private System.Int32 m_Height;        // 0x14
        private System.Int32 m_RefreshRate;        // 0x18

        // Methods
        private System.Int32 get_width() { }
        private System.Int32 get_height() { }
        private System.Int32 get_refreshRate() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x20000CD
    public struct RenderTargetSetup
    {
        // Fields
        public UnityEngine.RenderBuffer[] color;        // 0x10
        public UnityEngine.RenderBuffer depth;        // 0x18
        public System.Int32 mipLevel;        // 0x28
        public UnityEngine.CubemapFace cubemapFace;        // 0x2C
        public System.Int32 depthSlice;        // 0x30
        public UnityEngine.Rendering.RenderBufferLoadAction[] colorLoad;        // 0x38
        public UnityEngine.Rendering.RenderBufferStoreAction[] colorStore;        // 0x40
        public UnityEngine.Rendering.RenderBufferLoadAction depthLoad;        // 0x48
        public UnityEngine.Rendering.RenderBufferStoreAction depthStore;        // 0x4C

    }

    // TypeToken: 0x20000CE
    public struct RenderParams
    {
        // Fields
        private System.Int32 <layer>k__BackingField;        // 0x10
        private System.UInt32 <renderingLayerMask>k__BackingField;        // 0x14
        private System.Int32 <rendererPriority>k__BackingField;        // 0x18
        private UnityEngine.Bounds <worldBounds>k__BackingField;        // 0x1C
        private UnityEngine.Camera <camera>k__BackingField;        // 0x38
        private UnityEngine.MotionVectorGenerationMode <motionVectorMode>k__BackingField;        // 0x40
        private UnityEngine.Rendering.ReflectionProbeUsage <reflectionProbeUsage>k__BackingField;        // 0x44
        private UnityEngine.Material <material>k__BackingField;        // 0x48
        private UnityEngine.MaterialPropertyBlock <matProps>k__BackingField;        // 0x50
        private UnityEngine.Rendering.ShadowCastingMode <shadowCastingMode>k__BackingField;        // 0x58
        private System.Boolean <receiveShadows>k__BackingField;        // 0x5C
        private UnityEngine.Rendering.LightProbeUsage <lightProbeUsage>k__BackingField;        // 0x60
        private UnityEngine.LightProbeProxyVolume <lightProbeProxyVolume>k__BackingField;        // 0x68

        // Methods
        private UnityEngine.Material get_material() { }

    }

    // TypeToken: 0x20000CF
    public struct RenderInstancedDataLayout
    {
        // Fields
        private readonly System.Int32 <size>k__BackingField;        // 0x10
        private readonly System.Int32 <offsetObjectToWorld>k__BackingField;        // 0x14
        private readonly System.Int32 <offsetPrevObjectToWorld>k__BackingField;        // 0x18
        private readonly System.Int32 <offsetRenderingLayerMask>k__BackingField;        // 0x1C

        // Methods
        private System.Void .ctor(System.Type t) { }

    }

    // TypeToken: 0x20000D0
    public struct Internal_DrawTextureArguments
    {
        // Fields
        public UnityEngine.Rect screenRect;        // 0x10
        public UnityEngine.Rect sourceRect;        // 0x20
        public System.Int32 leftBorder;        // 0x30
        public System.Int32 rightBorder;        // 0x34
        public System.Int32 topBorder;        // 0x38
        public System.Int32 bottomBorder;        // 0x3C
        public UnityEngine.Color leftBorderColor;        // 0x40
        public UnityEngine.Color rightBorderColor;        // 0x50
        public UnityEngine.Color topBorderColor;        // 0x60
        public UnityEngine.Color bottomBorderColor;        // 0x70
        public UnityEngine.Color color;        // 0x80
        public UnityEngine.Vector4 borderWidths;        // 0x90
        public UnityEngine.Vector4 cornerRadiuses;        // 0xA0
        public System.Boolean smoothCorners;        // 0xB0
        public System.Int32 pass;        // 0xB4
        public UnityEngine.Texture texture;        // 0xB8
        public UnityEngine.Material mat;        // 0xC0

    }

    // TypeToken: 0x20000D1
    public class QualitySettings
    {
        // Methods
        private System.Void IncreaseLevel(System.Boolean applyExpensiveChanges) { }
        private System.Void DecreaseLevel(System.Boolean applyExpensiveChanges) { }
        private System.Void SetQualityLevel(System.Int32 index) { }
        private System.Void IncreaseLevel() { }
        private System.Void DecreaseLevel() { }
        private UnityEngine.QualityLevel get_currentLevel() { }
        private System.Void set_currentLevel(UnityEngine.QualityLevel value) { }
        private System.Void .ctor() { }
        private System.Int32 get_pixelLightCount() { }
        private System.Void set_pixelLightCount(System.Int32 value) { }
        private UnityEngine.ShadowQuality get_shadows() { }
        private System.Void set_shadows(UnityEngine.ShadowQuality value) { }
        private UnityEngine.ShadowProjection get_shadowProjection() { }
        private System.Void set_shadowProjection(UnityEngine.ShadowProjection value) { }
        private System.Int32 get_shadowCascades() { }
        private System.Void set_shadowCascades(System.Int32 value) { }
        private System.Single get_shadowDistance() { }
        private System.Void set_shadowDistance(System.Single value) { }
        private UnityEngine.ShadowResolution get_shadowResolution() { }
        private System.Void set_shadowResolution(UnityEngine.ShadowResolution value) { }
        private UnityEngine.ShadowmaskMode get_shadowmaskMode() { }
        private System.Void set_shadowmaskMode(UnityEngine.ShadowmaskMode value) { }
        private System.Single get_shadowNearPlaneOffset() { }
        private System.Void set_shadowNearPlaneOffset(System.Single value) { }
        private System.Single get_shadowCascade2Split() { }
        private System.Void set_shadowCascade2Split(System.Single value) { }
        private UnityEngine.Vector3 get_shadowCascade4Split() { }
        private System.Void set_shadowCascade4Split(UnityEngine.Vector3 value) { }
        private System.Single get_lodBias() { }
        private System.Void set_lodBias(System.Single value) { }
        private System.Int32 get_lodOffset() { }
        private System.Void set_lodOffset(System.Int32 value) { }
        private UnityEngine.AnisotropicFiltering get_anisotropicFiltering() { }
        private System.Void set_anisotropicFiltering(UnityEngine.AnisotropicFiltering value) { }
        private System.Int32 get_masterTextureLimit() { }
        private System.Void set_masterTextureLimit(System.Int32 value) { }
        private System.Int32 get_maximumLODLevel() { }
        private System.Void set_maximumLODLevel(System.Int32 value) { }
        private System.Int32 get_particleRaycastBudget() { }
        private System.Void set_particleRaycastBudget(System.Int32 value) { }
        private System.Boolean get_softParticles() { }
        private System.Void set_softParticles(System.Boolean value) { }
        private System.Boolean get_softVegetation() { }
        private System.Void set_softVegetation(System.Boolean value) { }
        private System.Int32 get_vSyncCount() { }
        private System.Void set_vSyncCount(System.Int32 value) { }
        private System.Boolean get_allowTearing() { }
        private System.Void set_allowTearing(System.Boolean value) { }
        private System.Int32 get_realtimeGICPUUsage() { }
        private System.Void set_realtimeGICPUUsage(System.Int32 value) { }
        private System.Int32 get_antiAliasing() { }
        private System.Void set_antiAliasing(System.Int32 value) { }
        private System.Int32 get_asyncUploadTimeSlice() { }
        private System.Void set_asyncUploadTimeSlice(System.Int32 value) { }
        private System.Int32 get_asyncUploadBufferSize() { }
        private System.Void set_asyncUploadBufferSize(System.Int32 value) { }
        private System.Boolean get_asyncUploadPersistentBuffer() { }
        private System.Void set_asyncUploadPersistentBuffer(System.Boolean value) { }
        private System.Void SetLODSettings(System.Single lodBias, System.Int32 maximumLODLevel, System.Boolean setDirty) { }
        private System.Void SetLODSettings(System.Single lodBias, System.Int32 lodOffset, System.Int32 maximumLODLevel, System.Boolean setDirty) { }
        private System.Boolean get_realtimeReflectionProbes() { }
        private System.Void set_realtimeReflectionProbes(System.Boolean value) { }
        private System.Boolean get_billboardsFaceCameraPosition() { }
        private System.Void set_billboardsFaceCameraPosition(System.Boolean value) { }
        private System.Single get_resolutionScalingFixedDPIFactor() { }
        private System.Void set_resolutionScalingFixedDPIFactor(System.Single value) { }
        private UnityEngine.ScriptableObject get_INTERNAL_renderPipeline() { }
        private System.Void set_INTERNAL_renderPipeline(UnityEngine.ScriptableObject value) { }
        private UnityEngine.Rendering.RenderPipelineAsset get_renderPipeline() { }
        private System.Void set_renderPipeline(UnityEngine.Rendering.RenderPipelineAsset value) { }
        private UnityEngine.ScriptableObject InternalGetRenderPipelineAssetAt(System.Int32 index) { }
        private UnityEngine.Rendering.RenderPipelineAsset GetRenderPipelineAssetAt(System.Int32 index) { }
        private UnityEngine.BlendWeights get_blendWeights() { }
        private System.Void set_blendWeights(UnityEngine.BlendWeights value) { }
        private UnityEngine.SkinWeights get_skinWeights() { }
        private System.Void set_skinWeights(UnityEngine.SkinWeights value) { }
        private System.Boolean get_streamingMipmapsActive() { }
        private System.Void set_streamingMipmapsActive(System.Boolean value) { }
        private System.Single get_streamingMipmapsMemoryBudget() { }
        private System.Void set_streamingMipmapsMemoryBudget(System.Single value) { }
        private System.Int32 get_streamingMipmapsRenderersPerFrame() { }
        private System.Void set_streamingMipmapsRenderersPerFrame(System.Int32 value) { }
        private System.Int32 get_streamingMipmapsMaxLevelReduction() { }
        private System.Void set_streamingMipmapsMaxLevelReduction(System.Int32 value) { }
        private System.Boolean get_streamingMipmapsAddAllCameras() { }
        private System.Void set_streamingMipmapsAddAllCameras(System.Boolean value) { }
        private System.Int32 get_streamingMipmapsMaxFileIORequests() { }
        private System.Void set_streamingMipmapsMaxFileIORequests(System.Int32 value) { }
        private System.Int32 get_maxQueuedFrames() { }
        private System.Void set_maxQueuedFrames(System.Int32 value) { }
        private System.Int32 GetQualityLevel() { }
        private UnityEngine.Object GetQualitySettings() { }
        private System.Void SetQualityLevel(System.Int32 index, System.Boolean applyExpensiveChanges) { }
        private System.String[] get_names() { }
        private UnityEngine.ColorSpace get_desiredColorSpace() { }
        private UnityEngine.ColorSpace get_activeColorSpace() { }
        private System.Void get_shadowCascade4Split_Injected(UnityEngine.Vector3& ret) { }
        private System.Void set_shadowCascade4Split_Injected(UnityEngine.Vector3& value) { }

    }

    // TypeToken: 0x20000D2
    public class TrailRenderer : Renderer
    {
        // Methods
        private System.Single get_time() { }
        private System.Void set_time(System.Single value) { }
        private System.Single get_startWidth() { }
        private System.Void set_startWidth(System.Single value) { }
        private System.Single get_endWidth() { }
        private System.Void set_endWidth(System.Single value) { }

    }

    // TypeToken: 0x20000D3
    public class LineRenderer : Renderer
    {
        // Methods
        private System.Void SetWidth(System.Single start, System.Single end) { }
        private System.Void SetColors(UnityEngine.Color start, UnityEngine.Color end) { }
        private System.Void SetVertexCount(System.Int32 count) { }
        private System.Int32 get_numPositions() { }
        private System.Void set_numPositions(System.Int32 value) { }
        private System.Single get_startWidth() { }
        private System.Void set_startWidth(System.Single value) { }
        private System.Single get_endWidth() { }
        private System.Void set_endWidth(System.Single value) { }
        private System.Single get_widthMultiplier() { }
        private System.Void set_widthMultiplier(System.Single value) { }
        private System.Int32 get_numCornerVertices() { }
        private System.Void set_numCornerVertices(System.Int32 value) { }
        private System.Int32 get_numCapVertices() { }
        private System.Void set_numCapVertices(System.Int32 value) { }
        private System.Boolean get_useWorldSpace() { }
        private System.Void set_useWorldSpace(System.Boolean value) { }
        private System.Boolean get_loop() { }
        private System.Void set_loop(System.Boolean value) { }
        private UnityEngine.Color get_startColor() { }
        private System.Void set_startColor(UnityEngine.Color value) { }
        private UnityEngine.Color get_endColor() { }
        private System.Void set_endColor(UnityEngine.Color value) { }
        private System.Int32 get_positionCount() { }
        private System.Void set_positionCount(System.Int32 value) { }
        private System.Void SetPosition(System.Int32 index, UnityEngine.Vector3 position) { }
        private UnityEngine.Vector3 GetPosition(System.Int32 index) { }
        private System.Single get_shadowBias() { }
        private System.Void set_shadowBias(System.Single value) { }
        private System.Boolean get_generateLightingData() { }
        private System.Void set_generateLightingData(System.Boolean value) { }
        private UnityEngine.LineTextureMode get_textureMode() { }
        private System.Void set_textureMode(UnityEngine.LineTextureMode value) { }
        private UnityEngine.LineAlignment get_alignment() { }
        private System.Void set_alignment(UnityEngine.LineAlignment value) { }
        private System.Void Simplify(System.Single tolerance) { }
        private System.Void BakeMesh(UnityEngine.Mesh mesh, System.Boolean useTransform) { }
        private System.Void BakeMesh(UnityEngine.Mesh mesh, UnityEngine.Camera camera, System.Boolean useTransform) { }
        private UnityEngine.AnimationCurve get_widthCurve() { }
        private System.Void set_widthCurve(UnityEngine.AnimationCurve value) { }
        private UnityEngine.Gradient get_colorGradient() { }
        private System.Void set_colorGradient(UnityEngine.Gradient value) { }
        private UnityEngine.AnimationCurve GetWidthCurveCopy() { }
        private System.Void SetWidthCurve(UnityEngine.AnimationCurve curve) { }
        private UnityEngine.Gradient GetColorGradientCopy() { }
        private System.Void SetColorGradient(UnityEngine.Gradient curve) { }
        private System.Int32 GetPositions(UnityEngine.Vector3[] positions) { }
        private System.Void SetPositions(UnityEngine.Vector3[] positions) { }
        private System.Void SetPositions(Unity.Collections.NativeArray<UnityEngine.Vector3> positions) { }
        private System.Void SetPositions(Unity.Collections.NativeSlice<UnityEngine.Vector3> positions) { }
        private System.Int32 GetPositions(Unity.Collections.NativeArray<UnityEngine.Vector3> positions) { }
        private System.Int32 GetPositions(Unity.Collections.NativeSlice<UnityEngine.Vector3> positions) { }
        private System.Void SetPositionsWithNativeContainer(System.IntPtr positions, System.Int32 count) { }
        private System.Int32 GetPositionsWithNativeContainer(System.IntPtr positions, System.Int32 length) { }
        private System.Void .ctor() { }
        private System.Void get_startColor_Injected(UnityEngine.Color& ret) { }
        private System.Void set_startColor_Injected(UnityEngine.Color& value) { }
        private System.Void get_endColor_Injected(UnityEngine.Color& ret) { }
        private System.Void set_endColor_Injected(UnityEngine.Color& value) { }
        private System.Void SetPosition_Injected(System.Int32 index, UnityEngine.Vector3& position) { }
        private System.Void GetPosition_Injected(System.Int32 index, UnityEngine.Vector3& ret) { }

    }

    // TypeToken: 0x20000D4
    public class MaterialPropertyBlock
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10

        // Methods
        private UnityEngine.Vector4 GetVectorImpl(System.Int32 name) { }
        private System.Void SetFloatImpl(System.Int32 name, System.Single value) { }
        private System.Void SetVectorImpl(System.Int32 name, UnityEngine.Vector4 value) { }
        private System.Void SetColorImpl(System.Int32 name, UnityEngine.Color value) { }
        private System.Void SetMatrixImpl(System.Int32 name, UnityEngine.Matrix4x4 value) { }
        private System.Void SetTextureImpl(System.Int32 name, UnityEngine.Texture value) { }
        private System.Void HGSetTextureImpl(System.Int32 name, UnityEngine.Texture value) { }
        private System.Void SetBufferImpl(System.Int32 name, UnityEngine.ComputeBuffer value, System.Int32 offset, System.Int32 size) { }
        private System.Void SetConstantBufferImpl(System.Int32 name, UnityEngine.ComputeBuffer value, System.Int32 offset, System.Int32 size) { }
        private System.Void SetConstantBufferImpl0(System.Int32 name, System.UInt32 bufferId, System.Int32 offset, System.Int32 size) { }
        private System.Void SetFloatArrayImpl(System.Int32 name, System.Single[] values, System.Int32 count) { }
        private System.Void SetVectorArrayImpl(System.Int32 name, UnityEngine.Vector4[] values, System.Int32 count) { }
        private System.Void SetNativeArrayImpl(System.Int32 name, System.Int32 type, System.UIntPtr values, System.Int32 count) { }
        private System.IntPtr CreateImpl() { }
        private System.Void DestroyImpl(System.IntPtr mpb) { }
        private System.Void Clear(System.Boolean keepMemory) { }
        private System.Void Clear() { }
        private System.Void CopyFrom(UnityEngine.MaterialPropertyBlock properties) { }
        private System.Void SetFloatArray(System.Int32 name, System.Single[] values, System.Int32 count) { }
        private System.Void SetVectorArray(System.Int32 name, UnityEngine.Vector4[] values, System.Int32 count) { }
        private System.Void SetFloatArray(System.Int32 name, Unity.Collections.NativeArray<System.Single> values, System.Int32 count) { }
        private System.Void SetVectorArray(System.Int32 name, Unity.Collections.NativeArray<UnityEngine.Vector4> values, System.Int32 count) { }
        private System.Void .ctor() { }
        private System.Void Finalize() { }
        private System.IntPtr GetNativePtr() { }
        private System.Void Dispose() { }
        private System.Void SetInt(System.String name, System.Int32 value) { }
        private System.Void SetInt(System.Int32 nameID, System.Int32 value) { }
        private System.Void SetFloat(System.String name, System.Single value) { }
        private System.Void SetFloat(System.Int32 nameID, System.Single value) { }
        private System.Void SetVector(System.String name, UnityEngine.Vector4 value) { }
        private System.Void SetVector(System.Int32 nameID, UnityEngine.Vector4 value) { }
        private System.Void SetColor(System.String name, UnityEngine.Color value) { }
        private System.Void SetColor(System.Int32 nameID, UnityEngine.Color value) { }
        private System.Void SetMatrix(System.Int32 nameID, UnityEngine.Matrix4x4 value) { }
        private System.Void SetBuffer(System.String name, UnityEngine.ComputeBuffer value, System.Int32 offset, System.Int32 size) { }
        private System.Void SetBuffer(System.Int32 nameID, UnityEngine.ComputeBuffer value, System.Int32 offset, System.Int32 size) { }
        private System.Void SetTexture(System.String name, UnityEngine.Texture value) { }
        private System.Void SetTexture(System.Int32 nameID, UnityEngine.Texture value) { }
        private System.Void HGSetTexture(System.String name, UnityEngine.Texture value) { }
        private System.Void HGSetTexture(System.Int32 nameID, UnityEngine.Texture value) { }
        private System.Void SetConstantBuffer(System.Int32 nameID, UnityEngine.ComputeBuffer value, System.Int32 offset, System.Int32 size) { }
        private System.Void SetConstantBuffer(System.String name, System.UInt32 bufferId, System.Int32 offset, System.Int32 size) { }
        private System.Void SetConstantBuffer(System.Int32 nameID, System.UInt32 bufferId, System.Int32 offset, System.Int32 size) { }
        private System.Void SetFloatArray(System.String name, System.Single[] values) { }
        private System.Void SetFloatArray(System.Int32 nameID, Unity.Collections.NativeArray<System.Single> values) { }
        private System.Void SetVectorArray(System.String name, UnityEngine.Vector4[] values) { }
        private System.Void SetVectorArray(System.Int32 nameID, UnityEngine.Vector4[] values) { }
        private System.Void SetVectorArray(System.Int32 nameID, Unity.Collections.NativeArray<UnityEngine.Vector4> values) { }
        private UnityEngine.Vector4 GetVector(System.Int32 nameID) { }
        private System.Void GetVectorImpl_Injected(System.Int32 name, UnityEngine.Vector4& ret) { }
        private System.Void SetVectorImpl_Injected(System.Int32 name, UnityEngine.Vector4& value) { }
        private System.Void SetColorImpl_Injected(System.Int32 name, UnityEngine.Color& value) { }
        private System.Void SetMatrixImpl_Injected(System.Int32 name, UnityEngine.Matrix4x4& value) { }

    }

    // TypeToken: 0x20000D5
    public class Renderer : Component
    {
        // Methods
        private System.Boolean get_castShadows() { }
        private System.Void set_castShadows(System.Boolean value) { }
        private System.Boolean get_motionVectors() { }
        private System.Void set_motionVectors(System.Boolean value) { }
        private System.Boolean get_useLightProbes() { }
        private System.Void set_useLightProbes(System.Boolean value) { }
        private UnityEngine.Bounds get_bounds() { }
        private System.Void set_bounds(UnityEngine.Bounds value) { }
        private UnityEngine.Bounds get_localBounds() { }
        private System.Void set_localBounds(UnityEngine.Bounds value) { }
        private System.Void ResetBounds() { }
        private System.Void ResetLocalBounds() { }
        private System.Void SetStaticLightmapST(UnityEngine.Vector4 st) { }
        private UnityEngine.Material GetInstantiatedMaterial() { }
        private UnityEngine.Material[] GetInstantiatedMaterialArray() { }
        private UnityEngine.Material GetAndAssignInstantiatedMaterial() { }
        private UnityEngine.Material GetSharedMaterial() { }
        private System.Void SetMaterial(UnityEngine.Material m) { }
        private UnityEngine.Material[] GetMaterialArray() { }
        private System.Void CopyAndAssignInstantiatedMaterialArray(UnityEngine.Material[] m) { }
        private System.Void CopyInstantiatedMaterialArray(UnityEngine.Material[] m) { }
        private System.Void CopySharedMaterialArray(UnityEngine.Material[] m) { }
        private System.Void SetMaterialArray(UnityEngine.Material[] m) { }
        private System.Void Internal_SetPropertyBlock(UnityEngine.MaterialPropertyBlock properties) { }
        private System.Void Internal_GetPropertyBlock(UnityEngine.MaterialPropertyBlock dest) { }
        private System.Void Internal_SetPropertyBlockMaterialIndex(UnityEngine.MaterialPropertyBlock properties, System.Int32 materialIndex) { }
        private System.Void Internal_GetPropertyBlockMaterialIndex(UnityEngine.MaterialPropertyBlock dest, System.Int32 materialIndex) { }
        private System.Boolean HasPropertyBlock() { }
        private System.Void SetPropertyBlock(UnityEngine.MaterialPropertyBlock properties) { }
        private System.Void SetPropertyBlock(UnityEngine.MaterialPropertyBlock properties, System.Int32 materialIndex) { }
        private System.Void GetPropertyBlock(UnityEngine.MaterialPropertyBlock properties) { }
        private System.Void GetPropertyBlock(UnityEngine.MaterialPropertyBlock properties, System.Int32 materialIndex) { }
        private System.Void GetClosestReflectionProbesInternal(System.Object result) { }
        private System.Void GetClosestReflectionProbesInternal2(UnityEngine.Bounds& aabb, UnityEngine.Transform anchor, UnityEngine.Rendering.ReflectionProbeUsage usage, System.Object result) { }
        private UnityEngine.ReflectionProbe GetReflectionProbeBySerializedIdentifier(System.Int64 identifier) { }
        private System.Void GetAllReflectionProbesInternal(System.Object result) { }
        private System.Void GetAllProbeTextureIndicesInternal(System.Int32[] result) { }
        private UnityEngine.Texture GetReflectionProbeArrayInternal() { }
        private System.Void set_lightingAnchor(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_lightingAnchor() { }
        private System.Boolean get_enablePerRendererLighting() { }
        private System.Void set_enablePerRendererLighting(System.Boolean value) { }
        private System.Boolean get_enabled() { }
        private System.Void set_enabled(System.Boolean value) { }
        private System.Boolean get_isVisible() { }
        private UnityEngine.Rendering.ShadowCastingMode get_shadowCastingMode() { }
        private System.Void set_shadowCastingMode(UnityEngine.Rendering.ShadowCastingMode value) { }
        private System.Boolean get_receiveShadows() { }
        private System.Void set_receiveShadows(System.Boolean value) { }
        private System.Boolean get_forceRenderingOff() { }
        private System.Void set_forceRenderingOff(System.Boolean value) { }
        private System.Boolean GetIsStaticShadowCaster() { }
        private System.Void SetIsStaticShadowCaster(System.Boolean value) { }
        private System.Boolean get_staticShadowCaster() { }
        private System.Void set_staticShadowCaster(System.Boolean value) { }
        private System.Boolean GetIsRealtimeShadowCaster() { }
        private System.Void SetIsRealtimeShadowCaster(System.Boolean value) { }
        private System.Boolean get_realtimeShadowCaster() { }
        private System.Void set_realtimeShadowCaster(System.Boolean value) { }
        private System.Boolean GetRenderFoliageOccluder() { }
        private System.Void SetRenderFoliageOccluder(System.Boolean value) { }
        private System.Boolean get_renderFoliageOccluder() { }
        private System.Void set_renderFoliageOccluder(System.Boolean value) { }
        private System.UInt16 get_characterIndex() { }
        private System.Void set_characterIndex(System.UInt16 value) { }
        private UnityEngine.Rendering.SubMeshRenderMode get_subMeshRenderMode() { }
        private System.Void set_subMeshRenderMode(UnityEngine.Rendering.SubMeshRenderMode value) { }
        private UnityEngine.Mesh get_shadowProxyMesh() { }
        private System.Void set_shadowProxyMesh(UnityEngine.Mesh value) { }
        private UnityEngine.MotionVectorGenerationMode get_motionVectorGenerationMode() { }
        private System.Void set_motionVectorGenerationMode(UnityEngine.MotionVectorGenerationMode value) { }
        private UnityEngine.Rendering.LightProbeUsage get_lightProbeUsage() { }
        private System.Void set_lightProbeUsage(UnityEngine.Rendering.LightProbeUsage value) { }
        private UnityEngine.Rendering.ReflectionProbeUsage get_reflectionProbeUsage() { }
        private System.Void set_reflectionProbeUsage(UnityEngine.Rendering.ReflectionProbeUsage value) { }
        private System.UInt32 get_renderingLayerMask() { }
        private System.Void set_renderingLayerMask(System.UInt32 value) { }
        private System.Int32 get_rendererPriority() { }
        private System.Void set_rendererPriority(System.Int32 value) { }
        private UnityEngine.Experimental.Rendering.RayTracingMode get_rayTracingMode() { }
        private System.Void set_rayTracingMode(UnityEngine.Experimental.Rendering.RayTracingMode value) { }
        private System.String get_sortingLayerName() { }
        private System.Void set_sortingLayerName(System.String value) { }
        private System.Int32 get_sortingLayerID() { }
        private System.Void set_sortingLayerID(System.Int32 value) { }
        private System.Int32 get_sortingOrder() { }
        private System.Void set_sortingOrder(System.Int32 value) { }
        private System.Int32 get_sortingGroupID() { }
        private System.Void set_sortingGroupID(System.Int32 value) { }
        private System.Int32 get_sortingGroupOrder() { }
        private System.Void set_sortingGroupOrder(System.Int32 value) { }
        private System.Single get_sortingFudge() { }
        private System.Void set_sortingFudge(System.Single value) { }
        private System.Boolean get_useCustomLODFadeValue() { }
        private System.Void set_useCustomLODFadeValue(System.Boolean value) { }
        private System.Single get_customLODFadeValue() { }
        private System.Void set_customLODFadeValue(System.Single value) { }
        private System.Boolean get_allowOcclusionWhenDynamic() { }
        private System.Void set_allowOcclusionWhenDynamic(System.Boolean value) { }
        private UnityEngine.Transform get_staticBatchRootTransform() { }
        private System.Void set_staticBatchRootTransform(UnityEngine.Transform value) { }
        private System.Int32 get_staticBatchIndex() { }
        private System.Void SetStaticBatchInfo(System.Int32 firstSubMesh, System.Int32 subMeshCount) { }
        private System.Boolean get_isPartOfStaticBatch() { }
        private UnityEngine.Matrix4x4 get_worldToLocalMatrix() { }
        private UnityEngine.Matrix4x4 get_localToWorldMatrix() { }
        private UnityEngine.GameObject get_lightProbeProxyVolumeOverride() { }
        private System.Void set_lightProbeProxyVolumeOverride(UnityEngine.GameObject value) { }
        private UnityEngine.Transform get_probeAnchor() { }
        private System.Void set_probeAnchor(UnityEngine.Transform value) { }
        private UnityEngine.LODGroup get_LODGroup() { }
        private System.Int32 GetLightmapIndex(UnityEngineInternal.LightmapType lt) { }
        private System.Void SetLightmapIndex(System.Int32 index, UnityEngineInternal.LightmapType lt) { }
        private UnityEngine.Vector4 GetLightmapST(UnityEngineInternal.LightmapType lt) { }
        private System.Void SetLightmapST(UnityEngine.Vector4 st, UnityEngineInternal.LightmapType lt) { }
        private System.Int32 get_lightmapIndex() { }
        private System.Void set_lightmapIndex(System.Int32 value) { }
        private System.Int32 get_realtimeLightmapIndex() { }
        private System.Void set_realtimeLightmapIndex(System.Int32 value) { }
        private UnityEngine.Vector4 get_lightmapScaleOffset() { }
        private System.Void set_lightmapScaleOffset(UnityEngine.Vector4 value) { }
        private UnityEngine.Vector4 get_realtimeLightmapScaleOffset() { }
        private System.Void set_realtimeLightmapScaleOffset(UnityEngine.Vector4 value) { }
        private System.Int32 GetMaterialCount() { }
        private UnityEngine.Material[] GetSharedMaterialArray() { }
        private UnityEngine.Material[] get_materials() { }
        private System.Void set_materials(UnityEngine.Material[] value) { }
        private UnityEngine.Material get_material() { }
        private System.Void set_material(UnityEngine.Material value) { }
        private UnityEngine.Material get_sharedMaterial() { }
        private System.Void set_sharedMaterial(UnityEngine.Material value) { }
        private UnityEngine.Material[] get_sharedMaterials() { }
        private System.Void set_sharedMaterials(UnityEngine.Material[] value) { }
        private System.Void GetMaterials(System.Collections.Generic.List<UnityEngine.Material> m) { }
        private System.Void GetInstantiatedMaterials(System.Collections.Generic.List<UnityEngine.Material> m) { }
        private System.Void GetSharedMaterials(System.Collections.Generic.List<UnityEngine.Material> m) { }
        private System.Void GetClosestReflectionProbes(System.Collections.Generic.List<UnityEngine.Rendering.ReflectionProbeBlendInfo> result) { }
        private System.Void GetClosestReflectionProbes(UnityEngine.Bounds& aabb, UnityEngine.Transform anchor, UnityEngine.Rendering.ReflectionProbeUsage usage, System.Collections.Generic.List<UnityEngine.Rendering.ReflectionProbeBlendInfo> result) { }
        private System.Void GetAllReflectionProbes(System.Collections.Generic.List<UnityEngine.Rendering.ReflectionProbeBlendInfo> result) { }
        private System.Void GetAllProbeTextureIndices(System.Int32[] result) { }
        private UnityEngine.Texture GetReflectionProbeArray() { }
        private System.Void SetCustomPerDrawData(System.Int32 index, UnityEngine.Vector4 param) { }
        private UnityEngine.Vector4 GetCustomPerDrawData(System.Int32 index) { }
        private UnityEngine.Vector4* GetCustomPerDrawDataPtr() { }
        private System.Void set_enableManualDither(System.Boolean value) { }
        private System.Void set_enableCameraDither(System.Boolean value) { }
        private System.Void set_manualDitherAlphaValue(System.Single value) { }
        private System.Void set_cameraDitherAlphaValue(System.Single value) { }
        private System.Void set_enableCharacterOutline(System.Boolean value) { }
        private System.Boolean get_enableCharacterOutline() { }
        private UnityEngine.Vector3 get_perRendererLightingOffset() { }
        private System.Void set_perRendererLightingOffset(UnityEngine.Vector3 value) { }
        private System.Void SetPlatformSpecificCastShadowsInternal(System.IntPtr value) { }
        private System.IntPtr GetPlatformSpecificCastShadowsInternal() { }
        private System.Void SetPlatformSpecificCastShadows(UnityEngine.PlatformSpecificParam<System.UInt32> value) { }
        private UnityEngine.PlatformSpecificParam<System.UInt32> GetPlatformSpecificCastShadows() { }
        private System.Void .ctor() { }
        private System.Void get_bounds_Injected(UnityEngine.Bounds& ret) { }
        private System.Void set_bounds_Injected(UnityEngine.Bounds& value) { }
        private System.Void get_localBounds_Injected(UnityEngine.Bounds& ret) { }
        private System.Void set_localBounds_Injected(UnityEngine.Bounds& value) { }
        private System.Void SetStaticLightmapST_Injected(UnityEngine.Vector4& st) { }
        private System.Void get_worldToLocalMatrix_Injected(UnityEngine.Matrix4x4& ret) { }
        private System.Void get_localToWorldMatrix_Injected(UnityEngine.Matrix4x4& ret) { }
        private System.Void GetLightmapST_Injected(UnityEngineInternal.LightmapType lt, UnityEngine.Vector4& ret) { }
        private System.Void SetLightmapST_Injected(UnityEngine.Vector4& st, UnityEngineInternal.LightmapType lt) { }
        private System.Void SetCustomPerDrawData_Injected(System.Int32 index, UnityEngine.Vector4& param) { }
        private System.Void GetCustomPerDrawData_Injected(System.Int32 index, UnityEngine.Vector4& ret) { }
        private System.Void get_perRendererLightingOffset_Injected(UnityEngine.Vector3& ret) { }
        private System.Void set_perRendererLightingOffset_Injected(UnityEngine.Vector3& value) { }

    }

    // TypeToken: 0x20000D6
    public class RenderSettings
    {
        // Methods
        private System.Single get_fogStartDistance() { }
        private System.Void set_fogStartDistance(System.Single value) { }
        private System.Single get_fogEndDistance() { }
        private System.Void set_fogEndDistance(System.Single value) { }
        private UnityEngine.Color get_fogColor() { }
        private System.Void set_fogColor(UnityEngine.Color value) { }
        private System.Single get_fogDensity() { }
        private System.Void set_fogDensity(System.Single value) { }
        private System.Void set_ambientMode(UnityEngine.Rendering.AmbientMode value) { }
        private System.Single get_ambientIntensity() { }
        private System.Void set_ambientIntensity(System.Single value) { }
        private UnityEngine.Color get_ambientLight() { }
        private System.Void set_ambientLight(UnityEngine.Color value) { }
        private System.Void set_skybox(UnityEngine.Material value) { }
        private System.Void set_sun(UnityEngine.Light value) { }
        private UnityEngine.Rendering.SphericalHarmonicsL2 get_ambientProbe() { }
        private System.Void set_ambientProbe(UnityEngine.Rendering.SphericalHarmonicsL2 value) { }
        private System.Void set_defaultReflectionMode(UnityEngine.Rendering.DefaultReflectionMode value) { }
        private System.Void get_fogColor_Injected(UnityEngine.Color& ret) { }
        private System.Void set_fogColor_Injected(UnityEngine.Color& value) { }
        private System.Void get_ambientLight_Injected(UnityEngine.Color& ret) { }
        private System.Void set_ambientLight_Injected(UnityEngine.Color& value) { }
        private System.Void get_ambientProbe_Injected(UnityEngine.Rendering.SphericalHarmonicsL2& ret) { }
        private System.Void set_ambientProbe_Injected(UnityEngine.Rendering.SphericalHarmonicsL2& value) { }

    }

    // TypeToken: 0x20000D7
    public class Shader
    {
        // Fields
        private static System.Action<System.String> onCompileShader;        // 0x0
        private static System.Action<System.String,System.String,System.String,System.String> onKeywordNotBestMatch;        // 0x8
        private static System.Action<System.String,System.Single,System.Int32,System.Boolean> onRenderPipelineUpload;        // 0x10

        // Methods
        private UnityEngine.Shader Find(System.String name) { }
        private System.Int32 get_globalMaximumLOD() { }
        private System.Void set_globalMaximumLOD(System.Int32 value) { }
        private System.Boolean get_isSupported() { }
        private System.Void set_globalRenderPipeline(System.String value) { }
        private UnityEngine.Rendering.LocalKeywordSpace get_keywordSpace() { }
        private System.Void EnableKeyword(System.String keyword) { }
        private System.Void DisableKeyword(System.String keyword) { }
        private System.Int32 TagToID(System.String name) { }
        private System.Int32 PropertyToID(System.String name) { }
        private System.Void SetGlobalFloatImpl(System.Int32 name, System.Single value) { }
        private System.Void SetGlobalMatrixImpl(System.Int32 name, UnityEngine.Matrix4x4 value) { }
        private System.Void SetGlobalTextureImpl(System.Int32 name, UnityEngine.Texture value) { }
        private System.Void SetGlobalConstantBufferImpl(System.Int32 name, UnityEngine.ComputeBuffer value, System.Int32 offset, System.Int32 size) { }
        private System.Void set_forceSubShaderReload(System.Boolean value) { }
        private System.Void InvokeOnCompileShader(System.String url) { }
        private System.Void InvokeOnKeywordNotBestMatch(System.String shaderName, System.String passInfo, System.String requestKeyword, System.String foundKeyword) { }
        private System.Void InvokeOnRenderPipelineUpload(System.String infoJson, System.Single time, System.Int32 codeSize, System.Boolean isMissing) { }
        private System.Void SetGlobalInt(System.Int32 nameID, System.Int32 value) { }
        private System.Void SetGlobalFloat(System.Int32 nameID, System.Single value) { }
        private System.Void SetGlobalMatrix(System.String name, UnityEngine.Matrix4x4 value) { }
        private System.Void SetGlobalTexture(System.Int32 nameID, UnityEngine.Texture value) { }
        private System.Void SetGlobalConstantBuffer(System.Int32 nameID, UnityEngine.ComputeBuffer value, System.Int32 offset, System.Int32 size) { }
        private System.Void .ctor() { }
        private System.Void get_keywordSpace_Injected(UnityEngine.Rendering.LocalKeywordSpace& ret) { }
        private System.Void SetGlobalMatrixImpl_Injected(System.Int32 name, UnityEngine.Matrix4x4& value) { }

    }

    // TypeToken: 0x20000D8
    public class Material
    {
        // Methods
        private System.IntPtr HGGetPtrUnchecked() { }
        private System.Void CreateWithShader(UnityEngine.Material self, UnityEngine.Shader shader) { }
        private System.Void CreateWithMaterial(UnityEngine.Material self, UnityEngine.Material source) { }
        private System.Void CreateWithString(UnityEngine.Material self) { }
        private System.Void .ctor(UnityEngine.Shader shader) { }
        private System.Void .ctor(UnityEngine.Material source) { }
        private System.Void .ctor(System.String contents) { }
        private UnityEngine.Shader get_shader() { }
        private System.Void set_shader(UnityEngine.Shader value) { }
        private UnityEngine.Color get_color() { }
        private System.Void set_color(UnityEngine.Color value) { }
        private UnityEngine.Texture get_mainTexture() { }
        private System.Void set_mainTexture(UnityEngine.Texture value) { }
        private UnityEngine.Vector2 get_mainTextureOffset() { }
        private System.Void set_mainTextureOffset(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 get_mainTextureScale() { }
        private System.Void set_mainTextureScale(UnityEngine.Vector2 value) { }
        private System.Int32 GetFirstPropertyNameIdByAttribute(UnityEngine.Rendering.ShaderPropertyFlags attributeFlag) { }
        private System.Boolean HasProperty(System.Int32 nameID) { }
        private System.Boolean HasProperty(System.String name) { }
        private System.Boolean HasFloatImpl(System.Int32 name) { }
        private System.Boolean HasFloat(System.String name) { }
        private System.Boolean HasFloat(System.Int32 nameID) { }
        private System.Boolean HasInt(System.String name) { }
        private System.Boolean HasVectorImpl(System.Int32 name) { }
        private System.Boolean HasColor(System.String name) { }
        private System.Int32 get_renderQueue() { }
        private System.Void set_renderQueue(System.Int32 value) { }
        private System.Void EnableKeyword(System.String keyword) { }
        private System.Void DisableKeyword(System.String keyword) { }
        private System.Boolean IsKeywordEnabled(System.String keyword) { }
        private System.Void EnableLocalKeyword(UnityEngine.Rendering.LocalKeyword keyword) { }
        private System.Void DisableLocalKeyword(UnityEngine.Rendering.LocalKeyword keyword) { }
        private System.Void SetLocalKeyword(UnityEngine.Rendering.LocalKeyword keyword, System.Boolean value) { }
        private System.Void EnableKeyword(UnityEngine.Rendering.LocalKeyword& keyword) { }
        private System.Void DisableKeyword(UnityEngine.Rendering.LocalKeyword& keyword) { }
        private System.Void SetKeyword(UnityEngine.Rendering.LocalKeyword& keyword, System.Boolean value) { }
        private System.Void SetEnabledKeywords(UnityEngine.Rendering.LocalKeyword[] keywords) { }
        private System.Void set_enabledKeywords(UnityEngine.Rendering.LocalKeyword[] value) { }
        private System.Void set_globalIlluminationFlags(UnityEngine.MaterialGlobalIlluminationFlags value) { }
        private System.Boolean get_enableInstancing() { }
        private System.Void set_enableInstancing(System.Boolean value) { }
        private System.Int32 get_passCount() { }
        private System.Void SetShaderPassEnabled(System.String passName, System.Boolean enabled) { }
        private System.Boolean GetShaderPassEnabledAndExisted(System.String passName) { }
        private System.Int32 FindPass(System.String passName) { }
        private System.Void SetOverrideTag(System.String tag, System.String val) { }
        private System.String GetTagImpl(System.String tag, System.Boolean currentSubShaderOnly, System.String defaultValue) { }
        private System.String GetTag(System.String tag, System.Boolean searchFallbacks) { }
        private System.Boolean SetPass(System.Int32 pass) { }
        private System.Void CopyPropertiesFromMaterial(UnityEngine.Material mat) { }
        private System.String[] GetShaderKeywords() { }
        private System.Void SetShaderKeywords(System.String[] names) { }
        private System.String[] get_shaderKeywords() { }
        private System.Void set_shaderKeywords(System.String[] value) { }
        private System.Int32 ComputeCRC() { }
        private System.Void GetTexturePropertyNamesInternal(System.Object outNames) { }
        private System.Void GetTexturePropertyNames(System.Collections.Generic.List<System.String> outNames) { }
        private System.Void SetIntImpl(System.Int32 name, System.Int32 value) { }
        private System.Void SetFloatImpl(System.Int32 name, System.Single value) { }
        private System.Void SetColorImpl(System.Int32 name, UnityEngine.Color value) { }
        private System.Void SetMatrixImpl(System.Int32 name, UnityEngine.Matrix4x4 value) { }
        private System.Void SetTextureImpl(System.Int32 name, UnityEngine.Texture value) { }
        private System.Void SetConstantBufferImpl(System.Int32 name, UnityEngine.ComputeBuffer value, System.Int32 offset, System.Int32 size) { }
        private System.Void SetConstantBufferImpl0(System.Int32 name, System.UInt32 bufferId, System.Int32 offset, System.Int32 size) { }
        private System.Int32 GetIntImpl(System.Int32 name) { }
        private System.Single GetFloatImpl(System.Int32 name) { }
        private UnityEngine.Color GetColorImpl(System.Int32 name) { }
        private UnityEngine.Matrix4x4 GetMatrixImpl(System.Int32 name) { }
        private UnityEngine.Texture GetTextureImpl(System.Int32 name) { }
        private System.Void SetMatrixArrayImpl(System.Int32 name, UnityEngine.Matrix4x4[] values, System.Int32 count) { }
        private UnityEngine.Vector4 GetTextureScaleAndOffsetImpl(System.Int32 name) { }
        private System.Void SetTextureOffsetImpl(System.Int32 name, UnityEngine.Vector2 offset) { }
        private System.Void SetTextureScaleImpl(System.Int32 name, UnityEngine.Vector2 scale) { }
        private UnityEngine.HGSubsurfaceProfile get_subsurfaceProfile() { }
        private System.Void SetMatrixArray(System.Int32 name, UnityEngine.Matrix4x4[] values, System.Int32 count) { }
        private System.Void SetInt(System.String name, System.Int32 value) { }
        private System.Void SetInt(System.Int32 nameID, System.Int32 value) { }
        private System.Void SetFloat(System.String name, System.Single value) { }
        private System.Void SetFloat(System.Int32 nameID, System.Single value) { }
        private System.Void SetInteger(System.String name, System.Int32 value) { }
        private System.Void SetColor(System.String name, UnityEngine.Color value) { }
        private System.Void SetColor(System.Int32 nameID, UnityEngine.Color value) { }
        private System.Void SetVector(System.String name, UnityEngine.Vector4 value) { }
        private System.Void SetVector(System.Int32 nameID, UnityEngine.Vector4 value) { }
        private System.Void SetMatrix(System.String name, UnityEngine.Matrix4x4 value) { }
        private System.Void SetMatrix(System.Int32 nameID, UnityEngine.Matrix4x4 value) { }
        private System.Void SetTexture(System.String name, UnityEngine.Texture value) { }
        private System.Void SetTexture(System.Int32 nameID, UnityEngine.Texture value) { }
        private System.Void SetConstantBuffer(System.Int32 nameID, UnityEngine.ComputeBuffer value, System.Int32 offset, System.Int32 size) { }
        private System.Void SetConstantBuffer(System.Int32 nameID, System.UInt32 bufferId, System.Int32 offset, System.Int32 size) { }
        private System.Void SetMatrixArray(System.String name, System.Collections.Generic.List<UnityEngine.Matrix4x4> values) { }
        private System.Int32 GetInt(System.String name) { }
        private System.Int32 GetInt(System.Int32 nameID) { }
        private System.Single GetFloat(System.String name) { }
        private System.Single GetFloat(System.Int32 nameID) { }
        private System.Int32 GetInteger(System.String name) { }
        private UnityEngine.Color GetColor(System.String name) { }
        private UnityEngine.Color GetColor(System.Int32 nameID) { }
        private UnityEngine.Vector4 GetVector(System.String name) { }
        private UnityEngine.Vector4 GetVector(System.Int32 nameID) { }
        private UnityEngine.Matrix4x4 GetMatrix(System.Int32 nameID) { }
        private UnityEngine.Texture GetTexture(System.String name) { }
        private UnityEngine.Texture GetTexture(System.Int32 nameID) { }
        private System.Void SetTextureOffset(System.String name, UnityEngine.Vector2 value) { }
        private System.Void SetTextureOffset(System.Int32 nameID, UnityEngine.Vector2 value) { }
        private System.Void SetTextureScale(System.String name, UnityEngine.Vector2 value) { }
        private System.Void SetTextureScale(System.Int32 nameID, UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 GetTextureOffset(System.String name) { }
        private UnityEngine.Vector2 GetTextureOffset(System.Int32 nameID) { }
        private UnityEngine.Vector2 GetTextureScale(System.String name) { }
        private UnityEngine.Vector2 GetTextureScale(System.Int32 nameID) { }
        private System.Void EnableLocalKeyword_Injected(UnityEngine.Rendering.LocalKeyword& keyword) { }
        private System.Void DisableLocalKeyword_Injected(UnityEngine.Rendering.LocalKeyword& keyword) { }
        private System.Void SetLocalKeyword_Injected(UnityEngine.Rendering.LocalKeyword& keyword, System.Boolean value) { }
        private System.Void SetColorImpl_Injected(System.Int32 name, UnityEngine.Color& value) { }
        private System.Void SetMatrixImpl_Injected(System.Int32 name, UnityEngine.Matrix4x4& value) { }
        private System.Void GetColorImpl_Injected(System.Int32 name, UnityEngine.Color& ret) { }
        private System.Void GetMatrixImpl_Injected(System.Int32 name, UnityEngine.Matrix4x4& ret) { }
        private System.Void GetTextureScaleAndOffsetImpl_Injected(System.Int32 name, UnityEngine.Vector4& ret) { }
        private System.Void SetTextureOffsetImpl_Injected(System.Int32 name, UnityEngine.Vector2& offset) { }
        private System.Void SetTextureScaleImpl_Injected(System.Int32 name, UnityEngine.Vector2& scale) { }

    }

    // TypeToken: 0x20000D9
    public class GraphicsBuffer, IDisposable
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10

        // Methods
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Boolean RequiresCompute(UnityEngine.GraphicsBuffer.Target target) { }
        private System.Boolean IsVertexIndexOrCopyOnly(UnityEngine.GraphicsBuffer.Target target) { }
        private System.IntPtr InitBuffer(UnityEngine.GraphicsBuffer.Target target, System.Int32 count, System.Int32 stride) { }
        private System.Void DestroyBuffer(UnityEngine.GraphicsBuffer buf) { }
        private System.Void .ctor(UnityEngine.GraphicsBuffer.Target target, System.Int32 count, System.Int32 stride) { }
        private System.Void Release() { }
        private System.Int32 get_count() { }
        private System.Int32 get_stride() { }
        private UnityEngine.GraphicsBuffer.Target get_target() { }
        private System.Void SetData(System.Array data) { }
        private System.Void SetData(Unity.Collections.NativeArray<T> data) { }
        private System.Void InternalSetNativeData(System.IntPtr data, System.Int32 nativeBufferStartIndex, System.Int32 graphicsBufferStartIndex, System.Int32 count, System.Int32 elemSize) { }
        private System.Void InternalSetData(System.Array data, System.Int32 managedBufferStartIndex, System.Int32 graphicsBufferStartIndex, System.Int32 count, System.Int32 elemSize) { }

    }

    // TypeToken: 0x20000DB
    public class Flare
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void Internal_Create(UnityEngine.Flare self) { }

    }

    // TypeToken: 0x20000DC
    public struct LightBakingOutput
    {
        // Fields
        public System.Int32 probeOcclusionLightIndex;        // 0x10
        public System.Int32 occlusionMaskChannel;        // 0x14
        public UnityEngine.LightmapBakeType lightmapBakeType;        // 0x18
        public UnityEngine.MixedLightingMode mixedLightingMode;        // 0x1C
        public System.Boolean isBaked;        // 0x20

    }

    // TypeToken: 0x20000DD
    public struct LightShadowCasterMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.LightShadowCasterMode Default;        // 0x0
        public static UnityEngine.LightShadowCasterMode NonLightmappedOnly;        // 0x0
        public static UnityEngine.LightShadowCasterMode Everything;        // 0x0

    }

    // TypeToken: 0x20000DE
    public class Light : Behaviour
    {
        // Fields
        private System.Int32 m_BakedIndex;        // 0x18

        // Methods
        private UnityEngine.LightType get_type() { }
        private System.Void set_type(UnityEngine.LightType value) { }
        private UnityEngine.LightShape get_shape() { }
        private System.Void set_shape(UnityEngine.LightShape value) { }
        private System.Single get_spotAngle() { }
        private System.Void set_spotAngle(System.Single value) { }
        private System.Single get_innerSpotAngle() { }
        private System.Void set_innerSpotAngle(System.Single value) { }
        private UnityEngine.Color get_color() { }
        private System.Void set_color(UnityEngine.Color value) { }
        private System.Single get_colorTemperature() { }
        private System.Void set_colorTemperature(System.Single value) { }
        private System.Boolean get_useColorTemperature() { }
        private System.Void set_useColorTemperature(System.Boolean value) { }
        private System.Boolean get_isSunSourceLight() { }
        private System.Void set_isSunSourceLight(System.Boolean value) { }
        private System.Boolean get_shadowOnly() { }
        private System.Void set_shadowOnly(System.Boolean value) { }
        private System.Boolean get_enableOBBCullingBox() { }
        private System.Void set_enableOBBCullingBox(System.Boolean value) { }
        private System.Boolean get_obbCullingBoxMode() { }
        private System.Void set_obbCullingBoxMode(System.Boolean value) { }
        private UnityEngine.Vector3 get_cullingBoxRelativePosition() { }
        private System.Void set_cullingBoxRelativePosition(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_cullingBoxHalfExtents() { }
        private System.Void set_cullingBoxHalfExtents(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_cullingBoxOrientation() { }
        private System.Void set_cullingBoxOrientation(UnityEngine.Vector3 value) { }
        private System.Single get_cullingBoxFalloffThreshold() { }
        private System.Void set_cullingBoxFalloffThreshold(System.Single value) { }
        private System.Single get_length() { }
        private System.Void set_length(System.Single value) { }
        private System.Single get_intensity() { }
        private System.Void set_intensity(System.Single value) { }
        private System.Single get_specularIntensity() { }
        private System.Void set_specularIntensity(System.Single value) { }
        private System.Single get_softSourceRadius() { }
        private System.Void set_softSourceRadius(System.Single value) { }
        private System.Single get_bounceIntensity() { }
        private System.Void set_bounceIntensity(System.Single value) { }
        private System.Boolean get_useBoundingSphereOverride() { }
        private System.Void set_useBoundingSphereOverride(System.Boolean value) { }
        private UnityEngine.Vector4 get_boundingSphereOverride() { }
        private System.Void set_boundingSphereOverride(UnityEngine.Vector4 value) { }
        private System.Boolean get_useViewFrustumForShadowCasterCull() { }
        private System.Void set_useViewFrustumForShadowCasterCull(System.Boolean value) { }
        private System.Int32 get_shadowCustomResolution() { }
        private System.Void set_shadowCustomResolution(System.Int32 value) { }
        private System.Single get_shadowBias() { }
        private System.Void set_shadowBias(System.Single value) { }
        private System.Single get_shadowNormalBias() { }
        private System.Void set_shadowNormalBias(System.Single value) { }
        private System.Single get_shadowNearPlane() { }
        private System.Void set_shadowNearPlane(System.Single value) { }
        private System.Boolean get_useShadowMatrixOverride() { }
        private System.Void set_useShadowMatrixOverride(System.Boolean value) { }
        private UnityEngine.Matrix4x4 get_shadowMatrixOverride() { }
        private System.Void set_shadowMatrixOverride(UnityEngine.Matrix4x4 value) { }
        private System.Single get_shadowFarPlane() { }
        private System.Void set_shadowFarPlane(System.Single value) { }
        private System.Single get_shadowCullDistance() { }
        private System.Void set_shadowCullDistance(System.Single value) { }
        private System.Single get_shadowFadeRatio() { }
        private System.Void set_shadowFadeRatio(System.Single value) { }
        private System.Single get_shadowGuardAngle() { }
        private System.Void set_shadowGuardAngle(System.Single value) { }
        private System.Int32 get_pointLightShadowCasterFaces() { }
        private System.Void set_pointLightShadowCasterFaces(System.Int32 value) { }
        private System.Int32 get_shadowCasterProperties() { }
        private System.Void set_shadowCasterProperties(System.Int32 value) { }
        private System.Boolean get_isRuntimeShadowBaked() { }
        private System.Void set_isRuntimeShadowBaked(System.Boolean value) { }
        private System.Int32 get_lightPriority() { }
        private System.Void set_lightPriority(System.Int32 value) { }
        private System.Single get_range() { }
        private System.Void set_range(System.Single value) { }
        private UnityEngine.Flare get_flare() { }
        private System.Void set_flare(UnityEngine.Flare value) { }
        private UnityEngine.LightBakingOutput get_bakingOutput() { }
        private System.Void set_bakingOutput(UnityEngine.LightBakingOutput value) { }
        private System.Int32 get_cullingMask() { }
        private System.Void set_cullingMask(System.Int32 value) { }
        private System.Int32 get_renderingLayerMask() { }
        private System.Void set_renderingLayerMask(System.Int32 value) { }
        private UnityEngine.LightShadowCasterMode get_lightShadowCasterMode() { }
        private System.Void set_lightShadowCasterMode(UnityEngine.LightShadowCasterMode value) { }
        private System.Boolean get_useCullingDistance() { }
        private System.Void set_useCullingDistance(System.Boolean value) { }
        private System.Single get_cullingDistance() { }
        private System.Void set_cullingDistance(System.Single value) { }
        private System.Single get_falloffDistance() { }
        private System.Void set_falloffDistance(System.Single value) { }
        private System.UInt64 get_entityID() { }
        private System.Boolean get_enableLightAnimation() { }
        private System.Void set_enableLightAnimation(System.Boolean value) { }
        private System.Boolean get_isInTransition() { }
        private System.Int32 get_lightStateEntryIdx() { }
        private System.Void set_lightStateEntryIdx(System.Int32 value) { }
        private System.Void ResetLightAnimation() { }
        private System.Void UpdateAdditionalMeshRendererBindData() { }
        private System.Void SetLightCurState(System.UInt32 stateIdx) { }
        private System.Void CopyLightToState(System.UInt32 stateIdx) { }
        private System.Void AddLightStateTransitionPreset(UnityEngine.LightStateTransition preset) { }
        private System.Void TransitionLightStateTo(System.String dstStateTagName, System.String transitionTagName) { }
        private System.Void Reset() { }
        private UnityEngine.LightShadows get_shadows() { }
        private System.Void set_shadows(UnityEngine.LightShadows value) { }
        private System.Single get_shadowStrength() { }
        private System.Void set_shadowStrength(System.Single value) { }
        private UnityEngine.Rendering.LightShadowResolution get_shadowResolution() { }
        private System.Void set_shadowResolution(UnityEngine.Rendering.LightShadowResolution value) { }
        private System.Single get_shadowSoftness() { }
        private System.Void set_shadowSoftness(System.Single value) { }
        private System.Single get_shadowSoftnessFade() { }
        private System.Void set_shadowSoftnessFade(System.Single value) { }
        private System.Single[] get_layerShadowCullDistances() { }
        private System.Void set_layerShadowCullDistances(System.Single[] value) { }
        private System.Single get_cookieSize() { }
        private System.Void set_cookieSize(System.Single value) { }
        private UnityEngine.Texture get_cookie() { }
        private System.Void set_cookie(UnityEngine.Texture value) { }
        private UnityEngine.LightRenderMode get_renderMode() { }
        private System.Void set_renderMode(UnityEngine.LightRenderMode value) { }
        private System.Int32 get_bakedIndex() { }
        private System.Void set_bakedIndex(System.Int32 value) { }
        private System.Void SetPlatformSpecificLightBakeTypeInternal(System.IntPtr value) { }
        private System.IntPtr GetPlatformSpecificLightBakeTypeInternal() { }
        private System.Void SetPlatformSpecificLightBakeType(UnityEngine.PlatformSpecificParam<UnityEngine.LightmapBakeType> value) { }
        private UnityEngine.PlatformSpecificParam<UnityEngine.LightmapBakeType> GetPlatformSpecificLightBakeType() { }
        private System.Void SetPlatformSpecificShadowTypeInternal(System.IntPtr value) { }
        private System.IntPtr GetPlatformSpecificShadowTypeInternal() { }
        private System.Void SetPlatformSpecificShadowType(UnityEngine.PlatformSpecificParam<System.Int32> value) { }
        private UnityEngine.PlatformSpecificParam<System.Int32> GetPlatformSpecificShadowType() { }
        private System.Void AddCommandBuffer(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer) { }
        private System.Void AddCommandBuffer(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask) { }
        private System.Void AddCommandBufferAsync(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType) { }
        private System.Void AddCommandBufferAsync(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask, UnityEngine.Rendering.ComputeQueueType queueType) { }
        private System.Void RemoveCommandBuffer(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer) { }
        private System.Void RemoveCommandBuffers(UnityEngine.Rendering.LightEvent evt) { }
        private System.Void RemoveAllCommandBuffers() { }
        private UnityEngine.Rendering.CommandBuffer[] GetCommandBuffers(UnityEngine.Rendering.LightEvent evt) { }
        private System.Int32 get_commandBufferCount() { }
        private System.Int32 get_pixelLightCount() { }
        private System.Void set_pixelLightCount(System.Int32 value) { }
        private UnityEngine.Light[] GetLights(UnityEngine.LightType type, System.Int32 layer) { }
        private UnityEngine.Light GetSunSourceLight() { }
        private System.Void set_isDynamicShadowCaster(System.Boolean value) { }
        private System.Boolean get_isDynamicShadowCaster() { }
        private System.Void set_castStaticObjects(System.Boolean value) { }
        private System.Boolean get_castStaticObjects() { }
        private System.Void set_castDynamicObjects(System.Boolean value) { }
        private System.Boolean get_castDynamicObjects() { }
        private System.Void SetPointLightShadowCasterFace(UnityEngine.CubemapFace face, System.Boolean enabled) { }
        private System.Boolean GetPointLightShadowCasterFace(UnityEngine.CubemapFace face) { }
        private System.Boolean IsPointLightHasExactlyOneCaster() { }
        private System.Single get_shadowConstantBias() { }
        private System.Void set_shadowConstantBias(System.Single value) { }
        private System.Single get_shadowObjectSizeBias() { }
        private System.Void set_shadowObjectSizeBias(System.Single value) { }
        private System.Boolean get_attenuate() { }
        private System.Void set_attenuate(System.Boolean value) { }
        private System.Void set_lightAdditionalData(UnityEngine.HGLightAdditionalData value) { }
        private System.Void .ctor() { }
        private System.Void get_color_Injected(UnityEngine.Color& ret) { }
        private System.Void set_color_Injected(UnityEngine.Color& value) { }
        private System.Void get_cullingBoxRelativePosition_Injected(UnityEngine.Vector3& ret) { }
        private System.Void set_cullingBoxRelativePosition_Injected(UnityEngine.Vector3& value) { }
        private System.Void get_cullingBoxHalfExtents_Injected(UnityEngine.Vector3& ret) { }
        private System.Void set_cullingBoxHalfExtents_Injected(UnityEngine.Vector3& value) { }
        private System.Void get_cullingBoxOrientation_Injected(UnityEngine.Vector3& ret) { }
        private System.Void set_cullingBoxOrientation_Injected(UnityEngine.Vector3& value) { }
        private System.Void get_boundingSphereOverride_Injected(UnityEngine.Vector4& ret) { }
        private System.Void set_boundingSphereOverride_Injected(UnityEngine.Vector4& value) { }
        private System.Void get_shadowMatrixOverride_Injected(UnityEngine.Matrix4x4& ret) { }
        private System.Void set_shadowMatrixOverride_Injected(UnityEngine.Matrix4x4& value) { }
        private System.Void get_bakingOutput_Injected(UnityEngine.LightBakingOutput& ret) { }
        private System.Void set_bakingOutput_Injected(UnityEngine.LightBakingOutput& value) { }
        private System.Void AddLightStateTransitionPreset_Injected(UnityEngine.LightStateTransition& preset) { }
        private System.Void set_lightAdditionalData_Injected(UnityEngine.HGLightAdditionalData& value) { }

    }

    // TypeToken: 0x20000DF
    public class MeshFilter : Component
    {
        // Methods
        private System.Void DontStripMeshFilter() { }
        private UnityEngine.Mesh get_sharedMesh() { }
        private System.Void set_sharedMesh(UnityEngine.Mesh value) { }

    }

    // TypeToken: 0x20000E0
    public struct RenderingPath
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.RenderingPath UsePlayerSettings;        // 0x0
        public static UnityEngine.RenderingPath VertexLit;        // 0x0
        public static UnityEngine.RenderingPath Forward;        // 0x0
        public static UnityEngine.RenderingPath DeferredLighting;        // 0x0
        public static UnityEngine.RenderingPath DeferredShading;        // 0x0

    }

    // TypeToken: 0x20000E1
    public struct TransparencySortMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TransparencySortMode Default;        // 0x0
        public static UnityEngine.TransparencySortMode Perspective;        // 0x0
        public static UnityEngine.TransparencySortMode Orthographic;        // 0x0
        public static UnityEngine.TransparencySortMode CustomAxis;        // 0x0

    }

    // TypeToken: 0x20000E2
    public struct StereoTargetEyeMask
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.StereoTargetEyeMask None;        // 0x0
        public static UnityEngine.StereoTargetEyeMask Left;        // 0x0
        public static UnityEngine.StereoTargetEyeMask Right;        // 0x0
        public static UnityEngine.StereoTargetEyeMask Both;        // 0x0

    }

    // TypeToken: 0x20000E3
    public struct CameraType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.CameraType Game;        // 0x0
        public static UnityEngine.CameraType SceneView;        // 0x0
        public static UnityEngine.CameraType Preview;        // 0x0
        public static UnityEngine.CameraType VR;        // 0x0
        public static UnityEngine.CameraType Reflection;        // 0x0
        public static UnityEngine.CameraType Shadow;        // 0x0
        public static UnityEngine.CameraType VTPage;        // 0x0
        public static UnityEngine.CameraType RayTracing;        // 0x0
        public static UnityEngine.CameraType Unknown;        // 0x0

    }

    // TypeToken: 0x20000E4
    public struct ComputeBufferType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.ComputeBufferType Default;        // 0x0
        public static UnityEngine.ComputeBufferType Raw;        // 0x0
        public static UnityEngine.ComputeBufferType Append;        // 0x0
        public static UnityEngine.ComputeBufferType Counter;        // 0x0
        public static UnityEngine.ComputeBufferType Constant;        // 0x0
        public static UnityEngine.ComputeBufferType Structured;        // 0x0
        public static UnityEngine.ComputeBufferType DrawIndirect;        // 0x0
        public static UnityEngine.ComputeBufferType IndirectArguments;        // 0x0
        public static UnityEngine.ComputeBufferType GPUMemory;        // 0x0

    }

    // TypeToken: 0x20000E5
    public struct LightType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.LightType Spot;        // 0x0
        public static UnityEngine.LightType Directional;        // 0x0
        public static UnityEngine.LightType Point;        // 0x0
        public static UnityEngine.LightType Area;        // 0x0
        public static UnityEngine.LightType Rectangle;        // 0x0
        public static UnityEngine.LightType Disc;        // 0x0

    }

    // TypeToken: 0x20000E6
    public struct LightShape
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.LightShape Cone;        // 0x0
        public static UnityEngine.LightShape Pyramid;        // 0x0
        public static UnityEngine.LightShape Box;        // 0x0

    }

    // TypeToken: 0x20000E7
    public struct LightRenderMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.LightRenderMode Auto;        // 0x0
        public static UnityEngine.LightRenderMode ForcePixel;        // 0x0
        public static UnityEngine.LightRenderMode ForceVertex;        // 0x0

    }

    // TypeToken: 0x20000E8
    public struct LightShadows
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.LightShadows None;        // 0x0
        public static UnityEngine.LightShadows Hard;        // 0x0
        public static UnityEngine.LightShadows Soft;        // 0x0

    }

    // TypeToken: 0x20000E9
    public struct LightmapBakeType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.LightmapBakeType Realtime;        // 0x0
        public static UnityEngine.LightmapBakeType Baked;        // 0x0
        public static UnityEngine.LightmapBakeType Mixed;        // 0x0

    }

    // TypeToken: 0x20000EA
    public struct MixedLightingMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.MixedLightingMode IndirectOnly;        // 0x0
        public static UnityEngine.MixedLightingMode Shadowmask;        // 0x0
        public static UnityEngine.MixedLightingMode Subtractive;        // 0x0

    }

    // TypeToken: 0x20000EB
    public struct QualityLevel
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.QualityLevel Fastest;        // 0x0
        public static UnityEngine.QualityLevel Fast;        // 0x0
        public static UnityEngine.QualityLevel Simple;        // 0x0
        public static UnityEngine.QualityLevel Good;        // 0x0
        public static UnityEngine.QualityLevel Beautiful;        // 0x0
        public static UnityEngine.QualityLevel Fantastic;        // 0x0

    }

    // TypeToken: 0x20000EC
    public struct ShadowProjection
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.ShadowProjection CloseFit;        // 0x0
        public static UnityEngine.ShadowProjection StableFit;        // 0x0

    }

    // TypeToken: 0x20000ED
    public struct ShadowQuality
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.ShadowQuality Disable;        // 0x0
        public static UnityEngine.ShadowQuality HardOnly;        // 0x0
        public static UnityEngine.ShadowQuality All;        // 0x0

    }

    // TypeToken: 0x20000EE
    public struct ShadowResolution
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.ShadowResolution Low;        // 0x0
        public static UnityEngine.ShadowResolution Medium;        // 0x0
        public static UnityEngine.ShadowResolution High;        // 0x0
        public static UnityEngine.ShadowResolution VeryHigh;        // 0x0

    }

    // TypeToken: 0x20000EF
    public struct ShadowmaskMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.ShadowmaskMode Shadowmask;        // 0x0
        public static UnityEngine.ShadowmaskMode DistanceShadowmask;        // 0x0

    }

    // TypeToken: 0x20000F0
    public struct ShadowObjectsFilter
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.ShadowObjectsFilter AllObjects;        // 0x0
        public static UnityEngine.ShadowObjectsFilter DynamicOnly;        // 0x0
        public static UnityEngine.ShadowObjectsFilter StaticOnly;        // 0x0

    }

    // TypeToken: 0x20000F1
    public struct CameraClearFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.CameraClearFlags Skybox;        // 0x0
        public static UnityEngine.CameraClearFlags Color;        // 0x0
        public static UnityEngine.CameraClearFlags SolidColor;        // 0x0
        public static UnityEngine.CameraClearFlags Depth;        // 0x0
        public static UnityEngine.CameraClearFlags Nothing;        // 0x0

    }

    // TypeToken: 0x20000F2
    public struct DepthTextureMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.DepthTextureMode None;        // 0x0
        public static UnityEngine.DepthTextureMode Depth;        // 0x0
        public static UnityEngine.DepthTextureMode DepthNormals;        // 0x0
        public static UnityEngine.DepthTextureMode MotionVectors;        // 0x0

    }

    // TypeToken: 0x20000F3
    public struct AnisotropicFiltering
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.AnisotropicFiltering Disable;        // 0x0
        public static UnityEngine.AnisotropicFiltering Enable;        // 0x0
        public static UnityEngine.AnisotropicFiltering ForceEnable;        // 0x0

    }

    // TypeToken: 0x20000F4
    public struct BlendWeights
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.BlendWeights OneBone;        // 0x0
        public static UnityEngine.BlendWeights TwoBones;        // 0x0
        public static UnityEngine.BlendWeights FourBones;        // 0x0

    }

    // TypeToken: 0x20000F5
    public struct SkinWeights
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.SkinWeights OneBone;        // 0x0
        public static UnityEngine.SkinWeights TwoBones;        // 0x0
        public static UnityEngine.SkinWeights FourBones;        // 0x0
        public static UnityEngine.SkinWeights Unlimited;        // 0x0

    }

    // TypeToken: 0x20000F6
    public struct MeshTopology
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.MeshTopology Triangles;        // 0x0
        public static UnityEngine.MeshTopology Quads;        // 0x0
        public static UnityEngine.MeshTopology Lines;        // 0x0
        public static UnityEngine.MeshTopology LineStrip;        // 0x0
        public static UnityEngine.MeshTopology Points;        // 0x0

    }

    // TypeToken: 0x20000F7
    public struct SkinQuality
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.SkinQuality Auto;        // 0x0
        public static UnityEngine.SkinQuality Bone1;        // 0x0
        public static UnityEngine.SkinQuality Bone2;        // 0x0
        public static UnityEngine.SkinQuality Bone4;        // 0x0

    }

    // TypeToken: 0x20000F8
    public struct ColorSpace
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.ColorSpace Uninitialized;        // 0x0
        public static UnityEngine.ColorSpace Gamma;        // 0x0
        public static UnityEngine.ColorSpace Linear;        // 0x0

    }

    // TypeToken: 0x20000F9
    public struct ColorGamut
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.ColorGamut sRGB;        // 0x0
        public static UnityEngine.ColorGamut Rec709;        // 0x0
        public static UnityEngine.ColorGamut Rec2020;        // 0x0
        public static UnityEngine.ColorGamut DisplayP3;        // 0x0
        public static UnityEngine.ColorGamut HDR10;        // 0x0
        public static UnityEngine.ColorGamut DolbyHDR;        // 0x0

    }

    // TypeToken: 0x20000FA
    public struct ScreenOrientation
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.ScreenOrientation Unknown;        // 0x0
        public static UnityEngine.ScreenOrientation Landscape;        // 0x0
        public static UnityEngine.ScreenOrientation Portrait;        // 0x0
        public static UnityEngine.ScreenOrientation PortraitUpsideDown;        // 0x0
        public static UnityEngine.ScreenOrientation LandscapeLeft;        // 0x0
        public static UnityEngine.ScreenOrientation LandscapeRight;        // 0x0
        public static UnityEngine.ScreenOrientation AutoRotation;        // 0x0

    }

    // TypeToken: 0x20000FB
    public struct FilterMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.FilterMode Point;        // 0x0
        public static UnityEngine.FilterMode Bilinear;        // 0x0
        public static UnityEngine.FilterMode Trilinear;        // 0x0

    }

    // TypeToken: 0x20000FC
    public struct TextureWrapMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TextureWrapMode Repeat;        // 0x0
        public static UnityEngine.TextureWrapMode Clamp;        // 0x0
        public static UnityEngine.TextureWrapMode Mirror;        // 0x0
        public static UnityEngine.TextureWrapMode MirrorOnce;        // 0x0

    }

    // TypeToken: 0x20000FD
    public struct TextureFormat
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TextureFormat Alpha8;        // 0x0
        public static UnityEngine.TextureFormat ARGB4444;        // 0x0
        public static UnityEngine.TextureFormat RGB24;        // 0x0
        public static UnityEngine.TextureFormat RGBA32;        // 0x0
        public static UnityEngine.TextureFormat ARGB32;        // 0x0
        public static UnityEngine.TextureFormat RGB565;        // 0x0
        public static UnityEngine.TextureFormat R16;        // 0x0
        public static UnityEngine.TextureFormat DXT1;        // 0x0
        public static UnityEngine.TextureFormat DXT5;        // 0x0
        public static UnityEngine.TextureFormat RGBA4444;        // 0x0
        public static UnityEngine.TextureFormat BGRA32;        // 0x0
        public static UnityEngine.TextureFormat RHalf;        // 0x0
        public static UnityEngine.TextureFormat RGHalf;        // 0x0
        public static UnityEngine.TextureFormat RGBAHalf;        // 0x0
        public static UnityEngine.TextureFormat RFloat;        // 0x0
        public static UnityEngine.TextureFormat RGFloat;        // 0x0
        public static UnityEngine.TextureFormat RGBAFloat;        // 0x0
        public static UnityEngine.TextureFormat YUY2;        // 0x0
        public static UnityEngine.TextureFormat RGB9e5Float;        // 0x0
        public static UnityEngine.TextureFormat BC4;        // 0x0
        public static UnityEngine.TextureFormat BC5;        // 0x0
        public static UnityEngine.TextureFormat BC6H;        // 0x0
        public static UnityEngine.TextureFormat BC7;        // 0x0
        public static UnityEngine.TextureFormat DXT1Crunched;        // 0x0
        public static UnityEngine.TextureFormat DXT5Crunched;        // 0x0
        public static UnityEngine.TextureFormat PVRTC_RGB2;        // 0x0
        public static UnityEngine.TextureFormat PVRTC_RGBA2;        // 0x0
        public static UnityEngine.TextureFormat PVRTC_RGB4;        // 0x0
        public static UnityEngine.TextureFormat PVRTC_RGBA4;        // 0x0
        public static UnityEngine.TextureFormat ETC_RGB4;        // 0x0
        public static UnityEngine.TextureFormat EAC_R;        // 0x0
        public static UnityEngine.TextureFormat EAC_R_SIGNED;        // 0x0
        public static UnityEngine.TextureFormat EAC_RG;        // 0x0
        public static UnityEngine.TextureFormat EAC_RG_SIGNED;        // 0x0
        public static UnityEngine.TextureFormat ETC2_RGB;        // 0x0
        public static UnityEngine.TextureFormat ETC2_RGBA1;        // 0x0
        public static UnityEngine.TextureFormat ETC2_RGBA8;        // 0x0
        public static UnityEngine.TextureFormat ASTC_4x4;        // 0x0
        public static UnityEngine.TextureFormat ASTC_5x5;        // 0x0
        public static UnityEngine.TextureFormat ASTC_6x6;        // 0x0
        public static UnityEngine.TextureFormat ASTC_8x8;        // 0x0
        public static UnityEngine.TextureFormat ASTC_10x10;        // 0x0
        public static UnityEngine.TextureFormat ASTC_12x12;        // 0x0
        public static UnityEngine.TextureFormat ETC_RGB4_3DS;        // 0x0
        public static UnityEngine.TextureFormat ETC_RGBA8_3DS;        // 0x0
        public static UnityEngine.TextureFormat RG16;        // 0x0
        public static UnityEngine.TextureFormat R8;        // 0x0
        public static UnityEngine.TextureFormat ETC_RGB4Crunched;        // 0x0
        public static UnityEngine.TextureFormat ETC2_RGBA8Crunched;        // 0x0
        public static UnityEngine.TextureFormat ASTC_HDR_4x4;        // 0x0
        public static UnityEngine.TextureFormat ASTC_HDR_5x5;        // 0x0
        public static UnityEngine.TextureFormat ASTC_HDR_6x6;        // 0x0
        public static UnityEngine.TextureFormat ASTC_HDR_8x8;        // 0x0
        public static UnityEngine.TextureFormat ASTC_HDR_10x10;        // 0x0
        public static UnityEngine.TextureFormat ASTC_HDR_12x12;        // 0x0
        public static UnityEngine.TextureFormat RG32;        // 0x0
        public static UnityEngine.TextureFormat RGB48;        // 0x0
        public static UnityEngine.TextureFormat RGBA64;        // 0x0
        public static UnityEngine.TextureFormat ASTC_RGB_4x4;        // 0x0
        public static UnityEngine.TextureFormat ASTC_RGB_5x5;        // 0x0
        public static UnityEngine.TextureFormat ASTC_RGB_6x6;        // 0x0
        public static UnityEngine.TextureFormat ASTC_RGB_8x8;        // 0x0
        public static UnityEngine.TextureFormat ASTC_RGB_10x10;        // 0x0
        public static UnityEngine.TextureFormat ASTC_RGB_12x12;        // 0x0
        public static UnityEngine.TextureFormat ASTC_RGBA_4x4;        // 0x0
        public static UnityEngine.TextureFormat ASTC_RGBA_5x5;        // 0x0
        public static UnityEngine.TextureFormat ASTC_RGBA_6x6;        // 0x0
        public static UnityEngine.TextureFormat ASTC_RGBA_8x8;        // 0x0
        public static UnityEngine.TextureFormat ASTC_RGBA_10x10;        // 0x0
        public static UnityEngine.TextureFormat ASTC_RGBA_12x12;        // 0x0

    }

    // TypeToken: 0x20000FE
    public struct TextureColorSpace
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TextureColorSpace Linear;        // 0x0
        public static UnityEngine.TextureColorSpace sRGB;        // 0x0

    }

    // TypeToken: 0x20000FF
    public struct CubemapFace
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.CubemapFace Unknown;        // 0x0
        public static UnityEngine.CubemapFace PositiveX;        // 0x0
        public static UnityEngine.CubemapFace NegativeX;        // 0x0
        public static UnityEngine.CubemapFace PositiveY;        // 0x0
        public static UnityEngine.CubemapFace NegativeY;        // 0x0
        public static UnityEngine.CubemapFace PositiveZ;        // 0x0
        public static UnityEngine.CubemapFace NegativeZ;        // 0x0

    }

    // TypeToken: 0x2000100
    public struct RenderTextureFormat
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.RenderTextureFormat ARGB32;        // 0x0
        public static UnityEngine.RenderTextureFormat Depth;        // 0x0
        public static UnityEngine.RenderTextureFormat ARGBHalf;        // 0x0
        public static UnityEngine.RenderTextureFormat Shadowmap;        // 0x0
        public static UnityEngine.RenderTextureFormat RGB565;        // 0x0
        public static UnityEngine.RenderTextureFormat ARGB4444;        // 0x0
        public static UnityEngine.RenderTextureFormat ARGB1555;        // 0x0
        public static UnityEngine.RenderTextureFormat Default;        // 0x0
        public static UnityEngine.RenderTextureFormat ARGB2101010;        // 0x0
        public static UnityEngine.RenderTextureFormat DefaultHDR;        // 0x0
        public static UnityEngine.RenderTextureFormat ARGB64;        // 0x0
        public static UnityEngine.RenderTextureFormat ARGBFloat;        // 0x0
        public static UnityEngine.RenderTextureFormat RGFloat;        // 0x0
        public static UnityEngine.RenderTextureFormat RGHalf;        // 0x0
        public static UnityEngine.RenderTextureFormat RFloat;        // 0x0
        public static UnityEngine.RenderTextureFormat RHalf;        // 0x0
        public static UnityEngine.RenderTextureFormat R8;        // 0x0
        public static UnityEngine.RenderTextureFormat ARGBInt;        // 0x0
        public static UnityEngine.RenderTextureFormat RGInt;        // 0x0
        public static UnityEngine.RenderTextureFormat RInt;        // 0x0
        public static UnityEngine.RenderTextureFormat BGRA32;        // 0x0
        public static UnityEngine.RenderTextureFormat RGB111110Float;        // 0x0
        public static UnityEngine.RenderTextureFormat RG32;        // 0x0
        public static UnityEngine.RenderTextureFormat RGBAUShort;        // 0x0
        public static UnityEngine.RenderTextureFormat RG16;        // 0x0
        public static UnityEngine.RenderTextureFormat BGRA10101010_XR;        // 0x0
        public static UnityEngine.RenderTextureFormat BGR101010_XR;        // 0x0
        public static UnityEngine.RenderTextureFormat R16;        // 0x0

    }

    // TypeToken: 0x2000101
    public struct VRTextureUsage
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.VRTextureUsage None;        // 0x0
        public static UnityEngine.VRTextureUsage OneEye;        // 0x0
        public static UnityEngine.VRTextureUsage TwoEyes;        // 0x0
        public static UnityEngine.VRTextureUsage DeviceSpecific;        // 0x0

    }

    // TypeToken: 0x2000102
    public struct RenderTextureCreationFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.RenderTextureCreationFlags MipMap;        // 0x0
        public static UnityEngine.RenderTextureCreationFlags AutoGenerateMips;        // 0x0
        public static UnityEngine.RenderTextureCreationFlags SRGB;        // 0x0
        public static UnityEngine.RenderTextureCreationFlags EyeTexture;        // 0x0
        public static UnityEngine.RenderTextureCreationFlags EnableRandomWrite;        // 0x0
        public static UnityEngine.RenderTextureCreationFlags CreatedFromScript;        // 0x0
        public static UnityEngine.RenderTextureCreationFlags AllowVerticalFlip;        // 0x0
        public static UnityEngine.RenderTextureCreationFlags NoResolvedColorSurface;        // 0x0
        public static UnityEngine.RenderTextureCreationFlags DynamicallyScalable;        // 0x0
        public static UnityEngine.RenderTextureCreationFlags BindMS;        // 0x0

    }

    // TypeToken: 0x2000103
    public struct RenderTextureReadWrite
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.RenderTextureReadWrite Default;        // 0x0
        public static UnityEngine.RenderTextureReadWrite Linear;        // 0x0
        public static UnityEngine.RenderTextureReadWrite sRGB;        // 0x0

    }

    // TypeToken: 0x2000104
    public struct RenderTextureMemoryless
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.RenderTextureMemoryless None;        // 0x0
        public static UnityEngine.RenderTextureMemoryless Color;        // 0x0
        public static UnityEngine.RenderTextureMemoryless Depth;        // 0x0
        public static UnityEngine.RenderTextureMemoryless MSAA;        // 0x0

    }

    // TypeToken: 0x2000105
    public struct HDRDisplaySupportFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.HDRDisplaySupportFlags None;        // 0x0
        public static UnityEngine.HDRDisplaySupportFlags Supported;        // 0x0
        public static UnityEngine.HDRDisplaySupportFlags RuntimeSwitchable;        // 0x0
        public static UnityEngine.HDRDisplaySupportFlags AutomaticTonemapping;        // 0x0

    }

    // TypeToken: 0x2000106
    public struct LightmapsMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.LightmapsMode NonDirectional;        // 0x0
        public static UnityEngine.LightmapsMode CombinedDirectional;        // 0x0

    }

    // TypeToken: 0x2000107
    public struct MaterialGlobalIlluminationFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.MaterialGlobalIlluminationFlags None;        // 0x0
        public static UnityEngine.MaterialGlobalIlluminationFlags RealtimeEmissive;        // 0x0
        public static UnityEngine.MaterialGlobalIlluminationFlags BakedEmissive;        // 0x0
        public static UnityEngine.MaterialGlobalIlluminationFlags EmissiveIsBlack;        // 0x0
        public static UnityEngine.MaterialGlobalIlluminationFlags AnyEmissive;        // 0x0

    }

    // TypeToken: 0x2000108
    public class LightProbeProxyVolume : Behaviour
    {
    }

    // TypeToken: 0x2000109
    public struct MotionVectorGenerationMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.MotionVectorGenerationMode Camera;        // 0x0
        public static UnityEngine.MotionVectorGenerationMode Object;        // 0x0
        public static UnityEngine.MotionVectorGenerationMode ForceNoMotion;        // 0x0

    }

    // TypeToken: 0x200010A
    public struct LineTextureMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.LineTextureMode Stretch;        // 0x0
        public static UnityEngine.LineTextureMode Tile;        // 0x0
        public static UnityEngine.LineTextureMode DistributePerSegment;        // 0x0
        public static UnityEngine.LineTextureMode RepeatPerSegment;        // 0x0

    }

    // TypeToken: 0x200010B
    public struct LineAlignment
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.LineAlignment View;        // 0x0
        public static UnityEngine.LineAlignment Local;        // 0x0
        public static UnityEngine.LineAlignment TransformZ;        // 0x0

    }

    // TypeToken: 0x200010C
    public struct PipelineCacheLoadResult
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.PipelineCacheLoadResult Unknown;        // 0x0
        public static UnityEngine.PipelineCacheLoadResult Success;        // 0x0
        public static UnityEngine.PipelineCacheLoadResult FailureFileIOError;        // 0x0
        public static UnityEngine.PipelineCacheLoadResult FailureInvalidCacheData;        // 0x0

    }

    // TypeToken: 0x200010D
    public class HGTextureGroupSettings
    {
        // Methods
        private System.Void SetSkippedMipsAt(System.Int32 textureGroupIndex, System.Int32 skippedMips) { }

    }

    // TypeToken: 0x200010E
    public class SkinnedMeshRenderer : Renderer
    {
        // Methods
        private UnityEngine.SkinQuality get_quality() { }
        private System.Void set_quality(UnityEngine.SkinQuality value) { }
        private System.Boolean get_updateWhenOffscreen() { }
        private System.Void set_updateWhenOffscreen(System.Boolean value) { }
        private System.Boolean get_forceMatrixRecalculationPerRender() { }
        private System.Void set_forceMatrixRecalculationPerRender(System.Boolean value) { }
        private UnityEngine.Transform get_rootBone() { }
        private System.Void set_rootBone(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_skinningRoot() { }
        private System.Void set_skinningRoot(UnityEngine.Transform value) { }
        private UnityEngine.Transform[] get_bones() { }
        private System.Void set_bones(UnityEngine.Transform[] value) { }
        private UnityEngine.Mesh get_sharedMesh() { }
        private System.Void set_sharedMesh(UnityEngine.Mesh value) { }
        private System.Boolean get_skinnedMotionVectors() { }
        private System.Void set_skinnedMotionVectors(System.Boolean value) { }
        private System.Single GetBlendShapeWeight(System.Int32 index) { }
        private System.Void SetBlendShapeWeight(System.Int32 index, System.Single value) { }
        private System.Void BakeMesh(UnityEngine.Mesh mesh) { }
        private System.Void BakeMesh(UnityEngine.Mesh mesh, System.Boolean useScale) { }
        private UnityEngine.GraphicsBuffer GetVertexBuffer() { }
        private UnityEngine.GraphicsBuffer GetPreviousVertexBuffer() { }
        private UnityEngine.GraphicsBuffer GetVertexBufferImpl() { }
        private UnityEngine.GraphicsBuffer GetPreviousVertexBufferImpl() { }
        private System.Boolean RequestCurrentFrameSkinMatrices(System.Void* ptr, System.Int32 size) { }
        private System.Boolean SkinMatricesRequestFinished() { }
        private UnityEngine.GraphicsBuffer.Target get_vertexBufferTarget() { }
        private System.Void set_vertexBufferTarget(UnityEngine.GraphicsBuffer.Target value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200010F
    public class MeshRenderer : Renderer
    {
        // Methods
        private System.Void DontStripMeshRenderer() { }
        private System.Int32 get_subMeshStartIndex() { }

    }

    // TypeToken: 0x2000110
    public struct HGLightNPRType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.HGLightNPRType Default;        // 0x0
        public static UnityEngine.HGLightNPRType Ramped;        // 0x0
        public static UnityEngine.HGLightNPRType SpecularOnly;        // 0x0
        public static UnityEngine.HGLightNPRType RimOnly;        // 0x0
        public static UnityEngine.HGLightNPRType FogFade;        // 0x0
        public static UnityEngine.HGLightNPRType IgnoreCharacter;        // 0x0

    }

    // TypeToken: 0x2000111
    public struct HGLightAdditionalData
    {
        // Fields
        public UnityEngine.Vector4 lightNPRData;        // 0x10
        public UnityEngine.HGLightNPRType lightNPRType;        // 0x20
        public System.Boolean LightCharacterOnly;        // 0x24
        public System.Single volumetricScatteringIntensity;        // 0x28
        public System.Single falloffExponent;        // 0x2C

    }

    // TypeToken: 0x2000112
    public struct HGSharedLightData, IEquatable`1
    {
        // Fields
        private System.UInt32 m_Padding1;        // 0x10
        private System.UInt32 m_Padding2;        // 0x14

        // Methods
        private System.Void .ctor(System.UInt32 entityIdx, System.UInt32 entityVersion) { }
        private System.Boolean Equals(UnityEngine.HGSharedLightData rhs) { }
        private System.Boolean Equals(System.Object obj) { }
        private UnityEngine.LightType get_type() { }
        private UnityEngine.Color get_color() { }
        private System.Single get_spotAngle() { }
        private System.Single get_innerSpotAngle() { }
        private System.Boolean get_shadowOnly() { }
        private System.Boolean get_enableOBBCullingBox() { }
        private UnityEngine.Vector3 get_cullingBoxRelativePosition() { }
        private UnityEngine.Vector3 get_cullingBoxHalfExtents() { }
        private UnityEngine.Vector3 get_cullingBoxOrientation() { }
        private System.Single get_cullingBoxFalloffThreshold() { }
        private System.Single get_length() { }
        private System.Single get_intensity() { }
        private System.Single get_specularIntensity() { }
        private System.Single get_shadowBias() { }
        private System.Single get_shadowNormalBias() { }
        private System.Single get_shadowNearPlane() { }
        private System.Single get_range() { }
        private System.Single get_softSourceRadius() { }
        private System.Int32 get_instanceID() { }
        private UnityEngine.LightShadows get_shadows() { }
        private System.Single get_shadowStrength() { }
        private UnityEngine.Matrix4x4 get_localToWorldMatrix() { }
        private System.Single get_shadowFarPlane() { }
        private System.Single get_shadowCullDistance() { }
        private System.Single get_shadowFadeRatio() { }
        private System.Single get_shadowGuardAngle() { }
        private System.Int32 get_pointLightShadowCasterFaces() { }
        private System.Int32 get_shadowCasterProperties() { }
        private System.Boolean get_useCullingDistance() { }
        private System.Single get_cullingDistance() { }
        private System.Single get_falloffDistance() { }
        private UnityEngine.Light get_light() { }
        private System.UInt32 get_entityIndex() { }
        private System.UInt32 get_entityVersion() { }
        private System.Boolean get_isVaild() { }
        private UnityEngine.Vector3 get_worldPosition() { }
        private UnityEngine.HGLightAdditionalData get_lightAdditionalData() { }
        private System.Void set_lightAdditionalData(UnityEngine.HGLightAdditionalData value) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean get_isRuntimeShadowBaked() { }
        private System.Void set_isRuntimeShadowBaked(System.Boolean value) { }
        private System.Boolean get_isDynamicShadowCaster() { }
        private System.Boolean get_castStaticObjects() { }
        private System.Boolean get_castDynamicObjects() { }
        private UnityEngine.Texture get_cookie() { }
        private System.Boolean GetPointLightShadowCasterFace(UnityEngine.CubemapFace face) { }
        private System.Boolean IsPointLightHasExactlyOneCaster() { }
        private System.String GetDebugName() { }
        private System.Single get_flickerScale() { }
        private UnityEngine.LightType get_type_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private System.Void get_color_Injected(UnityEngine.HGSharedLightData& _unity_self, UnityEngine.Color& ret) { }
        private System.Single get_spotAngle_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private System.Single get_innerSpotAngle_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private System.Boolean get_shadowOnly_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private System.Boolean get_enableOBBCullingBox_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private System.Void get_cullingBoxRelativePosition_Injected(UnityEngine.HGSharedLightData& _unity_self, UnityEngine.Vector3& ret) { }
        private System.Void get_cullingBoxHalfExtents_Injected(UnityEngine.HGSharedLightData& _unity_self, UnityEngine.Vector3& ret) { }
        private System.Void get_cullingBoxOrientation_Injected(UnityEngine.HGSharedLightData& _unity_self, UnityEngine.Vector3& ret) { }
        private System.Single get_cullingBoxFalloffThreshold_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private System.Single get_length_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private System.Single get_intensity_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private System.Single get_specularIntensity_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private System.Single get_shadowBias_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private System.Single get_shadowNormalBias_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private System.Single get_shadowNearPlane_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private System.Single get_range_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private System.Single get_softSourceRadius_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private System.Int32 get_instanceID_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private UnityEngine.LightShadows get_shadows_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private System.Single get_shadowStrength_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private System.Void get_localToWorldMatrix_Injected(UnityEngine.HGSharedLightData& _unity_self, UnityEngine.Matrix4x4& ret) { }
        private System.Single get_shadowFarPlane_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private System.Single get_shadowCullDistance_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private System.Single get_shadowFadeRatio_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private System.Single get_shadowGuardAngle_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private System.Int32 get_pointLightShadowCasterFaces_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private System.Int32 get_shadowCasterProperties_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private System.Boolean get_useCullingDistance_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private System.Single get_cullingDistance_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private System.Single get_falloffDistance_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private System.UInt32 get_entityIndex_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private System.UInt32 get_entityVersion_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private System.Boolean get_isVaild_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private System.Void get_worldPosition_Injected(UnityEngine.HGSharedLightData& _unity_self, UnityEngine.Vector3& ret) { }
        private System.Void get_lightAdditionalData_Injected(UnityEngine.HGSharedLightData& _unity_self, UnityEngine.HGLightAdditionalData& ret) { }
        private System.Void set_lightAdditionalData_Injected(UnityEngine.HGSharedLightData& _unity_self, UnityEngine.HGLightAdditionalData& value) { }
        private System.Boolean get_isRuntimeShadowBaked_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private System.Void set_isRuntimeShadowBaked_Injected(UnityEngine.HGSharedLightData& _unity_self, System.Boolean value) { }
        private UnityEngine.Texture get_cookie_Injected(UnityEngine.HGSharedLightData& _unity_self) { }
        private System.Single get_flickerScale_Injected(UnityEngine.HGSharedLightData& _unity_self) { }

    }

    // TypeToken: 0x2000113
    public struct LightStateIntensityTransition
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.LightStateIntensityTransition FadeToBlack;        // 0x0
        public static UnityEngine.LightStateIntensityTransition IntensityBlend;        // 0x0

    }

    // TypeToken: 0x2000114
    public class LightFlickerStyle
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void Internal_Create(UnityEngine.LightFlickerStyle self) { }

    }

    // TypeToken: 0x2000115
    public struct LightFlickerData
    {
        // Fields
        private System.Single flickeringSpeed;        // 0x10
        private System.Single flickerTimeDelay;        // 0x14
        private System.Boolean randomDelay;        // 0x18
        private System.Boolean enableFlicker;        // 0x19

    }

    // TypeToken: 0x2000116
    public struct LightSpinData
    {
        // Fields
        private UnityEngine.Vector3 spinAxis;        // 0x10
        private UnityEngine.Vector3 spinAnchor;        // 0x1C
        private System.Single spinSpeed;        // 0x28
        private System.Single spinTimeDelay;        // 0x2C
        private System.Boolean randomDelay;        // 0x30
        private System.Boolean enableSpin;        // 0x31

    }

    // TypeToken: 0x2000117
    public struct LightAnimatedData
    {
        // Fields
        private UnityEngine.LightFlickerData flickerData;        // 0x10
        private UnityEngine.LightSpinData spinData;        // 0x1C

    }

    // TypeToken: 0x2000118
    public struct LightStateTransitionData
    {
        // Fields
        public UnityEngine.LightStateIntensityTransition IntensityTransition;        // 0x10
        public UnityEngine.LightAnimatedData AnimatedData;        // 0x14

    }

    // TypeToken: 0x2000119
    public class LightStateTransitionPreset
    {
        // Fields
        private UnityEngine.LightStateTransitionData <transitionData>k__BackingField;        // 0x18

        // Methods
        private System.Void set_transitionData(UnityEngine.LightStateTransitionData value) { }
        private UnityEngine.LightStateTransitionData get_transitionData() { }
        private System.Void .ctor() { }
        private System.Void Internal_Create(UnityEngine.LightStateTransitionPreset self) { }

    }

    // TypeToken: 0x200011A
    public struct LightStateTransition
    {
        // Fields
        public System.String tagName;        // 0x10
        public UnityEngine.LightStateTransitionPreset transitionPreset;        // 0x18

    }

    // TypeToken: 0x200011B
    public class LightProbeGroup : Behaviour
    {
        // Methods
        private UnityEngine.Vector3[] get_probePositions() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200011C
    public struct LODFadeMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.LODFadeMode None;        // 0x0
        public static UnityEngine.LODFadeMode CrossFade;        // 0x0
        public static UnityEngine.LODFadeMode SpeedTree;        // 0x0
        public static UnityEngine.LODFadeMode Disabled;        // 0x0

    }

    // TypeToken: 0x200011D
    public struct LOD
    {
        // Fields
        public System.Single screenRelativeTransitionHeight;        // 0x10
        public System.Single fadeTransitionWidth;        // 0x14
        public UnityEngine.Renderer[] renderers;        // 0x18

        // Methods
        private System.Void .ctor(System.Single screenRelativeTransitionHeight, UnityEngine.Renderer[] renderers) { }

    }

    // TypeToken: 0x200011E
    public class LODGroup : Component
    {
        // Methods
        private System.Single get_size() { }
        private System.Void set_size(System.Single value) { }
        private System.Int32 get_lodCount() { }
        private System.Void set_fadeMode(UnityEngine.LODFadeMode value) { }
        private System.Boolean get_animateCrossFading() { }
        private System.Void set_animateCrossFading(System.Boolean value) { }
        private System.Void RecalculateBounds() { }
        private UnityEngine.LOD[] GetLODs(System.Boolean getPlatformLODs) { }
        private System.Void SetLODs(UnityEngine.LOD[] lods) { }
        private System.Void ForceLOD(System.Int32 index) { }
        private System.Boolean CalculateLOD(UnityEngine.Camera camera, System.Int32& lodIndex, System.Single& fadeValue) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200011F
    public class Mesh
    {
        // Methods
        private System.IntPtr HGGetPtrUnchecked() { }
        private System.Void Internal_Create(UnityEngine.Mesh mono) { }
        private System.Void .ctor() { }
        private UnityEngine.Mesh FromInstanceID(System.Int32 id) { }
        private UnityEngine.Rendering.IndexFormat get_indexFormat() { }
        private System.Void set_indexFormat(UnityEngine.Rendering.IndexFormat value) { }
        private System.Int32 GetVertexAttributeCountImpl() { }
        private UnityEngine.Rendering.VertexAttributeDescriptor GetVertexAttribute(System.Int32 index) { }
        private System.UInt32 GetIndexCountImpl(System.Int32 submesh) { }
        private System.UInt32 GetTrianglesCountImpl(System.Int32 submesh) { }
        private System.UInt32 GetBaseVertexImpl(System.Int32 submesh) { }
        private System.Int32[] GetTrianglesImpl(System.Int32 submesh, System.Boolean applyBaseVertex) { }
        private System.Int32[] GetIndicesImpl(System.Int32 submesh, System.Boolean applyBaseVertex) { }
        private System.Void SetIndicesImpl(System.Int32 submesh, UnityEngine.MeshTopology topology, UnityEngine.Rendering.IndexFormat indicesFormat, System.Array indices, System.Int32 arrayStart, System.Int32 arraySize, System.Boolean calculateBounds, System.Int32 baseVertex) { }
        private System.Void GetTrianglesNonAllocImpl(System.Int32[] values, System.Int32 submesh, System.Boolean applyBaseVertex) { }
        private System.Void PrintErrorCantAccessChannel(UnityEngine.Rendering.VertexAttribute ch) { }
        private System.Boolean HasVertexAttribute(UnityEngine.Rendering.VertexAttribute attr) { }
        private System.Void SetArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, System.Int32 dim, System.Array values, System.Int32 arraySize, System.Int32 valuesStart, System.Int32 valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Void SetNativeArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, System.Int32 dim, System.IntPtr values, System.Int32 arraySize, System.Int32 valuesStart, System.Int32 valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Array GetAllocArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, System.Int32 dim) { }
        private System.Void GetArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, System.Int32 dim, System.Array values) { }
        private UnityEngine.GraphicsBuffer GetVertexBufferImpl(System.Int32 index) { }
        private UnityEngine.GraphicsBuffer.Target get_vertexBufferTarget() { }
        private System.Void set_vertexBufferTarget(UnityEngine.GraphicsBuffer.Target value) { }
        private System.Int32 get_blendShapeCount() { }
        private System.String GetBlendShapeName(System.Int32 shapeIndex) { }
        private System.Int32 GetBlendShapeFrameCount(System.Int32 shapeIndex) { }
        private System.Single GetBlendShapeFrameWeight(System.Int32 shapeIndex, System.Int32 frameIndex) { }
        private System.Void GetBlendShapeFrameVertices(System.Int32 shapeIndex, System.Int32 frameIndex, UnityEngine.Vector3[] deltaVertices, UnityEngine.Vector3[] deltaNormals, UnityEngine.Vector3[] deltaTangents) { }
        private System.Void AddBlendShapeFrame(System.String shapeName, System.Single frameWeight, UnityEngine.Vector3[] deltaVertices, UnityEngine.Vector3[] deltaNormals, UnityEngine.Vector3[] deltaTangents) { }
        private System.Boolean HasBoneWeights() { }
        private UnityEngine.BoneWeight[] GetBoneWeightsImpl() { }
        private System.Void SetBoneWeightsImpl(UnityEngine.BoneWeight[] weights) { }
        private System.Void SetBoneWeights(Unity.Collections.NativeArray<System.Byte> bonesPerVertex, Unity.Collections.NativeArray<UnityEngine.BoneWeight1> weights) { }
        private System.Void InternalSetBoneWeights(System.IntPtr bonesPerVertex, System.Int32 bonesPerVertexSize, System.IntPtr weights, System.Int32 weightsSize) { }
        private Unity.Collections.NativeArray<UnityEngine.BoneWeight1> GetAllBoneWeights() { }
        private Unity.Collections.NativeArray<System.Byte> GetBonesPerVertex() { }
        private System.Int32 GetAllBoneWeightsArraySize() { }
        private System.IntPtr GetAllBoneWeightsArray() { }
        private System.IntPtr GetBonesPerVertexArray() { }
        private System.Int32 GetBonesPerVertexValue() { }
        private UnityEngine.Matrix4x4[] get_bindposes() { }
        private System.Void set_bindposes(UnityEngine.Matrix4x4[] value) { }
        private System.Void GetBoneWeightsNonAllocImpl(UnityEngine.BoneWeight[] values) { }
        private System.Boolean get_isReadable() { }
        private System.Boolean get_canAccess() { }
        private System.Int32 get_vertexCount() { }
        private System.Int32 get_subMeshCount() { }
        private System.Void set_subMeshCount(System.Int32 value) { }
        private UnityEngine.Bounds get_bounds() { }
        private System.Void set_bounds(UnityEngine.Bounds value) { }
        private System.Void ClearImpl(System.Boolean keepVertexLayout) { }
        private System.Void RecalculateBoundsImpl(UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Void RecalculateNormalsImpl(UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Void RecalculateTangentsImpl(UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Void MarkDynamicImpl() { }
        private System.Void UploadMeshDataImpl(System.Boolean markNoLongerReadable) { }
        private UnityEngine.MeshTopology GetTopologyImpl(System.Int32 submesh) { }
        private System.Void CombineMeshesImpl(UnityEngine.CombineInstance[] combine, System.Boolean mergeSubMeshes, System.Boolean useMatrices, System.Boolean hasLightmapData) { }
        private System.Void OptimizeImpl() { }
        private UnityEngine.Rendering.VertexAttribute GetUVChannel(System.Int32 uvIndex) { }
        private System.Int32 DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute channel) { }
        private T[] GetAllocArrayFromChannel(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, System.Int32 dim) { }
        private T[] GetAllocArrayFromChannel(UnityEngine.Rendering.VertexAttribute channel) { }
        private System.Void SetSizedArrayForChannel(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, System.Int32 dim, System.Array values, System.Int32 valuesArrayLength, System.Int32 valuesStart, System.Int32 valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Void SetSizedNativeArrayForChannel(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, System.Int32 dim, System.IntPtr values, System.Int32 valuesArrayLength, System.Int32 valuesStart, System.Int32 valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Void SetArrayForChannel(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, System.Int32 dim, T[] values, UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Void SetArrayForChannel(UnityEngine.Rendering.VertexAttribute channel, T[] values, UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Void SetListForChannel(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, System.Int32 dim, System.Collections.Generic.List<T> values, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Void SetListForChannel(UnityEngine.Rendering.VertexAttribute channel, System.Collections.Generic.List<T> values, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Void GetListForChannel(System.Collections.Generic.List<T> buffer, System.Int32 capacity, UnityEngine.Rendering.VertexAttribute channel, System.Int32 dim) { }
        private System.Void GetListForChannel(System.Collections.Generic.List<T> buffer, System.Int32 capacity, UnityEngine.Rendering.VertexAttribute channel, System.Int32 dim, UnityEngine.Rendering.VertexAttributeFormat channelType) { }
        private UnityEngine.Vector3[] get_vertices() { }
        private System.Void set_vertices(UnityEngine.Vector3[] value) { }
        private UnityEngine.Vector3[] get_normals() { }
        private System.Void set_normals(UnityEngine.Vector3[] value) { }
        private UnityEngine.Vector4[] get_tangents() { }
        private System.Void set_tangents(UnityEngine.Vector4[] value) { }
        private UnityEngine.Vector2[] get_uv() { }
        private System.Void set_uv(UnityEngine.Vector2[] value) { }
        private UnityEngine.Vector2[] get_uv2() { }
        private System.Void set_uv2(UnityEngine.Vector2[] value) { }
        private UnityEngine.Vector2[] get_uv3() { }
        private UnityEngine.Vector2[] get_uv4() { }
        private UnityEngine.Vector2[] get_uv5() { }
        private UnityEngine.Vector2[] get_uv6() { }
        private UnityEngine.Vector2[] get_uv7() { }
        private UnityEngine.Vector2[] get_uv8() { }
        private UnityEngine.Color[] get_colors() { }
        private System.Void set_colors(UnityEngine.Color[] value) { }
        private UnityEngine.Color32[] get_colors32() { }
        private System.Void set_colors32(UnityEngine.Color32[] value) { }
        private System.Void GetVertices(System.Collections.Generic.List<UnityEngine.Vector3> vertices) { }
        private System.Void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices) { }
        private System.Void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices, System.Int32 start, System.Int32 length) { }
        private System.Void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Void SetVertices(UnityEngine.Vector3[] inVertices) { }
        private System.Void SetVertices(UnityEngine.Vector3[] inVertices, System.Int32 start, System.Int32 length) { }
        private System.Void SetVertices(UnityEngine.Vector3[] inVertices, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Void SetVertices(Unity.Collections.NativeArray<T> inVertices) { }
        private System.Void SetVertices(Unity.Collections.NativeArray<T> inVertices, System.Int32 start, System.Int32 length) { }
        private System.Void SetVertices(Unity.Collections.NativeArray<T> inVertices, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Void GetNormals(System.Collections.Generic.List<UnityEngine.Vector3> normals) { }
        private System.Void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals) { }
        private System.Void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals, System.Int32 start, System.Int32 length) { }
        private System.Void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Void SetNormals(UnityEngine.Vector3[] inNormals) { }
        private System.Void SetNormals(UnityEngine.Vector3[] inNormals, System.Int32 start, System.Int32 length) { }
        private System.Void SetNormals(UnityEngine.Vector3[] inNormals, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Void SetNormals(Unity.Collections.NativeArray<T> inNormals) { }
        private System.Void SetNormals(Unity.Collections.NativeArray<T> inNormals, System.Int32 start, System.Int32 length) { }
        private System.Void SetNormals(Unity.Collections.NativeArray<T> inNormals, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Void GetTangents(System.Collections.Generic.List<UnityEngine.Vector4> tangents) { }
        private System.Void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents) { }
        private System.Void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents, System.Int32 start, System.Int32 length) { }
        private System.Void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Void SetTangents(Unity.Collections.NativeArray<T> inTangents) { }
        private System.Void SetTangents(Unity.Collections.NativeArray<T> inTangents, System.Int32 start, System.Int32 length) { }
        private System.Void SetTangents(Unity.Collections.NativeArray<T> inTangents, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Void SetColors(System.Collections.Generic.List<UnityEngine.Color> inColors) { }
        private System.Void SetColors(System.Collections.Generic.List<UnityEngine.Color> inColors, System.Int32 start, System.Int32 length) { }
        private System.Void SetColors(System.Collections.Generic.List<UnityEngine.Color> inColors, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Void GetColors(System.Collections.Generic.List<UnityEngine.Color32> colors) { }
        private System.Void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors) { }
        private System.Void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors, System.Int32 start, System.Int32 length) { }
        private System.Void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Void SetUvsImpl(System.Int32 uvIndex, System.Int32 dim, System.Collections.Generic.List<T> uvs, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Void SetUVs(System.Int32 channel, System.Collections.Generic.List<UnityEngine.Vector2> uvs) { }
        private System.Void SetUVs(System.Int32 channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs) { }
        private System.Void SetUVs(System.Int32 channel, System.Collections.Generic.List<UnityEngine.Vector2> uvs, System.Int32 start, System.Int32 length) { }
        private System.Void SetUVs(System.Int32 channel, System.Collections.Generic.List<UnityEngine.Vector2> uvs, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Void SetUVs(System.Int32 channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs, System.Int32 start, System.Int32 length) { }
        private System.Void SetUVs(System.Int32 channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Void SetUvsImpl(System.Int32 uvIndex, System.Int32 dim, System.Array uvs, System.Int32 arrayStart, System.Int32 arraySize, UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Void SetUVs(System.Int32 channel, UnityEngine.Vector2[] uvs) { }
        private System.Void SetUVs(System.Int32 channel, UnityEngine.Vector3[] uvs) { }
        private System.Void SetUVs(System.Int32 channel, UnityEngine.Vector4[] uvs) { }
        private System.Void SetUVs(System.Int32 channel, UnityEngine.Vector2[] uvs, System.Int32 start, System.Int32 length) { }
        private System.Void SetUVs(System.Int32 channel, UnityEngine.Vector2[] uvs, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Void SetUVs(System.Int32 channel, UnityEngine.Vector3[] uvs, System.Int32 start, System.Int32 length) { }
        private System.Void SetUVs(System.Int32 channel, UnityEngine.Vector3[] uvs, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Void SetUVs(System.Int32 channel, UnityEngine.Vector4[] uvs, System.Int32 start, System.Int32 length) { }
        private System.Void SetUVs(System.Int32 channel, UnityEngine.Vector4[] uvs, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Void GetUVsImpl(System.Int32 uvIndex, System.Collections.Generic.List<T> uvs, System.Int32 dim) { }
        private System.Void GetUVs(System.Int32 channel, System.Collections.Generic.List<UnityEngine.Vector3> uvs) { }
        private System.Void GetUVs(System.Int32 channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs) { }
        private System.Int32 get_vertexAttributeCount() { }
        private UnityEngine.Mesh.MeshDataArray AcquireReadOnlyMeshData(UnityEngine.Mesh mesh) { }
        private UnityEngine.GraphicsBuffer GetVertexBuffer(System.Int32 index) { }
        private System.Void PrintErrorCantAccessIndices() { }
        private System.Boolean CheckCanAccessSubmesh(System.Int32 submesh, System.Boolean errorAboutTriangles) { }
        private System.Boolean CheckCanAccessSubmeshTriangles(System.Int32 submesh) { }
        private System.Boolean CheckCanAccessSubmeshIndices(System.Int32 submesh) { }
        private System.Int32[] get_triangles() { }
        private System.Void set_triangles(System.Int32[] value) { }
        private System.Int32[] GetTriangles(System.Int32 submesh) { }
        private System.Int32[] GetTriangles(System.Int32 submesh, System.Boolean applyBaseVertex) { }
        private System.Void GetTriangles(System.Collections.Generic.List<System.Int32> triangles, System.Int32 submesh) { }
        private System.Void GetTriangles(System.Collections.Generic.List<System.Int32> triangles, System.Int32 submesh, System.Boolean applyBaseVertex) { }
        private System.Int32[] GetIndices(System.Int32 submesh) { }
        private System.Int32[] GetIndices(System.Int32 submesh, System.Boolean applyBaseVertex) { }
        private System.UInt32 GetIndexCount(System.Int32 submesh) { }
        private System.UInt32 GetBaseVertex(System.Int32 submesh) { }
        private System.Void CheckIndicesArrayRange(System.Int32 valuesLength, System.Int32 start, System.Int32 length) { }
        private System.Void SetTrianglesImpl(System.Int32 submesh, UnityEngine.Rendering.IndexFormat indicesFormat, System.Array triangles, System.Int32 trianglesArrayLength, System.Int32 start, System.Int32 length, System.Boolean calculateBounds, System.Int32 baseVertex) { }
        private System.Void SetTriangles(System.Int32[] triangles, System.Int32 submesh) { }
        private System.Void SetTriangles(System.Int32[] triangles, System.Int32 submesh, System.Boolean calculateBounds, System.Int32 baseVertex) { }
        private System.Void SetTriangles(System.Int32[] triangles, System.Int32 trianglesStart, System.Int32 trianglesLength, System.Int32 submesh, System.Boolean calculateBounds, System.Int32 baseVertex) { }
        private System.Void SetTriangles(System.Collections.Generic.List<System.Int32> triangles, System.Int32 submesh) { }
        private System.Void SetTriangles(System.Collections.Generic.List<System.Int32> triangles, System.Int32 submesh, System.Boolean calculateBounds, System.Int32 baseVertex) { }
        private System.Void SetTriangles(System.Collections.Generic.List<System.Int32> triangles, System.Int32 trianglesStart, System.Int32 trianglesLength, System.Int32 submesh, System.Boolean calculateBounds, System.Int32 baseVertex) { }
        private System.Void SetIndices(System.Int32[] indices, UnityEngine.MeshTopology topology, System.Int32 submesh) { }
        private System.Void SetIndices(System.Int32[] indices, UnityEngine.MeshTopology topology, System.Int32 submesh, System.Boolean calculateBounds, System.Int32 baseVertex) { }
        private System.Void SetIndices(System.Int32[] indices, System.Int32 indicesStart, System.Int32 indicesLength, UnityEngine.MeshTopology topology, System.Int32 submesh, System.Boolean calculateBounds, System.Int32 baseVertex) { }
        private System.Void SetIndices(System.UInt16[] indices, UnityEngine.MeshTopology topology, System.Int32 submesh, System.Boolean calculateBounds, System.Int32 baseVertex) { }
        private System.Void SetIndices(System.UInt16[] indices, System.Int32 indicesStart, System.Int32 indicesLength, UnityEngine.MeshTopology topology, System.Int32 submesh, System.Boolean calculateBounds, System.Int32 baseVertex) { }
        private System.Void SetIndices(System.Collections.Generic.List<System.Int32> indices, UnityEngine.MeshTopology topology, System.Int32 submesh, System.Boolean calculateBounds, System.Int32 baseVertex) { }
        private System.Void SetIndices(System.Collections.Generic.List<System.Int32> indices, System.Int32 indicesStart, System.Int32 indicesLength, UnityEngine.MeshTopology topology, System.Int32 submesh, System.Boolean calculateBounds, System.Int32 baseVertex) { }
        private System.Void GetBoneWeights(System.Collections.Generic.List<UnityEngine.BoneWeight> boneWeights) { }
        private UnityEngine.BoneWeight[] get_boneWeights() { }
        private System.Void set_boneWeights(UnityEngine.BoneWeight[] value) { }
        private System.Void Clear(System.Boolean keepVertexLayout) { }
        private System.Void Clear() { }
        private System.Void RecalculateBounds() { }
        private System.Void RecalculateNormals() { }
        private System.Void RecalculateTangents() { }
        private System.Void RecalculateBounds(UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Void RecalculateNormals(UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Void RecalculateTangents(UnityEngine.Rendering.MeshUpdateFlags flags) { }
        private System.Void MarkDynamic() { }
        private System.Void UploadMeshData(System.Boolean markNoLongerReadable) { }
        private System.Void Optimize() { }
        private UnityEngine.MeshTopology GetTopology(System.Int32 submesh) { }
        private System.Void CombineMeshes(UnityEngine.CombineInstance[] combine, System.Boolean mergeSubMeshes, System.Boolean useMatrices) { }
        private System.Void GetVertexAttribute_Injected(System.Int32 index, UnityEngine.Rendering.VertexAttributeDescriptor& ret) { }
        private System.Void get_bounds_Injected(UnityEngine.Bounds& ret) { }
        private System.Void set_bounds_Injected(UnityEngine.Bounds& value) { }

    }

    // TypeToken: 0x2000122
    public struct BoneWeight, IEquatable`1
    {
        // Fields
        private System.Single m_Weight0;        // 0x10
        private System.Single m_Weight1;        // 0x14
        private System.Single m_Weight2;        // 0x18
        private System.Single m_Weight3;        // 0x1C
        private System.Int32 m_BoneIndex0;        // 0x20
        private System.Int32 m_BoneIndex1;        // 0x24
        private System.Int32 m_BoneIndex2;        // 0x28
        private System.Int32 m_BoneIndex3;        // 0x2C

        // Methods
        private System.Single get_weight0() { }
        private System.Void set_weight0(System.Single value) { }
        private System.Single get_weight1() { }
        private System.Void set_weight1(System.Single value) { }
        private System.Single get_weight2() { }
        private System.Void set_weight2(System.Single value) { }
        private System.Single get_weight3() { }
        private System.Void set_weight3(System.Single value) { }
        private System.Int32 get_boneIndex0() { }
        private System.Void set_boneIndex0(System.Int32 value) { }
        private System.Int32 get_boneIndex1() { }
        private System.Void set_boneIndex1(System.Int32 value) { }
        private System.Int32 get_boneIndex2() { }
        private System.Void set_boneIndex2(System.Int32 value) { }
        private System.Int32 get_boneIndex3() { }
        private System.Void set_boneIndex3(System.Int32 value) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(UnityEngine.BoneWeight other) { }

    }

    // TypeToken: 0x2000123
    public struct BoneWeight1, IEquatable`1
    {
        // Fields
        private System.Single m_Weight;        // 0x10
        private System.Int32 m_BoneIndex;        // 0x14

        // Methods
        private System.Single get_weight() { }
        private System.Void set_weight(System.Single value) { }
        private System.Int32 get_boneIndex() { }
        private System.Void set_boneIndex(System.Int32 value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(UnityEngine.BoneWeight1 other) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000124
    public struct CombineInstance
    {
        // Fields
        private System.Int32 m_MeshInstanceID;        // 0x10
        private System.Int32 m_SubMeshIndex;        // 0x14
        private UnityEngine.Matrix4x4 m_Transform;        // 0x18
        private UnityEngine.Vector4 m_LightmapScaleOffset;        // 0x58
        private UnityEngine.Vector4 m_RealtimeLightmapScaleOffset;        // 0x68

        // Methods
        private UnityEngine.Mesh get_mesh() { }
        private System.Void set_mesh(UnityEngine.Mesh value) { }
        private System.Void set_subMeshIndex(System.Int32 value) { }
        private System.Void set_transform(UnityEngine.Matrix4x4 value) { }

    }

    // TypeToken: 0x2000125
    public class Texture
    {
        // Fields
        public static readonly System.Int32 GenerateAllMips;        // 0x0

        // Methods
        private System.IntPtr HGGetPtrUnchecked_Texture(System.Int32 instanceID) { }
        private System.IntPtr HGGetPtrUnchecked() { }
        private System.Void .ctor() { }
        private System.Int32 get_masterTextureLimit() { }
        private System.Void set_masterTextureLimit(System.Int32 value) { }
        private System.Int32 get_mipmapCount() { }
        private UnityEngine.AnisotropicFiltering get_anisotropicFiltering() { }
        private System.Void set_anisotropicFiltering(UnityEngine.AnisotropicFiltering value) { }
        private System.Void SetGlobalAnisotropicFilteringLimits(System.Int32 forcedMin, System.Int32 globalMax) { }
        private UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat() { }
        private System.Int32 GetDataWidth() { }
        private System.Int32 GetDataHeight() { }
        private UnityEngine.Rendering.TextureDimension GetDimension() { }
        private System.Int32 get_width() { }
        private System.Void set_width(System.Int32 value) { }
        private System.Int32 get_height() { }
        private System.Void set_height(System.Int32 value) { }
        private UnityEngine.Rendering.TextureDimension get_dimension() { }
        private System.Void set_dimension(UnityEngine.Rendering.TextureDimension value) { }
        private System.Boolean get_isNativeTexture() { }
        private System.Boolean get_isReadable() { }
        private UnityEngine.TextureWrapMode get_wrapMode() { }
        private System.Void set_wrapMode(UnityEngine.TextureWrapMode value) { }
        private UnityEngine.TextureWrapMode get_wrapModeU() { }
        private System.Void set_wrapModeU(UnityEngine.TextureWrapMode value) { }
        private UnityEngine.TextureWrapMode get_wrapModeV() { }
        private System.Void set_wrapModeV(UnityEngine.TextureWrapMode value) { }
        private UnityEngine.TextureWrapMode get_wrapModeW() { }
        private System.Void set_wrapModeW(UnityEngine.TextureWrapMode value) { }
        private UnityEngine.FilterMode get_filterMode() { }
        private System.Void set_filterMode(UnityEngine.FilterMode value) { }
        private System.Int32 get_anisoLevel() { }
        private System.Void set_anisoLevel(System.Int32 value) { }
        private System.Single get_mipMapBias() { }
        private System.Void set_mipMapBias(System.Single value) { }
        private UnityEngine.Vector2 get_texelSize() { }
        private System.Int32 get_textureGroup() { }
        private System.IntPtr GetNativeTexturePtr() { }
        private System.Int32 GetNativeTextureID() { }
        private System.UInt32 get_updateCount() { }
        private System.Void IncrementUpdateCount() { }
        private System.Int32 Internal_GetActiveTextureColorSpace() { }
        private UnityEngine.ColorSpace get_activeTextureColorSpace() { }
        private UnityEngine.TextureColorSpace Internal_GetStoredColorSpace() { }
        private System.Boolean get_isDataSRGB() { }
        private System.Void DumpStreamingTextureInfo() { }
        private System.UInt64 get_totalTextureMemory() { }
        private System.UInt64 get_desiredTextureMemory() { }
        private System.UInt64 get_targetTextureMemory() { }
        private System.UInt64 get_currentTextureMemory() { }
        private System.UInt64 get_nonStreamingTextureMemory() { }
        private System.UInt64 get_streamingMipmapUploadCount() { }
        private System.UInt64 get_streamingRendererCount() { }
        private System.UInt64 get_streamingTextureCount() { }
        private System.UInt64 get_nonStreamingTextureCount() { }
        private System.UInt64 get_streamingTexturePendingLoadCount() { }
        private System.UInt64 get_streamingTextureLoadingCount() { }
        private System.Void SetStreamingTextureMaterialDebugProperties() { }
        private System.Boolean get_streamingTextureForceLoadAll() { }
        private System.Void set_streamingTextureForceLoadAll(System.Boolean value) { }
        private System.Boolean get_streamingTextureDiscardUnusedMips() { }
        private System.Void set_streamingTextureDiscardUnusedMips(System.Boolean value) { }
        private System.Boolean get_allowThreadedTextureCreation() { }
        private System.Void set_allowThreadedTextureCreation(System.Boolean value) { }
        private System.UInt64 GetPixelDataSize(System.Int32 mipLevel, System.Int32 element) { }
        private System.UInt64 GetPixelDataOffset(System.Int32 mipLevel, System.Int32 element) { }
        private UnityEngine.TextureColorSpace GetTextureColorSpace(System.Boolean linear) { }
        private UnityEngine.TextureColorSpace GetTextureColorSpace(UnityEngine.Experimental.Rendering.GraphicsFormat format) { }
        private System.Boolean ValidateFormat(UnityEngine.RenderTextureFormat format) { }
        private System.Boolean ValidateFormat(UnityEngine.TextureFormat format) { }
        private System.Boolean ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage) { }
        private UnityEngine.UnityException CreateNonReadableException(UnityEngine.Texture t) { }
        private UnityEngine.UnityException CreateNativeArrayLengthOverflowException() { }
        private System.Void .cctor() { }
        private System.Void get_texelSize_Injected(UnityEngine.Vector2& ret) { }

    }

    // TypeToken: 0x2000126
    public class Texture2D : Texture
    {
        // Fields
        private static System.Int32 streamingMipmapsPriorityMin;        // 0x0
        private static System.Int32 streamingMipmapsPriorityMax;        // 0x0

        // Methods
        private UnityEngine.TextureFormat get_format() { }
        private System.Boolean get_ignoreMipmapLimit() { }
        private System.Void set_ignoreMipmapLimit(System.Boolean value) { }
        private UnityEngine.Texture2D get_whiteTexture() { }
        private UnityEngine.Texture2D get_blackTexture() { }
        private UnityEngine.Texture2D get_redTexture() { }
        private UnityEngine.Texture2D get_blueTexture() { }
        private UnityEngine.Texture2D get_grayTexture() { }
        private UnityEngine.Texture2D get_linearGrayTexture() { }
        private UnityEngine.Texture2D get_normalTexture() { }
        private System.Void Compress(System.Boolean highQuality) { }
        private System.Boolean Internal_CreateImpl(UnityEngine.Texture2D mono, System.Int32 w, System.Int32 h, System.Int32 mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, System.IntPtr nativeTex) { }
        private System.Void Internal_Create(UnityEngine.Texture2D mono, System.Int32 w, System.Int32 h, System.Int32 mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, System.IntPtr nativeTex) { }
        private System.Boolean get_isReadable() { }
        private System.Boolean get_vtOnly() { }
        private System.Void ApplyImpl(System.Boolean updateMipmaps, System.Boolean makeNoLongerReadable) { }
        private System.Boolean ReinitializeImpl(System.Int32 width, System.Int32 height) { }
        private System.Void SetPixelImpl(System.Int32 image, System.Int32 mip, System.Int32 x, System.Int32 y, UnityEngine.Color color) { }
        private UnityEngine.Color GetPixelImpl(System.Int32 image, System.Int32 mip, System.Int32 x, System.Int32 y) { }
        private UnityEngine.Color GetPixelBilinearImpl(System.Int32 image, System.Int32 mip, System.Single u, System.Single v) { }
        private System.Boolean ReinitializeWithFormatImpl(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Boolean hasMipMap) { }
        private System.Void ReadPixelsImpl(UnityEngine.Rect source, System.Int32 destX, System.Int32 destY, System.Boolean recalculateMipMaps) { }
        private System.Void SetPixelsImpl(System.Int32 x, System.Int32 y, System.Int32 w, System.Int32 h, UnityEngine.Color[] pixel, System.Int32 miplevel, System.Int32 frame) { }
        private System.Boolean LoadRawTextureDataImpl(System.IntPtr data, System.UInt64 size) { }
        private System.Boolean LoadRawTextureDataImplArray(System.Byte[] data) { }
        private System.Boolean SetPixelDataImplArray(System.Array data, System.Int32 mipLevel, System.Int32 elementSize, System.Int32 dataArraySize, System.Int32 sourceDataStartIndex) { }
        private System.Boolean SetPixelDataImpl(System.IntPtr data, System.Int32 mipLevel, System.Int32 elementSize, System.Int32 dataArraySize, System.Int32 sourceDataStartIndex) { }
        private System.IntPtr GetWritableImageData(System.Int32 frame) { }
        private System.UInt64 GetRawImageDataSize() { }
        private System.Void GenerateAtlasImpl(UnityEngine.Vector2[] sizes, System.Int32 padding, System.Int32 atlasSize, UnityEngine.Rect[] rect) { }
        private System.Boolean get_isPreProcessed() { }
        private System.Boolean get_streamingMipmaps() { }
        private System.Int32 get_streamingMipmapsPriority() { }
        private System.Int32 get_requestedMipmapLevel() { }
        private System.Void set_requestedMipmapLevel(System.Int32 value) { }
        private System.Int32 get_minimumMipmapLevel() { }
        private System.Void set_minimumMipmapLevel(System.Int32 value) { }
        private System.Boolean get_loadAllMips() { }
        private System.Void set_loadAllMips(System.Boolean value) { }
        private System.Int32 get_calculatedMipmapLevel() { }
        private System.Int32 get_desiredMipmapLevel() { }
        private System.Int32 get_loadingMipmapLevel() { }
        private System.Int32 get_loadedMipmapLevel() { }
        private System.Void ClearRequestedMipmapLevel() { }
        private System.Boolean IsRequestedMipmapLevelLoaded() { }
        private System.Void ClearMinimumMipmapLevel() { }
        private System.Void UpdateExternalTexture(System.IntPtr nativeTex) { }
        private System.Void SetAllPixels32(UnityEngine.Color32[] colors, System.Int32 miplevel) { }
        private System.Void SetBlockOfPixels32(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight, UnityEngine.Color32[] colors, System.Int32 miplevel) { }
        private System.Byte[] GetRawTextureData() { }
        private UnityEngine.Color[] GetPixels(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight, System.Int32 miplevel) { }
        private UnityEngine.Color[] GetPixels(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight) { }
        private UnityEngine.Color32[] GetPixels32(System.Int32 miplevel) { }
        private UnityEngine.Color32[] GetPixels32() { }
        private UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[] textures, System.Int32 padding, System.Int32 maximumAtlasSize, System.Boolean makeNoLongerReadable) { }
        private UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[] textures, System.Int32 padding, System.Int32 maximumAtlasSize) { }
        private UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[] textures, System.Int32 padding) { }
        private System.Boolean ValidateFormat(UnityEngine.TextureFormat format, System.Int32 width, System.Int32 height) { }
        private System.Boolean ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 width, System.Int32 height) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, System.Int32 mipCount, System.IntPtr nativeTex) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 mipCount, UnityEngine.Experimental.Rendering.TextureCreationFlags flags) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat textureFormat, System.Int32 mipCount, System.Boolean linear, System.IntPtr nativeTex) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat textureFormat, System.Int32 mipCount, System.Boolean linear) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat textureFormat, System.Boolean mipChain, System.Boolean linear) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat textureFormat, System.Boolean mipChain) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height) { }
        private UnityEngine.Texture2D CreateExternalTexture(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat format, System.Boolean mipChain, System.Boolean linear, System.IntPtr nativeTex) { }
        private System.Void SetPixel(System.Int32 x, System.Int32 y, UnityEngine.Color color) { }
        private System.Void SetPixel(System.Int32 x, System.Int32 y, UnityEngine.Color color, System.Int32 mipLevel) { }
        private System.Void SetPixels(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight, UnityEngine.Color[] colors, System.Int32 miplevel) { }
        private System.Void SetPixels(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight, UnityEngine.Color[] colors) { }
        private System.Void SetPixels(UnityEngine.Color[] colors, System.Int32 miplevel) { }
        private System.Void SetPixels(UnityEngine.Color[] colors) { }
        private UnityEngine.Color GetPixel(System.Int32 x, System.Int32 y) { }
        private UnityEngine.Color GetPixel(System.Int32 x, System.Int32 y, System.Int32 mipLevel) { }
        private UnityEngine.Color GetPixelBilinear(System.Single u, System.Single v) { }
        private UnityEngine.Color GetPixelBilinear(System.Single u, System.Single v, System.Int32 mipLevel) { }
        private System.Void LoadRawTextureData(System.IntPtr data, System.Int32 size) { }
        private System.Void LoadRawTextureData(System.Byte[] data) { }
        private System.Void LoadRawTextureData(Unity.Collections.NativeArray<T> data) { }
        private System.Void SetPixelData(T[] data, System.Int32 mipLevel, System.Int32 sourceDataStartIndex) { }
        private System.Void SetPixelData(Unity.Collections.NativeArray<T> data, System.Int32 mipLevel, System.Int32 sourceDataStartIndex) { }
        private Unity.Collections.NativeArray<T> GetPixelData(System.Int32 mipLevel) { }
        private Unity.Collections.NativeArray<T> GetRawTextureData() { }
        private System.Void Apply(System.Boolean updateMipmaps, System.Boolean makeNoLongerReadable) { }
        private System.Void Apply(System.Boolean updateMipmaps) { }
        private System.Void Apply() { }
        private System.Boolean Reinitialize(System.Int32 width, System.Int32 height) { }
        private System.Boolean Reinitialize(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat format, System.Boolean hasMipMap) { }
        private System.Boolean Reinitialize(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Boolean hasMipMap) { }
        private System.Boolean Resize(System.Int32 width, System.Int32 height) { }
        private System.Boolean Resize(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat format, System.Boolean hasMipMap) { }
        private System.Boolean Resize(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Boolean hasMipMap) { }
        private System.Void ReadPixels(UnityEngine.Rect source, System.Int32 destX, System.Int32 destY, System.Boolean recalculateMipMaps) { }
        private System.Void ReadPixels(UnityEngine.Rect source, System.Int32 destX, System.Int32 destY) { }
        private System.Boolean GenerateAtlas(UnityEngine.Vector2[] sizes, System.Int32 padding, System.Int32 atlasSize, System.Collections.Generic.List<UnityEngine.Rect> results) { }
        private System.Void SetPixels32(UnityEngine.Color32[] colors, System.Int32 miplevel) { }
        private System.Void SetPixels32(UnityEngine.Color32[] colors) { }
        private System.Void SetPixels32(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight, UnityEngine.Color32[] colors, System.Int32 miplevel) { }
        private System.Void SetPixels32(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight, UnityEngine.Color32[] colors) { }
        private UnityEngine.Color[] GetPixels(System.Int32 miplevel) { }
        private UnityEngine.Color[] GetPixels() { }
        private System.Void SetPixelImpl_Injected(System.Int32 image, System.Int32 mip, System.Int32 x, System.Int32 y, UnityEngine.Color& color) { }
        private System.Void GetPixelImpl_Injected(System.Int32 image, System.Int32 mip, System.Int32 x, System.Int32 y, UnityEngine.Color& ret) { }
        private System.Void GetPixelBilinearImpl_Injected(System.Int32 image, System.Int32 mip, System.Single u, System.Single v, UnityEngine.Color& ret) { }
        private System.Void ReadPixelsImpl_Injected(UnityEngine.Rect& source, System.Int32 destX, System.Int32 destY, System.Boolean recalculateMipMaps) { }

    }

    // TypeToken: 0x2000128
    public class Cubemap : Texture
    {
        // Methods
        private System.Boolean Internal_CreateImpl(UnityEngine.Cubemap mono, System.Int32 ext, System.Int32 mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, System.IntPtr nativeTex) { }
        private System.Void Internal_Create(UnityEngine.Cubemap mono, System.Int32 ext, System.Int32 mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, System.IntPtr nativeTex) { }
        private System.Void ApplyImpl(System.Boolean updateMipmaps, System.Boolean makeNoLongerReadable) { }
        private System.Boolean get_isReadable() { }
        private System.Void SetPixelImpl(System.Int32 image, System.Int32 mip, System.Int32 x, System.Int32 y, UnityEngine.Color color) { }
        private System.Boolean ValidateFormat(UnityEngine.TextureFormat format, System.Int32 width) { }
        private System.Boolean ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 width) { }
        private System.Void .ctor(System.Int32 width, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags) { }
        private System.Void .ctor(System.Int32 width, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags) { }
        private System.Void .ctor(System.Int32 width, UnityEngine.TextureFormat format, System.Int32 mipCount) { }
        private System.Void .ctor(System.Int32 width, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, System.Int32 mipCount) { }
        private System.Void .ctor(System.Int32 width, UnityEngine.TextureFormat textureFormat, System.Int32 mipCount, System.IntPtr nativeTex) { }
        private System.Void .ctor(System.Int32 width, UnityEngine.TextureFormat textureFormat, System.Boolean mipChain, System.IntPtr nativeTex) { }
        private System.Void .ctor(System.Int32 width, UnityEngine.TextureFormat textureFormat, System.Boolean mipChain) { }
        private System.Void SetPixel(UnityEngine.CubemapFace face, System.Int32 x, System.Int32 y, UnityEngine.Color color) { }
        private System.Void SetPixel(UnityEngine.CubemapFace face, System.Int32 x, System.Int32 y, UnityEngine.Color color, System.Int32 mip) { }
        private System.Void Apply(System.Boolean updateMipmaps, System.Boolean makeNoLongerReadable) { }
        private System.Void Apply() { }
        private System.Void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags) { }
        private System.Void SetPixelImpl_Injected(System.Int32 image, System.Int32 mip, System.Int32 x, System.Int32 y, UnityEngine.Color& color) { }

    }

    // TypeToken: 0x2000129
    public class Texture3D : Texture
    {
        // Methods
        private System.Int32 get_depth() { }
        private System.Boolean get_isReadable() { }
        private System.Void SetPixelImpl(System.Int32 mip, System.Int32 x, System.Int32 y, System.Int32 z, UnityEngine.Color color) { }
        private UnityEngine.Texture3D get_blackTexture3D() { }
        private System.Boolean Internal_CreateImpl(UnityEngine.Texture3D mono, System.Int32 w, System.Int32 h, System.Int32 d, System.Int32 mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, System.IntPtr nativeTex) { }
        private System.Void Internal_Create(UnityEngine.Texture3D mono, System.Int32 w, System.Int32 h, System.Int32 d, System.Int32 mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, System.IntPtr nativeTex) { }
        private System.Void ApplyImpl(System.Boolean updateMipmaps, System.Boolean makeNoLongerReadable) { }
        private System.Void SetPixels(UnityEngine.Color[] colors, System.Int32 miplevel) { }
        private System.Void SetPixels(UnityEngine.Color[] colors) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, System.Int32 mipCount) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.TextureFormat textureFormat, System.Int32 mipCount) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.TextureFormat textureFormat, System.Int32 mipCount, System.IntPtr nativeTex) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.TextureFormat textureFormat, System.Boolean mipChain) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.TextureFormat textureFormat, System.Boolean mipChain, System.IntPtr nativeTex) { }
        private System.Void Apply(System.Boolean updateMipmaps, System.Boolean makeNoLongerReadable) { }
        private System.Void Apply(System.Boolean updateMipmaps) { }
        private System.Void Apply() { }
        private System.Void SetPixel(System.Int32 x, System.Int32 y, System.Int32 z, UnityEngine.Color color) { }
        private System.Void SetPixel(System.Int32 x, System.Int32 y, System.Int32 z, UnityEngine.Color color, System.Int32 mipLevel) { }
        private System.Void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags) { }
        private System.Void SetPixelImpl_Injected(System.Int32 mip, System.Int32 x, System.Int32 y, System.Int32 z, UnityEngine.Color& color) { }

    }

    // TypeToken: 0x200012A
    public class Texture2DArray : Texture
    {
        // Methods
        private System.Int32 get_allSlices() { }
        private System.Boolean get_isReadable() { }
        private System.Boolean Internal_CreateImpl(UnityEngine.Texture2DArray mono, System.Int32 w, System.Int32 h, System.Int32 d, System.Int32 mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags) { }
        private System.Void Internal_Create(UnityEngine.Texture2DArray mono, System.Int32 w, System.Int32 h, System.Int32 d, System.Int32 mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags) { }
        private System.Void ApplyImpl(System.Boolean updateMipmaps, System.Boolean makeNoLongerReadable) { }
        private System.Boolean ValidateFormat(UnityEngine.TextureFormat format, System.Int32 width, System.Int32 height) { }
        private System.Boolean ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 width, System.Int32 height) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, System.Int32 mipCount) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.TextureFormat textureFormat, System.Int32 mipCount, System.Boolean linear) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.TextureFormat textureFormat, System.Boolean mipChain, System.Boolean linear) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.TextureFormat textureFormat, System.Boolean mipChain) { }
        private System.Void Apply(System.Boolean updateMipmaps, System.Boolean makeNoLongerReadable) { }
        private System.Void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags) { }

    }

    // TypeToken: 0x200012B
    public class CubemapArray : Texture
    {
        // Methods
        private System.Boolean get_isReadable() { }
        private System.Boolean Internal_CreateImpl(UnityEngine.CubemapArray mono, System.Int32 ext, System.Int32 count, System.Int32 mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags) { }
        private System.Void Internal_Create(UnityEngine.CubemapArray mono, System.Int32 ext, System.Int32 count, System.Int32 mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags) { }
        private System.Void ApplyImpl(System.Boolean updateMipmaps, System.Boolean makeNoLongerReadable) { }
        private System.Void SetPixels(UnityEngine.Color[] colors, UnityEngine.CubemapFace face, System.Int32 arrayElement, System.Int32 miplevel) { }
        private System.Void SetPixels(UnityEngine.Color[] colors, UnityEngine.CubemapFace face, System.Int32 arrayElement) { }
        private System.Void .ctor(System.Int32 width, System.Int32 cubemapCount, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags) { }
        private System.Void .ctor(System.Int32 width, System.Int32 cubemapCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags) { }
        private System.Void .ctor(System.Int32 width, System.Int32 cubemapCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, System.Int32 mipCount) { }
        private System.Void .ctor(System.Int32 width, System.Int32 cubemapCount, UnityEngine.TextureFormat textureFormat, System.Int32 mipCount, System.Boolean linear) { }
        private System.Void .ctor(System.Int32 width, System.Int32 cubemapCount, UnityEngine.TextureFormat textureFormat, System.Boolean mipChain, System.Boolean linear) { }
        private System.Void .ctor(System.Int32 width, System.Int32 cubemapCount, UnityEngine.TextureFormat textureFormat, System.Boolean mipChain) { }
        private System.Void Apply(System.Boolean updateMipmaps, System.Boolean makeNoLongerReadable) { }
        private System.Void Apply() { }
        private System.Void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags) { }

    }

    // TypeToken: 0x200012C
    public class RenderTexture : Texture
    {
        // Methods
        private System.Int32 get_width() { }
        private System.Void set_width(System.Int32 value) { }
        private System.Int32 get_height() { }
        private System.Void set_height(System.Int32 value) { }
        private UnityEngine.Rendering.TextureDimension get_dimension() { }
        private System.Void set_dimension(UnityEngine.Rendering.TextureDimension value) { }
        private UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat() { }
        private System.Void set_graphicsFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value) { }
        private System.Boolean get_useMipMap() { }
        private System.Void set_useMipMap(System.Boolean value) { }
        private System.Boolean get_sRGB() { }
        private System.Void set_memorylessMode(UnityEngine.RenderTextureMemoryless value) { }
        private UnityEngine.RenderTextureFormat get_format() { }
        private System.Void set_stencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value) { }
        private UnityEngine.Experimental.Rendering.GraphicsFormat get_depthStencilFormat() { }
        private System.Void set_depthStencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value) { }
        private System.Boolean get_autoGenerateMips() { }
        private System.Void set_autoGenerateMips(System.Boolean value) { }
        private System.Int32 get_volumeDepth() { }
        private System.Void set_volumeDepth(System.Int32 value) { }
        private System.Void set_antiAliasing(System.Int32 value) { }
        private System.Void set_bindTextureMS(System.Boolean value) { }
        private System.Boolean get_enableRandomWrite() { }
        private System.Void set_enableRandomWrite(System.Boolean value) { }
        private System.Void set_useDynamicScale(System.Boolean value) { }
        private UnityEngine.RenderTexture GetActive() { }
        private System.Void SetActive(UnityEngine.RenderTexture rt) { }
        private UnityEngine.RenderTexture get_active() { }
        private System.Void set_active(UnityEngine.RenderTexture value) { }
        private UnityEngine.RenderBuffer GetColorBuffer() { }
        private UnityEngine.RenderBuffer GetDepthBuffer() { }
        private System.UInt32 GetStencilTexID() { }
        private System.Void SetMipMapCount(System.Int32 count) { }
        private UnityEngine.RenderBuffer get_colorBuffer() { }
        private UnityEngine.RenderBuffer get_depthBuffer() { }
        private System.Void DiscardContents(System.Boolean discardColor, System.Boolean discardDepth) { }
        private System.Void DiscardContents() { }
        private System.Boolean Create() { }
        private System.Void Release() { }
        private System.Boolean IsCreated() { }
        private System.Void GenerateMips() { }
        private System.Void SetSRGBReadWrite(System.Boolean srgb) { }
        private System.Void Internal_Create(UnityEngine.RenderTexture rt) { }
        private System.Void SetRenderTextureDescriptor(UnityEngine.RenderTextureDescriptor desc) { }
        private UnityEngine.RenderTextureDescriptor GetDescriptor() { }
        private UnityEngine.RenderTexture GetTemporary_Internal(UnityEngine.RenderTextureDescriptor desc) { }
        private System.Void ReleaseTemporary(UnityEngine.RenderTexture temp) { }
        private System.Int32 get_depth() { }
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.RenderTextureDescriptor desc) { }
        private System.Void .ctor(UnityEngine.RenderTexture textureToCopy) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.DefaultFormat format) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.GraphicsFormat format) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 mipCount) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, System.Int32 mipCount) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.RenderTextureFormat format) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.RenderTextureFormat format, System.Int32 mipCount) { }
        private System.Void Initialize(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, System.Int32 mipCount) { }
        private UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(System.Int32 depthBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat) { }
        private UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(System.Int32 depthBits, UnityEngine.RenderTextureFormat format) { }
        private UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(System.Int32 depthBits, UnityEngine.Experimental.Rendering.DefaultFormat format) { }
        private UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(System.Int32 depthBits, System.Boolean requestedShadowMap) { }
        private UnityEngine.RenderTextureDescriptor get_descriptor() { }
        private System.Void set_descriptor(UnityEngine.RenderTextureDescriptor value) { }
        private System.Void ValidateRenderTextureDesc(UnityEngine.RenderTextureDescriptor desc) { }
        private UnityEngine.Experimental.Rendering.GraphicsFormat GetDefaultColorFormat(UnityEngine.Experimental.Rendering.DefaultFormat format) { }
        private UnityEngine.Experimental.Rendering.GraphicsFormat GetDefaultDepthStencilFormat(UnityEngine.Experimental.Rendering.DefaultFormat format, System.Int32 depth) { }
        private UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(UnityEngine.RenderTextureFormat renderTextureFormat, UnityEngine.RenderTextureReadWrite readWrite) { }
        private UnityEngine.RenderTexture GetTemporary(UnityEngine.RenderTextureDescriptor desc) { }
        private UnityEngine.RenderTexture GetTemporaryImpl(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, System.Int32 antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage, System.Boolean useDynamicScale) { }
        private UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, System.Int32 antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage, System.Boolean useDynamicScale) { }
        private UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, System.Int32 antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage) { }
        private UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, System.Int32 antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode) { }
        private UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, System.Int32 antiAliasing) { }
        private UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite) { }
        private UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.RenderTextureFormat format) { }
        private UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer) { }
        private UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height) { }
        private System.Void GetColorBuffer_Injected(UnityEngine.RenderBuffer& ret) { }
        private System.Void GetDepthBuffer_Injected(UnityEngine.RenderBuffer& ret) { }
        private System.Void SetRenderTextureDescriptor_Injected(UnityEngine.RenderTextureDescriptor& desc) { }
        private System.Void GetDescriptor_Injected(UnityEngine.RenderTextureDescriptor& ret) { }
        private UnityEngine.RenderTexture GetTemporary_Internal_Injected(UnityEngine.RenderTextureDescriptor& desc) { }

    }

    // TypeToken: 0x200012D
    public class CustomRenderTexture : RenderTexture
    {
    }

    // TypeToken: 0x200012E
    public struct RenderTextureDescriptor
    {
        // Fields
        private System.Int32 <width>k__BackingField;        // 0x10
        private System.Int32 <height>k__BackingField;        // 0x14
        private System.Int32 <msaaSamples>k__BackingField;        // 0x18
        private System.Int32 <volumeDepth>k__BackingField;        // 0x1C
        private System.Int32 <mipCount>k__BackingField;        // 0x20
        private UnityEngine.Experimental.Rendering.GraphicsFormat _graphicsFormat;        // 0x24
        private UnityEngine.Experimental.Rendering.GraphicsFormat <stencilFormat>k__BackingField;        // 0x28
        private UnityEngine.Experimental.Rendering.GraphicsFormat <depthStencilFormat>k__BackingField;        // 0x2C
        private UnityEngine.Rendering.TextureDimension <dimension>k__BackingField;        // 0x30
        private UnityEngine.Rendering.ShadowSamplingMode <shadowSamplingMode>k__BackingField;        // 0x34
        private UnityEngine.VRTextureUsage <vrUsage>k__BackingField;        // 0x38
        private UnityEngine.RenderTextureCreationFlags _flags;        // 0x3C
        private UnityEngine.RenderTextureMemoryless <memoryless>k__BackingField;        // 0x40

        // Methods
        private System.Int32 get_width() { }
        private System.Void set_width(System.Int32 value) { }
        private System.Int32 get_height() { }
        private System.Void set_height(System.Int32 value) { }
        private System.Int32 get_msaaSamples() { }
        private System.Void set_msaaSamples(System.Int32 value) { }
        private System.Int32 get_volumeDepth() { }
        private System.Void set_volumeDepth(System.Int32 value) { }
        private System.Void set_mipCount(System.Int32 value) { }
        private UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat() { }
        private System.Void set_graphicsFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value) { }
        private UnityEngine.Experimental.Rendering.GraphicsFormat get_depthStencilFormat() { }
        private System.Void set_depthStencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value) { }
        private UnityEngine.RenderTextureFormat get_colorFormat() { }
        private System.Void set_colorFormat(UnityEngine.RenderTextureFormat value) { }
        private System.Boolean get_sRGB() { }
        private System.Void set_sRGB(System.Boolean value) { }
        private System.Int32 get_depthBufferBits() { }
        private System.Void set_depthBufferBits(System.Int32 value) { }
        private UnityEngine.Rendering.TextureDimension get_dimension() { }
        private System.Void set_dimension(UnityEngine.Rendering.TextureDimension value) { }
        private UnityEngine.Rendering.ShadowSamplingMode get_shadowSamplingMode() { }
        private System.Void set_shadowSamplingMode(UnityEngine.Rendering.ShadowSamplingMode value) { }
        private System.Void set_vrUsage(UnityEngine.VRTextureUsage value) { }
        private System.Void set_memoryless(UnityEngine.RenderTextureMemoryless value) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.RenderTextureFormat colorFormat) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.RenderTextureFormat colorFormat, System.Int32 depthBufferBits) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, System.Int32 depthBufferBits) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.RenderTextureFormat colorFormat, System.Int32 depthBufferBits, System.Int32 mipCount) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.RenderTextureFormat colorFormat, System.Int32 depthBufferBits, System.Int32 mipCount, UnityEngine.RenderTextureReadWrite readWrite) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, System.Int32 depthBufferBits, System.Int32 mipCount) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat) { }
        private System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, System.Int32 mipCount) { }
        private System.Void SetOrClearRenderTextureCreationFlag(System.Boolean value, UnityEngine.RenderTextureCreationFlags flag) { }
        private System.Boolean get_useMipMap() { }
        private System.Void set_useMipMap(System.Boolean value) { }
        private System.Boolean get_autoGenerateMips() { }
        private System.Void set_autoGenerateMips(System.Boolean value) { }
        private System.Boolean get_enableRandomWrite() { }
        private System.Void set_enableRandomWrite(System.Boolean value) { }
        private System.Void set_bindMS(System.Boolean value) { }
        private System.Void set_createdFromScript(System.Boolean value) { }
        private System.Void set_useDynamicScale(System.Boolean value) { }

    }

    // TypeToken: 0x200012F
    public struct Hash128, IComparable, IComparable`1, IEquatable`1
    {
        // Fields
        private System.UInt64 u64_0;        // 0x10
        private System.UInt64 u64_1;        // 0x18
        private static System.UInt64 kConst;        // 0x0

        // Methods
        private System.Void .ctor(System.UInt64 u64_0, System.UInt64 u64_1) { }
        private System.Int32 CompareTo(UnityEngine.Hash128 rhs) { }
        private System.String ToString() { }
        private System.String Hash128ToStringImpl(UnityEngine.Hash128 hash) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(UnityEngine.Hash128 obj) { }
        private System.Int32 GetHashCode() { }
        private System.Int32 CompareTo(System.Object obj) { }
        private System.Boolean op_Equality(UnityEngine.Hash128 hash1, UnityEngine.Hash128 hash2) { }
        private System.Boolean op_LessThan(UnityEngine.Hash128 x, UnityEngine.Hash128 y) { }
        private System.Boolean op_GreaterThan(UnityEngine.Hash128 x, UnityEngine.Hash128 y) { }
        private System.String Hash128ToStringImpl_Injected(UnityEngine.Hash128& hash) { }

    }

    // TypeToken: 0x2000130
    public class HashUtilities
    {
        // Methods
        private System.Void AppendHash(UnityEngine.Hash128& inHash, UnityEngine.Hash128& outHash) { }
        private System.Void ComputeHash128(T& value, UnityEngine.Hash128& hash) { }

    }

    // TypeToken: 0x2000131
    public class HashUnsafeUtilities
    {
        // Methods
        private System.Void ComputeHash128(System.Void* data, System.UInt64 dataSize, System.UInt64* hash1, System.UInt64* hash2) { }
        private System.Void ComputeHash128(System.Void* data, System.UInt64 dataSize, UnityEngine.Hash128* hash) { }

    }

    // TypeToken: 0x2000132
    public class SpookyHash
    {
        // Fields
        private static readonly System.Boolean AllowUnalignedRead;        // 0x0

        // Methods
        private System.Boolean AttemptDetectAllowUnalignedRead() { }
        private System.Void Hash(System.Void* message, System.UInt64 length, System.UInt64* hash1, System.UInt64* hash2) { }
        private System.Void End(System.UInt64* data, System.UInt64& h0, System.UInt64& h1, System.UInt64& h2, System.UInt64& h3, System.UInt64& h4, System.UInt64& h5, System.UInt64& h6, System.UInt64& h7, System.UInt64& h8, System.UInt64& h9, System.UInt64& h10, System.UInt64& h11) { }
        private System.Void EndPartial(System.UInt64& h0, System.UInt64& h1, System.UInt64& h2, System.UInt64& h3, System.UInt64& h4, System.UInt64& h5, System.UInt64& h6, System.UInt64& h7, System.UInt64& h8, System.UInt64& h9, System.UInt64& h10, System.UInt64& h11) { }
        private System.Void Rot64(System.UInt64& x, System.Int32 k) { }
        private System.Void Short(System.Void* message, System.UInt64 length, System.UInt64* hash1, System.UInt64* hash2) { }
        private System.Void ShortMix(System.UInt64& h0, System.UInt64& h1, System.UInt64& h2, System.UInt64& h3) { }
        private System.Void ShortEnd(System.UInt64& h0, System.UInt64& h1, System.UInt64& h2, System.UInt64& h3) { }
        private System.Void Mix(System.UInt64* data, System.UInt64& s0, System.UInt64& s1, System.UInt64& s2, System.UInt64& s3, System.UInt64& s4, System.UInt64& s5, System.UInt64& s6, System.UInt64& s7, System.UInt64& s8, System.UInt64& s9, System.UInt64& s10, System.UInt64& s11) { }
        private System.Void memset(System.Void* dst, System.Int32 value, System.UInt64 numberOfBytes) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000134
    public struct StringHash, IEquatable`1, IFormattable
    {
        // Fields
        public System.Int64 hashValue;        // 0x10
        public System.String stringValue;        // 0x18

        // Methods
        private System.String ToString() { }
        private System.Int32 GetHashCode() { }
        private System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(UnityEngine.StringHash other) { }

    }

    // TypeToken: 0x2000135
    public struct CursorMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.CursorMode Auto;        // 0x0
        public static UnityEngine.CursorMode ForceSoftware;        // 0x0

    }

    // TypeToken: 0x2000136
    public struct CursorLockMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.CursorLockMode None;        // 0x0
        public static UnityEngine.CursorLockMode Locked;        // 0x0
        public static UnityEngine.CursorLockMode Confined;        // 0x0

    }

    // TypeToken: 0x2000137
    public class Cursor
    {
        // Methods
        private System.Void SetCursor(UnityEngine.Texture2D texture, UnityEngine.CursorMode cursorMode) { }
        private System.Void SetCursor(UnityEngine.Texture2D texture, UnityEngine.Vector2 hotspot, UnityEngine.CursorMode cursorMode) { }
        private System.Boolean get_visible() { }
        private System.Void set_visible(System.Boolean value) { }
        private UnityEngine.CursorLockMode get_lockState() { }
        private System.Void set_lockState(UnityEngine.CursorLockMode value) { }
        private System.Void .ctor() { }
        private System.Void SetCursor_Injected(UnityEngine.Texture2D texture, UnityEngine.Vector2& hotspot, UnityEngine.CursorMode cursorMode) { }

    }

    // TypeToken: 0x2000138
    public struct KeyCode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.KeyCode None;        // 0x0
        public static UnityEngine.KeyCode Backspace;        // 0x0
        public static UnityEngine.KeyCode Delete;        // 0x0
        public static UnityEngine.KeyCode Tab;        // 0x0
        public static UnityEngine.KeyCode Clear;        // 0x0
        public static UnityEngine.KeyCode Return;        // 0x0
        public static UnityEngine.KeyCode Pause;        // 0x0
        public static UnityEngine.KeyCode Escape;        // 0x0
        public static UnityEngine.KeyCode Space;        // 0x0
        public static UnityEngine.KeyCode Keypad0;        // 0x0
        public static UnityEngine.KeyCode Keypad1;        // 0x0
        public static UnityEngine.KeyCode Keypad2;        // 0x0
        public static UnityEngine.KeyCode Keypad3;        // 0x0
        public static UnityEngine.KeyCode Keypad4;        // 0x0
        public static UnityEngine.KeyCode Keypad5;        // 0x0
        public static UnityEngine.KeyCode Keypad6;        // 0x0
        public static UnityEngine.KeyCode Keypad7;        // 0x0
        public static UnityEngine.KeyCode Keypad8;        // 0x0
        public static UnityEngine.KeyCode Keypad9;        // 0x0
        public static UnityEngine.KeyCode KeypadPeriod;        // 0x0
        public static UnityEngine.KeyCode KeypadDivide;        // 0x0
        public static UnityEngine.KeyCode KeypadMultiply;        // 0x0
        public static UnityEngine.KeyCode KeypadMinus;        // 0x0
        public static UnityEngine.KeyCode KeypadPlus;        // 0x0
        public static UnityEngine.KeyCode KeypadEnter;        // 0x0
        public static UnityEngine.KeyCode KeypadEquals;        // 0x0
        public static UnityEngine.KeyCode UpArrow;        // 0x0
        public static UnityEngine.KeyCode DownArrow;        // 0x0
        public static UnityEngine.KeyCode RightArrow;        // 0x0
        public static UnityEngine.KeyCode LeftArrow;        // 0x0
        public static UnityEngine.KeyCode Insert;        // 0x0
        public static UnityEngine.KeyCode Home;        // 0x0
        public static UnityEngine.KeyCode End;        // 0x0
        public static UnityEngine.KeyCode PageUp;        // 0x0
        public static UnityEngine.KeyCode PageDown;        // 0x0
        public static UnityEngine.KeyCode F1;        // 0x0
        public static UnityEngine.KeyCode F2;        // 0x0
        public static UnityEngine.KeyCode F3;        // 0x0
        public static UnityEngine.KeyCode F4;        // 0x0
        public static UnityEngine.KeyCode F5;        // 0x0
        public static UnityEngine.KeyCode F6;        // 0x0
        public static UnityEngine.KeyCode F7;        // 0x0
        public static UnityEngine.KeyCode F8;        // 0x0
        public static UnityEngine.KeyCode F9;        // 0x0
        public static UnityEngine.KeyCode F10;        // 0x0
        public static UnityEngine.KeyCode F11;        // 0x0
        public static UnityEngine.KeyCode F12;        // 0x0
        public static UnityEngine.KeyCode F13;        // 0x0
        public static UnityEngine.KeyCode F14;        // 0x0
        public static UnityEngine.KeyCode F15;        // 0x0
        public static UnityEngine.KeyCode Alpha0;        // 0x0
        public static UnityEngine.KeyCode Alpha1;        // 0x0
        public static UnityEngine.KeyCode Alpha2;        // 0x0
        public static UnityEngine.KeyCode Alpha3;        // 0x0
        public static UnityEngine.KeyCode Alpha4;        // 0x0
        public static UnityEngine.KeyCode Alpha5;        // 0x0
        public static UnityEngine.KeyCode Alpha6;        // 0x0
        public static UnityEngine.KeyCode Alpha7;        // 0x0
        public static UnityEngine.KeyCode Alpha8;        // 0x0
        public static UnityEngine.KeyCode Alpha9;        // 0x0
        public static UnityEngine.KeyCode Exclaim;        // 0x0
        public static UnityEngine.KeyCode DoubleQuote;        // 0x0
        public static UnityEngine.KeyCode Hash;        // 0x0
        public static UnityEngine.KeyCode Dollar;        // 0x0
        public static UnityEngine.KeyCode Percent;        // 0x0
        public static UnityEngine.KeyCode Ampersand;        // 0x0
        public static UnityEngine.KeyCode Quote;        // 0x0
        public static UnityEngine.KeyCode LeftParen;        // 0x0
        public static UnityEngine.KeyCode RightParen;        // 0x0
        public static UnityEngine.KeyCode Asterisk;        // 0x0
        public static UnityEngine.KeyCode Plus;        // 0x0
        public static UnityEngine.KeyCode Comma;        // 0x0
        public static UnityEngine.KeyCode Minus;        // 0x0
        public static UnityEngine.KeyCode Period;        // 0x0
        public static UnityEngine.KeyCode Slash;        // 0x0
        public static UnityEngine.KeyCode Colon;        // 0x0
        public static UnityEngine.KeyCode Semicolon;        // 0x0
        public static UnityEngine.KeyCode Less;        // 0x0
        public static UnityEngine.KeyCode Equals;        // 0x0
        public static UnityEngine.KeyCode Greater;        // 0x0
        public static UnityEngine.KeyCode Question;        // 0x0
        public static UnityEngine.KeyCode At;        // 0x0
        public static UnityEngine.KeyCode LeftBracket;        // 0x0
        public static UnityEngine.KeyCode Backslash;        // 0x0
        public static UnityEngine.KeyCode RightBracket;        // 0x0
        public static UnityEngine.KeyCode Caret;        // 0x0
        public static UnityEngine.KeyCode Underscore;        // 0x0
        public static UnityEngine.KeyCode BackQuote;        // 0x0
        public static UnityEngine.KeyCode A;        // 0x0
        public static UnityEngine.KeyCode B;        // 0x0
        public static UnityEngine.KeyCode C;        // 0x0
        public static UnityEngine.KeyCode D;        // 0x0
        public static UnityEngine.KeyCode E;        // 0x0
        public static UnityEngine.KeyCode F;        // 0x0
        public static UnityEngine.KeyCode G;        // 0x0
        public static UnityEngine.KeyCode H;        // 0x0
        public static UnityEngine.KeyCode I;        // 0x0
        public static UnityEngine.KeyCode J;        // 0x0
        public static UnityEngine.KeyCode K;        // 0x0
        public static UnityEngine.KeyCode L;        // 0x0
        public static UnityEngine.KeyCode M;        // 0x0
        public static UnityEngine.KeyCode N;        // 0x0
        public static UnityEngine.KeyCode O;        // 0x0
        public static UnityEngine.KeyCode P;        // 0x0
        public static UnityEngine.KeyCode Q;        // 0x0
        public static UnityEngine.KeyCode R;        // 0x0
        public static UnityEngine.KeyCode S;        // 0x0
        public static UnityEngine.KeyCode T;        // 0x0
        public static UnityEngine.KeyCode U;        // 0x0
        public static UnityEngine.KeyCode V;        // 0x0
        public static UnityEngine.KeyCode W;        // 0x0
        public static UnityEngine.KeyCode X;        // 0x0
        public static UnityEngine.KeyCode Y;        // 0x0
        public static UnityEngine.KeyCode Z;        // 0x0
        public static UnityEngine.KeyCode LeftCurlyBracket;        // 0x0
        public static UnityEngine.KeyCode Pipe;        // 0x0
        public static UnityEngine.KeyCode RightCurlyBracket;        // 0x0
        public static UnityEngine.KeyCode Tilde;        // 0x0
        public static UnityEngine.KeyCode Numlock;        // 0x0
        public static UnityEngine.KeyCode CapsLock;        // 0x0
        public static UnityEngine.KeyCode ScrollLock;        // 0x0
        public static UnityEngine.KeyCode RightShift;        // 0x0
        public static UnityEngine.KeyCode LeftShift;        // 0x0
        public static UnityEngine.KeyCode RightControl;        // 0x0
        public static UnityEngine.KeyCode LeftControl;        // 0x0
        public static UnityEngine.KeyCode RightAlt;        // 0x0
        public static UnityEngine.KeyCode LeftAlt;        // 0x0
        public static UnityEngine.KeyCode LeftMeta;        // 0x0
        public static UnityEngine.KeyCode LeftCommand;        // 0x0
        public static UnityEngine.KeyCode LeftApple;        // 0x0
        public static UnityEngine.KeyCode LeftWindows;        // 0x0
        public static UnityEngine.KeyCode RightMeta;        // 0x0
        public static UnityEngine.KeyCode RightCommand;        // 0x0
        public static UnityEngine.KeyCode RightApple;        // 0x0
        public static UnityEngine.KeyCode RightWindows;        // 0x0
        public static UnityEngine.KeyCode AltGr;        // 0x0
        public static UnityEngine.KeyCode Help;        // 0x0
        public static UnityEngine.KeyCode Print;        // 0x0
        public static UnityEngine.KeyCode SysReq;        // 0x0
        public static UnityEngine.KeyCode Break;        // 0x0
        public static UnityEngine.KeyCode Menu;        // 0x0
        public static UnityEngine.KeyCode Mouse0;        // 0x0
        public static UnityEngine.KeyCode Mouse1;        // 0x0
        public static UnityEngine.KeyCode Mouse2;        // 0x0
        public static UnityEngine.KeyCode Mouse3;        // 0x0
        public static UnityEngine.KeyCode Mouse4;        // 0x0
        public static UnityEngine.KeyCode Mouse5;        // 0x0
        public static UnityEngine.KeyCode Mouse6;        // 0x0
        public static UnityEngine.KeyCode JoystickButton0;        // 0x0
        public static UnityEngine.KeyCode JoystickButton1;        // 0x0
        public static UnityEngine.KeyCode JoystickButton2;        // 0x0
        public static UnityEngine.KeyCode JoystickButton3;        // 0x0
        public static UnityEngine.KeyCode JoystickButton4;        // 0x0
        public static UnityEngine.KeyCode JoystickButton5;        // 0x0
        public static UnityEngine.KeyCode JoystickButton6;        // 0x0
        public static UnityEngine.KeyCode JoystickButton7;        // 0x0
        public static UnityEngine.KeyCode JoystickButton8;        // 0x0
        public static UnityEngine.KeyCode JoystickButton9;        // 0x0
        public static UnityEngine.KeyCode JoystickButton10;        // 0x0
        public static UnityEngine.KeyCode JoystickButton11;        // 0x0
        public static UnityEngine.KeyCode JoystickButton12;        // 0x0
        public static UnityEngine.KeyCode JoystickButton13;        // 0x0
        public static UnityEngine.KeyCode JoystickButton14;        // 0x0
        public static UnityEngine.KeyCode JoystickButton15;        // 0x0
        public static UnityEngine.KeyCode JoystickButton16;        // 0x0
        public static UnityEngine.KeyCode JoystickButton17;        // 0x0
        public static UnityEngine.KeyCode JoystickButton18;        // 0x0
        public static UnityEngine.KeyCode JoystickButton19;        // 0x0
        public static UnityEngine.KeyCode Joystick1Button0;        // 0x0
        public static UnityEngine.KeyCode Joystick1Button1;        // 0x0
        public static UnityEngine.KeyCode Joystick1Button2;        // 0x0
        public static UnityEngine.KeyCode Joystick1Button3;        // 0x0
        public static UnityEngine.KeyCode Joystick1Button4;        // 0x0
        public static UnityEngine.KeyCode Joystick1Button5;        // 0x0
        public static UnityEngine.KeyCode Joystick1Button6;        // 0x0
        public static UnityEngine.KeyCode Joystick1Button7;        // 0x0
        public static UnityEngine.KeyCode Joystick1Button8;        // 0x0
        public static UnityEngine.KeyCode Joystick1Button9;        // 0x0
        public static UnityEngine.KeyCode Joystick1Button10;        // 0x0
        public static UnityEngine.KeyCode Joystick1Button11;        // 0x0
        public static UnityEngine.KeyCode Joystick1Button12;        // 0x0
        public static UnityEngine.KeyCode Joystick1Button13;        // 0x0
        public static UnityEngine.KeyCode Joystick1Button14;        // 0x0
        public static UnityEngine.KeyCode Joystick1Button15;        // 0x0
        public static UnityEngine.KeyCode Joystick1Button16;        // 0x0
        public static UnityEngine.KeyCode Joystick1Button17;        // 0x0
        public static UnityEngine.KeyCode Joystick1Button18;        // 0x0
        public static UnityEngine.KeyCode Joystick1Button19;        // 0x0
        public static UnityEngine.KeyCode Joystick2Button0;        // 0x0
        public static UnityEngine.KeyCode Joystick2Button1;        // 0x0
        public static UnityEngine.KeyCode Joystick2Button2;        // 0x0
        public static UnityEngine.KeyCode Joystick2Button3;        // 0x0
        public static UnityEngine.KeyCode Joystick2Button4;        // 0x0
        public static UnityEngine.KeyCode Joystick2Button5;        // 0x0
        public static UnityEngine.KeyCode Joystick2Button6;        // 0x0
        public static UnityEngine.KeyCode Joystick2Button7;        // 0x0
        public static UnityEngine.KeyCode Joystick2Button8;        // 0x0
        public static UnityEngine.KeyCode Joystick2Button9;        // 0x0
        public static UnityEngine.KeyCode Joystick2Button10;        // 0x0
        public static UnityEngine.KeyCode Joystick2Button11;        // 0x0
        public static UnityEngine.KeyCode Joystick2Button12;        // 0x0
        public static UnityEngine.KeyCode Joystick2Button13;        // 0x0
        public static UnityEngine.KeyCode Joystick2Button14;        // 0x0
        public static UnityEngine.KeyCode Joystick2Button15;        // 0x0
        public static UnityEngine.KeyCode Joystick2Button16;        // 0x0
        public static UnityEngine.KeyCode Joystick2Button17;        // 0x0
        public static UnityEngine.KeyCode Joystick2Button18;        // 0x0
        public static UnityEngine.KeyCode Joystick2Button19;        // 0x0
        public static UnityEngine.KeyCode Joystick3Button0;        // 0x0
        public static UnityEngine.KeyCode Joystick3Button1;        // 0x0
        public static UnityEngine.KeyCode Joystick3Button2;        // 0x0
        public static UnityEngine.KeyCode Joystick3Button3;        // 0x0
        public static UnityEngine.KeyCode Joystick3Button4;        // 0x0
        public static UnityEngine.KeyCode Joystick3Button5;        // 0x0
        public static UnityEngine.KeyCode Joystick3Button6;        // 0x0
        public static UnityEngine.KeyCode Joystick3Button7;        // 0x0
        public static UnityEngine.KeyCode Joystick3Button8;        // 0x0
        public static UnityEngine.KeyCode Joystick3Button9;        // 0x0
        public static UnityEngine.KeyCode Joystick3Button10;        // 0x0
        public static UnityEngine.KeyCode Joystick3Button11;        // 0x0
        public static UnityEngine.KeyCode Joystick3Button12;        // 0x0
        public static UnityEngine.KeyCode Joystick3Button13;        // 0x0
        public static UnityEngine.KeyCode Joystick3Button14;        // 0x0
        public static UnityEngine.KeyCode Joystick3Button15;        // 0x0
        public static UnityEngine.KeyCode Joystick3Button16;        // 0x0
        public static UnityEngine.KeyCode Joystick3Button17;        // 0x0
        public static UnityEngine.KeyCode Joystick3Button18;        // 0x0
        public static UnityEngine.KeyCode Joystick3Button19;        // 0x0
        public static UnityEngine.KeyCode Joystick4Button0;        // 0x0
        public static UnityEngine.KeyCode Joystick4Button1;        // 0x0
        public static UnityEngine.KeyCode Joystick4Button2;        // 0x0
        public static UnityEngine.KeyCode Joystick4Button3;        // 0x0
        public static UnityEngine.KeyCode Joystick4Button4;        // 0x0
        public static UnityEngine.KeyCode Joystick4Button5;        // 0x0
        public static UnityEngine.KeyCode Joystick4Button6;        // 0x0
        public static UnityEngine.KeyCode Joystick4Button7;        // 0x0
        public static UnityEngine.KeyCode Joystick4Button8;        // 0x0
        public static UnityEngine.KeyCode Joystick4Button9;        // 0x0
        public static UnityEngine.KeyCode Joystick4Button10;        // 0x0
        public static UnityEngine.KeyCode Joystick4Button11;        // 0x0
        public static UnityEngine.KeyCode Joystick4Button12;        // 0x0
        public static UnityEngine.KeyCode Joystick4Button13;        // 0x0
        public static UnityEngine.KeyCode Joystick4Button14;        // 0x0
        public static UnityEngine.KeyCode Joystick4Button15;        // 0x0
        public static UnityEngine.KeyCode Joystick4Button16;        // 0x0
        public static UnityEngine.KeyCode Joystick4Button17;        // 0x0
        public static UnityEngine.KeyCode Joystick4Button18;        // 0x0
        public static UnityEngine.KeyCode Joystick4Button19;        // 0x0
        public static UnityEngine.KeyCode Joystick5Button0;        // 0x0
        public static UnityEngine.KeyCode Joystick5Button1;        // 0x0
        public static UnityEngine.KeyCode Joystick5Button2;        // 0x0
        public static UnityEngine.KeyCode Joystick5Button3;        // 0x0
        public static UnityEngine.KeyCode Joystick5Button4;        // 0x0
        public static UnityEngine.KeyCode Joystick5Button5;        // 0x0
        public static UnityEngine.KeyCode Joystick5Button6;        // 0x0
        public static UnityEngine.KeyCode Joystick5Button7;        // 0x0
        public static UnityEngine.KeyCode Joystick5Button8;        // 0x0
        public static UnityEngine.KeyCode Joystick5Button9;        // 0x0
        public static UnityEngine.KeyCode Joystick5Button10;        // 0x0
        public static UnityEngine.KeyCode Joystick5Button11;        // 0x0
        public static UnityEngine.KeyCode Joystick5Button12;        // 0x0
        public static UnityEngine.KeyCode Joystick5Button13;        // 0x0
        public static UnityEngine.KeyCode Joystick5Button14;        // 0x0
        public static UnityEngine.KeyCode Joystick5Button15;        // 0x0
        public static UnityEngine.KeyCode Joystick5Button16;        // 0x0
        public static UnityEngine.KeyCode Joystick5Button17;        // 0x0
        public static UnityEngine.KeyCode Joystick5Button18;        // 0x0
        public static UnityEngine.KeyCode Joystick5Button19;        // 0x0
        public static UnityEngine.KeyCode Joystick6Button0;        // 0x0
        public static UnityEngine.KeyCode Joystick6Button1;        // 0x0
        public static UnityEngine.KeyCode Joystick6Button2;        // 0x0
        public static UnityEngine.KeyCode Joystick6Button3;        // 0x0
        public static UnityEngine.KeyCode Joystick6Button4;        // 0x0
        public static UnityEngine.KeyCode Joystick6Button5;        // 0x0
        public static UnityEngine.KeyCode Joystick6Button6;        // 0x0
        public static UnityEngine.KeyCode Joystick6Button7;        // 0x0
        public static UnityEngine.KeyCode Joystick6Button8;        // 0x0
        public static UnityEngine.KeyCode Joystick6Button9;        // 0x0
        public static UnityEngine.KeyCode Joystick6Button10;        // 0x0
        public static UnityEngine.KeyCode Joystick6Button11;        // 0x0
        public static UnityEngine.KeyCode Joystick6Button12;        // 0x0
        public static UnityEngine.KeyCode Joystick6Button13;        // 0x0
        public static UnityEngine.KeyCode Joystick6Button14;        // 0x0
        public static UnityEngine.KeyCode Joystick6Button15;        // 0x0
        public static UnityEngine.KeyCode Joystick6Button16;        // 0x0
        public static UnityEngine.KeyCode Joystick6Button17;        // 0x0
        public static UnityEngine.KeyCode Joystick6Button18;        // 0x0
        public static UnityEngine.KeyCode Joystick6Button19;        // 0x0
        public static UnityEngine.KeyCode Joystick7Button0;        // 0x0
        public static UnityEngine.KeyCode Joystick7Button1;        // 0x0
        public static UnityEngine.KeyCode Joystick7Button2;        // 0x0
        public static UnityEngine.KeyCode Joystick7Button3;        // 0x0
        public static UnityEngine.KeyCode Joystick7Button4;        // 0x0
        public static UnityEngine.KeyCode Joystick7Button5;        // 0x0
        public static UnityEngine.KeyCode Joystick7Button6;        // 0x0
        public static UnityEngine.KeyCode Joystick7Button7;        // 0x0
        public static UnityEngine.KeyCode Joystick7Button8;        // 0x0
        public static UnityEngine.KeyCode Joystick7Button9;        // 0x0
        public static UnityEngine.KeyCode Joystick7Button10;        // 0x0
        public static UnityEngine.KeyCode Joystick7Button11;        // 0x0
        public static UnityEngine.KeyCode Joystick7Button12;        // 0x0
        public static UnityEngine.KeyCode Joystick7Button13;        // 0x0
        public static UnityEngine.KeyCode Joystick7Button14;        // 0x0
        public static UnityEngine.KeyCode Joystick7Button15;        // 0x0
        public static UnityEngine.KeyCode Joystick7Button16;        // 0x0
        public static UnityEngine.KeyCode Joystick7Button17;        // 0x0
        public static UnityEngine.KeyCode Joystick7Button18;        // 0x0
        public static UnityEngine.KeyCode Joystick7Button19;        // 0x0
        public static UnityEngine.KeyCode Joystick8Button0;        // 0x0
        public static UnityEngine.KeyCode Joystick8Button1;        // 0x0
        public static UnityEngine.KeyCode Joystick8Button2;        // 0x0
        public static UnityEngine.KeyCode Joystick8Button3;        // 0x0
        public static UnityEngine.KeyCode Joystick8Button4;        // 0x0
        public static UnityEngine.KeyCode Joystick8Button5;        // 0x0
        public static UnityEngine.KeyCode Joystick8Button6;        // 0x0
        public static UnityEngine.KeyCode Joystick8Button7;        // 0x0
        public static UnityEngine.KeyCode Joystick8Button8;        // 0x0
        public static UnityEngine.KeyCode Joystick8Button9;        // 0x0
        public static UnityEngine.KeyCode Joystick8Button10;        // 0x0
        public static UnityEngine.KeyCode Joystick8Button11;        // 0x0
        public static UnityEngine.KeyCode Joystick8Button12;        // 0x0
        public static UnityEngine.KeyCode Joystick8Button13;        // 0x0
        public static UnityEngine.KeyCode Joystick8Button14;        // 0x0
        public static UnityEngine.KeyCode Joystick8Button15;        // 0x0
        public static UnityEngine.KeyCode Joystick8Button16;        // 0x0
        public static UnityEngine.KeyCode Joystick8Button17;        // 0x0
        public static UnityEngine.KeyCode Joystick8Button18;        // 0x0
        public static UnityEngine.KeyCode Joystick8Button19;        // 0x0

    }

    // TypeToken: 0x2000139
    public interface ILogger : ILogHandler
    {
        // Methods
        private UnityEngine.ILogHandler get_logHandler() { }
        private System.Boolean get_logEnabled() { }
        private System.Void set_logEnabled(System.Boolean value) { }
        private System.Void set_filterLogType(UnityEngine.LogType value) { }
        private System.Boolean IsLogTypeAllowed(UnityEngine.LogType logType) { }
        private System.Void Log(UnityEngine.LogType logType, System.Object message) { }
        private System.Void Log(UnityEngine.LogType logType, System.Object message, UnityEngine.Object context) { }
        private System.Void Log(UnityEngine.LogType logType, System.String tag, System.Object message, UnityEngine.Object context) { }
        private System.Void Log(System.String tag, System.Object message) { }
        private System.Void LogWarning(System.String tag, System.Object message) { }
        private System.Void LogError(System.String tag, System.Object message) { }
        private System.Void LogFormat(UnityEngine.LogType logType, System.String format, System.Object[] args) { }
        private System.Void LogException(System.Exception exception) { }

    }

    // TypeToken: 0x200013A
    public interface ILogHandler
    {
        // Methods
        private System.Void LogFormat(UnityEngine.LogType logType, UnityEngine.Object context, System.String format, System.Object[] args) { }
        private System.Void LogException(System.Exception exception, UnityEngine.Object context) { }

    }

    // TypeToken: 0x200013B
    public class Logger, ILogger, ILogHandler
    {
        // Fields
        private UnityEngine.ILogHandler <logHandler>k__BackingField;        // 0x10
        private System.Boolean <logEnabled>k__BackingField;        // 0x18
        private UnityEngine.LogType <filterLogType>k__BackingField;        // 0x1C

        // Methods
        private System.Void .ctor(UnityEngine.ILogHandler logHandler) { }
        private UnityEngine.ILogHandler get_logHandler() { }
        private System.Void set_logHandler(UnityEngine.ILogHandler value) { }
        private System.Boolean get_logEnabled() { }
        private System.Void set_logEnabled(System.Boolean value) { }
        private UnityEngine.LogType get_filterLogType() { }
        private System.Void set_filterLogType(UnityEngine.LogType value) { }
        private System.Boolean IsLogTypeAllowed(UnityEngine.LogType logType) { }
        private System.String GetString(System.Object message) { }
        private System.Void Log(UnityEngine.LogType logType, System.Object message) { }
        private System.Void Log(UnityEngine.LogType logType, System.Object message, UnityEngine.Object context) { }
        private System.Void Log(UnityEngine.LogType logType, System.String tag, System.Object message, UnityEngine.Object context) { }
        private System.Void Log(System.String tag, System.Object message) { }
        private System.Void LogWarning(System.String tag, System.Object message) { }
        private System.Void LogError(System.String tag, System.Object message) { }
        private System.Void LogException(System.Exception exception) { }
        private System.Void LogException(System.Exception exception, UnityEngine.Object context) { }
        private System.Void LogFormat(UnityEngine.LogType logType, System.String format, System.Object[] args) { }
        private System.Void LogFormat(UnityEngine.LogType logType, UnityEngine.Object context, System.String format, System.Object[] args) { }

    }

    // TypeToken: 0x200013C
    public class UnityLogWriter : TextWriter
    {
        // Methods
        private System.Void WriteStringToUnityLog(System.String s) { }
        private System.Void WriteStringToUnityLogImpl(System.String s) { }
        private System.Void Init() { }
        private System.Text.Encoding get_Encoding() { }
        private System.Void Write(System.Char value) { }
        private System.Void Write(System.String s) { }
        private System.Void Write(System.Char[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200013D
    public struct Color, IEquatable`1, IFormattable
    {
        // Fields
        public System.Single r;        // 0x10
        public System.Single g;        // 0x14
        public System.Single b;        // 0x18
        public System.Single a;        // 0x1C

        // Methods
        private System.Void .ctor(System.Single r, System.Single g, System.Single b, System.Single a) { }
        private System.Void .ctor(System.Single r, System.Single g, System.Single b) { }
        private System.String ToString() { }
        private System.String ToString(System.String format) { }
        private System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(UnityEngine.Color other) { }
        private UnityEngine.Color op_Addition(UnityEngine.Color a, UnityEngine.Color b) { }
        private UnityEngine.Color op_Subtraction(UnityEngine.Color a, UnityEngine.Color b) { }
        private UnityEngine.Color op_Multiply(UnityEngine.Color a, UnityEngine.Color b) { }
        private UnityEngine.Color op_Multiply(UnityEngine.Color a, System.Single b) { }
        private UnityEngine.Color op_Multiply(System.Single b, UnityEngine.Color a) { }
        private UnityEngine.Color op_Division(UnityEngine.Color a, System.Single b) { }
        private System.Boolean op_Equality(UnityEngine.Color lhs, UnityEngine.Color rhs) { }
        private System.Boolean op_Inequality(UnityEngine.Color lhs, UnityEngine.Color rhs) { }
        private UnityEngine.Color Lerp(UnityEngine.Color a, UnityEngine.Color b, System.Single t) { }
        private UnityEngine.Color LerpUnclamped(UnityEngine.Color a, UnityEngine.Color b, System.Single t) { }
        private UnityEngine.Color RGBMultiplied(System.Single multiplier) { }
        private UnityEngine.Color AlphaMultiplied(System.Single multiplier) { }
        private UnityEngine.Color RGBMultiplied(UnityEngine.Color multiplier) { }
        private UnityEngine.Color get_red() { }
        private UnityEngine.Color get_green() { }
        private UnityEngine.Color get_blue() { }
        private UnityEngine.Color get_white() { }
        private UnityEngine.Color get_black() { }
        private UnityEngine.Color get_yellow() { }
        private UnityEngine.Color get_cyan() { }
        private UnityEngine.Color get_magenta() { }
        private UnityEngine.Color get_gray() { }
        private UnityEngine.Color get_grey() { }
        private UnityEngine.Color get_clear() { }
        private System.Single get_grayscale() { }
        private UnityEngine.Color get_linear() { }
        private UnityEngine.Color get_gamma() { }
        private System.Single get_maxColorComponent() { }
        private UnityEngine.Vector4 op_Implicit(UnityEngine.Color c) { }
        private UnityEngine.Color op_Implicit(UnityEngine.Vector4 v) { }
        private System.Single get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, System.Single value) { }
        private System.Void RGBToHSV(UnityEngine.Color rgbColor, System.Single& H, System.Single& S, System.Single& V) { }
        private System.Void RGBToHSVHelper(System.Single offset, System.Single dominantcolor, System.Single colorone, System.Single colortwo, System.Single& H, System.Single& S, System.Single& V) { }
        private UnityEngine.Color HSVToRGB(System.Single H, System.Single S, System.Single V) { }
        private UnityEngine.Color HSVToRGB(System.Single H, System.Single S, System.Single V, System.Boolean hdr) { }

    }

    // TypeToken: 0x200013E
    public struct Color32, IFormattable
    {
        // Fields
        private System.Int32 rgba;        // 0x10
        public System.Byte r;        // 0x10
        public System.Byte g;        // 0x11
        public System.Byte b;        // 0x12
        public System.Byte a;        // 0x13

        // Methods
        private System.Void .ctor(System.Byte r, System.Byte g, System.Byte b, System.Byte a) { }
        private UnityEngine.Color32 op_Implicit(UnityEngine.Color c) { }
        private UnityEngine.Color op_Implicit(UnityEngine.Color32 c) { }
        private UnityEngine.Color32 Lerp(UnityEngine.Color32 a, UnityEngine.Color32 b, System.Single t) { }
        private System.String ToString() { }
        private System.String ToString(System.String format, System.IFormatProvider formatProvider) { }

    }

    // TypeToken: 0x200013F
    public class ColorUtility
    {
        // Methods
        private System.Boolean DoTryParseHtmlColor(System.String htmlString, UnityEngine.Color32& color) { }
        private System.Boolean TryParseHtmlString(System.String htmlString, UnityEngine.Color& color) { }
        private System.String ToHtmlStringRGBA(UnityEngine.Color color) { }

    }

    // TypeToken: 0x2000140
    public struct GradientColorKey
    {
        // Fields
        public UnityEngine.Color color;        // 0x10
        public System.Single time;        // 0x20

        // Methods
        private System.Void .ctor(UnityEngine.Color col, System.Single time) { }

    }

    // TypeToken: 0x2000141
    public struct GradientAlphaKey
    {
        // Fields
        public System.Single alpha;        // 0x10
        public System.Single time;        // 0x14

        // Methods
        private System.Void .ctor(System.Single alpha, System.Single time) { }

    }

    // TypeToken: 0x2000142
    public struct GradientMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.GradientMode Blend;        // 0x0
        public static UnityEngine.GradientMode Fixed;        // 0x0

    }

    // TypeToken: 0x2000143
    public class Gradient, IEquatable`1
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10

        // Methods
        private System.IntPtr Init() { }
        private System.Void Cleanup() { }
        private System.Boolean Internal_Equals(System.IntPtr other) { }
        private System.Void .ctor() { }
        private System.Void Finalize() { }
        private UnityEngine.Color Evaluate(System.Single time) { }
        private UnityEngine.GradientColorKey[] get_colorKeys() { }
        private System.Void set_colorKeys(UnityEngine.GradientColorKey[] value) { }
        private UnityEngine.GradientAlphaKey[] get_alphaKeys() { }
        private System.Void set_alphaKeys(UnityEngine.GradientAlphaKey[] value) { }
        private UnityEngine.GradientMode get_mode() { }
        private System.Void set_mode(UnityEngine.GradientMode value) { }
        private System.Void SetKeys(UnityEngine.GradientColorKey[] colorKeys, UnityEngine.GradientAlphaKey[] alphaKeys) { }
        private System.Boolean Equals(System.Object o) { }
        private System.Boolean Equals(UnityEngine.Gradient other) { }
        private System.Int32 GetHashCode() { }
        private System.Void Evaluate_Injected(System.Single time, UnityEngine.Color& ret) { }

    }

    // TypeToken: 0x2000144
    public struct FrustumPlanes
    {
        // Fields
        public System.Single left;        // 0x10
        public System.Single right;        // 0x14
        public System.Single bottom;        // 0x18
        public System.Single top;        // 0x1C
        public System.Single zNear;        // 0x20
        public System.Single zFar;        // 0x24

    }

    // TypeToken: 0x2000145
    public struct Matrix4x4, IEquatable`1, IFormattable
    {
        // Fields
        public System.Single m00;        // 0x10
        public System.Single m10;        // 0x14
        public System.Single m20;        // 0x18
        public System.Single m30;        // 0x1C
        public System.Single m01;        // 0x20
        public System.Single m11;        // 0x24
        public System.Single m21;        // 0x28
        public System.Single m31;        // 0x2C
        public System.Single m02;        // 0x30
        public System.Single m12;        // 0x34
        public System.Single m22;        // 0x38
        public System.Single m32;        // 0x3C
        public System.Single m03;        // 0x40
        public System.Single m13;        // 0x44
        public System.Single m23;        // 0x48
        public System.Single m33;        // 0x4C
        private static readonly UnityEngine.Matrix4x4 zeroMatrix;        // 0x0
        private static readonly UnityEngine.Matrix4x4 identityMatrix;        // 0x40

        // Methods
        private UnityEngine.Quaternion GetRotation() { }
        private UnityEngine.Vector3 GetLossyScale() { }
        private System.Single GetDeterminant() { }
        private UnityEngine.FrustumPlanes DecomposeProjection() { }
        private UnityEngine.Matrix4x4 HGMultiplyMatrix4x4Fast(UnityEngine.Matrix4x4 rhs) { }
        private UnityEngine.Quaternion get_rotation() { }
        private UnityEngine.Vector3 get_lossyScale() { }
        private System.Single get_determinant() { }
        private UnityEngine.FrustumPlanes get_decomposeProjection() { }
        private UnityEngine.Matrix4x4 TRS(UnityEngine.Vector3 pos, UnityEngine.Quaternion q, UnityEngine.Vector3 s) { }
        private System.Void SetTRS(UnityEngine.Vector3 pos, UnityEngine.Quaternion q, UnityEngine.Vector3 s) { }
        private System.Boolean Inverse3DAffine(UnityEngine.Matrix4x4 input, UnityEngine.Matrix4x4& result) { }
        private UnityEngine.Matrix4x4 Inverse(UnityEngine.Matrix4x4 m) { }
        private UnityEngine.Matrix4x4 get_inverse() { }
        private UnityEngine.Matrix4x4 Transpose(UnityEngine.Matrix4x4 m) { }
        private UnityEngine.Matrix4x4 get_transpose() { }
        private UnityEngine.Matrix4x4 Ortho(System.Single left, System.Single right, System.Single bottom, System.Single top, System.Single zNear, System.Single zFar) { }
        private UnityEngine.Matrix4x4 Perspective(System.Single fov, System.Single aspect, System.Single zNear, System.Single zFar) { }
        private UnityEngine.Matrix4x4 LookAt(UnityEngine.Vector3 from, UnityEngine.Vector3 to, UnityEngine.Vector3 up) { }
        private UnityEngine.Matrix4x4 Frustum(System.Single left, System.Single right, System.Single bottom, System.Single top, System.Single zNear, System.Single zFar) { }
        private UnityEngine.Matrix4x4 Frustum(UnityEngine.FrustumPlanes fp) { }
        private System.Void .ctor(UnityEngine.Vector4 column0, UnityEngine.Vector4 column1, UnityEngine.Vector4 column2, UnityEngine.Vector4 column3) { }
        private System.Single get_Item(System.Int32 row, System.Int32 column) { }
        private System.Void set_Item(System.Int32 row, System.Int32 column, System.Single value) { }
        private System.Single get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, System.Single value) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(UnityEngine.Matrix4x4 other) { }
        private UnityEngine.Matrix4x4 op_Multiply(UnityEngine.Matrix4x4 lhs, UnityEngine.Matrix4x4 rhs) { }
        private UnityEngine.Vector4 op_Multiply(UnityEngine.Matrix4x4 lhs, UnityEngine.Vector4 vector) { }
        private System.Boolean op_Equality(UnityEngine.Matrix4x4 lhs, UnityEngine.Matrix4x4 rhs) { }
        private System.Boolean op_Inequality(UnityEngine.Matrix4x4 lhs, UnityEngine.Matrix4x4 rhs) { }
        private UnityEngine.Vector4 GetColumn(System.Int32 index) { }
        private UnityEngine.Vector4 GetRow(System.Int32 index) { }
        private UnityEngine.Vector3 GetPosition() { }
        private System.Void SetColumn(System.Int32 index, UnityEngine.Vector4 column) { }
        private System.Void SetRow(System.Int32 index, UnityEngine.Vector4 row) { }
        private UnityEngine.Vector3 MultiplyPoint(UnityEngine.Vector3 point) { }
        private UnityEngine.Vector3 MultiplyPoint3x4(UnityEngine.Vector3 point) { }
        private UnityEngine.Vector3 MultiplyVector(UnityEngine.Vector3 vector) { }
        private UnityEngine.Matrix4x4 Scale(UnityEngine.Vector3 vector) { }
        private UnityEngine.Matrix4x4 Translate(UnityEngine.Vector3 vector) { }
        private UnityEngine.Matrix4x4 Rotate(UnityEngine.Quaternion q) { }
        private UnityEngine.Matrix4x4 get_zero() { }
        private UnityEngine.Matrix4x4 get_identity() { }
        private System.String ToString() { }
        private System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        private System.Void .cctor() { }
        private System.Void GetRotation_Injected(UnityEngine.Matrix4x4& _unity_self, UnityEngine.Quaternion& ret) { }
        private System.Void GetLossyScale_Injected(UnityEngine.Matrix4x4& _unity_self, UnityEngine.Vector3& ret) { }
        private System.Single GetDeterminant_Injected(UnityEngine.Matrix4x4& _unity_self) { }
        private System.Void DecomposeProjection_Injected(UnityEngine.Matrix4x4& _unity_self, UnityEngine.FrustumPlanes& ret) { }
        private System.Void HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4& _unity_self, UnityEngine.Matrix4x4& rhs, UnityEngine.Matrix4x4& ret) { }
        private System.Void TRS_Injected(UnityEngine.Vector3& pos, UnityEngine.Quaternion& q, UnityEngine.Vector3& s, UnityEngine.Matrix4x4& ret) { }
        private System.Boolean Inverse3DAffine_Injected(UnityEngine.Matrix4x4& input, UnityEngine.Matrix4x4& result) { }
        private System.Void Inverse_Injected(UnityEngine.Matrix4x4& m, UnityEngine.Matrix4x4& ret) { }
        private System.Void Transpose_Injected(UnityEngine.Matrix4x4& m, UnityEngine.Matrix4x4& ret) { }
        private System.Void Ortho_Injected(System.Single left, System.Single right, System.Single bottom, System.Single top, System.Single zNear, System.Single zFar, UnityEngine.Matrix4x4& ret) { }
        private System.Void Perspective_Injected(System.Single fov, System.Single aspect, System.Single zNear, System.Single zFar, UnityEngine.Matrix4x4& ret) { }
        private System.Void LookAt_Injected(UnityEngine.Vector3& from, UnityEngine.Vector3& to, UnityEngine.Vector3& up, UnityEngine.Matrix4x4& ret) { }
        private System.Void Frustum_Injected(System.Single left, System.Single right, System.Single bottom, System.Single top, System.Single zNear, System.Single zFar, UnityEngine.Matrix4x4& ret) { }

    }

    // TypeToken: 0x2000146
    public struct Vector3, IEquatable`1, IFormattable
    {
        // Fields
        public static System.Single kEpsilon;        // 0x0
        public static System.Single kEpsilonNormalSqrt;        // 0x0
        public System.Single x;        // 0x10
        public System.Single y;        // 0x14
        public System.Single z;        // 0x18
        private static readonly UnityEngine.Vector3 zeroVector;        // 0x0
        private static readonly UnityEngine.Vector3 oneVector;        // 0xC
        private static readonly UnityEngine.Vector3 upVector;        // 0x18
        private static readonly UnityEngine.Vector3 downVector;        // 0x24
        private static readonly UnityEngine.Vector3 leftVector;        // 0x30
        private static readonly UnityEngine.Vector3 rightVector;        // 0x3C
        private static readonly UnityEngine.Vector3 forwardVector;        // 0x48
        private static readonly UnityEngine.Vector3 backVector;        // 0x54
        private static readonly UnityEngine.Vector3 positiveInfinityVector;        // 0x60
        private static readonly UnityEngine.Vector3 negativeInfinityVector;        // 0x6C

        // Methods
        private UnityEngine.Vector3 Slerp(UnityEngine.Vector3 a, UnityEngine.Vector3 b, System.Single t) { }
        private UnityEngine.Vector3 SlerpUnclamped(UnityEngine.Vector3 a, UnityEngine.Vector3 b, System.Single t) { }
        private System.Void OrthoNormalize2(UnityEngine.Vector3& a, UnityEngine.Vector3& b) { }
        private System.Void OrthoNormalize(UnityEngine.Vector3& normal, UnityEngine.Vector3& tangent) { }
        private System.Void OrthoNormalize3(UnityEngine.Vector3& a, UnityEngine.Vector3& b, UnityEngine.Vector3& c) { }
        private System.Void OrthoNormalize(UnityEngine.Vector3& normal, UnityEngine.Vector3& tangent, UnityEngine.Vector3& binormal) { }
        private UnityEngine.Vector3 RotateTowards(UnityEngine.Vector3 current, UnityEngine.Vector3 target, System.Single maxRadiansDelta, System.Single maxMagnitudeDelta) { }
        private UnityEngine.Vector3 Lerp(UnityEngine.Vector3 a, UnityEngine.Vector3 b, System.Single t) { }
        private UnityEngine.Vector3 LerpUnclamped(UnityEngine.Vector3 a, UnityEngine.Vector3 b, System.Single t) { }
        private UnityEngine.Vector3 MoveTowards(UnityEngine.Vector3 current, UnityEngine.Vector3 target, System.Single maxDistanceDelta) { }
        private UnityEngine.Vector3 SmoothDamp(UnityEngine.Vector3 current, UnityEngine.Vector3 target, UnityEngine.Vector3& currentVelocity, System.Single smoothTime, System.Single maxSpeed) { }
        private UnityEngine.Vector3 SmoothDamp(UnityEngine.Vector3 current, UnityEngine.Vector3 target, UnityEngine.Vector3& currentVelocity, System.Single smoothTime) { }
        private UnityEngine.Vector3 SmoothDamp(UnityEngine.Vector3 current, UnityEngine.Vector3 target, UnityEngine.Vector3& currentVelocity, System.Single smoothTime, System.Single maxSpeed, System.Single deltaTime) { }
        private System.Single get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, System.Single value) { }
        private System.Void .ctor(System.Single x, System.Single y, System.Single z) { }
        private System.Void .ctor(System.Single x, System.Single y) { }
        private System.Void Set(System.Single newX, System.Single newY, System.Single newZ) { }
        private UnityEngine.Vector3 Scale(UnityEngine.Vector3 a, UnityEngine.Vector3 b) { }
        private System.Void Scale(UnityEngine.Vector3 scale) { }
        private UnityEngine.Vector3 Cross(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(UnityEngine.Vector3 other) { }
        private UnityEngine.Vector3 Reflect(UnityEngine.Vector3 inDirection, UnityEngine.Vector3 inNormal) { }
        private UnityEngine.Vector3 Normalize(UnityEngine.Vector3 value) { }
        private System.Void Normalize() { }
        private UnityEngine.Vector3 get_normalized() { }
        private System.Single Dot(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs) { }
        private UnityEngine.Vector3 Project(UnityEngine.Vector3 vector, UnityEngine.Vector3 onNormal) { }
        private UnityEngine.Vector3 ProjectOnPlane(UnityEngine.Vector3 vector, UnityEngine.Vector3 planeNormal) { }
        private System.Single Angle(UnityEngine.Vector3 from, UnityEngine.Vector3 to) { }
        private System.Single SignedAngle(UnityEngine.Vector3 from, UnityEngine.Vector3 to, UnityEngine.Vector3 axis) { }
        private System.Single Distance(UnityEngine.Vector3 a, UnityEngine.Vector3 b) { }
        private UnityEngine.Vector3 ClampMagnitude(UnityEngine.Vector3 vector, System.Single maxLength) { }
        private System.Single Magnitude(UnityEngine.Vector3 vector) { }
        private System.Single get_magnitude() { }
        private System.Single SqrMagnitude(UnityEngine.Vector3 vector) { }
        private System.Single get_sqrMagnitude() { }
        private UnityEngine.Vector3 Min(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs) { }
        private UnityEngine.Vector3 Max(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs) { }
        private UnityEngine.Vector3 get_zero() { }
        private UnityEngine.Vector3 get_one() { }
        private UnityEngine.Vector3 get_forward() { }
        private UnityEngine.Vector3 get_back() { }
        private UnityEngine.Vector3 get_up() { }
        private UnityEngine.Vector3 get_down() { }
        private UnityEngine.Vector3 get_left() { }
        private UnityEngine.Vector3 get_right() { }
        private UnityEngine.Vector3 get_positiveInfinity() { }
        private UnityEngine.Vector3 get_negativeInfinity() { }
        private UnityEngine.Vector3 op_Addition(UnityEngine.Vector3 a, UnityEngine.Vector3 b) { }
        private UnityEngine.Vector3 op_Subtraction(UnityEngine.Vector3 a, UnityEngine.Vector3 b) { }
        private UnityEngine.Vector3 op_UnaryNegation(UnityEngine.Vector3 a) { }
        private UnityEngine.Vector3 op_Multiply(UnityEngine.Vector3 a, System.Single d) { }
        private UnityEngine.Vector3 op_Multiply(System.Single d, UnityEngine.Vector3 a) { }
        private UnityEngine.Vector3 op_Division(UnityEngine.Vector3 a, System.Single d) { }
        private System.Boolean op_Equality(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs) { }
        private System.Boolean op_Inequality(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs) { }
        private System.String ToString() { }
        private System.String ToString(System.String format) { }
        private System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        private UnityEngine.Vector3 get_fwd() { }
        private System.Single AngleBetween(UnityEngine.Vector3 from, UnityEngine.Vector3 to) { }
        private UnityEngine.Vector3 Exclude(UnityEngine.Vector3 excludeThis, UnityEngine.Vector3 fromThat) { }
        private System.Void .cctor() { }
        private System.Void Slerp_Injected(UnityEngine.Vector3& a, UnityEngine.Vector3& b, System.Single t, UnityEngine.Vector3& ret) { }
        private System.Void SlerpUnclamped_Injected(UnityEngine.Vector3& a, UnityEngine.Vector3& b, System.Single t, UnityEngine.Vector3& ret) { }
        private System.Void RotateTowards_Injected(UnityEngine.Vector3& current, UnityEngine.Vector3& target, System.Single maxRadiansDelta, System.Single maxMagnitudeDelta, UnityEngine.Vector3& ret) { }

    }

    // TypeToken: 0x2000147
    public struct Quaternion, IEquatable`1, IFormattable
    {
        // Fields
        public System.Single x;        // 0x10
        public System.Single y;        // 0x14
        public System.Single z;        // 0x18
        public System.Single w;        // 0x1C
        private static readonly UnityEngine.Quaternion identityQuaternion;        // 0x0
        public static System.Single kEpsilon;        // 0x0

        // Methods
        private UnityEngine.Quaternion FromToRotation(UnityEngine.Vector3 fromDirection, UnityEngine.Vector3 toDirection) { }
        private UnityEngine.Quaternion Inverse(UnityEngine.Quaternion rotation) { }
        private UnityEngine.Quaternion Slerp(UnityEngine.Quaternion a, UnityEngine.Quaternion b, System.Single t) { }
        private UnityEngine.Quaternion SlerpUnclamped(UnityEngine.Quaternion a, UnityEngine.Quaternion b, System.Single t) { }
        private UnityEngine.Quaternion Lerp(UnityEngine.Quaternion a, UnityEngine.Quaternion b, System.Single t) { }
        private UnityEngine.Quaternion LerpUnclamped(UnityEngine.Quaternion a, UnityEngine.Quaternion b, System.Single t) { }
        private UnityEngine.Quaternion Internal_FromEulerRad(UnityEngine.Vector3 euler) { }
        private UnityEngine.Vector3 Internal_ToEulerRad(UnityEngine.Quaternion rotation) { }
        private System.Void Internal_ToAxisAngleRad(UnityEngine.Quaternion q, UnityEngine.Vector3& axis, System.Single& angle) { }
        private UnityEngine.Quaternion AngleAxis(System.Single angle, UnityEngine.Vector3 axis) { }
        private UnityEngine.Quaternion LookRotation(UnityEngine.Vector3 forward, UnityEngine.Vector3 upwards) { }
        private UnityEngine.Quaternion LookRotation(UnityEngine.Vector3 forward) { }
        private System.Single get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, System.Single value) { }
        private System.Void .ctor(System.Single x, System.Single y, System.Single z, System.Single w) { }
        private System.Void Set(System.Single newX, System.Single newY, System.Single newZ, System.Single newW) { }
        private UnityEngine.Quaternion get_identity() { }
        private UnityEngine.Quaternion op_Multiply(UnityEngine.Quaternion lhs, UnityEngine.Quaternion rhs) { }
        private UnityEngine.Vector3 op_Multiply(UnityEngine.Quaternion rotation, UnityEngine.Vector3 point) { }
        private System.Boolean IsEqualUsingDot(System.Single dot) { }
        private System.Boolean op_Equality(UnityEngine.Quaternion lhs, UnityEngine.Quaternion rhs) { }
        private System.Boolean op_Inequality(UnityEngine.Quaternion lhs, UnityEngine.Quaternion rhs) { }
        private System.Single Dot(UnityEngine.Quaternion a, UnityEngine.Quaternion b) { }
        private System.Void SetLookRotation(UnityEngine.Vector3 view) { }
        private System.Void SetLookRotation(UnityEngine.Vector3 view, UnityEngine.Vector3 up) { }
        private System.Single Angle(UnityEngine.Quaternion a, UnityEngine.Quaternion b) { }
        private UnityEngine.Vector3 Internal_MakePositive(UnityEngine.Vector3 euler) { }
        private UnityEngine.Vector3 get_eulerAngles() { }
        private System.Void set_eulerAngles(UnityEngine.Vector3 value) { }
        private UnityEngine.Quaternion Euler(System.Single x, System.Single y, System.Single z) { }
        private UnityEngine.Quaternion Euler(UnityEngine.Vector3 euler) { }
        private System.Void ToAngleAxis(System.Single& angle, UnityEngine.Vector3& axis) { }
        private System.Void SetFromToRotation(UnityEngine.Vector3 fromDirection, UnityEngine.Vector3 toDirection) { }
        private UnityEngine.Quaternion RotateTowards(UnityEngine.Quaternion from, UnityEngine.Quaternion to, System.Single maxDegreesDelta) { }
        private UnityEngine.Quaternion Normalize(UnityEngine.Quaternion q) { }
        private System.Void Normalize() { }
        private UnityEngine.Quaternion get_normalized() { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(UnityEngine.Quaternion other) { }
        private System.String ToString() { }
        private System.String ToString(System.String format) { }
        private System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        private UnityEngine.Quaternion EulerRotation(System.Single x, System.Single y, System.Single z) { }
        private UnityEngine.Quaternion EulerRotation(UnityEngine.Vector3 euler) { }
        private System.Void SetEulerRotation(System.Single x, System.Single y, System.Single z) { }
        private System.Void SetEulerRotation(UnityEngine.Vector3 euler) { }
        private UnityEngine.Vector3 ToEuler() { }
        private UnityEngine.Quaternion EulerAngles(System.Single x, System.Single y, System.Single z) { }
        private UnityEngine.Quaternion EulerAngles(UnityEngine.Vector3 euler) { }
        private System.Void ToAxisAngle(UnityEngine.Vector3& axis, System.Single& angle) { }
        private System.Void SetEulerAngles(System.Single x, System.Single y, System.Single z) { }
        private System.Void SetEulerAngles(UnityEngine.Vector3 euler) { }
        private UnityEngine.Vector3 ToEulerAngles(UnityEngine.Quaternion rotation) { }
        private UnityEngine.Vector3 ToEulerAngles() { }
        private System.Void SetAxisAngle(UnityEngine.Vector3 axis, System.Single angle) { }
        private UnityEngine.Quaternion AxisAngle(UnityEngine.Vector3 axis, System.Single angle) { }
        private System.Void .cctor() { }
        private System.Void FromToRotation_Injected(UnityEngine.Vector3& fromDirection, UnityEngine.Vector3& toDirection, UnityEngine.Quaternion& ret) { }
        private System.Void Inverse_Injected(UnityEngine.Quaternion& rotation, UnityEngine.Quaternion& ret) { }
        private System.Void Slerp_Injected(UnityEngine.Quaternion& a, UnityEngine.Quaternion& b, System.Single t, UnityEngine.Quaternion& ret) { }
        private System.Void SlerpUnclamped_Injected(UnityEngine.Quaternion& a, UnityEngine.Quaternion& b, System.Single t, UnityEngine.Quaternion& ret) { }
        private System.Void Lerp_Injected(UnityEngine.Quaternion& a, UnityEngine.Quaternion& b, System.Single t, UnityEngine.Quaternion& ret) { }
        private System.Void LerpUnclamped_Injected(UnityEngine.Quaternion& a, UnityEngine.Quaternion& b, System.Single t, UnityEngine.Quaternion& ret) { }
        private System.Void Internal_FromEulerRad_Injected(UnityEngine.Vector3& euler, UnityEngine.Quaternion& ret) { }
        private System.Void Internal_ToEulerRad_Injected(UnityEngine.Quaternion& rotation, UnityEngine.Vector3& ret) { }
        private System.Void Internal_ToAxisAngleRad_Injected(UnityEngine.Quaternion& q, UnityEngine.Vector3& axis, System.Single& angle) { }
        private System.Void AngleAxis_Injected(System.Single angle, UnityEngine.Vector3& axis, UnityEngine.Quaternion& ret) { }
        private System.Void LookRotation_Injected(UnityEngine.Vector3& forward, UnityEngine.Vector3& upwards, UnityEngine.Quaternion& ret) { }

    }

    // TypeToken: 0x2000148
    public struct Mathf
    {
        // Fields
        public static System.Single PI;        // 0x0
        public static System.Single Infinity;        // 0x0
        public static System.Single NegativeInfinity;        // 0x0
        public static System.Single Deg2Rad;        // 0x0
        public static System.Single Rad2Deg;        // 0x0
        public static readonly System.Single Epsilon;        // 0x0

        // Methods
        private System.Int32 ClosestPowerOfTwo(System.Int32 value) { }
        private System.Boolean IsPowerOfTwo(System.Int32 value) { }
        private System.Int32 NextPowerOfTwo(System.Int32 value) { }
        private System.Single GammaToLinearSpace(System.Single value) { }
        private System.Single LinearToGammaSpace(System.Single value) { }
        private UnityEngine.Color CorrelatedColorTemperatureToRGB(System.Single kelvin) { }
        private System.UInt16 FloatToHalf(System.Single val) { }
        private System.Single HalfToFloat(System.UInt16 val) { }
        private System.Single PerlinNoise(System.Single x, System.Single y) { }
        private System.Single Sin(System.Single f) { }
        private System.Single Cos(System.Single f) { }
        private System.Single Tan(System.Single f) { }
        private System.Single Asin(System.Single f) { }
        private System.Single Acos(System.Single f) { }
        private System.Single Atan(System.Single f) { }
        private System.Single Atan2(System.Single y, System.Single x) { }
        private System.Single Sqrt(System.Single f) { }
        private System.Single Abs(System.Single f) { }
        private System.Int32 Abs(System.Int32 value) { }
        private System.Single Min(System.Single a, System.Single b) { }
        private System.Single Min(System.Single[] values) { }
        private System.Int32 Min(System.Int32 a, System.Int32 b) { }
        private System.Int32 Min(System.Int32[] values) { }
        private System.Single Max(System.Single a, System.Single b) { }
        private System.Single Max(System.Single[] values) { }
        private System.Int32 Max(System.Int32 a, System.Int32 b) { }
        private System.Int32 Max(System.Int32[] values) { }
        private System.Single Pow(System.Single f, System.Single p) { }
        private System.Single Exp(System.Single power) { }
        private System.Single Log(System.Single f, System.Single p) { }
        private System.Single Log(System.Single f) { }
        private System.Single Log10(System.Single f) { }
        private System.Single Ceil(System.Single f) { }
        private System.Single Floor(System.Single f) { }
        private System.Single Round(System.Single f) { }
        private System.Int32 CeilToInt(System.Single f) { }
        private System.Int32 FloorToInt(System.Single f) { }
        private System.Int32 RoundToInt(System.Single f) { }
        private System.Single Sign(System.Single f) { }
        private System.Single Clamp(System.Single value, System.Single min, System.Single max) { }
        private System.Int32 Clamp(System.Int32 value, System.Int32 min, System.Int32 max) { }
        private System.Single Clamp01(System.Single value) { }
        private System.Single Lerp(System.Single a, System.Single b, System.Single t) { }
        private System.Single LerpUnclamped(System.Single a, System.Single b, System.Single t) { }
        private System.Single LerpAngle(System.Single a, System.Single b, System.Single t) { }
        private System.Single MoveTowards(System.Single current, System.Single target, System.Single maxDelta) { }
        private System.Single MoveTowardsAngle(System.Single current, System.Single target, System.Single maxDelta) { }
        private System.Single SmoothStep(System.Single from, System.Single to, System.Single t) { }
        private System.Single Gamma(System.Single value, System.Single absmax, System.Single gamma) { }
        private System.Boolean Approximately(System.Single a, System.Single b) { }
        private System.Single SmoothDamp(System.Single current, System.Single target, System.Single& currentVelocity, System.Single smoothTime, System.Single maxSpeed) { }
        private System.Single SmoothDamp(System.Single current, System.Single target, System.Single& currentVelocity, System.Single smoothTime) { }
        private System.Single SmoothDamp(System.Single current, System.Single target, System.Single& currentVelocity, System.Single smoothTime, System.Single maxSpeed, System.Single deltaTime) { }
        private System.Single SmoothDampAngle(System.Single current, System.Single target, System.Single& currentVelocity, System.Single smoothTime, System.Single maxSpeed) { }
        private System.Single SmoothDampAngle(System.Single current, System.Single target, System.Single& currentVelocity, System.Single smoothTime) { }
        private System.Single SmoothDampAngle(System.Single current, System.Single target, System.Single& currentVelocity, System.Single smoothTime, System.Single maxSpeed, System.Single deltaTime) { }
        private System.Single Repeat(System.Single t, System.Single length) { }
        private System.Single PingPong(System.Single t, System.Single length) { }
        private System.Single InverseLerp(System.Single a, System.Single b, System.Single value) { }
        private System.Single DeltaAngle(System.Single current, System.Single target) { }
        private System.Boolean LineIntersection(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4, UnityEngine.Vector2& result) { }
        private System.Boolean LineSegmentIntersection(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4, UnityEngine.Vector2& result) { }
        private System.Int64 RandomToLong(System.Random r) { }
        private System.Single ClampToFloat(System.Double value) { }
        private System.Int32 ClampToInt(System.Int64 value) { }
        private System.UInt32 ClampToUInt(System.Int64 value) { }
        private System.Void .cctor() { }
        private System.Void CorrelatedColorTemperatureToRGB_Injected(System.Single kelvin, UnityEngine.Color& ret) { }

    }

    // TypeToken: 0x2000149
    public struct Vector2, IEquatable`1, IFormattable
    {
        // Fields
        public System.Single x;        // 0x10
        public System.Single y;        // 0x14
        private static readonly UnityEngine.Vector2 zeroVector;        // 0x0
        private static readonly UnityEngine.Vector2 oneVector;        // 0x8
        private static readonly UnityEngine.Vector2 upVector;        // 0x10
        private static readonly UnityEngine.Vector2 downVector;        // 0x18
        private static readonly UnityEngine.Vector2 leftVector;        // 0x20
        private static readonly UnityEngine.Vector2 rightVector;        // 0x28
        private static readonly UnityEngine.Vector2 positiveInfinityVector;        // 0x30
        private static readonly UnityEngine.Vector2 negativeInfinityVector;        // 0x38
        public static System.Single kEpsilon;        // 0x0
        public static System.Single kEpsilonNormalSqrt;        // 0x0

        // Methods
        private System.Single get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, System.Single value) { }
        private System.Void .ctor(System.Single x, System.Single y) { }
        private System.Void Set(System.Single newX, System.Single newY) { }
        private UnityEngine.Vector2 Lerp(UnityEngine.Vector2 a, UnityEngine.Vector2 b, System.Single t) { }
        private UnityEngine.Vector2 LerpUnclamped(UnityEngine.Vector2 a, UnityEngine.Vector2 b, System.Single t) { }
        private UnityEngine.Vector2 MoveTowards(UnityEngine.Vector2 current, UnityEngine.Vector2 target, System.Single maxDistanceDelta) { }
        private UnityEngine.Vector2 Scale(UnityEngine.Vector2 a, UnityEngine.Vector2 b) { }
        private System.Void Scale(UnityEngine.Vector2 scale) { }
        private System.Void Normalize() { }
        private UnityEngine.Vector2 get_normalized() { }
        private System.String ToString() { }
        private System.String ToString(System.String format) { }
        private System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(UnityEngine.Vector2 other) { }
        private UnityEngine.Vector2 Reflect(UnityEngine.Vector2 inDirection, UnityEngine.Vector2 inNormal) { }
        private UnityEngine.Vector2 Perpendicular(UnityEngine.Vector2 inDirection) { }
        private System.Single Dot(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs) { }
        private System.Single get_magnitude() { }
        private System.Single get_sqrMagnitude() { }
        private System.Single Angle(UnityEngine.Vector2 from, UnityEngine.Vector2 to) { }
        private System.Single SignedAngle(UnityEngine.Vector2 from, UnityEngine.Vector2 to) { }
        private System.Single Distance(UnityEngine.Vector2 a, UnityEngine.Vector2 b) { }
        private UnityEngine.Vector2 ClampMagnitude(UnityEngine.Vector2 vector, System.Single maxLength) { }
        private System.Single SqrMagnitude(UnityEngine.Vector2 a) { }
        private System.Single SqrMagnitude() { }
        private UnityEngine.Vector2 Min(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs) { }
        private UnityEngine.Vector2 Max(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs) { }
        private UnityEngine.Vector2 SmoothDamp(UnityEngine.Vector2 current, UnityEngine.Vector2 target, UnityEngine.Vector2& currentVelocity, System.Single smoothTime, System.Single maxSpeed) { }
        private UnityEngine.Vector2 SmoothDamp(UnityEngine.Vector2 current, UnityEngine.Vector2 target, UnityEngine.Vector2& currentVelocity, System.Single smoothTime) { }
        private UnityEngine.Vector2 SmoothDamp(UnityEngine.Vector2 current, UnityEngine.Vector2 target, UnityEngine.Vector2& currentVelocity, System.Single smoothTime, System.Single maxSpeed, System.Single deltaTime) { }
        private UnityEngine.Vector2 op_Addition(UnityEngine.Vector2 a, UnityEngine.Vector2 b) { }
        private UnityEngine.Vector2 op_Subtraction(UnityEngine.Vector2 a, UnityEngine.Vector2 b) { }
        private UnityEngine.Vector2 op_Multiply(UnityEngine.Vector2 a, UnityEngine.Vector2 b) { }
        private UnityEngine.Vector2 op_Division(UnityEngine.Vector2 a, UnityEngine.Vector2 b) { }
        private UnityEngine.Vector2 op_UnaryNegation(UnityEngine.Vector2 a) { }
        private UnityEngine.Vector2 op_Multiply(UnityEngine.Vector2 a, System.Single d) { }
        private UnityEngine.Vector2 op_Multiply(System.Single d, UnityEngine.Vector2 a) { }
        private UnityEngine.Vector2 op_Division(UnityEngine.Vector2 a, System.Single d) { }
        private System.Boolean op_Equality(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs) { }
        private System.Boolean op_Inequality(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs) { }
        private UnityEngine.Vector2 op_Implicit(UnityEngine.Vector3 v) { }
        private UnityEngine.Vector3 op_Implicit(UnityEngine.Vector2 v) { }
        private UnityEngine.Vector2 get_zero() { }
        private UnityEngine.Vector2 get_one() { }
        private UnityEngine.Vector2 get_up() { }
        private UnityEngine.Vector2 get_down() { }
        private UnityEngine.Vector2 get_left() { }
        private UnityEngine.Vector2 get_right() { }
        private UnityEngine.Vector2 get_positiveInfinity() { }
        private UnityEngine.Vector2 get_negativeInfinity() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200014A
    public struct Vector2Int, IEquatable`1, IFormattable
    {
        // Fields
        private System.Int32 m_X;        // 0x10
        private System.Int32 m_Y;        // 0x14
        private static readonly UnityEngine.Vector2Int s_Zero;        // 0x0
        private static readonly UnityEngine.Vector2Int s_One;        // 0x8
        private static readonly UnityEngine.Vector2Int s_Up;        // 0x10
        private static readonly UnityEngine.Vector2Int s_Down;        // 0x18
        private static readonly UnityEngine.Vector2Int s_Left;        // 0x20
        private static readonly UnityEngine.Vector2Int s_Right;        // 0x28

        // Methods
        private System.Int32 get_x() { }
        private System.Void set_x(System.Int32 value) { }
        private System.Int32 get_y() { }
        private System.Void set_y(System.Int32 value) { }
        private System.Void .ctor(System.Int32 x, System.Int32 y) { }
        private System.Void Set(System.Int32 x, System.Int32 y) { }
        private System.Int32 get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, System.Int32 value) { }
        private System.Single get_magnitude() { }
        private System.Int32 get_sqrMagnitude() { }
        private System.Single Distance(UnityEngine.Vector2Int a, UnityEngine.Vector2Int b) { }
        private UnityEngine.Vector2Int Min(UnityEngine.Vector2Int lhs, UnityEngine.Vector2Int rhs) { }
        private UnityEngine.Vector2Int Max(UnityEngine.Vector2Int lhs, UnityEngine.Vector2Int rhs) { }
        private UnityEngine.Vector2Int Scale(UnityEngine.Vector2Int a, UnityEngine.Vector2Int b) { }
        private System.Void Scale(UnityEngine.Vector2Int scale) { }
        private System.Void Clamp(UnityEngine.Vector2Int min, UnityEngine.Vector2Int max) { }
        private UnityEngine.Vector2 op_Implicit(UnityEngine.Vector2Int v) { }
        private UnityEngine.Vector3Int op_Explicit(UnityEngine.Vector2Int v) { }
        private UnityEngine.Vector2Int FloorToInt(UnityEngine.Vector2 v) { }
        private UnityEngine.Vector2Int CeilToInt(UnityEngine.Vector2 v) { }
        private UnityEngine.Vector2Int RoundToInt(UnityEngine.Vector2 v) { }
        private UnityEngine.Vector2Int op_UnaryNegation(UnityEngine.Vector2Int v) { }
        private UnityEngine.Vector2Int op_Addition(UnityEngine.Vector2Int a, UnityEngine.Vector2Int b) { }
        private UnityEngine.Vector2Int op_Subtraction(UnityEngine.Vector2Int a, UnityEngine.Vector2Int b) { }
        private UnityEngine.Vector2Int op_Multiply(UnityEngine.Vector2Int a, UnityEngine.Vector2Int b) { }
        private UnityEngine.Vector2Int op_Multiply(System.Int32 a, UnityEngine.Vector2Int b) { }
        private UnityEngine.Vector2Int op_Multiply(UnityEngine.Vector2Int a, System.Int32 b) { }
        private UnityEngine.Vector2Int op_Division(UnityEngine.Vector2Int a, System.Int32 b) { }
        private System.Boolean op_Equality(UnityEngine.Vector2Int lhs, UnityEngine.Vector2Int rhs) { }
        private System.Boolean op_Inequality(UnityEngine.Vector2Int lhs, UnityEngine.Vector2Int rhs) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(UnityEngine.Vector2Int other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.String ToString(System.String format) { }
        private System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        private UnityEngine.Vector2Int get_zero() { }
        private UnityEngine.Vector2Int get_one() { }
        private UnityEngine.Vector2Int get_up() { }
        private UnityEngine.Vector2Int get_down() { }
        private UnityEngine.Vector2Int get_left() { }
        private UnityEngine.Vector2Int get_right() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200014B
    public struct Vector3Int, IEquatable`1, IFormattable
    {
        // Fields
        private System.Int32 m_X;        // 0x10
        private System.Int32 m_Y;        // 0x14
        private System.Int32 m_Z;        // 0x18
        private static readonly UnityEngine.Vector3Int s_Zero;        // 0x0
        private static readonly UnityEngine.Vector3Int s_One;        // 0xC
        private static readonly UnityEngine.Vector3Int s_Up;        // 0x18
        private static readonly UnityEngine.Vector3Int s_Down;        // 0x24
        private static readonly UnityEngine.Vector3Int s_Left;        // 0x30
        private static readonly UnityEngine.Vector3Int s_Right;        // 0x3C
        private static readonly UnityEngine.Vector3Int s_Forward;        // 0x48
        private static readonly UnityEngine.Vector3Int s_Back;        // 0x54

        // Methods
        private System.Int32 get_x() { }
        private System.Void set_x(System.Int32 value) { }
        private System.Int32 get_y() { }
        private System.Void set_y(System.Int32 value) { }
        private System.Int32 get_z() { }
        private System.Void set_z(System.Int32 value) { }
        private System.Void .ctor(System.Int32 x, System.Int32 y) { }
        private System.Void .ctor(System.Int32 x, System.Int32 y, System.Int32 z) { }
        private System.Int32 get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, System.Int32 value) { }
        private System.Single get_magnitude() { }
        private System.Single Distance(UnityEngine.Vector3Int a, UnityEngine.Vector3Int b) { }
        private UnityEngine.Vector3Int Min(UnityEngine.Vector3Int lhs, UnityEngine.Vector3Int rhs) { }
        private UnityEngine.Vector3Int Max(UnityEngine.Vector3Int lhs, UnityEngine.Vector3Int rhs) { }
        private UnityEngine.Vector3 op_Implicit(UnityEngine.Vector3Int v) { }
        private UnityEngine.Vector3Int op_Addition(UnityEngine.Vector3Int a, UnityEngine.Vector3Int b) { }
        private UnityEngine.Vector3Int op_Subtraction(UnityEngine.Vector3Int a, UnityEngine.Vector3Int b) { }
        private UnityEngine.Vector3Int op_Multiply(UnityEngine.Vector3Int a, System.Int32 b) { }
        private UnityEngine.Vector3Int op_Multiply(System.Int32 a, UnityEngine.Vector3Int b) { }
        private UnityEngine.Vector3Int op_Division(UnityEngine.Vector3Int a, System.Int32 b) { }
        private System.Boolean op_Equality(UnityEngine.Vector3Int lhs, UnityEngine.Vector3Int rhs) { }
        private System.Boolean op_Inequality(UnityEngine.Vector3Int lhs, UnityEngine.Vector3Int rhs) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(UnityEngine.Vector3Int other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        private UnityEngine.Vector3Int get_zero() { }
        private UnityEngine.Vector3Int get_one() { }
        private UnityEngine.Vector3Int get_up() { }
        private UnityEngine.Vector3Int get_down() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200014C
    public struct Vector4, IEquatable`1, IFormattable
    {
        // Fields
        public static System.Single kEpsilon;        // 0x0
        public System.Single x;        // 0x10
        public System.Single y;        // 0x14
        public System.Single z;        // 0x18
        public System.Single w;        // 0x1C
        private static readonly UnityEngine.Vector4 zeroVector;        // 0x0
        private static readonly UnityEngine.Vector4 oneVector;        // 0x10
        private static readonly UnityEngine.Vector4 positiveInfinityVector;        // 0x20
        private static readonly UnityEngine.Vector4 negativeInfinityVector;        // 0x30

        // Methods
        private System.Single get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, System.Single value) { }
        private System.Void .ctor(System.Single x, System.Single y, System.Single z, System.Single w) { }
        private System.Void .ctor(System.Single x, System.Single y, System.Single z) { }
        private System.Void .ctor(System.Single x, System.Single y) { }
        private System.Void Set(System.Single newX, System.Single newY, System.Single newZ, System.Single newW) { }
        private UnityEngine.Vector4 Lerp(UnityEngine.Vector4 a, UnityEngine.Vector4 b, System.Single t) { }
        private UnityEngine.Vector4 LerpUnclamped(UnityEngine.Vector4 a, UnityEngine.Vector4 b, System.Single t) { }
        private UnityEngine.Vector4 MoveTowards(UnityEngine.Vector4 current, UnityEngine.Vector4 target, System.Single maxDistanceDelta) { }
        private UnityEngine.Vector4 Scale(UnityEngine.Vector4 a, UnityEngine.Vector4 b) { }
        private System.Void Scale(UnityEngine.Vector4 scale) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(UnityEngine.Vector4 other) { }
        private UnityEngine.Vector4 Normalize(UnityEngine.Vector4 a) { }
        private System.Void Normalize() { }
        private UnityEngine.Vector4 get_normalized() { }
        private System.Single Dot(UnityEngine.Vector4 a, UnityEngine.Vector4 b) { }
        private UnityEngine.Vector4 Project(UnityEngine.Vector4 a, UnityEngine.Vector4 b) { }
        private System.Single Distance(UnityEngine.Vector4 a, UnityEngine.Vector4 b) { }
        private System.Single Magnitude(UnityEngine.Vector4 a) { }
        private System.Single get_magnitude() { }
        private System.Single get_sqrMagnitude() { }
        private UnityEngine.Vector4 Min(UnityEngine.Vector4 lhs, UnityEngine.Vector4 rhs) { }
        private UnityEngine.Vector4 Max(UnityEngine.Vector4 lhs, UnityEngine.Vector4 rhs) { }
        private UnityEngine.Vector4 get_zero() { }
        private UnityEngine.Vector4 get_one() { }
        private UnityEngine.Vector4 get_positiveInfinity() { }
        private UnityEngine.Vector4 get_negativeInfinity() { }
        private UnityEngine.Vector4 op_Addition(UnityEngine.Vector4 a, UnityEngine.Vector4 b) { }
        private UnityEngine.Vector4 op_Subtraction(UnityEngine.Vector4 a, UnityEngine.Vector4 b) { }
        private UnityEngine.Vector4 op_UnaryNegation(UnityEngine.Vector4 a) { }
        private UnityEngine.Vector4 op_Multiply(UnityEngine.Vector4 a, System.Single d) { }
        private UnityEngine.Vector4 op_Multiply(System.Single d, UnityEngine.Vector4 a) { }
        private UnityEngine.Vector4 op_Division(UnityEngine.Vector4 a, System.Single d) { }
        private System.Boolean op_Equality(UnityEngine.Vector4 lhs, UnityEngine.Vector4 rhs) { }
        private System.Boolean op_Inequality(UnityEngine.Vector4 lhs, UnityEngine.Vector4 rhs) { }
        private UnityEngine.Vector4 op_Implicit(UnityEngine.Vector3 v) { }
        private UnityEngine.Vector3 op_Implicit(UnityEngine.Vector4 v) { }
        private UnityEngine.Vector4 op_Implicit(UnityEngine.Vector2 v) { }
        private UnityEngine.Vector2 op_Implicit(UnityEngine.Vector4 v) { }
        private System.String ToString() { }
        private System.String ToString(System.String format) { }
        private System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        private System.Single SqrMagnitude(UnityEngine.Vector4 a) { }
        private System.Single SqrMagnitude() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200014D
    public struct Vector4Int, IEquatable`1, IFormattable
    {
        // Fields
        private System.Int32 m_X;        // 0x10
        private System.Int32 m_Y;        // 0x14
        private System.Int32 m_Z;        // 0x18
        private System.Int32 m_W;        // 0x1C
        private static readonly UnityEngine.Vector4Int s_Zero;        // 0x0
        private static readonly UnityEngine.Vector4Int s_One;        // 0x10

        // Methods
        private System.Int32 get_x() { }
        private System.Void set_x(System.Int32 value) { }
        private System.Int32 get_y() { }
        private System.Void set_y(System.Int32 value) { }
        private System.Int32 get_z() { }
        private System.Void set_z(System.Int32 value) { }
        private System.Int32 get_w() { }
        private System.Void set_w(System.Int32 value) { }
        private System.Void .ctor(System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 w) { }
        private System.Boolean op_Equality(UnityEngine.Vector4Int lhs, UnityEngine.Vector4Int rhs) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(UnityEngine.Vector4Int other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200014E
    public interface IPlayerEditorConnectionNative
    {
        // Methods
        private System.Void Initialize() { }
        private System.Void DisconnectAll() { }
        private System.Void SendMessage(System.Guid messageId, System.Byte[] data, System.Int32 playerId) { }
        private System.Boolean TrySendMessage(System.Guid messageId, System.Byte[] data, System.Int32 playerId) { }
        private System.Void Poll() { }
        private System.Void RegisterInternal(System.Guid messageId) { }
        private System.Void UnregisterInternal(System.Guid messageId) { }
        private System.Boolean IsConnected() { }

    }

    // TypeToken: 0x200014F
    public class PlayerConnectionInternal, IPlayerEditorConnectionNative
    {
        // Methods
        private System.Void UnityEngine.IPlayerEditorConnectionNative.SendMessage(System.Guid messageId, System.Byte[] data, System.Int32 playerId) { }
        private System.Boolean UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(System.Guid messageId, System.Byte[] data, System.Int32 playerId) { }
        private System.Void UnityEngine.IPlayerEditorConnectionNative.Poll() { }
        private System.Void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(System.Guid messageId) { }
        private System.Void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(System.Guid messageId) { }
        private System.Void UnityEngine.IPlayerEditorConnectionNative.Initialize() { }
        private System.Boolean UnityEngine.IPlayerEditorConnectionNative.IsConnected() { }
        private System.Void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll() { }
        private System.Boolean IsConnected() { }
        private System.Void Initialize() { }
        private System.Void RegisterInternal(System.String messageId) { }
        private System.Void UnregisterInternal(System.String messageId) { }
        private System.Void SendMessage(System.String messageId, System.Byte[] data, System.Int32 playerId) { }
        private System.Boolean TrySendMessage(System.String messageId, System.Byte[] data, System.Int32 playerId) { }
        private System.Void PollInternal() { }
        private System.Void DisconnectAll() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000150
    public class PlayerPrefsException : Exception
    {
        // Methods
        private System.Void .ctor(System.String error) { }

    }

    // TypeToken: 0x2000151
    public class PlayerPrefs
    {
        // Methods
        private System.Boolean TrySetInt(System.String key, System.Int32 value) { }
        private System.Boolean TrySetFloat(System.String key, System.Single value) { }
        private System.Boolean TrySetSetString(System.String key, System.String value) { }
        private System.Void SetInt(System.String key, System.Int32 value) { }
        private System.Int32 GetInt(System.String key, System.Int32 defaultValue) { }
        private System.Int32 GetInt(System.String key) { }
        private System.Void SetFloat(System.String key, System.Single value) { }
        private System.Single GetFloat(System.String key, System.Single defaultValue) { }
        private System.Single GetFloat(System.String key) { }
        private System.Void SetString(System.String key, System.String value) { }
        private System.String GetString(System.String key, System.String defaultValue) { }
        private System.String GetString(System.String key) { }
        private System.Boolean HasKey(System.String key) { }
        private System.Void DeleteKey(System.String key) { }
        private System.Void DeleteAll() { }
        private System.Void Save() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000152
    public class PropertyAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000153
    public class ContextMenuItemAttribute : PropertyAttribute
    {
        // Fields
        public readonly System.String name;        // 0x10
        public readonly System.String function;        // 0x18

        // Methods
        private System.Void .ctor(System.String name, System.String function) { }

    }

    // TypeToken: 0x2000154
    public class InspectorNameAttribute : PropertyAttribute
    {
        // Fields
        public readonly System.String displayName;        // 0x10

        // Methods
        private System.Void .ctor(System.String displayName) { }

    }

    // TypeToken: 0x2000155
    public class TooltipAttribute : PropertyAttribute
    {
        // Fields
        public readonly System.String tooltip;        // 0x10

        // Methods
        private System.Void .ctor(System.String tooltip) { }

    }

    // TypeToken: 0x2000156
    public class SpaceAttribute : PropertyAttribute
    {
        // Fields
        public readonly System.Single height;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Single height) { }

    }

    // TypeToken: 0x2000157
    public class HeaderAttribute : PropertyAttribute
    {
        // Fields
        public readonly System.String header;        // 0x10

        // Methods
        private System.Void .ctor(System.String header) { }

    }

    // TypeToken: 0x2000158
    public class RangeAttribute : PropertyAttribute
    {
        // Fields
        public readonly System.Single min;        // 0x10
        public readonly System.Single max;        // 0x14

        // Methods
        private System.Void .ctor(System.Single min, System.Single max) { }

    }

    // TypeToken: 0x2000159
    public class MinAttribute : PropertyAttribute
    {
        // Fields
        public readonly System.Single min;        // 0x10

        // Methods
        private System.Void .ctor(System.Single min) { }

    }

    // TypeToken: 0x200015A
    public class MultilineAttribute : PropertyAttribute
    {
        // Fields
        public readonly System.Int32 lines;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 lines) { }

    }

    // TypeToken: 0x200015B
    public class TextAreaAttribute : PropertyAttribute
    {
        // Fields
        public readonly System.Int32 minLines;        // 0x10
        public readonly System.Int32 maxLines;        // 0x14

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 minLines, System.Int32 maxLines) { }

    }

    // TypeToken: 0x200015C
    public class ColorUsageAttribute : PropertyAttribute
    {
        // Fields
        public readonly System.Boolean showAlpha;        // 0x10
        public readonly System.Boolean hdr;        // 0x11
        public readonly System.Single minBrightness;        // 0x14
        public readonly System.Single maxBrightness;        // 0x18
        public readonly System.Single minExposureValue;        // 0x1C
        public readonly System.Single maxExposureValue;        // 0x20

        // Methods
        private System.Void .ctor(System.Boolean showAlpha) { }
        private System.Void .ctor(System.Boolean showAlpha, System.Boolean hdr) { }

    }

    // TypeToken: 0x200015D
    public class PropertyNameUtils
    {
        // Methods
        private UnityEngine.PropertyName PropertyNameFromString(System.String name) { }
        private System.Void PropertyNameFromString_Injected(System.String name, UnityEngine.PropertyName& ret) { }

    }

    // TypeToken: 0x200015E
    public struct PropertyName, IEquatable`1
    {
        // Fields
        private System.Int32 id;        // 0x10

        // Methods
        private System.Void .ctor(System.String name) { }
        private System.Void .ctor(UnityEngine.PropertyName other) { }
        private System.Boolean IsNullOrEmpty(UnityEngine.PropertyName prop) { }
        private System.Boolean op_Equality(UnityEngine.PropertyName lhs, UnityEngine.PropertyName rhs) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(UnityEngine.PropertyName other) { }
        private UnityEngine.PropertyName op_Implicit(System.String name) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200015F
    public class Random
    {
        // Methods
        private System.Void InitState(System.Int32 seed) { }
        private UnityEngine.Random.State get_state() { }
        private System.Void set_state(UnityEngine.Random.State value) { }
        private System.Single Range(System.Single minInclusive, System.Single maxInclusive) { }
        private System.Int32 Range(System.Int32 minInclusive, System.Int32 maxExclusive) { }
        private System.Int32 RandomRangeInt(System.Int32 minInclusive, System.Int32 maxExclusive) { }
        private System.Single get_value() { }
        private UnityEngine.Vector3 get_insideUnitSphere() { }
        private System.Void GetRandomUnitCircle(UnityEngine.Vector2& output) { }
        private UnityEngine.Vector2 get_insideUnitCircle() { }
        private UnityEngine.Quaternion get_rotation() { }
        private UnityEngine.Color ColorHSV() { }
        private UnityEngine.Color ColorHSV(System.Single hueMin, System.Single hueMax, System.Single saturationMin, System.Single saturationMax, System.Single valueMin, System.Single valueMax, System.Single alphaMin, System.Single alphaMax) { }
        private System.Void get_state_Injected(UnityEngine.Random.State& ret) { }
        private System.Void set_state_Injected(UnityEngine.Random.State& value) { }
        private System.Void get_insideUnitSphere_Injected(UnityEngine.Vector3& ret) { }
        private System.Void get_rotation_Injected(UnityEngine.Quaternion& ret) { }

    }

    // TypeToken: 0x2000161
    public class ResourceRequest : AsyncOperation
    {
        // Fields
        private System.String m_Path;        // 0x20
        private System.Type m_Type;        // 0x28

        // Methods
        private UnityEngine.Object GetResult() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000162
    public class ResourcesAPIInternal
    {
        // Methods
        private UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type) { }
        private UnityEngine.Shader FindShaderByName(System.String name) { }
        private UnityEngine.Object Load(System.String path, System.Type systemTypeInstance) { }
        private UnityEngine.Object[] LoadAll(System.String path, System.Type systemTypeInstance) { }
        private UnityEngine.ResourceRequest LoadAsyncInternal(System.String path, System.Type type) { }
        private System.Void UnloadAsset(UnityEngine.Object assetToUnload) { }

    }

    // TypeToken: 0x2000163
    public class ResourcesAPI
    {
        // Fields
        private static UnityEngine.ResourcesAPI s_DefaultAPI;        // 0x0
        private static UnityEngine.ResourcesAPI <overrideAPI>k__BackingField;        // 0x8

        // Methods
        private UnityEngine.ResourcesAPI get_ActiveAPI() { }
        private UnityEngine.ResourcesAPI get_overrideAPI() { }
        private System.Void .ctor() { }
        private UnityEngine.Object[] FindObjectsOfTypeAll(System.Type systemTypeInstance) { }
        private UnityEngine.Shader FindShaderByName(System.String name) { }
        private UnityEngine.Object Load(System.String path, System.Type systemTypeInstance) { }
        private UnityEngine.Object[] LoadAll(System.String path, System.Type systemTypeInstance) { }
        private UnityEngine.ResourceRequest LoadAsync(System.String path, System.Type systemTypeInstance) { }
        private System.Void UnloadAsset(UnityEngine.Object assetToUnload) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000164
    public class Resources
    {
        // Methods
        private T[] ConvertObjects(UnityEngine.Object[] rawObjects) { }
        private UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type) { }
        private T[] FindObjectsOfTypeAll() { }
        private UnityEngine.Object Load(System.String path) { }
        private T Load(System.String path) { }
        private UnityEngine.Object Load(System.String path, System.Type systemTypeInstance) { }
        private UnityEngine.ResourceRequest LoadAsync(System.String path) { }
        private UnityEngine.ResourceRequest LoadAsync(System.String path) { }
        private UnityEngine.ResourceRequest LoadAsync(System.String path, System.Type type) { }
        private UnityEngine.Object[] LoadAll(System.String path, System.Type systemTypeInstance) { }
        private UnityEngine.Object[] LoadAll(System.String path) { }
        private T[] LoadAll(System.String path) { }
        private UnityEngine.Object GetBuiltinResource(System.Type type, System.String path) { }
        private T GetBuiltinResource(System.String path) { }
        private System.Void UnloadAsset(UnityEngine.Object assetToUnload) { }
        private System.Void UnloadAssetImplResourceManager(UnityEngine.Object assetToUnload) { }
        private UnityEngine.AsyncOperation UnloadUnusedAssets() { }
        private System.Void UpdateCPUAffinity(UnityEngine.Resources.ResourcesCPUAffinity affinity) { }
        private UnityEngine.Object InstanceIDToObject(System.Int32 instanceID) { }
        private System.Void InstanceIDToObjectList(System.IntPtr instanceIDs, System.Int32 instanceCount, System.Collections.Generic.List<UnityEngine.Object> objects) { }
        private System.Void InstanceIDToObjectList(Unity.Collections.NativeArray<System.Int32> instanceIDs, System.Collections.Generic.List<UnityEngine.Object> objects) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000166
    public class AsyncInstantiateOperation : AsyncOperation
    {
        // Fields
        private UnityEngine.Object[] m_Result;        // 0x20

        // Methods
        private UnityEngine.Object[] get_Result() { }
        private System.Void WaitForCompletion() { }
        private System.Void Cancel() { }
        private System.Void set_IntegrationTimeMS(System.Single value) { }
        private System.Void .ctor() { }
        private System.Void SetIntegrationTimeMS(System.Single integrationTimeMS) { }

    }

    // TypeToken: 0x2000167
    public class AsyncInstantiateOperation`1 : CustomYieldInstruction
    {
        // Fields
        private UnityEngine.AsyncInstantiateOperation m_op;        // 0x0

        // Methods
        private System.Void .ctor(UnityEngine.AsyncInstantiateOperation op) { }
        private System.Boolean get_keepWaiting() { }
        private System.Boolean get_isDone() { }
        private System.Void WaitForCompletion() { }
        private System.Void Cancel() { }
        private T[] get_Result() { }

    }

    // TypeToken: 0x2000168
    public class AsyncInstantiateOperationHelper
    {
        // Methods
        private System.Void SetAsyncInstantiateOperationResult(UnityEngine.AsyncInstantiateOperation op, UnityEngine.Object[] result) { }

    }

    // TypeToken: 0x2000169
    public class AsyncOperation : YieldInstruction
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10
        private System.Action<UnityEngine.AsyncOperation> m_completeCallback;        // 0x18

        // Methods
        private System.Void InternalDestroy(System.IntPtr ptr) { }
        private System.Boolean get_isDone() { }
        private System.Single get_progress() { }
        private System.Int32 get_priority() { }
        private System.Void set_priority(System.Int32 value) { }
        private System.Boolean get_allowSceneActivation() { }
        private System.Void set_allowSceneActivation(System.Boolean value) { }
        private System.Boolean TryCancel() { }
        private System.Void Finalize() { }
        private System.Void InvokeCompletionEvent() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200016A
    public class AttributeHelperEngine
    {
        // Fields
        public static UnityEngine.DisallowMultipleComponent[] _disallowMultipleComponentArray;        // 0x0
        public static UnityEngine.ExecuteInEditMode[] _executeInEditModeArray;        // 0x8
        public static UnityEngine.RequireComponent[] _requireComponentArray;        // 0x10

        // Methods
        private System.Type GetParentTypeDisallowingMultipleInclusion(System.Type type) { }
        private System.Type[] GetRequiredComponents(System.Type klass) { }
        private System.Int32 GetExecuteMode(System.Type klass) { }
        private System.Int32 CheckIsEditorScript(System.Type klass) { }
        private System.Int32 GetDefaultExecutionOrderFor(System.Type klass) { }
        private T GetCustomAttributeOfType(System.Type klass) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200016B
    public class DisallowMultipleComponent : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200016C
    public class RequireComponent : Attribute
    {
        // Fields
        public System.Type m_Type0;        // 0x10
        public System.Type m_Type1;        // 0x18
        public System.Type m_Type2;        // 0x20

        // Methods
        private System.Void .ctor(System.Type requiredComponent) { }
        private System.Void .ctor(System.Type requiredComponent, System.Type requiredComponent2) { }

    }

    // TypeToken: 0x200016D
    public class AddComponentMenu : Attribute
    {
        // Fields
        private System.String m_AddComponentMenu;        // 0x10
        private System.Int32 m_Ordering;        // 0x18

        // Methods
        private System.Void .ctor(System.String menuName) { }
        private System.Void .ctor(System.String menuName, System.Int32 order) { }

    }

    // TypeToken: 0x200016E
    public class CreateAssetMenuAttribute : Attribute
    {
        // Fields
        private System.String <menuName>k__BackingField;        // 0x10
        private System.String <fileName>k__BackingField;        // 0x18
        private System.Int32 <order>k__BackingField;        // 0x20

        // Methods
        private System.Void set_menuName(System.String value) { }
        private System.Void set_fileName(System.String value) { }
        private System.Void set_order(System.Int32 value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200016F
    public class ContextMenu : Attribute
    {
        // Fields
        public readonly System.String menuItem;        // 0x10
        public readonly System.Boolean validate;        // 0x18
        public readonly System.Int32 priority;        // 0x1C

        // Methods
        private System.Void .ctor(System.String itemName) { }
        private System.Void .ctor(System.String itemName, System.Boolean isValidateFunction) { }
        private System.Void .ctor(System.String itemName, System.Boolean isValidateFunction, System.Int32 priority) { }

    }

    // TypeToken: 0x2000170
    public class ExecuteInEditMode : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000171
    public class ExecuteAlways : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000172
    public class HideInInspector : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000173
    public class HelpURLAttribute : Attribute
    {
        // Fields
        private readonly System.String m_Url;        // 0x10
        private readonly System.Boolean m_Dispatcher;        // 0x18
        private readonly System.String m_DispatchingFieldName;        // 0x20

        // Methods
        private System.Void .ctor(System.String url) { }
        private System.String get_URL() { }

    }

    // TypeToken: 0x2000174
    public class DefaultExecutionOrder : Attribute
    {
        // Fields
        private System.Int32 m_Order;        // 0x10

        // Methods
        private System.Void .ctor(System.Int32 order) { }
        private System.Int32 get_order() { }

    }

    // TypeToken: 0x2000175
    public class AssemblyIsEditorAssembly : Attribute
    {
    }

    // TypeToken: 0x2000176
    public class ExcludeFromPresetAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000177
    public class Behaviour : Component
    {
        // Methods
        private System.Boolean get_enabled() { }
        private System.Void set_enabled(System.Boolean value) { }
        private System.Boolean get_isActiveAndEnabled() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000178
    public struct CastHelper`1
    {
        // Fields
        public T t;        // 0x0
        public System.IntPtr onePointerFurtherThanT;        // 0x0

    }

    // TypeToken: 0x2000179
    public class ClassLibraryInitializer
    {
        // Methods
        private System.Void Init() { }

    }

    // TypeToken: 0x200017A
    public class Component
    {
        // Methods
        private UnityEngine.Transform get_transform() { }
        private UnityEngine.GameObject get_gameObject() { }
        private UnityEngine.Component GetComponent(System.Type type) { }
        private UnityEngine.Component GetComponent(System.Type type, System.Int32 multiComponentIndex) { }
        private T GetComponent() { }
        private T GetComponent(System.Int32 multiComponentIndex) { }
        private System.Void GetComponentFastPath(System.Type type, System.Int32 multiComponentIndex, System.IntPtr resultValue) { }
        private System.Boolean TryGetComponent(System.Type type, UnityEngine.Component& component) { }
        private System.Boolean TryGetComponent(T& component) { }
        private UnityEngine.Component GetComponent(System.String type) { }
        private UnityEngine.Component GetComponentInChildren(System.Type t, System.Boolean includeInactive) { }
        private UnityEngine.Component GetComponentInChildren(System.Type t) { }
        private T GetComponentInChildren(System.Boolean includeInactive) { }
        private T GetComponentInChildren() { }
        private UnityEngine.Component[] GetComponentsInChildren(System.Type t, System.Boolean includeInactive) { }
        private UnityEngine.Component[] GetComponentsInChildren(System.Type t) { }
        private T[] GetComponentsInChildren(System.Boolean includeInactive) { }
        private System.Void GetComponentsInChildren(System.Boolean includeInactive, System.Collections.Generic.List<T> result) { }
        private T[] GetComponentsInChildren() { }
        private System.Void GetComponentsInChildren(System.Collections.Generic.List<T> results) { }
        private UnityEngine.Component GetComponentInParent(System.Type t, System.Boolean includeInactive) { }
        private UnityEngine.Component GetComponentInParent(System.Type t) { }
        private T GetComponentInParent(System.Boolean includeInactive) { }
        private T GetComponentInParent() { }
        private UnityEngine.Component[] GetComponentsInParent(System.Type t, System.Boolean includeInactive) { }
        private UnityEngine.Component[] GetComponentsInParent(System.Type t) { }
        private T[] GetComponentsInParent(System.Boolean includeInactive) { }
        private System.Void GetComponentsInParent(System.Boolean includeInactive, System.Collections.Generic.List<T> results) { }
        private T[] GetComponentsInParent() { }
        private UnityEngine.Component[] GetComponents(System.Type type) { }
        private System.Void GetComponentsForListInternal(System.Type searchType, System.Object resultList) { }
        private System.Void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results) { }
        private System.Void GetComponents(System.Collections.Generic.List<T> results) { }
        private System.String get_tag() { }
        private System.Void set_tag(System.String value) { }
        private T[] GetComponents() { }
        private System.Boolean CompareTag(System.String tag) { }
        private System.Void SendMessageUpwards(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options) { }
        private System.Void SendMessageUpwards(System.String methodName, System.Object value) { }
        private System.Void SendMessageUpwards(System.String methodName) { }
        private System.Void SendMessageUpwards(System.String methodName, UnityEngine.SendMessageOptions options) { }
        private System.Void SendMessage(System.String methodName, System.Object value) { }
        private System.Void SendMessage(System.String methodName) { }
        private System.Void SendMessage(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options) { }
        private System.Void SendMessage(System.String methodName, UnityEngine.SendMessageOptions options) { }
        private System.Void BroadcastMessage(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options) { }
        private System.Void BroadcastMessage(System.String methodName, System.Object parameter) { }
        private System.Void BroadcastMessage(System.String methodName) { }
        private System.Void BroadcastMessage(System.String methodName, UnityEngine.SendMessageOptions options) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200017B
    public class Coroutine : YieldInstruction
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void Finalize() { }
        private System.Void ReleaseCoroutine(System.IntPtr ptr) { }

    }

    // TypeToken: 0x200017C
    public class SetupCoroutine
    {
        // Methods
        private System.Void InvokeMoveNext(System.Collections.IEnumerator enumerator, System.IntPtr returnValueAddress) { }
        private System.Object InvokeMember(System.Object behaviour, System.String name, System.Object variable) { }

    }

    // TypeToken: 0x200017D
    public class CustomYieldInstruction, IEnumerator
    {
        // Methods
        private System.Boolean get_keepWaiting() { }
        private System.Object get_Current() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200017E
    public class ExcludeFromObjectFactoryAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200017F
    public class ExtensionOfNativeClassAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000180
    public class FailedToLoadScriptObject
    {
    }

    // TypeToken: 0x2000181
    public struct PlatformLayers
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.PlatformLayers None;        // 0x0
        public static UnityEngine.PlatformLayers PC;        // 0x0
        public static UnityEngine.PlatformLayers Mobile;        // 0x0
        public static UnityEngine.PlatformLayers Other;        // 0x0
        public static UnityEngine.PlatformLayers AllPlatforms;        // 0x0

    }

    // TypeToken: 0x2000182
    public class GameObject
    {
        // Methods
        private UnityEngine.GameObject CreatePrimitive(UnityEngine.PrimitiveType type) { }
        private T GetComponent() { }
        private T GetComponent(System.Int32 multiComponentIndex) { }
        private UnityEngine.Component GetComponent(System.Type type) { }
        private UnityEngine.Component GetComponent(System.Type type, System.Int32 multiComponentIndex) { }
        private UnityEngine.Component GetComponentInternal(System.Type type) { }
        private System.Void GetComponentFastPath(System.Type type, System.Int32 multiComponentIndex, System.IntPtr resultValue) { }
        private UnityEngine.Component GetComponentByName(System.String type) { }
        private UnityEngine.Component GetComponent(System.String type) { }
        private UnityEngine.Component GetComponentInChildren(System.Type type, System.Boolean includeInactive) { }
        private UnityEngine.Component GetComponentInChildren(System.Type type) { }
        private T GetComponentInChildren() { }
        private T GetComponentInChildren(System.Boolean includeInactive) { }
        private UnityEngine.Component GetComponentInParent(System.Type type, System.Boolean includeInactive) { }
        private UnityEngine.Component GetComponentInParent(System.Type type) { }
        private T GetComponentInParent() { }
        private T GetComponentInParent(System.Boolean includeInactive) { }
        private System.Array GetComponentsInternal(System.Type type, System.Boolean useSearchTypeAsArrayReturnType, System.Boolean recursive, System.Boolean includeInactive, System.Boolean reverse, System.Object resultList) { }
        private UnityEngine.Component[] GetComponents(System.Type type) { }
        private T[] GetComponents() { }
        private System.Void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results) { }
        private System.Void GetComponents(System.Collections.Generic.List<T> results) { }
        private UnityEngine.Component[] GetComponentsInChildren(System.Type type) { }
        private UnityEngine.Component[] GetComponentsInChildren(System.Type type, System.Boolean includeInactive) { }
        private T[] GetComponentsInChildren(System.Boolean includeInactive) { }
        private System.Void GetComponentsInChildren(System.Boolean includeInactive, System.Collections.Generic.List<T> results) { }
        private T[] GetComponentsInChildren() { }
        private System.Void GetComponentsInChildren(System.Collections.Generic.List<T> results) { }
        private UnityEngine.Component[] GetComponentsInParent(System.Type type) { }
        private UnityEngine.Component[] GetComponentsInParent(System.Type type, System.Boolean includeInactive) { }
        private System.Void GetComponentsInParent(System.Boolean includeInactive, System.Collections.Generic.List<T> results) { }
        private T[] GetComponentsInParent(System.Boolean includeInactive) { }
        private T[] GetComponentsInParent() { }
        private System.Boolean TryGetComponent(T& component) { }
        private System.Boolean TryGetComponent(System.Int32 multiComponentIndex, T& component) { }
        private System.Boolean TryGetComponent(System.Type type, UnityEngine.Component& component) { }
        private System.Boolean TryGetComponent(System.Type type, System.Int32 multiComponentIndex, UnityEngine.Component& component) { }
        private UnityEngine.Component TryGetComponentInternal(System.Type type) { }
        private System.Void TryGetComponentFastPath(System.Type type, System.Int32 multiComponentIndex, System.IntPtr resultValue) { }
        private UnityEngine.GameObject FindWithTag(System.String tag) { }
        private System.Void SendMessageUpwards(System.String methodName, UnityEngine.SendMessageOptions options) { }
        private System.Void SendMessage(System.String methodName, UnityEngine.SendMessageOptions options) { }
        private System.Void BroadcastMessage(System.String methodName, UnityEngine.SendMessageOptions options) { }
        private UnityEngine.Component AddComponentInternal(System.String className) { }
        private UnityEngine.Component Internal_AddComponentWithType(System.Type componentType) { }
        private UnityEngine.Component AddComponent(System.Type componentType) { }
        private T AddComponent() { }
        private UnityEngine.Transform get_transform() { }
        private System.Int32 get_layer() { }
        private System.Void set_layer(System.Int32 value) { }
        private System.Boolean SyncLayerRecursive(UnityEngine.GameObject source) { }
        private System.Boolean SetLayerRecursive(System.Int32 layer) { }
        private System.Int32 get_artTag() { }
        private System.Void set_artTag(System.Int32 value) { }
        private System.Boolean get_active() { }
        private System.Void set_active(System.Boolean value) { }
        private System.Void SetActive(System.Boolean value) { }
        private System.Boolean get_activeSelf() { }
        private System.Boolean get_activeInHierarchy() { }
        private System.Void SetActiveRecursively(System.Boolean state) { }
        private System.Boolean get_isStatic() { }
        private System.Void set_isStatic(System.Boolean value) { }
        private System.Boolean get_isStaticBatchable() { }
        private System.String get_tag() { }
        private System.Void set_tag(System.String value) { }
        private System.Int32 get_tagInt() { }
        private System.Void set_tagInt(System.Int32 value) { }
        private System.Int32 GetTagInt(System.String tag) { }
        private System.Boolean CompareTag(System.String tag) { }
        private UnityEngine.GameObject FindGameObjectWithTag(System.String tag) { }
        private UnityEngine.GameObject[] FindGameObjectsWithTag(System.String tag) { }
        private System.String[] GetAllArtTagsStr() { }
        private System.Int32[] GetAllArtTagsInt() { }
        private System.Void SetArtTags(System.String[] tagStr, System.Int32[] tagInt) { }
        private System.Void SendMessageUpwards(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options) { }
        private System.Void SendMessageUpwards(System.String methodName, System.Object value) { }
        private System.Void SendMessageUpwards(System.String methodName) { }
        private System.Void SendMessage(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options) { }
        private System.Void SendMessage(System.String methodName, System.Object value) { }
        private System.Void SendMessage(System.String methodName) { }
        private System.Void BroadcastMessage(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options) { }
        private System.Void BroadcastMessage(System.String methodName, System.Object parameter) { }
        private System.Void BroadcastMessage(System.String methodName) { }
        private System.Void .ctor(System.String name) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String name, System.Type[] components) { }
        private System.Void Internal_CreateGameObject(UnityEngine.GameObject self, System.String name) { }
        private UnityEngine.GameObject Find(System.String name) { }
        private UnityEngine.SceneManagement.Scene get_scene() { }
        private System.Boolean get_isInPreviewScene() { }
        private System.UInt64 get_sceneCullingMask() { }
        private UnityEngine.GameObject get_gameObject() { }
        private System.Void get_scene_Injected(UnityEngine.SceneManagement.Scene& ret) { }

    }

    // TypeToken: 0x2000183
    public struct LayerMask
    {
        // Fields
        private System.Int32 m_Mask;        // 0x10

        // Methods
        private System.Int32 op_Implicit(UnityEngine.LayerMask mask) { }
        private UnityEngine.LayerMask op_Implicit(System.Int32 intVal) { }
        private System.Int32 get_value() { }
        private System.Void set_value(System.Int32 value) { }
        private System.String LayerToName(System.Int32 layer) { }
        private System.Int32 NameToLayer(System.String layerName) { }
        private System.Int32 GetMask(System.String[] layerNames) { }

    }

    // TypeToken: 0x2000184
    public class ManagedStreamHelpers
    {
        // Methods
        private System.Void ValidateLoadFromStream(System.IO.Stream stream) { }
        private System.Void ManagedStreamRead(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.IO.Stream stream, System.IntPtr returnValueAddress) { }
        private System.Void ManagedStreamSeek(System.Int64 offset, System.UInt32 origin, System.IO.Stream stream, System.IntPtr returnValueAddress) { }
        private System.Void ManagedStreamLength(System.IO.Stream stream, System.IntPtr returnValueAddress) { }

    }

    // TypeToken: 0x2000185
    public class MonoBehaviour : Behaviour
    {
        // Methods
        private System.Boolean IsInvoking() { }
        private System.Void CancelInvoke() { }
        private System.Void Invoke(System.String methodName, System.Single time) { }
        private System.Void InvokeRepeating(System.String methodName, System.Single time, System.Single repeatRate) { }
        private System.Void CancelInvoke(System.String methodName) { }
        private System.Boolean IsInvoking(System.String methodName) { }
        private UnityEngine.Coroutine StartCoroutine(System.String methodName) { }
        private UnityEngine.Coroutine StartCoroutine(System.String methodName, System.Object value) { }
        private UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine) { }
        private UnityEngine.Coroutine StartCoroutine_Auto(System.Collections.IEnumerator routine) { }
        private System.Void StopCoroutine(System.Collections.IEnumerator routine) { }
        private System.Void StopCoroutine(UnityEngine.Coroutine routine) { }
        private System.Void StopCoroutine(System.String methodName) { }
        private System.Void StopAllCoroutines() { }
        private System.Boolean get_useGUILayout() { }
        private System.Void set_useGUILayout(System.Boolean value) { }
        private System.Void print(System.Object message) { }
        private System.Void Internal_CancelInvokeAll(UnityEngine.MonoBehaviour self) { }
        private System.Boolean Internal_IsInvokingAll(UnityEngine.MonoBehaviour self) { }
        private System.Void InvokeDelayed(UnityEngine.MonoBehaviour self, System.String methodName, System.Single time, System.Single repeatRate) { }
        private System.Void CancelInvoke(UnityEngine.MonoBehaviour self, System.String methodName) { }
        private System.Boolean IsInvoking(UnityEngine.MonoBehaviour self, System.String methodName) { }
        private System.Boolean IsObjectMonoBehaviour(UnityEngine.Object obj) { }
        private UnityEngine.Coroutine StartCoroutineManaged(System.String methodName, System.Object value) { }
        private UnityEngine.Coroutine StartCoroutineManaged2(System.Collections.IEnumerator enumerator) { }
        private System.Void StopCoroutineManaged(UnityEngine.Coroutine routine) { }
        private System.Void StopCoroutineFromEnumeratorManaged(System.Collections.IEnumerator routine) { }
        private System.String GetScriptClassName() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000186
    public class NoAllocHelpers
    {
        // Methods
        private System.Void ResizeList(System.Collections.Generic.List<T> list, System.Int32 size) { }
        private System.Void EnsureListElemCount(System.Collections.Generic.List<T> list, System.Int32 count) { }
        private System.Int32 SafeLength(System.Array values) { }
        private System.Int32 SafeLength(System.Collections.Generic.List<T> values) { }
        private T[] ExtractArrayFromListT(System.Collections.Generic.List<T> list) { }
        private System.Void Internal_ResizeList(System.Object list, System.Int32 size) { }
        private System.Array ExtractArrayFromList(System.Object list) { }

    }

    // TypeToken: 0x2000187
    public struct PlatformSpecificParam`1
    {
        // Fields
        public T defaultParam;        // 0x0

    }

    // TypeToken: 0x2000188
    public struct RangeInt
    {
        // Fields
        public System.Int32 start;        // 0x10
        public System.Int32 length;        // 0x14

        // Methods
        private System.Int32 get_end() { }
        private System.Void .ctor(System.Int32 start, System.Int32 length) { }

    }

    // TypeToken: 0x2000189
    public struct RuntimeInitializeLoadType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.RuntimeInitializeLoadType AfterSceneLoad;        // 0x0
        public static UnityEngine.RuntimeInitializeLoadType BeforeSceneLoad;        // 0x0
        public static UnityEngine.RuntimeInitializeLoadType AfterAssembliesLoaded;        // 0x0
        public static UnityEngine.RuntimeInitializeLoadType BeforeSplashScreen;        // 0x0
        public static UnityEngine.RuntimeInitializeLoadType SubsystemRegistration;        // 0x0

    }

    // TypeToken: 0x200018A
    public class RuntimeInitializeOnLoadMethodAttribute : PreserveAttribute
    {
        // Fields
        private UnityEngine.RuntimeInitializeLoadType m_LoadType;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.RuntimeInitializeLoadType loadType) { }
        private System.Void set_loadType(UnityEngine.RuntimeInitializeLoadType value) { }

    }

    // TypeToken: 0x200018B
    public class ScriptableObject
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void SetDirty() { }
        private UnityEngine.ScriptableObject CreateInstance(System.String className) { }
        private UnityEngine.ScriptableObject CreateInstance(System.Type type) { }
        private T CreateInstance() { }
        private UnityEngine.ScriptableObject CreateInstance(System.Type type, System.Action<UnityEngine.ScriptableObject> initialize) { }
        private System.Void CreateScriptableObject(UnityEngine.ScriptableObject self) { }
        private UnityEngine.ScriptableObject CreateScriptableObjectInstanceFromName(System.String className) { }
        private UnityEngine.ScriptableObject CreateScriptableObjectInstanceFromType(System.Type type, System.Boolean applyDefaultsAndReset) { }
        private System.Void ResetAndApplyDefaultInstances(UnityEngine.Object obj) { }

    }

    // TypeToken: 0x200018C
    public class ScriptingRuntime
    {
        // Methods
        private System.String[] GetAllUserAssemblies() { }

    }

    // TypeToken: 0x200018D
    public class ScriptingUtility
    {
        // Methods
        private System.Boolean IsManagedCodeWorking() { }

    }

    // TypeToken: 0x200018F
    public class SelectionBaseAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000190
    public class StackTraceUtility
    {
        // Fields
        private static System.String projectFolder;        // 0x0

        // Methods
        private System.Void SetProjectFolder(System.String folder) { }
        private System.String ExtractStackTrace() { }
        private System.Void ExtractStringFromExceptionInternal(System.Object exceptiono, System.String& message, System.String& stackTrace) { }
        private System.String ExtractFormattedStackTrace(System.Diagnostics.StackTrace stackTrace) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000191
    public class UnityException : Exception
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String message) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }

    }

    // TypeToken: 0x2000192
    public class UnassignedReferenceException : Exception
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String message) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }

    }

    // TypeToken: 0x2000193
    public class TextAsset
    {
        // Methods
        private System.Byte[] get_bytes() { }
        private System.Byte[] GetPreviewBytes(System.Int32 maxByteCount) { }
        private System.Void Internal_CreateInstance(UnityEngine.TextAsset self, System.String text) { }
        private System.IntPtr GetDataPtr() { }
        private System.Int64 GetDataSize() { }
        private System.String get_text() { }
        private System.Int64 get_dataSize() { }
        private System.String ToString() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String text) { }
        private System.Void .ctor(UnityEngine.TextAsset.CreateOptions options, System.String text) { }
        private Unity.Collections.NativeArray<T> GetData() { }
        private System.String GetPreview(System.Int32 maxChars) { }
        private System.String DecodeString(System.Byte[] bytes) { }

    }

    // TypeToken: 0x2000196
    public class TrackedReference
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Boolean op_Equality(UnityEngine.TrackedReference x, UnityEngine.TrackedReference y) { }
        private System.Boolean op_Inequality(UnityEngine.TrackedReference x, UnityEngine.TrackedReference y) { }
        private System.Boolean Equals(System.Object o) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean op_Implicit(UnityEngine.TrackedReference exists) { }

    }

    // TypeToken: 0x2000197
    public class UnhandledExceptionHandler
    {
        // Methods
        private System.Void RegisterUECatcher() { }

    }

    // TypeToken: 0x2000199
    public class UnityAPICompatibilityVersionAttribute : Attribute
    {
        // Fields
        private System.String _version;        // 0x10
        private System.String[] _configurationAssembliesHashes;        // 0x18

        // Methods
        private System.Void .ctor(System.String version, System.String[] configurationAssembliesHashes) { }

    }

    // TypeToken: 0x200019A
    public struct HideFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.HideFlags None;        // 0x0
        public static UnityEngine.HideFlags HideInHierarchy;        // 0x0
        public static UnityEngine.HideFlags HideInInspector;        // 0x0
        public static UnityEngine.HideFlags DontSaveInEditor;        // 0x0
        public static UnityEngine.HideFlags NotEditable;        // 0x0
        public static UnityEngine.HideFlags DontSaveInBuild;        // 0x0
        public static UnityEngine.HideFlags DontUnloadUnusedAsset;        // 0x0
        public static UnityEngine.HideFlags DontSave;        // 0x0
        public static UnityEngine.HideFlags HideAndDontSave;        // 0x0

    }

    // TypeToken: 0x200019B
    public struct FindObjectsSortMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.FindObjectsSortMode None;        // 0x0
        public static UnityEngine.FindObjectsSortMode InstanceID;        // 0x0

    }

    // TypeToken: 0x200019C
    public struct FindObjectsInactive
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.FindObjectsInactive Exclude;        // 0x0
        public static UnityEngine.FindObjectsInactive Include;        // 0x0

    }

    // TypeToken: 0x200019D
    public class Object
    {
        // Fields
        private System.IntPtr m_CachedPtr;        // 0x10
        private static System.Int32 OffsetOfInstanceIDInCPlusPlusObject;        // 0x0
        private static System.String objectIsNullMessage;        // 0x0
        private static System.String cloneDestroyedMessage;        // 0x0

        // Methods
        private System.Int32 GetInstanceID() { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean op_Implicit(UnityEngine.Object exists) { }
        private System.Boolean CompareBaseObjects(UnityEngine.Object lhs, UnityEngine.Object rhs) { }
        private System.Void EnsureRunningOnMainThread() { }
        private System.Boolean IsNativeObjectAlive(UnityEngine.Object o) { }
        private System.IntPtr GetCachedPtr() { }
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        private UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, UnityEngine.Transform parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        private UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, System.Int32 count, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        private UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, System.Int32 count, UnityEngine.Transform parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        private T InstantiateAsyncImmediately(T original, UnityEngine.Transform parent) { }
        private T InstantiateAsyncImmediately(T original, UnityEngine.Transform parent, System.Boolean worldPositionStays) { }
        private System.Int32 GetNameHashCode() { }
        private System.Int32 GetNameHashCode(System.String name) { }
        private System.Int32 GetNameHashCode(System.Byte* name) { }
        private System.Void GetNameNoAlloc(System.String name) { }
        private System.Boolean CompareName(System.String name) { }
        private System.Boolean NameContains(System.String substring) { }
        private UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        private UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent) { }
        private UnityEngine.Object Instantiate(UnityEngine.Object original) { }
        private UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent) { }
        private UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent, System.Boolean instantiateInWorldSpace) { }
        private T Instantiate(T original) { }
        private T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        private T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent) { }
        private T Instantiate(T original, UnityEngine.Transform parent) { }
        private T Instantiate(T original, UnityEngine.Transform parent, System.Boolean worldPositionStays) { }
        private System.Void Destroy(UnityEngine.Object obj, System.Single t) { }
        private System.Void Destroy(UnityEngine.Object obj) { }
        private System.Void DestroyImmediate(UnityEngine.Object obj, System.Boolean allowDestroyingAssets) { }
        private System.Void DestroyImmediate(UnityEngine.Object obj) { }
        private UnityEngine.Object[] FindObjectsOfType(System.Type type) { }
        private UnityEngine.Object[] FindObjectsOfType(System.Type type, System.Boolean includeInactive) { }
        private UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsSortMode sortMode) { }
        private UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode) { }
        private System.Void DontDestroyOnLoad(UnityEngine.Object target) { }
        private UnityEngine.HideFlags get_hideFlags() { }
        private System.Void set_hideFlags(UnityEngine.HideFlags value) { }
        private System.Void DestroyObject(UnityEngine.Object obj, System.Single t) { }
        private System.Void DestroyObject(UnityEngine.Object obj) { }
        private UnityEngine.Object[] FindSceneObjectsOfType(System.Type type) { }
        private UnityEngine.Object[] FindObjectsOfTypeIncludingAssets(System.Type type) { }
        private T[] FindObjectsOfType() { }
        private T[] FindObjectsByType(UnityEngine.FindObjectsSortMode sortMode) { }
        private T[] FindObjectsOfType(System.Boolean includeInactive) { }
        private T[] FindObjectsByType(UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode) { }
        private T FindObjectOfType() { }
        private T FindObjectOfType(System.Boolean includeInactive) { }
        private T FindFirstObjectByType() { }
        private T FindAnyObjectByType() { }
        private T FindFirstObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive) { }
        private T FindAnyObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive) { }
        private UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type) { }
        private System.Void CheckNullArgument(System.Object arg, System.String message) { }
        private UnityEngine.Object FindObjectOfType(System.Type type) { }
        private UnityEngine.Object FindFirstObjectByType(System.Type type) { }
        private UnityEngine.Object FindAnyObjectByType(System.Type type) { }
        private UnityEngine.Object FindObjectOfType(System.Type type, System.Boolean includeInactive) { }
        private UnityEngine.Object FindFirstObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive) { }
        private UnityEngine.Object FindAnyObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive) { }
        private System.String ToString() { }
        private System.Boolean op_Equality(UnityEngine.Object x, UnityEngine.Object y) { }
        private System.Boolean op_Inequality(UnityEngine.Object x, UnityEngine.Object y) { }
        private System.Int32 GetOffsetOfInstanceIDInCPlusPlusObject() { }
        private System.Boolean CurrentThreadIsMainThread() { }
        private UnityEngine.Object Internal_CloneSingle(UnityEngine.Object data) { }
        private UnityEngine.Object Internal_CloneSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, System.Boolean worldPositionStays) { }
        private UnityEngine.AsyncInstantiateOperation Internal_InstantiateAsyncWithParent(UnityEngine.Object original, System.Int32 count, UnityEngine.Transform parent, System.IntPtr position, System.IntPtr rotation) { }
        private UnityEngine.Object Internal_InstantiateAsyncImmediatelyWithParent(UnityEngine.Object original, UnityEngine.Transform parent, System.Boolean worldPositionStays) { }
        private UnityEngine.Object Internal_InstantiateSingle(UnityEngine.Object data, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        private UnityEngine.Object Internal_InstantiateSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot) { }
        private System.String ToString(UnityEngine.Object obj) { }
        private System.String GetName(UnityEngine.Object obj) { }
        private System.Int32 GetNameHashCode(UnityEngine.Object obj) { }
        private System.Int32 GetHashCodeByName(System.String name) { }
        private System.Int32 UnsafeGetHashCodeByName(System.Byte* name) { }
        private System.Boolean Internal_CompareName(UnityEngine.Object obj, System.String name) { }
        private System.Boolean Internal_NameContains(UnityEngine.Object obj, System.String substring) { }
        private System.Void Internal_GetNameNoAlloc(UnityEngine.Object obj, System.String name) { }
        private System.Boolean IsPersistent(UnityEngine.Object obj) { }
        private System.Void SetName(UnityEngine.Object obj, System.String name) { }
        private System.Boolean DoesObjectWithInstanceIDExist(System.Int32 instanceID) { }
        private UnityEngine.Object FindObjectFromInstanceID(System.Int32 instanceID) { }
        private UnityEngine.Object ForceLoadFromInstanceID(System.Int32 instanceID) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }
        private UnityEngine.Object Internal_InstantiateSingle_Injected(UnityEngine.Object data, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot) { }
        private UnityEngine.Object Internal_InstantiateSingleWithParent_Injected(UnityEngine.Object data, UnityEngine.Transform parent, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot) { }

    }

    // TypeToken: 0x200019E
    public class UnitySynchronizationContext : SynchronizationContext
    {
        // Fields
        private readonly System.Collections.Generic.List<UnityEngine.UnitySynchronizationContext.WorkRequest> m_AsyncWorkQueue;        // 0x18
        private readonly System.Collections.Generic.List<UnityEngine.UnitySynchronizationContext.WorkRequest> m_CurrentFrameWork;        // 0x20
        private readonly System.Int32 m_MainThreadID;        // 0x28
        private System.Int32 m_TrackedCount;        // 0x2C

        // Methods
        private System.Void .ctor(System.Int32 mainThreadID) { }
        private System.Void .ctor(System.Collections.Generic.List<UnityEngine.UnitySynchronizationContext.WorkRequest> queue, System.Int32 mainThreadID) { }
        private System.Void Send(System.Threading.SendOrPostCallback callback, System.Object state) { }
        private System.Void OperationStarted() { }
        private System.Void OperationCompleted() { }
        private System.Void Post(System.Threading.SendOrPostCallback callback, System.Object state) { }
        private System.Threading.SynchronizationContext CreateCopy() { }
        private System.Void Exec() { }
        private System.Boolean HasPendingTasks() { }
        private System.Void InitializeSynchronizationContext() { }
        private System.Void ExecuteTasks() { }
        private System.Boolean ExecutePendingTasks(System.Int64 millisecondsTimeout) { }

    }

    // TypeToken: 0x20001A0
    public class WaitForEndOfFrame : YieldInstruction
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001A1
    public class WaitForFixedUpdate : YieldInstruction
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001A2
    public class WaitForSeconds : YieldInstruction
    {
        // Fields
        private System.Single m_Seconds;        // 0x10

        // Methods
        private System.Void .ctor(System.Single seconds) { }

    }

    // TypeToken: 0x20001A3
    public class WaitForSecondsRealtime : CustomYieldInstruction
    {
        // Fields
        private System.Single <waitTime>k__BackingField;        // 0x10
        private System.Single m_WaitUntilTime;        // 0x14

        // Methods
        private System.Single get_waitTime() { }
        private System.Void set_waitTime(System.Single value) { }
        private System.Boolean get_keepWaiting() { }
        private System.Void .ctor(System.Single time) { }
        private System.Void Reset() { }

    }

    // TypeToken: 0x20001A4
    public class WaitUntil : CustomYieldInstruction
    {
        // Fields
        private System.Func<System.Boolean> m_Predicate;        // 0x10

        // Methods
        private System.Boolean get_keepWaiting() { }
        private System.Void .ctor(System.Func<System.Boolean> predicate) { }

    }

    // TypeToken: 0x20001A5
    public class WaitWhile : CustomYieldInstruction
    {
        // Fields
        private System.Func<System.Boolean> m_Predicate;        // 0x10

        // Methods
        private System.Boolean get_keepWaiting() { }
        private System.Void .ctor(System.Func<System.Boolean> predicate) { }

    }

    // TypeToken: 0x20001A6
    public class YieldInstruction
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001A7
    public class SerializeField : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001A8
    public class SerializeReference : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001A9
    public class PreferBinarySerialization : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001AA
    public interface ISerializationCallbackReceiver
    {
        // Methods
        private System.Void OnBeforeSerialize() { }
        private System.Void OnAfterDeserialize() { }

    }

    // TypeToken: 0x20001AB
    public class ComputeBuffer, IDisposable
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10

        // Methods
        private System.IntPtr GetNativePtr() { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.IntPtr InitBuffer(System.Int32 count, System.Int32 stride, UnityEngine.ComputeBufferType type, UnityEngine.ComputeBufferMode usage) { }
        private System.Void DestroyBuffer(UnityEngine.ComputeBuffer buf) { }
        private System.Void .ctor(System.Int32 count, System.Int32 stride) { }
        private System.Void .ctor(System.Int32 count, System.Int32 stride, UnityEngine.ComputeBufferType type) { }
        private System.Void .ctor(System.Int32 count, System.Int32 stride, UnityEngine.ComputeBufferType type, UnityEngine.ComputeBufferMode usage) { }
        private System.Void .ctor(System.Int32 count, System.Int32 stride, UnityEngine.ComputeBufferType type, UnityEngine.ComputeBufferMode usage, System.Int32 stackDepth) { }
        private System.Void Release() { }
        private System.Boolean IsValidBuffer(UnityEngine.ComputeBuffer buf) { }
        private System.Boolean IsValid() { }
        private System.Int32 get_count() { }
        private System.Int32 get_stride() { }
        private UnityEngine.ComputeBufferMode get_usage() { }
        private System.Void SetData(System.Array data) { }
        private System.Void SetData(System.Collections.Generic.List<T> data) { }
        private System.Void SetData(Unity.Collections.NativeArray<T> data) { }
        private System.Void SetData(Unity.Collections.NativeArray<T> data, System.Int32 nativeBufferStartIndex, System.Int32 computeBufferStartIndex, System.Int32 count) { }
        private System.Void InternalSetNativeData(System.IntPtr data, System.Int32 nativeBufferStartIndex, System.Int32 computeBufferStartIndex, System.Int32 count, System.Int32 elemSize) { }
        private System.Void InternalSetData(System.Array data, System.Int32 managedBufferStartIndex, System.Int32 computeBufferStartIndex, System.Int32 count, System.Int32 elemSize) { }
        private System.Void* BeginBufferWrite(System.Int32 offset, System.Int32 size) { }
        private Unity.Collections.NativeArray<T> BeginWrite(System.Int32 computeBufferStartIndex, System.Int32 count) { }
        private System.Void EndBufferWrite(System.Int32 bytesWritten) { }
        private System.Void EndWrite(System.Int32 countWritten) { }
        private System.Void set_name(System.String value) { }
        private System.Void SetName(System.String name) { }

    }

    // TypeToken: 0x20001AC
    public class ComputeShader
    {
        // Methods
        private System.Int32 FindKernel(System.String name) { }
        private System.Void SetInt(System.Int32 nameID, System.Int32 val) { }
        private System.Void Internal_SetBuffer(System.Int32 kernelIndex, System.Int32 nameID, UnityEngine.ComputeBuffer buffer) { }
        private System.Void Internal_SetGraphicsBuffer(System.Int32 kernelIndex, System.Int32 nameID, UnityEngine.GraphicsBuffer buffer) { }
        private System.Void Internal_HGSetBuffer(System.Int32 kernelIndex, System.Int32 nameID, System.UInt32 gfxBufferID) { }
        private System.Void HGSetBuffer(System.Int32 kernelIndex, System.Int32 nameID, System.UInt32 gfxBufferID) { }
        private System.Void SetBuffer(System.Int32 kernelIndex, System.Int32 nameID, UnityEngine.ComputeBuffer buffer) { }
        private System.Void SetBuffer(System.Int32 kernelIndex, System.Int32 nameID, UnityEngine.GraphicsBuffer buffer) { }
        private System.Void SetConstantComputeBuffer(System.Int32 nameID, UnityEngine.ComputeBuffer buffer, System.Int32 offset, System.Int32 size) { }
        private System.Void GetKernelThreadGroupSizes(System.Int32 kernelIndex, System.UInt32& x, System.UInt32& y, System.UInt32& z) { }
        private System.Void Dispatch(System.Int32 kernelIndex, System.Int32 threadGroupsX, System.Int32 threadGroupsY, System.Int32 threadGroupsZ) { }
        private UnityEngine.Rendering.LocalKeywordSpace get_keywordSpace() { }
        private System.Void EnableKeyword(System.String keyword) { }
        private System.Void DisableKeyword(System.String keyword) { }
        private System.Boolean IsSupported(System.Int32 kernelIndex) { }
        private System.Void SetShaderKeywords(System.String[] names) { }
        private System.Void set_shaderKeywords(System.String[] value) { }
        private System.Void SetInt(System.String name, System.Int32 val) { }
        private System.Void SetBuffer(System.Int32 kernelIndex, System.String name, UnityEngine.ComputeBuffer buffer) { }
        private System.Void SetBuffer(System.Int32 kernelIndex, System.String name, UnityEngine.GraphicsBuffer buffer) { }
        private System.Void SetConstantBuffer(System.Int32 nameID, UnityEngine.ComputeBuffer buffer, System.Int32 offset, System.Int32 size) { }
        private System.Void get_keywordSpace_Injected(UnityEngine.Rendering.LocalKeywordSpace& ret) { }

    }

    // TypeToken: 0x20001AD
    public struct HGPsoExtInfo
    {
        // Fields
        public System.Single createTime;        // 0x10
        public System.Int32 codeSize;        // 0x14
        public System.Boolean isMissing;        // 0x18
        public System.String levelId;        // 0x20

    }

    // TypeToken: 0x20001AE
    public class HGPsoUtil
    {
        // Fields
        private static System.Action<System.String,UnityEngine.HGPsoExtInfo> onRenderPipelineUpload;        // 0x0
        private static UnityEngine.HGPsoUtil.GetLevelIdDelegate onUpdateGameInfo;        // 0x8

        // Methods
        private System.Void add_onRenderPipelineUpload(System.Action<System.String,UnityEngine.HGPsoExtInfo> value) { }
        private System.Void remove_onRenderPipelineUpload(System.Action<System.String,UnityEngine.HGPsoExtInfo> value) { }
        private System.Void InvokeOnRenderPipelineUploadV2(System.String infoJson, System.Single createTime, System.Int32 codeSize, System.Boolean isMissing, System.String levelId) { }
        private System.Void add_onUpdateGameInfo(UnityEngine.HGPsoUtil.GetLevelIdDelegate value) { }
        private System.Void remove_onUpdateGameInfo(UnityEngine.HGPsoUtil.GetLevelIdDelegate value) { }
        private System.String GetLevelId() { }
        private System.Boolean IsPsoRecordEnabled() { }

    }

    // TypeToken: 0x20001B0
    public class HGPsoWarmupCollection
    {
        // Methods
        private System.Void UploadPipelineCreatedInfoInternal() { }
        private System.Void SavePipelineCacheInternal() { }
        private System.Boolean IsCompilingStageInternal(System.Int32 index) { }
        private System.Int32 GetInfoCountInternal() { }
        private System.Void ScheduleIndexInternal(System.Int32 index, System.Boolean background) { }
        private System.Void DispatchAllInternal() { }
        private System.Int32 GetRemainingJobCountInternal() { }
        private System.Void UploadPipelineCreatedInfo() { }
        private System.Void SavePipelineCache() { }
        private System.Boolean IsCompilingStage(System.Int32 index) { }
        private System.Int32 GetInfoCount() { }
        private System.Int32 GetRemainingJobCount() { }

    }

    // TypeToken: 0x20001B2
    public class HGSubsurfaceProfile
    {
        // Fields
        public static System.Int32 LutSize;        // 0x0

        // Methods
        private UnityEngine.Vector3 get_subsurfaceNormalLerp() { }
        private System.Single get_curvatureScale() { }
        private System.Single get_penumbraScale() { }
        private UnityEngine.Texture2D get_scatterLut() { }
        private UnityEngine.Texture2D get_penumbraLut() { }
        private UnityEngine.Texture2D get_indirectLut() { }
        private System.Void .ctor() { }
        private System.Void Internal_Create(UnityEngine.HGSubsurfaceProfile self) { }
        private System.Void get_subsurfaceNormalLerp_Injected(UnityEngine.Vector3& ret) { }

    }

    // TypeToken: 0x20001B3
    public class LowerResBlitTexture
    {
        // Methods
        private System.Void LowerResBlitTextureDontStripMe() { }

    }

    // TypeToken: 0x20001B4
    public class PreloadData
    {
        // Methods
        private System.Void PreloadDataDontStripMe() { }

    }

    // TypeToken: 0x20001B5
    public struct BatteryStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.BatteryStatus Unknown;        // 0x0
        public static UnityEngine.BatteryStatus Charging;        // 0x0
        public static UnityEngine.BatteryStatus Discharging;        // 0x0
        public static UnityEngine.BatteryStatus NotCharging;        // 0x0
        public static UnityEngine.BatteryStatus Full;        // 0x0

    }

    // TypeToken: 0x20001B6
    public struct OperatingSystemFamily
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.OperatingSystemFamily Other;        // 0x0
        public static UnityEngine.OperatingSystemFamily MacOSX;        // 0x0
        public static UnityEngine.OperatingSystemFamily Windows;        // 0x0
        public static UnityEngine.OperatingSystemFamily Linux;        // 0x0

    }

    // TypeToken: 0x20001B7
    public struct DeviceType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.DeviceType Unknown;        // 0x0
        public static UnityEngine.DeviceType Handheld;        // 0x0
        public static UnityEngine.DeviceType Console;        // 0x0
        public static UnityEngine.DeviceType Desktop;        // 0x0

    }

    // TypeToken: 0x20001B8
    public class SystemInfo
    {
        // Methods
        private System.Single get_batteryLevel() { }
        private UnityEngine.BatteryStatus get_batteryStatus() { }
        private System.String get_operatingSystem() { }
        private UnityEngine.OperatingSystemFamily get_operatingSystemFamily() { }
        private System.String get_bootParameters() { }
        private System.String get_processorType() { }
        private System.Int32 get_processorCount() { }
        private System.Int32 get_systemMemorySize() { }
        private System.String get_deviceUniqueIdentifier() { }
        private System.String get_deviceName() { }
        private System.String get_deviceModel() { }
        private System.String get_socModel() { }
        private System.Boolean get_supportsAccelerometer() { }
        private System.Boolean get_supportsGyroscope() { }
        private System.Boolean get_supportsLocationService() { }
        private System.Boolean get_supportsVibration() { }
        private System.Boolean get_supportsAudio() { }
        private UnityEngine.DeviceType get_deviceType() { }
        private System.Int32 get_graphicsMemorySize() { }
        private System.String get_graphicsDeviceName() { }
        private System.String get_graphicsDeviceVendor() { }
        private UnityEngine.Rendering.GraphicsDeviceType get_graphicsDeviceType() { }
        private System.String get_nvidiaDriverVersion() { }
        private System.Boolean get_graphicsUVStartsAtTop() { }
        private System.String get_graphicsDeviceVersion() { }
        private System.Int32 get_graphicsShaderLevel() { }
        private System.Boolean get_graphicsMultiThreaded() { }
        private System.Boolean get_hasHiddenSurfaceRemovalOnGPU() { }
        private System.Boolean get_hasDynamicUniformArrayIndexingInFragmentShaders() { }
        private System.Boolean get_supportsShadows() { }
        private System.Boolean get_supportsRawShadowDepthSampling() { }
        private System.Boolean get_supportsMotionVectors() { }
        private System.Boolean get_supportsRenderToCubemap() { }
        private System.Boolean get_supportsImageEffects() { }
        private System.Boolean get_supports3DTextures() { }
        private System.Boolean get_supports2DArrayTextures() { }
        private System.Boolean get_supports3DRenderTextures() { }
        private System.Boolean get_supportsCubemapArrayTextures() { }
        private UnityEngine.Rendering.CopyTextureSupport get_copyTextureSupport() { }
        private System.Boolean get_supportsComputeShaders() { }
        private System.Boolean get_supportsRenderTargetArrayIndexFromVertexShader() { }
        private System.Boolean get_supportsInstancing() { }
        private System.Boolean get_supportsHardwareQuadTopology() { }
        private System.Boolean get_supports32bitsIndexBuffer() { }
        private System.Boolean get_supportsSparseTextures() { }
        private System.Int32 get_supportedRenderTargetCount() { }
        private System.Boolean get_supportsSeparatedRenderTargetsBlend() { }
        private System.Int32 get_supportedRandomWriteTargetCount() { }
        private System.Int32 get_supportsMultisampledTextures() { }
        private System.Int32 get_supportsTextureWrapMirrorOnce() { }
        private System.Boolean get_usesReversedZBuffer() { }
        private System.Boolean IsValidEnumValue(System.Enum value) { }
        private System.Boolean SupportsRenderTextureFormat(UnityEngine.RenderTextureFormat format) { }
        private System.Boolean SupportsTextureFormat(UnityEngine.TextureFormat format) { }
        private System.Int32 get_maxTextureSize() { }
        private System.Int32 get_maxRenderTextureSize() { }
        private System.Boolean get_supportsGraphicsFence() { }
        private System.Boolean get_supportsAsyncGPUReadback() { }
        private System.Boolean get_supportsRayTracing() { }
        private System.UInt32 get_waveIntrinsicsSupportedStages() { }
        private System.UInt32 get_waveIntrinsicsSupportedOperations() { }
        private System.Boolean get_supportsMetalFXSpatialScaler() { }
        private System.Boolean get_supportsMetalFXTemporalScaler() { }
        private System.Int32 get_constantBufferOffsetAlignment() { }
        private System.Int64 get_maxGraphicsBufferSize() { }
        private UnityEngine.HDRDisplaySupportFlags get_hdrDisplaySupportFlags() { }
        private System.Single GetBatteryLevel() { }
        private UnityEngine.BatteryStatus GetBatteryStatus() { }
        private System.String GetOperatingSystem() { }
        private UnityEngine.OperatingSystemFamily GetOperatingSystemFamily() { }
        private System.String HGGetBootParameters() { }
        private System.String GetProcessorType() { }
        private System.Int32 GetProcessorCount() { }
        private System.Int32 GetPhysicalMemoryMB() { }
        private System.String GetDeviceUniqueIdentifier() { }
        private System.String GetDeviceName() { }
        private System.String GetDeviceModel() { }
        private System.String GetSOCModel() { }
        private System.Boolean SupportsAccelerometer() { }
        private System.Boolean IsGyroAvailable() { }
        private System.Boolean SupportsLocationService() { }
        private System.Boolean SupportsVibration() { }
        private System.Boolean SupportsAudio() { }
        private UnityEngine.DeviceType GetDeviceType() { }
        private System.Int32 GetGraphicsMemorySize() { }
        private System.String GetGraphicsDeviceName() { }
        private System.String GetGraphicsDeviceVendor() { }
        private UnityEngine.Rendering.GraphicsDeviceType GetGraphicsDeviceType() { }
        private System.String GetNvidiaDriverVersion() { }
        private System.Boolean GetGraphicsUVStartsAtTop() { }
        private System.String GetGraphicsDeviceVersion() { }
        private System.Int32 GetGraphicsShaderLevel() { }
        private System.Boolean GetGraphicsMultiThreaded() { }
        private System.Boolean HasHiddenSurfaceRemovalOnGPU() { }
        private System.Boolean HasDynamicUniformArrayIndexingInFragmentShaders() { }
        private System.Boolean SupportsShadows() { }
        private System.Boolean SupportsRawShadowDepthSampling() { }
        private System.Boolean SupportsMotionVectors() { }
        private System.Boolean Supports3DTextures() { }
        private System.Boolean Supports2DArrayTextures() { }
        private System.Boolean Supports3DRenderTextures() { }
        private System.Boolean SupportsCubemapArrayTextures() { }
        private UnityEngine.Rendering.CopyTextureSupport GetCopyTextureSupport() { }
        private System.Boolean SupportsComputeShaders() { }
        private System.Boolean SupportsRenderTargetArrayIndexFromVertexShader() { }
        private System.Boolean SupportsInstancing() { }
        private System.Boolean SupportsHardwareQuadTopology() { }
        private System.Boolean Supports32bitsIndexBuffer() { }
        private System.Boolean SupportsSparseTextures() { }
        private System.Int32 SupportedRenderTargetCount() { }
        private System.Boolean SupportsSeparatedRenderTargetsBlend() { }
        private System.Int32 SupportedRandomWriteTargetCount() { }
        private System.Int32 SupportsMultisampledTextures() { }
        private System.Int32 SupportsTextureWrapMirrorOnce() { }
        private System.Boolean UsesReversedZBuffer() { }
        private System.Boolean HasRenderTextureNative(UnityEngine.RenderTextureFormat format) { }
        private System.Boolean SupportsTextureFormatNative(UnityEngine.TextureFormat format) { }
        private System.Int32 GetMaxTextureSize() { }
        private System.Int32 GetMaxRenderTextureSize() { }
        private System.Boolean SupportsGPUFence() { }
        private System.Boolean SupportsAsyncGPUReadback() { }
        private System.Boolean SupportsRayTracing() { }
        private System.UInt32 GetWaveIntrinsicsSupportedStages() { }
        private System.UInt32 GetWaveIntrinsicsSupportedOperations() { }
        private System.Boolean SupportsMetalFXSpatialScaler() { }
        private System.Boolean SupportsMetalFXTemporalScaler() { }
        private System.Int32 MinConstantBufferOffsetAlignment() { }
        private System.Int64 MaxGraphicsBufferSize() { }
        private System.Boolean IsFormatSupported(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage) { }
        private UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage) { }
        private UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.Experimental.Rendering.DefaultFormat format) { }
        private UnityEngine.HDRDisplaySupportFlags GetHDRDisplaySupportFlags() { }

    }

    // TypeToken: 0x20001B9
    public class SystemClock
    {
        // Fields
        private static readonly System.DateTime s_Epoch;        // 0x0

        // Methods
        private System.DateTime get_now() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001BA
    public class Time
    {
        // Methods
        private System.Single get_time() { }
        private System.Double get_timeAsDouble() { }
        private System.Single get_timeSinceLevelLoad() { }
        private System.Double get_timeSinceLevelLoadAsDouble() { }
        private System.Single get_deltaTime() { }
        private System.Single get_fixedTime() { }
        private System.Double get_fixedTimeAsDouble() { }
        private System.Single get_unscaledTime() { }
        private System.Double get_unscaledTimeAsDouble() { }
        private System.Single get_fixedUnscaledTime() { }
        private System.Double get_fixedUnscaledTimeAsDouble() { }
        private System.Single get_unscaledDeltaTime() { }
        private System.Single get_fixedUnscaledDeltaTime() { }
        private System.Single get_fixedDeltaTime() { }
        private System.Void set_fixedDeltaTime(System.Single value) { }
        private System.Single get_maximumDeltaTime() { }
        private System.Void set_maximumDeltaTime(System.Single value) { }
        private System.Single get_smoothDeltaTime() { }
        private System.Single get_maximumParticleDeltaTime() { }
        private System.Void set_maximumParticleDeltaTime(System.Single value) { }
        private System.Single get_timeScale() { }
        private System.Void set_timeScale(System.Single value) { }
        private System.Int32 get_frameCount() { }
        private System.Int32 get_renderedFrameCount() { }
        private System.Single get_realtimeSinceStartup() { }
        private System.Double get_realtimeSinceStartupAsDouble() { }
        private System.Single get_captureDeltaTime() { }
        private System.Void set_captureDeltaTime(System.Single value) { }
        private System.Int32 get_captureFramerate() { }
        private System.Void set_captureFramerate(System.Int32 value) { }
        private System.Boolean get_inFixedTimeStep() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001BB
    public struct TouchScreenKeyboard_InternalConstructorHelperArguments
    {
        // Fields
        public System.UInt32 keyboardType;        // 0x10
        public System.UInt32 autocorrection;        // 0x14
        public System.UInt32 multiline;        // 0x18
        public System.UInt32 secure;        // 0x1C
        public System.UInt32 alert;        // 0x20
        public System.Int32 characterLimit;        // 0x24

    }

    // TypeToken: 0x20001BC
    public class TouchScreenKeyboard
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10
        private static System.Boolean <disableInPlaceEditing>k__BackingField;        // 0x0

        // Methods
        private System.Void Internal_Destroy(System.IntPtr ptr) { }
        private System.Void Destroy() { }
        private System.Void Finalize() { }
        private System.Void .ctor(System.String text, UnityEngine.TouchScreenKeyboardType keyboardType, System.Boolean autocorrection, System.Boolean multiline, System.Boolean secure, System.Boolean alert, System.String textPlaceholder, System.Int32 characterLimit) { }
        private System.IntPtr TouchScreenKeyboard_InternalConstructorHelper(UnityEngine.TouchScreenKeyboard_InternalConstructorHelperArguments& arguments, System.String text, System.String textPlaceholder) { }
        private System.Boolean get_isSupported() { }
        private System.Boolean get_disableInPlaceEditing() { }
        private System.Boolean get_isInPlaceEditingAllowed() { }
        private UnityEngine.TouchScreenKeyboard Open(System.String text, UnityEngine.TouchScreenKeyboardType keyboardType, System.Boolean autocorrection, System.Boolean multiline, System.Boolean secure, System.Boolean alert, System.String textPlaceholder, System.Int32 characterLimit) { }
        private UnityEngine.TouchScreenKeyboard Open(System.String text, UnityEngine.TouchScreenKeyboardType keyboardType, System.Boolean autocorrection, System.Boolean multiline, System.Boolean secure) { }
        private System.String get_text() { }
        private System.Void set_text(System.String value) { }
        private System.Void set_hideInput(System.Boolean value) { }
        private System.Boolean get_active() { }
        private System.Void set_active(System.Boolean value) { }
        private UnityEngine.TouchScreenKeyboard.Status get_status() { }
        private System.Void set_characterLimit(System.Int32 value) { }
        private System.Boolean get_canGetSelection() { }
        private System.Boolean get_canSetSelection() { }
        private UnityEngine.RangeInt get_selection() { }
        private System.Void set_selection(UnityEngine.RangeInt value) { }
        private System.Void GetSelection(System.Int32& start, System.Int32& length) { }
        private System.Void SetSelection(System.Int32 start, System.Int32 length) { }

    }

    // TypeToken: 0x20001BE
    public struct TouchScreenKeyboardType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TouchScreenKeyboardType Default;        // 0x0
        public static UnityEngine.TouchScreenKeyboardType ASCIICapable;        // 0x0
        public static UnityEngine.TouchScreenKeyboardType NumbersAndPunctuation;        // 0x0
        public static UnityEngine.TouchScreenKeyboardType URL;        // 0x0
        public static UnityEngine.TouchScreenKeyboardType NumberPad;        // 0x0
        public static UnityEngine.TouchScreenKeyboardType PhonePad;        // 0x0
        public static UnityEngine.TouchScreenKeyboardType NamePhonePad;        // 0x0
        public static UnityEngine.TouchScreenKeyboardType EmailAddress;        // 0x0
        public static UnityEngine.TouchScreenKeyboardType NintendoNetworkAccount;        // 0x0
        public static UnityEngine.TouchScreenKeyboardType Social;        // 0x0
        public static UnityEngine.TouchScreenKeyboardType Search;        // 0x0
        public static UnityEngine.TouchScreenKeyboardType DecimalPad;        // 0x0
        public static UnityEngine.TouchScreenKeyboardType OneTimeCode;        // 0x0

    }

    // TypeToken: 0x20001BF
    public class FrameDebugger
    {
        // Methods
        private System.Boolean get_enabled() { }
        private System.Boolean IsLocalEnabled() { }
        private System.Boolean IsRemoteEnabled() { }

    }

    // TypeToken: 0x20001C0
    public struct DrivenTransformProperties
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.DrivenTransformProperties None;        // 0x0
        public static UnityEngine.DrivenTransformProperties All;        // 0x0
        public static UnityEngine.DrivenTransformProperties AnchoredPositionX;        // 0x0
        public static UnityEngine.DrivenTransformProperties AnchoredPositionY;        // 0x0
        public static UnityEngine.DrivenTransformProperties AnchoredPositionZ;        // 0x0
        public static UnityEngine.DrivenTransformProperties Rotation;        // 0x0
        public static UnityEngine.DrivenTransformProperties ScaleX;        // 0x0
        public static UnityEngine.DrivenTransformProperties ScaleY;        // 0x0
        public static UnityEngine.DrivenTransformProperties ScaleZ;        // 0x0
        public static UnityEngine.DrivenTransformProperties AnchorMinX;        // 0x0
        public static UnityEngine.DrivenTransformProperties AnchorMinY;        // 0x0
        public static UnityEngine.DrivenTransformProperties AnchorMaxX;        // 0x0
        public static UnityEngine.DrivenTransformProperties AnchorMaxY;        // 0x0
        public static UnityEngine.DrivenTransformProperties SizeDeltaX;        // 0x0
        public static UnityEngine.DrivenTransformProperties SizeDeltaY;        // 0x0
        public static UnityEngine.DrivenTransformProperties PivotX;        // 0x0
        public static UnityEngine.DrivenTransformProperties PivotY;        // 0x0
        public static UnityEngine.DrivenTransformProperties AnchoredPosition;        // 0x0
        public static UnityEngine.DrivenTransformProperties AnchoredPosition3D;        // 0x0
        public static UnityEngine.DrivenTransformProperties Scale;        // 0x0
        public static UnityEngine.DrivenTransformProperties AnchorMin;        // 0x0
        public static UnityEngine.DrivenTransformProperties AnchorMax;        // 0x0
        public static UnityEngine.DrivenTransformProperties Anchors;        // 0x0
        public static UnityEngine.DrivenTransformProperties SizeDelta;        // 0x0
        public static UnityEngine.DrivenTransformProperties Pivot;        // 0x0

    }

    // TypeToken: 0x20001C1
    public struct DrivenRectTransformTracker
    {
        // Methods
        private System.Void Add(UnityEngine.Object driver, UnityEngine.RectTransform rectTransform, UnityEngine.DrivenTransformProperties drivenProperties) { }
        private System.Void Clear() { }

    }

    // TypeToken: 0x20001C2
    public class RectTransform : Transform
    {
        // Fields
        private static UnityEngine.RectTransform.ReapplyDrivenProperties reapplyDrivenProperties;        // 0x0

        // Methods
        private System.Void add_reapplyDrivenProperties(UnityEngine.RectTransform.ReapplyDrivenProperties value) { }
        private System.Void remove_reapplyDrivenProperties(UnityEngine.RectTransform.ReapplyDrivenProperties value) { }
        private UnityEngine.Rect get_rect() { }
        private UnityEngine.Vector2 get_anchorMin() { }
        private System.Void set_anchorMin(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 get_anchorMax() { }
        private System.Void set_anchorMax(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 get_anchoredPosition() { }
        private System.Void set_anchoredPosition(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 get_sizeDelta() { }
        private System.Void set_sizeDelta(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 get_pivot() { }
        private System.Void set_pivot(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector3 get_anchoredPosition3D() { }
        private System.Void set_anchoredPosition3D(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector2 get_offsetMin() { }
        private System.Void set_offsetMin(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 get_offsetMax() { }
        private System.Void set_offsetMax(UnityEngine.Vector2 value) { }
        private UnityEngine.Object get_drivenByObject() { }
        private System.Void set_drivenByObject(UnityEngine.Object value) { }
        private UnityEngine.DrivenTransformProperties get_drivenProperties() { }
        private System.Void set_drivenProperties(UnityEngine.DrivenTransformProperties value) { }
        private System.Void ForceUpdateRectTransforms() { }
        private System.Void GetLocalCorners(UnityEngine.Vector3[] fourCornersArray) { }
        private System.Void GetWorldCorners(UnityEngine.Vector3[] fourCornersArray) { }
        private System.Void SetInsetAndSizeFromParentEdge(UnityEngine.RectTransform.Edge edge, System.Single inset, System.Single size) { }
        private System.Void SetSizeWithCurrentAnchors(UnityEngine.RectTransform.Axis axis, System.Single size) { }
        private System.Void SendReapplyDrivenProperties(UnityEngine.RectTransform driven) { }
        private UnityEngine.Rect GetRectInParentSpace() { }
        private UnityEngine.Vector2 GetParentSize() { }
        private System.Void .ctor() { }
        private System.Void get_rect_Injected(UnityEngine.Rect& ret) { }
        private System.Void get_anchorMin_Injected(UnityEngine.Vector2& ret) { }
        private System.Void set_anchorMin_Injected(UnityEngine.Vector2& value) { }
        private System.Void get_anchorMax_Injected(UnityEngine.Vector2& ret) { }
        private System.Void set_anchorMax_Injected(UnityEngine.Vector2& value) { }
        private System.Void get_anchoredPosition_Injected(UnityEngine.Vector2& ret) { }
        private System.Void set_anchoredPosition_Injected(UnityEngine.Vector2& value) { }
        private System.Void get_sizeDelta_Injected(UnityEngine.Vector2& ret) { }
        private System.Void set_sizeDelta_Injected(UnityEngine.Vector2& value) { }
        private System.Void get_pivot_Injected(UnityEngine.Vector2& ret) { }
        private System.Void set_pivot_Injected(UnityEngine.Vector2& value) { }

    }

    // TypeToken: 0x20001C6
    public struct RotationOrder
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.RotationOrder OrderXYZ;        // 0x0
        public static UnityEngine.RotationOrder OrderXZY;        // 0x0
        public static UnityEngine.RotationOrder OrderYZX;        // 0x0
        public static UnityEngine.RotationOrder OrderYXZ;        // 0x0
        public static UnityEngine.RotationOrder OrderZXY;        // 0x0
        public static UnityEngine.RotationOrder OrderZYX;        // 0x0

    }

    // TypeToken: 0x20001C7
    public class Transform : Component, IEnumerable
    {
        // Methods
        private System.Void .ctor() { }
        private UnityEngine.Vector3 get_position() { }
        private System.Void set_position(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_localPosition() { }
        private System.Void set_localPosition(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 GetLocalEulerAngles(UnityEngine.RotationOrder order) { }
        private System.Void SetLocalEulerAngles(UnityEngine.Vector3 euler, UnityEngine.RotationOrder order) { }
        private System.Void SetLocalEulerHint(UnityEngine.Vector3 euler) { }
        private UnityEngine.Vector3 get_eulerAngles() { }
        private System.Void set_eulerAngles(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_localEulerAngles() { }
        private System.Void set_localEulerAngles(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_right() { }
        private System.Void set_right(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_up() { }
        private System.Void set_up(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_forward() { }
        private System.Void set_forward(UnityEngine.Vector3 value) { }
        private UnityEngine.Quaternion get_rotation() { }
        private System.Void set_rotation(UnityEngine.Quaternion value) { }
        private UnityEngine.Quaternion get_localRotation() { }
        private System.Void set_localRotation(UnityEngine.Quaternion value) { }
        private UnityEngine.RotationOrder get_rotationOrder() { }
        private System.Void set_rotationOrder(UnityEngine.RotationOrder value) { }
        private System.Int32 GetRotationOrderInternal() { }
        private System.Void SetRotationOrderInternal(UnityEngine.RotationOrder rotationOrder) { }
        private UnityEngine.Vector3 get_localScale() { }
        private System.Void set_localScale(UnityEngine.Vector3 value) { }
        private UnityEngine.Transform get_parent() { }
        private System.Void set_parent(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_parentInternal() { }
        private System.Void set_parentInternal(UnityEngine.Transform value) { }
        private UnityEngine.Transform GetParent() { }
        private System.Void SetParent(UnityEngine.Transform p) { }
        private System.Void SetParent(UnityEngine.Transform parent, System.Boolean worldPositionStays) { }
        private UnityEngine.Matrix4x4 get_worldToLocalMatrix() { }
        private UnityEngine.Matrix4x4 get_localToWorldMatrix() { }
        private UnityEngine.Matrix4x4 GetLocalToRelativeMatrix(UnityEngine.Transform relativeT) { }
        private System.Void SetPositionAndRotation(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        private System.Void SetLocalPositionAndRotation(UnityEngine.Vector3 localPosition, UnityEngine.Quaternion localRotation) { }
        private System.Void GetPositionAndRotation(UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation) { }
        private System.Void GetLocalPositionAndRotation(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation) { }
        private System.Void SetRelativePosition(UnityEngine.Transform relativeT, UnityEngine.Vector3 position) { }
        private System.Void GetRelativePositionAndRotation(UnityEngine.Transform relativeT, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation) { }
        private UnityEngine.Vector3 GetRelativePosition(UnityEngine.Transform relativeT) { }
        private System.Int32 GetHierarchyIndex() { }
        private System.Void Translate(UnityEngine.Vector3 translation, UnityEngine.Space relativeTo) { }
        private System.Void Translate(UnityEngine.Vector3 translation) { }
        private System.Void Translate(System.Single x, System.Single y, System.Single z, UnityEngine.Space relativeTo) { }
        private System.Void Translate(System.Single x, System.Single y, System.Single z) { }
        private System.Void Translate(UnityEngine.Vector3 translation, UnityEngine.Transform relativeTo) { }
        private System.Void Translate(System.Single x, System.Single y, System.Single z, UnityEngine.Transform relativeTo) { }
        private System.Void Rotate(UnityEngine.Vector3 eulers, UnityEngine.Space relativeTo) { }
        private System.Void Rotate(UnityEngine.Vector3 eulers) { }
        private System.Void Rotate(System.Single xAngle, System.Single yAngle, System.Single zAngle, UnityEngine.Space relativeTo) { }
        private System.Void Rotate(System.Single xAngle, System.Single yAngle, System.Single zAngle) { }
        private System.Void RotateAroundInternal(UnityEngine.Vector3 axis, System.Single angle) { }
        private System.Void Rotate(UnityEngine.Vector3 axis, System.Single angle, UnityEngine.Space relativeTo) { }
        private System.Void Rotate(UnityEngine.Vector3 axis, System.Single angle) { }
        private System.Void RotateAround(UnityEngine.Vector3 point, UnityEngine.Vector3 axis, System.Single angle) { }
        private System.Void LookAt(UnityEngine.Transform target, UnityEngine.Vector3 worldUp) { }
        private System.Void LookAt(UnityEngine.Transform target) { }
        private System.Void LookAt(UnityEngine.Vector3 worldPosition, UnityEngine.Vector3 worldUp) { }
        private System.Void LookAt(UnityEngine.Vector3 worldPosition) { }
        private System.Void Internal_LookAt(UnityEngine.Vector3 worldPosition, UnityEngine.Vector3 worldUp) { }
        private UnityEngine.Vector3 TransformDirection(UnityEngine.Vector3 direction) { }
        private UnityEngine.Vector3 TransformDirection(System.Single x, System.Single y, System.Single z) { }
        private UnityEngine.Vector3 InverseTransformDirection(UnityEngine.Vector3 direction) { }
        private UnityEngine.Vector3 InverseTransformDirection(System.Single x, System.Single y, System.Single z) { }
        private UnityEngine.Vector3 TransformVector(UnityEngine.Vector3 vector) { }
        private UnityEngine.Vector3 TransformVector(System.Single x, System.Single y, System.Single z) { }
        private UnityEngine.Vector3 InverseTransformVector(UnityEngine.Vector3 vector) { }
        private UnityEngine.Vector3 InverseTransformVector(System.Single x, System.Single y, System.Single z) { }
        private UnityEngine.Vector3 TransformPoint(UnityEngine.Vector3 position) { }
        private UnityEngine.Vector3 TransformPoint(System.Single x, System.Single y, System.Single z) { }
        private UnityEngine.Vector3 InverseTransformPoint(UnityEngine.Vector3 position) { }
        private UnityEngine.Vector3 InverseTransformPoint(System.Single x, System.Single y, System.Single z) { }
        private UnityEngine.Transform get_root() { }
        private UnityEngine.Transform GetRoot() { }
        private System.Int32 get_childCount() { }
        private System.Void DetachChildren() { }
        private System.Void SetAsFirstSibling() { }
        private System.Void SetAsLastSibling() { }
        private System.Void SetSiblingIndex(System.Int32 index) { }
        private System.Void MoveAfterSibling(UnityEngine.Transform transform, System.Boolean notifyEditorAndMarkDirty) { }
        private System.Int32 GetSiblingIndex() { }
        private UnityEngine.Transform FindRelativeTransformWithPath(UnityEngine.Transform transform, System.String path, System.Boolean isActiveOnly) { }
        private UnityEngine.Transform Find(System.String n) { }
        private UnityEngine.Transform FindTransformWithName(UnityEngine.Transform transform, System.String name) { }
        private UnityEngine.Transform FindRecursiveWithName(System.String name) { }
        private System.Void SendTransformChangedScale() { }
        private UnityEngine.Vector3 get_lossyScale() { }
        private System.Boolean IsChildOf(UnityEngine.Transform parent) { }
        private System.Boolean get_hasChanged() { }
        private System.Void set_hasChanged(System.Boolean value) { }
        private UnityEngine.Transform FindChild(System.String n) { }
        private System.Collections.IEnumerator GetEnumerator() { }
        private System.Void RotateAround(UnityEngine.Vector3 axis, System.Single angle) { }
        private System.Void RotateAroundLocal(UnityEngine.Vector3 axis, System.Single angle) { }
        private UnityEngine.Transform GetChild(System.Int32 index) { }
        private System.Int32 GetChildCount() { }
        private System.Int32 get_hierarchyCapacity() { }
        private System.Void set_hierarchyCapacity(System.Int32 value) { }
        private System.Int32 internal_getHierarchyCapacity() { }
        private System.Void internal_setHierarchyCapacity(System.Int32 value) { }
        private System.Int32 get_hierarchyCount() { }
        private System.Int32 internal_getHierarchyCount() { }
        private System.Boolean IsNonUniformScaleTransform() { }
        private System.Boolean get_constrainProportionsScale() { }
        private System.Void set_constrainProportionsScale(System.Boolean value) { }
        private System.Void SetConstrainProportionsScale(System.Boolean isLinked) { }
        private System.Boolean IsConstrainProportionsScale() { }
        private System.Void get_position_Injected(UnityEngine.Vector3& ret) { }
        private System.Void set_position_Injected(UnityEngine.Vector3& value) { }
        private System.Void get_localPosition_Injected(UnityEngine.Vector3& ret) { }
        private System.Void set_localPosition_Injected(UnityEngine.Vector3& value) { }
        private System.Void GetLocalEulerAngles_Injected(UnityEngine.RotationOrder order, UnityEngine.Vector3& ret) { }
        private System.Void SetLocalEulerAngles_Injected(UnityEngine.Vector3& euler, UnityEngine.RotationOrder order) { }
        private System.Void SetLocalEulerHint_Injected(UnityEngine.Vector3& euler) { }
        private System.Void get_rotation_Injected(UnityEngine.Quaternion& ret) { }
        private System.Void set_rotation_Injected(UnityEngine.Quaternion& value) { }
        private System.Void get_localRotation_Injected(UnityEngine.Quaternion& ret) { }
        private System.Void set_localRotation_Injected(UnityEngine.Quaternion& value) { }
        private System.Void get_localScale_Injected(UnityEngine.Vector3& ret) { }
        private System.Void set_localScale_Injected(UnityEngine.Vector3& value) { }
        private System.Void get_worldToLocalMatrix_Injected(UnityEngine.Matrix4x4& ret) { }
        private System.Void get_localToWorldMatrix_Injected(UnityEngine.Matrix4x4& ret) { }
        private System.Void GetLocalToRelativeMatrix_Injected(UnityEngine.Transform relativeT, UnityEngine.Matrix4x4& ret) { }
        private System.Void SetPositionAndRotation_Injected(UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation) { }
        private System.Void SetLocalPositionAndRotation_Injected(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation) { }
        private System.Void SetRelativePosition_Injected(UnityEngine.Transform relativeT, UnityEngine.Vector3& position) { }
        private System.Void GetRelativePosition_Injected(UnityEngine.Transform relativeT, UnityEngine.Vector3& ret) { }
        private System.Void RotateAroundInternal_Injected(UnityEngine.Vector3& axis, System.Single angle) { }
        private System.Void Internal_LookAt_Injected(UnityEngine.Vector3& worldPosition, UnityEngine.Vector3& worldUp) { }
        private System.Void TransformDirection_Injected(UnityEngine.Vector3& direction, UnityEngine.Vector3& ret) { }
        private System.Void InverseTransformDirection_Injected(UnityEngine.Vector3& direction, UnityEngine.Vector3& ret) { }
        private System.Void TransformVector_Injected(UnityEngine.Vector3& vector, UnityEngine.Vector3& ret) { }
        private System.Void InverseTransformVector_Injected(UnityEngine.Vector3& vector, UnityEngine.Vector3& ret) { }
        private System.Void TransformPoint_Injected(UnityEngine.Vector3& position, UnityEngine.Vector3& ret) { }
        private System.Void InverseTransformPoint_Injected(UnityEngine.Vector3& position, UnityEngine.Vector3& ret) { }
        private System.Void get_lossyScale_Injected(UnityEngine.Vector3& ret) { }
        private System.Void RotateAround_Injected(UnityEngine.Vector3& axis, System.Single angle) { }
        private System.Void RotateAroundLocal_Injected(UnityEngine.Vector3& axis, System.Single angle) { }

    }

    // TypeToken: 0x20001C9
    public struct SpriteMaskInteraction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.SpriteMaskInteraction None;        // 0x0
        public static UnityEngine.SpriteMaskInteraction VisibleInsideMask;        // 0x0
        public static UnityEngine.SpriteMaskInteraction VisibleOutsideMask;        // 0x0

    }

    // TypeToken: 0x20001CA
    public class SpriteRenderer : Renderer
    {
        // Fields
        private UnityEngine.Events.UnityEvent<UnityEngine.SpriteRenderer> m_SpriteChangeEvent;        // 0x18

        // Methods
        private System.Void InvokeSpriteChanged() { }
        private UnityEngine.Sprite get_sprite() { }
        private System.Void set_sprite(UnityEngine.Sprite value) { }
        private UnityEngine.Color get_color() { }
        private System.Void set_color(UnityEngine.Color value) { }
        private System.Boolean get_flipX() { }
        private System.Void set_flipX(System.Boolean value) { }
        private System.Boolean get_flipY() { }
        private System.Void set_flipY(System.Boolean value) { }
        private System.Void get_color_Injected(UnityEngine.Color& ret) { }
        private System.Void set_color_Injected(UnityEngine.Color& value) { }

    }

    // TypeToken: 0x20001CB
    public struct SpriteMeshType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.SpriteMeshType FullRect;        // 0x0
        public static UnityEngine.SpriteMeshType Tight;        // 0x0

    }

    // TypeToken: 0x20001CC
    public struct SpritePackingMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.SpritePackingMode Tight;        // 0x0
        public static UnityEngine.SpritePackingMode Rectangle;        // 0x0

    }

    // TypeToken: 0x20001CD
    public struct SpritePackingRotation
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.SpritePackingRotation None;        // 0x0
        public static UnityEngine.SpritePackingRotation FlipHorizontal;        // 0x0
        public static UnityEngine.SpritePackingRotation FlipVertical;        // 0x0
        public static UnityEngine.SpritePackingRotation Rotate180;        // 0x0
        public static UnityEngine.SpritePackingRotation Any;        // 0x0

    }

    // TypeToken: 0x20001CE
    public class Sprite
    {
        // Fields
        private static System.Action<System.Collections.Generic.List<UnityEngine.Sprite>> dynamicAtlasFinishCallback;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Int32 GetPackingMode() { }
        private System.Int32 GetPackingRotation() { }
        private System.Int32 GetPacked() { }
        private UnityEngine.Rect GetTextureRect() { }
        private UnityEngine.Vector2 GetTextureRectOffset() { }
        private UnityEngine.Vector4 GetInnerUVs() { }
        private UnityEngine.Vector4 GetOuterUVs() { }
        private UnityEngine.Vector4 GetPadding() { }
        private UnityEngine.Sprite CreateSpriteWithoutTextureScripting(UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsToUnits, UnityEngine.Texture2D texture) { }
        private UnityEngine.Sprite CreateSprite(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsPerUnit, System.UInt32 extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border, System.Boolean generateFallbackPhysicsShape) { }
        private UnityEngine.Bounds get_bounds() { }
        private UnityEngine.Rect get_rect() { }
        private UnityEngine.Vector4 get_border() { }
        private UnityEngine.Texture2D get_texture() { }
        private UnityEngine.Texture2D GetSecondaryTexture(System.Int32 index) { }
        private System.Single get_pixelsPerUnit() { }
        private System.Single get_spriteAtlasTextureScale() { }
        private UnityEngine.Texture2D get_associatedAlphaSplitTexture() { }
        private UnityEngine.Vector2 get_pivot() { }
        private System.Boolean get_packed() { }
        private System.Boolean get_dynamicPacked() { }
        private UnityEngine.SpritePackingMode get_packingMode() { }
        private UnityEngine.SpritePackingRotation get_packingRotation() { }
        private UnityEngine.Rect get_textureRect() { }
        private UnityEngine.Vector2 get_textureRectOffset() { }
        private UnityEngine.Vector2[] get_vertices() { }
        private System.UInt16[] get_triangles() { }
        private UnityEngine.Vector2[] get_uv() { }
        private System.Int32 GetPhysicsShapeCount() { }
        private System.Int32 GetPhysicsShapePointCount(System.Int32 shapeIdx) { }
        private System.Int32 Internal_GetPhysicsShapePointCount(System.Int32 shapeIdx) { }
        private System.Void RegisterDynamicAtlas(System.Int32 panelLevel) { }
        private System.Void UnRegisterDynamicAtlas() { }
        private System.Void InternalRegisterDynamicAtlas(System.Int32 panelLevel) { }
        private System.Void Internal_UnRegisterDynamicAtlas() { }
        private System.Void add_dynamicAtlasFinishCallback(System.Action<System.Collections.Generic.List<UnityEngine.Sprite>> value) { }
        private System.Void remove_dynamicAtlasFinishCallback(System.Action<System.Collections.Generic.List<UnityEngine.Sprite>> value) { }
        private System.Boolean PostRegisteredAtlasFinish(System.Collections.Generic.List<UnityEngine.Sprite> sprites) { }
        private System.Void RegisterSpriteAtlasList(System.Collections.Generic.List<UnityEngine.Sprite> cacheCallBack) { }
        private System.Void Internal_RegisterSpriteCacheCallBack(System.Collections.Generic.List<UnityEngine.Sprite> cacheCallBac) { }
        private System.Int32 GetPhysicsShape(System.Int32 shapeIdx, System.Collections.Generic.List<UnityEngine.Vector2> physicsShape) { }
        private System.Void GetPhysicsShapeImpl(UnityEngine.Sprite sprite, System.Int32 shapeIdx, System.Collections.Generic.List<UnityEngine.Vector2> physicsShape) { }
        private System.Void OverridePhysicsShape(System.Collections.Generic.IList<UnityEngine.Vector2[]> physicsShapes) { }
        private System.Void OverridePhysicsShapeCount(UnityEngine.Sprite sprite, System.Int32 physicsShapeCount) { }
        private System.Void OverridePhysicsShape(UnityEngine.Sprite sprite, UnityEngine.Vector2[] physicsShape, System.Int32 idx) { }
        private System.Void OverrideGeometry(UnityEngine.Vector2[] vertices, System.UInt16[] triangles) { }
        private UnityEngine.Sprite Create(UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsToUnits, UnityEngine.Texture2D texture) { }
        private UnityEngine.Sprite Create(UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsToUnits) { }
        private UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsPerUnit, System.UInt32 extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border, System.Boolean generateFallbackPhysicsShape) { }
        private UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsPerUnit, System.UInt32 extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border) { }
        private UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsPerUnit, System.UInt32 extrude, UnityEngine.SpriteMeshType meshType) { }
        private UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsPerUnit, System.UInt32 extrude) { }
        private UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsPerUnit) { }
        private UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot) { }
        private System.Void GetTextureRect_Injected(UnityEngine.Rect& ret) { }
        private System.Void GetTextureRectOffset_Injected(UnityEngine.Vector2& ret) { }
        private System.Void GetInnerUVs_Injected(UnityEngine.Vector4& ret) { }
        private System.Void GetOuterUVs_Injected(UnityEngine.Vector4& ret) { }
        private System.Void GetPadding_Injected(UnityEngine.Vector4& ret) { }
        private UnityEngine.Sprite CreateSpriteWithoutTextureScripting_Injected(UnityEngine.Rect& rect, UnityEngine.Vector2& pivot, System.Single pixelsToUnits, UnityEngine.Texture2D texture) { }
        private UnityEngine.Sprite CreateSprite_Injected(UnityEngine.Texture2D texture, UnityEngine.Rect& rect, UnityEngine.Vector2& pivot, System.Single pixelsPerUnit, System.UInt32 extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4& border, System.Boolean generateFallbackPhysicsShape) { }
        private System.Void get_bounds_Injected(UnityEngine.Bounds& ret) { }
        private System.Void get_rect_Injected(UnityEngine.Rect& ret) { }
        private System.Void get_border_Injected(UnityEngine.Vector4& ret) { }
        private System.Void get_pivot_Injected(UnityEngine.Vector2& ret) { }

    }

}

namespace UnityEngine.Assertions
{

    // TypeToken: 0x20003A7
    public class Assert
    {
        // Fields
        public static System.Boolean raiseExceptions;        // 0x0

        // Methods
        private System.Void Fail(System.String message, System.String userMessage) { }
        private System.Void IsTrue(System.Boolean condition) { }
        private System.Void IsTrue(System.Boolean condition, System.String message) { }
        private System.Void IsFalse(System.Boolean condition, System.String message) { }
        private System.Void AreEqual(T expected, T actual) { }
        private System.Void AreEqual(T expected, T actual, System.String message) { }
        private System.Void AreEqual(T expected, T actual, System.String message, System.Collections.Generic.IEqualityComparer<T> comparer) { }
        private System.Void AreEqual(UnityEngine.Object expected, UnityEngine.Object actual, System.String message) { }
        private System.Void IsNull(T value) { }
        private System.Void IsNull(T value, System.String message) { }
        private System.Void IsNull(UnityEngine.Object value, System.String message) { }
        private System.Void IsNotNull(T value) { }
        private System.Void IsNotNull(T value, System.String message) { }
        private System.Void IsNotNull(UnityEngine.Object value, System.String message) { }
        private System.Void AreEqual(System.Int32 expected, System.Int32 actual) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20003A8
    public class AssertionException : Exception
    {
        // Fields
        private System.String m_UserMessage;        // 0x90

        // Methods
        private System.Void .ctor(System.String message, System.String userMessage) { }
        private System.String get_Message() { }

    }

    // TypeToken: 0x20003A9
    public class AssertionMessageUtil
    {
        // Methods
        private System.String GetMessage(System.String failureMessage) { }
        private System.String GetMessage(System.String failureMessage, System.String expected) { }
        private System.String GetEqualityMessage(System.Object actual, System.Object expected, System.Boolean expectEqual) { }
        private System.String NullFailureMessage(System.Object value, System.Boolean expectNull) { }
        private System.String BooleanFailureMessage(System.Boolean expected) { }

    }

}

namespace UnityEngine.Device
{

    // TypeToken: 0x2000386
    public class SystemInfo
    {
        // Methods
        private System.Int32 get_systemMemorySize() { }

    }

}

namespace UnityEngine.Diagnostics
{

    // TypeToken: 0x2000383
    public struct ForcedCrashCategory
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Diagnostics.ForcedCrashCategory AccessViolation;        // 0x0
        public static UnityEngine.Diagnostics.ForcedCrashCategory FatalError;        // 0x0
        public static UnityEngine.Diagnostics.ForcedCrashCategory Abort;        // 0x0
        public static UnityEngine.Diagnostics.ForcedCrashCategory PureVirtualFunction;        // 0x0
        public static UnityEngine.Diagnostics.ForcedCrashCategory MonoAbort;        // 0x0

    }

    // TypeToken: 0x2000384
    public struct AddressSanitizerCategory
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Diagnostics.AddressSanitizerCategory HeapBufferOverFlow;        // 0x0
        public static UnityEngine.Diagnostics.AddressSanitizerCategory HeapUseAfterFree;        // 0x0
        public static UnityEngine.Diagnostics.AddressSanitizerCategory MemcpyParamOverlap;        // 0x0
        public static UnityEngine.Diagnostics.AddressSanitizerCategory DoubleFree;        // 0x0

    }

    // TypeToken: 0x2000385
    public class Utils
    {
        // Methods
        private System.Void ForceCrash(UnityEngine.Diagnostics.ForcedCrashCategory crashCategory) { }
        private System.Void NativeAssert(System.String message) { }
        private System.Void NativeError(System.String message) { }
        private System.Void NativeWarning(System.String message) { }
        private System.Void AddressSanitizer(UnityEngine.Diagnostics.AddressSanitizerCategory crashCategory) { }

    }

}

namespace UnityEngine.Events
{

    // TypeToken: 0x200020C
    public struct PersistentListenerMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Events.PersistentListenerMode EventDefined;        // 0x0
        public static UnityEngine.Events.PersistentListenerMode Void;        // 0x0
        public static UnityEngine.Events.PersistentListenerMode Object;        // 0x0
        public static UnityEngine.Events.PersistentListenerMode Int;        // 0x0
        public static UnityEngine.Events.PersistentListenerMode Float;        // 0x0
        public static UnityEngine.Events.PersistentListenerMode String;        // 0x0
        public static UnityEngine.Events.PersistentListenerMode Bool;        // 0x0

    }

    // TypeToken: 0x200020D
    public class UnityEventTools
    {
        // Methods
        private System.String TidyAssemblyTypeName(System.String assemblyTypeName) { }

    }

    // TypeToken: 0x200020E
    public class ArgumentCache, ISerializationCallbackReceiver
    {
        // Fields
        private UnityEngine.Object m_ObjectArgument;        // 0x10
        private System.String m_ObjectArgumentAssemblyTypeName;        // 0x18
        private System.Int32 m_IntArgument;        // 0x20
        private System.Single m_FloatArgument;        // 0x24
        private System.String m_StringArgument;        // 0x28
        private System.Boolean m_BoolArgument;        // 0x30

        // Methods
        private UnityEngine.Object get_unityObjectArgument() { }
        private System.String get_unityObjectArgumentAssemblyTypeName() { }
        private System.Int32 get_intArgument() { }
        private System.Single get_floatArgument() { }
        private System.String get_stringArgument() { }
        private System.Boolean get_boolArgument() { }
        private System.Void OnBeforeSerialize() { }
        private System.Void OnAfterDeserialize() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200020F
    public class BaseInvokableCall
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Object target, System.Reflection.MethodInfo function) { }
        private System.Void Invoke(System.Object[] args) { }
        private System.Void ThrowOnInvalidArg(System.Object arg) { }
        private System.Boolean AllowInvoke(System.Delegate delegate) { }
        private System.Boolean Find(System.Object targetObj, System.Reflection.MethodInfo method) { }

    }

    // TypeToken: 0x2000210
    public class InvokableCall : BaseInvokableCall
    {
        // Fields
        private UnityEngine.Events.UnityAction Delegate;        // 0x10

        // Methods
        private System.Void add_Delegate(UnityEngine.Events.UnityAction value) { }
        private System.Void remove_Delegate(UnityEngine.Events.UnityAction value) { }
        private System.Void .ctor(System.Object target, System.Reflection.MethodInfo theFunction) { }
        private System.Void .ctor(UnityEngine.Events.UnityAction action) { }
        private System.Void Invoke(System.Object[] args) { }
        private System.Void Invoke() { }
        private System.Boolean Find(System.Object targetObj, System.Reflection.MethodInfo method) { }

    }

    // TypeToken: 0x2000211
    public class InvokableCall`1 : BaseInvokableCall
    {
        // Fields
        private UnityEngine.Events.UnityAction<T1> Delegate;        // 0x0

        // Methods
        private System.Void add_Delegate(UnityEngine.Events.UnityAction<T1> value) { }
        private System.Void remove_Delegate(UnityEngine.Events.UnityAction<T1> value) { }
        private System.Void .ctor(System.Object target, System.Reflection.MethodInfo theFunction) { }
        private System.Void .ctor(UnityEngine.Events.UnityAction<T1> action) { }
        private System.Void Invoke(System.Object[] args) { }
        private System.Void Invoke(T1 args0) { }
        private System.Boolean Find(System.Object targetObj, System.Reflection.MethodInfo method) { }

    }

    // TypeToken: 0x2000212
    public class InvokableCall`2 : BaseInvokableCall
    {
        // Fields
        private UnityEngine.Events.UnityAction<T1,T2> Delegate;        // 0x0

        // Methods
        private System.Void add_Delegate(UnityEngine.Events.UnityAction<T1,T2> value) { }
        private System.Void remove_Delegate(UnityEngine.Events.UnityAction<T1,T2> value) { }
        private System.Void .ctor(System.Object target, System.Reflection.MethodInfo theFunction) { }
        private System.Void .ctor(UnityEngine.Events.UnityAction<T1,T2> action) { }
        private System.Void Invoke(System.Object[] args) { }
        private System.Void Invoke(T1 args0, T2 args1) { }
        private System.Boolean Find(System.Object targetObj, System.Reflection.MethodInfo method) { }

    }

    // TypeToken: 0x2000213
    public class InvokableCall`3 : BaseInvokableCall
    {
        // Fields
        private UnityEngine.Events.UnityAction<T1,T2,T3> Delegate;        // 0x0

        // Methods
        private System.Void add_Delegate(UnityEngine.Events.UnityAction<T1,T2,T3> value) { }
        private System.Void remove_Delegate(UnityEngine.Events.UnityAction<T1,T2,T3> value) { }
        private System.Void .ctor(System.Object target, System.Reflection.MethodInfo theFunction) { }
        private System.Void .ctor(UnityEngine.Events.UnityAction<T1,T2,T3> action) { }
        private System.Void Invoke(System.Object[] args) { }
        private System.Void Invoke(T1 args0, T2 args1, T3 args2) { }
        private System.Boolean Find(System.Object targetObj, System.Reflection.MethodInfo method) { }

    }

    // TypeToken: 0x2000214
    public class InvokableCall`4 : BaseInvokableCall
    {
        // Fields
        private UnityEngine.Events.UnityAction<T1,T2,T3,T4> Delegate;        // 0x0

        // Methods
        private System.Void .ctor(System.Object target, System.Reflection.MethodInfo theFunction) { }
        private System.Void Invoke(System.Object[] args) { }
        private System.Boolean Find(System.Object targetObj, System.Reflection.MethodInfo method) { }

    }

    // TypeToken: 0x2000215
    public class CachedInvokableCall`1 : InvokableCall`1
    {
        // Fields
        private readonly T m_Arg1;        // 0x0

        // Methods
        private System.Void .ctor(UnityEngine.Object target, System.Reflection.MethodInfo theFunction, T argument) { }
        private System.Void Invoke(System.Object[] args) { }
        private System.Void Invoke(T arg0) { }

    }

    // TypeToken: 0x2000216
    public struct UnityEventCallState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Events.UnityEventCallState Off;        // 0x0
        public static UnityEngine.Events.UnityEventCallState EditorAndRuntime;        // 0x0
        public static UnityEngine.Events.UnityEventCallState RuntimeOnly;        // 0x0

    }

    // TypeToken: 0x2000217
    public class PersistentCall, ISerializationCallbackReceiver
    {
        // Fields
        private UnityEngine.Object m_Target;        // 0x10
        private System.String m_TargetAssemblyTypeName;        // 0x18
        private System.String m_MethodName;        // 0x20
        private UnityEngine.Events.PersistentListenerMode m_Mode;        // 0x28
        private UnityEngine.Events.ArgumentCache m_Arguments;        // 0x30
        private UnityEngine.Events.UnityEventCallState m_CallState;        // 0x38

        // Methods
        private UnityEngine.Object get_target() { }
        private System.String get_targetAssemblyTypeName() { }
        private System.String get_methodName() { }
        private UnityEngine.Events.PersistentListenerMode get_mode() { }
        private UnityEngine.Events.ArgumentCache get_arguments() { }
        private UnityEngine.Events.UnityEventCallState get_callState() { }
        private System.Void set_callState(UnityEngine.Events.UnityEventCallState value) { }
        private System.Boolean IsValid() { }
        private UnityEngine.Events.BaseInvokableCall GetRuntimeCall(UnityEngine.Events.UnityEventBase theEvent) { }
        private UnityEngine.Events.BaseInvokableCall GetObjectCall(UnityEngine.Object target, System.Reflection.MethodInfo method, UnityEngine.Events.ArgumentCache arguments) { }
        private System.Void OnBeforeSerialize() { }
        private System.Void OnAfterDeserialize() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000218
    public class PersistentCallGroup
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.Events.PersistentCall> m_Calls;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Int32 get_Count() { }
        private UnityEngine.Events.PersistentCall GetListener(System.Int32 index) { }
        private System.Void Initialize(UnityEngine.Events.InvokableCallList invokableList, UnityEngine.Events.UnityEventBase unityEventBase) { }

    }

    // TypeToken: 0x2000219
    public class InvokableCallList
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> m_PersistentCalls;        // 0x10
        private System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> m_RuntimeCalls;        // 0x18
        private System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> m_ExecutingCalls;        // 0x20
        private System.Boolean m_NeedsUpdate;        // 0x28
        private static System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> s_Empty;        // 0x0

        // Methods
        private System.Void AddPersistentInvokableCall(UnityEngine.Events.BaseInvokableCall call) { }
        private System.Void AddListener(UnityEngine.Events.BaseInvokableCall call) { }
        private System.Void RemoveListener(System.Object targetObj, System.Reflection.MethodInfo method) { }
        private System.Void Clear() { }
        private System.Void ClearPersistent() { }
        private System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> PrepareInvoke() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200021A
    public class UnityEventBase, ISerializationCallbackReceiver
    {
        // Fields
        private UnityEngine.Events.InvokableCallList m_Calls;        // 0x10
        private UnityEngine.Events.PersistentCallGroup m_PersistentCalls;        // 0x18
        private System.Boolean m_CallsDirty;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        private System.Reflection.MethodInfo FindMethod_Impl(System.String name, System.Object targetObj) { }
        private System.Reflection.MethodInfo FindMethod_Impl(System.String name, System.Type targetObjType) { }
        private UnityEngine.Events.BaseInvokableCall GetDelegate(System.Object target, System.Reflection.MethodInfo theFunction) { }
        private System.Reflection.MethodInfo FindMethod(UnityEngine.Events.PersistentCall call) { }
        private System.Reflection.MethodInfo FindMethod(System.String name, System.Type listenerType, UnityEngine.Events.PersistentListenerMode mode, System.Type argumentType) { }
        private System.Int32 GetPersistentEventCount() { }
        private UnityEngine.Object GetPersistentTarget(System.Int32 index) { }
        private System.String GetPersistentMethodName(System.Int32 index) { }
        private System.Void DirtyPersistentCalls() { }
        private System.Void RebuildPersistentCallsIfNeeded() { }
        private System.Void SetPersistentListenerState(System.Int32 index, UnityEngine.Events.UnityEventCallState state) { }
        private UnityEngine.Events.UnityEventCallState GetPersistentListenerState(System.Int32 index) { }
        private System.Void AddListener(System.Object targetObj, System.Reflection.MethodInfo method) { }
        private System.Void AddCall(UnityEngine.Events.BaseInvokableCall call) { }
        private System.Void RemoveListener(System.Object targetObj, System.Reflection.MethodInfo method) { }
        private System.Void RemoveAllListeners() { }
        private System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> PrepareInvoke() { }
        private System.Void Invoke(System.Object[] parameters) { }
        private System.String ToString() { }
        private System.Reflection.MethodInfo GetValidMethodInfo(System.Object obj, System.String functionName, System.Type[] argumentTypes) { }
        private System.Reflection.MethodInfo GetValidMethodInfo(System.Type objectType, System.String functionName, System.Type[] argumentTypes) { }

    }

    // TypeToken: 0x200021B
    public class UnityAction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }

    }

    // TypeToken: 0x200021C
    public class UnityEvent : UnityEventBase
    {
        // Fields
        private System.Object[] m_InvokeArray;        // 0x28

        // Methods
        private System.Void .ctor() { }
        private System.Void AddListener(UnityEngine.Events.UnityAction call) { }
        private System.Void RemoveListener(UnityEngine.Events.UnityAction call) { }
        private System.Reflection.MethodInfo FindMethod_Impl(System.String name, System.Type targetObjType) { }
        private UnityEngine.Events.BaseInvokableCall GetDelegate(System.Object target, System.Reflection.MethodInfo theFunction) { }
        private UnityEngine.Events.BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction action) { }
        private System.Void Invoke() { }

    }

    // TypeToken: 0x200021D
    public class UnityAction`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T0 arg0) { }

    }

    // TypeToken: 0x200021E
    public class UnityEvent`1 : UnityEventBase
    {
        // Fields
        private System.Object[] m_InvokeArray;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void AddListener(UnityEngine.Events.UnityAction<T0> call) { }
        private System.Void RemoveListener(UnityEngine.Events.UnityAction<T0> call) { }
        private System.Reflection.MethodInfo FindMethod_Impl(System.String name, System.Type targetObjType) { }
        private UnityEngine.Events.BaseInvokableCall GetDelegate(System.Object target, System.Reflection.MethodInfo theFunction) { }
        private UnityEngine.Events.BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction<T0> action) { }
        private System.Void Invoke(T0 arg0) { }

    }

    // TypeToken: 0x200021F
    public class UnityAction`2 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T0 arg0, T1 arg1) { }

    }

    // TypeToken: 0x2000220
    public class UnityEvent`2 : UnityEventBase
    {
        // Fields
        private System.Object[] m_InvokeArray;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void AddListener(UnityEngine.Events.UnityAction<T0,T1> call) { }
        private System.Void RemoveListener(UnityEngine.Events.UnityAction<T0,T1> call) { }
        private System.Reflection.MethodInfo FindMethod_Impl(System.String name, System.Type targetObjType) { }
        private UnityEngine.Events.BaseInvokableCall GetDelegate(System.Object target, System.Reflection.MethodInfo theFunction) { }
        private UnityEngine.Events.BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction<T0,T1> action) { }
        private System.Void Invoke(T0 arg0, T1 arg1) { }

    }

    // TypeToken: 0x2000221
    public class UnityAction`3 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T0 arg0, T1 arg1, T2 arg2) { }

    }

    // TypeToken: 0x2000222
    public class UnityEvent`3 : UnityEventBase
    {
        // Fields
        private System.Object[] m_InvokeArray;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void AddListener(UnityEngine.Events.UnityAction<T0,T1,T2> call) { }
        private System.Void RemoveListener(UnityEngine.Events.UnityAction<T0,T1,T2> call) { }
        private System.Reflection.MethodInfo FindMethod_Impl(System.String name, System.Type targetObjType) { }
        private UnityEngine.Events.BaseInvokableCall GetDelegate(System.Object target, System.Reflection.MethodInfo theFunction) { }
        private UnityEngine.Events.BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction<T0,T1,T2> action) { }
        private System.Void Invoke(T0 arg0, T1 arg1, T2 arg2) { }

    }

    // TypeToken: 0x2000223
    public class UnityAction`4 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }

    }

    // TypeToken: 0x2000224
    public class UnityEvent`4 : UnityEventBase
    {
        // Fields
        private System.Object[] m_InvokeArray;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Reflection.MethodInfo FindMethod_Impl(System.String name, System.Type targetObjType) { }
        private UnityEngine.Events.BaseInvokableCall GetDelegate(System.Object target, System.Reflection.MethodInfo theFunction) { }

    }

}

namespace UnityEngine.Experimental.GlobalIllumination
{

    // TypeToken: 0x2000389
    public struct LightType
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static UnityEngine.Experimental.GlobalIllumination.LightType Directional;        // 0x0
        public static UnityEngine.Experimental.GlobalIllumination.LightType Point;        // 0x0
        public static UnityEngine.Experimental.GlobalIllumination.LightType Spot;        // 0x0
        public static UnityEngine.Experimental.GlobalIllumination.LightType Rectangle;        // 0x0
        public static UnityEngine.Experimental.GlobalIllumination.LightType Disc;        // 0x0
        public static UnityEngine.Experimental.GlobalIllumination.LightType SpotPyramidShape;        // 0x0
        public static UnityEngine.Experimental.GlobalIllumination.LightType SpotBoxShape;        // 0x0

    }

    // TypeToken: 0x200038A
    public struct LightMode
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static UnityEngine.Experimental.GlobalIllumination.LightMode Realtime;        // 0x0
        public static UnityEngine.Experimental.GlobalIllumination.LightMode Mixed;        // 0x0
        public static UnityEngine.Experimental.GlobalIllumination.LightMode Baked;        // 0x0
        public static UnityEngine.Experimental.GlobalIllumination.LightMode Unknown;        // 0x0

    }

    // TypeToken: 0x200038B
    public struct FalloffType
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static UnityEngine.Experimental.GlobalIllumination.FalloffType InverseSquared;        // 0x0
        public static UnityEngine.Experimental.GlobalIllumination.FalloffType InverseSquaredNoRangeAttenuation;        // 0x0
        public static UnityEngine.Experimental.GlobalIllumination.FalloffType Linear;        // 0x0
        public static UnityEngine.Experimental.GlobalIllumination.FalloffType Legacy;        // 0x0
        public static UnityEngine.Experimental.GlobalIllumination.FalloffType Undefined;        // 0x0

    }

    // TypeToken: 0x200038C
    public struct AngularFalloffType
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static UnityEngine.Experimental.GlobalIllumination.AngularFalloffType LUT;        // 0x0
        public static UnityEngine.Experimental.GlobalIllumination.AngularFalloffType AnalyticAndInnerAngle;        // 0x0

    }

    // TypeToken: 0x200038D
    public struct LinearColor
    {
        // Fields
        private System.Single m_red;        // 0x10
        private System.Single m_green;        // 0x14
        private System.Single m_blue;        // 0x18
        private System.Single m_intensity;        // 0x1C

        // Methods
        private System.Single get_red() { }
        private System.Void set_red(System.Single value) { }
        private System.Single get_green() { }
        private System.Void set_green(System.Single value) { }
        private System.Single get_blue() { }
        private System.Void set_blue(System.Single value) { }
        private UnityEngine.Experimental.GlobalIllumination.LinearColor Convert(UnityEngine.Color color, System.Single intensity) { }
        private UnityEngine.Experimental.GlobalIllumination.LinearColor Black() { }

    }

    // TypeToken: 0x200038E
    public struct DirectionalLight
    {
        // Fields
        public System.Int32 instanceID;        // 0x10
        public System.Boolean shadow;        // 0x14
        public UnityEngine.Experimental.GlobalIllumination.LightMode mode;        // 0x15
        public UnityEngine.Vector3 position;        // 0x18
        public UnityEngine.Quaternion orientation;        // 0x24
        public UnityEngine.Experimental.GlobalIllumination.LinearColor color;        // 0x34
        public UnityEngine.Experimental.GlobalIllumination.LinearColor indirectColor;        // 0x44
        public System.Single penumbraWidthRadian;        // 0x54
        public UnityEngine.Vector3 direction;        // 0x58

    }

    // TypeToken: 0x200038F
    public struct PointLight
    {
        // Fields
        public System.Int32 instanceID;        // 0x10
        public System.Boolean shadow;        // 0x14
        public UnityEngine.Experimental.GlobalIllumination.LightMode mode;        // 0x15
        public UnityEngine.Vector3 position;        // 0x18
        public UnityEngine.Quaternion orientation;        // 0x24
        public UnityEngine.Experimental.GlobalIllumination.LinearColor color;        // 0x34
        public UnityEngine.Experimental.GlobalIllumination.LinearColor indirectColor;        // 0x44
        public System.Single range;        // 0x54
        public System.Single sphereRadius;        // 0x58
        public UnityEngine.Experimental.GlobalIllumination.FalloffType falloff;        // 0x5C

    }

    // TypeToken: 0x2000390
    public struct SpotLight
    {
        // Fields
        public System.Int32 instanceID;        // 0x10
        public System.Boolean shadow;        // 0x14
        public UnityEngine.Experimental.GlobalIllumination.LightMode mode;        // 0x15
        public UnityEngine.Vector3 position;        // 0x18
        public UnityEngine.Quaternion orientation;        // 0x24
        public UnityEngine.Experimental.GlobalIllumination.LinearColor color;        // 0x34
        public UnityEngine.Experimental.GlobalIllumination.LinearColor indirectColor;        // 0x44
        public System.Single range;        // 0x54
        public System.Single sphereRadius;        // 0x58
        public System.Single coneAngle;        // 0x5C
        public System.Single innerConeAngle;        // 0x60
        public UnityEngine.Experimental.GlobalIllumination.FalloffType falloff;        // 0x64
        public UnityEngine.Experimental.GlobalIllumination.AngularFalloffType angularFalloff;        // 0x65

    }

    // TypeToken: 0x2000391
    public struct RectangleLight
    {
        // Fields
        public System.Int32 instanceID;        // 0x10
        public System.Boolean shadow;        // 0x14
        public UnityEngine.Experimental.GlobalIllumination.LightMode mode;        // 0x15
        public UnityEngine.Vector3 position;        // 0x18
        public UnityEngine.Quaternion orientation;        // 0x24
        public UnityEngine.Experimental.GlobalIllumination.LinearColor color;        // 0x34
        public UnityEngine.Experimental.GlobalIllumination.LinearColor indirectColor;        // 0x44
        public System.Single range;        // 0x54
        public System.Single width;        // 0x58
        public System.Single height;        // 0x5C
        public UnityEngine.Experimental.GlobalIllumination.FalloffType falloff;        // 0x60

    }

    // TypeToken: 0x2000392
    public struct DiscLight
    {
        // Fields
        public System.Int32 instanceID;        // 0x10
        public System.Boolean shadow;        // 0x14
        public UnityEngine.Experimental.GlobalIllumination.LightMode mode;        // 0x15
        public UnityEngine.Vector3 position;        // 0x18
        public UnityEngine.Quaternion orientation;        // 0x24
        public UnityEngine.Experimental.GlobalIllumination.LinearColor color;        // 0x34
        public UnityEngine.Experimental.GlobalIllumination.LinearColor indirectColor;        // 0x44
        public System.Single range;        // 0x54
        public System.Single radius;        // 0x58
        public UnityEngine.Experimental.GlobalIllumination.FalloffType falloff;        // 0x5C

    }

    // TypeToken: 0x2000393
    public struct Cookie
    {
        // Fields
        public System.Int32 instanceID;        // 0x10
        public System.Single scale;        // 0x14
        public UnityEngine.Vector2 sizes;        // 0x18

    }

    // TypeToken: 0x2000394
    public struct LightDataGI
    {
        // Fields
        public System.Int32 instanceID;        // 0x10
        public System.Int32 cookieID;        // 0x14
        public System.Single cookieScale;        // 0x18
        public UnityEngine.Experimental.GlobalIllumination.LinearColor color;        // 0x1C
        public UnityEngine.Experimental.GlobalIllumination.LinearColor indirectColor;        // 0x2C
        public UnityEngine.Quaternion orientation;        // 0x3C
        public UnityEngine.Vector3 position;        // 0x4C
        public System.Single range;        // 0x58
        public System.Single coneAngle;        // 0x5C
        public System.Single innerConeAngle;        // 0x60
        public System.Single shape0;        // 0x64
        public System.Single shape1;        // 0x68
        public UnityEngine.Experimental.GlobalIllumination.LightType type;        // 0x6C
        public UnityEngine.Experimental.GlobalIllumination.LightMode mode;        // 0x6D
        public System.Byte shadow;        // 0x6E
        public UnityEngine.Experimental.GlobalIllumination.FalloffType falloff;        // 0x6F

        // Methods
        private System.Void Init(UnityEngine.Experimental.GlobalIllumination.DirectionalLight& light, UnityEngine.Experimental.GlobalIllumination.Cookie& cookie) { }
        private System.Void Init(UnityEngine.Experimental.GlobalIllumination.PointLight& light, UnityEngine.Experimental.GlobalIllumination.Cookie& cookie) { }
        private System.Void Init(UnityEngine.Experimental.GlobalIllumination.SpotLight& light, UnityEngine.Experimental.GlobalIllumination.Cookie& cookie) { }
        private System.Void Init(UnityEngine.Experimental.GlobalIllumination.RectangleLight& light, UnityEngine.Experimental.GlobalIllumination.Cookie& cookie) { }
        private System.Void Init(UnityEngine.Experimental.GlobalIllumination.DiscLight& light, UnityEngine.Experimental.GlobalIllumination.Cookie& cookie) { }
        private System.Void InitNoBake(System.Int32 lightInstanceID) { }

    }

    // TypeToken: 0x2000395
    public class LightmapperUtils
    {
        // Methods
        private UnityEngine.Experimental.GlobalIllumination.LightMode Extract(UnityEngine.LightmapBakeType baketype) { }
        private UnityEngine.Experimental.GlobalIllumination.LinearColor ExtractIndirect(UnityEngine.Light l) { }
        private System.Single ExtractInnerCone(UnityEngine.Light l) { }
        private UnityEngine.Color ExtractColorTemperature(UnityEngine.Light l) { }
        private System.Void ApplyColorTemperature(UnityEngine.Color cct, UnityEngine.Experimental.GlobalIllumination.LinearColor& lightColor) { }
        private System.Void Extract(UnityEngine.Light l, UnityEngine.Experimental.GlobalIllumination.DirectionalLight& dir) { }
        private System.Void Extract(UnityEngine.Light l, UnityEngine.Experimental.GlobalIllumination.PointLight& point) { }
        private System.Void Extract(UnityEngine.Light l, UnityEngine.Experimental.GlobalIllumination.SpotLight& spot) { }
        private System.Void Extract(UnityEngine.Light l, UnityEngine.Experimental.GlobalIllumination.RectangleLight& rect) { }
        private System.Void Extract(UnityEngine.Light l, UnityEngine.Experimental.GlobalIllumination.DiscLight& disc) { }
        private System.Void Extract(UnityEngine.Light l, UnityEngine.Experimental.GlobalIllumination.Cookie& cookie) { }

    }

    // TypeToken: 0x2000396
    public class Lightmapping
    {
        // Fields
        private static readonly UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate s_DefaultDelegate;        // 0x0
        private static UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate s_RequestLightsDelegate;        // 0x8

        // Methods
        private System.Void SetDelegate(UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate del) { }
        private UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate GetDelegate() { }
        private System.Void ResetDelegate() { }
        private System.Void RequestLights(UnityEngine.Light[] lights, System.IntPtr outLightsPtr, System.Int32 outLightsCount) { }
        private System.Void .cctor() { }

    }

}

namespace UnityEngine.Experimental.Playables
{

    // TypeToken: 0x2000399
    public struct CameraPlayable, IPlayable, IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;        // 0x10

        // Methods
        private UnityEngine.Playables.PlayableHandle GetHandle() { }
        private System.Boolean Equals(UnityEngine.Experimental.Playables.CameraPlayable other) { }

    }

    // TypeToken: 0x200039A
    public struct MaterialEffectPlayable, IPlayable, IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;        // 0x10

        // Methods
        private UnityEngine.Playables.PlayableHandle GetHandle() { }
        private System.Boolean Equals(UnityEngine.Experimental.Playables.MaterialEffectPlayable other) { }

    }

    // TypeToken: 0x200039B
    public struct TextureMixerPlayable, IPlayable, IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;        // 0x10

        // Methods
        private UnityEngine.Playables.PlayableHandle GetHandle() { }
        private System.Boolean Equals(UnityEngine.Experimental.Playables.TextureMixerPlayable other) { }

    }

    // TypeToken: 0x200039C
    public struct TexturePlayableOutput, IPlayableOutput
    {
        // Fields
        private UnityEngine.Playables.PlayableOutputHandle m_Handle;        // 0x10

        // Methods
        private UnityEngine.Playables.PlayableOutputHandle GetHandle() { }

    }

}

namespace UnityEngine.Experimental.Rendering
{

    // TypeToken: 0x200039D
    public class BuiltinRuntimeReflectionSystem, IScriptableRuntimeReflectionSystem, IDisposable
    {
        // Methods
        private System.Boolean TickRealtimeProbes() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Boolean BuiltinUpdate() { }
        private UnityEngine.Experimental.Rendering.BuiltinRuntimeReflectionSystem Internal_BuiltinRuntimeReflectionSystem_New() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200039E
    public interface IScriptableRuntimeReflectionSystem : IDisposable
    {
        // Methods
        private System.Boolean TickRealtimeProbes() { }

    }

    // TypeToken: 0x200039F
    public class ScriptableRuntimeReflectionSystemSettings
    {
        // Fields
        private static UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemWrapper s_Instance;        // 0x0

        // Methods
        private System.Void set_Internal_ScriptableRuntimeReflectionSystemSettings_system(UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem value) { }
        private UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemWrapper get_Internal_ScriptableRuntimeReflectionSystemSettings_instance() { }
        private System.Void ScriptingDirtyReflectionSystemInstance() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20003A0
    public class ScriptableRuntimeReflectionSystemWrapper
    {
        // Fields
        private UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem <implementation>k__BackingField;        // 0x10

        // Methods
        private UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem get_implementation() { }
        private System.Void set_implementation(UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem value) { }
        private System.Void Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes(System.Boolean& result) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003A1
    public struct TextureCreationFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Experimental.Rendering.TextureCreationFlags None;        // 0x0
        public static UnityEngine.Experimental.Rendering.TextureCreationFlags MipChain;        // 0x0
        public static UnityEngine.Experimental.Rendering.TextureCreationFlags Crunch;        // 0x0
        public static UnityEngine.Experimental.Rendering.TextureCreationFlags HGDisableDefragmentation;        // 0x0

    }

    // TypeToken: 0x20003A2
    public struct FormatUsage
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Experimental.Rendering.FormatUsage Sample;        // 0x0
        public static UnityEngine.Experimental.Rendering.FormatUsage Linear;        // 0x0
        public static UnityEngine.Experimental.Rendering.FormatUsage Sparse;        // 0x0
        public static UnityEngine.Experimental.Rendering.FormatUsage Render;        // 0x0
        public static UnityEngine.Experimental.Rendering.FormatUsage Blend;        // 0x0
        public static UnityEngine.Experimental.Rendering.FormatUsage GetPixels;        // 0x0
        public static UnityEngine.Experimental.Rendering.FormatUsage SetPixels;        // 0x0
        public static UnityEngine.Experimental.Rendering.FormatUsage SetPixels32;        // 0x0
        public static UnityEngine.Experimental.Rendering.FormatUsage ReadPixels;        // 0x0
        public static UnityEngine.Experimental.Rendering.FormatUsage LoadStore;        // 0x0
        public static UnityEngine.Experimental.Rendering.FormatUsage MSAA2x;        // 0x0
        public static UnityEngine.Experimental.Rendering.FormatUsage MSAA4x;        // 0x0
        public static UnityEngine.Experimental.Rendering.FormatUsage MSAA8x;        // 0x0
        public static UnityEngine.Experimental.Rendering.FormatUsage StencilSampling;        // 0x0

    }

    // TypeToken: 0x20003A3
    public struct DefaultFormat
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Experimental.Rendering.DefaultFormat LDR;        // 0x0
        public static UnityEngine.Experimental.Rendering.DefaultFormat HDR;        // 0x0
        public static UnityEngine.Experimental.Rendering.DefaultFormat DepthStencil;        // 0x0
        public static UnityEngine.Experimental.Rendering.DefaultFormat Shadow;        // 0x0
        public static UnityEngine.Experimental.Rendering.DefaultFormat Video;        // 0x0

    }

    // TypeToken: 0x20003A4
    public struct GraphicsFormat
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Experimental.Rendering.GraphicsFormat None;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R8_SRGB;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R8G8_SRGB;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R8G8B8_SRGB;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R8G8B8A8_SRGB;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R8_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R8G8_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R8G8B8_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R8G8B8A8_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R8_SNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R8G8_SNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R8G8B8_SNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R8G8B8A8_SNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R8_UInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R8G8_UInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R8G8B8_UInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R8G8B8A8_UInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R8_SInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R8G8_SInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R8G8B8_SInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R8G8B8A8_SInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R16_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R16G16_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R16G16B16_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R16G16B16A16_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R16_SNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R16G16_SNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R16G16B16_SNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R16G16B16A16_SNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R16_UInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R16G16_UInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R16G16B16_UInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R16G16B16A16_UInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R16_SInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R16G16_SInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R16G16B16_SInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R16G16B16A16_SInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R32_UInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R32G32_UInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R32G32B32_UInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R32G32B32A32_UInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R32_SInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R32G32_SInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R32G32B32_SInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R32G32B32A32_SInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R16_SFloat;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R16G16_SFloat;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R16G16B16_SFloat;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R16G16B16A16_SFloat;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R32_SFloat;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R32G32_SFloat;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R32G32B32_SFloat;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R32G32B32A32_SFloat;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat B8G8R8_SRGB;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat B8G8R8A8_SRGB;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat B8G8R8_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat B8G8R8A8_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat B8G8R8_SNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat B8G8R8A8_SNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat B8G8R8_UInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat B8G8R8A8_UInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat B8G8R8_SInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat B8G8R8A8_SInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R4G4B4A4_UNormPack16;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat B4G4R4A4_UNormPack16;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R5G6B5_UNormPack16;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat B5G6R5_UNormPack16;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R5G5B5A1_UNormPack16;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat B5G5R5A1_UNormPack16;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat A1R5G5B5_UNormPack16;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat E5B9G9R9_UFloatPack32;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat B10G11R11_UFloatPack32;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat A2B10G10R10_UNormPack32;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat A2B10G10R10_UIntPack32;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat A2B10G10R10_SIntPack32;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat A2R10G10B10_UNormPack32;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat A2R10G10B10_UIntPack32;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat A2R10G10B10_SIntPack32;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat A2R10G10B10_XRSRGBPack32;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat A2R10G10B10_XRUNormPack32;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R10G10B10_XRSRGBPack32;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R10G10B10_XRUNormPack32;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat A10R10G10B10_XRSRGBPack32;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat A10R10G10B10_XRUNormPack32;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat D16_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat D24_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat D24_UNorm_S8_UInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat D32_SFloat;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat D32_SFloat_S8_UInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat S8_UInt;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGB_DXT1_SRGB;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_DXT1_SRGB;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGB_DXT1_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_DXT1_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_DXT3_SRGB;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_DXT3_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_DXT5_SRGB;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_DXT5_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R_BC4_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R_BC4_SNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RG_BC5_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RG_BC5_SNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGB_BC6H_UFloat;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGB_BC6H_SFloat;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_BC7_SRGB;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_BC7_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGB_PVRTC_2Bpp_SRGB;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGB_PVRTC_2Bpp_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGB_PVRTC_4Bpp_SRGB;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGB_PVRTC_4Bpp_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_PVRTC_2Bpp_SRGB;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_PVRTC_2Bpp_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_PVRTC_4Bpp_SRGB;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_PVRTC_4Bpp_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGB_ETC_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGB_ETC2_SRGB;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGB_ETC2_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGB_A1_ETC2_SRGB;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGB_A1_ETC2_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ETC2_SRGB;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ETC2_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R_EAC_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat R_EAC_SNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RG_EAC_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RG_EAC_SNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC4X4_SRGB;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC4X4_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC5X5_SRGB;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC5X5_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC6X6_SRGB;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC6X6_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC8X8_SRGB;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC8X8_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC10X10_SRGB;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC10X10_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC12X12_SRGB;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC12X12_UNorm;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat YUV2;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat DepthAuto;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat ShadowAuto;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat VideoAuto;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC4X4_UFloat;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC5X5_UFloat;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC6X6_UFloat;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC8X8_UFloat;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC10X10_UFloat;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat RGBA_ASTC12X12_UFloat;        // 0x0

    }

    // TypeToken: 0x20003A5
    public struct RayTracingMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Experimental.Rendering.RayTracingMode Off;        // 0x0
        public static UnityEngine.Experimental.Rendering.RayTracingMode Static;        // 0x0
        public static UnityEngine.Experimental.Rendering.RayTracingMode DynamicTransform;        // 0x0
        public static UnityEngine.Experimental.Rendering.RayTracingMode DynamicGeometry;        // 0x0

    }

    // TypeToken: 0x20003A6
    public class GraphicsFormatUtility
    {
        // Fields
        private static readonly UnityEngine.Experimental.Rendering.GraphicsFormat[] tableNoStencil;        // 0x0
        private static readonly UnityEngine.Experimental.Rendering.GraphicsFormat[] tableStencil;        // 0x8

        // Methods
        private UnityEngine.Experimental.Rendering.GraphicsFormat GetFormat(UnityEngine.Texture texture) { }
        private UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.TextureFormat format, System.Boolean isSRGB) { }
        private UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat_Native_TextureFormat(UnityEngine.TextureFormat format, System.Boolean isSRGB) { }
        private UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.RenderTextureFormat format, System.Boolean isSRGB) { }
        private UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(UnityEngine.RenderTextureFormat format, System.Boolean isSRGB) { }
        private UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite) { }
        private UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatFromBitsLegacy_Native(System.Int32 minimumDepthBits) { }
        private UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormat(System.Int32 minimumDepthBits) { }
        private System.Int32 GetDepthBits(UnityEngine.Experimental.Rendering.GraphicsFormat format) { }
        private UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormat(System.Int32 minimumDepthBits, System.Int32 minimumStencilBits) { }
        private System.Boolean IsSRGBFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format) { }
        private UnityEngine.Experimental.Rendering.GraphicsFormat GetSRGBFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format) { }
        private UnityEngine.Experimental.Rendering.GraphicsFormat GetLinearFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format) { }
        private UnityEngine.RenderTextureFormat GetRenderTextureFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format) { }
        private System.UInt32 GetComponentCount(UnityEngine.Experimental.Rendering.GraphicsFormat format) { }
        private System.Boolean IsCompressedTextureFormat(UnityEngine.TextureFormat format) { }
        private System.Boolean CanDecompressFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Boolean wholeImage) { }
        private System.Boolean CanDecompressFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format) { }
        private System.Boolean IsAlphaOnlyFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format) { }
        private System.Boolean IsDepthFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format) { }
        private System.Boolean IsStencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format) { }
        private System.Boolean IsPVRTCFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format) { }
        private System.Boolean IsCrunchFormat(UnityEngine.TextureFormat format) { }
        private UnityEngine.Rendering.FormatSwizzle GetSwizzleR(UnityEngine.Experimental.Rendering.GraphicsFormat format) { }
        private UnityEngine.Rendering.FormatSwizzle GetSwizzleG(UnityEngine.Experimental.Rendering.GraphicsFormat format) { }
        private UnityEngine.Rendering.FormatSwizzle GetSwizzleB(UnityEngine.Experimental.Rendering.GraphicsFormat format) { }
        private UnityEngine.Rendering.FormatSwizzle GetSwizzleA(UnityEngine.Experimental.Rendering.GraphicsFormat format) { }
        private System.UInt32 GetBlockSize(UnityEngine.Experimental.Rendering.GraphicsFormat format) { }
        private System.Void .cctor() { }

    }

}

namespace UnityEngine.Experimental.U2D
{

    // TypeToken: 0x2000387
    public struct SpriteIntermediateRendererInfo
    {
        // Fields
        public System.Int32 SpriteID;        // 0x10
        public System.Int32 TextureID;        // 0x14
        public System.Int32 MaterialID;        // 0x18
        public UnityEngine.Color Color;        // 0x1C
        public UnityEngine.Matrix4x4 Transform;        // 0x2C
        public UnityEngine.Bounds Bounds;        // 0x6C
        public System.Int32 Layer;        // 0x84
        public System.Int32 SortingLayer;        // 0x88
        public System.Int32 SortingOrder;        // 0x8C
        public System.UInt64 SceneCullingMask;        // 0x90
        public System.IntPtr IndexData;        // 0x98
        public System.IntPtr VertexData;        // 0xA0
        public System.Int32 IndexCount;        // 0xA8
        public System.Int32 VertexCount;        // 0xAC
        public System.Int32 ShaderChannelMask;        // 0xB0

    }

    // TypeToken: 0x2000388
    public class SpriteRendererGroup
    {
    }

}

namespace UnityEngine.HyperGryph
{

    // TypeToken: 0x20002E0
    public struct ManagerContextType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.HyperGryph.ManagerContextType HGManagerContext;        // 0x0
        public static UnityEngine.HyperGryph.ManagerContextType GameplayManagerContext;        // 0x0
        public static UnityEngine.HyperGryph.ManagerContextType Count;        // 0x0

    }

    // TypeToken: 0x20002E1
    public class HGGlobalGameManagerAssetBase : ScriptableObject
    {
        // Methods
        private UnityEngine.HyperGryph.HGManagerContextBase InternalCreateManagerContext() { }
        private UnityEngine.HyperGryph.HGManagerContextBase CreateManagerContext() { }
        private System.Void OnDisable() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002E2
    public class HGGlobalGameManager
    {
        // Fields
        private static UnityEngine.HyperGryph.HGGlobalGameManagerAssetBase[] currentManagerAssets;        // 0x0
        public static UnityEngine.HyperGryph.HGManagerContextBase[] currentManagerContexts;        // 0x8

        // Methods
        private UnityEngine.ScriptableObject GetGlobalGameManagerAsset(UnityEngine.HyperGryph.ManagerContextType contextType) { }
        private UnityEngine.HyperGryph.HGGlobalGameManagerAssetBase GetManagerAsset(UnityEngine.HyperGryph.ManagerContextType contextType) { }
        private System.Void HandleManagerAssetChange(UnityEngine.HyperGryph.ManagerContextType contextType, UnityEngine.HyperGryph.HGGlobalGameManagerAssetBase asset) { }
        private System.Void CleanupManagerContext(UnityEngine.HyperGryph.ManagerContextType contextType) { }
        private System.Boolean InitializeManagerContext(UnityEngine.HyperGryph.ManagerContextType contextType, UnityEngine.HyperGryph.HGGlobalGameManagerAssetBase asset) { }
        private System.Void ManagerContextEarlyUpdate() { }
        private System.Void ManagerContextGameplayUpdate() { }
        private System.Void ManagerContextPipelineUpdate() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002E3
    public class HGManagerContextBase
    {
        // Fields
        private System.Boolean <disposed>k__BackingField;        // 0x10

        // Methods
        private System.Void EarlyUpdate() { }
        private System.Void GameplayUpdate() { }
        private System.Void PipelineUpdate() { }
        private System.Void InternalEarlyUpdate() { }
        private System.Void InternalGameplayUpdate() { }
        private System.Void InternalPipelineUpdate() { }
        private System.Boolean get_disposed() { }
        private System.Void set_disposed(System.Boolean value) { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002E4
    public struct LODCrossFadeConfig
    {
        // Fields
        public UnityEngine.Vector3 cameraPosition;        // 0x10
        public UnityEngine.Vector3 c0;        // 0x1C
        public UnityEngine.Vector3 c1;        // 0x28
        public System.Single fraction;        // 0x34
        public System.Single currMaxProjFactorSquared;        // 0x38
        public System.Single maxProjFactorSquared0;        // 0x3C
        public System.Single maxProjFactorSquared1;        // 0x40
        public System.Boolean enableDither;        // 0x44
        public System.Boolean isOrtho;        // 0x45
        public System.Byte lodBias;        // 0x46

    }

    // TypeToken: 0x20002E5
    public struct HGShadowCullData
    {
        // Fields
        public System.Boolean orthographic;        // 0x10
        public System.Single cameraNear;        // 0x14
        public System.Single projectionNear;        // 0x18
        public System.Single projectionFar;        // 0x1C
        public System.Single cameraFov;        // 0x20
        public System.Single shadowNearPlaneOffset;        // 0x24
        public System.Single shadowDistance;        // 0x28
        public System.Single baseFarDistance;        // 0x2C
        public UnityEngine.Matrix4x4 cameraClipToWorld;        // 0x30
        public UnityEngine.Matrix4x4 implicitProjection;        // 0x70
        public UnityEngine.Matrix4x4 cameraToWorld;        // 0xB0
        public UnityEngine.Vector3 eyePos;        // 0xF0
        public UnityEngine.Plane cullingPlaneLeft;        // 0xFC
        public UnityEngine.Plane cullingPlanesRight;        // 0x10C
        public UnityEngine.Plane cullingPlanesBottom;        // 0x11C
        public UnityEngine.Plane cullingPlanesTop;        // 0x12C
        public UnityEngine.Plane cullingPlanesNear;        // 0x13C
        public UnityEngine.Plane cullingPlanesFar;        // 0x14C
        public UnityEngine.Matrix4x4 lightLocalToWorld;        // 0x15C
        public UnityEngine.Vector3 center;        // 0x19C
        public System.Single radius;        // 0x1A8

    }

    // TypeToken: 0x20002E6
    public struct LightCullResult
    {
        // Fields
        public System.IntPtr visibleLightsPtr;        // 0x10
        public System.Int32 visibleLightCount;        // 0x18

        // Methods
        private Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> get_visibleLights() { }

    }

    // TypeToken: 0x20002E7
    public class HGCullingSystem
    {
        // Methods
        private System.Void set_parentLODBias(System.Single value) { }
        private System.Void SetArtTagLODBias(System.UInt32 artTag, System.Single lodBias) { }
        private System.UInt32 AddCullViewByMatrix(UnityEngine.Matrix4x4& viewProj, System.Int32 cameraInstantId, System.UInt64 sceneMask, System.UInt32 cullingLayerMask, System.UInt32 objectFlagsValue, System.UInt32 objectFlagsMask, UnityEngine.HyperGryph.LODCrossFadeConfig& config, System.Single viewScreenSizeMinSquared, UnityEngine.CameraType viewType, System.UInt32 uniqueId, System.Int32 depthBufferWidth, System.Int32 depthBufferHeight, UnityEngine.Vector3& cameraDir, UnityEngine.Vector4& cameraProjInfo, System.Single cullingRadius, System.Single ocScreenSizeMinSquared) { }
        private System.UInt32 AddCullViewByPlanes(Unity.Collections.NativeArray<UnityEngine.Plane> planes, System.Int32 cameraInstantId, System.UInt64 sceneMask, System.UInt32 cullingLayerMask, System.UInt32 objectFlagsValue, System.UInt32 objectFlagsMask, UnityEngine.HyperGryph.LODCrossFadeConfig& config, System.Single viewScreenSizeMinSquared, UnityEngine.CameraType viewType) { }
        private System.UInt32 RegisterCullViewUniqueId(System.Int32 instanceId) { }
        private System.Void UnregisterCullViewUniqueId(System.UInt32 cullViewUniqueId) { }
        private System.UInt32 AddCullViewByPlanes(System.IntPtr planes, System.Int32 planeCount, System.Int32 cameraInstantId, System.UInt64 sceneMask, System.UInt32 cullingLayerMask, System.UInt32 objectFlagsValue, System.UInt32 objectFlagsMask, UnityEngine.HyperGryph.LODCrossFadeConfig& config, System.Single viewScreenSizeMinSquared, UnityEngine.CameraType viewType, System.UInt32 uniqueId, System.Int32 depthBufferWidth, System.Int32 depthBufferHeight, UnityEngine.Matrix4x4& cullingMatrix, UnityEngine.Vector3& cameraDir, UnityEngine.Vector4& cameraProjInfo, System.Single cullingRadius, System.Single ocScreenSizeMinSquared) { }
        private System.Void DispatchBatchCullingJobs() { }
        private Unity.Jobs.JobHandle GetCullingViewFence(System.UInt32 viewHandle) { }
        private System.Void ExtractShadowCullDataForDirLight(UnityEngine.Camera camera, UnityEngine.Matrix4x4 lightLocalToWorld, System.Single shadowMaxDistance, System.Single nearPlaneOffset, UnityEngine.HyperGryph.HGShadowCullData& shadowCullData) { }
        private System.Void GetPSSMSplitMatrices(UnityEngine.HyperGryph.HGShadowCullData& shadowCullData, System.Single splitPercentage0, System.Single splitPercentage1, System.Int32 shadowResolution, UnityEngine.Matrix4x4& outViewMatrix, UnityEngine.Matrix4x4& outProjMatrix, UnityEngine.Matrix4x4& outProjFlipYMatrix, UnityEngine.Rendering.ShadowSplitData& outSplitData) { }
        private UnityEngine.HyperGryph.LightCullResult CullLights(System.UInt32 viewHandle, UnityEngine.Vector3 cameraPosition, System.UInt32 maxCount, System.Int32 cameraInstanceId) { }
        private System.Void CullLightsInternal(System.UInt32 viewHandle, UnityEngine.Vector3 cameraPosition, System.UInt32 maxCount, System.Int32 cameraInstanceId, System.IntPtr result) { }
        private System.Void GetCullingViewFence_Injected(System.UInt32 viewHandle, Unity.Jobs.JobHandle& ret) { }
        private System.Void ExtractShadowCullDataForDirLight_Injected(UnityEngine.Camera camera, UnityEngine.Matrix4x4& lightLocalToWorld, System.Single shadowMaxDistance, System.Single nearPlaneOffset, UnityEngine.HyperGryph.HGShadowCullData& shadowCullData) { }
        private System.Void CullLightsInternal_Injected(System.UInt32 viewHandle, UnityEngine.Vector3& cameraPosition, System.UInt32 maxCount, System.Int32 cameraInstanceId, System.IntPtr result) { }

    }

}

namespace UnityEngine.Internal
{

    // TypeToken: 0x20002DE
    public class DefaultValueAttribute : Attribute
    {
        // Fields
        private System.Object DefaultValue;        // 0x10

        // Methods
        private System.Void .ctor(System.String value) { }
        private System.Object get_Value() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x20002DF
    public class ExcludeFromDocsAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace UnityEngine.Jobs
{

    // TypeToken: 0x20001DE
    public interface IJobParallelForTransform
    {
        // Methods
        private System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform) { }

    }

    // TypeToken: 0x20001DF
    public interface IJobCrossFrameTransform
    {
        // Methods
        private System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform) { }

    }

    // TypeToken: 0x20001E0
    public class IJobParallelForTransformExtensions
    {
        // Methods
        private Unity.Jobs.JobHandle Schedule(T jobData, UnityEngine.Jobs.TransformAccessArray transforms, Unity.Jobs.JobHandle dependsOn) { }
        private Unity.Jobs.JobHandle ScheduleReadOnly(T jobData, UnityEngine.Jobs.TransformAccessArray transforms, System.Int32 batchSize, Unity.Jobs.JobHandle dependsOn) { }
        private System.Void RunReadOnly(T jobData, UnityEngine.Jobs.TransformAccessArray transforms) { }
        private Unity.Jobs.JobHandle ScheduleCrossFrameReadOnly(T jobData, UnityEngine.Jobs.TransformAccessArray transforms, Unity.Jobs.JobHandle dependsOn) { }
        private Unity.Jobs.JobHandle ScheduleCrossFrame(T jobData, UnityEngine.Jobs.TransformAccessArray transforms, Unity.Jobs.JobHandle dependsOn) { }

    }

    // TypeToken: 0x20001E7
    public struct TransformAccess
    {
        // Fields
        private System.IntPtr hierarchy;        // 0x10
        private System.Int32 index;        // 0x18

        // Methods
        private UnityEngine.Vector3 get_position() { }
        private System.Void set_position(UnityEngine.Vector3 value) { }
        private UnityEngine.Quaternion get_rotation() { }
        private System.Void set_rotation(UnityEngine.Quaternion value) { }
        private UnityEngine.Vector3 get_localPosition() { }
        private System.Void set_localPosition(UnityEngine.Vector3 value) { }
        private UnityEngine.Quaternion get_localRotation() { }
        private System.Void set_localRotation(UnityEngine.Quaternion value) { }
        private UnityEngine.Vector3 get_localScale() { }
        private System.Void set_localScale(UnityEngine.Vector3 value) { }
        private UnityEngine.Matrix4x4 get_localToWorldMatrix() { }
        private System.Boolean get_isValid() { }
        private System.Void GetPosition(UnityEngine.Jobs.TransformAccess& access, UnityEngine.Vector3& p) { }
        private System.Void SetPosition(UnityEngine.Jobs.TransformAccess& access, UnityEngine.Vector3& p) { }
        private System.Void GetRotation(UnityEngine.Jobs.TransformAccess& access, UnityEngine.Quaternion& r) { }
        private System.Void SetRotation(UnityEngine.Jobs.TransformAccess& access, UnityEngine.Quaternion& r) { }
        private System.Void GetLocalPosition(UnityEngine.Jobs.TransformAccess& access, UnityEngine.Vector3& p) { }
        private System.Void SetLocalPosition(UnityEngine.Jobs.TransformAccess& access, UnityEngine.Vector3& p) { }
        private System.Void GetLocalRotation(UnityEngine.Jobs.TransformAccess& access, UnityEngine.Quaternion& r) { }
        private System.Void SetLocalRotation(UnityEngine.Jobs.TransformAccess& access, UnityEngine.Quaternion& r) { }
        private System.Void GetLocalScale(UnityEngine.Jobs.TransformAccess& access, UnityEngine.Vector3& r) { }
        private System.Void SetLocalScale(UnityEngine.Jobs.TransformAccess& access, UnityEngine.Vector3& r) { }
        private System.Void GetLocalToWorldMatrix(UnityEngine.Jobs.TransformAccess& access, UnityEngine.Matrix4x4& m) { }

    }

    // TypeToken: 0x20001E8
    public struct TransformAccessArray, IDisposable
    {
        // Fields
        private System.IntPtr m_TransformArray;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.Transform[] transforms, System.Int32 desiredJobCount) { }
        private System.Void .ctor(System.Int32 capacity, System.Int32 desiredJobCount) { }
        private System.Void Allocate(System.Int32 capacity, System.Int32 desiredJobCount, UnityEngine.Jobs.TransformAccessArray& array) { }
        private System.Boolean get_isCreated() { }
        private System.Void Dispose() { }
        private System.IntPtr GetTransformAccessArrayForSchedule() { }
        private UnityEngine.Transform get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, UnityEngine.Transform value) { }
        private System.Int32 get_length() { }
        private System.Void Add(UnityEngine.Transform transform) { }
        private System.IntPtr Create(System.Int32 capacity, System.Int32 desiredJobCount) { }
        private System.Void DestroyTransformAccessArray(System.IntPtr transformArray) { }
        private System.Void SetTransforms(System.IntPtr transformArrayIntPtr, UnityEngine.Transform[] transforms) { }
        private System.Void Add(System.IntPtr transformArrayIntPtr, UnityEngine.Transform transform) { }
        private System.IntPtr GetSortedTransformAccess(System.IntPtr transformArrayIntPtr) { }
        private System.IntPtr GetSortedToUserIndex(System.IntPtr transformArrayIntPtr) { }
        private System.Int32 GetLength(System.IntPtr transformArrayIntPtr) { }
        private UnityEngine.Transform GetTransform(System.IntPtr transformArrayIntPtr, System.Int32 index) { }
        private System.Void SetTransform(System.IntPtr transformArrayIntPtr, System.Int32 index, UnityEngine.Transform transform) { }

    }

}

namespace UnityEngine.LowLevel
{

    // TypeToken: 0x2000234
    public struct PlayerLoopSystemInternal
    {
        // Fields
        public System.Type type;        // 0x10
        public UnityEngine.LowLevel.PlayerLoopSystem.UpdateFunction updateDelegate;        // 0x18
        public System.IntPtr updateFunction;        // 0x20
        public System.IntPtr loopConditionFunction;        // 0x28
        public System.Int32 numSubSystems;        // 0x30

    }

    // TypeToken: 0x2000235
    public struct PlayerLoopSystem
    {
        // Fields
        public System.Type type;        // 0x10
        public UnityEngine.LowLevel.PlayerLoopSystem[] subSystemList;        // 0x18
        public UnityEngine.LowLevel.PlayerLoopSystem.UpdateFunction updateDelegate;        // 0x20
        public System.IntPtr updateFunction;        // 0x28
        public System.IntPtr loopConditionFunction;        // 0x30

        // Methods
        private System.String ToString() { }

    }

    // TypeToken: 0x2000237
    public class PlayerLoop
    {
        // Methods
        private UnityEngine.LowLevel.PlayerLoopSystem GetCurrentPlayerLoop() { }
        private System.Void SetPlayerLoop(UnityEngine.LowLevel.PlayerLoopSystem loop) { }
        private System.Int32 PlayerLoopSystemToInternal(UnityEngine.LowLevel.PlayerLoopSystem sys, System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystemInternal>& internalSys) { }
        private UnityEngine.LowLevel.PlayerLoopSystem InternalToPlayerLoopSystem(UnityEngine.LowLevel.PlayerLoopSystemInternal[] internalSys, System.Int32& offset) { }
        private UnityEngine.LowLevel.PlayerLoopSystemInternal[] GetCurrentPlayerLoopInternal() { }
        private System.Void SetPlayerLoopInternal(UnityEngine.LowLevel.PlayerLoopSystemInternal[] loop) { }

    }

}

namespace UnityEngine.Networking.PlayerConnection
{

    // TypeToken: 0x20002D1
    public class MessageEventArgs
    {
        // Fields
        public System.Int32 playerId;        // 0x10
        public System.Byte[] data;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002D2
    public interface IEditorPlayerConnection
    {
        // Methods
        private System.Void Register(System.Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback) { }
        private System.Void RegisterConnection(UnityEngine.Events.UnityAction<System.Int32> callback) { }
        private System.Void RegisterDisconnection(UnityEngine.Events.UnityAction<System.Int32> callback) { }
        private System.Void Send(System.Guid messageId, System.Byte[] data) { }

    }

    // TypeToken: 0x20002D3
    public class PlayerConnection : ScriptableObject, IEditorPlayerConnection
    {
        // Fields
        private static UnityEngine.IPlayerEditorConnectionNative connectionNative;        // 0x0
        private UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents;        // 0x18
        private System.Collections.Generic.List<System.Int32> m_connectedPlayers;        // 0x20
        private System.Boolean m_IsInitilized;        // 0x28
        private static UnityEngine.Networking.PlayerConnection.PlayerConnection s_Instance;        // 0x8

        // Methods
        private UnityEngine.Networking.PlayerConnection.PlayerConnection get_instance() { }
        private System.Boolean get_isConnected() { }
        private UnityEngine.Networking.PlayerConnection.PlayerConnection CreateInstance() { }
        private System.Void OnEnable() { }
        private UnityEngine.IPlayerEditorConnectionNative GetConnectionNativeApi() { }
        private System.Void Register(System.Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback) { }
        private System.Void Unregister(System.Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback) { }
        private System.Void RegisterConnection(UnityEngine.Events.UnityAction<System.Int32> callback) { }
        private System.Void RegisterDisconnection(UnityEngine.Events.UnityAction<System.Int32> callback) { }
        private System.Void UnregisterConnection(UnityEngine.Events.UnityAction<System.Int32> callback) { }
        private System.Void UnregisterDisconnection(UnityEngine.Events.UnityAction<System.Int32> callback) { }
        private System.Void Send(System.Guid messageId, System.Byte[] data) { }
        private System.Boolean TrySend(System.Guid messageId, System.Byte[] data) { }
        private System.Boolean BlockUntilRecvMsg(System.Guid messageId, System.Int32 timeout) { }
        private System.Void DisconnectAll() { }
        private System.Void MessageCallbackInternal(System.IntPtr data, System.UInt64 size, System.UInt64 guid, System.String messageId) { }
        private System.Void ConnectedCallbackInternal(System.Int32 playerId) { }
        private System.Void DisconnectedCallback(System.Int32 playerId) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002D7
    public class PlayerEditorConnectionEvents
    {
        // Fields
        public System.Collections.Generic.List<UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers> messageTypeSubscribers;        // 0x10
        public UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.ConnectionChangeEvent connectionEvent;        // 0x18
        public UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent;        // 0x20

        // Methods
        private System.Void InvokeMessageIdSubscribers(System.Guid messageId, System.Byte[] data, System.Int32 playerId) { }
        private UnityEngine.Events.UnityEvent<UnityEngine.Networking.PlayerConnection.MessageEventArgs> AddAndCreate(System.Guid messageId) { }
        private System.Void UnregisterManagedCallback(System.Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback) { }
        private System.Void .ctor() { }

    }

}

namespace UnityEngine.Playables
{

    // TypeToken: 0x2000367
    public struct FrameData
    {
        // Fields
        private System.UInt64 m_FrameID;        // 0x10
        private System.Double m_DeltaTime;        // 0x18
        private System.Single m_Weight;        // 0x20
        private System.Single m_EffectiveWeight;        // 0x24
        private System.Double m_EffectiveParentDelay;        // 0x28
        private System.Single m_EffectiveParentSpeed;        // 0x30
        private System.Single m_EffectiveSpeed;        // 0x34
        private UnityEngine.Playables.FrameData.Flags m_Flags;        // 0x38
        private UnityEngine.Playables.PlayableOutput m_Output;        // 0x40

        // Methods
        private System.Boolean HasFlags(UnityEngine.Playables.FrameData.Flags flag) { }
        private System.Single get_deltaTime() { }
        private System.Single get_weight() { }
        private System.Single get_effectiveWeight() { }
        private System.Single get_effectiveSpeed() { }
        private UnityEngine.Playables.FrameData.EvaluationType get_evaluationType() { }
        private System.Boolean get_seekOccurred() { }
        private System.Boolean get_timeLooped() { }
        private System.Boolean get_timeHeld() { }
        private UnityEngine.Playables.PlayableOutput get_output() { }
        private UnityEngine.Playables.PlayState get_effectivePlayState() { }

    }

    // TypeToken: 0x200036A
    public struct FrameRate, IEquatable`1
    {
        // Fields
        public static readonly UnityEngine.Playables.FrameRate k_24Fps;        // 0x0
        public static readonly UnityEngine.Playables.FrameRate k_23_976Fps;        // 0x4
        public static readonly UnityEngine.Playables.FrameRate k_25Fps;        // 0x8
        public static readonly UnityEngine.Playables.FrameRate k_30Fps;        // 0xC
        public static readonly UnityEngine.Playables.FrameRate k_29_97Fps;        // 0x10
        public static readonly UnityEngine.Playables.FrameRate k_50Fps;        // 0x14
        public static readonly UnityEngine.Playables.FrameRate k_60Fps;        // 0x18
        public static readonly UnityEngine.Playables.FrameRate k_59_94Fps;        // 0x1C
        private System.Int32 m_Rate;        // 0x10

        // Methods
        private System.Boolean get_dropFrame() { }
        private System.Double get_rate() { }
        private System.Void .ctor(System.UInt32 frameRate, System.Boolean drop) { }
        private System.Boolean Equals(UnityEngine.Playables.FrameRate other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200036B
    public interface INotification
    {
        // Methods
        private UnityEngine.PropertyName get_id() { }

    }

    // TypeToken: 0x200036C
    public interface INotificationReceiver
    {
        // Methods
        private System.Void OnNotify(UnityEngine.Playables.Playable origin, UnityEngine.Playables.INotification notification, System.Object context) { }

    }

    // TypeToken: 0x200036D
    public interface IPlayable
    {
        // Methods
        private UnityEngine.Playables.PlayableHandle GetHandle() { }

    }

    // TypeToken: 0x200036E
    public interface IPlayableBehaviour
    {
        // Methods
        private System.Void OnGraphStart(UnityEngine.Playables.Playable playable) { }
        private System.Void OnGraphStop(UnityEngine.Playables.Playable playable) { }
        private System.Void OnPlayableCreate(UnityEngine.Playables.Playable playable) { }
        private System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable) { }
        private System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData) { }

    }

    // TypeToken: 0x200036F
    public interface IPlayableOutput
    {
        // Methods
        private UnityEngine.Playables.PlayableOutputHandle GetHandle() { }

    }

    // TypeToken: 0x2000370
    public struct DirectorWrapMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Playables.DirectorWrapMode Hold;        // 0x0
        public static UnityEngine.Playables.DirectorWrapMode Loop;        // 0x0
        public static UnityEngine.Playables.DirectorWrapMode None;        // 0x0

    }

    // TypeToken: 0x2000371
    public struct Playable, IPlayable, IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;        // 0x10
        private static readonly UnityEngine.Playables.Playable m_NullPlayable;        // 0x0

        // Methods
        private UnityEngine.Playables.Playable get_Null() { }
        private UnityEngine.Playables.Playable Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount) { }
        private System.Void .ctor(UnityEngine.Playables.PlayableHandle handle) { }
        private UnityEngine.Playables.PlayableHandle GetHandle() { }
        private System.Boolean IsPlayableOfType() { }
        private System.Type GetPlayableType() { }
        private System.Boolean Equals(UnityEngine.Playables.Playable other) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000372
    public interface IPlayableAsset
    {
        // Methods
        private UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner) { }
        private System.Double get_duration() { }

    }

    // TypeToken: 0x2000373
    public class PlayableAsset : ScriptableObject, IPlayableAsset
    {
        // Methods
        private UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner) { }
        private System.Double get_duration() { }
        private System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs() { }
        private System.Void Internal_CreatePlayable(UnityEngine.Playables.PlayableAsset asset, UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.IntPtr ptr) { }
        private System.Void Internal_GetPlayableAssetDuration(UnityEngine.Playables.PlayableAsset asset, System.IntPtr ptrToDouble) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000374
    public class PlayableBehaviour, IPlayableBehaviour, ICloneable
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void OnGraphStart(UnityEngine.Playables.Playable playable) { }
        private System.Void OnGraphStop(UnityEngine.Playables.Playable playable) { }
        private System.Void OnPlayableCreate(UnityEngine.Playables.Playable playable) { }
        private System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable) { }
        private System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void PrepareData(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData) { }
        private System.Object Clone() { }

    }

    // TypeToken: 0x2000375
    public struct PlayableBinding
    {
        // Fields
        private System.String m_StreamName;        // 0x10
        private UnityEngine.Object m_SourceObject;        // 0x18
        private System.Type m_SourceBindingType;        // 0x20
        private UnityEngine.Playables.PlayableBinding.CreateOutputMethod m_CreateOutputMethod;        // 0x28
        public static readonly UnityEngine.Playables.PlayableBinding[] None;        // 0x0
        public static readonly System.Double DefaultDuration;        // 0x8

        // Methods
        private UnityEngine.Object get_sourceObject() { }
        private UnityEngine.Playables.PlayableOutput CreateOutput(UnityEngine.Playables.PlayableGraph graph) { }
        private UnityEngine.Playables.PlayableBinding CreateInternal(System.String name, UnityEngine.Object sourceObject, System.Type sourceType, UnityEngine.Playables.PlayableBinding.CreateOutputMethod createFunction) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000377
    public struct PlayableTraversalMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Playables.PlayableTraversalMode Mix;        // 0x0
        public static UnityEngine.Playables.PlayableTraversalMode Passthrough;        // 0x0

    }

    // TypeToken: 0x2000378
    public class PlayableExtensions
    {
        // Methods
        private System.Boolean IsNull(U playable) { }
        private System.Boolean IsValid(U playable) { }
        private System.Void Destroy(U playable) { }
        private UnityEngine.Playables.PlayableGraph GetGraph(U playable) { }
        private UnityEngine.Playables.PlayState GetPlayState(U playable) { }
        private System.Void Play(U playable) { }
        private System.Void Pause(U playable) { }
        private System.Void SetSpeed(U playable, System.Double value) { }
        private System.Double GetSpeed(U playable) { }
        private System.Void SetDuration(U playable, System.Double value) { }
        private System.Double GetDuration(U playable) { }
        private System.Void SetTime(U playable, System.Double value) { }
        private System.Void SetTimeUncheck(U playable, System.Double value) { }
        private System.Double GetTime(U playable) { }
        private System.Double GetPreviousTime(U playable) { }
        private System.Boolean IsDone(U playable) { }
        private System.Void SetPropagateSetTime(U playable, System.Boolean value) { }
        private System.Boolean CanDestroy(U playable) { }
        private System.Void SetInputCount(U playable, System.Int32 value) { }
        private System.Int32 GetInputCount(U playable) { }
        private UnityEngine.Playables.Playable GetInput(U playable, System.Int32 inputPort) { }
        private System.Void SetInputWeight(U playable, System.Int32 inputIndex, System.Single weight) { }
        private System.Void SetInputWeightUncheck(U playable, System.Int32 inputIndex, System.Single weight) { }
        private System.Void SetInputWeight(U playable, V input, System.Single weight) { }
        private System.Single GetInputWeight(U playable, System.Int32 inputIndex) { }
        private System.Void ConnectInput(U playable, System.Int32 inputIndex, V sourcePlayable, System.Int32 sourceOutputIndex) { }
        private System.Void ConnectInput(U playable, System.Int32 inputIndex, V sourcePlayable, System.Int32 sourceOutputIndex, System.Single weight) { }
        private System.Void DisconnectInput(U playable, System.Int32 inputPort) { }
        private System.Int32 AddInput(U playable, V sourcePlayable, System.Int32 sourceOutputIndex, System.Single weight) { }
        private System.Single GetLeadTime(U playable) { }
        private System.Void SetTraversalMode(U playable, UnityEngine.Playables.PlayableTraversalMode mode) { }
        private UnityEngine.Playables.DirectorWrapMode GetTimeWrapMode(U playable) { }
        private System.Void SetTimeWrapMode(U playable, UnityEngine.Playables.DirectorWrapMode value) { }

    }

    // TypeToken: 0x2000379
    public struct DirectorUpdateMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Playables.DirectorUpdateMode DSPClock;        // 0x0
        public static UnityEngine.Playables.DirectorUpdateMode GameTime;        // 0x0
        public static UnityEngine.Playables.DirectorUpdateMode UnscaledGameTime;        // 0x0
        public static UnityEngine.Playables.DirectorUpdateMode Manual;        // 0x0

    }

    // TypeToken: 0x200037A
    public struct PlayableGraph
    {
        // Fields
        private System.IntPtr m_Handle;        // 0x10
        private System.UInt32 m_Version;        // 0x18

        // Methods
        private UnityEngine.Playables.Playable GetRootPlayable(System.Int32 index) { }
        private System.Boolean Connect(U source, System.Int32 sourceOutputPort, V destination, System.Int32 destinationInputPort) { }
        private System.Void Disconnect(U input, System.Int32 inputPort) { }
        private System.Void DestroyPlayable(U playable) { }
        private UnityEngine.Playables.PlayableOutput GetOutput(System.Int32 index) { }
        private System.Void Evaluate() { }
        private UnityEngine.Playables.PlayableGraph Create() { }
        private UnityEngine.Playables.PlayableGraph Create(System.String name) { }
        private System.Void Destroy() { }
        private System.Boolean IsValid() { }
        private System.Boolean IsPlaying() { }
        private System.Void Play() { }
        private System.Void Stop() { }
        private System.Void Evaluate(System.Single deltaTime) { }
        private System.Void SetTimeUpdateMode(UnityEngine.Playables.DirectorUpdateMode value) { }
        private UnityEngine.IExposedPropertyTable GetResolver() { }
        private System.Int32 GetPlayableCount() { }
        private System.Int32 GetRootPlayableCount() { }
        private System.Void SynchronizeEvaluation(UnityEngine.Playables.PlayableGraph playable) { }
        private System.Int32 GetOutputCount() { }
        private System.Void SetEarlyPrepareFrame(System.Boolean enable) { }
        private System.Boolean IsEarlyPrepareFrame() { }
        private UnityEngine.Playables.PlayableHandle CreatePlayableHandle() { }
        private System.Boolean CreateScriptOutputInternal(System.String name, UnityEngine.Playables.PlayableOutputHandle& handle) { }
        private UnityEngine.Playables.PlayableHandle GetRootPlayableInternal(System.Int32 index) { }
        private System.Boolean IsMatchFrameRateEnabled() { }
        private UnityEngine.Playables.FrameRate GetFrameRate() { }
        private System.Boolean GetOutputInternal(System.Int32 index, UnityEngine.Playables.PlayableOutputHandle& handle) { }
        private System.Boolean ConnectInternal(UnityEngine.Playables.PlayableHandle source, System.Int32 sourceOutputPort, UnityEngine.Playables.PlayableHandle destination, System.Int32 destinationInputPort) { }
        private System.Void DisconnectInternal(UnityEngine.Playables.PlayableHandle playable, System.Int32 inputPort) { }
        private System.Void DestroyPlayableInternal(UnityEngine.Playables.PlayableHandle playable) { }
        private System.Void Create_Injected(System.String name, UnityEngine.Playables.PlayableGraph& ret) { }
        private System.Void Destroy_Injected(UnityEngine.Playables.PlayableGraph& _unity_self) { }
        private System.Boolean IsValid_Injected(UnityEngine.Playables.PlayableGraph& _unity_self) { }
        private System.Boolean IsPlaying_Injected(UnityEngine.Playables.PlayableGraph& _unity_self) { }
        private System.Void Play_Injected(UnityEngine.Playables.PlayableGraph& _unity_self) { }
        private System.Void Stop_Injected(UnityEngine.Playables.PlayableGraph& _unity_self) { }
        private System.Void Evaluate_Injected(UnityEngine.Playables.PlayableGraph& _unity_self, System.Single deltaTime) { }
        private System.Void SetTimeUpdateMode_Injected(UnityEngine.Playables.PlayableGraph& _unity_self, UnityEngine.Playables.DirectorUpdateMode value) { }
        private UnityEngine.IExposedPropertyTable GetResolver_Injected(UnityEngine.Playables.PlayableGraph& _unity_self) { }
        private System.Int32 GetPlayableCount_Injected(UnityEngine.Playables.PlayableGraph& _unity_self) { }
        private System.Int32 GetRootPlayableCount_Injected(UnityEngine.Playables.PlayableGraph& _unity_self) { }
        private System.Void SynchronizeEvaluation_Injected(UnityEngine.Playables.PlayableGraph& _unity_self, UnityEngine.Playables.PlayableGraph& playable) { }
        private System.Int32 GetOutputCount_Injected(UnityEngine.Playables.PlayableGraph& _unity_self) { }
        private System.Void SetEarlyPrepareFrame_Injected(UnityEngine.Playables.PlayableGraph& _unity_self, System.Boolean enable) { }
        private System.Boolean IsEarlyPrepareFrame_Injected(UnityEngine.Playables.PlayableGraph& _unity_self) { }
        private System.Void CreatePlayableHandle_Injected(UnityEngine.Playables.PlayableGraph& _unity_self, UnityEngine.Playables.PlayableHandle& ret) { }
        private System.Boolean CreateScriptOutputInternal_Injected(UnityEngine.Playables.PlayableGraph& _unity_self, System.String name, UnityEngine.Playables.PlayableOutputHandle& handle) { }
        private System.Void GetRootPlayableInternal_Injected(UnityEngine.Playables.PlayableGraph& _unity_self, System.Int32 index, UnityEngine.Playables.PlayableHandle& ret) { }
        private System.Boolean IsMatchFrameRateEnabled_Injected(UnityEngine.Playables.PlayableGraph& _unity_self) { }
        private System.Void GetFrameRate_Injected(UnityEngine.Playables.PlayableGraph& _unity_self, UnityEngine.Playables.FrameRate& ret) { }
        private System.Boolean GetOutputInternal_Injected(UnityEngine.Playables.PlayableGraph& _unity_self, System.Int32 index, UnityEngine.Playables.PlayableOutputHandle& handle) { }
        private System.Boolean ConnectInternal_Injected(UnityEngine.Playables.PlayableGraph& _unity_self, UnityEngine.Playables.PlayableHandle& source, System.Int32 sourceOutputPort, UnityEngine.Playables.PlayableHandle& destination, System.Int32 destinationInputPort) { }
        private System.Void DisconnectInternal_Injected(UnityEngine.Playables.PlayableGraph& _unity_self, UnityEngine.Playables.PlayableHandle& playable, System.Int32 inputPort) { }
        private System.Void DestroyPlayableInternal_Injected(UnityEngine.Playables.PlayableGraph& _unity_self, UnityEngine.Playables.PlayableHandle& playable) { }

    }

    // TypeToken: 0x200037B
    public struct PlayState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Playables.PlayState Paused;        // 0x0
        public static UnityEngine.Playables.PlayState Playing;        // 0x0
        public static UnityEngine.Playables.PlayState Delayed;        // 0x0

    }

    // TypeToken: 0x200037C
    public struct PlayableHandle, IEquatable`1
    {
        // Fields
        private System.IntPtr m_Handle;        // 0x10
        private System.UInt32 m_Version;        // 0x18
        private static readonly UnityEngine.Playables.PlayableHandle m_Null;        // 0x0

        // Methods
        private T GetObject() { }
        private System.Object GetWrapScriptObject() { }
        private System.Boolean IsPlayableOfType() { }
        private UnityEngine.Playables.PlayableHandle get_Null() { }
        private UnityEngine.Playables.Playable GetInput(System.Int32 inputPort) { }
        private System.Boolean SetInputWeight(System.Int32 inputIndex, System.Single weight) { }
        private System.Boolean SetInputWeightUncheck(System.Int32 inputIndex, System.Single weight) { }
        private System.Single GetInputWeight(System.Int32 inputIndex) { }
        private System.Void Destroy() { }
        private System.Boolean op_Equality(UnityEngine.Playables.PlayableHandle x, UnityEngine.Playables.PlayableHandle y) { }
        private System.Boolean Equals(System.Object p) { }
        private System.Boolean Equals(UnityEngine.Playables.PlayableHandle other) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean CompareVersion(UnityEngine.Playables.PlayableHandle lhs, UnityEngine.Playables.PlayableHandle rhs) { }
        private System.Boolean CheckInputBounds(System.Int32 inputIndex) { }
        private System.Boolean CheckInputBounds(System.Int32 inputIndex, System.Boolean acceptAny) { }
        private System.Boolean CheckInputBoundsUncheck(System.Int32 inputIndex) { }
        private System.Boolean IsNull() { }
        private System.Boolean IsValid() { }
        private System.Type GetPlayableType() { }
        private System.Type GetJobType() { }
        private System.Void SetScriptInstance(System.Object scriptInstance) { }
        private System.Boolean CanDestroy() { }
        private UnityEngine.Playables.PlayState GetPlayState() { }
        private System.Void Play() { }
        private System.Void Pause() { }
        private System.Double GetSpeed() { }
        private System.Void SetSpeed(System.Double value) { }
        private System.Double GetTime() { }
        private System.Void SetTime(System.Double value) { }
        private System.Boolean IsDone() { }
        private System.Void SetDone(System.Boolean value) { }
        private System.Double GetDuration() { }
        private System.Void SetDuration(System.Double value) { }
        private System.Void SetPropagateSetTime(System.Boolean value) { }
        private UnityEngine.Playables.PlayableGraph GetGraph() { }
        private System.Int32 GetInputCount() { }
        private System.Void SetInputCount(System.Int32 value) { }
        private System.Void SetInputWeight(UnityEngine.Playables.PlayableHandle input, System.Single weight) { }
        private System.Double GetPreviousTime() { }
        private System.Single GetLeadTime() { }
        private System.Void SetTraversalMode(UnityEngine.Playables.PlayableTraversalMode mode) { }
        private System.IntPtr GetJobData() { }
        private UnityEngine.Playables.DirectorWrapMode GetTimeWrapMode() { }
        private System.Void SetTimeWrapMode(UnityEngine.Playables.DirectorWrapMode mode) { }
        private System.Object GetScriptInstance() { }
        private UnityEngine.Playables.PlayableHandle GetInputHandle(System.Int32 index) { }
        private System.Void SetInputWeightFromIndex(System.Int32 index, System.Single weight) { }
        private System.Single GetInputWeightFromIndex(System.Int32 index) { }
        private System.Void SetInputWeightFromIndexUncheck(System.Int32 index, System.Single weight) { }
        private System.Int32 GetInputCountUncheck() { }
        private System.Void SetTimeUncheck(System.Double value) { }
        private System.Void .cctor() { }
        private System.Boolean IsNull_Injected(UnityEngine.Playables.PlayableHandle& _unity_self) { }
        private System.Boolean IsValid_Injected(UnityEngine.Playables.PlayableHandle& _unity_self) { }
        private System.Type GetPlayableType_Injected(UnityEngine.Playables.PlayableHandle& _unity_self) { }
        private System.Type GetJobType_Injected(UnityEngine.Playables.PlayableHandle& _unity_self) { }
        private System.Void SetScriptInstance_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, System.Object scriptInstance) { }
        private System.Boolean CanDestroy_Injected(UnityEngine.Playables.PlayableHandle& _unity_self) { }
        private UnityEngine.Playables.PlayState GetPlayState_Injected(UnityEngine.Playables.PlayableHandle& _unity_self) { }
        private System.Void Play_Injected(UnityEngine.Playables.PlayableHandle& _unity_self) { }
        private System.Void Pause_Injected(UnityEngine.Playables.PlayableHandle& _unity_self) { }
        private System.Double GetSpeed_Injected(UnityEngine.Playables.PlayableHandle& _unity_self) { }
        private System.Void SetSpeed_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, System.Double value) { }
        private System.Double GetTime_Injected(UnityEngine.Playables.PlayableHandle& _unity_self) { }
        private System.Void SetTime_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, System.Double value) { }
        private System.Boolean IsDone_Injected(UnityEngine.Playables.PlayableHandle& _unity_self) { }
        private System.Void SetDone_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, System.Boolean value) { }
        private System.Double GetDuration_Injected(UnityEngine.Playables.PlayableHandle& _unity_self) { }
        private System.Void SetDuration_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, System.Double value) { }
        private System.Void SetPropagateSetTime_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, System.Boolean value) { }
        private System.Void GetGraph_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, UnityEngine.Playables.PlayableGraph& ret) { }
        private System.Int32 GetInputCount_Injected(UnityEngine.Playables.PlayableHandle& _unity_self) { }
        private System.Void SetInputCount_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, System.Int32 value) { }
        private System.Void SetInputWeight_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, UnityEngine.Playables.PlayableHandle& input, System.Single weight) { }
        private System.Double GetPreviousTime_Injected(UnityEngine.Playables.PlayableHandle& _unity_self) { }
        private System.Single GetLeadTime_Injected(UnityEngine.Playables.PlayableHandle& _unity_self) { }
        private System.Void SetTraversalMode_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, UnityEngine.Playables.PlayableTraversalMode mode) { }
        private System.IntPtr GetJobData_Injected(UnityEngine.Playables.PlayableHandle& _unity_self) { }
        private UnityEngine.Playables.DirectorWrapMode GetTimeWrapMode_Injected(UnityEngine.Playables.PlayableHandle& _unity_self) { }
        private System.Void SetTimeWrapMode_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, UnityEngine.Playables.DirectorWrapMode mode) { }
        private System.Object GetScriptInstance_Injected(UnityEngine.Playables.PlayableHandle& _unity_self) { }
        private System.Void GetInputHandle_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, System.Int32 index, UnityEngine.Playables.PlayableHandle& ret) { }
        private System.Void SetInputWeightFromIndex_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, System.Int32 index, System.Single weight) { }
        private System.Single GetInputWeightFromIndex_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, System.Int32 index) { }
        private System.Void SetInputWeightFromIndexUncheck_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, System.Int32 index, System.Single weight) { }
        private System.Int32 GetInputCountUncheck_Injected(UnityEngine.Playables.PlayableHandle& _unity_self) { }
        private System.Void SetTimeUncheck_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, System.Double value) { }

    }

    // TypeToken: 0x200037D
    public struct PlayableOutput, IPlayableOutput, IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableOutputHandle m_Handle;        // 0x10
        private static readonly UnityEngine.Playables.PlayableOutput m_NullPlayableOutput;        // 0x0

        // Methods
        private UnityEngine.Playables.PlayableOutput get_Null() { }
        private System.Void .ctor(UnityEngine.Playables.PlayableOutputHandle handle) { }
        private UnityEngine.Playables.PlayableOutputHandle GetHandle() { }
        private System.Boolean IsPlayableOutputOfType() { }
        private System.Boolean Equals(UnityEngine.Playables.PlayableOutput other) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200037E
    public class PlayableOutputExtensions
    {
        // Methods
        private System.Boolean IsOutputValid(U output) { }
        private System.Void SetReferenceObject(U output, UnityEngine.Object value) { }
        private UnityEngine.Object GetUserData(U output) { }
        private UnityEngine.Playables.Playable GetSourcePlayable(U output) { }
        private System.Void SetSourcePlayable(U output, V value) { }
        private System.Void SetSourcePlayable(U output, V value, System.Int32 port) { }
        private System.Int32 GetSourceOutputPort(U output) { }
        private System.Void SetWeight(U output, System.Single value) { }
        private System.Void PushNotification(U output, UnityEngine.Playables.Playable origin, UnityEngine.Playables.INotification notification, System.Object context) { }
        private System.Void AddNotificationReceiver(U output, UnityEngine.Playables.INotificationReceiver receiver) { }

    }

    // TypeToken: 0x200037F
    public struct PlayableOutputHandle, IEquatable`1
    {
        // Fields
        private System.IntPtr m_Handle;        // 0x10
        private System.UInt32 m_Version;        // 0x18
        private static readonly UnityEngine.Playables.PlayableOutputHandle m_Null;        // 0x0

        // Methods
        private UnityEngine.Playables.PlayableOutputHandle get_Null() { }
        private System.Boolean IsPlayableOutputOfType() { }
        private System.Int32 GetHashCode() { }
        private System.Boolean op_Equality(UnityEngine.Playables.PlayableOutputHandle lhs, UnityEngine.Playables.PlayableOutputHandle rhs) { }
        private System.Boolean Equals(System.Object p) { }
        private System.Boolean Equals(UnityEngine.Playables.PlayableOutputHandle other) { }
        private System.Boolean CompareVersion(UnityEngine.Playables.PlayableOutputHandle lhs, UnityEngine.Playables.PlayableOutputHandle rhs) { }
        private System.Boolean IsValid() { }
        private System.Type GetPlayableOutputType() { }
        private System.Void SetReferenceObject(UnityEngine.Object target) { }
        private UnityEngine.Object GetUserData() { }
        private UnityEngine.Playables.PlayableHandle GetSourcePlayable() { }
        private System.Void SetSourcePlayable(UnityEngine.Playables.PlayableHandle target, System.Int32 port) { }
        private System.Int32 GetSourceOutputPort() { }
        private System.Void SetWeight(System.Single weight) { }
        private System.Void PushNotification(UnityEngine.Playables.PlayableHandle origin, UnityEngine.Playables.INotification notification, System.Object context) { }
        private System.Void AddNotificationReceiver(UnityEngine.Playables.INotificationReceiver receiver) { }
        private System.Void .cctor() { }
        private System.Boolean IsValid_Injected(UnityEngine.Playables.PlayableOutputHandle& _unity_self) { }
        private System.Type GetPlayableOutputType_Injected(UnityEngine.Playables.PlayableOutputHandle& _unity_self) { }
        private System.Void SetReferenceObject_Injected(UnityEngine.Playables.PlayableOutputHandle& _unity_self, UnityEngine.Object target) { }
        private UnityEngine.Object GetUserData_Injected(UnityEngine.Playables.PlayableOutputHandle& _unity_self) { }
        private System.Void GetSourcePlayable_Injected(UnityEngine.Playables.PlayableOutputHandle& _unity_self, UnityEngine.Playables.PlayableHandle& ret) { }
        private System.Void SetSourcePlayable_Injected(UnityEngine.Playables.PlayableOutputHandle& _unity_self, UnityEngine.Playables.PlayableHandle& target, System.Int32 port) { }
        private System.Int32 GetSourceOutputPort_Injected(UnityEngine.Playables.PlayableOutputHandle& _unity_self) { }
        private System.Void SetWeight_Injected(UnityEngine.Playables.PlayableOutputHandle& _unity_self, System.Single weight) { }
        private System.Void PushNotification_Injected(UnityEngine.Playables.PlayableOutputHandle& _unity_self, UnityEngine.Playables.PlayableHandle& origin, UnityEngine.Playables.INotification notification, System.Object context) { }
        private System.Void AddNotificationReceiver_Injected(UnityEngine.Playables.PlayableOutputHandle& _unity_self, UnityEngine.Playables.INotificationReceiver receiver) { }

    }

    // TypeToken: 0x2000380
    public struct ScriptPlayable`1, IPlayable, IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;        // 0x0
        private static readonly UnityEngine.Playables.ScriptPlayable<T> m_NullPlayable;        // 0x0

        // Methods
        private UnityEngine.Playables.ScriptPlayable<T> get_Null() { }
        private UnityEngine.Playables.ScriptPlayable<T> Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount) { }
        private UnityEngine.Playables.ScriptPlayable<T> Create(UnityEngine.Playables.PlayableGraph graph, T template, System.Int32 inputCount) { }
        private UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, T template, System.Int32 inputCount) { }
        private System.Object CreateScriptInstance() { }
        private System.Object CloneScriptInstance(UnityEngine.Playables.IPlayableBehaviour source) { }
        private System.Object CloneScriptInstanceFromEngineObject(UnityEngine.Object source) { }
        private System.Object CloneScriptInstanceFromIClonable(System.ICloneable source) { }
        private System.Void .ctor(UnityEngine.Playables.PlayableHandle handle) { }
        private UnityEngine.Playables.PlayableHandle GetHandle() { }
        private T GetBehaviour() { }
        private UnityEngine.Playables.Playable op_Implicit(UnityEngine.Playables.ScriptPlayable<T> playable) { }
        private UnityEngine.Playables.ScriptPlayable<T> op_Explicit(UnityEngine.Playables.Playable playable) { }
        private System.Boolean Equals(UnityEngine.Playables.ScriptPlayable<T> other) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000381
    public class ScriptPlayableBinding
    {
        // Methods
        private UnityEngine.Playables.PlayableBinding Create(System.String name, UnityEngine.Object key, System.Type type) { }
        private UnityEngine.Playables.PlayableOutput CreateScriptOutput(UnityEngine.Playables.PlayableGraph graph, System.String name) { }

    }

    // TypeToken: 0x2000382
    public struct ScriptPlayableOutput, IPlayableOutput
    {
        // Fields
        private UnityEngine.Playables.PlayableOutputHandle m_Handle;        // 0x10

        // Methods
        private UnityEngine.Playables.ScriptPlayableOutput Create(UnityEngine.Playables.PlayableGraph graph, System.String name) { }
        private System.Void .ctor(UnityEngine.Playables.PlayableOutputHandle handle) { }
        private UnityEngine.Playables.ScriptPlayableOutput get_Null() { }
        private UnityEngine.Playables.PlayableOutputHandle GetHandle() { }
        private UnityEngine.Playables.PlayableOutput op_Implicit(UnityEngine.Playables.ScriptPlayableOutput output) { }

    }

}

namespace UnityEngine.PlayerLoop
{

    // TypeToken: 0x2000238
    public struct TimeUpdate
    {
    }

    // TypeToken: 0x200023A
    public struct Initialization
    {
    }

    // TypeToken: 0x2000242
    public struct EarlyUpdate
    {
    }

    // TypeToken: 0x2000264
    public struct FixedUpdate
    {
    }

    // TypeToken: 0x2000272
    public struct PreUpdate
    {
    }

    // TypeToken: 0x200027E
    public struct Update
    {
    }

    // TypeToken: 0x2000284
    public struct PreLateUpdate
    {
    }

    // TypeToken: 0x2000295
    public struct PostLateUpdate
    {
    }

}

namespace UnityEngine.Pool
{

    // TypeToken: 0x20002CC
    public class CollectionPool`2
    {
        // Fields
        private static readonly UnityEngine.Pool.ObjectPool<TCollection> s_Pool;        // 0x0

        // Methods
        private TCollection Get() { }
        private UnityEngine.Pool.PooledObject<TCollection> Get(TCollection& value) { }
        private System.Void Release(TCollection toRelease) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002CE
    public interface IObjectPool`1
    {
        // Methods
        private System.Void Release(T element) { }

    }

    // TypeToken: 0x20002CF
    public class ObjectPool`1, IDisposable, IObjectPool`1
    {
        // Fields
        private readonly System.Collections.Generic.List<T> m_List;        // 0x0
        private readonly System.Func<T> m_CreateFunc;        // 0x0
        private readonly System.Action<T> m_ActionOnGet;        // 0x0
        private readonly System.Action<T> m_ActionOnRelease;        // 0x0
        private readonly System.Action<T> m_ActionOnDestroy;        // 0x0
        private readonly System.Int32 m_MaxSize;        // 0x0
        private System.Boolean m_CollectionCheck;        // 0x0
        private System.Int32 <CountAll>k__BackingField;        // 0x0

        // Methods
        private System.Int32 get_CountAll() { }
        private System.Void set_CountAll(System.Int32 value) { }
        private System.Int32 get_CountInactive() { }
        private System.Void .ctor(System.Func<T> createFunc, System.Action<T> actionOnGet, System.Action<T> actionOnRelease, System.Action<T> actionOnDestroy, System.Boolean collectionCheck, System.Int32 defaultCapacity, System.Int32 maxSize) { }
        private T Get() { }
        private UnityEngine.Pool.PooledObject<T> Get(T& v) { }
        private System.Void Release(T element) { }
        private System.Void Clear() { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x20002D0
    public struct PooledObject`1, IDisposable
    {
        // Fields
        private readonly T m_ToReturn;        // 0x0
        private readonly UnityEngine.Pool.IObjectPool<T> m_Pool;        // 0x0

        // Methods
        private System.Void .ctor(T value, UnityEngine.Pool.IObjectPool<T> pool) { }
        private System.Void System.IDisposable.Dispose() { }

    }

}

namespace UnityEngine.Profiling
{

    // TypeToken: 0x20001D4
    public struct ProfilingHGPass
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Profiling.ProfilingHGPass None;        // 0x0
        public static UnityEngine.Profiling.ProfilingHGPass PreDepth;        // 0x0
        public static UnityEngine.Profiling.ProfilingHGPass GBuffer;        // 0x0
        public static UnityEngine.Profiling.ProfilingHGPass Shadow;        // 0x0
        public static UnityEngine.Profiling.ProfilingHGPass ForwardOpaque;        // 0x0
        public static UnityEngine.Profiling.ProfilingHGPass ForwardTransparent;        // 0x0
        public static UnityEngine.Profiling.ProfilingHGPass Distortion;        // 0x0

    }

    // TypeToken: 0x20001D5
    public class Profiler
    {
        // Methods
        private System.Boolean get_supported() { }
        private System.Boolean get_enabled() { }
        private System.Void set_enabled(System.Boolean value) { }
        private System.Void BeginSample(System.String name) { }
        private System.Void ValidateArguments(System.String name) { }
        private System.Void BeginSampleImpl(System.String name, UnityEngine.Object targetObject) { }
        private System.Void EndSample() { }
        private System.Int64 GetRuntimeMemorySizeLong(UnityEngine.Object o) { }
        private System.Int64 GetMonoHeapSizeLong() { }
        private System.Int64 GetMonoUsedSizeLong() { }
        private System.Int64 GetTotalAllocatedMemoryLong() { }
        private System.Int64 GetTotalReservedMemoryLong() { }
        private System.Void ReleaseMonoSnapShot(System.String filePath, System.Boolean bCompress) { }

    }

    // TypeToken: 0x20001D6
    public class HGSingleFrameProfiler
    {
        // Fields
        public static UnityEngine.Profiling.HGSingleFrameProfiler.FinishFrameCallback finishFrameCallback;        // 0x0

        // Methods
        private System.Void CallFinishFrameCallback(System.Double frameTimeMS, System.Boolean overflow, System.IntPtr frameDataPtr, System.Int32 size) { }

    }

    // TypeToken: 0x20001D8
    public class Recorder
    {
        // Fields
        private static Unity.Profiling.ProfilerRecorderOptions s_RecorderDefaultOptions;        // 0x0
        private static UnityEngine.Profiling.Recorder s_InvalidRecorder;        // 0x0
        private Unity.Profiling.ProfilerRecorder m_RecorderCPU;        // 0x10
        private Unity.Profiling.ProfilerRecorder m_RecorderGPU;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle handle) { }
        private System.Void Finalize() { }
        private System.Boolean get_enabled() { }
        private System.Void set_enabled(System.Boolean value) { }
        private System.Int64 get_elapsedNanoseconds() { }
        private System.Int64 get_gpuElapsedNanoseconds() { }
        private System.Int32 get_sampleBlockCount() { }
        private System.Int32 get_gpuSampleBlockCount() { }
        private System.Void SetEnabled(System.Boolean state) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001D9
    public class Sampler
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10
        private static UnityEngine.Profiling.Sampler s_InvalidSampler;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Boolean get_isValid() { }
        private UnityEngine.Profiling.Recorder GetRecorder() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001DA
    public class CustomSampler : Sampler
    {
        // Fields
        private static UnityEngine.Profiling.CustomSampler s_InvalidCustomSampler;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.IntPtr ptr) { }
        private UnityEngine.Profiling.CustomSampler Create(System.String name, System.Boolean collectGpuData) { }
        private System.Void .cctor() { }

    }

}

namespace UnityEngine.Profiling.Experimental
{

    // TypeToken: 0x20001DB
    public struct DebugScreenCapture
    {
        // Fields
        private Unity.Collections.NativeArray<System.Byte> <rawImageDataReference>k__BackingField;        // 0x10
        private UnityEngine.TextureFormat <imageFormat>k__BackingField;        // 0x20
        private System.Int32 <width>k__BackingField;        // 0x24
        private System.Int32 <height>k__BackingField;        // 0x28

        // Methods
        private System.Void set_rawImageDataReference(Unity.Collections.NativeArray<System.Byte> value) { }
        private System.Void set_imageFormat(UnityEngine.TextureFormat value) { }
        private System.Void set_width(System.Int32 value) { }
        private System.Void set_height(System.Int32 value) { }

    }

}

namespace UnityEngine.Profiling.Memory.Experimental
{

    // TypeToken: 0x20001DC
    public class MetaData
    {
        // Fields
        public System.String content;        // 0x10
        public System.String platform;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001DD
    public class MemoryProfiler
    {
        // Fields
        private static System.Action<System.String,System.Boolean> m_SnapshotFinished;        // 0x0
        private static System.Action<System.String,System.Boolean,UnityEngine.Profiling.Experimental.DebugScreenCapture> m_SaveScreenshotToDisk;        // 0x8
        private static System.Action<UnityEngine.Profiling.Memory.Experimental.MetaData> createMetaData;        // 0x10

        // Methods
        private System.Byte[] PrepareMetadata() { }
        private System.Int32 WriteIntToByteArray(System.Byte[] array, System.Int32 offset, System.Int32 value) { }
        private System.Int32 WriteStringToByteArray(System.Byte[] array, System.Int32 offset, System.String value) { }
        private System.Void FinalizeSnapshot(System.String path, System.Boolean result) { }
        private System.Void SaveScreenshotToDisk(System.String path, System.Boolean result, System.IntPtr pixelsPtr, System.Int32 pixelsCount, UnityEngine.TextureFormat format, System.Int32 width, System.Int32 height) { }

    }

}

namespace UnityEngine.Rendering
{

    // TypeToken: 0x20002E8
    public struct AsyncGPUReadbackRequest
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10
        private System.Int32 m_Version;        // 0x18

        // Methods
        private System.Void WaitForCompletion() { }
        private Unity.Collections.NativeArray<T> GetData(System.Int32 layer) { }
        private System.Boolean get_done() { }
        private System.Boolean get_hasError() { }
        private System.Int32 get_layerCount() { }
        private System.Int32 get_layerDataSize() { }
        private System.Boolean IsDone() { }
        private System.Boolean HasError() { }
        private System.Int32 GetLayerCount() { }
        private System.Int32 GetLayerDataSize() { }
        private System.Void SetScriptingCallback(System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback) { }
        private System.IntPtr GetDataRaw(System.Int32 layer) { }
        private System.Void WaitForCompletion_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest& _unity_self) { }
        private System.Boolean IsDone_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest& _unity_self) { }
        private System.Boolean HasError_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest& _unity_self) { }
        private System.Int32 GetLayerCount_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest& _unity_self) { }
        private System.Int32 GetLayerDataSize_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest& _unity_self) { }
        private System.Void SetScriptingCallback_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest& _unity_self, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback) { }
        private System.IntPtr GetDataRaw_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest& _unity_self, System.Int32 layer) { }

    }

    // TypeToken: 0x20002E9
    public struct AsyncRequestNativeArrayData
    {
        // Fields
        public System.Void* nativeArrayBuffer;        // 0x10
        public System.Int64 lengthInBytes;        // 0x18

        // Methods
        private UnityEngine.Rendering.AsyncRequestNativeArrayData CreateAndCheckAccess(Unity.Collections.NativeArray<T> array) { }

    }

    // TypeToken: 0x20002EA
    public class AsyncGPUReadback
    {
        // Methods
        private System.Void ValidateFormat(UnityEngine.Texture src, UnityEngine.Experimental.Rendering.GraphicsFormat dstformat) { }
        private UnityEngine.Rendering.AsyncGPUReadbackRequest Request(UnityEngine.ComputeBuffer src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback) { }
        private UnityEngine.Rendering.AsyncGPUReadbackRequest Request(UnityEngine.Texture src, System.Int32 mipIndex, UnityEngine.TextureFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback) { }
        private UnityEngine.Rendering.AsyncGPUReadbackRequest Request(UnityEngine.Texture src, System.Int32 mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback) { }
        private UnityEngine.Rendering.AsyncGPUReadbackRequest RequestIntoNativeArray(Unity.Collections.NativeArray<T>& output, UnityEngine.ComputeBuffer src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback) { }
        private UnityEngine.Rendering.AsyncGPUReadbackRequest Request_Internal_ComputeBuffer_1(UnityEngine.ComputeBuffer buffer, UnityEngine.Rendering.AsyncRequestNativeArrayData* data) { }
        private UnityEngine.Rendering.AsyncGPUReadbackRequest Request_Internal_Texture_2(UnityEngine.Texture src, System.Int32 mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, UnityEngine.Rendering.AsyncRequestNativeArrayData* data) { }
        private System.Void Request_Internal_ComputeBuffer_1_Injected(UnityEngine.ComputeBuffer buffer, UnityEngine.Rendering.AsyncRequestNativeArrayData* data, UnityEngine.Rendering.AsyncGPUReadbackRequest& ret) { }
        private System.Void Request_Internal_Texture_2_Injected(UnityEngine.Texture src, System.Int32 mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, UnityEngine.Rendering.AsyncRequestNativeArrayData* data, UnityEngine.Rendering.AsyncGPUReadbackRequest& ret) { }

    }

    // TypeToken: 0x20002EB
    public struct SynchronisationStage
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.SynchronisationStage VertexProcessing;        // 0x0
        public static UnityEngine.Rendering.SynchronisationStage PixelProcessing;        // 0x0

    }

    // TypeToken: 0x20002EC
    public struct IndexFormat
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.IndexFormat UInt16;        // 0x0
        public static UnityEngine.Rendering.IndexFormat UInt32;        // 0x0

    }

    // TypeToken: 0x20002ED
    public struct MeshUpdateFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.MeshUpdateFlags Default;        // 0x0
        public static UnityEngine.Rendering.MeshUpdateFlags DontValidateIndices;        // 0x0
        public static UnityEngine.Rendering.MeshUpdateFlags DontResetBoneBounds;        // 0x0
        public static UnityEngine.Rendering.MeshUpdateFlags DontNotifyMeshUsers;        // 0x0
        public static UnityEngine.Rendering.MeshUpdateFlags DontRecalculateBounds;        // 0x0

    }

    // TypeToken: 0x20002EE
    public struct VertexAttributeFormat
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.VertexAttributeFormat Float32;        // 0x0
        public static UnityEngine.Rendering.VertexAttributeFormat Float16;        // 0x0
        public static UnityEngine.Rendering.VertexAttributeFormat UNorm8;        // 0x0
        public static UnityEngine.Rendering.VertexAttributeFormat SNorm8;        // 0x0
        public static UnityEngine.Rendering.VertexAttributeFormat UNorm16;        // 0x0
        public static UnityEngine.Rendering.VertexAttributeFormat SNorm16;        // 0x0
        public static UnityEngine.Rendering.VertexAttributeFormat UInt8;        // 0x0
        public static UnityEngine.Rendering.VertexAttributeFormat SInt8;        // 0x0
        public static UnityEngine.Rendering.VertexAttributeFormat UInt16;        // 0x0
        public static UnityEngine.Rendering.VertexAttributeFormat SInt16;        // 0x0
        public static UnityEngine.Rendering.VertexAttributeFormat UInt32;        // 0x0
        public static UnityEngine.Rendering.VertexAttributeFormat SInt32;        // 0x0

    }

    // TypeToken: 0x20002EF
    public struct VertexAttribute
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.VertexAttribute Position;        // 0x0
        public static UnityEngine.Rendering.VertexAttribute Normal;        // 0x0
        public static UnityEngine.Rendering.VertexAttribute Tangent;        // 0x0
        public static UnityEngine.Rendering.VertexAttribute Color;        // 0x0
        public static UnityEngine.Rendering.VertexAttribute TexCoord0;        // 0x0
        public static UnityEngine.Rendering.VertexAttribute TexCoord1;        // 0x0
        public static UnityEngine.Rendering.VertexAttribute TexCoord2;        // 0x0
        public static UnityEngine.Rendering.VertexAttribute TexCoord3;        // 0x0
        public static UnityEngine.Rendering.VertexAttribute TexCoord4;        // 0x0
        public static UnityEngine.Rendering.VertexAttribute TexCoord5;        // 0x0
        public static UnityEngine.Rendering.VertexAttribute TexCoord6;        // 0x0
        public static UnityEngine.Rendering.VertexAttribute TexCoord7;        // 0x0
        public static UnityEngine.Rendering.VertexAttribute BlendWeight;        // 0x0
        public static UnityEngine.Rendering.VertexAttribute BlendIndices;        // 0x0

    }

    // TypeToken: 0x20002F0
    public struct OpaqueSortMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.OpaqueSortMode Default;        // 0x0
        public static UnityEngine.Rendering.OpaqueSortMode FrontToBack;        // 0x0
        public static UnityEngine.Rendering.OpaqueSortMode NoDistanceSort;        // 0x0

    }

    // TypeToken: 0x20002F1
    public struct RenderBufferLoadAction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.RenderBufferLoadAction Load;        // 0x0
        public static UnityEngine.Rendering.RenderBufferLoadAction Clear;        // 0x0
        public static UnityEngine.Rendering.RenderBufferLoadAction DontCare;        // 0x0

    }

    // TypeToken: 0x20002F2
    public struct RenderBufferStoreAction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.RenderBufferStoreAction Store;        // 0x0
        public static UnityEngine.Rendering.RenderBufferStoreAction Resolve;        // 0x0
        public static UnityEngine.Rendering.RenderBufferStoreAction StoreAndResolve;        // 0x0
        public static UnityEngine.Rendering.RenderBufferStoreAction DontCare;        // 0x0

    }

    // TypeToken: 0x20002F3
    public struct FastMemoryFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.FastMemoryFlags None;        // 0x0
        public static UnityEngine.Rendering.FastMemoryFlags SpillTop;        // 0x0
        public static UnityEngine.Rendering.FastMemoryFlags SpillBottom;        // 0x0

    }

    // TypeToken: 0x20002F4
    public struct BlendMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.BlendMode Zero;        // 0x0
        public static UnityEngine.Rendering.BlendMode One;        // 0x0
        public static UnityEngine.Rendering.BlendMode DstColor;        // 0x0
        public static UnityEngine.Rendering.BlendMode SrcColor;        // 0x0
        public static UnityEngine.Rendering.BlendMode OneMinusDstColor;        // 0x0
        public static UnityEngine.Rendering.BlendMode SrcAlpha;        // 0x0
        public static UnityEngine.Rendering.BlendMode OneMinusSrcColor;        // 0x0
        public static UnityEngine.Rendering.BlendMode DstAlpha;        // 0x0
        public static UnityEngine.Rendering.BlendMode OneMinusDstAlpha;        // 0x0
        public static UnityEngine.Rendering.BlendMode SrcAlphaSaturate;        // 0x0
        public static UnityEngine.Rendering.BlendMode OneMinusSrcAlpha;        // 0x0

    }

    // TypeToken: 0x20002F5
    public struct CompareFunction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.CompareFunction Disabled;        // 0x0
        public static UnityEngine.Rendering.CompareFunction Never;        // 0x0
        public static UnityEngine.Rendering.CompareFunction Less;        // 0x0
        public static UnityEngine.Rendering.CompareFunction Equal;        // 0x0
        public static UnityEngine.Rendering.CompareFunction LessEqual;        // 0x0
        public static UnityEngine.Rendering.CompareFunction Greater;        // 0x0
        public static UnityEngine.Rendering.CompareFunction NotEqual;        // 0x0
        public static UnityEngine.Rendering.CompareFunction GreaterEqual;        // 0x0
        public static UnityEngine.Rendering.CompareFunction Always;        // 0x0

    }

    // TypeToken: 0x20002F6
    public struct CullMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.CullMode Off;        // 0x0
        public static UnityEngine.Rendering.CullMode Front;        // 0x0
        public static UnityEngine.Rendering.CullMode Back;        // 0x0

    }

    // TypeToken: 0x20002F7
    public struct ColorWriteMask
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.ColorWriteMask Alpha;        // 0x0
        public static UnityEngine.Rendering.ColorWriteMask Blue;        // 0x0
        public static UnityEngine.Rendering.ColorWriteMask Green;        // 0x0
        public static UnityEngine.Rendering.ColorWriteMask Red;        // 0x0
        public static UnityEngine.Rendering.ColorWriteMask All;        // 0x0

    }

    // TypeToken: 0x20002F8
    public struct StencilOp
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.StencilOp Keep;        // 0x0
        public static UnityEngine.Rendering.StencilOp Zero;        // 0x0
        public static UnityEngine.Rendering.StencilOp Replace;        // 0x0
        public static UnityEngine.Rendering.StencilOp IncrementSaturate;        // 0x0
        public static UnityEngine.Rendering.StencilOp DecrementSaturate;        // 0x0
        public static UnityEngine.Rendering.StencilOp Invert;        // 0x0
        public static UnityEngine.Rendering.StencilOp IncrementWrap;        // 0x0
        public static UnityEngine.Rendering.StencilOp DecrementWrap;        // 0x0

    }

    // TypeToken: 0x20002F9
    public struct AmbientMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.AmbientMode Skybox;        // 0x0
        public static UnityEngine.Rendering.AmbientMode Trilight;        // 0x0
        public static UnityEngine.Rendering.AmbientMode Flat;        // 0x0
        public static UnityEngine.Rendering.AmbientMode Custom;        // 0x0

    }

    // TypeToken: 0x20002FA
    public struct DefaultReflectionMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.DefaultReflectionMode Skybox;        // 0x0
        public static UnityEngine.Rendering.DefaultReflectionMode Custom;        // 0x0

    }

    // TypeToken: 0x20002FB
    public struct CameraEvent
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.CameraEvent BeforeDepthTexture;        // 0x0
        public static UnityEngine.Rendering.CameraEvent AfterDepthTexture;        // 0x0
        public static UnityEngine.Rendering.CameraEvent BeforeDepthNormalsTexture;        // 0x0
        public static UnityEngine.Rendering.CameraEvent AfterDepthNormalsTexture;        // 0x0
        public static UnityEngine.Rendering.CameraEvent BeforeGBuffer;        // 0x0
        public static UnityEngine.Rendering.CameraEvent AfterGBuffer;        // 0x0
        public static UnityEngine.Rendering.CameraEvent BeforeLighting;        // 0x0
        public static UnityEngine.Rendering.CameraEvent AfterLighting;        // 0x0
        public static UnityEngine.Rendering.CameraEvent BeforeFinalPass;        // 0x0
        public static UnityEngine.Rendering.CameraEvent AfterFinalPass;        // 0x0
        public static UnityEngine.Rendering.CameraEvent BeforeForwardOpaque;        // 0x0
        public static UnityEngine.Rendering.CameraEvent AfterForwardOpaque;        // 0x0
        public static UnityEngine.Rendering.CameraEvent BeforeImageEffectsOpaque;        // 0x0
        public static UnityEngine.Rendering.CameraEvent AfterImageEffectsOpaque;        // 0x0
        public static UnityEngine.Rendering.CameraEvent BeforeSkybox;        // 0x0
        public static UnityEngine.Rendering.CameraEvent AfterSkybox;        // 0x0
        public static UnityEngine.Rendering.CameraEvent BeforeForwardAlpha;        // 0x0
        public static UnityEngine.Rendering.CameraEvent AfterForwardAlpha;        // 0x0
        public static UnityEngine.Rendering.CameraEvent BeforeImageEffects;        // 0x0
        public static UnityEngine.Rendering.CameraEvent AfterImageEffects;        // 0x0
        public static UnityEngine.Rendering.CameraEvent AfterEverything;        // 0x0
        public static UnityEngine.Rendering.CameraEvent BeforeReflections;        // 0x0
        public static UnityEngine.Rendering.CameraEvent AfterReflections;        // 0x0
        public static UnityEngine.Rendering.CameraEvent BeforeHaloAndLensFlares;        // 0x0
        public static UnityEngine.Rendering.CameraEvent AfterHaloAndLensFlares;        // 0x0

    }

    // TypeToken: 0x20002FC
    public class CameraEventUtils
    {
        // Methods
        private System.Boolean IsValid(UnityEngine.Rendering.CameraEvent value) { }

    }

    // TypeToken: 0x20002FD
    public struct LightEvent
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.LightEvent BeforeShadowMap;        // 0x0
        public static UnityEngine.Rendering.LightEvent AfterShadowMap;        // 0x0
        public static UnityEngine.Rendering.LightEvent BeforeScreenspaceMask;        // 0x0
        public static UnityEngine.Rendering.LightEvent AfterScreenspaceMask;        // 0x0
        public static UnityEngine.Rendering.LightEvent BeforeShadowMapPass;        // 0x0
        public static UnityEngine.Rendering.LightEvent AfterShadowMapPass;        // 0x0

    }

    // TypeToken: 0x20002FE
    public struct ShadowMapPass
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.ShadowMapPass PointlightPositiveX;        // 0x0
        public static UnityEngine.Rendering.ShadowMapPass PointlightNegativeX;        // 0x0
        public static UnityEngine.Rendering.ShadowMapPass PointlightPositiveY;        // 0x0
        public static UnityEngine.Rendering.ShadowMapPass PointlightNegativeY;        // 0x0
        public static UnityEngine.Rendering.ShadowMapPass PointlightPositiveZ;        // 0x0
        public static UnityEngine.Rendering.ShadowMapPass PointlightNegativeZ;        // 0x0
        public static UnityEngine.Rendering.ShadowMapPass DirectionalCascade0;        // 0x0
        public static UnityEngine.Rendering.ShadowMapPass DirectionalCascade1;        // 0x0
        public static UnityEngine.Rendering.ShadowMapPass DirectionalCascade2;        // 0x0
        public static UnityEngine.Rendering.ShadowMapPass DirectionalCascade3;        // 0x0
        public static UnityEngine.Rendering.ShadowMapPass Spotlight;        // 0x0
        public static UnityEngine.Rendering.ShadowMapPass Pointlight;        // 0x0
        public static UnityEngine.Rendering.ShadowMapPass Directional;        // 0x0
        public static UnityEngine.Rendering.ShadowMapPass All;        // 0x0

    }

    // TypeToken: 0x20002FF
    public struct BuiltinRenderTextureType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.BuiltinRenderTextureType PropertyName;        // 0x0
        public static UnityEngine.Rendering.BuiltinRenderTextureType BufferPtr;        // 0x0
        public static UnityEngine.Rendering.BuiltinRenderTextureType RenderTexture;        // 0x0
        public static UnityEngine.Rendering.BuiltinRenderTextureType BindableTexture;        // 0x0
        public static UnityEngine.Rendering.BuiltinRenderTextureType None;        // 0x0
        public static UnityEngine.Rendering.BuiltinRenderTextureType CurrentActive;        // 0x0
        public static UnityEngine.Rendering.BuiltinRenderTextureType CameraTarget;        // 0x0
        public static UnityEngine.Rendering.BuiltinRenderTextureType Depth;        // 0x0
        public static UnityEngine.Rendering.BuiltinRenderTextureType DepthNormals;        // 0x0
        public static UnityEngine.Rendering.BuiltinRenderTextureType ResolvedDepth;        // 0x0
        public static UnityEngine.Rendering.BuiltinRenderTextureType PrepassNormalsSpec;        // 0x0
        public static UnityEngine.Rendering.BuiltinRenderTextureType PrepassLight;        // 0x0
        public static UnityEngine.Rendering.BuiltinRenderTextureType PrepassLightSpec;        // 0x0
        public static UnityEngine.Rendering.BuiltinRenderTextureType GBuffer0;        // 0x0
        public static UnityEngine.Rendering.BuiltinRenderTextureType GBuffer1;        // 0x0
        public static UnityEngine.Rendering.BuiltinRenderTextureType GBuffer2;        // 0x0
        public static UnityEngine.Rendering.BuiltinRenderTextureType GBuffer3;        // 0x0
        public static UnityEngine.Rendering.BuiltinRenderTextureType Reflections;        // 0x0
        public static UnityEngine.Rendering.BuiltinRenderTextureType MotionVectors;        // 0x0
        public static UnityEngine.Rendering.BuiltinRenderTextureType GBuffer4;        // 0x0
        public static UnityEngine.Rendering.BuiltinRenderTextureType GBuffer5;        // 0x0
        public static UnityEngine.Rendering.BuiltinRenderTextureType GBuffer6;        // 0x0
        public static UnityEngine.Rendering.BuiltinRenderTextureType GBuffer7;        // 0x0

    }

    // TypeToken: 0x2000300
    public struct ShadowCastingMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.ShadowCastingMode Off;        // 0x0
        public static UnityEngine.Rendering.ShadowCastingMode On;        // 0x0
        public static UnityEngine.Rendering.ShadowCastingMode TwoSided;        // 0x0
        public static UnityEngine.Rendering.ShadowCastingMode ShadowsOnly;        // 0x0
        public static UnityEngine.Rendering.ShadowCastingMode ShadowsOnlyTwoSided;        // 0x0

    }

    // TypeToken: 0x2000301
    public struct LightShadowResolution
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.LightShadowResolution FromQualitySettings;        // 0x0
        public static UnityEngine.Rendering.LightShadowResolution Low;        // 0x0
        public static UnityEngine.Rendering.LightShadowResolution Medium;        // 0x0
        public static UnityEngine.Rendering.LightShadowResolution High;        // 0x0
        public static UnityEngine.Rendering.LightShadowResolution VeryHigh;        // 0x0

    }

    // TypeToken: 0x2000302
    public struct SubMeshRenderMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.SubMeshRenderMode SubMeshRenderModeDefault;        // 0x0
        public static UnityEngine.Rendering.SubMeshRenderMode SubMeshRenderModeLoop;        // 0x0

    }

    // TypeToken: 0x2000303
    public struct GraphicsDeviceType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.GraphicsDeviceType OpenGL2;        // 0x0
        public static UnityEngine.Rendering.GraphicsDeviceType Direct3D9;        // 0x0
        public static UnityEngine.Rendering.GraphicsDeviceType Direct3D11;        // 0x0
        public static UnityEngine.Rendering.GraphicsDeviceType PlayStation3;        // 0x0
        public static UnityEngine.Rendering.GraphicsDeviceType Null;        // 0x0
        public static UnityEngine.Rendering.GraphicsDeviceType Xbox360;        // 0x0
        public static UnityEngine.Rendering.GraphicsDeviceType OpenGLES2;        // 0x0
        public static UnityEngine.Rendering.GraphicsDeviceType OpenGLES3;        // 0x0
        public static UnityEngine.Rendering.GraphicsDeviceType PlayStationVita;        // 0x0
        public static UnityEngine.Rendering.GraphicsDeviceType PlayStation4;        // 0x0
        public static UnityEngine.Rendering.GraphicsDeviceType XboxOne;        // 0x0
        public static UnityEngine.Rendering.GraphicsDeviceType PlayStationMobile;        // 0x0
        public static UnityEngine.Rendering.GraphicsDeviceType Metal;        // 0x0
        public static UnityEngine.Rendering.GraphicsDeviceType OpenGLCore;        // 0x0
        public static UnityEngine.Rendering.GraphicsDeviceType Direct3D12;        // 0x0
        public static UnityEngine.Rendering.GraphicsDeviceType N3DS;        // 0x0
        public static UnityEngine.Rendering.GraphicsDeviceType Vulkan;        // 0x0
        public static UnityEngine.Rendering.GraphicsDeviceType Switch;        // 0x0
        public static UnityEngine.Rendering.GraphicsDeviceType XboxOneD3D12;        // 0x0
        public static UnityEngine.Rendering.GraphicsDeviceType GameCoreXboxOne;        // 0x0
        public static UnityEngine.Rendering.GraphicsDeviceType GameCoreScarlett;        // 0x0
        public static UnityEngine.Rendering.GraphicsDeviceType GameCoreXboxSeries;        // 0x0
        public static UnityEngine.Rendering.GraphicsDeviceType PlayStation5;        // 0x0
        public static UnityEngine.Rendering.GraphicsDeviceType PlayStation5NGGC;        // 0x0

    }

    // TypeToken: 0x2000304
    public struct GraphicsTier
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.GraphicsTier Tier1;        // 0x0
        public static UnityEngine.Rendering.GraphicsTier Tier2;        // 0x0
        public static UnityEngine.Rendering.GraphicsTier Tier3;        // 0x0

    }

    // TypeToken: 0x2000305
    public struct SubMeshDescriptor
    {
        // Fields
        private UnityEngine.Bounds <bounds>k__BackingField;        // 0x10
        private UnityEngine.MeshTopology <topology>k__BackingField;        // 0x28
        private System.Int32 <indexStart>k__BackingField;        // 0x2C
        private System.Int32 <indexCount>k__BackingField;        // 0x30
        private System.Int32 <baseVertex>k__BackingField;        // 0x34
        private System.Int32 <firstVertex>k__BackingField;        // 0x38
        private System.Int32 <vertexCount>k__BackingField;        // 0x3C

        // Methods
        private UnityEngine.Bounds get_bounds() { }
        private UnityEngine.MeshTopology get_topology() { }
        private System.Int32 get_indexStart() { }
        private System.Int32 get_indexCount() { }
        private System.Int32 get_baseVertex() { }
        private System.Int32 get_firstVertex() { }
        private System.Int32 get_vertexCount() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000306
    public struct VertexAttributeDescriptor, IEquatable`1
    {
        // Fields
        private UnityEngine.Rendering.VertexAttribute <attribute>k__BackingField;        // 0x10
        private UnityEngine.Rendering.VertexAttributeFormat <format>k__BackingField;        // 0x14
        private System.Int32 <dimension>k__BackingField;        // 0x18
        private System.Int32 <stream>k__BackingField;        // 0x1C

        // Methods
        private UnityEngine.Rendering.VertexAttribute get_attribute() { }
        private System.Void set_attribute(UnityEngine.Rendering.VertexAttribute value) { }
        private UnityEngine.Rendering.VertexAttributeFormat get_format() { }
        private System.Void set_format(UnityEngine.Rendering.VertexAttributeFormat value) { }
        private System.Int32 get_dimension() { }
        private System.Void set_dimension(System.Int32 value) { }
        private System.Int32 get_stream() { }
        private System.Void set_stream(System.Int32 value) { }
        private System.Void .ctor(UnityEngine.Rendering.VertexAttribute attribute, UnityEngine.Rendering.VertexAttributeFormat format, System.Int32 dimension, System.Int32 stream) { }
        private System.String ToString() { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(UnityEngine.Rendering.VertexAttributeDescriptor other) { }

    }

    // TypeToken: 0x2000307
    public struct FormatSwizzle
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.FormatSwizzle FormatSwizzleR;        // 0x0
        public static UnityEngine.Rendering.FormatSwizzle FormatSwizzleG;        // 0x0
        public static UnityEngine.Rendering.FormatSwizzle FormatSwizzleB;        // 0x0
        public static UnityEngine.Rendering.FormatSwizzle FormatSwizzleA;        // 0x0
        public static UnityEngine.Rendering.FormatSwizzle FormatSwizzle0;        // 0x0
        public static UnityEngine.Rendering.FormatSwizzle FormatSwizzle1;        // 0x0

    }

    // TypeToken: 0x2000308
    public struct RenderTargetIdentifier, IEquatable`1
    {
        // Fields
        public static System.Int32 AllDepthSlices;        // 0x0
        private UnityEngine.Rendering.BuiltinRenderTextureType m_Type;        // 0x10
        private System.Int32 m_NameID;        // 0x14
        private System.Int32 m_InstanceID;        // 0x18
        private System.IntPtr m_BufferPointer;        // 0x20
        private System.Int32 m_MipLevel;        // 0x28
        private UnityEngine.CubemapFace m_CubeFace;        // 0x2C
        private System.Int32 m_DepthSlice;        // 0x30

        // Methods
        private System.Void .ctor(UnityEngine.Rendering.BuiltinRenderTextureType type) { }
        private System.Void .ctor(System.Int32 nameID) { }
        private System.Void .ctor(UnityEngine.Rendering.RenderTargetIdentifier renderTargetIdentifier, System.Int32 mipLevel, UnityEngine.CubemapFace cubeFace, System.Int32 depthSlice) { }
        private System.Void .ctor(UnityEngine.Texture tex) { }
        private System.Void .ctor(UnityEngine.Texture tex, System.Int32 mipLevel, UnityEngine.CubemapFace cubeFace, System.Int32 depthSlice) { }
        private System.Void .ctor(UnityEngine.RenderBuffer buf, System.Int32 mipLevel, UnityEngine.CubemapFace cubeFace, System.Int32 depthSlice) { }
        private UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Rendering.BuiltinRenderTextureType type) { }
        private UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(System.Int32 nameID) { }
        private UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Texture tex) { }
        private System.String ToString() { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(UnityEngine.Rendering.RenderTargetIdentifier rhs) { }
        private System.Boolean Equals(System.Object obj) { }
        private UnityEngine.Rendering.BuiltinRenderTextureType HGGetType() { }
        private System.IntPtr HGGetBufferPointer() { }
        private System.Int32 HGGetInstanceID() { }

    }

    // TypeToken: 0x2000309
    public struct RenderTargetFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.RenderTargetFlags None;        // 0x0
        public static UnityEngine.Rendering.RenderTargetFlags ReadOnlyDepth;        // 0x0
        public static UnityEngine.Rendering.RenderTargetFlags ReadOnlyStencil;        // 0x0
        public static UnityEngine.Rendering.RenderTargetFlags ReadOnlyDepthStencil;        // 0x0

    }

    // TypeToken: 0x200030A
    public struct RenderTargetBinding
    {
        // Fields
        private UnityEngine.Rendering.RenderTargetIdentifier[] m_ColorRenderTargets;        // 0x10
        private UnityEngine.Rendering.RenderTargetIdentifier m_DepthRenderTarget;        // 0x18
        private UnityEngine.Rendering.RenderBufferLoadAction[] m_ColorLoadActions;        // 0x40
        private UnityEngine.Rendering.RenderBufferStoreAction[] m_ColorStoreActions;        // 0x48
        private UnityEngine.Rendering.RenderBufferLoadAction m_DepthLoadAction;        // 0x50
        private UnityEngine.Rendering.RenderBufferStoreAction m_DepthStoreAction;        // 0x54
        private UnityEngine.Rendering.RenderTargetFlags m_Flags;        // 0x58

        // Methods
        private UnityEngine.Rendering.RenderTargetIdentifier[] get_colorRenderTargets() { }
        private System.Void set_colorRenderTargets(UnityEngine.Rendering.RenderTargetIdentifier[] value) { }
        private UnityEngine.Rendering.RenderTargetIdentifier get_depthRenderTarget() { }
        private System.Void set_depthRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier value) { }
        private UnityEngine.Rendering.RenderBufferLoadAction[] get_colorLoadActions() { }
        private System.Void set_colorLoadActions(UnityEngine.Rendering.RenderBufferLoadAction[] value) { }
        private UnityEngine.Rendering.RenderBufferStoreAction[] get_colorStoreActions() { }
        private System.Void set_colorStoreActions(UnityEngine.Rendering.RenderBufferStoreAction[] value) { }
        private UnityEngine.Rendering.RenderBufferLoadAction get_depthLoadAction() { }
        private System.Void set_depthLoadAction(UnityEngine.Rendering.RenderBufferLoadAction value) { }
        private UnityEngine.Rendering.RenderBufferStoreAction get_depthStoreAction() { }
        private System.Void set_depthStoreAction(UnityEngine.Rendering.RenderBufferStoreAction value) { }
        private UnityEngine.Rendering.RenderTargetFlags get_flags() { }
        private System.Void .ctor(UnityEngine.Rendering.RenderTargetIdentifier[] colorRenderTargets, UnityEngine.Rendering.RenderBufferLoadAction[] colorLoadActions, UnityEngine.Rendering.RenderBufferStoreAction[] colorStoreActions, UnityEngine.Rendering.RenderTargetIdentifier depthRenderTarget, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction) { }

    }

    // TypeToken: 0x200030B
    public struct ReflectionProbeUsage
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.ReflectionProbeUsage Off;        // 0x0
        public static UnityEngine.Rendering.ReflectionProbeUsage BlendProbes;        // 0x0
        public static UnityEngine.Rendering.ReflectionProbeUsage BlendProbesAndSkybox;        // 0x0
        public static UnityEngine.Rendering.ReflectionProbeUsage Simple;        // 0x0

    }

    // TypeToken: 0x200030C
    public struct ReflectionProbeType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.ReflectionProbeType Cube;        // 0x0
        public static UnityEngine.Rendering.ReflectionProbeType Card;        // 0x0

    }

    // TypeToken: 0x200030D
    public struct ReflectionProbeClearFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.ReflectionProbeClearFlags Skybox;        // 0x0
        public static UnityEngine.Rendering.ReflectionProbeClearFlags SolidColor;        // 0x0

    }

    // TypeToken: 0x200030E
    public struct ReflectionProbeOrientedMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.ReflectionProbeOrientedMode None;        // 0x0
        public static UnityEngine.Rendering.ReflectionProbeOrientedMode Center;        // 0x0
        public static UnityEngine.Rendering.ReflectionProbeOrientedMode Axis;        // 0x0

    }

    // TypeToken: 0x200030F
    public struct ReflectionProbeShapeType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.ReflectionProbeShapeType Box;        // 0x0
        public static UnityEngine.Rendering.ReflectionProbeShapeType Sphere;        // 0x0

    }

    // TypeToken: 0x2000310
    public struct ReflectionProbeScopeType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.ReflectionProbeScopeType Local;        // 0x0
        public static UnityEngine.Rendering.ReflectionProbeScopeType Global;        // 0x0

    }

    // TypeToken: 0x2000311
    public struct ReflectionProbeMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.ReflectionProbeMode Baked;        // 0x0
        public static UnityEngine.Rendering.ReflectionProbeMode Realtime;        // 0x0
        public static UnityEngine.Rendering.ReflectionProbeMode Custom;        // 0x0

    }

    // TypeToken: 0x2000312
    public struct ReflectionProbeBlendInfo
    {
        // Fields
        public UnityEngine.ReflectionProbe probe;        // 0x10
        public System.Single weight;        // 0x18

    }

    // TypeToken: 0x2000313
    public struct ReflectionProbeRefreshMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.ReflectionProbeRefreshMode OnAwake;        // 0x0
        public static UnityEngine.Rendering.ReflectionProbeRefreshMode EveryFrame;        // 0x0
        public static UnityEngine.Rendering.ReflectionProbeRefreshMode ViaScripting;        // 0x0

    }

    // TypeToken: 0x2000314
    public struct ReflectionProbeTimeSlicingMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.ReflectionProbeTimeSlicingMode AllFacesAtOnce;        // 0x0
        public static UnityEngine.Rendering.ReflectionProbeTimeSlicingMode IndividualFaces;        // 0x0
        public static UnityEngine.Rendering.ReflectionProbeTimeSlicingMode NoTimeSlicing;        // 0x0

    }

    // TypeToken: 0x2000315
    public struct ShadowSamplingMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.ShadowSamplingMode CompareDepths;        // 0x0
        public static UnityEngine.Rendering.ShadowSamplingMode RawDepth;        // 0x0
        public static UnityEngine.Rendering.ShadowSamplingMode None;        // 0x0

    }

    // TypeToken: 0x2000316
    public struct LightProbeUsage
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.LightProbeUsage Off;        // 0x0
        public static UnityEngine.Rendering.LightProbeUsage BlendProbes;        // 0x0
        public static UnityEngine.Rendering.LightProbeUsage UseProxyVolume;        // 0x0
        public static UnityEngine.Rendering.LightProbeUsage CustomProvided;        // 0x0

    }

    // TypeToken: 0x2000317
    public struct BuiltinShaderDefine
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.BuiltinShaderDefine UNITY_NO_DXT5nm;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine UNITY_NO_RGBM;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine UNITY_USE_NATIVE_HDR;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine UNITY_ENABLE_REFLECTION_BUFFERS;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine UNITY_FRAMEBUFFER_FETCH_AVAILABLE;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine UNITY_ENABLE_NATIVE_SHADOW_LOOKUPS;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine UNITY_METAL_SHADOWS_USE_POINT_FILTERING;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine UNITY_NO_CUBEMAP_ARRAY;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine UNITY_NO_SCREENSPACE_SHADOWS;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine UNITY_USE_DITHER_MASK_FOR_ALPHABLENDED_SHADOWS;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine UNITY_PBS_USE_BRDF1;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine UNITY_PBS_USE_BRDF2;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine UNITY_PBS_USE_BRDF3;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine UNITY_NO_FULL_STANDARD_SHADER;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine UNITY_SPECCUBE_BOX_PROJECTION;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine UNITY_SPECCUBE_BLENDING;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine UNITY_ENABLE_DETAIL_NORMALMAP;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine SHADER_API_MOBILE;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine SHADER_API_DESKTOP;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine UNITY_HARDWARE_TIER1;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine UNITY_HARDWARE_TIER2;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine UNITY_HARDWARE_TIER3;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine UNITY_COLORSPACE_GAMMA;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine UNITY_LIGHT_PROBE_PROXY_VOLUME;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine UNITY_HALF_PRECISION_FRAGMENT_SHADER_REGISTERS;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine UNITY_LIGHTMAP_DLDR_ENCODING;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine UNITY_LIGHTMAP_RGBM_ENCODING;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine UNITY_LIGHTMAP_FULL_HDR;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine UNITY_VIRTUAL_TEXTURING;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine UNITY_PRETRANSFORM_TO_DISPLAY_ORIENTATION;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine UNITY_ASTC_NORMALMAP_ENCODING;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine SHADER_API_GLES30;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine UNITY_UNIFIED_SHADER_PRECISION_MODEL;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine HG_RENDER_PATH_MOBILE;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine HG_RENDER_PATH_DESKTOP;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine HG_RENDER_PATH_FORWARD;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine HG_RENDER_PATH_DEFAULT_DEFERRED;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine HG_RENDER_PATH_ONE_PASS_DEFERRED;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine HG_DEVICE_TIER_1000;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine HG_DEVICE_TIER_2000;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine HG_DEVICE_TIER_3000;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine HG_DEVICE_TIER_4000;        // 0x0
        public static UnityEngine.Rendering.BuiltinShaderDefine HG_DEVICE_TIER_5000;        // 0x0

    }

    // TypeToken: 0x2000318
    public struct TextureDimension
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.TextureDimension Unknown;        // 0x0
        public static UnityEngine.Rendering.TextureDimension None;        // 0x0
        public static UnityEngine.Rendering.TextureDimension Any;        // 0x0
        public static UnityEngine.Rendering.TextureDimension Tex2D;        // 0x0
        public static UnityEngine.Rendering.TextureDimension Tex3D;        // 0x0
        public static UnityEngine.Rendering.TextureDimension Cube;        // 0x0
        public static UnityEngine.Rendering.TextureDimension Tex2DArray;        // 0x0
        public static UnityEngine.Rendering.TextureDimension CubeArray;        // 0x0

    }

    // TypeToken: 0x2000319
    public struct CopyTextureSupport
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.CopyTextureSupport None;        // 0x0
        public static UnityEngine.Rendering.CopyTextureSupport Basic;        // 0x0
        public static UnityEngine.Rendering.CopyTextureSupport Copy3D;        // 0x0
        public static UnityEngine.Rendering.CopyTextureSupport DifferentTypes;        // 0x0
        public static UnityEngine.Rendering.CopyTextureSupport TextureToRT;        // 0x0
        public static UnityEngine.Rendering.CopyTextureSupport RTToTexture;        // 0x0

    }

    // TypeToken: 0x200031A
    public struct ComputeQueueType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.ComputeQueueType Default;        // 0x0
        public static UnityEngine.Rendering.ComputeQueueType Background;        // 0x0
        public static UnityEngine.Rendering.ComputeQueueType Urgent;        // 0x0

    }

    // TypeToken: 0x200031B
    public struct CommandBufferExecutionFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.CommandBufferExecutionFlags None;        // 0x0
        public static UnityEngine.Rendering.CommandBufferExecutionFlags AsyncCompute;        // 0x0

    }

    // TypeToken: 0x200031C
    public struct RTClearFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.RTClearFlags None;        // 0x0
        public static UnityEngine.Rendering.RTClearFlags Color;        // 0x0
        public static UnityEngine.Rendering.RTClearFlags Depth;        // 0x0
        public static UnityEngine.Rendering.RTClearFlags Stencil;        // 0x0
        public static UnityEngine.Rendering.RTClearFlags All;        // 0x0
        public static UnityEngine.Rendering.RTClearFlags DepthStencil;        // 0x0
        public static UnityEngine.Rendering.RTClearFlags ColorDepth;        // 0x0
        public static UnityEngine.Rendering.RTClearFlags ColorStencil;        // 0x0

    }

    // TypeToken: 0x200031D
    public struct RenderTextureSubElement
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.RenderTextureSubElement Color;        // 0x0
        public static UnityEngine.Rendering.RenderTextureSubElement Depth;        // 0x0
        public static UnityEngine.Rendering.RenderTextureSubElement Stencil;        // 0x0
        public static UnityEngine.Rendering.RenderTextureSubElement Default;        // 0x0

    }

    // TypeToken: 0x200031E
    public struct OpenGLESVersion
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.OpenGLESVersion None;        // 0x0
        public static UnityEngine.Rendering.OpenGLESVersion OpenGLES20;        // 0x0
        public static UnityEngine.Rendering.OpenGLESVersion OpenGLES30;        // 0x0
        public static UnityEngine.Rendering.OpenGLESVersion OpenGLES31;        // 0x0
        public static UnityEngine.Rendering.OpenGLESVersion OpenGLES31AEP;        // 0x0
        public static UnityEngine.Rendering.OpenGLESVersion OpenGLES32;        // 0x0

    }

    // TypeToken: 0x200031F
    public struct SynchronisationStageFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.SynchronisationStageFlags VertexProcessing;        // 0x0
        public static UnityEngine.Rendering.SynchronisationStageFlags PixelProcessing;        // 0x0
        public static UnityEngine.Rendering.SynchronisationStageFlags ComputeProcessing;        // 0x0
        public static UnityEngine.Rendering.SynchronisationStageFlags AllGPUOperations;        // 0x0

    }

    // TypeToken: 0x2000320
    public struct GraphicsFenceType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.GraphicsFenceType AsyncQueueSynchronisation;        // 0x0
        public static UnityEngine.Rendering.GraphicsFenceType CPUSynchronisation;        // 0x0

    }

    // TypeToken: 0x2000321
    public struct GraphicsFence
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10
        private System.Int32 m_Version;        // 0x18
        private UnityEngine.Rendering.GraphicsFenceType m_FenceType;        // 0x1C

        // Methods
        private UnityEngine.Rendering.SynchronisationStageFlags TranslateSynchronizationStageToFlags(UnityEngine.Rendering.SynchronisationStage s) { }
        private System.Void InitPostAllocation() { }
        private System.Boolean IsFencePending() { }
        private System.Void Validate() { }
        private System.Int32 GetPlatformNotSupportedVersion() { }
        private System.Int32 GetVersionNumber(System.IntPtr fencePtr) { }

    }

    // TypeToken: 0x2000322
    public class GraphicsSettings
    {
        // Methods
        private System.Boolean get_lightsUseLinearIntensity() { }
        private System.Void set_useScriptableRenderPipelineBatching(System.Boolean value) { }
        private System.Void set_enableSRPBatchInstancing(System.Boolean value) { }
        private System.Boolean HasShaderDefine(UnityEngine.Rendering.GraphicsTier tier, UnityEngine.Rendering.BuiltinShaderDefine defineHash) { }
        private System.Boolean HasShaderDefine(UnityEngine.Rendering.BuiltinShaderDefine defineHash) { }
        private UnityEngine.ScriptableObject get_INTERNAL_currentRenderPipeline() { }
        private UnityEngine.Rendering.RenderPipelineAsset get_currentRenderPipeline() { }
        private UnityEngine.Rendering.RenderPipelineAsset get_renderPipelineAsset() { }
        private System.Void set_renderPipelineAsset(UnityEngine.Rendering.RenderPipelineAsset value) { }
        private UnityEngine.ScriptableObject get_INTERNAL_defaultRenderPipeline() { }
        private System.Void set_INTERNAL_defaultRenderPipeline(UnityEngine.ScriptableObject value) { }
        private UnityEngine.Rendering.RenderPipelineAsset get_defaultRenderPipeline() { }
        private System.Void set_defaultRenderPipeline(UnityEngine.Rendering.RenderPipelineAsset value) { }
        private System.Void RegisterRenderPipelineSettings(UnityEngine.Rendering.RenderPipelineGlobalSettings settings) { }
        private System.Void RegisterRenderPipeline(System.String renderpipelineName, UnityEngine.Object settings) { }
        private System.Void UnregisterRenderPipelineSettings() { }
        private System.Void UnregisterRenderPipeline(System.String renderpipelineName) { }
        private UnityEngine.Rendering.RenderPipelineGlobalSettings GetSettingsForRenderPipeline() { }
        private UnityEngine.Object GetSettingsForRenderPipeline(System.String renderpipelineName) { }
        private System.Void INTERNAL_AddShaderToSRPInstancingWhiteList(System.String shaderName) { }
        private System.Void AddShaderToSRPInstancingWhiteList(System.String shaderName) { }

    }

    // TypeToken: 0x2000323
    public class OnDemandRendering
    {
        // Fields
        private static System.Int32 m_RenderFrameInterval;        // 0x0

        // Methods
        private System.Int32 get_renderFrameInterval() { }
        private System.Void GetRenderFrameInterval(System.Int32& frameInterval) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000324
    public class CommandBuffer, IDisposable
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10

        // Methods
        private System.Void SetInvertCulling(System.Boolean invertCulling) { }
        private System.IntPtr InitBuffer() { }
        private System.IntPtr InitBufferTempJobAlloc() { }
        private System.Void HGSetFragmentShadingRate(System.UInt32 fragmentSizeX, System.UInt32 fragmentSizeY) { }
        private System.Void HGSetTransparentOffscreenBlend(System.Boolean offscreenBlend) { }
        private System.IntPtr CreateGPUFence_Internal(UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage) { }
        private System.Void WaitOnGPUFence_Internal(System.IntPtr fencePtr, UnityEngine.Rendering.SynchronisationStageFlags stage) { }
        private System.Void ReleaseBuffer() { }
        private System.Void SetComputeIntParam(UnityEngine.ComputeShader computeShader, System.Int32 nameID, System.Int32 val) { }
        private System.Void SetComputeVectorParam(UnityEngine.ComputeShader computeShader, System.Int32 nameID, UnityEngine.Vector4 val) { }
        private System.Void SetComputeVectorArrayParam(UnityEngine.ComputeShader computeShader, System.Int32 nameID, UnityEngine.Vector4[] values) { }
        private System.Void SetComputeValueParam(UnityEngine.ComputeShader computeShader, System.Int32 nameID, System.UIntPtr data, System.Int32 byteCount) { }
        private System.Void SetComputeMatrixParam(UnityEngine.ComputeShader computeShader, System.Int32 nameID, UnityEngine.Matrix4x4 val) { }
        private System.Void Internal_SetComputeTextureParam(UnityEngine.ComputeShader computeShader, System.Int32 kernelIndex, System.Int32 nameID, UnityEngine.Rendering.RenderTargetIdentifier& rt, System.Int32 mipLevel, UnityEngine.Rendering.RenderTextureSubElement element, System.Int32 slice) { }
        private System.Void Internal_SetComputeBufferParam(UnityEngine.ComputeShader computeShader, System.Int32 kernelIndex, System.Int32 nameID, UnityEngine.ComputeBuffer buffer, System.Int32 offset, System.Int32 size) { }
        private System.Void Internal_SetComputeBufferIDParam(UnityEngine.ComputeShader computeShader, System.Int32 kernelIndex, System.Int32 nameID, System.UInt32 bufferID, System.Int32 offset, System.Int32 size) { }
        private System.Void Internal_SetComputeConstantComputeBufferParam(UnityEngine.ComputeShader computeShader, System.Int32 nameID, UnityEngine.ComputeBuffer buffer, System.Int32 offset, System.Int32 size) { }
        private System.Void Internal_SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, System.Int32 nameID, System.UInt32 bufferId, System.Int32 offset, System.Int32 size) { }
        private System.Void Internal_DispatchCompute(UnityEngine.ComputeShader computeShader, System.Int32 kernelIndex, System.Int32 threadGroupsX, System.Int32 threadGroupsY, System.Int32 threadGroupsZ) { }
        private System.Void set_name(System.String value) { }
        private System.Int32 get_sizeInBytes() { }
        private System.Void Clear() { }
        private System.Void Internal_DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 submeshIndex, System.Int32 shaderPass, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.RenderStateBlock* overrideState) { }
        private System.Void Internal_DrawRendererList(UnityEngine.Rendering.RendererUtils.RendererList rendererList) { }
        private System.Void AddDrawECSMeshRendererList(System.UInt32 rendererList) { }
        private System.Void AddDrawECSMeshRendererListWithSRPRendererList(System.UInt32 ecsList, UnityEngine.Rendering.RendererUtils.RendererList srpList) { }
        private System.Void AddDrawECSGrassRendererList(System.UInt32 rendererList) { }
        private System.Void AddDrawECSDecalRendererList(System.UInt32 rendererList) { }
        private System.Void AddDrawECSFoliageOccluderRendererList(System.UInt32 rendererList) { }
        private System.Void Add_GPUDriven_DrawRendererList(System.UInt32 rendererList, System.Boolean renderMatchedPrev) { }
        private System.Void Internal_DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 shaderPass, UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount, UnityEngine.MaterialPropertyBlock properties) { }
        private System.Void Internal_DrawProceduralIndexedIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties) { }
        private System.Void Internal_DrawMeshInstancedNativeMatrixArray(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Int32 shaderPass, System.IntPtr matrices, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.RenderStateBlock* overrideState) { }
        private System.Void Internal_HGDrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Int32 shaderPass, System.Int32 count, UnityEngine.MaterialPropertyBlock properties) { }
        private System.Void Internal_DrawMeshInstancedProcedural(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Int32 shaderPass, System.Int32 count, UnityEngine.MaterialPropertyBlock properties) { }
        private System.Void Internal_DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Int32 shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.RenderStateBlock* overrideState) { }
        private System.Void Internal_DrawOcclusionMesh(UnityEngine.RectInt normalizedCamViewport) { }
        private System.Void SetRandomWriteTarget_Buffer(System.Int32 index, UnityEngine.ComputeBuffer uav, System.Boolean preserveCounterValue) { }
        private System.Void SetViewport(UnityEngine.Rect pixelRect) { }
        private System.Void EnableScissorRect(UnityEngine.Rect scissor) { }
        private System.Void DisableScissorRect() { }
        private System.Void CopyTexture_Internal(UnityEngine.Rendering.RenderTargetIdentifier& src, System.Int32 srcElement, System.Int32 srcMip, System.Int32 srcX, System.Int32 srcY, System.Int32 srcWidth, System.Int32 srcHeight, UnityEngine.Rendering.RenderTargetIdentifier& dst, System.Int32 dstElement, System.Int32 dstMip, System.Int32 dstX, System.Int32 dstY, System.Int32 mode) { }
        private System.Void Blit_Texture(UnityEngine.Texture source, UnityEngine.Rendering.RenderTargetIdentifier& dest, UnityEngine.Material mat, System.Int32 pass, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, System.Int32 sourceDepthSlice, System.Int32 destDepthSlice) { }
        private System.Void Blit_Identifier(UnityEngine.Rendering.RenderTargetIdentifier& source, UnityEngine.Rendering.RenderTargetIdentifier& dest, UnityEngine.Material mat, System.Int32 pass, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, System.Int32 sourceDepthSlice, System.Int32 destDepthSlice) { }
        private System.Void EncodeMetalFXSpatialScaler(System.UInt32 spatialScalerHandle, UnityEngine.Rendering.RenderTargetIdentifier colorTexture, UnityEngine.Rendering.RenderTargetIdentifier outputTexture) { }
        private System.Void EncodeMetalFXTemporalScaler(System.UInt32 temporalScalerHandle, System.Boolean resetHistory, UnityEngine.Rendering.RenderTargetIdentifier colorTexture, UnityEngine.Rendering.RenderTargetIdentifier depthTexture, UnityEngine.Rendering.RenderTargetIdentifier motionTexture, UnityEngine.Rendering.RenderTargetIdentifier outputTexture, System.Boolean reversedDepth, System.Single jitterOffsetX, System.Single jitterOffsetY) { }
        private System.Void GetTemporaryRTWithDescriptor(System.Int32 nameID, UnityEngine.RenderTextureDescriptor desc, UnityEngine.FilterMode filter) { }
        private System.Void GetTemporaryRT(System.Int32 nameID, UnityEngine.RenderTextureDescriptor desc, UnityEngine.FilterMode filter) { }
        private System.Void GetTemporaryRT(System.Int32 nameID, UnityEngine.RenderTextureDescriptor desc) { }
        private System.Void ReleaseTemporaryRT(System.Int32 nameID) { }
        private System.Void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color backgroundColor, System.Single depth, System.UInt32 stencil) { }
        private System.Void ClearRenderTarget(System.Boolean clearDepth, System.Boolean clearColor, UnityEngine.Color backgroundColor) { }
        private System.Void SetGlobalFloat(System.Int32 nameID, System.Single value) { }
        private System.Void SetGlobalInt(System.Int32 nameID, System.Int32 value) { }
        private System.Void SetGlobalVector(System.Int32 nameID, UnityEngine.Vector4 value) { }
        private System.Void SetGlobalColor(System.Int32 nameID, UnityEngine.Color value) { }
        private System.Void SetGlobalMatrix(System.Int32 nameID, UnityEngine.Matrix4x4 value) { }
        private System.Void EnableShaderKeyword(System.String keyword) { }
        private System.Void EnableMaterialKeyword(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword keyword) { }
        private System.Void EnableComputeKeyword(UnityEngine.ComputeShader computeShader, UnityEngine.Rendering.LocalKeyword keyword) { }
        private System.Void EnableKeyword(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword& keyword) { }
        private System.Void EnableKeyword(UnityEngine.ComputeShader computeShader, UnityEngine.Rendering.LocalKeyword& keyword) { }
        private System.Void DisableShaderKeyword(System.String keyword) { }
        private System.Void DisableMaterialKeyword(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword keyword) { }
        private System.Void DisableComputeKeyword(UnityEngine.ComputeShader computeShader, UnityEngine.Rendering.LocalKeyword keyword) { }
        private System.Void DisableKeyword(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword& keyword) { }
        private System.Void DisableKeyword(UnityEngine.ComputeShader computeShader, UnityEngine.Rendering.LocalKeyword& keyword) { }
        private System.Void SetGlobalKeyword(UnityEngine.Rendering.GlobalKeyword keyword, System.Boolean value) { }
        private System.Void SetMaterialKeyword(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword keyword, System.Boolean value) { }
        private System.Void SetComputeKeyword(UnityEngine.ComputeShader computeShader, UnityEngine.Rendering.LocalKeyword keyword, System.Boolean value) { }
        private System.Void SetKeyword(UnityEngine.Rendering.GlobalKeyword& keyword, System.Boolean value) { }
        private System.Void SetKeyword(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword& keyword, System.Boolean value) { }
        private System.Void SetKeyword(UnityEngine.ComputeShader computeShader, UnityEngine.Rendering.LocalKeyword& keyword, System.Boolean value) { }
        private System.Void SetGlobalDepthBias(System.Single bias, System.Single slopeBias) { }
        private System.Void SetExecutionFlags(UnityEngine.Rendering.CommandBufferExecutionFlags flags) { }
        private System.Boolean ValidateAgainstExecutionFlags(UnityEngine.Rendering.CommandBufferExecutionFlags requiredFlags, UnityEngine.Rendering.CommandBufferExecutionFlags invalidFlags) { }
        private System.Void SetGlobalVectorArray(System.Int32 nameID, UnityEngine.Vector4[] values) { }
        private System.Void SetGlobalTexture_Impl(System.Int32 nameID, UnityEngine.Rendering.RenderTargetIdentifier& rt, UnityEngine.Rendering.RenderTextureSubElement element) { }
        private System.Void SetGlobalBufferInternal(System.Int32 nameID, UnityEngine.ComputeBuffer value) { }
        private System.Void SetGlobalBufferIDInternal(System.Int32 nameID, System.UInt32 bufferID) { }
        private System.Void BeginSample(System.String name) { }
        private System.Void EndSample(System.String name) { }
        private System.Void BeginSample(UnityEngine.Profiling.CustomSampler sampler) { }
        private System.Void EndSample(UnityEngine.Profiling.CustomSampler sampler) { }
        private System.Void BeginSample_CustomSampler(UnityEngine.Profiling.CustomSampler sampler) { }
        private System.Void EndSample_CustomSampler(UnityEngine.Profiling.CustomSampler sampler) { }
        private System.Void SetGlobalConstantBufferInternal(UnityEngine.ComputeBuffer buffer, System.Int32 nameID, System.Int32 offset, System.Int32 size) { }
        private System.Void SetGlobalConstantBufferInternal0(System.UInt32 bufferId, System.Int32 nameID, System.Int32 offset, System.Int32 size) { }
        private System.Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt) { }
        private System.Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction) { }
        private System.Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction) { }
        private System.Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, System.Int32 mipLevel) { }
        private System.Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, System.Int32 mipLevel, UnityEngine.CubemapFace cubemapFace, System.Int32 depthSlice) { }
        private System.Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, System.Int32 mipLevel, UnityEngine.CubemapFace cubemapFace, System.Int32 depthSlice) { }
        private System.Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction) { }
        private System.Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth, System.Int32 mipLevel, UnityEngine.CubemapFace cubemapFace, System.Int32 depthSlice) { }
        private System.Void SetRenderTarget(UnityEngine.Rendering.RenderTargetBinding binding) { }
        private System.Void SetRenderTargetSingle_Internal(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction) { }
        private System.Void SetRenderTargetColorDepth_Internal(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.RenderTargetFlags flags) { }
        private System.Void SetRenderTargetMulti_Internal(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction[] colorLoadActions, UnityEngine.Rendering.RenderBufferStoreAction[] colorStoreActions, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.RenderTargetFlags flags) { }
        private System.Void SetRenderTargetMultiSubtarget(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction[] colorLoadActions, UnityEngine.Rendering.RenderBufferStoreAction[] colorStoreActions, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, System.Int32 mipLevel, UnityEngine.CubemapFace cubemapFace, System.Int32 depthSlice) { }
        private System.Void SetBufferData(UnityEngine.ComputeBuffer buffer, System.Array data) { }
        private System.Void InternalSetComputeBufferData(UnityEngine.ComputeBuffer buffer, System.Array data, System.Int32 managedBufferStartIndex, System.Int32 graphicsBufferStartIndex, System.Int32 count, System.Int32 elemSize) { }
        private System.Void CopyBufferToImageImpl(UnityEngine.ComputeBuffer source, System.Int32 bufferOffset, UnityEngine.Texture dest, System.Int32 texOffsetX, System.Int32 texOffsetY, System.Int32 texOffsetZ, System.Int32 texExtentX, System.Int32 texExtentY, System.Int32 texExtentZ, System.Int32 mipLevel, System.Int32 layer) { }
        private System.Void SetProfilingHGPassImpl(System.Int32 pass) { }
        private System.Void SetProfilingHGPass(UnityEngine.Profiling.ProfilingHGPass pass) { }
        private System.Void RenderUIOverlayImpl(UnityEngine.Camera camera) { }
        private System.Void HGDrawUIRendererListImpl(System.UInt32 listHandle) { }
        private System.IntPtr GetNativePtr() { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void .ctor() { }
        private System.Void Release() { }
        private System.Void InitWithTempJobAlloc() { }
        private System.Void ReleaseInternalPtr() { }
        private UnityEngine.Rendering.GraphicsFence CreateAsyncGraphicsFence() { }
        private UnityEngine.Rendering.GraphicsFence CreateGraphicsFence(UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage) { }
        private System.Void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence fence) { }
        private System.Void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence fence, UnityEngine.Rendering.SynchronisationStage stage) { }
        private System.Void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence fence, UnityEngine.Rendering.SynchronisationStageFlags stage) { }
        private System.Void SetComputeVectorParam(UnityEngine.ComputeShader computeShader, System.String name, UnityEngine.Vector4 val) { }
        private System.Void SetComputeValueParam(UnityEngine.ComputeShader computeShader, System.Int32 nameID, Unity.Collections.NativeArray<T> data) { }
        private System.Void SetComputeMatrixParam(UnityEngine.ComputeShader computeShader, System.String name, UnityEngine.Matrix4x4 val) { }
        private System.Void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, System.Int32 kernelIndex, System.String name, UnityEngine.Rendering.RenderTargetIdentifier rt) { }
        private System.Void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, System.Int32 kernelIndex, System.Int32 nameID, UnityEngine.Rendering.RenderTargetIdentifier rt) { }
        private System.Void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, System.Int32 kernelIndex, System.String name, UnityEngine.Rendering.RenderTargetIdentifier rt, System.Int32 mipLevel) { }
        private System.Void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, System.Int32 kernelIndex, System.Int32 nameID, UnityEngine.Rendering.RenderTargetIdentifier rt, System.Int32 mipLevel) { }
        private System.Void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, System.Int32 kernelIndex, System.String name, UnityEngine.Rendering.RenderTargetIdentifier rt, System.Int32 mipLevel, UnityEngine.Rendering.RenderTextureSubElement element) { }
        private System.Void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, System.Int32 kernelIndex, System.Int32 nameID, UnityEngine.Rendering.RenderTargetIdentifier rt, System.Int32 mipLevel, UnityEngine.Rendering.RenderTextureSubElement element) { }
        private System.Void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, System.Int32 kernelIndex, System.Int32 nameID, UnityEngine.ComputeBuffer buffer, System.Int32 offset, System.Int32 size) { }
        private System.Void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, System.Int32 kernelIndex, System.String name, UnityEngine.ComputeBuffer buffer, System.Int32 offset, System.Int32 size) { }
        private System.Void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, System.Int32 kernelIndex, System.Int32 nameID, System.UInt32 bufferID, System.Int32 offset, System.Int32 size) { }
        private System.Void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, System.Int32 nameID, UnityEngine.ComputeBuffer buffer, System.Int32 offset, System.Int32 size) { }
        private System.Void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, System.Int32 nameID, System.UInt32 bufferId, System.Int32 offset, System.Int32 size) { }
        private System.Void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, System.String name, System.UInt32 bufferId, System.Int32 offset, System.Int32 size) { }
        private System.Void SetGlobalConstantBuffer(System.UInt32 bufferId, System.Int32 nameID, System.Int32 offset, System.Int32 size) { }
        private System.Void SetGlobalConstantBuffer(System.UInt32 bufferId, System.String name, System.Int32 offset, System.Int32 size) { }
        private System.Void DispatchCompute(UnityEngine.ComputeShader computeShader, System.Int32 kernelIndex, System.Int32 threadGroupsX, System.Int32 threadGroupsY, System.Int32 threadGroupsZ) { }
        private System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 submeshIndex, System.Int32 shaderPass, UnityEngine.MaterialPropertyBlock properties, System.Nullable<UnityEngine.Rendering.RenderStateBlock> overrideState) { }
        private System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 submeshIndex, System.Int32 shaderPass, UnityEngine.MaterialPropertyBlock properties) { }
        private System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 submeshIndex, System.Int32 shaderPass) { }
        private System.Void DrawRendererList(UnityEngine.Rendering.RendererUtils.RendererList rendererList) { }
        private System.Void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 shaderPass, UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount, UnityEngine.MaterialPropertyBlock properties) { }
        private System.Void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties) { }
        private System.Void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset) { }
        private System.Void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs) { }
        private System.Void HGDrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Int32 shaderPass, System.Int32 count, UnityEngine.MaterialPropertyBlock properties) { }
        private System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Int32 shaderPass, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> matrices, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, System.Nullable<UnityEngine.Rendering.RenderStateBlock> overrideState) { }
        private System.Void DrawMeshInstancedProcedural(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Int32 shaderPass, System.Int32 count, UnityEngine.MaterialPropertyBlock properties) { }
        private System.Void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Int32 shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties, System.Nullable<UnityEngine.Rendering.RenderStateBlock> overrideState) { }
        private System.Void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Int32 shaderPass, UnityEngine.ComputeBuffer bufferWithArgs) { }
        private System.Void DrawOcclusionMesh(UnityEngine.RectInt normalizedCamViewport) { }
        private System.Void SetRandomWriteTarget(System.Int32 index, UnityEngine.ComputeBuffer buffer, System.Boolean preserveCounterValue) { }
        private System.Void SetRandomWriteTarget(System.Int32 index, UnityEngine.ComputeBuffer buffer) { }
        private System.Void CopyTexture(UnityEngine.Rendering.RenderTargetIdentifier src, UnityEngine.Rendering.RenderTargetIdentifier dst) { }
        private System.Void CopyTexture(UnityEngine.Rendering.RenderTargetIdentifier src, System.Int32 srcElement, UnityEngine.Rendering.RenderTargetIdentifier dst, System.Int32 dstElement) { }
        private System.Void CopyTexture(UnityEngine.Rendering.RenderTargetIdentifier src, System.Int32 srcElement, System.Int32 srcMip, UnityEngine.Rendering.RenderTargetIdentifier dst, System.Int32 dstElement, System.Int32 dstMip) { }
        private System.Void CopyTexture(UnityEngine.Rendering.RenderTargetIdentifier src, System.Int32 srcElement, System.Int32 srcMip, System.Int32 srcX, System.Int32 srcY, System.Int32 srcWidth, System.Int32 srcHeight, UnityEngine.Rendering.RenderTargetIdentifier dst, System.Int32 dstElement, System.Int32 dstMip, System.Int32 dstX, System.Int32 dstY) { }
        private System.Void Blit(UnityEngine.Texture source, UnityEngine.Rendering.RenderTargetIdentifier dest) { }
        private System.Void Blit(UnityEngine.Texture source, UnityEngine.Rendering.RenderTargetIdentifier dest, UnityEngine.Material mat, System.Int32 pass) { }
        private System.Void Blit(UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier dest, System.Int32 sourceDepthSlice, System.Int32 destDepthSlice) { }
        private System.Void SetGlobalVectorArray(System.String propertyName, UnityEngine.Vector4[] values) { }
        private System.Void SetGlobalTexture(System.String name, UnityEngine.Rendering.RenderTargetIdentifier value) { }
        private System.Void SetGlobalTexture(System.Int32 nameID, UnityEngine.Rendering.RenderTargetIdentifier value) { }
        private System.Void SetGlobalTexture(System.Int32 nameID, UnityEngine.Rendering.RenderTargetIdentifier value, UnityEngine.Rendering.RenderTextureSubElement element) { }
        private System.Void SetGlobalBuffer(System.Int32 nameID, UnityEngine.ComputeBuffer value) { }
        private System.Void SetGlobalBuffer(System.Int32 nameID, System.UInt32 bufferID) { }
        private System.Void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, System.Int32 nameID, System.Int32 offset, System.Int32 size) { }
        private System.Void CopyBufferToImage(UnityEngine.ComputeBuffer source, System.Int32 offset, UnityEngine.Texture dest, System.Int32 texOffsetX, System.Int32 texOffsetY, System.Int32 texOffsetZ, System.Int32 texExtentX, System.Int32 texExtentY, System.Int32 texExtentZ, System.Int32 mipLevel, System.Int32 layer) { }
        private System.Void RenderUIOverlay(UnityEngine.Camera camera) { }
        private System.Void HGDrawUIRendererList(System.UInt32 listHandle) { }
        private System.Void SetComputeVectorParam_Injected(UnityEngine.ComputeShader computeShader, System.Int32 nameID, UnityEngine.Vector4& val) { }
        private System.Void SetComputeMatrixParam_Injected(UnityEngine.ComputeShader computeShader, System.Int32 nameID, UnityEngine.Matrix4x4& val) { }
        private System.Void Internal_DrawMesh_Injected(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4& matrix, UnityEngine.Material material, System.Int32 submeshIndex, System.Int32 shaderPass, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.RenderStateBlock* overrideState) { }
        private System.Void Internal_DrawRendererList_Injected(UnityEngine.Rendering.RendererUtils.RendererList& rendererList) { }
        private System.Void AddDrawECSMeshRendererListWithSRPRendererList_Injected(System.UInt32 ecsList, UnityEngine.Rendering.RendererUtils.RendererList& srpList) { }
        private System.Void Internal_DrawProcedural_Injected(UnityEngine.Matrix4x4& matrix, UnityEngine.Material material, System.Int32 shaderPass, UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount, UnityEngine.MaterialPropertyBlock properties) { }
        private System.Void Internal_DrawProceduralIndexedIndirect_Injected(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4& matrix, UnityEngine.Material material, System.Int32 shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties) { }
        private System.Void Internal_DrawOcclusionMesh_Injected(UnityEngine.RectInt& normalizedCamViewport) { }
        private System.Void SetViewport_Injected(UnityEngine.Rect& pixelRect) { }
        private System.Void EnableScissorRect_Injected(UnityEngine.Rect& scissor) { }
        private System.Void Blit_Texture_Injected(UnityEngine.Texture source, UnityEngine.Rendering.RenderTargetIdentifier& dest, UnityEngine.Material mat, System.Int32 pass, UnityEngine.Vector2& scale, UnityEngine.Vector2& offset, System.Int32 sourceDepthSlice, System.Int32 destDepthSlice) { }
        private System.Void Blit_Identifier_Injected(UnityEngine.Rendering.RenderTargetIdentifier& source, UnityEngine.Rendering.RenderTargetIdentifier& dest, UnityEngine.Material mat, System.Int32 pass, UnityEngine.Vector2& scale, UnityEngine.Vector2& offset, System.Int32 sourceDepthSlice, System.Int32 destDepthSlice) { }
        private System.Void EncodeMetalFXSpatialScaler_Injected(System.UInt32 spatialScalerHandle, UnityEngine.Rendering.RenderTargetIdentifier& colorTexture, UnityEngine.Rendering.RenderTargetIdentifier& outputTexture) { }
        private System.Void EncodeMetalFXTemporalScaler_Injected(System.UInt32 temporalScalerHandle, System.Boolean resetHistory, UnityEngine.Rendering.RenderTargetIdentifier& colorTexture, UnityEngine.Rendering.RenderTargetIdentifier& depthTexture, UnityEngine.Rendering.RenderTargetIdentifier& motionTexture, UnityEngine.Rendering.RenderTargetIdentifier& outputTexture, System.Boolean reversedDepth, System.Single jitterOffsetX, System.Single jitterOffsetY) { }
        private System.Void GetTemporaryRTWithDescriptor_Injected(System.Int32 nameID, UnityEngine.RenderTextureDescriptor& desc, UnityEngine.FilterMode filter) { }
        private System.Void ClearRenderTarget_Injected(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color& backgroundColor, System.Single depth, System.UInt32 stencil) { }
        private System.Void SetGlobalVector_Injected(System.Int32 nameID, UnityEngine.Vector4& value) { }
        private System.Void SetGlobalColor_Injected(System.Int32 nameID, UnityEngine.Color& value) { }
        private System.Void SetGlobalMatrix_Injected(System.Int32 nameID, UnityEngine.Matrix4x4& value) { }
        private System.Void EnableMaterialKeyword_Injected(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword& keyword) { }
        private System.Void EnableComputeKeyword_Injected(UnityEngine.ComputeShader computeShader, UnityEngine.Rendering.LocalKeyword& keyword) { }
        private System.Void DisableMaterialKeyword_Injected(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword& keyword) { }
        private System.Void DisableComputeKeyword_Injected(UnityEngine.ComputeShader computeShader, UnityEngine.Rendering.LocalKeyword& keyword) { }
        private System.Void SetGlobalKeyword_Injected(UnityEngine.Rendering.GlobalKeyword& keyword, System.Boolean value) { }
        private System.Void SetMaterialKeyword_Injected(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword& keyword, System.Boolean value) { }
        private System.Void SetComputeKeyword_Injected(UnityEngine.ComputeShader computeShader, UnityEngine.Rendering.LocalKeyword& keyword, System.Boolean value) { }
        private System.Void SetRenderTargetSingle_Internal_Injected(UnityEngine.Rendering.RenderTargetIdentifier& rt, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction) { }
        private System.Void SetRenderTargetColorDepth_Internal_Injected(UnityEngine.Rendering.RenderTargetIdentifier& color, UnityEngine.Rendering.RenderTargetIdentifier& depth, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.RenderTargetFlags flags) { }
        private System.Void SetRenderTargetMulti_Internal_Injected(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier& depth, UnityEngine.Rendering.RenderBufferLoadAction[] colorLoadActions, UnityEngine.Rendering.RenderBufferStoreAction[] colorStoreActions, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.RenderTargetFlags flags) { }
        private System.Void SetRenderTargetMultiSubtarget_Injected(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier& depth, UnityEngine.Rendering.RenderBufferLoadAction[] colorLoadActions, UnityEngine.Rendering.RenderBufferStoreAction[] colorStoreActions, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, System.Int32 mipLevel, UnityEngine.CubemapFace cubemapFace, System.Int32 depthSlice) { }

    }

    // TypeToken: 0x2000325
    public class CommandBufferExtensions
    {
        // Methods
        private System.Void Internal_SwitchIntoFastMemory(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier& rt, UnityEngine.Rendering.FastMemoryFlags fastMemoryFlags, System.Single residency, System.Boolean copyContents) { }
        private System.Void Internal_SwitchOutOfFastMemory(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier& rt, System.Boolean copyContents) { }
        private System.Void SwitchIntoFastMemory(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier rid, UnityEngine.Rendering.FastMemoryFlags fastMemoryFlags, System.Single residency, System.Boolean copyContents) { }
        private System.Void SwitchOutOfFastMemory(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier rid, System.Boolean copyContents) { }

    }

    // TypeToken: 0x2000326
    public class SplashScreen
    {
        // Methods
        private System.Boolean get_isFinished() { }

    }

    // TypeToken: 0x2000327
    public struct SphericalHarmonicsL2, IEquatable`1
    {
        // Fields
        private System.Single shr0;        // 0x10
        private System.Single shr1;        // 0x14
        private System.Single shr2;        // 0x18
        private System.Single shr3;        // 0x1C
        private System.Single shr4;        // 0x20
        private System.Single shr5;        // 0x24
        private System.Single shr6;        // 0x28
        private System.Single shr7;        // 0x2C
        private System.Single shr8;        // 0x30
        private System.Single shg0;        // 0x34
        private System.Single shg1;        // 0x38
        private System.Single shg2;        // 0x3C
        private System.Single shg3;        // 0x40
        private System.Single shg4;        // 0x44
        private System.Single shg5;        // 0x48
        private System.Single shg6;        // 0x4C
        private System.Single shg7;        // 0x50
        private System.Single shg8;        // 0x54
        private System.Single shb0;        // 0x58
        private System.Single shb1;        // 0x5C
        private System.Single shb2;        // 0x60
        private System.Single shb3;        // 0x64
        private System.Single shb4;        // 0x68
        private System.Single shb5;        // 0x6C
        private System.Single shb6;        // 0x70
        private System.Single shb7;        // 0x74
        private System.Single shb8;        // 0x78

        // Methods
        private System.Single get_Item(System.Int32 rgb, System.Int32 coefficient) { }
        private System.Void set_Item(System.Int32 rgb, System.Int32 coefficient, System.Single value) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(UnityEngine.Rendering.SphericalHarmonicsL2 other) { }
        private UnityEngine.Rendering.SphericalHarmonicsL2 op_Multiply(UnityEngine.Rendering.SphericalHarmonicsL2 lhs, System.Single rhs) { }
        private UnityEngine.Rendering.SphericalHarmonicsL2 op_Addition(UnityEngine.Rendering.SphericalHarmonicsL2 lhs, UnityEngine.Rendering.SphericalHarmonicsL2 rhs) { }
        private System.Boolean op_Equality(UnityEngine.Rendering.SphericalHarmonicsL2 lhs, UnityEngine.Rendering.SphericalHarmonicsL2 rhs) { }

    }

    // TypeToken: 0x2000328
    public struct BatchVisibility
    {
        // Fields
        public readonly System.Int32 offset;        // 0x10
        public readonly System.Int32 instancesCount;        // 0x14
        public System.Int32 visibleCount;        // 0x18

    }

    // TypeToken: 0x2000329
    public struct BatchCullingContext
    {
        // Fields
        public readonly Unity.Collections.NativeArray<UnityEngine.Plane> cullingPlanes;        // 0x10
        public Unity.Collections.NativeArray<UnityEngine.Rendering.BatchVisibility> batchVisibility;        // 0x20
        public Unity.Collections.NativeArray<System.Int32> visibleIndices;        // 0x30
        public Unity.Collections.NativeArray<System.Int32> visibleIndicesY;        // 0x40
        public readonly UnityEngine.Rendering.LODParameters lodParameters;        // 0x50
        public readonly UnityEngine.Matrix4x4 cullingMatrix;        // 0x6C
        public readonly System.Single nearPlane;        // 0xAC

        // Methods
        private System.Void .ctor(Unity.Collections.NativeArray<UnityEngine.Plane> inCullingPlanes, Unity.Collections.NativeArray<UnityEngine.Rendering.BatchVisibility> inOutBatchVisibility, Unity.Collections.NativeArray<System.Int32> outVisibleIndices, Unity.Collections.NativeArray<System.Int32> outVisibleIndicesY, UnityEngine.Rendering.LODParameters inLodParameters, UnityEngine.Matrix4x4 inCullingMatrix, System.Single inNearPlane) { }

    }

    // TypeToken: 0x200032A
    public struct BatchRendererCullingOutput
    {
        // Fields
        public Unity.Jobs.JobHandle cullingJobsFence;        // 0x10
        public UnityEngine.Matrix4x4 cullingMatrix;        // 0x20
        public UnityEngine.Plane* cullingPlanes;        // 0x60
        public UnityEngine.Rendering.BatchVisibility* batchVisibility;        // 0x68
        public System.Int32* visibleIndices;        // 0x70
        public System.Int32* visibleIndicesY;        // 0x78
        public System.Int32 cullingPlanesCount;        // 0x80
        public System.Int32 batchVisibilityCount;        // 0x84
        public System.Int32 visibleIndicesCount;        // 0x88
        public System.Single nearPlane;        // 0x8C

    }

    // TypeToken: 0x200032B
    public class BatchRendererGroup
    {
        // Fields
        private System.IntPtr m_GroupHandle;        // 0x10
        private UnityEngine.Rendering.BatchRendererGroup.OnPerformCulling m_PerformCulling;        // 0x18

        // Methods
        private System.Void InvokeOnPerformCulling(UnityEngine.Rendering.BatchRendererGroup group, UnityEngine.Rendering.BatchRendererCullingOutput& context, UnityEngine.Rendering.LODParameters& lodParameters) { }

    }

    // TypeToken: 0x200032D
    public struct AttachmentDescriptor, IEquatable`1
    {
        // Fields
        private UnityEngine.Rendering.RenderBufferLoadAction m_LoadAction;        // 0x10
        private UnityEngine.Rendering.RenderBufferStoreAction m_StoreAction;        // 0x14
        private UnityEngine.Experimental.Rendering.GraphicsFormat m_Format;        // 0x18
        private UnityEngine.Rendering.RenderTargetIdentifier m_LoadStoreTarget;        // 0x20
        private UnityEngine.Rendering.RenderTargetIdentifier m_ResolveTarget;        // 0x48
        private UnityEngine.Color m_ClearColor;        // 0x70
        private System.Single m_ClearDepth;        // 0x80
        private System.UInt32 m_ClearStencil;        // 0x84

        // Methods
        private System.Void set_loadAction(UnityEngine.Rendering.RenderBufferLoadAction value) { }
        private System.Void set_storeAction(UnityEngine.Rendering.RenderBufferStoreAction value) { }
        private System.Void set_graphicsFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value) { }
        private System.Void ConfigureTarget(UnityEngine.Rendering.RenderTargetIdentifier target, System.Boolean loadExistingContents, System.Boolean storeResults) { }
        private System.Void ConfigureClear(UnityEngine.Color clearColor, System.Single clearDepth, System.UInt32 clearStencil) { }
        private System.Boolean Equals(UnityEngine.Rendering.AttachmentDescriptor other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200032E
    public struct BlendState, IEquatable`1
    {
        // Fields
        private UnityEngine.Rendering.RenderTargetBlendState m_BlendState0;        // 0x10
        private UnityEngine.Rendering.RenderTargetBlendState m_BlendState1;        // 0x18
        private UnityEngine.Rendering.RenderTargetBlendState m_BlendState2;        // 0x20
        private UnityEngine.Rendering.RenderTargetBlendState m_BlendState3;        // 0x28
        private UnityEngine.Rendering.RenderTargetBlendState m_BlendState4;        // 0x30
        private UnityEngine.Rendering.RenderTargetBlendState m_BlendState5;        // 0x38
        private UnityEngine.Rendering.RenderTargetBlendState m_BlendState6;        // 0x40
        private UnityEngine.Rendering.RenderTargetBlendState m_BlendState7;        // 0x48
        private System.Byte m_SeparateMRTBlendStates;        // 0x50
        private System.Byte m_AlphaToMask;        // 0x51
        private System.Int16 m_Padding;        // 0x52

        // Methods
        private System.Boolean Equals(UnityEngine.Rendering.BlendState other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200032F
    public struct CoreCameraValues, IEquatable`1
    {
        // Fields
        private System.Int32 filterMode;        // 0x10
        private System.UInt32 cullingMask;        // 0x14
        private System.Int32 instanceID;        // 0x18
        private System.Int32 uiInstanceID;        // 0x1C

        // Methods
        private System.Boolean Equals(UnityEngine.Rendering.CoreCameraValues other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000330
    public struct CameraProperties, IEquatable`1
    {
        // Fields
        private UnityEngine.Rect screenRect;        // 0x10
        private UnityEngine.Vector3 viewDir;        // 0x20
        private System.Single projectionNear;        // 0x2C
        private System.Single projectionFar;        // 0x30
        private System.Single cameraNear;        // 0x34
        private System.Single cameraFar;        // 0x38
        private System.Single cameraAspect;        // 0x3C
        private UnityEngine.Matrix4x4 cameraToWorld;        // 0x40
        private UnityEngine.Matrix4x4 actualWorldToClip;        // 0x80
        private UnityEngine.Matrix4x4 cameraClipToWorld;        // 0xC0
        private UnityEngine.Matrix4x4 cameraWorldToClip;        // 0x100
        private UnityEngine.Matrix4x4 implicitProjection;        // 0x140
        private UnityEngine.Matrix4x4 stereoWorldToClipLeft;        // 0x180
        private UnityEngine.Matrix4x4 stereoWorldToClipRight;        // 0x1C0
        private UnityEngine.Matrix4x4 worldToCamera;        // 0x200
        private UnityEngine.Vector3 up;        // 0x240
        private UnityEngine.Vector3 right;        // 0x24C
        private UnityEngine.Vector3 transformDirection;        // 0x258
        private UnityEngine.Vector3 cameraEuler;        // 0x264
        private UnityEngine.Vector3 velocity;        // 0x270
        private System.Single farPlaneWorldSpaceLength;        // 0x27C
        private System.UInt32 rendererCount;        // 0x280
        private UnityEngine.Rendering.CameraProperties.<m_ShadowCullPlanes>e__FixedBuffer m_ShadowCullPlanes;        // 0x284
        private UnityEngine.Rendering.CameraProperties.<m_CameraCullPlanes>e__FixedBuffer m_CameraCullPlanes;        // 0x2E4
        private System.Single baseFarDistance;        // 0x344
        private UnityEngine.Vector3 shadowCullCenter;        // 0x348
        private UnityEngine.Rendering.CameraProperties.<layerCullDistances>e__FixedBuffer layerCullDistances;        // 0x354
        private System.Int32 layerCullSpherical;        // 0x3D4
        private UnityEngine.Rendering.CoreCameraValues coreCameraValues;        // 0x3D8
        private System.UInt32 cameraType;        // 0x3E8
        private System.Int32 projectionIsOblique;        // 0x3EC
        private System.Int32 isImplicitProjectionMatrix;        // 0x3F0

        // Methods
        private UnityEngine.Plane GetShadowCullingPlane(System.Int32 index) { }
        private UnityEngine.Plane GetCameraCullingPlane(System.Int32 index) { }
        private System.Boolean Equals(UnityEngine.Rendering.CameraProperties other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000334
    public struct CullingOptions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.CullingOptions None;        // 0x0
        public static UnityEngine.Rendering.CullingOptions ForceEvenIfCameraIsNotActive;        // 0x0
        public static UnityEngine.Rendering.CullingOptions OcclusionCull;        // 0x0
        public static UnityEngine.Rendering.CullingOptions NeedsLighting;        // 0x0
        public static UnityEngine.Rendering.CullingOptions NeedsReflectionProbes;        // 0x0
        public static UnityEngine.Rendering.CullingOptions Stereo;        // 0x0
        public static UnityEngine.Rendering.CullingOptions DisablePerObjectCulling;        // 0x0
        public static UnityEngine.Rendering.CullingOptions ShadowCasters;        // 0x0

    }

    // TypeToken: 0x2000335
    public struct ScriptableCullingParameters, IEquatable`1
    {
        // Fields
        private System.Int32 m_IsOrthographic;        // 0x10
        private UnityEngine.Rendering.LODParameters m_LODParameters;        // 0x14
        public static readonly System.Int32 maximumCullingPlaneCount;        // 0x0
        private UnityEngine.Rendering.ScriptableCullingParameters.<m_CullingPlanes>e__FixedBuffer m_CullingPlanes;        // 0x30
        private System.Int32 m_CullingPlaneCount;        // 0xD0
        private System.UInt32 m_CullingMask;        // 0xD4
        private System.UInt64 m_SceneMask;        // 0xD8
        public static readonly System.Int32 layerCount;        // 0x4
        private UnityEngine.Rendering.ScriptableCullingParameters.<m_LayerFarCullDistances>e__FixedBuffer m_LayerFarCullDistances;        // 0xE0
        private System.Int32 m_LayerCull;        // 0x160
        private UnityEngine.Matrix4x4 m_CullingMatrix;        // 0x164
        private UnityEngine.Vector3 m_Origin;        // 0x1A4
        private System.Single m_ShadowDistance;        // 0x1B0
        private System.Single m_ShadowNearPlaneOffset;        // 0x1B4
        private UnityEngine.Rendering.CullingOptions m_CullingOptions;        // 0x1B8
        private UnityEngine.Rendering.ReflectionProbeSortingCriteria m_ReflectionProbeSortingCriteria;        // 0x1BC
        private UnityEngine.Rendering.CameraProperties m_CameraProperties;        // 0x1C0
        private System.Single m_AccurateOcclusionThreshold;        // 0x5A4
        private System.Int32 m_MaximumPortalCullingJobs;        // 0x5A8
        private UnityEngine.Matrix4x4 m_StereoViewMatrix;        // 0x5AC
        private UnityEngine.Matrix4x4 m_StereoProjectionMatrix;        // 0x5EC
        private System.Single m_StereoSeparationDistance;        // 0x62C
        private System.Int32 m_maximumVisibleLights;        // 0x630
        private System.Boolean m_ConservativeEnclosingSphere;        // 0x634
        private System.Int32 m_NumIterationsEnclosingSphere;        // 0x638
        private System.UInt32 m_HGCullingViewHandle;        // 0x63C
        private System.UInt32 m_HGCullingViewUniqueID;        // 0x640
        private System.Single m_LightCullScreenSpaceArea;        // 0x644

        // Methods
        private System.Void set_maximumVisibleLights(System.Int32 value) { }
        private System.Int32 get_cullingPlaneCount() { }
        private System.Void set_isOrthographic(System.Boolean value) { }
        private System.Void set_cullingMask(System.UInt32 value) { }
        private System.Void set_cullingMatrix(UnityEngine.Matrix4x4 value) { }
        private System.Void set_shadowDistance(System.Single value) { }
        private UnityEngine.Rendering.CullingOptions get_cullingOptions() { }
        private System.Void set_cullingOptions(UnityEngine.Rendering.CullingOptions value) { }
        private System.Void set_hgCullingViewHandle(System.UInt32 value) { }
        private System.Void set_hgCullingViewUniqueID(System.UInt32 value) { }
        private System.Single GetLayerCullingDistance(System.Int32 layerIndex) { }
        private UnityEngine.Plane GetCullingPlane(System.Int32 index) { }
        private System.Void SetCullingPlane(System.Int32 index, UnityEngine.Plane plane) { }
        private System.Boolean Equals(UnityEngine.Rendering.ScriptableCullingParameters other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000338
    public struct CullingResults, IEquatable`1
    {
        // Fields
        public System.IntPtr ptr;        // 0x10
        private UnityEngine.Rendering.CullingAllocationInfo* m_AllocationInfo;        // 0x18

        // Methods
        private System.Boolean GetShadowCasterBounds(System.IntPtr cullingResultsPtr, System.Int32 lightIndex, UnityEngine.Bounds& bounds) { }
        private System.Boolean ComputeDirectionalShadowMatricesAndCullingPrimitives(System.IntPtr cullingResultsPtr, System.Int32 activeLightIndex, System.Int32 splitIndex, System.Int32 splitCount, UnityEngine.Vector3 splitRatio, System.Int32 shadowResolution, System.Single shadowNearPlaneOffset, UnityEngine.Matrix4x4& viewMatrix, UnityEngine.Matrix4x4& projMatrix, UnityEngine.Rendering.ShadowSplitData& shadowSplitData) { }
        private System.Boolean GetShadowCasterBounds(System.Int32 lightIndex, UnityEngine.Bounds& outBounds) { }
        private System.Boolean ComputeDirectionalShadowMatricesAndCullingPrimitives(System.Int32 activeLightIndex, System.Int32 splitIndex, System.Int32 splitCount, UnityEngine.Vector3 splitRatio, System.Int32 shadowResolution, System.Single shadowNearPlaneOffset, UnityEngine.Matrix4x4& viewMatrix, UnityEngine.Matrix4x4& projMatrix, UnityEngine.Rendering.ShadowSplitData& shadowSplitData) { }
        private System.Boolean Equals(UnityEngine.Rendering.CullingResults other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected(System.IntPtr cullingResultsPtr, System.Int32 activeLightIndex, System.Int32 splitIndex, System.Int32 splitCount, UnityEngine.Vector3& splitRatio, System.Int32 shadowResolution, System.Single shadowNearPlaneOffset, UnityEngine.Matrix4x4& viewMatrix, UnityEngine.Matrix4x4& projMatrix, UnityEngine.Rendering.ShadowSplitData& shadowSplitData) { }

    }

    // TypeToken: 0x2000339
    public struct CullingAllocationInfo
    {
        // Fields
        public UnityEngine.Rendering.VisibleLight* visibleLightsPtr;        // 0x10
        public UnityEngine.Rendering.VisibleLight* visibleOffscreenVertexLightsPtr;        // 0x18
        public UnityEngine.Rendering.VisibleReflectionProbe* visibleReflectionProbesPtr;        // 0x20
        public System.Int32 visibleLightCount;        // 0x28
        public System.Int32 visibleOffscreenVertexLightCount;        // 0x2C
        public System.Int32 visibleReflectionProbeCount;        // 0x30

    }

    // TypeToken: 0x200033A
    public struct DepthState, IEquatable`1
    {
        // Fields
        private System.Byte m_WriteEnabled;        // 0x10
        private System.SByte m_CompareFunction;        // 0x11

        // Methods
        private System.Boolean Equals(UnityEngine.Rendering.DepthState other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200033B
    public struct DrawingSettings, IEquatable`1
    {
        // Fields
        public static readonly System.Int32 maxShaderPasses;        // 0x0
        private UnityEngine.Rendering.SortingSettings m_SortingSettings;        // 0x10
        private UnityEngine.Rendering.DrawingSettings.<shaderPassNames>e__FixedBuffer shaderPassNames;        // 0xF4
        private UnityEngine.Rendering.PerObjectData m_PerObjectData;        // 0x134
        private UnityEngine.Rendering.DrawRendererFlags m_Flags;        // 0x138
        private System.Int32 m_OverrideMaterialInstanceId;        // 0x13C
        private System.Int32 m_OverrideMaterialPassIndex;        // 0x140
        private System.Int32 m_fallbackMaterialInstanceId;        // 0x144
        private System.Int32 m_MainLightIndex;        // 0x148
        private System.Single m_ScreenCullingRatio;        // 0x14C
        private System.Single m_ScreenRatioCullingDistance;        // 0x150
        private System.UInt32 m_ScreenCullingLayerMask;        // 0x154
        private System.Int32 m_UseSrpBatcher;        // 0x158

        // Methods
        private System.Void .ctor(UnityEngine.Rendering.ShaderTagId shaderPassName, UnityEngine.Rendering.SortingSettings sortingSettings) { }
        private System.Void set_perObjectData(UnityEngine.Rendering.PerObjectData value) { }
        private System.Void set_overrideMaterial(UnityEngine.Material value) { }
        private System.Void set_overrideMaterialPassIndex(System.Int32 value) { }
        private System.Void set_screenCullingRatio(System.Single value) { }
        private System.Void set_screenRatioCullingDistance(System.Single value) { }
        private System.Void set_screenCullingLayerMask(System.UInt32 value) { }
        private UnityEngine.Rendering.ShaderTagId GetShaderPassName(System.Int32 index) { }
        private System.Void SetShaderPassName(System.Int32 index, UnityEngine.Rendering.ShaderTagId shaderPassName) { }
        private System.Boolean Equals(UnityEngine.Rendering.DrawingSettings other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200033D
    public struct DrawRendererFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.DrawRendererFlags None;        // 0x0
        public static UnityEngine.Rendering.DrawRendererFlags EnableDynamicBatching;        // 0x0
        public static UnityEngine.Rendering.DrawRendererFlags EnableInstancing;        // 0x0

    }

    // TypeToken: 0x200033E
    public struct FilteringSettings, IEquatable`1
    {
        // Fields
        private UnityEngine.Rendering.RenderQueueRange m_RenderQueueRange;        // 0x10
        private System.Int32 m_LayerMask;        // 0x18
        private System.UInt32 m_RenderingLayerMask;        // 0x1C
        private System.Int32 m_ExcludeMotionVectorObjects;        // 0x20
        private UnityEngine.Rendering.SortingLayerRange m_SortingLayerRange;        // 0x24
        private System.Int16 m_SortingOrderMin;        // 0x28
        private System.Int16 m_SortingOrderMax;        // 0x2A
        private System.UInt16 m_CharacterIndex;        // 0x2C

        // Methods
        private System.Void .ctor(System.Nullable<UnityEngine.Rendering.RenderQueueRange> renderQueueRange, System.Int32 layerMask, System.UInt32 renderingLayerMask, System.Int32 excludeMotionVectorObjects) { }
        private System.Void set_excludeMotionVectorObjects(System.Boolean value) { }
        private System.Void set_sortingLayerRange(UnityEngine.Rendering.SortingLayerRange value) { }
        private System.Void set_sortingOrderMin(System.Int16 value) { }
        private System.Void set_sortingOrderMax(System.Int16 value) { }
        private System.Void set_characterIndex(System.UInt16 value) { }
        private System.Boolean Equals(UnityEngine.Rendering.FilteringSettings other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200033F
    public struct GizmoSubset
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.GizmoSubset PreImageEffects;        // 0x0
        public static UnityEngine.Rendering.GizmoSubset PostImageEffects;        // 0x0

    }

    // TypeToken: 0x2000340
    public struct LODParameters, IEquatable`1
    {
        // Fields
        private System.Int32 m_IsOrthographic;        // 0x10
        private UnityEngine.Vector3 m_CameraPosition;        // 0x14
        private System.Single m_FieldOfView;        // 0x20
        private System.Single m_OrthoSize;        // 0x24
        private System.Int32 m_CameraPixelHeight;        // 0x28

        // Methods
        private System.Boolean Equals(UnityEngine.Rendering.LODParameters other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000341
    public struct PerObjectData
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.PerObjectData None;        // 0x0
        public static UnityEngine.Rendering.PerObjectData LightProbe;        // 0x0
        public static UnityEngine.Rendering.PerObjectData ReflectionProbes;        // 0x0
        public static UnityEngine.Rendering.PerObjectData LightProbeProxyVolume;        // 0x0
        public static UnityEngine.Rendering.PerObjectData Lightmaps;        // 0x0
        public static UnityEngine.Rendering.PerObjectData LightData;        // 0x0
        public static UnityEngine.Rendering.PerObjectData MotionVectors;        // 0x0
        public static UnityEngine.Rendering.PerObjectData LightIndices;        // 0x0
        public static UnityEngine.Rendering.PerObjectData ReflectionProbeData;        // 0x0
        public static UnityEngine.Rendering.PerObjectData OcclusionProbe;        // 0x0
        public static UnityEngine.Rendering.PerObjectData OcclusionProbeProxyVolume;        // 0x0
        public static UnityEngine.Rendering.PerObjectData ShadowMask;        // 0x0
        public static UnityEngine.Rendering.PerObjectData CastShadow;        // 0x0
        public static UnityEngine.Rendering.PerObjectData StaticShadowCaster;        // 0x0
        public static UnityEngine.Rendering.PerObjectData DynamicShadowCaster;        // 0x0
        public static UnityEngine.Rendering.PerObjectData CullNonRealtimeShadowCaster;        // 0x0
        public static UnityEngine.Rendering.PerObjectData ParticleLightingIndex;        // 0x0

    }

    // TypeToken: 0x2000342
    public struct RasterState, IEquatable`1
    {
        // Fields
        public static readonly UnityEngine.Rendering.RasterState defaultValue;        // 0x0
        private UnityEngine.Rendering.CullMode m_CullingMode;        // 0x10
        private System.Int32 m_OffsetUnits;        // 0x14
        private System.Single m_OffsetFactor;        // 0x18
        private System.Byte m_DepthClip;        // 0x1C
        private System.Byte m_Conservative;        // 0x1D
        private System.Byte m_Padding1;        // 0x1E
        private System.Byte m_Padding2;        // 0x1F

        // Methods
        private System.Void .ctor(UnityEngine.Rendering.CullMode cullingMode, System.Int32 offsetUnits, System.Single offsetFactor, System.Boolean depthClip) { }
        private System.Boolean Equals(UnityEngine.Rendering.RasterState other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000343
    public struct ReflectionProbeSortingCriteria
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.ReflectionProbeSortingCriteria None;        // 0x0
        public static UnityEngine.Rendering.ReflectionProbeSortingCriteria Importance;        // 0x0
        public static UnityEngine.Rendering.ReflectionProbeSortingCriteria Size;        // 0x0
        public static UnityEngine.Rendering.ReflectionProbeSortingCriteria ImportanceThenSize;        // 0x0

    }

    // TypeToken: 0x2000344
    public class RenderPipeline
    {
        // Fields
        private System.Boolean <disposed>k__BackingField;        // 0x10

        // Methods
        private System.Void Render(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera[] cameras) { }
        private System.Void ProcessRenderRequests(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera, System.Collections.Generic.List<UnityEngine.Camera.RenderRequest> renderRequests) { }
        private System.Void BeginContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras) { }
        private System.Void BeginCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera) { }
        private System.Void EndContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras) { }
        private System.Void EndCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera) { }
        private System.Void Render(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras) { }
        private System.Void InternalRender(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras) { }
        private System.Void InternalRenderWithRequests(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras, System.Collections.Generic.List<UnityEngine.Camera.RenderRequest> renderRequests) { }
        private System.Boolean get_disposed() { }
        private System.Void set_disposed(System.Boolean value) { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private UnityEngine.Rendering.RenderPipelineGlobalSettings get_defaultSettings() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000345
    public class RenderPipelineAsset : ScriptableObject
    {
        // Methods
        private UnityEngine.Rendering.RenderPipeline InternalCreatePipeline() { }
        private System.String[] get_renderingLayerMaskNames() { }
        private System.String[] get_prefixedRenderingLayerMaskNames() { }
        private UnityEngine.Material get_defaultMaterial() { }
        private UnityEngine.Shader get_autodeskInteractiveShader() { }
        private UnityEngine.Shader get_autodeskInteractiveTransparentShader() { }
        private UnityEngine.Shader get_autodeskInteractiveMaskedShader() { }
        private UnityEngine.Shader get_terrainDetailLitShader() { }
        private UnityEngine.Shader get_terrainDetailGrassShader() { }
        private UnityEngine.Shader get_terrainDetailGrassBillboardShader() { }
        private UnityEngine.Material get_defaultParticleMaterial() { }
        private UnityEngine.Material get_defaultLineMaterial() { }
        private UnityEngine.Material get_defaultTerrainMaterial() { }
        private UnityEngine.Material get_defaultUIMaterial() { }
        private UnityEngine.Material get_defaultUIOverdrawMaterial() { }
        private UnityEngine.Material get_defaultUIETC1SupportedMaterial() { }
        private UnityEngine.Material get_default2DMaterial() { }
        private UnityEngine.Material get_default2DMaskMaterial() { }
        private UnityEngine.Shader get_defaultShader() { }
        private UnityEngine.Shader get_defaultSpeedTree7Shader() { }
        private UnityEngine.Shader get_defaultSpeedTree8Shader() { }
        private UnityEngine.Mesh get_defaultQuadMesh() { }
        private UnityEngine.Mesh get_defaultPlaneMesh() { }
        private UnityEngine.Mesh get_defaultCylinderMesh() { }
        private UnityEngine.Mesh get_defaultCapsuleMesh() { }
        private UnityEngine.Mesh get_defaultSphereMesh() { }
        private UnityEngine.Mesh get_defaultCubeMesh() { }
        private UnityEngine.Rendering.RenderPipeline CreatePipeline() { }
        private System.Void OnValidate() { }
        private System.Void OnDisable() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000346
    public class RenderPipelineGlobalSettings : ScriptableObject
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000347
    public class RenderPipelineManager
    {
        // Fields
        private static UnityEngine.Rendering.RenderPipelineAsset s_CurrentPipelineAsset;        // 0x0
        private static System.Collections.Generic.List<UnityEngine.Camera> s_Cameras;        // 0x8
        private static System.String s_currentPipelineType;        // 0x10
        private static UnityEngine.Rendering.RenderPipeline s_currentPipeline;        // 0x18
        private static System.Action<UnityEngine.Rendering.ScriptableRenderContext,System.Collections.Generic.List<UnityEngine.Camera>> beginContextRendering;        // 0x20
        private static System.Action<UnityEngine.Rendering.ScriptableRenderContext,System.Collections.Generic.List<UnityEngine.Camera>> endContextRendering;        // 0x28
        private static System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Camera[]> beginFrameRendering;        // 0x30
        private static System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Camera> beginCameraRendering;        // 0x38
        private static System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Camera[]> endFrameRendering;        // 0x40
        private static System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Camera> endCameraRendering;        // 0x48
        private static System.Action<UnityEngine.Rendering.ScriptableRenderContext,System.Collections.Generic.List<UnityEngine.Camera>> beginFrameRenderingNoAlloc;        // 0x50
        private static System.Action<UnityEngine.Rendering.ScriptableRenderContext,System.Collections.Generic.List<UnityEngine.Camera>> endFrameRenderingNoAlloc;        // 0x58
        private static System.Action activeRenderPipelineTypeChanged;        // 0x60
        private static System.Action activeRenderPipelineCreated;        // 0x68
        private static System.Action activeRenderPipelineDisposed;        // 0x70

        // Methods
        private UnityEngine.Rendering.RenderPipeline get_currentPipeline() { }
        private System.Void set_currentPipeline(UnityEngine.Rendering.RenderPipeline value) { }
        private System.Void add_beginCameraRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Camera> value) { }
        private System.Void remove_beginCameraRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Camera> value) { }
        private System.Void add_endCameraRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Camera> value) { }
        private System.Void remove_endCameraRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Camera> value) { }
        private System.Void add_beginFrameRenderingNoAlloc(System.Action<UnityEngine.Rendering.ScriptableRenderContext,System.Collections.Generic.List<UnityEngine.Camera>> value) { }
        private System.Void remove_beginFrameRenderingNoAlloc(System.Action<UnityEngine.Rendering.ScriptableRenderContext,System.Collections.Generic.List<UnityEngine.Camera>> value) { }
        private System.Void BeginContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras) { }
        private System.Void BeginCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera) { }
        private System.Void EndContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras) { }
        private System.Void EndCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera) { }
        private System.Void OnActiveRenderPipelineTypeChanged() { }
        private System.Void HandleRenderPipelineChange(UnityEngine.Rendering.RenderPipelineAsset pipelineAsset) { }
        private System.Void CleanupRenderPipeline() { }
        private System.String GetCurrentPipelineAssetType() { }
        private System.Void DoRenderLoop_Internal(UnityEngine.Rendering.RenderPipelineAsset pipe, System.IntPtr loopPtr, System.Collections.Generic.List<UnityEngine.Camera.RenderRequest> renderRequests) { }
        private System.Void PrepareRenderPipeline(UnityEngine.Rendering.RenderPipelineAsset pipelineAsset) { }
        private System.Boolean IsPipelineRequireCreation() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000348
    public struct RenderQueueRange, IEquatable`1
    {
        // Fields
        private System.Int32 m_LowerBound;        // 0x10
        private System.Int32 m_UpperBound;        // 0x14
        public static readonly System.Int32 minimumBound;        // 0x0
        public static readonly System.Int32 maximumBound;        // 0x4

        // Methods
        private UnityEngine.Rendering.RenderQueueRange get_all() { }
        private System.Int32 get_lowerBound() { }
        private System.Void set_lowerBound(System.Int32 value) { }
        private System.Int32 get_upperBound() { }
        private System.Void set_upperBound(System.Int32 value) { }
        private System.Boolean Equals(UnityEngine.Rendering.RenderQueueRange other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000349
    public struct RenderStateBlock, IEquatable`1
    {
        // Fields
        private UnityEngine.Rendering.BlendState m_BlendState;        // 0x10
        private UnityEngine.Rendering.RasterState m_RasterState;        // 0x54
        private UnityEngine.Rendering.DepthState m_DepthState;        // 0x64
        private UnityEngine.Rendering.StencilState m_StencilState;        // 0x66
        private System.Int32 m_StencilReference;        // 0x74
        private UnityEngine.Rendering.RenderStateMask m_Mask;        // 0x78

        // Methods
        private System.Boolean Equals(UnityEngine.Rendering.RenderStateBlock other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200034A
    public struct RenderStateMask
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.RenderStateMask Nothing;        // 0x0
        public static UnityEngine.Rendering.RenderStateMask Blend;        // 0x0
        public static UnityEngine.Rendering.RenderStateMask Raster;        // 0x0
        public static UnityEngine.Rendering.RenderStateMask Depth;        // 0x0
        public static UnityEngine.Rendering.RenderStateMask Stencil;        // 0x0
        public static UnityEngine.Rendering.RenderStateMask Everything;        // 0x0

    }

    // TypeToken: 0x200034B
    public struct RenderTargetBlendState, IEquatable`1
    {
        // Fields
        private System.Byte m_WriteMask;        // 0x10
        private System.Byte m_SourceColorBlendMode;        // 0x11
        private System.Byte m_DestinationColorBlendMode;        // 0x12
        private System.Byte m_SourceAlphaBlendMode;        // 0x13
        private System.Byte m_DestinationAlphaBlendMode;        // 0x14
        private System.Byte m_ColorBlendOperation;        // 0x15
        private System.Byte m_AlphaBlendOperation;        // 0x16
        private System.Byte m_Padding;        // 0x17

        // Methods
        private System.Boolean Equals(UnityEngine.Rendering.RenderTargetBlendState other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200034C
    public struct CBHandle
    {
        // Fields
        public System.UInt32 bufferId;        // 0x10
        public System.UInt32 offset;        // 0x14
        public System.UInt32 size;        // 0x18
        public System.IntPtr ptr;        // 0x20

    }

    // TypeToken: 0x200034D
    public struct ScriptableRenderContext, IEquatable`1
    {
        // Fields
        private static readonly UnityEngine.Rendering.ShaderTagId kRenderTypeTag;        // 0x0
        private System.IntPtr m_Ptr;        // 0x10

        // Methods
        private System.Void BeginRenderPass_Internal(System.IntPtr self, System.Int32 width, System.Int32 height, System.Int32 samples, System.IntPtr colors, System.Int32 colorCount, System.Int32 depthAttachmentIndex) { }
        private System.Void BeginSubPass_Internal(System.IntPtr self, System.IntPtr colors, System.Int32 colorCount, System.IntPtr inputs, System.Int32 inputCount, System.Boolean isDepthReadOnly, System.Boolean isStencilReadOnly) { }
        private System.Void EndSubPass_Internal(System.IntPtr self) { }
        private System.Void EndRenderPass_Internal(System.IntPtr self) { }
        private System.Void Internal_Cull(UnityEngine.Rendering.ScriptableCullingParameters& parameters, UnityEngine.Rendering.ScriptableRenderContext renderLoop, System.IntPtr results) { }
        private System.Void InitializeSortSettings(UnityEngine.Camera camera, UnityEngine.Rendering.SortingSettings& sortingSettings) { }
        private System.Void Submit_Internal() { }
        private System.Void GetCameras_Internal(System.Type listType, System.Object resultList) { }
        private System.Void DrawRenderers_Internal(System.IntPtr cullResults, UnityEngine.Rendering.DrawingSettings& drawingSettings, UnityEngine.Rendering.FilteringSettings& filteringSettings, UnityEngine.Rendering.ShaderTagId tagName, System.Boolean isPassTagName, System.IntPtr tagValues, System.IntPtr stateBlocks, System.Int32 stateCount) { }
        private System.Void DrawShadows_Internal(System.IntPtr shadowDrawingSettings) { }
        private System.Void EmitGeometryForCamera(UnityEngine.Camera camera) { }
        private UnityEngine.Rendering.CBHandle AllocateConstantBuffer(System.Int32 size) { }
        private System.Void ExecuteCommandBuffer_Internal(UnityEngine.Rendering.CommandBuffer commandBuffer) { }
        private System.Void ExecuteCommandBufferAsync_Internal(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Rendering.ComputeQueueType queueType) { }
        private System.Void ExecuteCommandBufferNoCopy_Internal(UnityEngine.Rendering.CommandBuffer commandBuffer) { }
        private System.Void ExecuteCommandBufferAsyncNoCopy_Internal(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Rendering.ComputeQueueType queueType) { }
        private System.Void SetupCameraProperties_Internal(UnityEngine.Camera camera, System.Boolean stereoSetup, System.Int32 eye) { }
        private System.Void DrawGizmos_Internal(UnityEngine.Camera camera, UnityEngine.Rendering.GizmoSubset gizmoSubset) { }
        private UnityEngine.Rendering.RendererUtils.RendererList CreateRendererList_Internal(System.IntPtr cullResults, UnityEngine.Rendering.DrawingSettings& drawingSettings, UnityEngine.Rendering.FilteringSettings& filteringSettings, UnityEngine.Rendering.ShaderTagId tagName, System.Boolean isPassTagName, System.IntPtr tagValues, System.IntPtr stateBlocks, System.Int32 stateCount, System.IntPtr drawableFeedbackPtr) { }
        private System.Void PrepareRendererListsAsync_Internal(System.Object rendererLists) { }
        private UnityEngine.Rendering.RendererUtils.RendererListStatus QueryRendererListStatus_Internal(UnityEngine.Rendering.RendererUtils.RendererList handle) { }
        private System.Int32 QueryRendererListObjCount_Internal(UnityEngine.Rendering.RendererUtils.RendererList handle) { }
        private System.Void .ctor(System.IntPtr ptr) { }
        private System.Void BeginRenderPass(System.Int32 width, System.Int32 height, System.Int32 samples, Unity.Collections.NativeArray<UnityEngine.Rendering.AttachmentDescriptor> attachments, System.Int32 depthAttachmentIndex) { }
        private System.Void BeginSubPass(Unity.Collections.NativeArray<System.Int32> colors, Unity.Collections.NativeArray<System.Int32> inputs, System.Boolean isDepthStencilReadOnly) { }
        private System.Void BeginSubPass(Unity.Collections.NativeArray<System.Int32> colors, System.Boolean isDepthStencilReadOnly) { }
        private System.Void EndSubPass() { }
        private System.Void EndRenderPass() { }
        private System.Void Submit() { }
        private System.Void GetCameras(System.Collections.Generic.List<UnityEngine.Camera> results) { }
        private System.Void DrawRenderers(UnityEngine.Rendering.CullingResults cullingResults, UnityEngine.Rendering.DrawingSettings& drawingSettings, UnityEngine.Rendering.FilteringSettings& filteringSettings) { }
        private System.Void DrawRenderers(UnityEngine.Rendering.CullingResults cullingResults, UnityEngine.Rendering.DrawingSettings& drawingSettings, UnityEngine.Rendering.FilteringSettings& filteringSettings, UnityEngine.Rendering.RenderStateBlock& stateBlock) { }
        private System.Void DrawShadows(UnityEngine.Rendering.ShadowDrawingSettings& settings) { }
        private System.Void ExecuteCommandBuffer(UnityEngine.Rendering.CommandBuffer commandBuffer) { }
        private System.Void ExecuteCommandBufferAsync(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Rendering.ComputeQueueType queueType) { }
        private System.Void ExecuteCommandBufferNoCopy(UnityEngine.Rendering.CommandBuffer commandBuffer) { }
        private System.Void ExecuteCommandBufferAsyncNoCopy(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Rendering.ComputeQueueType queueType) { }
        private System.Void SetupCameraProperties(UnityEngine.Camera camera, System.Boolean stereoSetup) { }
        private System.Void SetupCameraProperties(UnityEngine.Camera camera, System.Boolean stereoSetup, System.Int32 eye) { }
        private System.Void DrawGizmos(UnityEngine.Camera camera, UnityEngine.Rendering.GizmoSubset gizmoSubset) { }
        private UnityEngine.Rendering.CullingResults Cull(UnityEngine.Rendering.ScriptableCullingParameters& parameters) { }
        private System.Boolean Equals(UnityEngine.Rendering.ScriptableRenderContext other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private UnityEngine.Rendering.RendererUtils.RendererList CreateRendererList(UnityEngine.Rendering.RendererUtils.RendererListDesc desc) { }
        private System.Void PrepareRendererListsAsync(System.Collections.Generic.List<UnityEngine.Rendering.RendererUtils.RendererList> rendererLists) { }
        private UnityEngine.Rendering.RendererUtils.RendererListStatus QueryRendererListStatus(UnityEngine.Rendering.RendererUtils.RendererList rendererList) { }
        private System.Int32 QueryRendererListObjCount(UnityEngine.Rendering.RendererUtils.RendererList rendererList) { }
        private System.IntPtr GetNativePtr() { }
        private System.Void .cctor() { }
        private System.Void Internal_Cull_Injected(UnityEngine.Rendering.ScriptableCullingParameters& parameters, UnityEngine.Rendering.ScriptableRenderContext& renderLoop, System.IntPtr results) { }
        private System.Void Submit_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext& _unity_self) { }
        private System.Void GetCameras_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext& _unity_self, System.Type listType, System.Object resultList) { }
        private System.Void DrawRenderers_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext& _unity_self, System.IntPtr cullResults, UnityEngine.Rendering.DrawingSettings& drawingSettings, UnityEngine.Rendering.FilteringSettings& filteringSettings, UnityEngine.Rendering.ShaderTagId& tagName, System.Boolean isPassTagName, System.IntPtr tagValues, System.IntPtr stateBlocks, System.Int32 stateCount) { }
        private System.Void DrawShadows_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext& _unity_self, System.IntPtr shadowDrawingSettings) { }
        private System.Void AllocateConstantBuffer_Injected(UnityEngine.Rendering.ScriptableRenderContext& _unity_self, System.Int32 size, UnityEngine.Rendering.CBHandle& ret) { }
        private System.Void ExecuteCommandBuffer_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext& _unity_self, UnityEngine.Rendering.CommandBuffer commandBuffer) { }
        private System.Void ExecuteCommandBufferAsync_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext& _unity_self, UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Rendering.ComputeQueueType queueType) { }
        private System.Void ExecuteCommandBufferNoCopy_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext& _unity_self, UnityEngine.Rendering.CommandBuffer commandBuffer) { }
        private System.Void ExecuteCommandBufferAsyncNoCopy_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext& _unity_self, UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Rendering.ComputeQueueType queueType) { }
        private System.Void SetupCameraProperties_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext& _unity_self, UnityEngine.Camera camera, System.Boolean stereoSetup, System.Int32 eye) { }
        private System.Void DrawGizmos_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext& _unity_self, UnityEngine.Camera camera, UnityEngine.Rendering.GizmoSubset gizmoSubset) { }
        private System.Void CreateRendererList_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext& _unity_self, System.IntPtr cullResults, UnityEngine.Rendering.DrawingSettings& drawingSettings, UnityEngine.Rendering.FilteringSettings& filteringSettings, UnityEngine.Rendering.ShaderTagId& tagName, System.Boolean isPassTagName, System.IntPtr tagValues, System.IntPtr stateBlocks, System.Int32 stateCount, System.IntPtr drawableFeedbackPtr, UnityEngine.Rendering.RendererUtils.RendererList& ret) { }
        private System.Void PrepareRendererListsAsync_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext& _unity_self, System.Object rendererLists) { }
        private UnityEngine.Rendering.RendererUtils.RendererListStatus QueryRendererListStatus_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext& _unity_self, UnityEngine.Rendering.RendererUtils.RendererList& handle) { }
        private System.Int32 QueryRendererListObjCount_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext& _unity_self, UnityEngine.Rendering.RendererUtils.RendererList& handle) { }

    }

    // TypeToken: 0x200034E
    public struct ShaderTagId, IEquatable`1
    {
        // Fields
        public static readonly UnityEngine.Rendering.ShaderTagId none;        // 0x0
        private System.Int32 m_Id;        // 0x10

        // Methods
        private System.Void .ctor(System.String name) { }
        private System.Int32 get_id() { }
        private System.Void set_id(System.Int32 value) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(UnityEngine.Rendering.ShaderTagId other) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean op_Equality(UnityEngine.Rendering.ShaderTagId tag1, UnityEngine.Rendering.ShaderTagId tag2) { }
        private System.Boolean op_Inequality(UnityEngine.Rendering.ShaderTagId tag1, UnityEngine.Rendering.ShaderTagId tag2) { }

    }

    // TypeToken: 0x200034F
    public struct ShadowDrawingSettings, IEquatable`1
    {
        // Fields
        private UnityEngine.Rendering.CullingResults m_CullingResults;        // 0x10
        private System.Int32 m_LightIndex;        // 0x20
        private System.Int32 m_UseRenderingLayerMaskTest;        // 0x24
        private UnityEngine.Rendering.ShadowSplitData m_SplitData;        // 0x28
        private UnityEngine.ShadowObjectsFilter m_ObjectsFilter;        // 0xE4
        private System.Boolean m_CullNonRealtimeCasters;        // 0xE8

        // Methods
        private System.Void set_useRenderingLayerMaskTest(System.Boolean value) { }
        private System.Void set_splitData(UnityEngine.Rendering.ShadowSplitData value) { }
        private System.Void set_objectsFilter(UnityEngine.ShadowObjectsFilter value) { }
        private System.Void set_cullNonRealtimeCasters(System.Boolean value) { }
        private System.Void .ctor(UnityEngine.Rendering.CullingResults cullingResults, System.Int32 lightIndex) { }
        private System.Boolean Equals(UnityEngine.Rendering.ShadowDrawingSettings other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000350
    public struct ShadowSplitData, IEquatable`1
    {
        // Fields
        private static System.Int32 k_MaximumCullingPlaneCount;        // 0x0
        public static readonly System.Int32 maximumCullingPlaneCount;        // 0x0
        private System.Int32 m_CullingPlaneCount;        // 0x10
        public UnityEngine.Rendering.ShadowSplitData.<m_CullingPlanes>e__FixedBuffer m_CullingPlanes;        // 0x14
        private UnityEngine.Vector4 m_CullingSphere;        // 0xB4
        private System.Single m_ShadowCascadeBlendCullingFactor;        // 0xC4
        private System.Single m_CullingNearPlane;        // 0xC8

        // Methods
        private System.Int32 get_cullingPlaneCount() { }
        private System.Void set_cullingPlaneCount(System.Int32 value) { }
        private UnityEngine.Vector4 get_cullingSphere() { }
        private System.Void set_shadowCascadeBlendCullingFactor(System.Single value) { }
        private UnityEngine.Plane GetCullingPlane(System.Int32 index) { }
        private System.Boolean Equals(UnityEngine.Rendering.ShadowSplitData other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000352
    public struct SortingCriteria
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.SortingCriteria None;        // 0x0
        public static UnityEngine.Rendering.SortingCriteria SortingLayer;        // 0x0
        public static UnityEngine.Rendering.SortingCriteria RenderQueue;        // 0x0
        public static UnityEngine.Rendering.SortingCriteria BackToFront;        // 0x0
        public static UnityEngine.Rendering.SortingCriteria QuantizedFrontToBack;        // 0x0
        public static UnityEngine.Rendering.SortingCriteria OptimizeStateChanges;        // 0x0
        public static UnityEngine.Rendering.SortingCriteria CanvasOrder;        // 0x0
        public static UnityEngine.Rendering.SortingCriteria RendererPriority;        // 0x0
        public static UnityEngine.Rendering.SortingCriteria CommonOpaque;        // 0x0
        public static UnityEngine.Rendering.SortingCriteria CommonTransparent;        // 0x0

    }

    // TypeToken: 0x2000353
    public struct SortingLayerRange, IEquatable`1
    {
        // Fields
        private System.Int16 m_LowerBound;        // 0x10
        private System.Int16 m_UpperBound;        // 0x12

        // Methods
        private System.Void .ctor(System.Int16 lowerBound, System.Int16 upperBound) { }
        private UnityEngine.Rendering.SortingLayerRange get_all() { }
        private System.Boolean Equals(UnityEngine.Rendering.SortingLayerRange other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000354
    public struct DistanceMetric
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.DistanceMetric Perspective;        // 0x0
        public static UnityEngine.Rendering.DistanceMetric Orthographic;        // 0x0
        public static UnityEngine.Rendering.DistanceMetric CustomAxis;        // 0x0

    }

    // TypeToken: 0x2000355
    public struct SortingSettings, IEquatable`1
    {
        // Fields
        private UnityEngine.Matrix4x4 m_WorldToCameraMatrix;        // 0x10
        private UnityEngine.Vector3 m_CameraPosition;        // 0x50
        private UnityEngine.Vector3 m_CustomAxis;        // 0x5C
        private UnityEngine.Rendering.SortingCriteria m_Criteria;        // 0x68
        private UnityEngine.Rendering.DistanceMetric m_DistanceMetric;        // 0x6C
        private UnityEngine.Matrix4x4 m_PreviousVPMatrix;        // 0x70
        private UnityEngine.Matrix4x4 m_NonJitteredVPMatrix;        // 0xB0
        private System.Single m_FOV;        // 0xF0

        // Methods
        private System.Void .ctor(UnityEngine.Camera camera) { }
        private UnityEngine.Rendering.SortingCriteria get_criteria() { }
        private System.Void set_criteria(UnityEngine.Rendering.SortingCriteria value) { }
        private System.Boolean Equals(UnityEngine.Rendering.SortingSettings other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000356
    public struct StencilState, IEquatable`1
    {
        // Fields
        private System.Byte m_Enabled;        // 0x10
        private System.Byte m_ReadMask;        // 0x11
        private System.Byte m_WriteMask;        // 0x12
        private System.Byte m_Padding;        // 0x13
        private System.Byte m_CompareFunctionFront;        // 0x14
        private System.Byte m_PassOperationFront;        // 0x15
        private System.Byte m_FailOperationFront;        // 0x16
        private System.Byte m_ZFailOperationFront;        // 0x17
        private System.Byte m_CompareFunctionBack;        // 0x18
        private System.Byte m_PassOperationBack;        // 0x19
        private System.Byte m_FailOperationBack;        // 0x1A
        private System.Byte m_ZFailOperationBack;        // 0x1B

        // Methods
        private System.Void set_enabled(System.Boolean value) { }
        private System.Void set_readMask(System.Byte value) { }
        private System.Void set_writeMask(System.Byte value) { }
        private System.Void set_compareFunctionFront(UnityEngine.Rendering.CompareFunction value) { }
        private System.Void set_passOperationFront(UnityEngine.Rendering.StencilOp value) { }
        private System.Void set_failOperationFront(UnityEngine.Rendering.StencilOp value) { }
        private System.Void set_zFailOperationFront(UnityEngine.Rendering.StencilOp value) { }
        private System.Void set_compareFunctionBack(UnityEngine.Rendering.CompareFunction value) { }
        private System.Void set_passOperationBack(UnityEngine.Rendering.StencilOp value) { }
        private System.Void set_failOperationBack(UnityEngine.Rendering.StencilOp value) { }
        private System.Void set_zFailOperationBack(UnityEngine.Rendering.StencilOp value) { }
        private System.Boolean Equals(UnityEngine.Rendering.StencilState other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000357
    public class SupportedRenderingFeatures
    {
        // Fields
        private static UnityEngine.Rendering.SupportedRenderingFeatures s_Active;        // 0x0
        private UnityEngine.Rendering.SupportedRenderingFeatures.ReflectionProbeModes <reflectionProbeModes>k__BackingField;        // 0x10
        private UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes <defaultMixedLightingModes>k__BackingField;        // 0x14
        private UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes <mixedLightingModes>k__BackingField;        // 0x18
        private UnityEngine.LightmapBakeType <lightmapBakeTypes>k__BackingField;        // 0x1C
        private UnityEngine.LightmapsMode <lightmapsModes>k__BackingField;        // 0x20
        private System.Boolean <enlightenLightmapper>k__BackingField;        // 0x24
        private System.Boolean <enlighten>k__BackingField;        // 0x25
        private System.Boolean <lightProbeProxyVolumes>k__BackingField;        // 0x26
        private System.Boolean <motionVectors>k__BackingField;        // 0x27
        private System.Boolean <receiveShadows>k__BackingField;        // 0x28
        private System.Boolean <reflectionProbes>k__BackingField;        // 0x29
        private System.Boolean <reflectionProbesBlendDistance>k__BackingField;        // 0x2A
        private System.Boolean <rendererPriority>k__BackingField;        // 0x2B
        private System.Boolean <rendersUIOverlay>k__BackingField;        // 0x2C
        private System.Boolean <overridesEnvironmentLighting>k__BackingField;        // 0x2D
        private System.Boolean <overridesFog>k__BackingField;        // 0x2E
        private System.Boolean <overridesRealtimeReflectionProbes>k__BackingField;        // 0x2F
        private System.Boolean <overridesOtherLightingSettings>k__BackingField;        // 0x30
        private System.Boolean <editableMaterialRenderQueue>k__BackingField;        // 0x31
        private System.Boolean <overridesLODBias>k__BackingField;        // 0x32
        private System.Boolean <overridesMaximumLODLevel>k__BackingField;        // 0x33
        private System.Boolean <rendererProbes>k__BackingField;        // 0x34
        private System.Boolean <particleSystemInstancing>k__BackingField;        // 0x35
        private System.Boolean <autoAmbientProbeBaking>k__BackingField;        // 0x36
        private System.Boolean <autoDefaultReflectionProbeBaking>k__BackingField;        // 0x37
        private System.Boolean <overridesShadowmask>k__BackingField;        // 0x38
        private System.String <overrideShadowmaskMessage>k__BackingField;        // 0x40

        // Methods
        private UnityEngine.Rendering.SupportedRenderingFeatures get_active() { }
        private System.Void set_active(UnityEngine.Rendering.SupportedRenderingFeatures value) { }
        private System.Void set_reflectionProbeModes(UnityEngine.Rendering.SupportedRenderingFeatures.ReflectionProbeModes value) { }
        private UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes get_defaultMixedLightingModes() { }
        private System.Void set_defaultMixedLightingModes(UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes value) { }
        private UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes get_mixedLightingModes() { }
        private System.Void set_mixedLightingModes(UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes value) { }
        private UnityEngine.LightmapBakeType get_lightmapBakeTypes() { }
        private System.Void set_lightmapBakeTypes(UnityEngine.LightmapBakeType value) { }
        private UnityEngine.LightmapsMode get_lightmapsModes() { }
        private System.Void set_lightmapsModes(UnityEngine.LightmapsMode value) { }
        private System.Boolean get_enlightenLightmapper() { }
        private System.Void set_enlightenLightmapper(System.Boolean value) { }
        private System.Boolean get_enlighten() { }
        private System.Void set_enlighten(System.Boolean value) { }
        private System.Void set_lightProbeProxyVolumes(System.Boolean value) { }
        private System.Void set_motionVectors(System.Boolean value) { }
        private System.Void set_receiveShadows(System.Boolean value) { }
        private System.Void set_reflectionProbes(System.Boolean value) { }
        private System.Void set_rendererPriority(System.Boolean value) { }
        private System.Boolean get_rendersUIOverlay() { }
        private System.Void set_rendersUIOverlay(System.Boolean value) { }
        private System.Void set_overridesFog(System.Boolean value) { }
        private System.Void set_overridesRealtimeReflectionProbes(System.Boolean value) { }
        private System.Void set_overridesOtherLightingSettings(System.Boolean value) { }
        private System.Void set_editableMaterialRenderQueue(System.Boolean value) { }
        private System.Void set_overridesLODBias(System.Boolean value) { }
        private System.Void set_overridesMaximumLODLevel(System.Boolean value) { }
        private System.Boolean get_autoAmbientProbeBaking() { }
        private System.Void set_autoAmbientProbeBaking(System.Boolean value) { }
        private System.Boolean get_autoDefaultReflectionProbeBaking() { }
        private System.Void set_autoDefaultReflectionProbeBaking(System.Boolean value) { }
        private System.Void set_overridesShadowmask(System.Boolean value) { }
        private System.Void set_overrideShadowmaskMessage(System.String value) { }
        private System.Void FallbackMixedLightingModeByRef(System.IntPtr fallbackModePtr) { }
        private System.Boolean IsMixedLightingModeSupported(UnityEngine.MixedLightingMode mixedMode) { }
        private System.Void IsMixedLightingModeSupportedByRef(UnityEngine.MixedLightingMode mixedMode, System.IntPtr isSupportedPtr) { }
        private System.Boolean IsLightmapBakeTypeSupported(UnityEngine.LightmapBakeType bakeType) { }
        private System.Void IsLightmapBakeTypeSupportedByRef(UnityEngine.LightmapBakeType bakeType, System.IntPtr isSupportedPtr) { }
        private System.Void IsLightmapsModeSupportedByRef(UnityEngine.LightmapsMode mode, System.IntPtr isSupportedPtr) { }
        private System.Void IsLightmapperSupportedByRef(System.Int32 lightmapper, System.IntPtr isSupportedPtr) { }
        private System.Void IsUIOverlayRenderedBySRP(System.IntPtr isSupportedPtr) { }
        private System.Void IsAutoAmbientProbeBakingSupported(System.IntPtr isSupportedPtr) { }
        private System.Void IsAutoDefaultReflectionProbeBakingSupported(System.IntPtr isSupportedPtr) { }
        private System.Void FallbackLightmapperByRef(System.IntPtr lightmapperPtr) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200035A
    public struct VisibleLight, IEquatable`1
    {
        // Fields
        private UnityEngine.LightType m_LightType;        // 0x10
        private UnityEngine.Color m_FinalColor;        // 0x14
        private UnityEngine.Rect m_ScreenRect;        // 0x24
        private UnityEngine.Matrix4x4 m_LocalToWorldMatrix;        // 0x34
        private System.Single m_SpecularIntensity;        // 0x74
        private System.Single m_Range;        // 0x78
        private System.Single m_SpotAngle;        // 0x7C
        private System.Int32 m_LightPriority;        // 0x80
        private UnityEngine.Vector3 m_WorldPosition;        // 0x84
        private System.Int32 m_InstanceId;        // 0x90
        private UnityEngine.Rendering.VisibleLightFlags m_Flags;        // 0x94
        public UnityEngine.HGSharedLightData hgSharedLightData;        // 0x98
        private System.Single m_ScreenSpaceArea;        // 0xA0

        // Methods
        private UnityEngine.Light get_light() { }
        private UnityEngine.LightType get_lightType() { }
        private UnityEngine.Color get_finalColor() { }
        private UnityEngine.Matrix4x4 get_localToWorldMatrix() { }
        private System.Single get_range() { }
        private System.Single get_spotAngle() { }
        private System.Int32 get_lightPriority() { }
        private UnityEngine.Vector3 get_worldPosition() { }
        private System.Boolean Equals(UnityEngine.Rendering.VisibleLight other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200035B
    public struct VisibleLightFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.VisibleLightFlags IntersectsNearPlane;        // 0x0
        public static UnityEngine.Rendering.VisibleLightFlags IntersectsFarPlane;        // 0x0

    }

    // TypeToken: 0x200035C
    public struct VisibleReflectionProbe, IEquatable`1
    {
        // Fields
        private UnityEngine.Bounds m_Bounds;        // 0x10
        private UnityEngine.Matrix4x4 m_LocalToWorldMatrix;        // 0x28
        private UnityEngine.Vector4 m_HdrData;        // 0x68
        private UnityEngine.Vector3 m_Center;        // 0x78
        private System.Single m_BlendDistance;        // 0x84
        private System.Int32 m_Importance;        // 0x88
        private System.Int32 m_BoxProjection;        // 0x8C
        private System.Int32 m_InstanceId;        // 0x90
        private System.Int32 m_TextureId;        // 0x94

        // Methods
        private System.Boolean Equals(UnityEngine.Rendering.VisibleReflectionProbe other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200035D
    public struct GlobalKeyword
    {
        // Fields
        private readonly System.String m_Name;        // 0x10
        private readonly System.UInt32 m_Index;        // 0x18

        // Methods
        private System.UInt32 GetGlobalKeywordCount() { }
        private System.UInt32 GetGlobalKeywordIndex(System.String keyword) { }
        private System.Void CreateGlobalKeyword(System.String keyword) { }
        private System.String get_name() { }
        private UnityEngine.Rendering.GlobalKeyword Create(System.String name) { }
        private System.Void .ctor(System.String name) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200035E
    public struct LocalKeyword, IEquatable`1
    {
        // Fields
        private readonly UnityEngine.Rendering.LocalKeywordSpace m_SpaceInfo;        // 0x10
        private readonly System.String m_Name;        // 0x18
        private readonly System.UInt32 m_Index;        // 0x20

        // Methods
        private System.UInt32 GetShaderKeywordCount(UnityEngine.Shader shader) { }
        private System.UInt32 GetShaderKeywordIndex(UnityEngine.Shader shader, System.String keyword) { }
        private System.UInt32 GetComputeShaderKeywordCount(UnityEngine.ComputeShader shader) { }
        private System.UInt32 GetComputeShaderKeywordIndex(UnityEngine.ComputeShader shader, System.String keyword) { }
        private System.Void .ctor(UnityEngine.Shader shader, System.String name) { }
        private System.Void .ctor(UnityEngine.ComputeShader shader, System.String name) { }
        private System.String ToString() { }
        private System.Boolean Equals(System.Object o) { }
        private System.Boolean Equals(UnityEngine.Rendering.LocalKeyword rhs) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200035F
    public struct LocalKeywordSpace, IEquatable`1
    {
        // Fields
        private readonly System.IntPtr m_KeywordSpace;        // 0x10

        // Methods
        private System.Boolean Equals(System.Object o) { }
        private System.Boolean Equals(UnityEngine.Rendering.LocalKeywordSpace rhs) { }
        private System.Boolean op_Equality(UnityEngine.Rendering.LocalKeywordSpace lhs, UnityEngine.Rendering.LocalKeywordSpace rhs) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000360
    public struct ShaderKeyword
    {
        // Fields
        private System.String m_Name;        // 0x10
        private System.UInt32 m_Index;        // 0x18
        private System.Boolean m_IsLocal;        // 0x1C
        private System.Boolean m_IsCompute;        // 0x1D
        private System.Boolean m_IsValid;        // 0x1E

        // Methods
        private System.UInt32 GetGlobalKeywordCount() { }
        private System.UInt32 GetGlobalKeywordIndex(System.String keyword) { }
        private System.Void CreateGlobalKeyword(System.String keyword) { }
        private System.Void .ctor(System.String keywordName) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000361
    public struct ShaderPropertyType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.ShaderPropertyType Color;        // 0x0
        public static UnityEngine.Rendering.ShaderPropertyType Vector;        // 0x0
        public static UnityEngine.Rendering.ShaderPropertyType Float;        // 0x0
        public static UnityEngine.Rendering.ShaderPropertyType Range;        // 0x0
        public static UnityEngine.Rendering.ShaderPropertyType Texture;        // 0x0
        public static UnityEngine.Rendering.ShaderPropertyType Int;        // 0x0

    }

    // TypeToken: 0x2000362
    public struct ShaderPropertyFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.ShaderPropertyFlags None;        // 0x0
        public static UnityEngine.Rendering.ShaderPropertyFlags HideInInspector;        // 0x0
        public static UnityEngine.Rendering.ShaderPropertyFlags PerRendererData;        // 0x0
        public static UnityEngine.Rendering.ShaderPropertyFlags NoScaleOffset;        // 0x0
        public static UnityEngine.Rendering.ShaderPropertyFlags Normal;        // 0x0
        public static UnityEngine.Rendering.ShaderPropertyFlags HDR;        // 0x0
        public static UnityEngine.Rendering.ShaderPropertyFlags Gamma;        // 0x0
        public static UnityEngine.Rendering.ShaderPropertyFlags NonModifiableTextureData;        // 0x0
        public static UnityEngine.Rendering.ShaderPropertyFlags MainTexture;        // 0x0
        public static UnityEngine.Rendering.ShaderPropertyFlags MainColor;        // 0x0

    }

}

namespace UnityEngine.Rendering.RendererUtils
{

    // TypeToken: 0x2000363
    public struct RendererListStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Rendering.RendererUtils.RendererListStatus kRendererListInvalid;        // 0x0
        public static UnityEngine.Rendering.RendererUtils.RendererListStatus kRendererListProcessing;        // 0x0
        public static UnityEngine.Rendering.RendererUtils.RendererListStatus kRendererListEmpty;        // 0x0
        public static UnityEngine.Rendering.RendererUtils.RendererListStatus kRendererListPopulated;        // 0x0

    }

    // TypeToken: 0x2000364
    public struct RendererList
    {
        // Fields
        private System.UIntPtr context;        // 0x10
        private System.UInt32 index;        // 0x18
        private System.UInt32 frame;        // 0x1C
        public static readonly UnityEngine.Rendering.RendererUtils.RendererList nullRendererList;        // 0x0

        // Methods
        private System.Boolean get_isValid() { }
        private System.Void .ctor(System.UIntPtr ctx, System.UInt32 indx) { }
        private System.Void .cctor() { }
        private System.Boolean get_isValid_Injected(UnityEngine.Rendering.RendererUtils.RendererList& _unity_self) { }

    }

    // TypeToken: 0x2000365
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
        public System.Single screenCullingRatio;        // 0xA4
        public System.Single screenRatioCullingDistance;        // 0xA8
        public System.UInt32 screenCullingLayerMask;        // 0xAC
        public System.Int16 sortingLayerMin;        // 0xB0
        public System.Int16 sortingLayerMax;        // 0xB2
        public System.Int16 sortingOrderMin;        // 0xB4
        public System.Int16 sortingOrderMax;        // 0xB6
        public System.UInt16 characterIndex;        // 0xB8
        public System.IntPtr drawableFeedbackPtr;        // 0xC0
        private UnityEngine.Rendering.CullingResults <cullingResult>k__BackingField;        // 0xC8
        private UnityEngine.Camera <camera>k__BackingField;        // 0xD8
        private UnityEngine.Rendering.ShaderTagId <passName>k__BackingField;        // 0xE0
        private UnityEngine.Rendering.ShaderTagId[] <passNames>k__BackingField;        // 0xE8

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

    // TypeToken: 0x2000366
    public struct RendererListParams
    {
        // Fields
        private static readonly UnityEngine.Rendering.ShaderTagId s_EmptyName;        // 0x0
        public static readonly UnityEngine.Rendering.RendererUtils.RendererListParams nullRendererList;        // 0x8
        private System.Boolean <isValid>k__BackingField;        // 0x10
        private UnityEngine.Rendering.CullingResults cullingResult;        // 0x18
        private UnityEngine.Rendering.DrawingSettings drawSettings;        // 0x28
        private UnityEngine.Rendering.FilteringSettings filteringSettings;        // 0x174
        private System.Nullable<UnityEngine.Rendering.RenderStateBlock> stateBlock;        // 0x194

        // Methods
        private System.Void set_isValid(System.Boolean value) { }
        private UnityEngine.Rendering.RendererUtils.RendererListParams Create(UnityEngine.Rendering.RendererUtils.RendererListDesc& desc) { }
        private System.Void .cctor() { }

    }

}

namespace UnityEngine.SceneManagement
{

    // TypeToken: 0x200022A
    public struct Scene
    {
        // Fields
        private System.Int32 m_Handle;        // 0x10

        // Methods
        private System.Boolean IsValidInternal(System.Int32 sceneHandle) { }
        private System.String GetPathInternal(System.Int32 sceneHandle) { }
        private System.String GetNameInternal(System.Int32 sceneHandle) { }
        private System.Void SetNameInternal(System.Int32 sceneHandle, System.String name) { }
        private System.String GetGUIDInternal(System.Int32 sceneHandle) { }
        private System.Boolean IsSubScene(System.Int32 sceneHandle) { }
        private System.Void SetIsSubScene(System.Int32 sceneHandle, System.Boolean value) { }
        private System.Boolean GetIsLoadedInternal(System.Int32 sceneHandle) { }
        private UnityEngine.SceneManagement.Scene.LoadingState GetLoadingStateInternal(System.Int32 sceneHandle) { }
        private System.Boolean GetIsDirtyInternal(System.Int32 sceneHandle) { }
        private System.Int32 GetDirtyID(System.Int32 sceneHandle) { }
        private System.Int32 GetBuildIndexInternal(System.Int32 sceneHandle) { }
        private System.Int32 GetRootCountInternal(System.Int32 sceneHandle) { }
        private System.Void GetRootGameObjectsInternal(System.Int32 sceneHandle, System.Object resultRootList) { }
        private System.Void .ctor(System.Int32 handle) { }
        private System.Int32 get_handle() { }
        private UnityEngine.SceneManagement.Scene.LoadingState get_loadingState() { }
        private System.String get_guid() { }
        private System.Boolean IsValid() { }
        private System.String get_path() { }
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private System.Boolean get_isLoaded() { }
        private System.Int32 get_buildIndex() { }
        private System.Boolean get_isDirty() { }
        private System.Int32 get_dirtyID() { }
        private System.Int32 get_rootCount() { }
        private System.Boolean get_isSubScene() { }
        private System.Void set_isSubScene(System.Boolean value) { }
        private UnityEngine.GameObject[] GetRootGameObjects() { }
        private System.Void GetRootGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> rootGameObjects) { }
        private System.Boolean op_Equality(UnityEngine.SceneManagement.Scene lhs, UnityEngine.SceneManagement.Scene rhs) { }
        private System.Boolean op_Inequality(UnityEngine.SceneManagement.Scene lhs, UnityEngine.SceneManagement.Scene rhs) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object other) { }

    }

    // TypeToken: 0x200022C
    public class SceneManagerAPIInternal
    {
        // Methods
        private System.Int32 GetNumScenesInBuildSettings() { }
        private UnityEngine.SceneManagement.Scene GetSceneByBuildIndex(System.Int32 buildIndex) { }
        private UnityEngine.AsyncOperation LoadSceneAsyncNameIndexInternal(System.String sceneName, System.Int32 sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters, System.Boolean mustCompleteNextFrame) { }
        private UnityEngine.AsyncOperation UnloadSceneNameIndexInternal(System.String sceneName, System.Int32 sceneBuildIndex, System.Boolean immediately, UnityEngine.SceneManagement.UnloadSceneOptions options, System.Boolean& outSuccess) { }
        private System.Void GetSceneByBuildIndex_Injected(System.Int32 buildIndex, UnityEngine.SceneManagement.Scene& ret) { }
        private UnityEngine.AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(System.String sceneName, System.Int32 sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters& parameters, System.Boolean mustCompleteNextFrame) { }

    }

    // TypeToken: 0x200022D
    public class SceneManagerAPI
    {
        // Fields
        private static UnityEngine.SceneManagement.SceneManagerAPI s_DefaultAPI;        // 0x0
        private static UnityEngine.SceneManagement.SceneManagerAPI <overrideAPI>k__BackingField;        // 0x8

        // Methods
        private UnityEngine.SceneManagement.SceneManagerAPI get_ActiveAPI() { }
        private UnityEngine.SceneManagement.SceneManagerAPI get_overrideAPI() { }
        private System.Void .ctor() { }
        private System.Int32 GetNumScenesInBuildSettings() { }
        private UnityEngine.SceneManagement.Scene GetSceneByBuildIndex(System.Int32 buildIndex) { }
        private UnityEngine.AsyncOperation LoadSceneAsyncByNameOrIndex(System.String sceneName, System.Int32 sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters, System.Boolean mustCompleteNextFrame) { }
        private UnityEngine.AsyncOperation UnloadSceneAsyncByNameOrIndex(System.String sceneName, System.Int32 sceneBuildIndex, System.Boolean immediately, UnityEngine.SceneManagement.UnloadSceneOptions options, System.Boolean& outSuccess) { }
        private UnityEngine.AsyncOperation LoadFirstScene(System.Boolean mustLoadAsync) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200022E
    public class SceneManager
    {
        // Fields
        private static System.Boolean s_AllowLoadScene;        // 0x0
        private static UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.LoadSceneMode> sceneLoaded;        // 0x8
        private static UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> sceneUnloaded;        // 0x10
        private static UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.Scene> activeSceneChanged;        // 0x18

        // Methods
        private System.Int32 get_sceneCount() { }
        private System.Int32 get_sceneCountInBuildSettings() { }
        private UnityEngine.SceneManagement.Scene GetActiveScene() { }
        private System.Boolean SetActiveScene(UnityEngine.SceneManagement.Scene scene) { }
        private UnityEngine.SceneManagement.Scene GetSceneByPath(System.String scenePath) { }
        private UnityEngine.SceneManagement.Scene GetSceneByName(System.String name) { }
        private UnityEngine.SceneManagement.Scene GetSceneByBuildIndex(System.Int32 buildIndex) { }
        private UnityEngine.SceneManagement.Scene GetSceneAt(System.Int32 index) { }
        private UnityEngine.SceneManagement.Scene CreateScene(System.String sceneName, UnityEngine.SceneManagement.CreateSceneParameters parameters) { }
        private System.Boolean UnloadSceneInternal(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.UnloadSceneOptions options) { }
        private UnityEngine.AsyncOperation UnloadSceneAsyncInternal(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.UnloadSceneOptions options) { }
        private UnityEngine.AsyncOperation LoadSceneAsyncNameIndexInternal(System.String sceneName, System.Int32 sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters, System.Boolean mustCompleteNextFrame) { }
        private UnityEngine.AsyncOperation UnloadSceneNameIndexInternal(System.String sceneName, System.Int32 sceneBuildIndex, System.Boolean immediately, UnityEngine.SceneManagement.UnloadSceneOptions options, System.Boolean& outSuccess) { }
        private System.Void MergeScenes(UnityEngine.SceneManagement.Scene sourceScene, UnityEngine.SceneManagement.Scene destinationScene) { }
        private System.Void MoveGameObjectToScene(UnityEngine.GameObject go, UnityEngine.SceneManagement.Scene scene) { }
        private UnityEngine.AsyncOperation LoadFirstScene_Internal(System.Boolean async) { }
        private System.Void add_sceneLoaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.LoadSceneMode> value) { }
        private System.Void remove_sceneLoaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.LoadSceneMode> value) { }
        private System.Void add_sceneUnloaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> value) { }
        private System.Void remove_sceneUnloaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> value) { }
        private System.Void add_activeSceneChanged(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.Scene> value) { }
        private System.Void remove_activeSceneChanged(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.Scene> value) { }
        private UnityEngine.SceneManagement.Scene[] GetAllScenes() { }
        private UnityEngine.SceneManagement.Scene CreateScene(System.String sceneName) { }
        private System.Void LoadScene(System.String sceneName, UnityEngine.SceneManagement.LoadSceneMode mode) { }
        private System.Void LoadScene(System.String sceneName) { }
        private UnityEngine.SceneManagement.Scene LoadScene(System.String sceneName, UnityEngine.SceneManagement.LoadSceneParameters parameters) { }
        private System.Void LoadScene(System.Int32 sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneMode mode) { }
        private System.Void LoadScene(System.Int32 sceneBuildIndex) { }
        private UnityEngine.SceneManagement.Scene LoadScene(System.Int32 sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters) { }
        private UnityEngine.AsyncOperation LoadSceneAsync(System.Int32 sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneMode mode) { }
        private UnityEngine.AsyncOperation LoadSceneAsync(System.Int32 sceneBuildIndex) { }
        private UnityEngine.AsyncOperation LoadSceneAsync(System.Int32 sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters) { }
        private UnityEngine.AsyncOperation LoadSceneAsync(System.String sceneName, UnityEngine.SceneManagement.LoadSceneMode mode) { }
        private UnityEngine.AsyncOperation LoadSceneAsync(System.String sceneName) { }
        private UnityEngine.AsyncOperation LoadSceneAsync(System.String sceneName, UnityEngine.SceneManagement.LoadSceneParameters parameters) { }
        private System.Boolean UnloadScene(UnityEngine.SceneManagement.Scene scene) { }
        private System.Boolean UnloadScene(System.Int32 sceneBuildIndex) { }
        private System.Boolean UnloadScene(System.String sceneName) { }
        private UnityEngine.AsyncOperation UnloadSceneAsync(System.Int32 sceneBuildIndex) { }
        private UnityEngine.AsyncOperation UnloadSceneAsync(System.String sceneName) { }
        private UnityEngine.AsyncOperation UnloadSceneAsync(UnityEngine.SceneManagement.Scene scene) { }
        private UnityEngine.AsyncOperation UnloadSceneAsync(System.Int32 sceneBuildIndex, UnityEngine.SceneManagement.UnloadSceneOptions options) { }
        private UnityEngine.AsyncOperation UnloadSceneAsync(System.String sceneName, UnityEngine.SceneManagement.UnloadSceneOptions options) { }
        private UnityEngine.AsyncOperation UnloadSceneAsync(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.UnloadSceneOptions options) { }
        private System.Void Internal_SceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode) { }
        private System.Void Internal_SceneUnloaded(UnityEngine.SceneManagement.Scene scene) { }
        private System.Void Internal_ActiveSceneChanged(UnityEngine.SceneManagement.Scene previousActiveScene, UnityEngine.SceneManagement.Scene newActiveScene) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }
        private System.Void GetActiveScene_Injected(UnityEngine.SceneManagement.Scene& ret) { }
        private System.Boolean SetActiveScene_Injected(UnityEngine.SceneManagement.Scene& scene) { }
        private System.Void GetSceneByPath_Injected(System.String scenePath, UnityEngine.SceneManagement.Scene& ret) { }
        private System.Void GetSceneByName_Injected(System.String name, UnityEngine.SceneManagement.Scene& ret) { }
        private System.Void GetSceneAt_Injected(System.Int32 index, UnityEngine.SceneManagement.Scene& ret) { }
        private System.Void CreateScene_Injected(System.String sceneName, UnityEngine.SceneManagement.CreateSceneParameters& parameters, UnityEngine.SceneManagement.Scene& ret) { }
        private System.Boolean UnloadSceneInternal_Injected(UnityEngine.SceneManagement.Scene& scene, UnityEngine.SceneManagement.UnloadSceneOptions options) { }
        private UnityEngine.AsyncOperation UnloadSceneAsyncInternal_Injected(UnityEngine.SceneManagement.Scene& scene, UnityEngine.SceneManagement.UnloadSceneOptions options) { }
        private System.Void MergeScenes_Injected(UnityEngine.SceneManagement.Scene& sourceScene, UnityEngine.SceneManagement.Scene& destinationScene) { }
        private System.Void MoveGameObjectToScene_Injected(UnityEngine.GameObject go, UnityEngine.SceneManagement.Scene& scene) { }

    }

    // TypeToken: 0x200022F
    public struct LoadSceneMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.SceneManagement.LoadSceneMode Single;        // 0x0
        public static UnityEngine.SceneManagement.LoadSceneMode Additive;        // 0x0

    }

    // TypeToken: 0x2000230
    public struct LocalPhysicsMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.SceneManagement.LocalPhysicsMode None;        // 0x0
        public static UnityEngine.SceneManagement.LocalPhysicsMode Physics2D;        // 0x0
        public static UnityEngine.SceneManagement.LocalPhysicsMode Physics3D;        // 0x0

    }

    // TypeToken: 0x2000231
    public struct LoadSceneParameters
    {
        // Fields
        private UnityEngine.SceneManagement.LoadSceneMode m_LoadSceneMode;        // 0x10
        private UnityEngine.SceneManagement.LocalPhysicsMode m_LocalPhysicsMode;        // 0x14

        // Methods
        private System.Void set_loadSceneMode(UnityEngine.SceneManagement.LoadSceneMode value) { }
        private System.Void .ctor(UnityEngine.SceneManagement.LoadSceneMode mode) { }

    }

    // TypeToken: 0x2000232
    public struct CreateSceneParameters
    {
        // Fields
        private UnityEngine.SceneManagement.LocalPhysicsMode m_LocalPhysicsMode;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.SceneManagement.LocalPhysicsMode physicsMode) { }

    }

    // TypeToken: 0x2000233
    public struct UnloadSceneOptions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.SceneManagement.UnloadSceneOptions None;        // 0x0
        public static UnityEngine.SceneManagement.UnloadSceneOptions UnloadAllEmbeddedSceneObjects;        // 0x0

    }

}

namespace UnityEngine.Scripting
{

    // TypeToken: 0x2000226
    public class AlwaysLinkAssemblyAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000227
    public class PreserveAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace UnityEngine.Scripting.APIUpdating
{

    // TypeToken: 0x2000228
    public struct MovedFromAttributeData
    {
        // Fields
        public System.String className;        // 0x10
        public System.String nameSpace;        // 0x18
        public System.String assembly;        // 0x20
        public System.Boolean classHasChanged;        // 0x28
        public System.Boolean nameSpaceHasChanged;        // 0x29
        public System.Boolean assemblyHasChanged;        // 0x2A
        public System.Boolean autoUdpateAPI;        // 0x2B

        // Methods
        private System.Void Set(System.Boolean autoUpdateAPI, System.String sourceNamespace, System.String sourceAssembly, System.String sourceClassName) { }

    }

    // TypeToken: 0x2000229
    public class MovedFromAttribute : Attribute
    {
        // Fields
        private UnityEngine.Scripting.APIUpdating.MovedFromAttributeData data;        // 0x10

        // Methods
        private System.Void .ctor(System.Boolean autoUpdateAPI, System.String sourceNamespace, System.String sourceAssembly, System.String sourceClassName) { }
        private System.Void .ctor(System.String sourceNamespace) { }

    }

}

namespace UnityEngine.Serialization
{

    // TypeToken: 0x2000225
    public class FormerlySerializedAsAttribute : Attribute
    {
        // Fields
        private System.String m_oldName;        // 0x10

        // Methods
        private System.Void .ctor(System.String oldName) { }

    }

}

namespace UnityEngine.Sprites
{

    // TypeToken: 0x20001D0
    public class DataUtility
    {
        // Methods
        private UnityEngine.Vector4 GetInnerUV(UnityEngine.Sprite sprite) { }
        private UnityEngine.Vector4 GetOuterUV(UnityEngine.Sprite sprite) { }
        private UnityEngine.Vector4 GetPadding(UnityEngine.Sprite sprite) { }
        private UnityEngine.Vector2 GetMinSize(UnityEngine.Sprite sprite) { }

    }

}

namespace UnityEngine.U2D
{

    // TypeToken: 0x20001D1
    public struct SpriteBone
    {
        // Fields
        private System.String m_Name;        // 0x10
        private System.String m_Guid;        // 0x18
        private UnityEngine.Vector3 m_Position;        // 0x20
        private UnityEngine.Quaternion m_Rotation;        // 0x2C
        private System.Single m_Length;        // 0x3C
        private System.Int32 m_ParentId;        // 0x40
        private UnityEngine.Color32 m_Color;        // 0x44

    }

    // TypeToken: 0x20001D2
    public class SpriteAtlasManager
    {
        // Fields
        private static System.Action<System.String,System.Action<UnityEngine.U2D.SpriteAtlas>> atlasRequested;        // 0x0
        private static System.Action<UnityEngine.U2D.SpriteAtlas> atlasRegistered;        // 0x8

        // Methods
        private System.Boolean RequestAtlas(System.String tag) { }
        private System.Void add_atlasRegistered(System.Action<UnityEngine.U2D.SpriteAtlas> value) { }
        private System.Void remove_atlasRegistered(System.Action<UnityEngine.U2D.SpriteAtlas> value) { }
        private System.Void PostRegisteredAtlas(UnityEngine.U2D.SpriteAtlas spriteAtlas) { }
        private System.Void Register(UnityEngine.U2D.SpriteAtlas spriteAtlas) { }

    }

    // TypeToken: 0x20001D3
    public class SpriteAtlas
    {
        // Methods
        private System.Boolean CanBindTo(UnityEngine.Sprite sprite) { }

    }

}

namespace UnityEngine.Windows
{

    // TypeToken: 0x20001E9
    public class Input
    {
        // Methods
        private System.Void ForwardRawInputImpl(System.UInt32* rawInputHeaderIndices, System.UInt32* rawInputDataIndices, System.UInt32 indicesCount, System.Byte* rawInputData, System.UInt32 rawInputDataSize) { }
        private System.Void ForwardRawInput(System.UInt32* rawInputHeaderIndices, System.UInt32* rawInputDataIndices, System.UInt32 indicesCount, System.Byte* rawInputData, System.UInt32 rawInputDataSize) { }

    }

}

namespace UnityEngine.Windows.Speech
{

    // TypeToken: 0x20001EA
    public class PhraseRecognitionSystem
    {
        // Fields
        private static UnityEngine.Windows.Speech.PhraseRecognitionSystem.ErrorDelegate OnError;        // 0x0
        private static UnityEngine.Windows.Speech.PhraseRecognitionSystem.StatusDelegate OnStatusChanged;        // 0x8

        // Methods
        private System.Void PhraseRecognitionSystem_InvokeErrorEvent(UnityEngine.Windows.Speech.SpeechError errorCode) { }
        private System.Void PhraseRecognitionSystem_InvokeStatusChangedEvent(UnityEngine.Windows.Speech.SpeechSystemStatus status) { }

    }

    // TypeToken: 0x20001ED
    public class PhraseRecognizer
    {
        // Fields
        protected System.IntPtr m_Recognizer;        // 0x10
        private UnityEngine.Windows.Speech.PhraseRecognizer.PhraseRecognizedDelegate OnPhraseRecognized;        // 0x18

        // Methods
        private System.Void InvokePhraseRecognizedEvent(System.String text, UnityEngine.Windows.Speech.ConfidenceLevel confidence, UnityEngine.Windows.Speech.SemanticMeaning[] semanticMeanings, System.Int64 phraseStartFileTime, System.Int64 phraseDurationTicks) { }
        private UnityEngine.Windows.Speech.SemanticMeaning[] MarshalSemanticMeaning(System.IntPtr keys, System.IntPtr values, System.IntPtr valueSizes, System.Int32 valueCount) { }

    }

    // TypeToken: 0x20001EF
    public class DictationRecognizer
    {
        // Fields
        private System.IntPtr m_Recognizer;        // 0x10
        private UnityEngine.Windows.Speech.DictationRecognizer.DictationHypothesisDelegate DictationHypothesis;        // 0x18
        private UnityEngine.Windows.Speech.DictationRecognizer.DictationResultDelegate DictationResult;        // 0x20
        private UnityEngine.Windows.Speech.DictationRecognizer.DictationCompletedDelegate DictationComplete;        // 0x28
        private UnityEngine.Windows.Speech.DictationRecognizer.DictationErrorHandler DictationError;        // 0x30

        // Methods
        private System.Void DictationRecognizer_InvokeHypothesisGeneratedEvent(System.String keyword) { }
        private System.Void DictationRecognizer_InvokeResultGeneratedEvent(System.String keyword, UnityEngine.Windows.Speech.ConfidenceLevel minimumConfidence) { }
        private System.Void DictationRecognizer_InvokeCompletedEvent(UnityEngine.Windows.Speech.DictationCompletionCause cause) { }
        private System.Void DictationRecognizer_InvokeErrorEvent(System.String error, System.Int32 hresult) { }

    }

    // TypeToken: 0x20001F4
    public struct ConfidenceLevel
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Windows.Speech.ConfidenceLevel High;        // 0x0
        public static UnityEngine.Windows.Speech.ConfidenceLevel Medium;        // 0x0
        public static UnityEngine.Windows.Speech.ConfidenceLevel Low;        // 0x0
        public static UnityEngine.Windows.Speech.ConfidenceLevel Rejected;        // 0x0

    }

    // TypeToken: 0x20001F5
    public struct SpeechSystemStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Windows.Speech.SpeechSystemStatus Stopped;        // 0x0
        public static UnityEngine.Windows.Speech.SpeechSystemStatus Running;        // 0x0
        public static UnityEngine.Windows.Speech.SpeechSystemStatus Failed;        // 0x0

    }

    // TypeToken: 0x20001F6
    public struct SpeechError
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Windows.Speech.SpeechError NoError;        // 0x0
        public static UnityEngine.Windows.Speech.SpeechError TopicLanguageNotSupported;        // 0x0
        public static UnityEngine.Windows.Speech.SpeechError GrammarLanguageMismatch;        // 0x0
        public static UnityEngine.Windows.Speech.SpeechError GrammarCompilationFailure;        // 0x0
        public static UnityEngine.Windows.Speech.SpeechError AudioQualityFailure;        // 0x0
        public static UnityEngine.Windows.Speech.SpeechError PauseLimitExceeded;        // 0x0
        public static UnityEngine.Windows.Speech.SpeechError TimeoutExceeded;        // 0x0
        public static UnityEngine.Windows.Speech.SpeechError NetworkFailure;        // 0x0
        public static UnityEngine.Windows.Speech.SpeechError MicrophoneUnavailable;        // 0x0
        public static UnityEngine.Windows.Speech.SpeechError UnknownError;        // 0x0

    }

    // TypeToken: 0x20001F7
    public struct DictationCompletionCause
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Windows.Speech.DictationCompletionCause Complete;        // 0x0
        public static UnityEngine.Windows.Speech.DictationCompletionCause AudioQualityFailure;        // 0x0
        public static UnityEngine.Windows.Speech.DictationCompletionCause Canceled;        // 0x0
        public static UnityEngine.Windows.Speech.DictationCompletionCause TimeoutExceeded;        // 0x0
        public static UnityEngine.Windows.Speech.DictationCompletionCause PauseLimitExceeded;        // 0x0
        public static UnityEngine.Windows.Speech.DictationCompletionCause NetworkFailure;        // 0x0
        public static UnityEngine.Windows.Speech.DictationCompletionCause MicrophoneUnavailable;        // 0x0
        public static UnityEngine.Windows.Speech.DictationCompletionCause UnknownError;        // 0x0

    }

    // TypeToken: 0x20001F8
    public struct SemanticMeaning
    {
        // Fields
        public System.String key;        // 0x10
        public System.String[] values;        // 0x18

    }

    // TypeToken: 0x20001F9
    public struct PhraseRecognizedEventArgs
    {
        // Fields
        public readonly UnityEngine.Windows.Speech.ConfidenceLevel confidence;        // 0x10
        public readonly UnityEngine.Windows.Speech.SemanticMeaning[] semanticMeanings;        // 0x18
        public readonly System.String text;        // 0x20
        public readonly System.DateTime phraseStartTime;        // 0x28
        public readonly System.TimeSpan phraseDuration;        // 0x30

        // Methods
        private System.Void .ctor(System.String text, UnityEngine.Windows.Speech.ConfidenceLevel confidence, UnityEngine.Windows.Speech.SemanticMeaning[] semanticMeanings, System.DateTime phraseStartTime, System.TimeSpan phraseDuration) { }

    }

}

namespace UnityEngine.Windows.WebCam
{

    // TypeToken: 0x20001FA
    public class PhotoCapture, IDisposable
    {
        // Fields
        private System.IntPtr m_NativePtr;        // 0x10
        private static readonly System.Int64 HR_SUCCESS;        // 0x0

        // Methods
        private UnityEngine.Windows.WebCam.PhotoCapture.PhotoCaptureResult MakeCaptureResult(System.Int64 hResult) { }
        private System.Void InvokeOnCreatedResourceDelegate(UnityEngine.Windows.WebCam.PhotoCapture.OnCaptureResourceCreatedCallback callback, System.IntPtr nativePtr) { }
        private System.Void .ctor(System.IntPtr nativeCaptureObject) { }
        private System.Void InvokeOnPhotoModeStartedDelegate(UnityEngine.Windows.WebCam.PhotoCapture.OnPhotoModeStartedCallback callback, System.Int64 hResult) { }
        private System.Void InvokeOnPhotoModeStoppedDelegate(UnityEngine.Windows.WebCam.PhotoCapture.OnPhotoModeStoppedCallback callback, System.Int64 hResult) { }
        private System.Void InvokeOnCapturedPhotoToDiskDelegate(UnityEngine.Windows.WebCam.PhotoCapture.OnCapturedToDiskCallback callback, System.Int64 hResult) { }
        private System.Void InvokeOnCapturedPhotoToMemoryDelegate(UnityEngine.Windows.WebCam.PhotoCapture.OnCapturedToMemoryCallback callback, System.Int64 hResult, System.IntPtr photoCaptureFramePtr) { }
        private System.Void Dispose() { }
        private System.Void Dispose_Internal() { }
        private System.Void Finalize() { }
        private System.Void DisposeThreaded_Internal() { }

    }

    // TypeToken: 0x2000202
    public class PhotoCaptureFrame, IDisposable
    {
        // Fields
        private System.IntPtr m_NativePtr;        // 0x10
        private System.Int32 <dataLength>k__BackingField;        // 0x18
        private System.Boolean <hasLocationData>k__BackingField;        // 0x1C
        private UnityEngine.Windows.WebCam.CapturePixelFormat <pixelFormat>k__BackingField;        // 0x20

        // Methods
        private System.Int32 get_dataLength() { }
        private System.Void set_dataLength(System.Int32 value) { }
        private System.Void set_hasLocationData(System.Boolean value) { }
        private System.Void set_pixelFormat(UnityEngine.Windows.WebCam.CapturePixelFormat value) { }
        private System.Int32 GetDataLength() { }
        private System.Boolean GetHasLocationData() { }
        private UnityEngine.Windows.WebCam.CapturePixelFormat GetCapturePixelFormat() { }
        private System.Void .ctor(System.IntPtr nativePtr) { }
        private System.Void Cleanup() { }
        private System.Void Dispose_Internal() { }
        private System.Void Dispose() { }
        private System.Void Finalize() { }

    }

    // TypeToken: 0x2000203
    public class VideoCapture, IDisposable
    {
        // Fields
        private System.IntPtr m_NativePtr;        // 0x10
        private static readonly System.Int64 HR_SUCCESS;        // 0x0

        // Methods
        private UnityEngine.Windows.WebCam.VideoCapture.VideoCaptureResult MakeCaptureResult(System.Int64 hResult) { }
        private System.Void InvokeOnCreatedVideoCaptureResourceDelegate(UnityEngine.Windows.WebCam.VideoCapture.OnVideoCaptureResourceCreatedCallback callback, System.IntPtr nativePtr) { }
        private System.Void .ctor(System.IntPtr nativeCaptureObject) { }
        private System.Void InvokeOnVideoModeStartedDelegate(UnityEngine.Windows.WebCam.VideoCapture.OnVideoModeStartedCallback callback, System.Int64 hResult) { }
        private System.Void InvokeOnVideoModeStoppedDelegate(UnityEngine.Windows.WebCam.VideoCapture.OnVideoModeStoppedCallback callback, System.Int64 hResult) { }
        private System.Void InvokeOnStartedRecordingVideoToDiskDelegate(UnityEngine.Windows.WebCam.VideoCapture.OnStartedRecordingVideoCallback callback, System.Int64 hResult) { }
        private System.Void InvokeOnStoppedRecordingVideoToDiskDelegate(UnityEngine.Windows.WebCam.VideoCapture.OnStoppedRecordingVideoCallback callback, System.Int64 hResult) { }
        private System.Void Dispose() { }
        private System.Void Dispose_Internal() { }
        private System.Void Finalize() { }
        private System.Void DisposeThreaded_Internal() { }

    }

    // TypeToken: 0x200020B
    public struct CapturePixelFormat
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Windows.WebCam.CapturePixelFormat BGRA32;        // 0x0
        public static UnityEngine.Windows.WebCam.CapturePixelFormat NV12;        // 0x0
        public static UnityEngine.Windows.WebCam.CapturePixelFormat JPEG;        // 0x0
        public static UnityEngine.Windows.WebCam.CapturePixelFormat PNG;        // 0x0

    }

}

namespace UnityEngine._Scripting.APIUpdating
{

    // TypeToken: 0x20001CF
    public class APIUpdaterRuntimeHelpers
    {
        // Methods
        private System.Boolean GetMovedFromAttributeDataForType(System.Type sourceType, System.String& assembly, System.String& nsp, System.String& klass) { }
        private System.Boolean GetObsoleteTypeRedirection(System.Type sourceType, System.String& assemblyName, System.String& nsp, System.String& className) { }

    }

}

namespace UnityEngineInternal
{

    // TypeToken: 0x2000006
    public struct LightmapType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngineInternal.LightmapType NoLightmap;        // 0x0
        public static UnityEngineInternal.LightmapType StaticLightmap;        // 0x0
        public static UnityEngineInternal.LightmapType DynamicLightmap;        // 0x0

    }

    // TypeToken: 0x2000007
    public struct MathfInternal
    {
        // Fields
        public static System.Single FloatMinNormal;        // 0x0
        public static System.Single FloatMinDenormal;        // 0x4
        public static System.Boolean IsFlushToZeroEnabled;        // 0x8

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000008
    public struct TypeInferenceRules
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngineInternal.TypeInferenceRules TypeReferencedByFirstArgument;        // 0x0
        public static UnityEngineInternal.TypeInferenceRules TypeReferencedBySecondArgument;        // 0x0
        public static UnityEngineInternal.TypeInferenceRules ArrayOfTypeReferencedByFirstArgument;        // 0x0
        public static UnityEngineInternal.TypeInferenceRules TypeOfFirstArgument;        // 0x0

    }

    // TypeToken: 0x2000009
    public class TypeInferenceRuleAttribute : Attribute
    {
        // Fields
        private readonly System.String _rule;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngineInternal.TypeInferenceRules rule) { }
        private System.Void .ctor(System.String rule) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200000A
    public class GenericStack : Stack
    {
        // Methods
        private System.Void .ctor() { }

    }

}

