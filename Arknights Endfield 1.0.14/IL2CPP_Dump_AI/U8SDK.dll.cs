// ========================================================
// Dumped by @desirepro
// Assembly: U8SDK.dll
// Classes:  146
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: Status
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  U8.SDK.SDKCaptchaHandler.Status SUC  // 0x0
  public    static  U8.SDK.SDKCaptchaHandler.Status SYS_BUSY  // 0x0
  public    static  U8.SDK.SDKCaptchaHandler.Status USER_CANCEL  // 0x0
  public    static  U8.SDK.SDKCaptchaHandler.Status NOT_SUPPORT  // 0x0
  public    static  U8.SDK.SDKCaptchaHandler.Status INVALID_PARAM  // 0x0
  public    static  U8.SDK.SDKCaptchaHandler.Status UNKNOWN  // 0x0
METHODS:
END_CLASS

CLASS: Result
TYPE:  class
TOKEN: 0x2000008
FIELDS:
  private           U8.SDK.SDKCaptchaHandler.Status <status>k__BackingField  // 0x10
  private           System.Int32                    <errorCode>k__BackingField  // 0x14
  private           System.String                   <captcha>k__BackingField  // 0x18
METHODS:
  U8.SDK.SDKCaptchaHandler.Status get_status()
  System.Void set_status(U8.SDK.SDKCaptchaHandler.Status value)
  System.Int32 get_errorCode()
  System.Void set_errorCode(System.Int32 value)
  System.String get_captcha()
  System.Void set_captcha(System.String value)
  System.Void .ctor()
  U8.SDK.SDKCaptchaHandler.Result CreateForOutput()
  System.Void MarkSucceed(System.String captcha)
  System.Void MarkFailed(U8.SDK.SDKCaptchaHandler.Status status, System.Int32 errorCode)
  System.Void MarkFailed(U8.SDK.SDKCaptchaHandler.Status status)
END_CLASS

CLASS: IFromJSON
TYPE:  interface
TOKEN: 0x200000A
FIELDS:
METHODS:
  System.Boolean LoadFromJSON(System.String json)
END_CLASS

CLASS: POSTStatus
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  U8.SDK.SDKExternalTools.POSTStatusNONE  // 0x0
  public    static  U8.SDK.SDKExternalTools.POSTStatusSUC  // 0x0
  public    static  U8.SDK.SDKExternalTools.POSTStatusTIMEOUT  // 0x0
  public    static  U8.SDK.SDKExternalTools.POSTStatusERROR  // 0x0
METHODS:
END_CLASS

CLASS: BusType
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  U8.SDK.SDKExternalTools.BusType NONE  // 0x0
  public    static  U8.SDK.SDKExternalTools.BusType GET_TOKEN  // 0x0
  public    static  U8.SDK.SDKExternalTools.BusType GET_CAPTCHA  // 0x0
  public    static  U8.SDK.SDKExternalTools.BusType CREATE_ORDER  // 0x0
  public    static  U8.SDK.SDKExternalTools.BusType CONFIRM_ORDER  // 0x0
  public    static  U8.SDK.SDKExternalTools.BusType VERIFY_ACCOUNT  // 0x0
  public    static  U8.SDK.SDKExternalTools.BusType GET_PRODUCT_LIST  // 0x0
  public    static  U8.SDK.SDKExternalTools.BusType AUTHV2_SESSION_TOKEN  // 0x0
  public    static  U8.SDK.SDKExternalTools.BusType AUTHV2_OAUTH2CODE  // 0x0
  public    static  U8.SDK.SDKExternalTools.BusType AUTHV2_OAUTH2TOKEN  // 0x0
  public    static  U8.SDK.SDKExternalTools.BusType SERVER_LIST  // 0x0
  public    static  U8.SDK.SDKExternalTools.BusType CONFIRM_SERVER  // 0x0
METHODS:
END_CLASS

CLASS: ErrorType
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  U8.SDK.SDKExternalTools.ErrorTypeNONE  // 0x0
  public    static  U8.SDK.SDKExternalTools.ErrorTypeTIMEOUT  // 0x0
  public    static  U8.SDK.SDKExternalTools.ErrorTypeNETWORK_ERROR  // 0x0
  public    static  U8.SDK.SDKExternalTools.ErrorTypeDESERIALIZE_FAILED  // 0x0
  public    static  U8.SDK.SDKExternalTools.ErrorTypeBUSINESS_ERROR  // 0x0
METHODS:
END_CLASS

CLASS: POSTRequest
TYPE:  struct
TOKEN: 0x200000E
FIELDS:
  public            System.String                   url  // 0x10
  public            System.String                   body  // 0x18
  public            System.String                   contentType  // 0x20
  public            System.Collections.Generic.Dictionary<System.String,System.String>nullableHeaders  // 0x28
METHODS:
END_CLASS

CLASS: POSTResult
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  public            U8.SDK.SDKExternalTools.POSTStatusstatus  // 0x10
  public            System.Int32                    httpCode  // 0x14
  public            System.String                   response  // 0x18
  public            System.String                   error  // 0x20
METHODS:
  System.Boolean ServiceFailed()
END_CLASS

CLASS: ErrMsgMeta
TYPE:  struct
TOKEN: 0x2000010
FIELDS:
  public    static readonly U8.SDK.SDKExternalTools.ErrMsgMetaEMPTY  // 0x0
  public            U8.SDK.SDKExternalTools.BusType busType  // 0x10
  public            U8.SDK.SDKExternalTools.ErrorTypeerrorType  // 0x14
  public            System.Int32                    errorCode  // 0x18
  public            System.String                   alertFromServer  // 0x20
  public            System.Object                   meta  // 0x28
METHODS:
  System.Boolean IsEmpty()
  U8.SDK.SDKExternalTools.ErrMsgMeta FromPOSTResult(U8.SDK.SDKExternalTools.BusType busType, U8.SDK.SDKExternalTools.POSTResult postRet)
  System.Void .cctor()
END_CLASS

CLASS: CaptchaMgr
TYPE:  class
TOKEN: 0x2000011
FIELDS:
  private           U8.SDK.SDKExternalTools         m_host  // 0x10
  private           U8.SDK.SDKCaptchaHandler        <activeHandler>k__BackingField  // 0x18
METHODS:
  U8.SDK.SDKCaptchaHandler get_activeHandler()
  System.Void set_activeHandler(U8.SDK.SDKCaptchaHandler value)
  System.Void .ctor(U8.SDK.SDKExternalTools host)
  System.Collections.IEnumerator FetchCaptchaCoroutine(System.Collections.Generic.Dictionary<System.String,System.Object> captchaParams, U8.SDK.SDKCaptchaHandler.Result outResult)
END_CLASS

CLASS: Builder
TYPE:  struct
TOKEN: 0x2000014
FIELDS:
  public            U8.SDK.SDKExternalTools.POSTRequestrequest  // 0x10
  public            U8.SDK.SDKExternalTools.BusType busType  // 0x30
METHODS:
  U8.SDK.SDKExternalTools.POSTProcedure Build()
  U8.SDK.SDKExternalTools.POSTProcedure<TResp> TypedBuild()
END_CLASS

CLASS: POSTProcedure
TYPE:  class
TOKEN: 0x2000013
FIELDS:
  private           U8.SDK.SDKExternalTools.POSTProcedure.Builder<builder>k__BackingField  // 0x10
  private           System.Boolean                  <isServiceFinished>k__BackingField  // 0x38
  private           U8.SDK.SDKExternalTools.ErrMsgMeta<serviceError>k__BackingField  // 0x40
  private           System.String                   <rawResponse>k__BackingField  // 0x60
METHODS:
  U8.SDK.SDKExternalTools.POSTProcedure.Builder get_builder()
  System.Void set_builder(U8.SDK.SDKExternalTools.POSTProcedure.Builder value)
  System.Boolean get_isServiceFinished()
  System.Void set_isServiceFinished(System.Boolean value)
  U8.SDK.SDKExternalTools.ErrMsgMeta get_serviceError()
  System.Void set_serviceError(U8.SDK.SDKExternalTools.ErrMsgMeta value)
  System.String get_rawResponse()
  System.Void set_rawResponse(System.String value)
  U8.SDK.SDKExternalTools.ErrMsgMeta MakeBusinessError(System.Int32 errorCode)
  System.Collections.IEnumerator POST(U8.SDK.SDKExternalTools host)
  System.Void _OnServiceFinished(U8.SDK.SDKExternalTools.POSTResult postRet)
  System.Void HandleServiceResponse(U8.SDK.SDKExternalTools.POSTResult postRet)
  System.Void .ctor()
END_CLASS

