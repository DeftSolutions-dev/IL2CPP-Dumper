// ========================================================
// Dumped by @desirepro
// Assembly: Hypergryph.Browser.dll
// Classes:  22
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: OpenCallback
TYPE:  class
TOKEN: 0x2000005
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.String jsonData)
END_CLASS

CLASS: EventCallback
TYPE:  class
TOKEN: 0x2000006
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.String jsonData)
END_CLASS

CLASS: StatusCode
TYPE:  class
TOKEN: 0x2000008
FIELDS:
METHODS:
END_CLASS

CLASS: ExtraInfoCallback
TYPE:  class
TOKEN: 0x200000E
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.String jsonData)
END_CLASS

CLASS: OpenCallback
TYPE:  class
TOKEN: 0x2000016
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.String jsonData)
END_CLASS

CLASS: Hypergryph.SDK.IHGBulletinSDK
TYPE:  interface
TOKEN: 0x2000002
FIELDS:
METHODS:
  System.Void Open(System.String type, System.Action<System.String> onResult)
  System.Void Close()
  System.String GetRedDotState(System.String type)
  System.Void RegisterBulletinEventListener(System.Action<System.String> eventListener)
END_CLASS

CLASS: Hypergryph.SDK.HGBulletinSDK
TYPE:  class
TOKEN: 0x2000003
FIELDS:
  private   static  Hypergryph.SDK.IHGBulletinSDK   s_bulletin  // 0x0
METHODS:
  Hypergryph.SDK.IHGBulletinSDK get_bulletinSdk()
  System.Void Open(System.String type, System.Action<System.String> onResult)
  System.Void Close()
  System.String GetRedDotState(System.String type)
  System.Void RegisterBulletinEventListener(System.Action<System.String> eventListener)
END_CLASS

CLASS: Hypergryph.SDK.HGBulletinSDKPluginWindows
TYPE:  class
TOKEN: 0x2000004
FIELDS:
  private   static  System.Action<System.String>    outerOpenCallback  // 0x0
  private   static  System.Action<System.String>    outerEventCallback  // 0x8
METHODS:
  System.Void BulletinSDK_OpenBulletin(System.String type, Hypergryph.SDK.HGBulletinSDKPluginWindows.OpenCallback callback)
  System.Void BulletinSDK_CloseBulletin()
  System.IntPtr BulletinSDK_GetRedDotState(System.String type)
  System.Void BulletinSDK_RegisterBulletinEventListener(Hypergryph.SDK.HGBulletinSDKPluginWindows.EventCallback callback)
  System.Void InnerOpenCallBack(System.String jsonData)
  System.Void InnerEventCallBack(System.String jsonData)
  System.Void .ctor()
  System.Void Finalize()
  System.Void Open(System.String type, System.Action<System.String> onResult)
  System.Void Close()
  System.String GetRedDotState(System.String type)
  System.Void RegisterBulletinEventListener(System.Action<System.String> eventListener)
END_CLASS

CLASS: Hypergryph.SDK.HGBroserSDKConstants
TYPE:  class
TOKEN: 0x2000007
FIELDS:
METHODS:
END_CLASS

CLASS: Hypergryph.SDK.IHGBrowserSDKCallback
TYPE:  interface
TOKEN: 0x2000009
FIELDS:
METHODS:
  System.Void onBrowserEvent(System.String data)
END_CLASS

CLASS: Hypergryph.SDK.IHGBrowserSDK
TYPE:  interface
TOKEN: 0x200000A
FIELDS:
METHODS:
  System.Void Open(System.String url, System.String styleConfig, System.Action<System.String> onResult)
  System.Void Close()
END_CLASS

CLASS: Hypergryph.SDK.HGBrowserSDK
TYPE:  class
TOKEN: 0x200000B
FIELDS:
  private   static  Hypergryph.SDK.IHGBrowserSDK    s_browser  // 0x0
METHODS:
  Hypergryph.SDK.IHGBrowserSDK get_browserSDK()
  System.Void Open(System.String url, System.String styleConfig, Hypergryph.SDK.IHGBrowserSDKCallback callback)
  System.Void Close()
END_CLASS

CLASS: Hypergryph.SDK.HGBrowserSDKPluginWindows
TYPE:  class
TOKEN: 0x200000D
FIELDS:
  private   static  System.Action<System.String>    outerCallback  // 0x0
METHODS:
  System.Void MiniWebViewSDKLoad(System.String url, System.String styleConfig, Hypergryph.SDK.HGBrowserSDKPluginWindows.ExtraInfoCallback callback)
  System.Void MiniWebViewSDKClose()
  System.Void InnerCallBack(System.String jsonData)
  System.Void .ctor()
  System.Void Finalize()
  System.Void Open(System.String url, System.String styleConfig, System.Action<System.String> onResult)
  System.Void Close()
END_CLASS

CLASS: Hypergryph.SDK.HGBrowerSDKTickEvent
TYPE:  class
TOKEN: 0x200000F
EXTENDS: MonoBehaviour
FIELDS:
METHODS:
  System.Void Update()
  System.Void WebViewSDKTickEvent()
  System.Void .ctor()
END_CLASS

CLASS: Hypergryph.SDK.HGBrowerSDKTickEventManager
TYPE:  class
TOKEN: 0x2000010
FIELDS:
  private           UnityEngine.GameObject          tickGameObject  // 0x10
  private           Hypergryph.SDK.HGBrowerSDKTickEventtickEvent  // 0x18
  private   static  Hypergryph.SDK.HGBrowerSDKTickEventManagerinstanceMangaer  // 0x0
METHODS:
  Hypergryph.SDK.HGBrowerSDKTickEventManager get_InstanceMangaer()
  System.Void InitTickEvent()
  System.Void UnInitTickEvent()
  System.Void .ctor()
END_CLASS

CLASS: Hypergryph.SDK.HGWebPortalState
TYPE:  class
TOKEN: 0x2000011
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Hypergryph.SDK.HGWebPortalMetadata
TYPE:  class
TOKEN: 0x2000012
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Hypergryph.SDK.IHGWebPortalSDK
TYPE:  interface
TOKEN: 0x2000013
FIELDS:
METHODS:
  System.Void Open(System.String target, System.String urlParams, System.Action<System.String> onResult)
END_CLASS

CLASS: Hypergryph.SDK.HGWebPortalSDK
TYPE:  class
TOKEN: 0x2000014
FIELDS:
  private   static  Hypergryph.SDK.IHGWebPortalSDK  s_webportal  // 0x0
METHODS:
  Hypergryph.SDK.IHGWebPortalSDK get_webportalSdk()
  System.Void Open(System.String target, System.String urlParams, System.Action<System.String> onResult)
END_CLASS

CLASS: Hypergryph.SDK.HGWebPortalSDKPluginWindows
TYPE:  class
TOKEN: 0x2000015
FIELDS:
  private   static  System.Action<System.String>    outerOpenCallback  // 0x0
METHODS:
  System.Void WebPortalSDK_Open(System.String target, System.String urlParams, Hypergryph.SDK.HGWebPortalSDKPluginWindows.OpenCallback callback)
  System.Void InnerOpenCallBack(System.String jsonData)
  System.Void .ctor()
  System.Void Finalize()
  System.Void Open(System.String target, System.String urlParams, System.Action<System.String> onResult)
END_CLASS

