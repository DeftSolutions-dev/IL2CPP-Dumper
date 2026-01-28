// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.AssetBundleModule.dll
// Classes:  7
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace UnityEngine
{

    // TypeToken: 0x2000002
    public class AssetBundle
    {
        // Fields
        private static System.Action onMissReferencedScript;        // 0x0
        public static System.Func<System.Int64,System.String> hashToStringPath;        // 0x8
        public static System.Func<System.Int64,System.Boolean> checkHashValid;        // 0x10
        public static System.Action<System.String> addPathSting;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private UnityEngine.AssetBundle[] GetAllLoadedAssetBundles_Native() { }
        private System.Collections.Generic.IEnumerable<UnityEngine.AssetBundle> GetAllLoadedAssetBundles() { }
        private System.Void WaitForAllAsyncOperationsToComplete() { }
        private System.Void WaitForAllAsyncOperationsToComplete_Internal() { }
        private System.Void InvokeOnMissReferencedScriptOnBehaviour() { }
        private System.Void set_enableLazyCloseFile(System.Boolean value) { }
        private System.Boolean TryCloseLazyCloseFile_Internal(System.Boolean force) { }
        private System.Boolean TryCloseLazyCloseFile(System.Boolean force) { }
        private System.String HashToStringPath(System.Int64 hash) { }
        private System.Boolean CheckHashValid(System.Int64 hash) { }
        private System.Void AddPathStringToCSharp(System.String path) { }
        private UnityEngine.AssetBundleCreateRequest LoadFromFileAsync_Internal(System.String path, System.UInt32 crc, System.UInt64 offset) { }
        private UnityEngine.AssetBundleCreateRequest LoadFromFileAsync(System.String path) { }
        private UnityEngine.AssetBundleCreateRequest LoadFromFileAsync(System.String path, System.UInt32 crc, System.UInt64 offset) { }
        private UnityEngine.AssetBundle LoadFromFile_Internal(System.String path, System.UInt32 crc, System.UInt64 offset) { }
        private UnityEngine.AssetBundle LoadFromFile(System.String path) { }
        private UnityEngine.AssetBundle LoadFromFile(System.String path, System.UInt32 crc, System.UInt64 offset) { }
        private UnityEngine.AssetBundleCreateRequest LoadFromMemoryAsync_Internal(System.Byte[] binary, System.UInt32 crc) { }
        private UnityEngine.AssetBundleCreateRequest LoadFromMemoryAsync(System.Byte[] binary) { }
        private T LoadAsset(System.String name) { }
        private UnityEngine.Object LoadAsset(System.Int64 hash, System.Type type) { }
        private UnityEngine.Object LoadAsset(System.String name, System.Type type) { }
        private UnityEngine.Object LoadAsset_Internal(System.String name, System.Type type) { }
        private UnityEngine.Object LoadAssetByHash_Internal(System.Int64 hash, System.Type type) { }
        private UnityEngine.AssetBundleRequest LoadAssetAsync(System.String name) { }
        private UnityEngine.AssetBundleRequest LoadAssetAsync(System.String name, System.Type type) { }
        private UnityEngine.AssetBundleRequest LoadAssetAsync(System.Int64 hash, System.Type type) { }
        private UnityEngine.AssetBundleRequest LoadSubAssetAsync(System.String name, System.Int64 subAssetInstanceID, System.Type type) { }
        private UnityEngine.AssetBundleRequest LoadAssetAsync_Internal(System.String name, System.Type type) { }
        private UnityEngine.AssetBundleRequest LoadAssetAsyncByHash_Internal(System.Int64 hash, System.Type type) { }
        private System.Void Unload(System.Boolean unloadAllLoadedObjects) { }
        private UnityEngine.AsyncOperation UnloadAsync(System.Boolean unloadAllLoadedObjects) { }
        private UnityEngine.AssetBundleRequest LoadSubAssetAsync_Internal(System.String name, System.Int64 instanceID, System.Type type) { }
        private System.UInt32 get_memoryBudgetKB() { }
        private System.Void set_memoryBudgetKB(System.UInt32 value) { }

    }

    // TypeToken: 0x2000003
    public class AssetBundleCreateRequest : AsyncOperation
    {
        // Methods
        private UnityEngine.AssetBundle get_assetBundle() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000004
    public class AssetBundleLoadingCache
    {
        // Methods
        private System.UInt32 get_maxBlocksPerFile() { }
        private System.Void set_maxBlocksPerFile(System.UInt32 value) { }
        private System.UInt32 get_blockCount() { }
        private System.Void set_blockCount(System.UInt32 value) { }
        private System.UInt32 get_blockSize() { }
        private System.UInt32 get_memoryBudgetKB() { }
        private System.Void set_memoryBudgetKB(System.UInt32 value) { }

    }

    // TypeToken: 0x2000005
    public class AssetBundleRecompressOperation : AsyncOperation
    {
    }

    // TypeToken: 0x2000006
    public class AssetBundleRequest : ResourceRequest
    {
        // Methods
        private UnityEngine.Object GetResult() { }
        private UnityEngine.Object get_asset() { }
        private System.Void .ctor() { }

    }

}

namespace UnityEngine.Experimental.AssetBundlePatching
{

    // TypeToken: 0x2000007
    public class AssetBundleUtility
    {
        // Methods
        private System.Int32 LZ4Decompress(System.Void* src, System.Int32 srcSize, System.Void* dst, System.Int32 dstSize) { }
        private System.Int32 LZ4Decompress(System.Byte[] src, System.Int32 srcOffset, System.Int32 srcSize, System.Byte[] dst, System.Int32 dstOffset, System.Int32 dstSize) { }

    }

}

