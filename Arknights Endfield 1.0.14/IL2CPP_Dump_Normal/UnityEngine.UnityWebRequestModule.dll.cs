// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.UnityWebRequestModule.dll
// Classes:  15
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000008
    public struct UnityWebRequestMethod
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod Get;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod Post;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod Put;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod Head;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod Custom;        // 0x0

    }

    // TypeToken: 0x2000009
    public struct UnityWebRequestError
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError OK;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError Unknown;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SDKError;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError UnsupportedProtocol;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError MalformattedUrl;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError CannotResolveProxy;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError CannotResolveHost;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError CannotConnectToHost;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError AccessDenied;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError GenericHttpError;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError WriteError;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError ReadError;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError OutOfMemory;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError Timeout;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError HTTPPostError;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SSLCannotConnect;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError Aborted;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError TooManyRedirects;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError ReceivedNoData;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SSLNotSupported;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError FailedToSendData;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError FailedToReceiveData;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SSLCertificateError;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SSLCipherNotAvailable;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SSLCACertError;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError UnrecognizedContentEncoding;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError LoginFailed;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SSLShutdownFailed;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.UnityWebRequestError NoInternetConnection;        // 0x0

    }

    // TypeToken: 0x200000A
    public struct Result
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Networking.UnityWebRequest.Result InProgress;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.Result Success;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.Result ConnectionError;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.Result ProtocolError;        // 0x0
        public static UnityEngine.Networking.UnityWebRequest.Result DataProcessingError;        // 0x0

    }

namespace UnityEngine
{

    // TypeToken: 0x2000003
    public class WWWForm
    {
        // Fields
        private System.Collections.Generic.List<System.Byte[]> formData;        // 0x10
        private System.Collections.Generic.List<System.String> fieldNames;        // 0x18
        private System.Collections.Generic.List<System.String> fileNames;        // 0x20
        private System.Collections.Generic.List<System.String> types;        // 0x28
        private System.Byte[] boundary;        // 0x30
        private System.Boolean containsFiles;        // 0x38
        private static System.Byte[] dDash;        // 0x0
        private static System.Byte[] crlf;        // 0x8
        private static System.Byte[] contentTypeHeader;        // 0x10
        private static System.Byte[] dispositionHeader;        // 0x18
        private static System.Byte[] endQuote;        // 0x20
        private static System.Byte[] fileNameField;        // 0x28
        private static System.Byte[] ampersand;        // 0x30
        private static System.Byte[] equal;        // 0x38

        // Methods
        private System.Text.Encoding get_DefaultEncoding() { }
        private System.Collections.Generic.Dictionary<System.String,System.String> get_headers() { }
        private System.Byte[] get_data() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000004
    public class WWWTranscoder
    {
        // Fields
        private static System.Byte[] ucHexChars;        // 0x0
        private static System.Byte[] lcHexChars;        // 0x8
        private static System.Byte urlEscapeChar;        // 0x10
        private static System.Byte[] urlSpace;        // 0x18
        private static System.Byte[] dataSpace;        // 0x20
        private static System.Byte[] urlForbidden;        // 0x28
        private static System.Byte qpEscapeChar;        // 0x30
        private static System.Byte[] qpSpace;        // 0x38
        private static System.Byte[] qpForbidden;        // 0x40

