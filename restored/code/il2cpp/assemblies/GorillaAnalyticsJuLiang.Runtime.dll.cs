// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28455
{}

// Namespace: GorillaAnalyticsJuLiang.Runtime
internal interface IJuLiangAnalyticsPlatform // TypeDefIndex: 28456
{
	// Properties
	public abstract Action OnAttributionReady { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void set_OnAttributionReady(Action value);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Init(bool hasConsent);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string GetDeviceId();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string GetSDKVersion();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetConsent(bool isConsent);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SetDebugLogEnabled(bool enabled);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void TrackEvent(string eventName, string propertiesJson);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void TrackRegister(string registerMethod, bool isSuccess);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void TrackPurchase(string productType, string productName, string productId, int productCount, string payChannel, string currency, bool isSuccess, Decimal amount);
}

// Namespace: 
private struct JuLiangAnalyticsAdapter.<>c__DisplayClass31_0.<<TryStartAttributionRequest>b__0>d : IAsyncStateMachine // TypeDefIndex: 28457
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public JuLiangAnalyticsAdapter.<>c__DisplayClass31_0 <>4__this; // 0x20
	private JuLiangAnalyticsAdapter.<>c__DisplayClass31_1 <>8__1; // 0x28
	private TaskAwaiter<JuLiangAttributionResult> <>u__1; // 0x30

	// Methods

