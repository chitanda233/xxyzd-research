// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28259
{}

// Namespace: GorillaAd.Runtime
internal abstract class CsjAdBase : IAd, IAdPaidDataProvider // TypeDefIndex: 28260
{
	// Fields
	private bool _showSuccessRaised; // 0x10
	[CompilerGenerated]
	private readonly string <AdUnitId>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string <NetworkName>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsLoading>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsDisplaying>k__BackingField; // 0x29
	[CompilerGenerated]
	private object <ResponseInfo>k__BackingField; // 0x30
	[CompilerGenerated]
	private AdPaidEventData <CurrentPaidData>k__BackingField; // 0x38
	[CompilerGenerated]
	private Action<IAd> OnLoadStart; // 0x40
	[CompilerGenerated]
	private Action<IAd> OnLoadSuccess; // 0x48
	[CompilerGenerated]
	private Action<IAd, int, string> OnLoadFailure; // 0x50
	[CompilerGenerated]
	private Action<IAd> OnShowStart; // 0x58
	[CompilerGenerated]
	private Action<IAd> OnShowSuccess; // 0x60
	[CompilerGenerated]
	private Action<IAd, int, string> OnShowFailure; // 0x68
	[CompilerGenerated]
	private Action<IAd> OnImpression; // 0x70
	[CompilerGenerated]
	private Action<IAd> OnClicked; // 0x78
	[CompilerGenerated]
	private Action<IAd> OnClosed; // 0x80
	[CompilerGenerated]
	private Action<IAd, AdPaidEventData> OnAdPaid; // 0x88

	// Properties
	public string AdUnitId { get; }
	public string NetworkName { get; }
	public bool IsLoading { get; set; }
	public bool IsDisplaying { get; set; }
	public object ResponseInfo { get; set; }
	public AdPaidEventData CurrentPaidData { get; set; }

	// Methods

	// RVA: 0x63D8EFC Offset: 0x63D4EFC VA: 0x63D8EFC
	protected void .ctor(string adUnitId, string networkName) { }

	[CompilerGenerated]
	// RVA: 0x63D8FAC Offset: 0x63D4FAC VA: 0x63D8FAC Slot: 4
	public string get_AdUnitId() { }

	[CompilerGenerated]
	// RVA: 0x63D8FB4 Offset: 0x63D4FB4 VA: 0x63D8FB4 Slot: 5
	public string get_NetworkName() { }

	[CompilerGenerated]
	// RVA: 0x63D8FBC Offset: 0x63D4FBC VA: 0x63D8FBC Slot: 6
	public bool get_IsLoading() { }

	[CompilerGenerated]
	// RVA: 0x63D8FC4 Offset: 0x63D4FC4 VA: 0x63D8FC4
	protected void set_IsLoading(bool value) { }

	[CompilerGenerated]
	// RVA: 0x63D8FD0 Offset: 0x63D4FD0 VA: 0x63D8FD0 Slot: 7
	public bool get_IsDisplaying() { }

	[CompilerGenerated]
	// RVA: 0x63D8FD8 Offset: 0x63D4FD8 VA: 0x63D8FD8
	protected void set_IsDisplaying(bool value) { }

	[CompilerGenerated]
	// RVA: 0x63D8FE4 Offset: 0x63D4FE4 VA: 0x63D8FE4 Slot: 8
	public object get_ResponseInfo() { }

	[CompilerGenerated]
	// RVA: 0x63D8FEC Offset: 0x63D4FEC VA: 0x63D8FEC
	protected void set_ResponseInfo(object value) { }

	[CompilerGenerated]
	// RVA: 0x63D8FF4 Offset: 0x63D4FF4 VA: 0x63D8FF4 Slot: 33
	public AdPaidEventData get_CurrentPaidData() { }

	[CompilerGenerated]
	// RVA: 0x63D8FFC Offset: 0x63D4FFC VA: 0x63D8FFC
	private void set_CurrentPaidData(AdPaidEventData value) { }

	[CompilerGenerated]
	// RVA: 0x63D9004 Offset: 0x63D5004 VA: 0x63D9004 Slot: 13
	public void add_OnLoadStart(Action<IAd> value) { }

	[CompilerGenerated]
	// RVA: 0x63D90B4 Offset: 0x63D50B4 VA: 0x63D90B4 Slot: 14
	public void remove_OnLoadStart(Action<IAd> value) { }

