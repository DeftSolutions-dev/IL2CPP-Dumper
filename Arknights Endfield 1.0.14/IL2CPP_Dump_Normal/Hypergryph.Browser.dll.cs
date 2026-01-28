// ========================================================
// Dumped by @desirepro
// Assembly: Hypergryph.Browser.dll
// Classes:  22
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000005
    public class OpenCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.String jsonData) { }

    }

    // TypeToken: 0x2000006
    public class EventCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.String jsonData) { }

    }

    // TypeToken: 0x2000008
    public class StatusCode
    {
    }

    // TypeToken: 0x200000E
    public class ExtraInfoCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.String jsonData) { }

    }

    // TypeToken: 0x2000016
    public class OpenCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.String jsonData) { }

    }

namespace Hypergryph.SDK
{

    // TypeToken: 0x2000002
    public interface IHGBulletinSDK
    {
        // Methods
        private System.Void Open(System.String type, System.Action<System.String> onResult) { }
        private System.Void Close() { }
        private System.String GetRedDotState(System.String type) { }
        private System.Void RegisterBulletinEventListener(System.Action<System.String> eventListener) { }

    }

    // TypeToken: 0x2000003
    public class HGBulletinSDK
    {
        // Fields
        private static Hypergryph.SDK.IHGBulletinSDK s_bulletin;        // 0x0

        // Methods
        private Hypergryph.SDK.IHGBulletinSDK get_bulletinSdk() { }
        private System.Void Open(System.String type, System.Action<System.String> onResult) { }
        private System.Void Close() { }
        private System.String GetRedDotState(System.String type) { }
        private System.Void RegisterBulletinEventListener(System.Action<System.String> eventListener) { }

    }

    // TypeToken: 0x2000004
    public class HGBulletinSDKPluginWindows, IHGBulletinSDK
    {
        // Fields
        private static System.Action<System.String> outerOpenCallback;        // 0x0
        private static System.Action<System.String> outerEventCallback;        // 0x8

        // Methods
        private System.Void BulletinSDK_OpenBulletin(System.String type, Hypergryph.SDK.HGBulletinSDKPluginWindows.OpenCallback callback) { }
        private System.Void BulletinSDK_CloseBulletin() { }
        private System.IntPtr BulletinSDK_GetRedDotState(System.String type) { }
        private System.Void BulletinSDK_RegisterBulletinEventListener(Hypergryph.SDK.HGBulletinSDKPluginWindows.EventCallback callback) { }
        private System.Void InnerOpenCallBack(System.String jsonData) { }
        private System.Void InnerEventCallBack(System.String jsonData) { }
        private System.Void .ctor() { }
        private System.Void Finalize() { }
        private System.Void Open(System.String type, System.Action<System.String> onResult) { }
        private System.Void Close() { }
        private System.String GetRedDotState(System.String type) { }
        private System.Void RegisterBulletinEventListener(System.Action<System.String> eventListener) { }

    }

    // TypeToken: 0x2000007
    public class HGBroserSDKConstants
    {
    }

    // TypeToken: 0x2000009
    public interface IHGBrowserSDKCallback
    {
        // Methods
        private System.Void onBrowserEvent(System.String data) { }

    }

    // TypeToken: 0x200000A
    public interface IHGBrowserSDK
    {
        // Methods
        private System.Void Open(System.String url, System.String styleConfig, System.Action<System.String> onResult) { }
        private System.Void Close() { }

    }

    // TypeToken: 0x200000B
    public class HGBrowserSDK
    {
        // Fields
        private static Hypergryph.SDK.IHGBrowserSDK s_browser;        // 0x0

        // Methods
        private Hypergryph.SDK.IHGBrowserSDK get_browserSDK() { }
        private System.Void Open(System.String url, System.String styleConfig, Hypergryph.SDK.IHGBrowserSDKCallback callback) { }
        private System.Void Close() { }

    }

    // TypeToken: 0x200000D
    public class HGBrowserSDKPluginWindows, IHGBrowserSDK
    {
        // Fields
        private static System.Action<System.String> outerCallback;        // 0x0

        // Methods
        private System.Void MiniWebViewSDKLoad(System.String url, System.String styleConfig, Hypergryph.SDK.HGBrowserSDKPluginWindows.ExtraInfoCallback callback) { }
        private System.Void MiniWebViewSDKClose() { }
        private System.Void InnerCallBack(System.String jsonData) { }
        private System.Void .ctor() { }
        private System.Void Finalize() { }
        private System.Void Open(System.String url, System.String styleConfig, System.Action<System.String> onResult) { }
        private System.Void Close() { }

    }

    // TypeToken: 0x200000F
    public class HGBrowerSDKTickEvent : MonoBehaviour
    {
        // Methods
        private System.Void Update() { }
        private System.Void WebViewSDKTickEvent() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000010
    public class HGBrowerSDKTickEventManager
    {
        // Fields
        private UnityEngine.GameObject tickGameObject;        // 0x10
        private Hypergryph.SDK.HGBrowerSDKTickEvent tickEvent;        // 0x18
        private static Hypergryph.SDK.HGBrowerSDKTickEventManager instanceMangaer;        // 0x0

        // Methods
        private Hypergryph.SDK.HGBrowerSDKTickEventManager get_InstanceMangaer() { }
        private System.Void InitTickEvent() { }
        private System.Void UnInitTickEvent() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000011
    public class HGWebPortalState
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000012
    public class HGWebPortalMetadata
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000013
    public interface IHGWebPortalSDK
    {
        // Methods
        private System.Void Open(System.String target, System.String urlParams, System.Action<System.String> onResult) { }

    }

    // TypeToken: 0x2000014
    public class HGWebPortalSDK
    {
        // Fields
        private static Hypergryph.SDK.IHGWebPortalSDK s_webportal;        // 0x0

        // Methods
        private Hypergryph.SDK.IHGWebPortalSDK get_webportalSdk() { }
        private System.Void Open(System.String target, System.String urlParams, System.Action<System.String> onResult) { }

    }

    // TypeToken: 0x2000015
    public class HGWebPortalSDKPluginWindows, IHGWebPortalSDK
    {
        // Fields
        private static System.Action<System.String> outerOpenCallback;        // 0x0

        // Methods
        private System.Void WebPortalSDK_Open(System.String target, System.String urlParams, Hypergryph.SDK.HGWebPortalSDKPluginWindows.OpenCallback callback) { }
        private System.Void InnerOpenCallBack(System.String jsonData) { }
        private System.Void .ctor() { }
        private System.Void Finalize() { }
        private System.Void Open(System.String target, System.String urlParams, System.Action<System.String> onResult) { }

    }

}

