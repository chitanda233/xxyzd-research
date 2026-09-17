// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 27017
{}

// Namespace: System.Net.Http
[Extension]
internal static class HttpUtilities // TypeDefIndex: 27018
{
	// Methods

	// RVA: 0x816AAD8 Offset: 0x8166AD8 VA: 0x816AAD8
	internal static bool IsSupportedSecureScheme(string scheme) { }

	// RVA: 0x816AB44 Offset: 0x8166B44 VA: 0x816AB44
	internal static bool IsSecureWebSocketScheme(string scheme) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class HttpClientHandler.<>c // TypeDefIndex: 27019
{
	// Fields
	public static readonly HttpClientHandler.<>c <>9; // 0x0
	public static LocalCertificateSelectionCallback <>9__23_1; // 0x8

	// Methods

	// RVA: 0x816B5D0 Offset: 0x81675D0 VA: 0x816B5D0
	private static void .cctor() { }

	// RVA: 0x816B638 Offset: 0x8167638 VA: 0x816B638
	public void .ctor() { }

	// RVA: 0x816B640 Offset: 0x8167640 VA: 0x816B640
	internal X509Certificate <set_ClientCertificateOptions>b__23_1(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }
}

// Namespace: System.Net.Http
public class HttpClientHandler : HttpMessageHandler // TypeDefIndex: 27020
{
	// Fields
	private readonly IMonoHttpClientHandler _delegatingHandler; // 0x10
	private ClientCertificateOption _clientCertificateOptions; // 0x18

	// Properties
	public ClientCertificateOption ClientCertificateOptions { get; set; }
	public X509CertificateCollection ClientCertificates { get; }

	// Methods

	// RVA: 0x816AB94 Offset: 0x8166B94 VA: 0x816AB94
	private static IMonoHttpClientHandler CreateDefaultHandler() { }

	// RVA: 0x816ADB8 Offset: 0x8166DB8 VA: 0x816ADB8
	public void .ctor() { }

	// RVA: 0x816ADD4 Offset: 0x8166DD4 VA: 0x816ADD4
	internal void .ctor(IMonoHttpClientHandler handler) { }

	// RVA: 0x816B0B4 Offset: 0x81670B4 VA: 0x816B0B4 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x816B16C Offset: 0x816716C VA: 0x816B16C
	private void ThrowForModifiedManagedSslOptionsIfStarted() { }

	// RVA: 0x816B270 Offset: 0x8167270 VA: 0x816B270
	public ClientCertificateOption get_ClientCertificateOptions() { }

	// RVA: 0x816AE18 Offset: 0x8166E18 VA: 0x816AE18
	public void set_ClientCertificateOptions(ClientCertificateOption value) { }

	// RVA: 0x816B278 Offset: 0x8167278 VA: 0x816B278
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x816B454 Offset: 0x8167454 VA: 0x816B454
	internal void SetWebRequestTimeout(TimeSpan timeout) { }

	// RVA: 0x816B500 Offset: 0x8167500 VA: 0x816B500 Slot: 6
	protected internal override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

	[CompilerGenerated]
	// RVA: 0x816B5BC Offset: 0x81675BC VA: 0x816B5BC
	private X509Certificate <set_ClientCertificateOptions>b__23_0(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }
}

// Namespace: System.Net.Http
internal interface IMonoHttpClientHandler : IDisposable // TypeDefIndex: 27021
{
	// Properties
	public abstract SslClientAuthenticationOptions SslOptions { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract SslClientAuthenticationOptions get_SslOptions();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_SslOptions(SslClientAuthenticationOptions value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SetWebRequestTimeout(TimeSpan timeout);
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MonoWebRequestHandler.<>c // TypeDefIndex: 27022
{
	// Fields
	public static readonly MonoWebRequestHandler.<>c <>9; // 0x0
	public static Func<string, bool> <>9__95_0; // 0x8
	public static Func<string, bool> <>9__96_1; // 0x10
	public static Action<object> <>9__99_0; // 0x18

	// Methods

	// RVA: 0x816D030 Offset: 0x8169030 VA: 0x816D030
	private static void .cctor() { }

	// RVA: 0x816D098 Offset: 0x8169098 VA: 0x816D098
	public void .ctor() { }

	// RVA: 0x816D0A0 Offset: 0x81690A0 VA: 0x816D0A0
	internal bool <GetConnectionKeepAlive>b__95_0(string l) { }

	// RVA: 0x816D0F0 Offset: 0x81690F0 VA: 0x816D0F0
	internal bool <CreateWebRequest>b__96_1(string l) { }

	// RVA: 0x816D13C Offset: 0x816913C VA: 0x816D13C
	internal void <SendAsync>b__99_0(object l) { }
}

// Namespace: 
[CompilerGenerated]
private struct MonoWebRequestHandler.<SendAsync>d__99 : IAsyncStateMachine // TypeDefIndex: 27023
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<HttpResponseMessage> <>t__builder; // 0x8
	public MonoWebRequestHandler <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public HttpRequestMessage request; // 0x30
	private HttpWebRequest <wrequest>5__2; // 0x38
	private HttpWebResponse <wresponse>5__3; // 0x40
	private CancellationTokenRegistration <>7__wrap3; // 0x48
	private HttpContent <content>5__5; // 0x60
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x68
	private Stream <stream>5__6; // 0x78
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream> <>u__2; // 0x80
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebResponse> <>u__3; // 0x90
	private TaskAwaiter<HttpResponseMessage> <>u__4; // 0xA0

	// Methods

	// RVA: 0x816D1C4 Offset: 0x81691C4 VA: 0x816D1C4 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x816EF04 Offset: 0x816AF04 VA: 0x816EF04 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net.Http
internal class MonoWebRequestHandler : IMonoHttpClientHandler, IDisposable // TypeDefIndex: 27024
{
	// Fields
	private static long groupCounter; // 0x0
	private bool allowAutoRedirect; // 0x10
	private DecompressionMethods automaticDecompression; // 0x14
	private CookieContainer cookieContainer; // 0x18
	private ICredentials credentials; // 0x20
	private int maxAutomaticRedirections; // 0x28
	private long maxRequestContentBufferSize; // 0x30
	private bool preAuthenticate; // 0x38
	private IWebProxy proxy; // 0x40
	private bool useCookies; // 0x48
	private bool useProxy; // 0x49
	private SslClientAuthenticationOptions sslOptions; // 0x50
	private bool allowPipelining; // 0x58
	private RequestCachePolicy cachePolicy; // 0x60
	private AuthenticationLevel authenticationLevel; // 0x68
	private TimeSpan continueTimeout; // 0x70
	private TokenImpersonationLevel impersonationLevel; // 0x78
	private int maxResponseHeadersLength; // 0x7C
	private int readWriteTimeout; // 0x80
	private RemoteCertificateValidationCallback serverCertificateValidationCallback; // 0x88
	private bool unsafeAuthenticatedConnectionSharing; // 0x90
	private bool sentRequest; // 0x91
	private string connectionGroupName; // 0x98
	private Nullable<TimeSpan> timeout; // 0xA0
	private bool disposed; // 0xB0

	// Properties
	public CookieContainer CookieContainer { get; }
	public long MaxRequestContentBufferSize { get; }
	public SslClientAuthenticationOptions SslOptions { get; set; }

	// Methods

	// RVA: 0x816ABE4 Offset: 0x8166BE4 VA: 0x816ABE4
	public void .ctor() { }

	// RVA: 0x816B648 Offset: 0x8167648 VA: 0x816B648
	internal void EnsureModifiability() { }

	// RVA: 0x816B6A4 Offset: 0x81676A4 VA: 0x816B6A4 Slot: 9
	public CookieContainer get_CookieContainer() { }

	// RVA: 0x816B714 Offset: 0x8167714 VA: 0x816B714 Slot: 10
	public long get_MaxRequestContentBufferSize() { }

	// RVA: 0x816B71C Offset: 0x816771C VA: 0x816B71C Slot: 4
	public SslClientAuthenticationOptions get_SslOptions() { }

	// RVA: 0x816B78C Offset: 0x816778C VA: 0x816B78C Slot: 5
	public void set_SslOptions(SslClientAuthenticationOptions value) { }

	// RVA: 0x816B7B8 Offset: 0x81677B8 VA: 0x816B7B8 Slot: 8
	public void Dispose() { }

	// RVA: 0x816B7C8 Offset: 0x81677C8 VA: 0x816B7C8 Slot: 11
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x816B84C Offset: 0x816784C VA: 0x816B84C
	private bool GetConnectionKeepAlive(HttpRequestHeaders headers) { }

	// RVA: 0x816B9C8 Offset: 0x81679C8 VA: 0x816B9C8 Slot: 12
	internal virtual HttpWebRequest CreateWebRequest(HttpRequestMessage request) { }

	// RVA: 0x816C7A4 Offset: 0x81687A4 VA: 0x816C7A4
	private HttpResponseMessage CreateResponseMessage(HttpWebResponse wr, HttpRequestMessage requestMessage, CancellationToken cancellationToken) { }

	// RVA: 0x816CD08 Offset: 0x8168D08 VA: 0x816CD08
	private static bool MethodHasBody(HttpMethod method) { }

	[AsyncStateMachine(typeof(MonoWebRequestHandler.<SendAsync>d__99))]
	// RVA: 0x816CE14 Offset: 0x8168E14 VA: 0x816CE14 Slot: 6
	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

	// RVA: 0x816CF5C Offset: 0x8168F5C VA: 0x816CF5C Slot: 7
	private void System.Net.Http.IMonoHttpClientHandler.SetWebRequestTimeout(TimeSpan timeout) { }

	[CompilerGenerated]
	// RVA: 0x816CFCC Offset: 0x8168FCC VA: 0x816CFCC
	private X509Certificate <CreateWebRequest>b__96_0(string t, X509CertificateCollection lc, X509Certificate rc, string[] ai) { }
}

// Namespace: System.Net.Http
internal static class PlatformHelper // TypeDefIndex: 27025
{
	// Methods

	// RVA: 0x816CA3C Offset: 0x8168A3C VA: 0x816CA3C
	internal static bool IsContentHeader(string name) { }

	// RVA: 0x816C740 Offset: 0x8168740 VA: 0x816C740
	internal static string GetSingleHeaderString(string name, IEnumerable<string> values) { }

	// RVA: 0x816C9C4 Offset: 0x81689C4 VA: 0x816C9C4
	internal static StreamContent CreateStreamContent(Stream stream, CancellationToken cancellationToken) { }
}

// Namespace: System.Net.Http
public class ByteArrayContent : HttpContent // TypeDefIndex: 27026
{
	// Fields
	private readonly byte[] content; // 0x30
	private readonly int offset; // 0x38
	private readonly int count; // 0x3C

	// Methods

	// RVA: 0x816F520 Offset: 0x816B520 VA: 0x816F520
	public void .ctor(byte[] content) { }

	// RVA: 0x816F5B0 Offset: 0x816B5B0 VA: 0x816F5B0 Slot: 5
	protected override Task<Stream> CreateContentReadStreamAsync() { }

	// RVA: 0x816F668 Offset: 0x816B668 VA: 0x816F668 Slot: 7
	protected override Task SerializeToStreamAsync(Stream stream, TransportContext context) { }

	// RVA: 0x816F690 Offset: 0x816B690 VA: 0x816F690 Slot: 8
	protected internal override bool TryComputeLength(out long length) { }
}

// Namespace: System.Net.Http
public enum ClientCertificateOption // TypeDefIndex: 27027
{
	// Fields
	public int value__; // 0x0
	public const ClientCertificateOption Manual = 0;
	public const ClientCertificateOption Automatic = 1;
}

// Namespace: 
[CompilerGenerated]
private struct HttpClient.<SendAsyncWorker>d__47 : IAsyncStateMachine // TypeDefIndex: 27028
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<HttpResponseMessage> <>t__builder; // 0x8
	public HttpClient <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public HttpRequestMessage request; // 0x30
	public HttpCompletionOption completionOption; // 0x38
	private CancellationTokenSource <lcts>5__2; // 0x40
	private HttpResponseMessage <response>5__3; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<HttpResponseMessage> <>u__1; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x60

	// Methods

	// RVA: 0x8171FE0 Offset: 0x816DFE0 VA: 0x8171FE0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x81726A0 Offset: 0x816E6A0 VA: 0x81726A0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct HttpClient.<GetByteArrayAsync>d__48 : IAsyncStateMachine // TypeDefIndex: 27029
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<byte[]> <>t__builder; // 0x8
	public HttpClient <>4__this; // 0x20
	public string requestUri; // 0x28
	private HttpResponseMessage <resp>5__2; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<HttpResponseMessage> <>u__1; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<byte[]> <>u__2; // 0x48

	// Methods

	// RVA: 0x817271C Offset: 0x816E71C VA: 0x817271C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x8172E44 Offset: 0x816EE44 VA: 0x8172E44 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct HttpClient.<GetByteArrayAsync>d__49 : IAsyncStateMachine // TypeDefIndex: 27030
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<byte[]> <>t__builder; // 0x8
	public HttpClient <>4__this; // 0x20
	public Uri requestUri; // 0x28
	private HttpResponseMessage <resp>5__2; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<HttpResponseMessage> <>u__1; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<byte[]> <>u__2; // 0x48

	// Methods

	// RVA: 0x8172EC0 Offset: 0x816EEC0 VA: 0x8172EC0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x8173428 Offset: 0x816F428 VA: 0x8173428 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct HttpClient.<GetStreamAsync>d__50 : IAsyncStateMachine // TypeDefIndex: 27031
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Stream> <>t__builder; // 0x8
	public HttpClient <>4__this; // 0x20
	public string requestUri; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<HttpResponseMessage> <>u__1; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream> <>u__2; // 0x40

	// Methods

	// RVA: 0x81734A4 Offset: 0x816F4A4 VA: 0x81734A4 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x8173958 Offset: 0x816F958 VA: 0x8173958 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct HttpClient.<GetStreamAsync>d__51 : IAsyncStateMachine // TypeDefIndex: 27032
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Stream> <>t__builder; // 0x8
	public HttpClient <>4__this; // 0x20
	public Uri requestUri; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<HttpResponseMessage> <>u__1; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream> <>u__2; // 0x40

	// Methods

	// RVA: 0x81739D4 Offset: 0x816F9D4 VA: 0x81739D4 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x8173D70 Offset: 0x816FD70 VA: 0x8173D70 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct HttpClient.<GetStringAsync>d__52 : IAsyncStateMachine // TypeDefIndex: 27033
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public HttpClient <>4__this; // 0x20
	public string requestUri; // 0x28
	private HttpResponseMessage <resp>5__2; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<HttpResponseMessage> <>u__1; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<string> <>u__2; // 0x48

	// Methods

	// RVA: 0x8173DEC Offset: 0x816FDEC VA: 0x8173DEC Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x817446C Offset: 0x817046C VA: 0x817446C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct HttpClient.<GetStringAsync>d__53 : IAsyncStateMachine // TypeDefIndex: 27034
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public HttpClient <>4__this; // 0x20
	public Uri requestUri; // 0x28
	private HttpResponseMessage <resp>5__2; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<HttpResponseMessage> <>u__1; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<string> <>u__2; // 0x48

	// Methods

	// RVA: 0x81744E8 Offset: 0x81704E8 VA: 0x81744E8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x8174A50 Offset: 0x8170A50 VA: 0x8174A50 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net.Http
public class HttpClient : HttpMessageInvoker // TypeDefIndex: 27035
{
	// Fields
	private static readonly TimeSpan TimeoutDefault; // 0x0
	private Uri base_address; // 0x20
	private CancellationTokenSource cts; // 0x28
	private bool disposed; // 0x30
	private HttpRequestHeaders headers; // 0x38
	private long buffer_size; // 0x40
	private TimeSpan timeout; // 0x48

	// Properties
	public Uri BaseAddress { get; set; }
	public HttpRequestHeaders DefaultRequestHeaders { get; }
	public long MaxResponseContentBufferSize { get; set; }
	public TimeSpan Timeout { get; set; }

	// Methods

	// RVA: 0x816F6A0 Offset: 0x816B6A0 VA: 0x816F6A0
	public void .ctor() { }

	// RVA: 0x816F7C4 Offset: 0x816B7C4 VA: 0x816F7C4
	public void .ctor(HttpMessageHandler handler) { }

	// RVA: 0x816F708 Offset: 0x816B708 VA: 0x816F708
	public void .ctor(HttpMessageHandler handler, bool disposeHandler) { }

	// RVA: 0x816F858 Offset: 0x816B858 VA: 0x816F858
	public Uri get_BaseAddress() { }

	// RVA: 0x816F860 Offset: 0x816B860 VA: 0x816F860
	public void set_BaseAddress(Uri value) { }

	// RVA: 0x816F868 Offset: 0x816B868 VA: 0x816F868
	public HttpRequestHeaders get_DefaultRequestHeaders() { }

	// RVA: 0x816F934 Offset: 0x816B934 VA: 0x816F934
	public long get_MaxResponseContentBufferSize() { }

	// RVA: 0x816F93C Offset: 0x816B93C VA: 0x816F93C
	public void set_MaxResponseContentBufferSize(long value) { }

	// RVA: 0x816F988 Offset: 0x816B988 VA: 0x816F988
	public TimeSpan get_Timeout() { }

	// RVA: 0x816F990 Offset: 0x816B990 VA: 0x816F990
	public void set_Timeout(TimeSpan value) { }

	// RVA: 0x816FACC Offset: 0x816BACC VA: 0x816FACC
	public void CancelPendingRequests() { }

	// RVA: 0x816FC70 Offset: 0x816BC70 VA: 0x816FC70 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x816FD14 Offset: 0x816BD14 VA: 0x816FD14
	public Task<HttpResponseMessage> DeleteAsync(string requestUri) { }

	// RVA: 0x816FEE0 Offset: 0x816BEE0 VA: 0x816FEE0
	public Task<HttpResponseMessage> DeleteAsync(string requestUri, CancellationToken cancellationToken) { }

	// RVA: 0x816FFBC Offset: 0x816BFBC VA: 0x816FFBC
	public Task<HttpResponseMessage> DeleteAsync(Uri requestUri) { }

	// RVA: 0x81700C4 Offset: 0x816C0C4 VA: 0x81700C4
	public Task<HttpResponseMessage> DeleteAsync(Uri requestUri, CancellationToken cancellationToken) { }

	// RVA: 0x81701A0 Offset: 0x816C1A0 VA: 0x81701A0
	public Task<HttpResponseMessage> GetAsync(string requestUri) { }

	// RVA: 0x817026C Offset: 0x816C26C VA: 0x817026C
	public Task<HttpResponseMessage> GetAsync(string requestUri, CancellationToken cancellationToken) { }

	// RVA: 0x8170348 Offset: 0x816C348 VA: 0x8170348
	public Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption) { }

	// RVA: 0x8170494 Offset: 0x816C494 VA: 0x8170494
	public Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken) { }

	// RVA: 0x81707F0 Offset: 0x816C7F0 VA: 0x81707F0
	public Task<HttpResponseMessage> GetAsync(Uri requestUri) { }

	// RVA: 0x81708BC Offset: 0x816C8BC VA: 0x81708BC
	public Task<HttpResponseMessage> GetAsync(Uri requestUri, CancellationToken cancellationToken) { }

	// RVA: 0x8170998 Offset: 0x816C998 VA: 0x8170998
	public Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption) { }

