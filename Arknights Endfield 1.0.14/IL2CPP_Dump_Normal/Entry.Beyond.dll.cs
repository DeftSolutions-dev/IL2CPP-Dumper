// ========================================================
// Dumped by @desirepro
// Assembly: Entry.Beyond.dll
// Classes:  276
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000002
    public class RenderSilhouetteRT : MonoBehaviour
    {
        // Fields
        public UnityEngine.Camera cameraRT;        // 0x18
        public UnityEngine.Camera mainCamera;        // 0x20
        public UnityEngine.Material materialSilhouette;        // 0x28
        private static UnityEngine.Texture s_mSilhouetteRT;        // 0x0
        private static UnityEngine.RenderTexture s_mSilhouetteRth;        // 0x8

        // Methods
        private System.Void Update() { }
        private System.Void OnDestroy() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000019
    public struct FOptions
    {
        // Fields
        public Beyond.LoginContext context;        // 0x10

    }

    // TypeToken: 0x200001A
    public class Dialog : MonoBehaviour
    {
        // Fields
        private Beyond.UI.UISwitchTween m_switchTween;        // 0x18
        private Beyond.LoginController m_controller;        // 0x20
        public System.String showAudioEvent;        // 0x28
        public System.String closeAudioEvent;        // 0x30

        // Methods
        private System.Collections.IEnumerator _CloseCoroutine(System.Action callback) { }
        private System.Boolean TryCloseWithCallback(System.Action callback) { }
        private System.Void Show() { }
        private System.Void OnInit() { }
        private System.Collections.IEnumerator Create(System.String resPath, Beyond.LoginController controller, Beyond.Misc.ObjectRef outRef) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001D
    public class MaskConsts
    {
        // Fields
        public static System.Single DELAY_WAIT_NODE;        // 0x0
        public static System.String INIT;        // 0x0
        public static System.String U8_LOGIN;        // 0x0
        public static System.String FROM_GS_LOGIN;        // 0x0
        public static System.String FROM_CREATE_ROLE;        // 0x0
        public static System.String NET_AGE_TIPS;        // 0x0

    }

    // TypeToken: 0x200001E
    public struct EMaskType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.LoginController.EMaskType None;        // 0x0
        public static Beyond.LoginController.EMaskType Black;        // 0x0
        public static Beyond.LoginController.EMaskType Blur;        // 0x0
        public static Beyond.LoginController.EMaskType White;        // 0x0

    }

    // TypeToken: 0x200001F
    public class MaskCfg
    {
        // Fields
        public UnityEngine.CanvasGroup target;        // 0x10
        public System.Single showDuration;        // 0x18
        public System.Single hideDuration;        // 0x1C

        // Methods
        private Beyond.UI.UISwitchTween CreateTweenAndHide() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000021
    public class NetMaskRef
    {
        // Fields
        private System.String <key>k__BackingField;        // 0x10
        public System.Int32 maskId;        // 0x18
        public System.Boolean isEnabled;        // 0x1C

        // Methods
        private System.String get_key() { }
        private System.Void set_key(System.String value) { }
        private System.Void .ctor(System.String key) { }

    }

    // TypeToken: 0x2000020
    public class MaskCtrl, IDisposable
    {
        // Fields
        private static readonly System.Int32[] CROSS_SCENE_MASKS;        // 0x0
        private Beyond.ListDict<System.Int32,System.Collections.Generic.HashSet<System.String>> m_maskRefs;        // 0x10
        private Beyond.ListDict<System.Int32,Beyond.UI.UISwitchTween> m_maskTweens;        // 0x18
        private Beyond.ListDict<System.String,Beyond.LoginController.MaskCtrl.NetMaskRef> m_netMasks;        // 0x20

        // Methods
        private System.Void .ctor(Beyond.LoginController controller) { }
        private System.Void Dispose() { }
        private System.Void EnableMask(System.String key, Beyond.LoginController.EMaskType type, System.Boolean enable, System.Boolean reset) { }
        private System.Boolean IsMaskTweening(Beyond.LoginController.EMaskType type) { }
        private System.Boolean IsCrossSceneMaskTweening() { }
        private System.Collections.IEnumerator WaitForCrossSceneMasks() { }
        private System.Void EnableNetMask(System.String key, System.Single timeoutSecs) { }
        private System.Void DisableNetMask(System.String key) { }
        private Beyond.UI.UISwitchTween _GetMaskByType(System.Int32 type) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200002D
    public class AssetLoader, IDisposable
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.String,Beyond.Resource.FAssetProxyHandle> m_assetHandles;        // 0x10

        // Methods
        private Beyond.Resource.FAssetProxyHandle CachedLoad(System.String path) { }
        private Beyond.Resource.FAssetProxyHandle CachedLoadAsync(System.String path) { }
        private System.Boolean _CheckDisposedBeforeLoad(System.String path) { }
        private System.Void Dispose() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002E
    public class FlowWithMaskMgr
    {
        // Fields
        private Beyond.LoginContext m_context;        // 0x10
        private System.Collections.Generic.HashSet<System.String> m_activeFlows;        // 0x18

        // Methods
        private System.Void .ctor(Beyond.LoginContext context) { }
        private System.Void StartFlow(Beyond.LoginManager.FFlowWithMask flow) { }
        private System.Collections.IEnumerator _FlowCoroutine(Beyond.LoginManager.FFlowWithMask flow) { }
        private System.Void _OnFlowFinished(Beyond.LoginManager.FFlowWithMask flow) { }

    }

    // TypeToken: 0x2000030
    public struct FFlowWithMask
    {
        // Fields
        public System.String key;        // 0x10
        public Beyond.LoginController.EMaskType maskType;        // 0x18
        public System.Func<System.Boolean> flowAction;        // 0x20
        public Beyond.LoginManager.FFlowCondition condition;        // 0x28
        public System.Single disableDelay;        // 0x30

    }

    // TypeToken: 0x2000031
    public struct FFlowCondition
    {
        // Fields
        private Beyond.Login.LoginWorkFlow.ENode <priTarget>k__BackingField;        // 0x10
        private Beyond.Login.LoginWorkFlow.ENode <secTarget>k__BackingField;        // 0x14

        // Methods
        private Beyond.Login.LoginWorkFlow.ENode get_priTarget() { }
        private System.Void set_priTarget(Beyond.Login.LoginWorkFlow.ENode value) { }
        private Beyond.Login.LoginWorkFlow.ENode get_secTarget() { }
        private System.Void set_secTarget(Beyond.Login.LoginWorkFlow.ENode value) { }
        private System.Void .ctor(Beyond.Login.LoginWorkFlow.ENode target) { }
        private System.Void .ctor(Beyond.Login.LoginWorkFlow.ENode first, Beyond.Login.LoginWorkFlow.ENode second) { }
        private System.Boolean IsTargetMatch(Beyond.Login.LoginWorkFlow.ENode node) { }

    }

    // TypeToken: 0x2000049
    public class SwitchSceneTrigger
    {
        // Fields
        private System.Boolean m_isTweenFinished;        // 0x10
        private System.Action m_switchToScene;        // 0x18

        // Methods
        private System.Void .ctor(System.Action switchToScene) { }
        private System.Void NotifyTweenFinished() { }
        private System.Void _TryTriggerSwitchScene() { }

    }

    // TypeToken: 0x200004A
    public struct SplashConfig
    {
        // Fields
        public UnityEngine.Sprite sprite;        // 0x10
        public System.Boolean blackCoverFadeOut;        // 0x18

    }

    // TypeToken: 0x200004B
    public struct SplashConfigOverride
    {
        // Fields
        public Beyond.GEnums.EnvLang envLang;        // 0x10
        public Beyond.UI.SplashController.SplashConfig[] splashConfigs;        // 0x18

    }

    // TypeToken: 0x200004C
    public struct SplashConfigs
    {
        // Fields
        public Beyond.UI.SplashController.SplashConfig[] splashConfigs;        // 0x10
        public Beyond.UI.SplashController.SplashConfig[] splashConfigsVNMobile;        // 0x18
        public Beyond.UI.SplashController.SplashConfigOverride[] i18nSplashConfigOverrides;        // 0x20

    }

    // TypeToken: 0x2000052
    public struct HttpPostRequest
    {
        // Fields
        public System.String url;        // 0x10
        public System.String param;        // 0x18
        public System.String contentType;        // 0x20
        public System.Collections.Generic.Dictionary<System.String,System.String> header;        // 0x28
        public System.Action<Beyond.SDK.SDKNetUtils.WebHttpResponse> callback;        // 0x30

    }

    // TypeToken: 0x2000053
    public struct HttpGetRequest
    {
        // Fields
        public System.String url;        // 0x10
        public System.Action<Beyond.SDK.SDKNetUtils.WebHttpResponse> callback;        // 0x18

    }

    // TypeToken: 0x2000054
    public struct WebHttpResponse
    {
        // Fields
        public System.Boolean isTimeout;        // 0x10
        public System.Boolean isError;        // 0x11
        public System.Int64 responseCode;        // 0x18
        public System.Collections.Generic.Dictionary<System.String,System.String> header;        // 0x20
        public System.String text;        // 0x28
        public System.Byte[] data;        // 0x30
        public System.String error;        // 0x38

    }

    // TypeToken: 0x2000055
    public struct HTTPOptType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.SDK.SDKNetUtils.HTTPOptType GET;        // 0x0
        public static Beyond.SDK.SDKNetUtils.HTTPOptType POST;        // 0x0

    }

    // TypeToken: 0x2000056
    public struct HTTPConfig
    {
        // Fields
        public System.String url;        // 0x10
        public System.String body;        // 0x18
        public System.String contentType;        // 0x20
        public System.Collections.Generic.Dictionary<System.String,System.String> header;        // 0x28
        public Beyond.SDK.SDKNetUtils.HTTPOptType optType;        // 0x30
        public System.Action<Beyond.SDK.SDKNetUtils.WebHttpResponse> callback;        // 0x38

    }

    // TypeToken: 0x2000057
    public class HTTPImpl
    {
        // Methods
        private System.Collections.IEnumerator DoHTTP(Beyond.SDK.SDKNetUtils.HTTPConfig config) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000058
    public class BeyondHttp : HTTPImpl
    {
        // Methods
        private System.Collections.IEnumerator DoHTTP(Beyond.SDK.SDKNetUtils.HTTPConfig config) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005C
    public struct FHGSDKInit
    {
        // Fields
        public System.Boolean isIniting;        // 0x10
        public System.Boolean isInited;        // 0x11

    }

    // TypeToken: 0x200005D
    public class CaptchaHandler : SDKCaptchaHandler
    {
        // Fields
        private static System.Int32 FAILED;        // 0x0
        private System.Int64 m_flag;        // 0x10
        private System.String m_desc;        // 0x18

        // Methods
        private System.Collections.IEnumerator FetchCaptchaCoroutine(System.String captchaParams, U8.SDK.SDKCaptchaHandler.Result outResult) { }
        private System.Void OnGT3Message(System.Collections.Generic.Dictionary<System.String,System.Object> msg) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000067
    public class AppVersionRespone
    {
        // Fields
        public System.Int32 action;        // 0x10
        public System.Int32 state;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006F
    public class WorkProcess : CustomYieldInstruction, IDisposable
    {
        // Fields
        private Beyond.Login.LoginCreateRoleNode m_closure;        // 0x10
        private System.Boolean m_isFinished;        // 0x18

        // Methods
        private System.Void .ctor(Beyond.Login.LoginCreateRoleNode closure) { }
        private System.Boolean get_keepWaiting() { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x2000078
    public struct CodeType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Login.LoginGameUpdater.CodeType CODE_2103;        // 0x0
        public static Beyond.Login.LoginGameUpdater.CodeType CODE_2105;        // 0x0
        public static Beyond.Login.LoginGameUpdater.CodeType CODE_2200;        // 0x0
        public static Beyond.Login.LoginGameUpdater.CodeType CODE_2201;        // 0x0
        public static Beyond.Login.LoginGameUpdater.CodeType CODE_2202;        // 0x0
        public static Beyond.Login.LoginGameUpdater.CodeType CODE_2203;        // 0x0
        public static Beyond.Login.LoginGameUpdater.CodeType CODE_2204;        // 0x0
        public static Beyond.Login.LoginGameUpdater.CodeType CODE_2205;        // 0x0
        public static Beyond.Login.LoginGameUpdater.CodeType CODE_2206;        // 0x0
        public static Beyond.Login.LoginGameUpdater.CodeType CODE_2207;        // 0x0
        public static Beyond.Login.LoginGameUpdater.CodeType CODE_2208;        // 0x0
        public static Beyond.Login.LoginGameUpdater.CodeType CODE_2209;        // 0x0

    }

    // TypeToken: 0x2000079
    public struct UpdateType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Login.LoginGameUpdater.UpdateType FullUpdate;        // 0x0
        public static Beyond.Login.LoginGameUpdater.UpdateType IncrementalUpdate;        // 0x0
        public static Beyond.Login.LoginGameUpdater.UpdateType GoToBilibile;        // 0x0
        public static Beyond.Login.LoginGameUpdater.UpdateType GoToTaptap;        // 0x0
        public static Beyond.Login.LoginGameUpdater.UpdateType GoToAppStore;        // 0x0
        public static Beyond.Login.LoginGameUpdater.UpdateType GoToGooglePlay;        // 0x0
        public static Beyond.Login.LoginGameUpdater.UpdateType GoToSamsungStore;        // 0x0
        public static Beyond.Login.LoginGameUpdater.UpdateType GoToRustore;        // 0x0

    }

    // TypeToken: 0x200007A
    public struct UpdateCode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Login.LoginGameUpdater.UpdateCode Success;        // 0x0

    }

    // TypeToken: 0x200007B
    public struct UpdateAction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Login.LoginGameUpdater.UpdateAction Invalid;        // 0x0
        public static Beyond.Login.LoginGameUpdater.UpdateAction Latest;        // 0x0
        public static Beyond.Login.LoginGameUpdater.UpdateAction ForcedUpdate;        // 0x0
        public static Beyond.Login.LoginGameUpdater.UpdateAction OptionalUpdate;        // 0x0
        public static Beyond.Login.LoginGameUpdater.UpdateAction Error;        // 0x0
        public static Beyond.Login.LoginGameUpdater.UpdateAction Congestion;        // 0x0

    }

    // TypeToken: 0x200007C
    public class HGLatestGameInfo
    {
        // Fields
        public System.Int32 code;        // 0x10
        public System.String version;        // 0x18
        public System.Int32 action;        // 0x20
        public System.Int32 updateType;        // 0x24
        public System.String updateInfo;        // 0x28
        public System.Int32 state;        // 0x30

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007D
    public class NotificationTitleConfig
    {
        // Fields
        public System.String downloading;        // 0x10
        public System.String pause;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007E
    public class HGUpdateConfig
    {
        // Fields
        public System.String downloadPath;        // 0x10

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007F
    public struct Options
    {
        // Fields
        public Beyond.Login.NetUsagePolicy netUsagePolicy;        // 0x10
        public System.Action<System.String,System.Action> alertDialog;        // 0x18
        public Beyond.LoginContext loginContext;        // 0x20

    }

    // TypeToken: 0x2000080
    public class Result
    {
        // Fields
        public System.Boolean needRetry;        // 0x10
        public System.String errorInfo;        // 0x18
        public System.Int32 code;        // 0x20
        public System.Boolean auditing;        // 0x24

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000081
    public class Context
    {
        // Fields
        public System.Int64 taskId;        // 0x10
        public System.String errorInfo;        // 0x18
        public System.String logError;        // 0x20
        public System.Boolean needClear;        // 0x28
        public Beyond.Login.LoginGameUpdater.HGLatestGameInfo gameInfo;        // 0x30
        private System.Boolean <complete>k__BackingField;        // 0x38
        private System.Int32 <code>k__BackingField;        // 0x3C

        // Methods
        private System.Boolean get_complete() { }
        private System.Void set_complete(System.Boolean value) { }
        private System.Int32 get_code() { }
        private System.Void set_code(System.Int32 value) { }
        private System.Void CompleteWithCode(System.Int32 pCode) { }
        private System.Void UncompleteWithCode(System.Int32 pCode) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008E
    public class EnterGameServiceFlow : CustomYieldInstruction
    {
        // Fields
        private Beyond.LoginContext m_context;        // 0x10
        private Beyond.Login.LoginGSNode m_curNode;        // 0x18
        private Beyond.Misc.ObjectRef m_dialogBlocker;        // 0x20
        private System.Int32 m_state;        // 0x28

        // Methods
        private System.Boolean get_keepWaiting() { }
        private System.Void .ctor(Beyond.Login.LoginGSNode node) { }
        private System.Void MarkAborting() { }
        private System.Void EnterGame() { }
        private System.Boolean IsInterruptable() { }
        private System.Boolean TryInterrupt() { }
        private System.Collections.IEnumerator _EnterGameCoroutine() { }
        private System.Collections.IEnumerator _NetConnectAndGSLogin(System.String uid, System.String token, Beyond.Misc.ObjectRef loginRespRef) { }
        private System.String _ExtractErrorInfo(Beyond.Network.HttpSender.Result result, System.String keyErrorWithCode, System.String keyTimeout) { }
        private System.Collections.IEnumerator _YieldAlertError(System.String errorInfo) { }
        private System.Collections.IEnumerator _SaveCurrentUserToServerConfig(System.String uid) { }
        private System.Collections.IEnumerator _MockManualSelectServer(System.String uid) { }
        private System.Collections.IEnumerator _OnAuthError(System.Object rejectInfo) { }
        private System.Void _ReLoginWhenErrorEncountered() { }
        private System.Void _GlobalLoginSucBusiness(Proto.MSG_B1 msg) { }
        private System.Boolean <_EnterGameCoroutine>b__11_0() { }

    }

    // TypeToken: 0x2000099
    public interface IProgress
    {
        // Methods
        private System.Double GetTotal() { }
        private System.Double GetCurrent() { }
        private System.String GetInfo() { }

    }

    // TypeToken: 0x200009A
    public class SimpleProgress, IProgress
    {
        // Fields
        public System.Double current;        // 0x10

        // Methods
        private System.Double GetCurrent() { }
        private System.Double GetTotal() { }
        private System.String GetInfo() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009C
    public class HotUpdateInfo
    {
        // Fields
        public Beyond.Resource.HotUpdate.FResourceDiff resDiff;        // 0x10
        public Beyond.Resource.HotUpdate.LocalResPref localResPref;        // 0x50

        // Methods
        private System.Boolean CheckIfNeedReload() { }
        private System.Boolean HasChangedByType(Beyond.VFS.EVFSBlockType type) { }
        private System.Boolean HasAssetsChanged() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009D
    public class WorkContext
    {
        // Fields
        public Beyond.Login.LoginHotUpdater.HotUpdateInfo updateInitial;        // 0x10
        public Beyond.Login.LoginHotUpdater.HotUpdateInfo updateMain;        // 0x18
        public System.String vitalError;        // 0x20
        public System.Boolean reboot;        // 0x28
        public Beyond.Login.NetUsagePolicy netUsagePolicy;        // 0x30
        public Beyond.Resource.HotUpdate.ResourceIndex resIndex;        // 0x38
        private System.Boolean <illegalItemsInLocalRes>k__BackingField;        // 0x40

        // Methods
        private System.Boolean get_illegalItemsInLocalRes() { }
        private System.Void set_illegalItemsInLocalRes(System.Boolean value) { }
        private System.Void MarkIllegalItemsInLocalRes() { }
        private Beyond.Login.LoginHotUpdater.HotUpdateInfo GetHotUpdateInfo(System.Boolean isInitial) { }
        private System.Boolean HasChangedByType(Beyond.VFS.EVFSBlockType type) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B6
    public struct EUnit
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Login.LoginProgress.FDownloadSize.EUnit NONE;        // 0x0
        public static Beyond.Login.LoginProgress.FDownloadSize.EUnit B;        // 0x0
        public static Beyond.Login.LoginProgress.FDownloadSize.EUnit KB;        // 0x0
        public static Beyond.Login.LoginProgress.FDownloadSize.EUnit MB;        // 0x0

    }

    // TypeToken: 0x20000B5
    public struct FDownloadSize
    {
        // Fields
        private static System.Double MB;        // 0x0
        private static System.Double KB;        // 0x0
        private Beyond.Login.LoginProgress.FDownloadSize.EUnit m_unit;        // 0x10
        private System.Single m_displayCurrent;        // 0x14
        private System.Single m_displayTotal;        // 0x18
        private System.Single m_displaySpeed;        // 0x1C
        public System.String displayInfo;        // 0x20
        private System.Single m_current;        // 0x28
        private System.Single m_total;        // 0x2C

        // Methods
        private System.Void SetProgress(System.Double current, System.Double total) { }
        private System.Void SetIdle() { }
        private System.Void SetSize(System.Double current, System.Double total, System.Double speed) { }
        private Beyond.Login.LoginProgress.FDownloadSize.EUnit _PickUnit(System.Double number) { }
        private System.Single _DisplayWithUnit(System.Double number, Beyond.Login.LoginProgress.FDownloadSize.EUnit unit) { }
        private System.String _FormatDisplayInfo(System.Single current, System.Single total, Beyond.Login.LoginProgress.FDownloadSize.EUnit unit) { }
        private System.String _FormatSpeedInfo(System.Single speed, Beyond.Login.LoginProgress.FDownloadSize.EUnit unit) { }
        private System.String _FormatProgressInfo(System.Single current, System.Single total) { }

    }

    // TypeToken: 0x20000D1
    public struct FAgeTipsPolicy
    {
        // Fields
        public System.Boolean canOpenDetail;        // 0x10
        public System.Boolean displayCN;        // 0x11
        public System.Boolean displayKR;        // 0x12

        // Methods
        private System.Boolean get_display() { }

    }

    // TypeToken: 0x20000D6
    public class Node
    {
        // Fields
        private Beyond.LoginContext <context>k__BackingField;        // 0x10
        private Beyond.Login.LoginWorkFlow <workflow>k__BackingField;        // 0x18

        // Methods
        private Beyond.LoginContext get_context() { }
        private System.Void set_context(Beyond.LoginContext value) { }
        private Beyond.Login.LoginWorkFlow get_workflow() { }
        private System.Void set_workflow(Beyond.Login.LoginWorkFlow value) { }
        private System.Void Init(Beyond.LoginContext context, Beyond.Login.LoginWorkFlow workflow) { }
        private System.Void Dispose() { }
        private Beyond.Login.LoginWorkFlow.ENode get_type() { }
        private UnityEngine.CustomYieldInstruction Work() { }
        private System.Boolean CanCancel() { }
        private UnityEngine.CustomYieldInstruction Cancel() { }
        private System.Void OnInit() { }
        private System.Void OnDispose() { }
        private System.Boolean OnEvent(Beyond.ELoginEvent evt, System.Object param) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D7
    public struct ENode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Login.LoginWorkFlow.ENode None;        // 0x0
        public static Beyond.Login.LoginWorkFlow.ENode CheckForUpdate;        // 0x0
        public static Beyond.Login.LoginWorkFlow.ENode SDKInit;        // 0x0
        public static Beyond.Login.LoginWorkFlow.ENode GameUpdate;        // 0x0
        public static Beyond.Login.LoginWorkFlow.ENode Init;        // 0x0
        public static Beyond.Login.LoginWorkFlow.ENode U8Login;        // 0x0
        public static Beyond.Login.LoginWorkFlow.ENode HotUpdate;        // 0x0
        public static Beyond.Login.LoginWorkFlow.ENode ResCheck;        // 0x0
        public static Beyond.Login.LoginWorkFlow.ENode Preload;        // 0x0
        public static Beyond.Login.LoginWorkFlow.ENode PreloadPostDelay;        // 0x0
        public static Beyond.Login.LoginWorkFlow.ENode Trans2GsLogin;        // 0x0
        public static Beyond.Login.LoginWorkFlow.ENode GsLogin;        // 0x0
        public static Beyond.Login.LoginWorkFlow.ENode CreateRole;        // 0x0
        public static Beyond.Login.LoginWorkFlow.ENode Finish;        // 0x0

    }

    // TypeToken: 0x20000D8
    public interface IWorkerUpdateOnce
    {
        // Methods
        private System.Void Worker_UpdateOnce() { }

    }

    // TypeToken: 0x20000D9
    public interface IEventReceiver
    {
        // Methods
        private System.Void OnEvent(Beyond.ELoginEvent evt, System.Object param) { }

    }

    // TypeToken: 0x20000DA
    public class Worker, IDisposable
    {
        // Fields
        private System.Collections.Generic.HashSet<Beyond.Login.LoginWorkFlow.IWorkerUpdateOnce> m_updateOnce;        // 0x10
        private System.Collections.Generic.List<Beyond.Login.LoginWorkFlow.IWorkerUpdateOnce> m_buffer;        // 0x18
        private UnityEngine.CustomYieldInstruction m_curWork;        // 0x20
        private System.Boolean <isCancelled>k__BackingField;        // 0x28
        private System.Boolean <isDisposed>k__BackingField;        // 0x29
        private Beyond.Login.LoginWorkFlow.Node <curNode>k__BackingField;        // 0x30

        // Methods
        private System.Boolean get_isCancelled() { }
        private System.Void set_isCancelled(System.Boolean value) { }
        private System.Boolean get_isDisposed() { }
        private System.Void set_isDisposed(System.Boolean value) { }
        private Beyond.Login.LoginWorkFlow.Node get_curNode() { }
        private System.Void set_curNode(Beyond.Login.LoginWorkFlow.Node value) { }
        private System.Boolean Cancel() { }
        private System.Void Dispose() { }
        private System.Void SetCurNode(Beyond.Login.LoginWorkFlow.Node node) { }
        private System.Boolean UpdateOnce(Beyond.Login.LoginWorkFlow.IWorkerUpdateOnce inst) { }
        private System.Void TickInEmptyFrame() { }
        private System.Collections.IEnumerator Work(UnityEngine.CustomYieldInstruction work) { }
        private System.Void _InternalTick() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DC
    public struct FWork
    {
        // Fields
        public static readonly Beyond.Login.LoginWorkFlow.FWork IDLE;        // 0x0
        private System.Boolean <didFallback>k__BackingField;        // 0x10
        private System.Int32 <nodeIndex>k__BackingField;        // 0x14
        private System.Boolean <isWorking>k__BackingField;        // 0x18

        // Methods
        private System.Boolean get_didFallback() { }
        private System.Void set_didFallback(System.Boolean value) { }
        private System.Int32 get_nodeIndex() { }
        private System.Void set_nodeIndex(System.Int32 value) { }
        private System.Boolean get_isWorking() { }
        private System.Void set_isWorking(System.Boolean value) { }
        private System.Void MarkFallback(System.Int32 newIndex) { }
        private System.Boolean ConsumeFallback() { }
        private System.Void MoveNextIndex() { }
        private Beyond.Login.LoginWorkFlow.FWork Start() { }
        private Beyond.Login.LoginWorkFlow.ENode get_curNode() { }
        private System.Boolean WorkEnd() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000E7
    public struct Options
    {
        // Fields
        public System.Int64 minBytesToNotifyCarrier;        // 0x10

    }

    // TypeToken: 0x20000EA
    public struct EState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Login.LoginSceneAnimCtrl.EState NONE;        // 0x0
        public static Beyond.Login.LoginSceneAnimCtrl.EState A1;        // 0x0
        public static Beyond.Login.LoginSceneAnimCtrl.EState A2;        // 0x0

    }

    // TypeToken: 0x20000F0
    public struct FParams
    {
        // Fields
        public System.String text;        // 0x10
        public System.Action onConfirm;        // 0x18

    }

    // TypeToken: 0x20000F5
    public struct Style
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Login.LoginJudgeDialog.Style Center;        // 0x0
        public static Beyond.Login.LoginJudgeDialog.Style Left;        // 0x0

    }

    // TypeToken: 0x20000F6
    public struct FParams
    {
        // Fields
        public System.String text;        // 0x10
        public System.Action onPositive;        // 0x18
        public System.Action onNegative;        // 0x20
        public System.String btnPositive;        // 0x28
        public System.String btnNegative;        // 0x30
        public Beyond.Login.LoginJudgeDialog.Style style;        // 0x38

    }

    // TypeToken: 0x20000FA
    public struct FOptions
    {
        // Fields
        public System.String fixedUID;        // 0x10
        public Beyond.LoginContext context;        // 0x18

        // Methods
        private System.Boolean IsUIDFixed() { }

    }

    // TypeToken: 0x20000FE
    public class ChildPanel : MonoBehaviour, ILoginContextReceiver
    {
        // Fields
        private Beyond.UI.UISwitchTween <switchTween>k__BackingField;        // 0x18
        private Beyond.LoginContext <context>k__BackingField;        // 0x20

        // Methods
        private Beyond.UI.UISwitchTween get_switchTween() { }
        private System.Void set_switchTween(Beyond.UI.UISwitchTween value) { }
        private Beyond.LoginContext get_context() { }
        private System.Void set_context(Beyond.LoginContext value) { }
        private System.Void OnLoginContext(Beyond.LoginContext context) { }
        private System.Void OnInit() { }
        private System.Void OnDestroy() { }
        private System.Void SetPanelVisibleByAnimSwitchTween(Beyond.UI.UIAnimationWrapper anim, System.Boolean isVisible, System.Boolean forceReset) { }
        private System.Void SetPanelVisibleByFadeSwitchTween(UnityEngine.CanvasGroup canvasGroup, System.Boolean isVisible, System.Boolean forceReset) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000100
    public struct DelayInfo
    {
        // Fields
        public UnityEngine.Color color;        // 0x10
        public System.Int32 colorCount;        // 0x20
        public System.Int32 delayMax;        // 0x24
        public System.String text;        // 0x28

    }

    // TypeToken: 0x2000108
    public struct FParams
    {
        // Fields
        public System.Action onConfirm;        // 0x10

    }

    // TypeToken: 0x2000109
    public class VocResInfo
    {
        // Fields
        public System.String nameTextId;        // 0x10
        public Beyond.VFS.EVFSBlockType type;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200010C
    public class GameSettingSetterItem`1
    {
        // Fields
        private readonly System.String m_settingId;        // 0x0
        private readonly System.Action<T> m_otherSystemSet;        // 0x0

        // Methods
        private System.Void .ctor(System.String settingId) { }
        private System.Void .ctor(System.String settingId, System.Action<T> otherSystemSet) { }
        private System.Void Set(T value, System.Boolean forceSetOtherSystem) { }

    }

    // TypeToken: 0x200010D
    public class GameSettingSetterItem`2
    {
        // Fields
        private readonly System.String m_mainSettingId;        // 0x0
        private readonly System.String m_settingId1;        // 0x0
        private readonly System.String m_settingId2;        // 0x0
        private readonly System.Action<T1,T2> m_otherSystemSet;        // 0x0

        // Methods
        private System.Void .ctor(System.String mainSettingId, System.String settingId1, System.String settingId2, System.Action<T1,T2> otherSystemSet) { }
        private System.Void Set(T1 value1, T2 value2, System.Boolean forceSetOtherSystem) { }

    }

    // TypeToken: 0x2000110
    public struct __StaticArrayInitTypeSize=52
    {
    }

namespace Beyond
{

    // TypeToken: 0x2000004
    public class GameApp : MonoBehaviour, ILuaCallCSharp
    {
        // Fields
        private Beyond.GameStateMachine m_stateMachine;        // 0x18
        private static Beyond.GameApp <instance>k__BackingField;        // 0x0
        private System.Boolean m_hasFocus;        // 0x20
        private System.Boolean m_needCallLuaFocus;        // 0x21
        private System.Boolean m_pauseStatus;        // 0x22
        private System.Boolean m_needCallLuaPause;        // 0x23

        // Methods
        private Beyond.GameApp get_instance() { }
        private System.Void set_instance(Beyond.GameApp value) { }
        private Beyond.GameState get_currentState() { }
        private System.Void SwitchState(Beyond.GameState state) { }
        private System.Void Awake() { }
        private System.Void _RegisterLuaAfterGCEvent() { }
        private System.Void Update() { }
        private System.Void LateUpdate() { }
        private System.Void OnApplicationQuit() { }
        private System.Void OnApplicationFocus(System.Boolean hasFocus) { }
        private System.Void _OnApplicationFocusForLua() { }
        private System.Void OnApplicationPause(System.Boolean pauseStatus) { }
        private System.Void _OnApplicationPauseForLua() { }
        private System.Void OnDestroy() { }
        private System.Void _Init() { }
        private System.Void _UnInit() { }
        private System.Void _InitGameStateMachine() { }
        private System.Void _UnInitGameStateMachine() { }
        private System.Void QuitGame(System.Int32 exitCode) { }
        private System.Void RefreshScreenResolution() { }
        private System.Void _OnSystemDisplaySizeChanged() { }
        private System.Void _OnSystemScreenSizeChanged(Beyond.EventData<System.Boolean,System.Boolean>& data) { }
        private System.Collections.IEnumerator _InitSecuritySDK() { }
        private System.Void _OnApplicationPauseForSecurity(System.Boolean pauseStatus) { }
        private System.Collections.IEnumerator _FetchRemoteConfigUtilSuc() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000007
    public interface IMemoryPackProxy
    {
        // Methods
        private System.Void Init() { }

    }

    // TypeToken: 0x2000008
    public class MemoryPackProxyModule
    {
        // Fields
        private static Beyond.IMemoryPackProxy s_memoryPackProxy;        // 0x0

        // Methods
        private System.Void RegisterProxy(Beyond.IMemoryPackProxy memoryPackProxy) { }
        private Beyond.IMemoryPackProxy GetMemoryPackProxy() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000009
    public class GameInitState : GameStateBase
    {
        // Methods
        private Beyond.GameState get_stateId() { }
        private System.Void .ctor(Beyond.GameStateMachine stateMachine) { }
        private System.Void OnEnter(Beyond.GameState fromStateId) { }
        private System.Void OnLeave(Beyond.GameState toStateId) { }
        private System.Void _DoInit() { }
        private System.Void _InitInitialResourceManager(Beyond.VFS.VirtualFileSystem.BlockValidator& blockValidator) { }
        private System.Boolean _CheckIfLocalInitialAssetsValid(Beyond.Resource.HotUpdate.LocalResPref& outputLocalResPref, Beyond.VFS.VirtualFileSystem.BlockValidator& blockValidator) { }
        private System.Void _InitAPPDefaultCulture() { }
        private System.Void _PreInitGameSetting() { }
        private System.Void _InitGameSetting() { }
        private System.Void <>iFixBaseProxy_OnEnter(Beyond.GameState P0) { }
        private System.Void <>iFixBaseProxy_OnLeave(Beyond.GameState P0) { }

    }

    // TypeToken: 0x200000A
    public class GameLoginState : GameStateBase
    {
        // Methods
        private Beyond.GameState get_stateId() { }
        private System.Void .ctor(Beyond.GameStateMachine stateMachine) { }
        private System.Void OnEnter(Beyond.GameState fromStateId) { }
        private System.Void OnLeave(Beyond.GameState toStateId) { }
        private System.Void _TryStartLoginWorkflow() { }
        private System.Void <>iFixBaseProxy_OnEnter(Beyond.GameState P0) { }
        private System.Void <>iFixBaseProxy_OnLeave(Beyond.GameState P0) { }

    }

    // TypeToken: 0x200000B
    public class GameMainState : GameStateBase
    {
        // Fields
        private System.Boolean m_isFirstEnter;        // 0x18

        // Methods
        private Beyond.GameState get_stateId() { }
        private System.Void .ctor(Beyond.GameStateMachine stateMachine) { }
        private System.Void OnEnter(Beyond.GameState fromStateId) { }
        private System.Void OnLeave(Beyond.GameState toStateId) { }
        private System.Void ReleaseMainGame(Beyond.GameState toStateId) { }
        private System.Void _ClearUtils() { }
        private System.Void <>iFixBaseProxy_OnEnter(Beyond.GameState P0) { }
        private System.Void <>iFixBaseProxy_OnLeave(Beyond.GameState P0) { }

    }

    // TypeToken: 0x200000C
    public class GamePreloadState : GameStateBase
    {
        // Fields
        private Beyond.Cfg.Tables.AsyncLoadTask m_asyncTask;        // 0x18

        // Methods
        private Beyond.GameState get_stateId() { }
        private System.Void .ctor(Beyond.GameStateMachine stateMachine) { }
        private System.Void OnEnter(Beyond.GameState fromStateId) { }
        private System.Void OnLeave(Beyond.GameState toStateId) { }
        private System.Collections.IEnumerator _DoPreload() { }
        private System.Void _InitGameSettingStateInPreload() { }
        private System.Void <>iFixBaseProxy_OnEnter(Beyond.GameState P0) { }
        private System.Void <>iFixBaseProxy_OnLeave(Beyond.GameState P0) { }

    }

    // TypeToken: 0x200000E
    public class GameQuitState : GameStateBase
    {
        // Methods
        private Beyond.GameState get_stateId() { }
        private System.Void .ctor(Beyond.GameStateMachine stateMachine) { }
        private System.Void OnEnter(Beyond.GameState fromStateId) { }
        private System.Void OnLeave(Beyond.GameState toStateId) { }
        private System.Void DoQuit() { }
        private System.Void <>iFixBaseProxy_OnEnter(Beyond.GameState P0) { }
        private System.Void <>iFixBaseProxy_OnLeave(Beyond.GameState P0) { }

    }

    // TypeToken: 0x200000F
    public class GameStartState : GameStateBase
    {
        // Methods
        private Beyond.GameState get_stateId() { }
        private System.Void .ctor(Beyond.GameStateMachine stateMachine) { }
        private System.Void OnEnter(Beyond.GameState fromStateId) { }
        private System.Void OnLeave(Beyond.GameState toStateId) { }
        private System.Void _OnEnterMainGame() { }
        private System.Void <_OnEnterMainGame>b__5_0() { }
        private System.Void <>iFixBaseProxy_OnEnter(Beyond.GameState P0) { }
        private System.Void <>iFixBaseProxy_OnLeave(Beyond.GameState P0) { }

    }

    // TypeToken: 0x2000010
    public class GameStateBase, ISimpleStateNode`1, ILuaCallCSharp
    {
        // Fields
        protected readonly Beyond.GameStateMachine m_stateMachine;        // 0x10

        // Methods
        private System.Void .ctor(Beyond.GameStateMachine stateMachine) { }
        private Beyond.GameState get_stateId() { }
        private System.Void OnEnter(Beyond.GameState fromStateId) { }
        private System.Void OnLeave(Beyond.GameState toStateId) { }
        private System.Void OnTick(System.Single deltaTime) { }

    }

    // TypeToken: 0x2000011
    public class GameStateMachine : SimpleEnumStateMachine`1, IGameStateMachine, ILuaCallCSharp
    {
        // Fields
        private readonly Beyond.GameApp <app>k__BackingField;        // 0x30

        // Methods
        private Beyond.GameApp get_app() { }
        private Beyond.GameState get_curState() { }
        private System.Void .ctor(Beyond.GameApp gameApp) { }
        private System.Void _RegisterStates() { }
        private System.Boolean CheckCanReturnToLoginState() { }
        private System.Collections.IEnumerator ReturnToLoginState() { }

    }

    // TypeToken: 0x2000013
    public class GlobalInitializer
    {
        // Methods
        private System.Void InitGlobalConfig() { }

    }

    // TypeToken: 0x2000014
    public interface IHotFixCommon
    {
    }

    // TypeToken: 0x2000015
    public interface IHotFixPatchManagerProxy : IHotFixCommon
    {
        // Methods
        private System.Void InitManager() { }
        private System.Void ReleaseManager() { }
        private System.Void PatchInitAssemble() { }
        private System.Void PatchRemoteInitAssemble() { }
        private System.Void PatchMainAssemble() { }
        private System.Void PatchRemoteMainAssemble() { }

    }

    // TypeToken: 0x2000016
    public class HotFixPatchModules
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.Type,Beyond.IHotFixCommon> s_hotFixModules;        // 0x0

        // Methods
        private System.Void Register(T module) { }
        private System.Void UnRegister() { }
        private T GetModule() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000017
    public class InitialPathDef
    {
        // Fields
        public static System.String SPLASH_SCENE_PATH;        // 0x0
        public static System.String LOGIN_SCENE_PATH;        // 0x0
        public static System.String LOGIN_SK_ACTOR_M;        // 0x0
        public static System.String LOGIN_SK_ACTOR_F;        // 0x0
        public static System.String LOGIN_SK_ACTOR_NO_GENDER;        // 0x0
        public static System.String LOGIN_MOCK_UID_PANEL;        // 0x0
        public static System.String LOGIN_CONTROLLER_PATH;        // 0x0
        public static System.String LOGIN_ROOT_PANEL_PATH;        // 0x0
        public static System.String LOGIN_ALERT_DIALOG_PATH;        // 0x0
        public static System.String LOGIN_JUDGE_DIALOG_PATH;        // 0x0
        public static System.String LOGIN_VOC_RES_SELECT_DIALOG_PATH;        // 0x0

    }

    // TypeToken: 0x2000018
    public class LoginController : MonoBehaviour, ILoginBinder`1
    {
        // Fields
        private UnityEngine.Transform _uiFunc;        // 0x18
        private UnityEngine.Transform _uiDialog;        // 0x20
        private Beyond.UI.UIButton _versionBtn;        // 0x28
        private Beyond.Login.LoginDecorateUI _uiDecorate;        // 0x30
        private Beyond.LoginController.MaskCfg _maskBlur;        // 0x38
        private Beyond.LoginController.MaskCfg _maskBlack;        // 0x40
        private Beyond.LoginController.MaskCfg _maskWhite;        // 0x48
        private System.Single _enterGamePanelPredelay;        // 0x50
        private UnityEngine.Canvas _uiRootCanvas;        // 0x58
        private Beyond.UI.UICanvasScaleHelper _uiRootCanvasScaleHelper;        // 0x60
        private UnityEngine.Canvas _uiDecoCanvas;        // 0x68
        private Beyond.UI.UICanvasScaleHelper _uiDecoCanvasScaleHelper;        // 0x70
        private System.Boolean m_isInited;        // 0x78
        private Beyond.LoginController.FOptions m_options;        // 0x80
        private Beyond.LatchUtils.InvokeWhenUnlock m_startLatch;        // 0x88
        private Beyond.LatchUtils.InvokeWhenUnlock m_initLatch;        // 0x90
        private Beyond.Login.LoginWorkFlow.ENode m_lastNode;        // 0x98
        private Beyond.LoginController.MaskCtrl m_maskCtrl;        // 0xA0
        private Beyond.Login.LoginRootPanel m_rootPanel;        // 0xA8
        private System.Collections.IEnumerator m_mockLoginRoutine;        // 0xB0
        private System.Action<System.String> m_onMockLogin;        // 0xB8

        // Methods
        private Beyond.LoginController.MaskCtrl get_maskCtrl() { }
        private Beyond.Login.LoginRootPanel get_rootPanel() { }
        private System.Void Awake() { }
        private System.Void Start() { }
        private System.Single GetEnterGamePanelPredelay() { }
        private System.Void OnValueChanged(Beyond.Login.LoginViewModel viewModel) { }
        private System.Void InitUI(Beyond.LoginController.FOptions options) { }
        private System.Void InvokeWhenStart(System.Action callback) { }
        private System.Collections.IEnumerator BeforeDestroy() { }
        private System.Collections.IEnumerator _InstantiateUIFromRes(System.String resPath, UnityEngine.Transform parent, Beyond.Misc.ObjectRef objRef) { }
        private System.Void _InitImpl() { }
        private System.Collections.IEnumerator _InitCoroutine() { }
        private System.Void _InitVersionBtn() { }
        private System.Void add_m_onMockLogin(System.Action<System.String> value) { }
        private System.Void remove_m_onMockLogin(System.Action<System.String> value) { }
        private System.Void MockLoginWithCallback(System.String fixedUID, System.Action<System.String> callback) { }
        private System.Collections.IEnumerator _MockLoginCoroutine(System.String fixedUID) { }
        private System.Void .ctor() { }
        private System.Void <MockLoginWithCallback>b__44_0() { }

    }

    // TypeToken: 0x2000028
    public class LoginContext, IDisposable
    {
        // Fields
        private Beyond.LoginController m_controller;        // 0x10
        private System.Boolean m_isDisposed;        // 0x18
        private System.Boolean <quickStart>k__BackingField;        // 0x19
        private System.Boolean <firstLogin>k__BackingField;        // 0x1A
        private Beyond.Login.LoginWorkFlow <workflow>k__BackingField;        // 0x20
        private Beyond.Login.LoginViewProperty <viewProp>k__BackingField;        // 0x28
        private Beyond.LoginManager.AssetLoader <loader>k__BackingField;        // 0x30
        private Beyond.LoginManager.FlowWithMaskMgr <flowWithMask>k__BackingField;        // 0x38
        private Beyond.Login.NetUsagePolicy <netUsagePolicy>k__BackingField;        // 0x40
        private Beyond.Login.LoginGameUpdater <gameUpdater>k__BackingField;        // 0x48

        // Methods
        private System.Boolean get_quickStart() { }
        private System.Void set_quickStart(System.Boolean value) { }
        private System.Boolean get_firstLogin() { }
        private System.Void set_firstLogin(System.Boolean value) { }
        private Beyond.Login.LoginWorkFlow get_workflow() { }
        private System.Void set_workflow(Beyond.Login.LoginWorkFlow value) { }
        private Beyond.Login.LoginViewProperty get_viewProp() { }
        private System.Void set_viewProp(Beyond.Login.LoginViewProperty value) { }
        private Beyond.LoginManager.AssetLoader get_loader() { }
        private System.Void set_loader(Beyond.LoginManager.AssetLoader value) { }
        private Beyond.LoginManager.FlowWithMaskMgr get_flowWithMask() { }
        private System.Void set_flowWithMask(Beyond.LoginManager.FlowWithMaskMgr value) { }
        private Beyond.Login.NetUsagePolicy get_netUsagePolicy() { }
        private System.Void set_netUsagePolicy(Beyond.Login.NetUsagePolicy value) { }
        private Beyond.Login.LoginGameUpdater get_gameUpdater() { }
        private System.Void set_gameUpdater(Beyond.Login.LoginGameUpdater value) { }
        private Beyond.LoginController ViewOnlyController() { }
        private System.Void Init(System.Boolean quickStart, Beyond.LoginController controller, Beyond.Login.LoginWorkFlow workflow, Beyond.Login.LoginViewProperty viewProp, Beyond.LoginManager.AssetLoader loader, Beyond.LoginManager.FlowWithMaskMgr flowWithMask, Beyond.Login.NetUsagePolicy netUsagePolicy, Beyond.Login.LoginGameUpdater gameUpdater) { }
        private System.Void StartCoroutine(System.Collections.IEnumerator routine) { }
        private System.Void StopCoroutine(System.Collections.IEnumerator routine) { }
        private System.Void SendEvent(Beyond.ELoginEvent evt, System.Object param) { }
        private System.Void Dispose() { }
        private System.Void ShutDown() { }
        private System.Boolean IsWorkflowDisposed() { }
        private System.Boolean IsDisposed() { }
        private System.Void _DisposeImpl() { }
        private System.Collections.IEnumerator _DisposeCoroutine(Beyond.LoginController legacyController, System.Action disposeAction) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002A
    public struct ELoginEvent
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.ELoginEvent None;        // 0x0
        public static Beyond.ELoginEvent V2C_U8Login;        // 0x0
        public static Beyond.ELoginEvent V2C_EnterGame;        // 0x0
        public static Beyond.ELoginEvent V2C_Logout;        // 0x0
        public static Beyond.ELoginEvent V2C_ResourceRepair;        // 0x0
        public static Beyond.ELoginEvent V2C_OpenAgeTips;        // 0x0
        public static Beyond.ELoginEvent V2C_CloseAgeTips;        // 0x0
        public static Beyond.ELoginEvent V2C_OpenServerSelect;        // 0x0
        public static Beyond.ELoginEvent V2C_CloseServerSelect;        // 0x0
        public static Beyond.ELoginEvent V2C_SelectServer;        // 0x0
        public static Beyond.ELoginEvent V2C_ConfirmServer;        // 0x0
        public static Beyond.ELoginEvent V2C_Relogin;        // 0x0
        public static Beyond.ELoginEvent V2C_ReplayGsLogin;        // 0x0
        public static Beyond.ELoginEvent C2V_PrepareGsLogin;        // 0x0

    }

    // TypeToken: 0x200002B
    public class LoginTextDefines
    {
        // Fields
        public static System.String CS_LOGIN_CONN_FAIL;        // 0x0
        public static System.String HOTUPDATE_INDEX_FAILED;        // 0x0
        public static System.String HOTUPDATE_IO_FAILED;        // 0x0
        public static System.String HOTUPDATE_CHECK_VERSION;        // 0x0
        public static System.String HOTUPDATE_DOWNLOADING;        // 0x0
        public static System.String HOTUPDATE_DECOMPRESSING;        // 0x0
        public static System.String HOTUPDATE_DOWNLOAD_ERROR;        // 0x0
        public static System.String HOTUPDATE_DOWNLOAD_DISKFULL;        // 0x0
        public static System.String HOTUPDATE_LOCAL_RES_CHECK;        // 0x0
        public static System.String HOTUPDATE_PRELOAD_RES;        // 0x0
        public static System.String HOTUPDATE_INVALID_LOCAL_FILES;        // 0x0
        public static System.String HOTUPDATE_INIT_RES_CHANGED;        // 0x0
        public static System.String HOTUPDATE_DOWNLOAD_IO_ERROR;        // 0x0
        public static System.String HOTUPDATE_DOWNLOAD_DATA_CHECK_ERROR;        // 0x0
        public static System.String HOTUPDATE_DOWNLOAD_START_DOWNLOAD_ERROR;        // 0x0
        public static System.String HOTUPDATE_DECOMPRESS_ERROR;        // 0x0
        public static System.String REMOTE_CFG_GAME_CFG_ERROR;        // 0x0
        public static System.String REMOTE_CFG_GAME_CFG_TIMEOUT;        // 0x0
        public static System.String REMOTE_CFG_NETWORK_CFG_ERROR;        // 0x0
        public static System.String REMOTE_CFG_NETWORK_CFG_TIMEOUT;        // 0x0
        public static System.String REMOTE_CFG_RES_VERSION_ERROR;        // 0x0
        public static System.String REMOTE_CFG_RES_VERSION_TIMEOUT;        // 0x0
        public static System.String REMOTE_CFG_GAME_VERSION_ERROR;        // 0x0
        public static System.String REMOTE_CFG_GAME_VERSION_TIMEOUT;        // 0x0
        public static System.String LOGIN_JUDGE_EXIT_GAME;        // 0x0
        public static System.String LOGIN_JUDGE_LOGOUT;        // 0x0
        public static System.String LOGIN_JUDGE_RES_REPAIR;        // 0x0
        public static System.String LOGIN_AGE_TIPS_FAILED;        // 0x0
        public static System.String LOGIN_TXT_DIALOG_CONFIRM;        // 0x0
        public static System.String LOGIN_TXT_DIALOG_CANCEL;        // 0x0
        public static System.String LOGIN_AUDIO_LANG_CN;        // 0x0
        public static System.String LOGIN_AUDIO_LANG_JP;        // 0x0
        public static System.String LOGIN_AUDIO_LANG_EN;        // 0x0
        public static System.String LOGIN_AUDIO_LANG_KR;        // 0x0
        public static System.String LOGIN_TXT_NETWORK_ERROR;        // 0x0
        public static System.String LOGIN_GAME_UPGRADED;        // 0x0
        public static System.String LOGIN_TXT_SERVER_CLOSED;        // 0x0
        public static System.String LOGIN_TXT_SERVER_CLOSED_DATETIME;        // 0x0
        public static System.String LOGIN_TXT_USR_BAN_DATETIME;        // 0x0
        public static System.String LOGIN_TXT_HOTUPDATE_CLEAR_DOWNLOAD_FOLDER;        // 0x0
        public static System.String LOGIN_GET_SERVER_LIST_FAILED;        // 0x0
        public static System.String LOGIN_TEXT_SERVER_ZONE_FAILED;        // 0x0
        public static System.String LOGIN_TEXT_GET_APP_VERSION_FAILED;        // 0x0
        public static System.String LOGIN_TEXT_ALERT_CARRIER_NETWORK;        // 0x0
        public static System.String LOGIN_TEXT_ERROR_DOWNLOAD_HOTUPDATE_RES_FAILED;        // 0x0
        public static System.String LOGIN_SHADER_WARM_UP_PRELOAD_RES;        // 0x0
        public static System.String LOGIN_GAME_UPDATE_TIPS_DOWNLOADING;        // 0x0
        public static System.String LOGIN_GAME_UPDATE_TIPS_PAUSE;        // 0x0
        public static System.String LOGIN_GAME_UPDATE_ALERT_NEWER;        // 0x0
        public static System.String LOGIN_GAME_UPDATE_ERROR_DISK_FULL;        // 0x0
        public static System.String LOGIN_GAME_UPDATE_ALERT_SUC;        // 0x0
        public static System.String LOGIN_GAME_UPDATE_ERROR_CHECK_FOR_UPDATE_COMMON;        // 0x0
        public static System.String LOGIN_GAME_UPDATE_ERROR_COMMON;        // 0x0
        public static System.String LOGIN_GAME_UPDATE_TITLE;        // 0x0
        public static System.String LOGIN_GOTO_SHOP_FOR_GAME_UPDATE;        // 0x0
        public static System.String LOGIN_SDK_INIT_FAILED;        // 0x0
        public static System.String LOGIN_DOWNLOADING_SPEED_HINT;        // 0x0
        public static System.String LOGIN_SDK_INIT_FAILED_NEED_QUIT_GAME;        // 0x0
        public static System.String LOGIN_NETWORK_CONGESTION_TITLE;        // 0x0
        public static System.String LOGIN_LOW_SCORE_DEVICE_TIP;        // 0x0

    }

    // TypeToken: 0x200002C
    public class LoginManager : ExplicitSingleton`1
    {
        // Fields
        public static System.Int64 MIN_BYTES_SIZE_TO_NOTIFY_IF_NOT_WIFI;        // 0x0
        private Beyond.Resource.ISceneHandle m_splashSceneHandle;        // 0x10
        private Beyond.Resource.ISceneHandle m_sceneHandle;        // 0x18
        private Beyond.LoginContext m_context;        // 0x20
        private Beyond.LatchUtils.InvokeWhenUnlock m_workflowFinishLatch;        // 0x28
        private Beyond.LatchUtils.InvokeWhenUnlock m_workflowStartLatch;        // 0x30
        private System.Collections.Generic.Queue<System.WeakReference<Beyond.Login.LoginSceneComponent>> m_pendingSceneComps;        // 0x38
        private System.Collections.Generic.HashSet<Beyond.Login.LoginSceneComponent> m_sceneComps;        // 0x40
        private System.Boolean <quickStart>k__BackingField;        // 0x48
        private System.Object m_dialogBlocker;        // 0x50

        // Methods
        private System.Void RecordSplashSceneHandle(Beyond.Resource.ISceneHandle splashSceneHandle) { }
        private System.Void _ReleaseSplashScene() { }
        private System.Boolean get_quickStart() { }
        private System.Void set_quickStart(System.Boolean value) { }
        private System.Boolean get_firstLogin() { }
        private System.Collections.IEnumerator InitCoroutine(System.Boolean quickStart) { }
        private System.Boolean IsReLoginInProgress() { }
        private System.Void OnReleaseMainGame() { }
        private System.Boolean IsWorkflowInProgress() { }
        private System.Collections.IEnumerator _ClearLoginSceneCoroutine() { }
        private System.Void Clear() { }
        private System.Void _ReleaseLoginScene() { }
        private System.Void InvokeWhenWorkFlowFinished(System.Action callback) { }
        private System.Void SceneComponentOnly_Bind(Beyond.Login.LoginSceneComponent comp) { }
        private System.Void _BindPendingComponents() { }
        private System.Void ToggleLoginBindingGroup(System.Boolean enable) { }
        private System.Void AlertDialog(System.String desc, System.Action callback) { }
        private System.Void VocResSelDialog(System.Action callback) { }
        private System.Collections.IEnumerator VocResSelDialogWithConfirm() { }
        private System.Collections.IEnumerator AlertDialogWithResult(System.String desc, Beyond.Misc.ObjectRef outRef, System.Action<Beyond.Misc.ObjectRef> callback) { }
        private System.Collections.IEnumerator AlertDialogWithConfirm(System.String desc) { }
        private System.Void JudgeDialog(System.String desc, System.Action onPositive, System.Action onNegative) { }
        private System.Void JudgeDialog(Beyond.Login.LoginJudgeDialog.FParams param) { }
        private System.Void _StartShowJudgeDialogCoroutine(Beyond.Login.LoginJudgeDialog.FParams param) { }
        private System.Collections.IEnumerator _ShowDialogCoroutine(System.String resPath, TParam param, System.Action<TDialog,TParam> setParamFunc) { }
        private System.Void MockLoginWithCallback(System.Action<System.String> callback) { }
        private System.Void MockManualSelectServer(System.String uid, System.Action callback) { }
        private System.Void _Init() { }
        private System.Boolean IsLoginSceneLoading() { }
        private System.Void _PrepareBeforeLoginProcess() { }
        private System.Collections.IEnumerator _LoginWorkFlowCoroutine(Beyond.LoginController nullableCtrl) { }
        private System.Void _ClearWorkflowAndContext(System.Boolean isShutDownMode) { }
        private System.Collections.IEnumerator FetchRemoteConfigUtilSuc(Beyond.Cfg.IRemoteConfig config, System.String configEnv, System.String keyErrorWithCode, System.String keyTimeout) { }
        private System.String _ExtractErrorInfo(Beyond.Network.HttpSender.Result result, System.String keyErrorWithCode, System.String keyTimeout) { }
        private System.Void DevOnlyCheckEnableLocalResMode(System.Boolean& enable) { }
        private System.Void DevOnlyUseLocalResVersion(Beyond.Cfg.ResVersionDevCfg config, System.Boolean& useLocalResVersion) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000040
    public class VietnamLoginAgePanel : MonoBehaviour
    {
        // Fields
        private static System.String PREFAB_PATH;        // 0x0
        private static Beyond.Resource.FAssetProxyHandle s_prefabAssetHandle;        // 0x0
        public static UnityEngine.GameObject instance;        // 0x18

        // Methods
        private System.Void Init() { }
        private System.Void UnInit() { }
        private System.Void _Init() { }
        private System.Void _UnInit() { }
        private System.Void OnApplicationQuit() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000041
    public class VietnamLoginAgeTipsPanelCtrl : MonoBehaviour
    {
        // Fields
        private Beyond.UI.UIDrag _UIDrag;        // 0x18
        private Beyond.UI.UIButton _tipsBtn;        // 0x20
        private Beyond.UI.UIButton _circleBtn;        // 0x28
        private Beyond.UI.UIState.UIStateController _stateController;        // 0x30

        // Methods
        private System.Void Awake() { }
        private System.Void _SetStateTips(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void _SetStateCircle(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000042
    public class RenderPipelineDataLoader
    {
        // Fields
        public static Beyond.Resource.FAssetProxyHandle s_globalSettings;        // 0x0
        public static Beyond.Resource.FAssetProxyHandle s_pipelineAsset;        // 0x14

        // Methods
        private System.Void LoadRpData() { }

    }

    // TypeToken: 0x2000043
    public class TailGameLoop : MonoBehaviour
    {
        // Methods
        private System.Void Update() { }
        private System.Void LateUpdate() { }
        private System.Void .ctor() { }

    }

}

namespace Beyond.Login
{

    // TypeToken: 0x2000066
    public class LoginCheckForUpdateNode : Node
    {
        // Fields
        private Beyond.Login.LoginGameUpdater m_sdk;        // 0x20
        private System.Boolean m_checkSuccess;        // 0x28
        private static System.String REQUEST_API;        // 0x0
        private static System.String REQUEST_PARAM_FORMAT;        // 0x0
        private static System.String REQUEST_URL_FORMAT;        // 0x0
        private static System.String PRAM_SOURCE;        // 0x0

        // Methods
        private Beyond.Login.LoginWorkFlow.ENode get_type() { }
        private UnityEngine.CustomYieldInstruction Work() { }
        private System.Collections.IEnumerator _CheckForUpdateCoroutine() { }
        private System.Collections.IEnumerator AlertNoMatchDeviceBeforeLogin() { }
        private System.Collections.IEnumerator _CheckForUpdateCoroutineMobile() { }
        private System.Collections.IEnumerator _CheckForUpdateCoroutinePC() { }
        private System.Collections.IEnumerator _CheckForUpdatePC() { }
        private System.Collections.IEnumerator _GetOnlineAppVersion(Beyond.Misc.ObjectRef outRef) { }
        private System.String _GetRequestPram() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006E
    public class LoginCreateRoleNode : Node
    {
        // Fields
        public static System.String LUA_SYS_NAME;        // 0x0
        private Beyond.Login.LoginCreateRoleNode.WorkProcess m_activeProcess;        // 0x20

        // Methods
        private Beyond.Login.LoginWorkFlow.ENode get_type() { }
        private System.Void OnDispose() { }
        private System.Boolean CanCancel() { }
        private UnityEngine.CustomYieldInstruction Work() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnDispose() { }
        private System.Boolean <>iFixBaseProxy_CanCancel() { }

    }

    // TypeToken: 0x2000070
    public class LoginDownloadTask, IDisposable
    {
        // Fields
        private System.Boolean m_isDownloadFinished;        // 0x10
        private Beyond.SDK.HGDownloader.TaskHandler m_downloadTask;        // 0x18
        private Beyond.Resource.HotUpdate.FResourceDiff m_resDiff;        // 0x20
        private System.String m_patchInfo;        // 0x60
        private System.Collections.IEnumerator m_mockCoroutine;        // 0x68
        private System.Boolean m_isInitial;        // 0x70
        private System.String <vitalError>k__BackingField;        // 0x78
        private Beyond.Login.NetUsagePolicy m_netUsagePolicy;        // 0x80

        // Methods
        private System.Void .ctor(Beyond.Resource.HotUpdate.FResourceDiff resDiff, System.String patchInfo, System.Boolean isInitial, Beyond.Login.NetUsagePolicy netUsagePolicy) { }
        private System.String get_vitalError() { }
        private System.Void set_vitalError(System.String value) { }
        private Beyond.SDK.HGDownloader.DownloadProgress GetDownloadProgress() { }
        private System.Single GetDecompressProgress() { }
        private Beyond.SDK.HGDownloader.WorkState GetWorkState() { }
        private System.Boolean Tick() { }
        private System.Void Dispose() { }
        private System.Void _StartDownload() { }
        private System.Void _StartDownloadImpl() { }
        private System.Collections.Generic.List<Beyond.SDK.HGFileInfo> _GetFileList(System.String rootUrl) { }
        private System.Void _OnDownloadFinish() { }
        private System.Boolean _OnDownloadError(Beyond.SDK.HGRetCodeType codeType, System.Int32 errorCode) { }
        private System.Void _OnDownloadPaused(Beyond.SDK.HGDownloader.PauseReason reason) { }

    }

    // TypeToken: 0x2000073
    public class LoginGameSettingInitializer : MonoBehaviour
    {
        // Fields
        private static System.Boolean s_isInitialized;        // 0x0
        private UnityEngine.RectTransform m_rectTransform;        // 0x18
        private Beyond.UI.UICanvasScaleHelper m_canvasScaleHelper;        // 0x20

        // Methods
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void _TryInitializeComponents() { }
        private System.Void _InitGameSettingStateInLogin() { }
        private System.Void _InitGameSettingNotchPadding() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000074
    public class LoginGameUpdateNode : Node
    {
        // Fields
        private Beyond.Login.LoginGameUpdater m_sdk;        // 0x20
        private Beyond.Login.NetUsagePolicy m_netUsagePolicy;        // 0x28

        // Methods
        private Beyond.Login.LoginWorkFlow.ENode get_type() { }
        private UnityEngine.CustomYieldInstruction Work() { }
        private System.Collections.IEnumerator _GameUpdateCoroutine() { }
        private System.Collections.IEnumerator _GameUpdateCoroutineMobileImpl() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000077
    public class LoginGameUpdater
    {
        // Fields
        private static System.Single COOLDOWN_INSTALL;        // 0x0
        private static System.Int32 ERROR_CODE_NETWORK;        // 0x0
        private static System.Int32 ERROR_INIT_FAILED;        // 0x0
        private static System.Int32 ERROR_DESERIALIZE_FAILED;        // 0x0
        public static System.Int32 ERROR_ACTION;        // 0x0
        private static System.Int32 WAIT_TIME_SECONDS_MIN;        // 0x0
        private static System.Int32 WAIT_TIME_SECONDS_MAX;        // 0x0
        private Beyond.Login.LoginGameUpdater.Options m_options;        // 0x10
        private Beyond.SDK.IGameUpdateInterface m_sdkImpl;        // 0x28
        private System.Boolean m_hasUpdateAlerted;        // 0x30
        private Beyond.Login.LoginGameUpdater.Context m_context;        // 0x38
        private Beyond.Login.LoginProgress m_progress;        // 0x40
        private Beyond.Login.LoginHotUpdateProp m_hotUpdateProp;        // 0x48

        // Methods
        private System.Void Clear() { }
        private System.Void .ctor(Beyond.Login.LoginGameUpdater.Options options) { }
        private System.Collections.IEnumerator CheckLastGameInfo(Beyond.Login.LoginGameUpdater.Result result) { }
        private System.Collections.IEnumerator DoUpdate(Beyond.Login.LoginGameUpdater.Result result) { }
        private System.Collections.IEnumerator _GetLastGameInfo(Beyond.Login.LoginGameUpdater.Context context) { }
        private System.Collections.IEnumerator _UpdateGame(Beyond.Login.LoginGameUpdater.Context context) { }
        private System.Collections.IEnumerator _DoTaskUpdating(Beyond.Login.LoginGameUpdater.Context context) { }
        private System.Void _OnDownloadStart() { }
        private System.Void _OnDownloadProgress(System.Int64 curSize, System.Int64 totalSize, System.Int64 speed) { }
        private System.Collections.IEnumerator _YieldErrorAlert(System.String desc) { }
        private System.Collections.IEnumerator _YieldCheckNetUsagePolicy(System.Int64 downloadSize) { }
        private System.Collections.IEnumerator _WaitForTaskCancel(System.Int64 taskId) { }
        private System.Void _CreateDirectoryIfNotExists(System.String folderPath) { }
        private System.Void ClearWaitProgress() { }
        private System.Void ShowWaitProgress() { }
        private System.Int32 GetNoAlertCode() { }
        private System.Single GetWaitTime() { }

    }

    // TypeToken: 0x200008D
    public class LoginGSNode : Node
    {
        // Fields
        private static System.Int32 FLOW_NONE;        // 0x0
        private static System.Int32 FLOW_WORKING;        // 0x0
        private static System.Int32 FLOW_FINISH;        // 0x0
        private static System.Int32 FLOW_ABORTING;        // 0x0
        private Beyond.Login.LoginGSNode.EnterGameServiceFlow m_flow;        // 0x20

        // Methods
        private Beyond.Login.LoginWorkFlow.ENode get_type() { }
        private UnityEngine.CustomYieldInstruction Work() { }
        private System.Boolean OnEvent(Beyond.ELoginEvent evt, System.Object param) { }
        private System.Collections.IEnumerator _ConfirmServer() { }
        private System.Void _FallbackToInitWithMask(System.Boolean bLogoutAccount) { }
        private System.Void _OnEventLogout() { }
        private System.Void _OnEventResourceRepair() { }
        private System.Boolean _LogoutToInitNode() { }
        private System.Boolean _FallbackToInitNodeImpl() { }
        private System.Boolean _FallbackToResRepairImpl() { }
        private System.Void .ctor() { }
        private System.Void <_OnEventLogout>b__12_0() { }
        private System.Void <_OnEventResourceRepair>b__13_0() { }
        private System.Boolean <>iFixBaseProxy_OnEvent(Beyond.ELoginEvent P0, System.Object P1) { }

    }

    // TypeToken: 0x2000097
    public class LoginHotUpdateProp : LoginProperty`1
    {
        // Methods
        private System.Void .ctor(Beyond.Login.LoginWorkFlow workflow) { }

    }

    // TypeToken: 0x2000098
    public class LoginHotUpdateModel
    {
        // Fields
        public System.String title;        // 0x10
        public System.String desc;        // 0x18
        public Beyond.Login.LoginHotUpdateModel.IProgress progress;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009B
    public class LoginHotUpdater : CustomYieldInstruction, IDisposable
    {
        // Fields
        private static System.Int32 MODE_SKIP;        // 0x0
        private static System.Int32 MODE_DOWNLOAD;        // 0x0
        private static System.Int32 MODE_LOCAL;        // 0x0
        private static System.Boolean s_hasInitialAssetChanged;        // 0x0
        private Beyond.LoginContext m_loginCxt;        // 0x10
        private System.Collections.IEnumerator m_mainRoutine;        // 0x18
        private Beyond.Login.LoginProgress m_progress;        // 0x20
        private Beyond.Login.LoginHotUpdateProp m_hotupdateProp;        // 0x28
        private Beyond.Login.LoginDownloadTask m_downloadTask;        // 0x30
        private Beyond.Login.LoginLocalResTask m_localResTask;        // 0x38
        private System.Boolean m_resRepairMode;        // 0x40
        public static System.String URL_GET_SPLIT;        // 0x0

        // Methods
        private System.Void MarkInitialAssetChanged() { }
        private System.Boolean CheckInitialAssetChanged() { }
        private System.Void MarkNeedClearFolder(System.Boolean isInitial) { }
        private System.Boolean NeedClearFolder() { }
        private System.Void MarkClearSuccessed() { }
        private System.Void .ctor(Beyond.LoginContext context, System.Boolean resRepairMode) { }
        private System.Boolean get_keepWaiting() { }
        private System.Void Dispose() { }
        private Beyond.Login.LoginHotUpdater StartHotUpdate(Beyond.LoginContext context, System.Boolean resRepairMode) { }
        private System.Collections.IEnumerator _Work() { }
        private System.Collections.IEnumerator _CreateMainCoroutine(Beyond.Login.LoginHotUpdater.WorkContext workContext) { }
        private System.Collections.IEnumerator _MainCoroutineModeSkip(Beyond.Login.LoginHotUpdater.WorkContext context) { }
        private System.Collections.IEnumerator _MainCoroutineModeLocal(Beyond.Login.LoginHotUpdater.WorkContext context) { }
        private System.Collections.IEnumerator _UpdateResVersion(Beyond.Login.LoginHotUpdater.WorkContext workContext) { }
        private System.String _GetOnlineResVersion(System.Boolean isInitial) { }
        private System.String ResourceRootUrl(System.String version, System.Boolean isInitial) { }
        private System.Collections.IEnumerator _UpdateResVersionDev(Beyond.Login.LoginHotUpdater.WorkContext workContext) { }
        private System.Collections.IEnumerator _UpdateResVersionProd(Beyond.Login.LoginHotUpdater.WorkContext workContext) { }
        private System.String _ResourcePatchUrl(System.String version, System.Boolean isInitial) { }
        private System.String _ResourceFileUrl(System.String version, System.Boolean isInitial) { }
        private System.String _ResourcePatchRootUrl(System.String version, System.Boolean isInitial) { }
        private System.String _ResourceIndexUrl(System.String version, System.Boolean isInitial) { }
        private System.Collections.IEnumerator _MainCoroutineModeDownload(Beyond.Login.LoginHotUpdater.WorkContext workContext) { }
        private System.Collections.IEnumerator _ReloadResourceIndexes(Beyond.Login.LoginHotUpdater.WorkContext workContext) { }
        private System.Collections.IEnumerator _LoadOrDownloadResIndex(System.String onlineVer, System.Boolean isInitial, Beyond.Misc.ObjectRef resIndexRef) { }
        private System.Collections.IEnumerator _GenResIndex(System.String onlineVer, System.Boolean isInitial, Beyond.Login.LoginHotUpdater.WorkContext workContext) { }
        private System.Collections.IEnumerator _GenRiff(System.String onlineVer, System.Boolean isInitial, Beyond.Login.LoginHotUpdater.WorkContext workContext) { }
        private System.Collections.IEnumerator _GenLocalRef(System.String onlineVer, System.Boolean isInitial, Beyond.Login.LoginHotUpdater.WorkContext workContext) { }
        private System.Collections.IEnumerator _CheckAndDownloadResource(System.String onlineVer, System.Boolean isInitial, Beyond.Login.LoginHotUpdater.WorkContext workContext) { }
        private System.Void _EventLogDownloadProgress(System.Boolean& first, System.Double current, System.Double total, System.Int32 target, System.Boolean isInitial) { }
        private System.Collections.IEnumerator _DownloadPatchInfo(System.String onlineVer, System.Boolean isInitial, Beyond.Misc.ObjectRef patchInfoRef) { }
        private System.Collections.IEnumerator _ClearDownloadFolder(Beyond.Login.LoginHotUpdater.WorkContext workContext) { }
        private System.Collections.IEnumerator _CheckLocalResConsistency(System.String onlineVer, System.Boolean isInitial, Beyond.Login.LoginHotUpdater.WorkContext context) { }
        private System.Collections.IEnumerator _VitalError(System.String error) { }
        private System.Collections.IEnumerator _LoadStreamingIndex(System.Boolean isInitial, Beyond.Login.LoginHotUpdater.WorkContext workContext, Beyond.Misc.ObjectRef resultRef) { }
        private System.Void WriteLocalResPrefToFile(Beyond.Resource.HotUpdate.LocalResPref localResPref, Beyond.Login.LoginHotUpdater.WorkContext workContext) { }
        private System.Int32 _CurrentWorkMode(Beyond.LoginContext context) { }

    }

    // TypeToken: 0x20000B4
    public class LoginProgress, IProgress
    {
        // Fields
        public static System.Int32 MODE_PROG;        // 0x0
        public static System.Int32 MODE_SIZE;        // 0x0
        public static System.Int32 MODE_IDEL;        // 0x0
        public System.Int32 mode;        // 0x10
        public System.Double current;        // 0x18
        public System.Double total;        // 0x20
        public System.Double speed;        // 0x28
        private Beyond.Login.LoginProgress.FDownloadSize m_downloadSize;        // 0x30

        // Methods
        private System.Double GetCurrent() { }
        private System.Double GetTotal() { }
        private System.String GetInfo() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B7
    public class LoginInitNode : Node
    {
        // Fields
        private System.Boolean m_isSDKInited;        // 0x20

        // Methods
        private Beyond.Login.LoginWorkFlow.ENode get_type() { }
        private UnityEngine.CustomYieldInstruction Work() { }
        private System.Collections.IEnumerator _InitCoroutine() { }
        private System.Collections.IEnumerator _InitRemoteConfigs() { }
        private System.Collections.IEnumerator _YieldAlertError(System.String errorInfo) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BB
    public class LoginLocalResTask, IDisposable
    {
        // Fields
        private Beyond.LoginContext m_loginCxt;        // 0x10
        private Beyond.Login.LoginHotUpdater.WorkContext m_workCxt;        // 0x18

        // Methods
        private System.Void .ctor(Beyond.LoginContext loginContext, Beyond.Login.LoginHotUpdater.WorkContext workContext) { }
        private System.Collections.IEnumerator Work() { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x20000BE
    public class PreloadNode : Node
    {
        // Fields
        private Beyond.Login.LoginHotUpdateModel.SimpleProgress m_progress;        // 0x20
        private System.Boolean m_getServerListSuc;        // 0x28
        private System.String m_errorMsg;        // 0x30

        // Methods
        private Beyond.Login.LoginWorkFlow.ENode get_type() { }
        private UnityEngine.CustomYieldInstruction Work() { }
        private System.Void _ShowPreloadResourcePanel() { }
        private System.Collections.IEnumerator _LoginPreLoad() { }
        private System.Collections.IEnumerator _WarmUp() { }
        private System.Collections.IEnumerator _GetServerList() { }
        private System.Void _EnterPreLoad() { }
        private System.Collections.IEnumerator _GetServerListInfoMock() { }
        private System.Collections.IEnumerator _GetServerListInfo() { }
        private System.Void _OnGetServerListSuc() { }
        private System.Void _OnGetServerListFail(System.String errorInfo) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C6
    public class LoginSDKInitNode : Node
    {
        // Fields
        private System.Boolean m_isSDKInited;        // 0x20

        // Methods
        private Beyond.Login.LoginWorkFlow.ENode get_type() { }
        private UnityEngine.CustomYieldInstruction Work() { }
        private System.Collections.IEnumerator _SDKInitCoroutine() { }
        private System.Collections.IEnumerator _WaitForSDKInited() { }
        private System.Collections.IEnumerator _InitSubSDKs(System.String env) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CA
    public class U8LoginNode : Node
    {
        // Fields
        private System.Boolean m_loginSuc;        // 0x20
        private System.Boolean m_isSDKLoginFinished;        // 0x21
        private System.Int32 m_rqstSkipLoginCache;        // 0x24

        // Methods
        private Beyond.Login.LoginWorkFlow.ENode get_type() { }
        private UnityEngine.CustomYieldInstruction Work() { }
        private System.Collections.IEnumerator _LoginCoroutine() { }
        private System.Collections.IEnumerator _FinishLogin() { }
        private System.Boolean OnEvent(Beyond.ELoginEvent evt, System.Object param) { }
        private System.Void _StartSDKLogin() { }
        private System.Void _SetCursorOnLoginStart() { }
        private System.Void _SetCursorOnLoginFinish() { }
        private System.Void _SkipSDKLogin() { }
        private System.Void _ClearLoginCaches() { }
        private System.Void _OnLoginSuc() { }
        private System.Void _OnLoginFail(System.Object rawInfo) { }
        private System.Void _OnSDKViewDisabled() { }
        private System.Void _OnLoginCanceled() { }
        private System.Void _EnableBlurMask(System.Boolean enable) { }
        private System.Void .ctor() { }
        private System.Void <_StartSDKLogin>b__9_0(System.String sessionToken) { }
        private System.Void <_StartSDKLogin>b__9_1(System.Object pram) { }
        private System.Boolean <>iFixBaseProxy_OnEvent(Beyond.ELoginEvent P0, System.Object P1) { }

    }

    // TypeToken: 0x20000CD
    public class LoginProperty`1, IWorkerUpdateOnce
    {
        // Fields
        private T m_value;        // 0x0
        private System.Collections.Generic.HashSet<Beyond.Login.ILoginBinder<T>> m_binders;        // 0x0
        private Beyond.Login.LoginWorkFlow m_workflow;        // 0x0
        private System.Boolean <isDataChanged>k__BackingField;        // 0x0

        // Methods
        private System.Void .ctor(Beyond.Login.LoginWorkFlow workflow) { }
        private System.Boolean get_isDataChanged() { }
        private System.Void set_isDataChanged(System.Boolean value) { }
        private T get_value() { }
        private System.Void NotifyDataChanged() { }
        private System.Void Bind(Beyond.Login.ILoginBinder<T> binder) { }
        private System.Void Worker_UpdateOnce() { }

    }

    // TypeToken: 0x20000CE
    public interface ILoginBinder`1
    {
        // Methods
        private System.Void OnValueChanged(T value) { }

    }

    // TypeToken: 0x20000CF
    public interface ILoginContextReceiver
    {
        // Methods
        private System.Void OnLoginContext(Beyond.LoginContext context) { }

    }

    // TypeToken: 0x20000D0
    public class LoginViewModel
    {
        // Fields
        public Beyond.Login.LoginWorkFlow.ENode workCachedCurNode;        // 0x10
        public Beyond.Login.LoginWorkFlow.ENode workCurNode;        // 0x14
        public System.Boolean isFirstLogin;        // 0x18
        private System.Int32 <rqstSkipU8Login>k__BackingField;        // 0x1C
        public System.Boolean isU8LoginCancelled;        // 0x20
        private System.Int32 <rqstResRepairCode>k__BackingField;        // 0x24
        public Beyond.Login.LoginViewModel.FAgeTipsPolicy ageTipsPolicy;        // 0x28

        // Methods
        private System.Void .ctor() { }
        private System.Int32 get_rqstSkipU8Login() { }
        private System.Void set_rqstSkipU8Login(System.Int32 value) { }
        private System.Int32 get_rqstResRepairCode() { }
        private System.Void set_rqstResRepairCode(System.Int32 value) { }
        private System.Boolean IsAgeTipsVisible() { }
        private System.Boolean IsGovTipsVisible() { }
        private System.Boolean IsMenuVisible() { }
        private System.Void RequestResourceRepair() { }
        private System.Void RequestSkipU8Login() { }
        private Beyond.Login.LoginViewModel.FAgeTipsPolicy _LoadAgeTipsPolicy() { }

    }

    // TypeToken: 0x20000D2
    public class LoginViewProperty : LoginProperty`1
    {
        // Fields
        private Beyond.Login.LoginHotUpdateProp <hotUpdateProp>k__BackingField;        // 0x30
        private Beyond.Login.LoginAgeTipsProp <ageTipsProp>k__BackingField;        // 0x38
        private Beyond.Login.LoginServerSelectProp <serverSelectProp>k__BackingField;        // 0x40

        // Methods
        private Beyond.Login.LoginHotUpdateProp get_hotUpdateProp() { }
        private System.Void set_hotUpdateProp(Beyond.Login.LoginHotUpdateProp value) { }
        private Beyond.Login.LoginAgeTipsProp get_ageTipsProp() { }
        private System.Void set_ageTipsProp(Beyond.Login.LoginAgeTipsProp value) { }
        private Beyond.Login.LoginServerSelectProp get_serverSelectProp() { }
        private System.Void set_serverSelectProp(Beyond.Login.LoginServerSelectProp value) { }
        private System.Void .ctor(Beyond.Login.LoginWorkFlow workflow) { }

    }

    // TypeToken: 0x20000D3
    public class LoginAgeTipsModel
    {
        // Fields
        public System.String contentCache;        // 0x10
        public System.Boolean isShow;        // 0x18
        public System.Boolean isFetchingContent;        // 0x19

        // Methods
        private System.Boolean IsContentEmpty() { }
        private System.Boolean CanDisplay() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D4
    public class LoginAgeTipsProp : LoginProperty`1
    {
        // Methods
        private System.Void .ctor(Beyond.Login.LoginWorkFlow workflow) { }
        private System.Void ClearContentCache() { }
        private System.Void UpdateContent(System.String content) { }

    }

    // TypeToken: 0x20000D5
    public class LoginWorkFlow, IDisposable
    {
        // Fields
        public static System.String CURSOR_KEY_LOGIN;        // 0x0
        private static readonly Beyond.Login.LoginWorkFlow.ENode[] NODE_ORDER;        // 0x0
        private static Beyond.Login.LoginWorkFlow.ENode NEED_GAME_LOGIN_STATE_BEFORE_NODE;        // 0x0
        private readonly Beyond.Login.LoginWorkFlow.Node[] m_nodes;        // 0x10
        private readonly Beyond.LoginContext m_context;        // 0x18
        private Beyond.Login.LoginWorkFlow.FWork m_work;        // 0x20
        private Beyond.Login.LoginWorkFlow.Worker m_worker;        // 0x30
        private System.Collections.Generic.HashSet<Beyond.Login.LoginWorkFlow.IEventReceiver> m_evtRecvrs;        // 0x38
        private System.Collections.Generic.List<Beyond.Login.LoginWorkFlow.IEventReceiver> m_recvrBuffer;        // 0x40
        private System.Boolean <isDisposed>k__BackingField;        // 0x48

        // Methods
        private Beyond.Login.LoginWorkFlow.Node[] _RegisterNodes() { }
        private System.Boolean get_isDisposed() { }
        private System.Void set_isDisposed(System.Boolean value) { }
        private System.Void .ctor(Beyond.LoginContext context) { }
        private System.Collections.IEnumerator DoWorkFlow() { }
        private System.Void Dispose() { }
        private System.Boolean PeekFallbackStatus(Beyond.Login.LoginWorkFlow.ENode& fallbackNode) { }
        private System.Boolean Fallback(Beyond.Login.LoginWorkFlow.ENode target, System.Boolean validCheck) { }
        private System.Boolean CancelAndFallback(Beyond.Login.LoginWorkFlow.ENode target, System.Boolean validCheck) { }
        private System.Void SendEvent(Beyond.ELoginEvent evt, System.Object param) { }
        private System.Void AddEventReceiver(Beyond.Login.LoginWorkFlow.IEventReceiver receiver) { }
        private System.Boolean UpdateOnce(Beyond.Login.LoginWorkFlow.IWorkerUpdateOnce inst) { }
        private System.Boolean IsBeforeWork(Beyond.Login.LoginWorkFlow.ENode curNode, Beyond.Login.LoginWorkFlow.ENode check) { }
        private System.Boolean IsOnOrAfterWork(Beyond.Login.LoginWorkFlow.ENode curNode, Beyond.Login.LoginWorkFlow.ENode check) { }
        private System.Boolean IsAfterWork(Beyond.Login.LoginWorkFlow.ENode target, Beyond.Login.LoginWorkFlow.ENode check) { }
        private System.Boolean _HandleGlobalEvent(Beyond.ELoginEvent evt, System.Object param) { }
        private System.Void _EventOnOpenAgeTips() { }
        private System.Void _EventOnCloseAgeTips() { }
        private System.Void _EventOnOpenServerSelect(System.Boolean isOpen) { }
        private System.Void _EventOnSelectServer(Beyond.Gameplay.ServerZoneManager.ServerZoneData serverZoneData) { }
        private System.Void _EventOnConfirmServer() { }
        private System.Void _EnableCursor(System.Boolean enabled) { }
        private System.Void _UpdateCursor(Beyond.EventData<Beyond.DeviceInfo.InputType>& input) { }
        private System.Void _EnbaleToggleGroup() { }
        private System.Collections.IEnumerator _FetchAgeTipsCoroutine(Beyond.Login.LoginAgeTipsProp prop) { }
        private System.Boolean _CheckIfGameStateNotMatch(Beyond.Login.LoginWorkFlow.ENode curNode) { }
        private System.Collections.IEnumerator _AdjustCurrentGameState(Beyond.Login.LoginWorkFlow.ENode curNode) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000E0
    public class HotUpdateNode : Node
    {
        // Fields
        private Beyond.Login.LoginHotUpdater m_updater;        // 0x20
        private System.Int32 m_cachedResRepairCode;        // 0x28

        // Methods
        private Beyond.Login.LoginWorkFlow.ENode get_type() { }
        private UnityEngine.CustomYieldInstruction Work() { }
        private System.Void OnDispose() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnDispose() { }

    }

    // TypeToken: 0x20000E1
    public class WaitForSecondsNode : Node
    {
        // Fields
        private System.Nullable<System.Int32> m_timerId;        // 0x20

        // Methods
        private UnityEngine.CustomYieldInstruction Work() { }
        private System.Boolean _IsTimeout() { }
        private System.Void _NotifyTimeout() { }
        private System.Void _DisposeTimer() { }
        private System.Single WaitForSeconds(System.Boolean& unscaled) { }
        private System.Void OnDispose() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnDispose() { }

    }

    // TypeToken: 0x20000E2
    public class PreloadPostDelayNode : WaitForSecondsNode
    {
        // Methods
        private Beyond.Login.LoginWorkFlow.ENode get_type() { }
        private System.Single WaitForSeconds(System.Boolean& unscaled) { }
        private UnityEngine.CustomYieldInstruction Work() { }
        private System.Void _DisableLoadingPanel() { }
        private System.Void .ctor() { }
        private UnityEngine.CustomYieldInstruction <>iFixBaseProxy_Work() { }

    }

    // TypeToken: 0x20000E3
    public class Trans2GsLoginNode : WaitForSecondsNode
    {
        // Methods
        private Beyond.Login.LoginWorkFlow.ENode get_type() { }
        private System.Single WaitForSeconds(System.Boolean& unscaled) { }
        private UnityEngine.CustomYieldInstruction Work() { }
        private System.Void .ctor() { }
        private UnityEngine.CustomYieldInstruction <>iFixBaseProxy_Work() { }

    }

    // TypeToken: 0x20000E4
    public class FinishNode : Node
    {
        // Methods
        private Beyond.Login.LoginWorkFlow.ENode get_type() { }
        private UnityEngine.CustomYieldInstruction Work() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E5
    public struct CarrierDownloadCache
    {
        // Fields
        public static readonly Beyond.Login.CarrierDownloadCache EMPTY;        // 0x0
        public System.Int64 size;        // 0x10
        public System.Boolean isAllowed;        // 0x18

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000E6
    public class NetUsagePolicy
    {
        // Fields
        private Beyond.Login.CarrierDownloadCache m_mobileDataCache;        // 0x10
        private UnityEngine.NetworkReachability m_lastNetworkState;        // 0x20
        private Beyond.Login.NetUsagePolicy.Options m_options;        // 0x28

        // Methods
        private System.Void .ctor(Beyond.Login.NetUsagePolicy.Options options) { }
        private System.Void CheckIfAllowDownload(System.Int64 downloadSize, System.Action onAllowed, System.Action onRejected, System.Action onReachable) { }
        private System.Boolean AllowMobileDataInLastCheck() { }
        private System.String _GetPrettySizeStringUpToMB(System.Double number) { }

    }

    // TypeToken: 0x20000E9
    public class LoginSceneAnimCtrl : LoginSceneComponent, ILoginBinder`1, IAnimationClipSource
    {
        // Fields
        private static System.Single COUNT_DOWN_EMPTY;        // 0x0
        private UnityEngine.Animator _target;        // 0x78
        private UnityEngine.AnimationClip _clipA1;        // 0x80
        private UnityEngine.AnimationClip _clipA1s;        // 0x88
        private System.Single _transA1;        // 0x90
        private System.Single _transA1s;        // 0x94
        private UnityEngine.Vector2 _randomRangeA1s;        // 0x98
        private UnityEngine.AnimationClip _clipA1A2;        // 0xA0
        private System.Single _predelayA1A2;        // 0xA8
        private System.Single _transA1A2;        // 0xAC
        private UnityEngine.AnimationClip _clipA2;        // 0xB0
        private System.Single _transA2;        // 0xB8
        private Beyond.UI.UIAnimationMixPlayer m_player;        // 0xC0
        private Beyond.Login.LoginSceneAnimCtrl.EState m_state;        // 0xC8
        private System.Single m_countDownA1s;        // 0xCC
        private System.Single m_countDownA1A2;        // 0xD0

        // Methods
        private Beyond.TickType get_tickOption() { }
        private System.Void OnBindToManager() { }
        private Beyond.UI.UIAnimationMixPlayer _EnsurePlayer() { }
        private System.Void _ChangeToState(Beyond.Login.LoginSceneAnimCtrl.EState target) { }
        private System.Void _ResetToA1() { }
        private System.Void _TransitionToA2() { }
        private System.Void _PlayA1sAndTriggerNext() { }
        private System.Single _RandomIntervalA1s() { }
        private System.Void _PlayA1A2Impl() { }
        private System.Void OnValueChanged(Beyond.Login.LoginViewModel value) { }
        private System.Void Start() { }
        private System.Void Tick(System.Single deltaTime) { }
        private System.Void OnRelease() { }
        private System.Void GetAnimationClips(System.Collections.Generic.List<UnityEngine.AnimationClip> results) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnBindToManager() { }
        private System.Void <>iFixBaseProxy_Start() { }
        private System.Void <>iFixBaseProxy_Tick(System.Single P0) { }
        private System.Void <>iFixBaseProxy_OnRelease() { }

    }

    // TypeToken: 0x20000EB
    public class LoginSceneComponent : TickableMono
    {
        // Fields
        private Beyond.LoginContext <context>k__BackingField;        // 0x68
        private Beyond.LoginController <controller>k__BackingField;        // 0x70

        // Methods
        private Beyond.TickType get_tickOption() { }
        private Beyond.LoginContext get_context() { }
        private System.Void set_context(Beyond.LoginContext value) { }
        private Beyond.LoginController get_controller() { }
        private System.Void set_controller(Beyond.LoginController value) { }
        private System.Void Start() { }
        private System.Void Bind(Beyond.LoginContext context, Beyond.LoginController controller) { }
        private System.Void OnBindToManager() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000EC
    public class LoginSceneRoot : LoginSceneComponent
    {
        // Methods
        private Beyond.TickType get_tickOption() { }
        private System.Void OnBindToManager() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnBindToManager() { }

    }

    // TypeToken: 0x20000ED
    public class LoginAgeTipsDetailPanel : MonoBehaviour, ILoginBinder`1
    {
        // Fields
        private Beyond.UI.UIAnimationWrapper _anim;        // 0x18
        private UnityEngine.RectTransform _content;        // 0x20
        private Beyond.UI.UIText _txtTitle;        // 0x28
        private Beyond.UI.UIText _lineTmpl;        // 0x30
        private Beyond.UI.UIButton _btnClose;        // 0x38
        private Beyond.UI.UIScrollRect _scroll;        // 0x40
        private Beyond.Input.InputBindingGroupMonoTarget _ageTipsBindingGroup;        // 0x48
        private Beyond.LoginContext m_context;        // 0x50
        private Beyond.UI.UISwitchTween m_switchTween;        // 0x58
        private DG.Tweening.Tween m_displayDelayTween;        // 0x60
        private static System.Int32 MAX_TEXT_STRLEN;        // 0x0
        private static System.Int32 MIN_TEXT_STRLEN;        // 0x0

        // Methods
        private System.Void Init(Beyond.LoginContext context) { }
        private System.Void OnValueChanged(Beyond.Login.LoginAgeTipsModel value) { }
        private System.Void _RenderContent(System.String contentStr) { }
        private System.Void _ShowContent() { }
        private System.Void _EventOnCloseClicked(UnityEngine.EventSystems.PointerEventData _) { }
        private System.Collections.Generic.List<System.String> _SplitLicenseToSegments(System.String content) { }
        private System.Void _SplitLongString(System.String longStr, System.Collections.Generic.List<System.String> outputList) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000EE
    public class LoginAgeTipsPanel : ChildPanel, ILoginBinder`1
    {
        // Fields
        private Beyond.Login.LoginAgeTipsDetailPanel _detailPanel;        // 0x28
        private Beyond.UI.UIButton _ageTipsCN;        // 0x30
        private UnityEngine.GameObject _ageTipsKR;        // 0x38
        private UnityEngine.CanvasGroup _canvasVersionTop;        // 0x40

        // Methods
        private System.Void OnInit() { }
        private System.Void OnValueChanged(Beyond.Login.LoginViewModel value) { }
        private System.Void _UpdateAgeTipsPolicy(Beyond.Login.LoginViewModel.FAgeTipsPolicy policy) { }
        private System.Void _EventOnOpenAgeTipsClicked(UnityEngine.EventSystems.PointerEventData _) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnInit() { }

    }

    // TypeToken: 0x20000EF
    public class LoginAlertDialog : Dialog
    {
        // Fields
        private Beyond.UI.UIButton _btnConfirm;        // 0x38
        private Beyond.UI.UIText _text;        // 0x40
        private Beyond.Login.LoginAlertDialog.FParams m_params;        // 0x48

        // Methods
        private System.Void OnInit() { }
        private System.Void SetParams(Beyond.Login.LoginAlertDialog.FParams param) { }
        private System.Void _OnConfirmClicked(UnityEngine.EventSystems.PointerEventData evt) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnInit() { }

    }

    // TypeToken: 0x20000F1
    public class LoginDecorateUI : TickableUIMono, ILoginBinder`1, ILoginContextReceiver
    {
        // Fields
        private UnityEngine.CanvasGroup _imgLogo;        // 0x68
        private System.Single _durationLogo;        // 0x70
        private UnityEngine.AnimationClip _clipLoopGlow;        // 0x78
        private UnityEngine.AnimationClip _clipInGlow;        // 0x80
        private UnityEngine.Animator _targetGlow;        // 0x88
        private System.Single _delay;        // 0x90
        private Beyond.LoginContext m_context;        // 0x98
        private System.Boolean m_isOnTransNode;        // 0xA0
        private Beyond.Interpolator.FLerpByTime m_hideLogoLerp;        // 0xA8
        private Beyond.UI.UIAnimationLayerMixPlayer m_glowPlayer;        // 0xC8
        private System.Boolean m_isGlowEnabled;        // 0xD0
        private System.Single m_countDownDelay;        // 0xD4
        private System.Single m_countDownDisableGlow;        // 0xD8

        // Methods
        private Beyond.TickType get_tickOption() { }
        private System.Void OnLoginContext(Beyond.LoginContext context) { }
        private System.Void OnValueChanged(Beyond.Login.LoginViewModel value) { }
        private System.Void _TriggerTrans2GSLoginImpl() { }
        private System.Void _ToggleGlow(System.Boolean enable) { }
        private Beyond.UI.UIAnimationLayerMixPlayer _EnsureGlowPlayer() { }
        private System.Void Tick(System.Single deltaTime) { }
        private System.Void OnRelease() { }
        private System.Void _TimeManagerTick(System.Single timeDelta) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Tick(System.Single P0) { }
        private System.Void <>iFixBaseProxy_OnRelease() { }

    }

    // TypeToken: 0x20000F2
    public class LoginEnterGamePanel : ChildPanel, ILoginBinder`1
    {
        // Fields
        private UnityEngine.CanvasGroup _canvasGroup;        // 0x28
        private Beyond.UI.UIButton _btnEnterGame;        // 0x30
        private Beyond.UI.UIText _textEnterGame;        // 0x38
        private System.Single _delayEnterGame;        // 0x40
        private System.Boolean m_isPanelActive;        // 0x44
        private System.Double m_panelActiveTime;        // 0x48
        private System.Boolean m_isInited;        // 0x50

        // Methods
        private System.Void _InitIfNot() { }
        private System.Void OnValueChanged(Beyond.Login.LoginViewModel value) { }
        private System.Void _OnEnterGameClicked(UnityEngine.EventSystems.PointerEventData evt) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F3
    public class LoginGovTipsPanel : ChildPanel, ILoginBinder`1
    {
        // Fields
        private Beyond.UI.UIButton _btnOpen;        // 0x28

        // Methods
        private System.Void OnInit() { }
        private System.Void OnValueChanged(Beyond.Login.LoginViewModel value) { }
        private System.Void _EventOnOpenAgeTipsClicked(UnityEngine.EventSystems.PointerEventData _) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnInit() { }

    }

    // TypeToken: 0x20000F4
    public class LoginJudgeDialog : Dialog
    {
        // Fields
        private Beyond.UI.UIButton _btnPositive;        // 0x38
        private Beyond.UI.UIButton _btnNegative;        // 0x40
        private Beyond.UI.UIText _text;        // 0x48
        private Beyond.UI.UIText _text2;        // 0x50
        private Beyond.UI.UIText _textPositive;        // 0x58
        private Beyond.UI.UIText _textNegative;        // 0x60
        private Beyond.Login.LoginJudgeDialog.FParams m_params;        // 0x68

        // Methods
        private System.Void OnInit() { }
        private System.Void SetParams(Beyond.Login.LoginJudgeDialog.FParams param) { }
        private System.Void _OnPositiveClicked(UnityEngine.EventSystems.PointerEventData evt) { }
        private System.Void _OnNegativeClicked(UnityEngine.EventSystems.PointerEventData evt) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnInit() { }

    }

    // TypeToken: 0x20000F7
    public class LoginMenuPanel : ChildPanel, ILoginBinder`1
    {
        // Fields
        public static System.String CONTROLLER_STATE_NORMAL;        // 0x0
        public static System.String CONTROLLER_STATE_SELECT;        // 0x0
        private Beyond.UI.UIButton _btnAnnounce;        // 0x28
        private Beyond.UI.UIButton _btnSetting;        // 0x30
        private Beyond.UI.UIButton _btnResCheck;        // 0x38
        private Beyond.UI.UIButton _btnLogout;        // 0x40
        private Beyond.UI.UIButton _btnQuitGame;        // 0x48
        private Beyond.UI.UIButton _btnLogin;        // 0x50
        private Beyond.UI.UIButton _btnQR;        // 0x58
        private Beyond.UI.UIState.UIStateController _ctrlAnnounce;        // 0x60
        private Beyond.UI.UIState.UIStateController _ctrlSetting;        // 0x68
        private Beyond.UI.UIState.UIStateController _ctrlResCheck;        // 0x70
        private Beyond.UI.UIState.UIStateController _ctrlLogout;        // 0x78
        private Beyond.UI.UIState.UIStateController _ctrlQR;        // 0x80
        private Beyond.UI.UISimpleStateController _ctrlRight;        // 0x88
        private Beyond.UI.UISelectableNaviGroup _naviGroupRight;        // 0x90
        private Beyond.Input.InputBindingGroupMonoTarget _bindingGroupForKeyboard;        // 0x98
        private Beyond.Input.InputBindingGroupMonoTarget _rootPanelBindingGroup;        // 0xA0
        private UnityEngine.CanvasGroup _alphaHandler;        // 0xA8
        private UnityEngine.GameObject _redDotAnnounce;        // 0xB0
        private Beyond.UI.UIAnimationWrapper _transAnim;        // 0xB8
        private Beyond.UI.UIButton _serverZoneBtn;        // 0xC0
        private Beyond.UI.UIText _serverZoneName;        // 0xC8
        private UnityEngine.GameObject _serverZonePS5;        // 0xD0
        private Beyond.UI.UIText _serverZoneNamePS5;        // 0xD8
        private Beyond.UI.UIState.UIStateController m_curRightBtnCtrl;        // 0xE0
        private System.Boolean m_hasRedDot;        // 0xE8
        private System.Int32 m_rootParentGroupId;        // 0xEC

        // Methods
        private System.Void OnInit() { }
        private System.Void OnValueChanged(Beyond.Login.LoginViewModel value) { }
        private System.Void InitBulletinAndRedAfterLoginSuc() { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void _OnAnnounceClicked(UnityEngine.EventSystems.PointerEventData _) { }
        private System.Void _OnSettingClicked(UnityEngine.EventSystems.PointerEventData _) { }
        private System.Void _OnResCheckClicked(UnityEngine.EventSystems.PointerEventData _) { }
        private System.Void _OnCustomServiceClicked(UnityEngine.EventSystems.PointerEventData _) { }
        private System.Void _OnAccountCenterClicked(UnityEngine.EventSystems.PointerEventData _) { }
        private System.Void _OnLogoutClicked(UnityEngine.EventSystems.PointerEventData _) { }
        private System.Void _OnQuitGameClicked(UnityEngine.EventSystems.PointerEventData _) { }
        private System.Void _OnLoginClicked(UnityEngine.EventSystems.PointerEventData _) { }
        private System.Void _OnQRClicked(UnityEngine.EventSystems.PointerEventData _) { }
        private System.Void _OnRequestRelogin() { }
        private System.Boolean _CanQRLogin() { }
        private System.Void _UpdateAnnounceRedDot() { }
        private System.Void _UpdateServerZone() { }
        private System.Void _OnServerZoneBtnClicked() { }
        private System.Void _OnFocusMenuGroup(System.Boolean isFocused) { }
        private System.Void _OnAnnounceClosed() { }
        private System.Void _OnReceiveRedDotAndPopup(System.Boolean showRedDot) { }
        private System.Void _OnUpdateRedDotForSDKListener(Beyond.EventData<System.Boolean>& show) { }
        private System.Void _OnInputChanged(Beyond.EventData<Beyond.DeviceInfo.InputType>& input) { }
        private System.Void .ctor() { }
        private System.Void <OnInit>b__28_0(System.Boolean isTarget, System.Boolean isGroupChanged, System.Boolean isOnNaviTargetEnabledAgain) { }
        private System.Void <OnInit>b__28_1(System.Boolean isTarget, System.Boolean isGroupChanged, System.Boolean isOnNaviTargetEnabledAgain) { }
        private System.Void <OnInit>b__28_2(System.Boolean isTarget, System.Boolean isGroupChanged, System.Boolean isOnNaviTargetEnabledAgain) { }
        private System.Void <OnInit>b__28_3(System.Boolean isTarget, System.Boolean isGroupChanged, System.Boolean isOnNaviTargetEnabledAgain) { }
        private System.Void <OnInit>b__28_4(System.Boolean isTarget, System.Boolean isGroupChanged, System.Boolean isOnNaviTargetEnabledAgain) { }
        private System.Void <OnInit>b__28_5(UnityEngine.EventSystems.PointerEventData _) { }
        private System.Void <OnInit>b__28_6(System.Boolean isFocused) { }
        private System.Void <_OnAnnounceClicked>b__35_0(System.String s) { }
        private System.Void <>iFixBaseProxy_OnInit() { }
        private System.Void <>iFixBaseProxy_OnDestroy() { }

    }

    // TypeToken: 0x20000F9
    public class LoginMockUIDPanel : MonoBehaviour
    {
        // Fields
        private UnityEngine.CanvasGroup _canvas;        // 0x18
        private Beyond.UI.UIInputField _userIdInputField;        // 0x20
        private Beyond.UI.UIButton _btnEnterGame;        // 0x28
        private Beyond.UI.UIButton _btnDelLocalFile;        // 0x30
        private Beyond.UI.UIDropdown _serverDropdown;        // 0x38
        private UnityEngine.GameObject _hintSelectServer;        // 0x40
        private Beyond.UI.UIButton _btnClose;        // 0x48
        private Beyond.UI.UIText _selectedServerLabel;        // 0x50
        private System.Boolean m_isInited;        // 0x58
        private Beyond.UI.UISwitchTween m_switchTween;        // 0x60
        private System.Collections.Generic.List<Beyond.Network.ServerDesc> m_serverDescList;        // 0x68
        private Beyond.Network.ServerList m_serverListObj;        // 0x70
        private Beyond.Network.ServerConfig m_serverConfig;        // 0x78
        private System.Action<System.String> m_callback;        // 0x80
        private Beyond.Login.LoginMockUIDPanel.FOptions m_options;        // 0x88
        private static Beyond.Login.LoginMockUIDPanel s_instance;        // 0x0

        // Methods
        private Beyond.Login.LoginMockUIDPanel get_instance() { }
        private System.Void LoginWithCallback(Beyond.Login.LoginMockUIDPanel.FOptions options, System.Action<System.String> callback) { }
        private System.Void Refresh() { }
        private System.Collections.IEnumerator HideAndDestroy() { }
        private System.Void _UpdateStatus() { }
        private System.Void _InitLoginInfo() { }
        private System.Void _SaveConfig() { }
        private System.Void _OnBtnEnterGame() { }
        private System.Void _SmokeEnterGame(System.String serverName, System.String uid) { }
        private System.Void _OnBtnDelLocalFile() { }
        private System.Void _TryClosePanel() { }
        private System.Void _OnSelectServer(System.Int32 index) { }
        private System.Void OnDestroy() { }
        private System.Void .ctor() { }
        private System.Void <_UpdateStatus>b__22_0(UnityEngine.EventSystems.PointerEventData _) { }
        private System.Void <_UpdateStatus>b__22_1(UnityEngine.EventSystems.PointerEventData _) { }
        private System.Void <_UpdateStatus>b__22_2(UnityEngine.EventSystems.PointerEventData _) { }
        private System.Void <_InitLoginInfo>b__23_0(System.Int32 index, Beyond.UI.UIDropdownOption options, System.Boolean isSelected) { }

    }

    // TypeToken: 0x20000FC
    public class LoginResourcePanel : ChildPanel, ILoginBinder`1
    {
        // Fields
        private static System.Single PROGRESS_LERP_DURATION;        // 0x0
        private UnityEngine.CanvasGroup _alphaHandler;        // 0x28
        private Beyond.UI.UISlider _progressBar;        // 0x30
        private Beyond.UI.UIText _textTitle;        // 0x38
        private Beyond.UI.UIText _textInfo;        // 0x40
        private Beyond.Login.LoginHotUpdateModel.IProgress m_progress;        // 0x48
        private Beyond.UI.TweenUtils.FLerpByTime m_progressLerper;        // 0x50
        private System.String m_resInfoCache;        // 0x80

        // Methods
        private System.Void OnValueChanged(Beyond.Login.LoginHotUpdateModel value) { }
        private System.Void _UpdateResourceInfo() { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FD
    public class LoginRootPanel : MonoBehaviour
    {
        // Fields
        private Beyond.UI.NotchAdapter _notchAdapter;        // 0x18
        private Beyond.Login.LoginMenuPanel _menuPanel;        // 0x20
        private Beyond.Login.LoginAgeTipsPanel _ageTipsPanel;        // 0x28
        private Beyond.Login.LoginGovTipsPanel _govTipsPanel;        // 0x30
        private Beyond.Login.LoginResourcePanel _resPanel;        // 0x38
        private Beyond.Login.LoginEnterGamePanel _enterGamePanel;        // 0x40
        private Beyond.Login.LoginServerSelectPanel _serverSelectPanel;        // 0x48
        private Beyond.Input.InputBindingGroupMonoTarget _bindingGroup;        // 0x50
        private System.Int32 m_loginRootBindingGroupId;        // 0x58

        // Methods
        private System.Void Awake() { }
        private System.Void OnDestroy() { }
        private System.Void Init(Beyond.LoginContext context) { }
        private System.Void _OnNotchPaddingChanged(Beyond.EventData<System.Single>& data) { }
        private System.Void _InitController() { }
        private System.Void ToggleLoginBindingGroup(System.Boolean enable) { }
        private System.Void InitBulletinAndRedAfterLoginSuc() { }
        private System.Void _InitChildPanel(Beyond.Login.LoginRootPanel.ChildPanel childPanel, Beyond.LoginContext context) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FF
    public class LoginServerSelectItemView : MonoBehaviour
    {
        // Fields
        private Beyond.UI.UIText _serverName;        // 0x18
        private Beyond.UI.UIImage _playerIcon;        // 0x20
        private Beyond.UI.UIText _playerLevel;        // 0x28
        private Beyond.UI.UIImage[] _delayImages;        // 0x30
        private Beyond.UI.UIText _delayText;        // 0x38
        private Beyond.UI.UIButton _btnSelect;        // 0x40
        private Beyond.UI.UIState.UIStateController _stateController;        // 0x48
        private static readonly UnityEngine.Color DEFAULT_COLOR;        // 0x0
        private static System.String DEFAULT_TEXT;        // 0x0
        private static readonly Beyond.Login.LoginServerSelectItemView.DelayInfo DEFAULT_SPEED_INFO;        // 0x10
        private Beyond.Gameplay.ServerZoneManager.ServerZoneData m_serverItem;        // 0x50
        private Beyond.LoginContext m_context;        // 0x58
        private System.Collections.Generic.List<Beyond.Login.LoginServerSelectItemView.DelayInfo> m_speedInfos;        // 0x60

        // Methods
        private System.Void RefreshView(Beyond.LoginContext context, Beyond.Gameplay.ServerZoneManager.ServerZoneData serverItem, System.Boolean isSelected) { }
        private System.Void NaviToBtnTarget() { }
        private System.Void SetSelected(System.Boolean isSelected) { }
        private System.Void _OnClicked(UnityEngine.EventSystems.PointerEventData _) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000101
    public class LoginServerSelectProp : LoginProperty`1
    {
        // Methods
        private System.Void .ctor(Beyond.Login.LoginWorkFlow workflow) { }

    }

    // TypeToken: 0x2000102
    public class LoginServerItem
    {
        // Fields
        public Beyond.Gameplay.ServerZoneManager.ServerZoneData serverZoneData;        // 0x10

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000103
    public class LoginServerSelectModel
    {
        // Fields
        public System.Boolean showPanel;        // 0x10
        public System.Int32 selectedIndex;        // 0x14

        // Methods
        private System.Collections.Generic.List<Beyond.Gameplay.ServerZoneManager.ServerZoneData> get_serverList() { }
        private Beyond.Gameplay.ServerZoneManager.ServerZoneData get_curServerZoneData() { }
        private System.Void InitData() { }
        private Beyond.Gameplay.ServerZoneManager.ServerZoneData GetSelectedServer() { }
        private System.Boolean UpdateSelectedServer(Beyond.Gameplay.ServerZoneManager.ServerZoneData selectedServer) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000104
    public class LoginServerSelectPanel : ChildPanel, ILoginBinder`1
    {
        // Fields
        private Beyond.UI.UIButton _btnBack;        // 0x28
        private Beyond.UI.UIButton _btnConfirm;        // 0x30
        private Beyond.UI.UIAnimationWrapper _showAnim;        // 0x38
        private Beyond.UI.UIScrollList _showList;        // 0x40
        private Beyond.UI.UISelectableNaviGroup _naviGroup;        // 0x48
        private Beyond.Input.InputBindingGroupMonoTarget _bindingGroup;        // 0x50
        private Beyond.Input.InputBindingGroupMonoTarget _rootPanelBindingGroup;        // 0x58
        private Beyond.Login.LoginServerSelectModel m_viewModel;        // 0x60

        // Methods
        private System.Void OnInit() { }
        private System.Void OnDisable() { }
        private System.Void OnEnable() { }
        private System.Void _UpdateServerCell(UnityEngine.GameObject cell, System.Int32 index) { }
        private System.Void _UpdateServerSelected(System.Int32 index, UnityEngine.GameObject cell) { }
        private System.Void OnValueChanged(Beyond.Login.LoginServerSelectModel value) { }
        private System.Void _NaviToSelectedItem() { }
        private System.Void _OnInputChanged(Beyond.EventData<Beyond.DeviceInfo.InputType>& input) { }
        private System.Void _OnCloseClicked(UnityEngine.EventSystems.PointerEventData _) { }
        private System.Void _OnConfirmClicked(UnityEngine.EventSystems.PointerEventData _) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnInit() { }

    }

    // TypeToken: 0x2000106
    public class LoginVersionPanel : MonoBehaviour
    {
        // Fields
        private Beyond.UI.UIText _textVersion;        // 0x18

        // Methods
        private System.Void Start() { }
        private System.String get_displayGameVersion() { }
        private System.String get_versionZoneType() { }
        private System.String get_versionPlatform() { }
        private System.String get_versionAppType() { }
        private System.String get_versionVersionNum() { }
        private System.String get_versionProjectCL() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000107
    public class LoginVocResSelDialog : Dialog
    {
        // Fields
        private Beyond.Login.LoginVocResSelDialog.FParams m_params;        // 0x38
        private Beyond.UI.UIButton _btnConfirm;        // 0x40
        private Beyond.UI.UIScrollList _showList;        // 0x48
        private Beyond.UI.UISelectableNaviGroup _naviGroup;        // 0x50
        private Beyond.Input.InputBindingGroupMonoTarget _bindingGroup;        // 0x58
        private System.Collections.Generic.List<Beyond.Login.LoginVocResSelDialog.VocResInfo> m_vocResInfos;        // 0x60
        private System.Int32 m_selectedIndex;        // 0x68

        // Methods
        private System.Void OnInit() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void SetParams(Beyond.Login.LoginVocResSelDialog.FParams param) { }
        private System.Void UpdateSelected(Beyond.VFS.EVFSBlockType type) { }
        private System.Void _UpdateList() { }
        private System.Void _UpdateSelected(System.Int32 index, UnityEngine.GameObject cell) { }
        private System.Void _UpdateCell(UnityEngine.GameObject cell, System.Int32 index) { }
        private System.Void _OnConfirmClicked(UnityEngine.EventSystems.PointerEventData evt) { }
        private System.Void _OnConfirmClicked() { }
        private System.Void _OnInputTypeChanged(Beyond.EventData<Beyond.DeviceInfo.InputType>& data) { }
        private System.Void _NaviToSelectedItem() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnInit() { }

    }

    // TypeToken: 0x200010A
    public class LoginVocResSelItemView : MonoBehaviour
    {
        // Fields
        private Beyond.UI.UIText _name;        // 0x18
        private Beyond.UI.UIText _size;        // 0x20
        private Beyond.UI.UIButton _btnSelect;        // 0x28
        private Beyond.UI.UIState.UIStateController _stateController;        // 0x30
        private Beyond.Login.LoginVocResSelDialog.VocResInfo m_info;        // 0x38
        private Beyond.Login.LoginVocResSelDialog m_context;        // 0x40
        private static System.Double MB;        // 0x0

        // Methods
        private System.Void RefreshView(Beyond.Login.LoginVocResSelDialog context, Beyond.Login.LoginVocResSelDialog.VocResInfo info, System.Boolean isSelected) { }
        private System.Void NaviToBtnTarget() { }
        private System.Void SetSelected(System.Boolean isSelected) { }
        private System.Void _OnClicked(UnityEngine.EventSystems.PointerEventData _) { }
        private System.Void .ctor() { }

    }

}

namespace Beyond.SDK
{

    // TypeToken: 0x2000050
    public class PlatformFont, IPlatformFont
    {
        // Fields
        private static System.Int32 DEFAULT_FONT_ID;        // 0x0

        // Methods
        private TMPro.TMP_FontAsset GetFont() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000051
    public class SDKNetUtils
    {
        // Fields
        public static System.String CONTENT_TYPE_JSON;        // 0x0
        private static System.Int32 GENERAL_TIMEOUT;        // 0x0
        private static Beyond.SDK.SDKNetUtils.HTTPImpl s_HTTPImpl;        // 0x0

        // Methods
        private System.Void HTTPPost(Beyond.SDK.SDKNetUtils.HttpPostRequest request) { }
        private System.Void HTTPGet(Beyond.SDK.SDKNetUtils.HttpGetRequest request) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200005A
    public class SDKTextDefines
    {
        // Fields
        public static System.String CS_SDK_STO_DESC;        // 0x0
        public static System.String CS_SDK_COMMON_ERROR;        // 0x0
        public static System.String CS_SDK_CREATE_ORDER_ERROR;        // 0x0
        public static System.String CS_SDK_CREATE_ORDER_ERROR_LIMIT_COUNT;        // 0x0
        public static System.String CS_SDK_USR_BAN;        // 0x0
        public static System.String CS_SDK_USR_BAN_TIME;        // 0x0
        public static System.String CS_SDK_LOGIN_FORBID;        // 0x0
        public static System.String CS_SDK_CREATE_ORDER_ERROR_NETWORK_TIMEOUT;        // 0x0
        public static System.String CS_SDK_CREATE_ORDER_ERROR_NETWORK_ERROR;        // 0x0
        public static System.String CS_SDK_CREATE_ORDER_ERROR_TOKEN_INVALID;        // 0x0

    }

}

namespace Beyond.SDK.Impl
{

    // TypeToken: 0x200005B
    public class U8ExternalTools : SDKExternalToolsShortcut
    {
        // Fields
        private static System.Boolean s_inited;        // 0x0
        private static System.Boolean s_initing;        // 0x1
        private static System.Boolean s_needRetry;        // 0x2
        private static System.Boolean s_needQuitGame;        // 0x3
        private static Beyond.SDK.Impl.U8ExternalTools.FHGSDKInit s_initHGSDK;        // 0x4

        // Methods
        private System.Boolean IsInited() { }
        private System.Boolean NeedRetryInit() { }
        private System.Boolean NeedQuitGame() { }
        private System.Void RetryInitSDKSystem(System.String env) { }
        private System.Void InitSDKSystem(System.String env) { }
        private System.Collections.IEnumerator WaitForInited() { }
        private System.Void InitHGSDK(System.String env) { }
        private System.Boolean IsHGSDKInited() { }
        private System.Collections.IEnumerator WaitForInitHGSDK() { }
        private System.Void Log(System.String content) { }
        private System.Void LogError(System.String content) { }
        private System.Void LogWarning(System.String content) { }
        private System.String GetSignKey() { }
        private System.Collections.Generic.Dictionary<System.String,System.String> GetDeviceIDs() { }
        private System.Void SetSubChannel(System.String subChannel) { }
        private System.Int32 GetPlatformKey() { }
        private System.Void OnSDKExtraInfo(System.String jsonData) { }
        private System.String U8RootUrl() { }
        private System.Void POSTImplementation(U8.SDK.SDKExternalTools.POSTRequest request, System.Action<U8.SDK.SDKExternalTools.POSTResult> callback) { }
        private U8.SDK.SDKExternalTools.POSTResult _ConvertToPOSTResult(Beyond.SDK.SDKNetUtils.WebHttpResponse response) { }
        private System.Void _ProcessExtraInfo(U8.SDK.SDKExtraData extraData) { }
        private System.Void _OnRequestExitGame() { }
        private System.Void _OnFakeAccountCenter() { }
        private U8.SDK.SDKCaptchaHandler CreateCaptchaHandler() { }
        private System.String GetErrorMessage(U8.SDK.SDKExternalTools.ErrMsgMeta meta) { }
        private System.Boolean _ErrorMsg_GET_TOKEN(U8.SDK.SDKExternalTools.ErrMsgMeta meta, System.String& errorMsg) { }
        private System.Boolean _ErrorMsg_CREATE_ORDER(U8.SDK.SDKExternalTools.ErrMsgMeta meta, System.String& errorMsg) { }
        private System.Void .ctor() { }
        private System.String <>iFixBaseProxy_GetSignKey() { }
        private System.Collections.Generic.Dictionary<System.String,System.String> <>iFixBaseProxy_GetDeviceIDs() { }
        private System.Void <>iFixBaseProxy_OnSDKExtraInfo(System.String P0) { }

    }

    // TypeToken: 0x2000063
    public class U8Plugin, IExternalPlugin
    {
        // Methods
        private System.String GetPayAddition() { }
        private System.String GetSDKToken() { }
        private System.String GetSDKUid() { }
        private System.Void Init() { }
        private System.Void Login(U8.SDK.ExternalPluginLoginParams args) { }
        private System.Void Logout(U8.SDK.ExternalPluginLogoutParams args) { }
        private System.Void OnProductListChanged(System.Collections.Generic.List<U8.SDK.U8ProductInfo> productList) { }
        private System.Void Pay(U8.SDK.ExternalPluginPayParams args) { }
        private System.Boolean TryLoadSDKMeta(System.Func<U8.SDK.SDKMeta> loadMetaNative, U8.SDK.SDKMeta& meta) { }
        private System.Boolean _UseMockVersion() { }
        private System.Void _MockLogin(U8.SDK.ExternalPluginLoginParams args) { }
        private System.Void .ctor() { }

    }

}

namespace Beyond.Scripts.Entry
{

    // TypeToken: 0x200010B
    public class GameSettingSetter
    {
        // Fields
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> <audioGlobalVolume>k__BackingField;        // 0x0
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> <audioMusicVolume>k__BackingField;        // 0x8
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> <audioVoiceVolume>k__BackingField;        // 0x10
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> <audioSfxVolume>k__BackingField;        // 0x18
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> <audioSuspendUnfocused>k__BackingField;        // 0x20
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> <audioBackgroundMusic>k__BackingField;        // 0x28
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingAudioSuiteMode> <audioSuiteMode>k__BackingField;        // 0x30
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> <audioController>k__BackingField;        // 0x38
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> <audioSpatial>k__BackingField;        // 0x40
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> <controllerCameraSpeedX>k__BackingField;        // 0x48
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> <controllerCameraSpeedY>k__BackingField;        // 0x50
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> <controllerCameraTopViewSpeed>k__BackingField;        // 0x58
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> <controllerWalkRunRatio>k__BackingField;        // 0x60
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.CameraImpulseLevel> <cameraImpulseLevel>k__BackingField;        // 0x68
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> <enableCameraFar>k__BackingField;        // 0x70
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> <controllerCameraReverseX>k__BackingField;        // 0x78
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> <controllerCameraReverseY>k__BackingField;        // 0x80
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingControllerAutoLockTarget> <controllerAutoLockTarget>k__BackingField;        // 0x88
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.ComboSkillCameraAlpha> <comboSkillCameraAlpha>k__BackingField;        // 0x90
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> <controllerAutoSprint>k__BackingField;        // 0x98
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> <controllerMotion>k__BackingField;        // 0xA0
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> <controllerTriggerEffect>k__BackingField;        // 0xA8
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> <enableAutoAttackTouch>k__BackingField;        // 0xB0
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> <enableAutoAttackGamepad>k__BackingField;        // 0xB8
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GEnums.EnvLang> <languageText>k__BackingField;        // 0xC0
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingLanguageAudio> <languageAudio>k__BackingField;        // 0xC8
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingVideoQuality> <graphicsQuality>k__BackingField;        // 0xD0
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Int32,System.Int32> <graphicsResolution>k__BackingField;        // 0xD8
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> <graphicsNotchPadding>k__BackingField;        // 0xE0
        private static Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> <otherShowSmartAlert>k__BackingField;        // 0xE8
        public static System.Boolean s_stageInitFinished;        // 0xF0

        // Methods
        private Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> get_audioGlobalVolume() { }
        private System.Void set_audioGlobalVolume(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> value) { }
        private Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> get_audioMusicVolume() { }
        private System.Void set_audioMusicVolume(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> value) { }
        private Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> get_audioVoiceVolume() { }
        private System.Void set_audioVoiceVolume(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> value) { }
        private Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> get_audioSfxVolume() { }
        private System.Void set_audioSfxVolume(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> value) { }
        private Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> get_audioSuspendUnfocused() { }
        private System.Void set_audioSuspendUnfocused(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> value) { }
        private Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> get_audioBackgroundMusic() { }
        private System.Void set_audioBackgroundMusic(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> value) { }
        private Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingAudioSuiteMode> get_audioSuiteMode() { }
        private System.Void set_audioSuiteMode(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingAudioSuiteMode> value) { }
        private Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> get_audioController() { }
        private System.Void set_audioController(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> value) { }
        private Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> get_audioSpatial() { }
        private System.Void set_audioSpatial(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> value) { }
        private Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> get_controllerCameraSpeedX() { }
        private System.Void set_controllerCameraSpeedX(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> value) { }
        private Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> get_controllerCameraSpeedY() { }
        private System.Void set_controllerCameraSpeedY(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> value) { }
        private Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> get_controllerCameraTopViewSpeed() { }
        private System.Void set_controllerCameraTopViewSpeed(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> value) { }
        private Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> get_controllerWalkRunRatio() { }
        private System.Void set_controllerWalkRunRatio(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> value) { }
        private Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.CameraImpulseLevel> get_cameraImpulseLevel() { }
        private System.Void set_cameraImpulseLevel(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.CameraImpulseLevel> value) { }
        private Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> get_enableCameraFar() { }
        private System.Void set_enableCameraFar(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> value) { }
        private Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> get_controllerCameraReverseX() { }
        private System.Void set_controllerCameraReverseX(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> value) { }
        private Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> get_controllerCameraReverseY() { }
        private System.Void set_controllerCameraReverseY(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> value) { }
        private Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingControllerAutoLockTarget> get_controllerAutoLockTarget() { }
        private System.Void set_controllerAutoLockTarget(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingControllerAutoLockTarget> value) { }
        private Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.ComboSkillCameraAlpha> get_comboSkillCameraAlpha() { }
        private System.Void set_comboSkillCameraAlpha(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.ComboSkillCameraAlpha> value) { }
        private Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> get_controllerAutoSprint() { }
        private System.Void set_controllerAutoSprint(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> value) { }
        private Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> get_controllerMotion() { }
        private System.Void set_controllerMotion(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> value) { }
        private Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> get_controllerTriggerEffect() { }
        private System.Void set_controllerTriggerEffect(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> value) { }
        private Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> get_enableAutoAttackTouch() { }
        private System.Void set_enableAutoAttackTouch(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> value) { }
        private Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> get_enableAutoAttackGamepad() { }
        private System.Void set_enableAutoAttackGamepad(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> value) { }
        private Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GEnums.EnvLang> get_languageText() { }
        private System.Void set_languageText(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GEnums.EnvLang> value) { }
        private Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingLanguageAudio> get_languageAudio() { }
        private System.Void set_languageAudio(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingLanguageAudio> value) { }
        private Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingVideoQuality> get_graphicsQuality() { }
        private System.Void set_graphicsQuality(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingVideoQuality> value) { }
        private Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Int32,System.Int32> get_graphicsResolution() { }
        private System.Void set_graphicsResolution(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Int32,System.Int32> value) { }
        private Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> get_graphicsNotchPadding() { }
        private System.Void set_graphicsNotchPadding(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> value) { }
        private Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> get_otherShowSmartAlert() { }
        private System.Void set_otherShowSmartAlert(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> value) { }
        private System.Void InitSetterItems() { }
        private System.Void _OnAudioGlobalVolumeChange(System.Single volume) { }
        private System.Void _OnAudioMusicVolumeChange(System.Single volume) { }
        private System.Void _OnAudioVoiceVolumeChange(System.Single volume) { }
        private System.Void _OnAudioSfxVolumeChange(System.Single volume) { }
        private System.Void _OnAudioSuspendUnfocusedChange(System.Boolean suspendUnfocused) { }
        private System.Void _OnAudioBackgroundMusicChange(System.Boolean enable) { }
        private System.Void _OnAudioSuiteModeChange(Beyond.GameSetting.GameSettingAudioSuiteMode mode) { }
        private System.Void _OnAudioControllerChange(System.Boolean enable) { }
        private System.Void _OnAudioSpatialAudioChange(System.Boolean enable) { }
        private System.Void _OnControllerCameraSpeedXChange(System.Single cameraSpeed) { }
        private System.Void _OnControllerCameraSpeedYChange(System.Single cameraSpeed) { }
        private System.Void _OnControllerCameraTopViewSpeedChange(System.Single cameraSpeed) { }
        private System.Void _OnControllerWalkRunRatioChange(System.Single walkRunRatio) { }
        private System.Void _OnCameraImpulseLevelChange(Beyond.GameSetting.CameraImpulseLevel level) { }
        private System.Void _OnEnableCameraFarChange(System.Boolean enable) { }
        private System.Void _OnControllerCameraReverseXChange(System.Boolean isReverse) { }
        private System.Void _OnControllerCameraReverseYChange(System.Boolean isReverse) { }
        private System.Void _OnControllerAutoLockTargetChange(Beyond.GameSetting.GameSettingControllerAutoLockTarget mode) { }
        private System.Void _OnComboSkillCameraAlphaChange(Beyond.GameSetting.ComboSkillCameraAlpha alpha) { }
        private System.Void _OnControllerAutoSprintChange(System.Boolean valid) { }
        private System.Void _OnControllerMotionChange(System.Boolean valid) { }
        private System.Void _OnControllerTriggerEffectChange(System.Boolean enable) { }
        private System.Void _OnEnableAutoAttackTouchChange(System.Boolean enable) { }
        private System.Void _OnEnableAutoAttackGamepadChange(System.Boolean enable) { }
        private System.Void _OnLanguageTextChange(Beyond.GEnums.EnvLang language) { }
        private System.Void _OnLanguageAudioChange(Beyond.GameSetting.GameSettingLanguageAudio language) { }
        private System.Void _OnGraphicsQualityChange(Beyond.GameSetting.GameSettingVideoQuality quality) { }
        private System.Void _OnGraphicsResolutionChange(System.Int32 width, System.Int32 height) { }
        private System.Void _OnGraphicsNotchPaddingChange(System.Single notchPadding) { }
        private System.Void _OnOtherShowSmartAlertChange(System.Boolean show) { }

    }

    // TypeToken: 0x200010E
    public class WarmUpProgress, IProgress
    {
        // Methods
        private System.Double GetTotal() { }
        private System.Double GetCurrent() { }
        private System.String GetInfo() { }
        private System.Void .ctor() { }

    }

}

namespace Beyond.SourceGenerator
{

    // TypeToken: 0x2000044
    public class ECSComponentAttribute : Attribute
    {
        // Fields
        public System.Runtime.InteropServices.LayoutKind layoutKind;        // 0x10
        public System.Boolean isTag;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000045
    public class CameraControlConfigAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000046
    public class DataNAttribute : Attribute
    {
        // Fields
        public System.Int32 capacity;        // 0x10
        public System.Int32 tSize;        // 0x14
        public System.Boolean ring;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000047
    public class AnimatorBlackboardAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace Beyond.UI
{

    // TypeToken: 0x2000048
    public class SplashController : MonoBehaviour
    {
        // Fields
        private static System.String CURSOR_KEY_SPLASH;        // 0x0
        private System.Single _initialFadeTime;        // 0x18
        private System.Single _regularFadeTime;        // 0x1C
        private System.Single _showTime;        // 0x20
        private UnityEngine.UI.Image _blackCoverImage;        // 0x28
        private UnityEngine.UI.Image _splashImage;        // 0x30
        private Beyond.UI.SplashController.SplashConfigs _splashConfigsCN;        // 0x38
        private Beyond.UI.SplashController.SplashConfigs _splashConfigsOS;        // 0x50
        private DG.Tweening.Sequence m_tween;        // 0x68
        private Beyond.UI.SplashController.SwitchSceneTrigger m_sceneTrigger;        // 0x70

        // Methods
        private System.Void Start() { }
        private Beyond.UI.SplashController.SplashConfig[] _GetSplashConfigs() { }
        private System.Void _DoStartSplash(Beyond.UI.SplashController.SplashConfig[] splashConfigs) { }
        private System.Void _OnTweenFinished() { }
        private System.Void _SwitchToInitScene() { }
        private System.Collections.IEnumerator _SwitchToInitSceneCoroutine() { }
        private System.Collections.IEnumerator _StartLicenseCoroutine() { }
        private System.Void .ctor() { }
        private System.Void <_DoStartSplash>b__16_1() { }

    }

}

namespace HG.Rendering.Runtime
{

    // TypeToken: 0x2000003
    public class HGConstantBufferLayoutAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace IFix
{

    // TypeToken: 0x2000111
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10
        private System.Int32 methodId;        // 0x18
        private System.Object anonObj;        // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;        // 0x0

        // Methods
        private System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        private System.Void __Gen_Wrap_0(System.Object P0, Beyond.GameState P1) { }
        private System.Collections.IEnumerator __Gen_Wrap_1(System.Object P0) { }
        private System.Void __Gen_Wrap_2(System.Object P0) { }
        private System.Void __Gen_Wrap_3() { }
        private System.Void __Gen_Wrap_4(Beyond.EventData<System.Boolean,System.Boolean>& P0) { }
        private System.Void __Gen_Wrap_5(System.Object P0, System.Boolean P1) { }
        private System.Void __Gen_Wrap_6(System.Int32 P0) { }
        private System.Void __Gen_Wrap_7(System.Single P0) { }
        private System.Void __Gen_Wrap_8(System.Boolean P0) { }
        private System.Void __Gen_Wrap_9(Beyond.GameSetting.GameSettingAudioSuiteMode P0) { }
        private System.Void __Gen_Wrap_10(Beyond.GameSetting.CameraImpulseLevel P0) { }
        private System.Void __Gen_Wrap_11(Beyond.GameSetting.GameSettingControllerAutoLockTarget P0) { }
        private System.Void __Gen_Wrap_12(Beyond.GameSetting.ComboSkillCameraAlpha P0) { }
        private System.Void __Gen_Wrap_13(Beyond.GEnums.EnvLang P0) { }
        private System.Void __Gen_Wrap_14(Beyond.GameSetting.GameSettingLanguageAudio P0) { }
        private System.Void __Gen_Wrap_15(Beyond.GameSetting.GameSettingVideoQuality P0) { }
        private System.Void __Gen_Wrap_16(System.Int32 P0, System.Int32 P1) { }
        private System.Boolean __Gen_Wrap_17(System.Object P0, Beyond.Resource.HotUpdate.LocalResPref& P1, Beyond.VFS.VirtualFileSystem.BlockValidator& P2) { }
        private System.Void __Gen_Wrap_18(System.Object P0, Beyond.VFS.VirtualFileSystem.BlockValidator& P1) { }
        private System.Void __Gen_Wrap_19(System.Object P0, System.Object P1) { }
        private System.Boolean __Gen_Wrap_20(System.Object P0) { }
        private System.Void __Gen_Wrap_21(System.Object P0, Beyond.EventData<Beyond.DeviceInfo.InputType>& P1) { }
        private Beyond.LoginController.MaskCtrl __Gen_Wrap_22(System.Object P0) { }
        private Beyond.UI.UISwitchTween __Gen_Wrap_23(System.Object P0, System.Int32 P1) { }
        private System.Collections.IEnumerator __Gen_Wrap_24(System.Object P0, System.Object P1) { }
        private System.Void __Gen_Wrap_25(System.Object P0, System.Object P1, Beyond.LoginController.EMaskType P2, System.Boolean P3, System.Boolean P4) { }
        private Beyond.UI.UIAnimationLayerMixPlayer __Gen_Wrap_26(System.Object P0) { }
        private System.Void __Gen_Wrap_27(System.Object P0, Beyond.LoginController.FOptions P1) { }
        private Beyond.Login.LoginWorkFlow.FWork __Gen_Wrap_28() { }
        private System.Boolean __Gen_Wrap_29(Beyond.Login.LoginWorkFlow.ENode P0, Beyond.Login.LoginWorkFlow.ENode P1) { }
        private System.Boolean __Gen_Wrap_30(Beyond.Login.LoginWorkFlow.ENode P0) { }
        private System.Collections.IEnumerator __Gen_Wrap_31(Beyond.Login.LoginWorkFlow.ENode P0) { }
        private UnityEngine.CustomYieldInstruction __Gen_Wrap_32(System.Object P0) { }
        private System.Boolean __Gen_Wrap_33(Beyond.Login.LoginWorkFlow.FWork& P0) { }
        private System.Void __Gen_Wrap_34(Beyond.Login.LoginWorkFlow.FWork& P0) { }
        private System.Void __Gen_Wrap_35(System.Object P0, Beyond.Login.LoginAlertDialog.FParams P1) { }
        private System.Void __Gen_Wrap_36(System.Object P0, Beyond.Login.LoginVocResSelDialog.FParams P1) { }
        private System.Void __Gen_Wrap_37(System.Object P0, Beyond.Login.LoginJudgeDialog.FParams P1) { }
        private System.Void __Gen_Wrap_38(Beyond.Login.LoginAlertDialog P0, Beyond.Login.LoginAlertDialog.FParams P1) { }
        private System.Void __Gen_Wrap_39(System.Object P0, System.Object P1, System.Object P2) { }
        private System.Void __Gen_Wrap_40(System.Object P0, System.Boolean P1, System.Object P2, System.Object P3, System.Object P4, System.Object P5, System.Object P6, System.Object P7, System.Object P8) { }
        private System.Collections.IEnumerator __Gen_Wrap_41(System.Object P0, System.Boolean P1) { }
        private System.Boolean __Gen_Wrap_42(System.Object P0, Beyond.Login.LoginWorkFlow.ENode& P1) { }
        private System.Void __Gen_Wrap_43(Beyond.GameState P0) { }
        private System.Void __Gen_Wrap_44(System.Object P0, System.Single P1) { }
        private System.Single __Gen_Wrap_45(System.Object P0) { }
        private Beyond.LoginController __Gen_Wrap_46(System.Object P0) { }
        private System.Void __Gen_Wrap_47(System.Object P0, System.Object P1, System.Single P2) { }
        private System.Collections.Generic.List<Beyond.Gameplay.ServerZoneManager.ServerZoneData> __Gen_Wrap_48(System.Object P0) { }
        private System.Boolean __Gen_Wrap_49(System.Object P0, System.Object P1) { }
        private Beyond.Gameplay.ServerZoneManager.ServerZoneData __Gen_Wrap_50(System.Object P0) { }
        private System.Boolean __Gen_Wrap_51(System.Object P0, Beyond.ELoginEvent P1, System.Object P2) { }
        private System.Void __Gen_Wrap_52(System.Object P0, Beyond.ELoginEvent P1, System.Object P2) { }
        private System.Void __Gen_Wrap_53(System.String P0) { }
        private System.Void __Gen_Wrap_54(UnityEngine.EventSystems.PointerEventData P0) { }
        private System.Boolean __Gen_Wrap_55(Beyond.Login.LoginMockUIDPanel.FOptions& P0) { }
        private System.Void __Gen_Wrap_56(System.Int32 P0, Beyond.UI.UIDropdownOption P1, System.Boolean P2) { }
        private System.Void __Gen_Wrap_57(System.Object P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_58(System.Object P0, Beyond.Login.LoginMockUIDPanel.FOptions P1, System.Object P2) { }
        private Beyond.UI.UISwitchTween __Gen_Wrap_59(System.Object P0) { }
        private System.Boolean __Gen_Wrap_60(System.Object P0, Beyond.LoginController.EMaskType P1) { }
        private System.Void __Gen_Wrap_61(Beyond.Login.LoginVocResSelDialog P0, Beyond.Login.LoginVocResSelDialog.FParams P1) { }
        private System.Collections.IEnumerator __Gen_Wrap_62(System.Object P0, System.Object P1, System.Object P2, System.Object P3) { }
        private System.Void __Gen_Wrap_63(Beyond.Login.LoginJudgeDialog P0, Beyond.Login.LoginJudgeDialog.FParams P1) { }
        private System.Void __Gen_Wrap_64(System.Object P0, System.Object P1, System.Object P2, System.Object P3) { }
        private System.String __Gen_Wrap_65(System.Object P0, System.Object P1, System.Object P2) { }
        private System.Void __Gen_Wrap_66(System.Boolean& P0) { }
        private System.Void __Gen_Wrap_67(System.Object P0, System.Boolean& P1) { }
        private System.Void __Gen_Wrap_68(System.Object P0, Beyond.LoginManager.FFlowWithMask P1) { }
        private System.Boolean __Gen_Wrap_69(Beyond.LoginManager.FFlowCondition& P0, Beyond.Login.LoginWorkFlow.ENode P1) { }
        private System.Collections.IEnumerator __Gen_Wrap_70(System.Object P0, Beyond.LoginManager.FFlowWithMask P1) { }
        private Beyond.UI.SplashController.SplashConfig[] __Gen_Wrap_71(System.Object P0) { }
        private TMPro.TMP_FontAsset __Gen_Wrap_72(System.Object P0) { }
        private System.Void __Gen_Wrap_73(Beyond.SDK.SDKNetUtils.HttpPostRequest P0) { }
        private System.Void __Gen_Wrap_74(Beyond.SDK.SDKNetUtils.HttpGetRequest P0) { }
        private System.Collections.IEnumerator __Gen_Wrap_75(System.Object P0, Beyond.SDK.SDKNetUtils.HTTPConfig P1) { }
        private System.Boolean __Gen_Wrap_76() { }
        private System.Collections.IEnumerator __Gen_Wrap_77() { }
        private System.String __Gen_Wrap_78(System.Object P0) { }
        private System.Collections.Generic.Dictionary<System.String,System.String> __Gen_Wrap_79(System.Object P0) { }
        private System.Int32 __Gen_Wrap_80(System.Object P0) { }
        private System.Void __Gen_Wrap_81(System.Object P0, U8.SDK.SDKExtraData P1) { }
        private U8.SDK.SDKExternalTools.POSTResult __Gen_Wrap_82(Beyond.SDK.SDKNetUtils.WebHttpResponse P0) { }
        private System.Void __Gen_Wrap_83(Beyond.SDK.SDKNetUtils.WebHttpResponse P0) { }
        private System.Void __Gen_Wrap_84(System.Object P0, U8.SDK.SDKExternalTools.POSTRequest P1, System.Object P2) { }
        private U8.SDK.SDKCaptchaHandler __Gen_Wrap_85(System.Object P0) { }
        private System.Boolean __Gen_Wrap_86(System.Object P0, U8.SDK.SDKExternalTools.ErrMsgMeta P1, System.String& P2) { }
        private System.String __Gen_Wrap_87(System.Object P0, U8.SDK.SDKExternalTools.ErrMsgMeta P1) { }
        private System.Collections.IEnumerator __Gen_Wrap_88(System.Object P0, System.Object P1, System.Object P2) { }
        private System.Void __Gen_Wrap_89(System.Object P0, U8.SDK.ExternalPluginLoginParams P1) { }
        private System.Void __Gen_Wrap_90(System.Object P0, U8.SDK.ExternalPluginLogoutParams P1) { }
        private System.Void __Gen_Wrap_91(U8.SDK.U8PayResult P0) { }
        private System.Void __Gen_Wrap_92(System.Object P0, U8.SDK.ExternalPluginPayParams P1) { }
        private System.Boolean __Gen_Wrap_93(System.Object P0, System.Object P1, U8.SDK.SDKMeta& P2) { }
        private System.Void __Gen_Wrap_94(Beyond.Login.LoginWorkFlow.FWork& P0, System.Int32 P1) { }
        private System.Boolean __Gen_Wrap_95(System.Object P0, Beyond.Login.LoginWorkFlow.ENode P1, System.Boolean P2) { }
        private Beyond.SDK.HGDownloader.DownloadProgress __Gen_Wrap_96(System.Object P0) { }
        private Beyond.SDK.HGDownloader.WorkState __Gen_Wrap_97(System.Object P0) { }
        private System.Collections.Generic.List<Beyond.SDK.HGFileInfo> __Gen_Wrap_98(System.Object P0, System.Object P1) { }
        private System.Boolean __Gen_Wrap_99(System.Object P0, Beyond.SDK.HGRetCodeType P1, System.Int32 P2) { }
        private System.String __Gen_Wrap_100(System.Double P0) { }
        private System.Void __Gen_Wrap_101(System.Object P0, System.Int64 P1, System.Object P2, System.Object P3, System.Object P4) { }
        private System.Void __Gen_Wrap_102(System.Object P0, Beyond.SDK.HGDownloader.PauseReason P1) { }
        private System.Collections.IEnumerator __Gen_Wrap_103(System.Object P0, System.Int64 P1) { }
        private System.Void __Gen_Wrap_104(System.Object P0, System.Int64 P1, System.Int64 P2, System.Int64 P3) { }
        private System.Double __Gen_Wrap_105(System.Object P0) { }
        private System.String __Gen_Wrap_106(System.Object P0, System.Boolean P1) { }
        private Beyond.Resource.HotUpdate.LocalResPref __Gen_Wrap_107() { }
        private Beyond.Login.LoginHotUpdater.HotUpdateInfo __Gen_Wrap_108(System.Object P0, System.Boolean P1) { }
        private Beyond.Resource.HotUpdate.ResourceIndex __Gen_Wrap_109() { }
        private System.String __Gen_Wrap_110(System.Object P0, System.Object P1, System.Boolean P2) { }
        private System.Object __Gen_Wrap_111() { }
        private System.Collections.IEnumerator __Gen_Wrap_112(System.Object P0, System.Object P1, System.Boolean P2, System.Object P3) { }
        private System.Collections.IEnumerator __Gen_Wrap_113(System.Boolean P0, System.Object P1, System.Object P2) { }
        private System.Void __Gen_Wrap_114(System.Object P0, System.Boolean& P1, System.Double P2, System.Double P3, System.Int32 P4, System.Boolean P5) { }
        private System.Boolean __Gen_Wrap_115(System.Object P0, Beyond.VFS.EVFSBlockType P1) { }
        private Beyond.Login.LoginHotUpdater __Gen_Wrap_116(System.Object P0, System.Boolean P1) { }
        private Beyond.Login.LoginProgress.FDownloadSize.EUnit __Gen_Wrap_117(System.Double P0) { }
        private System.Single __Gen_Wrap_118(System.Double P0, Beyond.Login.LoginProgress.FDownloadSize.EUnit P1) { }
        private System.String __Gen_Wrap_119(System.Single P0, System.Single P1, Beyond.Login.LoginProgress.FDownloadSize.EUnit P2) { }
        private System.String __Gen_Wrap_120(System.Single P0, Beyond.Login.LoginProgress.FDownloadSize.EUnit P1) { }
        private System.String __Gen_Wrap_121(System.Single P0, System.Single P1) { }
        private System.Void __Gen_Wrap_122(Beyond.Login.LoginProgress.FDownloadSize& P0, System.Double P1, System.Double P2, System.Double P3) { }
        private System.Void __Gen_Wrap_123(Beyond.Login.LoginProgress.FDownloadSize& P0, System.Double P1, System.Double P2) { }
        private System.Void __Gen_Wrap_124(Beyond.Login.LoginProgress.FDownloadSize& P0) { }
        private System.Void __Gen_Wrap_125(Hypergryph.SpeedTest.SpeedTestResult P0) { }
        private System.Threading.Tasks.Task<Hypergryph.SpeedTest.TaskResult> __Gen_Wrap_126() { }
        private Beyond.Login.LoginViewModel.FAgeTipsPolicy __Gen_Wrap_127() { }
        private Beyond.Login.LoginWorkFlow.Node[] __Gen_Wrap_128(System.Object P0) { }
        private System.Single __Gen_Wrap_129(System.Object P0, System.Boolean& P1) { }
        private Beyond.UI.UIAnimationMixPlayer __Gen_Wrap_130(System.Object P0) { }
        private System.Void __Gen_Wrap_131(System.Object P0, Beyond.Login.LoginSceneAnimCtrl.EState P1) { }
        private System.Collections.Generic.List<System.String> __Gen_Wrap_132(System.Object P0) { }
        private System.Void __Gen_Wrap_133(System.Object P0, Beyond.Login.LoginViewModel.FAgeTipsPolicy P1) { }
        private System.Void __Gen_Wrap_134(System.Object P0, System.Object P1, System.Boolean P2, System.Boolean P3) { }
        private System.Void __Gen_Wrap_135(System.Boolean P0, System.Boolean P1, System.Boolean P2) { }
        private System.Void __Gen_Wrap_136(System.Object P0, Beyond.EventData<System.Boolean>& P1) { }
        private System.Void __Gen_Wrap_137(System.Object P0, Beyond.EventData<System.Single>& P1) { }
        private System.Void __Gen_Wrap_138(System.Object P0, System.Object P1, System.Object P2, System.Boolean P3) { }
        private System.Void __Gen_Wrap_139(System.Object P0, System.Object P1, System.Int32 P2) { }
        private System.Void __Gen_Wrap_140(System.Object P0, System.Int32 P1, System.Object P2) { }
        private System.Void __Gen_Wrap_141(System.Object P0, Beyond.VFS.EVFSBlockType P1) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000112
    public class ILFixInterfaceBridge : AnonymousStorey, IDisposable, IEnumerator, IEnumerator`1
    {
        // Fields
        private System.Int32 methodId_0;        // 0x40
        private System.Int32 methodId_1;        // 0x44
        private System.Int32 methodId_2;        // 0x48
        private System.Int32 methodId_3;        // 0x4C
        private System.Int32 methodId_4;        // 0x50

        // Methods
        private System.Void System.IDisposable.Dispose() { }
        private System.Boolean MoveNext() { }
        private System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
        private System.Void System.Collections.IEnumerator.Reset() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        private System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x2000113
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

    // TypeToken: 0x2000114
    public struct IDMAP0
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static IFix.IDMAP0 Beyond-GameApp-SwitchState0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameApp-_FetchRemoteConfigUtilSuc0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameApp-_InitSecuritySDK0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameApp-_InitGameStateMachine0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameApp-_Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameApp-_OnApplicationFocusForLua0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameApp-_OnApplicationPauseForLua0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameApp-_RegisterLuaAfterGCEvent0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameApp-_OnSystemDisplaySizeChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameApp-RefreshScreenResolution0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameApp-_OnSystemScreenSizeChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameApp-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameApp-Update0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameApp-LateUpdate0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameApp-OnApplicationQuit0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameApp-OnApplicationFocus0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameApp-_OnApplicationPauseForSecurity0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameApp-OnApplicationPause0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameApp-_UnInitGameStateMachine0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameApp-_UnInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameApp-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameApp-QuitGame0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameStateBase-OnEnter0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnAudioGlobalVolumeChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnAudioMusicVolumeChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnAudioVoiceVolumeChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnAudioSfxVolumeChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnAudioSuspendUnfocusedChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnAudioBackgroundMusicChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnAudioSuiteModeChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnAudioControllerChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnAudioSpatialAudioChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnControllerCameraSpeedXChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnControllerCameraSpeedYChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnControllerCameraTopViewSpeedChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnControllerWalkRunRatioChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnCameraImpulseLevelChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnEnableCameraFarChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnControllerCameraReverseXChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnControllerCameraReverseYChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnControllerAutoLockTargetChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnComboSkillCameraAlphaChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnControllerAutoSprintChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnControllerMotionChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnControllerTriggerEffectChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnEnableAutoAttackTouchChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnEnableAutoAttackGamepadChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnLanguageTextChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnLanguageAudioChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnGraphicsQualityChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnGraphicsResolutionChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnGraphicsNotchPaddingChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-_OnOtherShowSmartAlertChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-GameSettingSetter-InitSetterItems0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameInitState-_PreInitGameSetting0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameInitState-_CheckIfLocalInitialAssetsValid0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameInitState-_InitAPPDefaultCulture0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameInitState-_InitInitialResourceManager0;        // 0x0
        public static IFix.IDMAP0 Beyond-RenderPipelineDataLoader-LoadRpData0;        // 0x0
        public static IFix.IDMAP0 Beyond-VietnamLoginAgePanel-_UnInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-VietnamLoginAgePanel-_Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-VietnamLoginAgePanel-Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameInitState-_InitGameSetting0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-RecordSplashSceneHandle0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameInitState-_DoInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameInitState-OnEnter0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameStateBase-OnLeave0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameInitState-OnLeave0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginContext-IsDisposed0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-IsWorkflowInProgress0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Node-OnDispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Node-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-_EnableCursor0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-_UpdateCursor0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-_EnbaleToggleGroup0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Worker-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-AssetLoader-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginContext-_DisposeImpl0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginController-get_maskCtrl0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginController-MaskCtrl-_GetMaskByType0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginController-MaskCtrl-IsCrossSceneMaskTweening0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginController-MaskCtrl-WaitForCrossSceneMasks0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginController-MaskCtrl-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginController-BeforeDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginContext-_DisposeCoroutine0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginContext-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginContext-IsWorkflowDisposed0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginController-MaskCtrl-EnableMask0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginRootPanel-_InitController0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginRootPanel-ChildPanel-OnInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginRootPanel-ChildPanel-OnLoginContext0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginRootPanel-_InitChildPanel0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginRootPanel-Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginDecorateUI-_EnsureGlowPlayer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginDecorateUI-_ToggleGlow0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginDecorateUI-OnLoginContext0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginController-_InitVersionBtn0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginController-_InitCoroutine0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginController-_InitImpl0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginController-InitUI0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-FWork-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-IsOnOrAfterWork0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-IsBeforeWork0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-_CheckIfGameStateNotMatch0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-_AdjustCurrentGameState0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Worker-SetCurNode0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Worker-_InternalTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Node-Cancel0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Worker-Work0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Worker-TickInEmptyFrame0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-FWork-ConsumeFallback0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-FWork-MoveNextIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-FWork-WorkEnd0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-DoWorkFlow0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-_LoginWorkFlowCoroutine0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-_PrepareBeforeLoginProcess0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginAlertDialog-SetParams0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelDialog-SetParams0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginJudgeDialog-SetParams0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginContext-StartCoroutine0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-AlertDialog0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginContext-Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginController-InvokeWhenStart0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-_Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-InitCoroutine0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameLoginState-_TryStartLoginWorkflow0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameLoginState-OnEnter0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameLoginState-OnLeave0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginContext-ShutDown0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-_ClearWorkflowAndContext0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-_ReleaseSplashScene0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-_ReleaseLoginScene0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-_ClearLoginSceneCoroutine0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-Clear0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameMainState-OnEnter0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-IsAfterWork0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-PeekFallbackStatus0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-IsReLoginInProgress0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-OnReleaseMainGame0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameMainState-_ClearUtils0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameMainState-ReleaseMainGame0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameMainState-OnLeave0;        // 0x0
        public static IFix.IDMAP0 Beyond-GamePreloadState-_InitGameSettingStateInPreload0;        // 0x0
        public static IFix.IDMAP0 Beyond-GamePreloadState-_DoPreload0;        // 0x0
        public static IFix.IDMAP0 Beyond-GamePreloadState-OnEnter0;        // 0x0
        public static IFix.IDMAP0 Beyond-GamePreloadState-OnLeave0;        // 0x0
        public static IFix.IDMAP0 Beyond-VietnamLoginAgePanel-UnInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameQuitState-DoQuit0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameQuitState-OnEnter0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameQuitState-OnLeave0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-InvokeWhenWorkFlowFinished0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameStartState-_OnEnterMainGame0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameStartState-OnEnter0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameStartState-OnLeave0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameStateBase-OnTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameStateMachine-_RegisterStates0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameStateMachine-CheckCanReturnToLoginState0;        // 0x0
        public static IFix.IDMAP0 Beyond-GameStateMachine-ReturnToLoginState0;        // 0x0
        public static IFix.IDMAP0 Beyond-GlobalInitializer-InitGlobalConfig0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginController-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginController-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginController-GetEnterGamePanelPredelay0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginAgeTipsModel-IsContentEmpty0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginContext-ViewOnlyController0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginController-MaskCtrl-EnableNetMask0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginController-MaskCtrl-DisableNetMask0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-_FetchAgeTipsCoroutine0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginRootPanel-ToggleLoginBindingGroup0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-_EventOnOpenAgeTips0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-_EventOnCloseAgeTips0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-_EventOnOpenServerSelect0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectModel-get_serverList0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectModel-UpdateSelectedServer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-_EventOnSelectServer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectModel-GetSelectedServer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-_EventOnConfirmServer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-_HandleGlobalEvent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Node-OnEvent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-SendEvent0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginController-OnValueChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMockUIDPanel-_SaveConfig0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMockUIDPanel-_OnBtnEnterGame0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMockUIDPanel-_OnBtnDelLocalFile0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMockUIDPanel-FOptions-IsUIDFixed0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMockUIDPanel-_TryClosePanel0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMockUIDPanel-_OnSelectServer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMockUIDPanel-_InitLoginInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMockUIDPanel-_UpdateStatus0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMockUIDPanel-LoginWithCallback0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMockUIDPanel-HideAndDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginController-_MockLoginCoroutine0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginController-MockLoginWithCallback0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginController-Dialog-_CloseCoroutine0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginController-Dialog-TryCloseWithCallback0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginController-Dialog-Show0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginController-Dialog-OnInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginController-MaskCfg-CreateTweenAndHide0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginController-MaskCtrl-IsMaskTweening0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginContext-StopCoroutine0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginContext-SendEvent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginSceneComponent-OnBindToManager0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginSceneComponent-Bind0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-_BindPendingComponents0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-SceneComponentOnly_Bind0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-ToggleLoginBindingGroup0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-VocResSelDialog0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-VocResSelDialogWithConfirm0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-AlertDialogWithResult0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-AlertDialogWithConfirm0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-_StartShowJudgeDialogCoroutine0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-JudgeDialog0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-JudgeDialog1;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-MockLoginWithCallback0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-MockManualSelectServer0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-IsLoginSceneLoading0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-_ExtractErrorInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-FetchRemoteConfigUtilSuc0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-DevOnlyCheckEnableLocalResMode0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-DevOnlyUseLocalResVersion0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-AssetLoader-_CheckDisposedBeforeLoad0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-FlowWithMaskMgr-_OnFlowFinished0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-FFlowCondition-IsTargetMatch0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-FlowWithMaskMgr-_FlowCoroutine0;        // 0x0
        public static IFix.IDMAP0 Beyond-LoginManager-FlowWithMaskMgr-StartFlow0;        // 0x0
        public static IFix.IDMAP0 Beyond-VietnamLoginAgePanel-OnApplicationQuit0;        // 0x0
        public static IFix.IDMAP0 Beyond-VietnamLoginAgeTipsPanelCtrl-_SetStateTips0;        // 0x0
        public static IFix.IDMAP0 Beyond-VietnamLoginAgeTipsPanelCtrl-_SetStateCircle0;        // 0x0
        public static IFix.IDMAP0 Beyond-VietnamLoginAgeTipsPanelCtrl-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-TailGameLoop-Update0;        // 0x0
        public static IFix.IDMAP0 Beyond-TailGameLoop-LateUpdate0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-SplashController-_StartLicenseCoroutine0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-SplashController-_SwitchToInitSceneCoroutine0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-SplashController-_SwitchToInitScene0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-SplashController-_GetSplashConfigs0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-SplashController-SwitchSceneTrigger-_TryTriggerSwitchScene0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-SplashController-SwitchSceneTrigger-NotifyTweenFinished0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-SplashController-_OnTweenFinished0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-SplashController-_DoStartSplash0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-SplashController-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-PlatformFont-GetFont0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-SDKNetUtils-HTTPPost0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-SDKNetUtils-HTTPGet0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-SDKNetUtils-BeyondHttp-DoHTTP0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-IsInited0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-NeedRetryInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-NeedQuitGame0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-_OnRequestExitGame0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-InitSDKSystem0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-RetryInitSDKSystem0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-WaitForInited0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-InitHGSDK0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-IsHGSDKInited0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-WaitForInitHGSDK0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-Log0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-LogError0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-LogWarning0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-GetSignKey0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-GetDeviceIDs0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-SetSubChannel0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-GetPlatformKey0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-CaptchaHandler-OnGT3Message0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-_ProcessExtraInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-OnSDKExtraInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-U8RootUrl0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-_ConvertToPOSTResult0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-POSTImplementation0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-_OnFakeAccountCenter0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-CreateCaptchaHandler0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-_ErrorMsg_GET_TOKEN0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-_ErrorMsg_CREATE_ORDER0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-GetErrorMessage0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8ExternalTools-CaptchaHandler-FetchCaptchaCoroutine0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8Plugin-GetPayAddition0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8Plugin-GetSDKToken0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8Plugin-GetSDKUid0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8Plugin-Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8Plugin-_UseMockVersion0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8Plugin-_MockLogin0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8Plugin-Login0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8Plugin-Logout0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8Plugin-OnProductListChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8Plugin-Pay0;        // 0x0
        public static IFix.IDMAP0 Beyond-SDK-Impl-U8Plugin-TryLoadSDKMeta0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-Clear0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginCheckForUpdateNode-AlertNoMatchDeviceBeforeLogin0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginCheckForUpdateNode-_GetRequestPram0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginCheckForUpdateNode-_GetOnlineAppVersion0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-ShowWaitProgress0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-GetWaitTime0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdatePC0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdateCoroutinePC0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-ClearWaitProgress0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdateCoroutine0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginCheckForUpdateNode-Work0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-_CreateDirectoryIfNotExists0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-Context-CompleteWithCode0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-Context-UncompleteWithCode0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-GetNoAlertCode0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-_GetLastGameInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-CheckLastGameInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-FWork-MarkFallback0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Fallback0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdateCoroutineMobile0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginCreateRoleNode-WorkProcess-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginCreateRoleNode-OnDispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginCreateRoleNode-CanCancel0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginCreateRoleNode-Work0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginDownloadTask-GetDownloadProgress0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginDownloadTask-GetDecompressProgress0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginDownloadTask-GetWorkState0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginDownloadTask-Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginDownloadTask-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginDownloadTask-_GetFileList0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-NetUsagePolicy-AllowMobileDataInLastCheck0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginDownloadTask-_OnDownloadFinish0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginDownloadTask-_OnDownloadError0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-NetUsagePolicy-_GetPrettySizeStringUpToMB0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-NetUsagePolicy-CheckIfAllowDownload0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginDownloadTask-_OnDownloadPaused0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginDownloadTask-_StartDownloadImpl0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginDownloadTask-_StartDownload0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGameSettingInitializer-_TryInitializeComponents0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGameSettingInitializer-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGameSettingInitializer-_InitGameSettingNotchPadding0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGameSettingInitializer-_InitGameSettingStateInLogin0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGameSettingInitializer-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdateNode-_GameUpdateCoroutine0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdateNode-Work0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-_YieldCheckNetUsagePolicy0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-_YieldErrorAlert0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-_OnDownloadStart0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-_OnDownloadProgress0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-_DoTaskUpdating0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-_UpdateGame0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-_WaitForTaskCancel0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdater-DoUpdate0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGameUpdateNode-_GameUpdateCoroutineMobileImpl0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-EnterGameServiceFlow-IsInterruptable0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-EnterGameServiceFlow-TryInterrupt0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-_FallbackToInitNodeImpl0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-_LogoutToInitNode0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-_FallbackToInitWithMask0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-EnterGameServiceFlow-_ReLoginWhenErrorEncountered0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-EnterGameServiceFlow-_OnAuthError0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-_ConfirmServer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-EnterGameServiceFlow-_MockManualSelectServer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-EnterGameServiceFlow-_SaveCurrentUserToServerConfig0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-EnterGameServiceFlow-_NetConnectAndGSLogin0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-EnterGameServiceFlow-_GlobalLoginSucBusiness0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-EnterGameServiceFlow-_EnterGameCoroutine0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-EnterGameServiceFlow-EnterGame0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-Work0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-_OnEventLogout0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginViewModel-RequestResourceRepair0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-_FallbackToResRepairImpl0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-_OnEventResourceRepair0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-OnEvent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-EnterGameServiceFlow-MarkAborting0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-EnterGameServiceFlow-_ExtractErrorInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGSNode-EnterGameServiceFlow-_YieldAlertError0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdateModel-SimpleProgress-GetCurrent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdateModel-SimpleProgress-GetTotal0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdateModel-SimpleProgress-GetInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-MarkInitialAssetChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-CheckInitialAssetChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-MarkNeedClearFolder0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-NeedClearFolder0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-MarkClearSuccessed0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginLocalResTask-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_UpdateResVersionDev0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_UpdateResVersionProd0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_UpdateResVersion0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_CurrentWorkMode0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_GetOnlineResVersion0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-WorkContext-GetHotUpdateInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-ResourceRootUrl0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_ResourceIndexUrl0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_LoadOrDownloadResIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_GenResIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_ResourcePatchUrl0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_ResourceFileUrl0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_LoadStreamingIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_GenRiff0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_ResourcePatchRootUrl0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_DownloadPatchInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_EventLogDownloadProgress0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-HotUpdateInfo-HasAssetsChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-WriteLocalResPrefToFile0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_GenLocalRef0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_CheckAndDownloadResource0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-HotUpdateInfo-CheckIfNeedReload0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-HotUpdateInfo-HasChangedByType0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-WorkContext-MarkIllegalItemsInLocalRes0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_CheckLocalResConsistency0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_ClearDownloadFolder0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-WorkContext-HasChangedByType0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_ReloadResourceIndexes0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_MainCoroutineModeDownload0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginLocalResTask-Work0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_MainCoroutineModeLocal0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_MainCoroutineModeSkip0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_CreateMainCoroutine0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginViewModel-RequestSkipU8Login0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_VitalError0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-_Work0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginHotUpdater-StartHotUpdate0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginProgress-GetCurrent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginProgress-GetTotal0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginProgress-FDownloadSize-_PickUnit0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginProgress-FDownloadSize-_DisplayWithUnit0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginProgress-FDownloadSize-_FormatDisplayInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginProgress-FDownloadSize-_FormatSpeedInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginProgress-FDownloadSize-_FormatProgressInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginProgress-FDownloadSize-SetSize0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginProgress-FDownloadSize-SetProgress0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginProgress-FDownloadSize-SetIdle0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginProgress-GetInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginInitNode-_YieldAlertError0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginInitNode-_InitRemoteConfigs0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginInitNode-_InitCoroutine0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginInitNode-Work0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-PreloadNode-_ShowPreloadResourcePanel0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-PreloadNode-_WarmUp0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-PreloadNode-_OnGetServerListSuc0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-PreloadNode-_GetServerListInfoMock0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-PreloadNode-_OnGetServerListFail0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-PreloadNode-_GetServerListInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-PreloadNode-_GetServerList0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-PreloadNode-_EnterPreLoad0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-PreloadNode-_LoginPreLoad0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-PreloadNode-Work0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginSDKInitNode-_WaitForSDKInited0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginSDKInitNode-_InitSubSDKs0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginSDKInitNode-_SDKInitCoroutine0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginSDKInitNode-Work0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-U8LoginNode-_ClearLoginCaches0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-U8LoginNode-_EnableBlurMask0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-U8LoginNode-_OnSDKViewDisabled0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnReceiveRedDotAndPopup0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_UpdateAnnounceRedDot0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-InitBulletinAndRedAfterLoginSuc0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginRootPanel-InitBulletinAndRedAfterLoginSuc0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-U8LoginNode-_OnLoginSuc0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-U8LoginNode-_SkipSDKLogin0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-U8LoginNode-_SetCursorOnLoginStart0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-U8LoginNode-_SetCursorOnLoginFinish0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-U8LoginNode-_OnLoginCanceled0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-U8LoginNode-_OnLoginFail0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-U8LoginNode-_StartSDKLogin0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-U8LoginNode-_FinishLogin0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-U8LoginNode-_LoginCoroutine0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-U8LoginNode-Work0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-U8LoginNode-OnEvent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginViewModel-IsAgeTipsVisible0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginViewModel-IsGovTipsVisible0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginViewModel-IsMenuVisible0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginViewModel-_LoadAgeTipsPolicy0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginAgeTipsModel-CanDisplay0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginAgeTipsProp-ClearContentCache0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginAgeTipsProp-UpdateContent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-_RegisterNodes0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Node-CanCancel0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Worker-Cancel0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-CancelAndFallback0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-AddEventReceiver0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Worker-UpdateOnce0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-UpdateOnce0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Node-OnInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginWorkFlow-Node-Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-HotUpdateNode-Work0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-HotUpdateNode-OnDispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-WaitForSecondsNode-_NotifyTimeout0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-WaitForSecondsNode-_IsTimeout0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-WaitForSecondsNode-Work0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-WaitForSecondsNode-_DisposeTimer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-WaitForSecondsNode-OnDispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-PreloadPostDelayNode-WaitForSeconds0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-PreloadPostDelayNode-_DisableLoadingPanel0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-PreloadPostDelayNode-Work0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-Trans2GsLoginNode-WaitForSeconds0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-Trans2GsLoginNode-Work0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-FinishNode-Work0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginSceneAnimCtrl-OnBindToManager0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginSceneAnimCtrl-_EnsurePlayer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginSceneAnimCtrl-_RandomIntervalA1s0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginSceneAnimCtrl-_ResetToA10;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginSceneAnimCtrl-_PlayA1A2Impl0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginSceneAnimCtrl-_TransitionToA20;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginSceneAnimCtrl-_ChangeToState0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginSceneAnimCtrl-_PlayA1sAndTriggerNext0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginSceneAnimCtrl-OnValueChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginSceneComponent-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginSceneAnimCtrl-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginSceneAnimCtrl-Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginSceneAnimCtrl-OnRelease0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginSceneAnimCtrl-GetAnimationClips0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginSceneRoot-OnBindToManager0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginAgeTipsDetailPanel-_EventOnCloseClicked0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginAgeTipsDetailPanel-Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginAgeTipsDetailPanel-_SplitLongString0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginAgeTipsDetailPanel-_SplitLicenseToSegments0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginAgeTipsDetailPanel-_RenderContent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginAgeTipsDetailPanel-_ShowContent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginAgeTipsDetailPanel-OnValueChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginAgeTipsPanel-_EventOnOpenAgeTipsClicked0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginAgeTipsPanel-OnInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginAgeTipsPanel-_UpdateAgeTipsPolicy0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginAgeTipsPanel-OnValueChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginAlertDialog-_OnConfirmClicked0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginAlertDialog-OnInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginDecorateUI-_TriggerTrans2GSLoginImpl0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginDecorateUI-OnValueChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginDecorateUI-_TimeManagerTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginDecorateUI-Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginDecorateUI-OnRelease0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginEnterGamePanel-_OnEnterGameClicked0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginEnterGamePanel-_InitIfNot0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginRootPanel-ChildPanel-SetPanelVisibleByFadeSwitchTween0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginEnterGamePanel-OnValueChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGovTipsPanel-_EventOnOpenAgeTipsClicked0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGovTipsPanel-OnInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginGovTipsPanel-OnValueChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginJudgeDialog-_OnPositiveClicked0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginJudgeDialog-_OnNegativeClicked0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginJudgeDialog-OnInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnAnnounceClosed0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnAnnounceClicked0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnSettingClicked0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnResCheckClicked0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnLogoutClicked0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnQuitGameClicked0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnLoginClicked0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnQRClicked0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnServerZoneBtnClicked0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnFocusMenuGroup0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-OnInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_CanQRLogin0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-OnValueChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_UpdateServerZone0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnRequestRelogin0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnInputChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnUpdateRedDotForSDKListener0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginRootPanel-ChildPanel-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnCustomServiceClicked0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMenuPanel-_OnAccountCenterClicked0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMockUIDPanel-Refresh0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMockUIDPanel-_SmokeEnterGame0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginMockUIDPanel-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginResourcePanel-_UpdateResourceInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginResourcePanel-OnValueChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginResourcePanel-Update0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginRootPanel-_OnNotchPaddingChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginRootPanel-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginRootPanel-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginRootPanel-ChildPanel-SetPanelVisibleByAnimSwitchTween0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectItemView-_OnClicked0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectItemView-RefreshView0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectItemView-NaviToBtnTarget0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectItemView-SetSelected0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectModel-InitData0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectPanel-_OnConfirmClicked0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectPanel-_OnCloseClicked0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectPanel-_UpdateServerCell0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectPanel-OnInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectPanel-_NaviToSelectedItem0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectPanel-_OnInputChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectPanel-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectPanel-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectPanel-_UpdateServerSelected0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginServerSelectPanel-OnValueChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginVersionPanel-get_displayGameVersion0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginVersionPanel-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelDialog-_OnConfirmClicked0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelDialog-_OnConfirmClicked1;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelItemView-SetSelected0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelDialog-_UpdateSelected0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelDialog-_UpdateList0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelDialog-UpdateSelected0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelItemView-_OnClicked0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelItemView-RefreshView0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelDialog-_UpdateCell0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelItemView-NaviToBtnTarget0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelDialog-_NaviToSelectedItem0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelDialog-OnInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelDialog-_OnInputTypeChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelDialog-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-Login-LoginVocResSelDialog-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-WarmUpProgress-GetTotal0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-WarmUpProgress-GetCurrent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Entry-WarmUpProgress-GetInfo0;        // 0x0

    }

}

