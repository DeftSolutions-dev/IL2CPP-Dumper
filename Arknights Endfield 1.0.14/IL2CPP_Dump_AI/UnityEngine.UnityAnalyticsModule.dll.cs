// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.UnityAnalyticsModule.dll
// Classes:  11
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: UpdatedEventHandler
TYPE:  class
TOKEN: 0x2000003
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
END_CLASS

CLASS: Tag
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.RemoteConfigSettingsHelper.TagkUnknown  // 0x0
  public    static  UnityEngine.RemoteConfigSettingsHelper.TagkIntVal  // 0x0
  public    static  UnityEngine.RemoteConfigSettingsHelper.TagkInt64Val  // 0x0
  public    static  UnityEngine.RemoteConfigSettingsHelper.TagkUInt64Val  // 0x0
  public    static  UnityEngine.RemoteConfigSettingsHelper.TagkDoubleVal  // 0x0
  public    static  UnityEngine.RemoteConfigSettingsHelper.TagkBoolVal  // 0x0
  public    static  UnityEngine.RemoteConfigSettingsHelper.TagkStringVal  // 0x0
  public    static  UnityEngine.RemoteConfigSettingsHelper.TagkArrayVal  // 0x0
  public    static  UnityEngine.RemoteConfigSettingsHelper.TagkMixedArrayVal  // 0x0
  public    static  UnityEngine.RemoteConfigSettingsHelper.TagkMapVal  // 0x0
  public    static  UnityEngine.RemoteConfigSettingsHelper.TagkMaxTags  // 0x0
METHODS:
END_CLASS

CLASS: SessionStateChanged
TYPE:  class
TOKEN: 0x200000A
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Analytics.AnalyticsSessionState sessionState, System.Int64 sessionId, System.Int64 sessionElapsedTime, System.Boolean sessionChanged)
END_CLASS

CLASS: IdentityTokenChanged
TYPE:  class
TOKEN: 0x200000B
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.String token)
END_CLASS

CLASS: UnityEngine.RemoteSettings
TYPE:  class
TOKEN: 0x2000002
FIELDS:
  private   static  UnityEngine.RemoteSettings.UpdatedEventHandlerUpdated  // 0x0
  private   static  System.Action                   BeforeFetchFromServer  // 0x8
  private   static  System.Action<System.Boolean,System.Boolean,System.Int32>Completed  // 0x10
METHODS:
  System.Void RemoteSettingsUpdated(System.Boolean wasLastUpdatedFromServer)
  System.Void RemoteSettingsBeforeFetchFromServer()
  System.Void RemoteSettingsUpdateCompleted(System.Boolean wasLastUpdatedFromServer, System.Boolean settingsChanged, System.Int32 response)
END_CLASS

CLASS: UnityEngine.RemoteConfigSettings
TYPE:  class
TOKEN: 0x2000004
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
  private           System.Action<System.Boolean>   Updated  // 0x18
METHODS:
  System.Void RemoteConfigSettingsUpdated(UnityEngine.RemoteConfigSettings rcs, System.Boolean wasLastUpdatedFromServer)
END_CLASS

CLASS: UnityEngine.RemoteConfigSettingsHelper
TYPE:  class
TOKEN: 0x2000005
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Analytics.ContinuousEvent
TYPE:  class
TOKEN: 0x2000007
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Analytics.AnalyticsSessionState
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Analytics.AnalyticsSessionStatekSessionStopped  // 0x0
  public    static  UnityEngine.Analytics.AnalyticsSessionStatekSessionStarted  // 0x0
  public    static  UnityEngine.Analytics.AnalyticsSessionStatekSessionPaused  // 0x0
  public    static  UnityEngine.Analytics.AnalyticsSessionStatekSessionResumed  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Analytics.AnalyticsSessionInfo
TYPE:  class
TOKEN: 0x2000009
FIELDS:
  private   static  UnityEngine.Analytics.AnalyticsSessionInfo.SessionStateChangedsessionStateChanged  // 0x0
  private   static  UnityEngine.Analytics.AnalyticsSessionInfo.IdentityTokenChangedidentityTokenChanged  // 0x8
METHODS:
  System.Void CallSessionStateChanged(UnityEngine.Analytics.AnalyticsSessionState sessionState, System.Int64 sessionId, System.Int64 sessionElapsedTime, System.Boolean sessionChanged)
  System.Void CallIdentityTokenChanged(System.String token)
END_CLASS