	[CompilerGenerated]
	// RVA: 0x63D9164 Offset: 0x63D5164 VA: 0x63D9164 Slot: 15
	public void add_OnLoadSuccess(Action<IAd> value) { }

	[CompilerGenerated]
	// RVA: 0x63D9214 Offset: 0x63D5214 VA: 0x63D9214 Slot: 16
	public void remove_OnLoadSuccess(Action<IAd> value) { }

	[CompilerGenerated]
	// RVA: 0x63D92C4 Offset: 0x63D52C4 VA: 0x63D92C4 Slot: 17
	public void add_OnLoadFailure(Action<IAd, int, string> value) { }

	[CompilerGenerated]
	// RVA: 0x63D9374 Offset: 0x63D5374 VA: 0x63D9374 Slot: 18
	public void remove_OnLoadFailure(Action<IAd, int, string> value) { }

	[CompilerGenerated]
	// RVA: 0x63D9424 Offset: 0x63D5424 VA: 0x63D9424 Slot: 19
	public void add_OnShowStart(Action<IAd> value) { }

	[CompilerGenerated]
	// RVA: 0x63D94D4 Offset: 0x63D54D4 VA: 0x63D94D4 Slot: 20
	public void remove_OnShowStart(Action<IAd> value) { }

	[CompilerGenerated]
	// RVA: 0x63D9584 Offset: 0x63D5584 VA: 0x63D9584 Slot: 21
	public void add_OnShowSuccess(Action<IAd> value) { }

	[CompilerGenerated]
	// RVA: 0x63D9634 Offset: 0x63D5634 VA: 0x63D9634 Slot: 22
	public void remove_OnShowSuccess(Action<IAd> value) { }

	[CompilerGenerated]
	// RVA: 0x63D96E4 Offset: 0x63D56E4 VA: 0x63D96E4 Slot: 23
	public void add_OnShowFailure(Action<IAd, int, string> value) { }

	[CompilerGenerated]
	// RVA: 0x63D9794 Offset: 0x63D5794 VA: 0x63D9794 Slot: 24
	public void remove_OnShowFailure(Action<IAd, int, string> value) { }

	[CompilerGenerated]
	// RVA: 0x63D9844 Offset: 0x63D5844 VA: 0x63D9844 Slot: 25
	public void add_OnImpression(Action<IAd> value) { }

	[CompilerGenerated]
	// RVA: 0x63D98F4 Offset: 0x63D58F4 VA: 0x63D98F4 Slot: 26
	public void remove_OnImpression(Action<IAd> value) { }

	[CompilerGenerated]
	// RVA: 0x63D99A4 Offset: 0x63D59A4 VA: 0x63D99A4 Slot: 27
	public void add_OnClicked(Action<IAd> value) { }

	[CompilerGenerated]
	// RVA: 0x63D9A54 Offset: 0x63D5A54 VA: 0x63D9A54 Slot: 28
	public void remove_OnClicked(Action<IAd> value) { }

	[CompilerGenerated]
	// RVA: 0x63D9B04 Offset: 0x63D5B04 VA: 0x63D9B04 Slot: 29
	public void add_OnClosed(Action<IAd> value) { }

	[CompilerGenerated]
	// RVA: 0x63D9BB4 Offset: 0x63D5BB4 VA: 0x63D9BB4 Slot: 30
	public void remove_OnClosed(Action<IAd> value) { }

	[CompilerGenerated]
	// RVA: 0x63D9C64 Offset: 0x63D5C64 VA: 0x63D9C64 Slot: 31
	public void add_OnAdPaid(Action<IAd, AdPaidEventData> value) { }

	[CompilerGenerated]
	// RVA: 0x63D9D14 Offset: 0x63D5D14 VA: 0x63D9D14 Slot: 32
	public void remove_OnAdPaid(Action<IAd, AdPaidEventData> value) { }

	// RVA: -1 Offset: -1 Slot: 34
	public abstract void Load();

	// RVA: -1 Offset: -1 Slot: 35
	public abstract void Show();

	// RVA: -1 Offset: -1 Slot: 36
	public abstract bool IsReady();

	// RVA: 0x63D9DC4 Offset: 0x63D5DC4 VA: 0x63D9DC4 Slot: 12
	public AdLoadError GetLoadError(int code) { }

	// RVA: 0x63D9DCC Offset: 0x63D5DCC VA: 0x63D9DCC
	protected void RaiseLoadStart() { }

