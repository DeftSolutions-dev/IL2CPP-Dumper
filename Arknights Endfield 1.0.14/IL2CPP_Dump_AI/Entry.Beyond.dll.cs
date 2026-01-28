// ========================================================
// Dumped by @desirepro
// Assembly: Entry.Beyond.dll
// Classes:  276
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: RenderSilhouetteRT
TYPE:  class
TOKEN: 0x2000002
EXTENDS: MonoBehaviour
FIELDS:
  public            UnityEngine.Camera              cameraRT  // 0x18
  public            UnityEngine.Camera              mainCamera  // 0x20
  public            UnityEngine.Material            materialSilhouette  // 0x28
  private   static  UnityEngine.Texture             s_mSilhouetteRT  // 0x0
  private   static  UnityEngine.RenderTexture       s_mSilhouetteRth  // 0x8
METHODS:
  System.Void Update()
  System.Void OnDestroy()
  System.Void .ctor()
END_CLASS

CLASS: FOptions
TYPE:  struct
TOKEN: 0x2000019
FIELDS:
  public            Beyond.LoginContext             context  // 0x10
METHODS:
END_CLASS

CLASS: Dialog
TYPE:  class
TOKEN: 0x200001A
EXTENDS: MonoBehaviour
FIELDS:
  private           Beyond.UI.UISwitchTween         m_switchTween  // 0x18
  private           Beyond.LoginController          m_controller  // 0x20
  public            System.String                   showAudioEvent  // 0x28
  public            System.String                   closeAudioEvent  // 0x30
METHODS:
  System.Collections.IEnumerator _CloseCoroutine(System.Action callback)
  System.Boolean TryCloseWithCallback(System.Action callback)
  System.Void Show()
  System.Void OnInit()
  System.Collections.IEnumerator Create(System.String resPath, Beyond.LoginController controller, Beyond.Misc.ObjectRef outRef)
  System.Void .ctor()
END_CLASS

CLASS: MaskConsts
TYPE:  class
TOKEN: 0x200001D
FIELDS:
  public    static  System.Single                   DELAY_WAIT_NODE  // 0x0
  public    static  System.String                   INIT  // 0x0
  public    static  System.String                   U8_LOGIN  // 0x0
  public    static  System.String                   FROM_GS_LOGIN  // 0x0
  public    static  System.String                   FROM_CREATE_ROLE  // 0x0
  public    static  System.String                   NET_AGE_TIPS  // 0x0
METHODS:
END_CLASS

CLASS: EMaskType
TYPE:  struct
TOKEN: 0x200001E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.LoginController.EMaskTypeNone  // 0x0
  public    static  Beyond.LoginController.EMaskTypeBlack  // 0x0
  public    static  Beyond.LoginController.EMaskTypeBlur  // 0x0
  public    static  Beyond.LoginController.EMaskTypeWhite  // 0x0
METHODS:
END_CLASS

CLASS: MaskCfg
TYPE:  class
TOKEN: 0x200001F
FIELDS:
  public            UnityEngine.CanvasGroup         target  // 0x10
  public            System.Single                   showDuration  // 0x18
  public            System.Single                   hideDuration  // 0x1C
METHODS:
  Beyond.UI.UISwitchTween CreateTweenAndHide()
  System.Void .ctor()
END_CLASS

CLASS: NetMaskRef
TYPE:  class
TOKEN: 0x2000021
FIELDS:
  private           System.String                   <key>k__BackingField  // 0x10
  public            System.Int32                    maskId  // 0x18
  public            System.Boolean                  isEnabled  // 0x1C
METHODS:
  System.String get_key()
  System.Void set_key(System.String value)
  System.Void .ctor(System.String key)
END_CLASS

CLASS: MaskCtrl
TYPE:  class
TOKEN: 0x2000020
FIELDS:
  private   static readonly System.Int32[]                  CROSS_SCENE_MASKS  // 0x0
  private           Beyond.ListDict<System.Int32,System.Collections.Generic.HashSet<System.String>>m_maskRefs  // 0x10
  private           Beyond.ListDict<System.Int32,Beyond.UI.UISwitchTween>m_maskTweens  // 0x18
  private           Beyond.ListDict<System.String,Beyond.LoginController.MaskCtrl.NetMaskRef>m_netMasks  // 0x20
METHODS:
  System.Void .ctor(Beyond.LoginController controller)
  System.Void Dispose()
  System.Void EnableMask(System.String key, Beyond.LoginController.EMaskType type, System.Boolean enable, System.Boolean reset)
  System.Boolean IsMaskTweening(Beyond.LoginController.EMaskType type)
  System.Boolean IsCrossSceneMaskTweening()
  System.Collections.IEnumerator WaitForCrossSceneMasks()
  System.Void EnableNetMask(System.String key, System.Single timeoutSecs)
  System.Void DisableNetMask(System.String key)
  Beyond.UI.UISwitchTween _GetMaskByType(System.Int32 type)
  System.Void .cctor()
END_CLASS

CLASS: AssetLoader
TYPE:  class
TOKEN: 0x200002D
FIELDS:
  private           System.Collections.Generic.Dictionary<System.String,Beyond.Resource.FAssetProxyHandle>m_assetHandles  // 0x10
METHODS:
  Beyond.Resource.FAssetProxyHandle CachedLoad(System.String path)
  Beyond.Resource.FAssetProxyHandle CachedLoadAsync(System.String path)
  System.Boolean _CheckDisposedBeforeLoad(System.String path)
  System.Void Dispose()
  System.Void .ctor()
END_CLASS

CLASS: FlowWithMaskMgr
TYPE:  class
TOKEN: 0x200002E
FIELDS:
  private           Beyond.LoginContext             m_context  // 0x10
  private           System.Collections.Generic.HashSet<System.String>m_activeFlows  // 0x18
METHODS:
  System.Void .ctor(Beyond.LoginContext context)
  System.Void StartFlow(Beyond.LoginManager.FFlowWithMask flow)
  System.Collections.IEnumerator _FlowCoroutine(Beyond.LoginManager.FFlowWithMask flow)
  System.Void _OnFlowFinished(Beyond.LoginManager.FFlowWithMask flow)
END_CLASS

CLASS: FFlowWithMask
TYPE:  struct
TOKEN: 0x2000030
FIELDS:
  public            System.String                   key  // 0x10
  public            Beyond.LoginController.EMaskTypemaskType  // 0x18
  public            System.Func<System.Boolean>     flowAction  // 0x20
  public            Beyond.LoginManager.FFlowConditioncondition  // 0x28
  public            System.Single                   disableDelay  // 0x30
METHODS:
END_CLASS

CLASS: FFlowCondition
TYPE:  struct
TOKEN: 0x2000031
FIELDS:
  private           Beyond.Login.LoginWorkFlow.ENode<priTarget>k__BackingField  // 0x10
  private           Beyond.Login.LoginWorkFlow.ENode<secTarget>k__BackingField  // 0x14
METHODS:
  Beyond.Login.LoginWorkFlow.ENode get_priTarget()
  System.Void set_priTarget(Beyond.Login.LoginWorkFlow.ENode value)
  Beyond.Login.LoginWorkFlow.ENode get_secTarget()
  System.Void set_secTarget(Beyond.Login.LoginWorkFlow.ENode value)
  System.Void .ctor(Beyond.Login.LoginWorkFlow.ENode target)
  System.Void .ctor(Beyond.Login.LoginWorkFlow.ENode first, Beyond.Login.LoginWorkFlow.ENode second)
  System.Boolean IsTargetMatch(Beyond.Login.LoginWorkFlow.ENode node)
END_CLASS

CLASS: SwitchSceneTrigger
TYPE:  class
TOKEN: 0x2000049
FIELDS:
  private           System.Boolean                  m_isTweenFinished  // 0x10
  private           System.Action                   m_switchToScene  // 0x18
METHODS:
  System.Void .ctor(System.Action switchToScene)
  System.Void NotifyTweenFinished()
  System.Void _TryTriggerSwitchScene()
END_CLASS

CLASS: SplashConfig
TYPE:  struct
TOKEN: 0x200004A
FIELDS:
  public            UnityEngine.Sprite              sprite  // 0x10
  public            System.Boolean                  blackCoverFadeOut  // 0x18
METHODS:
END_CLASS

CLASS: SplashConfigOverride
TYPE:  struct
TOKEN: 0x200004B
FIELDS:
  public            Beyond.GEnums.EnvLang           envLang  // 0x10
  public            Beyond.UI.SplashController.SplashConfig[]splashConfigs  // 0x18
METHODS:
END_CLASS

CLASS: SplashConfigs
TYPE:  struct
TOKEN: 0x200004C
FIELDS:
  public            Beyond.UI.SplashController.SplashConfig[]splashConfigs  // 0x10
  public            Beyond.UI.SplashController.SplashConfig[]splashConfigsVNMobile  // 0x18
  public            Beyond.UI.SplashController.SplashConfigOverride[]i18nSplashConfigOverrides  // 0x20
METHODS:
END_CLASS

CLASS: HttpPostRequest
TYPE:  struct
TOKEN: 0x2000052
FIELDS:
  public            System.String                   url  // 0x10
  public            System.String                   param  // 0x18
  public            System.String                   contentType  // 0x20
  public            System.Collections.Generic.Dictionary<System.String,System.String>header  // 0x28
  public            System.Action<Beyond.SDK.SDKNetUtils.WebHttpResponse>callback  // 0x30
METHODS:
END_CLASS

CLASS: HttpGetRequest
TYPE:  struct
TOKEN: 0x2000053
FIELDS:
  public            System.String                   url  // 0x10
  public            System.Action<Beyond.SDK.SDKNetUtils.WebHttpResponse>callback  // 0x18
METHODS:
END_CLASS

CLASS: WebHttpResponse
TYPE:  struct
TOKEN: 0x2000054
FIELDS:
  public            System.Boolean                  isTimeout  // 0x10
  public            System.Boolean                  isError  // 0x11
  public            System.Int64                    responseCode  // 0x18
  public            System.Collections.Generic.Dictionary<System.String,System.String>header  // 0x20
  public            System.String                   text  // 0x28
  public            System.Byte[]                   data  // 0x30
  public            System.String                   error  // 0x38
METHODS:
END_CLASS

CLASS: HTTPOptType
TYPE:  struct
TOKEN: 0x2000055
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.SDK.SDKNetUtils.HTTPOptTypeGET  // 0x0
  public    static  Beyond.SDK.SDKNetUtils.HTTPOptTypePOST  // 0x0
METHODS:
END_CLASS

CLASS: HTTPConfig
TYPE:  struct
TOKEN: 0x2000056
FIELDS:
  public            System.String                   url  // 0x10
  public            System.String                   body  // 0x18
  public            System.String                   contentType  // 0x20
  public            System.Collections.Generic.Dictionary<System.String,System.String>header  // 0x28
  public            Beyond.SDK.SDKNetUtils.HTTPOptTypeoptType  // 0x30
  public            System.Action<Beyond.SDK.SDKNetUtils.WebHttpResponse>callback  // 0x38
METHODS:
END_CLASS

CLASS: HTTPImpl
TYPE:  class
TOKEN: 0x2000057
FIELDS:
METHODS:
  System.Collections.IEnumerator DoHTTP(Beyond.SDK.SDKNetUtils.HTTPConfig config)
  System.Void .ctor()
END_CLASS

CLASS: BeyondHttp
TYPE:  class
TOKEN: 0x2000058
EXTENDS: HTTPImpl
FIELDS:
METHODS:
  System.Collections.IEnumerator DoHTTP(Beyond.SDK.SDKNetUtils.HTTPConfig config)
  System.Void .ctor()
END_CLASS

CLASS: FHGSDKInit
TYPE:  struct
TOKEN: 0x200005C
FIELDS:
  public            System.Boolean                  isIniting  // 0x10
  public            System.Boolean                  isInited  // 0x11
METHODS:
END_CLASS

CLASS: CaptchaHandler
TYPE:  class
TOKEN: 0x200005D
EXTENDS: SDKCaptchaHandler
FIELDS:
  private   static  System.Int32                    FAILED  // 0x0
  private           System.Int64                    m_flag  // 0x10
  private           System.String                   m_desc  // 0x18
METHODS:
  System.Collections.IEnumerator FetchCaptchaCoroutine(System.String captchaParams, U8.SDK.SDKCaptchaHandler.Result outResult)
  System.Void OnGT3Message(System.Collections.Generic.Dictionary<System.String,System.Object> msg)
  System.Void .ctor()
END_CLASS

CLASS: AppVersionRespone
TYPE:  class
TOKEN: 0x2000067
FIELDS:
  public            System.Int32                    action  // 0x10
  public            System.Int32                    state  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: WorkProcess
TYPE:  class
TOKEN: 0x200006F
EXTENDS: CustomYieldInstruction
FIELDS:
  private           Beyond.Login.LoginCreateRoleNodem_closure  // 0x10
  private           System.Boolean                  m_isFinished  // 0x18
METHODS:
  System.Void .ctor(Beyond.Login.LoginCreateRoleNode closure)
  System.Boolean get_keepWaiting()
  System.Void Dispose()
END_CLASS

CLASS: CodeType
TYPE:  struct
TOKEN: 0x2000078
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Login.LoginGameUpdater.CodeTypeCODE_2103  // 0x0
  public    static  Beyond.Login.LoginGameUpdater.CodeTypeCODE_2105  // 0x0
  public    static  Beyond.Login.LoginGameUpdater.CodeTypeCODE_2200  // 0x0
  public    static  Beyond.Login.LoginGameUpdater.CodeTypeCODE_2201  // 0x0
  public    static  Beyond.Login.LoginGameUpdater.CodeTypeCODE_2202  // 0x0
  public    static  Beyond.Login.LoginGameUpdater.CodeTypeCODE_2203  // 0x0
  public    static  Beyond.Login.LoginGameUpdater.CodeTypeCODE_2204  // 0x0
  public    static  Beyond.Login.LoginGameUpdater.CodeTypeCODE_2205  // 0x0
  public    static  Beyond.Login.LoginGameUpdater.CodeTypeCODE_2206  // 0x0
  public    static  Beyond.Login.LoginGameUpdater.CodeTypeCODE_2207  // 0x0
  public    static  Beyond.Login.LoginGameUpdater.CodeTypeCODE_2208  // 0x0
  public    static  Beyond.Login.LoginGameUpdater.CodeTypeCODE_2209  // 0x0
METHODS:
END_CLASS

CLASS: UpdateType
TYPE:  struct
TOKEN: 0x2000079
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Login.LoginGameUpdater.UpdateTypeFullUpdate  // 0x0
  public    static  Beyond.Login.LoginGameUpdater.UpdateTypeIncrementalUpdate  // 0x0
  public    static  Beyond.Login.LoginGameUpdater.UpdateTypeGoToBilibile  // 0x0
  public    static  Beyond.Login.LoginGameUpdater.UpdateTypeGoToTaptap  // 0x0
  public    static  Beyond.Login.LoginGameUpdater.UpdateTypeGoToAppStore  // 0x0
  public    static  Beyond.Login.LoginGameUpdater.UpdateTypeGoToGooglePlay  // 0x0
  public    static  Beyond.Login.LoginGameUpdater.UpdateTypeGoToSamsungStore  // 0x0
  public    static  Beyond.Login.LoginGameUpdater.UpdateTypeGoToRustore  // 0x0
METHODS:
END_CLASS

CLASS: UpdateCode
TYPE:  struct
TOKEN: 0x200007A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Login.LoginGameUpdater.UpdateCodeSuccess  // 0x0
METHODS:
END_CLASS

CLASS: UpdateAction
TYPE:  struct
TOKEN: 0x200007B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Login.LoginGameUpdater.UpdateActionInvalid  // 0x0
  public    static  Beyond.Login.LoginGameUpdater.UpdateActionLatest  // 0x0
  public    static  Beyond.Login.LoginGameUpdater.UpdateActionForcedUpdate  // 0x0
  public    static  Beyond.Login.LoginGameUpdater.UpdateActionOptionalUpdate  // 0x0
  public    static  Beyond.Login.LoginGameUpdater.UpdateActionError  // 0x0
  public    static  Beyond.Login.LoginGameUpdater.UpdateActionCongestion  // 0x0
METHODS:
END_CLASS

CLASS: HGLatestGameInfo
TYPE:  class
TOKEN: 0x200007C
FIELDS:
  public            System.Int32                    code  // 0x10
  public            System.String                   version  // 0x18
  public            System.Int32                    action  // 0x20
  public            System.Int32                    updateType  // 0x24
  public            System.String                   updateInfo  // 0x28
  public            System.Int32                    state  // 0x30
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: NotificationTitleConfig
TYPE:  class
TOKEN: 0x200007D
FIELDS:
  public            System.String                   downloading  // 0x10
  public            System.String                   pause  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HGUpdateConfig
TYPE:  class
TOKEN: 0x200007E
FIELDS:
  public            System.String                   downloadPath  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Options
TYPE:  struct
TOKEN: 0x200007F
FIELDS:
  public            Beyond.Login.NetUsagePolicy     netUsagePolicy  // 0x10
  public            System.Action<System.String,System.Action>alertDialog  // 0x18
  public            Beyond.LoginContext             loginContext  // 0x20
METHODS:
END_CLASS

CLASS: Result
TYPE:  class
TOKEN: 0x2000080
FIELDS:
  public            System.Boolean                  needRetry  // 0x10
  public            System.String                   errorInfo  // 0x18
  public            System.Int32                    code  // 0x20
  public            System.Boolean                  auditing  // 0x24
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Context
TYPE:  class
TOKEN: 0x2000081
FIELDS:
  public            System.Int64                    taskId  // 0x10
  public            System.String                   errorInfo  // 0x18
  public            System.String                   logError  // 0x20
  public            System.Boolean                  needClear  // 0x28
  public            Beyond.Login.LoginGameUpdater.HGLatestGameInfogameInfo  // 0x30
  private           System.Boolean                  <complete>k__BackingField  // 0x38
  private           System.Int32                    <code>k__BackingField  // 0x3C
METHODS:
  System.Boolean get_complete()
  System.Void set_complete(System.Boolean value)
  System.Int32 get_code()
  System.Void set_code(System.Int32 value)
  System.Void CompleteWithCode(System.Int32 pCode)
  System.Void UncompleteWithCode(System.Int32 pCode)
  System.Void .ctor()
END_CLASS

CLASS: EnterGameServiceFlow
TYPE:  class
TOKEN: 0x200008E
EXTENDS: CustomYieldInstruction
FIELDS:
  private           Beyond.LoginContext             m_context  // 0x10
  private           Beyond.Login.LoginGSNode        m_curNode  // 0x18
  private           Beyond.Misc.ObjectRef           m_dialogBlocker  // 0x20
  private           System.Int32                    m_state  // 0x28
METHODS:
  System.Boolean get_keepWaiting()
  System.Void .ctor(Beyond.Login.LoginGSNode node)
  System.Void MarkAborting()
  System.Void EnterGame()
  System.Boolean IsInterruptable()
  System.Boolean TryInterrupt()
  System.Collections.IEnumerator _EnterGameCoroutine()
  System.Collections.IEnumerator _NetConnectAndGSLogin(System.String uid, System.String token, Beyond.Misc.ObjectRef loginRespRef)
  System.String _ExtractErrorInfo(Beyond.Network.HttpSender.Result result, System.String keyErrorWithCode, System.String keyTimeout)
  System.Collections.IEnumerator _YieldAlertError(System.String errorInfo)
  System.Collections.IEnumerator _SaveCurrentUserToServerConfig(System.String uid)
  System.Collections.IEnumerator _MockManualSelectServer(System.String uid)
  System.Collections.IEnumerator _OnAuthError(System.Object rejectInfo)
  System.Void _ReLoginWhenErrorEncountered()
  System.Void _GlobalLoginSucBusiness(Proto.MSG_B1 msg)
  System.Boolean <_EnterGameCoroutine>b__11_0()
END_CLASS

CLASS: IProgress
TYPE:  interface
TOKEN: 0x2000099
FIELDS:
METHODS:
  System.Double GetTotal()
  System.Double GetCurrent()
  System.String GetInfo()
END_CLASS

CLASS: SimpleProgress
TYPE:  class
TOKEN: 0x200009A
FIELDS:
  public            System.Double                   current  // 0x10
METHODS:
  System.Double GetCurrent()
  System.Double GetTotal()
  System.String GetInfo()
  System.Void .ctor()
END_CLASS

CLASS: HotUpdateInfo
TYPE:  class
TOKEN: 0x200009C
FIELDS:
  public            Beyond.Resource.HotUpdate.FResourceDiffresDiff  // 0x10
  public            Beyond.Resource.HotUpdate.LocalResPreflocalResPref  // 0x50
METHODS:
  System.Boolean CheckIfNeedReload()
  System.Boolean HasChangedByType(Beyond.VFS.EVFSBlockType type)
  System.Boolean HasAssetsChanged()
  System.Void .ctor()
END_CLASS

CLASS: WorkContext
TYPE:  class
TOKEN: 0x200009D
FIELDS:
  public            Beyond.Login.LoginHotUpdater.HotUpdateInfoupdateInitial  // 0x10
  public            Beyond.Login.LoginHotUpdater.HotUpdateInfoupdateMain  // 0x18
  public            System.String                   vitalError  // 0x20
  public            System.Boolean                  reboot  // 0x28
  public            Beyond.Login.NetUsagePolicy     netUsagePolicy  // 0x30
  public            Beyond.Resource.HotUpdate.ResourceIndexresIndex  // 0x38
  private           System.Boolean                  <illegalItemsInLocalRes>k__BackingField  // 0x40
METHODS:
  System.Boolean get_illegalItemsInLocalRes()
  System.Void set_illegalItemsInLocalRes(System.Boolean value)
  System.Void MarkIllegalItemsInLocalRes()
  Beyond.Login.LoginHotUpdater.HotUpdateInfo GetHotUpdateInfo(System.Boolean isInitial)
  System.Boolean HasChangedByType(Beyond.VFS.EVFSBlockType type)
  System.Void .ctor()
END_CLASS

