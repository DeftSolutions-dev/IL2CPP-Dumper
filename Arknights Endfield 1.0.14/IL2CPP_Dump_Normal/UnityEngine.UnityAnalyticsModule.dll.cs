// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.UnityAnalyticsModule.dll
// Classes:  11
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000003
    public class UpdatedEventHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }

    }

    // TypeToken: 0x2000006
    public struct Tag
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.RemoteConfigSettingsHelper.Tag kUnknown;        // 0x0
        public static UnityEngine.RemoteConfigSettingsHelper.Tag kIntVal;        // 0x0
        public static UnityEngine.RemoteConfigSettingsHelper.Tag kInt64Val;        // 0x0
        public static UnityEngine.RemoteConfigSettingsHelper.Tag kUInt64Val;        // 0x0
        public static UnityEngine.RemoteConfigSettingsHelper.Tag kDoubleVal;        // 0x0
        public static UnityEngine.RemoteConfigSettingsHelper.Tag kBoolVal;        // 0x0
        public static UnityEngine.RemoteConfigSettingsHelper.Tag kStringVal;        // 0x0
        public static UnityEngine.RemoteConfigSettingsHelper.Tag kArrayVal;        // 0x0
        public static UnityEngine.RemoteConfigSettingsHelper.Tag kMixedArrayVal;        // 0x0
        public static UnityEngine.RemoteConfigSettingsHelper.Tag kMapVal;        // 0x0
        public static UnityEngine.RemoteConfigSettingsHelper.Tag kMaxTags;        // 0x0

    }

    // TypeToken: 0x200000A
    public class SessionStateChanged : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Analytics.AnalyticsSessionState sessionState, System.Int64 sessionId, System.Int64 sessionElapsedTime, System.Boolean sessionChanged) { }

    }

    // TypeToken: 0x200000B
    public class IdentityTokenChanged : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.String token) { }

    }

namespace UnityEngine
{

    // TypeToken: 0x2000002
    public class RemoteSettings
    {
        // Fields
        private static UnityEngine.RemoteSettings.UpdatedEventHandler Updated;        // 0x0
        private static System.Action BeforeFetchFromServer;        // 0x8
        private static System.Action<System.Boolean,System.Boolean,System.Int32> Completed;        // 0x10

        // Methods
        private System.Void RemoteSettingsUpdated(System.Boolean wasLastUpdatedFromServer) { }
        private System.Void RemoteSettingsBeforeFetchFromServer() { }
        private System.Void RemoteSettingsUpdateCompleted(System.Boolean wasLastUpdatedFromServer, System.Boolean settingsChanged, System.Int32 response) { }

    }

    // TypeToken: 0x2000004
    public class RemoteConfigSettings
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10
        private System.Action<System.Boolean> Updated;        // 0x18

        // Methods
        private System.Void RemoteConfigSettingsUpdated(UnityEngine.RemoteConfigSettings rcs, System.Boolean wasLastUpdatedFromServer) { }

    }

    // TypeToken: 0x2000005
    public class RemoteConfigSettingsHelper
    {
    }

}

namespace UnityEngine.Analytics
{

    // TypeToken: 0x2000007
    public class ContinuousEvent
    {
    }

    // TypeToken: 0x2000008
    public struct AnalyticsSessionState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Analytics.AnalyticsSessionState kSessionStopped;        // 0x0
        public static UnityEngine.Analytics.AnalyticsSessionState kSessionStarted;        // 0x0
        public static UnityEngine.Analytics.AnalyticsSessionState kSessionPaused;        // 0x0
        public static UnityEngine.Analytics.AnalyticsSessionState kSessionResumed;        // 0x0

    }

    // TypeToken: 0x2000009
    public class AnalyticsSessionInfo
    {
        // Fields
        private static UnityEngine.Analytics.AnalyticsSessionInfo.SessionStateChanged sessionStateChanged;        // 0x0
        private static UnityEngine.Analytics.AnalyticsSessionInfo.IdentityTokenChanged identityTokenChanged;        // 0x8

        // Methods
        private System.Void CallSessionStateChanged(UnityEngine.Analytics.AnalyticsSessionState sessionState, System.Int64 sessionId, System.Int64 sessionElapsedTime, System.Boolean sessionChanged) { }
        private System.Void CallIdentityTokenChanged(System.String token) { }

    }

}

