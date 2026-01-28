// ========================================================
// Dumped by @desirepro
// Assembly: Hypergryph.GameUpdate.dll
// Classes:  9
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace Hypergryph.SDK
{

    // TypeToken: 0x2000002
    public class HGGameUpdateCallback : MonoBehaviour
    {
        // Fields
        private static Hypergryph.SDK.IHGGameUpdateSDKCallback m_callback;        // 0x0
        private static System.String gameObjectName;        // 0x0
        private static System.Threading.SynchronizationContext mainThreadContext;        // 0x8
        public static Hypergryph.SDK.HGGameUpdateCallback s_instance;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void Init(Hypergryph.SDK.IHGGameUpdateSDKCallback callback) { }
        private System.Void onLatestGame(System.String data) { }
        private System.Void runInMainTread(System.Action action) { }

    }

    // TypeToken: 0x2000005
    public interface IHGGameUpdateSDKCallback
    {
        // Methods
        private System.Void onLatestGame(System.String data) { }

    }

    // TypeToken: 0x2000006
    public interface IHGGameUpdateSDK
    {
        // Methods
        private System.Int32 Init(System.String config) { }
        private System.Void GetLatestGame(System.Action<System.String> onResult) { }
        private System.Int64 Update(System.Int32 updateType, System.Boolean useMobileData) { }
        private System.Int32 EnableMobileData(System.Int64 taskId) { }
        private System.Int32 GetTaskState(System.Int64 taskId) { }
        private System.Int32 Resume(System.Int64 taskId) { }
        private System.Int32 CancelAndClear(System.Int64 taskId) { }
        private System.Int32 Cancel(System.Int64 taskId) { }
        private System.Int32 Install(System.Int64 taskId) { }
        private System.Int64 GetDownloadSpeed(System.Int64 taskId) { }
        private System.Int64 GetDownloadedSize(System.Int64 taskId) { }
        private System.Int64 GetTotalDownloadSize(System.Int64 taskId) { }
        private System.Int64 GetEstimatedDownloadSize(System.Int32 updateType) { }
        private System.Int32 SetNotificationTitle(System.String titleConfig) { }

    }

    // TypeToken: 0x2000007
    public class HGGameUpdateSDK
    {
        // Fields
        private static Hypergryph.SDK.IHGGameUpdateSDK s_gu;        // 0x0
        private static Hypergryph.SDK.IHGGameUpdateSDKCallback m_callback;        // 0x8
        private static System.Threading.SynchronizationContext mainThreadContext;        // 0x10

        // Methods
        private Hypergryph.SDK.IHGGameUpdateSDK get_gameUpdateSDK() { }
        private System.Int32 Init(System.String config, Hypergryph.SDK.IHGGameUpdateSDKCallback callback) { }
        private System.Void GetLatestGame() { }
        private System.Int64 Update(System.Int32 updateType, System.Boolean useMobileData) { }
        private System.Int32 EnableMobileData(System.Int64 taskId) { }
        private System.Int32 GetTaskState(System.Int64 taskId) { }
        private System.Int32 Resume(System.Int64 taskId) { }
        private System.Int32 CancelAndClear(System.Int64 taskId) { }
        private System.Int32 Cancel(System.Int64 taskId) { }
        private System.Int32 Install(System.Int64 taskId) { }
        private System.Int64 GetDownloadSpeed(System.Int64 taskId) { }
        private System.Int64 GetDownloadedSize(System.Int64 taskId) { }
        private System.Int64 GetTotalDownloadSize(System.Int64 taskId) { }
        private System.Int64 GetEstimatedDownloadSize(System.Int32 updateType) { }
        private System.Int32 SetNotificationTitle(System.String titleConfig) { }

    }

    // TypeToken: 0x2000009
    public class HGGameUpdateSDKPluginDefault, IHGGameUpdateSDK
    {
        // Methods
        private System.Int32 Init(System.String config) { }
        private System.Void GetLatestGame(System.Action<System.String> onResult) { }
        private System.Int64 Update(System.Int32 updateType, System.Boolean useMobileData) { }
        private System.Int32 EnableMobileData(System.Int64 taskId) { }
        private System.Int32 GetTaskState(System.Int64 taskId) { }
        private System.Int32 Resume(System.Int64 taskId) { }
        private System.Int32 CancelAndClear(System.Int64 taskId) { }
        private System.Int32 Cancel(System.Int64 taskId) { }
        private System.Int32 Install(System.Int64 taskId) { }
        private System.Int64 GetDownloadSpeed(System.Int64 taskId) { }
        private System.Int64 GetDownloadedSize(System.Int64 taskId) { }
        private System.Int64 GetTotalDownloadSize(System.Int64 taskId) { }
        private System.Int64 GetEstimatedDownloadSize(System.Int32 updateType) { }
        private System.Int32 SetNotificationTitle(System.String titleConfig) { }
        private System.Void .ctor() { }

    }

}