        // Methods
        private System.Byte Hex2Byte(System.Byte[] b, System.Int32 offset) { }
        private System.Void Byte2Hex(System.Byte b, System.Byte[] hexChars, System.Byte& byte0, System.Byte& byte1) { }
        private System.Byte[] URLEncode(System.Byte[] toEncode) { }
        private System.String DataEncode(System.String toEncode) { }
        private System.String DataEncode(System.String toEncode, System.Text.Encoding e) { }
        private System.Byte[] DataEncode(System.Byte[] toEncode) { }
        private System.String QPEncode(System.String toEncode, System.Text.Encoding e) { }
        private System.Byte[] Encode(System.Byte[] input, System.Byte escapeChar, System.Byte[] space, System.Byte[] forbidden, System.Boolean uppercase) { }
        private System.Boolean ByteArrayContains(System.Byte[] array, System.Byte b) { }
        private System.Byte[] URLDecode(System.Byte[] toEncode) { }
        private System.Boolean ByteSubArrayEquals(System.Byte[] array, System.Int32 index, System.Byte[] comperand) { }
        private System.Byte[] Decode(System.Byte[] input, System.Byte escapeChar, System.Byte[] space) { }
        private System.Boolean SevenBitClean(System.String s, System.Text.Encoding e) { }
        private System.Boolean SevenBitClean(System.Byte* input, System.Int32 inputLength) { }
        private System.Void .cctor() { }

    }

}

namespace UnityEngine.Networking
{

    // TypeToken: 0x2000005
    public interface IMultipartFormSection
    {
        // Methods
        private System.String get_sectionName() { }
        private System.Byte[] get_sectionData() { }
        private System.String get_fileName() { }
        private System.String get_contentType() { }

    }

    // TypeToken: 0x2000006
    public class UnityWebRequestAsyncOperation : AsyncOperation
    {
        // Fields
        private UnityEngine.Networking.UnityWebRequest <webRequest>k__BackingField;        // 0x20

