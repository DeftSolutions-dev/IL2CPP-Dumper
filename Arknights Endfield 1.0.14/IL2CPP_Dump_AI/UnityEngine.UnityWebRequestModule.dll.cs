// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.UnityWebRequestModule.dll
// Classes:  15
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: UnityWebRequestMethod
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethodGet  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethodPost  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethodPut  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethodHead  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethodCustom  // 0x0
METHODS:
END_CLASS

CLASS: UnityWebRequestError
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestErrorOK  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestErrorUnknown  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestErrorSDKError  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestErrorUnsupportedProtocol  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestErrorMalformattedUrl  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestErrorCannotResolveProxy  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestErrorCannotResolveHost  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestErrorCannotConnectToHost  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestErrorAccessDenied  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestErrorGenericHttpError  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestErrorWriteError  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestErrorReadError  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestErrorOutOfMemory  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestErrorTimeout  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestErrorHTTPPostError  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestErrorSSLCannotConnect  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestErrorAborted  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestErrorTooManyRedirects  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestErrorReceivedNoData  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestErrorSSLNotSupported  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestErrorFailedToSendData  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestErrorFailedToReceiveData  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestErrorSSLCertificateError  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestErrorSSLCipherNotAvailable  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestErrorSSLCACertError  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestErrorUnrecognizedContentEncoding  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestErrorLoginFailed  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestErrorSSLShutdownFailed  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.UnityWebRequestErrorNoInternetConnection  // 0x0
METHODS:
END_CLASS

CLASS: Result
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Networking.UnityWebRequest.ResultInProgress  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.ResultSuccess  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.ResultConnectionError  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.ResultProtocolError  // 0x0
  public    static  UnityEngine.Networking.UnityWebRequest.ResultDataProcessingError  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.WWWForm
TYPE:  class
TOKEN: 0x2000003
FIELDS:
  private           System.Collections.Generic.List<System.Byte[]>formData  // 0x10
  private           System.Collections.Generic.List<System.String>fieldNames  // 0x18
  private           System.Collections.Generic.List<System.String>fileNames  // 0x20
  private           System.Collections.Generic.List<System.String>types  // 0x28
  private           System.Byte[]                   boundary  // 0x30
  private           System.Boolean                  containsFiles  // 0x38
  private   static  System.Byte[]                   dDash  // 0x0
  private   static  System.Byte[]                   crlf  // 0x8
  private   static  System.Byte[]                   contentTypeHeader  // 0x10
  private   static  System.Byte[]                   dispositionHeader  // 0x18
  private   static  System.Byte[]                   endQuote  // 0x20
  private   static  System.Byte[]                   fileNameField  // 0x28
  private   static  System.Byte[]                   ampersand  // 0x30
  private   static  System.Byte[]                   equal  // 0x38
METHODS:
  System.Text.Encoding get_DefaultEncoding()
  System.Collections.Generic.Dictionary<System.String,System.String> get_headers()
  System.Byte[] get_data()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.WWWTranscoder
TYPE:  class
TOKEN: 0x2000004
FIELDS:
  private   static  System.Byte[]                   ucHexChars  // 0x0
  private   static  System.Byte[]                   lcHexChars  // 0x8
  private   static  System.Byte                     urlEscapeChar  // 0x10
  private   static  System.Byte[]                   urlSpace  // 0x18
  private   static  System.Byte[]                   dataSpace  // 0x20
  private   static  System.Byte[]                   urlForbidden  // 0x28
  private   static  System.Byte                     qpEscapeChar  // 0x30
  private   static  System.Byte[]                   qpSpace  // 0x38
  private   static  System.Byte[]                   qpForbidden  // 0x40
