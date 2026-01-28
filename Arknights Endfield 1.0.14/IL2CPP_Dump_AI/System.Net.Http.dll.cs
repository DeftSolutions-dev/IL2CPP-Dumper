// ========================================================
// Dumped by @desirepro
// Assembly: System.Net.Http.dll
// Classes:  84
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: FixedMemoryStream
TYPE:  class
TOKEN: 0x200000F
EXTENDS: MemoryStream
FIELDS:
  private   readonly System.Int64                    maxSize  // 0x50
METHODS:
  System.Void .ctor(System.Int64 maxSize)
  System.Void CheckOverflow(System.Int32 count)
  System.Void WriteByte(System.Byte value)
  System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 count)
END_CLASS

CLASS: HeaderTypeInfo`2
TYPE:  class
TOKEN: 0x2000029
EXTENDS: HeaderInfo
FIELDS:
  private   readonly System.Net.Http.Headers.TryParseDelegate<T>parser  // 0x0
METHODS:
  System.Void .ctor(System.String name, System.Net.Http.Headers.TryParseDelegate<T> parser, System.Net.Http.Headers.HttpHeaderKind headerKind)
  System.Void AddToCollection(System.Object collection, System.Object value)
  System.Object CreateCollection(System.Net.Http.Headers.HttpHeaders headers, System.Net.Http.Headers.HeaderInfo headerInfo)
  System.Collections.Generic.List<System.String> ToStringCollection(System.Object collection)
  System.Boolean TryParse(System.String value, System.Object& result)
END_CLASS

CLASS: CollectionHeaderTypeInfo`2
TYPE:  class
TOKEN: 0x200002A
EXTENDS: HeaderTypeInfo`2
FIELDS:
  private   readonly System.Int32                    minimalCount  // 0x0
  private   readonly System.String                   separator  // 0x0
  private   readonly System.Net.Http.Headers.TryParseListDelegate<T>parser  // 0x0
METHODS:
  System.Void .ctor(System.String name, System.Net.Http.Headers.TryParseListDelegate<T> parser, System.Net.Http.Headers.HttpHeaderKind headerKind, System.Int32 minimalCount, System.String separator)
  System.String get_Separator()
  System.Boolean TryParse(System.String value, System.Object& result)
END_CLASS

CLASS: HeaderBucket
TYPE:  class
TOKEN: 0x200002F
FIELDS:
  public            System.Object                   Parsed  // 0x10
  private           System.Collections.Generic.List<System.String>values  // 0x18
  public    readonly System.Func<System.Object,System.String>CustomToString  // 0x20
METHODS:
  System.Void .ctor(System.Object parsed, System.Func<System.Object,System.String> converter)
  System.Boolean get_HasStringValues()
  System.Collections.Generic.List<System.String> get_Values()
  System.Void set_Values(System.Collections.Generic.List<System.String> value)
  System.String ParsedToString()
END_CLASS

CLASS: Type
TYPE:  struct
TOKEN: 0x2000035
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.Http.Headers.Token.TypeError  // 0x0
  public    static  System.Net.Http.Headers.Token.TypeEnd  // 0x0
  public    static  System.Net.Http.Headers.Token.TypeToken  // 0x0
  public    static  System.Net.Http.Headers.Token.TypeQuotedString  // 0x0
  public    static  System.Net.Http.Headers.Token.TypeSeparatorEqual  // 0x0
  public    static  System.Net.Http.Headers.Token.TypeSeparatorSemicolon  // 0x0
  public    static  System.Net.Http.Headers.Token.TypeSeparatorSlash  // 0x0
  public    static  System.Net.Http.Headers.Token.TypeSeparatorDash  // 0x0
  public    static  System.Net.Http.Headers.Token.TypeSeparatorComma  // 0x0
  public    static  System.Net.Http.Headers.Token.TypeOpenParens  // 0x0
METHODS:
END_CLASS

CLASS: Token
TYPE:  class
TOKEN: 0x200003D
FIELDS:
METHODS:
  System.Void Check(System.String s)
  System.Boolean TryCheck(System.String s)
END_CLASS

CLASS: DateTime
TYPE:  class
TOKEN: 0x200003E
FIELDS:
  public    static readonly System.Func<System.Object,System.String>ToString  // 0x0
METHODS:
  System.Boolean TryParse(System.String input, System.DateTimeOffset& result)
  System.Void .cctor()
END_CLASS

CLASS: EmailAddress
TYPE:  class
TOKEN: 0x2000040
FIELDS:
METHODS:
  System.Boolean TryParse(System.String input, System.String& result)
END_CLASS

CLASS: Host
TYPE:  class
TOKEN: 0x2000041
FIELDS:
METHODS:
  System.Boolean TryParse(System.String input, System.String& result)
END_CLASS

CLASS: Int
TYPE:  class
TOKEN: 0x2000042
FIELDS:
METHODS:
  System.Boolean TryParse(System.String input, System.Int32& result)
END_CLASS

CLASS: Long
TYPE:  class
TOKEN: 0x2000043
FIELDS:
METHODS:
  System.Boolean TryParse(System.String input, System.Int64& result)
END_CLASS

CLASS: MD5
TYPE:  class
TOKEN: 0x2000044
FIELDS:
  public    static readonly System.Func<System.Object,System.String>ToString  // 0x0
METHODS:
  System.Boolean TryParse(System.String input, System.Byte[]& result)
  System.Void .cctor()
END_CLASS

CLASS: TimeSpanSeconds
TYPE:  class
TOKEN: 0x2000046
FIELDS:
METHODS:
  System.Boolean TryParse(System.String input, System.TimeSpan& result)
END_CLASS

CLASS: Uri
TYPE:  class
TOKEN: 0x2000047
FIELDS:
METHODS:
  System.Boolean TryParse(System.String input, System.Uri& result)
END_CLASS

CLASS: __StaticArrayInitTypeSize=127
TYPE:  struct
TOKEN: 0x2000054
FIELDS:
METHODS:
END_CLASS

CLASS: System.Net.Http.HttpClientHandler
TYPE:  class
TOKEN: 0x2000002
EXTENDS: HttpMessageHandler
FIELDS:
  private   readonly System.Net.Http.IMonoHttpClientHandler_delegatingHandler  // 0x10
  private           System.Net.Http.ClientCertificateOption_clientCertificateOptions  // 0x18
METHODS:
  System.Net.Http.IMonoHttpClientHandler CreateDefaultHandler()
  System.Void .ctor()
  System.Void .ctor(System.Net.Http.IMonoHttpClientHandler handler)
  System.Void Dispose(System.Boolean disposing)
  System.Void ThrowForModifiedManagedSslOptionsIfStarted()
  System.Net.Http.ClientCertificateOption get_ClientCertificateOptions()
  System.Void set_ClientCertificateOptions(System.Net.Http.ClientCertificateOption value)
  System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates()
  System.Void SetWebRequestTimeout(System.TimeSpan timeout)
  System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
  System.Security.Cryptography.X509Certificates.X509Certificate <set_ClientCertificateOptions>b__23_0(System.Object sender, System.String targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, System.String[] acceptableIssuers)
END_CLASS

CLASS: System.Net.Http.IMonoHttpClientHandler
TYPE:  interface
TOKEN: 0x2000004
FIELDS:
METHODS:
  System.Net.Security.SslClientAuthenticationOptions get_SslOptions()
  System.Void set_SslOptions(System.Net.Security.SslClientAuthenticationOptions value)
  System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
  System.Void SetWebRequestTimeout(System.TimeSpan timeout)
END_CLASS

CLASS: System.Net.Http.MonoWebRequestHandler
TYPE:  class
TOKEN: 0x2000005
FIELDS:
  private   static  System.Int64                    groupCounter  // 0x0
  private           System.Boolean                  allowAutoRedirect  // 0x10
  private           System.Net.DecompressionMethods automaticDecompression  // 0x14
  private           System.Net.CookieContainer      cookieContainer  // 0x18
  private           System.Net.ICredentials         credentials  // 0x20
  private           System.Int32                    maxAutomaticRedirections  // 0x28
  private           System.Int64                    maxRequestContentBufferSize  // 0x30
  private           System.Boolean                  preAuthenticate  // 0x38
  private           System.Net.IWebProxy            proxy  // 0x40
  private           System.Boolean                  useCookies  // 0x48
  private           System.Boolean                  useProxy  // 0x49
  private           System.Net.Security.SslClientAuthenticationOptionssslOptions  // 0x50
  private           System.Boolean                  allowPipelining  // 0x58
  private           System.Net.Cache.RequestCachePolicycachePolicy  // 0x60
  private           System.Net.Security.AuthenticationLevelauthenticationLevel  // 0x68
  private           System.TimeSpan                 continueTimeout  // 0x70
  private           System.Security.Principal.TokenImpersonationLevelimpersonationLevel  // 0x78
  private           System.Int32                    maxResponseHeadersLength  // 0x7C
  private           System.Int32                    readWriteTimeout  // 0x80
  private           System.Net.Security.RemoteCertificateValidationCallbackserverCertificateValidationCallback  // 0x88
  private           System.Boolean                  unsafeAuthenticatedConnectionSharing  // 0x90
  private           System.Boolean                  sentRequest  // 0x91
  private           System.String                   connectionGroupName  // 0x98
  private           System.Nullable<System.TimeSpan>timeout  // 0xA0
  private           System.Boolean                  disposed  // 0xB0
METHODS:
  System.Void .ctor()
  System.Void EnsureModifiability()
  System.Net.CookieContainer get_CookieContainer()
  System.Int64 get_MaxRequestContentBufferSize()
  System.Net.Security.SslClientAuthenticationOptions get_SslOptions()
  System.Void set_SslOptions(System.Net.Security.SslClientAuthenticationOptions value)
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Boolean GetConnectionKeepAlive(System.Net.Http.Headers.HttpRequestHeaders headers)
  System.Net.HttpWebRequest CreateWebRequest(System.Net.Http.HttpRequestMessage request)
  System.Net.Http.HttpResponseMessage CreateResponseMessage(System.Net.HttpWebResponse wr, System.Net.Http.HttpRequestMessage requestMessage, System.Threading.CancellationToken cancellationToken)
  System.Boolean MethodHasBody(System.Net.Http.HttpMethod method)
  System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
  System.Void System.Net.Http.IMonoHttpClientHandler.SetWebRequestTimeout(System.TimeSpan timeout)
END_CLASS

CLASS: System.Net.Http.PlatformHelper
TYPE:  class
TOKEN: 0x2000008
FIELDS:
METHODS:
  System.Boolean IsContentHeader(System.String name)
  System.String GetSingleHeaderString(System.String name, System.Collections.Generic.IEnumerable<System.String> values)
  System.Net.Http.StreamContent CreateStreamContent(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken)
END_CLASS

CLASS: System.Net.Http.ByteArrayContent
TYPE:  class
TOKEN: 0x2000009
EXTENDS: HttpContent
FIELDS:
  private   readonly System.Byte[]                   content  // 0x28
  private   readonly System.Int32                    offset  // 0x30
  private   readonly System.Int32                    count  // 0x34
METHODS:
  System.Void .ctor(System.Byte[] content)
  System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context)
  System.Boolean TryComputeLength(System.Int64& length)
END_CLASS

CLASS: System.Net.Http.ClientCertificateOption
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.Http.ClientCertificateOptionManual  // 0x0
  public    static  System.Net.Http.ClientCertificateOptionAutomatic  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.Http.HttpClient
TYPE:  class
TOKEN: 0x200000B
EXTENDS: HttpMessageInvoker
FIELDS:
  private   static readonly System.TimeSpan                 TimeoutDefault  // 0x0
  private           System.Uri                      base_address  // 0x20
  private           System.Threading.CancellationTokenSourcects  // 0x28
  private           System.Boolean                  disposed  // 0x30
  private           System.Net.Http.Headers.HttpRequestHeadersheaders  // 0x38
  private           System.Int64                    buffer_size  // 0x40
  private           System.TimeSpan                 timeout  // 0x48
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Net.Http.HttpMessageHandler handler, System.Boolean disposeHandler)
  System.Net.Http.Headers.HttpRequestHeaders get_DefaultRequestHeaders()
  System.Int64 get_MaxResponseContentBufferSize()
  System.Void Dispose(System.Boolean disposing)
  System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PostAsync(System.String requestUri, System.Net.Http.HttpContent content)
  System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request)
  System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Net.Http.HttpCompletionOption completionOption, System.Threading.CancellationToken cancellationToken)
  System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsyncWorker(System.Net.Http.HttpRequestMessage request, System.Net.Http.HttpCompletionOption completionOption, System.Threading.CancellationToken cancellationToken)
  System.Void .cctor()
  System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> <>n__0(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
END_CLASS

CLASS: System.Net.Http.HttpCompletionOption
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.Http.HttpCompletionOptionResponseContentRead  // 0x0
  public    static  System.Net.Http.HttpCompletionOptionResponseHeadersRead  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.Http.HttpContent
TYPE:  class
TOKEN: 0x200000E
FIELDS:
  private           System.Net.Http.HttpContent.FixedMemoryStreambuffer  // 0x10
  private           System.Boolean                  disposed  // 0x18
  private           System.Net.Http.Headers.HttpContentHeadersheaders  // 0x20
METHODS:
  System.Net.Http.Headers.HttpContentHeaders get_Headers()
  System.Nullable<System.Int64> get_LoadedBufferLength()
  System.Threading.Tasks.Task CopyToAsync(System.IO.Stream stream)
  System.Threading.Tasks.Task CopyToAsync(System.IO.Stream stream, System.Net.TransportContext context)
  System.Net.Http.HttpContent.FixedMemoryStream CreateFixedMemoryStream(System.Int64 maxBufferSize)
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Threading.Tasks.Task LoadIntoBufferAsync()
  System.Threading.Tasks.Task LoadIntoBufferAsync(System.Int64 maxBufferSize)
  System.Threading.Tasks.Task<System.String> ReadAsStringAsync()
  System.Text.Encoding GetEncodingFromBuffer(System.Byte[] buffer, System.Int32 length, System.Int32& preambleLength)
  System.Int32 StartsWith(System.Byte[] array, System.Int32 length, System.Byte[] value)
  System.Threading.Tasks.Task SerializeToStreamAsync_internal(System.IO.Stream stream, System.Net.TransportContext context)
  System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context)
  System.Boolean TryComputeLength(System.Int64& length)
  System.Void .ctor()
END_CLASS

CLASS: System.Net.Http.HttpMessageHandler
TYPE:  class
TOKEN: 0x2000012
FIELDS:
METHODS:
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
  System.Void .ctor()
END_CLASS

CLASS: System.Net.Http.HttpMessageInvoker
TYPE:  class
TOKEN: 0x2000013
FIELDS:
  private           System.Net.Http.HttpMessageHandlerhandler  // 0x10
  private   readonly System.Boolean                  disposeHandler  // 0x18
METHODS:
  System.Void .ctor(System.Net.Http.HttpMessageHandler handler, System.Boolean disposeHandler)
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
END_CLASS

CLASS: System.Net.Http.HttpMethod
TYPE:  class
TOKEN: 0x2000014
FIELDS:
  private   static readonly System.Net.Http.HttpMethod      delete_method  // 0x0
  private   static readonly System.Net.Http.HttpMethod      get_method  // 0x8
  private   static readonly System.Net.Http.HttpMethod      head_method  // 0x10
  private   static readonly System.Net.Http.HttpMethod      options_method  // 0x18
  private   static readonly System.Net.Http.HttpMethod      post_method  // 0x20
  private   static readonly System.Net.Http.HttpMethod      put_method  // 0x28
  private   static readonly System.Net.Http.HttpMethod      trace_method  // 0x30
  private   readonly System.String                   method  // 0x10
METHODS:
  System.Void .ctor(System.String method)
  System.String get_Method()
  System.Net.Http.HttpMethod get_Post()
  System.Boolean op_Equality(System.Net.Http.HttpMethod left, System.Net.Http.HttpMethod right)
  System.Boolean Equals(System.Net.Http.HttpMethod other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void .cctor()
END_CLASS

CLASS: System.Net.Http.HttpRequestException
TYPE:  class
TOKEN: 0x2000015
EXTENDS: Exception
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String message)
  System.Void .ctor(System.String message, System.Exception inner)
END_CLASS

CLASS: System.Net.Http.HttpRequestMessage
TYPE:  class
TOKEN: 0x2000016
FIELDS:
  private           System.Net.Http.Headers.HttpRequestHeadersheaders  // 0x10
  private           System.Net.Http.HttpMethod      method  // 0x18
  private           System.Version                  version  // 0x20
  private           System.Uri                      uri  // 0x28
  private           System.Boolean                  is_used  // 0x30
  private           System.Boolean                  disposed  // 0x31
  private           System.Net.Http.HttpContent     <Content>k__BackingField  // 0x38
METHODS:
  System.Void .ctor(System.Net.Http.HttpMethod method, System.String requestUri)
  System.Void .ctor(System.Net.Http.HttpMethod method, System.Uri requestUri)
  System.Net.Http.HttpContent get_Content()
  System.Void set_Content(System.Net.Http.HttpContent value)
  System.Net.Http.Headers.HttpRequestHeaders get_Headers()
  System.Net.Http.HttpMethod get_Method()
  System.Void set_Method(System.Net.Http.HttpMethod value)
  System.Uri get_RequestUri()
  System.Void set_RequestUri(System.Uri value)
  System.Boolean IsAllowedAbsoluteUri(System.Uri uri)
  System.Version get_Version()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Boolean SetIsUsed()
  System.String ToString()
END_CLASS

CLASS: System.Net.Http.HttpResponseMessage
TYPE:  class
TOKEN: 0x2000017
FIELDS:
  private           System.Net.Http.Headers.HttpResponseHeadersheaders  // 0x10
  private           System.String                   reasonPhrase  // 0x18
  private           System.Net.HttpStatusCode       statusCode  // 0x20
  private           System.Version                  version  // 0x28
  private           System.Boolean                  disposed  // 0x30
  private           System.Net.Http.HttpContent     <Content>k__BackingField  // 0x38
  private           System.Net.Http.HttpRequestMessage<RequestMessage>k__BackingField  // 0x40
METHODS:
  System.Void .ctor(System.Net.HttpStatusCode statusCode)
  System.Net.Http.HttpContent get_Content()
  System.Void set_Content(System.Net.Http.HttpContent value)
  System.Net.Http.Headers.HttpResponseHeaders get_Headers()
  System.String get_ReasonPhrase()
  System.Void set_ReasonPhrase(System.String value)
  System.Void set_RequestMessage(System.Net.Http.HttpRequestMessage value)
  System.Net.HttpStatusCode get_StatusCode()
  System.Void set_StatusCode(System.Net.HttpStatusCode value)
  System.Version get_Version()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.String ToString()
END_CLASS

CLASS: System.Net.Http.MultipartContent
TYPE:  class
TOKEN: 0x2000018
EXTENDS: HttpContent
FIELDS:
  private           System.Collections.Generic.List<System.Net.Http.HttpContent>nested_content  // 0x28
  private   readonly System.String                   boundary  // 0x30
METHODS:
  System.Void .ctor(System.String subtype)
  System.Void .ctor(System.String subtype, System.String boundary)
  System.Boolean IsValidRFC2049(System.String s)
  System.Void Add(System.Net.Http.HttpContent content)
  System.Void Dispose(System.Boolean disposing)
  System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context)
  System.Boolean TryComputeLength(System.Int64& length)
  System.Collections.Generic.IEnumerator<System.Net.Http.HttpContent> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: System.Net.Http.MultipartFormDataContent
TYPE:  class
TOKEN: 0x200001A
EXTENDS: MultipartContent
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void Add(System.Net.Http.HttpContent content)
  System.Void Add(System.Net.Http.HttpContent content, System.String name)
  System.Void Add(System.Net.Http.HttpContent content, System.String name, System.String fileName)
  System.Void AddContentDisposition(System.Net.Http.HttpContent content, System.String name, System.String fileName)
END_CLASS

CLASS: System.Net.Http.StreamContent
TYPE:  class
TOKEN: 0x200001B
EXTENDS: HttpContent
FIELDS:
  private   readonly System.IO.Stream                content  // 0x28
  private   readonly System.Int32                    bufferSize  // 0x30
  private   readonly System.Threading.CancellationTokencancellationToken  // 0x38
  private   readonly System.Int64                    startPosition  // 0x40
  private           System.Boolean                  contentCopied  // 0x48
METHODS:
  System.Void .ctor(System.IO.Stream content)
  System.Void .ctor(System.IO.Stream content, System.Int32 bufferSize)
  System.Void .ctor(System.IO.Stream content, System.Threading.CancellationToken cancellationToken)
  System.Void Dispose(System.Boolean disposing)
  System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context)
  System.Boolean TryComputeLength(System.Int64& length)
END_CLASS

CLASS: System.Net.Http.StringContent
TYPE:  class
TOKEN: 0x200001C
EXTENDS: ByteArrayContent
FIELDS:
METHODS:
  System.Void .ctor(System.String content)
  System.Void .ctor(System.String content, System.Text.Encoding encoding, System.String mediaType)
  System.Byte[] GetByteArray(System.String content, System.Text.Encoding encoding)
END_CLASS

CLASS: System.Net.Http.Headers.AuthenticationHeaderValue
TYPE:  class
TOKEN: 0x200001D
FIELDS:
  private           System.String                   <Parameter>k__BackingField  // 0x10
  private           System.String                   <Scheme>k__BackingField  // 0x18
METHODS:
  System.Void .ctor(System.String scheme, System.String parameter)
  System.Void .ctor()
  System.String get_Parameter()
  System.Void set_Parameter(System.String value)
  System.String get_Scheme()
  System.Void set_Scheme(System.String value)
  System.Object System.ICloneable.Clone()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean TryParse(System.String input, System.Net.Http.Headers.AuthenticationHeaderValue& parsedValue)
  System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.AuthenticationHeaderValue>& result)
  System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.AuthenticationHeaderValue& parsedValue, System.Net.Http.Headers.Token& t)
  System.String ToString()
END_CLASS

CLASS: System.Net.Http.Headers.CacheControlHeaderValue
TYPE:  class
TOKEN: 0x200001E
FIELDS:
  private           System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue>extensions  // 0x10
  private           System.Collections.Generic.List<System.String>no_cache_headers  // 0x18
  private           System.Collections.Generic.List<System.String>private_headers  // 0x20
  private           System.Nullable<System.TimeSpan><MaxAge>k__BackingField  // 0x28
  private           System.Boolean                  <MaxStale>k__BackingField  // 0x38
  private           System.Nullable<System.TimeSpan><MaxStaleLimit>k__BackingField  // 0x40
  private           System.Nullable<System.TimeSpan><MinFresh>k__BackingField  // 0x50
  private           System.Boolean                  <MustRevalidate>k__BackingField  // 0x60
  private           System.Boolean                  <NoCache>k__BackingField  // 0x61
  private           System.Boolean                  <NoStore>k__BackingField  // 0x62
  private           System.Boolean                  <NoTransform>k__BackingField  // 0x63
  private           System.Boolean                  <OnlyIfCached>k__BackingField  // 0x64
  private           System.Boolean                  <Private>k__BackingField  // 0x65
  private           System.Boolean                  <ProxyRevalidate>k__BackingField  // 0x66
  private           System.Boolean                  <Public>k__BackingField  // 0x67
  private           System.Nullable<System.TimeSpan><SharedMaxAge>k__BackingField  // 0x68
METHODS:
  System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue> get_Extensions()
  System.Nullable<System.TimeSpan> get_MaxAge()
  System.Void set_MaxAge(System.Nullable<System.TimeSpan> value)
  System.Boolean get_MaxStale()
  System.Void set_MaxStale(System.Boolean value)
  System.Nullable<System.TimeSpan> get_MaxStaleLimit()
  System.Void set_MaxStaleLimit(System.Nullable<System.TimeSpan> value)
  System.Nullable<System.TimeSpan> get_MinFresh()
  System.Void set_MinFresh(System.Nullable<System.TimeSpan> value)
  System.Boolean get_MustRevalidate()
  System.Void set_MustRevalidate(System.Boolean value)
  System.Boolean get_NoCache()
  System.Void set_NoCache(System.Boolean value)
  System.Collections.Generic.ICollection<System.String> get_NoCacheHeaders()
  System.Boolean get_NoStore()
  System.Void set_NoStore(System.Boolean value)
  System.Boolean get_NoTransform()
  System.Void set_NoTransform(System.Boolean value)
  System.Boolean get_OnlyIfCached()
  System.Void set_OnlyIfCached(System.Boolean value)
  System.Boolean get_Private()
  System.Void set_Private(System.Boolean value)
  System.Collections.Generic.ICollection<System.String> get_PrivateHeaders()
  System.Boolean get_ProxyRevalidate()
  System.Void set_ProxyRevalidate(System.Boolean value)
  System.Boolean get_Public()
  System.Void set_Public(System.Boolean value)
  System.Nullable<System.TimeSpan> get_SharedMaxAge()
  System.Void set_SharedMaxAge(System.Nullable<System.TimeSpan> value)
  System.Object System.ICloneable.Clone()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean TryParse(System.String input, System.Net.Http.Headers.CacheControlHeaderValue& parsedValue)
  System.String ToString()
  System.Void .ctor()
END_CLASS

CLASS: System.Net.Http.Headers.CollectionExtensions
TYPE:  class
TOKEN: 0x200001F
FIELDS:
METHODS:
  System.Boolean SequenceEqual(System.Collections.Generic.List<TSource> first, System.Collections.Generic.List<TSource> second)
  System.Void SetValue(System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue> parameters, System.String key, System.String value)
  System.String ToString(System.Collections.Generic.List<T> list)
  System.Void ToStringBuilder(System.Collections.Generic.List<T> list, System.Text.StringBuilder sb)
END_CLASS

CLASS: System.Net.Http.Headers.ElementTryParser`1
TYPE:  class
TOKEN: 0x2000020
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(System.Net.Http.Headers.Lexer lexer, T& parsedValue, System.Net.Http.Headers.Token& token)
END_CLASS

