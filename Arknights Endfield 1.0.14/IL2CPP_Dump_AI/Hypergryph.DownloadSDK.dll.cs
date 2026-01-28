// ========================================================
// Dumped by @desirepro
// Assembly: Hypergryph.DownloadSDK.dll
// Classes:  4
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: Hypergryph.SDK.IHGDownloadSDK
TYPE:  interface
TOKEN: 0x2000002
FIELDS:
METHODS:
  System.Int32 init(System.String config)
  System.Int64 download(System.String versionId, System.String downloadFiles, System.String decompressPath, System.Boolean useMobileData, System.Boolean needCompress, System.Boolean usePatch, System.String rootPath)
  System.Int64 updateV3(System.String versionId, System.String basePath, System.String rootPath, System.String fileUrl, System.String patchUrl, System.String totalFiles, System.String patchInfo, System.Boolean useMobileData, System.Int32 checkType)
  System.Int32 clearUselessFiles(System.String rootPath, System.String allFiles)
  System.Int32 enableMobileData(System.Int64 taskId)
  System.Int32 resume(System.Int64 taskId)
  System.Int32 cancel(System.Int64 taskId)
  System.Int32 clearAllTasks()
  System.Int32 finish(System.Int64 taskId)
  System.Int32 getSDKState()
  System.Int32 getTaskState(System.Int64 taskId)
  System.String getTaskInfo(System.Int64 taskId)
  System.Int64 getDownloadSpeed(System.Int64 taskId)
  System.Int64 getDownloadedSize(System.Int64 taskId)
  System.Int64 getTotalDownloadSize(System.Int64 taskId)
  System.Int32 getDecompressedProgress(System.Int64 taskId)
  System.Int32 setLanguageType(System.Int32 type)
  System.Int32 setNotificationTitle(System.String title)
  System.Int64 getEstimatedDownloadSize(System.String versionId, System.String downloadFiles)
  System.Int64 getEstimatedUpdateSizeV2(System.String versionId, System.String basePath, System.String rootPath, System.String fileUrl, System.String patchUrl, System.String totalFiles, System.String patchInfo)
END_CLASS

CLASS: Hypergryph.SDK.HGDownloadSDK
TYPE:  class
TOKEN: 0x2000003
FIELDS:
  private   static  Hypergryph.SDK.IHGDownloadSDK   s_dl  // 0x0
METHODS:
  Hypergryph.SDK.IHGDownloadSDK get_downloadSDK()
  System.Int32 Init(System.String config)
  System.Int64 Download(System.String versionId, System.String downloadFiles, System.Boolean useMobileData, System.String decompressPath, System.Boolean needCompress, System.Boolean usePatch, System.String rootPath)
  System.Int64 UpdateV3(System.String versionId, System.String basePath, System.String rootPath, System.String fileUrl, System.String patchUrl, System.String totalFiles, System.String patchInfo, System.Boolean useMobileData, System.Int32 checkType)
  System.Int32 ClearUselessFiles(System.String rootPath, System.String allFiles)
  System.Int32 EnableMobileData(System.Int64 taskId)
  System.Int32 Resume(System.Int64 taskId)
  System.Int32 Cancel(System.Int64 taskId)
  System.Int32 ClearAllTasks()
  System.Int32 Finish(System.Int64 taskId)
  System.Int32 GetSDKState()
  System.Int32 GetTaskState(System.Int64 taskId)
  System.String GetTaskInfo(System.Int64 taskId)
  System.Int64 GetDownloadSpeed(System.Int64 taskId)
  System.Int64 GetDownloadedSize(System.Int64 taskId)
  System.Int64 GetTotalDownloadSize(System.Int64 taskId)
  System.Int32 GetDecompressedProgress(System.Int64 taskId)
  System.Int32 SetLanguageType(System.Int32 type)
  System.Int32 SetNotificationTitle(System.String title)
  System.Int64 GetEstimatedDownloadSize(System.String versionId, System.String downloadFiles)
  System.Int64 GetEstimatedUpdateSizeV2(System.String versionId, System.String basePath, System.String rootPath, System.String fileUrl, System.String patchUrl, System.String totalFiles, System.String patchInfo)
