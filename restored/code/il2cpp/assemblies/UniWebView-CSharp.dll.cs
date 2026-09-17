// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 26529
{}

// Namespace: 
internal class UniWebViewMethodChannel : AndroidJavaProxy // TypeDefIndex: 26530
{
	// Methods

	// RVA: 0x89C8048 Offset: 0x89C4048 VA: 0x89C8048
	public void .ctor() { }

	// RVA: 0x89C80B8 Offset: 0x89C40B8 VA: 0x89C80B8
	private string invokeChannelMethod(string name, string method, string parameters) { }
}

// Namespace: 
public class UniWebViewInterface // TypeDefIndex: 26531
{
	// Fields
	private static readonly AndroidJavaClass plugin; // 0x0
	private static bool correctPlatform; // 0x8

	// Methods

	// RVA: 0x89C8728 Offset: 0x89C4728 VA: 0x89C8728
	private static void .cctor() { }

	// RVA: 0x89C8AA8 Offset: 0x89C4AA8 VA: 0x89C8AA8
	public static void SetLogLevel(int level) { }

	// RVA: 0x89C8BD0 Offset: 0x89C4BD0 VA: 0x89C8BD0
	public static bool IsWebViewSupported() { }

	// RVA: 0x89C8CCC Offset: 0x89C4CCC VA: 0x89C8CCC
	public static void Init(string name, int x, int y, int width, int height) { }

	// RVA: 0x89C8F28 Offset: 0x89C4F28 VA: 0x89C8F28
	public static void Destroy(string name) { }

	// RVA: 0x89C901C Offset: 0x89C501C VA: 0x89C901C
	public static void Load(string name, string url, bool skipEncoding, string readAccessURL) { }

	// RVA: 0x89C9150 Offset: 0x89C5150 VA: 0x89C9150
	public static void LoadHTMLString(string name, string html, string baseUrl, bool skipEncoding) { }

	// RVA: 0x89C92BC Offset: 0x89C52BC VA: 0x89C92BC
	public static void Reload(string name) { }

	// RVA: 0x89C93B0 Offset: 0x89C53B0 VA: 0x89C93B0
	public static void Stop(string name) { }

	// RVA: 0x89C94A4 Offset: 0x89C54A4 VA: 0x89C94A4
	public static string GetUrl(string name) { }

	// RVA: 0x89C95AC Offset: 0x89C55AC VA: 0x89C95AC
	public static void SetFrame(string name, int x, int y, int width, int height) { }

	// RVA: 0x89C9808 Offset: 0x89C5808 VA: 0x89C9808
	public static void SetPosition(string name, int x, int y) { }

	// RVA: 0x89C99BC Offset: 0x89C59BC VA: 0x89C99BC
	public static void SetSize(string name, int width, int height) { }

	// RVA: 0x89C9B70 Offset: 0x89C5B70 VA: 0x89C9B70
	public static bool Show(string name, bool fade, int edge, float duration, bool useAsync, string identifier) { }

	// RVA: 0x89C9F64 Offset: 0x89C5F64 VA: 0x89C9F64
	public static bool Hide(string name, bool fade, int edge, float duration, bool useAsync, string identifier) { }

	// RVA: 0x89CA358 Offset: 0x89C6358 VA: 0x89CA358
	public static bool AnimateTo(string name, int x, int y, int width, int height, float duration, float delay, string identifier) { }

	// RVA: 0x89CA6B8 Offset: 0x89C66B8 VA: 0x89CA6B8
	public static void AddJavaScript(string name, string jsString, string identifier) { }

	// RVA: 0x89CA824 Offset: 0x89C6824 VA: 0x89CA824
	public static void EvaluateJavaScript(string name, string jsString, string identifier) { }

	// RVA: 0x89CA990 Offset: 0x89C6990 VA: 0x89CA990
	public static void AddUrlScheme(string name, string scheme) { }

	// RVA: 0x89CAAC4 Offset: 0x89C6AC4 VA: 0x89CAAC4
	public static void RemoveUrlScheme(string name, string scheme) { }

	// RVA: 0x89CABF8 Offset: 0x89C6BF8 VA: 0x89CABF8
	public static void AddSslExceptionDomain(string name, string domain) { }

	// RVA: 0x89CAD2C Offset: 0x89C6D2C VA: 0x89CAD2C
	public static void RemoveSslExceptionDomain(string name, string domain) { }

	// RVA: 0x89CAE60 Offset: 0x89C6E60 VA: 0x89CAE60
	public static void AddPermissionTrustDomain(string name, string domain) { }

	// RVA: 0x89CAF94 Offset: 0x89C6F94 VA: 0x89CAF94
	public static void RemovePermissionTrustDomain(string name, string domain) { }

	// RVA: 0x89CB0C8 Offset: 0x89C70C8 VA: 0x89CB0C8
	public static void SetHeaderField(string name, string key, string value) { }

	// RVA: 0x89CB234 Offset: 0x89C7234 VA: 0x89CB234
	public static void SetUserAgent(string name, string userAgent) { }

	// RVA: 0x89CB368 Offset: 0x89C7368 VA: 0x89CB368
	public static string GetUserAgent(string name) { }

	// RVA: 0x89CB470 Offset: 0x89C7470 VA: 0x89CB470
	public static void SetAllowAutoPlay(bool flag) { }

	// RVA: 0x89CB5A4 Offset: 0x89C75A4 VA: 0x89CB5A4
	public static void SetAllowJavaScriptOpenWindow(bool flag) { }

	// RVA: 0x89CB6D8 Offset: 0x89C76D8 VA: 0x89CB6D8
	public static void SetAllowFileAccess(string name, bool flag) { }

	// RVA: 0x89CB844 Offset: 0x89C7844 VA: 0x89CB844
	public static void SetAcceptThirdPartyCookies(string name, bool flag) { }

	// RVA: 0x89CB9B0 Offset: 0x89C79B0 VA: 0x89CB9B0
	public static void SetAllowFileAccessFromFileURLs(string name, bool flag) { }

	// RVA: 0x89CBB1C Offset: 0x89C7B1C VA: 0x89CBB1C
	public static void SetAllowUniversalAccessFromFileURLs(bool flag) { }

	// RVA: 0x89CBC50 Offset: 0x89C7C50 VA: 0x89CBC50
	public static void BringContentToFront(string name) { }

	// RVA: 0x89CBD44 Offset: 0x89C7D44 VA: 0x89CBD44
	public static void SetForwardWebConsoleToNativeOutput(bool flag) { }

	// RVA: 0x89CBE78 Offset: 0x89C7E78 VA: 0x89CBE78
	public static void SetEnableKeyboardAvoidance(bool flag) { }

	// RVA: 0x89CBFAC Offset: 0x89C7FAC VA: 0x89CBFAC
	public static void SetJavaScriptEnabled(bool enabled) { }

	// RVA: 0x89CC0E0 Offset: 0x89C80E0 VA: 0x89CC0E0
	public static void CleanCache(string name) { }

	// RVA: 0x89CC1D4 Offset: 0x89C81D4 VA: 0x89CC1D4
	public static void SetCacheMode(string name, int mode) { }

	// RVA: 0x89CC33C Offset: 0x89C833C VA: 0x89CC33C
	public static void ClearCookies() { }

	// RVA: 0x89CC424 Offset: 0x89C8424 VA: 0x89CC424
	public static void SetCookie(string url, string cookie, bool skipEncoding) { }

	// RVA: 0x89CC558 Offset: 0x89C8558 VA: 0x89CC558
	public static string GetCookie(string url, string key, bool skipEncoding) { }

	// RVA: 0x89CC6A0 Offset: 0x89C86A0 VA: 0x89CC6A0
	public static void RemoveCookies(string url, bool skipEncoding) { }

	// RVA: 0x89CC794 Offset: 0x89C8794 VA: 0x89CC794
	public static void RemoveCookie(string url, string key, bool skipEncoding) { }

	// RVA: 0x89CC8C8 Offset: 0x89C88C8 VA: 0x89CC8C8
	public static void ClearHttpAuthUsernamePassword(string host, string realm) { }

	// RVA: 0x89CC9FC Offset: 0x89C89FC VA: 0x89CC9FC
	public static void SetBackgroundColor(string name, float r, float g, float b, float a) { }

	// RVA: 0x89CCC58 Offset: 0x89C8C58 VA: 0x89CCC58
	public static void SetWebViewAlpha(string name, float alpha) { }

	// RVA: 0x89CCDC8 Offset: 0x89C8DC8 VA: 0x89CCDC8
	public static float GetWebViewAlpha(string name) { }

	// RVA: 0x89CCED0 Offset: 0x89C8ED0 VA: 0x89CCED0
	public static void SetShowSpinnerWhileLoading(string name, bool show) { }

	// RVA: 0x89CD03C Offset: 0x89C903C VA: 0x89CD03C
	public static void SetSpinnerText(string name, string text) { }

	// RVA: 0x89CD170 Offset: 0x89C9170 VA: 0x89CD170
	public static void SetAllowUserDismissSpinnerByGesture(string name, bool flag) { }

	// RVA: 0x89CD2DC Offset: 0x89C92DC VA: 0x89CD2DC
	public static void ShowSpinner(string name) { }

	// RVA: 0x89CD3D0 Offset: 0x89C93D0 VA: 0x89CD3D0
	public static void HideSpinner(string name) { }

	// RVA: 0x89CD4C4 Offset: 0x89C94C4 VA: 0x89CD4C4
	public static bool CanGoBack(string name) { }

	// RVA: 0x89CD5CC Offset: 0x89C95CC VA: 0x89CD5CC
	public static bool CanGoForward(string name) { }

	// RVA: 0x89CD6D4 Offset: 0x89C96D4 VA: 0x89CD6D4
	public static void GoBack(string name) { }

	// RVA: 0x89CD7C8 Offset: 0x89C97C8 VA: 0x89CD7C8
	public static void GoForward(string name) { }

	// RVA: 0x89CD8BC Offset: 0x89C98BC VA: 0x89CD8BC
	public static void SetOpenLinksInExternalBrowser(string name, bool flag) { }

	// RVA: 0x89CDA28 Offset: 0x89C9A28 VA: 0x89CDA28
	public static void SetHorizontalScrollBarEnabled(string name, bool enabled) { }

	// RVA: 0x89CDB94 Offset: 0x89C9B94 VA: 0x89CDB94
	public static void SetVerticalScrollBarEnabled(string name, bool enabled) { }

	// RVA: 0x89CDD00 Offset: 0x89C9D00 VA: 0x89CDD00
	public static void SetBouncesEnabled(string name, bool enabled) { }

	// RVA: 0x89CDE6C Offset: 0x89C9E6C VA: 0x89CDE6C
	public static void SetZoomEnabled(string name, bool enabled) { }

	// RVA: 0x89CDFD8 Offset: 0x89C9FD8 VA: 0x89CDFD8
	public static void SetUseWideViewPort(string name, bool use) { }

	// RVA: 0x89CE144 Offset: 0x89CA144 VA: 0x89CE144
	public static void SetLoadWithOverviewMode(string name, bool overview) { }

	// RVA: 0x89CE2B0 Offset: 0x89CA2B0 VA: 0x89CE2B0
	public static void SetImmersiveModeEnabled(string name, bool enabled) { }

	// RVA: 0x89CE41C Offset: 0x89CA41C VA: 0x89CE41C
	public static void SetUserInteractionEnabled(string name, bool enabled) { }

	// RVA: 0x89CE588 Offset: 0x89CA588 VA: 0x89CE588
	public static void SetTransparencyClickingThroughEnabled(string name, bool enabled) { }

	// RVA: 0x89CE6F4 Offset: 0x89CA6F4 VA: 0x89CE6F4
	public static void SetWebContentsDebuggingEnabled(bool enabled) { }

	// RVA: 0x89CE828 Offset: 0x89CA828 VA: 0x89CE828
	public static void SetAllowHTTPAuthPopUpWindow(string name, bool flag) { }

	// RVA: 0x89CE994 Offset: 0x89CA994 VA: 0x89CE994
	public static void Print(string name) { }

	// RVA: 0x89CEA88 Offset: 0x89CAA88 VA: 0x89CEA88
	public static void CaptureSnapshot(string name, string filename) { }

	// RVA: 0x89CEBBC Offset: 0x89CABBC VA: 0x89CEBBC
	public static void ScrollTo(string name, int x, int y, bool animated) { }

	// RVA: 0x89CEDDC Offset: 0x89CADDC VA: 0x89CEDDC
	public static void SetCalloutEnabled(string name, bool flag) { }

	// RVA: 0x89CEF48 Offset: 0x89CAF48 VA: 0x89CEF48
	public static void SetSupportMultipleWindows(string name, bool enabled, bool allowJavaScriptOpening) { }

	// RVA: 0x89CF104 Offset: 0x89CB104 VA: 0x89CF104
	public static void SetDragInteractionEnabled(string name, bool flag) { }

	// RVA: 0x89CF270 Offset: 0x89CB270 VA: 0x89CF270
	public static void SetDefaultFontSize(string name, int size) { }

	// RVA: 0x89CF3D8 Offset: 0x89CB3D8 VA: 0x89CF3D8
	public static void SetTextZoom(string name, int textZoom) { }

	// RVA: 0x89CF540 Offset: 0x89CB540 VA: 0x89CF540
	public static float NativeScreenWidth() { }

	// RVA: 0x89CF63C Offset: 0x89CB63C VA: 0x89CF63C
	public static float NativeScreenHeight() { }

	// RVA: 0x89CF738 Offset: 0x89CB738 VA: 0x89CF738
	public static void SetDownloadEventForContextMenuEnabled(string name, bool enabled) { }

	// RVA: 0x89CF8A4 Offset: 0x89CB8A4 VA: 0x89CF8A4
	public static void SetAllowUserEditFileNameBeforeDownloading(string name, bool allowed) { }

	// RVA: 0x89CFA10 Offset: 0x89CBA10 VA: 0x89CFA10
	public static bool IsSafeBrowsingSupported() { }

	// RVA: 0x89CFB0C Offset: 0x89CBB0C VA: 0x89CFB0C
	public static void SafeBrowsingInit(string name, string url) { }

	// RVA: 0x89CFC40 Offset: 0x89CBC40 VA: 0x89CFC40
	public static void SafeBrowsingSetToolbarColor(string name, float r, float g, float b) { }

	// RVA: 0x89CFE50 Offset: 0x89CBE50 VA: 0x89CFE50
	public static void SafeBrowsingShow(string name) { }

	// RVA: 0x89CFF44 Offset: 0x89CBF44 VA: 0x89CFF44
	public static bool IsAuthenticationIsSupported() { }

	// RVA: 0x89D0040 Offset: 0x89CC040 VA: 0x89D0040
	public static void AuthenticationInit(string name, string url, string scheme) { }

	// RVA: 0x89D01AC Offset: 0x89CC1AC VA: 0x89D01AC
	public static void AuthenticationStart(string name) { }

	// RVA: 0x89D02A0 Offset: 0x89CC2A0 VA: 0x89D02A0
	public static void AuthenticationSetPrivateMode(string name, bool enabled) { }

	// RVA: 0x89D040C Offset: 0x89CC40C VA: 0x89D040C
	public static void SetShowEmbeddedToolbar(string name, bool show) { }

	// RVA: 0x89D0578 Offset: 0x89CC578 VA: 0x89D0578
	public static void SetEmbeddedToolbarOnTop(string name, bool top) { }

	// RVA: 0x89D06E4 Offset: 0x89CC6E4 VA: 0x89D06E4
	public static void SetEmbeddedToolbarDoneButtonText(string name, string text) { }

	// RVA: 0x89D0818 Offset: 0x89CC818 VA: 0x89D0818
	public static void SetEmbeddedToolbarGoBackButtonText(string name, string text) { }

	// RVA: 0x89D094C Offset: 0x89CC94C VA: 0x89D094C
	public static void SetEmbeddedToolbarGoForwardButtonText(string name, string text) { }

	// RVA: 0x89D0A80 Offset: 0x89CCA80 VA: 0x89D0A80
	public static void SetEmbeddedToolbarTitleText(string name, string text) { }

	// RVA: 0x89D0BB4 Offset: 0x89CCBB4 VA: 0x89D0BB4
	public static void SetEmbeddedToolbarBackgroundColor(string name, Color color) { }

	// RVA: 0x89D0E10 Offset: 0x89CCE10 VA: 0x89D0E10
	public static void SetEmbeddedToolbarButtonTextColor(string name, Color color) { }

	// RVA: 0x89D106C Offset: 0x89CD06C VA: 0x89D106C
	public static void SetEmbeddedToolbarTitleTextColor(string name, Color color) { }

	// RVA: 0x89D12C8 Offset: 0x89CD2C8 VA: 0x89D12C8
	public static void SetEmeddedToolbarNavigationButtonsShow(string name, bool show) { }

	// RVA: 0x89D1434 Offset: 0x89CD434 VA: 0x89D1434
	public static void StartSnapshotForRendering(string name, string identifier) { }

	// RVA: 0x89D1568 Offset: 0x89CD568 VA: 0x89D1568
	public static void StopSnapshotForRendering(string name) { }

	// RVA: 0x89D165C Offset: 0x89CD65C VA: 0x89D165C
	public static byte[] GetRenderedData(string name, int x, int y, int width, int height) { }

	// RVA: 0x89C89F8 Offset: 0x89C49F8 VA: 0x89C89F8
	public static void CheckPlatform() { }

	// RVA: 0x89D1940 Offset: 0x89CD940 VA: 0x89D1940
	public void .ctor() { }
}

// Namespace: 
public class UniWebViewAndroidStaticListener : MonoBehaviour // TypeDefIndex: 26532
{
	// Methods

	// RVA: 0x89D1948 Offset: 0x89CD948 VA: 0x89D1948
	private void Awake() { }

	// RVA: 0x89D19B4 Offset: 0x89CD9B4 VA: 0x89D19B4
	private void OnJavaMessage(string message) { }

	// RVA: 0x89D1DD0 Offset: 0x89CDDD0 VA: 0x89D1DD0
	public void .ctor() { }
}

// Namespace: 
public sealed class UniWebView.PageStartedDelegate : MulticastDelegate // TypeDefIndex: 26533
{
	// Methods

	// RVA: 0x89D7DE0 Offset: 0x89D3DE0 VA: 0x89D7DE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89D7EEC Offset: 0x89D3EEC VA: 0x89D7EEC Slot: 13
	public virtual void Invoke(UniWebView webView, string url) { }

	// RVA: 0x89D7F00 Offset: 0x89D3F00 VA: 0x89D7F00 Slot: 14
	public virtual IAsyncResult BeginInvoke(UniWebView webView, string url, AsyncCallback callback, object object) { }

