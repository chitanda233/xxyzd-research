// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 26874
{}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 26875
{
	// Fields
	public byte[] FilePathsData; // 0x0
	public byte[] TypesData; // 0x8
	public int TotalTypes; // 0x10
	public int TotalFiles; // 0x14
	public bool IsEditorOnly; // 0x18
}

// Namespace: 
[CompilerGenerated]
[EditorBrowsable(1)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 26876
{
	// Methods

	// RVA: 0x40BC684 Offset: 0x40B8684 VA: 0x40BC684
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x40BC77C Offset: 0x40B877C VA: 0x40BC77C
	public void .ctor() { }
}

// Namespace: ByteDance.Union
public class AdConst // TypeDefIndex: 26877
{
	// Fields
	public const string PangleSdkVersion = "7.6.0.0";
	public const int NETWORK_STATE_MOBILE = 1;
	public const int NETWORK_STATE_2G = 2;
	public const int NETWORK_STATE_3G = 3;
	public const int NETWORK_STATE_WIFI = 4;
	public const int NETWORK_STATE_4G = 5;
	public const string ADN_GDT = "gdt";
	public const string ADN_PANGLE = "pangle";
	public const string ADN_ADMOB = "admob";
	public const string ADN_MINTEGRAL = "mintegral";
	public const string ADN_UNITY = "unity";
	public const string ADN_BAIDU = "baidu";
	public const string ADN_KS = "ks";
	public const string ADN_SIGMOB = "sigmob";
	public const string ADN_KLEVIN = "klevin";
	public const string GENDER_MALE = "male";
	public const string GENDER_FEMALE = "female";
	public const string GENDER_UNKNOWN = "unknown";
	public const string KEY_GROMORE_EXTRA = "gromoreExtra";
	public const int AD_EVENT_AUTH_DOUYIN = 1;
	public const int TITLE_BAR_THEME_LIGHT = 0;
	public const int TITLE_BAR_THEME_DARK = 1;
	public const int TITLE_BAR_THEME_NO_TITLE_BAR = -1;
	public const string KEY_M_MEDIA_AD_ROTATE_VIEW_ENABLE = "rotate_enable";
	public const string KEY_M_AUTO_PLAY_POLICY = "auto_play_policy";
	public const string KEY_M_TWO_STAGE_INFO = "TwoStageInfo";
	public const string KEY_M_SHOW_ADN_LOAD_ERROR_DETAIL = "show_adn_load_error_detail";
	public const string KEY_NET_OP = "netop";
	public const string KEY_M_IP_ADDR = "mipaddr";
	public const string KEY_W_IP_ADDR = "wipaddr";
	public const string KEY_TAID = "taid";
	public const string KEY_INSTALL_UNINSTALL_LISTEN = "installUninstallListen";
	public const string bum_advertiser_tracking_enabled = "bum_advertiser_tracking_enabled";
	public const string bum_loc_time = "bum_loc_time";
	public const string bum_limit_personal_cpus = "bum_limit_personal_cpus";
	public const string bum_disable_use_phone_status = "bum_disable_use_phone_status";
	public const string bum_custom_idfv = "bum_custom_idfv";
	public const string bum_forbidden_idfv = "bum_forbidden_idfv";

	// Methods

	// RVA: 0x40BC784 Offset: 0x40B8784 VA: 0x40BC784
	public void .ctor() { }
}

// Namespace: ByteDance.Union
public enum AdOrientation // TypeDefIndex: 26878
{
	// Fields
	public int value__; // 0x0
	public const AdOrientation Vertical = 0;
	public const AdOrientation Horizontal = 1;
}

// Namespace: ByteDance.Union
public enum AdSlotType // TypeDefIndex: 26879
{
	// Fields
	public int value__; // 0x0
	public const AdSlotType Banner = 0;
	public const AdSlotType InteractionAd = 1;
	public const AdSlotType Splash = 2;
	public const AdSlotType CachedSplash = 3;
	public const AdSlotType Feed = 4;
	public const AdSlotType RewardVideo = 5;
	public const AdSlotType FullScreenVideo = 6;
	public const AdSlotType DrawFeed = 7;
	public const AdSlotType UNKOWN = 8;
}

// Namespace: ByteDance.Union
public enum AdLoadType // TypeDefIndex: 26880
{
	// Fields
	public int value__; // 0x0
	public const AdLoadType Unknown = -1;
	public const AdLoadType PreLoad = 1;
	public const AdLoadType Load = 3;
}

// Namespace: ByteDance.Union
public interface IClientBidding // TypeDefIndex: 26881
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void setAuctionPrice(double price);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void win(double price);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Loss(double price, string reason, string bidder);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SetAdInteractionListener(ITTAdInteractionListener listener, bool callbackOnMainThread = True);
}

// Namespace: ByteDance.Union
public interface IRewardBundleModel // TypeDefIndex: 26882
{
	// Properties
	public abstract int ServerErrorCode { get; }
	public abstract string ServerErrorMsg { get; }
	public abstract string RewardName { get; }
	public abstract float RewardAmount { get; }
	public abstract float RewardPropose { get; }
	public abstract bool GMIsServerSideVerify { get; }
	public abstract string GMExtra { get; }
	public abstract string GMAdnName { get; }
	public abstract string GMTransId { get; }
	public abstract int GMReason { get; }
	public abstract int GMErrorCode { get; }
	public abstract string GMErrorMsg { get; }
	public abstract string GMEcpm { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_ServerErrorCode();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_ServerErrorMsg();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_RewardName();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract float get_RewardAmount();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float get_RewardPropose();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_GMIsServerSideVerify();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_GMExtra();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_GMAdnName();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_GMTransId();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract int get_GMReason();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int get_GMErrorCode();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract string get_GMErrorMsg();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract string get_GMEcpm();
}

// Namespace: ByteDance.Union
public interface IAppDownloadListener // TypeDefIndex: 26883
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnIdle();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnDownloadActive(long totalBytes, long currBytes, string fileName, string appName);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnDownloadPaused(long totalBytes, long currBytes, string fileName, string appName);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnDownloadFailed(long totalBytes, long currBytes, string fileName, string appName);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnDownloadFinished(long totalBytes, string fileName, string appName);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnInstalled(string fileName, string appName);
}

// Namespace: ByteDance.Union
public interface IDislikeInteractionListener // TypeDefIndex: 26884
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnSelected(int var1, string var2, bool enforce);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnCancel();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnShow();
}

// Namespace: ByteDance.Union
public interface IDrawFeedAdListener // TypeDefIndex: 26885
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnError(int code, string message);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnDrawFeedAdLoad(IList<DrawFeedAd> ads);
}

// Namespace: ByteDance.Union
public interface IExpressAdInteractionListener // TypeDefIndex: 26886
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnAdViewRenderSucc(ExpressAd ad, float width, float height);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnAdViewRenderError(ExpressAd ad, int code, string message);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnAdShow(ExpressAd ad);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnAdClicked(ExpressAd ad);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnAdClose(ExpressAd ad);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void onAdRemoved(ExpressAd ad);
}

// Namespace: ByteDance.Union
public interface IExpressAdListener // TypeDefIndex: 26887
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnError(int code, string message);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnExpressAdLoad(List<ExpressAd> ads);
}

// Namespace: ByteDance.Union
public interface IExpressBannerAdListener // TypeDefIndex: 26888
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnError(int code, string message);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnBannerAdLoad(ExpressBannerAd ad);
}

// Namespace: ByteDance.Union
public interface IExpressBannerInteractionListener // TypeDefIndex: 26889
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnAdViewRenderSucc(float width, float height);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnAdViewRenderError(int code, string message);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnAdShow();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnAdClicked();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnAdClose();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void onAdRemoved();
}

// Namespace: ByteDance.Union
public interface IFeedAdInteractionListener // TypeDefIndex: 26890
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnAdClicked();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnAdCreativeClick();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnAdShow();
}

// Namespace: ByteDance.Union
public interface IFeedAdListener // TypeDefIndex: 26891
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnError(int code, string message);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnFeedAdLoad(IList<FeedAd> ads);
}

// Namespace: ByteDance.Union
public interface IFullScreenVideoAdInteractionListener // TypeDefIndex: 26892
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnAdShow();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnAdVideoBarClick();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnAdClose();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnVideoComplete();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnSkippedVideo();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnVideoError();
}

// Namespace: ByteDance.Union
public interface IFullScreenVideoAdListener // TypeDefIndex: 26893
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnError(int code, string message);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnFullScreenVideoAdLoad(FullScreenVideoAd ad);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnFullScreenVideoCached();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnFullScreenVideoCached(FullScreenVideoAd ad);
}

// Namespace: ByteDance.Union
public interface IInteractionAdInteractionListener // TypeDefIndex: 26894
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnAdClicked();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnAdCreativeClick();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnAdShow();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnAdDismiss();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void onAdRemoved();
}

// Namespace: ByteDance.Union
public interface INativeAdListener // TypeDefIndex: 26895
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnError(int code, string message);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnNativeAdLoad(NativeAd[] ads);
}

// Namespace: ByteDance.Union
public interface IRewardAdInteractionListener // TypeDefIndex: 26896
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnAdShow();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnAdVideoBarClick();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnAdClose();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnVideoComplete();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnVideoSkip();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnVideoError();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnRewardArrived(bool isRewardValid, int rewardType, IRewardBundleModel extraInfo);
}

// Namespace: ByteDance.Union
public interface IRewardVideoAdListener // TypeDefIndex: 26897
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnError(int code, string message);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnRewardVideoAdLoad(RewardVideoAd ad);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnRewardVideoCached();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnRewardVideoCached(RewardVideoAd ad);
}

// Namespace: ByteDance.Union
public interface ISplashAdInteractionListener // TypeDefIndex: 26898
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnAdClicked(int type);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnAdDidShow(int type);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnAdWillShow(int type);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnAdClose(int type);
}

// Namespace: ByteDance.Union
public interface ISplashAdListener // TypeDefIndex: 26899
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnSplashLoadFail(int code, string message);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnSplashLoadSuccess(BUSplashAd ad);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnSplashRenderSuccess(BUSplashAd ad);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnSplashRenderFail(int code, string message);
}

// Namespace: ByteDance.Union
public interface ITTAdInteractionListener // TypeDefIndex: 26900
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnAdEvent(int code, Dictionary<string, object> map);
}

// Namespace: ByteDance.Union
public interface IVideoAdListener // TypeDefIndex: 26901
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnVideoLoad(FeedAd feedAd);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnVideoError(int var1, int var2);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnVideoAdStartPlay(FeedAd feedAd);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnVideoAdPaused(FeedAd feedAd);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnVideoAdContinuePlay(FeedAd feedAd);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnProgressUpdate(long current, long duration);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnVideoAdComplete(FeedAd feedAd);
}

// Namespace: ByteDance.Union
public class PrivacyConfiguration // TypeDefIndex: 26902
{
	// Fields
	[CompilerGenerated]
	private bool <CanUseWifiState>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <CanUseLocation>k__BackingField; // 0x11
	[CompilerGenerated]
	private bool <CanReadAppList>k__BackingField; // 0x12
	[CompilerGenerated]
	private bool <CanUsePhoneState>k__BackingField; // 0x13
	[CompilerGenerated]
	private bool <CanUseWriteExternal>k__BackingField; // 0x14
	[CompilerGenerated]
	private string <MacAddress>k__BackingField; // 0x18
	[CompilerGenerated]
	private double <Latitude>k__BackingField; // 0x20
	[CompilerGenerated]
	private double <Longitude>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <DevImei>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <DevOaid>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <CanUseAndroidId>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <CanUsePermissionRecordAudio>k__BackingField; // 0x41
	[CompilerGenerated]
	private string <AndroidId>k__BackingField; // 0x48
	[CompilerGenerated]
	private Dictionary<string, object> <UserPrivacyConfig>k__BackingField; // 0x50
	[CompilerGenerated]
	private MediationPrivacyConfig <MediationPrivacyConfig>k__BackingField; // 0x58
	[CompilerGenerated]
	private string <CustomIdfa>k__BackingField; // 0x60
	[CompilerGenerated]
	private bool <IsCanUseMessage>k__BackingField; // 0x68

	// Properties
	public bool CanUseWifiState { get; set; }
	public bool CanUseLocation { get; set; }
	public bool CanReadAppList { get; set; }
	public bool CanUsePhoneState { get; set; }
	public bool CanUseWriteExternal { get; set; }
	public string MacAddress { get; set; }
	public double Latitude { get; set; }
	public double Longitude { get; set; }
	public string DevImei { get; set; }
	public string DevOaid { get; set; }
	public bool CanUseAndroidId { get; set; }
	public bool CanUsePermissionRecordAudio { get; set; }
	public string AndroidId { get; set; }
	public Dictionary<string, object> UserPrivacyConfig { get; set; }
	public MediationPrivacyConfig MediationPrivacyConfig { get; set; }
	public string CustomIdfa { get; set; }
	public bool IsCanUseMessage { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x40BC78C Offset: 0x40B878C VA: 0x40BC78C
	public bool get_CanUseWifiState() { }

	[CompilerGenerated]
	// RVA: 0x40BC794 Offset: 0x40B8794 VA: 0x40BC794
	public void set_CanUseWifiState(bool value) { }

	[CompilerGenerated]
	// RVA: 0x40BC7A0 Offset: 0x40B87A0 VA: 0x40BC7A0
	public bool get_CanUseLocation() { }

	[CompilerGenerated]
	// RVA: 0x40BC7A8 Offset: 0x40B87A8 VA: 0x40BC7A8
	public void set_CanUseLocation(bool value) { }

	[CompilerGenerated]
	// RVA: 0x40BC7B4 Offset: 0x40B87B4 VA: 0x40BC7B4
	public bool get_CanReadAppList() { }

	[CompilerGenerated]
	// RVA: 0x40BC7BC Offset: 0x40B87BC VA: 0x40BC7BC
	public void set_CanReadAppList(bool value) { }

	[CompilerGenerated]
	// RVA: 0x40BC7C8 Offset: 0x40B87C8 VA: 0x40BC7C8
	public bool get_CanUsePhoneState() { }

	[CompilerGenerated]
	// RVA: 0x40BC7D0 Offset: 0x40B87D0 VA: 0x40BC7D0
	public void set_CanUsePhoneState(bool value) { }

	[CompilerGenerated]
	// RVA: 0x40BC7DC Offset: 0x40B87DC VA: 0x40BC7DC
	public bool get_CanUseWriteExternal() { }

	[CompilerGenerated]
	// RVA: 0x40BC7E4 Offset: 0x40B87E4 VA: 0x40BC7E4
	public void set_CanUseWriteExternal(bool value) { }

	[CompilerGenerated]
	// RVA: 0x40BC7F0 Offset: 0x40B87F0 VA: 0x40BC7F0
	public string get_MacAddress() { }

	[CompilerGenerated]
	// RVA: 0x40BC7F8 Offset: 0x40B87F8 VA: 0x40BC7F8
	public void set_MacAddress(string value) { }

	[CompilerGenerated]
	// RVA: 0x40BC800 Offset: 0x40B8800 VA: 0x40BC800
	public double get_Latitude() { }

	[CompilerGenerated]
	// RVA: 0x40BC808 Offset: 0x40B8808 VA: 0x40BC808
	public void set_Latitude(double value) { }

	[CompilerGenerated]
	// RVA: 0x40BC810 Offset: 0x40B8810 VA: 0x40BC810
	public double get_Longitude() { }

	[CompilerGenerated]
	// RVA: 0x40BC818 Offset: 0x40B8818 VA: 0x40BC818
	public void set_Longitude(double value) { }

	[CompilerGenerated]
	// RVA: 0x40BC820 Offset: 0x40B8820 VA: 0x40BC820
	public string get_DevImei() { }

	[CompilerGenerated]
	// RVA: 0x40BC828 Offset: 0x40B8828 VA: 0x40BC828
	public void set_DevImei(string value) { }

	[CompilerGenerated]
	// RVA: 0x40BC830 Offset: 0x40B8830 VA: 0x40BC830
	public string get_DevOaid() { }

	[CompilerGenerated]
	// RVA: 0x40BC838 Offset: 0x40B8838 VA: 0x40BC838
	public void set_DevOaid(string value) { }

	[CompilerGenerated]
	// RVA: 0x40BC840 Offset: 0x40B8840 VA: 0x40BC840
	public bool get_CanUseAndroidId() { }

	[CompilerGenerated]
	// RVA: 0x40BC848 Offset: 0x40B8848 VA: 0x40BC848
	public void set_CanUseAndroidId(bool value) { }

	[CompilerGenerated]
	// RVA: 0x40BC854 Offset: 0x40B8854 VA: 0x40BC854
	public bool get_CanUsePermissionRecordAudio() { }

	[CompilerGenerated]
	// RVA: 0x40BC85C Offset: 0x40B885C VA: 0x40BC85C
	public void set_CanUsePermissionRecordAudio(bool value) { }

	[CompilerGenerated]
	// RVA: 0x40BC868 Offset: 0x40B8868 VA: 0x40BC868
	public string get_AndroidId() { }

	[CompilerGenerated]
	// RVA: 0x40BC870 Offset: 0x40B8870 VA: 0x40BC870
	public void set_AndroidId(string value) { }

	[CompilerGenerated]
	// RVA: 0x40BC878 Offset: 0x40B8878 VA: 0x40BC878
	public Dictionary<string, object> get_UserPrivacyConfig() { }

	[CompilerGenerated]
	// RVA: 0x40BC880 Offset: 0x40B8880 VA: 0x40BC880
	public void set_UserPrivacyConfig(Dictionary<string, object> value) { }

	[CompilerGenerated]
	// RVA: 0x40BC888 Offset: 0x40B8888 VA: 0x40BC888
	public MediationPrivacyConfig get_MediationPrivacyConfig() { }

	[CompilerGenerated]
	// RVA: 0x40BC890 Offset: 0x40B8890 VA: 0x40BC890
	public void set_MediationPrivacyConfig(MediationPrivacyConfig value) { }

	[CompilerGenerated]
	// RVA: 0x40BC898 Offset: 0x40B8898 VA: 0x40BC898
	public string get_CustomIdfa() { }

	[CompilerGenerated]
	// RVA: 0x40BC8A0 Offset: 0x40B88A0 VA: 0x40BC8A0
	public void set_CustomIdfa(string value) { }

	[CompilerGenerated]
	// RVA: 0x40BC8A8 Offset: 0x40B88A8 VA: 0x40BC8A8
	public bool get_IsCanUseMessage() { }

	[CompilerGenerated]
	// RVA: 0x40BC8B0 Offset: 0x40B88B0 VA: 0x40BC8B0
	public void set_IsCanUseMessage(bool value) { }

	// RVA: 0x40BC8BC Offset: 0x40B88BC VA: 0x40BC8BC
	public void .ctor() { }
}

// Namespace: 
public class SDKConfiguration.Builder // TypeDefIndex: 26903
{
	// Fields
	private SDKConfiguration configuration; // 0x10

	// Methods

