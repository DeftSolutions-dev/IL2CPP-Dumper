// ========================================================
// Dumped by @desirepro
// Assembly: Unsafe.Streaming.dll
// Classes:  15
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: Beyond.Gameplay.Streaming.StreamingUnsafeUtilsV2
TYPE:  class
TOKEN: 0x2000009
FIELDS:
  public    static  System.Int32                    s_defaultSceneStateId  // 0x0
  public    static  System.Int32                    s_defaultAreaId  // 0x4
METHODS:
  UnityEngine.HyperGryph.Streaming.StreamingSourceData CreateStreamingSourceData(UnityEngine.Vector2 streamingPos, System.Single chunkLoadRadius, System.Single defaultLayerLoadRadius, System.Single hlod0LayerLoadRadius, System.Single hlod1LayerLoadRadius, System.Single hlod2LayerLoadRadius, System.Single colliderLayerLoadRadius, System.Single tinyLayerLoadRadius, System.Single waterLayerLoadRadius, System.Single lightingLoadRadius, System.Single audioLoadRadius, Unity.Collections.NativeArray<System.Byte> layerEnabled)
  System.Void MemSet(Unity.Collections.NativeArray<T> array, System.Byte value, System.Int32 count)
  System.Span<T> AsSpan(Unity.Collections.NativeArray<T> nativeArray)
  System.ReadOnlySpan<T> AsReadOnlySpan(Unity.Collections.NativeArray<T> nativeArray)
  System.Void MemCpyUnsafe(System.IntPtr destination, System.IntPtr source, System.Int64 size)
  System.IntPtr MallocUnsafe(System.Int64 size, System.Int32 alignment, Unity.Collections.Allocator allocator)
  System.Void FreeUnsafe(System.IntPtr memory, Unity.Collections.Allocator allocator)
  System.Byte[] ConvertToBytes(T val)
  System.IntPtr GetIntPtr(Unity.Collections.NativeArray<T> array)
  System.IntPtr GetReadonlyIntPtr(Unity.Collections.NativeArray<T> array)
  System.UIntPtr GetReadonlyUIntPtr(Unity.Collections.NativeArray<T> array)
  System.IntPtr GetRendererInfos(T& kComponent)
  UnityEngine.HyperGryph.ECS.RendererInfo& GetRendererInfo(System.IntPtr rendererInfos, System.Int32 index)
  TTo ReinterpretAs(TFrom val)
END_CLASS

CLASS: Beyond.Gameplay.Streaming.UnsafeArray`1
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            System.IntPtr                   ptr  // 0x0
  public            System.Int32                    count  // 0x0
  public            Unity.Collections.Allocator     allocator  // 0x0
METHODS:
  System.Boolean get_IsCreated()
  System.Void .ctor(System.Int32 count, Unity.Collections.Allocator allocator, Unity.Collections.NativeArrayOptions options)
  T get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, T value)
  T GetValue(System.Int32 index)
  T& GetRef(System.Int32 index)
  System.Void SetValue(System.Int32 index, T value)
  System.Void Resize(System.Int32 newCount, Unity.Collections.NativeArrayOptions options)
  System.Void Dispose()
END_CLASS

CLASS: Beyond.Gameplay.Streaming.VFSReadOperation
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  public            Unity.IO.LowLevel.Unsafe.ReadCommand*readCommand  // 0x10
  public            Unity.IO.LowLevel.Unsafe.ReadHandlereadHandle  // 0x18
METHODS:
  System.Void .ctor(Beyond.VFS.FVFBlockFileInfo info, System.Boolean async)
  System.Void Dispose()
  System.Boolean IsValid()
  Unity.Collections.NativeArray<System.Byte> GetData()
END_CLASS

CLASS: Beyond.SourceGenerator.AnimatorBlackboardAttribute
TYPE:  class
TOKEN: 0x2000005
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.CameraControlConfigAttribute
TYPE:  class
TOKEN: 0x2000006
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.ECSComponentAttribute
TYPE:  class
TOKEN: 0x2000007
EXTENDS: Attribute
FIELDS:
  public            System.Runtime.InteropServices.LayoutKindlayoutKind  // 0x10
  public            System.Boolean                  isTag  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.DataNAttribute
TYPE:  class
TOKEN: 0x2000008
EXTENDS: Attribute
FIELDS:
  public            System.Int32                    capacity  // 0x10
  public            System.Int32                    tSize  // 0x14
  public            System.Boolean                  ring  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HG.Rendering.Runtime.HGConstantBufferLayoutAttribute
TYPE:  class
TOKEN: 0x2000004
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x200000C
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // 0x0
METHODS:
  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj)
  UnityEngine.HyperGryph.Streaming.StreamingSourceData __Gen_Wrap_0(UnityEngine.Vector2 P0, System.Single P1, System.Single P2, System.Single P3, System.Single P4, System.Single P5, System.Single P6, System.Single P7, System.Single P8, System.Single P9, System.Single P10, Unity.Collections.NativeArray<System.Byte> P11)
  System.Void __Gen_Wrap_1(System.IntPtr P0, System.IntPtr P1, System.Int64 P2)
  System.IntPtr __Gen_Wrap_2(System.Int64 P0, System.Int32 P1, Unity.Collections.Allocator P2)
  System.Void __Gen_Wrap_3(System.IntPtr P0, Unity.Collections.Allocator P1)
  System.Void __Gen_Wrap_4(Beyond.Gameplay.Streaming.VFSReadOperation& P0)
  System.Boolean __Gen_Wrap_5(Beyond.Gameplay.Streaming.VFSReadOperation& P0)
  Unity.Collections.NativeArray<System.Byte> __Gen_Wrap_6(Beyond.Gameplay.Streaming.VFSReadOperation& P0)
  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixInterfaceBridge
TYPE:  class
TOKEN: 0x200000D
EXTENDS: AnonymousStorey
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine)
  System.Void RefAsyncBuilderStartMethod()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x200000E
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
TOKEN: 0x200000F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Streaming-StreamingUnsafeUtilsV2-CreateStreamingSourceData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Streaming-StreamingUnsafeUtilsV2-MemCpyUnsafe0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Streaming-StreamingUnsafeUtilsV2-MallocUnsafe0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Streaming-StreamingUnsafeUtilsV2-FreeUnsafe0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Streaming-VFSReadOperation-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Streaming-VFSReadOperation-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Streaming-VFSReadOperation-GetData0  // 0x0
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