	// RVA: 0x8170A6C Offset: 0x816CA6C VA: 0x8170A6C
	public Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken) { }

	// RVA: 0x8170B50 Offset: 0x816CB50 VA: 0x8170B50
	public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content) { }

	// RVA: 0x8170C40 Offset: 0x816CC40 VA: 0x8170C40
	public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content, CancellationToken cancellationToken) { }

	// RVA: 0x8170D40 Offset: 0x816CD40 VA: 0x8170D40
	public Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content) { }

	// RVA: 0x8170E30 Offset: 0x816CE30 VA: 0x8170E30
	public Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken) { }

	// RVA: 0x8170F30 Offset: 0x816CF30 VA: 0x8170F30
	public Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content) { }

	// RVA: 0x8171020 Offset: 0x816D020 VA: 0x8171020
	public Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken) { }

	// RVA: 0x8171120 Offset: 0x816D120 VA: 0x8171120
	public Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content) { }

	// RVA: 0x8171210 Offset: 0x816D210 VA: 0x8171210
	public Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content, CancellationToken cancellationToken) { }

	// RVA: 0x816FE6C Offset: 0x816BE6C VA: 0x816FE6C
	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request) { }

	// RVA: 0x817041C Offset: 0x816C41C VA: 0x817041C
	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption) { }

	// RVA: 0x8171310 Offset: 0x816D310 VA: 0x8171310 Slot: 6
	public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

	// RVA: 0x8170578 Offset: 0x816C578 VA: 0x8170578
	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(HttpClient.<SendAsyncWorker>d__47))]
	// RVA: 0x81715CC Offset: 0x816D5CC VA: 0x81715CC
	private Task<HttpResponseMessage> SendAsyncWorker(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(HttpClient.<GetByteArrayAsync>d__48))]
	// RVA: 0x817172C Offset: 0x816D72C VA: 0x817172C
	public Task<byte[]> GetByteArrayAsync(string requestUri) { }

	[AsyncStateMachine(typeof(HttpClient.<GetByteArrayAsync>d__49))]
	// RVA: 0x817185C Offset: 0x816D85C VA: 0x817185C
	public Task<byte[]> GetByteArrayAsync(Uri requestUri) { }

	[AsyncStateMachine(typeof(HttpClient.<GetStreamAsync>d__50))]
	// RVA: 0x817198C Offset: 0x816D98C VA: 0x817198C
	public Task<Stream> GetStreamAsync(string requestUri) { }

	[AsyncStateMachine(typeof(HttpClient.<GetStreamAsync>d__51))]
	// RVA: 0x8171AB8 Offset: 0x816DAB8 VA: 0x8171AB8
	public Task<Stream> GetStreamAsync(Uri requestUri) { }

	[AsyncStateMachine(typeof(HttpClient.<GetStringAsync>d__52))]
	// RVA: 0x8171BE4 Offset: 0x816DBE4 VA: 0x8171BE4
	public Task<string> GetStringAsync(string requestUri) { }

	[AsyncStateMachine(typeof(HttpClient.<GetStringAsync>d__53))]
	// RVA: 0x8171D14 Offset: 0x816DD14 VA: 0x8171D14
	public Task<string> GetStringAsync(Uri requestUri) { }

	// RVA: 0x8171E44 Offset: 0x816DE44 VA: 0x8171E44
	public Task<HttpResponseMessage> PatchAsync(string requestUri, HttpContent content) { }

	// RVA: 0x8171E7C Offset: 0x816DE7C VA: 0x8171E7C
	public Task<HttpResponseMessage> PatchAsync(string requestUri, HttpContent content, CancellationToken cancellationToken) { }

	// RVA: 0x8171EB4 Offset: 0x816DEB4 VA: 0x8171EB4
	public Task<HttpResponseMessage> PatchAsync(Uri requestUri, HttpContent content) { }

	// RVA: 0x8171EEC Offset: 0x816DEEC VA: 0x8171EEC
	public Task<HttpResponseMessage> PatchAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken) { }

	// RVA: 0x8171F24 Offset: 0x816DF24 VA: 0x8171F24
	private static void .cctor() { }

	[DebuggerHidden]
	[CompilerGenerated]
	// RVA: 0x8171FA0 Offset: 0x816DFA0 VA: 0x8171FA0
	private Task<HttpResponseMessage> <>n__0(HttpRequestMessage request, CancellationToken cancellationToken) { }
}

// Namespace: System.Net.Http
public enum HttpCompletionOption // TypeDefIndex: 27036
{
	// Fields
	public int value__; // 0x0
	public const HttpCompletionOption ResponseContentRead = 0;
	public const HttpCompletionOption ResponseHeadersRead = 1;
}

// Namespace: 
private sealed class HttpContent.FixedMemoryStream : MemoryStream // TypeDefIndex: 27037
{
	// Fields
	private readonly long maxSize; // 0x50

	// Methods

	// RVA: 0x8174DCC Offset: 0x8170DCC VA: 0x8174DCC
	public void .ctor(long maxSize) { }

	// RVA: 0x817505C Offset: 0x817105C VA: 0x817505C
	private void CheckOverflow(int count) { }

	// RVA: 0x817516C Offset: 0x817116C VA: 0x817516C Slot: 40
	public override void WriteByte(byte value) { }

	// RVA: 0x817519C Offset: 0x817119C VA: 0x817519C Slot: 38
	public override void Write(byte[] buffer, int offset, int count) { }
}

// Namespace: 
[CompilerGenerated]
private struct HttpContent.<CreateContentReadStreamAsync>d__12 : IAsyncStateMachine // TypeDefIndex: 27038
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Stream> <>t__builder; // 0x8
	public HttpContent <>4__this; // 0x20
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x81751E4 Offset: 0x81711E4 VA: 0x81751E4 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x8175400 Offset: 0x8171400 VA: 0x8175400 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct HttpContent.<LoadIntoBufferAsync>d__17 : IAsyncStateMachine // TypeDefIndex: 27039
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public HttpContent <>4__this; // 0x20
	public long maxBufferSize; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x817547C Offset: 0x817147C VA: 0x817547C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x8175748 Offset: 0x8171748 VA: 0x8175748 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct HttpContent.<ReadAsStreamAsync>d__18 : IAsyncStateMachine // TypeDefIndex: 27040
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Stream> <>t__builder; // 0x8
	public HttpContent <>4__this; // 0x20
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream> <>u__1; // 0x28

	// Methods

	// RVA: 0x81757B0 Offset: 0x81717B0 VA: 0x81757B0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x8175B34 Offset: 0x8171B34 VA: 0x8175B34 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct HttpContent.<ReadAsByteArrayAsync>d__19 : IAsyncStateMachine // TypeDefIndex: 27041
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<byte[]> <>t__builder; // 0x8
	public HttpContent <>4__this; // 0x20
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x8175BB0 Offset: 0x8171BB0 VA: 0x8175BB0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x8175DF0 Offset: 0x8171DF0 VA: 0x8175DF0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct HttpContent.<ReadAsStringAsync>d__20 : IAsyncStateMachine // TypeDefIndex: 27042
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public HttpContent <>4__this; // 0x20
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x8175E6C Offset: 0x8171E6C VA: 0x8175E6C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x81763B4 Offset: 0x81723B4 VA: 0x81763B4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net.Http
public abstract class HttpContent : IDisposable // TypeDefIndex: 27043
{
	// Fields
	private HttpContent.FixedMemoryStream buffer; // 0x10
	private Stream stream; // 0x18
	private bool disposed; // 0x20
	private HttpContentHeaders headers; // 0x28

	// Properties
	public HttpContentHeaders Headers { get; }
	internal Nullable<long> LoadedBufferLength { get; }

	// Methods

	// RVA: 0x816CA9C Offset: 0x8168A9C VA: 0x816CA9C
	public HttpContentHeaders get_Headers() { }

	// RVA: 0x8174B44 Offset: 0x8170B44 VA: 0x8174B44
	internal Nullable<long> get_LoadedBufferLength() { }

	// RVA: 0x8174BC0 Offset: 0x8170BC0 VA: 0x8174BC0
	internal void CopyTo(Stream stream) { }

	// RVA: 0x816EE8C Offset: 0x816AE8C VA: 0x816EE8C
	public Task CopyToAsync(Stream stream) { }

	// RVA: 0x8174BE0 Offset: 0x8170BE0 VA: 0x8174BE0
	public Task CopyToAsync(Stream stream, TransportContext context) { }

	[AsyncStateMachine(typeof(HttpContent.<CreateContentReadStreamAsync>d__12))]
	// RVA: 0x8174C58 Offset: 0x8170C58 VA: 0x8174C58 Slot: 5
	protected virtual Task<Stream> CreateContentReadStreamAsync() { }

	// RVA: 0x8174D70 Offset: 0x8170D70 VA: 0x8174D70
	private static HttpContent.FixedMemoryStream CreateFixedMemoryStream(long maxBufferSize) { }

	// RVA: 0x8174DF4 Offset: 0x8170DF4 VA: 0x8174DF4 Slot: 4
	public void Dispose() { }

	// RVA: 0x8174E04 Offset: 0x8170E04 VA: 0x8174E04 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x8174E30 Offset: 0x8170E30 VA: 0x8174E30
	public Task LoadIntoBufferAsync() { }

	[AsyncStateMachine(typeof(HttpContent.<LoadIntoBufferAsync>d__17))]
	// RVA: 0x816EDA0 Offset: 0x816ADA0 VA: 0x816EDA0
	public Task LoadIntoBufferAsync(long maxBufferSize) { }

	[AsyncStateMachine(typeof(HttpContent.<ReadAsStreamAsync>d__18))]
	// RVA: 0x8173840 Offset: 0x816F840 VA: 0x8173840
	public Task<Stream> ReadAsStreamAsync() { }

	[AsyncStateMachine(typeof(HttpContent.<ReadAsByteArrayAsync>d__19))]
	// RVA: 0x8172D2C Offset: 0x816ED2C VA: 0x8172D2C
	public Task<byte[]> ReadAsByteArrayAsync() { }

	[AsyncStateMachine(typeof(HttpContent.<ReadAsStringAsync>d__20))]
	// RVA: 0x8174354 Offset: 0x8170354 VA: 0x8174354
	public Task<string> ReadAsStringAsync() { }

	// RVA: 0x8174E38 Offset: 0x8170E38 VA: 0x8174E38
	private static Encoding GetEncodingFromBuffer(byte[] buffer, int length, ref int preambleLength) { }

	// RVA: 0x8174FDC Offset: 0x8170FDC VA: 0x8174FDC
	private static int StartsWith(byte[] array, int length, byte[] value) { }

	// RVA: 0x8175050 Offset: 0x8171050 VA: 0x8175050
	internal Task SerializeToStreamAsync_internal(Stream stream, TransportContext context) { }

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract Task SerializeToStreamAsync(Stream stream, TransportContext context);

	// RVA: -1 Offset: -1 Slot: 8
	protected internal abstract bool TryComputeLength(out long length);

	// RVA: 0x816F5A8 Offset: 0x816B5A8 VA: 0x816F5A8
	protected void .ctor() { }
}

// Namespace: System.Net.Http
public abstract class HttpMessageHandler : IDisposable // TypeDefIndex: 27044
{
	// Methods

	// RVA: 0x8176430 Offset: 0x8172430 VA: 0x8176430 Slot: 4
	public void Dispose() { }