CLASS: EUnit
TYPE:  struct
TOKEN: 0x20000B6
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Login.LoginProgress.FDownloadSize.EUnitNONE  // 0x0
  public    static  Beyond.Login.LoginProgress.FDownloadSize.EUnitB  // 0x0
  public    static  Beyond.Login.LoginProgress.FDownloadSize.EUnitKB  // 0x0
  public    static  Beyond.Login.LoginProgress.FDownloadSize.EUnitMB  // 0x0
METHODS:
END_CLASS

CLASS: FDownloadSize
TYPE:  struct
TOKEN: 0x20000B5
FIELDS:
  private   static  System.Double                   MB  // 0x0
  private   static  System.Double                   KB  // 0x0
  private           Beyond.Login.LoginProgress.FDownloadSize.EUnitm_unit  // 0x10
  private           System.Single                   m_displayCurrent  // 0x14
  private           System.Single                   m_displayTotal  // 0x18
  private           System.Single                   m_displaySpeed  // 0x1C
  public            System.String                   displayInfo  // 0x20
  private           System.Single                   m_current  // 0x28
  private           System.Single                   m_total  // 0x2C
METHODS:
  System.Void SetProgress(System.Double current, System.Double total)
  System.Void SetIdle()
  System.Void SetSize(System.Double current, System.Double total, System.Double speed)
  Beyond.Login.LoginProgress.FDownloadSize.EUnit _PickUnit(System.Double number)
  System.Single _DisplayWithUnit(System.Double number, Beyond.Login.LoginProgress.FDownloadSize.EUnit unit)
  System.String _FormatDisplayInfo(System.Single current, System.Single total, Beyond.Login.LoginProgress.FDownloadSize.EUnit unit)
  System.String _FormatSpeedInfo(System.Single speed, Beyond.Login.LoginProgress.FDownloadSize.EUnit unit)
  System.String _FormatProgressInfo(System.Single current, System.Single total)
END_CLASS

CLASS: FAgeTipsPolicy
TYPE:  struct
TOKEN: 0x20000D1
FIELDS:
  public            System.Boolean                  canOpenDetail  // 0x10
  public            System.Boolean                  displayCN  // 0x11
  public            System.Boolean                  displayKR  // 0x12
METHODS:
  System.Boolean get_display()
END_CLASS

CLASS: Node
TYPE:  class
TOKEN: 0x20000D6
FIELDS:
  private           Beyond.LoginContext             <context>k__BackingField  // 0x10
  private           Beyond.Login.LoginWorkFlow      <workflow>k__BackingField  // 0x18
METHODS:
  Beyond.LoginContext get_context()
  System.Void set_context(Beyond.LoginContext value)
  Beyond.Login.LoginWorkFlow get_workflow()
  System.Void set_workflow(Beyond.Login.LoginWorkFlow value)
  System.Void Init(Beyond.LoginContext context, Beyond.Login.LoginWorkFlow workflow)
  System.Void Dispose()
  Beyond.Login.LoginWorkFlow.ENode get_type()
  UnityEngine.CustomYieldInstruction Work()
  System.Boolean CanCancel()
  UnityEngine.CustomYieldInstruction Cancel()
  System.Void OnInit()
  System.Void OnDispose()
  System.Boolean OnEvent(Beyond.ELoginEvent evt, System.Object param)
  System.Void .ctor()
END_CLASS

CLASS: ENode
TYPE:  struct
TOKEN: 0x20000D7
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Login.LoginWorkFlow.ENodeNone  // 0x0
  public    static  Beyond.Login.LoginWorkFlow.ENodeCheckForUpdate  // 0x0
  public    static  Beyond.Login.LoginWorkFlow.ENodeSDKInit  // 0x0
  public    static  Beyond.Login.LoginWorkFlow.ENodeGameUpdate  // 0x0
  public    static  Beyond.Login.LoginWorkFlow.ENodeInit  // 0x0
  public    static  Beyond.Login.LoginWorkFlow.ENodeU8Login  // 0x0
  public    static  Beyond.Login.LoginWorkFlow.ENodeHotUpdate  // 0x0
  public    static  Beyond.Login.LoginWorkFlow.ENodeResCheck  // 0x0
  public    static  Beyond.Login.LoginWorkFlow.ENodePreload  // 0x0
  public    static  Beyond.Login.LoginWorkFlow.ENodePreloadPostDelay  // 0x0
  public    static  Beyond.Login.LoginWorkFlow.ENodeTrans2GsLogin  // 0x0
  public    static  Beyond.Login.LoginWorkFlow.ENodeGsLogin  // 0x0
  public    static  Beyond.Login.LoginWorkFlow.ENodeCreateRole  // 0x0
  public    static  Beyond.Login.LoginWorkFlow.ENodeFinish  // 0x0
METHODS:
END_CLASS

CLASS: IWorkerUpdateOnce
TYPE:  interface
TOKEN: 0x20000D8
FIELDS:
METHODS:
  System.Void Worker_UpdateOnce()
END_CLASS

CLASS: IEventReceiver
TYPE:  interface
TOKEN: 0x20000D9
FIELDS:
METHODS:
  System.Void OnEvent(Beyond.ELoginEvent evt, System.Object param)
END_CLASS

CLASS: Worker
TYPE:  class
TOKEN: 0x20000DA
FIELDS:
  private           System.Collections.Generic.HashSet<Beyond.Login.LoginWorkFlow.IWorkerUpdateOnce>m_updateOnce  // 0x10
  private           System.Collections.Generic.List<Beyond.Login.LoginWorkFlow.IWorkerUpdateOnce>m_buffer  // 0x18
  private           UnityEngine.CustomYieldInstructionm_curWork  // 0x20
  private           System.Boolean                  <isCancelled>k__BackingField  // 0x28
  private           System.Boolean                  <isDisposed>k__BackingField  // 0x29
  private           Beyond.Login.LoginWorkFlow.Node <curNode>k__BackingField  // 0x30
METHODS:
  System.Boolean get_isCancelled()
  System.Void set_isCancelled(System.Boolean value)
  System.Boolean get_isDisposed()
  System.Void set_isDisposed(System.Boolean value)
  Beyond.Login.LoginWorkFlow.Node get_curNode()
  System.Void set_curNode(Beyond.Login.LoginWorkFlow.Node value)
  System.Boolean Cancel()
  System.Void Dispose()
  System.Void SetCurNode(Beyond.Login.LoginWorkFlow.Node node)
  System.Boolean UpdateOnce(Beyond.Login.LoginWorkFlow.IWorkerUpdateOnce inst)
  System.Void TickInEmptyFrame()
  System.Collections.IEnumerator Work(UnityEngine.CustomYieldInstruction work)
  System.Void _InternalTick()
  System.Void .ctor()
END_CLASS

CLASS: FWork
TYPE:  struct
TOKEN: 0x20000DC
FIELDS:
  public    static readonly Beyond.Login.LoginWorkFlow.FWorkIDLE  // 0x0
  private           System.Boolean                  <didFallback>k__BackingField  // 0x10
  private           System.Int32                    <nodeIndex>k__BackingField  // 0x14
  private           System.Boolean                  <isWorking>k__BackingField  // 0x18
METHODS:
  System.Boolean get_didFallback()
  System.Void set_didFallback(System.Boolean value)
  System.Int32 get_nodeIndex()
  System.Void set_nodeIndex(System.Int32 value)
  System.Boolean get_isWorking()
  System.Void set_isWorking(System.Boolean value)
  System.Void MarkFallback(System.Int32 newIndex)
  System.Boolean ConsumeFallback()
  System.Void MoveNextIndex()
  Beyond.Login.LoginWorkFlow.FWork Start()
  Beyond.Login.LoginWorkFlow.ENode get_curNode()
  System.Boolean WorkEnd()
  System.Void .cctor()
END_CLASS

CLASS: Options
TYPE:  struct
TOKEN: 0x20000E7
FIELDS:
  public            System.Int64                    minBytesToNotifyCarrier  // 0x10
METHODS:
END_CLASS

CLASS: EState
TYPE:  struct
TOKEN: 0x20000EA
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Login.LoginSceneAnimCtrl.EStateNONE  // 0x0
  public    static  Beyond.Login.LoginSceneAnimCtrl.EStateA1  // 0x0
  public    static  Beyond.Login.LoginSceneAnimCtrl.EStateA2  // 0x0
METHODS:
END_CLASS

CLASS: FParams
TYPE:  struct
TOKEN: 0x20000F0
FIELDS:
  public            System.String                   text  // 0x10
  public            System.Action                   onConfirm  // 0x18
METHODS:
END_CLASS

CLASS: Style
TYPE:  struct
TOKEN: 0x20000F5
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Login.LoginJudgeDialog.StyleCenter  // 0x0
  public    static  Beyond.Login.LoginJudgeDialog.StyleLeft  // 0x0
METHODS:
END_CLASS

CLASS: FParams
TYPE:  struct
TOKEN: 0x20000F6
FIELDS:
  public            System.String                   text  // 0x10
  public            System.Action                   onPositive  // 0x18
  public            System.Action                   onNegative  // 0x20
  public            System.String                   btnPositive  // 0x28
  public            System.String                   btnNegative  // 0x30
  public            Beyond.Login.LoginJudgeDialog.Stylestyle  // 0x38
METHODS:
END_CLASS

CLASS: FOptions
TYPE:  struct
TOKEN: 0x20000FA
FIELDS:
  public            System.String                   fixedUID  // 0x10
  public            Beyond.LoginContext             context  // 0x18
METHODS:
  System.Boolean IsUIDFixed()
END_CLASS

CLASS: ChildPanel
TYPE:  class
TOKEN: 0x20000FE
EXTENDS: MonoBehaviour
FIELDS:
  private           Beyond.UI.UISwitchTween         <switchTween>k__BackingField  // 0x18
  private           Beyond.LoginContext             <context>k__BackingField  // 0x20
METHODS:
  Beyond.UI.UISwitchTween get_switchTween()
  System.Void set_switchTween(Beyond.UI.UISwitchTween value)
  Beyond.LoginContext get_context()
  System.Void set_context(Beyond.LoginContext value)
  System.Void OnLoginContext(Beyond.LoginContext context)
  System.Void OnInit()
  System.Void OnDestroy()
  System.Void SetPanelVisibleByAnimSwitchTween(Beyond.UI.UIAnimationWrapper anim, System.Boolean isVisible, System.Boolean forceReset)
  System.Void SetPanelVisibleByFadeSwitchTween(UnityEngine.CanvasGroup canvasGroup, System.Boolean isVisible, System.Boolean forceReset)
  System.Void .ctor()
END_CLASS

CLASS: DelayInfo
TYPE:  struct
TOKEN: 0x2000100
FIELDS:
  public            UnityEngine.Color               color  // 0x10
  public            System.Int32                    colorCount  // 0x20
  public            System.Int32                    delayMax  // 0x24
  public            System.String                   text  // 0x28
METHODS:
END_CLASS

CLASS: FParams
TYPE:  struct
TOKEN: 0x2000108
FIELDS:
  public            System.Action                   onConfirm  // 0x10
METHODS:
END_CLASS

CLASS: VocResInfo
TYPE:  class
TOKEN: 0x2000109
FIELDS:
  public            System.String                   nameTextId  // 0x10
  public            Beyond.VFS.EVFSBlockType        type  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: GameSettingSetterItem`1
TYPE:  class
TOKEN: 0x200010C
FIELDS:
  private   readonly System.String                   m_settingId  // 0x0
  private   readonly System.Action<T>                m_otherSystemSet  // 0x0
METHODS:
  System.Void .ctor(System.String settingId)
  System.Void .ctor(System.String settingId, System.Action<T> otherSystemSet)
  System.Void Set(T value, System.Boolean forceSetOtherSystem)
END_CLASS

CLASS: GameSettingSetterItem`2
TYPE:  class
TOKEN: 0x200010D
FIELDS:
  private   readonly System.String                   m_mainSettingId  // 0x0
  private   readonly System.String                   m_settingId1  // 0x0
  private   readonly System.String                   m_settingId2  // 0x0
  private   readonly System.Action<T1,T2>            m_otherSystemSet  // 0x0
METHODS:
  System.Void .ctor(System.String mainSettingId, System.String settingId1, System.String settingId2, System.Action<T1,T2> otherSystemSet)
  System.Void Set(T1 value1, T2 value2, System.Boolean forceSetOtherSystem)
END_CLASS

CLASS: __StaticArrayInitTypeSize=52
TYPE:  struct
TOKEN: 0x2000110
FIELDS:
METHODS:
END_CLASS

CLASS: Beyond.GameApp
TYPE:  class
TOKEN: 0x2000004
EXTENDS: MonoBehaviour
FIELDS:
  private           Beyond.GameStateMachine         m_stateMachine  // 0x18
  private   static  Beyond.GameApp                  <instance>k__BackingField  // 0x0
  private           System.Boolean                  m_hasFocus  // 0x20
  private           System.Boolean                  m_needCallLuaFocus  // 0x21
  private           System.Boolean                  m_pauseStatus  // 0x22
  private           System.Boolean                  m_needCallLuaPause  // 0x23
METHODS:
  Beyond.GameApp get_instance()
  System.Void set_instance(Beyond.GameApp value)
  Beyond.GameState get_currentState()
  System.Void SwitchState(Beyond.GameState state)
  System.Void Awake()
  System.Void _RegisterLuaAfterGCEvent()
  System.Void Update()
  System.Void LateUpdate()
  System.Void OnApplicationQuit()
  System.Void OnApplicationFocus(System.Boolean hasFocus)
  System.Void _OnApplicationFocusForLua()
  System.Void OnApplicationPause(System.Boolean pauseStatus)
  System.Void _OnApplicationPauseForLua()
  System.Void OnDestroy()
  System.Void _Init()
  System.Void _UnInit()
  System.Void _InitGameStateMachine()
  System.Void _UnInitGameStateMachine()
  System.Void QuitGame(System.Int32 exitCode)
  System.Void RefreshScreenResolution()
  System.Void _OnSystemDisplaySizeChanged()
  System.Void _OnSystemScreenSizeChanged(Beyond.EventData<System.Boolean,System.Boolean>& data)
  System.Collections.IEnumerator _InitSecuritySDK()
  System.Void _OnApplicationPauseForSecurity(System.Boolean pauseStatus)
  System.Collections.IEnumerator _FetchRemoteConfigUtilSuc()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.IMemoryPackProxy
TYPE:  interface
TOKEN: 0x2000007
FIELDS:
METHODS:
  System.Void Init()
END_CLASS

CLASS: Beyond.MemoryPackProxyModule
TYPE:  class
TOKEN: 0x2000008
FIELDS:
  private   static  Beyond.IMemoryPackProxy         s_memoryPackProxy  // 0x0
METHODS:
  System.Void RegisterProxy(Beyond.IMemoryPackProxy memoryPackProxy)
  Beyond.IMemoryPackProxy GetMemoryPackProxy()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.GameInitState
TYPE:  class
TOKEN: 0x2000009
EXTENDS: GameStateBase
FIELDS:
METHODS:
  Beyond.GameState get_stateId()
  System.Void .ctor(Beyond.GameStateMachine stateMachine)
  System.Void OnEnter(Beyond.GameState fromStateId)
  System.Void OnLeave(Beyond.GameState toStateId)
  System.Void _DoInit()
  System.Void _InitInitialResourceManager(Beyond.VFS.VirtualFileSystem.BlockValidator& blockValidator)
  System.Boolean _CheckIfLocalInitialAssetsValid(Beyond.Resource.HotUpdate.LocalResPref& outputLocalResPref, Beyond.VFS.VirtualFileSystem.BlockValidator& blockValidator)
  System.Void _InitAPPDefaultCulture()
  System.Void _PreInitGameSetting()
  System.Void _InitGameSetting()
  System.Void <>iFixBaseProxy_OnEnter(Beyond.GameState P0)
  System.Void <>iFixBaseProxy_OnLeave(Beyond.GameState P0)
END_CLASS

CLASS: Beyond.GameLoginState
TYPE:  class
TOKEN: 0x200000A
EXTENDS: GameStateBase
FIELDS:
METHODS:
  Beyond.GameState get_stateId()
  System.Void .ctor(Beyond.GameStateMachine stateMachine)
  System.Void OnEnter(Beyond.GameState fromStateId)
  System.Void OnLeave(Beyond.GameState toStateId)
  System.Void _TryStartLoginWorkflow()
  System.Void <>iFixBaseProxy_OnEnter(Beyond.GameState P0)
  System.Void <>iFixBaseProxy_OnLeave(Beyond.GameState P0)
END_CLASS

CLASS: Beyond.GameMainState
TYPE:  class
TOKEN: 0x200000B
EXTENDS: GameStateBase
FIELDS:
  private           System.Boolean                  m_isFirstEnter  // 0x18
METHODS:
  Beyond.GameState get_stateId()
  System.Void .ctor(Beyond.GameStateMachine stateMachine)
  System.Void OnEnter(Beyond.GameState fromStateId)
  System.Void OnLeave(Beyond.GameState toStateId)
  System.Void ReleaseMainGame(Beyond.GameState toStateId)
  System.Void _ClearUtils()
  System.Void <>iFixBaseProxy_OnEnter(Beyond.GameState P0)
  System.Void <>iFixBaseProxy_OnLeave(Beyond.GameState P0)
END_CLASS

CLASS: Beyond.GamePreloadState
TYPE:  class
TOKEN: 0x200000C
EXTENDS: GameStateBase
FIELDS:
  private           Beyond.Cfg.Tables.AsyncLoadTask m_asyncTask  // 0x18
METHODS:
  Beyond.GameState get_stateId()
  System.Void .ctor(Beyond.GameStateMachine stateMachine)
  System.Void OnEnter(Beyond.GameState fromStateId)
  System.Void OnLeave(Beyond.GameState toStateId)
  System.Collections.IEnumerator _DoPreload()
  System.Void _InitGameSettingStateInPreload()
  System.Void <>iFixBaseProxy_OnEnter(Beyond.GameState P0)
  System.Void <>iFixBaseProxy_OnLeave(Beyond.GameState P0)
END_CLASS

CLASS: Beyond.GameQuitState
TYPE:  class
TOKEN: 0x200000E
EXTENDS: GameStateBase
FIELDS:
METHODS:
  Beyond.GameState get_stateId()
  System.Void .ctor(Beyond.GameStateMachine stateMachine)
  System.Void OnEnter(Beyond.GameState fromStateId)
  System.Void OnLeave(Beyond.GameState toStateId)
  System.Void DoQuit()
  System.Void <>iFixBaseProxy_OnEnter(Beyond.GameState P0)
  System.Void <>iFixBaseProxy_OnLeave(Beyond.GameState P0)
END_CLASS

CLASS: Beyond.GameStartState
TYPE:  class
TOKEN: 0x200000F
EXTENDS: GameStateBase
FIELDS:
METHODS:
  Beyond.GameState get_stateId()
  System.Void .ctor(Beyond.GameStateMachine stateMachine)
  System.Void OnEnter(Beyond.GameState fromStateId)
  System.Void OnLeave(Beyond.GameState toStateId)
  System.Void _OnEnterMainGame()
  System.Void <_OnEnterMainGame>b__5_0()
  System.Void <>iFixBaseProxy_OnEnter(Beyond.GameState P0)
  System.Void <>iFixBaseProxy_OnLeave(Beyond.GameState P0)
END_CLASS

CLASS: Beyond.GameStateBase
TYPE:  class
TOKEN: 0x2000010
FIELDS:
  protected readonly Beyond.GameStateMachine         m_stateMachine  // 0x10
METHODS:
  System.Void .ctor(Beyond.GameStateMachine stateMachine)
  Beyond.GameState get_stateId()
  System.Void OnEnter(Beyond.GameState fromStateId)
  System.Void OnLeave(Beyond.GameState toStateId)
  System.Void OnTick(System.Single deltaTime)
END_CLASS

