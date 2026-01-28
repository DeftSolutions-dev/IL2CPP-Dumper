// ========================================================
// Dumped by @desirepro
// Assembly: U8SDK.dll
// Classes:  146
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000007
    public struct Status
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static U8.SDK.SDKCaptchaHandler.Status SUC;        // 0x0
        public static U8.SDK.SDKCaptchaHandler.Status SYS_BUSY;        // 0x0
        public static U8.SDK.SDKCaptchaHandler.Status USER_CANCEL;        // 0x0
        public static U8.SDK.SDKCaptchaHandler.Status NOT_SUPPORT;        // 0x0
        public static U8.SDK.SDKCaptchaHandler.Status INVALID_PARAM;        // 0x0
        public static U8.SDK.SDKCaptchaHandler.Status UNKNOWN;        // 0x0

    }

    // TypeToken: 0x2000008
    public class Result
    {
        // Fields
        private U8.SDK.SDKCaptchaHandler.Status <status>k__BackingField;        // 0x10
        private System.Int32 <errorCode>k__BackingField;        // 0x14
        private System.String <captcha>k__BackingField;        // 0x18

        // Methods
        private U8.SDK.SDKCaptchaHandler.Status get_status() { }
        private System.Void set_status(U8.SDK.SDKCaptchaHandler.Status value) { }
        private System.Int32 get_errorCode() { }
        private System.Void set_errorCode(System.Int32 value) { }
        private System.String get_captcha() { }
        private System.Void set_captcha(System.String value) { }
        private System.Void .ctor() { }
        private U8.SDK.SDKCaptchaHandler.Result CreateForOutput() { }
        private System.Void MarkSucceed(System.String captcha) { }
        private System.Void MarkFailed(U8.SDK.SDKCaptchaHandler.Status status, System.Int32 errorCode) { }
        private System.Void MarkFailed(U8.SDK.SDKCaptchaHandler.Status status) { }

    }

    // TypeToken: 0x200000A
    public interface IFromJSON
    {
        // Methods
        private System.Boolean LoadFromJSON(System.String json) { }

    }

    // TypeToken: 0x200000B
    public struct POSTStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static U8.SDK.SDKExternalTools.POSTStatus NONE;        // 0x0
        public static U8.SDK.SDKExternalTools.POSTStatus SUC;        // 0x0
        public static U8.SDK.SDKExternalTools.POSTStatus TIMEOUT;        // 0x0
        public static U8.SDK.SDKExternalTools.POSTStatus ERROR;        // 0x0

    }

    // TypeToken: 0x200000C
    public struct BusType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static U8.SDK.SDKExternalTools.BusType NONE;        // 0x0
        public static U8.SDK.SDKExternalTools.BusType GET_TOKEN;        // 0x0
        public static U8.SDK.SDKExternalTools.BusType GET_CAPTCHA;        // 0x0
        public static U8.SDK.SDKExternalTools.BusType CREATE_ORDER;        // 0x0
        public static U8.SDK.SDKExternalTools.BusType CONFIRM_ORDER;        // 0x0
        public static U8.SDK.SDKExternalTools.BusType VERIFY_ACCOUNT;        // 0x0
        public static U8.SDK.SDKExternalTools.BusType GET_PRODUCT_LIST;        // 0x0
        public static U8.SDK.SDKExternalTools.BusType AUTHV2_SESSION_TOKEN;        // 0x0
        public static U8.SDK.SDKExternalTools.BusType AUTHV2_OAUTH2CODE;        // 0x0
        public static U8.SDK.SDKExternalTools.BusType AUTHV2_OAUTH2TOKEN;        // 0x0
        public static U8.SDK.SDKExternalTools.BusType SERVER_LIST;        // 0x0
        public static U8.SDK.SDKExternalTools.BusType CONFIRM_SERVER;        // 0x0

    }

    // TypeToken: 0x200000D
    public struct ErrorType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static U8.SDK.SDKExternalTools.ErrorType NONE;        // 0x0
        public static U8.SDK.SDKExternalTools.ErrorType TIMEOUT;        // 0x0
        public static U8.SDK.SDKExternalTools.ErrorType NETWORK_ERROR;        // 0x0
        public static U8.SDK.SDKExternalTools.ErrorType DESERIALIZE_FAILED;        // 0x0
        public static U8.SDK.SDKExternalTools.ErrorType BUSINESS_ERROR;        // 0x0

    }

    // TypeToken: 0x200000E
    public struct POSTRequest
    {
        // Fields
        public System.String url;        // 0x10
        public System.String body;        // 0x18
        public System.String contentType;        // 0x20
        public System.Collections.Generic.Dictionary<System.String,System.String> nullableHeaders;        // 0x28

    }

    // TypeToken: 0x200000F
    public struct POSTResult
    {
        // Fields
        public U8.SDK.SDKExternalTools.POSTStatus status;        // 0x10
        public System.Int32 httpCode;        // 0x14
        public System.String response;        // 0x18
        public System.String error;        // 0x20

        // Methods
        private System.Boolean ServiceFailed() { }

    }

    // TypeToken: 0x2000010
    public struct ErrMsgMeta
    {
        // Fields
        public static readonly U8.SDK.SDKExternalTools.ErrMsgMeta EMPTY;        // 0x0
        public U8.SDK.SDKExternalTools.BusType busType;        // 0x10
        public U8.SDK.SDKExternalTools.ErrorType errorType;        // 0x14
        public System.Int32 errorCode;        // 0x18
        public System.String alertFromServer;        // 0x20
        public System.Object meta;        // 0x28

        // Methods
        private System.Boolean IsEmpty() { }
        private U8.SDK.SDKExternalTools.ErrMsgMeta FromPOSTResult(U8.SDK.SDKExternalTools.BusType busType, U8.SDK.SDKExternalTools.POSTResult postRet) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000011
    public class CaptchaMgr
    {
        // Fields
        private U8.SDK.SDKExternalTools m_host;        // 0x10
        private U8.SDK.SDKCaptchaHandler <activeHandler>k__BackingField;        // 0x18

        // Methods
        private U8.SDK.SDKCaptchaHandler get_activeHandler() { }
        private System.Void set_activeHandler(U8.SDK.SDKCaptchaHandler value) { }
        private System.Void .ctor(U8.SDK.SDKExternalTools host) { }
        private System.Collections.IEnumerator FetchCaptchaCoroutine(System.Collections.Generic.Dictionary<System.String,System.Object> captchaParams, U8.SDK.SDKCaptchaHandler.Result outResult) { }

    }

    // TypeToken: 0x2000014
    public struct Builder
    {
        // Fields
        public U8.SDK.SDKExternalTools.POSTRequest request;        // 0x10
        public U8.SDK.SDKExternalTools.BusType busType;        // 0x30

        // Methods
        private U8.SDK.SDKExternalTools.POSTProcedure Build() { }
        private U8.SDK.SDKExternalTools.POSTProcedure<TResp> TypedBuild() { }

    }

    // TypeToken: 0x2000013
    public class POSTProcedure
    {
        // Fields
        private U8.SDK.SDKExternalTools.POSTProcedure.Builder <builder>k__BackingField;        // 0x10
        private System.Boolean <isServiceFinished>k__BackingField;        // 0x38
        private U8.SDK.SDKExternalTools.ErrMsgMeta <serviceError>k__BackingField;        // 0x40
        private System.String <rawResponse>k__BackingField;        // 0x60

        // Methods
        private U8.SDK.SDKExternalTools.POSTProcedure.Builder get_builder() { }
        private System.Void set_builder(U8.SDK.SDKExternalTools.POSTProcedure.Builder value) { }
        private System.Boolean get_isServiceFinished() { }
        private System.Void set_isServiceFinished(System.Boolean value) { }
        private U8.SDK.SDKExternalTools.ErrMsgMeta get_serviceError() { }
        private System.Void set_serviceError(U8.SDK.SDKExternalTools.ErrMsgMeta value) { }
        private System.String get_rawResponse() { }
        private System.Void set_rawResponse(System.String value) { }
        private U8.SDK.SDKExternalTools.ErrMsgMeta MakeBusinessError(System.Int32 errorCode) { }
        private System.Collections.IEnumerator POST(U8.SDK.SDKExternalTools host) { }
        private System.Void _OnServiceFinished(U8.SDK.SDKExternalTools.POSTResult postRet) { }
        private System.Void HandleServiceResponse(U8.SDK.SDKExternalTools.POSTResult postRet) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000016
    public class POSTProcedure`1 : POSTProcedure
    {
        // Fields
        private TResp <response>k__BackingField;        // 0x0

        // Methods
        private TResp get_response() { }
        private System.Void set_response(TResp value) { }
        private System.Void HandleServiceResponse(U8.SDK.SDKExternalTools.POSTResult postRet) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000017
    public class AuthV2SessionTokenResp, IFromJSON
    {
        // Fields
        public System.Int32 status;        // 0x10
        public System.String msg;        // 0x18
        public System.String type;        // 0x20
        public System.String token;        // 0x28
        public System.String uid;        // 0x30
        public System.Boolean isNew;        // 0x38

        // Methods
        private System.Boolean LoadFromJSON(System.String json) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000018
    public class GetProductLsitResp, IFromJSON
    {
        // Fields
        public System.Int32 flag;        // 0x10
        public System.Collections.Generic.Dictionary<System.String,System.Object> desc;        // 0x18

        // Methods
        private System.Boolean LoadFromDictionary(System.Collections.Generic.Dictionary<System.String,System.Object> dict) { }
        private System.Boolean LoadFromJSON(System.String json) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000019
    public class AuthV2GrantResp, IFromJSON
    {
        // Fields
        public System.Int32 status;        // 0x10
        public System.String msg;        // 0x18
        public System.String type;        // 0x20
        public System.String uid;        // 0x28
        public System.String code;        // 0x30
        public System.String token;        // 0x38
        public System.Int64 banStartTs;        // 0x40
        public System.Int64 banEndTs;        // 0x48
        public System.Int64 maintainStartTs;        // 0x50
        public System.Int64 maintainEndTs;        // 0x58
        public System.Collections.Generic.Dictionary<System.String,System.Object> captcha;        // 0x60

        // Methods
        private System.Boolean LoadFromJSON(System.String json) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001B
    public struct ServerData
    {
        // Fields
        public System.String serverId;        // 0x10
        public System.String serverName;        // 0x18
        public System.String serverDomain;        // 0x20
        public System.Boolean defaultChoose;        // 0x28
        public System.String roleId;        // 0x30
        public System.String nickName;        // 0x38
        public System.Int64 level;        // 0x40
        public System.String extension;        // 0x48

    }

    // TypeToken: 0x200001A
    public class ServerListResp, IFromJSON
    {
        // Fields
        public System.Int32 status;        // 0x10
        public System.String msg;        // 0x18
        public System.Collections.Generic.List<U8.SDK.SDKExternalTools.ServerListResp.ServerData> data;        // 0x20

        // Methods
        private System.Boolean LoadFromJSON(System.String json) { }
        private System.Collections.Generic.List<U8.SDK.U8ServerInfo> ToServerInfo() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001C
    public class ConfirmServerResp, IFromJSON
    {
        // Fields
        public static System.Int32 SERVER_NOT_EXIST;        // 0x0
        public static System.Int32 ACCOUNT_NOT_EXIST;        // 0x0
        public System.Int32 status;        // 0x10
        public System.String msg;        // 0x18

        // Methods
        private System.Boolean LoadFromJSON(System.String json) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001D
    public class ConfirmOrderU1Resp, IFromJSON
    {
        // Fields
        public static System.Int32 STATUS_ORDER_NOT_EXIST;        // 0x0
        public static System.Int32 STATUS_THIRD_PARTY_PENDING;        // 0x0
        public static System.Int32 STATUS_GAME_SERVER_PENDING;        // 0x0
        public System.Int32 status;        // 0x10

        // Methods
        private System.Boolean LoadFromJSON(System.String json) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001F
    public struct Data
    {
        // Fields
        public System.String orderId;        // 0x10
        public System.String channelProductCode;        // 0x18
        public System.String productName;        // 0x20
        public System.String productDesc;        // 0x28
        public System.Int64 amount;        // 0x30
        public System.Collections.Generic.Dictionary<System.String,System.Object> extension;        // 0x38

    }

    // TypeToken: 0x200001E
    public class CreateOrderU1Resp, IFromJSON
    {
        // Fields
        public System.Int32 status;        // 0x10
        public System.String msg;        // 0x18
        public System.String type;        // 0x20
        public U8.SDK.SDKExternalTools.CreateOrderU1Resp.Data data;        // 0x28

        // Methods
        private System.Boolean LoadFromJSON(System.String json) { }
        private U8.SDK.U8OrderInfo ToOrderInfo() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002E
    public struct U8ProductListData, IFromJSON
    {
        // Fields
        public System.Collections.Generic.List<U8.SDK.U8ProductInfo> productList;        // 0x10

        // Methods
        private System.Boolean LoadFromJSON(System.String json) { }
        private System.Boolean _BuildProductInfo(U8.SDK.U8ProductInfo outInfo, System.Collections.Generic.Dictionary<System.String,System.Object> dict) { }

    }

    // TypeToken: 0x200002F
    public struct U8ProductListDataV2, IFromJSON
    {
        // Fields
        public System.Collections.Generic.List<U8.SDK.U8ProductInfo> productList;        // 0x10

        // Methods
        private System.Boolean LoadFromJSON(System.String json) { }
        private System.Boolean _BuildProductInfo(U8.SDK.U8ProductInfo outInfo, System.Collections.Generic.Dictionary<System.String,System.Object> dict) { }

    }

    // TypeToken: 0x2000030
    public struct U8UpdateGuestResponse, IFromJSON
    {
        // Fields
        public System.Int32 result;        // 0x10

        // Methods
        private System.Boolean LoadFromJSON(System.String json) { }

    }

    // TypeToken: 0x2000031
    public struct U8VerifyAccountResponse, IFromJSON
    {
        // Fields
        public System.String uid;        // 0x10

        // Methods
        private System.Boolean LoadFromJSON(System.String json) { }

    }

    // TypeToken: 0x2000032
    public struct U8GetCaptchaResponse, IFromJSON
    {
        // Fields
        public System.Int32 result;        // 0x10
        public System.Collections.Generic.Dictionary<System.String,System.Object> data;        // 0x18

        // Methods
        private System.Boolean LoadFromJSON(System.String json) { }

    }

    // TypeToken: 0x2000033
    public struct U8AuthResponse, IFromJSON
    {
        // Fields
        public System.Int32 result;        // 0x10
        public System.String uid;        // 0x18
        public System.String channelUid;        // 0x20
        public System.String token;        // 0x28
        public System.String extension;        // 0x30
        public System.Boolean isGuest;        // 0x38
        public System.String error;        // 0x40
        public System.String captchaTips;        // 0x48
        public System.Boolean isNew;        // 0x50
        public System.Collections.Generic.Dictionary<System.String,System.Object> captcha;        // 0x58

        // Methods
        private System.Boolean LoadFromJSON(System.String json) { }
        private U8.SDK.U8LoginResult ToLoginResult() { }

    }

    // TypeToken: 0x2000034
    public struct U8PayConfirmResponse, IFromJSON
    {
        // Fields
        public System.Int32 payState;        // 0x10

        // Methods
        private System.Boolean LoadFromJSON(System.String json) { }

    }

    // TypeToken: 0x2000035
    public struct RequestConnPolicy
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static U8.SDK.SDKExternalToolsShortcut.RequestConnPolicy DEFAULT;        // 0x0
        public static U8.SDK.SDKExternalToolsShortcut.RequestConnPolicy CLOSE_EACH_CON;        // 0x0

    }

    // TypeToken: 0x2000036
    public struct RequestHeaderInjectOptions
    {
        // Fields
        public U8.SDK.SDKExternalToolsShortcut.RequestConnPolicy policy;        // 0x10

    }

    // TypeToken: 0x2000040
    public struct AuthStatus
    {
        // Fields
        public static readonly U8.SDK.U8SDKInterface.AuthStatus EMPTY;        // 0x0
        public System.String uid;        // 0x10
        public System.String oauth2code;        // 0x18
        public System.String oauth2token;        // 0x20
        public System.String sessionToken;        // 0x28

        // Methods
        private System.Boolean IsEmpty() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000041
    public struct V2LoginStatus
    {
        // Fields
        public System.String sessionToken;        // 0x10

    }

    // TypeToken: 0x2000042
    public class ReceiverProductListResult : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Collections.Generic.Dictionary<System.String,System.Object> msg) { }
        private System.IAsyncResult BeginInvoke(System.Collections.Generic.Dictionary<System.String,System.Object> msg, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000043
    public struct GameServerTimeCache
    {
        // Fields
        public System.Int64 cacheTime;        // 0x10
        public System.Int64 maintainEndTs;        // 0x18
        public System.Int64 maintainStartTs;        // 0x20

    }

    // TypeToken: 0x2000072
    public class DataCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Int32 index, System.String paramValue) { }
        private System.IAsyncResult BeginInvoke(System.Int32 index, System.String paramValue, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000073
    public class U8SDKSendMessageCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.String methodName, System.String paramValue) { }
        private System.IAsyncResult BeginInvoke(System.String methodName, System.String paramValue, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200007C
    public struct State
    {
        // Fields
        public System.Int32 value__;        // 0x0
        public static U8.SDK.SDKPromiseEnumerator.State<T> NONE;        // 0x0
        public static U8.SDK.SDKPromiseEnumerator.State<T> FULFILL;        // 0x0
        public static U8.SDK.SDKPromiseEnumerator.State<T> REJECT;        // 0x0

    }

    // TypeToken: 0x2000089
    public struct TOKEN
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static U8.SDK.MiniJSON.Json.Parser.TOKEN NONE;        // 0x0
        public static U8.SDK.MiniJSON.Json.Parser.TOKEN CURLY_OPEN;        // 0x0
        public static U8.SDK.MiniJSON.Json.Parser.TOKEN CURLY_CLOSE;        // 0x0
        public static U8.SDK.MiniJSON.Json.Parser.TOKEN SQUARED_OPEN;        // 0x0
        public static U8.SDK.MiniJSON.Json.Parser.TOKEN SQUARED_CLOSE;        // 0x0
        public static U8.SDK.MiniJSON.Json.Parser.TOKEN COLON;        // 0x0
        public static U8.SDK.MiniJSON.Json.Parser.TOKEN COMMA;        // 0x0
        public static U8.SDK.MiniJSON.Json.Parser.TOKEN STRING;        // 0x0
        public static U8.SDK.MiniJSON.Json.Parser.TOKEN NUMBER;        // 0x0
        public static U8.SDK.MiniJSON.Json.Parser.TOKEN TRUE;        // 0x0
        public static U8.SDK.MiniJSON.Json.Parser.TOKEN FALSE;        // 0x0
        public static U8.SDK.MiniJSON.Json.Parser.TOKEN NULL;        // 0x0

    }

    // TypeToken: 0x2000088
    public class Parser, IDisposable
    {
        // Fields
        private static System.String WORD_BREAK;        // 0x0
        private System.IO.StringReader json;        // 0x10

        // Methods
        private System.Boolean IsWordBreak(System.Char c) { }
        private System.Void .ctor(System.String jsonString) { }
        private System.Object Parse(System.String jsonString) { }
        private System.Void Dispose() { }
        private System.Collections.Generic.Dictionary<System.String,System.Object> ParseObject() { }
        private System.Collections.Generic.List<System.Object> ParseArray() { }
        private System.Object ParseValue() { }
        private System.Object ParseByToken(U8.SDK.MiniJSON.Json.Parser.TOKEN token) { }
        private System.String ParseString() { }
        private System.Object ParseNumber() { }
        private System.Void EatWhitespace() { }
        private System.Char get_PeekChar() { }
        private System.Char get_NextChar() { }
        private System.String get_NextWord() { }
        private U8.SDK.MiniJSON.Json.Parser.TOKEN get_NextToken() { }

    }

    // TypeToken: 0x200008A
    public class Serializer
    {
        // Fields
        private System.Text.StringBuilder builder;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.String Serialize(System.Object obj) { }
        private System.Void SerializeValue(System.Object value) { }
        private System.Void SerializeObject(System.Collections.IDictionary obj) { }
        private System.Void SerializeArray(System.Collections.IList anArray) { }
        private System.Void SerializeString(System.String str) { }
        private System.Void SerializeOther(System.Object value) { }

    }

    // TypeToken: 0x2000091
    public struct __StaticArrayInitTypeSize=24
    {
    }

    // TypeToken: 0x2000092
    public struct __StaticArrayInitTypeSize=72
    {
    }

namespace Hypergryph.PlatformFacade
{

    // TypeToken: 0x200008B
    public struct PSNAuthResultStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Hypergryph.PlatformFacade.PSNAuthResultStatus Success;        // 0x0
        public static Hypergryph.PlatformFacade.PSNAuthResultStatus Failed;        // 0x0

    }

    // TypeToken: 0x200008C
    public struct PSNAuthInfo
    {
        // Fields
        public Hypergryph.PlatformFacade.PSNAuthResultStatus status;        // 0x10
        public System.String psnAuthCode;        // 0x18
        public System.String psnEnv;        // 0x20

    }

    // TypeToken: 0x200008D
    public class PlatformFacade
    {
        // Methods
        private System.Void SetupPlatformFont(Hypergryph.PlatformFacade.IPlatformFont iFont) { }
        private System.Threading.Tasks.Task<Hypergryph.PlatformFacade.PSNAuthInfo> GetPSNAuthInfo() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008F
    public interface IPlatformFont
    {
        // Methods
        private TMPro.TMP_FontAsset GetFont() { }

    }

}

namespace U8.SDK
{

    // TypeToken: 0x2000002
    public struct ExternalPluginLoginParams
    {
        // Fields
        public System.Action nativeLogin;        // 0x10
        public System.Action<System.String> nativeLoginCustom;        // 0x18
        public System.Action<System.String> nativeOnLoginSuc;        // 0x20
        public System.Action<System.String> nativeOnLoginFail;        // 0x28
        public System.Action<U8.SDK.U8MockLogin> markMockLogin;        // 0x30

    }

    // TypeToken: 0x2000003
    public struct ExternalPluginLogoutParams
    {
        // Fields
        public System.Action nativeLogout;        // 0x10
        public System.Action nativeOnLogoutSuc;        // 0x18
        public System.Action nativeOnLogoutFail;        // 0x20

    }

    // TypeToken: 0x2000004
    public struct ExternalPluginPayParams
    {
        // Fields
        public U8.SDK.U8PayParams payParams;        // 0x10
        public System.Func<U8.SDK.U8PayParams,U8.SDK.SDKPromise<U8.SDK.U8PayResult>> nativePay;        // 0x18
        public System.Action<U8.SDK.U8PayResult> onPaySuc;        // 0x20
        public System.Action<System.Object> onPayFail;        // 0x28

    }

    // TypeToken: 0x2000005
    public interface IExternalPlugin
    {
        // Methods
        private System.Void Init() { }
        private System.Void Login(U8.SDK.ExternalPluginLoginParams args) { }
        private System.Void Pay(U8.SDK.ExternalPluginPayParams args) { }
        private System.Void Logout(U8.SDK.ExternalPluginLogoutParams args) { }
        private System.String GetSDKToken() { }
        private System.String GetSDKUid() { }
        private System.Boolean TryLoadSDKMeta(System.Func<U8.SDK.SDKMeta> loadMetaNative, U8.SDK.SDKMeta& meta) { }
        private System.Void OnProductListChanged(System.Collections.Generic.List<U8.SDK.U8ProductInfo> productList) { }
        private System.String GetPayAddition() { }

    }

    // TypeToken: 0x2000006
    public class SDKCaptchaHandler
    {
        // Methods
        private System.Collections.IEnumerator FetchCaptchaCoroutine(System.String captchaParams, U8.SDK.SDKCaptchaHandler.Result outResult) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000009
    public class SDKExternalTools
    {
        // Fields
        private static readonly System.Char[] RANDOM_CHAR_MAP;        // 0x0
        protected static System.String CONTENT_TYPE_JSON;        // 0x0
        protected static readonly System.Int32[] PAY_CONFIRM_RETRY_INTERVALS;        // 0x8
        private static U8.SDK.SDKExternalTools s_instance;        // 0x10
        private static U8.SDK.IExternalPlugin s_plugin;        // 0x18
        private System.Boolean <inited>k__BackingField;        // 0x10
        private U8.SDK.SDKExternalTools.CaptchaMgr <captchaMgr>k__BackingField;        // 0x18
        private System.String <subChannel>k__BackingField;        // 0x20
        protected static System.String AUTHV2_SESSION_TOKEN_PATH;        // 0x0
        protected static System.String AUTHV2_GRANT_PATH;        // 0x0
        protected static System.String GAME_SERVER_LIST;        // 0x0
        protected static System.String GAME_CONFIRM_SERVER;        // 0x0
        protected static System.String ORDERV1_CHECK_PATH;        // 0x0
        protected static System.String ORDERV1_CONFIRM_PATH;        // 0x0
        protected static System.String ORDERV1_CREATE_PATH;        // 0x0
        public static System.Int32 GRANT_TYPE_OAUTH2CODE;        // 0x0
        private static System.Int32 U8_SDK_SET_DATA_SET_SERVER;        // 0x20

        // Methods
        private System.Boolean get_inited() { }
        private System.Void set_inited(System.Boolean value) { }
        private U8.SDK.IExternalPlugin get_plugin() { }
        private U8.SDK.SDKExternalTools.CaptchaMgr get_captchaMgr() { }
        private System.Void set_captchaMgr(U8.SDK.SDKExternalTools.CaptchaMgr value) { }
        private System.String get_subChannel() { }
        private System.Void set_subChannel(System.String value) { }
        private System.Boolean SDKInterfaceInitExternalTools() { }
        private U8.SDK.SDKExternalTools GetInstance() { }
        private System.Boolean HasInstance() { }
        private System.String PublicServiceSignKey() { }
        private U8.SDK.SDKPromise<U8.SDK.U8LoginResult> SDKInterfaceSDKAuth(System.String extension, System.String captcha) { }
        private U8.SDK.SDKPromise<U8.SDK.U8CaptchaResult> SDKInterfaceGetCaptcha() { }
        private U8.SDK.SDKPromise<System.Object> SDKInterfaceVerifyAccount(System.String uid, System.String token) { }
        private U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ProductInfo>> SDKInterfaceGetProductList(System.Int32 worldId) { }
        private U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ProductInfo>> SDKInterfaceProductListV2() { }
        private System.Void NotifyProductListUpdated(System.Collections.Generic.List<U8.SDK.U8ProductInfo> productList) { }
        private U8.SDK.SDKPromise<U8.SDK.U8ConfirmOrderResult> SDKLegacyConfirmOrder(System.String uid, System.String orderId, System.String extension) { }
        private U8.SDK.SDKPromise<System.Object> SDKInterfaceUpgradeGuest(System.String targetUid, System.String guestExt, System.String accountExt) { }
        private System.String SDKInterfaceSDKToken() { }
        private System.String SDKInterfaceSDKUid() { }
        private System.String MakeHttpPostParam(System.Collections.Generic.Dictionary<System.String,System.Object> param) { }
        private System.String MakeHttpGetParam(System.Collections.Generic.Dictionary<System.String,System.String> param) { }
        private System.Void LoginWithPlugin(System.Action nativeLogin, System.Action<System.String> nativeLoginCustom, System.Action<U8.SDK.U8MockLogin> markMockLogin) { }
        private System.Void LogoutWithPlugin(System.Action nativeLogout) { }
        private System.Void SDKInterfacePayWithPlugin(U8.SDK.U8PayParams payParams, System.Func<U8.SDK.U8PayParams,U8.SDK.SDKPromise<U8.SDK.U8PayResult>> nativePay, System.Action<U8.SDK.U8PayResult> onSuc, System.Action<System.Object> onFail) { }
        private System.String SDKInterfaceGetPayAddition() { }
        private System.Void StaticLog(System.String content) { }
        private System.Void StaticLogWarning(System.String content) { }
        private System.Void StaticLogError(System.String content) { }
        private System.Void RegisterPlugin(U8.SDK.IExternalPlugin plugin) { }
        private System.Void UnregisterPlugin(U8.SDK.IExternalPlugin plugin) { }
        private System.String GenerateRandomString(System.Int32 min, System.Int32 max) { }
        private T GetValueSafe(System.Collections.Generic.Dictionary<System.String,System.Object> dict, System.String key, T defVal) { }
        private System.String U8Url(System.String routeUrl) { }
        private System.String U8urlWithoutU8(System.String routeUrl) { }
        private U8.SDK.SDKExternalTools.ErrMsgMeta HandleResponseFromU8(U8.SDK.SDKExternalTools.BusType busType, U8.SDK.SDKExternalTools.POSTResult postRet, TResp& resp) { }
        private System.Collections.Generic.Dictionary<System.String,System.Object> FromMiniJSON(System.String json) { }
        private System.Collections.Generic.List<System.Object> FromMiniJSONArray(System.String data) { }
        private System.Void InternalInvokeCoroutine(System.Collections.IEnumerator coroutine) { }
        private System.Void InternalInvokeNextFrame(System.Action action) { }
        private System.Collections.IEnumerator _NextFrameCoroutine(System.Action action) { }
        private System.Void InitIfNot() { }
        private System.Void Init() { }
        private System.Void SwitchAccount() { }
        private System.Void OnSDKError(U8.SDK.SDKError error) { }
        private System.Void OnInvalidProduct(System.Int32 storeId) { }
        private System.Void OnSDKExtraInfo(System.String jsonData) { }
        private U8.SDK.SDKMeta LoadSDKMetaFromPlugin(System.Func<U8.SDK.SDKMeta> nativeLoadMeta) { }
        private U8.SDK.SDKCaptchaHandler CreateCaptchaHandler() { }
        private System.String GetSignKey() { }
        private System.Collections.Generic.Dictionary<System.String,System.String> GetDeviceIDs() { }
        private U8.SDK.SDKPromise<U8.SDK.U8LoginResult> SendSDKAuthRequest(System.String paramStr) { }
        private U8.SDK.SDKPromise<U8.SDK.U8CaptchaResult> SendSDKGetCaptchaRequest(System.String paramStr) { }
        private U8.SDK.SDKPromise<System.Object> SendSDKVerifyAccountRequest(System.String paramStr) { }
        private U8.SDK.SDKPromise<U8.SDK.U8ConfirmOrderResult> SendConfirmOrderRequest(System.String paramStr) { }
        private U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ProductInfo>> SendGetProductListRequest(System.String paramStr) { }
        private U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ProductInfo>> SendGetProductListRequestV2(System.String paramStr) { }
        private U8.SDK.SDKPromise<System.Object> SendUpgradeGuestRequest(System.String paramStr) { }
        private System.Int32 GetPlatformKey() { }
        private System.Void POSTImplementation(U8.SDK.SDKExternalTools.POSTRequest request, System.Action<U8.SDK.SDKExternalTools.POSTResult> callback) { }
        private System.String U8RootUrl() { }
        private System.String GetErrorMessage(U8.SDK.SDKExternalTools.ErrMsgMeta meta) { }
        private System.Void Log(System.String content) { }
        private System.Void LogWarning(System.String content) { }
        private System.Void LogError(System.String content) { }
        private System.Boolean _ValidatePlugin() { }
        private System.String _MakeAuthParam(U8.SDK.SDKMeta meta, System.String extension, System.String captcha) { }
        private System.String _MakeGetCaptchaParam(U8.SDK.SDKMeta meta) { }
        private System.String _MakeVerifyAccountParam(System.String uid, System.String token) { }
        private System.String _MakeGetProductListParam(U8.SDK.SDKMeta meta, System.Int32 worldId) { }
        private System.String _MakeGetProductListV2Param(U8.SDK.SDKMeta meta) { }
        private System.String _MakeLegacyConfirmOrderParam(System.String uid, System.String orderId, System.String extension) { }
        private System.String _MakeUpgradeGuestParam(System.String uid, System.String accountExt, System.String guestExt) { }
        private System.String _SignRequest(System.Collections.Generic.Dictionary<System.String,System.Object> param) { }
        private System.Void _AddDeviceIDsToRequest(System.Collections.Generic.Dictionary<System.String,System.Object> paramDict) { }
        private System.Collections.IEnumerator SDKInterfaceAuthV2SessionToken(U8.SDK.SDKMeta meta, System.String channelToken, U8.SDK.SDKPromiseWithResult<U8.SDK.U8LoginV2Result> promise) { }
        private System.Collections.IEnumerator SDKInterfaceAuthV2OAuth2Code(System.String sessionToken, U8.SDK.SDKPromiseWithResult<U8.SDK.U8GrantResult> promise, System.Action onSessionInvalid) { }
        private U8.SDK.SDKPromise<U8.SDK.U8ConfirmOrderResult> SDKInterfaceConfirmOrderU1(System.String orderId, System.String extension) { }
        private U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ServerInfo>> SDKInterFaceGetServerList(System.String sessionToken) { }
        private U8.SDK.SDKPromise<U8.SDK.U8ConfirmServerResult> SDKInterFaceConfirmServer(System.String sessionToken, System.String serverId) { }
        private U8.SDK.SDKPromise<U8.SDK.U8OrderInfo> SDKInterfaceCreateOrderU1(System.String sessionToken, System.String productId, System.String signParams) { }
        private System.String _MakeGrantParam(System.String sessionToken, System.Int32 type, System.String captcha) { }
        private System.Collections.IEnumerator _AuthV2GrantImpl(System.String sessionToken, U8.SDK.SDKPromiseWithResult<U8.SDK.U8GrantResult> promise, System.Action onSessionInvalid) { }
        private System.String _MakeCheckOrderV1Param(System.String orderId, System.String extension) { }
        private System.String _MakeConfirmOrderV1Param(System.String orderId) { }
        private System.Collections.IEnumerator _ConfirmOrderU1Coroutine(System.String orderId, System.String extension, U8.SDK.SDKPromise<U8.SDK.U8ConfirmOrderResult> promise) { }
        private System.Collections.IEnumerator _PollOrderStatusCoroutine(System.String orderId, System.String extension, U8.SDK.SDKPromise<U8.SDK.U8ConfirmOrderResult> promise) { }
        private System.Collections.IEnumerator _GetServerListCoroutine(System.String paramStr, U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ServerInfo>> promise) { }
        private System.Collections.IEnumerator _ConfirmServerListCoroutine(System.String paramStr, System.String serverId, U8.SDK.SDKPromise<U8.SDK.U8ConfirmServerResult> promise) { }
        private System.Collections.IEnumerator _SendCreateOrderU1Coroutine(System.String paramStr, U8.SDK.SDKPromise<U8.SDK.U8OrderInfo> promise) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200002A
    public class DataConsts
    {
        // Fields
        public static System.Int32 U8_MSG_TYPE_GAME_VERSION_UPGRADE;        // 0x0
        public static System.Int32 U8_MSG_TYPE_IF_MTP_ENABLED;        // 0x0
        public static System.Int32 U8_MSG_TYPE_DEVICE_ID;        // 0x0
        public static System.Int32 U8_MSG_TYPE_TRACKINGIO_DEVICE_ID;        // 0x0
        public static System.Int32 U8_MSG_TYPE_OVER_GAME_VERSION_UPGRADE;        // 0x0
        public static System.Int32 U8_MSG_TYPE_INIT_LICENSE;        // 0x0
        public static System.Int32 U8_SET_DATA_APPETIZER;        // 0x0
        public static System.Int32 U8_SET_DATA_GUEST_CAPTCHA;        // 0x0
        public static System.Int32 U8_SET_DATA_BI_U8_LOGIN;        // 0x0
        public static System.Int32 U8_SET_DATA_BI_GS_LOGIN;        // 0x0
        public static System.Int32 U8_SET_DATA_BI_START_GAME;        // 0x0
        public static System.Int32 U8_SET_DATA_BI_STOP_GAME;        // 0x0
        public static System.Int32 U8_SET_DATA_BI_INIT;        // 0x0
        public static System.Int32 U8_SET_DATA_TRACKINGIO_SET;        // 0x0
        public static System.Int32 U8_SET_DATA_CLIP_BOARD;        // 0x0
        public static System.Int32 U8_SET_DATA_WEIBO_ROLE;        // 0x0
        public static System.Int32 U8_SET_DATA_BAIDU_ROLE;        // 0x0
        public static System.Int32 U8_SET_DATA_BAIDU_PAY;        // 0x0
        public static System.Int32 U8_SET_DATA_NEWLENS_INIT;        // 0x0
        public static System.Int32 U8_SET_DATA_NEWLENS_ID;        // 0x0
        public static System.Int32 U8_SET_DATA_CLOUD_AUTH;        // 0x0
        public static System.Int32 U8_SET_DATA_INIT_CLOUD_AUTH;        // 0x0
        public static System.Int32 U8_SET_DATA_TOUTIAO_LOGIN;        // 0x0
        public static System.Int32 U8_SET_DATA_TOUTIAO_ROLE;        // 0x0
        public static System.Int32 U8_SET_DATA_TOUTIAO_PAY;        // 0x0
        public static System.Int32 U8_SET_DATA_TOUTIAO_LOGOUT;        // 0x0
        public static System.Int32 U8_SET_DATA_UNBIND_GRANT;        // 0x0
        public static System.Int32 U8_SET_DATA_INIT_LICENSE;        // 0x0
        public static System.Int32 U8_SET_DATA_INIT_HGSDK;        // 0x0

    }

    // TypeToken: 0x200002B
    public class U8ErrorCode
    {
        // Fields
        public static System.Int32 DESERIALIZE_ERROR_CODE;        // 0x0
        public static System.Int32 CAPTCHA_ERROR_BASE;        // 0x0
        public static System.Int32 AUTH_PARSE_DATA_FAILED;        // 0x0
        public static System.Int32 VERIFY_ACCOUNT_UID_EMPTY;        // 0x0
        public static System.Int32 AUTHV2_SESSION_EMPTY;        // 0x0

    }

    // TypeToken: 0x200002C
    public struct SDKExtraData
    {
        // Fields
        public static readonly U8.SDK.SDKExtraData EMPTY;        // 0x0
        public System.Int32 code;        // 0x10
        public System.Collections.Generic.Dictionary<System.String,System.Object> msg;        // 0x18

        // Methods
        private System.Boolean IsEmpty() { }
        private U8.SDK.SDKExtraData FromJson(System.String jsonStr) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200002D
    public class SDKExternalToolsShortcut : SDKExternalTools
    {
        // Methods
        private U8.SDK.SDKPromise<U8.SDK.U8LoginResult> SendSDKAuthRequest(System.String paramStr) { }
        private U8.SDK.SDKPromise<System.Object> SendSDKVerifyAccountRequest(System.String paramStr) { }
        private U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ProductInfo>> SendGetProductListRequest(System.String paramStr) { }
        private U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ProductInfo>> SendGetProductListRequestV2(System.String paramStr) { }
        private U8.SDK.SDKPromise<System.Object> SendUpgradeGuestRequest(System.String paramStr) { }
        private U8.SDK.SDKPromise<U8.SDK.U8CaptchaResult> SendSDKGetCaptchaRequest(System.String paramStr) { }
        private U8.SDK.SDKPromise<U8.SDK.U8ConfirmOrderResult> SendConfirmOrderRequest(System.String paramStr) { }
        private System.Collections.IEnumerator _ConfirmOrderCoroutine(U8.SDK.SDKPromise<U8.SDK.U8ConfirmOrderResult> promise, System.String paramStr) { }
        private System.Collections.Generic.Dictionary<System.String,System.String> GetDeviceIDs() { }
        private System.String GetU8DeviceID() { }
        private System.Void InjectRequestHeaders(System.Collections.Generic.Dictionary<System.String,System.String>& headers, U8.SDK.SDKExternalToolsShortcut.RequestHeaderInjectOptions policy) { }
        private System.String _AuthUrl() { }
        private System.String _CaptchaUrl() { }
        private System.String _GetProductListUrl() { }
        private System.String _GetProductListV1Url() { }
        private System.String _CreateOrderUrl() { }
        private System.String _ConfirmOrderUrl() { }
        private System.String _UpdateGuestUserUrl() { }
        private System.String _VerifyAccountUrl() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003F
    public class U8SDKInterface
    {
        // Fields
        public static System.String KEYWORD_DISABLE;        // 0x0
        private static System.String KEY_CACHED_UID;        // 0x0
        private static U8.SDK.U8SDKInterface m_instance;        // 0x0
        protected U8.SDK.SDKPromiseWrapper m_initPromise;        // 0x10
        protected U8.SDK.SDKPromiseWrapper m_loginPromise;        // 0x18
        protected U8.SDK.SDKPromiseWrapper m_logoutPromise;        // 0x20
        protected U8.SDK.SDKPromiseWrapper m_payPromise;        // 0x28
        private U8.SDK.U8LoginResult m_loginResult;        // 0x30
        private U8.SDK.U8SDKInterface.AuthStatus m_authStatus;        // 0x68
        private System.String m_loginExtV1;        // 0x88
        private U8.SDK.U8MockLogin m_mockLogin;        // 0x90
        private System.Collections.Generic.List<U8.SDK.U8ProductInfo> m_productList;        // 0xA0
        private System.Nullable<System.Boolean> m_isNativePlugin;        // 0xA8
        private U8.SDK.SDKMeta m_sdkMeta;        // 0xB0
        private U8.SDK.U8SDKInterface.V2LoginStatus m_loginStatusV2;        // 0xB8
        private static System.Int32 U8_SDK_SET_DATA_SET_SESSION_TOKEN;        // 0x8
        private static System.Int32 U8_SDK_SET_DATA_GET_PRODUCT_LIST;        // 0xC
        private static U8.SDK.U8SDKInterface.ReceiverProductListResult onReceiverProductlist;        // 0x10
        private U8.SDK.U8SDKInterface.GameServerTimeCache m_gameServerTimeCache;        // 0xC0

        // Methods
        private U8.SDK.U8SDKInterface get_Instance() { }
        private U8.SDK.SDKMeta _InternalSDKMeta() { }
        private System.Boolean get_isNativePlugin() { }
        private System.Void CallbackInitSuc(System.String extConfigs) { }
        private System.Void CallbackInitFail(System.String info) { }
        private System.Void CallbackLoginSuc(System.String extension) { }
        private System.Void CallbackLoginFail(System.String info) { }
        private System.Void CallbackLogout() { }
        private System.Void CallbackSwitchAccount() { }
        private System.Void CallbackPaySuc(System.String jsonData) { }
        private System.Void CallbackPayFail(System.String failMsg) { }
        private System.String get_uid() { }
        private System.String get_channel() { }
        private System.Int32 get_worldId() { }
        private System.String get_cachedUid() { }
        private System.Void set_cachedUid(System.String value) { }
        private System.String get_token() { }
        private System.String get_oauth2token() { }
        private System.String get_oauth2code() { }
        private System.Collections.Generic.List<U8.SDK.U8ProductInfo> get_productList() { }
        private System.Boolean get_isInterfaceDisabled() { }
        private System.String PublicLoadExtraConfig() { }
        private U8.SDK.U8SDKInterface.ReceiverProductListResult getOnReceiverProductlist() { }
        private U8.SDK.SDKPromise<System.String> PublicInit() { }
        private U8.SDK.SDKPromise<System.String> V2PublicInit(System.String env) { }
        private U8.SDK.SDKPromise<System.String> PublicLogin() { }
        private System.Void _MarkMockLogin(U8.SDK.U8MockLogin mockLogin) { }
        private U8.SDK.SDKPromise<U8.SDK.U8LoginResult> PublicAuth(System.String captcha) { }
        private System.Void _onLoginSuc(System.String uid, System.Boolean isNew) { }
        private U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ProductInfo>> PublicGetProductList() { }
        private U8.SDK.SDKPromise<U8.SDK.U8ProductsResult> PublicGetProductListV2() { }
        private U8.SDK.SDKPromise<U8.SDK.U8LoginResult> _DoMockLoginAuth() { }
        private U8.SDK.SDKPromise<U8.SDK.U8CaptchaResult> PublicGetCaptcha() { }
        private System.Void ClearAuthStatus() { }
        private System.Void ClearLoginStatus() { }
        private System.Void _ConfirmAuthResult(U8.SDK.U8SDKInterface.AuthStatus result) { }
        private U8.SDK.SDKPromise<System.Object> PublicVerifyAuth() { }
        private U8.SDK.SDKPromise<System.Object> _MockVerifyAccount() { }
        private U8.SDK.SDKPromise<System.Object> PublicLogout() { }
        private U8.SDK.SDKPromise<U8.SDK.U8OrderInfo> PublicCreateOrder(System.String productId, System.String signParams) { }
        private U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ServerInfo>> PublicGetServerList() { }
        private U8.SDK.SDKPromise<U8.SDK.U8ConfirmServerResult> PubliceConfirmServer(System.String serverId) { }
        private U8.SDK.SDKPromise<U8.SDK.U8PayResult> PublicPay(System.Int32 storeId, U8.SDK.U8OrderInfo orderInfo) { }
        private System.Void _OnNativePayFulfilled(System.Int64 revenue) { }
        private U8.SDK.SDKPromise<U8.SDK.U8ConfirmOrderResult> PublicConfirmOrder(System.String orderId, System.String extension) { }
        private U8.SDK.SDKPromise<System.Object> LegacyUpgradeGuest(System.String targetUid, System.String guestExt, System.String accountExt) { }
        private System.String get_sdkUid() { }
        private System.Boolean _TryGetProduct(System.Int32 storeId, U8.SDK.U8ProductInfo& productInfo) { }
        private U8.SDK.U8PayParams _GeneratePayParams(U8.SDK.U8ProductInfo productInfo, U8.SDK.U8OrderInfo orderInfo) { }
        private U8.SDK.SDKPromise<U8.SDK.U8PayResult> Test_NativePay() { }
        private U8.SDK.SDKPromise<U8.SDK.U8PayResult> _NativePay(U8.SDK.U8PayParams payParams) { }
        private T GetValueSafe(System.Collections.Generic.Dictionary<System.String,System.Object> dict, System.String key, T defVal) { }
        private U8.SDK.SDKMeta PublicLoadSDKMeta() { }
        private System.Boolean TryFindInfoByProductId(System.String productId, U8.SDK.U8ProductInfo& outInfo) { }
        private System.String GenU8Sign(System.Collections.Generic.IDictionary<System.String,System.String> signDict, System.String appKey) { }
        private System.String _BinaryToHexString(System.Byte[] binary, System.Int32 index, System.Int32 length) { }
        private U8.SDK.SDKPromise<System.String> AuthV2(System.String captcha) { }
        private System.String LoadExtraConfig() { }
        private System.Void V2Init(System.String env) { }
        private System.Void Init() { }
        private System.Void Login() { }
        private System.Void LoginCustom(System.String customData) { }
        private System.Void SwitchLogin() { }
        private System.Boolean Logout() { }
        private System.Boolean ShowAccountCenter() { }
        private System.Void SubmitGameData(U8.SDK.U8ExtraGameData data) { }
        private System.Boolean SDKExit() { }
        private System.Void Pay(U8.SDK.U8PayParams data) { }
        private System.Boolean IsSupportExit() { }
        private System.Boolean IsSupportAccountCenter() { }
        private System.Boolean IsSupportLogout() { }
        private System.Boolean IsSupportLogin() { }
        private System.Void SetData(System.Int32 type, System.String paramJson) { }
        private System.String GetData(System.Int32 type, System.String paramJson) { }
        private U8.SDK.SDKMeta LoadSDKMeta() { }
        private System.Boolean IsNativePlugin() { }
        private System.Collections.IEnumerator _NextFrameCoroutine(System.Action call) { }
        private System.Void InvokeNextFrame(System.Action action) { }
        private System.Void InvokeCoroutine(System.Collections.IEnumerator coroutine) { }
        private System.String EncodeGameData(U8.SDK.U8ExtraGameData data) { }
        private System.String EncodePayParams(U8.SDK.U8PayParams data) { }
        private System.Void add_onReceiverProductlist(U8.SDK.U8SDKInterface.ReceiverProductListResult value) { }
        private System.Void remove_onReceiverProductlist(U8.SDK.U8SDKInterface.ReceiverProductListResult value) { }
        private System.String get_sessionToken() { }
        private U8.SDK.U8SDKInterface.GameServerTimeCache get_serverCacheTime() { }
        private System.Void set_serverCacheTime(U8.SDK.U8SDKInterface.GameServerTimeCache value) { }
        private U8.SDK.SDKPromise<System.String> V2PublicLogin() { }
        private U8.SDK.SDKPromise<U8.SDK.U8AuthV2Result> V2PublicAuth() { }
        private U8.SDK.SDKPromise<U8.SDK.U8OrderInfo> U1PublicCreateOrder(System.String productId, System.String signParams) { }
        private U8.SDK.SDKPromise<System.Collections.Generic.List<U8.SDK.U8ServerInfo>> U1PublicGetServerList() { }
        private U8.SDK.SDKPromise<U8.SDK.U8ConfirmServerResult> U1PublicConfirmServer(System.String serverId) { }
        private U8.SDK.SDKPromise<U8.SDK.U8ConfirmOrderResult> U1PublicConfirmOrder(System.String orderId, System.String extension) { }
        private U8.SDK.SDKPromise<U8.SDK.U8AuthV2Result> _DoMockAuthV2() { }
        private System.Collections.IEnumerator _LoginV2Coroutine(U8.SDK.SDKPromise<System.String> promise) { }
        private System.Void _OnSessionTokenInvalid() { }
        private System.Collections.IEnumerator _AuthV2Coroutine(U8.SDK.SDKPromise<U8.SDK.U8AuthV2Result> promise) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }
        private System.Void <PublicLogout>b__64_0() { }
        private System.Void <PublicLogout>b__64_1() { }
        private System.Void <PublicLogout>b__64_2() { }

    }

    // TypeToken: 0x2000059
    public struct SDKError
    {
        // Fields
        public static System.Int32 NetworkRequestFailed;        // 0x0
        public static System.Int32 ConcurrentCall;        // 0x0
        public static System.Int32 ErrorNeedExit;        // 0x0
        private System.String <code>k__BackingField;        // 0x10
        private System.String <msg>k__BackingField;        // 0x18

        // Methods
        private System.String get_code() { }
        private System.Void set_code(System.String value) { }
        private System.String get_msg() { }
        private System.Void set_msg(System.String value) { }
        private System.Void .ctor(System.String content) { }

    }

    // TypeToken: 0x200005A
    public struct U8MockLogin
    {
        // Fields
        public static readonly U8.SDK.U8MockLogin EMPTY;        // 0x0
        public System.String uid;        // 0x10
        public System.String token;        // 0x18

        // Methods
        private System.Boolean IsEmpty() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200005B
    public class U8ProductInfo
    {
        // Fields
        public System.String app_id;        // 0x10
        public System.String channel_id;        // 0x18
        public System.Int32 world_id;        // 0x20
        public System.Int32 store_id;        // 0x24
        public System.String product_id;        // 0x28
        public System.String desc;        // 0x30
        public System.String name;        // 0x38
        public System.Int32 type;        // 0x40
        public System.Int64 price;        // 0x48
        public System.String extra_data;        // 0x50
        public System.String appstore_id;        // 0x58
        public System.String channel_product_id;        // 0x60
        public System.String display_price;        // 0x68

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005C
    public class U8ProductsResult
    {
        // Fields
        public System.Int32 status;        // 0x10
        public System.Collections.Generic.List<U8.SDK.U8ProductInfo> u8Products;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005D
    public class U8ServerInfo
    {
        // Fields
        public System.String serverId;        // 0x10
        public System.String serverName;        // 0x18
        public System.String serverDomain;        // 0x20
        public System.Boolean defaultChoose;        // 0x28
        public System.String roleId;        // 0x30
        public System.String nickName;        // 0x38
        public System.Int64 level;        // 0x40
        public System.String extension;        // 0x48

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005E
    public class U8ServerErrorInfo
    {
        // Fields
        public System.Int32 status;        // 0x10
        public System.Int32 errorCode;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005F
    public class U8OrderInfo
    {
        // Fields
        public System.String orderId;        // 0x10
        public System.String channelProductCode;        // 0x18
        public System.String productName;        // 0x20
        public System.String productDesc;        // 0x28
        public System.Int64 amount;        // 0x30
        public System.String extension;        // 0x38

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000060
    public class U8PayParams
    {
        // Fields
        private System.String <productId>k__BackingField;        // 0x10
        private System.String <productName>k__BackingField;        // 0x18
        private System.String <productDesc>k__BackingField;        // 0x20
        private System.Int64 <price>k__BackingField;        // 0x28
        private System.Int32 <buyNum>k__BackingField;        // 0x30
        private System.Int32 <coinNum>k__BackingField;        // 0x34
        private System.String <serverId>k__BackingField;        // 0x38
        private System.String <serverName>k__BackingField;        // 0x40
        private System.String <roleId>k__BackingField;        // 0x48
        private System.String <roleName>k__BackingField;        // 0x50
        private System.Int32 <roleLevel>k__BackingField;        // 0x58
        private System.String <vip>k__BackingField;        // 0x60
        private System.String <orderID>k__BackingField;        // 0x68
        private System.String <worldID>k__BackingField;        // 0x70
        private System.String <token>k__BackingField;        // 0x78
        private System.String <appKey>k__BackingField;        // 0x80
        private System.String <extension>k__BackingField;        // 0x88
        private System.String <addition>k__BackingField;        // 0x90

        // Methods
        private System.String get_productId() { }
        private System.Void set_productId(System.String value) { }
        private System.String get_productName() { }
        private System.Void set_productName(System.String value) { }
        private System.String get_productDesc() { }
        private System.Void set_productDesc(System.String value) { }
        private System.Int64 get_price() { }
        private System.Void set_price(System.Int64 value) { }
        private System.Int32 get_buyNum() { }
        private System.Void set_buyNum(System.Int32 value) { }
        private System.Int32 get_coinNum() { }
        private System.Void set_coinNum(System.Int32 value) { }
        private System.String get_serverId() { }
        private System.Void set_serverId(System.String value) { }
        private System.String get_serverName() { }
        private System.Void set_serverName(System.String value) { }
        private System.String get_roleId() { }
        private System.Void set_roleId(System.String value) { }
        private System.String get_roleName() { }
        private System.Void set_roleName(System.String value) { }
        private System.Int32 get_roleLevel() { }
        private System.Void set_roleLevel(System.Int32 value) { }
        private System.String get_vip() { }
        private System.Void set_vip(System.String value) { }
        private System.String get_orderID() { }
        private System.Void set_orderID(System.String value) { }
        private System.String get_worldID() { }
        private System.Void set_worldID(System.String value) { }
        private System.String get_token() { }
        private System.Void set_token(System.String value) { }
        private System.String get_appKey() { }
        private System.Void set_appKey(System.String value) { }
        private System.String get_extension() { }
        private System.Void set_extension(System.String value) { }
        private System.String get_addition() { }
        private System.Void set_addition(System.String value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000061
    public class U8ExtraGameData
    {
        // Fields
        public static System.Int32 TYPE_SELECT_SERVER;        // 0x0
        public static System.Int32 TYPE_CREATE_ROLE;        // 0x0
        public static System.Int32 TYPE_ENTER_GAME;        // 0x0
        public static System.Int32 TYPE_LEVEL_UP;        // 0x0
        public static System.Int32 TYPE_EXIT_GAME;        // 0x0
        public static System.Int32 TYPE_STOP_GAME;        // 0x0
        public static System.Int32 TYPE_APP_START;        // 0x0
        public static System.Int32 TYPE_USER_LOGIN;        // 0x0
        public static System.Int32 TYPE_USER_LOGOUT;        // 0x0
        public static System.Int32 TYPE_PAY_SUCCESS;        // 0x0
        public static System.Int32 TYPE_CUSTOM_EVENT;        // 0x0
        private System.Int32 <dataType>k__BackingField;        // 0x10
        private System.String <uid>k__BackingField;        // 0x18
        private System.String <roleID>k__BackingField;        // 0x20
        private System.String <roleName>k__BackingField;        // 0x28
        private System.String <roleLevel>k__BackingField;        // 0x30
        private System.Int32 <serverID>k__BackingField;        // 0x38
        private System.String <serverName>k__BackingField;        // 0x40
        private System.String <channel>k__BackingField;        // 0x48
        private System.String <subChannel>k__BackingField;        // 0x50
        private System.Boolean <isNewUser>k__BackingField;        // 0x58
        private System.Int64 <revenue>k__BackingField;        // 0x60
        private System.String <customEventName>k__BackingField;        // 0x68
        private System.String <customEventParams>k__BackingField;        // 0x70

        // Methods
        private System.Int32 get_dataType() { }
        private System.Void set_dataType(System.Int32 value) { }
        private System.String get_uid() { }
        private System.Void set_uid(System.String value) { }
        private System.String get_roleID() { }
        private System.Void set_roleID(System.String value) { }
        private System.String get_roleName() { }
        private System.Void set_roleName(System.String value) { }
        private System.String get_roleLevel() { }
        private System.Void set_roleLevel(System.String value) { }
        private System.Int32 get_serverID() { }
        private System.Void set_serverID(System.Int32 value) { }
        private System.String get_serverName() { }
        private System.Void set_serverName(System.String value) { }
        private System.String get_channel() { }
        private System.Void set_channel(System.String value) { }
        private System.String get_subChannel() { }
        private System.Void set_subChannel(System.String value) { }
        private System.Boolean get_isNewUser() { }
        private System.Void set_isNewUser(System.Boolean value) { }
        private System.Int64 get_revenue() { }
        private System.Void set_revenue(System.Int64 value) { }
        private System.String get_customEventName() { }
        private System.Void set_customEventName(System.String value) { }
        private System.String get_customEventParams() { }
        private System.Void set_customEventParams(System.String value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000062
    public struct U8LoginResult
    {
        // Fields
        public static readonly U8.SDK.U8LoginResult EMPTY;        // 0x0
        public System.Int32 result;        // 0x10
        public System.String uid;        // 0x18
        public System.String channelUid;        // 0x20
        public System.String token;        // 0x28
        public System.String extension;        // 0x30
        public System.Boolean isGuest;        // 0x38
        public System.Boolean isNew;        // 0x39
        public System.String error;        // 0x40

        // Methods
        private System.String ToString() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000063
    public struct U8LoginRejectInfo
    {
        // Fields
        public System.String error;        // 0x10
        public System.Boolean needCaptcha;        // 0x18
        public System.String captcha;        // 0x20
        public System.String captchaTips;        // 0x28

    }

    // TypeToken: 0x2000064
    public struct U8ProductError
    {
        // Fields
        public System.Int32 status;        // 0x10
        public System.Int32 errorCode;        // 0x14

    }

    // TypeToken: 0x2000065
    public struct U8CaptchaResult
    {
        // Fields
        public System.Int32 result;        // 0x10
        public System.String data;        // 0x18

    }

    // TypeToken: 0x2000066
    public struct U8PayConfirmResult
    {
        // Fields
        public U8.SDK.PayConfirmStatus payState;        // 0x10

    }

    // TypeToken: 0x2000067
    public struct PayConfirmStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static U8.SDK.PayConfirmStatus FAILED;        // 0x0
        public static U8.SDK.PayConfirmStatus THIRD_PARTY_PENDING;        // 0x0
        public static U8.SDK.PayConfirmStatus GAME_SERVER_PENDING;        // 0x0
        public static U8.SDK.PayConfirmStatus SUCCEED;        // 0x0
        public static U8.SDK.PayConfirmStatus ORDER_NOT_EXIST;        // 0x0

    }

    // TypeToken: 0x2000068
    public struct PayResultStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static U8.SDK.PayResultStatus SUCCEED;        // 0x0
        public static U8.SDK.PayResultStatus PENDING;        // 0x0

    }

    // TypeToken: 0x2000069
    public struct PayFailStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static U8.SDK.PayFailStatus UNKNOWN;        // 0x0
        public static U8.SDK.PayFailStatus CANCELED;        // 0x0
        public static U8.SDK.PayFailStatus ERROR;        // 0x0
        public static U8.SDK.PayFailStatus HALT;        // 0x0

    }

    // TypeToken: 0x200006A
    public class U8ConfirmServerResult
    {
        // Fields
        public System.Int32 status;        // 0x10
        public System.String message;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006B
    public struct U8ConfirmOrderStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static U8.SDK.U8ConfirmOrderStatus NONE;        // 0x0
        public static U8.SDK.U8ConfirmOrderStatus INTERNAL_ERROR;        // 0x0
        public static U8.SDK.U8ConfirmOrderStatus TIMEOUT;        // 0x0
        public static U8.SDK.U8ConfirmOrderStatus INVALID_ORDER;        // 0x0
        public static U8.SDK.U8ConfirmOrderStatus SUCCEED;        // 0x0

    }

    // TypeToken: 0x200006C
    public class U8ConfirmOrderResult
    {
        // Fields
        public U8.SDK.U8ConfirmOrderStatus status;        // 0x10
        public System.String message;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006D
    public struct U8PayFailMsg
    {
        // Fields
        public static U8.SDK.U8PayFailMsg EMPTY;        // 0x0
        public U8.SDK.PayFailStatus status;        // 0x10
        public System.String message;        // 0x18
        public System.String extension;        // 0x20

        // Methods
        private U8.SDK.U8PayFailMsg FromJson(System.String jsonStr) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200006E
    public struct U8PayResult
    {
        // Fields
        public static readonly U8.SDK.U8PayResult EMPTY;        // 0x0
        public U8.SDK.PayResultStatus status;        // 0x10
        public System.String outTradeNo;        // 0x18
        public System.String extension;        // 0x20

        // Methods
        private U8.SDK.U8PayResult FromJson(System.String jsonData) { }
        private System.String ToString() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200006F
    public struct U8GetDataResult
    {
        // Fields
        public static readonly U8.SDK.U8GetDataResult EMPTY;        // 0x0
        public System.Int32 code;        // 0x10
        public System.String msg;        // 0x18

        // Methods
        private System.Boolean IsSuc() { }
        private U8.SDK.U8GetDataResult FromJson(System.String rawJson) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000070
    public class SDKInterfaceDefault : U8SDKInterface
    {
        // Methods
        private System.String LoadExtraConfig() { }
        private System.Void V2Init(System.String env) { }
        private System.Void Init() { }
        private System.Void Login() { }
        private System.Void LoginCustom(System.String customData) { }
        private System.Void SwitchLogin() { }
        private System.Boolean Logout() { }
        private System.Boolean ShowAccountCenter() { }
        private System.Void SubmitGameData(U8.SDK.U8ExtraGameData data) { }
        private System.Boolean SDKExit() { }
        private System.Void Pay(U8.SDK.U8PayParams data) { }
        private System.Boolean IsSupportLogin() { }
        private System.Boolean IsSupportExit() { }
        private System.Boolean IsSupportAccountCenter() { }
        private System.Boolean IsSupportLogout() { }
        private System.Void SetData(System.Int32 type, System.String paramJson) { }
        private System.String GetData(System.Int32 type, System.String paramJson) { }
        private U8.SDK.SDKMeta LoadSDKMeta() { }
        private System.Boolean IsNativePlugin() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000071
    public class SDKInterfaceWIN : U8SDKInterface
    {
        // Fields
        private System.Int32 actionIndex;        // 0xD8
        private static System.Collections.Generic.Dictionary<System.Int32,System.Action<System.String>> dictAction;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void Finalize() { }
        private System.Int32 AddAction(System.Action<System.String> action) { }
        private System.Void DataActionCallback(System.Int32 index, System.String paramValue) { }
        private System.Void ASyncDataActionCallback(System.Int32 index, System.String paramValue) { }
        private System.Void U8SDKSendMessage(System.String methodName, System.String paramValue) { }
        private System.Void HGU8SDKInitLibrary(System.String windowText, System.Int64 windowHandle) { }
        private System.Int32 HGU8SDKSetUserDataPath(System.String path) { }
        private System.Void HGU8SDKUnInitLibrary() { }
        private System.Void HGU8SDKInitDatacallback(U8.SDK.SDKInterfaceWIN.DataCallback Callback, U8.SDK.SDKInterfaceWIN.DataCallback asyncCallback) { }
        private System.Void HGU8SDKInitSendMessage(U8.SDK.SDKInterfaceWIN.U8SDKSendMessageCallback callback) { }
        private System.Void HGU8SDKInit() { }
        private System.Void HGU8SDKV2Init(System.String env) { }
        private System.Void HGU8SDKLogin() { }
        private System.Void HGU8SDKLoginCustom(System.String json) { }
        private System.Void HGU8SDKSwitchLogin() { }
        private System.Int32 HGU8SDKLogout() { }
        private System.Int32 HGU8SDKShowAccountCenter() { }
        private System.Void HGU8SDKPay(System.String json) { }
        private System.Void HGU8SDKSubmitGameData(System.String json) { }
        private System.Int32 HGU8SDKIsSupportExit() { }
        private System.Int32 HGU8SDKIsSupportAccountCenter() { }
        private System.Int32 HGU8SDKIsSupportLogin() { }
        private System.Int32 HGU8SDKIsSupportLogout() { }
        private System.Void HGU8SDKGetSDKMeta(System.Int32 index) { }
        private System.Void HGU8SDKSetData(System.Int32 code, System.String paramJson) { }
        private System.Void HGU8SDKGetData(System.Int32 code, System.String paramJson, System.Int32 index) { }
        private System.Int32 HGU8SDKIsNativePlugin() { }
        private System.Void HGU8SDKLoadExtraConfig(System.Int32 index) { }
        private System.String LoadExtraConfig() { }
        private System.Void V2Init(System.String env) { }
        private System.Void Init() { }
        private System.Void Login() { }
        private System.Boolean Logout() { }
        private System.Void LoginCustom(System.String customData) { }
        private System.Void SwitchLogin() { }
        private System.Void SubmitGameData(U8.SDK.U8ExtraGameData data) { }
        private System.Void SetData(System.Int32 type, System.String paramJson) { }
        private System.String GetData(System.Int32 type, System.String paramJson) { }
        private System.Boolean ShowAccountCenter() { }
        private System.Boolean SDKExit() { }
        private System.Void Pay(U8.SDK.U8PayParams data) { }
        private System.Boolean IsSupportExit() { }
        private System.Boolean IsSupportAccountCenter() { }
        private System.Boolean IsSupportLogin() { }
        private System.Boolean IsSupportLogout() { }
        private U8.SDK.SDKMeta LoadSDKMeta() { }
        private System.Boolean IsNativePlugin() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000077
    public class SDKMeta
    {
        // Fields
        public System.String appID;        // 0x10
        public System.String appKey;        // 0x18
        public System.String channel;        // 0x20
        public System.String token;        // 0x28
        public System.String worldId;        // 0x30
        public System.String extension;        // 0x38
        public System.String appCode;        // 0x40

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String jsonData) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000078
    public interface ISDKPromise
    {
        // Methods
        private System.Void Fulfill(System.Object param) { }
        private System.Void Reject(System.Object reason) { }

    }

    // TypeToken: 0x2000079
    public class SDKPromise`1, ISDKPromise
    {
        // Fields
        public System.Action<Param> onFulfilled;        // 0x0
        public System.Action<System.Object> onRejected;        // 0x0

        // Methods
        private System.Void Fulfill(System.Object param) { }
        private System.Void Reject(System.Object reason) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007A
    public class SDKPromiseWithResult`1 : SDKPromise`1
    {
        // Fields
        private Param <result>k__BackingField;        // 0x0
        private System.Object <rejectInfo>k__BackingField;        // 0x0

        // Methods
        private Param get_result() { }
        private System.Void set_result(Param value) { }
        private System.Object get_rejectInfo() { }
        private System.Void set_rejectInfo(System.Object value) { }
        private System.Void Fulfill(System.Object param) { }
        private System.Void Reject(System.Object reason) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007B
    public class SDKPromiseEnumerator`1
    {
        // Fields
        private U8.SDK.SDKPromiseEnumerator.State<T> m_state;        // 0x0
        private T <result>k__BackingField;        // 0x0
        private System.Object <reject>k__BackingField;        // 0x0

        // Methods
        private System.Boolean get_isFulfilled() { }
        private T get_result() { }
        private System.Void set_result(T value) { }
        private System.Object get_reject() { }
        private System.Void set_reject(System.Object value) { }
        private System.Collections.IEnumerator Yield() { }
        private System.Void .ctor(U8.SDK.SDKPromise<T> promise) { }
        private System.Void _OnFulfilled(T result) { }
        private System.Void _OnRejected(System.Object rejectInfo) { }

    }

    // TypeToken: 0x200007E
    public class SDKPromiseWrapper
    {
        // Fields
        private U8.SDK.ISDKPromise m_promise;        // 0x10

        // Methods
        private T EnsurePromise() { }
        private System.Void Fulfill(System.Object param) { }
        private System.Void Reject(System.Object reason) { }
        private System.Void _Clear() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007F
    public class SDKPromiseExtensions
    {
        // Methods
        private System.Void RejectWithString(U8.SDK.ISDKPromise promise, System.String errorInfo) { }
        private System.Void FulfillWithType(U8.SDK.SDKPromise<T> promise, T param) { }

    }

    // TypeToken: 0x2000080
    public class U8SDKTickEvent : MonoBehaviour
    {
        // Methods
        private System.Void Update() { }
        private System.Void HGU8SDKTickEvent() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000081
    public class U8TickEventManager
    {
        // Fields
        private UnityEngine.GameObject tickGameObject;        // 0x10
        private U8.SDK.U8SDKTickEvent tickEvent;        // 0x18
        private static U8.SDK.U8TickEventManager instanceMangaer;        // 0x0

        // Methods
        private U8.SDK.U8TickEventManager get_InstanceMangaer() { }
        private System.Void InitTickEvent() { }
        private System.Void UnInitTickEvent() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000082
    public class U8LoginV2Result
    {
        // Fields
        public System.String token;        // 0x10
        public System.String uid;        // 0x18
        public System.Boolean isNew;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000083
    public class U8AuthV2Result
    {
        // Fields
        public System.String uid;        // 0x10
        public System.String oauth2Code;        // 0x18
        public System.String oauth2Token;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000084
    public class U8GrantResult
    {
        // Fields
        public System.String uid;        // 0x10
        public System.String code;        // 0x18
        public System.String token;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000085
    public class U8SDKCallback : MonoBehaviour
    {
        // Fields
        private static U8.SDK.U8SDKCallback m_instance;        // 0x0
        private static System.Object m_lock;        // 0x8

        // Methods
        private U8.SDK.U8SDKCallback InitCallback() { }
        private System.Void OnInitSuc(System.String extConfigs) { }
        private System.Void OnInitFail(System.String info) { }
        private System.Void OnLoginSuc(System.String extension) { }
        private System.Void OnLoginFail(System.String info) { }
        private System.Void OnLogout(System.String info) { }
        private System.Void OnSwitchAccount() { }
        private System.Void OnPaySuc(System.String jsonData) { }
        private System.Void OnPayFail(System.String failMsg) { }
        private System.Void OnSDKError(System.String jsonData) { }
        private System.Void OnExtraInfo(System.String jsonData) { }
        private System.Collections.IEnumerator _onLogoutNextFrameCoroutine() { }
        private T GetValueSafe(System.Collections.Generic.Dictionary<System.String,System.Object> dict, System.String key, T defVal) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

}

namespace U8.SDK.MiniJSON
{

    // TypeToken: 0x2000087
    public class Json
    {
        // Methods
        private System.Object Deserialize(System.String json) { }
        private System.String Serialize(System.Object obj) { }

    }

}