CLASS: System.Net.Http.Headers.CollectionParser
TYPE:  class
TOKEN: 0x2000021
FIELDS:
METHODS:
  System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Net.Http.Headers.ElementTryParser<T> parser, System.Collections.Generic.List<T>& result)
  System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.String>& result)
  System.Boolean TryParseStringElement(System.Net.Http.Headers.Lexer lexer, System.String& parsedValue, System.Net.Http.Headers.Token& t)
END_CLASS

CLASS: System.Net.Http.Headers.ContentDispositionHeaderValue
TYPE:  class
TOKEN: 0x2000022
FIELDS:
  private           System.String                   dispositionType  // 0x10
  private           System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue>parameters  // 0x18
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String dispositionType)
  System.Void .ctor(System.Net.Http.Headers.ContentDispositionHeaderValue source)
  System.Void set_DispositionType(System.String value)
  System.Void set_FileName(System.String value)
  System.Void set_FileNameStar(System.String value)
  System.Void set_Name(System.String value)
  System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue> get_Parameters()
  System.Object System.ICloneable.Clone()
  System.Boolean Equals(System.Object obj)
  System.String EncodeBase64Value(System.String value)
  System.String EncodeRFC5987(System.String value)
  System.Int32 GetHashCode()
  System.Void SetValue(System.String key, System.String value)
  System.String ToString()
  System.Boolean TryParse(System.String input, System.Net.Http.Headers.ContentDispositionHeaderValue& parsedValue)
