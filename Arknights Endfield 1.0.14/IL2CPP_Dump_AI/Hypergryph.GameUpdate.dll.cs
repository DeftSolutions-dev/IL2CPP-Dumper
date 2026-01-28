// ========================================================
// Dumped by @desirepro
// Assembly: Hypergryph.GameUpdate.dll
// Classes:  9
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: Hypergryph.SDK.HGGameUpdateCallback
TYPE:  class
TOKEN: 0x2000002
EXTENDS: MonoBehaviour
FIELDS:
  private   static  Hypergryph.SDK.IHGGameUpdateSDKCallbackm_callback  // 0x0
  private   static  System.String                   gameObjectName  // 0x0
  private   static  System.Threading.SynchronizationContextmainThreadContext  // 0x8
  public    static  Hypergryph.SDK.HGGameUpdateCallbacks_instance  // 0x10
METHODS:
  System.Void .ctor()
  System.Void Init(Hypergryph.SDK.IHGGameUpdateSDKCallback callback)
  System.Void onLatestGame(System.String data)
  System.Void runInMainTread(System.Action action)
END_CLASS

CLASS: Hypergryph.SDK.IHGGameUpdateSDKCallback
TYPE:  interface
TOKEN: 0x2000005
FIELDS:
METHODS:
  System.Void onLatestGame(System.String data)
END_CLASS

CLASS: Hypergryph.SDK.IHGGameUpdateSDK
TYPE:  interface
TOKEN: 0x2000006
FIELDS:
METHODS:
  System.Int32 Init(System.String config)
  System.Void GetLatestGame(System.Action<System.String> onResult)
  System.Int64 Update(System.Int32 updateType, System.Boolean useMobileData)
  System.Int32 EnableMobileData(System.Int64 taskId)
  System.Int32 GetTaskState(System.Int64 taskId)
  System.Int32 Resume(System.Int64 taskId)
  System.Int32 CancelAndClear(System.Int64 taskId)
  System.Int32 Cancel(System.Int64 taskId)
  System.Int32 Install(System.Int64 taskId)
  System.Int64 GetDownloadSpeed(System.Int64 taskId)
  System.Int64 GetDownloadedSize(System.Int64 taskId)
  System.Int64 GetTotalDownloadSize(System.Int64 taskId)
  System.Int64 GetEstimatedDownloadSize(System.Int32 updateType)
  System.Int32 SetNotificationTitle(System.String titleConfig)
END_CLASS

CLASS: Hypergryph.SDK.HGGameUpdateSDK
TYPE:  class
TOKEN: 0x2000007
FIELDS:
  private   static  Hypergryph.SDK.IHGGameUpdateSDK s_gu  // 0x0
  private   static  Hypergryph.SDK.IHGGameUpdateSDKCallbackm_callback  // 0x8
  private   static  System.Threading.SynchronizationContextmainThreadContext  // 0x10
METHODS:
  Hypergryph.SDK.IHGGameUpdateSDK get_gameUpdateSDK()
  System.Int32 Init(System.String config, Hypergryph.SDK.IHGGameUpdateSDKCallback callback)
  System.Void GetLatestGame()
  System.Int64 Update(System.Int32 updateType, System.Boolean useMobileData)
  System.Int32 EnableMobileData(System.Int64 taskId)
  System.Int32 GetTaskState(System.Int64 taskId)
  System.Int32 Resume(System.Int64 taskId)
  System.Int32 CancelAndClear(System.Int64 taskId)
  System.Int32 Cancel(System.Int64 taskId)
  System.Int32 Install(System.Int64 taskId)
  System.Int64 GetDownloadSpeed(System.Int64 taskId)
  System.Int64 GetDownloadedSize(System.Int64 taskId)
  System.Int64 GetTotalDownloadSize(System.Int64 taskId)
  System.Int64 GetEstimatedDownloadSize(System.Int32 updateType)
  System.Int32 SetNotificationTitle(System.String titleConfig)
END_CLASS

CLASS: Hypergryph.SDK.HGGameUpdateSDKPluginDefault
TYPE:  class
TOKEN: 0x2000009
FIELDS:
METHODS:
  System.Int32 Init(System.String config)
  System.Void GetLatestGame(System.Action<System.String> onResult)
  System.Int64 Update(System.Int32 updateType, System.Boolean useMobileData)
  System.Int32 EnableMobileData(System.Int64 taskId)
  System.Int32 GetTaskState(System.Int64 taskId)
  System.Int32 Resume(System.Int64 taskId)
  System.Int32 CancelAndClear(System.Int64 taskId)
  System.Int32 Cancel(System.Int64 taskId)
  System.Int32 Install(System.Int64 taskId)
  System.Int64 GetDownloadSpeed(System.Int64 taskId)
  System.Int64 GetDownloadedSize(System.Int64 taskId)
  System.Int64 GetTotalDownloadSize(System.Int64 taskId)
  System.Int64 GetEstimatedDownloadSize(System.Int32 updateType)
  System.Int32 SetNotificationTitle(System.String titleConfig)
  System.Void .ctor()
END_CLASS