	// RVA: 0x816B168 Offset: 0x8167168 VA: 0x816B168 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 6
	protected internal abstract Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);

	// RVA: 0x816AE10 Offset: 0x8166E10 VA: 0x816AE10
	protected void .ctor() { }
}

// Namespace: System.Net.Http
public class HttpMessageInvoker : IDisposable // TypeDefIndex: 27045
{
	// Fields
	internal HttpMessageHandler handler; // 0x10
	private readonly bool disposeHandler; // 0x18

	// Methods

	// RVA: 0x816F7CC Offset: 0x816B7CC VA: 0x816F7CC
	public void .ctor(HttpMessageHandler handler, bool disposeHandler) { }

	// RVA: 0x8176440 Offset: 0x8172440 VA: 0x8176440 Slot: 4
	public void Dispose() { }

	// RVA: 0x816FCCC Offset: 0x816BCCC VA: 0x816FCCC Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x8171FC0 Offset: 0x816DFC0 VA: 0x8171FC0 Slot: 6
	public virtual Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }
}

// Namespace: System.Net.Http
public class HttpMethod : IEquatable<HttpMethod> // TypeDefIndex: 27046
{
	// Fields
	private static readonly HttpMethod delete_method; // 0x0
	private static readonly HttpMethod get_method; // 0x8
	private static readonly HttpMethod head_method; // 0x10
	private static readonly HttpMethod options_method; // 0x18
	private static readonly HttpMethod post_method; // 0x20
	private static readonly HttpMethod put_method; // 0x28
	private static readonly HttpMethod trace_method; // 0x30
	private readonly string method; // 0x10

	// Properties
	public static HttpMethod Delete { get; }
	public static HttpMethod Get { get; }
	public string Method { get; }
	public static HttpMethod Post { get; }
	public static HttpMethod Put { get; }

	// Methods

	// RVA: 0x8176450 Offset: 0x8172450 VA: 0x8176450
	public void .ctor(string method) { }

	// RVA: 0x81765D4 Offset: 0x81725D4 VA: 0x81765D4
	public static HttpMethod get_Delete() { }

	// RVA: 0x817662C Offset: 0x817262C VA: 0x817662C
	public static HttpMethod get_Get() { }

	// RVA: 0x8176684 Offset: 0x8172684 VA: 0x8176684
	public string get_Method() { }

	// RVA: 0x817668C Offset: 0x817268C VA: 0x817668C
	public static HttpMethod get_Post() { }

	// RVA: 0x81766E4 Offset: 0x81726E4 VA: 0x81766E4
	public static HttpMethod get_Put() { }

	// RVA: 0x817673C Offset: 0x817273C VA: 0x817673C
	public static bool op_Equality(HttpMethod left, HttpMethod right) { }

	// RVA: 0x8176764 Offset: 0x8172764 VA: 0x8176764 Slot: 4
	public bool Equals(HttpMethod other) { }

	// RVA: 0x8176788 Offset: 0x8172788 VA: 0x8176788 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x8176814 Offset: 0x8172814 VA: 0x8176814 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x8176834 Offset: 0x8172834 VA: 0x8176834 Slot: 3
	public override string ToString() { }

	// RVA: 0x817683C Offset: 0x817283C VA: 0x817683C
	private static void .cctor() { }
}

// Namespace: System.Net.Http
[Serializable]
public class HttpRequestException : Exception // TypeDefIndex: 27047
{
	// Methods

	// RVA: 0x8176A38 Offset: 0x8172A38 VA: 0x8176A38
	public void .ctor() { }

	// RVA: 0x8175104 Offset: 0x8171104 VA: 0x8175104
	public void .ctor(string message) { }

	// RVA: 0x816EE94 Offset: 0x816AE94 VA: 0x816EE94
	public void .ctor(string message, Exception inner) { }
}

// Namespace: System.Net.Http
public class HttpRequestMessage : IDisposable // TypeDefIndex: 27048
{
	// Fields
	private HttpRequestHeaders headers; // 0x10
	private HttpMethod method; // 0x18
	private Version version; // 0x20
	private Uri uri; // 0x28
	private bool is_used; // 0x30
	private bool disposed; // 0x31
	[CompilerGenerated]
	private HttpContent <Content>k__BackingField; // 0x38

	// Properties
	public HttpContent Content { get; set; }
	public HttpRequestHeaders Headers { get; }
	public HttpMethod Method { get; set; }
	public Uri RequestUri { get; set; }
	public Version Version { get; }

	// Methods

	// RVA: 0x816FDE0 Offset: 0x816BDE0 VA: 0x816FDE0
	public void .ctor(HttpMethod method, string requestUri) { }

	// RVA: 0x8170088 Offset: 0x816C088 VA: 0x8170088
	public void .ctor(HttpMethod method, Uri requestUri) { }

	[CompilerGenerated]
	// RVA: 0x8176B44 Offset: 0x8172B44 VA: 0x8176B44
	public HttpContent get_Content() { }

	[CompilerGenerated]
	// RVA: 0x8176B4C Offset: 0x8172B4C VA: 0x8176B4C
	public void set_Content(HttpContent value) { }

	// RVA: 0x816C300 Offset: 0x8168300 VA: 0x816C300
	public HttpRequestHeaders get_Headers() { }

	// RVA: 0x8176B54 Offset: 0x8172B54 VA: 0x8176B54
	public HttpMethod get_Method() { }

	// RVA: 0x8176A90 Offset: 0x8172A90 VA: 0x8176A90
	public void set_Method(HttpMethod value) { }

	// RVA: 0x8176B5C Offset: 0x8172B5C VA: 0x8176B5C
	public Uri get_RequestUri() { }

	// RVA: 0x816CC20 Offset: 0x8168C20 VA: 0x816CC20
	public void set_RequestUri(Uri value) { }

	// RVA: 0x8176B64 Offset: 0x8172B64 VA: 0x8176B64
	private static bool IsAllowedAbsoluteUri(Uri uri) { }

	// RVA: 0x816C29C Offset: 0x816829C VA: 0x816C29C
	public Version get_Version() { }

	// RVA: 0x8176CB0 Offset: 0x8172CB0 VA: 0x8176CB0 Slot: 4
	public void Dispose() { }

	// RVA: 0x8176CC0 Offset: 0x8172CC0 VA: 0x8176CC0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x817131C Offset: 0x816D31C VA: 0x817131C
	internal bool SetIsUsed() { }

	// RVA: 0x8176CF4 Offset: 0x8172CF4 VA: 0x8176CF4 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net.Http
public class HttpResponseMessage : IDisposable // TypeDefIndex: 27049
{
	// Fields
	private HttpResponseHeaders headers; // 0x10
	private HttpResponseHeaders trailingHeaders; // 0x18
	private string reasonPhrase; // 0x20
	private HttpStatusCode statusCode; // 0x28
	private Version version; // 0x30
	private bool disposed; // 0x38
	[CompilerGenerated]
	private HttpContent <Content>k__BackingField; // 0x40
	[CompilerGenerated]
	private HttpRequestMessage <RequestMessage>k__BackingField; // 0x48

	// Properties
	public HttpContent Content { get; set; }
	public HttpResponseHeaders Headers { get; }
	public bool IsSuccessStatusCode { get; }
	public string ReasonPhrase { get; set; }
	public HttpRequestMessage RequestMessage { get; set; }
	public HttpStatusCode StatusCode { get; set; }
	public Version Version { get; set; }
	public HttpResponseHeaders TrailingHeaders { get; }

	// Methods

	// RVA: 0x8176F74 Offset: 0x8172F74 VA: 0x8176F74
	public void .ctor() { }

	// RVA: 0x816C998 Offset: 0x8168998 VA: 0x816C998
	public void .ctor(HttpStatusCode statusCode) { }

	[CompilerGenerated]
	// RVA: 0x8176FDC Offset: 0x8172FDC VA: 0x8176FDC
	public HttpContent get_Content() { }

	[CompilerGenerated]
	// RVA: 0x8176FE4 Offset: 0x8172FE4 VA: 0x8176FE4
	public void set_Content(HttpContent value) { }

	// RVA: 0x816CB10 Offset: 0x8168B10 VA: 0x816CB10
	public HttpResponseHeaders get_Headers() { }

	// RVA: 0x817704C Offset: 0x817304C VA: 0x817704C
	public bool get_IsSuccessStatusCode() { }

	// RVA: 0x8177060 Offset: 0x8173060 VA: 0x8177060
	public string get_ReasonPhrase() { }

	// RVA: 0x817707C Offset: 0x817307C VA: 0x817707C
	public void set_ReasonPhrase(string value) { }

	[CompilerGenerated]
	// RVA: 0x8177084 Offset: 0x8173084 VA: 0x8177084
	public HttpRequestMessage get_RequestMessage() { }

	[CompilerGenerated]
	// RVA: 0x817708C Offset: 0x817308C VA: 0x817708C
	public void set_RequestMessage(HttpRequestMessage value) { }

	// RVA: 0x8177094 Offset: 0x8173094 VA: 0x8177094
	public HttpStatusCode get_StatusCode() { }

	// RVA: 0x8176F94 Offset: 0x8172F94 VA: 0x8176F94
	public void set_StatusCode(HttpStatusCode value) { }

	// RVA: 0x817709C Offset: 0x817309C VA: 0x817709C
	public Version get_Version() { }

	// RVA: 0x8177100 Offset: 0x8173100 VA: 0x8177100
	public void set_Version(Version value) { }

	// RVA: 0x8177184 Offset: 0x8173184 VA: 0x8177184 Slot: 4
	public void Dispose() { }

	// RVA: 0x8177194 Offset: 0x8173194 VA: 0x8177194 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x8172C84 Offset: 0x816EC84 VA: 0x8172C84
	public HttpResponseMessage EnsureSuccessStatusCode() { }

	// RVA: 0x81771C8 Offset: 0x81731C8 VA: 0x81771C8 Slot: 3
	public override string ToString() { }

	// RVA: 0x8177404 Offset: 0x8173404 VA: 0x8177404
	public HttpResponseHeaders get_TrailingHeaders() { }
}

// Namespace: System.Net.Http
public class StreamContent : HttpContent // TypeDefIndex: 27050
{
	// Fields
	private readonly Stream content; // 0x30
	private readonly int bufferSize; // 0x38
	private readonly CancellationToken cancellationToken; // 0x40
	private readonly long startPosition; // 0x48
	private bool contentCopied; // 0x50

	// Methods

	// RVA: 0x8177470 Offset: 0x8173470 VA: 0x8177470
	public void .ctor(Stream content) { }

	// RVA: 0x8177478 Offset: 0x8173478 VA: 0x8177478
	public void .ctor(Stream content, int bufferSize) { }

	// RVA: 0x816F4F0 Offset: 0x816B4F0 VA: 0x816F4F0
	internal void .ctor(Stream content, CancellationToken cancellationToken) { }

	// RVA: 0x8177570 Offset: 0x8173570 VA: 0x8177570 Slot: 5
	protected override Task<Stream> CreateContentReadStreamAsync() { }

	// RVA: 0x81775E0 Offset: 0x81735E0 VA: 0x81775E0 Slot: 6
	protected override void Dispose(bool disposing) { }

	// RVA: 0x817762C Offset: 0x817362C VA: 0x817762C Slot: 7
	protected override Task SerializeToStreamAsync(Stream stream, TransportContext context) { }

	// RVA: 0x8177700 Offset: 0x8173700 VA: 0x8177700 Slot: 8
	protected internal override bool TryComputeLength(out long length) { }
}

// Namespace: System.Net.Http
public class StringContent : ByteArrayContent // TypeDefIndex: 27051
{
	// Methods

	// RVA: 0x8177768 Offset: 0x8173768 VA: 0x8177768
	public void .ctor(string content) { }

	// RVA: 0x8177878 Offset: 0x8173878 VA: 0x8177878
	public void .ctor(string content, Encoding encoding) { }

	// RVA: 0x8177774 Offset: 0x8173774 VA: 0x8177774
	public void .ctor(string content, Encoding encoding, string mediaType) { }

	// RVA: 0x8177880 Offset: 0x8173880 VA: 0x8177880
	private static byte[] GetByteArray(string content, Encoding encoding) { }
}

// Namespace: System.Net.Http.Headers
public class AuthenticationHeaderValue : ICloneable // TypeDefIndex: 27052
{
	// Fields
	[CompilerGenerated]
	private string <Parameter>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Scheme>k__BackingField; // 0x18

	// Properties
	public string Parameter { get; set; }
	public string Scheme { get; set; }

	// Methods

	// RVA: 0x8177A08 Offset: 0x8173A08 VA: 0x8177A08
	private void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x8177A10 Offset: 0x8173A10 VA: 0x8177A10
	public string get_Parameter() { }

	[CompilerGenerated]
	// RVA: 0x8177A18 Offset: 0x8173A18 VA: 0x8177A18
	private void set_Parameter(string value) { }

	[CompilerGenerated]
	// RVA: 0x8177A20 Offset: 0x8173A20 VA: 0x8177A20
	public string get_Scheme() { }

	[CompilerGenerated]
	// RVA: 0x8177A28 Offset: 0x8173A28 VA: 0x8177A28
	private void set_Scheme(string value) { }

	// RVA: 0x8177A30 Offset: 0x8173A30 VA: 0x8177A30 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x8177A38 Offset: 0x8173A38 VA: 0x8177A38 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x8177AEC Offset: 0x8173AEC VA: 0x8177AEC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x8177B68 Offset: 0x8173B68 VA: 0x8177B68
	public static bool TryParse(string input, out AuthenticationHeaderValue parsedValue) { }

	// RVA: 0x8177E1C Offset: 0x8173E1C VA: 0x8177E1C
	internal static bool TryParse(string input, int minimalCount, out List<AuthenticationHeaderValue> result) { }

	// RVA: 0x8177C78 Offset: 0x8173C78 VA: 0x8177C78
	private static bool TryParseElement(Lexer lexer, out AuthenticationHeaderValue parsedValue, out Token t) { }

	// RVA: 0x8178304 Offset: 0x8174304 VA: 0x8178304 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net.Http.Headers
public class CacheControlHeaderValue : ICloneable // TypeDefIndex: 27053
{
	// Fields
	private List<NameValueHeaderValue> extensions; // 0x10
	private List<string> no_cache_headers; // 0x18
	private List<string> private_headers; // 0x20
	[CompilerGenerated]
	private Nullable<TimeSpan> <MaxAge>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <MaxStale>k__BackingField; // 0x38
	[CompilerGenerated]
	private Nullable<TimeSpan> <MaxStaleLimit>k__BackingField; // 0x40
	[CompilerGenerated]
	private Nullable<TimeSpan> <MinFresh>k__BackingField; // 0x50
	[CompilerGenerated]
	private bool <MustRevalidate>k__BackingField; // 0x60
	[CompilerGenerated]
	private bool <NoCache>k__BackingField; // 0x61
	[CompilerGenerated]
	private bool <NoStore>k__BackingField; // 0x62
	[CompilerGenerated]
	private bool <NoTransform>k__BackingField; // 0x63
	[CompilerGenerated]
	private bool <OnlyIfCached>k__BackingField; // 0x64
	[CompilerGenerated]
	private bool <Private>k__BackingField; // 0x65
	[CompilerGenerated]
	private bool <ProxyRevalidate>k__BackingField; // 0x66
	[CompilerGenerated]
	private bool <Public>k__BackingField; // 0x67
	[CompilerGenerated]
	private Nullable<TimeSpan> <SharedMaxAge>k__BackingField; // 0x68