CLASS: POSTProcedure`1
TYPE:  class
TOKEN: 0x2000016
EXTENDS: POSTProcedure
FIELDS:
  private           TResp                           <response>k__BackingField  // 0x0
METHODS:
  TResp get_response()
  System.Void set_response(TResp value)
  System.Void HandleServiceResponse(U8.SDK.SDKExternalTools.POSTResult postRet)
  System.Void .ctor()
END_CLASS

CLASS: AuthV2SessionTokenResp
TYPE:  class
TOKEN: 0x2000017
FIELDS:
  public            System.Int32                    status  // 0x10
  public            System.String                   msg  // 0x18
  public            System.String                   type  // 0x20
  public            System.String                   token  // 0x28
  public            System.String                   uid  // 0x30
  public            System.Boolean                  isNew  // 0x38
METHODS:
  System.Boolean LoadFromJSON(System.String json)
  System.Void .ctor()
END_CLASS

CLASS: GetProductLsitResp
TYPE:  class
TOKEN: 0x2000018
FIELDS:
  public            System.Int32                    flag  // 0x10
  public            System.Collections.Generic.Dictionary<System.String,System.Object>desc  // 0x18
METHODS:
  System.Boolean LoadFromDictionary(System.Collections.Generic.Dictionary<System.String,System.Object> dict)
  System.Boolean LoadFromJSON(System.String json)
  System.Void .ctor()
END_CLASS

CLASS: AuthV2GrantResp
TYPE:  class
TOKEN: 0x2000019
FIELDS:
  public            System.Int32                    status  // 0x10
  public            System.String                   msg  // 0x18
  public            System.String                   type  // 0x20
  public            System.String                   uid  // 0x28
  public            System.String                   code  // 0x30
  public            System.String                   token  // 0x38
  public            System.Int64                    banStartTs  // 0x40
  public            System.Int64                    banEndTs  // 0x48
  public            System.Int64                    maintainStartTs  // 0x50
  public            System.Int64                    maintainEndTs  // 0x58
  public            System.Collections.Generic.Dictionary<System.String,System.Object>captcha  // 0x60
METHODS:
  System.Boolean LoadFromJSON(System.String json)
  System.Void .ctor()
END_CLASS

CLASS: ServerData
TYPE:  struct
TOKEN: 0x200001B
FIELDS:
  public            System.String                   serverId  // 0x10
  public            System.String                   serverName  // 0x18
  public            System.String                   serverDomain  // 0x20
  public            System.Boolean                  defaultChoose  // 0x28
  public            System.String                   roleId  // 0x30
  public            System.String                   nickName  // 0x38
  public            System.Int64                    level  // 0x40
  public            System.String                   extension  // 0x48
METHODS:
END_CLASS

CLASS: ServerListResp
TYPE:  class
TOKEN: 0x200001A
FIELDS:
  public            System.Int32                    status  // 0x10
  public            System.String                   msg  // 0x18
  public            System.Collections.Generic.List<U8.SDK.SDKExternalTools.ServerListResp.ServerData>data  // 0x20
METHODS:
  System.Boolean LoadFromJSON(System.String json)
  System.Collections.Generic.List<U8.SDK.U8ServerInfo> ToServerInfo()
  System.Void .ctor()
END_CLASS

CLASS: ConfirmServerResp
TYPE:  class
TOKEN: 0x200001C
FIELDS:
  public    static  System.Int32                    SERVER_NOT_EXIST  // 0x0
  public    static  System.Int32                    ACCOUNT_NOT_EXIST  // 0x0
  public            System.Int32                    status  // 0x10
  public            System.String                   msg  // 0x18
METHODS:
  System.Boolean LoadFromJSON(System.String json)
  System.Void .ctor()
END_CLASS

CLASS: ConfirmOrderU1Resp
TYPE:  class
TOKEN: 0x200001D
FIELDS:
  public    static  System.Int32                    STATUS_ORDER_NOT_EXIST  // 0x0
  public    static  System.Int32                    STATUS_THIRD_PARTY_PENDING  // 0x0
  public    static  System.Int32                    STATUS_GAME_SERVER_PENDING  // 0x0
  public            System.Int32                    status  // 0x10
METHODS:
  System.Boolean LoadFromJSON(System.String json)
  System.Void .ctor()
END_CLASS

CLASS: Data
TYPE:  struct
TOKEN: 0x200001F
FIELDS:
  public            System.String                   orderId  // 0x10
  public            System.String                   channelProductCode  // 0x18
  public            System.String                   productName  // 0x20
  public            System.String                   productDesc  // 0x28
  public            System.Int64                    amount  // 0x30
  public            System.Collections.Generic.Dictionary<System.String,System.Object>extension  // 0x38
METHODS:
END_CLASS

CLASS: CreateOrderU1Resp
TYPE:  class
TOKEN: 0x200001E
FIELDS:
  public            System.Int32                    status  // 0x10
  public            System.String                   msg  // 0x18
  public            System.String                   type  // 0x20
  public            U8.SDK.SDKExternalTools.CreateOrderU1Resp.Datadata  // 0x28
METHODS:
  System.Boolean LoadFromJSON(System.String json)
  U8.SDK.U8OrderInfo ToOrderInfo()
  System.Void .ctor()
END_CLASS

CLASS: U8ProductListData
TYPE:  struct
TOKEN: 0x200002E
FIELDS:
  public            System.Collections.Generic.List<U8.SDK.U8ProductInfo>productList  // 0x10
METHODS:
  System.Boolean LoadFromJSON(System.String json)
  System.Boolean _BuildProductInfo(U8.SDK.U8ProductInfo outInfo, System.Collections.Generic.Dictionary<System.String,System.Object> dict)
END_CLASS

CLASS: U8ProductListDataV2
TYPE:  struct
TOKEN: 0x200002F
FIELDS:
  public            System.Collections.Generic.List<U8.SDK.U8ProductInfo>productList  // 0x10
METHODS:
  System.Boolean LoadFromJSON(System.String json)
  System.Boolean _BuildProductInfo(U8.SDK.U8ProductInfo outInfo, System.Collections.Generic.Dictionary<System.String,System.Object> dict)
END_CLASS

CLASS: U8UpdateGuestResponse
TYPE:  struct
TOKEN: 0x2000030
FIELDS:
  public            System.Int32                    result  // 0x10
METHODS:
  System.Boolean LoadFromJSON(System.String json)
END_CLASS

CLASS: U8VerifyAccountResponse
TYPE:  struct
TOKEN: 0x2000031
FIELDS:
  public            System.String                   uid  // 0x10
METHODS:
  System.Boolean LoadFromJSON(System.String json)
END_CLASS

CLASS: U8GetCaptchaResponse
TYPE:  struct
TOKEN: 0x2000032
FIELDS:
  public            System.Int32                    result  // 0x10
  public            System.Collections.Generic.Dictionary<System.String,System.Object>data  // 0x18
METHODS:
  System.Boolean LoadFromJSON(System.String json)
END_CLASS

CLASS: U8AuthResponse
TYPE:  struct
TOKEN: 0x2000033
FIELDS:
  public            System.Int32                    result  // 0x10
  public            System.String                   uid  // 0x18
  public            System.String                   channelUid  // 0x20
  public            System.String                   token  // 0x28
  public            System.String                   extension  // 0x30
  public            System.Boolean                  isGuest  // 0x38
  public            System.String                   error  // 0x40
  public            System.String                   captchaTips  // 0x48
  public            System.Boolean                  isNew  // 0x50
  public            System.Collections.Generic.Dictionary<System.String,System.Object>captcha  // 0x58
METHODS:
  System.Boolean LoadFromJSON(System.String json)
  U8.SDK.U8LoginResult ToLoginResult()
END_CLASS

CLASS: U8PayConfirmResponse
TYPE:  struct
TOKEN: 0x2000034
FIELDS:
  public            System.Int32                    payState  // 0x10
METHODS:
  System.Boolean LoadFromJSON(System.String json)
END_CLASS

CLASS: RequestConnPolicy
TYPE:  struct
TOKEN: 0x2000035
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  U8.SDK.SDKExternalToolsShortcut.RequestConnPolicyDEFAULT  // 0x0
  public    static  U8.SDK.SDKExternalToolsShortcut.RequestConnPolicyCLOSE_EACH_CON  // 0x0
METHODS:
END_CLASS

CLASS: RequestHeaderInjectOptions
TYPE:  struct
TOKEN: 0x2000036
FIELDS:
  public            U8.SDK.SDKExternalToolsShortcut.RequestConnPolicypolicy  // 0x10
METHODS:
END_CLASS

CLASS: AuthStatus
TYPE:  struct
TOKEN: 0x2000040
FIELDS:
  public    static readonly U8.SDK.U8SDKInterface.AuthStatusEMPTY  // 0x0
  public            System.String                   uid  // 0x10
  public            System.String                   oauth2code  // 0x18
  public            System.String                   oauth2token  // 0x20
  public            System.String                   sessionToken  // 0x28
METHODS:
  System.Boolean IsEmpty()
  System.Void .cctor()
END_CLASS

CLASS: V2LoginStatus
TYPE:  struct
TOKEN: 0x2000041
FIELDS:
  public            System.String                   sessionToken  // 0x10
METHODS:
END_CLASS

CLASS: ReceiverProductListResult
TYPE:  class
TOKEN: 0x2000042
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Collections.Generic.Dictionary<System.String,System.Object> msg)
  System.IAsyncResult BeginInvoke(System.Collections.Generic.Dictionary<System.String,System.Object> msg, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: GameServerTimeCache
TYPE:  struct
TOKEN: 0x2000043
FIELDS:
  public            System.Int64                    cacheTime  // 0x10
  public            System.Int64                    maintainEndTs  // 0x18
  public            System.Int64                    maintainStartTs  // 0x20
METHODS:
END_CLASS

CLASS: DataCallback
TYPE:  class
TOKEN: 0x2000072
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Int32 index, System.String paramValue)
  System.IAsyncResult BeginInvoke(System.Int32 index, System.String paramValue, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: U8SDKSendMessageCallback
TYPE:  class
TOKEN: 0x2000073
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.String methodName, System.String paramValue)
  System.IAsyncResult BeginInvoke(System.String methodName, System.String paramValue, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: State
TYPE:  struct
TOKEN: 0x200007C
FIELDS:
  public            System.Int32                    value__  // 0x0
  public    static  U8.SDK.SDKPromiseEnumerator.State<T>NONE  // 0x0
  public    static  U8.SDK.SDKPromiseEnumerator.State<T>FULFILL  // 0x0
  public    static  U8.SDK.SDKPromiseEnumerator.State<T>REJECT  // 0x0
METHODS:
END_CLASS

CLASS: TOKEN
TYPE:  struct
TOKEN: 0x2000089
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  U8.SDK.MiniJSON.Json.Parser.TOKENNONE  // 0x0
  public    static  U8.SDK.MiniJSON.Json.Parser.TOKENCURLY_OPEN  // 0x0
  public    static  U8.SDK.MiniJSON.Json.Parser.TOKENCURLY_CLOSE  // 0x0
  public    static  U8.SDK.MiniJSON.Json.Parser.TOKENSQUARED_OPEN  // 0x0
  public    static  U8.SDK.MiniJSON.Json.Parser.TOKENSQUARED_CLOSE  // 0x0
  public    static  U8.SDK.MiniJSON.Json.Parser.TOKENCOLON  // 0x0
  public    static  U8.SDK.MiniJSON.Json.Parser.TOKENCOMMA  // 0x0
  public    static  U8.SDK.MiniJSON.Json.Parser.TOKENSTRING  // 0x0
  public    static  U8.SDK.MiniJSON.Json.Parser.TOKENNUMBER  // 0x0
  public    static  U8.SDK.MiniJSON.Json.Parser.TOKENTRUE  // 0x0
  public    static  U8.SDK.MiniJSON.Json.Parser.TOKENFALSE  // 0x0
  public    static  U8.SDK.MiniJSON.Json.Parser.TOKENNULL  // 0x0
METHODS:
END_CLASS

CLASS: Parser
TYPE:  class
TOKEN: 0x2000088
FIELDS:
  private   static  System.String                   WORD_BREAK  // 0x0
  private           System.IO.StringReader          json  // 0x10
METHODS:
  System.Boolean IsWordBreak(System.Char c)
  System.Void .ctor(System.String jsonString)
  System.Object Parse(System.String jsonString)
  System.Void Dispose()
  System.Collections.Generic.Dictionary<System.String,System.Object> ParseObject()
  System.Collections.Generic.List<System.Object> ParseArray()
  System.Object ParseValue()
  System.Object ParseByToken(U8.SDK.MiniJSON.Json.Parser.TOKEN token)
  System.String ParseString()
  System.Object ParseNumber()
  System.Void EatWhitespace()
  System.Char get_PeekChar()
  System.Char get_NextChar()
  System.String get_NextWord()
  U8.SDK.MiniJSON.Json.Parser.TOKEN get_NextToken()
END_CLASS

CLASS: Serializer
TYPE:  class
TOKEN: 0x200008A
FIELDS:
  private           System.Text.StringBuilder       builder  // 0x10
METHODS:
  System.Void .ctor()
  System.String Serialize(System.Object obj)
  System.Void SerializeValue(System.Object value)
  System.Void SerializeObject(System.Collections.IDictionary obj)
  System.Void SerializeArray(System.Collections.IList anArray)
  System.Void SerializeString(System.String str)
  System.Void SerializeOther(System.Object value)
END_CLASS

CLASS: __StaticArrayInitTypeSize=24
TYPE:  struct
TOKEN: 0x2000091
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=72
TYPE:  struct
TOKEN: 0x2000092
FIELDS:
METHODS:
END_CLASS

CLASS: Hypergryph.PlatformFacade.PSNAuthResultStatus
TYPE:  struct
TOKEN: 0x200008B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Hypergryph.PlatformFacade.PSNAuthResultStatusSuccess  // 0x0
  public    static  Hypergryph.PlatformFacade.PSNAuthResultStatusFailed  // 0x0
METHODS:
END_CLASS

CLASS: Hypergryph.PlatformFacade.PSNAuthInfo
TYPE:  struct
TOKEN: 0x200008C
FIELDS:
  public            Hypergryph.PlatformFacade.PSNAuthResultStatusstatus  // 0x10
  public            System.String                   psnAuthCode  // 0x18
  public            System.String                   psnEnv  // 0x20
METHODS:
END_CLASS

CLASS: Hypergryph.PlatformFacade.PlatformFacade
TYPE:  class
TOKEN: 0x200008D
FIELDS:
METHODS:
  System.Void SetupPlatformFont(Hypergryph.PlatformFacade.IPlatformFont iFont)
  System.Threading.Tasks.Task<Hypergryph.PlatformFacade.PSNAuthInfo> GetPSNAuthInfo()
  System.Void .ctor()
END_CLASS

CLASS: Hypergryph.PlatformFacade.IPlatformFont
TYPE:  interface
TOKEN: 0x200008F
FIELDS:
METHODS:
  TMPro.TMP_FontAsset GetFont()
END_CLASS

CLASS: U8.SDK.ExternalPluginLoginParams
TYPE:  struct
TOKEN: 0x2000002
FIELDS:
  public            System.Action                   nativeLogin  // 0x10
  public            System.Action<System.String>    nativeLoginCustom  // 0x18
  public            System.Action<System.String>    nativeOnLoginSuc  // 0x20
  public            System.Action<System.String>    nativeOnLoginFail  // 0x28
  public            System.Action<U8.SDK.U8MockLogin>markMockLogin  // 0x30
METHODS:
END_CLASS

CLASS: U8.SDK.ExternalPluginLogoutParams
TYPE:  struct
TOKEN: 0x2000003
FIELDS:
  public            System.Action                   nativeLogout  // 0x10
  public            System.Action                   nativeOnLogoutSuc  // 0x18
  public            System.Action                   nativeOnLogoutFail  // 0x20
METHODS:
END_CLASS

CLASS: U8.SDK.ExternalPluginPayParams
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  public            U8.SDK.U8PayParams              payParams  // 0x10
  public            System.Func<U8.SDK.U8PayParams,U8.SDK.SDKPromise<U8.SDK.U8PayResult>>nativePay  // 0x18
  public            System.Action<U8.SDK.U8PayResult>onPaySuc  // 0x20
  public            System.Action<System.Object>    onPayFail  // 0x28
METHODS:
END_CLASS

CLASS: U8.SDK.IExternalPlugin
TYPE:  interface
TOKEN: 0x2000005
FIELDS:
METHODS:
  System.Void Init()
  System.Void Login(U8.SDK.ExternalPluginLoginParams args)
  System.Void Pay(U8.SDK.ExternalPluginPayParams args)
  System.Void Logout(U8.SDK.ExternalPluginLogoutParams args)
  System.String GetSDKToken()
  System.String GetSDKUid()
  System.Boolean TryLoadSDKMeta(System.Func<U8.SDK.SDKMeta> loadMetaNative, U8.SDK.SDKMeta& meta)
  System.Void OnProductListChanged(System.Collections.Generic.List<U8.SDK.U8ProductInfo> productList)
  System.String GetPayAddition()
END_CLASS

CLASS: U8.SDK.SDKCaptchaHandler
TYPE:  class
TOKEN: 0x2000006
FIELDS:
METHODS:
  System.Collections.IEnumerator FetchCaptchaCoroutine(System.String captchaParams, U8.SDK.SDKCaptchaHandler.Result outResult)
  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.SDKExternalTools
TYPE:  class
TOKEN: 0x2000009
FIELDS:
  private   static readonly System.Char[]                   RANDOM_CHAR_MAP  // 0x0
  protected static  System.String                   CONTENT_TYPE_JSON  // 0x0
  protected static readonly System.Int32[]                  PAY_CONFIRM_RETRY_INTERVALS  // 0x8
  private   static  U8.SDK.SDKExternalTools         s_instance  // 0x10
  private   static  U8.SDK.IExternalPlugin          s_plugin  // 0x18
  private           System.Boolean                  <inited>k__BackingField  // 0x10
  private           U8.SDK.SDKExternalTools.CaptchaMgr<captchaMgr>k__BackingField  // 0x18
  private           System.String                   <subChannel>k__BackingField  // 0x20
  protected static  System.String                   AUTHV2_SESSION_TOKEN_PATH  // 0x0
  protected static  System.String                   AUTHV2_GRANT_PATH  // 0x0
  protected static  System.String                   GAME_SERVER_LIST  // 0x0
  protected static  System.String                   GAME_CONFIRM_SERVER  // 0x0
  protected static  System.String                   ORDERV1_CHECK_PATH  // 0x0
  protected static  System.String                   ORDERV1_CONFIRM_PATH  // 0x0
  protected static  System.String                   ORDERV1_CREATE_PATH  // 0x0
  public    static  System.Int32                    GRANT_TYPE_OAUTH2CODE  // 0x0
  private   static  System.Int32                    U8_SDK_SET_DATA_SET_SERVER  // 0x20
METHODS:
  System.Boolean get_inited()
  System.Void set_inited(System.Boolean value)
  U8.SDK.IExternalPlugin get_plugin()
  U8.SDK.SDKExternalTools.CaptchaMgr get_captchaMgr()
  System.Void set_captchaMgr(U8.SDK.SDKExternalTools.CaptchaMgr value)
  System.String get_subChannel()
  System.Void set_subChannel(System.String value)
  System.Boolean SDKInterfaceInitExternalTools()
  U8.SDK.SDKExternalTools GetInstance()
  System.Boolean HasInstance()
  System.String PublicServiceSignKey()
  U8.SDK.SDKPromise<U8.SDK.U8LoginResult> SDKInterfaceSDKAuth(System.String extension, System.String captcha)
  U8.SDK.SDKPromise<U8.SDK.U8CaptchaResult> SDKInterfaceGetCaptcha()
  U8.SDK.SDKPromise<System.Object> SDKInterfaceVerifyAccount(System.String uid, System.String token)
  U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ProductInfo>> SDKInterfaceGetProductList(System.Int32 worldId)
  U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ProductInfo>> SDKInterfaceProductListV2()
  System.Void NotifyProductListUpdated(System.Collections.Generic.List<U8.SDK.U8ProductInfo> productList)
  U8.SDK.SDKPromise<U8.SDK.U8ConfirmOrderResult> SDKLegacyConfirmOrder(System.String uid, System.String orderId, System.String extension)
  U8.SDK.SDKPromise<System.Object> SDKInterfaceUpgradeGuest(System.String targetUid, System.String guestExt, System.String accountExt)
  System.String SDKInterfaceSDKToken()
  System.String SDKInterfaceSDKUid()
  System.String MakeHttpPostParam(System.Collections.Generic.Dictionary<System.String,System.Object> param)
  System.String MakeHttpGetParam(System.Collections.Generic.Dictionary<System.String,System.String> param)
  System.Void LoginWithPlugin(System.Action nativeLogin, System.Action<System.String> nativeLoginCustom, System.Action<U8.SDK.U8MockLogin> markMockLogin)
  System.Void LogoutWithPlugin(System.Action nativeLogout)
  System.Void SDKInterfacePayWithPlugin(U8.SDK.U8PayParams payParams, System.Func<U8.SDK.U8PayParams,U8.SDK.SDKPromise<U8.SDK.U8PayResult>> nativePay, System.Action<U8.SDK.U8PayResult> onSuc, System.Action<System.Object> onFail)
  System.String SDKInterfaceGetPayAddition()
  System.Void StaticLog(System.String content)
  System.Void StaticLogWarning(System.String content)
  System.Void StaticLogError(System.String content)
  System.Void RegisterPlugin(U8.SDK.IExternalPlugin plugin)
  System.Void UnregisterPlugin(U8.SDK.IExternalPlugin plugin)
  System.String GenerateRandomString(System.Int32 min, System.Int32 max)
  T GetValueSafe(System.Collections.Generic.Dictionary<System.String,System.Object> dict, System.String key, T defVal)
  System.String U8Url(System.String routeUrl)
  System.String U8urlWithoutU8(System.String routeUrl)
  U8.SDK.SDKExternalTools.ErrMsgMeta HandleResponseFromU8(U8.SDK.SDKExternalTools.BusType busType, U8.SDK.SDKExternalTools.POSTResult postRet, TResp& resp)
  System.Collections.Generic.Dictionary<System.String,System.Object> FromMiniJSON(System.String json)
  System.Collections.Generic.List<System.Object> FromMiniJSONArray(System.String data)
  System.Void InternalInvokeCoroutine(System.Collections.IEnumerator coroutine)
  System.Void InternalInvokeNextFrame(System.Action action)
  System.Collections.IEnumerator _NextFrameCoroutine(System.Action action)
  System.Void InitIfNot()
  System.Void Init()
  System.Void SwitchAccount()
  System.Void OnSDKError(U8.SDK.SDKError error)
  System.Void OnInvalidProduct(System.Int32 storeId)
  System.Void OnSDKExtraInfo(System.String jsonData)
  U8.SDK.SDKMeta LoadSDKMetaFromPlugin(System.Func<U8.SDK.SDKMeta> nativeLoadMeta)
  U8.SDK.SDKCaptchaHandler CreateCaptchaHandler()
  System.String GetSignKey()
  System.Collections.Generic.Dictionary<System.String,System.String> GetDeviceIDs()
  U8.SDK.SDKPromise<U8.SDK.U8LoginResult> SendSDKAuthRequest(System.String paramStr)
  U8.SDK.SDKPromise<U8.SDK.U8CaptchaResult> SendSDKGetCaptchaRequest(System.String paramStr)
  U8.SDK.SDKPromise<System.Object> SendSDKVerifyAccountRequest(System.String paramStr)
  U8.SDK.SDKPromise<U8.SDK.U8ConfirmOrderResult> SendConfirmOrderRequest(System.String paramStr)
  U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ProductInfo>> SendGetProductListRequest(System.String paramStr)
  U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ProductInfo>> SendGetProductListRequestV2(System.String paramStr)
  U8.SDK.SDKPromise<System.Object> SendUpgradeGuestRequest(System.String paramStr)
  System.Int32 GetPlatformKey()
  System.Void POSTImplementation(U8.SDK.SDKExternalTools.POSTRequest request, System.Action<U8.SDK.SDKExternalTools.POSTResult> callback)
  System.String U8RootUrl()
  System.String GetErrorMessage(U8.SDK.SDKExternalTools.ErrMsgMeta meta)
  System.Void Log(System.String content)
  System.Void LogWarning(System.String content)
  System.Void LogError(System.String content)
  System.Boolean _ValidatePlugin()
  System.String _MakeAuthParam(U8.SDK.SDKMeta meta, System.String extension, System.String captcha)
  System.String _MakeGetCaptchaParam(U8.SDK.SDKMeta meta)
  System.String _MakeVerifyAccountParam(System.String uid, System.String token)
  System.String _MakeGetProductListParam(U8.SDK.SDKMeta meta, System.Int32 worldId)
  System.String _MakeGetProductListV2Param(U8.SDK.SDKMeta meta)
  System.String _MakeLegacyConfirmOrderParam(System.String uid, System.String orderId, System.String extension)
  System.String _MakeUpgradeGuestParam(System.String uid, System.String accountExt, System.String guestExt)
  System.String _SignRequest(System.Collections.Generic.Dictionary<System.String,System.Object> param)
  System.Void _AddDeviceIDsToRequest(System.Collections.Generic.Dictionary<System.String,System.Object> paramDict)
  System.Collections.IEnumerator SDKInterfaceAuthV2SessionToken(U8.SDK.SDKMeta meta, System.String channelToken, U8.SDK.SDKPromiseWithResult<U8.SDK.U8LoginV2Result> promise)
  System.Collections.IEnumerator SDKInterfaceAuthV2OAuth2Code(System.String sessionToken, U8.SDK.SDKPromiseWithResult<U8.SDK.U8GrantResult> promise, System.Action onSessionInvalid)
  U8.SDK.SDKPromise<U8.SDK.U8ConfirmOrderResult> SDKInterfaceConfirmOrderU1(System.String orderId, System.String extension)
  U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ServerInfo>> SDKInterFaceGetServerList(System.String sessionToken)
  U8.SDK.SDKPromise<U8.SDK.U8ConfirmServerResult> SDKInterFaceConfirmServer(System.String sessionToken, System.String serverId)
  U8.SDK.SDKPromise<U8.SDK.U8OrderInfo> SDKInterfaceCreateOrderU1(System.String sessionToken, System.String productId, System.String signParams)
  System.String _MakeGrantParam(System.String sessionToken, System.Int32 type, System.String captcha)
  System.Collections.IEnumerator _AuthV2GrantImpl(System.String sessionToken, U8.SDK.SDKPromiseWithResult<U8.SDK.U8GrantResult> promise, System.Action onSessionInvalid)
  System.String _MakeCheckOrderV1Param(System.String orderId, System.String extension)
  System.String _MakeConfirmOrderV1Param(System.String orderId)
  System.Collections.IEnumerator _ConfirmOrderU1Coroutine(System.String orderId, System.String extension, U8.SDK.SDKPromise<U8.SDK.U8ConfirmOrderResult> promise)
  System.Collections.IEnumerator _PollOrderStatusCoroutine(System.String orderId, System.String extension, U8.SDK.SDKPromise<U8.SDK.U8ConfirmOrderResult> promise)
  System.Collections.IEnumerator _GetServerListCoroutine(System.String paramStr, U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ServerInfo>> promise)
  System.Collections.IEnumerator _ConfirmServerListCoroutine(System.String paramStr, System.String serverId, U8.SDK.SDKPromise<U8.SDK.U8ConfirmServerResult> promise)
  System.Collections.IEnumerator _SendCreateOrderU1Coroutine(System.String paramStr, U8.SDK.SDKPromise<U8.SDK.U8OrderInfo> promise)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: U8.SDK.DataConsts
TYPE:  class
TOKEN: 0x200002A
FIELDS:
  public    static  System.Int32                    U8_MSG_TYPE_GAME_VERSION_UPGRADE  // 0x0
  public    static  System.Int32                    U8_MSG_TYPE_IF_MTP_ENABLED  // 0x0
  public    static  System.Int32                    U8_MSG_TYPE_DEVICE_ID  // 0x0
  public    static  System.Int32                    U8_MSG_TYPE_TRACKINGIO_DEVICE_ID  // 0x0
  public    static  System.Int32                    U8_MSG_TYPE_OVER_GAME_VERSION_UPGRADE  // 0x0
  public    static  System.Int32                    U8_MSG_TYPE_INIT_LICENSE  // 0x0
  public    static  System.Int32                    U8_SET_DATA_APPETIZER  // 0x0
  public    static  System.Int32                    U8_SET_DATA_GUEST_CAPTCHA  // 0x0
  public    static  System.Int32                    U8_SET_DATA_BI_U8_LOGIN  // 0x0
  public    static  System.Int32                    U8_SET_DATA_BI_GS_LOGIN  // 0x0
  public    static  System.Int32                    U8_SET_DATA_BI_START_GAME  // 0x0
  public    static  System.Int32                    U8_SET_DATA_BI_STOP_GAME  // 0x0
  public    static  System.Int32                    U8_SET_DATA_BI_INIT  // 0x0
  public    static  System.Int32                    U8_SET_DATA_TRACKINGIO_SET  // 0x0
  public    static  System.Int32                    U8_SET_DATA_CLIP_BOARD  // 0x0
  public    static  System.Int32                    U8_SET_DATA_WEIBO_ROLE  // 0x0
  public    static  System.Int32                    U8_SET_DATA_BAIDU_ROLE  // 0x0
  public    static  System.Int32                    U8_SET_DATA_BAIDU_PAY  // 0x0
  public    static  System.Int32                    U8_SET_DATA_NEWLENS_INIT  // 0x0
  public    static  System.Int32                    U8_SET_DATA_NEWLENS_ID  // 0x0
  public    static  System.Int32                    U8_SET_DATA_CLOUD_AUTH  // 0x0
  public    static  System.Int32                    U8_SET_DATA_INIT_CLOUD_AUTH  // 0x0
  public    static  System.Int32                    U8_SET_DATA_TOUTIAO_LOGIN  // 0x0
  public    static  System.Int32                    U8_SET_DATA_TOUTIAO_ROLE  // 0x0
  public    static  System.Int32                    U8_SET_DATA_TOUTIAO_PAY  // 0x0
  public    static  System.Int32                    U8_SET_DATA_TOUTIAO_LOGOUT  // 0x0
  public    static  System.Int32                    U8_SET_DATA_UNBIND_GRANT  // 0x0
  public    static  System.Int32                    U8_SET_DATA_INIT_LICENSE  // 0x0
  public    static  System.Int32                    U8_SET_DATA_INIT_HGSDK  // 0x0
METHODS:
END_CLASS

CLASS: U8.SDK.U8ErrorCode
TYPE:  class
TOKEN: 0x200002B
FIELDS:
  public    static  System.Int32                    DESERIALIZE_ERROR_CODE  // 0x0
  public    static  System.Int32                    CAPTCHA_ERROR_BASE  // 0x0
  public    static  System.Int32                    AUTH_PARSE_DATA_FAILED  // 0x0
  public    static  System.Int32                    VERIFY_ACCOUNT_UID_EMPTY  // 0x0
  public    static  System.Int32                    AUTHV2_SESSION_EMPTY  // 0x0
METHODS:
END_CLASS

CLASS: U8.SDK.SDKExtraData
TYPE:  struct
TOKEN: 0x200002C
FIELDS:
  public    static readonly U8.SDK.SDKExtraData             EMPTY  // 0x0
  public            System.Int32                    code  // 0x10
  public            System.Collections.Generic.Dictionary<System.String,System.Object>msg  // 0x18
METHODS:
  System.Boolean IsEmpty()
  U8.SDK.SDKExtraData FromJson(System.String jsonStr)
  System.Void .cctor()
END_CLASS

CLASS: U8.SDK.SDKExternalToolsShortcut
TYPE:  class
TOKEN: 0x200002D
EXTENDS: SDKExternalTools
FIELDS:
METHODS:
  U8.SDK.SDKPromise<U8.SDK.U8LoginResult> SendSDKAuthRequest(System.String paramStr)
  U8.SDK.SDKPromise<System.Object> SendSDKVerifyAccountRequest(System.String paramStr)
  U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ProductInfo>> SendGetProductListRequest(System.String paramStr)
  U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ProductInfo>> SendGetProductListRequestV2(System.String paramStr)
  U8.SDK.SDKPromise<System.Object> SendUpgradeGuestRequest(System.String paramStr)
  U8.SDK.SDKPromise<U8.SDK.U8CaptchaResult> SendSDKGetCaptchaRequest(System.String paramStr)
  U8.SDK.SDKPromise<U8.SDK.U8ConfirmOrderResult> SendConfirmOrderRequest(System.String paramStr)
  System.Collections.IEnumerator _ConfirmOrderCoroutine(U8.SDK.SDKPromise<U8.SDK.U8ConfirmOrderResult> promise, System.String paramStr)
  System.Collections.Generic.Dictionary<System.String,System.String> GetDeviceIDs()
  System.String GetU8DeviceID()
  System.Void InjectRequestHeaders(System.Collections.Generic.Dictionary<System.String,System.String>& headers, U8.SDK.SDKExternalToolsShortcut.RequestHeaderInjectOptions policy)
  System.String _AuthUrl()
  System.String _CaptchaUrl()
  System.String _GetProductListUrl()
  System.String _GetProductListV1Url()
  System.String _CreateOrderUrl()
  System.String _ConfirmOrderUrl()
  System.String _UpdateGuestUserUrl()
  System.String _VerifyAccountUrl()
  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.U8SDKInterface
TYPE:  class
TOKEN: 0x200003F
FIELDS:
  public    static  System.String                   KEYWORD_DISABLE  // 0x0
  private   static  System.String                   KEY_CACHED_UID  // 0x0
  private   static  U8.SDK.U8SDKInterface           m_instance  // 0x0
  protected         U8.SDK.SDKPromiseWrapper        m_initPromise  // 0x10
  protected         U8.SDK.SDKPromiseWrapper        m_loginPromise  // 0x18
  protected         U8.SDK.SDKPromiseWrapper        m_logoutPromise  // 0x20
  protected         U8.SDK.SDKPromiseWrapper        m_payPromise  // 0x28
  private           U8.SDK.U8LoginResult            m_loginResult  // 0x30
  private           U8.SDK.U8SDKInterface.AuthStatusm_authStatus  // 0x68
  private           System.String                   m_loginExtV1  // 0x88
  private           U8.SDK.U8MockLogin              m_mockLogin  // 0x90
  private           System.Collections.Generic.List<U8.SDK.U8ProductInfo>m_productList  // 0xA0
  private           System.Nullable<System.Boolean> m_isNativePlugin  // 0xA8
  private           U8.SDK.SDKMeta                  m_sdkMeta  // 0xB0
  private           U8.SDK.U8SDKInterface.V2LoginStatusm_loginStatusV2  // 0xB8
  private   static  System.Int32                    U8_SDK_SET_DATA_SET_SESSION_TOKEN  // 0x8
  private   static  System.Int32                    U8_SDK_SET_DATA_GET_PRODUCT_LIST  // 0xC
  private   static  U8.SDK.U8SDKInterface.ReceiverProductListResultonReceiverProductlist  // 0x10
  private           U8.SDK.U8SDKInterface.GameServerTimeCachem_gameServerTimeCache  // 0xC0
METHODS:
  U8.SDK.U8SDKInterface get_Instance()
  U8.SDK.SDKMeta _InternalSDKMeta()
  System.Boolean get_isNativePlugin()
  System.Void CallbackInitSuc(System.String extConfigs)
  System.Void CallbackInitFail(System.String info)
  System.Void CallbackLoginSuc(System.String extension)
  System.Void CallbackLoginFail(System.String info)
  System.Void CallbackLogout()
  System.Void CallbackSwitchAccount()
  System.Void CallbackPaySuc(System.String jsonData)
  System.Void CallbackPayFail(System.String failMsg)
  System.String get_uid()
  System.String get_channel()
  System.Int32 get_worldId()
  System.String get_cachedUid()
  System.Void set_cachedUid(System.String value)
  System.String get_token()
  System.String get_oauth2token()
  System.String get_oauth2code()
  System.Collections.Generic.List<U8.SDK.U8ProductInfo> get_productList()
  System.Boolean get_isInterfaceDisabled()
  System.String PublicLoadExtraConfig()
  U8.SDK.U8SDKInterface.ReceiverProductListResult getOnReceiverProductlist()
  U8.SDK.SDKPromise<System.String> PublicInit()
  U8.SDK.SDKPromise<System.String> V2PublicInit(System.String env)
  U8.SDK.SDKPromise<System.String> PublicLogin()
  System.Void _MarkMockLogin(U8.SDK.U8MockLogin mockLogin)
  U8.SDK.SDKPromise<U8.SDK.U8LoginResult> PublicAuth(System.String captcha)
  System.Void _onLoginSuc(System.String uid, System.Boolean isNew)
  U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ProductInfo>> PublicGetProductList()
  U8.SDK.SDKPromise<U8.SDK.U8ProductsResult> PublicGetProductListV2()
  U8.SDK.SDKPromise<U8.SDK.U8LoginResult> _DoMockLoginAuth()
  U8.SDK.SDKPromise<U8.SDK.U8CaptchaResult> PublicGetCaptcha()
  System.Void ClearAuthStatus()
  System.Void ClearLoginStatus()
  System.Void _ConfirmAuthResult(U8.SDK.U8SDKInterface.AuthStatus result)
  U8.SDK.SDKPromise<System.Object> PublicVerifyAuth()
  U8.SDK.SDKPromise<System.Object> _MockVerifyAccount()
  U8.SDK.SDKPromise<System.Object> PublicLogout()
  U8.SDK.SDKPromise<U8.SDK.U8OrderInfo> PublicCreateOrder(System.String productId, System.String signParams)
  U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ServerInfo>> PublicGetServerList()
  U8.SDK.SDKPromise<U8.SDK.U8ConfirmServerResult> PubliceConfirmServer(System.String serverId)
  U8.SDK.SDKPromise<U8.SDK.U8PayResult> PublicPay(System.Int32 storeId, U8.SDK.U8OrderInfo orderInfo)
  System.Void _OnNativePayFulfilled(System.Int64 revenue)
  U8.SDK.SDKPromise<U8.SDK.U8ConfirmOrderResult> PublicConfirmOrder(System.String orderId, System.String extension)
  U8.SDK.SDKPromise<System.Object> LegacyUpgradeGuest(System.String targetUid, System.String guestExt, System.String accountExt)
  System.String get_sdkUid()
  System.Boolean _TryGetProduct(System.Int32 storeId, U8.SDK.U8ProductInfo& productInfo)
  U8.SDK.U8PayParams _GeneratePayParams(U8.SDK.U8ProductInfo productInfo, U8.SDK.U8OrderInfo orderInfo)
  U8.SDK.SDKPromise<U8.SDK.U8PayResult> Test_NativePay()
  U8.SDK.SDKPromise<U8.SDK.U8PayResult> _NativePay(U8.SDK.U8PayParams payParams)
  T GetValueSafe(System.Collections.Generic.Dictionary<System.String,System.Object> dict, System.String key, T defVal)
  U8.SDK.SDKMeta PublicLoadSDKMeta()
  System.Boolean TryFindInfoByProductId(System.String productId, U8.SDK.U8ProductInfo& outInfo)
  System.String GenU8Sign(System.Collections.Generic.IDictionary<System.String,System.String> signDict, System.String appKey)
  System.String _BinaryToHexString(System.Byte[] binary, System.Int32 index, System.Int32 length)
  U8.SDK.SDKPromise<System.String> AuthV2(System.String captcha)
  System.String LoadExtraConfig()
  System.Void V2Init(System.String env)
  System.Void Init()
  System.Void Login()
  System.Void LoginCustom(System.String customData)
  System.Void SwitchLogin()
  System.Boolean Logout()
  System.Boolean ShowAccountCenter()
  System.Void SubmitGameData(U8.SDK.U8ExtraGameData data)
  System.Boolean SDKExit()
  System.Void Pay(U8.SDK.U8PayParams data)
  System.Boolean IsSupportExit()
  System.Boolean IsSupportAccountCenter()
  System.Boolean IsSupportLogout()
  System.Boolean IsSupportLogin()
  System.Void SetData(System.Int32 type, System.String paramJson)
  System.String GetData(System.Int32 type, System.String paramJson)
  U8.SDK.SDKMeta LoadSDKMeta()
  System.Boolean IsNativePlugin()
  System.Collections.IEnumerator _NextFrameCoroutine(System.Action call)
  System.Void InvokeNextFrame(System.Action action)
  System.Void InvokeCoroutine(System.Collections.IEnumerator coroutine)
  System.String EncodeGameData(U8.SDK.U8ExtraGameData data)
  System.String EncodePayParams(U8.SDK.U8PayParams data)
  System.Void add_onReceiverProductlist(U8.SDK.U8SDKInterface.ReceiverProductListResult value)
  System.Void remove_onReceiverProductlist(U8.SDK.U8SDKInterface.ReceiverProductListResult value)
  System.String get_sessionToken()
  U8.SDK.U8SDKInterface.GameServerTimeCache get_serverCacheTime()
  System.Void set_serverCacheTime(U8.SDK.U8SDKInterface.GameServerTimeCache value)
  U8.SDK.SDKPromise<System.String> V2PublicLogin()
  U8.SDK.SDKPromise<U8.SDK.U8AuthV2Result> V2PublicAuth()
  U8.SDK.SDKPromise<U8.SDK.U8OrderInfo> U1PublicCreateOrder(System.String productId, System.String signParams)
  U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ServerInfo>> U1PublicGetServerList()
  U8.SDK.SDKPromise<U8.SDK.U8ConfirmServerResult> U1PublicConfirmServer(System.String serverId)
  U8.SDK.SDKPromise<U8.SDK.U8ConfirmOrderResult> U1PublicConfirmOrder(System.String orderId, System.String extension)
  U8.SDK.SDKPromise<U8.SDK.U8AuthV2Result> _DoMockAuthV2()
  System.Collections.IEnumerator _LoginV2Coroutine(U8.SDK.SDKPromise<System.String> promise)
  System.Void _OnSessionTokenInvalid()
  System.Collections.IEnumerator _AuthV2Coroutine(U8.SDK.SDKPromise<U8.SDK.U8AuthV2Result> promise)
  System.Void .ctor()
  System.Void .cctor()
  System.Void <PublicLogout>b__64_0()
  System.Void <PublicLogout>b__64_1()
  System.Void <PublicLogout>b__64_2()
END_CLASS

CLASS: U8.SDK.SDKError
TYPE:  struct
TOKEN: 0x2000059
FIELDS:
  public    static  System.Int32                    NetworkRequestFailed  // 0x0
  public    static  System.Int32                    ConcurrentCall  // 0x0
  public    static  System.Int32                    ErrorNeedExit  // 0x0
  private           System.String                   <code>k__BackingField  // 0x10
  private           System.String                   <msg>k__BackingField  // 0x18
METHODS:
  System.String get_code()
  System.Void set_code(System.String value)
  System.String get_msg()
  System.Void set_msg(System.String value)
  System.Void .ctor(System.String content)
END_CLASS

CLASS: U8.SDK.U8MockLogin
TYPE:  struct
TOKEN: 0x200005A
FIELDS:
  public    static readonly U8.SDK.U8MockLogin              EMPTY  // 0x0
  public            System.String                   uid  // 0x10
  public            System.String                   token  // 0x18
METHODS:
  System.Boolean IsEmpty()
  System.Void .cctor()
END_CLASS

CLASS: U8.SDK.U8ProductInfo
TYPE:  class
TOKEN: 0x200005B
FIELDS:
  public            System.String                   app_id  // 0x10
  public            System.String                   channel_id  // 0x18
  public            System.Int32                    world_id  // 0x20
  public            System.Int32                    store_id  // 0x24
  public            System.String                   product_id  // 0x28
  public            System.String                   desc  // 0x30
  public            System.String                   name  // 0x38
  public            System.Int32                    type  // 0x40
  public            System.Int64                    price  // 0x48
  public            System.String                   extra_data  // 0x50
  public            System.String                   appstore_id  // 0x58
  public            System.String                   channel_product_id  // 0x60
  public            System.String                   display_price  // 0x68
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.U8ProductsResult
TYPE:  class
TOKEN: 0x200005C
FIELDS:
  public            System.Int32                    status  // 0x10
  public            System.Collections.Generic.List<U8.SDK.U8ProductInfo>u8Products  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.U8ServerInfo
TYPE:  class
TOKEN: 0x200005D
FIELDS:
  public            System.String                   serverId  // 0x10
  public            System.String                   serverName  // 0x18
  public            System.String                   serverDomain  // 0x20
  public            System.Boolean                  defaultChoose  // 0x28
  public            System.String                   roleId  // 0x30
  public            System.String                   nickName  // 0x38
  public            System.Int64                    level  // 0x40
  public            System.String                   extension  // 0x48
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.U8ServerErrorInfo
TYPE:  class
TOKEN: 0x200005E
FIELDS:
  public            System.Int32                    status  // 0x10
  public            System.Int32                    errorCode  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.U8OrderInfo
TYPE:  class
TOKEN: 0x200005F
FIELDS:
  public            System.String                   orderId  // 0x10
  public            System.String                   channelProductCode  // 0x18
  public            System.String                   productName  // 0x20
  public            System.String                   productDesc  // 0x28
  public            System.Int64                    amount  // 0x30
  public            System.String                   extension  // 0x38
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.U8PayParams
TYPE:  class
TOKEN: 0x2000060
FIELDS:
  private           System.String                   <productId>k__BackingField  // 0x10
  private           System.String                   <productName>k__BackingField  // 0x18
  private           System.String                   <productDesc>k__BackingField  // 0x20
  private           System.Int64                    <price>k__BackingField  // 0x28
  private           System.Int32                    <buyNum>k__BackingField  // 0x30
  private           System.Int32                    <coinNum>k__BackingField  // 0x34
  private           System.String                   <serverId>k__BackingField  // 0x38
  private           System.String                   <serverName>k__BackingField  // 0x40
  private           System.String                   <roleId>k__BackingField  // 0x48
  private           System.String                   <roleName>k__BackingField  // 0x50
  private           System.Int32                    <roleLevel>k__BackingField  // 0x58
  private           System.String                   <vip>k__BackingField  // 0x60
  private           System.String                   <orderID>k__BackingField  // 0x68
  private           System.String                   <worldID>k__BackingField  // 0x70
  private           System.String                   <token>k__BackingField  // 0x78
  private           System.String                   <appKey>k__BackingField  // 0x80
  private           System.String                   <extension>k__BackingField  // 0x88
  private           System.String                   <addition>k__BackingField  // 0x90
METHODS:
  System.String get_productId()
  System.Void set_productId(System.String value)
  System.String get_productName()
  System.Void set_productName(System.String value)
  System.String get_productDesc()
  System.Void set_productDesc(System.String value)
  System.Int64 get_price()
  System.Void set_price(System.Int64 value)
  System.Int32 get_buyNum()
  System.Void set_buyNum(System.Int32 value)
  System.Int32 get_coinNum()
  System.Void set_coinNum(System.Int32 value)
  System.String get_serverId()
  System.Void set_serverId(System.String value)
  System.String get_serverName()
  System.Void set_serverName(System.String value)
  System.String get_roleId()
  System.Void set_roleId(System.String value)
  System.String get_roleName()
  System.Void set_roleName(System.String value)
  System.Int32 get_roleLevel()
  System.Void set_roleLevel(System.Int32 value)
  System.String get_vip()
  System.Void set_vip(System.String value)
  System.String get_orderID()
  System.Void set_orderID(System.String value)
  System.String get_worldID()
  System.Void set_worldID(System.String value)
  System.String get_token()
  System.Void set_token(System.String value)
  System.String get_appKey()
  System.Void set_appKey(System.String value)
  System.String get_extension()
  System.Void set_extension(System.String value)
  System.String get_addition()
  System.Void set_addition(System.String value)
  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.U8ExtraGameData
TYPE:  class
TOKEN: 0x2000061
FIELDS:
  public    static  System.Int32                    TYPE_SELECT_SERVER  // 0x0
  public    static  System.Int32                    TYPE_CREATE_ROLE  // 0x0
  public    static  System.Int32                    TYPE_ENTER_GAME  // 0x0
  public    static  System.Int32                    TYPE_LEVEL_UP  // 0x0
  public    static  System.Int32                    TYPE_EXIT_GAME  // 0x0
  public    static  System.Int32                    TYPE_STOP_GAME  // 0x0
  public    static  System.Int32                    TYPE_APP_START  // 0x0
  public    static  System.Int32                    TYPE_USER_LOGIN  // 0x0
  public    static  System.Int32                    TYPE_USER_LOGOUT  // 0x0
  public    static  System.Int32                    TYPE_PAY_SUCCESS  // 0x0
  public    static  System.Int32                    TYPE_CUSTOM_EVENT  // 0x0
  private           System.Int32                    <dataType>k__BackingField  // 0x10
  private           System.String                   <uid>k__BackingField  // 0x18
  private           System.String                   <roleID>k__BackingField  // 0x20
  private           System.String                   <roleName>k__BackingField  // 0x28
  private           System.String                   <roleLevel>k__BackingField  // 0x30
  private           System.Int32                    <serverID>k__BackingField  // 0x38
  private           System.String                   <serverName>k__BackingField  // 0x40
  private           System.String                   <channel>k__BackingField  // 0x48
  private           System.String                   <subChannel>k__BackingField  // 0x50
  private           System.Boolean                  <isNewUser>k__BackingField  // 0x58
  private           System.Int64                    <revenue>k__BackingField  // 0x60
  private           System.String                   <customEventName>k__BackingField  // 0x68
  private           System.String                   <customEventParams>k__BackingField  // 0x70
METHODS:
  System.Int32 get_dataType()
  System.Void set_dataType(System.Int32 value)
  System.String get_uid()
  System.Void set_uid(System.String value)
  System.String get_roleID()
  System.Void set_roleID(System.String value)
  System.String get_roleName()
  System.Void set_roleName(System.String value)
  System.String get_roleLevel()
  System.Void set_roleLevel(System.String value)
  System.Int32 get_serverID()
  System.Void set_serverID(System.Int32 value)
  System.String get_serverName()
  System.Void set_serverName(System.String value)
  System.String get_channel()
  System.Void set_channel(System.String value)
  System.String get_subChannel()
  System.Void set_subChannel(System.String value)
  System.Boolean get_isNewUser()
  System.Void set_isNewUser(System.Boolean value)
  System.Int64 get_revenue()
  System.Void set_revenue(System.Int64 value)
  System.String get_customEventName()
  System.Void set_customEventName(System.String value)
  System.String get_customEventParams()
  System.Void set_customEventParams(System.String value)
  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.U8LoginResult
TYPE:  struct
TOKEN: 0x2000062
FIELDS:
  public    static readonly U8.SDK.U8LoginResult            EMPTY  // 0x0
  public            System.Int32                    result  // 0x10
  public            System.String                   uid  // 0x18
  public            System.String                   channelUid  // 0x20
  public            System.String                   token  // 0x28
  public            System.String                   extension  // 0x30
  public            System.Boolean                  isGuest  // 0x38
  public            System.Boolean                  isNew  // 0x39
  public            System.String                   error  // 0x40
METHODS:
  System.String ToString()
  System.Void .cctor()
END_CLASS

CLASS: U8.SDK.U8LoginRejectInfo
TYPE:  struct
TOKEN: 0x2000063
FIELDS:
  public            System.String                   error  // 0x10
  public            System.Boolean                  needCaptcha  // 0x18
  public            System.String                   captcha  // 0x20
  public            System.String                   captchaTips  // 0x28
METHODS:
END_CLASS

CLASS: U8.SDK.U8ProductError
TYPE:  struct
TOKEN: 0x2000064
FIELDS:
  public            System.Int32                    status  // 0x10
  public            System.Int32                    errorCode  // 0x14
METHODS:
END_CLASS

CLASS: U8.SDK.U8CaptchaResult
TYPE:  struct
TOKEN: 0x2000065
FIELDS:
  public            System.Int32                    result  // 0x10
  public            System.String                   data  // 0x18
METHODS:
END_CLASS

CLASS: U8.SDK.U8PayConfirmResult
TYPE:  struct
TOKEN: 0x2000066
FIELDS:
  public            U8.SDK.PayConfirmStatus         payState  // 0x10
METHODS:
END_CLASS

CLASS: U8.SDK.PayConfirmStatus
TYPE:  struct
TOKEN: 0x2000067
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  U8.SDK.PayConfirmStatus         FAILED  // 0x0
  public    static  U8.SDK.PayConfirmStatus         THIRD_PARTY_PENDING  // 0x0
  public    static  U8.SDK.PayConfirmStatus         GAME_SERVER_PENDING  // 0x0
  public    static  U8.SDK.PayConfirmStatus         SUCCEED  // 0x0
  public    static  U8.SDK.PayConfirmStatus         ORDER_NOT_EXIST  // 0x0
METHODS:
END_CLASS

CLASS: U8.SDK.PayResultStatus
TYPE:  struct
TOKEN: 0x2000068
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  U8.SDK.PayResultStatus          SUCCEED  // 0x0
  public    static  U8.SDK.PayResultStatus          PENDING  // 0x0
METHODS:
END_CLASS

CLASS: U8.SDK.PayFailStatus
TYPE:  struct
TOKEN: 0x2000069
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  U8.SDK.PayFailStatus            UNKNOWN  // 0x0
  public    static  U8.SDK.PayFailStatus            CANCELED  // 0x0
  public    static  U8.SDK.PayFailStatus            ERROR  // 0x0
  public    static  U8.SDK.PayFailStatus            HALT  // 0x0
METHODS:
END_CLASS

CLASS: U8.SDK.U8ConfirmServerResult
TYPE:  class
TOKEN: 0x200006A
FIELDS:
  public            System.Int32                    status  // 0x10
  public            System.String                   message  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.U8ConfirmOrderStatus
TYPE:  struct
TOKEN: 0x200006B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  U8.SDK.U8ConfirmOrderStatus     NONE  // 0x0
  public    static  U8.SDK.U8ConfirmOrderStatus     INTERNAL_ERROR  // 0x0
  public    static  U8.SDK.U8ConfirmOrderStatus     TIMEOUT  // 0x0
  public    static  U8.SDK.U8ConfirmOrderStatus     INVALID_ORDER  // 0x0
  public    static  U8.SDK.U8ConfirmOrderStatus     SUCCEED  // 0x0
METHODS:
END_CLASS

CLASS: U8.SDK.U8ConfirmOrderResult
TYPE:  class
TOKEN: 0x200006C
FIELDS:
  public            U8.SDK.U8ConfirmOrderStatus     status  // 0x10
  public            System.String                   message  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.U8PayFailMsg
TYPE:  struct
TOKEN: 0x200006D
FIELDS:
  public    static  U8.SDK.U8PayFailMsg             EMPTY  // 0x0
  public            U8.SDK.PayFailStatus            status  // 0x10
  public            System.String                   message  // 0x18
  public            System.String                   extension  // 0x20
METHODS:
  U8.SDK.U8PayFailMsg FromJson(System.String jsonStr)
  System.Void .cctor()
END_CLASS

CLASS: U8.SDK.U8PayResult
TYPE:  struct
TOKEN: 0x200006E
FIELDS:
  public    static readonly U8.SDK.U8PayResult              EMPTY  // 0x0
  public            U8.SDK.PayResultStatus          status  // 0x10
  public            System.String                   outTradeNo  // 0x18
  public            System.String                   extension  // 0x20
METHODS:
  U8.SDK.U8PayResult FromJson(System.String jsonData)
  System.String ToString()
  System.Void .cctor()
END_CLASS

CLASS: U8.SDK.U8GetDataResult
TYPE:  struct
TOKEN: 0x200006F
FIELDS:
  public    static readonly U8.SDK.U8GetDataResult          EMPTY  // 0x0
  public            System.Int32                    code  // 0x10
  public            System.String                   msg  // 0x18
METHODS:
  System.Boolean IsSuc()
  U8.SDK.U8GetDataResult FromJson(System.String rawJson)
  System.Void .cctor()
END_CLASS

CLASS: U8.SDK.SDKInterfaceDefault
TYPE:  class
TOKEN: 0x2000070
EXTENDS: U8SDKInterface
FIELDS:
METHODS:
  System.String LoadExtraConfig()
  System.Void V2Init(System.String env)
  System.Void Init()
  System.Void Login()
  System.Void LoginCustom(System.String customData)
  System.Void SwitchLogin()
  System.Boolean Logout()
  System.Boolean ShowAccountCenter()
  System.Void SubmitGameData(U8.SDK.U8ExtraGameData data)
  System.Boolean SDKExit()
  System.Void Pay(U8.SDK.U8PayParams data)
  System.Boolean IsSupportLogin()
  System.Boolean IsSupportExit()
  System.Boolean IsSupportAccountCenter()
  System.Boolean IsSupportLogout()
  System.Void SetData(System.Int32 type, System.String paramJson)
  System.String GetData(System.Int32 type, System.String paramJson)
  U8.SDK.SDKMeta LoadSDKMeta()
  System.Boolean IsNativePlugin()
  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.SDKInterfaceWIN
TYPE:  class
TOKEN: 0x2000071
EXTENDS: U8SDKInterface
FIELDS:
  private           System.Int32                    actionIndex  // 0xD8
  private   static  System.Collections.Generic.Dictionary<System.Int32,System.Action<System.String>>dictAction  // 0x0
METHODS:
  System.Void .ctor()
  System.Void Finalize()
  System.Int32 AddAction(System.Action<System.String> action)
  System.Void DataActionCallback(System.Int32 index, System.String paramValue)
  System.Void ASyncDataActionCallback(System.Int32 index, System.String paramValue)
  System.Void U8SDKSendMessage(System.String methodName, System.String paramValue)
  System.Void HGU8SDKInitLibrary(System.String windowText, System.Int64 windowHandle)
  System.Int32 HGU8SDKSetUserDataPath(System.String path)
  System.Void HGU8SDKUnInitLibrary()
  System.Void HGU8SDKInitDatacallback(U8.SDK.SDKInterfaceWIN.DataCallback Callback, U8.SDK.SDKInterfaceWIN.DataCallback asyncCallback)
  System.Void HGU8SDKInitSendMessage(U8.SDK.SDKInterfaceWIN.U8SDKSendMessageCallback callback)
  System.Void HGU8SDKInit()
  System.Void HGU8SDKV2Init(System.String env)
  System.Void HGU8SDKLogin()
  System.Void HGU8SDKLoginCustom(System.String json)
  System.Void HGU8SDKSwitchLogin()
  System.Int32 HGU8SDKLogout()
  System.Int32 HGU8SDKShowAccountCenter()
  System.Void HGU8SDKPay(System.String json)
  System.Void HGU8SDKSubmitGameData(System.String json)
  System.Int32 HGU8SDKIsSupportExit()
  System.Int32 HGU8SDKIsSupportAccountCenter()
  System.Int32 HGU8SDKIsSupportLogin()
  System.Int32 HGU8SDKIsSupportLogout()
  System.Void HGU8SDKGetSDKMeta(System.Int32 index)
  System.Void HGU8SDKSetData(System.Int32 code, System.String paramJson)
  System.Void HGU8SDKGetData(System.Int32 code, System.String paramJson, System.Int32 index)
  System.Int32 HGU8SDKIsNativePlugin()
  System.Void HGU8SDKLoadExtraConfig(System.Int32 index)
  System.String LoadExtraConfig()
  System.Void V2Init(System.String env)
  System.Void Init()
  System.Void Login()
  System.Boolean Logout()
  System.Void LoginCustom(System.String customData)
  System.Void SwitchLogin()
  System.Void SubmitGameData(U8.SDK.U8ExtraGameData data)
  System.Void SetData(System.Int32 type, System.String paramJson)
  System.String GetData(System.Int32 type, System.String paramJson)
  System.Boolean ShowAccountCenter()
  System.Boolean SDKExit()
  System.Void Pay(U8.SDK.U8PayParams data)
  System.Boolean IsSupportExit()
  System.Boolean IsSupportAccountCenter()
  System.Boolean IsSupportLogin()
  System.Boolean IsSupportLogout()
  U8.SDK.SDKMeta LoadSDKMeta()
  System.Boolean IsNativePlugin()
  System.Void .cctor()
END_CLASS

CLASS: U8.SDK.SDKMeta
TYPE:  class
TOKEN: 0x2000077
FIELDS:
  public            System.String                   appID  // 0x10
  public            System.String                   appKey  // 0x18
  public            System.String                   channel  // 0x20
  public            System.String                   token  // 0x28
  public            System.String                   worldId  // 0x30
  public            System.String                   extension  // 0x38
  public            System.String                   appCode  // 0x40
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String jsonData)
  System.String ToString()
END_CLASS

CLASS: U8.SDK.ISDKPromise
TYPE:  interface
TOKEN: 0x2000078
FIELDS:
METHODS:
  System.Void Fulfill(System.Object param)
  System.Void Reject(System.Object reason)
END_CLASS

CLASS: U8.SDK.SDKPromise`1
TYPE:  class
TOKEN: 0x2000079
FIELDS:
  public            System.Action<Param>            onFulfilled  // 0x0
  public            System.Action<System.Object>    onRejected  // 0x0