CLASS: Beyond.GameStateMachine
TYPE:  class
TOKEN: 0x2000011
EXTENDS: SimpleEnumStateMachine`1
FIELDS:
  private   readonly Beyond.GameApp                  <app>k__BackingField  // 0x30
METHODS:
  Beyond.GameApp get_app()
  Beyond.GameState get_curState()
  System.Void .ctor(Beyond.GameApp gameApp)
  System.Void _RegisterStates()
  System.Boolean CheckCanReturnToLoginState()
  System.Collections.IEnumerator ReturnToLoginState()
END_CLASS

CLASS: Beyond.GlobalInitializer
TYPE:  class
TOKEN: 0x2000013
FIELDS:
METHODS:
  System.Void InitGlobalConfig()
END_CLASS

CLASS: Beyond.IHotFixCommon
TYPE:  interface
TOKEN: 0x2000014
FIELDS:
METHODS:
END_CLASS

CLASS: Beyond.IHotFixPatchManagerProxy
TYPE:  interface
TOKEN: 0x2000015
FIELDS:
METHODS:
  System.Void InitManager()
  System.Void ReleaseManager()
  System.Void PatchInitAssemble()
  System.Void PatchRemoteInitAssemble()
  System.Void PatchMainAssemble()
  System.Void PatchRemoteMainAssemble()
END_CLASS

CLASS: Beyond.HotFixPatchModules
TYPE:  class
TOKEN: 0x2000016
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.Type,Beyond.IHotFixCommon>s_hotFixModules  // 0x0
METHODS:
  System.Void Register(T module)
  System.Void UnRegister()
  T GetModule()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.InitialPathDef
TYPE:  class
TOKEN: 0x2000017
FIELDS:
  public    static  System.String                   SPLASH_SCENE_PATH  // 0x0
  public    static  System.String                   LOGIN_SCENE_PATH  // 0x0
  public    static  System.String                   LOGIN_SK_ACTOR_M  // 0x0
  public    static  System.String                   LOGIN_SK_ACTOR_F  // 0x0
  public    static  System.String                   LOGIN_SK_ACTOR_NO_GENDER  // 0x0
  public    static  System.String                   LOGIN_MOCK_UID_PANEL  // 0x0
  public    static  System.String                   LOGIN_CONTROLLER_PATH  // 0x0
  public    static  System.String                   LOGIN_ROOT_PANEL_PATH  // 0x0
  public    static  System.String                   LOGIN_ALERT_DIALOG_PATH  // 0x0
  public    static  System.String                   LOGIN_JUDGE_DIALOG_PATH  // 0x0
  public    static  System.String                   LOGIN_VOC_RES_SELECT_DIALOG_PATH  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.LoginController
TYPE:  class
TOKEN: 0x2000018
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.Transform           _uiFunc  // 0x18
  private           UnityEngine.Transform           _uiDialog  // 0x20
  private           Beyond.UI.UIButton              _versionBtn  // 0x28
  private           Beyond.Login.LoginDecorateUI    _uiDecorate  // 0x30
  private           Beyond.LoginController.MaskCfg  _maskBlur  // 0x38
  private           Beyond.LoginController.MaskCfg  _maskBlack  // 0x40
  private           Beyond.LoginController.MaskCfg  _maskWhite  // 0x48
  private           System.Single                   _enterGamePanelPredelay  // 0x50
  private           UnityEngine.Canvas              _uiRootCanvas  // 0x58
  private           Beyond.UI.UICanvasScaleHelper   _uiRootCanvasScaleHelper  // 0x60
  private           UnityEngine.Canvas              _uiDecoCanvas  // 0x68
  private           Beyond.UI.UICanvasScaleHelper   _uiDecoCanvasScaleHelper  // 0x70
  private           System.Boolean                  m_isInited  // 0x78
  private           Beyond.LoginController.FOptions m_options  // 0x80
  private           Beyond.LatchUtils.InvokeWhenUnlockm_startLatch  // 0x88
  private           Beyond.LatchUtils.InvokeWhenUnlockm_initLatch  // 0x90
  private           Beyond.Login.LoginWorkFlow.ENodem_lastNode  // 0x98
  private           Beyond.LoginController.MaskCtrl m_maskCtrl  // 0xA0
  private           Beyond.Login.LoginRootPanel     m_rootPanel  // 0xA8
  private           System.Collections.IEnumerator  m_mockLoginRoutine  // 0xB0
  private           System.Action<System.String>    m_onMockLogin  // 0xB8
METHODS:
  Beyond.LoginController.MaskCtrl get_maskCtrl()
  Beyond.Login.LoginRootPanel get_rootPanel()
  System.Void Awake()
  System.Void Start()
  System.Single GetEnterGamePanelPredelay()
  System.Void OnValueChanged(Beyond.Login.LoginViewModel viewModel)
  System.Void InitUI(Beyond.LoginController.FOptions options)
  System.Void InvokeWhenStart(System.Action callback)
  System.Collections.IEnumerator BeforeDestroy()
  System.Collections.IEnumerator _InstantiateUIFromRes(System.String resPath, UnityEngine.Transform parent, Beyond.Misc.ObjectRef objRef)
  System.Void _InitImpl()
  System.Collections.IEnumerator _InitCoroutine()
  System.Void _InitVersionBtn()
  System.Void add_m_onMockLogin(System.Action<System.String> value)
  System.Void remove_m_onMockLogin(System.Action<System.String> value)
  System.Void MockLoginWithCallback(System.String fixedUID, System.Action<System.String> callback)
  System.Collections.IEnumerator _MockLoginCoroutine(System.String fixedUID)
  System.Void .ctor()
  System.Void <MockLoginWithCallback>b__44_0()
END_CLASS

CLASS: Beyond.LoginContext
TYPE:  class
TOKEN: 0x2000028
FIELDS:
  private           Beyond.LoginController          m_controller  // 0x10
  private           System.Boolean                  m_isDisposed  // 0x18
  private           System.Boolean                  <quickStart>k__BackingField  // 0x19
  private           System.Boolean                  <firstLogin>k__BackingField  // 0x1A
  private           Beyond.Login.LoginWorkFlow      <workflow>k__BackingField  // 0x20
  private           Beyond.Login.LoginViewProperty  <viewProp>k__BackingField  // 0x28
  private           Beyond.LoginManager.AssetLoader <loader>k__BackingField  // 0x30
  private           Beyond.LoginManager.FlowWithMaskMgr<flowWithMask>k__BackingField  // 0x38
  private           Beyond.Login.NetUsagePolicy     <netUsagePolicy>k__BackingField  // 0x40
  private           Beyond.Login.LoginGameUpdater   <gameUpdater>k__BackingField  // 0x48
METHODS:
  System.Boolean get_quickStart()
  System.Void set_quickStart(System.Boolean value)
  System.Boolean get_firstLogin()
  System.Void set_firstLogin(System.Boolean value)
  Beyond.Login.LoginWorkFlow get_workflow()
  System.Void set_workflow(Beyond.Login.LoginWorkFlow value)
  Beyond.Login.LoginViewProperty get_viewProp()
  System.Void set_viewProp(Beyond.Login.LoginViewProperty value)
  Beyond.LoginManager.AssetLoader get_loader()
  System.Void set_loader(Beyond.LoginManager.AssetLoader value)
  Beyond.LoginManager.FlowWithMaskMgr get_flowWithMask()
  System.Void set_flowWithMask(Beyond.LoginManager.FlowWithMaskMgr value)
  Beyond.Login.NetUsagePolicy get_netUsagePolicy()
  System.Void set_netUsagePolicy(Beyond.Login.NetUsagePolicy value)
  Beyond.Login.LoginGameUpdater get_gameUpdater()
  System.Void set_gameUpdater(Beyond.Login.LoginGameUpdater value)
  Beyond.LoginController ViewOnlyController()
  System.Void Init(System.Boolean quickStart, Beyond.LoginController controller, Beyond.Login.LoginWorkFlow workflow, Beyond.Login.LoginViewProperty viewProp, Beyond.LoginManager.AssetLoader loader, Beyond.LoginManager.FlowWithMaskMgr flowWithMask, Beyond.Login.NetUsagePolicy netUsagePolicy, Beyond.Login.LoginGameUpdater gameUpdater)
  System.Void StartCoroutine(System.Collections.IEnumerator routine)
  System.Void StopCoroutine(System.Collections.IEnumerator routine)
  System.Void SendEvent(Beyond.ELoginEvent evt, System.Object param)
  System.Void Dispose()
  System.Void ShutDown()
  System.Boolean IsWorkflowDisposed()
  System.Boolean IsDisposed()
  System.Void _DisposeImpl()
  System.Collections.IEnumerator _DisposeCoroutine(Beyond.LoginController legacyController, System.Action disposeAction)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.ELoginEvent
TYPE:  struct
TOKEN: 0x200002A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.ELoginEvent              None  // 0x0
  public    static  Beyond.ELoginEvent              V2C_U8Login  // 0x0
  public    static  Beyond.ELoginEvent              V2C_EnterGame  // 0x0
  public    static  Beyond.ELoginEvent              V2C_Logout  // 0x0
  public    static  Beyond.ELoginEvent              V2C_ResourceRepair  // 0x0
  public    static  Beyond.ELoginEvent              V2C_OpenAgeTips  // 0x0
  public    static  Beyond.ELoginEvent              V2C_CloseAgeTips  // 0x0
  public    static  Beyond.ELoginEvent              V2C_OpenServerSelect  // 0x0
  public    static  Beyond.ELoginEvent              V2C_CloseServerSelect  // 0x0
  public    static  Beyond.ELoginEvent              V2C_SelectServer  // 0x0
  public    static  Beyond.ELoginEvent              V2C_ConfirmServer  // 0x0
  public    static  Beyond.ELoginEvent              V2C_Relogin  // 0x0
  public    static  Beyond.ELoginEvent              V2C_ReplayGsLogin  // 0x0
  public    static  Beyond.ELoginEvent              C2V_PrepareGsLogin  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.LoginTextDefines
TYPE:  class
TOKEN: 0x200002B
FIELDS:
  public    static  System.String                   CS_LOGIN_CONN_FAIL  // 0x0
  public    static  System.String                   HOTUPDATE_INDEX_FAILED  // 0x0
  public    static  System.String                   HOTUPDATE_IO_FAILED  // 0x0
  public    static  System.String                   HOTUPDATE_CHECK_VERSION  // 0x0
  public    static  System.String                   HOTUPDATE_DOWNLOADING  // 0x0
  public    static  System.String                   HOTUPDATE_DECOMPRESSING  // 0x0
  public    static  System.String                   HOTUPDATE_DOWNLOAD_ERROR  // 0x0
  public    static  System.String                   HOTUPDATE_DOWNLOAD_DISKFULL  // 0x0
  public    static  System.String                   HOTUPDATE_LOCAL_RES_CHECK  // 0x0
  public    static  System.String                   HOTUPDATE_PRELOAD_RES  // 0x0
  public    static  System.String                   HOTUPDATE_INVALID_LOCAL_FILES  // 0x0
  public    static  System.String                   HOTUPDATE_INIT_RES_CHANGED  // 0x0
  public    static  System.String                   HOTUPDATE_DOWNLOAD_IO_ERROR  // 0x0
  public    static  System.String                   HOTUPDATE_DOWNLOAD_DATA_CHECK_ERROR  // 0x0
  public    static  System.String                   HOTUPDATE_DOWNLOAD_START_DOWNLOAD_ERROR  // 0x0
  public    static  System.String                   HOTUPDATE_DECOMPRESS_ERROR  // 0x0
  public    static  System.String                   REMOTE_CFG_GAME_CFG_ERROR  // 0x0
  public    static  System.String                   REMOTE_CFG_GAME_CFG_TIMEOUT  // 0x0
  public    static  System.String                   REMOTE_CFG_NETWORK_CFG_ERROR  // 0x0
  public    static  System.String                   REMOTE_CFG_NETWORK_CFG_TIMEOUT  // 0x0
  public    static  System.String                   REMOTE_CFG_RES_VERSION_ERROR  // 0x0
  public    static  System.String                   REMOTE_CFG_RES_VERSION_TIMEOUT  // 0x0
  public    static  System.String                   REMOTE_CFG_GAME_VERSION_ERROR  // 0x0
  public    static  System.String                   REMOTE_CFG_GAME_VERSION_TIMEOUT  // 0x0
  public    static  System.String                   LOGIN_JUDGE_EXIT_GAME  // 0x0
  public    static  System.String                   LOGIN_JUDGE_LOGOUT  // 0x0
  public    static  System.String                   LOGIN_JUDGE_RES_REPAIR  // 0x0
  public    static  System.String                   LOGIN_AGE_TIPS_FAILED  // 0x0
  public    static  System.String                   LOGIN_TXT_DIALOG_CONFIRM  // 0x0
  public    static  System.String                   LOGIN_TXT_DIALOG_CANCEL  // 0x0
  public    static  System.String                   LOGIN_AUDIO_LANG_CN  // 0x0
  public    static  System.String                   LOGIN_AUDIO_LANG_JP  // 0x0
  public    static  System.String                   LOGIN_AUDIO_LANG_EN  // 0x0
  public    static  System.String                   LOGIN_AUDIO_LANG_KR  // 0x0
  public    static  System.String                   LOGIN_TXT_NETWORK_ERROR  // 0x0
  public    static  System.String                   LOGIN_GAME_UPGRADED  // 0x0
  public    static  System.String                   LOGIN_TXT_SERVER_CLOSED  // 0x0
  public    static  System.String                   LOGIN_TXT_SERVER_CLOSED_DATETIME  // 0x0
  public    static  System.String                   LOGIN_TXT_USR_BAN_DATETIME  // 0x0
  public    static  System.String                   LOGIN_TXT_HOTUPDATE_CLEAR_DOWNLOAD_FOLDER  // 0x0
  public    static  System.String                   LOGIN_GET_SERVER_LIST_FAILED  // 0x0
  public    static  System.String                   LOGIN_TEXT_SERVER_ZONE_FAILED  // 0x0
  public    static  System.String                   LOGIN_TEXT_GET_APP_VERSION_FAILED  // 0x0
  public    static  System.String                   LOGIN_TEXT_ALERT_CARRIER_NETWORK  // 0x0
  public    static  System.String                   LOGIN_TEXT_ERROR_DOWNLOAD_HOTUPDATE_RES_FAILED  // 0x0
  public    static  System.String                   LOGIN_SHADER_WARM_UP_PRELOAD_RES  // 0x0
  public    static  System.String                   LOGIN_GAME_UPDATE_TIPS_DOWNLOADING  // 0x0
  public    static  System.String                   LOGIN_GAME_UPDATE_TIPS_PAUSE  // 0x0
  public    static  System.String                   LOGIN_GAME_UPDATE_ALERT_NEWER  // 0x0
  public    static  System.String                   LOGIN_GAME_UPDATE_ERROR_DISK_FULL  // 0x0
  public    static  System.String                   LOGIN_GAME_UPDATE_ALERT_SUC  // 0x0
  public    static  System.String                   LOGIN_GAME_UPDATE_ERROR_CHECK_FOR_UPDATE_COMMON  // 0x0
  public    static  System.String                   LOGIN_GAME_UPDATE_ERROR_COMMON  // 0x0
  public    static  System.String                   LOGIN_GAME_UPDATE_TITLE  // 0x0
  public    static  System.String                   LOGIN_GOTO_SHOP_FOR_GAME_UPDATE  // 0x0
  public    static  System.String                   LOGIN_SDK_INIT_FAILED  // 0x0
  public    static  System.String                   LOGIN_DOWNLOADING_SPEED_HINT  // 0x0
  public    static  System.String                   LOGIN_SDK_INIT_FAILED_NEED_QUIT_GAME  // 0x0
  public    static  System.String                   LOGIN_NETWORK_CONGESTION_TITLE  // 0x0
  public    static  System.String                   LOGIN_LOW_SCORE_DEVICE_TIP  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.LoginManager
TYPE:  class
TOKEN: 0x200002C
EXTENDS: ExplicitSingleton`1
FIELDS:
  public    static  System.Int64                    MIN_BYTES_SIZE_TO_NOTIFY_IF_NOT_WIFI  // 0x0
  private           Beyond.Resource.ISceneHandle    m_splashSceneHandle  // 0x10
  private           Beyond.Resource.ISceneHandle    m_sceneHandle  // 0x18
  private           Beyond.LoginContext             m_context  // 0x20
  private           Beyond.LatchUtils.InvokeWhenUnlockm_workflowFinishLatch  // 0x28
  private           Beyond.LatchUtils.InvokeWhenUnlockm_workflowStartLatch  // 0x30
  private           System.Collections.Generic.Queue<System.WeakReference<Beyond.Login.LoginSceneComponent>>m_pendingSceneComps  // 0x38
  private           System.Collections.Generic.HashSet<Beyond.Login.LoginSceneComponent>m_sceneComps  // 0x40
  private           System.Boolean                  <quickStart>k__BackingField  // 0x48
  private           System.Object                   m_dialogBlocker  // 0x50
METHODS:
  System.Void RecordSplashSceneHandle(Beyond.Resource.ISceneHandle splashSceneHandle)
  System.Void _ReleaseSplashScene()
  System.Boolean get_quickStart()
  System.Void set_quickStart(System.Boolean value)
  System.Boolean get_firstLogin()
  System.Collections.IEnumerator InitCoroutine(System.Boolean quickStart)
  System.Boolean IsReLoginInProgress()
  System.Void OnReleaseMainGame()
  System.Boolean IsWorkflowInProgress()
  System.Collections.IEnumerator _ClearLoginSceneCoroutine()
  System.Void Clear()
  System.Void _ReleaseLoginScene()
  System.Void InvokeWhenWorkFlowFinished(System.Action callback)
  System.Void SceneComponentOnly_Bind(Beyond.Login.LoginSceneComponent comp)
  System.Void _BindPendingComponents()
  System.Void ToggleLoginBindingGroup(System.Boolean enable)
  System.Void AlertDialog(System.String desc, System.Action callback)
  System.Void VocResSelDialog(System.Action callback)
  System.Collections.IEnumerator VocResSelDialogWithConfirm()
  System.Collections.IEnumerator AlertDialogWithResult(System.String desc, Beyond.Misc.ObjectRef outRef, System.Action<Beyond.Misc.ObjectRef> callback)
  System.Collections.IEnumerator AlertDialogWithConfirm(System.String desc)
  System.Void JudgeDialog(System.String desc, System.Action onPositive, System.Action onNegative)
  System.Void JudgeDialog(Beyond.Login.LoginJudgeDialog.FParams param)
  System.Void _StartShowJudgeDialogCoroutine(Beyond.Login.LoginJudgeDialog.FParams param)
  System.Collections.IEnumerator _ShowDialogCoroutine(System.String resPath, TParam param, System.Action<TDialog,TParam> setParamFunc)
  System.Void MockLoginWithCallback(System.Action<System.String> callback)
  System.Void MockManualSelectServer(System.String uid, System.Action callback)
  System.Void _Init()
  System.Boolean IsLoginSceneLoading()
  System.Void _PrepareBeforeLoginProcess()
  System.Collections.IEnumerator _LoginWorkFlowCoroutine(Beyond.LoginController nullableCtrl)
  System.Void _ClearWorkflowAndContext(System.Boolean isShutDownMode)
  System.Collections.IEnumerator FetchRemoteConfigUtilSuc(Beyond.Cfg.IRemoteConfig config, System.String configEnv, System.String keyErrorWithCode, System.String keyTimeout)
  System.String _ExtractErrorInfo(Beyond.Network.HttpSender.Result result, System.String keyErrorWithCode, System.String keyTimeout)
  System.Void DevOnlyCheckEnableLocalResMode(System.Boolean& enable)
  System.Void DevOnlyUseLocalResVersion(Beyond.Cfg.ResVersionDevCfg config, System.Boolean& useLocalResVersion)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.VietnamLoginAgePanel
TYPE:  class
TOKEN: 0x2000040
EXTENDS: MonoBehaviour
FIELDS:
  private   static  System.String                   PREFAB_PATH  // 0x0
  private   static  Beyond.Resource.FAssetProxyHandles_prefabAssetHandle  // 0x0
  public    static  UnityEngine.GameObject          instance  // 0x18
METHODS:
  System.Void Init()
  System.Void UnInit()
  System.Void _Init()
  System.Void _UnInit()
  System.Void OnApplicationQuit()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.VietnamLoginAgeTipsPanelCtrl
TYPE:  class
TOKEN: 0x2000041
EXTENDS: MonoBehaviour
FIELDS:
  private           Beyond.UI.UIDrag                _UIDrag  // 0x18
  private           Beyond.UI.UIButton              _tipsBtn  // 0x20
  private           Beyond.UI.UIButton              _circleBtn  // 0x28
  private           Beyond.UI.UIState.UIStateController_stateController  // 0x30