	// RVA: 0x40BC93C Offset: 0x40B893C VA: 0x40BC93C
	public SDKConfiguration.Builder SetAppId(string appId) { }

	// RVA: 0x40BC964 Offset: 0x40B8964 VA: 0x40BC964
	public SDKConfiguration.Builder SetAppName(string appName) { }

	// RVA: 0x40BC98C Offset: 0x40B898C VA: 0x40BC98C
	public SDKConfiguration.Builder SetUseMediation(bool useMediation) { }

	// RVA: 0x40BC9AC Offset: 0x40B89AC VA: 0x40BC9AC
	public SDKConfiguration.Builder SetAllowShowNotify(bool allowShowNotify) { }

	// RVA: 0x40BC9CC Offset: 0x40B89CC VA: 0x40BC9CC
	public SDKConfiguration.Builder SetDebug(bool debug) { }

	// RVA: 0x40BC9EC Offset: 0x40B89EC VA: 0x40BC9EC
	public SDKConfiguration.Builder SetThemeStatus(int themeStatus) { }

	// RVA: 0x40BCA08 Offset: 0x40B8A08 VA: 0x40BCA08
	public SDKConfiguration.Builder SetAgeGroup(int ageGroup) { }

	// RVA: 0x40BCA24 Offset: 0x40B8A24 VA: 0x40BCA24
	public SDKConfiguration.Builder SetSupportMultiProcesse(bool supportMultiProcess) { }

	// RVA: 0x40BCA44 Offset: 0x40B8A44 VA: 0x40BCA44
	public SDKConfiguration.Builder SetPrivacyConfigurationn(PrivacyConfiguration configuration) { }

	// RVA: 0x40BCA6C Offset: 0x40B8A6C VA: 0x40BCA6C
	public SDKConfiguration.Builder SetMediationConfig(MediationConfig mediationConfig) { }

	// RVA: 0x40BCA94 Offset: 0x40B8A94 VA: 0x40BCA94
	public SDKConfiguration.Builder SetDirectDownloadNetworkType(int[] directDownloadNetworkType) { }

	// RVA: 0x40BCABC Offset: 0x40B8ABC VA: 0x40BCABC
	public SDKConfiguration.Builder SetData(string data) { }

	// RVA: 0x40BCAE4 Offset: 0x40B8AE4 VA: 0x40BCAE4
	public SDKConfiguration.Builder SetKeyWords(string keyWords) { }

	// RVA: 0x40BCB0C Offset: 0x40B8B0C VA: 0x40BCB0C
	public SDKConfiguration.Builder SetPaid(bool paid) { }

	// RVA: 0x40BCB2C Offset: 0x40B8B2C VA: 0x40BCB2C
	public SDKConfiguration.Builder SetTitleBarTheme(int titleBarTheme) { }

	// RVA: 0x40BCB48 Offset: 0x40B8B48 VA: 0x40BCB48
	public SDKConfiguration Build() { }

	// RVA: 0x40BCB50 Offset: 0x40B8B50 VA: 0x40BCB50
	public void .ctor() { }
}

// Namespace: ByteDance.Union
public sealed class SDKConfiguration // TypeDefIndex: 26904
{
	// Fields
	internal string appId; // 0x10
	internal string appName; // 0x18
	internal bool useMediation; // 0x20
	internal bool allowShowNotify; // 0x21
	internal bool debug; // 0x22
	internal int themeStatus; // 0x24
	internal bool supportMultiProcess; // 0x28
	internal int[] directDownloadNetworkType; // 0x30
	internal string data; // 0x38
	internal PrivacyConfiguration privacyConfiguration; // 0x40
	internal MediationConfig mediationConfig; // 0x48
	internal int ageGroup; // 0x50
	internal bool paid; // 0x54
	internal string keyWords; // 0x58
	internal int titleBarTheme; // 0x60

	// Methods

