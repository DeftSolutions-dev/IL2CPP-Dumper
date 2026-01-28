// ========================================================
// Dumped by @desirepro
// Assembly: Unsafe.Streaming.dll
// Classes:  15
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace Beyond.Gameplay.Streaming
{

    // TypeToken: 0x2000009
    public class StreamingUnsafeUtilsV2
    {
        // Fields
        public static System.Int32 s_defaultSceneStateId;        // 0x0
        public static System.Int32 s_defaultAreaId;        // 0x4

        // Methods
        private UnityEngine.HyperGryph.Streaming.StreamingSourceData CreateStreamingSourceData(UnityEngine.Vector2 streamingPos, System.Single chunkLoadRadius, System.Single defaultLayerLoadRadius, System.Single hlod0LayerLoadRadius, System.Single hlod1LayerLoadRadius, System.Single hlod2LayerLoadRadius, System.Single colliderLayerLoadRadius, System.Single tinyLayerLoadRadius, System.Single waterLayerLoadRadius, System.Single lightingLoadRadius, System.Single audioLoadRadius, Unity.Collections.NativeArray<System.Byte> layerEnabled) { }
        private System.Void MemSet(Unity.Collections.NativeArray<T> array, System.Byte value, System.Int32 count) { }
        private System.Span<T> AsSpan(Unity.Collections.NativeArray<T> nativeArray) { }
        private System.ReadOnlySpan<T> AsReadOnlySpan(Unity.Collections.NativeArray<T> nativeArray) { }
        private System.Void MemCpyUnsafe(System.IntPtr destination, System.IntPtr source, System.Int64 size) { }
        private System.IntPtr MallocUnsafe(System.Int64 size, System.Int32 alignment, Unity.Collections.Allocator allocator) { }
        private System.Void FreeUnsafe(System.IntPtr memory, Unity.Collections.Allocator allocator) { }
        private System.Byte[] ConvertToBytes(T val) { }
        private System.IntPtr GetIntPtr(Unity.Collections.NativeArray<T> array) { }
        private System.IntPtr GetReadonlyIntPtr(Unity.Collections.NativeArray<T> array) { }
        private System.UIntPtr GetReadonlyUIntPtr(Unity.Collections.NativeArray<T> array) { }
        private System.IntPtr GetRendererInfos(T& kComponent) { }
        private UnityEngine.HyperGryph.ECS.RendererInfo& GetRendererInfo(System.IntPtr rendererInfos, System.Int32 index) { }
        private TTo ReinterpretAs(TFrom val) { }

    }

    // TypeToken: 0x200000A
    public struct UnsafeArray`1, IDisposable
    {
        // Fields
        public System.IntPtr ptr;        // 0x0
        public System.Int32 count;        // 0x0
        public Unity.Collections.Allocator allocator;        // 0x0

        // Methods
        private System.Boolean get_IsCreated() { }
        private System.Void .ctor(System.Int32 count, Unity.Collections.Allocator allocator, Unity.Collections.NativeArrayOptions options) { }
        private T get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, T value) { }
        private T GetValue(System.Int32 index) { }
        private T& GetRef(System.Int32 index) { }
        private System.Void SetValue(System.Int32 index, T value) { }
        private System.Void Resize(System.Int32 newCount, Unity.Collections.NativeArrayOptions options) { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x200000B
    public struct VFSReadOperation, IDisposable
    {
        // Fields
        public Unity.IO.LowLevel.Unsafe.ReadCommand* readCommand;        // 0x10
        public Unity.IO.LowLevel.Unsafe.ReadHandle readHandle;        // 0x18

        // Methods
        private System.Void .ctor(Beyond.VFS.FVFBlockFileInfo info, System.Boolean async) { }
        private System.Void Dispose() { }
        private System.Boolean IsValid() { }
        private Unity.Collections.NativeArray<System.Byte> GetData() { }

    }

}

namespace Beyond.SourceGenerator
{

    // TypeToken: 0x2000005
    public class AnimatorBlackboardAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000006
    public class CameraControlConfigAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000007
    public class ECSComponentAttribute : Attribute
    {
        // Fields
        public System.Runtime.InteropServices.LayoutKind layoutKind;        // 0x10
        public System.Boolean isTag;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000008
    public class DataNAttribute : Attribute
    {
        // Fields
        public System.Int32 capacity;        // 0x10
        public System.Int32 tSize;        // 0x14
        public System.Boolean ring;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

}

namespace HG.Rendering.Runtime
{

    // TypeToken: 0x2000004
    public class HGConstantBufferLayoutAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace IFix
{

    // TypeToken: 0x200000C
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10
        private System.Int32 methodId;        // 0x18
        private System.Object anonObj;        // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;        // 0x0

        // Methods
        private System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        private UnityEngine.HyperGryph.Streaming.StreamingSourceData __Gen_Wrap_0(UnityEngine.Vector2 P0, System.Single P1, System.Single P2, System.Single P3, System.Single P4, System.Single P5, System.Single P6, System.Single P7, System.Single P8, System.Single P9, System.Single P10, Unity.Collections.NativeArray<System.Byte> P11) { }
        private System.Void __Gen_Wrap_1(System.IntPtr P0, System.IntPtr P1, System.Int64 P2) { }
        private System.IntPtr __Gen_Wrap_2(System.Int64 P0, System.Int32 P1, Unity.Collections.Allocator P2) { }
        private System.Void __Gen_Wrap_3(System.IntPtr P0, Unity.Collections.Allocator P1) { }
        private System.Void __Gen_Wrap_4(Beyond.Gameplay.Streaming.VFSReadOperation& P0) { }
        private System.Boolean __Gen_Wrap_5(Beyond.Gameplay.Streaming.VFSReadOperation& P0) { }
        private Unity.Collections.NativeArray<System.Byte> __Gen_Wrap_6(Beyond.Gameplay.Streaming.VFSReadOperation& P0) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000D
    public class ILFixInterfaceBridge : AnonymousStorey
    {
        // Methods
        private System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        private System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x200000E
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

    // TypeToken: 0x200000F
    public struct IDMAP0
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static IFix.IDMAP0 Beyond-Gameplay-Streaming-StreamingUnsafeUtilsV2-CreateStreamingSourceData0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Streaming-StreamingUnsafeUtilsV2-MemCpyUnsafe0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Streaming-StreamingUnsafeUtilsV2-MallocUnsafe0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Streaming-StreamingUnsafeUtilsV2-FreeUnsafe0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Streaming-VFSReadOperation-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Streaming-VFSReadOperation-IsValid0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-Streaming-VFSReadOperation-GetData0;        // 0x0

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