	// RVA: 0x6400A2C Offset: 0x63FCA2C VA: 0x6400A2C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x6400F84 Offset: 0x63FCF84 VA: 0x6400F84 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class JuLiangAnalyticsAdapter.<>c__DisplayClass31_0 // TypeDefIndex: 28458
{
	// Fields
	public JuLiangAnalyticsAdapter <>4__this; // 0x10
	public string platform; // 0x18
	public string deviceId; // 0x20

	// Methods

	// RVA: 0x640054C Offset: 0x63FC54C VA: 0x640054C
	public void .ctor() { }

	[AsyncStateMachine(typeof(JuLiangAnalyticsAdapter.<>c__DisplayClass31_0.<<TryStartAttributionRequest>b__0>d))]
	// RVA: 0x640083C Offset: 0x63FC83C VA: 0x640083C
	internal Task <TryStartAttributionRequest>b__0() { }

	// RVA: 0x6400924 Offset: 0x63FC924 VA: 0x6400924
	internal void <TryStartAttributionRequest>b__1(Exception exception) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class JuLiangAnalyticsAdapter.<>c__DisplayClass31_1 // TypeDefIndex: 28459
{
	// Fields
	public JuLiangAttributionResult result; // 0x10
	public JuLiangAnalyticsAdapter.<>c__DisplayClass31_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x6400E24 Offset: 0x63FCE24 VA: 0x6400E24
	public void .ctor() { }

	// RVA: 0x6400FEC Offset: 0x63FCFEC VA: 0x6400FEC
	internal void <TryStartAttributionRequest>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class JuLiangAnalyticsAdapter.<>c__DisplayClass31_2 // TypeDefIndex: 28460
{
	// Fields
	public Exception exception; // 0x10
	public JuLiangAnalyticsAdapter.<>c__DisplayClass31_0 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0x6400A24 Offset: 0x63FCA24 VA: 0x6400A24
	public void .ctor() { }

	// RVA: 0x6401078 Offset: 0x63FD078 VA: 0x6401078
	internal void <TryStartAttributionRequest>b__3() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class JuLiangAnalyticsAdapter.<>c__DisplayClass34_0 // TypeDefIndex: 28461
{
	// Fields
	public JuLiangAnalyticsAdapter <>4__this; // 0x10
	public int code; // 0x18
	public string message; // 0x20

	// Methods

	// RVA: 0x6400828 Offset: 0x63FC828 VA: 0x6400828
	public void .ctor() { }

	// RVA: 0x6401164 Offset: 0x63FD164 VA: 0x6401164
	internal void <FailWithoutRequest>b__0() { }
}

// Namespace: GorillaAnalyticsJuLiang.Runtime
[Preserve]
internal sealed class JuLiangAnalyticsAdapter : IJuLiangAnalytics, IAnalytics // TypeDefIndex: 28462
{
	// Fields
	private readonly IJuLiangAnalyticsPlatform _platform; // 0x10
	private readonly JuLiangAttributionClient _attributionClient; // 0x18
	private bool _isInitialized; // 0x20
	private bool _isAttributionReady; // 0x21
	private bool _attributionRequestStarted; // 0x22
	private bool _hasConsent; // 0x23
	[CompilerGenerated]
	private Action<Dictionary<string, object>> <OnAttributionSuccess>k__BackingField; // 0x28
	[CompilerGenerated]
	private Action<JuLiangAttributionFailure> <OnAttributionFailure>k__BackingField; // 0x30
	[CompilerGenerated]
	private Action<JuLiangDeepLinkResult> <OnDeepLinkCallback>k__BackingField; // 0x38

	// Properties
	public Action<Dictionary<string, object>> OnAttributionSuccess { get; set; }
	public Action<JuLiangAttributionFailure> OnAttributionFailure { get; set; }
	public Action<JuLiangDeepLinkResult> OnDeepLinkCallback { get; set; }

	// Methods

	// RVA: 0x63FF640 Offset: 0x63FB640 VA: 0x63FF640
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x63FF904 Offset: 0x63FB904 VA: 0x63FF904 Slot: 4
	public Action<Dictionary<string, object>> get_OnAttributionSuccess() { }

	[CompilerGenerated]
	// RVA: 0x63FF90C Offset: 0x63FB90C VA: 0x63FF90C Slot: 5
	public void set_OnAttributionSuccess(Action<Dictionary<string, object>> value) { }

	[CompilerGenerated]
	// RVA: 0x63FF914 Offset: 0x63FB914 VA: 0x63FF914 Slot: 6
	public Action<JuLiangAttributionFailure> get_OnAttributionFailure() { }

	[CompilerGenerated]
	// RVA: 0x63FF91C Offset: 0x63FB91C VA: 0x63FF91C Slot: 7
	public void set_OnAttributionFailure(Action<JuLiangAttributionFailure> value) { }

	[CompilerGenerated]
	// RVA: 0x63FF924 Offset: 0x63FB924 VA: 0x63FF924 Slot: 8
	public Action<JuLiangDeepLinkResult> get_OnDeepLinkCallback() { }

	[CompilerGenerated]
	// RVA: 0x63FF92C Offset: 0x63FB92C VA: 0x63FF92C Slot: 9
	public void set_OnDeepLinkCallback(Action<JuLiangDeepLinkResult> value) { }

	// RVA: 0x63FF934 Offset: 0x63FB934 VA: 0x63FF934 Slot: 18
	public void Init(object data) { }

	// RVA: 0x63FF9F8 Offset: 0x63FB9F8 VA: 0x63FF9F8 Slot: 10
	public string GetDeviceId() { }

	// RVA: 0x63FFA9C Offset: 0x63FBA9C VA: 0x63FFA9C Slot: 11
	public string GetSDKVersion() { }

	// RVA: 0x63FFB40 Offset: 0x63FBB40 VA: 0x63FFB40 Slot: 12
	public void SetConsent(bool isConsent) { }

	// RVA: 0x63FFEE0 Offset: 0x63FBEE0 VA: 0x63FFEE0 Slot: 13
	public void SetDebugLogEnabled(bool enabled) { }

	// RVA: 0x63FFF8C Offset: 0x63FBF8C VA: 0x63FFF8C Slot: 14
	public void TrackEvent(string eventName, Dictionary<string, object> properties) { }

	// RVA: 0x64000EC Offset: 0x63FC0EC VA: 0x64000EC Slot: 15
	public void TrackRegister(string registerMethod, bool isSuccess) { }

	// RVA: 0x64001D4 Offset: 0x63FC1D4 VA: 0x64001D4 Slot: 16
	public void TrackPurchase(string productType, string productName, string productId, int productCount, string payChannel, string currency, bool isSuccess, Decimal amount) { }

	// RVA: 0x64003C0 Offset: 0x63FC3C0 VA: 0x64003C0 Slot: 17
	public void TrackConversion(string conversionEvent, Dictionary<string, object> properties) { }

	// RVA: 0x6400074 Offset: 0x63FC074 VA: 0x6400074
	private static string ToJson(Dictionary<string, object> properties) { }

	// RVA: 0x64004A8 Offset: 0x63FC4A8 VA: 0x64004A8
	private void HandleAttributionReady() { }

	// RVA: 0x63FFC18 Offset: 0x63FBC18 VA: 0x63FFC18
	private void TryStartAttributionRequest() { }

	// RVA: 0x6400554 Offset: 0x63FC554 VA: 0x6400554
	internal static bool IsAttributionCompleted() { }

	// RVA: 0x64007D8 Offset: 0x63FC7D8 VA: 0x64007D8
	internal static void MarkAttributionCompleted() { }

	// RVA: 0x64006C8 Offset: 0x63FC6C8 VA: 0x64006C8
	private void FailWithoutRequest(int code, string message) { }

	[CompilerGenerated]
	// RVA: 0x6400830 Offset: 0x63FC830 VA: 0x6400830
	private void <HandleAttributionReady>b__30_0() { }
}

// Namespace: 
[Preserve]
private sealed class JuLiangAnalyticsAndroid.InitializationCallback : AndroidJavaProxy // TypeDefIndex: 28463
{
	// Fields
	private readonly Action _onSuccess; // 0x20

	// Methods

	[Preserve]
	// RVA: 0x6401930 Offset: 0x63FD930 VA: 0x6401930
	public void .ctor(Action onSuccess) { }

	[Preserve]
	// RVA: 0x6403558 Offset: 0x63FF558 VA: 0x6403558
	public void onInitSuccess() { }
}

// Namespace: GorillaAnalyticsJuLiang.Runtime
internal sealed class JuLiangAnalyticsAndroid : IJuLiangAnalyticsPlatform // TypeDefIndex: 28464
{
	// Fields
	private string _deviceId; // 0x10
	private bool _isInitialized; // 0x18
	private bool _hasConsent; // 0x19
	private bool _isDebugLogEnabled; // 0x1A
	private JuLiangAnalyticsAndroid.InitializationCallback _initializationCallback; // 0x20
	[CompilerGenerated]
	private Action <OnAttributionReady>k__BackingField; // 0x28

	// Properties
	public Action OnAttributionReady { get; set; }
	private static AndroidJavaClass Wrapper { get; }
	private static AndroidJavaObject CurrentActivity { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6401234 Offset: 0x63FD234 VA: 0x6401234 Slot: 13
	public Action get_OnAttributionReady() { }

	[CompilerGenerated]
	// RVA: 0x640123C Offset: 0x63FD23C VA: 0x640123C Slot: 4
	public void set_OnAttributionReady(Action value) { }

	// RVA: 0x6401244 Offset: 0x63FD244 VA: 0x6401244 Slot: 5
	public void Init(bool hasConsent) { }

	// RVA: 0x6401CA8 Offset: 0x63FDCA8 VA: 0x6401CA8 Slot: 6
	public string GetDeviceId() { }

	// RVA: 0x6402478 Offset: 0x63FE478 VA: 0x6402478 Slot: 7
	public string GetSDKVersion() { }

	// RVA: 0x6402638 Offset: 0x63FE638 VA: 0x6402638 Slot: 8
	public void SetConsent(bool isConsent) { }

	// RVA: 0x6402958 Offset: 0x63FE958 VA: 0x6402958 Slot: 9
	public void SetDebugLogEnabled(bool enabled) { }

	// RVA: 0x6402B4C Offset: 0x63FEB4C VA: 0x6402B4C Slot: 10
	public void TrackEvent(string eventName, string propertiesJson) { }

	// RVA: 0x6402D50 Offset: 0x63FED50 VA: 0x6402D50 Slot: 11
	public void TrackRegister(string registerMethod, bool isSuccess) { }

	// RVA: 0x6402F74 Offset: 0x63FEF74 VA: 0x6402F74 Slot: 12
	public void TrackPurchase(string productType, string productName, string productId, int productCount, string payChannel, string currency, bool isSuccess, Decimal amount) { }

	// RVA: 0x64019BC Offset: 0x63FD9BC VA: 0x64019BC
	private static AndroidJavaClass get_Wrapper() { }

	// RVA: 0x6401750 Offset: 0x63FD750 VA: 0x6401750
	private static AndroidJavaObject get_CurrentActivity() { }

	// RVA: 0x640266C Offset: 0x63FE66C VA: 0x640266C
	private void SendLaunchEvent() { }

	// RVA: 0x6402964 Offset: 0x63FE964 VA: 0x6402964
	private void TrySetWrapperDebugLogEnabled(bool enabled) { }

	// RVA: 0x64024E8 Offset: 0x63FE4E8 VA: 0x64024E8
	private static string TryCallWrapperString(string methodName) { }

	// RVA: 0x64033FC Offset: 0x63FF3FC VA: 0x64033FC
	private static long TryCallWrapperLong(string methodName) { }

	// RVA: 0x6401D0C Offset: 0x63FDD0C VA: 0x6401D0C
	private string GetAndroidId() { }

	// RVA: 0x6401A28 Offset: 0x63FDA28 VA: 0x6401A28
	private void LogInitResult() { }

	// RVA: 0x640353C Offset: 0x63FF53C VA: 0x640353C
	private void NotifyAttributionReady() { }

	// RVA: 0x63FF7BC Offset: 0x63FB7BC VA: 0x63FF7BC
	public void .ctor() { }
}

// Namespace: GorillaAnalyticsJuLiang.Runtime
[Preserve]
internal static class JuLiangAnalyticsInjector // TypeDefIndex: 28465
{
	// Methods

	[RuntimeInitializeOnLoadMethod(1)]
	[Preserve]
	// RVA: 0x6403574 Offset: 0x63FF574 VA: 0x6403574
	private static void Initialize() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class JuLiangAttributionClient.<>c // TypeDefIndex: 28466
{
	// Fields
	public static readonly JuLiangAttributionClient.<>c <>9; // 0x0
	public static Func<Task> <>9__14_0; // 0x8

	// Methods

	// RVA: 0x64047E8 Offset: 0x64007E8 VA: 0x64047E8
	private static void .cctor() { }

	// RVA: 0x6404850 Offset: 0x6400850 VA: 0x6404850
	public void .ctor() { }

	// RVA: 0x6404858 Offset: 0x6400858 VA: 0x6404858
	internal Task <.ctor>b__14_0() { }
}

// Namespace: 
[CompilerGenerated]
private struct JuLiangAttributionClient.<SendAsync>d__15 : IAsyncStateMachine // TypeDefIndex: 28467
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<JuLiangAttributionResult> <>t__builder; // 0x8
	public string platform; // 0x20
	public string deviceId; // 0x28
	public string packageName; // 0x30
	public long customerActiveTime; // 0x38
	public JuLiangAttributionClient <>4__this; // 0x40
	private string <requestJson>5__2; // 0x48
	private int <retryCount>5__3; // 0x50
	private TaskAwaiter<JuLiangAttributionTransportResponse> <>u__1; // 0x58
	private TaskAwaiter <>u__2; // 0x60

	// Methods

	// RVA: 0x6404880 Offset: 0x6400880 VA: 0x6404880 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x64052E4 Offset: 0x64012E4 VA: 0x64052E4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: GorillaAnalyticsJuLiang.Runtime
internal sealed class JuLiangAttributionClient // TypeDefIndex: 28468
{
	// Fields
	private readonly IJuLiangAttributionTransport _transport; // 0x10
	private readonly Func<Task> _retryDelay; // 0x18

	// Methods

	// RVA: 0x63FF7C4 Offset: 0x63FB7C4 VA: 0x63FF7C4
	internal void .ctor(IJuLiangAttributionTransport transport, Func<Task> retryDelay) { }

	[AsyncStateMachine(typeof(JuLiangAttributionClient.<SendAsync>d__15))]
	// RVA: 0x6400E2C Offset: 0x63FCE2C VA: 0x6400E2C
	internal Task<JuLiangAttributionResult> SendAsync(string platform, string deviceId, string packageName, long customerActiveTime) { }

	// RVA: 0x640362C Offset: 0x63FF62C VA: 0x640362C
	internal static string BuildCurlCommand(string url, string requestJson) { }

	// RVA: 0x64005A8 Offset: 0x63FC5A8 VA: 0x64005A8
	internal static bool IsValidAndroidId(string value) { }

	// RVA: 0x64036B8 Offset: 0x63FF6B8 VA: 0x64036B8
	private static string ShellQuote(string value) { }

	// RVA: 0x6403760 Offset: 0x63FF760 VA: 0x6403760
	internal static bool ShouldRetryApiCode(int code) { }

	// RVA: 0x6403788 Offset: 0x63FF788 VA: 0x6403788
	internal static bool ShouldRetryHttp(long httpStatus) { }

	// RVA: 0x64037B0 Offset: 0x63FF7B0 VA: 0x64037B0
	internal static bool TryParseResponse(string rawResponse, out Dictionary<string, object> response, out int code, out string message) { }

	// RVA: 0x6403EF0 Offset: 0x63FFEF0 VA: 0x6403EF0
	private static Dictionary<string, object> BuildRequestBody(string platform, string deviceId, string packageName, long customerActiveTime) { }

	// RVA: 0x6403B2C Offset: 0x63FFB2C VA: 0x6403B2C
	private static object ConvertToken(JToken token) { }

	// RVA: 0x64040DC Offset: 0x64000DC VA: 0x64040DC
	private static Dictionary<string, object> ConvertObject(JObject value) { }

	// RVA: 0x64044AC Offset: 0x64004AC VA: 0x64044AC
	private static List<object> ConvertArray(JArray value) { }

	// RVA: 0x6403DB4 Offset: 0x63FFDB4 VA: 0x6403DB4
	private static bool TryConvertToInt(object value, out int result) { }
}

// Namespace: GorillaAnalyticsJuLiang.Runtime
internal interface IJuLiangAttributionTransport // TypeDefIndex: 28469
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Task<JuLiangAttributionTransportResponse> PostAsync(string url, string body, int timeoutSeconds);
}

// Namespace: 
[CompilerGenerated]
private struct UnityWebRequestAttributionTransport.<PostAsync>d__0 : IAsyncStateMachine // TypeDefIndex: 28470
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<JuLiangAttributionTransportResponse> <>t__builder; // 0x8
	public string url; // 0x20
	public string body; // 0x28
	public int timeoutSeconds; // 0x30
	private UnityWebRequest <request>5__2; // 0x38
	private UnityWebRequestAsyncOperation <operation>5__3; // 0x40
	private YieldAwaitable.YieldAwaiter <>u__1; // 0x48

	// Methods

	// RVA: 0x6405484 Offset: 0x6401484 VA: 0x6405484 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x6405BA4 Offset: 0x6401BA4 VA: 0x6405BA4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: GorillaAnalyticsJuLiang.Runtime
internal sealed class UnityWebRequestAttributionTransport : IJuLiangAttributionTransport // TypeDefIndex: 28471
{
	// Methods

	[AsyncStateMachine(typeof(UnityWebRequestAttributionTransport.<PostAsync>d__0))]
	// RVA: 0x6405360 Offset: 0x6401360 VA: 0x6405360 Slot: 4
	public Task<JuLiangAttributionTransportResponse> PostAsync(string url, string body, int timeoutSeconds) { }

	// RVA: 0x6403624 Offset: 0x63FF624 VA: 0x6403624
	public void .ctor() { }
}

// Namespace: GorillaAnalyticsJuLiang.Runtime
internal sealed class JuLiangAttributionTransportResponse // TypeDefIndex: 28472
{
	// Fields
	internal bool IsHttpSuccess; // 0x10
	internal long HttpStatus; // 0x18
	internal string RawResponse; // 0x20
	internal string Error; // 0x28

	// Methods

	// RVA: 0x6405B9C Offset: 0x6401B9C VA: 0x6405B9C
	public void .ctor() { }
}

// Namespace: GorillaAnalyticsJuLiang.Runtime
internal sealed class JuLiangAttributionResult // TypeDefIndex: 28473
{
	// Fields
	internal bool IsSuccess; // 0x10
	internal Dictionary<string, object> Response; // 0x18
	internal JuLiangAttributionFailure Failure; // 0x20

	// Methods

	// RVA: 0x640526C Offset: 0x640126C VA: 0x640526C
	internal static JuLiangAttributionResult Succeeded(Dictionary<string, object> response) { }

	// RVA: 0x64051F8 Offset: 0x64011F8 VA: 0x64051F8
	internal static JuLiangAttributionResult Failed(JuLiangAttributionFailure failure) { }

	// RVA: 0x6405C20 Offset: 0x6401C20 VA: 0x6405C20
	public void .ctor() { }
}