METHODS:
  System.Void Fulfill(System.Object param)
  System.Void Reject(System.Object reason)
  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.SDKPromiseWithResult`1
TYPE:  class
TOKEN: 0x200007A
EXTENDS: SDKPromise`1
FIELDS:
  private           Param                           <result>k__BackingField  // 0x0
  private           System.Object                   <rejectInfo>k__BackingField  // 0x0
METHODS:
  Param get_result()
  System.Void set_result(Param value)
  System.Object get_rejectInfo()
  System.Void set_rejectInfo(System.Object value)
  System.Void Fulfill(System.Object param)
  System.Void Reject(System.Object reason)
  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.SDKPromiseEnumerator`1
TYPE:  class
TOKEN: 0x200007B
FIELDS:
  private           U8.SDK.SDKPromiseEnumerator.State<T>m_state  // 0x0
  private           T                               <result>k__BackingField  // 0x0
  private           System.Object                   <reject>k__BackingField  // 0x0
METHODS:
  System.Boolean get_isFulfilled()
  T get_result()
  System.Void set_result(T value)
  System.Object get_reject()
  System.Void set_reject(System.Object value)
  System.Collections.IEnumerator Yield()
  System.Void .ctor(U8.SDK.SDKPromise<T> promise)
  System.Void _OnFulfilled(T result)
  System.Void _OnRejected(System.Object rejectInfo)
END_CLASS

CLASS: U8.SDK.SDKPromiseWrapper
TYPE:  class
TOKEN: 0x200007E
FIELDS:
  private           U8.SDK.ISDKPromise              m_promise  // 0x10
METHODS:
  T EnsurePromise()
  System.Void Fulfill(System.Object param)
  System.Void Reject(System.Object reason)
  System.Void _Clear()
  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.SDKPromiseExtensions
TYPE:  class
TOKEN: 0x200007F
FIELDS:
METHODS:
  System.Void RejectWithString(U8.SDK.ISDKPromise promise, System.String errorInfo)
  System.Void FulfillWithType(U8.SDK.SDKPromise<T> promise, T param)
END_CLASS

CLASS: U8.SDK.U8SDKTickEvent
TYPE:  class
TOKEN: 0x2000080
EXTENDS: MonoBehaviour
FIELDS:
METHODS:
  System.Void Update()
  System.Void HGU8SDKTickEvent()
  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.U8TickEventManager
TYPE:  class
TOKEN: 0x2000081
FIELDS:
  private           UnityEngine.GameObject          tickGameObject  // 0x10
  private           U8.SDK.U8SDKTickEvent           tickEvent  // 0x18
  private   static  U8.SDK.U8TickEventManager       instanceMangaer  // 0x0
METHODS:
  U8.SDK.U8TickEventManager get_InstanceMangaer()
  System.Void InitTickEvent()
  System.Void UnInitTickEvent()
  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.U8LoginV2Result
TYPE:  class
TOKEN: 0x2000082
FIELDS:
  public            System.String                   token  // 0x10
  public            System.String                   uid  // 0x18
  public            System.Boolean                  isNew  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.U8AuthV2Result
TYPE:  class
TOKEN: 0x2000083
FIELDS:
  public            System.String                   uid  // 0x10
  public            System.String                   oauth2Code  // 0x18
  public            System.String                   oauth2Token  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.U8GrantResult
TYPE:  class
TOKEN: 0x2000084
FIELDS:
  public            System.String                   uid  // 0x10
  public            System.String                   code  // 0x18
  public            System.String                   token  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: U8.SDK.U8SDKCallback
TYPE:  class
TOKEN: 0x2000085
EXTENDS: MonoBehaviour
FIELDS:
  private   static  U8.SDK.U8SDKCallback            m_instance  // 0x0
  private   static  System.Object                   m_lock  // 0x8
METHODS:
  U8.SDK.U8SDKCallback InitCallback()
  System.Void OnInitSuc(System.String extConfigs)
  System.Void OnInitFail(System.String info)
  System.Void OnLoginSuc(System.String extension)
  System.Void OnLoginFail(System.String info)
  System.Void OnLogout(System.String info)
  System.Void OnSwitchAccount()
  System.Void OnPaySuc(System.String jsonData)
  System.Void OnPayFail(System.String failMsg)
  System.Void OnSDKError(System.String jsonData)
  System.Void OnExtraInfo(System.String jsonData)
  System.Collections.IEnumerator _onLogoutNextFrameCoroutine()
  T GetValueSafe(System.Collections.Generic.Dictionary<System.String,System.Object> dict, System.String key, T defVal)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: U8.SDK.MiniJSON.Json
TYPE:  class
TOKEN: 0x2000087
FIELDS:
METHODS:
  System.Object Deserialize(System.String json)
  System.String Serialize(System.Object obj)
END_CLASS