	// RVA: 0x89D7F28 Offset: 0x89D3F28 VA: 0x89D7F28 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class UniWebView.PageFinishedDelegate : MulticastDelegate // TypeDefIndex: 26534
{
	// Methods

	// RVA: 0x89D7F34 Offset: 0x89D3F34 VA: 0x89D7F34
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89D8040 Offset: 0x89D4040 VA: 0x89D8040 Slot: 13
	public virtual void Invoke(UniWebView webView, int statusCode, string url) { }

	// RVA: 0x89D8054 Offset: 0x89D4054 VA: 0x89D8054 Slot: 14
	public virtual IAsyncResult BeginInvoke(UniWebView webView, int statusCode, string url, AsyncCallback callback, object object) { }

	// RVA: 0x89D80EC Offset: 0x89D40EC VA: 0x89D80EC Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[Obsolete("PageErrorReceivedDelegate is deprecated. Use `LoadingErrorReceivedDelegate` instead.", False)]
public sealed class UniWebView.PageErrorReceivedDelegate : MulticastDelegate // TypeDefIndex: 26535
{
	// Methods

	// RVA: 0x89D80F8 Offset: 0x89D40F8 VA: 0x89D80F8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89D8204 Offset: 0x89D4204 VA: 0x89D8204 Slot: 13
	public virtual void Invoke(UniWebView webView, int errorCode, string errorMessage) { }

	// RVA: 0x89D8218 Offset: 0x89D4218 VA: 0x89D8218 Slot: 14
	public virtual IAsyncResult BeginInvoke(UniWebView webView, int errorCode, string errorMessage, AsyncCallback callback, object object) { }

	// RVA: 0x89D82B0 Offset: 0x89D42B0 VA: 0x89D82B0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class UniWebView.LoadingErrorReceivedDelegate : MulticastDelegate // TypeDefIndex: 26536
{
	// Methods

	// RVA: 0x89D82BC Offset: 0x89D42BC VA: 0x89D82BC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89D83C8 Offset: 0x89D43C8 VA: 0x89D83C8 Slot: 13
	public virtual void Invoke(UniWebView webView, int errorCode, string errorMessage, UniWebViewNativeResultPayload payload) { }

	// RVA: 0x89D83DC Offset: 0x89D43DC VA: 0x89D83DC Slot: 14
	public virtual IAsyncResult BeginInvoke(UniWebView webView, int errorCode, string errorMessage, UniWebViewNativeResultPayload payload, AsyncCallback callback, object object) { }

	// RVA: 0x89D8488 Offset: 0x89D4488 VA: 0x89D8488 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class UniWebView.PageProgressChangedDelegate : MulticastDelegate // TypeDefIndex: 26537
{
	// Methods

	// RVA: 0x89D8494 Offset: 0x89D4494 VA: 0x89D8494
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89D85A0 Offset: 0x89D45A0 VA: 0x89D85A0 Slot: 13
	public virtual void Invoke(UniWebView webView, float progress) { }

	// RVA: 0x89D85B4 Offset: 0x89D45B4 VA: 0x89D85B4 Slot: 14
	public virtual IAsyncResult BeginInvoke(UniWebView webView, float progress, AsyncCallback callback, object object) { }

	// RVA: 0x89D8648 Offset: 0x89D4648 VA: 0x89D8648 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class UniWebView.MessageReceivedDelegate : MulticastDelegate // TypeDefIndex: 26538
{
	// Methods

	// RVA: 0x89D8654 Offset: 0x89D4654 VA: 0x89D8654
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89D8760 Offset: 0x89D4760 VA: 0x89D8760 Slot: 13
	public virtual void Invoke(UniWebView webView, UniWebViewMessage message) { }

	// RVA: 0x89D8794 Offset: 0x89D4794 VA: 0x89D8794 Slot: 14
	public virtual IAsyncResult BeginInvoke(UniWebView webView, UniWebViewMessage message, AsyncCallback callback, object object) { }

	// RVA: 0x89D8828 Offset: 0x89D4828 VA: 0x89D8828 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class UniWebView.ShouldCloseDelegate : MulticastDelegate // TypeDefIndex: 26539
{
	// Methods

	// RVA: 0x89D8834 Offset: 0x89D4834 VA: 0x89D8834
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89D893C Offset: 0x89D493C VA: 0x89D893C Slot: 13
	public virtual bool Invoke(UniWebView webView) { }

	// RVA: 0x89D8950 Offset: 0x89D4950 VA: 0x89D8950 Slot: 14
	public virtual IAsyncResult BeginInvoke(UniWebView webView, AsyncCallback callback, object object) { }

	// RVA: 0x89D8970 Offset: 0x89D4970 VA: 0x89D8970 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class UniWebView.OrientationChangedDelegate : MulticastDelegate // TypeDefIndex: 26540
{
	// Methods

	// RVA: 0x89D8998 Offset: 0x89D4998 VA: 0x89D8998
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89D8AA4 Offset: 0x89D4AA4 VA: 0x89D8AA4 Slot: 13
	public virtual void Invoke(UniWebView webView, ScreenOrientation orientation) { }

	// RVA: 0x89D8AB8 Offset: 0x89D4AB8 VA: 0x89D8AB8 Slot: 14
	public virtual IAsyncResult BeginInvoke(UniWebView webView, ScreenOrientation orientation, AsyncCallback callback, object object) { }

	// RVA: 0x89D8B4C Offset: 0x89D4B4C VA: 0x89D8B4C Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class UniWebView.OnWebContentProcessTerminatedDelegate : MulticastDelegate // TypeDefIndex: 26541
{
	// Methods

	// RVA: 0x89D8B58 Offset: 0x89D4B58 VA: 0x89D8B58
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89D8C60 Offset: 0x89D4C60 VA: 0x89D8C60 Slot: 13
	public virtual void Invoke(UniWebView webView) { }

	// RVA: 0x89D8C74 Offset: 0x89D4C74 VA: 0x89D8C74 Slot: 14
	public virtual IAsyncResult BeginInvoke(UniWebView webView, AsyncCallback callback, object object) { }

	// RVA: 0x89D8C94 Offset: 0x89D4C94 VA: 0x89D8C94 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class UniWebView.FileDownloadStarted : MulticastDelegate // TypeDefIndex: 26542
{
	// Methods

	// RVA: 0x89D8CA0 Offset: 0x89D4CA0 VA: 0x89D8CA0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89D8DAC Offset: 0x89D4DAC VA: 0x89D8DAC Slot: 13
	public virtual void Invoke(UniWebView webView, string remoteUrl, string fileName) { }

	// RVA: 0x89D8DC0 Offset: 0x89D4DC0 VA: 0x89D8DC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(UniWebView webView, string remoteUrl, string fileName, AsyncCallback callback, object object) { }

	// RVA: 0x89D8DEC Offset: 0x89D4DEC VA: 0x89D8DEC Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class UniWebView.FileDownloadFinished : MulticastDelegate // TypeDefIndex: 26543
{
	// Methods

	// RVA: 0x89D8DF8 Offset: 0x89D4DF8 VA: 0x89D8DF8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89D8F04 Offset: 0x89D4F04 VA: 0x89D8F04 Slot: 13
	public virtual void Invoke(UniWebView webView, int errorCode, string remoteUrl, string diskPath) { }

	// RVA: 0x89D8F18 Offset: 0x89D4F18 VA: 0x89D8F18 Slot: 14
	public virtual IAsyncResult BeginInvoke(UniWebView webView, int errorCode, string remoteUrl, string diskPath, AsyncCallback callback, object object) { }

	// RVA: 0x89D8FC4 Offset: 0x89D4FC4 VA: 0x89D8FC4 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class UniWebView.CaptureSnapshotFinished : MulticastDelegate // TypeDefIndex: 26544
{
	// Methods

	// RVA: 0x89D8FD0 Offset: 0x89D4FD0 VA: 0x89D8FD0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89D90DC Offset: 0x89D50DC VA: 0x89D90DC Slot: 13
	public virtual void Invoke(UniWebView webView, int errorCode, string diskPath) { }

	// RVA: 0x89D90F0 Offset: 0x89D50F0 VA: 0x89D90F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(UniWebView webView, int errorCode, string diskPath, AsyncCallback callback, object object) { }

	// RVA: 0x89D9188 Offset: 0x89D5188 VA: 0x89D9188 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class UniWebView.MultipleWindowOpenedDelegate : MulticastDelegate // TypeDefIndex: 26545
{
	// Methods

	// RVA: 0x89D9194 Offset: 0x89D5194 VA: 0x89D9194
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89D92A0 Offset: 0x89D52A0 VA: 0x89D92A0 Slot: 13
	public virtual void Invoke(UniWebView webView, string multipleWindowId) { }

	// RVA: 0x89D92B4 Offset: 0x89D52B4 VA: 0x89D92B4 Slot: 14
	public virtual IAsyncResult BeginInvoke(UniWebView webView, string multipleWindowId, AsyncCallback callback, object object) { }

	// RVA: 0x89D92DC Offset: 0x89D52DC VA: 0x89D92DC Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class UniWebView.MultipleWindowClosedDelegate : MulticastDelegate // TypeDefIndex: 26546
{
	// Methods

	// RVA: 0x89D92E8 Offset: 0x89D52E8 VA: 0x89D92E8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89D93F4 Offset: 0x89D53F4 VA: 0x89D93F4 Slot: 13
	public virtual void Invoke(UniWebView webView, string multipleWindowId) { }

	// RVA: 0x89D9408 Offset: 0x89D5408 VA: 0x89D9408 Slot: 14
	public virtual IAsyncResult BeginInvoke(UniWebView webView, string multipleWindowId, AsyncCallback callback, object object) { }

	// RVA: 0x89D9430 Offset: 0x89D5430 VA: 0x89D9430 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[Obsolete("KeyCodeReceivedDelegate is deprecated. Now UniWebView never intercepts device key code events. Check `Input.GetKeyUp` instead.", False)]
public sealed class UniWebView.KeyCodeReceivedDelegate : MulticastDelegate // TypeDefIndex: 26547
{
	// Methods

	// RVA: 0x89D943C Offset: 0x89D543C VA: 0x89D943C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89D9548 Offset: 0x89D5548 VA: 0x89D9548 Slot: 13
	public virtual void Invoke(UniWebView webView, int keyCode) { }

	// RVA: 0x89D955C Offset: 0x89D555C VA: 0x89D955C Slot: 14
	public virtual IAsyncResult BeginInvoke(UniWebView webView, int keyCode, AsyncCallback callback, object object) { }

	// RVA: 0x89D95F0 Offset: 0x89D55F0 VA: 0x89D95F0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UniWebView.<>c__DisplayClass175_0 // TypeDefIndex: 26548
{
	// Fields
	public Action<string> handler; // 0x10

	// Methods

	// RVA: 0x89D5A4C Offset: 0x89D1A4C VA: 0x89D5A4C
	public void .ctor() { }

	// RVA: 0x89D95FC Offset: 0x89D55FC VA: 0x89D95FC
	internal void <GetHTMLContent>b__0(UniWebViewNativeResultPayload payload) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UniWebView.<>c__DisplayClass194_0 // TypeDefIndex: 26549
{
	// Fields
	public UniWebView <>4__this; // 0x10
	public Nullable<Rect> rect; // 0x18
	public Action<Texture2D> onStarted; // 0x30

	// Methods

	// RVA: 0x89D6128 Offset: 0x89D2128 VA: 0x89D6128
	public void .ctor() { }

	// RVA: 0x89D9630 Offset: 0x89D5630 VA: 0x89D9630
	internal void <StartSnapshotForRendering>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UniWebView.<>c__DisplayClass198_0 // TypeDefIndex: 26550
{
	// Fields
	public Func<UniWebViewChannelMethodHandleRequest, bool> handler; // 0x10

	// Methods

	// RVA: 0x89D646C Offset: 0x89D246C VA: 0x89D646C
	public void .ctor() { }

	// RVA: 0x89D9694 Offset: 0x89D5694 VA: 0x89D9694
	internal object <RegisterShouldHandleRequest>g__Func|0(object obj) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UniWebView.<>c__DisplayClass200_0 // TypeDefIndex: 26551
{
	// Fields
	public Func<UniWebViewChannelMethodMediaCapturePermission, UniWebViewMediaCapturePermissionDecision> handler; // 0x10

	// Methods

	// RVA: 0x89D6890 Offset: 0x89D2890 VA: 0x89D6890
	public void .ctor() { }

	// RVA: 0x89D9764 Offset: 0x89D5764 VA: 0x89D9764
	internal object <RegisterOnRequestMediaCapturePermission>g__Func|0(object obj) { }
}

// Namespace: 
public class UniWebView : MonoBehaviour // TypeDefIndex: 26552
{
	// Fields
	[CompilerGenerated]
	private UniWebView.PageStartedDelegate OnPageStarted; // 0x20
	[CompilerGenerated]
	private UniWebView.PageFinishedDelegate OnPageFinished; // 0x28
	[CompilerGenerated]
	private UniWebView.PageErrorReceivedDelegate OnPageErrorReceived; // 0x30
	[CompilerGenerated]
	private UniWebView.LoadingErrorReceivedDelegate OnLoadingErrorReceived; // 0x38
	[CompilerGenerated]
	private UniWebView.PageProgressChangedDelegate OnPageProgressChanged; // 0x40
	[CompilerGenerated]
	private UniWebView.MessageReceivedDelegate OnMessageReceived; // 0x48
	[CompilerGenerated]
	private UniWebView.ShouldCloseDelegate OnShouldClose; // 0x50
	[CompilerGenerated]
	private UniWebView.OrientationChangedDelegate OnOrientationChanged; // 0x58
	[CompilerGenerated]
	private UniWebView.OnWebContentProcessTerminatedDelegate OnWebContentProcessTerminated; // 0x60
	[CompilerGenerated]
	private UniWebView.FileDownloadStarted OnFileDownloadStarted; // 0x68
	[CompilerGenerated]
	private UniWebView.FileDownloadFinished OnFileDownloadFinished; // 0x70
	[CompilerGenerated]
	private UniWebView.CaptureSnapshotFinished OnCaptureSnapshotFinished; // 0x78
	[CompilerGenerated]
	private UniWebView.MultipleWindowOpenedDelegate OnMultipleWindowOpened; // 0x80
	[CompilerGenerated]
	private UniWebView.MultipleWindowClosedDelegate OnMultipleWindowClosed; // 0x88
	private static readonly Rect snapshotFullViewRect; // 0x0
	private string id; // 0x90
	private UniWebViewNativeListener listener; // 0x98
	[CompilerGenerated]
	private UniWebViewEmbeddedToolbar <EmbeddedToolbar>k__BackingField; // 0xA0
	private ScreenOrientation currentOrientation; // 0xA8
	[SerializeField]
	private string urlOnStart; // 0xB0
	[SerializeField]
	private bool showOnStart; // 0xB8
	[SerializeField]
	private bool fullScreen; // 0xB9
	[Obsolete("Use Toolbar is deprecated. Use the embedded toolbar instead.", False)]
	[SerializeField]
	private bool useToolbar; // 0xBA
	[Obsolete("Use Toolbar is deprecated. Use the embedded toolbar instead.", False)]
	[SerializeField]
	private UniWebViewToolbarPosition toolbarPosition; // 0xBC
	[SerializeField]
	private bool useEmbeddedToolbar; // 0xC0
	[SerializeField]
	private UniWebViewToolbarPosition embeddedToolbarPosition; // 0xC4
	private Dictionary<string, Action> actions; // 0xC8
	private Dictionary<string, Action<UniWebViewNativeResultPayload>> payloadActions; // 0xD0
	[SerializeField]
	private Rect frame; // 0xD8
	[SerializeField]
	private RectTransform referenceRectTransform; // 0xE8
	private bool started; // 0xF0
	private bool backButtonEnabled; // 0xF1
	[CompilerGenerated]
	private bool <RestoreViewHierarchyOnResume>k__BackingField; // 0xF2
	private Color backgroundColor; // 0xF4
	[CompilerGenerated]
	private UniWebView.KeyCodeReceivedDelegate OnKeyCodeReceived; // 0x108

	// Properties
	public UniWebViewEmbeddedToolbar EmbeddedToolbar { get; set; }
	public Rect Frame { get; set; }
	public RectTransform ReferenceRectTransform { get; set; }
	public string Url { get; }
	public static bool IsWebViewSupported { get; }
	public bool RestoreViewHierarchyOnResume { get; set; }
	public bool CanGoBack { get; }
	public bool CanGoForward { get; }
	public Color BackgroundColor { get; set; }
	public float Alpha { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x89D1DD8 Offset: 0x89CDDD8 VA: 0x89D1DD8
	public void add_OnPageStarted(UniWebView.PageStartedDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x89D1E74 Offset: 0x89CDE74 VA: 0x89D1E74
	public void remove_OnPageStarted(UniWebView.PageStartedDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x89D1F10 Offset: 0x89CDF10 VA: 0x89D1F10
	public void add_OnPageFinished(UniWebView.PageFinishedDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x89D1FAC Offset: 0x89CDFAC VA: 0x89D1FAC
	public void remove_OnPageFinished(UniWebView.PageFinishedDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x89D2048 Offset: 0x89CE048 VA: 0x89D2048
	public void add_OnPageErrorReceived(UniWebView.PageErrorReceivedDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x89D20E4 Offset: 0x89CE0E4 VA: 0x89D20E4
	public void remove_OnPageErrorReceived(UniWebView.PageErrorReceivedDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x89D2180 Offset: 0x89CE180 VA: 0x89D2180
	public void add_OnLoadingErrorReceived(UniWebView.LoadingErrorReceivedDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x89D221C Offset: 0x89CE21C VA: 0x89D221C
	public void remove_OnLoadingErrorReceived(UniWebView.LoadingErrorReceivedDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x89D22B8 Offset: 0x89CE2B8 VA: 0x89D22B8
	public void add_OnPageProgressChanged(UniWebView.PageProgressChangedDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x89D2354 Offset: 0x89CE354 VA: 0x89D2354
	public void remove_OnPageProgressChanged(UniWebView.PageProgressChangedDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x89D23F0 Offset: 0x89CE3F0 VA: 0x89D23F0
	public void add_OnMessageReceived(UniWebView.MessageReceivedDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x89D248C Offset: 0x89CE48C VA: 0x89D248C
	public void remove_OnMessageReceived(UniWebView.MessageReceivedDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x89D2528 Offset: 0x89CE528 VA: 0x89D2528
	public void add_OnShouldClose(UniWebView.ShouldCloseDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x89D25C4 Offset: 0x89CE5C4 VA: 0x89D25C4
	public void remove_OnShouldClose(UniWebView.ShouldCloseDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x89D2660 Offset: 0x89CE660 VA: 0x89D2660
	public void add_OnOrientationChanged(UniWebView.OrientationChangedDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x89D26FC Offset: 0x89CE6FC VA: 0x89D26FC
	public void remove_OnOrientationChanged(UniWebView.OrientationChangedDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x89D2798 Offset: 0x89CE798 VA: 0x89D2798
	public void add_OnWebContentProcessTerminated(UniWebView.OnWebContentProcessTerminatedDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x89D2834 Offset: 0x89CE834 VA: 0x89D2834
	public void remove_OnWebContentProcessTerminated(UniWebView.OnWebContentProcessTerminatedDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x89D28D0 Offset: 0x89CE8D0 VA: 0x89D28D0
	public void add_OnFileDownloadStarted(UniWebView.FileDownloadStarted value) { }

	[CompilerGenerated]
	// RVA: 0x89D296C Offset: 0x89CE96C VA: 0x89D296C
	public void remove_OnFileDownloadStarted(UniWebView.FileDownloadStarted value) { }

	[CompilerGenerated]
	// RVA: 0x89D2A08 Offset: 0x89CEA08 VA: 0x89D2A08
	public void add_OnFileDownloadFinished(UniWebView.FileDownloadFinished value) { }

	[CompilerGenerated]
	// RVA: 0x89D2AA4 Offset: 0x89CEAA4 VA: 0x89D2AA4
	public void remove_OnFileDownloadFinished(UniWebView.FileDownloadFinished value) { }

	[CompilerGenerated]
	// RVA: 0x89D2B40 Offset: 0x89CEB40 VA: 0x89D2B40
	public void add_OnCaptureSnapshotFinished(UniWebView.CaptureSnapshotFinished value) { }

	[CompilerGenerated]
	// RVA: 0x89D2BDC Offset: 0x89CEBDC VA: 0x89D2BDC
	public void remove_OnCaptureSnapshotFinished(UniWebView.CaptureSnapshotFinished value) { }

	[CompilerGenerated]
	// RVA: 0x89D2C78 Offset: 0x89CEC78 VA: 0x89D2C78
	public void add_OnMultipleWindowOpened(UniWebView.MultipleWindowOpenedDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x89D2D14 Offset: 0x89CED14 VA: 0x89D2D14
	public void remove_OnMultipleWindowOpened(UniWebView.MultipleWindowOpenedDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x89D2DB0 Offset: 0x89CEDB0 VA: 0x89D2DB0
	public void add_OnMultipleWindowClosed(UniWebView.MultipleWindowClosedDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x89D2E4C Offset: 0x89CEE4C VA: 0x89D2E4C
	public void remove_OnMultipleWindowClosed(UniWebView.MultipleWindowClosedDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x89D2EE8 Offset: 0x89CEEE8 VA: 0x89D2EE8
	public UniWebViewEmbeddedToolbar get_EmbeddedToolbar() { }

	[CompilerGenerated]
	// RVA: 0x89D2EF0 Offset: 0x89CEEF0 VA: 0x89D2EF0
	private void set_EmbeddedToolbar(UniWebViewEmbeddedToolbar value) { }

	// RVA: 0x89D2EF8 Offset: 0x89CEEF8 VA: 0x89D2EF8
	public Rect get_Frame() { }

	// RVA: 0x89D2F04 Offset: 0x89CEF04 VA: 0x89D2F04
	public void set_Frame(Rect value) { }

	// RVA: 0x89D2FE8 Offset: 0x89CEFE8 VA: 0x89D2FE8
	public RectTransform get_ReferenceRectTransform() { }

	// RVA: 0x89D2FF0 Offset: 0x89CEFF0 VA: 0x89D2FF0
	public void set_ReferenceRectTransform(RectTransform value) { }

	// RVA: 0x89D300C Offset: 0x89CF00C VA: 0x89D300C
	public string get_Url() { }

	// RVA: 0x89D2F10 Offset: 0x89CEF10 VA: 0x89D2F10
	public void UpdateFrame() { }

	// RVA: 0x89D3098 Offset: 0x89CF098 VA: 0x89D3098
	private Rect NextFrameRect() { }

	// RVA: 0x89D33DC Offset: 0x89CF3DC VA: 0x89D33DC
	private void Awake() { }

	// RVA: 0x89D36EC Offset: 0x89CF6EC VA: 0x89D36EC
	private void Start() { }

	// RVA: 0x89D394C Offset: 0x89CF94C VA: 0x89D394C
	private void Update() { }

	// RVA: 0x89D3BC0 Offset: 0x89CFBC0 VA: 0x89D3BC0
	private void OnEnable() { }

	// RVA: 0x89D3D1C Offset: 0x89CFD1C VA: 0x89D3D1C
	private void OnDisable() { }

	// RVA: 0x89D3E78 Offset: 0x89CFE78 VA: 0x89D3E78
	public static bool get_IsWebViewSupported() { }

	[CompilerGenerated]
	// RVA: 0x89D3EC4 Offset: 0x89CFEC4 VA: 0x89D3EC4
	public bool get_RestoreViewHierarchyOnResume() { }

	[CompilerGenerated]
	// RVA: 0x89D3ECC Offset: 0x89CFECC VA: 0x89D3ECC
	public void set_RestoreViewHierarchyOnResume(bool value) { }

	// RVA: 0x89D38D4 Offset: 0x89CF8D4 VA: 0x89D38D4
	public void Load(string url, bool skipEncoding = False, string readAccessURL) { }

	// RVA: 0x89D3ED8 Offset: 0x89CFED8 VA: 0x89D3ED8
	public void LoadHTMLString(string htmlString, string baseUrl, bool skipEncoding = False) { }

	// RVA: 0x89D3F60 Offset: 0x89CFF60 VA: 0x89D3F60
	public void Reload() { }

	// RVA: 0x89D3FCC Offset: 0x89CFFCC VA: 0x89D3FCC
	public void Stop() { }

	// RVA: 0x89D3A64 Offset: 0x89CFA64 VA: 0x89D3A64
	public bool get_CanGoBack() { }

	// RVA: 0x89D4038 Offset: 0x89D0038 VA: 0x89D4038
	public bool get_CanGoForward() { }

	// RVA: 0x89D3AD0 Offset: 0x89CFAD0 VA: 0x89D3AD0
	public void GoBack() { }

	// RVA: 0x89D40A4 Offset: 0x89D00A4 VA: 0x89D40A4
	public void GoForward() { }

	// RVA: 0x89D4110 Offset: 0x89D0110 VA: 0x89D4110
	public void SetOpenLinksInExternalBrowser(bool flag) { }

	// RVA: 0x89D37DC Offset: 0x89CF7DC VA: 0x89D37DC
	public bool Show(bool fade = False, UniWebViewTransitionEdge edge = 0, float duration = 0.4, Action completionHandler) { }

	// RVA: 0x89D3BE8 Offset: 0x89CFBE8 VA: 0x89D3BE8
	public bool _Show(bool fade = False, UniWebViewTransitionEdge edge = 0, float duration = 0.4, bool useAsync = False, Action completionHandler) { }

	// RVA: 0x89D4188 Offset: 0x89D0188 VA: 0x89D4188
	public bool Hide(bool fade = False, UniWebViewTransitionEdge edge = 0, float duration = 0.4, Action completionHandler) { }

	// RVA: 0x89D3D44 Offset: 0x89CFD44 VA: 0x89D3D44
	public bool _Hide(bool fade = False, UniWebViewTransitionEdge edge = 0, float duration = 0.4, bool useAsync = False, Action completionHandler) { }

	// RVA: 0x89D4198 Offset: 0x89D0198 VA: 0x89D4198
	public bool AnimateTo(Rect frame, float duration, float delay = 0, Action completionHandler) { }

	// RVA: 0x89D42FC Offset: 0x89D02FC VA: 0x89D42FC
	public void AddJavaScript(string jsString, Action<UniWebViewNativeResultPayload> completionHandler) { }

	// RVA: 0x89D43DC Offset: 0x89D03DC VA: 0x89D43DC
	public void EvaluateJavaScript(string jsString, Action<UniWebViewNativeResultPayload> completionHandler) { }

	// RVA: 0x89D44BC Offset: 0x89D04BC VA: 0x89D44BC
	public void AddUrlScheme(string scheme) { }

	// RVA: 0x89D45AC Offset: 0x89D05AC VA: 0x89D45AC
	public void RemoveUrlScheme(string scheme) { }

	// RVA: 0x89D469C Offset: 0x89D069C VA: 0x89D469C
	public void AddSslExceptionDomain(string domain) { }

	// RVA: 0x89D478C Offset: 0x89D078C VA: 0x89D478C
	public void RemoveSslExceptionDomain(string domain) { }

	// RVA: 0x89D487C Offset: 0x89D087C VA: 0x89D487C
	public void SetHeaderField(string key, string value) { }

	// RVA: 0x89D4938 Offset: 0x89D0938 VA: 0x89D4938
	public void SetUserAgent(string agent) { }

	// RVA: 0x89D49AC Offset: 0x89D09AC VA: 0x89D49AC
	public string GetUserAgent() { }

	// RVA: 0x89D4A18 Offset: 0x89D0A18 VA: 0x89D4A18
	public void SetContentInsetAdjustmentBehavior(UniWebViewContentInsetAdjustmentBehavior behavior) { }

	// RVA: 0x89D4A1C Offset: 0x89D0A1C VA: 0x89D4A1C
	public static void SetAllowAutoPlay(bool flag) { }

	// RVA: 0x89D4A70 Offset: 0x89D0A70 VA: 0x89D4A70
	public static void SetAllowInlinePlay(bool flag) { }

	// RVA: 0x89D4A74 Offset: 0x89D0A74 VA: 0x89D4A74
	public void SetAllowFileAccess(bool flag) { }

	// RVA: 0x89D4AE8 Offset: 0x89D0AE8 VA: 0x89D4AE8
	public void SetAllowFileAccessFromFileURLs(bool flag) { }

	// RVA: 0x89D4B5C Offset: 0x89D0B5C VA: 0x89D4B5C
	public void SetAcceptThirdPartyCookies(bool flag) { }

	// RVA: 0x89D4BD0 Offset: 0x89D0BD0 VA: 0x89D4BD0
	public static void SetAllowUniversalAccessFromFileURLs(bool flag) { }

	// RVA: 0x89D4C24 Offset: 0x89D0C24 VA: 0x89D4C24
	public static void SetEnableKeyboardAvoidance(bool flag) { }

	// RVA: 0x89D4C78 Offset: 0x89D0C78 VA: 0x89D4C78
	public static void SetJavaScriptEnabled(bool enabled) { }

	// RVA: 0x89D4CCC Offset: 0x89D0CCC VA: 0x89D4CCC
	public static void SetLimitsNavigationsToAppBoundDomains(bool enabled) { }

	// RVA: 0x89D4CD0 Offset: 0x89D0CD0 VA: 0x89D4CD0
	public static void SetAllowJavaScriptOpenWindow(bool flag) { }

	// RVA: 0x89D4D24 Offset: 0x89D0D24 VA: 0x89D4D24
	public static void SetForwardWebConsoleToNativeOutput(bool flag) { }

	// RVA: 0x89D4D78 Offset: 0x89D0D78 VA: 0x89D4D78
	public void CleanCache() { }

	// RVA: 0x89D4DE4 Offset: 0x89D0DE4 VA: 0x89D4DE4
	public void SetCacheMode(UniWebViewCacheMode cacheMode) { }

	// RVA: 0x89D4E58 Offset: 0x89D0E58 VA: 0x89D4E58
	public static void ClearCookies() { }

	// RVA: 0x89D4EA4 Offset: 0x89D0EA4 VA: 0x89D4EA4
	public static void SetCookie(string url, string cookie, bool skipEncoding = False) { }

	// RVA: 0x89D4F0C Offset: 0x89D0F0C VA: 0x89D4F0C
	public static string GetCookie(string url, string key, bool skipEncoding = False) { }

	// RVA: 0x89D4F74 Offset: 0x89D0F74 VA: 0x89D4F74
	public static void RemoveCookies(string url, bool skipEncoding = False) { }

	// RVA: 0x89D4FCC Offset: 0x89D0FCC VA: 0x89D4FCC
	public static void RemoveCooke(string url, string key, bool skipEncoding = False) { }

	// RVA: 0x89D5034 Offset: 0x89D1034 VA: 0x89D5034
	public static void ClearHttpAuthUsernamePassword(string host, string realm) { }

	// RVA: 0x89D5098 Offset: 0x89D1098 VA: 0x89D5098
	public Color get_BackgroundColor() { }

	// RVA: 0x89D50A4 Offset: 0x89D10A4 VA: 0x89D50A4
	public void set_BackgroundColor(Color value) { }

	// RVA: 0x89D5148 Offset: 0x89D1148 VA: 0x89D5148
	public float get_Alpha() { }

	// RVA: 0x89D51B4 Offset: 0x89D11B4 VA: 0x89D51B4
	public void set_Alpha(float value) { }

	// RVA: 0x89D5230 Offset: 0x89D1230 VA: 0x89D5230
	public void SetShowSpinnerWhileLoading(bool flag) { }

	// RVA: 0x89D52A4 Offset: 0x89D12A4 VA: 0x89D52A4
	public void SetSpinnerText(string text) { }

	// RVA: 0x89D5318 Offset: 0x89D1318 VA: 0x89D5318
	public void SetAllowUserDismissSpinner(bool flag) { }

	// RVA: 0x89D538C Offset: 0x89D138C VA: 0x89D538C
	public void ShowSpinner() { }

	// RVA: 0x89D53F8 Offset: 0x89D13F8 VA: 0x89D53F8
	public void HideSpinner() { }

	// RVA: 0x89D5464 Offset: 0x89D1464 VA: 0x89D5464
	public void SetHorizontalScrollBarEnabled(bool enabled) { }

	// RVA: 0x89D54D8 Offset: 0x89D14D8 VA: 0x89D54D8
	public void SetVerticalScrollBarEnabled(bool enabled) { }

	// RVA: 0x89D554C Offset: 0x89D154C VA: 0x89D554C
	public void SetBouncesEnabled(bool enabled) { }

	// RVA: 0x89D55C0 Offset: 0x89D15C0 VA: 0x89D55C0
	public void SetZoomEnabled(bool enabled) { }

	[Obsolete("Deprecated. Use `RegisterOnRequestMediaCapturePermission` instead. Check https://docs.uniwebview.com/api/#registeronrequestmediacapturepermission", False)]
	// RVA: 0x89D5634 Offset: 0x89D1634 VA: 0x89D5634
	public void AddPermissionTrustDomain(string domain) { }

	[Obsolete("Deprecated. Use `UnregisterOnRequestMediaCapturePermission` instead.", False)]
	// RVA: 0x89D56A8 Offset: 0x89D16A8 VA: 0x89D56A8
	public void RemovePermissionTrustDomain(string domain) { }

	// RVA: 0x89D571C Offset: 0x89D171C VA: 0x89D571C
	public void SetBackButtonEnabled(bool enabled) { }

	// RVA: 0x89D5728 Offset: 0x89D1728 VA: 0x89D5728
	public void SetUseWideViewPort(bool flag) { }

	// RVA: 0x89D579C Offset: 0x89D179C VA: 0x89D579C
	public void SetLoadWithOverviewMode(bool flag) { }

	[Obsolete("`SetShowToolbar` is deprecated. Use `EmbeddedToolbar.Show()` or `EmbeddedToolbar.Hide()`instead.", False)]
	// RVA: 0x89D4184 Offset: 0x89D0184 VA: 0x89D4184
	public void SetShowToolbar(bool show, bool animated = False, bool onTop = True, bool adjustInset = False) { }

	[Obsolete("`SetToolbarDoneButtonText` is deprecated. Use `EmbeddedToolbar.SetDoneButtonText` instead.", False)]
	// RVA: 0x89D5810 Offset: 0x89D1810 VA: 0x89D5810
	public void SetToolbarDoneButtonText(string text) { }

	[Obsolete("`SetToolbarGoBackButtonText` is deprecated. Use `EmbeddedToolbar.SetGoBackButtonText` instead.", False)]
	// RVA: 0x89D5814 Offset: 0x89D1814 VA: 0x89D5814
	public void SetToolbarGoBackButtonText(string text) { }

	[Obsolete("`SetToolbarGoForwardButtonText` is deprecated. Use `EmbeddedToolbar.SetGoForwardButtonText` instead.", False)]
	// RVA: 0x89D5818 Offset: 0x89D1818 VA: 0x89D5818
	public void SetToolbarGoForwardButtonText(string text) { }

	[Obsolete("`SetToolbarTintColor` is deprecated. Use `EmbeddedToolbar.SetBackgroundColor` instead.", False)]
	// RVA: 0x89D581C Offset: 0x89D181C VA: 0x89D581C
	public void SetToolbarTintColor(Color color) { }

	[Obsolete("`SetToolbarTextColor` is deprecated. Use `EmbeddedToolbar.SetButtonTextColor` or `EmbeddedToolbar.SetTitleTextColor` instead.", False)]
	// RVA: 0x89D5820 Offset: 0x89D1820 VA: 0x89D5820
	public void SetToolbarTextColor(Color color) { }

	[Obsolete("`SetShowToolbarNavigationButtons` is deprecated. Use `EmbeddedToolbar.ShowNavigationButtons` or `EmbeddedToolbar.HideNavigationButtons` instead.", False)]
	// RVA: 0x89D5824 Offset: 0x89D1824 VA: 0x89D5824
	public void SetShowToolbarNavigationButtons(bool show) { }

	// RVA: 0x89D5828 Offset: 0x89D1828 VA: 0x89D5828
	public void SetUserInteractionEnabled(bool enabled) { }

	// RVA: 0x89D589C Offset: 0x89D189C VA: 0x89D589C
	public void SetTransparencyClickingThroughEnabled(bool enabled) { }

	// RVA: 0x89D5910 Offset: 0x89D1910 VA: 0x89D5910
	public static void SetWebContentsDebuggingEnabled(bool enabled) { }

	// RVA: 0x89D5964 Offset: 0x89D1964 VA: 0x89D5964
	public void SetWindowUserResizeEnabled(bool enabled) { }

	// RVA: 0x89D5968 Offset: 0x89D1968 VA: 0x89D5968
	public void GetHTMLContent(Action<string> handler) { }

	// RVA: 0x89D5A54 Offset: 0x89D1A54 VA: 0x89D5A54
	public void SetAllowBackForwardNavigationGestures(bool flag) { }

	// RVA: 0x89D5A58 Offset: 0x89D1A58 VA: 0x89D5A58
	public void SetAllowHTTPAuthPopUpWindow(bool flag) { }

	// RVA: 0x89D5ACC Offset: 0x89D1ACC VA: 0x89D5ACC
	public void SetCalloutEnabled(bool enabled) { }

	[Obsolete("Deprecated. Use `SetSupportMultipleWindows(bool enabled, bool allowJavaScriptOpen)` to set `allowJavaScriptOpen` explicitly.")]
	// RVA: 0x89D5B40 Offset: 0x89D1B40 VA: 0x89D5B40
	public void SetSupportMultipleWindows(bool enabled) { }

	// RVA: 0x89D5B4C Offset: 0x89D1B4C VA: 0x89D5B4C
	public void SetSupportMultipleWindows(bool enabled, bool allowJavaScriptOpening) { }

	// RVA: 0x89D5BD0 Offset: 0x89D1BD0 VA: 0x89D5BD0
	public void SetDefaultFontSize(int size) { }

	// RVA: 0x89D5C44 Offset: 0x89D1C44 VA: 0x89D5C44
	public void SetTextZoom(int textZoom) { }

	// RVA: 0x89D5CB8 Offset: 0x89D1CB8 VA: 0x89D5CB8
	public void SetDragInteractionEnabled(bool enabled) { }

	// RVA: 0x89D5D2C Offset: 0x89D1D2C VA: 0x89D5D2C
	public void Print() { }

	// RVA: 0x89D5D98 Offset: 0x89D1D98 VA: 0x89D5D98
	public void CaptureSnapshot(string fileName) { }

	// RVA: 0x89D5E0C Offset: 0x89D1E0C VA: 0x89D5E0C
	public void ScrollTo(int x, int y, bool animated) { }

	// RVA: 0x89D5E98 Offset: 0x89D1E98 VA: 0x89D5E98
	public void AddDownloadURL(string urlString, UniWebViewDownloadMatchingType type = 1) { }

	// RVA: 0x89D5E9C Offset: 0x89D1E9C VA: 0x89D5E9C
	public void RemoveDownloadURL(string urlString, UniWebViewDownloadMatchingType type = 1) { }

	// RVA: 0x89D5EA0 Offset: 0x89D1EA0 VA: 0x89D5EA0
	public void AddDownloadMIMEType(string MIMEType, UniWebViewDownloadMatchingType type = 1) { }

	// RVA: 0x89D5EA4 Offset: 0x89D1EA4 VA: 0x89D5EA4
	public void RemoveDownloadMIMETypes(string MIMEType, UniWebViewDownloadMatchingType type = 1) { }

	// RVA: 0x89D5EA8 Offset: 0x89D1EA8 VA: 0x89D5EA8
	public void SetAllowUserEditFileNameBeforeDownloading(bool allowed) { }

	// RVA: 0x89D5F1C Offset: 0x89D1F1C VA: 0x89D5F1C
	public void SetAllowUserChooseActionAfterDownloading(bool allowed) { }

	// RVA: 0x89D5F20 Offset: 0x89D1F20 VA: 0x89D5F20
	public void SetDownloadEventForContextMenuEnabled(bool enabled) { }

	// RVA: 0x89D5F94 Offset: 0x89D1F94 VA: 0x89D5F94
	public void StartSnapshotForRendering(Nullable<Rect> rect, Action<Texture2D> onStarted) { }

	// RVA: 0x89D6130 Offset: 0x89D2130 VA: 0x89D6130
	public void StopSnapshotForRendering() { }

	// RVA: 0x89D619C Offset: 0x89D219C VA: 0x89D619C
	public byte[] GetRenderedData(Nullable<Rect> rect) { }

	// RVA: 0x89D62D4 Offset: 0x89D22D4 VA: 0x89D62D4
	public Texture2D CreateRenderedTexture(Nullable<Rect> rect) { }

	// RVA: 0x89D637C Offset: 0x89D237C VA: 0x89D637C
	public void RegisterShouldHandleRequest(Func<UniWebViewChannelMethodHandleRequest, bool> handler) { }

	// RVA: 0x89D662C Offset: 0x89D262C VA: 0x89D662C
	public void UnregisterShouldHandleRequest() { }

	// RVA: 0x89D67A0 Offset: 0x89D27A0 VA: 0x89D67A0
	public void RegisterOnRequestMediaCapturePermission(Func<UniWebViewChannelMethodMediaCapturePermission, UniWebViewMediaCapturePermissionDecision> handler) { }

	// RVA: 0x89D6898 Offset: 0x89D2898 VA: 0x89D6898
	public void UnregisterOnRequestMediaCapturePermission() { }

	// RVA: 0x89D68D4 Offset: 0x89D28D4 VA: 0x89D68D4
	private void OnDestroy() { }

	// RVA: 0x89D6B28 Offset: 0x89D2B28 VA: 0x89D6B28
	private void OnApplicationPause(bool pauseStatus) { }

	// RVA: 0x89D6BB0 Offset: 0x89D2BB0 VA: 0x89D6BB0
	internal void InternalOnShowTransitionFinished(string identifier) { }

	// RVA: 0x89D6C60 Offset: 0x89D2C60 VA: 0x89D6C60
	internal void InternalOnHideTransitionFinished(string identifier) { }

	// RVA: 0x89D6D10 Offset: 0x89D2D10 VA: 0x89D6D10
	internal void InternalOnAnimateToFinished(string identifier) { }

	// RVA: 0x89D6DC0 Offset: 0x89D2DC0 VA: 0x89D6DC0
	internal void InternalOnAddJavaScriptFinished(UniWebViewNativeResultPayload payload) { }

	// RVA: 0x89D6E7C Offset: 0x89D2E7C VA: 0x89D6E7C
	internal void InternalOnEvalJavaScriptFinished(UniWebViewNativeResultPayload payload) { }

	// RVA: 0x89D6F38 Offset: 0x89D2F38 VA: 0x89D6F38
	internal void InternalOnPageFinished(UniWebViewNativeResultPayload payload) { }

	// RVA: 0x89D7008 Offset: 0x89D3008 VA: 0x89D7008
	internal void InternalOnPageStarted(string url) { }

	// RVA: 0x89D7030 Offset: 0x89D3030 VA: 0x89D7030
	internal void InternalOnPageErrorReceived(UniWebViewNativeResultPayload payload) { }

	// RVA: 0x89D7148 Offset: 0x89D3148 VA: 0x89D7148
	internal void InternalOnPageProgressChanged(float progress) { }

	// RVA: 0x89D7168 Offset: 0x89D3168 VA: 0x89D7168
	internal void InternalOnMessageReceived(string result) { }

	// RVA: 0x89D3B3C Offset: 0x89CFB3C VA: 0x89D3B3C
	internal void InternalOnShouldClose() { }

	// RVA: 0x89D7888 Offset: 0x89D3888 VA: 0x89D7888
	internal void InternalOnWebContentProcessDidTerminate() { }

	// RVA: 0x89D78A8 Offset: 0x89D38A8 VA: 0x89D78A8
	internal void InternalOnMultipleWindowOpened(string multiWindowId) { }

	// RVA: 0x89D78D0 Offset: 0x89D38D0 VA: 0x89D78D0
	internal void InternalOnMultipleWindowClosed(string multiWindowId) { }

	// RVA: 0x89D78F8 Offset: 0x89D38F8 VA: 0x89D78F8
	internal void InternalOnFileDownloadStarted(UniWebViewNativeResultPayload payload) { }

	// RVA: 0x89D7938 Offset: 0x89D3938 VA: 0x89D7938
	internal void InternalOnFileDownloadFinished(UniWebViewNativeResultPayload payload) { }

	// RVA: 0x89D79AC Offset: 0x89D39AC VA: 0x89D79AC
	internal void InternalOnCaptureSnapshotFinished(UniWebViewNativeResultPayload payload) { }

	// RVA: 0x89D7A1C Offset: 0x89D3A1C VA: 0x89D7A1C
	internal void InternalOnSnapshotRenderingStarted(string identifier) { }

	[Obsolete("SetImmersiveModeEnabled is deprecated. Now UniWebView always respect navigation bar/status bar settings from Unity.", False)]
	// RVA: 0x89D7ACC Offset: 0x89D3ACC VA: 0x89D7ACC
	public void SetImmersiveModeEnabled(bool enabled) { }

	[CompilerGenerated]
	// RVA: 0x89D7B34 Offset: 0x89D3B34 VA: 0x89D7B34
	public void add_OnKeyCodeReceived(UniWebView.KeyCodeReceivedDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x89D7BD4 Offset: 0x89D3BD4 VA: 0x89D7BD4
	public void remove_OnKeyCodeReceived(UniWebView.KeyCodeReceivedDelegate value) { }

	// RVA: 0x89D7C74 Offset: 0x89D3C74 VA: 0x89D7C74
	public void .ctor() { }

	// RVA: 0x89D7D94 Offset: 0x89D3D94 VA: 0x89D7D94
	private static void .cctor() { }
}

// Namespace: 
public abstract class UniWebViewAuthenticationCommonFlow : MonoBehaviour // TypeDefIndex: 26553
{
	// Fields
	public bool authorizeOnStart; // 0x20
	public bool privateMode; // 0x21
	private string state; // 0x28
	[CompilerGenerated]
	private string <CodeVerify>k__BackingField; // 0x30

	// Properties
	protected string CodeVerify { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x89D9830 Offset: 0x89D5830 VA: 0x89D9830
	protected string get_CodeVerify() { }

	[CompilerGenerated]
	// RVA: 0x89D9838 Offset: 0x89D5838 VA: 0x89D9838
	private void set_CodeVerify(string value) { }

	// RVA: 0x89D9840 Offset: 0x89D5840 VA: 0x89D9840
	public void Start() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void StartAuthenticationFlow();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void StartRefreshTokenFlow(string refreshToken);

	// RVA: 0x89D9858 Offset: 0x89D5858 VA: 0x89D9858
	protected string GenerateAndStoreState() { }

	// RVA: 0x89D9910 Offset: 0x89D5910 VA: 0x89D9910
	protected string GenerateCodeChallengeAndStoreCodeVerify(UniWebViewAuthenticationPKCE method) { }

	// RVA: 0x89D9E3C Offset: 0x89D5E3C VA: 0x89D9E3C
	protected void VerifyState(Dictionary<string, string> parameters, string key = "state") { }

	// RVA: 0x89D9F08 Offset: 0x89D5F08 VA: 0x89D9F08
	protected void .ctor() { }
}

// Namespace: 
public interface IUniWebViewAuthenticationFlow<TTokenType> // TypeDefIndex: 26554
{
	// Properties
	public abstract UnityEvent<TTokenType> OnAuthenticationFinished { get; }
	public abstract UnityEvent<long, string> OnAuthenticationErrored { get; }
	public abstract UnityEvent<TTokenType> OnRefreshTokenFinished { get; }
	public abstract UnityEvent<long, string> OnRefreshTokenErrored { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string GetCallbackUrl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IUniWebViewAuthenticationFlow<__Il2CppFullySharedGenericType>.GetCallbackUrl
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract UniWebViewAuthenticationConfiguration GetAuthenticationConfiguration();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IUniWebViewAuthenticationFlow<__Il2CppFullySharedGenericType>.GetAuthenticationConfiguration
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Dictionary<string, string> GetAuthenticationUriArguments();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IUniWebViewAuthenticationFlow<__Il2CppFullySharedGenericType>.GetAuthenticationUriArguments
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Dictionary<string, string> GetAccessTokenRequestParameters(string authResponse);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IUniWebViewAuthenticationFlow<__Il2CppFullySharedGenericType>.GetAccessTokenRequestParameters
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Dictionary<string, string> GetRefreshTokenRequestParameters(string refreshToken);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IUniWebViewAuthenticationFlow<__Il2CppFullySharedGenericType>.GetRefreshTokenRequestParameters
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract TTokenType GenerateTokenFromExchangeResponse(string exchangeResponse);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IUniWebViewAuthenticationFlow<__Il2CppFullySharedGenericType>.GenerateTokenFromExchangeResponse
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public abstract UnityEvent<TTokenType> get_OnAuthenticationFinished();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IUniWebViewAuthenticationFlow<__Il2CppFullySharedGenericType>.get_OnAuthenticationFinished
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract UnityEvent<long, string> get_OnAuthenticationErrored();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IUniWebViewAuthenticationFlow<__Il2CppFullySharedGenericType>.get_OnAuthenticationErrored
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public abstract UnityEvent<TTokenType> get_OnRefreshTokenFinished();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IUniWebViewAuthenticationFlow<__Il2CppFullySharedGenericType>.get_OnRefreshTokenFinished
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract UnityEvent<long, string> get_OnRefreshTokenErrored();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IUniWebViewAuthenticationFlow<__Il2CppFullySharedGenericType>.get_OnRefreshTokenErrored
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class UniWebViewAuthenticationFlow.<SendTokenRequest>d__9<TTokenType> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 26555
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public UnityWebRequest request; // 0x0
	public Action<long, string> errorAction; // 0x0
	public UniWebViewAuthenticationFlow<TTokenType> <>4__this; // 0x0
	public Action<TTokenType> finishAction; // 0x0
	private UnityWebRequest <www>5__2; // 0x0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E44E88 Offset: 0x5E40E88 VA: 0x5E44E88
	|-UniWebViewAuthenticationFlow.<SendTokenRequest>d__9<object>..ctor
	|
	|-RVA: 0x5E45730 Offset: 0x5E41730 VA: 0x5E45730
	|-UniWebViewAuthenticationFlow.<SendTokenRequest>d__9<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E44EB0 Offset: 0x5E40EB0 VA: 0x5E44EB0
	|-UniWebViewAuthenticationFlow.<SendTokenRequest>d__9<object>.System.IDisposable.Dispose
	|
	|-RVA: 0x5E45758 Offset: 0x5E41758 VA: 0x5E45758
	|-UniWebViewAuthenticationFlow.<SendTokenRequest>d__9<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E44ECC Offset: 0x5E40ECC VA: 0x5E44ECC
	|-UniWebViewAuthenticationFlow.<SendTokenRequest>d__9<object>.MoveNext
	|
	|-RVA: 0x5E45784 Offset: 0x5E41784 VA: 0x5E45784
	|-UniWebViewAuthenticationFlow.<SendTokenRequest>d__9<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E4563C Offset: 0x5E4163C VA: 0x5E4563C
	|-UniWebViewAuthenticationFlow.<SendTokenRequest>d__9<object>.<>m__Finally1
	|
	|-RVA: 0x5E45FD4 Offset: 0x5E41FD4 VA: 0x5E45FD4
	|-UniWebViewAuthenticationFlow.<SendTokenRequest>d__9<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E456EC Offset: 0x5E416EC VA: 0x5E456EC
	|-UniWebViewAuthenticationFlow.<SendTokenRequest>d__9<object>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	|
	|-RVA: 0x5E46084 Offset: 0x5E42084 VA: 0x5E46084
	|-UniWebViewAuthenticationFlow.<SendTokenRequest>d__9<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E456F4 Offset: 0x5E416F4 VA: 0x5E456F4
	|-UniWebViewAuthenticationFlow.<SendTokenRequest>d__9<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x5E4608C Offset: 0x5E4208C VA: 0x5E4608C
	|-UniWebViewAuthenticationFlow.<SendTokenRequest>d__9<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E45728 Offset: 0x5E41728 VA: 0x5E45728
	|-UniWebViewAuthenticationFlow.<SendTokenRequest>d__9<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x5E460C0 Offset: 0x5E420C0 VA: 0x5E460C0
	|-UniWebViewAuthenticationFlow.<SendTokenRequest>d__9<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: 
public class UniWebViewAuthenticationFlow<TTokenType> // TypeDefIndex: 26556
{
	// Fields
	private IUniWebViewAuthenticationFlow<TTokenType> service; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IUniWebViewAuthenticationFlow<TTokenType> service) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56B4828 Offset: 0x56B0828 VA: 0x56B4828
	|-UniWebViewAuthenticationFlow<object>..ctor
	|
	|-RVA: 0x56B6214 Offset: 0x56B2214 VA: 0x56B6214
	|-UniWebViewAuthenticationFlow<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void StartAuth() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56B4858 Offset: 0x56B0858 VA: 0x56B4858
	|-UniWebViewAuthenticationFlow<object>.StartAuth
	|
	|-RVA: 0x56B6244 Offset: 0x56B2244 VA: 0x56B6244
	|-UniWebViewAuthenticationFlow<__Il2CppFullySharedGenericType>.StartAuth
	*/

	// RVA: -1 Offset: -1
	private void ExchangeToken(string response) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56B4B44 Offset: 0x56B0B44 VA: 0x56B4B44
	|-UniWebViewAuthenticationFlow<object>.ExchangeToken
	|
	|-RVA: 0x56B6534 Offset: 0x56B2534 VA: 0x56B6534
	|-UniWebViewAuthenticationFlow<__Il2CppFullySharedGenericType>.ExchangeToken
	*/

	// RVA: -1 Offset: -1
	public void RefreshToken(string refreshToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56B4EF8 Offset: 0x56B0EF8 VA: 0x56B4EF8
	|-UniWebViewAuthenticationFlow<object>.RefreshToken
	|
	|-RVA: 0x56B68F4 Offset: 0x56B28F4 VA: 0x56B68F4
	|-UniWebViewAuthenticationFlow<__Il2CppFullySharedGenericType>.RefreshToken
	*/

	// RVA: -1 Offset: -1
	private string GetAuthUrl() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56B52AC Offset: 0x56B12AC VA: 0x56B52AC
	|-UniWebViewAuthenticationFlow<object>.GetAuthUrl
	|
	|-RVA: 0x56B6CB4 Offset: 0x56B2CB4 VA: 0x56B6CB4
	|-UniWebViewAuthenticationFlow<__Il2CppFullySharedGenericType>.GetAuthUrl
	*/

	// RVA: -1 Offset: -1
	private UnityWebRequest GetTokenRequest(Dictionary<string, string> args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56B5600 Offset: 0x56B1600 VA: 0x56B5600
	|-UniWebViewAuthenticationFlow<object>.GetTokenRequest
	|
	|-RVA: 0x56B7008 Offset: 0x56B3008 VA: 0x56B7008
	|-UniWebViewAuthenticationFlow<__Il2CppFullySharedGenericType>.GetTokenRequest
	*/

	// RVA: -1 Offset: -1
	private IEnumerator SendExchangeTokenRequest(UnityWebRequest request) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56B5878 Offset: 0x56B1878 VA: 0x56B5878
	|-UniWebViewAuthenticationFlow<object>.SendExchangeTokenRequest
	|
	|-RVA: 0x56B7280 Offset: 0x56B3280 VA: 0x56B7280
	|-UniWebViewAuthenticationFlow<__Il2CppFullySharedGenericType>.SendExchangeTokenRequest
	*/

	// RVA: -1 Offset: -1
	private IEnumerator SendRefreshTokenRequest(UnityWebRequest request) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56B5940 Offset: 0x56B1940 VA: 0x56B5940
	|-UniWebViewAuthenticationFlow<object>.SendRefreshTokenRequest
	|
	|-RVA: 0x56B7350 Offset: 0x56B3350 VA: 0x56B7350
	|-UniWebViewAuthenticationFlow<__Il2CppFullySharedGenericType>.SendRefreshTokenRequest
	*/

	[IteratorStateMachine(typeof(UniWebViewAuthenticationFlow.<SendTokenRequest>d__9<TTokenType>))]
	// RVA: -1 Offset: -1
	private IEnumerator SendTokenRequest(UnityWebRequest request, Action<TTokenType> finishAction, Action<long, string> errorAction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56B5A08 Offset: 0x56B1A08 VA: 0x56B5A08
	|-UniWebViewAuthenticationFlow<object>.SendTokenRequest
	|
	|-RVA: 0x56B7420 Offset: 0x56B3420 VA: 0x56B7420
	|-UniWebViewAuthenticationFlow<__Il2CppFullySharedGenericType>.SendTokenRequest
	*/

	// RVA: -1 Offset: -1
	private void ExchangeTokenFinished(TTokenType token) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56B5AC4 Offset: 0x56B1AC4 VA: 0x56B5AC4
	|-UniWebViewAuthenticationFlow<object>.ExchangeTokenFinished
	|
	|-RVA: 0x56B74E0 Offset: 0x56B34E0 VA: 0x56B74E0
	|-UniWebViewAuthenticationFlow<__Il2CppFullySharedGenericType>.ExchangeTokenFinished
	*/

	// RVA: -1 Offset: -1
	private void ExchangeTokenErrored(long code, string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56B5C18 Offset: 0x56B1C18 VA: 0x56B5C18
	|-UniWebViewAuthenticationFlow<object>.ExchangeTokenErrored
	|
	|-RVA: 0x56B76DC Offset: 0x56B36DC VA: 0x56B76DC
	|-UniWebViewAuthenticationFlow<__Il2CppFullySharedGenericType>.ExchangeTokenErrored
	*/

	// RVA: -1 Offset: -1
	private void RefreshTokenFinished(TTokenType token) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56B5E10 Offset: 0x56B1E10 VA: 0x56B5E10
	|-UniWebViewAuthenticationFlow<object>.RefreshTokenFinished
	|
	|-RVA: 0x56B78D4 Offset: 0x56B38D4 VA: 0x56B78D4
	|-UniWebViewAuthenticationFlow<__Il2CppFullySharedGenericType>.RefreshTokenFinished
	*/

	// RVA: -1 Offset: -1
	private void RefreshTokenErrored(long code, string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56B5F64 Offset: 0x56B1F64 VA: 0x56B5F64
	|-UniWebViewAuthenticationFlow<object>.RefreshTokenErrored
	|
	|-RVA: 0x56B7AD0 Offset: 0x56B3AD0 VA: 0x56B7AD0
	|-UniWebViewAuthenticationFlow<__Il2CppFullySharedGenericType>.RefreshTokenErrored
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <StartAuth>b__2_0(UniWebViewAuthenticationSession _, string resultUrl) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56B615C Offset: 0x56B215C VA: 0x56B615C
	|-UniWebViewAuthenticationFlow<object>.<StartAuth>b__2_0
	|
	|-RVA: 0x56B7CC8 Offset: 0x56B3CC8 VA: 0x56B7CC8
	|-UniWebViewAuthenticationFlow<__Il2CppFullySharedGenericType>.<StartAuth>b__2_0
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <StartAuth>b__2_1(UniWebViewAuthenticationSession _, int errorCode, string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56B61F8 Offset: 0x56B21F8 VA: 0x56B61F8
	|-UniWebViewAuthenticationFlow<object>.<StartAuth>b__2_1
	|
	|-RVA: 0x56B7D68 Offset: 0x56B3D68 VA: 0x56B7D68
	|-UniWebViewAuthenticationFlow<__Il2CppFullySharedGenericType>.<StartAuth>b__2_1
	*/
}

// Namespace: 
public class UniWebViewAuthenticationConfiguration // TypeDefIndex: 26557
{
	// Fields
	internal readonly string authorizationEndpoint; // 0x10
	internal readonly string tokenEndpoint; // 0x18

	// Methods

	// RVA: 0x89D9F10 Offset: 0x89D5F10 VA: 0x89D9F10
	public void .ctor(string authorizationEndpoint, string tokenEndpoint) { }
}

// Namespace: 
public class AuthenticationResponseException : Exception // TypeDefIndex: 26558
{
	// Fields
	[CompilerGenerated]
	private readonly int <Code>k__BackingField; // 0x8C
	public static AuthenticationResponseException UnexpectedAuthCallbackUrl; // 0x0
	public static AuthenticationResponseException InvalidState; // 0x8

	// Properties
	public int Code { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x89D9F54 Offset: 0x89D5F54 VA: 0x89D9F54
	public int get_Code() { }

	// RVA: 0x89D9F5C Offset: 0x89D5F5C VA: 0x89D9F5C
	public void .ctor(int code, string message) { }

	// RVA: 0x89D9FD0 Offset: 0x89D5FD0 VA: 0x89D9FD0
	public static AuthenticationResponseException InvalidResponse(string query) { }

	// RVA: 0x89DA060 Offset: 0x89D6060 VA: 0x89DA060
	private static void .cctor() { }
}

// Namespace: 
public class UniWebViewAuthenticationFlowCustomize : UniWebViewAuthenticationCommonFlow, IUniWebViewAuthenticationFlow<UniWebViewAuthenticationStandardToken> // TypeDefIndex: 26559
{
	// Fields
	public UniWebViewAuthenticationFlowCustomizeConfig config; // 0x38
	public string clientId; // 0x40
	public string redirectUri; // 0x48
	public string scope; // 0x50
	public UniWebViewAuthenticationFlowCustomizeOptional optional; // 0x58
	[SerializeField]
	[CompilerGenerated]
	private UnityEvent<UniWebViewAuthenticationStandardToken> <OnAuthenticationFinished>k__BackingField; // 0x60
	[SerializeField]
	[CompilerGenerated]
	private UnityEvent<long, string> <OnAuthenticationErrored>k__BackingField; // 0x68
	[SerializeField]
	[CompilerGenerated]
	private UnityEvent<UniWebViewAuthenticationStandardToken> <OnRefreshTokenFinished>k__BackingField; // 0x70
	[CompilerGenerated]
	[SerializeField]
	private UnityEvent<long, string> <OnRefreshTokenErrored>k__BackingField; // 0x78

	// Properties
	public UnityEvent<UniWebViewAuthenticationStandardToken> OnAuthenticationFinished { get; set; }
	public UnityEvent<long, string> OnAuthenticationErrored { get; set; }
	public UnityEvent<UniWebViewAuthenticationStandardToken> OnRefreshTokenFinished { get; set; }
	public UnityEvent<long, string> OnRefreshTokenErrored { get; set; }

	// Methods

	// RVA: 0x89DA128 Offset: 0x89D6128 VA: 0x89DA128 Slot: 4
	public override void StartAuthenticationFlow() { }

	// RVA: 0x89DA1C0 Offset: 0x89D61C0 VA: 0x89DA1C0 Slot: 5
	public override void StartRefreshTokenFlow(string refreshToken) { }

	// RVA: 0x89DA260 Offset: 0x89D6260 VA: 0x89DA260 Slot: 16
	public virtual UniWebViewAuthenticationConfiguration GetAuthenticationConfiguration() { }

	// RVA: 0x89DA2CC Offset: 0x89D62CC VA: 0x89DA2CC Slot: 17
	public virtual string GetCallbackUrl() { }

	// RVA: 0x89DA2D4 Offset: 0x89D62D4 VA: 0x89DA2D4 Slot: 18
	public virtual Dictionary<string, string> GetAuthenticationUriArguments() { }

	// RVA: 0x89DA560 Offset: 0x89D6560 VA: 0x89DA560 Slot: 19
	public virtual Dictionary<string, string> GetAccessTokenRequestParameters(string authResponse) { }

	// RVA: 0x89DAA1C Offset: 0x89D6A1C VA: 0x89DAA1C Slot: 20
	public virtual Dictionary<string, string> GetRefreshTokenRequestParameters(string refreshToken) { }

	// RVA: 0x89DAB78 Offset: 0x89D6B78 VA: 0x89DAB78 Slot: 21
	public virtual UniWebViewAuthenticationStandardToken GenerateTokenFromExchangeResponse(string exchangeResponse) { }

	[CompilerGenerated]
	// RVA: 0x89DABC0 Offset: 0x89D6BC0 VA: 0x89DABC0 Slot: 12
	public UnityEvent<UniWebViewAuthenticationStandardToken> get_OnAuthenticationFinished() { }

	[CompilerGenerated]
	// RVA: 0x89DABC8 Offset: 0x89D6BC8 VA: 0x89DABC8
	public void set_OnAuthenticationFinished(UnityEvent<UniWebViewAuthenticationStandardToken> value) { }

	[CompilerGenerated]
	// RVA: 0x89DABD0 Offset: 0x89D6BD0 VA: 0x89DABD0 Slot: 13
	public UnityEvent<long, string> get_OnAuthenticationErrored() { }

	[CompilerGenerated]
	// RVA: 0x89DABD8 Offset: 0x89D6BD8 VA: 0x89DABD8
	public void set_OnAuthenticationErrored(UnityEvent<long, string> value) { }

	[CompilerGenerated]
	// RVA: 0x89DABE0 Offset: 0x89D6BE0 VA: 0x89DABE0 Slot: 14
	public UnityEvent<UniWebViewAuthenticationStandardToken> get_OnRefreshTokenFinished() { }

	[CompilerGenerated]
	// RVA: 0x89DABE8 Offset: 0x89D6BE8 VA: 0x89DABE8
	public void set_OnRefreshTokenFinished(UnityEvent<UniWebViewAuthenticationStandardToken> value) { }

	[CompilerGenerated]
	// RVA: 0x89DABF0 Offset: 0x89D6BF0 VA: 0x89DABF0 Slot: 15
	public UnityEvent<long, string> get_OnRefreshTokenErrored() { }

	[CompilerGenerated]
	// RVA: 0x89DABF8 Offset: 0x89D6BF8 VA: 0x89DABF8
	public void set_OnRefreshTokenErrored(UnityEvent<long, string> value) { }

	// RVA: 0x89DAC00 Offset: 0x89D6C00 VA: 0x89DAC00
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class UniWebViewAuthenticationFlowCustomizeConfig // TypeDefIndex: 26560
{
	// Fields
	public string authorizationEndpoint; // 0x10
	public string tokenEndpoint; // 0x18
	public string responseType; // 0x20
	public string grantType; // 0x28
	public string refreshTokenGrantType; // 0x30

	// Methods

	// RVA: 0x89DACB4 Offset: 0x89D6CB4 VA: 0x89DACB4
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class UniWebViewAuthenticationFlowCustomizeOptional // TypeDefIndex: 26561
{
	// Fields
	public UniWebViewAuthenticationPKCE PKCESupport; // 0x10
	public bool enableState; // 0x14
	public string clientSecret; // 0x18

	// Methods

	// RVA: 0x89DAD98 Offset: 0x89D6D98 VA: 0x89DAD98
	public void .ctor() { }
}

// Namespace: 
public class UniWebViewAuthenticationFlowDiscord : UniWebViewAuthenticationCommonFlow, IUniWebViewAuthenticationFlow<UniWebViewAuthenticationDiscordToken> // TypeDefIndex: 26562
{
	// Fields
	public string clientId; // 0x38
	public string clientSecret; // 0x40
	public string redirectUri; // 0x48
	public string scope; // 0x50
	public UniWebViewAuthenticationFlowDiscordOptional optional; // 0x58
	private const string responseType = "code";
	private const string grantType = "authorization_code";
	private readonly UniWebViewAuthenticationConfiguration config; // 0x60
	[CompilerGenerated]
	[SerializeField]
	private UnityEvent<UniWebViewAuthenticationDiscordToken> <OnAuthenticationFinished>k__BackingField; // 0x68
	[CompilerGenerated]
	[SerializeField]
	private UnityEvent<long, string> <OnAuthenticationErrored>k__BackingField; // 0x70
	[CompilerGenerated]
	[SerializeField]
	private UnityEvent<UniWebViewAuthenticationDiscordToken> <OnRefreshTokenFinished>k__BackingField; // 0x78
	[CompilerGenerated]
	[SerializeField]
	private UnityEvent<long, string> <OnRefreshTokenErrored>k__BackingField; // 0x80

	// Properties
	public UnityEvent<UniWebViewAuthenticationDiscordToken> OnAuthenticationFinished { get; set; }
	public UnityEvent<long, string> OnAuthenticationErrored { get; set; }
	public UnityEvent<UniWebViewAuthenticationDiscordToken> OnRefreshTokenFinished { get; set; }
	public UnityEvent<long, string> OnRefreshTokenErrored { get; set; }

	// Methods

	// RVA: 0x89DADF0 Offset: 0x89D6DF0 VA: 0x89DADF0 Slot: 4
	public override void StartAuthenticationFlow() { }

	// RVA: 0x89DAE88 Offset: 0x89D6E88 VA: 0x89DAE88 Slot: 5
	public override void StartRefreshTokenFlow(string refreshToken) { }

	// RVA: 0x89DAF28 Offset: 0x89D6F28 VA: 0x89DAF28 Slot: 7
	public UniWebViewAuthenticationConfiguration GetAuthenticationConfiguration() { }

	// RVA: 0x89DAF30 Offset: 0x89D6F30 VA: 0x89DAF30 Slot: 6
	public string GetCallbackUrl() { }

	// RVA: 0x89DAF38 Offset: 0x89D6F38 VA: 0x89DAF38 Slot: 8
	public Dictionary<string, string> GetAuthenticationUriArguments() { }

	// RVA: 0x89DB164 Offset: 0x89D7164 VA: 0x89DB164 Slot: 9
	public Dictionary<string, string> GetAccessTokenRequestParameters(string authResponse) { }

	// RVA: 0x89DB460 Offset: 0x89D7460 VA: 0x89DB460 Slot: 10
	public Dictionary<string, string> GetRefreshTokenRequestParameters(string refreshToken) { }

	// RVA: 0x89DB59C Offset: 0x89D759C VA: 0x89DB59C Slot: 11
	public UniWebViewAuthenticationDiscordToken GenerateTokenFromExchangeResponse(string exchangeResponse) { }

	[CompilerGenerated]
	// RVA: 0x89DB5E4 Offset: 0x89D75E4 VA: 0x89DB5E4 Slot: 12
	public UnityEvent<UniWebViewAuthenticationDiscordToken> get_OnAuthenticationFinished() { }

	[CompilerGenerated]
	// RVA: 0x89DB5EC Offset: 0x89D75EC VA: 0x89DB5EC
	public void set_OnAuthenticationFinished(UnityEvent<UniWebViewAuthenticationDiscordToken> value) { }

	[CompilerGenerated]
	// RVA: 0x89DB5F4 Offset: 0x89D75F4 VA: 0x89DB5F4 Slot: 13
	public UnityEvent<long, string> get_OnAuthenticationErrored() { }

	[CompilerGenerated]
	// RVA: 0x89DB5FC Offset: 0x89D75FC VA: 0x89DB5FC
	public void set_OnAuthenticationErrored(UnityEvent<long, string> value) { }

	[CompilerGenerated]
	// RVA: 0x89DB604 Offset: 0x89D7604 VA: 0x89DB604 Slot: 14
	public UnityEvent<UniWebViewAuthenticationDiscordToken> get_OnRefreshTokenFinished() { }

	[CompilerGenerated]
	// RVA: 0x89DB60C Offset: 0x89D760C VA: 0x89DB60C
	public void set_OnRefreshTokenFinished(UnityEvent<UniWebViewAuthenticationDiscordToken> value) { }

	[CompilerGenerated]
	// RVA: 0x89DB614 Offset: 0x89D7614 VA: 0x89DB614 Slot: 15
	public UnityEvent<long, string> get_OnRefreshTokenErrored() { }

	[CompilerGenerated]
	// RVA: 0x89DB61C Offset: 0x89D761C VA: 0x89DB61C
	public void set_OnRefreshTokenErrored(UnityEvent<long, string> value) { }

	// RVA: 0x89DB624 Offset: 0x89D7624 VA: 0x89DB624
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class UniWebViewAuthenticationFlowDiscordOptional // TypeDefIndex: 26563
{
	// Fields
	public UniWebViewAuthenticationPKCE PKCESupport; // 0x10
	public bool enableState; // 0x14

	// Methods

	// RVA: 0x89DB720 Offset: 0x89D7720 VA: 0x89DB720
	public void .ctor() { }
}

// Namespace: 
public class UniWebViewAuthenticationDiscordToken : UniWebViewAuthenticationStandardToken // TypeDefIndex: 26564
{
	// Methods

	// RVA: 0x89DB734 Offset: 0x89D7734 VA: 0x89DB734
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UniWebViewAuthenticationFlowFacebook.<>c__DisplayClass13_0 // TypeDefIndex: 26565
{
	// Fields
	public UniWebViewAuthenticationFlowFacebook <>4__this; // 0x10
	public UniWebView webView; // 0x18
	public Action <>9__2; // 0x20
	public Action <>9__3; // 0x28

	// Methods

	// RVA: 0x89DB970 Offset: 0x89D7970 VA: 0x89DB970
	public void .ctor() { }

	// RVA: 0x89DC09C Offset: 0x89D809C VA: 0x89DC09C
	internal void <StartAuthenticationFlow>b__0(UniWebView view, int status, string url) { }

	// RVA: 0x89DC854 Offset: 0x89D8854 VA: 0x89DC854
	internal void <StartAuthenticationFlow>b__2() { }

	// RVA: 0x89DC8B0 Offset: 0x89D88B0 VA: 0x89DC8B0
	internal void <StartAuthenticationFlow>b__3() { }

	// RVA: 0x89DC90C Offset: 0x89D890C VA: 0x89DC90C
	internal void <StartAuthenticationFlow>b__1(UniWebView view, int code, string message, UniWebViewNativeResultPayload payload) { }
}

// Namespace: 
public class UniWebViewAuthenticationFlowFacebook : UniWebViewAuthenticationCommonFlow // TypeDefIndex: 26566
{
	// Fields
	public string appId; // 0x38
	public UniWebViewAuthenticationFlowFacebookOptional optional; // 0x40
	private const string redirectUri = "https://www.facebook.com/connect/login_success.html";
	private const string responseType = "token";
	[SerializeField]
	[CompilerGenerated]
	private UnityEvent<UniWebViewAuthenticationFacebookToken> <OnAuthenticationFinished>k__BackingField; // 0x48
	[CompilerGenerated]
	[SerializeField]
	private UnityEvent<long, string> <OnAuthenticationErrored>k__BackingField; // 0x50
	private readonly UniWebViewAuthenticationConfiguration config; // 0x58

	// Properties
	public UnityEvent<UniWebViewAuthenticationFacebookToken> OnAuthenticationFinished { get; set; }
	public UnityEvent<long, string> OnAuthenticationErrored { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x89DB744 Offset: 0x89D7744 VA: 0x89DB744
	public UnityEvent<UniWebViewAuthenticationFacebookToken> get_OnAuthenticationFinished() { }

	[CompilerGenerated]
	// RVA: 0x89DB74C Offset: 0x89D774C VA: 0x89DB74C
	public void set_OnAuthenticationFinished(UnityEvent<UniWebViewAuthenticationFacebookToken> value) { }

	[CompilerGenerated]
	// RVA: 0x89DB754 Offset: 0x89D7754 VA: 0x89DB754
	public UnityEvent<long, string> get_OnAuthenticationErrored() { }

	[CompilerGenerated]
	// RVA: 0x89DB75C Offset: 0x89D775C VA: 0x89DB75C
	public void set_OnAuthenticationErrored(UnityEvent<long, string> value) { }

	// RVA: 0x89DB764 Offset: 0x89D7764 VA: 0x89DB764 Slot: 4
	public override void StartAuthenticationFlow() { }

	// RVA: 0x89DBBD0 Offset: 0x89D7BD0 VA: 0x89DBBD0 Slot: 5
	public override void StartRefreshTokenFlow(string refreshToken) { }

	// RVA: 0x89DB978 Offset: 0x89D7978 VA: 0x89DB978
	private string GetAuthUrl() { }

	// RVA: 0x89DBC2C Offset: 0x89D7C2C VA: 0x89DBC2C
	private Dictionary<string, string> GetAuthenticationUriArguments() { }

	// RVA: 0x89DBFD0 Offset: 0x89D7FD0 VA: 0x89DBFD0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class UniWebViewAuthenticationFlowFacebookOptional // TypeDefIndex: 26567
{
	// Fields
	public string scope; // 0x10

	// Methods

	// RVA: 0x89DC98C Offset: 0x89D898C VA: 0x89DC98C
	public void .ctor() { }
}

// Namespace: 
public class UniWebViewAuthenticationFacebookToken // TypeDefIndex: 26568
{
	// Fields
	[CompilerGenerated]
	private readonly string <AccessToken>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly long <DataAccessExpirationTime>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly long <ExpiresIn>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly string <RawValue>k__BackingField; // 0x28

	// Properties
	public string AccessToken { get; }
	public long DataAccessExpirationTime { get; }
	public long ExpiresIn { get; }
	public string RawValue { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x89DC9E4 Offset: 0x89D89E4 VA: 0x89DC9E4
	public string get_AccessToken() { }

	[CompilerGenerated]
	// RVA: 0x89DC9EC Offset: 0x89D89EC VA: 0x89DC9EC
	public long get_DataAccessExpirationTime() { }

	[CompilerGenerated]
	// RVA: 0x89DC9F4 Offset: 0x89D89F4 VA: 0x89DC9F4
	public long get_ExpiresIn() { }

	[CompilerGenerated]
	// RVA: 0x89DC9FC Offset: 0x89D89FC VA: 0x89DC9FC
	public string get_RawValue() { }

	// RVA: 0x89DC694 Offset: 0x89D8694 VA: 0x89DC694
	public void .ctor(string response, Dictionary<string, string> values) { }
}

// Namespace: 
public class UniWebViewAuthenticationFlowGitHub : UniWebViewAuthenticationCommonFlow, IUniWebViewAuthenticationFlow<UniWebViewAuthenticationGitHubToken> // TypeDefIndex: 26569
{
	// Fields
	public string clientId; // 0x38
	public string clientSecret; // 0x40
	public string callbackUrl; // 0x48
	public UniWebViewAuthenticationFlowGitHubOptional optional; // 0x50
	private readonly UniWebViewAuthenticationConfiguration config; // 0x58
	[SerializeField]
	[CompilerGenerated]
	private UnityEvent<UniWebViewAuthenticationGitHubToken> <OnAuthenticationFinished>k__BackingField; // 0x60
	[SerializeField]
	[CompilerGenerated]
	private UnityEvent<long, string> <OnAuthenticationErrored>k__BackingField; // 0x68
	[SerializeField]
	[CompilerGenerated]
	private UnityEvent<UniWebViewAuthenticationGitHubToken> <OnRefreshTokenFinished>k__BackingField; // 0x70
	[SerializeField]
	[CompilerGenerated]
	private UnityEvent<long, string> <OnRefreshTokenErrored>k__BackingField; // 0x78

	// Properties
	public UnityEvent<UniWebViewAuthenticationGitHubToken> OnAuthenticationFinished { get; set; }
	public UnityEvent<long, string> OnAuthenticationErrored { get; set; }
	public UnityEvent<UniWebViewAuthenticationGitHubToken> OnRefreshTokenFinished { get; set; }
	public UnityEvent<long, string> OnRefreshTokenErrored { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x89DCA04 Offset: 0x89D8A04 VA: 0x89DCA04 Slot: 12
	public UnityEvent<UniWebViewAuthenticationGitHubToken> get_OnAuthenticationFinished() { }

	[CompilerGenerated]
	// RVA: 0x89DCA0C Offset: 0x89D8A0C VA: 0x89DCA0C
	public void set_OnAuthenticationFinished(UnityEvent<UniWebViewAuthenticationGitHubToken> value) { }

	[CompilerGenerated]
	// RVA: 0x89DCA14 Offset: 0x89D8A14 VA: 0x89DCA14 Slot: 13
	public UnityEvent<long, string> get_OnAuthenticationErrored() { }

	[CompilerGenerated]
	// RVA: 0x89DCA1C Offset: 0x89D8A1C VA: 0x89DCA1C
	public void set_OnAuthenticationErrored(UnityEvent<long, string> value) { }

	[CompilerGenerated]
	// RVA: 0x89DCA24 Offset: 0x89D8A24 VA: 0x89DCA24 Slot: 14
	public UnityEvent<UniWebViewAuthenticationGitHubToken> get_OnRefreshTokenFinished() { }

	[CompilerGenerated]
	// RVA: 0x89DCA2C Offset: 0x89D8A2C VA: 0x89DCA2C
	public void set_OnRefreshTokenFinished(UnityEvent<UniWebViewAuthenticationGitHubToken> value) { }

	[CompilerGenerated]
	// RVA: 0x89DCA34 Offset: 0x89D8A34 VA: 0x89DCA34 Slot: 15
	public UnityEvent<long, string> get_OnRefreshTokenErrored() { }

	[CompilerGenerated]
	// RVA: 0x89DCA3C Offset: 0x89D8A3C VA: 0x89DCA3C
	public void set_OnRefreshTokenErrored(UnityEvent<long, string> value) { }

	// RVA: 0x89DCA44 Offset: 0x89D8A44 VA: 0x89DCA44 Slot: 4
	public override void StartAuthenticationFlow() { }

	// RVA: 0x89DCADC Offset: 0x89D8ADC VA: 0x89DCADC Slot: 5
	public override void StartRefreshTokenFlow(string refreshToken) { }

	// RVA: 0x89DCB7C Offset: 0x89D8B7C VA: 0x89DCB7C Slot: 8
	public Dictionary<string, string> GetAuthenticationUriArguments() { }

	// RVA: 0x89DCD98 Offset: 0x89D8D98 VA: 0x89DCD98 Slot: 6
	public string GetCallbackUrl() { }

	// RVA: 0x89DCDA0 Offset: 0x89D8DA0 VA: 0x89DCDA0 Slot: 7
	public UniWebViewAuthenticationConfiguration GetAuthenticationConfiguration() { }

	// RVA: 0x89DCDA8 Offset: 0x89D8DA8 VA: 0x89DCDA8 Slot: 9
	public Dictionary<string, string> GetAccessTokenRequestParameters(string authResponse) { }

	// RVA: 0x89DD054 Offset: 0x89D9054 VA: 0x89DD054 Slot: 10
	public Dictionary<string, string> GetRefreshTokenRequestParameters(string refreshToken) { }

	// RVA: 0x89DD190 Offset: 0x89D9190 VA: 0x89DD190 Slot: 11
	public UniWebViewAuthenticationGitHubToken GenerateTokenFromExchangeResponse(string exchangeResponse) { }

	// RVA: 0x89DD484 Offset: 0x89D9484 VA: 0x89DD484
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class UniWebViewAuthenticationFlowGitHubOptional // TypeDefIndex: 26570
{
	// Fields
	public string redirectUri; // 0x10
	public string login; // 0x18
	public string scope; // 0x20
	public bool enableState; // 0x28
	public bool allowSignup; // 0x29

	// Methods

	// RVA: 0x89DD570 Offset: 0x89D9570 VA: 0x89DD570
	public void .ctor() { }
}

// Namespace: 
public class UniWebViewAuthenticationGitHubToken // TypeDefIndex: 26571
{
	// Fields
	[CompilerGenerated]
	private readonly string <AccessToken>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <Scope>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string <TokenType>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly string <RefreshToken>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly long <RefreshTokenExpiresIn>k__BackingField; // 0x30
	[CompilerGenerated]
	private readonly string <RawValue>k__BackingField; // 0x38

	// Properties
	public string AccessToken { get; }
	public string Scope { get; }
	public string TokenType { get; }
	public string RefreshToken { get; }
	public long RefreshTokenExpiresIn { get; }
	public string RawValue { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x89DD5F0 Offset: 0x89D95F0 VA: 0x89DD5F0
	public string get_AccessToken() { }

	[CompilerGenerated]
	// RVA: 0x89DD5F8 Offset: 0x89D95F8 VA: 0x89DD5F8
	public string get_Scope() { }

	[CompilerGenerated]
	// RVA: 0x89DD600 Offset: 0x89D9600 VA: 0x89DD600
	public string get_TokenType() { }

	[CompilerGenerated]
	// RVA: 0x89DD608 Offset: 0x89D9608 VA: 0x89DD608
	public string get_RefreshToken() { }

	[CompilerGenerated]
	// RVA: 0x89DD610 Offset: 0x89D9610 VA: 0x89DD610
	public long get_RefreshTokenExpiresIn() { }

	[CompilerGenerated]
	// RVA: 0x89DD618 Offset: 0x89D9618 VA: 0x89DD618
	public string get_RawValue() { }

	// RVA: 0x89DD1E8 Offset: 0x89D91E8 VA: 0x89DD1E8
	public void .ctor(string result) { }
}

// Namespace: 
public class UniWebViewAuthenticationFlowGoogle : UniWebViewAuthenticationCommonFlow, IUniWebViewAuthenticationFlow<UniWebViewAuthenticationGoogleToken> // TypeDefIndex: 26572
{
	// Fields
	public string clientId; // 0x38
	public string redirectUri; // 0x40
	public string scope; // 0x48
	public UniWebViewAuthenticationFlowGoogleOptional optional; // 0x50
	private const string responseType = "code";
	private const string grantType = "authorization_code";
	private readonly UniWebViewAuthenticationConfiguration config; // 0x58
	[SerializeField]
	[CompilerGenerated]
	private UnityEvent<UniWebViewAuthenticationGoogleToken> <OnAuthenticationFinished>k__BackingField; // 0x60
	[CompilerGenerated]
	[SerializeField]
	private UnityEvent<long, string> <OnAuthenticationErrored>k__BackingField; // 0x68
	[CompilerGenerated]
	[SerializeField]
	private UnityEvent<UniWebViewAuthenticationGoogleToken> <OnRefreshTokenFinished>k__BackingField; // 0x70
	[CompilerGenerated]
	[SerializeField]
	private UnityEvent<long, string> <OnRefreshTokenErrored>k__BackingField; // 0x78

	// Properties
	public UnityEvent<UniWebViewAuthenticationGoogleToken> OnAuthenticationFinished { get; set; }
	public UnityEvent<long, string> OnAuthenticationErrored { get; set; }
	public UnityEvent<UniWebViewAuthenticationGoogleToken> OnRefreshTokenFinished { get; set; }
	public UnityEvent<long, string> OnRefreshTokenErrored { get; set; }

	// Methods

	// RVA: 0x89DD620 Offset: 0x89D9620 VA: 0x89DD620 Slot: 4
	public override void StartAuthenticationFlow() { }

	// RVA: 0x89DD6B8 Offset: 0x89D96B8 VA: 0x89DD6B8 Slot: 5
	public override void StartRefreshTokenFlow(string refreshToken) { }

	// RVA: 0x89DD758 Offset: 0x89D9758 VA: 0x89DD758 Slot: 7
	public UniWebViewAuthenticationConfiguration GetAuthenticationConfiguration() { }

	// RVA: 0x89DD760 Offset: 0x89D9760 VA: 0x89DD760 Slot: 6
	public string GetCallbackUrl() { }

	// RVA: 0x89DD768 Offset: 0x89D9768 VA: 0x89DD768 Slot: 8
	public Dictionary<string, string> GetAuthenticationUriArguments() { }

	// RVA: 0x89DD9DC Offset: 0x89D99DC VA: 0x89DD9DC Slot: 9
	public Dictionary<string, string> GetAccessTokenRequestParameters(string authResponse) { }

	// RVA: 0x89DDCB0 Offset: 0x89D9CB0 VA: 0x89DDCB0 Slot: 10
	public Dictionary<string, string> GetRefreshTokenRequestParameters(string refreshToken) { }

	// RVA: 0x89DDDBC Offset: 0x89D9DBC VA: 0x89DDDBC Slot: 11
	public UniWebViewAuthenticationGoogleToken GenerateTokenFromExchangeResponse(string exchangeResponse) { }

	[CompilerGenerated]
	// RVA: 0x89DDE04 Offset: 0x89D9E04 VA: 0x89DDE04 Slot: 12
	public UnityEvent<UniWebViewAuthenticationGoogleToken> get_OnAuthenticationFinished() { }

	[CompilerGenerated]
	// RVA: 0x89DDE0C Offset: 0x89D9E0C VA: 0x89DDE0C
	public void set_OnAuthenticationFinished(UnityEvent<UniWebViewAuthenticationGoogleToken> value) { }

	[CompilerGenerated]
	// RVA: 0x89DDE14 Offset: 0x89D9E14 VA: 0x89DDE14 Slot: 13
	public UnityEvent<long, string> get_OnAuthenticationErrored() { }

	[CompilerGenerated]
	// RVA: 0x89DDE1C Offset: 0x89D9E1C VA: 0x89DDE1C
	public void set_OnAuthenticationErrored(UnityEvent<long, string> value) { }

	[CompilerGenerated]
	// RVA: 0x89DDE24 Offset: 0x89D9E24 VA: 0x89DDE24 Slot: 14
	public UnityEvent<UniWebViewAuthenticationGoogleToken> get_OnRefreshTokenFinished() { }

	[CompilerGenerated]
	// RVA: 0x89DDE2C Offset: 0x89D9E2C VA: 0x89DDE2C
	public void set_OnRefreshTokenFinished(UnityEvent<UniWebViewAuthenticationGoogleToken> value) { }

	[CompilerGenerated]
	// RVA: 0x89DDE34 Offset: 0x89D9E34 VA: 0x89DDE34 Slot: 15
	public UnityEvent<long, string> get_OnRefreshTokenErrored() { }

	[CompilerGenerated]
	// RVA: 0x89DDE3C Offset: 0x89D9E3C VA: 0x89DDE3C
	public void set_OnRefreshTokenErrored(UnityEvent<long, string> value) { }

	// RVA: 0x89DDE44 Offset: 0x89D9E44 VA: 0x89DDE44
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class UniWebViewAuthenticationFlowGoogleOptional // TypeDefIndex: 26573
{
	// Fields
	public UniWebViewAuthenticationPKCE PKCESupport; // 0x10
	public bool enableState; // 0x14
	public string loginHint; // 0x18

	// Methods

	// RVA: 0x89DDF30 Offset: 0x89D9F30 VA: 0x89DDF30
	public void .ctor() { }
}

// Namespace: 
public class UniWebViewAuthenticationGoogleToken : UniWebViewAuthenticationStandardToken // TypeDefIndex: 26574
{
	// Methods

	// RVA: 0x89DDF94 Offset: 0x89D9F94 VA: 0x89DDF94
	public void .ctor() { }
}

// Namespace: 
public class UniWebViewAuthenticationFlowLine : UniWebViewAuthenticationCommonFlow, IUniWebViewAuthenticationFlow<UniWebViewAuthenticationLineToken> // TypeDefIndex: 26575
{
	// Fields
	public string clientId; // 0x38
	public string iOSBundleId; // 0x40
	public string androidPackageName; // 0x48
	public string scope; // 0x50
	public UniWebViewAuthenticationFlowLineOptional optional; // 0x58
	private const string responseType = "code";
	private const string grantType = "authorization_code";
	private readonly UniWebViewAuthenticationConfiguration config; // 0x60
	[SerializeField]
	[CompilerGenerated]
	private UnityEvent<UniWebViewAuthenticationLineToken> <OnAuthenticationFinished>k__BackingField; // 0x68
	[SerializeField]
	[CompilerGenerated]
	private UnityEvent<long, string> <OnAuthenticationErrored>k__BackingField; // 0x70
	[SerializeField]
	[CompilerGenerated]
	private UnityEvent<UniWebViewAuthenticationLineToken> <OnRefreshTokenFinished>k__BackingField; // 0x78
	[SerializeField]
	[CompilerGenerated]
	private UnityEvent<long, string> <OnRefreshTokenErrored>k__BackingField; // 0x80

	// Properties
	private string RedirectUri { get; }
	public UnityEvent<UniWebViewAuthenticationLineToken> OnAuthenticationFinished { get; set; }
	public UnityEvent<long, string> OnAuthenticationErrored { get; set; }
	public UnityEvent<UniWebViewAuthenticationLineToken> OnRefreshTokenFinished { get; set; }
	public UnityEvent<long, string> OnRefreshTokenErrored { get; set; }

	// Methods

	// RVA: 0x89DDF9C Offset: 0x89D9F9C VA: 0x89DDF9C
	private string get_RedirectUri() { }

	// RVA: 0x89DE0F0 Offset: 0x89DA0F0 VA: 0x89DE0F0 Slot: 4
	public override void StartAuthenticationFlow() { }

	// RVA: 0x89DE188 Offset: 0x89DA188 VA: 0x89DE188 Slot: 5
	public override void StartRefreshTokenFlow(string refreshToken) { }

	// RVA: 0x89DE228 Offset: 0x89DA228 VA: 0x89DE228 Slot: 7
	public UniWebViewAuthenticationConfiguration GetAuthenticationConfiguration() { }

	// RVA: 0x89DE230 Offset: 0x89DA230 VA: 0x89DE230 Slot: 6
	public string GetCallbackUrl() { }

	// RVA: 0x89DE234 Offset: 0x89DA234 VA: 0x89DE234 Slot: 8
	public Dictionary<string, string> GetAuthenticationUriArguments() { }

	// RVA: 0x89DE31C Offset: 0x89DA31C VA: 0x89DE31C
	private string GenerateReturnUri() { }

	// RVA: 0x89DE5AC Offset: 0x89DA5AC VA: 0x89DE5AC Slot: 9
	public Dictionary<string, string> GetAccessTokenRequestParameters(string authResponse) { }

	// RVA: 0x89DEA90 Offset: 0x89DAA90 VA: 0x89DEA90 Slot: 10
	public Dictionary<string, string> GetRefreshTokenRequestParameters(string refreshToken) { }

	// RVA: 0x89DEB9C Offset: 0x89DAB9C VA: 0x89DEB9C Slot: 11
	public UniWebViewAuthenticationLineToken GenerateTokenFromExchangeResponse(string exchangeResponse) { }

	[CompilerGenerated]
	// RVA: 0x89DEBE4 Offset: 0x89DABE4 VA: 0x89DEBE4 Slot: 12
	public UnityEvent<UniWebViewAuthenticationLineToken> get_OnAuthenticationFinished() { }

	[CompilerGenerated]
	// RVA: 0x89DEBEC Offset: 0x89DABEC VA: 0x89DEBEC
	public void set_OnAuthenticationFinished(UnityEvent<UniWebViewAuthenticationLineToken> value) { }

	[CompilerGenerated]
	// RVA: 0x89DEBF4 Offset: 0x89DABF4 VA: 0x89DEBF4 Slot: 13
	public UnityEvent<long, string> get_OnAuthenticationErrored() { }

	[CompilerGenerated]
	// RVA: 0x89DEBFC Offset: 0x89DABFC VA: 0x89DEBFC
	public void set_OnAuthenticationErrored(UnityEvent<long, string> value) { }

	[CompilerGenerated]
	// RVA: 0x89DEC04 Offset: 0x89DAC04 VA: 0x89DEC04 Slot: 14
	public UnityEvent<UniWebViewAuthenticationLineToken> get_OnRefreshTokenFinished() { }

	[CompilerGenerated]
	// RVA: 0x89DEC0C Offset: 0x89DAC0C VA: 0x89DEC0C
	public void set_OnRefreshTokenFinished(UnityEvent<UniWebViewAuthenticationLineToken> value) { }

	[CompilerGenerated]
	// RVA: 0x89DEC14 Offset: 0x89DAC14 VA: 0x89DEC14 Slot: 15
	public UnityEvent<long, string> get_OnRefreshTokenErrored() { }

	[CompilerGenerated]
	// RVA: 0x89DEC1C Offset: 0x89DAC1C VA: 0x89DEC1C
	public void set_OnRefreshTokenErrored(UnityEvent<long, string> value) { }

	// RVA: 0x89DEC24 Offset: 0x89DAC24 VA: 0x89DEC24
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class UniWebViewAuthenticationFlowLineOptional // TypeDefIndex: 26576
{
	// Fields
	public UniWebViewAuthenticationPKCE PKCESupport; // 0x10

	// Methods

	// RVA: 0x89DED20 Offset: 0x89DAD20 VA: 0x89DED20
	public void .ctor() { }
}

// Namespace: 
public class UniWebViewAuthenticationLineToken : UniWebViewAuthenticationStandardToken // TypeDefIndex: 26577
{
	// Methods

	// RVA: 0x89DED30 Offset: 0x89DAD30 VA: 0x89DED30
	public void .ctor() { }
}

// Namespace: 
public class UniWebViewAuthenticationFlowTwitter : UniWebViewAuthenticationCommonFlow, IUniWebViewAuthenticationFlow<UniWebViewAuthenticationTwitterToken> // TypeDefIndex: 26578
{
	// Fields
	public string clientId; // 0x38
	public string redirectUri; // 0x40
	public string scope; // 0x48
	public UniWebViewAuthenticationFlowTwitterOptional optional; // 0x50
	private const string responseType = "code";
	private const string grantType = "authorization_code";
	private readonly UniWebViewAuthenticationConfiguration config; // 0x58
	[SerializeField]
	[CompilerGenerated]
	private UnityEvent<UniWebViewAuthenticationTwitterToken> <OnAuthenticationFinished>k__BackingField; // 0x60
	[SerializeField]
	[CompilerGenerated]
	private UnityEvent<long, string> <OnAuthenticationErrored>k__BackingField; // 0x68
	[CompilerGenerated]
	[SerializeField]
	private UnityEvent<UniWebViewAuthenticationTwitterToken> <OnRefreshTokenFinished>k__BackingField; // 0x70
	[CompilerGenerated]
	[SerializeField]
	private UnityEvent<long, string> <OnRefreshTokenErrored>k__BackingField; // 0x78

	// Properties
	public UnityEvent<UniWebViewAuthenticationTwitterToken> OnAuthenticationFinished { get; set; }
	public UnityEvent<long, string> OnAuthenticationErrored { get; set; }
	public UnityEvent<UniWebViewAuthenticationTwitterToken> OnRefreshTokenFinished { get; set; }
	public UnityEvent<long, string> OnRefreshTokenErrored { get; set; }

	// Methods

	// RVA: 0x89DED38 Offset: 0x89DAD38 VA: 0x89DED38 Slot: 4
	public override void StartAuthenticationFlow() { }

	// RVA: 0x89DEDD0 Offset: 0x89DADD0 VA: 0x89DEDD0 Slot: 5
	public override void StartRefreshTokenFlow(string refreshToken) { }

	// RVA: 0x89DEE70 Offset: 0x89DAE70 VA: 0x89DEE70 Slot: 7
	public UniWebViewAuthenticationConfiguration GetAuthenticationConfiguration() { }

	// RVA: 0x89DEE78 Offset: 0x89DAE78 VA: 0x89DEE78 Slot: 6
	public string GetCallbackUrl() { }

	// RVA: 0x89DEE80 Offset: 0x89DAE80 VA: 0x89DEE80 Slot: 8
	public Dictionary<string, string> GetAuthenticationUriArguments() { }

	// RVA: 0x89DF0AC Offset: 0x89DB0AC VA: 0x89DF0AC Slot: 9
	public Dictionary<string, string> GetAccessTokenRequestParameters(string authResponse) { }

	// RVA: 0x89DF380 Offset: 0x89DB380 VA: 0x89DF380 Slot: 10
	public Dictionary<string, string> GetRefreshTokenRequestParameters(string refreshToken) { }

	// RVA: 0x89DF48C Offset: 0x89DB48C VA: 0x89DF48C Slot: 11
	public UniWebViewAuthenticationTwitterToken GenerateTokenFromExchangeResponse(string exchangeResponse) { }

	[CompilerGenerated]
	// RVA: 0x89DF4D4 Offset: 0x89DB4D4 VA: 0x89DF4D4 Slot: 12
	public UnityEvent<UniWebViewAuthenticationTwitterToken> get_OnAuthenticationFinished() { }

	[CompilerGenerated]
	// RVA: 0x89DF4DC Offset: 0x89DB4DC VA: 0x89DF4DC
	public void set_OnAuthenticationFinished(UnityEvent<UniWebViewAuthenticationTwitterToken> value) { }

	[CompilerGenerated]
	// RVA: 0x89DF4E4 Offset: 0x89DB4E4 VA: 0x89DF4E4 Slot: 13
	public UnityEvent<long, string> get_OnAuthenticationErrored() { }

	[CompilerGenerated]
	// RVA: 0x89DF4EC Offset: 0x89DB4EC VA: 0x89DF4EC
	public void set_OnAuthenticationErrored(UnityEvent<long, string> value) { }

	[CompilerGenerated]
	// RVA: 0x89DF4F4 Offset: 0x89DB4F4 VA: 0x89DF4F4 Slot: 14
	public UnityEvent<UniWebViewAuthenticationTwitterToken> get_OnRefreshTokenFinished() { }

	[CompilerGenerated]
	// RVA: 0x89DF4FC Offset: 0x89DB4FC VA: 0x89DF4FC
	public void set_OnRefreshTokenFinished(UnityEvent<UniWebViewAuthenticationTwitterToken> value) { }

	[CompilerGenerated]
	// RVA: 0x89DF504 Offset: 0x89DB504 VA: 0x89DF504 Slot: 15
	public UnityEvent<long, string> get_OnRefreshTokenErrored() { }

	[CompilerGenerated]
	// RVA: 0x89DF50C Offset: 0x89DB50C VA: 0x89DF50C
	public void set_OnRefreshTokenErrored(UnityEvent<long, string> value) { }

	// RVA: 0x89DF514 Offset: 0x89DB514 VA: 0x89DF514
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class UniWebViewAuthenticationFlowTwitterOptional // TypeDefIndex: 26579
{
	// Fields
	public UniWebViewAuthenticationPKCE PKCESupport; // 0x10
	public bool enableState; // 0x14

	// Methods

	// RVA: 0x89DF600 Offset: 0x89DB600 VA: 0x89DF600
	public void .ctor() { }
}

// Namespace: 
public class UniWebViewAuthenticationTwitterToken : UniWebViewAuthenticationStandardToken // TypeDefIndex: 26580
{
	// Methods

	// RVA: 0x89DF614 Offset: 0x89DB614 VA: 0x89DF614
	public void .ctor() { }
}

// Namespace: 
public sealed class UniWebViewAuthenticationSession.AuthenticationFinishedDelegate : MulticastDelegate // TypeDefIndex: 26581
{
	// Methods

	// RVA: 0x89DFE00 Offset: 0x89DBE00 VA: 0x89DFE00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89DFF0C Offset: 0x89DBF0C VA: 0x89DFF0C Slot: 13
	public virtual void Invoke(UniWebViewAuthenticationSession session, string url) { }

	// RVA: 0x89DFF20 Offset: 0x89DBF20 VA: 0x89DFF20 Slot: 14
	public virtual IAsyncResult BeginInvoke(UniWebViewAuthenticationSession session, string url, AsyncCallback callback, object object) { }

	// RVA: 0x89DFF48 Offset: 0x89DBF48 VA: 0x89DFF48 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class UniWebViewAuthenticationSession.AuthErrorReceivedDelegate : MulticastDelegate // TypeDefIndex: 26582
{
	// Methods

	// RVA: 0x89DFF54 Offset: 0x89DBF54 VA: 0x89DFF54
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89E0060 Offset: 0x89DC060 VA: 0x89E0060 Slot: 13
	public virtual void Invoke(UniWebViewAuthenticationSession session, int errorCode, string errorMessage) { }

	// RVA: 0x89E0074 Offset: 0x89DC074 VA: 0x89E0074 Slot: 14
	public virtual IAsyncResult BeginInvoke(UniWebViewAuthenticationSession session, int errorCode, string errorMessage, AsyncCallback callback, object object) { }

	// RVA: 0x89E010C Offset: 0x89DC10C VA: 0x89E010C Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public class UniWebViewAuthenticationSession : Object // TypeDefIndex: 26583
{
	// Fields
	[CompilerGenerated]
	private UniWebViewAuthenticationSession.AuthenticationFinishedDelegate OnAuthenticationFinished; // 0x18
	[CompilerGenerated]
	private UniWebViewAuthenticationSession.AuthErrorReceivedDelegate OnAuthenticationErrorReceived; // 0x20
	private readonly string id; // 0x28
	private UniWebViewNativeListener listener; // 0x30
	[CompilerGenerated]
	private string <Url>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <CallbackScheme>k__BackingField; // 0x40

	// Properties
	public string Url { get; set; }
	public string CallbackScheme { get; set; }
	public static bool IsAuthenticationSupported { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x89DF61C Offset: 0x89DB61C VA: 0x89DF61C
	public void add_OnAuthenticationFinished(UniWebViewAuthenticationSession.AuthenticationFinishedDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x89DF6B8 Offset: 0x89DB6B8 VA: 0x89DF6B8
	public void remove_OnAuthenticationFinished(UniWebViewAuthenticationSession.AuthenticationFinishedDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x89DF754 Offset: 0x89DB754 VA: 0x89DF754
	public void add_OnAuthenticationErrorReceived(UniWebViewAuthenticationSession.AuthErrorReceivedDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x89DF7F0 Offset: 0x89DB7F0 VA: 0x89DF7F0
	public void remove_OnAuthenticationErrorReceived(UniWebViewAuthenticationSession.AuthErrorReceivedDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x89DF88C Offset: 0x89DB88C VA: 0x89DF88C
	public string get_Url() { }

	[CompilerGenerated]
	// RVA: 0x89DF894 Offset: 0x89DB894 VA: 0x89DF894
	private void set_Url(string value) { }

	[CompilerGenerated]
	// RVA: 0x89DF89C Offset: 0x89DB89C VA: 0x89DF89C
	public string get_CallbackScheme() { }

	[CompilerGenerated]
	// RVA: 0x89DF8A4 Offset: 0x89DB8A4 VA: 0x89DF8A4
	private void set_CallbackScheme(string value) { }

	// RVA: 0x89DF8AC Offset: 0x89DB8AC VA: 0x89DF8AC
	internal void InternalAuthenticationFinished(string url) { }

	// RVA: 0x89DF984 Offset: 0x89DB984 VA: 0x89DF984
	internal void InternalAuthenticationErrorReceived(UniWebViewNativeResultPayload payload) { }

	// RVA: 0x89DFA98 Offset: 0x89DBA98 VA: 0x89DFA98
	private void .ctor() { }

	// RVA: 0x89DFBEC Offset: 0x89DBBEC VA: 0x89DFBEC
	public static bool get_IsAuthenticationSupported() { }

	// RVA: 0x89DFC38 Offset: 0x89DBC38 VA: 0x89DFC38
	public static UniWebViewAuthenticationSession Create(string url, string callbackScheme) { }

	// RVA: 0x89DFD20 Offset: 0x89DBD20 VA: 0x89DFD20
	public void Start() { }

	// RVA: 0x89DFD8C Offset: 0x89DBD8C VA: 0x89DFD8C
	public void SetPrivateMode(bool flag) { }
}

// Namespace: 
[Serializable]
public class UniWebViewAuthenticationStandardToken // TypeDefIndex: 26584
{
	// Fields
	[SerializeField]
	private string access_token; // 0x10
	[SerializeField]
	private string scope; // 0x18
	[SerializeField]
	private string token_type; // 0x20
	[SerializeField]
	private string refresh_token; // 0x28
	[SerializeField]
	private long expires_in; // 0x30
	[SerializeField]
	private string id_token; // 0x38
	[CompilerGenerated]
	private string <RawValue>k__BackingField; // 0x40

	// Properties
	public string AccessToken { get; }
	public string Scope { get; }
	public string TokenType { get; }
	public string RefreshToken { get; }
	public long ExpiresIn { get; }
	public string IdToken { get; }
	public string RawValue { get; set; }

	// Methods

	// RVA: 0x89E0118 Offset: 0x89DC118 VA: 0x89E0118
	public string get_AccessToken() { }

	// RVA: 0x89E0120 Offset: 0x89DC120 VA: 0x89E0120
	public string get_Scope() { }

	// RVA: 0x89E0128 Offset: 0x89DC128 VA: 0x89E0128
	public string get_TokenType() { }

	// RVA: 0x89E0130 Offset: 0x89DC130 VA: 0x89E0130
	public string get_RefreshToken() { }

	// RVA: 0x89E0138 Offset: 0x89DC138 VA: 0x89E0138
	public long get_ExpiresIn() { }

	// RVA: 0x89E0140 Offset: 0x89DC140 VA: 0x89E0140
	public string get_IdToken() { }

	[CompilerGenerated]
	// RVA: 0x89E0148 Offset: 0x89DC148 VA: 0x89E0148
	public string get_RawValue() { }

	[CompilerGenerated]
	// RVA: 0x89E0150 Offset: 0x89DC150 VA: 0x89E0150
	public void set_RawValue(string value) { }

	// RVA: 0x89DB73C Offset: 0x89D773C VA: 0x89DB73C
	public void .ctor() { }
}

// Namespace: 
public abstract class UniWebViewAuthenticationTokenFactory<TToken> // TypeDefIndex: 26585
{
	// Methods

	// RVA: -1 Offset: -1
	public static TToken Parse(string result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56B7D88 Offset: 0x56B3D88 VA: 0x56B7D88
	|-UniWebViewAuthenticationTokenFactory<object>.Parse
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56B7E24 Offset: 0x56B3E24 VA: 0x56B7E24
	|-UniWebViewAuthenticationTokenFactory<object>..ctor
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class UniWebViewAuthenticationUtils.<>c__DisplayClass6_0 // TypeDefIndex: 26586
{
	// Fields
	public Random random; // 0x10

	// Methods

	// RVA: 0x89E04A4 Offset: 0x89DC4A4 VA: 0x89E04A4
	public void .ctor() { }

	// RVA: 0x89E054C Offset: 0x89DC54C VA: 0x89E054C
	internal char <GenerateCodeVerifier>b__0(string s) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UniWebViewAuthenticationUtils.<>c__DisplayClass9_0 // TypeDefIndex: 26587
{
	// Fields
	public string scheme; // 0x10

	// Methods

	// RVA: 0x89E04AC Offset: 0x89DC4AC VA: 0x89E04AC
	public void .ctor() { }

	// RVA: 0x89E0588 Offset: 0x89DC588 VA: 0x89E0588
	internal void <ConvertIntentUri>b__0(string fragment) { }
}

// Namespace: 
public class UniWebViewAuthenticationUtils // TypeDefIndex: 26588
{
	// Fields
	private static readonly char[] padding; // 0x0

	// Methods

	// RVA: 0x89DA868 Offset: 0x89D6868 VA: 0x89DA868
	internal static Dictionary<string, string> ParseFormUrlEncodedString(string input) { }

	// RVA: 0x89E0158 Offset: 0x89DC158 VA: 0x89E0158
	public static string GenerateRandomBase64String() { }

	// RVA: 0x89D98C0 Offset: 0x89D58C0 VA: 0x89D98C0
	public static string GenerateRandomBase64URLString() { }

	// RVA: 0x89E034C Offset: 0x89DC34C VA: 0x89E034C
	public static string ConvertToBase64URLString(string input) { }

	// RVA: 0x89E03E0 Offset: 0x89DC3E0 VA: 0x89E03E0
	public static string ConvertToBase64String(string input) { }

	// RVA: 0x89D998C Offset: 0x89D598C VA: 0x89D998C
	public static string GenerateCodeVerifier(int length = 64) { }

	// RVA: 0x89D9CAC Offset: 0x89D5CAC VA: 0x89D9CAC
	public static string CalculateCodeChallenge(string codeVerifier, UniWebViewAuthenticationPKCE method) { }

	// RVA: 0x89DA4EC Offset: 0x89D64EC VA: 0x89DA4EC
	public static string ConvertPKCEToString(UniWebViewAuthenticationPKCE method) { }

	// RVA: 0x89DE8A4 Offset: 0x89DA8A4 VA: 0x89DE8A4
	public static string ConvertIntentUri(string input) { }

	// RVA: 0x89DBDEC Offset: 0x89D7DEC VA: 0x89DBDEC
	public static string CreateQueryString(Dictionary<string, string> collection) { }

	// RVA: 0x89E04B4 Offset: 0x89DC4B4 VA: 0x89E04B4
	public void .ctor() { }

	// RVA: 0x89E04BC Offset: 0x89DC4BC VA: 0x89E04BC
	private static void .cctor() { }
}

// Namespace: 
public enum UniWebViewAuthenticationPKCE // TypeDefIndex: 26589
{
	// Fields
	public int value__; // 0x0
	public const UniWebViewAuthenticationPKCE None = 0;
	public const UniWebViewAuthenticationPKCE S256 = 1;
	public const UniWebViewAuthenticationPKCE Plain = 2;
}

// Namespace: 
public enum UniWebViewCacheMode // TypeDefIndex: 26590
{
	// Fields
	public int value__; // 0x0
	public const UniWebViewCacheMode Default = 0;
	public const UniWebViewCacheMode NoCache = 1;
	public const UniWebViewCacheMode CacheElseLoad = 2;
	public const UniWebViewCacheMode CacheOnly = 3;
}

// Namespace: 
[Serializable]
public class UniWebViewChannelMethodHandleRequest // TypeDefIndex: 26591
{
	// Fields
	[SerializeField]
	private string url; // 0x10

	// Properties
	public string Url { get; }

	// Methods

	// RVA: 0x89E0638 Offset: 0x89DC638 VA: 0x89E0638
	public string get_Url() { }

	// RVA: 0x89E0640 Offset: 0x89DC640 VA: 0x89E0640
	public void .ctor() { }
}

// Namespace: 
internal enum UniWebViewChannelMethod // TypeDefIndex: 26592
{
	// Fields
	public int value__; // 0x0
	public const UniWebViewChannelMethod ShouldUniWebViewHandleRequest = 0;
	public const UniWebViewChannelMethod RequestMediaCapturePermission = 1;
}

// Namespace: 
[CompilerGenerated]
private struct UniWebViewChannelMethodManager.<>c__DisplayClass9_0 // TypeDefIndex: 26593
{
	// Fields
	public Func<object, object> func; // 0x0
}

// Namespace: 
internal class UniWebViewChannelMethodManager // TypeDefIndex: 26594
{
	// Fields
	private static UniWebViewChannelMethodManager instance; // 0x0
	private Dictionary<string, Dictionary<string, Func<object, object>>> channels; // 0x10

	// Properties
	internal static UniWebViewChannelMethodManager Instance { get; }

	// Methods

	// RVA: 0x89C82FC Offset: 0x89C42FC VA: 0x89C82FC
	internal static UniWebViewChannelMethodManager get_Instance() { }

	// RVA: 0x89D6474 Offset: 0x89D2474 VA: 0x89D6474
	internal void RegisterChannelMethod(string webViewName, UniWebViewChannelMethod method, Func<object, object> handler) { }

	// RVA: 0x89D6A70 Offset: 0x89D2A70 VA: 0x89D6A70
	internal void UnregisterChannel(string webViewName) { }

	// RVA: 0x89D6668 Offset: 0x89D2668 VA: 0x89D6668
	internal void UnregisterChannelMethod(string webViewName, UniWebViewChannelMethod method) { }

	// RVA: 0x89E06D0 Offset: 0x89DC6D0 VA: 0x89E06D0
	private bool HasRegisteredChannel(string webViewName) { }

	// RVA: 0x89E0750 Offset: 0x89DC750 VA: 0x89E0750
	private bool HasRegisteredMethod(string webViewName, string methodName) { }

	// RVA: 0x89C8380 Offset: 0x89C4380 VA: 0x89C8380
	internal string InvokeMethod(string webViewName, string methodName, string parameters) { }

	// RVA: 0x89E08A4 Offset: 0x89DC8A4 VA: 0x89E08A4
	private string ResultJsonWith(bool value) { }

	// RVA: 0x89E0998 Offset: 0x89DC998 VA: 0x89E0998
	private string ResultJsonWith(UniWebViewMediaCapturePermissionDecision decision) { }

	// RVA: 0x89E0648 Offset: 0x89DC648 VA: 0x89E0648
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x89E0818 Offset: 0x89DC818 VA: 0x89E0818
	internal static bool <InvokeMethod>g__Func|9_0(UniWebViewChannelMethodHandleRequest i, ref UniWebViewChannelMethodManager.<>c__DisplayClass9_0 ) { }

	[CompilerGenerated]
	// RVA: 0x89E090C Offset: 0x89DC90C VA: 0x89E090C
	internal static UniWebViewMediaCapturePermissionDecision <InvokeMethod>g__Func|9_1(UniWebViewChannelMethodMediaCapturePermission i, ref UniWebViewChannelMethodManager.<>c__DisplayClass9_0 ) { }
}

// Namespace: 
[Serializable]
public class UniWebViewChannelMethodMediaCapturePermission // TypeDefIndex: 26595
{
	// Fields
	[SerializeField]
	private string protocol; // 0x10
	[SerializeField]
	private string host; // 0x18
	[SerializeField]
	private int port; // 0x20
	[SerializeField]
	private string[] resources; // 0x28

	// Properties
	public string Protocol { get; }
	public string Host { get; }
	public int Port { get; }
	public string[] Resources { get; }

	// Methods

	// RVA: 0x89E0AA0 Offset: 0x89DCAA0 VA: 0x89E0AA0
	public string get_Protocol() { }

	// RVA: 0x89E0AA8 Offset: 0x89DCAA8 VA: 0x89E0AA8
	public string get_Host() { }

	// RVA: 0x89E0AB0 Offset: 0x89DCAB0 VA: 0x89E0AB0
	public int get_Port() { }

	// RVA: 0x89E0AB8 Offset: 0x89DCAB8 VA: 0x89E0AB8
	public string[] get_Resources() { }

	// RVA: 0x89E0AC0 Offset: 0x89DCAC0 VA: 0x89E0AC0
	public void .ctor() { }
}

// Namespace: 
public enum UniWebViewMediaCapturePermissionDecision // TypeDefIndex: 26596
{
	// Fields
	public int value__; // 0x0
	public const UniWebViewMediaCapturePermissionDecision Prompt = 0;
	public const UniWebViewMediaCapturePermissionDecision Grant = 1;
	public const UniWebViewMediaCapturePermissionDecision Deny = 2;
}

// Namespace: 
public enum UniWebViewContentInsetAdjustmentBehavior // TypeDefIndex: 26597
{
	// Fields
	public int value__; // 0x0
	public const UniWebViewContentInsetAdjustmentBehavior Automatic = 0;
	public const UniWebViewContentInsetAdjustmentBehavior ScrollableAxes = 1;
	public const UniWebViewContentInsetAdjustmentBehavior Never = 2;
	public const UniWebViewContentInsetAdjustmentBehavior Always = 3;
}

// Namespace: 
public enum UniWebViewDownloadMatchingType // TypeDefIndex: 26598
{
	// Fields
	public int value__; // 0x0
	public const UniWebViewDownloadMatchingType ExactValue = 1;
	public const UniWebViewDownloadMatchingType RegularExpression = 2;
}

// Namespace: 
public class UniWebViewEmbeddedToolbar // TypeDefIndex: 26599
{
	// Fields
	private readonly UniWebViewNativeListener listener; // 0x10

	// Methods

	// RVA: 0x89D36BC Offset: 0x89CF6BC VA: 0x89D36BC
	internal void .ctor(UniWebViewNativeListener listener) { }

	// RVA: 0x89D37EC Offset: 0x89CF7EC VA: 0x89D37EC
	public void SetPosition(UniWebViewToolbarPosition position) { }

	// RVA: 0x89D3864 Offset: 0x89CF864 VA: 0x89D3864
	public void Show() { }

	// RVA: 0x89E0AC8 Offset: 0x89DCAC8 VA: 0x89E0AC8
	public void Hide() { }

	// RVA: 0x89E0B38 Offset: 0x89DCB38 VA: 0x89E0B38
	public void SetDoneButtonText(string text) { }

	// RVA: 0x89E0BAC Offset: 0x89DCBAC VA: 0x89E0BAC
	public void SetGoBackButtonText(string text) { }

	// RVA: 0x89E0C20 Offset: 0x89DCC20 VA: 0x89E0C20
	public void SetGoForwardButtonText(string text) { }

	// RVA: 0x89E0C94 Offset: 0x89DCC94 VA: 0x89E0C94
	public void SetTitleText(string text) { }

	// RVA: 0x89E0D08 Offset: 0x89DCD08 VA: 0x89E0D08
	public void SetBackgroundColor(Color color) { }

	// RVA: 0x89E0DA4 Offset: 0x89DCDA4 VA: 0x89E0DA4
	public void SetButtonTextColor(Color color) { }

	// RVA: 0x89E0E40 Offset: 0x89DCE40 VA: 0x89E0E40
	public void SetTitleTextColor(Color color) { }

	// RVA: 0x89E0EDC Offset: 0x89DCEDC VA: 0x89E0EDC
	public void HideNavigationButtons() { }

	// RVA: 0x89E0F4C Offset: 0x89DCF4C VA: 0x89E0F4C
	public void ShowNavigationButtons() { }
}

// Namespace: 
public class UniWebViewHelper // TypeDefIndex: 26600
{
	// Properties
	internal static bool IsEditor { get; }

	// Methods

	// RVA: 0x89E0FBC Offset: 0x89DCFBC VA: 0x89E0FBC
	public static string StreamingAssetURLForPath(string path) { }

	// RVA: 0x89E102C Offset: 0x89DD02C VA: 0x89E102C
	public static string PersistentDataURLForPath(string path) { }

	// RVA: 0x89E10E4 Offset: 0x89DD0E4 VA: 0x89E10E4
	internal static bool get_IsEditor() { }

	// RVA: 0x89E10EC Offset: 0x89DD0EC VA: 0x89E10EC
	public void .ctor() { }
}

// Namespace: 
public enum UniWebViewLogger.Level // TypeDefIndex: 26601
{
	// Fields
	public int value__; // 0x0
	public const UniWebViewLogger.Level Verbose = 0;
	public const UniWebViewLogger.Level Debug = 10;
	public const UniWebViewLogger.Level Info = 20;
	public const UniWebViewLogger.Level Critical = 80;
	public const UniWebViewLogger.Level Off = 99;
}

// Namespace: 
public class UniWebViewLogger // TypeDefIndex: 26602
{
	// Fields
	private static UniWebViewLogger instance; // 0x0
	private UniWebViewLogger.Level level; // 0x10

	// Properties
	public UniWebViewLogger.Level LogLevel { get; set; }
	public static UniWebViewLogger Instance { get; }

	// Methods

	// RVA: 0x89E10F4 Offset: 0x89DD0F4 VA: 0x89E10F4
	public UniWebViewLogger.Level get_LogLevel() { }

	// RVA: 0x89E10FC Offset: 0x89DD0FC VA: 0x89E10FC
	public void set_LogLevel(UniWebViewLogger.Level value) { }

	// RVA: 0x89E12A8 Offset: 0x89DD2A8 VA: 0x89E12A8
	private void .ctor(UniWebViewLogger.Level level) { }

	// RVA: 0x89C8260 Offset: 0x89C4260 VA: 0x89C8260
	public static UniWebViewLogger get_Instance() { }

	// RVA: 0x89C82F0 Offset: 0x89C42F0 VA: 0x89C82F0
	public void Verbose(string message) { }

	// RVA: 0x89E0744 Offset: 0x89DC744 VA: 0x89E0744
	public void Debug(string message) { }

	// RVA: 0x89C8A9C Offset: 0x89C4A9C VA: 0x89C8A9C
	public void Info(string message) { }

	// RVA: 0x89D33D0 Offset: 0x89CF3D0 VA: 0x89D33D0
	public void Critical(string message) { }

	// RVA: 0x89E11DC Offset: 0x89DD1DC VA: 0x89E11DC
	private void Log(UniWebViewLogger.Level targetLevel, string message) { }
}

// Namespace: 
public struct UniWebViewMessage // TypeDefIndex: 26603
{
	// Fields
	[CompilerGenerated]
	private string <RawMessage>k__BackingField; // 0x0
	[CompilerGenerated]
	private string <Scheme>k__BackingField; // 0x8
	[CompilerGenerated]
	private string <Path>k__BackingField; // 0x10
	[CompilerGenerated]
	private Dictionary<string, string> <Args>k__BackingField; // 0x18

	// Properties
	public string RawMessage { get; set; }
	public string Scheme { get; set; }
	public string Path { get; set; }
	public Dictionary<string, string> Args { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x89E12D0 Offset: 0x89DD2D0 VA: 0x89E12D0
	public string get_RawMessage() { }

	[CompilerGenerated]
	// RVA: 0x89E12D8 Offset: 0x89DD2D8 VA: 0x89E12D8
	private void set_RawMessage(string value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x89E12E0 Offset: 0x89DD2E0 VA: 0x89E12E0
	public string get_Scheme() { }

	[CompilerGenerated]
	// RVA: 0x89E12E8 Offset: 0x89DD2E8 VA: 0x89E12E8
	private void set_Scheme(string value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x89E12F0 Offset: 0x89DD2F0 VA: 0x89E12F0
	public string get_Path() { }

	[CompilerGenerated]
	// RVA: 0x89E12F8 Offset: 0x89DD2F8 VA: 0x89E12F8
	private void set_Path(string value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x89E1300 Offset: 0x89DD300 VA: 0x89E1300
	public Dictionary<string, string> get_Args() { }

	[CompilerGenerated]
	// RVA: 0x89E1308 Offset: 0x89DD308 VA: 0x89E1308
	private void set_Args(Dictionary<string, string> value) { }

	// RVA: 0x89D71CC Offset: 0x89D31CC VA: 0x89D71CC
	public void .ctor(string rawMessage) { }
}

// Namespace: 
public class UniWebViewNativeListener : MonoBehaviour // TypeDefIndex: 26604
{
	// Fields
	private static Dictionary<string, UniWebViewNativeListener> listeners; // 0x0
	[HideInInspector]
	public UniWebView webView; // 0x20
	[HideInInspector]
	public UniWebViewSafeBrowsing safeBrowsing; // 0x28
	[HideInInspector]
	public UniWebViewAuthenticationSession session; // 0x30

	// Properties
	public string Name { get; }

	// Methods

	// RVA: 0x89D3628 Offset: 0x89CF628 VA: 0x89D3628
	public static void AddListener(UniWebViewNativeListener target) { }

	// RVA: 0x89D69F0 Offset: 0x89D29F0 VA: 0x89D69F0
	public static void RemoveListener(string name) { }

	// RVA: 0x89D1D30 Offset: 0x89CDD30 VA: 0x89D1D30
	public static UniWebViewNativeListener GetListener(string name) { }

	// RVA: 0x89D3078 Offset: 0x89CF078 VA: 0x89D3078
	public string get_Name() { }

	// RVA: 0x89E1310 Offset: 0x89DD310 VA: 0x89E1310
	public void PageStarted(string url) { }

	// RVA: 0x89E13C0 Offset: 0x89DD3C0 VA: 0x89E13C0
	public void PageFinished(string result) { }

	// RVA: 0x89E1470 Offset: 0x89DD470 VA: 0x89E1470
	public void PageErrorReceived(string result) { }

	// RVA: 0x89E1520 Offset: 0x89DD520 VA: 0x89E1520
	public void PageProgressChanged(string result) { }

	// RVA: 0x89E157C Offset: 0x89DD57C VA: 0x89E157C
	public void ShowTransitionFinished(string identifer) { }

	// RVA: 0x89E1608 Offset: 0x89DD608 VA: 0x89E1608
	public void HideTransitionFinished(string identifer) { }

	// RVA: 0x89E1694 Offset: 0x89DD694 VA: 0x89E1694
	public void AnimateToFinished(string identifer) { }

	// RVA: 0x89E1720 Offset: 0x89DD720 VA: 0x89E1720
	public void AddJavaScriptFinished(string result) { }

	// RVA: 0x89E17D0 Offset: 0x89DD7D0 VA: 0x89E17D0
	public void EvalJavaScriptFinished(string result) { }

	// RVA: 0x89E1880 Offset: 0x89DD880 VA: 0x89E1880
	public void MessageReceived(string result) { }

	// RVA: 0x89E190C Offset: 0x89DD90C VA: 0x89E190C
	public void WebViewDone(string param) { }

	// RVA: 0x89E196C Offset: 0x89DD96C VA: 0x89E196C
	public void WebContentProcessDidTerminate(string param) { }

	// RVA: 0x89E19EC Offset: 0x89DD9EC VA: 0x89E19EC
	public void SafeBrowsingFinished(string param) { }

	// RVA: 0x89E1B1C Offset: 0x89DDB1C VA: 0x89E1B1C
	public void MultipleWindowOpened(string param) { }

	// RVA: 0x89E1BCC Offset: 0x89DDBCC VA: 0x89E1BCC
	public void MultipleWindowClosed(string param) { }

	// RVA: 0x89E1C7C Offset: 0x89DDC7C VA: 0x89E1C7C
	public void FileDownloadStarted(string result) { }

	// RVA: 0x89E1D2C Offset: 0x89DDD2C VA: 0x89E1D2C
	public void FileDownloadFinished(string result) { }

	// RVA: 0x89E1DDC Offset: 0x89DDDDC VA: 0x89E1DDC
	public void CaptureSnapshotFinished(string result) { }

	// RVA: 0x89E1E8C Offset: 0x89DDE8C VA: 0x89E1E8C
	public void AuthFinished(string result) { }

	// RVA: 0x89E1F18 Offset: 0x89DDF18 VA: 0x89E1F18
	public void AuthErrorReceived(string result) { }

	// RVA: 0x89E1FC8 Offset: 0x89DDFC8 VA: 0x89E1FC8
	public void SnapshotRenderingStarted(string identifier) { }

	// RVA: 0x89E2054 Offset: 0x89DE054 VA: 0x89E2054
	public void .ctor() { }

	// RVA: 0x89E205C Offset: 0x89DE05C VA: 0x89E205C
	private static void .cctor() { }
}

// Namespace: 
[Serializable]
public class UniWebViewNativeResultPayload // TypeDefIndex: 26605
{
	// Fields
	public const string ExtraFailingURLKey = "failingURL";
	public string identifier; // 0x10
	public string resultCode; // 0x18
	public string data; // 0x20
	public string extra; // 0x28

	// Properties
	public Dictionary<string, object> Extra { get; }

	// Methods

	// RVA: 0x89E20F4 Offset: 0x89DE0F4 VA: 0x89E20F4
	public Dictionary<string, object> get_Extra() { }

	// RVA: 0x89E219C Offset: 0x89DE19C VA: 0x89E219C
	public void .ctor() { }
}

// Namespace: 
public class UniWebViewSafeBrowingComponent : MonoBehaviour // TypeDefIndex: 26606
{
	// Fields
	[SerializeField]
	private string url; // 0x20

	// Methods

	// RVA: 0x89E21A4 Offset: 0x89DE1A4 VA: 0x89E21A4
	private void Start() { }

	// RVA: 0x89E23A0 Offset: 0x89DE3A0 VA: 0x89E23A0
	public void .ctor() { }
}

// Namespace: 
public sealed class UniWebViewSafeBrowsing.OnSafeBrowsingFinishedDelegate : MulticastDelegate // TypeDefIndex: 26607
{
	// Methods

	// RVA: 0x89E2768 Offset: 0x89DE768 VA: 0x89E2768
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89E2870 Offset: 0x89DE870 VA: 0x89E2870 Slot: 13
	public virtual void Invoke(UniWebViewSafeBrowsing browsing) { }

	// RVA: 0x89E2884 Offset: 0x89DE884 VA: 0x89E2884 Slot: 14
	public virtual IAsyncResult BeginInvoke(UniWebViewSafeBrowsing browsing, AsyncCallback callback, object object) { }

	// RVA: 0x89E28A4 Offset: 0x89DE8A4 VA: 0x89E28A4 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public class UniWebViewSafeBrowsing : Object // TypeDefIndex: 26608
{
	// Fields
	[CompilerGenerated]
	private UniWebViewSafeBrowsing.OnSafeBrowsingFinishedDelegate OnSafeBrowsingFinished; // 0x18
	private string id; // 0x20
	private UniWebViewNativeListener listener; // 0x28
	private string url; // 0x30

	// Properties
	public static bool IsSafeBrowsingSupported { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x89E23A8 Offset: 0x89DE3A8 VA: 0x89E23A8
	public void add_OnSafeBrowsingFinished(UniWebViewSafeBrowsing.OnSafeBrowsingFinishedDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x89E2444 Offset: 0x89DE444 VA: 0x89E2444
	public void remove_OnSafeBrowsingFinished(UniWebViewSafeBrowsing.OnSafeBrowsingFinishedDelegate value) { }

	// RVA: 0x89E24E0 Offset: 0x89DE4E0 VA: 0x89E24E0
	public static bool get_IsSafeBrowsingSupported() { }

	// RVA: 0x89E223C Offset: 0x89DE23C VA: 0x89E223C
	public static UniWebViewSafeBrowsing Create(string url) { }

	// RVA: 0x89E22C8 Offset: 0x89DE2C8 VA: 0x89E22C8
	public void Show() { }

	// RVA: 0x89E26CC Offset: 0x89DE6CC VA: 0x89E26CC
	public void Dismiss() { }

	// RVA: 0x89E26D0 Offset: 0x89DE6D0 VA: 0x89E26D0
	public void SetToolbarColor(Color color) { }

	// RVA: 0x89E2764 Offset: 0x89DE764 VA: 0x89E2764
	public void SetToolbarItemColor(Color color) { }

	// RVA: 0x89E252C Offset: 0x89DE52C VA: 0x89E252C
	private void .ctor() { }

	// RVA: 0x89E2658 Offset: 0x89DE658 VA: 0x89E2658
	private void Init(string url) { }

	// RVA: 0x89E1A4C Offset: 0x89DDA4C VA: 0x89E1A4C
	internal void InternalSafeBrowsingFinished() { }
}

// Namespace: 
public class UniWebViewStaticListener // TypeDefIndex: 26609
{
	// Methods

	// RVA: 0x89E28B0 Offset: 0x89DE8B0 VA: 0x89E28B0
	public static void DebugLog(string value) { }

	// RVA: 0x89E2A8C Offset: 0x89DEA8C VA: 0x89E2A8C
	public void .ctor() { }
}

// Namespace: 
public enum UniWebViewToolbarPosition // TypeDefIndex: 26610
{
	// Fields
	public int value__; // 0x0
	public const UniWebViewToolbarPosition Top = 0;
	public const UniWebViewToolbarPosition Bottom = 1;
}

// Namespace: 
public enum UniWebViewTransitionEdge // TypeDefIndex: 26611
{
	// Fields
	public int value__; // 0x0
	public const UniWebViewTransitionEdge None = 0;
	public const UniWebViewTransitionEdge Top = 1;
	public const UniWebViewTransitionEdge Left = 2;
	public const UniWebViewTransitionEdge Bottom = 3;
	public const UniWebViewTransitionEdge Right = 4;
}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 26612
{
	// Fields
	public byte[] FilePathsData; // 0x0
	public byte[] TypesData; // 0x8
	public int TotalTypes; // 0x10
	public int TotalFiles; // 0x14
	public bool IsEditorOnly; // 0x18
}

// Namespace: 
[EditorBrowsable(1)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
[CompilerGenerated]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 26613
{
	// Methods

	// RVA: 0x89E2A94 Offset: 0x89DEA94 VA: 0x89E2A94
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x89E2B8C Offset: 0x89DEB8C VA: 0x89E2B8C
	public void .ctor() { }
}

// Namespace: 
private enum Json.Parser.TOKEN // TypeDefIndex: 26614
{
	// Fields
	public int value__; // 0x0
	public const Json.Parser.TOKEN NONE = 0;
	public const Json.Parser.TOKEN CURLY_OPEN = 1;
	public const Json.Parser.TOKEN CURLY_CLOSE = 2;
	public const Json.Parser.TOKEN SQUARED_OPEN = 3;
	public const Json.Parser.TOKEN SQUARED_CLOSE = 4;
	public const Json.Parser.TOKEN COLON = 5;
	public const Json.Parser.TOKEN COMMA = 6;
	public const Json.Parser.TOKEN STRING = 7;
	public const Json.Parser.TOKEN NUMBER = 8;
	public const Json.Parser.TOKEN TRUE = 9;
	public const Json.Parser.TOKEN FALSE = 10;
	public const Json.Parser.TOKEN NULL = 11;
}

// Namespace: 
private sealed class Json.Parser : IDisposable // TypeDefIndex: 26615
{
	// Fields
	private const string WORD_BREAK = "{}[],:\"";
	private StringReader json; // 0x10

	// Properties
	private char PeekChar { get; }
	private char NextChar { get; }
	private string NextWord { get; }
	private Json.Parser.TOKEN NextToken { get; }

	// Methods

	// RVA: 0x89E2DB4 Offset: 0x89DEDB4 VA: 0x89E2DB4
	public static bool IsWordBreak(char c) { }

	// RVA: 0x89E2E50 Offset: 0x89DEE50 VA: 0x89E2E50
	private void .ctor(string jsonString) { }

	// RVA: 0x89E2B94 Offset: 0x89DEB94 VA: 0x89E2B94
	public static object Parse(string jsonString) { }

	// RVA: 0x89E2EE8 Offset: 0x89DEEE8 VA: 0x89E2EE8 Slot: 4
	public void Dispose() { }

	// RVA: 0x89E2F18 Offset: 0x89DEF18 VA: 0x89E2F18
	private Dictionary<string, object> ParseObject() { }

	// RVA: 0x89E3480 Offset: 0x89DF480 VA: 0x89E3480
	private List<object> ParseArray() { }

	// RVA: 0x89E2ECC Offset: 0x89DEECC VA: 0x89E2ECC
	private object ParseValue() { }

	// RVA: 0x89E35AC Offset: 0x89DF5AC VA: 0x89E35AC
	private object ParseByToken(Json.Parser.TOKEN token) { }

	// RVA: 0x89E3200 Offset: 0x89DF200 VA: 0x89E3200
	private string ParseString() { }

	// RVA: 0x89E369C Offset: 0x89DF69C VA: 0x89E369C
	private object ParseNumber() { }

	// RVA: 0x89E3898 Offset: 0x89DF898 VA: 0x89E3898
	private void EatWhitespace() { }

	// RVA: 0x89E393C Offset: 0x89DF93C VA: 0x89E393C
	private char get_PeekChar() { }

	// RVA: 0x89E376C Offset: 0x89DF76C VA: 0x89E376C
	private char get_NextChar() { }

	// RVA: 0x89E37E4 Offset: 0x89DF7E4 VA: 0x89E37E4
	private string get_NextWord() { }

	// RVA: 0x89E303C Offset: 0x89DF03C VA: 0x89E303C
	private Json.Parser.TOKEN get_NextToken() { }
}

// Namespace: 
private sealed class Json.Serializer // TypeDefIndex: 26616
{
	// Fields
	private StringBuilder builder; // 0x10

	// Methods

	// RVA: 0x89E39B4 Offset: 0x89DF9B4 VA: 0x89E39B4
	private void .ctor() { }

	// RVA: 0x89E2D40 Offset: 0x89DED40 VA: 0x89E2D40
	public static string Serialize(object obj) { }

	// RVA: 0x89E3A20 Offset: 0x89DFA20 VA: 0x89E3A20
	private void SerializeValue(object value) { }

	// RVA: 0x89E420C Offset: 0x89E020C VA: 0x89E420C
	private void SerializeObject(IDictionary obj) { }

	// RVA: 0x89E3EAC Offset: 0x89DFEAC VA: 0x89E3EAC
	private void SerializeArray(IList anArray) { }

	// RVA: 0x89E3BF0 Offset: 0x89DFBF0 VA: 0x89E3BF0
	private void SerializeString(string str) { }

	// RVA: 0x89E4698 Offset: 0x89E0698 VA: 0x89E4698
	private void SerializeOther(object value) { }
}

// Namespace: UniWebViewExternal
public static class Json // TypeDefIndex: 26617
{
	// Methods

	// RVA: 0x89E2190 Offset: 0x89DE190 VA: 0x89E2190
	public static object Deserialize(string json) { }

	// RVA: 0x89E2D3C Offset: 0x89DED3C VA: 0x89E2D3C
	public static string Serialize(object obj) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1864 // TypeDefIndex: 26618
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2139 // TypeDefIndex: 26619
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 26620
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1864 865B79E8E901EC73A1E2817351CD0BB5852B320FFDD139DC4B543F8CA535FD15 /*Metadata offset 0xF46208*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2139 9A48EF637BAB971B991CD720874C737247A729801E42FC16EF3C4EB6035DBB6B /*Metadata offset 0xF46958*/; // 0x748
}