METHODS:
  System.Void Awake()
  System.Void _SetStateTips(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void _SetStateCircle(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.RenderPipelineDataLoader
TYPE:  class
TOKEN: 0x2000042
FIELDS:
  public    static  Beyond.Resource.FAssetProxyHandles_globalSettings  // 0x0
  public    static  Beyond.Resource.FAssetProxyHandles_pipelineAsset  // 0x14
METHODS:
  System.Void LoadRpData()
END_CLASS

CLASS: Beyond.TailGameLoop
TYPE:  class
TOKEN: 0x2000043
EXTENDS: MonoBehaviour
FIELDS:
METHODS:
  System.Void Update()
  System.Void LateUpdate()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginCheckForUpdateNode
TYPE:  class
TOKEN: 0x2000066
EXTENDS: Node
FIELDS:
  private           Beyond.Login.LoginGameUpdater   m_sdk  // 0x20
  private           System.Boolean                  m_checkSuccess  // 0x28
  private   static  System.String                   REQUEST_API  // 0x0
  private   static  System.String                   REQUEST_PARAM_FORMAT  // 0x0
  private   static  System.String                   REQUEST_URL_FORMAT  // 0x0
  private   static  System.String                   PRAM_SOURCE  // 0x0
METHODS:
  Beyond.Login.LoginWorkFlow.ENode get_type()
  UnityEngine.CustomYieldInstruction Work()
  System.Collections.IEnumerator _CheckForUpdateCoroutine()
  System.Collections.IEnumerator AlertNoMatchDeviceBeforeLogin()
  System.Collections.IEnumerator _CheckForUpdateCoroutineMobile()
  System.Collections.IEnumerator _CheckForUpdateCoroutinePC()
  System.Collections.IEnumerator _CheckForUpdatePC()
  System.Collections.IEnumerator _GetOnlineAppVersion(Beyond.Misc.ObjectRef outRef)
  System.String _GetRequestPram()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginCreateRoleNode
TYPE:  class
TOKEN: 0x200006E
EXTENDS: Node
FIELDS:
  public    static  System.String                   LUA_SYS_NAME  // 0x0
  private           Beyond.Login.LoginCreateRoleNode.WorkProcessm_activeProcess  // 0x20
METHODS:
  Beyond.Login.LoginWorkFlow.ENode get_type()
  System.Void OnDispose()
  System.Boolean CanCancel()
  UnityEngine.CustomYieldInstruction Work()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnDispose()
  System.Boolean <>iFixBaseProxy_CanCancel()
END_CLASS

CLASS: Beyond.Login.LoginDownloadTask
TYPE:  class
TOKEN: 0x2000070
FIELDS:
  private           System.Boolean                  m_isDownloadFinished  // 0x10
  private           Beyond.SDK.HGDownloader.TaskHandlerm_downloadTask  // 0x18
  private           Beyond.Resource.HotUpdate.FResourceDiffm_resDiff  // 0x20
  private           System.String                   m_patchInfo  // 0x60
  private           System.Collections.IEnumerator  m_mockCoroutine  // 0x68
  private           System.Boolean                  m_isInitial  // 0x70
  private           System.String                   <vitalError>k__BackingField  // 0x78
  private           Beyond.Login.NetUsagePolicy     m_netUsagePolicy  // 0x80
METHODS:
  System.Void .ctor(Beyond.Resource.HotUpdate.FResourceDiff resDiff, System.String patchInfo, System.Boolean isInitial, Beyond.Login.NetUsagePolicy netUsagePolicy)
  System.String get_vitalError()
  System.Void set_vitalError(System.String value)
  Beyond.SDK.HGDownloader.DownloadProgress GetDownloadProgress()
  System.Single GetDecompressProgress()
  Beyond.SDK.HGDownloader.WorkState GetWorkState()
  System.Boolean Tick()
  System.Void Dispose()
  System.Void _StartDownload()
  System.Void _StartDownloadImpl()
  System.Collections.Generic.List<Beyond.SDK.HGFileInfo> _GetFileList(System.String rootUrl)
  System.Void _OnDownloadFinish()
  System.Boolean _OnDownloadError(Beyond.SDK.HGRetCodeType codeType, System.Int32 errorCode)
  System.Void _OnDownloadPaused(Beyond.SDK.HGDownloader.PauseReason reason)
END_CLASS

CLASS: Beyond.Login.LoginGameSettingInitializer
TYPE:  class
TOKEN: 0x2000073
EXTENDS: MonoBehaviour
FIELDS:
  private   static  System.Boolean                  s_isInitialized  // 0x0
  private           UnityEngine.RectTransform       m_rectTransform  // 0x18
  private           Beyond.UI.UICanvasScaleHelper   m_canvasScaleHelper  // 0x20
METHODS:
  System.Void Awake()
  System.Void OnEnable()
  System.Void _TryInitializeComponents()
  System.Void _InitGameSettingStateInLogin()
  System.Void _InitGameSettingNotchPadding()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginGameUpdateNode
TYPE:  class
TOKEN: 0x2000074
EXTENDS: Node
FIELDS:
  private           Beyond.Login.LoginGameUpdater   m_sdk  // 0x20
  private           Beyond.Login.NetUsagePolicy     m_netUsagePolicy  // 0x28
METHODS:
  Beyond.Login.LoginWorkFlow.ENode get_type()
  UnityEngine.CustomYieldInstruction Work()
  System.Collections.IEnumerator _GameUpdateCoroutine()
  System.Collections.IEnumerator _GameUpdateCoroutineMobileImpl()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginGameUpdater
TYPE:  class
TOKEN: 0x2000077
FIELDS:
  private   static  System.Single                   COOLDOWN_INSTALL  // 0x0
  private   static  System.Int32                    ERROR_CODE_NETWORK  // 0x0
  private   static  System.Int32                    ERROR_INIT_FAILED  // 0x0
  private   static  System.Int32                    ERROR_DESERIALIZE_FAILED  // 0x0
  public    static  System.Int32                    ERROR_ACTION  // 0x0
  private   static  System.Int32                    WAIT_TIME_SECONDS_MIN  // 0x0
  private   static  System.Int32                    WAIT_TIME_SECONDS_MAX  // 0x0
  private           Beyond.Login.LoginGameUpdater.Optionsm_options  // 0x10
  private           Beyond.SDK.IGameUpdateInterface m_sdkImpl  // 0x28
  private           System.Boolean                  m_hasUpdateAlerted  // 0x30
  private           Beyond.Login.LoginGameUpdater.Contextm_context  // 0x38
  private           Beyond.Login.LoginProgress      m_progress  // 0x40
  private           Beyond.Login.LoginHotUpdateProp m_hotUpdateProp  // 0x48
METHODS:
  System.Void Clear()
  System.Void .ctor(Beyond.Login.LoginGameUpdater.Options options)
  System.Collections.IEnumerator CheckLastGameInfo(Beyond.Login.LoginGameUpdater.Result result)
  System.Collections.IEnumerator DoUpdate(Beyond.Login.LoginGameUpdater.Result result)
  System.Collections.IEnumerator _GetLastGameInfo(Beyond.Login.LoginGameUpdater.Context context)
  System.Collections.IEnumerator _UpdateGame(Beyond.Login.LoginGameUpdater.Context context)
  System.Collections.IEnumerator _DoTaskUpdating(Beyond.Login.LoginGameUpdater.Context context)
  System.Void _OnDownloadStart()
  System.Void _OnDownloadProgress(System.Int64 curSize, System.Int64 totalSize, System.Int64 speed)
  System.Collections.IEnumerator _YieldErrorAlert(System.String desc)
  System.Collections.IEnumerator _YieldCheckNetUsagePolicy(System.Int64 downloadSize)
  System.Collections.IEnumerator _WaitForTaskCancel(System.Int64 taskId)
  System.Void _CreateDirectoryIfNotExists(System.String folderPath)
  System.Void ClearWaitProgress()
  System.Void ShowWaitProgress()
  System.Int32 GetNoAlertCode()
  System.Single GetWaitTime()
END_CLASS

CLASS: Beyond.Login.LoginGSNode
TYPE:  class
TOKEN: 0x200008D
EXTENDS: Node
FIELDS:
  private   static  System.Int32                    FLOW_NONE  // 0x0
  private   static  System.Int32                    FLOW_WORKING  // 0x0
  private   static  System.Int32                    FLOW_FINISH  // 0x0
  private   static  System.Int32                    FLOW_ABORTING  // 0x0
  private           Beyond.Login.LoginGSNode.EnterGameServiceFlowm_flow  // 0x20
METHODS:
  Beyond.Login.LoginWorkFlow.ENode get_type()
  UnityEngine.CustomYieldInstruction Work()
  System.Boolean OnEvent(Beyond.ELoginEvent evt, System.Object param)
  System.Collections.IEnumerator _ConfirmServer()
  System.Void _FallbackToInitWithMask(System.Boolean bLogoutAccount)
  System.Void _OnEventLogout()
  System.Void _OnEventResourceRepair()
  System.Boolean _LogoutToInitNode()
  System.Boolean _FallbackToInitNodeImpl()
  System.Boolean _FallbackToResRepairImpl()
  System.Void .ctor()
  System.Void <_OnEventLogout>b__12_0()
  System.Void <_OnEventResourceRepair>b__13_0()
  System.Boolean <>iFixBaseProxy_OnEvent(Beyond.ELoginEvent P0, System.Object P1)
END_CLASS

CLASS: Beyond.Login.LoginHotUpdateProp
TYPE:  class
TOKEN: 0x2000097
EXTENDS: LoginProperty`1
FIELDS:
METHODS:
  System.Void .ctor(Beyond.Login.LoginWorkFlow workflow)
END_CLASS

CLASS: Beyond.Login.LoginHotUpdateModel
TYPE:  class
TOKEN: 0x2000098
FIELDS:
  public            System.String                   title  // 0x10
  public            System.String                   desc  // 0x18
  public            Beyond.Login.LoginHotUpdateModel.IProgressprogress  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginHotUpdater
TYPE:  class
TOKEN: 0x200009B
EXTENDS: CustomYieldInstruction
FIELDS:
  private   static  System.Int32                    MODE_SKIP  // 0x0
  private   static  System.Int32                    MODE_DOWNLOAD  // 0x0
  private   static  System.Int32                    MODE_LOCAL  // 0x0
  private   static  System.Boolean                  s_hasInitialAssetChanged  // 0x0
  private           Beyond.LoginContext             m_loginCxt  // 0x10
  private           System.Collections.IEnumerator  m_mainRoutine  // 0x18
  private           Beyond.Login.LoginProgress      m_progress  // 0x20
  private           Beyond.Login.LoginHotUpdateProp m_hotupdateProp  // 0x28
  private           Beyond.Login.LoginDownloadTask  m_downloadTask  // 0x30
  private           Beyond.Login.LoginLocalResTask  m_localResTask  // 0x38
  private           System.Boolean                  m_resRepairMode  // 0x40
  public    static  System.String                   URL_GET_SPLIT  // 0x0
METHODS:
  System.Void MarkInitialAssetChanged()
  System.Boolean CheckInitialAssetChanged()
  System.Void MarkNeedClearFolder(System.Boolean isInitial)
  System.Boolean NeedClearFolder()
  System.Void MarkClearSuccessed()
  System.Void .ctor(Beyond.LoginContext context, System.Boolean resRepairMode)
  System.Boolean get_keepWaiting()
  System.Void Dispose()
  Beyond.Login.LoginHotUpdater StartHotUpdate(Beyond.LoginContext context, System.Boolean resRepairMode)
  System.Collections.IEnumerator _Work()
  System.Collections.IEnumerator _CreateMainCoroutine(Beyond.Login.LoginHotUpdater.WorkContext workContext)
  System.Collections.IEnumerator _MainCoroutineModeSkip(Beyond.Login.LoginHotUpdater.WorkContext context)
  System.Collections.IEnumerator _MainCoroutineModeLocal(Beyond.Login.LoginHotUpdater.WorkContext context)
  System.Collections.IEnumerator _UpdateResVersion(Beyond.Login.LoginHotUpdater.WorkContext workContext)
  System.String _GetOnlineResVersion(System.Boolean isInitial)
  System.String ResourceRootUrl(System.String version, System.Boolean isInitial)
  System.Collections.IEnumerator _UpdateResVersionDev(Beyond.Login.LoginHotUpdater.WorkContext workContext)
  System.Collections.IEnumerator _UpdateResVersionProd(Beyond.Login.LoginHotUpdater.WorkContext workContext)
  System.String _ResourcePatchUrl(System.String version, System.Boolean isInitial)
  System.String _ResourceFileUrl(System.String version, System.Boolean isInitial)
  System.String _ResourcePatchRootUrl(System.String version, System.Boolean isInitial)
  System.String _ResourceIndexUrl(System.String version, System.Boolean isInitial)
  System.Collections.IEnumerator _MainCoroutineModeDownload(Beyond.Login.LoginHotUpdater.WorkContext workContext)
  System.Collections.IEnumerator _ReloadResourceIndexes(Beyond.Login.LoginHotUpdater.WorkContext workContext)
  System.Collections.IEnumerator _LoadOrDownloadResIndex(System.String onlineVer, System.Boolean isInitial, Beyond.Misc.ObjectRef resIndexRef)
  System.Collections.IEnumerator _GenResIndex(System.String onlineVer, System.Boolean isInitial, Beyond.Login.LoginHotUpdater.WorkContext workContext)
  System.Collections.IEnumerator _GenRiff(System.String onlineVer, System.Boolean isInitial, Beyond.Login.LoginHotUpdater.WorkContext workContext)
  System.Collections.IEnumerator _GenLocalRef(System.String onlineVer, System.Boolean isInitial, Beyond.Login.LoginHotUpdater.WorkContext workContext)
  System.Collections.IEnumerator _CheckAndDownloadResource(System.String onlineVer, System.Boolean isInitial, Beyond.Login.LoginHotUpdater.WorkContext workContext)
  System.Void _EventLogDownloadProgress(System.Boolean& first, System.Double current, System.Double total, System.Int32 target, System.Boolean isInitial)
  System.Collections.IEnumerator _DownloadPatchInfo(System.String onlineVer, System.Boolean isInitial, Beyond.Misc.ObjectRef patchInfoRef)
  System.Collections.IEnumerator _ClearDownloadFolder(Beyond.Login.LoginHotUpdater.WorkContext workContext)
  System.Collections.IEnumerator _CheckLocalResConsistency(System.String onlineVer, System.Boolean isInitial, Beyond.Login.LoginHotUpdater.WorkContext context)
  System.Collections.IEnumerator _VitalError(System.String error)
  System.Collections.IEnumerator _LoadStreamingIndex(System.Boolean isInitial, Beyond.Login.LoginHotUpdater.WorkContext workContext, Beyond.Misc.ObjectRef resultRef)
  System.Void WriteLocalResPrefToFile(Beyond.Resource.HotUpdate.LocalResPref localResPref, Beyond.Login.LoginHotUpdater.WorkContext workContext)
  System.Int32 _CurrentWorkMode(Beyond.LoginContext context)
END_CLASS

CLASS: Beyond.Login.LoginProgress
TYPE:  class
TOKEN: 0x20000B4
FIELDS:
  public    static  System.Int32                    MODE_PROG  // 0x0
  public    static  System.Int32                    MODE_SIZE  // 0x0
  public    static  System.Int32                    MODE_IDEL  // 0x0
  public            System.Int32                    mode  // 0x10
  public            System.Double                   current  // 0x18
  public            System.Double                   total  // 0x20
  public            System.Double                   speed  // 0x28
  private           Beyond.Login.LoginProgress.FDownloadSizem_downloadSize  // 0x30
METHODS:
  System.Double GetCurrent()
  System.Double GetTotal()
  System.String GetInfo()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginInitNode
TYPE:  class
TOKEN: 0x20000B7
EXTENDS: Node
FIELDS:
  private           System.Boolean                  m_isSDKInited  // 0x20
METHODS:
  Beyond.Login.LoginWorkFlow.ENode get_type()
  UnityEngine.CustomYieldInstruction Work()
  System.Collections.IEnumerator _InitCoroutine()
  System.Collections.IEnumerator _InitRemoteConfigs()
  System.Collections.IEnumerator _YieldAlertError(System.String errorInfo)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginLocalResTask
TYPE:  class
TOKEN: 0x20000BB
FIELDS:
  private           Beyond.LoginContext             m_loginCxt  // 0x10
  private           Beyond.Login.LoginHotUpdater.WorkContextm_workCxt  // 0x18
METHODS:
  System.Void .ctor(Beyond.LoginContext loginContext, Beyond.Login.LoginHotUpdater.WorkContext workContext)
  System.Collections.IEnumerator Work()
  System.Void Dispose()
END_CLASS

CLASS: Beyond.Login.PreloadNode
TYPE:  class
TOKEN: 0x20000BE
EXTENDS: Node
FIELDS:
  private           Beyond.Login.LoginHotUpdateModel.SimpleProgressm_progress  // 0x20
  private           System.Boolean                  m_getServerListSuc  // 0x28
  private           System.String                   m_errorMsg  // 0x30
METHODS:
  Beyond.Login.LoginWorkFlow.ENode get_type()
  UnityEngine.CustomYieldInstruction Work()
  System.Void _ShowPreloadResourcePanel()
  System.Collections.IEnumerator _LoginPreLoad()
  System.Collections.IEnumerator _WarmUp()
  System.Collections.IEnumerator _GetServerList()
  System.Void _EnterPreLoad()
  System.Collections.IEnumerator _GetServerListInfoMock()
  System.Collections.IEnumerator _GetServerListInfo()
  System.Void _OnGetServerListSuc()
  System.Void _OnGetServerListFail(System.String errorInfo)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginSDKInitNode
TYPE:  class
TOKEN: 0x20000C6
EXTENDS: Node
FIELDS:
  private           System.Boolean                  m_isSDKInited  // 0x20
METHODS:
  Beyond.Login.LoginWorkFlow.ENode get_type()
  UnityEngine.CustomYieldInstruction Work()
  System.Collections.IEnumerator _SDKInitCoroutine()
  System.Collections.IEnumerator _WaitForSDKInited()
  System.Collections.IEnumerator _InitSubSDKs(System.String env)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.U8LoginNode
TYPE:  class
TOKEN: 0x20000CA
EXTENDS: Node
FIELDS:
  private           System.Boolean                  m_loginSuc  // 0x20
  private           System.Boolean                  m_isSDKLoginFinished  // 0x21
  private           System.Int32                    m_rqstSkipLoginCache  // 0x24
METHODS:
  Beyond.Login.LoginWorkFlow.ENode get_type()
  UnityEngine.CustomYieldInstruction Work()
  System.Collections.IEnumerator _LoginCoroutine()
  System.Collections.IEnumerator _FinishLogin()
  System.Boolean OnEvent(Beyond.ELoginEvent evt, System.Object param)
  System.Void _StartSDKLogin()
  System.Void _SetCursorOnLoginStart()
  System.Void _SetCursorOnLoginFinish()
  System.Void _SkipSDKLogin()
  System.Void _ClearLoginCaches()
  System.Void _OnLoginSuc()
  System.Void _OnLoginFail(System.Object rawInfo)
  System.Void _OnSDKViewDisabled()
  System.Void _OnLoginCanceled()
  System.Void _EnableBlurMask(System.Boolean enable)
  System.Void .ctor()
  System.Void <_StartSDKLogin>b__9_0(System.String sessionToken)
  System.Void <_StartSDKLogin>b__9_1(System.Object pram)
  System.Boolean <>iFixBaseProxy_OnEvent(Beyond.ELoginEvent P0, System.Object P1)
END_CLASS

CLASS: Beyond.Login.LoginProperty`1
TYPE:  class
TOKEN: 0x20000CD
FIELDS:
  private           T                               m_value  // 0x0
  private           System.Collections.Generic.HashSet<Beyond.Login.ILoginBinder<T>>m_binders  // 0x0
  private           Beyond.Login.LoginWorkFlow      m_workflow  // 0x0
  private           System.Boolean                  <isDataChanged>k__BackingField  // 0x0
METHODS:
  System.Void .ctor(Beyond.Login.LoginWorkFlow workflow)
  System.Boolean get_isDataChanged()
  System.Void set_isDataChanged(System.Boolean value)
  T get_value()
  System.Void NotifyDataChanged()
  System.Void Bind(Beyond.Login.ILoginBinder<T> binder)
  System.Void Worker_UpdateOnce()
END_CLASS

CLASS: Beyond.Login.ILoginBinder`1
TYPE:  interface
TOKEN: 0x20000CE
FIELDS:
METHODS:
  System.Void OnValueChanged(T value)
END_CLASS

CLASS: Beyond.Login.ILoginContextReceiver
TYPE:  interface
TOKEN: 0x20000CF
FIELDS:
METHODS:
  System.Void OnLoginContext(Beyond.LoginContext context)
END_CLASS

CLASS: Beyond.Login.LoginViewModel
TYPE:  class
TOKEN: 0x20000D0
FIELDS:
  public            Beyond.Login.LoginWorkFlow.ENodeworkCachedCurNode  // 0x10
  public            Beyond.Login.LoginWorkFlow.ENodeworkCurNode  // 0x14
  public            System.Boolean                  isFirstLogin  // 0x18
  private           System.Int32                    <rqstSkipU8Login>k__BackingField  // 0x1C
  public            System.Boolean                  isU8LoginCancelled  // 0x20
  private           System.Int32                    <rqstResRepairCode>k__BackingField  // 0x24
  public            Beyond.Login.LoginViewModel.FAgeTipsPolicyageTipsPolicy  // 0x28
METHODS:
  System.Void .ctor()
  System.Int32 get_rqstSkipU8Login()
  System.Void set_rqstSkipU8Login(System.Int32 value)
  System.Int32 get_rqstResRepairCode()
  System.Void set_rqstResRepairCode(System.Int32 value)
  System.Boolean IsAgeTipsVisible()
  System.Boolean IsGovTipsVisible()
  System.Boolean IsMenuVisible()
  System.Void RequestResourceRepair()
  System.Void RequestSkipU8Login()
  Beyond.Login.LoginViewModel.FAgeTipsPolicy _LoadAgeTipsPolicy()
END_CLASS

CLASS: Beyond.Login.LoginViewProperty
TYPE:  class
TOKEN: 0x20000D2
EXTENDS: LoginProperty`1
FIELDS:
  private           Beyond.Login.LoginHotUpdateProp <hotUpdateProp>k__BackingField  // 0x30
  private           Beyond.Login.LoginAgeTipsProp   <ageTipsProp>k__BackingField  // 0x38
  private           Beyond.Login.LoginServerSelectProp<serverSelectProp>k__BackingField  // 0x40
METHODS:
  Beyond.Login.LoginHotUpdateProp get_hotUpdateProp()
  System.Void set_hotUpdateProp(Beyond.Login.LoginHotUpdateProp value)
  Beyond.Login.LoginAgeTipsProp get_ageTipsProp()
  System.Void set_ageTipsProp(Beyond.Login.LoginAgeTipsProp value)
  Beyond.Login.LoginServerSelectProp get_serverSelectProp()
  System.Void set_serverSelectProp(Beyond.Login.LoginServerSelectProp value)
  System.Void .ctor(Beyond.Login.LoginWorkFlow workflow)
END_CLASS

CLASS: Beyond.Login.LoginAgeTipsModel
TYPE:  class
TOKEN: 0x20000D3
FIELDS:
  public            System.String                   contentCache  // 0x10
  public            System.Boolean                  isShow  // 0x18
  public            System.Boolean                  isFetchingContent  // 0x19
METHODS:
  System.Boolean IsContentEmpty()
  System.Boolean CanDisplay()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginAgeTipsProp
TYPE:  class
TOKEN: 0x20000D4
EXTENDS: LoginProperty`1
FIELDS:
METHODS:
  System.Void .ctor(Beyond.Login.LoginWorkFlow workflow)
  System.Void ClearContentCache()
  System.Void UpdateContent(System.String content)
END_CLASS

CLASS: Beyond.Login.LoginWorkFlow
TYPE:  class
TOKEN: 0x20000D5
FIELDS:
  public    static  System.String                   CURSOR_KEY_LOGIN  // 0x0
  private   static readonly Beyond.Login.LoginWorkFlow.ENode[]NODE_ORDER  // 0x0
  private   static  Beyond.Login.LoginWorkFlow.ENodeNEED_GAME_LOGIN_STATE_BEFORE_NODE  // 0x0
  private   readonly Beyond.Login.LoginWorkFlow.Node[]m_nodes  // 0x10
  private   readonly Beyond.LoginContext             m_context  // 0x18
  private           Beyond.Login.LoginWorkFlow.FWorkm_work  // 0x20
  private           Beyond.Login.LoginWorkFlow.Workerm_worker  // 0x30
  private           System.Collections.Generic.HashSet<Beyond.Login.LoginWorkFlow.IEventReceiver>m_evtRecvrs  // 0x38
  private           System.Collections.Generic.List<Beyond.Login.LoginWorkFlow.IEventReceiver>m_recvrBuffer  // 0x40
  private           System.Boolean                  <isDisposed>k__BackingField  // 0x48
METHODS:
  Beyond.Login.LoginWorkFlow.Node[] _RegisterNodes()
  System.Boolean get_isDisposed()
  System.Void set_isDisposed(System.Boolean value)
  System.Void .ctor(Beyond.LoginContext context)
  System.Collections.IEnumerator DoWorkFlow()
  System.Void Dispose()
  System.Boolean PeekFallbackStatus(Beyond.Login.LoginWorkFlow.ENode& fallbackNode)
  System.Boolean Fallback(Beyond.Login.LoginWorkFlow.ENode target, System.Boolean validCheck)
  System.Boolean CancelAndFallback(Beyond.Login.LoginWorkFlow.ENode target, System.Boolean validCheck)
  System.Void SendEvent(Beyond.ELoginEvent evt, System.Object param)
  System.Void AddEventReceiver(Beyond.Login.LoginWorkFlow.IEventReceiver receiver)
  System.Boolean UpdateOnce(Beyond.Login.LoginWorkFlow.IWorkerUpdateOnce inst)
  System.Boolean IsBeforeWork(Beyond.Login.LoginWorkFlow.ENode curNode, Beyond.Login.LoginWorkFlow.ENode check)
  System.Boolean IsOnOrAfterWork(Beyond.Login.LoginWorkFlow.ENode curNode, Beyond.Login.LoginWorkFlow.ENode check)
  System.Boolean IsAfterWork(Beyond.Login.LoginWorkFlow.ENode target, Beyond.Login.LoginWorkFlow.ENode check)
  System.Boolean _HandleGlobalEvent(Beyond.ELoginEvent evt, System.Object param)
  System.Void _EventOnOpenAgeTips()
  System.Void _EventOnCloseAgeTips()
  System.Void _EventOnOpenServerSelect(System.Boolean isOpen)
  System.Void _EventOnSelectServer(Beyond.Gameplay.ServerZoneManager.ServerZoneData serverZoneData)
  System.Void _EventOnConfirmServer()
  System.Void _EnableCursor(System.Boolean enabled)
  System.Void _UpdateCursor(Beyond.EventData<Beyond.DeviceInfo.InputType>& input)
  System.Void _EnbaleToggleGroup()
  System.Collections.IEnumerator _FetchAgeTipsCoroutine(Beyond.Login.LoginAgeTipsProp prop)
  System.Boolean _CheckIfGameStateNotMatch(Beyond.Login.LoginWorkFlow.ENode curNode)
  System.Collections.IEnumerator _AdjustCurrentGameState(Beyond.Login.LoginWorkFlow.ENode curNode)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Login.HotUpdateNode
TYPE:  class
TOKEN: 0x20000E0
EXTENDS: Node
FIELDS:
  private           Beyond.Login.LoginHotUpdater    m_updater  // 0x20
  private           System.Int32                    m_cachedResRepairCode  // 0x28
METHODS:
  Beyond.Login.LoginWorkFlow.ENode get_type()
  UnityEngine.CustomYieldInstruction Work()
  System.Void OnDispose()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnDispose()
END_CLASS

CLASS: Beyond.Login.WaitForSecondsNode
TYPE:  class
TOKEN: 0x20000E1
EXTENDS: Node
FIELDS:
  private           System.Nullable<System.Int32>   m_timerId  // 0x20
METHODS:
  UnityEngine.CustomYieldInstruction Work()
  System.Boolean _IsTimeout()
  System.Void _NotifyTimeout()
  System.Void _DisposeTimer()
  System.Single WaitForSeconds(System.Boolean& unscaled)
  System.Void OnDispose()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnDispose()
END_CLASS

CLASS: Beyond.Login.PreloadPostDelayNode
TYPE:  class
TOKEN: 0x20000E2
EXTENDS: WaitForSecondsNode
FIELDS:
METHODS:
  Beyond.Login.LoginWorkFlow.ENode get_type()
  System.Single WaitForSeconds(System.Boolean& unscaled)
  UnityEngine.CustomYieldInstruction Work()
  System.Void _DisableLoadingPanel()
  System.Void .ctor()
  UnityEngine.CustomYieldInstruction <>iFixBaseProxy_Work()
END_CLASS

CLASS: Beyond.Login.Trans2GsLoginNode
TYPE:  class
TOKEN: 0x20000E3
EXTENDS: WaitForSecondsNode
FIELDS:
METHODS:
  Beyond.Login.LoginWorkFlow.ENode get_type()
  System.Single WaitForSeconds(System.Boolean& unscaled)
  UnityEngine.CustomYieldInstruction Work()
  System.Void .ctor()
  UnityEngine.CustomYieldInstruction <>iFixBaseProxy_Work()
END_CLASS

CLASS: Beyond.Login.FinishNode
TYPE:  class
TOKEN: 0x20000E4
EXTENDS: Node
FIELDS:
METHODS:
  Beyond.Login.LoginWorkFlow.ENode get_type()
  UnityEngine.CustomYieldInstruction Work()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.CarrierDownloadCache
TYPE:  struct
TOKEN: 0x20000E5
FIELDS:
  public    static readonly Beyond.Login.CarrierDownloadCacheEMPTY  // 0x0
  public            System.Int64                    size  // 0x10
  public            System.Boolean                  isAllowed  // 0x18
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Login.NetUsagePolicy
TYPE:  class
TOKEN: 0x20000E6
FIELDS:
  private           Beyond.Login.CarrierDownloadCachem_mobileDataCache  // 0x10
  private           UnityEngine.NetworkReachability m_lastNetworkState  // 0x20
  private           Beyond.Login.NetUsagePolicy.Optionsm_options  // 0x28
METHODS:
  System.Void .ctor(Beyond.Login.NetUsagePolicy.Options options)
  System.Void CheckIfAllowDownload(System.Int64 downloadSize, System.Action onAllowed, System.Action onRejected, System.Action onReachable)
  System.Boolean AllowMobileDataInLastCheck()
  System.String _GetPrettySizeStringUpToMB(System.Double number)
END_CLASS

CLASS: Beyond.Login.LoginSceneAnimCtrl
TYPE:  class
TOKEN: 0x20000E9
EXTENDS: LoginSceneComponent
FIELDS:
  private   static  System.Single                   COUNT_DOWN_EMPTY  // 0x0
  private           UnityEngine.Animator            _target  // 0x78
  private           UnityEngine.AnimationClip       _clipA1  // 0x80
  private           UnityEngine.AnimationClip       _clipA1s  // 0x88
  private           System.Single                   _transA1  // 0x90
  private           System.Single                   _transA1s  // 0x94
  private           UnityEngine.Vector2             _randomRangeA1s  // 0x98
  private           UnityEngine.AnimationClip       _clipA1A2  // 0xA0
  private           System.Single                   _predelayA1A2  // 0xA8
  private           System.Single                   _transA1A2  // 0xAC
  private           UnityEngine.AnimationClip       _clipA2  // 0xB0
  private           System.Single                   _transA2  // 0xB8
  private           Beyond.UI.UIAnimationMixPlayer  m_player  // 0xC0
  private           Beyond.Login.LoginSceneAnimCtrl.EStatem_state  // 0xC8
  private           System.Single                   m_countDownA1s  // 0xCC
  private           System.Single                   m_countDownA1A2  // 0xD0
METHODS:
  Beyond.TickType get_tickOption()
  System.Void OnBindToManager()
  Beyond.UI.UIAnimationMixPlayer _EnsurePlayer()
  System.Void _ChangeToState(Beyond.Login.LoginSceneAnimCtrl.EState target)
  System.Void _ResetToA1()
  System.Void _TransitionToA2()
  System.Void _PlayA1sAndTriggerNext()
  System.Single _RandomIntervalA1s()
  System.Void _PlayA1A2Impl()
  System.Void OnValueChanged(Beyond.Login.LoginViewModel value)
  System.Void Start()
  System.Void Tick(System.Single deltaTime)
  System.Void OnRelease()
  System.Void GetAnimationClips(System.Collections.Generic.List<UnityEngine.AnimationClip> results)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnBindToManager()
  System.Void <>iFixBaseProxy_Start()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
  System.Void <>iFixBaseProxy_OnRelease()
END_CLASS

CLASS: Beyond.Login.LoginSceneComponent
TYPE:  class
TOKEN: 0x20000EB
EXTENDS: TickableMono
FIELDS:
  private           Beyond.LoginContext             <context>k__BackingField  // 0x68
  private           Beyond.LoginController          <controller>k__BackingField  // 0x70
METHODS:
  Beyond.TickType get_tickOption()
  Beyond.LoginContext get_context()
  System.Void set_context(Beyond.LoginContext value)
  Beyond.LoginController get_controller()
  System.Void set_controller(Beyond.LoginController value)
  System.Void Start()
  System.Void Bind(Beyond.LoginContext context, Beyond.LoginController controller)
  System.Void OnBindToManager()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginSceneRoot
TYPE:  class
TOKEN: 0x20000EC
EXTENDS: LoginSceneComponent
FIELDS:
METHODS:
  Beyond.TickType get_tickOption()
  System.Void OnBindToManager()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnBindToManager()
END_CLASS

CLASS: Beyond.Login.LoginAgeTipsDetailPanel
TYPE:  class
TOKEN: 0x20000ED
EXTENDS: MonoBehaviour
FIELDS:
  private           Beyond.UI.UIAnimationWrapper    _anim  // 0x18
  private           UnityEngine.RectTransform       _content  // 0x20
  private           Beyond.UI.UIText                _txtTitle  // 0x28
  private           Beyond.UI.UIText                _lineTmpl  // 0x30
  private           Beyond.UI.UIButton              _btnClose  // 0x38
  private           Beyond.UI.UIScrollRect          _scroll  // 0x40
  private           Beyond.Input.InputBindingGroupMonoTarget_ageTipsBindingGroup  // 0x48
  private           Beyond.LoginContext             m_context  // 0x50
  private           Beyond.UI.UISwitchTween         m_switchTween  // 0x58
  private           DG.Tweening.Tween               m_displayDelayTween  // 0x60
  private   static  System.Int32                    MAX_TEXT_STRLEN  // 0x0
  private   static  System.Int32                    MIN_TEXT_STRLEN  // 0x0
METHODS:
  System.Void Init(Beyond.LoginContext context)
  System.Void OnValueChanged(Beyond.Login.LoginAgeTipsModel value)
  System.Void _RenderContent(System.String contentStr)
  System.Void _ShowContent()
  System.Void _EventOnCloseClicked(UnityEngine.EventSystems.PointerEventData _)
  System.Collections.Generic.List<System.String> _SplitLicenseToSegments(System.String content)
  System.Void _SplitLongString(System.String longStr, System.Collections.Generic.List<System.String> outputList)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginAgeTipsPanel
TYPE:  class
TOKEN: 0x20000EE
EXTENDS: ChildPanel
FIELDS:
  private           Beyond.Login.LoginAgeTipsDetailPanel_detailPanel  // 0x28
  private           Beyond.UI.UIButton              _ageTipsCN  // 0x30
  private           UnityEngine.GameObject          _ageTipsKR  // 0x38
  private           UnityEngine.CanvasGroup         _canvasVersionTop  // 0x40
METHODS:
  System.Void OnInit()
  System.Void OnValueChanged(Beyond.Login.LoginViewModel value)
  System.Void _UpdateAgeTipsPolicy(Beyond.Login.LoginViewModel.FAgeTipsPolicy policy)
  System.Void _EventOnOpenAgeTipsClicked(UnityEngine.EventSystems.PointerEventData _)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnInit()
END_CLASS

CLASS: Beyond.Login.LoginAlertDialog
TYPE:  class
TOKEN: 0x20000EF
EXTENDS: Dialog
FIELDS:
  private           Beyond.UI.UIButton              _btnConfirm  // 0x38
  private           Beyond.UI.UIText                _text  // 0x40
  private           Beyond.Login.LoginAlertDialog.FParamsm_params  // 0x48
METHODS:
  System.Void OnInit()
  System.Void SetParams(Beyond.Login.LoginAlertDialog.FParams param)
  System.Void _OnConfirmClicked(UnityEngine.EventSystems.PointerEventData evt)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnInit()
END_CLASS

CLASS: Beyond.Login.LoginDecorateUI
TYPE:  class
TOKEN: 0x20000F1
EXTENDS: TickableUIMono
FIELDS:
  private           UnityEngine.CanvasGroup         _imgLogo  // 0x68
  private           System.Single                   _durationLogo  // 0x70
  private           UnityEngine.AnimationClip       _clipLoopGlow  // 0x78
  private           UnityEngine.AnimationClip       _clipInGlow  // 0x80
  private           UnityEngine.Animator            _targetGlow  // 0x88
  private           System.Single                   _delay  // 0x90
  private           Beyond.LoginContext             m_context  // 0x98
  private           System.Boolean                  m_isOnTransNode  // 0xA0
  private           Beyond.Interpolator.FLerpByTime m_hideLogoLerp  // 0xA8
  private           Beyond.UI.UIAnimationLayerMixPlayerm_glowPlayer  // 0xC8
  private           System.Boolean                  m_isGlowEnabled  // 0xD0
  private           System.Single                   m_countDownDelay  // 0xD4
  private           System.Single                   m_countDownDisableGlow  // 0xD8
METHODS:
  Beyond.TickType get_tickOption()
  System.Void OnLoginContext(Beyond.LoginContext context)
  System.Void OnValueChanged(Beyond.Login.LoginViewModel value)
  System.Void _TriggerTrans2GSLoginImpl()
  System.Void _ToggleGlow(System.Boolean enable)
  Beyond.UI.UIAnimationLayerMixPlayer _EnsureGlowPlayer()
  System.Void Tick(System.Single deltaTime)
  System.Void OnRelease()
  System.Void _TimeManagerTick(System.Single timeDelta)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
  System.Void <>iFixBaseProxy_OnRelease()
END_CLASS

CLASS: Beyond.Login.LoginEnterGamePanel
TYPE:  class
TOKEN: 0x20000F2
EXTENDS: ChildPanel
FIELDS:
  private           UnityEngine.CanvasGroup         _canvasGroup  // 0x28
  private           Beyond.UI.UIButton              _btnEnterGame  // 0x30
  private           Beyond.UI.UIText                _textEnterGame  // 0x38
  private           System.Single                   _delayEnterGame  // 0x40
  private           System.Boolean                  m_isPanelActive  // 0x44
  private           System.Double                   m_panelActiveTime  // 0x48
  private           System.Boolean                  m_isInited  // 0x50
METHODS:
  System.Void _InitIfNot()
  System.Void OnValueChanged(Beyond.Login.LoginViewModel value)
  System.Void _OnEnterGameClicked(UnityEngine.EventSystems.PointerEventData evt)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginGovTipsPanel
TYPE:  class
TOKEN: 0x20000F3
EXTENDS: ChildPanel
FIELDS:
  private           Beyond.UI.UIButton              _btnOpen  // 0x28
METHODS:
  System.Void OnInit()
  System.Void OnValueChanged(Beyond.Login.LoginViewModel value)
  System.Void _EventOnOpenAgeTipsClicked(UnityEngine.EventSystems.PointerEventData _)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnInit()
END_CLASS

CLASS: Beyond.Login.LoginJudgeDialog
TYPE:  class
TOKEN: 0x20000F4
EXTENDS: Dialog
FIELDS:
  private           Beyond.UI.UIButton              _btnPositive  // 0x38
  private           Beyond.UI.UIButton              _btnNegative  // 0x40
  private           Beyond.UI.UIText                _text  // 0x48
  private           Beyond.UI.UIText                _text2  // 0x50
  private           Beyond.UI.UIText                _textPositive  // 0x58
  private           Beyond.UI.UIText                _textNegative  // 0x60
  private           Beyond.Login.LoginJudgeDialog.FParamsm_params  // 0x68
METHODS:
  System.Void OnInit()
  System.Void SetParams(Beyond.Login.LoginJudgeDialog.FParams param)
  System.Void _OnPositiveClicked(UnityEngine.EventSystems.PointerEventData evt)
  System.Void _OnNegativeClicked(UnityEngine.EventSystems.PointerEventData evt)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnInit()
END_CLASS

CLASS: Beyond.Login.LoginMenuPanel
TYPE:  class
TOKEN: 0x20000F7
EXTENDS: ChildPanel
FIELDS:
  public    static  System.String                   CONTROLLER_STATE_NORMAL  // 0x0
  public    static  System.String                   CONTROLLER_STATE_SELECT  // 0x0
  private           Beyond.UI.UIButton              _btnAnnounce  // 0x28
  private           Beyond.UI.UIButton              _btnSetting  // 0x30
  private           Beyond.UI.UIButton              _btnResCheck  // 0x38
  private           Beyond.UI.UIButton              _btnLogout  // 0x40
  private           Beyond.UI.UIButton              _btnQuitGame  // 0x48
  private           Beyond.UI.UIButton              _btnLogin  // 0x50
  private           Beyond.UI.UIButton              _btnQR  // 0x58
  private           Beyond.UI.UIState.UIStateController_ctrlAnnounce  // 0x60
  private           Beyond.UI.UIState.UIStateController_ctrlSetting  // 0x68
  private           Beyond.UI.UIState.UIStateController_ctrlResCheck  // 0x70
  private           Beyond.UI.UIState.UIStateController_ctrlLogout  // 0x78
  private           Beyond.UI.UIState.UIStateController_ctrlQR  // 0x80
  private           Beyond.UI.UISimpleStateController_ctrlRight  // 0x88
  private           Beyond.UI.UISelectableNaviGroup _naviGroupRight  // 0x90
  private           Beyond.Input.InputBindingGroupMonoTarget_bindingGroupForKeyboard  // 0x98
  private           Beyond.Input.InputBindingGroupMonoTarget_rootPanelBindingGroup  // 0xA0
  private           UnityEngine.CanvasGroup         _alphaHandler  // 0xA8
  private           UnityEngine.GameObject          _redDotAnnounce  // 0xB0
  private           Beyond.UI.UIAnimationWrapper    _transAnim  // 0xB8
  private           Beyond.UI.UIButton              _serverZoneBtn  // 0xC0
  private           Beyond.UI.UIText                _serverZoneName  // 0xC8
  private           UnityEngine.GameObject          _serverZonePS5  // 0xD0
  private           Beyond.UI.UIText                _serverZoneNamePS5  // 0xD8
  private           Beyond.UI.UIState.UIStateControllerm_curRightBtnCtrl  // 0xE0
  private           System.Boolean                  m_hasRedDot  // 0xE8
  private           System.Int32                    m_rootParentGroupId  // 0xEC
METHODS:
  System.Void OnInit()
  System.Void OnValueChanged(Beyond.Login.LoginViewModel value)
  System.Void InitBulletinAndRedAfterLoginSuc()
  System.Void Awake()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void _OnAnnounceClicked(UnityEngine.EventSystems.PointerEventData _)
  System.Void _OnSettingClicked(UnityEngine.EventSystems.PointerEventData _)
  System.Void _OnResCheckClicked(UnityEngine.EventSystems.PointerEventData _)
  System.Void _OnCustomServiceClicked(UnityEngine.EventSystems.PointerEventData _)
  System.Void _OnAccountCenterClicked(UnityEngine.EventSystems.PointerEventData _)
  System.Void _OnLogoutClicked(UnityEngine.EventSystems.PointerEventData _)
  System.Void _OnQuitGameClicked(UnityEngine.EventSystems.PointerEventData _)
  System.Void _OnLoginClicked(UnityEngine.EventSystems.PointerEventData _)
  System.Void _OnQRClicked(UnityEngine.EventSystems.PointerEventData _)
  System.Void _OnRequestRelogin()
  System.Boolean _CanQRLogin()
  System.Void _UpdateAnnounceRedDot()
  System.Void _UpdateServerZone()
  System.Void _OnServerZoneBtnClicked()
  System.Void _OnFocusMenuGroup(System.Boolean isFocused)
  System.Void _OnAnnounceClosed()
  System.Void _OnReceiveRedDotAndPopup(System.Boolean showRedDot)
  System.Void _OnUpdateRedDotForSDKListener(Beyond.EventData<System.Boolean>& show)
  System.Void _OnInputChanged(Beyond.EventData<Beyond.DeviceInfo.InputType>& input)
  System.Void .ctor()
  System.Void <OnInit>b__28_0(System.Boolean isTarget, System.Boolean isGroupChanged, System.Boolean isOnNaviTargetEnabledAgain)
  System.Void <OnInit>b__28_1(System.Boolean isTarget, System.Boolean isGroupChanged, System.Boolean isOnNaviTargetEnabledAgain)
  System.Void <OnInit>b__28_2(System.Boolean isTarget, System.Boolean isGroupChanged, System.Boolean isOnNaviTargetEnabledAgain)
  System.Void <OnInit>b__28_3(System.Boolean isTarget, System.Boolean isGroupChanged, System.Boolean isOnNaviTargetEnabledAgain)
  System.Void <OnInit>b__28_4(System.Boolean isTarget, System.Boolean isGroupChanged, System.Boolean isOnNaviTargetEnabledAgain)
  System.Void <OnInit>b__28_5(UnityEngine.EventSystems.PointerEventData _)
  System.Void <OnInit>b__28_6(System.Boolean isFocused)
  System.Void <_OnAnnounceClicked>b__35_0(System.String s)
  System.Void <>iFixBaseProxy_OnInit()
  System.Void <>iFixBaseProxy_OnDestroy()
END_CLASS

CLASS: Beyond.Login.LoginMockUIDPanel
TYPE:  class
TOKEN: 0x20000F9
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.CanvasGroup         _canvas  // 0x18
  private           Beyond.UI.UIInputField          _userIdInputField  // 0x20
  private           Beyond.UI.UIButton              _btnEnterGame  // 0x28
  private           Beyond.UI.UIButton              _btnDelLocalFile  // 0x30
  private           Beyond.UI.UIDropdown            _serverDropdown  // 0x38
  private           UnityEngine.GameObject          _hintSelectServer  // 0x40
  private           Beyond.UI.UIButton              _btnClose  // 0x48
  private           Beyond.UI.UIText                _selectedServerLabel  // 0x50
  private           System.Boolean                  m_isInited  // 0x58
  private           Beyond.UI.UISwitchTween         m_switchTween  // 0x60
  private           System.Collections.Generic.List<Beyond.Network.ServerDesc>m_serverDescList  // 0x68
  private           Beyond.Network.ServerList       m_serverListObj  // 0x70
  private           Beyond.Network.ServerConfig     m_serverConfig  // 0x78
  private           System.Action<System.String>    m_callback  // 0x80
  private           Beyond.Login.LoginMockUIDPanel.FOptionsm_options  // 0x88
  private   static  Beyond.Login.LoginMockUIDPanel  s_instance  // 0x0
METHODS:
  Beyond.Login.LoginMockUIDPanel get_instance()
  System.Void LoginWithCallback(Beyond.Login.LoginMockUIDPanel.FOptions options, System.Action<System.String> callback)
  System.Void Refresh()
  System.Collections.IEnumerator HideAndDestroy()
  System.Void _UpdateStatus()
  System.Void _InitLoginInfo()
  System.Void _SaveConfig()
  System.Void _OnBtnEnterGame()
  System.Void _SmokeEnterGame(System.String serverName, System.String uid)
  System.Void _OnBtnDelLocalFile()
  System.Void _TryClosePanel()
  System.Void _OnSelectServer(System.Int32 index)
  System.Void OnDestroy()
  System.Void .ctor()
  System.Void <_UpdateStatus>b__22_0(UnityEngine.EventSystems.PointerEventData _)
  System.Void <_UpdateStatus>b__22_1(UnityEngine.EventSystems.PointerEventData _)
  System.Void <_UpdateStatus>b__22_2(UnityEngine.EventSystems.PointerEventData _)
  System.Void <_InitLoginInfo>b__23_0(System.Int32 index, Beyond.UI.UIDropdownOption options, System.Boolean isSelected)
END_CLASS

CLASS: Beyond.Login.LoginResourcePanel
TYPE:  class
TOKEN: 0x20000FC
EXTENDS: ChildPanel
FIELDS:
  private   static  System.Single                   PROGRESS_LERP_DURATION  // 0x0
  private           UnityEngine.CanvasGroup         _alphaHandler  // 0x28
  private           Beyond.UI.UISlider              _progressBar  // 0x30
  private           Beyond.UI.UIText                _textTitle  // 0x38
  private           Beyond.UI.UIText                _textInfo  // 0x40
  private           Beyond.Login.LoginHotUpdateModel.IProgressm_progress  // 0x48
  private           Beyond.UI.TweenUtils.FLerpByTimem_progressLerper  // 0x50
  private           System.String                   m_resInfoCache  // 0x80
METHODS:
  System.Void OnValueChanged(Beyond.Login.LoginHotUpdateModel value)
  System.Void _UpdateResourceInfo()
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginRootPanel
TYPE:  class
TOKEN: 0x20000FD
EXTENDS: MonoBehaviour
FIELDS:
  private           Beyond.UI.NotchAdapter          _notchAdapter  // 0x18
  private           Beyond.Login.LoginMenuPanel     _menuPanel  // 0x20
  private           Beyond.Login.LoginAgeTipsPanel  _ageTipsPanel  // 0x28
  private           Beyond.Login.LoginGovTipsPanel  _govTipsPanel  // 0x30
  private           Beyond.Login.LoginResourcePanel _resPanel  // 0x38
  private           Beyond.Login.LoginEnterGamePanel_enterGamePanel  // 0x40
  private           Beyond.Login.LoginServerSelectPanel_serverSelectPanel  // 0x48
  private           Beyond.Input.InputBindingGroupMonoTarget_bindingGroup  // 0x50
  private           System.Int32                    m_loginRootBindingGroupId  // 0x58
METHODS:
  System.Void Awake()
  System.Void OnDestroy()
  System.Void Init(Beyond.LoginContext context)
  System.Void _OnNotchPaddingChanged(Beyond.EventData<System.Single>& data)
  System.Void _InitController()
  System.Void ToggleLoginBindingGroup(System.Boolean enable)
  System.Void InitBulletinAndRedAfterLoginSuc()
  System.Void _InitChildPanel(Beyond.Login.LoginRootPanel.ChildPanel childPanel, Beyond.LoginContext context)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginServerSelectItemView
TYPE:  class
TOKEN: 0x20000FF
EXTENDS: MonoBehaviour
FIELDS:
  private           Beyond.UI.UIText                _serverName  // 0x18
  private           Beyond.UI.UIImage               _playerIcon  // 0x20
  private           Beyond.UI.UIText                _playerLevel  // 0x28
  private           Beyond.UI.UIImage[]             _delayImages  // 0x30
  private           Beyond.UI.UIText                _delayText  // 0x38
  private           Beyond.UI.UIButton              _btnSelect  // 0x40
  private           Beyond.UI.UIState.UIStateController_stateController  // 0x48
  private   static readonly UnityEngine.Color               DEFAULT_COLOR  // 0x0
  private   static  System.String                   DEFAULT_TEXT  // 0x0
  private   static readonly Beyond.Login.LoginServerSelectItemView.DelayInfoDEFAULT_SPEED_INFO  // 0x10
  private           Beyond.Gameplay.ServerZoneManager.ServerZoneDatam_serverItem  // 0x50
  private           Beyond.LoginContext             m_context  // 0x58
  private           System.Collections.Generic.List<Beyond.Login.LoginServerSelectItemView.DelayInfo>m_speedInfos  // 0x60
METHODS:
  System.Void RefreshView(Beyond.LoginContext context, Beyond.Gameplay.ServerZoneManager.ServerZoneData serverItem, System.Boolean isSelected)
  System.Void NaviToBtnTarget()
  System.Void SetSelected(System.Boolean isSelected)
  System.Void _OnClicked(UnityEngine.EventSystems.PointerEventData _)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Login.LoginServerSelectProp
TYPE:  class
TOKEN: 0x2000101
EXTENDS: LoginProperty`1
FIELDS:
METHODS:
  System.Void .ctor(Beyond.Login.LoginWorkFlow workflow)
END_CLASS

CLASS: Beyond.Login.LoginServerItem
TYPE:  class
TOKEN: 0x2000102
FIELDS:
  public            Beyond.Gameplay.ServerZoneManager.ServerZoneDataserverZoneData  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginServerSelectModel
TYPE:  class
TOKEN: 0x2000103
FIELDS:
  public            System.Boolean                  showPanel  // 0x10
  public            System.Int32                    selectedIndex  // 0x14
METHODS:
  System.Collections.Generic.List<Beyond.Gameplay.ServerZoneManager.ServerZoneData> get_serverList()
  Beyond.Gameplay.ServerZoneManager.ServerZoneData get_curServerZoneData()
  System.Void InitData()
  Beyond.Gameplay.ServerZoneManager.ServerZoneData GetSelectedServer()
  System.Boolean UpdateSelectedServer(Beyond.Gameplay.ServerZoneManager.ServerZoneData selectedServer)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginServerSelectPanel
TYPE:  class
TOKEN: 0x2000104
EXTENDS: ChildPanel
FIELDS:
  private           Beyond.UI.UIButton              _btnBack  // 0x28
  private           Beyond.UI.UIButton              _btnConfirm  // 0x30
  private           Beyond.UI.UIAnimationWrapper    _showAnim  // 0x38
  private           Beyond.UI.UIScrollList          _showList  // 0x40
  private           Beyond.UI.UISelectableNaviGroup _naviGroup  // 0x48
  private           Beyond.Input.InputBindingGroupMonoTarget_bindingGroup  // 0x50
  private           Beyond.Input.InputBindingGroupMonoTarget_rootPanelBindingGroup  // 0x58
  private           Beyond.Login.LoginServerSelectModelm_viewModel  // 0x60
METHODS:
  System.Void OnInit()
  System.Void OnDisable()
  System.Void OnEnable()
  System.Void _UpdateServerCell(UnityEngine.GameObject cell, System.Int32 index)
  System.Void _UpdateServerSelected(System.Int32 index, UnityEngine.GameObject cell)
  System.Void OnValueChanged(Beyond.Login.LoginServerSelectModel value)
  System.Void _NaviToSelectedItem()
  System.Void _OnInputChanged(Beyond.EventData<Beyond.DeviceInfo.InputType>& input)
  System.Void _OnCloseClicked(UnityEngine.EventSystems.PointerEventData _)
  System.Void _OnConfirmClicked(UnityEngine.EventSystems.PointerEventData _)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnInit()
END_CLASS

CLASS: Beyond.Login.LoginVersionPanel
TYPE:  class
TOKEN: 0x2000106
EXTENDS: MonoBehaviour
FIELDS:
  private           Beyond.UI.UIText                _textVersion  // 0x18
METHODS:
  System.Void Start()
  System.String get_displayGameVersion()
  System.String get_versionZoneType()
  System.String get_versionPlatform()
  System.String get_versionAppType()
  System.String get_versionVersionNum()
  System.String get_versionProjectCL()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Login.LoginVocResSelDialog
TYPE:  class
TOKEN: 0x2000107
EXTENDS: Dialog
FIELDS:
  private           Beyond.Login.LoginVocResSelDialog.FParamsm_params  // 0x38
  private           Beyond.UI.UIButton              _btnConfirm  // 0x40
  private           Beyond.UI.UIScrollList          _showList  // 0x48
  private           Beyond.UI.UISelectableNaviGroup _naviGroup  // 0x50
  private           Beyond.Input.InputBindingGroupMonoTarget_bindingGroup  // 0x58
  private           System.Collections.Generic.List<Beyond.Login.LoginVocResSelDialog.VocResInfo>m_vocResInfos  // 0x60
  private           System.Int32                    m_selectedIndex  // 0x68
METHODS:
  System.Void OnInit()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void SetParams(Beyond.Login.LoginVocResSelDialog.FParams param)
  System.Void UpdateSelected(Beyond.VFS.EVFSBlockType type)
  System.Void _UpdateList()
  System.Void _UpdateSelected(System.Int32 index, UnityEngine.GameObject cell)
  System.Void _UpdateCell(UnityEngine.GameObject cell, System.Int32 index)
  System.Void _OnConfirmClicked(UnityEngine.EventSystems.PointerEventData evt)
  System.Void _OnConfirmClicked()
  System.Void _OnInputTypeChanged(Beyond.EventData<Beyond.DeviceInfo.InputType>& data)
  System.Void _NaviToSelectedItem()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnInit()
END_CLASS

CLASS: Beyond.Login.LoginVocResSelItemView
TYPE:  class
TOKEN: 0x200010A
EXTENDS: MonoBehaviour
FIELDS:
  private           Beyond.UI.UIText                _name  // 0x18
  private           Beyond.UI.UIText                _size  // 0x20
  private           Beyond.UI.UIButton              _btnSelect  // 0x28
  private           Beyond.UI.UIState.UIStateController_stateController  // 0x30
  private           Beyond.Login.LoginVocResSelDialog.VocResInfom_info  // 0x38
  private           Beyond.Login.LoginVocResSelDialogm_context  // 0x40
  private   static  System.Double                   MB  // 0x0
METHODS:
  System.Void RefreshView(Beyond.Login.LoginVocResSelDialog context, Beyond.Login.LoginVocResSelDialog.VocResInfo info, System.Boolean isSelected)
  System.Void NaviToBtnTarget()
  System.Void SetSelected(System.Boolean isSelected)
  System.Void _OnClicked(UnityEngine.EventSystems.PointerEventData _)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SDK.PlatformFont
TYPE:  class
TOKEN: 0x2000050
FIELDS:
  private   static  System.Int32                    DEFAULT_FONT_ID  // 0x0
METHODS:
  TMPro.TMP_FontAsset GetFont()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SDK.SDKNetUtils
TYPE:  class
TOKEN: 0x2000051
FIELDS:
  public    static  System.String                   CONTENT_TYPE_JSON  // 0x0
  private   static  System.Int32                    GENERAL_TIMEOUT  // 0x0
  private   static  Beyond.SDK.SDKNetUtils.HTTPImpl s_HTTPImpl  // 0x0
METHODS:
  System.Void HTTPPost(Beyond.SDK.SDKNetUtils.HttpPostRequest request)
  System.Void HTTPGet(Beyond.SDK.SDKNetUtils.HttpGetRequest request)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.SDK.SDKTextDefines
TYPE:  class
TOKEN: 0x200005A
FIELDS:
  public    static  System.String                   CS_SDK_STO_DESC  // 0x0
  public    static  System.String                   CS_SDK_COMMON_ERROR  // 0x0
  public    static  System.String                   CS_SDK_CREATE_ORDER_ERROR  // 0x0
  public    static  System.String                   CS_SDK_CREATE_ORDER_ERROR_LIMIT_COUNT  // 0x0
  public    static  System.String                   CS_SDK_USR_BAN  // 0x0
  public    static  System.String                   CS_SDK_USR_BAN_TIME  // 0x0
  public    static  System.String                   CS_SDK_LOGIN_FORBID  // 0x0
  public    static  System.String                   CS_SDK_CREATE_ORDER_ERROR_NETWORK_TIMEOUT  // 0x0
  public    static  System.String                   CS_SDK_CREATE_ORDER_ERROR_NETWORK_ERROR  // 0x0
  public    static  System.String                   CS_SDK_CREATE_ORDER_ERROR_TOKEN_INVALID  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.SDK.Impl.U8ExternalTools
TYPE:  class
TOKEN: 0x200005B
EXTENDS: SDKExternalToolsShortcut
FIELDS:
  private   static  System.Boolean                  s_inited  // 0x0
  private   static  System.Boolean                  s_initing  // 0x1
  private   static  System.Boolean                  s_needRetry  // 0x2
  private   static  System.Boolean                  s_needQuitGame  // 0x3
  private   static  Beyond.SDK.Impl.U8ExternalTools.FHGSDKInits_initHGSDK  // 0x4
METHODS:
  System.Boolean IsInited()
  System.Boolean NeedRetryInit()
  System.Boolean NeedQuitGame()
  System.Void RetryInitSDKSystem(System.String env)
  System.Void InitSDKSystem(System.String env)
  System.Collections.IEnumerator WaitForInited()
  System.Void InitHGSDK(System.String env)
  System.Boolean IsHGSDKInited()
  System.Collections.IEnumerator WaitForInitHGSDK()
  System.Void Log(System.String content)
  System.Void LogError(System.String content)
  System.Void LogWarning(System.String content)
  System.String GetSignKey()
  System.Collections.Generic.Dictionary<System.String,System.String> GetDeviceIDs()
  System.Void SetSubChannel(System.String subChannel)
  System.Int32 GetPlatformKey()
  System.Void OnSDKExtraInfo(System.String jsonData)
  System.String U8RootUrl()
  System.Void POSTImplementation(U8.SDK.SDKExternalTools.POSTRequest request, System.Action<U8.SDK.SDKExternalTools.POSTResult> callback)
  U8.SDK.SDKExternalTools.POSTResult _ConvertToPOSTResult(Beyond.SDK.SDKNetUtils.WebHttpResponse response)
  System.Void _ProcessExtraInfo(U8.SDK.SDKExtraData extraData)
  System.Void _OnRequestExitGame()
  System.Void _OnFakeAccountCenter()
  U8.SDK.SDKCaptchaHandler CreateCaptchaHandler()
  System.String GetErrorMessage(U8.SDK.SDKExternalTools.ErrMsgMeta meta)
  System.Boolean _ErrorMsg_GET_TOKEN(U8.SDK.SDKExternalTools.ErrMsgMeta meta, System.String& errorMsg)
  System.Boolean _ErrorMsg_CREATE_ORDER(U8.SDK.SDKExternalTools.ErrMsgMeta meta, System.String& errorMsg)
  System.Void .ctor()
  System.String <>iFixBaseProxy_GetSignKey()
  System.Collections.Generic.Dictionary<System.String,System.String> <>iFixBaseProxy_GetDeviceIDs()
  System.Void <>iFixBaseProxy_OnSDKExtraInfo(System.String P0)
END_CLASS

CLASS: Beyond.SDK.Impl.U8Plugin
TYPE:  class
TOKEN: 0x2000063
FIELDS:
METHODS:
  System.String GetPayAddition()
  System.String GetSDKToken()
  System.String GetSDKUid()
  System.Void Init()
  System.Void Login(U8.SDK.ExternalPluginLoginParams args)
  System.Void Logout(U8.SDK.ExternalPluginLogoutParams args)
  System.Void OnProductListChanged(System.Collections.Generic.List<U8.SDK.U8ProductInfo> productList)
  System.Void Pay(U8.SDK.ExternalPluginPayParams args)
  System.Boolean TryLoadSDKMeta(System.Func<U8.SDK.SDKMeta> loadMetaNative, U8.SDK.SDKMeta& meta)
  System.Boolean _UseMockVersion()
  System.Void _MockLogin(U8.SDK.ExternalPluginLoginParams args)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Scripts.Entry.GameSettingSetter
TYPE:  class
TOKEN: 0x200010B
FIELDS:
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single><audioGlobalVolume>k__BackingField  // 0x0
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single><audioMusicVolume>k__BackingField  // 0x8
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single><audioVoiceVolume>k__BackingField  // 0x10
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single><audioSfxVolume>k__BackingField  // 0x18
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean><audioSuspendUnfocused>k__BackingField  // 0x20
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean><audioBackgroundMusic>k__BackingField  // 0x28
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingAudioSuiteMode><audioSuiteMode>k__BackingField  // 0x30
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean><audioController>k__BackingField  // 0x38
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean><audioSpatial>k__BackingField  // 0x40
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single><controllerCameraSpeedX>k__BackingField  // 0x48
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single><controllerCameraSpeedY>k__BackingField  // 0x50
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single><controllerCameraTopViewSpeed>k__BackingField  // 0x58
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single><controllerWalkRunRatio>k__BackingField  // 0x60
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.CameraImpulseLevel><cameraImpulseLevel>k__BackingField  // 0x68
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean><enableCameraFar>k__BackingField  // 0x70
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean><controllerCameraReverseX>k__BackingField  // 0x78
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean><controllerCameraReverseY>k__BackingField  // 0x80
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingControllerAutoLockTarget><controllerAutoLockTarget>k__BackingField  // 0x88
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.ComboSkillCameraAlpha><comboSkillCameraAlpha>k__BackingField  // 0x90
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean><controllerAutoSprint>k__BackingField  // 0x98
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean><controllerMotion>k__BackingField  // 0xA0
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean><controllerTriggerEffect>k__BackingField  // 0xA8
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean><enableAutoAttackTouch>k__BackingField  // 0xB0
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean><enableAutoAttackGamepad>k__BackingField  // 0xB8
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GEnums.EnvLang><languageText>k__BackingField  // 0xC0
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingLanguageAudio><languageAudio>k__BackingField  // 0xC8
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingVideoQuality><graphicsQuality>k__BackingField  // 0xD0
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Int32,System.Int32><graphicsResolution>k__BackingField  // 0xD8
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single><graphicsNotchPadding>k__BackingField  // 0xE0
  private   static  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean><otherShowSmartAlert>k__BackingField  // 0xE8
  public    static  System.Boolean                  s_stageInitFinished  // 0xF0
METHODS:
  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> get_audioGlobalVolume()
  System.Void set_audioGlobalVolume(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> value)
  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> get_audioMusicVolume()
  System.Void set_audioMusicVolume(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> value)
  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> get_audioVoiceVolume()
  System.Void set_audioVoiceVolume(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> value)
  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> get_audioSfxVolume()
  System.Void set_audioSfxVolume(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> value)
  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> get_audioSuspendUnfocused()
  System.Void set_audioSuspendUnfocused(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> value)
  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> get_audioBackgroundMusic()
  System.Void set_audioBackgroundMusic(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> value)
  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingAudioSuiteMode> get_audioSuiteMode()
  System.Void set_audioSuiteMode(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingAudioSuiteMode> value)
  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> get_audioController()
  System.Void set_audioController(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> value)
  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> get_audioSpatial()
  System.Void set_audioSpatial(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> value)
  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> get_controllerCameraSpeedX()
  System.Void set_controllerCameraSpeedX(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> value)
  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> get_controllerCameraSpeedY()
  System.Void set_controllerCameraSpeedY(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> value)
  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> get_controllerCameraTopViewSpeed()
  System.Void set_controllerCameraTopViewSpeed(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> value)
  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> get_controllerWalkRunRatio()
  System.Void set_controllerWalkRunRatio(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> value)
  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.CameraImpulseLevel> get_cameraImpulseLevel()
  System.Void set_cameraImpulseLevel(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.CameraImpulseLevel> value)
  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> get_enableCameraFar()
  System.Void set_enableCameraFar(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> value)
  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> get_controllerCameraReverseX()
  System.Void set_controllerCameraReverseX(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> value)
  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> get_controllerCameraReverseY()
  System.Void set_controllerCameraReverseY(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> value)
  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingControllerAutoLockTarget> get_controllerAutoLockTarget()
  System.Void set_controllerAutoLockTarget(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingControllerAutoLockTarget> value)
  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.ComboSkillCameraAlpha> get_comboSkillCameraAlpha()
  System.Void set_comboSkillCameraAlpha(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.ComboSkillCameraAlpha> value)
  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> get_controllerAutoSprint()
  System.Void set_controllerAutoSprint(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> value)
  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> get_controllerMotion()
  System.Void set_controllerMotion(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> value)
  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> get_controllerTriggerEffect()
  System.Void set_controllerTriggerEffect(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> value)
  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> get_enableAutoAttackTouch()
  System.Void set_enableAutoAttackTouch(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> value)
  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> get_enableAutoAttackGamepad()
  System.Void set_enableAutoAttackGamepad(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> value)
  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GEnums.EnvLang> get_languageText()
  System.Void set_languageText(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GEnums.EnvLang> value)
  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingLanguageAudio> get_languageAudio()
  System.Void set_languageAudio(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingLanguageAudio> value)
  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingVideoQuality> get_graphicsQuality()
  System.Void set_graphicsQuality(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<Beyond.GameSetting.GameSettingVideoQuality> value)
  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Int32,System.Int32> get_graphicsResolution()
  System.Void set_graphicsResolution(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Int32,System.Int32> value)
  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> get_graphicsNotchPadding()
  System.Void set_graphicsNotchPadding(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Single> value)
  Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> get_otherShowSmartAlert()
  System.Void set_otherShowSmartAlert(Beyond.Scripts.Entry.GameSettingSetter.GameSettingSetterItem<System.Boolean> value)
  System.Void InitSetterItems()
  System.Void _OnAudioGlobalVolumeChange(System.Single volume)
  System.Void _OnAudioMusicVolumeChange(System.Single volume)
  System.Void _OnAudioVoiceVolumeChange(System.Single volume)
  System.Void _OnAudioSfxVolumeChange(System.Single volume)
  System.Void _OnAudioSuspendUnfocusedChange(System.Boolean suspendUnfocused)
  System.Void _OnAudioBackgroundMusicChange(System.Boolean enable)
  System.Void _OnAudioSuiteModeChange(Beyond.GameSetting.GameSettingAudioSuiteMode mode)
  System.Void _OnAudioControllerChange(System.Boolean enable)
  System.Void _OnAudioSpatialAudioChange(System.Boolean enable)
  System.Void _OnControllerCameraSpeedXChange(System.Single cameraSpeed)
  System.Void _OnControllerCameraSpeedYChange(System.Single cameraSpeed)
  System.Void _OnControllerCameraTopViewSpeedChange(System.Single cameraSpeed)
  System.Void _OnControllerWalkRunRatioChange(System.Single walkRunRatio)
  System.Void _OnCameraImpulseLevelChange(Beyond.GameSetting.CameraImpulseLevel level)
  System.Void _OnEnableCameraFarChange(System.Boolean enable)
  System.Void _OnControllerCameraReverseXChange(System.Boolean isReverse)
  System.Void _OnControllerCameraReverseYChange(System.Boolean isReverse)
  System.Void _OnControllerAutoLockTargetChange(Beyond.GameSetting.GameSettingControllerAutoLockTarget mode)
  System.Void _OnComboSkillCameraAlphaChange(Beyond.GameSetting.ComboSkillCameraAlpha alpha)
  System.Void _OnControllerAutoSprintChange(System.Boolean valid)
  System.Void _OnControllerMotionChange(System.Boolean valid)
  System.Void _OnControllerTriggerEffectChange(System.Boolean enable)
  System.Void _OnEnableAutoAttackTouchChange(System.Boolean enable)
  System.Void _OnEnableAutoAttackGamepadChange(System.Boolean enable)
  System.Void _OnLanguageTextChange(Beyond.GEnums.EnvLang language)
  System.Void _OnLanguageAudioChange(Beyond.GameSetting.GameSettingLanguageAudio language)
  System.Void _OnGraphicsQualityChange(Beyond.GameSetting.GameSettingVideoQuality quality)
  System.Void _OnGraphicsResolutionChange(System.Int32 width, System.Int32 height)
  System.Void _OnGraphicsNotchPaddingChange(System.Single notchPadding)
  System.Void _OnOtherShowSmartAlertChange(System.Boolean show)
END_CLASS

CLASS: Beyond.Scripts.Entry.WarmUpProgress
TYPE:  class
TOKEN: 0x200010E
FIELDS:
METHODS:
  System.Double GetTotal()
  System.Double GetCurrent()
  System.String GetInfo()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.ECSComponentAttribute
TYPE:  class
TOKEN: 0x2000044
EXTENDS: Attribute
FIELDS:
  public            System.Runtime.InteropServices.LayoutKindlayoutKind  // 0x10
  public            System.Boolean                  isTag  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.CameraControlConfigAttribute
TYPE:  class
TOKEN: 0x2000045
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.DataNAttribute
TYPE:  class
TOKEN: 0x2000046
EXTENDS: Attribute
FIELDS:
  public            System.Int32                    capacity  // 0x10
  public            System.Int32                    tSize  // 0x14
  public            System.Boolean                  ring  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.AnimatorBlackboardAttribute
TYPE:  class
TOKEN: 0x2000047
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.SplashController
TYPE:  class
TOKEN: 0x2000048
EXTENDS: MonoBehaviour
FIELDS:
  private   static  System.String                   CURSOR_KEY_SPLASH  // 0x0
  private           System.Single                   _initialFadeTime  // 0x18
  private           System.Single                   _regularFadeTime  // 0x1C
  private           System.Single                   _showTime  // 0x20
  private           UnityEngine.UI.Image            _blackCoverImage  // 0x28
  private           UnityEngine.UI.Image            _splashImage  // 0x30
  private           Beyond.UI.SplashController.SplashConfigs_splashConfigsCN  // 0x38
  private           Beyond.UI.SplashController.SplashConfigs_splashConfigsOS  // 0x50
  private           DG.Tweening.Sequence            m_tween  // 0x68
  private           Beyond.UI.SplashController.SwitchSceneTriggerm_sceneTrigger  // 0x70
METHODS:
  System.Void Start()
  Beyond.UI.SplashController.SplashConfig[] _GetSplashConfigs()
  System.Void _DoStartSplash(Beyond.UI.SplashController.SplashConfig[] splashConfigs)
  System.Void _OnTweenFinished()
  System.Void _SwitchToInitScene()
  System.Collections.IEnumerator _SwitchToInitSceneCoroutine()
  System.Collections.IEnumerator _StartLicenseCoroutine()
  System.Void .ctor()
  System.Void <_DoStartSplash>b__16_1()
END_CLASS

CLASS: HG.Rendering.Runtime.HGConstantBufferLayoutAttribute
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x2000111
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // 0x0
METHODS:
  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj)
  System.Void __Gen_Wrap_0(System.Object P0, Beyond.GameState P1)
  System.Collections.IEnumerator __Gen_Wrap_1(System.Object P0)
  System.Void __Gen_Wrap_2(System.Object P0)
  System.Void __Gen_Wrap_3()
  System.Void __Gen_Wrap_4(Beyond.EventData<System.Boolean,System.Boolean>& P0)
  System.Void __Gen_Wrap_5(System.Object P0, System.Boolean P1)
  System.Void __Gen_Wrap_6(System.Int32 P0)
  System.Void __Gen_Wrap_7(System.Single P0)
  System.Void __Gen_Wrap_8(System.Boolean P0)
  System.Void __Gen_Wrap_9(Beyond.GameSetting.GameSettingAudioSuiteMode P0)
  System.Void __Gen_Wrap_10(Beyond.GameSetting.CameraImpulseLevel P0)
  System.Void __Gen_Wrap_11(Beyond.GameSetting.GameSettingControllerAutoLockTarget P0)
  System.Void __Gen_Wrap_12(Beyond.GameSetting.ComboSkillCameraAlpha P0)
  System.Void __Gen_Wrap_13(Beyond.GEnums.EnvLang P0)
  System.Void __Gen_Wrap_14(Beyond.GameSetting.GameSettingLanguageAudio P0)
  System.Void __Gen_Wrap_15(Beyond.GameSetting.GameSettingVideoQuality P0)
  System.Void __Gen_Wrap_16(System.Int32 P0, System.Int32 P1)
  System.Boolean __Gen_Wrap_17(System.Object P0, Beyond.Resource.HotUpdate.LocalResPref& P1, Beyond.VFS.VirtualFileSystem.BlockValidator& P2)
  System.Void __Gen_Wrap_18(System.Object P0, Beyond.VFS.VirtualFileSystem.BlockValidator& P1)
  System.Void __Gen_Wrap_19(System.Object P0, System.Object P1)
  System.Boolean __Gen_Wrap_20(System.Object P0)
  System.Void __Gen_Wrap_21(System.Object P0, Beyond.EventData<Beyond.DeviceInfo.InputType>& P1)
  Beyond.LoginController.MaskCtrl __Gen_Wrap_22(System.Object P0)
  Beyond.UI.UISwitchTween __Gen_Wrap_23(System.Object P0, System.Int32 P1)
  System.Collections.IEnumerator __Gen_Wrap_24(System.Object P0, System.Object P1)
  System.Void __Gen_Wrap_25(System.Object P0, System.Object P1, Beyond.LoginController.EMaskType P2, System.Boolean P3, System.Boolean P4)
  Beyond.UI.UIAnimationLayerMixPlayer __Gen_Wrap_26(System.Object P0)
  System.Void __Gen_Wrap_27(System.Object P0, Beyond.LoginController.FOptions P1)
  Beyond.Login.LoginWorkFlow.FWork __Gen_Wrap_28()
  System.Boolean __Gen_Wrap_29(Beyond.Login.LoginWorkFlow.ENode P0, Beyond.Login.LoginWorkFlow.ENode P1)
  System.Boolean __Gen_Wrap_30(Beyond.Login.LoginWorkFlow.ENode P0)
  System.Collections.IEnumerator __Gen_Wrap_31(Beyond.Login.LoginWorkFlow.ENode P0)
  UnityEngine.CustomYieldInstruction __Gen_Wrap_32(System.Object P0)
  System.Boolean __Gen_Wrap_33(Beyond.Login.LoginWorkFlow.FWork& P0)
  System.Void __Gen_Wrap_34(Beyond.Login.LoginWorkFlow.FWork& P0)
  System.Void __Gen_Wrap_35(System.Object P0, Beyond.Login.LoginAlertDialog.FParams P1)
  System.Void __Gen_Wrap_36(System.Object P0, Beyond.Login.LoginVocResSelDialog.FParams P1)
  System.Void __Gen_Wrap_37(System.Object P0, Beyond.Login.LoginJudgeDialog.FParams P1)
  System.Void __Gen_Wrap_38(Beyond.Login.LoginAlertDialog P0, Beyond.Login.LoginAlertDialog.FParams P1)
  System.Void __Gen_Wrap_39(System.Object P0, System.Object P1, System.Object P2)
  System.Void __Gen_Wrap_40(System.Object P0, System.Boolean P1, System.Object P2, System.Object P3, System.Object P4, System.Object P5, System.Object P6, System.Object P7, System.Object P8)
  System.Collections.IEnumerator __Gen_Wrap_41(System.Object P0, System.Boolean P1)
  System.Boolean __Gen_Wrap_42(System.Object P0, Beyond.Login.LoginWorkFlow.ENode& P1)
  System.Void __Gen_Wrap_43(Beyond.GameState P0)
  System.Void __Gen_Wrap_44(System.Object P0, System.Single P1)
  System.Single __Gen_Wrap_45(System.Object P0)
  Beyond.LoginController __Gen_Wrap_46(System.Object P0)
  System.Void __Gen_Wrap_47(System.Object P0, System.Object P1, System.Single P2)
  System.Collections.Generic.List<Beyond.Gameplay.ServerZoneManager.ServerZoneData> __Gen_Wrap_48(System.Object P0)
  System.Boolean __Gen_Wrap_49(System.Object P0, System.Object P1)
  Beyond.Gameplay.ServerZoneManager.ServerZoneData __Gen_Wrap_50(System.Object P0)
  System.Boolean __Gen_Wrap_51(System.Object P0, Beyond.ELoginEvent P1, System.Object P2)
  System.Void __Gen_Wrap_52(System.Object P0, Beyond.ELoginEvent P1, System.Object P2)
  System.Void __Gen_Wrap_53(System.String P0)
  System.Void __Gen_Wrap_54(UnityEngine.EventSystems.PointerEventData P0)
  System.Boolean __Gen_Wrap_55(Beyond.Login.LoginMockUIDPanel.FOptions& P0)
  System.Void __Gen_Wrap_56(System.Int32 P0, Beyond.UI.UIDropdownOption P1, System.Boolean P2)
  System.Void __Gen_Wrap_57(System.Object P0, System.Int32 P1)
  System.Void __Gen_Wrap_58(System.Object P0, Beyond.Login.LoginMockUIDPanel.FOptions P1, System.Object P2)
  Beyond.UI.UISwitchTween __Gen_Wrap_59(System.Object P0)
  System.Boolean __Gen_Wrap_60(System.Object P0, Beyond.LoginController.EMaskType P1)
  System.Void __Gen_Wrap_61(Beyond.Login.LoginVocResSelDialog P0, Beyond.Login.LoginVocResSelDialog.FParams P1)
  System.Collections.IEnumerator __Gen_Wrap_62(System.Object P0, System.Object P1, System.Object P2, System.Object P3)
  System.Void __Gen_Wrap_63(Beyond.Login.LoginJudgeDialog P0, Beyond.Login.LoginJudgeDialog.FParams P1)
  System.Void __Gen_Wrap_64(System.Object P0, System.Object P1, System.Object P2, System.Object P3)
  System.String __Gen_Wrap_65(System.Object P0, System.Object P1, System.Object P2)
  System.Void __Gen_Wrap_66(System.Boolean& P0)
  System.Void __Gen_Wrap_67(System.Object P0, System.Boolean& P1)
  System.Void __Gen_Wrap_68(System.Object P0, Beyond.LoginManager.FFlowWithMask P1)
  System.Boolean __Gen_Wrap_69(Beyond.LoginManager.FFlowCondition& P0, Beyond.Login.LoginWorkFlow.ENode P1)
  System.Collections.IEnumerator __Gen_Wrap_70(System.Object P0, Beyond.LoginManager.FFlowWithMask P1)
  Beyond.UI.SplashController.SplashConfig[] __Gen_Wrap_71(System.Object P0)
  TMPro.TMP_FontAsset __Gen_Wrap_72(System.Object P0)
  System.Void __Gen_Wrap_73(Beyond.SDK.SDKNetUtils.HttpPostRequest P0)
  System.Void __Gen_Wrap_74(Beyond.SDK.SDKNetUtils.HttpGetRequest P0)
  System.Collections.IEnumerator __Gen_Wrap_75(System.Object P0, Beyond.SDK.SDKNetUtils.HTTPConfig P1)
  System.Boolean __Gen_Wrap_76()
  System.Collections.IEnumerator __Gen_Wrap_77()
  System.String __Gen_Wrap_78(System.Object P0)
  System.Collections.Generic.Dictionary<System.String,System.String> __Gen_Wrap_79(System.Object P0)
  System.Int32 __Gen_Wrap_80(System.Object P0)
  System.Void __Gen_Wrap_81(System.Object P0, U8.SDK.SDKExtraData P1)
  U8.SDK.SDKExternalTools.POSTResult __Gen_Wrap_82(Beyond.SDK.SDKNetUtils.WebHttpResponse P0)
  System.Void __Gen_Wrap_83(Beyond.SDK.SDKNetUtils.WebHttpResponse P0)
  System.Void __Gen_Wrap_84(System.Object P0, U8.SDK.SDKExternalTools.POSTRequest P1, System.Object P2)
  U8.SDK.SDKCaptchaHandler __Gen_Wrap_85(System.Object P0)
  System.Boolean __Gen_Wrap_86(System.Object P0, U8.SDK.SDKExternalTools.ErrMsgMeta P1, System.String& P2)
  System.String __Gen_Wrap_87(System.Object P0, U8.SDK.SDKExternalTools.ErrMsgMeta P1)
  System.Collections.IEnumerator __Gen_Wrap_88(System.Object P0, System.Object P1, System.Object P2)
  System.Void __Gen_Wrap_89(System.Object P0, U8.SDK.ExternalPluginLoginParams P1)
  System.Void __Gen_Wrap_90(System.Object P0, U8.SDK.ExternalPluginLogoutParams P1)
  System.Void __Gen_Wrap_91(U8.SDK.U8PayResult P0)
  System.Void __Gen_Wrap_92(System.Object P0, U8.SDK.ExternalPluginPayParams P1)
  System.Boolean __Gen_Wrap_93(System.Object P0, System.Object P1, U8.SDK.SDKMeta& P2)
  System.Void __Gen_Wrap_94(Beyond.Login.LoginWorkFlow.FWork& P0, System.Int32 P1)
  System.Boolean __Gen_Wrap_95(System.Object P0, Beyond.Login.LoginWorkFlow.ENode P1, System.Boolean P2)
  Beyond.SDK.HGDownloader.DownloadProgress __Gen_Wrap_96(System.Object P0)
  Beyond.SDK.HGDownloader.WorkState __Gen_Wrap_97(System.Object P0)
  System.Collections.Generic.List<Beyond.SDK.HGFileInfo> __Gen_Wrap_98(System.Object P0, System.Object P1)
  System.Boolean __Gen_Wrap_99(System.Object P0, Beyond.SDK.HGRetCodeType P1, System.Int32 P2)
  System.String __Gen_Wrap_100(System.Double P0)
  System.Void __Gen_Wrap_101(System.Object P0, System.Int64 P1, System.Object P2, System.Object P3, System.Object P4)
  System.Void __Gen_Wrap_102(System.Object P0, Beyond.SDK.HGDownloader.PauseReason P1)
  System.Collections.IEnumerator __Gen_Wrap_103(System.Object P0, System.Int64 P1)
  System.Void __Gen_Wrap_104(System.Object P0, System.Int64 P1, System.Int64 P2, System.Int64 P3)
  System.Double __Gen_Wrap_105(System.Object P0)
  System.String __Gen_Wrap_106(System.Object P0, System.Boolean P1)
  Beyond.Resource.HotUpdate.LocalResPref __Gen_Wrap_107()
  Beyond.Login.LoginHotUpdater.HotUpdateInfo __Gen_Wrap_108(System.Object P0, System.Boolean P1)
  Beyond.Resource.HotUpdate.ResourceIndex __Gen_Wrap_109()
  System.String __Gen_Wrap_110(System.Object P0, System.Object P1, System.Boolean P2)
  System.Object __Gen_Wrap_111()
  System.Collections.IEnumerator __Gen_Wrap_112(System.Object P0, System.Object P1, System.Boolean P2, System.Object P3)
  System.Collections.IEnumerator __Gen_Wrap_113(System.Boolean P0, System.Object P1, System.Object P2)
  System.Void __Gen_Wrap_114(System.Object P0, System.Boolean& P1, System.Double P2, System.Double P3, System.Int32 P4, System.Boolean P5)
  System.Boolean __Gen_Wrap_115(System.Object P0, Beyond.VFS.EVFSBlockType P1)
  Beyond.Login.LoginHotUpdater __Gen_Wrap_116(System.Object P0, System.Boolean P1)
  Beyond.Login.LoginProgress.FDownloadSize.EUnit __Gen_Wrap_117(System.Double P0)
  System.Single __Gen_Wrap_118(System.Double P0, Beyond.Login.LoginProgress.FDownloadSize.EUnit P1)
  System.String __Gen_Wrap_119(System.Single P0, System.Single P1, Beyond.Login.LoginProgress.FDownloadSize.EUnit P2)
  System.String __Gen_Wrap_120(System.Single P0, Beyond.Login.LoginProgress.FDownloadSize.EUnit P1)
  System.String __Gen_Wrap_121(System.Single P0, System.Single P1)
  System.Void __Gen_Wrap_122(Beyond.Login.LoginProgress.FDownloadSize& P0, System.Double P1, System.Double P2, System.Double P3)
  System.Void __Gen_Wrap_123(Beyond.Login.LoginProgress.FDownloadSize& P0, System.Double P1, System.Double P2)
  System.Void __Gen_Wrap_124(Beyond.Login.LoginProgress.FDownloadSize& P0)
  System.Void __Gen_Wrap_125(Hypergryph.SpeedTest.SpeedTestResult P0)
  System.Threading.Tasks.Task<Hypergryph.SpeedTest.TaskResult> __Gen_Wrap_126()
  Beyond.Login.LoginViewModel.FAgeTipsPolicy __Gen_Wrap_127()
  Beyond.Login.LoginWorkFlow.Node[] __Gen_Wrap_128(System.Object P0)
  System.Single __Gen_Wrap_129(System.Object P0, System.Boolean& P1)
  Beyond.UI.UIAnimationMixPlayer __Gen_Wrap_130(System.Object P0)
  System.Void __Gen_Wrap_131(System.Object P0, Beyond.Login.LoginSceneAnimCtrl.EState P1)
  System.Collections.Generic.List<System.String> __Gen_Wrap_132(System.Object P0)
  System.Void __Gen_Wrap_133(System.Object P0, Beyond.Login.LoginViewModel.FAgeTipsPolicy P1)
  System.Void __Gen_Wrap_134(System.Object P0, System.Object P1, System.Boolean P2, System.Boolean P3)
  System.Void __Gen_Wrap_135(System.Boolean P0, System.Boolean P1, System.Boolean P2)
  System.Void __Gen_Wrap_136(System.Object P0, Beyond.EventData<System.Boolean>& P1)
  System.Void __Gen_Wrap_137(System.Object P0, Beyond.EventData<System.Single>& P1)
  System.Void __Gen_Wrap_138(System.Object P0, System.Object P1, System.Object P2, System.Boolean P3)
  System.Void __Gen_Wrap_139(System.Object P0, System.Object P1, System.Int32 P2)
  System.Void __Gen_Wrap_140(System.Object P0, System.Int32 P1, System.Object P2)
  System.Void __Gen_Wrap_141(System.Object P0, Beyond.VFS.EVFSBlockType P1)
  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixInterfaceBridge
TYPE:  class
TOKEN: 0x2000112
EXTENDS: AnonymousStorey
FIELDS:
  private           System.Int32                    methodId_0  // 0x40
  private           System.Int32                    methodId_1  // 0x44
  private           System.Int32                    methodId_2  // 0x48
  private           System.Int32                    methodId_3  // 0x4C
  private           System.Int32                    methodId_4  // 0x50
METHODS:
  System.Void System.IDisposable.Dispose()
  System.Boolean MoveNext()
  System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
  System.Void System.Collections.IEnumerator.Reset()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine)
  System.Void RefAsyncBuilderStartMethod()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x2000113
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
METHODS:
  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine)
  IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id)
  System.Boolean IsPatched(System.Int32 id)
  System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon)
  System.Object CreateWrapper(System.Int32 id)
  System.Object InitWrapperArray(System.Int32 len)
  IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine)