END_CLASS

CLASS: System.Net.Http.Headers.ContentRangeHeaderValue
TYPE:  class
TOKEN: 0x2000023
FIELDS:
  private           System.String                   unit  // 0x10
  private           System.Nullable<System.Int64>   <From>k__BackingField  // 0x18
  private           System.Nullable<System.Int64>   <Length>k__BackingField  // 0x28
  private           System.Nullable<System.Int64>   <To>k__BackingField  // 0x38
METHODS:
  System.Void .ctor()
  System.Nullable<System.Int64> get_From()
  System.Void set_From(System.Nullable<System.Int64> value)
  System.Nullable<System.Int64> get_Length()
  System.Void set_Length(System.Nullable<System.Int64> value)
  System.Nullable<System.Int64> get_To()
  System.Void set_To(System.Nullable<System.Int64> value)
  System.String get_Unit()
  System.Object System.ICloneable.Clone()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean TryParse(System.String input, System.Net.Http.Headers.ContentRangeHeaderValue& parsedValue)
  System.String ToString()
END_CLASS

CLASS: System.Net.Http.Headers.EntityTagHeaderValue
TYPE:  class
TOKEN: 0x2000024
FIELDS:
  private   static readonly System.Net.Http.Headers.EntityTagHeaderValueany  // 0x0
  private           System.Boolean                  <IsWeak>k__BackingField  // 0x10
  private           System.String                   <Tag>k__BackingField  // 0x18