        // Methods
        private System.Void set_webRequest(UnityEngine.Networking.UnityWebRequest value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000007
    public class UnityWebRequest, IDisposable
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10
        private UnityEngine.Networking.DownloadHandler m_DownloadHandler;        // 0x18
        private UnityEngine.Networking.UploadHandler m_UploadHandler;        // 0x20
        private UnityEngine.Networking.CertificateHandler m_CertificateHandler;        // 0x28
        private System.Uri m_Uri;        // 0x30
        public static System.String kHttpVerbGET;        // 0x0
        public static System.String kHttpVerbHEAD;        // 0x0
        public static System.String kHttpVerbPOST;        // 0x0
        public static System.String kHttpVerbPUT;        // 0x0
        public static System.String kHttpVerbCREATE;        // 0x0
        public static System.String kHttpVerbDELETE;        // 0x0
        private System.Boolean <disposeCertificateHandlerOnDispose>k__BackingField;        // 0x38
        private System.Boolean <disposeDownloadHandlerOnDispose>k__BackingField;        // 0x39
        private System.Boolean <disposeUploadHandlerOnDispose>k__BackingField;        // 0x3A

        // Methods
        private System.String GetWebErrorString(UnityEngine.Networking.UnityWebRequest.UnityWebRequestError err) { }
        private System.String GetHTTPStatusString(System.Int64 responseCode) { }
        private System.Boolean get_disposeCertificateHandlerOnDispose() { }
        private System.Void set_disposeCertificateHandlerOnDispose(System.Boolean value) { }
        private System.Boolean get_disposeDownloadHandlerOnDispose() { }
        private System.Void set_disposeDownloadHandlerOnDispose(System.Boolean value) { }
        private System.Boolean get_disposeUploadHandlerOnDispose() { }
        private System.Void set_disposeUploadHandlerOnDispose(System.Boolean value) { }
        private System.Void ClearCookieCache() { }
        private System.Void ClearCookieCache(System.Uri uri) { }
        private System.Void ClearCookieCache(System.String domain, System.String path) { }
        private System.IntPtr Create() { }
        private System.Void Release() { }
        private System.Void InternalDestroy() { }
        private System.Void InternalSetDefaults() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String url) { }
        private System.Void .ctor(System.Uri uri) { }
        private System.Void .ctor(System.String url, System.String method) { }
        private System.Void .ctor(System.Uri uri, System.String method) { }
        private System.Void .ctor(System.String url, System.String method, UnityEngine.Networking.DownloadHandler downloadHandler, UnityEngine.Networking.UploadHandler uploadHandler) { }
        private System.Void .ctor(System.Uri uri, System.String method, UnityEngine.Networking.DownloadHandler downloadHandler, UnityEngine.Networking.UploadHandler uploadHandler) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void DisposeHandlers() { }
        private UnityEngine.Networking.UnityWebRequestAsyncOperation BeginWebRequest() { }
        private UnityEngine.AsyncOperation Send() { }
        private UnityEngine.Networking.UnityWebRequestAsyncOperation SendWebRequest() { }
        private System.Void Abort() { }
        private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetMethod(UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod methodType) { }
        private System.Void InternalSetMethod(UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod methodType) { }
        private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetCustomMethod(System.String customMethodName) { }
        private System.Void InternalSetCustomMethod(System.String customMethodName) { }
        private UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod GetMethod() { }
        private System.String GetCustomMethod() { }
        private System.String get_method() { }
        private System.Void set_method(System.String value) { }
        private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError GetError() { }
        private System.String get_error() { }
        private System.Boolean get_use100Continue() { }
        private System.Void set_use100Continue(System.Boolean value) { }
        private System.Boolean get_useHttpContinue() { }
        private System.Void set_useHttpContinue(System.Boolean value) { }
        private System.String get_url() { }
        private System.Void set_url(System.String value) { }
        private System.Uri get_uri() { }
        private System.Void set_uri(System.Uri value) { }
        private System.String GetUrl() { }
        private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetUrl(System.String url) { }
        private System.Void InternalSetUrl(System.String url) { }
        private System.Int64 get_responseCode() { }
        private System.Single GetUploadProgress() { }
        private System.Boolean IsExecuting() { }
        private System.Single get_uploadProgress() { }
        private System.Boolean get_isModifiable() { }
        private System.Boolean get_isDone() { }
        private System.Boolean get_isNetworkError() { }
        private System.Boolean get_isHttpError() { }
        private UnityEngine.Networking.UnityWebRequest.Result get_result() { }
        private System.Single GetDownloadProgress() { }
        private System.Single get_downloadProgress() { }
        private System.UInt64 get_uploadedBytes() { }
        private System.UInt64 get_downloadedBytes() { }
        private System.Int32 GetRedirectLimit() { }
        private System.Void SetRedirectLimitFromScripting(System.Int32 limit) { }
        private System.Int32 get_redirectLimit() { }
        private System.Void set_redirectLimit(System.Int32 value) { }
        private System.Boolean GetChunked() { }
        private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetChunked(System.Boolean chunked) { }
        private System.Boolean get_chunkedTransfer() { }
        private System.Void set_chunkedTransfer(System.Boolean value) { }
        private System.String GetRequestHeader(System.String name) { }
        private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError InternalSetRequestHeader(System.String name, System.String value) { }
        private System.Void SetRequestHeader(System.String name, System.String value) { }
        private System.String GetResponseHeader(System.String name) { }
        private System.String[] GetResponseHeaderKeys() { }
        private System.Collections.Generic.Dictionary<System.String,System.String> GetResponseHeaders() { }
        private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetUploadHandler(UnityEngine.Networking.UploadHandler uh) { }
        private UnityEngine.Networking.UploadHandler get_uploadHandler() { }
        private System.Void set_uploadHandler(UnityEngine.Networking.UploadHandler value) { }
        private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetDownloadHandler(UnityEngine.Networking.DownloadHandler dh) { }
        private UnityEngine.Networking.DownloadHandler get_downloadHandler() { }
        private System.Void set_downloadHandler(UnityEngine.Networking.DownloadHandler value) { }
        private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetCertificateHandler(UnityEngine.Networking.CertificateHandler ch) { }
        private UnityEngine.Networking.CertificateHandler get_certificateHandler() { }
        private System.Void set_certificateHandler(UnityEngine.Networking.CertificateHandler value) { }
        private System.Int32 GetTimeoutMsec() { }
        private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetTimeoutMsec(System.Int32 timeout) { }
        private System.Int32 get_timeout() { }
        private System.Void set_timeout(System.Int32 value) { }
        private System.Boolean GetSuppressErrorsToConsole() { }
        private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetSuppressErrorsToConsole(System.Boolean suppress) { }
        private System.Boolean get_suppressErrorsToConsole() { }
        private System.Void set_suppressErrorsToConsole(System.Boolean value) { }
        private UnityEngine.Networking.UnityWebRequest Get(System.String uri) { }
        private UnityEngine.Networking.UnityWebRequest Get(System.Uri uri) { }
        private UnityEngine.Networking.UnityWebRequest Delete(System.String uri) { }
        private UnityEngine.Networking.UnityWebRequest Delete(System.Uri uri) { }
        private UnityEngine.Networking.UnityWebRequest Head(System.String uri) { }
        private UnityEngine.Networking.UnityWebRequest Head(System.Uri uri) { }
        private UnityEngine.Networking.UnityWebRequest GetTexture(System.String uri) { }
        private UnityEngine.Networking.UnityWebRequest GetTexture(System.String uri, System.Boolean nonReadable) { }
        private UnityEngine.Networking.UnityWebRequest GetAudioClip(System.String uri, UnityEngine.AudioType audioType) { }
        private UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.String uri) { }
        private UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.String uri, System.UInt32 crc) { }
        private UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.String uri, System.UInt32 version, System.UInt32 crc) { }
        private UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.String uri, UnityEngine.Hash128 hash, System.UInt32 crc) { }
        private UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.String uri, UnityEngine.CachedAssetBundle cachedAssetBundle, System.UInt32 crc) { }
        private UnityEngine.Networking.UnityWebRequest Put(System.String uri, System.Byte[] bodyData) { }
        private UnityEngine.Networking.UnityWebRequest Put(System.Uri uri, System.Byte[] bodyData) { }
        private UnityEngine.Networking.UnityWebRequest Put(System.String uri, System.String bodyData) { }
        private UnityEngine.Networking.UnityWebRequest Put(System.Uri uri, System.String bodyData) { }
        private UnityEngine.Networking.UnityWebRequest Post(System.String uri, System.String postData) { }
        private UnityEngine.Networking.UnityWebRequest Post(System.Uri uri, System.String postData) { }
        private System.Void SetupPost(UnityEngine.Networking.UnityWebRequest request, System.String postData) { }
        private UnityEngine.Networking.UnityWebRequest Post(System.String uri, UnityEngine.WWWForm formData) { }
        private UnityEngine.Networking.UnityWebRequest Post(System.Uri uri, UnityEngine.WWWForm formData) { }
        private System.Void SetupPost(UnityEngine.Networking.UnityWebRequest request, UnityEngine.WWWForm formData) { }
        private UnityEngine.Networking.UnityWebRequest Post(System.String uri, System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> multipartFormSections) { }
        private UnityEngine.Networking.UnityWebRequest Post(System.Uri uri, System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> multipartFormSections) { }
        private UnityEngine.Networking.UnityWebRequest Post(System.String uri, System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> multipartFormSections, System.Byte[] boundary) { }
        private UnityEngine.Networking.UnityWebRequest Post(System.Uri uri, System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> multipartFormSections, System.Byte[] boundary) { }
        private System.Void SetupPost(UnityEngine.Networking.UnityWebRequest request, System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> multipartFormSections, System.Byte[] boundary) { }
        private UnityEngine.Networking.UnityWebRequest Post(System.String uri, System.Collections.Generic.Dictionary<System.String,System.String> formFields) { }
        private UnityEngine.Networking.UnityWebRequest Post(System.Uri uri, System.Collections.Generic.Dictionary<System.String,System.String> formFields) { }
        private System.Void SetupPost(UnityEngine.Networking.UnityWebRequest request, System.Collections.Generic.Dictionary<System.String,System.String> formFields) { }
        private System.String EscapeURL(System.String s) { }
        private System.String EscapeURL(System.String s, System.Text.Encoding e) { }
        private System.String UnEscapeURL(System.String s) { }
        private System.String UnEscapeURL(System.String s, System.Text.Encoding e) { }
        private System.Byte[] SerializeFormSections(System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> multipartFormSections, System.Byte[] boundary) { }
        private System.Byte[] GenerateBoundary() { }
        private System.Byte[] SerializeSimpleForm(System.Collections.Generic.Dictionary<System.String,System.String> formFields) { }

    }

    // TypeToken: 0x200000B
    public class CertificateHandler, IDisposable
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10

        // Methods
        private System.Void Release() { }
        private System.Boolean ValidateCertificate(System.Byte[] certificateData) { }
        private System.Boolean ValidateCertificateNative(System.Byte[] certificateData) { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x200000C
    public class DownloadHandler, IDisposable
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10

        // Methods
        private System.Void Release() { }
        private System.Void .ctor() { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Byte[] get_data() { }
        private System.String get_text() { }
        private Unity.Collections.NativeArray<System.Byte> GetNativeData() { }
        private System.Byte[] GetData() { }
        private System.String GetText() { }
        private System.Text.Encoding GetTextEncoder() { }
        private System.String GetContentType() { }
        private System.Boolean ReceiveData(System.Byte[] data, System.Int32 dataLength) { }
        private System.Void ReceiveContentLengthHeader(System.UInt64 contentLength) { }
        private System.Void ReceiveContentLength(System.Int32 contentLength) { }
        private System.Void CompleteContent() { }
        private System.Single GetProgress() { }
        private System.Byte* InternalGetByteArray(UnityEngine.Networking.DownloadHandler dh, System.Int32& length) { }
        private System.Byte[] InternalGetByteArray(UnityEngine.Networking.DownloadHandler dh) { }
        private Unity.Collections.NativeArray<System.Byte> InternalGetNativeArray(UnityEngine.Networking.DownloadHandler dh, Unity.Collections.NativeArray<System.Byte>& nativeArray) { }
        private System.Void DisposeNativeArray(Unity.Collections.NativeArray<System.Byte>& data) { }
        private System.Void CreateNativeArrayForNativeData(Unity.Collections.NativeArray<System.Byte>& data, System.Byte* bytes, System.Int32 length) { }

    }

    // TypeToken: 0x200000D
    public class DownloadHandlerBuffer : DownloadHandler
    {
        // Fields
        private Unity.Collections.NativeArray<System.Byte> m_NativeData;        // 0x18

        // Methods
        private System.IntPtr Create(UnityEngine.Networking.DownloadHandlerBuffer obj) { }
        private System.Void InternalCreateBuffer() { }
        private System.Void .ctor() { }
        private Unity.Collections.NativeArray<System.Byte> GetNativeData() { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x200000E
    public class UploadHandler, IDisposable
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10

        // Methods
        private System.Void Release() { }
        private System.Void .ctor() { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void set_contentType(System.String value) { }
        private System.Void SetContentType(System.String newContentType) { }
        private System.Void InternalSetContentType(System.String newContentType) { }

    }

    // TypeToken: 0x200000F
    public class UploadHandlerRaw : UploadHandler
    {
        // Fields
        private Unity.Collections.NativeArray<System.Byte> m_Payload;        // 0x18

        // Methods
        private System.IntPtr Create(UnityEngine.Networking.UploadHandlerRaw self, System.Byte* data, System.Int32 dataLength) { }
        private System.Void .ctor(System.Byte[] data) { }
        private System.Void .ctor(Unity.Collections.NativeArray<System.Byte> data, System.Boolean transferOwnership) { }
        private System.Void Dispose() { }

    }

}

namespace UnityEngineInternal
{

    // TypeToken: 0x2000002
    public class WebRequestUtils
    {
        // Fields
        private static System.Text.RegularExpressions.Regex domainRegex;        // 0x0

        // Methods
        private System.String RedirectTo(System.String baseUri, System.String redirectUri) { }
        private System.String MakeInitialUrl(System.String targetUrl, System.String localUrl) { }
        private System.String MakeUriString(System.Uri targetUri, System.String targetUrl, System.Boolean prependProtocol) { }
        private System.String URLDecode(System.String encoded) { }
        private System.Void .cctor() { }

    }

}