METHODS:
  System.Byte Hex2Byte(System.Byte[] b, System.Int32 offset)
  System.Void Byte2Hex(System.Byte b, System.Byte[] hexChars, System.Byte& byte0, System.Byte& byte1)
  System.Byte[] URLEncode(System.Byte[] toEncode)
  System.String DataEncode(System.String toEncode)
  System.String DataEncode(System.String toEncode, System.Text.Encoding e)
  System.Byte[] DataEncode(System.Byte[] toEncode)
  System.String QPEncode(System.String toEncode, System.Text.Encoding e)
  System.Byte[] Encode(System.Byte[] input, System.Byte escapeChar, System.Byte[] space, System.Byte[] forbidden, System.Boolean uppercase)
  System.Boolean ByteArrayContains(System.Byte[] array, System.Byte b)
  System.Byte[] URLDecode(System.Byte[] toEncode)
  System.Boolean ByteSubArrayEquals(System.Byte[] array, System.Int32 index, System.Byte[] comperand)
  System.Byte[] Decode(System.Byte[] input, System.Byte escapeChar, System.Byte[] space)
  System.Boolean SevenBitClean(System.String s, System.Text.Encoding e)
  System.Boolean SevenBitClean(System.Byte* input, System.Int32 inputLength)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Networking.IMultipartFormSection
TYPE:  interface
TOKEN: 0x2000005
FIELDS:
METHODS:
  System.String get_sectionName()
  System.Byte[] get_sectionData()
  System.String get_fileName()
  System.String get_contentType()
END_CLASS

CLASS: UnityEngine.Networking.UnityWebRequestAsyncOperation
TYPE:  class
TOKEN: 0x2000006
EXTENDS: AsyncOperation
FIELDS:
  private           UnityEngine.Networking.UnityWebRequest<webRequest>k__BackingField  // 0x20
METHODS:
  System.Void set_webRequest(UnityEngine.Networking.UnityWebRequest value)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Networking.UnityWebRequest
TYPE:  class
TOKEN: 0x2000007
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
  private           UnityEngine.Networking.DownloadHandlerm_DownloadHandler  // 0x18
  private           UnityEngine.Networking.UploadHandlerm_UploadHandler  // 0x20
  private           UnityEngine.Networking.CertificateHandlerm_CertificateHandler  // 0x28
  private           System.Uri                      m_Uri  // 0x30
  public    static  System.String                   kHttpVerbGET  // 0x0
  public    static  System.String                   kHttpVerbHEAD  // 0x0
  public    static  System.String                   kHttpVerbPOST  // 0x0
  public    static  System.String                   kHttpVerbPUT  // 0x0
  public    static  System.String                   kHttpVerbCREATE  // 0x0
  public    static  System.String                   kHttpVerbDELETE  // 0x0
  private           System.Boolean                  <disposeCertificateHandlerOnDispose>k__BackingField  // 0x38
  private           System.Boolean                  <disposeDownloadHandlerOnDispose>k__BackingField  // 0x39
  private           System.Boolean                  <disposeUploadHandlerOnDispose>k__BackingField  // 0x3A