METHODS:
  System.Void .ctor()
  System.Boolean get_IsWeak()
  System.Void set_IsWeak(System.Boolean value)
  System.String get_Tag()
  System.Void set_Tag(System.String value)
  System.Object System.ICloneable.Clone()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean TryParse(System.String input, System.Net.Http.Headers.EntityTagHeaderValue& parsedValue)
  System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.EntityTagHeaderValue& parsedValue, System.Net.Http.Headers.Token& t)
  System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.EntityTagHeaderValue>& result)
  System.String ToString()
  System.Void .cctor()
END_CLASS

CLASS: System.Net.Http.Headers.HashCodeCalculator
TYPE:  class
TOKEN: 0x2000025
FIELDS:
METHODS:
  System.Int32 Calculate(System.Collections.Generic.ICollection<T> list)
END_CLASS

CLASS: System.Net.Http.Headers.TryParseDelegate`1
TYPE:  class
TOKEN: 0x2000026
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(System.String value, T& result)
END_CLASS

CLASS: System.Net.Http.Headers.TryParseListDelegate`1
TYPE:  class
TOKEN: 0x2000027
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(System.String value, System.Int32 minimalCount, System.Collections.Generic.List<T>& result)
END_CLASS

CLASS: System.Net.Http.Headers.HeaderInfo
TYPE:  class
TOKEN: 0x2000028
FIELDS:
  public            System.Boolean                  AllowsMany  // 0x10
  public    readonly System.Net.Http.Headers.HttpHeaderKindHeaderKind  // 0x14
  public    readonly System.String                   Name  // 0x18
  private           System.Func<System.Object,System.String><CustomToString>k__BackingField  // 0x20