	// Properties
	public ICollection<NameValueHeaderValue> Extensions { get; }
	public Nullable<TimeSpan> MaxAge { get; set; }
	public bool MaxStale { get; set; }
	public Nullable<TimeSpan> MaxStaleLimit { get; set; }
	public Nullable<TimeSpan> MinFresh { get; set; }
	public bool MustRevalidate { get; set; }
	public bool NoCache { get; set; }
	public ICollection<string> NoCacheHeaders { get; }
	public bool NoStore { get; set; }
	public bool NoTransform { get; set; }
	public bool OnlyIfCached { get; set; }
	public bool Private { get; set; }
	public ICollection<string> PrivateHeaders { get; }
	public bool ProxyRevalidate { get; set; }
	public bool Public { get; set; }
	public Nullable<TimeSpan> SharedMaxAge { get; set; }

	// Methods

	// RVA: 0x8178360 Offset: 0x8174360 VA: 0x8178360
	public ICollection<NameValueHeaderValue> get_Extensions() { }

	[CompilerGenerated]
	// RVA: 0x81783E4 Offset: 0x81743E4 VA: 0x81783E4
	public Nullable<TimeSpan> get_MaxAge() { }

	[CompilerGenerated]
	// RVA: 0x81783F0 Offset: 0x81743F0 VA: 0x81783F0
	public void set_MaxAge(Nullable<TimeSpan> value) { }

	[CompilerGenerated]
	// RVA: 0x81783F8 Offset: 0x81743F8 VA: 0x81783F8
	public bool get_MaxStale() { }

	[CompilerGenerated]
	// RVA: 0x8178400 Offset: 0x8174400 VA: 0x8178400
	public void set_MaxStale(bool value) { }

	[CompilerGenerated]
	// RVA: 0x817840C Offset: 0x817440C VA: 0x817840C
	public Nullable<TimeSpan> get_MaxStaleLimit() { }

	[CompilerGenerated]
	// RVA: 0x8178418 Offset: 0x8174418 VA: 0x8178418
	public void set_MaxStaleLimit(Nullable<TimeSpan> value) { }

	[CompilerGenerated]
	// RVA: 0x8178420 Offset: 0x8174420 VA: 0x8178420
	public Nullable<TimeSpan> get_MinFresh() { }

	[CompilerGenerated]
	// RVA: 0x817842C Offset: 0x817442C VA: 0x817842C
	public void set_MinFresh(Nullable<TimeSpan> value) { }

	[CompilerGenerated]
	// RVA: 0x8178434 Offset: 0x8174434 VA: 0x8178434
	public bool get_MustRevalidate() { }

	[CompilerGenerated]
	// RVA: 0x817843C Offset: 0x817443C VA: 0x817843C
	public void set_MustRevalidate(bool value) { }

	[CompilerGenerated]
	// RVA: 0x8178448 Offset: 0x8174448 VA: 0x8178448
	public bool get_NoCache() { }

	[CompilerGenerated]
	// RVA: 0x8178450 Offset: 0x8174450 VA: 0x8178450
	public void set_NoCache(bool value) { }

	// RVA: 0x817845C Offset: 0x817445C VA: 0x817845C
	public ICollection<string> get_NoCacheHeaders() { }

	[CompilerGenerated]
	// RVA: 0x81784E0 Offset: 0x81744E0 VA: 0x81784E0
	public bool get_NoStore() { }

	[CompilerGenerated]
	// RVA: 0x81784E8 Offset: 0x81744E8 VA: 0x81784E8
	public void set_NoStore(bool value) { }

	[CompilerGenerated]
	// RVA: 0x81784F4 Offset: 0x81744F4 VA: 0x81784F4
	public bool get_NoTransform() { }

	[CompilerGenerated]
	// RVA: 0x81784FC Offset: 0x81744FC VA: 0x81784FC
	public void set_NoTransform(bool value) { }

	[CompilerGenerated]
	// RVA: 0x8178508 Offset: 0x8174508 VA: 0x8178508
	public bool get_OnlyIfCached() { }

	[CompilerGenerated]
	// RVA: 0x8178510 Offset: 0x8174510 VA: 0x8178510
	public void set_OnlyIfCached(bool value) { }

	[CompilerGenerated]
	// RVA: 0x817851C Offset: 0x817451C VA: 0x817851C
	public bool get_Private() { }

	[CompilerGenerated]
	// RVA: 0x8178524 Offset: 0x8174524 VA: 0x8178524
	public void set_Private(bool value) { }

	// RVA: 0x8178530 Offset: 0x8174530 VA: 0x8178530
	public ICollection<string> get_PrivateHeaders() { }

	[CompilerGenerated]
	// RVA: 0x81785B4 Offset: 0x81745B4 VA: 0x81785B4
	public bool get_ProxyRevalidate() { }

	[CompilerGenerated]
	// RVA: 0x81785BC Offset: 0x81745BC VA: 0x81785BC
	public void set_ProxyRevalidate(bool value) { }

	[CompilerGenerated]
	// RVA: 0x81785C8 Offset: 0x81745C8 VA: 0x81785C8
	public bool get_Public() { }

	[CompilerGenerated]
	// RVA: 0x81785D0 Offset: 0x81745D0 VA: 0x81785D0
	public void set_Public(bool value) { }

	[CompilerGenerated]
	// RVA: 0x81785DC Offset: 0x81745DC VA: 0x81785DC
	public Nullable<TimeSpan> get_SharedMaxAge() { }

	[CompilerGenerated]
	// RVA: 0x81785E8 Offset: 0x81745E8 VA: 0x81785E8
	public void set_SharedMaxAge(Nullable<TimeSpan> value) { }

	// RVA: 0x81785F0 Offset: 0x81745F0 VA: 0x81785F0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x8178B88 Offset: 0x8174B88 VA: 0x8178B88 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x8178F24 Offset: 0x8174F24 VA: 0x8178F24 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x81791AC Offset: 0x81751AC VA: 0x81791AC
	public static bool TryParse(string input, out CacheControlHeaderValue parsedValue) { }

	// RVA: 0x8179CE8 Offset: 0x8175CE8 VA: 0x8179CE8 Slot: 3
	public override string ToString() { }