END_CLASS

CLASS: Hypergryph.SDK.HGDownloadSDKPluginWindows
TYPE:  class
TOKEN: 0x2000004
FIELDS:
METHODS:
  System.Int32 HGDLSDKInit(System.String config)
  System.Int64 HGDLSDKDownloadWithPatch(System.String version_id, System.String download_files, System.String decompress_path, System.Boolean need_decompress, System.Boolean use_patch, System.String root_path)
  System.Int32 HGDLSDKClearAllTasks()
  System.Int32 HGDLSDKGetSDKState()
  System.Int32 HGDLSDKGetTaskState(System.Int64 task_id)
  System.Int32 HGDLSDKResume(System.Int64 task_id)
  System.Int32 HGDLSDKCancel(System.Int64 task_id)
  System.Int32 HGDLSDKFinish(System.Int64 task_id)
  System.IntPtr HGDLSDKGetTaskInfo(System.Int64 task_id)
  System.Int64 HGDLSDKGetDownloadSpeed(System.Int64 task_id)
  System.Int64 HGDLSDKGetDownloadedSize(System.Int64 task_id)
  System.Int64 HGDLSDKGetTotalDownloadSize(System.Int64 task_id)
  System.Int32 HGDLSDKGetDecompressedProgress(System.Int64 task_id)
  System.Int64 HGDLSDKGetEstimatedDownloadSize(System.String version_id, System.String download_files)
  System.Void HGDLSDKFree(System.IntPtr pointer)
  System.Int32 HGDLSDKClearUselessFiles(System.String root_path, System.String all_files)
  System.Int64 HGDLSDKGetEstimatedUpdateSizeV2(System.String version_id, System.String base_paths, System.String root_path, System.String file_url_prefix, System.String patch_url_prefixm, System.String total_files, System.String patch_info)
  System.Int64 HGDLSDKUpdateV3(System.String version_id, System.String base_paths, System.String root_path, System.String file_url_prefix, System.String patch_url_prefix, System.String total_files, System.String patch_info, System.Int32 check_type)
  System.Void .ctor()
  System.Int32 init(System.String config)
  System.Int64 download(System.String versionId, System.String downloadFiles, System.String decompressPath, System.Boolean useMobileData, System.Boolean needCompress, System.Boolean usePatch, System.String rootPath)
  System.Int32 enableMobileData(System.Int64 taskId)
  System.Int32 resume(System.Int64 taskId)
  System.Int32 cancel(System.Int64 taskId)
  System.Int32 clearAllTasks()
  System.Int32 finish(System.Int64 taskId)
  System.Int32 getSDKState()
  System.Int32 getTaskState(System.Int64 taskId)
  System.String getTaskInfo(System.Int64 taskId)
  System.Int64 getDownloadSpeed(System.Int64 taskId)
  System.Int64 getDownloadedSize(System.Int64 taskId)
  System.Int64 getTotalDownloadSize(System.Int64 taskId)
  System.Int32 getDecompressedProgress(System.Int64 taskId)
  System.Int32 setLanguageType(System.Int32 type)
  System.Int32 setNotificationTitle(System.String title)
  System.Int64 getEstimatedDownloadSize(System.String versionId, System.String downloadFiles)
  System.Int32 clearUselessFiles(System.String rootPath, System.String allFiles)
  System.Int64 getEstimatedUpdateSizeV2(System.String versionId, System.String basePath, System.String rootPath, System.String fileUrl, System.String patchUrl, System.String totalFiles, System.String patchInfo)
  System.Int64 updateV3(System.String versionId, System.String basePath, System.String rootPath, System.String fileUrl, System.String patchUrl, System.String totalFiles, System.String patchInfo, System.Boolean useMobileData, System.Int32 checkType)
END_CLASS