METHODS:
  System.Void .ctor(System.String name, System.Net.Http.Headers.HttpHeaderKind headerKind)
  System.Net.Http.Headers.HeaderInfo CreateSingle(System.String name, System.Net.Http.Headers.TryParseDelegate<T> parser, System.Net.Http.Headers.HttpHeaderKind headerKind, System.Func<System.Object,System.String> toString)
  System.Net.Http.Headers.HeaderInfo CreateMulti(System.String name, System.Net.Http.Headers.TryParseListDelegate<T> elementParser, System.Net.Http.Headers.HttpHeaderKind headerKind, System.Int32 minimalCount, System.String separator)
  System.Object CreateCollection(System.Net.Http.Headers.HttpHeaders headers)
  System.Func<System.Object,System.String> get_CustomToString()
  System.Void set_CustomToString(System.Func<System.Object,System.String> value)
  System.String get_Separator()
  System.Void AddToCollection(System.Object collection, System.Object value)
  System.Object CreateCollection(System.Net.Http.Headers.HttpHeaders headers, System.Net.Http.Headers.HeaderInfo headerInfo)
  System.Collections.Generic.List<System.String> ToStringCollection(System.Object collection)
  System.Boolean TryParse(System.String value, System.Object& result)
END_CLASS

CLASS: System.Net.Http.Headers.HttpContentHeaders
TYPE:  class
TOKEN: 0x200002B
EXTENDS: HttpHeaders
FIELDS:
  private   readonly System.Net.Http.HttpContent     content  // 0x20
METHODS:
  System.Void .ctor(System.Net.Http.HttpContent content)
  System.Net.Http.Headers.ContentDispositionHeaderValue get_ContentDisposition()
  System.Void set_ContentDisposition(System.Net.Http.Headers.ContentDispositionHeaderValue value)
  System.Nullable<System.Int64> get_ContentLength()
  System.Void set_ContentLength(System.Nullable<System.Int64> value)
  System.Net.Http.Headers.MediaTypeHeaderValue get_ContentType()
  System.Void set_ContentType(System.Net.Http.Headers.MediaTypeHeaderValue value)
END_CLASS

CLASS: System.Net.Http.Headers.HttpHeaderKind
TYPE:  struct
TOKEN: 0x200002C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Net.Http.Headers.HttpHeaderKindNone  // 0x0
  public    static  System.Net.Http.Headers.HttpHeaderKindRequest  // 0x0
  public    static  System.Net.Http.Headers.HttpHeaderKindResponse  // 0x0
  public    static  System.Net.Http.Headers.HttpHeaderKindContent  // 0x0