	// RVA: 0x63D9DF4 Offset: 0x63D5DF4 VA: 0x63D9DF4
	protected void RaiseLoadSuccess(object responseInfo) { }

	// RVA: 0x63D9EEC Offset: 0x63D5EEC VA: 0x63D9EEC
	protected void RaiseLoadFailure(int code, string message) { }

	// RVA: 0x63DA13C Offset: 0x63D613C VA: 0x63DA13C
	protected void RaiseShowStart() { }

	// RVA: 0x63DA198 Offset: 0x63D6198 VA: 0x63DA198
	protected void RaiseShowSuccess(bool recordImpression = True, Action beforeImpression) { }

	// RVA: 0x63DA220 Offset: 0x63D6220 VA: 0x63DA220
	protected void RaiseShowFailure(int code, string message) { }

	// RVA: 0x63DA470 Offset: 0x63D6470 VA: 0x63DA470
	protected void RaiseClicked() { }

	// RVA: 0x63DA490 Offset: 0x63D6490 VA: 0x63DA490
	protected void RaiseClosed() { }

	// RVA: 0x63DA4B4 Offset: 0x63D64B4 VA: 0x63DA4B4
	protected void RaiseAdPaid(AdPaidEventData data) { }
}

// Namespace: 
[Preserve]
private sealed class CsjBannerAd.BannerLoadListener : IExpressBannerAdListener // TypeDefIndex: 28261
{
	// Fields
	private readonly CsjBannerAd _owner; // 0x10

	// Methods

	// RVA: 0x63DA750 Offset: 0x63D6750 VA: 0x63DA750
	public void .ctor(CsjBannerAd owner) { }

	// RVA: 0x63DABB4 Offset: 0x63D6BB4 VA: 0x63DABB4 Slot: 4
	public void OnError(int code, string message) { }

	// RVA: 0x63DABCC Offset: 0x63D6BCC VA: 0x63DABCC Slot: 5
	public void OnBannerAdLoad(ExpressBannerAd ad) { }
}

// Namespace: 
[Preserve]
private sealed class CsjBannerAd.BannerInteractionListener : IExpressBannerInteractionListener // TypeDefIndex: 28262
{
	// Fields
	private readonly CsjBannerAd _owner; // 0x10

	// Methods

	// RVA: 0x63DA860 Offset: 0x63D6860 VA: 0x63DA860
	public void .ctor(CsjBannerAd owner) { }

	// RVA: 0x63DABE4 Offset: 0x63D6BE4 VA: 0x63DABE4 Slot: 4
	public void OnAdViewRenderSucc(float width, float height) { }

	// RVA: 0x63DAC70 Offset: 0x63D6C70 VA: 0x63DAC70 Slot: 5
	public void OnAdViewRenderError(int code, string message) { }

	// RVA: 0x63DAC88 Offset: 0x63D6C88 VA: 0x63DAC88 Slot: 6
	public void OnAdShow() { }

	// RVA: 0x63DAD14 Offset: 0x63D6D14 VA: 0x63DAD14 Slot: 7
	public void OnAdClicked() { }

	// RVA: 0x63DAD48 Offset: 0x63D6D48 VA: 0x63DAD48 Slot: 8
	public void OnAdClose() { }

	// RVA: 0x63DADFC Offset: 0x63D6DFC VA: 0x63DADFC Slot: 9
	public void onAdRemoved() { }
}

// Namespace: GorillaAd.Runtime
[Preserve]
internal sealed class CsjBannerAd : CsjAdBase, IBannerAd, IAd // TypeDefIndex: 28263
{
	// Fields
	private readonly BannerPosition _position; // 0x90
	private ExpressBannerAd _ad; // 0x98
	private float _acceptedWidth; // 0xA0
	private float _acceptedHeight; // 0xA4

	// Methods

	// RVA: 0x63DA508 Offset: 0x63D6508 VA: 0x63DA508
	public void .ctor(string adUnitId, BannerPosition position) { }

	// RVA: 0x63DA56C Offset: 0x63D656C VA: 0x63DA56C Slot: 34
	public override void Load() { }

	// RVA: 0x63DA780 Offset: 0x63D6780 VA: 0x63DA780 Slot: 35
	public override void Show() { }

	// RVA: 0x63DA96C Offset: 0x63D696C VA: 0x63DA96C Slot: 36
	public override bool IsReady() { }