METHODS:
  System.String GetWebErrorString(UnityEngine.Networking.UnityWebRequest.UnityWebRequestError err)
  System.String GetHTTPStatusString(System.Int64 responseCode)
  System.Boolean get_disposeCertificateHandlerOnDispose()
  System.Void set_disposeCertificateHandlerOnDispose(System.Boolean value)
  System.Boolean get_disposeDownloadHandlerOnDispose()
  System.Void set_disposeDownloadHandlerOnDispose(System.Boolean value)
  System.Boolean get_disposeUploadHandlerOnDispose()
  System.Void set_disposeUploadHandlerOnDispose(System.Boolean value)
  System.Void ClearCookieCache()
  System.Void ClearCookieCache(System.Uri uri)
  System.Void ClearCookieCache(System.String domain, System.String path)
  System.IntPtr Create()
  System.Void Release()
  System.Void InternalDestroy()
  System.Void InternalSetDefaults()
  System.Void .ctor()
  System.Void .ctor(System.String url)
  System.Void .ctor(System.Uri uri)
  System.Void .ctor(System.String url, System.String method)
  System.Void .ctor(System.Uri uri, System.String method)
  System.Void .ctor(System.String url, System.String method, UnityEngine.Networking.DownloadHandler downloadHandler, UnityEngine.Networking.UploadHandler uploadHandler)
  System.Void .ctor(System.Uri uri, System.String method, UnityEngine.Networking.DownloadHandler downloadHandler, UnityEngine.Networking.UploadHandler uploadHandler)
  System.Void Finalize()
  System.Void Dispose()
  System.Void DisposeHandlers()
  UnityEngine.Networking.UnityWebRequestAsyncOperation BeginWebRequest()
  UnityEngine.AsyncOperation Send()
  UnityEngine.Networking.UnityWebRequestAsyncOperation SendWebRequest()
  System.Void Abort()
  UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetMethod(UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod methodType)
  System.Void InternalSetMethod(UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod methodType)
  UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetCustomMethod(System.String customMethodName)
  System.Void InternalSetCustomMethod(System.String customMethodName)
  UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod GetMethod()
  System.String GetCustomMethod()
  System.String get_method()
  System.Void set_method(System.String value)
  UnityEngine.Networking.UnityWebRequest.UnityWebRequestError GetError()
  System.String get_error()
  System.Boolean get_use100Continue()
  System.Void set_use100Continue(System.Boolean value)
  System.Boolean get_useHttpContinue()
  System.Void set_useHttpContinue(System.Boolean value)
  System.String get_url()
  System.Void set_url(System.String value)
  System.Uri get_uri()
  System.Void set_uri(System.Uri value)
  System.String GetUrl()
  UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetUrl(System.String url)
  System.Void InternalSetUrl(System.String url)
  System.Int64 get_responseCode()
  System.Single GetUploadProgress()
  System.Boolean IsExecuting()
  System.Single get_uploadProgress()
  System.Boolean get_isModifiable()
  System.Boolean get_isDone()
  System.Boolean get_isNetworkError()
  System.Boolean get_isHttpError()
  UnityEngine.Networking.UnityWebRequest.Result get_result()
  System.Single GetDownloadProgress()
  System.Single get_downloadProgress()
  System.UInt64 get_uploadedBytes()
  System.UInt64 get_downloadedBytes()
  System.Int32 GetRedirectLimit()
  System.Void SetRedirectLimitFromScripting(System.Int32 limit)
  System.Int32 get_redirectLimit()
  System.Void set_redirectLimit(System.Int32 value)
  System.Boolean GetChunked()
  UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetChunked(System.Boolean chunked)
  System.Boolean get_chunkedTransfer()
  System.Void set_chunkedTransfer(System.Boolean value)
  System.String GetRequestHeader(System.String name)
  UnityEngine.Networking.UnityWebRequest.UnityWebRequestError InternalSetRequestHeader(System.String name, System.String value)
  System.Void SetRequestHeader(System.String name, System.String value)
  System.String GetResponseHeader(System.String name)
  System.String[] GetResponseHeaderKeys()
  System.Collections.Generic.Dictionary<System.String,System.String> GetResponseHeaders()
  UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetUploadHandler(UnityEngine.Networking.UploadHandler uh)
  UnityEngine.Networking.UploadHandler get_uploadHandler()
  System.Void set_uploadHandler(UnityEngine.Networking.UploadHandler value)
  UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetDownloadHandler(UnityEngine.Networking.DownloadHandler dh)
  UnityEngine.Networking.DownloadHandler get_downloadHandler()
  System.Void set_downloadHandler(UnityEngine.Networking.DownloadHandler value)
  UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetCertificateHandler(UnityEngine.Networking.CertificateHandler ch)
  UnityEngine.Networking.CertificateHandler get_certificateHandler()
  System.Void set_certificateHandler(UnityEngine.Networking.CertificateHandler value)
  System.Int32 GetTimeoutMsec()
  UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetTimeoutMsec(System.Int32 timeout)
  System.Int32 get_timeout()
  System.Void set_timeout(System.Int32 value)
  System.Boolean GetSuppressErrorsToConsole()
  UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetSuppressErrorsToConsole(System.Boolean suppress)
  System.Boolean get_suppressErrorsToConsole()
  System.Void set_suppressErrorsToConsole(System.Boolean value)
  UnityEngine.Networking.UnityWebRequest Get(System.String uri)
  UnityEngine.Networking.UnityWebRequest Get(System.Uri uri)
  UnityEngine.Networking.UnityWebRequest Delete(System.String uri)
  UnityEngine.Networking.UnityWebRequest Delete(System.Uri uri)
  UnityEngine.Networking.UnityWebRequest Head(System.String uri)
  UnityEngine.Networking.UnityWebRequest Head(System.Uri uri)
  UnityEngine.Networking.UnityWebRequest GetTexture(System.String uri)
  UnityEngine.Networking.UnityWebRequest GetTexture(System.String uri, System.Boolean nonReadable)
  UnityEngine.Networking.UnityWebRequest GetAudioClip(System.String uri, UnityEngine.AudioType audioType)
  UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.String uri)
  UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.String uri, System.UInt32 crc)
  UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.String uri, System.UInt32 version, System.UInt32 crc)
  UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.String uri, UnityEngine.Hash128 hash, System.UInt32 crc)
  UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.String uri, UnityEngine.CachedAssetBundle cachedAssetBundle, System.UInt32 crc)
  UnityEngine.Networking.UnityWebRequest Put(System.String uri, System.Byte[] bodyData)
  UnityEngine.Networking.UnityWebRequest Put(System.Uri uri, System.Byte[] bodyData)
  UnityEngine.Networking.UnityWebRequest Put(System.String uri, System.String bodyData)
  UnityEngine.Networking.UnityWebRequest Put(System.Uri uri, System.String bodyData)
  UnityEngine.Networking.UnityWebRequest Post(System.String uri, System.String postData)
  UnityEngine.Networking.UnityWebRequest Post(System.Uri uri, System.String postData)
  System.Void SetupPost(UnityEngine.Networking.UnityWebRequest request, System.String postData)
  UnityEngine.Networking.UnityWebRequest Post(System.String uri, UnityEngine.WWWForm formData)
  UnityEngine.Networking.UnityWebRequest Post(System.Uri uri, UnityEngine.WWWForm formData)
  System.Void SetupPost(UnityEngine.Networking.UnityWebRequest request, UnityEngine.WWWForm formData)
  UnityEngine.Networking.UnityWebRequest Post(System.String uri, System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> multipartFormSections)
  UnityEngine.Networking.UnityWebRequest Post(System.Uri uri, System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> multipartFormSections)
  UnityEngine.Networking.UnityWebRequest Post(System.String uri, System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> multipartFormSections, System.Byte[] boundary)
  UnityEngine.Networking.UnityWebRequest Post(System.Uri uri, System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> multipartFormSections, System.Byte[] boundary)
  System.Void SetupPost(UnityEngine.Networking.UnityWebRequest request, System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> multipartFormSections, System.Byte[] boundary)
  UnityEngine.Networking.UnityWebRequest Post(System.String uri, System.Collections.Generic.Dictionary<System.String,System.String> formFields)
  UnityEngine.Networking.UnityWebRequest Post(System.Uri uri, System.Collections.Generic.Dictionary<System.String,System.String> formFields)
  System.Void SetupPost(UnityEngine.Networking.UnityWebRequest request, System.Collections.Generic.Dictionary<System.String,System.String> formFields)
  System.String EscapeURL(System.String s)
  System.String EscapeURL(System.String s, System.Text.Encoding e)
  System.String UnEscapeURL(System.String s)
  System.String UnEscapeURL(System.String s, System.Text.Encoding e)
  System.Byte[] SerializeFormSections(System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> multipartFormSections, System.Byte[] boundary)
  System.Byte[] GenerateBoundary()
  System.Byte[] SerializeSimpleForm(System.Collections.Generic.Dictionary<System.String,System.String> formFields)
