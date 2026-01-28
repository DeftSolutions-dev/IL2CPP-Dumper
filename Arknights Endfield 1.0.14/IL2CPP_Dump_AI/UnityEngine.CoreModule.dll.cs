// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.CoreModule.dll
// Classes:  937
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: AutoScope
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
  private   readonly System.IntPtr                   m_Ptr  // 0x10
METHODS:
  System.Void .ctor(System.IntPtr markerPtr)
  System.Void Dispose()
END_CLASS

CLASS: ControlOptions
TYPE:  struct
TOKEN: 0x2000013
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.Profiling.ProfilerRecorder.ControlOptionsStart  // 0x0
  public    static  Unity.Profiling.ProfilerRecorder.ControlOptionsStop  // 0x0
  public    static  Unity.Profiling.ProfilerRecorder.ControlOptionsReset  // 0x0
  public    static  Unity.Profiling.ProfilerRecorder.ControlOptionsRelease  // 0x0
  public    static  Unity.Profiling.ProfilerRecorder.ControlOptionsSetFilterToCurrentThread  // 0x0
  public    static  Unity.Profiling.ProfilerRecorder.ControlOptionsSetToCollectFromAllThreads  // 0x0
METHODS:
END_CLASS

CLASS: CountOptions
TYPE:  struct
TOKEN: 0x2000014
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.Profiling.ProfilerRecorder.CountOptionsCount  // 0x0
  public    static  Unity.Profiling.ProfilerRecorder.CountOptionsMaxCount  // 0x0
METHODS:
END_CLASS

CLASS: ExecuteJobFunction
TYPE:  class
TOKEN: 0x2000020
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T& data, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex)
END_CLASS

CLASS: JobStruct`1
TYPE:  struct
TOKEN: 0x200001F
FIELDS:
  private   static readonly Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<System.IntPtr>jobReflectionData  // 0x0
METHODS:
  System.Void Initialize()
  System.Void Execute(T& data, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex)
  System.Void .cctor()
END_CLASS

CLASS: ExecuteJobFunction
TYPE:  class
TOKEN: 0x2000024
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T& data, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex)
END_CLASS

CLASS: ForJobStruct`1
TYPE:  struct
TOKEN: 0x2000023
FIELDS:
  private   static readonly Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<System.IntPtr>jobReflectionData  // 0x0
METHODS:
  System.Void Initialize()
  System.Void Execute(T& jobData, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex)
  System.Void .cctor()
END_CLASS

CLASS: ExecuteJobFunction
TYPE:  class
TOKEN: 0x2000028
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T& data, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex)
END_CLASS

CLASS: ParallelForJobStruct`1
TYPE:  struct
TOKEN: 0x2000027
FIELDS:
  public    static readonly System.IntPtr                   jobReflectionData  // 0x0
METHODS:
  System.Void Execute(T& jobData, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex)
  System.Void .cctor()
END_CLASS

CLASS: JobScheduleParameters
TYPE:  struct
TOKEN: 0x2000031
FIELDS:
  public            Unity.Jobs.JobHandle            Dependency  // 0x10
  public            System.Int32                    ScheduleMode  // 0x20
  public            System.IntPtr                   ReflectionData  // 0x28
  public            System.IntPtr                   JobDataPtr  // 0x30
METHODS:
  System.Void .ctor(System.Void* i_jobData, System.IntPtr i_reflectionData, Unity.Jobs.JobHandle i_dependency, Unity.Jobs.LowLevel.Unsafe.ScheduleMode i_scheduleMode)
END_CLASS

CLASS: PanicFunction_
TYPE:  class
TOKEN: 0x2000032
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x200004A
FIELDS:
  private           Unity.Collections.NativeArray<T>m_Array  // 0x0
  private           System.Int32                    m_Index  // 0x0
  private           T                               value  // 0x0
METHODS:
  System.Void .ctor(Unity.Collections.NativeArray<T>& array)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x200004C
FIELDS:
  private           Unity.Collections.NativeArray.ReadOnly<T>m_Array  // 0x0
  private           System.Int32                    m_Index  // 0x0
  private           T                               value  // 0x0
METHODS:
  System.Void .ctor(Unity.Collections.NativeArray.ReadOnly<T>& array)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: ReadOnly
TYPE:  struct
TOKEN: 0x200004B
FIELDS:
  private           System.Void*                    m_Buffer  // 0x0
  private           System.Int32                    m_Length  // 0x0
METHODS:
  System.Void .ctor(System.Void* buffer, System.Int32 length)
  T get_Item(System.Int32 index)
  Unity.Collections.NativeArray.ReadOnly.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000053
FIELDS:
  private           Unity.Collections.NativeSlice<T>m_Array  // 0x0
  private           System.Int32                    m_Index  // 0x0
METHODS:
  System.Void .ctor(Unity.Collections.NativeSlice<T>& array)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: SharedStatic`1
TYPE:  struct
TOKEN: 0x2000056
FIELDS:
  private   readonly System.Void*                    _buffer  // 0x0
METHODS:
  System.Void .ctor(System.Void* buffer)
  T& get_Data()
  Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<T> GetOrCreate(System.UInt32 alignment)
END_CLASS

CLASS: SharedStatic
TYPE:  class
TOKEN: 0x2000057
FIELDS:
METHODS:
  System.Void* GetOrCreateSharedStaticInternal(System.Int64 getHashCode64, System.Int64 getSubHashCode64, System.UInt32 sizeOf, System.UInt32 alignment)
END_CLASS

CLASS: HashCode64`1
TYPE:  struct
TOKEN: 0x2000059
FIELDS:
  public    static readonly System.Int64                    Value  // 0x0
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: IsUnmanagedCache`1
TYPE:  struct
TOKEN: 0x2000069
FIELDS:
  private   static  System.Int32                    value  // 0x0
METHODS:
END_CLASS

CLASS: AlignOfHelper`1
TYPE:  struct
TOKEN: 0x200006A
FIELDS:
  public            System.Byte                     dummy  // 0x0
  public            T                               data  // 0x0
METHODS:
END_CLASS

CLASS: BurstLogType
TYPE:  struct
TOKEN: 0x200006E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.Burst.LowLevel.BurstCompilerService.BurstLogTypeInfo  // 0x0
  public    static  Unity.Burst.LowLevel.BurstCompilerService.BurstLogTypeWarning  // 0x0
  public    static  Unity.Burst.LowLevel.BurstCompilerService.BurstLogTypeError  // 0x0
METHODS:
END_CLASS

CLASS: AdvertisingIdentifierCallback
TYPE:  class
TOKEN: 0x2000085
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.String advertisingId, System.Boolean trackingEnabled, System.String errorMsg)
END_CLASS

CLASS: LowMemoryCallback
TYPE:  class
TOKEN: 0x2000086
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
END_CLASS

CLASS: LogCallback
TYPE:  class
TOKEN: 0x2000087
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.String condition, System.String stackTrace, UnityEngine.LogType type)
END_CLASS

CLASS: ProjectionMatrixMode
TYPE:  struct
TOKEN: 0x2000093
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Camera.ProjectionMatrixModeExplicit  // 0x0
  public    static  UnityEngine.Camera.ProjectionMatrixModeImplicit  // 0x0
  public    static  UnityEngine.Camera.ProjectionMatrixModePhysicalPropertiesBased  // 0x0
METHODS:
END_CLASS

CLASS: GateFitMode
TYPE:  struct
TOKEN: 0x2000094
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Camera.GateFitMode  Vertical  // 0x0
  public    static  UnityEngine.Camera.GateFitMode  Horizontal  // 0x0
  public    static  UnityEngine.Camera.GateFitMode  Fill  // 0x0
  public    static  UnityEngine.Camera.GateFitMode  Overscan  // 0x0
  public    static  UnityEngine.Camera.GateFitMode  None  // 0x0
METHODS:
END_CLASS

CLASS: FieldOfViewAxis
TYPE:  struct
TOKEN: 0x2000095
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Camera.FieldOfViewAxisVertical  // 0x0
  public    static  UnityEngine.Camera.FieldOfViewAxisHorizontal  // 0x0
METHODS:
END_CLASS

CLASS: GateFitParameters
TYPE:  struct
TOKEN: 0x2000096
FIELDS:
  private           UnityEngine.Camera.GateFitMode  <mode>k__BackingField  // 0x10
  private           System.Single                   <aspect>k__BackingField  // 0x14
METHODS:
  UnityEngine.Camera.GateFitMode get_mode()
  System.Void set_mode(UnityEngine.Camera.GateFitMode value)
  System.Single get_aspect()
  System.Void set_aspect(System.Single value)
  System.Void .ctor(UnityEngine.Camera.GateFitMode mode, System.Single aspect)
END_CLASS

CLASS: StereoscopicEye
TYPE:  struct
TOKEN: 0x2000097
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Camera.StereoscopicEyeLeft  // 0x0
  public    static  UnityEngine.Camera.StereoscopicEyeRight  // 0x0
METHODS:
END_CLASS

CLASS: MonoOrStereoscopicEye
TYPE:  struct
TOKEN: 0x2000098
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Camera.MonoOrStereoscopicEyeLeft  // 0x0
  public    static  UnityEngine.Camera.MonoOrStereoscopicEyeRight  // 0x0
  public    static  UnityEngine.Camera.MonoOrStereoscopicEyeMono  // 0x0
METHODS:
END_CLASS

CLASS: SceneViewFilterMode
TYPE:  struct
TOKEN: 0x2000099
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Camera.SceneViewFilterModeOff  // 0x0
  public    static  UnityEngine.Camera.SceneViewFilterModeShowFiltered  // 0x0
METHODS:
END_CLASS

CLASS: RenderRequestMode
TYPE:  struct
TOKEN: 0x200009A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Camera.RenderRequestModeNone  // 0x0
  public    static  UnityEngine.Camera.RenderRequestModeObjectId  // 0x0
  public    static  UnityEngine.Camera.RenderRequestModeDepth  // 0x0
  public    static  UnityEngine.Camera.RenderRequestModeVertexNormal  // 0x0
  public    static  UnityEngine.Camera.RenderRequestModeWorldPosition  // 0x0
  public    static  UnityEngine.Camera.RenderRequestModeEntityId  // 0x0
  public    static  UnityEngine.Camera.RenderRequestModeBaseColor  // 0x0
  public    static  UnityEngine.Camera.RenderRequestModeSpecularColor  // 0x0
  public    static  UnityEngine.Camera.RenderRequestModeMetallic  // 0x0
  public    static  UnityEngine.Camera.RenderRequestModeEmission  // 0x0
  public    static  UnityEngine.Camera.RenderRequestModeNormal  // 0x0
  public    static  UnityEngine.Camera.RenderRequestModeSmoothness  // 0x0
  public    static  UnityEngine.Camera.RenderRequestModeOcclusion  // 0x0
  public    static  UnityEngine.Camera.RenderRequestModeDiffuseColor  // 0x0
METHODS:
END_CLASS

CLASS: RenderRequestOutputSpace
TYPE:  struct
TOKEN: 0x200009B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Camera.RenderRequestOutputSpaceScreenSpace  // 0x0
  public    static  UnityEngine.Camera.RenderRequestOutputSpaceUV0  // 0x0
  public    static  UnityEngine.Camera.RenderRequestOutputSpaceUV1  // 0x0
  public    static  UnityEngine.Camera.RenderRequestOutputSpaceUV2  // 0x0
  public    static  UnityEngine.Camera.RenderRequestOutputSpaceUV3  // 0x0
  public    static  UnityEngine.Camera.RenderRequestOutputSpaceUV4  // 0x0
  public    static  UnityEngine.Camera.RenderRequestOutputSpaceUV5  // 0x0
  public    static  UnityEngine.Camera.RenderRequestOutputSpaceUV6  // 0x0
  public    static  UnityEngine.Camera.RenderRequestOutputSpaceUV7  // 0x0
  public    static  UnityEngine.Camera.RenderRequestOutputSpaceUV8  // 0x0
METHODS:
END_CLASS

CLASS: RenderRequest
TYPE:  struct
TOKEN: 0x200009C
FIELDS:
  private   readonly UnityEngine.Camera.RenderRequestModem_CameraRenderMode  // 0x10
  private   readonly UnityEngine.RenderTexture       m_ResultRT  // 0x18
  private   readonly UnityEngine.Camera.RenderRequestOutputSpacem_OutputSpace  // 0x20
METHODS:
  System.Void .ctor(UnityEngine.Camera.RenderRequestMode mode, UnityEngine.RenderTexture rt)
  System.Void .ctor(UnityEngine.Camera.RenderRequestMode mode, UnityEngine.Camera.RenderRequestOutputSpace space, UnityEngine.RenderTexture rt)
  System.Boolean get_isValid()
  UnityEngine.Camera.RenderRequestMode get_mode()
  UnityEngine.RenderTexture get_result()
  UnityEngine.Camera.RenderRequestOutputSpace get_outputSpace()
END_CLASS

CLASS: CameraCallback
TYPE:  class
TOKEN: 0x200009D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Camera cam)
END_CLASS

CLASS: StateChanged
TYPE:  class
TOKEN: 0x20000A1
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.CullingGroupEvent sphere)
END_CLASS

CLASS: ReflectionProbeEvent
TYPE:  struct
TOKEN: 0x20000A4
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ReflectionProbe.ReflectionProbeEventReflectionProbeAdded  // 0x0
  public    static  UnityEngine.ReflectionProbe.ReflectionProbeEventReflectionProbeRemoved  // 0x0
  public    static  UnityEngine.ReflectionProbe.ReflectionProbeEventReflectionProbeTextureChanged  // 0x0
METHODS:
END_CLASS

CLASS: PositionEnumerator
TYPE:  struct
TOKEN: 0x20000AC
FIELDS:
  private   readonly UnityEngine.Vector3Int          _min  // 0x10
  private   readonly UnityEngine.Vector3Int          _max  // 0x1C
  private           UnityEngine.Vector3Int          _current  // 0x28
METHODS:
  System.Void .ctor(UnityEngine.Vector3Int min, UnityEngine.Vector3Int max)
  UnityEngine.BoundsInt.PositionEnumerator GetEnumerator()
  System.Boolean MoveNext()
  System.Void Reset()
  UnityEngine.Vector3Int get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void System.IDisposable.Dispose()
END_CLASS

CLASS: PositionEnumerator
TYPE:  struct
TOKEN: 0x20000B3
FIELDS:
  private   readonly UnityEngine.Vector2Int          _min  // 0x10
  private   readonly UnityEngine.Vector2Int          _max  // 0x18
  private           UnityEngine.Vector2Int          _current  // 0x20
METHODS:
  System.Void .ctor(UnityEngine.Vector2Int min, UnityEngine.Vector2Int max)
  UnityEngine.RectInt.PositionEnumerator GetEnumerator()
  System.Boolean MoveNext()
  System.Void Reset()
  UnityEngine.Vector2Int get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void System.IDisposable.Dispose()
END_CLASS

CLASS: OrderBlock
TYPE:  struct
TOKEN: 0x20000B9
FIELDS:
  private           System.Int32                    order  // 0x10
  private           UnityEngine.Events.UnityAction  callback  // 0x18
METHODS:
END_CLASS

CLASS: PreTransform
TYPE:  struct
TOKEN: 0x20000BC
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Display.PreTransformPreTransformIdentity  // 0x0
  public    static  UnityEngine.Display.PreTransformPreTransformRotate90  // 0x0
  public    static  UnityEngine.Display.PreTransformPreTransformRotate180  // 0x0
  public    static  UnityEngine.Display.PreTransformPreTransformRotate270  // 0x0
METHODS:
END_CLASS

CLASS: DisplaysUpdatedDelegate
TYPE:  class
TOKEN: 0x20000BD
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
END_CLASS

CLASS: Target
TYPE:  struct
TOKEN: 0x20000DA
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.GraphicsBuffer.TargetVertex  // 0x0
  public    static  UnityEngine.GraphicsBuffer.TargetIndex  // 0x0
  public    static  UnityEngine.GraphicsBuffer.TargetCopySource  // 0x0
  public    static  UnityEngine.GraphicsBuffer.TargetCopyDestination  // 0x0
  public    static  UnityEngine.GraphicsBuffer.TargetStructured  // 0x0
  public    static  UnityEngine.GraphicsBuffer.TargetRaw  // 0x0
  public    static  UnityEngine.GraphicsBuffer.TargetAppend  // 0x0
  public    static  UnityEngine.GraphicsBuffer.TargetCounter  // 0x0
  public    static  UnityEngine.GraphicsBuffer.TargetIndirectArguments  // 0x0
  public    static  UnityEngine.GraphicsBuffer.TargetConstant  // 0x0
METHODS:
END_CLASS

CLASS: MeshData
TYPE:  struct
TOKEN: 0x2000120
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
METHODS:
  System.Boolean HasVertexAttribute(System.IntPtr self, UnityEngine.Rendering.VertexAttribute attr)
  System.Int32 GetVertexCount(System.IntPtr self)
  System.Void CopyAttributeIntoPtr(System.IntPtr self, UnityEngine.Rendering.VertexAttribute attr, UnityEngine.Rendering.VertexAttributeFormat format, System.Int32 dim, System.IntPtr dst)
  System.Void CopyIndicesIntoPtr(System.IntPtr self, System.Int32 submesh, System.Boolean applyBaseVertex, System.Int32 dstStride, System.IntPtr dst)
  System.Int32 GetIndexCount(System.IntPtr self, System.Int32 submesh)
  System.Int32 GetSubMeshCount(System.IntPtr self)
  UnityEngine.Rendering.SubMeshDescriptor GetSubMesh(System.IntPtr self, System.Int32 index)
  System.Int32 get_vertexCount()
  System.Boolean HasVertexAttribute(UnityEngine.Rendering.VertexAttribute attr)
  System.Void GetVertices(Unity.Collections.NativeArray<UnityEngine.Vector3> outVertices)
  System.Void GetNormals(Unity.Collections.NativeArray<UnityEngine.Vector3> outNormals)
  System.Void GetTangents(Unity.Collections.NativeArray<UnityEngine.Vector4> outTangents)
  System.Void GetUVs(System.Int32 channel, Unity.Collections.NativeArray<UnityEngine.Vector2> outUVs)
  System.Void CopyAttributeInto(Unity.Collections.NativeArray<T> buffer, UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, System.Int32 dim)
  System.Void GetIndices(Unity.Collections.NativeArray<System.Int32> outIndices, System.Int32 submesh, System.Boolean applyBaseVertex)
  System.Int32 get_subMeshCount()
  UnityEngine.Rendering.SubMeshDescriptor GetSubMesh(System.Int32 index)
  System.Void GetSubMesh_Injected(System.IntPtr self, System.Int32 index, UnityEngine.Rendering.SubMeshDescriptor& ret)
END_CLASS

CLASS: MeshDataArray
TYPE:  struct
TOKEN: 0x2000121
FIELDS:
  private           System.IntPtr*                  m_Ptrs  // 0x10
  private           System.Int32                    m_Length  // 0x18
METHODS:
  System.Void AcquireReadOnlyMeshData(UnityEngine.Mesh mesh, System.IntPtr* datas)
  System.Void ReleaseMeshDatas(System.IntPtr* datas, System.Int32 count)
  System.Int32 get_Length()
  UnityEngine.Mesh.MeshData get_Item(System.Int32 index)
  System.Void Dispose()
  System.Void .ctor(UnityEngine.Mesh mesh, System.Boolean checkReadWrite)
END_CLASS

CLASS: EXRFlags
TYPE:  struct
TOKEN: 0x2000127
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Texture2D.EXRFlags  None  // 0x0
  public    static  UnityEngine.Texture2D.EXRFlags  OutputAsFloat  // 0x0
  public    static  UnityEngine.Texture2D.EXRFlags  CompressZIP  // 0x0
  public    static  UnityEngine.Texture2D.EXRFlags  CompressRLE  // 0x0
  public    static  UnityEngine.Texture2D.EXRFlags  CompressPIZ  // 0x0
METHODS:
END_CLASS

CLASS: U
TYPE:  struct
TOKEN: 0x2000133
FIELDS:
  public            System.Byte*                    p8  // 0x10
  public            System.UInt32*                  p32  // 0x10
  public            System.UInt64*                  p64  // 0x10
  public            System.UInt64                   i  // 0x10
METHODS:
  System.Void .ctor(System.UInt16* p8)
END_CLASS

CLASS: State
TYPE:  struct
TOKEN: 0x2000160
FIELDS:
  private           System.Int32                    s0  // 0x10
  private           System.Int32                    s1  // 0x14
  private           System.Int32                    s2  // 0x18
  private           System.Int32                    s3  // 0x1C
METHODS:
END_CLASS

CLASS: ResourcesCPUAffinity
TYPE:  struct
TOKEN: 0x2000165
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Resources.ResourcesCPUAffinitykPCoreAffinity  // 0x0
  public    static  UnityEngine.Resources.ResourcesCPUAffinitykECoreAffinity  // 0x0
METHODS:
END_CLASS

CLASS: TestClass
TYPE:  struct
TOKEN: 0x200018E
FIELDS:
  public            System.Int32                    value  // 0x10
METHODS:
END_CLASS

CLASS: CreateOptions
TYPE:  struct
TOKEN: 0x2000194
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextAsset.CreateOptionsNone  // 0x0
  public    static  UnityEngine.TextAsset.CreateOptionsCreateNativeObject  // 0x0
METHODS:
END_CLASS

CLASS: EncodingUtility
TYPE:  class
TOKEN: 0x2000195
FIELDS:
  private   static readonly System.Collections.Generic.KeyValuePair<System.Byte[],System.Text.Encoding>[]encodingLookup  // 0x0
  private   static readonly System.Text.Encoding            targetEncoding  // 0x8
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: WorkRequest
TYPE:  struct
TOKEN: 0x200019F
FIELDS:
  private   readonly System.Threading.SendOrPostCallbackm_DelagateCallback  // 0x10
  private   readonly System.Object                   m_DelagateState  // 0x18
  private   readonly System.Threading.ManualResetEventm_WaitHandle  // 0x20
METHODS:
  System.Void .ctor(System.Threading.SendOrPostCallback callback, System.Object state, System.Threading.ManualResetEvent waitHandle)
  System.Void Invoke()
END_CLASS

CLASS: GetLevelIdDelegate
TYPE:  class
TOKEN: 0x20001AF
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.String Invoke()
END_CLASS

CLASS: AutoDispatcher
TYPE:  class
TOKEN: 0x20001B1
FIELDS:
  private           UnityEngine.HGPsoWarmupCollectionm_Psoc  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.HGPsoWarmupCollection psoc)
  UnityEngine.HGPsoWarmupCollection.AutoDispatcher Create(UnityEngine.HGPsoWarmupCollection psoc)
  System.Void ScheduleIndex(System.Int32 index, System.Boolean background)
  System.Void Dispose()
END_CLASS

CLASS: Status
TYPE:  struct
TOKEN: 0x20001BD
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TouchScreenKeyboard.StatusVisible  // 0x0
  public    static  UnityEngine.TouchScreenKeyboard.StatusDone  // 0x0
  public    static  UnityEngine.TouchScreenKeyboard.StatusCanceled  // 0x0
  public    static  UnityEngine.TouchScreenKeyboard.StatusLostFocus  // 0x0
METHODS:
END_CLASS

CLASS: Edge
TYPE:  struct
TOKEN: 0x20001C3
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.RectTransform.Edge  Left  // 0x0
  public    static  UnityEngine.RectTransform.Edge  Right  // 0x0
  public    static  UnityEngine.RectTransform.Edge  Top  // 0x0
  public    static  UnityEngine.RectTransform.Edge  Bottom  // 0x0
METHODS:
END_CLASS

CLASS: Axis
TYPE:  struct
TOKEN: 0x20001C4
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.RectTransform.Axis  Horizontal  // 0x0
  public    static  UnityEngine.RectTransform.Axis  Vertical  // 0x0
METHODS:
END_CLASS

CLASS: ReapplyDrivenProperties
TYPE:  class
TOKEN: 0x20001C5
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.RectTransform driven)
END_CLASS

CLASS: Enumerator
TYPE:  class
TOKEN: 0x20001C8
FIELDS:
  private           UnityEngine.Transform           outer  // 0x10
  private           System.Int32                    currentIndex  // 0x18
METHODS:
  System.Void .ctor(UnityEngine.Transform outer)
  System.Object get_Current()
  System.Boolean MoveNext()
  System.Void Reset()
END_CLASS

CLASS: FinishFrameCallback
TYPE:  class
TOKEN: 0x20001D7
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Double frameTimeMS, System.Boolean overflow, System.IntPtr frameDataPtr, System.Int32 size)
END_CLASS

CLASS: TransformJobData
TYPE:  struct
TOKEN: 0x20001E2
FIELDS:
  public            System.IntPtr                   TransformAccessArray  // 0x0
  public            System.Int32                    IsReadOnly  // 0x0
METHODS:
END_CLASS

CLASS: ExecuteJobFunction
TYPE:  class
TOKEN: 0x20001E3
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T& jobData, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex)
END_CLASS

CLASS: TransformCrossFrameStruct`1
TYPE:  struct
TOKEN: 0x20001E1
FIELDS:
  public    static  System.IntPtr                   jobReflectionData  // 0x0
METHODS:
  System.IntPtr Initialize()
  System.Void Execute(T& jobData, System.IntPtr jobData2, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex)
END_CLASS

CLASS: TransformJobData
TYPE:  struct
TOKEN: 0x20001E5
FIELDS:
  public            System.IntPtr                   TransformAccessArray  // 0x0
  public            System.Int32                    IsReadOnly  // 0x0
METHODS:
END_CLASS

CLASS: ExecuteJobFunction
TYPE:  class
TOKEN: 0x20001E6
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T& jobData, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex)
END_CLASS

CLASS: TransformParallelForLoopStruct`1
TYPE:  struct
TOKEN: 0x20001E4
FIELDS:
  public    static  System.IntPtr                   jobReflectionData  // 0x0
METHODS:
  System.IntPtr Initialize()
  System.Void Execute(T& jobData, System.IntPtr jobData2, System.IntPtr bufferRangePatchData, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex)
END_CLASS

CLASS: ErrorDelegate
TYPE:  class
TOKEN: 0x20001EB
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Windows.Speech.SpeechError errorCode)
END_CLASS

CLASS: StatusDelegate
TYPE:  class
TOKEN: 0x20001EC
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Windows.Speech.SpeechSystemStatus status)
END_CLASS

CLASS: PhraseRecognizedDelegate
TYPE:  class
TOKEN: 0x20001EE
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Windows.Speech.PhraseRecognizedEventArgs args)
END_CLASS

CLASS: DictationHypothesisDelegate
TYPE:  class
TOKEN: 0x20001F0
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.String text)
END_CLASS

CLASS: DictationResultDelegate
TYPE:  class
TOKEN: 0x20001F1
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.String text, UnityEngine.Windows.Speech.ConfidenceLevel confidence)
END_CLASS

CLASS: DictationCompletedDelegate
TYPE:  class
TOKEN: 0x20001F2
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Windows.Speech.DictationCompletionCause cause)
END_CLASS

CLASS: DictationErrorHandler
TYPE:  class
TOKEN: 0x20001F3
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.String error, System.Int32 hresult)
END_CLASS

CLASS: CaptureResultType
TYPE:  struct
TOKEN: 0x20001FB
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Windows.WebCam.PhotoCapture.CaptureResultTypeSuccess  // 0x0
  public    static  UnityEngine.Windows.WebCam.PhotoCapture.CaptureResultTypeUnknownError  // 0x0
METHODS:
END_CLASS

CLASS: PhotoCaptureResult
TYPE:  struct
TOKEN: 0x20001FC
FIELDS:
  public            UnityEngine.Windows.WebCam.PhotoCapture.CaptureResultTyperesultType  // 0x10
  public            System.Int64                    hResult  // 0x18
METHODS:
END_CLASS

CLASS: OnCaptureResourceCreatedCallback
TYPE:  class
TOKEN: 0x20001FD
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Windows.WebCam.PhotoCapture captureObject)
END_CLASS

CLASS: OnPhotoModeStartedCallback
TYPE:  class
TOKEN: 0x20001FE
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Windows.WebCam.PhotoCapture.PhotoCaptureResult result)
END_CLASS

CLASS: OnPhotoModeStoppedCallback
TYPE:  class
TOKEN: 0x20001FF
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Windows.WebCam.PhotoCapture.PhotoCaptureResult result)
END_CLASS

CLASS: OnCapturedToDiskCallback
TYPE:  class
TOKEN: 0x2000200
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Windows.WebCam.PhotoCapture.PhotoCaptureResult result)
END_CLASS

CLASS: OnCapturedToMemoryCallback
TYPE:  class
TOKEN: 0x2000201
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Windows.WebCam.PhotoCapture.PhotoCaptureResult result, UnityEngine.Windows.WebCam.PhotoCaptureFrame photoCaptureFrame)
END_CLASS

CLASS: CaptureResultType
TYPE:  struct
TOKEN: 0x2000204
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Windows.WebCam.VideoCapture.CaptureResultTypeSuccess  // 0x0
  public    static  UnityEngine.Windows.WebCam.VideoCapture.CaptureResultTypeUnknownError  // 0x0
METHODS:
END_CLASS

CLASS: VideoCaptureResult
TYPE:  struct
TOKEN: 0x2000205
FIELDS:
  public            UnityEngine.Windows.WebCam.VideoCapture.CaptureResultTyperesultType  // 0x10
  public            System.Int64                    hResult  // 0x18
METHODS:
END_CLASS

CLASS: OnVideoCaptureResourceCreatedCallback
TYPE:  class
TOKEN: 0x2000206
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Windows.WebCam.VideoCapture captureObject)
END_CLASS

CLASS: OnVideoModeStartedCallback
TYPE:  class
TOKEN: 0x2000207
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Windows.WebCam.VideoCapture.VideoCaptureResult result)
END_CLASS

CLASS: OnVideoModeStoppedCallback
TYPE:  class
TOKEN: 0x2000208
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Windows.WebCam.VideoCapture.VideoCaptureResult result)
END_CLASS

CLASS: OnStartedRecordingVideoCallback
TYPE:  class
TOKEN: 0x2000209
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Windows.WebCam.VideoCapture.VideoCaptureResult result)
END_CLASS

CLASS: OnStoppedRecordingVideoCallback
TYPE:  class
TOKEN: 0x200020A
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Windows.WebCam.VideoCapture.VideoCaptureResult result)
END_CLASS

CLASS: LoadingState
TYPE:  struct
TOKEN: 0x200022B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.SceneManagement.Scene.LoadingStateNotLoaded  // 0x0
  public    static  UnityEngine.SceneManagement.Scene.LoadingStateLoading  // 0x0
  public    static  UnityEngine.SceneManagement.Scene.LoadingStateLoaded  // 0x0
  public    static  UnityEngine.SceneManagement.Scene.LoadingStateUnloading  // 0x0
METHODS:
END_CLASS

CLASS: UpdateFunction
TYPE:  class
TOKEN: 0x2000236
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
END_CLASS

CLASS: WaitForLastPresentationAndUpdateTime
TYPE:  struct
TOKEN: 0x2000239
FIELDS:
METHODS:
END_CLASS

CLASS: ProfilerStartFrame
TYPE:  struct
TOKEN: 0x200023B
FIELDS:
METHODS:
END_CLASS

CLASS: UpdateCameraMotionVectors
TYPE:  struct
TOKEN: 0x200023C
FIELDS:
METHODS:
END_CLASS

CLASS: DirectorSampleTime
TYPE:  struct
TOKEN: 0x200023D
FIELDS:
METHODS:
END_CLASS

CLASS: AsyncUploadTimeSlicedUpdate
TYPE:  struct
TOKEN: 0x200023E
FIELDS:
METHODS:
END_CLASS

CLASS: SynchronizeState
TYPE:  struct
TOKEN: 0x200023F
FIELDS:
METHODS:
END_CLASS

CLASS: SynchronizeInputs
TYPE:  struct
TOKEN: 0x2000240
FIELDS:
METHODS:
END_CLASS

CLASS: XREarlyUpdate
TYPE:  struct
TOKEN: 0x2000241
FIELDS:
METHODS:
END_CLASS

CLASS: PollPlayerConnection
TYPE:  struct
TOKEN: 0x2000243
FIELDS:
METHODS:
END_CLASS

CLASS: PollHtcsPlayerConnection
TYPE:  struct
TOKEN: 0x2000244
FIELDS:
METHODS:
END_CLASS

CLASS: GpuTimestamp
TYPE:  struct
TOKEN: 0x2000245
FIELDS:
METHODS:
END_CLASS

CLASS: AnalyticsCoreStatsUpdate
TYPE:  struct
TOKEN: 0x2000246
FIELDS:
METHODS:
END_CLASS

CLASS: UnityWebRequestUpdate
TYPE:  struct
TOKEN: 0x2000247
FIELDS:
METHODS:
END_CLASS

CLASS: UpdateStreamingManager
TYPE:  struct
TOKEN: 0x2000248
FIELDS:
METHODS:
END_CLASS

CLASS: ExecuteMainThreadJobs
TYPE:  struct
TOKEN: 0x2000249
FIELDS:
METHODS:
END_CLASS

CLASS: ProcessMouseInWindow
TYPE:  struct
TOKEN: 0x200024A
FIELDS:
METHODS:
END_CLASS

CLASS: ClearIntermediateRenderers
TYPE:  struct
TOKEN: 0x200024B
FIELDS:
METHODS:
END_CLASS

CLASS: ClearLines
TYPE:  struct
TOKEN: 0x200024C
FIELDS:
METHODS:
END_CLASS

CLASS: PresentBeforeUpdate
TYPE:  struct
TOKEN: 0x200024D
FIELDS:
METHODS:
END_CLASS

CLASS: ResetFrameStatsAfterPresent
TYPE:  struct
TOKEN: 0x200024E
FIELDS:
METHODS:
END_CLASS

CLASS: UpdateAsyncReadbackManager
TYPE:  struct
TOKEN: 0x200024F
FIELDS:
METHODS:
END_CLASS

CLASS: UpdateTextureStreamingManager
TYPE:  struct
TOKEN: 0x2000250
FIELDS:
METHODS:
END_CLASS

CLASS: HGGlobalGameManagerEarlyUpdate
TYPE:  struct
TOKEN: 0x2000251
FIELDS:
METHODS:
END_CLASS

CLASS: UpdatePreloading
TYPE:  struct
TOKEN: 0x2000252
FIELDS:
METHODS:
END_CLASS

CLASS: UpdateAsyncInstantiate
TYPE:  struct
TOKEN: 0x2000253
FIELDS:
METHODS:
END_CLASS

CLASS: RendererNotifyInvisible
TYPE:  struct
TOKEN: 0x2000254
FIELDS:
METHODS:
END_CLASS

CLASS: PlayerCleanupCachedData
TYPE:  struct
TOKEN: 0x2000255
FIELDS:
METHODS:
END_CLASS

CLASS: UpdateMainGameViewRect
TYPE:  struct
TOKEN: 0x2000256
FIELDS:
METHODS:
END_CLASS

CLASS: UpdateCanvasRectTransform
TYPE:  struct
TOKEN: 0x2000257
FIELDS:
METHODS:
END_CLASS

CLASS: UpdateInputManager
TYPE:  struct
TOKEN: 0x2000258
FIELDS:
METHODS:
END_CLASS

CLASS: ProcessRemoteInput
TYPE:  struct
TOKEN: 0x2000259
FIELDS:
METHODS:
END_CLASS

CLASS: XRUpdate
TYPE:  struct
TOKEN: 0x200025A
FIELDS:
METHODS:
END_CLASS

CLASS: ScriptRunDelayedStartupFrame
TYPE:  struct
TOKEN: 0x200025B
FIELDS:
METHODS:
END_CLASS

CLASS: UpdateKinect
TYPE:  struct
TOKEN: 0x200025C
FIELDS:
METHODS:
END_CLASS

CLASS: DeliverIosPlatformEvents
TYPE:  struct
TOKEN: 0x200025D
FIELDS:
METHODS:
END_CLASS

CLASS: DispatchEventQueueEvents
TYPE:  struct
TOKEN: 0x200025E
FIELDS:
METHODS:
END_CLASS

CLASS: PhysicsResetInterpolatedTransformPosition
TYPE:  struct
TOKEN: 0x200025F
FIELDS:
METHODS:
END_CLASS

CLASS: SpriteAtlasManagerUpdate
TYPE:  struct
TOKEN: 0x2000260
FIELDS:
METHODS:
END_CLASS

CLASS: TangoUpdate
TYPE:  struct
TOKEN: 0x2000261
FIELDS:
METHODS:
END_CLASS

CLASS: ARCoreUpdate
TYPE:  struct
TOKEN: 0x2000262
FIELDS:
METHODS:
END_CLASS

CLASS: PerformanceAnalyticsUpdate
TYPE:  struct
TOKEN: 0x2000263
FIELDS:
METHODS:
END_CLASS

CLASS: ClearLines
TYPE:  struct
TOKEN: 0x2000265
FIELDS:
METHODS:
END_CLASS

CLASS: DirectorFixedSampleTime
TYPE:  struct
TOKEN: 0x2000266
FIELDS:
METHODS:
END_CLASS

CLASS: AudioFixedUpdate
TYPE:  struct
TOKEN: 0x2000267
FIELDS:
METHODS:
END_CLASS

CLASS: ScriptRunBehaviourFixedUpdate
TYPE:  struct
TOKEN: 0x2000268
FIELDS:
METHODS:
END_CLASS

CLASS: DirectorFixedUpdate
TYPE:  struct
TOKEN: 0x2000269
FIELDS:
METHODS:
END_CLASS

CLASS: LegacyFixedAnimationUpdate
TYPE:  struct
TOKEN: 0x200026A
FIELDS:
METHODS:
END_CLASS

CLASS: XRFixedUpdate
TYPE:  struct
TOKEN: 0x200026B
FIELDS:
METHODS:
END_CLASS

CLASS: PhysicsFixedUpdate
TYPE:  struct
TOKEN: 0x200026C
FIELDS:
METHODS:
END_CLASS

CLASS: Physics2DFixedUpdate
TYPE:  struct
TOKEN: 0x200026D
FIELDS:
METHODS:
END_CLASS

CLASS: PhysicsClothFixedUpdate
TYPE:  struct
TOKEN: 0x200026E
FIELDS:
METHODS:
END_CLASS

CLASS: DirectorFixedUpdatePostPhysics
TYPE:  struct
TOKEN: 0x200026F
FIELDS:
METHODS:
END_CLASS

CLASS: ScriptRunDelayedFixedFrameRate
TYPE:  struct
TOKEN: 0x2000270
FIELDS:
METHODS:
END_CLASS

CLASS: NewInputFixedUpdate
TYPE:  struct
TOKEN: 0x2000271
FIELDS:
METHODS:
END_CLASS

CLASS: PhysicsUpdate
TYPE:  struct
TOKEN: 0x2000273
FIELDS:
METHODS:
END_CLASS

CLASS: Physics2DUpdate
TYPE:  struct
TOKEN: 0x2000274
FIELDS:
METHODS:
END_CLASS

CLASS: HGGlobalGameManagerPreGameplayUpdate
TYPE:  struct
TOKEN: 0x2000275
FIELDS:
METHODS:
END_CLASS

CLASS: CheckTexFieldInput
TYPE:  struct
TOKEN: 0x2000276
FIELDS:
METHODS:
END_CLASS

CLASS: IMGUISendQueuedEvents
TYPE:  struct
TOKEN: 0x2000277
FIELDS:
METHODS:
END_CLASS

CLASS: SendMouseEvents
TYPE:  struct
TOKEN: 0x2000278
FIELDS:
METHODS:
END_CLASS

CLASS: AIUpdate
TYPE:  struct
TOKEN: 0x2000279
FIELDS:
METHODS:
END_CLASS

CLASS: WindUpdate
TYPE:  struct
TOKEN: 0x200027A
FIELDS:
METHODS:
END_CLASS

CLASS: UpdateVideo
TYPE:  struct
TOKEN: 0x200027B
FIELDS:
METHODS:
END_CLASS

CLASS: NewInputUpdate
TYPE:  struct
TOKEN: 0x200027C
FIELDS:
METHODS:
END_CLASS

CLASS: DirectorPreUpdate
TYPE:  struct
TOKEN: 0x200027D
FIELDS:
METHODS:
END_CLASS

CLASS: ScriptRunBehaviourUpdate
TYPE:  struct
TOKEN: 0x200027F
FIELDS:
METHODS:
END_CLASS

CLASS: HGGlobalGameManagerGameplayUpdate
TYPE:  struct
TOKEN: 0x2000280
FIELDS:
METHODS:
END_CLASS

CLASS: DirectorUpdate
TYPE:  struct
TOKEN: 0x2000281
FIELDS:
METHODS:
END_CLASS

CLASS: ScriptRunDelayedDynamicFrameRate
TYPE:  struct
TOKEN: 0x2000282
FIELDS:
METHODS:
END_CLASS

CLASS: ScriptRunDelayedTasks
TYPE:  struct
TOKEN: 0x2000283
FIELDS:
METHODS:
END_CLASS

CLASS: HGGlobalGameManagerPreLateUpdate
TYPE:  struct
TOKEN: 0x2000285
FIELDS:
METHODS:
END_CLASS

CLASS: Physics2DLateUpdate
TYPE:  struct
TOKEN: 0x2000286
FIELDS:
METHODS:
END_CLASS

CLASS: AIUpdatePostScript
TYPE:  struct
TOKEN: 0x2000287
FIELDS:
METHODS:
END_CLASS

CLASS: DirectorUpdateAnimationBegin
TYPE:  struct
TOKEN: 0x2000288
FIELDS:
METHODS:
END_CLASS

CLASS: LegacyAnimationUpdate
TYPE:  struct
TOKEN: 0x2000289
FIELDS:
METHODS:
END_CLASS

CLASS: DirectorUpdateAnimationEnd
TYPE:  struct
TOKEN: 0x200028A
FIELDS:
METHODS:
END_CLASS

CLASS: DirectorDeferredEvaluate
TYPE:  struct
TOKEN: 0x200028B
FIELDS:
METHODS:
END_CLASS

CLASS: UIElementsUpdatePanels
TYPE:  struct
TOKEN: 0x200028C
FIELDS:
METHODS:
END_CLASS

CLASS: UpdateNetworkManager
TYPE:  struct
TOKEN: 0x200028D
FIELDS:
METHODS:
END_CLASS

CLASS: UpdateMasterServerInterface
TYPE:  struct
TOKEN: 0x200028E
FIELDS:
METHODS:
END_CLASS

CLASS: UNetUpdate
TYPE:  struct
TOKEN: 0x200028F
FIELDS:
METHODS:
END_CLASS

CLASS: EndGraphicsJobsAfterScriptUpdate
TYPE:  struct
TOKEN: 0x2000290
FIELDS:
METHODS:
END_CLASS

CLASS: ParticleSystemBeginUpdateAll
TYPE:  struct
TOKEN: 0x2000291
FIELDS:
METHODS:
END_CLASS

CLASS: ScriptRunBehaviourLateUpdate
TYPE:  struct
TOKEN: 0x2000292
FIELDS:
METHODS:
END_CLASS

CLASS: UIAtlasManagerUpdate
TYPE:  struct
TOKEN: 0x2000293
FIELDS:
METHODS:
END_CLASS

CLASS: ConstraintManagerUpdate
TYPE:  struct
TOKEN: 0x2000294
FIELDS:
METHODS:
END_CLASS

CLASS: PlayerSendFrameStarted
TYPE:  struct
TOKEN: 0x2000296
FIELDS:
METHODS:
END_CLASS

CLASS: UpdateRectTransform
TYPE:  struct
TOKEN: 0x2000297
FIELDS:
METHODS:
END_CLASS

CLASS: UpdateCanvasRectTransform
TYPE:  struct
TOKEN: 0x2000298
FIELDS:
METHODS:
END_CLASS

CLASS: PlayerUpdateCanvases
TYPE:  struct
TOKEN: 0x2000299
FIELDS:
METHODS:
END_CLASS

CLASS: UpdateAudio
TYPE:  struct
TOKEN: 0x200029A
FIELDS:
METHODS:
END_CLASS

CLASS: UpdateVideo
TYPE:  struct
TOKEN: 0x200029B
FIELDS:
METHODS:
END_CLASS

CLASS: DirectorLateUpdate
TYPE:  struct
TOKEN: 0x200029C
FIELDS:
METHODS:
END_CLASS

CLASS: ScriptRunDelayedDynamicFrameRate
TYPE:  struct
TOKEN: 0x200029D
FIELDS:
METHODS:
END_CLASS

CLASS: VFXUpdate
TYPE:  struct
TOKEN: 0x200029E
FIELDS:
METHODS:
END_CLASS

CLASS: ParticleSystemEndUpdateAll
TYPE:  struct
TOKEN: 0x200029F
FIELDS:
METHODS:
END_CLASS

CLASS: EndGraphicsJobsAfterScriptLateUpdate
TYPE:  struct
TOKEN: 0x20002A0
FIELDS:
METHODS:
END_CLASS

CLASS: UpdateSubstance
TYPE:  struct
TOKEN: 0x20002A1
FIELDS:
METHODS:
END_CLASS

CLASS: UpdateCustomRenderTextures
TYPE:  struct
TOKEN: 0x20002A2
FIELDS:
METHODS:
END_CLASS

CLASS: XRPostLateUpdate
TYPE:  struct
TOKEN: 0x20002A3
FIELDS:
METHODS:
END_CLASS

CLASS: UpdateAllRenderers
TYPE:  struct
TOKEN: 0x20002A4
FIELDS:
METHODS:
END_CLASS

CLASS: HGGlobalGameManagerLateUpdate
TYPE:  struct
TOKEN: 0x20002A5
FIELDS:
METHODS:
END_CLASS

CLASS: HGGlobalGameManagerPostLateUpdate
TYPE:  struct
TOKEN: 0x20002A6
FIELDS:
METHODS:
END_CLASS

CLASS: HGGlobalGameManagerPipelineUpdate
TYPE:  struct
TOKEN: 0x20002A7
FIELDS:
METHODS:
END_CLASS

CLASS: HGGlobalGameManagerUpdateAfterTransformSyncToEcs
TYPE:  struct
TOKEN: 0x20002A8
FIELDS:
METHODS:
END_CLASS

CLASS: UpdateLightProbeProxyVolumes
TYPE:  struct
TOKEN: 0x20002A9
FIELDS:
METHODS:
END_CLASS

CLASS: EnlightenRuntimeUpdate
TYPE:  struct
TOKEN: 0x20002AA
FIELDS:
METHODS:
END_CLASS

CLASS: UpdateAllSkinnedMeshes
TYPE:  struct
TOKEN: 0x20002AB
FIELDS:
METHODS:
END_CLASS

CLASS: ProcessWebSendMessages
TYPE:  struct
TOKEN: 0x20002AC
FIELDS:
METHODS:
END_CLASS

CLASS: SortingGroupsUpdate
TYPE:  struct
TOKEN: 0x20002AD
FIELDS:
METHODS:
END_CLASS

CLASS: UpdateVideoTextures
TYPE:  struct
TOKEN: 0x20002AE
FIELDS:
METHODS:
END_CLASS

CLASS: DirectorRenderImage
TYPE:  struct
TOKEN: 0x20002AF
FIELDS:
METHODS:
END_CLASS

CLASS: PlayerEmitCanvasGeometry
TYPE:  struct
TOKEN: 0x20002B0
FIELDS:
METHODS:
END_CLASS

CLASS: PlayerRenderUIEBatchModeOffscreen
TYPE:  struct
TOKEN: 0x20002B1
FIELDS:
METHODS:
END_CLASS

CLASS: FinishFrameRendering
TYPE:  struct
TOKEN: 0x20002B2
FIELDS:
METHODS:
END_CLASS

CLASS: BatchModeUpdate
TYPE:  struct
TOKEN: 0x20002B3
FIELDS:
METHODS:
END_CLASS

CLASS: PlayerSendFrameComplete
TYPE:  struct
TOKEN: 0x20002B4
FIELDS:
METHODS:
END_CLASS

CLASS: UpdateCaptureScreenshot
TYPE:  struct
TOKEN: 0x20002B5
FIELDS:
METHODS:
END_CLASS

CLASS: PresentAfterDraw
TYPE:  struct
TOKEN: 0x20002B6
FIELDS:
METHODS:
END_CLASS

CLASS: ClearImmediateRenderers
TYPE:  struct
TOKEN: 0x20002B7
FIELDS:
METHODS:
END_CLASS

CLASS: XRPostPresent
TYPE:  struct
TOKEN: 0x20002B8
FIELDS:
METHODS:
END_CLASS

CLASS: UpdateResolution
TYPE:  struct
TOKEN: 0x20002B9
FIELDS:
METHODS:
END_CLASS

CLASS: InputEndFrame
TYPE:  struct
TOKEN: 0x20002BA
FIELDS:
METHODS:
END_CLASS

CLASS: GUIClearEvents
TYPE:  struct
TOKEN: 0x20002BB
FIELDS:
METHODS:
END_CLASS

CLASS: ShaderHandleErrors
TYPE:  struct
TOKEN: 0x20002BC
FIELDS:
METHODS:
END_CLASS

CLASS: ResetInputAxis
TYPE:  struct
TOKEN: 0x20002BD
FIELDS:
METHODS:
END_CLASS

CLASS: ThreadedLoadingDebug
TYPE:  struct
TOKEN: 0x20002BE
FIELDS:
METHODS:
END_CLASS

CLASS: ProfilerSynchronizeStats
TYPE:  struct
TOKEN: 0x20002BF
FIELDS:
METHODS:
END_CLASS

CLASS: MemoryFrameMaintenance
TYPE:  struct
TOKEN: 0x20002C0
FIELDS:
METHODS:
END_CLASS

CLASS: ExecuteGameCenterCallbacks
TYPE:  struct
TOKEN: 0x20002C1
FIELDS:
METHODS:
END_CLASS

CLASS: XRPreEndFrame
TYPE:  struct
TOKEN: 0x20002C2
FIELDS:
METHODS:
END_CLASS

CLASS: ProfilerEndFrame
TYPE:  struct
TOKEN: 0x20002C3
FIELDS:
METHODS:
END_CLASS

CLASS: GraphicsWarmupPreloadedShaders
TYPE:  struct
TOKEN: 0x20002C4
FIELDS:
METHODS:
END_CLASS

CLASS: PlayerSendFramePostPresent
TYPE:  struct
TOKEN: 0x20002C5
FIELDS:
METHODS:
END_CLASS

CLASS: PhysicsSkinnedClothBeginUpdate
TYPE:  struct
TOKEN: 0x20002C6
FIELDS:
METHODS:
END_CLASS

CLASS: PhysicsSkinnedClothFinishUpdate
TYPE:  struct
TOKEN: 0x20002C7
FIELDS:
METHODS:
END_CLASS

CLASS: DirectorManagerNextFrameEnd
TYPE:  struct
TOKEN: 0x20002C8
FIELDS:
METHODS:
END_CLASS

CLASS: TriggerEndOfFrameCallbacks
TYPE:  struct
TOKEN: 0x20002C9
FIELDS:
METHODS:
END_CLASS

CLASS: WaitForLastPresentationAndUpdateTimeAfterFrame
TYPE:  struct
TOKEN: 0x20002CA
FIELDS:
METHODS:
END_CLASS

CLASS: HGGlobalGameManagerPreParticleUpdate
TYPE:  struct
TOKEN: 0x20002CB
FIELDS:
METHODS:
END_CLASS

CLASS: MessageEvent
TYPE:  class
TOKEN: 0x20002D8
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ConnectionChangeEvent
TYPE:  class
TOKEN: 0x20002D9
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: MessageTypeSubscribers
TYPE:  class
TOKEN: 0x20002DA
FIELDS:
  private           System.String                   m_messageTypeId  // 0x10
  public            System.Int32                    subscriberCount  // 0x18
  public            UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageEventmessageCallback  // 0x20
METHODS:
  System.Guid get_MessageTypeId()
  System.Void set_MessageTypeId(System.Guid value)
  System.Void .ctor()
END_CLASS

CLASS: OnPerformCulling
TYPE:  class
TOKEN: 0x200032C
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  Unity.Jobs.JobHandle Invoke(UnityEngine.Rendering.BatchRendererGroup rendererGroup, UnityEngine.Rendering.BatchCullingContext cullingContext)
END_CLASS

CLASS: ReflectionProbeModes
TYPE:  struct
TOKEN: 0x2000358
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.SupportedRenderingFeatures.ReflectionProbeModesNone  // 0x0
  public    static  UnityEngine.Rendering.SupportedRenderingFeatures.ReflectionProbeModesRotation  // 0x0
METHODS:
END_CLASS

CLASS: LightmapMixedBakeModes
TYPE:  struct
TOKEN: 0x2000359
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModesNone  // 0x0
  public    static  UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModesIndirectOnly  // 0x0
  public    static  UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModesSubtractive  // 0x0
  public    static  UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModesShadowmask  // 0x0
METHODS:
END_CLASS

CLASS: Flags
TYPE:  struct
TOKEN: 0x2000368
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Playables.FrameData.FlagsEvaluate  // 0x0
  public    static  UnityEngine.Playables.FrameData.FlagsSeekOccured  // 0x0
  public    static  UnityEngine.Playables.FrameData.FlagsLoop  // 0x0
  public    static  UnityEngine.Playables.FrameData.FlagsHold  // 0x0
  public    static  UnityEngine.Playables.FrameData.FlagsEffectivePlayStateDelayed  // 0x0
  public    static  UnityEngine.Playables.FrameData.FlagsEffectivePlayStatePlaying  // 0x0
METHODS:
END_CLASS

CLASS: EvaluationType
TYPE:  struct
TOKEN: 0x2000369
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Playables.FrameData.EvaluationTypeEvaluate  // 0x0
  public    static  UnityEngine.Playables.FrameData.EvaluationTypePlayback  // 0x0
METHODS:
END_CLASS

CLASS: CreateOutputMethod
TYPE:  class
TOKEN: 0x2000376
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  UnityEngine.Playables.PlayableOutput Invoke(UnityEngine.Playables.PlayableGraph graph, System.String name)
END_CLASS

CLASS: RequestLightsDelegate
TYPE:  class
TOKEN: 0x2000397
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Light[] requests, Unity.Collections.NativeArray<UnityEngine.Experimental.GlobalIllumination.LightDataGI> lightsOutput)
END_CLASS

CLASS: AOT.MonoPInvokeCallbackAttribute
TYPE:  class
TOKEN: 0x2000005
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor(System.Type type)
END_CLASS

CLASS: JetBrains.Annotations.CanBeNullAttribute
TYPE:  class
TOKEN: 0x200006F
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: JetBrains.Annotations.NotNullAttribute
TYPE:  class
TOKEN: 0x2000070
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: JetBrains.Annotations.MeansImplicitUseAttribute
TYPE:  class
TOKEN: 0x2000071
EXTENDS: Attribute
FIELDS:
  private   readonly JetBrains.Annotations.ImplicitUseKindFlags<UseKindFlags>k__BackingField  // 0x10
  private   readonly JetBrains.Annotations.ImplicitUseTargetFlags<TargetFlags>k__BackingField  // 0x14
METHODS:
  System.Void .ctor()
  System.Void .ctor(JetBrains.Annotations.ImplicitUseKindFlags useKindFlags, JetBrains.Annotations.ImplicitUseTargetFlags targetFlags)
END_CLASS

CLASS: JetBrains.Annotations.ImplicitUseKindFlags
TYPE:  struct
TOKEN: 0x2000072
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  JetBrains.Annotations.ImplicitUseKindFlagsDefault  // 0x0
  public    static  JetBrains.Annotations.ImplicitUseKindFlagsAccess  // 0x0
  public    static  JetBrains.Annotations.ImplicitUseKindFlagsAssign  // 0x0
  public    static  JetBrains.Annotations.ImplicitUseKindFlagsInstantiatedWithFixedConstructorSignature  // 0x0
  public    static  JetBrains.Annotations.ImplicitUseKindFlagsInstantiatedNoFixedConstructorSignature  // 0x0
METHODS:
END_CLASS

CLASS: JetBrains.Annotations.ImplicitUseTargetFlags
TYPE:  struct
TOKEN: 0x2000073
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  JetBrains.Annotations.ImplicitUseTargetFlagsDefault  // 0x0
  public    static  JetBrains.Annotations.ImplicitUseTargetFlagsItself  // 0x0
  public    static  JetBrains.Annotations.ImplicitUseTargetFlagsMembers  // 0x0
  public    static  JetBrains.Annotations.ImplicitUseTargetFlagsWithMembers  // 0x0
METHODS:
END_CLASS

CLASS: JetBrains.Annotations.PureAttribute
TYPE:  class
TOKEN: 0x2000074
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: JetBrains.Annotations.MustUseReturnValueAttribute
TYPE:  class
TOKEN: 0x2000075
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: JetBrains.Annotations.NoEnumerationAttribute
TYPE:  class
TOKEN: 0x2000076
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Microsoft.CodeAnalysis.EmbeddedAttribute
TYPE:  class
TOKEN: 0x2000002
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Runtime.CompilerServices.IsReadOnlyAttribute
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Runtime.CompilerServices.IsUnmanagedAttribute
TYPE:  class
TOKEN: 0x2000004
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Burst.BurstAuthorizedExternalMethodAttribute
TYPE:  class
TOKEN: 0x200006B
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Burst.BurstDiscardAttribute
TYPE:  class
TOKEN: 0x200006C
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Burst.LowLevel.BurstCompilerService
TYPE:  class
TOKEN: 0x200006D
FIELDS:
METHODS:
  System.Int32 CompileAsyncDelegateMethod(System.Object delegateMethod, System.String compilerOptions)
  System.Void* GetAsyncCompiledAsyncDelegateMethod(System.Int32 userID)
  System.Void* GetOrCreateSharedMemory(UnityEngine.Hash128& key, System.UInt32 size_of, System.UInt32 alignment)
  System.Void Log(System.Void* userData, Unity.Burst.LowLevel.BurstCompilerService.BurstLogType logType, System.Byte* message, System.Byte* filename, System.Int32 lineNumber)
END_CLASS

CLASS: Unity.Collections.ReadOnlyAttribute
TYPE:  class
TOKEN: 0x200003F
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Collections.WriteOnlyAttribute
TYPE:  class
TOKEN: 0x2000040
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Collections.DeallocateOnJobCompletionAttribute
TYPE:  class
TOKEN: 0x2000041
EXTENDS: Attribute
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Collections.NativeFixedLengthAttribute
TYPE:  class
TOKEN: 0x2000042
EXTENDS: Attribute
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Collections.NativeMatchesParallelForLengthAttribute
TYPE:  class
TOKEN: 0x2000043
EXTENDS: Attribute
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Collections.NativeDisableParallelForRestrictionAttribute
TYPE:  class
TOKEN: 0x2000044
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Collections.Allocator
TYPE:  struct
TOKEN: 0x2000045
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.Collections.Allocator     Invalid  // 0x0
  public    static  Unity.Collections.Allocator     None  // 0x0
  public    static  Unity.Collections.Allocator     Temp  // 0x0
  public    static  Unity.Collections.Allocator     TempJob  // 0x0
  public    static  Unity.Collections.Allocator     Persistent  // 0x0
  public    static  Unity.Collections.Allocator     AudioKernel  // 0x0
METHODS:
END_CLASS

CLASS: Unity.Collections.LeakCategory
TYPE:  struct
TOKEN: 0x2000046
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.Collections.LeakCategory  Invalid  // 0x0
  public    static  Unity.Collections.LeakCategory  Malloc  // 0x0
  public    static  Unity.Collections.LeakCategory  TempJob  // 0x0
  public    static  Unity.Collections.LeakCategory  Persistent  // 0x0
  public    static  Unity.Collections.LeakCategory  LightProbesQuery  // 0x0
  public    static  Unity.Collections.LeakCategory  NativeTest  // 0x0
  public    static  Unity.Collections.LeakCategory  MeshDataArray  // 0x0
  public    static  Unity.Collections.LeakCategory  TransformAccessArray  // 0x0
  public    static  Unity.Collections.LeakCategory  NavMeshQuery  // 0x0
METHODS:
END_CLASS

CLASS: Unity.Collections.NativeLeakDetection
TYPE:  class
TOKEN: 0x2000047
FIELDS:
  private   static  System.Int32                    s_NativeLeakDetectionMode  // 0x0
METHODS:
  System.Void Initialize()
END_CLASS

CLASS: Unity.Collections.NativeArrayOptions
TYPE:  struct
TOKEN: 0x2000048
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.Collections.NativeArrayOptionsUninitializedMemory  // 0x0
  public    static  Unity.Collections.NativeArrayOptionsClearMemory  // 0x0
METHODS:
END_CLASS

CLASS: Unity.Collections.NativeArray`1
TYPE:  struct
TOKEN: 0x2000049
FIELDS:
  private           System.Void*                    m_Buffer  // 0x0
  private           System.Int32                    m_Length  // 0x0
  private           Unity.Collections.Allocator     m_AllocatorLabel  // 0x0
METHODS:
  System.Void .ctor(System.Int32 length, Unity.Collections.Allocator allocator, Unity.Collections.NativeArrayOptions options)
  System.Void .ctor(T[] array, Unity.Collections.Allocator allocator)
  System.Void .ctor(Unity.Collections.NativeArray<T> array, Unity.Collections.Allocator allocator)
  System.Void Allocate(System.Int32 length, Unity.Collections.Allocator allocator, Unity.Collections.NativeArray<T>& array)
  System.Int32 get_Length()
  T get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, T value)
  System.Boolean get_IsCreated()
  System.Void Dispose()
  Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps)
  System.Void CopyFrom(T[] array)
  System.Void CopyFrom(Unity.Collections.NativeArray<T> array)
  T[] ToArray()
  Unity.Collections.NativeArray.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Boolean Equals(Unity.Collections.NativeArray<T> other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Void Copy(Unity.Collections.NativeArray<T> src, Unity.Collections.NativeArray<T> dst)
  System.Void Copy(T[] src, Unity.Collections.NativeArray<T> dst)
  System.Void Copy(Unity.Collections.NativeArray<T> src, T[] dst)
  System.Void Copy(Unity.Collections.NativeArray<T> src, Unity.Collections.NativeArray<T> dst, System.Int32 length)
  System.Void Copy(Unity.Collections.NativeArray<T> src, T[] dst, System.Int32 length)
  System.Void Copy(Unity.Collections.NativeArray<T> src, System.Int32 srcIndex, Unity.Collections.NativeArray<T> dst, System.Int32 dstIndex, System.Int32 length)
  System.Void Copy(T[] src, System.Int32 srcIndex, Unity.Collections.NativeArray<T> dst, System.Int32 dstIndex, System.Int32 length)
  System.Void Copy(Unity.Collections.NativeArray<T> src, System.Int32 srcIndex, T[] dst, System.Int32 dstIndex, System.Int32 length)
  System.Void ReinterpretStore(System.Int32 destIndex, U data)
  Unity.Collections.NativeArray<U> InternalReinterpret(System.Int32 length)
  Unity.Collections.NativeArray<U> Reinterpret()
  Unity.Collections.NativeArray<T> GetSubArray(System.Int32 start, System.Int32 length)
  Unity.Collections.NativeArray.ReadOnly<T> AsReadOnly()
END_CLASS

CLASS: Unity.Collections.NativeArrayDispose
TYPE:  struct
TOKEN: 0x200004D
FIELDS:
  private           System.Void*                    m_Buffer  // 0x10
  private           Unity.Collections.Allocator     m_AllocatorLabel  // 0x18
METHODS:
  System.Void Dispose()
END_CLASS

CLASS: Unity.Collections.NativeArrayDisposeJob
TYPE:  struct
TOKEN: 0x200004E
FIELDS:
  private           Unity.Collections.NativeArrayDisposeData  // 0x10
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Unity.Collections.NativeArrayDebugView`1
TYPE:  class
TOKEN: 0x200004F
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Collections.NativeArrayReadOnlyDebugView`1
TYPE:  class
TOKEN: 0x2000050
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Collections.NativeSliceExtensions
TYPE:  class
TOKEN: 0x2000051
FIELDS:
METHODS:
  Unity.Collections.NativeSlice<T> Slice(Unity.Collections.NativeArray<T> thisArray, System.Int32 start, System.Int32 length)
  Unity.Collections.NativeSlice<T> Slice(Unity.Collections.NativeSlice<T> thisSlice, System.Int32 start, System.Int32 length)
END_CLASS

CLASS: Unity.Collections.NativeSlice`1
TYPE:  struct
TOKEN: 0x2000052
FIELDS:
  private           System.Byte*                    m_Buffer  // 0x0
  private           System.Int32                    m_Stride  // 0x0
  private           System.Int32                    m_Length  // 0x0
METHODS:
  System.Void .ctor(Unity.Collections.NativeSlice<T> slice, System.Int32 start, System.Int32 length)
  System.Void .ctor(Unity.Collections.NativeArray<T> array)
  Unity.Collections.NativeSlice<T> op_Implicit(Unity.Collections.NativeArray<T> array)
  System.Void .ctor(Unity.Collections.NativeArray<T> array, System.Int32 start, System.Int32 length)
  Unity.Collections.NativeSlice<U> SliceConvert()
  T get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, T value)
  System.Void CopyFrom(Unity.Collections.NativeSlice<T> slice)
  System.Void CopyFrom(T[] array)
  System.Void CopyTo(Unity.Collections.NativeArray<T> array)
  System.Void CopyTo(T[] array)
  System.Int32 get_Stride()
  System.Int32 get_Length()
  Unity.Collections.NativeSlice.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Boolean Equals(Unity.Collections.NativeSlice<T> other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean op_Inequality(Unity.Collections.NativeSlice<T> left, Unity.Collections.NativeSlice<T> right)
END_CLASS

CLASS: Unity.Collections.NativeSliceDebugView`1
TYPE:  class
TOKEN: 0x2000054
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.BurstLike
TYPE:  class
TOKEN: 0x2000055
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.BurstRuntime
TYPE:  class
TOKEN: 0x2000058
FIELDS:
METHODS:
  System.Int64 GetHashCode64()
  System.Int64 HashStringWithFNV1A64(System.String text)
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.NativeContainerAttribute
TYPE:  class
TOKEN: 0x200005A
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.NativeContainerIsReadOnlyAttribute
TYPE:  class
TOKEN: 0x200005B
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.NativeContainerIsAtomicWriteOnlyAttribute
TYPE:  class
TOKEN: 0x200005C
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.NativeContainerSupportsMinMaxWriteRestrictionAttribute
TYPE:  class
TOKEN: 0x200005D
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.NativeContainerSupportsDeallocateOnJobCompletionAttribute
TYPE:  class
TOKEN: 0x200005E
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.NativeContainerSupportsDeferredConvertListToArray
TYPE:  class
TOKEN: 0x200005F
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.NativeSetThreadIndexAttribute
TYPE:  class
TOKEN: 0x2000060
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.NativeContainerNeedsThreadIndexAttribute
TYPE:  class
TOKEN: 0x2000061
EXTENDS: Attribute
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.WriteAccessRequiredAttribute
TYPE:  class
TOKEN: 0x2000062
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.NativeDisableUnsafePtrRestrictionAttribute
TYPE:  class
TOKEN: 0x2000063
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.NativeDisableContainerSafetyRestrictionAttribute
TYPE:  class
TOKEN: 0x2000064
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.NativeSetClassTypeToNullOnScheduleAttribute
TYPE:  class
TOKEN: 0x2000065
EXTENDS: Attribute
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility
TYPE:  class
TOKEN: 0x2000066
FIELDS:
METHODS:
  Unity.Collections.NativeArray<T> ConvertExistingDataToNativeArray(System.Void* dataPointer, System.Int32 length, Unity.Collections.Allocator allocator)
  System.Void* GetUnsafePtr(Unity.Collections.NativeArray<T> nativeArray)
  System.Void* GetUnsafeReadOnlyPtr(Unity.Collections.NativeArray<T> nativeArray)
  System.Void* GetUnsafeBufferPointerWithoutChecks(Unity.Collections.NativeArray<T> nativeArray)
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.NativeSliceUnsafeUtility
TYPE:  class
TOKEN: 0x2000067
FIELDS:
METHODS:
  Unity.Collections.NativeSlice<T> ConvertExistingDataToNativeSlice(System.Void* dataPointer, System.Int32 stride, System.Int32 length)
  System.Void* GetUnsafePtr(Unity.Collections.NativeSlice<T> nativeSlice)
  System.Void* GetUnsafeReadOnlyPtr(Unity.Collections.NativeSlice<T> nativeSlice)
END_CLASS

CLASS: Unity.Collections.LowLevel.Unsafe.UnsafeUtility
TYPE:  class
TOKEN: 0x2000068
FIELDS:
METHODS:
  System.Int32 GetFieldOffsetInStruct(System.Reflection.FieldInfo field)
  System.Int32 GetFieldOffsetInClass(System.Reflection.FieldInfo field)
  System.Int32 GetFieldOffset(System.Reflection.FieldInfo field)
  System.Void* PinGCObjectAndGetAddress(System.Object target, System.UInt64& gcHandle)
  System.Void* PinGCArrayAndGetDataAddress(System.Array target, System.UInt64& gcHandle)
  System.Void* PinSystemArrayAndGetAddress(System.Object target, System.UInt64& gcHandle)
  System.Void* PinSystemObjectAndGetAddress(System.Object target, System.UInt64& gcHandle)
  System.Void ReleaseGCObject(System.UInt64 gcHandle)
  System.Boolean IsBlittable()
  System.Int32 LeakRecord(System.IntPtr handle, Unity.Collections.LeakCategory category, System.Int32 callstacksToSkip)
  System.Int32 LeakErase(System.IntPtr handle, Unity.Collections.LeakCategory category)
  System.Void* MallocTracked(System.Int64 size, System.Int32 alignment, Unity.Collections.Allocator allocator, System.Int32 callstacksToSkip)
  System.Void FreeTracked(System.Void* memory, Unity.Collections.Allocator allocator)
  System.Void* Malloc(System.Int64 size, System.Int32 alignment, Unity.Collections.Allocator allocator)
  System.Void Free(System.Void* memory, Unity.Collections.Allocator allocator)
  System.Void MemCpy(System.Void* destination, System.Void* source, System.Int64 size)
  System.Void MemCpyStride(System.Void* destination, System.Int32 destinationStride, System.Void* source, System.Int32 sourceStride, System.Int32 elementSize, System.Int32 count)
  System.Void MemMove(System.Void* destination, System.Void* source, System.Int64 size)
  System.Void MemSet(System.Void* destination, System.Byte value, System.Int64 size)
  System.Void MemClear(System.Void* destination, System.Int64 size)
  System.Int32 MemCmp(System.Void* ptr1, System.Void* ptr2, System.Int64 size)
  System.Int32 SizeOf(System.Type type)
  System.Boolean IsBlittable(System.Type type)
  System.Boolean IsUnmanaged(System.Type type)
  System.Boolean IsBlittableValueType(System.Type t)
  System.String GetReasonForTypeNonBlittableImpl(System.Type t, System.String name)
  System.Boolean IsArrayBlittable(System.Array arr)
  System.Boolean IsGenericListBlittable()
  System.String GetReasonForArrayNonBlittable(System.Array arr)
  System.String GetReasonForGenericListNonBlittable()
  System.Boolean IsUnmanaged()
  System.Int32 AlignOf()
  System.Void CopyPtrToStructure(System.Void* ptr, T& output)
  System.Void InternalCopyPtrToStructure(System.Void* ptr, T& output)
  System.Void CopyStructureToPtr(T& input, System.Void* ptr)
  System.Void InternalCopyStructureToPtr(T& input, System.Void* ptr)
  T ReadArrayElement(System.Void* source, System.Int32 index)
  T ReadArrayElementWithStride(System.Void* source, System.Int32 index, System.Int32 stride)
  System.Void WriteArrayElement(System.Void* destination, System.Int32 index, T value)
  System.Void WriteArrayElementWithStride(System.Void* destination, System.Int32 index, System.Int32 stride, T value)
  System.Void* AddressOf(T& output)
  System.Int32 SizeOf()
  T& As(U& from)
  T& AsRef(System.Void* ptr)
  T& ArrayElementAsRef(System.Void* ptr, System.Int32 index)
  System.Int32 EnumToInt(T enumValue)
  System.Void InternalEnumToInt(T& enumValue, System.Int32& intValue)
  System.Boolean EnumEquals(T lhs, T rhs)
END_CLASS

CLASS: Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstructionAttribute
TYPE:  class
TOKEN: 0x2000033
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.IO.LowLevel.Unsafe.ReadCommand
TYPE:  struct
TOKEN: 0x2000034
FIELDS:
  public            System.Void*                    Buffer  // 0x10
  public            System.Int64                    Offset  // 0x18
  public            System.Int64                    Size  // 0x20
METHODS:
END_CLASS

CLASS: Unity.IO.LowLevel.Unsafe.FileState
TYPE:  struct
TOKEN: 0x2000035
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.IO.LowLevel.Unsafe.FileStateAbsent  // 0x0
  public    static  Unity.IO.LowLevel.Unsafe.FileStateExists  // 0x0
METHODS:
END_CLASS

CLASS: Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem
TYPE:  struct
TOKEN: 0x2000036
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystemOther  // 0x0
  public    static  Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystemTexture  // 0x0
  public    static  Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystemVirtualTexture  // 0x0
  public    static  Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystemMesh  // 0x0
  public    static  Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystemAudio  // 0x0
  public    static  Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystemScripts  // 0x0
  public    static  Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystemEntitiesScene  // 0x0
  public    static  Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystemEntitiesStreamBinaryReader  // 0x0
  public    static  Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystemFileInfo  // 0x0
METHODS:
END_CLASS

CLASS: Unity.IO.LowLevel.Unsafe.ReadStatus
TYPE:  struct
TOKEN: 0x2000037
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.IO.LowLevel.Unsafe.ReadStatusComplete  // 0x0
  public    static  Unity.IO.LowLevel.Unsafe.ReadStatusInProgress  // 0x0
  public    static  Unity.IO.LowLevel.Unsafe.ReadStatusFailed  // 0x0
  public    static  Unity.IO.LowLevel.Unsafe.ReadStatusTruncated  // 0x0
  public    static  Unity.IO.LowLevel.Unsafe.ReadStatusCanceled  // 0x0
METHODS:
END_CLASS

CLASS: Unity.IO.LowLevel.Unsafe.Priority
TYPE:  struct
TOKEN: 0x2000038
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.IO.LowLevel.Unsafe.PriorityPriorityLow  // 0x0
  public    static  Unity.IO.LowLevel.Unsafe.PriorityPriorityHigh  // 0x0
METHODS:
END_CLASS

CLASS: Unity.IO.LowLevel.Unsafe.ReadHandle
TYPE:  struct
TOKEN: 0x2000039
FIELDS:
  private           System.IntPtr                   ptr  // 0x10
  private           System.Int32                    version  // 0x18
METHODS:
  System.Boolean IsValid()
  System.Void Dispose()
  Unity.Jobs.JobHandle get_JobHandle()
  Unity.IO.LowLevel.Unsafe.ReadStatus get_Status()
  Unity.IO.LowLevel.Unsafe.ReadStatus GetReadStatus(Unity.IO.LowLevel.Unsafe.ReadHandle handle)
  System.Void ReleaseReadHandle(Unity.IO.LowLevel.Unsafe.ReadHandle handle)
  System.Boolean IsReadHandleValid(Unity.IO.LowLevel.Unsafe.ReadHandle handle)
  Unity.Jobs.JobHandle GetJobHandle(Unity.IO.LowLevel.Unsafe.ReadHandle handle)
  Unity.IO.LowLevel.Unsafe.ReadStatus GetReadStatus_Injected(Unity.IO.LowLevel.Unsafe.ReadHandle& handle)
  System.Void ReleaseReadHandle_Injected(Unity.IO.LowLevel.Unsafe.ReadHandle& handle)
  System.Boolean IsReadHandleValid_Injected(Unity.IO.LowLevel.Unsafe.ReadHandle& handle)
  System.Void GetJobHandle_Injected(Unity.IO.LowLevel.Unsafe.ReadHandle& handle, Unity.Jobs.JobHandle& ret)
END_CLASS

CLASS: Unity.IO.LowLevel.Unsafe.AsyncReadManager
TYPE:  class
TOKEN: 0x200003A
FIELDS:
METHODS:
  Unity.IO.LowLevel.Unsafe.ReadHandle ReadInternal(System.String filename, System.Void* cmds, System.UInt32 cmdCount, System.String assetName, System.UInt64 typeID, Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem subsystem)
  Unity.IO.LowLevel.Unsafe.ReadHandle Read(System.String filename, Unity.IO.LowLevel.Unsafe.ReadCommand* readCmds, System.UInt32 readCmdCount, System.String assetName, System.UInt64 typeID, Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem subsystem)
  System.Void ReadInternal_Injected(System.String filename, System.Void* cmds, System.UInt32 cmdCount, System.String assetName, System.UInt64 typeID, Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem subsystem, Unity.IO.LowLevel.Unsafe.ReadHandle& ret)
END_CLASS

CLASS: Unity.IO.LowLevel.Unsafe.ProcessingState
TYPE:  struct
TOKEN: 0x200003B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.IO.LowLevel.Unsafe.ProcessingStateUnknown  // 0x0
  public    static  Unity.IO.LowLevel.Unsafe.ProcessingStateInQueue  // 0x0
  public    static  Unity.IO.LowLevel.Unsafe.ProcessingStateReading  // 0x0
  public    static  Unity.IO.LowLevel.Unsafe.ProcessingStateCompleted  // 0x0
  public    static  Unity.IO.LowLevel.Unsafe.ProcessingStateFailed  // 0x0
  public    static  Unity.IO.LowLevel.Unsafe.ProcessingStateCanceled  // 0x0
METHODS:
END_CLASS

CLASS: Unity.IO.LowLevel.Unsafe.FileReadType
TYPE:  struct
TOKEN: 0x200003C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.IO.LowLevel.Unsafe.FileReadTypeSync  // 0x0
  public    static  Unity.IO.LowLevel.Unsafe.FileReadTypeAsync  // 0x0
METHODS:
END_CLASS

CLASS: Unity.IO.LowLevel.Unsafe.AsyncReadManagerRequestMetric
TYPE:  struct
TOKEN: 0x200003D
FIELDS:
  private   readonly System.String                   <AssetName>k__BackingField  // 0x10
  private   readonly System.String                   <FileName>k__BackingField  // 0x18
  private   readonly System.UInt64                   <OffsetBytes>k__BackingField  // 0x20
  private   readonly System.UInt64                   <SizeBytes>k__BackingField  // 0x28
  private   readonly System.UInt64                   <AssetTypeId>k__BackingField  // 0x30
  private   readonly System.UInt64                   <CurrentBytesRead>k__BackingField  // 0x38
  private   readonly System.UInt32                   <BatchReadCount>k__BackingField  // 0x40
  private   readonly System.Boolean                  <IsBatchRead>k__BackingField  // 0x44
  private   readonly Unity.IO.LowLevel.Unsafe.ProcessingState<State>k__BackingField  // 0x48
  private   readonly Unity.IO.LowLevel.Unsafe.FileReadType<ReadType>k__BackingField  // 0x4C
  private   readonly Unity.IO.LowLevel.Unsafe.Priority<PriorityLevel>k__BackingField  // 0x50
  private   readonly Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem<Subsystem>k__BackingField  // 0x54
  private   readonly System.Double                   <RequestTimeMicroseconds>k__BackingField  // 0x58
  private   readonly System.Double                   <TimeInQueueMicroseconds>k__BackingField  // 0x60
  private   readonly System.Double                   <TotalTimeMicroseconds>k__BackingField  // 0x68
METHODS:
END_CLASS

CLASS: Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetricsFilters
TYPE:  class
TOKEN: 0x200003E
FIELDS:
  private           System.UInt64[]                 TypeIDs  // 0x10
  private           Unity.IO.LowLevel.Unsafe.ProcessingState[]States  // 0x18
  private           Unity.IO.LowLevel.Unsafe.FileReadType[]ReadTypes  // 0x20
  private           Unity.IO.LowLevel.Unsafe.Priority[]PriorityLevels  // 0x28
  private           Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem[]Subsystems  // 0x30
METHODS:
END_CLASS

CLASS: Unity.Jobs.IJob
TYPE:  interface
TOKEN: 0x200001D
FIELDS:
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Unity.Jobs.IJobExtensions
TYPE:  class
TOKEN: 0x200001E
FIELDS:
METHODS:
  System.Void EarlyJobInit()
  System.IntPtr GetReflectionData()
  Unity.Jobs.JobHandle Schedule(T jobData, Unity.Jobs.JobHandle dependsOn)
  System.Void Run(T jobData)
  Unity.Jobs.JobHandle ScheduleManagedCrossFrameJob(T jobData, Unity.Jobs.LowLevel.Unsafe.JobQueuePriority priority, Unity.Jobs.JobHandle dependsOn)
END_CLASS

CLASS: Unity.Jobs.IJobFor
TYPE:  interface
TOKEN: 0x2000021
FIELDS:
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: Unity.Jobs.IJobForExtensions
TYPE:  class
TOKEN: 0x2000022
FIELDS:
METHODS:
  System.Void EarlyJobInit()
  System.IntPtr GetReflectionData()
  Unity.Jobs.JobHandle ScheduleParallel(T jobData, System.Int32 arrayLength, System.Int32 innerloopBatchCount, Unity.Jobs.JobHandle dependency)
END_CLASS

CLASS: Unity.Jobs.IJobParallelFor
TYPE:  interface
TOKEN: 0x2000025
FIELDS:
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: Unity.Jobs.IJobParallelForExtensions
TYPE:  class
TOKEN: 0x2000026
FIELDS:
METHODS:
  Unity.Jobs.JobHandle Schedule(T jobData, System.Int32 arrayLength, System.Int32 innerloopBatchCount, Unity.Jobs.JobHandle dependsOn)
  System.Void Run(T jobData, System.Int32 arrayLength)
END_CLASS

CLASS: Unity.Jobs.JobHandle
TYPE:  struct
TOKEN: 0x2000029
FIELDS:
  private           System.UInt64                   jobGroup  // 0x10
  private           System.Int32                    jobType  // 0x18
METHODS:
  System.Void Complete()
  System.Void CrossFrameComplete()
  System.Boolean IsValid()
  System.Void CompleteAll(Unity.Collections.NativeArray<Unity.Jobs.JobHandle> jobs)
  System.Boolean get_IsCompleted()
  System.Void ScheduleBatchedJobs()
  System.Void ScheduleBatchedJobsAndComplete(Unity.Jobs.JobHandle& job)
  System.Void ScheduleBatchedCrossFrameJobsAndComplete(Unity.Jobs.JobHandle& job)
  System.Boolean ScheduleBatchedJobsAndIsCompleted(Unity.Jobs.JobHandle& job)
  System.Void ScheduleBatchedJobsAndCompleteAll(System.Void* jobs, System.Int32 count)
  Unity.Jobs.JobHandle CombineDependencies(Unity.Jobs.JobHandle job0, Unity.Jobs.JobHandle job1)
  Unity.Jobs.JobHandle CombineDependencies(Unity.Jobs.JobHandle job0, Unity.Jobs.JobHandle job1, Unity.Jobs.JobHandle job2)
  Unity.Jobs.JobHandle CombineDependencies(Unity.Collections.NativeArray<Unity.Jobs.JobHandle> jobs)
  Unity.Jobs.JobHandle CombineDependenciesInternal2(Unity.Jobs.JobHandle& job0, Unity.Jobs.JobHandle& job1)
  Unity.Jobs.JobHandle CombineDependenciesInternal3(Unity.Jobs.JobHandle& job0, Unity.Jobs.JobHandle& job1, Unity.Jobs.JobHandle& job2)
  Unity.Jobs.JobHandle CombineDependenciesInternalPtr(System.Void* jobs, System.Int32 count)
  System.Boolean Equals(Unity.Jobs.JobHandle other)
  System.Void CombineDependenciesInternal2_Injected(Unity.Jobs.JobHandle& job0, Unity.Jobs.JobHandle& job1, Unity.Jobs.JobHandle& ret)
  System.Void CombineDependenciesInternal3_Injected(Unity.Jobs.JobHandle& job0, Unity.Jobs.JobHandle& job1, Unity.Jobs.JobHandle& job2, Unity.Jobs.JobHandle& ret)
  System.Void CombineDependenciesInternalPtr_Injected(System.Void* jobs, System.Int32 count, Unity.Jobs.JobHandle& ret)
END_CLASS

CLASS: Unity.Jobs.LowLevel.Unsafe.BatchQueryJob`2
TYPE:  struct
TOKEN: 0x200002A
FIELDS:
  private           Unity.Collections.NativeArray<CommandT>commands  // 0x0
  private           Unity.Collections.NativeArray<ResultT>results  // 0x0
METHODS:
  System.Void .ctor(Unity.Collections.NativeArray<CommandT> commands, Unity.Collections.NativeArray<ResultT> results)
END_CLASS

CLASS: Unity.Jobs.LowLevel.Unsafe.BatchQueryJobStruct`1
TYPE:  struct
TOKEN: 0x200002B
FIELDS:
  private   static  System.IntPtr                   jobReflectionData  // 0x0
METHODS:
  System.IntPtr Initialize()
END_CLASS

CLASS: Unity.Jobs.LowLevel.Unsafe.JobProducerTypeAttribute
TYPE:  class
TOKEN: 0x200002C
EXTENDS: Attribute
FIELDS:
  private   readonly System.Type                     <ProducerType>k__BackingField  // 0x10
METHODS:
  System.Void .ctor(System.Type producerType)
END_CLASS

CLASS: Unity.Jobs.LowLevel.Unsafe.JobRanges
TYPE:  struct
TOKEN: 0x200002D
FIELDS:
  private           System.Int32                    BatchSize  // 0x10
  private           System.Int32                    NumJobs  // 0x14
  public            System.Int32                    TotalIterationCount  // 0x18
  private           System.IntPtr                   StartEndIndex  // 0x20
METHODS:
END_CLASS

CLASS: Unity.Jobs.LowLevel.Unsafe.ScheduleMode
TYPE:  struct
TOKEN: 0x200002E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.Jobs.LowLevel.Unsafe.ScheduleModeRun  // 0x0
  public    static  Unity.Jobs.LowLevel.Unsafe.ScheduleModeBatched  // 0x0
  public    static  Unity.Jobs.LowLevel.Unsafe.ScheduleModeParallel  // 0x0
  public    static  Unity.Jobs.LowLevel.Unsafe.ScheduleModeSingle  // 0x0
METHODS:
END_CLASS

CLASS: Unity.Jobs.LowLevel.Unsafe.JobQueuePriority
TYPE:  struct
TOKEN: 0x200002F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.Jobs.LowLevel.Unsafe.JobQueuePriorityNormalJobPriority  // 0x0
  public    static  Unity.Jobs.LowLevel.Unsafe.JobQueuePriorityHighJobPriority  // 0x0
METHODS:
END_CLASS

CLASS: Unity.Jobs.LowLevel.Unsafe.JobsUtility
TYPE:  class
TOKEN: 0x2000030
FIELDS:
  private   static  Unity.Jobs.LowLevel.Unsafe.JobsUtility.PanicFunction_PanicFunction  // 0x0
METHODS:
  System.Void GetJobRange(Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex, System.Int32& beginIndex, System.Int32& endIndex)
  System.Boolean GetWorkStealingRange(Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex, System.Int32& beginIndex, System.Int32& endIndex)
  Unity.Jobs.JobHandle Schedule(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters)
  Unity.Jobs.JobHandle ScheduleCrossFrameJob(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, Unity.Jobs.LowLevel.Unsafe.JobQueuePriority priority)
  Unity.Jobs.JobHandle ScheduleJobCrossFrameJobTransformReadOnly(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.IntPtr transfromAccesssArray)
  Unity.Jobs.JobHandle ScheduleJobCrossFrameJobTransform(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.IntPtr transfromAccesssArray)
  Unity.Jobs.JobHandle ScheduleParallelFor(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.Int32 arrayLength, System.Int32 innerloopBatchCount)
  Unity.Jobs.JobHandle ScheduleParallelForDeferArraySize(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.Int32 innerloopBatchCount, System.Void* listData, System.Void* listDataAtomicSafetyHandle)
  Unity.Jobs.JobHandle ScheduleParallelForTransform(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.IntPtr transfromAccesssArray)
  Unity.Jobs.JobHandle ScheduleParallelForTransformReadOnly(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.IntPtr transfromAccesssArray, System.Int32 innerloopBatchCount)
  System.IntPtr CreateJobReflectionData(System.Type wrapperJobType, System.Type userJobType, System.Object managedJobFunction0, System.Object managedJobFunction1, System.Object managedJobFunction2)
  System.IntPtr CreateJobReflectionData(System.Type type, System.Object managedJobFunction0, System.Object managedJobFunction1, System.Object managedJobFunction2)
  System.IntPtr CreateJobReflectionData(System.Type wrapperJobType, System.Type userJobType, System.Object managedJobFunction0)
  System.Boolean get_IsExecutingJob()
  System.Void set_JobCompilerEnabled(System.Boolean value)
  System.Int32 GetJobQueueWorkerThreadCount()
  System.Int32 get_JobWorkerMaximumCount()
  System.Int32 get_JobWorkerCount()
  System.Void InvokePanicFunction()
  System.Void Schedule_Injected(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, Unity.Jobs.JobHandle& ret)
  System.Void ScheduleCrossFrameJob_Injected(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, Unity.Jobs.LowLevel.Unsafe.JobQueuePriority priority, Unity.Jobs.JobHandle& ret)
  System.Void ScheduleJobCrossFrameJobTransformReadOnly_Injected(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.IntPtr transfromAccesssArray, Unity.Jobs.JobHandle& ret)
  System.Void ScheduleJobCrossFrameJobTransform_Injected(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.IntPtr transfromAccesssArray, Unity.Jobs.JobHandle& ret)
  System.Void ScheduleParallelFor_Injected(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.Int32 arrayLength, System.Int32 innerloopBatchCount, Unity.Jobs.JobHandle& ret)
  System.Void ScheduleParallelForDeferArraySize_Injected(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.Int32 innerloopBatchCount, System.Void* listData, System.Void* listDataAtomicSafetyHandle, Unity.Jobs.JobHandle& ret)
  System.Void ScheduleParallelForTransform_Injected(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.IntPtr transfromAccesssArray, Unity.Jobs.JobHandle& ret)
  System.Void ScheduleParallelForTransformReadOnly_Injected(Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters& parameters, System.IntPtr transfromAccesssArray, System.Int32 innerloopBatchCount, Unity.Jobs.JobHandle& ret)
END_CLASS

CLASS: Unity.Profiling.ProfilerCategory
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  private   readonly System.UInt16                   m_CategoryId  // 0x10
METHODS:
  System.Void .ctor(System.UInt16 category)
  System.String get_Name()
  System.String ToString()
  Unity.Profiling.ProfilerCategory get_Scripts()
  Unity.Profiling.ProfilerCategory get_Audio()
  System.UInt16 op_Implicit(Unity.Profiling.ProfilerCategory category)
END_CLASS

CLASS: Unity.Profiling.ProfilerMarker
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  private   readonly System.IntPtr                   m_Ptr  // 0x10
METHODS:
  System.IntPtr get_Handle()
  System.Void .ctor(System.String name)
  System.Void .ctor(Unity.Profiling.ProfilerCategory category, System.String name)
  System.Void Begin()
  System.Void End()
  Unity.Profiling.ProfilerMarker.AutoScope Auto()
END_CLASS

CLASS: Unity.Profiling.ProfilerMarkerDataUnit
TYPE:  struct
TOKEN: 0x200000E
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Unity.Profiling.ProfilerMarkerDataUnitUndefined  // 0x0
  public    static  Unity.Profiling.ProfilerMarkerDataUnitTimeNanoseconds  // 0x0
  public    static  Unity.Profiling.ProfilerMarkerDataUnitBytes  // 0x0
  public    static  Unity.Profiling.ProfilerMarkerDataUnitCount  // 0x0
  public    static  Unity.Profiling.ProfilerMarkerDataUnitPercent  // 0x0
  public    static  Unity.Profiling.ProfilerMarkerDataUnitFrequencyHz  // 0x0
METHODS:
END_CLASS

CLASS: Unity.Profiling.ProfilerCounterOptions
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  public            System.UInt16                   value__  // 0x10
  public    static  Unity.Profiling.ProfilerCounterOptionsNone  // 0x0
  public    static  Unity.Profiling.ProfilerCounterOptionsFlushOnEndOfFrame  // 0x0
  public    static  Unity.Profiling.ProfilerCounterOptionsResetToZeroOnFlush  // 0x0
METHODS:
END_CLASS

CLASS: Unity.Profiling.ProfilerRecorderOptions
TYPE:  struct
TOKEN: 0x2000010
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.Profiling.ProfilerRecorderOptionsNone  // 0x0
  public    static  Unity.Profiling.ProfilerRecorderOptionsStartImmediately  // 0x0
  public    static  Unity.Profiling.ProfilerRecorderOptionsKeepAliveDuringDomainReload  // 0x0
  public    static  Unity.Profiling.ProfilerRecorderOptionsCollectOnlyOnCurrentThread  // 0x0
  public    static  Unity.Profiling.ProfilerRecorderOptionsWrapAroundWhenCapacityReached  // 0x0
  public    static  Unity.Profiling.ProfilerRecorderOptionsSumAllSamplesInFrame  // 0x0
  public    static  Unity.Profiling.ProfilerRecorderOptionsGpuRecorder  // 0x0
  public    static  Unity.Profiling.ProfilerRecorderOptionsDefault  // 0x0
METHODS:
END_CLASS

CLASS: Unity.Profiling.ProfilerRecorderSample
TYPE:  struct
TOKEN: 0x2000011
FIELDS:
  private           System.Int64                    value  // 0x10
  private           System.Int64                    count  // 0x18
  private           System.Int64                    refValue  // 0x20
METHODS:
  System.Int64 get_Count()
END_CLASS

CLASS: Unity.Profiling.ProfilerRecorder
TYPE:  struct
TOKEN: 0x2000012
FIELDS:
  private           System.UInt64                   handle  // 0x10
  private   static  Unity.Profiling.ProfilerRecorderOptionsSharedRecorder  // 0x0
METHODS:
  System.Void .ctor(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle statHandle, System.Int32 capacity, Unity.Profiling.ProfilerRecorderOptions options)
  System.Boolean get_Valid()
  System.Void Start()
  System.Void Stop()
  System.Int64 get_LastValue()
  System.Int32 get_Count()
  System.Boolean get_IsRunning()
  Unity.Profiling.ProfilerRecorderSample GetSample(System.Int32 index)
  Unity.Profiling.ProfilerRecorder Create(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle statHandle, System.Int32 maxSampleCount, Unity.Profiling.ProfilerRecorderOptions options)
  System.Void Control(Unity.Profiling.ProfilerRecorder handle, Unity.Profiling.ProfilerRecorder.ControlOptions options)
  System.Int64 GetLastValue(Unity.Profiling.ProfilerRecorder handle)
  System.Int32 GetCount(Unity.Profiling.ProfilerRecorder handle, Unity.Profiling.ProfilerRecorder.CountOptions countOptions)
  System.Boolean GetValid(Unity.Profiling.ProfilerRecorder handle)
  System.Boolean GetRunning(Unity.Profiling.ProfilerRecorder handle)
  Unity.Profiling.ProfilerRecorderSample GetSampleInternal(Unity.Profiling.ProfilerRecorder handle, System.Int32 index)
  System.Void Dispose()
  System.Void CheckInitializedAndThrow()
  System.Void Create_Injected(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle& statHandle, System.Int32 maxSampleCount, Unity.Profiling.ProfilerRecorderOptions options, Unity.Profiling.ProfilerRecorder& ret)
  System.Void Control_Injected(Unity.Profiling.ProfilerRecorder& handle, Unity.Profiling.ProfilerRecorder.ControlOptions options)
  System.Int64 GetLastValue_Injected(Unity.Profiling.ProfilerRecorder& handle)
  System.Int32 GetCount_Injected(Unity.Profiling.ProfilerRecorder& handle, Unity.Profiling.ProfilerRecorder.CountOptions countOptions)
  System.Boolean GetValid_Injected(Unity.Profiling.ProfilerRecorder& handle)
  System.Boolean GetRunning_Injected(Unity.Profiling.ProfilerRecorder& handle)
  System.Void GetSampleInternal_Injected(Unity.Profiling.ProfilerRecorder& handle, System.Int32 index, Unity.Profiling.ProfilerRecorderSample& ret)
END_CLASS

CLASS: Unity.Profiling.ProfilerRecorderDebugView
TYPE:  class
TOKEN: 0x2000015
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Profiling.LowLevel.MarkerFlags
TYPE:  struct
TOKEN: 0x2000016
FIELDS:
  public            System.UInt16                   value__  // 0x10
  public    static  Unity.Profiling.LowLevel.MarkerFlagsDefault  // 0x0
  public    static  Unity.Profiling.LowLevel.MarkerFlagsScript  // 0x0
  public    static  Unity.Profiling.LowLevel.MarkerFlagsScriptInvoke  // 0x0
  public    static  Unity.Profiling.LowLevel.MarkerFlagsScriptDeepProfiler  // 0x0
  public    static  Unity.Profiling.LowLevel.MarkerFlagsAvailabilityEditor  // 0x0
  public    static  Unity.Profiling.LowLevel.MarkerFlagsAvailabilityNonDevelopment  // 0x0
  public    static  Unity.Profiling.LowLevel.MarkerFlagsWarning  // 0x0
  public    static  Unity.Profiling.LowLevel.MarkerFlagsCounter  // 0x0
  public    static  Unity.Profiling.LowLevel.MarkerFlagsSampleGPU  // 0x0
METHODS:
END_CLASS

CLASS: Unity.Profiling.LowLevel.ProfilerMarkerDataType
TYPE:  struct
TOKEN: 0x2000017
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Unity.Profiling.LowLevel.ProfilerMarkerDataTypeInt32  // 0x0
  public    static  Unity.Profiling.LowLevel.ProfilerMarkerDataTypeUInt32  // 0x0
  public    static  Unity.Profiling.LowLevel.ProfilerMarkerDataTypeInt64  // 0x0
  public    static  Unity.Profiling.LowLevel.ProfilerMarkerDataTypeUInt64  // 0x0
  public    static  Unity.Profiling.LowLevel.ProfilerMarkerDataTypeFloat  // 0x0
  public    static  Unity.Profiling.LowLevel.ProfilerMarkerDataTypeDouble  // 0x0
  public    static  Unity.Profiling.LowLevel.ProfilerMarkerDataTypeString16  // 0x0
  public    static  Unity.Profiling.LowLevel.ProfilerMarkerDataTypeBlob8  // 0x0
METHODS:
END_CLASS

CLASS: Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription
TYPE:  struct
TOKEN: 0x2000018
FIELDS:
  private   readonly Unity.Profiling.ProfilerCategorycategory  // 0x10
  private   readonly Unity.Profiling.LowLevel.MarkerFlagsflags  // 0x12
  private   readonly Unity.Profiling.LowLevel.ProfilerMarkerDataTypedataType  // 0x14
  private   readonly Unity.Profiling.ProfilerMarkerDataUnitunitType  // 0x15
  private   readonly System.Int32                    reserved0  // 0x18
  private   readonly System.Int32                    nameUtf8Len  // 0x1C
  private   readonly System.Byte*                    nameUtf8  // 0x20
METHODS:
  Unity.Profiling.LowLevel.MarkerFlags get_Flags()
END_CLASS

CLASS: Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle
TYPE:  struct
TOKEN: 0x2000019
FIELDS:
  private   readonly System.UInt64                   handle  // 0x10
METHODS:
  System.Void .ctor(System.UInt64 handle)
  System.Boolean get_Valid()
  Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription GetDescription(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle handle)
  Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription GetDescriptionInternal(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle handle)
  System.Void GetDescriptionInternal_Injected(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle& handle, Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription& ret)
END_CLASS

CLASS: Unity.Profiling.LowLevel.Unsafe.ProfilerMarkerData
TYPE:  struct
TOKEN: 0x200001A
FIELDS:
  public            System.Byte                     Type  // 0x10
  private   readonly System.Byte                     reserved0  // 0x11
  private   readonly System.UInt16                   reserved1  // 0x12
  public            System.UInt32                   Size  // 0x14
  public            System.Void*                    Ptr  // 0x18
METHODS:
END_CLASS

CLASS: Unity.Profiling.LowLevel.Unsafe.ProfilerCategoryDescription
TYPE:  struct
TOKEN: 0x200001B
FIELDS:
  public    readonly System.UInt16                   Id  // 0x10
  public    readonly System.UInt16                   Flags  // 0x12
  public    readonly UnityEngine.Color32             Color  // 0x14
  private   readonly System.Int32                    reserved0  // 0x18
  public    readonly System.Int32                    NameUtf8Len  // 0x1C
  public    readonly System.Byte*                    NameUtf8  // 0x20
METHODS:
END_CLASS

CLASS: Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility
TYPE:  class
TOKEN: 0x200001C
FIELDS:
METHODS:
  Unity.Profiling.LowLevel.Unsafe.ProfilerCategoryDescription GetCategoryDescription(System.UInt16 categoryId)
  System.IntPtr CreateMarker(System.String name, System.UInt16 categoryId, Unity.Profiling.LowLevel.MarkerFlags flags, System.Int32 metadataCount)
  System.Void BeginSample(System.IntPtr markerPtr)
  System.Void BeginSampleWithMetadata(System.IntPtr markerPtr, System.Int32 metadataCount, System.Void* metadata)
  System.Void EndSample(System.IntPtr markerPtr)
  System.String Utf8ToString(System.Byte* chars, System.Int32 charsLen)
  System.Void GetCategoryDescription_Injected(System.UInt16 categoryId, Unity.Profiling.LowLevel.Unsafe.ProfilerCategoryDescription& ret)
END_CLASS

CLASS: UnityEngine.SendMessageOptions
TYPE:  struct
TOKEN: 0x2000077
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.SendMessageOptions  RequireReceiver  // 0x0
  public    static  UnityEngine.SendMessageOptions  DontRequireReceiver  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.PrimitiveType
TYPE:  struct
TOKEN: 0x2000078
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.PrimitiveType       Sphere  // 0x0
  public    static  UnityEngine.PrimitiveType       Capsule  // 0x0
  public    static  UnityEngine.PrimitiveType       Cylinder  // 0x0
  public    static  UnityEngine.PrimitiveType       Cube  // 0x0
  public    static  UnityEngine.PrimitiveType       Plane  // 0x0
  public    static  UnityEngine.PrimitiveType       Quad  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Space
TYPE:  struct
TOKEN: 0x2000079
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Space               World  // 0x0
  public    static  UnityEngine.Space               Self  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.RuntimePlatform
TYPE:  struct
TOKEN: 0x200007A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.RuntimePlatform     OSXEditor  // 0x0
  public    static  UnityEngine.RuntimePlatform     OSXPlayer  // 0x0
  public    static  UnityEngine.RuntimePlatform     WindowsPlayer  // 0x0
  public    static  UnityEngine.RuntimePlatform     OSXWebPlayer  // 0x0
  public    static  UnityEngine.RuntimePlatform     OSXDashboardPlayer  // 0x0
  public    static  UnityEngine.RuntimePlatform     WindowsWebPlayer  // 0x0
  public    static  UnityEngine.RuntimePlatform     WindowsEditor  // 0x0
  public    static  UnityEngine.RuntimePlatform     IPhonePlayer  // 0x0
  public    static  UnityEngine.RuntimePlatform     XBOX360  // 0x0
  public    static  UnityEngine.RuntimePlatform     PS3  // 0x0
  public    static  UnityEngine.RuntimePlatform     Android  // 0x0
  public    static  UnityEngine.RuntimePlatform     NaCl  // 0x0
  public    static  UnityEngine.RuntimePlatform     FlashPlayer  // 0x0
  public    static  UnityEngine.RuntimePlatform     LinuxPlayer  // 0x0
  public    static  UnityEngine.RuntimePlatform     LinuxEditor  // 0x0
  public    static  UnityEngine.RuntimePlatform     WebGLPlayer  // 0x0
  public    static  UnityEngine.RuntimePlatform     MetroPlayerX86  // 0x0
  public    static  UnityEngine.RuntimePlatform     WSAPlayerX86  // 0x0
  public    static  UnityEngine.RuntimePlatform     MetroPlayerX64  // 0x0
  public    static  UnityEngine.RuntimePlatform     WSAPlayerX64  // 0x0
  public    static  UnityEngine.RuntimePlatform     MetroPlayerARM  // 0x0
  public    static  UnityEngine.RuntimePlatform     WSAPlayerARM  // 0x0
  public    static  UnityEngine.RuntimePlatform     WP8Player  // 0x0
  public    static  UnityEngine.RuntimePlatform     BlackBerryPlayer  // 0x0
  public    static  UnityEngine.RuntimePlatform     TizenPlayer  // 0x0
  public    static  UnityEngine.RuntimePlatform     PSP2  // 0x0
  public    static  UnityEngine.RuntimePlatform     PS4  // 0x0
  public    static  UnityEngine.RuntimePlatform     PSM  // 0x0
  public    static  UnityEngine.RuntimePlatform     XboxOne  // 0x0
  public    static  UnityEngine.RuntimePlatform     SamsungTVPlayer  // 0x0
  public    static  UnityEngine.RuntimePlatform     WiiU  // 0x0
  public    static  UnityEngine.RuntimePlatform     tvOS  // 0x0
  public    static  UnityEngine.RuntimePlatform     Switch  // 0x0
  public    static  UnityEngine.RuntimePlatform     Lumin  // 0x0
  public    static  UnityEngine.RuntimePlatform     Stadia  // 0x0
  public    static  UnityEngine.RuntimePlatform     CloudRendering  // 0x0
  public    static  UnityEngine.RuntimePlatform     GameCoreScarlett  // 0x0
  public    static  UnityEngine.RuntimePlatform     GameCoreXboxSeries  // 0x0
  public    static  UnityEngine.RuntimePlatform     GameCoreXboxOne  // 0x0
  public    static  UnityEngine.RuntimePlatform     PS5  // 0x0
  public    static  UnityEngine.RuntimePlatform     EmbeddedLinuxArm64  // 0x0
  public    static  UnityEngine.RuntimePlatform     EmbeddedLinuxArm32  // 0x0
  public    static  UnityEngine.RuntimePlatform     EmbeddedLinuxX64  // 0x0
  public    static  UnityEngine.RuntimePlatform     EmbeddedLinuxX86  // 0x0
  public    static  UnityEngine.RuntimePlatform     LinuxServer  // 0x0
  public    static  UnityEngine.RuntimePlatform     WindowsServer  // 0x0
  public    static  UnityEngine.RuntimePlatform     OSXServer  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.SystemLanguage
TYPE:  struct
TOKEN: 0x200007B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.SystemLanguage      Afrikaans  // 0x0
  public    static  UnityEngine.SystemLanguage      Arabic  // 0x0
  public    static  UnityEngine.SystemLanguage      Basque  // 0x0
  public    static  UnityEngine.SystemLanguage      Belarusian  // 0x0
  public    static  UnityEngine.SystemLanguage      Bulgarian  // 0x0
  public    static  UnityEngine.SystemLanguage      Catalan  // 0x0
  public    static  UnityEngine.SystemLanguage      Chinese  // 0x0
  public    static  UnityEngine.SystemLanguage      Czech  // 0x0
  public    static  UnityEngine.SystemLanguage      Danish  // 0x0
  public    static  UnityEngine.SystemLanguage      Dutch  // 0x0
  public    static  UnityEngine.SystemLanguage      English  // 0x0
  public    static  UnityEngine.SystemLanguage      Estonian  // 0x0
  public    static  UnityEngine.SystemLanguage      Faroese  // 0x0
  public    static  UnityEngine.SystemLanguage      Finnish  // 0x0
  public    static  UnityEngine.SystemLanguage      French  // 0x0
  public    static  UnityEngine.SystemLanguage      German  // 0x0
  public    static  UnityEngine.SystemLanguage      Greek  // 0x0
  public    static  UnityEngine.SystemLanguage      Hebrew  // 0x0
  public    static  UnityEngine.SystemLanguage      Icelandic  // 0x0
  public    static  UnityEngine.SystemLanguage      Indonesian  // 0x0
  public    static  UnityEngine.SystemLanguage      Italian  // 0x0
  public    static  UnityEngine.SystemLanguage      Japanese  // 0x0
  public    static  UnityEngine.SystemLanguage      Korean  // 0x0
  public    static  UnityEngine.SystemLanguage      Latvian  // 0x0
  public    static  UnityEngine.SystemLanguage      Lithuanian  // 0x0
  public    static  UnityEngine.SystemLanguage      Norwegian  // 0x0
  public    static  UnityEngine.SystemLanguage      Polish  // 0x0
  public    static  UnityEngine.SystemLanguage      Portuguese  // 0x0
  public    static  UnityEngine.SystemLanguage      Romanian  // 0x0
  public    static  UnityEngine.SystemLanguage      Russian  // 0x0
  public    static  UnityEngine.SystemLanguage      SerboCroatian  // 0x0
  public    static  UnityEngine.SystemLanguage      Slovak  // 0x0
  public    static  UnityEngine.SystemLanguage      Slovenian  // 0x0
  public    static  UnityEngine.SystemLanguage      Spanish  // 0x0
  public    static  UnityEngine.SystemLanguage      Swedish  // 0x0
  public    static  UnityEngine.SystemLanguage      Thai  // 0x0
  public    static  UnityEngine.SystemLanguage      Turkish  // 0x0
  public    static  UnityEngine.SystemLanguage      Ukrainian  // 0x0
  public    static  UnityEngine.SystemLanguage      Vietnamese  // 0x0
  public    static  UnityEngine.SystemLanguage      ChineseSimplified  // 0x0
  public    static  UnityEngine.SystemLanguage      ChineseTraditional  // 0x0
  public    static  UnityEngine.SystemLanguage      Unknown  // 0x0
  public    static  UnityEngine.SystemLanguage      Hungarian  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.LogType
TYPE:  struct
TOKEN: 0x200007C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.LogType             Critical  // 0x0
  public    static  UnityEngine.LogType             Error  // 0x0
  public    static  UnityEngine.LogType             Assert  // 0x0
  public    static  UnityEngine.LogType             Warning  // 0x0
  public    static  UnityEngine.LogType             Log  // 0x0
  public    static  UnityEngine.LogType             Exception  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.LogOption
TYPE:  struct
TOKEN: 0x200007D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.LogOption           None  // 0x0
  public    static  UnityEngine.LogOption           NoStacktrace  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.ThreadPriority
TYPE:  struct
TOKEN: 0x200007E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ThreadPriority      Low  // 0x0
  public    static  UnityEngine.ThreadPriority      BelowNormal  // 0x0
  public    static  UnityEngine.ThreadPriority      Normal  // 0x0
  public    static  UnityEngine.ThreadPriority      High  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.SortingLayer
TYPE:  struct
TOKEN: 0x200007F
FIELDS:
  private           System.Int32                    m_Id  // 0x10
METHODS:
  System.String get_name()
  UnityEngine.SortingLayer[] get_layers()
  System.Int32[] GetSortingLayerIDsInternal()
  System.Int32 GetLayerValueFromID(System.Int32 id)
  System.Int32 NameToID(System.String name)
  System.String IDToName(System.Int32 id)
  System.Boolean IsValid(System.Int32 id)
END_CLASS

CLASS: UnityEngine.WeightedMode
TYPE:  struct
TOKEN: 0x2000080
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.WeightedMode        None  // 0x0
  public    static  UnityEngine.WeightedMode        In  // 0x0
  public    static  UnityEngine.WeightedMode        Out  // 0x0
  public    static  UnityEngine.WeightedMode        Both  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Keyframe
TYPE:  struct
TOKEN: 0x2000081
FIELDS:
  private           System.Single                   m_Time  // 0x10
  private           System.Single                   m_Value  // 0x14
  private           System.Single                   m_InTangent  // 0x18
  private           System.Single                   m_OutTangent  // 0x1C
  private           System.Int32                    m_WeightedMode  // 0x20
  private           System.Single                   m_InWeight  // 0x24
  private           System.Single                   m_OutWeight  // 0x28
METHODS:
  System.Void .ctor(System.Single time, System.Single value)
  System.Void .ctor(System.Single time, System.Single value, System.Single inTangent, System.Single outTangent)
  System.Void .ctor(System.Single time, System.Single value, System.Single inTangent, System.Single outTangent, System.Single inWeight, System.Single outWeight)
  System.Single get_time()
  System.Void set_time(System.Single value)
  System.Single get_value()
  System.Void set_value(System.Single value)
  System.Single get_inTangent()
  System.Void set_inTangent(System.Single value)
  System.Single get_outTangent()
  System.Void set_outTangent(System.Single value)
  System.Single get_inWeight()
  System.Void set_inWeight(System.Single value)
  System.Single get_outWeight()
  System.Void set_outWeight(System.Single value)
  UnityEngine.WeightedMode get_weightedMode()
  System.Void set_weightedMode(UnityEngine.WeightedMode value)
  System.Int32 get_tangentMode()
  System.Void set_tangentMode(System.Int32 value)
  System.Int32 get_tangentModeInternal()
  System.Void set_tangentModeInternal(System.Int32 value)
END_CLASS

CLASS: UnityEngine.WrapMode
TYPE:  struct
TOKEN: 0x2000082
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.WrapMode            Once  // 0x0
  public    static  UnityEngine.WrapMode            Loop  // 0x0
  public    static  UnityEngine.WrapMode            PingPong  // 0x0
  public    static  UnityEngine.WrapMode            Default  // 0x0
  public    static  UnityEngine.WrapMode            ClampForever  // 0x0
  public    static  UnityEngine.WrapMode            Clamp  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.AnimationCurve
TYPE:  class
TOKEN: 0x2000083
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
METHODS:
  System.Void Internal_Destroy(System.IntPtr ptr)
  System.IntPtr Internal_Create(UnityEngine.Keyframe[] keys)
  System.Boolean Internal_Equals(System.IntPtr other)
  System.Void Finalize()
  System.Single Evaluate(System.Single time)
  UnityEngine.Keyframe[] get_keys()
  System.Void set_keys(UnityEngine.Keyframe[] value)
  System.Int32 AddKey(System.Single time, System.Single value)
  System.Int32 AddKey(UnityEngine.Keyframe key)
  System.Int32 AddKey_Internal(UnityEngine.Keyframe key)
  System.Int32 MoveKey(System.Int32 index, UnityEngine.Keyframe key)
  System.Void RemoveKey(System.Int32 index)
  UnityEngine.Keyframe get_Item(System.Int32 index)
  System.Int32 get_length()
  System.Void SetKeys(UnityEngine.Keyframe[] keys)
  System.Void SetKeys(Unity.Collections.NativeArray<UnityEngine.Keyframe> keys, System.Int32 count)
  System.Void Internal_SetKeysNoGC(System.IntPtr keys, System.Int32 count)
  UnityEngine.Keyframe GetKey(System.Int32 index)
  UnityEngine.Keyframe[] GetKeys()
  System.Void SmoothTangents(System.Int32 index, System.Single weight)
  UnityEngine.AnimationCurve Constant(System.Single timeStart, System.Single timeEnd, System.Single value)
  UnityEngine.AnimationCurve Linear(System.Single timeStart, System.Single valueStart, System.Single timeEnd, System.Single valueEnd)
  UnityEngine.AnimationCurve EaseInOut(System.Single timeStart, System.Single valueStart, System.Single timeEnd, System.Single valueEnd)
  UnityEngine.WrapMode get_preWrapMode()
  System.Void set_preWrapMode(UnityEngine.WrapMode value)
  UnityEngine.WrapMode get_postWrapMode()
  System.Void set_postWrapMode(UnityEngine.WrapMode value)
  System.Void .ctor(UnityEngine.Keyframe[] keys)
  System.Void .ctor()
  System.Boolean Equals(System.Object o)
  System.Boolean Equals(UnityEngine.AnimationCurve other)
  System.Int32 GetHashCode()
  System.Int32 AddKey_Internal_Injected(UnityEngine.Keyframe& key)
  System.Int32 MoveKey_Injected(System.Int32 index, UnityEngine.Keyframe& key)
  System.Void GetKey_Injected(System.Int32 index, UnityEngine.Keyframe& ret)
END_CLASS

CLASS: UnityEngine.Application
TYPE:  class
TOKEN: 0x2000084
FIELDS:
  private   static  UnityEngine.Application.LowMemoryCallbacklowMemory  // 0x0
  private   static  UnityEngine.Application.LogCallbacks_LogCallbackHandler  // 0x8
  private   static  UnityEngine.Application.LogCallbacks_LogCallbackHandlerThreaded  // 0x10
  private   static  UnityEngine.Application.AdvertisingIdentifierCallbackOnAdvertisingIdentifierCallback  // 0x18
  private   static  System.Action<System.Boolean>   focusChanged  // 0x20
  private   static  System.Action<System.String>    deepLinkActivated  // 0x28
  private   static  System.Func<System.Boolean>     wantsToQuit  // 0x30
  private   static  System.Action                   quitting  // 0x38
  private   static  System.Action                   unloading  // 0x40
  private   static  UnityEngine.Application.LogCallbacks_RegisterLogCallbackDeprecated  // 0x48
METHODS:
  System.Void Quit(System.Int32 exitCode)
  System.Void Quit()
  System.Void CancelQuit()
  System.Void Unload()
  System.Boolean get_isLoadingLevel()
  System.Single GetStreamProgressForLevel(System.Int32 levelIndex)
  System.Single GetStreamProgressForLevel(System.String levelName)
  System.Int32 get_streamedBytes()
  System.Boolean get_webSecurityEnabled()
  System.Boolean CanStreamedLevelBeLoaded(System.Int32 levelIndex)
  System.Boolean CanStreamedLevelBeLoaded(System.String levelName)
  System.Boolean get_isPlaying()
  System.Boolean IsPlaying(UnityEngine.Object obj)
  System.Boolean get_isFocused()
  System.String[] GetBuildTags()
  System.Void SetBuildTags(System.String[] buildTags)
  System.String get_buildGUID()
  System.Boolean get_runInBackground()
  System.Void set_runInBackground(System.Boolean value)
  System.Boolean HasProLicense()
  System.Boolean get_isBatchMode()
  System.Boolean get_isTestRun()
  System.Boolean get_isHumanControllingUs()
  System.Boolean HasARGV(System.String name)
  System.String GetValueForARGV(System.String name)
  System.String get_dataPath()
  System.String get_streamingAssetsPath()
  System.String get_persistentDataPath()
  System.String get_temporaryCachePath()
  System.String get_absoluteURL()
  System.Void ExternalEval(System.String script)
  System.Void Internal_ExternalCall(System.String script)
  System.String get_unityVersion()
  System.String get_unityBuildVersion()
  System.String get_unityBuildBranch()
  System.String get_unityBuildDate()
  System.String get_unityBuildChangeList()
  System.String get_unityCacheServerNamespace()
  System.String get_unityRemoteShaderCacheNamespace()
  System.Int32 get_unityVersionVer()
  System.Int32 get_unityVersionMaj()
  System.Int32 get_unityVersionMin()
  System.String get_version()
  System.String get_installerName()
  System.String get_identifier()
  UnityEngine.ApplicationInstallMode get_installMode()
  UnityEngine.ApplicationSandboxType get_sandboxType()
  System.String get_productName()
  System.String get_companyName()
  System.Boolean get_isRemoveSerializedFileExternalRef()
  System.Void set_isRemoveSerializedFileExternalRef(System.Boolean value)
  System.Boolean get_isRemoveABPreloadData()
  System.Void set_isRemoveABPreloadData(System.Boolean value)
  System.Boolean get_obsoletePhysicsAPI()
  System.Void set_obsoletePhysicsAPI(System.Boolean value)
  System.String get_cloudProjectId()
  System.Boolean RequestAdvertisingIdentifierAsync(UnityEngine.Application.AdvertisingIdentifierCallback delegateMethod)
  System.Void OpenURL(System.String url)
  System.Void ForceCrash(System.Int32 mode)
  System.Int32 get_targetFrameRate()
  System.Void set_targetFrameRate(System.Int32 value)
  System.Void SetLogCallbackDefined(System.Boolean defined)
  UnityEngine.StackTraceLogType get_stackTraceLogType()
  System.Void set_stackTraceLogType(UnityEngine.StackTraceLogType value)
  UnityEngine.StackTraceLogType GetStackTraceLogType(UnityEngine.LogType logType)
  System.Void SetStackTraceLogType(UnityEngine.LogType logType, UnityEngine.StackTraceLogType stackTraceType)
  System.String get_consoleLogPath()
  UnityEngine.ThreadPriority get_backgroundLoadingPriority()
  System.Void set_backgroundLoadingPriority(UnityEngine.ThreadPriority value)
  System.Boolean get_genuine()
  System.Boolean get_genuineCheckAvailable()
  UnityEngine.AsyncOperation RequestUserAuthorization(UnityEngine.UserAuthorization mode)
  System.Boolean HasUserAuthorization(UnityEngine.UserAuthorization mode)
  System.Boolean get_submitAnalytics()
  System.Boolean get_isShowingSplashScreen()
  UnityEngine.RuntimePlatform get_platform()
  System.Boolean get_isMobilePlatform()
  System.Boolean get_isConsolePlatform()
  UnityEngine.SystemLanguage get_systemLanguage()
  UnityEngine.NetworkReachability get_internetReachability()
  System.Boolean get_enableHGFramePacing()
  System.Void add_lowMemory(UnityEngine.Application.LowMemoryCallback value)
  System.Void remove_lowMemory(UnityEngine.Application.LowMemoryCallback value)
  System.Void CallLowMemory()
  System.Void add_logMessageReceived(UnityEngine.Application.LogCallback value)
  System.Void remove_logMessageReceived(UnityEngine.Application.LogCallback value)
  System.Void add_logMessageReceivedThreaded(UnityEngine.Application.LogCallback value)
  System.Void remove_logMessageReceivedThreaded(UnityEngine.Application.LogCallback value)
  System.Void CallLogCallback(System.String logString, System.String stackTrace, UnityEngine.LogType type, System.Boolean invokedOnMainThread)
  System.Void InvokeOnAdvertisingIdentifierCallback(System.String advertisingId, System.Boolean trackingEnabled)
  System.String ObjectToJSString(System.Object o)
  System.Void ExternalCall(System.String functionName, System.Object[] args)
  System.String BuildInvocationForArguments(System.String functionName, System.Object[] args)
  System.Boolean get_isPlayer()
  System.Void DontDestroyOnLoad(UnityEngine.Object o)
  System.Void CaptureScreenshot(System.String filename, System.Int32 superSize)
  System.Void CaptureScreenshot(System.String filename)
  System.Void add_onBeforeRender(UnityEngine.Events.UnityAction value)
  System.Void remove_onBeforeRender(UnityEngine.Events.UnityAction value)
  System.Void add_focusChanged(System.Action<System.Boolean> value)
  System.Void remove_focusChanged(System.Action<System.Boolean> value)
  System.Void add_deepLinkActivated(System.Action<System.String> value)
  System.Void remove_deepLinkActivated(System.Action<System.String> value)
  System.Void add_wantsToQuit(System.Func<System.Boolean> value)
  System.Void remove_wantsToQuit(System.Func<System.Boolean> value)
  System.Void add_quitting(System.Action value)
  System.Void remove_quitting(System.Action value)
  System.Void add_unloading(System.Action value)
  System.Void remove_unloading(System.Action value)
  System.Boolean Internal_ApplicationWantsToQuit()
  System.Void Internal_ApplicationQuit()
  System.Void Internal_ApplicationUnload()
  System.Void InvokeOnBeforeRender()
  System.Void InvokeFocusChanged(System.Boolean focus)
  System.Void InvokeDeepLinkActivated(System.String url)
  System.Void RegisterLogCallback(UnityEngine.Application.LogCallback handler)
  System.Void RegisterLogCallbackThreaded(UnityEngine.Application.LogCallback handler)
  System.Void RegisterLogCallback(UnityEngine.Application.LogCallback handler, System.Boolean threaded)
  System.Int32 get_levelCount()
  System.Int32 get_loadedLevel()
  System.String get_loadedLevelName()
  System.Void LoadLevel(System.Int32 index)
  System.Void LoadLevel(System.String name)
  System.Void LoadLevelAdditive(System.Int32 index)
  System.Void LoadLevelAdditive(System.String name)
  UnityEngine.AsyncOperation LoadLevelAsync(System.Int32 index)
  UnityEngine.AsyncOperation LoadLevelAsync(System.String levelName)
  UnityEngine.AsyncOperation LoadLevelAdditiveAsync(System.Int32 index)
  UnityEngine.AsyncOperation LoadLevelAdditiveAsync(System.String levelName)
  System.Boolean UnloadLevel(System.Int32 index)
  System.Boolean UnloadLevel(System.String scenePath)
  System.Boolean get_isEditor()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.StackTraceLogType
TYPE:  struct
TOKEN: 0x2000088
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.StackTraceLogType   None  // 0x0
  public    static  UnityEngine.StackTraceLogType   ScriptOnly  // 0x0
  public    static  UnityEngine.StackTraceLogType   Full  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.NetworkReachability
TYPE:  struct
TOKEN: 0x2000089
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.NetworkReachability NotReachable  // 0x0
  public    static  UnityEngine.NetworkReachability ReachableViaCarrierDataNetwork  // 0x0
  public    static  UnityEngine.NetworkReachability ReachableViaLocalAreaNetwork  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UserAuthorization
TYPE:  struct
TOKEN: 0x200008A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UserAuthorization   WebCam  // 0x0
  public    static  UnityEngine.UserAuthorization   Microphone  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.ApplicationInstallMode
TYPE:  struct
TOKEN: 0x200008B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ApplicationInstallModeUnknown  // 0x0
  public    static  UnityEngine.ApplicationInstallModeStore  // 0x0
  public    static  UnityEngine.ApplicationInstallModeDeveloperBuild  // 0x0
  public    static  UnityEngine.ApplicationInstallModeAdhoc  // 0x0
  public    static  UnityEngine.ApplicationInstallModeEnterprise  // 0x0
  public    static  UnityEngine.ApplicationInstallModeEditor  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.ApplicationSandboxType
TYPE:  struct
TOKEN: 0x200008C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ApplicationSandboxTypeUnknown  // 0x0
  public    static  UnityEngine.ApplicationSandboxTypeNotSandboxed  // 0x0
  public    static  UnityEngine.ApplicationSandboxTypeSandboxed  // 0x0
  public    static  UnityEngine.ApplicationSandboxTypeSandboxBroken  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.AudioType
TYPE:  struct
TOKEN: 0x200008D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AudioType           UNKNOWN  // 0x0
  public    static  UnityEngine.AudioType           ACC  // 0x0
  public    static  UnityEngine.AudioType           AIFF  // 0x0
  public    static  UnityEngine.AudioType           IT  // 0x0
  public    static  UnityEngine.AudioType           MOD  // 0x0
  public    static  UnityEngine.AudioType           MPEG  // 0x0
  public    static  UnityEngine.AudioType           OGGVORBIS  // 0x0
  public    static  UnityEngine.AudioType           S3M  // 0x0
  public    static  UnityEngine.AudioType           WAV  // 0x0
  public    static  UnityEngine.AudioType           XM  // 0x0
  public    static  UnityEngine.AudioType           XMA  // 0x0
  public    static  UnityEngine.AudioType           VAG  // 0x0
  public    static  UnityEngine.AudioType           AUDIOQUEUE  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.BootConfigData
TYPE:  class
TOKEN: 0x200008E
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
METHODS:
  UnityEngine.BootConfigData WrapBootConfigData(System.IntPtr nativeHandle)
  System.Void .ctor(System.IntPtr nativeHandle)
END_CLASS

CLASS: UnityEngine.CachedAssetBundle
TYPE:  struct
TOKEN: 0x200008F
FIELDS:
  private           System.String                   m_Name  // 0x10
  private           UnityEngine.Hash128             m_Hash  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.Cache
TYPE:  struct
TOKEN: 0x2000090
FIELDS:
  private           System.Int32                    m_Handle  // 0x10
METHODS:
  System.Int32 get_handle()
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(UnityEngine.Cache other)
  System.String get_path()
  System.String Cache_GetPath(System.Int32 handle)
END_CLASS

CLASS: UnityEngine.Caching
TYPE:  class
TOKEN: 0x2000091
FIELDS:
METHODS:
  UnityEngine.Cache get_currentCacheForWriting()
  System.Void get_currentCacheForWriting_Injected(UnityEngine.Cache& ret)
END_CLASS

CLASS: UnityEngine.Camera
TYPE:  class
TOKEN: 0x2000092
EXTENDS: Behaviour
FIELDS:
  public    static  UnityEngine.Camera.CameraCallbackonPreCull  // 0x0
  public    static  UnityEngine.Camera.CameraCallbackonPreRender  // 0x8
  public    static  UnityEngine.Camera.CameraCallbackonPostRender  // 0x10
METHODS:
  System.IntPtr HGGetPtrUnchecked_Camera(System.Int32 instanceID)
  System.IntPtr HGGetPtrUnchecked()
  System.Void .ctor()
  System.Single get_nearClipPlane()
  System.Void set_nearClipPlane(System.Single value)
  System.Single get_farClipPlane()
  System.Void set_farClipPlane(System.Single value)
  System.Single get_fieldOfView()
  System.Void set_fieldOfView(System.Single value)
  UnityEngine.RenderingPath get_renderingPath()
  System.Void set_renderingPath(UnityEngine.RenderingPath value)
  UnityEngine.RenderingPath get_actualRenderingPath()
  System.Void Reset()
  System.Boolean get_allowHDR()
  System.Void set_allowHDR(System.Boolean value)
  System.Boolean get_allowMSAA()
  System.Void set_allowMSAA(System.Boolean value)
  System.Boolean get_allowDynamicResolution()
  System.Void set_allowDynamicResolution(System.Boolean value)
  System.Boolean get_forceIntoRenderTexture()
  System.Void set_forceIntoRenderTexture(System.Boolean value)
  System.Single get_orthographicSize()
  System.Void set_orthographicSize(System.Single value)
  System.Boolean get_orthographic()
  System.Void set_orthographic(System.Boolean value)
  UnityEngine.Rendering.OpaqueSortMode get_opaqueSortMode()
  System.Void set_opaqueSortMode(UnityEngine.Rendering.OpaqueSortMode value)
  UnityEngine.TransparencySortMode get_transparencySortMode()
  System.Void set_transparencySortMode(UnityEngine.TransparencySortMode value)
  UnityEngine.Vector3 get_transparencySortAxis()
  System.Void set_transparencySortAxis(UnityEngine.Vector3 value)
  System.Void ResetTransparencySortSettings()
  System.Single get_depth()
  System.Void set_depth(System.Single value)
  System.Single get_aspect()
  System.Void set_aspect(System.Single value)
  System.Void ResetAspect()
  UnityEngine.Vector3 get_velocity()
  System.Int32 get_cullingMask()
  System.Void set_cullingMask(System.Int32 value)
  System.Int32 get_eventMask()
  System.Void set_eventMask(System.Int32 value)
  System.Boolean get_layerCullSpherical()
  System.Void set_layerCullSpherical(System.Boolean value)
  UnityEngine.CameraType get_cameraType()
  System.Void set_cameraType(UnityEngine.CameraType value)
  UnityEngine.Material get_skyboxMaterial()
  System.UInt64 get_overrideSceneCullingMask()
  System.Void set_overrideSceneCullingMask(System.UInt64 value)
  System.UInt64 get_sceneCullingMask()
  System.Single[] GetLayerCullDistances()
  System.Void SetLayerCullDistances(System.Single[] d)
  System.Single[] get_layerCullDistances()
  System.Void set_layerCullDistances(System.Single[] value)
  System.Int32 get_PreviewCullingLayer()
  System.Boolean get_useOcclusionCulling()
  System.Void set_useOcclusionCulling(System.Boolean value)
  UnityEngine.Matrix4x4 get_cullingMatrix()
  System.Void set_cullingMatrix(UnityEngine.Matrix4x4 value)
  System.Void ResetCullingMatrix()
  UnityEngine.Color get_backgroundColor()
  System.Void set_backgroundColor(UnityEngine.Color value)
  UnityEngine.CameraClearFlags get_clearFlags()
  System.Void set_clearFlags(UnityEngine.CameraClearFlags value)
  UnityEngine.DepthTextureMode get_depthTextureMode()
  System.Void set_depthTextureMode(UnityEngine.DepthTextureMode value)
  System.Boolean get_clearStencilAfterLightingPass()
  System.Void set_clearStencilAfterLightingPass(System.Boolean value)
  System.Void SetReplacementShader(UnityEngine.Shader shader, System.String replacementTag)
  System.Void ResetReplacementShader()
  UnityEngine.Camera.ProjectionMatrixMode get_projectionMatrixMode()
  System.Boolean get_usePhysicalProperties()
  System.Void set_usePhysicalProperties(System.Boolean value)
  UnityEngine.Vector2 get_sensorSize()
  System.Void set_sensorSize(UnityEngine.Vector2 value)
  UnityEngine.Vector2 get_lensShift()
  System.Void set_lensShift(UnityEngine.Vector2 value)
  System.Single get_focalLength()
  System.Void set_focalLength(System.Single value)
  UnityEngine.Camera.GateFitMode get_gateFit()
  System.Void set_gateFit(UnityEngine.Camera.GateFitMode value)
  System.Single GetGateFittedFieldOfView()
  UnityEngine.Vector2 GetGateFittedLensShift()
  UnityEngine.Vector3 GetLocalSpaceAim()
  UnityEngine.Rect get_rect()
  System.Void set_rect(UnityEngine.Rect value)
  UnityEngine.Rect get_pixelRect()
  System.Void set_pixelRect(UnityEngine.Rect value)
  UnityEngine.RectInt get_pixelRectInt()
  System.Int32 get_pixelWidth()
  System.Int32 get_pixelHeight()
  System.Int32 get_scaledPixelWidth()
  System.Int32 get_scaledPixelHeight()
  UnityEngine.RenderTexture get_targetTexture()
  System.Void set_targetTexture(UnityEngine.RenderTexture value)
  UnityEngine.RenderTexture get_activeTexture()
  System.Int32 get_targetDisplay()
  System.Void set_targetDisplay(System.Int32 value)
  System.Void SetTargetBuffersImpl(UnityEngine.RenderBuffer color, UnityEngine.RenderBuffer depth)
  System.Void SetTargetBuffers(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer)
  System.Void SetTargetBuffersMRTImpl(UnityEngine.RenderBuffer[] color, UnityEngine.RenderBuffer depth)
  System.Void SetTargetBuffers(UnityEngine.RenderBuffer[] colorBuffer, UnityEngine.RenderBuffer depthBuffer)
  System.String[] GetCameraBufferWarnings()
  UnityEngine.Matrix4x4 get_cameraToWorldMatrix()
  UnityEngine.Matrix4x4 get_worldToCameraMatrix()
  System.Void set_worldToCameraMatrix(UnityEngine.Matrix4x4 value)
  UnityEngine.Matrix4x4 get_projectionMatrix()
  System.Void set_projectionMatrix(UnityEngine.Matrix4x4 value)
  UnityEngine.Matrix4x4 get_nonJitteredProjectionMatrix()
  System.Void set_nonJitteredProjectionMatrix(UnityEngine.Matrix4x4 value)
  System.Boolean get_useJitteredProjectionMatrixForTransparentRendering()
  System.Void set_useJitteredProjectionMatrixForTransparentRendering(System.Boolean value)
  UnityEngine.Matrix4x4 get_previousViewProjectionMatrix()
  System.Void ResetWorldToCameraMatrix()
  System.Void ResetProjectionMatrix()
  UnityEngine.Matrix4x4 CalculateObliqueMatrix(UnityEngine.Vector4 clipPlane)
  UnityEngine.Vector3 WorldToScreenPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye)
  UnityEngine.Vector3 WorldToViewportPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye)
  UnityEngine.Vector3 ViewportToWorldPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye)
  UnityEngine.Vector3 ScreenToWorldPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye)
  UnityEngine.Vector3 WorldToScreenPoint(UnityEngine.Vector3 position)
  UnityEngine.Vector3 WorldToViewportPoint(UnityEngine.Vector3 position)
  UnityEngine.Vector3 ViewportToWorldPoint(UnityEngine.Vector3 position)
  UnityEngine.Vector3 ScreenToWorldPoint(UnityEngine.Vector3 position)
  UnityEngine.Vector3 ScreenToViewportPoint(UnityEngine.Vector3 position)
  UnityEngine.Vector3 ViewportToScreenPoint(UnityEngine.Vector3 position)
  UnityEngine.Vector2 GetFrustumPlaneSizeAt(System.Single distance)
  UnityEngine.Ray ViewportPointToRay(UnityEngine.Vector2 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye)
  UnityEngine.Ray ViewportPointToRay(UnityEngine.Vector3 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye)
  UnityEngine.Ray ViewportPointToRay(UnityEngine.Vector3 pos)
  UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector2 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye)
  UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector3 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye)
  UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector3 pos)
  System.Void CalculateFrustumCornersInternal(UnityEngine.Rect viewport, System.Single z, UnityEngine.Camera.MonoOrStereoscopicEye eye, UnityEngine.Vector3[] outCorners)
  System.Void CalculateFrustumCorners(UnityEngine.Rect viewport, System.Single z, UnityEngine.Camera.MonoOrStereoscopicEye eye, UnityEngine.Vector3[] outCorners)
  System.Void CalculateProjectionMatrixFromPhysicalPropertiesInternal(UnityEngine.Matrix4x4& output, System.Single focalLength, UnityEngine.Vector2 sensorSize, UnityEngine.Vector2 lensShift, System.Single nearClip, System.Single farClip, System.Single gateAspect, UnityEngine.Camera.GateFitMode gateFitMode)
  System.Void CalculateProjectionMatrixFromPhysicalProperties(UnityEngine.Matrix4x4& output, System.Single focalLength, UnityEngine.Vector2 sensorSize, UnityEngine.Vector2 lensShift, System.Single nearClip, System.Single farClip, UnityEngine.Camera.GateFitParameters gateFitParameters)
  System.Single FocalLengthToFieldOfView(System.Single focalLength, System.Single sensorSize)
  System.Single FieldOfViewToFocalLength(System.Single fieldOfView, System.Single sensorSize)
  System.Single HorizontalToVerticalFieldOfView(System.Single horizontalFieldOfView, System.Single aspectRatio)
  System.Single VerticalToHorizontalFieldOfView(System.Single verticalFieldOfView, System.Single aspectRatio)
  UnityEngine.Camera get_main()
  UnityEngine.Camera get_current()
  UnityEngine.Camera GetLightWeightCamera()
  System.Void SetLightWeight(System.Boolean flag)
  UnityEngine.SceneManagement.Scene get_scene()
  System.Void set_scene(UnityEngine.SceneManagement.Scene value)
  System.Boolean get_stereoEnabled()
  System.Single get_stereoSeparation()
  System.Void set_stereoSeparation(System.Single value)
  System.Single get_stereoConvergence()
  System.Void set_stereoConvergence(System.Single value)
  System.Boolean get_areVRStereoViewMatricesWithinSingleCullTolerance()
  UnityEngine.StereoTargetEyeMask get_stereoTargetEye()
  System.Void set_stereoTargetEye(UnityEngine.StereoTargetEyeMask value)
  UnityEngine.Camera.MonoOrStereoscopicEye get_stereoActiveEye()
  UnityEngine.Matrix4x4 GetStereoNonJitteredProjectionMatrix(UnityEngine.Camera.StereoscopicEye eye)
  UnityEngine.Matrix4x4 GetStereoViewMatrix(UnityEngine.Camera.StereoscopicEye eye)
  System.Void CopyStereoDeviceProjectionMatrixToNonJittered(UnityEngine.Camera.StereoscopicEye eye)
  UnityEngine.Matrix4x4 GetStereoProjectionMatrix(UnityEngine.Camera.StereoscopicEye eye)
  System.Void SetStereoProjectionMatrix(UnityEngine.Camera.StereoscopicEye eye, UnityEngine.Matrix4x4 matrix)
  System.Void ResetStereoProjectionMatrices()
  System.Void SetStereoViewMatrix(UnityEngine.Camera.StereoscopicEye eye, UnityEngine.Matrix4x4 matrix)
  System.Void ResetStereoViewMatrices()
  System.Int32 GetAllCamerasCount()
  System.Int32 GetAllCamerasImpl(UnityEngine.Camera[] cam)
  System.Int32 get_allCamerasCount()
  UnityEngine.Camera[] get_allCameras()
  System.Int32 GetAllCameras(UnityEngine.Camera[] cameras)
  System.Int32 HGGetAllCamerasCountImpl(System.Boolean includeEditorCameras)
  System.Int32 HGGetAllCamerasImpl(UnityEngine.Camera[] cam, System.Boolean includeEditorCameras)
  System.Int32 HGGetAllCamerasCount(System.Boolean includeEditorCameras)
  System.Int32 HGGetAllCameras(UnityEngine.Camera[] cameras, System.Boolean includeEditorCameras)
  System.Boolean RenderToCubemapImpl(UnityEngine.Texture tex, System.Int32 faceMask)
  System.Boolean RenderToCubemap(UnityEngine.Cubemap cubemap, System.Int32 faceMask)
  System.Boolean RenderToCubemap(UnityEngine.Cubemap cubemap)
  System.Boolean RenderToCubemap(UnityEngine.RenderTexture cubemap, System.Int32 faceMask)
  System.Boolean RenderToCubemap(UnityEngine.RenderTexture cubemap)
  System.Int32 GetFilterMode()
  UnityEngine.Camera.SceneViewFilterMode get_sceneViewFilterMode()
  System.Boolean RenderToCubemapEyeImpl(UnityEngine.RenderTexture cubemap, System.Int32 faceMask, UnityEngine.Camera.MonoOrStereoscopicEye stereoEye)
  System.Boolean RenderToCubemap(UnityEngine.RenderTexture cubemap, System.Int32 faceMask, UnityEngine.Camera.MonoOrStereoscopicEye stereoEye)
  System.Void Render()
  System.Void RenderWithShader(UnityEngine.Shader shader, System.String replacementTag)
  System.Void RenderDontRestore()
  System.Void SubmitRenderRequests(System.Collections.Generic.List<UnityEngine.Camera.RenderRequest> renderRequests)
  System.Void SubmitRenderRequestsInternal(System.Object requests)
  System.Void SetupCurrent(UnityEngine.Camera cur)
  System.Void CopyFrom(UnityEngine.Camera other)
  System.Int32 get_commandBufferCount()
  System.Void RemoveCommandBuffers(UnityEngine.Rendering.CameraEvent evt)
  System.Void RemoveAllCommandBuffers()
  System.Void AddCommandBufferImpl(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer)
  System.Void AddCommandBufferAsyncImpl(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType)
  System.Void RemoveCommandBufferImpl(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer)
  System.Void AddCommandBuffer(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer)
  System.Void AddCommandBufferAsync(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType)
  System.Void RemoveCommandBuffer(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer)
  UnityEngine.Rendering.CommandBuffer[] GetCommandBuffers(UnityEngine.Rendering.CameraEvent evt)
  System.Void FireOnPreCull(UnityEngine.Camera cam)
  System.Void FireOnPreRender(UnityEngine.Camera cam)
  System.Void FireOnPostRender(UnityEngine.Camera cam)
  System.Void OnlyUsedForTesting1()
  System.Void OnlyUsedForTesting2()
  System.Boolean TryGetCullingParameters(UnityEngine.Rendering.ScriptableCullingParameters& cullingParameters)
  System.Boolean TryGetCullingParameters(System.Boolean stereoAware, UnityEngine.Rendering.ScriptableCullingParameters& cullingParameters)
  System.Boolean GetCullingParameters_Internal(UnityEngine.Camera camera, System.Boolean stereoAware, UnityEngine.Rendering.ScriptableCullingParameters& cullingParameters, System.Int32 managedCullingParametersSize)
  System.Void get_transparencySortAxis_Injected(UnityEngine.Vector3& ret)
  System.Void set_transparencySortAxis_Injected(UnityEngine.Vector3& value)
  System.Void get_velocity_Injected(UnityEngine.Vector3& ret)
  System.Void get_cullingMatrix_Injected(UnityEngine.Matrix4x4& ret)
  System.Void set_cullingMatrix_Injected(UnityEngine.Matrix4x4& value)
  System.Void get_backgroundColor_Injected(UnityEngine.Color& ret)
  System.Void set_backgroundColor_Injected(UnityEngine.Color& value)
  System.Void get_sensorSize_Injected(UnityEngine.Vector2& ret)
  System.Void set_sensorSize_Injected(UnityEngine.Vector2& value)
  System.Void get_lensShift_Injected(UnityEngine.Vector2& ret)
  System.Void set_lensShift_Injected(UnityEngine.Vector2& value)
  System.Void GetGateFittedLensShift_Injected(UnityEngine.Vector2& ret)
  System.Void GetLocalSpaceAim_Injected(UnityEngine.Vector3& ret)
  System.Void get_rect_Injected(UnityEngine.Rect& ret)
  System.Void set_rect_Injected(UnityEngine.Rect& value)
  System.Void get_pixelRect_Injected(UnityEngine.Rect& ret)
  System.Void set_pixelRect_Injected(UnityEngine.Rect& value)
  System.Void get_pixelRectInt_Injected(UnityEngine.RectInt& ret)
  System.Void SetTargetBuffersImpl_Injected(UnityEngine.RenderBuffer& color, UnityEngine.RenderBuffer& depth)
  System.Void SetTargetBuffersMRTImpl_Injected(UnityEngine.RenderBuffer[] color, UnityEngine.RenderBuffer& depth)
  System.Void get_cameraToWorldMatrix_Injected(UnityEngine.Matrix4x4& ret)
  System.Void get_worldToCameraMatrix_Injected(UnityEngine.Matrix4x4& ret)
  System.Void set_worldToCameraMatrix_Injected(UnityEngine.Matrix4x4& value)
  System.Void get_projectionMatrix_Injected(UnityEngine.Matrix4x4& ret)
  System.Void set_projectionMatrix_Injected(UnityEngine.Matrix4x4& value)
  System.Void get_nonJitteredProjectionMatrix_Injected(UnityEngine.Matrix4x4& ret)
  System.Void set_nonJitteredProjectionMatrix_Injected(UnityEngine.Matrix4x4& value)
  System.Void get_previousViewProjectionMatrix_Injected(UnityEngine.Matrix4x4& ret)
  System.Void CalculateObliqueMatrix_Injected(UnityEngine.Vector4& clipPlane, UnityEngine.Matrix4x4& ret)
  System.Void WorldToScreenPoint_Injected(UnityEngine.Vector3& position, UnityEngine.Camera.MonoOrStereoscopicEye eye, UnityEngine.Vector3& ret)
  System.Void WorldToViewportPoint_Injected(UnityEngine.Vector3& position, UnityEngine.Camera.MonoOrStereoscopicEye eye, UnityEngine.Vector3& ret)
  System.Void ViewportToWorldPoint_Injected(UnityEngine.Vector3& position, UnityEngine.Camera.MonoOrStereoscopicEye eye, UnityEngine.Vector3& ret)
  System.Void ScreenToWorldPoint_Injected(UnityEngine.Vector3& position, UnityEngine.Camera.MonoOrStereoscopicEye eye, UnityEngine.Vector3& ret)
  System.Void ScreenToViewportPoint_Injected(UnityEngine.Vector3& position, UnityEngine.Vector3& ret)
  System.Void ViewportToScreenPoint_Injected(UnityEngine.Vector3& position, UnityEngine.Vector3& ret)
  System.Void GetFrustumPlaneSizeAt_Injected(System.Single distance, UnityEngine.Vector2& ret)
  System.Void ViewportPointToRay_Injected(UnityEngine.Vector2& pos, UnityEngine.Camera.MonoOrStereoscopicEye eye, UnityEngine.Ray& ret)
  System.Void ScreenPointToRay_Injected(UnityEngine.Vector2& pos, UnityEngine.Camera.MonoOrStereoscopicEye eye, UnityEngine.Ray& ret)
  System.Void CalculateFrustumCornersInternal_Injected(UnityEngine.Rect& viewport, System.Single z, UnityEngine.Camera.MonoOrStereoscopicEye eye, UnityEngine.Vector3[] outCorners)
  System.Void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(UnityEngine.Matrix4x4& output, System.Single focalLength, UnityEngine.Vector2& sensorSize, UnityEngine.Vector2& lensShift, System.Single nearClip, System.Single farClip, System.Single gateAspect, UnityEngine.Camera.GateFitMode gateFitMode)
  System.Void get_scene_Injected(UnityEngine.SceneManagement.Scene& ret)
  System.Void set_scene_Injected(UnityEngine.SceneManagement.Scene& value)
  System.Void GetStereoNonJitteredProjectionMatrix_Injected(UnityEngine.Camera.StereoscopicEye eye, UnityEngine.Matrix4x4& ret)
  System.Void GetStereoViewMatrix_Injected(UnityEngine.Camera.StereoscopicEye eye, UnityEngine.Matrix4x4& ret)
  System.Void GetStereoProjectionMatrix_Injected(UnityEngine.Camera.StereoscopicEye eye, UnityEngine.Matrix4x4& ret)
  System.Void SetStereoProjectionMatrix_Injected(UnityEngine.Camera.StereoscopicEye eye, UnityEngine.Matrix4x4& matrix)
  System.Void SetStereoViewMatrix_Injected(UnityEngine.Camera.StereoscopicEye eye, UnityEngine.Matrix4x4& matrix)
END_CLASS

CLASS: UnityEngine.BoundingSphere
TYPE:  struct
TOKEN: 0x200009E
FIELDS:
  public            UnityEngine.Vector3             position  // 0x10
  public            System.Single                   radius  // 0x1C
METHODS:
  System.Void .ctor(UnityEngine.Vector3 pos, System.Single rad)
END_CLASS

CLASS: UnityEngine.CullingGroupEvent
TYPE:  struct
TOKEN: 0x200009F
FIELDS:
  private           System.Int32                    m_Index  // 0x10
  private           System.Byte                     m_PrevState  // 0x14
  private           System.Byte                     m_ThisState  // 0x15
METHODS:
END_CLASS

CLASS: UnityEngine.CullingGroup
TYPE:  class
TOKEN: 0x20000A0
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
  private           UnityEngine.CullingGroup.StateChangedm_OnStateChanged  // 0x18
METHODS:
  System.Void .ctor()
  System.Void Finalize()
  System.Void DisposeInternal()
  System.Void Dispose()
  System.Void SendEvents(UnityEngine.CullingGroup cullingGroup, System.IntPtr eventsPtr, System.Int32 count)
  System.IntPtr Init(System.Object scripting)
  System.Void FinalizerFailure()
END_CLASS

CLASS: UnityEngine.FlareLayer
TYPE:  class
TOKEN: 0x20000A2
EXTENDS: Behaviour
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.ReflectionProbe
TYPE:  class
TOKEN: 0x20000A3
EXTENDS: Behaviour
FIELDS:
  private   static  System.Action<UnityEngine.ReflectionProbe,UnityEngine.ReflectionProbe.ReflectionProbeEvent>reflectionProbeChanged  // 0x0
  private   static  System.Action<UnityEngine.Cubemap>defaultReflectionSet  // 0x8
  private   static  System.Action<UnityEngine.Texture>defaultReflectionTexture  // 0x10
METHODS:
  UnityEngine.Rendering.ReflectionProbeType get_type()
  System.Void set_type(UnityEngine.Rendering.ReflectionProbeType value)
  UnityEngine.Vector3 get_size()
  System.Void set_size(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_center()
  System.Void set_center(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_rotatedExtents()
  System.Void set_rotatedExtents(UnityEngine.Vector3 value)
  System.Void UpdateRotatedExtentsAndTRS()
  UnityEngine.Vector3 get_boxRotation()
  System.Void set_boxRotation(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_boxInfluenceScale()
  System.Void set_boxInfluenceScale(UnityEngine.Vector3 value)
  UnityEngine.Matrix4x4 get_TRS()
  System.Void set_TRS(UnityEngine.Matrix4x4 value)
  UnityEngine.Matrix4x4 get_TRInverse()
  System.Void set_TRInverse(UnityEngine.Matrix4x4 value)
  System.Single get_falloffDistance()
  System.Void set_falloffDistance(System.Single value)
  System.Single get_cullingDistance()
  System.Void set_cullingDistance(System.Single value)
  System.Single get_nearClipPlane()
  System.Void set_nearClipPlane(System.Single value)
  System.Single get_farClipPlane()
  System.Void set_farClipPlane(System.Single value)
  System.Single get_intensity()
  System.Void set_intensity(System.Single value)
  UnityEngine.Bounds get_bounds()
  System.Boolean get_hdr()
  System.Void set_hdr(System.Boolean value)
  System.Boolean get_renderDynamicObjects()
  System.Void set_renderDynamicObjects(System.Boolean value)
  System.Single get_shadowDistance()
  System.Void set_shadowDistance(System.Single value)
  System.Int32 get_resolution()
  System.Void set_resolution(System.Int32 value)
  System.Int32 get_cullingMask()
  System.Void set_cullingMask(System.Int32 value)
  UnityEngine.Rendering.ReflectionProbeClearFlags get_clearFlags()
  System.Void set_clearFlags(UnityEngine.Rendering.ReflectionProbeClearFlags value)
  UnityEngine.Color get_backgroundColor()
  System.Void set_backgroundColor(UnityEngine.Color value)
  System.Single get_blendDistance()
  System.Void set_blendDistance(System.Single value)
  UnityEngine.Rendering.ReflectionProbeOrientedMode get_oriented()
  System.Void set_oriented(UnityEngine.Rendering.ReflectionProbeOrientedMode value)
  UnityEngine.Rendering.ReflectionProbeShapeType get_shapeType()
  System.Void set_shapeType(UnityEngine.Rendering.ReflectionProbeShapeType value)
  System.Single get_sphereRadius()
  System.Void set_sphereRadius(System.Single value)
  System.Single get_sphereInfluenceScale()
  System.Void set_sphereInfluenceScale(System.Single value)
  UnityEngine.Rendering.ReflectionProbeScopeType get_scopeType()
  System.Void set_scopeType(UnityEngine.Rendering.ReflectionProbeScopeType value)
  System.Int64 get_serializedIdentifier()
  System.Void set_serializedIdentifier(System.Int64 value)
  System.Boolean get_boxProjection()
  System.Void set_boxProjection(System.Boolean value)
  UnityEngine.Rendering.ReflectionProbeMode get_mode()
  System.Void set_mode(UnityEngine.Rendering.ReflectionProbeMode value)
  System.Int32 get_importance()
  System.Void set_importance(System.Int32 value)
  UnityEngine.Rendering.ReflectionProbeRefreshMode get_refreshMode()
  System.Void set_refreshMode(UnityEngine.Rendering.ReflectionProbeRefreshMode value)
  UnityEngine.Rendering.ReflectionProbeTimeSlicingMode get_timeSlicingMode()
  System.Void set_timeSlicingMode(UnityEngine.Rendering.ReflectionProbeTimeSlicingMode value)
  UnityEngine.Texture get_bakedTexture()
  System.Void set_bakedTexture(UnityEngine.Texture value)
  UnityEngine.Texture get_customBakedTexture()
  System.Void set_customBakedTexture(UnityEngine.Texture value)
  UnityEngine.RenderTexture get_realtimeTexture()
  System.Void set_realtimeTexture(UnityEngine.RenderTexture value)
  UnityEngine.Texture get_texture()
  UnityEngine.Rendering.SphericalHarmonicsL2 get_bakedProbeSH()
  System.Void set_bakedProbeSH(UnityEngine.Rendering.SphericalHarmonicsL2 value)
  UnityEngine.Rendering.SphericalHarmonicsL2 get_customBakedProbeSH()
  System.Void set_customBakedProbeSH(UnityEngine.Rendering.SphericalHarmonicsL2 value)
  UnityEngine.Rendering.SphericalHarmonicsL2 get_probeSH()
  UnityEngine.Vector4 get_textureHDRDecodeValues()
  System.String get_texturePath()
  UnityEngine.Hash128 get_probeHash()
  System.Void set_probeHash(UnityEngine.Hash128 value)
  System.Void SetTexturePathWithoutUpdate(System.String texturePath)
  System.Void Reset()
  System.Int32 RenderProbe()
  System.Int32 RenderProbe(UnityEngine.RenderTexture targetTexture)
  System.Boolean IsFinishedRendering(System.Int32 renderId)
  System.Int32 ScheduleRender(UnityEngine.Rendering.ReflectionProbeTimeSlicingMode timeSlicingMode, UnityEngine.RenderTexture targetTexture)
  System.Boolean BlendCubemap(UnityEngine.Texture src, UnityEngine.Texture dst, System.Single blend, UnityEngine.RenderTexture target)
  System.Void UpdateCachedState()
  System.Int32 get_minBakedCubemapResolution()
  System.Int32 get_maxBakedCubemapResolution()
  UnityEngine.Vector4 get_defaultTextureHDRDecodeValues()
  UnityEngine.Texture get_defaultTexture()
  UnityEngine.Rendering.SphericalHarmonicsL2 get_defaultProbeSH()
  System.Void add_reflectionProbeChanged(System.Action<UnityEngine.ReflectionProbe,UnityEngine.ReflectionProbe.ReflectionProbeEvent> value)
  System.Void remove_reflectionProbeChanged(System.Action<UnityEngine.ReflectionProbe,UnityEngine.ReflectionProbe.ReflectionProbeEvent> value)
  System.Void add_defaultReflectionSet(System.Action<UnityEngine.Cubemap> value)
  System.Void remove_defaultReflectionSet(System.Action<UnityEngine.Cubemap> value)
  System.Void add_defaultReflectionTexture(System.Action<UnityEngine.Texture> value)
  System.Void remove_defaultReflectionTexture(System.Action<UnityEngine.Texture> value)
  System.Void CallReflectionProbeEvent(UnityEngine.ReflectionProbe probe, UnityEngine.ReflectionProbe.ReflectionProbeEvent probeEvent)
  System.Void CallSetDefaultReflection(UnityEngine.Texture defaultReflectionCubemap)
  System.Void .ctor()
  System.Void get_size_Injected(UnityEngine.Vector3& ret)
  System.Void set_size_Injected(UnityEngine.Vector3& value)
  System.Void get_center_Injected(UnityEngine.Vector3& ret)
  System.Void set_center_Injected(UnityEngine.Vector3& value)
  System.Void get_rotatedExtents_Injected(UnityEngine.Vector3& ret)
  System.Void set_rotatedExtents_Injected(UnityEngine.Vector3& value)
  System.Void get_boxRotation_Injected(UnityEngine.Vector3& ret)
  System.Void set_boxRotation_Injected(UnityEngine.Vector3& value)
  System.Void get_boxInfluenceScale_Injected(UnityEngine.Vector3& ret)
  System.Void set_boxInfluenceScale_Injected(UnityEngine.Vector3& value)
  System.Void get_TRS_Injected(UnityEngine.Matrix4x4& ret)
  System.Void set_TRS_Injected(UnityEngine.Matrix4x4& value)
  System.Void get_TRInverse_Injected(UnityEngine.Matrix4x4& ret)
  System.Void set_TRInverse_Injected(UnityEngine.Matrix4x4& value)
  System.Void get_bounds_Injected(UnityEngine.Bounds& ret)
  System.Void get_backgroundColor_Injected(UnityEngine.Color& ret)
  System.Void set_backgroundColor_Injected(UnityEngine.Color& value)
  System.Void get_bakedProbeSH_Injected(UnityEngine.Rendering.SphericalHarmonicsL2& ret)
  System.Void set_bakedProbeSH_Injected(UnityEngine.Rendering.SphericalHarmonicsL2& value)
  System.Void get_customBakedProbeSH_Injected(UnityEngine.Rendering.SphericalHarmonicsL2& ret)
  System.Void set_customBakedProbeSH_Injected(UnityEngine.Rendering.SphericalHarmonicsL2& value)
  System.Void get_probeSH_Injected(UnityEngine.Rendering.SphericalHarmonicsL2& ret)
  System.Void get_textureHDRDecodeValues_Injected(UnityEngine.Vector4& ret)
  System.Void get_probeHash_Injected(UnityEngine.Hash128& ret)
  System.Void set_probeHash_Injected(UnityEngine.Hash128& value)
  System.Void get_defaultTextureHDRDecodeValues_Injected(UnityEngine.Vector4& ret)
  System.Void get_defaultProbeSH_Injected(UnityEngine.Rendering.SphericalHarmonicsL2& ret)
END_CLASS

CLASS: UnityEngine.DebugLogHandler
TYPE:  class
TOKEN: 0x20000A5
FIELDS:
METHODS:
  System.Void Internal_Log(UnityEngine.LogType level, UnityEngine.LogOption options, System.String msg, UnityEngine.Object obj)
  System.Void Internal_LogException(System.Exception ex, UnityEngine.Object obj)
  System.Void LogFormat(UnityEngine.LogType logType, UnityEngine.Object context, System.String format, System.Object[] args)
  System.Void LogFormat(UnityEngine.LogType logType, UnityEngine.LogOption logOptions, UnityEngine.Object context, System.String format, System.Object[] args)
  System.Void LogException(System.Exception exception, UnityEngine.Object context)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Debug
TYPE:  class
TOKEN: 0x20000A6
FIELDS:
  private   static readonly UnityEngine.ILogger             s_DefaultLogger  // 0x0
  private   static  UnityEngine.ILogger             s_Logger  // 0x8
METHODS:
  UnityEngine.ILogger get_unityLogger()
  System.Void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Color color, System.Single duration)
  System.Void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Color color)
  System.Void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end)
  System.Void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Color color, System.Single duration, System.Boolean depthTest)
  System.Void DrawRay(UnityEngine.Vector3 start, UnityEngine.Vector3 dir, UnityEngine.Color color, System.Single duration)
  System.Void DrawRay(UnityEngine.Vector3 start, UnityEngine.Vector3 dir, UnityEngine.Color color)
  System.Void DrawRay(UnityEngine.Vector3 start, UnityEngine.Vector3 dir)
  System.Void DrawRay(UnityEngine.Vector3 start, UnityEngine.Vector3 dir, UnityEngine.Color color, System.Single duration, System.Boolean depthTest)
  System.Void Break()
  System.Void DebugBreak()
  System.Int32 ExtractStackTraceNoAlloc(System.Byte* buffer, System.Int32 bufferMax, System.String projectFolder)
  System.Void Log(System.Object message)
  System.Void Log(System.Object message, UnityEngine.Object context)
  System.Void LogFormat(System.String format, System.Object[] args)
  System.Void LogFormat(UnityEngine.Object context, System.String format, System.Object[] args)
  System.Void LogFormat(UnityEngine.LogType logType, UnityEngine.LogOption logOptions, UnityEngine.Object context, System.String format, System.Object[] args)
  System.Void LogError(System.Object message)
  System.Void LogError(System.Object message, UnityEngine.Object context)
  System.Void LogErrorFormat(System.String format, System.Object[] args)
  System.Void LogErrorFormat(UnityEngine.Object context, System.String format, System.Object[] args)
  System.Void LogCritical(System.Object message)
  System.Void LogCritical(System.Object message, UnityEngine.Object context)
  System.Void LogCriticalFormat(System.String format, System.Object[] args)
  System.Void LogCriticalFormat(UnityEngine.Object context, System.String format, System.Object[] args)
  System.Void ClearDeveloperConsole()
  System.Boolean get_developerConsoleEnabled()
  System.Void set_developerConsoleEnabled(System.Boolean value)
  System.Void set_developerConsoleLogType(UnityEngine.LogType value)
  UnityEngine.LogType get_developerConsoleLogType()
  System.Int32 get_developerConsoleLoggingLevel()
  System.Void set_developerConsoleLoggingLevel(System.Int32 value)
  System.Boolean get_developerConsoleVisible()
  System.Void set_developerConsoleVisible(System.Boolean value)
  System.Void LogException(System.Exception exception)
  System.Void LogException(System.Exception exception, UnityEngine.Object context)
  System.Void LogWarning(System.Object message)
  System.Void LogWarning(System.Object message, UnityEngine.Object context)
  System.Void LogWarningFormat(System.String format, System.Object[] args)
  System.Void LogWarningFormat(UnityEngine.Object context, System.String format, System.Object[] args)
  System.Void Assert(System.Boolean condition)
  System.Void Assert(System.Boolean condition, UnityEngine.Object context)
  System.Void Assert(System.Boolean condition, System.Object message)
  System.Void Assert(System.Boolean condition, System.String message)
  System.Void Assert(System.Boolean condition, System.Object message, UnityEngine.Object context)
  System.Void Assert(System.Boolean condition, System.String message, UnityEngine.Object context)
  System.Void AssertFormat(System.Boolean condition, System.String format, System.Object[] args)
  System.Void AssertFormat(System.Boolean condition, UnityEngine.Object context, System.String format, System.Object[] args)
  System.Void LogAssertion(System.Object message)
  System.Void LogAssertion(System.Object message, UnityEngine.Object context)
  System.Void LogAssertionFormat(System.String format, System.Object[] args)
  System.Void LogAssertionFormat(UnityEngine.Object context, System.String format, System.Object[] args)
  System.Boolean get_isDebugBuild()
  System.Void OpenConsoleFile()
  UnityEngine.DiagnosticSwitch[] get_diagnosticSwitches()
  UnityEngine.DiagnosticSwitch GetDiagnosticSwitch(System.String name)
  System.Boolean CallOverridenDebugHandler(System.Exception exception, UnityEngine.Object obj)
  System.Boolean IsLoggingEnabled()
  System.Void SetStripLogInRelease(System.Boolean enable)
  System.Void Assert(System.Boolean condition, System.String format, System.Object[] args)
  UnityEngine.ILogger get_logger()
  System.Void .ctor()
  System.Void .cctor()
  System.Void DrawLine_Injected(UnityEngine.Vector3& start, UnityEngine.Vector3& end, UnityEngine.Color& color, System.Single duration, System.Boolean depthTest)
END_CLASS

CLASS: UnityEngine.DiagnosticSwitch
TYPE:  class
TOKEN: 0x20000A7
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
METHODS:
  System.Void .ctor()
  System.String get_name()
END_CLASS

CLASS: UnityEngine.ExposedReference`1
TYPE:  struct
TOKEN: 0x20000A8
FIELDS:
  public            UnityEngine.PropertyName        exposedName  // 0x0
  public            UnityEngine.Object              defaultValue  // 0x0
METHODS:
  T Resolve(UnityEngine.IExposedPropertyTable resolver)
END_CLASS

CLASS: UnityEngine.IExposedPropertyTable
TYPE:  interface
TOKEN: 0x20000A9
FIELDS:
METHODS:
  UnityEngine.Object GetReferenceValue(UnityEngine.PropertyName id, System.Boolean& idValid)
END_CLASS

CLASS: UnityEngine.Bounds
TYPE:  struct
TOKEN: 0x20000AA
FIELDS:
  private           UnityEngine.Vector3             m_Center  // 0x10
  private           UnityEngine.Vector3             m_Extents  // 0x1C
METHODS:
  System.Void .ctor(UnityEngine.Vector3 center, UnityEngine.Vector3 size)
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(UnityEngine.Bounds other)
  UnityEngine.Vector3 get_center()
  System.Void set_center(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_size()
  System.Void set_size(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_extents()
  System.Void set_extents(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_min()
  System.Void set_min(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_max()
  System.Void set_max(UnityEngine.Vector3 value)
  System.Boolean op_Equality(UnityEngine.Bounds lhs, UnityEngine.Bounds rhs)
  System.Boolean op_Inequality(UnityEngine.Bounds lhs, UnityEngine.Bounds rhs)
  System.Void SetMinMax(UnityEngine.Vector3 min, UnityEngine.Vector3 max)
  System.Void Encapsulate(UnityEngine.Vector3 point)
  System.Void Encapsulate(UnityEngine.Bounds bounds)
  System.Void Expand(System.Single amount)
  System.Void Expand(UnityEngine.Vector3 amount)
  System.Boolean Intersects(UnityEngine.Bounds bounds)
  System.Boolean IntersectRay(UnityEngine.Ray ray)
  System.Boolean IntersectRay(UnityEngine.Ray ray, System.Single& distance)
  System.String ToString()
  System.String ToString(System.String format)
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  System.Boolean Contains(UnityEngine.Vector3 point)
  System.Single SqrDistance(UnityEngine.Vector3 point)
  System.Boolean IntersectRayAABB(UnityEngine.Ray ray, UnityEngine.Bounds bounds, System.Single& dist)
  UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 point)
  System.Boolean Contains_Injected(UnityEngine.Bounds& _unity_self, UnityEngine.Vector3& point)
  System.Single SqrDistance_Injected(UnityEngine.Bounds& _unity_self, UnityEngine.Vector3& point)
  System.Boolean IntersectRayAABB_Injected(UnityEngine.Ray& ray, UnityEngine.Bounds& bounds, System.Single& dist)
  System.Void ClosestPoint_Injected(UnityEngine.Bounds& _unity_self, UnityEngine.Vector3& point, UnityEngine.Vector3& ret)
END_CLASS

CLASS: UnityEngine.BoundsInt
TYPE:  struct
TOKEN: 0x20000AB
FIELDS:
  private           UnityEngine.Vector3Int          m_Position  // 0x10
  private           UnityEngine.Vector3Int          m_Size  // 0x1C
METHODS:
  UnityEngine.Vector3Int get_min()
  System.Void set_min(UnityEngine.Vector3Int value)
  UnityEngine.Vector3Int get_max()
  System.Void set_max(UnityEngine.Vector3Int value)
  System.Int32 get_xMin()
  System.Void set_xMin(System.Int32 value)
  System.Int32 get_yMin()
  System.Void set_yMin(System.Int32 value)
  System.Int32 get_zMin()
  System.Void set_zMin(System.Int32 value)
  System.Int32 get_xMax()
  System.Void set_xMax(System.Int32 value)
  System.Int32 get_yMax()
  System.Void set_yMax(System.Int32 value)
  System.Int32 get_zMax()
  System.Void set_zMax(System.Int32 value)
  UnityEngine.Vector3Int get_size()
  System.Void .ctor(UnityEngine.Vector3Int position, UnityEngine.Vector3Int size)
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(UnityEngine.BoundsInt other)
  System.Int32 GetHashCode()
  UnityEngine.BoundsInt.PositionEnumerator get_allPositionsWithin()
END_CLASS

CLASS: UnityEngine.GeometryUtility
TYPE:  class
TOKEN: 0x20000AD
FIELDS:
METHODS:
  System.Void CalculateFrustumPlanes(UnityEngine.Camera camera, UnityEngine.Plane[] planes)
  System.Void CalculateFrustumPlanes(UnityEngine.Matrix4x4 worldToProjectionMatrix, UnityEngine.Plane[] planes)
  System.Void SPMDCullAABB(UnityEngine.Matrix4x4 viewProj, Unity.Collections.NativeArray<System.Single> centerXs, Unity.Collections.NativeArray<System.Single> centerYs, Unity.Collections.NativeArray<System.Single> centerZs, Unity.Collections.NativeArray<System.Single> halfExtentXs, Unity.Collections.NativeArray<System.Single> halfExtentYs, Unity.Collections.NativeArray<System.Single> halfExtentZs, Unity.Collections.NativeArray<System.Int32> visibilityOut)
  System.Void SPMDCullAABBNoFar(UnityEngine.Matrix4x4 viewProj, Unity.Collections.NativeArray<System.Single> centerXs, Unity.Collections.NativeArray<System.Single> centerYs, Unity.Collections.NativeArray<System.Single> centerZs, Unity.Collections.NativeArray<System.Single> halfExtentXs, Unity.Collections.NativeArray<System.Single> halfExtentYs, Unity.Collections.NativeArray<System.Single> halfExtentZs, Unity.Collections.NativeArray<System.Int32> visibilityOut)
  System.Boolean TestPlanesAABB(UnityEngine.Plane[] planes, UnityEngine.Bounds bounds)
  System.Void Internal_SPMDCullAABB(UnityEngine.Matrix4x4 viewProj, System.UInt32 aabbCount, System.UIntPtr centerXs, System.UIntPtr centerYs, System.UIntPtr centerZs, System.UIntPtr halfExtentXs, System.UIntPtr halfExtentYs, System.UIntPtr halfExtentZs, System.IntPtr visibilityOut)
  System.Void Internal_SPMDCullAABBNoFar(UnityEngine.Matrix4x4 viewProj, System.UInt32 aabbCount, System.UIntPtr centerXs, System.UIntPtr centerYs, System.UIntPtr centerZs, System.UIntPtr halfExtentXs, System.UIntPtr halfExtentYs, System.UIntPtr halfExtentZs, System.IntPtr visibilityOut)
  System.Single DistFromAABBToPoint(UnityEngine.Vector3 bCenter, UnityEngine.Vector3 bExtent, UnityEngine.Vector3 point)
  System.Void Internal_ExtractPlanes(UnityEngine.Plane[] planes, UnityEngine.Matrix4x4 worldToProjectionMatrix)
  System.Boolean TestPlanesAABB_Injected(UnityEngine.Plane[] planes, UnityEngine.Bounds& bounds)
  System.Void Internal_SPMDCullAABB_Injected(UnityEngine.Matrix4x4& viewProj, System.UInt32 aabbCount, System.UIntPtr centerXs, System.UIntPtr centerYs, System.UIntPtr centerZs, System.UIntPtr halfExtentXs, System.UIntPtr halfExtentYs, System.UIntPtr halfExtentZs, System.IntPtr visibilityOut)
  System.Void Internal_SPMDCullAABBNoFar_Injected(UnityEngine.Matrix4x4& viewProj, System.UInt32 aabbCount, System.UIntPtr centerXs, System.UIntPtr centerYs, System.UIntPtr centerZs, System.UIntPtr halfExtentXs, System.UIntPtr halfExtentYs, System.UIntPtr halfExtentZs, System.IntPtr visibilityOut)
  System.Single DistFromAABBToPoint_Injected(UnityEngine.Vector3& bCenter, UnityEngine.Vector3& bExtent, UnityEngine.Vector3& point)
  System.Void Internal_ExtractPlanes_Injected(UnityEngine.Plane[] planes, UnityEngine.Matrix4x4& worldToProjectionMatrix)
END_CLASS

CLASS: UnityEngine.Plane
TYPE:  struct
TOKEN: 0x20000AE
FIELDS:
  private   static  System.Int32                    size  // 0x0
  private           UnityEngine.Vector3             m_Normal  // 0x10
  private           System.Single                   m_Distance  // 0x1C
METHODS:
  UnityEngine.Vector3 get_normal()
  System.Void set_normal(UnityEngine.Vector3 value)
  System.Single get_distance()
  System.Void set_distance(System.Single value)
  System.Void .ctor(UnityEngine.Vector3 inNormal, UnityEngine.Vector3 inPoint)
  System.Void .ctor(UnityEngine.Vector3 inNormal, System.Single d)
  System.Void .ctor(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c)
  System.Void SetNormalAndPosition(UnityEngine.Vector3 inNormal, UnityEngine.Vector3 inPoint)
  System.Single GetDistanceToPoint(UnityEngine.Vector3 point)
  System.Boolean GetSide(UnityEngine.Vector3 point)
  System.Boolean SameSide(UnityEngine.Vector3 inPt0, UnityEngine.Vector3 inPt1)
  System.Boolean Raycast(UnityEngine.Ray ray, System.Single& enter)
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: UnityEngine.Ray
TYPE:  struct
TOKEN: 0x20000AF
FIELDS:
  private           UnityEngine.Vector3             m_Origin  // 0x10
  private           UnityEngine.Vector3             m_Direction  // 0x1C
METHODS:
  System.Void .ctor(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction)
  UnityEngine.Vector3 get_origin()
  System.Void set_origin(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_direction()
  System.Void set_direction(UnityEngine.Vector3 value)
  UnityEngine.Vector3 GetPoint(System.Single distance)
  System.String ToString()
  System.String ToString(System.String format)
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: UnityEngine.Ray2D
TYPE:  struct
TOKEN: 0x20000B0
FIELDS:
  private           UnityEngine.Vector2             m_Origin  // 0x10
  private           UnityEngine.Vector2             m_Direction  // 0x18
METHODS:
  System.Void .ctor(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction)
  UnityEngine.Vector2 get_origin()
  System.Void set_origin(UnityEngine.Vector2 value)
  UnityEngine.Vector2 get_direction()
  System.Void set_direction(UnityEngine.Vector2 value)
  UnityEngine.Vector2 GetPoint(System.Single distance)
  System.String ToString()
  System.String ToString(System.String format)
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: UnityEngine.Rect
TYPE:  struct
TOKEN: 0x20000B1
FIELDS:
  private           System.Single                   m_XMin  // 0x10
  private           System.Single                   m_YMin  // 0x14
  private           System.Single                   m_Width  // 0x18
  private           System.Single                   m_Height  // 0x1C
METHODS:
  System.Void .ctor(System.Single x, System.Single y, System.Single width, System.Single height)
  System.Void .ctor(UnityEngine.Vector2 position, UnityEngine.Vector2 size)
  System.Void .ctor(UnityEngine.Rect source)
  UnityEngine.Rect get_zero()
  UnityEngine.Rect MinMaxRect(System.Single xmin, System.Single ymin, System.Single xmax, System.Single ymax)
  System.Void Set(System.Single x, System.Single y, System.Single width, System.Single height)
  System.Single get_x()
  System.Void set_x(System.Single value)
  System.Single get_y()
  System.Void set_y(System.Single value)
  UnityEngine.Vector2 get_position()
  System.Void set_position(UnityEngine.Vector2 value)
  UnityEngine.Vector2 get_center()
  System.Void set_center(UnityEngine.Vector2 value)
  UnityEngine.Vector2 get_min()
  System.Void set_min(UnityEngine.Vector2 value)
  UnityEngine.Vector2 get_max()
  System.Void set_max(UnityEngine.Vector2 value)
  System.Single get_width()
  System.Void set_width(System.Single value)
  System.Single get_height()
  System.Void set_height(System.Single value)
  UnityEngine.Vector2 get_size()
  System.Void set_size(UnityEngine.Vector2 value)
  System.Single get_xMin()
  System.Void set_xMin(System.Single value)
  System.Single get_yMin()
  System.Void set_yMin(System.Single value)
  System.Single get_xMax()
  System.Void set_xMax(System.Single value)
  System.Single get_yMax()
  System.Void set_yMax(System.Single value)
  System.Boolean Contains(UnityEngine.Vector2 point)
  System.Boolean Contains(UnityEngine.Vector3 point)
  System.Boolean Contains(UnityEngine.Vector3 point, System.Boolean allowInverse)
  UnityEngine.Rect OrderMinMax(UnityEngine.Rect rect)
  System.Boolean Overlaps(UnityEngine.Rect other)
  System.Boolean Overlaps(UnityEngine.Rect other, System.Boolean allowInverse)
  UnityEngine.Vector2 NormalizedToPoint(UnityEngine.Rect rectangle, UnityEngine.Vector2 normalizedRectCoordinates)
  UnityEngine.Vector2 PointToNormalized(UnityEngine.Rect rectangle, UnityEngine.Vector2 point)
  System.Boolean op_Inequality(UnityEngine.Rect lhs, UnityEngine.Rect rhs)
  System.Boolean op_Equality(UnityEngine.Rect lhs, UnityEngine.Rect rhs)
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(UnityEngine.Rect other)
  System.String ToString()
  System.String ToString(System.String format)
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  System.Single get_left()
  System.Single get_right()
  System.Single get_top()
  System.Single get_bottom()
END_CLASS

CLASS: UnityEngine.RectInt
TYPE:  struct
TOKEN: 0x20000B2
FIELDS:
  private           System.Int32                    m_XMin  // 0x10
  private           System.Int32                    m_YMin  // 0x14
  private           System.Int32                    m_Width  // 0x18
  private           System.Int32                    m_Height  // 0x1C
METHODS:
  System.Int32 get_x()
  System.Void set_x(System.Int32 value)
  System.Int32 get_y()
  System.Void set_y(System.Int32 value)
  UnityEngine.Vector2 get_center()
  UnityEngine.Vector2Int get_min()
  System.Void set_min(UnityEngine.Vector2Int value)
  UnityEngine.Vector2Int get_max()
  System.Void set_max(UnityEngine.Vector2Int value)
  System.Int32 get_width()
  System.Void set_width(System.Int32 value)
  System.Int32 get_height()
  System.Void set_height(System.Int32 value)
  System.Int32 get_xMin()
  System.Void set_xMin(System.Int32 value)
  System.Int32 get_yMin()
  System.Void set_yMin(System.Int32 value)
  System.Int32 get_xMax()
  System.Void set_xMax(System.Int32 value)
  System.Int32 get_yMax()
  System.Void set_yMax(System.Int32 value)
  UnityEngine.Vector2Int get_position()
  System.Void set_position(UnityEngine.Vector2Int value)
  UnityEngine.Vector2Int get_size()
  System.Void set_size(UnityEngine.Vector2Int value)
  System.Void SetMinMax(UnityEngine.Vector2Int minPosition, UnityEngine.Vector2Int maxPosition)
  System.Void .ctor(System.Int32 xMin, System.Int32 yMin, System.Int32 width, System.Int32 height)
  System.Void .ctor(UnityEngine.Vector2Int position, UnityEngine.Vector2Int size)
  System.Void ClampToBounds(UnityEngine.RectInt bounds)
  System.Boolean Contains(UnityEngine.Vector2Int position)
  System.Boolean Overlaps(UnityEngine.RectInt other)
  System.String ToString()
  System.String ToString(System.String format)
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  System.Boolean Equals(UnityEngine.RectInt other)
  UnityEngine.RectInt.PositionEnumerator get_allPositionsWithin()
END_CLASS

CLASS: UnityEngine.RectOffset
TYPE:  class
TOKEN: 0x20000B4
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
  private   readonly System.Object                   m_SourceStyle  // 0x18
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Object sourceStyle, System.IntPtr source)
  System.Void Finalize()
  System.Void .ctor(System.Int32 left, System.Int32 right, System.Int32 top, System.Int32 bottom)
  System.String ToString()
  System.String ToString(System.String format)
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  System.Void Destroy()
  System.IntPtr InternalCreate()
  System.Void InternalDestroy(System.IntPtr ptr)
  System.Int32 get_left()
  System.Void set_left(System.Int32 value)
  System.Int32 get_right()
  System.Void set_right(System.Int32 value)
  System.Int32 get_top()
  System.Void set_top(System.Int32 value)
  System.Int32 get_bottom()
  System.Void set_bottom(System.Int32 value)
  System.Int32 get_horizontal()
  System.Int32 get_vertical()
  UnityEngine.Rect Add(UnityEngine.Rect rect)
  UnityEngine.Rect Remove(UnityEngine.Rect rect)
  System.Void Add_Injected(UnityEngine.Rect& rect, UnityEngine.Rect& ret)
  System.Void Remove_Injected(UnityEngine.Rect& rect, UnityEngine.Rect& ret)
END_CLASS

CLASS: UnityEngine.LightingSettings
TYPE:  class
TOKEN: 0x20000B5
FIELDS:
METHODS:
  System.Void LightingSettingsDontStripMe()
END_CLASS

CLASS: UnityEngine.Gizmos
TYPE:  class
TOKEN: 0x20000B6
FIELDS:
METHODS:
  System.Void DrawLine(UnityEngine.Vector3 from, UnityEngine.Vector3 to)
  System.Void DrawWireSphere(UnityEngine.Vector3 center, System.Single radius)
  System.Void DrawSphere(UnityEngine.Vector3 center, System.Single radius)
  System.Void DrawWireCube(UnityEngine.Vector3 center, UnityEngine.Vector3 size)
  System.Void DrawCube(UnityEngine.Vector3 center, UnityEngine.Vector3 size)
  System.Void DrawMesh(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale)
  System.Void DrawWireMesh(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale)
  System.Void DrawMeshWithMaterial(UnityEngine.Mesh mesh, UnityEngine.Material material, System.Int32 submeshIndex, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale)
  System.Void set_color(UnityEngine.Color value)
  System.Void set_matrix(UnityEngine.Matrix4x4 value)
  System.Void DrawFrustum(UnityEngine.Vector3 center, System.Single fov, System.Single maxRange, System.Single minRange, System.Single aspect)
  System.Void DrawRay(UnityEngine.Vector3 from, UnityEngine.Vector3 direction)
  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale)
  System.Void DrawWireMesh(UnityEngine.Mesh mesh)
  System.Void DrawWireMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale)
  System.Void DrawLine_Injected(UnityEngine.Vector3& from, UnityEngine.Vector3& to)
  System.Void DrawWireSphere_Injected(UnityEngine.Vector3& center, System.Single radius)
  System.Void DrawSphere_Injected(UnityEngine.Vector3& center, System.Single radius)
  System.Void DrawWireCube_Injected(UnityEngine.Vector3& center, UnityEngine.Vector3& size)
  System.Void DrawCube_Injected(UnityEngine.Vector3& center, UnityEngine.Vector3& size)
  System.Void DrawMesh_Injected(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale)
  System.Void DrawWireMesh_Injected(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale)
  System.Void DrawMeshWithMaterial_Injected(UnityEngine.Mesh mesh, UnityEngine.Material material, System.Int32 submeshIndex, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale)
  System.Void set_color_Injected(UnityEngine.Color& value)
  System.Void set_matrix_Injected(UnityEngine.Matrix4x4& value)
  System.Void DrawFrustum_Injected(UnityEngine.Vector3& center, System.Single fov, System.Single maxRange, System.Single minRange, System.Single aspect)
END_CLASS

CLASS: UnityEngine.BeforeRenderOrderAttribute
TYPE:  class
TOKEN: 0x20000B7
EXTENDS: Attribute
FIELDS:
  private           System.Int32                    <order>k__BackingField  // 0x10
METHODS:
  System.Int32 get_order()
END_CLASS

CLASS: UnityEngine.BeforeRenderHelper
TYPE:  class
TOKEN: 0x20000B8
FIELDS:
  private   static  System.Collections.Generic.List<UnityEngine.BeforeRenderHelper.OrderBlock>s_OrderBlocks  // 0x0
METHODS:
  System.Int32 GetUpdateOrder(UnityEngine.Events.UnityAction callback)
  System.Void RegisterCallback(UnityEngine.Events.UnityAction callback)
  System.Void UnregisterCallback(UnityEngine.Events.UnityAction callback)
  System.Void Invoke()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.CustomRenderTextureManager
TYPE:  class
TOKEN: 0x20000BA
FIELDS:
  private   static  System.Action<UnityEngine.CustomRenderTexture>textureLoaded  // 0x0
  private   static  System.Action<UnityEngine.CustomRenderTexture>textureUnloaded  // 0x8
METHODS:
  System.Void InvokeOnTextureLoaded_Internal(UnityEngine.CustomRenderTexture source)
  System.Void InvokeOnTextureUnloaded_Internal(UnityEngine.CustomRenderTexture source)
END_CLASS

CLASS: UnityEngine.Display
TYPE:  class
TOKEN: 0x20000BB
FIELDS:
  private           System.IntPtr                   nativeDisplay  // 0x10
  public    static  UnityEngine.Display[]           displays  // 0x0
  private   static  UnityEngine.Display             _mainDisplay  // 0x8
  private   static  System.Int32                    m_ActiveEditorGameViewTarget  // 0x10
  private   static  UnityEngine.Display.DisplaysUpdatedDelegateonDisplaysUpdated  // 0x18
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.IntPtr nativeDisplay)
  System.Int32 get_renderingWidth()
  System.Int32 get_renderingHeight()
  System.Int32 get_systemWidth()
  System.Int32 get_systemHeight()
  UnityEngine.Display.PreTransform get_preTransform()
  System.Void SetRenderingResolution(System.Int32 w, System.Int32 h)
  UnityEngine.Vector3 RelativeMouseAt(UnityEngine.Vector3 inputMouseCoordinates)
  UnityEngine.Display get_main()
  System.Void RecreateDisplayList(System.IntPtr[] nativeDisplay)
  System.Void FireDisplaysUpdated()
  System.Void GetSystemExtImpl(System.IntPtr nativeDisplay, System.Int32& w, System.Int32& h)
  System.Void GetRenderingExtImpl(System.IntPtr nativeDisplay, System.Int32& w, System.Int32& h)
  System.Void SetRenderingResolutionImpl(System.IntPtr nativeDisplay, System.Int32 w, System.Int32 h)
  System.Int32 RelativeMouseAtImpl(System.Int32 x, System.Int32 y, System.Int32& rx, System.Int32& ry)
  System.UInt32 GetPreTransform()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.EnabledOrientation
TYPE:  struct
TOKEN: 0x20000BE
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.EnabledOrientation  kAutorotateToPortrait  // 0x0
  public    static  UnityEngine.EnabledOrientation  kAutorotateToPortraitUpsideDown  // 0x0
  public    static  UnityEngine.EnabledOrientation  kAutorotateToLandscapeLeft  // 0x0
  public    static  UnityEngine.EnabledOrientation  kAutorotateToLandscapeRight  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.FullScreenMode
TYPE:  struct
TOKEN: 0x20000BF
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.FullScreenMode      ExclusiveFullScreen  // 0x0
  public    static  UnityEngine.FullScreenMode      FullScreenWindow  // 0x0
  public    static  UnityEngine.FullScreenMode      MaximizedWindow  // 0x0
  public    static  UnityEngine.FullScreenMode      Windowed  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.RefreshRate
TYPE:  struct
TOKEN: 0x20000C0
FIELDS:
  public            System.UInt32                   numerator  // 0x10
  public            System.UInt32                   denominator  // 0x14
METHODS:
  System.Boolean Equals(UnityEngine.RefreshRate other)
END_CLASS

CLASS: UnityEngine.DisplayInfo
TYPE:  struct
TOKEN: 0x20000C1
FIELDS:
  private           System.UInt64                   handle  // 0x10
  public            System.Int32                    width  // 0x18
  public            System.Int32                    height  // 0x1C
  public            UnityEngine.RefreshRate         refreshRate  // 0x20
  public            UnityEngine.RectInt             workArea  // 0x28
  public            System.String                   name  // 0x38
METHODS:
  System.Boolean Equals(UnityEngine.DisplayInfo other)
END_CLASS

CLASS: UnityEngine.Screen
TYPE:  class
TOKEN: 0x20000C2
FIELDS:
METHODS:
  System.Int32 get_width()
  System.Int32 get_height()
  System.Single get_dpi()
  System.Void RequestOrientation(UnityEngine.ScreenOrientation orient)
  UnityEngine.ScreenOrientation GetScreenOrientation()
  UnityEngine.ScreenOrientation get_orientation()
  System.Void set_orientation(UnityEngine.ScreenOrientation value)
  System.Int32 get_sleepTimeout()
  System.Void set_sleepTimeout(System.Int32 value)
  System.Boolean IsOrientationEnabled(UnityEngine.EnabledOrientation orient)
  System.Void SetOrientationEnabled(UnityEngine.EnabledOrientation orient, System.Boolean enabled)
  System.Boolean get_autorotateToPortrait()
  System.Void set_autorotateToPortrait(System.Boolean value)
  System.Boolean get_autorotateToPortraitUpsideDown()
  System.Void set_autorotateToPortraitUpsideDown(System.Boolean value)
  System.Boolean get_autorotateToLandscapeLeft()
  System.Void set_autorotateToLandscapeLeft(System.Boolean value)
  System.Boolean get_autorotateToLandscapeRight()
  System.Void set_autorotateToLandscapeRight(System.Boolean value)
  UnityEngine.Resolution get_currentResolution()
  System.Boolean get_fullScreen()
  System.Void set_fullScreen(System.Boolean value)
  UnityEngine.FullScreenMode get_fullScreenMode()
  System.Void set_fullScreenMode(UnityEngine.FullScreenMode value)
  UnityEngine.Rect get_safeArea()
  UnityEngine.Rect[] get_cutouts()
  System.Void SetResolution(System.Int32 width, System.Int32 height, UnityEngine.FullScreenMode fullscreenMode, System.Int32 preferredRefreshRate)
  System.Void SetResolution(System.Int32 width, System.Int32 height, UnityEngine.FullScreenMode fullscreenMode)
  System.Void SetResolution(System.Int32 width, System.Int32 height, System.Boolean fullscreen, System.Int32 preferredRefreshRate)
  System.Void SetResolution(System.Int32 width, System.Int32 height, System.Boolean fullscreen)
  UnityEngine.Vector2Int get_mainWindowPosition()
  UnityEngine.DisplayInfo get_mainWindowDisplayInfo()
  System.Void GetDisplayLayout(System.Collections.Generic.List<UnityEngine.DisplayInfo> displayLayout)
  UnityEngine.AsyncOperation MoveMainWindowTo(UnityEngine.DisplayInfo& display, UnityEngine.Vector2Int position)
  UnityEngine.Vector2Int GetMainWindowPosition()
  UnityEngine.DisplayInfo GetMainWindowDisplayInfo()
  System.Void GetDisplayLayoutImpl(System.Collections.Generic.List<UnityEngine.DisplayInfo> displayLayout)
  UnityEngine.AsyncOperation MoveMainWindowImpl(UnityEngine.DisplayInfo& display, UnityEngine.Vector2Int position)
  UnityEngine.Resolution[] get_resolutions()
  System.Single get_brightness()
  System.Void set_brightness(System.Single value)
  System.Boolean get_lockCursor()
  System.Void set_lockCursor(System.Boolean value)
  System.Void .ctor()
  System.Void get_currentResolution_Injected(UnityEngine.Resolution& ret)
  System.Void get_safeArea_Injected(UnityEngine.Rect& ret)
  System.Void GetMainWindowPosition_Injected(UnityEngine.Vector2Int& ret)
  System.Void GetMainWindowDisplayInfo_Injected(UnityEngine.DisplayInfo& ret)
  UnityEngine.AsyncOperation MoveMainWindowImpl_Injected(UnityEngine.DisplayInfo& display, UnityEngine.Vector2Int& position)
END_CLASS

CLASS: UnityEngine.RenderBuffer
TYPE:  struct
TOKEN: 0x20000C3
FIELDS:
  public            System.Int32                    m_RenderTextureInstanceID  // 0x10
  public            System.IntPtr                   m_BufferPtr  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.ComputeBufferMode
TYPE:  struct
TOKEN: 0x20000C4
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ComputeBufferMode   Immutable  // 0x0
  public    static  UnityEngine.ComputeBufferMode   Dynamic  // 0x0
  public    static  UnityEngine.ComputeBufferMode   Circular  // 0x0
  public    static  UnityEngine.ComputeBufferMode   StreamOut  // 0x0
  public    static  UnityEngine.ComputeBufferMode   SubUpdates  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Graphics
TYPE:  class
TOKEN: 0x20000C5
FIELDS:
  private   static readonly System.Int32                    kMaxDrawMeshInstanceCount  // 0x0
  private   static  System.Collections.Generic.Dictionary<System.Int32,UnityEngine.RenderInstancedDataLayout>s_RenderInstancedDataLayouts  // 0x8
METHODS:
  System.Int32 Internal_GetMaxDrawMeshInstanceCount()
  UnityEngine.ColorGamut GetActiveColorGamut()
  UnityEngine.ColorGamut get_activeColorGamut()
  UnityEngine.Rendering.GraphicsTier get_activeTier()
  System.Void set_activeTier(UnityEngine.Rendering.GraphicsTier value)
  System.Int32 get_totalBufferCount()
  System.Int32 get_totalBufferBytes()
  System.Int32 get_totalInternalBufferCount()
  System.Int32 get_totalInternalBufferBytes()
  System.Boolean GetPreserveFramebufferAlpha()
  System.Boolean get_preserveFramebufferAlpha()
  UnityEngine.Rendering.OpenGLESVersion GetMinOpenGLESVersion()
  UnityEngine.Rendering.OpenGLESVersion get_minOpenGLESVersion()
  UnityEngine.RenderBuffer GetActiveColorBuffer()
  UnityEngine.RenderBuffer GetActiveDepthBuffer()
  System.Void Internal_SetNullRT()
  System.Void Internal_SetRTSimple(UnityEngine.RenderBuffer color, UnityEngine.RenderBuffer depth, System.Int32 mip, UnityEngine.CubemapFace face, System.Int32 depthSlice)
  System.Void Internal_SetMRTSimple(UnityEngine.RenderBuffer[] color, UnityEngine.RenderBuffer depth, System.Int32 mip, UnityEngine.CubemapFace face, System.Int32 depthSlice)
  System.Void Internal_SetMRTFullSetup(UnityEngine.RenderBuffer[] color, UnityEngine.RenderBuffer depth, System.Int32 mip, UnityEngine.CubemapFace face, System.Int32 depthSlice, UnityEngine.Rendering.RenderBufferLoadAction[] colorLA, UnityEngine.Rendering.RenderBufferStoreAction[] colorSA, UnityEngine.Rendering.RenderBufferLoadAction depthLA, UnityEngine.Rendering.RenderBufferStoreAction depthSA)
  System.Void Internal_SetRandomWriteTargetRT(System.Int32 index, UnityEngine.RenderTexture uav)
  System.Void Internal_SetRandomWriteTargetBuffer(System.Int32 index, UnityEngine.ComputeBuffer uav, System.Boolean preserveCounterValue)
  System.Void Internal_SetRandomWriteTargetGraphicsBuffer(System.Int32 index, UnityEngine.GraphicsBuffer uav, System.Boolean preserveCounterValue)
  System.Void ClearRandomWriteTargets()
  System.Void CopyTexture_Full(UnityEngine.Texture src, UnityEngine.Texture dst)
  System.Void CopyTexture_Slice_AllMips(UnityEngine.Texture src, System.Int32 srcElement, UnityEngine.Texture dst, System.Int32 dstElement)
  System.Void CopyTexture_Slice(UnityEngine.Texture src, System.Int32 srcElement, System.Int32 srcMip, UnityEngine.Texture dst, System.Int32 dstElement, System.Int32 dstMip)
  System.Void CopyTexture_Region(UnityEngine.Texture src, System.Int32 srcElement, System.Int32 srcMip, System.Int32 srcX, System.Int32 srcY, System.Int32 srcWidth, System.Int32 srcHeight, UnityEngine.Texture dst, System.Int32 dstElement, System.Int32 dstMip, System.Int32 dstX, System.Int32 dstY)
  System.Boolean ConvertTexture_Full(UnityEngine.Texture src, UnityEngine.Texture dst)
  System.Boolean ConvertTexture_Slice(UnityEngine.Texture src, System.Int32 srcElement, UnityEngine.Texture dst, System.Int32 dstElement)
  System.Void CopyBufferImpl(UnityEngine.GraphicsBuffer source, UnityEngine.GraphicsBuffer dest)
  System.Void CopyBufferOffsetImpl(UnityEngine.GraphicsBuffer source, System.Int32 srcOffset, UnityEngine.GraphicsBuffer dest, System.Int32 dstOffset, System.Int32 size)
  System.Void CopyComputeBufferImpl(UnityEngine.ComputeBuffer source, UnityEngine.ComputeBuffer dest)
  System.Void CopyComputeBufferOffsetImpl(UnityEngine.ComputeBuffer source, System.Int32 srcOffset, UnityEngine.ComputeBuffer dest, System.Int32 dstOffset, System.Int32 size)
  System.Void Internal_DrawMeshNow1(UnityEngine.Mesh mesh, System.Int32 subsetIndex, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  System.Void Internal_DrawMeshNow2(UnityEngine.Mesh mesh, System.Int32 subsetIndex, UnityEngine.Matrix4x4 matrix)
  System.Void Internal_DrawTexture(UnityEngine.Internal_DrawTextureArguments& args)
  System.Void Internal_RenderMesh(UnityEngine.RenderParams rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Matrix4x4 objectToWorld, UnityEngine.Matrix4x4* prevObjectToWorld)
  System.Void Internal_RenderMeshInstanced(UnityEngine.RenderParams rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, System.IntPtr instanceData, UnityEngine.RenderInstancedDataLayout layout, System.UInt32 instanceCount)
  System.Void Internal_RenderMeshIndirect(UnityEngine.RenderParams rparams, UnityEngine.Mesh mesh, UnityEngine.GraphicsBuffer commandBuffer, System.Int32 commandCount, System.Int32 startCommand)
  System.Void Internal_RenderMeshPrimitives(UnityEngine.RenderParams rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, System.Int32 instanceCount)
  System.Void Internal_RenderPrimitives(UnityEngine.RenderParams rparams, UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount)
  System.Void Internal_RenderPrimitivesIndexed(UnityEngine.RenderParams rparams, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, System.Int32 indexCount, System.Int32 startIndex, System.Int32 instanceCount)
  System.Void Internal_RenderPrimitivesIndirect(UnityEngine.RenderParams rparams, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer commandBuffer, System.Int32 commandCount, System.Int32 startCommand)
  System.Void Internal_RenderPrimitivesIndexedIndirect(UnityEngine.RenderParams rparams, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.GraphicsBuffer commandBuffer, System.Int32 commandCount, System.Int32 startCommand)
  System.Void Internal_DrawMesh(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, UnityEngine.Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
  System.Void Internal_DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
  System.Void Internal_DrawMeshInstancedProcedural(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds bounds, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
  System.Void Internal_DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
  System.Void Internal_DrawMeshInstancedIndirectGraphicsBuffer(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
  System.Void Internal_DrawProceduralNow(UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount)
  System.Void Internal_DrawProceduralIndexedNow(UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, System.Int32 indexCount, System.Int32 instanceCount)
  System.Void Internal_DrawProceduralIndirectNow(UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset)
  System.Void Internal_DrawProceduralIndexedIndirectNow(UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset)
  System.Void Internal_DrawProceduralIndirectNowGraphicsBuffer(UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset)
  System.Void Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer(UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset)
  System.Void Internal_DrawProcedural(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
  System.Void Internal_DrawProceduralIndexed(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, System.Int32 indexCount, System.Int32 instanceCount, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
  System.Void Internal_DrawProceduralIndirect(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
  System.Void Internal_DrawProceduralIndirectGraphicsBuffer(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
  System.Void Internal_DrawProceduralIndexedIndirect(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
  System.Void Internal_DrawProceduralIndexedIndirectGraphicsBuffer(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
  System.Void Internal_BlitMaterial5(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat, System.Int32 pass, System.Boolean setRT)
  System.Void Internal_BlitMaterial6(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat, System.Int32 pass, System.Boolean setRT, System.Int32 destDepthSlice)
  System.Void Internal_BlitMultiTap4(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat, UnityEngine.Vector2[] offsets)
  System.Void Internal_BlitMultiTap5(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat, UnityEngine.Vector2[] offsets, System.Int32 destDepthSlice)
  System.Void Blit2(UnityEngine.Texture source, UnityEngine.RenderTexture dest)
  System.Void Blit3(UnityEngine.Texture source, UnityEngine.RenderTexture dest, System.Int32 sourceDepthSlice, System.Int32 destDepthSlice)
  System.Void Blit4(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset)
  System.Void Blit5(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, System.Int32 sourceDepthSlice, System.Int32 destDepthSlice)
  System.IntPtr CreateGPUFenceImpl(UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage)
  System.Void WaitOnGPUFenceImpl(System.IntPtr fencePtr, UnityEngine.Rendering.SynchronisationStageFlags stage)
  System.Void ExecuteCommandBuffer(UnityEngine.Rendering.CommandBuffer buffer)
  System.Void ExecuteCommandBufferAsync(UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType)
  System.Int32 GetGfxBufferCount()
  System.Void GetGfxBufferStats(System.Collections.Generic.List<System.Int32> bufferSizes, System.Collections.Generic.List<System.String> bufferNames)
  System.Int64 GetTotalPsoCreationTimeInCPUCycles()
  UnityEngine.PipelineCacheLoadResult GetPipelineCacheLoadResult()
  System.Void DebugRecordRenderGraph(System.UInt32 frameOffset, System.UInt32 count)
  System.Void CheckLoadActionValid(UnityEngine.Rendering.RenderBufferLoadAction load, System.String bufferType)
  System.Void CheckStoreActionValid(UnityEngine.Rendering.RenderBufferStoreAction store, System.String bufferType)
  System.Void SetRenderTargetImpl(UnityEngine.RenderTargetSetup setup)
  System.Void SetRenderTargetImpl(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer, System.Int32 mipLevel, UnityEngine.CubemapFace face, System.Int32 depthSlice)
  System.Void SetRenderTargetImpl(UnityEngine.RenderTexture rt, System.Int32 mipLevel, UnityEngine.CubemapFace face, System.Int32 depthSlice)
  System.Void SetRenderTargetImpl(UnityEngine.RenderBuffer[] colorBuffers, UnityEngine.RenderBuffer depthBuffer, System.Int32 mipLevel, UnityEngine.CubemapFace face, System.Int32 depthSlice)
  System.Void SetRenderTarget(UnityEngine.RenderTexture rt, System.Int32 mipLevel, UnityEngine.CubemapFace face, System.Int32 depthSlice)
  System.Void SetRenderTarget(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer, System.Int32 mipLevel, UnityEngine.CubemapFace face, System.Int32 depthSlice)
  System.Void SetRenderTarget(UnityEngine.RenderBuffer[] colorBuffers, UnityEngine.RenderBuffer depthBuffer)
  System.Void SetRenderTarget(UnityEngine.RenderTargetSetup setup)
  UnityEngine.RenderBuffer get_activeColorBuffer()
  UnityEngine.RenderBuffer get_activeDepthBuffer()
  System.Void SetRandomWriteTarget(System.Int32 index, UnityEngine.RenderTexture uav)
  System.Void SetRandomWriteTarget(System.Int32 index, UnityEngine.ComputeBuffer uav, System.Boolean preserveCounterValue)
  System.Void SetRandomWriteTarget(System.Int32 index, UnityEngine.GraphicsBuffer uav, System.Boolean preserveCounterValue)
  System.Void CopyTexture(UnityEngine.Texture src, UnityEngine.Texture dst)
  System.Void CopyTexture(UnityEngine.Texture src, System.Int32 srcElement, UnityEngine.Texture dst, System.Int32 dstElement)
  System.Void CopyTexture(UnityEngine.Texture src, System.Int32 srcElement, System.Int32 srcMip, UnityEngine.Texture dst, System.Int32 dstElement, System.Int32 dstMip)
  System.Void CopyTexture(UnityEngine.Texture src, System.Int32 srcElement, System.Int32 srcMip, System.Int32 srcX, System.Int32 srcY, System.Int32 srcWidth, System.Int32 srcHeight, UnityEngine.Texture dst, System.Int32 dstElement, System.Int32 dstMip, System.Int32 dstX, System.Int32 dstY)
  System.Boolean ConvertTexture(UnityEngine.Texture src, UnityEngine.Texture dst)
  System.Boolean ConvertTexture(UnityEngine.Texture src, System.Int32 srcElement, UnityEngine.Texture dst, System.Int32 dstElement)
  UnityEngine.Rendering.GraphicsFence CreateAsyncGraphicsFence(UnityEngine.Rendering.SynchronisationStage stage)
  UnityEngine.Rendering.GraphicsFence CreateAsyncGraphicsFence()
  UnityEngine.Rendering.GraphicsFence CreateGraphicsFence(UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage)
  System.Void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence fence)
  System.Void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence fence, UnityEngine.Rendering.SynchronisationStage stage)
  System.Void ValidateCopyBuffer(UnityEngine.GraphicsBuffer source, UnityEngine.GraphicsBuffer dest)
  System.Void ValidateCopyBuffer(UnityEngine.GraphicsBuffer source, System.Int32 srcOffset, UnityEngine.GraphicsBuffer dest, System.Int32 dstOffset, System.Int32 size)
  System.Void ValidateCopyBuffer(UnityEngine.ComputeBuffer source, UnityEngine.ComputeBuffer dest)
  System.Void ValidateCopyBuffer(UnityEngine.ComputeBuffer source, System.Int32 srcOffset, UnityEngine.ComputeBuffer dest, System.Int32 dstOffset, System.Int32 size)
  System.Void CopyBuffer(UnityEngine.GraphicsBuffer source, UnityEngine.GraphicsBuffer dest)
  System.Void CopyBuffer(UnityEngine.GraphicsBuffer source, System.Int32 srcOffset, UnityEngine.GraphicsBuffer dest, System.Int32 dstOffset, System.Int32 size)
  System.Void CopyBuffer(UnityEngine.ComputeBuffer source, UnityEngine.ComputeBuffer dest)
  System.Void CopyBuffer(UnityEngine.ComputeBuffer source, System.Int32 srcOffset, UnityEngine.ComputeBuffer dest, System.Int32 dstOffset, System.Int32 size)
  System.Void DrawTextureImpl(UnityEngine.Rect screenRect, UnityEngine.Texture texture, UnityEngine.Rect sourceRect, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, UnityEngine.Color color, UnityEngine.Material mat, System.Int32 pass)
  System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, UnityEngine.Rect sourceRect, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, UnityEngine.Color color, UnityEngine.Material mat, System.Int32 pass)
  System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, UnityEngine.Rect sourceRect, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, UnityEngine.Material mat, System.Int32 pass)
  System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, UnityEngine.Material mat, System.Int32 pass)
  System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, UnityEngine.Material mat, System.Int32 pass)
  System.Void RenderMesh(UnityEngine.RenderParams& rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Matrix4x4 objectToWorld, System.Nullable<UnityEngine.Matrix4x4> prevObjectToWorld)
  UnityEngine.RenderInstancedDataLayout GetCachedRenderInstancedDataLayout(System.Type type)
  System.Void RenderMeshInstanced(UnityEngine.RenderParams& rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, T[] instanceData, System.Int32 instanceCount, System.Int32 startInstance)
  System.Void RenderMeshInstanced(UnityEngine.RenderParams& rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, System.Collections.Generic.List<T> instanceData, System.Int32 instanceCount, System.Int32 startInstance)
  System.Void RenderMeshInstanced(UnityEngine.RenderParams rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, Unity.Collections.NativeArray<T> instanceData, System.Int32 instanceCount, System.Int32 startInstance)
  System.Void RenderMeshIndirect(UnityEngine.RenderParams& rparams, UnityEngine.Mesh mesh, UnityEngine.GraphicsBuffer commandBuffer, System.Int32 commandCount, System.Int32 startCommand)
  System.Void RenderMeshPrimitives(UnityEngine.RenderParams& rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, System.Int32 instanceCount)
  System.Void RenderPrimitives(UnityEngine.RenderParams& rparams, UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount)
  System.Void RenderPrimitivesIndexed(UnityEngine.RenderParams& rparams, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, System.Int32 indexCount, System.Int32 startIndex, System.Int32 instanceCount)
  System.Void RenderPrimitivesIndirect(UnityEngine.RenderParams& rparams, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer commandBuffer, System.Int32 commandCount, System.Int32 startCommand)
  System.Void RenderPrimitivesIndexedIndirect(UnityEngine.RenderParams& rparams, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.GraphicsBuffer commandBuffer, System.Int32 commandCount, System.Int32 startCommand)
  System.Void DrawMeshNow(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Int32 materialIndex)
  System.Void DrawMeshNow(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, System.Int32 materialIndex)
  System.Void DrawMeshNow(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  System.Void DrawMeshNow(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix)
  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, System.Boolean castShadows, System.Boolean receiveShadows, System.Boolean useLightProbes)
  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, UnityEngine.Transform probeAnchor, System.Boolean useLightProbes)
  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, System.Boolean castShadows, System.Boolean receiveShadows, System.Boolean useLightProbes)
  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, UnityEngine.Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
  System.Void DrawMeshInstancedProcedural(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds bounds, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
  System.Void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
  System.Void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
  System.Void DrawProceduralNow(UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount)
  System.Void DrawProceduralNow(UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, System.Int32 indexCount, System.Int32 instanceCount)
  System.Void DrawProceduralIndirectNow(UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset)
  System.Void DrawProceduralIndirectNow(UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset)
  System.Void DrawProceduralIndirectNow(UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset)
  System.Void DrawProceduralIndirectNow(UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset)
  System.Void DrawProcedural(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
  System.Void DrawProcedural(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, System.Int32 indexCount, System.Int32 instanceCount, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
  System.Void DrawProceduralIndirect(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
  System.Void DrawProceduralIndirect(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
  System.Void DrawProceduralIndirect(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
  System.Void DrawProceduralIndirect(UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
  System.Void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest)
  System.Void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest, System.Int32 sourceDepthSlice, System.Int32 destDepthSlice)
  System.Void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset)
  System.Void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, System.Int32 sourceDepthSlice, System.Int32 destDepthSlice)
  System.Void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat, System.Int32 pass)
  System.Void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat, System.Int32 pass, System.Int32 destDepthSlice)
  System.Void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat)
  System.Void Blit(UnityEngine.Texture source, UnityEngine.Material mat, System.Int32 pass)
  System.Void Blit(UnityEngine.Texture source, UnityEngine.Material mat, System.Int32 pass, System.Int32 destDepthSlice)
  System.Void Blit(UnityEngine.Texture source, UnityEngine.Material mat)
  System.Void BlitMultiTap(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat, UnityEngine.Vector2[] offsets)
  System.Void BlitMultiTap(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat, System.Int32 destDepthSlice, UnityEngine.Vector2[] offsets)
  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer)
  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera)
  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex)
  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties)
  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, System.Boolean castShadows)
  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, System.Boolean castShadows, System.Boolean receiveShadows)
  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows)
  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows)
  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, UnityEngine.Transform probeAnchor)
  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer)
  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera)
  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex)
  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties)
  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, System.Boolean castShadows)
  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, System.Boolean castShadows, System.Boolean receiveShadows)
  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows)
  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows)
  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, UnityEngine.Transform probeAnchor)
  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, UnityEngine.Transform probeAnchor, System.Boolean useLightProbes)
  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, System.Int32 submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, UnityEngine.Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices)
  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, System.Int32 count)
  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, System.Int32 count, UnityEngine.MaterialPropertyBlock properties)
  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows)
  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows)
  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera)
  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices)
  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices, UnityEngine.MaterialPropertyBlock properties)
  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows)
  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows)
  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera)
  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
  System.Void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
  System.Void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds bounds, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
  System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, UnityEngine.Rect sourceRect, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, UnityEngine.Color color, UnityEngine.Material mat)
  System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, UnityEngine.Rect sourceRect, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, UnityEngine.Color color)
  System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, UnityEngine.Rect sourceRect, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, UnityEngine.Material mat)
  System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, UnityEngine.Rect sourceRect, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder)
  System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder, UnityEngine.Material mat)
  System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, System.Int32 leftBorder, System.Int32 rightBorder, System.Int32 topBorder, System.Int32 bottomBorder)
  System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture, UnityEngine.Material mat)
  System.Void DrawTexture(UnityEngine.Rect screenRect, UnityEngine.Texture texture)
  System.Void SetRenderTarget(UnityEngine.RenderTexture rt)
  System.Void SetRenderTarget(UnityEngine.RenderTexture rt, System.Int32 mipLevel)
  System.Void SetRenderTarget(UnityEngine.RenderTexture rt, System.Int32 mipLevel, UnityEngine.CubemapFace face)
  System.Void SetRenderTarget(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer)
  System.Void SetRenderTarget(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer, System.Int32 mipLevel)
  System.Void SetRenderTarget(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer, System.Int32 mipLevel, UnityEngine.CubemapFace face)
  System.Void SetRandomWriteTarget(System.Int32 index, UnityEngine.ComputeBuffer uav)
  System.Void SetRandomWriteTarget(System.Int32 index, UnityEngine.GraphicsBuffer uav)
  System.Void .ctor()
  System.Void .cctor()
  System.Void GetActiveColorBuffer_Injected(UnityEngine.RenderBuffer& ret)
  System.Void GetActiveDepthBuffer_Injected(UnityEngine.RenderBuffer& ret)
  System.Void Internal_SetRTSimple_Injected(UnityEngine.RenderBuffer& color, UnityEngine.RenderBuffer& depth, System.Int32 mip, UnityEngine.CubemapFace face, System.Int32 depthSlice)
  System.Void Internal_SetMRTSimple_Injected(UnityEngine.RenderBuffer[] color, UnityEngine.RenderBuffer& depth, System.Int32 mip, UnityEngine.CubemapFace face, System.Int32 depthSlice)
  System.Void Internal_SetMRTFullSetup_Injected(UnityEngine.RenderBuffer[] color, UnityEngine.RenderBuffer& depth, System.Int32 mip, UnityEngine.CubemapFace face, System.Int32 depthSlice, UnityEngine.Rendering.RenderBufferLoadAction[] colorLA, UnityEngine.Rendering.RenderBufferStoreAction[] colorSA, UnityEngine.Rendering.RenderBufferLoadAction depthLA, UnityEngine.Rendering.RenderBufferStoreAction depthSA)
  System.Void Internal_DrawMeshNow1_Injected(UnityEngine.Mesh mesh, System.Int32 subsetIndex, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation)
  System.Void Internal_DrawMeshNow2_Injected(UnityEngine.Mesh mesh, System.Int32 subsetIndex, UnityEngine.Matrix4x4& matrix)
  System.Void Internal_RenderMesh_Injected(UnityEngine.RenderParams& rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Matrix4x4& objectToWorld, UnityEngine.Matrix4x4* prevObjectToWorld)
  System.Void Internal_RenderMeshInstanced_Injected(UnityEngine.RenderParams& rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, System.IntPtr instanceData, UnityEngine.RenderInstancedDataLayout& layout, System.UInt32 instanceCount)
  System.Void Internal_RenderMeshIndirect_Injected(UnityEngine.RenderParams& rparams, UnityEngine.Mesh mesh, UnityEngine.GraphicsBuffer commandBuffer, System.Int32 commandCount, System.Int32 startCommand)
  System.Void Internal_RenderMeshPrimitives_Injected(UnityEngine.RenderParams& rparams, UnityEngine.Mesh mesh, System.Int32 submeshIndex, System.Int32 instanceCount)
  System.Void Internal_RenderPrimitives_Injected(UnityEngine.RenderParams& rparams, UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount)
  System.Void Internal_RenderPrimitivesIndexed_Injected(UnityEngine.RenderParams& rparams, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, System.Int32 indexCount, System.Int32 startIndex, System.Int32 instanceCount)
  System.Void Internal_RenderPrimitivesIndirect_Injected(UnityEngine.RenderParams& rparams, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer commandBuffer, System.Int32 commandCount, System.Int32 startCommand)
  System.Void Internal_RenderPrimitivesIndexedIndirect_Injected(UnityEngine.RenderParams& rparams, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.GraphicsBuffer commandBuffer, System.Int32 commandCount, System.Int32 startCommand)
  System.Void Internal_DrawMesh_Injected(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Matrix4x4& matrix, UnityEngine.Material material, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, UnityEngine.Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
  System.Void Internal_DrawMeshInstancedProcedural_Injected(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds& bounds, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
  System.Void Internal_DrawMeshInstancedIndirect_Injected(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds& bounds, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
  System.Void Internal_DrawMeshInstancedIndirectGraphicsBuffer_Injected(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, UnityEngine.Bounds& bounds, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume)
  System.Void Internal_DrawProcedural_Injected(UnityEngine.Material material, UnityEngine.Bounds& bounds, UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
  System.Void Internal_DrawProceduralIndexed_Injected(UnityEngine.Material material, UnityEngine.Bounds& bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, System.Int32 indexCount, System.Int32 instanceCount, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
  System.Void Internal_DrawProceduralIndirect_Injected(UnityEngine.Material material, UnityEngine.Bounds& bounds, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
  System.Void Internal_DrawProceduralIndirectGraphicsBuffer_Injected(UnityEngine.Material material, UnityEngine.Bounds& bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
  System.Void Internal_DrawProceduralIndexedIndirect_Injected(UnityEngine.Material material, UnityEngine.Bounds& bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
  System.Void Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected(UnityEngine.Material material, UnityEngine.Bounds& bounds, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.GraphicsBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, System.Boolean receiveShadows, System.Int32 layer)
  System.Void Blit4_Injected(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Vector2& scale, UnityEngine.Vector2& offset)
  System.Void Blit5_Injected(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Vector2& scale, UnityEngine.Vector2& offset, System.Int32 sourceDepthSlice, System.Int32 destDepthSlice)
END_CLASS

CLASS: UnityEngine.GL
TYPE:  class
TOKEN: 0x20000C6
FIELDS:
METHODS:
  System.Void Vertex3(System.Single x, System.Single y, System.Single z)
  System.Void TexCoord3(System.Single x, System.Single y, System.Single z)
  System.Void TexCoord2(System.Single x, System.Single y)
  System.Void ImmediateColor(System.Single r, System.Single g, System.Single b, System.Single a)
  System.Void Color(UnityEngine.Color c)
  System.Boolean get_wireframe()
  System.Void set_sRGBWrite(System.Boolean value)
  System.Void SetViewMatrix(UnityEngine.Matrix4x4 m)
  System.Void set_modelview(UnityEngine.Matrix4x4 value)
  System.Void PushMatrix()
  System.Void PopMatrix()
  System.Void LoadOrtho()
  System.Void LoadProjectionMatrix(UnityEngine.Matrix4x4 mat)
  UnityEngine.Matrix4x4 GetGPUProjectionMatrix(UnityEngine.Matrix4x4 proj, System.Boolean renderIntoTexture)
  System.Void GLLoadPixelMatrixScript(System.Single left, System.Single right, System.Single bottom, System.Single top)
  System.Void LoadPixelMatrix(System.Single left, System.Single right, System.Single bottom, System.Single top)
  System.Void GLIssuePluginEvent(System.IntPtr callback, System.Int32 eventID)
  System.Void IssuePluginEvent(System.IntPtr callback, System.Int32 eventID)
  System.Void Begin(System.Int32 mode)
  System.Void End()
  System.Void GLClear(System.Boolean clearDepth, System.Boolean clearColor, UnityEngine.Color backgroundColor, System.Single depth)
  System.Void Clear(System.Boolean clearDepth, System.Boolean clearColor, UnityEngine.Color backgroundColor, System.Single depth)
  System.Void Clear(System.Boolean clearDepth, System.Boolean clearColor, UnityEngine.Color backgroundColor)
  System.Void Viewport(UnityEngine.Rect pixelRect)
  System.Void SetViewMatrix_Injected(UnityEngine.Matrix4x4& m)
  System.Void LoadProjectionMatrix_Injected(UnityEngine.Matrix4x4& mat)
  System.Void GetGPUProjectionMatrix_Injected(UnityEngine.Matrix4x4& proj, System.Boolean renderIntoTexture, UnityEngine.Matrix4x4& ret)
  System.Void GLClear_Injected(System.Boolean clearDepth, System.Boolean clearColor, UnityEngine.Color& backgroundColor, System.Single depth)
  System.Void Viewport_Injected(UnityEngine.Rect& pixelRect)
END_CLASS

CLASS: UnityEngine.ScalableBufferManager
TYPE:  class
TOKEN: 0x20000C7
FIELDS:
METHODS:
  System.Single get_widthScaleFactor()
  System.Single get_heightScaleFactor()
  System.Void ResizeBuffers(System.Single widthScale, System.Single heightScale)
END_CLASS

CLASS: UnityEngine.LightmapData
TYPE:  class
TOKEN: 0x20000C8
FIELDS:
  private           UnityEngine.Texture2D           m_Light  // 0x10
  private           UnityEngine.Texture2D           m_Dir  // 0x18
  private           UnityEngine.Texture2D           m_ShadowMask  // 0x20
METHODS:
  UnityEngine.Texture2D get_lightmapColor()
  System.Void set_lightmapColor(UnityEngine.Texture2D value)
  UnityEngine.Texture2D get_lightmapDir()
  System.Void set_lightmapDir(UnityEngine.Texture2D value)
  UnityEngine.Texture2D get_shadowMask()
  System.Void set_shadowMask(UnityEngine.Texture2D value)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.LightmapSettings
TYPE:  class
TOKEN: 0x20000C9
FIELDS:
METHODS:
  System.Void set_lightmaps(UnityEngine.LightmapData[] value)
END_CLASS

CLASS: UnityEngine.LightProbes
TYPE:  class
TOKEN: 0x20000CA
FIELDS:
  private   static  System.Action                   tetrahedralizationCompleted  // 0x0
  private   static  System.Action                   needsRetetrahedralization  // 0x8
METHODS:
  System.Void .ctor()
  System.Void add_tetrahedralizationCompleted(System.Action value)
  System.Void remove_tetrahedralizationCompleted(System.Action value)
  System.Void Internal_CallTetrahedralizationCompletedFunction()
  System.Void add_needsRetetrahedralization(System.Action value)
  System.Void remove_needsRetetrahedralization(System.Action value)
  System.Void Internal_CallNeedsRetetrahedralizationFunction()
  System.Void Tetrahedralize()
  System.Void TetrahedralizeAsync()
  System.Void GetInterpolatedProbe(UnityEngine.Vector3 position, UnityEngine.Renderer renderer, UnityEngine.Rendering.SphericalHarmonicsL2& probe)
  System.Boolean AreLightProbesAllowed(UnityEngine.Renderer renderer)
  System.Void CalculateInterpolatedLightAndOcclusionProbes(UnityEngine.Vector3[] positions, UnityEngine.Rendering.SphericalHarmonicsL2[] lightProbes, UnityEngine.Vector4[] occlusionProbes)
  System.Void CalculateInterpolatedLightAndOcclusionProbes(UnityEngine.Vector3[] positions, System.Int32 count, UnityEngine.Rendering.SphericalHarmonicsL2[] lightProbes, UnityEngine.Vector4[] occlusionProbes)
  System.Void CalculateInterpolatedLightAndOcclusionProbes(System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Rendering.SphericalHarmonicsL2> lightProbes, System.Collections.Generic.List<UnityEngine.Vector4> occlusionProbes)
  System.Void CalculateInterpolatedLightAndOcclusionProbes(System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Int32 count, System.Collections.Generic.List<UnityEngine.Rendering.SphericalHarmonicsL2> lightProbes, System.Collections.Generic.List<UnityEngine.Vector4> occlusionProbes)
  System.Void CalculateInterpolatedLightAndOcclusionProbes_Internal(UnityEngine.Vector3[] positions, System.Int32 positionsCount, UnityEngine.Rendering.SphericalHarmonicsL2[] lightProbes, UnityEngine.Vector4[] occlusionProbes)
  UnityEngine.Vector3[] get_positions()
  UnityEngine.Rendering.SphericalHarmonicsL2[] get_bakedProbes()
  System.Void set_bakedProbes(UnityEngine.Rendering.SphericalHarmonicsL2[] value)
  System.Int32 get_count()
  System.Int32 get_cellCount()
  System.Int32 GetCount()
  System.Void GetInterpolatedLightProbe(UnityEngine.Vector3 position, UnityEngine.Renderer renderer, System.Single[] coefficients)
  System.Single[] get_coefficients()
  System.Void set_coefficients(System.Single[] value)
  System.Void GetInterpolatedProbe_Injected(UnityEngine.Vector3& position, UnityEngine.Renderer renderer, UnityEngine.Rendering.SphericalHarmonicsL2& probe)
END_CLASS

CLASS: UnityEngine.HDROutputSettings
TYPE:  class
TOKEN: 0x20000CB
FIELDS:
  private           System.Int32                    m_DisplayIndex  // 0x10
  public    static  UnityEngine.HDROutputSettings[] displays  // 0x0
  private   static  UnityEngine.HDROutputSettings   _mainDisplay  // 0x8
METHODS:
  System.Void .ctor()
  UnityEngine.HDROutputSettings get_main()
  System.Boolean get_active()
  System.Boolean GetActive(System.Int32 displayIndex)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Resolution
TYPE:  struct
TOKEN: 0x20000CC
FIELDS:
  private           System.Int32                    m_Width  // 0x10
  private           System.Int32                    m_Height  // 0x14
  private           System.Int32                    m_RefreshRate  // 0x18
METHODS:
  System.Int32 get_width()
  System.Int32 get_height()
  System.Int32 get_refreshRate()
  System.String ToString()
END_CLASS

CLASS: UnityEngine.RenderTargetSetup
TYPE:  struct
TOKEN: 0x20000CD
FIELDS:
  public            UnityEngine.RenderBuffer[]      color  // 0x10
  public            UnityEngine.RenderBuffer        depth  // 0x18
  public            System.Int32                    mipLevel  // 0x28
  public            UnityEngine.CubemapFace         cubemapFace  // 0x2C
  public            System.Int32                    depthSlice  // 0x30
  public            UnityEngine.Rendering.RenderBufferLoadAction[]colorLoad  // 0x38
  public            UnityEngine.Rendering.RenderBufferStoreAction[]colorStore  // 0x40
  public            UnityEngine.Rendering.RenderBufferLoadActiondepthLoad  // 0x48
  public            UnityEngine.Rendering.RenderBufferStoreActiondepthStore  // 0x4C
METHODS:
END_CLASS

CLASS: UnityEngine.RenderParams
TYPE:  struct
TOKEN: 0x20000CE
FIELDS:
  private           System.Int32                    <layer>k__BackingField  // 0x10
  private           System.UInt32                   <renderingLayerMask>k__BackingField  // 0x14
  private           System.Int32                    <rendererPriority>k__BackingField  // 0x18
  private           UnityEngine.Bounds              <worldBounds>k__BackingField  // 0x1C
  private           UnityEngine.Camera              <camera>k__BackingField  // 0x38
  private           UnityEngine.MotionVectorGenerationMode<motionVectorMode>k__BackingField  // 0x40
  private           UnityEngine.Rendering.ReflectionProbeUsage<reflectionProbeUsage>k__BackingField  // 0x44
  private           UnityEngine.Material            <material>k__BackingField  // 0x48
  private           UnityEngine.MaterialPropertyBlock<matProps>k__BackingField  // 0x50
  private           UnityEngine.Rendering.ShadowCastingMode<shadowCastingMode>k__BackingField  // 0x58
  private           System.Boolean                  <receiveShadows>k__BackingField  // 0x5C
  private           UnityEngine.Rendering.LightProbeUsage<lightProbeUsage>k__BackingField  // 0x60
  private           UnityEngine.LightProbeProxyVolume<lightProbeProxyVolume>k__BackingField  // 0x68
METHODS:
  UnityEngine.Material get_material()
END_CLASS

CLASS: UnityEngine.RenderInstancedDataLayout
TYPE:  struct
TOKEN: 0x20000CF
FIELDS:
  private   readonly System.Int32                    <size>k__BackingField  // 0x10
  private   readonly System.Int32                    <offsetObjectToWorld>k__BackingField  // 0x14
  private   readonly System.Int32                    <offsetPrevObjectToWorld>k__BackingField  // 0x18
  private   readonly System.Int32                    <offsetRenderingLayerMask>k__BackingField  // 0x1C
METHODS:
  System.Void .ctor(System.Type t)
END_CLASS

CLASS: UnityEngine.Internal_DrawTextureArguments
TYPE:  struct
TOKEN: 0x20000D0
FIELDS:
  public            UnityEngine.Rect                screenRect  // 0x10
  public            UnityEngine.Rect                sourceRect  // 0x20
  public            System.Int32                    leftBorder  // 0x30
  public            System.Int32                    rightBorder  // 0x34
  public            System.Int32                    topBorder  // 0x38
  public            System.Int32                    bottomBorder  // 0x3C
  public            UnityEngine.Color               leftBorderColor  // 0x40
  public            UnityEngine.Color               rightBorderColor  // 0x50
  public            UnityEngine.Color               topBorderColor  // 0x60
  public            UnityEngine.Color               bottomBorderColor  // 0x70
  public            UnityEngine.Color               color  // 0x80
  public            UnityEngine.Vector4             borderWidths  // 0x90
  public            UnityEngine.Vector4             cornerRadiuses  // 0xA0
  public            System.Boolean                  smoothCorners  // 0xB0
  public            System.Int32                    pass  // 0xB4
  public            UnityEngine.Texture             texture  // 0xB8
  public            UnityEngine.Material            mat  // 0xC0
METHODS:
END_CLASS

CLASS: UnityEngine.QualitySettings
TYPE:  class
TOKEN: 0x20000D1
FIELDS:
METHODS:
  System.Void IncreaseLevel(System.Boolean applyExpensiveChanges)
  System.Void DecreaseLevel(System.Boolean applyExpensiveChanges)
  System.Void SetQualityLevel(System.Int32 index)
  System.Void IncreaseLevel()
  System.Void DecreaseLevel()
  UnityEngine.QualityLevel get_currentLevel()
  System.Void set_currentLevel(UnityEngine.QualityLevel value)
  System.Void .ctor()
  System.Int32 get_pixelLightCount()
  System.Void set_pixelLightCount(System.Int32 value)
  UnityEngine.ShadowQuality get_shadows()
  System.Void set_shadows(UnityEngine.ShadowQuality value)
  UnityEngine.ShadowProjection get_shadowProjection()
  System.Void set_shadowProjection(UnityEngine.ShadowProjection value)
  System.Int32 get_shadowCascades()
  System.Void set_shadowCascades(System.Int32 value)
  System.Single get_shadowDistance()
  System.Void set_shadowDistance(System.Single value)
  UnityEngine.ShadowResolution get_shadowResolution()
  System.Void set_shadowResolution(UnityEngine.ShadowResolution value)
  UnityEngine.ShadowmaskMode get_shadowmaskMode()
  System.Void set_shadowmaskMode(UnityEngine.ShadowmaskMode value)
  System.Single get_shadowNearPlaneOffset()
  System.Void set_shadowNearPlaneOffset(System.Single value)
  System.Single get_shadowCascade2Split()
  System.Void set_shadowCascade2Split(System.Single value)
  UnityEngine.Vector3 get_shadowCascade4Split()
  System.Void set_shadowCascade4Split(UnityEngine.Vector3 value)
  System.Single get_lodBias()
  System.Void set_lodBias(System.Single value)
  System.Int32 get_lodOffset()
  System.Void set_lodOffset(System.Int32 value)
  UnityEngine.AnisotropicFiltering get_anisotropicFiltering()
  System.Void set_anisotropicFiltering(UnityEngine.AnisotropicFiltering value)
  System.Int32 get_masterTextureLimit()
  System.Void set_masterTextureLimit(System.Int32 value)
  System.Int32 get_maximumLODLevel()
  System.Void set_maximumLODLevel(System.Int32 value)
  System.Int32 get_particleRaycastBudget()
  System.Void set_particleRaycastBudget(System.Int32 value)
  System.Boolean get_softParticles()
  System.Void set_softParticles(System.Boolean value)
  System.Boolean get_softVegetation()
  System.Void set_softVegetation(System.Boolean value)
  System.Int32 get_vSyncCount()
  System.Void set_vSyncCount(System.Int32 value)
  System.Boolean get_allowTearing()
  System.Void set_allowTearing(System.Boolean value)
  System.Int32 get_realtimeGICPUUsage()
  System.Void set_realtimeGICPUUsage(System.Int32 value)
  System.Int32 get_antiAliasing()
  System.Void set_antiAliasing(System.Int32 value)
  System.Int32 get_asyncUploadTimeSlice()
  System.Void set_asyncUploadTimeSlice(System.Int32 value)
  System.Int32 get_asyncUploadBufferSize()
  System.Void set_asyncUploadBufferSize(System.Int32 value)
  System.Boolean get_asyncUploadPersistentBuffer()
  System.Void set_asyncUploadPersistentBuffer(System.Boolean value)
  System.Void SetLODSettings(System.Single lodBias, System.Int32 maximumLODLevel, System.Boolean setDirty)
  System.Void SetLODSettings(System.Single lodBias, System.Int32 lodOffset, System.Int32 maximumLODLevel, System.Boolean setDirty)
  System.Boolean get_realtimeReflectionProbes()
  System.Void set_realtimeReflectionProbes(System.Boolean value)
  System.Boolean get_billboardsFaceCameraPosition()
  System.Void set_billboardsFaceCameraPosition(System.Boolean value)
  System.Single get_resolutionScalingFixedDPIFactor()
  System.Void set_resolutionScalingFixedDPIFactor(System.Single value)
  UnityEngine.ScriptableObject get_INTERNAL_renderPipeline()
  System.Void set_INTERNAL_renderPipeline(UnityEngine.ScriptableObject value)
  UnityEngine.Rendering.RenderPipelineAsset get_renderPipeline()
  System.Void set_renderPipeline(UnityEngine.Rendering.RenderPipelineAsset value)
  UnityEngine.ScriptableObject InternalGetRenderPipelineAssetAt(System.Int32 index)
  UnityEngine.Rendering.RenderPipelineAsset GetRenderPipelineAssetAt(System.Int32 index)
  UnityEngine.BlendWeights get_blendWeights()
  System.Void set_blendWeights(UnityEngine.BlendWeights value)
  UnityEngine.SkinWeights get_skinWeights()
  System.Void set_skinWeights(UnityEngine.SkinWeights value)
  System.Boolean get_streamingMipmapsActive()
  System.Void set_streamingMipmapsActive(System.Boolean value)
  System.Single get_streamingMipmapsMemoryBudget()
  System.Void set_streamingMipmapsMemoryBudget(System.Single value)
  System.Int32 get_streamingMipmapsRenderersPerFrame()
  System.Void set_streamingMipmapsRenderersPerFrame(System.Int32 value)
  System.Int32 get_streamingMipmapsMaxLevelReduction()
  System.Void set_streamingMipmapsMaxLevelReduction(System.Int32 value)
  System.Boolean get_streamingMipmapsAddAllCameras()
  System.Void set_streamingMipmapsAddAllCameras(System.Boolean value)
  System.Int32 get_streamingMipmapsMaxFileIORequests()
  System.Void set_streamingMipmapsMaxFileIORequests(System.Int32 value)
  System.Int32 get_maxQueuedFrames()
  System.Void set_maxQueuedFrames(System.Int32 value)
  System.Int32 GetQualityLevel()
  UnityEngine.Object GetQualitySettings()
  System.Void SetQualityLevel(System.Int32 index, System.Boolean applyExpensiveChanges)
  System.String[] get_names()
  UnityEngine.ColorSpace get_desiredColorSpace()
  UnityEngine.ColorSpace get_activeColorSpace()
  System.Void get_shadowCascade4Split_Injected(UnityEngine.Vector3& ret)
  System.Void set_shadowCascade4Split_Injected(UnityEngine.Vector3& value)
END_CLASS

CLASS: UnityEngine.TrailRenderer
TYPE:  class
TOKEN: 0x20000D2
EXTENDS: Renderer
FIELDS:
METHODS:
  System.Single get_time()
  System.Void set_time(System.Single value)
  System.Single get_startWidth()
  System.Void set_startWidth(System.Single value)
  System.Single get_endWidth()
  System.Void set_endWidth(System.Single value)
END_CLASS

CLASS: UnityEngine.LineRenderer
TYPE:  class
TOKEN: 0x20000D3
EXTENDS: Renderer
FIELDS:
METHODS:
  System.Void SetWidth(System.Single start, System.Single end)
  System.Void SetColors(UnityEngine.Color start, UnityEngine.Color end)
  System.Void SetVertexCount(System.Int32 count)
  System.Int32 get_numPositions()
  System.Void set_numPositions(System.Int32 value)
  System.Single get_startWidth()
  System.Void set_startWidth(System.Single value)
  System.Single get_endWidth()
  System.Void set_endWidth(System.Single value)
  System.Single get_widthMultiplier()
  System.Void set_widthMultiplier(System.Single value)
  System.Int32 get_numCornerVertices()
  System.Void set_numCornerVertices(System.Int32 value)
  System.Int32 get_numCapVertices()
  System.Void set_numCapVertices(System.Int32 value)
  System.Boolean get_useWorldSpace()
  System.Void set_useWorldSpace(System.Boolean value)
  System.Boolean get_loop()
  System.Void set_loop(System.Boolean value)
  UnityEngine.Color get_startColor()
  System.Void set_startColor(UnityEngine.Color value)
  UnityEngine.Color get_endColor()
  System.Void set_endColor(UnityEngine.Color value)
  System.Int32 get_positionCount()
  System.Void set_positionCount(System.Int32 value)
  System.Void SetPosition(System.Int32 index, UnityEngine.Vector3 position)
  UnityEngine.Vector3 GetPosition(System.Int32 index)
  System.Single get_shadowBias()
  System.Void set_shadowBias(System.Single value)
  System.Boolean get_generateLightingData()
  System.Void set_generateLightingData(System.Boolean value)
  UnityEngine.LineTextureMode get_textureMode()
  System.Void set_textureMode(UnityEngine.LineTextureMode value)
  UnityEngine.LineAlignment get_alignment()
  System.Void set_alignment(UnityEngine.LineAlignment value)
  System.Void Simplify(System.Single tolerance)
  System.Void BakeMesh(UnityEngine.Mesh mesh, System.Boolean useTransform)
  System.Void BakeMesh(UnityEngine.Mesh mesh, UnityEngine.Camera camera, System.Boolean useTransform)
  UnityEngine.AnimationCurve get_widthCurve()
  System.Void set_widthCurve(UnityEngine.AnimationCurve value)
  UnityEngine.Gradient get_colorGradient()
  System.Void set_colorGradient(UnityEngine.Gradient value)
  UnityEngine.AnimationCurve GetWidthCurveCopy()
  System.Void SetWidthCurve(UnityEngine.AnimationCurve curve)
  UnityEngine.Gradient GetColorGradientCopy()
  System.Void SetColorGradient(UnityEngine.Gradient curve)
  System.Int32 GetPositions(UnityEngine.Vector3[] positions)
  System.Void SetPositions(UnityEngine.Vector3[] positions)
  System.Void SetPositions(Unity.Collections.NativeArray<UnityEngine.Vector3> positions)
  System.Void SetPositions(Unity.Collections.NativeSlice<UnityEngine.Vector3> positions)
  System.Int32 GetPositions(Unity.Collections.NativeArray<UnityEngine.Vector3> positions)
  System.Int32 GetPositions(Unity.Collections.NativeSlice<UnityEngine.Vector3> positions)
  System.Void SetPositionsWithNativeContainer(System.IntPtr positions, System.Int32 count)
  System.Int32 GetPositionsWithNativeContainer(System.IntPtr positions, System.Int32 length)
  System.Void .ctor()
  System.Void get_startColor_Injected(UnityEngine.Color& ret)
  System.Void set_startColor_Injected(UnityEngine.Color& value)
  System.Void get_endColor_Injected(UnityEngine.Color& ret)
  System.Void set_endColor_Injected(UnityEngine.Color& value)
  System.Void SetPosition_Injected(System.Int32 index, UnityEngine.Vector3& position)
  System.Void GetPosition_Injected(System.Int32 index, UnityEngine.Vector3& ret)
END_CLASS

CLASS: UnityEngine.MaterialPropertyBlock
TYPE:  class
TOKEN: 0x20000D4
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
METHODS:
  UnityEngine.Vector4 GetVectorImpl(System.Int32 name)
  System.Void SetFloatImpl(System.Int32 name, System.Single value)
  System.Void SetVectorImpl(System.Int32 name, UnityEngine.Vector4 value)
  System.Void SetColorImpl(System.Int32 name, UnityEngine.Color value)
  System.Void SetMatrixImpl(System.Int32 name, UnityEngine.Matrix4x4 value)
  System.Void SetTextureImpl(System.Int32 name, UnityEngine.Texture value)
  System.Void HGSetTextureImpl(System.Int32 name, UnityEngine.Texture value)
  System.Void SetBufferImpl(System.Int32 name, UnityEngine.ComputeBuffer value, System.Int32 offset, System.Int32 size)
  System.Void SetConstantBufferImpl(System.Int32 name, UnityEngine.ComputeBuffer value, System.Int32 offset, System.Int32 size)
  System.Void SetConstantBufferImpl0(System.Int32 name, System.UInt32 bufferId, System.Int32 offset, System.Int32 size)
  System.Void SetFloatArrayImpl(System.Int32 name, System.Single[] values, System.Int32 count)
  System.Void SetVectorArrayImpl(System.Int32 name, UnityEngine.Vector4[] values, System.Int32 count)
  System.Void SetNativeArrayImpl(System.Int32 name, System.Int32 type, System.UIntPtr values, System.Int32 count)
  System.IntPtr CreateImpl()
  System.Void DestroyImpl(System.IntPtr mpb)
  System.Void Clear(System.Boolean keepMemory)
  System.Void Clear()
  System.Void CopyFrom(UnityEngine.MaterialPropertyBlock properties)
  System.Void SetFloatArray(System.Int32 name, System.Single[] values, System.Int32 count)
  System.Void SetVectorArray(System.Int32 name, UnityEngine.Vector4[] values, System.Int32 count)
  System.Void SetFloatArray(System.Int32 name, Unity.Collections.NativeArray<System.Single> values, System.Int32 count)
  System.Void SetVectorArray(System.Int32 name, Unity.Collections.NativeArray<UnityEngine.Vector4> values, System.Int32 count)
  System.Void .ctor()
  System.Void Finalize()
  System.IntPtr GetNativePtr()
  System.Void Dispose()
  System.Void SetInt(System.String name, System.Int32 value)
  System.Void SetInt(System.Int32 nameID, System.Int32 value)
  System.Void SetFloat(System.String name, System.Single value)
  System.Void SetFloat(System.Int32 nameID, System.Single value)
  System.Void SetVector(System.String name, UnityEngine.Vector4 value)
  System.Void SetVector(System.Int32 nameID, UnityEngine.Vector4 value)
  System.Void SetColor(System.String name, UnityEngine.Color value)
  System.Void SetColor(System.Int32 nameID, UnityEngine.Color value)
  System.Void SetMatrix(System.Int32 nameID, UnityEngine.Matrix4x4 value)
  System.Void SetBuffer(System.String name, UnityEngine.ComputeBuffer value, System.Int32 offset, System.Int32 size)
  System.Void SetBuffer(System.Int32 nameID, UnityEngine.ComputeBuffer value, System.Int32 offset, System.Int32 size)
  System.Void SetTexture(System.String name, UnityEngine.Texture value)
  System.Void SetTexture(System.Int32 nameID, UnityEngine.Texture value)
  System.Void HGSetTexture(System.String name, UnityEngine.Texture value)
  System.Void HGSetTexture(System.Int32 nameID, UnityEngine.Texture value)
  System.Void SetConstantBuffer(System.Int32 nameID, UnityEngine.ComputeBuffer value, System.Int32 offset, System.Int32 size)
  System.Void SetConstantBuffer(System.String name, System.UInt32 bufferId, System.Int32 offset, System.Int32 size)
  System.Void SetConstantBuffer(System.Int32 nameID, System.UInt32 bufferId, System.Int32 offset, System.Int32 size)
  System.Void SetFloatArray(System.String name, System.Single[] values)
  System.Void SetFloatArray(System.Int32 nameID, Unity.Collections.NativeArray<System.Single> values)
  System.Void SetVectorArray(System.String name, UnityEngine.Vector4[] values)
  System.Void SetVectorArray(System.Int32 nameID, UnityEngine.Vector4[] values)
  System.Void SetVectorArray(System.Int32 nameID, Unity.Collections.NativeArray<UnityEngine.Vector4> values)
  UnityEngine.Vector4 GetVector(System.Int32 nameID)
  System.Void GetVectorImpl_Injected(System.Int32 name, UnityEngine.Vector4& ret)
  System.Void SetVectorImpl_Injected(System.Int32 name, UnityEngine.Vector4& value)
  System.Void SetColorImpl_Injected(System.Int32 name, UnityEngine.Color& value)
  System.Void SetMatrixImpl_Injected(System.Int32 name, UnityEngine.Matrix4x4& value)
END_CLASS

CLASS: UnityEngine.Renderer
TYPE:  class
TOKEN: 0x20000D5
EXTENDS: Component
FIELDS:
METHODS:
  System.Boolean get_castShadows()
  System.Void set_castShadows(System.Boolean value)
  System.Boolean get_motionVectors()
  System.Void set_motionVectors(System.Boolean value)
  System.Boolean get_useLightProbes()
  System.Void set_useLightProbes(System.Boolean value)
  UnityEngine.Bounds get_bounds()
  System.Void set_bounds(UnityEngine.Bounds value)
  UnityEngine.Bounds get_localBounds()
  System.Void set_localBounds(UnityEngine.Bounds value)
  System.Void ResetBounds()
  System.Void ResetLocalBounds()
  System.Void SetStaticLightmapST(UnityEngine.Vector4 st)
  UnityEngine.Material GetInstantiatedMaterial()
  UnityEngine.Material[] GetInstantiatedMaterialArray()
  UnityEngine.Material GetAndAssignInstantiatedMaterial()
  UnityEngine.Material GetSharedMaterial()
  System.Void SetMaterial(UnityEngine.Material m)
  UnityEngine.Material[] GetMaterialArray()
  System.Void CopyAndAssignInstantiatedMaterialArray(UnityEngine.Material[] m)
  System.Void CopyInstantiatedMaterialArray(UnityEngine.Material[] m)
  System.Void CopySharedMaterialArray(UnityEngine.Material[] m)
  System.Void SetMaterialArray(UnityEngine.Material[] m)
  System.Void Internal_SetPropertyBlock(UnityEngine.MaterialPropertyBlock properties)
  System.Void Internal_GetPropertyBlock(UnityEngine.MaterialPropertyBlock dest)
  System.Void Internal_SetPropertyBlockMaterialIndex(UnityEngine.MaterialPropertyBlock properties, System.Int32 materialIndex)
  System.Void Internal_GetPropertyBlockMaterialIndex(UnityEngine.MaterialPropertyBlock dest, System.Int32 materialIndex)
  System.Boolean HasPropertyBlock()
  System.Void SetPropertyBlock(UnityEngine.MaterialPropertyBlock properties)
  System.Void SetPropertyBlock(UnityEngine.MaterialPropertyBlock properties, System.Int32 materialIndex)
  System.Void GetPropertyBlock(UnityEngine.MaterialPropertyBlock properties)
  System.Void GetPropertyBlock(UnityEngine.MaterialPropertyBlock properties, System.Int32 materialIndex)
  System.Void GetClosestReflectionProbesInternal(System.Object result)
  System.Void GetClosestReflectionProbesInternal2(UnityEngine.Bounds& aabb, UnityEngine.Transform anchor, UnityEngine.Rendering.ReflectionProbeUsage usage, System.Object result)
  UnityEngine.ReflectionProbe GetReflectionProbeBySerializedIdentifier(System.Int64 identifier)
  System.Void GetAllReflectionProbesInternal(System.Object result)
  System.Void GetAllProbeTextureIndicesInternal(System.Int32[] result)
  UnityEngine.Texture GetReflectionProbeArrayInternal()
  System.Void set_lightingAnchor(UnityEngine.Transform value)
  UnityEngine.Transform get_lightingAnchor()
  System.Boolean get_enablePerRendererLighting()
  System.Void set_enablePerRendererLighting(System.Boolean value)
  System.Boolean get_enabled()
  System.Void set_enabled(System.Boolean value)
  System.Boolean get_isVisible()
  UnityEngine.Rendering.ShadowCastingMode get_shadowCastingMode()
  System.Void set_shadowCastingMode(UnityEngine.Rendering.ShadowCastingMode value)
  System.Boolean get_receiveShadows()
  System.Void set_receiveShadows(System.Boolean value)
  System.Boolean get_forceRenderingOff()
  System.Void set_forceRenderingOff(System.Boolean value)
  System.Boolean GetIsStaticShadowCaster()
  System.Void SetIsStaticShadowCaster(System.Boolean value)
  System.Boolean get_staticShadowCaster()
  System.Void set_staticShadowCaster(System.Boolean value)
  System.Boolean GetIsRealtimeShadowCaster()
  System.Void SetIsRealtimeShadowCaster(System.Boolean value)
  System.Boolean get_realtimeShadowCaster()
  System.Void set_realtimeShadowCaster(System.Boolean value)
  System.Boolean GetRenderFoliageOccluder()
  System.Void SetRenderFoliageOccluder(System.Boolean value)
  System.Boolean get_renderFoliageOccluder()
  System.Void set_renderFoliageOccluder(System.Boolean value)
  System.UInt16 get_characterIndex()
  System.Void set_characterIndex(System.UInt16 value)
  UnityEngine.Rendering.SubMeshRenderMode get_subMeshRenderMode()
  System.Void set_subMeshRenderMode(UnityEngine.Rendering.SubMeshRenderMode value)
  UnityEngine.Mesh get_shadowProxyMesh()
  System.Void set_shadowProxyMesh(UnityEngine.Mesh value)
  UnityEngine.MotionVectorGenerationMode get_motionVectorGenerationMode()
  System.Void set_motionVectorGenerationMode(UnityEngine.MotionVectorGenerationMode value)
  UnityEngine.Rendering.LightProbeUsage get_lightProbeUsage()
  System.Void set_lightProbeUsage(UnityEngine.Rendering.LightProbeUsage value)
  UnityEngine.Rendering.ReflectionProbeUsage get_reflectionProbeUsage()
  System.Void set_reflectionProbeUsage(UnityEngine.Rendering.ReflectionProbeUsage value)
  System.UInt32 get_renderingLayerMask()
  System.Void set_renderingLayerMask(System.UInt32 value)
  System.Int32 get_rendererPriority()
  System.Void set_rendererPriority(System.Int32 value)
  UnityEngine.Experimental.Rendering.RayTracingMode get_rayTracingMode()
  System.Void set_rayTracingMode(UnityEngine.Experimental.Rendering.RayTracingMode value)
  System.String get_sortingLayerName()
  System.Void set_sortingLayerName(System.String value)
  System.Int32 get_sortingLayerID()
  System.Void set_sortingLayerID(System.Int32 value)
  System.Int32 get_sortingOrder()
  System.Void set_sortingOrder(System.Int32 value)
  System.Int32 get_sortingGroupID()
  System.Void set_sortingGroupID(System.Int32 value)
  System.Int32 get_sortingGroupOrder()
  System.Void set_sortingGroupOrder(System.Int32 value)
  System.Single get_sortingFudge()
  System.Void set_sortingFudge(System.Single value)
  System.Boolean get_useCustomLODFadeValue()
  System.Void set_useCustomLODFadeValue(System.Boolean value)
  System.Single get_customLODFadeValue()
  System.Void set_customLODFadeValue(System.Single value)
  System.Boolean get_allowOcclusionWhenDynamic()
  System.Void set_allowOcclusionWhenDynamic(System.Boolean value)
  UnityEngine.Transform get_staticBatchRootTransform()
  System.Void set_staticBatchRootTransform(UnityEngine.Transform value)
  System.Int32 get_staticBatchIndex()
  System.Void SetStaticBatchInfo(System.Int32 firstSubMesh, System.Int32 subMeshCount)
  System.Boolean get_isPartOfStaticBatch()
  UnityEngine.Matrix4x4 get_worldToLocalMatrix()
  UnityEngine.Matrix4x4 get_localToWorldMatrix()
  UnityEngine.GameObject get_lightProbeProxyVolumeOverride()
  System.Void set_lightProbeProxyVolumeOverride(UnityEngine.GameObject value)
  UnityEngine.Transform get_probeAnchor()
  System.Void set_probeAnchor(UnityEngine.Transform value)
  UnityEngine.LODGroup get_LODGroup()
  System.Int32 GetLightmapIndex(UnityEngineInternal.LightmapType lt)
  System.Void SetLightmapIndex(System.Int32 index, UnityEngineInternal.LightmapType lt)
  UnityEngine.Vector4 GetLightmapST(UnityEngineInternal.LightmapType lt)
  System.Void SetLightmapST(UnityEngine.Vector4 st, UnityEngineInternal.LightmapType lt)
  System.Int32 get_lightmapIndex()
  System.Void set_lightmapIndex(System.Int32 value)
  System.Int32 get_realtimeLightmapIndex()
  System.Void set_realtimeLightmapIndex(System.Int32 value)
  UnityEngine.Vector4 get_lightmapScaleOffset()
  System.Void set_lightmapScaleOffset(UnityEngine.Vector4 value)
  UnityEngine.Vector4 get_realtimeLightmapScaleOffset()
  System.Void set_realtimeLightmapScaleOffset(UnityEngine.Vector4 value)
  System.Int32 GetMaterialCount()
  UnityEngine.Material[] GetSharedMaterialArray()
  UnityEngine.Material[] get_materials()
  System.Void set_materials(UnityEngine.Material[] value)
  UnityEngine.Material get_material()
  System.Void set_material(UnityEngine.Material value)
  UnityEngine.Material get_sharedMaterial()
  System.Void set_sharedMaterial(UnityEngine.Material value)
  UnityEngine.Material[] get_sharedMaterials()
  System.Void set_sharedMaterials(UnityEngine.Material[] value)
  System.Void GetMaterials(System.Collections.Generic.List<UnityEngine.Material> m)
  System.Void GetInstantiatedMaterials(System.Collections.Generic.List<UnityEngine.Material> m)
  System.Void GetSharedMaterials(System.Collections.Generic.List<UnityEngine.Material> m)
  System.Void GetClosestReflectionProbes(System.Collections.Generic.List<UnityEngine.Rendering.ReflectionProbeBlendInfo> result)
  System.Void GetClosestReflectionProbes(UnityEngine.Bounds& aabb, UnityEngine.Transform anchor, UnityEngine.Rendering.ReflectionProbeUsage usage, System.Collections.Generic.List<UnityEngine.Rendering.ReflectionProbeBlendInfo> result)
  System.Void GetAllReflectionProbes(System.Collections.Generic.List<UnityEngine.Rendering.ReflectionProbeBlendInfo> result)
  System.Void GetAllProbeTextureIndices(System.Int32[] result)
  UnityEngine.Texture GetReflectionProbeArray()
  System.Void SetCustomPerDrawData(System.Int32 index, UnityEngine.Vector4 param)
  UnityEngine.Vector4 GetCustomPerDrawData(System.Int32 index)
  UnityEngine.Vector4* GetCustomPerDrawDataPtr()
  System.Void set_enableManualDither(System.Boolean value)
  System.Void set_enableCameraDither(System.Boolean value)
  System.Void set_manualDitherAlphaValue(System.Single value)
  System.Void set_cameraDitherAlphaValue(System.Single value)
  System.Void set_enableCharacterOutline(System.Boolean value)
  System.Boolean get_enableCharacterOutline()
  UnityEngine.Vector3 get_perRendererLightingOffset()
  System.Void set_perRendererLightingOffset(UnityEngine.Vector3 value)
  System.Void SetPlatformSpecificCastShadowsInternal(System.IntPtr value)
  System.IntPtr GetPlatformSpecificCastShadowsInternal()
  System.Void SetPlatformSpecificCastShadows(UnityEngine.PlatformSpecificParam<System.UInt32> value)
  UnityEngine.PlatformSpecificParam<System.UInt32> GetPlatformSpecificCastShadows()
  System.Void .ctor()
  System.Void get_bounds_Injected(UnityEngine.Bounds& ret)
  System.Void set_bounds_Injected(UnityEngine.Bounds& value)
  System.Void get_localBounds_Injected(UnityEngine.Bounds& ret)
  System.Void set_localBounds_Injected(UnityEngine.Bounds& value)
  System.Void SetStaticLightmapST_Injected(UnityEngine.Vector4& st)
  System.Void get_worldToLocalMatrix_Injected(UnityEngine.Matrix4x4& ret)
  System.Void get_localToWorldMatrix_Injected(UnityEngine.Matrix4x4& ret)
  System.Void GetLightmapST_Injected(UnityEngineInternal.LightmapType lt, UnityEngine.Vector4& ret)
  System.Void SetLightmapST_Injected(UnityEngine.Vector4& st, UnityEngineInternal.LightmapType lt)
  System.Void SetCustomPerDrawData_Injected(System.Int32 index, UnityEngine.Vector4& param)
  System.Void GetCustomPerDrawData_Injected(System.Int32 index, UnityEngine.Vector4& ret)
  System.Void get_perRendererLightingOffset_Injected(UnityEngine.Vector3& ret)
  System.Void set_perRendererLightingOffset_Injected(UnityEngine.Vector3& value)
END_CLASS

CLASS: UnityEngine.RenderSettings
TYPE:  class
TOKEN: 0x20000D6
FIELDS:
METHODS:
  System.Single get_fogStartDistance()
  System.Void set_fogStartDistance(System.Single value)
  System.Single get_fogEndDistance()
  System.Void set_fogEndDistance(System.Single value)
  UnityEngine.Color get_fogColor()
  System.Void set_fogColor(UnityEngine.Color value)
  System.Single get_fogDensity()
  System.Void set_fogDensity(System.Single value)
  System.Void set_ambientMode(UnityEngine.Rendering.AmbientMode value)
  System.Single get_ambientIntensity()
  System.Void set_ambientIntensity(System.Single value)
  UnityEngine.Color get_ambientLight()
  System.Void set_ambientLight(UnityEngine.Color value)
  System.Void set_skybox(UnityEngine.Material value)
  System.Void set_sun(UnityEngine.Light value)
  UnityEngine.Rendering.SphericalHarmonicsL2 get_ambientProbe()
  System.Void set_ambientProbe(UnityEngine.Rendering.SphericalHarmonicsL2 value)
  System.Void set_defaultReflectionMode(UnityEngine.Rendering.DefaultReflectionMode value)
  System.Void get_fogColor_Injected(UnityEngine.Color& ret)
  System.Void set_fogColor_Injected(UnityEngine.Color& value)
  System.Void get_ambientLight_Injected(UnityEngine.Color& ret)
  System.Void set_ambientLight_Injected(UnityEngine.Color& value)
  System.Void get_ambientProbe_Injected(UnityEngine.Rendering.SphericalHarmonicsL2& ret)
  System.Void set_ambientProbe_Injected(UnityEngine.Rendering.SphericalHarmonicsL2& value)
END_CLASS

CLASS: UnityEngine.Shader
TYPE:  class
TOKEN: 0x20000D7
FIELDS:
  private   static  System.Action<System.String>    onCompileShader  // 0x0
  private   static  System.Action<System.String,System.String,System.String,System.String>onKeywordNotBestMatch  // 0x8
  private   static  System.Action<System.String,System.Single,System.Int32,System.Boolean>onRenderPipelineUpload  // 0x10
METHODS:
  UnityEngine.Shader Find(System.String name)
  System.Int32 get_globalMaximumLOD()
  System.Void set_globalMaximumLOD(System.Int32 value)
  System.Boolean get_isSupported()
  System.Void set_globalRenderPipeline(System.String value)
  UnityEngine.Rendering.LocalKeywordSpace get_keywordSpace()
  System.Void EnableKeyword(System.String keyword)
  System.Void DisableKeyword(System.String keyword)
  System.Int32 TagToID(System.String name)
  System.Int32 PropertyToID(System.String name)
  System.Void SetGlobalFloatImpl(System.Int32 name, System.Single value)
  System.Void SetGlobalMatrixImpl(System.Int32 name, UnityEngine.Matrix4x4 value)
  System.Void SetGlobalTextureImpl(System.Int32 name, UnityEngine.Texture value)
  System.Void SetGlobalConstantBufferImpl(System.Int32 name, UnityEngine.ComputeBuffer value, System.Int32 offset, System.Int32 size)
  System.Void set_forceSubShaderReload(System.Boolean value)
  System.Void InvokeOnCompileShader(System.String url)
  System.Void InvokeOnKeywordNotBestMatch(System.String shaderName, System.String passInfo, System.String requestKeyword, System.String foundKeyword)
  System.Void InvokeOnRenderPipelineUpload(System.String infoJson, System.Single time, System.Int32 codeSize, System.Boolean isMissing)
  System.Void SetGlobalInt(System.Int32 nameID, System.Int32 value)
  System.Void SetGlobalFloat(System.Int32 nameID, System.Single value)
  System.Void SetGlobalMatrix(System.String name, UnityEngine.Matrix4x4 value)
  System.Void SetGlobalTexture(System.Int32 nameID, UnityEngine.Texture value)
  System.Void SetGlobalConstantBuffer(System.Int32 nameID, UnityEngine.ComputeBuffer value, System.Int32 offset, System.Int32 size)
  System.Void .ctor()
  System.Void get_keywordSpace_Injected(UnityEngine.Rendering.LocalKeywordSpace& ret)
  System.Void SetGlobalMatrixImpl_Injected(System.Int32 name, UnityEngine.Matrix4x4& value)
END_CLASS

CLASS: UnityEngine.Material
TYPE:  class
TOKEN: 0x20000D8
FIELDS:
METHODS:
  System.IntPtr HGGetPtrUnchecked()
  System.Void CreateWithShader(UnityEngine.Material self, UnityEngine.Shader shader)
  System.Void CreateWithMaterial(UnityEngine.Material self, UnityEngine.Material source)
  System.Void CreateWithString(UnityEngine.Material self)
  System.Void .ctor(UnityEngine.Shader shader)
  System.Void .ctor(UnityEngine.Material source)
  System.Void .ctor(System.String contents)
  UnityEngine.Shader get_shader()
  System.Void set_shader(UnityEngine.Shader value)
  UnityEngine.Color get_color()
  System.Void set_color(UnityEngine.Color value)
  UnityEngine.Texture get_mainTexture()
  System.Void set_mainTexture(UnityEngine.Texture value)
  UnityEngine.Vector2 get_mainTextureOffset()
  System.Void set_mainTextureOffset(UnityEngine.Vector2 value)
  UnityEngine.Vector2 get_mainTextureScale()
  System.Void set_mainTextureScale(UnityEngine.Vector2 value)
  System.Int32 GetFirstPropertyNameIdByAttribute(UnityEngine.Rendering.ShaderPropertyFlags attributeFlag)
  System.Boolean HasProperty(System.Int32 nameID)
  System.Boolean HasProperty(System.String name)
  System.Boolean HasFloatImpl(System.Int32 name)
  System.Boolean HasFloat(System.String name)
  System.Boolean HasFloat(System.Int32 nameID)
  System.Boolean HasInt(System.String name)
  System.Boolean HasVectorImpl(System.Int32 name)
  System.Boolean HasColor(System.String name)
  System.Int32 get_renderQueue()
  System.Void set_renderQueue(System.Int32 value)
  System.Void EnableKeyword(System.String keyword)
  System.Void DisableKeyword(System.String keyword)
  System.Boolean IsKeywordEnabled(System.String keyword)
  System.Void EnableLocalKeyword(UnityEngine.Rendering.LocalKeyword keyword)
  System.Void DisableLocalKeyword(UnityEngine.Rendering.LocalKeyword keyword)
  System.Void SetLocalKeyword(UnityEngine.Rendering.LocalKeyword keyword, System.Boolean value)
  System.Void EnableKeyword(UnityEngine.Rendering.LocalKeyword& keyword)
  System.Void DisableKeyword(UnityEngine.Rendering.LocalKeyword& keyword)
  System.Void SetKeyword(UnityEngine.Rendering.LocalKeyword& keyword, System.Boolean value)
  System.Void SetEnabledKeywords(UnityEngine.Rendering.LocalKeyword[] keywords)
  System.Void set_enabledKeywords(UnityEngine.Rendering.LocalKeyword[] value)
  System.Void set_globalIlluminationFlags(UnityEngine.MaterialGlobalIlluminationFlags value)
  System.Boolean get_enableInstancing()
  System.Void set_enableInstancing(System.Boolean value)
  System.Int32 get_passCount()
  System.Void SetShaderPassEnabled(System.String passName, System.Boolean enabled)
  System.Boolean GetShaderPassEnabledAndExisted(System.String passName)
  System.Int32 FindPass(System.String passName)
  System.Void SetOverrideTag(System.String tag, System.String val)
  System.String GetTagImpl(System.String tag, System.Boolean currentSubShaderOnly, System.String defaultValue)
  System.String GetTag(System.String tag, System.Boolean searchFallbacks)
  System.Boolean SetPass(System.Int32 pass)
  System.Void CopyPropertiesFromMaterial(UnityEngine.Material mat)
  System.String[] GetShaderKeywords()
  System.Void SetShaderKeywords(System.String[] names)
  System.String[] get_shaderKeywords()
  System.Void set_shaderKeywords(System.String[] value)
  System.Int32 ComputeCRC()
  System.Void GetTexturePropertyNamesInternal(System.Object outNames)
  System.Void GetTexturePropertyNames(System.Collections.Generic.List<System.String> outNames)
  System.Void SetIntImpl(System.Int32 name, System.Int32 value)
  System.Void SetFloatImpl(System.Int32 name, System.Single value)
  System.Void SetColorImpl(System.Int32 name, UnityEngine.Color value)
  System.Void SetMatrixImpl(System.Int32 name, UnityEngine.Matrix4x4 value)
  System.Void SetTextureImpl(System.Int32 name, UnityEngine.Texture value)
  System.Void SetConstantBufferImpl(System.Int32 name, UnityEngine.ComputeBuffer value, System.Int32 offset, System.Int32 size)
  System.Void SetConstantBufferImpl0(System.Int32 name, System.UInt32 bufferId, System.Int32 offset, System.Int32 size)
  System.Int32 GetIntImpl(System.Int32 name)
  System.Single GetFloatImpl(System.Int32 name)
  UnityEngine.Color GetColorImpl(System.Int32 name)
  UnityEngine.Matrix4x4 GetMatrixImpl(System.Int32 name)
  UnityEngine.Texture GetTextureImpl(System.Int32 name)
  System.Void SetMatrixArrayImpl(System.Int32 name, UnityEngine.Matrix4x4[] values, System.Int32 count)
  UnityEngine.Vector4 GetTextureScaleAndOffsetImpl(System.Int32 name)
  System.Void SetTextureOffsetImpl(System.Int32 name, UnityEngine.Vector2 offset)
  System.Void SetTextureScaleImpl(System.Int32 name, UnityEngine.Vector2 scale)
  UnityEngine.HGSubsurfaceProfile get_subsurfaceProfile()
  System.Void SetMatrixArray(System.Int32 name, UnityEngine.Matrix4x4[] values, System.Int32 count)
  System.Void SetInt(System.String name, System.Int32 value)
  System.Void SetInt(System.Int32 nameID, System.Int32 value)
  System.Void SetFloat(System.String name, System.Single value)
  System.Void SetFloat(System.Int32 nameID, System.Single value)
  System.Void SetInteger(System.String name, System.Int32 value)
  System.Void SetColor(System.String name, UnityEngine.Color value)
  System.Void SetColor(System.Int32 nameID, UnityEngine.Color value)
  System.Void SetVector(System.String name, UnityEngine.Vector4 value)
  System.Void SetVector(System.Int32 nameID, UnityEngine.Vector4 value)
  System.Void SetMatrix(System.String name, UnityEngine.Matrix4x4 value)
  System.Void SetMatrix(System.Int32 nameID, UnityEngine.Matrix4x4 value)
  System.Void SetTexture(System.String name, UnityEngine.Texture value)
  System.Void SetTexture(System.Int32 nameID, UnityEngine.Texture value)
  System.Void SetConstantBuffer(System.Int32 nameID, UnityEngine.ComputeBuffer value, System.Int32 offset, System.Int32 size)
  System.Void SetConstantBuffer(System.Int32 nameID, System.UInt32 bufferId, System.Int32 offset, System.Int32 size)
  System.Void SetMatrixArray(System.String name, System.Collections.Generic.List<UnityEngine.Matrix4x4> values)
  System.Int32 GetInt(System.String name)
  System.Int32 GetInt(System.Int32 nameID)
  System.Single GetFloat(System.String name)
  System.Single GetFloat(System.Int32 nameID)
  System.Int32 GetInteger(System.String name)
  UnityEngine.Color GetColor(System.String name)
  UnityEngine.Color GetColor(System.Int32 nameID)
  UnityEngine.Vector4 GetVector(System.String name)
  UnityEngine.Vector4 GetVector(System.Int32 nameID)
  UnityEngine.Matrix4x4 GetMatrix(System.Int32 nameID)
  UnityEngine.Texture GetTexture(System.String name)
  UnityEngine.Texture GetTexture(System.Int32 nameID)
  System.Void SetTextureOffset(System.String name, UnityEngine.Vector2 value)
  System.Void SetTextureOffset(System.Int32 nameID, UnityEngine.Vector2 value)
  System.Void SetTextureScale(System.String name, UnityEngine.Vector2 value)
  System.Void SetTextureScale(System.Int32 nameID, UnityEngine.Vector2 value)
  UnityEngine.Vector2 GetTextureOffset(System.String name)
  UnityEngine.Vector2 GetTextureOffset(System.Int32 nameID)
  UnityEngine.Vector2 GetTextureScale(System.String name)
  UnityEngine.Vector2 GetTextureScale(System.Int32 nameID)
  System.Void EnableLocalKeyword_Injected(UnityEngine.Rendering.LocalKeyword& keyword)
  System.Void DisableLocalKeyword_Injected(UnityEngine.Rendering.LocalKeyword& keyword)
  System.Void SetLocalKeyword_Injected(UnityEngine.Rendering.LocalKeyword& keyword, System.Boolean value)
  System.Void SetColorImpl_Injected(System.Int32 name, UnityEngine.Color& value)
  System.Void SetMatrixImpl_Injected(System.Int32 name, UnityEngine.Matrix4x4& value)
  System.Void GetColorImpl_Injected(System.Int32 name, UnityEngine.Color& ret)
  System.Void GetMatrixImpl_Injected(System.Int32 name, UnityEngine.Matrix4x4& ret)
  System.Void GetTextureScaleAndOffsetImpl_Injected(System.Int32 name, UnityEngine.Vector4& ret)
  System.Void SetTextureOffsetImpl_Injected(System.Int32 name, UnityEngine.Vector2& offset)
  System.Void SetTextureScaleImpl_Injected(System.Int32 name, UnityEngine.Vector2& scale)
END_CLASS

CLASS: UnityEngine.GraphicsBuffer
TYPE:  class
TOKEN: 0x20000D9
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
METHODS:
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Boolean RequiresCompute(UnityEngine.GraphicsBuffer.Target target)
  System.Boolean IsVertexIndexOrCopyOnly(UnityEngine.GraphicsBuffer.Target target)
  System.IntPtr InitBuffer(UnityEngine.GraphicsBuffer.Target target, System.Int32 count, System.Int32 stride)
  System.Void DestroyBuffer(UnityEngine.GraphicsBuffer buf)
  System.Void .ctor(UnityEngine.GraphicsBuffer.Target target, System.Int32 count, System.Int32 stride)
  System.Void Release()
  System.Int32 get_count()
  System.Int32 get_stride()
  UnityEngine.GraphicsBuffer.Target get_target()
  System.Void SetData(System.Array data)
  System.Void SetData(Unity.Collections.NativeArray<T> data)
  System.Void InternalSetNativeData(System.IntPtr data, System.Int32 nativeBufferStartIndex, System.Int32 graphicsBufferStartIndex, System.Int32 count, System.Int32 elemSize)
  System.Void InternalSetData(System.Array data, System.Int32 managedBufferStartIndex, System.Int32 graphicsBufferStartIndex, System.Int32 count, System.Int32 elemSize)
END_CLASS

CLASS: UnityEngine.Flare
TYPE:  class
TOKEN: 0x20000DB
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void Internal_Create(UnityEngine.Flare self)
END_CLASS

CLASS: UnityEngine.LightBakingOutput
TYPE:  struct
TOKEN: 0x20000DC
FIELDS:
  public            System.Int32                    probeOcclusionLightIndex  // 0x10
  public            System.Int32                    occlusionMaskChannel  // 0x14
  public            UnityEngine.LightmapBakeType    lightmapBakeType  // 0x18
  public            UnityEngine.MixedLightingMode   mixedLightingMode  // 0x1C
  public            System.Boolean                  isBaked  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.LightShadowCasterMode
TYPE:  struct
TOKEN: 0x20000DD
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.LightShadowCasterModeDefault  // 0x0
  public    static  UnityEngine.LightShadowCasterModeNonLightmappedOnly  // 0x0
  public    static  UnityEngine.LightShadowCasterModeEverything  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Light
TYPE:  class
TOKEN: 0x20000DE
EXTENDS: Behaviour
FIELDS:
  private           System.Int32                    m_BakedIndex  // 0x18
METHODS:
  UnityEngine.LightType get_type()
  System.Void set_type(UnityEngine.LightType value)
  UnityEngine.LightShape get_shape()
  System.Void set_shape(UnityEngine.LightShape value)
  System.Single get_spotAngle()
  System.Void set_spotAngle(System.Single value)
  System.Single get_innerSpotAngle()
  System.Void set_innerSpotAngle(System.Single value)
  UnityEngine.Color get_color()
  System.Void set_color(UnityEngine.Color value)
  System.Single get_colorTemperature()
  System.Void set_colorTemperature(System.Single value)
  System.Boolean get_useColorTemperature()
  System.Void set_useColorTemperature(System.Boolean value)
  System.Boolean get_isSunSourceLight()
  System.Void set_isSunSourceLight(System.Boolean value)
  System.Boolean get_shadowOnly()
  System.Void set_shadowOnly(System.Boolean value)
  System.Boolean get_enableOBBCullingBox()
  System.Void set_enableOBBCullingBox(System.Boolean value)
  System.Boolean get_obbCullingBoxMode()
  System.Void set_obbCullingBoxMode(System.Boolean value)
  UnityEngine.Vector3 get_cullingBoxRelativePosition()
  System.Void set_cullingBoxRelativePosition(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_cullingBoxHalfExtents()
  System.Void set_cullingBoxHalfExtents(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_cullingBoxOrientation()
  System.Void set_cullingBoxOrientation(UnityEngine.Vector3 value)
  System.Single get_cullingBoxFalloffThreshold()
  System.Void set_cullingBoxFalloffThreshold(System.Single value)
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_intensity()
  System.Void set_intensity(System.Single value)
  System.Single get_specularIntensity()
  System.Void set_specularIntensity(System.Single value)
  System.Single get_softSourceRadius()
  System.Void set_softSourceRadius(System.Single value)
  System.Single get_bounceIntensity()
  System.Void set_bounceIntensity(System.Single value)
  System.Boolean get_useBoundingSphereOverride()
  System.Void set_useBoundingSphereOverride(System.Boolean value)
  UnityEngine.Vector4 get_boundingSphereOverride()
  System.Void set_boundingSphereOverride(UnityEngine.Vector4 value)
  System.Boolean get_useViewFrustumForShadowCasterCull()
  System.Void set_useViewFrustumForShadowCasterCull(System.Boolean value)
  System.Int32 get_shadowCustomResolution()
  System.Void set_shadowCustomResolution(System.Int32 value)
  System.Single get_shadowBias()
  System.Void set_shadowBias(System.Single value)
  System.Single get_shadowNormalBias()
  System.Void set_shadowNormalBias(System.Single value)
  System.Single get_shadowNearPlane()
  System.Void set_shadowNearPlane(System.Single value)
  System.Boolean get_useShadowMatrixOverride()
  System.Void set_useShadowMatrixOverride(System.Boolean value)
  UnityEngine.Matrix4x4 get_shadowMatrixOverride()
  System.Void set_shadowMatrixOverride(UnityEngine.Matrix4x4 value)
  System.Single get_shadowFarPlane()
  System.Void set_shadowFarPlane(System.Single value)
  System.Single get_shadowCullDistance()
  System.Void set_shadowCullDistance(System.Single value)
  System.Single get_shadowFadeRatio()
  System.Void set_shadowFadeRatio(System.Single value)
  System.Single get_shadowGuardAngle()
  System.Void set_shadowGuardAngle(System.Single value)
  System.Int32 get_pointLightShadowCasterFaces()
  System.Void set_pointLightShadowCasterFaces(System.Int32 value)
  System.Int32 get_shadowCasterProperties()
  System.Void set_shadowCasterProperties(System.Int32 value)
  System.Boolean get_isRuntimeShadowBaked()
  System.Void set_isRuntimeShadowBaked(System.Boolean value)
  System.Int32 get_lightPriority()
  System.Void set_lightPriority(System.Int32 value)
  System.Single get_range()
  System.Void set_range(System.Single value)
  UnityEngine.Flare get_flare()
  System.Void set_flare(UnityEngine.Flare value)
  UnityEngine.LightBakingOutput get_bakingOutput()
  System.Void set_bakingOutput(UnityEngine.LightBakingOutput value)
  System.Int32 get_cullingMask()
  System.Void set_cullingMask(System.Int32 value)
  System.Int32 get_renderingLayerMask()
  System.Void set_renderingLayerMask(System.Int32 value)
  UnityEngine.LightShadowCasterMode get_lightShadowCasterMode()
  System.Void set_lightShadowCasterMode(UnityEngine.LightShadowCasterMode value)
  System.Boolean get_useCullingDistance()
  System.Void set_useCullingDistance(System.Boolean value)
  System.Single get_cullingDistance()
  System.Void set_cullingDistance(System.Single value)
  System.Single get_falloffDistance()
  System.Void set_falloffDistance(System.Single value)
  System.UInt64 get_entityID()
  System.Boolean get_enableLightAnimation()
  System.Void set_enableLightAnimation(System.Boolean value)
  System.Boolean get_isInTransition()
  System.Int32 get_lightStateEntryIdx()
  System.Void set_lightStateEntryIdx(System.Int32 value)
  System.Void ResetLightAnimation()
  System.Void UpdateAdditionalMeshRendererBindData()
  System.Void SetLightCurState(System.UInt32 stateIdx)
  System.Void CopyLightToState(System.UInt32 stateIdx)
  System.Void AddLightStateTransitionPreset(UnityEngine.LightStateTransition preset)
  System.Void TransitionLightStateTo(System.String dstStateTagName, System.String transitionTagName)
  System.Void Reset()
  UnityEngine.LightShadows get_shadows()
  System.Void set_shadows(UnityEngine.LightShadows value)
  System.Single get_shadowStrength()
  System.Void set_shadowStrength(System.Single value)
  UnityEngine.Rendering.LightShadowResolution get_shadowResolution()
  System.Void set_shadowResolution(UnityEngine.Rendering.LightShadowResolution value)
  System.Single get_shadowSoftness()
  System.Void set_shadowSoftness(System.Single value)
  System.Single get_shadowSoftnessFade()
  System.Void set_shadowSoftnessFade(System.Single value)
  System.Single[] get_layerShadowCullDistances()
  System.Void set_layerShadowCullDistances(System.Single[] value)
  System.Single get_cookieSize()
  System.Void set_cookieSize(System.Single value)
  UnityEngine.Texture get_cookie()
  System.Void set_cookie(UnityEngine.Texture value)
  UnityEngine.LightRenderMode get_renderMode()
  System.Void set_renderMode(UnityEngine.LightRenderMode value)
  System.Int32 get_bakedIndex()
  System.Void set_bakedIndex(System.Int32 value)
  System.Void SetPlatformSpecificLightBakeTypeInternal(System.IntPtr value)
  System.IntPtr GetPlatformSpecificLightBakeTypeInternal()
  System.Void SetPlatformSpecificLightBakeType(UnityEngine.PlatformSpecificParam<UnityEngine.LightmapBakeType> value)
  UnityEngine.PlatformSpecificParam<UnityEngine.LightmapBakeType> GetPlatformSpecificLightBakeType()
  System.Void SetPlatformSpecificShadowTypeInternal(System.IntPtr value)
  System.IntPtr GetPlatformSpecificShadowTypeInternal()
  System.Void SetPlatformSpecificShadowType(UnityEngine.PlatformSpecificParam<System.Int32> value)
  UnityEngine.PlatformSpecificParam<System.Int32> GetPlatformSpecificShadowType()
  System.Void AddCommandBuffer(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer)
  System.Void AddCommandBuffer(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask)
  System.Void AddCommandBufferAsync(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType)
  System.Void AddCommandBufferAsync(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask, UnityEngine.Rendering.ComputeQueueType queueType)
  System.Void RemoveCommandBuffer(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer)
  System.Void RemoveCommandBuffers(UnityEngine.Rendering.LightEvent evt)
  System.Void RemoveAllCommandBuffers()
  UnityEngine.Rendering.CommandBuffer[] GetCommandBuffers(UnityEngine.Rendering.LightEvent evt)
  System.Int32 get_commandBufferCount()
  System.Int32 get_pixelLightCount()
  System.Void set_pixelLightCount(System.Int32 value)
  UnityEngine.Light[] GetLights(UnityEngine.LightType type, System.Int32 layer)
  UnityEngine.Light GetSunSourceLight()
  System.Void set_isDynamicShadowCaster(System.Boolean value)
  System.Boolean get_isDynamicShadowCaster()
  System.Void set_castStaticObjects(System.Boolean value)
  System.Boolean get_castStaticObjects()
  System.Void set_castDynamicObjects(System.Boolean value)
  System.Boolean get_castDynamicObjects()
  System.Void SetPointLightShadowCasterFace(UnityEngine.CubemapFace face, System.Boolean enabled)
  System.Boolean GetPointLightShadowCasterFace(UnityEngine.CubemapFace face)
  System.Boolean IsPointLightHasExactlyOneCaster()
  System.Single get_shadowConstantBias()
  System.Void set_shadowConstantBias(System.Single value)
  System.Single get_shadowObjectSizeBias()
  System.Void set_shadowObjectSizeBias(System.Single value)
  System.Boolean get_attenuate()
  System.Void set_attenuate(System.Boolean value)
  System.Void set_lightAdditionalData(UnityEngine.HGLightAdditionalData value)
  System.Void .ctor()
  System.Void get_color_Injected(UnityEngine.Color& ret)
  System.Void set_color_Injected(UnityEngine.Color& value)
  System.Void get_cullingBoxRelativePosition_Injected(UnityEngine.Vector3& ret)
  System.Void set_cullingBoxRelativePosition_Injected(UnityEngine.Vector3& value)
  System.Void get_cullingBoxHalfExtents_Injected(UnityEngine.Vector3& ret)
  System.Void set_cullingBoxHalfExtents_Injected(UnityEngine.Vector3& value)
  System.Void get_cullingBoxOrientation_Injected(UnityEngine.Vector3& ret)
  System.Void set_cullingBoxOrientation_Injected(UnityEngine.Vector3& value)
  System.Void get_boundingSphereOverride_Injected(UnityEngine.Vector4& ret)
  System.Void set_boundingSphereOverride_Injected(UnityEngine.Vector4& value)
  System.Void get_shadowMatrixOverride_Injected(UnityEngine.Matrix4x4& ret)
  System.Void set_shadowMatrixOverride_Injected(UnityEngine.Matrix4x4& value)
  System.Void get_bakingOutput_Injected(UnityEngine.LightBakingOutput& ret)
  System.Void set_bakingOutput_Injected(UnityEngine.LightBakingOutput& value)
  System.Void AddLightStateTransitionPreset_Injected(UnityEngine.LightStateTransition& preset)
  System.Void set_lightAdditionalData_Injected(UnityEngine.HGLightAdditionalData& value)
END_CLASS

CLASS: UnityEngine.MeshFilter
TYPE:  class
TOKEN: 0x20000DF
EXTENDS: Component
FIELDS:
METHODS:
  System.Void DontStripMeshFilter()
  UnityEngine.Mesh get_sharedMesh()
  System.Void set_sharedMesh(UnityEngine.Mesh value)
END_CLASS

CLASS: UnityEngine.RenderingPath
TYPE:  struct
TOKEN: 0x20000E0
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.RenderingPath       UsePlayerSettings  // 0x0
  public    static  UnityEngine.RenderingPath       VertexLit  // 0x0
  public    static  UnityEngine.RenderingPath       Forward  // 0x0
  public    static  UnityEngine.RenderingPath       DeferredLighting  // 0x0
  public    static  UnityEngine.RenderingPath       DeferredShading  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.TransparencySortMode
TYPE:  struct
TOKEN: 0x20000E1
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TransparencySortModeDefault  // 0x0
  public    static  UnityEngine.TransparencySortModePerspective  // 0x0
  public    static  UnityEngine.TransparencySortModeOrthographic  // 0x0
  public    static  UnityEngine.TransparencySortModeCustomAxis  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.StereoTargetEyeMask
TYPE:  struct
TOKEN: 0x20000E2
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.StereoTargetEyeMask None  // 0x0
  public    static  UnityEngine.StereoTargetEyeMask Left  // 0x0
  public    static  UnityEngine.StereoTargetEyeMask Right  // 0x0
  public    static  UnityEngine.StereoTargetEyeMask Both  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.CameraType
TYPE:  struct
TOKEN: 0x20000E3
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.CameraType          Game  // 0x0
  public    static  UnityEngine.CameraType          SceneView  // 0x0
  public    static  UnityEngine.CameraType          Preview  // 0x0
  public    static  UnityEngine.CameraType          VR  // 0x0
  public    static  UnityEngine.CameraType          Reflection  // 0x0
  public    static  UnityEngine.CameraType          Shadow  // 0x0
  public    static  UnityEngine.CameraType          VTPage  // 0x0
  public    static  UnityEngine.CameraType          RayTracing  // 0x0
  public    static  UnityEngine.CameraType          Unknown  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.ComputeBufferType
TYPE:  struct
TOKEN: 0x20000E4
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ComputeBufferType   Default  // 0x0
  public    static  UnityEngine.ComputeBufferType   Raw  // 0x0
  public    static  UnityEngine.ComputeBufferType   Append  // 0x0
  public    static  UnityEngine.ComputeBufferType   Counter  // 0x0
  public    static  UnityEngine.ComputeBufferType   Constant  // 0x0
  public    static  UnityEngine.ComputeBufferType   Structured  // 0x0
  public    static  UnityEngine.ComputeBufferType   DrawIndirect  // 0x0
  public    static  UnityEngine.ComputeBufferType   IndirectArguments  // 0x0
  public    static  UnityEngine.ComputeBufferType   GPUMemory  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.LightType
TYPE:  struct
TOKEN: 0x20000E5
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.LightType           Spot  // 0x0
  public    static  UnityEngine.LightType           Directional  // 0x0
  public    static  UnityEngine.LightType           Point  // 0x0
  public    static  UnityEngine.LightType           Area  // 0x0
  public    static  UnityEngine.LightType           Rectangle  // 0x0
  public    static  UnityEngine.LightType           Disc  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.LightShape
TYPE:  struct
TOKEN: 0x20000E6
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.LightShape          Cone  // 0x0
  public    static  UnityEngine.LightShape          Pyramid  // 0x0
  public    static  UnityEngine.LightShape          Box  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.LightRenderMode
TYPE:  struct
TOKEN: 0x20000E7
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.LightRenderMode     Auto  // 0x0
  public    static  UnityEngine.LightRenderMode     ForcePixel  // 0x0
  public    static  UnityEngine.LightRenderMode     ForceVertex  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.LightShadows
TYPE:  struct
TOKEN: 0x20000E8
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.LightShadows        None  // 0x0
  public    static  UnityEngine.LightShadows        Hard  // 0x0
  public    static  UnityEngine.LightShadows        Soft  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.LightmapBakeType
TYPE:  struct
TOKEN: 0x20000E9
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.LightmapBakeType    Realtime  // 0x0
  public    static  UnityEngine.LightmapBakeType    Baked  // 0x0
  public    static  UnityEngine.LightmapBakeType    Mixed  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.MixedLightingMode
TYPE:  struct
TOKEN: 0x20000EA
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.MixedLightingMode   IndirectOnly  // 0x0
  public    static  UnityEngine.MixedLightingMode   Shadowmask  // 0x0
  public    static  UnityEngine.MixedLightingMode   Subtractive  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.QualityLevel
TYPE:  struct
TOKEN: 0x20000EB
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.QualityLevel        Fastest  // 0x0
  public    static  UnityEngine.QualityLevel        Fast  // 0x0
  public    static  UnityEngine.QualityLevel        Simple  // 0x0
  public    static  UnityEngine.QualityLevel        Good  // 0x0
  public    static  UnityEngine.QualityLevel        Beautiful  // 0x0
  public    static  UnityEngine.QualityLevel        Fantastic  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.ShadowProjection
TYPE:  struct
TOKEN: 0x20000EC
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ShadowProjection    CloseFit  // 0x0
  public    static  UnityEngine.ShadowProjection    StableFit  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.ShadowQuality
TYPE:  struct
TOKEN: 0x20000ED
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ShadowQuality       Disable  // 0x0
  public    static  UnityEngine.ShadowQuality       HardOnly  // 0x0
  public    static  UnityEngine.ShadowQuality       All  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.ShadowResolution
TYPE:  struct
TOKEN: 0x20000EE
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ShadowResolution    Low  // 0x0
  public    static  UnityEngine.ShadowResolution    Medium  // 0x0
  public    static  UnityEngine.ShadowResolution    High  // 0x0
  public    static  UnityEngine.ShadowResolution    VeryHigh  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.ShadowmaskMode
TYPE:  struct
TOKEN: 0x20000EF
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ShadowmaskMode      Shadowmask  // 0x0
  public    static  UnityEngine.ShadowmaskMode      DistanceShadowmask  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.ShadowObjectsFilter
TYPE:  struct
TOKEN: 0x20000F0
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ShadowObjectsFilter AllObjects  // 0x0
  public    static  UnityEngine.ShadowObjectsFilter DynamicOnly  // 0x0
  public    static  UnityEngine.ShadowObjectsFilter StaticOnly  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.CameraClearFlags
TYPE:  struct
TOKEN: 0x20000F1
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.CameraClearFlags    Skybox  // 0x0
  public    static  UnityEngine.CameraClearFlags    Color  // 0x0
  public    static  UnityEngine.CameraClearFlags    SolidColor  // 0x0
  public    static  UnityEngine.CameraClearFlags    Depth  // 0x0
  public    static  UnityEngine.CameraClearFlags    Nothing  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.DepthTextureMode
TYPE:  struct
TOKEN: 0x20000F2
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.DepthTextureMode    None  // 0x0
  public    static  UnityEngine.DepthTextureMode    Depth  // 0x0
  public    static  UnityEngine.DepthTextureMode    DepthNormals  // 0x0
  public    static  UnityEngine.DepthTextureMode    MotionVectors  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.AnisotropicFiltering
TYPE:  struct
TOKEN: 0x20000F3
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AnisotropicFilteringDisable  // 0x0
  public    static  UnityEngine.AnisotropicFilteringEnable  // 0x0
  public    static  UnityEngine.AnisotropicFilteringForceEnable  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.BlendWeights
TYPE:  struct
TOKEN: 0x20000F4
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.BlendWeights        OneBone  // 0x0
  public    static  UnityEngine.BlendWeights        TwoBones  // 0x0
  public    static  UnityEngine.BlendWeights        FourBones  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.SkinWeights
TYPE:  struct
TOKEN: 0x20000F5
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.SkinWeights         OneBone  // 0x0
  public    static  UnityEngine.SkinWeights         TwoBones  // 0x0
  public    static  UnityEngine.SkinWeights         FourBones  // 0x0
  public    static  UnityEngine.SkinWeights         Unlimited  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.MeshTopology
TYPE:  struct
TOKEN: 0x20000F6
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.MeshTopology        Triangles  // 0x0
  public    static  UnityEngine.MeshTopology        Quads  // 0x0
  public    static  UnityEngine.MeshTopology        Lines  // 0x0
  public    static  UnityEngine.MeshTopology        LineStrip  // 0x0
  public    static  UnityEngine.MeshTopology        Points  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.SkinQuality
TYPE:  struct
TOKEN: 0x20000F7
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.SkinQuality         Auto  // 0x0
  public    static  UnityEngine.SkinQuality         Bone1  // 0x0
  public    static  UnityEngine.SkinQuality         Bone2  // 0x0
  public    static  UnityEngine.SkinQuality         Bone4  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.ColorSpace
TYPE:  struct
TOKEN: 0x20000F8
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ColorSpace          Uninitialized  // 0x0
  public    static  UnityEngine.ColorSpace          Gamma  // 0x0
  public    static  UnityEngine.ColorSpace          Linear  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.ColorGamut
TYPE:  struct
TOKEN: 0x20000F9
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ColorGamut          sRGB  // 0x0
  public    static  UnityEngine.ColorGamut          Rec709  // 0x0
  public    static  UnityEngine.ColorGamut          Rec2020  // 0x0
  public    static  UnityEngine.ColorGamut          DisplayP3  // 0x0
  public    static  UnityEngine.ColorGamut          HDR10  // 0x0
  public    static  UnityEngine.ColorGamut          DolbyHDR  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.ScreenOrientation
TYPE:  struct
TOKEN: 0x20000FA
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.ScreenOrientation   Unknown  // 0x0
  public    static  UnityEngine.ScreenOrientation   Landscape  // 0x0
  public    static  UnityEngine.ScreenOrientation   Portrait  // 0x0
  public    static  UnityEngine.ScreenOrientation   PortraitUpsideDown  // 0x0
  public    static  UnityEngine.ScreenOrientation   LandscapeLeft  // 0x0
  public    static  UnityEngine.ScreenOrientation   LandscapeRight  // 0x0
  public    static  UnityEngine.ScreenOrientation   AutoRotation  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.FilterMode
TYPE:  struct
TOKEN: 0x20000FB
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.FilterMode          Point  // 0x0
  public    static  UnityEngine.FilterMode          Bilinear  // 0x0
  public    static  UnityEngine.FilterMode          Trilinear  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.TextureWrapMode
TYPE:  struct
TOKEN: 0x20000FC
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextureWrapMode     Repeat  // 0x0
  public    static  UnityEngine.TextureWrapMode     Clamp  // 0x0
  public    static  UnityEngine.TextureWrapMode     Mirror  // 0x0
  public    static  UnityEngine.TextureWrapMode     MirrorOnce  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.TextureFormat
TYPE:  struct
TOKEN: 0x20000FD
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextureFormat       Alpha8  // 0x0
  public    static  UnityEngine.TextureFormat       ARGB4444  // 0x0
  public    static  UnityEngine.TextureFormat       RGB24  // 0x0
  public    static  UnityEngine.TextureFormat       RGBA32  // 0x0
  public    static  UnityEngine.TextureFormat       ARGB32  // 0x0
  public    static  UnityEngine.TextureFormat       RGB565  // 0x0
  public    static  UnityEngine.TextureFormat       R16  // 0x0
  public    static  UnityEngine.TextureFormat       DXT1  // 0x0
  public    static  UnityEngine.TextureFormat       DXT5  // 0x0
  public    static  UnityEngine.TextureFormat       RGBA4444  // 0x0
  public    static  UnityEngine.TextureFormat       BGRA32  // 0x0
  public    static  UnityEngine.TextureFormat       RHalf  // 0x0
  public    static  UnityEngine.TextureFormat       RGHalf  // 0x0
  public    static  UnityEngine.TextureFormat       RGBAHalf  // 0x0
  public    static  UnityEngine.TextureFormat       RFloat  // 0x0
  public    static  UnityEngine.TextureFormat       RGFloat  // 0x0
  public    static  UnityEngine.TextureFormat       RGBAFloat  // 0x0
  public    static  UnityEngine.TextureFormat       YUY2  // 0x0
  public    static  UnityEngine.TextureFormat       RGB9e5Float  // 0x0
  public    static  UnityEngine.TextureFormat       BC4  // 0x0
  public    static  UnityEngine.TextureFormat       BC5  // 0x0
  public    static  UnityEngine.TextureFormat       BC6H  // 0x0
  public    static  UnityEngine.TextureFormat       BC7  // 0x0
  public    static  UnityEngine.TextureFormat       DXT1Crunched  // 0x0
  public    static  UnityEngine.TextureFormat       DXT5Crunched  // 0x0
  public    static  UnityEngine.TextureFormat       PVRTC_RGB2  // 0x0
  public    static  UnityEngine.TextureFormat       PVRTC_RGBA2  // 0x0
  public    static  UnityEngine.TextureFormat       PVRTC_RGB4  // 0x0
  public    static  UnityEngine.TextureFormat       PVRTC_RGBA4  // 0x0
  public    static  UnityEngine.TextureFormat       ETC_RGB4  // 0x0
  public    static  UnityEngine.TextureFormat       EAC_R  // 0x0
  public    static  UnityEngine.TextureFormat       EAC_R_SIGNED  // 0x0
  public    static  UnityEngine.TextureFormat       EAC_RG  // 0x0
  public    static  UnityEngine.TextureFormat       EAC_RG_SIGNED  // 0x0
  public    static  UnityEngine.TextureFormat       ETC2_RGB  // 0x0
  public    static  UnityEngine.TextureFormat       ETC2_RGBA1  // 0x0
  public    static  UnityEngine.TextureFormat       ETC2_RGBA8  // 0x0
  public    static  UnityEngine.TextureFormat       ASTC_4x4  // 0x0
  public    static  UnityEngine.TextureFormat       ASTC_5x5  // 0x0
  public    static  UnityEngine.TextureFormat       ASTC_6x6  // 0x0
  public    static  UnityEngine.TextureFormat       ASTC_8x8  // 0x0
  public    static  UnityEngine.TextureFormat       ASTC_10x10  // 0x0
  public    static  UnityEngine.TextureFormat       ASTC_12x12  // 0x0
  public    static  UnityEngine.TextureFormat       ETC_RGB4_3DS  // 0x0
  public    static  UnityEngine.TextureFormat       ETC_RGBA8_3DS  // 0x0
  public    static  UnityEngine.TextureFormat       RG16  // 0x0
  public    static  UnityEngine.TextureFormat       R8  // 0x0
  public    static  UnityEngine.TextureFormat       ETC_RGB4Crunched  // 0x0
  public    static  UnityEngine.TextureFormat       ETC2_RGBA8Crunched  // 0x0
  public    static  UnityEngine.TextureFormat       ASTC_HDR_4x4  // 0x0
  public    static  UnityEngine.TextureFormat       ASTC_HDR_5x5  // 0x0
  public    static  UnityEngine.TextureFormat       ASTC_HDR_6x6  // 0x0
  public    static  UnityEngine.TextureFormat       ASTC_HDR_8x8  // 0x0
  public    static  UnityEngine.TextureFormat       ASTC_HDR_10x10  // 0x0
  public    static  UnityEngine.TextureFormat       ASTC_HDR_12x12  // 0x0
  public    static  UnityEngine.TextureFormat       RG32  // 0x0
  public    static  UnityEngine.TextureFormat       RGB48  // 0x0
  public    static  UnityEngine.TextureFormat       RGBA64  // 0x0
  public    static  UnityEngine.TextureFormat       ASTC_RGB_4x4  // 0x0
  public    static  UnityEngine.TextureFormat       ASTC_RGB_5x5  // 0x0
  public    static  UnityEngine.TextureFormat       ASTC_RGB_6x6  // 0x0
  public    static  UnityEngine.TextureFormat       ASTC_RGB_8x8  // 0x0
  public    static  UnityEngine.TextureFormat       ASTC_RGB_10x10  // 0x0
  public    static  UnityEngine.TextureFormat       ASTC_RGB_12x12  // 0x0
  public    static  UnityEngine.TextureFormat       ASTC_RGBA_4x4  // 0x0
  public    static  UnityEngine.TextureFormat       ASTC_RGBA_5x5  // 0x0
  public    static  UnityEngine.TextureFormat       ASTC_RGBA_6x6  // 0x0
  public    static  UnityEngine.TextureFormat       ASTC_RGBA_8x8  // 0x0
  public    static  UnityEngine.TextureFormat       ASTC_RGBA_10x10  // 0x0
  public    static  UnityEngine.TextureFormat       ASTC_RGBA_12x12  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.TextureColorSpace
TYPE:  struct
TOKEN: 0x20000FE
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TextureColorSpace   Linear  // 0x0
  public    static  UnityEngine.TextureColorSpace   sRGB  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.CubemapFace
TYPE:  struct
TOKEN: 0x20000FF
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.CubemapFace         Unknown  // 0x0
  public    static  UnityEngine.CubemapFace         PositiveX  // 0x0
  public    static  UnityEngine.CubemapFace         NegativeX  // 0x0
  public    static  UnityEngine.CubemapFace         PositiveY  // 0x0
  public    static  UnityEngine.CubemapFace         NegativeY  // 0x0
  public    static  UnityEngine.CubemapFace         PositiveZ  // 0x0
  public    static  UnityEngine.CubemapFace         NegativeZ  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.RenderTextureFormat
TYPE:  struct
TOKEN: 0x2000100
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.RenderTextureFormat ARGB32  // 0x0
  public    static  UnityEngine.RenderTextureFormat Depth  // 0x0
  public    static  UnityEngine.RenderTextureFormat ARGBHalf  // 0x0
  public    static  UnityEngine.RenderTextureFormat Shadowmap  // 0x0
  public    static  UnityEngine.RenderTextureFormat RGB565  // 0x0
  public    static  UnityEngine.RenderTextureFormat ARGB4444  // 0x0
  public    static  UnityEngine.RenderTextureFormat ARGB1555  // 0x0
  public    static  UnityEngine.RenderTextureFormat Default  // 0x0
  public    static  UnityEngine.RenderTextureFormat ARGB2101010  // 0x0
  public    static  UnityEngine.RenderTextureFormat DefaultHDR  // 0x0
  public    static  UnityEngine.RenderTextureFormat ARGB64  // 0x0
  public    static  UnityEngine.RenderTextureFormat ARGBFloat  // 0x0
  public    static  UnityEngine.RenderTextureFormat RGFloat  // 0x0
  public    static  UnityEngine.RenderTextureFormat RGHalf  // 0x0
  public    static  UnityEngine.RenderTextureFormat RFloat  // 0x0
  public    static  UnityEngine.RenderTextureFormat RHalf  // 0x0
  public    static  UnityEngine.RenderTextureFormat R8  // 0x0
  public    static  UnityEngine.RenderTextureFormat ARGBInt  // 0x0
  public    static  UnityEngine.RenderTextureFormat RGInt  // 0x0
  public    static  UnityEngine.RenderTextureFormat RInt  // 0x0
  public    static  UnityEngine.RenderTextureFormat BGRA32  // 0x0
  public    static  UnityEngine.RenderTextureFormat RGB111110Float  // 0x0
  public    static  UnityEngine.RenderTextureFormat RG32  // 0x0
  public    static  UnityEngine.RenderTextureFormat RGBAUShort  // 0x0
  public    static  UnityEngine.RenderTextureFormat RG16  // 0x0
  public    static  UnityEngine.RenderTextureFormat BGRA10101010_XR  // 0x0
  public    static  UnityEngine.RenderTextureFormat BGR101010_XR  // 0x0
  public    static  UnityEngine.RenderTextureFormat R16  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.VRTextureUsage
TYPE:  struct
TOKEN: 0x2000101
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.VRTextureUsage      None  // 0x0
  public    static  UnityEngine.VRTextureUsage      OneEye  // 0x0
  public    static  UnityEngine.VRTextureUsage      TwoEyes  // 0x0
  public    static  UnityEngine.VRTextureUsage      DeviceSpecific  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.RenderTextureCreationFlags
TYPE:  struct
TOKEN: 0x2000102
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.RenderTextureCreationFlagsMipMap  // 0x0
  public    static  UnityEngine.RenderTextureCreationFlagsAutoGenerateMips  // 0x0
  public    static  UnityEngine.RenderTextureCreationFlagsSRGB  // 0x0
  public    static  UnityEngine.RenderTextureCreationFlagsEyeTexture  // 0x0
  public    static  UnityEngine.RenderTextureCreationFlagsEnableRandomWrite  // 0x0
  public    static  UnityEngine.RenderTextureCreationFlagsCreatedFromScript  // 0x0
  public    static  UnityEngine.RenderTextureCreationFlagsAllowVerticalFlip  // 0x0
  public    static  UnityEngine.RenderTextureCreationFlagsNoResolvedColorSurface  // 0x0
  public    static  UnityEngine.RenderTextureCreationFlagsDynamicallyScalable  // 0x0
  public    static  UnityEngine.RenderTextureCreationFlagsBindMS  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.RenderTextureReadWrite
TYPE:  struct
TOKEN: 0x2000103
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.RenderTextureReadWriteDefault  // 0x0
  public    static  UnityEngine.RenderTextureReadWriteLinear  // 0x0
  public    static  UnityEngine.RenderTextureReadWritesRGB  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.RenderTextureMemoryless
TYPE:  struct
TOKEN: 0x2000104
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.RenderTextureMemorylessNone  // 0x0
  public    static  UnityEngine.RenderTextureMemorylessColor  // 0x0
  public    static  UnityEngine.RenderTextureMemorylessDepth  // 0x0
  public    static  UnityEngine.RenderTextureMemorylessMSAA  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HDRDisplaySupportFlags
TYPE:  struct
TOKEN: 0x2000105
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HDRDisplaySupportFlagsNone  // 0x0
  public    static  UnityEngine.HDRDisplaySupportFlagsSupported  // 0x0
  public    static  UnityEngine.HDRDisplaySupportFlagsRuntimeSwitchable  // 0x0
  public    static  UnityEngine.HDRDisplaySupportFlagsAutomaticTonemapping  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.LightmapsMode
TYPE:  struct
TOKEN: 0x2000106
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.LightmapsMode       NonDirectional  // 0x0
  public    static  UnityEngine.LightmapsMode       CombinedDirectional  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.MaterialGlobalIlluminationFlags
TYPE:  struct
TOKEN: 0x2000107
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.MaterialGlobalIlluminationFlagsNone  // 0x0
  public    static  UnityEngine.MaterialGlobalIlluminationFlagsRealtimeEmissive  // 0x0
  public    static  UnityEngine.MaterialGlobalIlluminationFlagsBakedEmissive  // 0x0
  public    static  UnityEngine.MaterialGlobalIlluminationFlagsEmissiveIsBlack  // 0x0
  public    static  UnityEngine.MaterialGlobalIlluminationFlagsAnyEmissive  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.LightProbeProxyVolume
TYPE:  class
TOKEN: 0x2000108
EXTENDS: Behaviour
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.MotionVectorGenerationMode
TYPE:  struct
TOKEN: 0x2000109
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.MotionVectorGenerationModeCamera  // 0x0
  public    static  UnityEngine.MotionVectorGenerationModeObject  // 0x0
  public    static  UnityEngine.MotionVectorGenerationModeForceNoMotion  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.LineTextureMode
TYPE:  struct
TOKEN: 0x200010A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.LineTextureMode     Stretch  // 0x0
  public    static  UnityEngine.LineTextureMode     Tile  // 0x0
  public    static  UnityEngine.LineTextureMode     DistributePerSegment  // 0x0
  public    static  UnityEngine.LineTextureMode     RepeatPerSegment  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.LineAlignment
TYPE:  struct
TOKEN: 0x200010B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.LineAlignment       View  // 0x0
  public    static  UnityEngine.LineAlignment       Local  // 0x0
  public    static  UnityEngine.LineAlignment       TransformZ  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.PipelineCacheLoadResult
TYPE:  struct
TOKEN: 0x200010C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.PipelineCacheLoadResultUnknown  // 0x0
  public    static  UnityEngine.PipelineCacheLoadResultSuccess  // 0x0
  public    static  UnityEngine.PipelineCacheLoadResultFailureFileIOError  // 0x0
  public    static  UnityEngine.PipelineCacheLoadResultFailureInvalidCacheData  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HGTextureGroupSettings
TYPE:  class
TOKEN: 0x200010D
FIELDS:
METHODS:
  System.Void SetSkippedMipsAt(System.Int32 textureGroupIndex, System.Int32 skippedMips)
END_CLASS

CLASS: UnityEngine.SkinnedMeshRenderer
TYPE:  class
TOKEN: 0x200010E
EXTENDS: Renderer
FIELDS:
METHODS:
  UnityEngine.SkinQuality get_quality()
  System.Void set_quality(UnityEngine.SkinQuality value)
  System.Boolean get_updateWhenOffscreen()
  System.Void set_updateWhenOffscreen(System.Boolean value)
  System.Boolean get_forceMatrixRecalculationPerRender()
  System.Void set_forceMatrixRecalculationPerRender(System.Boolean value)
  UnityEngine.Transform get_rootBone()
  System.Void set_rootBone(UnityEngine.Transform value)
  UnityEngine.Transform get_skinningRoot()
  System.Void set_skinningRoot(UnityEngine.Transform value)
  UnityEngine.Transform[] get_bones()
  System.Void set_bones(UnityEngine.Transform[] value)
  UnityEngine.Mesh get_sharedMesh()
  System.Void set_sharedMesh(UnityEngine.Mesh value)
  System.Boolean get_skinnedMotionVectors()
  System.Void set_skinnedMotionVectors(System.Boolean value)
  System.Single GetBlendShapeWeight(System.Int32 index)
  System.Void SetBlendShapeWeight(System.Int32 index, System.Single value)
  System.Void BakeMesh(UnityEngine.Mesh mesh)
  System.Void BakeMesh(UnityEngine.Mesh mesh, System.Boolean useScale)
  UnityEngine.GraphicsBuffer GetVertexBuffer()
  UnityEngine.GraphicsBuffer GetPreviousVertexBuffer()
  UnityEngine.GraphicsBuffer GetVertexBufferImpl()
  UnityEngine.GraphicsBuffer GetPreviousVertexBufferImpl()
  System.Boolean RequestCurrentFrameSkinMatrices(System.Void* ptr, System.Int32 size)
  System.Boolean SkinMatricesRequestFinished()
  UnityEngine.GraphicsBuffer.Target get_vertexBufferTarget()
  System.Void set_vertexBufferTarget(UnityEngine.GraphicsBuffer.Target value)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.MeshRenderer
TYPE:  class
TOKEN: 0x200010F
EXTENDS: Renderer
FIELDS:
METHODS:
  System.Void DontStripMeshRenderer()
  System.Int32 get_subMeshStartIndex()
END_CLASS

CLASS: UnityEngine.HGLightNPRType
TYPE:  struct
TOKEN: 0x2000110
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HGLightNPRType      Default  // 0x0
  public    static  UnityEngine.HGLightNPRType      Ramped  // 0x0
  public    static  UnityEngine.HGLightNPRType      SpecularOnly  // 0x0
  public    static  UnityEngine.HGLightNPRType      RimOnly  // 0x0
  public    static  UnityEngine.HGLightNPRType      FogFade  // 0x0
  public    static  UnityEngine.HGLightNPRType      IgnoreCharacter  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HGLightAdditionalData
TYPE:  struct
TOKEN: 0x2000111
FIELDS:
  public            UnityEngine.Vector4             lightNPRData  // 0x10
  public            UnityEngine.HGLightNPRType      lightNPRType  // 0x20
  public            System.Boolean                  LightCharacterOnly  // 0x24
  public            System.Single                   volumetricScatteringIntensity  // 0x28
  public            System.Single                   falloffExponent  // 0x2C
METHODS:
END_CLASS

CLASS: UnityEngine.HGSharedLightData
TYPE:  struct
TOKEN: 0x2000112
FIELDS:
  private           System.UInt32                   m_Padding1  // 0x10
  private           System.UInt32                   m_Padding2  // 0x14
METHODS:
  System.Void .ctor(System.UInt32 entityIdx, System.UInt32 entityVersion)
  System.Boolean Equals(UnityEngine.HGSharedLightData rhs)
  System.Boolean Equals(System.Object obj)
  UnityEngine.LightType get_type()
  UnityEngine.Color get_color()
  System.Single get_spotAngle()
  System.Single get_innerSpotAngle()
  System.Boolean get_shadowOnly()
  System.Boolean get_enableOBBCullingBox()
  UnityEngine.Vector3 get_cullingBoxRelativePosition()
  UnityEngine.Vector3 get_cullingBoxHalfExtents()
  UnityEngine.Vector3 get_cullingBoxOrientation()
  System.Single get_cullingBoxFalloffThreshold()
  System.Single get_length()
  System.Single get_intensity()
  System.Single get_specularIntensity()
  System.Single get_shadowBias()
  System.Single get_shadowNormalBias()
  System.Single get_shadowNearPlane()
  System.Single get_range()
  System.Single get_softSourceRadius()
  System.Int32 get_instanceID()
  UnityEngine.LightShadows get_shadows()
  System.Single get_shadowStrength()
  UnityEngine.Matrix4x4 get_localToWorldMatrix()
  System.Single get_shadowFarPlane()
  System.Single get_shadowCullDistance()
  System.Single get_shadowFadeRatio()
  System.Single get_shadowGuardAngle()
  System.Int32 get_pointLightShadowCasterFaces()
  System.Int32 get_shadowCasterProperties()
  System.Boolean get_useCullingDistance()
  System.Single get_cullingDistance()
  System.Single get_falloffDistance()
  UnityEngine.Light get_light()
  System.UInt32 get_entityIndex()
  System.UInt32 get_entityVersion()
  System.Boolean get_isVaild()
  UnityEngine.Vector3 get_worldPosition()
  UnityEngine.HGLightAdditionalData get_lightAdditionalData()
  System.Void set_lightAdditionalData(UnityEngine.HGLightAdditionalData value)
  System.Int32 GetHashCode()
  System.Boolean get_isRuntimeShadowBaked()
  System.Void set_isRuntimeShadowBaked(System.Boolean value)
  System.Boolean get_isDynamicShadowCaster()
  System.Boolean get_castStaticObjects()
  System.Boolean get_castDynamicObjects()
  UnityEngine.Texture get_cookie()
  System.Boolean GetPointLightShadowCasterFace(UnityEngine.CubemapFace face)
  System.Boolean IsPointLightHasExactlyOneCaster()
  System.String GetDebugName()
  System.Single get_flickerScale()
  UnityEngine.LightType get_type_Injected(UnityEngine.HGSharedLightData& _unity_self)
  System.Void get_color_Injected(UnityEngine.HGSharedLightData& _unity_self, UnityEngine.Color& ret)
  System.Single get_spotAngle_Injected(UnityEngine.HGSharedLightData& _unity_self)
  System.Single get_innerSpotAngle_Injected(UnityEngine.HGSharedLightData& _unity_self)
  System.Boolean get_shadowOnly_Injected(UnityEngine.HGSharedLightData& _unity_self)
  System.Boolean get_enableOBBCullingBox_Injected(UnityEngine.HGSharedLightData& _unity_self)
  System.Void get_cullingBoxRelativePosition_Injected(UnityEngine.HGSharedLightData& _unity_self, UnityEngine.Vector3& ret)
  System.Void get_cullingBoxHalfExtents_Injected(UnityEngine.HGSharedLightData& _unity_self, UnityEngine.Vector3& ret)
  System.Void get_cullingBoxOrientation_Injected(UnityEngine.HGSharedLightData& _unity_self, UnityEngine.Vector3& ret)
  System.Single get_cullingBoxFalloffThreshold_Injected(UnityEngine.HGSharedLightData& _unity_self)
  System.Single get_length_Injected(UnityEngine.HGSharedLightData& _unity_self)
  System.Single get_intensity_Injected(UnityEngine.HGSharedLightData& _unity_self)
  System.Single get_specularIntensity_Injected(UnityEngine.HGSharedLightData& _unity_self)
  System.Single get_shadowBias_Injected(UnityEngine.HGSharedLightData& _unity_self)
  System.Single get_shadowNormalBias_Injected(UnityEngine.HGSharedLightData& _unity_self)
  System.Single get_shadowNearPlane_Injected(UnityEngine.HGSharedLightData& _unity_self)
  System.Single get_range_Injected(UnityEngine.HGSharedLightData& _unity_self)
  System.Single get_softSourceRadius_Injected(UnityEngine.HGSharedLightData& _unity_self)
  System.Int32 get_instanceID_Injected(UnityEngine.HGSharedLightData& _unity_self)
  UnityEngine.LightShadows get_shadows_Injected(UnityEngine.HGSharedLightData& _unity_self)
  System.Single get_shadowStrength_Injected(UnityEngine.HGSharedLightData& _unity_self)
  System.Void get_localToWorldMatrix_Injected(UnityEngine.HGSharedLightData& _unity_self, UnityEngine.Matrix4x4& ret)
  System.Single get_shadowFarPlane_Injected(UnityEngine.HGSharedLightData& _unity_self)
  System.Single get_shadowCullDistance_Injected(UnityEngine.HGSharedLightData& _unity_self)
  System.Single get_shadowFadeRatio_Injected(UnityEngine.HGSharedLightData& _unity_self)
  System.Single get_shadowGuardAngle_Injected(UnityEngine.HGSharedLightData& _unity_self)
  System.Int32 get_pointLightShadowCasterFaces_Injected(UnityEngine.HGSharedLightData& _unity_self)
  System.Int32 get_shadowCasterProperties_Injected(UnityEngine.HGSharedLightData& _unity_self)
  System.Boolean get_useCullingDistance_Injected(UnityEngine.HGSharedLightData& _unity_self)
  System.Single get_cullingDistance_Injected(UnityEngine.HGSharedLightData& _unity_self)
  System.Single get_falloffDistance_Injected(UnityEngine.HGSharedLightData& _unity_self)
  System.UInt32 get_entityIndex_Injected(UnityEngine.HGSharedLightData& _unity_self)
  System.UInt32 get_entityVersion_Injected(UnityEngine.HGSharedLightData& _unity_self)
  System.Boolean get_isVaild_Injected(UnityEngine.HGSharedLightData& _unity_self)
  System.Void get_worldPosition_Injected(UnityEngine.HGSharedLightData& _unity_self, UnityEngine.Vector3& ret)
  System.Void get_lightAdditionalData_Injected(UnityEngine.HGSharedLightData& _unity_self, UnityEngine.HGLightAdditionalData& ret)
  System.Void set_lightAdditionalData_Injected(UnityEngine.HGSharedLightData& _unity_self, UnityEngine.HGLightAdditionalData& value)
  System.Boolean get_isRuntimeShadowBaked_Injected(UnityEngine.HGSharedLightData& _unity_self)
  System.Void set_isRuntimeShadowBaked_Injected(UnityEngine.HGSharedLightData& _unity_self, System.Boolean value)
  UnityEngine.Texture get_cookie_Injected(UnityEngine.HGSharedLightData& _unity_self)
  System.Single get_flickerScale_Injected(UnityEngine.HGSharedLightData& _unity_self)
END_CLASS

CLASS: UnityEngine.LightStateIntensityTransition
TYPE:  struct
TOKEN: 0x2000113
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.LightStateIntensityTransitionFadeToBlack  // 0x0
  public    static  UnityEngine.LightStateIntensityTransitionIntensityBlend  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.LightFlickerStyle
TYPE:  class
TOKEN: 0x2000114
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void Internal_Create(UnityEngine.LightFlickerStyle self)
END_CLASS

CLASS: UnityEngine.LightFlickerData
TYPE:  struct
TOKEN: 0x2000115
FIELDS:
  private           System.Single                   flickeringSpeed  // 0x10
  private           System.Single                   flickerTimeDelay  // 0x14
  private           System.Boolean                  randomDelay  // 0x18
  private           System.Boolean                  enableFlicker  // 0x19
METHODS:
END_CLASS

CLASS: UnityEngine.LightSpinData
TYPE:  struct
TOKEN: 0x2000116
FIELDS:
  private           UnityEngine.Vector3             spinAxis  // 0x10
  private           UnityEngine.Vector3             spinAnchor  // 0x1C
  private           System.Single                   spinSpeed  // 0x28
  private           System.Single                   spinTimeDelay  // 0x2C
  private           System.Boolean                  randomDelay  // 0x30
  private           System.Boolean                  enableSpin  // 0x31
METHODS:
END_CLASS

CLASS: UnityEngine.LightAnimatedData
TYPE:  struct
TOKEN: 0x2000117
FIELDS:
  private           UnityEngine.LightFlickerData    flickerData  // 0x10
  private           UnityEngine.LightSpinData       spinData  // 0x1C
METHODS:
END_CLASS

CLASS: UnityEngine.LightStateTransitionData
TYPE:  struct
TOKEN: 0x2000118
FIELDS:
  public            UnityEngine.LightStateIntensityTransitionIntensityTransition  // 0x10
  public            UnityEngine.LightAnimatedData   AnimatedData  // 0x14
METHODS:
END_CLASS

CLASS: UnityEngine.LightStateTransitionPreset
TYPE:  class
TOKEN: 0x2000119
FIELDS:
  private           UnityEngine.LightStateTransitionData<transitionData>k__BackingField  // 0x18
METHODS:
  System.Void set_transitionData(UnityEngine.LightStateTransitionData value)
  UnityEngine.LightStateTransitionData get_transitionData()
  System.Void .ctor()
  System.Void Internal_Create(UnityEngine.LightStateTransitionPreset self)
END_CLASS

CLASS: UnityEngine.LightStateTransition
TYPE:  struct
TOKEN: 0x200011A
FIELDS:
  public            System.String                   tagName  // 0x10
  public            UnityEngine.LightStateTransitionPresettransitionPreset  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.LightProbeGroup
TYPE:  class
TOKEN: 0x200011B
EXTENDS: Behaviour
FIELDS:
METHODS:
  UnityEngine.Vector3[] get_probePositions()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.LODFadeMode
TYPE:  struct
TOKEN: 0x200011C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.LODFadeMode         None  // 0x0
  public    static  UnityEngine.LODFadeMode         CrossFade  // 0x0
  public    static  UnityEngine.LODFadeMode         SpeedTree  // 0x0
  public    static  UnityEngine.LODFadeMode         Disabled  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.LOD
TYPE:  struct
TOKEN: 0x200011D
FIELDS:
  public            System.Single                   screenRelativeTransitionHeight  // 0x10
  public            System.Single                   fadeTransitionWidth  // 0x14
  public            UnityEngine.Renderer[]          renderers  // 0x18
METHODS:
  System.Void .ctor(System.Single screenRelativeTransitionHeight, UnityEngine.Renderer[] renderers)
END_CLASS

CLASS: UnityEngine.LODGroup
TYPE:  class
TOKEN: 0x200011E
EXTENDS: Component
FIELDS:
METHODS:
  System.Single get_size()
  System.Void set_size(System.Single value)
  System.Int32 get_lodCount()
  System.Void set_fadeMode(UnityEngine.LODFadeMode value)
  System.Boolean get_animateCrossFading()
  System.Void set_animateCrossFading(System.Boolean value)
  System.Void RecalculateBounds()
  UnityEngine.LOD[] GetLODs(System.Boolean getPlatformLODs)
  System.Void SetLODs(UnityEngine.LOD[] lods)
  System.Void ForceLOD(System.Int32 index)
  System.Boolean CalculateLOD(UnityEngine.Camera camera, System.Int32& lodIndex, System.Single& fadeValue)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Mesh
TYPE:  class
TOKEN: 0x200011F
FIELDS:
METHODS:
  System.IntPtr HGGetPtrUnchecked()
  System.Void Internal_Create(UnityEngine.Mesh mono)
  System.Void .ctor()
  UnityEngine.Mesh FromInstanceID(System.Int32 id)
  UnityEngine.Rendering.IndexFormat get_indexFormat()
  System.Void set_indexFormat(UnityEngine.Rendering.IndexFormat value)
  System.Int32 GetVertexAttributeCountImpl()
  UnityEngine.Rendering.VertexAttributeDescriptor GetVertexAttribute(System.Int32 index)
  System.UInt32 GetIndexCountImpl(System.Int32 submesh)
  System.UInt32 GetTrianglesCountImpl(System.Int32 submesh)
  System.UInt32 GetBaseVertexImpl(System.Int32 submesh)
  System.Int32[] GetTrianglesImpl(System.Int32 submesh, System.Boolean applyBaseVertex)
  System.Int32[] GetIndicesImpl(System.Int32 submesh, System.Boolean applyBaseVertex)
  System.Void SetIndicesImpl(System.Int32 submesh, UnityEngine.MeshTopology topology, UnityEngine.Rendering.IndexFormat indicesFormat, System.Array indices, System.Int32 arrayStart, System.Int32 arraySize, System.Boolean calculateBounds, System.Int32 baseVertex)
  System.Void GetTrianglesNonAllocImpl(System.Int32[] values, System.Int32 submesh, System.Boolean applyBaseVertex)
  System.Void PrintErrorCantAccessChannel(UnityEngine.Rendering.VertexAttribute ch)
  System.Boolean HasVertexAttribute(UnityEngine.Rendering.VertexAttribute attr)
  System.Void SetArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, System.Int32 dim, System.Array values, System.Int32 arraySize, System.Int32 valuesStart, System.Int32 valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Void SetNativeArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, System.Int32 dim, System.IntPtr values, System.Int32 arraySize, System.Int32 valuesStart, System.Int32 valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Array GetAllocArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, System.Int32 dim)
  System.Void GetArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, System.Int32 dim, System.Array values)
  UnityEngine.GraphicsBuffer GetVertexBufferImpl(System.Int32 index)
  UnityEngine.GraphicsBuffer.Target get_vertexBufferTarget()
  System.Void set_vertexBufferTarget(UnityEngine.GraphicsBuffer.Target value)
  System.Int32 get_blendShapeCount()
  System.String GetBlendShapeName(System.Int32 shapeIndex)
  System.Int32 GetBlendShapeFrameCount(System.Int32 shapeIndex)
  System.Single GetBlendShapeFrameWeight(System.Int32 shapeIndex, System.Int32 frameIndex)
  System.Void GetBlendShapeFrameVertices(System.Int32 shapeIndex, System.Int32 frameIndex, UnityEngine.Vector3[] deltaVertices, UnityEngine.Vector3[] deltaNormals, UnityEngine.Vector3[] deltaTangents)
  System.Void AddBlendShapeFrame(System.String shapeName, System.Single frameWeight, UnityEngine.Vector3[] deltaVertices, UnityEngine.Vector3[] deltaNormals, UnityEngine.Vector3[] deltaTangents)
  System.Boolean HasBoneWeights()
  UnityEngine.BoneWeight[] GetBoneWeightsImpl()
  System.Void SetBoneWeightsImpl(UnityEngine.BoneWeight[] weights)
  System.Void SetBoneWeights(Unity.Collections.NativeArray<System.Byte> bonesPerVertex, Unity.Collections.NativeArray<UnityEngine.BoneWeight1> weights)
  System.Void InternalSetBoneWeights(System.IntPtr bonesPerVertex, System.Int32 bonesPerVertexSize, System.IntPtr weights, System.Int32 weightsSize)
  Unity.Collections.NativeArray<UnityEngine.BoneWeight1> GetAllBoneWeights()
  Unity.Collections.NativeArray<System.Byte> GetBonesPerVertex()
  System.Int32 GetAllBoneWeightsArraySize()
  System.IntPtr GetAllBoneWeightsArray()
  System.IntPtr GetBonesPerVertexArray()
  System.Int32 GetBonesPerVertexValue()
  UnityEngine.Matrix4x4[] get_bindposes()
  System.Void set_bindposes(UnityEngine.Matrix4x4[] value)
  System.Void GetBoneWeightsNonAllocImpl(UnityEngine.BoneWeight[] values)
  System.Boolean get_isReadable()
  System.Boolean get_canAccess()
  System.Int32 get_vertexCount()
  System.Int32 get_subMeshCount()
  System.Void set_subMeshCount(System.Int32 value)
  UnityEngine.Bounds get_bounds()
  System.Void set_bounds(UnityEngine.Bounds value)
  System.Void ClearImpl(System.Boolean keepVertexLayout)
  System.Void RecalculateBoundsImpl(UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Void RecalculateNormalsImpl(UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Void RecalculateTangentsImpl(UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Void MarkDynamicImpl()
  System.Void UploadMeshDataImpl(System.Boolean markNoLongerReadable)
  UnityEngine.MeshTopology GetTopologyImpl(System.Int32 submesh)
  System.Void CombineMeshesImpl(UnityEngine.CombineInstance[] combine, System.Boolean mergeSubMeshes, System.Boolean useMatrices, System.Boolean hasLightmapData)
  System.Void OptimizeImpl()
  UnityEngine.Rendering.VertexAttribute GetUVChannel(System.Int32 uvIndex)
  System.Int32 DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute channel)
  T[] GetAllocArrayFromChannel(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, System.Int32 dim)
  T[] GetAllocArrayFromChannel(UnityEngine.Rendering.VertexAttribute channel)
  System.Void SetSizedArrayForChannel(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, System.Int32 dim, System.Array values, System.Int32 valuesArrayLength, System.Int32 valuesStart, System.Int32 valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Void SetSizedNativeArrayForChannel(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, System.Int32 dim, System.IntPtr values, System.Int32 valuesArrayLength, System.Int32 valuesStart, System.Int32 valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Void SetArrayForChannel(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, System.Int32 dim, T[] values, UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Void SetArrayForChannel(UnityEngine.Rendering.VertexAttribute channel, T[] values, UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Void SetListForChannel(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, System.Int32 dim, System.Collections.Generic.List<T> values, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Void SetListForChannel(UnityEngine.Rendering.VertexAttribute channel, System.Collections.Generic.List<T> values, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Void GetListForChannel(System.Collections.Generic.List<T> buffer, System.Int32 capacity, UnityEngine.Rendering.VertexAttribute channel, System.Int32 dim)
  System.Void GetListForChannel(System.Collections.Generic.List<T> buffer, System.Int32 capacity, UnityEngine.Rendering.VertexAttribute channel, System.Int32 dim, UnityEngine.Rendering.VertexAttributeFormat channelType)
  UnityEngine.Vector3[] get_vertices()
  System.Void set_vertices(UnityEngine.Vector3[] value)
  UnityEngine.Vector3[] get_normals()
  System.Void set_normals(UnityEngine.Vector3[] value)
  UnityEngine.Vector4[] get_tangents()
  System.Void set_tangents(UnityEngine.Vector4[] value)
  UnityEngine.Vector2[] get_uv()
  System.Void set_uv(UnityEngine.Vector2[] value)
  UnityEngine.Vector2[] get_uv2()
  System.Void set_uv2(UnityEngine.Vector2[] value)
  UnityEngine.Vector2[] get_uv3()
  UnityEngine.Vector2[] get_uv4()
  UnityEngine.Vector2[] get_uv5()
  UnityEngine.Vector2[] get_uv6()
  UnityEngine.Vector2[] get_uv7()
  UnityEngine.Vector2[] get_uv8()
  UnityEngine.Color[] get_colors()
  System.Void set_colors(UnityEngine.Color[] value)
  UnityEngine.Color32[] get_colors32()
  System.Void set_colors32(UnityEngine.Color32[] value)
  System.Void GetVertices(System.Collections.Generic.List<UnityEngine.Vector3> vertices)
  System.Void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices)
  System.Void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices, System.Int32 start, System.Int32 length)
  System.Void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Void SetVertices(UnityEngine.Vector3[] inVertices)
  System.Void SetVertices(UnityEngine.Vector3[] inVertices, System.Int32 start, System.Int32 length)
  System.Void SetVertices(UnityEngine.Vector3[] inVertices, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Void SetVertices(Unity.Collections.NativeArray<T> inVertices)
  System.Void SetVertices(Unity.Collections.NativeArray<T> inVertices, System.Int32 start, System.Int32 length)
  System.Void SetVertices(Unity.Collections.NativeArray<T> inVertices, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Void GetNormals(System.Collections.Generic.List<UnityEngine.Vector3> normals)
  System.Void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals)
  System.Void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals, System.Int32 start, System.Int32 length)
  System.Void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Void SetNormals(UnityEngine.Vector3[] inNormals)
  System.Void SetNormals(UnityEngine.Vector3[] inNormals, System.Int32 start, System.Int32 length)
  System.Void SetNormals(UnityEngine.Vector3[] inNormals, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Void SetNormals(Unity.Collections.NativeArray<T> inNormals)
  System.Void SetNormals(Unity.Collections.NativeArray<T> inNormals, System.Int32 start, System.Int32 length)
  System.Void SetNormals(Unity.Collections.NativeArray<T> inNormals, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Void GetTangents(System.Collections.Generic.List<UnityEngine.Vector4> tangents)
  System.Void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents)
  System.Void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents, System.Int32 start, System.Int32 length)
  System.Void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Void SetTangents(Unity.Collections.NativeArray<T> inTangents)
  System.Void SetTangents(Unity.Collections.NativeArray<T> inTangents, System.Int32 start, System.Int32 length)
  System.Void SetTangents(Unity.Collections.NativeArray<T> inTangents, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Void SetColors(System.Collections.Generic.List<UnityEngine.Color> inColors)
  System.Void SetColors(System.Collections.Generic.List<UnityEngine.Color> inColors, System.Int32 start, System.Int32 length)
  System.Void SetColors(System.Collections.Generic.List<UnityEngine.Color> inColors, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Void GetColors(System.Collections.Generic.List<UnityEngine.Color32> colors)
  System.Void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors)
  System.Void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors, System.Int32 start, System.Int32 length)
  System.Void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Void SetUvsImpl(System.Int32 uvIndex, System.Int32 dim, System.Collections.Generic.List<T> uvs, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Void SetUVs(System.Int32 channel, System.Collections.Generic.List<UnityEngine.Vector2> uvs)
  System.Void SetUVs(System.Int32 channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs)
  System.Void SetUVs(System.Int32 channel, System.Collections.Generic.List<UnityEngine.Vector2> uvs, System.Int32 start, System.Int32 length)
  System.Void SetUVs(System.Int32 channel, System.Collections.Generic.List<UnityEngine.Vector2> uvs, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Void SetUVs(System.Int32 channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs, System.Int32 start, System.Int32 length)
  System.Void SetUVs(System.Int32 channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Void SetUvsImpl(System.Int32 uvIndex, System.Int32 dim, System.Array uvs, System.Int32 arrayStart, System.Int32 arraySize, UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Void SetUVs(System.Int32 channel, UnityEngine.Vector2[] uvs)
  System.Void SetUVs(System.Int32 channel, UnityEngine.Vector3[] uvs)
  System.Void SetUVs(System.Int32 channel, UnityEngine.Vector4[] uvs)
  System.Void SetUVs(System.Int32 channel, UnityEngine.Vector2[] uvs, System.Int32 start, System.Int32 length)
  System.Void SetUVs(System.Int32 channel, UnityEngine.Vector2[] uvs, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Void SetUVs(System.Int32 channel, UnityEngine.Vector3[] uvs, System.Int32 start, System.Int32 length)
  System.Void SetUVs(System.Int32 channel, UnityEngine.Vector3[] uvs, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Void SetUVs(System.Int32 channel, UnityEngine.Vector4[] uvs, System.Int32 start, System.Int32 length)
  System.Void SetUVs(System.Int32 channel, UnityEngine.Vector4[] uvs, System.Int32 start, System.Int32 length, UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Void GetUVsImpl(System.Int32 uvIndex, System.Collections.Generic.List<T> uvs, System.Int32 dim)
  System.Void GetUVs(System.Int32 channel, System.Collections.Generic.List<UnityEngine.Vector3> uvs)
  System.Void GetUVs(System.Int32 channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs)
  System.Int32 get_vertexAttributeCount()
  UnityEngine.Mesh.MeshDataArray AcquireReadOnlyMeshData(UnityEngine.Mesh mesh)
  UnityEngine.GraphicsBuffer GetVertexBuffer(System.Int32 index)
  System.Void PrintErrorCantAccessIndices()
  System.Boolean CheckCanAccessSubmesh(System.Int32 submesh, System.Boolean errorAboutTriangles)
  System.Boolean CheckCanAccessSubmeshTriangles(System.Int32 submesh)
  System.Boolean CheckCanAccessSubmeshIndices(System.Int32 submesh)
  System.Int32[] get_triangles()
  System.Void set_triangles(System.Int32[] value)
  System.Int32[] GetTriangles(System.Int32 submesh)
  System.Int32[] GetTriangles(System.Int32 submesh, System.Boolean applyBaseVertex)
  System.Void GetTriangles(System.Collections.Generic.List<System.Int32> triangles, System.Int32 submesh)
  System.Void GetTriangles(System.Collections.Generic.List<System.Int32> triangles, System.Int32 submesh, System.Boolean applyBaseVertex)
  System.Int32[] GetIndices(System.Int32 submesh)
  System.Int32[] GetIndices(System.Int32 submesh, System.Boolean applyBaseVertex)
  System.UInt32 GetIndexCount(System.Int32 submesh)
  System.UInt32 GetBaseVertex(System.Int32 submesh)
  System.Void CheckIndicesArrayRange(System.Int32 valuesLength, System.Int32 start, System.Int32 length)
  System.Void SetTrianglesImpl(System.Int32 submesh, UnityEngine.Rendering.IndexFormat indicesFormat, System.Array triangles, System.Int32 trianglesArrayLength, System.Int32 start, System.Int32 length, System.Boolean calculateBounds, System.Int32 baseVertex)
  System.Void SetTriangles(System.Int32[] triangles, System.Int32 submesh)
  System.Void SetTriangles(System.Int32[] triangles, System.Int32 submesh, System.Boolean calculateBounds, System.Int32 baseVertex)
  System.Void SetTriangles(System.Int32[] triangles, System.Int32 trianglesStart, System.Int32 trianglesLength, System.Int32 submesh, System.Boolean calculateBounds, System.Int32 baseVertex)
  System.Void SetTriangles(System.Collections.Generic.List<System.Int32> triangles, System.Int32 submesh)
  System.Void SetTriangles(System.Collections.Generic.List<System.Int32> triangles, System.Int32 submesh, System.Boolean calculateBounds, System.Int32 baseVertex)
  System.Void SetTriangles(System.Collections.Generic.List<System.Int32> triangles, System.Int32 trianglesStart, System.Int32 trianglesLength, System.Int32 submesh, System.Boolean calculateBounds, System.Int32 baseVertex)
  System.Void SetIndices(System.Int32[] indices, UnityEngine.MeshTopology topology, System.Int32 submesh)
  System.Void SetIndices(System.Int32[] indices, UnityEngine.MeshTopology topology, System.Int32 submesh, System.Boolean calculateBounds, System.Int32 baseVertex)
  System.Void SetIndices(System.Int32[] indices, System.Int32 indicesStart, System.Int32 indicesLength, UnityEngine.MeshTopology topology, System.Int32 submesh, System.Boolean calculateBounds, System.Int32 baseVertex)
  System.Void SetIndices(System.UInt16[] indices, UnityEngine.MeshTopology topology, System.Int32 submesh, System.Boolean calculateBounds, System.Int32 baseVertex)
  System.Void SetIndices(System.UInt16[] indices, System.Int32 indicesStart, System.Int32 indicesLength, UnityEngine.MeshTopology topology, System.Int32 submesh, System.Boolean calculateBounds, System.Int32 baseVertex)
  System.Void SetIndices(System.Collections.Generic.List<System.Int32> indices, UnityEngine.MeshTopology topology, System.Int32 submesh, System.Boolean calculateBounds, System.Int32 baseVertex)
  System.Void SetIndices(System.Collections.Generic.List<System.Int32> indices, System.Int32 indicesStart, System.Int32 indicesLength, UnityEngine.MeshTopology topology, System.Int32 submesh, System.Boolean calculateBounds, System.Int32 baseVertex)
  System.Void GetBoneWeights(System.Collections.Generic.List<UnityEngine.BoneWeight> boneWeights)
  UnityEngine.BoneWeight[] get_boneWeights()
  System.Void set_boneWeights(UnityEngine.BoneWeight[] value)
  System.Void Clear(System.Boolean keepVertexLayout)
  System.Void Clear()
  System.Void RecalculateBounds()
  System.Void RecalculateNormals()
  System.Void RecalculateTangents()
  System.Void RecalculateBounds(UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Void RecalculateNormals(UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Void RecalculateTangents(UnityEngine.Rendering.MeshUpdateFlags flags)
  System.Void MarkDynamic()
  System.Void UploadMeshData(System.Boolean markNoLongerReadable)
  System.Void Optimize()
  UnityEngine.MeshTopology GetTopology(System.Int32 submesh)
  System.Void CombineMeshes(UnityEngine.CombineInstance[] combine, System.Boolean mergeSubMeshes, System.Boolean useMatrices)
  System.Void GetVertexAttribute_Injected(System.Int32 index, UnityEngine.Rendering.VertexAttributeDescriptor& ret)
  System.Void get_bounds_Injected(UnityEngine.Bounds& ret)
  System.Void set_bounds_Injected(UnityEngine.Bounds& value)
END_CLASS

CLASS: UnityEngine.BoneWeight
TYPE:  struct
TOKEN: 0x2000122
FIELDS:
  private           System.Single                   m_Weight0  // 0x10
  private           System.Single                   m_Weight1  // 0x14
  private           System.Single                   m_Weight2  // 0x18
  private           System.Single                   m_Weight3  // 0x1C
  private           System.Int32                    m_BoneIndex0  // 0x20
  private           System.Int32                    m_BoneIndex1  // 0x24
  private           System.Int32                    m_BoneIndex2  // 0x28
  private           System.Int32                    m_BoneIndex3  // 0x2C
METHODS:
  System.Single get_weight0()
  System.Void set_weight0(System.Single value)
  System.Single get_weight1()
  System.Void set_weight1(System.Single value)
  System.Single get_weight2()
  System.Void set_weight2(System.Single value)
  System.Single get_weight3()
  System.Void set_weight3(System.Single value)
  System.Int32 get_boneIndex0()
  System.Void set_boneIndex0(System.Int32 value)
  System.Int32 get_boneIndex1()
  System.Void set_boneIndex1(System.Int32 value)
  System.Int32 get_boneIndex2()
  System.Void set_boneIndex2(System.Int32 value)
  System.Int32 get_boneIndex3()
  System.Void set_boneIndex3(System.Int32 value)
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(UnityEngine.BoneWeight other)
END_CLASS

CLASS: UnityEngine.BoneWeight1
TYPE:  struct
TOKEN: 0x2000123
FIELDS:
  private           System.Single                   m_Weight  // 0x10
  private           System.Int32                    m_BoneIndex  // 0x14
METHODS:
  System.Single get_weight()
  System.Void set_weight(System.Single value)
  System.Int32 get_boneIndex()
  System.Void set_boneIndex(System.Int32 value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(UnityEngine.BoneWeight1 other)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.CombineInstance
TYPE:  struct
TOKEN: 0x2000124
FIELDS:
  private           System.Int32                    m_MeshInstanceID  // 0x10
  private           System.Int32                    m_SubMeshIndex  // 0x14
  private           UnityEngine.Matrix4x4           m_Transform  // 0x18
  private           UnityEngine.Vector4             m_LightmapScaleOffset  // 0x58
  private           UnityEngine.Vector4             m_RealtimeLightmapScaleOffset  // 0x68
METHODS:
  UnityEngine.Mesh get_mesh()
  System.Void set_mesh(UnityEngine.Mesh value)
  System.Void set_subMeshIndex(System.Int32 value)
  System.Void set_transform(UnityEngine.Matrix4x4 value)
END_CLASS

CLASS: UnityEngine.Texture
TYPE:  class
TOKEN: 0x2000125
FIELDS:
  public    static readonly System.Int32                    GenerateAllMips  // 0x0
METHODS:
  System.IntPtr HGGetPtrUnchecked_Texture(System.Int32 instanceID)
  System.IntPtr HGGetPtrUnchecked()
  System.Void .ctor()
  System.Int32 get_masterTextureLimit()
  System.Void set_masterTextureLimit(System.Int32 value)
  System.Int32 get_mipmapCount()
  UnityEngine.AnisotropicFiltering get_anisotropicFiltering()
  System.Void set_anisotropicFiltering(UnityEngine.AnisotropicFiltering value)
  System.Void SetGlobalAnisotropicFilteringLimits(System.Int32 forcedMin, System.Int32 globalMax)
  UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat()
  System.Int32 GetDataWidth()
  System.Int32 GetDataHeight()
  UnityEngine.Rendering.TextureDimension GetDimension()
  System.Int32 get_width()
  System.Void set_width(System.Int32 value)
  System.Int32 get_height()
  System.Void set_height(System.Int32 value)
  UnityEngine.Rendering.TextureDimension get_dimension()
  System.Void set_dimension(UnityEngine.Rendering.TextureDimension value)
  System.Boolean get_isNativeTexture()
  System.Boolean get_isReadable()
  UnityEngine.TextureWrapMode get_wrapMode()
  System.Void set_wrapMode(UnityEngine.TextureWrapMode value)
  UnityEngine.TextureWrapMode get_wrapModeU()
  System.Void set_wrapModeU(UnityEngine.TextureWrapMode value)
  UnityEngine.TextureWrapMode get_wrapModeV()
  System.Void set_wrapModeV(UnityEngine.TextureWrapMode value)
  UnityEngine.TextureWrapMode get_wrapModeW()
  System.Void set_wrapModeW(UnityEngine.TextureWrapMode value)
  UnityEngine.FilterMode get_filterMode()
  System.Void set_filterMode(UnityEngine.FilterMode value)
  System.Int32 get_anisoLevel()
  System.Void set_anisoLevel(System.Int32 value)
  System.Single get_mipMapBias()
  System.Void set_mipMapBias(System.Single value)
  UnityEngine.Vector2 get_texelSize()
  System.Int32 get_textureGroup()
  System.IntPtr GetNativeTexturePtr()
  System.Int32 GetNativeTextureID()
  System.UInt32 get_updateCount()
  System.Void IncrementUpdateCount()
  System.Int32 Internal_GetActiveTextureColorSpace()
  UnityEngine.ColorSpace get_activeTextureColorSpace()
  UnityEngine.TextureColorSpace Internal_GetStoredColorSpace()
  System.Boolean get_isDataSRGB()
  System.Void DumpStreamingTextureInfo()
  System.UInt64 get_totalTextureMemory()
  System.UInt64 get_desiredTextureMemory()
  System.UInt64 get_targetTextureMemory()
  System.UInt64 get_currentTextureMemory()
  System.UInt64 get_nonStreamingTextureMemory()
  System.UInt64 get_streamingMipmapUploadCount()
  System.UInt64 get_streamingRendererCount()
  System.UInt64 get_streamingTextureCount()
  System.UInt64 get_nonStreamingTextureCount()
  System.UInt64 get_streamingTexturePendingLoadCount()
  System.UInt64 get_streamingTextureLoadingCount()
  System.Void SetStreamingTextureMaterialDebugProperties()
  System.Boolean get_streamingTextureForceLoadAll()
  System.Void set_streamingTextureForceLoadAll(System.Boolean value)
  System.Boolean get_streamingTextureDiscardUnusedMips()
  System.Void set_streamingTextureDiscardUnusedMips(System.Boolean value)
  System.Boolean get_allowThreadedTextureCreation()
  System.Void set_allowThreadedTextureCreation(System.Boolean value)
  System.UInt64 GetPixelDataSize(System.Int32 mipLevel, System.Int32 element)
  System.UInt64 GetPixelDataOffset(System.Int32 mipLevel, System.Int32 element)
  UnityEngine.TextureColorSpace GetTextureColorSpace(System.Boolean linear)
  UnityEngine.TextureColorSpace GetTextureColorSpace(UnityEngine.Experimental.Rendering.GraphicsFormat format)
  System.Boolean ValidateFormat(UnityEngine.RenderTextureFormat format)
  System.Boolean ValidateFormat(UnityEngine.TextureFormat format)
  System.Boolean ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage)
  UnityEngine.UnityException CreateNonReadableException(UnityEngine.Texture t)
  UnityEngine.UnityException CreateNativeArrayLengthOverflowException()
  System.Void .cctor()
  System.Void get_texelSize_Injected(UnityEngine.Vector2& ret)
END_CLASS

CLASS: UnityEngine.Texture2D
TYPE:  class
TOKEN: 0x2000126
EXTENDS: Texture
FIELDS:
  private   static  System.Int32                    streamingMipmapsPriorityMin  // 0x0
  private   static  System.Int32                    streamingMipmapsPriorityMax  // 0x0
METHODS:
  UnityEngine.TextureFormat get_format()
  System.Boolean get_ignoreMipmapLimit()
  System.Void set_ignoreMipmapLimit(System.Boolean value)
  UnityEngine.Texture2D get_whiteTexture()
  UnityEngine.Texture2D get_blackTexture()
  UnityEngine.Texture2D get_redTexture()
  UnityEngine.Texture2D get_blueTexture()
  UnityEngine.Texture2D get_grayTexture()
  UnityEngine.Texture2D get_linearGrayTexture()
  UnityEngine.Texture2D get_normalTexture()
  System.Void Compress(System.Boolean highQuality)
  System.Boolean Internal_CreateImpl(UnityEngine.Texture2D mono, System.Int32 w, System.Int32 h, System.Int32 mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, System.IntPtr nativeTex)
  System.Void Internal_Create(UnityEngine.Texture2D mono, System.Int32 w, System.Int32 h, System.Int32 mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, System.IntPtr nativeTex)
  System.Boolean get_isReadable()
  System.Boolean get_vtOnly()
  System.Void ApplyImpl(System.Boolean updateMipmaps, System.Boolean makeNoLongerReadable)
  System.Boolean ReinitializeImpl(System.Int32 width, System.Int32 height)
  System.Void SetPixelImpl(System.Int32 image, System.Int32 mip, System.Int32 x, System.Int32 y, UnityEngine.Color color)
  UnityEngine.Color GetPixelImpl(System.Int32 image, System.Int32 mip, System.Int32 x, System.Int32 y)
  UnityEngine.Color GetPixelBilinearImpl(System.Int32 image, System.Int32 mip, System.Single u, System.Single v)
  System.Boolean ReinitializeWithFormatImpl(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Boolean hasMipMap)
  System.Void ReadPixelsImpl(UnityEngine.Rect source, System.Int32 destX, System.Int32 destY, System.Boolean recalculateMipMaps)
  System.Void SetPixelsImpl(System.Int32 x, System.Int32 y, System.Int32 w, System.Int32 h, UnityEngine.Color[] pixel, System.Int32 miplevel, System.Int32 frame)
  System.Boolean LoadRawTextureDataImpl(System.IntPtr data, System.UInt64 size)
  System.Boolean LoadRawTextureDataImplArray(System.Byte[] data)
  System.Boolean SetPixelDataImplArray(System.Array data, System.Int32 mipLevel, System.Int32 elementSize, System.Int32 dataArraySize, System.Int32 sourceDataStartIndex)
  System.Boolean SetPixelDataImpl(System.IntPtr data, System.Int32 mipLevel, System.Int32 elementSize, System.Int32 dataArraySize, System.Int32 sourceDataStartIndex)
  System.IntPtr GetWritableImageData(System.Int32 frame)
  System.UInt64 GetRawImageDataSize()
  System.Void GenerateAtlasImpl(UnityEngine.Vector2[] sizes, System.Int32 padding, System.Int32 atlasSize, UnityEngine.Rect[] rect)
  System.Boolean get_isPreProcessed()
  System.Boolean get_streamingMipmaps()
  System.Int32 get_streamingMipmapsPriority()
  System.Int32 get_requestedMipmapLevel()
  System.Void set_requestedMipmapLevel(System.Int32 value)
  System.Int32 get_minimumMipmapLevel()
  System.Void set_minimumMipmapLevel(System.Int32 value)
  System.Boolean get_loadAllMips()
  System.Void set_loadAllMips(System.Boolean value)
  System.Int32 get_calculatedMipmapLevel()
  System.Int32 get_desiredMipmapLevel()
  System.Int32 get_loadingMipmapLevel()
  System.Int32 get_loadedMipmapLevel()
  System.Void ClearRequestedMipmapLevel()
  System.Boolean IsRequestedMipmapLevelLoaded()
  System.Void ClearMinimumMipmapLevel()
  System.Void UpdateExternalTexture(System.IntPtr nativeTex)
  System.Void SetAllPixels32(UnityEngine.Color32[] colors, System.Int32 miplevel)
  System.Void SetBlockOfPixels32(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight, UnityEngine.Color32[] colors, System.Int32 miplevel)
  System.Byte[] GetRawTextureData()
  UnityEngine.Color[] GetPixels(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight, System.Int32 miplevel)
  UnityEngine.Color[] GetPixels(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight)
  UnityEngine.Color32[] GetPixels32(System.Int32 miplevel)
  UnityEngine.Color32[] GetPixels32()
  UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[] textures, System.Int32 padding, System.Int32 maximumAtlasSize, System.Boolean makeNoLongerReadable)
  UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[] textures, System.Int32 padding, System.Int32 maximumAtlasSize)
  UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[] textures, System.Int32 padding)
  System.Boolean ValidateFormat(UnityEngine.TextureFormat format, System.Int32 width, System.Int32 height)
  System.Boolean ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 width, System.Int32 height)
  System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, System.Int32 mipCount, System.IntPtr nativeTex)
  System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
  System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
  System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 mipCount, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
  System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat textureFormat, System.Int32 mipCount, System.Boolean linear, System.IntPtr nativeTex)
  System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat textureFormat, System.Int32 mipCount, System.Boolean linear)
  System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat textureFormat, System.Boolean mipChain, System.Boolean linear)
  System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat textureFormat, System.Boolean mipChain)
  System.Void .ctor(System.Int32 width, System.Int32 height)
  UnityEngine.Texture2D CreateExternalTexture(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat format, System.Boolean mipChain, System.Boolean linear, System.IntPtr nativeTex)
  System.Void SetPixel(System.Int32 x, System.Int32 y, UnityEngine.Color color)
  System.Void SetPixel(System.Int32 x, System.Int32 y, UnityEngine.Color color, System.Int32 mipLevel)
  System.Void SetPixels(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight, UnityEngine.Color[] colors, System.Int32 miplevel)
  System.Void SetPixels(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight, UnityEngine.Color[] colors)
  System.Void SetPixels(UnityEngine.Color[] colors, System.Int32 miplevel)
  System.Void SetPixels(UnityEngine.Color[] colors)
  UnityEngine.Color GetPixel(System.Int32 x, System.Int32 y)
  UnityEngine.Color GetPixel(System.Int32 x, System.Int32 y, System.Int32 mipLevel)
  UnityEngine.Color GetPixelBilinear(System.Single u, System.Single v)
  UnityEngine.Color GetPixelBilinear(System.Single u, System.Single v, System.Int32 mipLevel)
  System.Void LoadRawTextureData(System.IntPtr data, System.Int32 size)
  System.Void LoadRawTextureData(System.Byte[] data)
  System.Void LoadRawTextureData(Unity.Collections.NativeArray<T> data)
  System.Void SetPixelData(T[] data, System.Int32 mipLevel, System.Int32 sourceDataStartIndex)
  System.Void SetPixelData(Unity.Collections.NativeArray<T> data, System.Int32 mipLevel, System.Int32 sourceDataStartIndex)
  Unity.Collections.NativeArray<T> GetPixelData(System.Int32 mipLevel)
  Unity.Collections.NativeArray<T> GetRawTextureData()
  System.Void Apply(System.Boolean updateMipmaps, System.Boolean makeNoLongerReadable)
  System.Void Apply(System.Boolean updateMipmaps)
  System.Void Apply()
  System.Boolean Reinitialize(System.Int32 width, System.Int32 height)
  System.Boolean Reinitialize(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat format, System.Boolean hasMipMap)
  System.Boolean Reinitialize(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Boolean hasMipMap)
  System.Boolean Resize(System.Int32 width, System.Int32 height)
  System.Boolean Resize(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat format, System.Boolean hasMipMap)
  System.Boolean Resize(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Boolean hasMipMap)
  System.Void ReadPixels(UnityEngine.Rect source, System.Int32 destX, System.Int32 destY, System.Boolean recalculateMipMaps)
  System.Void ReadPixels(UnityEngine.Rect source, System.Int32 destX, System.Int32 destY)
  System.Boolean GenerateAtlas(UnityEngine.Vector2[] sizes, System.Int32 padding, System.Int32 atlasSize, System.Collections.Generic.List<UnityEngine.Rect> results)
  System.Void SetPixels32(UnityEngine.Color32[] colors, System.Int32 miplevel)
  System.Void SetPixels32(UnityEngine.Color32[] colors)
  System.Void SetPixels32(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight, UnityEngine.Color32[] colors, System.Int32 miplevel)
  System.Void SetPixels32(System.Int32 x, System.Int32 y, System.Int32 blockWidth, System.Int32 blockHeight, UnityEngine.Color32[] colors)
  UnityEngine.Color[] GetPixels(System.Int32 miplevel)
  UnityEngine.Color[] GetPixels()
  System.Void SetPixelImpl_Injected(System.Int32 image, System.Int32 mip, System.Int32 x, System.Int32 y, UnityEngine.Color& color)
  System.Void GetPixelImpl_Injected(System.Int32 image, System.Int32 mip, System.Int32 x, System.Int32 y, UnityEngine.Color& ret)
  System.Void GetPixelBilinearImpl_Injected(System.Int32 image, System.Int32 mip, System.Single u, System.Single v, UnityEngine.Color& ret)
  System.Void ReadPixelsImpl_Injected(UnityEngine.Rect& source, System.Int32 destX, System.Int32 destY, System.Boolean recalculateMipMaps)
END_CLASS

CLASS: UnityEngine.Cubemap
TYPE:  class
TOKEN: 0x2000128
EXTENDS: Texture
FIELDS:
METHODS:
  System.Boolean Internal_CreateImpl(UnityEngine.Cubemap mono, System.Int32 ext, System.Int32 mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, System.IntPtr nativeTex)
  System.Void Internal_Create(UnityEngine.Cubemap mono, System.Int32 ext, System.Int32 mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, System.IntPtr nativeTex)
  System.Void ApplyImpl(System.Boolean updateMipmaps, System.Boolean makeNoLongerReadable)
  System.Boolean get_isReadable()
  System.Void SetPixelImpl(System.Int32 image, System.Int32 mip, System.Int32 x, System.Int32 y, UnityEngine.Color color)
  System.Boolean ValidateFormat(UnityEngine.TextureFormat format, System.Int32 width)
  System.Boolean ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 width)
  System.Void .ctor(System.Int32 width, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
  System.Void .ctor(System.Int32 width, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
  System.Void .ctor(System.Int32 width, UnityEngine.TextureFormat format, System.Int32 mipCount)
  System.Void .ctor(System.Int32 width, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, System.Int32 mipCount)
  System.Void .ctor(System.Int32 width, UnityEngine.TextureFormat textureFormat, System.Int32 mipCount, System.IntPtr nativeTex)
  System.Void .ctor(System.Int32 width, UnityEngine.TextureFormat textureFormat, System.Boolean mipChain, System.IntPtr nativeTex)
  System.Void .ctor(System.Int32 width, UnityEngine.TextureFormat textureFormat, System.Boolean mipChain)
  System.Void SetPixel(UnityEngine.CubemapFace face, System.Int32 x, System.Int32 y, UnityEngine.Color color)
  System.Void SetPixel(UnityEngine.CubemapFace face, System.Int32 x, System.Int32 y, UnityEngine.Color color, System.Int32 mip)
  System.Void Apply(System.Boolean updateMipmaps, System.Boolean makeNoLongerReadable)
  System.Void Apply()
  System.Void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
  System.Void SetPixelImpl_Injected(System.Int32 image, System.Int32 mip, System.Int32 x, System.Int32 y, UnityEngine.Color& color)
END_CLASS

CLASS: UnityEngine.Texture3D
TYPE:  class
TOKEN: 0x2000129
EXTENDS: Texture
FIELDS:
METHODS:
  System.Int32 get_depth()
  System.Boolean get_isReadable()
  System.Void SetPixelImpl(System.Int32 mip, System.Int32 x, System.Int32 y, System.Int32 z, UnityEngine.Color color)
  UnityEngine.Texture3D get_blackTexture3D()
  System.Boolean Internal_CreateImpl(UnityEngine.Texture3D mono, System.Int32 w, System.Int32 h, System.Int32 d, System.Int32 mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, System.IntPtr nativeTex)
  System.Void Internal_Create(UnityEngine.Texture3D mono, System.Int32 w, System.Int32 h, System.Int32 d, System.Int32 mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, System.IntPtr nativeTex)
  System.Void ApplyImpl(System.Boolean updateMipmaps, System.Boolean makeNoLongerReadable)
  System.Void SetPixels(UnityEngine.Color[] colors, System.Int32 miplevel)
  System.Void SetPixels(UnityEngine.Color[] colors)
  System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
  System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
  System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, System.Int32 mipCount)
  System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.TextureFormat textureFormat, System.Int32 mipCount)
  System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.TextureFormat textureFormat, System.Int32 mipCount, System.IntPtr nativeTex)
  System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.TextureFormat textureFormat, System.Boolean mipChain)
  System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.TextureFormat textureFormat, System.Boolean mipChain, System.IntPtr nativeTex)
  System.Void Apply(System.Boolean updateMipmaps, System.Boolean makeNoLongerReadable)
  System.Void Apply(System.Boolean updateMipmaps)
  System.Void Apply()
  System.Void SetPixel(System.Int32 x, System.Int32 y, System.Int32 z, UnityEngine.Color color)
  System.Void SetPixel(System.Int32 x, System.Int32 y, System.Int32 z, UnityEngine.Color color, System.Int32 mipLevel)
  System.Void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
  System.Void SetPixelImpl_Injected(System.Int32 mip, System.Int32 x, System.Int32 y, System.Int32 z, UnityEngine.Color& color)
END_CLASS

CLASS: UnityEngine.Texture2DArray
TYPE:  class
TOKEN: 0x200012A
EXTENDS: Texture
FIELDS:
METHODS:
  System.Int32 get_allSlices()
  System.Boolean get_isReadable()
  System.Boolean Internal_CreateImpl(UnityEngine.Texture2DArray mono, System.Int32 w, System.Int32 h, System.Int32 d, System.Int32 mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
  System.Void Internal_Create(UnityEngine.Texture2DArray mono, System.Int32 w, System.Int32 h, System.Int32 d, System.Int32 mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
  System.Void ApplyImpl(System.Boolean updateMipmaps, System.Boolean makeNoLongerReadable)
  System.Boolean ValidateFormat(UnityEngine.TextureFormat format, System.Int32 width, System.Int32 height)
  System.Boolean ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 width, System.Int32 height)
  System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
  System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
  System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, System.Int32 mipCount)
  System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.TextureFormat textureFormat, System.Int32 mipCount, System.Boolean linear)
  System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.TextureFormat textureFormat, System.Boolean mipChain, System.Boolean linear)
  System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.TextureFormat textureFormat, System.Boolean mipChain)
  System.Void Apply(System.Boolean updateMipmaps, System.Boolean makeNoLongerReadable)
  System.Void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
END_CLASS

CLASS: UnityEngine.CubemapArray
TYPE:  class
TOKEN: 0x200012B
EXTENDS: Texture
FIELDS:
METHODS:
  System.Boolean get_isReadable()
  System.Boolean Internal_CreateImpl(UnityEngine.CubemapArray mono, System.Int32 ext, System.Int32 count, System.Int32 mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
  System.Void Internal_Create(UnityEngine.CubemapArray mono, System.Int32 ext, System.Int32 count, System.Int32 mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
  System.Void ApplyImpl(System.Boolean updateMipmaps, System.Boolean makeNoLongerReadable)
  System.Void SetPixels(UnityEngine.Color[] colors, UnityEngine.CubemapFace face, System.Int32 arrayElement, System.Int32 miplevel)
  System.Void SetPixels(UnityEngine.Color[] colors, UnityEngine.CubemapFace face, System.Int32 arrayElement)
  System.Void .ctor(System.Int32 width, System.Int32 cubemapCount, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
  System.Void .ctor(System.Int32 width, System.Int32 cubemapCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
  System.Void .ctor(System.Int32 width, System.Int32 cubemapCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, System.Int32 mipCount)
  System.Void .ctor(System.Int32 width, System.Int32 cubemapCount, UnityEngine.TextureFormat textureFormat, System.Int32 mipCount, System.Boolean linear)
  System.Void .ctor(System.Int32 width, System.Int32 cubemapCount, UnityEngine.TextureFormat textureFormat, System.Boolean mipChain, System.Boolean linear)
  System.Void .ctor(System.Int32 width, System.Int32 cubemapCount, UnityEngine.TextureFormat textureFormat, System.Boolean mipChain)
  System.Void Apply(System.Boolean updateMipmaps, System.Boolean makeNoLongerReadable)
  System.Void Apply()
  System.Void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
END_CLASS

CLASS: UnityEngine.RenderTexture
TYPE:  class
TOKEN: 0x200012C
EXTENDS: Texture
FIELDS:
METHODS:
  System.Int32 get_width()
  System.Void set_width(System.Int32 value)
  System.Int32 get_height()
  System.Void set_height(System.Int32 value)
  UnityEngine.Rendering.TextureDimension get_dimension()
  System.Void set_dimension(UnityEngine.Rendering.TextureDimension value)
  UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat()
  System.Void set_graphicsFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value)
  System.Boolean get_useMipMap()
  System.Void set_useMipMap(System.Boolean value)
  System.Boolean get_sRGB()
  System.Void set_memorylessMode(UnityEngine.RenderTextureMemoryless value)
  UnityEngine.RenderTextureFormat get_format()
  System.Void set_stencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value)
  UnityEngine.Experimental.Rendering.GraphicsFormat get_depthStencilFormat()
  System.Void set_depthStencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value)
  System.Boolean get_autoGenerateMips()
  System.Void set_autoGenerateMips(System.Boolean value)
  System.Int32 get_volumeDepth()
  System.Void set_volumeDepth(System.Int32 value)
  System.Void set_antiAliasing(System.Int32 value)
  System.Void set_bindTextureMS(System.Boolean value)
  System.Boolean get_enableRandomWrite()
  System.Void set_enableRandomWrite(System.Boolean value)
  System.Void set_useDynamicScale(System.Boolean value)
  UnityEngine.RenderTexture GetActive()
  System.Void SetActive(UnityEngine.RenderTexture rt)
  UnityEngine.RenderTexture get_active()
  System.Void set_active(UnityEngine.RenderTexture value)
  UnityEngine.RenderBuffer GetColorBuffer()
  UnityEngine.RenderBuffer GetDepthBuffer()
  System.UInt32 GetStencilTexID()
  System.Void SetMipMapCount(System.Int32 count)
  UnityEngine.RenderBuffer get_colorBuffer()
  UnityEngine.RenderBuffer get_depthBuffer()
  System.Void DiscardContents(System.Boolean discardColor, System.Boolean discardDepth)
  System.Void DiscardContents()
  System.Boolean Create()
  System.Void Release()
  System.Boolean IsCreated()
  System.Void GenerateMips()
  System.Void SetSRGBReadWrite(System.Boolean srgb)
  System.Void Internal_Create(UnityEngine.RenderTexture rt)
  System.Void SetRenderTextureDescriptor(UnityEngine.RenderTextureDescriptor desc)
  UnityEngine.RenderTextureDescriptor GetDescriptor()
  UnityEngine.RenderTexture GetTemporary_Internal(UnityEngine.RenderTextureDescriptor desc)
  System.Void ReleaseTemporary(UnityEngine.RenderTexture temp)
  System.Int32 get_depth()
  System.Void .ctor()
  System.Void .ctor(UnityEngine.RenderTextureDescriptor desc)
  System.Void .ctor(UnityEngine.RenderTexture textureToCopy)
  System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.DefaultFormat format)
  System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.GraphicsFormat format)
  System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Int32 mipCount)
  System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, System.Int32 mipCount)
  System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat)
  System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite)
  System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.RenderTextureFormat format)
  System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth)
  System.Void .ctor(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.RenderTextureFormat format, System.Int32 mipCount)
  System.Void Initialize(System.Int32 width, System.Int32 height, System.Int32 depth, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, System.Int32 mipCount)
  UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(System.Int32 depthBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat)
  UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(System.Int32 depthBits, UnityEngine.RenderTextureFormat format)
  UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(System.Int32 depthBits, UnityEngine.Experimental.Rendering.DefaultFormat format)
  UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(System.Int32 depthBits, System.Boolean requestedShadowMap)
  UnityEngine.RenderTextureDescriptor get_descriptor()
  System.Void set_descriptor(UnityEngine.RenderTextureDescriptor value)
  System.Void ValidateRenderTextureDesc(UnityEngine.RenderTextureDescriptor desc)
  UnityEngine.Experimental.Rendering.GraphicsFormat GetDefaultColorFormat(UnityEngine.Experimental.Rendering.DefaultFormat format)
  UnityEngine.Experimental.Rendering.GraphicsFormat GetDefaultDepthStencilFormat(UnityEngine.Experimental.Rendering.DefaultFormat format, System.Int32 depth)
  UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(UnityEngine.RenderTextureFormat renderTextureFormat, UnityEngine.RenderTextureReadWrite readWrite)
  UnityEngine.RenderTexture GetTemporary(UnityEngine.RenderTextureDescriptor desc)
  UnityEngine.RenderTexture GetTemporaryImpl(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, System.Int32 antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage, System.Boolean useDynamicScale)
  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, System.Int32 antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage, System.Boolean useDynamicScale)
  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, System.Int32 antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage)
  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, System.Int32 antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode)
  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, System.Int32 antiAliasing)
  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite)
  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer, UnityEngine.RenderTextureFormat format)
  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height, System.Int32 depthBuffer)
  UnityEngine.RenderTexture GetTemporary(System.Int32 width, System.Int32 height)
  System.Void GetColorBuffer_Injected(UnityEngine.RenderBuffer& ret)
  System.Void GetDepthBuffer_Injected(UnityEngine.RenderBuffer& ret)
  System.Void SetRenderTextureDescriptor_Injected(UnityEngine.RenderTextureDescriptor& desc)
  System.Void GetDescriptor_Injected(UnityEngine.RenderTextureDescriptor& ret)
  UnityEngine.RenderTexture GetTemporary_Internal_Injected(UnityEngine.RenderTextureDescriptor& desc)
END_CLASS

CLASS: UnityEngine.CustomRenderTexture
TYPE:  class
TOKEN: 0x200012D
EXTENDS: RenderTexture
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.RenderTextureDescriptor
TYPE:  struct
TOKEN: 0x200012E
FIELDS:
  private           System.Int32                    <width>k__BackingField  // 0x10
  private           System.Int32                    <height>k__BackingField  // 0x14
  private           System.Int32                    <msaaSamples>k__BackingField  // 0x18
  private           System.Int32                    <volumeDepth>k__BackingField  // 0x1C
  private           System.Int32                    <mipCount>k__BackingField  // 0x20
  private           UnityEngine.Experimental.Rendering.GraphicsFormat_graphicsFormat  // 0x24
  private           UnityEngine.Experimental.Rendering.GraphicsFormat<stencilFormat>k__BackingField  // 0x28
  private           UnityEngine.Experimental.Rendering.GraphicsFormat<depthStencilFormat>k__BackingField  // 0x2C
  private           UnityEngine.Rendering.TextureDimension<dimension>k__BackingField  // 0x30
  private           UnityEngine.Rendering.ShadowSamplingMode<shadowSamplingMode>k__BackingField  // 0x34
  private           UnityEngine.VRTextureUsage      <vrUsage>k__BackingField  // 0x38
  private           UnityEngine.RenderTextureCreationFlags_flags  // 0x3C
  private           UnityEngine.RenderTextureMemoryless<memoryless>k__BackingField  // 0x40
METHODS:
  System.Int32 get_width()
  System.Void set_width(System.Int32 value)
  System.Int32 get_height()
  System.Void set_height(System.Int32 value)
  System.Int32 get_msaaSamples()
  System.Void set_msaaSamples(System.Int32 value)
  System.Int32 get_volumeDepth()
  System.Void set_volumeDepth(System.Int32 value)
  System.Void set_mipCount(System.Int32 value)
  UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat()
  System.Void set_graphicsFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value)
  UnityEngine.Experimental.Rendering.GraphicsFormat get_depthStencilFormat()
  System.Void set_depthStencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value)
  UnityEngine.RenderTextureFormat get_colorFormat()
  System.Void set_colorFormat(UnityEngine.RenderTextureFormat value)
  System.Boolean get_sRGB()
  System.Void set_sRGB(System.Boolean value)
  System.Int32 get_depthBufferBits()
  System.Void set_depthBufferBits(System.Int32 value)
  UnityEngine.Rendering.TextureDimension get_dimension()
  System.Void set_dimension(UnityEngine.Rendering.TextureDimension value)
  UnityEngine.Rendering.ShadowSamplingMode get_shadowSamplingMode()
  System.Void set_shadowSamplingMode(UnityEngine.Rendering.ShadowSamplingMode value)
  System.Void set_vrUsage(UnityEngine.VRTextureUsage value)
  System.Void set_memoryless(UnityEngine.RenderTextureMemoryless value)
  System.Void .ctor(System.Int32 width, System.Int32 height)
  System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.RenderTextureFormat colorFormat)
  System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.RenderTextureFormat colorFormat, System.Int32 depthBufferBits)
  System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, System.Int32 depthBufferBits)
  System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.RenderTextureFormat colorFormat, System.Int32 depthBufferBits, System.Int32 mipCount)
  System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.RenderTextureFormat colorFormat, System.Int32 depthBufferBits, System.Int32 mipCount, UnityEngine.RenderTextureReadWrite readWrite)
  System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, System.Int32 depthBufferBits, System.Int32 mipCount)
  System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat)
  System.Void .ctor(System.Int32 width, System.Int32 height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, System.Int32 mipCount)
  System.Void SetOrClearRenderTextureCreationFlag(System.Boolean value, UnityEngine.RenderTextureCreationFlags flag)
  System.Boolean get_useMipMap()
  System.Void set_useMipMap(System.Boolean value)
  System.Boolean get_autoGenerateMips()
  System.Void set_autoGenerateMips(System.Boolean value)
  System.Boolean get_enableRandomWrite()
  System.Void set_enableRandomWrite(System.Boolean value)
  System.Void set_bindMS(System.Boolean value)
  System.Void set_createdFromScript(System.Boolean value)
  System.Void set_useDynamicScale(System.Boolean value)
END_CLASS

CLASS: UnityEngine.Hash128
TYPE:  struct
TOKEN: 0x200012F
FIELDS:
  private           System.UInt64                   u64_0  // 0x10
  private           System.UInt64                   u64_1  // 0x18
  private   static  System.UInt64                   kConst  // 0x0
METHODS:
  System.Void .ctor(System.UInt64 u64_0, System.UInt64 u64_1)
  System.Int32 CompareTo(UnityEngine.Hash128 rhs)
  System.String ToString()
  System.String Hash128ToStringImpl(UnityEngine.Hash128 hash)
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(UnityEngine.Hash128 obj)
  System.Int32 GetHashCode()
  System.Int32 CompareTo(System.Object obj)
  System.Boolean op_Equality(UnityEngine.Hash128 hash1, UnityEngine.Hash128 hash2)
  System.Boolean op_LessThan(UnityEngine.Hash128 x, UnityEngine.Hash128 y)
  System.Boolean op_GreaterThan(UnityEngine.Hash128 x, UnityEngine.Hash128 y)
  System.String Hash128ToStringImpl_Injected(UnityEngine.Hash128& hash)
END_CLASS

CLASS: UnityEngine.HashUtilities
TYPE:  class
TOKEN: 0x2000130
FIELDS:
METHODS:
  System.Void AppendHash(UnityEngine.Hash128& inHash, UnityEngine.Hash128& outHash)
  System.Void ComputeHash128(T& value, UnityEngine.Hash128& hash)
END_CLASS

CLASS: UnityEngine.HashUnsafeUtilities
TYPE:  class
TOKEN: 0x2000131
FIELDS:
METHODS:
  System.Void ComputeHash128(System.Void* data, System.UInt64 dataSize, System.UInt64* hash1, System.UInt64* hash2)
  System.Void ComputeHash128(System.Void* data, System.UInt64 dataSize, UnityEngine.Hash128* hash)
END_CLASS

CLASS: UnityEngine.SpookyHash
TYPE:  class
TOKEN: 0x2000132
FIELDS:
  private   static readonly System.Boolean                  AllowUnalignedRead  // 0x0
METHODS:
  System.Boolean AttemptDetectAllowUnalignedRead()
  System.Void Hash(System.Void* message, System.UInt64 length, System.UInt64* hash1, System.UInt64* hash2)
  System.Void End(System.UInt64* data, System.UInt64& h0, System.UInt64& h1, System.UInt64& h2, System.UInt64& h3, System.UInt64& h4, System.UInt64& h5, System.UInt64& h6, System.UInt64& h7, System.UInt64& h8, System.UInt64& h9, System.UInt64& h10, System.UInt64& h11)
  System.Void EndPartial(System.UInt64& h0, System.UInt64& h1, System.UInt64& h2, System.UInt64& h3, System.UInt64& h4, System.UInt64& h5, System.UInt64& h6, System.UInt64& h7, System.UInt64& h8, System.UInt64& h9, System.UInt64& h10, System.UInt64& h11)
  System.Void Rot64(System.UInt64& x, System.Int32 k)
  System.Void Short(System.Void* message, System.UInt64 length, System.UInt64* hash1, System.UInt64* hash2)
  System.Void ShortMix(System.UInt64& h0, System.UInt64& h1, System.UInt64& h2, System.UInt64& h3)
  System.Void ShortEnd(System.UInt64& h0, System.UInt64& h1, System.UInt64& h2, System.UInt64& h3)
  System.Void Mix(System.UInt64* data, System.UInt64& s0, System.UInt64& s1, System.UInt64& s2, System.UInt64& s3, System.UInt64& s4, System.UInt64& s5, System.UInt64& s6, System.UInt64& s7, System.UInt64& s8, System.UInt64& s9, System.UInt64& s10, System.UInt64& s11)
  System.Void memset(System.Void* dst, System.Int32 value, System.UInt64 numberOfBytes)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.StringHash
TYPE:  struct
TOKEN: 0x2000134
FIELDS:
  public            System.Int64                    hashValue  // 0x10
  public            System.String                   stringValue  // 0x18
METHODS:
  System.String ToString()
  System.Int32 GetHashCode()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(UnityEngine.StringHash other)
END_CLASS

CLASS: UnityEngine.CursorMode
TYPE:  struct
TOKEN: 0x2000135
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.CursorMode          Auto  // 0x0
  public    static  UnityEngine.CursorMode          ForceSoftware  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.CursorLockMode
TYPE:  struct
TOKEN: 0x2000136
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.CursorLockMode      None  // 0x0
  public    static  UnityEngine.CursorLockMode      Locked  // 0x0
  public    static  UnityEngine.CursorLockMode      Confined  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Cursor
TYPE:  class
TOKEN: 0x2000137
FIELDS:
METHODS:
  System.Void SetCursor(UnityEngine.Texture2D texture, UnityEngine.CursorMode cursorMode)
  System.Void SetCursor(UnityEngine.Texture2D texture, UnityEngine.Vector2 hotspot, UnityEngine.CursorMode cursorMode)
  System.Boolean get_visible()
  System.Void set_visible(System.Boolean value)
  UnityEngine.CursorLockMode get_lockState()
  System.Void set_lockState(UnityEngine.CursorLockMode value)
  System.Void .ctor()
  System.Void SetCursor_Injected(UnityEngine.Texture2D texture, UnityEngine.Vector2& hotspot, UnityEngine.CursorMode cursorMode)
END_CLASS

CLASS: UnityEngine.KeyCode
TYPE:  struct
TOKEN: 0x2000138
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.KeyCode             None  // 0x0
  public    static  UnityEngine.KeyCode             Backspace  // 0x0
  public    static  UnityEngine.KeyCode             Delete  // 0x0
  public    static  UnityEngine.KeyCode             Tab  // 0x0
  public    static  UnityEngine.KeyCode             Clear  // 0x0
  public    static  UnityEngine.KeyCode             Return  // 0x0
  public    static  UnityEngine.KeyCode             Pause  // 0x0
  public    static  UnityEngine.KeyCode             Escape  // 0x0
  public    static  UnityEngine.KeyCode             Space  // 0x0
  public    static  UnityEngine.KeyCode             Keypad0  // 0x0
  public    static  UnityEngine.KeyCode             Keypad1  // 0x0
  public    static  UnityEngine.KeyCode             Keypad2  // 0x0
  public    static  UnityEngine.KeyCode             Keypad3  // 0x0
  public    static  UnityEngine.KeyCode             Keypad4  // 0x0
  public    static  UnityEngine.KeyCode             Keypad5  // 0x0
  public    static  UnityEngine.KeyCode             Keypad6  // 0x0
  public    static  UnityEngine.KeyCode             Keypad7  // 0x0
  public    static  UnityEngine.KeyCode             Keypad8  // 0x0
  public    static  UnityEngine.KeyCode             Keypad9  // 0x0
  public    static  UnityEngine.KeyCode             KeypadPeriod  // 0x0
  public    static  UnityEngine.KeyCode             KeypadDivide  // 0x0
  public    static  UnityEngine.KeyCode             KeypadMultiply  // 0x0
  public    static  UnityEngine.KeyCode             KeypadMinus  // 0x0
  public    static  UnityEngine.KeyCode             KeypadPlus  // 0x0
  public    static  UnityEngine.KeyCode             KeypadEnter  // 0x0
  public    static  UnityEngine.KeyCode             KeypadEquals  // 0x0
  public    static  UnityEngine.KeyCode             UpArrow  // 0x0
  public    static  UnityEngine.KeyCode             DownArrow  // 0x0
  public    static  UnityEngine.KeyCode             RightArrow  // 0x0
  public    static  UnityEngine.KeyCode             LeftArrow  // 0x0
  public    static  UnityEngine.KeyCode             Insert  // 0x0
  public    static  UnityEngine.KeyCode             Home  // 0x0
  public    static  UnityEngine.KeyCode             End  // 0x0
  public    static  UnityEngine.KeyCode             PageUp  // 0x0
  public    static  UnityEngine.KeyCode             PageDown  // 0x0
  public    static  UnityEngine.KeyCode             F1  // 0x0
  public    static  UnityEngine.KeyCode             F2  // 0x0
  public    static  UnityEngine.KeyCode             F3  // 0x0
  public    static  UnityEngine.KeyCode             F4  // 0x0
  public    static  UnityEngine.KeyCode             F5  // 0x0
  public    static  UnityEngine.KeyCode             F6  // 0x0
  public    static  UnityEngine.KeyCode             F7  // 0x0
  public    static  UnityEngine.KeyCode             F8  // 0x0
  public    static  UnityEngine.KeyCode             F9  // 0x0
  public    static  UnityEngine.KeyCode             F10  // 0x0
  public    static  UnityEngine.KeyCode             F11  // 0x0
  public    static  UnityEngine.KeyCode             F12  // 0x0
  public    static  UnityEngine.KeyCode             F13  // 0x0
  public    static  UnityEngine.KeyCode             F14  // 0x0
  public    static  UnityEngine.KeyCode             F15  // 0x0
  public    static  UnityEngine.KeyCode             Alpha0  // 0x0
  public    static  UnityEngine.KeyCode             Alpha1  // 0x0
  public    static  UnityEngine.KeyCode             Alpha2  // 0x0
  public    static  UnityEngine.KeyCode             Alpha3  // 0x0
  public    static  UnityEngine.KeyCode             Alpha4  // 0x0
  public    static  UnityEngine.KeyCode             Alpha5  // 0x0
  public    static  UnityEngine.KeyCode             Alpha6  // 0x0
  public    static  UnityEngine.KeyCode             Alpha7  // 0x0
  public    static  UnityEngine.KeyCode             Alpha8  // 0x0
  public    static  UnityEngine.KeyCode             Alpha9  // 0x0
  public    static  UnityEngine.KeyCode             Exclaim  // 0x0
  public    static  UnityEngine.KeyCode             DoubleQuote  // 0x0
  public    static  UnityEngine.KeyCode             Hash  // 0x0
  public    static  UnityEngine.KeyCode             Dollar  // 0x0
  public    static  UnityEngine.KeyCode             Percent  // 0x0
  public    static  UnityEngine.KeyCode             Ampersand  // 0x0
  public    static  UnityEngine.KeyCode             Quote  // 0x0
  public    static  UnityEngine.KeyCode             LeftParen  // 0x0
  public    static  UnityEngine.KeyCode             RightParen  // 0x0
  public    static  UnityEngine.KeyCode             Asterisk  // 0x0
  public    static  UnityEngine.KeyCode             Plus  // 0x0
  public    static  UnityEngine.KeyCode             Comma  // 0x0
  public    static  UnityEngine.KeyCode             Minus  // 0x0
  public    static  UnityEngine.KeyCode             Period  // 0x0
  public    static  UnityEngine.KeyCode             Slash  // 0x0
  public    static  UnityEngine.KeyCode             Colon  // 0x0
  public    static  UnityEngine.KeyCode             Semicolon  // 0x0
  public    static  UnityEngine.KeyCode             Less  // 0x0
  public    static  UnityEngine.KeyCode             Equals  // 0x0
  public    static  UnityEngine.KeyCode             Greater  // 0x0
  public    static  UnityEngine.KeyCode             Question  // 0x0
  public    static  UnityEngine.KeyCode             At  // 0x0
  public    static  UnityEngine.KeyCode             LeftBracket  // 0x0
  public    static  UnityEngine.KeyCode             Backslash  // 0x0
  public    static  UnityEngine.KeyCode             RightBracket  // 0x0
  public    static  UnityEngine.KeyCode             Caret  // 0x0
  public    static  UnityEngine.KeyCode             Underscore  // 0x0
  public    static  UnityEngine.KeyCode             BackQuote  // 0x0
  public    static  UnityEngine.KeyCode             A  // 0x0
  public    static  UnityEngine.KeyCode             B  // 0x0
  public    static  UnityEngine.KeyCode             C  // 0x0
  public    static  UnityEngine.KeyCode             D  // 0x0
  public    static  UnityEngine.KeyCode             E  // 0x0
  public    static  UnityEngine.KeyCode             F  // 0x0
  public    static  UnityEngine.KeyCode             G  // 0x0
  public    static  UnityEngine.KeyCode             H  // 0x0
  public    static  UnityEngine.KeyCode             I  // 0x0
  public    static  UnityEngine.KeyCode             J  // 0x0
  public    static  UnityEngine.KeyCode             K  // 0x0
  public    static  UnityEngine.KeyCode             L  // 0x0
  public    static  UnityEngine.KeyCode             M  // 0x0
  public    static  UnityEngine.KeyCode             N  // 0x0
  public    static  UnityEngine.KeyCode             O  // 0x0
  public    static  UnityEngine.KeyCode             P  // 0x0
  public    static  UnityEngine.KeyCode             Q  // 0x0
  public    static  UnityEngine.KeyCode             R  // 0x0
  public    static  UnityEngine.KeyCode             S  // 0x0
  public    static  UnityEngine.KeyCode             T  // 0x0
  public    static  UnityEngine.KeyCode             U  // 0x0
  public    static  UnityEngine.KeyCode             V  // 0x0
  public    static  UnityEngine.KeyCode             W  // 0x0
  public    static  UnityEngine.KeyCode             X  // 0x0
  public    static  UnityEngine.KeyCode             Y  // 0x0
  public    static  UnityEngine.KeyCode             Z  // 0x0
  public    static  UnityEngine.KeyCode             LeftCurlyBracket  // 0x0
  public    static  UnityEngine.KeyCode             Pipe  // 0x0
  public    static  UnityEngine.KeyCode             RightCurlyBracket  // 0x0
  public    static  UnityEngine.KeyCode             Tilde  // 0x0
  public    static  UnityEngine.KeyCode             Numlock  // 0x0
  public    static  UnityEngine.KeyCode             CapsLock  // 0x0
  public    static  UnityEngine.KeyCode             ScrollLock  // 0x0
  public    static  UnityEngine.KeyCode             RightShift  // 0x0
  public    static  UnityEngine.KeyCode             LeftShift  // 0x0
  public    static  UnityEngine.KeyCode             RightControl  // 0x0
  public    static  UnityEngine.KeyCode             LeftControl  // 0x0
  public    static  UnityEngine.KeyCode             RightAlt  // 0x0
  public    static  UnityEngine.KeyCode             LeftAlt  // 0x0
  public    static  UnityEngine.KeyCode             LeftMeta  // 0x0
  public    static  UnityEngine.KeyCode             LeftCommand  // 0x0
  public    static  UnityEngine.KeyCode             LeftApple  // 0x0
  public    static  UnityEngine.KeyCode             LeftWindows  // 0x0
  public    static  UnityEngine.KeyCode             RightMeta  // 0x0
  public    static  UnityEngine.KeyCode             RightCommand  // 0x0
  public    static  UnityEngine.KeyCode             RightApple  // 0x0
  public    static  UnityEngine.KeyCode             RightWindows  // 0x0
  public    static  UnityEngine.KeyCode             AltGr  // 0x0
  public    static  UnityEngine.KeyCode             Help  // 0x0
  public    static  UnityEngine.KeyCode             Print  // 0x0
  public    static  UnityEngine.KeyCode             SysReq  // 0x0
  public    static  UnityEngine.KeyCode             Break  // 0x0
  public    static  UnityEngine.KeyCode             Menu  // 0x0
  public    static  UnityEngine.KeyCode             Mouse0  // 0x0
  public    static  UnityEngine.KeyCode             Mouse1  // 0x0
  public    static  UnityEngine.KeyCode             Mouse2  // 0x0
  public    static  UnityEngine.KeyCode             Mouse3  // 0x0
  public    static  UnityEngine.KeyCode             Mouse4  // 0x0
  public    static  UnityEngine.KeyCode             Mouse5  // 0x0
  public    static  UnityEngine.KeyCode             Mouse6  // 0x0
  public    static  UnityEngine.KeyCode             JoystickButton0  // 0x0
  public    static  UnityEngine.KeyCode             JoystickButton1  // 0x0
  public    static  UnityEngine.KeyCode             JoystickButton2  // 0x0
  public    static  UnityEngine.KeyCode             JoystickButton3  // 0x0
  public    static  UnityEngine.KeyCode             JoystickButton4  // 0x0
  public    static  UnityEngine.KeyCode             JoystickButton5  // 0x0
  public    static  UnityEngine.KeyCode             JoystickButton6  // 0x0
  public    static  UnityEngine.KeyCode             JoystickButton7  // 0x0
  public    static  UnityEngine.KeyCode             JoystickButton8  // 0x0
  public    static  UnityEngine.KeyCode             JoystickButton9  // 0x0
  public    static  UnityEngine.KeyCode             JoystickButton10  // 0x0
  public    static  UnityEngine.KeyCode             JoystickButton11  // 0x0
  public    static  UnityEngine.KeyCode             JoystickButton12  // 0x0
  public    static  UnityEngine.KeyCode             JoystickButton13  // 0x0
  public    static  UnityEngine.KeyCode             JoystickButton14  // 0x0
  public    static  UnityEngine.KeyCode             JoystickButton15  // 0x0
  public    static  UnityEngine.KeyCode             JoystickButton16  // 0x0
  public    static  UnityEngine.KeyCode             JoystickButton17  // 0x0
  public    static  UnityEngine.KeyCode             JoystickButton18  // 0x0
  public    static  UnityEngine.KeyCode             JoystickButton19  // 0x0
  public    static  UnityEngine.KeyCode             Joystick1Button0  // 0x0
  public    static  UnityEngine.KeyCode             Joystick1Button1  // 0x0
  public    static  UnityEngine.KeyCode             Joystick1Button2  // 0x0
  public    static  UnityEngine.KeyCode             Joystick1Button3  // 0x0
  public    static  UnityEngine.KeyCode             Joystick1Button4  // 0x0
  public    static  UnityEngine.KeyCode             Joystick1Button5  // 0x0
  public    static  UnityEngine.KeyCode             Joystick1Button6  // 0x0
  public    static  UnityEngine.KeyCode             Joystick1Button7  // 0x0
  public    static  UnityEngine.KeyCode             Joystick1Button8  // 0x0
  public    static  UnityEngine.KeyCode             Joystick1Button9  // 0x0
  public    static  UnityEngine.KeyCode             Joystick1Button10  // 0x0
  public    static  UnityEngine.KeyCode             Joystick1Button11  // 0x0
  public    static  UnityEngine.KeyCode             Joystick1Button12  // 0x0
  public    static  UnityEngine.KeyCode             Joystick1Button13  // 0x0
  public    static  UnityEngine.KeyCode             Joystick1Button14  // 0x0
  public    static  UnityEngine.KeyCode             Joystick1Button15  // 0x0
  public    static  UnityEngine.KeyCode             Joystick1Button16  // 0x0
  public    static  UnityEngine.KeyCode             Joystick1Button17  // 0x0
  public    static  UnityEngine.KeyCode             Joystick1Button18  // 0x0
  public    static  UnityEngine.KeyCode             Joystick1Button19  // 0x0
  public    static  UnityEngine.KeyCode             Joystick2Button0  // 0x0
  public    static  UnityEngine.KeyCode             Joystick2Button1  // 0x0
  public    static  UnityEngine.KeyCode             Joystick2Button2  // 0x0
  public    static  UnityEngine.KeyCode             Joystick2Button3  // 0x0
  public    static  UnityEngine.KeyCode             Joystick2Button4  // 0x0
  public    static  UnityEngine.KeyCode             Joystick2Button5  // 0x0
  public    static  UnityEngine.KeyCode             Joystick2Button6  // 0x0
  public    static  UnityEngine.KeyCode             Joystick2Button7  // 0x0
  public    static  UnityEngine.KeyCode             Joystick2Button8  // 0x0
  public    static  UnityEngine.KeyCode             Joystick2Button9  // 0x0
  public    static  UnityEngine.KeyCode             Joystick2Button10  // 0x0
  public    static  UnityEngine.KeyCode             Joystick2Button11  // 0x0
  public    static  UnityEngine.KeyCode             Joystick2Button12  // 0x0
  public    static  UnityEngine.KeyCode             Joystick2Button13  // 0x0
  public    static  UnityEngine.KeyCode             Joystick2Button14  // 0x0
  public    static  UnityEngine.KeyCode             Joystick2Button15  // 0x0
  public    static  UnityEngine.KeyCode             Joystick2Button16  // 0x0
  public    static  UnityEngine.KeyCode             Joystick2Button17  // 0x0
  public    static  UnityEngine.KeyCode             Joystick2Button18  // 0x0
  public    static  UnityEngine.KeyCode             Joystick2Button19  // 0x0
  public    static  UnityEngine.KeyCode             Joystick3Button0  // 0x0
  public    static  UnityEngine.KeyCode             Joystick3Button1  // 0x0
  public    static  UnityEngine.KeyCode             Joystick3Button2  // 0x0
  public    static  UnityEngine.KeyCode             Joystick3Button3  // 0x0
  public    static  UnityEngine.KeyCode             Joystick3Button4  // 0x0
  public    static  UnityEngine.KeyCode             Joystick3Button5  // 0x0
  public    static  UnityEngine.KeyCode             Joystick3Button6  // 0x0
  public    static  UnityEngine.KeyCode             Joystick3Button7  // 0x0
  public    static  UnityEngine.KeyCode             Joystick3Button8  // 0x0
  public    static  UnityEngine.KeyCode             Joystick3Button9  // 0x0
  public    static  UnityEngine.KeyCode             Joystick3Button10  // 0x0
  public    static  UnityEngine.KeyCode             Joystick3Button11  // 0x0
  public    static  UnityEngine.KeyCode             Joystick3Button12  // 0x0
  public    static  UnityEngine.KeyCode             Joystick3Button13  // 0x0
  public    static  UnityEngine.KeyCode             Joystick3Button14  // 0x0
  public    static  UnityEngine.KeyCode             Joystick3Button15  // 0x0
  public    static  UnityEngine.KeyCode             Joystick3Button16  // 0x0
  public    static  UnityEngine.KeyCode             Joystick3Button17  // 0x0
  public    static  UnityEngine.KeyCode             Joystick3Button18  // 0x0
  public    static  UnityEngine.KeyCode             Joystick3Button19  // 0x0
  public    static  UnityEngine.KeyCode             Joystick4Button0  // 0x0
  public    static  UnityEngine.KeyCode             Joystick4Button1  // 0x0
  public    static  UnityEngine.KeyCode             Joystick4Button2  // 0x0
  public    static  UnityEngine.KeyCode             Joystick4Button3  // 0x0
  public    static  UnityEngine.KeyCode             Joystick4Button4  // 0x0
  public    static  UnityEngine.KeyCode             Joystick4Button5  // 0x0
  public    static  UnityEngine.KeyCode             Joystick4Button6  // 0x0
  public    static  UnityEngine.KeyCode             Joystick4Button7  // 0x0
  public    static  UnityEngine.KeyCode             Joystick4Button8  // 0x0
  public    static  UnityEngine.KeyCode             Joystick4Button9  // 0x0
  public    static  UnityEngine.KeyCode             Joystick4Button10  // 0x0
  public    static  UnityEngine.KeyCode             Joystick4Button11  // 0x0
  public    static  UnityEngine.KeyCode             Joystick4Button12  // 0x0
  public    static  UnityEngine.KeyCode             Joystick4Button13  // 0x0
  public    static  UnityEngine.KeyCode             Joystick4Button14  // 0x0
  public    static  UnityEngine.KeyCode             Joystick4Button15  // 0x0
  public    static  UnityEngine.KeyCode             Joystick4Button16  // 0x0
  public    static  UnityEngine.KeyCode             Joystick4Button17  // 0x0
  public    static  UnityEngine.KeyCode             Joystick4Button18  // 0x0
  public    static  UnityEngine.KeyCode             Joystick4Button19  // 0x0
  public    static  UnityEngine.KeyCode             Joystick5Button0  // 0x0
  public    static  UnityEngine.KeyCode             Joystick5Button1  // 0x0
  public    static  UnityEngine.KeyCode             Joystick5Button2  // 0x0
  public    static  UnityEngine.KeyCode             Joystick5Button3  // 0x0
  public    static  UnityEngine.KeyCode             Joystick5Button4  // 0x0
  public    static  UnityEngine.KeyCode             Joystick5Button5  // 0x0
  public    static  UnityEngine.KeyCode             Joystick5Button6  // 0x0
  public    static  UnityEngine.KeyCode             Joystick5Button7  // 0x0
  public    static  UnityEngine.KeyCode             Joystick5Button8  // 0x0
  public    static  UnityEngine.KeyCode             Joystick5Button9  // 0x0
  public    static  UnityEngine.KeyCode             Joystick5Button10  // 0x0
  public    static  UnityEngine.KeyCode             Joystick5Button11  // 0x0
  public    static  UnityEngine.KeyCode             Joystick5Button12  // 0x0
  public    static  UnityEngine.KeyCode             Joystick5Button13  // 0x0
  public    static  UnityEngine.KeyCode             Joystick5Button14  // 0x0
  public    static  UnityEngine.KeyCode             Joystick5Button15  // 0x0
  public    static  UnityEngine.KeyCode             Joystick5Button16  // 0x0
  public    static  UnityEngine.KeyCode             Joystick5Button17  // 0x0
  public    static  UnityEngine.KeyCode             Joystick5Button18  // 0x0
  public    static  UnityEngine.KeyCode             Joystick5Button19  // 0x0
  public    static  UnityEngine.KeyCode             Joystick6Button0  // 0x0
  public    static  UnityEngine.KeyCode             Joystick6Button1  // 0x0
  public    static  UnityEngine.KeyCode             Joystick6Button2  // 0x0
  public    static  UnityEngine.KeyCode             Joystick6Button3  // 0x0
  public    static  UnityEngine.KeyCode             Joystick6Button4  // 0x0
  public    static  UnityEngine.KeyCode             Joystick6Button5  // 0x0
  public    static  UnityEngine.KeyCode             Joystick6Button6  // 0x0
  public    static  UnityEngine.KeyCode             Joystick6Button7  // 0x0
  public    static  UnityEngine.KeyCode             Joystick6Button8  // 0x0
  public    static  UnityEngine.KeyCode             Joystick6Button9  // 0x0
  public    static  UnityEngine.KeyCode             Joystick6Button10  // 0x0
  public    static  UnityEngine.KeyCode             Joystick6Button11  // 0x0
  public    static  UnityEngine.KeyCode             Joystick6Button12  // 0x0
  public    static  UnityEngine.KeyCode             Joystick6Button13  // 0x0
  public    static  UnityEngine.KeyCode             Joystick6Button14  // 0x0
  public    static  UnityEngine.KeyCode             Joystick6Button15  // 0x0
  public    static  UnityEngine.KeyCode             Joystick6Button16  // 0x0
  public    static  UnityEngine.KeyCode             Joystick6Button17  // 0x0
  public    static  UnityEngine.KeyCode             Joystick6Button18  // 0x0
  public    static  UnityEngine.KeyCode             Joystick6Button19  // 0x0
  public    static  UnityEngine.KeyCode             Joystick7Button0  // 0x0
  public    static  UnityEngine.KeyCode             Joystick7Button1  // 0x0
  public    static  UnityEngine.KeyCode             Joystick7Button2  // 0x0
  public    static  UnityEngine.KeyCode             Joystick7Button3  // 0x0
  public    static  UnityEngine.KeyCode             Joystick7Button4  // 0x0
  public    static  UnityEngine.KeyCode             Joystick7Button5  // 0x0
  public    static  UnityEngine.KeyCode             Joystick7Button6  // 0x0
  public    static  UnityEngine.KeyCode             Joystick7Button7  // 0x0
  public    static  UnityEngine.KeyCode             Joystick7Button8  // 0x0
  public    static  UnityEngine.KeyCode             Joystick7Button9  // 0x0
  public    static  UnityEngine.KeyCode             Joystick7Button10  // 0x0
  public    static  UnityEngine.KeyCode             Joystick7Button11  // 0x0
  public    static  UnityEngine.KeyCode             Joystick7Button12  // 0x0
  public    static  UnityEngine.KeyCode             Joystick7Button13  // 0x0
  public    static  UnityEngine.KeyCode             Joystick7Button14  // 0x0
  public    static  UnityEngine.KeyCode             Joystick7Button15  // 0x0
  public    static  UnityEngine.KeyCode             Joystick7Button16  // 0x0
  public    static  UnityEngine.KeyCode             Joystick7Button17  // 0x0
  public    static  UnityEngine.KeyCode             Joystick7Button18  // 0x0
  public    static  UnityEngine.KeyCode             Joystick7Button19  // 0x0
  public    static  UnityEngine.KeyCode             Joystick8Button0  // 0x0
  public    static  UnityEngine.KeyCode             Joystick8Button1  // 0x0
  public    static  UnityEngine.KeyCode             Joystick8Button2  // 0x0
  public    static  UnityEngine.KeyCode             Joystick8Button3  // 0x0
  public    static  UnityEngine.KeyCode             Joystick8Button4  // 0x0
  public    static  UnityEngine.KeyCode             Joystick8Button5  // 0x0
  public    static  UnityEngine.KeyCode             Joystick8Button6  // 0x0
  public    static  UnityEngine.KeyCode             Joystick8Button7  // 0x0
  public    static  UnityEngine.KeyCode             Joystick8Button8  // 0x0
  public    static  UnityEngine.KeyCode             Joystick8Button9  // 0x0
  public    static  UnityEngine.KeyCode             Joystick8Button10  // 0x0
  public    static  UnityEngine.KeyCode             Joystick8Button11  // 0x0
  public    static  UnityEngine.KeyCode             Joystick8Button12  // 0x0
  public    static  UnityEngine.KeyCode             Joystick8Button13  // 0x0
  public    static  UnityEngine.KeyCode             Joystick8Button14  // 0x0
  public    static  UnityEngine.KeyCode             Joystick8Button15  // 0x0
  public    static  UnityEngine.KeyCode             Joystick8Button16  // 0x0
  public    static  UnityEngine.KeyCode             Joystick8Button17  // 0x0
  public    static  UnityEngine.KeyCode             Joystick8Button18  // 0x0
  public    static  UnityEngine.KeyCode             Joystick8Button19  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.ILogger
TYPE:  interface
TOKEN: 0x2000139
FIELDS:
METHODS:
  UnityEngine.ILogHandler get_logHandler()
  System.Boolean get_logEnabled()
  System.Void set_logEnabled(System.Boolean value)
  System.Void set_filterLogType(UnityEngine.LogType value)
  System.Boolean IsLogTypeAllowed(UnityEngine.LogType logType)
  System.Void Log(UnityEngine.LogType logType, System.Object message)
  System.Void Log(UnityEngine.LogType logType, System.Object message, UnityEngine.Object context)
  System.Void Log(UnityEngine.LogType logType, System.String tag, System.Object message, UnityEngine.Object context)
  System.Void Log(System.String tag, System.Object message)
  System.Void LogWarning(System.String tag, System.Object message)
  System.Void LogError(System.String tag, System.Object message)
  System.Void LogFormat(UnityEngine.LogType logType, System.String format, System.Object[] args)
  System.Void LogException(System.Exception exception)
END_CLASS

CLASS: UnityEngine.ILogHandler
TYPE:  interface
TOKEN: 0x200013A
FIELDS:
METHODS:
  System.Void LogFormat(UnityEngine.LogType logType, UnityEngine.Object context, System.String format, System.Object[] args)
  System.Void LogException(System.Exception exception, UnityEngine.Object context)
END_CLASS

CLASS: UnityEngine.Logger
TYPE:  class
TOKEN: 0x200013B
FIELDS:
  private           UnityEngine.ILogHandler         <logHandler>k__BackingField  // 0x10
  private           System.Boolean                  <logEnabled>k__BackingField  // 0x18
  private           UnityEngine.LogType             <filterLogType>k__BackingField  // 0x1C
METHODS:
  System.Void .ctor(UnityEngine.ILogHandler logHandler)
  UnityEngine.ILogHandler get_logHandler()
  System.Void set_logHandler(UnityEngine.ILogHandler value)
  System.Boolean get_logEnabled()
  System.Void set_logEnabled(System.Boolean value)
  UnityEngine.LogType get_filterLogType()
  System.Void set_filterLogType(UnityEngine.LogType value)
  System.Boolean IsLogTypeAllowed(UnityEngine.LogType logType)
  System.String GetString(System.Object message)
  System.Void Log(UnityEngine.LogType logType, System.Object message)
  System.Void Log(UnityEngine.LogType logType, System.Object message, UnityEngine.Object context)
  System.Void Log(UnityEngine.LogType logType, System.String tag, System.Object message, UnityEngine.Object context)
  System.Void Log(System.String tag, System.Object message)
  System.Void LogWarning(System.String tag, System.Object message)
  System.Void LogError(System.String tag, System.Object message)
  System.Void LogException(System.Exception exception)
  System.Void LogException(System.Exception exception, UnityEngine.Object context)
  System.Void LogFormat(UnityEngine.LogType logType, System.String format, System.Object[] args)
  System.Void LogFormat(UnityEngine.LogType logType, UnityEngine.Object context, System.String format, System.Object[] args)
END_CLASS

CLASS: UnityEngine.UnityLogWriter
TYPE:  class
TOKEN: 0x200013C
EXTENDS: TextWriter
FIELDS:
METHODS:
  System.Void WriteStringToUnityLog(System.String s)
  System.Void WriteStringToUnityLogImpl(System.String s)
  System.Void Init()
  System.Text.Encoding get_Encoding()
  System.Void Write(System.Char value)
  System.Void Write(System.String s)
  System.Void Write(System.Char[] buffer, System.Int32 index, System.Int32 count)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Color
TYPE:  struct
TOKEN: 0x200013D
FIELDS:
  public            System.Single                   r  // 0x10
  public            System.Single                   g  // 0x14
  public            System.Single                   b  // 0x18
  public            System.Single                   a  // 0x1C
METHODS:
  System.Void .ctor(System.Single r, System.Single g, System.Single b, System.Single a)
  System.Void .ctor(System.Single r, System.Single g, System.Single b)
  System.String ToString()
  System.String ToString(System.String format)
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(UnityEngine.Color other)
  UnityEngine.Color op_Addition(UnityEngine.Color a, UnityEngine.Color b)
  UnityEngine.Color op_Subtraction(UnityEngine.Color a, UnityEngine.Color b)
  UnityEngine.Color op_Multiply(UnityEngine.Color a, UnityEngine.Color b)
  UnityEngine.Color op_Multiply(UnityEngine.Color a, System.Single b)
  UnityEngine.Color op_Multiply(System.Single b, UnityEngine.Color a)
  UnityEngine.Color op_Division(UnityEngine.Color a, System.Single b)
  System.Boolean op_Equality(UnityEngine.Color lhs, UnityEngine.Color rhs)
  System.Boolean op_Inequality(UnityEngine.Color lhs, UnityEngine.Color rhs)
  UnityEngine.Color Lerp(UnityEngine.Color a, UnityEngine.Color b, System.Single t)
  UnityEngine.Color LerpUnclamped(UnityEngine.Color a, UnityEngine.Color b, System.Single t)
  UnityEngine.Color RGBMultiplied(System.Single multiplier)
  UnityEngine.Color AlphaMultiplied(System.Single multiplier)
  UnityEngine.Color RGBMultiplied(UnityEngine.Color multiplier)
  UnityEngine.Color get_red()
  UnityEngine.Color get_green()
  UnityEngine.Color get_blue()
  UnityEngine.Color get_white()
  UnityEngine.Color get_black()
  UnityEngine.Color get_yellow()
  UnityEngine.Color get_cyan()
  UnityEngine.Color get_magenta()
  UnityEngine.Color get_gray()
  UnityEngine.Color get_grey()
  UnityEngine.Color get_clear()
  System.Single get_grayscale()
  UnityEngine.Color get_linear()
  UnityEngine.Color get_gamma()
  System.Single get_maxColorComponent()
  UnityEngine.Vector4 op_Implicit(UnityEngine.Color c)
  UnityEngine.Color op_Implicit(UnityEngine.Vector4 v)
  System.Single get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, System.Single value)
  System.Void RGBToHSV(UnityEngine.Color rgbColor, System.Single& H, System.Single& S, System.Single& V)
  System.Void RGBToHSVHelper(System.Single offset, System.Single dominantcolor, System.Single colorone, System.Single colortwo, System.Single& H, System.Single& S, System.Single& V)
  UnityEngine.Color HSVToRGB(System.Single H, System.Single S, System.Single V)
  UnityEngine.Color HSVToRGB(System.Single H, System.Single S, System.Single V, System.Boolean hdr)
END_CLASS

CLASS: UnityEngine.Color32
TYPE:  struct
TOKEN: 0x200013E
FIELDS:
  private           System.Int32                    rgba  // 0x10
  public            System.Byte                     r  // 0x10
  public            System.Byte                     g  // 0x11
  public            System.Byte                     b  // 0x12
  public            System.Byte                     a  // 0x13
METHODS:
  System.Void .ctor(System.Byte r, System.Byte g, System.Byte b, System.Byte a)
  UnityEngine.Color32 op_Implicit(UnityEngine.Color c)
  UnityEngine.Color op_Implicit(UnityEngine.Color32 c)
  UnityEngine.Color32 Lerp(UnityEngine.Color32 a, UnityEngine.Color32 b, System.Single t)
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: UnityEngine.ColorUtility
TYPE:  class
TOKEN: 0x200013F
FIELDS:
METHODS:
  System.Boolean DoTryParseHtmlColor(System.String htmlString, UnityEngine.Color32& color)
  System.Boolean TryParseHtmlString(System.String htmlString, UnityEngine.Color& color)
  System.String ToHtmlStringRGBA(UnityEngine.Color color)
END_CLASS

CLASS: UnityEngine.GradientColorKey
TYPE:  struct
TOKEN: 0x2000140
FIELDS:
  public            UnityEngine.Color               color  // 0x10
  public            System.Single                   time  // 0x20
METHODS:
  System.Void .ctor(UnityEngine.Color col, System.Single time)
END_CLASS

CLASS: UnityEngine.GradientAlphaKey
TYPE:  struct
TOKEN: 0x2000141
FIELDS:
  public            System.Single                   alpha  // 0x10
  public            System.Single                   time  // 0x14
METHODS:
  System.Void .ctor(System.Single alpha, System.Single time)
END_CLASS

CLASS: UnityEngine.GradientMode
TYPE:  struct
TOKEN: 0x2000142
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.GradientMode        Blend  // 0x0
  public    static  UnityEngine.GradientMode        Fixed  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Gradient
TYPE:  class
TOKEN: 0x2000143
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
METHODS:
  System.IntPtr Init()
  System.Void Cleanup()
  System.Boolean Internal_Equals(System.IntPtr other)
  System.Void .ctor()
  System.Void Finalize()
  UnityEngine.Color Evaluate(System.Single time)
  UnityEngine.GradientColorKey[] get_colorKeys()
  System.Void set_colorKeys(UnityEngine.GradientColorKey[] value)
  UnityEngine.GradientAlphaKey[] get_alphaKeys()
  System.Void set_alphaKeys(UnityEngine.GradientAlphaKey[] value)
  UnityEngine.GradientMode get_mode()
  System.Void set_mode(UnityEngine.GradientMode value)
  System.Void SetKeys(UnityEngine.GradientColorKey[] colorKeys, UnityEngine.GradientAlphaKey[] alphaKeys)
  System.Boolean Equals(System.Object o)
  System.Boolean Equals(UnityEngine.Gradient other)
  System.Int32 GetHashCode()
  System.Void Evaluate_Injected(System.Single time, UnityEngine.Color& ret)
END_CLASS

CLASS: UnityEngine.FrustumPlanes
TYPE:  struct
TOKEN: 0x2000144
FIELDS:
  public            System.Single                   left  // 0x10
  public            System.Single                   right  // 0x14
  public            System.Single                   bottom  // 0x18
  public            System.Single                   top  // 0x1C
  public            System.Single                   zNear  // 0x20
  public            System.Single                   zFar  // 0x24
METHODS:
END_CLASS

CLASS: UnityEngine.Matrix4x4
TYPE:  struct
TOKEN: 0x2000145
FIELDS:
  public            System.Single                   m00  // 0x10
  public            System.Single                   m10  // 0x14
  public            System.Single                   m20  // 0x18
  public            System.Single                   m30  // 0x1C
  public            System.Single                   m01  // 0x20
  public            System.Single                   m11  // 0x24
  public            System.Single                   m21  // 0x28
  public            System.Single                   m31  // 0x2C
  public            System.Single                   m02  // 0x30
  public            System.Single                   m12  // 0x34
  public            System.Single                   m22  // 0x38
  public            System.Single                   m32  // 0x3C
  public            System.Single                   m03  // 0x40
  public            System.Single                   m13  // 0x44
  public            System.Single                   m23  // 0x48
  public            System.Single                   m33  // 0x4C
  private   static readonly UnityEngine.Matrix4x4           zeroMatrix  // 0x0
  private   static readonly UnityEngine.Matrix4x4           identityMatrix  // 0x40
METHODS:
  UnityEngine.Quaternion GetRotation()
  UnityEngine.Vector3 GetLossyScale()
  System.Single GetDeterminant()
  UnityEngine.FrustumPlanes DecomposeProjection()
  UnityEngine.Matrix4x4 HGMultiplyMatrix4x4Fast(UnityEngine.Matrix4x4 rhs)
  UnityEngine.Quaternion get_rotation()
  UnityEngine.Vector3 get_lossyScale()
  System.Single get_determinant()
  UnityEngine.FrustumPlanes get_decomposeProjection()
  UnityEngine.Matrix4x4 TRS(UnityEngine.Vector3 pos, UnityEngine.Quaternion q, UnityEngine.Vector3 s)
  System.Void SetTRS(UnityEngine.Vector3 pos, UnityEngine.Quaternion q, UnityEngine.Vector3 s)
  System.Boolean Inverse3DAffine(UnityEngine.Matrix4x4 input, UnityEngine.Matrix4x4& result)
  UnityEngine.Matrix4x4 Inverse(UnityEngine.Matrix4x4 m)
  UnityEngine.Matrix4x4 get_inverse()
  UnityEngine.Matrix4x4 Transpose(UnityEngine.Matrix4x4 m)
  UnityEngine.Matrix4x4 get_transpose()
  UnityEngine.Matrix4x4 Ortho(System.Single left, System.Single right, System.Single bottom, System.Single top, System.Single zNear, System.Single zFar)
  UnityEngine.Matrix4x4 Perspective(System.Single fov, System.Single aspect, System.Single zNear, System.Single zFar)
  UnityEngine.Matrix4x4 LookAt(UnityEngine.Vector3 from, UnityEngine.Vector3 to, UnityEngine.Vector3 up)
  UnityEngine.Matrix4x4 Frustum(System.Single left, System.Single right, System.Single bottom, System.Single top, System.Single zNear, System.Single zFar)
  UnityEngine.Matrix4x4 Frustum(UnityEngine.FrustumPlanes fp)
  System.Void .ctor(UnityEngine.Vector4 column0, UnityEngine.Vector4 column1, UnityEngine.Vector4 column2, UnityEngine.Vector4 column3)
  System.Single get_Item(System.Int32 row, System.Int32 column)
  System.Void set_Item(System.Int32 row, System.Int32 column, System.Single value)
  System.Single get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, System.Single value)
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(UnityEngine.Matrix4x4 other)
  UnityEngine.Matrix4x4 op_Multiply(UnityEngine.Matrix4x4 lhs, UnityEngine.Matrix4x4 rhs)
  UnityEngine.Vector4 op_Multiply(UnityEngine.Matrix4x4 lhs, UnityEngine.Vector4 vector)
  System.Boolean op_Equality(UnityEngine.Matrix4x4 lhs, UnityEngine.Matrix4x4 rhs)
  System.Boolean op_Inequality(UnityEngine.Matrix4x4 lhs, UnityEngine.Matrix4x4 rhs)
  UnityEngine.Vector4 GetColumn(System.Int32 index)
  UnityEngine.Vector4 GetRow(System.Int32 index)
  UnityEngine.Vector3 GetPosition()
  System.Void SetColumn(System.Int32 index, UnityEngine.Vector4 column)
  System.Void SetRow(System.Int32 index, UnityEngine.Vector4 row)
  UnityEngine.Vector3 MultiplyPoint(UnityEngine.Vector3 point)
  UnityEngine.Vector3 MultiplyPoint3x4(UnityEngine.Vector3 point)
  UnityEngine.Vector3 MultiplyVector(UnityEngine.Vector3 vector)
  UnityEngine.Matrix4x4 Scale(UnityEngine.Vector3 vector)
  UnityEngine.Matrix4x4 Translate(UnityEngine.Vector3 vector)
  UnityEngine.Matrix4x4 Rotate(UnityEngine.Quaternion q)
  UnityEngine.Matrix4x4 get_zero()
  UnityEngine.Matrix4x4 get_identity()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  System.Void .cctor()
  System.Void GetRotation_Injected(UnityEngine.Matrix4x4& _unity_self, UnityEngine.Quaternion& ret)
  System.Void GetLossyScale_Injected(UnityEngine.Matrix4x4& _unity_self, UnityEngine.Vector3& ret)
  System.Single GetDeterminant_Injected(UnityEngine.Matrix4x4& _unity_self)
  System.Void DecomposeProjection_Injected(UnityEngine.Matrix4x4& _unity_self, UnityEngine.FrustumPlanes& ret)
  System.Void HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4& _unity_self, UnityEngine.Matrix4x4& rhs, UnityEngine.Matrix4x4& ret)
  System.Void TRS_Injected(UnityEngine.Vector3& pos, UnityEngine.Quaternion& q, UnityEngine.Vector3& s, UnityEngine.Matrix4x4& ret)
  System.Boolean Inverse3DAffine_Injected(UnityEngine.Matrix4x4& input, UnityEngine.Matrix4x4& result)
  System.Void Inverse_Injected(UnityEngine.Matrix4x4& m, UnityEngine.Matrix4x4& ret)
  System.Void Transpose_Injected(UnityEngine.Matrix4x4& m, UnityEngine.Matrix4x4& ret)
  System.Void Ortho_Injected(System.Single left, System.Single right, System.Single bottom, System.Single top, System.Single zNear, System.Single zFar, UnityEngine.Matrix4x4& ret)
  System.Void Perspective_Injected(System.Single fov, System.Single aspect, System.Single zNear, System.Single zFar, UnityEngine.Matrix4x4& ret)
  System.Void LookAt_Injected(UnityEngine.Vector3& from, UnityEngine.Vector3& to, UnityEngine.Vector3& up, UnityEngine.Matrix4x4& ret)
  System.Void Frustum_Injected(System.Single left, System.Single right, System.Single bottom, System.Single top, System.Single zNear, System.Single zFar, UnityEngine.Matrix4x4& ret)
END_CLASS

CLASS: UnityEngine.Vector3
TYPE:  struct
TOKEN: 0x2000146
FIELDS:
  public    static  System.Single                   kEpsilon  // 0x0
  public    static  System.Single                   kEpsilonNormalSqrt  // 0x0
  public            System.Single                   x  // 0x10
  public            System.Single                   y  // 0x14
  public            System.Single                   z  // 0x18
  private   static readonly UnityEngine.Vector3             zeroVector  // 0x0
  private   static readonly UnityEngine.Vector3             oneVector  // 0xC
  private   static readonly UnityEngine.Vector3             upVector  // 0x18
  private   static readonly UnityEngine.Vector3             downVector  // 0x24
  private   static readonly UnityEngine.Vector3             leftVector  // 0x30
  private   static readonly UnityEngine.Vector3             rightVector  // 0x3C
  private   static readonly UnityEngine.Vector3             forwardVector  // 0x48
  private   static readonly UnityEngine.Vector3             backVector  // 0x54
  private   static readonly UnityEngine.Vector3             positiveInfinityVector  // 0x60
  private   static readonly UnityEngine.Vector3             negativeInfinityVector  // 0x6C
METHODS:
  UnityEngine.Vector3 Slerp(UnityEngine.Vector3 a, UnityEngine.Vector3 b, System.Single t)
  UnityEngine.Vector3 SlerpUnclamped(UnityEngine.Vector3 a, UnityEngine.Vector3 b, System.Single t)
  System.Void OrthoNormalize2(UnityEngine.Vector3& a, UnityEngine.Vector3& b)
  System.Void OrthoNormalize(UnityEngine.Vector3& normal, UnityEngine.Vector3& tangent)
  System.Void OrthoNormalize3(UnityEngine.Vector3& a, UnityEngine.Vector3& b, UnityEngine.Vector3& c)
  System.Void OrthoNormalize(UnityEngine.Vector3& normal, UnityEngine.Vector3& tangent, UnityEngine.Vector3& binormal)
  UnityEngine.Vector3 RotateTowards(UnityEngine.Vector3 current, UnityEngine.Vector3 target, System.Single maxRadiansDelta, System.Single maxMagnitudeDelta)
  UnityEngine.Vector3 Lerp(UnityEngine.Vector3 a, UnityEngine.Vector3 b, System.Single t)
  UnityEngine.Vector3 LerpUnclamped(UnityEngine.Vector3 a, UnityEngine.Vector3 b, System.Single t)
  UnityEngine.Vector3 MoveTowards(UnityEngine.Vector3 current, UnityEngine.Vector3 target, System.Single maxDistanceDelta)
  UnityEngine.Vector3 SmoothDamp(UnityEngine.Vector3 current, UnityEngine.Vector3 target, UnityEngine.Vector3& currentVelocity, System.Single smoothTime, System.Single maxSpeed)
  UnityEngine.Vector3 SmoothDamp(UnityEngine.Vector3 current, UnityEngine.Vector3 target, UnityEngine.Vector3& currentVelocity, System.Single smoothTime)
  UnityEngine.Vector3 SmoothDamp(UnityEngine.Vector3 current, UnityEngine.Vector3 target, UnityEngine.Vector3& currentVelocity, System.Single smoothTime, System.Single maxSpeed, System.Single deltaTime)
  System.Single get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, System.Single value)
  System.Void .ctor(System.Single x, System.Single y, System.Single z)
  System.Void .ctor(System.Single x, System.Single y)
  System.Void Set(System.Single newX, System.Single newY, System.Single newZ)
  UnityEngine.Vector3 Scale(UnityEngine.Vector3 a, UnityEngine.Vector3 b)
  System.Void Scale(UnityEngine.Vector3 scale)
  UnityEngine.Vector3 Cross(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs)
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(UnityEngine.Vector3 other)
  UnityEngine.Vector3 Reflect(UnityEngine.Vector3 inDirection, UnityEngine.Vector3 inNormal)
  UnityEngine.Vector3 Normalize(UnityEngine.Vector3 value)
  System.Void Normalize()
  UnityEngine.Vector3 get_normalized()
  System.Single Dot(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs)
  UnityEngine.Vector3 Project(UnityEngine.Vector3 vector, UnityEngine.Vector3 onNormal)
  UnityEngine.Vector3 ProjectOnPlane(UnityEngine.Vector3 vector, UnityEngine.Vector3 planeNormal)
  System.Single Angle(UnityEngine.Vector3 from, UnityEngine.Vector3 to)
  System.Single SignedAngle(UnityEngine.Vector3 from, UnityEngine.Vector3 to, UnityEngine.Vector3 axis)
  System.Single Distance(UnityEngine.Vector3 a, UnityEngine.Vector3 b)
  UnityEngine.Vector3 ClampMagnitude(UnityEngine.Vector3 vector, System.Single maxLength)
  System.Single Magnitude(UnityEngine.Vector3 vector)
  System.Single get_magnitude()
  System.Single SqrMagnitude(UnityEngine.Vector3 vector)
  System.Single get_sqrMagnitude()
  UnityEngine.Vector3 Min(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs)
  UnityEngine.Vector3 Max(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs)
  UnityEngine.Vector3 get_zero()
  UnityEngine.Vector3 get_one()
  UnityEngine.Vector3 get_forward()
  UnityEngine.Vector3 get_back()
  UnityEngine.Vector3 get_up()
  UnityEngine.Vector3 get_down()
  UnityEngine.Vector3 get_left()
  UnityEngine.Vector3 get_right()
  UnityEngine.Vector3 get_positiveInfinity()
  UnityEngine.Vector3 get_negativeInfinity()
  UnityEngine.Vector3 op_Addition(UnityEngine.Vector3 a, UnityEngine.Vector3 b)
  UnityEngine.Vector3 op_Subtraction(UnityEngine.Vector3 a, UnityEngine.Vector3 b)
  UnityEngine.Vector3 op_UnaryNegation(UnityEngine.Vector3 a)
  UnityEngine.Vector3 op_Multiply(UnityEngine.Vector3 a, System.Single d)
  UnityEngine.Vector3 op_Multiply(System.Single d, UnityEngine.Vector3 a)
  UnityEngine.Vector3 op_Division(UnityEngine.Vector3 a, System.Single d)
  System.Boolean op_Equality(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs)
  System.Boolean op_Inequality(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs)
  System.String ToString()
  System.String ToString(System.String format)
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  UnityEngine.Vector3 get_fwd()
  System.Single AngleBetween(UnityEngine.Vector3 from, UnityEngine.Vector3 to)
  UnityEngine.Vector3 Exclude(UnityEngine.Vector3 excludeThis, UnityEngine.Vector3 fromThat)
  System.Void .cctor()
  System.Void Slerp_Injected(UnityEngine.Vector3& a, UnityEngine.Vector3& b, System.Single t, UnityEngine.Vector3& ret)
  System.Void SlerpUnclamped_Injected(UnityEngine.Vector3& a, UnityEngine.Vector3& b, System.Single t, UnityEngine.Vector3& ret)
  System.Void RotateTowards_Injected(UnityEngine.Vector3& current, UnityEngine.Vector3& target, System.Single maxRadiansDelta, System.Single maxMagnitudeDelta, UnityEngine.Vector3& ret)
END_CLASS

CLASS: UnityEngine.Quaternion
TYPE:  struct
TOKEN: 0x2000147
FIELDS:
  public            System.Single                   x  // 0x10
  public            System.Single                   y  // 0x14
  public            System.Single                   z  // 0x18
  public            System.Single                   w  // 0x1C
  private   static readonly UnityEngine.Quaternion          identityQuaternion  // 0x0
  public    static  System.Single                   kEpsilon  // 0x0
METHODS:
  UnityEngine.Quaternion FromToRotation(UnityEngine.Vector3 fromDirection, UnityEngine.Vector3 toDirection)
  UnityEngine.Quaternion Inverse(UnityEngine.Quaternion rotation)
  UnityEngine.Quaternion Slerp(UnityEngine.Quaternion a, UnityEngine.Quaternion b, System.Single t)
  UnityEngine.Quaternion SlerpUnclamped(UnityEngine.Quaternion a, UnityEngine.Quaternion b, System.Single t)
  UnityEngine.Quaternion Lerp(UnityEngine.Quaternion a, UnityEngine.Quaternion b, System.Single t)
  UnityEngine.Quaternion LerpUnclamped(UnityEngine.Quaternion a, UnityEngine.Quaternion b, System.Single t)
  UnityEngine.Quaternion Internal_FromEulerRad(UnityEngine.Vector3 euler)
  UnityEngine.Vector3 Internal_ToEulerRad(UnityEngine.Quaternion rotation)
  System.Void Internal_ToAxisAngleRad(UnityEngine.Quaternion q, UnityEngine.Vector3& axis, System.Single& angle)
  UnityEngine.Quaternion AngleAxis(System.Single angle, UnityEngine.Vector3 axis)
  UnityEngine.Quaternion LookRotation(UnityEngine.Vector3 forward, UnityEngine.Vector3 upwards)
  UnityEngine.Quaternion LookRotation(UnityEngine.Vector3 forward)
  System.Single get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, System.Single value)
  System.Void .ctor(System.Single x, System.Single y, System.Single z, System.Single w)
  System.Void Set(System.Single newX, System.Single newY, System.Single newZ, System.Single newW)
  UnityEngine.Quaternion get_identity()
  UnityEngine.Quaternion op_Multiply(UnityEngine.Quaternion lhs, UnityEngine.Quaternion rhs)
  UnityEngine.Vector3 op_Multiply(UnityEngine.Quaternion rotation, UnityEngine.Vector3 point)
  System.Boolean IsEqualUsingDot(System.Single dot)
  System.Boolean op_Equality(UnityEngine.Quaternion lhs, UnityEngine.Quaternion rhs)
  System.Boolean op_Inequality(UnityEngine.Quaternion lhs, UnityEngine.Quaternion rhs)
  System.Single Dot(UnityEngine.Quaternion a, UnityEngine.Quaternion b)
  System.Void SetLookRotation(UnityEngine.Vector3 view)
  System.Void SetLookRotation(UnityEngine.Vector3 view, UnityEngine.Vector3 up)
  System.Single Angle(UnityEngine.Quaternion a, UnityEngine.Quaternion b)
  UnityEngine.Vector3 Internal_MakePositive(UnityEngine.Vector3 euler)
  UnityEngine.Vector3 get_eulerAngles()
  System.Void set_eulerAngles(UnityEngine.Vector3 value)
  UnityEngine.Quaternion Euler(System.Single x, System.Single y, System.Single z)
  UnityEngine.Quaternion Euler(UnityEngine.Vector3 euler)
  System.Void ToAngleAxis(System.Single& angle, UnityEngine.Vector3& axis)
  System.Void SetFromToRotation(UnityEngine.Vector3 fromDirection, UnityEngine.Vector3 toDirection)
  UnityEngine.Quaternion RotateTowards(UnityEngine.Quaternion from, UnityEngine.Quaternion to, System.Single maxDegreesDelta)
  UnityEngine.Quaternion Normalize(UnityEngine.Quaternion q)
  System.Void Normalize()
  UnityEngine.Quaternion get_normalized()
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(UnityEngine.Quaternion other)
  System.String ToString()
  System.String ToString(System.String format)
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  UnityEngine.Quaternion EulerRotation(System.Single x, System.Single y, System.Single z)
  UnityEngine.Quaternion EulerRotation(UnityEngine.Vector3 euler)
  System.Void SetEulerRotation(System.Single x, System.Single y, System.Single z)
  System.Void SetEulerRotation(UnityEngine.Vector3 euler)
  UnityEngine.Vector3 ToEuler()
  UnityEngine.Quaternion EulerAngles(System.Single x, System.Single y, System.Single z)
  UnityEngine.Quaternion EulerAngles(UnityEngine.Vector3 euler)
  System.Void ToAxisAngle(UnityEngine.Vector3& axis, System.Single& angle)
  System.Void SetEulerAngles(System.Single x, System.Single y, System.Single z)
  System.Void SetEulerAngles(UnityEngine.Vector3 euler)
  UnityEngine.Vector3 ToEulerAngles(UnityEngine.Quaternion rotation)
  UnityEngine.Vector3 ToEulerAngles()
  System.Void SetAxisAngle(UnityEngine.Vector3 axis, System.Single angle)
  UnityEngine.Quaternion AxisAngle(UnityEngine.Vector3 axis, System.Single angle)
  System.Void .cctor()
  System.Void FromToRotation_Injected(UnityEngine.Vector3& fromDirection, UnityEngine.Vector3& toDirection, UnityEngine.Quaternion& ret)
  System.Void Inverse_Injected(UnityEngine.Quaternion& rotation, UnityEngine.Quaternion& ret)
  System.Void Slerp_Injected(UnityEngine.Quaternion& a, UnityEngine.Quaternion& b, System.Single t, UnityEngine.Quaternion& ret)
  System.Void SlerpUnclamped_Injected(UnityEngine.Quaternion& a, UnityEngine.Quaternion& b, System.Single t, UnityEngine.Quaternion& ret)
  System.Void Lerp_Injected(UnityEngine.Quaternion& a, UnityEngine.Quaternion& b, System.Single t, UnityEngine.Quaternion& ret)
  System.Void LerpUnclamped_Injected(UnityEngine.Quaternion& a, UnityEngine.Quaternion& b, System.Single t, UnityEngine.Quaternion& ret)
  System.Void Internal_FromEulerRad_Injected(UnityEngine.Vector3& euler, UnityEngine.Quaternion& ret)
  System.Void Internal_ToEulerRad_Injected(UnityEngine.Quaternion& rotation, UnityEngine.Vector3& ret)
  System.Void Internal_ToAxisAngleRad_Injected(UnityEngine.Quaternion& q, UnityEngine.Vector3& axis, System.Single& angle)
  System.Void AngleAxis_Injected(System.Single angle, UnityEngine.Vector3& axis, UnityEngine.Quaternion& ret)
  System.Void LookRotation_Injected(UnityEngine.Vector3& forward, UnityEngine.Vector3& upwards, UnityEngine.Quaternion& ret)
END_CLASS

CLASS: UnityEngine.Mathf
TYPE:  struct
TOKEN: 0x2000148
FIELDS:
  public    static  System.Single                   PI  // 0x0
  public    static  System.Single                   Infinity  // 0x0
  public    static  System.Single                   NegativeInfinity  // 0x0
  public    static  System.Single                   Deg2Rad  // 0x0
  public    static  System.Single                   Rad2Deg  // 0x0
  public    static readonly System.Single                   Epsilon  // 0x0
METHODS:
  System.Int32 ClosestPowerOfTwo(System.Int32 value)
  System.Boolean IsPowerOfTwo(System.Int32 value)
  System.Int32 NextPowerOfTwo(System.Int32 value)
  System.Single GammaToLinearSpace(System.Single value)
  System.Single LinearToGammaSpace(System.Single value)
  UnityEngine.Color CorrelatedColorTemperatureToRGB(System.Single kelvin)
  System.UInt16 FloatToHalf(System.Single val)
  System.Single HalfToFloat(System.UInt16 val)
  System.Single PerlinNoise(System.Single x, System.Single y)
  System.Single Sin(System.Single f)
  System.Single Cos(System.Single f)
  System.Single Tan(System.Single f)
  System.Single Asin(System.Single f)
  System.Single Acos(System.Single f)
  System.Single Atan(System.Single f)
  System.Single Atan2(System.Single y, System.Single x)
  System.Single Sqrt(System.Single f)
  System.Single Abs(System.Single f)
  System.Int32 Abs(System.Int32 value)
  System.Single Min(System.Single a, System.Single b)
  System.Single Min(System.Single[] values)
  System.Int32 Min(System.Int32 a, System.Int32 b)
  System.Int32 Min(System.Int32[] values)
  System.Single Max(System.Single a, System.Single b)
  System.Single Max(System.Single[] values)
  System.Int32 Max(System.Int32 a, System.Int32 b)
  System.Int32 Max(System.Int32[] values)
  System.Single Pow(System.Single f, System.Single p)
  System.Single Exp(System.Single power)
  System.Single Log(System.Single f, System.Single p)
  System.Single Log(System.Single f)
  System.Single Log10(System.Single f)
  System.Single Ceil(System.Single f)
  System.Single Floor(System.Single f)
  System.Single Round(System.Single f)
  System.Int32 CeilToInt(System.Single f)
  System.Int32 FloorToInt(System.Single f)
  System.Int32 RoundToInt(System.Single f)
  System.Single Sign(System.Single f)
  System.Single Clamp(System.Single value, System.Single min, System.Single max)
  System.Int32 Clamp(System.Int32 value, System.Int32 min, System.Int32 max)
  System.Single Clamp01(System.Single value)
  System.Single Lerp(System.Single a, System.Single b, System.Single t)
  System.Single LerpUnclamped(System.Single a, System.Single b, System.Single t)
  System.Single LerpAngle(System.Single a, System.Single b, System.Single t)
  System.Single MoveTowards(System.Single current, System.Single target, System.Single maxDelta)
  System.Single MoveTowardsAngle(System.Single current, System.Single target, System.Single maxDelta)
  System.Single SmoothStep(System.Single from, System.Single to, System.Single t)
  System.Single Gamma(System.Single value, System.Single absmax, System.Single gamma)
  System.Boolean Approximately(System.Single a, System.Single b)
  System.Single SmoothDamp(System.Single current, System.Single target, System.Single& currentVelocity, System.Single smoothTime, System.Single maxSpeed)
  System.Single SmoothDamp(System.Single current, System.Single target, System.Single& currentVelocity, System.Single smoothTime)
  System.Single SmoothDamp(System.Single current, System.Single target, System.Single& currentVelocity, System.Single smoothTime, System.Single maxSpeed, System.Single deltaTime)
  System.Single SmoothDampAngle(System.Single current, System.Single target, System.Single& currentVelocity, System.Single smoothTime, System.Single maxSpeed)
  System.Single SmoothDampAngle(System.Single current, System.Single target, System.Single& currentVelocity, System.Single smoothTime)
  System.Single SmoothDampAngle(System.Single current, System.Single target, System.Single& currentVelocity, System.Single smoothTime, System.Single maxSpeed, System.Single deltaTime)
  System.Single Repeat(System.Single t, System.Single length)
  System.Single PingPong(System.Single t, System.Single length)
  System.Single InverseLerp(System.Single a, System.Single b, System.Single value)
  System.Single DeltaAngle(System.Single current, System.Single target)
  System.Boolean LineIntersection(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4, UnityEngine.Vector2& result)
  System.Boolean LineSegmentIntersection(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4, UnityEngine.Vector2& result)
  System.Int64 RandomToLong(System.Random r)
  System.Single ClampToFloat(System.Double value)
  System.Int32 ClampToInt(System.Int64 value)
  System.UInt32 ClampToUInt(System.Int64 value)
  System.Void .cctor()
  System.Void CorrelatedColorTemperatureToRGB_Injected(System.Single kelvin, UnityEngine.Color& ret)
END_CLASS

CLASS: UnityEngine.Vector2
TYPE:  struct
TOKEN: 0x2000149
FIELDS:
  public            System.Single                   x  // 0x10
  public            System.Single                   y  // 0x14
  private   static readonly UnityEngine.Vector2             zeroVector  // 0x0
  private   static readonly UnityEngine.Vector2             oneVector  // 0x8
  private   static readonly UnityEngine.Vector2             upVector  // 0x10
  private   static readonly UnityEngine.Vector2             downVector  // 0x18
  private   static readonly UnityEngine.Vector2             leftVector  // 0x20
  private   static readonly UnityEngine.Vector2             rightVector  // 0x28
  private   static readonly UnityEngine.Vector2             positiveInfinityVector  // 0x30
  private   static readonly UnityEngine.Vector2             negativeInfinityVector  // 0x38
  public    static  System.Single                   kEpsilon  // 0x0
  public    static  System.Single                   kEpsilonNormalSqrt  // 0x0
METHODS:
  System.Single get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, System.Single value)
  System.Void .ctor(System.Single x, System.Single y)
  System.Void Set(System.Single newX, System.Single newY)
  UnityEngine.Vector2 Lerp(UnityEngine.Vector2 a, UnityEngine.Vector2 b, System.Single t)
  UnityEngine.Vector2 LerpUnclamped(UnityEngine.Vector2 a, UnityEngine.Vector2 b, System.Single t)
  UnityEngine.Vector2 MoveTowards(UnityEngine.Vector2 current, UnityEngine.Vector2 target, System.Single maxDistanceDelta)
  UnityEngine.Vector2 Scale(UnityEngine.Vector2 a, UnityEngine.Vector2 b)
  System.Void Scale(UnityEngine.Vector2 scale)
  System.Void Normalize()
  UnityEngine.Vector2 get_normalized()
  System.String ToString()
  System.String ToString(System.String format)
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(UnityEngine.Vector2 other)
  UnityEngine.Vector2 Reflect(UnityEngine.Vector2 inDirection, UnityEngine.Vector2 inNormal)
  UnityEngine.Vector2 Perpendicular(UnityEngine.Vector2 inDirection)
  System.Single Dot(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs)
  System.Single get_magnitude()
  System.Single get_sqrMagnitude()
  System.Single Angle(UnityEngine.Vector2 from, UnityEngine.Vector2 to)
  System.Single SignedAngle(UnityEngine.Vector2 from, UnityEngine.Vector2 to)
  System.Single Distance(UnityEngine.Vector2 a, UnityEngine.Vector2 b)
  UnityEngine.Vector2 ClampMagnitude(UnityEngine.Vector2 vector, System.Single maxLength)
  System.Single SqrMagnitude(UnityEngine.Vector2 a)
  System.Single SqrMagnitude()
  UnityEngine.Vector2 Min(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs)
  UnityEngine.Vector2 Max(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs)
  UnityEngine.Vector2 SmoothDamp(UnityEngine.Vector2 current, UnityEngine.Vector2 target, UnityEngine.Vector2& currentVelocity, System.Single smoothTime, System.Single maxSpeed)
  UnityEngine.Vector2 SmoothDamp(UnityEngine.Vector2 current, UnityEngine.Vector2 target, UnityEngine.Vector2& currentVelocity, System.Single smoothTime)
  UnityEngine.Vector2 SmoothDamp(UnityEngine.Vector2 current, UnityEngine.Vector2 target, UnityEngine.Vector2& currentVelocity, System.Single smoothTime, System.Single maxSpeed, System.Single deltaTime)
  UnityEngine.Vector2 op_Addition(UnityEngine.Vector2 a, UnityEngine.Vector2 b)
  UnityEngine.Vector2 op_Subtraction(UnityEngine.Vector2 a, UnityEngine.Vector2 b)
  UnityEngine.Vector2 op_Multiply(UnityEngine.Vector2 a, UnityEngine.Vector2 b)
  UnityEngine.Vector2 op_Division(UnityEngine.Vector2 a, UnityEngine.Vector2 b)
  UnityEngine.Vector2 op_UnaryNegation(UnityEngine.Vector2 a)
  UnityEngine.Vector2 op_Multiply(UnityEngine.Vector2 a, System.Single d)
  UnityEngine.Vector2 op_Multiply(System.Single d, UnityEngine.Vector2 a)
  UnityEngine.Vector2 op_Division(UnityEngine.Vector2 a, System.Single d)
  System.Boolean op_Equality(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs)
  System.Boolean op_Inequality(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs)
  UnityEngine.Vector2 op_Implicit(UnityEngine.Vector3 v)
  UnityEngine.Vector3 op_Implicit(UnityEngine.Vector2 v)
  UnityEngine.Vector2 get_zero()
  UnityEngine.Vector2 get_one()
  UnityEngine.Vector2 get_up()
  UnityEngine.Vector2 get_down()
  UnityEngine.Vector2 get_left()
  UnityEngine.Vector2 get_right()
  UnityEngine.Vector2 get_positiveInfinity()
  UnityEngine.Vector2 get_negativeInfinity()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Vector2Int
TYPE:  struct
TOKEN: 0x200014A
FIELDS:
  private           System.Int32                    m_X  // 0x10
  private           System.Int32                    m_Y  // 0x14
  private   static readonly UnityEngine.Vector2Int          s_Zero  // 0x0
  private   static readonly UnityEngine.Vector2Int          s_One  // 0x8
  private   static readonly UnityEngine.Vector2Int          s_Up  // 0x10
  private   static readonly UnityEngine.Vector2Int          s_Down  // 0x18
  private   static readonly UnityEngine.Vector2Int          s_Left  // 0x20
  private   static readonly UnityEngine.Vector2Int          s_Right  // 0x28
METHODS:
  System.Int32 get_x()
  System.Void set_x(System.Int32 value)
  System.Int32 get_y()
  System.Void set_y(System.Int32 value)
  System.Void .ctor(System.Int32 x, System.Int32 y)
  System.Void Set(System.Int32 x, System.Int32 y)
  System.Int32 get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, System.Int32 value)
  System.Single get_magnitude()
  System.Int32 get_sqrMagnitude()
  System.Single Distance(UnityEngine.Vector2Int a, UnityEngine.Vector2Int b)
  UnityEngine.Vector2Int Min(UnityEngine.Vector2Int lhs, UnityEngine.Vector2Int rhs)
  UnityEngine.Vector2Int Max(UnityEngine.Vector2Int lhs, UnityEngine.Vector2Int rhs)
  UnityEngine.Vector2Int Scale(UnityEngine.Vector2Int a, UnityEngine.Vector2Int b)
  System.Void Scale(UnityEngine.Vector2Int scale)
  System.Void Clamp(UnityEngine.Vector2Int min, UnityEngine.Vector2Int max)
  UnityEngine.Vector2 op_Implicit(UnityEngine.Vector2Int v)
  UnityEngine.Vector3Int op_Explicit(UnityEngine.Vector2Int v)
  UnityEngine.Vector2Int FloorToInt(UnityEngine.Vector2 v)
  UnityEngine.Vector2Int CeilToInt(UnityEngine.Vector2 v)
  UnityEngine.Vector2Int RoundToInt(UnityEngine.Vector2 v)
  UnityEngine.Vector2Int op_UnaryNegation(UnityEngine.Vector2Int v)
  UnityEngine.Vector2Int op_Addition(UnityEngine.Vector2Int a, UnityEngine.Vector2Int b)
  UnityEngine.Vector2Int op_Subtraction(UnityEngine.Vector2Int a, UnityEngine.Vector2Int b)
  UnityEngine.Vector2Int op_Multiply(UnityEngine.Vector2Int a, UnityEngine.Vector2Int b)
  UnityEngine.Vector2Int op_Multiply(System.Int32 a, UnityEngine.Vector2Int b)
  UnityEngine.Vector2Int op_Multiply(UnityEngine.Vector2Int a, System.Int32 b)
  UnityEngine.Vector2Int op_Division(UnityEngine.Vector2Int a, System.Int32 b)
  System.Boolean op_Equality(UnityEngine.Vector2Int lhs, UnityEngine.Vector2Int rhs)
  System.Boolean op_Inequality(UnityEngine.Vector2Int lhs, UnityEngine.Vector2Int rhs)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(UnityEngine.Vector2Int other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format)
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  UnityEngine.Vector2Int get_zero()
  UnityEngine.Vector2Int get_one()
  UnityEngine.Vector2Int get_up()
  UnityEngine.Vector2Int get_down()
  UnityEngine.Vector2Int get_left()
  UnityEngine.Vector2Int get_right()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Vector3Int
TYPE:  struct
TOKEN: 0x200014B
FIELDS:
  private           System.Int32                    m_X  // 0x10
  private           System.Int32                    m_Y  // 0x14
  private           System.Int32                    m_Z  // 0x18
  private   static readonly UnityEngine.Vector3Int          s_Zero  // 0x0
  private   static readonly UnityEngine.Vector3Int          s_One  // 0xC
  private   static readonly UnityEngine.Vector3Int          s_Up  // 0x18
  private   static readonly UnityEngine.Vector3Int          s_Down  // 0x24
  private   static readonly UnityEngine.Vector3Int          s_Left  // 0x30
  private   static readonly UnityEngine.Vector3Int          s_Right  // 0x3C
  private   static readonly UnityEngine.Vector3Int          s_Forward  // 0x48
  private   static readonly UnityEngine.Vector3Int          s_Back  // 0x54
METHODS:
  System.Int32 get_x()
  System.Void set_x(System.Int32 value)
  System.Int32 get_y()
  System.Void set_y(System.Int32 value)
  System.Int32 get_z()
  System.Void set_z(System.Int32 value)
  System.Void .ctor(System.Int32 x, System.Int32 y)
  System.Void .ctor(System.Int32 x, System.Int32 y, System.Int32 z)
  System.Int32 get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, System.Int32 value)
  System.Single get_magnitude()
  System.Single Distance(UnityEngine.Vector3Int a, UnityEngine.Vector3Int b)
  UnityEngine.Vector3Int Min(UnityEngine.Vector3Int lhs, UnityEngine.Vector3Int rhs)
  UnityEngine.Vector3Int Max(UnityEngine.Vector3Int lhs, UnityEngine.Vector3Int rhs)
  UnityEngine.Vector3 op_Implicit(UnityEngine.Vector3Int v)
  UnityEngine.Vector3Int op_Addition(UnityEngine.Vector3Int a, UnityEngine.Vector3Int b)
  UnityEngine.Vector3Int op_Subtraction(UnityEngine.Vector3Int a, UnityEngine.Vector3Int b)
  UnityEngine.Vector3Int op_Multiply(UnityEngine.Vector3Int a, System.Int32 b)
  UnityEngine.Vector3Int op_Multiply(System.Int32 a, UnityEngine.Vector3Int b)
  UnityEngine.Vector3Int op_Division(UnityEngine.Vector3Int a, System.Int32 b)
  System.Boolean op_Equality(UnityEngine.Vector3Int lhs, UnityEngine.Vector3Int rhs)
  System.Boolean op_Inequality(UnityEngine.Vector3Int lhs, UnityEngine.Vector3Int rhs)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(UnityEngine.Vector3Int other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  UnityEngine.Vector3Int get_zero()
  UnityEngine.Vector3Int get_one()
  UnityEngine.Vector3Int get_up()
  UnityEngine.Vector3Int get_down()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Vector4
TYPE:  struct
TOKEN: 0x200014C
FIELDS:
  public    static  System.Single                   kEpsilon  // 0x0
  public            System.Single                   x  // 0x10
  public            System.Single                   y  // 0x14
  public            System.Single                   z  // 0x18
  public            System.Single                   w  // 0x1C
  private   static readonly UnityEngine.Vector4             zeroVector  // 0x0
  private   static readonly UnityEngine.Vector4             oneVector  // 0x10
  private   static readonly UnityEngine.Vector4             positiveInfinityVector  // 0x20
  private   static readonly UnityEngine.Vector4             negativeInfinityVector  // 0x30
METHODS:
  System.Single get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, System.Single value)
  System.Void .ctor(System.Single x, System.Single y, System.Single z, System.Single w)
  System.Void .ctor(System.Single x, System.Single y, System.Single z)
  System.Void .ctor(System.Single x, System.Single y)
  System.Void Set(System.Single newX, System.Single newY, System.Single newZ, System.Single newW)
  UnityEngine.Vector4 Lerp(UnityEngine.Vector4 a, UnityEngine.Vector4 b, System.Single t)
  UnityEngine.Vector4 LerpUnclamped(UnityEngine.Vector4 a, UnityEngine.Vector4 b, System.Single t)
  UnityEngine.Vector4 MoveTowards(UnityEngine.Vector4 current, UnityEngine.Vector4 target, System.Single maxDistanceDelta)
  UnityEngine.Vector4 Scale(UnityEngine.Vector4 a, UnityEngine.Vector4 b)
  System.Void Scale(UnityEngine.Vector4 scale)
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(UnityEngine.Vector4 other)
  UnityEngine.Vector4 Normalize(UnityEngine.Vector4 a)
  System.Void Normalize()
  UnityEngine.Vector4 get_normalized()
  System.Single Dot(UnityEngine.Vector4 a, UnityEngine.Vector4 b)
  UnityEngine.Vector4 Project(UnityEngine.Vector4 a, UnityEngine.Vector4 b)
  System.Single Distance(UnityEngine.Vector4 a, UnityEngine.Vector4 b)
  System.Single Magnitude(UnityEngine.Vector4 a)
  System.Single get_magnitude()
  System.Single get_sqrMagnitude()
  UnityEngine.Vector4 Min(UnityEngine.Vector4 lhs, UnityEngine.Vector4 rhs)
  UnityEngine.Vector4 Max(UnityEngine.Vector4 lhs, UnityEngine.Vector4 rhs)
  UnityEngine.Vector4 get_zero()
  UnityEngine.Vector4 get_one()
  UnityEngine.Vector4 get_positiveInfinity()
  UnityEngine.Vector4 get_negativeInfinity()
  UnityEngine.Vector4 op_Addition(UnityEngine.Vector4 a, UnityEngine.Vector4 b)
  UnityEngine.Vector4 op_Subtraction(UnityEngine.Vector4 a, UnityEngine.Vector4 b)
  UnityEngine.Vector4 op_UnaryNegation(UnityEngine.Vector4 a)
  UnityEngine.Vector4 op_Multiply(UnityEngine.Vector4 a, System.Single d)
  UnityEngine.Vector4 op_Multiply(System.Single d, UnityEngine.Vector4 a)
  UnityEngine.Vector4 op_Division(UnityEngine.Vector4 a, System.Single d)
  System.Boolean op_Equality(UnityEngine.Vector4 lhs, UnityEngine.Vector4 rhs)
  System.Boolean op_Inequality(UnityEngine.Vector4 lhs, UnityEngine.Vector4 rhs)
  UnityEngine.Vector4 op_Implicit(UnityEngine.Vector3 v)
  UnityEngine.Vector3 op_Implicit(UnityEngine.Vector4 v)
  UnityEngine.Vector4 op_Implicit(UnityEngine.Vector2 v)
  UnityEngine.Vector2 op_Implicit(UnityEngine.Vector4 v)
  System.String ToString()
  System.String ToString(System.String format)
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  System.Single SqrMagnitude(UnityEngine.Vector4 a)
  System.Single SqrMagnitude()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Vector4Int
TYPE:  struct
TOKEN: 0x200014D
FIELDS:
  private           System.Int32                    m_X  // 0x10
  private           System.Int32                    m_Y  // 0x14
  private           System.Int32                    m_Z  // 0x18
  private           System.Int32                    m_W  // 0x1C
  private   static readonly UnityEngine.Vector4Int          s_Zero  // 0x0
  private   static readonly UnityEngine.Vector4Int          s_One  // 0x10
METHODS:
  System.Int32 get_x()
  System.Void set_x(System.Int32 value)
  System.Int32 get_y()
  System.Void set_y(System.Int32 value)
  System.Int32 get_z()
  System.Void set_z(System.Int32 value)
  System.Int32 get_w()
  System.Void set_w(System.Int32 value)
  System.Void .ctor(System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 w)
  System.Boolean op_Equality(UnityEngine.Vector4Int lhs, UnityEngine.Vector4Int rhs)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(UnityEngine.Vector4Int other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.IPlayerEditorConnectionNative
TYPE:  interface
TOKEN: 0x200014E
FIELDS:
METHODS:
  System.Void Initialize()
  System.Void DisconnectAll()
  System.Void SendMessage(System.Guid messageId, System.Byte[] data, System.Int32 playerId)
  System.Boolean TrySendMessage(System.Guid messageId, System.Byte[] data, System.Int32 playerId)
  System.Void Poll()
  System.Void RegisterInternal(System.Guid messageId)
  System.Void UnregisterInternal(System.Guid messageId)
  System.Boolean IsConnected()
END_CLASS

CLASS: UnityEngine.PlayerConnectionInternal
TYPE:  class
TOKEN: 0x200014F
FIELDS:
METHODS:
  System.Void UnityEngine.IPlayerEditorConnectionNative.SendMessage(System.Guid messageId, System.Byte[] data, System.Int32 playerId)
  System.Boolean UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(System.Guid messageId, System.Byte[] data, System.Int32 playerId)
  System.Void UnityEngine.IPlayerEditorConnectionNative.Poll()
  System.Void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(System.Guid messageId)
  System.Void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(System.Guid messageId)
  System.Void UnityEngine.IPlayerEditorConnectionNative.Initialize()
  System.Boolean UnityEngine.IPlayerEditorConnectionNative.IsConnected()
  System.Void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll()
  System.Boolean IsConnected()
  System.Void Initialize()
  System.Void RegisterInternal(System.String messageId)
  System.Void UnregisterInternal(System.String messageId)
  System.Void SendMessage(System.String messageId, System.Byte[] data, System.Int32 playerId)
  System.Boolean TrySendMessage(System.String messageId, System.Byte[] data, System.Int32 playerId)
  System.Void PollInternal()
  System.Void DisconnectAll()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.PlayerPrefsException
TYPE:  class
TOKEN: 0x2000150
EXTENDS: Exception
FIELDS:
METHODS:
  System.Void .ctor(System.String error)
END_CLASS

CLASS: UnityEngine.PlayerPrefs
TYPE:  class
TOKEN: 0x2000151
FIELDS:
METHODS:
  System.Boolean TrySetInt(System.String key, System.Int32 value)
  System.Boolean TrySetFloat(System.String key, System.Single value)
  System.Boolean TrySetSetString(System.String key, System.String value)
  System.Void SetInt(System.String key, System.Int32 value)
  System.Int32 GetInt(System.String key, System.Int32 defaultValue)
  System.Int32 GetInt(System.String key)
  System.Void SetFloat(System.String key, System.Single value)
  System.Single GetFloat(System.String key, System.Single defaultValue)
  System.Single GetFloat(System.String key)
  System.Void SetString(System.String key, System.String value)
  System.String GetString(System.String key, System.String defaultValue)
  System.String GetString(System.String key)
  System.Boolean HasKey(System.String key)
  System.Void DeleteKey(System.String key)
  System.Void DeleteAll()
  System.Void Save()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.PropertyAttribute
TYPE:  class
TOKEN: 0x2000152
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.ContextMenuItemAttribute
TYPE:  class
TOKEN: 0x2000153
EXTENDS: PropertyAttribute
FIELDS:
  public    readonly System.String                   name  // 0x10
  public    readonly System.String                   function  // 0x18
METHODS:
  System.Void .ctor(System.String name, System.String function)
END_CLASS

CLASS: UnityEngine.InspectorNameAttribute
TYPE:  class
TOKEN: 0x2000154
EXTENDS: PropertyAttribute
FIELDS:
  public    readonly System.String                   displayName  // 0x10
METHODS:
  System.Void .ctor(System.String displayName)
END_CLASS

CLASS: UnityEngine.TooltipAttribute
TYPE:  class
TOKEN: 0x2000155
EXTENDS: PropertyAttribute
FIELDS:
  public    readonly System.String                   tooltip  // 0x10
METHODS:
  System.Void .ctor(System.String tooltip)
END_CLASS

CLASS: UnityEngine.SpaceAttribute
TYPE:  class
TOKEN: 0x2000156
EXTENDS: PropertyAttribute
FIELDS:
  public    readonly System.Single                   height  // 0x10
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Single height)
END_CLASS

CLASS: UnityEngine.HeaderAttribute
TYPE:  class
TOKEN: 0x2000157
EXTENDS: PropertyAttribute
FIELDS:
  public    readonly System.String                   header  // 0x10
METHODS:
  System.Void .ctor(System.String header)
END_CLASS

CLASS: UnityEngine.RangeAttribute
TYPE:  class
TOKEN: 0x2000158
EXTENDS: PropertyAttribute
FIELDS:
  public    readonly System.Single                   min  // 0x10
  public    readonly System.Single                   max  // 0x14
METHODS:
  System.Void .ctor(System.Single min, System.Single max)
END_CLASS

CLASS: UnityEngine.MinAttribute
TYPE:  class
TOKEN: 0x2000159
EXTENDS: PropertyAttribute
FIELDS:
  public    readonly System.Single                   min  // 0x10
METHODS:
  System.Void .ctor(System.Single min)
END_CLASS

CLASS: UnityEngine.MultilineAttribute
TYPE:  class
TOKEN: 0x200015A
EXTENDS: PropertyAttribute
FIELDS:
  public    readonly System.Int32                    lines  // 0x10
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Int32 lines)
END_CLASS

CLASS: UnityEngine.TextAreaAttribute
TYPE:  class
TOKEN: 0x200015B
EXTENDS: PropertyAttribute
FIELDS:
  public    readonly System.Int32                    minLines  // 0x10
  public    readonly System.Int32                    maxLines  // 0x14
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Int32 minLines, System.Int32 maxLines)
END_CLASS

CLASS: UnityEngine.ColorUsageAttribute
TYPE:  class
TOKEN: 0x200015C
EXTENDS: PropertyAttribute
FIELDS:
  public    readonly System.Boolean                  showAlpha  // 0x10
  public    readonly System.Boolean                  hdr  // 0x11
  public    readonly System.Single                   minBrightness  // 0x14
  public    readonly System.Single                   maxBrightness  // 0x18
  public    readonly System.Single                   minExposureValue  // 0x1C
  public    readonly System.Single                   maxExposureValue  // 0x20
METHODS:
  System.Void .ctor(System.Boolean showAlpha)
  System.Void .ctor(System.Boolean showAlpha, System.Boolean hdr)
END_CLASS

CLASS: UnityEngine.PropertyNameUtils
TYPE:  class
TOKEN: 0x200015D
FIELDS:
METHODS:
  UnityEngine.PropertyName PropertyNameFromString(System.String name)
  System.Void PropertyNameFromString_Injected(System.String name, UnityEngine.PropertyName& ret)
END_CLASS

CLASS: UnityEngine.PropertyName
TYPE:  struct
TOKEN: 0x200015E
FIELDS:
  private           System.Int32                    id  // 0x10
METHODS:
  System.Void .ctor(System.String name)
  System.Void .ctor(UnityEngine.PropertyName other)
  System.Boolean IsNullOrEmpty(UnityEngine.PropertyName prop)
  System.Boolean op_Equality(UnityEngine.PropertyName lhs, UnityEngine.PropertyName rhs)
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(UnityEngine.PropertyName other)
  UnityEngine.PropertyName op_Implicit(System.String name)
  System.String ToString()
END_CLASS

CLASS: UnityEngine.Random
TYPE:  class
TOKEN: 0x200015F
FIELDS:
METHODS:
  System.Void InitState(System.Int32 seed)
  UnityEngine.Random.State get_state()
  System.Void set_state(UnityEngine.Random.State value)
  System.Single Range(System.Single minInclusive, System.Single maxInclusive)
  System.Int32 Range(System.Int32 minInclusive, System.Int32 maxExclusive)
  System.Int32 RandomRangeInt(System.Int32 minInclusive, System.Int32 maxExclusive)
  System.Single get_value()
  UnityEngine.Vector3 get_insideUnitSphere()
  System.Void GetRandomUnitCircle(UnityEngine.Vector2& output)
  UnityEngine.Vector2 get_insideUnitCircle()
  UnityEngine.Quaternion get_rotation()
  UnityEngine.Color ColorHSV()
  UnityEngine.Color ColorHSV(System.Single hueMin, System.Single hueMax, System.Single saturationMin, System.Single saturationMax, System.Single valueMin, System.Single valueMax, System.Single alphaMin, System.Single alphaMax)
  System.Void get_state_Injected(UnityEngine.Random.State& ret)
  System.Void set_state_Injected(UnityEngine.Random.State& value)
  System.Void get_insideUnitSphere_Injected(UnityEngine.Vector3& ret)
  System.Void get_rotation_Injected(UnityEngine.Quaternion& ret)
END_CLASS

CLASS: UnityEngine.ResourceRequest
TYPE:  class
TOKEN: 0x2000161
EXTENDS: AsyncOperation
FIELDS:
  private           System.String                   m_Path  // 0x20
  private           System.Type                     m_Type  // 0x28
METHODS:
  UnityEngine.Object GetResult()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.ResourcesAPIInternal
TYPE:  class
TOKEN: 0x2000162
FIELDS:
METHODS:
  UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type)
  UnityEngine.Shader FindShaderByName(System.String name)
  UnityEngine.Object Load(System.String path, System.Type systemTypeInstance)
  UnityEngine.Object[] LoadAll(System.String path, System.Type systemTypeInstance)
  UnityEngine.ResourceRequest LoadAsyncInternal(System.String path, System.Type type)
  System.Void UnloadAsset(UnityEngine.Object assetToUnload)
END_CLASS

CLASS: UnityEngine.ResourcesAPI
TYPE:  class
TOKEN: 0x2000163
FIELDS:
  private   static  UnityEngine.ResourcesAPI        s_DefaultAPI  // 0x0
  private   static  UnityEngine.ResourcesAPI        <overrideAPI>k__BackingField  // 0x8
METHODS:
  UnityEngine.ResourcesAPI get_ActiveAPI()
  UnityEngine.ResourcesAPI get_overrideAPI()
  System.Void .ctor()
  UnityEngine.Object[] FindObjectsOfTypeAll(System.Type systemTypeInstance)
  UnityEngine.Shader FindShaderByName(System.String name)
  UnityEngine.Object Load(System.String path, System.Type systemTypeInstance)
  UnityEngine.Object[] LoadAll(System.String path, System.Type systemTypeInstance)
  UnityEngine.ResourceRequest LoadAsync(System.String path, System.Type systemTypeInstance)
  System.Void UnloadAsset(UnityEngine.Object assetToUnload)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Resources
TYPE:  class
TOKEN: 0x2000164
FIELDS:
METHODS:
  T[] ConvertObjects(UnityEngine.Object[] rawObjects)
  UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type)
  T[] FindObjectsOfTypeAll()
  UnityEngine.Object Load(System.String path)
  T Load(System.String path)
  UnityEngine.Object Load(System.String path, System.Type systemTypeInstance)
  UnityEngine.ResourceRequest LoadAsync(System.String path)
  UnityEngine.ResourceRequest LoadAsync(System.String path)
  UnityEngine.ResourceRequest LoadAsync(System.String path, System.Type type)
  UnityEngine.Object[] LoadAll(System.String path, System.Type systemTypeInstance)
  UnityEngine.Object[] LoadAll(System.String path)
  T[] LoadAll(System.String path)
  UnityEngine.Object GetBuiltinResource(System.Type type, System.String path)
  T GetBuiltinResource(System.String path)
  System.Void UnloadAsset(UnityEngine.Object assetToUnload)
  System.Void UnloadAssetImplResourceManager(UnityEngine.Object assetToUnload)
  UnityEngine.AsyncOperation UnloadUnusedAssets()
  System.Void UpdateCPUAffinity(UnityEngine.Resources.ResourcesCPUAffinity affinity)
  UnityEngine.Object InstanceIDToObject(System.Int32 instanceID)
  System.Void InstanceIDToObjectList(System.IntPtr instanceIDs, System.Int32 instanceCount, System.Collections.Generic.List<UnityEngine.Object> objects)
  System.Void InstanceIDToObjectList(Unity.Collections.NativeArray<System.Int32> instanceIDs, System.Collections.Generic.List<UnityEngine.Object> objects)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.AsyncInstantiateOperation
TYPE:  class
TOKEN: 0x2000166
EXTENDS: AsyncOperation
FIELDS:
  private           UnityEngine.Object[]            m_Result  // 0x20
METHODS:
  UnityEngine.Object[] get_Result()
  System.Void WaitForCompletion()
  System.Void Cancel()
  System.Void set_IntegrationTimeMS(System.Single value)
  System.Void .ctor()
  System.Void SetIntegrationTimeMS(System.Single integrationTimeMS)
END_CLASS

CLASS: UnityEngine.AsyncInstantiateOperation`1
TYPE:  class
TOKEN: 0x2000167
EXTENDS: CustomYieldInstruction
FIELDS:
  private           UnityEngine.AsyncInstantiateOperationm_op  // 0x0
METHODS:
  System.Void .ctor(UnityEngine.AsyncInstantiateOperation op)
  System.Boolean get_keepWaiting()
  System.Boolean get_isDone()
  System.Void WaitForCompletion()
  System.Void Cancel()
  T[] get_Result()
END_CLASS

CLASS: UnityEngine.AsyncInstantiateOperationHelper
TYPE:  class
TOKEN: 0x2000168
FIELDS:
METHODS:
  System.Void SetAsyncInstantiateOperationResult(UnityEngine.AsyncInstantiateOperation op, UnityEngine.Object[] result)
END_CLASS

CLASS: UnityEngine.AsyncOperation
TYPE:  class
TOKEN: 0x2000169
EXTENDS: YieldInstruction
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
  private           System.Action<UnityEngine.AsyncOperation>m_completeCallback  // 0x18
METHODS:
  System.Void InternalDestroy(System.IntPtr ptr)
  System.Boolean get_isDone()
  System.Single get_progress()
  System.Int32 get_priority()
  System.Void set_priority(System.Int32 value)
  System.Boolean get_allowSceneActivation()
  System.Void set_allowSceneActivation(System.Boolean value)
  System.Boolean TryCancel()
  System.Void Finalize()
  System.Void InvokeCompletionEvent()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.AttributeHelperEngine
TYPE:  class
TOKEN: 0x200016A
FIELDS:
  public    static  UnityEngine.DisallowMultipleComponent[]_disallowMultipleComponentArray  // 0x0
  public    static  UnityEngine.ExecuteInEditMode[] _executeInEditModeArray  // 0x8
  public    static  UnityEngine.RequireComponent[]  _requireComponentArray  // 0x10
METHODS:
  System.Type GetParentTypeDisallowingMultipleInclusion(System.Type type)
  System.Type[] GetRequiredComponents(System.Type klass)
  System.Int32 GetExecuteMode(System.Type klass)
  System.Int32 CheckIsEditorScript(System.Type klass)
  System.Int32 GetDefaultExecutionOrderFor(System.Type klass)
  T GetCustomAttributeOfType(System.Type klass)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.DisallowMultipleComponent
TYPE:  class
TOKEN: 0x200016B
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.RequireComponent
TYPE:  class
TOKEN: 0x200016C
EXTENDS: Attribute
FIELDS:
  public            System.Type                     m_Type0  // 0x10
  public            System.Type                     m_Type1  // 0x18
  public            System.Type                     m_Type2  // 0x20
METHODS:
  System.Void .ctor(System.Type requiredComponent)
  System.Void .ctor(System.Type requiredComponent, System.Type requiredComponent2)
END_CLASS

CLASS: UnityEngine.AddComponentMenu
TYPE:  class
TOKEN: 0x200016D
EXTENDS: Attribute
FIELDS:
  private           System.String                   m_AddComponentMenu  // 0x10
  private           System.Int32                    m_Ordering  // 0x18
METHODS:
  System.Void .ctor(System.String menuName)
  System.Void .ctor(System.String menuName, System.Int32 order)
END_CLASS

CLASS: UnityEngine.CreateAssetMenuAttribute
TYPE:  class
TOKEN: 0x200016E
EXTENDS: Attribute
FIELDS:
  private           System.String                   <menuName>k__BackingField  // 0x10
  private           System.String                   <fileName>k__BackingField  // 0x18
  private           System.Int32                    <order>k__BackingField  // 0x20
METHODS:
  System.Void set_menuName(System.String value)
  System.Void set_fileName(System.String value)
  System.Void set_order(System.Int32 value)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.ContextMenu
TYPE:  class
TOKEN: 0x200016F
EXTENDS: Attribute
FIELDS:
  public    readonly System.String                   menuItem  // 0x10
  public    readonly System.Boolean                  validate  // 0x18
  public    readonly System.Int32                    priority  // 0x1C
METHODS:
  System.Void .ctor(System.String itemName)
  System.Void .ctor(System.String itemName, System.Boolean isValidateFunction)
  System.Void .ctor(System.String itemName, System.Boolean isValidateFunction, System.Int32 priority)
END_CLASS

CLASS: UnityEngine.ExecuteInEditMode
TYPE:  class
TOKEN: 0x2000170
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.ExecuteAlways
TYPE:  class
TOKEN: 0x2000171
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.HideInInspector
TYPE:  class
TOKEN: 0x2000172
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.HelpURLAttribute
TYPE:  class
TOKEN: 0x2000173
EXTENDS: Attribute
FIELDS:
  private   readonly System.String                   m_Url  // 0x10
  private   readonly System.Boolean                  m_Dispatcher  // 0x18
  private   readonly System.String                   m_DispatchingFieldName  // 0x20
METHODS:
  System.Void .ctor(System.String url)
  System.String get_URL()
END_CLASS

CLASS: UnityEngine.DefaultExecutionOrder
TYPE:  class
TOKEN: 0x2000174
EXTENDS: Attribute
FIELDS:
  private           System.Int32                    m_Order  // 0x10
METHODS:
  System.Void .ctor(System.Int32 order)
  System.Int32 get_order()
END_CLASS

CLASS: UnityEngine.AssemblyIsEditorAssembly
TYPE:  class
TOKEN: 0x2000175
EXTENDS: Attribute
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.ExcludeFromPresetAttribute
TYPE:  class
TOKEN: 0x2000176
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Behaviour
TYPE:  class
TOKEN: 0x2000177
EXTENDS: Component
FIELDS:
METHODS:
  System.Boolean get_enabled()
  System.Void set_enabled(System.Boolean value)
  System.Boolean get_isActiveAndEnabled()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.CastHelper`1
TYPE:  struct
TOKEN: 0x2000178
FIELDS:
  public            T                               t  // 0x0
  public            System.IntPtr                   onePointerFurtherThanT  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.ClassLibraryInitializer
TYPE:  class
TOKEN: 0x2000179
FIELDS:
METHODS:
  System.Void Init()
END_CLASS

CLASS: UnityEngine.Component
TYPE:  class
TOKEN: 0x200017A
FIELDS:
METHODS:
  UnityEngine.Transform get_transform()
  UnityEngine.GameObject get_gameObject()
  UnityEngine.Component GetComponent(System.Type type)
  UnityEngine.Component GetComponent(System.Type type, System.Int32 multiComponentIndex)
  T GetComponent()
  T GetComponent(System.Int32 multiComponentIndex)
  System.Void GetComponentFastPath(System.Type type, System.Int32 multiComponentIndex, System.IntPtr resultValue)
  System.Boolean TryGetComponent(System.Type type, UnityEngine.Component& component)
  System.Boolean TryGetComponent(T& component)
  UnityEngine.Component GetComponent(System.String type)
  UnityEngine.Component GetComponentInChildren(System.Type t, System.Boolean includeInactive)
  UnityEngine.Component GetComponentInChildren(System.Type t)
  T GetComponentInChildren(System.Boolean includeInactive)
  T GetComponentInChildren()
  UnityEngine.Component[] GetComponentsInChildren(System.Type t, System.Boolean includeInactive)
  UnityEngine.Component[] GetComponentsInChildren(System.Type t)
  T[] GetComponentsInChildren(System.Boolean includeInactive)
  System.Void GetComponentsInChildren(System.Boolean includeInactive, System.Collections.Generic.List<T> result)
  T[] GetComponentsInChildren()
  System.Void GetComponentsInChildren(System.Collections.Generic.List<T> results)
  UnityEngine.Component GetComponentInParent(System.Type t, System.Boolean includeInactive)
  UnityEngine.Component GetComponentInParent(System.Type t)
  T GetComponentInParent(System.Boolean includeInactive)
  T GetComponentInParent()
  UnityEngine.Component[] GetComponentsInParent(System.Type t, System.Boolean includeInactive)
  UnityEngine.Component[] GetComponentsInParent(System.Type t)
  T[] GetComponentsInParent(System.Boolean includeInactive)
  System.Void GetComponentsInParent(System.Boolean includeInactive, System.Collections.Generic.List<T> results)
  T[] GetComponentsInParent()
  UnityEngine.Component[] GetComponents(System.Type type)
  System.Void GetComponentsForListInternal(System.Type searchType, System.Object resultList)
  System.Void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results)
  System.Void GetComponents(System.Collections.Generic.List<T> results)
  System.String get_tag()
  System.Void set_tag(System.String value)
  T[] GetComponents()
  System.Boolean CompareTag(System.String tag)
  System.Void SendMessageUpwards(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options)
  System.Void SendMessageUpwards(System.String methodName, System.Object value)
  System.Void SendMessageUpwards(System.String methodName)
  System.Void SendMessageUpwards(System.String methodName, UnityEngine.SendMessageOptions options)
  System.Void SendMessage(System.String methodName, System.Object value)
  System.Void SendMessage(System.String methodName)
  System.Void SendMessage(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options)
  System.Void SendMessage(System.String methodName, UnityEngine.SendMessageOptions options)
  System.Void BroadcastMessage(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options)
  System.Void BroadcastMessage(System.String methodName, System.Object parameter)
  System.Void BroadcastMessage(System.String methodName)
  System.Void BroadcastMessage(System.String methodName, UnityEngine.SendMessageOptions options)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Coroutine
TYPE:  class
TOKEN: 0x200017B
EXTENDS: YieldInstruction
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
METHODS:
  System.Void .ctor()
  System.Void Finalize()
  System.Void ReleaseCoroutine(System.IntPtr ptr)
END_CLASS

CLASS: UnityEngine.SetupCoroutine
TYPE:  class
TOKEN: 0x200017C
FIELDS:
METHODS:
  System.Void InvokeMoveNext(System.Collections.IEnumerator enumerator, System.IntPtr returnValueAddress)
  System.Object InvokeMember(System.Object behaviour, System.String name, System.Object variable)
END_CLASS

CLASS: UnityEngine.CustomYieldInstruction
TYPE:  class
TOKEN: 0x200017D
FIELDS:
METHODS:
  System.Boolean get_keepWaiting()
  System.Object get_Current()
  System.Boolean MoveNext()
  System.Void Reset()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.ExcludeFromObjectFactoryAttribute
TYPE:  class
TOKEN: 0x200017E
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.ExtensionOfNativeClassAttribute
TYPE:  class
TOKEN: 0x200017F
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.FailedToLoadScriptObject
TYPE:  class
TOKEN: 0x2000180
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.PlatformLayers
TYPE:  struct
TOKEN: 0x2000181
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.PlatformLayers      None  // 0x0
  public    static  UnityEngine.PlatformLayers      PC  // 0x0
  public    static  UnityEngine.PlatformLayers      Mobile  // 0x0
  public    static  UnityEngine.PlatformLayers      Other  // 0x0
  public    static  UnityEngine.PlatformLayers      AllPlatforms  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.GameObject
TYPE:  class
TOKEN: 0x2000182
FIELDS:
METHODS:
  UnityEngine.GameObject CreatePrimitive(UnityEngine.PrimitiveType type)
  T GetComponent()
  T GetComponent(System.Int32 multiComponentIndex)
  UnityEngine.Component GetComponent(System.Type type)
  UnityEngine.Component GetComponent(System.Type type, System.Int32 multiComponentIndex)
  UnityEngine.Component GetComponentInternal(System.Type type)
  System.Void GetComponentFastPath(System.Type type, System.Int32 multiComponentIndex, System.IntPtr resultValue)
  UnityEngine.Component GetComponentByName(System.String type)
  UnityEngine.Component GetComponent(System.String type)
  UnityEngine.Component GetComponentInChildren(System.Type type, System.Boolean includeInactive)
  UnityEngine.Component GetComponentInChildren(System.Type type)
  T GetComponentInChildren()
  T GetComponentInChildren(System.Boolean includeInactive)
  UnityEngine.Component GetComponentInParent(System.Type type, System.Boolean includeInactive)
  UnityEngine.Component GetComponentInParent(System.Type type)
  T GetComponentInParent()
  T GetComponentInParent(System.Boolean includeInactive)
  System.Array GetComponentsInternal(System.Type type, System.Boolean useSearchTypeAsArrayReturnType, System.Boolean recursive, System.Boolean includeInactive, System.Boolean reverse, System.Object resultList)
  UnityEngine.Component[] GetComponents(System.Type type)
  T[] GetComponents()
  System.Void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results)
  System.Void GetComponents(System.Collections.Generic.List<T> results)
  UnityEngine.Component[] GetComponentsInChildren(System.Type type)
  UnityEngine.Component[] GetComponentsInChildren(System.Type type, System.Boolean includeInactive)
  T[] GetComponentsInChildren(System.Boolean includeInactive)
  System.Void GetComponentsInChildren(System.Boolean includeInactive, System.Collections.Generic.List<T> results)
  T[] GetComponentsInChildren()
  System.Void GetComponentsInChildren(System.Collections.Generic.List<T> results)
  UnityEngine.Component[] GetComponentsInParent(System.Type type)
  UnityEngine.Component[] GetComponentsInParent(System.Type type, System.Boolean includeInactive)
  System.Void GetComponentsInParent(System.Boolean includeInactive, System.Collections.Generic.List<T> results)
  T[] GetComponentsInParent(System.Boolean includeInactive)
  T[] GetComponentsInParent()
  System.Boolean TryGetComponent(T& component)
  System.Boolean TryGetComponent(System.Int32 multiComponentIndex, T& component)
  System.Boolean TryGetComponent(System.Type type, UnityEngine.Component& component)
  System.Boolean TryGetComponent(System.Type type, System.Int32 multiComponentIndex, UnityEngine.Component& component)
  UnityEngine.Component TryGetComponentInternal(System.Type type)
  System.Void TryGetComponentFastPath(System.Type type, System.Int32 multiComponentIndex, System.IntPtr resultValue)
  UnityEngine.GameObject FindWithTag(System.String tag)
  System.Void SendMessageUpwards(System.String methodName, UnityEngine.SendMessageOptions options)
  System.Void SendMessage(System.String methodName, UnityEngine.SendMessageOptions options)
  System.Void BroadcastMessage(System.String methodName, UnityEngine.SendMessageOptions options)
  UnityEngine.Component AddComponentInternal(System.String className)
  UnityEngine.Component Internal_AddComponentWithType(System.Type componentType)
  UnityEngine.Component AddComponent(System.Type componentType)
  T AddComponent()
  UnityEngine.Transform get_transform()
  System.Int32 get_layer()
  System.Void set_layer(System.Int32 value)
  System.Boolean SyncLayerRecursive(UnityEngine.GameObject source)
  System.Boolean SetLayerRecursive(System.Int32 layer)
  System.Int32 get_artTag()
  System.Void set_artTag(System.Int32 value)
  System.Boolean get_active()
  System.Void set_active(System.Boolean value)
  System.Void SetActive(System.Boolean value)
  System.Boolean get_activeSelf()
  System.Boolean get_activeInHierarchy()
  System.Void SetActiveRecursively(System.Boolean state)
  System.Boolean get_isStatic()
  System.Void set_isStatic(System.Boolean value)
  System.Boolean get_isStaticBatchable()
  System.String get_tag()
  System.Void set_tag(System.String value)
  System.Int32 get_tagInt()
  System.Void set_tagInt(System.Int32 value)
  System.Int32 GetTagInt(System.String tag)
  System.Boolean CompareTag(System.String tag)
  UnityEngine.GameObject FindGameObjectWithTag(System.String tag)
  UnityEngine.GameObject[] FindGameObjectsWithTag(System.String tag)
  System.String[] GetAllArtTagsStr()
  System.Int32[] GetAllArtTagsInt()
  System.Void SetArtTags(System.String[] tagStr, System.Int32[] tagInt)
  System.Void SendMessageUpwards(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options)
  System.Void SendMessageUpwards(System.String methodName, System.Object value)
  System.Void SendMessageUpwards(System.String methodName)
  System.Void SendMessage(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options)
  System.Void SendMessage(System.String methodName, System.Object value)
  System.Void SendMessage(System.String methodName)
  System.Void BroadcastMessage(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options)
  System.Void BroadcastMessage(System.String methodName, System.Object parameter)
  System.Void BroadcastMessage(System.String methodName)
  System.Void .ctor(System.String name)
  System.Void .ctor()
  System.Void .ctor(System.String name, System.Type[] components)
  System.Void Internal_CreateGameObject(UnityEngine.GameObject self, System.String name)
  UnityEngine.GameObject Find(System.String name)
  UnityEngine.SceneManagement.Scene get_scene()
  System.Boolean get_isInPreviewScene()
  System.UInt64 get_sceneCullingMask()
  UnityEngine.GameObject get_gameObject()
  System.Void get_scene_Injected(UnityEngine.SceneManagement.Scene& ret)
END_CLASS

CLASS: UnityEngine.LayerMask
TYPE:  struct
TOKEN: 0x2000183
FIELDS:
  private           System.Int32                    m_Mask  // 0x10
METHODS:
  System.Int32 op_Implicit(UnityEngine.LayerMask mask)
  UnityEngine.LayerMask op_Implicit(System.Int32 intVal)
  System.Int32 get_value()
  System.Void set_value(System.Int32 value)
  System.String LayerToName(System.Int32 layer)
  System.Int32 NameToLayer(System.String layerName)
  System.Int32 GetMask(System.String[] layerNames)
END_CLASS

CLASS: UnityEngine.ManagedStreamHelpers
TYPE:  class
TOKEN: 0x2000184
FIELDS:
METHODS:
  System.Void ValidateLoadFromStream(System.IO.Stream stream)
  System.Void ManagedStreamRead(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.IO.Stream stream, System.IntPtr returnValueAddress)
  System.Void ManagedStreamSeek(System.Int64 offset, System.UInt32 origin, System.IO.Stream stream, System.IntPtr returnValueAddress)
  System.Void ManagedStreamLength(System.IO.Stream stream, System.IntPtr returnValueAddress)
END_CLASS

CLASS: UnityEngine.MonoBehaviour
TYPE:  class
TOKEN: 0x2000185
EXTENDS: Behaviour
FIELDS:
METHODS:
  System.Boolean IsInvoking()
  System.Void CancelInvoke()
  System.Void Invoke(System.String methodName, System.Single time)
  System.Void InvokeRepeating(System.String methodName, System.Single time, System.Single repeatRate)
  System.Void CancelInvoke(System.String methodName)
  System.Boolean IsInvoking(System.String methodName)
  UnityEngine.Coroutine StartCoroutine(System.String methodName)
  UnityEngine.Coroutine StartCoroutine(System.String methodName, System.Object value)
  UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine)
  UnityEngine.Coroutine StartCoroutine_Auto(System.Collections.IEnumerator routine)
  System.Void StopCoroutine(System.Collections.IEnumerator routine)
  System.Void StopCoroutine(UnityEngine.Coroutine routine)
  System.Void StopCoroutine(System.String methodName)
  System.Void StopAllCoroutines()
  System.Boolean get_useGUILayout()
  System.Void set_useGUILayout(System.Boolean value)
  System.Void print(System.Object message)
  System.Void Internal_CancelInvokeAll(UnityEngine.MonoBehaviour self)
  System.Boolean Internal_IsInvokingAll(UnityEngine.MonoBehaviour self)
  System.Void InvokeDelayed(UnityEngine.MonoBehaviour self, System.String methodName, System.Single time, System.Single repeatRate)
  System.Void CancelInvoke(UnityEngine.MonoBehaviour self, System.String methodName)
  System.Boolean IsInvoking(UnityEngine.MonoBehaviour self, System.String methodName)
  System.Boolean IsObjectMonoBehaviour(UnityEngine.Object obj)
  UnityEngine.Coroutine StartCoroutineManaged(System.String methodName, System.Object value)
  UnityEngine.Coroutine StartCoroutineManaged2(System.Collections.IEnumerator enumerator)
  System.Void StopCoroutineManaged(UnityEngine.Coroutine routine)
  System.Void StopCoroutineFromEnumeratorManaged(System.Collections.IEnumerator routine)
  System.String GetScriptClassName()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.NoAllocHelpers
TYPE:  class
TOKEN: 0x2000186
FIELDS:
METHODS:
  System.Void ResizeList(System.Collections.Generic.List<T> list, System.Int32 size)
  System.Void EnsureListElemCount(System.Collections.Generic.List<T> list, System.Int32 count)
  System.Int32 SafeLength(System.Array values)
  System.Int32 SafeLength(System.Collections.Generic.List<T> values)
  T[] ExtractArrayFromListT(System.Collections.Generic.List<T> list)
  System.Void Internal_ResizeList(System.Object list, System.Int32 size)
  System.Array ExtractArrayFromList(System.Object list)
END_CLASS

CLASS: UnityEngine.PlatformSpecificParam`1
TYPE:  struct
TOKEN: 0x2000187
FIELDS:
  public            T                               defaultParam  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.RangeInt
TYPE:  struct
TOKEN: 0x2000188
FIELDS:
  public            System.Int32                    start  // 0x10
  public            System.Int32                    length  // 0x14
METHODS:
  System.Int32 get_end()
  System.Void .ctor(System.Int32 start, System.Int32 length)
END_CLASS

CLASS: UnityEngine.RuntimeInitializeLoadType
TYPE:  struct
TOKEN: 0x2000189
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.RuntimeInitializeLoadTypeAfterSceneLoad  // 0x0
  public    static  UnityEngine.RuntimeInitializeLoadTypeBeforeSceneLoad  // 0x0
  public    static  UnityEngine.RuntimeInitializeLoadTypeAfterAssembliesLoaded  // 0x0
  public    static  UnityEngine.RuntimeInitializeLoadTypeBeforeSplashScreen  // 0x0
  public    static  UnityEngine.RuntimeInitializeLoadTypeSubsystemRegistration  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.RuntimeInitializeOnLoadMethodAttribute
TYPE:  class
TOKEN: 0x200018A
EXTENDS: PreserveAttribute
FIELDS:
  private           UnityEngine.RuntimeInitializeLoadTypem_LoadType  // 0x10
METHODS:
  System.Void .ctor()
  System.Void .ctor(UnityEngine.RuntimeInitializeLoadType loadType)
  System.Void set_loadType(UnityEngine.RuntimeInitializeLoadType value)
END_CLASS

CLASS: UnityEngine.ScriptableObject
TYPE:  class
TOKEN: 0x200018B
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void SetDirty()
  UnityEngine.ScriptableObject CreateInstance(System.String className)
  UnityEngine.ScriptableObject CreateInstance(System.Type type)
  T CreateInstance()
  UnityEngine.ScriptableObject CreateInstance(System.Type type, System.Action<UnityEngine.ScriptableObject> initialize)
  System.Void CreateScriptableObject(UnityEngine.ScriptableObject self)
  UnityEngine.ScriptableObject CreateScriptableObjectInstanceFromName(System.String className)
  UnityEngine.ScriptableObject CreateScriptableObjectInstanceFromType(System.Type type, System.Boolean applyDefaultsAndReset)
  System.Void ResetAndApplyDefaultInstances(UnityEngine.Object obj)
END_CLASS

CLASS: UnityEngine.ScriptingRuntime
TYPE:  class
TOKEN: 0x200018C
FIELDS:
METHODS:
  System.String[] GetAllUserAssemblies()
END_CLASS

CLASS: UnityEngine.ScriptingUtility
TYPE:  class
TOKEN: 0x200018D
FIELDS:
METHODS:
  System.Boolean IsManagedCodeWorking()
END_CLASS

CLASS: UnityEngine.SelectionBaseAttribute
TYPE:  class
TOKEN: 0x200018F
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.StackTraceUtility
TYPE:  class
TOKEN: 0x2000190
FIELDS:
  private   static  System.String                   projectFolder  // 0x0
METHODS:
  System.Void SetProjectFolder(System.String folder)
  System.String ExtractStackTrace()
  System.Void ExtractStringFromExceptionInternal(System.Object exceptiono, System.String& message, System.String& stackTrace)
  System.String ExtractFormattedStackTrace(System.Diagnostics.StackTrace stackTrace)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UnityException
TYPE:  class
TOKEN: 0x2000191
EXTENDS: Exception
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String message)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
END_CLASS

CLASS: UnityEngine.UnassignedReferenceException
TYPE:  class
TOKEN: 0x2000192
EXTENDS: Exception
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String message)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
END_CLASS

CLASS: UnityEngine.TextAsset
TYPE:  class
TOKEN: 0x2000193
FIELDS:
METHODS:
  System.Byte[] get_bytes()
  System.Byte[] GetPreviewBytes(System.Int32 maxByteCount)
  System.Void Internal_CreateInstance(UnityEngine.TextAsset self, System.String text)
  System.IntPtr GetDataPtr()
  System.Int64 GetDataSize()
  System.String get_text()
  System.Int64 get_dataSize()
  System.String ToString()
  System.Void .ctor()
  System.Void .ctor(System.String text)
  System.Void .ctor(UnityEngine.TextAsset.CreateOptions options, System.String text)
  Unity.Collections.NativeArray<T> GetData()
  System.String GetPreview(System.Int32 maxChars)
  System.String DecodeString(System.Byte[] bytes)
END_CLASS

CLASS: UnityEngine.TrackedReference
TYPE:  class
TOKEN: 0x2000196
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
METHODS:
  System.Void .ctor()
  System.Boolean op_Equality(UnityEngine.TrackedReference x, UnityEngine.TrackedReference y)
  System.Boolean op_Inequality(UnityEngine.TrackedReference x, UnityEngine.TrackedReference y)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.Boolean op_Implicit(UnityEngine.TrackedReference exists)
END_CLASS

CLASS: UnityEngine.UnhandledExceptionHandler
TYPE:  class
TOKEN: 0x2000197
FIELDS:
METHODS:
  System.Void RegisterUECatcher()
END_CLASS

CLASS: UnityEngine.UnityAPICompatibilityVersionAttribute
TYPE:  class
TOKEN: 0x2000199
EXTENDS: Attribute
FIELDS:
  private           System.String                   _version  // 0x10
  private           System.String[]                 _configurationAssembliesHashes  // 0x18
METHODS:
  System.Void .ctor(System.String version, System.String[] configurationAssembliesHashes)
END_CLASS

CLASS: UnityEngine.HideFlags
TYPE:  struct
TOKEN: 0x200019A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HideFlags           None  // 0x0
  public    static  UnityEngine.HideFlags           HideInHierarchy  // 0x0
  public    static  UnityEngine.HideFlags           HideInInspector  // 0x0
  public    static  UnityEngine.HideFlags           DontSaveInEditor  // 0x0
  public    static  UnityEngine.HideFlags           NotEditable  // 0x0
  public    static  UnityEngine.HideFlags           DontSaveInBuild  // 0x0
  public    static  UnityEngine.HideFlags           DontUnloadUnusedAsset  // 0x0
  public    static  UnityEngine.HideFlags           DontSave  // 0x0
  public    static  UnityEngine.HideFlags           HideAndDontSave  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.FindObjectsSortMode
TYPE:  struct
TOKEN: 0x200019B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.FindObjectsSortMode None  // 0x0
  public    static  UnityEngine.FindObjectsSortMode InstanceID  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.FindObjectsInactive
TYPE:  struct
TOKEN: 0x200019C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.FindObjectsInactive Exclude  // 0x0
  public    static  UnityEngine.FindObjectsInactive Include  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Object
TYPE:  class
TOKEN: 0x200019D
FIELDS:
  private           System.IntPtr                   m_CachedPtr  // 0x10
  private   static  System.Int32                    OffsetOfInstanceIDInCPlusPlusObject  // 0x0
  private   static  System.String                   objectIsNullMessage  // 0x0
  private   static  System.String                   cloneDestroyedMessage  // 0x0
METHODS:
  System.Int32 GetInstanceID()
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object other)
  System.Boolean op_Implicit(UnityEngine.Object exists)
  System.Boolean CompareBaseObjects(UnityEngine.Object lhs, UnityEngine.Object rhs)
  System.Void EnsureRunningOnMainThread()
  System.Boolean IsNativeObjectAlive(UnityEngine.Object o)
  System.IntPtr GetCachedPtr()
  System.String get_name()
  System.Void set_name(System.String value)
  UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, UnityEngine.Transform parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, System.Int32 count, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, System.Int32 count, UnityEngine.Transform parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  T InstantiateAsyncImmediately(T original, UnityEngine.Transform parent)
  T InstantiateAsyncImmediately(T original, UnityEngine.Transform parent, System.Boolean worldPositionStays)
  System.Int32 GetNameHashCode()
  System.Int32 GetNameHashCode(System.String name)
  System.Int32 GetNameHashCode(System.Byte* name)
  System.Void GetNameNoAlloc(System.String name)
  System.Boolean CompareName(System.String name)
  System.Boolean NameContains(System.String substring)
  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
  UnityEngine.Object Instantiate(UnityEngine.Object original)
  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent)
  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent, System.Boolean instantiateInWorldSpace)
  T Instantiate(T original)
  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
  T Instantiate(T original, UnityEngine.Transform parent)
  T Instantiate(T original, UnityEngine.Transform parent, System.Boolean worldPositionStays)
  System.Void Destroy(UnityEngine.Object obj, System.Single t)
  System.Void Destroy(UnityEngine.Object obj)
  System.Void DestroyImmediate(UnityEngine.Object obj, System.Boolean allowDestroyingAssets)
  System.Void DestroyImmediate(UnityEngine.Object obj)
  UnityEngine.Object[] FindObjectsOfType(System.Type type)
  UnityEngine.Object[] FindObjectsOfType(System.Type type, System.Boolean includeInactive)
  UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsSortMode sortMode)
  UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode)
  System.Void DontDestroyOnLoad(UnityEngine.Object target)
  UnityEngine.HideFlags get_hideFlags()
  System.Void set_hideFlags(UnityEngine.HideFlags value)
  System.Void DestroyObject(UnityEngine.Object obj, System.Single t)
  System.Void DestroyObject(UnityEngine.Object obj)
  UnityEngine.Object[] FindSceneObjectsOfType(System.Type type)
  UnityEngine.Object[] FindObjectsOfTypeIncludingAssets(System.Type type)
  T[] FindObjectsOfType()
  T[] FindObjectsByType(UnityEngine.FindObjectsSortMode sortMode)
  T[] FindObjectsOfType(System.Boolean includeInactive)
  T[] FindObjectsByType(UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode)
  T FindObjectOfType()
  T FindObjectOfType(System.Boolean includeInactive)
  T FindFirstObjectByType()
  T FindAnyObjectByType()
  T FindFirstObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive)
  T FindAnyObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive)
  UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type)
  System.Void CheckNullArgument(System.Object arg, System.String message)
  UnityEngine.Object FindObjectOfType(System.Type type)
  UnityEngine.Object FindFirstObjectByType(System.Type type)
  UnityEngine.Object FindAnyObjectByType(System.Type type)
  UnityEngine.Object FindObjectOfType(System.Type type, System.Boolean includeInactive)
  UnityEngine.Object FindFirstObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive)
  UnityEngine.Object FindAnyObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive)
  System.String ToString()
  System.Boolean op_Equality(UnityEngine.Object x, UnityEngine.Object y)
  System.Boolean op_Inequality(UnityEngine.Object x, UnityEngine.Object y)
  System.Int32 GetOffsetOfInstanceIDInCPlusPlusObject()
  System.Boolean CurrentThreadIsMainThread()
  UnityEngine.Object Internal_CloneSingle(UnityEngine.Object data)
  UnityEngine.Object Internal_CloneSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, System.Boolean worldPositionStays)
  UnityEngine.AsyncInstantiateOperation Internal_InstantiateAsyncWithParent(UnityEngine.Object original, System.Int32 count, UnityEngine.Transform parent, System.IntPtr position, System.IntPtr rotation)
  UnityEngine.Object Internal_InstantiateAsyncImmediatelyWithParent(UnityEngine.Object original, UnityEngine.Transform parent, System.Boolean worldPositionStays)
  UnityEngine.Object Internal_InstantiateSingle(UnityEngine.Object data, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
  UnityEngine.Object Internal_InstantiateSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
  System.String ToString(UnityEngine.Object obj)
  System.String GetName(UnityEngine.Object obj)
  System.Int32 GetNameHashCode(UnityEngine.Object obj)
  System.Int32 GetHashCodeByName(System.String name)
  System.Int32 UnsafeGetHashCodeByName(System.Byte* name)
  System.Boolean Internal_CompareName(UnityEngine.Object obj, System.String name)
  System.Boolean Internal_NameContains(UnityEngine.Object obj, System.String substring)
  System.Void Internal_GetNameNoAlloc(UnityEngine.Object obj, System.String name)
  System.Boolean IsPersistent(UnityEngine.Object obj)
  System.Void SetName(UnityEngine.Object obj, System.String name)
  System.Boolean DoesObjectWithInstanceIDExist(System.Int32 instanceID)
  UnityEngine.Object FindObjectFromInstanceID(System.Int32 instanceID)
  UnityEngine.Object ForceLoadFromInstanceID(System.Int32 instanceID)
  System.Void .ctor()
  System.Void .cctor()
  UnityEngine.Object Internal_InstantiateSingle_Injected(UnityEngine.Object data, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
  UnityEngine.Object Internal_InstantiateSingleWithParent_Injected(UnityEngine.Object data, UnityEngine.Transform parent, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
END_CLASS

CLASS: UnityEngine.UnitySynchronizationContext
TYPE:  class
TOKEN: 0x200019E
EXTENDS: SynchronizationContext
FIELDS:
  private   readonly System.Collections.Generic.List<UnityEngine.UnitySynchronizationContext.WorkRequest>m_AsyncWorkQueue  // 0x18
  private   readonly System.Collections.Generic.List<UnityEngine.UnitySynchronizationContext.WorkRequest>m_CurrentFrameWork  // 0x20
  private   readonly System.Int32                    m_MainThreadID  // 0x28
  private           System.Int32                    m_TrackedCount  // 0x2C
METHODS:
  System.Void .ctor(System.Int32 mainThreadID)
  System.Void .ctor(System.Collections.Generic.List<UnityEngine.UnitySynchronizationContext.WorkRequest> queue, System.Int32 mainThreadID)
  System.Void Send(System.Threading.SendOrPostCallback callback, System.Object state)
  System.Void OperationStarted()
  System.Void OperationCompleted()
  System.Void Post(System.Threading.SendOrPostCallback callback, System.Object state)
  System.Threading.SynchronizationContext CreateCopy()
  System.Void Exec()
  System.Boolean HasPendingTasks()
  System.Void InitializeSynchronizationContext()
  System.Void ExecuteTasks()
  System.Boolean ExecutePendingTasks(System.Int64 millisecondsTimeout)
END_CLASS

CLASS: UnityEngine.WaitForEndOfFrame
TYPE:  class
TOKEN: 0x20001A0
EXTENDS: YieldInstruction
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.WaitForFixedUpdate
TYPE:  class
TOKEN: 0x20001A1
EXTENDS: YieldInstruction
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.WaitForSeconds
TYPE:  class
TOKEN: 0x20001A2
EXTENDS: YieldInstruction
FIELDS:
  private           System.Single                   m_Seconds  // 0x10
METHODS:
  System.Void .ctor(System.Single seconds)
END_CLASS

CLASS: UnityEngine.WaitForSecondsRealtime
TYPE:  class
TOKEN: 0x20001A3
EXTENDS: CustomYieldInstruction
FIELDS:
  private           System.Single                   <waitTime>k__BackingField  // 0x10
  private           System.Single                   m_WaitUntilTime  // 0x14
METHODS:
  System.Single get_waitTime()
  System.Void set_waitTime(System.Single value)
  System.Boolean get_keepWaiting()
  System.Void .ctor(System.Single time)
  System.Void Reset()
END_CLASS

CLASS: UnityEngine.WaitUntil
TYPE:  class
TOKEN: 0x20001A4
EXTENDS: CustomYieldInstruction
FIELDS:
  private           System.Func<System.Boolean>     m_Predicate  // 0x10
METHODS:
  System.Boolean get_keepWaiting()
  System.Void .ctor(System.Func<System.Boolean> predicate)
END_CLASS

CLASS: UnityEngine.WaitWhile
TYPE:  class
TOKEN: 0x20001A5
EXTENDS: CustomYieldInstruction
FIELDS:
  private           System.Func<System.Boolean>     m_Predicate  // 0x10
METHODS:
  System.Boolean get_keepWaiting()
  System.Void .ctor(System.Func<System.Boolean> predicate)
END_CLASS

CLASS: UnityEngine.YieldInstruction
TYPE:  class
TOKEN: 0x20001A6
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.SerializeField
TYPE:  class
TOKEN: 0x20001A7
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.SerializeReference
TYPE:  class
TOKEN: 0x20001A8
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.PreferBinarySerialization
TYPE:  class
TOKEN: 0x20001A9
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.ISerializationCallbackReceiver
TYPE:  interface
TOKEN: 0x20001AA
FIELDS:
METHODS:
  System.Void OnBeforeSerialize()
  System.Void OnAfterDeserialize()
END_CLASS

CLASS: UnityEngine.ComputeBuffer
TYPE:  class
TOKEN: 0x20001AB
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
METHODS:
  System.IntPtr GetNativePtr()
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.IntPtr InitBuffer(System.Int32 count, System.Int32 stride, UnityEngine.ComputeBufferType type, UnityEngine.ComputeBufferMode usage)
  System.Void DestroyBuffer(UnityEngine.ComputeBuffer buf)
  System.Void .ctor(System.Int32 count, System.Int32 stride)
  System.Void .ctor(System.Int32 count, System.Int32 stride, UnityEngine.ComputeBufferType type)
  System.Void .ctor(System.Int32 count, System.Int32 stride, UnityEngine.ComputeBufferType type, UnityEngine.ComputeBufferMode usage)
  System.Void .ctor(System.Int32 count, System.Int32 stride, UnityEngine.ComputeBufferType type, UnityEngine.ComputeBufferMode usage, System.Int32 stackDepth)
  System.Void Release()
  System.Boolean IsValidBuffer(UnityEngine.ComputeBuffer buf)
  System.Boolean IsValid()
  System.Int32 get_count()
  System.Int32 get_stride()
  UnityEngine.ComputeBufferMode get_usage()
  System.Void SetData(System.Array data)
  System.Void SetData(System.Collections.Generic.List<T> data)
  System.Void SetData(Unity.Collections.NativeArray<T> data)
  System.Void SetData(Unity.Collections.NativeArray<T> data, System.Int32 nativeBufferStartIndex, System.Int32 computeBufferStartIndex, System.Int32 count)
  System.Void InternalSetNativeData(System.IntPtr data, System.Int32 nativeBufferStartIndex, System.Int32 computeBufferStartIndex, System.Int32 count, System.Int32 elemSize)
  System.Void InternalSetData(System.Array data, System.Int32 managedBufferStartIndex, System.Int32 computeBufferStartIndex, System.Int32 count, System.Int32 elemSize)
  System.Void* BeginBufferWrite(System.Int32 offset, System.Int32 size)
  Unity.Collections.NativeArray<T> BeginWrite(System.Int32 computeBufferStartIndex, System.Int32 count)
  System.Void EndBufferWrite(System.Int32 bytesWritten)
  System.Void EndWrite(System.Int32 countWritten)
  System.Void set_name(System.String value)
  System.Void SetName(System.String name)
END_CLASS

CLASS: UnityEngine.ComputeShader
TYPE:  class
TOKEN: 0x20001AC
FIELDS:
METHODS:
  System.Int32 FindKernel(System.String name)
  System.Void SetInt(System.Int32 nameID, System.Int32 val)
  System.Void Internal_SetBuffer(System.Int32 kernelIndex, System.Int32 nameID, UnityEngine.ComputeBuffer buffer)
  System.Void Internal_SetGraphicsBuffer(System.Int32 kernelIndex, System.Int32 nameID, UnityEngine.GraphicsBuffer buffer)
  System.Void Internal_HGSetBuffer(System.Int32 kernelIndex, System.Int32 nameID, System.UInt32 gfxBufferID)
  System.Void HGSetBuffer(System.Int32 kernelIndex, System.Int32 nameID, System.UInt32 gfxBufferID)
  System.Void SetBuffer(System.Int32 kernelIndex, System.Int32 nameID, UnityEngine.ComputeBuffer buffer)
  System.Void SetBuffer(System.Int32 kernelIndex, System.Int32 nameID, UnityEngine.GraphicsBuffer buffer)
  System.Void SetConstantComputeBuffer(System.Int32 nameID, UnityEngine.ComputeBuffer buffer, System.Int32 offset, System.Int32 size)
  System.Void GetKernelThreadGroupSizes(System.Int32 kernelIndex, System.UInt32& x, System.UInt32& y, System.UInt32& z)
  System.Void Dispatch(System.Int32 kernelIndex, System.Int32 threadGroupsX, System.Int32 threadGroupsY, System.Int32 threadGroupsZ)
  UnityEngine.Rendering.LocalKeywordSpace get_keywordSpace()
  System.Void EnableKeyword(System.String keyword)
  System.Void DisableKeyword(System.String keyword)
  System.Boolean IsSupported(System.Int32 kernelIndex)
  System.Void SetShaderKeywords(System.String[] names)
  System.Void set_shaderKeywords(System.String[] value)
  System.Void SetInt(System.String name, System.Int32 val)
  System.Void SetBuffer(System.Int32 kernelIndex, System.String name, UnityEngine.ComputeBuffer buffer)
  System.Void SetBuffer(System.Int32 kernelIndex, System.String name, UnityEngine.GraphicsBuffer buffer)
  System.Void SetConstantBuffer(System.Int32 nameID, UnityEngine.ComputeBuffer buffer, System.Int32 offset, System.Int32 size)
  System.Void get_keywordSpace_Injected(UnityEngine.Rendering.LocalKeywordSpace& ret)
END_CLASS

CLASS: UnityEngine.HGPsoExtInfo
TYPE:  struct
TOKEN: 0x20001AD
FIELDS:
  public            System.Single                   createTime  // 0x10
  public            System.Int32                    codeSize  // 0x14
  public            System.Boolean                  isMissing  // 0x18
  public            System.String                   levelId  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.HGPsoUtil
TYPE:  class
TOKEN: 0x20001AE
FIELDS:
  private   static  System.Action<System.String,UnityEngine.HGPsoExtInfo>onRenderPipelineUpload  // 0x0
  private   static  UnityEngine.HGPsoUtil.GetLevelIdDelegateonUpdateGameInfo  // 0x8
METHODS:
  System.Void add_onRenderPipelineUpload(System.Action<System.String,UnityEngine.HGPsoExtInfo> value)
  System.Void remove_onRenderPipelineUpload(System.Action<System.String,UnityEngine.HGPsoExtInfo> value)
  System.Void InvokeOnRenderPipelineUploadV2(System.String infoJson, System.Single createTime, System.Int32 codeSize, System.Boolean isMissing, System.String levelId)
  System.Void add_onUpdateGameInfo(UnityEngine.HGPsoUtil.GetLevelIdDelegate value)
  System.Void remove_onUpdateGameInfo(UnityEngine.HGPsoUtil.GetLevelIdDelegate value)
  System.String GetLevelId()
  System.Boolean IsPsoRecordEnabled()
END_CLASS

CLASS: UnityEngine.HGPsoWarmupCollection
TYPE:  class
TOKEN: 0x20001B0
FIELDS:
METHODS:
  System.Void UploadPipelineCreatedInfoInternal()
  System.Void SavePipelineCacheInternal()
  System.Boolean IsCompilingStageInternal(System.Int32 index)
  System.Int32 GetInfoCountInternal()
  System.Void ScheduleIndexInternal(System.Int32 index, System.Boolean background)
  System.Void DispatchAllInternal()
  System.Int32 GetRemainingJobCountInternal()
  System.Void UploadPipelineCreatedInfo()
  System.Void SavePipelineCache()
  System.Boolean IsCompilingStage(System.Int32 index)
  System.Int32 GetInfoCount()
  System.Int32 GetRemainingJobCount()
END_CLASS

CLASS: UnityEngine.HGSubsurfaceProfile
TYPE:  class
TOKEN: 0x20001B2
FIELDS:
  public    static  System.Int32                    LutSize  // 0x0
METHODS:
  UnityEngine.Vector3 get_subsurfaceNormalLerp()
  System.Single get_curvatureScale()
  System.Single get_penumbraScale()
  UnityEngine.Texture2D get_scatterLut()
  UnityEngine.Texture2D get_penumbraLut()
  UnityEngine.Texture2D get_indirectLut()
  System.Void .ctor()
  System.Void Internal_Create(UnityEngine.HGSubsurfaceProfile self)
  System.Void get_subsurfaceNormalLerp_Injected(UnityEngine.Vector3& ret)
END_CLASS

CLASS: UnityEngine.LowerResBlitTexture
TYPE:  class
TOKEN: 0x20001B3
FIELDS:
METHODS:
  System.Void LowerResBlitTextureDontStripMe()
END_CLASS

CLASS: UnityEngine.PreloadData
TYPE:  class
TOKEN: 0x20001B4
FIELDS:
METHODS:
  System.Void PreloadDataDontStripMe()
END_CLASS

CLASS: UnityEngine.BatteryStatus
TYPE:  struct
TOKEN: 0x20001B5
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.BatteryStatus       Unknown  // 0x0
  public    static  UnityEngine.BatteryStatus       Charging  // 0x0
  public    static  UnityEngine.BatteryStatus       Discharging  // 0x0
  public    static  UnityEngine.BatteryStatus       NotCharging  // 0x0
  public    static  UnityEngine.BatteryStatus       Full  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.OperatingSystemFamily
TYPE:  struct
TOKEN: 0x20001B6
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.OperatingSystemFamilyOther  // 0x0
  public    static  UnityEngine.OperatingSystemFamilyMacOSX  // 0x0
  public    static  UnityEngine.OperatingSystemFamilyWindows  // 0x0
  public    static  UnityEngine.OperatingSystemFamilyLinux  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.DeviceType
TYPE:  struct
TOKEN: 0x20001B7
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.DeviceType          Unknown  // 0x0
  public    static  UnityEngine.DeviceType          Handheld  // 0x0
  public    static  UnityEngine.DeviceType          Console  // 0x0
  public    static  UnityEngine.DeviceType          Desktop  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.SystemInfo
TYPE:  class
TOKEN: 0x20001B8
FIELDS:
METHODS:
  System.Single get_batteryLevel()
  UnityEngine.BatteryStatus get_batteryStatus()
  System.String get_operatingSystem()
  UnityEngine.OperatingSystemFamily get_operatingSystemFamily()
  System.String get_bootParameters()
  System.String get_processorType()
  System.Int32 get_processorCount()
  System.Int32 get_systemMemorySize()
  System.String get_deviceUniqueIdentifier()
  System.String get_deviceName()
  System.String get_deviceModel()
  System.String get_socModel()
  System.Boolean get_supportsAccelerometer()
  System.Boolean get_supportsGyroscope()
  System.Boolean get_supportsLocationService()
  System.Boolean get_supportsVibration()
  System.Boolean get_supportsAudio()
  UnityEngine.DeviceType get_deviceType()
  System.Int32 get_graphicsMemorySize()
  System.String get_graphicsDeviceName()
  System.String get_graphicsDeviceVendor()
  UnityEngine.Rendering.GraphicsDeviceType get_graphicsDeviceType()
  System.String get_nvidiaDriverVersion()
  System.Boolean get_graphicsUVStartsAtTop()
  System.String get_graphicsDeviceVersion()
  System.Int32 get_graphicsShaderLevel()
  System.Boolean get_graphicsMultiThreaded()
  System.Boolean get_hasHiddenSurfaceRemovalOnGPU()
  System.Boolean get_hasDynamicUniformArrayIndexingInFragmentShaders()
  System.Boolean get_supportsShadows()
  System.Boolean get_supportsRawShadowDepthSampling()
  System.Boolean get_supportsMotionVectors()
  System.Boolean get_supportsRenderToCubemap()
  System.Boolean get_supportsImageEffects()
  System.Boolean get_supports3DTextures()
  System.Boolean get_supports2DArrayTextures()
  System.Boolean get_supports3DRenderTextures()
  System.Boolean get_supportsCubemapArrayTextures()
  UnityEngine.Rendering.CopyTextureSupport get_copyTextureSupport()
  System.Boolean get_supportsComputeShaders()
  System.Boolean get_supportsRenderTargetArrayIndexFromVertexShader()
  System.Boolean get_supportsInstancing()
  System.Boolean get_supportsHardwareQuadTopology()
  System.Boolean get_supports32bitsIndexBuffer()
  System.Boolean get_supportsSparseTextures()
  System.Int32 get_supportedRenderTargetCount()
  System.Boolean get_supportsSeparatedRenderTargetsBlend()
  System.Int32 get_supportedRandomWriteTargetCount()
  System.Int32 get_supportsMultisampledTextures()
  System.Int32 get_supportsTextureWrapMirrorOnce()
  System.Boolean get_usesReversedZBuffer()
  System.Boolean IsValidEnumValue(System.Enum value)
  System.Boolean SupportsRenderTextureFormat(UnityEngine.RenderTextureFormat format)
  System.Boolean SupportsTextureFormat(UnityEngine.TextureFormat format)
  System.Int32 get_maxTextureSize()
  System.Int32 get_maxRenderTextureSize()
  System.Boolean get_supportsGraphicsFence()
  System.Boolean get_supportsAsyncGPUReadback()
  System.Boolean get_supportsRayTracing()
  System.UInt32 get_waveIntrinsicsSupportedStages()
  System.UInt32 get_waveIntrinsicsSupportedOperations()
  System.Boolean get_supportsMetalFXSpatialScaler()
  System.Boolean get_supportsMetalFXTemporalScaler()
  System.Int32 get_constantBufferOffsetAlignment()
  System.Int64 get_maxGraphicsBufferSize()
  UnityEngine.HDRDisplaySupportFlags get_hdrDisplaySupportFlags()
  System.Single GetBatteryLevel()
  UnityEngine.BatteryStatus GetBatteryStatus()
  System.String GetOperatingSystem()
  UnityEngine.OperatingSystemFamily GetOperatingSystemFamily()
  System.String HGGetBootParameters()
  System.String GetProcessorType()
  System.Int32 GetProcessorCount()
  System.Int32 GetPhysicalMemoryMB()
  System.String GetDeviceUniqueIdentifier()
  System.String GetDeviceName()
  System.String GetDeviceModel()
  System.String GetSOCModel()
  System.Boolean SupportsAccelerometer()
  System.Boolean IsGyroAvailable()
  System.Boolean SupportsLocationService()
  System.Boolean SupportsVibration()
  System.Boolean SupportsAudio()
  UnityEngine.DeviceType GetDeviceType()
  System.Int32 GetGraphicsMemorySize()
  System.String GetGraphicsDeviceName()
  System.String GetGraphicsDeviceVendor()
  UnityEngine.Rendering.GraphicsDeviceType GetGraphicsDeviceType()
  System.String GetNvidiaDriverVersion()
  System.Boolean GetGraphicsUVStartsAtTop()
  System.String GetGraphicsDeviceVersion()
  System.Int32 GetGraphicsShaderLevel()
  System.Boolean GetGraphicsMultiThreaded()
  System.Boolean HasHiddenSurfaceRemovalOnGPU()
  System.Boolean HasDynamicUniformArrayIndexingInFragmentShaders()
  System.Boolean SupportsShadows()
  System.Boolean SupportsRawShadowDepthSampling()
  System.Boolean SupportsMotionVectors()
  System.Boolean Supports3DTextures()
  System.Boolean Supports2DArrayTextures()
  System.Boolean Supports3DRenderTextures()
  System.Boolean SupportsCubemapArrayTextures()
  UnityEngine.Rendering.CopyTextureSupport GetCopyTextureSupport()
  System.Boolean SupportsComputeShaders()
  System.Boolean SupportsRenderTargetArrayIndexFromVertexShader()
  System.Boolean SupportsInstancing()
  System.Boolean SupportsHardwareQuadTopology()
  System.Boolean Supports32bitsIndexBuffer()
  System.Boolean SupportsSparseTextures()
  System.Int32 SupportedRenderTargetCount()
  System.Boolean SupportsSeparatedRenderTargetsBlend()
  System.Int32 SupportedRandomWriteTargetCount()
  System.Int32 SupportsMultisampledTextures()
  System.Int32 SupportsTextureWrapMirrorOnce()
  System.Boolean UsesReversedZBuffer()
  System.Boolean HasRenderTextureNative(UnityEngine.RenderTextureFormat format)
  System.Boolean SupportsTextureFormatNative(UnityEngine.TextureFormat format)
  System.Int32 GetMaxTextureSize()
  System.Int32 GetMaxRenderTextureSize()
  System.Boolean SupportsGPUFence()
  System.Boolean SupportsAsyncGPUReadback()
  System.Boolean SupportsRayTracing()
  System.UInt32 GetWaveIntrinsicsSupportedStages()
  System.UInt32 GetWaveIntrinsicsSupportedOperations()
  System.Boolean SupportsMetalFXSpatialScaler()
  System.Boolean SupportsMetalFXTemporalScaler()
  System.Int32 MinConstantBufferOffsetAlignment()
  System.Int64 MaxGraphicsBufferSize()
  System.Boolean IsFormatSupported(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage)
  UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage)
  UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.Experimental.Rendering.DefaultFormat format)
  UnityEngine.HDRDisplaySupportFlags GetHDRDisplaySupportFlags()
END_CLASS

CLASS: UnityEngine.SystemClock
TYPE:  class
TOKEN: 0x20001B9
FIELDS:
  private   static readonly System.DateTime                 s_Epoch  // 0x0
METHODS:
  System.DateTime get_now()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Time
TYPE:  class
TOKEN: 0x20001BA
FIELDS:
METHODS:
  System.Single get_time()
  System.Double get_timeAsDouble()
  System.Single get_timeSinceLevelLoad()
  System.Double get_timeSinceLevelLoadAsDouble()
  System.Single get_deltaTime()
  System.Single get_fixedTime()
  System.Double get_fixedTimeAsDouble()
  System.Single get_unscaledTime()
  System.Double get_unscaledTimeAsDouble()
  System.Single get_fixedUnscaledTime()
  System.Double get_fixedUnscaledTimeAsDouble()
  System.Single get_unscaledDeltaTime()
  System.Single get_fixedUnscaledDeltaTime()
  System.Single get_fixedDeltaTime()
  System.Void set_fixedDeltaTime(System.Single value)
  System.Single get_maximumDeltaTime()
  System.Void set_maximumDeltaTime(System.Single value)
  System.Single get_smoothDeltaTime()
  System.Single get_maximumParticleDeltaTime()
  System.Void set_maximumParticleDeltaTime(System.Single value)
  System.Single get_timeScale()
  System.Void set_timeScale(System.Single value)
  System.Int32 get_frameCount()
  System.Int32 get_renderedFrameCount()
  System.Single get_realtimeSinceStartup()
  System.Double get_realtimeSinceStartupAsDouble()
  System.Single get_captureDeltaTime()
  System.Void set_captureDeltaTime(System.Single value)
  System.Int32 get_captureFramerate()
  System.Void set_captureFramerate(System.Int32 value)
  System.Boolean get_inFixedTimeStep()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.TouchScreenKeyboard_InternalConstructorHelperArguments
TYPE:  struct
TOKEN: 0x20001BB
FIELDS:
  public            System.UInt32                   keyboardType  // 0x10
  public            System.UInt32                   autocorrection  // 0x14
  public            System.UInt32                   multiline  // 0x18
  public            System.UInt32                   secure  // 0x1C
  public            System.UInt32                   alert  // 0x20
  public            System.Int32                    characterLimit  // 0x24
METHODS:
END_CLASS

CLASS: UnityEngine.TouchScreenKeyboard
TYPE:  class
TOKEN: 0x20001BC
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
  private   static  System.Boolean                  <disableInPlaceEditing>k__BackingField  // 0x0
METHODS:
  System.Void Internal_Destroy(System.IntPtr ptr)
  System.Void Destroy()
  System.Void Finalize()
  System.Void .ctor(System.String text, UnityEngine.TouchScreenKeyboardType keyboardType, System.Boolean autocorrection, System.Boolean multiline, System.Boolean secure, System.Boolean alert, System.String textPlaceholder, System.Int32 characterLimit)
  System.IntPtr TouchScreenKeyboard_InternalConstructorHelper(UnityEngine.TouchScreenKeyboard_InternalConstructorHelperArguments& arguments, System.String text, System.String textPlaceholder)
  System.Boolean get_isSupported()
  System.Boolean get_disableInPlaceEditing()
  System.Boolean get_isInPlaceEditingAllowed()
  UnityEngine.TouchScreenKeyboard Open(System.String text, UnityEngine.TouchScreenKeyboardType keyboardType, System.Boolean autocorrection, System.Boolean multiline, System.Boolean secure, System.Boolean alert, System.String textPlaceholder, System.Int32 characterLimit)
  UnityEngine.TouchScreenKeyboard Open(System.String text, UnityEngine.TouchScreenKeyboardType keyboardType, System.Boolean autocorrection, System.Boolean multiline, System.Boolean secure)
  System.String get_text()
  System.Void set_text(System.String value)
  System.Void set_hideInput(System.Boolean value)
  System.Boolean get_active()
  System.Void set_active(System.Boolean value)
  UnityEngine.TouchScreenKeyboard.Status get_status()
  System.Void set_characterLimit(System.Int32 value)
  System.Boolean get_canGetSelection()
  System.Boolean get_canSetSelection()
  UnityEngine.RangeInt get_selection()
  System.Void set_selection(UnityEngine.RangeInt value)
  System.Void GetSelection(System.Int32& start, System.Int32& length)
  System.Void SetSelection(System.Int32 start, System.Int32 length)
END_CLASS

CLASS: UnityEngine.TouchScreenKeyboardType
TYPE:  struct
TOKEN: 0x20001BE
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TouchScreenKeyboardTypeDefault  // 0x0
  public    static  UnityEngine.TouchScreenKeyboardTypeASCIICapable  // 0x0
  public    static  UnityEngine.TouchScreenKeyboardTypeNumbersAndPunctuation  // 0x0
  public    static  UnityEngine.TouchScreenKeyboardTypeURL  // 0x0
  public    static  UnityEngine.TouchScreenKeyboardTypeNumberPad  // 0x0
  public    static  UnityEngine.TouchScreenKeyboardTypePhonePad  // 0x0
  public    static  UnityEngine.TouchScreenKeyboardTypeNamePhonePad  // 0x0
  public    static  UnityEngine.TouchScreenKeyboardTypeEmailAddress  // 0x0
  public    static  UnityEngine.TouchScreenKeyboardTypeNintendoNetworkAccount  // 0x0
  public    static  UnityEngine.TouchScreenKeyboardTypeSocial  // 0x0
  public    static  UnityEngine.TouchScreenKeyboardTypeSearch  // 0x0
  public    static  UnityEngine.TouchScreenKeyboardTypeDecimalPad  // 0x0
  public    static  UnityEngine.TouchScreenKeyboardTypeOneTimeCode  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.FrameDebugger
TYPE:  class
TOKEN: 0x20001BF
FIELDS:
METHODS:
  System.Boolean get_enabled()
  System.Boolean IsLocalEnabled()
  System.Boolean IsRemoteEnabled()
END_CLASS

CLASS: UnityEngine.DrivenTransformProperties
TYPE:  struct
TOKEN: 0x20001C0
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.DrivenTransformPropertiesNone  // 0x0
  public    static  UnityEngine.DrivenTransformPropertiesAll  // 0x0
  public    static  UnityEngine.DrivenTransformPropertiesAnchoredPositionX  // 0x0
  public    static  UnityEngine.DrivenTransformPropertiesAnchoredPositionY  // 0x0
  public    static  UnityEngine.DrivenTransformPropertiesAnchoredPositionZ  // 0x0
  public    static  UnityEngine.DrivenTransformPropertiesRotation  // 0x0
  public    static  UnityEngine.DrivenTransformPropertiesScaleX  // 0x0
  public    static  UnityEngine.DrivenTransformPropertiesScaleY  // 0x0
  public    static  UnityEngine.DrivenTransformPropertiesScaleZ  // 0x0
  public    static  UnityEngine.DrivenTransformPropertiesAnchorMinX  // 0x0
  public    static  UnityEngine.DrivenTransformPropertiesAnchorMinY  // 0x0
  public    static  UnityEngine.DrivenTransformPropertiesAnchorMaxX  // 0x0
  public    static  UnityEngine.DrivenTransformPropertiesAnchorMaxY  // 0x0
  public    static  UnityEngine.DrivenTransformPropertiesSizeDeltaX  // 0x0
  public    static  UnityEngine.DrivenTransformPropertiesSizeDeltaY  // 0x0
  public    static  UnityEngine.DrivenTransformPropertiesPivotX  // 0x0
  public    static  UnityEngine.DrivenTransformPropertiesPivotY  // 0x0
  public    static  UnityEngine.DrivenTransformPropertiesAnchoredPosition  // 0x0
  public    static  UnityEngine.DrivenTransformPropertiesAnchoredPosition3D  // 0x0
  public    static  UnityEngine.DrivenTransformPropertiesScale  // 0x0
  public    static  UnityEngine.DrivenTransformPropertiesAnchorMin  // 0x0
  public    static  UnityEngine.DrivenTransformPropertiesAnchorMax  // 0x0
  public    static  UnityEngine.DrivenTransformPropertiesAnchors  // 0x0
  public    static  UnityEngine.DrivenTransformPropertiesSizeDelta  // 0x0
  public    static  UnityEngine.DrivenTransformPropertiesPivot  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.DrivenRectTransformTracker
TYPE:  struct
TOKEN: 0x20001C1
FIELDS:
METHODS:
  System.Void Add(UnityEngine.Object driver, UnityEngine.RectTransform rectTransform, UnityEngine.DrivenTransformProperties drivenProperties)
  System.Void Clear()
END_CLASS

CLASS: UnityEngine.RectTransform
TYPE:  class
TOKEN: 0x20001C2
EXTENDS: Transform
FIELDS:
  private   static  UnityEngine.RectTransform.ReapplyDrivenPropertiesreapplyDrivenProperties  // 0x0
METHODS:
  System.Void add_reapplyDrivenProperties(UnityEngine.RectTransform.ReapplyDrivenProperties value)
  System.Void remove_reapplyDrivenProperties(UnityEngine.RectTransform.ReapplyDrivenProperties value)
  UnityEngine.Rect get_rect()
  UnityEngine.Vector2 get_anchorMin()
  System.Void set_anchorMin(UnityEngine.Vector2 value)
  UnityEngine.Vector2 get_anchorMax()
  System.Void set_anchorMax(UnityEngine.Vector2 value)
  UnityEngine.Vector2 get_anchoredPosition()
  System.Void set_anchoredPosition(UnityEngine.Vector2 value)
  UnityEngine.Vector2 get_sizeDelta()
  System.Void set_sizeDelta(UnityEngine.Vector2 value)
  UnityEngine.Vector2 get_pivot()
  System.Void set_pivot(UnityEngine.Vector2 value)
  UnityEngine.Vector3 get_anchoredPosition3D()
  System.Void set_anchoredPosition3D(UnityEngine.Vector3 value)
  UnityEngine.Vector2 get_offsetMin()
  System.Void set_offsetMin(UnityEngine.Vector2 value)
  UnityEngine.Vector2 get_offsetMax()
  System.Void set_offsetMax(UnityEngine.Vector2 value)
  UnityEngine.Object get_drivenByObject()
  System.Void set_drivenByObject(UnityEngine.Object value)
  UnityEngine.DrivenTransformProperties get_drivenProperties()
  System.Void set_drivenProperties(UnityEngine.DrivenTransformProperties value)
  System.Void ForceUpdateRectTransforms()
  System.Void GetLocalCorners(UnityEngine.Vector3[] fourCornersArray)
  System.Void GetWorldCorners(UnityEngine.Vector3[] fourCornersArray)
  System.Void SetInsetAndSizeFromParentEdge(UnityEngine.RectTransform.Edge edge, System.Single inset, System.Single size)
  System.Void SetSizeWithCurrentAnchors(UnityEngine.RectTransform.Axis axis, System.Single size)
  System.Void SendReapplyDrivenProperties(UnityEngine.RectTransform driven)
  UnityEngine.Rect GetRectInParentSpace()
  UnityEngine.Vector2 GetParentSize()
  System.Void .ctor()
  System.Void get_rect_Injected(UnityEngine.Rect& ret)
  System.Void get_anchorMin_Injected(UnityEngine.Vector2& ret)
  System.Void set_anchorMin_Injected(UnityEngine.Vector2& value)
  System.Void get_anchorMax_Injected(UnityEngine.Vector2& ret)
  System.Void set_anchorMax_Injected(UnityEngine.Vector2& value)
  System.Void get_anchoredPosition_Injected(UnityEngine.Vector2& ret)
  System.Void set_anchoredPosition_Injected(UnityEngine.Vector2& value)
  System.Void get_sizeDelta_Injected(UnityEngine.Vector2& ret)
  System.Void set_sizeDelta_Injected(UnityEngine.Vector2& value)
  System.Void get_pivot_Injected(UnityEngine.Vector2& ret)
  System.Void set_pivot_Injected(UnityEngine.Vector2& value)
END_CLASS

CLASS: UnityEngine.RotationOrder
TYPE:  struct
TOKEN: 0x20001C6
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.RotationOrder       OrderXYZ  // 0x0
  public    static  UnityEngine.RotationOrder       OrderXZY  // 0x0
  public    static  UnityEngine.RotationOrder       OrderYZX  // 0x0
  public    static  UnityEngine.RotationOrder       OrderYXZ  // 0x0
  public    static  UnityEngine.RotationOrder       OrderZXY  // 0x0
  public    static  UnityEngine.RotationOrder       OrderZYX  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Transform
TYPE:  class
TOKEN: 0x20001C7
EXTENDS: Component
FIELDS:
METHODS:
  System.Void .ctor()
  UnityEngine.Vector3 get_position()
  System.Void set_position(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_localPosition()
  System.Void set_localPosition(UnityEngine.Vector3 value)
  UnityEngine.Vector3 GetLocalEulerAngles(UnityEngine.RotationOrder order)
  System.Void SetLocalEulerAngles(UnityEngine.Vector3 euler, UnityEngine.RotationOrder order)
  System.Void SetLocalEulerHint(UnityEngine.Vector3 euler)
  UnityEngine.Vector3 get_eulerAngles()
  System.Void set_eulerAngles(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_localEulerAngles()
  System.Void set_localEulerAngles(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_right()
  System.Void set_right(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_up()
  System.Void set_up(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_forward()
  System.Void set_forward(UnityEngine.Vector3 value)
  UnityEngine.Quaternion get_rotation()
  System.Void set_rotation(UnityEngine.Quaternion value)
  UnityEngine.Quaternion get_localRotation()
  System.Void set_localRotation(UnityEngine.Quaternion value)
  UnityEngine.RotationOrder get_rotationOrder()
  System.Void set_rotationOrder(UnityEngine.RotationOrder value)
  System.Int32 GetRotationOrderInternal()
  System.Void SetRotationOrderInternal(UnityEngine.RotationOrder rotationOrder)
  UnityEngine.Vector3 get_localScale()
  System.Void set_localScale(UnityEngine.Vector3 value)
  UnityEngine.Transform get_parent()
  System.Void set_parent(UnityEngine.Transform value)
  UnityEngine.Transform get_parentInternal()
  System.Void set_parentInternal(UnityEngine.Transform value)
  UnityEngine.Transform GetParent()
  System.Void SetParent(UnityEngine.Transform p)
  System.Void SetParent(UnityEngine.Transform parent, System.Boolean worldPositionStays)
  UnityEngine.Matrix4x4 get_worldToLocalMatrix()
  UnityEngine.Matrix4x4 get_localToWorldMatrix()
  UnityEngine.Matrix4x4 GetLocalToRelativeMatrix(UnityEngine.Transform relativeT)
  System.Void SetPositionAndRotation(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  System.Void SetLocalPositionAndRotation(UnityEngine.Vector3 localPosition, UnityEngine.Quaternion localRotation)
  System.Void GetPositionAndRotation(UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation)
  System.Void GetLocalPositionAndRotation(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation)
  System.Void SetRelativePosition(UnityEngine.Transform relativeT, UnityEngine.Vector3 position)
  System.Void GetRelativePositionAndRotation(UnityEngine.Transform relativeT, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation)
  UnityEngine.Vector3 GetRelativePosition(UnityEngine.Transform relativeT)
  System.Int32 GetHierarchyIndex()
  System.Void Translate(UnityEngine.Vector3 translation, UnityEngine.Space relativeTo)
  System.Void Translate(UnityEngine.Vector3 translation)
  System.Void Translate(System.Single x, System.Single y, System.Single z, UnityEngine.Space relativeTo)
  System.Void Translate(System.Single x, System.Single y, System.Single z)
  System.Void Translate(UnityEngine.Vector3 translation, UnityEngine.Transform relativeTo)
  System.Void Translate(System.Single x, System.Single y, System.Single z, UnityEngine.Transform relativeTo)
  System.Void Rotate(UnityEngine.Vector3 eulers, UnityEngine.Space relativeTo)
  System.Void Rotate(UnityEngine.Vector3 eulers)
  System.Void Rotate(System.Single xAngle, System.Single yAngle, System.Single zAngle, UnityEngine.Space relativeTo)
  System.Void Rotate(System.Single xAngle, System.Single yAngle, System.Single zAngle)
  System.Void RotateAroundInternal(UnityEngine.Vector3 axis, System.Single angle)
  System.Void Rotate(UnityEngine.Vector3 axis, System.Single angle, UnityEngine.Space relativeTo)
  System.Void Rotate(UnityEngine.Vector3 axis, System.Single angle)
  System.Void RotateAround(UnityEngine.Vector3 point, UnityEngine.Vector3 axis, System.Single angle)
  System.Void LookAt(UnityEngine.Transform target, UnityEngine.Vector3 worldUp)
  System.Void LookAt(UnityEngine.Transform target)
  System.Void LookAt(UnityEngine.Vector3 worldPosition, UnityEngine.Vector3 worldUp)
  System.Void LookAt(UnityEngine.Vector3 worldPosition)
  System.Void Internal_LookAt(UnityEngine.Vector3 worldPosition, UnityEngine.Vector3 worldUp)
  UnityEngine.Vector3 TransformDirection(UnityEngine.Vector3 direction)
  UnityEngine.Vector3 TransformDirection(System.Single x, System.Single y, System.Single z)
  UnityEngine.Vector3 InverseTransformDirection(UnityEngine.Vector3 direction)
  UnityEngine.Vector3 InverseTransformDirection(System.Single x, System.Single y, System.Single z)
  UnityEngine.Vector3 TransformVector(UnityEngine.Vector3 vector)
  UnityEngine.Vector3 TransformVector(System.Single x, System.Single y, System.Single z)
  UnityEngine.Vector3 InverseTransformVector(UnityEngine.Vector3 vector)
  UnityEngine.Vector3 InverseTransformVector(System.Single x, System.Single y, System.Single z)
  UnityEngine.Vector3 TransformPoint(UnityEngine.Vector3 position)
  UnityEngine.Vector3 TransformPoint(System.Single x, System.Single y, System.Single z)
  UnityEngine.Vector3 InverseTransformPoint(UnityEngine.Vector3 position)
  UnityEngine.Vector3 InverseTransformPoint(System.Single x, System.Single y, System.Single z)
  UnityEngine.Transform get_root()
  UnityEngine.Transform GetRoot()
  System.Int32 get_childCount()
  System.Void DetachChildren()
  System.Void SetAsFirstSibling()
  System.Void SetAsLastSibling()
  System.Void SetSiblingIndex(System.Int32 index)
  System.Void MoveAfterSibling(UnityEngine.Transform transform, System.Boolean notifyEditorAndMarkDirty)
  System.Int32 GetSiblingIndex()
  UnityEngine.Transform FindRelativeTransformWithPath(UnityEngine.Transform transform, System.String path, System.Boolean isActiveOnly)
  UnityEngine.Transform Find(System.String n)
  UnityEngine.Transform FindTransformWithName(UnityEngine.Transform transform, System.String name)
  UnityEngine.Transform FindRecursiveWithName(System.String name)
  System.Void SendTransformChangedScale()
  UnityEngine.Vector3 get_lossyScale()
  System.Boolean IsChildOf(UnityEngine.Transform parent)
  System.Boolean get_hasChanged()
  System.Void set_hasChanged(System.Boolean value)
  UnityEngine.Transform FindChild(System.String n)
  System.Collections.IEnumerator GetEnumerator()
  System.Void RotateAround(UnityEngine.Vector3 axis, System.Single angle)
  System.Void RotateAroundLocal(UnityEngine.Vector3 axis, System.Single angle)
  UnityEngine.Transform GetChild(System.Int32 index)
  System.Int32 GetChildCount()
  System.Int32 get_hierarchyCapacity()
  System.Void set_hierarchyCapacity(System.Int32 value)
  System.Int32 internal_getHierarchyCapacity()
  System.Void internal_setHierarchyCapacity(System.Int32 value)
  System.Int32 get_hierarchyCount()
  System.Int32 internal_getHierarchyCount()
  System.Boolean IsNonUniformScaleTransform()
  System.Boolean get_constrainProportionsScale()
  System.Void set_constrainProportionsScale(System.Boolean value)
  System.Void SetConstrainProportionsScale(System.Boolean isLinked)
  System.Boolean IsConstrainProportionsScale()
  System.Void get_position_Injected(UnityEngine.Vector3& ret)
  System.Void set_position_Injected(UnityEngine.Vector3& value)
  System.Void get_localPosition_Injected(UnityEngine.Vector3& ret)
  System.Void set_localPosition_Injected(UnityEngine.Vector3& value)
  System.Void GetLocalEulerAngles_Injected(UnityEngine.RotationOrder order, UnityEngine.Vector3& ret)
  System.Void SetLocalEulerAngles_Injected(UnityEngine.Vector3& euler, UnityEngine.RotationOrder order)
  System.Void SetLocalEulerHint_Injected(UnityEngine.Vector3& euler)
  System.Void get_rotation_Injected(UnityEngine.Quaternion& ret)
  System.Void set_rotation_Injected(UnityEngine.Quaternion& value)
  System.Void get_localRotation_Injected(UnityEngine.Quaternion& ret)
  System.Void set_localRotation_Injected(UnityEngine.Quaternion& value)
  System.Void get_localScale_Injected(UnityEngine.Vector3& ret)
  System.Void set_localScale_Injected(UnityEngine.Vector3& value)
  System.Void get_worldToLocalMatrix_Injected(UnityEngine.Matrix4x4& ret)
  System.Void get_localToWorldMatrix_Injected(UnityEngine.Matrix4x4& ret)
  System.Void GetLocalToRelativeMatrix_Injected(UnityEngine.Transform relativeT, UnityEngine.Matrix4x4& ret)
  System.Void SetPositionAndRotation_Injected(UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation)
  System.Void SetLocalPositionAndRotation_Injected(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation)
  System.Void SetRelativePosition_Injected(UnityEngine.Transform relativeT, UnityEngine.Vector3& position)
  System.Void GetRelativePosition_Injected(UnityEngine.Transform relativeT, UnityEngine.Vector3& ret)
  System.Void RotateAroundInternal_Injected(UnityEngine.Vector3& axis, System.Single angle)
  System.Void Internal_LookAt_Injected(UnityEngine.Vector3& worldPosition, UnityEngine.Vector3& worldUp)
  System.Void TransformDirection_Injected(UnityEngine.Vector3& direction, UnityEngine.Vector3& ret)
  System.Void InverseTransformDirection_Injected(UnityEngine.Vector3& direction, UnityEngine.Vector3& ret)
  System.Void TransformVector_Injected(UnityEngine.Vector3& vector, UnityEngine.Vector3& ret)
  System.Void InverseTransformVector_Injected(UnityEngine.Vector3& vector, UnityEngine.Vector3& ret)
  System.Void TransformPoint_Injected(UnityEngine.Vector3& position, UnityEngine.Vector3& ret)
  System.Void InverseTransformPoint_Injected(UnityEngine.Vector3& position, UnityEngine.Vector3& ret)
  System.Void get_lossyScale_Injected(UnityEngine.Vector3& ret)
  System.Void RotateAround_Injected(UnityEngine.Vector3& axis, System.Single angle)
  System.Void RotateAroundLocal_Injected(UnityEngine.Vector3& axis, System.Single angle)
END_CLASS

CLASS: UnityEngine.SpriteMaskInteraction
TYPE:  struct
TOKEN: 0x20001C9
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.SpriteMaskInteractionNone  // 0x0
  public    static  UnityEngine.SpriteMaskInteractionVisibleInsideMask  // 0x0
  public    static  UnityEngine.SpriteMaskInteractionVisibleOutsideMask  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.SpriteRenderer
TYPE:  class
TOKEN: 0x20001CA
EXTENDS: Renderer
FIELDS:
  private           UnityEngine.Events.UnityEvent<UnityEngine.SpriteRenderer>m_SpriteChangeEvent  // 0x18
METHODS:
  System.Void InvokeSpriteChanged()
  UnityEngine.Sprite get_sprite()
  System.Void set_sprite(UnityEngine.Sprite value)
  UnityEngine.Color get_color()
  System.Void set_color(UnityEngine.Color value)
  System.Boolean get_flipX()
  System.Void set_flipX(System.Boolean value)
  System.Boolean get_flipY()
  System.Void set_flipY(System.Boolean value)
  System.Void get_color_Injected(UnityEngine.Color& ret)
  System.Void set_color_Injected(UnityEngine.Color& value)
END_CLASS

CLASS: UnityEngine.SpriteMeshType
TYPE:  struct
TOKEN: 0x20001CB
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.SpriteMeshType      FullRect  // 0x0
  public    static  UnityEngine.SpriteMeshType      Tight  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.SpritePackingMode
TYPE:  struct
TOKEN: 0x20001CC
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.SpritePackingMode   Tight  // 0x0
  public    static  UnityEngine.SpritePackingMode   Rectangle  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.SpritePackingRotation
TYPE:  struct
TOKEN: 0x20001CD
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.SpritePackingRotationNone  // 0x0
  public    static  UnityEngine.SpritePackingRotationFlipHorizontal  // 0x0
  public    static  UnityEngine.SpritePackingRotationFlipVertical  // 0x0
  public    static  UnityEngine.SpritePackingRotationRotate180  // 0x0
  public    static  UnityEngine.SpritePackingRotationAny  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Sprite
TYPE:  class
TOKEN: 0x20001CE
FIELDS:
  private   static  System.Action<System.Collections.Generic.List<UnityEngine.Sprite>>dynamicAtlasFinishCallback  // 0x0
METHODS:
  System.Void .ctor()
  System.Int32 GetPackingMode()
  System.Int32 GetPackingRotation()
  System.Int32 GetPacked()
  UnityEngine.Rect GetTextureRect()
  UnityEngine.Vector2 GetTextureRectOffset()
  UnityEngine.Vector4 GetInnerUVs()
  UnityEngine.Vector4 GetOuterUVs()
  UnityEngine.Vector4 GetPadding()
  UnityEngine.Sprite CreateSpriteWithoutTextureScripting(UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsToUnits, UnityEngine.Texture2D texture)
  UnityEngine.Sprite CreateSprite(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsPerUnit, System.UInt32 extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border, System.Boolean generateFallbackPhysicsShape)
  UnityEngine.Bounds get_bounds()
  UnityEngine.Rect get_rect()
  UnityEngine.Vector4 get_border()
  UnityEngine.Texture2D get_texture()
  UnityEngine.Texture2D GetSecondaryTexture(System.Int32 index)
  System.Single get_pixelsPerUnit()
  System.Single get_spriteAtlasTextureScale()
  UnityEngine.Texture2D get_associatedAlphaSplitTexture()
  UnityEngine.Vector2 get_pivot()
  System.Boolean get_packed()
  System.Boolean get_dynamicPacked()
  UnityEngine.SpritePackingMode get_packingMode()
  UnityEngine.SpritePackingRotation get_packingRotation()
  UnityEngine.Rect get_textureRect()
  UnityEngine.Vector2 get_textureRectOffset()
  UnityEngine.Vector2[] get_vertices()
  System.UInt16[] get_triangles()
  UnityEngine.Vector2[] get_uv()
  System.Int32 GetPhysicsShapeCount()
  System.Int32 GetPhysicsShapePointCount(System.Int32 shapeIdx)
  System.Int32 Internal_GetPhysicsShapePointCount(System.Int32 shapeIdx)
  System.Void RegisterDynamicAtlas(System.Int32 panelLevel)
  System.Void UnRegisterDynamicAtlas()
  System.Void InternalRegisterDynamicAtlas(System.Int32 panelLevel)
  System.Void Internal_UnRegisterDynamicAtlas()
  System.Void add_dynamicAtlasFinishCallback(System.Action<System.Collections.Generic.List<UnityEngine.Sprite>> value)
  System.Void remove_dynamicAtlasFinishCallback(System.Action<System.Collections.Generic.List<UnityEngine.Sprite>> value)
  System.Boolean PostRegisteredAtlasFinish(System.Collections.Generic.List<UnityEngine.Sprite> sprites)
  System.Void RegisterSpriteAtlasList(System.Collections.Generic.List<UnityEngine.Sprite> cacheCallBack)
  System.Void Internal_RegisterSpriteCacheCallBack(System.Collections.Generic.List<UnityEngine.Sprite> cacheCallBac)
  System.Int32 GetPhysicsShape(System.Int32 shapeIdx, System.Collections.Generic.List<UnityEngine.Vector2> physicsShape)
  System.Void GetPhysicsShapeImpl(UnityEngine.Sprite sprite, System.Int32 shapeIdx, System.Collections.Generic.List<UnityEngine.Vector2> physicsShape)
  System.Void OverridePhysicsShape(System.Collections.Generic.IList<UnityEngine.Vector2[]> physicsShapes)
  System.Void OverridePhysicsShapeCount(UnityEngine.Sprite sprite, System.Int32 physicsShapeCount)
  System.Void OverridePhysicsShape(UnityEngine.Sprite sprite, UnityEngine.Vector2[] physicsShape, System.Int32 idx)
  System.Void OverrideGeometry(UnityEngine.Vector2[] vertices, System.UInt16[] triangles)
  UnityEngine.Sprite Create(UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsToUnits, UnityEngine.Texture2D texture)
  UnityEngine.Sprite Create(UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsToUnits)
  UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsPerUnit, System.UInt32 extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border, System.Boolean generateFallbackPhysicsShape)
  UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsPerUnit, System.UInt32 extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border)
  UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsPerUnit, System.UInt32 extrude, UnityEngine.SpriteMeshType meshType)
  UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsPerUnit, System.UInt32 extrude)
  UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, System.Single pixelsPerUnit)
  UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot)
  System.Void GetTextureRect_Injected(UnityEngine.Rect& ret)
  System.Void GetTextureRectOffset_Injected(UnityEngine.Vector2& ret)
  System.Void GetInnerUVs_Injected(UnityEngine.Vector4& ret)
  System.Void GetOuterUVs_Injected(UnityEngine.Vector4& ret)
  System.Void GetPadding_Injected(UnityEngine.Vector4& ret)
  UnityEngine.Sprite CreateSpriteWithoutTextureScripting_Injected(UnityEngine.Rect& rect, UnityEngine.Vector2& pivot, System.Single pixelsToUnits, UnityEngine.Texture2D texture)
  UnityEngine.Sprite CreateSprite_Injected(UnityEngine.Texture2D texture, UnityEngine.Rect& rect, UnityEngine.Vector2& pivot, System.Single pixelsPerUnit, System.UInt32 extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4& border, System.Boolean generateFallbackPhysicsShape)
  System.Void get_bounds_Injected(UnityEngine.Bounds& ret)
  System.Void get_rect_Injected(UnityEngine.Rect& ret)
  System.Void get_border_Injected(UnityEngine.Vector4& ret)
  System.Void get_pivot_Injected(UnityEngine.Vector2& ret)
END_CLASS

CLASS: UnityEngine.Assertions.Assert
TYPE:  class
TOKEN: 0x20003A7
FIELDS:
  public    static  System.Boolean                  raiseExceptions  // 0x0
METHODS:
  System.Void Fail(System.String message, System.String userMessage)
  System.Void IsTrue(System.Boolean condition)
  System.Void IsTrue(System.Boolean condition, System.String message)
  System.Void IsFalse(System.Boolean condition, System.String message)
  System.Void AreEqual(T expected, T actual)
  System.Void AreEqual(T expected, T actual, System.String message)
  System.Void AreEqual(T expected, T actual, System.String message, System.Collections.Generic.IEqualityComparer<T> comparer)
  System.Void AreEqual(UnityEngine.Object expected, UnityEngine.Object actual, System.String message)
  System.Void IsNull(T value)
  System.Void IsNull(T value, System.String message)
  System.Void IsNull(UnityEngine.Object value, System.String message)
  System.Void IsNotNull(T value)
  System.Void IsNotNull(T value, System.String message)
  System.Void IsNotNull(UnityEngine.Object value, System.String message)
  System.Void AreEqual(System.Int32 expected, System.Int32 actual)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Assertions.AssertionException
TYPE:  class
TOKEN: 0x20003A8
EXTENDS: Exception
FIELDS:
  private           System.String                   m_UserMessage  // 0x90
METHODS:
  System.Void .ctor(System.String message, System.String userMessage)
  System.String get_Message()
END_CLASS

CLASS: UnityEngine.Assertions.AssertionMessageUtil
TYPE:  class
TOKEN: 0x20003A9
FIELDS:
METHODS:
  System.String GetMessage(System.String failureMessage)
  System.String GetMessage(System.String failureMessage, System.String expected)
  System.String GetEqualityMessage(System.Object actual, System.Object expected, System.Boolean expectEqual)
  System.String NullFailureMessage(System.Object value, System.Boolean expectNull)
  System.String BooleanFailureMessage(System.Boolean expected)
END_CLASS

CLASS: UnityEngine.Device.SystemInfo
TYPE:  class
TOKEN: 0x2000386
FIELDS:
METHODS:
  System.Int32 get_systemMemorySize()
END_CLASS

CLASS: UnityEngine.Diagnostics.ForcedCrashCategory
TYPE:  struct
TOKEN: 0x2000383
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Diagnostics.ForcedCrashCategoryAccessViolation  // 0x0
  public    static  UnityEngine.Diagnostics.ForcedCrashCategoryFatalError  // 0x0
  public    static  UnityEngine.Diagnostics.ForcedCrashCategoryAbort  // 0x0
  public    static  UnityEngine.Diagnostics.ForcedCrashCategoryPureVirtualFunction  // 0x0
  public    static  UnityEngine.Diagnostics.ForcedCrashCategoryMonoAbort  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Diagnostics.AddressSanitizerCategory
TYPE:  struct
TOKEN: 0x2000384
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Diagnostics.AddressSanitizerCategoryHeapBufferOverFlow  // 0x0
  public    static  UnityEngine.Diagnostics.AddressSanitizerCategoryHeapUseAfterFree  // 0x0
  public    static  UnityEngine.Diagnostics.AddressSanitizerCategoryMemcpyParamOverlap  // 0x0
  public    static  UnityEngine.Diagnostics.AddressSanitizerCategoryDoubleFree  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Diagnostics.Utils
TYPE:  class
TOKEN: 0x2000385
FIELDS:
METHODS:
  System.Void ForceCrash(UnityEngine.Diagnostics.ForcedCrashCategory crashCategory)
  System.Void NativeAssert(System.String message)
  System.Void NativeError(System.String message)
  System.Void NativeWarning(System.String message)
  System.Void AddressSanitizer(UnityEngine.Diagnostics.AddressSanitizerCategory crashCategory)
END_CLASS

CLASS: UnityEngine.Events.PersistentListenerMode
TYPE:  struct
TOKEN: 0x200020C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Events.PersistentListenerModeEventDefined  // 0x0
  public    static  UnityEngine.Events.PersistentListenerModeVoid  // 0x0
  public    static  UnityEngine.Events.PersistentListenerModeObject  // 0x0
  public    static  UnityEngine.Events.PersistentListenerModeInt  // 0x0
  public    static  UnityEngine.Events.PersistentListenerModeFloat  // 0x0
  public    static  UnityEngine.Events.PersistentListenerModeString  // 0x0
  public    static  UnityEngine.Events.PersistentListenerModeBool  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Events.UnityEventTools
TYPE:  class
TOKEN: 0x200020D
FIELDS:
METHODS:
  System.String TidyAssemblyTypeName(System.String assemblyTypeName)
END_CLASS

CLASS: UnityEngine.Events.ArgumentCache
TYPE:  class
TOKEN: 0x200020E
FIELDS:
  private           UnityEngine.Object              m_ObjectArgument  // 0x10
  private           System.String                   m_ObjectArgumentAssemblyTypeName  // 0x18
  private           System.Int32                    m_IntArgument  // 0x20
  private           System.Single                   m_FloatArgument  // 0x24
  private           System.String                   m_StringArgument  // 0x28
  private           System.Boolean                  m_BoolArgument  // 0x30
METHODS:
  UnityEngine.Object get_unityObjectArgument()
  System.String get_unityObjectArgumentAssemblyTypeName()
  System.Int32 get_intArgument()
  System.Single get_floatArgument()
  System.String get_stringArgument()
  System.Boolean get_boolArgument()
  System.Void OnBeforeSerialize()
  System.Void OnAfterDeserialize()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Events.BaseInvokableCall
TYPE:  class
TOKEN: 0x200020F
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Object target, System.Reflection.MethodInfo function)
  System.Void Invoke(System.Object[] args)
  System.Void ThrowOnInvalidArg(System.Object arg)
  System.Boolean AllowInvoke(System.Delegate delegate)
  System.Boolean Find(System.Object targetObj, System.Reflection.MethodInfo method)
END_CLASS

CLASS: UnityEngine.Events.InvokableCall
TYPE:  class
TOKEN: 0x2000210
EXTENDS: BaseInvokableCall
FIELDS:
  private           UnityEngine.Events.UnityAction  Delegate  // 0x10
METHODS:
  System.Void add_Delegate(UnityEngine.Events.UnityAction value)
  System.Void remove_Delegate(UnityEngine.Events.UnityAction value)
  System.Void .ctor(System.Object target, System.Reflection.MethodInfo theFunction)
  System.Void .ctor(UnityEngine.Events.UnityAction action)
  System.Void Invoke(System.Object[] args)
  System.Void Invoke()
  System.Boolean Find(System.Object targetObj, System.Reflection.MethodInfo method)
END_CLASS

CLASS: UnityEngine.Events.InvokableCall`1
TYPE:  class
TOKEN: 0x2000211
EXTENDS: BaseInvokableCall
FIELDS:
  private           UnityEngine.Events.UnityAction<T1>Delegate  // 0x0
METHODS:
  System.Void add_Delegate(UnityEngine.Events.UnityAction<T1> value)
  System.Void remove_Delegate(UnityEngine.Events.UnityAction<T1> value)
  System.Void .ctor(System.Object target, System.Reflection.MethodInfo theFunction)
  System.Void .ctor(UnityEngine.Events.UnityAction<T1> action)
  System.Void Invoke(System.Object[] args)
  System.Void Invoke(T1 args0)
  System.Boolean Find(System.Object targetObj, System.Reflection.MethodInfo method)
END_CLASS

CLASS: UnityEngine.Events.InvokableCall`2
TYPE:  class
TOKEN: 0x2000212
EXTENDS: BaseInvokableCall
FIELDS:
  private           UnityEngine.Events.UnityAction<T1,T2>Delegate  // 0x0
METHODS:
  System.Void add_Delegate(UnityEngine.Events.UnityAction<T1,T2> value)
  System.Void remove_Delegate(UnityEngine.Events.UnityAction<T1,T2> value)
  System.Void .ctor(System.Object target, System.Reflection.MethodInfo theFunction)
  System.Void .ctor(UnityEngine.Events.UnityAction<T1,T2> action)
  System.Void Invoke(System.Object[] args)
  System.Void Invoke(T1 args0, T2 args1)
  System.Boolean Find(System.Object targetObj, System.Reflection.MethodInfo method)
END_CLASS

CLASS: UnityEngine.Events.InvokableCall`3
TYPE:  class
TOKEN: 0x2000213
EXTENDS: BaseInvokableCall
FIELDS:
  private           UnityEngine.Events.UnityAction<T1,T2,T3>Delegate  // 0x0
METHODS:
  System.Void add_Delegate(UnityEngine.Events.UnityAction<T1,T2,T3> value)
  System.Void remove_Delegate(UnityEngine.Events.UnityAction<T1,T2,T3> value)
  System.Void .ctor(System.Object target, System.Reflection.MethodInfo theFunction)
  System.Void .ctor(UnityEngine.Events.UnityAction<T1,T2,T3> action)
  System.Void Invoke(System.Object[] args)
  System.Void Invoke(T1 args0, T2 args1, T3 args2)
  System.Boolean Find(System.Object targetObj, System.Reflection.MethodInfo method)
END_CLASS

CLASS: UnityEngine.Events.InvokableCall`4
TYPE:  class
TOKEN: 0x2000214
EXTENDS: BaseInvokableCall
FIELDS:
  private           UnityEngine.Events.UnityAction<T1,T2,T3,T4>Delegate  // 0x0
METHODS:
  System.Void .ctor(System.Object target, System.Reflection.MethodInfo theFunction)
  System.Void Invoke(System.Object[] args)
  System.Boolean Find(System.Object targetObj, System.Reflection.MethodInfo method)
END_CLASS

CLASS: UnityEngine.Events.CachedInvokableCall`1
TYPE:  class
TOKEN: 0x2000215
EXTENDS: InvokableCall`1
FIELDS:
  private   readonly T                               m_Arg1  // 0x0
METHODS:
  System.Void .ctor(UnityEngine.Object target, System.Reflection.MethodInfo theFunction, T argument)
  System.Void Invoke(System.Object[] args)
  System.Void Invoke(T arg0)
END_CLASS

CLASS: UnityEngine.Events.UnityEventCallState
TYPE:  struct
TOKEN: 0x2000216
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Events.UnityEventCallStateOff  // 0x0
  public    static  UnityEngine.Events.UnityEventCallStateEditorAndRuntime  // 0x0
  public    static  UnityEngine.Events.UnityEventCallStateRuntimeOnly  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Events.PersistentCall
TYPE:  class
TOKEN: 0x2000217
FIELDS:
  private           UnityEngine.Object              m_Target  // 0x10
  private           System.String                   m_TargetAssemblyTypeName  // 0x18
  private           System.String                   m_MethodName  // 0x20
  private           UnityEngine.Events.PersistentListenerModem_Mode  // 0x28
  private           UnityEngine.Events.ArgumentCachem_Arguments  // 0x30
  private           UnityEngine.Events.UnityEventCallStatem_CallState  // 0x38
METHODS:
  UnityEngine.Object get_target()
  System.String get_targetAssemblyTypeName()
  System.String get_methodName()
  UnityEngine.Events.PersistentListenerMode get_mode()
  UnityEngine.Events.ArgumentCache get_arguments()
  UnityEngine.Events.UnityEventCallState get_callState()
  System.Void set_callState(UnityEngine.Events.UnityEventCallState value)
  System.Boolean IsValid()
  UnityEngine.Events.BaseInvokableCall GetRuntimeCall(UnityEngine.Events.UnityEventBase theEvent)
  UnityEngine.Events.BaseInvokableCall GetObjectCall(UnityEngine.Object target, System.Reflection.MethodInfo method, UnityEngine.Events.ArgumentCache arguments)
  System.Void OnBeforeSerialize()
  System.Void OnAfterDeserialize()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Events.PersistentCallGroup
TYPE:  class
TOKEN: 0x2000218
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.Events.PersistentCall>m_Calls  // 0x10
METHODS:
  System.Void .ctor()
  System.Int32 get_Count()
  UnityEngine.Events.PersistentCall GetListener(System.Int32 index)
  System.Void Initialize(UnityEngine.Events.InvokableCallList invokableList, UnityEngine.Events.UnityEventBase unityEventBase)
END_CLASS

CLASS: UnityEngine.Events.InvokableCallList
TYPE:  class
TOKEN: 0x2000219
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall>m_PersistentCalls  // 0x10
  private           System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall>m_RuntimeCalls  // 0x18
  private           System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall>m_ExecutingCalls  // 0x20
  private           System.Boolean                  m_NeedsUpdate  // 0x28
  private   static  System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall>s_Empty  // 0x0
METHODS:
  System.Void AddPersistentInvokableCall(UnityEngine.Events.BaseInvokableCall call)
  System.Void AddListener(UnityEngine.Events.BaseInvokableCall call)
  System.Void RemoveListener(System.Object targetObj, System.Reflection.MethodInfo method)
  System.Void Clear()
  System.Void ClearPersistent()
  System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> PrepareInvoke()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Events.UnityEventBase
TYPE:  class
TOKEN: 0x200021A
FIELDS:
  private           UnityEngine.Events.InvokableCallListm_Calls  // 0x10
  private           UnityEngine.Events.PersistentCallGroupm_PersistentCalls  // 0x18
  private           System.Boolean                  m_CallsDirty  // 0x20
METHODS:
  System.Void .ctor()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  System.Reflection.MethodInfo FindMethod_Impl(System.String name, System.Object targetObj)
  System.Reflection.MethodInfo FindMethod_Impl(System.String name, System.Type targetObjType)
  UnityEngine.Events.BaseInvokableCall GetDelegate(System.Object target, System.Reflection.MethodInfo theFunction)
  System.Reflection.MethodInfo FindMethod(UnityEngine.Events.PersistentCall call)
  System.Reflection.MethodInfo FindMethod(System.String name, System.Type listenerType, UnityEngine.Events.PersistentListenerMode mode, System.Type argumentType)
  System.Int32 GetPersistentEventCount()
  UnityEngine.Object GetPersistentTarget(System.Int32 index)
  System.String GetPersistentMethodName(System.Int32 index)
  System.Void DirtyPersistentCalls()
  System.Void RebuildPersistentCallsIfNeeded()
  System.Void SetPersistentListenerState(System.Int32 index, UnityEngine.Events.UnityEventCallState state)
  UnityEngine.Events.UnityEventCallState GetPersistentListenerState(System.Int32 index)
  System.Void AddListener(System.Object targetObj, System.Reflection.MethodInfo method)
  System.Void AddCall(UnityEngine.Events.BaseInvokableCall call)
  System.Void RemoveListener(System.Object targetObj, System.Reflection.MethodInfo method)
  System.Void RemoveAllListeners()
  System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> PrepareInvoke()
  System.Void Invoke(System.Object[] parameters)
  System.String ToString()
  System.Reflection.MethodInfo GetValidMethodInfo(System.Object obj, System.String functionName, System.Type[] argumentTypes)
  System.Reflection.MethodInfo GetValidMethodInfo(System.Type objectType, System.String functionName, System.Type[] argumentTypes)
END_CLASS

CLASS: UnityEngine.Events.UnityAction
TYPE:  class
TOKEN: 0x200021B
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
END_CLASS

CLASS: UnityEngine.Events.UnityEvent
TYPE:  class
TOKEN: 0x200021C
EXTENDS: UnityEventBase
FIELDS:
  private           System.Object[]                 m_InvokeArray  // 0x28
METHODS:
  System.Void .ctor()
  System.Void AddListener(UnityEngine.Events.UnityAction call)
  System.Void RemoveListener(UnityEngine.Events.UnityAction call)
  System.Reflection.MethodInfo FindMethod_Impl(System.String name, System.Type targetObjType)
  UnityEngine.Events.BaseInvokableCall GetDelegate(System.Object target, System.Reflection.MethodInfo theFunction)
  UnityEngine.Events.BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction action)
  System.Void Invoke()
END_CLASS

CLASS: UnityEngine.Events.UnityAction`1
TYPE:  class
TOKEN: 0x200021D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T0 arg0)
END_CLASS

CLASS: UnityEngine.Events.UnityEvent`1
TYPE:  class
TOKEN: 0x200021E
EXTENDS: UnityEventBase
FIELDS:
  private           System.Object[]                 m_InvokeArray  // 0x0
METHODS:
  System.Void .ctor()
  System.Void AddListener(UnityEngine.Events.UnityAction<T0> call)
  System.Void RemoveListener(UnityEngine.Events.UnityAction<T0> call)
  System.Reflection.MethodInfo FindMethod_Impl(System.String name, System.Type targetObjType)
  UnityEngine.Events.BaseInvokableCall GetDelegate(System.Object target, System.Reflection.MethodInfo theFunction)
  UnityEngine.Events.BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction<T0> action)
  System.Void Invoke(T0 arg0)
END_CLASS

CLASS: UnityEngine.Events.UnityAction`2
TYPE:  class
TOKEN: 0x200021F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T0 arg0, T1 arg1)
END_CLASS

CLASS: UnityEngine.Events.UnityEvent`2
TYPE:  class
TOKEN: 0x2000220
EXTENDS: UnityEventBase
FIELDS:
  private           System.Object[]                 m_InvokeArray  // 0x0
METHODS:
  System.Void .ctor()
  System.Void AddListener(UnityEngine.Events.UnityAction<T0,T1> call)
  System.Void RemoveListener(UnityEngine.Events.UnityAction<T0,T1> call)
  System.Reflection.MethodInfo FindMethod_Impl(System.String name, System.Type targetObjType)
  UnityEngine.Events.BaseInvokableCall GetDelegate(System.Object target, System.Reflection.MethodInfo theFunction)
  UnityEngine.Events.BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction<T0,T1> action)
  System.Void Invoke(T0 arg0, T1 arg1)
END_CLASS

CLASS: UnityEngine.Events.UnityAction`3
TYPE:  class
TOKEN: 0x2000221
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T0 arg0, T1 arg1, T2 arg2)
END_CLASS

CLASS: UnityEngine.Events.UnityEvent`3
TYPE:  class
TOKEN: 0x2000222
EXTENDS: UnityEventBase
FIELDS:
  private           System.Object[]                 m_InvokeArray  // 0x0
METHODS:
  System.Void .ctor()
  System.Void AddListener(UnityEngine.Events.UnityAction<T0,T1,T2> call)
  System.Void RemoveListener(UnityEngine.Events.UnityAction<T0,T1,T2> call)
  System.Reflection.MethodInfo FindMethod_Impl(System.String name, System.Type targetObjType)
  UnityEngine.Events.BaseInvokableCall GetDelegate(System.Object target, System.Reflection.MethodInfo theFunction)
  UnityEngine.Events.BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction<T0,T1,T2> action)
  System.Void Invoke(T0 arg0, T1 arg1, T2 arg2)
END_CLASS

CLASS: UnityEngine.Events.UnityAction`4
TYPE:  class
TOKEN: 0x2000223
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3)
END_CLASS

CLASS: UnityEngine.Events.UnityEvent`4
TYPE:  class
TOKEN: 0x2000224
EXTENDS: UnityEventBase
FIELDS:
  private           System.Object[]                 m_InvokeArray  // 0x0
METHODS:
  System.Void .ctor()
  System.Reflection.MethodInfo FindMethod_Impl(System.String name, System.Type targetObjType)
  UnityEngine.Events.BaseInvokableCall GetDelegate(System.Object target, System.Reflection.MethodInfo theFunction)
END_CLASS

CLASS: UnityEngine.Experimental.GlobalIllumination.LightType
TYPE:  struct
TOKEN: 0x2000389
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  UnityEngine.Experimental.GlobalIllumination.LightTypeDirectional  // 0x0
  public    static  UnityEngine.Experimental.GlobalIllumination.LightTypePoint  // 0x0
  public    static  UnityEngine.Experimental.GlobalIllumination.LightTypeSpot  // 0x0
  public    static  UnityEngine.Experimental.GlobalIllumination.LightTypeRectangle  // 0x0
  public    static  UnityEngine.Experimental.GlobalIllumination.LightTypeDisc  // 0x0
  public    static  UnityEngine.Experimental.GlobalIllumination.LightTypeSpotPyramidShape  // 0x0
  public    static  UnityEngine.Experimental.GlobalIllumination.LightTypeSpotBoxShape  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.GlobalIllumination.LightMode
TYPE:  struct
TOKEN: 0x200038A
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  UnityEngine.Experimental.GlobalIllumination.LightModeRealtime  // 0x0
  public    static  UnityEngine.Experimental.GlobalIllumination.LightModeMixed  // 0x0
  public    static  UnityEngine.Experimental.GlobalIllumination.LightModeBaked  // 0x0
  public    static  UnityEngine.Experimental.GlobalIllumination.LightModeUnknown  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.GlobalIllumination.FalloffType
TYPE:  struct
TOKEN: 0x200038B
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  UnityEngine.Experimental.GlobalIllumination.FalloffTypeInverseSquared  // 0x0
  public    static  UnityEngine.Experimental.GlobalIllumination.FalloffTypeInverseSquaredNoRangeAttenuation  // 0x0
  public    static  UnityEngine.Experimental.GlobalIllumination.FalloffTypeLinear  // 0x0
  public    static  UnityEngine.Experimental.GlobalIllumination.FalloffTypeLegacy  // 0x0
  public    static  UnityEngine.Experimental.GlobalIllumination.FalloffTypeUndefined  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.GlobalIllumination.AngularFalloffType
TYPE:  struct
TOKEN: 0x200038C
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  UnityEngine.Experimental.GlobalIllumination.AngularFalloffTypeLUT  // 0x0
  public    static  UnityEngine.Experimental.GlobalIllumination.AngularFalloffTypeAnalyticAndInnerAngle  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.GlobalIllumination.LinearColor
TYPE:  struct
TOKEN: 0x200038D
FIELDS:
  private           System.Single                   m_red  // 0x10
  private           System.Single                   m_green  // 0x14
  private           System.Single                   m_blue  // 0x18
  private           System.Single                   m_intensity  // 0x1C
METHODS:
  System.Single get_red()
  System.Void set_red(System.Single value)
  System.Single get_green()
  System.Void set_green(System.Single value)
  System.Single get_blue()
  System.Void set_blue(System.Single value)
  UnityEngine.Experimental.GlobalIllumination.LinearColor Convert(UnityEngine.Color color, System.Single intensity)
  UnityEngine.Experimental.GlobalIllumination.LinearColor Black()
END_CLASS

CLASS: UnityEngine.Experimental.GlobalIllumination.DirectionalLight
TYPE:  struct
TOKEN: 0x200038E
FIELDS:
  public            System.Int32                    instanceID  // 0x10
  public            System.Boolean                  shadow  // 0x14
  public            UnityEngine.Experimental.GlobalIllumination.LightModemode  // 0x15
  public            UnityEngine.Vector3             position  // 0x18
  public            UnityEngine.Quaternion          orientation  // 0x24
  public            UnityEngine.Experimental.GlobalIllumination.LinearColorcolor  // 0x34
  public            UnityEngine.Experimental.GlobalIllumination.LinearColorindirectColor  // 0x44
  public            System.Single                   penumbraWidthRadian  // 0x54
  public            UnityEngine.Vector3             direction  // 0x58
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.GlobalIllumination.PointLight
TYPE:  struct
TOKEN: 0x200038F
FIELDS:
  public            System.Int32                    instanceID  // 0x10
  public            System.Boolean                  shadow  // 0x14
  public            UnityEngine.Experimental.GlobalIllumination.LightModemode  // 0x15
  public            UnityEngine.Vector3             position  // 0x18
  public            UnityEngine.Quaternion          orientation  // 0x24
  public            UnityEngine.Experimental.GlobalIllumination.LinearColorcolor  // 0x34
  public            UnityEngine.Experimental.GlobalIllumination.LinearColorindirectColor  // 0x44
  public            System.Single                   range  // 0x54
  public            System.Single                   sphereRadius  // 0x58
  public            UnityEngine.Experimental.GlobalIllumination.FalloffTypefalloff  // 0x5C
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.GlobalIllumination.SpotLight
TYPE:  struct
TOKEN: 0x2000390
FIELDS:
  public            System.Int32                    instanceID  // 0x10
  public            System.Boolean                  shadow  // 0x14
  public            UnityEngine.Experimental.GlobalIllumination.LightModemode  // 0x15
  public            UnityEngine.Vector3             position  // 0x18
  public            UnityEngine.Quaternion          orientation  // 0x24
  public            UnityEngine.Experimental.GlobalIllumination.LinearColorcolor  // 0x34
  public            UnityEngine.Experimental.GlobalIllumination.LinearColorindirectColor  // 0x44
  public            System.Single                   range  // 0x54
  public            System.Single                   sphereRadius  // 0x58
  public            System.Single                   coneAngle  // 0x5C
  public            System.Single                   innerConeAngle  // 0x60
  public            UnityEngine.Experimental.GlobalIllumination.FalloffTypefalloff  // 0x64
  public            UnityEngine.Experimental.GlobalIllumination.AngularFalloffTypeangularFalloff  // 0x65
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.GlobalIllumination.RectangleLight
TYPE:  struct
TOKEN: 0x2000391
FIELDS:
  public            System.Int32                    instanceID  // 0x10
  public            System.Boolean                  shadow  // 0x14
  public            UnityEngine.Experimental.GlobalIllumination.LightModemode  // 0x15
  public            UnityEngine.Vector3             position  // 0x18
  public            UnityEngine.Quaternion          orientation  // 0x24
  public            UnityEngine.Experimental.GlobalIllumination.LinearColorcolor  // 0x34
  public            UnityEngine.Experimental.GlobalIllumination.LinearColorindirectColor  // 0x44
  public            System.Single                   range  // 0x54
  public            System.Single                   width  // 0x58
  public            System.Single                   height  // 0x5C
  public            UnityEngine.Experimental.GlobalIllumination.FalloffTypefalloff  // 0x60
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.GlobalIllumination.DiscLight
TYPE:  struct
TOKEN: 0x2000392
FIELDS:
  public            System.Int32                    instanceID  // 0x10
  public            System.Boolean                  shadow  // 0x14
  public            UnityEngine.Experimental.GlobalIllumination.LightModemode  // 0x15
  public            UnityEngine.Vector3             position  // 0x18
  public            UnityEngine.Quaternion          orientation  // 0x24
  public            UnityEngine.Experimental.GlobalIllumination.LinearColorcolor  // 0x34
  public            UnityEngine.Experimental.GlobalIllumination.LinearColorindirectColor  // 0x44
  public            System.Single                   range  // 0x54
  public            System.Single                   radius  // 0x58
  public            UnityEngine.Experimental.GlobalIllumination.FalloffTypefalloff  // 0x5C
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.GlobalIllumination.Cookie
TYPE:  struct
TOKEN: 0x2000393
FIELDS:
  public            System.Int32                    instanceID  // 0x10
  public            System.Single                   scale  // 0x14
  public            UnityEngine.Vector2             sizes  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.GlobalIllumination.LightDataGI
TYPE:  struct
TOKEN: 0x2000394
FIELDS:
  public            System.Int32                    instanceID  // 0x10
  public            System.Int32                    cookieID  // 0x14
  public            System.Single                   cookieScale  // 0x18
  public            UnityEngine.Experimental.GlobalIllumination.LinearColorcolor  // 0x1C
  public            UnityEngine.Experimental.GlobalIllumination.LinearColorindirectColor  // 0x2C
  public            UnityEngine.Quaternion          orientation  // 0x3C
  public            UnityEngine.Vector3             position  // 0x4C
  public            System.Single                   range  // 0x58
  public            System.Single                   coneAngle  // 0x5C
  public            System.Single                   innerConeAngle  // 0x60
  public            System.Single                   shape0  // 0x64
  public            System.Single                   shape1  // 0x68
  public            UnityEngine.Experimental.GlobalIllumination.LightTypetype  // 0x6C
  public            UnityEngine.Experimental.GlobalIllumination.LightModemode  // 0x6D
  public            System.Byte                     shadow  // 0x6E
  public            UnityEngine.Experimental.GlobalIllumination.FalloffTypefalloff  // 0x6F
METHODS:
  System.Void Init(UnityEngine.Experimental.GlobalIllumination.DirectionalLight& light, UnityEngine.Experimental.GlobalIllumination.Cookie& cookie)
  System.Void Init(UnityEngine.Experimental.GlobalIllumination.PointLight& light, UnityEngine.Experimental.GlobalIllumination.Cookie& cookie)
  System.Void Init(UnityEngine.Experimental.GlobalIllumination.SpotLight& light, UnityEngine.Experimental.GlobalIllumination.Cookie& cookie)
  System.Void Init(UnityEngine.Experimental.GlobalIllumination.RectangleLight& light, UnityEngine.Experimental.GlobalIllumination.Cookie& cookie)
  System.Void Init(UnityEngine.Experimental.GlobalIllumination.DiscLight& light, UnityEngine.Experimental.GlobalIllumination.Cookie& cookie)
  System.Void InitNoBake(System.Int32 lightInstanceID)
END_CLASS

CLASS: UnityEngine.Experimental.GlobalIllumination.LightmapperUtils
TYPE:  class
TOKEN: 0x2000395
FIELDS:
METHODS:
  UnityEngine.Experimental.GlobalIllumination.LightMode Extract(UnityEngine.LightmapBakeType baketype)
  UnityEngine.Experimental.GlobalIllumination.LinearColor ExtractIndirect(UnityEngine.Light l)
  System.Single ExtractInnerCone(UnityEngine.Light l)
  UnityEngine.Color ExtractColorTemperature(UnityEngine.Light l)
  System.Void ApplyColorTemperature(UnityEngine.Color cct, UnityEngine.Experimental.GlobalIllumination.LinearColor& lightColor)
  System.Void Extract(UnityEngine.Light l, UnityEngine.Experimental.GlobalIllumination.DirectionalLight& dir)
  System.Void Extract(UnityEngine.Light l, UnityEngine.Experimental.GlobalIllumination.PointLight& point)
  System.Void Extract(UnityEngine.Light l, UnityEngine.Experimental.GlobalIllumination.SpotLight& spot)
  System.Void Extract(UnityEngine.Light l, UnityEngine.Experimental.GlobalIllumination.RectangleLight& rect)
  System.Void Extract(UnityEngine.Light l, UnityEngine.Experimental.GlobalIllumination.DiscLight& disc)
  System.Void Extract(UnityEngine.Light l, UnityEngine.Experimental.GlobalIllumination.Cookie& cookie)
END_CLASS

CLASS: UnityEngine.Experimental.GlobalIllumination.Lightmapping
TYPE:  class
TOKEN: 0x2000396
FIELDS:
  private   static readonly UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegates_DefaultDelegate  // 0x0
  private   static  UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegates_RequestLightsDelegate  // 0x8
METHODS:
  System.Void SetDelegate(UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate del)
  UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate GetDelegate()
  System.Void ResetDelegate()
  System.Void RequestLights(UnityEngine.Light[] lights, System.IntPtr outLightsPtr, System.Int32 outLightsCount)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Experimental.Playables.CameraPlayable
TYPE:  struct
TOKEN: 0x2000399
FIELDS:
  private           UnityEngine.Playables.PlayableHandlem_Handle  // 0x10
METHODS:
  UnityEngine.Playables.PlayableHandle GetHandle()
  System.Boolean Equals(UnityEngine.Experimental.Playables.CameraPlayable other)
END_CLASS

CLASS: UnityEngine.Experimental.Playables.MaterialEffectPlayable
TYPE:  struct
TOKEN: 0x200039A
FIELDS:
  private           UnityEngine.Playables.PlayableHandlem_Handle  // 0x10
METHODS:
  UnityEngine.Playables.PlayableHandle GetHandle()
  System.Boolean Equals(UnityEngine.Experimental.Playables.MaterialEffectPlayable other)
END_CLASS

CLASS: UnityEngine.Experimental.Playables.TextureMixerPlayable
TYPE:  struct
TOKEN: 0x200039B
FIELDS:
  private           UnityEngine.Playables.PlayableHandlem_Handle  // 0x10
METHODS:
  UnityEngine.Playables.PlayableHandle GetHandle()
  System.Boolean Equals(UnityEngine.Experimental.Playables.TextureMixerPlayable other)
END_CLASS

CLASS: UnityEngine.Experimental.Playables.TexturePlayableOutput
TYPE:  struct
TOKEN: 0x200039C
FIELDS:
  private           UnityEngine.Playables.PlayableOutputHandlem_Handle  // 0x10
METHODS:
  UnityEngine.Playables.PlayableOutputHandle GetHandle()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.BuiltinRuntimeReflectionSystem
TYPE:  class
TOKEN: 0x200039D
FIELDS:
METHODS:
  System.Boolean TickRealtimeProbes()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Boolean BuiltinUpdate()
  UnityEngine.Experimental.Rendering.BuiltinRuntimeReflectionSystem Internal_BuiltinRuntimeReflectionSystem_New()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem
TYPE:  interface
TOKEN: 0x200039E
FIELDS:
METHODS:
  System.Boolean TickRealtimeProbes()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemSettings
TYPE:  class
TOKEN: 0x200039F
FIELDS:
  private   static  UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemWrappers_Instance  // 0x0
METHODS:
  System.Void set_Internal_ScriptableRuntimeReflectionSystemSettings_system(UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem value)
  UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemWrapper get_Internal_ScriptableRuntimeReflectionSystemSettings_instance()
  System.Void ScriptingDirtyReflectionSystemInstance()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemWrapper
TYPE:  class
TOKEN: 0x20003A0
FIELDS:
  private           UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem<implementation>k__BackingField  // 0x10
METHODS:
  UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem get_implementation()
  System.Void set_implementation(UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem value)
  System.Void Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes(System.Boolean& result)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.TextureCreationFlags
TYPE:  struct
TOKEN: 0x20003A1
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Experimental.Rendering.TextureCreationFlagsNone  // 0x0
  public    static  UnityEngine.Experimental.Rendering.TextureCreationFlagsMipChain  // 0x0
  public    static  UnityEngine.Experimental.Rendering.TextureCreationFlagsCrunch  // 0x0
  public    static  UnityEngine.Experimental.Rendering.TextureCreationFlagsHGDisableDefragmentation  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.FormatUsage
TYPE:  struct
TOKEN: 0x20003A2
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Experimental.Rendering.FormatUsageSample  // 0x0
  public    static  UnityEngine.Experimental.Rendering.FormatUsageLinear  // 0x0
  public    static  UnityEngine.Experimental.Rendering.FormatUsageSparse  // 0x0
  public    static  UnityEngine.Experimental.Rendering.FormatUsageRender  // 0x0
  public    static  UnityEngine.Experimental.Rendering.FormatUsageBlend  // 0x0
  public    static  UnityEngine.Experimental.Rendering.FormatUsageGetPixels  // 0x0
  public    static  UnityEngine.Experimental.Rendering.FormatUsageSetPixels  // 0x0
  public    static  UnityEngine.Experimental.Rendering.FormatUsageSetPixels32  // 0x0
  public    static  UnityEngine.Experimental.Rendering.FormatUsageReadPixels  // 0x0
  public    static  UnityEngine.Experimental.Rendering.FormatUsageLoadStore  // 0x0
  public    static  UnityEngine.Experimental.Rendering.FormatUsageMSAA2x  // 0x0
  public    static  UnityEngine.Experimental.Rendering.FormatUsageMSAA4x  // 0x0
  public    static  UnityEngine.Experimental.Rendering.FormatUsageMSAA8x  // 0x0
  public    static  UnityEngine.Experimental.Rendering.FormatUsageStencilSampling  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.DefaultFormat
TYPE:  struct
TOKEN: 0x20003A3
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Experimental.Rendering.DefaultFormatLDR  // 0x0
  public    static  UnityEngine.Experimental.Rendering.DefaultFormatHDR  // 0x0
  public    static  UnityEngine.Experimental.Rendering.DefaultFormatDepthStencil  // 0x0
  public    static  UnityEngine.Experimental.Rendering.DefaultFormatShadow  // 0x0
  public    static  UnityEngine.Experimental.Rendering.DefaultFormatVideo  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.GraphicsFormat
TYPE:  struct
TOKEN: 0x20003A4
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatNone  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR8_SRGB  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR8G8_SRGB  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR8G8B8_SRGB  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR8G8B8A8_SRGB  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR8_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR8G8_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR8G8B8_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR8G8B8A8_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR8_SNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR8G8_SNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR8G8B8_SNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR8G8B8A8_SNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR8_UInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR8G8_UInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR8G8B8_UInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR8G8B8A8_UInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR8_SInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR8G8_SInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR8G8B8_SInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR8G8B8A8_SInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR16_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR16G16_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR16G16B16_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR16G16B16A16_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR16_SNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR16G16_SNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR16G16B16_SNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR16G16B16A16_SNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR16_UInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR16G16_UInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR16G16B16_UInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR16G16B16A16_UInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR16_SInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR16G16_SInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR16G16B16_SInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR16G16B16A16_SInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR32_UInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR32G32_UInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR32G32B32_UInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR32G32B32A32_UInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR32_SInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR32G32_SInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR32G32B32_SInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR32G32B32A32_SInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR16_SFloat  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR16G16_SFloat  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR16G16B16_SFloat  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR16G16B16A16_SFloat  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR32_SFloat  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR32G32_SFloat  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR32G32B32_SFloat  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR32G32B32A32_SFloat  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatB8G8R8_SRGB  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatB8G8R8A8_SRGB  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatB8G8R8_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatB8G8R8A8_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatB8G8R8_SNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatB8G8R8A8_SNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatB8G8R8_UInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatB8G8R8A8_UInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatB8G8R8_SInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatB8G8R8A8_SInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR4G4B4A4_UNormPack16  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatB4G4R4A4_UNormPack16  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR5G6B5_UNormPack16  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatB5G6R5_UNormPack16  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR5G5B5A1_UNormPack16  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatB5G5R5A1_UNormPack16  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatA1R5G5B5_UNormPack16  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatE5B9G9R9_UFloatPack32  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatB10G11R11_UFloatPack32  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatA2B10G10R10_UNormPack32  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatA2B10G10R10_UIntPack32  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatA2B10G10R10_SIntPack32  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatA2R10G10B10_UNormPack32  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatA2R10G10B10_UIntPack32  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatA2R10G10B10_SIntPack32  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatA2R10G10B10_XRSRGBPack32  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatA2R10G10B10_XRUNormPack32  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR10G10B10_XRSRGBPack32  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR10G10B10_XRUNormPack32  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatA10R10G10B10_XRSRGBPack32  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatA10R10G10B10_XRUNormPack32  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatD16_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatD24_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatD24_UNorm_S8_UInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatD32_SFloat  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatD32_SFloat_S8_UInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatS8_UInt  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGB_DXT1_SRGB  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_DXT1_SRGB  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGB_DXT1_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_DXT1_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_DXT3_SRGB  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_DXT3_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_DXT5_SRGB  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_DXT5_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR_BC4_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR_BC4_SNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRG_BC5_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRG_BC5_SNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGB_BC6H_UFloat  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGB_BC6H_SFloat  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_BC7_SRGB  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_BC7_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGB_PVRTC_2Bpp_SRGB  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGB_PVRTC_2Bpp_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGB_PVRTC_4Bpp_SRGB  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGB_PVRTC_4Bpp_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_PVRTC_2Bpp_SRGB  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_PVRTC_2Bpp_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_PVRTC_4Bpp_SRGB  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_PVRTC_4Bpp_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGB_ETC_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGB_ETC2_SRGB  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGB_ETC2_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGB_A1_ETC2_SRGB  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGB_A1_ETC2_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_ETC2_SRGB  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_ETC2_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR_EAC_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatR_EAC_SNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRG_EAC_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRG_EAC_SNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_ASTC4X4_SRGB  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_ASTC4X4_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_ASTC5X5_SRGB  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_ASTC5X5_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_ASTC6X6_SRGB  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_ASTC6X6_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_ASTC8X8_SRGB  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_ASTC8X8_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_ASTC10X10_SRGB  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_ASTC10X10_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_ASTC12X12_SRGB  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_ASTC12X12_UNorm  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatYUV2  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatDepthAuto  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatShadowAuto  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatVideoAuto  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_ASTC4X4_UFloat  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_ASTC5X5_UFloat  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_ASTC6X6_UFloat  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_ASTC8X8_UFloat  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_ASTC10X10_UFloat  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatRGBA_ASTC12X12_UFloat  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.RayTracingMode
TYPE:  struct
TOKEN: 0x20003A5
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Experimental.Rendering.RayTracingModeOff  // 0x0
  public    static  UnityEngine.Experimental.Rendering.RayTracingModeStatic  // 0x0
  public    static  UnityEngine.Experimental.Rendering.RayTracingModeDynamicTransform  // 0x0
  public    static  UnityEngine.Experimental.Rendering.RayTracingModeDynamicGeometry  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.Rendering.GraphicsFormatUtility
TYPE:  class
TOKEN: 0x20003A6
FIELDS:
  private   static readonly UnityEngine.Experimental.Rendering.GraphicsFormat[]tableNoStencil  // 0x0
  private   static readonly UnityEngine.Experimental.Rendering.GraphicsFormat[]tableStencil  // 0x8
METHODS:
  UnityEngine.Experimental.Rendering.GraphicsFormat GetFormat(UnityEngine.Texture texture)
  UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.TextureFormat format, System.Boolean isSRGB)
  UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat_Native_TextureFormat(UnityEngine.TextureFormat format, System.Boolean isSRGB)
  UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.RenderTextureFormat format, System.Boolean isSRGB)
  UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(UnityEngine.RenderTextureFormat format, System.Boolean isSRGB)
  UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite)
  UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatFromBitsLegacy_Native(System.Int32 minimumDepthBits)
  UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormat(System.Int32 minimumDepthBits)
  System.Int32 GetDepthBits(UnityEngine.Experimental.Rendering.GraphicsFormat format)
  UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormat(System.Int32 minimumDepthBits, System.Int32 minimumStencilBits)
  System.Boolean IsSRGBFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format)
  UnityEngine.Experimental.Rendering.GraphicsFormat GetSRGBFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format)
  UnityEngine.Experimental.Rendering.GraphicsFormat GetLinearFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format)
  UnityEngine.RenderTextureFormat GetRenderTextureFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format)
  System.UInt32 GetComponentCount(UnityEngine.Experimental.Rendering.GraphicsFormat format)
  System.Boolean IsCompressedTextureFormat(UnityEngine.TextureFormat format)
  System.Boolean CanDecompressFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, System.Boolean wholeImage)
  System.Boolean CanDecompressFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format)
  System.Boolean IsAlphaOnlyFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format)
  System.Boolean IsDepthFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format)
  System.Boolean IsStencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format)
  System.Boolean IsPVRTCFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format)
  System.Boolean IsCrunchFormat(UnityEngine.TextureFormat format)
  UnityEngine.Rendering.FormatSwizzle GetSwizzleR(UnityEngine.Experimental.Rendering.GraphicsFormat format)
  UnityEngine.Rendering.FormatSwizzle GetSwizzleG(UnityEngine.Experimental.Rendering.GraphicsFormat format)
  UnityEngine.Rendering.FormatSwizzle GetSwizzleB(UnityEngine.Experimental.Rendering.GraphicsFormat format)
  UnityEngine.Rendering.FormatSwizzle GetSwizzleA(UnityEngine.Experimental.Rendering.GraphicsFormat format)
  System.UInt32 GetBlockSize(UnityEngine.Experimental.Rendering.GraphicsFormat format)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Experimental.U2D.SpriteIntermediateRendererInfo
TYPE:  struct
TOKEN: 0x2000387
FIELDS:
  public            System.Int32                    SpriteID  // 0x10
  public            System.Int32                    TextureID  // 0x14
  public            System.Int32                    MaterialID  // 0x18
  public            UnityEngine.Color               Color  // 0x1C
  public            UnityEngine.Matrix4x4           Transform  // 0x2C
  public            UnityEngine.Bounds              Bounds  // 0x6C
  public            System.Int32                    Layer  // 0x84
  public            System.Int32                    SortingLayer  // 0x88
  public            System.Int32                    SortingOrder  // 0x8C
  public            System.UInt64                   SceneCullingMask  // 0x90
  public            System.IntPtr                   IndexData  // 0x98
  public            System.IntPtr                   VertexData  // 0xA0
  public            System.Int32                    IndexCount  // 0xA8
  public            System.Int32                    VertexCount  // 0xAC
  public            System.Int32                    ShaderChannelMask  // 0xB0
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.U2D.SpriteRendererGroup
TYPE:  class
TOKEN: 0x2000388
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.ManagerContextType
TYPE:  struct
TOKEN: 0x20002E0
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryph.ManagerContextTypeHGManagerContext  // 0x0
  public    static  UnityEngine.HyperGryph.ManagerContextTypeGameplayManagerContext  // 0x0
  public    static  UnityEngine.HyperGryph.ManagerContextTypeCount  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.HGGlobalGameManagerAssetBase
TYPE:  class
TOKEN: 0x20002E1
EXTENDS: ScriptableObject
FIELDS:
METHODS:
  UnityEngine.HyperGryph.HGManagerContextBase InternalCreateManagerContext()
  UnityEngine.HyperGryph.HGManagerContextBase CreateManagerContext()
  System.Void OnDisable()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.HyperGryph.HGGlobalGameManager
TYPE:  class
TOKEN: 0x20002E2
FIELDS:
  private   static  UnityEngine.HyperGryph.HGGlobalGameManagerAssetBase[]currentManagerAssets  // 0x0
  public    static  UnityEngine.HyperGryph.HGManagerContextBase[]currentManagerContexts  // 0x8
METHODS:
  UnityEngine.ScriptableObject GetGlobalGameManagerAsset(UnityEngine.HyperGryph.ManagerContextType contextType)
  UnityEngine.HyperGryph.HGGlobalGameManagerAssetBase GetManagerAsset(UnityEngine.HyperGryph.ManagerContextType contextType)
  System.Void HandleManagerAssetChange(UnityEngine.HyperGryph.ManagerContextType contextType, UnityEngine.HyperGryph.HGGlobalGameManagerAssetBase asset)
  System.Void CleanupManagerContext(UnityEngine.HyperGryph.ManagerContextType contextType)
  System.Boolean InitializeManagerContext(UnityEngine.HyperGryph.ManagerContextType contextType, UnityEngine.HyperGryph.HGGlobalGameManagerAssetBase asset)
  System.Void ManagerContextEarlyUpdate()
  System.Void ManagerContextGameplayUpdate()
  System.Void ManagerContextPipelineUpdate()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.HyperGryph.HGManagerContextBase
TYPE:  class
TOKEN: 0x20002E3
FIELDS:
  private           System.Boolean                  <disposed>k__BackingField  // 0x10
METHODS:
  System.Void EarlyUpdate()
  System.Void GameplayUpdate()
  System.Void PipelineUpdate()
  System.Void InternalEarlyUpdate()
  System.Void InternalGameplayUpdate()
  System.Void InternalPipelineUpdate()
  System.Boolean get_disposed()
  System.Void set_disposed(System.Boolean value)
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.HyperGryph.LODCrossFadeConfig
TYPE:  struct
TOKEN: 0x20002E4
FIELDS:
  public            UnityEngine.Vector3             cameraPosition  // 0x10
  public            UnityEngine.Vector3             c0  // 0x1C
  public            UnityEngine.Vector3             c1  // 0x28
  public            System.Single                   fraction  // 0x34
  public            System.Single                   currMaxProjFactorSquared  // 0x38
  public            System.Single                   maxProjFactorSquared0  // 0x3C
  public            System.Single                   maxProjFactorSquared1  // 0x40
  public            System.Boolean                  enableDither  // 0x44
  public            System.Boolean                  isOrtho  // 0x45
  public            System.Byte                     lodBias  // 0x46
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.HGShadowCullData
TYPE:  struct
TOKEN: 0x20002E5
FIELDS:
  public            System.Boolean                  orthographic  // 0x10
  public            System.Single                   cameraNear  // 0x14
  public            System.Single                   projectionNear  // 0x18
  public            System.Single                   projectionFar  // 0x1C
  public            System.Single                   cameraFov  // 0x20
  public            System.Single                   shadowNearPlaneOffset  // 0x24
  public            System.Single                   shadowDistance  // 0x28
  public            System.Single                   baseFarDistance  // 0x2C
  public            UnityEngine.Matrix4x4           cameraClipToWorld  // 0x30
  public            UnityEngine.Matrix4x4           implicitProjection  // 0x70
  public            UnityEngine.Matrix4x4           cameraToWorld  // 0xB0
  public            UnityEngine.Vector3             eyePos  // 0xF0
  public            UnityEngine.Plane               cullingPlaneLeft  // 0xFC
  public            UnityEngine.Plane               cullingPlanesRight  // 0x10C
  public            UnityEngine.Plane               cullingPlanesBottom  // 0x11C
  public            UnityEngine.Plane               cullingPlanesTop  // 0x12C
  public            UnityEngine.Plane               cullingPlanesNear  // 0x13C
  public            UnityEngine.Plane               cullingPlanesFar  // 0x14C
  public            UnityEngine.Matrix4x4           lightLocalToWorld  // 0x15C
  public            UnityEngine.Vector3             center  // 0x19C
  public            System.Single                   radius  // 0x1A8
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.LightCullResult
TYPE:  struct
TOKEN: 0x20002E6
FIELDS:
  public            System.IntPtr                   visibleLightsPtr  // 0x10
  public            System.Int32                    visibleLightCount  // 0x18
METHODS:
  Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> get_visibleLights()
END_CLASS

CLASS: UnityEngine.HyperGryph.HGCullingSystem
TYPE:  class
TOKEN: 0x20002E7
FIELDS:
METHODS:
  System.Void set_parentLODBias(System.Single value)
  System.Void SetArtTagLODBias(System.UInt32 artTag, System.Single lodBias)
  System.UInt32 AddCullViewByMatrix(UnityEngine.Matrix4x4& viewProj, System.Int32 cameraInstantId, System.UInt64 sceneMask, System.UInt32 cullingLayerMask, System.UInt32 objectFlagsValue, System.UInt32 objectFlagsMask, UnityEngine.HyperGryph.LODCrossFadeConfig& config, System.Single viewScreenSizeMinSquared, UnityEngine.CameraType viewType, System.UInt32 uniqueId, System.Int32 depthBufferWidth, System.Int32 depthBufferHeight, UnityEngine.Vector3& cameraDir, UnityEngine.Vector4& cameraProjInfo, System.Single cullingRadius, System.Single ocScreenSizeMinSquared)
  System.UInt32 AddCullViewByPlanes(Unity.Collections.NativeArray<UnityEngine.Plane> planes, System.Int32 cameraInstantId, System.UInt64 sceneMask, System.UInt32 cullingLayerMask, System.UInt32 objectFlagsValue, System.UInt32 objectFlagsMask, UnityEngine.HyperGryph.LODCrossFadeConfig& config, System.Single viewScreenSizeMinSquared, UnityEngine.CameraType viewType)
  System.UInt32 RegisterCullViewUniqueId(System.Int32 instanceId)
  System.Void UnregisterCullViewUniqueId(System.UInt32 cullViewUniqueId)
  System.UInt32 AddCullViewByPlanes(System.IntPtr planes, System.Int32 planeCount, System.Int32 cameraInstantId, System.UInt64 sceneMask, System.UInt32 cullingLayerMask, System.UInt32 objectFlagsValue, System.UInt32 objectFlagsMask, UnityEngine.HyperGryph.LODCrossFadeConfig& config, System.Single viewScreenSizeMinSquared, UnityEngine.CameraType viewType, System.UInt32 uniqueId, System.Int32 depthBufferWidth, System.Int32 depthBufferHeight, UnityEngine.Matrix4x4& cullingMatrix, UnityEngine.Vector3& cameraDir, UnityEngine.Vector4& cameraProjInfo, System.Single cullingRadius, System.Single ocScreenSizeMinSquared)
  System.Void DispatchBatchCullingJobs()
  Unity.Jobs.JobHandle GetCullingViewFence(System.UInt32 viewHandle)
  System.Void ExtractShadowCullDataForDirLight(UnityEngine.Camera camera, UnityEngine.Matrix4x4 lightLocalToWorld, System.Single shadowMaxDistance, System.Single nearPlaneOffset, UnityEngine.HyperGryph.HGShadowCullData& shadowCullData)
  System.Void GetPSSMSplitMatrices(UnityEngine.HyperGryph.HGShadowCullData& shadowCullData, System.Single splitPercentage0, System.Single splitPercentage1, System.Int32 shadowResolution, UnityEngine.Matrix4x4& outViewMatrix, UnityEngine.Matrix4x4& outProjMatrix, UnityEngine.Matrix4x4& outProjFlipYMatrix, UnityEngine.Rendering.ShadowSplitData& outSplitData)
  UnityEngine.HyperGryph.LightCullResult CullLights(System.UInt32 viewHandle, UnityEngine.Vector3 cameraPosition, System.UInt32 maxCount, System.Int32 cameraInstanceId)
  System.Void CullLightsInternal(System.UInt32 viewHandle, UnityEngine.Vector3 cameraPosition, System.UInt32 maxCount, System.Int32 cameraInstanceId, System.IntPtr result)
  System.Void GetCullingViewFence_Injected(System.UInt32 viewHandle, Unity.Jobs.JobHandle& ret)
  System.Void ExtractShadowCullDataForDirLight_Injected(UnityEngine.Camera camera, UnityEngine.Matrix4x4& lightLocalToWorld, System.Single shadowMaxDistance, System.Single nearPlaneOffset, UnityEngine.HyperGryph.HGShadowCullData& shadowCullData)
  System.Void CullLightsInternal_Injected(System.UInt32 viewHandle, UnityEngine.Vector3& cameraPosition, System.UInt32 maxCount, System.Int32 cameraInstanceId, System.IntPtr result)
END_CLASS

CLASS: UnityEngine.Internal.DefaultValueAttribute
TYPE:  class
TOKEN: 0x20002DE
EXTENDS: Attribute
FIELDS:
  private           System.Object                   DefaultValue  // 0x10
METHODS:
  System.Void .ctor(System.String value)
  System.Object get_Value()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Internal.ExcludeFromDocsAttribute
TYPE:  class
TOKEN: 0x20002DF
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Jobs.IJobParallelForTransform
TYPE:  interface
TOKEN: 0x20001DE
FIELDS:
METHODS:
  System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform)
END_CLASS

CLASS: UnityEngine.Jobs.IJobCrossFrameTransform
TYPE:  interface
TOKEN: 0x20001DF
FIELDS:
METHODS:
  System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform)
END_CLASS

CLASS: UnityEngine.Jobs.IJobParallelForTransformExtensions
TYPE:  class
TOKEN: 0x20001E0
FIELDS:
METHODS:
  Unity.Jobs.JobHandle Schedule(T jobData, UnityEngine.Jobs.TransformAccessArray transforms, Unity.Jobs.JobHandle dependsOn)
  Unity.Jobs.JobHandle ScheduleReadOnly(T jobData, UnityEngine.Jobs.TransformAccessArray transforms, System.Int32 batchSize, Unity.Jobs.JobHandle dependsOn)
  System.Void RunReadOnly(T jobData, UnityEngine.Jobs.TransformAccessArray transforms)
  Unity.Jobs.JobHandle ScheduleCrossFrameReadOnly(T jobData, UnityEngine.Jobs.TransformAccessArray transforms, Unity.Jobs.JobHandle dependsOn)
  Unity.Jobs.JobHandle ScheduleCrossFrame(T jobData, UnityEngine.Jobs.TransformAccessArray transforms, Unity.Jobs.JobHandle dependsOn)
END_CLASS

CLASS: UnityEngine.Jobs.TransformAccess
TYPE:  struct
TOKEN: 0x20001E7
FIELDS:
  private           System.IntPtr                   hierarchy  // 0x10
  private           System.Int32                    index  // 0x18
METHODS:
  UnityEngine.Vector3 get_position()
  System.Void set_position(UnityEngine.Vector3 value)
  UnityEngine.Quaternion get_rotation()
  System.Void set_rotation(UnityEngine.Quaternion value)
  UnityEngine.Vector3 get_localPosition()
  System.Void set_localPosition(UnityEngine.Vector3 value)
  UnityEngine.Quaternion get_localRotation()
  System.Void set_localRotation(UnityEngine.Quaternion value)
  UnityEngine.Vector3 get_localScale()
  System.Void set_localScale(UnityEngine.Vector3 value)
  UnityEngine.Matrix4x4 get_localToWorldMatrix()
  System.Boolean get_isValid()
  System.Void GetPosition(UnityEngine.Jobs.TransformAccess& access, UnityEngine.Vector3& p)
  System.Void SetPosition(UnityEngine.Jobs.TransformAccess& access, UnityEngine.Vector3& p)
  System.Void GetRotation(UnityEngine.Jobs.TransformAccess& access, UnityEngine.Quaternion& r)
  System.Void SetRotation(UnityEngine.Jobs.TransformAccess& access, UnityEngine.Quaternion& r)
  System.Void GetLocalPosition(UnityEngine.Jobs.TransformAccess& access, UnityEngine.Vector3& p)
  System.Void SetLocalPosition(UnityEngine.Jobs.TransformAccess& access, UnityEngine.Vector3& p)
  System.Void GetLocalRotation(UnityEngine.Jobs.TransformAccess& access, UnityEngine.Quaternion& r)
  System.Void SetLocalRotation(UnityEngine.Jobs.TransformAccess& access, UnityEngine.Quaternion& r)
  System.Void GetLocalScale(UnityEngine.Jobs.TransformAccess& access, UnityEngine.Vector3& r)
  System.Void SetLocalScale(UnityEngine.Jobs.TransformAccess& access, UnityEngine.Vector3& r)
  System.Void GetLocalToWorldMatrix(UnityEngine.Jobs.TransformAccess& access, UnityEngine.Matrix4x4& m)
END_CLASS

CLASS: UnityEngine.Jobs.TransformAccessArray
TYPE:  struct
TOKEN: 0x20001E8
FIELDS:
  private           System.IntPtr                   m_TransformArray  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.Transform[] transforms, System.Int32 desiredJobCount)
  System.Void .ctor(System.Int32 capacity, System.Int32 desiredJobCount)
  System.Void Allocate(System.Int32 capacity, System.Int32 desiredJobCount, UnityEngine.Jobs.TransformAccessArray& array)
  System.Boolean get_isCreated()
  System.Void Dispose()
  System.IntPtr GetTransformAccessArrayForSchedule()
  UnityEngine.Transform get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, UnityEngine.Transform value)
  System.Int32 get_length()
  System.Void Add(UnityEngine.Transform transform)
  System.IntPtr Create(System.Int32 capacity, System.Int32 desiredJobCount)
  System.Void DestroyTransformAccessArray(System.IntPtr transformArray)
  System.Void SetTransforms(System.IntPtr transformArrayIntPtr, UnityEngine.Transform[] transforms)
  System.Void Add(System.IntPtr transformArrayIntPtr, UnityEngine.Transform transform)
  System.IntPtr GetSortedTransformAccess(System.IntPtr transformArrayIntPtr)
  System.IntPtr GetSortedToUserIndex(System.IntPtr transformArrayIntPtr)
  System.Int32 GetLength(System.IntPtr transformArrayIntPtr)
  UnityEngine.Transform GetTransform(System.IntPtr transformArrayIntPtr, System.Int32 index)
  System.Void SetTransform(System.IntPtr transformArrayIntPtr, System.Int32 index, UnityEngine.Transform transform)
END_CLASS

CLASS: UnityEngine.LowLevel.PlayerLoopSystemInternal
TYPE:  struct
TOKEN: 0x2000234
FIELDS:
  public            System.Type                     type  // 0x10
  public            UnityEngine.LowLevel.PlayerLoopSystem.UpdateFunctionupdateDelegate  // 0x18
  public            System.IntPtr                   updateFunction  // 0x20
  public            System.IntPtr                   loopConditionFunction  // 0x28
  public            System.Int32                    numSubSystems  // 0x30
METHODS:
END_CLASS

CLASS: UnityEngine.LowLevel.PlayerLoopSystem
TYPE:  struct
TOKEN: 0x2000235
FIELDS:
  public            System.Type                     type  // 0x10
  public            UnityEngine.LowLevel.PlayerLoopSystem[]subSystemList  // 0x18
  public            UnityEngine.LowLevel.PlayerLoopSystem.UpdateFunctionupdateDelegate  // 0x20
  public            System.IntPtr                   updateFunction  // 0x28
  public            System.IntPtr                   loopConditionFunction  // 0x30
METHODS:
  System.String ToString()
END_CLASS

CLASS: UnityEngine.LowLevel.PlayerLoop
TYPE:  class
TOKEN: 0x2000237
FIELDS:
METHODS:
  UnityEngine.LowLevel.PlayerLoopSystem GetCurrentPlayerLoop()
  System.Void SetPlayerLoop(UnityEngine.LowLevel.PlayerLoopSystem loop)
  System.Int32 PlayerLoopSystemToInternal(UnityEngine.LowLevel.PlayerLoopSystem sys, System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystemInternal>& internalSys)
  UnityEngine.LowLevel.PlayerLoopSystem InternalToPlayerLoopSystem(UnityEngine.LowLevel.PlayerLoopSystemInternal[] internalSys, System.Int32& offset)
  UnityEngine.LowLevel.PlayerLoopSystemInternal[] GetCurrentPlayerLoopInternal()
  System.Void SetPlayerLoopInternal(UnityEngine.LowLevel.PlayerLoopSystemInternal[] loop)
END_CLASS

CLASS: UnityEngine.Networking.PlayerConnection.MessageEventArgs
TYPE:  class
TOKEN: 0x20002D1
FIELDS:
  public            System.Int32                    playerId  // 0x10
  public            System.Byte[]                   data  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Networking.PlayerConnection.IEditorPlayerConnection
TYPE:  interface
TOKEN: 0x20002D2
FIELDS:
METHODS:
  System.Void Register(System.Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback)
  System.Void RegisterConnection(UnityEngine.Events.UnityAction<System.Int32> callback)
  System.Void RegisterDisconnection(UnityEngine.Events.UnityAction<System.Int32> callback)
  System.Void Send(System.Guid messageId, System.Byte[] data)
END_CLASS

CLASS: UnityEngine.Networking.PlayerConnection.PlayerConnection
TYPE:  class
TOKEN: 0x20002D3
EXTENDS: ScriptableObject
FIELDS:
  private   static  UnityEngine.IPlayerEditorConnectionNativeconnectionNative  // 0x0
  private           UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEventsm_PlayerEditorConnectionEvents  // 0x18
  private           System.Collections.Generic.List<System.Int32>m_connectedPlayers  // 0x20
  private           System.Boolean                  m_IsInitilized  // 0x28
  private   static  UnityEngine.Networking.PlayerConnection.PlayerConnections_Instance  // 0x8
METHODS:
  UnityEngine.Networking.PlayerConnection.PlayerConnection get_instance()
  System.Boolean get_isConnected()
  UnityEngine.Networking.PlayerConnection.PlayerConnection CreateInstance()
  System.Void OnEnable()
  UnityEngine.IPlayerEditorConnectionNative GetConnectionNativeApi()
  System.Void Register(System.Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback)
  System.Void Unregister(System.Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback)
  System.Void RegisterConnection(UnityEngine.Events.UnityAction<System.Int32> callback)
  System.Void RegisterDisconnection(UnityEngine.Events.UnityAction<System.Int32> callback)
  System.Void UnregisterConnection(UnityEngine.Events.UnityAction<System.Int32> callback)
  System.Void UnregisterDisconnection(UnityEngine.Events.UnityAction<System.Int32> callback)
  System.Void Send(System.Guid messageId, System.Byte[] data)
  System.Boolean TrySend(System.Guid messageId, System.Byte[] data)
  System.Boolean BlockUntilRecvMsg(System.Guid messageId, System.Int32 timeout)
  System.Void DisconnectAll()
  System.Void MessageCallbackInternal(System.IntPtr data, System.UInt64 size, System.UInt64 guid, System.String messageId)
  System.Void ConnectedCallbackInternal(System.Int32 playerId)
  System.Void DisconnectedCallback(System.Int32 playerId)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents
TYPE:  class
TOKEN: 0x20002D7
FIELDS:
  public            System.Collections.Generic.List<UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers>messageTypeSubscribers  // 0x10
  public            UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.ConnectionChangeEventconnectionEvent  // 0x18
  public            UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.ConnectionChangeEventdisconnectionEvent  // 0x20
METHODS:
  System.Void InvokeMessageIdSubscribers(System.Guid messageId, System.Byte[] data, System.Int32 playerId)
  UnityEngine.Events.UnityEvent<UnityEngine.Networking.PlayerConnection.MessageEventArgs> AddAndCreate(System.Guid messageId)
  System.Void UnregisterManagedCallback(System.Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Playables.FrameData
TYPE:  struct
TOKEN: 0x2000367
FIELDS:
  private           System.UInt64                   m_FrameID  // 0x10
  private           System.Double                   m_DeltaTime  // 0x18
  private           System.Single                   m_Weight  // 0x20
  private           System.Single                   m_EffectiveWeight  // 0x24
  private           System.Double                   m_EffectiveParentDelay  // 0x28
  private           System.Single                   m_EffectiveParentSpeed  // 0x30
  private           System.Single                   m_EffectiveSpeed  // 0x34
  private           UnityEngine.Playables.FrameData.Flagsm_Flags  // 0x38
  private           UnityEngine.Playables.PlayableOutputm_Output  // 0x40
METHODS:
  System.Boolean HasFlags(UnityEngine.Playables.FrameData.Flags flag)
  System.Single get_deltaTime()
  System.Single get_weight()
  System.Single get_effectiveWeight()
  System.Single get_effectiveSpeed()
  UnityEngine.Playables.FrameData.EvaluationType get_evaluationType()
  System.Boolean get_seekOccurred()
  System.Boolean get_timeLooped()
  System.Boolean get_timeHeld()
  UnityEngine.Playables.PlayableOutput get_output()
  UnityEngine.Playables.PlayState get_effectivePlayState()
END_CLASS

CLASS: UnityEngine.Playables.FrameRate
TYPE:  struct
TOKEN: 0x200036A
FIELDS:
  public    static readonly UnityEngine.Playables.FrameRate k_24Fps  // 0x0
  public    static readonly UnityEngine.Playables.FrameRate k_23_976Fps  // 0x4
  public    static readonly UnityEngine.Playables.FrameRate k_25Fps  // 0x8
  public    static readonly UnityEngine.Playables.FrameRate k_30Fps  // 0xC
  public    static readonly UnityEngine.Playables.FrameRate k_29_97Fps  // 0x10
  public    static readonly UnityEngine.Playables.FrameRate k_50Fps  // 0x14
  public    static readonly UnityEngine.Playables.FrameRate k_60Fps  // 0x18
  public    static readonly UnityEngine.Playables.FrameRate k_59_94Fps  // 0x1C
  private           System.Int32                    m_Rate  // 0x10
METHODS:
  System.Boolean get_dropFrame()
  System.Double get_rate()
  System.Void .ctor(System.UInt32 frameRate, System.Boolean drop)
  System.Boolean Equals(UnityEngine.Playables.FrameRate other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Playables.INotification
TYPE:  interface
TOKEN: 0x200036B
FIELDS:
METHODS:
  UnityEngine.PropertyName get_id()
END_CLASS

CLASS: UnityEngine.Playables.INotificationReceiver
TYPE:  interface
TOKEN: 0x200036C
FIELDS:
METHODS:
  System.Void OnNotify(UnityEngine.Playables.Playable origin, UnityEngine.Playables.INotification notification, System.Object context)
END_CLASS

CLASS: UnityEngine.Playables.IPlayable
TYPE:  interface
TOKEN: 0x200036D
FIELDS:
METHODS:
  UnityEngine.Playables.PlayableHandle GetHandle()
END_CLASS

CLASS: UnityEngine.Playables.IPlayableBehaviour
TYPE:  interface
TOKEN: 0x200036E
FIELDS:
METHODS:
  System.Void OnGraphStart(UnityEngine.Playables.Playable playable)
  System.Void OnGraphStop(UnityEngine.Playables.Playable playable)
  System.Void OnPlayableCreate(UnityEngine.Playables.Playable playable)
  System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable)
  System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData)
END_CLASS

CLASS: UnityEngine.Playables.IPlayableOutput
TYPE:  interface
TOKEN: 0x200036F
FIELDS:
METHODS:
  UnityEngine.Playables.PlayableOutputHandle GetHandle()
END_CLASS

CLASS: UnityEngine.Playables.DirectorWrapMode
TYPE:  struct
TOKEN: 0x2000370
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Playables.DirectorWrapModeHold  // 0x0
  public    static  UnityEngine.Playables.DirectorWrapModeLoop  // 0x0
  public    static  UnityEngine.Playables.DirectorWrapModeNone  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Playables.Playable
TYPE:  struct
TOKEN: 0x2000371
FIELDS:
  private           UnityEngine.Playables.PlayableHandlem_Handle  // 0x10
  private   static readonly UnityEngine.Playables.Playable  m_NullPlayable  // 0x0
METHODS:
  UnityEngine.Playables.Playable get_Null()
  UnityEngine.Playables.Playable Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount)
  System.Void .ctor(UnityEngine.Playables.PlayableHandle handle)
  UnityEngine.Playables.PlayableHandle GetHandle()
  System.Boolean IsPlayableOfType()
  System.Type GetPlayableType()
  System.Boolean Equals(UnityEngine.Playables.Playable other)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Playables.IPlayableAsset
TYPE:  interface
TOKEN: 0x2000372
FIELDS:
METHODS:
  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner)
  System.Double get_duration()
END_CLASS

CLASS: UnityEngine.Playables.PlayableAsset
TYPE:  class
TOKEN: 0x2000373
EXTENDS: ScriptableObject
FIELDS:
METHODS:
  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner)
  System.Double get_duration()
  System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs()
  System.Void Internal_CreatePlayable(UnityEngine.Playables.PlayableAsset asset, UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.IntPtr ptr)
  System.Void Internal_GetPlayableAssetDuration(UnityEngine.Playables.PlayableAsset asset, System.IntPtr ptrToDouble)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Playables.PlayableBehaviour
TYPE:  class
TOKEN: 0x2000374
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void OnGraphStart(UnityEngine.Playables.Playable playable)
  System.Void OnGraphStop(UnityEngine.Playables.Playable playable)
  System.Void OnPlayableCreate(UnityEngine.Playables.Playable playable)
  System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable)
  System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void PrepareData(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData)
  System.Object Clone()
END_CLASS

CLASS: UnityEngine.Playables.PlayableBinding
TYPE:  struct
TOKEN: 0x2000375
FIELDS:
  private           System.String                   m_StreamName  // 0x10
  private           UnityEngine.Object              m_SourceObject  // 0x18
  private           System.Type                     m_SourceBindingType  // 0x20
  private           UnityEngine.Playables.PlayableBinding.CreateOutputMethodm_CreateOutputMethod  // 0x28
  public    static readonly UnityEngine.Playables.PlayableBinding[]None  // 0x0
  public    static readonly System.Double                   DefaultDuration  // 0x8
METHODS:
  UnityEngine.Object get_sourceObject()
  UnityEngine.Playables.PlayableOutput CreateOutput(UnityEngine.Playables.PlayableGraph graph)
  UnityEngine.Playables.PlayableBinding CreateInternal(System.String name, UnityEngine.Object sourceObject, System.Type sourceType, UnityEngine.Playables.PlayableBinding.CreateOutputMethod createFunction)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Playables.PlayableTraversalMode
TYPE:  struct
TOKEN: 0x2000377
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Playables.PlayableTraversalModeMix  // 0x0
  public    static  UnityEngine.Playables.PlayableTraversalModePassthrough  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Playables.PlayableExtensions
TYPE:  class
TOKEN: 0x2000378
FIELDS:
METHODS:
  System.Boolean IsNull(U playable)
  System.Boolean IsValid(U playable)
  System.Void Destroy(U playable)
  UnityEngine.Playables.PlayableGraph GetGraph(U playable)
  UnityEngine.Playables.PlayState GetPlayState(U playable)
  System.Void Play(U playable)
  System.Void Pause(U playable)
  System.Void SetSpeed(U playable, System.Double value)
  System.Double GetSpeed(U playable)
  System.Void SetDuration(U playable, System.Double value)
  System.Double GetDuration(U playable)
  System.Void SetTime(U playable, System.Double value)
  System.Void SetTimeUncheck(U playable, System.Double value)
  System.Double GetTime(U playable)
  System.Double GetPreviousTime(U playable)
  System.Boolean IsDone(U playable)
  System.Void SetPropagateSetTime(U playable, System.Boolean value)
  System.Boolean CanDestroy(U playable)
  System.Void SetInputCount(U playable, System.Int32 value)
  System.Int32 GetInputCount(U playable)
  UnityEngine.Playables.Playable GetInput(U playable, System.Int32 inputPort)
  System.Void SetInputWeight(U playable, System.Int32 inputIndex, System.Single weight)
  System.Void SetInputWeightUncheck(U playable, System.Int32 inputIndex, System.Single weight)
  System.Void SetInputWeight(U playable, V input, System.Single weight)
  System.Single GetInputWeight(U playable, System.Int32 inputIndex)
  System.Void ConnectInput(U playable, System.Int32 inputIndex, V sourcePlayable, System.Int32 sourceOutputIndex)
  System.Void ConnectInput(U playable, System.Int32 inputIndex, V sourcePlayable, System.Int32 sourceOutputIndex, System.Single weight)
  System.Void DisconnectInput(U playable, System.Int32 inputPort)
  System.Int32 AddInput(U playable, V sourcePlayable, System.Int32 sourceOutputIndex, System.Single weight)
  System.Single GetLeadTime(U playable)
  System.Void SetTraversalMode(U playable, UnityEngine.Playables.PlayableTraversalMode mode)
  UnityEngine.Playables.DirectorWrapMode GetTimeWrapMode(U playable)
  System.Void SetTimeWrapMode(U playable, UnityEngine.Playables.DirectorWrapMode value)
END_CLASS

CLASS: UnityEngine.Playables.DirectorUpdateMode
TYPE:  struct
TOKEN: 0x2000379
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Playables.DirectorUpdateModeDSPClock  // 0x0
  public    static  UnityEngine.Playables.DirectorUpdateModeGameTime  // 0x0
  public    static  UnityEngine.Playables.DirectorUpdateModeUnscaledGameTime  // 0x0
  public    static  UnityEngine.Playables.DirectorUpdateModeManual  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Playables.PlayableGraph
TYPE:  struct
TOKEN: 0x200037A
FIELDS:
  private           System.IntPtr                   m_Handle  // 0x10
  private           System.UInt32                   m_Version  // 0x18
METHODS:
  UnityEngine.Playables.Playable GetRootPlayable(System.Int32 index)
  System.Boolean Connect(U source, System.Int32 sourceOutputPort, V destination, System.Int32 destinationInputPort)
  System.Void Disconnect(U input, System.Int32 inputPort)
  System.Void DestroyPlayable(U playable)
  UnityEngine.Playables.PlayableOutput GetOutput(System.Int32 index)
  System.Void Evaluate()
  UnityEngine.Playables.PlayableGraph Create()
  UnityEngine.Playables.PlayableGraph Create(System.String name)
  System.Void Destroy()
  System.Boolean IsValid()
  System.Boolean IsPlaying()
  System.Void Play()
  System.Void Stop()
  System.Void Evaluate(System.Single deltaTime)
  System.Void SetTimeUpdateMode(UnityEngine.Playables.DirectorUpdateMode value)
  UnityEngine.IExposedPropertyTable GetResolver()
  System.Int32 GetPlayableCount()
  System.Int32 GetRootPlayableCount()
  System.Void SynchronizeEvaluation(UnityEngine.Playables.PlayableGraph playable)
  System.Int32 GetOutputCount()
  System.Void SetEarlyPrepareFrame(System.Boolean enable)
  System.Boolean IsEarlyPrepareFrame()
  UnityEngine.Playables.PlayableHandle CreatePlayableHandle()
  System.Boolean CreateScriptOutputInternal(System.String name, UnityEngine.Playables.PlayableOutputHandle& handle)
  UnityEngine.Playables.PlayableHandle GetRootPlayableInternal(System.Int32 index)
  System.Boolean IsMatchFrameRateEnabled()
  UnityEngine.Playables.FrameRate GetFrameRate()
  System.Boolean GetOutputInternal(System.Int32 index, UnityEngine.Playables.PlayableOutputHandle& handle)
  System.Boolean ConnectInternal(UnityEngine.Playables.PlayableHandle source, System.Int32 sourceOutputPort, UnityEngine.Playables.PlayableHandle destination, System.Int32 destinationInputPort)
  System.Void DisconnectInternal(UnityEngine.Playables.PlayableHandle playable, System.Int32 inputPort)
  System.Void DestroyPlayableInternal(UnityEngine.Playables.PlayableHandle playable)
  System.Void Create_Injected(System.String name, UnityEngine.Playables.PlayableGraph& ret)
  System.Void Destroy_Injected(UnityEngine.Playables.PlayableGraph& _unity_self)
  System.Boolean IsValid_Injected(UnityEngine.Playables.PlayableGraph& _unity_self)
  System.Boolean IsPlaying_Injected(UnityEngine.Playables.PlayableGraph& _unity_self)
  System.Void Play_Injected(UnityEngine.Playables.PlayableGraph& _unity_self)
  System.Void Stop_Injected(UnityEngine.Playables.PlayableGraph& _unity_self)
  System.Void Evaluate_Injected(UnityEngine.Playables.PlayableGraph& _unity_self, System.Single deltaTime)
  System.Void SetTimeUpdateMode_Injected(UnityEngine.Playables.PlayableGraph& _unity_self, UnityEngine.Playables.DirectorUpdateMode value)
  UnityEngine.IExposedPropertyTable GetResolver_Injected(UnityEngine.Playables.PlayableGraph& _unity_self)
  System.Int32 GetPlayableCount_Injected(UnityEngine.Playables.PlayableGraph& _unity_self)
  System.Int32 GetRootPlayableCount_Injected(UnityEngine.Playables.PlayableGraph& _unity_self)
  System.Void SynchronizeEvaluation_Injected(UnityEngine.Playables.PlayableGraph& _unity_self, UnityEngine.Playables.PlayableGraph& playable)
  System.Int32 GetOutputCount_Injected(UnityEngine.Playables.PlayableGraph& _unity_self)
  System.Void SetEarlyPrepareFrame_Injected(UnityEngine.Playables.PlayableGraph& _unity_self, System.Boolean enable)
  System.Boolean IsEarlyPrepareFrame_Injected(UnityEngine.Playables.PlayableGraph& _unity_self)
  System.Void CreatePlayableHandle_Injected(UnityEngine.Playables.PlayableGraph& _unity_self, UnityEngine.Playables.PlayableHandle& ret)
  System.Boolean CreateScriptOutputInternal_Injected(UnityEngine.Playables.PlayableGraph& _unity_self, System.String name, UnityEngine.Playables.PlayableOutputHandle& handle)
  System.Void GetRootPlayableInternal_Injected(UnityEngine.Playables.PlayableGraph& _unity_self, System.Int32 index, UnityEngine.Playables.PlayableHandle& ret)
  System.Boolean IsMatchFrameRateEnabled_Injected(UnityEngine.Playables.PlayableGraph& _unity_self)
  System.Void GetFrameRate_Injected(UnityEngine.Playables.PlayableGraph& _unity_self, UnityEngine.Playables.FrameRate& ret)
  System.Boolean GetOutputInternal_Injected(UnityEngine.Playables.PlayableGraph& _unity_self, System.Int32 index, UnityEngine.Playables.PlayableOutputHandle& handle)
  System.Boolean ConnectInternal_Injected(UnityEngine.Playables.PlayableGraph& _unity_self, UnityEngine.Playables.PlayableHandle& source, System.Int32 sourceOutputPort, UnityEngine.Playables.PlayableHandle& destination, System.Int32 destinationInputPort)
  System.Void DisconnectInternal_Injected(UnityEngine.Playables.PlayableGraph& _unity_self, UnityEngine.Playables.PlayableHandle& playable, System.Int32 inputPort)
  System.Void DestroyPlayableInternal_Injected(UnityEngine.Playables.PlayableGraph& _unity_self, UnityEngine.Playables.PlayableHandle& playable)
END_CLASS

CLASS: UnityEngine.Playables.PlayState
TYPE:  struct
TOKEN: 0x200037B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Playables.PlayState Paused  // 0x0
  public    static  UnityEngine.Playables.PlayState Playing  // 0x0
  public    static  UnityEngine.Playables.PlayState Delayed  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Playables.PlayableHandle
TYPE:  struct
TOKEN: 0x200037C
FIELDS:
  private           System.IntPtr                   m_Handle  // 0x10
  private           System.UInt32                   m_Version  // 0x18
  private   static readonly UnityEngine.Playables.PlayableHandlem_Null  // 0x0
METHODS:
  T GetObject()
  System.Object GetWrapScriptObject()
  System.Boolean IsPlayableOfType()
  UnityEngine.Playables.PlayableHandle get_Null()
  UnityEngine.Playables.Playable GetInput(System.Int32 inputPort)
  System.Boolean SetInputWeight(System.Int32 inputIndex, System.Single weight)
  System.Boolean SetInputWeightUncheck(System.Int32 inputIndex, System.Single weight)
  System.Single GetInputWeight(System.Int32 inputIndex)
  System.Void Destroy()
  System.Boolean op_Equality(UnityEngine.Playables.PlayableHandle x, UnityEngine.Playables.PlayableHandle y)
  System.Boolean Equals(System.Object p)
  System.Boolean Equals(UnityEngine.Playables.PlayableHandle other)
  System.Int32 GetHashCode()
  System.Boolean CompareVersion(UnityEngine.Playables.PlayableHandle lhs, UnityEngine.Playables.PlayableHandle rhs)
  System.Boolean CheckInputBounds(System.Int32 inputIndex)
  System.Boolean CheckInputBounds(System.Int32 inputIndex, System.Boolean acceptAny)
  System.Boolean CheckInputBoundsUncheck(System.Int32 inputIndex)
  System.Boolean IsNull()
  System.Boolean IsValid()
  System.Type GetPlayableType()
  System.Type GetJobType()
  System.Void SetScriptInstance(System.Object scriptInstance)
  System.Boolean CanDestroy()
  UnityEngine.Playables.PlayState GetPlayState()
  System.Void Play()
  System.Void Pause()
  System.Double GetSpeed()
  System.Void SetSpeed(System.Double value)
  System.Double GetTime()
  System.Void SetTime(System.Double value)
  System.Boolean IsDone()
  System.Void SetDone(System.Boolean value)
  System.Double GetDuration()
  System.Void SetDuration(System.Double value)
  System.Void SetPropagateSetTime(System.Boolean value)
  UnityEngine.Playables.PlayableGraph GetGraph()
  System.Int32 GetInputCount()
  System.Void SetInputCount(System.Int32 value)
  System.Void SetInputWeight(UnityEngine.Playables.PlayableHandle input, System.Single weight)
  System.Double GetPreviousTime()
  System.Single GetLeadTime()
  System.Void SetTraversalMode(UnityEngine.Playables.PlayableTraversalMode mode)
  System.IntPtr GetJobData()
  UnityEngine.Playables.DirectorWrapMode GetTimeWrapMode()
  System.Void SetTimeWrapMode(UnityEngine.Playables.DirectorWrapMode mode)
  System.Object GetScriptInstance()
  UnityEngine.Playables.PlayableHandle GetInputHandle(System.Int32 index)
  System.Void SetInputWeightFromIndex(System.Int32 index, System.Single weight)
  System.Single GetInputWeightFromIndex(System.Int32 index)
  System.Void SetInputWeightFromIndexUncheck(System.Int32 index, System.Single weight)
  System.Int32 GetInputCountUncheck()
  System.Void SetTimeUncheck(System.Double value)
  System.Void .cctor()
  System.Boolean IsNull_Injected(UnityEngine.Playables.PlayableHandle& _unity_self)
  System.Boolean IsValid_Injected(UnityEngine.Playables.PlayableHandle& _unity_self)
  System.Type GetPlayableType_Injected(UnityEngine.Playables.PlayableHandle& _unity_self)
  System.Type GetJobType_Injected(UnityEngine.Playables.PlayableHandle& _unity_self)
  System.Void SetScriptInstance_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, System.Object scriptInstance)
  System.Boolean CanDestroy_Injected(UnityEngine.Playables.PlayableHandle& _unity_self)
  UnityEngine.Playables.PlayState GetPlayState_Injected(UnityEngine.Playables.PlayableHandle& _unity_self)
  System.Void Play_Injected(UnityEngine.Playables.PlayableHandle& _unity_self)
  System.Void Pause_Injected(UnityEngine.Playables.PlayableHandle& _unity_self)
  System.Double GetSpeed_Injected(UnityEngine.Playables.PlayableHandle& _unity_self)
  System.Void SetSpeed_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, System.Double value)
  System.Double GetTime_Injected(UnityEngine.Playables.PlayableHandle& _unity_self)
  System.Void SetTime_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, System.Double value)
  System.Boolean IsDone_Injected(UnityEngine.Playables.PlayableHandle& _unity_self)
  System.Void SetDone_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, System.Boolean value)
  System.Double GetDuration_Injected(UnityEngine.Playables.PlayableHandle& _unity_self)
  System.Void SetDuration_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, System.Double value)
  System.Void SetPropagateSetTime_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, System.Boolean value)
  System.Void GetGraph_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, UnityEngine.Playables.PlayableGraph& ret)
  System.Int32 GetInputCount_Injected(UnityEngine.Playables.PlayableHandle& _unity_self)
  System.Void SetInputCount_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, System.Int32 value)
  System.Void SetInputWeight_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, UnityEngine.Playables.PlayableHandle& input, System.Single weight)
  System.Double GetPreviousTime_Injected(UnityEngine.Playables.PlayableHandle& _unity_self)
  System.Single GetLeadTime_Injected(UnityEngine.Playables.PlayableHandle& _unity_self)
  System.Void SetTraversalMode_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, UnityEngine.Playables.PlayableTraversalMode mode)
  System.IntPtr GetJobData_Injected(UnityEngine.Playables.PlayableHandle& _unity_self)
  UnityEngine.Playables.DirectorWrapMode GetTimeWrapMode_Injected(UnityEngine.Playables.PlayableHandle& _unity_self)
  System.Void SetTimeWrapMode_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, UnityEngine.Playables.DirectorWrapMode mode)
  System.Object GetScriptInstance_Injected(UnityEngine.Playables.PlayableHandle& _unity_self)
  System.Void GetInputHandle_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, System.Int32 index, UnityEngine.Playables.PlayableHandle& ret)
  System.Void SetInputWeightFromIndex_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, System.Int32 index, System.Single weight)
  System.Single GetInputWeightFromIndex_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, System.Int32 index)
  System.Void SetInputWeightFromIndexUncheck_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, System.Int32 index, System.Single weight)
  System.Int32 GetInputCountUncheck_Injected(UnityEngine.Playables.PlayableHandle& _unity_self)
  System.Void SetTimeUncheck_Injected(UnityEngine.Playables.PlayableHandle& _unity_self, System.Double value)
END_CLASS

CLASS: UnityEngine.Playables.PlayableOutput
TYPE:  struct
TOKEN: 0x200037D
FIELDS:
  private           UnityEngine.Playables.PlayableOutputHandlem_Handle  // 0x10
  private   static readonly UnityEngine.Playables.PlayableOutputm_NullPlayableOutput  // 0x0
METHODS:
  UnityEngine.Playables.PlayableOutput get_Null()
  System.Void .ctor(UnityEngine.Playables.PlayableOutputHandle handle)
  UnityEngine.Playables.PlayableOutputHandle GetHandle()
  System.Boolean IsPlayableOutputOfType()
  System.Boolean Equals(UnityEngine.Playables.PlayableOutput other)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Playables.PlayableOutputExtensions
TYPE:  class
TOKEN: 0x200037E
FIELDS:
METHODS:
  System.Boolean IsOutputValid(U output)
  System.Void SetReferenceObject(U output, UnityEngine.Object value)
  UnityEngine.Object GetUserData(U output)
  UnityEngine.Playables.Playable GetSourcePlayable(U output)
  System.Void SetSourcePlayable(U output, V value)
  System.Void SetSourcePlayable(U output, V value, System.Int32 port)
  System.Int32 GetSourceOutputPort(U output)
  System.Void SetWeight(U output, System.Single value)
  System.Void PushNotification(U output, UnityEngine.Playables.Playable origin, UnityEngine.Playables.INotification notification, System.Object context)
  System.Void AddNotificationReceiver(U output, UnityEngine.Playables.INotificationReceiver receiver)
END_CLASS

CLASS: UnityEngine.Playables.PlayableOutputHandle
TYPE:  struct
TOKEN: 0x200037F
FIELDS:
  private           System.IntPtr                   m_Handle  // 0x10
  private           System.UInt32                   m_Version  // 0x18
  private   static readonly UnityEngine.Playables.PlayableOutputHandlem_Null  // 0x0
METHODS:
  UnityEngine.Playables.PlayableOutputHandle get_Null()
  System.Boolean IsPlayableOutputOfType()
  System.Int32 GetHashCode()
  System.Boolean op_Equality(UnityEngine.Playables.PlayableOutputHandle lhs, UnityEngine.Playables.PlayableOutputHandle rhs)
  System.Boolean Equals(System.Object p)
  System.Boolean Equals(UnityEngine.Playables.PlayableOutputHandle other)
  System.Boolean CompareVersion(UnityEngine.Playables.PlayableOutputHandle lhs, UnityEngine.Playables.PlayableOutputHandle rhs)
  System.Boolean IsValid()
  System.Type GetPlayableOutputType()
  System.Void SetReferenceObject(UnityEngine.Object target)
  UnityEngine.Object GetUserData()
  UnityEngine.Playables.PlayableHandle GetSourcePlayable()
  System.Void SetSourcePlayable(UnityEngine.Playables.PlayableHandle target, System.Int32 port)
  System.Int32 GetSourceOutputPort()
  System.Void SetWeight(System.Single weight)
  System.Void PushNotification(UnityEngine.Playables.PlayableHandle origin, UnityEngine.Playables.INotification notification, System.Object context)
  System.Void AddNotificationReceiver(UnityEngine.Playables.INotificationReceiver receiver)
  System.Void .cctor()
  System.Boolean IsValid_Injected(UnityEngine.Playables.PlayableOutputHandle& _unity_self)
  System.Type GetPlayableOutputType_Injected(UnityEngine.Playables.PlayableOutputHandle& _unity_self)
  System.Void SetReferenceObject_Injected(UnityEngine.Playables.PlayableOutputHandle& _unity_self, UnityEngine.Object target)
  UnityEngine.Object GetUserData_Injected(UnityEngine.Playables.PlayableOutputHandle& _unity_self)
  System.Void GetSourcePlayable_Injected(UnityEngine.Playables.PlayableOutputHandle& _unity_self, UnityEngine.Playables.PlayableHandle& ret)
  System.Void SetSourcePlayable_Injected(UnityEngine.Playables.PlayableOutputHandle& _unity_self, UnityEngine.Playables.PlayableHandle& target, System.Int32 port)
  System.Int32 GetSourceOutputPort_Injected(UnityEngine.Playables.PlayableOutputHandle& _unity_self)
  System.Void SetWeight_Injected(UnityEngine.Playables.PlayableOutputHandle& _unity_self, System.Single weight)
  System.Void PushNotification_Injected(UnityEngine.Playables.PlayableOutputHandle& _unity_self, UnityEngine.Playables.PlayableHandle& origin, UnityEngine.Playables.INotification notification, System.Object context)
  System.Void AddNotificationReceiver_Injected(UnityEngine.Playables.PlayableOutputHandle& _unity_self, UnityEngine.Playables.INotificationReceiver receiver)
END_CLASS

CLASS: UnityEngine.Playables.ScriptPlayable`1
TYPE:  struct
TOKEN: 0x2000380
FIELDS:
  private           UnityEngine.Playables.PlayableHandlem_Handle  // 0x0
  private   static readonly UnityEngine.Playables.ScriptPlayable<T>m_NullPlayable  // 0x0
METHODS:
  UnityEngine.Playables.ScriptPlayable<T> get_Null()
  UnityEngine.Playables.ScriptPlayable<T> Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount)
  UnityEngine.Playables.ScriptPlayable<T> Create(UnityEngine.Playables.PlayableGraph graph, T template, System.Int32 inputCount)
  UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, T template, System.Int32 inputCount)
  System.Object CreateScriptInstance()
  System.Object CloneScriptInstance(UnityEngine.Playables.IPlayableBehaviour source)
  System.Object CloneScriptInstanceFromEngineObject(UnityEngine.Object source)
  System.Object CloneScriptInstanceFromIClonable(System.ICloneable source)
  System.Void .ctor(UnityEngine.Playables.PlayableHandle handle)
  UnityEngine.Playables.PlayableHandle GetHandle()
  T GetBehaviour()
  UnityEngine.Playables.Playable op_Implicit(UnityEngine.Playables.ScriptPlayable<T> playable)
  UnityEngine.Playables.ScriptPlayable<T> op_Explicit(UnityEngine.Playables.Playable playable)
  System.Boolean Equals(UnityEngine.Playables.ScriptPlayable<T> other)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Playables.ScriptPlayableBinding
TYPE:  class
TOKEN: 0x2000381
FIELDS:
METHODS:
  UnityEngine.Playables.PlayableBinding Create(System.String name, UnityEngine.Object key, System.Type type)
  UnityEngine.Playables.PlayableOutput CreateScriptOutput(UnityEngine.Playables.PlayableGraph graph, System.String name)
END_CLASS

CLASS: UnityEngine.Playables.ScriptPlayableOutput
TYPE:  struct
TOKEN: 0x2000382
FIELDS:
  private           UnityEngine.Playables.PlayableOutputHandlem_Handle  // 0x10
METHODS:
  UnityEngine.Playables.ScriptPlayableOutput Create(UnityEngine.Playables.PlayableGraph graph, System.String name)
  System.Void .ctor(UnityEngine.Playables.PlayableOutputHandle handle)
  UnityEngine.Playables.ScriptPlayableOutput get_Null()
  UnityEngine.Playables.PlayableOutputHandle GetHandle()
  UnityEngine.Playables.PlayableOutput op_Implicit(UnityEngine.Playables.ScriptPlayableOutput output)
END_CLASS

CLASS: UnityEngine.PlayerLoop.TimeUpdate
TYPE:  struct
TOKEN: 0x2000238
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.PlayerLoop.Initialization
TYPE:  struct
TOKEN: 0x200023A
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.PlayerLoop.EarlyUpdate
TYPE:  struct
TOKEN: 0x2000242
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.PlayerLoop.FixedUpdate
TYPE:  struct
TOKEN: 0x2000264
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.PlayerLoop.PreUpdate
TYPE:  struct
TOKEN: 0x2000272
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.PlayerLoop.Update
TYPE:  struct
TOKEN: 0x200027E
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.PlayerLoop.PreLateUpdate
TYPE:  struct
TOKEN: 0x2000284
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.PlayerLoop.PostLateUpdate
TYPE:  struct
TOKEN: 0x2000295
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Pool.CollectionPool`2
TYPE:  class
TOKEN: 0x20002CC
FIELDS:
  private   static readonly UnityEngine.Pool.ObjectPool<TCollection>s_Pool  // 0x0
METHODS:
  TCollection Get()
  UnityEngine.Pool.PooledObject<TCollection> Get(TCollection& value)
  System.Void Release(TCollection toRelease)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Pool.IObjectPool`1
TYPE:  interface
TOKEN: 0x20002CE
FIELDS:
METHODS:
  System.Void Release(T element)
END_CLASS

CLASS: UnityEngine.Pool.ObjectPool`1
TYPE:  class
TOKEN: 0x20002CF
FIELDS:
  private   readonly System.Collections.Generic.List<T>m_List  // 0x0
  private   readonly System.Func<T>                  m_CreateFunc  // 0x0
  private   readonly System.Action<T>                m_ActionOnGet  // 0x0
  private   readonly System.Action<T>                m_ActionOnRelease  // 0x0
  private   readonly System.Action<T>                m_ActionOnDestroy  // 0x0
  private   readonly System.Int32                    m_MaxSize  // 0x0
  private           System.Boolean                  m_CollectionCheck  // 0x0
  private           System.Int32                    <CountAll>k__BackingField  // 0x0
METHODS:
  System.Int32 get_CountAll()
  System.Void set_CountAll(System.Int32 value)
  System.Int32 get_CountInactive()
  System.Void .ctor(System.Func<T> createFunc, System.Action<T> actionOnGet, System.Action<T> actionOnRelease, System.Action<T> actionOnDestroy, System.Boolean collectionCheck, System.Int32 defaultCapacity, System.Int32 maxSize)
  T Get()
  UnityEngine.Pool.PooledObject<T> Get(T& v)
  System.Void Release(T element)
  System.Void Clear()
  System.Void Dispose()
END_CLASS

CLASS: UnityEngine.Pool.PooledObject`1
TYPE:  struct
TOKEN: 0x20002D0
FIELDS:
  private   readonly T                               m_ToReturn  // 0x0
  private   readonly UnityEngine.Pool.IObjectPool<T> m_Pool  // 0x0
METHODS:
  System.Void .ctor(T value, UnityEngine.Pool.IObjectPool<T> pool)
  System.Void System.IDisposable.Dispose()
END_CLASS

CLASS: UnityEngine.Profiling.ProfilingHGPass
TYPE:  struct
TOKEN: 0x20001D4
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Profiling.ProfilingHGPassNone  // 0x0
  public    static  UnityEngine.Profiling.ProfilingHGPassPreDepth  // 0x0
  public    static  UnityEngine.Profiling.ProfilingHGPassGBuffer  // 0x0
  public    static  UnityEngine.Profiling.ProfilingHGPassShadow  // 0x0
  public    static  UnityEngine.Profiling.ProfilingHGPassForwardOpaque  // 0x0
  public    static  UnityEngine.Profiling.ProfilingHGPassForwardTransparent  // 0x0
  public    static  UnityEngine.Profiling.ProfilingHGPassDistortion  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Profiling.Profiler
TYPE:  class
TOKEN: 0x20001D5
FIELDS:
METHODS:
  System.Boolean get_supported()
  System.Boolean get_enabled()
  System.Void set_enabled(System.Boolean value)
  System.Void BeginSample(System.String name)
  System.Void ValidateArguments(System.String name)
  System.Void BeginSampleImpl(System.String name, UnityEngine.Object targetObject)
  System.Void EndSample()
  System.Int64 GetRuntimeMemorySizeLong(UnityEngine.Object o)
  System.Int64 GetMonoHeapSizeLong()
  System.Int64 GetMonoUsedSizeLong()
  System.Int64 GetTotalAllocatedMemoryLong()
  System.Int64 GetTotalReservedMemoryLong()
  System.Void ReleaseMonoSnapShot(System.String filePath, System.Boolean bCompress)
END_CLASS

CLASS: UnityEngine.Profiling.HGSingleFrameProfiler
TYPE:  class
TOKEN: 0x20001D6
FIELDS:
  public    static  UnityEngine.Profiling.HGSingleFrameProfiler.FinishFrameCallbackfinishFrameCallback  // 0x0
METHODS:
  System.Void CallFinishFrameCallback(System.Double frameTimeMS, System.Boolean overflow, System.IntPtr frameDataPtr, System.Int32 size)
END_CLASS

CLASS: UnityEngine.Profiling.Recorder
TYPE:  class
TOKEN: 0x20001D8
FIELDS:
  private   static  Unity.Profiling.ProfilerRecorderOptionss_RecorderDefaultOptions  // 0x0
  private   static  UnityEngine.Profiling.Recorder  s_InvalidRecorder  // 0x0
  private           Unity.Profiling.ProfilerRecorderm_RecorderCPU  // 0x10
  private           Unity.Profiling.ProfilerRecorderm_RecorderGPU  // 0x18
METHODS:
  System.Void .ctor()
  System.Void .ctor(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle handle)
  System.Void Finalize()
  System.Boolean get_enabled()
  System.Void set_enabled(System.Boolean value)
  System.Int64 get_elapsedNanoseconds()
  System.Int64 get_gpuElapsedNanoseconds()
  System.Int32 get_sampleBlockCount()
  System.Int32 get_gpuSampleBlockCount()
  System.Void SetEnabled(System.Boolean state)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Profiling.Sampler
TYPE:  class
TOKEN: 0x20001D9
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
  private   static  UnityEngine.Profiling.Sampler   s_InvalidSampler  // 0x0
METHODS:
  System.Void .ctor()
  System.Boolean get_isValid()
  UnityEngine.Profiling.Recorder GetRecorder()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Profiling.CustomSampler
TYPE:  class
TOKEN: 0x20001DA
EXTENDS: Sampler
FIELDS:
  private   static  UnityEngine.Profiling.CustomSamplers_InvalidCustomSampler  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.IntPtr ptr)
  UnityEngine.Profiling.CustomSampler Create(System.String name, System.Boolean collectGpuData)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Profiling.Experimental.DebugScreenCapture
TYPE:  struct
TOKEN: 0x20001DB
FIELDS:
  private           Unity.Collections.NativeArray<System.Byte><rawImageDataReference>k__BackingField  // 0x10
  private           UnityEngine.TextureFormat       <imageFormat>k__BackingField  // 0x20
  private           System.Int32                    <width>k__BackingField  // 0x24
  private           System.Int32                    <height>k__BackingField  // 0x28
METHODS:
  System.Void set_rawImageDataReference(Unity.Collections.NativeArray<System.Byte> value)
  System.Void set_imageFormat(UnityEngine.TextureFormat value)
  System.Void set_width(System.Int32 value)
  System.Void set_height(System.Int32 value)
END_CLASS

CLASS: UnityEngine.Profiling.Memory.Experimental.MetaData
TYPE:  class
TOKEN: 0x20001DC
FIELDS:
  public            System.String                   content  // 0x10
  public            System.String                   platform  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Profiling.Memory.Experimental.MemoryProfiler
TYPE:  class
TOKEN: 0x20001DD
FIELDS:
  private   static  System.Action<System.String,System.Boolean>m_SnapshotFinished  // 0x0
  private   static  System.Action<System.String,System.Boolean,UnityEngine.Profiling.Experimental.DebugScreenCapture>m_SaveScreenshotToDisk  // 0x8
  private   static  System.Action<UnityEngine.Profiling.Memory.Experimental.MetaData>createMetaData  // 0x10
METHODS:
  System.Byte[] PrepareMetadata()
  System.Int32 WriteIntToByteArray(System.Byte[] array, System.Int32 offset, System.Int32 value)
  System.Int32 WriteStringToByteArray(System.Byte[] array, System.Int32 offset, System.String value)
  System.Void FinalizeSnapshot(System.String path, System.Boolean result)
  System.Void SaveScreenshotToDisk(System.String path, System.Boolean result, System.IntPtr pixelsPtr, System.Int32 pixelsCount, UnityEngine.TextureFormat format, System.Int32 width, System.Int32 height)
END_CLASS

CLASS: UnityEngine.Rendering.AsyncGPUReadbackRequest
TYPE:  struct
TOKEN: 0x20002E8
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
  private           System.Int32                    m_Version  // 0x18
METHODS:
  System.Void WaitForCompletion()
  Unity.Collections.NativeArray<T> GetData(System.Int32 layer)
  System.Boolean get_done()
  System.Boolean get_hasError()
  System.Int32 get_layerCount()
  System.Int32 get_layerDataSize()
  System.Boolean IsDone()
  System.Boolean HasError()
  System.Int32 GetLayerCount()
  System.Int32 GetLayerDataSize()
  System.Void SetScriptingCallback(System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback)
  System.IntPtr GetDataRaw(System.Int32 layer)
  System.Void WaitForCompletion_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest& _unity_self)
  System.Boolean IsDone_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest& _unity_self)
  System.Boolean HasError_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest& _unity_self)
  System.Int32 GetLayerCount_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest& _unity_self)
  System.Int32 GetLayerDataSize_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest& _unity_self)
  System.Void SetScriptingCallback_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest& _unity_self, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback)
  System.IntPtr GetDataRaw_Injected(UnityEngine.Rendering.AsyncGPUReadbackRequest& _unity_self, System.Int32 layer)
END_CLASS

CLASS: UnityEngine.Rendering.AsyncRequestNativeArrayData
TYPE:  struct
TOKEN: 0x20002E9
FIELDS:
  public            System.Void*                    nativeArrayBuffer  // 0x10
  public            System.Int64                    lengthInBytes  // 0x18
METHODS:
  UnityEngine.Rendering.AsyncRequestNativeArrayData CreateAndCheckAccess(Unity.Collections.NativeArray<T> array)
END_CLASS

CLASS: UnityEngine.Rendering.AsyncGPUReadback
TYPE:  class
TOKEN: 0x20002EA
FIELDS:
METHODS:
  System.Void ValidateFormat(UnityEngine.Texture src, UnityEngine.Experimental.Rendering.GraphicsFormat dstformat)
  UnityEngine.Rendering.AsyncGPUReadbackRequest Request(UnityEngine.ComputeBuffer src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback)
  UnityEngine.Rendering.AsyncGPUReadbackRequest Request(UnityEngine.Texture src, System.Int32 mipIndex, UnityEngine.TextureFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback)
  UnityEngine.Rendering.AsyncGPUReadbackRequest Request(UnityEngine.Texture src, System.Int32 mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback)
  UnityEngine.Rendering.AsyncGPUReadbackRequest RequestIntoNativeArray(Unity.Collections.NativeArray<T>& output, UnityEngine.ComputeBuffer src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback)
  UnityEngine.Rendering.AsyncGPUReadbackRequest Request_Internal_ComputeBuffer_1(UnityEngine.ComputeBuffer buffer, UnityEngine.Rendering.AsyncRequestNativeArrayData* data)
  UnityEngine.Rendering.AsyncGPUReadbackRequest Request_Internal_Texture_2(UnityEngine.Texture src, System.Int32 mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, UnityEngine.Rendering.AsyncRequestNativeArrayData* data)
  System.Void Request_Internal_ComputeBuffer_1_Injected(UnityEngine.ComputeBuffer buffer, UnityEngine.Rendering.AsyncRequestNativeArrayData* data, UnityEngine.Rendering.AsyncGPUReadbackRequest& ret)
  System.Void Request_Internal_Texture_2_Injected(UnityEngine.Texture src, System.Int32 mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, UnityEngine.Rendering.AsyncRequestNativeArrayData* data, UnityEngine.Rendering.AsyncGPUReadbackRequest& ret)
END_CLASS

CLASS: UnityEngine.Rendering.SynchronisationStage
TYPE:  struct
TOKEN: 0x20002EB
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.SynchronisationStageVertexProcessing  // 0x0
  public    static  UnityEngine.Rendering.SynchronisationStagePixelProcessing  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.IndexFormat
TYPE:  struct
TOKEN: 0x20002EC
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.IndexFormatUInt16  // 0x0
  public    static  UnityEngine.Rendering.IndexFormatUInt32  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.MeshUpdateFlags
TYPE:  struct
TOKEN: 0x20002ED
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.MeshUpdateFlagsDefault  // 0x0
  public    static  UnityEngine.Rendering.MeshUpdateFlagsDontValidateIndices  // 0x0
  public    static  UnityEngine.Rendering.MeshUpdateFlagsDontResetBoneBounds  // 0x0
  public    static  UnityEngine.Rendering.MeshUpdateFlagsDontNotifyMeshUsers  // 0x0
  public    static  UnityEngine.Rendering.MeshUpdateFlagsDontRecalculateBounds  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.VertexAttributeFormat
TYPE:  struct
TOKEN: 0x20002EE
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.VertexAttributeFormatFloat32  // 0x0
  public    static  UnityEngine.Rendering.VertexAttributeFormatFloat16  // 0x0
  public    static  UnityEngine.Rendering.VertexAttributeFormatUNorm8  // 0x0
  public    static  UnityEngine.Rendering.VertexAttributeFormatSNorm8  // 0x0
  public    static  UnityEngine.Rendering.VertexAttributeFormatUNorm16  // 0x0
  public    static  UnityEngine.Rendering.VertexAttributeFormatSNorm16  // 0x0
  public    static  UnityEngine.Rendering.VertexAttributeFormatUInt8  // 0x0
  public    static  UnityEngine.Rendering.VertexAttributeFormatSInt8  // 0x0
  public    static  UnityEngine.Rendering.VertexAttributeFormatUInt16  // 0x0
  public    static  UnityEngine.Rendering.VertexAttributeFormatSInt16  // 0x0
  public    static  UnityEngine.Rendering.VertexAttributeFormatUInt32  // 0x0
  public    static  UnityEngine.Rendering.VertexAttributeFormatSInt32  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.VertexAttribute
TYPE:  struct
TOKEN: 0x20002EF
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.VertexAttributePosition  // 0x0
  public    static  UnityEngine.Rendering.VertexAttributeNormal  // 0x0
  public    static  UnityEngine.Rendering.VertexAttributeTangent  // 0x0
  public    static  UnityEngine.Rendering.VertexAttributeColor  // 0x0
  public    static  UnityEngine.Rendering.VertexAttributeTexCoord0  // 0x0
  public    static  UnityEngine.Rendering.VertexAttributeTexCoord1  // 0x0
  public    static  UnityEngine.Rendering.VertexAttributeTexCoord2  // 0x0
  public    static  UnityEngine.Rendering.VertexAttributeTexCoord3  // 0x0
  public    static  UnityEngine.Rendering.VertexAttributeTexCoord4  // 0x0
  public    static  UnityEngine.Rendering.VertexAttributeTexCoord5  // 0x0
  public    static  UnityEngine.Rendering.VertexAttributeTexCoord6  // 0x0
  public    static  UnityEngine.Rendering.VertexAttributeTexCoord7  // 0x0
  public    static  UnityEngine.Rendering.VertexAttributeBlendWeight  // 0x0
  public    static  UnityEngine.Rendering.VertexAttributeBlendIndices  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.OpaqueSortMode
TYPE:  struct
TOKEN: 0x20002F0
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.OpaqueSortModeDefault  // 0x0
  public    static  UnityEngine.Rendering.OpaqueSortModeFrontToBack  // 0x0
  public    static  UnityEngine.Rendering.OpaqueSortModeNoDistanceSort  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.RenderBufferLoadAction
TYPE:  struct
TOKEN: 0x20002F1
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.RenderBufferLoadActionLoad  // 0x0
  public    static  UnityEngine.Rendering.RenderBufferLoadActionClear  // 0x0
  public    static  UnityEngine.Rendering.RenderBufferLoadActionDontCare  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.RenderBufferStoreAction
TYPE:  struct
TOKEN: 0x20002F2
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.RenderBufferStoreActionStore  // 0x0
  public    static  UnityEngine.Rendering.RenderBufferStoreActionResolve  // 0x0
  public    static  UnityEngine.Rendering.RenderBufferStoreActionStoreAndResolve  // 0x0
  public    static  UnityEngine.Rendering.RenderBufferStoreActionDontCare  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.FastMemoryFlags
TYPE:  struct
TOKEN: 0x20002F3
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.FastMemoryFlagsNone  // 0x0
  public    static  UnityEngine.Rendering.FastMemoryFlagsSpillTop  // 0x0
  public    static  UnityEngine.Rendering.FastMemoryFlagsSpillBottom  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.BlendMode
TYPE:  struct
TOKEN: 0x20002F4
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.BlendMode Zero  // 0x0
  public    static  UnityEngine.Rendering.BlendMode One  // 0x0
  public    static  UnityEngine.Rendering.BlendMode DstColor  // 0x0
  public    static  UnityEngine.Rendering.BlendMode SrcColor  // 0x0
  public    static  UnityEngine.Rendering.BlendMode OneMinusDstColor  // 0x0
  public    static  UnityEngine.Rendering.BlendMode SrcAlpha  // 0x0
  public    static  UnityEngine.Rendering.BlendMode OneMinusSrcColor  // 0x0
  public    static  UnityEngine.Rendering.BlendMode DstAlpha  // 0x0
  public    static  UnityEngine.Rendering.BlendMode OneMinusDstAlpha  // 0x0
  public    static  UnityEngine.Rendering.BlendMode SrcAlphaSaturate  // 0x0
  public    static  UnityEngine.Rendering.BlendMode OneMinusSrcAlpha  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.CompareFunction
TYPE:  struct
TOKEN: 0x20002F5
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.CompareFunctionDisabled  // 0x0
  public    static  UnityEngine.Rendering.CompareFunctionNever  // 0x0
  public    static  UnityEngine.Rendering.CompareFunctionLess  // 0x0
  public    static  UnityEngine.Rendering.CompareFunctionEqual  // 0x0
  public    static  UnityEngine.Rendering.CompareFunctionLessEqual  // 0x0
  public    static  UnityEngine.Rendering.CompareFunctionGreater  // 0x0
  public    static  UnityEngine.Rendering.CompareFunctionNotEqual  // 0x0
  public    static  UnityEngine.Rendering.CompareFunctionGreaterEqual  // 0x0
  public    static  UnityEngine.Rendering.CompareFunctionAlways  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.CullMode
TYPE:  struct
TOKEN: 0x20002F6
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.CullMode  Off  // 0x0
  public    static  UnityEngine.Rendering.CullMode  Front  // 0x0
  public    static  UnityEngine.Rendering.CullMode  Back  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.ColorWriteMask
TYPE:  struct
TOKEN: 0x20002F7
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.ColorWriteMaskAlpha  // 0x0
  public    static  UnityEngine.Rendering.ColorWriteMaskBlue  // 0x0
  public    static  UnityEngine.Rendering.ColorWriteMaskGreen  // 0x0
  public    static  UnityEngine.Rendering.ColorWriteMaskRed  // 0x0
  public    static  UnityEngine.Rendering.ColorWriteMaskAll  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.StencilOp
TYPE:  struct
TOKEN: 0x20002F8
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.StencilOp Keep  // 0x0
  public    static  UnityEngine.Rendering.StencilOp Zero  // 0x0
  public    static  UnityEngine.Rendering.StencilOp Replace  // 0x0
  public    static  UnityEngine.Rendering.StencilOp IncrementSaturate  // 0x0
  public    static  UnityEngine.Rendering.StencilOp DecrementSaturate  // 0x0
  public    static  UnityEngine.Rendering.StencilOp Invert  // 0x0
  public    static  UnityEngine.Rendering.StencilOp IncrementWrap  // 0x0
  public    static  UnityEngine.Rendering.StencilOp DecrementWrap  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.AmbientMode
TYPE:  struct
TOKEN: 0x20002F9
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.AmbientModeSkybox  // 0x0
  public    static  UnityEngine.Rendering.AmbientModeTrilight  // 0x0
  public    static  UnityEngine.Rendering.AmbientModeFlat  // 0x0
  public    static  UnityEngine.Rendering.AmbientModeCustom  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.DefaultReflectionMode
TYPE:  struct
TOKEN: 0x20002FA
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.DefaultReflectionModeSkybox  // 0x0
  public    static  UnityEngine.Rendering.DefaultReflectionModeCustom  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.CameraEvent
TYPE:  struct
TOKEN: 0x20002FB
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.CameraEventBeforeDepthTexture  // 0x0
  public    static  UnityEngine.Rendering.CameraEventAfterDepthTexture  // 0x0
  public    static  UnityEngine.Rendering.CameraEventBeforeDepthNormalsTexture  // 0x0
  public    static  UnityEngine.Rendering.CameraEventAfterDepthNormalsTexture  // 0x0
  public    static  UnityEngine.Rendering.CameraEventBeforeGBuffer  // 0x0
  public    static  UnityEngine.Rendering.CameraEventAfterGBuffer  // 0x0
  public    static  UnityEngine.Rendering.CameraEventBeforeLighting  // 0x0
  public    static  UnityEngine.Rendering.CameraEventAfterLighting  // 0x0
  public    static  UnityEngine.Rendering.CameraEventBeforeFinalPass  // 0x0
  public    static  UnityEngine.Rendering.CameraEventAfterFinalPass  // 0x0
  public    static  UnityEngine.Rendering.CameraEventBeforeForwardOpaque  // 0x0
  public    static  UnityEngine.Rendering.CameraEventAfterForwardOpaque  // 0x0
  public    static  UnityEngine.Rendering.CameraEventBeforeImageEffectsOpaque  // 0x0
  public    static  UnityEngine.Rendering.CameraEventAfterImageEffectsOpaque  // 0x0
  public    static  UnityEngine.Rendering.CameraEventBeforeSkybox  // 0x0
  public    static  UnityEngine.Rendering.CameraEventAfterSkybox  // 0x0
  public    static  UnityEngine.Rendering.CameraEventBeforeForwardAlpha  // 0x0
  public    static  UnityEngine.Rendering.CameraEventAfterForwardAlpha  // 0x0
  public    static  UnityEngine.Rendering.CameraEventBeforeImageEffects  // 0x0
  public    static  UnityEngine.Rendering.CameraEventAfterImageEffects  // 0x0
  public    static  UnityEngine.Rendering.CameraEventAfterEverything  // 0x0
  public    static  UnityEngine.Rendering.CameraEventBeforeReflections  // 0x0
  public    static  UnityEngine.Rendering.CameraEventAfterReflections  // 0x0
  public    static  UnityEngine.Rendering.CameraEventBeforeHaloAndLensFlares  // 0x0
  public    static  UnityEngine.Rendering.CameraEventAfterHaloAndLensFlares  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.CameraEventUtils
TYPE:  class
TOKEN: 0x20002FC
FIELDS:
METHODS:
  System.Boolean IsValid(UnityEngine.Rendering.CameraEvent value)
END_CLASS

CLASS: UnityEngine.Rendering.LightEvent
TYPE:  struct
TOKEN: 0x20002FD
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.LightEventBeforeShadowMap  // 0x0
  public    static  UnityEngine.Rendering.LightEventAfterShadowMap  // 0x0
  public    static  UnityEngine.Rendering.LightEventBeforeScreenspaceMask  // 0x0
  public    static  UnityEngine.Rendering.LightEventAfterScreenspaceMask  // 0x0
  public    static  UnityEngine.Rendering.LightEventBeforeShadowMapPass  // 0x0
  public    static  UnityEngine.Rendering.LightEventAfterShadowMapPass  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.ShadowMapPass
TYPE:  struct
TOKEN: 0x20002FE
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.ShadowMapPassPointlightPositiveX  // 0x0
  public    static  UnityEngine.Rendering.ShadowMapPassPointlightNegativeX  // 0x0
  public    static  UnityEngine.Rendering.ShadowMapPassPointlightPositiveY  // 0x0
  public    static  UnityEngine.Rendering.ShadowMapPassPointlightNegativeY  // 0x0
  public    static  UnityEngine.Rendering.ShadowMapPassPointlightPositiveZ  // 0x0
  public    static  UnityEngine.Rendering.ShadowMapPassPointlightNegativeZ  // 0x0
  public    static  UnityEngine.Rendering.ShadowMapPassDirectionalCascade0  // 0x0
  public    static  UnityEngine.Rendering.ShadowMapPassDirectionalCascade1  // 0x0
  public    static  UnityEngine.Rendering.ShadowMapPassDirectionalCascade2  // 0x0
  public    static  UnityEngine.Rendering.ShadowMapPassDirectionalCascade3  // 0x0
  public    static  UnityEngine.Rendering.ShadowMapPassSpotlight  // 0x0
  public    static  UnityEngine.Rendering.ShadowMapPassPointlight  // 0x0
  public    static  UnityEngine.Rendering.ShadowMapPassDirectional  // 0x0
  public    static  UnityEngine.Rendering.ShadowMapPassAll  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.BuiltinRenderTextureType
TYPE:  struct
TOKEN: 0x20002FF
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.BuiltinRenderTextureTypePropertyName  // 0x0
  public    static  UnityEngine.Rendering.BuiltinRenderTextureTypeBufferPtr  // 0x0
  public    static  UnityEngine.Rendering.BuiltinRenderTextureTypeRenderTexture  // 0x0
  public    static  UnityEngine.Rendering.BuiltinRenderTextureTypeBindableTexture  // 0x0
  public    static  UnityEngine.Rendering.BuiltinRenderTextureTypeNone  // 0x0
  public    static  UnityEngine.Rendering.BuiltinRenderTextureTypeCurrentActive  // 0x0
  public    static  UnityEngine.Rendering.BuiltinRenderTextureTypeCameraTarget  // 0x0
  public    static  UnityEngine.Rendering.BuiltinRenderTextureTypeDepth  // 0x0
  public    static  UnityEngine.Rendering.BuiltinRenderTextureTypeDepthNormals  // 0x0
  public    static  UnityEngine.Rendering.BuiltinRenderTextureTypeResolvedDepth  // 0x0
  public    static  UnityEngine.Rendering.BuiltinRenderTextureTypePrepassNormalsSpec  // 0x0
  public    static  UnityEngine.Rendering.BuiltinRenderTextureTypePrepassLight  // 0x0
  public    static  UnityEngine.Rendering.BuiltinRenderTextureTypePrepassLightSpec  // 0x0
  public    static  UnityEngine.Rendering.BuiltinRenderTextureTypeGBuffer0  // 0x0
  public    static  UnityEngine.Rendering.BuiltinRenderTextureTypeGBuffer1  // 0x0
  public    static  UnityEngine.Rendering.BuiltinRenderTextureTypeGBuffer2  // 0x0
  public    static  UnityEngine.Rendering.BuiltinRenderTextureTypeGBuffer3  // 0x0
  public    static  UnityEngine.Rendering.BuiltinRenderTextureTypeReflections  // 0x0
  public    static  UnityEngine.Rendering.BuiltinRenderTextureTypeMotionVectors  // 0x0
  public    static  UnityEngine.Rendering.BuiltinRenderTextureTypeGBuffer4  // 0x0
  public    static  UnityEngine.Rendering.BuiltinRenderTextureTypeGBuffer5  // 0x0
  public    static  UnityEngine.Rendering.BuiltinRenderTextureTypeGBuffer6  // 0x0
  public    static  UnityEngine.Rendering.BuiltinRenderTextureTypeGBuffer7  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.ShadowCastingMode
TYPE:  struct
TOKEN: 0x2000300
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.ShadowCastingModeOff  // 0x0
  public    static  UnityEngine.Rendering.ShadowCastingModeOn  // 0x0
  public    static  UnityEngine.Rendering.ShadowCastingModeTwoSided  // 0x0
  public    static  UnityEngine.Rendering.ShadowCastingModeShadowsOnly  // 0x0
  public    static  UnityEngine.Rendering.ShadowCastingModeShadowsOnlyTwoSided  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.LightShadowResolution
TYPE:  struct
TOKEN: 0x2000301
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.LightShadowResolutionFromQualitySettings  // 0x0
  public    static  UnityEngine.Rendering.LightShadowResolutionLow  // 0x0
  public    static  UnityEngine.Rendering.LightShadowResolutionMedium  // 0x0
  public    static  UnityEngine.Rendering.LightShadowResolutionHigh  // 0x0
  public    static  UnityEngine.Rendering.LightShadowResolutionVeryHigh  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.SubMeshRenderMode
TYPE:  struct
TOKEN: 0x2000302
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.SubMeshRenderModeSubMeshRenderModeDefault  // 0x0
  public    static  UnityEngine.Rendering.SubMeshRenderModeSubMeshRenderModeLoop  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.GraphicsDeviceType
TYPE:  struct
TOKEN: 0x2000303
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.GraphicsDeviceTypeOpenGL2  // 0x0
  public    static  UnityEngine.Rendering.GraphicsDeviceTypeDirect3D9  // 0x0
  public    static  UnityEngine.Rendering.GraphicsDeviceTypeDirect3D11  // 0x0
  public    static  UnityEngine.Rendering.GraphicsDeviceTypePlayStation3  // 0x0
  public    static  UnityEngine.Rendering.GraphicsDeviceTypeNull  // 0x0
  public    static  UnityEngine.Rendering.GraphicsDeviceTypeXbox360  // 0x0
  public    static  UnityEngine.Rendering.GraphicsDeviceTypeOpenGLES2  // 0x0
  public    static  UnityEngine.Rendering.GraphicsDeviceTypeOpenGLES3  // 0x0
  public    static  UnityEngine.Rendering.GraphicsDeviceTypePlayStationVita  // 0x0
  public    static  UnityEngine.Rendering.GraphicsDeviceTypePlayStation4  // 0x0
  public    static  UnityEngine.Rendering.GraphicsDeviceTypeXboxOne  // 0x0
  public    static  UnityEngine.Rendering.GraphicsDeviceTypePlayStationMobile  // 0x0
  public    static  UnityEngine.Rendering.GraphicsDeviceTypeMetal  // 0x0
  public    static  UnityEngine.Rendering.GraphicsDeviceTypeOpenGLCore  // 0x0
  public    static  UnityEngine.Rendering.GraphicsDeviceTypeDirect3D12  // 0x0
  public    static  UnityEngine.Rendering.GraphicsDeviceTypeN3DS  // 0x0
  public    static  UnityEngine.Rendering.GraphicsDeviceTypeVulkan  // 0x0
  public    static  UnityEngine.Rendering.GraphicsDeviceTypeSwitch  // 0x0
  public    static  UnityEngine.Rendering.GraphicsDeviceTypeXboxOneD3D12  // 0x0
  public    static  UnityEngine.Rendering.GraphicsDeviceTypeGameCoreXboxOne  // 0x0
  public    static  UnityEngine.Rendering.GraphicsDeviceTypeGameCoreScarlett  // 0x0
  public    static  UnityEngine.Rendering.GraphicsDeviceTypeGameCoreXboxSeries  // 0x0
  public    static  UnityEngine.Rendering.GraphicsDeviceTypePlayStation5  // 0x0
  public    static  UnityEngine.Rendering.GraphicsDeviceTypePlayStation5NGGC  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.GraphicsTier
TYPE:  struct
TOKEN: 0x2000304
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.GraphicsTierTier1  // 0x0
  public    static  UnityEngine.Rendering.GraphicsTierTier2  // 0x0
  public    static  UnityEngine.Rendering.GraphicsTierTier3  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.SubMeshDescriptor
TYPE:  struct
TOKEN: 0x2000305
FIELDS:
  private           UnityEngine.Bounds              <bounds>k__BackingField  // 0x10
  private           UnityEngine.MeshTopology        <topology>k__BackingField  // 0x28
  private           System.Int32                    <indexStart>k__BackingField  // 0x2C
  private           System.Int32                    <indexCount>k__BackingField  // 0x30
  private           System.Int32                    <baseVertex>k__BackingField  // 0x34
  private           System.Int32                    <firstVertex>k__BackingField  // 0x38
  private           System.Int32                    <vertexCount>k__BackingField  // 0x3C
METHODS:
  UnityEngine.Bounds get_bounds()
  UnityEngine.MeshTopology get_topology()
  System.Int32 get_indexStart()
  System.Int32 get_indexCount()
  System.Int32 get_baseVertex()
  System.Int32 get_firstVertex()
  System.Int32 get_vertexCount()
  System.String ToString()
END_CLASS

CLASS: UnityEngine.Rendering.VertexAttributeDescriptor
TYPE:  struct
TOKEN: 0x2000306
FIELDS:
  private           UnityEngine.Rendering.VertexAttribute<attribute>k__BackingField  // 0x10
  private           UnityEngine.Rendering.VertexAttributeFormat<format>k__BackingField  // 0x14
  private           System.Int32                    <dimension>k__BackingField  // 0x18
  private           System.Int32                    <stream>k__BackingField  // 0x1C
METHODS:
  UnityEngine.Rendering.VertexAttribute get_attribute()
  System.Void set_attribute(UnityEngine.Rendering.VertexAttribute value)
  UnityEngine.Rendering.VertexAttributeFormat get_format()
  System.Void set_format(UnityEngine.Rendering.VertexAttributeFormat value)
  System.Int32 get_dimension()
  System.Void set_dimension(System.Int32 value)
  System.Int32 get_stream()
  System.Void set_stream(System.Int32 value)
  System.Void .ctor(UnityEngine.Rendering.VertexAttribute attribute, UnityEngine.Rendering.VertexAttributeFormat format, System.Int32 dimension, System.Int32 stream)
  System.String ToString()
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(UnityEngine.Rendering.VertexAttributeDescriptor other)
END_CLASS

CLASS: UnityEngine.Rendering.FormatSwizzle
TYPE:  struct
TOKEN: 0x2000307
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.FormatSwizzleFormatSwizzleR  // 0x0
  public    static  UnityEngine.Rendering.FormatSwizzleFormatSwizzleG  // 0x0
  public    static  UnityEngine.Rendering.FormatSwizzleFormatSwizzleB  // 0x0
  public    static  UnityEngine.Rendering.FormatSwizzleFormatSwizzleA  // 0x0
  public    static  UnityEngine.Rendering.FormatSwizzleFormatSwizzle0  // 0x0
  public    static  UnityEngine.Rendering.FormatSwizzleFormatSwizzle1  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.RenderTargetIdentifier
TYPE:  struct
TOKEN: 0x2000308
FIELDS:
  public    static  System.Int32                    AllDepthSlices  // 0x0
  private           UnityEngine.Rendering.BuiltinRenderTextureTypem_Type  // 0x10
  private           System.Int32                    m_NameID  // 0x14
  private           System.Int32                    m_InstanceID  // 0x18
  private           System.IntPtr                   m_BufferPointer  // 0x20
  private           System.Int32                    m_MipLevel  // 0x28
  private           UnityEngine.CubemapFace         m_CubeFace  // 0x2C
  private           System.Int32                    m_DepthSlice  // 0x30
METHODS:
  System.Void .ctor(UnityEngine.Rendering.BuiltinRenderTextureType type)
  System.Void .ctor(System.Int32 nameID)
  System.Void .ctor(UnityEngine.Rendering.RenderTargetIdentifier renderTargetIdentifier, System.Int32 mipLevel, UnityEngine.CubemapFace cubeFace, System.Int32 depthSlice)
  System.Void .ctor(UnityEngine.Texture tex)
  System.Void .ctor(UnityEngine.Texture tex, System.Int32 mipLevel, UnityEngine.CubemapFace cubeFace, System.Int32 depthSlice)
  System.Void .ctor(UnityEngine.RenderBuffer buf, System.Int32 mipLevel, UnityEngine.CubemapFace cubeFace, System.Int32 depthSlice)
  UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Rendering.BuiltinRenderTextureType type)
  UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(System.Int32 nameID)
  UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Texture tex)
  System.String ToString()
  System.Int32 GetHashCode()
  System.Boolean Equals(UnityEngine.Rendering.RenderTargetIdentifier rhs)
  System.Boolean Equals(System.Object obj)
  UnityEngine.Rendering.BuiltinRenderTextureType HGGetType()
  System.IntPtr HGGetBufferPointer()
  System.Int32 HGGetInstanceID()
END_CLASS

CLASS: UnityEngine.Rendering.RenderTargetFlags
TYPE:  struct
TOKEN: 0x2000309
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.RenderTargetFlagsNone  // 0x0
  public    static  UnityEngine.Rendering.RenderTargetFlagsReadOnlyDepth  // 0x0
  public    static  UnityEngine.Rendering.RenderTargetFlagsReadOnlyStencil  // 0x0
  public    static  UnityEngine.Rendering.RenderTargetFlagsReadOnlyDepthStencil  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.RenderTargetBinding
TYPE:  struct
TOKEN: 0x200030A
FIELDS:
  private           UnityEngine.Rendering.RenderTargetIdentifier[]m_ColorRenderTargets  // 0x10
  private           UnityEngine.Rendering.RenderTargetIdentifierm_DepthRenderTarget  // 0x18
  private           UnityEngine.Rendering.RenderBufferLoadAction[]m_ColorLoadActions  // 0x40
  private           UnityEngine.Rendering.RenderBufferStoreAction[]m_ColorStoreActions  // 0x48
  private           UnityEngine.Rendering.RenderBufferLoadActionm_DepthLoadAction  // 0x50
  private           UnityEngine.Rendering.RenderBufferStoreActionm_DepthStoreAction  // 0x54
  private           UnityEngine.Rendering.RenderTargetFlagsm_Flags  // 0x58
METHODS:
  UnityEngine.Rendering.RenderTargetIdentifier[] get_colorRenderTargets()
  System.Void set_colorRenderTargets(UnityEngine.Rendering.RenderTargetIdentifier[] value)
  UnityEngine.Rendering.RenderTargetIdentifier get_depthRenderTarget()
  System.Void set_depthRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier value)
  UnityEngine.Rendering.RenderBufferLoadAction[] get_colorLoadActions()
  System.Void set_colorLoadActions(UnityEngine.Rendering.RenderBufferLoadAction[] value)
  UnityEngine.Rendering.RenderBufferStoreAction[] get_colorStoreActions()
  System.Void set_colorStoreActions(UnityEngine.Rendering.RenderBufferStoreAction[] value)
  UnityEngine.Rendering.RenderBufferLoadAction get_depthLoadAction()
  System.Void set_depthLoadAction(UnityEngine.Rendering.RenderBufferLoadAction value)
  UnityEngine.Rendering.RenderBufferStoreAction get_depthStoreAction()
  System.Void set_depthStoreAction(UnityEngine.Rendering.RenderBufferStoreAction value)
  UnityEngine.Rendering.RenderTargetFlags get_flags()
  System.Void .ctor(UnityEngine.Rendering.RenderTargetIdentifier[] colorRenderTargets, UnityEngine.Rendering.RenderBufferLoadAction[] colorLoadActions, UnityEngine.Rendering.RenderBufferStoreAction[] colorStoreActions, UnityEngine.Rendering.RenderTargetIdentifier depthRenderTarget, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction)
END_CLASS

CLASS: UnityEngine.Rendering.ReflectionProbeUsage
TYPE:  struct
TOKEN: 0x200030B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.ReflectionProbeUsageOff  // 0x0
  public    static  UnityEngine.Rendering.ReflectionProbeUsageBlendProbes  // 0x0
  public    static  UnityEngine.Rendering.ReflectionProbeUsageBlendProbesAndSkybox  // 0x0
  public    static  UnityEngine.Rendering.ReflectionProbeUsageSimple  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.ReflectionProbeType
TYPE:  struct
TOKEN: 0x200030C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.ReflectionProbeTypeCube  // 0x0
  public    static  UnityEngine.Rendering.ReflectionProbeTypeCard  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.ReflectionProbeClearFlags
TYPE:  struct
TOKEN: 0x200030D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.ReflectionProbeClearFlagsSkybox  // 0x0
  public    static  UnityEngine.Rendering.ReflectionProbeClearFlagsSolidColor  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.ReflectionProbeOrientedMode
TYPE:  struct
TOKEN: 0x200030E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.ReflectionProbeOrientedModeNone  // 0x0
  public    static  UnityEngine.Rendering.ReflectionProbeOrientedModeCenter  // 0x0
  public    static  UnityEngine.Rendering.ReflectionProbeOrientedModeAxis  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.ReflectionProbeShapeType
TYPE:  struct
TOKEN: 0x200030F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.ReflectionProbeShapeTypeBox  // 0x0
  public    static  UnityEngine.Rendering.ReflectionProbeShapeTypeSphere  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.ReflectionProbeScopeType
TYPE:  struct
TOKEN: 0x2000310
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.ReflectionProbeScopeTypeLocal  // 0x0
  public    static  UnityEngine.Rendering.ReflectionProbeScopeTypeGlobal  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.ReflectionProbeMode
TYPE:  struct
TOKEN: 0x2000311
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.ReflectionProbeModeBaked  // 0x0
  public    static  UnityEngine.Rendering.ReflectionProbeModeRealtime  // 0x0
  public    static  UnityEngine.Rendering.ReflectionProbeModeCustom  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.ReflectionProbeBlendInfo
TYPE:  struct
TOKEN: 0x2000312
FIELDS:
  public            UnityEngine.ReflectionProbe     probe  // 0x10
  public            System.Single                   weight  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.ReflectionProbeRefreshMode
TYPE:  struct
TOKEN: 0x2000313
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.ReflectionProbeRefreshModeOnAwake  // 0x0
  public    static  UnityEngine.Rendering.ReflectionProbeRefreshModeEveryFrame  // 0x0
  public    static  UnityEngine.Rendering.ReflectionProbeRefreshModeViaScripting  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.ReflectionProbeTimeSlicingMode
TYPE:  struct
TOKEN: 0x2000314
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.ReflectionProbeTimeSlicingModeAllFacesAtOnce  // 0x0
  public    static  UnityEngine.Rendering.ReflectionProbeTimeSlicingModeIndividualFaces  // 0x0
  public    static  UnityEngine.Rendering.ReflectionProbeTimeSlicingModeNoTimeSlicing  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.ShadowSamplingMode
TYPE:  struct
TOKEN: 0x2000315
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.ShadowSamplingModeCompareDepths  // 0x0
  public    static  UnityEngine.Rendering.ShadowSamplingModeRawDepth  // 0x0
  public    static  UnityEngine.Rendering.ShadowSamplingModeNone  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.LightProbeUsage
TYPE:  struct
TOKEN: 0x2000316
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.LightProbeUsageOff  // 0x0
  public    static  UnityEngine.Rendering.LightProbeUsageBlendProbes  // 0x0
  public    static  UnityEngine.Rendering.LightProbeUsageUseProxyVolume  // 0x0
  public    static  UnityEngine.Rendering.LightProbeUsageCustomProvided  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.BuiltinShaderDefine
TYPE:  struct
TOKEN: 0x2000317
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.BuiltinShaderDefineUNITY_NO_DXT5nm  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineUNITY_NO_RGBM  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineUNITY_USE_NATIVE_HDR  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineUNITY_ENABLE_REFLECTION_BUFFERS  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineUNITY_FRAMEBUFFER_FETCH_AVAILABLE  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineUNITY_ENABLE_NATIVE_SHADOW_LOOKUPS  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineUNITY_METAL_SHADOWS_USE_POINT_FILTERING  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineUNITY_NO_CUBEMAP_ARRAY  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineUNITY_NO_SCREENSPACE_SHADOWS  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineUNITY_USE_DITHER_MASK_FOR_ALPHABLENDED_SHADOWS  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineUNITY_PBS_USE_BRDF1  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineUNITY_PBS_USE_BRDF2  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineUNITY_PBS_USE_BRDF3  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineUNITY_NO_FULL_STANDARD_SHADER  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineUNITY_SPECCUBE_BOX_PROJECTION  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineUNITY_SPECCUBE_BLENDING  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineUNITY_ENABLE_DETAIL_NORMALMAP  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineSHADER_API_MOBILE  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineSHADER_API_DESKTOP  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineUNITY_HARDWARE_TIER1  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineUNITY_HARDWARE_TIER2  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineUNITY_HARDWARE_TIER3  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineUNITY_COLORSPACE_GAMMA  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineUNITY_LIGHT_PROBE_PROXY_VOLUME  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineUNITY_HALF_PRECISION_FRAGMENT_SHADER_REGISTERS  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineUNITY_LIGHTMAP_DLDR_ENCODING  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineUNITY_LIGHTMAP_RGBM_ENCODING  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineUNITY_LIGHTMAP_FULL_HDR  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineUNITY_VIRTUAL_TEXTURING  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineUNITY_PRETRANSFORM_TO_DISPLAY_ORIENTATION  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineUNITY_ASTC_NORMALMAP_ENCODING  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineSHADER_API_GLES30  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineUNITY_UNIFIED_SHADER_PRECISION_MODEL  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineHG_RENDER_PATH_MOBILE  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineHG_RENDER_PATH_DESKTOP  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineHG_RENDER_PATH_FORWARD  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineHG_RENDER_PATH_DEFAULT_DEFERRED  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineHG_RENDER_PATH_ONE_PASS_DEFERRED  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineHG_DEVICE_TIER_1000  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineHG_DEVICE_TIER_2000  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineHG_DEVICE_TIER_3000  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineHG_DEVICE_TIER_4000  // 0x0
  public    static  UnityEngine.Rendering.BuiltinShaderDefineHG_DEVICE_TIER_5000  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.TextureDimension
TYPE:  struct
TOKEN: 0x2000318
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.TextureDimensionUnknown  // 0x0
  public    static  UnityEngine.Rendering.TextureDimensionNone  // 0x0
  public    static  UnityEngine.Rendering.TextureDimensionAny  // 0x0
  public    static  UnityEngine.Rendering.TextureDimensionTex2D  // 0x0
  public    static  UnityEngine.Rendering.TextureDimensionTex3D  // 0x0
  public    static  UnityEngine.Rendering.TextureDimensionCube  // 0x0
  public    static  UnityEngine.Rendering.TextureDimensionTex2DArray  // 0x0
  public    static  UnityEngine.Rendering.TextureDimensionCubeArray  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.CopyTextureSupport
TYPE:  struct
TOKEN: 0x2000319
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.CopyTextureSupportNone  // 0x0
  public    static  UnityEngine.Rendering.CopyTextureSupportBasic  // 0x0
  public    static  UnityEngine.Rendering.CopyTextureSupportCopy3D  // 0x0
  public    static  UnityEngine.Rendering.CopyTextureSupportDifferentTypes  // 0x0
  public    static  UnityEngine.Rendering.CopyTextureSupportTextureToRT  // 0x0
  public    static  UnityEngine.Rendering.CopyTextureSupportRTToTexture  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.ComputeQueueType
TYPE:  struct
TOKEN: 0x200031A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.ComputeQueueTypeDefault  // 0x0
  public    static  UnityEngine.Rendering.ComputeQueueTypeBackground  // 0x0
  public    static  UnityEngine.Rendering.ComputeQueueTypeUrgent  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.CommandBufferExecutionFlags
TYPE:  struct
TOKEN: 0x200031B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.CommandBufferExecutionFlagsNone  // 0x0
  public    static  UnityEngine.Rendering.CommandBufferExecutionFlagsAsyncCompute  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.RTClearFlags
TYPE:  struct
TOKEN: 0x200031C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.RTClearFlagsNone  // 0x0
  public    static  UnityEngine.Rendering.RTClearFlagsColor  // 0x0
  public    static  UnityEngine.Rendering.RTClearFlagsDepth  // 0x0
  public    static  UnityEngine.Rendering.RTClearFlagsStencil  // 0x0
  public    static  UnityEngine.Rendering.RTClearFlagsAll  // 0x0
  public    static  UnityEngine.Rendering.RTClearFlagsDepthStencil  // 0x0
  public    static  UnityEngine.Rendering.RTClearFlagsColorDepth  // 0x0
  public    static  UnityEngine.Rendering.RTClearFlagsColorStencil  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.RenderTextureSubElement
TYPE:  struct
TOKEN: 0x200031D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.RenderTextureSubElementColor  // 0x0
  public    static  UnityEngine.Rendering.RenderTextureSubElementDepth  // 0x0
  public    static  UnityEngine.Rendering.RenderTextureSubElementStencil  // 0x0
  public    static  UnityEngine.Rendering.RenderTextureSubElementDefault  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.OpenGLESVersion
TYPE:  struct
TOKEN: 0x200031E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.OpenGLESVersionNone  // 0x0
  public    static  UnityEngine.Rendering.OpenGLESVersionOpenGLES20  // 0x0
  public    static  UnityEngine.Rendering.OpenGLESVersionOpenGLES30  // 0x0
  public    static  UnityEngine.Rendering.OpenGLESVersionOpenGLES31  // 0x0
  public    static  UnityEngine.Rendering.OpenGLESVersionOpenGLES31AEP  // 0x0
  public    static  UnityEngine.Rendering.OpenGLESVersionOpenGLES32  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.SynchronisationStageFlags
TYPE:  struct
TOKEN: 0x200031F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.SynchronisationStageFlagsVertexProcessing  // 0x0
  public    static  UnityEngine.Rendering.SynchronisationStageFlagsPixelProcessing  // 0x0
  public    static  UnityEngine.Rendering.SynchronisationStageFlagsComputeProcessing  // 0x0
  public    static  UnityEngine.Rendering.SynchronisationStageFlagsAllGPUOperations  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.GraphicsFenceType
TYPE:  struct
TOKEN: 0x2000320
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.GraphicsFenceTypeAsyncQueueSynchronisation  // 0x0
  public    static  UnityEngine.Rendering.GraphicsFenceTypeCPUSynchronisation  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.GraphicsFence
TYPE:  struct
TOKEN: 0x2000321
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
  private           System.Int32                    m_Version  // 0x18
  private           UnityEngine.Rendering.GraphicsFenceTypem_FenceType  // 0x1C
METHODS:
  UnityEngine.Rendering.SynchronisationStageFlags TranslateSynchronizationStageToFlags(UnityEngine.Rendering.SynchronisationStage s)
  System.Void InitPostAllocation()
  System.Boolean IsFencePending()
  System.Void Validate()
  System.Int32 GetPlatformNotSupportedVersion()
  System.Int32 GetVersionNumber(System.IntPtr fencePtr)
END_CLASS

CLASS: UnityEngine.Rendering.GraphicsSettings
TYPE:  class
TOKEN: 0x2000322
FIELDS:
METHODS:
  System.Boolean get_lightsUseLinearIntensity()
  System.Void set_useScriptableRenderPipelineBatching(System.Boolean value)
  System.Void set_enableSRPBatchInstancing(System.Boolean value)
  System.Boolean HasShaderDefine(UnityEngine.Rendering.GraphicsTier tier, UnityEngine.Rendering.BuiltinShaderDefine defineHash)
  System.Boolean HasShaderDefine(UnityEngine.Rendering.BuiltinShaderDefine defineHash)
  UnityEngine.ScriptableObject get_INTERNAL_currentRenderPipeline()
  UnityEngine.Rendering.RenderPipelineAsset get_currentRenderPipeline()
  UnityEngine.Rendering.RenderPipelineAsset get_renderPipelineAsset()
  System.Void set_renderPipelineAsset(UnityEngine.Rendering.RenderPipelineAsset value)
  UnityEngine.ScriptableObject get_INTERNAL_defaultRenderPipeline()
  System.Void set_INTERNAL_defaultRenderPipeline(UnityEngine.ScriptableObject value)
  UnityEngine.Rendering.RenderPipelineAsset get_defaultRenderPipeline()
  System.Void set_defaultRenderPipeline(UnityEngine.Rendering.RenderPipelineAsset value)
  System.Void RegisterRenderPipelineSettings(UnityEngine.Rendering.RenderPipelineGlobalSettings settings)
  System.Void RegisterRenderPipeline(System.String renderpipelineName, UnityEngine.Object settings)
  System.Void UnregisterRenderPipelineSettings()
  System.Void UnregisterRenderPipeline(System.String renderpipelineName)
  UnityEngine.Rendering.RenderPipelineGlobalSettings GetSettingsForRenderPipeline()
  UnityEngine.Object GetSettingsForRenderPipeline(System.String renderpipelineName)
  System.Void INTERNAL_AddShaderToSRPInstancingWhiteList(System.String shaderName)
  System.Void AddShaderToSRPInstancingWhiteList(System.String shaderName)
END_CLASS

CLASS: UnityEngine.Rendering.OnDemandRendering
TYPE:  class
TOKEN: 0x2000323
FIELDS:
  private   static  System.Int32                    m_RenderFrameInterval  // 0x0
METHODS:
  System.Int32 get_renderFrameInterval()
  System.Void GetRenderFrameInterval(System.Int32& frameInterval)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Rendering.CommandBuffer
TYPE:  class
TOKEN: 0x2000324
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
METHODS:
  System.Void SetInvertCulling(System.Boolean invertCulling)
  System.IntPtr InitBuffer()
  System.IntPtr InitBufferTempJobAlloc()
  System.Void HGSetFragmentShadingRate(System.UInt32 fragmentSizeX, System.UInt32 fragmentSizeY)
  System.Void HGSetTransparentOffscreenBlend(System.Boolean offscreenBlend)
  System.IntPtr CreateGPUFence_Internal(UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage)
  System.Void WaitOnGPUFence_Internal(System.IntPtr fencePtr, UnityEngine.Rendering.SynchronisationStageFlags stage)
  System.Void ReleaseBuffer()
  System.Void SetComputeIntParam(UnityEngine.ComputeShader computeShader, System.Int32 nameID, System.Int32 val)
  System.Void SetComputeVectorParam(UnityEngine.ComputeShader computeShader, System.Int32 nameID, UnityEngine.Vector4 val)
  System.Void SetComputeVectorArrayParam(UnityEngine.ComputeShader computeShader, System.Int32 nameID, UnityEngine.Vector4[] values)
  System.Void SetComputeValueParam(UnityEngine.ComputeShader computeShader, System.Int32 nameID, System.UIntPtr data, System.Int32 byteCount)
  System.Void SetComputeMatrixParam(UnityEngine.ComputeShader computeShader, System.Int32 nameID, UnityEngine.Matrix4x4 val)
  System.Void Internal_SetComputeTextureParam(UnityEngine.ComputeShader computeShader, System.Int32 kernelIndex, System.Int32 nameID, UnityEngine.Rendering.RenderTargetIdentifier& rt, System.Int32 mipLevel, UnityEngine.Rendering.RenderTextureSubElement element, System.Int32 slice)
  System.Void Internal_SetComputeBufferParam(UnityEngine.ComputeShader computeShader, System.Int32 kernelIndex, System.Int32 nameID, UnityEngine.ComputeBuffer buffer, System.Int32 offset, System.Int32 size)
  System.Void Internal_SetComputeBufferIDParam(UnityEngine.ComputeShader computeShader, System.Int32 kernelIndex, System.Int32 nameID, System.UInt32 bufferID, System.Int32 offset, System.Int32 size)
  System.Void Internal_SetComputeConstantComputeBufferParam(UnityEngine.ComputeShader computeShader, System.Int32 nameID, UnityEngine.ComputeBuffer buffer, System.Int32 offset, System.Int32 size)
  System.Void Internal_SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, System.Int32 nameID, System.UInt32 bufferId, System.Int32 offset, System.Int32 size)
  System.Void Internal_DispatchCompute(UnityEngine.ComputeShader computeShader, System.Int32 kernelIndex, System.Int32 threadGroupsX, System.Int32 threadGroupsY, System.Int32 threadGroupsZ)
  System.Void set_name(System.String value)
  System.Int32 get_sizeInBytes()
  System.Void Clear()
  System.Void Internal_DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 submeshIndex, System.Int32 shaderPass, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.RenderStateBlock* overrideState)
  System.Void Internal_DrawRendererList(UnityEngine.Rendering.RendererUtils.RendererList rendererList)
  System.Void AddDrawECSMeshRendererList(System.UInt32 rendererList)
  System.Void AddDrawECSMeshRendererListWithSRPRendererList(System.UInt32 ecsList, UnityEngine.Rendering.RendererUtils.RendererList srpList)
  System.Void AddDrawECSGrassRendererList(System.UInt32 rendererList)
  System.Void AddDrawECSDecalRendererList(System.UInt32 rendererList)
  System.Void AddDrawECSFoliageOccluderRendererList(System.UInt32 rendererList)
  System.Void Add_GPUDriven_DrawRendererList(System.UInt32 rendererList, System.Boolean renderMatchedPrev)
  System.Void Internal_DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 shaderPass, UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount, UnityEngine.MaterialPropertyBlock properties)
  System.Void Internal_DrawProceduralIndexedIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties)
  System.Void Internal_DrawMeshInstancedNativeMatrixArray(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Int32 shaderPass, System.IntPtr matrices, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.RenderStateBlock* overrideState)
  System.Void Internal_HGDrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Int32 shaderPass, System.Int32 count, UnityEngine.MaterialPropertyBlock properties)
  System.Void Internal_DrawMeshInstancedProcedural(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Int32 shaderPass, System.Int32 count, UnityEngine.MaterialPropertyBlock properties)
  System.Void Internal_DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Int32 shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.RenderStateBlock* overrideState)
  System.Void Internal_DrawOcclusionMesh(UnityEngine.RectInt normalizedCamViewport)
  System.Void SetRandomWriteTarget_Buffer(System.Int32 index, UnityEngine.ComputeBuffer uav, System.Boolean preserveCounterValue)
  System.Void SetViewport(UnityEngine.Rect pixelRect)
  System.Void EnableScissorRect(UnityEngine.Rect scissor)
  System.Void DisableScissorRect()
  System.Void CopyTexture_Internal(UnityEngine.Rendering.RenderTargetIdentifier& src, System.Int32 srcElement, System.Int32 srcMip, System.Int32 srcX, System.Int32 srcY, System.Int32 srcWidth, System.Int32 srcHeight, UnityEngine.Rendering.RenderTargetIdentifier& dst, System.Int32 dstElement, System.Int32 dstMip, System.Int32 dstX, System.Int32 dstY, System.Int32 mode)
  System.Void Blit_Texture(UnityEngine.Texture source, UnityEngine.Rendering.RenderTargetIdentifier& dest, UnityEngine.Material mat, System.Int32 pass, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, System.Int32 sourceDepthSlice, System.Int32 destDepthSlice)
  System.Void Blit_Identifier(UnityEngine.Rendering.RenderTargetIdentifier& source, UnityEngine.Rendering.RenderTargetIdentifier& dest, UnityEngine.Material mat, System.Int32 pass, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, System.Int32 sourceDepthSlice, System.Int32 destDepthSlice)
  System.Void EncodeMetalFXSpatialScaler(System.UInt32 spatialScalerHandle, UnityEngine.Rendering.RenderTargetIdentifier colorTexture, UnityEngine.Rendering.RenderTargetIdentifier outputTexture)
  System.Void EncodeMetalFXTemporalScaler(System.UInt32 temporalScalerHandle, System.Boolean resetHistory, UnityEngine.Rendering.RenderTargetIdentifier colorTexture, UnityEngine.Rendering.RenderTargetIdentifier depthTexture, UnityEngine.Rendering.RenderTargetIdentifier motionTexture, UnityEngine.Rendering.RenderTargetIdentifier outputTexture, System.Boolean reversedDepth, System.Single jitterOffsetX, System.Single jitterOffsetY)
  System.Void GetTemporaryRTWithDescriptor(System.Int32 nameID, UnityEngine.RenderTextureDescriptor desc, UnityEngine.FilterMode filter)
  System.Void GetTemporaryRT(System.Int32 nameID, UnityEngine.RenderTextureDescriptor desc, UnityEngine.FilterMode filter)
  System.Void GetTemporaryRT(System.Int32 nameID, UnityEngine.RenderTextureDescriptor desc)
  System.Void ReleaseTemporaryRT(System.Int32 nameID)
  System.Void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color backgroundColor, System.Single depth, System.UInt32 stencil)
  System.Void ClearRenderTarget(System.Boolean clearDepth, System.Boolean clearColor, UnityEngine.Color backgroundColor)
  System.Void SetGlobalFloat(System.Int32 nameID, System.Single value)
  System.Void SetGlobalInt(System.Int32 nameID, System.Int32 value)
  System.Void SetGlobalVector(System.Int32 nameID, UnityEngine.Vector4 value)
  System.Void SetGlobalColor(System.Int32 nameID, UnityEngine.Color value)
  System.Void SetGlobalMatrix(System.Int32 nameID, UnityEngine.Matrix4x4 value)
  System.Void EnableShaderKeyword(System.String keyword)
  System.Void EnableMaterialKeyword(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword keyword)
  System.Void EnableComputeKeyword(UnityEngine.ComputeShader computeShader, UnityEngine.Rendering.LocalKeyword keyword)
  System.Void EnableKeyword(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword& keyword)
  System.Void EnableKeyword(UnityEngine.ComputeShader computeShader, UnityEngine.Rendering.LocalKeyword& keyword)
  System.Void DisableShaderKeyword(System.String keyword)
  System.Void DisableMaterialKeyword(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword keyword)
  System.Void DisableComputeKeyword(UnityEngine.ComputeShader computeShader, UnityEngine.Rendering.LocalKeyword keyword)
  System.Void DisableKeyword(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword& keyword)
  System.Void DisableKeyword(UnityEngine.ComputeShader computeShader, UnityEngine.Rendering.LocalKeyword& keyword)
  System.Void SetGlobalKeyword(UnityEngine.Rendering.GlobalKeyword keyword, System.Boolean value)
  System.Void SetMaterialKeyword(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword keyword, System.Boolean value)
  System.Void SetComputeKeyword(UnityEngine.ComputeShader computeShader, UnityEngine.Rendering.LocalKeyword keyword, System.Boolean value)
  System.Void SetKeyword(UnityEngine.Rendering.GlobalKeyword& keyword, System.Boolean value)
  System.Void SetKeyword(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword& keyword, System.Boolean value)
  System.Void SetKeyword(UnityEngine.ComputeShader computeShader, UnityEngine.Rendering.LocalKeyword& keyword, System.Boolean value)
  System.Void SetGlobalDepthBias(System.Single bias, System.Single slopeBias)
  System.Void SetExecutionFlags(UnityEngine.Rendering.CommandBufferExecutionFlags flags)
  System.Boolean ValidateAgainstExecutionFlags(UnityEngine.Rendering.CommandBufferExecutionFlags requiredFlags, UnityEngine.Rendering.CommandBufferExecutionFlags invalidFlags)
  System.Void SetGlobalVectorArray(System.Int32 nameID, UnityEngine.Vector4[] values)
  System.Void SetGlobalTexture_Impl(System.Int32 nameID, UnityEngine.Rendering.RenderTargetIdentifier& rt, UnityEngine.Rendering.RenderTextureSubElement element)
  System.Void SetGlobalBufferInternal(System.Int32 nameID, UnityEngine.ComputeBuffer value)
  System.Void SetGlobalBufferIDInternal(System.Int32 nameID, System.UInt32 bufferID)
  System.Void BeginSample(System.String name)
  System.Void EndSample(System.String name)
  System.Void BeginSample(UnityEngine.Profiling.CustomSampler sampler)
  System.Void EndSample(UnityEngine.Profiling.CustomSampler sampler)
  System.Void BeginSample_CustomSampler(UnityEngine.Profiling.CustomSampler sampler)
  System.Void EndSample_CustomSampler(UnityEngine.Profiling.CustomSampler sampler)
  System.Void SetGlobalConstantBufferInternal(UnityEngine.ComputeBuffer buffer, System.Int32 nameID, System.Int32 offset, System.Int32 size)
  System.Void SetGlobalConstantBufferInternal0(System.UInt32 bufferId, System.Int32 nameID, System.Int32 offset, System.Int32 size)
  System.Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt)
  System.Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction)
  System.Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction)
  System.Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, System.Int32 mipLevel)
  System.Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, System.Int32 mipLevel, UnityEngine.CubemapFace cubemapFace, System.Int32 depthSlice)
  System.Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, System.Int32 mipLevel, UnityEngine.CubemapFace cubemapFace, System.Int32 depthSlice)
  System.Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction)
  System.Void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth, System.Int32 mipLevel, UnityEngine.CubemapFace cubemapFace, System.Int32 depthSlice)
  System.Void SetRenderTarget(UnityEngine.Rendering.RenderTargetBinding binding)
  System.Void SetRenderTargetSingle_Internal(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction)
  System.Void SetRenderTargetColorDepth_Internal(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.RenderTargetFlags flags)
  System.Void SetRenderTargetMulti_Internal(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction[] colorLoadActions, UnityEngine.Rendering.RenderBufferStoreAction[] colorStoreActions, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.RenderTargetFlags flags)
  System.Void SetRenderTargetMultiSubtarget(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction[] colorLoadActions, UnityEngine.Rendering.RenderBufferStoreAction[] colorStoreActions, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, System.Int32 mipLevel, UnityEngine.CubemapFace cubemapFace, System.Int32 depthSlice)
  System.Void SetBufferData(UnityEngine.ComputeBuffer buffer, System.Array data)
  System.Void InternalSetComputeBufferData(UnityEngine.ComputeBuffer buffer, System.Array data, System.Int32 managedBufferStartIndex, System.Int32 graphicsBufferStartIndex, System.Int32 count, System.Int32 elemSize)
  System.Void CopyBufferToImageImpl(UnityEngine.ComputeBuffer source, System.Int32 bufferOffset, UnityEngine.Texture dest, System.Int32 texOffsetX, System.Int32 texOffsetY, System.Int32 texOffsetZ, System.Int32 texExtentX, System.Int32 texExtentY, System.Int32 texExtentZ, System.Int32 mipLevel, System.Int32 layer)
  System.Void SetProfilingHGPassImpl(System.Int32 pass)
  System.Void SetProfilingHGPass(UnityEngine.Profiling.ProfilingHGPass pass)
  System.Void RenderUIOverlayImpl(UnityEngine.Camera camera)
  System.Void HGDrawUIRendererListImpl(System.UInt32 listHandle)
  System.IntPtr GetNativePtr()
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void .ctor()
  System.Void Release()
  System.Void InitWithTempJobAlloc()
  System.Void ReleaseInternalPtr()
  UnityEngine.Rendering.GraphicsFence CreateAsyncGraphicsFence()
  UnityEngine.Rendering.GraphicsFence CreateGraphicsFence(UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage)
  System.Void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence fence)
  System.Void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence fence, UnityEngine.Rendering.SynchronisationStage stage)
  System.Void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence fence, UnityEngine.Rendering.SynchronisationStageFlags stage)
  System.Void SetComputeVectorParam(UnityEngine.ComputeShader computeShader, System.String name, UnityEngine.Vector4 val)
  System.Void SetComputeValueParam(UnityEngine.ComputeShader computeShader, System.Int32 nameID, Unity.Collections.NativeArray<T> data)
  System.Void SetComputeMatrixParam(UnityEngine.ComputeShader computeShader, System.String name, UnityEngine.Matrix4x4 val)
  System.Void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, System.Int32 kernelIndex, System.String name, UnityEngine.Rendering.RenderTargetIdentifier rt)
  System.Void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, System.Int32 kernelIndex, System.Int32 nameID, UnityEngine.Rendering.RenderTargetIdentifier rt)
  System.Void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, System.Int32 kernelIndex, System.String name, UnityEngine.Rendering.RenderTargetIdentifier rt, System.Int32 mipLevel)
  System.Void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, System.Int32 kernelIndex, System.Int32 nameID, UnityEngine.Rendering.RenderTargetIdentifier rt, System.Int32 mipLevel)
  System.Void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, System.Int32 kernelIndex, System.String name, UnityEngine.Rendering.RenderTargetIdentifier rt, System.Int32 mipLevel, UnityEngine.Rendering.RenderTextureSubElement element)
  System.Void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, System.Int32 kernelIndex, System.Int32 nameID, UnityEngine.Rendering.RenderTargetIdentifier rt, System.Int32 mipLevel, UnityEngine.Rendering.RenderTextureSubElement element)
  System.Void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, System.Int32 kernelIndex, System.Int32 nameID, UnityEngine.ComputeBuffer buffer, System.Int32 offset, System.Int32 size)
  System.Void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, System.Int32 kernelIndex, System.String name, UnityEngine.ComputeBuffer buffer, System.Int32 offset, System.Int32 size)
  System.Void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, System.Int32 kernelIndex, System.Int32 nameID, System.UInt32 bufferID, System.Int32 offset, System.Int32 size)
  System.Void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, System.Int32 nameID, UnityEngine.ComputeBuffer buffer, System.Int32 offset, System.Int32 size)
  System.Void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, System.Int32 nameID, System.UInt32 bufferId, System.Int32 offset, System.Int32 size)
  System.Void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, System.String name, System.UInt32 bufferId, System.Int32 offset, System.Int32 size)
  System.Void SetGlobalConstantBuffer(System.UInt32 bufferId, System.Int32 nameID, System.Int32 offset, System.Int32 size)
  System.Void SetGlobalConstantBuffer(System.UInt32 bufferId, System.String name, System.Int32 offset, System.Int32 size)
  System.Void DispatchCompute(UnityEngine.ComputeShader computeShader, System.Int32 kernelIndex, System.Int32 threadGroupsX, System.Int32 threadGroupsY, System.Int32 threadGroupsZ)
  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 submeshIndex, System.Int32 shaderPass, UnityEngine.MaterialPropertyBlock properties, System.Nullable<UnityEngine.Rendering.RenderStateBlock> overrideState)
  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 submeshIndex, System.Int32 shaderPass, UnityEngine.MaterialPropertyBlock properties)
  System.Void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 submeshIndex, System.Int32 shaderPass)
  System.Void DrawRendererList(UnityEngine.Rendering.RendererUtils.RendererList rendererList)
  System.Void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 shaderPass, UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount, UnityEngine.MaterialPropertyBlock properties)
  System.Void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties)
  System.Void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset)
  System.Void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, System.Int32 shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs)
  System.Void HGDrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Int32 shaderPass, System.Int32 count, UnityEngine.MaterialPropertyBlock properties)
  System.Void DrawMeshInstanced(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Int32 shaderPass, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> matrices, System.Int32 count, UnityEngine.MaterialPropertyBlock properties, System.Nullable<UnityEngine.Rendering.RenderStateBlock> overrideState)
  System.Void DrawMeshInstancedProcedural(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Int32 shaderPass, System.Int32 count, UnityEngine.MaterialPropertyBlock properties)
  System.Void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Int32 shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties, System.Nullable<UnityEngine.Rendering.RenderStateBlock> overrideState)
  System.Void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, System.Int32 submeshIndex, UnityEngine.Material material, System.Int32 shaderPass, UnityEngine.ComputeBuffer bufferWithArgs)
  System.Void DrawOcclusionMesh(UnityEngine.RectInt normalizedCamViewport)
  System.Void SetRandomWriteTarget(System.Int32 index, UnityEngine.ComputeBuffer buffer, System.Boolean preserveCounterValue)
  System.Void SetRandomWriteTarget(System.Int32 index, UnityEngine.ComputeBuffer buffer)
  System.Void CopyTexture(UnityEngine.Rendering.RenderTargetIdentifier src, UnityEngine.Rendering.RenderTargetIdentifier dst)
  System.Void CopyTexture(UnityEngine.Rendering.RenderTargetIdentifier src, System.Int32 srcElement, UnityEngine.Rendering.RenderTargetIdentifier dst, System.Int32 dstElement)
  System.Void CopyTexture(UnityEngine.Rendering.RenderTargetIdentifier src, System.Int32 srcElement, System.Int32 srcMip, UnityEngine.Rendering.RenderTargetIdentifier dst, System.Int32 dstElement, System.Int32 dstMip)
  System.Void CopyTexture(UnityEngine.Rendering.RenderTargetIdentifier src, System.Int32 srcElement, System.Int32 srcMip, System.Int32 srcX, System.Int32 srcY, System.Int32 srcWidth, System.Int32 srcHeight, UnityEngine.Rendering.RenderTargetIdentifier dst, System.Int32 dstElement, System.Int32 dstMip, System.Int32 dstX, System.Int32 dstY)
  System.Void Blit(UnityEngine.Texture source, UnityEngine.Rendering.RenderTargetIdentifier dest)
  System.Void Blit(UnityEngine.Texture source, UnityEngine.Rendering.RenderTargetIdentifier dest, UnityEngine.Material mat, System.Int32 pass)
  System.Void Blit(UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier dest, System.Int32 sourceDepthSlice, System.Int32 destDepthSlice)
  System.Void SetGlobalVectorArray(System.String propertyName, UnityEngine.Vector4[] values)
  System.Void SetGlobalTexture(System.String name, UnityEngine.Rendering.RenderTargetIdentifier value)
  System.Void SetGlobalTexture(System.Int32 nameID, UnityEngine.Rendering.RenderTargetIdentifier value)
  System.Void SetGlobalTexture(System.Int32 nameID, UnityEngine.Rendering.RenderTargetIdentifier value, UnityEngine.Rendering.RenderTextureSubElement element)
  System.Void SetGlobalBuffer(System.Int32 nameID, UnityEngine.ComputeBuffer value)
  System.Void SetGlobalBuffer(System.Int32 nameID, System.UInt32 bufferID)
  System.Void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, System.Int32 nameID, System.Int32 offset, System.Int32 size)
  System.Void CopyBufferToImage(UnityEngine.ComputeBuffer source, System.Int32 offset, UnityEngine.Texture dest, System.Int32 texOffsetX, System.Int32 texOffsetY, System.Int32 texOffsetZ, System.Int32 texExtentX, System.Int32 texExtentY, System.Int32 texExtentZ, System.Int32 mipLevel, System.Int32 layer)
  System.Void RenderUIOverlay(UnityEngine.Camera camera)
  System.Void HGDrawUIRendererList(System.UInt32 listHandle)
  System.Void SetComputeVectorParam_Injected(UnityEngine.ComputeShader computeShader, System.Int32 nameID, UnityEngine.Vector4& val)
  System.Void SetComputeMatrixParam_Injected(UnityEngine.ComputeShader computeShader, System.Int32 nameID, UnityEngine.Matrix4x4& val)
  System.Void Internal_DrawMesh_Injected(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4& matrix, UnityEngine.Material material, System.Int32 submeshIndex, System.Int32 shaderPass, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.RenderStateBlock* overrideState)
  System.Void Internal_DrawRendererList_Injected(UnityEngine.Rendering.RendererUtils.RendererList& rendererList)
  System.Void AddDrawECSMeshRendererListWithSRPRendererList_Injected(System.UInt32 ecsList, UnityEngine.Rendering.RendererUtils.RendererList& srpList)
  System.Void Internal_DrawProcedural_Injected(UnityEngine.Matrix4x4& matrix, UnityEngine.Material material, System.Int32 shaderPass, UnityEngine.MeshTopology topology, System.Int32 vertexCount, System.Int32 instanceCount, UnityEngine.MaterialPropertyBlock properties)
  System.Void Internal_DrawProceduralIndexedIndirect_Injected(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4& matrix, UnityEngine.Material material, System.Int32 shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, System.Int32 argsOffset, UnityEngine.MaterialPropertyBlock properties)
  System.Void Internal_DrawOcclusionMesh_Injected(UnityEngine.RectInt& normalizedCamViewport)
  System.Void SetViewport_Injected(UnityEngine.Rect& pixelRect)
  System.Void EnableScissorRect_Injected(UnityEngine.Rect& scissor)
  System.Void Blit_Texture_Injected(UnityEngine.Texture source, UnityEngine.Rendering.RenderTargetIdentifier& dest, UnityEngine.Material mat, System.Int32 pass, UnityEngine.Vector2& scale, UnityEngine.Vector2& offset, System.Int32 sourceDepthSlice, System.Int32 destDepthSlice)
  System.Void Blit_Identifier_Injected(UnityEngine.Rendering.RenderTargetIdentifier& source, UnityEngine.Rendering.RenderTargetIdentifier& dest, UnityEngine.Material mat, System.Int32 pass, UnityEngine.Vector2& scale, UnityEngine.Vector2& offset, System.Int32 sourceDepthSlice, System.Int32 destDepthSlice)
  System.Void EncodeMetalFXSpatialScaler_Injected(System.UInt32 spatialScalerHandle, UnityEngine.Rendering.RenderTargetIdentifier& colorTexture, UnityEngine.Rendering.RenderTargetIdentifier& outputTexture)
  System.Void EncodeMetalFXTemporalScaler_Injected(System.UInt32 temporalScalerHandle, System.Boolean resetHistory, UnityEngine.Rendering.RenderTargetIdentifier& colorTexture, UnityEngine.Rendering.RenderTargetIdentifier& depthTexture, UnityEngine.Rendering.RenderTargetIdentifier& motionTexture, UnityEngine.Rendering.RenderTargetIdentifier& outputTexture, System.Boolean reversedDepth, System.Single jitterOffsetX, System.Single jitterOffsetY)
  System.Void GetTemporaryRTWithDescriptor_Injected(System.Int32 nameID, UnityEngine.RenderTextureDescriptor& desc, UnityEngine.FilterMode filter)
  System.Void ClearRenderTarget_Injected(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color& backgroundColor, System.Single depth, System.UInt32 stencil)
  System.Void SetGlobalVector_Injected(System.Int32 nameID, UnityEngine.Vector4& value)
  System.Void SetGlobalColor_Injected(System.Int32 nameID, UnityEngine.Color& value)
  System.Void SetGlobalMatrix_Injected(System.Int32 nameID, UnityEngine.Matrix4x4& value)
  System.Void EnableMaterialKeyword_Injected(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword& keyword)
  System.Void EnableComputeKeyword_Injected(UnityEngine.ComputeShader computeShader, UnityEngine.Rendering.LocalKeyword& keyword)
  System.Void DisableMaterialKeyword_Injected(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword& keyword)
  System.Void DisableComputeKeyword_Injected(UnityEngine.ComputeShader computeShader, UnityEngine.Rendering.LocalKeyword& keyword)
  System.Void SetGlobalKeyword_Injected(UnityEngine.Rendering.GlobalKeyword& keyword, System.Boolean value)
  System.Void SetMaterialKeyword_Injected(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword& keyword, System.Boolean value)
  System.Void SetComputeKeyword_Injected(UnityEngine.ComputeShader computeShader, UnityEngine.Rendering.LocalKeyword& keyword, System.Boolean value)
  System.Void SetRenderTargetSingle_Internal_Injected(UnityEngine.Rendering.RenderTargetIdentifier& rt, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction)
  System.Void SetRenderTargetColorDepth_Internal_Injected(UnityEngine.Rendering.RenderTargetIdentifier& color, UnityEngine.Rendering.RenderTargetIdentifier& depth, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.RenderTargetFlags flags)
  System.Void SetRenderTargetMulti_Internal_Injected(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier& depth, UnityEngine.Rendering.RenderBufferLoadAction[] colorLoadActions, UnityEngine.Rendering.RenderBufferStoreAction[] colorStoreActions, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.RenderTargetFlags flags)
  System.Void SetRenderTargetMultiSubtarget_Injected(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier& depth, UnityEngine.Rendering.RenderBufferLoadAction[] colorLoadActions, UnityEngine.Rendering.RenderBufferStoreAction[] colorStoreActions, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, System.Int32 mipLevel, UnityEngine.CubemapFace cubemapFace, System.Int32 depthSlice)
END_CLASS

CLASS: UnityEngine.Rendering.CommandBufferExtensions
TYPE:  class
TOKEN: 0x2000325
FIELDS:
METHODS:
  System.Void Internal_SwitchIntoFastMemory(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier& rt, UnityEngine.Rendering.FastMemoryFlags fastMemoryFlags, System.Single residency, System.Boolean copyContents)
  System.Void Internal_SwitchOutOfFastMemory(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier& rt, System.Boolean copyContents)
  System.Void SwitchIntoFastMemory(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier rid, UnityEngine.Rendering.FastMemoryFlags fastMemoryFlags, System.Single residency, System.Boolean copyContents)
  System.Void SwitchOutOfFastMemory(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier rid, System.Boolean copyContents)
END_CLASS

CLASS: UnityEngine.Rendering.SplashScreen
TYPE:  class
TOKEN: 0x2000326
FIELDS:
METHODS:
  System.Boolean get_isFinished()
END_CLASS

CLASS: UnityEngine.Rendering.SphericalHarmonicsL2
TYPE:  struct
TOKEN: 0x2000327
FIELDS:
  private           System.Single                   shr0  // 0x10
  private           System.Single                   shr1  // 0x14
  private           System.Single                   shr2  // 0x18
  private           System.Single                   shr3  // 0x1C
  private           System.Single                   shr4  // 0x20
  private           System.Single                   shr5  // 0x24
  private           System.Single                   shr6  // 0x28
  private           System.Single                   shr7  // 0x2C
  private           System.Single                   shr8  // 0x30
  private           System.Single                   shg0  // 0x34
  private           System.Single                   shg1  // 0x38
  private           System.Single                   shg2  // 0x3C
  private           System.Single                   shg3  // 0x40
  private           System.Single                   shg4  // 0x44
  private           System.Single                   shg5  // 0x48
  private           System.Single                   shg6  // 0x4C
  private           System.Single                   shg7  // 0x50
  private           System.Single                   shg8  // 0x54
  private           System.Single                   shb0  // 0x58
  private           System.Single                   shb1  // 0x5C
  private           System.Single                   shb2  // 0x60
  private           System.Single                   shb3  // 0x64
  private           System.Single                   shb4  // 0x68
  private           System.Single                   shb5  // 0x6C
  private           System.Single                   shb6  // 0x70
  private           System.Single                   shb7  // 0x74
  private           System.Single                   shb8  // 0x78
METHODS:
  System.Single get_Item(System.Int32 rgb, System.Int32 coefficient)
  System.Void set_Item(System.Int32 rgb, System.Int32 coefficient, System.Single value)
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(UnityEngine.Rendering.SphericalHarmonicsL2 other)
  UnityEngine.Rendering.SphericalHarmonicsL2 op_Multiply(UnityEngine.Rendering.SphericalHarmonicsL2 lhs, System.Single rhs)
  UnityEngine.Rendering.SphericalHarmonicsL2 op_Addition(UnityEngine.Rendering.SphericalHarmonicsL2 lhs, UnityEngine.Rendering.SphericalHarmonicsL2 rhs)
  System.Boolean op_Equality(UnityEngine.Rendering.SphericalHarmonicsL2 lhs, UnityEngine.Rendering.SphericalHarmonicsL2 rhs)
END_CLASS

CLASS: UnityEngine.Rendering.BatchVisibility
TYPE:  struct
TOKEN: 0x2000328
FIELDS:
  public    readonly System.Int32                    offset  // 0x10
  public    readonly System.Int32                    instancesCount  // 0x14
  public            System.Int32                    visibleCount  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.BatchCullingContext
TYPE:  struct
TOKEN: 0x2000329
FIELDS:
  public    readonly Unity.Collections.NativeArray<UnityEngine.Plane>cullingPlanes  // 0x10
  public            Unity.Collections.NativeArray<UnityEngine.Rendering.BatchVisibility>batchVisibility  // 0x20
  public            Unity.Collections.NativeArray<System.Int32>visibleIndices  // 0x30
  public            Unity.Collections.NativeArray<System.Int32>visibleIndicesY  // 0x40
  public    readonly UnityEngine.Rendering.LODParameterslodParameters  // 0x50
  public    readonly UnityEngine.Matrix4x4           cullingMatrix  // 0x6C
  public    readonly System.Single                   nearPlane  // 0xAC
METHODS:
  System.Void .ctor(Unity.Collections.NativeArray<UnityEngine.Plane> inCullingPlanes, Unity.Collections.NativeArray<UnityEngine.Rendering.BatchVisibility> inOutBatchVisibility, Unity.Collections.NativeArray<System.Int32> outVisibleIndices, Unity.Collections.NativeArray<System.Int32> outVisibleIndicesY, UnityEngine.Rendering.LODParameters inLodParameters, UnityEngine.Matrix4x4 inCullingMatrix, System.Single inNearPlane)
END_CLASS

CLASS: UnityEngine.Rendering.BatchRendererCullingOutput
TYPE:  struct
TOKEN: 0x200032A
FIELDS:
  public            Unity.Jobs.JobHandle            cullingJobsFence  // 0x10
  public            UnityEngine.Matrix4x4           cullingMatrix  // 0x20
  public            UnityEngine.Plane*              cullingPlanes  // 0x60
  public            UnityEngine.Rendering.BatchVisibility*batchVisibility  // 0x68
  public            System.Int32*                   visibleIndices  // 0x70
  public            System.Int32*                   visibleIndicesY  // 0x78
  public            System.Int32                    cullingPlanesCount  // 0x80
  public            System.Int32                    batchVisibilityCount  // 0x84
  public            System.Int32                    visibleIndicesCount  // 0x88
  public            System.Single                   nearPlane  // 0x8C
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.BatchRendererGroup
TYPE:  class
TOKEN: 0x200032B
FIELDS:
  private           System.IntPtr                   m_GroupHandle  // 0x10
  private           UnityEngine.Rendering.BatchRendererGroup.OnPerformCullingm_PerformCulling  // 0x18
METHODS:
  System.Void InvokeOnPerformCulling(UnityEngine.Rendering.BatchRendererGroup group, UnityEngine.Rendering.BatchRendererCullingOutput& context, UnityEngine.Rendering.LODParameters& lodParameters)
END_CLASS

CLASS: UnityEngine.Rendering.AttachmentDescriptor
TYPE:  struct
TOKEN: 0x200032D
FIELDS:
  private           UnityEngine.Rendering.RenderBufferLoadActionm_LoadAction  // 0x10
  private           UnityEngine.Rendering.RenderBufferStoreActionm_StoreAction  // 0x14
  private           UnityEngine.Experimental.Rendering.GraphicsFormatm_Format  // 0x18
  private           UnityEngine.Rendering.RenderTargetIdentifierm_LoadStoreTarget  // 0x20
  private           UnityEngine.Rendering.RenderTargetIdentifierm_ResolveTarget  // 0x48
  private           UnityEngine.Color               m_ClearColor  // 0x70
  private           System.Single                   m_ClearDepth  // 0x80
  private           System.UInt32                   m_ClearStencil  // 0x84
METHODS:
  System.Void set_loadAction(UnityEngine.Rendering.RenderBufferLoadAction value)
  System.Void set_storeAction(UnityEngine.Rendering.RenderBufferStoreAction value)
  System.Void set_graphicsFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value)
  System.Void ConfigureTarget(UnityEngine.Rendering.RenderTargetIdentifier target, System.Boolean loadExistingContents, System.Boolean storeResults)
  System.Void ConfigureClear(UnityEngine.Color clearColor, System.Single clearDepth, System.UInt32 clearStencil)
  System.Boolean Equals(UnityEngine.Rendering.AttachmentDescriptor other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.BlendState
TYPE:  struct
TOKEN: 0x200032E
FIELDS:
  private           UnityEngine.Rendering.RenderTargetBlendStatem_BlendState0  // 0x10
  private           UnityEngine.Rendering.RenderTargetBlendStatem_BlendState1  // 0x18
  private           UnityEngine.Rendering.RenderTargetBlendStatem_BlendState2  // 0x20
  private           UnityEngine.Rendering.RenderTargetBlendStatem_BlendState3  // 0x28
  private           UnityEngine.Rendering.RenderTargetBlendStatem_BlendState4  // 0x30
  private           UnityEngine.Rendering.RenderTargetBlendStatem_BlendState5  // 0x38
  private           UnityEngine.Rendering.RenderTargetBlendStatem_BlendState6  // 0x40
  private           UnityEngine.Rendering.RenderTargetBlendStatem_BlendState7  // 0x48
  private           System.Byte                     m_SeparateMRTBlendStates  // 0x50
  private           System.Byte                     m_AlphaToMask  // 0x51
  private           System.Int16                    m_Padding  // 0x52
METHODS:
  System.Boolean Equals(UnityEngine.Rendering.BlendState other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.CoreCameraValues
TYPE:  struct
TOKEN: 0x200032F
FIELDS:
  private           System.Int32                    filterMode  // 0x10
  private           System.UInt32                   cullingMask  // 0x14
  private           System.Int32                    instanceID  // 0x18
  private           System.Int32                    uiInstanceID  // 0x1C
METHODS:
  System.Boolean Equals(UnityEngine.Rendering.CoreCameraValues other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.CameraProperties
TYPE:  struct
TOKEN: 0x2000330
FIELDS:
  private           UnityEngine.Rect                screenRect  // 0x10
  private           UnityEngine.Vector3             viewDir  // 0x20
  private           System.Single                   projectionNear  // 0x2C
  private           System.Single                   projectionFar  // 0x30
  private           System.Single                   cameraNear  // 0x34
  private           System.Single                   cameraFar  // 0x38
  private           System.Single                   cameraAspect  // 0x3C
  private           UnityEngine.Matrix4x4           cameraToWorld  // 0x40
  private           UnityEngine.Matrix4x4           actualWorldToClip  // 0x80
  private           UnityEngine.Matrix4x4           cameraClipToWorld  // 0xC0
  private           UnityEngine.Matrix4x4           cameraWorldToClip  // 0x100
  private           UnityEngine.Matrix4x4           implicitProjection  // 0x140
  private           UnityEngine.Matrix4x4           stereoWorldToClipLeft  // 0x180
  private           UnityEngine.Matrix4x4           stereoWorldToClipRight  // 0x1C0
  private           UnityEngine.Matrix4x4           worldToCamera  // 0x200
  private           UnityEngine.Vector3             up  // 0x240
  private           UnityEngine.Vector3             right  // 0x24C
  private           UnityEngine.Vector3             transformDirection  // 0x258
  private           UnityEngine.Vector3             cameraEuler  // 0x264
  private           UnityEngine.Vector3             velocity  // 0x270
  private           System.Single                   farPlaneWorldSpaceLength  // 0x27C
  private           System.UInt32                   rendererCount  // 0x280
  private           UnityEngine.Rendering.CameraProperties.<m_ShadowCullPlanes>e__FixedBufferm_ShadowCullPlanes  // 0x284
  private           UnityEngine.Rendering.CameraProperties.<m_CameraCullPlanes>e__FixedBufferm_CameraCullPlanes  // 0x2E4
  private           System.Single                   baseFarDistance  // 0x344
  private           UnityEngine.Vector3             shadowCullCenter  // 0x348
  private           UnityEngine.Rendering.CameraProperties.<layerCullDistances>e__FixedBufferlayerCullDistances  // 0x354
  private           System.Int32                    layerCullSpherical  // 0x3D4
  private           UnityEngine.Rendering.CoreCameraValuescoreCameraValues  // 0x3D8
  private           System.UInt32                   cameraType  // 0x3E8
  private           System.Int32                    projectionIsOblique  // 0x3EC
  private           System.Int32                    isImplicitProjectionMatrix  // 0x3F0
METHODS:
  UnityEngine.Plane GetShadowCullingPlane(System.Int32 index)
  UnityEngine.Plane GetCameraCullingPlane(System.Int32 index)
  System.Boolean Equals(UnityEngine.Rendering.CameraProperties other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.CullingOptions
TYPE:  struct
TOKEN: 0x2000334
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.CullingOptionsNone  // 0x0
  public    static  UnityEngine.Rendering.CullingOptionsForceEvenIfCameraIsNotActive  // 0x0
  public    static  UnityEngine.Rendering.CullingOptionsOcclusionCull  // 0x0
  public    static  UnityEngine.Rendering.CullingOptionsNeedsLighting  // 0x0
  public    static  UnityEngine.Rendering.CullingOptionsNeedsReflectionProbes  // 0x0
  public    static  UnityEngine.Rendering.CullingOptionsStereo  // 0x0
  public    static  UnityEngine.Rendering.CullingOptionsDisablePerObjectCulling  // 0x0
  public    static  UnityEngine.Rendering.CullingOptionsShadowCasters  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.ScriptableCullingParameters
TYPE:  struct
TOKEN: 0x2000335
FIELDS:
  private           System.Int32                    m_IsOrthographic  // 0x10
  private           UnityEngine.Rendering.LODParametersm_LODParameters  // 0x14
  public    static readonly System.Int32                    maximumCullingPlaneCount  // 0x0
  private           UnityEngine.Rendering.ScriptableCullingParameters.<m_CullingPlanes>e__FixedBufferm_CullingPlanes  // 0x30
  private           System.Int32                    m_CullingPlaneCount  // 0xD0
  private           System.UInt32                   m_CullingMask  // 0xD4
  private           System.UInt64                   m_SceneMask  // 0xD8
  public    static readonly System.Int32                    layerCount  // 0x4
  private           UnityEngine.Rendering.ScriptableCullingParameters.<m_LayerFarCullDistances>e__FixedBufferm_LayerFarCullDistances  // 0xE0
  private           System.Int32                    m_LayerCull  // 0x160
  private           UnityEngine.Matrix4x4           m_CullingMatrix  // 0x164
  private           UnityEngine.Vector3             m_Origin  // 0x1A4
  private           System.Single                   m_ShadowDistance  // 0x1B0
  private           System.Single                   m_ShadowNearPlaneOffset  // 0x1B4
  private           UnityEngine.Rendering.CullingOptionsm_CullingOptions  // 0x1B8
  private           UnityEngine.Rendering.ReflectionProbeSortingCriteriam_ReflectionProbeSortingCriteria  // 0x1BC
  private           UnityEngine.Rendering.CameraPropertiesm_CameraProperties  // 0x1C0
  private           System.Single                   m_AccurateOcclusionThreshold  // 0x5A4
  private           System.Int32                    m_MaximumPortalCullingJobs  // 0x5A8
  private           UnityEngine.Matrix4x4           m_StereoViewMatrix  // 0x5AC
  private           UnityEngine.Matrix4x4           m_StereoProjectionMatrix  // 0x5EC
  private           System.Single                   m_StereoSeparationDistance  // 0x62C
  private           System.Int32                    m_maximumVisibleLights  // 0x630
  private           System.Boolean                  m_ConservativeEnclosingSphere  // 0x634
  private           System.Int32                    m_NumIterationsEnclosingSphere  // 0x638
  private           System.UInt32                   m_HGCullingViewHandle  // 0x63C
  private           System.UInt32                   m_HGCullingViewUniqueID  // 0x640
  private           System.Single                   m_LightCullScreenSpaceArea  // 0x644
METHODS:
  System.Void set_maximumVisibleLights(System.Int32 value)
  System.Int32 get_cullingPlaneCount()
  System.Void set_isOrthographic(System.Boolean value)
  System.Void set_cullingMask(System.UInt32 value)
  System.Void set_cullingMatrix(UnityEngine.Matrix4x4 value)
  System.Void set_shadowDistance(System.Single value)
  UnityEngine.Rendering.CullingOptions get_cullingOptions()
  System.Void set_cullingOptions(UnityEngine.Rendering.CullingOptions value)
  System.Void set_hgCullingViewHandle(System.UInt32 value)
  System.Void set_hgCullingViewUniqueID(System.UInt32 value)
  System.Single GetLayerCullingDistance(System.Int32 layerIndex)
  UnityEngine.Plane GetCullingPlane(System.Int32 index)
  System.Void SetCullingPlane(System.Int32 index, UnityEngine.Plane plane)
  System.Boolean Equals(UnityEngine.Rendering.ScriptableCullingParameters other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Rendering.CullingResults
TYPE:  struct
TOKEN: 0x2000338
FIELDS:
  public            System.IntPtr                   ptr  // 0x10
  private           UnityEngine.Rendering.CullingAllocationInfo*m_AllocationInfo  // 0x18
METHODS:
  System.Boolean GetShadowCasterBounds(System.IntPtr cullingResultsPtr, System.Int32 lightIndex, UnityEngine.Bounds& bounds)
  System.Boolean ComputeDirectionalShadowMatricesAndCullingPrimitives(System.IntPtr cullingResultsPtr, System.Int32 activeLightIndex, System.Int32 splitIndex, System.Int32 splitCount, UnityEngine.Vector3 splitRatio, System.Int32 shadowResolution, System.Single shadowNearPlaneOffset, UnityEngine.Matrix4x4& viewMatrix, UnityEngine.Matrix4x4& projMatrix, UnityEngine.Rendering.ShadowSplitData& shadowSplitData)
  System.Boolean GetShadowCasterBounds(System.Int32 lightIndex, UnityEngine.Bounds& outBounds)
  System.Boolean ComputeDirectionalShadowMatricesAndCullingPrimitives(System.Int32 activeLightIndex, System.Int32 splitIndex, System.Int32 splitCount, UnityEngine.Vector3 splitRatio, System.Int32 shadowResolution, System.Single shadowNearPlaneOffset, UnityEngine.Matrix4x4& viewMatrix, UnityEngine.Matrix4x4& projMatrix, UnityEngine.Rendering.ShadowSplitData& shadowSplitData)
  System.Boolean Equals(UnityEngine.Rendering.CullingResults other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected(System.IntPtr cullingResultsPtr, System.Int32 activeLightIndex, System.Int32 splitIndex, System.Int32 splitCount, UnityEngine.Vector3& splitRatio, System.Int32 shadowResolution, System.Single shadowNearPlaneOffset, UnityEngine.Matrix4x4& viewMatrix, UnityEngine.Matrix4x4& projMatrix, UnityEngine.Rendering.ShadowSplitData& shadowSplitData)
END_CLASS

CLASS: UnityEngine.Rendering.CullingAllocationInfo
TYPE:  struct
TOKEN: 0x2000339
FIELDS:
  public            UnityEngine.Rendering.VisibleLight*visibleLightsPtr  // 0x10
  public            UnityEngine.Rendering.VisibleLight*visibleOffscreenVertexLightsPtr  // 0x18
  public            UnityEngine.Rendering.VisibleReflectionProbe*visibleReflectionProbesPtr  // 0x20
  public            System.Int32                    visibleLightCount  // 0x28
  public            System.Int32                    visibleOffscreenVertexLightCount  // 0x2C
  public            System.Int32                    visibleReflectionProbeCount  // 0x30
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.DepthState
TYPE:  struct
TOKEN: 0x200033A
FIELDS:
  private           System.Byte                     m_WriteEnabled  // 0x10
  private           System.SByte                    m_CompareFunction  // 0x11
METHODS:
  System.Boolean Equals(UnityEngine.Rendering.DepthState other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.DrawingSettings
TYPE:  struct
TOKEN: 0x200033B
FIELDS:
  public    static readonly System.Int32                    maxShaderPasses  // 0x0
  private           UnityEngine.Rendering.SortingSettingsm_SortingSettings  // 0x10
  private           UnityEngine.Rendering.DrawingSettings.<shaderPassNames>e__FixedBuffershaderPassNames  // 0xF4
  private           UnityEngine.Rendering.PerObjectDatam_PerObjectData  // 0x134
  private           UnityEngine.Rendering.DrawRendererFlagsm_Flags  // 0x138
  private           System.Int32                    m_OverrideMaterialInstanceId  // 0x13C
  private           System.Int32                    m_OverrideMaterialPassIndex  // 0x140
  private           System.Int32                    m_fallbackMaterialInstanceId  // 0x144
  private           System.Int32                    m_MainLightIndex  // 0x148
  private           System.Single                   m_ScreenCullingRatio  // 0x14C
  private           System.Single                   m_ScreenRatioCullingDistance  // 0x150
  private           System.UInt32                   m_ScreenCullingLayerMask  // 0x154
  private           System.Int32                    m_UseSrpBatcher  // 0x158
METHODS:
  System.Void .ctor(UnityEngine.Rendering.ShaderTagId shaderPassName, UnityEngine.Rendering.SortingSettings sortingSettings)
  System.Void set_perObjectData(UnityEngine.Rendering.PerObjectData value)
  System.Void set_overrideMaterial(UnityEngine.Material value)
  System.Void set_overrideMaterialPassIndex(System.Int32 value)
  System.Void set_screenCullingRatio(System.Single value)
  System.Void set_screenRatioCullingDistance(System.Single value)
  System.Void set_screenCullingLayerMask(System.UInt32 value)
  UnityEngine.Rendering.ShaderTagId GetShaderPassName(System.Int32 index)
  System.Void SetShaderPassName(System.Int32 index, UnityEngine.Rendering.ShaderTagId shaderPassName)
  System.Boolean Equals(UnityEngine.Rendering.DrawingSettings other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Rendering.DrawRendererFlags
TYPE:  struct
TOKEN: 0x200033D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.DrawRendererFlagsNone  // 0x0
  public    static  UnityEngine.Rendering.DrawRendererFlagsEnableDynamicBatching  // 0x0
  public    static  UnityEngine.Rendering.DrawRendererFlagsEnableInstancing  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.FilteringSettings
TYPE:  struct
TOKEN: 0x200033E
FIELDS:
  private           UnityEngine.Rendering.RenderQueueRangem_RenderQueueRange  // 0x10
  private           System.Int32                    m_LayerMask  // 0x18
  private           System.UInt32                   m_RenderingLayerMask  // 0x1C
  private           System.Int32                    m_ExcludeMotionVectorObjects  // 0x20
  private           UnityEngine.Rendering.SortingLayerRangem_SortingLayerRange  // 0x24
  private           System.Int16                    m_SortingOrderMin  // 0x28
  private           System.Int16                    m_SortingOrderMax  // 0x2A
  private           System.UInt16                   m_CharacterIndex  // 0x2C
METHODS:
  System.Void .ctor(System.Nullable<UnityEngine.Rendering.RenderQueueRange> renderQueueRange, System.Int32 layerMask, System.UInt32 renderingLayerMask, System.Int32 excludeMotionVectorObjects)
  System.Void set_excludeMotionVectorObjects(System.Boolean value)
  System.Void set_sortingLayerRange(UnityEngine.Rendering.SortingLayerRange value)
  System.Void set_sortingOrderMin(System.Int16 value)
  System.Void set_sortingOrderMax(System.Int16 value)
  System.Void set_characterIndex(System.UInt16 value)
  System.Boolean Equals(UnityEngine.Rendering.FilteringSettings other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.GizmoSubset
TYPE:  struct
TOKEN: 0x200033F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.GizmoSubsetPreImageEffects  // 0x0
  public    static  UnityEngine.Rendering.GizmoSubsetPostImageEffects  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.LODParameters
TYPE:  struct
TOKEN: 0x2000340
FIELDS:
  private           System.Int32                    m_IsOrthographic  // 0x10
  private           UnityEngine.Vector3             m_CameraPosition  // 0x14
  private           System.Single                   m_FieldOfView  // 0x20
  private           System.Single                   m_OrthoSize  // 0x24
  private           System.Int32                    m_CameraPixelHeight  // 0x28
METHODS:
  System.Boolean Equals(UnityEngine.Rendering.LODParameters other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.PerObjectData
TYPE:  struct
TOKEN: 0x2000341
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.PerObjectDataNone  // 0x0
  public    static  UnityEngine.Rendering.PerObjectDataLightProbe  // 0x0
  public    static  UnityEngine.Rendering.PerObjectDataReflectionProbes  // 0x0
  public    static  UnityEngine.Rendering.PerObjectDataLightProbeProxyVolume  // 0x0
  public    static  UnityEngine.Rendering.PerObjectDataLightmaps  // 0x0
  public    static  UnityEngine.Rendering.PerObjectDataLightData  // 0x0
  public    static  UnityEngine.Rendering.PerObjectDataMotionVectors  // 0x0
  public    static  UnityEngine.Rendering.PerObjectDataLightIndices  // 0x0
  public    static  UnityEngine.Rendering.PerObjectDataReflectionProbeData  // 0x0
  public    static  UnityEngine.Rendering.PerObjectDataOcclusionProbe  // 0x0
  public    static  UnityEngine.Rendering.PerObjectDataOcclusionProbeProxyVolume  // 0x0
  public    static  UnityEngine.Rendering.PerObjectDataShadowMask  // 0x0
  public    static  UnityEngine.Rendering.PerObjectDataCastShadow  // 0x0
  public    static  UnityEngine.Rendering.PerObjectDataStaticShadowCaster  // 0x0
  public    static  UnityEngine.Rendering.PerObjectDataDynamicShadowCaster  // 0x0
  public    static  UnityEngine.Rendering.PerObjectDataCullNonRealtimeShadowCaster  // 0x0
  public    static  UnityEngine.Rendering.PerObjectDataParticleLightingIndex  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.RasterState
TYPE:  struct
TOKEN: 0x2000342
FIELDS:
  public    static readonly UnityEngine.Rendering.RasterStatedefaultValue  // 0x0
  private           UnityEngine.Rendering.CullMode  m_CullingMode  // 0x10
  private           System.Int32                    m_OffsetUnits  // 0x14
  private           System.Single                   m_OffsetFactor  // 0x18
  private           System.Byte                     m_DepthClip  // 0x1C
  private           System.Byte                     m_Conservative  // 0x1D
  private           System.Byte                     m_Padding1  // 0x1E
  private           System.Byte                     m_Padding2  // 0x1F
METHODS:
  System.Void .ctor(UnityEngine.Rendering.CullMode cullingMode, System.Int32 offsetUnits, System.Single offsetFactor, System.Boolean depthClip)
  System.Boolean Equals(UnityEngine.Rendering.RasterState other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Rendering.ReflectionProbeSortingCriteria
TYPE:  struct
TOKEN: 0x2000343
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.ReflectionProbeSortingCriteriaNone  // 0x0
  public    static  UnityEngine.Rendering.ReflectionProbeSortingCriteriaImportance  // 0x0
  public    static  UnityEngine.Rendering.ReflectionProbeSortingCriteriaSize  // 0x0
  public    static  UnityEngine.Rendering.ReflectionProbeSortingCriteriaImportanceThenSize  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.RenderPipeline
TYPE:  class
TOKEN: 0x2000344
FIELDS:
  private           System.Boolean                  <disposed>k__BackingField  // 0x10
METHODS:
  System.Void Render(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera[] cameras)
  System.Void ProcessRenderRequests(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera, System.Collections.Generic.List<UnityEngine.Camera.RenderRequest> renderRequests)
  System.Void BeginContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras)
  System.Void BeginCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera)
  System.Void EndContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras)
  System.Void EndCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera)
  System.Void Render(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras)
  System.Void InternalRender(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras)
  System.Void InternalRenderWithRequests(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras, System.Collections.Generic.List<UnityEngine.Camera.RenderRequest> renderRequests)
  System.Boolean get_disposed()
  System.Void set_disposed(System.Boolean value)
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  UnityEngine.Rendering.RenderPipelineGlobalSettings get_defaultSettings()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.RenderPipelineAsset
TYPE:  class
TOKEN: 0x2000345
EXTENDS: ScriptableObject
FIELDS:
METHODS:
  UnityEngine.Rendering.RenderPipeline InternalCreatePipeline()
  System.String[] get_renderingLayerMaskNames()
  System.String[] get_prefixedRenderingLayerMaskNames()
  UnityEngine.Material get_defaultMaterial()
  UnityEngine.Shader get_autodeskInteractiveShader()
  UnityEngine.Shader get_autodeskInteractiveTransparentShader()
  UnityEngine.Shader get_autodeskInteractiveMaskedShader()
  UnityEngine.Shader get_terrainDetailLitShader()
  UnityEngine.Shader get_terrainDetailGrassShader()
  UnityEngine.Shader get_terrainDetailGrassBillboardShader()
  UnityEngine.Material get_defaultParticleMaterial()
  UnityEngine.Material get_defaultLineMaterial()
  UnityEngine.Material get_defaultTerrainMaterial()
  UnityEngine.Material get_defaultUIMaterial()
  UnityEngine.Material get_defaultUIOverdrawMaterial()
  UnityEngine.Material get_defaultUIETC1SupportedMaterial()
  UnityEngine.Material get_default2DMaterial()
  UnityEngine.Material get_default2DMaskMaterial()
  UnityEngine.Shader get_defaultShader()
  UnityEngine.Shader get_defaultSpeedTree7Shader()
  UnityEngine.Shader get_defaultSpeedTree8Shader()
  UnityEngine.Mesh get_defaultQuadMesh()
  UnityEngine.Mesh get_defaultPlaneMesh()
  UnityEngine.Mesh get_defaultCylinderMesh()
  UnityEngine.Mesh get_defaultCapsuleMesh()
  UnityEngine.Mesh get_defaultSphereMesh()
  UnityEngine.Mesh get_defaultCubeMesh()
  UnityEngine.Rendering.RenderPipeline CreatePipeline()
  System.Void OnValidate()
  System.Void OnDisable()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.RenderPipelineGlobalSettings
TYPE:  class
TOKEN: 0x2000346
EXTENDS: ScriptableObject
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Rendering.RenderPipelineManager
TYPE:  class
TOKEN: 0x2000347
FIELDS:
  private   static  UnityEngine.Rendering.RenderPipelineAssets_CurrentPipelineAsset  // 0x0
  private   static  System.Collections.Generic.List<UnityEngine.Camera>s_Cameras  // 0x8
  private   static  System.String                   s_currentPipelineType  // 0x10
  private   static  UnityEngine.Rendering.RenderPipelines_currentPipeline  // 0x18
  private   static  System.Action<UnityEngine.Rendering.ScriptableRenderContext,System.Collections.Generic.List<UnityEngine.Camera>>beginContextRendering  // 0x20
  private   static  System.Action<UnityEngine.Rendering.ScriptableRenderContext,System.Collections.Generic.List<UnityEngine.Camera>>endContextRendering  // 0x28
  private   static  System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Camera[]>beginFrameRendering  // 0x30
  private   static  System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Camera>beginCameraRendering  // 0x38
  private   static  System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Camera[]>endFrameRendering  // 0x40
  private   static  System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Camera>endCameraRendering  // 0x48
  private   static  System.Action<UnityEngine.Rendering.ScriptableRenderContext,System.Collections.Generic.List<UnityEngine.Camera>>beginFrameRenderingNoAlloc  // 0x50
  private   static  System.Action<UnityEngine.Rendering.ScriptableRenderContext,System.Collections.Generic.List<UnityEngine.Camera>>endFrameRenderingNoAlloc  // 0x58
  private   static  System.Action                   activeRenderPipelineTypeChanged  // 0x60
  private   static  System.Action                   activeRenderPipelineCreated  // 0x68
  private   static  System.Action                   activeRenderPipelineDisposed  // 0x70
METHODS:
  UnityEngine.Rendering.RenderPipeline get_currentPipeline()
  System.Void set_currentPipeline(UnityEngine.Rendering.RenderPipeline value)
  System.Void add_beginCameraRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Camera> value)
  System.Void remove_beginCameraRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Camera> value)
  System.Void add_endCameraRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Camera> value)
  System.Void remove_endCameraRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Camera> value)
  System.Void add_beginFrameRenderingNoAlloc(System.Action<UnityEngine.Rendering.ScriptableRenderContext,System.Collections.Generic.List<UnityEngine.Camera>> value)
  System.Void remove_beginFrameRenderingNoAlloc(System.Action<UnityEngine.Rendering.ScriptableRenderContext,System.Collections.Generic.List<UnityEngine.Camera>> value)
  System.Void BeginContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras)
  System.Void BeginCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera)
  System.Void EndContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras)
  System.Void EndCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera)
  System.Void OnActiveRenderPipelineTypeChanged()
  System.Void HandleRenderPipelineChange(UnityEngine.Rendering.RenderPipelineAsset pipelineAsset)
  System.Void CleanupRenderPipeline()
  System.String GetCurrentPipelineAssetType()
  System.Void DoRenderLoop_Internal(UnityEngine.Rendering.RenderPipelineAsset pipe, System.IntPtr loopPtr, System.Collections.Generic.List<UnityEngine.Camera.RenderRequest> renderRequests)
  System.Void PrepareRenderPipeline(UnityEngine.Rendering.RenderPipelineAsset pipelineAsset)
  System.Boolean IsPipelineRequireCreation()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Rendering.RenderQueueRange
TYPE:  struct
TOKEN: 0x2000348
FIELDS:
  private           System.Int32                    m_LowerBound  // 0x10
  private           System.Int32                    m_UpperBound  // 0x14
  public    static readonly System.Int32                    minimumBound  // 0x0
  public    static readonly System.Int32                    maximumBound  // 0x4
METHODS:
  UnityEngine.Rendering.RenderQueueRange get_all()
  System.Int32 get_lowerBound()
  System.Void set_lowerBound(System.Int32 value)
  System.Int32 get_upperBound()
  System.Void set_upperBound(System.Int32 value)
  System.Boolean Equals(UnityEngine.Rendering.RenderQueueRange other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Rendering.RenderStateBlock
TYPE:  struct
TOKEN: 0x2000349
FIELDS:
  private           UnityEngine.Rendering.BlendStatem_BlendState  // 0x10
  private           UnityEngine.Rendering.RasterStatem_RasterState  // 0x54
  private           UnityEngine.Rendering.DepthStatem_DepthState  // 0x64
  private           UnityEngine.Rendering.StencilStatem_StencilState  // 0x66
  private           System.Int32                    m_StencilReference  // 0x74
  private           UnityEngine.Rendering.RenderStateMaskm_Mask  // 0x78
METHODS:
  System.Boolean Equals(UnityEngine.Rendering.RenderStateBlock other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.RenderStateMask
TYPE:  struct
TOKEN: 0x200034A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.RenderStateMaskNothing  // 0x0
  public    static  UnityEngine.Rendering.RenderStateMaskBlend  // 0x0
  public    static  UnityEngine.Rendering.RenderStateMaskRaster  // 0x0
  public    static  UnityEngine.Rendering.RenderStateMaskDepth  // 0x0
  public    static  UnityEngine.Rendering.RenderStateMaskStencil  // 0x0
  public    static  UnityEngine.Rendering.RenderStateMaskEverything  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.RenderTargetBlendState
TYPE:  struct
TOKEN: 0x200034B
FIELDS:
  private           System.Byte                     m_WriteMask  // 0x10
  private           System.Byte                     m_SourceColorBlendMode  // 0x11
  private           System.Byte                     m_DestinationColorBlendMode  // 0x12
  private           System.Byte                     m_SourceAlphaBlendMode  // 0x13
  private           System.Byte                     m_DestinationAlphaBlendMode  // 0x14
  private           System.Byte                     m_ColorBlendOperation  // 0x15
  private           System.Byte                     m_AlphaBlendOperation  // 0x16
  private           System.Byte                     m_Padding  // 0x17
METHODS:
  System.Boolean Equals(UnityEngine.Rendering.RenderTargetBlendState other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.CBHandle
TYPE:  struct
TOKEN: 0x200034C
FIELDS:
  public            System.UInt32                   bufferId  // 0x10
  public            System.UInt32                   offset  // 0x14
  public            System.UInt32                   size  // 0x18
  public            System.IntPtr                   ptr  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.ScriptableRenderContext
TYPE:  struct
TOKEN: 0x200034D
FIELDS:
  private   static readonly UnityEngine.Rendering.ShaderTagIdkRenderTypeTag  // 0x0
  private           System.IntPtr                   m_Ptr  // 0x10
METHODS:
  System.Void BeginRenderPass_Internal(System.IntPtr self, System.Int32 width, System.Int32 height, System.Int32 samples, System.IntPtr colors, System.Int32 colorCount, System.Int32 depthAttachmentIndex)
  System.Void BeginSubPass_Internal(System.IntPtr self, System.IntPtr colors, System.Int32 colorCount, System.IntPtr inputs, System.Int32 inputCount, System.Boolean isDepthReadOnly, System.Boolean isStencilReadOnly)
  System.Void EndSubPass_Internal(System.IntPtr self)
  System.Void EndRenderPass_Internal(System.IntPtr self)
  System.Void Internal_Cull(UnityEngine.Rendering.ScriptableCullingParameters& parameters, UnityEngine.Rendering.ScriptableRenderContext renderLoop, System.IntPtr results)
  System.Void InitializeSortSettings(UnityEngine.Camera camera, UnityEngine.Rendering.SortingSettings& sortingSettings)
  System.Void Submit_Internal()
  System.Void GetCameras_Internal(System.Type listType, System.Object resultList)
  System.Void DrawRenderers_Internal(System.IntPtr cullResults, UnityEngine.Rendering.DrawingSettings& drawingSettings, UnityEngine.Rendering.FilteringSettings& filteringSettings, UnityEngine.Rendering.ShaderTagId tagName, System.Boolean isPassTagName, System.IntPtr tagValues, System.IntPtr stateBlocks, System.Int32 stateCount)
  System.Void DrawShadows_Internal(System.IntPtr shadowDrawingSettings)
  System.Void EmitGeometryForCamera(UnityEngine.Camera camera)
  UnityEngine.Rendering.CBHandle AllocateConstantBuffer(System.Int32 size)
  System.Void ExecuteCommandBuffer_Internal(UnityEngine.Rendering.CommandBuffer commandBuffer)
  System.Void ExecuteCommandBufferAsync_Internal(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Rendering.ComputeQueueType queueType)
  System.Void ExecuteCommandBufferNoCopy_Internal(UnityEngine.Rendering.CommandBuffer commandBuffer)
  System.Void ExecuteCommandBufferAsyncNoCopy_Internal(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Rendering.ComputeQueueType queueType)
  System.Void SetupCameraProperties_Internal(UnityEngine.Camera camera, System.Boolean stereoSetup, System.Int32 eye)
  System.Void DrawGizmos_Internal(UnityEngine.Camera camera, UnityEngine.Rendering.GizmoSubset gizmoSubset)
  UnityEngine.Rendering.RendererUtils.RendererList CreateRendererList_Internal(System.IntPtr cullResults, UnityEngine.Rendering.DrawingSettings& drawingSettings, UnityEngine.Rendering.FilteringSettings& filteringSettings, UnityEngine.Rendering.ShaderTagId tagName, System.Boolean isPassTagName, System.IntPtr tagValues, System.IntPtr stateBlocks, System.Int32 stateCount, System.IntPtr drawableFeedbackPtr)
  System.Void PrepareRendererListsAsync_Internal(System.Object rendererLists)
  UnityEngine.Rendering.RendererUtils.RendererListStatus QueryRendererListStatus_Internal(UnityEngine.Rendering.RendererUtils.RendererList handle)
  System.Int32 QueryRendererListObjCount_Internal(UnityEngine.Rendering.RendererUtils.RendererList handle)
  System.Void .ctor(System.IntPtr ptr)
  System.Void BeginRenderPass(System.Int32 width, System.Int32 height, System.Int32 samples, Unity.Collections.NativeArray<UnityEngine.Rendering.AttachmentDescriptor> attachments, System.Int32 depthAttachmentIndex)
  System.Void BeginSubPass(Unity.Collections.NativeArray<System.Int32> colors, Unity.Collections.NativeArray<System.Int32> inputs, System.Boolean isDepthStencilReadOnly)
  System.Void BeginSubPass(Unity.Collections.NativeArray<System.Int32> colors, System.Boolean isDepthStencilReadOnly)
  System.Void EndSubPass()
  System.Void EndRenderPass()
  System.Void Submit()
  System.Void GetCameras(System.Collections.Generic.List<UnityEngine.Camera> results)
  System.Void DrawRenderers(UnityEngine.Rendering.CullingResults cullingResults, UnityEngine.Rendering.DrawingSettings& drawingSettings, UnityEngine.Rendering.FilteringSettings& filteringSettings)
  System.Void DrawRenderers(UnityEngine.Rendering.CullingResults cullingResults, UnityEngine.Rendering.DrawingSettings& drawingSettings, UnityEngine.Rendering.FilteringSettings& filteringSettings, UnityEngine.Rendering.RenderStateBlock& stateBlock)
  System.Void DrawShadows(UnityEngine.Rendering.ShadowDrawingSettings& settings)
  System.Void ExecuteCommandBuffer(UnityEngine.Rendering.CommandBuffer commandBuffer)
  System.Void ExecuteCommandBufferAsync(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Rendering.ComputeQueueType queueType)
  System.Void ExecuteCommandBufferNoCopy(UnityEngine.Rendering.CommandBuffer commandBuffer)
  System.Void ExecuteCommandBufferAsyncNoCopy(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Rendering.ComputeQueueType queueType)
  System.Void SetupCameraProperties(UnityEngine.Camera camera, System.Boolean stereoSetup)
  System.Void SetupCameraProperties(UnityEngine.Camera camera, System.Boolean stereoSetup, System.Int32 eye)
  System.Void DrawGizmos(UnityEngine.Camera camera, UnityEngine.Rendering.GizmoSubset gizmoSubset)
  UnityEngine.Rendering.CullingResults Cull(UnityEngine.Rendering.ScriptableCullingParameters& parameters)
  System.Boolean Equals(UnityEngine.Rendering.ScriptableRenderContext other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  UnityEngine.Rendering.RendererUtils.RendererList CreateRendererList(UnityEngine.Rendering.RendererUtils.RendererListDesc desc)
  System.Void PrepareRendererListsAsync(System.Collections.Generic.List<UnityEngine.Rendering.RendererUtils.RendererList> rendererLists)
  UnityEngine.Rendering.RendererUtils.RendererListStatus QueryRendererListStatus(UnityEngine.Rendering.RendererUtils.RendererList rendererList)
  System.Int32 QueryRendererListObjCount(UnityEngine.Rendering.RendererUtils.RendererList rendererList)
  System.IntPtr GetNativePtr()
  System.Void .cctor()
  System.Void Internal_Cull_Injected(UnityEngine.Rendering.ScriptableCullingParameters& parameters, UnityEngine.Rendering.ScriptableRenderContext& renderLoop, System.IntPtr results)
  System.Void Submit_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext& _unity_self)
  System.Void GetCameras_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext& _unity_self, System.Type listType, System.Object resultList)
  System.Void DrawRenderers_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext& _unity_self, System.IntPtr cullResults, UnityEngine.Rendering.DrawingSettings& drawingSettings, UnityEngine.Rendering.FilteringSettings& filteringSettings, UnityEngine.Rendering.ShaderTagId& tagName, System.Boolean isPassTagName, System.IntPtr tagValues, System.IntPtr stateBlocks, System.Int32 stateCount)
  System.Void DrawShadows_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext& _unity_self, System.IntPtr shadowDrawingSettings)
  System.Void AllocateConstantBuffer_Injected(UnityEngine.Rendering.ScriptableRenderContext& _unity_self, System.Int32 size, UnityEngine.Rendering.CBHandle& ret)
  System.Void ExecuteCommandBuffer_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext& _unity_self, UnityEngine.Rendering.CommandBuffer commandBuffer)
  System.Void ExecuteCommandBufferAsync_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext& _unity_self, UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Rendering.ComputeQueueType queueType)
  System.Void ExecuteCommandBufferNoCopy_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext& _unity_self, UnityEngine.Rendering.CommandBuffer commandBuffer)
  System.Void ExecuteCommandBufferAsyncNoCopy_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext& _unity_self, UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Rendering.ComputeQueueType queueType)
  System.Void SetupCameraProperties_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext& _unity_self, UnityEngine.Camera camera, System.Boolean stereoSetup, System.Int32 eye)
  System.Void DrawGizmos_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext& _unity_self, UnityEngine.Camera camera, UnityEngine.Rendering.GizmoSubset gizmoSubset)
  System.Void CreateRendererList_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext& _unity_self, System.IntPtr cullResults, UnityEngine.Rendering.DrawingSettings& drawingSettings, UnityEngine.Rendering.FilteringSettings& filteringSettings, UnityEngine.Rendering.ShaderTagId& tagName, System.Boolean isPassTagName, System.IntPtr tagValues, System.IntPtr stateBlocks, System.Int32 stateCount, System.IntPtr drawableFeedbackPtr, UnityEngine.Rendering.RendererUtils.RendererList& ret)
  System.Void PrepareRendererListsAsync_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext& _unity_self, System.Object rendererLists)
  UnityEngine.Rendering.RendererUtils.RendererListStatus QueryRendererListStatus_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext& _unity_self, UnityEngine.Rendering.RendererUtils.RendererList& handle)
  System.Int32 QueryRendererListObjCount_Internal_Injected(UnityEngine.Rendering.ScriptableRenderContext& _unity_self, UnityEngine.Rendering.RendererUtils.RendererList& handle)
END_CLASS

CLASS: UnityEngine.Rendering.ShaderTagId
TYPE:  struct
TOKEN: 0x200034E
FIELDS:
  public    static readonly UnityEngine.Rendering.ShaderTagIdnone  // 0x0
  private           System.Int32                    m_Id  // 0x10
METHODS:
  System.Void .ctor(System.String name)
  System.Int32 get_id()
  System.Void set_id(System.Int32 value)
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(UnityEngine.Rendering.ShaderTagId other)
  System.Int32 GetHashCode()
  System.Boolean op_Equality(UnityEngine.Rendering.ShaderTagId tag1, UnityEngine.Rendering.ShaderTagId tag2)
  System.Boolean op_Inequality(UnityEngine.Rendering.ShaderTagId tag1, UnityEngine.Rendering.ShaderTagId tag2)
END_CLASS

CLASS: UnityEngine.Rendering.ShadowDrawingSettings
TYPE:  struct
TOKEN: 0x200034F
FIELDS:
  private           UnityEngine.Rendering.CullingResultsm_CullingResults  // 0x10
  private           System.Int32                    m_LightIndex  // 0x20
  private           System.Int32                    m_UseRenderingLayerMaskTest  // 0x24
  private           UnityEngine.Rendering.ShadowSplitDatam_SplitData  // 0x28
  private           UnityEngine.ShadowObjectsFilter m_ObjectsFilter  // 0xE4
  private           System.Boolean                  m_CullNonRealtimeCasters  // 0xE8
METHODS:
  System.Void set_useRenderingLayerMaskTest(System.Boolean value)
  System.Void set_splitData(UnityEngine.Rendering.ShadowSplitData value)
  System.Void set_objectsFilter(UnityEngine.ShadowObjectsFilter value)
  System.Void set_cullNonRealtimeCasters(System.Boolean value)
  System.Void .ctor(UnityEngine.Rendering.CullingResults cullingResults, System.Int32 lightIndex)
  System.Boolean Equals(UnityEngine.Rendering.ShadowDrawingSettings other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.ShadowSplitData
TYPE:  struct
TOKEN: 0x2000350
FIELDS:
  private   static  System.Int32                    k_MaximumCullingPlaneCount  // 0x0
  public    static readonly System.Int32                    maximumCullingPlaneCount  // 0x0
  private           System.Int32                    m_CullingPlaneCount  // 0x10
  public            UnityEngine.Rendering.ShadowSplitData.<m_CullingPlanes>e__FixedBufferm_CullingPlanes  // 0x14
  private           UnityEngine.Vector4             m_CullingSphere  // 0xB4
  private           System.Single                   m_ShadowCascadeBlendCullingFactor  // 0xC4
  private           System.Single                   m_CullingNearPlane  // 0xC8
METHODS:
  System.Int32 get_cullingPlaneCount()
  System.Void set_cullingPlaneCount(System.Int32 value)
  UnityEngine.Vector4 get_cullingSphere()
  System.Void set_shadowCascadeBlendCullingFactor(System.Single value)
  UnityEngine.Plane GetCullingPlane(System.Int32 index)
  System.Boolean Equals(UnityEngine.Rendering.ShadowSplitData other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Rendering.SortingCriteria
TYPE:  struct
TOKEN: 0x2000352
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.SortingCriteriaNone  // 0x0
  public    static  UnityEngine.Rendering.SortingCriteriaSortingLayer  // 0x0
  public    static  UnityEngine.Rendering.SortingCriteriaRenderQueue  // 0x0
  public    static  UnityEngine.Rendering.SortingCriteriaBackToFront  // 0x0
  public    static  UnityEngine.Rendering.SortingCriteriaQuantizedFrontToBack  // 0x0
  public    static  UnityEngine.Rendering.SortingCriteriaOptimizeStateChanges  // 0x0
  public    static  UnityEngine.Rendering.SortingCriteriaCanvasOrder  // 0x0
  public    static  UnityEngine.Rendering.SortingCriteriaRendererPriority  // 0x0
  public    static  UnityEngine.Rendering.SortingCriteriaCommonOpaque  // 0x0
  public    static  UnityEngine.Rendering.SortingCriteriaCommonTransparent  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.SortingLayerRange
TYPE:  struct
TOKEN: 0x2000353
FIELDS:
  private           System.Int16                    m_LowerBound  // 0x10
  private           System.Int16                    m_UpperBound  // 0x12
METHODS:
  System.Void .ctor(System.Int16 lowerBound, System.Int16 upperBound)
  UnityEngine.Rendering.SortingLayerRange get_all()
  System.Boolean Equals(UnityEngine.Rendering.SortingLayerRange other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.DistanceMetric
TYPE:  struct
TOKEN: 0x2000354
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.DistanceMetricPerspective  // 0x0
  public    static  UnityEngine.Rendering.DistanceMetricOrthographic  // 0x0
  public    static  UnityEngine.Rendering.DistanceMetricCustomAxis  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.SortingSettings
TYPE:  struct
TOKEN: 0x2000355
FIELDS:
  private           UnityEngine.Matrix4x4           m_WorldToCameraMatrix  // 0x10
  private           UnityEngine.Vector3             m_CameraPosition  // 0x50
  private           UnityEngine.Vector3             m_CustomAxis  // 0x5C
  private           UnityEngine.Rendering.SortingCriteriam_Criteria  // 0x68
  private           UnityEngine.Rendering.DistanceMetricm_DistanceMetric  // 0x6C
  private           UnityEngine.Matrix4x4           m_PreviousVPMatrix  // 0x70
  private           UnityEngine.Matrix4x4           m_NonJitteredVPMatrix  // 0xB0
  private           System.Single                   m_FOV  // 0xF0
METHODS:
  System.Void .ctor(UnityEngine.Camera camera)
  UnityEngine.Rendering.SortingCriteria get_criteria()
  System.Void set_criteria(UnityEngine.Rendering.SortingCriteria value)
  System.Boolean Equals(UnityEngine.Rendering.SortingSettings other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.StencilState
TYPE:  struct
TOKEN: 0x2000356
FIELDS:
  private           System.Byte                     m_Enabled  // 0x10
  private           System.Byte                     m_ReadMask  // 0x11
  private           System.Byte                     m_WriteMask  // 0x12
  private           System.Byte                     m_Padding  // 0x13
  private           System.Byte                     m_CompareFunctionFront  // 0x14
  private           System.Byte                     m_PassOperationFront  // 0x15
  private           System.Byte                     m_FailOperationFront  // 0x16
  private           System.Byte                     m_ZFailOperationFront  // 0x17
  private           System.Byte                     m_CompareFunctionBack  // 0x18
  private           System.Byte                     m_PassOperationBack  // 0x19
  private           System.Byte                     m_FailOperationBack  // 0x1A
  private           System.Byte                     m_ZFailOperationBack  // 0x1B
METHODS:
  System.Void set_enabled(System.Boolean value)
  System.Void set_readMask(System.Byte value)
  System.Void set_writeMask(System.Byte value)
  System.Void set_compareFunctionFront(UnityEngine.Rendering.CompareFunction value)
  System.Void set_passOperationFront(UnityEngine.Rendering.StencilOp value)
  System.Void set_failOperationFront(UnityEngine.Rendering.StencilOp value)
  System.Void set_zFailOperationFront(UnityEngine.Rendering.StencilOp value)
  System.Void set_compareFunctionBack(UnityEngine.Rendering.CompareFunction value)
  System.Void set_passOperationBack(UnityEngine.Rendering.StencilOp value)
  System.Void set_failOperationBack(UnityEngine.Rendering.StencilOp value)
  System.Void set_zFailOperationBack(UnityEngine.Rendering.StencilOp value)
  System.Boolean Equals(UnityEngine.Rendering.StencilState other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.SupportedRenderingFeatures
TYPE:  class
TOKEN: 0x2000357
FIELDS:
  private   static  UnityEngine.Rendering.SupportedRenderingFeaturess_Active  // 0x0
  private           UnityEngine.Rendering.SupportedRenderingFeatures.ReflectionProbeModes<reflectionProbeModes>k__BackingField  // 0x10
  private           UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes<defaultMixedLightingModes>k__BackingField  // 0x14
  private           UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes<mixedLightingModes>k__BackingField  // 0x18
  private           UnityEngine.LightmapBakeType    <lightmapBakeTypes>k__BackingField  // 0x1C
  private           UnityEngine.LightmapsMode       <lightmapsModes>k__BackingField  // 0x20
  private           System.Boolean                  <enlightenLightmapper>k__BackingField  // 0x24
  private           System.Boolean                  <enlighten>k__BackingField  // 0x25
  private           System.Boolean                  <lightProbeProxyVolumes>k__BackingField  // 0x26
  private           System.Boolean                  <motionVectors>k__BackingField  // 0x27
  private           System.Boolean                  <receiveShadows>k__BackingField  // 0x28
  private           System.Boolean                  <reflectionProbes>k__BackingField  // 0x29
  private           System.Boolean                  <reflectionProbesBlendDistance>k__BackingField  // 0x2A
  private           System.Boolean                  <rendererPriority>k__BackingField  // 0x2B
  private           System.Boolean                  <rendersUIOverlay>k__BackingField  // 0x2C
  private           System.Boolean                  <overridesEnvironmentLighting>k__BackingField  // 0x2D
  private           System.Boolean                  <overridesFog>k__BackingField  // 0x2E
  private           System.Boolean                  <overridesRealtimeReflectionProbes>k__BackingField  // 0x2F
  private           System.Boolean                  <overridesOtherLightingSettings>k__BackingField  // 0x30
  private           System.Boolean                  <editableMaterialRenderQueue>k__BackingField  // 0x31
  private           System.Boolean                  <overridesLODBias>k__BackingField  // 0x32
  private           System.Boolean                  <overridesMaximumLODLevel>k__BackingField  // 0x33
  private           System.Boolean                  <rendererProbes>k__BackingField  // 0x34
  private           System.Boolean                  <particleSystemInstancing>k__BackingField  // 0x35
  private           System.Boolean                  <autoAmbientProbeBaking>k__BackingField  // 0x36
  private           System.Boolean                  <autoDefaultReflectionProbeBaking>k__BackingField  // 0x37
  private           System.Boolean                  <overridesShadowmask>k__BackingField  // 0x38
  private           System.String                   <overrideShadowmaskMessage>k__BackingField  // 0x40
METHODS:
  UnityEngine.Rendering.SupportedRenderingFeatures get_active()
  System.Void set_active(UnityEngine.Rendering.SupportedRenderingFeatures value)
  System.Void set_reflectionProbeModes(UnityEngine.Rendering.SupportedRenderingFeatures.ReflectionProbeModes value)
  UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes get_defaultMixedLightingModes()
  System.Void set_defaultMixedLightingModes(UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes value)
  UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes get_mixedLightingModes()
  System.Void set_mixedLightingModes(UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes value)
  UnityEngine.LightmapBakeType get_lightmapBakeTypes()
  System.Void set_lightmapBakeTypes(UnityEngine.LightmapBakeType value)
  UnityEngine.LightmapsMode get_lightmapsModes()
  System.Void set_lightmapsModes(UnityEngine.LightmapsMode value)
  System.Boolean get_enlightenLightmapper()
  System.Void set_enlightenLightmapper(System.Boolean value)
  System.Boolean get_enlighten()
  System.Void set_enlighten(System.Boolean value)
  System.Void set_lightProbeProxyVolumes(System.Boolean value)
  System.Void set_motionVectors(System.Boolean value)
  System.Void set_receiveShadows(System.Boolean value)
  System.Void set_reflectionProbes(System.Boolean value)
  System.Void set_rendererPriority(System.Boolean value)
  System.Boolean get_rendersUIOverlay()
  System.Void set_rendersUIOverlay(System.Boolean value)
  System.Void set_overridesFog(System.Boolean value)
  System.Void set_overridesRealtimeReflectionProbes(System.Boolean value)
  System.Void set_overridesOtherLightingSettings(System.Boolean value)
  System.Void set_editableMaterialRenderQueue(System.Boolean value)
  System.Void set_overridesLODBias(System.Boolean value)
  System.Void set_overridesMaximumLODLevel(System.Boolean value)
  System.Boolean get_autoAmbientProbeBaking()
  System.Void set_autoAmbientProbeBaking(System.Boolean value)
  System.Boolean get_autoDefaultReflectionProbeBaking()
  System.Void set_autoDefaultReflectionProbeBaking(System.Boolean value)
  System.Void set_overridesShadowmask(System.Boolean value)
  System.Void set_overrideShadowmaskMessage(System.String value)
  System.Void FallbackMixedLightingModeByRef(System.IntPtr fallbackModePtr)
  System.Boolean IsMixedLightingModeSupported(UnityEngine.MixedLightingMode mixedMode)
  System.Void IsMixedLightingModeSupportedByRef(UnityEngine.MixedLightingMode mixedMode, System.IntPtr isSupportedPtr)
  System.Boolean IsLightmapBakeTypeSupported(UnityEngine.LightmapBakeType bakeType)
  System.Void IsLightmapBakeTypeSupportedByRef(UnityEngine.LightmapBakeType bakeType, System.IntPtr isSupportedPtr)
  System.Void IsLightmapsModeSupportedByRef(UnityEngine.LightmapsMode mode, System.IntPtr isSupportedPtr)
  System.Void IsLightmapperSupportedByRef(System.Int32 lightmapper, System.IntPtr isSupportedPtr)
  System.Void IsUIOverlayRenderedBySRP(System.IntPtr isSupportedPtr)
  System.Void IsAutoAmbientProbeBakingSupported(System.IntPtr isSupportedPtr)
  System.Void IsAutoDefaultReflectionProbeBakingSupported(System.IntPtr isSupportedPtr)
  System.Void FallbackLightmapperByRef(System.IntPtr lightmapperPtr)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Rendering.VisibleLight
TYPE:  struct
TOKEN: 0x200035A
FIELDS:
  private           UnityEngine.LightType           m_LightType  // 0x10
  private           UnityEngine.Color               m_FinalColor  // 0x14
  private           UnityEngine.Rect                m_ScreenRect  // 0x24
  private           UnityEngine.Matrix4x4           m_LocalToWorldMatrix  // 0x34
  private           System.Single                   m_SpecularIntensity  // 0x74
  private           System.Single                   m_Range  // 0x78
  private           System.Single                   m_SpotAngle  // 0x7C
  private           System.Int32                    m_LightPriority  // 0x80
  private           UnityEngine.Vector3             m_WorldPosition  // 0x84
  private           System.Int32                    m_InstanceId  // 0x90
  private           UnityEngine.Rendering.VisibleLightFlagsm_Flags  // 0x94
  public            UnityEngine.HGSharedLightData   hgSharedLightData  // 0x98
  private           System.Single                   m_ScreenSpaceArea  // 0xA0
METHODS:
  UnityEngine.Light get_light()
  UnityEngine.LightType get_lightType()
  UnityEngine.Color get_finalColor()
  UnityEngine.Matrix4x4 get_localToWorldMatrix()
  System.Single get_range()
  System.Single get_spotAngle()
  System.Int32 get_lightPriority()
  UnityEngine.Vector3 get_worldPosition()
  System.Boolean Equals(UnityEngine.Rendering.VisibleLight other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.VisibleLightFlags
TYPE:  struct
TOKEN: 0x200035B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.VisibleLightFlagsIntersectsNearPlane  // 0x0
  public    static  UnityEngine.Rendering.VisibleLightFlagsIntersectsFarPlane  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.VisibleReflectionProbe
TYPE:  struct
TOKEN: 0x200035C
FIELDS:
  private           UnityEngine.Bounds              m_Bounds  // 0x10
  private           UnityEngine.Matrix4x4           m_LocalToWorldMatrix  // 0x28
  private           UnityEngine.Vector4             m_HdrData  // 0x68
  private           UnityEngine.Vector3             m_Center  // 0x78
  private           System.Single                   m_BlendDistance  // 0x84
  private           System.Int32                    m_Importance  // 0x88
  private           System.Int32                    m_BoxProjection  // 0x8C
  private           System.Int32                    m_InstanceId  // 0x90
  private           System.Int32                    m_TextureId  // 0x94
METHODS:
  System.Boolean Equals(UnityEngine.Rendering.VisibleReflectionProbe other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.GlobalKeyword
TYPE:  struct
TOKEN: 0x200035D
FIELDS:
  private   readonly System.String                   m_Name  // 0x10
  private   readonly System.UInt32                   m_Index  // 0x18
METHODS:
  System.UInt32 GetGlobalKeywordCount()
  System.UInt32 GetGlobalKeywordIndex(System.String keyword)
  System.Void CreateGlobalKeyword(System.String keyword)
  System.String get_name()
  UnityEngine.Rendering.GlobalKeyword Create(System.String name)
  System.Void .ctor(System.String name)
  System.String ToString()
END_CLASS

CLASS: UnityEngine.Rendering.LocalKeyword
TYPE:  struct
TOKEN: 0x200035E
FIELDS:
  private   readonly UnityEngine.Rendering.LocalKeywordSpacem_SpaceInfo  // 0x10
  private   readonly System.String                   m_Name  // 0x18
  private   readonly System.UInt32                   m_Index  // 0x20
METHODS:
  System.UInt32 GetShaderKeywordCount(UnityEngine.Shader shader)
  System.UInt32 GetShaderKeywordIndex(UnityEngine.Shader shader, System.String keyword)
  System.UInt32 GetComputeShaderKeywordCount(UnityEngine.ComputeShader shader)
  System.UInt32 GetComputeShaderKeywordIndex(UnityEngine.ComputeShader shader, System.String keyword)
  System.Void .ctor(UnityEngine.Shader shader, System.String name)
  System.Void .ctor(UnityEngine.ComputeShader shader, System.String name)
  System.String ToString()
  System.Boolean Equals(System.Object o)
  System.Boolean Equals(UnityEngine.Rendering.LocalKeyword rhs)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.LocalKeywordSpace
TYPE:  struct
TOKEN: 0x200035F
FIELDS:
  private   readonly System.IntPtr                   m_KeywordSpace  // 0x10
METHODS:
  System.Boolean Equals(System.Object o)
  System.Boolean Equals(UnityEngine.Rendering.LocalKeywordSpace rhs)
  System.Boolean op_Equality(UnityEngine.Rendering.LocalKeywordSpace lhs, UnityEngine.Rendering.LocalKeywordSpace rhs)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.Rendering.ShaderKeyword
TYPE:  struct
TOKEN: 0x2000360
FIELDS:
  private           System.String                   m_Name  // 0x10
  private           System.UInt32                   m_Index  // 0x18
  private           System.Boolean                  m_IsLocal  // 0x1C
  private           System.Boolean                  m_IsCompute  // 0x1D
  private           System.Boolean                  m_IsValid  // 0x1E
METHODS:
  System.UInt32 GetGlobalKeywordCount()
  System.UInt32 GetGlobalKeywordIndex(System.String keyword)
  System.Void CreateGlobalKeyword(System.String keyword)
  System.Void .ctor(System.String keywordName)
  System.String ToString()
END_CLASS

CLASS: UnityEngine.Rendering.ShaderPropertyType
TYPE:  struct
TOKEN: 0x2000361
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.ShaderPropertyTypeColor  // 0x0
  public    static  UnityEngine.Rendering.ShaderPropertyTypeVector  // 0x0
  public    static  UnityEngine.Rendering.ShaderPropertyTypeFloat  // 0x0
  public    static  UnityEngine.Rendering.ShaderPropertyTypeRange  // 0x0
  public    static  UnityEngine.Rendering.ShaderPropertyTypeTexture  // 0x0
  public    static  UnityEngine.Rendering.ShaderPropertyTypeInt  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.ShaderPropertyFlags
TYPE:  struct
TOKEN: 0x2000362
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.ShaderPropertyFlagsNone  // 0x0
  public    static  UnityEngine.Rendering.ShaderPropertyFlagsHideInInspector  // 0x0
  public    static  UnityEngine.Rendering.ShaderPropertyFlagsPerRendererData  // 0x0
  public    static  UnityEngine.Rendering.ShaderPropertyFlagsNoScaleOffset  // 0x0
  public    static  UnityEngine.Rendering.ShaderPropertyFlagsNormal  // 0x0
  public    static  UnityEngine.Rendering.ShaderPropertyFlagsHDR  // 0x0
  public    static  UnityEngine.Rendering.ShaderPropertyFlagsGamma  // 0x0
  public    static  UnityEngine.Rendering.ShaderPropertyFlagsNonModifiableTextureData  // 0x0
  public    static  UnityEngine.Rendering.ShaderPropertyFlagsMainTexture  // 0x0
  public    static  UnityEngine.Rendering.ShaderPropertyFlagsMainColor  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.RendererUtils.RendererListStatus
TYPE:  struct
TOKEN: 0x2000363
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Rendering.RendererUtils.RendererListStatuskRendererListInvalid  // 0x0
  public    static  UnityEngine.Rendering.RendererUtils.RendererListStatuskRendererListProcessing  // 0x0
  public    static  UnityEngine.Rendering.RendererUtils.RendererListStatuskRendererListEmpty  // 0x0
  public    static  UnityEngine.Rendering.RendererUtils.RendererListStatuskRendererListPopulated  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Rendering.RendererUtils.RendererList
TYPE:  struct
TOKEN: 0x2000364
FIELDS:
  private           System.UIntPtr                  context  // 0x10
  private           System.UInt32                   index  // 0x18
  private           System.UInt32                   frame  // 0x1C
  public    static readonly UnityEngine.Rendering.RendererUtils.RendererListnullRendererList  // 0x0
METHODS:
  System.Boolean get_isValid()
  System.Void .ctor(System.UIntPtr ctx, System.UInt32 indx)
  System.Void .cctor()
  System.Boolean get_isValid_Injected(UnityEngine.Rendering.RendererUtils.RendererList& _unity_self)
END_CLASS

CLASS: UnityEngine.Rendering.RendererUtils.RendererListDesc
TYPE:  struct
TOKEN: 0x2000365
FIELDS:
  public            UnityEngine.Rendering.SortingCriteriasortingCriteria  // 0x10
  public            UnityEngine.Rendering.PerObjectDatarendererConfiguration  // 0x14
  public            UnityEngine.Rendering.RenderQueueRangerenderQueueRange  // 0x18
  public            System.Nullable<UnityEngine.Rendering.RenderStateBlock>stateBlock  // 0x20
  public            UnityEngine.Material            overrideMaterial  // 0x90
  public            System.Boolean                  excludeObjectMotionVectors  // 0x98
  public            System.Int32                    layerMask  // 0x9C
  public            System.Int32                    overrideMaterialPassIndex  // 0xA0
  public            System.Single                   screenCullingRatio  // 0xA4
  public            System.Single                   screenRatioCullingDistance  // 0xA8
  public            System.UInt32                   screenCullingLayerMask  // 0xAC
  public            System.Int16                    sortingLayerMin  // 0xB0
  public            System.Int16                    sortingLayerMax  // 0xB2
  public            System.Int16                    sortingOrderMin  // 0xB4
  public            System.Int16                    sortingOrderMax  // 0xB6
  public            System.UInt16                   characterIndex  // 0xB8
  public            System.IntPtr                   drawableFeedbackPtr  // 0xC0
  private           UnityEngine.Rendering.CullingResults<cullingResult>k__BackingField  // 0xC8
  private           UnityEngine.Camera              <camera>k__BackingField  // 0xD8
  private           UnityEngine.Rendering.ShaderTagId<passName>k__BackingField  // 0xE0
  private           UnityEngine.Rendering.ShaderTagId[]<passNames>k__BackingField  // 0xE8
METHODS:
  UnityEngine.Rendering.CullingResults get_cullingResult()
  System.Void set_cullingResult(UnityEngine.Rendering.CullingResults value)
  UnityEngine.Camera get_camera()
  System.Void set_camera(UnityEngine.Camera value)
  UnityEngine.Rendering.ShaderTagId get_passName()
  System.Void set_passName(UnityEngine.Rendering.ShaderTagId value)
  UnityEngine.Rendering.ShaderTagId[] get_passNames()
  System.Void set_passNames(UnityEngine.Rendering.ShaderTagId[] value)
  System.Void .ctor(UnityEngine.Rendering.ShaderTagId passName, UnityEngine.Rendering.CullingResults cullingResult, UnityEngine.Camera camera)
  System.Void .ctor(UnityEngine.Rendering.ShaderTagId[] passNames, UnityEngine.Rendering.CullingResults cullingResult, UnityEngine.Camera camera)
  System.Boolean IsValid()
END_CLASS

CLASS: UnityEngine.Rendering.RendererUtils.RendererListParams
TYPE:  struct
TOKEN: 0x2000366
FIELDS:
  private   static readonly UnityEngine.Rendering.ShaderTagIds_EmptyName  // 0x0
  public    static readonly UnityEngine.Rendering.RendererUtils.RendererListParamsnullRendererList  // 0x8
  private           System.Boolean                  <isValid>k__BackingField  // 0x10
  private           UnityEngine.Rendering.CullingResultscullingResult  // 0x18
  private           UnityEngine.Rendering.DrawingSettingsdrawSettings  // 0x28
  private           UnityEngine.Rendering.FilteringSettingsfilteringSettings  // 0x174
  private           System.Nullable<UnityEngine.Rendering.RenderStateBlock>stateBlock  // 0x194
METHODS:
  System.Void set_isValid(System.Boolean value)
  UnityEngine.Rendering.RendererUtils.RendererListParams Create(UnityEngine.Rendering.RendererUtils.RendererListDesc& desc)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.SceneManagement.Scene
TYPE:  struct
TOKEN: 0x200022A
FIELDS:
  private           System.Int32                    m_Handle  // 0x10
METHODS:
  System.Boolean IsValidInternal(System.Int32 sceneHandle)
  System.String GetPathInternal(System.Int32 sceneHandle)
  System.String GetNameInternal(System.Int32 sceneHandle)
  System.Void SetNameInternal(System.Int32 sceneHandle, System.String name)
  System.String GetGUIDInternal(System.Int32 sceneHandle)
  System.Boolean IsSubScene(System.Int32 sceneHandle)
  System.Void SetIsSubScene(System.Int32 sceneHandle, System.Boolean value)
  System.Boolean GetIsLoadedInternal(System.Int32 sceneHandle)
  UnityEngine.SceneManagement.Scene.LoadingState GetLoadingStateInternal(System.Int32 sceneHandle)
  System.Boolean GetIsDirtyInternal(System.Int32 sceneHandle)
  System.Int32 GetDirtyID(System.Int32 sceneHandle)
  System.Int32 GetBuildIndexInternal(System.Int32 sceneHandle)
  System.Int32 GetRootCountInternal(System.Int32 sceneHandle)
  System.Void GetRootGameObjectsInternal(System.Int32 sceneHandle, System.Object resultRootList)
  System.Void .ctor(System.Int32 handle)
  System.Int32 get_handle()
  UnityEngine.SceneManagement.Scene.LoadingState get_loadingState()
  System.String get_guid()
  System.Boolean IsValid()
  System.String get_path()
  System.String get_name()
  System.Void set_name(System.String value)
  System.Boolean get_isLoaded()
  System.Int32 get_buildIndex()
  System.Boolean get_isDirty()
  System.Int32 get_dirtyID()
  System.Int32 get_rootCount()
  System.Boolean get_isSubScene()
  System.Void set_isSubScene(System.Boolean value)
  UnityEngine.GameObject[] GetRootGameObjects()
  System.Void GetRootGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> rootGameObjects)
  System.Boolean op_Equality(UnityEngine.SceneManagement.Scene lhs, UnityEngine.SceneManagement.Scene rhs)
  System.Boolean op_Inequality(UnityEngine.SceneManagement.Scene lhs, UnityEngine.SceneManagement.Scene rhs)
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object other)
END_CLASS

CLASS: UnityEngine.SceneManagement.SceneManagerAPIInternal
TYPE:  class
TOKEN: 0x200022C
FIELDS:
METHODS:
  System.Int32 GetNumScenesInBuildSettings()
  UnityEngine.SceneManagement.Scene GetSceneByBuildIndex(System.Int32 buildIndex)
  UnityEngine.AsyncOperation LoadSceneAsyncNameIndexInternal(System.String sceneName, System.Int32 sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters, System.Boolean mustCompleteNextFrame)
  UnityEngine.AsyncOperation UnloadSceneNameIndexInternal(System.String sceneName, System.Int32 sceneBuildIndex, System.Boolean immediately, UnityEngine.SceneManagement.UnloadSceneOptions options, System.Boolean& outSuccess)
  System.Void GetSceneByBuildIndex_Injected(System.Int32 buildIndex, UnityEngine.SceneManagement.Scene& ret)
  UnityEngine.AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(System.String sceneName, System.Int32 sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters& parameters, System.Boolean mustCompleteNextFrame)
END_CLASS

CLASS: UnityEngine.SceneManagement.SceneManagerAPI
TYPE:  class
TOKEN: 0x200022D
FIELDS:
  private   static  UnityEngine.SceneManagement.SceneManagerAPIs_DefaultAPI  // 0x0
  private   static  UnityEngine.SceneManagement.SceneManagerAPI<overrideAPI>k__BackingField  // 0x8
METHODS:
  UnityEngine.SceneManagement.SceneManagerAPI get_ActiveAPI()
  UnityEngine.SceneManagement.SceneManagerAPI get_overrideAPI()
  System.Void .ctor()
  System.Int32 GetNumScenesInBuildSettings()
  UnityEngine.SceneManagement.Scene GetSceneByBuildIndex(System.Int32 buildIndex)
  UnityEngine.AsyncOperation LoadSceneAsyncByNameOrIndex(System.String sceneName, System.Int32 sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters, System.Boolean mustCompleteNextFrame)
  UnityEngine.AsyncOperation UnloadSceneAsyncByNameOrIndex(System.String sceneName, System.Int32 sceneBuildIndex, System.Boolean immediately, UnityEngine.SceneManagement.UnloadSceneOptions options, System.Boolean& outSuccess)
  UnityEngine.AsyncOperation LoadFirstScene(System.Boolean mustLoadAsync)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.SceneManagement.SceneManager
TYPE:  class
TOKEN: 0x200022E
FIELDS:
  private   static  System.Boolean                  s_AllowLoadScene  // 0x0
  private   static  UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.LoadSceneMode>sceneLoaded  // 0x8
  private   static  UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>sceneUnloaded  // 0x10
  private   static  UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.Scene>activeSceneChanged  // 0x18
METHODS:
  System.Int32 get_sceneCount()
  System.Int32 get_sceneCountInBuildSettings()
  UnityEngine.SceneManagement.Scene GetActiveScene()
  System.Boolean SetActiveScene(UnityEngine.SceneManagement.Scene scene)
  UnityEngine.SceneManagement.Scene GetSceneByPath(System.String scenePath)
  UnityEngine.SceneManagement.Scene GetSceneByName(System.String name)
  UnityEngine.SceneManagement.Scene GetSceneByBuildIndex(System.Int32 buildIndex)
  UnityEngine.SceneManagement.Scene GetSceneAt(System.Int32 index)
  UnityEngine.SceneManagement.Scene CreateScene(System.String sceneName, UnityEngine.SceneManagement.CreateSceneParameters parameters)
  System.Boolean UnloadSceneInternal(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.UnloadSceneOptions options)
  UnityEngine.AsyncOperation UnloadSceneAsyncInternal(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.UnloadSceneOptions options)
  UnityEngine.AsyncOperation LoadSceneAsyncNameIndexInternal(System.String sceneName, System.Int32 sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters, System.Boolean mustCompleteNextFrame)
  UnityEngine.AsyncOperation UnloadSceneNameIndexInternal(System.String sceneName, System.Int32 sceneBuildIndex, System.Boolean immediately, UnityEngine.SceneManagement.UnloadSceneOptions options, System.Boolean& outSuccess)
  System.Void MergeScenes(UnityEngine.SceneManagement.Scene sourceScene, UnityEngine.SceneManagement.Scene destinationScene)
  System.Void MoveGameObjectToScene(UnityEngine.GameObject go, UnityEngine.SceneManagement.Scene scene)
  UnityEngine.AsyncOperation LoadFirstScene_Internal(System.Boolean async)
  System.Void add_sceneLoaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.LoadSceneMode> value)
  System.Void remove_sceneLoaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.LoadSceneMode> value)
  System.Void add_sceneUnloaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> value)
  System.Void remove_sceneUnloaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> value)
  System.Void add_activeSceneChanged(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.Scene> value)
  System.Void remove_activeSceneChanged(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.Scene> value)
  UnityEngine.SceneManagement.Scene[] GetAllScenes()
  UnityEngine.SceneManagement.Scene CreateScene(System.String sceneName)
  System.Void LoadScene(System.String sceneName, UnityEngine.SceneManagement.LoadSceneMode mode)
  System.Void LoadScene(System.String sceneName)
  UnityEngine.SceneManagement.Scene LoadScene(System.String sceneName, UnityEngine.SceneManagement.LoadSceneParameters parameters)
  System.Void LoadScene(System.Int32 sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneMode mode)
  System.Void LoadScene(System.Int32 sceneBuildIndex)
  UnityEngine.SceneManagement.Scene LoadScene(System.Int32 sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters)
  UnityEngine.AsyncOperation LoadSceneAsync(System.Int32 sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneMode mode)
  UnityEngine.AsyncOperation LoadSceneAsync(System.Int32 sceneBuildIndex)
  UnityEngine.AsyncOperation LoadSceneAsync(System.Int32 sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters)
  UnityEngine.AsyncOperation LoadSceneAsync(System.String sceneName, UnityEngine.SceneManagement.LoadSceneMode mode)
  UnityEngine.AsyncOperation LoadSceneAsync(System.String sceneName)
  UnityEngine.AsyncOperation LoadSceneAsync(System.String sceneName, UnityEngine.SceneManagement.LoadSceneParameters parameters)
  System.Boolean UnloadScene(UnityEngine.SceneManagement.Scene scene)
  System.Boolean UnloadScene(System.Int32 sceneBuildIndex)
  System.Boolean UnloadScene(System.String sceneName)
  UnityEngine.AsyncOperation UnloadSceneAsync(System.Int32 sceneBuildIndex)
  UnityEngine.AsyncOperation UnloadSceneAsync(System.String sceneName)
  UnityEngine.AsyncOperation UnloadSceneAsync(UnityEngine.SceneManagement.Scene scene)
  UnityEngine.AsyncOperation UnloadSceneAsync(System.Int32 sceneBuildIndex, UnityEngine.SceneManagement.UnloadSceneOptions options)
  UnityEngine.AsyncOperation UnloadSceneAsync(System.String sceneName, UnityEngine.SceneManagement.UnloadSceneOptions options)
  UnityEngine.AsyncOperation UnloadSceneAsync(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.UnloadSceneOptions options)
  System.Void Internal_SceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
  System.Void Internal_SceneUnloaded(UnityEngine.SceneManagement.Scene scene)
  System.Void Internal_ActiveSceneChanged(UnityEngine.SceneManagement.Scene previousActiveScene, UnityEngine.SceneManagement.Scene newActiveScene)
  System.Void .ctor()
  System.Void .cctor()
  System.Void GetActiveScene_Injected(UnityEngine.SceneManagement.Scene& ret)
  System.Boolean SetActiveScene_Injected(UnityEngine.SceneManagement.Scene& scene)
  System.Void GetSceneByPath_Injected(System.String scenePath, UnityEngine.SceneManagement.Scene& ret)
  System.Void GetSceneByName_Injected(System.String name, UnityEngine.SceneManagement.Scene& ret)
  System.Void GetSceneAt_Injected(System.Int32 index, UnityEngine.SceneManagement.Scene& ret)
  System.Void CreateScene_Injected(System.String sceneName, UnityEngine.SceneManagement.CreateSceneParameters& parameters, UnityEngine.SceneManagement.Scene& ret)
  System.Boolean UnloadSceneInternal_Injected(UnityEngine.SceneManagement.Scene& scene, UnityEngine.SceneManagement.UnloadSceneOptions options)
  UnityEngine.AsyncOperation UnloadSceneAsyncInternal_Injected(UnityEngine.SceneManagement.Scene& scene, UnityEngine.SceneManagement.UnloadSceneOptions options)
  System.Void MergeScenes_Injected(UnityEngine.SceneManagement.Scene& sourceScene, UnityEngine.SceneManagement.Scene& destinationScene)
  System.Void MoveGameObjectToScene_Injected(UnityEngine.GameObject go, UnityEngine.SceneManagement.Scene& scene)
END_CLASS

CLASS: UnityEngine.SceneManagement.LoadSceneMode
TYPE:  struct
TOKEN: 0x200022F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.SceneManagement.LoadSceneModeSingle  // 0x0
  public    static  UnityEngine.SceneManagement.LoadSceneModeAdditive  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.SceneManagement.LocalPhysicsMode
TYPE:  struct
TOKEN: 0x2000230
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.SceneManagement.LocalPhysicsModeNone  // 0x0
  public    static  UnityEngine.SceneManagement.LocalPhysicsModePhysics2D  // 0x0
  public    static  UnityEngine.SceneManagement.LocalPhysicsModePhysics3D  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.SceneManagement.LoadSceneParameters
TYPE:  struct
TOKEN: 0x2000231
FIELDS:
  private           UnityEngine.SceneManagement.LoadSceneModem_LoadSceneMode  // 0x10
  private           UnityEngine.SceneManagement.LocalPhysicsModem_LocalPhysicsMode  // 0x14
METHODS:
  System.Void set_loadSceneMode(UnityEngine.SceneManagement.LoadSceneMode value)
  System.Void .ctor(UnityEngine.SceneManagement.LoadSceneMode mode)
END_CLASS

CLASS: UnityEngine.SceneManagement.CreateSceneParameters
TYPE:  struct
TOKEN: 0x2000232
FIELDS:
  private           UnityEngine.SceneManagement.LocalPhysicsModem_LocalPhysicsMode  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.SceneManagement.LocalPhysicsMode physicsMode)
END_CLASS

CLASS: UnityEngine.SceneManagement.UnloadSceneOptions
TYPE:  struct
TOKEN: 0x2000233
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.SceneManagement.UnloadSceneOptionsNone  // 0x0
  public    static  UnityEngine.SceneManagement.UnloadSceneOptionsUnloadAllEmbeddedSceneObjects  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Scripting.AlwaysLinkAssemblyAttribute
TYPE:  class
TOKEN: 0x2000226
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Scripting.PreserveAttribute
TYPE:  class
TOKEN: 0x2000227
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Scripting.APIUpdating.MovedFromAttributeData
TYPE:  struct
TOKEN: 0x2000228
FIELDS:
  public            System.String                   className  // 0x10
  public            System.String                   nameSpace  // 0x18
  public            System.String                   assembly  // 0x20
  public            System.Boolean                  classHasChanged  // 0x28
  public            System.Boolean                  nameSpaceHasChanged  // 0x29
  public            System.Boolean                  assemblyHasChanged  // 0x2A
  public            System.Boolean                  autoUdpateAPI  // 0x2B
METHODS:
  System.Void Set(System.Boolean autoUpdateAPI, System.String sourceNamespace, System.String sourceAssembly, System.String sourceClassName)
END_CLASS

CLASS: UnityEngine.Scripting.APIUpdating.MovedFromAttribute
TYPE:  class
TOKEN: 0x2000229
EXTENDS: Attribute
FIELDS:
  private           UnityEngine.Scripting.APIUpdating.MovedFromAttributeDatadata  // 0x10
METHODS:
  System.Void .ctor(System.Boolean autoUpdateAPI, System.String sourceNamespace, System.String sourceAssembly, System.String sourceClassName)
  System.Void .ctor(System.String sourceNamespace)
END_CLASS

CLASS: UnityEngine.Serialization.FormerlySerializedAsAttribute
TYPE:  class
TOKEN: 0x2000225
EXTENDS: Attribute
FIELDS:
  private           System.String                   m_oldName  // 0x10
METHODS:
  System.Void .ctor(System.String oldName)
END_CLASS

CLASS: UnityEngine.Sprites.DataUtility
TYPE:  class
TOKEN: 0x20001D0
FIELDS:
METHODS:
  UnityEngine.Vector4 GetInnerUV(UnityEngine.Sprite sprite)
  UnityEngine.Vector4 GetOuterUV(UnityEngine.Sprite sprite)
  UnityEngine.Vector4 GetPadding(UnityEngine.Sprite sprite)
  UnityEngine.Vector2 GetMinSize(UnityEngine.Sprite sprite)
END_CLASS

CLASS: UnityEngine.U2D.SpriteBone
TYPE:  struct
TOKEN: 0x20001D1
FIELDS:
  private           System.String                   m_Name  // 0x10
  private           System.String                   m_Guid  // 0x18
  private           UnityEngine.Vector3             m_Position  // 0x20
  private           UnityEngine.Quaternion          m_Rotation  // 0x2C
  private           System.Single                   m_Length  // 0x3C
  private           System.Int32                    m_ParentId  // 0x40
  private           UnityEngine.Color32             m_Color  // 0x44
METHODS:
END_CLASS

CLASS: UnityEngine.U2D.SpriteAtlasManager
TYPE:  class
TOKEN: 0x20001D2
FIELDS:
  private   static  System.Action<System.String,System.Action<UnityEngine.U2D.SpriteAtlas>>atlasRequested  // 0x0
  private   static  System.Action<UnityEngine.U2D.SpriteAtlas>atlasRegistered  // 0x8
METHODS:
  System.Boolean RequestAtlas(System.String tag)
  System.Void add_atlasRegistered(System.Action<UnityEngine.U2D.SpriteAtlas> value)
  System.Void remove_atlasRegistered(System.Action<UnityEngine.U2D.SpriteAtlas> value)
  System.Void PostRegisteredAtlas(UnityEngine.U2D.SpriteAtlas spriteAtlas)
  System.Void Register(UnityEngine.U2D.SpriteAtlas spriteAtlas)
END_CLASS

CLASS: UnityEngine.U2D.SpriteAtlas
TYPE:  class
TOKEN: 0x20001D3
FIELDS:
METHODS:
  System.Boolean CanBindTo(UnityEngine.Sprite sprite)
END_CLASS

CLASS: UnityEngine.Windows.Input
TYPE:  class
TOKEN: 0x20001E9
FIELDS:
METHODS:
  System.Void ForwardRawInputImpl(System.UInt32* rawInputHeaderIndices, System.UInt32* rawInputDataIndices, System.UInt32 indicesCount, System.Byte* rawInputData, System.UInt32 rawInputDataSize)
  System.Void ForwardRawInput(System.UInt32* rawInputHeaderIndices, System.UInt32* rawInputDataIndices, System.UInt32 indicesCount, System.Byte* rawInputData, System.UInt32 rawInputDataSize)
END_CLASS

CLASS: UnityEngine.Windows.Speech.PhraseRecognitionSystem
TYPE:  class
TOKEN: 0x20001EA
FIELDS:
  private   static  UnityEngine.Windows.Speech.PhraseRecognitionSystem.ErrorDelegateOnError  // 0x0
  private   static  UnityEngine.Windows.Speech.PhraseRecognitionSystem.StatusDelegateOnStatusChanged  // 0x8
METHODS:
  System.Void PhraseRecognitionSystem_InvokeErrorEvent(UnityEngine.Windows.Speech.SpeechError errorCode)
  System.Void PhraseRecognitionSystem_InvokeStatusChangedEvent(UnityEngine.Windows.Speech.SpeechSystemStatus status)
END_CLASS

CLASS: UnityEngine.Windows.Speech.PhraseRecognizer
TYPE:  class
TOKEN: 0x20001ED
FIELDS:
  protected         System.IntPtr                   m_Recognizer  // 0x10
  private           UnityEngine.Windows.Speech.PhraseRecognizer.PhraseRecognizedDelegateOnPhraseRecognized  // 0x18
METHODS:
  System.Void InvokePhraseRecognizedEvent(System.String text, UnityEngine.Windows.Speech.ConfidenceLevel confidence, UnityEngine.Windows.Speech.SemanticMeaning[] semanticMeanings, System.Int64 phraseStartFileTime, System.Int64 phraseDurationTicks)
  UnityEngine.Windows.Speech.SemanticMeaning[] MarshalSemanticMeaning(System.IntPtr keys, System.IntPtr values, System.IntPtr valueSizes, System.Int32 valueCount)
END_CLASS

CLASS: UnityEngine.Windows.Speech.DictationRecognizer
TYPE:  class
TOKEN: 0x20001EF
FIELDS:
  private           System.IntPtr                   m_Recognizer  // 0x10
  private           UnityEngine.Windows.Speech.DictationRecognizer.DictationHypothesisDelegateDictationHypothesis  // 0x18
  private           UnityEngine.Windows.Speech.DictationRecognizer.DictationResultDelegateDictationResult  // 0x20
  private           UnityEngine.Windows.Speech.DictationRecognizer.DictationCompletedDelegateDictationComplete  // 0x28
  private           UnityEngine.Windows.Speech.DictationRecognizer.DictationErrorHandlerDictationError  // 0x30
METHODS:
  System.Void DictationRecognizer_InvokeHypothesisGeneratedEvent(System.String keyword)
  System.Void DictationRecognizer_InvokeResultGeneratedEvent(System.String keyword, UnityEngine.Windows.Speech.ConfidenceLevel minimumConfidence)
  System.Void DictationRecognizer_InvokeCompletedEvent(UnityEngine.Windows.Speech.DictationCompletionCause cause)
  System.Void DictationRecognizer_InvokeErrorEvent(System.String error, System.Int32 hresult)
END_CLASS

CLASS: UnityEngine.Windows.Speech.ConfidenceLevel
TYPE:  struct
TOKEN: 0x20001F4
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Windows.Speech.ConfidenceLevelHigh  // 0x0
  public    static  UnityEngine.Windows.Speech.ConfidenceLevelMedium  // 0x0
  public    static  UnityEngine.Windows.Speech.ConfidenceLevelLow  // 0x0
  public    static  UnityEngine.Windows.Speech.ConfidenceLevelRejected  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Windows.Speech.SpeechSystemStatus
TYPE:  struct
TOKEN: 0x20001F5
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Windows.Speech.SpeechSystemStatusStopped  // 0x0
  public    static  UnityEngine.Windows.Speech.SpeechSystemStatusRunning  // 0x0
  public    static  UnityEngine.Windows.Speech.SpeechSystemStatusFailed  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Windows.Speech.SpeechError
TYPE:  struct
TOKEN: 0x20001F6
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Windows.Speech.SpeechErrorNoError  // 0x0
  public    static  UnityEngine.Windows.Speech.SpeechErrorTopicLanguageNotSupported  // 0x0
  public    static  UnityEngine.Windows.Speech.SpeechErrorGrammarLanguageMismatch  // 0x0
  public    static  UnityEngine.Windows.Speech.SpeechErrorGrammarCompilationFailure  // 0x0
  public    static  UnityEngine.Windows.Speech.SpeechErrorAudioQualityFailure  // 0x0
  public    static  UnityEngine.Windows.Speech.SpeechErrorPauseLimitExceeded  // 0x0
  public    static  UnityEngine.Windows.Speech.SpeechErrorTimeoutExceeded  // 0x0
  public    static  UnityEngine.Windows.Speech.SpeechErrorNetworkFailure  // 0x0
  public    static  UnityEngine.Windows.Speech.SpeechErrorMicrophoneUnavailable  // 0x0
  public    static  UnityEngine.Windows.Speech.SpeechErrorUnknownError  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Windows.Speech.DictationCompletionCause
TYPE:  struct
TOKEN: 0x20001F7
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Windows.Speech.DictationCompletionCauseComplete  // 0x0
  public    static  UnityEngine.Windows.Speech.DictationCompletionCauseAudioQualityFailure  // 0x0
  public    static  UnityEngine.Windows.Speech.DictationCompletionCauseCanceled  // 0x0
  public    static  UnityEngine.Windows.Speech.DictationCompletionCauseTimeoutExceeded  // 0x0
  public    static  UnityEngine.Windows.Speech.DictationCompletionCausePauseLimitExceeded  // 0x0
  public    static  UnityEngine.Windows.Speech.DictationCompletionCauseNetworkFailure  // 0x0
  public    static  UnityEngine.Windows.Speech.DictationCompletionCauseMicrophoneUnavailable  // 0x0
  public    static  UnityEngine.Windows.Speech.DictationCompletionCauseUnknownError  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Windows.Speech.SemanticMeaning
TYPE:  struct
TOKEN: 0x20001F8
FIELDS:
  public            System.String                   key  // 0x10
  public            System.String[]                 values  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.Windows.Speech.PhraseRecognizedEventArgs
TYPE:  struct
TOKEN: 0x20001F9
FIELDS:
  public    readonly UnityEngine.Windows.Speech.ConfidenceLevelconfidence  // 0x10
  public    readonly UnityEngine.Windows.Speech.SemanticMeaning[]semanticMeanings  // 0x18
  public    readonly System.String                   text  // 0x20
  public    readonly System.DateTime                 phraseStartTime  // 0x28
  public    readonly System.TimeSpan                 phraseDuration  // 0x30
METHODS:
  System.Void .ctor(System.String text, UnityEngine.Windows.Speech.ConfidenceLevel confidence, UnityEngine.Windows.Speech.SemanticMeaning[] semanticMeanings, System.DateTime phraseStartTime, System.TimeSpan phraseDuration)
END_CLASS

CLASS: UnityEngine.Windows.WebCam.PhotoCapture
TYPE:  class
TOKEN: 0x20001FA
FIELDS:
  private           System.IntPtr                   m_NativePtr  // 0x10
  private   static readonly System.Int64                    HR_SUCCESS  // 0x0
METHODS:
  UnityEngine.Windows.WebCam.PhotoCapture.PhotoCaptureResult MakeCaptureResult(System.Int64 hResult)
  System.Void InvokeOnCreatedResourceDelegate(UnityEngine.Windows.WebCam.PhotoCapture.OnCaptureResourceCreatedCallback callback, System.IntPtr nativePtr)
  System.Void .ctor(System.IntPtr nativeCaptureObject)
  System.Void InvokeOnPhotoModeStartedDelegate(UnityEngine.Windows.WebCam.PhotoCapture.OnPhotoModeStartedCallback callback, System.Int64 hResult)
  System.Void InvokeOnPhotoModeStoppedDelegate(UnityEngine.Windows.WebCam.PhotoCapture.OnPhotoModeStoppedCallback callback, System.Int64 hResult)
  System.Void InvokeOnCapturedPhotoToDiskDelegate(UnityEngine.Windows.WebCam.PhotoCapture.OnCapturedToDiskCallback callback, System.Int64 hResult)
  System.Void InvokeOnCapturedPhotoToMemoryDelegate(UnityEngine.Windows.WebCam.PhotoCapture.OnCapturedToMemoryCallback callback, System.Int64 hResult, System.IntPtr photoCaptureFramePtr)
  System.Void Dispose()
  System.Void Dispose_Internal()
  System.Void Finalize()
  System.Void DisposeThreaded_Internal()
END_CLASS

CLASS: UnityEngine.Windows.WebCam.PhotoCaptureFrame
TYPE:  class
TOKEN: 0x2000202
FIELDS:
  private           System.IntPtr                   m_NativePtr  // 0x10
  private           System.Int32                    <dataLength>k__BackingField  // 0x18
  private           System.Boolean                  <hasLocationData>k__BackingField  // 0x1C
  private           UnityEngine.Windows.WebCam.CapturePixelFormat<pixelFormat>k__BackingField  // 0x20
METHODS:
  System.Int32 get_dataLength()
  System.Void set_dataLength(System.Int32 value)
  System.Void set_hasLocationData(System.Boolean value)
  System.Void set_pixelFormat(UnityEngine.Windows.WebCam.CapturePixelFormat value)
  System.Int32 GetDataLength()
  System.Boolean GetHasLocationData()
  UnityEngine.Windows.WebCam.CapturePixelFormat GetCapturePixelFormat()
  System.Void .ctor(System.IntPtr nativePtr)
  System.Void Cleanup()
  System.Void Dispose_Internal()
  System.Void Dispose()
  System.Void Finalize()
END_CLASS

CLASS: UnityEngine.Windows.WebCam.VideoCapture
TYPE:  class
TOKEN: 0x2000203
FIELDS:
  private           System.IntPtr                   m_NativePtr  // 0x10
  private   static readonly System.Int64                    HR_SUCCESS  // 0x0
METHODS:
  UnityEngine.Windows.WebCam.VideoCapture.VideoCaptureResult MakeCaptureResult(System.Int64 hResult)
  System.Void InvokeOnCreatedVideoCaptureResourceDelegate(UnityEngine.Windows.WebCam.VideoCapture.OnVideoCaptureResourceCreatedCallback callback, System.IntPtr nativePtr)
  System.Void .ctor(System.IntPtr nativeCaptureObject)
  System.Void InvokeOnVideoModeStartedDelegate(UnityEngine.Windows.WebCam.VideoCapture.OnVideoModeStartedCallback callback, System.Int64 hResult)
  System.Void InvokeOnVideoModeStoppedDelegate(UnityEngine.Windows.WebCam.VideoCapture.OnVideoModeStoppedCallback callback, System.Int64 hResult)
  System.Void InvokeOnStartedRecordingVideoToDiskDelegate(UnityEngine.Windows.WebCam.VideoCapture.OnStartedRecordingVideoCallback callback, System.Int64 hResult)
  System.Void InvokeOnStoppedRecordingVideoToDiskDelegate(UnityEngine.Windows.WebCam.VideoCapture.OnStoppedRecordingVideoCallback callback, System.Int64 hResult)
  System.Void Dispose()
  System.Void Dispose_Internal()
  System.Void Finalize()
  System.Void DisposeThreaded_Internal()
END_CLASS

CLASS: UnityEngine.Windows.WebCam.CapturePixelFormat
TYPE:  struct
TOKEN: 0x200020B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Windows.WebCam.CapturePixelFormatBGRA32  // 0x0
  public    static  UnityEngine.Windows.WebCam.CapturePixelFormatNV12  // 0x0
  public    static  UnityEngine.Windows.WebCam.CapturePixelFormatJPEG  // 0x0
  public    static  UnityEngine.Windows.WebCam.CapturePixelFormatPNG  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine._Scripting.APIUpdating.APIUpdaterRuntimeHelpers
TYPE:  class
TOKEN: 0x20001CF
FIELDS:
METHODS:
  System.Boolean GetMovedFromAttributeDataForType(System.Type sourceType, System.String& assembly, System.String& nsp, System.String& klass)
  System.Boolean GetObsoleteTypeRedirection(System.Type sourceType, System.String& assemblyName, System.String& nsp, System.String& className)
END_CLASS

CLASS: UnityEngineInternal.LightmapType
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngineInternal.LightmapTypeNoLightmap  // 0x0
  public    static  UnityEngineInternal.LightmapTypeStaticLightmap  // 0x0
  public    static  UnityEngineInternal.LightmapTypeDynamicLightmap  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngineInternal.MathfInternal
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public    static  System.Single                   FloatMinNormal  // 0x0
  public    static  System.Single                   FloatMinDenormal  // 0x4
  public    static  System.Boolean                  IsFlushToZeroEnabled  // 0x8
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: UnityEngineInternal.TypeInferenceRules
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngineInternal.TypeInferenceRulesTypeReferencedByFirstArgument  // 0x0
  public    static  UnityEngineInternal.TypeInferenceRulesTypeReferencedBySecondArgument  // 0x0
  public    static  UnityEngineInternal.TypeInferenceRulesArrayOfTypeReferencedByFirstArgument  // 0x0
  public    static  UnityEngineInternal.TypeInferenceRulesTypeOfFirstArgument  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngineInternal.TypeInferenceRuleAttribute
TYPE:  class
TOKEN: 0x2000009
EXTENDS: Attribute
FIELDS:
  private   readonly System.String                   _rule  // 0x10
METHODS:
  System.Void .ctor(UnityEngineInternal.TypeInferenceRules rule)
  System.Void .ctor(System.String rule)
  System.String ToString()
END_CLASS

CLASS: UnityEngineInternal.GenericStack
TYPE:  class
TOKEN: 0x200000A
EXTENDS: Stack
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