	// RVA: 0x63DA98C Offset: 0x63D698C VA: 0x63DA98C Slot: 37
	public void Hide() { }

	// RVA: 0x63DA990 Offset: 0x63D6990 VA: 0x63DA990 Slot: 38
	public void Destroy() { }

	// RVA: 0x63DA9D0 Offset: 0x63D69D0 VA: 0x63DA9D0
	private void HandleLoaded(ExpressBannerAd ad) { }

	// RVA: 0x63DA6C8 Offset: 0x63D66C8 VA: 0x63DA6C8
	private Vector2 CalculateBannerSize() { }

	// RVA: 0x63DA890 Offset: 0x63D6890 VA: 0x63DA890
	private Vector2 CalculateBannerOrigin() { }
}

// Namespace: GorillaAd.Runtime
[Preserve]
internal abstract class CsjInjector // TypeDefIndex: 28264
{
	// Methods

	[RuntimeInitializeOnLoadMethod(1)]
	[Preserve]
	// RVA: 0x63DAEB0 Offset: 0x63D6EB0 VA: 0x63DAEB0
	private static void Register() { }

	// RVA: 0x63DAF34 Offset: 0x63D6F34 VA: 0x63DAF34
	protected void .ctor() { }
}

// Namespace: 
[Preserve]
private sealed class CsjInterstitialAd.FullScreenLoadListener : IFullScreenVideoAdListener // TypeDefIndex: 28265
{
	// Fields
	private readonly CsjInterstitialAd _owner; // 0x10

	// Methods

	// RVA: 0x63DB0E8 Offset: 0x63D70E8 VA: 0x63DB0E8
	public void .ctor(CsjInterstitialAd owner) { }

	// RVA: 0x63DB4F0 Offset: 0x63D74F0 VA: 0x63DB4F0 Slot: 4
	public void OnError(int code, string message) { }

	// RVA: 0x63DB508 Offset: 0x63D7508 VA: 0x63DB508 Slot: 5
	public void OnFullScreenVideoAdLoad(FullScreenVideoAd ad) { }

	// RVA: 0x63DB520 Offset: 0x63D7520 VA: 0x63DB520 Slot: 6
	public void OnFullScreenVideoCached() { }

	// RVA: 0x63DB524 Offset: 0x63D7524 VA: 0x63DB524 Slot: 7
	public void OnFullScreenVideoCached(FullScreenVideoAd ad) { }
}

// Namespace: 
[Preserve]
private sealed class CsjInterstitialAd.FullScreenInteractionListener : IFullScreenVideoAdInteractionListener // TypeDefIndex: 28266
{
	// Fields
	private readonly CsjInterstitialAd _owner; // 0x10

	// Methods

	// RVA: 0x63DB1F4 Offset: 0x63D71F4 VA: 0x63DB1F4
	public void .ctor(CsjInterstitialAd owner) { }

	// RVA: 0x63DB528 Offset: 0x63D7528 VA: 0x63DB528 Slot: 4
	public void OnAdShow() { }

	// RVA: 0x63DB5B4 Offset: 0x63D75B4 VA: 0x63DB5B4 Slot: 5
	public void OnAdVideoBarClick() { }

	// RVA: 0x63DB5E8 Offset: 0x63D75E8 VA: 0x63DB5E8 Slot: 6
	public void OnAdClose() { }

	// RVA: 0x63DB600 Offset: 0x63D7600 VA: 0x63DB600 Slot: 7
	public void OnVideoComplete() { }

	// RVA: 0x63DB604 Offset: 0x63D7604 VA: 0x63DB604 Slot: 8
	public void OnSkippedVideo() { }

	// RVA: 0x63DB608 Offset: 0x63D7608 VA: 0x63DB608 Slot: 9
	public void OnVideoError() { }
}

// Namespace: GorillaAd.Runtime
[Preserve]
internal sealed class CsjInterstitialAd : CsjAdBase, IInterstitialAd, IAd // TypeDefIndex: 28267
{
	// Fields
	private FullScreenVideoAd _ad; // 0x90

	// Methods

	// RVA: 0x63DAF3C Offset: 0x63D6F3C VA: 0x63DAF3C
	public void .ctor(string adUnitId) { }

	// RVA: 0x63DAF94 Offset: 0x63D6F94 VA: 0x63DAF94 Slot: 34
	public override void Load() { }