END_CLASS

CLASS: UnityEngine.Networking.CertificateHandler
TYPE:  class
TOKEN: 0x200000B
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
METHODS:
  System.Void Release()
  System.Boolean ValidateCertificate(System.Byte[] certificateData)
  System.Boolean ValidateCertificateNative(System.Byte[] certificateData)
  System.Void Dispose()
END_CLASS

CLASS: UnityEngine.Networking.DownloadHandler
TYPE:  class
TOKEN: 0x200000C
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
METHODS:
  System.Void Release()
  System.Void .ctor()
  System.Void Finalize()
  System.Void Dispose()
  System.Byte[] get_data()
  System.String get_text()
  Unity.Collections.NativeArray<System.Byte> GetNativeData()
  System.Byte[] GetData()
  System.String GetText()
  System.Text.Encoding GetTextEncoder()
  System.String GetContentType()
  System.Boolean ReceiveData(System.Byte[] data, System.Int32 dataLength)
  System.Void ReceiveContentLengthHeader(System.UInt64 contentLength)
  System.Void ReceiveContentLength(System.Int32 contentLength)
  System.Void CompleteContent()
  System.Single GetProgress()
  System.Byte* InternalGetByteArray(UnityEngine.Networking.DownloadHandler dh, System.Int32& length)
  System.Byte[] InternalGetByteArray(UnityEngine.Networking.DownloadHandler dh)
  Unity.Collections.NativeArray<System.Byte> InternalGetNativeArray(UnityEngine.Networking.DownloadHandler dh, Unity.Collections.NativeArray<System.Byte>& nativeArray)
  System.Void DisposeNativeArray(Unity.Collections.NativeArray<System.Byte>& data)
  System.Void CreateNativeArrayForNativeData(Unity.Collections.NativeArray<System.Byte>& data, System.Byte* bytes, System.Int32 length)