	// RVA: 0x40BC8E4 Offset: 0x40B88E4 VA: 0x40BC8E4
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class BUSplashAd.AdInteractionListener.<>c__DisplayClass3_0 // TypeDefIndex: 26905
{
	// Fields
	public BUSplashAd.AdInteractionListener <>4__this; // 0x10
	public AndroidJavaObject ad; // 0x18

	// Methods

	// RVA: 0x40BDD84 Offset: 0x40B9D84 VA: 0x40BDD84
	public void .ctor() { }

	// RVA: 0x40BE244 Offset: 0x40BA244 VA: 0x40BE244
	internal void <onSplashAdClick>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class BUSplashAd.AdInteractionListener.<>c__DisplayClass4_0 // TypeDefIndex: 26906
{
	// Fields
	public BUSplashAd.AdInteractionListener <>4__this; // 0x10
	public AndroidJavaObject ad; // 0x18

	// Methods

	// RVA: 0x40BE060 Offset: 0x40BA060 VA: 0x40BE060
	public void .ctor() { }

	// RVA: 0x40BE2FC Offset: 0x40BA2FC VA: 0x40BE2FC
	internal void <onSplashAdShow>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class BUSplashAd.AdInteractionListener.<>c__DisplayClass5_0 // TypeDefIndex: 26907
{
	// Fields
	public BUSplashAd.AdInteractionListener <>4__this; // 0x10
	public int closeType; // 0x18

	// Methods

	// RVA: 0x40BE164 Offset: 0x40BA164 VA: 0x40BE164
	public void .ctor() { }

	// RVA: 0x40BE3B8 Offset: 0x40BA3B8 VA: 0x40BE3B8
	internal void <onSplashAdClose>b__0() { }
}

// Namespace: 
private sealed class BUSplashAd.AdInteractionListener : AndroidJavaProxy // TypeDefIndex: 26908
{
	// Fields
	private readonly ISplashAdInteractionListener listener; // 0x20
	private bool callbackOnMainThread; // 0x28

	// Methods

	// RVA: 0x40BD174 Offset: 0x40B9174 VA: 0x40BD174
	public void .ctor(ISplashAdInteractionListener listener, bool callbackOnMainThread) { }

	// RVA: 0x40BDC7C Offset: 0x40B9C7C VA: 0x40BDC7C
	public void onSplashAdClick(AndroidJavaObject ad) { }

	// RVA: 0x40BDF58 Offset: 0x40B9F58 VA: 0x40BDF58
	public void onSplashAdShow(AndroidJavaObject ad) { }

	// RVA: 0x40BE068 Offset: 0x40BA068 VA: 0x40BE068
	public void onSplashAdClose(AndroidJavaObject ad, int closeType) { }

	// RVA: 0x40BE16C Offset: 0x40BA16C VA: 0x40BE16C
	public int getType(AndroidJavaObject ad) { }
}

// Namespace: ByteDance.Union
public class BUSplashAd : IClientBidding // TypeDefIndex: 26909
{
	// Fields
	private readonly AndroidJavaObject ad; // 0x10

	// Methods

	// RVA: 0x40BCBB8 Offset: 0x40B8BB8 VA: 0x40BCBB8
	internal void .ctor(AndroidJavaObject ad) { }

	// RVA: 0x40BCBE8 Offset: 0x40B8BE8 VA: 0x40BCBE8
	public int GetInteractionType() { }

	// RVA: 0x40BCCB8 Offset: 0x40B8CB8 VA: 0x40BCCB8
	public void ShowSplashAd() { }

	// RVA: 0x40BCF5C Offset: 0x40B8F5C VA: 0x40BCF5C
	private static void CallJavaMethod(AndroidJavaObject javaObject, string methodName, string signature, object[] obs) { }

	// RVA: 0x40BD064 Offset: 0x40B9064 VA: 0x40BD064
	public AndroidJavaObject getCurrentSplshAd() { }

	// RVA: 0x40BD06C Offset: 0x40B906C VA: 0x40BD06C
	public void SetSplashInteractionListener(ISplashAdInteractionListener listener, bool callbackOnMainThread = True) { }

	// RVA: 0x40BD210 Offset: 0x40B9210 VA: 0x40BD210
	public void SetDownloadListener(IAppDownloadListener listener, bool callbackOnMainThread = True) { }

	// RVA: 0x40BD3B4 Offset: 0x40B93B4 VA: 0x40BD3B4
	public void SetNotAllowSdkCountdown() { }

	// RVA: 0x40BD470 Offset: 0x40B9470 VA: 0x40BD470
	public void Dispose() { }

	// RVA: 0x40BD624 Offset: 0x40B9624 VA: 0x40BD624 Slot: 5
	public void win(double auctionBidToWin) { }

	// RVA: 0x40BD728 Offset: 0x40B9728 VA: 0x40BD728 Slot: 6
	public void Loss(double auctionPrice = NaN, string lossReason, string winBidder) { }

	// RVA: 0x40BD894 Offset: 0x40B9894 VA: 0x40BD894 Slot: 4
	public void setAuctionPrice(double auctionPrice = NaN) { }

	// RVA: 0x40BD990 Offset: 0x40B9990 VA: 0x40BD990 Slot: 7
	public void SetAdInteractionListener(ITTAdInteractionListener ilistener, bool callbackOnMainThread = True) { }

	// RVA: 0x40BDB34 Offset: 0x40B9B34 VA: 0x40BDB34
	public MediationSplashManager GetMediationManager() { }
}

// Namespace: ByteDance.Union
public sealed class DrawFeedAd : FeedAd // TypeDefIndex: 26910
{
	// Methods

	// RVA: 0x40BE46C Offset: 0x40BA46C VA: 0x40BE46C
	internal void .ctor(AndroidJavaObject ad) { }

	// RVA: 0x40BE4B0 Offset: 0x40BA4B0 VA: 0x40BE4B0
	public void SetCanInterruptVideoPlay(bool support) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ExpressAd.ExpressAdInteractionCallback.<>c__DisplayClass5_0 // TypeDefIndex: 26911
{
	// Fields
	public ExpressAd.ExpressAdInteractionCallback <>4__this; // 0x10
	public int code; // 0x18
	public string msg; // 0x20

	// Methods

	// RVA: 0x40BF464 Offset: 0x40BB464 VA: 0x40BF464
	public void .ctor() { }

	// RVA: 0x40BF71C Offset: 0x40BB71C VA: 0x40BF71C
	internal void <onRenderFail>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ExpressAd.ExpressAdInteractionCallback.<>c__DisplayClass6_0 // TypeDefIndex: 26912
{
	// Fields
	public ExpressAd.ExpressAdInteractionCallback <>4__this; // 0x10
	public float width; // 0x18
	public float height; // 0x1C

	// Methods

	// RVA: 0x40BF5C4 Offset: 0x40BB5C4 VA: 0x40BF5C4
	public void .ctor() { }

	// RVA: 0x40BF7DC Offset: 0x40BB7DC VA: 0x40BF7DC
	internal void <onRenderSuccess>b__0() { }
}

// Namespace: 
private sealed class ExpressAd.ExpressAdInteractionCallback : AndroidJavaProxy // TypeDefIndex: 26913
{
	// Fields
	private IExpressAdInteractionListener listener; // 0x20
	private bool callbackOnMainThread; // 0x28

	// Methods

	// RVA: 0x40BF160 Offset: 0x40BB160 VA: 0x40BF160
	public void .ctor(IExpressAdInteractionListener callback, bool callbackOnMainThread) { }

	// RVA: 0x40BF1FC Offset: 0x40BB1FC VA: 0x40BF1FC
	public void onAdClicked(AndroidJavaObject view, int type) { }

	// RVA: 0x40BF2A8 Offset: 0x40BB2A8 VA: 0x40BF2A8
	public void onAdShow(AndroidJavaObject view, int type) { }

	// RVA: 0x40BF354 Offset: 0x40BB354 VA: 0x40BF354
	public void onRenderFail(AndroidJavaObject view, string msg, int code) { }

	// RVA: 0x40BF46C Offset: 0x40BB46C VA: 0x40BF46C
	public void onRenderSuccess(AndroidJavaObject view, float width, float height) { }

	[CompilerGenerated]
	// RVA: 0x40BF5CC Offset: 0x40BB5CC VA: 0x40BF5CC
	private void <onAdClicked>b__3_0() { }

	[CompilerGenerated]
	// RVA: 0x40BF674 Offset: 0x40BB674 VA: 0x40BF674
	private void <onAdShow>b__4_0() { }
}

// Namespace: ByteDance.Union
public sealed class ExpressAd : IDisposable, IClientBidding // TypeDefIndex: 26914
{
	// Fields
	private IExpressAdInteractionListener interactionListener; // 0x10
	private IDislikeInteractionListener dislikeListener; // 0x18
	public AndroidJavaObject javaObject; // 0x20
	public int index; // 0x28

	// Properties
	public AndroidJavaObject handle { get; }

	// Methods

	// RVA: 0x40BE5B8 Offset: 0x40BA5B8 VA: 0x40BE5B8
	internal void .ctor(AndroidJavaObject expressAd) { }

	// RVA: 0x40BE5E8 Offset: 0x40BA5E8 VA: 0x40BE5E8
	public AndroidJavaObject get_handle() { }

	// RVA: 0x40BE5F0 Offset: 0x40BA5F0 VA: 0x40BE5F0
	public int GetInteractionType() { }

	// RVA: 0x40BE6C0 Offset: 0x40BA6C0 VA: 0x40BE6C0
	public void SetExpressInteractionListener(IExpressAdInteractionListener listener, bool callbackOnMainThread = True) { }

	// RVA: 0x40BE6C8 Offset: 0x40BA6C8 VA: 0x40BE6C8
	public void SetDislikeCallback(IDislikeInteractionListener dislikeCallback, bool callbackOnMainThread = True) { }

	// RVA: 0x40BE6D0 Offset: 0x40BA6D0 VA: 0x40BE6D0
	public void SetDownloadListener(IAppDownloadListener listener, bool callbackOnMainThread = True) { }

	// RVA: 0x40BE7D8 Offset: 0x40BA7D8 VA: 0x40BE7D8
	public void SetNotAllowSdkCountdown() { }

	// RVA: 0x40BE7DC Offset: 0x40BA7DC VA: 0x40BE7DC
	public void ShowExpressAd(float x, float y) { }

	// RVA: 0x40BEB70 Offset: 0x40BAB70 VA: 0x40BEB70 Slot: 4
	public void Dispose() { }

	// RVA: 0x40BED20 Offset: 0x40BAD20 VA: 0x40BED20
	public void SetSlideIntervalTime(int intervalTime) { }

	// RVA: 0x40BEE24 Offset: 0x40BAE24 VA: 0x40BEE24 Slot: 6
	public void win(double auctionBidToWin) { }

	// RVA: 0x40BEE2C Offset: 0x40BAE2C VA: 0x40BEE2C Slot: 7
	public void Loss(double auctionPrice = NaN, string lossReason, string winBidder) { }

	// RVA: 0x40BEE34 Offset: 0x40BAE34 VA: 0x40BEE34 Slot: 5
	public void setAuctionPrice(double auctionPrice = NaN) { }

	// RVA: 0x40BEE3C Offset: 0x40BAE3C VA: 0x40BEE3C Slot: 8
	public void SetAdInteractionListener(ITTAdInteractionListener ilistener, bool callbackOnMainThread = True) { }

	// RVA: 0x40BEF44 Offset: 0x40BAF44 VA: 0x40BEF44
	public void UploadDislikeEvent(string dislikeStr) { }

	// RVA: 0x40BF018 Offset: 0x40BB018 VA: 0x40BF018
	public MediationNativeManager GetMediationManager() { }
}

// Namespace: ByteDance.Union
public sealed class ExpressBannerAd : IClientBidding // TypeDefIndex: 26915
{
	// Fields
	public AndroidJavaObject javaObject; // 0x10
	private IExpressBannerInteractionListener interactionListener; // 0x18
	private IDislikeInteractionListener dislikeListener; // 0x20

	// Properties
	public AndroidJavaObject handle { get; }

	// Methods

	// RVA: 0x40BF89C Offset: 0x40BB89C VA: 0x40BF89C
	internal void .ctor(AndroidJavaObject expressAd) { }

	// RVA: 0x40BF8CC Offset: 0x40BB8CC VA: 0x40BF8CC
	public AndroidJavaObject get_handle() { }

	// RVA: 0x40BF8D4 Offset: 0x40BB8D4 VA: 0x40BF8D4
	public void SetExpressInteractionListener(IExpressBannerInteractionListener listener, bool callbackOnMainThread = True) { }

	// RVA: 0x40BF8DC Offset: 0x40BB8DC VA: 0x40BF8DC
	public void SetDislikeCallback(IDislikeInteractionListener dislikeCallback, bool callbackOnMainThread = True) { }

	// RVA: 0x40BF8E4 Offset: 0x40BB8E4 VA: 0x40BF8E4
	public void SetDownloadListener(IAppDownloadListener listener, bool callbackOnMainThread = True) { }

	// RVA: 0x40BF9EC Offset: 0x40BB9EC VA: 0x40BF9EC
	public void ShowExpressAd(float x, float y) { }

	// RVA: 0x40BFD80 Offset: 0x40BBD80 VA: 0x40BFD80
	public void Dispose() { }

	// RVA: 0x40BFF30 Offset: 0x40BBF30 VA: 0x40BFF30
	public void SetSlideIntervalTime(int intervalTime) { }

	// RVA: 0x40C0034 Offset: 0x40BC034 VA: 0x40C0034 Slot: 5
	public void win(double auctionBidToWin) { }

	// RVA: 0x40C003C Offset: 0x40BC03C VA: 0x40C003C Slot: 6
	public void Loss(double auctionPrice = NaN, string lossReason, string winBidder) { }

	// RVA: 0x40C0044 Offset: 0x40BC044 VA: 0x40C0044 Slot: 4
	public void setAuctionPrice(double auctionPrice = NaN) { }

	// RVA: 0x40C004C Offset: 0x40BC04C VA: 0x40C004C Slot: 7
	public void SetAdInteractionListener(ITTAdInteractionListener ilistener, bool callbackOnMainThread = True) { }

	// RVA: 0x40C0154 Offset: 0x40BC154 VA: 0x40C0154
	public void UploadDislikeEvent(string dislikeStr) { }

	// RVA: 0x40C0228 Offset: 0x40BC228 VA: 0x40C0228
	public MediationBannerManager GetMediationManager() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FeedAd.VideoAdListener.<>c__DisplayClass10_0 // TypeDefIndex: 26916
{
	// Fields
	public FeedAd.VideoAdListener <>4__this; // 0x10
	public FeedAd feedAd; // 0x18

	// Methods

	// RVA: 0x40C1334 Offset: 0x40BD334 VA: 0x40C1334
	public void .ctor() { }

	// RVA: 0x40C133C Offset: 0x40BD33C VA: 0x40C133C
	internal void <onVideoAdComplete>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FeedAd.VideoAdListener.<>c__DisplayClass4_0 // TypeDefIndex: 26917
{
	// Fields
	public FeedAd.VideoAdListener <>4__this; // 0x10
	public FeedAd feedAd; // 0x18

	// Methods

	// RVA: 0x40C0BF4 Offset: 0x40BCBF4 VA: 0x40C0BF4
	public void .ctor() { }

	// RVA: 0x40C13F0 Offset: 0x40BD3F0 VA: 0x40C13F0
	internal void <onVideoLoad>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FeedAd.VideoAdListener.<>c__DisplayClass5_0 // TypeDefIndex: 26918
{
	// Fields
	public FeedAd.VideoAdListener <>4__this; // 0x10
	public int var1; // 0x18
	public int var2; // 0x1C

	// Methods

	// RVA: 0x40C0CFC Offset: 0x40BCCFC VA: 0x40C0CFC
	public void .ctor() { }

	// RVA: 0x40C14A0 Offset: 0x40BD4A0 VA: 0x40C14A0
	internal void <onVideoError>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FeedAd.VideoAdListener.<>c__DisplayClass6_0 // TypeDefIndex: 26919
{
	// Fields
	public FeedAd.VideoAdListener <>4__this; // 0x10
	public FeedAd feedAd; // 0x18

	// Methods

	// RVA: 0x40C0E48 Offset: 0x40BCE48 VA: 0x40C0E48
	public void .ctor() { }

	// RVA: 0x40C1558 Offset: 0x40BD558 VA: 0x40C1558
	internal void <onVideoAdStartPlay>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FeedAd.VideoAdListener.<>c__DisplayClass7_0 // TypeDefIndex: 26920
{
	// Fields
	public FeedAd.VideoAdListener <>4__this; // 0x10
	public FeedAd feedAd; // 0x18

	// Methods

	// RVA: 0x40C0F94 Offset: 0x40BCF94 VA: 0x40C0F94
	public void .ctor() { }

	// RVA: 0x40C160C Offset: 0x40BD60C VA: 0x40C160C
	internal void <onVideoAdPaused>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FeedAd.VideoAdListener.<>c__DisplayClass8_0 // TypeDefIndex: 26921
{
	// Fields
	public FeedAd.VideoAdListener <>4__this; // 0x10
	public FeedAd feedAd; // 0x18

	// Methods

	// RVA: 0x40C10E0 Offset: 0x40BD0E0 VA: 0x40C10E0
	public void .ctor() { }

	// RVA: 0x40C16C0 Offset: 0x40BD6C0 VA: 0x40C16C0
	internal void <onVideoAdContinuePlay>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FeedAd.VideoAdListener.<>c__DisplayClass9_0 // TypeDefIndex: 26922
{
	// Fields
	public FeedAd.VideoAdListener <>4__this; // 0x10
	public long current; // 0x18
	public long duration; // 0x20

	// Methods

	// RVA: 0x40C11E8 Offset: 0x40BD1E8 VA: 0x40C11E8
	public void .ctor() { }

	// RVA: 0x40C1774 Offset: 0x40BD774 VA: 0x40C1774
	internal void <onProgressUpdate>b__0() { }
}

// Namespace: 
private sealed class FeedAd.VideoAdListener : AndroidJavaProxy // TypeDefIndex: 26923
{
	// Fields
	private readonly FeedAd ad; // 0x20
	private readonly IVideoAdListener listener; // 0x28
	private bool callbackOnMainThread; // 0x30

	// Methods

	// RVA: 0x40C09F8 Offset: 0x40BC9F8 VA: 0x40C09F8
	public void .ctor(FeedAd ad, IVideoAdListener listener, bool callbackOnMainThread) { }

	// RVA: 0x40C0AB0 Offset: 0x40BCAB0 VA: 0x40C0AB0
	public void onVideoLoad(AndroidJavaObject ad) { }

	// RVA: 0x40C0BFC Offset: 0x40BCBFC VA: 0x40C0BFC
	public void onVideoError(int var1, int var2) { }

	// RVA: 0x40C0D04 Offset: 0x40BCD04 VA: 0x40C0D04
	public void onVideoAdStartPlay(AndroidJavaObject ad) { }

	// RVA: 0x40C0E50 Offset: 0x40BCE50 VA: 0x40C0E50
	public void onVideoAdPaused(AndroidJavaObject ad) { }

	// RVA: 0x40C0F9C Offset: 0x40BCF9C VA: 0x40C0F9C
	public void onVideoAdContinuePlay(AndroidJavaObject ad) { }

	// RVA: 0x40C10E8 Offset: 0x40BD0E8 VA: 0x40C10E8
	public void onProgressUpdate(long current, long duration) { }

	// RVA: 0x40C11F0 Offset: 0x40BD1F0 VA: 0x40C11F0
	public void onVideoAdComplete(AndroidJavaObject ad) { }
}

// Namespace: ByteDance.Union
public class FeedAd : NativeAd // TypeDefIndex: 26924
{
	// Fields
	private IFeedAdInteractionListener listener; // 0x28
	private IDislikeInteractionListener dislike; // 0x30
	internal AndroidJavaObject Handle; // 0x38

	// Methods

	// RVA: 0x40BE470 Offset: 0x40BA470 VA: 0x40BE470
	internal void .ctor(AndroidJavaObject ad) { }

	// RVA: 0x40C03A0 Offset: 0x40BC3A0 VA: 0x40C03A0
	public void Dispose() { }

	// RVA: 0x40C0550 Offset: 0x40BC550 VA: 0x40C0550
	public void ShowFeedAd(float x, float y) { }

	// RVA: 0x40C08DC Offset: 0x40BC8DC VA: 0x40C08DC
	public void SetFeedAdInteractionListener(IFeedAdInteractionListener listener) { }

	// RVA: 0x40C08E4 Offset: 0x40BC8E4 VA: 0x40C08E4
	public void SetFeedAdDislikeListener(IDislikeInteractionListener dislike) { }

	// RVA: 0x40C08EC Offset: 0x40BC8EC VA: 0x40C08EC
	public void SetVideoAdListener(IVideoAdListener listener, bool callbackOnMainThread = True) { }
}

// Namespace: 
private sealed class FullScreenVideoAd.FullScreenVideoAdInteractionListener : AndroidJavaProxy // TypeDefIndex: 26925
{
	// Fields
	private readonly IFullScreenVideoAdInteractionListener listener; // 0x20
	private bool callbackOnMainThread; // 0x28

	// Methods

	// RVA: 0x40C1968 Offset: 0x40BD968 VA: 0x40C1968
	public void .ctor(IFullScreenVideoAdInteractionListener listener, bool callbackOnMainThread) { }

	// RVA: 0x40C2504 Offset: 0x40BE504 VA: 0x40C2504
	public void onAdShow() { }

	// RVA: 0x40C25B0 Offset: 0x40BE5B0 VA: 0x40C25B0
	public void onAdVideoBarClick() { }

	// RVA: 0x40C265C Offset: 0x40BE65C VA: 0x40C265C
	public void onAdClose() { }

	// RVA: 0x40C2708 Offset: 0x40BE708 VA: 0x40C2708
	public void onVideoComplete() { }

	// RVA: 0x40C27B4 Offset: 0x40BE7B4 VA: 0x40C27B4
	public void onSkippedVideo() { }

	[CompilerGenerated]
	// RVA: 0x40C2860 Offset: 0x40BE860 VA: 0x40C2860
	private void <onAdShow>b__3_0() { }

	[CompilerGenerated]
	// RVA: 0x40C2900 Offset: 0x40BE900 VA: 0x40C2900
	private void <onAdVideoBarClick>b__4_0() { }

	[CompilerGenerated]
	// RVA: 0x40C29A4 Offset: 0x40BE9A4 VA: 0x40C29A4
	private void <onAdClose>b__5_0() { }

	[CompilerGenerated]
	// RVA: 0x40C2A48 Offset: 0x40BEA48 VA: 0x40C2A48
	private void <onVideoComplete>b__6_0() { }

	[CompilerGenerated]
	// RVA: 0x40C2AEC Offset: 0x40BEAEC VA: 0x40C2AEC
	private void <onSkippedVideo>b__7_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FullScreenVideoAd.<>c__DisplayClass6_0 // TypeDefIndex: 26926
{
	// Fields
	public FullScreenVideoAd <>4__this; // 0x10
	public AndroidJavaObject activity; // 0x18

	// Methods

	// RVA: 0x40C1D40 Offset: 0x40BDD40 VA: 0x40C1D40
	public void .ctor() { }

	// RVA: 0x40C2B90 Offset: 0x40BEB90 VA: 0x40C2B90
	internal void <ShowFullScreenVideoAd>b__0() { }
}

// Namespace: ByteDance.Union
public sealed class FullScreenVideoAd : IClientBidding // TypeDefIndex: 26927
{
	// Fields
	private readonly AndroidJavaObject ad; // 0x10

	// Methods

	// RVA: 0x40C182C Offset: 0x40BD82C VA: 0x40C182C
	internal void .ctor(AndroidJavaObject ad) { }

	// RVA: 0x40C185C Offset: 0x40BD85C VA: 0x40C185C
	public void Dispose() { }

	// RVA: 0x40C1860 Offset: 0x40BD860 VA: 0x40C1860
	public void SetFullScreenVideoAdInteractionListener(IFullScreenVideoAdInteractionListener listener, bool callbackOnMainThread = True) { }

	// RVA: 0x40C1A04 Offset: 0x40BDA04 VA: 0x40C1A04
	public void SetDownloadListener(IAppDownloadListener listener, bool callbackOnMainThread = True) { }

	// RVA: 0x40C1B0C Offset: 0x40BDB0C VA: 0x40C1B0C
	public int GetInteractionType() { }

	// RVA: 0x40C1BDC Offset: 0x40BDBDC VA: 0x40C1BDC
	public void ShowFullScreenVideoAd() { }

	// RVA: 0x40C1D48 Offset: 0x40BDD48 VA: 0x40C1D48
	public Dictionary<string, string> GetMediaExtraInfo() { }

	// RVA: 0x40C229C Offset: 0x40BE29C VA: 0x40C229C Slot: 5
	public void win(double auctionBidToWin) { }

	// RVA: 0x40C22A4 Offset: 0x40BE2A4 VA: 0x40C22A4 Slot: 6
	public void Loss(double auctionPrice = NaN, string lossReason, string winBidder) { }

	// RVA: 0x40C22AC Offset: 0x40BE2AC VA: 0x40C22AC Slot: 4
	public void setAuctionPrice(double auctionPrice = NaN) { }

	// RVA: 0x40C22B4 Offset: 0x40BE2B4 VA: 0x40C22B4 Slot: 7
	public void SetAdInteractionListener(ITTAdInteractionListener ilistener, bool callbackOnMainThread = True) { }

	// RVA: 0x40C23BC Offset: 0x40BE3BC VA: 0x40C23BC
	public MediationFullScreenManager GetMediationManager() { }
}

// Namespace: ByteDance.Union
public class NativeAd : IClientBidding // TypeDefIndex: 26928
{
	// Fields
	protected readonly AndroidJavaObject ad; // 0x10
	private IInteractionAdInteractionListener interactionListener; // 0x18
	private IDislikeInteractionListener dislikeLinstener; // 0x20

	// Methods

	// RVA: 0x40C0370 Offset: 0x40BC370 VA: 0x40C0370
	internal void .ctor(AndroidJavaObject ad) { }

	// RVA: 0x40C2C60 Offset: 0x40BEC60 VA: 0x40C2C60
	public string GetTitle() { }

	// RVA: 0x40C2D30 Offset: 0x40BED30 VA: 0x40C2D30
	public string GetDescription() { }

	// RVA: 0x40C2E00 Offset: 0x40BEE00 VA: 0x40C2E00
	public string GetButtonText() { }

	// RVA: 0x40C2ED0 Offset: 0x40BEED0 VA: 0x40C2ED0
	public int GetAppScore() { }

	// RVA: 0x40C2FA0 Offset: 0x40BEFA0 VA: 0x40C2FA0
	public int GetAppCommentNum() { }

	// RVA: 0x40C3070 Offset: 0x40BF070 VA: 0x40C3070
	public int GetAppSize() { }

	// RVA: 0x40C3140 Offset: 0x40BF140 VA: 0x40C3140
	public string GetSource() { }

	// RVA: 0x40C3210 Offset: 0x40BF210 VA: 0x40C3210
	public int GetInteractionType() { }

	// RVA: 0x40C32E0 Offset: 0x40BF2E0 VA: 0x40C32E0
	public int GetImageMode() { }

	// RVA: 0x40C33B0 Offset: 0x40BF3B0 VA: 0x40C33B0
	public void SetDownloadListener(IAppDownloadListener listener, bool callbackOnMainThread = True) { }

	// RVA: 0x40C34B8 Offset: 0x40BF4B8 VA: 0x40C34B8
	public void Dispose() { }

	// RVA: 0x40C3668 Offset: 0x40BF668 VA: 0x40C3668 Slot: 5
	public void win(double auctionBidToWin) { }

	// RVA: 0x40C3670 Offset: 0x40BF670 VA: 0x40C3670 Slot: 6
	public void Loss(double auctionPrice = NaN, string lossReason, string winBidder) { }

	// RVA: 0x40C3678 Offset: 0x40BF678 VA: 0x40C3678 Slot: 4
	public void setAuctionPrice(double auctionPrice = NaN) { }

	// RVA: 0x40C3680 Offset: 0x40BF680 VA: 0x40C3680 Slot: 7
	public void SetAdInteractionListener(ITTAdInteractionListener ilistener, bool callbackOnMainThread = True) { }

	// RVA: 0x40C3788 Offset: 0x40BF788 VA: 0x40C3788
	public void UploadDislikeEvent(string dislikeStr) { }

	// RVA: 0x40C385C Offset: 0x40BF85C VA: 0x40C385C
	public MediationNativeManager GetMediationManager() { }

	// RVA: 0x40C3974 Offset: 0x40BF974 VA: 0x40C3974
	public void RenderNative(AndroidJavaObject activity, IDislikeInteractionListener dislikeInteractionListener, AdSlotType type, bool callbackOnMainThread = True) { }

	// RVA: 0x40C3978 Offset: 0x40BF978 VA: 0x40C3978
	public void ShowNativeAd(AdSlotType type, float x, float y) { }

	// RVA: 0x40C3CF8 Offset: 0x40BFCF8 VA: 0x40C3CF8
	public void SetNativeAdInteractionListener(IInteractionAdInteractionListener listener, bool callbackOnMainThread = True) { }

	// RVA: 0x40C3D00 Offset: 0x40BFD00 VA: 0x40C3D00
	public void SetNativeAdDislikeListener(IDislikeInteractionListener dislikeInteractionListener) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RewardVideoAd.RewardAdInteractionListener.<>c__DisplayClass9_0 // TypeDefIndex: 26929
{
	// Fields
	public RewardVideoAd.RewardAdInteractionListener <>4__this; // 0x10
	public bool isRewardValid; // 0x18
	public int rewardType; // 0x1C
	public AndroidJavaObject extraInfo; // 0x20

	// Methods

	// RVA: 0x40C4F34 Offset: 0x40C0F34 VA: 0x40C4F34
	public void .ctor() { }

	// RVA: 0x40C53BC Offset: 0x40C13BC VA: 0x40C53BC
	internal void <onRewardArrived>b__0() { }
}

// Namespace: 
private sealed class RewardVideoAd.RewardAdInteractionListener : AndroidJavaProxy // TypeDefIndex: 26930
{
	// Fields
	private readonly IRewardAdInteractionListener listener; // 0x20
	private readonly bool callbackOnMainThread; // 0x28

	// Methods

	// RVA: 0x40C3F14 Offset: 0x40BFF14 VA: 0x40C3F14
	public void .ctor(IRewardAdInteractionListener listener, bool callbackOnMainThread) { }

	// RVA: 0x40C4AB0 Offset: 0x40C0AB0 VA: 0x40C4AB0
	public void onAdShow() { }

	// RVA: 0x40C4B5C Offset: 0x40C0B5C VA: 0x40C4B5C
	public void onAdVideoBarClick() { }

	// RVA: 0x40C4C08 Offset: 0x40C0C08 VA: 0x40C4C08
	public void onAdClose() { }

	// RVA: 0x40C4CB4 Offset: 0x40C0CB4 VA: 0x40C4CB4
	public void onVideoComplete() { }

	// RVA: 0x40C4D60 Offset: 0x40C0D60 VA: 0x40C4D60
	public void onVideoError() { }

	// RVA: 0x40C4E0C Offset: 0x40C0E0C VA: 0x40C4E0C
	public void onRewardVerify(bool rewardVerify, int rewardAmount, string rewardName, int errorCode, string errorMsg) { }

	// RVA: 0x40C4E10 Offset: 0x40C0E10 VA: 0x40C4E10
	public void onRewardArrived(bool isRewardValid, int rewardType, AndroidJavaObject extraInfo) { }

	// RVA: 0x40C4F3C Offset: 0x40C0F3C VA: 0x40C4F3C
	public void onSkippedVideo() { }

	[CompilerGenerated]
	// RVA: 0x40C4FE8 Offset: 0x40C0FE8 VA: 0x40C4FE8
	private void <onAdShow>b__3_0() { }

	[CompilerGenerated]
	// RVA: 0x40C5088 Offset: 0x40C1088 VA: 0x40C5088
	private void <onAdVideoBarClick>b__4_0() { }

	[CompilerGenerated]
	// RVA: 0x40C512C Offset: 0x40C112C VA: 0x40C512C
	private void <onAdClose>b__5_0() { }

	[CompilerGenerated]
	// RVA: 0x40C51D0 Offset: 0x40C11D0 VA: 0x40C51D0
	private void <onVideoComplete>b__6_0() { }

	[CompilerGenerated]
	// RVA: 0x40C5274 Offset: 0x40C1274 VA: 0x40C5274
	private void <onVideoError>b__7_0() { }

	[CompilerGenerated]
	// RVA: 0x40C5318 Offset: 0x40C1318 VA: 0x40C5318
	private void <onSkippedVideo>b__10_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RewardVideoAd.<>c__DisplayClass6_0 // TypeDefIndex: 26931
{
	// Fields
	public RewardVideoAd <>4__this; // 0x10
	public AndroidJavaObject activity; // 0x18

	// Methods

	// RVA: 0x40C42EC Offset: 0x40C02EC VA: 0x40C42EC
	public void .ctor() { }

	// RVA: 0x40C6204 Offset: 0x40C2204 VA: 0x40C6204
	internal void <ShowRewardVideoAd>b__0() { }
}

// Namespace: ByteDance.Union
public sealed class RewardVideoAd : IDisposable, IClientBidding // TypeDefIndex: 26932
{
	// Fields
	private readonly AndroidJavaObject ad; // 0x10

	// Methods

	// RVA: 0x40C3D08 Offset: 0x40BFD08 VA: 0x40C3D08
	internal void .ctor(AndroidJavaObject ad) { }

	// RVA: 0x40C3E08 Offset: 0x40BFE08 VA: 0x40C3E08 Slot: 4
	public void Dispose() { }

	// RVA: 0x40C3E0C Offset: 0x40BFE0C VA: 0x40C3E0C
	public void SetRewardAdInteractionListener(IRewardAdInteractionListener listener, bool callbackOnMainThread = True) { }

	// RVA: 0x40C3FB0 Offset: 0x40BFFB0 VA: 0x40C3FB0
	public void SetDownloadListener(IAppDownloadListener listener, bool callbackOnMainThread = True) { }

	// RVA: 0x40C40B8 Offset: 0x40C00B8 VA: 0x40C40B8
	public int GetInteractionType() { }

	// RVA: 0x40C4188 Offset: 0x40C0188 VA: 0x40C4188
	public void ShowRewardVideoAd() { }

	// RVA: 0x40C42F4 Offset: 0x40C02F4 VA: 0x40C42F4
	public Dictionary<string, string> GetMediaExtraInfo() { }

	// RVA: 0x40C4848 Offset: 0x40C0848 VA: 0x40C4848 Slot: 6
	public void win(double auctionBidToWin) { }

	// RVA: 0x40C4850 Offset: 0x40C0850 VA: 0x40C4850 Slot: 7
	public void Loss(double auctionPrice = NaN, string lossReason, string winBidder) { }

	// RVA: 0x40C4858 Offset: 0x40C0858 VA: 0x40C4858 Slot: 5
	public void setAuctionPrice(double auctionPrice = NaN) { }

	// RVA: 0x40C4860 Offset: 0x40C0860 VA: 0x40C4860 Slot: 8
	public void SetAdInteractionListener(ITTAdInteractionListener ilistener, bool callbackOnMainThread = True) { }

	// RVA: 0x40C4968 Offset: 0x40C0968 VA: 0x40C4968
	public MediationRewardManager GetMediationManager() { }
}

// Namespace: ByteDance.Union
public sealed class AdDislike // TypeDefIndex: 26933
{
	// Fields
	private readonly AndroidJavaObject ad; // 0x10

	// Methods

	// RVA: 0x40C62D4 Offset: 0x40C22D4 VA: 0x40C62D4
	internal void .ctor(AndroidJavaObject ad) { }

	// RVA: 0x40C6304 Offset: 0x40C2304 VA: 0x40C6304
	public void ShowDislikeDialog() { }

	// RVA: 0x40C63C0 Offset: 0x40C23C0 VA: 0x40C63C0
	public void SetDislikeInteractionCallback(IDislikeInteractionListener listener, bool callbackOnMainThread) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AdNative.FeedAdListener.<>c__DisplayClass3_0 // TypeDefIndex: 26934
{
	// Fields
	public AdNative.FeedAdListener <>4__this; // 0x10
	public int code; // 0x18
	public string message; // 0x20

	// Methods

	// RVA: 0x40C7778 Offset: 0x40C3778 VA: 0x40C7778
	public void .ctor() { }

	// RVA: 0x40C7AE4 Offset: 0x40C3AE4 VA: 0x40C7AE4
	internal void <onError>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AdNative.FeedAdListener.<>c__DisplayClass4_0 // TypeDefIndex: 26935
{
	// Fields
	public AdNative.FeedAdListener <>4__this; // 0x10
	public FeedAd[] ads; // 0x18

	// Methods

	// RVA: 0x40C7ADC Offset: 0x40C3ADC VA: 0x40C7ADC
	public void .ctor() { }

	// RVA: 0x40C7B9C Offset: 0x40C3B9C VA: 0x40C7B9C
	internal void <onFeedAdLoad>b__0() { }
}

// Namespace: 
private sealed class AdNative.FeedAdListener : AndroidJavaProxy // TypeDefIndex: 26936
{
	// Fields
	private readonly IFeedAdListener listener; // 0x20
	private bool callbackOnMainThread; // 0x28

	// Methods

	// RVA: 0x40C66DC Offset: 0x40C26DC VA: 0x40C66DC
	public void .ctor(IFeedAdListener listener, bool callbackOnMainThread) { }

	// RVA: 0x40C7668 Offset: 0x40C3668 VA: 0x40C7668
	public void onError(int code, string message) { }

	// RVA: 0x40C7780 Offset: 0x40C3780 VA: 0x40C7780
	public void onFeedAdLoad(AndroidJavaObject list) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AdNative.DrawFeedAdListener.<>c__DisplayClass3_0 // TypeDefIndex: 26937
{
	// Fields
	public AdNative.DrawFeedAdListener <>4__this; // 0x10
	public int code; // 0x18
	public string message; // 0x20

	// Methods

	// RVA: 0x40C7D60 Offset: 0x40C3D60 VA: 0x40C7D60
	public void .ctor() { }

	// RVA: 0x40C80B4 Offset: 0x40C40B4 VA: 0x40C80B4
	internal void <onError>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AdNative.DrawFeedAdListener.<>c__DisplayClass4_0 // TypeDefIndex: 26938
{
	// Fields
	public AdNative.DrawFeedAdListener <>4__this; // 0x10
	public DrawFeedAd[] ads; // 0x18

	// Methods

	// RVA: 0x40C80AC Offset: 0x40C40AC VA: 0x40C80AC
	public void .ctor() { }

	// RVA: 0x40C816C Offset: 0x40C416C VA: 0x40C816C
	internal void <onDrawFeedAdLoad>b__0() { }
}

// Namespace: 
private sealed class AdNative.DrawFeedAdListener : AndroidJavaProxy // TypeDefIndex: 26939
{
	// Fields
	private readonly IDrawFeedAdListener listener; // 0x20
	private bool callbackOnMainThread; // 0x28

	// Methods

	// RVA: 0x40C68C0 Offset: 0x40C28C0 VA: 0x40C68C0
	public void .ctor(IDrawFeedAdListener listener, bool callbackOnMainThread) { }

	// RVA: 0x40C7C50 Offset: 0x40C3C50 VA: 0x40C7C50
	public void onError(int code, string message) { }

	// RVA: 0x40C7D68 Offset: 0x40C3D68 VA: 0x40C7D68
	public void onDrawFeedAdLoad(AndroidJavaObject list) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AdNative.NativeAdListener.<>c__DisplayClass3_0 // TypeDefIndex: 26940
{
	// Fields
	public AdNative.NativeAdListener <>4__this; // 0x10
	public int code; // 0x18
	public string message; // 0x20

	// Methods

	// RVA: 0x40C8330 Offset: 0x40C4330 VA: 0x40C8330
	public void .ctor() { }

	// RVA: 0x40C86A8 Offset: 0x40C46A8 VA: 0x40C86A8
	internal void <onError>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AdNative.NativeAdListener.<>c__DisplayClass4_0 // TypeDefIndex: 26941
{
	// Fields
	public AdNative.NativeAdListener <>4__this; // 0x10
	public NativeAd[] ads; // 0x18

	// Methods

	// RVA: 0x40C86A0 Offset: 0x40C46A0 VA: 0x40C86A0
	public void .ctor() { }

	// RVA: 0x40C8760 Offset: 0x40C4760 VA: 0x40C8760
	internal void <onNativeAdLoad>b__0() { }
}

// Namespace: 
private sealed class AdNative.NativeAdListener : AndroidJavaProxy // TypeDefIndex: 26942
{
	// Fields
	private readonly INativeAdListener listener; // 0x20
	private bool callbackOnMainThread; // 0x28

	// Methods

	// RVA: 0x40C6AA4 Offset: 0x40C2AA4 VA: 0x40C6AA4
	public void .ctor(INativeAdListener listener, bool callbackOnMainThread) { }

	// RVA: 0x40C8220 Offset: 0x40C4220 VA: 0x40C8220
	public void onError(int code, string message) { }

	// RVA: 0x40C8338 Offset: 0x40C4338 VA: 0x40C8338
	public void onNativeAdLoad(AndroidJavaObject list) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AdNative.SplashAdListener.<>c__DisplayClass5_0 // TypeDefIndex: 26943
{
	// Fields
	public AdNative.SplashAdListener <>4__this; // 0x10
	public int code; // 0x18
	public string message; // 0x20

	// Methods

	// RVA: 0x40C8B90 Offset: 0x40C4B90 VA: 0x40C8B90
	public void .ctor() { }

	// RVA: 0x40C9074 Offset: 0x40C5074 VA: 0x40C9074
	internal void <onSplashLoadFail>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AdNative.SplashAdListener.<>c__DisplayClass7_0 // TypeDefIndex: 26944
{
	// Fields
	public AdNative.SplashAdListener <>4__this; // 0x10
	public int code; // 0x18
	public string message; // 0x20

	// Methods

	// RVA: 0x40C8F14 Offset: 0x40C4F14 VA: 0x40C8F14
	public void .ctor() { }

	// RVA: 0x40C912C Offset: 0x40C512C VA: 0x40C912C
	internal void <onSplashRenderFail>b__0() { }
}

// Namespace: 
private sealed class AdNative.SplashAdListener : AndroidJavaProxy // TypeDefIndex: 26945
{
	// Fields
	private BUSplashAd buSplashAd; // 0x20
	private readonly ISplashAdListener listener; // 0x28
	private bool callbackOnMainThread; // 0x30

	// Methods

	// RVA: 0x40C6CF4 Offset: 0x40C2CF4 VA: 0x40C6CF4
	public void .ctor(ISplashAdListener listener, bool callbackOnMainThread) { }

	// RVA: 0x40C8814 Offset: 0x40C4814 VA: 0x40C8814
	public void onSplashLoadSuccess(AndroidJavaObject handle) { }

	// RVA: 0x40C8920 Offset: 0x40C4920 VA: 0x40C8920
	public void onSplashLoadFail(AndroidJavaObject error) { }

	// RVA: 0x40C8B98 Offset: 0x40C4B98 VA: 0x40C8B98
	public void onSplashRenderSuccess(AndroidJavaObject handle) { }

	// RVA: 0x40C8CA4 Offset: 0x40C4CA4 VA: 0x40C8CA4
	public void onSplashRenderFail(AndroidJavaObject ad, AndroidJavaObject error) { }

	[CompilerGenerated]
	// RVA: 0x40C8F1C Offset: 0x40C4F1C VA: 0x40C8F1C
	private void <onSplashLoadSuccess>b__4_0() { }

	[CompilerGenerated]
	// RVA: 0x40C8FC8 Offset: 0x40C4FC8 VA: 0x40C8FC8
	private void <onSplashRenderSuccess>b__6_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AdNative.RewardVideoAdListener.<>c__DisplayClass3_0 // TypeDefIndex: 26946
{
	// Fields
	public AdNative.RewardVideoAdListener <>4__this; // 0x10
	public int code; // 0x18
	public string message; // 0x20

	// Methods

	// RVA: 0x40C92F8 Offset: 0x40C52F8 VA: 0x40C92F8
	public void .ctor() { }

	// RVA: 0x40C96C0 Offset: 0x40C56C0 VA: 0x40C96C0
	internal void <onError>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AdNative.RewardVideoAdListener.<>c__DisplayClass4_0 // TypeDefIndex: 26947
{
	// Fields
	public AdNative.RewardVideoAdListener <>4__this; // 0x10
	public RewardVideoAd ad; // 0x18

	// Methods

	// RVA: 0x40C9430 Offset: 0x40C5430 VA: 0x40C9430
	public void .ctor() { }

	// RVA: 0x40C9778 Offset: 0x40C5778 VA: 0x40C9778
	internal void <onRewardVideoAdLoad>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AdNative.RewardVideoAdListener.<>c__DisplayClass6_0 // TypeDefIndex: 26948
{
	// Fields
	public AdNative.RewardVideoAdListener <>4__this; // 0x10
	public RewardVideoAd ad; // 0x18

	// Methods

	// RVA: 0x40C9614 Offset: 0x40C5614 VA: 0x40C9614
	public void .ctor() { }

	// RVA: 0x40C982C Offset: 0x40C582C VA: 0x40C982C
	internal void <onRewardVideoCached>b__0() { }
}

// Namespace: 
private sealed class AdNative.RewardVideoAdListener : AndroidJavaProxy // TypeDefIndex: 26949
{
	// Fields
	private readonly IRewardVideoAdListener listener; // 0x20
	private bool callbackOnMainThread; // 0x28

	// Methods

	// RVA: 0x40C7020 Offset: 0x40C3020 VA: 0x40C7020
	public void .ctor(IRewardVideoAdListener listener, bool callbackOnMainThread) { }

	// RVA: 0x40C91E8 Offset: 0x40C51E8 VA: 0x40C91E8
	public void onError(int code, string message) { }

	// RVA: 0x40C9300 Offset: 0x40C5300 VA: 0x40C9300
	public void onRewardVideoAdLoad(AndroidJavaObject handle) { }

	// RVA: 0x40C9438 Offset: 0x40C5438 VA: 0x40C9438
	public void onRewardVideoCached() { }

	// RVA: 0x40C94E4 Offset: 0x40C54E4 VA: 0x40C94E4
	public void onRewardVideoCached(AndroidJavaObject handle) { }

	[CompilerGenerated]
	// RVA: 0x40C961C Offset: 0x40C561C VA: 0x40C961C
	private void <onRewardVideoCached>b__5_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AdNative.FullScreenVideoAdListener.<>c__DisplayClass3_0 // TypeDefIndex: 26950
{
	// Fields
	public AdNative.FullScreenVideoAdListener <>4__this; // 0x10
	public int code; // 0x18
	public string message; // 0x20

	// Methods

	// RVA: 0x40C99F0 Offset: 0x40C59F0 VA: 0x40C99F0
	public void .ctor() { }

	// RVA: 0x40C9DD8 Offset: 0x40C5DD8 VA: 0x40C9DD8
	internal void <onError>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AdNative.FullScreenVideoAdListener.<>c__DisplayClass4_0 // TypeDefIndex: 26951
{
	// Fields
	public AdNative.FullScreenVideoAdListener <>4__this; // 0x10
	public FullScreenVideoAd ad; // 0x18

	// Methods

	// RVA: 0x40C9B38 Offset: 0x40C5B38 VA: 0x40C9B38
	public void .ctor() { }

	// RVA: 0x40C9E90 Offset: 0x40C5E90 VA: 0x40C9E90
	internal void <onFullScreenVideoAdLoad>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AdNative.FullScreenVideoAdListener.<>c__DisplayClass6_0 // TypeDefIndex: 26952
{
	// Fields
	public AdNative.FullScreenVideoAdListener <>4__this; // 0x10
	public FullScreenVideoAd ad; // 0x18

	// Methods

	// RVA: 0x40C9D2C Offset: 0x40C5D2C VA: 0x40C9D2C
	public void .ctor() { }

	// RVA: 0x40C9F44 Offset: 0x40C5F44 VA: 0x40C9F44
	internal void <onFullScreenVideoCached>b__0() { }
}

// Namespace: 
private sealed class AdNative.FullScreenVideoAdListener : AndroidJavaProxy // TypeDefIndex: 26953
{
	// Fields
	private readonly IFullScreenVideoAdListener listener; // 0x20
	private bool callbackOnMainThread; // 0x28

	// Methods

	// RVA: 0x40C7204 Offset: 0x40C3204 VA: 0x40C7204
	public void .ctor(IFullScreenVideoAdListener listener, bool callbackOnMainThread) { }

	// RVA: 0x40C98E0 Offset: 0x40C58E0 VA: 0x40C98E0
	public void onError(int code, string message) { }

	// RVA: 0x40C99F8 Offset: 0x40C59F8 VA: 0x40C99F8
	public void onFullScreenVideoAdLoad(AndroidJavaObject handle) { }

	// RVA: 0x40C9B40 Offset: 0x40C5B40 VA: 0x40C9B40
	public void onFullScreenVideoCached() { }

	// RVA: 0x40C9BEC Offset: 0x40C5BEC VA: 0x40C9BEC
	public void onFullScreenVideoCached(AndroidJavaObject handle) { }

	[CompilerGenerated]
	// RVA: 0x40C9D34 Offset: 0x40C5D34 VA: 0x40C9D34
	private void <onFullScreenVideoCached>b__5_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AdNative.ExpressAdListener.<>c__DisplayClass3_0 // TypeDefIndex: 26954
{
	// Fields
	public AdNative.ExpressAdListener <>4__this; // 0x10
	public int code; // 0x18
	public string message; // 0x20

	// Methods

	// RVA: 0x40CA108 Offset: 0x40C6108 VA: 0x40CA108
	public void .ctor() { }

	// RVA: 0x40CA484 Offset: 0x40C6484 VA: 0x40CA484
	internal void <onError>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AdNative.ExpressAdListener.<>c__DisplayClass4_0 // TypeDefIndex: 26955
{
	// Fields
	public AdNative.ExpressAdListener <>4__this; // 0x10
	public List<ExpressAd> expressAds; // 0x18

	// Methods

	// RVA: 0x40CA47C Offset: 0x40C647C VA: 0x40CA47C
	public void .ctor() { }

	// RVA: 0x40CA53C Offset: 0x40C653C VA: 0x40CA53C
	internal void <onNativeExpressAdLoad>b__0() { }
}

// Namespace: 
private sealed class AdNative.ExpressAdListener : AndroidJavaProxy // TypeDefIndex: 26956
{
	// Fields
	private readonly IExpressAdListener callback; // 0x20
	private bool callbackOnMainThread; // 0x28

	// Methods

	// RVA: 0x40C73E8 Offset: 0x40C33E8 VA: 0x40C73E8
	public void .ctor(IExpressAdListener listener, bool callbackOnMainThread) { }

	// RVA: 0x40C9FF8 Offset: 0x40C5FF8 VA: 0x40C9FF8
	public void onError(int code, string message) { }

	// RVA: 0x40CA110 Offset: 0x40C6110 VA: 0x40CA110
	public void onNativeExpressAdLoad(AndroidJavaObject ads) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AdNative.ExpressBannerAdListener.<>c__DisplayClass3_0 // TypeDefIndex: 26957
{
	// Fields
	public AdNative.ExpressBannerAdListener <>4__this; // 0x10
	public int code; // 0x18
	public string message; // 0x20

	// Methods

	// RVA: 0x40CA700 Offset: 0x40C6700 VA: 0x40CA700
	public void .ctor() { }

	// RVA: 0x40CA9E8 Offset: 0x40C69E8 VA: 0x40CA9E8
	internal void <onError>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AdNative.ExpressBannerAdListener.<>c__DisplayClass4_0 // TypeDefIndex: 26958
{
	// Fields
	public AdNative.ExpressBannerAdListener <>4__this; // 0x10
	public ExpressBannerAd ad; // 0x18

	// Methods

	// RVA: 0x40CA9E0 Offset: 0x40C69E0 VA: 0x40CA9E0
	public void .ctor() { }

	// RVA: 0x40CAAA0 Offset: 0x40C6AA0 VA: 0x40CAAA0
	internal void <onNativeExpressAdLoad>b__0() { }
}

// Namespace: 
private sealed class AdNative.ExpressBannerAdListener : AndroidJavaProxy // TypeDefIndex: 26959
{
	// Fields
	private readonly IExpressBannerAdListener callback; // 0x20
	private bool callbackOnMainThread; // 0x28

	// Methods

	// RVA: 0x40C75CC Offset: 0x40C35CC VA: 0x40C75CC
	public void .ctor(IExpressBannerAdListener listener, bool callbackOnMainThread) { }

	// RVA: 0x40CA5F0 Offset: 0x40C65F0 VA: 0x40CA5F0
	public void onError(int code, string message) { }

	// RVA: 0x40CA708 Offset: 0x40C6708 VA: 0x40CA708
	public void onNativeExpressAdLoad(AndroidJavaObject ads) { }
}

// Namespace: ByteDance.Union
public sealed class AdNative // TypeDefIndex: 26960
{
	// Fields
	private readonly AndroidJavaObject adNative; // 0x10

	// Methods

	// RVA: 0x40C6564 Offset: 0x40C2564 VA: 0x40C6564
	internal void .ctor(AndroidJavaObject adNative) { }

	// RVA: 0x40C6594 Offset: 0x40C2594 VA: 0x40C6594
	public void LoadFeedAd(AdSlot adSlot, IFeedAdListener listener, bool callbackOnMainThread = True) { }

	// RVA: 0x40C6778 Offset: 0x40C2778 VA: 0x40C6778
	public void LoadDrawFeedAd(AdSlot adSlot, IDrawFeedAdListener listener, bool callbackOnMainThread = True) { }

	// RVA: 0x40C695C Offset: 0x40C295C VA: 0x40C695C
	public void LoadNativeAd(AdSlot adSlot, INativeAdListener listener, bool callbackOnMainThread = True) { }

	// RVA: 0x40C6B40 Offset: 0x40C2B40 VA: 0x40C6B40
	public void LoadSplashAd(AdSlot adSlot, ISplashAdListener listener, int timeOut, bool callbackOnMainThread = True) { }

	// RVA: 0x40C6D90 Offset: 0x40C2D90 VA: 0x40C6D90
	public void LoadSplashAd(AdSlot adSlot, ISplashAdListener listener, bool callbackOnMainThread = True) { }

	// RVA: 0x40C6ED8 Offset: 0x40C2ED8 VA: 0x40C6ED8
	public void LoadRewardVideoAd(AdSlot adSlot, IRewardVideoAdListener listener, bool callbackOnMainThread = True) { }

	// RVA: 0x40C70BC Offset: 0x40C30BC VA: 0x40C70BC
	public void LoadFullScreenVideoAd(AdSlot adSlot, IFullScreenVideoAdListener listener, bool callbackOnMainThread = True) { }

	// RVA: 0x40C72A0 Offset: 0x40C32A0 VA: 0x40C72A0
	public void LoadNativeExpressAd(AdSlot adSlot, IExpressAdListener listener, bool callbackOnMainThread = True) { }

	// RVA: 0x40C7484 Offset: 0x40C3484 VA: 0x40C7484
	public void LoadExpressBannerAd(AdSlot adSlot, IExpressBannerAdListener listener, bool callbackOnMainThread = True) { }
}

// Namespace: ByteDance.Union
[Extension]
internal static class AdOrientationAndroid // TypeDefIndex: 26961
{
	// Methods

	[Extension]
	// RVA: 0x40CAB54 Offset: 0x40C6B54 VA: 0x40CAB54
	public static int ToAndroid(AdOrientation orientation) { }
}

// Namespace: 
public sealed class AdSlot.Builder // TypeDefIndex: 26962
{
	// Fields
	private AndroidJavaObject builder; // 0x10

	// Methods

	// RVA: 0x40CAC20 Offset: 0x40C6C20 VA: 0x40CAC20
	public void .ctor() { }

	// RVA: 0x40CAD14 Offset: 0x40C6D14 VA: 0x40CAD14
	public AdSlot.Builder SetCodeId(string codeId) { }

	// RVA: 0x40CAE00 Offset: 0x40C6E00 VA: 0x40CAE00
	public AdSlot.Builder SetImageAcceptedSize(int width, int height) { }

	// RVA: 0x40CAF68 Offset: 0x40C6F68 VA: 0x40CAF68
	public AdSlot.Builder SetExpressViewAcceptedSize(float width, float height) { }

	// RVA: 0x40CB0D8 Offset: 0x40C70D8 VA: 0x40CB0D8
	public AdSlot.Builder SetSupportDeepLink(bool support) { }

	// RVA: 0x40CB1F8 Offset: 0x40C71F8 VA: 0x40CB1F8
	public AdSlot.Builder SetAdCount(int count) { }

	// RVA: 0x40CB314 Offset: 0x40C7314 VA: 0x40CB314
	public AdSlot.Builder SetNativeAdType(AdSlotType type) { }

	// RVA: 0x40CB4D4 Offset: 0x40C74D4 VA: 0x40CB4D4
	public AdSlot.Builder SetRewardName(string name) { }

	// RVA: 0x40CB5C0 Offset: 0x40C75C0 VA: 0x40CB5C0
	public AdSlot.Builder SetRewardAmount(int amount) { }

	// RVA: 0x40CB6DC Offset: 0x40C76DC VA: 0x40CB6DC
	public AdSlot.Builder SetUserID(string id) { }

	// RVA: 0x40CB7C8 Offset: 0x40C77C8 VA: 0x40CB7C8
	public AdSlot.Builder SetOrientation(AdOrientation orientation) { }

	// RVA: 0x40CB8F0 Offset: 0x40C78F0 VA: 0x40CB8F0
	public AdSlot.Builder SetMediaExtra(string extra) { }

	// RVA: 0x40CB9DC Offset: 0x40C79DC VA: 0x40CB9DC
	public AdSlot.Builder SetSlideIntervalTime(int intervalTime) { }

	// RVA: 0x40CB9E0 Offset: 0x40C79E0 VA: 0x40CB9E0
	public AdSlot.Builder SetAdLoadType(AdLoadType adLoadType) { }

	// RVA: 0x40CBBA4 Offset: 0x40C7BA4 VA: 0x40CBBA4
	public AdSlot.Builder SupportIconStyle() { }

	// RVA: 0x40CBC7C Offset: 0x40C7C7C VA: 0x40CBC7C
	public AdSlot.Builder SetMediationAdSlot(MediationAdSlot mediationAdSlot) { }

	// RVA: 0x40CBD70 Offset: 0x40C7D70 VA: 0x40CBD70
	public AdSlot Build() { }
}

// Namespace: ByteDance.Union
public sealed class AdSlot // TypeDefIndex: 26963
{
	// Fields
	private AndroidJavaObject slot; // 0x10

	// Properties
	internal AndroidJavaObject Handle { get; }

	// Methods

	// RVA: 0x40CABE8 Offset: 0x40C6BE8 VA: 0x40CABE8
	internal void .ctor(AndroidJavaObject slot) { }

	// RVA: 0x40CAC18 Offset: 0x40C6C18 VA: 0x40CAC18
	internal AndroidJavaObject get_Handle() { }
}

// Namespace: ByteDance.Union
[Extension]
internal static class AdSlotTypeAndroid // TypeDefIndex: 26964
{
	// Methods

	[Extension]
	// RVA: 0x40CB43C Offset: 0x40C743C VA: 0x40CB43C
	public static int ToAndroid(AdSlotType type) { }
}

// Namespace: ByteDance.Union
public sealed class AndroidBundleWrapper // TypeDefIndex: 26965
{
	// Fields
	private AndroidJavaObject bundle; // 0x10

	// Methods

	// RVA: 0x40CBE88 Offset: 0x40C7E88 VA: 0x40CBE88
	public void .ctor() { }

	// RVA: 0x40CBF7C Offset: 0x40C7F7C VA: 0x40CBF7C
	public void putString(string key, string value) { }

	// RVA: 0x40CC084 Offset: 0x40C8084 VA: 0x40CC084
	public void putBoolean(string key, bool value) { }

	// RVA: 0x40CC1C4 Offset: 0x40C81C4 VA: 0x40CC1C4
	public void putInt(string key, int value) { }

	// RVA: 0x40CC300 Offset: 0x40C8300 VA: 0x40CC300
	public AndroidJavaObject getAndroidBundle() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AppDownloadListener.<>c__DisplayClass4_0 // TypeDefIndex: 26966
{
	// Fields
	public AppDownloadListener <>4__this; // 0x10
	public long totalBytes; // 0x18
	public long currBytes; // 0x20
	public string fileName; // 0x28
	public string appName; // 0x30

	// Methods

	// RVA: 0x40CC4E4 Offset: 0x40C84E4 VA: 0x40CC4E4
	public void .ctor() { }

	// RVA: 0x40CCA54 Offset: 0x40C8A54 VA: 0x40CCA54
	internal void <onDownloadActive>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AppDownloadListener.<>c__DisplayClass5_0 // TypeDefIndex: 26967
{
	// Fields
	public AppDownloadListener <>4__this; // 0x10
	public long totalBytes; // 0x18
	public long currBytes; // 0x20
	public string fileName; // 0x28
	public string appName; // 0x30

	// Methods

	// RVA: 0x40CC61C Offset: 0x40C861C VA: 0x40CC61C
	public void .ctor() { }

	// RVA: 0x40CCB20 Offset: 0x40C8B20 VA: 0x40CCB20
	internal void <onDownloadPaused>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AppDownloadListener.<>c__DisplayClass6_0 // TypeDefIndex: 26968
{
	// Fields
	public AppDownloadListener <>4__this; // 0x10
	public long totalBytes; // 0x18
	public long currBytes; // 0x20
	public string fileName; // 0x28
	public string appName; // 0x30

	// Methods

	// RVA: 0x40CC754 Offset: 0x40C8754 VA: 0x40CC754
	public void .ctor() { }

	// RVA: 0x40CCBEC Offset: 0x40C8BEC VA: 0x40CCBEC
	internal void <onDownloadFailed>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AppDownloadListener.<>c__DisplayClass7_0 // TypeDefIndex: 26969
{
	// Fields
	public AppDownloadListener <>4__this; // 0x10
	public long totalBytes; // 0x18
	public string fileName; // 0x20
	public string appName; // 0x28

	// Methods

	// RVA: 0x40CC888 Offset: 0x40C8888 VA: 0x40CC888
	public void .ctor() { }

	// RVA: 0x40CCCB8 Offset: 0x40C8CB8 VA: 0x40CCCB8
	internal void <onDownloadFinished>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AppDownloadListener.<>c__DisplayClass8_0 // TypeDefIndex: 26970
{
	// Fields
	public AppDownloadListener <>4__this; // 0x10
	public string fileName; // 0x18
	public string appName; // 0x20

	// Methods

	// RVA: 0x40CC9AC Offset: 0x40C89AC VA: 0x40CC9AC
	public void .ctor() { }

	// RVA: 0x40CCD80 Offset: 0x40C8D80 VA: 0x40CCD80
	internal void <onInstalled>b__0() { }
}

// Namespace: ByteDance.Union
internal sealed class AppDownloadListener : AndroidJavaProxy // TypeDefIndex: 26971
{
	// Fields
	private readonly IAppDownloadListener listener; // 0x20
	private bool callbackOnMainThread; // 0x28

	// Methods

	// RVA: 0x40BD318 Offset: 0x40B9318 VA: 0x40BD318
	public void .ctor(IAppDownloadListener listener, bool callbackOnMainThread) { }

	// RVA: 0x40CC308 Offset: 0x40C8308 VA: 0x40CC308
	public void onIdle() { }

	// RVA: 0x40CC3B4 Offset: 0x40C83B4 VA: 0x40CC3B4
	public void onDownloadActive(long totalBytes, long currBytes, string fileName, string appName) { }

	// RVA: 0x40CC4EC Offset: 0x40C84EC VA: 0x40CC4EC
	public void onDownloadPaused(long totalBytes, long currBytes, string fileName, string appName) { }

	// RVA: 0x40CC624 Offset: 0x40C8624 VA: 0x40CC624
	public void onDownloadFailed(long totalBytes, long currBytes, string fileName, string appName) { }

	// RVA: 0x40CC75C Offset: 0x40C875C VA: 0x40CC75C
	public void onDownloadFinished(long totalBytes, string fileName, string appName) { }

	// RVA: 0x40CC890 Offset: 0x40C8890 VA: 0x40CC890
	public void onInstalled(string fileName, string appName) { }

	[CompilerGenerated]
	// RVA: 0x40CC9B4 Offset: 0x40C89B4 VA: 0x40CC9B4
	private void <onIdle>b__3_0() { }
}

// Namespace: ByteDance.Union
public static class ClientBiddingUtils // TypeDefIndex: 26972
{
	// Methods

	// RVA: 0x40BD62C Offset: 0x40B962C VA: 0x40BD62C
	public static void Win(AndroidJavaObject adObject, double auctionBidToWin) { }

	// RVA: 0x40BD730 Offset: 0x40B9730 VA: 0x40BD730
	public static void Loss(AndroidJavaObject adObject, double auctionPrice, string lossReason, string winBidder) { }

	// RVA: 0x40BD89C Offset: 0x40B989C VA: 0x40BD89C
	public static void SetPrice(AndroidJavaObject adObject, double auctionPrice) { }

	// RVA: 0x40CCE38 Offset: 0x40C8E38 VA: 0x40CCE38
	private static AndroidJavaObject ToDoubleObject(double value) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DislikeInteractionCallback.<>c__DisplayClass3_0 // TypeDefIndex: 26973
{
	// Fields
	public DislikeInteractionCallback <>4__this; // 0x10
	public int var1; // 0x18
	public string var2; // 0x20
	public bool enforce; // 0x28

	// Methods

	// RVA: 0x40CD0C0 Offset: 0x40C90C0 VA: 0x40CD0C0
	public void .ctor() { }

	// RVA: 0x40CD368 Offset: 0x40C9368 VA: 0x40CD368
	internal void <onSelected>b__0() { }
}

// Namespace: ByteDance.Union
public sealed class DislikeInteractionCallback : AndroidJavaProxy // TypeDefIndex: 26974
{
	// Fields
	private readonly IDislikeInteractionListener listener; // 0x20
	private bool callbackOnMainThread; // 0x28

	// Methods

	// RVA: 0x40C64C8 Offset: 0x40C24C8 VA: 0x40C64C8
	public void .ctor(IDislikeInteractionListener listener, bool callbackOnMainThread) { }

	// RVA: 0x40CCF9C Offset: 0x40C8F9C VA: 0x40CCF9C
	public void onSelected(int var1, string var2, bool enforce) { }

	// RVA: 0x40CD0C8 Offset: 0x40C90C8 VA: 0x40CD0C8
	public void onCancel() { }

	// RVA: 0x40CD174 Offset: 0x40C9174 VA: 0x40CD174
	public void onShow() { }

	[CompilerGenerated]
	// RVA: 0x40CD220 Offset: 0x40C9220 VA: 0x40CD220
	private void <onCancel>b__4_0() { }

	[CompilerGenerated]
	// RVA: 0x40CD2C4 Offset: 0x40C92C4 VA: 0x40CD2C4
	private void <onShow>b__5_0() { }
}

// Namespace: 
private sealed class NativeAdManager.FeedInteractionListener : AndroidJavaProxy // TypeDefIndex: 26975
{
	// Fields
	private IFeedAdInteractionListener mInteractionListener; // 0x20

	// Methods

	// RVA: 0x40CD800 Offset: 0x40C9800 VA: 0x40CD800
	public void .ctor(IFeedAdInteractionListener listener) { }

	// RVA: 0x40CDA28 Offset: 0x40C9A28 VA: 0x40CDA28
	public void onAdClicked(AndroidJavaObject view, AndroidJavaObject feedAd) { }

	// RVA: 0x40CDAD0 Offset: 0x40C9AD0 VA: 0x40CDAD0
	public void onAdCreativeClick(AndroidJavaObject view, AndroidJavaObject feedAd) { }

	// RVA: 0x40CDB7C Offset: 0x40C9B7C VA: 0x40CDB7C
	public void onAdShow(AndroidJavaObject feedAd) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NativeAdManager.ExpressAdInteractionCallback.<>c__DisplayClass6_0 // TypeDefIndex: 26976
{
	// Fields
	public NativeAdManager.ExpressAdInteractionCallback <>4__this; // 0x10
	public int code; // 0x18
	public string msg; // 0x20

	// Methods

	// RVA: 0x40CDF3C Offset: 0x40C9F3C VA: 0x40CDF3C
	public void .ctor() { }

	// RVA: 0x40CE244 Offset: 0x40CA244 VA: 0x40CE244
	internal void <onRenderFail>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NativeAdManager.ExpressAdInteractionCallback.<>c__DisplayClass7_0 // TypeDefIndex: 26977
{
	// Fields
	public NativeAdManager.ExpressAdInteractionCallback <>4__this; // 0x10
	public float width; // 0x18
	public float height; // 0x1C

	// Methods

	// RVA: 0x40CE044 Offset: 0x40CA044 VA: 0x40CE044
	public void .ctor() { }

	// RVA: 0x40CE304 Offset: 0x40CA304 VA: 0x40CE304
	internal void <onRenderSuccess>b__0() { }
}

// Namespace: 
private sealed class NativeAdManager.ExpressAdInteractionCallback : AndroidJavaProxy // TypeDefIndex: 26978
{
	// Fields
	private IExpressAdInteractionListener listener; // 0x20
	private readonly bool callbackOnMainThread; // 0x28

	// Methods

	// RVA: 0x40CD5BC Offset: 0x40C95BC VA: 0x40CD5BC
	public void .ctor(IExpressAdInteractionListener callback, bool callbackOnMainThread) { }

	// RVA: 0x40CDC28 Offset: 0x40C9C28 VA: 0x40CDC28
	public void onAdDismiss() { }

	// RVA: 0x40CDCD4 Offset: 0x40C9CD4 VA: 0x40CDCD4
	public void onAdClicked(AndroidJavaObject view, int type) { }

	// RVA: 0x40CDD80 Offset: 0x40C9D80 VA: 0x40CDD80
	public void onAdShow(AndroidJavaObject view, int type) { }

	// RVA: 0x40CDE2C Offset: 0x40C9E2C VA: 0x40CDE2C
	public void onRenderFail(AndroidJavaObject view, string msg, int code) { }

	// RVA: 0x40CDF44 Offset: 0x40C9F44 VA: 0x40CDF44
	public void onRenderSuccess(AndroidJavaObject view, float width, float height) { }

	[CompilerGenerated]
	// RVA: 0x40CE04C Offset: 0x40CA04C VA: 0x40CE04C
	private void <onAdDismiss>b__3_0() { }

	[CompilerGenerated]
	// RVA: 0x40CE0F4 Offset: 0x40CA0F4 VA: 0x40CE0F4
	private void <onAdClicked>b__4_0() { }

	[CompilerGenerated]
	// RVA: 0x40CE19C Offset: 0x40CA19C VA: 0x40CE19C
	private void <onAdShow>b__5_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NativeAdManager.ExpressBannerAdInteractionCallback.<>c__DisplayClass6_0 // TypeDefIndex: 26979
{
	// Fields
	public NativeAdManager.ExpressBannerAdInteractionCallback <>4__this; // 0x10
	public int code; // 0x18
	public string msg; // 0x20

	// Methods

	// RVA: 0x40CE6D8 Offset: 0x40CA6D8 VA: 0x40CE6D8
	public void .ctor() { }

	// RVA: 0x40CE9D4 Offset: 0x40CA9D4 VA: 0x40CE9D4
	internal void <onRenderFail>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NativeAdManager.ExpressBannerAdInteractionCallback.<>c__DisplayClass7_0 // TypeDefIndex: 26980
{
	// Fields
	public NativeAdManager.ExpressBannerAdInteractionCallback <>4__this; // 0x10
	public float width; // 0x18
	public float height; // 0x1C

	// Methods

	// RVA: 0x40CE7E0 Offset: 0x40CA7E0 VA: 0x40CE7E0
	public void .ctor() { }

	// RVA: 0x40CEA90 Offset: 0x40CAA90 VA: 0x40CEA90
	internal void <onRenderSuccess>b__0() { }
}

// Namespace: 
private sealed class NativeAdManager.ExpressBannerAdInteractionCallback : AndroidJavaProxy // TypeDefIndex: 26981
{
	// Fields
	private IExpressBannerInteractionListener listener; // 0x20
	private readonly bool callbackOnMainThread; // 0x28

	// Methods

	// RVA: 0x40CD88C Offset: 0x40C988C VA: 0x40CD88C
	public void .ctor(IExpressBannerInteractionListener callback, bool callbackOnMainThread) { }

	// RVA: 0x40CE3C4 Offset: 0x40CA3C4 VA: 0x40CE3C4
	public void onAdDismiss() { }

	// RVA: 0x40CE470 Offset: 0x40CA470 VA: 0x40CE470
	public void onAdClicked(AndroidJavaObject view, int type) { }

	// RVA: 0x40CE51C Offset: 0x40CA51C VA: 0x40CE51C
	public void onAdShow(AndroidJavaObject view, int type) { }

	// RVA: 0x40CE5C8 Offset: 0x40CA5C8 VA: 0x40CE5C8
	public void onRenderFail(AndroidJavaObject view, string msg, int code) { }

	// RVA: 0x40CE6E0 Offset: 0x40CA6E0 VA: 0x40CE6E0
	public void onRenderSuccess(AndroidJavaObject view, float width, float height) { }

	[CompilerGenerated]
	// RVA: 0x40CE7E8 Offset: 0x40CA7E8 VA: 0x40CE7E8
	private void <onAdDismiss>b__3_0() { }

	[CompilerGenerated]
	// RVA: 0x40CE88C Offset: 0x40CA88C VA: 0x40CE88C
	private void <onAdClicked>b__4_0() { }

	[CompilerGenerated]
	// RVA: 0x40CE930 Offset: 0x40CA930 VA: 0x40CE930
	private void <onAdShow>b__5_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NativeAdManager.DisLikeCallback.<>c__DisplayClass3_0 // TypeDefIndex: 26982
{
	// Fields
	public NativeAdManager.DisLikeCallback <>4__this; // 0x10
	public int position; // 0x18
	public string value; // 0x20
	public bool enforce; // 0x28

	// Methods

	// RVA: 0x40CED98 Offset: 0x40CAD98 VA: 0x40CED98
	public void .ctor() { }

	// RVA: 0x40CF040 Offset: 0x40CB040 VA: 0x40CF040
	internal void <onSelected>b__0() { }
}

// Namespace: 
private sealed class NativeAdManager.DisLikeCallback : AndroidJavaProxy // TypeDefIndex: 26983
{
	// Fields
	private IDislikeInteractionListener dislikeInteractionCallback; // 0x20
	private readonly bool callbackOnMainThread; // 0x28

	// Methods

	// RVA: 0x40CD658 Offset: 0x40C9658 VA: 0x40CD658
	public void .ctor(IDislikeInteractionListener dislike, bool callbackOnMainThread) { }

	// RVA: 0x40CEB4C Offset: 0x40CAB4C VA: 0x40CEB4C
	private void onSelected(int position, string value, bool enforce) { }

	// RVA: 0x40CEDA0 Offset: 0x40CADA0 VA: 0x40CEDA0
	private void onCancel() { }

	// RVA: 0x40CEE4C Offset: 0x40CAE4C VA: 0x40CEE4C
	public void onShow() { }

	[CompilerGenerated]
	// RVA: 0x40CEEF8 Offset: 0x40CAEF8 VA: 0x40CEEF8
	private void <onCancel>b__4_0() { }

	[CompilerGenerated]
	// RVA: 0x40CEF9C Offset: 0x40CAF9C VA: 0x40CEF9C
	private void <onShow>b__5_0() { }
}

// Namespace: 
public class NativeAdManager.NativeAdInteractionListener : AndroidJavaProxy // TypeDefIndex: 26984
{
	// Fields
	private IInteractionAdInteractionListener listener; // 0x20
	private bool callbackOnMainThread; // 0x28

	// Methods

	// RVA: 0x40CD928 Offset: 0x40C9928 VA: 0x40CD928
	public void .ctor(IInteractionAdInteractionListener listener, bool callbackOnMainThread = True) { }

	// RVA: 0x40CF10C Offset: 0x40CB10C VA: 0x40CF10C
	public void onAdClicked(AndroidJavaObject view, AndroidJavaObject ad) { }

	// RVA: 0x40CF1B8 Offset: 0x40CB1B8 VA: 0x40CF1B8
	public void onAdCreativeClick(AndroidJavaObject view, AndroidJavaObject ad) { }

	// RVA: 0x40CF264 Offset: 0x40CB264 VA: 0x40CF264
	public void onAdShow(AndroidJavaObject ad) { }

	[CompilerGenerated]
	// RVA: 0x40CF310 Offset: 0x40CB310 VA: 0x40CF310
	private void <onAdClicked>b__3_0() { }

	[CompilerGenerated]
	// RVA: 0x40CF3B8 Offset: 0x40CB3B8 VA: 0x40CF3B8
	private void <onAdCreativeClick>b__4_0() { }

	[CompilerGenerated]
	// RVA: 0x40CF464 Offset: 0x40CB464 VA: 0x40CF464
	private void <onAdShow>b__5_0() { }
}

// Namespace: ByteDance.Union
public class NativeAdManager // TypeDefIndex: 26985
{
	// Fields
	protected readonly AndroidJavaObject nativeAdManager; // 0x10
	private static NativeAdManager sNativeAdManager; // 0x0

	// Methods

	// RVA: 0x40CD434 Offset: 0x40C9434 VA: 0x40CD434
	private void .ctor() { }

	// RVA: 0x40CD564 Offset: 0x40C9564 VA: 0x40CD564
	public static NativeAdManager Instance() { }

	// RVA: 0x40BE8C8 Offset: 0x40BA8C8 VA: 0x40BE8C8
	public void ShowExpressFeedAd(AndroidJavaObject activity, AndroidJavaObject expressAd, IExpressAdInteractionListener listener, IDislikeInteractionListener dislikeInteractionListener, bool callbackOnMainThread, int x, int y) { }

	// RVA: 0x40CD6E4 Offset: 0x40C96E4 VA: 0x40CD6E4
	private void CallJavaMethod(string methodName, string signature, object[] objs) { }

	// RVA: 0x40C063C Offset: 0x40BC63C VA: 0x40C063C
	public void ShowFeedAd(AndroidJavaObject activity, AndroidJavaObject feedAd, IFeedAdInteractionListener listener, IDislikeInteractionListener dislike, bool callbackOnMainThread, int x, int y) { }

	// RVA: 0x40BFAD8 Offset: 0x40BBAD8 VA: 0x40BFAD8
	public void ShowExpressBannerAd(AndroidJavaObject activity, AndroidJavaObject expressAd, IExpressBannerInteractionListener listener, IDislikeInteractionListener dislikeInteractionListener, bool callbackOnMainThread, int x, int y) { }

	// RVA: 0x40BEC08 Offset: 0x40BAC08 VA: 0x40BEC08
	public void DestroyExpressFeedAd(AndroidJavaObject expressFeedAd) { }

	// RVA: 0x40BFE18 Offset: 0x40BBE18 VA: 0x40BFE18
	public void DestroyExpressBannerAd(AndroidJavaObject expressBannerAd) { }

	// RVA: 0x40C0438 Offset: 0x40BC438 VA: 0x40C0438
	public void DestroyFeedAd(AndroidJavaObject feedAd) { }

	// RVA: 0x40C3550 Offset: 0x40BF550 VA: 0x40C3550
	public void DestroyNativeAd(AndroidJavaObject nativeAd) { }

	// RVA: 0x40C3A54 Offset: 0x40BFA54 VA: 0x40C3A54
	public void ShowNativeBannerAd(AndroidJavaObject activity, AndroidJavaObject nativeAd, IInteractionAdInteractionListener listener, IDislikeInteractionListener dislikeInteractionListener, int x, int y) { }

	// RVA: 0x40CD9C4 Offset: 0x40C99C4 VA: 0x40CD9C4
	private static void .cctor() { }
}

// Namespace: 
public sealed class Pangle.PangleInitializeCallBack : MulticastDelegate // TypeDefIndex: 26986
{
	// Methods

	// RVA: 0x40D1638 Offset: 0x40CD638 VA: 0x40D1638
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x40D16D8 Offset: 0x40CD6D8 VA: 0x40D16D8 Slot: 13
	public virtual void Invoke(bool success, string message) { }

	// RVA: 0x40D16F0 Offset: 0x40CD6F0 VA: 0x40D16F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(bool success, string message, AsyncCallback callback, object object) { }

	// RVA: 0x40D1788 Offset: 0x40CD788 VA: 0x40D1788 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private sealed class Pangle.SdkInitCallback : AndroidJavaProxy // TypeDefIndex: 26987
{
	// Fields
	private readonly Pangle.PangleInitializeCallBack listener; // 0x20

	// Methods

	// RVA: 0x40D1794 Offset: 0x40CD794 VA: 0x40D1794
	public void .ctor(Pangle.PangleInitializeCallBack listener) { }

	// RVA: 0x40D1820 Offset: 0x40CD820 VA: 0x40D1820
	public void fail(int code, string message) { }

	// RVA: 0x40D1848 Offset: 0x40CD848 VA: 0x40D1848
	public void success() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Pangle.<>c__DisplayClass1_0 // TypeDefIndex: 26988
{
	// Fields
	public SDKConfiguration sdkConfiguration; // 0x10

	// Methods

	// RVA: 0x40CF6B0 Offset: 0x40CB6B0 VA: 0x40CF6B0
	public void .ctor() { }

	// RVA: 0x40D18A8 Offset: 0x40CD8A8 VA: 0x40D18A8
	internal void <Init>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Pangle.<>c__DisplayClass4_0 // TypeDefIndex: 26989
{
	// Fields
	public Pangle.PangleInitializeCallBack callback; // 0x10

	// Methods

	// RVA: 0x40D1628 Offset: 0x40CD628 VA: 0x40D1628
	public void .ctor() { }

	// RVA: 0x40D18B0 Offset: 0x40CD8B0 VA: 0x40D18B0
	internal void <Start>b__0() { }
}

// Namespace: ByteDance.Union
public class Pangle // TypeDefIndex: 26990
{
	// Methods

	// RVA: 0x40CF510 Offset: 0x40CB510 VA: 0x40CF510
	public static void Init(SDKConfiguration sdkConfiguration) { }

	// RVA: 0x40CF6B8 Offset: 0x40CB6B8 VA: 0x40CF6B8
	public static bool IsSdkReady() { }

	// RVA: 0x40CF7C8 Offset: 0x40CB7C8 VA: 0x40CF7C8
	private static void initTTSdk(SDKConfiguration sdkConfiguration) { }

	// RVA: 0x40D14D4 Offset: 0x40CD4D4 VA: 0x40D14D4
	public static void Start(Pangle.PangleInitializeCallBack callback) { }

	// RVA: 0x40D1630 Offset: 0x40CD630 VA: 0x40D1630
	public void .ctor() { }
}

// Namespace: ByteDance.Union
public class RewardBundleModel : IRewardBundleModel // TypeDefIndex: 26991
{
	// Fields
	private static string REWARD_EXTRA_KEY_ERROR_CODE; // 0x0
	private static string REWARD_EXTRA_KEY_ERROR_MSG; // 0x8
	private static string REWARD_EXTRA_KEY_REWARD_NAME; // 0x10
	private static string REWARD_EXTRA_KEY_REWARD_AMOUNT; // 0x18
	private static string REWARD_EXTRA_KEY_REWARD_PROPOSE; // 0x20
	private const string GM_IS_SERVER_SIDE_VERIFY = "isGroMoreServerSideVerify";
	private const string GM_EXTRA = "gromoreExtra";
	private const string GM_TRANS_ID = "transId";
	private const string GM_REASON = "reason";
	private const string GM_ERROR_CODE = "errorCode";
	private const string GM_ERROR_MSG = "errorMsg";
	private const string GM_ADN_NAME = "adnName";
	private const string GM_ECPM = "ecpm";
	[CompilerGenerated]
	private readonly int <ServerErrorCode>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <ServerErrorMsg>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string <RewardName>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly float <RewardAmount>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly float <RewardPropose>k__BackingField; // 0x2C
	[CompilerGenerated]
	private readonly bool <GMIsServerSideVerify>k__BackingField; // 0x30
	[CompilerGenerated]
	private readonly string <GMExtra>k__BackingField; // 0x38
	[CompilerGenerated]
	private readonly string <GMAdnName>k__BackingField; // 0x40
	[CompilerGenerated]
	private readonly string <GMTransId>k__BackingField; // 0x48
	[CompilerGenerated]
	private readonly int <GMReason>k__BackingField; // 0x50
	[CompilerGenerated]
	private readonly int <GMErrorCode>k__BackingField; // 0x54
	[CompilerGenerated]
	private readonly string <GMErrorMsg>k__BackingField; // 0x58
	[CompilerGenerated]
	private readonly string <GMEcpm>k__BackingField; // 0x60

	// Properties
	public int ServerErrorCode { get; }
	public string ServerErrorMsg { get; }
	public string RewardName { get; }
	public float RewardAmount { get; }
	public float RewardPropose { get; }
	public bool GMIsServerSideVerify { get; }
	public string GMExtra { get; }
	public string GMAdnName { get; }
	public string GMTransId { get; }
	public int GMReason { get; }
	public int GMErrorCode { get; }
	public string GMErrorMsg { get; }
	public string GMEcpm { get; }

	// Methods

	// RVA: 0x40D19EC Offset: 0x40CD9EC VA: 0x40D19EC
	private void .ctor(int serverErrorCode, string serverErrorMsg, string rewardName, float rewardAmount, float rewardPropose, bool isGromoreServersideVerify, string gromoreExtra, string transId, int reason, int errCode, string errMsg, string adnName, string ecpm) { }

	// RVA: 0x40C54BC Offset: 0x40C14BC VA: 0x40C54BC
	public static RewardBundleModel Create(AndroidJavaObject extraInfo) { }

	[CompilerGenerated]
	// RVA: 0x40D1AEC Offset: 0x40CDAEC VA: 0x40D1AEC Slot: 4
	public int get_ServerErrorCode() { }

	[CompilerGenerated]
	// RVA: 0x40D1AF4 Offset: 0x40CDAF4 VA: 0x40D1AF4 Slot: 5
	public string get_ServerErrorMsg() { }

	[CompilerGenerated]
	// RVA: 0x40D1AFC Offset: 0x40CDAFC VA: 0x40D1AFC Slot: 6
	public string get_RewardName() { }

	[CompilerGenerated]
	// RVA: 0x40D1B04 Offset: 0x40CDB04 VA: 0x40D1B04 Slot: 7
	public float get_RewardAmount() { }

	[CompilerGenerated]
	// RVA: 0x40D1B0C Offset: 0x40CDB0C VA: 0x40D1B0C Slot: 8
	public float get_RewardPropose() { }

	[CompilerGenerated]
	// RVA: 0x40D1B14 Offset: 0x40CDB14 VA: 0x40D1B14 Slot: 9
	public bool get_GMIsServerSideVerify() { }

	[CompilerGenerated]
	// RVA: 0x40D1B1C Offset: 0x40CDB1C VA: 0x40D1B1C Slot: 10
	public string get_GMExtra() { }

	[CompilerGenerated]
	// RVA: 0x40D1B24 Offset: 0x40CDB24 VA: 0x40D1B24 Slot: 11
	public string get_GMAdnName() { }

	[CompilerGenerated]
	// RVA: 0x40D1B2C Offset: 0x40CDB2C VA: 0x40D1B2C Slot: 12
	public string get_GMTransId() { }

	[CompilerGenerated]
	// RVA: 0x40D1B34 Offset: 0x40CDB34 VA: 0x40D1B34 Slot: 13
	public int get_GMReason() { }

	[CompilerGenerated]
	// RVA: 0x40D1B3C Offset: 0x40CDB3C VA: 0x40D1B3C Slot: 14
	public int get_GMErrorCode() { }

	[CompilerGenerated]
	// RVA: 0x40D1B44 Offset: 0x40CDB44 VA: 0x40D1B44 Slot: 15
	public string get_GMErrorMsg() { }

	[CompilerGenerated]
	// RVA: 0x40D1B4C Offset: 0x40CDB4C VA: 0x40D1B4C Slot: 16
	public string get_GMEcpm() { }

	// RVA: 0x40D1B54 Offset: 0x40CDB54 VA: 0x40D1B54 Slot: 3
	public override string ToString() { }

	// RVA: 0x40D1F0C Offset: 0x40CDF0C VA: 0x40D1F0C
	private static void .cctor() { }
}

// Namespace: 
private sealed class SDK.ExitInstallListener : AndroidJavaProxy // TypeDefIndex: 26992
{
	// Fields
	private readonly Action callback; // 0x20

	// Methods

	// RVA: 0x40D2594 Offset: 0x40CE594 VA: 0x40D2594
	public void .ctor(Action callback) { }

	// RVA: 0x40D3778 Offset: 0x40CF778 VA: 0x40D3778
	public void onExitInstall() { }
}

// Namespace: ByteDance.Union
public static class SDK // TypeDefIndex: 26993
{
	// Fields
	private static AndroidJavaObject activity; // 0x0
	private static AndroidJavaObject adManager; // 0x8

	// Properties
	public static string Version { get; }

	// Methods

	// RVA: 0x40D2028 Offset: 0x40CE028 VA: 0x40D2028
	public static string get_Version() { }

	// RVA: 0x40D224C Offset: 0x40CE24C VA: 0x40D224C
	public static AdNative CreateAdNative() { }

	// RVA: 0x40D2378 Offset: 0x40CE378 VA: 0x40D2378
	public static void RequestPermissionIfNecessary() { }

	// RVA: 0x40D2448 Offset: 0x40CE448 VA: 0x40D2448
	public static bool TryShowInstallDialogWhenExit(Action onExitInstall) { }

	// RVA: 0x40D20F8 Offset: 0x40CE0F8 VA: 0x40D20F8
	private static AndroidJavaObject GetAdManager() { }

	// RVA: 0x40D2620 Offset: 0x40CE620 VA: 0x40D2620
	public static void MediationPreload(AndroidJavaObject activity, List<MediationPreloadRequestInfo> requestInfos, int parallelNum, int requestIntervalS) { }

	// RVA: 0x40D2D8C Offset: 0x40CED8C VA: 0x40D2D8C
	public static void MediationSetUserInfoForSegment(MediationConfigUserInfoForSegment segment) { }

	// RVA: 0x40D32DC Offset: 0x40CF2DC VA: 0x40D32DC
	public static void MediationSetPublisherDid(string publisherDid) { }

	// RVA: 0x40D33BC Offset: 0x40CF3BC VA: 0x40D33BC
	public static void MediationSetThemeStatus(int themeStatus) { }

	// RVA: 0x40D34B8 Offset: 0x40CF4B8 VA: 0x40D34B8
	public static void MediationUpdatePrivacyConfig(PrivacyConfiguration privacyConfig) { }

	// RVA: 0x40D3598 Offset: 0x40CF598 VA: 0x40D3598
	public static Dictionary<string, object> GetMediationExtraInfo() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TTAdInteractionListener.<>c__DisplayClass3_0 // TypeDefIndex: 26994
{
	// Fields
	public TTAdInteractionListener <>4__this; // 0x10
	public int code; // 0x18
	public Dictionary<string, object> map; // 0x20

	// Methods

	// RVA: 0x40D3A44 Offset: 0x40CFA44 VA: 0x40D3A44
	public void .ctor() { }

	// RVA: 0x40D3A4C Offset: 0x40CFA4C VA: 0x40D3A4C
	internal void <onAdEvent>b__0() { }
}

// Namespace: ByteDance.Union
internal sealed class TTAdInteractionListener : AndroidJavaProxy // TypeDefIndex: 26995
{
	// Fields
	private readonly ITTAdInteractionListener listener; // 0x20
	private bool callbackOnMainThread; // 0x28

	// Methods

	// RVA: 0x40BDA98 Offset: 0x40B9A98 VA: 0x40BDA98
	public void .ctor(ITTAdInteractionListener listener, bool callbackOnMainThread) { }

	// RVA: 0x40D37D4 Offset: 0x40CF7D4 VA: 0x40D37D4
	public void onAdEvent(int code, AndroidJavaObject jMap) { }
}

// Namespace: ByteDance.Union
public class Utils // TypeDefIndex: 26996
{
	// Methods

	// RVA: 0x40D0308 Offset: 0x40CC308 VA: 0x40D0308
	public static AndroidJavaObject MakeCustomController(PrivacyConfiguration controller) { }

	// RVA: 0x40D0E1C Offset: 0x40CCE1C VA: 0x40D0E1C
	public static AndroidJavaObject MakeMediationConfig(MediationConfig mediationConfig) { }

	// RVA: 0x40D2E6C Offset: 0x40CEE6C VA: 0x40D2E6C
	public static AndroidJavaObject MakeMediationConfigUserInfoForSegment(MediationConfigUserInfoForSegment segment) { }

	// RVA: 0x40D3B04 Offset: 0x40CFB04 VA: 0x40D3B04
	public static AndroidJavaObject MakeMediationPrivacyConfig(MediationPrivacyConfig config) { }

	// RVA: 0x40D2918 Offset: 0x40CE918 VA: 0x40D2918
	public static AndroidJavaObject MakeMediationPreloadReqInfos(List<MediationPreloadRequestInfo> reqInfos) { }

	// RVA: 0x40D3EB8 Offset: 0x40CFEB8 VA: 0x40D3EB8
	public static AndroidJavaObject GetMapFromDictionary(Dictionary<string, object> dict) { }

	// RVA: 0x40D48EC Offset: 0x40D08EC VA: 0x40D48EC
	public static AndroidJavaObject GetMapFromDictionary(Dictionary<string, string> dict) { }

	// RVA: 0x40D46CC Offset: 0x40D06CC VA: 0x40D46CC
	public static AndroidJavaObject GetJsonObjFromJsonStr(string jsonStr) { }

	// RVA: 0x40D4C14 Offset: 0x40D0C14 VA: 0x40D4C14
	public static AndroidJavaObject GetJavaListFromList(List<string> list) { }

	// RVA: 0x40D2808 Offset: 0x40CE808 VA: 0x40D2808
	public static AndroidJavaObject GetMediationManager() { }

	// RVA: 0x40BCEB8 Offset: 0x40B8EB8 VA: 0x40BCEB8
	public static AndroidJavaObject GetActivity() { }

	// RVA: 0x40D4ED0 Offset: 0x40D0ED0 VA: 0x40D4ED0
	public static List<MediationAdLoadInfo> GetAdLoadInfo(AndroidJavaObject handle) { }

	// RVA: 0x40D54D0 Offset: 0x40D14D0 VA: 0x40D54D0
	public static List<MediationAdEcpmInfo> GetMultiBiddingEcpm(AndroidJavaObject handle) { }

	// RVA: 0x40D5828 Offset: 0x40D1828 VA: 0x40D5828
	public static List<MediationAdEcpmInfo> GetCacheList(AndroidJavaObject handle) { }

	// RVA: 0x40D5870 Offset: 0x40D1870 VA: 0x40D5870
	public static MediationAdEcpmInfo GetBestEcpm(AndroidJavaObject handle) { }

	// RVA: 0x40D65D8 Offset: 0x40D25D8 VA: 0x40D65D8
	public static MediationAdEcpmInfo GetShowEcpm(AndroidJavaObject handle) { }

	// RVA: 0x40D5518 Offset: 0x40D1518 VA: 0x40D5518
	private static List<MediationAdEcpmInfo> GetMediationAdEcpmInfos(AndroidJavaObject handle, string javaMethodName) { }

	// RVA: 0x40D594C Offset: 0x40D194C VA: 0x40D594C
	private static MediationAdEcpmInfo GetMediationAdEcpmInfo(AndroidJavaObject jEcpmInfo) { }

	// RVA: 0x40D66BC Offset: 0x40D26BC VA: 0x40D66BC
	public void .ctor() { }
}

// Namespace: ByteDance.Union
[DisallowMultipleComponent]
internal sealed class UnityDispatcher : MonoBehaviour // TypeDefIndex: 26997
{
	// Fields
	private static UnityDispatcher instance; // 0x0
	private static List<Action> postTasks; // 0x8
	private static List<Action> executing; // 0x10

	// Properties
	private static UnityDispatcher Instance { get; }

	// Methods

	// RVA: 0x40D66C4 Offset: 0x40D26C4 VA: 0x40D66C4
	private static UnityDispatcher get_Instance() { }

	// RVA: 0x40BDD8C Offset: 0x40B9D8C VA: 0x40BDD8C
	public static void PostTask(Action task, bool executeOnMainThread = True) { }

	[RuntimeInitializeOnLoadMethod]
	// RVA: 0x40D6720 Offset: 0x40D2720 VA: 0x40D6720
	private static void CheckInstance() { }

	// RVA: 0x40D696C Offset: 0x40D296C VA: 0x40D696C
	private void Awake() { }

	// RVA: 0x40D69C4 Offset: 0x40D29C4 VA: 0x40D69C4
	private void OnDestroy() { }

	// RVA: 0x40D6AA0 Offset: 0x40D2AA0 VA: 0x40D6AA0
	private void Update() { }

	// RVA: 0x40D6EF4 Offset: 0x40D2EF4 VA: 0x40D6EF4
	public void .ctor() { }

	// RVA: 0x40D6EFC Offset: 0x40D2EFC VA: 0x40D6EFC
	private static void .cctor() { }
}

// Namespace: ByteDance.Union.Mediation
[Serializable]
public sealed class MediationAdEcpmInfo // TypeDefIndex: 26998
{
	// Fields
	public Dictionary<string, string> customData; // 0x10
	public string sdkName; // 0x18
	public string customSdkName; // 0x20
	public string slotId; // 0x28
	public string levelTag; // 0x30
	public string ecpm; // 0x38
	public int reqBiddingType; // 0x40
	public string errorMsg; // 0x48
	public string requestId; // 0x50
	public string ritType; // 0x58
	public string segmentId; // 0x60
	public string channel; // 0x68
	public string subChannel; // 0x70
	public string abTestId; // 0x78
	public string scenarioId; // 0x80

	// Methods

	// RVA: 0x40D6FB4 Offset: 0x40D2FB4 VA: 0x40D6FB4 Slot: 3
	public override string ToString() { }

	// RVA: 0x40D66B4 Offset: 0x40D26B4 VA: 0x40D66B4
	public void .ctor() { }
}

// Namespace: ByteDance.Union.Mediation
public sealed class MediationAdLoadInfo // TypeDefIndex: 26999
{
	// Fields
	[CompilerGenerated]
	private string <mediationRit>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <adnName>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <adType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <errCode>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <errMsg>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <errUserInfo>k__BackingField; // 0x38

	// Properties
	public string mediationRit { get; set; }
	public string adnName { get; set; }
	public string adType { get; set; }
	public int errCode { get; set; }
	public string errMsg { get; set; }
	public string errUserInfo { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x40D778C Offset: 0x40D378C VA: 0x40D778C
	public void set_mediationRit(string value) { }

	[CompilerGenerated]
	// RVA: 0x40D7794 Offset: 0x40D3794 VA: 0x40D7794
	public string get_mediationRit() { }

	[CompilerGenerated]
	// RVA: 0x40D779C Offset: 0x40D379C VA: 0x40D779C
	public void set_adnName(string value) { }

	[CompilerGenerated]
	// RVA: 0x40D77A4 Offset: 0x40D37A4 VA: 0x40D77A4
	public string get_adnName() { }

	[CompilerGenerated]
	// RVA: 0x40D77AC Offset: 0x40D37AC VA: 0x40D77AC
	public void set_adType(string value) { }

	[CompilerGenerated]
	// RVA: 0x40D77B4 Offset: 0x40D37B4 VA: 0x40D77B4
	public string get_adType() { }

	[CompilerGenerated]
	// RVA: 0x40D77BC Offset: 0x40D37BC VA: 0x40D77BC
	public void set_errCode(int value) { }

	[CompilerGenerated]
	// RVA: 0x40D77C4 Offset: 0x40D37C4 VA: 0x40D77C4
	public int get_errCode() { }

	[CompilerGenerated]
	// RVA: 0x40D77CC Offset: 0x40D37CC VA: 0x40D77CC
	public void set_errMsg(string value) { }

	[CompilerGenerated]
	// RVA: 0x40D77D4 Offset: 0x40D37D4 VA: 0x40D77D4
	public string get_errMsg() { }

	[CompilerGenerated]
	// RVA: 0x40D77DC Offset: 0x40D37DC VA: 0x40D77DC
	public void set_errUserInfo(string value) { }

	[CompilerGenerated]
	// RVA: 0x40D77E4 Offset: 0x40D37E4 VA: 0x40D77E4
	public string get_errUserInfo() { }

	// RVA: 0x40D77EC Offset: 0x40D37EC VA: 0x40D77EC Slot: 3
	public override string ToString() { }

	// RVA: 0x40D54C8 Offset: 0x40D14C8 VA: 0x40D54C8
	public void .ctor() { }
}

// Namespace: ByteDance.Union.Mediation
public class MediationConfig // TypeDefIndex: 27000
{
	// Fields
	[CompilerGenerated]
	private string <PublisherDid>k__BackingField; // 0x10
	[CompilerGenerated]
	private MediationConfigUserInfoForSegment <MediationConfigUserInfoForSegment>k__BackingField; // 0x18
	[CompilerGenerated]
	private Dictionary<string, object> <LocalExtra>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <UseHttps>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <CustomLocalConfig>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <OpensdkVer>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <WxInstalled>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <SupportH265>k__BackingField; // 0x41
	[CompilerGenerated]
	private bool <SupportSplashZoomout>k__BackingField; // 0x42
	[CompilerGenerated]
	private string <WxAppId>k__BackingField; // 0x48

	// Properties
	public string PublisherDid { get; set; }
	public MediationConfigUserInfoForSegment MediationConfigUserInfoForSegment { get; set; }
	public Dictionary<string, object> LocalExtra { get; set; }
	public bool UseHttps { get; set; }
	public string CustomLocalConfig { get; set; }
	public string OpensdkVer { get; set; }
	public bool WxInstalled { get; set; }
	public bool SupportH265 { get; set; }
	public bool SupportSplashZoomout { get; set; }
	public string WxAppId { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x40D7A60 Offset: 0x40D3A60 VA: 0x40D7A60
	public string get_PublisherDid() { }

	[CompilerGenerated]
	// RVA: 0x40D7A68 Offset: 0x40D3A68 VA: 0x40D7A68
	public void set_PublisherDid(string value) { }

	[CompilerGenerated]
	// RVA: 0x40D7A70 Offset: 0x40D3A70 VA: 0x40D7A70
	public MediationConfigUserInfoForSegment get_MediationConfigUserInfoForSegment() { }

	[CompilerGenerated]
	// RVA: 0x40D7A78 Offset: 0x40D3A78 VA: 0x40D7A78
	public void set_MediationConfigUserInfoForSegment(MediationConfigUserInfoForSegment value) { }

	[CompilerGenerated]
	// RVA: 0x40D7A80 Offset: 0x40D3A80 VA: 0x40D7A80
	public Dictionary<string, object> get_LocalExtra() { }

	[CompilerGenerated]
	// RVA: 0x40D7A88 Offset: 0x40D3A88 VA: 0x40D7A88
	public void set_LocalExtra(Dictionary<string, object> value) { }

	[CompilerGenerated]
	// RVA: 0x40D7A90 Offset: 0x40D3A90 VA: 0x40D7A90
	public bool get_UseHttps() { }

	[CompilerGenerated]
	// RVA: 0x40D7A98 Offset: 0x40D3A98 VA: 0x40D7A98
	public void set_UseHttps(bool value) { }

	[CompilerGenerated]
	// RVA: 0x40D7AA4 Offset: 0x40D3AA4 VA: 0x40D7AA4
	public string get_CustomLocalConfig() { }

	[CompilerGenerated]
	// RVA: 0x40D7AAC Offset: 0x40D3AAC VA: 0x40D7AAC
	public void set_CustomLocalConfig(string value) { }

	[CompilerGenerated]
	// RVA: 0x40D7AB4 Offset: 0x40D3AB4 VA: 0x40D7AB4
	public string get_OpensdkVer() { }

	[CompilerGenerated]
	// RVA: 0x40D7ABC Offset: 0x40D3ABC VA: 0x40D7ABC
	public void set_OpensdkVer(string value) { }

	[CompilerGenerated]
	// RVA: 0x40D7AC4 Offset: 0x40D3AC4 VA: 0x40D7AC4
	public bool get_WxInstalled() { }

	[CompilerGenerated]
	// RVA: 0x40D7ACC Offset: 0x40D3ACC VA: 0x40D7ACC
	public void set_WxInstalled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x40D7AD8 Offset: 0x40D3AD8 VA: 0x40D7AD8
	public bool get_SupportH265() { }

	[CompilerGenerated]
	// RVA: 0x40D7AE0 Offset: 0x40D3AE0 VA: 0x40D7AE0
	public void set_SupportH265(bool value) { }

	[CompilerGenerated]
	// RVA: 0x40D7AEC Offset: 0x40D3AEC VA: 0x40D7AEC
	public bool get_SupportSplashZoomout() { }

	[CompilerGenerated]
	// RVA: 0x40D7AF4 Offset: 0x40D3AF4 VA: 0x40D7AF4
	public void set_SupportSplashZoomout(bool value) { }

	[CompilerGenerated]
	// RVA: 0x40D7B00 Offset: 0x40D3B00 VA: 0x40D7B00
	public string get_WxAppId() { }

	[CompilerGenerated]
	// RVA: 0x40D7B08 Offset: 0x40D3B08 VA: 0x40D7B08
	public void set_WxAppId(string value) { }

	// RVA: 0x40D7B10 Offset: 0x40D3B10 VA: 0x40D7B10
	public void .ctor() { }
}

// Namespace: ByteDance.Union.Mediation
public class MediationConfigUserInfoForSegment // TypeDefIndex: 27001
{
	// Fields
	[CompilerGenerated]
	private Dictionary<string, string> <CustomInfos>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <UserId>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Channel>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <SubChannel>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Age>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <Gender>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <UserValueGroup>k__BackingField; // 0x40

	// Properties
	public Dictionary<string, string> CustomInfos { get; set; }
	public string UserId { get; set; }
	public string Channel { get; set; }
	public string SubChannel { get; set; }
	public int Age { get; set; }
	public string Gender { get; set; }
	public string UserValueGroup { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x40D7B18 Offset: 0x40D3B18 VA: 0x40D7B18
	public Dictionary<string, string> get_CustomInfos() { }

	[CompilerGenerated]
	// RVA: 0x40D7B20 Offset: 0x40D3B20 VA: 0x40D7B20
	public void set_CustomInfos(Dictionary<string, string> value) { }

	[CompilerGenerated]
	// RVA: 0x40D7B28 Offset: 0x40D3B28 VA: 0x40D7B28
	public string get_UserId() { }

	[CompilerGenerated]
	// RVA: 0x40D7B30 Offset: 0x40D3B30 VA: 0x40D7B30
	public void set_UserId(string value) { }

	[CompilerGenerated]
	// RVA: 0x40D7B38 Offset: 0x40D3B38 VA: 0x40D7B38
	public string get_Channel() { }

	[CompilerGenerated]
	// RVA: 0x40D7B40 Offset: 0x40D3B40 VA: 0x40D7B40
	public void set_Channel(string value) { }

	[CompilerGenerated]
	// RVA: 0x40D7B48 Offset: 0x40D3B48 VA: 0x40D7B48
	public string get_SubChannel() { }

	[CompilerGenerated]
	// RVA: 0x40D7B50 Offset: 0x40D3B50 VA: 0x40D7B50
	public void set_SubChannel(string value) { }

	[CompilerGenerated]
	// RVA: 0x40D7B58 Offset: 0x40D3B58 VA: 0x40D7B58
	public int get_Age() { }

	[CompilerGenerated]
	// RVA: 0x40D7B60 Offset: 0x40D3B60 VA: 0x40D7B60
	public void set_Age(int value) { }

	[CompilerGenerated]
	// RVA: 0x40D7B68 Offset: 0x40D3B68 VA: 0x40D7B68
	public string get_Gender() { }

	[CompilerGenerated]
	// RVA: 0x40D7B70 Offset: 0x40D3B70 VA: 0x40D7B70
	public void set_Gender(string value) { }

	[CompilerGenerated]
	// RVA: 0x40D7B78 Offset: 0x40D3B78 VA: 0x40D7B78
	public string get_UserValueGroup() { }

	[CompilerGenerated]
	// RVA: 0x40D7B80 Offset: 0x40D3B80 VA: 0x40D7B80
	public void set_UserValueGroup(string value) { }

	// RVA: 0x40D7B88 Offset: 0x40D3B88 VA: 0x40D7B88
	public void .ctor() { }
}

// Namespace: ByteDance.Union.Mediation
public class MediationPreloadRequestInfo // TypeDefIndex: 27002
{
	// Fields
	[CompilerGenerated]
	private int <AdType>k__BackingField; // 0x10
	[CompilerGenerated]
	private AdSlot <AdSlot>k__BackingField; // 0x18
	[CompilerGenerated]
	private List<string> <PrimeRitList>k__BackingField; // 0x20

	// Properties
	public int AdType { get; set; }
	public AdSlot AdSlot { get; set; }
	public List<string> PrimeRitList { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x40D7B90 Offset: 0x40D3B90 VA: 0x40D7B90
	public void set_AdType(int value) { }

	[CompilerGenerated]
	// RVA: 0x40D7B98 Offset: 0x40D3B98 VA: 0x40D7B98
	public int get_AdType() { }

	[CompilerGenerated]
	// RVA: 0x40D7BA0 Offset: 0x40D3BA0 VA: 0x40D7BA0
	public void set_AdSlot(AdSlot value) { }

	[CompilerGenerated]
	// RVA: 0x40D7BA8 Offset: 0x40D3BA8 VA: 0x40D7BA8
	public AdSlot get_AdSlot() { }

	[CompilerGenerated]
	// RVA: 0x40D7BB0 Offset: 0x40D3BB0 VA: 0x40D7BB0
	public void set_PrimeRitList(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x40D7BB8 Offset: 0x40D3BB8 VA: 0x40D7BB8
	public List<string> get_PrimeRitList() { }

	// RVA: 0x40D7BC0 Offset: 0x40D3BC0 VA: 0x40D7BC0
	public void .ctor() { }
}

// Namespace: ByteDance.Union.Mediation
public class MediationPrivacyConfig // TypeDefIndex: 27003
{
	// Fields
	[CompilerGenerated]
	private List<string> <CustomAppList>k__BackingField; // 0x10
	[CompilerGenerated]
	private List<string> <CustomDevImeis>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <CanUseOaid>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <LimitPersonalAds>k__BackingField; // 0x21
	[CompilerGenerated]
	private bool <ProgrammaticRecommend>k__BackingField; // 0x22

	// Properties
	public List<string> CustomAppList { get; set; }
	public List<string> CustomDevImeis { get; set; }
	public bool CanUseOaid { get; set; }
	public bool LimitPersonalAds { get; set; }
	public bool ProgrammaticRecommend { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x40D7BC8 Offset: 0x40D3BC8 VA: 0x40D7BC8
	public List<string> get_CustomAppList() { }

	[CompilerGenerated]
	// RVA: 0x40D7BD0 Offset: 0x40D3BD0 VA: 0x40D7BD0
	public void set_CustomAppList(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x40D7BD8 Offset: 0x40D3BD8 VA: 0x40D7BD8
	public List<string> get_CustomDevImeis() { }

	[CompilerGenerated]
	// RVA: 0x40D7BE0 Offset: 0x40D3BE0 VA: 0x40D7BE0
	public void set_CustomDevImeis(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x40D7BE8 Offset: 0x40D3BE8 VA: 0x40D7BE8
	public bool get_CanUseOaid() { }

	[CompilerGenerated]
	// RVA: 0x40D7BF0 Offset: 0x40D3BF0 VA: 0x40D7BF0
	public void set_CanUseOaid(bool value) { }

	[CompilerGenerated]
	// RVA: 0x40D7BFC Offset: 0x40D3BFC VA: 0x40D7BFC
	public bool get_LimitPersonalAds() { }

	[CompilerGenerated]
	// RVA: 0x40D7C04 Offset: 0x40D3C04 VA: 0x40D7C04
	public void set_LimitPersonalAds(bool value) { }

	[CompilerGenerated]
	// RVA: 0x40D7C10 Offset: 0x40D3C10 VA: 0x40D7C10
	public bool get_ProgrammaticRecommend() { }

	[CompilerGenerated]
	// RVA: 0x40D7C18 Offset: 0x40D3C18 VA: 0x40D7C18
	public void set_ProgrammaticRecommend(bool value) { }

	// RVA: 0x40D7C24 Offset: 0x40D3C24 VA: 0x40D7C24
	public void .ctor() { }
}

// Namespace: ByteDance.Union.Mediation
public interface MediationShakeViewListener // TypeDefIndex: 27004
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnDismissed();
}

// Namespace: ByteDance.Union.Mediation
public sealed class MediationSplashRequestInfo // TypeDefIndex: 27005
{
	// Fields
	[CompilerGenerated]
	private string <AdnName>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <AdnSlotId>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <AppId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Appkey>k__BackingField; // 0x28

	// Properties
	public string AdnName { get; set; }
	public string AdnSlotId { get; set; }
	public string AppId { get; set; }
	public string Appkey { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x40D7C38 Offset: 0x40D3C38 VA: 0x40D7C38
	public string get_AdnName() { }

	[CompilerGenerated]
	// RVA: 0x40D7C40 Offset: 0x40D3C40 VA: 0x40D7C40
	public void set_AdnName(string value) { }

	[CompilerGenerated]
	// RVA: 0x40D7C48 Offset: 0x40D3C48 VA: 0x40D7C48
	public string get_AdnSlotId() { }

	[CompilerGenerated]
	// RVA: 0x40D7C50 Offset: 0x40D3C50 VA: 0x40D7C50
	public void set_AdnSlotId(string value) { }

	[CompilerGenerated]
	// RVA: 0x40D7C58 Offset: 0x40D3C58 VA: 0x40D7C58
	public string get_AppId() { }

	[CompilerGenerated]
	// RVA: 0x40D7C60 Offset: 0x40D3C60 VA: 0x40D7C60
	public void set_AppId(string value) { }

	[CompilerGenerated]
	// RVA: 0x40D7C68 Offset: 0x40D3C68 VA: 0x40D7C68
	public string get_Appkey() { }

	[CompilerGenerated]
	// RVA: 0x40D7C70 Offset: 0x40D3C70 VA: 0x40D7C70
	public void set_Appkey(string value) { }

	// RVA: 0x40D7C78 Offset: 0x40D3C78 VA: 0x40D7C78
	public void .ctor() { }
}

// Namespace: 
public class MediationAdSlot.Builder // TypeDefIndex: 27006
{
	// Fields
	private AndroidJavaObject jBuilder; // 0x10

	// Methods

	// RVA: 0x40D7CB8 Offset: 0x40D3CB8 VA: 0x40D7CB8
	public void .ctor() { }

	// RVA: 0x40D7DAC Offset: 0x40D3DAC VA: 0x40D7DAC
	public MediationAdSlot.Builder SetSplashShakeButton(bool splashShakeBtn) { }

	// RVA: 0x40D7ECC Offset: 0x40D3ECC VA: 0x40D7ECC
	public MediationAdSlot.Builder SetAllowShowCloseBtn(bool allowShowCloseBtn) { }

	// RVA: 0x40D7FEC Offset: 0x40D3FEC VA: 0x40D7FEC
	public MediationAdSlot.Builder SetShakeViewSize(float w, float h) { }

	// RVA: 0x40D815C Offset: 0x40D415C VA: 0x40D815C
	public MediationAdSlot.Builder SetWxAppId(string wxAppId) { }

	// RVA: 0x40D8248 Offset: 0x40D4248 VA: 0x40D8248
	public MediationAdSlot.Builder SetMediationSplashRequestInfo(MediationSplashRequestInfo info) { }

	// RVA: 0x40D8474 Offset: 0x40D4474 VA: 0x40D8474
	public MediationAdSlot.Builder SetSplashPreLoad(bool isPreload) { }

	// RVA: 0x40D8594 Offset: 0x40D4594 VA: 0x40D8594
	public MediationAdSlot.Builder SetMuted(bool isMuted) { }

	// RVA: 0x40D86B4 Offset: 0x40D46B4 VA: 0x40D86B4
	public MediationAdSlot.Builder SetVolume(float volume) { }

	// RVA: 0x40D87D8 Offset: 0x40D47D8 VA: 0x40D87D8
	public MediationAdSlot.Builder SetUseSurfaceView(bool isUseSurfaceview) { }

	// RVA: 0x40D88F8 Offset: 0x40D48F8 VA: 0x40D88F8
	public MediationAdSlot.Builder SetBidNotify(bool bidNotify) { }

	// RVA: 0x40D8A18 Offset: 0x40D4A18 VA: 0x40D8A18
	public MediationAdSlot.Builder SetScenarioId(string scenarioId) { }

	// RVA: 0x40D8B04 Offset: 0x40D4B04 VA: 0x40D8B04
	public MediationAdSlot.Builder SetRewardName(string rewardName) { }

	// RVA: 0x40D8BF0 Offset: 0x40D4BF0 VA: 0x40D8BF0
	public MediationAdSlot.Builder SetRewardAmount(int amount) { }

	// RVA: 0x40D8D0C Offset: 0x40D4D0C VA: 0x40D8D0C
	public MediationAdSlot.Builder SetExtraObject(string key, string value) { }

	// RVA: 0x40D92E4 Offset: 0x40D52E4 VA: 0x40D92E4
	public MediationAdSlot Build() { }
}

// Namespace: ByteDance.Union.Mediation
public sealed class MediationAdSlot // TypeDefIndex: 27007
{
	// Fields
	internal AndroidJavaObject jMediationAdSlot; // 0x10

	// Properties
	internal AndroidJavaObject Handle { get; }

	// Methods

	// RVA: 0x40D7C80 Offset: 0x40D3C80 VA: 0x40D7C80
	public void .ctor(AndroidJavaObject slot) { }

	// RVA: 0x40D7CB0 Offset: 0x40D3CB0 VA: 0x40D7CB0
	internal AndroidJavaObject get_Handle() { }
}

// Namespace: ByteDance.Union.Mediation
public sealed class MediationBannerManager : IDisposable // TypeDefIndex: 27008
{
	// Fields
	private AndroidJavaObject handle; // 0x10

	// Methods

	// RVA: 0x40C0340 Offset: 0x40BC340 VA: 0x40C0340
	internal void .ctor(AndroidJavaObject javaObject) { }

	// RVA: 0x40D9570 Offset: 0x40D5570 VA: 0x40D9570 Slot: 4
	public void Dispose() { }

	// RVA: 0x40D9574 Offset: 0x40D5574 VA: 0x40D9574
	public bool IsReady() { }

	// RVA: 0x40D9650 Offset: 0x40D5650 VA: 0x40D9650
	public List<MediationAdLoadInfo> GetAdLoadInfo() { }

	// RVA: 0x40D9660 Offset: 0x40D5660 VA: 0x40D9660
	public MediationAdEcpmInfo GetBestEcpm() { }

	// RVA: 0x40D9670 Offset: 0x40D5670 VA: 0x40D9670
	public List<MediationAdEcpmInfo> GetMultiBiddingEcpm() { }

	// RVA: 0x40D9680 Offset: 0x40D5680 VA: 0x40D9680
	public MediationAdEcpmInfo GetShowEcpm() { }

	// RVA: 0x40D9690 Offset: 0x40D5690 VA: 0x40D9690
	public List<MediationAdEcpmInfo> GetCacheList() { }

	// RVA: 0x40D96A0 Offset: 0x40D56A0 VA: 0x40D96A0
	public void destroy() { }
}

// Namespace: ByteDance.Union.Mediation
public sealed class MediationFullScreenManager : IDisposable // TypeDefIndex: 27009
{
	// Fields
	private AndroidJavaObject handle; // 0x10

	// Methods

	// RVA: 0x40C24D4 Offset: 0x40BE4D4 VA: 0x40C24D4
	internal void .ctor(AndroidJavaObject javaObject) { }

	// RVA: 0x40D96A4 Offset: 0x40D56A4 VA: 0x40D96A4 Slot: 4
	public void Dispose() { }

	// RVA: 0x40D96A8 Offset: 0x40D56A8 VA: 0x40D96A8
	public bool IsReady() { }

	// RVA: 0x40D9784 Offset: 0x40D5784 VA: 0x40D9784
	public List<MediationAdLoadInfo> GetAdLoadInfo() { }

	// RVA: 0x40D9794 Offset: 0x40D5794 VA: 0x40D9794
	public MediationAdEcpmInfo GetBestEcpm() { }

	// RVA: 0x40D97A4 Offset: 0x40D57A4 VA: 0x40D97A4
	public List<MediationAdEcpmInfo> GetMultiBiddingEcpm() { }

	// RVA: 0x40D97B4 Offset: 0x40D57B4 VA: 0x40D97B4
	public MediationAdEcpmInfo GetShowEcpm() { }

	// RVA: 0x40D97C4 Offset: 0x40D57C4 VA: 0x40D97C4
	public List<MediationAdEcpmInfo> GetCacheList() { }

	// RVA: 0x40D97D4 Offset: 0x40D57D4 VA: 0x40D97D4
	public void Destroy() { }
}

// Namespace: 
private sealed class MediationNativeManager.InnerShakeViewListener : AndroidJavaProxy // TypeDefIndex: 27010
{
	// Fields
	private MediationShakeViewListener listener; // 0x20

	// Methods

	// RVA: 0x40D9CB0 Offset: 0x40D5CB0 VA: 0x40D9CB0
	public void .ctor(MediationShakeViewListener listener) { }

	// RVA: 0x40D9E18 Offset: 0x40D5E18 VA: 0x40D9E18
	public void onDismissed() { }
}

// Namespace: ByteDance.Union.Mediation
public sealed class MediationNativeManager : IDisposable // TypeDefIndex: 27011
{
	// Fields
	private AndroidJavaObject handle; // 0x10

	// Methods

	// RVA: 0x40BF130 Offset: 0x40BB130 VA: 0x40BF130
	internal void .ctor(AndroidJavaObject javaObject) { }

	// RVA: 0x40D9898 Offset: 0x40D5898 VA: 0x40D9898 Slot: 4
	public void Dispose() { }

	// RVA: 0x40D989C Offset: 0x40D589C VA: 0x40D989C
	public bool IsReady() { }

	// RVA: 0x40D9978 Offset: 0x40D5978 VA: 0x40D9978
	public List<MediationAdLoadInfo> GetAdLoadInfo() { }

	// RVA: 0x40D9988 Offset: 0x40D5988 VA: 0x40D9988
	public MediationAdEcpmInfo GetBestEcpm() { }

	// RVA: 0x40D9998 Offset: 0x40D5998 VA: 0x40D9998
	public List<MediationAdEcpmInfo> GetMultiBiddingEcpm() { }

	// RVA: 0x40D99A8 Offset: 0x40D59A8 VA: 0x40D99A8
	public MediationAdEcpmInfo GetShowEcpm() { }

	// RVA: 0x40D99B8 Offset: 0x40D59B8 VA: 0x40D99B8
	public List<MediationAdEcpmInfo> GetCacheList() { }

	// RVA: 0x40D99C8 Offset: 0x40D59C8 VA: 0x40D99C8
	public bool HasDislike() { }

	// RVA: 0x40D9AA4 Offset: 0x40D5AA4 VA: 0x40D9AA4
	public void SetUseCustomVideo(bool isUseCustomVideo) { }

	// RVA: 0x40D9BA4 Offset: 0x40D5BA4 VA: 0x40D9BA4
	public void SetShakeViewListener(MediationShakeViewListener listener) { }

	// RVA: 0x40D9D3C Offset: 0x40D5D3C VA: 0x40D9D3C
	public bool IsExpress() { }
}

// Namespace: ByteDance.Union.Mediation
public sealed class MediationRewardManager : IDisposable // TypeDefIndex: 27012
{
	// Fields
	private AndroidJavaObject handle; // 0x10

	// Methods

	// RVA: 0x40C4A80 Offset: 0x40C0A80 VA: 0x40C4A80
	internal void .ctor(AndroidJavaObject javaObject) { }

	// RVA: 0x40D9EC0 Offset: 0x40D5EC0 VA: 0x40D9EC0 Slot: 4
	public void Dispose() { }

	// RVA: 0x40D9EC4 Offset: 0x40D5EC4 VA: 0x40D9EC4
	public bool IsReady() { }

	// RVA: 0x40D9FA0 Offset: 0x40D5FA0 VA: 0x40D9FA0
	public List<MediationAdLoadInfo> GetAdLoadInfo() { }

	// RVA: 0x40D9FB0 Offset: 0x40D5FB0 VA: 0x40D9FB0
	public MediationAdEcpmInfo GetBestEcpm() { }

	// RVA: 0x40D9FC0 Offset: 0x40D5FC0 VA: 0x40D9FC0
	public List<MediationAdEcpmInfo> GetMultiBiddingEcpm() { }

	// RVA: 0x40D9FD0 Offset: 0x40D5FD0 VA: 0x40D9FD0
	public MediationAdEcpmInfo GetShowEcpm() { }

	// RVA: 0x40D9FE0 Offset: 0x40D5FE0 VA: 0x40D9FE0
	public List<MediationAdEcpmInfo> GetCacheList() { }

	// RVA: 0x40D9FF0 Offset: 0x40D5FF0 VA: 0x40D9FF0
	public void Destroy() { }
}

// Namespace: ByteDance.Union.Mediation
public sealed class MediationSplashManager : IDisposable // TypeDefIndex: 27013
{
	// Fields
	private AndroidJavaObject handle; // 0x10

	// Methods

	// RVA: 0x40BDC4C Offset: 0x40B9C4C VA: 0x40BDC4C
	internal void .ctor(AndroidJavaObject javaObject) { }

	// RVA: 0x40DA0B4 Offset: 0x40D60B4 VA: 0x40DA0B4 Slot: 4
	public void Dispose() { }

	// RVA: 0x40DA0B8 Offset: 0x40D60B8 VA: 0x40DA0B8
	public bool IsReady() { }

	// RVA: 0x40DA194 Offset: 0x40D6194 VA: 0x40DA194
	public List<MediationAdLoadInfo> GetAdLoadInfo() { }

	// RVA: 0x40DA1A4 Offset: 0x40D61A4 VA: 0x40DA1A4
	public MediationAdEcpmInfo GetBestEcpm() { }

	// RVA: 0x40DA1B4 Offset: 0x40D61B4 VA: 0x40DA1B4
	public List<MediationAdEcpmInfo> GetMultiBiddingEcpm() { }

	// RVA: 0x40DA1C4 Offset: 0x40D61C4 VA: 0x40DA1C4
	public MediationAdEcpmInfo GetShowEcpm() { }

	// RVA: 0x40DA1D4 Offset: 0x40D61D4 VA: 0x40DA1D4
	public List<MediationAdEcpmInfo> GetCacheList() { }

	// RVA: 0x40DA1E4 Offset: 0x40D61E4 VA: 0x40DA1E4
	public void Destroy() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3898 // TypeDefIndex: 27014
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4232 // TypeDefIndex: 27015
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 27016
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3898 1817AF67F0A59596D0BFECF23A7B4AFA6E84E82DD418B6580B456E9234C5307D /*Metadata offset 0xF4A6B8*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4232 967944C16073B63CA7165467F911E63EA35D0153A88FAAFAA723E518B537DC1F /*Metadata offset 0xF4B5F8*/; // 0xF3A
}