	// RVA: 0x63DB118 Offset: 0x63D7118 VA: 0x63DB118 Slot: 35
	public override void Show() { }

	// RVA: 0x63DB224 Offset: 0x63D7224 VA: 0x63DB224 Slot: 36
	public override bool IsReady() { }

	// RVA: 0x63DB244 Offset: 0x63D7244 VA: 0x63DB244
	private void HandleLoaded(FullScreenVideoAd ad) { }

	// RVA: 0x63DB428 Offset: 0x63D7428 VA: 0x63DB428
	private void HandleClosed() { }
}

// Namespace: GorillaAd.Runtime
internal static class CsjMediationDiagnostics // TypeDefIndex: 28268
{
	// Fields
	[CompilerGenerated]
	private static bool <Enabled>k__BackingField; // 0x0

	// Properties
	public static bool Enabled { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x63DB65C Offset: 0x63D765C VA: 0x63DB65C
	public static bool get_Enabled() { }

	[CompilerGenerated]
	// RVA: 0x63DB6A4 Offset: 0x63D76A4 VA: 0x63DB6A4
	public static void set_Enabled(bool value) { }

	// RVA: 0x63DB6F4 Offset: 0x63D76F4 VA: 0x63DB6F4
	public static void Log(string adUnitId, string stage, MediationRewardManager manager) { }

	// RVA: 0x63DB2D4 Offset: 0x63D72D4 VA: 0x63DB2D4
	public static void Log(string adUnitId, string stage, MediationFullScreenManager manager) { }

	// RVA: 0x63DAA60 Offset: 0x63D6A60 VA: 0x63DAA60
	public static void Log(string adUnitId, string stage, MediationBannerManager manager) { }

	// RVA: 0x63DB848 Offset: 0x63D7848 VA: 0x63DB848
	private static void LogCore(string adUnitId, string stage, Nullable<bool> isReady, List<MediationAdLoadInfo> loadInfos, MediationAdEcpmInfo bestEcpm, MediationAdEcpmInfo showEcpm, List<MediationAdEcpmInfo> cacheList, List<MediationAdEcpmInfo> multiBiddingEcpm) { }

	// RVA: 0x63DBC04 Offset: 0x63D7C04 VA: 0x63DBC04
	private static string FormatReady(Nullable<bool> isReady) { }

	// RVA: 0x63DBCC4 Offset: 0x63D7CC4 VA: 0x63DBCC4
	private static string FormatLoadSummary(List<MediationAdLoadInfo> infos) { }

	// RVA: 0x63DC080 Offset: 0x63D8080 VA: 0x63DC080
	private static string FormatEcpm(MediationAdEcpmInfo info) { }

	// RVA: -1 Offset: -1
	private static string FormatCount<T>(List<T> infos) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4563BD8 Offset: 0x455FBD8 VA: 0x4563BD8
	|-CsjMediationDiagnostics.FormatCount<object>
	|
	|-RVA: 0x4563C44 Offset: 0x455FC44 VA: 0x4563C44
	|-CsjMediationDiagnostics.FormatCount<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x63DC204 Offset: 0x63D8204 VA: 0x63DC204
	private static string FormatValue(string value) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CsjPreviewTool.<>c__DisplayClass5_0 // TypeDefIndex: 28269
{
	// Fields
	public Action<int, string> onFailure; // 0x10
	public AndroidJavaObject capturedActivity; // 0x18

	// Methods

	// RVA: 0x63DC6C8 Offset: 0x63D86C8 VA: 0x63DC6C8
	public void .ctor() { }

	// RVA: 0x63DC6D0 Offset: 0x63D86D0 VA: 0x63DC6D0
	internal void <OpenAndroid>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CsjPreviewTool.<>c__DisplayClass5_1 // TypeDefIndex: 28270
{
	// Fields
	public Exception exception; // 0x10
	public CsjPreviewTool.<>c__DisplayClass5_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x63DCAC0 Offset: 0x63D8AC0 VA: 0x63DCAC0
	public void .ctor() { }

	// RVA: 0x63DCAC8 Offset: 0x63D8AC8 VA: 0x63DCAC8
	internal void <OpenAndroid>b__1() { }
}

// Namespace: GorillaAd.Runtime
internal static class CsjPreviewTool // TypeDefIndex: 28271
{
	// Methods

	// RVA: 0x63DC25C Offset: 0x63D825C VA: 0x63DC25C
	public static void Open(Action<int, string> onFailure) { }

	// RVA: 0x63DC260 Offset: 0x63D8260 VA: 0x63DC260
	private static void OpenAndroid(Action<int, string> onFailure) { }
}

// Namespace: GorillaAd.Runtime
[Preserve]
internal sealed class CsjProvider : IAdProvider // TypeDefIndex: 28272
{
	// Fields
	private AdSetting _setting; // 0x10

	// Properties
	public AdProvider Provider { get; }
	public bool IsSdkProvider { get; }

	// Methods

	// RVA: 0x63DCB68 Offset: 0x63D8B68 VA: 0x63DCB68 Slot: 4
	public AdProvider get_Provider() { }

	// RVA: 0x63DCB70 Offset: 0x63D8B70 VA: 0x63DCB70 Slot: 5
	public bool get_IsSdkProvider() { }

	// RVA: 0x63DCB78 Offset: 0x63D8B78 VA: 0x63DCB78 Slot: 6
	public IAdSdkInitializer CreateInitializer(AdSetting setting) { }

	// RVA: 0x63DCC2C Offset: 0x63D8C2C VA: 0x63DCC2C Slot: 7
	public IConsentFlow CreateConsentFlow(AdSetting setting) { }

	// RVA: 0x63DCC34 Offset: 0x63D8C34 VA: 0x63DCC34 Slot: 8
	public IRewardAd CreateRewardAd(string adUnitId) { }

	// RVA: 0x63DCD10 Offset: 0x63D8D10 VA: 0x63DCD10 Slot: 9
	public IInterstitialAd CreateInterstitialAd(string adUnitId) { }

	// RVA: 0x63DCD68 Offset: 0x63D8D68 VA: 0x63DCD68 Slot: 10
	public IBannerAd CreateBannerAd(string adUnitId, BannerPosition position) { }

	// RVA: 0x63DAF2C Offset: 0x63D6F2C VA: 0x63DAF2C
	public void .ctor() { }
}

// Namespace: 
[Preserve]
private sealed class CsjRewardAd.RewardLoadListener : IRewardVideoAdListener // TypeDefIndex: 28273
{
	// Fields
	private readonly CsjRewardAd _owner; // 0x10

	// Methods

	// RVA: 0x63DD3BC Offset: 0x63D93BC VA: 0x63DD3BC
	public void .ctor(CsjRewardAd owner) { }

	// RVA: 0x63DE284 Offset: 0x63DA284 VA: 0x63DE284 Slot: 4
	public void OnError(int code, string message) { }

	// RVA: 0x63DE29C Offset: 0x63DA29C VA: 0x63DE29C Slot: 5
	public void OnRewardVideoAdLoad(RewardVideoAd ad) { }

	// RVA: 0x63DE2B4 Offset: 0x63DA2B4 VA: 0x63DE2B4 Slot: 6
	public void OnRewardVideoCached() { }

	// RVA: 0x63DE2D0 Offset: 0x63DA2D0 VA: 0x63DE2D0 Slot: 7
	public void OnRewardVideoCached(RewardVideoAd ad) { }
}

// Namespace: 
[Preserve]
private sealed class CsjRewardAd.RewardInteractionListener : IRewardAdInteractionListener // TypeDefIndex: 28274
{
	// Fields
	private readonly CsjRewardAd _owner; // 0x10

	// Methods

	// RVA: 0x63DD670 Offset: 0x63D9670 VA: 0x63DD670
	public void .ctor(CsjRewardAd owner) { }

	// RVA: 0x63DE2E8 Offset: 0x63DA2E8 VA: 0x63DE2E8 Slot: 4
	public void OnAdShow() { }

	// RVA: 0x63DE3C4 Offset: 0x63DA3C4 VA: 0x63DE3C4 Slot: 5
	public void OnAdVideoBarClick() { }

	// RVA: 0x63DE3F8 Offset: 0x63DA3F8 VA: 0x63DE3F8 Slot: 6
	public void OnAdClose() { }

	// RVA: 0x63DE410 Offset: 0x63DA410 VA: 0x63DE410 Slot: 7
	public void OnVideoComplete() { }

	// RVA: 0x63DE414 Offset: 0x63DA414 VA: 0x63DE414 Slot: 8
	public void OnVideoSkip() { }

	// RVA: 0x63DE418 Offset: 0x63DA418 VA: 0x63DE418 Slot: 9
	public void OnVideoError() { }

	// RVA: 0x63DE46C Offset: 0x63DA46C VA: 0x63DE46C Slot: 10
	public void OnRewardArrived(bool isRewardValid, int rewardType, IRewardBundleModel extraInfo) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CsjRewardAd.<>c__DisplayClass34_0 // TypeDefIndex: 28275
{
	// Fields
	public int generation; // 0x10
	public CsjRewardAd <>4__this; // 0x18

	// Methods

	// RVA: 0x63DE48C Offset: 0x63DA48C VA: 0x63DE48C
	public void .ctor() { }

	// RVA: 0x63DE494 Offset: 0x63DA494 VA: 0x63DE494
	internal void <VerifyShowStateAfterForegroundRecoveryAsync>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private struct CsjRewardAd.<VerifyShowStateAfterForegroundRecoveryAsync>d__34 : IAsyncStateMachine // TypeDefIndex: 28276
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public int generation; // 0x20
	public CsjRewardAd <>4__this; // 0x28
	private CsjRewardAd.<>c__DisplayClass34_0 <>8__1; // 0x30
	private TaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x63DE510 Offset: 0x63DA510 VA: 0x63DE510 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x63DE81C Offset: 0x63DA81C VA: 0x63DE81C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: GorillaAd.Runtime
[Preserve]
internal sealed class CsjRewardAd : CsjAdBase, IRewardAd, IAd // TypeDefIndex: 28277
{
	// Fields
	private RewardVideoAd _ad; // 0x90
	private bool _adPaidRaised; // 0x98
	private bool _isCached; // 0x99
	private bool _foregroundRecoveryPending; // 0x9A
	private int _showGeneration; // 0x9C
	[CompilerGenerated]
	private string <RewardType>k__BackingField; // 0xA0
	[CompilerGenerated]
	private double <RewardAmount>k__BackingField; // 0xA8
	[CompilerGenerated]
	private Action<IRewardAd> OnRewarded; // 0xB0

	// Properties
	public string RewardType { get; set; }
	public double RewardAmount { get; set; }

	// Methods

	// RVA: 0x63DCC8C Offset: 0x63D8C8C VA: 0x63DCC8C
	public void .ctor(string adUnitId) { }

	[CompilerGenerated]
	// RVA: 0x63DCDD0 Offset: 0x63D8DD0 VA: 0x63DCDD0 Slot: 37
	public string get_RewardType() { }

	[CompilerGenerated]
	// RVA: 0x63DCDD8 Offset: 0x63D8DD8 VA: 0x63DCDD8
	private void set_RewardType(string value) { }

	[CompilerGenerated]
	// RVA: 0x63DCDE0 Offset: 0x63D8DE0 VA: 0x63DCDE0 Slot: 38
	public double get_RewardAmount() { }

	[CompilerGenerated]
	// RVA: 0x63DCDE8 Offset: 0x63D8DE8 VA: 0x63DCDE8
	private void set_RewardAmount(double value) { }

	[CompilerGenerated]
	// RVA: 0x63DCDF0 Offset: 0x63D8DF0 VA: 0x63DCDF0 Slot: 39
	public void add_OnRewarded(Action<IRewardAd> value) { }

	[CompilerGenerated]
	// RVA: 0x63DCEA0 Offset: 0x63D8EA0 VA: 0x63DCEA0 Slot: 40
	public void remove_OnRewarded(Action<IRewardAd> value) { }

	// RVA: 0x63DCF50 Offset: 0x63D8F50 VA: 0x63DCF50 Slot: 34
	public override void Load() { }

	// RVA: 0x63DD3EC Offset: 0x63D93EC VA: 0x63DD3EC Slot: 35
	public override void Show() { }

	// RVA: 0x63DD718 Offset: 0x63D9718 VA: 0x63DD718 Slot: 36
	public override bool IsReady() { }

	// RVA: 0x63DD75C Offset: 0x63D975C VA: 0x63DD75C
	private void HandleLoaded(RewardVideoAd ad) { }

	// RVA: 0x63DD7F0 Offset: 0x63D97F0 VA: 0x63DD7F0
	private void HandleCached(RewardVideoAd ad) { }

	// RVA: 0x63DD890 Offset: 0x63D9890 VA: 0x63DD890
	private void HandleLoadFailure(int code, string message) { }

	// RVA: 0x63DD904 Offset: 0x63D9904 VA: 0x63DD904
	private void HandleClosed() { }

	// RVA: 0x63DD6A0 Offset: 0x63D96A0 VA: 0x63DD6A0
	private void HandleShowFailure(int code, string message) { }

	// RVA: 0x63DD594 Offset: 0x63D9594 VA: 0x63DD594
	private void StartForegroundInterruptionWatch() { }

	// RVA: 0x63DD9E0 Offset: 0x63D99E0 VA: 0x63DD9E0
	private void StopForegroundInterruptionWatch() { }

	// RVA: 0x63DDA94 Offset: 0x63D9A94 VA: 0x63DDA94
	private void HandleApplicationFocusChanged(bool hasFocus) { }

	[AsyncStateMachine(typeof(CsjRewardAd.<VerifyShowStateAfterForegroundRecoveryAsync>d__34))]
	// RVA: 0x63DDABC Offset: 0x63D9ABC VA: 0x63DDABC
	private Task VerifyShowStateAfterForegroundRecoveryAsync(int generation) { }

	// RVA: 0x63DD2F8 Offset: 0x63D92F8 VA: 0x63DD2F8
	private void ApplyRuntimeRewardContext(CsjAdRuntimeContext context) { }

	// RVA: 0x63DDBA8 Offset: 0x63D9BA8 VA: 0x63DDBA8
	private void HandleRewardArrived(bool isRewardValid, IRewardBundleModel extraInfo) { }

	// RVA: 0x63DDF8C Offset: 0x63D9F8C VA: 0x63DDF8C
	private void TryRaiseAdPaidFromShowEcpm() { }

	// RVA: 0x63DDE40 Offset: 0x63D9E40 VA: 0x63DDE40
	private void TryRaiseAdPaidFromRewardBundle(IRewardBundleModel extraInfo) { }

	// RVA: 0x63DDFC8 Offset: 0x63D9FC8 VA: 0x63DDFC8
	private void TryRaiseAdPaid(MediationAdEcpmInfo info) { }

	// RVA: 0x63DE060 Offset: 0x63DA060 VA: 0x63DE060
	private void TryRaiseAdPaid(string ecpm, string network, string unit, string placement) { }

	// RVA: 0x63DD284 Offset: 0x63D9284 VA: 0x63DD284
	private static CsjAdRuntimeContext GetRuntimeContext() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CsjSdkInitializer.<>c__DisplayClass4_0 // TypeDefIndex: 28278
{
	// Fields
	public Stopwatch watch; // 0x10
	public CsjSdkInitializer <>4__this; // 0x18
	public Action<bool> onCompletion; // 0x20

	// Methods

	// RVA: 0x63DED7C Offset: 0x63DAD7C VA: 0x63DED7C
	public void .ctor() { }

	// RVA: 0x63DEF6C Offset: 0x63DAF6C VA: 0x63DEF6C
	internal void <Init>b__0(bool success, string message) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CsjSdkInitializer.<>c__DisplayClass4_1 // TypeDefIndex: 28279
{
	// Fields
	public bool success; // 0x10
	public string message; // 0x18
	public CsjSdkInitializer.<>c__DisplayClass4_0 CS$<>8__locals1; // 0x20

	// Methods

	// RVA: 0x63DF13C Offset: 0x63DB13C VA: 0x63DF13C
	public void .ctor() { }

	// RVA: 0x63DF144 Offset: 0x63DB144 VA: 0x63DF144
	internal void <Init>b__1() { }
}

// Namespace: GorillaAd.Runtime
[Preserve]
internal sealed class CsjSdkInitializer : IAdSdkInitializer // TypeDefIndex: 28280
{
	// Fields
	private readonly AdSetting _setting; // 0x10
	private bool _isInitialized; // 0x18

	// Methods

	// RVA: 0x63DCBFC Offset: 0x63D8BFC VA: 0x63DCBFC
	public void .ctor(AdSetting setting) { }

	// RVA: 0x63DE884 Offset: 0x63DA884 VA: 0x63DE884 Slot: 4
	public void Init(Action<bool> onCompletion) { }

	// RVA: 0x63DED84 Offset: 0x63DAD84 VA: 0x63DED84 Slot: 5
	public void OpenInspector(Action<int, string> onFailure) { }
}