METHODS:
END_CLASS

CLASS: System.Net.Http.Headers.HttpHeaderValueCollection`1
TYPE:  class
TOKEN: 0x200002D
FIELDS:
  private   readonly System.Collections.Generic.List<T>list  // 0x0
  private   readonly System.Net.Http.Headers.HttpHeadersheaders  // 0x0
  private   readonly System.Net.Http.Headers.HeaderInfoheaderInfo  // 0x0
  private           System.Collections.Generic.List<System.String>invalidValues  // 0x0
METHODS:
  System.Void .ctor(System.Net.Http.Headers.HttpHeaders headers, System.Net.Http.Headers.HeaderInfo headerInfo)
  System.Int32 get_Count()
  System.Collections.Generic.List<System.String> get_InvalidValues()
  System.Boolean get_IsReadOnly()
  System.Void Add(T item)
  System.Void AddRange(System.Collections.Generic.List<T> values)
  System.Void AddInvalidValue(System.String invalidValue)
  System.Void Clear()
  System.Boolean Contains(T item)
  System.Void CopyTo(T[] array, System.Int32 arrayIndex)
  System.Boolean Remove(T item)
  System.String ToString()
  System.Collections.Generic.IEnumerator<T> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  T Find(System.Predicate<T> predicate)
END_CLASS

CLASS: System.Net.Http.Headers.HttpHeaders
TYPE:  class
TOKEN: 0x200002E
FIELDS:
  private   static readonly System.Collections.Generic.Dictionary<System.String,System.Net.Http.Headers.HeaderInfo>known_headers  // 0x0
  private   readonly System.Collections.Generic.Dictionary<System.String,System.Net.Http.Headers.HttpHeaders.HeaderBucket>headers  // 0x10
  private   readonly System.Net.Http.Headers.HttpHeaderKindHeaderKind  // 0x18
  private           System.Nullable<System.Boolean> connectionclose  // 0x1C
  private           System.Nullable<System.Boolean> transferEncodingChunked  // 0x1E
METHODS:
  System.Void .cctor()
  System.Void .ctor()
  System.Void .ctor(System.Net.Http.Headers.HttpHeaderKind headerKind)
  System.Boolean AddInternal(System.String name, System.Collections.Generic.IEnumerable<System.String> values, System.Net.Http.Headers.HeaderInfo headerInfo, System.Boolean ignoreInvalid)
  System.Boolean TryAddWithoutValidation(System.String name, System.Collections.Generic.IEnumerable<System.String> values)
  System.Net.Http.Headers.HeaderInfo CheckName(System.String name)
  System.Boolean TryCheckName(System.String name, System.Net.Http.Headers.HeaderInfo& headerInfo)
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Boolean Remove(System.String name)
  System.String GetSingleHeaderString(System.String key, System.Collections.Generic.IEnumerable<System.String> values)
  System.String ToString()
  System.Void AddOrRemove(System.String name, T value, System.Func<System.Object,System.String> converter)
  System.Void AddOrRemove(System.String name, System.Nullable<T> value)
  System.Void AddOrRemove(System.String name, System.Nullable<T> value, System.Func<System.Object,System.String> converter)
  System.Collections.Generic.List<System.String> GetAllHeaderValues(System.Net.Http.Headers.HttpHeaders.HeaderBucket bucket, System.Net.Http.Headers.HeaderInfo headerInfo)
  System.Net.Http.Headers.HttpHeaderKind GetKnownHeaderKind(System.String name)
  T GetValue(System.String name)
  System.Net.Http.Headers.HttpHeaderValueCollection<T> GetValues(System.String name)
  System.Void SetValue(System.String name, T value, System.Func<System.Object,System.String> toStringConverter)
END_CLASS

CLASS: System.Net.Http.Headers.HttpRequestHeaders
TYPE:  class
TOKEN: 0x2000031
EXTENDS: HttpHeaders
FIELDS:
  private           System.Nullable<System.Boolean> expectContinue  // 0x20
METHODS:
  System.Void .ctor()
  System.Void set_Authorization(System.Net.Http.Headers.AuthenticationHeaderValue value)
  System.Net.Http.Headers.HttpHeaderValueCollection<System.String> get_Connection()
  System.Nullable<System.Boolean> get_ConnectionClose()
  System.Void set_ConnectionClose(System.Nullable<System.Boolean> value)
  System.Nullable<System.Boolean> get_ExpectContinue()
  System.String get_Host()
  System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.TransferCodingHeaderValue> get_TransferEncoding()
  System.Nullable<System.Boolean> get_TransferEncodingChunked()
  System.Void AddHeaders(System.Net.Http.Headers.HttpRequestHeaders headers)
END_CLASS

CLASS: System.Net.Http.Headers.HttpResponseHeaders
TYPE:  class
TOKEN: 0x2000033
EXTENDS: HttpHeaders
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Net.Http.Headers.Token
TYPE:  struct
TOKEN: 0x2000034
FIELDS:
  public    static readonly System.Net.Http.Headers.Token   Empty  // 0x0
  private   readonly System.Net.Http.Headers.Token.Typetype  // 0x10
  private           System.Int32                    <StartPosition>k__BackingField  // 0x14
  private           System.Int32                    <EndPosition>k__BackingField  // 0x18
METHODS:
  System.Void .ctor(System.Net.Http.Headers.Token.Type type, System.Int32 startPosition, System.Int32 endPosition)
  System.Int32 get_StartPosition()
  System.Void set_StartPosition(System.Int32 value)
  System.Int32 get_EndPosition()
  System.Void set_EndPosition(System.Int32 value)
  System.Net.Http.Headers.Token.Type get_Kind()
  System.Net.Http.Headers.Token.Type op_Implicit(System.Net.Http.Headers.Token token)
  System.String ToString()
  System.Void .cctor()
END_CLASS

CLASS: System.Net.Http.Headers.Lexer
TYPE:  class
TOKEN: 0x2000036
FIELDS:
  private   static readonly System.Boolean[]                token_chars  // 0x0
  private   static readonly System.Int32                    last_token_char  // 0x8
  private   static readonly System.String[]                 dt_formats  // 0x10
  private   readonly System.String                   s  // 0x10
  private           System.Int32                    pos  // 0x18
METHODS:
  System.Void .ctor(System.String stream)
  System.Int32 get_Position()
  System.Void set_Position(System.Int32 value)
  System.String GetStringValue(System.Net.Http.Headers.Token token)
  System.String GetStringValue(System.Net.Http.Headers.Token start, System.Net.Http.Headers.Token end)
  System.String GetQuotedStringValue(System.Net.Http.Headers.Token start)
  System.String GetRemainingStringValue(System.Int32 position)
  System.Boolean IsStarStringValue(System.Net.Http.Headers.Token token)
  System.Boolean TryGetNumericValue(System.Net.Http.Headers.Token token, System.Int32& value)
  System.Boolean TryGetNumericValue(System.Net.Http.Headers.Token token, System.Int64& value)
  System.Nullable<System.TimeSpan> TryGetTimeSpanValue(System.Net.Http.Headers.Token token)
  System.Boolean TryGetDateValue(System.Net.Http.Headers.Token token, System.DateTimeOffset& value)
  System.Boolean TryGetDateValue(System.String text, System.DateTimeOffset& value)
  System.Boolean TryGetDoubleValue(System.Net.Http.Headers.Token token, System.Double& value)
  System.Boolean IsValidToken(System.String input)
  System.Boolean IsValidCharacter(System.Char input)
  System.Void EatChar()
  System.Int32 PeekChar()
  System.Boolean ScanCommentOptional(System.String& value, System.Net.Http.Headers.Token& readToken)
  System.Net.Http.Headers.Token Scan(System.Boolean recognizeDash)
  System.Void .cctor()
END_CLASS

CLASS: System.Net.Http.Headers.MediaTypeHeaderValue
TYPE:  class
TOKEN: 0x2000037
FIELDS:
  private           System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue>parameters  // 0x10
  private           System.String                   media_type  // 0x18
METHODS:
  System.Void .ctor(System.String mediaType)
  System.Void .ctor(System.Net.Http.Headers.MediaTypeHeaderValue source)
  System.Void .ctor()
  System.String get_CharSet()
  System.Void set_CharSet(System.String value)
  System.Void set_MediaType(System.String value)
  System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue> get_Parameters()
  System.Object System.ICloneable.Clone()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Boolean TryParse(System.String input, System.Net.Http.Headers.MediaTypeHeaderValue& parsedValue)
  System.Nullable<System.Net.Http.Headers.Token> TryParseMediaType(System.Net.Http.Headers.Lexer lexer, System.String& media)
END_CLASS

CLASS: System.Net.Http.Headers.MediaTypeWithQualityHeaderValue
TYPE:  class
TOKEN: 0x2000039
EXTENDS: MediaTypeHeaderValue
FIELDS:
METHODS:
  System.Void .ctor()
  System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.MediaTypeWithQualityHeaderValue& parsedValue, System.Net.Http.Headers.Token& t)
  System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.MediaTypeWithQualityHeaderValue>& result)
END_CLASS

CLASS: System.Net.Http.Headers.NameValueHeaderValue
TYPE:  class
TOKEN: 0x200003A
FIELDS:
  private           System.String                   value  // 0x10
  private           System.String                   <Name>k__BackingField  // 0x18
METHODS:
  System.Void .ctor(System.String name, System.String value)
  System.Void .ctor(System.Net.Http.Headers.NameValueHeaderValue source)
  System.Void .ctor()
  System.String get_Name()
  System.Void set_Name(System.String value)
  System.String get_Value()
  System.Void set_Value(System.String value)
  System.Net.Http.Headers.NameValueHeaderValue Create(System.String name, System.String value)
  System.Object System.ICloneable.Clone()
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object obj)
  System.Boolean TryParsePragma(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue>& result)
  System.Boolean TryParseParameters(System.Net.Http.Headers.Lexer lexer, System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue>& result, System.Net.Http.Headers.Token& t)
  System.String ToString()
  System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.NameValueHeaderValue& parsedValue, System.Net.Http.Headers.Token& t)
END_CLASS

CLASS: System.Net.Http.Headers.NameValueWithParametersHeaderValue
TYPE:  class
TOKEN: 0x200003B
EXTENDS: NameValueHeaderValue
FIELDS:
  private           System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue>parameters  // 0x20
METHODS:
  System.Void .ctor(System.Net.Http.Headers.NameValueWithParametersHeaderValue source)
  System.Void .ctor()
  System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue> get_Parameters()
  System.Object System.ICloneable.Clone()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.NameValueWithParametersHeaderValue>& result)
  System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.NameValueWithParametersHeaderValue& parsedValue, System.Net.Http.Headers.Token& t)
END_CLASS

CLASS: System.Net.Http.Headers.Parser
TYPE:  class
TOKEN: 0x200003C
FIELDS:
METHODS:
END_CLASS

CLASS: System.Net.Http.Headers.ProductHeaderValue
TYPE:  class
TOKEN: 0x2000048
FIELDS:
  private           System.String                   <Name>k__BackingField  // 0x10
  private           System.String                   <Version>k__BackingField  // 0x18
METHODS:
  System.Void .ctor()
  System.String get_Name()
  System.Void set_Name(System.String value)
  System.String get_Version()
  System.Void set_Version(System.String value)
  System.Object System.ICloneable.Clone()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.ProductHeaderValue>& result)
  System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.ProductHeaderValue& parsedValue, System.Net.Http.Headers.Token& t)
  System.String ToString()
END_CLASS

CLASS: System.Net.Http.Headers.ProductInfoHeaderValue
TYPE:  class
TOKEN: 0x2000049
FIELDS:
  private           System.String                   <Comment>k__BackingField  // 0x10
  private           System.Net.Http.Headers.ProductHeaderValue<Product>k__BackingField  // 0x18
METHODS:
  System.Void .ctor(System.Net.Http.Headers.ProductHeaderValue product)
  System.Void .ctor()
  System.String get_Comment()
  System.Void set_Comment(System.String value)
  System.Net.Http.Headers.ProductHeaderValue get_Product()
  System.Void set_Product(System.Net.Http.Headers.ProductHeaderValue value)
  System.Object System.ICloneable.Clone()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.ProductInfoHeaderValue>& result)
  System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.ProductInfoHeaderValue& parsedValue)
  System.String ToString()
END_CLASS

CLASS: System.Net.Http.Headers.RangeConditionHeaderValue
TYPE:  class
TOKEN: 0x200004A
FIELDS:
  private           System.Nullable<System.DateTimeOffset><Date>k__BackingField  // 0x10
  private           System.Net.Http.Headers.EntityTagHeaderValue<EntityTag>k__BackingField  // 0x28
METHODS:
  System.Void .ctor(System.DateTimeOffset date)
  System.Void .ctor(System.Net.Http.Headers.EntityTagHeaderValue entityTag)
  System.Nullable<System.DateTimeOffset> get_Date()
  System.Void set_Date(System.Nullable<System.DateTimeOffset> value)
  System.Net.Http.Headers.EntityTagHeaderValue get_EntityTag()
  System.Void set_EntityTag(System.Net.Http.Headers.EntityTagHeaderValue value)
  System.Object System.ICloneable.Clone()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean TryParse(System.String input, System.Net.Http.Headers.RangeConditionHeaderValue& parsedValue)
  System.String ToString()
END_CLASS

CLASS: System.Net.Http.Headers.RangeHeaderValue
TYPE:  class
TOKEN: 0x200004B
FIELDS:
  private           System.Collections.Generic.List<System.Net.Http.Headers.RangeItemHeaderValue>ranges  // 0x10
  private           System.String                   unit  // 0x18
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Net.Http.Headers.RangeHeaderValue source)
  System.Collections.Generic.ICollection<System.Net.Http.Headers.RangeItemHeaderValue> get_Ranges()
  System.String get_Unit()
  System.Object System.ICloneable.Clone()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean TryParse(System.String input, System.Net.Http.Headers.RangeHeaderValue& parsedValue)
  System.String ToString()
END_CLASS

CLASS: System.Net.Http.Headers.RangeItemHeaderValue
TYPE:  class
TOKEN: 0x200004C
FIELDS:
  private           System.Nullable<System.Int64>   <From>k__BackingField  // 0x10
  private           System.Nullable<System.Int64>   <To>k__BackingField  // 0x20
METHODS:
  System.Void .ctor(System.Nullable<System.Int64> from, System.Nullable<System.Int64> to)
  System.Nullable<System.Int64> get_From()
  System.Void set_From(System.Nullable<System.Int64> value)
  System.Nullable<System.Int64> get_To()
  System.Void set_To(System.Nullable<System.Int64> value)
  System.Object System.ICloneable.Clone()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: System.Net.Http.Headers.RetryConditionHeaderValue
TYPE:  class
TOKEN: 0x200004D
FIELDS:
  private           System.Nullable<System.DateTimeOffset><Date>k__BackingField  // 0x10
  private           System.Nullable<System.TimeSpan><Delta>k__BackingField  // 0x28
METHODS:
  System.Void .ctor(System.DateTimeOffset date)
  System.Void .ctor(System.TimeSpan delta)
  System.Nullable<System.DateTimeOffset> get_Date()
  System.Void set_Date(System.Nullable<System.DateTimeOffset> value)
  System.Nullable<System.TimeSpan> get_Delta()
  System.Void set_Delta(System.Nullable<System.TimeSpan> value)
  System.Object System.ICloneable.Clone()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean TryParse(System.String input, System.Net.Http.Headers.RetryConditionHeaderValue& parsedValue)
  System.String ToString()
END_CLASS

CLASS: System.Net.Http.Headers.StringWithQualityHeaderValue
TYPE:  class
TOKEN: 0x200004E
FIELDS:
  private           System.Nullable<System.Double>  <Quality>k__BackingField  // 0x10
  private           System.String                   <Value>k__BackingField  // 0x20
METHODS:
  System.Void .ctor()
  System.Nullable<System.Double> get_Quality()
  System.Void set_Quality(System.Nullable<System.Double> value)
  System.String get_Value()
  System.Void set_Value(System.String value)
  System.Object System.ICloneable.Clone()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.StringWithQualityHeaderValue>& result)
  System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.StringWithQualityHeaderValue& parsedValue, System.Net.Http.Headers.Token& t)
  System.String ToString()
END_CLASS

CLASS: System.Net.Http.Headers.TransferCodingHeaderValue
TYPE:  class
TOKEN: 0x200004F
FIELDS:
  private           System.String                   value  // 0x10
  private           System.Collections.Generic.List<System.Net.Http.Headers.NameValueHeaderValue>parameters  // 0x18
METHODS:
  System.Void .ctor(System.Net.Http.Headers.TransferCodingHeaderValue source)
  System.Void .ctor()
  System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue> get_Parameters()
  System.String get_Value()
  System.Object System.ICloneable.Clone()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.TransferCodingHeaderValue>& result)
  System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.TransferCodingHeaderValue& parsedValue, System.Net.Http.Headers.Token& t)
END_CLASS

CLASS: System.Net.Http.Headers.TransferCodingWithQualityHeaderValue
TYPE:  class
TOKEN: 0x2000050
EXTENDS: TransferCodingHeaderValue
FIELDS:
METHODS:
  System.Void .ctor()
  System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.TransferCodingWithQualityHeaderValue>& result)
  System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.TransferCodingWithQualityHeaderValue& parsedValue, System.Net.Http.Headers.Token& t)
END_CLASS

CLASS: System.Net.Http.Headers.ViaHeaderValue
TYPE:  class
TOKEN: 0x2000051
FIELDS:
  private           System.String                   <Comment>k__BackingField  // 0x10
  private           System.String                   <ProtocolName>k__BackingField  // 0x18
  private           System.String                   <ProtocolVersion>k__BackingField  // 0x20
  private           System.String                   <ReceivedBy>k__BackingField  // 0x28
METHODS:
  System.Void .ctor()
  System.String get_Comment()
  System.Void set_Comment(System.String value)
  System.String get_ProtocolName()
  System.Void set_ProtocolName(System.String value)
  System.String get_ProtocolVersion()
  System.Void set_ProtocolVersion(System.String value)
  System.String get_ReceivedBy()
  System.Void set_ReceivedBy(System.String value)
  System.Object System.ICloneable.Clone()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.ViaHeaderValue>& result)
  System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.ViaHeaderValue& parsedValue, System.Net.Http.Headers.Token& t)
  System.String ToString()
END_CLASS

CLASS: System.Net.Http.Headers.WarningHeaderValue
TYPE:  class
TOKEN: 0x2000052
FIELDS:
  private           System.String                   <Agent>k__BackingField  // 0x10
  private           System.Int32                    <Code>k__BackingField  // 0x18
  private           System.Nullable<System.DateTimeOffset><Date>k__BackingField  // 0x20
  private           System.String                   <Text>k__BackingField  // 0x38
METHODS:
  System.Void .ctor()
  System.String get_Agent()
  System.Void set_Agent(System.String value)
  System.Int32 get_Code()
  System.Void set_Code(System.Int32 value)
  System.Nullable<System.DateTimeOffset> get_Date()
  System.Void set_Date(System.Nullable<System.DateTimeOffset> value)
  System.String get_Text()
  System.Void set_Text(System.String value)
  System.Boolean IsCodeValid(System.Int32 code)
  System.Object System.ICloneable.Clone()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean TryParse(System.String input, System.Int32 minimalCount, System.Collections.Generic.List<System.Net.Http.Headers.WarningHeaderValue>& result)
  System.Boolean TryParseElement(System.Net.Http.Headers.Lexer lexer, System.Net.Http.Headers.WarningHeaderValue& parsedValue, System.Net.Http.Headers.Token& t)
  System.String ToString()
END_CLASS

