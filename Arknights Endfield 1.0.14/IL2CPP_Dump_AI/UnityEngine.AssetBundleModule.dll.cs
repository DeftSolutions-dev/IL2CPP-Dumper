// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.AssetBundleModule.dll
// Classes:  7
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: UnityEngine.AssetBundle
TYPE:  class
TOKEN: 0x2000002
FIELDS:
  private   static  System.Action                   onMissReferencedScript  // 0x0
  public    static  System.Func<System.Int64,System.String>hashToStringPath  // 0x8
  public    static  System.Func<System.Int64,System.Boolean>checkHashValid  // 0x10
  public    static  System.Action<System.String>    addPathSting  // 0x18
METHODS:
  System.Void .ctor()
  UnityEngine.AssetBundle[] GetAllLoadedAssetBundles_Native()
  System.Collections.Generic.IEnumerable<UnityEngine.AssetBundle> GetAllLoadedAssetBundles()
  System.Void WaitForAllAsyncOperationsToComplete()
  System.Void WaitForAllAsyncOperationsToComplete_Internal()
  System.Void InvokeOnMissReferencedScriptOnBehaviour()
  System.Void set_enableLazyCloseFile(System.Boolean value)
  System.Boolean TryCloseLazyCloseFile_Internal(System.Boolean force)
  System.Boolean TryCloseLazyCloseFile(System.Boolean force)
  System.String HashToStringPath(System.Int64 hash)
  System.Boolean CheckHashValid(System.Int64 hash)
  System.Void AddPathStringToCSharp(System.String path)
  UnityEngine.AssetBundleCreateRequest LoadFromFileAsync_Internal(System.String path, System.UInt32 crc, System.UInt64 offset)
  UnityEngine.AssetBundleCreateRequest LoadFromFileAsync(System.String path)
  UnityEngine.AssetBundleCreateRequest LoadFromFileAsync(System.String path, System.UInt32 crc, System.UInt64 offset)
  UnityEngine.AssetBundle LoadFromFile_Internal(System.String path, System.UInt32 crc, System.UInt64 offset)
  UnityEngine.AssetBundle LoadFromFile(System.String path)
  UnityEngine.AssetBundle LoadFromFile(System.String path, System.UInt32 crc, System.UInt64 offset)
  UnityEngine.AssetBundleCreateRequest LoadFromMemoryAsync_Internal(System.Byte[] binary, System.UInt32 crc)
  UnityEngine.AssetBundleCreateRequest LoadFromMemoryAsync(System.Byte[] binary)
  T LoadAsset(System.String name)
  UnityEngine.Object LoadAsset(System.Int64 hash, System.Type type)
  UnityEngine.Object LoadAsset(System.String name, System.Type type)
  UnityEngine.Object LoadAsset_Internal(System.String name, System.Type type)
  UnityEngine.Object LoadAssetByHash_Internal(System.Int64 hash, System.Type type)
  UnityEngine.AssetBundleRequest LoadAssetAsync(System.String name)
  UnityEngine.AssetBundleRequest LoadAssetAsync(System.String name, System.Type type)
  UnityEngine.AssetBundleRequest LoadAssetAsync(System.Int64 hash, System.Type type)
  UnityEngine.AssetBundleRequest LoadSubAssetAsync(System.String name, System.Int64 subAssetInstanceID, System.Type type)
  UnityEngine.AssetBundleRequest LoadAssetAsync_Internal(System.String name, System.Type type)
  UnityEngine.AssetBundleRequest LoadAssetAsyncByHash_Internal(System.Int64 hash, System.Type type)
  System.Void Unload(System.Boolean unloadAllLoadedObjects)
  UnityEngine.AsyncOperation UnloadAsync(System.Boolean unloadAllLoadedObjects)
  UnityEngine.AssetBundleRequest LoadSubAssetAsync_Internal(System.String name, System.Int64 instanceID, System.Type type)
  System.UInt32 get_memoryBudgetKB()
  System.Void set_memoryBudgetKB(System.UInt32 value)
END_CLASS

CLASS: UnityEngine.AssetBundleCreateRequest
TYPE:  class
TOKEN: 0x2000003
EXTENDS: AsyncOperation
FIELDS:
METHODS:
  UnityEngine.AssetBundle get_assetBundle()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.AssetBundleLoadingCache
TYPE:  class
TOKEN: 0x2000004
FIELDS:
METHODS:
  System.UInt32 get_maxBlocksPerFile()
  System.Void set_maxBlocksPerFile(System.UInt32 value)
  System.UInt32 get_blockCount()
  System.Void set_blockCount(System.UInt32 value)
  System.UInt32 get_blockSize()
  System.UInt32 get_memoryBudgetKB()
  System.Void set_memoryBudgetKB(System.UInt32 value)
END_CLASS

CLASS: UnityEngine.AssetBundleRecompressOperation
TYPE:  class
TOKEN: 0x2000005
EXTENDS: AsyncOperation
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.AssetBundleRequest
TYPE:  class
TOKEN: 0x2000006
EXTENDS: ResourceRequest
FIELDS:
METHODS:
  UnityEngine.Object GetResult()
  UnityEngine.Object get_asset()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Experimental.AssetBundlePatching.AssetBundleUtility
TYPE:  class
TOKEN: 0x2000007
FIELDS:
METHODS:
  System.Int32 LZ4Decompress(System.Void* src, System.Int32 srcSize, System.Void* dst, System.Int32 dstSize)
  System.Int32 LZ4Decompress(System.Byte[] src, System.Int32 srcOffset, System.Int32 srcSize, System.Byte[] dst, System.Int32 dstOffset, System.Int32 dstSize)
END_CLASS

