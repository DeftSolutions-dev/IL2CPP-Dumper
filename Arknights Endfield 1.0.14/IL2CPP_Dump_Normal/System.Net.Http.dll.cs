// ========================================================
// Dumped by @desirepro
// Assembly: System.Net.Http.dll
// Classes:  84
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x200000F
    public class FixedMemoryStream : MemoryStream
    {
        // Fields
        private readonly System.Int64 maxSize;        // 0x50

        // Methods
        private System.Void .ctor(System.Int64 maxSize) { }
        private System.Void CheckOverflow(System.Int32 count) { }
        private System.Void WriteByte(System.Byte value) { }
        private System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 count) { }

    }

    // TypeToken: 0x2000029
    public class HeaderTypeInfo`2 : HeaderInfo
    {
        // Fields
        private readonly System.Net.Http.Headers.TryParseDelegate<T> parser;        // 0x0

        // Methods
        private System.Void .ctor(System.String name, System.Net.Http.Headers.TryParseDelegate<T> parser, System.Net.Http.Headers.HttpHeaderKind headerKind) { }
        private System.Void AddToCollection(System.Object collection, System.Object value) { }
        private System.Object CreateCollection(System.Net.Http.Headers.HttpHeaders headers, System.Net.Http.Headers.HeaderInfo headerInfo) { }
        private System.Collections.Generic.List<System.String> ToStringCollection(System.Object collection) { }
        private System.Boolean TryParse(System.String value, System.Object& result) { }

    }

    // TypeToken: 0x200002A
    public class CollectionHeaderTypeInfo`2 : HeaderTypeInfo`2
    {
        // Fields
        private readonly System.Int32 minimalCount;        // 0x0
        private readonly System.String separator;        // 0x0
        private readonly System.Net.Http.Headers.TryParseListDelegate<T> parser;        // 0x0

        // Methods
        private System.Void .ctor(System.String name, System.Net.Http.Headers.TryParseListDelegate<T> parser, System.Net.Http.Headers.HttpHeaderKind headerKind, System.Int32 minimalCount, System.String separator) { }
        private System.String get_Separator() { }
        private System.Boolean TryParse(System.String value, System.Object& result) { }

    }

    // TypeToken: 0x200002F
    public class HeaderBucket
    {
        // Fields
        public System.Object Parsed;        // 0x10
        private System.Collections.Generic.List<System.String> values;        // 0x18
        public readonly System.Func<System.Object,System.String> CustomToString;        // 0x20

        // Methods
        private System.Void .ctor(System.Object parsed, System.Func<System.Object,System.String> converter) { }
        private System.Boolean get_HasStringValues() { }
        private System.Collections.Generic.List<System.String> get_Values() { }
        private System.Void set_Values(System.Collections.Generic.List<System.String> value) { }
        private System.String ParsedToString() { }

    }

    // TypeToken: 0x2000035
    public struct Type
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.Http.Headers.Token.Type Error;        // 0x0
        public static System.Net.Http.Headers.Token.Type End;        // 0x0
        public static System.Net.Http.Headers.Token.Type Token;        // 0x0
        public static System.Net.Http.Headers.Token.Type QuotedString;        // 0x0
        public static System.Net.Http.Headers.Token.Type SeparatorEqual;        // 0x0
        public static System.Net.Http.Headers.Token.Type SeparatorSemicolon;        // 0x0
        public static System.Net.Http.Headers.Token.Type SeparatorSlash;        // 0x0
        public static System.Net.Http.Headers.Token.Type SeparatorDash;        // 0x0
        public static System.Net.Http.Headers.Token.Type SeparatorComma;        // 0x0
        public static System.Net.Http.Headers.Token.Type OpenParens;        // 0x0

    }

    // TypeToken: 0x200003D
    public class Token
    {
        // Methods
        private System.Void Check(System.String s) { }
        private System.Boolean TryCheck(System.String s) { }

    }

    // TypeToken: 0x200003E
    public class DateTime
    {
        // Fields
        public static readonly System.Func<System.Object,System.String> ToString;        // 0x0

        // Methods
        private System.Boolean TryParse(System.String input, System.DateTimeOffset& result) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000040
    public class EmailAddress
    {
        // Methods
        private System.Boolean TryParse(System.String input, System.String& result) { }

    }

    // TypeToken: 0x2000041
    public class Host
    {
        // Methods
        private System.Boolean TryParse(System.String input, System.String& result) { }

    }

    // TypeToken: 0x2000042
    public class Int
    {
        // Methods
        private System.Boolean TryParse(System.String input, System.Int32& result) { }

    }

    // TypeToken: 0x2000043
    public class Long
    {
        // Methods
        private System.Boolean TryParse(System.String input, System.Int64& result) { }

    }

    // TypeToken: 0x2000044
    public class MD5
    {
        // Fields
        public static readonly System.Func<System.Object,System.String> ToString;        // 0x0

        // Methods
        private System.Boolean TryParse(System.String input, System.Byte[]& result) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000046
    public class TimeSpanSeconds
    {
        // Methods
        private System.Boolean TryParse(System.String input, System.TimeSpan& result) { }

    }

    // TypeToken: 0x2000047
    public class Uri
    {
        // Methods
        private System.Boolean TryParse(System.String input, System.Uri& result) { }

    }

    // TypeToken: 0x2000054
    public struct __StaticArrayInitTypeSize=127
    {
    }

namespace System.Net.Http
{

    // TypeToken: 0x2000002
    public class HttpClientHandler : HttpMessageHandler
    {
        // Fields
        private readonly System.Net.Http.IMonoHttpClientHandler _delegatingHandler;        // 0x10
        private System.Net.Http.ClientCertificateOption _clientCertificateOptions;        // 0x18

        // Methods
        private System.Net.Http.IMonoHttpClientHandler CreateDefaultHandler() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Net.Http.IMonoHttpClientHandler handler) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void ThrowForModifiedManagedSslOptionsIfStarted() { }
        private System.Net.Http.ClientCertificateOption get_ClientCertificateOptions() { }
        private System.Void set_ClientCertificateOptions(System.Net.Http.ClientCertificateOption value) { }
        private System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates() { }
        private System.Void SetWebRequestTimeout(System.TimeSpan timeout) { }
        private System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { }
        private System.Security.Cryptography.X509Certificates.X509Certificate <set_ClientCertificateOptions>b__23_0(System.Object sender, System.String targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, System.String[] acceptableIssuers) { }

    }

    // TypeToken: 0x2000004
    public interface IMonoHttpClientHandler : IDisposable
    {
        // Methods
        private System.Net.Security.SslClientAuthenticationOptions get_SslOptions() { }
        private System.Void set_SslOptions(System.Net.Security.SslClientAuthenticationOptions value) { }
        private System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { }
        private System.Void SetWebRequestTimeout(System.TimeSpan timeout) { }

    }

    // TypeToken: 0x2000005
    public class MonoWebRequestHandler, IMonoHttpClientHandler, IDisposable
    {
        // Fields
        private static System.Int64 groupCounter;        // 0x0
        private System.Boolean allowAutoRedirect;        // 0x10
        private System.Net.DecompressionMethods automaticDecompression;        // 0x14
        private System.Net.CookieContainer cookieContainer;        // 0x18
        private System.Net.ICredentials credentials;        // 0x20
        private System.Int32 maxAutomaticRedirections;        // 0x28
        private System.Int64 maxRequestContentBufferSize;        // 0x30
        private System.Boolean preAuthenticate;        // 0x38
        private System.Net.IWebProxy proxy;        // 0x40
        private System.Boolean useCookies;        // 0x48
        private System.Boolean useProxy;        // 0x49
        private System.Net.Security.SslClientAuthenticationOptions sslOptions;        // 0x50
        private System.Boolean allowPipelining;        // 0x58
        private System.Net.Cache.RequestCachePolicy cachePolicy;        // 0x60
        private System.Net.Security.AuthenticationLevel authenticationLevel;        // 0x68
        private System.TimeSpan continueTimeout;        // 0x70
        private System.Security.Principal.TokenImpersonationLevel impersonationLevel;        // 0x78
        private System.Int32 maxResponseHeadersLength;        // 0x7C
        private System.Int32 readWriteTimeout;        // 0x80
        private System.Net.Security.RemoteCertificateValidationCallback serverCertificateValidationCallback;        // 0x88
        private System.Boolean unsafeAuthenticatedConnectionSharing;        // 0x90
        private System.Boolean sentRequest;        // 0x91
        private System.String connectionGroupName;        // 0x98
        private System.Nullable<System.TimeSpan> timeout;        // 0xA0
        private System.Boolean disposed;        // 0xB0

        // Methods
        private System.Void .ctor() { }
        private System.Void EnsureModifiability() { }
        private System.Net.CookieContainer get_CookieContainer() { }
        private System.Int64 get_MaxRequestContentBufferSize() { }
        private System.Net.Security.SslClientAuthenticationOptions get_SslOptions() { }
        private System.Void set_SslOptions(System.Net.Security.SslClientAuthenticationOptions value) { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Boolean GetConnectionKeepAlive(System.Net.Http.Headers.HttpRequestHeaders headers) { }
        private System.Net.HttpWebRequest CreateWebRequest(System.Net.Http.HttpRequestMessage request) { }
        private System.Net.Http.HttpResponseMessage CreateResponseMessage(System.Net.HttpWebResponse wr, System.Net.Http.HttpRequestMessage requestMessage, System.Threading.CancellationToken cancellationToken) { }
        private System.Boolean MethodHasBody(System.Net.Http.HttpMethod method) { }
        private System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { }
        private System.Void System.Net.Http.IMonoHttpClientHandler.SetWebRequestTimeout(System.TimeSpan timeout) { }

    }

    // TypeToken: 0x2000008
    public class PlatformHelper
    {
        // Methods
        private System.Boolean IsContentHeader(System.String name) { }
        private System.String GetSingleHeaderString(System.String name, System.Collections.Generic.IEnumerable<System.String> values) { }
        private System.Net.Http.StreamContent CreateStreamContent(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken) { }

    }

    // TypeToken: 0x2000009
    public class ByteArrayContent : HttpContent
    {
        // Fields
        private readonly System.Byte[] content;        // 0x28
        private readonly System.Int32 offset;        // 0x30
        private readonly System.Int32 count;        // 0x34

        // Methods
        private System.Void .ctor(System.Byte[] content) { }
        private System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context) { }
        private System.Boolean TryComputeLength(System.Int64& length) { }

    }

    // TypeToken: 0x200000A
    public struct ClientCertificateOption
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.Http.ClientCertificateOption Manual;        // 0x0
        public static System.Net.Http.ClientCertificateOption Automatic;        // 0x0

    }

    // TypeToken: 0x200000B
    public class HttpClient : HttpMessageInvoker
    {
        // Fields
        private static readonly System.TimeSpan TimeoutDefault;        // 0x0
        private System.Uri base_address;        // 0x20
        private System.Threading.CancellationTokenSource cts;        // 0x28
        private System.Boolean disposed;        // 0x30
        private System.Net.Http.Headers.HttpRequestHeaders headers;        // 0x38
        private System.Int64 buffer_size;        // 0x40
        private System.TimeSpan timeout;        // 0x48

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Net.Http.HttpMessageHandler handler, System.Boolean disposeHandler) { }
        private System.Net.Http.Headers.HttpRequestHeaders get_DefaultRequestHeaders() { }
        private System.Int64 get_MaxResponseContentBufferSize() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PostAsync(System.String requestUri, System.Net.Http.HttpContent content) { }
        private System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request) { }
        private System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Net.Http.HttpCompletionOption completionOption, System.Threading.CancellationToken cancellationToken) { }
        private System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsyncWorker(System.Net.Http.HttpRequestMessage request, System.Net.Http.HttpCompletionOption completionOption, System.Threading.CancellationToken cancellationToken) { }
        private System.Void .cctor() { }
        private System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> <>n__0(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { }

    }

    // TypeToken: 0x200000D
    public struct HttpCompletionOption
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.Http.HttpCompletionOption ResponseContentRead;        // 0x0
        public static System.Net.Http.HttpCompletionOption ResponseHeadersRead;        // 0x0

    }

    // TypeToken: 0x200000E
    public class HttpContent, IDisposable
    {
        // Fields
        private System.Net.Http.HttpContent.FixedMemoryStream buffer;        // 0x10
        private System.Boolean disposed;        // 0x18
        private System.Net.Http.Headers.HttpContentHeaders headers;        // 0x20

        // Methods
        private System.Net.Http.Headers.HttpContentHeaders get_Headers() { }
        private System.Nullable<System.Int64> get_LoadedBufferLength() { }
        private System.Threading.Tasks.Task CopyToAsync(System.IO.Stream stream) { }
        private System.Threading.Tasks.Task CopyToAsync(System.IO.Stream stream, System.Net.TransportContext context) { }
        private System.Net.Http.HttpContent.FixedMemoryStream CreateFixedMemoryStream(System.Int64 maxBufferSize) { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Threading.Tasks.Task LoadIntoBufferAsync() { }
        private System.Threading.Tasks.Task LoadIntoBufferAsync(System.Int64 maxBufferSize) { }
        private System.Threading.Tasks.Task<System.String> ReadAsStringAsync() { }
        private System.Text.Encoding GetEncodingFromBuffer(System.Byte[] buffer, System.Int32 length, System.Int32& preambleLength) { }
        private System.Int32 StartsWith(System.Byte[] array, System.Int32 length, System.Byte[] value) { }
        private System.Threading.Tasks.Task SerializeToStreamAsync_internal(System.IO.Stream stream, System.Net.TransportContext context) { }
        private System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context) { }
        private System.Boolean TryComputeLength(System.Int64& length) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000012
    public class HttpMessageHandler, IDisposable
    {
        // Methods
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000013
    public class HttpMessageInvoker, IDisposable
    {
        // Fields
        private System.Net.Http.HttpMessageHandler handler;        // 0x10
        private readonly System.Boolean disposeHandler;        // 0x18

        // Methods
        private System.Void .ctor(System.Net.Http.HttpMessageHandler handler, System.Boolean disposeHandler) { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { }

    }

    // TypeToken: 0x2000014
    public class HttpMethod, IEquatable`1
    {
        // Fields
        private static readonly System.Net.Http.HttpMethod delete_method;        // 0x0
        private static readonly System.Net.Http.HttpMethod get_method;        // 0x8
        private static readonly System.Net.Http.HttpMethod head_method;        // 0x10
        private static readonly System.Net.Http.HttpMethod options_method;        // 0x18
        private static readonly System.Net.Http.HttpMethod post_method;        // 0x20
        private static readonly System.Net.Http.HttpMethod put_method;        // 0x28
        private static readonly System.Net.Http.HttpMethod trace_method;        // 0x30
        private readonly System.String method;        // 0x10

        // Methods
        private System.Void .ctor(System.String method) { }
        private System.String get_Method() { }
        private System.Net.Http.HttpMethod get_Post() { }
        private System.Boolean op_Equality(System.Net.Http.HttpMethod left, System.Net.Http.HttpMethod right) { }
        private System.Boolean Equals(System.Net.Http.HttpMethod other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000015
    public class HttpRequestException : Exception
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String message) { }
        private System.Void .ctor(System.String message, System.Exception inner) { }

    }

    // TypeToken: 0x2000016
    public class HttpRequestMessage, IDisposable
    {
        // Fields
        private System.Net.Http.Headers.HttpRequestHeaders headers;        // 0x10
        private System.Net.Http.HttpMethod method;        // 0x18
        private System.Version version;        // 0x20
        private System.Uri uri;        // 0x28
        private System.Boolean is_used;        // 0x30
        private System.Boolean disposed;        // 0x31
        private System.Net.Http.HttpContent <Content>k__BackingField;        // 0x38

        // Methods
        private System.Void .ctor(System.Net.Http.HttpMethod method, System.String requestUri) { }
        private System.Void .ctor(System.Net.Http.HttpMethod method, System.Uri requestUri) { }
        private System.Net.Http.HttpContent get_Content() { }
        private System.Void set_Content(System.Net.Http.HttpContent value) { }
        private System.Net.Http.Headers.HttpRequestHeaders get_Headers() { }
        private System.Net.Http.HttpMethod get_Method() { }
        private System.Void set_Method(System.Net.Http.HttpMethod value) { }
        private System.Uri get_RequestUri() { }
        private System.Void set_RequestUri(System.Uri value) { }
        private System.Boolean IsAllowedAbsoluteUri(System.Uri uri) { }
        private System.Version get_Version() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Boolean SetIsUsed() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000017
    public class HttpResponseMessage, IDisposable
    {
        // Fields
        private System.Net.Http.Headers.HttpResponseHeaders headers;        // 0x10
        private System.String reasonPhrase;        // 0x18
        private System.Net.HttpStatusCode statusCode;        // 0x20
        private System.Version version;        // 0x28
        private System.Boolean disposed;        // 0x30
        private System.Net.Http.HttpContent <Content>k__BackingField;        // 0x38
        private System.Net.Http.HttpRequestMessage <RequestMessage>k__BackingField;        // 0x40

        // Methods
        private System.Void .ctor(System.Net.HttpStatusCode statusCode) { }
        private System.Net.Http.HttpContent get_Content() { }
        private System.Void set_Content(System.Net.Http.HttpContent value) { }
        private System.Net.Http.Headers.HttpResponseHeaders get_Headers() { }
        private System.String get_ReasonPhrase() { }
        private System.Void set_ReasonPhrase(System.String value) { }
        private System.Void set_RequestMessage(System.Net.Http.HttpRequestMessage value) { }
        private System.Net.HttpStatusCode get_StatusCode() { }
        private System.Void set_StatusCode(System.Net.HttpStatusCode value) { }
        private System.Version get_Version() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000018
    public class MultipartContent : HttpContent, IEnumerable`1, IEnumerable
    {
        // Fields
        private System.Collections.Generic.List<System.Net.Http.HttpContent> nested_content;        // 0x28
        private readonly System.String boundary;        // 0x30

        // Methods
        private System.Void .ctor(System.String subtype) { }
        private System.Void .ctor(System.String subtype, System.String boundary) { }
        private System.Boolean IsValidRFC2049(System.String s) { }
        private System.Void Add(System.Net.Http.HttpContent content) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context) { }
        private System.Boolean TryComputeLength(System.Int64& length) { }
        private System.Collections.Generic.IEnumerator<System.Net.Http.HttpContent> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x200001A
    public class MultipartFormDataContent : MultipartContent
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void Add(System.Net.Http.HttpContent content) { }
        private System.Void Add(System.Net.Http.HttpContent content, System.String name) { }
        private System.Void Add(System.Net.Http.HttpContent content, System.String name, System.String fileName) { }
        private System.Void AddContentDisposition(System.Net.Http.HttpContent content, System.String name, System.String fileName) { }

    }

    // TypeToken: 0x200001B
    public class StreamContent : HttpContent
    {
        // Fields
        private readonly System.IO.Stream content;        // 0x28
        private readonly System.Int32 bufferSize;        // 0x30
        private readonly System.Threading.CancellationToken cancellationToken;        // 0x38
        private readonly System.Int64 startPosition;        // 0x40
        private System.Boolean contentCopied;        // 0x48

        // Methods
        private System.Void .ctor(System.IO.Stream content) { }
        private System.Void .ctor(System.IO.Stream content, System.Int32 bufferSize) { }
        private System.Void .ctor(System.IO.Stream content, System.Threading.CancellationToken cancellationToken) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context) { }
        private System.Boolean TryComputeLength(System.Int64& length) { }

    }

    // TypeToken: 0x200001C
    public class StringContent : ByteArrayContent
    {
        // Methods
        private System.Void .ctor(System.String content) { }
        private System.Void .ctor(System.String content, System.Text.Encoding encoding, System.String mediaType) { }
        private System.Byte[] GetByteArray(System.String content, System.Text.Encoding encoding) { }

    }

}

namespace System.Net.Http.Headers
{

    // TypeToken: 0x200001D
    public class AuthenticationHeaderValue, ICloneable
    {
        // Fields
        private System.String <Parameter>k__BackingField;        // 0x10
        private System.String <Scheme>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor(System.String scheme, System.String parameter) { }
        private System.Void .ctor() { }
        private System.String get_Parameter() { }
        private System.Void set_Parameter(System.String value) { }
        private System.String get_Scheme() { }
        private System.Void set_Scheme(System.String value) { }
        private System.Object System.ICloneable.Clone() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean TryParse(System.String input, System.Net.Http.Headers.AuthenticationHeaderValue& parsedValue) { }
        private System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.AuthenticationHeaderValue>& result) { }
        private System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.AuthenticationHeaderValue& parsedValue, System.Net.Http.Headers.Token& t) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200001E
    public class CacheControlHeaderValue, ICloneable
    {
        // Fields
        private System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue> extensions;        // 0x10
        private System.Collections.Generic.List<System.String> no_cache_headers;        // 0x18
        private System.Collections.Generic.List<System.String> private_headers;        // 0x20
        private System.Nullable<System.TimeSpan> <MaxAge>k__BackingField;        // 0x28
        private System.Boolean <MaxStale>k__BackingField;        // 0x38
        private System.Nullable<System.TimeSpan> <MaxStaleLimit>k__BackingField;        // 0x40
        private System.Nullable<System.TimeSpan> <MinFresh>k__BackingField;        // 0x50
        private System.Boolean <MustRevalidate>k__BackingField;        // 0x60
        private System.Boolean <NoCache>k__BackingField;        // 0x61
        private System.Boolean <NoStore>k__BackingField;        // 0x62
        private System.Boolean <NoTransform>k__BackingField;        // 0x63
        private System.Boolean <OnlyIfCached>k__BackingField;        // 0x64
        private System.Boolean <Private>k__BackingField;        // 0x65
        private System.Boolean <ProxyRevalidate>k__BackingField;        // 0x66
        private System.Boolean <Public>k__BackingField;        // 0x67
        private System.Nullable<System.TimeSpan> <SharedMaxAge>k__BackingField;        // 0x68

        // Methods
        private System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue> get_Extensions() { }
        private System.Nullable<System.TimeSpan> get_MaxAge() { }
        private System.Void set_MaxAge(System.Nullable<System.TimeSpan> value) { }
        private System.Boolean get_MaxStale() { }
        private System.Void set_MaxStale(System.Boolean value) { }
        private System.Nullable<System.TimeSpan> get_MaxStaleLimit() { }
        private System.Void set_MaxStaleLimit(System.Nullable<System.TimeSpan> value) { }
        private System.Nullable<System.TimeSpan> get_MinFresh() { }
        private System.Void set_MinFresh(System.Nullable<System.TimeSpan> value) { }
        private System.Boolean get_MustRevalidate() { }
        private System.Void set_MustRevalidate(System.Boolean value) { }
        private System.Boolean get_NoCache() { }
        private System.Void set_NoCache(System.Boolean value) { }
        private System.Collections.Generic.ICollection<System.String> get_NoCacheHeaders() { }
        private System.Boolean get_NoStore() { }
        private System.Void set_NoStore(System.Boolean value) { }
        private System.Boolean get_NoTransform() { }
        private System.Void set_NoTransform(System.Boolean value) { }
        private System.Boolean get_OnlyIfCached() { }
        private System.Void set_OnlyIfCached(System.Boolean value) { }
        private System.Boolean get_Private() { }
        private System.Void set_Private(System.Boolean value) { }
        private System.Collections.Generic.ICollection<System.String> get_PrivateHeaders() { }
        private System.Boolean get_ProxyRevalidate() { }
        private System.Void set_ProxyRevalidate(System.Boolean value) { }
        private System.Boolean get_Public() { }
        private System.Void set_Public(System.Boolean value) { }
        private System.Nullable<System.TimeSpan> get_SharedMaxAge() { }
        private System.Void set_SharedMaxAge(System.Nullable<System.TimeSpan> value) { }
        private System.Object System.ICloneable.Clone() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean TryParse(System.String input, System.Net.Http.Headers.CacheControlHeaderValue& parsedValue) { }
        private System.String ToString() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001F
    public class CollectionExtensions
    {
        // Methods
        private System.Boolean SequenceEqual(System.Collections.Generic.List<TSource> first, System.Collections.Generic.List<TSource> second) { }
        private System.Void SetValue(System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue> parameters, System.String key, System.String value) { }
        private System.String ToString(System.Collections.Generic.List<T> list) { }
        private System.Void ToStringBuilder(System.Collections.Generic.List<T> list, System.Text.StringBuilder sb) { }

    }

    // TypeToken: 0x2000020
    public class ElementTryParser`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(System.Net.Http.Headers.Lexer lexer, T& parsedValue, System.Net.Http.Headers.Token& token) { }

    }

    // TypeToken: 0x2000021
    public class CollectionParser
    {
        // Methods
        private System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Net.Http.Headers.ElementTryParser<T> parser, System.Collections.Generic.List<T>& result) { }
        private System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.String>& result) { }
        private System.Boolean TryParseStringElement(System.Net.Http.Headers.Lexer lexer, System.String& parsedValue, System.Net.Http.Headers.Token& t) { }

    }

    // TypeToken: 0x2000022
    public class ContentDispositionHeaderValue, ICloneable
    {
        // Fields
        private System.String dispositionType;        // 0x10
        private System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue> parameters;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String dispositionType) { }
        private System.Void .ctor(System.Net.Http.Headers.ContentDispositionHeaderValue source) { }
        private System.Void set_DispositionType(System.String value) { }
        private System.Void set_FileName(System.String value) { }
        private System.Void set_FileNameStar(System.String value) { }
        private System.Void set_Name(System.String value) { }
        private System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue> get_Parameters() { }
        private System.Object System.ICloneable.Clone() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.String EncodeBase64Value(System.String value) { }
        private System.String EncodeRFC5987(System.String value) { }
        private System.Int32 GetHashCode() { }
        private System.Void SetValue(System.String key, System.String value) { }
        private System.String ToString() { }
        private System.Boolean TryParse(System.String input, System.Net.Http.Headers.ContentDispositionHeaderValue& parsedValue) { }

    }

    // TypeToken: 0x2000023
    public class ContentRangeHeaderValue, ICloneable
    {
        // Fields
        private System.String unit;        // 0x10
        private System.Nullable<System.Int64> <From>k__BackingField;        // 0x18
        private System.Nullable<System.Int64> <Length>k__BackingField;        // 0x28
        private System.Nullable<System.Int64> <To>k__BackingField;        // 0x38

        // Methods
        private System.Void .ctor() { }
        private System.Nullable<System.Int64> get_From() { }
        private System.Void set_From(System.Nullable<System.Int64> value) { }
        private System.Nullable<System.Int64> get_Length() { }
        private System.Void set_Length(System.Nullable<System.Int64> value) { }
        private System.Nullable<System.Int64> get_To() { }
        private System.Void set_To(System.Nullable<System.Int64> value) { }
        private System.String get_Unit() { }
        private System.Object System.ICloneable.Clone() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean TryParse(System.String input, System.Net.Http.Headers.ContentRangeHeaderValue& parsedValue) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000024
    public class EntityTagHeaderValue, ICloneable
    {
        // Fields
        private static readonly System.Net.Http.Headers.EntityTagHeaderValue any;        // 0x0
        private System.Boolean <IsWeak>k__BackingField;        // 0x10
        private System.String <Tag>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Boolean get_IsWeak() { }
        private System.Void set_IsWeak(System.Boolean value) { }
        private System.String get_Tag() { }
        private System.Void set_Tag(System.String value) { }
        private System.Object System.ICloneable.Clone() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean TryParse(System.String input, System.Net.Http.Headers.EntityTagHeaderValue& parsedValue) { }
        private System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.EntityTagHeaderValue& parsedValue, System.Net.Http.Headers.Token& t) { }
        private System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.EntityTagHeaderValue>& result) { }
        private System.String ToString() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000025
    public class HashCodeCalculator
    {
        // Methods
        private System.Int32 Calculate(System.Collections.Generic.ICollection<T> list) { }

    }

    // TypeToken: 0x2000026
    public class TryParseDelegate`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(System.String value, T& result) { }

    }

    // TypeToken: 0x2000027
    public class TryParseListDelegate`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(System.String value, System.Int32 minimalCount, System.Collections.Generic.List<T>& result) { }

    }

    // TypeToken: 0x2000028
    public class HeaderInfo
    {
        // Fields
        public System.Boolean AllowsMany;        // 0x10
        public readonly System.Net.Http.Headers.HttpHeaderKind HeaderKind;        // 0x14
        public readonly System.String Name;        // 0x18
        private System.Func<System.Object,System.String> <CustomToString>k__BackingField;        // 0x20

        // Methods
        private System.Void .ctor(System.String name, System.Net.Http.Headers.HttpHeaderKind headerKind) { }
        private System.Net.Http.Headers.HeaderInfo CreateSingle(System.String name, System.Net.Http.Headers.TryParseDelegate<T> parser, System.Net.Http.Headers.HttpHeaderKind headerKind, System.Func<System.Object,System.String> toString) { }
        private System.Net.Http.Headers.HeaderInfo CreateMulti(System.String name, System.Net.Http.Headers.TryParseListDelegate<T> elementParser, System.Net.Http.Headers.HttpHeaderKind headerKind, System.Int32 minimalCount, System.String separator) { }
        private System.Object CreateCollection(System.Net.Http.Headers.HttpHeaders headers) { }
        private System.Func<System.Object,System.String> get_CustomToString() { }
        private System.Void set_CustomToString(System.Func<System.Object,System.String> value) { }
        private System.String get_Separator() { }
        private System.Void AddToCollection(System.Object collection, System.Object value) { }
        private System.Object CreateCollection(System.Net.Http.Headers.HttpHeaders headers, System.Net.Http.Headers.HeaderInfo headerInfo) { }
        private System.Collections.Generic.List<System.String> ToStringCollection(System.Object collection) { }
        private System.Boolean TryParse(System.String value, System.Object& result) { }

    }

    // TypeToken: 0x200002B
    public class HttpContentHeaders : HttpHeaders
    {
        // Fields
        private readonly System.Net.Http.HttpContent content;        // 0x20

        // Methods
        private System.Void .ctor(System.Net.Http.HttpContent content) { }
        private System.Net.Http.Headers.ContentDispositionHeaderValue get_ContentDisposition() { }
        private System.Void set_ContentDisposition(System.Net.Http.Headers.ContentDispositionHeaderValue value) { }
        private System.Nullable<System.Int64> get_ContentLength() { }
        private System.Void set_ContentLength(System.Nullable<System.Int64> value) { }
        private System.Net.Http.Headers.MediaTypeHeaderValue get_ContentType() { }
        private System.Void set_ContentType(System.Net.Http.Headers.MediaTypeHeaderValue value) { }

    }

    // TypeToken: 0x200002C
    public struct HttpHeaderKind
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Net.Http.Headers.HttpHeaderKind None;        // 0x0
        public static System.Net.Http.Headers.HttpHeaderKind Request;        // 0x0
        public static System.Net.Http.Headers.HttpHeaderKind Response;        // 0x0
        public static System.Net.Http.Headers.HttpHeaderKind Content;        // 0x0

    }

    // TypeToken: 0x200002D
    public class HttpHeaderValueCollection`1, ICollection`1, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly System.Collections.Generic.List<T> list;        // 0x0
        private readonly System.Net.Http.Headers.HttpHeaders headers;        // 0x0
        private readonly System.Net.Http.Headers.HeaderInfo headerInfo;        // 0x0
        private System.Collections.Generic.List<System.String> invalidValues;        // 0x0

        // Methods
        private System.Void .ctor(System.Net.Http.Headers.HttpHeaders headers, System.Net.Http.Headers.HeaderInfo headerInfo) { }
        private System.Int32 get_Count() { }
        private System.Collections.Generic.List<System.String> get_InvalidValues() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Void Add(T item) { }
        private System.Void AddRange(System.Collections.Generic.List<T> values) { }
        private System.Void AddInvalidValue(System.String invalidValue) { }
        private System.Void Clear() { }
        private System.Boolean Contains(T item) { }
        private System.Void CopyTo(T[] array, System.Int32 arrayIndex) { }
        private System.Boolean Remove(T item) { }
        private System.String ToString() { }
        private System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private T Find(System.Predicate<T> predicate) { }

    }

    // TypeToken: 0x200002E
    public class HttpHeaders, IEnumerable`1, IEnumerable
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<System.String,System.Net.Http.Headers.HeaderInfo> known_headers;        // 0x0
        private readonly System.Collections.Generic.Dictionary<System.String,System.Net.Http.Headers.HttpHeaders.HeaderBucket> headers;        // 0x10
        private readonly System.Net.Http.Headers.HttpHeaderKind HeaderKind;        // 0x18
        private System.Nullable<System.Boolean> connectionclose;        // 0x1C
        private System.Nullable<System.Boolean> transferEncodingChunked;        // 0x1E

        // Methods
        private System.Void .cctor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Net.Http.Headers.HttpHeaderKind headerKind) { }
        private System.Boolean AddInternal(System.String name, System.Collections.Generic.IEnumerable<System.String> values, System.Net.Http.Headers.HeaderInfo headerInfo, System.Boolean ignoreInvalid) { }
        private System.Boolean TryAddWithoutValidation(System.String name, System.Collections.Generic.IEnumerable<System.String> values) { }
        private System.Net.Http.Headers.HeaderInfo CheckName(System.String name) { }
        private System.Boolean TryCheckName(System.String name, System.Net.Http.Headers.HeaderInfo& headerInfo) { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Boolean Remove(System.String name) { }
        private System.String GetSingleHeaderString(System.String key, System.Collections.Generic.IEnumerable<System.String> values) { }
        private System.String ToString() { }
        private System.Void AddOrRemove(System.String name, T value, System.Func<System.Object,System.String> converter) { }
        private System.Void AddOrRemove(System.String name, System.Nullable<T> value) { }
        private System.Void AddOrRemove(System.String name, System.Nullable<T> value, System.Func<System.Object,System.String> converter) { }
        private System.Collections.Generic.List<System.String> GetAllHeaderValues(System.Net.Http.Headers.HttpHeaders.HeaderBucket bucket, System.Net.Http.Headers.HeaderInfo headerInfo) { }
        private System.Net.Http.Headers.HttpHeaderKind GetKnownHeaderKind(System.String name) { }
        private T GetValue(System.String name) { }
        private System.Net.Http.Headers.HttpHeaderValueCollection<T> GetValues(System.String name) { }
        private System.Void SetValue(System.String name, T value, System.Func<System.Object,System.String> toStringConverter) { }

    }

    // TypeToken: 0x2000031
    public class HttpRequestHeaders : HttpHeaders
    {
        // Fields
        private System.Nullable<System.Boolean> expectContinue;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.Void set_Authorization(System.Net.Http.Headers.AuthenticationHeaderValue value) { }
        private System.Net.Http.Headers.HttpHeaderValueCollection<System.String> get_Connection() { }
        private System.Nullable<System.Boolean> get_ConnectionClose() { }
        private System.Void set_ConnectionClose(System.Nullable<System.Boolean> value) { }
        private System.Nullable<System.Boolean> get_ExpectContinue() { }
        private System.String get_Host() { }
        private System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.TransferCodingHeaderValue> get_TransferEncoding() { }
        private System.Nullable<System.Boolean> get_TransferEncodingChunked() { }
        private System.Void AddHeaders(System.Net.Http.Headers.HttpRequestHeaders headers) { }

    }

    // TypeToken: 0x2000033
    public class HttpResponseHeaders : HttpHeaders
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000034
    public struct Token
    {
        // Fields
        public static readonly System.Net.Http.Headers.Token Empty;        // 0x0
        private readonly System.Net.Http.Headers.Token.Type type;        // 0x10
        private System.Int32 <StartPosition>k__BackingField;        // 0x14
        private System.Int32 <EndPosition>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor(System.Net.Http.Headers.Token.Type type, System.Int32 startPosition, System.Int32 endPosition) { }
        private System.Int32 get_StartPosition() { }
        private System.Void set_StartPosition(System.Int32 value) { }
        private System.Int32 get_EndPosition() { }
        private System.Void set_EndPosition(System.Int32 value) { }
        private System.Net.Http.Headers.Token.Type get_Kind() { }
        private System.Net.Http.Headers.Token.Type op_Implicit(System.Net.Http.Headers.Token token) { }
        private System.String ToString() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000036
    public class Lexer
    {
        // Fields
        private static readonly System.Boolean[] token_chars;        // 0x0
        private static readonly System.Int32 last_token_char;        // 0x8
        private static readonly System.String[] dt_formats;        // 0x10
        private readonly System.String s;        // 0x10
        private System.Int32 pos;        // 0x18

        // Methods
        private System.Void .ctor(System.String stream) { }
        private System.Int32 get_Position() { }
        private System.Void set_Position(System.Int32 value) { }
        private System.String GetStringValue(System.Net.Http.Headers.Token token) { }
        private System.String GetStringValue(System.Net.Http.Headers.Token start, System.Net.Http.Headers.Token end) { }
        private System.String GetQuotedStringValue(System.Net.Http.Headers.Token start) { }
        private System.String GetRemainingStringValue(System.Int32 position) { }
        private System.Boolean IsStarStringValue(System.Net.Http.Headers.Token token) { }
        private System.Boolean TryGetNumericValue(System.Net.Http.Headers.Token token, System.Int32& value) { }
        private System.Boolean TryGetNumericValue(System.Net.Http.Headers.Token token, System.Int64& value) { }
        private System.Nullable<System.TimeSpan> TryGetTimeSpanValue(System.Net.Http.Headers.Token token) { }
        private System.Boolean TryGetDateValue(System.Net.Http.Headers.Token token, System.DateTimeOffset& value) { }
        private System.Boolean TryGetDateValue(System.String text, System.DateTimeOffset& value) { }
        private System.Boolean TryGetDoubleValue(System.Net.Http.Headers.Token token, System.Double& value) { }
        private System.Boolean IsValidToken(System.String input) { }
        private System.Boolean IsValidCharacter(System.Char input) { }
        private System.Void EatChar() { }
        private System.Int32 PeekChar() { }
        private System.Boolean ScanCommentOptional(System.String& value, System.Net.Http.Headers.Token& readToken) { }
        private System.Net.Http.Headers.Token Scan(System.Boolean recognizeDash) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000037
    public class MediaTypeHeaderValue, ICloneable
    {
        // Fields
        private System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue> parameters;        // 0x10
        private System.String media_type;        // 0x18

        // Methods
        private System.Void .ctor(System.String mediaType) { }
        private System.Void .ctor(System.Net.Http.Headers.MediaTypeHeaderValue source) { }
        private System.Void .ctor() { }
        private System.String get_CharSet() { }
        private System.Void set_CharSet(System.String value) { }
        private System.Void set_MediaType(System.String value) { }
        private System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue> get_Parameters() { }
        private System.Object System.ICloneable.Clone() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Boolean TryParse(System.String input, System.Net.Http.Headers.MediaTypeHeaderValue& parsedValue) { }
        private System.Nullable<System.Net.Http.Headers.Token> TryParseMediaType(System.Net.Http.Headers.Lexer lexer, System.String& media) { }

    }

    // TypeToken: 0x2000039
    public class MediaTypeWithQualityHeaderValue : MediaTypeHeaderValue
    {
        // Methods
        private System.Void .ctor() { }
        private System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.MediaTypeWithQualityHeaderValue& parsedValue, System.Net.Http.Headers.Token& t) { }
        private System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.MediaTypeWithQualityHeaderValue>& result) { }

    }

    // TypeToken: 0x200003A
    public class NameValueHeaderValue, ICloneable
    {
        // Fields
        private System.String value;        // 0x10
        private System.String <Name>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor(System.String name, System.String value) { }
        private System.Void .ctor(System.Net.Http.Headers.NameValueHeaderValue source) { }
        private System.Void .ctor() { }
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private System.String get_Value() { }
        private System.Void set_Value(System.String value) { }
        private System.Net.Http.Headers.NameValueHeaderValue Create(System.String name, System.String value) { }
        private System.Object System.ICloneable.Clone() { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean TryParsePragma(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue>& result) { }
        private System.Boolean TryParseParameters(System.Net.Http.Headers.Lexer lexer, System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue>& result, System.Net.Http.Headers.Token& t) { }
        private System.String ToString() { }
        private System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.NameValueHeaderValue& parsedValue, System.Net.Http.Headers.Token& t) { }

    }

    // TypeToken: 0x200003B
    public class NameValueWithParametersHeaderValue : NameValueHeaderValue, ICloneable
    {
        // Fields
        private System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue> parameters;        // 0x20

        // Methods
        private System.Void .ctor(System.Net.Http.Headers.NameValueWithParametersHeaderValue source) { }
        private System.Void .ctor() { }
        private System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue> get_Parameters() { }
        private System.Object System.ICloneable.Clone() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.NameValueWithParametersHeaderValue>& result) { }
        private System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.NameValueWithParametersHeaderValue& parsedValue, System.Net.Http.Headers.Token& t) { }

    }

    // TypeToken: 0x200003C
    public class Parser
    {
    }

    // TypeToken: 0x2000048
    public class ProductHeaderValue, ICloneable
    {
        // Fields
        private System.String <Name>k__BackingField;        // 0x10
        private System.String <Version>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private System.String get_Version() { }
        private System.Void set_Version(System.String value) { }
        private System.Object System.ICloneable.Clone() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.ProductHeaderValue>& result) { }
        private System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.ProductHeaderValue& parsedValue, System.Net.Http.Headers.Token& t) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000049
    public class ProductInfoHeaderValue, ICloneable
    {
        // Fields
        private System.String <Comment>k__BackingField;        // 0x10
        private System.Net.Http.Headers.ProductHeaderValue <Product>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor(System.Net.Http.Headers.ProductHeaderValue product) { }
        private System.Void .ctor() { }
        private System.String get_Comment() { }
        private System.Void set_Comment(System.String value) { }
        private System.Net.Http.Headers.ProductHeaderValue get_Product() { }
        private System.Void set_Product(System.Net.Http.Headers.ProductHeaderValue value) { }
        private System.Object System.ICloneable.Clone() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.ProductInfoHeaderValue>& result) { }
        private System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.ProductInfoHeaderValue& parsedValue) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200004A
    public class RangeConditionHeaderValue, ICloneable
    {
        // Fields
        private System.Nullable<System.DateTimeOffset> <Date>k__BackingField;        // 0x10
        private System.Net.Http.Headers.EntityTagHeaderValue <EntityTag>k__BackingField;        // 0x28

        // Methods
        private System.Void .ctor(System.DateTimeOffset date) { }
        private System.Void .ctor(System.Net.Http.Headers.EntityTagHeaderValue entityTag) { }
        private System.Nullable<System.DateTimeOffset> get_Date() { }
        private System.Void set_Date(System.Nullable<System.DateTimeOffset> value) { }
        private System.Net.Http.Headers.EntityTagHeaderValue get_EntityTag() { }
        private System.Void set_EntityTag(System.Net.Http.Headers.EntityTagHeaderValue value) { }
        private System.Object System.ICloneable.Clone() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean TryParse(System.String input, System.Net.Http.Headers.RangeConditionHeaderValue& parsedValue) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200004B
    public class RangeHeaderValue, ICloneable
    {
        // Fields
        private System.Collections.Generic.List<System.Net.Http.Headers.RangeItemHeaderValue> ranges;        // 0x10
        private System.String unit;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Net.Http.Headers.RangeHeaderValue source) { }
        private System.Collections.Generic.ICollection<System.Net.Http.Headers.RangeItemHeaderValue> get_Ranges() { }
        private System.String get_Unit() { }
        private System.Object System.ICloneable.Clone() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean TryParse(System.String input, System.Net.Http.Headers.RangeHeaderValue& parsedValue) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200004C
    public class RangeItemHeaderValue, ICloneable
    {
        // Fields
        private System.Nullable<System.Int64> <From>k__BackingField;        // 0x10
        private System.Nullable<System.Int64> <To>k__BackingField;        // 0x20

        // Methods
        private System.Void .ctor(System.Nullable<System.Int64> from, System.Nullable<System.Int64> to) { }
        private System.Nullable<System.Int64> get_From() { }
        private System.Void set_From(System.Nullable<System.Int64> value) { }
        private System.Nullable<System.Int64> get_To() { }
        private System.Void set_To(System.Nullable<System.Int64> value) { }
        private System.Object System.ICloneable.Clone() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200004D
    public class RetryConditionHeaderValue, ICloneable
    {
        // Fields
        private System.Nullable<System.DateTimeOffset> <Date>k__BackingField;        // 0x10
        private System.Nullable<System.TimeSpan> <Delta>k__BackingField;        // 0x28

        // Methods
        private System.Void .ctor(System.DateTimeOffset date) { }
        private System.Void .ctor(System.TimeSpan delta) { }
        private System.Nullable<System.DateTimeOffset> get_Date() { }
        private System.Void set_Date(System.Nullable<System.DateTimeOffset> value) { }
        private System.Nullable<System.TimeSpan> get_Delta() { }
        private System.Void set_Delta(System.Nullable<System.TimeSpan> value) { }
        private System.Object System.ICloneable.Clone() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean TryParse(System.String input, System.Net.Http.Headers.RetryConditionHeaderValue& parsedValue) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200004E
    public class StringWithQualityHeaderValue, ICloneable
    {
        // Fields
        private System.Nullable<System.Double> <Quality>k__BackingField;        // 0x10
        private System.String <Value>k__BackingField;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.Nullable<System.Double> get_Quality() { }
        private System.Void set_Quality(System.Nullable<System.Double> value) { }
        private System.String get_Value() { }
        private System.Void set_Value(System.String value) { }
        private System.Object System.ICloneable.Clone() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.StringWithQualityHeaderValue>& result) { }
        private System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.StringWithQualityHeaderValue& parsedValue, System.Net.Http.Headers.Token& t) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200004F
    public class TransferCodingHeaderValue, ICloneable
    {
        // Fields
        private System.String value;        // 0x10
        private System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue> parameters;        // 0x18

        // Methods
        private System.Void .ctor(System.Net.Http.Headers.TransferCodingHeaderValue source) { }
        private System.Void .ctor() { }
        private System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue> get_Parameters() { }
        private System.String get_Value() { }
        private System.Object System.ICloneable.Clone() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.TransferCodingHeaderValue>& result) { }
        private System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.TransferCodingHeaderValue& parsedValue, System.Net.Http.Headers.Token& t) { }

    }

    // TypeToken: 0x2000050
    public class TransferCodingWithQualityHeaderValue : TransferCodingHeaderValue
    {
        // Methods
        private System.Void .ctor() { }
        private System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.TransferCodingWithQualityHeaderValue>& result) { }
        private System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.TransferCodingWithQualityHeaderValue& parsedValue, System.Net.Http.Headers.Token& t) { }

    }

    // TypeToken: 0x2000051
    public class ViaHeaderValue, ICloneable
    {
        // Fields
        private System.String <Comment>k__BackingField;        // 0x10
        private System.String <ProtocolName>k__BackingField;        // 0x18
        private System.String <ProtocolVersion>k__BackingField;        // 0x20
        private System.String <ReceivedBy>k__BackingField;        // 0x28

        // Methods
        private System.Void .ctor() { }
        private System.String get_Comment() { }
        private System.Void set_Comment(System.String value) { }
        private System.String get_ProtocolName() { }
        private System.Void set_ProtocolName(System.String value) { }
        private System.String get_ProtocolVersion() { }
        private System.Void set_ProtocolVersion(System.String value) { }
        private System.String get_ReceivedBy() { }
        private System.Void set_ReceivedBy(System.String value) { }
        private System.Object System.ICloneable.Clone() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.ViaHeaderValue>& result) { }
        private System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.ViaHeaderValue& parsedValue, System.Net.Http.Headers.Token& t) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000052
    public class WarningHeaderValue, ICloneable
    {
        // Fields
        private System.String <Agent>k__BackingField;        // 0x10
        private System.Int32 <Code>k__BackingField;        // 0x18
        private System.Nullable<System.DateTimeOffset> <Date>k__BackingField;        // 0x20
        private System.String <Text>k__BackingField;        // 0x38

        // Methods
        private System.Void .ctor() { }
        private System.String get_Agent() { }
        private System.Void set_Agent(System.String value) { }
        private System.Int32 get_Code() { }
        private System.Void set_Code(System.Int32 value) { }
        private System.Nullable<System.DateTimeOffset> get_Date() { }
        private System.Void set_Date(System.Nullable<System.DateTimeOffset> value) { }
        private System.String get_Text() { }
        private System.Void set_Text(System.String value) { }
        private System.Boolean IsCodeValid(System.Int32 code) { }
        private System.Object System.ICloneable.Clone() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.WarningHeaderValue>& result) { }
        private System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.WarningHeaderValue& parsedValue, System.Net.Http.Headers.Token& t) { }
        private System.String ToString() { }

    }

}

