// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 25793
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <>f__AnonymousType0<<Config>j__TPar, <Provider>j__TPar> // TypeDefIndex: 25794
{
	// Fields
	[DebuggerBrowsable(0)]
	private readonly <Config>j__TPar <Config>i__Field; // 0x0
	[DebuggerBrowsable(0)]
	private readonly <Provider>j__TPar <Provider>i__Field; // 0x0

	// Properties
	public <Config>j__TPar Config { get; }
	public <Provider>j__TPar Provider { get; }

	// Methods

	// RVA: -1 Offset: -1
	public <Config>j__TPar get_Config() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x546BE88 Offset: 0x5467E88 VA: 0x546BE88
	|-<>f__AnonymousType0<object, Int32Enum>.get_Config
	|
	|-RVA: 0x546D28C Offset: 0x546928C VA: 0x546D28C
	|-<>f__AnonymousType0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Config
	*/

	// RVA: -1 Offset: -1
	public <Provider>j__TPar get_Provider() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x546BE90 Offset: 0x5467E90 VA: 0x546BE90
	|-<>f__AnonymousType0<object, Int32Enum>.get_Provider
	|
	|-RVA: 0x546D324 Offset: 0x5469324 VA: 0x546D324
	|-<>f__AnonymousType0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Provider
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(<Config>j__TPar Config, <Provider>j__TPar Provider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x546BE98 Offset: 0x5467E98 VA: 0x546BE98
	|-<>f__AnonymousType0<object, Int32Enum>..ctor
	|
	|-RVA: 0x546D3C4 Offset: 0x54693C4 VA: 0x546D3C4
	|-<>f__AnonymousType0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x546BED4 Offset: 0x5467ED4 VA: 0x546BED4
	|-<>f__AnonymousType0<object, Int32Enum>.Equals
	|
	|-RVA: 0x546D508 Offset: 0x5469508 VA: 0x546D508
	|-<>f__AnonymousType0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x546BFA8 Offset: 0x5467FA8 VA: 0x546BFA8
	|-<>f__AnonymousType0<object, Int32Enum>.GetHashCode
	|
	|-RVA: 0x546D794 Offset: 0x5469794 VA: 0x546D794
	|-<>f__AnonymousType0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCode
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x546C034 Offset: 0x5468034 VA: 0x546C034
	|-<>f__AnonymousType0<object, Int32Enum>.ToString
	|
	|-RVA: 0x546D948 Offset: 0x5469948 VA: 0x546D948
	|-<>f__AnonymousType0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToString
	*/
}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 25795
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
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 25796
{
	// Methods

	// RVA: 0x63DF204 Offset: 0x63DB204 VA: 0x63DF204
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x63DF2FC Offset: 0x63DB2FC VA: 0x63DF2FC
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class AdConfig.<>c // TypeDefIndex: 25797
{
	// Fields
	public static readonly AdConfig.<>c <>9; // 0x0
	public static Func<AdUnitConfig, bool> <>9__7_0; // 0x8

	// Methods

	// RVA: 0x63DF730 Offset: 0x63DB730 VA: 0x63DF730
	private static void .cctor() { }

	// RVA: 0x63DF798 Offset: 0x63DB798 VA: 0x63DF798
	public void .ctor() { }

	// RVA: 0x63DF7A0 Offset: 0x63DB7A0 VA: 0x63DF7A0
	internal bool <OnValidate>b__7_0(AdUnitConfig config) { }
}

// Namespace: GorillaAd.Runtime
public class AdConfig : ScriptableObject // TypeDefIndex: 25798
{
	// Fields
	public const string Path = "Assets/Resources/GorillaSDK/AdConfig";
	[Header("iOS 平台广告单元配置列表")]
	public List<AdUnitConfig> iOSAdUnitConfigList; // 0x18
	[Header("Android 平台广告单元配置列表")]
	public List<AdUnitConfig> androidAdUnitConfigList; // 0x20
	[Header("WebGL / 小游戏平台广告单元配置列表")]
	public List<AdUnitConfig> webGLAdUnitConfigList; // 0x28
	[Header("广告设置")]
	public AdSetting setting; // 0x30

	// Properties
	public List<AdUnitConfig> AdUnityConfigs { get; }

	// Methods

	// RVA: 0x63DF304 Offset: 0x63DB304 VA: 0x63DF304
	public List<AdUnitConfig> get_AdUnityConfigs() { }

	// RVA: 0x63DF30C Offset: 0x63DB30C VA: 0x63DF30C
	private void OnValidate() { }

	// RVA: 0x63DF728 Offset: 0x63DB728 VA: 0x63DF728
	public void .ctor() { }
}

// Namespace: GorillaAd.Runtime
[Preserve]
[Serializable]
public class AdUnitConfig // TypeDefIndex: 25799
{
	// Fields
	[Header("广告单元id")]
	public string adUnitId; // 0x10
	[Header("adUnitId 所属的广告 Provider")]
	public AdProvider adUnitIdProvider; // 0x18
	[Header("广告位名称")]
	public string adUnitName; // 0x20
	[Header("广告格式")]
	public AdFormat format; // 0x28
	[Preserve]
	[Header("Banner 广告展示位置")]
	public BannerPosition bannerPosition; // 0x2C
	[Header("优先级，值越大越先 加载/播放")]
	public int priority; // 0x30
	[Header("是否自动重新加载广告单元")]
	public bool autoReload; // 0x34
	[Header("重试策略")]
	public AdUnitRetryStrategy retryStrategy; // 0x38
	[Header("如果重试策略为指数退避重试，则为初始延迟秒数，如果重试策略为固定延迟，则为固定延迟秒数")]
	public float param0; // 0x3C
	[Header("如果重试策略为指数退避重试，则为最大延迟秒数, 如果重试策略为固定延迟，则不使用此参数")]
	public float param1; // 0x40
	[CompilerGenerated]
	private IAdRetryPolicy <RetryPolicy>k__BackingField; // 0x48

	// Properties
	public IAdRetryPolicy RetryPolicy { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x63DF7AC Offset: 0x63DB7AC VA: 0x63DF7AC
	public IAdRetryPolicy get_RetryPolicy() { }

	[CompilerGenerated]
	// RVA: 0x63DF7B4 Offset: 0x63DB7B4 VA: 0x63DF7B4
	private void set_RetryPolicy(IAdRetryPolicy value) { }

	// RVA: 0x63DF7BC Offset: 0x63DB7BC VA: 0x63DF7BC
	public string GetAdUnitId() { }

	// RVA: 0x63DF818 Offset: 0x63DB818 VA: 0x63DF818
	public AdProvider ResolveAdUnitIdProvider(AdProvider defaultProvider = 0) { }

	// RVA: 0x63DF828 Offset: 0x63DB828 VA: 0x63DF828
	public bool MatchesProvider(AdProvider provider, AdProvider defaultProvider = 0) { }

	// RVA: 0x63DF87C Offset: 0x63DB87C VA: 0x63DF87C
	public bool ContainsAdUnitId(string targetAdUnitId) { }

	// RVA: 0x63DF8C8 Offset: 0x63DB8C8 VA: 0x63DF8C8
	public void BuildRetryPolicy() { }

	// RVA: 0x63DF988 Offset: 0x63DB988 VA: 0x63DF988 Slot: 3
	public override string ToString() { }

	// RVA: 0x63DFCF0 Offset: 0x63DBCF0 VA: 0x63DFCF0
	public void .ctor() { }
}

// Namespace: GorillaAd.Runtime
[Preserve]
[Serializable]
public enum AdProvider // TypeDefIndex: 25800
{
	// Fields
	public int value__; // 0x0
	[Preserve]
	public const AdProvider Admob = 0;
	[Preserve]
	public const AdProvider AppLovin = 1;
	[Preserve]
	public const AdProvider Vungle = 2;
	[Preserve]
	public const AdProvider LocalVideo = 3;
	[Preserve]
	public const AdProvider CSJ = 4;
	[Preserve]
	public const AdProvider WeChatMiniGame = 5;
	[Preserve]
	public const AdProvider DouyinMiniGame = 6;
	[Preserve]
	public const AdProvider TikTokMiniGame = 7;
}

// Namespace: GorillaAd.Runtime
[Preserve]
[Serializable]
public enum AdUnitRetryStrategy // TypeDefIndex: 25801
{
	// Fields
	public int value__; // 0x0
	public const AdUnitRetryStrategy ExponentialBackoffRetry = 0;
	public const AdUnitRetryStrategy FixedDelay = 1;
}

// Namespace: GorillaAd.Runtime
[Preserve]
[Serializable]
public class AdSetting // TypeDefIndex: 25802
{
	// Fields
	[Header("测试设备 ID 列表，用于加载类似正式环境的广告")]
	public List<string> testDeviceIds; // 0x10
	[Header("Google UMP / CMP 的测试设备哈希 ID 列表")]
	public List<string> umpTestDeviceHashedIds; // 0x18
	[Header("指示是否启用测试模式")]
	public bool isTestMode; // 0x20
	[Header("指示是否将广告收入数据共享到分析平台，例如 Adjust")]
	public bool shareAdRevenueDataToAnalyticsPlatform; // 0x21
	[Header("检查已加载广告是否准备好展示的时间间隔（秒）")]
	public float checkLoadedAdIsReadyInterval; // 0x24
	[Header("激励视频 Provider 队列，第一个为主 Provider")]
	public List<AdProvider> rewardedVideoProviderQueue; // 0x28
	[Preserve]
	[Header("是否启用并行加载激励视频（默认开启）")]
	public bool enableParallelLoading; // 0x30
	[Header("本地兜底视频配置")]
	[Preserve]
	public FallbackRewardedVideoConfig fallbackRewardedVideo; // 0x38
	[Preserve]
	[Header("Vungle Common App ID")]
	public string vungleAppId; // 0x40
	[Preserve]
	[Header("Vungle iOS App ID")]
	public string vungleIOSAppId; // 0x48
	[Preserve]
	[Header("Vungle Android App ID")]
	public string vungleAndroidAppId; // 0x50
	[Preserve]
	[Header("穿山甲配置")]
	public CSJConfig csj; // 0x58

	// Methods

	// RVA: 0x63DFD70 Offset: 0x63DBD70 VA: 0x63DFD70
	public string GetVungleAppId() { }

	// RVA: 0x63DFDA0 Offset: 0x63DBDA0 VA: 0x63DFDA0
	public void .ctor() { }
}

// Namespace: GorillaAd.Runtime
[Preserve]
[Serializable]
public class CSJConfig // TypeDefIndex: 25803
{
	// Fields
	[Preserve]
	[Header("穿山甲 App ID")]
	public string appId; // 0x10
	[Header("穿山甲 App Name")]
	[Preserve]
	public string appName; // 0x18
	[Preserve]
	[Header("是否启用穿山甲聚合维度")]
	public bool useMediation; // 0x20
	[Preserve]
	[Header("是否启用穿山甲调试日志")]
	public bool debugLog; // 0x21

	// Methods

	// RVA: 0x63DFF24 Offset: 0x63DBF24 VA: 0x63DFF24
	public void .ctor() { }
}

// Namespace: GorillaAd.Runtime
[Preserve]
[Serializable]
public class FallbackRewardedVideoConfig // TypeDefIndex: 25804
{
	// Fields
	[Header("是否允许包内激励视频来兜底")]
	public bool enable; // 0x10
	[Header("内兜底的激励视频远端下载地址")]
	public string remoteUrl; // 0x18
	[Header("包内兜底视频跳转地址")]
	public string redirectUrl; // 0x20
	[Header("是否允许跳过播放。允许之后，直接回调成功、奖励和关闭事件，不实际播放视频。")]
	public bool isSkipPlaying; // 0x28

	// Methods

	// RVA: 0x63DFF1C Offset: 0x63DBF1C VA: 0x63DFF1C
	public void .ctor() { }
}

// Namespace: GorillaAd.Runtime
[Preserve]
[Serializable]
public enum AdFormat // TypeDefIndex: 25805
{
	// Fields
	public int value__; // 0x0
	public const AdFormat Reward = 0;
	public const AdFormat Interstitial = 1;
	public const AdFormat Banner = 2;
}

// Namespace: GorillaAd.Runtime
[Preserve]
[Serializable]
public enum BannerPosition // TypeDefIndex: 25806
{
	// Fields
	public int value__; // 0x0
	public const BannerPosition Top = 0;
	public const BannerPosition Bottom = 1;
	public const BannerPosition TopLeft = 2;
	public const BannerPosition TopRight = 3;
	public const BannerPosition Center = 4;
	public const BannerPosition BottomLeft = 5;
	public const BannerPosition BottomRight = 6;
}

// Namespace: 
private class AdController.AdLoadOperationCallbacks // TypeDefIndex: 25807
{
	// Fields
	[CompilerGenerated]
	private readonly Action <OnSuccess>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Action<int, string> <OnFailure>k__BackingField; // 0x18

	// Properties
	public Action OnSuccess { get; }
	public Action<int, string> OnFailure { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x63E6210 Offset: 0x63E2210 VA: 0x63E6210
	public Action get_OnSuccess() { }

	[CompilerGenerated]
	// RVA: 0x63E6218 Offset: 0x63E2218 VA: 0x63E6218
	public Action<int, string> get_OnFailure() { }

	// RVA: 0x63E0384 Offset: 0x63DC384 VA: 0x63E0384
	public void .ctor(Action onSuccess, Action<int, string> onFailure) { }
}

// Namespace: 
private class AdController.AdShowOperationCallbacks // TypeDefIndex: 25808
{
	// Fields
	[CompilerGenerated]
	private readonly Action <OnSuccess>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Action<int, string> <OnFailure>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly Action <OnClose>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly Action <OnRewarded>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly Action <OnClick>k__BackingField; // 0x30
	[CompilerGenerated]
	private readonly Action <OnImpression>k__BackingField; // 0x38
	[CompilerGenerated]
	private readonly Action<AdPaidEventData> <OnAdPaid>k__BackingField; // 0x40
	[CompilerGenerated]
	private readonly Dictionary<string, object> <CustomData>k__BackingField; // 0x48
	[CompilerGenerated]
	private readonly Stopwatch <PlaybackWatch>k__BackingField; // 0x50
	[CompilerGenerated]
	private readonly object <PlaybackLock>k__BackingField; // 0x58
	[CompilerGenerated]
	private IDisposable <PlaybackTimer>k__BackingField; // 0x60
	[CompilerGenerated]
	private IAd <PlayingAd>k__BackingField; // 0x68
	[CompilerGenerated]
	private AdProvider <PlayingProvider>k__BackingField; // 0x70

	// Properties
	public Action OnSuccess { get; }
	public Action<int, string> OnFailure { get; }
	public Action OnClose { get; }
	public Action OnRewarded { get; }
	public Action OnClick { get; }
	public Action OnImpression { get; }
	public Action<AdPaidEventData> OnAdPaid { get; }
	public Dictionary<string, object> CustomData { get; }
	public Stopwatch PlaybackWatch { get; }
	public object PlaybackLock { get; }
	public IDisposable PlaybackTimer { get; set; }
	public IAd PlayingAd { get; set; }
	public AdProvider PlayingProvider { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x63E6220 Offset: 0x63E2220 VA: 0x63E6220
	public Action get_OnSuccess() { }

	[CompilerGenerated]
	// RVA: 0x63E6228 Offset: 0x63E2228 VA: 0x63E6228
	public Action<int, string> get_OnFailure() { }

	[CompilerGenerated]
	// RVA: 0x63E6230 Offset: 0x63E2230 VA: 0x63E6230
	public Action get_OnClose() { }

	[CompilerGenerated]
	// RVA: 0x63E6238 Offset: 0x63E2238 VA: 0x63E6238
	public Action get_OnRewarded() { }

	[CompilerGenerated]
	// RVA: 0x63E6240 Offset: 0x63E2240 VA: 0x63E6240
	public Action get_OnClick() { }

	[CompilerGenerated]
	// RVA: 0x63E6248 Offset: 0x63E2248 VA: 0x63E6248
	public Action get_OnImpression() { }

	[CompilerGenerated]
	// RVA: 0x63E6250 Offset: 0x63E2250 VA: 0x63E6250
	public Action<AdPaidEventData> get_OnAdPaid() { }

	[CompilerGenerated]
	// RVA: 0x63E6258 Offset: 0x63E2258 VA: 0x63E6258
	public Dictionary<string, object> get_CustomData() { }

	[CompilerGenerated]
	// RVA: 0x63E6260 Offset: 0x63E2260 VA: 0x63E6260
	public Stopwatch get_PlaybackWatch() { }

	[CompilerGenerated]
	// RVA: 0x63E6268 Offset: 0x63E2268 VA: 0x63E6268
	public object get_PlaybackLock() { }

	[CompilerGenerated]
	// RVA: 0x63E6270 Offset: 0x63E2270 VA: 0x63E6270
	public IDisposable get_PlaybackTimer() { }

	[CompilerGenerated]
	// RVA: 0x63E6278 Offset: 0x63E2278 VA: 0x63E6278
	public void set_PlaybackTimer(IDisposable value) { }

	[CompilerGenerated]
	// RVA: 0x63E6280 Offset: 0x63E2280 VA: 0x63E6280
	public IAd get_PlayingAd() { }

	[CompilerGenerated]
	// RVA: 0x63E6288 Offset: 0x63E2288 VA: 0x63E6288
	public void set_PlayingAd(IAd value) { }

	[CompilerGenerated]
	// RVA: 0x63E6290 Offset: 0x63E2290 VA: 0x63E6290
	public AdProvider get_PlayingProvider() { }

	[CompilerGenerated]
	// RVA: 0x63E6298 Offset: 0x63E2298 VA: 0x63E6298
	public void set_PlayingProvider(AdProvider value) { }

	// RVA: 0x63E0764 Offset: 0x63DC764 VA: 0x63E0764
	public void .ctor(Action onSuccess, Action<int, string> onFailure, Action onClose, Action onRewarded, Action onClick, Action onImpression, Action<AdPaidEventData> onAdPaid, Dictionary<string, object> customData) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AdController.<>c__DisplayClass36_0 // TypeDefIndex: 25809
{
	// Fields
	public bool allSuccess; // 0x10
	public int completed; // 0x14
	public AdController <>4__this; // 0x18
	public Action<bool> onCompletion; // 0x20
	public Action<bool> <>9__0; // 0x28

	// Methods

	// RVA: 0x63E27B4 Offset: 0x63DE7B4 VA: 0x63E27B4
	public void .ctor() { }

	// RVA: 0x63E62A0 Offset: 0x63E22A0 VA: 0x63E62A0
	internal void <InitializeAdSdk>b__0(bool success) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AdController.<>c__DisplayClass37_0 // TypeDefIndex: 25810
{
	// Fields
	public AdController <>4__this; // 0x10
	public AdProvider provider; // 0x18

	// Methods

	// RVA: 0x63E2CA0 Offset: 0x63DECA0 VA: 0x63E2CA0
	public void .ctor() { }

	// RVA: 0x63E6340 Offset: 0x63E2340 VA: 0x63E6340
	internal void <InitializeAdSdk>b__0(bool success) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AdController.<>c__DisplayClass42_0 // TypeDefIndex: 25811
{
	// Fields
	public BannerPosition position; // 0x10

	// Methods

	// RVA: 0x63E30D8 Offset: 0x63DF0D8 VA: 0x63E30D8
	public void .ctor() { }

	// RVA: 0x63E6560 Offset: 0x63E2560 VA: 0x63E6560
	internal IBannerAd <GetOrCreateBannerAd>b__0(AdProvider adProvider, string unitId) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AdController.<>c__DisplayClass49_0<TAd> // TypeDefIndex: 25812
{
	// Fields
	public AdController <>4__this; // 0x0
	public string callbackKey; // 0x0
	public AdProvider provider; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54583E0 Offset: 0x54543E0 VA: 0x54583E0
	|-AdController.<>c__DisplayClass49_0<object>..ctor
	|
	|-RVA: 0x5458CA4 Offset: 0x5454CA4 VA: 0x5458CA4
	|-AdController.<>c__DisplayClass49_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <RegisterEventHandlers>b__0(IAd sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54583E8 Offset: 0x54543E8 VA: 0x54583E8
	|-AdController.<>c__DisplayClass49_0<object>.<RegisterEventHandlers>b__0
	|
	|-RVA: 0x5458CAC Offset: 0x5454CAC VA: 0x5458CAC
	|-AdController.<>c__DisplayClass49_0<__Il2CppFullySharedGenericType>.<RegisterEventHandlers>b__0
	*/

	// RVA: -1 Offset: -1
	internal void <RegisterEventHandlers>b__1(IAd sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5458474 Offset: 0x5454474 VA: 0x5458474
	|-AdController.<>c__DisplayClass49_0<object>.<RegisterEventHandlers>b__1
	|
	|-RVA: 0x5458D38 Offset: 0x5454D38 VA: 0x5458D38
	|-AdController.<>c__DisplayClass49_0<__Il2CppFullySharedGenericType>.<RegisterEventHandlers>b__1
	*/

	// RVA: -1 Offset: -1
	internal void <RegisterEventHandlers>b__2(IAd sender, int code, string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5458550 Offset: 0x5454550 VA: 0x5458550
	|-AdController.<>c__DisplayClass49_0<object>.<RegisterEventHandlers>b__2
	|
	|-RVA: 0x5458E14 Offset: 0x5454E14 VA: 0x5458E14
	|-AdController.<>c__DisplayClass49_0<__Il2CppFullySharedGenericType>.<RegisterEventHandlers>b__2
	*/

	// RVA: -1 Offset: -1
	internal void <RegisterEventHandlers>b__3(IAd sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5458630 Offset: 0x5454630 VA: 0x5458630
	|-AdController.<>c__DisplayClass49_0<object>.<RegisterEventHandlers>b__3
	|
	|-RVA: 0x5458EF4 Offset: 0x5454EF4 VA: 0x5458EF4
	|-AdController.<>c__DisplayClass49_0<__Il2CppFullySharedGenericType>.<RegisterEventHandlers>b__3
	*/

	// RVA: -1 Offset: -1
	internal void <RegisterEventHandlers>b__4(IAd sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54586E8 Offset: 0x54546E8 VA: 0x54586E8
	|-AdController.<>c__DisplayClass49_0<object>.<RegisterEventHandlers>b__4
	|
	|-RVA: 0x5458FAC Offset: 0x5454FAC VA: 0x5458FAC
	|-AdController.<>c__DisplayClass49_0<__Il2CppFullySharedGenericType>.<RegisterEventHandlers>b__4
	*/

	// RVA: -1 Offset: -1
	internal void <RegisterEventHandlers>b__5(IAd sender, int code, string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54587E0 Offset: 0x54547E0 VA: 0x54587E0
	|-AdController.<>c__DisplayClass49_0<object>.<RegisterEventHandlers>b__5
	|
	|-RVA: 0x54590A4 Offset: 0x54550A4 VA: 0x54590A4
	|-AdController.<>c__DisplayClass49_0<__Il2CppFullySharedGenericType>.<RegisterEventHandlers>b__5
	*/

	// RVA: -1 Offset: -1
	internal void <RegisterEventHandlers>b__6(IAd sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54588D4 Offset: 0x54548D4 VA: 0x54588D4
	|-AdController.<>c__DisplayClass49_0<object>.<RegisterEventHandlers>b__6
	|
	|-RVA: 0x5459198 Offset: 0x5455198 VA: 0x5459198
	|-AdController.<>c__DisplayClass49_0<__Il2CppFullySharedGenericType>.<RegisterEventHandlers>b__6
	*/

	// RVA: -1 Offset: -1
	internal void <RegisterEventHandlers>b__7(IAd sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5458950 Offset: 0x5454950 VA: 0x5458950
	|-AdController.<>c__DisplayClass49_0<object>.<RegisterEventHandlers>b__7
	|
	|-RVA: 0x5459214 Offset: 0x5455214 VA: 0x5459214
	|-AdController.<>c__DisplayClass49_0<__Il2CppFullySharedGenericType>.<RegisterEventHandlers>b__7
	*/

	// RVA: -1 Offset: -1
	internal void <RegisterEventHandlers>b__8(IAd sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54589CC Offset: 0x54549CC VA: 0x54589CC
	|-AdController.<>c__DisplayClass49_0<object>.<RegisterEventHandlers>b__8
	|
	|-RVA: 0x5459290 Offset: 0x5455290 VA: 0x5459290
	|-AdController.<>c__DisplayClass49_0<__Il2CppFullySharedGenericType>.<RegisterEventHandlers>b__8
	*/

	// RVA: -1 Offset: -1
	internal void <RegisterEventHandlers>b__9(IAd sender, AdPaidEventData paidData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5458AEC Offset: 0x5454AEC VA: 0x5458AEC
	|-AdController.<>c__DisplayClass49_0<object>.<RegisterEventHandlers>b__9
	|
	|-RVA: 0x54593B0 Offset: 0x54553B0 VA: 0x54593B0
	|-AdController.<>c__DisplayClass49_0<__Il2CppFullySharedGenericType>.<RegisterEventHandlers>b__9
	*/

	// RVA: -1 Offset: -1
	internal void <RegisterEventHandlers>b__10(IRewardAd sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5458BF4 Offset: 0x5454BF4 VA: 0x5458BF4
	|-AdController.<>c__DisplayClass49_0<object>.<RegisterEventHandlers>b__10
	|
	|-RVA: 0x54594B8 Offset: 0x54554B8 VA: 0x54594B8
	|-AdController.<>c__DisplayClass49_0<__Il2CppFullySharedGenericType>.<RegisterEventHandlers>b__10
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class AdController.<>c__DisplayClass51_0 // TypeDefIndex: 25813
{
	// Fields
	public AdController.AdShowOperationCallbacks callback; // 0x10

	// Methods

	// RVA: 0x63E33D8 Offset: 0x63DF3D8 VA: 0x63E33D8
	public void .ctor() { }

	// RVA: 0x63E66C4 Offset: 0x63E26C4 VA: 0x63E66C4
	internal void <StartPlaybackTracking>b__0() { }
}

// Namespace: GorillaAd.Runtime
public class AdController // TypeDefIndex: 25814
{
	// Fields
	private readonly Dictionary<string, IBannerAd> _bannerAdContainer; // 0x10
	private const string Tag = "[AdController]";
	private const int AdNotAvailableErrorCode = -1;
	private const int DefaultPlayStartIntervalSeconds = 5;
	private readonly Dictionary<AdProvider, IAdSdkInitializer> _adInitializers; // 0x18
	private readonly Dictionary<AdProvider, IConsentFlow> _consentFlows; // 0x20
	private readonly HashSet<AdProvider> _initializedProviders; // 0x28
	private readonly HashSet<AdProvider> _initializingProviders; // 0x30
	private readonly Dictionary<AdProvider, List<Action<bool>>> _pendingInitializeCallbacks; // 0x38
	private readonly ConcurrentDictionary<string, AdController.AdLoadOperationCallbacks> _loadCallbacksMap; // 0x40
	private readonly ConcurrentDictionary<string, AdController.AdShowOperationCallbacks> _showCallbacksMap; // 0x48
	private readonly AdProvider _primaryProvider; // 0x50
	private readonly bool _shareAdRevenueDataToAnalyticsPlatform; // 0x54
	private int _playStartIntervalSeconds; // 0x58
	private AdController.AdShowOperationCallbacks _activePlaybackCallbacks; // 0x60
	private readonly Dictionary<string, IInterstitialAd> _interstitialAdContainer; // 0x68
	private readonly Dictionary<string, IRewardAd> _rewardAdContainer; // 0x70

	// Methods

	// RVA: 0x63DFF2C Offset: 0x63DBF2C VA: 0x63DFF2C
	public void LoadBannerAd(string adUnitId, BannerPosition position = 1, Action onLoadSuccess, Action<int, string> onLoadFailure) { }

	// RVA: 0x63DFF48 Offset: 0x63DBF48 VA: 0x63DFF48
	public void LoadBannerAd(AdProvider provider, string adUnitId, BannerPosition position = 1, Action onLoadSuccess, Action<int, string> onLoadFailure) { }

	// RVA: 0x63E03C8 Offset: 0x63DC3C8 VA: 0x63E03C8
	public void ShowBannerAd(string adUnitId, BannerPosition position = 1, Action onShowSuccess, Action<int, string> onShowFailure, Action onClick, Action onImpression, Action<AdPaidEventData> onAdPaid, Dictionary<string, object> customData, Action onClose) { }

	// RVA: 0x63E0410 Offset: 0x63DC410 VA: 0x63E0410
	public void ShowBannerAd(AdProvider provider, string adUnitId, BannerPosition position = 1, Action onShowSuccess, Action<int, string> onShowFailure, Action onClick, Action onImpression, Action<AdPaidEventData> onAdPaid, Dictionary<string, object> customData, Action onClose) { }

	// RVA: 0x63E08C8 Offset: 0x63DC8C8 VA: 0x63E08C8
	public void HideBannerAd(string adUnitId) { }

	// RVA: 0x63E08D8 Offset: 0x63DC8D8 VA: 0x63E08D8
	public void HideBannerAd(AdProvider provider, string adUnitId) { }

	// RVA: 0x63E0BC4 Offset: 0x63DCBC4 VA: 0x63E0BC4
	public void DestroyBannerAd(string adUnitId) { }

	// RVA: 0x63E0BD4 Offset: 0x63DCBD4 VA: 0x63E0BD4
	public void DestroyBannerAd(AdProvider provider, string adUnitId) { }

	// RVA: 0x63E0AA0 Offset: 0x63DCAA0 VA: 0x63E0AA0
	private void InvokeBannerCloseCallback(AdProvider provider, string callbackKey, IBannerAd ad, bool wasDisplaying) { }

	// RVA: 0x63E0E78 Offset: 0x63DCE78 VA: 0x63E0E78
	public bool IsBannerAdReady(string adUnitId) { }

	// RVA: 0x63E0E88 Offset: 0x63DCE88 VA: 0x63E0E88
	public bool IsBannerAdReady(AdProvider provider, string adUnitId) { }

	// RVA: 0x63E0F90 Offset: 0x63DCF90 VA: 0x63E0F90
	public bool IsBannerAdLoading(string adUnitId) { }

	// RVA: 0x63E0FA0 Offset: 0x63DCFA0 VA: 0x63E0FA0
	public bool IsBannerAdLoading(AdProvider provider, string adUnitId) { }

	// RVA: 0x63E10A8 Offset: 0x63DD0A8 VA: 0x63E10A8
	public bool IsBannerAdDisplaying(string adUnitId) { }

	// RVA: 0x63E10B8 Offset: 0x63DD0B8 VA: 0x63E10B8
	public bool IsBannerAdDisplaying(AdProvider provider, string adUnitId) { }

	// RVA: 0x63E11C0 Offset: 0x63DD1C0 VA: 0x63E11C0
	public void .ctor(AdSetting setting) { }

	// RVA: 0x63E2214 Offset: 0x63DE214 VA: 0x63E2214
	internal void SetPlayStartInterval(int intervalSeconds) { }

	// RVA: 0x63E2290 Offset: 0x63DE290 VA: 0x63E2290
	public void InitializeConsentFlow(bool isShowConsent = True, Action onGranted) { }

	// RVA: 0x63E22A8 Offset: 0x63DE2A8 VA: 0x63E22A8
	public void InitializeConsentFlow(AdProvider provider, bool isShowConsent = True, Action onGranted) { }

	// RVA: 0x63E23A4 Offset: 0x63DE3A4 VA: 0x63E23A4
	public void ShowPrivacyOptionsForm(Action<int, string> onFailure) { }

	// RVA: 0x63E23B4 Offset: 0x63DE3B4 VA: 0x63E23B4
	public void ShowPrivacyOptionsForm(AdProvider provider, Action<int, string> onFailure) { }

	// RVA: 0x63E24D8 Offset: 0x63DE4D8 VA: 0x63E24D8
	public void ResetConsent() { }

	// RVA: 0x63E25B4 Offset: 0x63DE5B4 VA: 0x63E25B4
	public void InitializeAdSdk(Action<bool> onCompletion) { }

	// RVA: 0x63E27BC Offset: 0x63DE7BC VA: 0x63E27BC
	public void InitializeAdSdk(AdProvider provider, Action<bool> onCompletion) { }

	// RVA: 0x63E2DB4 Offset: 0x63DEDB4 VA: 0x63E2DB4
	public void OpenDebugTool() { }

	// RVA: 0x63E2DC0 Offset: 0x63DEDC0 VA: 0x63E2DC0
	public void OpenDebugTool(AdProvider provider, Action<int, string> onFailure) { }

	// RVA: 0x63E2F28 Offset: 0x63DEF28 VA: 0x63E2F28
	private IRewardAd GetOrCreateRewardAd(AdProvider provider, string adUnitId) { }

	// RVA: 0x63E3000 Offset: 0x63DF000 VA: 0x63E3000
	private IInterstitialAd GetOrCreateInterstitialAd(AdProvider provider, string adUnitId) { }

	// RVA: 0x63E01BC Offset: 0x63DC1BC VA: 0x63E01BC
	private IBannerAd GetOrCreateBannerAd(AdProvider provider, string adUnitId, BannerPosition position) { }

	// RVA: -1 Offset: -1
	private IAd GetOrCreateAd<TAd>(AdProvider provider, string adUnitId, Func<AdProvider, string, TAd> creatorFunc, Dictionary<string, TAd> container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B54CC Offset: 0x44B14CC VA: 0x44B54CC
	|-AdController.GetOrCreateAd<object>
	*/

	// RVA: 0x63E02C4 Offset: 0x63DC2C4 VA: 0x63E02C4
	internal static string BuildAdKey(AdProvider provider, string adUnitId) { }

	// RVA: 0x63E0164 Offset: 0x63DC164 VA: 0x63E0164
	internal static string NormalizeAdUnitId(AdProvider provider, string adUnitId) { }

	// RVA: -1 Offset: -1
	private void RegisterEventHandlers<TAd>(AdProvider provider, string callbackKey, TAd ad) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B56EC Offset: 0x44B16EC VA: 0x44B56EC
	|-AdController.RegisterEventHandlers<object>
	|
	|-RVA: 0x44B5DB4 Offset: 0x44B1DB4 VA: 0x44B5DB4
	|-AdController.RegisterEventHandlers<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x63E30E0 Offset: 0x63DF0E0 VA: 0x63E30E0
	private static void TrackPaidAdEvent(AdProvider provider, AdEventType type, IAd sender, AdController.AdShowOperationCallbacks callback) { }

	// RVA: 0x63E3150 Offset: 0x63DF150 VA: 0x63E3150
	private void StartPlaybackTracking(AdProvider provider, IAd sender, AdController.AdShowOperationCallbacks callback) { }

	// RVA: 0x63E33E0 Offset: 0x63DF3E0 VA: 0x63E33E0
	private void StopPlaybackTracking(AdController.AdShowOperationCallbacks callback) { }

	// RVA: 0x63E3598 Offset: 0x63DF598 VA: 0x63E3598
	private static void ReportPlaybackDuration(AdController.AdShowOperationCallbacks callback) { }

	// RVA: 0x63E3864 Offset: 0x63DF864 VA: 0x63E3864
	private static Nullable<AdFormat> GetAdFormat(IAd ad) { }

	// RVA: 0x63E3BEC Offset: 0x63DFBEC VA: 0x63E3BEC
	private bool ShouldDispatchLoadEvent(string callbackKey, IAd sender) { }

	// RVA: 0x63E3C88 Offset: 0x63DFC88 VA: 0x63E3C88
	private static bool ShouldDispatchLoadEvent(IAd sender, bool hasLoadCallbacks) { }

	// RVA: 0x63E3CF0 Offset: 0x63DFCF0 VA: 0x63E3CF0
	private bool TryGetShowCallbacksForWatchEvent(string callbackKey, IAd sender, out AdController.AdShowOperationCallbacks callback) { }

	// RVA: 0x63E0E24 Offset: 0x63DCE24 VA: 0x63E0E24
	private static void TrackAdEventIfNeeded(AdProvider provider, AdEventType type, IAd sender, int code = 0, string message = "", Dictionary<string, object> customData) { }

	// RVA: 0x63E48C0 Offset: 0x63E08C0 VA: 0x63E48C0
	private void ForwardAdRevenueEvent(IAd sender, AdPaidEventData data) { }

	// RVA: 0x63E48DC Offset: 0x63E08DC VA: 0x63E48DC
	private static void ForwardAdRevenueEventToAdjust(IAd sender, AdPaidEventData data) { }

	// RVA: 0x63E514C Offset: 0x63E114C VA: 0x63E514C
	public void LoadInterstitialAd(string adUnitId, Action onLoadSuccess, Action<int, string> onLoadFailure) { }

	// RVA: 0x63E5164 Offset: 0x63E1164 VA: 0x63E5164
	public void LoadInterstitialAd(AdProvider provider, string adUnitId, Action onLoadSuccess, Action<int, string> onLoadFailure) { }

	// RVA: 0x63E5378 Offset: 0x63E1378 VA: 0x63E5378
	public void ShowInterstitialAd(string adUnitId, Action onShowSuccess, Action<int, string> onShowFailure, Action onClose, Action onClick, Action onImpression, Action<AdPaidEventData> onAdPaid, Dictionary<string, object> customData) { }

	// RVA: 0x63E53BC Offset: 0x63E13BC VA: 0x63E53BC
	public void ShowInterstitialAd(AdProvider provider, string adUnitId, Action onShowSuccess, Action<int, string> onShowFailure, Action onClose, Action onClick, Action onImpression, Action<AdPaidEventData> onAdPaid, Dictionary<string, object> customData) { }

	// RVA: 0x63E5708 Offset: 0x63E1708 VA: 0x63E5708
	public bool IsInterstitialAdReady(string adUnitId) { }

	// RVA: 0x63E5718 Offset: 0x63E1718 VA: 0x63E5718
	public bool IsInterstitialAdReady(AdProvider provider, string adUnitId) { }

	// RVA: 0x63E57E8 Offset: 0x63E17E8 VA: 0x63E57E8
	public bool IsInterstitialAdLoading(string adUnitId) { }

	// RVA: 0x63E57F8 Offset: 0x63E17F8 VA: 0x63E57F8
	public bool IsInterstitialAdLoading(AdProvider provider, string adUnitId) { }

	// RVA: 0x63E58C8 Offset: 0x63E18C8 VA: 0x63E58C8
	public bool IsInterstitialAdDisplaying(string adUnitId) { }

	// RVA: 0x63E58D8 Offset: 0x63E18D8 VA: 0x63E58D8
	public bool IsInterstitialAdDisplaying(AdProvider provider, string adUnitId) { }

	// RVA: 0x63E59A8 Offset: 0x63E19A8 VA: 0x63E59A8
	public void LoadRewardAd(string adUnitId, Action onLoadSuccess, Action<int, string> onLoadFailure) { }

	// RVA: 0x63E59C0 Offset: 0x63E19C0 VA: 0x63E59C0
	public void LoadRewardAd(AdProvider provider, string adUnitId, Action onLoadSuccess, Action<int, string> onLoadFailure) { }

	// RVA: 0x63E5BD4 Offset: 0x63E1BD4 VA: 0x63E5BD4
	public void ShowRewardAd(string adUnitId, Action onShowSuccess, Action<int, string> onShowFailure, Action onClose, Action onRewarded, Action onClick, Action onImpression, Action<AdPaidEventData> onAdPaid, Dictionary<string, object> customData) { }

	// RVA: 0x63E5C1C Offset: 0x63E1C1C VA: 0x63E5C1C
	public void ShowRewardAd(AdProvider provider, string adUnitId, Action onShowSuccess, Action<int, string> onShowFailure, Action onClose, Action onRewarded, Action onClick, Action onImpression, Action<AdPaidEventData> onAdPaid, Dictionary<string, object> customData) { }

	// RVA: 0x63E5F70 Offset: 0x63E1F70 VA: 0x63E5F70
	public bool IsRewardAdReady(string adUnitId) { }

	// RVA: 0x63E5F80 Offset: 0x63E1F80 VA: 0x63E5F80
	public bool IsRewardAdReady(AdProvider provider, string adUnitId) { }

	// RVA: 0x63E6050 Offset: 0x63E2050 VA: 0x63E6050
	public bool IsRewardAdLoading(string adUnitId) { }

	// RVA: 0x63E6060 Offset: 0x63E2060 VA: 0x63E6060
	public bool IsRewardAdLoading(AdProvider provider, string adUnitId) { }

	// RVA: 0x63E6130 Offset: 0x63E2130 VA: 0x63E6130
	public bool IsRewardAdDisplaying(string adUnitId) { }

	// RVA: 0x63E6140 Offset: 0x63E2140 VA: 0x63E6140
	public bool IsRewardAdDisplaying(AdProvider provider, string adUnitId) { }
}

// Namespace: GorillaAd.Runtime
internal enum AdEventType // TypeDefIndex: 25815
{
	// Fields
	public int value__; // 0x0
	public const AdEventType LoadStart = 0;
	public const AdEventType LoadSuccess = 1;
	public const AdEventType LoadFailure = 2;
	public const AdEventType ShowStart = 3;
	public const AdEventType ShowSuccess = 4;
	public const AdEventType ShowFailure = 5;
	public const AdEventType Impression = 6;
	public const AdEventType Click = 7;
	public const AdEventType Close = 8;
	public const AdEventType Rewarded = 9;
	public const AdEventType AdPaid = 10;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class AdFactory.<>c // TypeDefIndex: 25816
{
	// Fields
	public static readonly AdFactory.<>c <>9; // 0x0
	public static Func<IAdProvider, bool> <>9__3_0; // 0x8
	public static Func<IAdProvider, AdProvider> <>9__3_1; // 0x10
	public static Func<IAdProvider, bool> <>9__4_0; // 0x18
	public static Func<IAdProvider, AdProvider> <>9__4_1; // 0x20
	public static Func<IAdProvider, bool> <>9__7_0; // 0x28
	public static Func<IAdProvider, bool> <>9__8_0; // 0x30

	// Methods

	// RVA: 0x63E719C Offset: 0x63E319C VA: 0x63E719C
	private static void .cctor() { }

	// RVA: 0x63E7204 Offset: 0x63E3204 VA: 0x63E7204
	public void .ctor() { }

	// RVA: 0x63E720C Offset: 0x63E320C VA: 0x63E720C
	internal bool <GetAvailableSdkProviders>b__3_0(IAdProvider provider) { }

	// RVA: 0x63E72AC Offset: 0x63E32AC VA: 0x63E72AC
	internal AdProvider <GetAvailableSdkProviders>b__3_1(IAdProvider provider) { }

	// RVA: 0x63E7348 Offset: 0x63E3348 VA: 0x63E7348
	internal bool <GetAvailableAdProviders>b__4_0(IAdProvider provider) { }

	// RVA: 0x63E73F0 Offset: 0x63E33F0 VA: 0x63E73F0
	internal AdProvider <GetAvailableAdProviders>b__4_1(IAdProvider provider) { }

	// RVA: 0x63E748C Offset: 0x63E348C VA: 0x63E748C
	internal bool <CreateAdInitializers>b__7_0(IAdProvider provider) { }

	// RVA: 0x63E752C Offset: 0x63E352C VA: 0x63E752C
	internal bool <CreateConsentFlows>b__8_0(IAdProvider provider) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AdFactory.<>c__DisplayClass15_0 // TypeDefIndex: 25817
{
	// Fields
	public AdProvider provider; // 0x10

	// Methods

	// RVA: 0x63E7194 Offset: 0x63E3194 VA: 0x63E7194
	public void .ctor() { }

	// RVA: 0x63E75CC Offset: 0x63E35CC VA: 0x63E75CC
	internal bool <FindProvider>b__0(IAdProvider e) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AdFactory.<>c__DisplayClass2_0 // TypeDefIndex: 25818
{
	// Fields
	public IAdProvider provider; // 0x10

	// Methods

	// RVA: 0x63E699C Offset: 0x63E299C VA: 0x63E699C
	public void .ctor() { }

	// RVA: 0x63E767C Offset: 0x63E367C VA: 0x63E767C
	internal bool <RegisterProvider>b__0(IAdProvider e) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AdFactory.<>c__DisplayClass5_0 // TypeDefIndex: 25819
{
	// Fields
	public AdProvider provider; // 0x10

	// Methods

	// RVA: 0x63E6BB0 Offset: 0x63E2BB0 VA: 0x63E6BB0
	public void .ctor() { }

	// RVA: 0x63E778C Offset: 0x63E378C VA: 0x63E778C
	internal bool <IsAdProviderAvailable>b__0(IAdProvider e) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AdFactory.<>c__DisplayClass6_0 // TypeDefIndex: 25820
{
	// Fields
	public AdProvider provider; // 0x10

	// Methods

	// RVA: 0x63E6CBC Offset: 0x63E2CBC VA: 0x63E6CBC
	public void .ctor() { }

	// RVA: 0x63E783C Offset: 0x63E383C VA: 0x63E783C
	internal bool <IsSdkProviderAvailable>b__0(IAdProvider e) { }
}

// Namespace: GorillaAd.Runtime
internal static class AdFactory // TypeDefIndex: 25821
{
	// Fields
	private static readonly List<IAdProvider> Providers; // 0x0

	// Methods

	// RVA: 0x63E66CC Offset: 0x63E26CC VA: 0x63E66CC
	private static void .cctor() { }

	// RVA: 0x63E67E0 Offset: 0x63E27E0 VA: 0x63E67E0
	internal static void RegisterProvider(IAdProvider provider) { }

	// RVA: 0x63E69A4 Offset: 0x63E29A4 VA: 0x63E69A4
	public static IReadOnlyList<AdProvider> GetAvailableSdkProviders() { }

	// RVA: 0x63E158C Offset: 0x63DD58C VA: 0x63E158C
	public static IReadOnlyList<AdProvider> GetAvailableAdProviders() { }

	// RVA: 0x63E2CA8 Offset: 0x63DECA8 VA: 0x63E2CA8
	public static bool IsAdProviderAvailable(AdProvider provider) { }

	// RVA: 0x63E6BB8 Offset: 0x63E2BB8 VA: 0x63E6BB8
	public static bool IsSdkProviderAvailable(AdProvider provider) { }

	// RVA: 0x63E1798 Offset: 0x63DD798 VA: 0x63E1798
	public static void CreateAdInitializers(AdSetting setting, Dictionary<AdProvider, IAdSdkInitializer> adInitializers) { }

	// RVA: 0x63E1D20 Offset: 0x63DDD20 VA: 0x63E1D20
	public static void CreateConsentFlows(AdSetting setting, Dictionary<AdProvider, IConsentFlow> consentFlows) { }

	// RVA: 0x63E6CC4 Offset: 0x63E2CC4 VA: 0x63E6CC4
	public static IRewardAd CreateRewardAd(AdProvider provider, string adUnitId) { }

	// RVA: 0x63E6EB4 Offset: 0x63E2EB4 VA: 0x63E6EB4
	public static IInterstitialAd CreateInterstitialAd(AdProvider provider, string adUnitId) { }

	// RVA: 0x63E65D0 Offset: 0x63E25D0 VA: 0x63E65D0
	public static IBannerAd CreateBannerAd(AdProvider provider, string adUnitId, BannerPosition position) { }

	// RVA: 0x63E6FA0 Offset: 0x63E2FA0 VA: 0x63E6FA0
	public static IRewardAd CreateRewardAd(string adUnitId) { }

	// RVA: 0x63E7040 Offset: 0x63E3040 VA: 0x63E7040
	public static IInterstitialAd CreateInterstitialAd(string adUnitId) { }

	// RVA: 0x63E70E0 Offset: 0x63E30E0 VA: 0x63E70E0
	public static IBannerAd CreateBannerAd(string adUnitId, BannerPosition position = 1) { }

	// RVA: 0x63E6DB0 Offset: 0x63E2DB0 VA: 0x63E6DB0
	private static IAdProvider FindProvider(AdProvider provider) { }

	// RVA: 0x63E6768 Offset: 0x63E2768 VA: 0x63E6768
	private static void RegisterBuiltInProviders() { }
}

// Namespace: GorillaAd.Runtime
[Preserve]
[Serializable]
public enum AdLoadError // TypeDefIndex: 25822
{
	// Fields
	public int value__; // 0x0
	[Preserve]
	public const AdLoadError NoAD = 0;
	[Preserve]
	public const AdLoadError NetworkFail = 1;
	[Preserve]
	public const AdLoadError Unknown = 2;
}

// Namespace: GorillaAd.Runtime
internal static class AdNetworkNames // TypeDefIndex: 25823
{
	// Fields
	public const string Admob = "Admob";
	public const string AppLovin = "AppLovin";
	public const string Vungle = "Vungle";
	public const string Csj = "CSJ";
	public const string FallbackLocalVideo = "FallbackLocalVideo";
	public const string WeChatMiniGame = "WeChatMiniGame";
	public const string DouyinMiniGame = "DouyinMiniGame";
	public const string TikTokMiniGame = "TikTokMiniGame";

	// Methods

	// RVA: 0x63E7954 Offset: 0x63E3954 VA: 0x63E7954
	public static string FromProvider(AdProvider provider) { }
}

// Namespace: GorillaAd.Runtime
public class AdPaidEventData // TypeDefIndex: 25824
{
	// Fields
	[CompilerGenerated]
	private readonly string <Source>k__BackingField; // 0x10
	[CompilerGenerated]
	private double <Revenue>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Currency>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <RevenueNetwork>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <RevenueUnit>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <RevenuePlacement>k__BackingField; // 0x38

	// Properties
	public string Source { get; }
	public double Revenue { get; set; }
	public string Currency { get; set; }
	public string RevenueNetwork { get; set; }
	public string RevenueUnit { get; set; }
	public string RevenuePlacement { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x63E7AA0 Offset: 0x63E3AA0 VA: 0x63E7AA0
	public string get_Source() { }

	[CompilerGenerated]
	// RVA: 0x63E7AA8 Offset: 0x63E3AA8 VA: 0x63E7AA8
	public double get_Revenue() { }

	[CompilerGenerated]
	// RVA: 0x63E7AB0 Offset: 0x63E3AB0 VA: 0x63E7AB0
	public void set_Revenue(double value) { }

	[CompilerGenerated]
	// RVA: 0x63E7AB8 Offset: 0x63E3AB8 VA: 0x63E7AB8
	public string get_Currency() { }

	[CompilerGenerated]
	// RVA: 0x63E7AC0 Offset: 0x63E3AC0 VA: 0x63E7AC0
	public void set_Currency(string value) { }

	[CompilerGenerated]
	// RVA: 0x63E7AC8 Offset: 0x63E3AC8 VA: 0x63E7AC8
	public string get_RevenueNetwork() { }

	[CompilerGenerated]
	// RVA: 0x63E7AD0 Offset: 0x63E3AD0 VA: 0x63E7AD0
	public void set_RevenueNetwork(string value) { }

	[CompilerGenerated]
	// RVA: 0x63E7AD8 Offset: 0x63E3AD8 VA: 0x63E7AD8
	public string get_RevenueUnit() { }

	[CompilerGenerated]
	// RVA: 0x63E7AE0 Offset: 0x63E3AE0 VA: 0x63E7AE0
	public void set_RevenueUnit(string value) { }

	[CompilerGenerated]
	// RVA: 0x63E7AE8 Offset: 0x63E3AE8 VA: 0x63E7AE8
	public string get_RevenuePlacement() { }

	[CompilerGenerated]
	// RVA: 0x63E7AF0 Offset: 0x63E3AF0 VA: 0x63E7AF0
	public void set_RevenuePlacement(string value) { }

	// RVA: 0x63E7AF8 Offset: 0x63E3AF8 VA: 0x63E7AF8
	public void .ctor(string source) { }

	// RVA: 0x63E7B28 Offset: 0x63E3B28 VA: 0x63E7B28 Slot: 3
	public override string ToString() { }
}

// Namespace: GorillaAd.Runtime
[Preserve]
public class AdRuntimeContext // TypeDefIndex: 25825
{
	// Fields
	private readonly Dictionary<Type, IAdRuntimeContextExtension> _extensions; // 0x10

	// Methods

	[Preserve]
	// RVA: -1 Offset: -1
	public void SetExtension<T>(T extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B684C Offset: 0x44B284C VA: 0x44B684C
	|-AdRuntimeContext.SetExtension<object>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	public T GetExtension<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B6730 Offset: 0x44B2730 VA: 0x44B6730
	|-AdRuntimeContext.GetExtension<object>
	*/

	// RVA: 0x63E7D64 Offset: 0x63E3D64 VA: 0x63E7D64
	public void .ctor() { }
}

// Namespace: GorillaAd.Runtime
public static class EventName // TypeDefIndex: 25826
{
	// Fields
	public const string SdkInit = "sdk_init";
	public const string AdLoad = "ad_load";
	public const string AdWatch = "ad_watch";
}

// Namespace: GorillaAd.Runtime
internal static class EventTracker // TypeDefIndex: 25827
{
	// Fields
	public static Action<string, Dictionary<string, object>> OnAdEvent; // 0x0

	// Methods

	// RVA: 0x63E7DEC Offset: 0x63E3DEC VA: 0x63E7DEC
	public static void SDKInitEvent(string sdkName, long duration, string errorMsg = "") { }

	// RVA: 0x63E3D94 Offset: 0x63DFD94 VA: 0x63E3D94
	public static void AdLoadEvent(AdEventType type, IAd sender, int code = 0, string message = "") { }

	// RVA: 0x63E4260 Offset: 0x63E0260 VA: 0x63E4260
	public static void AdWatchEvent(AdEventType type, IAd sender, int code = 0, string message = "", Dictionary<string, object> customData) { }

	// RVA: 0x63E3958 Offset: 0x63DF958 VA: 0x63E3958
	public static void AdPlayStartEvent(string adUnitId, Nullable<AdFormat> format, Nullable<AdProvider> provider, Dictionary<string, object> customData, long duration = 0) { }

	// RVA: 0x63E7FF0 Offset: 0x63E3FF0 VA: 0x63E7FF0
	private static void MergePaidData(Dictionary<string, object> properties, AdPaidEventData paidData) { }

	// RVA: 0x63E8194 Offset: 0x63E4194 VA: 0x63E8194
	private static void MergeCustomData(Dictionary<string, object> properties, Dictionary<string, object> customData) { }

	// RVA: 0x63E8348 Offset: 0x63E4348 VA: 0x63E8348
	private static string GetAdType(AdFormat format) { }

	// RVA: 0x63E7FEC Offset: 0x63E3FEC VA: 0x63E7FEC
	private static void MergeResponse(IAd sender, Dictionary<string, object> properties) { }
}

// Namespace: GorillaAd.Runtime
internal sealed class FallbackHost : MonoBehaviour // TypeDefIndex: 25828
{
	// Fields
	private static FallbackHost _inst; // 0x0
	[CompilerGenerated]
	private LocalRewardedVideoPlayer <Player>k__BackingField; // 0x20
	[CompilerGenerated]
	private RewardedVideoCacheManager <CacheManager>k__BackingField; // 0x28

	// Properties
	public static FallbackHost Instance { get; }
	public LocalRewardedVideoPlayer Player { get; set; }
	public RewardedVideoCacheManager CacheManager { get; set; }

	// Methods

	// RVA: 0x63E83C8 Offset: 0x63E43C8 VA: 0x63E83C8
	public static FallbackHost get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x63E84F4 Offset: 0x63E44F4 VA: 0x63E84F4
	public LocalRewardedVideoPlayer get_Player() { }

	[CompilerGenerated]
	// RVA: 0x63E84FC Offset: 0x63E44FC VA: 0x63E84FC
	private void set_Player(LocalRewardedVideoPlayer value) { }

	[CompilerGenerated]
	// RVA: 0x63E8504 Offset: 0x63E4504 VA: 0x63E8504
	public RewardedVideoCacheManager get_CacheManager() { }

	[CompilerGenerated]
	// RVA: 0x63E850C Offset: 0x63E450C VA: 0x63E850C
	private void set_CacheManager(RewardedVideoCacheManager value) { }

	// RVA: 0x63E8514 Offset: 0x63E4514 VA: 0x63E8514
	private void Awake() { }

	// RVA: 0x63E85B8 Offset: 0x63E45B8 VA: 0x63E85B8
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FallbackRewardedVideo.<>c__DisplayClass19_0 // TypeDefIndex: 25829
{
	// Fields
	public Action onSuccess; // 0x10
	public Action<string> onFailure; // 0x18

	// Methods

	// RVA: 0x63E8B7C Offset: 0x63E4B7C VA: 0x63E8B7C
	public void .ctor() { }

	// RVA: 0x63E9650 Offset: 0x63E5650 VA: 0x63E9650
	internal void <Load>b__0() { }

	// RVA: 0x63E966C Offset: 0x63E566C VA: 0x63E966C
	internal void <Load>b__1(string msg) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FallbackRewardedVideo.<>c__DisplayClass23_0 // TypeDefIndex: 25830
{
	// Fields
	public Action onShowSuccess; // 0x10
	public Action<string> onShowFailure; // 0x18
	public Action<bool> onClose; // 0x20

	// Methods

	// RVA: 0x63E8FF8 Offset: 0x63E4FF8 VA: 0x63E8FF8
	public void .ctor() { }

	// RVA: 0x63E9688 Offset: 0x63E5688 VA: 0x63E9688
	internal void <Show>b__0() { }

	// RVA: 0x63E96A4 Offset: 0x63E56A4 VA: 0x63E96A4
	internal void <Show>b__1(string msg) { }

	// RVA: 0x63E96C0 Offset: 0x63E56C0 VA: 0x63E96C0
	internal void <Show>b__2(bool reward) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FallbackRewardedVideo.<>c__DisplayClass24_0 // TypeDefIndex: 25831
{
	// Fields
	public string fallbackPlayable; // 0x10

	// Methods

	// RVA: 0x63E96E0 Offset: 0x63E56E0 VA: 0x63E96E0
	public void .ctor() { }

	// RVA: 0x63E96E8 Offset: 0x63E56E8 VA: 0x63E96E8
	internal void <CoLoad>b__0(string path) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FallbackRewardedVideo.<CoLoad>d__24 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 25832
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string remoteUrl; // 0x20
	private FallbackRewardedVideo.<>c__DisplayClass24_0 <>8__1; // 0x28
	public Action<string> onLoadFailure; // 0x30
	public Action onLoadSuccess; // 0x38

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x63E917C Offset: 0x63E517C VA: 0x63E917C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x63E96F0 Offset: 0x63E56F0 VA: 0x63E96F0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x63E96F4 Offset: 0x63E56F4 VA: 0x63E96F4 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x63EA0B0 Offset: 0x63E60B0 VA: 0x63EA0B0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x63EA0B8 Offset: 0x63E60B8 VA: 0x63EA0B8 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x63EA0F0 Offset: 0x63E60F0 VA: 0x63EA0F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FallbackRewardedVideo.<EnsureFallbackExtractedAndroid>d__26 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 25833
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Action<string> onPathReady; // 0x20
	private UnityWebRequest <req>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x63E9328 Offset: 0x63E5328 VA: 0x63E9328
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x63EA0F8 Offset: 0x63E60F8 VA: 0x63EA0F8 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x63EA114 Offset: 0x63E6114 VA: 0x63EA114 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x63EA564 Offset: 0x63E6564 VA: 0x63EA564
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x63EA614 Offset: 0x63E6614 VA: 0x63EA614 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x63EA61C Offset: 0x63E661C VA: 0x63EA61C Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x63EA654 Offset: 0x63E6654 VA: 0x63EA654 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: GorillaAd.Runtime
public static class FallbackRewardedVideo // TypeDefIndex: 25834
{
	// Fields
	private const string Tag = "[FallbackRewardedVideo]";
	private const string FallbackRelativePath = "RewardedFallback/fallback.mp4";
	private static Coroutine _loadCoroutine; // 0x0
	[CompilerGenerated]
	private static string <RemoteUrl>k__BackingField; // 0x8
	[CompilerGenerated]
	private static string <RedirectUrl>k__BackingField; // 0x10
	[CompilerGenerated]
	private static bool <IsSkipPlaying>k__BackingField; // 0x18

	// Properties
	private static string PersistFallbackPath { get; }
	private static string PersistFallbackTmpPath { get; }
	public static string RemoteUrl { get; set; }
	public static string RedirectUrl { get; set; }
	public static bool IsSkipPlaying { get; set; }

	// Methods

	// RVA: 0x63E85C0 Offset: 0x63E45C0 VA: 0x63E85C0
	private static string get_PersistFallbackPath() { }

	// RVA: 0x63E8678 Offset: 0x63E4678 VA: 0x63E8678
	private static string get_PersistFallbackTmpPath() { }

	[CompilerGenerated]
	// RVA: 0x63E8730 Offset: 0x63E4730 VA: 0x63E8730
	public static string get_RemoteUrl() { }

	[CompilerGenerated]
	// RVA: 0x63E8778 Offset: 0x63E4778 VA: 0x63E8778
	public static void set_RemoteUrl(string value) { }

	[CompilerGenerated]
	// RVA: 0x63E87C8 Offset: 0x63E47C8 VA: 0x63E87C8
	public static string get_RedirectUrl() { }

	[CompilerGenerated]
	// RVA: 0x63E8810 Offset: 0x63E4810 VA: 0x63E8810
	public static void set_RedirectUrl(string value) { }

	[CompilerGenerated]
	// RVA: 0x63E8860 Offset: 0x63E4860 VA: 0x63E8860
	public static bool get_IsSkipPlaying() { }

	[CompilerGenerated]
	// RVA: 0x63E88A8 Offset: 0x63E48A8 VA: 0x63E88A8
	public static void set_IsSkipPlaying(bool value) { }

	// RVA: 0x63E88F8 Offset: 0x63E48F8 VA: 0x63E88F8
	public static void Load(Action onSuccess, Action<string> onFailure) { }

	// RVA: 0x63E8C20 Offset: 0x63E4C20 VA: 0x63E8C20
	public static bool IsReady() { }

	// RVA: 0x63E8CA4 Offset: 0x63E4CA4 VA: 0x63E8CA4
	public static bool IsPreparing() { }

	// RVA: 0x63E8D38 Offset: 0x63E4D38 VA: 0x63E8D38
	public static bool IsShowing() { }

	// RVA: 0x63E8DCC Offset: 0x63E4DCC VA: 0x63E8DCC
	public static void Show(Action onShowSuccess, Action<string> onShowFailure, Action<bool> onClose, Action onClick) { }

	[IteratorStateMachine(typeof(FallbackRewardedVideo.<CoLoad>d__24))]
	// RVA: 0x63E8B84 Offset: 0x63E4B84 VA: 0x63E8B84
	private static IEnumerator CoLoad(string remoteUrl, Action onLoadSuccess, Action<string> onLoadFailure) { }

	// RVA: 0x63E91A4 Offset: 0x63E51A4 VA: 0x63E91A4
	private static bool IsValidRemoteUrl(string remoteUrl) { }

	[IteratorStateMachine(typeof(FallbackRewardedVideo.<EnsureFallbackExtractedAndroid>d__26))]
	// RVA: 0x63E92BC Offset: 0x63E52BC VA: 0x63E92BC
	private static IEnumerator EnsureFallbackExtractedAndroid(Action<string> onPathReady) { }

	// RVA: 0x63E9350 Offset: 0x63E5350 VA: 0x63E9350
	private static bool TryCreateDirectory(string dir) { }

	// RVA: 0x63E9440 Offset: 0x63E5440 VA: 0x63E9440
	private static void SafeDeleteFile(string path) { }

	// RVA: 0x63E9544 Offset: 0x63E5544 VA: 0x63E9544
	private static void SafeMoveFile(string src, string dst) { }
}

// Namespace: GorillaAd.Runtime
internal sealed class LocalRewardedVideoAd : IRewardAd, IAd // TypeDefIndex: 25835
{
	// Fields
	public const string AdUnitId = "build_in_fallback";
	private const string Network = "FallbackLocalVideo";
	[CompilerGenerated]
	private string <RewardType>k__BackingField; // 0x10
	[CompilerGenerated]
	private double <RewardAmount>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <IsLoading>k__BackingField; // 0x20
	[CompilerGenerated]
	private Action<IAd> OnLoadStart; // 0x28
	[CompilerGenerated]
	private Action<IAd> OnLoadSuccess; // 0x30
	[CompilerGenerated]
	private Action<IAd, int, string> OnLoadFailure; // 0x38
	[CompilerGenerated]
	private Action<IAd> OnShowStart; // 0x40
	[CompilerGenerated]
	private Action<IAd> OnShowSuccess; // 0x48
	[CompilerGenerated]
	private Action<IAd, int, string> OnShowFailure; // 0x50
	[CompilerGenerated]
	private Action<IAd> OnImpression; // 0x58
	[CompilerGenerated]
	private Action<IAd> OnClicked; // 0x60
	[CompilerGenerated]
	private Action<IAd> OnClosed; // 0x68
	[CompilerGenerated]
	private Action<IRewardAd> OnRewarded; // 0x70

	// Properties
	public string RewardType { get; set; }
	public double RewardAmount { get; set; }
	private string GorillaAd.Runtime.IAd.AdUnitId { get; }
	public string NetworkName { get; }
	public bool IsLoading { get; set; }
	public bool IsDisplaying { get; }
	public object ResponseInfo { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x63EA65C Offset: 0x63E665C VA: 0x63EA65C Slot: 4
	public string get_RewardType() { }

	[CompilerGenerated]
	// RVA: 0x63EA664 Offset: 0x63E6664 VA: 0x63EA664
	private void set_RewardType(string value) { }

	[CompilerGenerated]
	// RVA: 0x63EA66C Offset: 0x63E666C VA: 0x63EA66C Slot: 5
	public double get_RewardAmount() { }

	[CompilerGenerated]
	// RVA: 0x63EA674 Offset: 0x63E6674 VA: 0x63EA674
	private void set_RewardAmount(double value) { }

	// RVA: 0x63EA67C Offset: 0x63E667C VA: 0x63EA67C Slot: 8
	private string GorillaAd.Runtime.IAd.get_AdUnitId() { }

	// RVA: 0x63EA6BC Offset: 0x63E66BC VA: 0x63EA6BC Slot: 9
	public string get_NetworkName() { }

	[CompilerGenerated]
	// RVA: 0x63EA6FC Offset: 0x63E66FC VA: 0x63EA6FC Slot: 10
	public bool get_IsLoading() { }

	[CompilerGenerated]
	// RVA: 0x63EA704 Offset: 0x63E6704 VA: 0x63EA704
	private void set_IsLoading(bool value) { }

	// RVA: 0x63EA710 Offset: 0x63E6710 VA: 0x63EA710 Slot: 11
	public bool get_IsDisplaying() { }

	// RVA: 0x63EA714 Offset: 0x63E6714 VA: 0x63EA714 Slot: 12
	public object get_ResponseInfo() { }

	[CompilerGenerated]
	// RVA: 0x63EA71C Offset: 0x63E671C VA: 0x63EA71C Slot: 17
	public void add_OnLoadStart(Action<IAd> value) { }

	[CompilerGenerated]
	// RVA: 0x63EA7CC Offset: 0x63E67CC VA: 0x63EA7CC Slot: 18
	public void remove_OnLoadStart(Action<IAd> value) { }

	[CompilerGenerated]
	// RVA: 0x63EA87C Offset: 0x63E687C VA: 0x63EA87C Slot: 19
	public void add_OnLoadSuccess(Action<IAd> value) { }

	[CompilerGenerated]
	// RVA: 0x63EA92C Offset: 0x63E692C VA: 0x63EA92C Slot: 20
	public void remove_OnLoadSuccess(Action<IAd> value) { }

	[CompilerGenerated]
	// RVA: 0x63EA9DC Offset: 0x63E69DC VA: 0x63EA9DC Slot: 21
	public void add_OnLoadFailure(Action<IAd, int, string> value) { }

	[CompilerGenerated]
	// RVA: 0x63EAA8C Offset: 0x63E6A8C VA: 0x63EAA8C Slot: 22
	public void remove_OnLoadFailure(Action<IAd, int, string> value) { }

	[CompilerGenerated]
	// RVA: 0x63EAB3C Offset: 0x63E6B3C VA: 0x63EAB3C Slot: 23
	public void add_OnShowStart(Action<IAd> value) { }

	[CompilerGenerated]
	// RVA: 0x63EABEC Offset: 0x63E6BEC VA: 0x63EABEC Slot: 24
	public void remove_OnShowStart(Action<IAd> value) { }

	[CompilerGenerated]
	// RVA: 0x63EAC9C Offset: 0x63E6C9C VA: 0x63EAC9C Slot: 25
	public void add_OnShowSuccess(Action<IAd> value) { }

	[CompilerGenerated]
	// RVA: 0x63EAD4C Offset: 0x63E6D4C VA: 0x63EAD4C Slot: 26
	public void remove_OnShowSuccess(Action<IAd> value) { }

	[CompilerGenerated]
	// RVA: 0x63EADFC Offset: 0x63E6DFC VA: 0x63EADFC Slot: 27
	public void add_OnShowFailure(Action<IAd, int, string> value) { }

	[CompilerGenerated]
	// RVA: 0x63EAEAC Offset: 0x63E6EAC VA: 0x63EAEAC Slot: 28
	public void remove_OnShowFailure(Action<IAd, int, string> value) { }

	[CompilerGenerated]
	// RVA: 0x63EAF5C Offset: 0x63E6F5C VA: 0x63EAF5C Slot: 29
	public void add_OnImpression(Action<IAd> value) { }

	[CompilerGenerated]
	// RVA: 0x63EB00C Offset: 0x63E700C VA: 0x63EB00C Slot: 30
	public void remove_OnImpression(Action<IAd> value) { }

	[CompilerGenerated]
	// RVA: 0x63EB0BC Offset: 0x63E70BC VA: 0x63EB0BC Slot: 31
	public void add_OnClicked(Action<IAd> value) { }

	[CompilerGenerated]
	// RVA: 0x63EB16C Offset: 0x63E716C VA: 0x63EB16C Slot: 32
	public void remove_OnClicked(Action<IAd> value) { }

	[CompilerGenerated]
	// RVA: 0x63EB21C Offset: 0x63E721C VA: 0x63EB21C Slot: 33
	public void add_OnClosed(Action<IAd> value) { }

	[CompilerGenerated]
	// RVA: 0x63EB2CC Offset: 0x63E72CC VA: 0x63EB2CC Slot: 34
	public void remove_OnClosed(Action<IAd> value) { }

	[CompilerGenerated]
	// RVA: 0x63EB37C Offset: 0x63E737C VA: 0x63EB37C Slot: 6
	public void add_OnRewarded(Action<IRewardAd> value) { }

	[CompilerGenerated]
	// RVA: 0x63EB42C Offset: 0x63E742C VA: 0x63EB42C Slot: 7
	public void remove_OnRewarded(Action<IRewardAd> value) { }

	// RVA: 0x63EB4DC Offset: 0x63E74DC VA: 0x63EB4DC Slot: 35
	private void GorillaAd.Runtime.IAd.add_OnAdPaid(Action<IAd, AdPaidEventData> value) { }

	// RVA: 0x63EB4E0 Offset: 0x63E74E0 VA: 0x63EB4E0 Slot: 36
	private void GorillaAd.Runtime.IAd.remove_OnAdPaid(Action<IAd, AdPaidEventData> value) { }

	// RVA: 0x63EB4E4 Offset: 0x63E74E4 VA: 0x63EB4E4 Slot: 13
	public void Load() { }

	// RVA: 0x63EB5E0 Offset: 0x63E75E0 VA: 0x63EB5E0 Slot: 14
	public void Show() { }

	// RVA: 0x63EB864 Offset: 0x63E7864 VA: 0x63EB864 Slot: 15
	public bool IsReady() { }

	// RVA: 0x63EB868 Offset: 0x63E7868 VA: 0x63EB868 Slot: 16
	public AdLoadError GetLoadError(int code) { }

	// RVA: 0x63EB870 Offset: 0x63E7870 VA: 0x63EB870
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x63EB8D0 Offset: 0x63E78D0 VA: 0x63EB8D0
	private void <Load>b__55_0() { }

	[CompilerGenerated]
	// RVA: 0x63EB8F4 Offset: 0x63E78F4 VA: 0x63EB8F4
	private void <Load>b__55_1(string message) { }

	[CompilerGenerated]
	// RVA: 0x63EB920 Offset: 0x63E7920 VA: 0x63EB920
	private void <Show>b__56_0() { }

	[CompilerGenerated]
	// RVA: 0x63EB96C Offset: 0x63E796C VA: 0x63EB96C
	private void <Show>b__56_1(string message) { }

	[CompilerGenerated]
	// RVA: 0x63EB998 Offset: 0x63E7998 VA: 0x63EB998
	private void <Show>b__56_2(bool rewarded) { }

	[CompilerGenerated]
	// RVA: 0x63EB9E8 Offset: 0x63E79E8 VA: 0x63EB9E8
	private void <Show>b__56_3() { }
}

// Namespace: 
private enum LocalRewardedVideoPlayer.State // TypeDefIndex: 25836
{
	// Fields
	public int value__; // 0x0
	public const LocalRewardedVideoPlayer.State Idle = 0;
	public const LocalRewardedVideoPlayer.State Preparing = 1;
	public const LocalRewardedVideoPlayer.State Ready = 2;
	public const LocalRewardedVideoPlayer.State Showing = 3;
	public const LocalRewardedVideoPlayer.State Completed = 4;
}

// Namespace: 
[CompilerGenerated]
private sealed class LocalRewardedVideoPlayer.<PlayNextFrame>d__43 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 25837
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public LocalRewardedVideoPlayer <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x63ECDC0 Offset: 0x63E8DC0 VA: 0x63ECDC0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x63EDFA0 Offset: 0x63E9FA0 VA: 0x63EDFA0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x63EDFA4 Offset: 0x63E9FA4 VA: 0x63EDFA4 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x63EE11C Offset: 0x63EA11C VA: 0x63EE11C Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x63EE124 Offset: 0x63EA124 VA: 0x63EE124 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x63EE15C Offset: 0x63EA15C VA: 0x63EE15C Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: GorillaAd.Runtime
internal sealed class LocalRewardedVideoPlayer : MonoBehaviour // TypeDefIndex: 25838
{
	// Fields
	private const string Tag = "[LocalRewardedVideoPlayer]";
	private const int MinRenderTextureSize = 16;
	private const float ClickCooldownSeconds = 0.5;
	[CompilerGenerated]
	private bool <IsReady>k__BackingField; // 0x20
	private LocalRewardedVideoPlayer.State _state; // 0x24
	private string _sourceUrlOrPath; // 0x28
	private VideoPlayer _videoPlayer; // 0x30
	private RenderTexture _renderTexture; // 0x38
	private AudioSource _audioSource; // 0x40
	private GameObject _root; // 0x48
	private CanvasGroup _canvasGroup; // 0x50
	private RectTransform _safeAreaPanel; // 0x58
	private RawImage _raw; // 0x60
	private AspectRatioFitter _aspectFitter; // 0x68
	private Text _countdownText; // 0x70
	private Button _closeButton; // 0x78
	private Image _closeImage; // 0x80
	private Button _clickButton; // 0x88
	private Action _onLoadSuccess; // 0x90
	private Action<string> _onLoadFailed; // 0x98
	private Action _onShowSuccess; // 0xA0
	private Action<string> _onShowFailed; // 0xA8
	private Action<bool> _onClose; // 0xB0
	private Action _onClick; // 0xB8
	private string _redirectUrl; // 0xC0
	private float _lastClickTime; // 0xC8
	private Rect _lastSafeArea; // 0xCC
	private ScreenOrientation _lastOrientation; // 0xDC
	private float _volume; // 0xE0
	private bool _muted; // 0xE4

	// Properties
	public bool IsReady { get; set; }
	public bool IsPreparing { get; }
	public bool IsShowing { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x63EBA08 Offset: 0x63E7A08 VA: 0x63EBA08
	public bool get_IsReady() { }

	[CompilerGenerated]
	// RVA: 0x63EBA10 Offset: 0x63E7A10 VA: 0x63EBA10
	private void set_IsReady(bool value) { }

	// RVA: 0x63E8D28 Offset: 0x63E4D28 VA: 0x63E8D28
	public bool get_IsPreparing() { }

	// RVA: 0x63E8DBC Offset: 0x63E4DBC VA: 0x63E8DBC
	public bool get_IsShowing() { }

	// RVA: 0x63EBA1C Offset: 0x63E7A1C VA: 0x63EBA1C
	public void SetVolume(float volume01) { }

	// RVA: 0x63EBAD4 Offset: 0x63E7AD4 VA: 0x63EBAD4
	public void SetMuted(bool muted) { }

	// RVA: 0x63EBAE0 Offset: 0x63E7AE0 VA: 0x63EBAE0
	public void ResetAudioToSystem() { }

	// RVA: 0x63E9BC4 Offset: 0x63E5BC4 VA: 0x63E9BC4
	public void Load(string urlOrPath, Action onSuccess, Action<string> onFailure) { }

	// RVA: 0x63E9000 Offset: 0x63E5000 VA: 0x63E9000
	public void Show(Action onShowSuccess, Action<string> onShowFailed, Action<bool> onClose, Action onClick, string redirectUrl) { }

	[IteratorStateMachine(typeof(LocalRewardedVideoPlayer.<PlayNextFrame>d__43))]
	// RVA: 0x63ECD54 Offset: 0x63E8D54 VA: 0x63ECD54
	private IEnumerator PlayNextFrame() { }

	// RVA: 0x63ECDE8 Offset: 0x63E8DE8 VA: 0x63ECDE8
	private void Update() { }

	// RVA: 0x63ED010 Offset: 0x63E9010 VA: 0x63ED010
	private void OnApplicationPause(bool pause) { }

	// RVA: 0x63ECED8 Offset: 0x63E8ED8 VA: 0x63ECED8
	private void UpdateCountdownText() { }

	// RVA: 0x63ED2E8 Offset: 0x63E92E8 VA: 0x63ED2E8
	private void OnCloseClicked() { }

	// RVA: 0x63ED344 Offset: 0x63E9344 VA: 0x63ED344
	private void OnVideoClicked() { }

	// RVA: 0x63EBAF0 Offset: 0x63E7AF0 VA: 0x63EBAF0
	private void ForceReset() { }

	// RVA: 0x63EBA38 Offset: 0x63E7A38 VA: 0x63EBA38
	private void ApplyAudioSettings() { }

	// RVA: 0x63ED7C0 Offset: 0x63E97C0 VA: 0x63ED7C0
	private void OnPrepareCompleted(VideoPlayer _) { }

	// RVA: 0x63ED8F4 Offset: 0x63E98F4 VA: 0x63ED8F4
	private void OnErrorReceived(VideoPlayer _, string msg) { }

	// RVA: 0x63EDA20 Offset: 0x63E9A20 VA: 0x63EDA20
	private void OnLoopPointReached(VideoPlayer _) { }

	// RVA: 0x63EDB9C Offset: 0x63E9B9C VA: 0x63EDB9C
	private void OnVideoStarted(VideoPlayer _) { }

	// RVA: 0x63EBCA8 Offset: 0x63E7CA8 VA: 0x63EBCA8
	private void BuildUI() { }

	// RVA: 0x63EC904 Offset: 0x63E8904 VA: 0x63EC904
	private void ApplySafeArea() { }

	// RVA: 0x63ECA68 Offset: 0x63E8A68 VA: 0x63ECA68
	private void CreateOrResizeRenderTexture() { }

	// RVA: 0x63EDE90 Offset: 0x63E9E90 VA: 0x63EDE90
	private Vector2Int GetRenderTextureSize() { }

	// RVA: 0x63ECC68 Offset: 0x63E8C68 VA: 0x63ECC68
	private void ShowUI() { }

	// RVA: 0x63EDDB8 Offset: 0x63E9DB8 VA: 0x63EDDB8
	private void HideUI() { }

	// RVA: 0x63ED4C0 Offset: 0x63E94C0 VA: 0x63ED4C0
	private void DestroyUI() { }

	// RVA: 0x63EDBD8 Offset: 0x63E9BD8 VA: 0x63EDBD8
	private static Sprite CreateXSprite(int size, int thickness) { }

	// RVA: 0x63ED154 Offset: 0x63E9154 VA: 0x63ED154
	private static string FormatCountdown(int seconds) { }

	// RVA: 0x63ED05C Offset: 0x63E905C VA: 0x63ED05C
	private static string GetUnknownCountdownText() { }

	// RVA: 0x63EDF88 Offset: 0x63E9F88 VA: 0x63EDF88
	public void .ctor() { }
}

// Namespace: 
[Serializable]
private class RewardedVideoCacheManager.IndexModel // TypeDefIndex: 25839
{
	// Fields
	public List<RewardedVideoCacheManager.Entry> entries; // 0x10

	// Methods

	// RVA: 0x63EE940 Offset: 0x63EA940 VA: 0x63EE940
	public void .ctor() { }
}

// Namespace: 
[Serializable]
private class RewardedVideoCacheManager.Entry // TypeDefIndex: 25840
{
	// Fields
	public string hash; // 0x10
	public long lastFailAtUtc; // 0x18

	// Methods

	// RVA: 0x63EED8C Offset: 0x63EAD8C VA: 0x63EED8C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RewardedVideoCacheManager.<>c__DisplayClass24_0 // TypeDefIndex: 25841
{
	// Fields
	public string hash; // 0x10

	// Methods

	// RVA: 0x63EEC70 Offset: 0x63EAC70 VA: 0x63EEC70
	public void .ctor() { }

	// RVA: 0x63EF500 Offset: 0x63EB500 VA: 0x63EF500
	internal bool <FindEntryByHash>b__0(RewardedVideoCacheManager.Entry x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RewardedVideoCacheManager.<>c__DisplayClass28_0 // TypeDefIndex: 25842
{
	// Fields
	public string keepHash; // 0x10

	// Methods

	// RVA: 0x63EF210 Offset: 0x63EB210 VA: 0x63EF210
	public void .ctor() { }

	// RVA: 0x63EF528 Offset: 0x63EB528 VA: 0x63EF528
	internal bool <CleanupKeepOnlyAndTmp>b__0(RewardedVideoCacheManager.Entry e) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RewardedVideoCacheManager.<DownloadCoroutine>d__19 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 25843
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string hash; // 0x20
	public string url; // 0x28
	public RewardedVideoCacheManager <>4__this; // 0x30
	private string <finalPath>5__2; // 0x38
	private string <tmpPath>5__3; // 0x40
	private UnityWebRequest <req>5__4; // 0x48

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x63EE674 Offset: 0x63EA674 VA: 0x63EE674
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x63EF550 Offset: 0x63EB550 VA: 0x63EF550 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x63EF56C Offset: 0x63EB56C VA: 0x63EF56C Slot: 6
	private bool MoveNext() { }

	// RVA: 0x63EFB30 Offset: 0x63EBB30 VA: 0x63EFB30
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x63EFBE0 Offset: 0x63EBBE0 VA: 0x63EFBE0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x63EFBE8 Offset: 0x63EBBE8 VA: 0x63EFBE8 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x63EFC20 Offset: 0x63EBC20 VA: 0x63EFC20 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: GorillaAd.Runtime
internal sealed class RewardedVideoCacheManager : MonoBehaviour // TypeDefIndex: 25844
{
	// Fields
	private const string Tag = "[RewardedVideoCacheManager]";
	public int timeoutSeconds; // 0x20
	public float failCooldownSeconds; // 0x24
	[CompilerGenerated]
	private string <CurrentUrl>k__BackingField; // 0x28
	private bool _downloading; // 0x30
	private string _downloadingUrl; // 0x38
	private Coroutine _downloadCo; // 0x40
	private RewardedVideoCacheManager.IndexModel _index; // 0x48

	// Properties
	public string CurrentUrl { get; set; }
	private static string CacheDir { get; }
	private static string IndexPath { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x63EE164 Offset: 0x63EA164 VA: 0x63EE164
	public string get_CurrentUrl() { }

	[CompilerGenerated]
	// RVA: 0x63EE16C Offset: 0x63EA16C VA: 0x63EE16C
	public void set_CurrentUrl(string value) { }

	// RVA: 0x63EE174 Offset: 0x63EA174 VA: 0x63EE174
	private static string get_CacheDir() { }

	// RVA: 0x63EE214 Offset: 0x63EA214 VA: 0x63EE214
	private static string get_IndexPath() { }

	// RVA: 0x63E99FC Offset: 0x63E59FC VA: 0x63E99FC
	public string GetCachedPath() { }

	// RVA: 0x63E9AE0 Offset: 0x63E5AE0 VA: 0x63E9AE0
	public bool EnsureDownloadCurrent() { }

	[IteratorStateMachine(typeof(RewardedVideoCacheManager.<DownloadCoroutine>d__19))]
	// RVA: 0x63EE5D8 Offset: 0x63EA5D8 VA: 0x63EE5D8
	private IEnumerator DownloadCoroutine(string url, string hash) { }

	// RVA: 0x63EE548 Offset: 0x63EA548 VA: 0x63EE548
	private void StopDownload() { }

	// RVA: 0x63EE69C Offset: 0x63EA69C VA: 0x63EE69C
	private void FinishDownload() { }

	// RVA: 0x63EE704 Offset: 0x63EA704 VA: 0x63EE704
	private void LoadIndex() { }

	// RVA: 0x63EEA90 Offset: 0x63EAA90 VA: 0x63EEA90
	private void SaveIndex() { }

	// RVA: 0x63EEB88 Offset: 0x63EAB88 VA: 0x63EEB88
	private RewardedVideoCacheManager.Entry FindEntryByHash(string hash) { }

	// RVA: 0x63EEC78 Offset: 0x63EAC78 VA: 0x63EEC78
	private RewardedVideoCacheManager.Entry FindOrCreateEntry(string hash) { }

	// RVA: 0x63EE570 Offset: 0x63EA570 VA: 0x63EE570
	private bool IsInFailCooldown(string hash) { }

	// RVA: 0x63EEE58 Offset: 0x63EAE58 VA: 0x63EEE58
	private void MarkFail(string hash, string error) { }

	// RVA: 0x63EEF14 Offset: 0x63EAF14 VA: 0x63EEF14
	private void CleanupKeepOnlyAndTmp(string keepHash) { }

	// RVA: 0x63EF418 Offset: 0x63EB418 VA: 0x63EF418
	private void ClearFailRecord(string hash) { }

	// RVA: 0x63EF2CC Offset: 0x63EB2CC VA: 0x63EF2CC
	private static void CleanupTmpFiles() { }

	// RVA: 0x63EF218 Offset: 0x63EB218 VA: 0x63EF218
	private static void SafeDelete(string path) { }

	// RVA: 0x63EEDEC Offset: 0x63EADEC VA: 0x63EEDEC
	private static long NowUtcSeconds() { }

	// RVA: 0x63EE28C Offset: 0x63EA28C VA: 0x63EE28C
	private static string Sha1Hex(string s) { }

	// RVA: 0x63EE9C8 Offset: 0x63EA9C8 VA: 0x63EE9C8
	private static void LogException(string context, Exception e) { }

	// RVA: 0x63EF440 Offset: 0x63EB440 VA: 0x63EF440
	public void .ctor() { }
}

// Namespace: 
private sealed class GorillaAdManager.LoadedAdEntry // TypeDefIndex: 25845
{
	// Fields
	[CompilerGenerated]
	private readonly AdUnitConfig <Config>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly AdProvider <Provider>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string <AdUnitId>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly string <Key>k__BackingField; // 0x28

	// Properties
	public AdUnitConfig Config { get; }
	public AdProvider Provider { get; }
	public string AdUnitId { get; }
	public string Key { get; }
	public AdFormat Format { get; }

	// Methods

	// RVA: 0x63FA088 Offset: 0x63F6088 VA: 0x63FA088
	public void .ctor(AdUnitConfig config, AdProvider provider, string adUnitId) { }

	[CompilerGenerated]
	// RVA: 0x63FA5D4 Offset: 0x63F65D4 VA: 0x63FA5D4
	public AdUnitConfig get_Config() { }

	[CompilerGenerated]
	// RVA: 0x63FA5DC Offset: 0x63F65DC VA: 0x63FA5DC
	public AdProvider get_Provider() { }

	[CompilerGenerated]
	// RVA: 0x63FA5E4 Offset: 0x63F65E4 VA: 0x63FA5E4
	public string get_AdUnitId() { }

	[CompilerGenerated]
	// RVA: 0x63FA5EC Offset: 0x63F65EC VA: 0x63FA5EC
	public string get_Key() { }

	// RVA: 0x63F5B24 Offset: 0x63F1B24 VA: 0x63F5B24
	public AdFormat get_Format() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class GorillaAdManager.<>c // TypeDefIndex: 25846
{
	// Fields
	public static readonly GorillaAdManager.<>c <>9; // 0x0
	public static Action<AdUnitConfig> <>9__24_0; // 0x8
	public static Action <>9__29_0; // 0x10
	public static Func<AdUnitConfig, bool> <>9__39_0; // 0x18
	public static Func<AdUnitConfig, int> <>9__39_1; // 0x20
	public static Func<AdUnitConfig, int> <>9__41_1; // 0x28
	public static Func<AdUnitConfig, int> <>9__41_3; // 0x30
	public static Func<RewardedVideoCandidate, bool> <>9__81_0; // 0x38
	public static Func<RewardedVideoCandidate, bool> <>9__87_0; // 0x40
	public static Func<<>f__AnonymousType0<AdUnitConfig, AdProvider>, int> <>9__88_2; // 0x48
	public static Func<<>f__AnonymousType0<AdUnitConfig, AdProvider>, int> <>9__88_3; // 0x50
	public static Func<<>f__AnonymousType0<AdUnitConfig, AdProvider>, RewardedVideoCandidate> <>9__88_4; // 0x58
	public static Func<AdUnitConfig, bool> <>9__91_0; // 0x60
	public static Func<AdUnitConfig, bool> <>9__93_0; // 0x68
	public static Func<RewardedVideoCandidate, AdUnitConfig> <>9__94_0; // 0x70
	public static Func<GorillaAdManager.LoadedAdEntry, int> <>9__105_1; // 0x78
	public static Func<GorillaAdManager.LoadedAdEntry, int> <>9__105_2; // 0x80
	public static Func<GorillaAdManager.LoadedAdEntry, bool> <>9__106_0; // 0x88
	public static Func<GorillaAdManager.LoadedAdEntry, int> <>9__106_2; // 0x90
	public static Func<GorillaAdManager.LoadedAdEntry, int> <>9__106_3; // 0x98
	public static Func<AdUnitConfig, int> <>9__110_1; // 0xA0

	// Methods

	// RVA: 0x63FA5F4 Offset: 0x63F65F4 VA: 0x63FA5F4
	private static void .cctor() { }

	// RVA: 0x63FA65C Offset: 0x63F665C VA: 0x63FA65C
	public void .ctor() { }

	// RVA: 0x63FA664 Offset: 0x63F6664 VA: 0x63FA664
	internal void <Initialize>b__24_0(AdUnitConfig e) { }

	// RVA: 0x63FA678 Offset: 0x63F6678 VA: 0x63FA678
	internal void <InitializeConsentFlow>b__29_0() { }

	// RVA: 0x63FA6E0 Offset: 0x63F66E0 VA: 0x63FA6E0
	internal bool <AutoLoadAds>b__39_0(AdUnitConfig config) { }

	// RVA: 0x63FA700 Offset: 0x63F6700 VA: 0x63FA700
	internal int <AutoLoadAds>b__39_1(AdUnitConfig c) { }

	// RVA: 0x63FA718 Offset: 0x63F6718 VA: 0x63FA718
	internal int <LoadAdsForProviderInternal>b__41_1(AdUnitConfig config) { }

	// RVA: 0x63FA730 Offset: 0x63F6730 VA: 0x63FA730
	internal int <LoadAdsForProviderInternal>b__41_3(AdUnitConfig config) { }

	// RVA: 0x63FA748 Offset: 0x63F6748 VA: 0x63FA748
	internal bool <LoadRewardedVideoCandidatesForShowAttempt>b__81_0(RewardedVideoCandidate candidate) { }

	// RVA: 0x63FA770 Offset: 0x63F6770 VA: 0x63FA770
	internal bool <HasRewardedVideoLoadingOrReady>b__87_0(RewardedVideoCandidate candidate) { }

	// RVA: 0x63FA8D8 Offset: 0x63F68D8 VA: 0x63FA8D8
	internal int <BuildRewardedVideoPlaybackCandidates>b__88_2(<>f__AnonymousType0<AdUnitConfig, AdProvider> item) { }

	// RVA: 0x63FA924 Offset: 0x63F6924 VA: 0x63FA924
	internal int <BuildRewardedVideoPlaybackCandidates>b__88_3(<>f__AnonymousType0<AdUnitConfig, AdProvider> item) { }

	// RVA: 0x63FA990 Offset: 0x63F6990 VA: 0x63FA990
	internal RewardedVideoCandidate <BuildRewardedVideoPlaybackCandidates>b__88_4(<>f__AnonymousType0<AdUnitConfig, AdProvider> item) { }

	// RVA: 0x63FAA38 Offset: 0x63F6A38 VA: 0x63FAA38
	internal bool <ShouldIncludeLocalVideoCandidate>b__91_0(AdUnitConfig rewardConfig) { }

	// RVA: 0x63FAA98 Offset: 0x63F6A98 VA: 0x63FAA98
	internal bool <GetRewardedVideoConfigs>b__93_0(AdUnitConfig e) { }

	// RVA: 0x63FAAB4 Offset: 0x63F6AB4 VA: 0x63FAAB4
	internal AdUnitConfig <FindBestRewardConfig>b__94_0(RewardedVideoCandidate candidate) { }

	// RVA: 0x63FAACC Offset: 0x63F6ACC VA: 0x63FAACC
	internal int <FindBestLoadedEntry>b__105_1(GorillaAdManager.LoadedAdEntry entry) { }

	// RVA: 0x63FAB2C Offset: 0x63F6B2C VA: 0x63FAB2C
	internal int <FindBestLoadedEntry>b__105_2(GorillaAdManager.LoadedAdEntry entry) { }

	// RVA: 0x63FAB4C Offset: 0x63F6B4C VA: 0x63FAB4C
	internal bool <FindBestBannerEntry>b__106_0(GorillaAdManager.LoadedAdEntry entry) { }

	// RVA: 0x63FAB74 Offset: 0x63F6B74 VA: 0x63FAB74
	internal int <FindBestBannerEntry>b__106_2(GorillaAdManager.LoadedAdEntry entry) { }

	// RVA: 0x63FABD4 Offset: 0x63F6BD4 VA: 0x63FABD4
	internal int <FindBestBannerEntry>b__106_3(GorillaAdManager.LoadedAdEntry entry) { }

	// RVA: 0x63FABF4 Offset: 0x63F6BF4 VA: 0x63FABF4
	internal int <FindBestConfigByFormat>b__110_1(AdUnitConfig config) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass101_0 // TypeDefIndex: 25847
{
	// Fields
	public AdProvider provider; // 0x10
	public string adUnitId; // 0x18

	// Methods

	// RVA: 0x63FA130 Offset: 0x63F6130 VA: 0x63FA130
	public void .ctor() { }

	// RVA: 0x63FAC0C Offset: 0x63F6C0C VA: 0x63FAC0C
	internal void <RemoveLoaded>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass103_0 // TypeDefIndex: 25848
{
	// Fields
	public AdUnitConfig config; // 0x10

	// Methods

	// RVA: 0x63FA290 Offset: 0x63F6290 VA: 0x63FA290
	public void .ctor() { }

	// RVA: 0x63FAC6C Offset: 0x63F6C6C VA: 0x63FAC6C
	internal bool <HasLoadedEntry>b__0(GorillaAdManager.LoadedAdEntry entry) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass105_0 // TypeDefIndex: 25849
{
	// Fields
	public Func<GorillaAdManager.LoadedAdEntry, bool> predicate; // 0x10

	// Methods

	// RVA: 0x63FACEC Offset: 0x63F6CEC VA: 0x63FACEC
	public void .ctor() { }

	// RVA: 0x63FACF4 Offset: 0x63F6CF4 VA: 0x63FACF4
	internal bool <FindBestLoadedEntry>b__0(GorillaAdManager.LoadedAdEntry entry) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass106_0 // TypeDefIndex: 25850
{
	// Fields
	public Func<GorillaAdManager.LoadedAdEntry, bool> predicate; // 0x10

	// Methods

	// RVA: 0x63FAD14 Offset: 0x63F6D14 VA: 0x63FAD14
	public void .ctor() { }

	// RVA: 0x63FAD1C Offset: 0x63F6D1C VA: 0x63FAD1C
	internal bool <FindBestBannerEntry>b__1(GorillaAdManager.LoadedAdEntry entry) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass110_0 // TypeDefIndex: 25851
{
	// Fields
	public AdFormat format; // 0x10

	// Methods

	// RVA: 0x63FAD3C Offset: 0x63F6D3C VA: 0x63FAD3C
	public void .ctor() { }

	// RVA: 0x63FAD44 Offset: 0x63F6D44 VA: 0x63FAD44
	internal bool <FindBestConfigByFormat>b__0(AdUnitConfig config) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass111_0 // TypeDefIndex: 25852
{
	// Fields
	public string adUnitId; // 0x10

	// Methods

	// RVA: 0x63FAD64 Offset: 0x63F6D64 VA: 0x63FAD64
	public void .ctor() { }

	// RVA: 0x63FAD6C Offset: 0x63F6D6C VA: 0x63FAD6C
	internal bool <FindConfigByAdUnitId>b__0(AdUnitConfig config) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass26_0 // TypeDefIndex: 25853
{
	// Fields
	public Action onSuccess; // 0x10

	// Methods

	// RVA: 0x63FAD8C Offset: 0x63F6D8C VA: 0x63FAD8C
	public void .ctor() { }

	// RVA: 0x63FAD94 Offset: 0x63F6D94 VA: 0x63FAD94
	internal void <WrapOnSuccess>b__0(AdUnitConfig _) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass31_0 // TypeDefIndex: 25854
{
	// Fields
	public bool isInitialAttempt; // 0x10
	public AdProvider provider; // 0x14
	public int initialProviderCount; // 0x18

	// Methods

	// RVA: 0x63FADB8 Offset: 0x63F6DB8 VA: 0x63FADB8
	public void .ctor() { }

	// RVA: 0x63FADC0 Offset: 0x63F6DC0 VA: 0x63FADC0
	internal void <InitializeAdProvider>b__0(bool success) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass31_1 // TypeDefIndex: 25855
{
	// Fields
	public bool success; // 0x10
	public GorillaAdManager.<>c__DisplayClass31_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x63FAEB8 Offset: 0x63F6EB8 VA: 0x63FAEB8
	public void .ctor() { }

	// RVA: 0x63FAEC0 Offset: 0x63F6EC0 VA: 0x63FAEC0
	internal void <InitializeAdProvider>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass32_0 // TypeDefIndex: 25856
{
	// Fields
	public AdProvider provider; // 0x10
	public int initialProviderCount; // 0x14

	// Methods

	// RVA: 0x63FB290 Offset: 0x63F7290 VA: 0x63FB290
	public void .ctor() { }

	// RVA: 0x63FB298 Offset: 0x63F7298 VA: 0x63FB298
	internal void <RetryAdProviderInitializationIfNeeded>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass39_0 // TypeDefIndex: 25857
{
	// Fields
	public AdUnitConfig config; // 0x10

	// Methods

	// RVA: 0x63FB2FC Offset: 0x63F72FC VA: 0x63FB2FC
	public void .ctor() { }

	// RVA: 0x63FB304 Offset: 0x63F7304 VA: 0x63FB304
	internal void <AutoLoadAds>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass40_0 // TypeDefIndex: 25858
{
	// Fields
	public AdProvider provider; // 0x10

	// Methods

	// RVA: 0x63FB360 Offset: 0x63F7360 VA: 0x63FB360
	public void .ctor() { }

	// RVA: 0x63FB368 Offset: 0x63F7368 VA: 0x63FB368
	internal void <LoadAdsForProvider>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass41_0 // TypeDefIndex: 25859
{
	// Fields
	public AdProvider provider; // 0x10
	public AdProvider primaryProvider; // 0x14

	// Methods

	// RVA: 0x63FB3C4 Offset: 0x63F73C4 VA: 0x63FB3C4
	public void .ctor() { }

	// RVA: 0x63FB3CC Offset: 0x63F73CC VA: 0x63FB3CC
	internal bool <LoadAdsForProviderInternal>b__0(AdUnitConfig config) { }

	// RVA: 0x63FB3F4 Offset: 0x63F73F4 VA: 0x63FB3F4
	internal bool <LoadAdsForProviderInternal>b__2(AdUnitConfig config) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass41_1 // TypeDefIndex: 25860
{
	// Fields
	public AdUnitConfig config; // 0x10

	// Methods

	// RVA: 0x63FB42C Offset: 0x63F742C VA: 0x63FB42C
	public void .ctor() { }

	// RVA: 0x63FB434 Offset: 0x63F7434 VA: 0x63FB434
	internal void <LoadAdsForProviderInternal>b__4() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass42_0 // TypeDefIndex: 25861
{
	// Fields
	public AdUnitConfig config; // 0x10

	// Methods

	// RVA: 0x63FB490 Offset: 0x63F7490 VA: 0x63FB490
	public void .ctor() { }

	// RVA: 0x63FB498 Offset: 0x63F7498 VA: 0x63FB498
	internal void <LoadAd>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass46_0 // TypeDefIndex: 25862
{
	// Fields
	public RewardedVideoCandidate candidate; // 0x10
	public IReadOnlyList<RewardedVideoCandidate> candidates; // 0x18
	public int index; // 0x20
	public Action <>9__2; // 0x28
	public Action <>9__3; // 0x30

	// Methods

	// RVA: 0x63FB4F4 Offset: 0x63F74F4 VA: 0x63FB4F4
	public void .ctor() { }

	// RVA: 0x63FB4FC Offset: 0x63F74FC VA: 0x63FB4FC
	internal void <LoadRewardedVideoCandidateSerial>b__0() { }

	// RVA: 0x63FB5BC Offset: 0x63F75BC VA: 0x63FB5BC
	internal void <LoadRewardedVideoCandidateSerial>b__2() { }

	// RVA: 0x63FB6D4 Offset: 0x63F76D4 VA: 0x63FB6D4
	internal void <LoadRewardedVideoCandidateSerial>b__1(int code, string message) { }

	// RVA: 0x63FB794 Offset: 0x63F7794 VA: 0x63FB794
	internal void <LoadRewardedVideoCandidateSerial>b__3() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass47_0 // TypeDefIndex: 25863
{
	// Fields
	public RewardedVideoCandidate candidate; // 0x10
	public Action <>9__2; // 0x18

	// Methods

	// RVA: 0x63FB81C Offset: 0x63F781C VA: 0x63FB81C
	public void .ctor() { }

	// RVA: 0x63FB824 Offset: 0x63F7824 VA: 0x63FB824
	internal void <LoadSingleRewardedVideoCandidate>b__0() { }

	// RVA: 0x63FB8E4 Offset: 0x63F78E4 VA: 0x63FB8E4
	internal void <LoadSingleRewardedVideoCandidate>b__2() { }

	// RVA: 0x63FB9E0 Offset: 0x63F79E0 VA: 0x63FB9E0
	internal void <LoadSingleRewardedVideoCandidate>b__1(int code, string message) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass47_1 // TypeDefIndex: 25864
{
	// Fields
	public int code; // 0x10
	public string message; // 0x18
	public GorillaAdManager.<>c__DisplayClass47_0 CS$<>8__locals1; // 0x20

	// Methods

	// RVA: 0x63FBAE8 Offset: 0x63F7AE8 VA: 0x63FBAE8
	public void .ctor() { }

	// RVA: 0x63FBAF0 Offset: 0x63F7AF0 VA: 0x63FBAF0
	internal void <LoadSingleRewardedVideoCandidate>b__3() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass48_0 // TypeDefIndex: 25865
{
	// Fields
	public AdUnitConfig config; // 0x10
	public AdProvider provider; // 0x18
	public string adUnitId; // 0x20

	// Methods

	// RVA: 0x63FBDB8 Offset: 0x63F7DB8 VA: 0x63FBDB8
	public void .ctor() { }

	// RVA: 0x63FBDC0 Offset: 0x63F7DC0 VA: 0x63FBDC0
	internal void <LoadInterstitial>b__0() { }

	// RVA: 0x63FBEB4 Offset: 0x63F7EB4 VA: 0x63FBEB4
	internal void <LoadInterstitial>b__1(int code, string message) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass49_0 // TypeDefIndex: 25866
{
	// Fields
	public AdUnitConfig config; // 0x10
	public AdProvider provider; // 0x18
	public string adUnitId; // 0x20

	// Methods

	// RVA: 0x63FC13C Offset: 0x63F813C VA: 0x63FC13C
	public void .ctor() { }

	// RVA: 0x63FC144 Offset: 0x63F8144 VA: 0x63FC144
	internal void <LoadBanner>b__0() { }

	// RVA: 0x63FC238 Offset: 0x63F8238 VA: 0x63FC238
	internal void <LoadBanner>b__1(int code, string message) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass50_0 // TypeDefIndex: 25867
{
	// Fields
	public AdUnitConfig config; // 0x10

	// Methods

	// RVA: 0x63FC4C0 Offset: 0x63F84C0 VA: 0x63FC4C0
	public void .ctor() { }

	// RVA: 0x63FC4C8 Offset: 0x63F84C8 VA: 0x63FC4C8
	internal void <TryLoadLocalVideoProvider>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass51_0 // TypeDefIndex: 25868
{
	// Fields
	public AdUnitConfig config; // 0x10
	public Action <>9__2; // 0x18

	// Methods

	// RVA: 0x63FC524 Offset: 0x63F8524 VA: 0x63FC524
	public void .ctor() { }

	// RVA: 0x63FC52C Offset: 0x63F852C VA: 0x63FC52C
	internal void <TryLoadLocalVideoProviderInternal>b__0() { }

	// RVA: 0x63FC5EC Offset: 0x63F85EC VA: 0x63FC5EC
	internal void <TryLoadLocalVideoProviderInternal>b__2() { }

	// RVA: 0x63FC668 Offset: 0x63F8668 VA: 0x63FC668
	internal void <TryLoadLocalVideoProviderInternal>b__1(int code, string message) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass51_1 // TypeDefIndex: 25869
{
	// Fields
	public int code; // 0x10
	public string message; // 0x18
	public GorillaAdManager.<>c__DisplayClass51_0 CS$<>8__locals1; // 0x20

	// Methods

	// RVA: 0x63FC770 Offset: 0x63F8770 VA: 0x63FC770
	public void .ctor() { }

	// RVA: 0x63FC778 Offset: 0x63F8778 VA: 0x63FC778
	internal void <TryLoadLocalVideoProviderInternal>b__3() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass55_0 // TypeDefIndex: 25870
{
	// Fields
	public AdUnitConfig config; // 0x10
	public bool immediately; // 0x18

	// Methods

	// RVA: 0x63FC8B8 Offset: 0x63F88B8 VA: 0x63FC8B8
	public void .ctor() { }

	// RVA: 0x63FC8C0 Offset: 0x63F88C0 VA: 0x63FC8C0
	internal void <ReloadAdIfNeed>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass56_0 // TypeDefIndex: 25871
{
	// Fields
	public AdUnitConfig config; // 0x10

	// Methods

	// RVA: 0x63FC928 Offset: 0x63F8928 VA: 0x63FC928
	public void .ctor() { }

	// RVA: 0x63FC930 Offset: 0x63F8930 VA: 0x63FC930
	internal void <ReloadAdIfNeedInternal>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass57_0 // TypeDefIndex: 25872
{
	// Fields
	public RewardedVideoCandidate candidate; // 0x10

	// Methods

	// RVA: 0x63FC98C Offset: 0x63F898C VA: 0x63FC98C
	public void .ctor() { }

	// RVA: 0x63FC994 Offset: 0x63F8994 VA: 0x63FC994
	internal void <ReloadSingleRewardAdIfNeed>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass65_0 // TypeDefIndex: 25873
{
	// Fields
	public string adUnitId; // 0x10

	// Methods

	// RVA: 0x63FCAB0 Offset: 0x63F8AB0 VA: 0x63FCAB0
	public void .ctor() { }

	// RVA: 0x63FCAB8 Offset: 0x63F8AB8 VA: 0x63FCAB8
	internal bool <Show>b__0(GorillaAdManager.LoadedAdEntry entry) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass67_0 // TypeDefIndex: 25874
{
	// Fields
	public AdFormat format; // 0x10

	// Methods

	// RVA: 0x63FCB14 Offset: 0x63F8B14 VA: 0x63FCB14
	public void .ctor() { }

	// RVA: 0x63FCB1C Offset: 0x63F8B1C VA: 0x63FCB1C
	internal bool <Show>b__0(GorillaAdManager.LoadedAdEntry entry) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass69_0 // TypeDefIndex: 25875
{
	// Fields
	public AdUnitConfig config; // 0x10

	// Methods

	// RVA: 0x63FCB48 Offset: 0x63F8B48 VA: 0x63FCB48
	public void .ctor() { }

	// RVA: 0x63FCB50 Offset: 0x63F8B50 VA: 0x63FCB50
	internal bool <Show>b__0(GorillaAdManager.LoadedAdEntry entry) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass77_0 // TypeDefIndex: 25876
{
	// Fields
	public Action callback; // 0x10

	// Methods

	// RVA: 0x63FCB74 Offset: 0x63F8B74 VA: 0x63FCB74
	public void .ctor() { }

	// RVA: 0x63FCB7C Offset: 0x63F8B7C VA: 0x63FCB7C
	internal void <WrapShowCallback>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass78_0<T> // TypeDefIndex: 25877
{
	// Fields
	public Action<T> callback; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545E15C Offset: 0x545A15C VA: 0x545E15C
	|-GorillaAdManager.<>c__DisplayClass78_0<bool>..ctor
	|
	|-RVA: 0x545E254 Offset: 0x545A254 VA: 0x545E254
	|-GorillaAdManager.<>c__DisplayClass78_0<object>..ctor
	|
	|-RVA: 0x545E3B0 Offset: 0x545A3B0 VA: 0x545E3B0
	|-GorillaAdManager.<>c__DisplayClass78_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <WrapShowCallback>b__0(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545E164 Offset: 0x545A164 VA: 0x545E164
	|-GorillaAdManager.<>c__DisplayClass78_0<bool>.<WrapShowCallback>b__0
	|
	|-RVA: 0x545E25C Offset: 0x545A25C VA: 0x545E25C
	|-GorillaAdManager.<>c__DisplayClass78_0<object>.<WrapShowCallback>b__0
	|
	|-RVA: 0x545E3B8 Offset: 0x545A3B8 VA: 0x545E3B8
	|-GorillaAdManager.<>c__DisplayClass78_0<__Il2CppFullySharedGenericType>.<WrapShowCallback>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass78_1<T> // TypeDefIndex: 25878
{
	// Fields
	public T value; // 0x0
	public GorillaAdManager.<>c__DisplayClass78_0<T> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545E560 Offset: 0x545A560 VA: 0x545E560
	|-GorillaAdManager.<>c__DisplayClass78_1<bool>..ctor
	|
	|-RVA: 0x545E598 Offset: 0x545A598 VA: 0x545E598
	|-GorillaAdManager.<>c__DisplayClass78_1<object>..ctor
	|
	|-RVA: 0x545E5D0 Offset: 0x545A5D0 VA: 0x545E5D0
	|-GorillaAdManager.<>c__DisplayClass78_1<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <WrapShowCallback>b__1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545E568 Offset: 0x545A568 VA: 0x545E568
	|-GorillaAdManager.<>c__DisplayClass78_1<bool>.<WrapShowCallback>b__1
	|
	|-RVA: 0x545E5A0 Offset: 0x545A5A0 VA: 0x545E5A0
	|-GorillaAdManager.<>c__DisplayClass78_1<object>.<WrapShowCallback>b__1
	|
	|-RVA: 0x545E5D8 Offset: 0x545A5D8 VA: 0x545E5D8
	|-GorillaAdManager.<>c__DisplayClass78_1<__Il2CppFullySharedGenericType>.<WrapShowCallback>b__1
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass79_0<T1, T2> // TypeDefIndex: 25879
{
	// Fields
	public Action<T1, T2> callback; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545E788 Offset: 0x545A788 VA: 0x545E788
	|-GorillaAdManager.<>c__DisplayClass79_0<int, object>..ctor
	|
	|-RVA: 0x545E890 Offset: 0x545A890 VA: 0x545E890
	|-GorillaAdManager.<>c__DisplayClass79_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <WrapShowCallback>b__0(T1 value1, T2 value2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545E790 Offset: 0x545A790 VA: 0x545E790
	|-GorillaAdManager.<>c__DisplayClass79_0<int, object>.<WrapShowCallback>b__0
	|
	|-RVA: 0x545E898 Offset: 0x545A898 VA: 0x545E898
	|-GorillaAdManager.<>c__DisplayClass79_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<WrapShowCallback>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass79_1<T1, T2> // TypeDefIndex: 25880
{
	// Fields
	public T1 value1; // 0x0
	public T2 value2; // 0x0
	public GorillaAdManager.<>c__DisplayClass79_0<T1, T2> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545EAA4 Offset: 0x545AAA4 VA: 0x545EAA4
	|-GorillaAdManager.<>c__DisplayClass79_1<int, object>..ctor
	|
	|-RVA: 0x545EAE0 Offset: 0x545AAE0 VA: 0x545EAE0
	|-GorillaAdManager.<>c__DisplayClass79_1<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <WrapShowCallback>b__1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545EAAC Offset: 0x545AAAC VA: 0x545EAAC
	|-GorillaAdManager.<>c__DisplayClass79_1<int, object>.<WrapShowCallback>b__1
	|
	|-RVA: 0x545EAE8 Offset: 0x545AAE8 VA: 0x545EAE8
	|-GorillaAdManager.<>c__DisplayClass79_1<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<WrapShowCallback>b__1
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass80_0 // TypeDefIndex: 25881
{
	// Fields
	public RewardedVideoCandidate candidate; // 0x10
	public Action<AdUnitConfig> onSuccess; // 0x18
	public Action<int, string> onFailure; // 0x20
	public Action<bool> onClose; // 0x28
	public bool isRewarded; // 0x30
	public Action onClick; // 0x38
	public Action <>9__5; // 0x40
	public Action <>9__7; // 0x48
	public Action <>9__8; // 0x50

	// Methods

	// RVA: 0x63FCBD8 Offset: 0x63F8BD8 VA: 0x63FCBD8
	public void .ctor() { }

	// RVA: 0x63FCBE0 Offset: 0x63F8BE0 VA: 0x63FCBE0
	internal void <ShowRewardedVideo>b__0() { }

	// RVA: 0x63FCCA0 Offset: 0x63F8CA0 VA: 0x63FCCA0
	internal void <ShowRewardedVideo>b__5() { }

	// RVA: 0x63FCD40 Offset: 0x63F8D40 VA: 0x63FCD40
	internal void <ShowRewardedVideo>b__1(int code, string message) { }

	// RVA: 0x63FCE50 Offset: 0x63F8E50 VA: 0x63FCE50
	internal void <ShowRewardedVideo>b__2() { }

	// RVA: 0x63FCF10 Offset: 0x63F8F10 VA: 0x63FCF10
	internal void <ShowRewardedVideo>b__7() { }

	// RVA: 0x63FCFC4 Offset: 0x63F8FC4 VA: 0x63FCFC4
	internal void <ShowRewardedVideo>b__3() { }

	// RVA: 0x63FD084 Offset: 0x63F9084 VA: 0x63FD084
	internal void <ShowRewardedVideo>b__8() { }

	// RVA: 0x63FD090 Offset: 0x63F9090 VA: 0x63FD090
	internal void <ShowRewardedVideo>b__4() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass80_1 // TypeDefIndex: 25882
{
	// Fields
	public int code; // 0x10
	public string message; // 0x18
	public GorillaAdManager.<>c__DisplayClass80_0 CS$<>8__locals1; // 0x20

	// Methods

	// RVA: 0x63FCE48 Offset: 0x63F8E48 VA: 0x63FCE48
	public void .ctor() { }

	// RVA: 0x63FD0AC Offset: 0x63F90AC VA: 0x63FD0AC
	internal void <ShowRewardedVideo>b__6() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass82_0 // TypeDefIndex: 25883
{
	// Fields
	public AdProvider provider; // 0x10
	public string adUnitId; // 0x18
	public Action<AdUnitConfig> onSuccess; // 0x20
	public AdUnitConfig config; // 0x28
	public Action<int, string> onFailure; // 0x30
	public Action<bool> onClose; // 0x38
	public Action onClick; // 0x40

	// Methods

	// RVA: 0x63FD3B8 Offset: 0x63F93B8 VA: 0x63FD3B8
	public void .ctor() { }

	// RVA: 0x63FD3C0 Offset: 0x63F93C0 VA: 0x63FD3C0
	internal void <ShowInterstitial>b__0() { }

	// RVA: 0x63FD44C Offset: 0x63F944C VA: 0x63FD44C
	internal void <ShowInterstitial>b__1(int code, string message) { }

	// RVA: 0x63FD50C Offset: 0x63F950C VA: 0x63FD50C
	internal void <ShowInterstitial>b__2() { }

	// RVA: 0x63FD5B8 Offset: 0x63F95B8 VA: 0x63FD5B8
	internal void <ShowInterstitial>b__3() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass83_0 // TypeDefIndex: 25884
{
	// Fields
	public Action<AdUnitConfig> onSuccess; // 0x10
	public AdUnitConfig config; // 0x18
	public Action<int, string> onFailure; // 0x20
	public Action<bool> onClose; // 0x28

	// Methods

	// RVA: 0x63FD5D4 Offset: 0x63F95D4 VA: 0x63FD5D4
	public void .ctor() { }

	// RVA: 0x63FD5DC Offset: 0x63F95DC VA: 0x63FD5DC
	internal void <ShowBannerInternal>b__0() { }

	// RVA: 0x63FD5FC Offset: 0x63F95FC VA: 0x63FD5FC
	internal void <ShowBannerInternal>b__1(int code, string message) { }

	// RVA: 0x63FD68C Offset: 0x63F968C VA: 0x63FD68C
	internal void <ShowBannerInternal>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass88_0 // TypeDefIndex: 25885
{
	// Fields
	public AdProvider primaryProvider; // 0x10
	public IReadOnlyList<AdProvider> readyProviders; // 0x18

	// Methods

	// RVA: 0x63FD6AC Offset: 0x63F96AC VA: 0x63FD6AC
	public void .ctor() { }

	// RVA: 0x63FD6B4 Offset: 0x63F96B4 VA: 0x63FD6B4
	internal <>f__AnonymousType0<AdUnitConfig, AdProvider> <BuildRewardedVideoPlaybackCandidates>b__0(AdUnitConfig config) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass88_1 // TypeDefIndex: 25886
{
	// Fields
	public List<AdProvider> configuredProviders; // 0x10
	public GorillaAdManager.<>c__DisplayClass88_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x63FD74C Offset: 0x63F974C VA: 0x63FD74C
	public void .ctor() { }

	// RVA: 0x63FD754 Offset: 0x63F9754 VA: 0x63FD754
	internal bool <BuildRewardedVideoPlaybackCandidates>b__1(<>f__AnonymousType0<AdUnitConfig, AdProvider> item) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass90_0 // TypeDefIndex: 25887
{
	// Fields
	public AdProvider provider; // 0x10
	public AdProvider primaryProvider; // 0x14

	// Methods

	// RVA: 0x63FD7FC Offset: 0x63F97FC VA: 0x63FD7FC
	public void .ctor() { }

	// RVA: 0x63FD804 Offset: 0x63F9804 VA: 0x63FD804
	internal bool <FindRewardConfigForProvider>b__0(AdUnitConfig config) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaAdManager.<>c__DisplayClass99_0 // TypeDefIndex: 25888
{
	// Fields
	public string adUnitId; // 0x10

	// Methods

	// RVA: 0x63FD828 Offset: 0x63F9828 VA: 0x63FD828
	public void .ctor() { }

	// RVA: 0x63FD830 Offset: 0x63F9830 VA: 0x63FD830
	internal bool <TryFindBannerEntry>b__0(GorillaAdManager.LoadedAdEntry e) { }
}

// Namespace: 
[CompilerGenerated]
private struct GorillaAdManager.<ScheduleDelay>d__59 : IAsyncStateMachine // TypeDefIndex: 25889
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public float seconds; // 0x28
	public Action action; // 0x30
	private TaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x63FD88C Offset: 0x63F988C VA: 0x63FD88C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x63FDA60 Offset: 0x63F9A60 VA: 0x63FDA60 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: GorillaAd.Runtime
public static class GorillaAdManager // TypeDefIndex: 25890
{
	// Fields
	private const string Tag = "[GorillaAdManager]";
	private const int DefaultPlayStartIntervalSeconds = 5;
	private const int MinimumPlayStartIntervalSeconds = 1;
	private static int _playStartIntervalSeconds; // 0x0
	private static bool _isInitialized; // 0x4
	private static bool _adLoadingStarted; // 0x5
	private static int _localVideoLoadAttemptsRemaining; // 0x8
	private const int LocalVideoMaxLoadAttemptsPerCycle = 2;
	private static AdConfig _adConfig; // 0x10
	private static int _unityMainThreadId; // 0x18
	private static AdRuntimeContext _runtimeContext; // 0x20
	private static IAdRetryPolicy _adSdkInitializeRetryPolicyTemplate; // 0x28
	private static readonly Dictionary<AdProvider, IAdRetryPolicy> ProviderInitializeRetryPolicies; // 0x30
	private static readonly HashSet<AdProvider> InitialProviderInitializationCompleted; // 0x38
	private static readonly HashSet<AdProvider> ReadyAdProviders; // 0x40
	private static readonly ConcurrentDictionary<string, GorillaAdManager.LoadedAdEntry> LoadedAdEntries; // 0x48
	[CompilerGenerated]
	private static AdController <Controller>k__BackingField; // 0x50

	// Properties
	public static AdController Controller { get; set; }
	internal static AdRuntimeContext RuntimeContext { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x63EFC28 Offset: 0x63EBC28 VA: 0x63EFC28
	public static AdController get_Controller() { }

	[CompilerGenerated]
	// RVA: 0x63EFC80 Offset: 0x63EBC80 VA: 0x63EFC80
	private static void set_Controller(AdController value) { }

	// RVA: 0x63EFCE0 Offset: 0x63EBCE0 VA: 0x63EFCE0
	internal static AdRuntimeContext get_RuntimeContext() { }

	// RVA: 0x63EFD88 Offset: 0x63EBD88 VA: 0x63EFD88
	public static void SetPlayStartInterval(int intervalSeconds) { }

	// RVA: 0x63EFE90 Offset: 0x63EBE90 VA: 0x63EFE90
	public static void Initialize(AdConfig adConfig, bool isShowConsent = True, Action<string, Dictionary<string, object>> onAdEvent, IAdRetryPolicy adSdkInitializeRetryPolicy) { }

	// RVA: 0x63EFF10 Offset: 0x63EBF10 VA: 0x63EFF10
	public static void Initialize(AdConfig adConfig, AdRuntimeContext runtimeContext, bool isShowConsent = True, Action<string, Dictionary<string, object>> onAdEvent, IAdRetryPolicy adSdkInitializeRetryPolicy) { }

	// RVA: 0x63F08E8 Offset: 0x63EC8E8 VA: 0x63F08E8
	public static void SetRuntimeContext(AdRuntimeContext runtimeContext) { }

	// RVA: 0x63F0970 Offset: 0x63EC970 VA: 0x63F0970
	private static Action<AdUnitConfig> WrapOnSuccess(Action onSuccess) { }

	// RVA: 0x63F0A38 Offset: 0x63ECA38 VA: 0x63F0A38
	private static bool IsOnUnityMainThread() { }

	// RVA: 0x63F0AE0 Offset: 0x63ECAE0 VA: 0x63F0AE0
	private static void RunInternalOnUnityMainThread(Action action) { }

	// RVA: 0x63F0514 Offset: 0x63EC514 VA: 0x63F0514
	private static void InitializeConsentFlow() { }

	// RVA: 0x63F0664 Offset: 0x63EC664 VA: 0x63F0664
	private static void InitializeAdSdk() { }

	// RVA: 0x63F1038 Offset: 0x63ED038 VA: 0x63F1038
	private static void InitializeAdProvider(AdProvider provider, bool isInitialAttempt, int initialProviderCount) { }

	// RVA: 0x63F1170 Offset: 0x63ED170 VA: 0x63F1170
	private static void RetryAdProviderInitializationIfNeeded(AdProvider provider, int initialProviderCount) { }

	// RVA: 0x63F0E84 Offset: 0x63ECE84 VA: 0x63F0E84
	private static IAdRetryPolicy CreateProviderInitializeRetryPolicy() { }

	// RVA: 0x63F03D8 Offset: 0x63EC3D8 VA: 0x63F03D8
	private static void ApplyFallbackVideoSettings() { }

	// RVA: 0x63F153C Offset: 0x63ED53C VA: 0x63F153C
	public static void SkipFallbackRewardedVideoPlaying(bool isSkip) { }

	// RVA: 0x63F0DE8 Offset: 0x63ECDE8 VA: 0x63F0DE8
	private static void StartAdLoadingIfNeeded() { }

	// RVA: 0x63F158C Offset: 0x63ED58C VA: 0x63F158C
	private static void StartAdLoadingIfNeededInternal() { }

	// RVA: 0x63F1614 Offset: 0x63ED614 VA: 0x63F1614
	private static void AutoLoadAds() { }

	// RVA: 0x63F22E4 Offset: 0x63EE2E4 VA: 0x63F22E4
	private static void LoadAdsForProvider(AdProvider provider) { }

	// RVA: 0x63F23B0 Offset: 0x63EE3B0 VA: 0x63F23B0
	private static void LoadAdsForProviderInternal(AdProvider provider) { }

	// RVA: 0x63F313C Offset: 0x63EF13C VA: 0x63F313C
	private static void LoadAd(AdUnitConfig config) { }

	// RVA: 0x63F321C Offset: 0x63EF21C VA: 0x63F321C
	private static void LoadAdInternal(AdUnitConfig config) { }

	// RVA: 0x63F3390 Offset: 0x63EF390 VA: 0x63F3390
	private static void LoadAllRewardedVideos() { }

	// RVA: 0x63F3C00 Offset: 0x63EFC00 VA: 0x63F3C00
	private static void LoadRewardedVideoParallel(IReadOnlyList<RewardedVideoCandidate> candidates) { }

	// RVA: 0x63F3D68 Offset: 0x63EFD68 VA: 0x63F3D68
	private static void LoadRewardedVideoCandidateSerial(IReadOnlyList<RewardedVideoCandidate> candidates, int index) { }

	// RVA: 0x63F2DCC Offset: 0x63EEDCC VA: 0x63F2DCC
	private static void LoadSingleRewardedVideoCandidate(RewardedVideoCandidate candidate) { }

	// RVA: 0x63F3474 Offset: 0x63EF474 VA: 0x63F3474
	private static void LoadInterstitial(AdUnitConfig config) { }

	// RVA: 0x63F37CC Offset: 0x63EF7CC VA: 0x63F37CC
	private static void LoadBanner(AdUnitConfig config) { }

	// RVA: 0x63F0D08 Offset: 0x63ECD08 VA: 0x63F0D08
	private static void TryLoadLocalVideoProvider(AdUnitConfig config) { }

	// RVA: 0x63F4578 Offset: 0x63F0578 VA: 0x63F4578
	private static void TryLoadLocalVideoProviderInternal(AdUnitConfig config) { }

	// RVA: 0x63F037C Offset: 0x63EC37C VA: 0x63F037C
	private static void ResetLocalVideoLoadCycle() { }

	// RVA: 0x63F4998 Offset: 0x63F0998 VA: 0x63F4998
	private static void ReloadLocalVideoAfterShow(AdUnitConfig contextConfig) { }

	// RVA: 0x63F4914 Offset: 0x63F0914 VA: 0x63F4914
	private static bool IsMiniGameProviderConfig(AdUnitConfig config) { }

	// RVA: 0x63F4484 Offset: 0x63F0484 VA: 0x63F4484
	private static void ReloadAdIfNeed(AdUnitConfig config, bool immediately = False) { }

	// RVA: 0x63F4B00 Offset: 0x63F0B00 VA: 0x63F4B00
	private static void ReloadAdIfNeedInternal(AdUnitConfig config, bool immediately) { }

	// RVA: 0x63F4DE0 Offset: 0x63F0DE0 VA: 0x63F4DE0
	private static void ReloadSingleRewardAdIfNeed(RewardedVideoCandidate candidate) { }

	// RVA: 0x63F51B0 Offset: 0x63F11B0 VA: 0x63F51B0
	private static void ReloadRewardedCandidateAfterShow(RewardedVideoCandidate candidate) { }

	[AsyncStateMachine(typeof(GorillaAdManager.<ScheduleDelay>d__59))]
	// RVA: 0x63F1478 Offset: 0x63ED478 VA: 0x63F1478
	private static void ScheduleDelay(float seconds, Action action) { }

	// RVA: 0x63F1CE4 Offset: 0x63EDCE4 VA: 0x63F1CE4
	private static void CheckLoadedAds() { }

	// RVA: 0x63F5268 Offset: 0x63F1268 VA: 0x63F5268
	private static void CheckLoadedAdIsReady() { }

	[Obsolete("请使用 Show(Action<AdUnitConfig> onSuccess, ...) 方法")]
	// RVA: 0x63F5B40 Offset: 0x63F1B40 VA: 0x63F5B40
	public static bool Show(Action onSuccess, Action<int, string> onFailure, Action<bool> onClose, Action onClick, Action onImpression, Action<AdPaidEventData> onAdPaid, Dictionary<string, object> customData) { }

	// RVA: 0x63F5BE0 Offset: 0x63F1BE0 VA: 0x63F5BE0
	public static bool Show(Action<AdUnitConfig> onSuccess, Action<int, string> onFailure, Action<bool> onClose, Action onClick, Action onImpression, Action<AdPaidEventData> onAdPaid, Dictionary<string, object> customData) { }

	[Obsolete("请使用 Show(Action<AdUnitConfig> onSuccess, ...) 方法")]
	// RVA: 0x63F62BC Offset: 0x63F22BC VA: 0x63F62BC
	public static bool Show(string adUnitId, Action onSuccess, Action<int, string> onFailure, Action<bool> onClose, Action onClick, Action onImpression, Action<AdPaidEventData> onAdPaid, Dictionary<string, object> customData) { }

	// RVA: 0x63F6370 Offset: 0x63F2370 VA: 0x63F6370
	public static bool Show(string adUnitId, Action<AdUnitConfig> onSuccess, Action<int, string> onFailure, Action<bool> onClose, Action onClick, Action onImpression, Action<AdPaidEventData> onAdPaid, Dictionary<string, object> customData) { }

	[Obsolete("请使用 Show(Action<AdUnitConfig> onSuccess, ...) 方法")]
	// RVA: 0x63F6C1C Offset: 0x63F2C1C VA: 0x63F6C1C
	public static bool Show(AdFormat format, Action onSuccess, Action<int, string> onFailure, Action<bool> onClose, Action onClick, Action onImpression, Action<AdPaidEventData> onAdPaid, Dictionary<string, object> customData) { }

	// RVA: 0x63F6CD0 Offset: 0x63F2CD0 VA: 0x63F6CD0
	public static bool Show(AdFormat format, Action<AdUnitConfig> onSuccess, Action<int, string> onFailure, Action<bool> onClose, Action onClick, Action onImpression, Action<AdPaidEventData> onAdPaid, Dictionary<string, object> customData) { }

	[Obsolete("请使用 Show(Action<AdUnitConfig> onSuccess, ...) 方法")]
	// RVA: 0x63F6F60 Offset: 0x63F2F60 VA: 0x63F6F60
	public static bool Show(AdUnitConfig config, Action onSuccess, Action<int, string> onFailure, Action<bool> onClose, Action onClick, Action onImpression, Action<AdPaidEventData> onAdPaid, Dictionary<string, object> customData) { }

	// RVA: 0x63F7014 Offset: 0x63F3014 VA: 0x63F7014
	public static bool Show(AdUnitConfig config, Action<AdUnitConfig> onSuccess, Action<int, string> onFailure, Action<bool> onClose, Action onClick, Action onImpression, Action<AdPaidEventData> onAdPaid, Dictionary<string, object> customData) { }

	// RVA: 0x63F725C Offset: 0x63F325C VA: 0x63F725C
	public static void HideBanner(string adUnitId) { }

	// RVA: 0x63F7528 Offset: 0x63F3528 VA: 0x63F7528
	public static void DestroyBanner(string adUnitId) { }

	// RVA: 0x63F747C Offset: 0x63F347C VA: 0x63F747C
	private static void HideBanner(GorillaAdManager.LoadedAdEntry entry) { }

	// RVA: 0x63F7610 Offset: 0x63F3610 VA: 0x63F7610
	private static void DestroyBanner(GorillaAdManager.LoadedAdEntry entry) { }

	// RVA: 0x63F6A80 Offset: 0x63F2A80 VA: 0x63F6A80
	private static void TrackAdPlayStartForShowAttempt(AdUnitConfig config, GorillaAdManager.LoadedAdEntry loadedEntry, string requestedAdUnitId, Nullable<AdFormat> format, Dictionary<string, object> customData) { }

	// RVA: 0x63F76C8 Offset: 0x63F36C8 VA: 0x63F76C8
	private static Dictionary<string, object> BuildAdWatchCustomData(Dictionary<string, object> customData, string originalAdUnitId) { }

	// RVA: 0x63F5F0C Offset: 0x63F1F0C VA: 0x63F5F0C
	private static bool ShowInternal(AdUnitConfig config, Nullable<AdFormat> requestedFormat, bool allowFallbackWhenUnknown, Action<AdUnitConfig> onSuccess, Action<int, string> onFailure, Action<bool> onClose, Action onClick, Action onImpression, Action<AdPaidEventData> onAdPaid, Dictionary<string, object> customData, bool useGlobalRewardedCandidates = False, string requestedAdUnitId) { }

	// RVA: 0x63F7898 Offset: 0x63F3898 VA: 0x63F7898
	private static Action WrapShowCallback(Action callback) { }

	// RVA: -1 Offset: -1
	private static Action<T> WrapShowCallback<T>(Action<T> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x463204C Offset: 0x462E04C VA: 0x463204C
	|-GorillaAdManager.WrapShowCallback<bool>
	|
	|-RVA: 0x4632104 Offset: 0x462E104 VA: 0x4632104
	|-GorillaAdManager.WrapShowCallback<object>
	|
	|-RVA: 0x46321BC Offset: 0x462E1BC VA: 0x46321BC
	|-GorillaAdManager.WrapShowCallback<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static Action<T1, T2> WrapShowCallback<T1, T2>(Action<T1, T2> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x463227C Offset: 0x462E27C VA: 0x463227C
	|-GorillaAdManager.WrapShowCallback<int, object>
	|
	|-RVA: 0x4632334 Offset: 0x462E334 VA: 0x4632334
	|-GorillaAdManager.WrapShowCallback<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x63F7960 Offset: 0x63F3960 VA: 0x63F7960
	private static bool ShowRewardedVideo(AdUnitConfig config, bool useGlobalCandidates, string requestedAdUnitId, Action<AdUnitConfig> onSuccess, Action<int, string> onFailure, Action<bool> onClose, Action onClick, Action onImpression, Action<AdPaidEventData> onAdPaid, Dictionary<string, object> customData) { }

	// RVA: 0x63F90C4 Offset: 0x63F50C4 VA: 0x63F90C4
	private static void LoadRewardedVideoCandidatesForShowAttempt(IReadOnlyCollection<RewardedVideoCandidate> playbackCandidates, AdUnitConfig requestedConfig, bool useGlobalCandidates) { }

	// RVA: 0x63F813C Offset: 0x63F413C VA: 0x63F813C
	private static bool ShowInterstitial(AdUnitConfig config, Action<AdUnitConfig> onSuccess, Action<int, string> onFailure, Action<bool> onClose, Action onClick, Action onImpression, Action<AdPaidEventData> onAdPaid, Dictionary<string, object> customData) { }

	// RVA: 0x63F8540 Offset: 0x63F4540 VA: 0x63F8540
	private static bool ShowBannerInternal(AdUnitConfig config, Action<AdUnitConfig> onSuccess, Action<int, string> onFailure, Action<bool> onClose, Action onClick, Action onImpression, Action<AdPaidEventData> onAdPaid, Dictionary<string, object> customData) { }

	// RVA: 0x63F597C Offset: 0x63F197C VA: 0x63F597C
	private static bool IsReady(GorillaAdManager.LoadedAdEntry entry) { }

	// RVA: 0x63F57D4 Offset: 0x63F17D4 VA: 0x63F57D4
	private static bool IsDisplaying(GorillaAdManager.LoadedAdEntry entry) { }

	// RVA: 0x63F950C Offset: 0x63F550C VA: 0x63F950C
	private static bool IsRewardedVideoCandidateReady(RewardedVideoCandidate candidate) { }

	// RVA: 0x63F2064 Offset: 0x63EE064 VA: 0x63F2064
	private static bool HasRewardedVideoLoadingOrReady() { }

	// RVA: 0x63F89F4 Offset: 0x63F49F4 VA: 0x63F89F4
	private static List<RewardedVideoCandidate> BuildRewardedVideoPlaybackCandidates(AdUnitConfig requestedConfig, bool useGlobalCandidates) { }

	// RVA: 0x63F964C Offset: 0x63F564C VA: 0x63F964C
	private static void AddPlaybackCandidateIfProviderReady(ICollection<RewardedVideoCandidate> result, AdUnitConfig config, AdProvider provider, IReadOnlyCollection<AdProvider> readyProviders) { }

	// RVA: 0x63F978C Offset: 0x63F578C VA: 0x63F978C
	private static AdUnitConfig FindRewardConfigForProvider(AdProvider provider) { }

	// RVA: 0x63F9894 Offset: 0x63F5894 VA: 0x63F9894
	private static bool ShouldIncludeLocalVideoCandidate(AdUnitConfig config) { }

	// RVA: 0x63F3B50 Offset: 0x63EFB50 VA: 0x63F3B50
	private static List<RewardedVideoCandidate> BuildSdkRewardedVideoCandidates() { }

	// RVA: 0x63F1E48 Offset: 0x63EDE48 VA: 0x63F1E48
	private static IEnumerable<AdUnitConfig> GetRewardedVideoConfigs(AdUnitConfig config) { }

	// RVA: 0x63F0B8C Offset: 0x63ECB8C VA: 0x63F0B8C
	private static AdUnitConfig FindBestRewardConfig() { }

	// RVA: 0x63F4414 Offset: 0x63F0414 VA: 0x63F4414
	private static IReadOnlyList<AdProvider> GetReadyAdProviders() { }

	// RVA: 0x63F2D3C Offset: 0x63EED3C VA: 0x63F2D3C
	private static AdProvider ResolveConfiguredPrimarySdkProvider() { }

	// RVA: 0x63F95BC Offset: 0x63F55BC VA: 0x63F95BC
	private static Nullable<AdProvider> ResolveConfiguredFallbackSdkProvider() { }

	// RVA: 0x63F77C4 Offset: 0x63F37C4 VA: 0x63F77C4
	private static Nullable<AdProvider> ResolveEventProvider(AdUnitConfig config) { }

	// RVA: 0x63F7344 Offset: 0x63F3344 VA: 0x63F7344
	private static bool TryFindBannerEntry(string adUnitId, out GorillaAdManager.LoadedAdEntry entry) { }

	// RVA: 0x63F4344 Offset: 0x63F0344 VA: 0x63F4344
	private static void MarkLoaded(AdUnitConfig config, AdProvider provider, string adUnitId) { }

	// RVA: 0x63F4A10 Offset: 0x63F0A10 VA: 0x63F4A10
	private static void RemoveLoaded(AdProvider provider, string adUnitId) { }

	// RVA: 0x63FA138 Offset: 0x63F6138 VA: 0x63FA138
	private static void RemoveLoadedInternal(AdProvider provider, string adUnitId) { }

	// RVA: 0x63F2194 Offset: 0x63EE194 VA: 0x63F2194
	private static bool HasLoadedEntry(AdUnitConfig config) { }

	// RVA: 0x63FA298 Offset: 0x63F6298 VA: 0x63FA298
	private static AdUnitConfig FindBestLoadedConfig(Func<GorillaAdManager.LoadedAdEntry, bool> predicate) { }

	// RVA: 0x63F65E0 Offset: 0x63F25E0 VA: 0x63F65E0
	private static GorillaAdManager.LoadedAdEntry FindBestLoadedEntry(Func<GorillaAdManager.LoadedAdEntry, bool> predicate) { }

	// RVA: 0x63F9C70 Offset: 0x63F5C70 VA: 0x63F9C70
	private static GorillaAdManager.LoadedAdEntry FindBestBannerEntry(Func<GorillaAdManager.LoadedAdEntry, bool> predicate) { }

	// RVA: 0x63F9FEC Offset: 0x63F5FEC VA: 0x63F9FEC
	private static GorillaAdManager.LoadedAdEntry FindBestDisplayingBannerEntry() { }

	// RVA: 0x63FA2F8 Offset: 0x63F62F8 VA: 0x63FA2F8
	private static int GetProviderQueueIndex(AdProvider provider) { }

	// RVA: 0x63FA36C Offset: 0x63F636C VA: 0x63FA36C
	private static int GetConfiguredProviderQueueIndex(AdProvider provider) { }

	// RVA: 0x63F5D18 Offset: 0x63F1D18 VA: 0x63F5D18
	private static AdUnitConfig FindBestConfigByFormat(AdFormat format) { }

	// RVA: 0x63F6904 Offset: 0x63F2904 VA: 0x63F6904
	private static AdUnitConfig FindConfigByAdUnitId(string adUnitId) { }

	// RVA: 0x63F9A20 Offset: 0x63F5A20 VA: 0x63F9A20
	private static IEnumerable<AdUnitConfig> GetAllConfigs() { }

	// RVA: 0x63FA424 Offset: 0x63F6424 VA: 0x63FA424
	private static void .cctor() { }
}

// Namespace: GorillaAd.Runtime
public interface IAd // TypeDefIndex: 25891
{
	// Properties
	public abstract string AdUnitId { get; }
	public abstract string NetworkName { get; }
	public abstract bool IsLoading { get; }
	public abstract bool IsDisplaying { get; }
	public abstract object ResponseInfo { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_AdUnitId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_NetworkName();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsLoading();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_IsDisplaying();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object get_ResponseInfo();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Load();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Show();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool IsReady();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract AdLoadError GetLoadError(int code);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 9
	public abstract void add_OnLoadStart(Action<IAd> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 10
	public abstract void remove_OnLoadStart(Action<IAd> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 11
	public abstract void add_OnLoadSuccess(Action<IAd> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 12
	public abstract void remove_OnLoadSuccess(Action<IAd> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 13
	public abstract void add_OnLoadFailure(Action<IAd, int, string> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 14
	public abstract void remove_OnLoadFailure(Action<IAd, int, string> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 15
	public abstract void add_OnShowStart(Action<IAd> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 16
	public abstract void remove_OnShowStart(Action<IAd> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 17
	public abstract void add_OnShowSuccess(Action<IAd> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 18
	public abstract void remove_OnShowSuccess(Action<IAd> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 19
	public abstract void add_OnShowFailure(Action<IAd, int, string> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 20
	public abstract void remove_OnShowFailure(Action<IAd, int, string> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 21
	public abstract void add_OnImpression(Action<IAd> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 22
	public abstract void remove_OnImpression(Action<IAd> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 23
	public abstract void add_OnClicked(Action<IAd> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 24
	public abstract void remove_OnClicked(Action<IAd> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 25
	public abstract void add_OnClosed(Action<IAd> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 26
	public abstract void remove_OnClosed(Action<IAd> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 27
	public abstract void add_OnAdPaid(Action<IAd, AdPaidEventData> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 28
	public abstract void remove_OnAdPaid(Action<IAd, AdPaidEventData> value);
}

// Namespace: GorillaAd.Runtime
public interface IAdPaidDataProvider // TypeDefIndex: 25892
{
	// Properties
	public abstract AdPaidEventData CurrentPaidData { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract AdPaidEventData get_CurrentPaidData();
}

// Namespace: GorillaAd.Runtime
public interface IInterstitialAd : IAd // TypeDefIndex: 25893
{}

// Namespace: GorillaAd.Runtime
public interface IBannerAd : IAd // TypeDefIndex: 25894
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Hide();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Destroy();
}

// Namespace: GorillaAd.Runtime
public interface IRewardAd : IAd // TypeDefIndex: 25895
{
	// Properties
	public abstract string RewardType { get; }
	public abstract double RewardAmount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_RewardType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract double get_RewardAmount();

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_OnRewarded(Action<IRewardAd> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void remove_OnRewarded(Action<IRewardAd> value);
}

// Namespace: GorillaAd.Runtime
internal interface IAdProvider // TypeDefIndex: 25896
{
	// Properties
	public abstract AdProvider Provider { get; }
	public abstract bool IsSdkProvider { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract AdProvider get_Provider();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsSdkProvider();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IAdSdkInitializer CreateInitializer(AdSetting setting);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IConsentFlow CreateConsentFlow(AdSetting setting);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IRewardAd CreateRewardAd(string adUnitId);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IInterstitialAd CreateInterstitialAd(string adUnitId);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IBannerAd CreateBannerAd(string adUnitId, BannerPosition position);
}

// Namespace: GorillaAd.Runtime
internal sealed class LocalVideoProvider : IAdProvider // TypeDefIndex: 25897
{
	// Properties
	public AdProvider Provider { get; }
	public bool IsSdkProvider { get; }

	// Methods

	// RVA: 0x63FDA6C Offset: 0x63F9A6C VA: 0x63FDA6C Slot: 4
	public AdProvider get_Provider() { }

	// RVA: 0x63FDA74 Offset: 0x63F9A74 VA: 0x63FDA74 Slot: 5
	public bool get_IsSdkProvider() { }

	// RVA: 0x63FDA7C Offset: 0x63F9A7C VA: 0x63FDA7C Slot: 6
	public IAdSdkInitializer CreateInitializer(AdSetting setting) { }

	// RVA: 0x63FDA84 Offset: 0x63F9A84 VA: 0x63FDA84 Slot: 7
	public IConsentFlow CreateConsentFlow(AdSetting setting) { }

	// RVA: 0x63FDA8C Offset: 0x63F9A8C VA: 0x63FDA8C Slot: 8
	public IRewardAd CreateRewardAd(string adUnitId) { }

	// RVA: 0x63FDAE0 Offset: 0x63F9AE0 VA: 0x63FDAE0 Slot: 9
	public IInterstitialAd CreateInterstitialAd(string adUnitId) { }

	// RVA: 0x63FDAE8 Offset: 0x63F9AE8 VA: 0x63FDAE8 Slot: 10
	public IBannerAd CreateBannerAd(string adUnitId, BannerPosition position) { }

	// RVA: 0x63FDAF0 Offset: 0x63F9AF0 VA: 0x63FDAF0
	public void .ctor() { }
}

// Namespace: GorillaAd.Runtime
public interface IAdRetryPolicy // TypeDefIndex: 25898
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Reset();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract float GetNextDelay();
}

// Namespace: GorillaAd.Runtime
public class FixedDelayRetryPolicy : IAdRetryPolicy // TypeDefIndex: 25899
{
	// Fields
	private readonly float _delaySeconds; // 0x10

	// Properties
	internal float DelaySeconds { get; }

	// Methods

	// RVA: 0x63FDAF8 Offset: 0x63F9AF8 VA: 0x63FDAF8
	internal float get_DelaySeconds() { }

	// RVA: 0x63FDB00 Offset: 0x63F9B00 VA: 0x63FDB00
	public void .ctor(float delaySeconds = 5) { }

	// RVA: 0x63FDB28 Offset: 0x63F9B28 VA: 0x63FDB28 Slot: 4
	public void Reset() { }

	// RVA: 0x63FDB2C Offset: 0x63F9B2C VA: 0x63FDB2C Slot: 5
	public float GetNextDelay() { }
}

// Namespace: GorillaAd.Runtime
public class ExponentialBackoffRetryPolicy : IAdRetryPolicy // TypeDefIndex: 25900
{
	// Fields
	private readonly float _initialDelaySeconds; // 0x10
	private readonly float _maxDelaySeconds; // 0x14
	private int _attemptCount; // 0x18

	// Properties
	internal float InitialDelaySeconds { get; }
	internal float MaxDelaySeconds { get; }

	// Methods

	// RVA: 0x63FDB34 Offset: 0x63F9B34 VA: 0x63FDB34
	internal float get_InitialDelaySeconds() { }

	// RVA: 0x63FDB3C Offset: 0x63F9B3C VA: 0x63FDB3C
	internal float get_MaxDelaySeconds() { }

	// RVA: 0x63FDB44 Offset: 0x63F9B44 VA: 0x63FDB44
	public void .ctor(float initialDelaySeconds = 2, float maxDelaySeconds = 300) { }

	// RVA: 0x63FDB74 Offset: 0x63F9B74 VA: 0x63FDB74 Slot: 4
	public void Reset() { }

	// RVA: 0x63FDB7C Offset: 0x63F9B7C VA: 0x63FDB7C Slot: 5
	public float GetNextDelay() { }
}

// Namespace: GorillaAd.Runtime
public class MaxRetryPolicy : IAdRetryPolicy // TypeDefIndex: 25901
{
	// Fields
	private readonly int _maxAttemptCount; // 0x10
	private readonly float _delaySeconds; // 0x14
	private int _attemptCount; // 0x18

	// Properties
	internal int MaxAttemptCount { get; }
	internal float DelaySeconds { get; }

	// Methods

	// RVA: 0x63FDC14 Offset: 0x63F9C14 VA: 0x63FDC14
	internal int get_MaxAttemptCount() { }

	// RVA: 0x63FDC1C Offset: 0x63F9C1C VA: 0x63FDC1C
	internal float get_DelaySeconds() { }

	// RVA: 0x63FDC24 Offset: 0x63F9C24 VA: 0x63FDC24
	public void .ctor(int maxAttemptCount = 2, float delaySeconds = 5) { }

	// RVA: 0x63FDC60 Offset: 0x63F9C60 VA: 0x63FDC60 Slot: 4
	public void Reset() { }

	// RVA: 0x63FDC68 Offset: 0x63F9C68 VA: 0x63FDC68 Slot: 5
	public float GetNextDelay() { }
}

// Namespace: GorillaAd.Runtime
[Preserve]
public interface IAdRuntimeContextExtension // TypeDefIndex: 25902
{}

// Namespace: GorillaAd.Runtime
[Preserve]
public sealed class CsjAdRuntimeContext : IAdRuntimeContextExtension // TypeDefIndex: 25903
{
	// Fields
	[Preserve]
	public string RewardUserId; // 0x10
	[Preserve]
	public string MediaExtra; // 0x18
	[Preserve]
	public string RewardName; // 0x20
	[Preserve]
	public int RewardAmount; // 0x28

	// Methods

	// RVA: 0x63FDC8C Offset: 0x63F9C8C VA: 0x63FDC8C
	public void .ctor() { }
}

// Namespace: GorillaAd.Runtime
[Extension]
[Preserve]
public static class CsjAdRuntimeContextExtensions // TypeDefIndex: 25904
{
	// Methods

	[Extension]
	// RVA: 0x63FDC94 Offset: 0x63F9C94 VA: 0x63FDC94
	public static AdRuntimeContext SetCsjContext(AdRuntimeContext context, CsjAdRuntimeContext csjContext) { }
}

// Namespace: GorillaAd.Runtime
public interface IAdSdkInitializer // TypeDefIndex: 25905
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Init(Action<bool> onCompletion);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OpenInspector(Action<int, string> onFailure);
}

// Namespace: GorillaAd.Runtime
public interface IConsentFlow // TypeDefIndex: 25906
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ShowConsentForm(bool isShowConsent = True, Action onGranted);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ShowPrivacyOptionsForm(Action<int, string> onFailure);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void ResetConsent();
}

// Namespace: GorillaAd.Runtime
internal sealed class RewardedVideoCandidate // TypeDefIndex: 25907
{
	// Fields
	[CompilerGenerated]
	private readonly AdUnitConfig <Config>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly AdProvider <Provider>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string <AdUnitId>k__BackingField; // 0x20

	// Properties
	public AdUnitConfig Config { get; }
	public AdProvider Provider { get; }
	public string AdUnitId { get; }
	public bool IsLocalVideo { get; }

	// Methods

	// RVA: 0x63FDD20 Offset: 0x63F9D20 VA: 0x63FDD20
	public void .ctor(AdUnitConfig config, AdProvider provider, string adUnitId) { }

	[CompilerGenerated]
	// RVA: 0x63FDD74 Offset: 0x63F9D74 VA: 0x63FDD74
	public AdUnitConfig get_Config() { }

	[CompilerGenerated]
	// RVA: 0x63FDD7C Offset: 0x63F9D7C VA: 0x63FDD7C
	public AdProvider get_Provider() { }

	[CompilerGenerated]
	// RVA: 0x63FDD84 Offset: 0x63F9D84 VA: 0x63FDD84
	public string get_AdUnitId() { }

	// RVA: 0x63FDD8C Offset: 0x63F9D8C VA: 0x63FDD8C
	public bool get_IsLocalVideo() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class RewardedVideoProviderResolver.<>c // TypeDefIndex: 25908
{
	// Fields
	public static readonly RewardedVideoProviderResolver.<>c <>9; // 0x0
	public static Func<AdUnitConfig, int> <>9__10_1; // 0x8
	public static Func<AdUnitConfig, bool> <>9__11_0; // 0x10

	// Methods

	// RVA: 0x63FF438 Offset: 0x63FB438 VA: 0x63FF438
	private static void .cctor() { }

	// RVA: 0x63FF4A0 Offset: 0x63FB4A0 VA: 0x63FF4A0
	public void .ctor() { }

	// RVA: 0x63FF4A8 Offset: 0x63FB4A8 VA: 0x63FF4A8
	internal int <AddSdkCandidates>b__10_1(AdUnitConfig config) { }

	// RVA: 0x63FF4C0 Offset: 0x63FB4C0 VA: 0x63FF4C0
	internal bool <NormalizeConfigs>b__11_0(AdUnitConfig config) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RewardedVideoProviderResolver.<>c__DisplayClass10_0 // TypeDefIndex: 25909
{
	// Fields
	public AdProvider provider; // 0x10
	public AdProvider primaryProvider; // 0x14
	public Func<AdUnitConfig, bool> <>9__0; // 0x18

	// Methods

	// RVA: 0x63FF2D8 Offset: 0x63FB2D8 VA: 0x63FF2D8
	public void .ctor() { }

	// RVA: 0x63FF4F4 Offset: 0x63FB4F4 VA: 0x63FF4F4
	internal bool <AddSdkCandidates>b__0(AdUnitConfig config) { }
}

// Namespace: GorillaAd.Runtime
internal static class RewardedVideoProviderResolver // TypeDefIndex: 25910
{
	// Fields
	private const string Tag = "[RewardedVideoProviderResolver]";
	private static bool _legacyVungleWarningLogged; // 0x0
	private static readonly AdProvider[] DefaultSdkProviderOrder; // 0x8

	// Methods

	// RVA: 0x63FDD9C Offset: 0x63F9D9C VA: 0x63FDD9C
	public static AdProvider ResolvePrimaryProvider(AdSetting setting, IEnumerable<AdProvider> availableSdkProviders) { }

	// RVA: 0x63FDDF0 Offset: 0x63F9DF0 VA: 0x63FDDF0
	public static AdProvider ResolveConfiguredPrimaryProvider(AdSetting setting) { }

	// RVA: 0x63FE148 Offset: 0x63FA148 VA: 0x63FE148
	public static Nullable<AdProvider> ResolveConfiguredFallbackProvider(AdSetting setting) { }

	// RVA: 0x63FDE94 Offset: 0x63F9E94 VA: 0x63FDE94
	public static List<AdProvider> ResolveConfiguredProviderQueue(AdSetting setting) { }

	// RVA: 0x63FE22C Offset: 0x63FA22C VA: 0x63FE22C
	public static List<AdProvider> ResolveProviderQueue(AdSetting setting, IEnumerable<AdProvider> availableSdkProviders) { }

	// RVA: 0x63FE84C Offset: 0x63FA84C VA: 0x63FE84C
	public static List<RewardedVideoCandidate> BuildCandidates(IEnumerable<AdUnitConfig> configs, AdSetting setting, IEnumerable<AdProvider> availableSdkProviders, bool includeLocalVideo) { }

	// RVA: 0x63FF268 Offset: 0x63FB268 VA: 0x63FF268
	public static List<RewardedVideoCandidate> BuildSdkCandidates(IEnumerable<AdUnitConfig> configs, AdSetting setting, IEnumerable<AdProvider> availableSdkProviders) { }

	// RVA: 0x63FECDC Offset: 0x63FACDC VA: 0x63FECDC
	private static void AddSdkCandidates(List<RewardedVideoCandidate> result, IEnumerable<AdUnitConfig> configs, AdProvider provider, AdProvider primaryProvider) { }

	// RVA: 0x63FEB68 Offset: 0x63FAB68 VA: 0x63FEB68
	private static List<AdUnitConfig> NormalizeConfigs(IEnumerable<AdUnitConfig> configs) { }

	// RVA: 0x63FE31C Offset: 0x63FA31C VA: 0x63FE31C
	private static List<AdProvider> NormalizeSdkProviders(IEnumerable<AdProvider> providers) { }

	// RVA: 0x63FE440 Offset: 0x63FA440 VA: 0x63FE440
	private static void AddProviders(List<AdProvider> result, IEnumerable<AdProvider> providers, IReadOnlyCollection<AdProvider> availableProviders) { }

	// RVA: 0x63FE220 Offset: 0x63FA220 VA: 0x63FE220
	private static bool IsValidSdkProvider(AdProvider provider) { }

	// RVA: 0x63FF2E0 Offset: 0x63FB2E0 VA: 0x63FF2E0
	private static void LogUnavailableProvider(AdProvider provider) { }

	// RVA: 0x63FF3B0 Offset: 0x63FB3B0 VA: 0x63FF3B0
	private static void .cctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1957 // TypeDefIndex: 25911
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2288 // TypeDefIndex: 25912
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 25913
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1957 1A931DF7512031DA87A668300CD5444DCC304815B96678E203A8A14C975B0FF4 /*Metadata offset 0xF42C70*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2288 5675FB86F9064DED9A729D2F3816F2E91BF105FE3CD39FD815A4AB3FD4CE0E99 /*Metadata offset 0xF43418*/; // 0x7A5
}