	// RVA: 0x8179B08 Offset: 0x8175B08 VA: 0x8179B08
	public void .ctor() { }
}

// Namespace: System.Net.Http.Headers
[Extension]
internal static class CollectionExtensions // TypeDefIndex: 27054
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static bool SequenceEqual<TSource>(List<TSource> first, List<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45505CC Offset: 0x454C5CC VA: 0x45505CC
	|-CollectionExtensions.SequenceEqual<object>
	|
	|-RVA: 0x4550644 Offset: 0x454C644 VA: 0x4550644
	|-CollectionExtensions.SequenceEqual<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x817A454 Offset: 0x8176454 VA: 0x817A454
	public static void SetValue(List<NameValueHeaderValue> parameters, string key, string value) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static string ToString<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45506D4 Offset: 0x454C6D4 VA: 0x45506D4
	|-CollectionExtensions.ToString<object>
	|
	|-RVA: 0x45507D8 Offset: 0x454C7D8 VA: 0x45507D8
	|-CollectionExtensions.ToString<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void ToStringBuilder<T>(List<T> list, StringBuilder sb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4550980 Offset: 0x454C980 VA: 0x4550980
	|-CollectionExtensions.ToStringBuilder<object>
	|
	|-RVA: 0x4550A44 Offset: 0x454CA44 VA: 0x4550A44
	|-CollectionExtensions.ToStringBuilder<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Net.Http.Headers
internal sealed class ElementTryParser<T> : MulticastDelegate // TypeDefIndex: 27055
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6053074 Offset: 0x604F074 VA: 0x6053074
	|-ElementTryParser<object>..ctor
	|
	|-RVA: 0x6053194 Offset: 0x604F194 VA: 0x6053194
	|-ElementTryParser<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual bool Invoke(Lexer lexer, out T parsedValue, out Token token) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6053180 Offset: 0x604F180 VA: 0x6053180
	|-ElementTryParser<object>.Invoke
	|
	|-RVA: 0x60532A0 Offset: 0x604F2A0 VA: 0x60532A0
	|-ElementTryParser<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System.Net.Http.Headers
internal static class CollectionParser // TypeDefIndex: 27056
{
	// Methods

	// RVA: -1 Offset: -1
	public static bool TryParse<T>(string input, int minimalCount, ElementTryParser<T> parser, out List<T> result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4550D04 Offset: 0x454CD04 VA: 0x4550D04
	|-CollectionParser.TryParse<object>
	*/

	// RVA: 0x817A7D8 Offset: 0x81767D8 VA: 0x817A7D8
	public static bool TryParse(string input, int minimalCount, out List<string> result) { }

	// RVA: 0x817A888 Offset: 0x8176888 VA: 0x817A888
	private static bool TryParseStringElement(Lexer lexer, out string parsedValue, out Token t) { }
}

// Namespace: System.Net.Http.Headers
public class ContentDispositionHeaderValue : ICloneable // TypeDefIndex: 27057
{
	// Fields
	private string dispositionType; // 0x10
	private List<NameValueHeaderValue> parameters; // 0x18

	// Properties
	public ICollection<NameValueHeaderValue> Parameters { get; }

	// Methods

	// RVA: 0x817A97C Offset: 0x817697C VA: 0x817A97C
	private void .ctor() { }

	// RVA: 0x817A984 Offset: 0x8176984 VA: 0x817A984
	protected void .ctor(ContentDispositionHeaderValue source) { }

	// RVA: 0x817ABF4 Offset: 0x8176BF4 VA: 0x817ABF4
	public ICollection<NameValueHeaderValue> get_Parameters() { }

	// RVA: 0x817ACC0 Offset: 0x8176CC0 VA: 0x817ACC0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x817AD18 Offset: 0x8176D18 VA: 0x817AD18 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x817ADE0 Offset: 0x8176DE0 VA: 0x817ADE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x817AE5C Offset: 0x8176E5C VA: 0x817AE5C Slot: 3
	public override string ToString() { }

	// RVA: 0x817AEB4 Offset: 0x8176EB4 VA: 0x817AEB4
	public static bool TryParse(string input, out ContentDispositionHeaderValue parsedValue) { }
}

// Namespace: System.Net.Http.Headers
public class ContentRangeHeaderValue : ICloneable // TypeDefIndex: 27058
{
	// Fields
	private string unit; // 0x10
	[CompilerGenerated]
	private Nullable<long> <From>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<long> <Length>k__BackingField; // 0x28
	[CompilerGenerated]
	private Nullable<long> <To>k__BackingField; // 0x38

	// Properties
	public Nullable<long> From { get; set; }
	public Nullable<long> Length { get; set; }
	public Nullable<long> To { get; set; }
	public string Unit { get; }

	// Methods

	// RVA: 0x817B35C Offset: 0x817735C VA: 0x817B35C
	private void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x817B3B4 Offset: 0x81773B4 VA: 0x817B3B4
	public Nullable<long> get_From() { }

	[CompilerGenerated]
	// RVA: 0x817B3C0 Offset: 0x81773C0 VA: 0x817B3C0
	private void set_From(Nullable<long> value) { }

	[CompilerGenerated]
	// RVA: 0x817B3C8 Offset: 0x81773C8 VA: 0x817B3C8
	public Nullable<long> get_Length() { }

	[CompilerGenerated]
	// RVA: 0x817B3D4 Offset: 0x81773D4 VA: 0x817B3D4
	private void set_Length(Nullable<long> value) { }

	[CompilerGenerated]
	// RVA: 0x817B3DC Offset: 0x81773DC VA: 0x817B3DC
	public Nullable<long> get_To() { }

	[CompilerGenerated]
	// RVA: 0x817B3E8 Offset: 0x81773E8 VA: 0x817B3E8
	private void set_To(Nullable<long> value) { }

	// RVA: 0x817B3F0 Offset: 0x81773F0 VA: 0x817B3F0
	public string get_Unit() { }

	// RVA: 0x817B3F8 Offset: 0x81773F8 VA: 0x817B3F8 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x817B400 Offset: 0x8177400 VA: 0x817B400 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x817B548 Offset: 0x8177548 VA: 0x817B548 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x817B634 Offset: 0x8177634 VA: 0x817B634
	public static bool TryParse(string input, out ContentRangeHeaderValue parsedValue) { }

	// RVA: 0x817BB88 Offset: 0x8177B88 VA: 0x817BB88 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net.Http.Headers
public class EntityTagHeaderValue : ICloneable // TypeDefIndex: 27059
{
	// Fields
	private static readonly EntityTagHeaderValue any; // 0x0
	[CompilerGenerated]
	private bool <IsWeak>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Tag>k__BackingField; // 0x18

	// Properties
	public bool IsWeak { get; set; }
	public string Tag { get; set; }

	// Methods

	// RVA: 0x817BDE4 Offset: 0x8177DE4 VA: 0x817BDE4
	internal void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x817BDEC Offset: 0x8177DEC VA: 0x817BDEC
	public bool get_IsWeak() { }

	[CompilerGenerated]
	// RVA: 0x817BDF4 Offset: 0x8177DF4 VA: 0x817BDF4
	internal void set_IsWeak(bool value) { }

	[CompilerGenerated]
	// RVA: 0x817BE00 Offset: 0x8177E00 VA: 0x817BE00
	public string get_Tag() { }

	[CompilerGenerated]
	// RVA: 0x817BE08 Offset: 0x8177E08 VA: 0x817BE08
	internal void set_Tag(string value) { }

	// RVA: 0x817BE10 Offset: 0x8177E10 VA: 0x817BE10 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x817BE18 Offset: 0x8177E18 VA: 0x817BE18 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x817BECC Offset: 0x8177ECC VA: 0x817BECC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x817BF5C Offset: 0x8177F5C VA: 0x817BF5C
	public static bool TryParse(string input, out EntityTagHeaderValue parsedValue) { }

	// RVA: 0x817C060 Offset: 0x8178060 VA: 0x817C060
	private static bool TryParseElement(Lexer lexer, out EntityTagHeaderValue parsedValue, out Token t) { }

	// RVA: 0x817C2C8 Offset: 0x81782C8 VA: 0x817C2C8
	internal static bool TryParse(string input, int minimalCount, out List<EntityTagHeaderValue> result) { }

	// RVA: 0x817C378 Offset: 0x8178378 VA: 0x817C378 Slot: 3
	public override string ToString() { }

	// RVA: 0x817C3DC Offset: 0x81783DC VA: 0x817C3DC
	private static void .cctor() { }
}

// Namespace: System.Net.Http.Headers
internal static class HashCodeCalculator // TypeDefIndex: 27060
{
	// Methods

	// RVA: -1 Offset: -1
	public static int Calculate<T>(ICollection<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4638628 Offset: 0x4634628 VA: 0x4638628
	|-HashCodeCalculator.Calculate<object>
	|
	|-RVA: 0x4638938 Offset: 0x4634938 VA: 0x4638938
	|-HashCodeCalculator.Calculate<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Net.Http.Headers
internal sealed class TryParseDelegate<T> : MulticastDelegate // TypeDefIndex: 27061
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5657E8C Offset: 0x5653E8C VA: 0x5657E8C
	|-TryParseDelegate<DateTimeOffset>..ctor
	|
	|-RVA: 0x5657F54 Offset: 0x5653F54 VA: 0x5657F54
	|-TryParseDelegate<int>..ctor
	|
	|-RVA: 0x565801C Offset: 0x565401C VA: 0x565801C
	|-TryParseDelegate<long>..ctor
	|
	|-RVA: 0x56580E4 Offset: 0x56540E4 VA: 0x56580E4
	|-TryParseDelegate<object>..ctor
	|
	|-RVA: 0x56581AC Offset: 0x56541AC VA: 0x56581AC
	|-TryParseDelegate<TimeSpan>..ctor
	|
	|-RVA: 0x5658274 Offset: 0x5654274 VA: 0x5658274
	|-TryParseDelegate<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual bool Invoke(string value, out T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5657F40 Offset: 0x5653F40 VA: 0x5657F40
	|-TryParseDelegate<DateTimeOffset>.Invoke
	|
	|-RVA: 0x5658008 Offset: 0x5654008 VA: 0x5658008
	|-TryParseDelegate<int>.Invoke
	|
	|-RVA: 0x56580D0 Offset: 0x56540D0 VA: 0x56580D0
	|-TryParseDelegate<long>.Invoke
	|
	|-RVA: 0x5658198 Offset: 0x5654198 VA: 0x5658198
	|-TryParseDelegate<object>.Invoke
	|
	|-RVA: 0x5658260 Offset: 0x5654260 VA: 0x5658260
	|-TryParseDelegate<TimeSpan>.Invoke
	|
	|-RVA: 0x5658328 Offset: 0x5654328 VA: 0x5658328
	|-TryParseDelegate<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System.Net.Http.Headers
internal sealed class TryParseListDelegate<T> : MulticastDelegate // TypeDefIndex: 27062
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x565833C Offset: 0x565433C VA: 0x565833C
	|-TryParseListDelegate<object>..ctor
	|
	|-RVA: 0x5658404 Offset: 0x5654404 VA: 0x5658404
	|-TryParseListDelegate<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual bool Invoke(string value, int minimalCount, out List<T> result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56583F0 Offset: 0x56543F0 VA: 0x56583F0
	|-TryParseListDelegate<object>.Invoke
	|
	|-RVA: 0x56584B8 Offset: 0x56544B8 VA: 0x56584B8
	|-TryParseListDelegate<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
private class HeaderInfo.HeaderTypeInfo<T, U> : HeaderInfo // TypeDefIndex: 27063
{
	// Fields
	private readonly TryParseDelegate<T> parser; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(string name, TryParseDelegate<T> parser, HttpHeaderKind headerKind) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49821CC Offset: 0x497E1CC VA: 0x49821CC
	|-HeaderInfo.HeaderTypeInfo<DateTimeOffset, object>..ctor
	|
	|-RVA: 0x4982830 Offset: 0x497E830 VA: 0x4982830
	|-HeaderInfo.HeaderTypeInfo<int, object>..ctor
	|
	|-RVA: 0x4982E8C Offset: 0x497EE8C VA: 0x4982E8C
	|-HeaderInfo.HeaderTypeInfo<long, object>..ctor
	|
	|-RVA: 0x49834EC Offset: 0x497F4EC VA: 0x49834EC
	|-HeaderInfo.HeaderTypeInfo<object, object>..ctor
	|
	|-RVA: 0x4983B24 Offset: 0x497FB24 VA: 0x4983B24
	|-HeaderInfo.HeaderTypeInfo<TimeSpan, object>..ctor
	|
	|-RVA: 0x4984184 Offset: 0x4980184 VA: 0x4984184
	|-HeaderInfo.HeaderTypeInfo<__Il2CppFullySharedGenericType, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override void AddToCollection(object collection, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4982200 Offset: 0x497E200 VA: 0x4982200
	|-HeaderInfo.HeaderTypeInfo<DateTimeOffset, object>.AddToCollection
	|
	|-RVA: 0x4982864 Offset: 0x497E864 VA: 0x4982864
	|-HeaderInfo.HeaderTypeInfo<int, object>.AddToCollection
	|
	|-RVA: 0x4982EC0 Offset: 0x497EEC0 VA: 0x4982EC0
	|-HeaderInfo.HeaderTypeInfo<long, object>.AddToCollection
	|
	|-RVA: 0x4983520 Offset: 0x497F520 VA: 0x4983520
	|-HeaderInfo.HeaderTypeInfo<object, object>.AddToCollection
	|
	|-RVA: 0x4983B58 Offset: 0x497FB58 VA: 0x4983B58
	|-HeaderInfo.HeaderTypeInfo<TimeSpan, object>.AddToCollection
	|
	|-RVA: 0x49841B8 Offset: 0x49801B8 VA: 0x49841B8
	|-HeaderInfo.HeaderTypeInfo<__Il2CppFullySharedGenericType, object>.AddToCollection
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override object CreateCollection(HttpHeaders headers, HeaderInfo headerInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x498232C Offset: 0x497E32C VA: 0x498232C
	|-HeaderInfo.HeaderTypeInfo<DateTimeOffset, object>.CreateCollection
	|
	|-RVA: 0x4982990 Offset: 0x497E990 VA: 0x4982990
	|-HeaderInfo.HeaderTypeInfo<int, object>.CreateCollection
	|
	|-RVA: 0x4982FEC Offset: 0x497EFEC VA: 0x4982FEC
	|-HeaderInfo.HeaderTypeInfo<long, object>.CreateCollection
	|
	|-RVA: 0x498364C Offset: 0x497F64C VA: 0x498364C
	|-HeaderInfo.HeaderTypeInfo<object, object>.CreateCollection
	|
	|-RVA: 0x4983C84 Offset: 0x497FC84 VA: 0x4983C84
	|-HeaderInfo.HeaderTypeInfo<TimeSpan, object>.CreateCollection
	|
	|-RVA: 0x49842E4 Offset: 0x49802E4 VA: 0x49842E4
	|-HeaderInfo.HeaderTypeInfo<__Il2CppFullySharedGenericType, object>.CreateCollection
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override List<string> ToStringCollection(object collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4982388 Offset: 0x497E388 VA: 0x4982388
	|-HeaderInfo.HeaderTypeInfo<DateTimeOffset, object>.ToStringCollection
	|
	|-RVA: 0x49829EC Offset: 0x497E9EC VA: 0x49829EC
	|-HeaderInfo.HeaderTypeInfo<int, object>.ToStringCollection
	|
	|-RVA: 0x4983048 Offset: 0x497F048 VA: 0x4983048
	|-HeaderInfo.HeaderTypeInfo<long, object>.ToStringCollection
	|
	|-RVA: 0x49836A8 Offset: 0x497F6A8 VA: 0x49836A8
	|-HeaderInfo.HeaderTypeInfo<object, object>.ToStringCollection
	|
	|-RVA: 0x4983CE0 Offset: 0x497FCE0 VA: 0x4983CE0
	|-HeaderInfo.HeaderTypeInfo<TimeSpan, object>.ToStringCollection
	|
	|-RVA: 0x4984340 Offset: 0x4980340 VA: 0x4984340
	|-HeaderInfo.HeaderTypeInfo<__Il2CppFullySharedGenericType, object>.ToStringCollection
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override bool TryParse(string value, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49827B0 Offset: 0x497E7B0 VA: 0x49827B0
	|-HeaderInfo.HeaderTypeInfo<DateTimeOffset, object>.TryParse
	|
	|-RVA: 0x4982E14 Offset: 0x497EE14 VA: 0x4982E14
	|-HeaderInfo.HeaderTypeInfo<int, object>.TryParse
	|
	|-RVA: 0x4983470 Offset: 0x497F470 VA: 0x4983470
	|-HeaderInfo.HeaderTypeInfo<long, object>.TryParse
	|
	|-RVA: 0x4983AD0 Offset: 0x497FAD0 VA: 0x4983AD0
	|-HeaderInfo.HeaderTypeInfo<object, object>.TryParse
	|
	|-RVA: 0x4984108 Offset: 0x4980108 VA: 0x4984108
	|-HeaderInfo.HeaderTypeInfo<TimeSpan, object>.TryParse
	|
	|-RVA: 0x4984768 Offset: 0x4980768 VA: 0x4984768
	|-HeaderInfo.HeaderTypeInfo<__Il2CppFullySharedGenericType, object>.TryParse
	*/
}

// Namespace: 
private class HeaderInfo.CollectionHeaderTypeInfo<T, U> : HeaderInfo.HeaderTypeInfo<T, U> // TypeDefIndex: 27064
{
	// Fields
	private readonly int minimalCount; // 0x0
	private readonly string separator; // 0x0
	private readonly TryParseListDelegate<T> parser; // 0x0

	// Properties
	public override string Separator { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(string name, TryParseListDelegate<T> parser, HttpHeaderKind headerKind, int minimalCount, string separator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BB9D20 Offset: 0x5BB5D20 VA: 0x5BB9D20
	|-HeaderInfo.CollectionHeaderTypeInfo<object, object>..ctor
	|
	|-RVA: 0x5BB9DFC Offset: 0x5BB5DFC VA: 0x5BB9DFC
	|-HeaderInfo.CollectionHeaderTypeInfo<__Il2CppFullySharedGenericType, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override string get_Separator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BB9D88 Offset: 0x5BB5D88 VA: 0x5BB9D88
	|-HeaderInfo.CollectionHeaderTypeInfo<object, object>.get_Separator
	|
	|-RVA: 0x5BB9E68 Offset: 0x5BB5E68 VA: 0x5BB9E68
	|-HeaderInfo.CollectionHeaderTypeInfo<__Il2CppFullySharedGenericType, object>.get_Separator
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override bool TryParse(string value, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BB9D90 Offset: 0x5BB5D90 VA: 0x5BB9D90
	|-HeaderInfo.CollectionHeaderTypeInfo<object, object>.TryParse
	|
	|-RVA: 0x5BB9E70 Offset: 0x5BB5E70 VA: 0x5BB9E70
	|-HeaderInfo.CollectionHeaderTypeInfo<__Il2CppFullySharedGenericType, object>.TryParse
	*/
}

// Namespace: System.Net.Http.Headers
internal abstract class HeaderInfo // TypeDefIndex: 27065
{
	// Fields
	public bool AllowsMany; // 0x10
	public readonly HttpHeaderKind HeaderKind; // 0x14
	public readonly string Name; // 0x18
	[CompilerGenerated]
	private Func<object, string> <CustomToString>k__BackingField; // 0x20

	// Properties
	public Func<object, string> CustomToString { get; set; }
	public virtual string Separator { get; }

	// Methods

	// RVA: 0x817C470 Offset: 0x8178470 VA: 0x817C470
	protected void .ctor(string name, HttpHeaderKind headerKind) { }

	// RVA: -1 Offset: -1
	public static HeaderInfo CreateSingle<T>(string name, TryParseDelegate<T> parser, HttpHeaderKind headerKind, Func<object, string> toString) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46395EC Offset: 0x46355EC VA: 0x46395EC
	|-HeaderInfo.CreateSingle<DateTimeOffset>
	|
	|-RVA: 0x463967C Offset: 0x463567C VA: 0x463967C
	|-HeaderInfo.CreateSingle<int>
	|
	|-RVA: 0x463970C Offset: 0x463570C VA: 0x463970C
	|-HeaderInfo.CreateSingle<long>
	|
	|-RVA: 0x463979C Offset: 0x463579C VA: 0x463979C
	|-HeaderInfo.CreateSingle<object>
	|
	|-RVA: 0x463982C Offset: 0x463582C VA: 0x463982C
	|-HeaderInfo.CreateSingle<TimeSpan>
	|
	|-RVA: 0x46398BC Offset: 0x46358BC VA: 0x46398BC
	|-HeaderInfo.CreateSingle<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static HeaderInfo CreateMulti<T>(string name, TryParseListDelegate<T> elementParser, HttpHeaderKind headerKind, int minimalCount = 1, string separator = ", ") { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4639560 Offset: 0x4635560 VA: 0x4639560
	|-HeaderInfo.CreateMulti<object>
	*/

	// RVA: 0x817C4AC Offset: 0x81784AC VA: 0x817C4AC
	public object CreateCollection(HttpHeaders headers) { }

	[CompilerGenerated]
	// RVA: 0x817C4BC Offset: 0x81784BC VA: 0x817C4BC
	public Func<object, string> get_CustomToString() { }

	[CompilerGenerated]
	// RVA: 0x817C4C4 Offset: 0x81784C4 VA: 0x817C4C4
	private void set_CustomToString(Func<object, string> value) { }

	// RVA: 0x817C4CC Offset: 0x81784CC VA: 0x817C4CC Slot: 4
	public virtual string get_Separator() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void AddToCollection(object collection, object value);

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract object CreateCollection(HttpHeaders headers, HeaderInfo headerInfo);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract List<string> ToStringCollection(object collection);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool TryParse(string value, out object result);
}

// Namespace: System.Net.Http.Headers
public sealed class HttpContentHeaders : HttpHeaders // TypeDefIndex: 27066
{
	// Fields
	private readonly HttpContent content; // 0x20

	// Properties
	public Nullable<long> ContentLength { get; }
	public MediaTypeHeaderValue ContentType { get; set; }

	// Methods

	// RVA: 0x8174ACC Offset: 0x8170ACC VA: 0x8174ACC
	internal void .ctor(HttpContent content) { }

	// RVA: 0x816EC78 Offset: 0x816AC78 VA: 0x816EC78
	public Nullable<long> get_ContentLength() { }

	// RVA: 0x8176238 Offset: 0x8172238 VA: 0x8176238
	public MediaTypeHeaderValue get_ContentType() { }

	// RVA: 0x8177994 Offset: 0x8173994 VA: 0x8177994
	public void set_ContentType(MediaTypeHeaderValue value) { }
}

// Namespace: System.Net.Http.Headers
[Flags]
internal enum HttpHeaderKind // TypeDefIndex: 27067
{
	// Fields
	public int value__; // 0x0
	public const HttpHeaderKind None = 0;
	public const HttpHeaderKind Request = 1;
	public const HttpHeaderKind Response = 2;
	public const HttpHeaderKind Content = 4;
}

// Namespace: System.Net.Http.Headers
public sealed class HttpHeaderValueCollection<T> : ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 27068
{
	// Fields
	private readonly List<T> list; // 0x0
	private readonly HttpHeaders headers; // 0x0
	private readonly HeaderInfo headerInfo; // 0x0
	private List<string> invalidValues; // 0x0

	// Properties
	public int Count { get; }
	internal List<string> InvalidValues { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(HttpHeaders headers, HeaderInfo headerInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4984B28 Offset: 0x4980B28 VA: 0x4984B28
	|-HttpHeaderValueCollection<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4984BB8 Offset: 0x4980BB8 VA: 0x4984BB8
	|-HttpHeaderValueCollection<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	internal List<string> get_InvalidValues() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4984BD4 Offset: 0x4980BD4 VA: 0x4984BD4
	|-HttpHeaderValueCollection<object>.get_InvalidValues
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4984BDC Offset: 0x4980BDC VA: 0x4984BDC
	|-HttpHeaderValueCollection<object>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4984BE4 Offset: 0x4980BE4 VA: 0x4984BE4
	|-HttpHeaderValueCollection<object>.Add
	*/

	// RVA: -1 Offset: -1
	internal void AddRange(List<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4984C54 Offset: 0x4980C54 VA: 0x4984C54
	|-HttpHeaderValueCollection<object>.AddRange
	*/

	// RVA: -1 Offset: -1
	internal void AddInvalidValue(string invalidValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4984C78 Offset: 0x4980C78 VA: 0x4984C78
	|-HttpHeaderValueCollection<object>.AddInvalidValue
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4984D78 Offset: 0x4980D78 VA: 0x4984D78
	|-HttpHeaderValueCollection<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4984DC4 Offset: 0x4980DC4 VA: 0x4984DC4
	|-HttpHeaderValueCollection<object>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4984DE8 Offset: 0x4980DE8 VA: 0x4984DE8
	|-HttpHeaderValueCollection<object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4984E0C Offset: 0x4980E0C VA: 0x4984E0C
	|-HttpHeaderValueCollection<object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4984E30 Offset: 0x4980E30 VA: 0x4984E30
	|-HttpHeaderValueCollection<object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4984EC0 Offset: 0x4980EC0 VA: 0x4984EC0
	|-HttpHeaderValueCollection<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4984F24 Offset: 0x4980F24 VA: 0x4984F24
	|-HttpHeaderValueCollection<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	internal T Find(Predicate<T> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4984F34 Offset: 0x4980F34 VA: 0x4984F34
	|-HttpHeaderValueCollection<object>.Find
	*/
}

// Namespace: 
private class HttpHeaders.HeaderBucket // TypeDefIndex: 27069
{
	// Fields
	public object Parsed; // 0x10
	private List<string> values; // 0x18
	public readonly Func<object, string> CustomToString; // 0x20

	// Properties
	public bool HasStringValues { get; }
	public List<string> Values { get; set; }

	// Methods

	// RVA: 0x817EE64 Offset: 0x817AE64 VA: 0x817EE64
	public void .ctor(object parsed, Func<object, string> converter) { }

	// RVA: 0x817F800 Offset: 0x817B800 VA: 0x817F800
	public bool get_HasStringValues() { }

	// RVA: 0x817EEA8 Offset: 0x817AEA8 VA: 0x817EEA8
	public List<string> get_Values() { }

	// RVA: 0x817F854 Offset: 0x817B854 VA: 0x817F854
	public void set_Values(List<string> value) { }

	// RVA: 0x817F7C4 Offset: 0x817B7C4 VA: 0x817F7C4
	public string ParsedToString() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HttpHeaders.<GetEnumerator>d__19 : IEnumerator<KeyValuePair<string, IEnumerable<string>>>, IDisposable, IEnumerator // TypeDefIndex: 27070
{
	// Fields
	private int <>1__state; // 0x10
	private KeyValuePair<string, IEnumerable<string>> <>2__current; // 0x18
	public HttpHeaders <>4__this; // 0x28
	private Dictionary.Enumerator<string, HttpHeaders.HeaderBucket> <>7__wrap1; // 0x30

	// Properties
	private KeyValuePair<string, IEnumerable<string>> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x817F1DC Offset: 0x817B1DC VA: 0x817F1DC
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x817F85C Offset: 0x817B85C VA: 0x817F85C Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x817F878 Offset: 0x817B878 VA: 0x817F878 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x817FB4C Offset: 0x817BB4C VA: 0x817FB4C
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x817FB9C Offset: 0x817BB9C VA: 0x817FB9C Slot: 4
	private KeyValuePair<string, IEnumerable<string>> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x817FBA8 Offset: 0x817BBA8 VA: 0x817FBA8 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x817FBE0 Offset: 0x817BBE0 VA: 0x817FBE0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: System.Net.Http.Headers
public abstract class HttpHeaders : IEnumerable<KeyValuePair<string, IEnumerable<string>>>, IEnumerable // TypeDefIndex: 27071
{
	// Fields
	private static readonly Dictionary<string, HeaderInfo> known_headers; // 0x0
	private readonly Dictionary<string, HttpHeaders.HeaderBucket> headers; // 0x10
	private readonly HttpHeaderKind HeaderKind; // 0x18
	internal Nullable<bool> connectionclose; // 0x1C
	internal Nullable<bool> transferEncodingChunked; // 0x1E

	// Methods

	// RVA: 0x817C528 Offset: 0x8178528 VA: 0x817C528
	private static void .cctor() { }

	// RVA: 0x817E748 Offset: 0x817A748 VA: 0x817E748
	protected void .ctor() { }

	// RVA: 0x817C504 Offset: 0x8178504 VA: 0x817C504
	internal void .ctor(HttpHeaderKind headerKind) { }

	// RVA: 0x817E834 Offset: 0x817A834 VA: 0x817E834
	private bool AddInternal(string name, IEnumerable<string> values, HeaderInfo headerInfo, bool ignoreInvalid) { }

	// RVA: 0x816CB7C Offset: 0x8168B7C VA: 0x816CB7C
	public bool TryAddWithoutValidation(string name, IEnumerable<string> values) { }

	// RVA: 0x817F014 Offset: 0x817B014 VA: 0x817F014
	private HeaderInfo CheckName(string name) { }

	// RVA: 0x817EF2C Offset: 0x817AF2C VA: 0x817EF2C
	private bool TryCheckName(string name, out HeaderInfo headerInfo) { }

	[IteratorStateMachine(typeof(HttpHeaders.<GetEnumerator>d__19))]
	// RVA: 0x816C66C Offset: 0x816866C VA: 0x816C66C Slot: 4
	public IEnumerator<KeyValuePair<string, IEnumerable<string>>> GetEnumerator() { }

	// RVA: 0x817F204 Offset: 0x817B204 VA: 0x817F204 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x817F208 Offset: 0x817B208 VA: 0x817F208
	public bool Remove(string name) { }

	// RVA: 0x816F07C Offset: 0x816B07C VA: 0x816F07C
	internal static string GetSingleHeaderString(string key, IEnumerable<string> values) { }

	// RVA: 0x817F26C Offset: 0x817B26C VA: 0x817F26C Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1
	internal void AddOrRemove<T>(string name, T value, Func<object, string> converter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x463C98C Offset: 0x463898C VA: 0x463C98C
	|-HttpHeaders.AddOrRemove<object>
	*/

	// RVA: 0x817F5E8 Offset: 0x817B5E8 VA: 0x817F5E8
	private List<string> GetAllHeaderValues(HttpHeaders.HeaderBucket bucket, HeaderInfo headerInfo) { }

	// RVA: 0x816EF80 Offset: 0x816AF80 VA: 0x816EF80
	internal static HttpHeaderKind GetKnownHeaderKind(string name) { }

	// RVA: -1 Offset: -1
	internal T GetValue<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x463C9F0 Offset: 0x46389F0 VA: 0x463C9F0
	|-HttpHeaders.GetValue<Nullable<long>>
	|
	|-RVA: 0x463CCCC Offset: 0x4638CCC VA: 0x463CCCC
	|-HttpHeaders.GetValue<object>
	|
	|-RVA: 0x463CF30 Offset: 0x4638F30 VA: 0x463CF30
	|-HttpHeaders.GetValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal HttpHeaderValueCollection<T> GetValues<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x463D230 Offset: 0x4639230 VA: 0x463D230
	|-HttpHeaders.GetValues<object>
	*/

	// RVA: -1 Offset: -1
	internal void SetValue<T>(string name, T value, Func<object, string> toStringConverter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x463D598 Offset: 0x4639598 VA: 0x463D598
	|-HttpHeaders.SetValue<long>
	|
	|-RVA: 0x463D668 Offset: 0x4639668 VA: 0x463D668
	|-HttpHeaders.SetValue<object>
	|
	|-RVA: 0x463D710 Offset: 0x4639710 VA: 0x463D710
	|-HttpHeaders.SetValue<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class HttpRequestHeaders.<>c // TypeDefIndex: 27072
{
	// Fields
	public static readonly HttpRequestHeaders.<>c <>9; // 0x0
	public static Predicate<string> <>9__19_0; // 0x8
	public static Predicate<TransferCodingHeaderValue> <>9__29_0; // 0x10
	public static Predicate<TransferCodingHeaderValue> <>9__71_0; // 0x18

	// Methods

	// RVA: 0x817FCA4 Offset: 0x817BCA4 VA: 0x817FCA4
	private static void .cctor() { }

	// RVA: 0x817FD0C Offset: 0x817BD0C VA: 0x817FD0C
	public void .ctor() { }

	// RVA: 0x817FD14 Offset: 0x817BD14 VA: 0x817FD14
	internal bool <get_ConnectionClose>b__19_0(string l) { }

	// RVA: 0x817FD64 Offset: 0x817BD64 VA: 0x817FD64
	internal bool <get_ExpectContinue>b__29_0(TransferCodingHeaderValue l) { }

	// RVA: 0x817FDBC Offset: 0x817BDBC VA: 0x817FDBC
	internal bool <get_TransferEncodingChunked>b__71_0(TransferCodingHeaderValue l) { }
}

// Namespace: System.Net.Http.Headers
public sealed class HttpRequestHeaders : HttpHeaders // TypeDefIndex: 27073
{
	// Fields
	private Nullable<bool> expectContinue; // 0x20

	// Properties
	public HttpHeaderValueCollection<string> Connection { get; }
	public Nullable<bool> ConnectionClose { get; }
	public Nullable<bool> ExpectContinue { get; }
	public string Host { get; }
	public HttpHeaderValueCollection<TransferCodingHeaderValue> TransferEncoding { get; }
	public Nullable<bool> TransferEncodingChunked { get; }

	// Methods

	// RVA: 0x816F8D4 Offset: 0x816B8D4 VA: 0x816F8D4
	internal void .ctor() { }

	// RVA: 0x816B960 Offset: 0x8167960 VA: 0x816B960
	public HttpHeaderValueCollection<string> get_Connection() { }

	// RVA: 0x816C36C Offset: 0x816836C VA: 0x816C36C
	public Nullable<bool> get_ConnectionClose() { }

	// RVA: 0x816C4F8 Offset: 0x81684F8 VA: 0x816C4F8
	public Nullable<bool> get_ExpectContinue() { }

	// RVA: 0x816C6D8 Offset: 0x81686D8 VA: 0x816C6D8
	public string get_Host() { }

	// RVA: 0x817FC3C Offset: 0x817BC3C VA: 0x817FC3C
	public HttpHeaderValueCollection<TransferCodingHeaderValue> get_TransferEncoding() { }

	// RVA: 0x816EB04 Offset: 0x816AB04 VA: 0x816EB04
	public Nullable<bool> get_TransferEncodingChunked() { }

	// RVA: 0x8171338 Offset: 0x816D338 VA: 0x8171338
	internal void AddHeaders(HttpRequestHeaders headers) { }
}

// Namespace: System.Net.Http.Headers
public sealed class HttpResponseHeaders : HttpHeaders // TypeDefIndex: 27074
{
	// Methods

	// RVA: 0x8176FEC Offset: 0x8172FEC VA: 0x8176FEC
	internal void .ctor() { }
}

// Namespace: 
public enum Token.Type // TypeDefIndex: 27075
{
	// Fields
	public int value__; // 0x0
	public const Token.Type Error = 0;
	public const Token.Type End = 1;
	public const Token.Type Token = 2;
	public const Token.Type QuotedString = 3;
	public const Token.Type SeparatorEqual = 4;
	public const Token.Type SeparatorSemicolon = 5;
	public const Token.Type SeparatorSlash = 6;
	public const Token.Type SeparatorDash = 7;
	public const Token.Type SeparatorComma = 8;
	public const Token.Type OpenParens = 9;
}

// Namespace: System.Net.Http.Headers
internal struct Token // TypeDefIndex: 27076
{
	// Fields
	public static readonly Token Empty; // 0x0
	private readonly Token.Type type; // 0x0
	[CompilerGenerated]
	private int <StartPosition>k__BackingField; // 0x4
	[CompilerGenerated]
	private int <EndPosition>k__BackingField; // 0x8

	// Properties
	public int StartPosition { get; set; }
	public int EndPosition { get; set; }
	public Token.Type Kind { get; }

	// Methods

	// RVA: 0x817828C Offset: 0x817428C VA: 0x817828C
	public void .ctor(Token.Type type, int startPosition, int endPosition) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x817FE14 Offset: 0x817BE14 VA: 0x817FE14
	public int get_StartPosition() { }

	[CompilerGenerated]
	// RVA: 0x817FE1C Offset: 0x817BE1C VA: 0x817FE1C
	private void set_StartPosition(int value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x817FE24 Offset: 0x817BE24 VA: 0x817FE24
	public int get_EndPosition() { }

	[CompilerGenerated]
	// RVA: 0x817FE2C Offset: 0x817BE2C VA: 0x817FE2C
	private void set_EndPosition(int value) { }

	// RVA: 0x817FE34 Offset: 0x817BE34 VA: 0x817FE34
	public Token.Type get_Kind() { }

	// RVA: 0x817FE3C Offset: 0x817BE3C VA: 0x817FE3C
	public static Token.Type op_Implicit(Token token) { }

	// RVA: 0x817FE40 Offset: 0x817BE40 VA: 0x817FE40 Slot: 3
	public override string ToString() { }

	// RVA: 0x817FEA8 Offset: 0x817BEA8 VA: 0x817FEA8
	private static void .cctor() { }
}

// Namespace: System.Net.Http.Headers
internal class Lexer // TypeDefIndex: 27077
{
	// Fields
	private static readonly bool[] token_chars; // 0x0
	private static readonly int last_token_char; // 0x8
	private static readonly string[] dt_formats; // 0x10
	private readonly string s; // 0x10
	private int pos; // 0x18

	// Properties
	public int Position { get; set; }

	// Methods

	// RVA: 0x8177C48 Offset: 0x8173C48 VA: 0x8177C48
	public void .ctor(string stream) { }

	// RVA: 0x817FF20 Offset: 0x817BF20 VA: 0x817FF20
	public int get_Position() { }

	// RVA: 0x817FF28 Offset: 0x817BF28 VA: 0x817FF28
	public void set_Position(int value) { }

	// RVA: 0x81781DC Offset: 0x81741DC VA: 0x81781DC
	public string GetStringValue(Token token) { }

	// RVA: 0x817FF30 Offset: 0x817BF30 VA: 0x817FF30
	public string GetStringValue(Token start, Token end) { }

	// RVA: 0x8179BD8 Offset: 0x8175BD8 VA: 0x8179BD8
	public string GetQuotedStringValue(Token start) { }

	// RVA: 0x8178258 Offset: 0x8174258 VA: 0x8178258
	public string GetRemainingStringValue(int position) { }

	// RVA: 0x817BA3C Offset: 0x8177A3C VA: 0x817BA3C
	public bool IsStarStringValue(Token token) { }

	// RVA: 0x817FFAC Offset: 0x817BFAC VA: 0x817FFAC
	public bool TryGetNumericValue(Token token, out int value) { }

	// RVA: 0x817BAE8 Offset: 0x8177AE8 VA: 0x817BAE8
	public bool TryGetNumericValue(Token token, out long value) { }

	// RVA: 0x8179B10 Offset: 0x8175B10 VA: 0x8179B10
	public Nullable<TimeSpan> TryGetTimeSpanValue(Token token) { }

	// RVA: 0x818004C Offset: 0x817C04C VA: 0x818004C
	public bool TryGetDateValue(Token token, out DateTimeOffset value) { }

	// RVA: 0x818013C Offset: 0x817C13C VA: 0x818013C
	public static bool TryGetDateValue(string text, out DateTimeOffset value) { }

	// RVA: 0x8180218 Offset: 0x817C218 VA: 0x8180218
	public bool TryGetDoubleValue(Token token, out double value) { }

	// RVA: 0x81802B8 Offset: 0x817C2B8 VA: 0x81802B8
	public static bool IsValidToken(string input) { }

	// RVA: 0x8180370 Offset: 0x817C370 VA: 0x8180370
	public static bool IsValidCharacter(char input) { }

	// RVA: 0x817C2B8 Offset: 0x81782B8 VA: 0x817C2B8
	public void EatChar() { }

	// RVA: 0x817C278 Offset: 0x8178278 VA: 0x817C278
	public int PeekChar() { }

	// RVA: 0x8180420 Offset: 0x817C420 VA: 0x8180420
	public bool ScanCommentOptional(out string value, out Token readToken) { }

	// RVA: 0x8177ECC Offset: 0x8173ECC VA: 0x8177ECC
	public Token Scan(bool recognizeDash = False) { }

	// RVA: 0x8180594 Offset: 0x817C594 VA: 0x8180594
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MediaTypeHeaderValue.<>c // TypeDefIndex: 27078
{
	// Fields
	public static readonly MediaTypeHeaderValue.<>c <>9; // 0x0
	public static Predicate<NameValueHeaderValue> <>9__6_0; // 0x8

	// Methods

	// RVA: 0x8181154 Offset: 0x817D154 VA: 0x8181154
	private static void .cctor() { }

	// RVA: 0x81811BC Offset: 0x817D1BC VA: 0x81811BC
	public void .ctor() { }

	// RVA: 0x81811C4 Offset: 0x817D1C4 VA: 0x81811C4
	internal bool <get_CharSet>b__6_0(NameValueHeaderValue l) { }
}

// Namespace: System.Net.Http.Headers
public class MediaTypeHeaderValue : ICloneable // TypeDefIndex: 27079
{
	// Fields
	internal List<NameValueHeaderValue> parameters; // 0x10
	internal string media_type; // 0x18

	// Properties
	public string CharSet { get; set; }
	public string MediaType { set; }
	public ICollection<NameValueHeaderValue> Parameters { get; }

	// Methods

	// RVA: 0x81778BC Offset: 0x81738BC VA: 0x81778BC
	public void .ctor(string mediaType) { }

	// RVA: 0x81808F8 Offset: 0x817C8F8 VA: 0x81808F8
	protected void .ctor(MediaTypeHeaderValue source) { }

	// RVA: 0x8180BEC Offset: 0x817CBEC VA: 0x8180BEC
	internal void .ctor() { }

	// RVA: 0x81762A0 Offset: 0x81722A0 VA: 0x81762A0
	public string get_CharSet() { }

	// RVA: 0x81778E8 Offset: 0x81738E8 VA: 0x81778E8
	public void set_CharSet(string value) { }

	// RVA: 0x818078C Offset: 0x817C78C VA: 0x818078C
	public void set_MediaType(string value) { }

	// RVA: 0x8180B68 Offset: 0x817CB68 VA: 0x8180B68
	public ICollection<NameValueHeaderValue> get_Parameters() { }

	// RVA: 0x8180D94 Offset: 0x817CD94 VA: 0x8180D94 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x8180DEC Offset: 0x817CDEC VA: 0x8180DEC Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x8180EB4 Offset: 0x817CEB4 VA: 0x8180EB4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x8180F30 Offset: 0x817CF30 VA: 0x8180F30 Slot: 3
	public override string ToString() { }

	// RVA: 0x8180F9C Offset: 0x817CF9C VA: 0x8180F9C
	public static bool TryParse(string input, out MediaTypeHeaderValue parsedValue) { }

	// RVA: 0x8180BF4 Offset: 0x817CBF4 VA: 0x8180BF4
	internal static Nullable<Token> TryParseMediaType(Lexer lexer, out string media) { }
}

// Namespace: System.Net.Http.Headers
public sealed class MediaTypeWithQualityHeaderValue : MediaTypeHeaderValue // TypeDefIndex: 27080
{
	// Methods

	// RVA: 0x818121C Offset: 0x817D21C VA: 0x818121C
	private void .ctor() { }

	// RVA: 0x8181224 Offset: 0x817D224 VA: 0x8181224
	private static bool TryParseElement(Lexer lexer, out MediaTypeWithQualityHeaderValue parsedValue, out Token t) { }

	// RVA: 0x81813B8 Offset: 0x817D3B8 VA: 0x81813B8
	internal static bool TryParse(string input, int minimalCount, out List<MediaTypeWithQualityHeaderValue> result) { }
}

// Namespace: System.Net.Http.Headers
public class NameValueHeaderValue : ICloneable // TypeDefIndex: 27081
{
	// Fields
	internal string value; // 0x10
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x18

	// Properties
	public string Name { get; set; }
	public string Value { get; set; }

	// Methods

	// RVA: 0x817A790 Offset: 0x8176790 VA: 0x817A790
	public void .ctor(string name, string value) { }

	// RVA: 0x817AC78 Offset: 0x8176C78 VA: 0x817AC78
	protected internal void .ctor(NameValueHeaderValue source) { }

	// RVA: 0x8181468 Offset: 0x817D468 VA: 0x8181468
	internal void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x8181470 Offset: 0x817D470 VA: 0x8181470
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x8181478 Offset: 0x817D478 VA: 0x8181478
	internal void set_Name(string value) { }

	// RVA: 0x8181480 Offset: 0x817D480 VA: 0x8181480
	public string get_Value() { }

	// RVA: 0x817A620 Offset: 0x8176620 VA: 0x817A620
	public void set_Value(string value) { }

	// RVA: 0x8179C5C Offset: 0x8175C5C VA: 0x8179C5C
	internal static NameValueHeaderValue Create(string name, string value) { }

	// RVA: 0x8181488 Offset: 0x817D488 VA: 0x8181488 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x81814E0 Offset: 0x817D4E0 VA: 0x81814E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x818155C Offset: 0x817D55C VA: 0x818155C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x818163C Offset: 0x817D63C VA: 0x818163C
	internal static bool TryParsePragma(string input, int minimalCount, out List<NameValueHeaderValue> result) { }

	// RVA: 0x817B068 Offset: 0x8177068 VA: 0x817B068
	internal static bool TryParseParameters(Lexer lexer, out List<NameValueHeaderValue> result, out Token t) { }

	// RVA: 0x81816EC Offset: 0x817D6EC VA: 0x81816EC Slot: 3
	public override string ToString() { }

	// RVA: 0x8181760 Offset: 0x817D760 VA: 0x8181760
	private static bool TryParseElement(Lexer lexer, out NameValueHeaderValue parsedValue, out Token t) { }
}

// Namespace: System.Net.Http.Headers
public class NameValueWithParametersHeaderValue : NameValueHeaderValue, ICloneable // TypeDefIndex: 27082
{
	// Fields
	private List<NameValueHeaderValue> parameters; // 0x20

	// Properties
	public ICollection<NameValueHeaderValue> Parameters { get; }

	// Methods

	// RVA: 0x8181918 Offset: 0x817D918 VA: 0x8181918
	protected void .ctor(NameValueWithParametersHeaderValue source) { }

	// RVA: 0x8181B78 Offset: 0x817DB78 VA: 0x8181B78
	private void .ctor() { }

	// RVA: 0x8181AF4 Offset: 0x817DAF4 VA: 0x8181AF4
	public ICollection<NameValueHeaderValue> get_Parameters() { }

	// RVA: 0x8181B80 Offset: 0x817DB80 VA: 0x8181B80 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x8181BD8 Offset: 0x817DBD8 VA: 0x8181BD8 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x8181C98 Offset: 0x817DC98 VA: 0x8181C98 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x8181CF8 Offset: 0x817DCF8 VA: 0x8181CF8 Slot: 3
	public override string ToString() { }

	// RVA: 0x8181D8C Offset: 0x817DD8C VA: 0x8181D8C
	internal static bool TryParse(string input, int minimalCount, out List<NameValueWithParametersHeaderValue> result) { }

	// RVA: 0x8181E3C Offset: 0x817DE3C VA: 0x8181E3C
	private static bool TryParseElement(Lexer lexer, out NameValueWithParametersHeaderValue parsedValue, out Token t) { }
}

// Namespace: 
public static class Parser.Token // TypeDefIndex: 27083
{
	// Methods

	// RVA: 0x81764E0 Offset: 0x81724E0 VA: 0x81764E0
	public static void Check(string s) { }

	// RVA: 0x817F174 Offset: 0x817B174 VA: 0x817F174
	public static bool TryCheck(string s) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Parser.DateTime.<>c // TypeDefIndex: 27084
{
	// Fields
	public static readonly Parser.DateTime.<>c <>9; // 0x0

	// Methods

	// RVA: 0x8182180 Offset: 0x817E180 VA: 0x8182180
	private static void .cctor() { }

	// RVA: 0x81821E8 Offset: 0x817E1E8 VA: 0x81821E8
	public void .ctor() { }

	// RVA: 0x81821F0 Offset: 0x817E1F0 VA: 0x81821F0
	internal string <.cctor>b__2_0(object l) { }
}

// Namespace: 
public static class Parser.DateTime // TypeDefIndex: 27085
{
	// Fields
	public static readonly Func<object, string> ToString; // 0x0

	// Methods

	// RVA: 0x818204C Offset: 0x817E04C VA: 0x818204C
	public static bool TryParse(string input, out DateTimeOffset result) { }

	// RVA: 0x81820B0 Offset: 0x817E0B0 VA: 0x81820B0
	private static void .cctor() { }
}

// Namespace: 
public static class Parser.EmailAddress // TypeDefIndex: 27086
{
	// Methods

	// RVA: 0x81822E0 Offset: 0x817E2E0 VA: 0x81822E0
	public static bool TryParse(string input, out string result) { }
}

// Namespace: 
public static class Parser.Host // TypeDefIndex: 27087
{
	// Methods

	// RVA: 0x81823DC Offset: 0x817E3DC VA: 0x81823DC
	public static bool TryParse(string input, out string result) { }
}

// Namespace: 
public static class Parser.Int // TypeDefIndex: 27088
{
	// Methods

	// RVA: 0x81824B0 Offset: 0x817E4B0 VA: 0x81824B0
	public static bool TryParse(string input, out int result) { }
}

// Namespace: 
public static class Parser.Long // TypeDefIndex: 27089
{
	// Methods

	// RVA: 0x8182528 Offset: 0x817E528 VA: 0x8182528
	public static bool TryParse(string input, out long result) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Parser.MD5.<>c // TypeDefIndex: 27090
{
	// Fields
	public static readonly Parser.MD5.<>c <>9; // 0x0

	// Methods

	// RVA: 0x8182774 Offset: 0x817E774 VA: 0x8182774
	private static void .cctor() { }

	// RVA: 0x81827DC Offset: 0x817E7DC VA: 0x81827DC
	public void .ctor() { }

	// RVA: 0x81827E4 Offset: 0x817E7E4 VA: 0x81827E4
	internal string <.cctor>b__2_0(object l) { }
}

// Namespace: 
public static class Parser.MD5 // TypeDefIndex: 27091
{
	// Fields
	public static readonly Func<object, string> ToString; // 0x0

	// Methods

	// RVA: 0x81825A0 Offset: 0x817E5A0 VA: 0x81825A0
	public static bool TryParse(string input, out byte[] result) { }

	// RVA: 0x81826A4 Offset: 0x817E6A4 VA: 0x81826A4
	private static void .cctor() { }
}

// Namespace: 
public static class Parser.TimeSpanSeconds // TypeDefIndex: 27092
{
	// Methods

	// RVA: 0x8182878 Offset: 0x817E878 VA: 0x8182878
	public static bool TryParse(string input, out TimeSpan result) { }
}

// Namespace: 
public static class Parser.Uri // TypeDefIndex: 27093
{
	// Methods

	// RVA: 0x8182928 Offset: 0x817E928 VA: 0x8182928
	public static bool TryParse(string input, out Uri result) { }
}

// Namespace: System.Net.Http.Headers
internal static class Parser // TypeDefIndex: 27094
{}

// Namespace: System.Net.Http.Headers
public class ProductHeaderValue : ICloneable // TypeDefIndex: 27095
{
	// Fields
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Version>k__BackingField; // 0x18

	// Properties
	public string Name { get; set; }
	public string Version { get; set; }

	// Methods

	// RVA: 0x8182994 Offset: 0x817E994 VA: 0x8182994
	internal void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x818299C Offset: 0x817E99C VA: 0x818299C
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x81829A4 Offset: 0x817E9A4 VA: 0x81829A4
	internal void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x81829AC Offset: 0x817E9AC VA: 0x81829AC
	public string get_Version() { }

	[CompilerGenerated]
	// RVA: 0x81829B4 Offset: 0x817E9B4 VA: 0x81829B4
	internal void set_Version(string value) { }

	// RVA: 0x81829BC Offset: 0x817E9BC VA: 0x81829BC Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x81829C4 Offset: 0x817E9C4 VA: 0x81829C4 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x8182A7C Offset: 0x817EA7C VA: 0x8182A7C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x8182AE0 Offset: 0x817EAE0 VA: 0x8182AE0
	internal static bool TryParse(string input, int minimalCount, out List<ProductHeaderValue> result) { }

	// RVA: 0x8182B90 Offset: 0x817EB90 VA: 0x8182B90
	private static bool TryParseElement(Lexer lexer, out ProductHeaderValue parsedValue, out Token t) { }

	// RVA: 0x8182D30 Offset: 0x817ED30 VA: 0x8182D30 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net.Http.Headers
public class ProductInfoHeaderValue : ICloneable // TypeDefIndex: 27096
{
	// Fields
	[CompilerGenerated]
	private string <Comment>k__BackingField; // 0x10
	[CompilerGenerated]
	private ProductHeaderValue <Product>k__BackingField; // 0x18

	// Properties
	public string Comment { get; set; }
	public ProductHeaderValue Product { get; set; }

	// Methods

	// RVA: 0x8182D8C Offset: 0x817ED8C VA: 0x8182D8C
	public void .ctor(ProductHeaderValue product) { }

	// RVA: 0x8182DF4 Offset: 0x817EDF4 VA: 0x8182DF4
	private void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x8182DFC Offset: 0x817EDFC VA: 0x8182DFC
	public string get_Comment() { }

	[CompilerGenerated]
	// RVA: 0x8182E04 Offset: 0x817EE04 VA: 0x8182E04
	private void set_Comment(string value) { }

	[CompilerGenerated]
	// RVA: 0x8182E0C Offset: 0x817EE0C VA: 0x8182E0C
	public ProductHeaderValue get_Product() { }

	[CompilerGenerated]
	// RVA: 0x8182E14 Offset: 0x817EE14 VA: 0x8182E14
	private void set_Product(ProductHeaderValue value) { }

	// RVA: 0x8182E1C Offset: 0x817EE1C VA: 0x8182E1C Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x8182E24 Offset: 0x817EE24 VA: 0x8182E24 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x8182EE4 Offset: 0x817EEE4 VA: 0x8182EE4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x8182F10 Offset: 0x817EF10 VA: 0x8182F10
	internal static bool TryParse(string input, int minimalCount, out List<ProductInfoHeaderValue> result) { }

	// RVA: 0x81830E8 Offset: 0x817F0E8 VA: 0x81830E8
	private static bool TryParseElement(Lexer lexer, out ProductInfoHeaderValue parsedValue) { }

	// RVA: 0x8183318 Offset: 0x817F318 VA: 0x8183318 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net.Http.Headers
public class RangeConditionHeaderValue : ICloneable // TypeDefIndex: 27097
{
	// Fields
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <Date>k__BackingField; // 0x10
	[CompilerGenerated]
	private EntityTagHeaderValue <EntityTag>k__BackingField; // 0x28

	// Properties
	public Nullable<DateTimeOffset> Date { get; set; }
	public EntityTagHeaderValue EntityTag { get; set; }

	// Methods

	// RVA: 0x8183338 Offset: 0x817F338 VA: 0x8183338
	public void .ctor(DateTimeOffset date) { }

	// RVA: 0x81833C8 Offset: 0x817F3C8 VA: 0x81833C8
	public void .ctor(EntityTagHeaderValue entityTag) { }

	[CompilerGenerated]
	// RVA: 0x8183444 Offset: 0x817F444 VA: 0x8183444
	public Nullable<DateTimeOffset> get_Date() { }

	[CompilerGenerated]
	// RVA: 0x8183458 Offset: 0x817F458 VA: 0x8183458
	private void set_Date(Nullable<DateTimeOffset> value) { }

	[CompilerGenerated]
	// RVA: 0x818346C Offset: 0x817F46C VA: 0x818346C
	public EntityTagHeaderValue get_EntityTag() { }

	[CompilerGenerated]
	// RVA: 0x8183474 Offset: 0x817F474 VA: 0x8183474
	private void set_EntityTag(EntityTagHeaderValue value) { }

	// RVA: 0x818347C Offset: 0x817F47C VA: 0x818347C Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x8183484 Offset: 0x817F484 VA: 0x8183484 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x81835C8 Offset: 0x817F5C8 VA: 0x81835C8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x818364C Offset: 0x817F64C VA: 0x818364C
	public static bool TryParse(string input, out RangeConditionHeaderValue parsedValue) { }

	// RVA: 0x81838C8 Offset: 0x817F8C8 VA: 0x81838C8 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net.Http.Headers
public class RangeHeaderValue : ICloneable // TypeDefIndex: 27098
{
	// Fields
	private List<RangeItemHeaderValue> ranges; // 0x10
	private string unit; // 0x18

	// Properties
	public ICollection<RangeItemHeaderValue> Ranges { get; }
	public string Unit { get; }

	// Methods

	// RVA: 0x81839D8 Offset: 0x817F9D8 VA: 0x81839D8
	public void .ctor() { }

	// RVA: 0x8183A30 Offset: 0x817FA30 VA: 0x8183A30
	private void .ctor(RangeHeaderValue source) { }

	// RVA: 0x8183C08 Offset: 0x817FC08 VA: 0x8183C08
	public ICollection<RangeItemHeaderValue> get_Ranges() { }

	// RVA: 0x8183C8C Offset: 0x817FC8C VA: 0x8183C8C
	public string get_Unit() { }

	// RVA: 0x8183C94 Offset: 0x817FC94 VA: 0x8183C94 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x8183CEC Offset: 0x817FCEC VA: 0x8183CEC Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x8183DB4 Offset: 0x817FDB4 VA: 0x8183DB4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x8183E30 Offset: 0x817FE30 VA: 0x8183E30
	public static bool TryParse(string input, out RangeHeaderValue parsedValue) { }

	// RVA: 0x81844F0 Offset: 0x81804F0 VA: 0x81844F0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net.Http.Headers
public class RangeItemHeaderValue : ICloneable // TypeDefIndex: 27099
{
	// Fields
	[CompilerGenerated]
	private Nullable<long> <From>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<long> <To>k__BackingField; // 0x20

	// Properties
	public Nullable<long> From { get; set; }
	public Nullable<long> To { get; set; }

	// Methods

	// RVA: 0x81843A4 Offset: 0x81803A4 VA: 0x81843A4
	public void .ctor(Nullable<long> from, Nullable<long> to) { }

	[CompilerGenerated]
	// RVA: 0x8184690 Offset: 0x8180690 VA: 0x8184690
	public Nullable<long> get_From() { }

	[CompilerGenerated]
	// RVA: 0x818469C Offset: 0x818069C VA: 0x818469C
	private void set_From(Nullable<long> value) { }

	[CompilerGenerated]
	// RVA: 0x81846A4 Offset: 0x81806A4 VA: 0x81846A4
	public Nullable<long> get_To() { }

	[CompilerGenerated]
	// RVA: 0x81846B0 Offset: 0x81806B0 VA: 0x81846B0
	private void set_To(Nullable<long> value) { }

	// RVA: 0x81846B8 Offset: 0x81806B8 VA: 0x81846B8 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x81846C0 Offset: 0x81806C0 VA: 0x81846C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x81847C4 Offset: 0x81807C4 VA: 0x81847C4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x818483C Offset: 0x818083C VA: 0x818483C Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net.Http.Headers
public class RetryConditionHeaderValue : ICloneable // TypeDefIndex: 27100
{
	// Fields
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <Date>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<TimeSpan> <Delta>k__BackingField; // 0x28

	// Properties
	public Nullable<DateTimeOffset> Date { get; set; }
	public Nullable<TimeSpan> Delta { get; set; }

	// Methods

	// RVA: 0x8184974 Offset: 0x8180974 VA: 0x8184974
	public void .ctor(DateTimeOffset date) { }

	// RVA: 0x8184A04 Offset: 0x8180A04 VA: 0x8184A04
	public void .ctor(TimeSpan delta) { }

	[CompilerGenerated]
	// RVA: 0x8184B00 Offset: 0x8180B00 VA: 0x8184B00
	public Nullable<DateTimeOffset> get_Date() { }

	[CompilerGenerated]
	// RVA: 0x8184B14 Offset: 0x8180B14 VA: 0x8184B14
	private void set_Date(Nullable<DateTimeOffset> value) { }

	[CompilerGenerated]
	// RVA: 0x8184B28 Offset: 0x8180B28 VA: 0x8184B28
	public Nullable<TimeSpan> get_Delta() { }

	[CompilerGenerated]
	// RVA: 0x8184B34 Offset: 0x8180B34 VA: 0x8184B34
	private void set_Delta(Nullable<TimeSpan> value) { }

	// RVA: 0x8184B3C Offset: 0x8180B3C VA: 0x8184B3C Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x8184B44 Offset: 0x8180B44 VA: 0x8184B44 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x8184CE8 Offset: 0x8180CE8 VA: 0x8184CE8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x8184D88 Offset: 0x8180D88 VA: 0x8184D88
	public static bool TryParse(string input, out RetryConditionHeaderValue parsedValue) { }

	// RVA: 0x8184F7C Offset: 0x8180F7C VA: 0x8184F7C Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net.Http.Headers
public class StringWithQualityHeaderValue : ICloneable // TypeDefIndex: 27101
{
	// Fields
	[CompilerGenerated]
	private Nullable<double> <Quality>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Value>k__BackingField; // 0x20

	// Properties
	public Nullable<double> Quality { get; set; }
	public string Value { get; set; }

	// Methods

	// RVA: 0x8185124 Offset: 0x8181124 VA: 0x8185124
	private void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x818512C Offset: 0x818112C VA: 0x818512C
	public Nullable<double> get_Quality() { }

	[CompilerGenerated]
	// RVA: 0x8185138 Offset: 0x8181138 VA: 0x8185138
	private void set_Quality(Nullable<double> value) { }

	[CompilerGenerated]
	// RVA: 0x8185140 Offset: 0x8181140 VA: 0x8185140
	public string get_Value() { }

	[CompilerGenerated]
	// RVA: 0x8185148 Offset: 0x8181148 VA: 0x8185148
	private void set_Value(string value) { }

	// RVA: 0x8185150 Offset: 0x8181150 VA: 0x8185150 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x8185158 Offset: 0x8181158 VA: 0x8185158 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x8185240 Offset: 0x8181240 VA: 0x8185240 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x81852CC Offset: 0x81812CC VA: 0x81852CC
	internal static bool TryParse(string input, int minimalCount, out List<StringWithQualityHeaderValue> result) { }

	// RVA: 0x818537C Offset: 0x818137C VA: 0x818537C
	private static bool TryParseElement(Lexer lexer, out StringWithQualityHeaderValue parsedValue, out Token t) { }

	// RVA: 0x818562C Offset: 0x818162C VA: 0x818562C Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net.Http.Headers
public class TransferCodingHeaderValue : ICloneable // TypeDefIndex: 27102
{
	// Fields
	internal string value; // 0x10
	internal List<NameValueHeaderValue> parameters; // 0x18

	// Properties
	public ICollection<NameValueHeaderValue> Parameters { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x8185738 Offset: 0x8181738 VA: 0x8185738
	protected void .ctor(TransferCodingHeaderValue source) { }

	// RVA: 0x81859EC Offset: 0x81819EC VA: 0x81859EC
	internal void .ctor() { }

	// RVA: 0x8185968 Offset: 0x8181968 VA: 0x8185968
	public ICollection<NameValueHeaderValue> get_Parameters() { }

	// RVA: 0x81859F4 Offset: 0x81819F4 VA: 0x81859F4
	public string get_Value() { }

	// RVA: 0x81859FC Offset: 0x81819FC VA: 0x81859FC Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x8185A54 Offset: 0x8181A54 VA: 0x8185A54 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x8185B1C Offset: 0x8181B1C VA: 0x8185B1C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x8185BA0 Offset: 0x8181BA0 VA: 0x8185BA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x8185BF8 Offset: 0x8181BF8 VA: 0x8185BF8
	internal static bool TryParse(string input, int minimalCount, out List<TransferCodingHeaderValue> result) { }

	// RVA: 0x8185CA8 Offset: 0x8181CA8 VA: 0x8185CA8
	private static bool TryParseElement(Lexer lexer, out TransferCodingHeaderValue parsedValue, out Token t) { }
}

// Namespace: System.Net.Http.Headers
public sealed class TransferCodingWithQualityHeaderValue : TransferCodingHeaderValue // TypeDefIndex: 27103
{
	// Methods

	// RVA: 0x8185E20 Offset: 0x8181E20 VA: 0x8185E20
	private void .ctor() { }

	// RVA: 0x8185E28 Offset: 0x8181E28 VA: 0x8185E28
	internal static bool TryParse(string input, int minimalCount, out List<TransferCodingWithQualityHeaderValue> result) { }

	// RVA: 0x8185ED8 Offset: 0x8181ED8 VA: 0x8185ED8
	private static bool TryParseElement(Lexer lexer, out TransferCodingWithQualityHeaderValue parsedValue, out Token t) { }
}

// Namespace: System.Net.Http.Headers
public class ViaHeaderValue : ICloneable // TypeDefIndex: 27104
{
	// Fields
	[CompilerGenerated]
	private string <Comment>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <ProtocolName>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <ProtocolVersion>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <ReceivedBy>k__BackingField; // 0x28

	// Properties
	public string Comment { get; set; }
	public string ProtocolName { get; set; }
	public string ProtocolVersion { get; set; }
	public string ReceivedBy { get; set; }

	// Methods

	// RVA: 0x8186050 Offset: 0x8182050 VA: 0x8186050
	private void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x8186058 Offset: 0x8182058 VA: 0x8186058
	public string get_Comment() { }

	[CompilerGenerated]
	// RVA: 0x8186060 Offset: 0x8182060 VA: 0x8186060
	private void set_Comment(string value) { }

	[CompilerGenerated]
	// RVA: 0x8186068 Offset: 0x8182068 VA: 0x8186068
	public string get_ProtocolName() { }

	[CompilerGenerated]
	// RVA: 0x8186070 Offset: 0x8182070 VA: 0x8186070
	private void set_ProtocolName(string value) { }

	[CompilerGenerated]
	// RVA: 0x8186078 Offset: 0x8182078 VA: 0x8186078
	public string get_ProtocolVersion() { }

	[CompilerGenerated]
	// RVA: 0x8186080 Offset: 0x8182080 VA: 0x8186080
	private void set_ProtocolVersion(string value) { }

	[CompilerGenerated]
	// RVA: 0x8186088 Offset: 0x8182088 VA: 0x8186088
	public string get_ReceivedBy() { }

	[CompilerGenerated]
	// RVA: 0x8186090 Offset: 0x8182090 VA: 0x8186090
	private void set_ReceivedBy(string value) { }

	// RVA: 0x8186098 Offset: 0x8182098 VA: 0x8186098 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x81860A0 Offset: 0x81820A0 VA: 0x81860A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x8186188 Offset: 0x8182188 VA: 0x8186188 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x8186254 Offset: 0x8182254 VA: 0x8186254
	internal static bool TryParse(string input, int minimalCount, out List<ViaHeaderValue> result) { }

	// RVA: 0x8186304 Offset: 0x8182304 VA: 0x8186304
	private static bool TryParseElement(Lexer lexer, out ViaHeaderValue parsedValue, out Token t) { }

	// RVA: 0x81865E4 Offset: 0x81825E4 VA: 0x81865E4 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net.Http.Headers
public class WarningHeaderValue : ICloneable // TypeDefIndex: 27105
{
	// Fields
	[CompilerGenerated]
	private string <Agent>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <Code>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <Date>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Text>k__BackingField; // 0x38

	// Properties
	public string Agent { get; set; }
	public int Code { get; set; }
	public Nullable<DateTimeOffset> Date { get; set; }
	public string Text { get; set; }

	// Methods

	// RVA: 0x8186750 Offset: 0x8182750 VA: 0x8186750
	private void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x8186758 Offset: 0x8182758 VA: 0x8186758
	public string get_Agent() { }

	[CompilerGenerated]
	// RVA: 0x8186760 Offset: 0x8182760 VA: 0x8186760
	private void set_Agent(string value) { }

	[CompilerGenerated]
	// RVA: 0x8186768 Offset: 0x8182768 VA: 0x8186768
	public int get_Code() { }

	[CompilerGenerated]
	// RVA: 0x8186770 Offset: 0x8182770 VA: 0x8186770
	private void set_Code(int value) { }

	[CompilerGenerated]
	// RVA: 0x8186778 Offset: 0x8182778 VA: 0x8186778
	public Nullable<DateTimeOffset> get_Date() { }

	[CompilerGenerated]
	// RVA: 0x818678C Offset: 0x818278C VA: 0x818678C
	private void set_Date(Nullable<DateTimeOffset> value) { }

	[CompilerGenerated]
	// RVA: 0x81867A0 Offset: 0x81827A0 VA: 0x81867A0
	public string get_Text() { }

	[CompilerGenerated]
	// RVA: 0x81867A8 Offset: 0x81827A8 VA: 0x81867A8
	private void set_Text(string value) { }

	// RVA: 0x81867B0 Offset: 0x81827B0 VA: 0x81867B0
	private static bool IsCodeValid(int code) { }

	// RVA: 0x81867BC Offset: 0x81827BC VA: 0x81867BC Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x81867C4 Offset: 0x81827C4 VA: 0x81867C4 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x818691C Offset: 0x818291C VA: 0x818691C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x81869FC Offset: 0x81829FC VA: 0x81869FC
	internal static bool TryParse(string input, int minimalCount, out List<WarningHeaderValue> result) { }

	// RVA: 0x8186AAC Offset: 0x8182AAC VA: 0x8186AAC
	private static bool TryParseElement(Lexer lexer, out WarningHeaderValue parsedValue, out Token t) { }

	// RVA: 0x8186D94 Offset: 0x8182D94 VA: 0x8186D94 Slot: 3
	public override string ToString() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=127 // TypeDefIndex: 27106
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 27107
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=127 1D59178A3E2B293760F6FE72820F96FEC4071964A5B9E4BB13F7EA51510A4729 /*Metadata offset 0xF4C698*/; // 0x0

	// Methods

	// RVA: 0x818701C Offset: 0x818301C VA: 0x818701C
	internal static uint ComputeStringHash(string s) { }
}