END_CLASS

CLASS: IFix.IDMAP0
TYPE:  struct
TOKEN: 0x2000114
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  IFix.IDMAP0                     Beyond-GameApp-SwitchState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameApp-_FetchRemoteConfigUtilSuc0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameApp-_InitSecuritySDK0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameApp-_InitGameStateMachine0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameApp-_Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameApp-_OnApplicationFocusForLua0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameApp-_OnApplicationPauseForLua0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameApp-_RegisterLuaAfterGCEvent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameApp-_OnSystemDisplaySizeChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameApp-RefreshScreenResolution0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameApp-_OnSystemScreenSizeChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameApp-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameApp-Update0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameApp-LateUpdate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameApp-OnApplicationQuit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameApp-OnApplicationFocus0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameApp-_OnApplicationPauseForSecurity0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameApp-OnApplicationPause0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameApp-_UnInitGameStateMachine0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameApp-_UnInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameApp-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameApp-QuitGame0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameStateBase-OnEnter0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnAudioGlobalVolumeChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnAudioMusicVolumeChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnAudioVoiceVolumeChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnAudioSfxVolumeChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnAudioSuspendUnfocusedChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnAudioBackgroundMusicChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnAudioSuiteModeChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnAudioControllerChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnAudioSpatialAudioChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnControllerCameraSpeedXChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnControllerCameraSpeedYChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnControllerCameraTopViewSpeedChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnControllerWalkRunRatioChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnCameraImpulseLevelChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnEnableCameraFarChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnControllerCameraReverseXChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnControllerCameraReverseYChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnControllerAutoLockTargetChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnComboSkillCameraAlphaChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnControllerAutoSprintChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnControllerMotionChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnControllerTriggerEffectChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnEnableAutoAttackTouchChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnEnableAutoAttackGamepadChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnLanguageTextChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnLanguageAudioChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnGraphicsQualityChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnGraphicsResolutionChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnGraphicsNotchPaddingChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-_OnOtherShowSmartAlertChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-GameSettingSetter-InitSetterItems0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameInitState-_PreInitGameSetting0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameInitState-_CheckIfLocalInitialAssetsValid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameInitState-_InitAPPDefaultCulture0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameInitState-_InitInitialResourceManager0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-RenderPipelineDataLoader-LoadRpData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-VietnamLoginAgePanel-_UnInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-VietnamLoginAgePanel-_Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-VietnamLoginAgePanel-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameInitState-_InitGameSetting0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-RecordSplashSceneHandle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameInitState-_DoInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameInitState-OnEnter0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameStateBase-OnLeave0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameInitState-OnLeave0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginContext-IsDisposed0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-IsWorkflowInProgress0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Node-OnDispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Node-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-_EnableCursor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-_UpdateCursor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-_EnbaleToggleGroup0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Worker-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-AssetLoader-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginContext-_DisposeImpl0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginController-get_maskCtrl0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginController-MaskCtrl-_GetMaskByType0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginController-MaskCtrl-IsCrossSceneMaskTweening0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginController-MaskCtrl-WaitForCrossSceneMasks0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginController-MaskCtrl-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginController-BeforeDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginContext-_DisposeCoroutine0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginContext-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginContext-IsWorkflowDisposed0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginController-MaskCtrl-EnableMask0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginRootPanel-_InitController0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginRootPanel-ChildPanel-OnInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginRootPanel-ChildPanel-OnLoginContext0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginRootPanel-_InitChildPanel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginRootPanel-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDecorateUI-_EnsureGlowPlayer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDecorateUI-_ToggleGlow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDecorateUI-OnLoginContext0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginController-_InitVersionBtn0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginController-_InitCoroutine0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginController-_InitImpl0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginController-InitUI0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-FWork-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-IsOnOrAfterWork0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-IsBeforeWork0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-_CheckIfGameStateNotMatch0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-_AdjustCurrentGameState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Worker-SetCurNode0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Worker-_InternalTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Node-Cancel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Worker-Work0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Worker-TickInEmptyFrame0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-FWork-ConsumeFallback0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-FWork-MoveNextIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-FWork-WorkEnd0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-DoWorkFlow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-_LoginWorkFlowCoroutine0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-_PrepareBeforeLoginProcess0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAlertDialog-SetParams0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelDialog-SetParams0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginJudgeDialog-SetParams0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginContext-StartCoroutine0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-AlertDialog0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginContext-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginController-InvokeWhenStart0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-_Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-InitCoroutine0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameLoginState-_TryStartLoginWorkflow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameLoginState-OnEnter0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameLoginState-OnLeave0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginContext-ShutDown0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-_ClearWorkflowAndContext0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-_ReleaseSplashScene0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-_ReleaseLoginScene0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-_ClearLoginSceneCoroutine0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-Clear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameMainState-OnEnter0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-IsAfterWork0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-PeekFallbackStatus0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-IsReLoginInProgress0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-OnReleaseMainGame0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameMainState-_ClearUtils0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameMainState-ReleaseMainGame0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameMainState-OnLeave0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GamePreloadState-_InitGameSettingStateInPreload0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GamePreloadState-_DoPreload0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GamePreloadState-OnEnter0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GamePreloadState-OnLeave0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-VietnamLoginAgePanel-UnInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameQuitState-DoQuit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameQuitState-OnEnter0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameQuitState-OnLeave0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-InvokeWhenWorkFlowFinished0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameStartState-_OnEnterMainGame0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameStartState-OnEnter0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameStartState-OnLeave0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameStateBase-OnTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameStateMachine-_RegisterStates0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameStateMachine-CheckCanReturnToLoginState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GameStateMachine-ReturnToLoginState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-GlobalInitializer-InitGlobalConfig0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginController-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginController-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginController-GetEnterGamePanelPredelay0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAgeTipsModel-IsContentEmpty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginContext-ViewOnlyController0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginController-MaskCtrl-EnableNetMask0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginController-MaskCtrl-DisableNetMask0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-_FetchAgeTipsCoroutine0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginRootPanel-ToggleLoginBindingGroup0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-_EventOnOpenAgeTips0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-_EventOnCloseAgeTips0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-_EventOnOpenServerSelect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectModel-get_serverList0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectModel-UpdateSelectedServer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-_EventOnSelectServer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectModel-GetSelectedServer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-_EventOnConfirmServer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-_HandleGlobalEvent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Node-OnEvent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-SendEvent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginController-OnValueChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMockUIDPanel-_SaveConfig0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMockUIDPanel-_OnBtnEnterGame0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMockUIDPanel-_OnBtnDelLocalFile0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMockUIDPanel-FOptions-IsUIDFixed0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMockUIDPanel-_TryClosePanel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMockUIDPanel-_OnSelectServer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMockUIDPanel-_InitLoginInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMockUIDPanel-_UpdateStatus0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMockUIDPanel-LoginWithCallback0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMockUIDPanel-HideAndDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginController-_MockLoginCoroutine0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginController-MockLoginWithCallback0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginController-Dialog-_CloseCoroutine0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginController-Dialog-TryCloseWithCallback0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginController-Dialog-Show0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginController-Dialog-OnInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginController-MaskCfg-CreateTweenAndHide0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginController-MaskCtrl-IsMaskTweening0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginContext-StopCoroutine0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginContext-SendEvent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneComponent-OnBindToManager0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneComponent-Bind0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-_BindPendingComponents0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-SceneComponentOnly_Bind0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-ToggleLoginBindingGroup0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-VocResSelDialog0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-VocResSelDialogWithConfirm0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-AlertDialogWithResult0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-AlertDialogWithConfirm0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-_StartShowJudgeDialogCoroutine0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-JudgeDialog0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-JudgeDialog1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-MockLoginWithCallback0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-MockManualSelectServer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-IsLoginSceneLoading0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-_ExtractErrorInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-FetchRemoteConfigUtilSuc0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-DevOnlyCheckEnableLocalResMode0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-DevOnlyUseLocalResVersion0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-AssetLoader-_CheckDisposedBeforeLoad0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-FlowWithMaskMgr-_OnFlowFinished0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-FFlowCondition-IsTargetMatch0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-FlowWithMaskMgr-_FlowCoroutine0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-LoginManager-FlowWithMaskMgr-StartFlow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-VietnamLoginAgePanel-OnApplicationQuit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-VietnamLoginAgeTipsPanelCtrl-_SetStateTips0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-VietnamLoginAgeTipsPanelCtrl-_SetStateCircle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-VietnamLoginAgeTipsPanelCtrl-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-TailGameLoop-Update0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-TailGameLoop-LateUpdate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SplashController-_StartLicenseCoroutine0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SplashController-_SwitchToInitSceneCoroutine0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SplashController-_SwitchToInitScene0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SplashController-_GetSplashConfigs0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SplashController-SwitchSceneTrigger-_TryTriggerSwitchScene0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SplashController-SwitchSceneTrigger-NotifyTweenFinished0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SplashController-_OnTweenFinished0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SplashController-_DoStartSplash0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SplashController-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-PlatformFont-GetFont0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-SDKNetUtils-HTTPPost0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-SDKNetUtils-HTTPGet0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-SDKNetUtils-BeyondHttp-DoHTTP0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-IsInited0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-NeedRetryInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-NeedQuitGame0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-_OnRequestExitGame0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-InitSDKSystem0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-RetryInitSDKSystem0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-WaitForInited0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-InitHGSDK0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-IsHGSDKInited0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-WaitForInitHGSDK0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-Log0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-LogError0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-LogWarning0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-GetSignKey0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-GetDeviceIDs0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-SetSubChannel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-GetPlatformKey0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-CaptchaHandler-OnGT3Message0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-_ProcessExtraInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-OnSDKExtraInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-U8RootUrl0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-_ConvertToPOSTResult0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-POSTImplementation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-_OnFakeAccountCenter0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-CreateCaptchaHandler0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-_ErrorMsg_GET_TOKEN0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-_ErrorMsg_CREATE_ORDER0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-GetErrorMessage0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8ExternalTools-CaptchaHandler-FetchCaptchaCoroutine0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8Plugin-GetPayAddition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8Plugin-GetSDKToken0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8Plugin-GetSDKUid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8Plugin-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8Plugin-_UseMockVersion0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8Plugin-_MockLogin0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8Plugin-Login0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8Plugin-Logout0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8Plugin-OnProductListChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8Plugin-Pay0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SDK-Impl-U8Plugin-TryLoadSDKMeta0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-Clear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginCheckForUpdateNode-AlertNoMatchDeviceBeforeLogin0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginCheckForUpdateNode-_GetRequestPram0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginCheckForUpdateNode-_GetOnlineAppVersion0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-ShowWaitProgress0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-GetWaitTime0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdatePC0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdateCoroutinePC0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-ClearWaitProgress0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdateCoroutine0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginCheckForUpdateNode-Work0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-_CreateDirectoryIfNotExists0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-Context-CompleteWithCode0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-Context-UncompleteWithCode0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-GetNoAlertCode0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-_GetLastGameInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-CheckLastGameInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-FWork-MarkFallback0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Fallback0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdateCoroutineMobile0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginCreateRoleNode-WorkProcess-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginCreateRoleNode-OnDispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginCreateRoleNode-CanCancel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginCreateRoleNode-Work0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDownloadTask-GetDownloadProgress0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDownloadTask-GetDecompressProgress0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDownloadTask-GetWorkState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDownloadTask-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDownloadTask-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDownloadTask-_GetFileList0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-NetUsagePolicy-AllowMobileDataInLastCheck0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDownloadTask-_OnDownloadFinish0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDownloadTask-_OnDownloadError0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-NetUsagePolicy-_GetPrettySizeStringUpToMB0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-NetUsagePolicy-CheckIfAllowDownload0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDownloadTask-_OnDownloadPaused0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDownloadTask-_StartDownloadImpl0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDownloadTask-_StartDownload0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameSettingInitializer-_TryInitializeComponents0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameSettingInitializer-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameSettingInitializer-_InitGameSettingNotchPadding0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameSettingInitializer-_InitGameSettingStateInLogin0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameSettingInitializer-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdateNode-_GameUpdateCoroutine0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdateNode-Work0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-_YieldCheckNetUsagePolicy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-_YieldErrorAlert0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-_OnDownloadStart0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-_OnDownloadProgress0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-_DoTaskUpdating0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-_UpdateGame0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-_WaitForTaskCancel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdater-DoUpdate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGameUpdateNode-_GameUpdateCoroutineMobileImpl0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-EnterGameServiceFlow-IsInterruptable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-EnterGameServiceFlow-TryInterrupt0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-_FallbackToInitNodeImpl0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-_LogoutToInitNode0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-_FallbackToInitWithMask0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-EnterGameServiceFlow-_ReLoginWhenErrorEncountered0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-EnterGameServiceFlow-_OnAuthError0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-_ConfirmServer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-EnterGameServiceFlow-_MockManualSelectServer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-EnterGameServiceFlow-_SaveCurrentUserToServerConfig0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-EnterGameServiceFlow-_NetConnectAndGSLogin0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-EnterGameServiceFlow-_GlobalLoginSucBusiness0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-EnterGameServiceFlow-_EnterGameCoroutine0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-EnterGameServiceFlow-EnterGame0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-Work0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-_OnEventLogout0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginViewModel-RequestResourceRepair0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-_FallbackToResRepairImpl0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-_OnEventResourceRepair0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-OnEvent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-EnterGameServiceFlow-MarkAborting0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-EnterGameServiceFlow-_ExtractErrorInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGSNode-EnterGameServiceFlow-_YieldAlertError0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdateModel-SimpleProgress-GetCurrent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdateModel-SimpleProgress-GetTotal0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdateModel-SimpleProgress-GetInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-MarkInitialAssetChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-CheckInitialAssetChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-MarkNeedClearFolder0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-NeedClearFolder0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-MarkClearSuccessed0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginLocalResTask-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_UpdateResVersionDev0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_UpdateResVersionProd0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_UpdateResVersion0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_CurrentWorkMode0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_GetOnlineResVersion0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-WorkContext-GetHotUpdateInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-ResourceRootUrl0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_ResourceIndexUrl0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_LoadOrDownloadResIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_GenResIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_ResourcePatchUrl0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_ResourceFileUrl0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_LoadStreamingIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_GenRiff0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_ResourcePatchRootUrl0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_DownloadPatchInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_EventLogDownloadProgress0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-HotUpdateInfo-HasAssetsChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-WriteLocalResPrefToFile0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_GenLocalRef0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_CheckAndDownloadResource0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-HotUpdateInfo-CheckIfNeedReload0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-HotUpdateInfo-HasChangedByType0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-WorkContext-MarkIllegalItemsInLocalRes0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_CheckLocalResConsistency0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_ClearDownloadFolder0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-WorkContext-HasChangedByType0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_ReloadResourceIndexes0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_MainCoroutineModeDownload0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginLocalResTask-Work0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_MainCoroutineModeLocal0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_MainCoroutineModeSkip0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_CreateMainCoroutine0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginViewModel-RequestSkipU8Login0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_VitalError0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-_Work0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginHotUpdater-StartHotUpdate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginProgress-GetCurrent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginProgress-GetTotal0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginProgress-FDownloadSize-_PickUnit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginProgress-FDownloadSize-_DisplayWithUnit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginProgress-FDownloadSize-_FormatDisplayInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginProgress-FDownloadSize-_FormatSpeedInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginProgress-FDownloadSize-_FormatProgressInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginProgress-FDownloadSize-SetSize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginProgress-FDownloadSize-SetProgress0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginProgress-FDownloadSize-SetIdle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginProgress-GetInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginInitNode-_YieldAlertError0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginInitNode-_InitRemoteConfigs0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginInitNode-_InitCoroutine0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginInitNode-Work0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-PreloadNode-_ShowPreloadResourcePanel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-PreloadNode-_WarmUp0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-PreloadNode-_OnGetServerListSuc0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-PreloadNode-_GetServerListInfoMock0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-PreloadNode-_OnGetServerListFail0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-PreloadNode-_GetServerListInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-PreloadNode-_GetServerList0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-PreloadNode-_EnterPreLoad0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-PreloadNode-_LoginPreLoad0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-PreloadNode-Work0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSDKInitNode-_WaitForSDKInited0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSDKInitNode-_InitSubSDKs0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSDKInitNode-_SDKInitCoroutine0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSDKInitNode-Work0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-U8LoginNode-_ClearLoginCaches0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-U8LoginNode-_EnableBlurMask0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-U8LoginNode-_OnSDKViewDisabled0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnReceiveRedDotAndPopup0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_UpdateAnnounceRedDot0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-InitBulletinAndRedAfterLoginSuc0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginRootPanel-InitBulletinAndRedAfterLoginSuc0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-U8LoginNode-_OnLoginSuc0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-U8LoginNode-_SkipSDKLogin0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-U8LoginNode-_SetCursorOnLoginStart0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-U8LoginNode-_SetCursorOnLoginFinish0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-U8LoginNode-_OnLoginCanceled0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-U8LoginNode-_OnLoginFail0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-U8LoginNode-_StartSDKLogin0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-U8LoginNode-_FinishLogin0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-U8LoginNode-_LoginCoroutine0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-U8LoginNode-Work0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-U8LoginNode-OnEvent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginViewModel-IsAgeTipsVisible0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginViewModel-IsGovTipsVisible0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginViewModel-IsMenuVisible0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginViewModel-_LoadAgeTipsPolicy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAgeTipsModel-CanDisplay0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAgeTipsProp-ClearContentCache0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAgeTipsProp-UpdateContent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-_RegisterNodes0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Node-CanCancel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Worker-Cancel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-CancelAndFallback0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-AddEventReceiver0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Worker-UpdateOnce0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-UpdateOnce0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Node-OnInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginWorkFlow-Node-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-HotUpdateNode-Work0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-HotUpdateNode-OnDispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-WaitForSecondsNode-_NotifyTimeout0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-WaitForSecondsNode-_IsTimeout0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-WaitForSecondsNode-Work0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-WaitForSecondsNode-_DisposeTimer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-WaitForSecondsNode-OnDispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-PreloadPostDelayNode-WaitForSeconds0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-PreloadPostDelayNode-_DisableLoadingPanel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-PreloadPostDelayNode-Work0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-Trans2GsLoginNode-WaitForSeconds0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-Trans2GsLoginNode-Work0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-FinishNode-Work0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneAnimCtrl-OnBindToManager0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneAnimCtrl-_EnsurePlayer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneAnimCtrl-_RandomIntervalA1s0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneAnimCtrl-_ResetToA10  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneAnimCtrl-_PlayA1A2Impl0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneAnimCtrl-_TransitionToA20  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneAnimCtrl-_ChangeToState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneAnimCtrl-_PlayA1sAndTriggerNext0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneAnimCtrl-OnValueChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneComponent-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneAnimCtrl-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneAnimCtrl-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneAnimCtrl-OnRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneAnimCtrl-GetAnimationClips0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginSceneRoot-OnBindToManager0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAgeTipsDetailPanel-_EventOnCloseClicked0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAgeTipsDetailPanel-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAgeTipsDetailPanel-_SplitLongString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAgeTipsDetailPanel-_SplitLicenseToSegments0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAgeTipsDetailPanel-_RenderContent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAgeTipsDetailPanel-_ShowContent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAgeTipsDetailPanel-OnValueChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAgeTipsPanel-_EventOnOpenAgeTipsClicked0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAgeTipsPanel-OnInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAgeTipsPanel-_UpdateAgeTipsPolicy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAgeTipsPanel-OnValueChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAlertDialog-_OnConfirmClicked0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginAlertDialog-OnInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDecorateUI-_TriggerTrans2GSLoginImpl0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDecorateUI-OnValueChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDecorateUI-_TimeManagerTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDecorateUI-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginDecorateUI-OnRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginEnterGamePanel-_OnEnterGameClicked0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginEnterGamePanel-_InitIfNot0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginRootPanel-ChildPanel-SetPanelVisibleByFadeSwitchTween0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginEnterGamePanel-OnValueChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGovTipsPanel-_EventOnOpenAgeTipsClicked0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGovTipsPanel-OnInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginGovTipsPanel-OnValueChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginJudgeDialog-_OnPositiveClicked0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginJudgeDialog-_OnNegativeClicked0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginJudgeDialog-OnInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnAnnounceClosed0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnAnnounceClicked0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnSettingClicked0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnResCheckClicked0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnLogoutClicked0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnQuitGameClicked0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnLoginClicked0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnQRClicked0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnServerZoneBtnClicked0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnFocusMenuGroup0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-OnInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_CanQRLogin0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-OnValueChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_UpdateServerZone0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnRequestRelogin0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnInputChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnUpdateRedDotForSDKListener0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginRootPanel-ChildPanel-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnCustomServiceClicked0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMenuPanel-_OnAccountCenterClicked0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMockUIDPanel-Refresh0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMockUIDPanel-_SmokeEnterGame0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginMockUIDPanel-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginResourcePanel-_UpdateResourceInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginResourcePanel-OnValueChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginResourcePanel-Update0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginRootPanel-_OnNotchPaddingChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginRootPanel-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginRootPanel-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginRootPanel-ChildPanel-SetPanelVisibleByAnimSwitchTween0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectItemView-_OnClicked0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectItemView-RefreshView0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectItemView-NaviToBtnTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectItemView-SetSelected0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectModel-InitData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectPanel-_OnConfirmClicked0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectPanel-_OnCloseClicked0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectPanel-_UpdateServerCell0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectPanel-OnInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectPanel-_NaviToSelectedItem0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectPanel-_OnInputChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectPanel-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectPanel-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectPanel-_UpdateServerSelected0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginServerSelectPanel-OnValueChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVersionPanel-get_displayGameVersion0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVersionPanel-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelDialog-_OnConfirmClicked0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelDialog-_OnConfirmClicked1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelItemView-SetSelected0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelDialog-_UpdateSelected0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelDialog-_UpdateList0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelDialog-UpdateSelected0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelItemView-_OnClicked0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelItemView-RefreshView0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelDialog-_UpdateCell0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelItemView-NaviToBtnTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelDialog-_NaviToSelectedItem0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelDialog-OnInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelDialog-_OnInputTypeChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelDialog-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Login-LoginVocResSelDialog-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-WarmUpProgress-GetTotal0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-WarmUpProgress-GetCurrent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Entry-WarmUpProgress-GetInfo0  // 0x0
METHODS:
END_CLASS