END_CLASS

CLASS: UnityEngine.Networking.DownloadHandlerBuffer
TYPE:  class
TOKEN: 0x200000D
EXTENDS: DownloadHandler
FIELDS:
  private           Unity.Collections.NativeArray<System.Byte>m_NativeData  // 0x18
METHODS:
  System.IntPtr Create(UnityEngine.Networking.DownloadHandlerBuffer obj)
  System.Void InternalCreateBuffer()
  System.Void .ctor()
  Unity.Collections.NativeArray<System.Byte> GetNativeData()
  System.Void Dispose()
END_CLASS

CLASS: UnityEngine.Networking.UploadHandler
TYPE:  class
TOKEN: 0x200000E
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
METHODS:
  System.Void Release()
  System.Void .ctor()
  System.Void Finalize()
  System.Void Dispose()
  System.Void set_contentType(System.String value)
  System.Void SetContentType(System.String newContentType)
  System.Void InternalSetContentType(System.String newContentType)
END_CLASS

CLASS: UnityEngine.Networking.UploadHandlerRaw
TYPE:  class
TOKEN: 0x200000F
EXTENDS: UploadHandler
FIELDS:
  private           Unity.Collections.NativeArray<System.Byte>m_Payload  // 0x18
METHODS:
  System.IntPtr Create(UnityEngine.Networking.UploadHandlerRaw self, System.Byte* data, System.Int32 dataLength)
  System.Void .ctor(System.Byte[] data)
  System.Void .ctor(Unity.Collections.NativeArray<System.Byte> data, System.Boolean transferOwnership)
  System.Void Dispose()
END_CLASS

CLASS: UnityEngineInternal.WebRequestUtils
TYPE:  class
TOKEN: 0x2000002
FIELDS:
  private   static  System.Text.RegularExpressions.RegexdomainRegex  // 0x0
METHODS:
  System.String RedirectTo(System.String baseUri, System.String redirectUri)
  System.String MakeInitialUrl(System.String targetUrl, System.String localUrl)
  System.String MakeUriString(System.Uri targetUri, System.String targetUrl, System.Boolean prependProtocol)
  System.String URLDecode(System.String encoded)
  System.Void .cctor()
END_CLASS

