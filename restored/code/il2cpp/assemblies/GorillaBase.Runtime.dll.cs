// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 25914
{}

// Namespace: 
[IsReadOnly]
private struct GorillaAbility.LifecycleParticipant<T> // TypeDefIndex: 25915
{
	// Fields
	[CompilerGenerated]
	private readonly string <Id>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly T <Participant>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly int <Order>k__BackingField; // 0x0

	// Properties
	public string Id { get; }
	public T Participant { get; }
	public int Order { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public string get_Id() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B149D0 Offset: 0x4B109D0 VA: 0x4B149D0
	|-GorillaAbility.LifecycleParticipant<object>.get_Id
	|
	|-RVA: 0x4B14A24 Offset: 0x4B10A24 VA: 0x4B14A24
	|-GorillaAbility.LifecycleParticipant<__Il2CppFullySharedGenericType>.get_Id
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public T get_Participant() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B149D8 Offset: 0x4B109D8 VA: 0x4B149D8
	|-GorillaAbility.LifecycleParticipant<object>.get_Participant
	|
	|-RVA: 0x4B14A64 Offset: 0x4B10A64 VA: 0x4B14A64
	|-GorillaAbility.LifecycleParticipant<__Il2CppFullySharedGenericType>.get_Participant
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_Order() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B149E0 Offset: 0x4B109E0 VA: 0x4B149E0
	|-GorillaAbility.LifecycleParticipant<object>.get_Order
	|
	|-RVA: 0x4B14B54 Offset: 0x4B10B54 VA: 0x4B14B54
	|-GorillaAbility.LifecycleParticipant<__Il2CppFullySharedGenericType>.get_Order
	*/

	// RVA: -1 Offset: -1
	public void .ctor(string id, T participant, int order) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B149E8 Offset: 0x4B109E8 VA: 0x4B149E8
	|-GorillaAbility.LifecycleParticipant<object>..ctor
	|
	|-RVA: 0x4B14B98 Offset: 0x4B10B98 VA: 0x4B14B98
	|-GorillaAbility.LifecycleParticipant<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
private sealed class GorillaAbility.RuntimeSecurityConfig : ISecurityConfig // TypeDefIndex: 25916
{
	// Fields
	[CompilerGenerated]
	private readonly string <RsaPublicKey>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <RsaPrivateKey>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string <AesKey>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly string <AesIv>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly string <RequestSignSecret>k__BackingField; // 0x30

	// Properties
	public string AesKey { get; }
	public string AesIv { get; }
	public string RequestSignSecret { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x64094B4 Offset: 0x64054B4 VA: 0x64094B4 Slot: 4
	public string get_AesKey() { }

	[CompilerGenerated]
	// RVA: 0x64094BC Offset: 0x64054BC VA: 0x64094BC Slot: 5
	public string get_AesIv() { }

	[CompilerGenerated]
	// RVA: 0x64094C4 Offset: 0x64054C4 VA: 0x64094C4 Slot: 6
	public string get_RequestSignSecret() { }

	// RVA: 0x640923C Offset: 0x640523C VA: 0x640923C
	public void .ctor(string aesKey, string aesIv, string requestSignSecret, string rsaPublicKey = "", string rsaPrivateKey = "") { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class GorillaAbility.<>c // TypeDefIndex: 25917
{
	// Fields
	public static readonly GorillaAbility.<>c <>9; // 0x0
	public static Func<IGorillaAbilityInitializer, int> <>9__103_0; // 0x8
	public static Func<IGorillaAbilityLoginObserver, int> <>9__104_0; // 0x10
	public static Func<IGorillaAbilityLogoutObserver, int> <>9__105_0; // 0x18

	// Methods

	// RVA: 0x64094CC Offset: 0x64054CC VA: 0x64094CC
	private static void .cctor() { }

	// RVA: 0x6409534 Offset: 0x6405534 VA: 0x6409534
	public void .ctor() { }

	// RVA: 0x640953C Offset: 0x640553C VA: 0x640953C
	internal int <InitializeRegisteredAbilities>b__103_0(IGorillaAbilityInitializer participant) { }

	// RVA: 0x64095D8 Offset: 0x64055D8 VA: 0x64095D8
	internal int <NotifyLoginSucceeded>b__104_0(IGorillaAbilityLoginObserver participant) { }

	// RVA: 0x6409674 Offset: 0x6405674 VA: 0x6409674
	internal int <NotifyLogout>b__105_0(IGorillaAbilityLogoutObserver participant) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class GorillaAbility.<>c__107<T> // TypeDefIndex: 25918
{
	// Fields
	public static readonly GorillaAbility.<>c__107<T> <>9; // 0x0
	public static Comparison<GorillaAbility.LifecycleParticipant<T>> <>9__107_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4858928 Offset: 0x4854928 VA: 0x4858928
	|-GorillaAbility.<>c__107<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48589E4 Offset: 0x48549E4 VA: 0x48589E4
	|-GorillaAbility.<>c__107<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int <GetOrderedLifecycleParticipants>b__107_0(GorillaAbility.LifecycleParticipant<T> left, GorillaAbility.LifecycleParticipant<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48589EC Offset: 0x48549EC VA: 0x48589EC
	|-GorillaAbility.<>c__107<object>.<GetOrderedLifecycleParticipants>b__107_0
	*/
}

// Namespace: GorillaBase.Runtime
public static class GorillaAbility // TypeDefIndex: 25919
{
	// Fields
	private const string Tag = "[GorillaAbility]";
	private static readonly Dictionary<string, object> LifecycleParticipants; // 0x0
	[CompilerGenerated]
	private static SDKConfig <Config>k__BackingField; // 0x8
	[CompilerGenerated]
	private static INetworkService <AccountNetwork>k__BackingField; // 0x10
	[CompilerGenerated]
	private static INetworkService <PurchaseNetwork>k__BackingField; // 0x18
	private static ISystemInfoAbility _systemInfo; // 0x20
	private static IUILoadAbility _uiLoadAbility; // 0x28
	[CompilerGenerated]
	private static readonly ISystemUIAbility <SystemUIAbility>k__BackingField; // 0x30
	private static IAccountService _accountService; // 0x38
	private static bool _isAccountServiceManuallySet; // 0x40
	private static ShareService _shareService; // 0x48
	private static IPurchaseEligibilityService _purchaseEligibilityService; // 0x50
	private static bool _isPurchaseEligibilityServiceManuallySet; // 0x58
	private static IGameTrack _gameTrack; // 0x60
	private static IDataNexus _dataNexus; // 0x68
	private static IAdjustAnalytics _adjust; // 0x70
	private static IAppsFlyerAnalytics _appsFlyer; // 0x78
	private static IJuLiangAnalytics _juLiang; // 0x80
	private static ISolarEngineAnalytics _solarEngine; // 0x88
	private static IGravityEngineAnalytics _gravityEngine; // 0x90
	private static ISecurityConfig _securityConfig; // 0x98
	private static IFirebase _firebase; // 0xA0
	[CompilerGenerated]
	private static ICrashReporter <CrashReporter>k__BackingField; // 0xA8
	private static PushService _pushService; // 0xB0
	[CompilerGenerated]
	private static IFacebook <Facebook>k__BackingField; // 0xB8
	[CompilerGenerated]
	private static ILocalNotification <LocalNotification>k__BackingField; // 0xC0
	[CompilerGenerated]
	private static readonly IReviewService <ReviewService>k__BackingField; // 0xC8
	private static IAppDownloadService _appDownloadService; // 0xD0
	private static IReviewGuideService _reviewGuideService; // 0xD8

	// Properties
	public static SDKConfig Config { get; set; }
	public static INetworkService AccountNetwork { get; set; }
	public static INetworkService PurchaseNetwork { get; set; }
	public static ISystemInfoAbility SystemInfo { get; set; }
	public static IUILoadAbility UILoadAbility { get; set; }
	public static ISystemUIAbility SystemUIAbility { get; }
	public static IAccountService AccountService { get; set; }
	public static ShareService ShareService { get; }
	public static IPurchaseEligibilityService PurchaseEligibilityService { get; set; }
	public static IGameTrack GameTrack { get; set; }
	public static IDataNexus DataNexus { get; set; }
	public static IAdjustAnalytics Adjust { get; set; }
	public static IAppsFlyerAnalytics AppsFlyer { get; set; }
	public static IJuLiangAnalytics JuLiang { get; set; }
	public static ISolarEngineAnalytics SolarEngine { get; set; }
	public static IGravityEngineAnalytics GravityEngine { get; set; }
	public static ISecurityConfig SecurityConfig { get; set; }
	public static IFirebase Firebase { get; set; }
	public static ICrashReporter CrashReporter { get; set; }
	public static PushService PushService { get; }
	public static IFacebook Facebook { get; set; }
	public static ILocalNotification LocalNotification { get; set; }
	public static IReviewService ReviewService { get; }
	public static IAppDownloadService AppDownloadService { get; set; }
	public static IReviewGuideService ReviewGuideService { get; set; }

	// Methods

	// RVA: 0x640607C Offset: 0x640207C VA: 0x640607C
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x64062F8 Offset: 0x64022F8 VA: 0x64062F8
	public static SDKConfig get_Config() { }

	[CompilerGenerated]
	// RVA: 0x6406350 Offset: 0x6402350 VA: 0x6406350
	private static void set_Config(SDKConfig value) { }

	[CompilerGenerated]
	// RVA: 0x64063B0 Offset: 0x64023B0 VA: 0x64063B0
	public static INetworkService get_AccountNetwork() { }

	[CompilerGenerated]
	// RVA: 0x6406408 Offset: 0x6402408 VA: 0x6406408
	private static void set_AccountNetwork(INetworkService value) { }

	[CompilerGenerated]
	// RVA: 0x6406468 Offset: 0x6402468 VA: 0x6406468
	public static INetworkService get_PurchaseNetwork() { }

	[CompilerGenerated]
	// RVA: 0x64064C0 Offset: 0x64024C0 VA: 0x64064C0
	private static void set_PurchaseNetwork(INetworkService value) { }

	// RVA: 0x6406520 Offset: 0x6402520 VA: 0x6406520
	public static ISystemInfoAbility get_SystemInfo() { }

	// RVA: 0x6406730 Offset: 0x6402730 VA: 0x6406730
	public static void set_SystemInfo(ISystemInfoAbility value) { }

	// RVA: 0x6406790 Offset: 0x6402790 VA: 0x6406790
	public static IUILoadAbility get_UILoadAbility() { }

	// RVA: 0x64068C0 Offset: 0x64028C0 VA: 0x64068C0
	public static void set_UILoadAbility(IUILoadAbility value) { }

	[CompilerGenerated]
	// RVA: 0x6406920 Offset: 0x6402920 VA: 0x6406920
	public static ISystemUIAbility get_SystemUIAbility() { }

	// RVA: 0x6406978 Offset: 0x6402978 VA: 0x6406978
	public static IAccountService get_AccountService() { }

	// RVA: 0x6406B20 Offset: 0x6402B20 VA: 0x6406B20
	public static void set_AccountService(IAccountService value) { }

	// RVA: 0x6406B98 Offset: 0x6402B98 VA: 0x6406B98
	public static ShareService get_ShareService() { }

	// RVA: 0x6406C4C Offset: 0x6402C4C VA: 0x6406C4C
	public static IPurchaseEligibilityService get_PurchaseEligibilityService() { }

	// RVA: 0x6406D00 Offset: 0x6402D00 VA: 0x6406D00
	public static void set_PurchaseEligibilityService(IPurchaseEligibilityService value) { }

	// RVA: 0x6406D78 Offset: 0x6402D78 VA: 0x6406D78
	public static bool TrySetDefaultPurchaseEligibilityService(IPurchaseEligibilityService service) { }

	// RVA: 0x6406E0C Offset: 0x6402E0C VA: 0x6406E0C
	public static IGameTrack get_GameTrack() { }

	// RVA: 0x6406EC0 Offset: 0x6402EC0 VA: 0x6406EC0
	public static void set_GameTrack(IGameTrack value) { }

	// RVA: 0x6406F20 Offset: 0x6402F20 VA: 0x6406F20
	public static IDataNexus get_DataNexus() { }

	// RVA: 0x6406FD4 Offset: 0x6402FD4 VA: 0x6406FD4
	public static void set_DataNexus(IDataNexus value) { }

	// RVA: 0x6407034 Offset: 0x6403034 VA: 0x6407034
	public static IAdjustAnalytics get_Adjust() { }

	// RVA: 0x64070E8 Offset: 0x64030E8 VA: 0x64070E8
	public static void set_Adjust(IAdjustAnalytics value) { }

	// RVA: 0x6407148 Offset: 0x6403148 VA: 0x6407148
	public static IAppsFlyerAnalytics get_AppsFlyer() { }

	// RVA: 0x64071FC Offset: 0x64031FC VA: 0x64071FC
	public static void set_AppsFlyer(IAppsFlyerAnalytics value) { }

	// RVA: 0x640725C Offset: 0x640325C VA: 0x640725C
	public static IJuLiangAnalytics get_JuLiang() { }

	// RVA: 0x6407310 Offset: 0x6403310 VA: 0x6407310
	public static void set_JuLiang(IJuLiangAnalytics value) { }

	// RVA: 0x6407370 Offset: 0x6403370 VA: 0x6407370
	public static ISolarEngineAnalytics get_SolarEngine() { }

	// RVA: 0x6407424 Offset: 0x6403424 VA: 0x6407424
	public static void set_SolarEngine(ISolarEngineAnalytics value) { }

	// RVA: 0x6407484 Offset: 0x6403484 VA: 0x6407484
	public static IGravityEngineAnalytics get_GravityEngine() { }

	// RVA: 0x6407538 Offset: 0x6403538 VA: 0x6407538
	public static void set_GravityEngine(IGravityEngineAnalytics value) { }

	// RVA: 0x6407598 Offset: 0x6403598 VA: 0x6407598
	public static ISecurityConfig get_SecurityConfig() { }

	// RVA: 0x640764C Offset: 0x640364C VA: 0x640764C
	public static void set_SecurityConfig(ISecurityConfig value) { }

	// RVA: 0x64076AC Offset: 0x64036AC VA: 0x64076AC
	public static IFirebase get_Firebase() { }

	// RVA: 0x6407760 Offset: 0x6403760 VA: 0x6407760
	public static void set_Firebase(IFirebase value) { }

	[CompilerGenerated]
	// RVA: 0x64077C0 Offset: 0x64037C0 VA: 0x64077C0
	public static ICrashReporter get_CrashReporter() { }

	[CompilerGenerated]
	// RVA: 0x6407818 Offset: 0x6403818 VA: 0x6407818
	public static void set_CrashReporter(ICrashReporter value) { }

	// RVA: 0x6407878 Offset: 0x6403878 VA: 0x6407878
	public static PushService get_PushService() { }

	[CompilerGenerated]
	// RVA: 0x64079A8 Offset: 0x64039A8 VA: 0x64079A8
	public static IFacebook get_Facebook() { }

	[CompilerGenerated]
	// RVA: 0x6407A00 Offset: 0x6403A00 VA: 0x6407A00
	public static void set_Facebook(IFacebook value) { }

	[CompilerGenerated]
	// RVA: 0x6407A60 Offset: 0x6403A60 VA: 0x6407A60
	public static ILocalNotification get_LocalNotification() { }

	[CompilerGenerated]
	// RVA: 0x6407AB8 Offset: 0x6403AB8 VA: 0x6407AB8
	public static void set_LocalNotification(ILocalNotification value) { }

	[CompilerGenerated]
	// RVA: 0x6407B18 Offset: 0x6403B18 VA: 0x6407B18
	public static IReviewService get_ReviewService() { }

	// RVA: 0x6407B70 Offset: 0x6403B70 VA: 0x6407B70
	public static IAppDownloadService get_AppDownloadService() { }

	// RVA: 0x6407C24 Offset: 0x6403C24 VA: 0x6407C24
	public static void set_AppDownloadService(IAppDownloadService value) { }

	// RVA: 0x6407C84 Offset: 0x6403C84 VA: 0x6407C84
	public static IReviewGuideService get_ReviewGuideService() { }

	// RVA: 0x6407D38 Offset: 0x6403D38 VA: 0x6407D38
	public static void set_ReviewGuideService(IReviewGuideService value) { }

	// RVA: 0x6407D98 Offset: 0x6403D98 VA: 0x6407D98
	public static void RegisterLifecycle(string id, object participant) { }

	// RVA: 0x64080B4 Offset: 0x64040B4 VA: 0x64080B4
	public static void InitializeRegisteredAbilities(SDKConfig config) { }

	// RVA: 0x6408614 Offset: 0x6404614 VA: 0x6408614
	public static void NotifyLoginSucceeded(LoginResult result) { }

	// RVA: 0x64089D0 Offset: 0x64049D0 VA: 0x64089D0
	public static void NotifyLogout() { }

	// RVA: 0x6408D74 Offset: 0x6404D74 VA: 0x6408D74
	public static void Init(SDKConfig config) { }

	// RVA: -1 Offset: -1
	private static List<GorillaAbility.LifecycleParticipant<T>> GetOrderedLifecycleParticipants<T>(Func<T, int> getOrder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4631BF4 Offset: 0x462DBF4 VA: 0x4631BF4
	|-GorillaAbility.GetOrderedLifecycleParticipants<object>
	*/

	// RVA: 0x6408460 Offset: 0x6404460 VA: 0x6408460
	private static void LogLifecycleException(string phase, string id, Exception exception) { }

	[RuntimeInitializeOnLoadMethod(4)]
	// RVA: 0x640943C Offset: 0x640543C VA: 0x640943C
	private static void ResetLifecycleRegistry() { }
}

// Namespace: GorillaBase.Runtime
public enum GorillaAccountProvider // TypeDefIndex: 25920
{
	// Fields
	public int value__; // 0x0
	public const GorillaAccountProvider Default = 0;
	public const GorillaAccountProvider Overseas = 100;
	public const GorillaAccountProvider OverseasExplicit = 110;
	public const GorillaAccountProvider China = 200;
	public const GorillaAccountProvider ChinaAudit = 210;
	public const GorillaAccountProvider MiniGame = 300;
}

// Namespace: GorillaBase.Runtime
[Extension]
public static class GorillaAccountProviderIds // TypeDefIndex: 25921
{
	// Methods

	[Extension]
	// RVA: 0x6409710 Offset: 0x6405710 VA: 0x6409710
	public static string ToProviderId(GorillaAccountProvider provider) { }

	[Extension]
	// RVA: 0x64097FC Offset: 0x64057FC VA: 0x64097FC
	public static int GetPriority(GorillaAccountProvider provider) { }
}

// Namespace: GorillaBase.Runtime
[Preserve]
internal static class LocalizedTextRegister // TypeDefIndex: 25922
{
	// Fields
	private static bool _isInitialized; // 0x0

	// Methods

	[Preserve]
	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x6409800 Offset: 0x6405800 VA: 0x6409800
	private static void Init() { }

	// RVA: 0x640AC80 Offset: 0x6406C80 VA: 0x640AC80
	private static void RegisterPrivacyText(string key, string[] values) { }
}

// Namespace: GorillaBase.Runtime
[Preserve]
[Serializable]
public class LocalizedText // TypeDefIndex: 25923
{
	// Fields
	private static readonly Dictionary<string, Dictionary<string, string>> LocalizationTable; // 0x0
	private static string _languageCodeOverride; // 0x8
	private static Nullable<SystemLanguage> _languageOverride; // 0x10
	[Preserve]
	public string key; // 0x10

	// Methods

	// RVA: 0x640AF3C Offset: 0x6406F3C VA: 0x640AF3C
	public void .ctor() { }

	// RVA: 0x640AF44 Offset: 0x6406F44 VA: 0x640AF44
	public void .ctor(string key) { }

	// RVA: 0x640AF74 Offset: 0x6406F74 VA: 0x640AF74
	public string Resolve(string languageCode) { }

	// RVA: 0x640B338 Offset: 0x6407338 VA: 0x640B338
	public string ResolveFormat(object[] args) { }

	// RVA: 0x640B344 Offset: 0x6407344 VA: 0x640B344
	public string ResolveFormatWithLanguage(string languageCode, object[] args) { }

	// RVA: 0x640A6B8 Offset: 0x64066B8 VA: 0x640A6B8
	public static void Register(string key, IDictionary<string, string> translations) { }

	// RVA: 0x640B14C Offset: 0x640714C VA: 0x640B14C
	private static List<string> BuildLanguageCandidates(string languageCode) { }

	// RVA: 0x640B640 Offset: 0x6407640 VA: 0x640B640
	private static void AddLanguageCandidates(ICollection<string> candidates, string languageCode) { }

	// RVA: 0x640BB58 Offset: 0x6407B58 VA: 0x640BB58
	private static void AddCandidateChain(ICollection<string> candidates, string languageCode) { }

	// RVA: 0x640B5A8 Offset: 0x64075A8 VA: 0x640B5A8
	private static string NormalizeLanguageCode(string languageCode) { }

	// RVA: 0x640B8A0 Offset: 0x64078A0 VA: 0x640B8A0
	private static string[] GetLanguageAliases(string languageCode) { }

	// RVA: 0x640B734 Offset: 0x6407734 VA: 0x640B734
	private static string ToLanguageCode(SystemLanguage language) { }

	// RVA: 0x640BD64 Offset: 0x6407D64 VA: 0x640BD64
	private static void .cctor() { }
}

// Namespace: GorillaBase.Runtime
public static class GameLoginVerificationFactory // TypeDefIndex: 25924
{
	// Methods

	// RVA: 0x640BE60 Offset: 0x6407E60 VA: 0x640BE60
	public static string CreateDevice(string gameId, string deviceId) { }

	// RVA: 0x640C330 Offset: 0x6408330 VA: 0x640C330
	public static string CreateGameCenter(GameCenterLoginResult result, string deviceId) { }

	// RVA: 0x640C564 Offset: 0x6408564 VA: 0x640C564
	public static string CreatePlayGame(PlayGameLoginResult result, string deviceId) { }

	// RVA: 0x640C664 Offset: 0x6408664 VA: 0x640C664
	public static string CreatePhoneCaptcha(string code, string deviceId) { }

	// RVA: 0x640C7A0 Offset: 0x64087A0 VA: 0x640C7A0
	public static string CreatePhoneAutoLogin(string accessToken, string deviceId, string provider = "shanyan") { }

	// RVA: 0x640C958 Offset: 0x6408958 VA: 0x640C958
	public static string CreateAppleID(AppleIDLoginResult result, string deviceId) { }

	// RVA: 0x640CB44 Offset: 0x6408B44 VA: 0x640CB44
	public static string CreateWeChat(WeChatLoginResult result, string deviceId) { }

	// RVA: 0x640CBD0 Offset: 0x6408BD0 VA: 0x640CBD0
	public static string CreateQQ(QQLoginResult result, string deviceId) { }

	// RVA: 0x640CCB4 Offset: 0x6408CB4 VA: 0x640CCB4
	public static string CreateFacebook(string userId, string deviceId, string fbAppId, string accessToken, string nonce, bool isLimitedLogin) { }

	// RVA: 0x640BF0C Offset: 0x6407F0C VA: 0x640BF0C
	private static Dictionary<string, object> CreateBasePayload(string deviceId, string gameId) { }

	// RVA: 0x640C190 Offset: 0x6408190 VA: 0x640C190
	private static string Encrypt(IDictionary<string, object> payload) { }
}

// Namespace: GorillaBase.Runtime
[Preserve]
[Serializable]
public class SDKConfig // TypeDefIndex: 25925
{
	// Fields
	[Preserve]
	[Tooltip("游戏在 Gorilla Center 中的唯一标识")]
	public string gameId; // 0x10
	[Tooltip("Gorilla Center API 服务器连接地址，参见 GorillaCenterAPI 预置常量")]
	[Preserve]
	public string baseUrl; // 0x18
	[Tooltip("客户端 AES 加密密钥，为空时将使用默认密钥")]
	[Preserve]
	public string aesKey; // 0x20
	[Tooltip("客户端 AES 加密向量，为空时将使用默认向量")]
	[Preserve]
	public string aesIv; // 0x28
	[Preserve]
	[Tooltip("请求 Header 签名密钥，为空时不启用协议签名")]
	public string requestSignSecret; // 0x30
	[Tooltip("账号服务 Provider Id。null 或空字符串表示按已导入模块自动选择。")]
	[Preserve]
	public string accountProviderId; // 0x38

	// Methods

	// RVA: 0x640D2E0 Offset: 0x64092E0 VA: 0x640D2E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x640D534 Offset: 0x6409534 VA: 0x640D534
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime
public interface IShareProvider // TypeDefIndex: 25926
{}

// Namespace: GorillaBase.Runtime
[Preserve]
internal class WhatsAppShareProviders : IShareProvider // TypeDefIndex: 25927
{
	// Methods

	[Preserve]
	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x640D53C Offset: 0x640953C VA: 0x640D53C
	private static void Install() { }

	// RVA: 0x640D5B4 Offset: 0x64095B4 VA: 0x640D5B4
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class XShareProviders.<>c // TypeDefIndex: 25928
{
	// Fields
	public static readonly XShareProviders.<>c <>9; // 0x0

	// Methods

	// RVA: 0x640D720 Offset: 0x6409720 VA: 0x640D720
	private static void .cctor() { }

	// RVA: 0x640D788 Offset: 0x6409788 VA: 0x640D788
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime
[Preserve]
internal class XShareProviders : IShareProvider // TypeDefIndex: 25929
{
	// Methods

	[Preserve]
	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x640D6A0 Offset: 0x64096A0 VA: 0x640D6A0
	private static void Install() { }

	// RVA: 0x640D718 Offset: 0x6409718 VA: 0x640D718
	public void .ctor() { }
}

// Namespace: 
[Preserve]
[Serializable]
public enum WeChatSharePayload.ShareScene // TypeDefIndex: 25930
{
	// Fields
	public int value__; // 0x0
	public const WeChatSharePayload.ShareScene Session = 0;
	public const WeChatSharePayload.ShareScene Timeline = 1;
}

// Namespace: 
[Preserve]
[Serializable]
public enum WeChatSharePayload.ShareType // TypeDefIndex: 25931
{
	// Fields
	public int value__; // 0x0
	public const WeChatSharePayload.ShareType Image = 1;
	public const WeChatSharePayload.ShareType WebPage = 2;
	public const WeChatSharePayload.ShareType Text = 3;
}

// Namespace: GorillaBase.Runtime
[Preserve]
[Serializable]
public class WeChatSharePayload // TypeDefIndex: 25932
{
	// Fields
	[Preserve]
	public WeChatSharePayload.ShareScene scene; // 0x10
	[Preserve]
	public WeChatSharePayload.ShareType shareType; // 0x14
	[Preserve]
	public string thumbImage; // 0x18
	[Preserve]
	public string title; // 0x20
	[Preserve]
	public string description; // 0x28
	[Preserve]
	public string webpageUrl; // 0x30
	[Preserve]
	public string image; // 0x38
	[Preserve]
	public string text; // 0x40

	// Methods

	// RVA: 0x640D790 Offset: 0x6409790 VA: 0x640D790
	public void .ctor() { }
}

// Namespace: 
[Preserve]
[Serializable]
public enum QQSharePayload.ShareType // TypeDefIndex: 25933
{
	// Fields
	public int value__; // 0x0
	public const QQSharePayload.ShareType Image = 1;
	public const QQSharePayload.ShareType ImageText = 2;
	public const QQSharePayload.ShareType QZoneImageText = 3;
	public const QQSharePayload.ShareType QZonePublish = 4;
}

// Namespace: 
[Preserve]
[Serializable]
public enum QQSharePayload.PublishType // TypeDefIndex: 25934
{
	// Fields
	public int value__; // 0x0
	public const QQSharePayload.PublishType QZoneMood = 3;
	public const QQSharePayload.PublishType QZoneVideo = 4;
}

// Namespace: GorillaBase.Runtime
[Preserve]
[Serializable]
public class QQSharePayload // TypeDefIndex: 25935
{
	// Fields
	[Preserve]
	public QQSharePayload.ShareType shareType; // 0x10
	[Preserve]
	public string title; // 0x18
	[Preserve]
	public string summary; // 0x20
	[Preserve]
	public string targetUrl; // 0x28
	[Preserve]
	public string imageUrl; // 0x30
	[Preserve]
	public QQSharePayload.PublishType publishType; // 0x38
	[Preserve]
	public string videoPath; // 0x40

	// Methods

	// RVA: 0x640D798 Offset: 0x6409798 VA: 0x640D798
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime
[Preserve]
[Serializable]
public class WeiboSharePayload // TypeDefIndex: 25936
{
	// Fields
	[Preserve]
	public string text; // 0x10
	[Preserve]
	public string image; // 0x18
	[Preserve]
	public string superGroup; // 0x20
	[Preserve]
	public string supergroupSection; // 0x28

	// Methods

	// RVA: 0x640D7A0 Offset: 0x64097A0 VA: 0x640D7A0
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime
[Preserve]
[Serializable]
public class FacebookLinkSharePayload // TypeDefIndex: 25937
{
	// Fields
	[Preserve]
	public string title; // 0x10
	[Preserve]
	public string description; // 0x18
	[Preserve]
	public string contentUrl; // 0x20
	[Preserve]
	public string photoUrl; // 0x28

	// Methods

	// RVA: 0x640D7A8 Offset: 0x64097A8 VA: 0x640D7A8
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime
[Preserve]
[Serializable]
public class FacebookFeedSharePayload // TypeDefIndex: 25938
{
	// Fields
	[Preserve]
	public string toId; // 0x10
	[Preserve]
	public string link; // 0x18
	[Preserve]
	public string title; // 0x20
	[Preserve]
	public string caption; // 0x28
	[Preserve]
	public string description; // 0x30
	[Preserve]
	public string picture; // 0x38
	[Preserve]
	public string mediaSource; // 0x40

	// Methods

	// RVA: 0x640D7B0 Offset: 0x64097B0 VA: 0x640D7B0
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime
[Preserve]
[Serializable]
public class XSharePayload // TypeDefIndex: 25939
{
	// Fields
	[Preserve]
	public string url; // 0x10
	[Preserve]
	public string text; // 0x18
	[Preserve]
	public List<string> hashTags; // 0x20

	// Methods

	// RVA: 0x640D828 Offset: 0x6409828 VA: 0x640D828
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime
[Preserve]
[Serializable]
public class SystemSharePayload // TypeDefIndex: 25940
{
	// Fields
	[Preserve]
	public string text; // 0x10
	[Preserve]
	public string url; // 0x18
	[Preserve]
	public string filePath; // 0x20

	// Methods

	// RVA: 0x640D830 Offset: 0x6409830 VA: 0x640D830
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime
[Preserve]
[Serializable]
public class InstagramSharePayload // TypeDefIndex: 25941
{
	// Methods

	// RVA: 0x640D838 Offset: 0x6409838 VA: 0x640D838
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime
[Preserve]
[Serializable]
public class WhatsAppSharePayload // TypeDefIndex: 25942
{
	// Fields
	[Preserve]
	public string text; // 0x10

	// Methods

	// RVA: 0x640D840 Offset: 0x6409840 VA: 0x640D840
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime
public static class ShareProviderRegistry // TypeDefIndex: 25943
{
	// Fields
	private static readonly List<IShareProvider> Providers; // 0x0

	// Methods

	// RVA: 0x640D5BC Offset: 0x64095BC VA: 0x640D5BC
	public static void Register(IShareProvider provider) { }

	// RVA: 0x640D848 Offset: 0x6409848 VA: 0x640D848
	private static void .cctor() { }
}

// Namespace: GorillaBase.Runtime
public sealed class ShareService // TypeDefIndex: 25944
{
	// Methods

	// RVA: 0x6406C44 Offset: 0x6402C44 VA: 0x6406C44
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Utils
public static class AESUtil // TypeDefIndex: 25945
{
	// Methods

	// RVA: 0x640CF38 Offset: 0x6408F38 VA: 0x640CF38
	public static string Encrypt(string content, string key, string iv) { }
}

// Namespace: 
[CompilerGenerated]
private struct AsyncUtil.<RunInternal>d__2 : IAsyncStateMachine // TypeDefIndex: 25946
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public Func<Task> asyncAction; // 0x20
	public Action<Exception> onException; // 0x28
	public string tag; // 0x30
	private TaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x640DAA4 Offset: 0x6409AA4 VA: 0x640DAA4 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x640DD74 Offset: 0x6409D74 VA: 0x640DD74 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: GorillaBase.Runtime.Utils
public static class AsyncUtil // TypeDefIndex: 25947
{
	// Methods

	// RVA: 0x640D8E0 Offset: 0x64098E0 VA: 0x640D8E0
	public static void RunSafe(Func<Task> asyncAction, string tag, Action<Exception> onException) { }

	[AsyncStateMachine(typeof(AsyncUtil.<RunInternal>d__2))]
	// RVA: 0x640D990 Offset: 0x6409990 VA: 0x640D990
	private static Task RunInternal(Func<Task> asyncAction, string tag, Action<Exception> onException) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Delay.<WaitForSecondsCoroutine>d__4 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 25948
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public float seconds; // 0x20
	public TaskCompletionSource<bool> tcs; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x640E034 Offset: 0x640A034 VA: 0x640E034
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x640E064 Offset: 0x640A064 VA: 0x640E064 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x640E068 Offset: 0x640A068 VA: 0x640E068 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x640E140 Offset: 0x640A140 VA: 0x640E140 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x640E148 Offset: 0x640A148 VA: 0x640E148 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x640E180 Offset: 0x640A180 VA: 0x640E180 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: GorillaBase.Runtime.Utils
public class Delay : MonoBehaviour // TypeDefIndex: 25949
{
	// Fields
	private static Delay _instance; // 0x0

	// Properties
	public static Delay Instance { get; }

	// Methods

	// RVA: 0x640DDDC Offset: 0x6409DDC VA: 0x640DDDC
	public static Delay get_Instance() { }

	// RVA: 0x640DF08 Offset: 0x6409F08 VA: 0x640DF08
	public Task WaitForSeconds(float seconds) { }

	[IteratorStateMachine(typeof(Delay.<WaitForSecondsCoroutine>d__4))]
	// RVA: 0x640DFB8 Offset: 0x6409FB8 VA: 0x640DFB8
	private static IEnumerator WaitForSecondsCoroutine(float seconds, TaskCompletionSource<bool> tcs) { }

	// RVA: 0x640E05C Offset: 0x640A05C VA: 0x640E05C
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Utils
public static class JsonUtil // TypeDefIndex: 25950
{
	// Methods

	// RVA: 0x640CEA4 Offset: 0x6408EA4 VA: 0x640CEA4
	public static string Serialize(object obj, bool pretty = True) { }

	// RVA: -1 Offset: -1
	public static T Deserialize<T>(string json) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46546DC Offset: 0x46506DC VA: 0x46546DC
	|-JsonUtil.Deserialize<object>
	|
	|-RVA: 0x4654760 Offset: 0x4650760 VA: 0x4654760
	|-JsonUtil.Deserialize<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: GorillaBase.Runtime.Utils
[Preserve]
public class MainThreadRunner : MonoBehaviour // TypeDefIndex: 25951
{
	// Fields
	private static readonly ConcurrentQueue<Action> Queue; // 0x0

	// Methods

	// RVA: 0x640E188 Offset: 0x640A188 VA: 0x640E188
	public static void Run(Action action) { }

	// RVA: 0x640E218 Offset: 0x640A218 VA: 0x640E218
	private void Update() { }

	[Preserve]
	[RuntimeInitializeOnLoadMethod(0)]
	// RVA: 0x640E370 Offset: 0x640A370 VA: 0x640E370
	private static void Init() { }

	// RVA: 0x640E43C Offset: 0x640A43C VA: 0x640E43C
	public void .ctor() { }

	// RVA: 0x640E444 Offset: 0x640A444 VA: 0x640E444
	private static void .cctor() { }
}

// Namespace: 
[IsReadOnly]
private struct PushNotificationPermission.AutoStartSettingsTarget // TypeDefIndex: 25952
{
	// Fields
	[CompilerGenerated]
	private readonly string <PackageName>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly string <ClassName>k__BackingField; // 0x8

	// Properties
	public string PackageName { get; }
	public string ClassName { get; }

	// Methods

	// RVA: 0x6412A40 Offset: 0x640EA40 VA: 0x6412A40
	public void .ctor(string packageName, string className) { }

	[CompilerGenerated]
	// RVA: 0x6412A70 Offset: 0x640EA70 VA: 0x6412A70
	public string get_PackageName() { }

	[CompilerGenerated]
	// RVA: 0x6412A78 Offset: 0x640EA78 VA: 0x6412A78
	public string get_ClassName() { }
}

// Namespace: GorillaBase.Runtime.Utils
public static class PushNotificationPermission // TypeDefIndex: 25953
{
	// Fields
	private static readonly Dictionary<string, PushNotificationPermission.AutoStartSettingsTarget[]> AndroidAutoStartSettingsTargets; // 0x0

	// Methods

	[Preserve]
	// RVA: 0x640E4DC Offset: 0x640A4DC VA: 0x640E4DC
	public static void OpenNotificationSettings() { }

	[Preserve]
	// RVA: 0x640F008 Offset: 0x640B008 VA: 0x640F008
	public static void OpenBatteryOptimizationSettings() { }

	[Preserve]
	// RVA: 0x6410264 Offset: 0x640C264 VA: 0x6410264
	public static void OpenAutoStartSettings() { }

	// RVA: 0x640E6A8 Offset: 0x640A6A8 VA: 0x640E6A8
	private static void OpenAndroidNotificationSettings() { }

	// RVA: 0x640F054 Offset: 0x640B054 VA: 0x640F054
	private static void OpenAndroidBatteryOptimizationSettings() { }

	// RVA: 0x64102B0 Offset: 0x640C2B0 VA: 0x64102B0
	private static void OpenAndroidAutoStartSettings() { }

	// RVA: 0x64117F8 Offset: 0x640D7F8 VA: 0x64117F8
	private static bool TryOpenAndroidAutoStartSettings(AndroidJavaObject activity, AndroidJavaObject packageManager) { }

	// RVA: 0x6410F94 Offset: 0x640CF94 VA: 0x6410F94
	private static void OpenAndroidApplicationDetailsSettings(AndroidJavaObject activity, AndroidJavaObject packageManager) { }

	// RVA: 0x6410B9C Offset: 0x640CB9C VA: 0x6410B9C
	private static bool TryStartAndroidActivity(AndroidJavaObject activity, AndroidJavaObject packageManager, AndroidJavaObject intent, string pageName) { }

	// RVA: 0x64107DC Offset: 0x640C7DC VA: 0x64107DC
	private static AndroidJavaObject GetAndroidActivity() { }

	// RVA: 0x64109BC Offset: 0x640C9BC VA: 0x64109BC
	private static int GetAndroidSdkInt() { }

	// RVA: 0x64122DC Offset: 0x640E2DC VA: 0x64122DC
	private static void .cctor() { }
}

// Namespace: GorillaBase.Runtime.Utils
public static class RequestSignatureUtil // TypeDefIndex: 25954
{
	// Methods

	// RVA: 0x6412A80 Offset: 0x640EA80 VA: 0x6412A80
	public static Dictionary<string, string> CreateHeaders(string secret, string path, string body) { }

	// RVA: 0x6412D54 Offset: 0x640ED54 VA: 0x6412D54
	private static string CalculateSignature(string secret, string version, string timestamp, string nonce, string path, string body) { }
}

// Namespace: 
private class ScreenSizePlugin.ScreenSizeProxy : AndroidJavaProxy // TypeDefIndex: 25955
{
	// Methods

	// RVA: 0x64130F8 Offset: 0x640F0F8 VA: 0x64130F8
	public void .ctor() { }

	[Preserve]
	// RVA: 0x6413168 Offset: 0x640F168 VA: 0x6413168
	private void onScreenSizeChanged(int width, int height, float density, int rotation, int left, int top, int right, int bottom) { }
}

// Namespace: 
[Preserve]
[Serializable]
public class ScreenSizePlugin.ScreenInfo // TypeDefIndex: 25956
{
	// Fields
	public int width; // 0x10
	public int height; // 0x14
	public float density; // 0x18
	public int rotation; // 0x1C
	public int left; // 0x20
	public int top; // 0x24
	public int right; // 0x28
	public int bottom; // 0x2C

	// Methods

	// RVA: 0x641326C Offset: 0x640F26C VA: 0x641326C Slot: 3
	public override string ToString() { }

	// RVA: 0x6413264 Offset: 0x640F264 VA: 0x6413264
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Utils
public static class ScreenSizePlugin // TypeDefIndex: 25957
{
	// Fields
	private static Action<ScreenSizePlugin.ScreenInfo> _onSizeChanged; // 0x0
}

// Namespace: 
[Preserve]
private sealed class NativeTimer.AndroidTimerCallback : AndroidJavaProxy // TypeDefIndex: 25958
{
	// Fields
	private readonly Action _callback; // 0x20

	// Methods

	[Preserve]
	// RVA: 0x6413B94 Offset: 0x640FB94 VA: 0x6413B94
	public void .ctor(Action callback) { }

	[Preserve]
	// RVA: 0x6413CFC Offset: 0x640FCFC VA: 0x6413CFC
	public void onTick() { }
}

// Namespace: GorillaBase.Runtime.Threading
public sealed class NativeTimer : IDisposable // TypeDefIndex: 25959
{
	// Fields
	private readonly Action _callback; // 0x10
	private int _disposed; // 0x18
	private NativeTimer.AndroidTimerCallback _androidCallback; // 0x20
	private long _nativeTimerId; // 0x28

	// Methods

	// RVA: 0x6413278 Offset: 0x640F278 VA: 0x6413278
	private void .ctor(Action callback, TimeSpan interval) { }

	// RVA: 0x6413748 Offset: 0x640F748 VA: 0x6413748
	public static NativeTimer StartPeriodic(Action callback, TimeSpan interval) { }

	// RVA: 0x64138E8 Offset: 0x640F8E8 VA: 0x64138E8 Slot: 4
	public void Dispose() { }

	// RVA: 0x64132B8 Offset: 0x640F2B8 VA: 0x64132B8
	private void Start(TimeSpan interval) { }

	// RVA: 0x6413C20 Offset: 0x640FC20 VA: 0x6413C20
	private void InvokeCallback() { }
}

// Namespace: GorillaBase.Runtime.Storage
public static class UserStorage // TypeDefIndex: 25960
{
	// Methods

	// RVA: 0x6413D20 Offset: 0x640FD20 VA: 0x6413D20
	public static void SetAccountId(string accountId) { }

	// RVA: 0x6413D9C Offset: 0x640FD9C VA: 0x6413D9C
	public static string GetAccountId() { }

	// RVA: 0x6413E00 Offset: 0x640FE00 VA: 0x6413E00
	public static void DeleteAccountId() { }

	// RVA: 0x6413E74 Offset: 0x640FE74 VA: 0x6413E74
	public static void SetChannelAccountId(string accountId) { }

	// RVA: 0x6413EC8 Offset: 0x640FEC8 VA: 0x6413EC8
	public static string GetChannelAccountId() { }

	// RVA: 0x6413F24 Offset: 0x640FF24 VA: 0x6413F24
	public static void DeleteChannelAccountId() { }

	// RVA: 0x6413F70 Offset: 0x640FF70 VA: 0x6413F70
	public static void SetAccessToken(string token) { }

	// RVA: 0x6413FC4 Offset: 0x640FFC4 VA: 0x6413FC4
	public static string GetAccessToken() { }

	// RVA: 0x6414020 Offset: 0x6410020 VA: 0x6414020
	public static void DeleteAccessToken() { }

	// RVA: 0x641406C Offset: 0x641006C VA: 0x641406C
	public static void SetLoginChannelId(int channelId) { }

	// RVA: 0x64140E8 Offset: 0x64100E8 VA: 0x64140E8
	public static int GetLoginChannelId() { }

	// RVA: 0x6414138 Offset: 0x6410138 VA: 0x6414138
	public static void DeleteLoginChannelId() { }

	// RVA: 0x6414184 Offset: 0x6410184 VA: 0x6414184
	public static void DeleteAll() { }

	// RVA: 0x6413D74 Offset: 0x640FD74 VA: 0x6413D74
	public static void SetString(string key, string value, bool saveImmediately = True) { }

	// RVA: 0x6413DF8 Offset: 0x640FDF8 VA: 0x6413DF8
	public static string GetString(string key, string defaultValue = "") { }

	// RVA: 0x64140C0 Offset: 0x64100C0 VA: 0x64140C0
	public static void SetInt(string key, int value, bool saveImmediately = True) { }

	// RVA: 0x6414130 Offset: 0x6410130 VA: 0x6414130
	public static int GetInt(string key, int defaultValue = 0) { }

	// RVA: 0x6413E4C Offset: 0x640FE4C VA: 0x6413E4C
	public static void Delete(string key, bool saveImmediately = True) { }
}

// Namespace: GorillaBase.Runtime.Network
public class AccountDeleteRequest : Request // TypeDefIndex: 25961
{
	// Fields
	private readonly string _gameId; // 0x10

	// Methods

	// RVA: 0x64141A4 Offset: 0x64101A4 VA: 0x64141A4
	public void .ctor(string gameId) { }

	// RVA: 0x64141DC Offset: 0x64101DC VA: 0x64141DC Slot: 7
	public override Request.Method GetMethod() { }

	// RVA: 0x64141E4 Offset: 0x64101E4 VA: 0x64141E4 Slot: 4
	public override string GetPath() { }

	// RVA: 0x6414230 Offset: 0x6410230 VA: 0x6414230 Slot: 5
	public override Dictionary<string, string> GetHeaders() { }
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
public class AccountLogoutRequest : Request // TypeDefIndex: 25962
{
	// Methods

	// RVA: 0x6414394 Offset: 0x6410394 VA: 0x6414394 Slot: 4
	public override string GetPath() { }

	// RVA: 0x64143D4 Offset: 0x64103D4 VA: 0x64143D4 Slot: 5
	public override Dictionary<string, string> GetHeaders() { }

	// RVA: 0x6414478 Offset: 0x6410478 VA: 0x6414478 Slot: 6
	public override int GetTimeout() { }

	// RVA: 0x6414480 Offset: 0x6410480 VA: 0x6414480 Slot: 8
	public override int GetMaxRetries() { }

	// RVA: 0x6414488 Offset: 0x6410488 VA: 0x6414488
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
[Serializable]
public class BindRequest : Request // TypeDefIndex: 25963
{
	// Fields
	[Preserve]
	public int channelId; // 0x10
	[Preserve]
	public string channelAccountId; // 0x18
	[Preserve]
	public string verification; // 0x20
	[Preserve]
	public string deviceId; // 0x28
	private readonly string _gameId; // 0x30

	// Methods

	// RVA: 0x6414490 Offset: 0x6410490 VA: 0x6414490
	public void .ctor(string gameId) { }

	// RVA: 0x64144C0 Offset: 0x64104C0 VA: 0x64144C0 Slot: 4
	public override string GetPath() { }

	// RVA: 0x641450C Offset: 0x641050C VA: 0x641450C Slot: 5
	public override Dictionary<string, string> GetHeaders() { }
}

// Namespace: GorillaBase.Runtime.Network
public class DeviceDeleteRequest : Request // TypeDefIndex: 25964
{
	// Fields
	private readonly string _gameId; // 0x10
	private readonly string _deviceId; // 0x18

	// Methods

	// RVA: 0x64145B0 Offset: 0x64105B0 VA: 0x64145B0
	public void .ctor(string gameId, string deviceId) { }

	// RVA: 0x64145F4 Offset: 0x64105F4 VA: 0x64145F4 Slot: 7
	public override Request.Method GetMethod() { }

	// RVA: 0x64145FC Offset: 0x64105FC VA: 0x64145FC Slot: 4
	public override string GetPath() { }

	// RVA: 0x6414668 Offset: 0x6410668 VA: 0x6414668 Slot: 5
	public override Dictionary<string, string> GetHeaders() { }
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
[Serializable]
public class DouyinMiniLoginRequest : Request // TypeDefIndex: 25965
{
	// Fields
	[Preserve]
	public string code; // 0x10
	[Preserve]
	public string anonymousCode; // 0x18
	[Preserve]
	public bool isLogin; // 0x20
	private readonly string _gameId; // 0x28

	// Methods

	// RVA: 0x641470C Offset: 0x641070C VA: 0x641470C Slot: 4
	public override string GetPath() { }
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
[Serializable]
public class DouyinMiniLoginResponse : GameLoginResponse // TypeDefIndex: 25966
{
	// Fields
	[Preserve]
	public string openId; // 0x70
	[Preserve]
	public string unionId; // 0x78
	[Preserve]
	public string anonymousOpenId; // 0x80

	// Methods

	// RVA: 0x6414758 Offset: 0x6410758 VA: 0x6414758
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
[Serializable]
public class EmailBindRequest : Request // TypeDefIndex: 25967
{
	// Fields
	[Preserve]
	public string email; // 0x10
	[Preserve]
	public string code; // 0x18

	// Methods

	// RVA: 0x6414768 Offset: 0x6410768 VA: 0x6414768 Slot: 4
	public override string GetPath() { }

	// RVA: 0x64147A8 Offset: 0x64107A8 VA: 0x64147A8 Slot: 5
	public override Dictionary<string, string> GetHeaders() { }

	// RVA: 0x641484C Offset: 0x641084C VA: 0x641484C
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
[Serializable]
public class EmailCodeRequest : Request // TypeDefIndex: 25968
{
	// Fields
	[Preserve]
	public string email; // 0x10

	// Methods

	// RVA: 0x6414854 Offset: 0x6410854 VA: 0x6414854 Slot: 4
	public override string GetPath() { }

	// RVA: 0x6414894 Offset: 0x6410894 VA: 0x6414894
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
[Serializable]
public class EmailCodeResponse // TypeDefIndex: 25969
{
	// Fields
	[Preserve]
	public int remaining; // 0x10

	// Methods

	// RVA: 0x641489C Offset: 0x641089C VA: 0x641489C Slot: 3
	public override string ToString() { }

	// RVA: 0x6414920 Offset: 0x6410920 VA: 0x6414920
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Network
internal static class GameLoginAuthPolicy // TypeDefIndex: 25970
{
	// Methods

	// RVA: 0x6414928 Offset: 0x6410928 VA: 0x6414928
	public static string GetAccessToken(GameLoginRequest request) { }
}

// Namespace: GorillaBase.Runtime.Network
public static class GameLoginCache // TypeDefIndex: 25971
{
	// Methods

	// RVA: 0x64149F4 Offset: 0x64109F4 VA: 0x64149F4
	public static void Save(GameLoginRequest request, GameLoginResponse response) { }
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
[Serializable]
public class GameLoginRequest : Request // TypeDefIndex: 25972
{
	// Fields
	private readonly string _gameId; // 0x10
	private readonly int _timeout; // 0x18
	[Preserve]
	public int channelId; // 0x1C
	[Preserve]
	public string channelAccountId; // 0x20
	[Preserve]
	public string verification; // 0x28
	[Preserve]
	public string deviceId; // 0x30

	// Methods

	// RVA: 0x6414A98 Offset: 0x6410A98 VA: 0x6414A98
	public void .ctor(string gameId, int timeout = 10) { }

	// RVA: 0x6414AD4 Offset: 0x6410AD4 VA: 0x6414AD4 Slot: 4
	public override string GetPath() { }

	// RVA: 0x6414B20 Offset: 0x6410B20 VA: 0x6414B20 Slot: 6
	public override int GetTimeout() { }

	// RVA: 0x6414B28 Offset: 0x6410B28 VA: 0x6414B28 Slot: 5
	public override Dictionary<string, string> GetHeaders() { }
}

// Namespace: GorillaBase.Runtime.Network
public static class GameLoginRequestFactory // TypeDefIndex: 25973
{
	// Methods

	// RVA: 0x6414BD4 Offset: 0x6410BD4 VA: 0x6414BD4
	public static GameLoginRequest CreateDeviceLogin(string gameId) { }
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
[Serializable]
public class GameLoginResponse // TypeDefIndex: 25974
{
	// Fields
	[Preserve]
	public string gorillaId; // 0x10
	[Preserve]
	public string email; // 0x18
	[Preserve]
	public string phoneNumber; // 0x20
	[Preserve]
	public string accountId; // 0x28
	[Preserve]
	public string status; // 0x30
	[Preserve]
	public TokenInfo tokenInfo; // 0x38
	[Preserve]
	public string accountVerification; // 0x40
	[Preserve]
	public bool isNewAccount; // 0x48
	[Preserve]
	public Nullable<long> lastLoginTime; // 0x50
	[Preserve]
	public AntiAddictionInfo antiAddictionInfo; // 0x60
	[Preserve]
	public List<ChannelBindInfo> channelBindings; // 0x68

	// Methods

	// RVA: 0x6414D2C Offset: 0x6410D2C VA: 0x6414D2C Slot: 3
	public override string ToString() { }

	// RVA: 0x6414760 Offset: 0x6410760 VA: 0x6414760
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
[Serializable]
public class IdCardValidateRequest : Request // TypeDefIndex: 25975
{
	// Fields
	private readonly string _gameId; // 0x10
	[Preserve]
	public string idCardNumber; // 0x18
	[Preserve]
	public string idCardName; // 0x20

	// Methods

	// RVA: 0x6414D34 Offset: 0x6410D34 VA: 0x6414D34
	public void .ctor(string gameId) { }

	// RVA: 0x6414D64 Offset: 0x6410D64 VA: 0x6414D64 Slot: 4
	public override string GetPath() { }

	// RVA: 0x6414DB0 Offset: 0x6410DB0 VA: 0x6414DB0 Slot: 5
	public override Dictionary<string, string> GetHeaders() { }
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
[Serializable]
public class IdCardValidateResponse // TypeDefIndex: 25976
{
	// Fields
	[Preserve]
	public int addictLevel; // 0x10
	[Preserve]
	public int age; // 0x14

	// Methods

	// RVA: 0x6414E54 Offset: 0x6410E54 VA: 0x6414E54 Slot: 3
	public override string ToString() { }

	// RVA: 0x6414E60 Offset: 0x6410E60 VA: 0x6414E60
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Network
public interface INetworkService // TypeDefIndex: 25977
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Task<T> SendRequest<T>(Request request);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-INetworkService.SendRequest<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SendRequest<T>(Request request, Action<T> onSuccess, Action<int, string> onFailure);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-INetworkService.SendRequest<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: GorillaBase.Runtime.Network
public class NetworkException : Exception // TypeDefIndex: 25978
{
	// Fields
	[CompilerGenerated]
	private readonly int <ErrorCode>k__BackingField; // 0x8C
	[CompilerGenerated]
	private readonly string <ErrorMessage>k__BackingField; // 0x90

	// Properties
	public int ErrorCode { get; }
	public string ErrorMessage { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6414E68 Offset: 0x6410E68 VA: 0x6414E68
	public int get_ErrorCode() { }

	[CompilerGenerated]
	// RVA: 0x6414E70 Offset: 0x6410E70 VA: 0x6414E70
	public string get_ErrorMessage() { }

	// RVA: 0x6414E78 Offset: 0x6410E78 VA: 0x6414E78
	public void .ctor(int errorCode, string message) { }
}

// Namespace: GorillaBase.Runtime.Network
public class APIException : NetworkException // TypeDefIndex: 25979
{
	// Methods

	// RVA: 0x6414F64 Offset: 0x6410F64 VA: 0x6414F64
	public void .ctor(int errorCode, string message) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class NetworkService.<>c // TypeDefIndex: 25980
{
	// Fields
	public static readonly NetworkService.<>c <>9; // 0x0
	public static Func<KeyValuePair<string, string>, bool> <>9__8_0; // 0x8
	public static Func<KeyValuePair<string, object>, string> <>9__10_0; // 0x10
	public static Func<KeyValuePair<string, string>, bool> <>9__11_0; // 0x18

	// Methods

	// RVA: 0x64164B0 Offset: 0x64124B0 VA: 0x64164B0
	private static void .cctor() { }

	// RVA: 0x6416518 Offset: 0x6412518 VA: 0x6416518
	public void .ctor() { }

	// RVA: 0x6416520 Offset: 0x6412520 VA: 0x6416520
	internal bool <BuildWebRequest>b__8_0(KeyValuePair<string, string> x) { }

	// RVA: 0x641656C Offset: 0x641256C VA: 0x641656C
	internal string <BuildUrl>b__10_0(KeyValuePair<string, object> query) { }

	// RVA: 0x6416650 Offset: 0x6412650 VA: 0x6416650
	internal bool <LogRequestAsCurl>b__11_0(KeyValuePair<string, string> h) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NetworkService.<>c__DisplayClass3_0<T> // TypeDefIndex: 25981
{
	// Fields
	public NetworkService <>4__this; // 0x0
	public Request request; // 0x0
	public Action<T> onSuccess; // 0x0
	public Action<int, string> onFailure; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48761AC Offset: 0x48721AC VA: 0x48761AC
	|-NetworkService.<>c__DisplayClass3_0<object>..ctor
	|
	|-RVA: 0x487635C Offset: 0x487235C VA: 0x487635C
	|-NetworkService.<>c__DisplayClass3_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal Task <SendRequest>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48761B4 Offset: 0x48721B4 VA: 0x48761B4
	|-NetworkService.<>c__DisplayClass3_0<object>.<SendRequest>b__0
	|
	|-RVA: 0x4876364 Offset: 0x4872364 VA: 0x4876364
	|-NetworkService.<>c__DisplayClass3_0<__Il2CppFullySharedGenericType>.<SendRequest>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private struct NetworkService.<Send>d__7 : IAsyncStateMachine // TypeDefIndex: 25982
{
	// Fields
	public int <>1__state; // 0x0
	[TupleElementNames(new[] { "success", "text", "responseCode" })]
	public AsyncTaskMethodBuilder<ValueTuple<bool, string, long>> <>t__builder; // 0x8
	public NetworkService <>4__this; // 0x20
	public Request request; // 0x28
	private UnityWebRequest <webRequest>5__2; // 0x30
	private UnityWebRequestAsyncOperation <operation>5__3; // 0x38
	private YieldAwaitable.YieldAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x641669C Offset: 0x641269C VA: 0x641669C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x6416F28 Offset: 0x6412F28 VA: 0x6416F28 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct NetworkService.<SendRequest>d__5<T> : IAsyncStateMachine // TypeDefIndex: 25983
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<T> <>t__builder; // 0x0
	public Request request; // 0x0
	public NetworkService <>4__this; // 0x0
	[TupleElementNames(new[] { "success", "text", "responseCode" })]
	private TaskAwaiter<ValueTuple<bool, string, long>> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E437D4 Offset: 0x5E3F7D4 VA: 0x5E437D4
	|-NetworkService.<SendRequest>d__5<object>.MoveNext
	|
	|-RVA: 0x5E43C98 Offset: 0x5E3FC98 VA: 0x5E43C98
	|-NetworkService.<SendRequest>d__5<__Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E43C20 Offset: 0x5E3FC20 VA: 0x5E43C20
	|-NetworkService.<SendRequest>d__5<object>.SetStateMachine
	|
	|-RVA: 0x5E4436C Offset: 0x5E4036C VA: 0x5E4436C
	|-NetworkService.<SendRequest>d__5<__Il2CppFullySharedGenericType>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGenerated]
private struct NetworkService.<SendRequestWithCallbacksAsync>d__4<T> : IAsyncStateMachine // TypeDefIndex: 25984
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x0
	public NetworkService <>4__this; // 0x0
	public Request request; // 0x0
	public Action<T> onSuccess; // 0x0
	public Action<int, string> onFailure; // 0x0
	private TaskAwaiter<T> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E4442C Offset: 0x5E4042C VA: 0x5E4442C
	|-NetworkService.<SendRequestWithCallbacksAsync>d__4<object>.MoveNext
	|
	|-RVA: 0x5E44828 Offset: 0x5E40828 VA: 0x5E44828
	|-NetworkService.<SendRequestWithCallbacksAsync>d__4<__Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E447C0 Offset: 0x5E407C0 VA: 0x5E447C0
	|-NetworkService.<SendRequestWithCallbacksAsync>d__4<object>.SetStateMachine
	|
	|-RVA: 0x5E44E20 Offset: 0x5E40E20 VA: 0x5E44E20
	|-NetworkService.<SendRequestWithCallbacksAsync>d__4<__Il2CppFullySharedGenericType>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGenerated]
private struct NetworkService.<SendWithRetry>d__6 : IAsyncStateMachine // TypeDefIndex: 25985
{
	// Fields
	public int <>1__state; // 0x0
	[TupleElementNames(new[] { "success", "text", "responseCode" })]
	public AsyncTaskMethodBuilder<ValueTuple<bool, string, long>> <>t__builder; // 0x8
	public int maxRetries; // 0x20
	public NetworkService <>4__this; // 0x28
	public Request request; // 0x30
	private int <attempt>5__2; // 0x38
	[TupleElementNames(new[] { "success", "text", "responseCode" })]
	private TaskAwaiter<ValueTuple<bool, string, long>> <>u__1; // 0x40
	private TaskAwaiter <>u__2; // 0x48

	// Methods

	// RVA: 0x6416FA4 Offset: 0x6412FA4 VA: 0x6416FA4 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x64176B4 Offset: 0x64136B4 VA: 0x64176B4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: GorillaBase.Runtime.Network
public class NetworkService : INetworkService // TypeDefIndex: 25986
{
	// Fields
	private readonly string _baseUrl; // 0x10

	// Methods

	// RVA: 0x64092CC Offset: 0x64052CC VA: 0x64092CC
	public void .ctor(string baseUrl) { }

	// RVA: -1 Offset: -1 Slot: 5
	public void SendRequest<T>(Request request, Action<T> onSuccess, Action<int, string> onFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4681E1C Offset: 0x467DE1C VA: 0x4681E1C
	|-NetworkService.SendRequest<object>
	|
	|-RVA: 0x4681F34 Offset: 0x467DF34 VA: 0x4681F34
	|-NetworkService.SendRequest<__Il2CppFullySharedGenericType>
	*/

	[AsyncStateMachine(typeof(NetworkService.<SendRequestWithCallbacksAsync>d__4<T>))]
	// RVA: -1 Offset: -1
	private Task SendRequestWithCallbacksAsync<T>(Request request, Action<T> onSuccess, Action<int, string> onFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4682050 Offset: 0x467E050 VA: 0x4682050
	|-NetworkService.SendRequestWithCallbacksAsync<object>
	|
	|-RVA: 0x4682174 Offset: 0x467E174 VA: 0x4682174
	|-NetworkService.SendRequestWithCallbacksAsync<__Il2CppFullySharedGenericType>
	*/

	[AsyncStateMachine(typeof(NetworkService.<SendRequest>d__5<T>))]
	// RVA: -1 Offset: -1 Slot: 4
	public Task<T> SendRequest<T>(Request request) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4681C30 Offset: 0x467DC30 VA: 0x4681C30
	|-NetworkService.SendRequest<object>
	|
	|-RVA: 0x4681D20 Offset: 0x467DD20 VA: 0x4681D20
	|-NetworkService.SendRequest<__Il2CppFullySharedGenericType>
	*/

	[AsyncStateMachine(typeof(NetworkService.<SendWithRetry>d__6))]
	// RVA: 0x6414F68 Offset: 0x6410F68 VA: 0x6414F68
	private Task<ValueTuple<bool, string, long>> SendWithRetry(Request request, int maxRetries) { }

	[AsyncStateMachine(typeof(NetworkService.<Send>d__7))]
	// RVA: 0x641508C Offset: 0x641108C VA: 0x641508C
	private Task<ValueTuple<bool, string, long>> Send(Request request) { }

	// RVA: 0x64151A8 Offset: 0x64111A8 VA: 0x64151A8
	private UnityWebRequest BuildWebRequest(Request request) { }

	// RVA: 0x6415AB8 Offset: 0x6411AB8 VA: 0x6415AB8
	private static void AppendSignatureHeaders(Dictionary<string, string> headers, Request request, string body) { }

	// RVA: 0x6415850 Offset: 0x6411850 VA: 0x6415850
	private string BuildUrl(Request request) { }

	// RVA: 0x6415D90 Offset: 0x6411D90 VA: 0x6415D90
	private static void LogRequestAsCurl(string url, Request.Method method, string body, Dictionary<string, string> headers) { }
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
[Serializable]
public class OrderReceiptRequest : Request // TypeDefIndex: 25987
{
	// Fields
	private readonly string _channelName; // 0x10
	[Preserve]
	public string gameId; // 0x18
	[Preserve]
	public string accountId; // 0x20
	[Preserve]
	public string userId; // 0x28
	[Preserve]
	public int channelId; // 0x30
	[Preserve]
	public int orderType; // 0x34
	[Preserve]
	public string preOrderId; // 0x38
	[Preserve]
	public string receipt; // 0x40
	[Preserve]
	public string receiptVersion; // 0x48

	// Methods

	// RVA: 0x6417730 Offset: 0x6413730 VA: 0x6417730 Slot: 4
	public override string GetPath() { }
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
[Serializable]
public class OrderReceiptResponse // TypeDefIndex: 25988
{
	// Fields
	[Preserve]
	public string gameId; // 0x10
	[Preserve]
	public string userId; // 0x18
	[Preserve]
	public string productId; // 0x20
	[Preserve]
	public string orderId; // 0x28
	[Preserve]
	public string originalOrderId; // 0x30
	[Preserve]
	public bool sandbox; // 0x38
	[Preserve]
	public string cpOrderId; // 0x40
	[Preserve]
	public string channelId; // 0x48
	[Preserve]
	public string preOrderId; // 0x50
	[Preserve]
	public Dictionary<string, string> extra; // 0x58
	[Preserve]
	public int amount; // 0x60
	[Preserve]
	public int status; // 0x64

	// Methods

	// RVA: 0x641779C Offset: 0x641379C VA: 0x641779C
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
[Serializable]
public class PhoneBindRequest : Request // TypeDefIndex: 25989
{
	// Fields
	[Preserve]
	public string phoneNumber; // 0x10
	[Preserve]
	public string code; // 0x18
	[Preserve]
	public string deviceId; // 0x20
	[Preserve]
	public string deviceModel; // 0x28

	// Methods

	// RVA: 0x64177A4 Offset: 0x64137A4 VA: 0x64177A4 Slot: 4
	public override string GetPath() { }

	// RVA: 0x64177E4 Offset: 0x64137E4 VA: 0x64177E4 Slot: 5
	public override Dictionary<string, string> GetHeaders() { }

	// RVA: 0x6417888 Offset: 0x6413888 VA: 0x6417888
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Network
public class PhoneCaptchaMeRequest : Request // TypeDefIndex: 25990
{
	// Methods

	// RVA: 0x64178B8 Offset: 0x64138B8 VA: 0x64178B8 Slot: 4
	public override string GetPath() { }

	// RVA: 0x64178F8 Offset: 0x64138F8 VA: 0x64178F8 Slot: 5
	public override Dictionary<string, string> GetHeaders() { }

	// RVA: 0x641799C Offset: 0x641399C VA: 0x641799C
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
[Serializable]
public class PhoneCaptchaRequest : Request // TypeDefIndex: 25991
{
	// Fields
	[Preserve]
	public string phoneNumber; // 0x10

	// Methods

	// RVA: 0x64179A4 Offset: 0x64139A4 VA: 0x64179A4 Slot: 4
	public override string GetPath() { }

	// RVA: 0x64179E4 Offset: 0x64139E4 VA: 0x64179E4
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
[Serializable]
public class PhoneCaptchaResponse // TypeDefIndex: 25992
{
	// Fields
	[Preserve]
	public int remaining; // 0x10

	// Methods

	// RVA: 0x64179EC Offset: 0x64139EC VA: 0x64179EC Slot: 3
	public override string ToString() { }

	// RVA: 0x64179F8 Offset: 0x64139F8 VA: 0x64179F8
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
[Serializable]
public class PhoneChangeBindRequest : Request // TypeDefIndex: 25993
{
	// Fields
	[Preserve]
	public string phoneNumber; // 0x10
	[Preserve]
	public string code; // 0x18
	[Preserve]
	public string deviceId; // 0x20
	[Preserve]
	public string deviceModel; // 0x28
	[Preserve]
	public string currentCode; // 0x30

	// Methods

	// RVA: 0x6417A00 Offset: 0x6413A00 VA: 0x6417A00 Slot: 4
	public override string GetPath() { }

	// RVA: 0x6417A40 Offset: 0x6413A40 VA: 0x6417A40 Slot: 5
	public override Dictionary<string, string> GetHeaders() { }

	// RVA: 0x6417AE4 Offset: 0x6413AE4 VA: 0x6417AE4
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
[Serializable]
public class PreOrderRequest : Request // TypeDefIndex: 25994
{
	// Fields
	private readonly string _channelName; // 0x10
	private readonly string _gameId; // 0x18

	// Methods

	// RVA: 0x6417B14 Offset: 0x6413B14 VA: 0x6417B14 Slot: 4
	public override string GetPath() { }
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
[Serializable]
public class PreOrderResponse<T> // TypeDefIndex: 25995
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x526D624 Offset: 0x5269624 VA: 0x526D624
	|-PreOrderResponse<__Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x526D630 Offset: 0x5269630 VA: 0x526D630
	|-PreOrderResponse<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
[Serializable]
public class PreOrderAndroidChannelOrderResult // TypeDefIndex: 25996
{
	// Methods

	// RVA: 0x6417B80 Offset: 0x6413B80 VA: 0x6417B80
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
[Serializable]
public class PreOrderIOSChannelOrderResult // TypeDefIndex: 25997
{
	// Methods

	// RVA: 0x6417B88 Offset: 0x6413B88 VA: 0x6417B88
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
[Serializable]
public class QueryOrderRequest : Request // TypeDefIndex: 25998
{
	// Fields
	private readonly string _channelName; // 0x10
	private readonly string _gameId; // 0x18
	private readonly string _userId; // 0x20
	private readonly string _preOrderId; // 0x28
	private readonly int _maxRetries; // 0x30

	// Methods

	// RVA: 0x6417B90 Offset: 0x6413B90 VA: 0x6417B90
	public void .ctor(PayChannelId channelId, string gameId, string userId, string preOrderId, int maxRetries = 3) { }

	// RVA: 0x6417F40 Offset: 0x6413F40 VA: 0x6417F40 Slot: 7
	public override Request.Method GetMethod() { }

	// RVA: 0x6417F48 Offset: 0x6413F48 VA: 0x6417F48 Slot: 8
	public override int GetMaxRetries() { }

	// RVA: 0x6417FA8 Offset: 0x6413FA8 VA: 0x6417FA8 Slot: 4
	public override string GetPath() { }

	// RVA: 0x6418014 Offset: 0x6414014 VA: 0x6418014 Slot: 10
	public override List<KeyValuePair<string, object>> GetQueries() { }
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
[Serializable]
public class QueryOrderResponse // TypeDefIndex: 25999
{
	// Fields
	public string gameId; // 0x10
	public string userId; // 0x18
	public string productId; // 0x20
	public string orderId; // 0x28
	public string originalOrderId; // 0x30
	public bool sandbox; // 0x38
	public string cpOrderId; // 0x40
	public string channelId; // 0x48
	public string preOrderId; // 0x50
	public Dictionary<string, string> extra; // 0x58
	public int amount; // 0x60
	public int status; // 0x64

	// Methods

	// RVA: 0x64181E0 Offset: 0x64141E0 VA: 0x64181E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x64181EC Offset: 0x64141EC VA: 0x64181EC
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public enum Request.Method // TypeDefIndex: 26000
{
	// Fields
	public int value__; // 0x0
	public const Request.Method GET = 0;
	public const Request.Method POST = 1;
	public const Request.Method Delete = 2;
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
[Serializable]
public abstract class Request // TypeDefIndex: 26001
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string GetPath();

	// RVA: 0x64142D4 Offset: 0x64102D4 VA: 0x64142D4 Slot: 5
	public virtual Dictionary<string, string> GetHeaders() { }

	// RVA: 0x64181F4 Offset: 0x64141F4 VA: 0x64181F4 Slot: 6
	public virtual int GetTimeout() { }

	// RVA: 0x64181FC Offset: 0x64141FC VA: 0x64181FC Slot: 7
	public virtual Request.Method GetMethod() { }

	// RVA: 0x6418204 Offset: 0x6414204 VA: 0x6418204 Slot: 8
	public virtual int GetMaxRetries() { }

	// RVA: 0x641820C Offset: 0x641420C VA: 0x641820C Slot: 9
	public virtual int GetServerSuccessCode() { }

	// RVA: 0x6418214 Offset: 0x6414214 VA: 0x6418214 Slot: 10
	public virtual List<KeyValuePair<string, object>> GetQueries() { }

	// RVA: 0x64141D4 Offset: 0x64101D4 VA: 0x64141D4
	protected void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
[Serializable]
public class Response<T> // TypeDefIndex: 26002
{
	// Fields
	[Preserve]
	public int code; // 0x0
	[Preserve]
	public string message; // 0x0
	[Preserve]
	public T data; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54BC6F0 Offset: 0x54B86F0 VA: 0x54BC6F0
	|-Response<object>..ctor
	|
	|-RVA: 0x54BC6F8 Offset: 0x54B86F8 VA: 0x54BC6F8
	|-Response<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
[Serializable]
public class TikTokMiniLoginRequest : Request // TypeDefIndex: 26003
{
	// Fields
	[Preserve]
	public string code; // 0x10
	private readonly string _gameId; // 0x18

	// Methods

	// RVA: 0x641821C Offset: 0x641421C VA: 0x641821C Slot: 4
	public override string GetPath() { }
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
[Serializable]
public class TikTokMiniLoginResponse : GameLoginResponse // TypeDefIndex: 26004
{
	// Fields
	[Preserve]
	public string openId; // 0x70
	[Preserve]
	public string unionId; // 0x78
	[Preserve]
	public string anonymousOpenId; // 0x80

	// Methods

	// RVA: 0x6418268 Offset: 0x6414268 VA: 0x6418268
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
[Serializable]
public class WeChatMiniGetPhoneNumberRequest : Request // TypeDefIndex: 26005
{
	// Fields
	[Preserve]
	public string code; // 0x10
	private readonly string _gameId; // 0x18

	// Methods

	// RVA: 0x6418270 Offset: 0x6414270 VA: 0x6418270 Slot: 4
	public override string GetPath() { }
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
[Serializable]
public class WeChatMiniGetPhoneNumberResponse // TypeDefIndex: 26006
{
	// Fields
	[Preserve]
	public string phoneNumber; // 0x10
	[Preserve]
	public string purePhoneNumber; // 0x18
	[Preserve]
	public string countryCode; // 0x20

	// Methods

	// RVA: 0x64182BC Offset: 0x64142BC VA: 0x64182BC Slot: 3
	public override string ToString() { }

	// RVA: 0x64182C8 Offset: 0x64142C8 VA: 0x64182C8
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
[Serializable]
public class WeChatMiniLoginRequest : Request // TypeDefIndex: 26007
{
	// Fields
	[Preserve]
	public string code; // 0x10
	private readonly string _gameId; // 0x18

	// Methods

	// RVA: 0x64182D0 Offset: 0x64142D0 VA: 0x64182D0 Slot: 4
	public override string GetPath() { }
}

// Namespace: GorillaBase.Runtime.Network
[Preserve]
[Serializable]
public class WeChatMiniLoginResponse : GameLoginResponse // TypeDefIndex: 26008
{
	// Fields
	[Preserve]
	public string openId; // 0x70
	[Preserve]
	public string unionId; // 0x78

	// Methods

	// RVA: 0x641831C Offset: 0x641431C VA: 0x641831C
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public class AliPurchaseArgs : PurchaseArgs // TypeDefIndex: 26009
{
	// Fields
	[Preserve]
	public string orderString; // 0x30

	// Methods

	// RVA: 0x6418324 Offset: 0x6414324 VA: 0x6418324
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public class AliPurchaseResult // TypeDefIndex: 26010
{
	// Fields
	[Preserve]
	public string resultStatus; // 0x10
	[Preserve]
	public string memo; // 0x18
	[Preserve]
	public string result; // 0x20

	// Methods

	// RVA: 0x6418370 Offset: 0x6414370 VA: 0x6418370
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public class AntiAddictionInfo // TypeDefIndex: 26011
{
	// Fields
	[Preserve]
	public bool isValidated; // 0x10
	[Preserve]
	public AntiAddictionLevel addictLevel; // 0x14
	[Preserve]
	public int age; // 0x18

	// Methods

	// RVA: 0x6418378 Offset: 0x6414378 VA: 0x6418378
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public enum AntiAddictionLevel // TypeDefIndex: 26012
{
	// Fields
	public int value__; // 0x0
	public const AntiAddictionLevel Unknown = 0;
	public const AntiAddictionLevel Under8 = 1;
	public const AntiAddictionLevel Under16 = 2;
	public const AntiAddictionLevel Under18 = 3;
	public const AntiAddictionLevel Adult = 4;
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public class AppleIDLoginArgs // TypeDefIndex: 26013
{
	// Fields
	[Preserve]
	public string nonce; // 0x10
	[Preserve]
	public string state; // 0x18

	// Methods

	// RVA: 0x6418380 Offset: 0x6414380 VA: 0x6418380
	public void .ctor() { }
}

// Namespace: 
[Preserve]
[Serializable]
public class AppleIDLoginResult.FullName // TypeDefIndex: 26014
{
	// Fields
	[Preserve]
	public string namePrefix; // 0x10
	[Preserve]
	public string givenName; // 0x18
	[Preserve]
	public string middleName; // 0x20
	[Preserve]
	public string familyName; // 0x28
	[Preserve]
	public string nameSuffix; // 0x30
	[Preserve]
	public string nickname; // 0x38

	// Methods

	// RVA: 0x641840C Offset: 0x641440C VA: 0x641840C
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public class AppleIDLoginResult // TypeDefIndex: 26015
{
	// Fields
	[Preserve]
	public string state; // 0x10
	[Preserve]
	public string user; // 0x18
	[Preserve]
	public string email; // 0x20
	[Preserve]
	public string authorizationCode; // 0x28
	[Preserve]
	public string identityToken; // 0x30
	[Preserve]
	public int realUserStatus; // 0x38
	[Preserve]
	public AppleIDLoginResult.FullName fullName; // 0x40

	// Methods

	// RVA: 0x640CAD8 Offset: 0x6408AD8 VA: 0x640CAD8
	public string GetName() { }

	// RVA: 0x64183F8 Offset: 0x64143F8 VA: 0x64183F8 Slot: 3
	public override string ToString() { }

	// RVA: 0x6418404 Offset: 0x6414404 VA: 0x6418404
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public class BindArgs : Callback<ChannelBindInfo> // TypeDefIndex: 26016
{
	// Fields
	[Preserve]
	public LoginChannelId loginChannelId; // 0x28
	[Preserve]
	public List<string> facebookPermissions; // 0x30
	[Preserve]
	public string facebookNonce; // 0x38

	// Methods

	// RVA: 0x6418414 Offset: 0x6414414 VA: 0x6418414
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public class Callback<TSuccess> // TypeDefIndex: 26017
{
	// Fields
	[Preserve]
	[JsonIgnore]
	public Action<TSuccess> OnSuccess; // 0x0
	[JsonIgnore]
	[Preserve]
	public Action<int, string> OnFailure; // 0x0
	[JsonIgnore]
	[Preserve]
	public Action OnCancel; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA7814 Offset: 0x5BA3814 VA: 0x5BA7814
	|-Callback<Int32Enum>..ctor
	|
	|-RVA: 0x5BA781C Offset: 0x5BA381C VA: 0x5BA781C
	|-Callback<object>..ctor
	|
	|-RVA: 0x5BA7824 Offset: 0x5BA3824 VA: 0x5BA7824
	|-Callback<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public class ChannelBindInfo // TypeDefIndex: 26018
{
	// Fields
	[Preserve]
	public int channelId; // 0x10
	[Preserve]
	public string channelAccountId; // 0x18
	[Preserve]
	public Dictionary<string, string> extraInfo; // 0x20
	[Preserve]
	public string deviceId; // 0x28
	[Preserve]
	public long lastLoginAt; // 0x30
	[Preserve]
	public string lastLoginIp; // 0x38
	[Preserve]
	public string deviceModel; // 0x40
	[Preserve]
	public string lastLoginCountry; // 0x48
	[Preserve]
	public string lastLoginCity; // 0x50

	// Methods

	// RVA: 0x64184B8 Offset: 0x64144B8 VA: 0x64184B8
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public class GameCenterLoginResult // TypeDefIndex: 26019
{
	// Fields
	[Preserve]
	public string playerId; // 0x10
	[Preserve]
	public string playerName; // 0x18
	[Preserve]
	public string teamPlayerID; // 0x20
	[Preserve]
	public string publicKeyURL; // 0x28
	[Preserve]
	public string signature; // 0x30
	[Preserve]
	public string salt; // 0x38
	[Preserve]
	public string timestamp; // 0x40

	// Methods

	// RVA: 0x64184C0 Offset: 0x64144C0 VA: 0x64184C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x64184CC Offset: 0x64144CC VA: 0x64184CC
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Flags]
public enum GravityEngineCapabilities // TypeDefIndex: 26020
{
	// Fields
	public int value__; // 0x0
	public const GravityEngineCapabilities None = 0;
	public const GravityEngineCapabilities Initialization = 1;
	public const GravityEngineCapabilities Identity = 2;
	public const GravityEngineCapabilities Events = 4;
	public const GravityEngineCapabilities SuperProperties = 8;
	public const GravityEngineCapabilities UserProperties = 16;
	public const GravityEngineCapabilities AutoTrack = 32;
	public const GravityEngineCapabilities PredefinedEvents = 64;
	public const GravityEngineCapabilities TrackStatus = 128;
	public const GravityEngineCapabilities TimeCalibration = 256;
	public const GravityEngineCapabilities DeviceIdentifiers = 512;
	public const GravityEngineCapabilities Attribution = 1024;
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
public enum GravityEngineRunMode // TypeDefIndex: 26021
{
	// Fields
	public int value__; // 0x0
	public const GravityEngineRunMode Normal = 0;
	public const GravityEngineRunMode Debug = 1;
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
public enum GravityEngineTimeZone // TypeDefIndex: 26022
{
	// Fields
	public int value__; // 0x0
	public const GravityEngineTimeZone Local = 0;
	public const GravityEngineTimeZone Utc = 1;
	public const GravityEngineTimeZone AsiaShanghai = 2;
	public const GravityEngineTimeZone AsiaTokyo = 3;
	public const GravityEngineTimeZone AmericaLosAngeles = 4;
	public const GravityEngineTimeZone AmericaNewYork = 5;
	public const GravityEngineTimeZone Other = 100;
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
public enum GravityEngineSslPinningMode // TypeDefIndex: 26023
{
	// Fields
	public int value__; // 0x0
	public const GravityEngineSslPinningMode None = 0;
	public const GravityEngineSslPinningMode PublicKey = 1;
	public const GravityEngineSslPinningMode Certificate = 2;
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
public enum GravityEngineAndroidClientIdType // TypeDefIndex: 26024
{
	// Fields
	public int value__; // 0x0
	public const GravityEngineAndroidClientIdType Oaid = 0;
	public const GravityEngineAndroidClientIdType AndroidId = 1;
}

// Namespace: GorillaBase.Runtime.Model
[Flags]
[Preserve]
public enum GravityEngineAutoTrackEvents // TypeDefIndex: 26025
{
	// Fields
	public int value__; // 0x0
	public const GravityEngineAutoTrackEvents None = 0;
	public const GravityEngineAutoTrackEvents AppStart = 1;
	public const GravityEngineAutoTrackEvents AppEnd = 2;
	public const GravityEngineAutoTrackEvents AppCrash = 16;
	public const GravityEngineAutoTrackEvents AppInstall = 32;
	public const GravityEngineAutoTrackEvents SceneLoad = 64;
	public const GravityEngineAutoTrackEvents SceneUnload = 128;
	public const GravityEngineAutoTrackEvents AppAll = 35;
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
public enum GravityEngineTrackStatus // TypeDefIndex: 26026
{
	// Fields
	public int value__; // 0x0
	public const GravityEngineTrackStatus Pause = 1;
	public const GravityEngineTrackStatus Stop = 2;
	public const GravityEngineTrackStatus SaveOnly = 3;
	public const GravityEngineTrackStatus Normal = 4;
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public sealed class GravityEngineInitializationResult // TypeDefIndex: 26027
{
	// Fields
	[CompilerGenerated]
	private bool <IsSuccess>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <ErrorMessage>k__BackingField; // 0x18
	[CompilerGenerated]
	private Dictionary<string, object> <Response>k__BackingField; // 0x20

	// Properties
	[Preserve]
	public bool IsSuccess { get; set; }
	[Preserve]
	public string ErrorMessage { get; set; }
	[Preserve]
	public Dictionary<string, object> Response { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x64184D4 Offset: 0x64144D4 VA: 0x64184D4
	public bool get_IsSuccess() { }

	[CompilerGenerated]
	// RVA: 0x64184DC Offset: 0x64144DC VA: 0x64184DC
	public void set_IsSuccess(bool value) { }

	[CompilerGenerated]
	// RVA: 0x64184E8 Offset: 0x64144E8 VA: 0x64184E8
	public string get_ErrorMessage() { }

	[CompilerGenerated]
	// RVA: 0x64184F0 Offset: 0x64144F0 VA: 0x64184F0
	public void set_ErrorMessage(string value) { }

	[CompilerGenerated]
	// RVA: 0x64184F8 Offset: 0x64144F8 VA: 0x64184F8
	public Dictionary<string, object> get_Response() { }

	[CompilerGenerated]
	// RVA: 0x6418500 Offset: 0x6414500 VA: 0x6418500
	public void set_Response(Dictionary<string, object> value) { }

	// RVA: 0x6418508 Offset: 0x6414508 VA: 0x6418508
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public sealed class GravityEngineUserInfo // TypeDefIndex: 26028
{
	// Fields
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Channel>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <Version>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <OpenId>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <UnionId>k__BackingField; // 0x30

	// Properties
	[Preserve]
	public string Name { get; set; }
	[Preserve]
	public string Channel { get; set; }
	[Preserve]
	public int Version { get; set; }
	[Preserve]
	public string OpenId { get; set; }
	[Preserve]
	public string UnionId { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6418510 Offset: 0x6414510 VA: 0x6418510
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x6418518 Offset: 0x6414518 VA: 0x6418518
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x6418520 Offset: 0x6414520 VA: 0x6418520
	public string get_Channel() { }

	[CompilerGenerated]
	// RVA: 0x6418528 Offset: 0x6414528 VA: 0x6418528
	public void set_Channel(string value) { }

	[CompilerGenerated]
	// RVA: 0x6418530 Offset: 0x6414530 VA: 0x6418530
	public int get_Version() { }

	[CompilerGenerated]
	// RVA: 0x6418538 Offset: 0x6414538 VA: 0x6418538
	public void set_Version(int value) { }

	[CompilerGenerated]
	// RVA: 0x6418540 Offset: 0x6414540 VA: 0x6418540
	public string get_OpenId() { }

	[CompilerGenerated]
	// RVA: 0x6418548 Offset: 0x6414548 VA: 0x6418548
	public void set_OpenId(string value) { }

	[CompilerGenerated]
	// RVA: 0x6418550 Offset: 0x6414550 VA: 0x6418550
	public string get_UnionId() { }

	[CompilerGenerated]
	// RVA: 0x6418558 Offset: 0x6414558 VA: 0x6418558
	public void set_UnionId(string value) { }

	// RVA: 0x6418560 Offset: 0x6414560 VA: 0x6418560
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public sealed class GravityEnginePayEventArgs // TypeDefIndex: 26029
{
	// Fields
	[CompilerGenerated]
	private int <Amount>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Currency>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <OrderId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Reason>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <Method>k__BackingField; // 0x30

	// Properties
	[Preserve]
	public int Amount { get; set; }
	[Preserve]
	public string Currency { get; set; }
	[Preserve]
	public string OrderId { get; set; }
	[Preserve]
	public string Reason { get; set; }
	[Preserve]
	public string Method { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6418570 Offset: 0x6414570 VA: 0x6418570
	public int get_Amount() { }

	[CompilerGenerated]
	// RVA: 0x6418578 Offset: 0x6414578 VA: 0x6418578
	public void set_Amount(int value) { }

	[CompilerGenerated]
	// RVA: 0x6418580 Offset: 0x6414580 VA: 0x6418580
	public string get_Currency() { }

	[CompilerGenerated]
	// RVA: 0x6418588 Offset: 0x6414588 VA: 0x6418588
	public void set_Currency(string value) { }

	[CompilerGenerated]
	// RVA: 0x6418590 Offset: 0x6414590 VA: 0x6418590
	public string get_OrderId() { }

	[CompilerGenerated]
	// RVA: 0x6418598 Offset: 0x6414598 VA: 0x6418598
	public void set_OrderId(string value) { }

	[CompilerGenerated]
	// RVA: 0x64185A0 Offset: 0x64145A0 VA: 0x64185A0
	public string get_Reason() { }

	[CompilerGenerated]
	// RVA: 0x64185A8 Offset: 0x64145A8 VA: 0x64185A8
	public void set_Reason(string value) { }

	[CompilerGenerated]
	// RVA: 0x64185B0 Offset: 0x64145B0 VA: 0x64185B0
	public string get_Method() { }

	[CompilerGenerated]
	// RVA: 0x64185B8 Offset: 0x64145B8 VA: 0x64185B8
	public void set_Method(string value) { }

	// RVA: 0x64185C0 Offset: 0x64145C0 VA: 0x64185C0
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public sealed class GravityEngineNativeAdShowEventArgs // TypeDefIndex: 26030
{
	// Fields
	[CompilerGenerated]
	private string <AdUnionType>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <AdPlacementId>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <AdSourceId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <AdType>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <AdNetworkType>k__BackingField; // 0x30
	[CompilerGenerated]
	private float <Ecpm>k__BackingField; // 0x38

	// Properties
	[Preserve]
	public string AdUnionType { get; set; }
	[Preserve]
	public string AdPlacementId { get; set; }
	[Preserve]
	public string AdSourceId { get; set; }
	[Preserve]
	public string AdType { get; set; }
	[Preserve]
	public string AdNetworkType { get; set; }
	[Preserve]
	public float Ecpm { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x64185C8 Offset: 0x64145C8 VA: 0x64185C8
	public string get_AdUnionType() { }

	[CompilerGenerated]
	// RVA: 0x64185D0 Offset: 0x64145D0 VA: 0x64185D0
	public void set_AdUnionType(string value) { }

	[CompilerGenerated]
	// RVA: 0x64185D8 Offset: 0x64145D8 VA: 0x64185D8
	public string get_AdPlacementId() { }

	[CompilerGenerated]
	// RVA: 0x64185E0 Offset: 0x64145E0 VA: 0x64185E0
	public void set_AdPlacementId(string value) { }

	[CompilerGenerated]
	// RVA: 0x64185E8 Offset: 0x64145E8 VA: 0x64185E8
	public string get_AdSourceId() { }

	[CompilerGenerated]
	// RVA: 0x64185F0 Offset: 0x64145F0 VA: 0x64185F0
	public void set_AdSourceId(string value) { }

	[CompilerGenerated]
	// RVA: 0x64185F8 Offset: 0x64145F8 VA: 0x64185F8
	public string get_AdType() { }

	[CompilerGenerated]
	// RVA: 0x6418600 Offset: 0x6414600 VA: 0x6418600
	public void set_AdType(string value) { }

	[CompilerGenerated]
	// RVA: 0x6418608 Offset: 0x6414608 VA: 0x6418608
	public string get_AdNetworkType() { }

	[CompilerGenerated]
	// RVA: 0x6418610 Offset: 0x6414610 VA: 0x6418610
	public void set_AdNetworkType(string value) { }

	[CompilerGenerated]
	// RVA: 0x6418618 Offset: 0x6414618 VA: 0x6418618
	public float get_Ecpm() { }

	[CompilerGenerated]
	// RVA: 0x6418620 Offset: 0x6414620 VA: 0x6418620
	public void set_Ecpm(float value) { }

	// RVA: 0x6418628 Offset: 0x6414628 VA: 0x6418628
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public class LoginArgs : Callback<LoginResult> // TypeDefIndex: 26031
{
	// Fields
	[Preserve]
	public LoginChannelId loginChannelId; // 0x28
	[Preserve]
	public List<string> facebookPermissions; // 0x30
	[Preserve]
	public string facebookNonce; // 0x38
	[Preserve]
	public Action<string, Dictionary<string, object>> LoginEventTracker; // 0x40

	// Methods

	// RVA: 0x6418630 Offset: 0x6414630 VA: 0x6418630
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public enum LoginChannelId // TypeDefIndex: 26032
{
	// Fields
	public int value__; // 0x0
	[Preserve]
	public const LoginChannelId Auto = -1;
	[Preserve]
	public const LoginChannelId Device = 0;
	[Preserve]
	public const LoginChannelId GameCenter = 1;
	[Preserve]
	public const LoginChannelId PlayGame = 2;
	[Preserve]
	public const LoginChannelId Facebook = 4;
	[Preserve]
	public const LoginChannelId PhoneCaptcha = 10;
	[Preserve]
	public const LoginChannelId Email = 11;
	[Preserve]
	public const LoginChannelId WeChat = 12;
	[Preserve]
	public const LoginChannelId QQ = 13;
	[Preserve]
	public const LoginChannelId AppleID = 14;
	[Preserve]
	public const LoginChannelId Weibo = 15;
}

// Namespace: GorillaBase.Runtime.Model
[Extension]
public static class LoginChannelIdExtension // TypeDefIndex: 26033
{
	// Methods

	[Extension]
	// RVA: 0x64149F0 Offset: 0x64109F0 VA: 0x64149F0
	public static int ToInt(LoginChannelId channelId) { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public class LoginResult // TypeDefIndex: 26034
{
	// Fields
	[Preserve]
	public string gorillaId; // 0x10
	[Preserve]
	public string accountId; // 0x18
	[Preserve]
	public string verification; // 0x20
	[Preserve]
	public LoginChannelId channelId; // 0x28
	[Preserve]
	public bool isNewAccount; // 0x2C
	[Preserve]
	public TokenInfo tokenInfo; // 0x30
	[Preserve]
	public AntiAddictionInfo antiAddictionInfo; // 0x38
	[Preserve]
	public List<ChannelBindInfo> channelBindings; // 0x40

	// Methods

	// RVA: 0x64186D4 Offset: 0x64146D4 VA: 0x64186D4 Slot: 3
	public override string ToString() { }

	// RVA: 0x64186E0 Offset: 0x64146E0 VA: 0x64186E0
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
public static class LoginResultMapper // TypeDefIndex: 26035
{
	// Methods

	// RVA: 0x64186F0 Offset: 0x64146F0 VA: 0x64186F0
	public static LoginResult FromGameLoginResponse(GameLoginResponse response, LoginChannelId channelId) { }

	// RVA: -1 Offset: -1
	public static T FromGameLoginResponse<T>(GameLoginResponse response, LoginChannelId channelId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466CDF0 Offset: 0x4668DF0 VA: 0x466CDF0
	|-LoginResultMapper.FromGameLoginResponse<object>
	*/

	// RVA: 0x6418748 Offset: 0x6414748 VA: 0x6418748
	private static void CopyFromGameLoginResponse(GameLoginResponse response, LoginChannelId channelId, LoginResult result) { }

	// RVA: 0x64187FC Offset: 0x64147FC VA: 0x64187FC
	private static TokenInfo CloneTokenInfo(TokenInfo source) { }

	// RVA: 0x6418890 Offset: 0x6414890 VA: 0x6418890
	private static AntiAddictionInfo CloneAntiAddictionInfo(AntiAddictionInfo source) { }

	// RVA: 0x641890C Offset: 0x641490C VA: 0x641890C
	private static List<ChannelBindInfo> CloneChannelBindings(List<ChannelBindInfo> source) { }

	// RVA: 0x6418B24 Offset: 0x6414B24 VA: 0x6418B24
	private static ChannelBindInfo CloneChannelBindInfo(ChannelBindInfo source) { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public class OpenUserCenterArgs // TypeDefIndex: 26036
{
	// Fields
	[Preserve]
	public Action OnClose; // 0x10
	[Preserve]
	public Action OnSwitch; // 0x18
	[Preserve]
	public Action OnDeleteAccount; // 0x20
	[Preserve]
	public Action OnCustomService; // 0x28

	// Methods

	// RVA: 0x6418C68 Offset: 0x6414C68 VA: 0x6418C68
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public enum PayChannelId // TypeDefIndex: 26037
{
	// Fields
	public int value__; // 0x0
	public const PayChannelId Unity = 0;
	[Obsolete("Use Unity instead.")]
	public const PayChannelId Editor = 0;
	public const PayChannelId Apple = 1;
	public const PayChannelId Google = 2;
	public const PayChannelId HuaweiOverseas = 3;
	public const PayChannelId GorillaStore = 4;
	public const PayChannelId OneStore = 5;
	public const PayChannelId WeChat = 101;
	public const PayChannelId AliPay = 102;
	public const PayChannelId HuaWei = 201;
	public const PayChannelId YYB = 202;
	public const PayChannelId XiaoMi = 203;
	public const PayChannelId Oppo = 204;
	public const PayChannelId Vivo = 205;
	public const PayChannelId Ssjj = 206;
	public const PayChannelId UC = 207;
	public const PayChannelId Bili = 208;
	public const PayChannelId DouYin = 209;
	public const PayChannelId Honor = 210;
	public const PayChannelId Harmony = 211;
	public const PayChannelId KuaiShou = 212;
	public const PayChannelId YYBAd = 213;
	public const PayChannelId WeChatMiniGame = 301;
	public const PayChannelId WeChatJs = 302;
	public const PayChannelId DouYinMiniGame = 401;
	public const PayChannelId MyCard = 501;
}

// Namespace: GorillaBase.Runtime.Model
[Extension]
public static class PurchaseChannelIdExtension // TypeDefIndex: 26038
{
	// Methods

	[Extension]
	// RVA: 0x6417C20 Offset: 0x6413C20 VA: 0x6417C20
	public static string ToChannelName(PayChannelId channelId) { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public class PlayGameLoginResult // TypeDefIndex: 26039
{
	// Fields
	[Preserve]
	public string userId; // 0x10
	[Preserve]
	public string userName; // 0x18
	[Preserve]
	public string authenticationCode; // 0x20

	// Methods

	// RVA: 0x6418C70 Offset: 0x6414C70 VA: 0x6418C70 Slot: 3
	public override string ToString() { }

	// RVA: 0x6418C7C Offset: 0x6414C7C VA: 0x6418C7C
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public sealed class PrivacyPolicyRequest // TypeDefIndex: 26040
{
	// Fields
	[Preserve]
	public string serviceTermsUrl; // 0x10
	[Preserve]
	public string privacyPolicyUrl; // 0x18
	[Preserve]
	public bool showCancelButton; // 0x20
	[Preserve]
	public PrivacyPolicyTextOverrides textOverrides; // 0x28

	// Methods

	// RVA: 0x6418C84 Offset: 0x6414C84 VA: 0x6418C84
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public sealed class PrivacyPolicyTextOverrides // TypeDefIndex: 26041
{
	// Fields
	[Preserve]
	public string title; // 0x10
	[Preserve]
	public string contentTemplate; // 0x18
	[Preserve]
	public string serviceTermsText; // 0x20
	[Preserve]
	public string privacyPolicyText; // 0x28
	[Preserve]
	public string confirmButtonText; // 0x30
	[Preserve]
	public string cancelButtonText; // 0x38

	// Methods

	// RVA: 0x6418C8C Offset: 0x6414C8C VA: 0x6418C8C
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
public enum PrivacyPolicyResult // TypeDefIndex: 26042
{
	// Fields
	public int value__; // 0x0
	public const PrivacyPolicyResult Confirmed = 0;
	public const PrivacyPolicyResult Cancelled = 1;
	public const PrivacyPolicyResult AlreadyShown = 2;
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public class PurchaseArgs : Callback<object> // TypeDefIndex: 26043
{
	// Fields
	[Preserve]
	public string productId; // 0x28

	// Methods

	// RVA: 0x6418328 Offset: 0x6414328 VA: 0x6418328
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public class QQLoginResult // TypeDefIndex: 26044
{
	// Fields
	[Preserve]
	public string accessToken; // 0x10
	[Preserve]
	public string openId; // 0x18
	[Preserve]
	public string unionId; // 0x20
	[Preserve]
	public long expirationDate; // 0x28

	// Methods

	// RVA: 0x6418C94 Offset: 0x6414C94 VA: 0x6418C94 Slot: 3
	public override string ToString() { }

	// RVA: 0x6418CA0 Offset: 0x6414CA0 VA: 0x6418CA0
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
public class QueryOrderArgs // TypeDefIndex: 26045
{
	// Fields
	[Preserve]
	public PayChannelId ChannelId; // 0x10
	[Preserve]
	public string UserId; // 0x18
	[Preserve]
	public string PreOrderId; // 0x20
	[Preserve]
	public int MaxRetries; // 0x28

	// Methods

	// RVA: 0x6418CA8 Offset: 0x6414CA8 VA: 0x6418CA8
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
public class ReviewGuideArgs // TypeDefIndex: 26046
{
	// Methods

	// RVA: 0x6418CB8 Offset: 0x6414CB8 VA: 0x6418CB8
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public class SendSmsArgs // TypeDefIndex: 26047
{
	// Fields
	[Preserve]
	public string phoneNumber; // 0x10
	[Preserve]
	public string content; // 0x18

	// Methods

	// RVA: 0x6418CC0 Offset: 0x6414CC0 VA: 0x6418CC0
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Flags]
public enum SolarEngineCapabilities // TypeDefIndex: 26048
{
	// Fields
	public int value__; // 0x0
	public const SolarEngineCapabilities None = 0;
	public const SolarEngineCapabilities Initialization = 1;
	public const SolarEngineCapabilities Attribution = 2;
	public const SolarEngineCapabilities Identity = 4;
	public const SolarEngineCapabilities SuperProperties = 8;
	public const SolarEngineCapabilities UserProperties = 16;
	public const SolarEngineCapabilities CustomEvents = 32;
	public const SolarEngineCapabilities PredefinedEvents = 64;
	public const SolarEngineCapabilities FirstEvents = 128;
	public const SolarEngineCapabilities DeepLink = 256;
	public const SolarEngineCapabilities Att = 512;
	public const SolarEngineCapabilities Skan = 1024;
	public const SolarEngineCapabilities MiniGame = 2048;
	public const SolarEngineCapabilities DeviceIdentifiers = 4096;
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
public enum SolarEnginePresetEventType // TypeDefIndex: 26049
{
	// Fields
	public int value__; // 0x0
	public const SolarEnginePresetEventType Install = 0;
	public const SolarEnginePresetEventType Start = 1;
	public const SolarEnginePresetEventType End = 2;
	public const SolarEnginePresetEventType All = 3;
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
public enum SolarEngineUserDeleteType // TypeDefIndex: 26050
{
	// Fields
	public int value__; // 0x0
	public const SolarEngineUserDeleteType ByAccountId = 0;
	public const SolarEngineUserDeleteType ByVisitorId = 1;
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
public enum SolarEnginePayStatus // TypeDefIndex: 26051
{
	// Fields
	public int value__; // 0x0
	public const SolarEnginePayStatus Success = 1;
	public const SolarEnginePayStatus Fail = 2;
	public const SolarEnginePayStatus Restored = 3;
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public sealed class SolarEngineAttributionResult // TypeDefIndex: 26052
{
	// Fields
	[CompilerGenerated]
	private int <Code>k__BackingField; // 0x10
	[CompilerGenerated]
	private Dictionary<string, object> <Attribution>k__BackingField; // 0x18

	// Properties
	[Preserve]
	public int Code { get; set; }
	[Preserve]
	public Dictionary<string, object> Attribution { get; set; }
	[Preserve]
	public bool IsSuccess { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6418CC8 Offset: 0x6414CC8 VA: 0x6418CC8
	public int get_Code() { }

	[CompilerGenerated]
	// RVA: 0x6418CD0 Offset: 0x6414CD0 VA: 0x6418CD0
	public void set_Code(int value) { }

	[CompilerGenerated]
	// RVA: 0x6418CD8 Offset: 0x6414CD8 VA: 0x6418CD8
	public Dictionary<string, object> get_Attribution() { }

	[CompilerGenerated]
	// RVA: 0x6418CE0 Offset: 0x6414CE0 VA: 0x6418CE0
	public void set_Attribution(Dictionary<string, object> value) { }

	// RVA: 0x6418CE8 Offset: 0x6414CE8 VA: 0x6418CE8
	public bool get_IsSuccess() { }

	// RVA: 0x6418CF8 Offset: 0x6414CF8 VA: 0x6418CF8
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public sealed class SolarEngineDeepLinkResult // TypeDefIndex: 26053
{
	// Fields
	[CompilerGenerated]
	private int <Code>k__BackingField; // 0x10
	[CompilerGenerated]
	private Dictionary<string, object> <Data>k__BackingField; // 0x18

	// Properties
	[Preserve]
	public int Code { get; set; }
	[Preserve]
	public Dictionary<string, object> Data { get; set; }
	[Preserve]
	public bool IsSuccess { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6418D00 Offset: 0x6414D00 VA: 0x6418D00
	public int get_Code() { }

	[CompilerGenerated]
	// RVA: 0x6418D08 Offset: 0x6414D08 VA: 0x6418D08
	public void set_Code(int value) { }

	[CompilerGenerated]
	// RVA: 0x6418D10 Offset: 0x6414D10 VA: 0x6418D10
	public Dictionary<string, object> get_Data() { }

	[CompilerGenerated]
	// RVA: 0x6418D18 Offset: 0x6414D18 VA: 0x6418D18
	public void set_Data(Dictionary<string, object> value) { }

	// RVA: 0x6418D20 Offset: 0x6414D20 VA: 0x6418D20
	public bool get_IsSuccess() { }

	// RVA: 0x6418D30 Offset: 0x6414D30 VA: 0x6418D30
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public sealed class SolarEngineSkanResult // TypeDefIndex: 26054
{
	// Fields
	[CompilerGenerated]
	private int <ErrorCode>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <ErrorMessage>k__BackingField; // 0x18

	// Properties
	[Preserve]
	public int ErrorCode { get; set; }
	[Preserve]
	public string ErrorMessage { get; set; }
	[Preserve]
	public bool IsSuccess { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6418D38 Offset: 0x6414D38 VA: 0x6418D38
	public int get_ErrorCode() { }

	[CompilerGenerated]
	// RVA: 0x6418D40 Offset: 0x6414D40 VA: 0x6418D40
	public void set_ErrorCode(int value) { }

	[CompilerGenerated]
	// RVA: 0x6418D48 Offset: 0x6414D48 VA: 0x6418D48
	public string get_ErrorMessage() { }

	[CompilerGenerated]
	// RVA: 0x6418D50 Offset: 0x6414D50 VA: 0x6418D50
	public void set_ErrorMessage(string value) { }

	// RVA: 0x6418D58 Offset: 0x6414D58 VA: 0x6418D58
	public bool get_IsSuccess() { }

	// RVA: 0x6418D68 Offset: 0x6414D68 VA: 0x6418D68
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public class SolarEngineEventArgs // TypeDefIndex: 26055
{
	// Fields
	[CompilerGenerated]
	private Dictionary<string, object> <CustomProperties>k__BackingField; // 0x10

	// Properties
	[Preserve]
	public Dictionary<string, object> CustomProperties { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6418D70 Offset: 0x6414D70 VA: 0x6418D70
	public Dictionary<string, object> get_CustomProperties() { }

	[CompilerGenerated]
	// RVA: 0x6418D78 Offset: 0x6414D78 VA: 0x6418D78
	public void set_CustomProperties(Dictionary<string, object> value) { }

	// RVA: 0x6418D80 Offset: 0x6414D80 VA: 0x6418D80
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public sealed class SolarEngineFirstCustomEventArgs : SolarEngineEventArgs // TypeDefIndex: 26056
{
	// Fields
	[CompilerGenerated]
	private string <EventName>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <CheckId>k__BackingField; // 0x20
	[CompilerGenerated]
	private Dictionary<string, object> <PresetProperties>k__BackingField; // 0x28

	// Properties
	[Preserve]
	public string EventName { get; set; }
	[Preserve]
	public string CheckId { get; set; }
	[Preserve]
	public Dictionary<string, object> PresetProperties { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6418D88 Offset: 0x6414D88 VA: 0x6418D88
	public string get_EventName() { }

	[CompilerGenerated]
	// RVA: 0x6418D90 Offset: 0x6414D90 VA: 0x6418D90
	public void set_EventName(string value) { }

	[CompilerGenerated]
	// RVA: 0x6418D98 Offset: 0x6414D98 VA: 0x6418D98
	public string get_CheckId() { }

	[CompilerGenerated]
	// RVA: 0x6418DA0 Offset: 0x6414DA0 VA: 0x6418DA0
	public void set_CheckId(string value) { }

	[CompilerGenerated]
	// RVA: 0x6418DA8 Offset: 0x6414DA8 VA: 0x6418DA8
	public Dictionary<string, object> get_PresetProperties() { }

	[CompilerGenerated]
	// RVA: 0x6418DB0 Offset: 0x6414DB0 VA: 0x6418DB0
	public void set_PresetProperties(Dictionary<string, object> value) { }

	// RVA: 0x6418DB8 Offset: 0x6414DB8 VA: 0x6418DB8
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public sealed class SolarEnginePurchaseEventArgs : SolarEngineEventArgs // TypeDefIndex: 26057
{
	// Fields
	[CompilerGenerated]
	private string <ProductName>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <ProductId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ProductCount>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <Currency>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <OrderId>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <FailureReason>k__BackingField; // 0x40
	[CompilerGenerated]
	private SolarEnginePayStatus <Status>k__BackingField; // 0x48
	[CompilerGenerated]
	private string <PaymentType>k__BackingField; // 0x50
	[CompilerGenerated]
	private double <Amount>k__BackingField; // 0x58
	[CompilerGenerated]
	private int <ReportToTencent>k__BackingField; // 0x60

	// Properties
	[Preserve]
	public string ProductName { get; set; }
	[Preserve]
	public string ProductId { get; set; }
	[Preserve]
	public int ProductCount { get; set; }
	[Preserve]
	public string Currency { get; set; }
	[Preserve]
	public string OrderId { get; set; }
	[Preserve]
	public string FailureReason { get; set; }
	[Preserve]
	public SolarEnginePayStatus Status { get; set; }
	[Preserve]
	public string PaymentType { get; set; }
	[Preserve]
	public double Amount { get; set; }
	[Preserve]
	public int ReportToTencent { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6418DC0 Offset: 0x6414DC0 VA: 0x6418DC0
	public string get_ProductName() { }

	[CompilerGenerated]
	// RVA: 0x6418DC8 Offset: 0x6414DC8 VA: 0x6418DC8
	public void set_ProductName(string value) { }

	[CompilerGenerated]
	// RVA: 0x6418DD0 Offset: 0x6414DD0 VA: 0x6418DD0
	public string get_ProductId() { }

	[CompilerGenerated]
	// RVA: 0x6418DD8 Offset: 0x6414DD8 VA: 0x6418DD8
	public void set_ProductId(string value) { }

	[CompilerGenerated]
	// RVA: 0x6418DE0 Offset: 0x6414DE0 VA: 0x6418DE0
	public int get_ProductCount() { }

	[CompilerGenerated]
	// RVA: 0x6418DE8 Offset: 0x6414DE8 VA: 0x6418DE8
	public void set_ProductCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x6418DF0 Offset: 0x6414DF0 VA: 0x6418DF0
	public string get_Currency() { }

	[CompilerGenerated]
	// RVA: 0x6418DF8 Offset: 0x6414DF8 VA: 0x6418DF8
	public void set_Currency(string value) { }

	[CompilerGenerated]
	// RVA: 0x6418E00 Offset: 0x6414E00 VA: 0x6418E00
	public string get_OrderId() { }

	[CompilerGenerated]
	// RVA: 0x6418E08 Offset: 0x6414E08 VA: 0x6418E08
	public void set_OrderId(string value) { }

	[CompilerGenerated]
	// RVA: 0x6418E10 Offset: 0x6414E10 VA: 0x6418E10
	public string get_FailureReason() { }

	[CompilerGenerated]
	// RVA: 0x6418E18 Offset: 0x6414E18 VA: 0x6418E18
	public void set_FailureReason(string value) { }

	[CompilerGenerated]
	// RVA: 0x6418E20 Offset: 0x6414E20 VA: 0x6418E20
	public SolarEnginePayStatus get_Status() { }

	[CompilerGenerated]
	// RVA: 0x6418E28 Offset: 0x6414E28 VA: 0x6418E28
	public void set_Status(SolarEnginePayStatus value) { }

	[CompilerGenerated]
	// RVA: 0x6418E30 Offset: 0x6414E30 VA: 0x6418E30
	public string get_PaymentType() { }

	[CompilerGenerated]
	// RVA: 0x6418E38 Offset: 0x6414E38 VA: 0x6418E38
	public void set_PaymentType(string value) { }

	[CompilerGenerated]
	// RVA: 0x6418E40 Offset: 0x6414E40 VA: 0x6418E40
	public double get_Amount() { }

	[CompilerGenerated]
	// RVA: 0x6418E48 Offset: 0x6414E48 VA: 0x6418E48
	public void set_Amount(double value) { }

	[CompilerGenerated]
	// RVA: 0x6418E50 Offset: 0x6414E50 VA: 0x6418E50
	public int get_ReportToTencent() { }

	[CompilerGenerated]
	// RVA: 0x6418E58 Offset: 0x6414E58 VA: 0x6418E58
	public void set_ReportToTencent(int value) { }

	// RVA: 0x6418E60 Offset: 0x6414E60 VA: 0x6418E60
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public sealed class SolarEngineAdImpressionEventArgs : SolarEngineEventArgs // TypeDefIndex: 26058
{
	// Fields
	[CompilerGenerated]
	private string <AdPlatform>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <MediationPlatform>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <AdAppId>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <AdPlacementId>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <AdType>k__BackingField; // 0x38
	[CompilerGenerated]
	private double <Ecpm>k__BackingField; // 0x40
	[CompilerGenerated]
	private string <Currency>k__BackingField; // 0x48
	[CompilerGenerated]
	private bool <IsRendered>k__BackingField; // 0x50

	// Properties
	[Preserve]
	public string AdPlatform { get; set; }
	[Preserve]
	public string MediationPlatform { get; set; }
	[Preserve]
	public string AdAppId { get; set; }
	[Preserve]
	public string AdPlacementId { get; set; }
	[Preserve]
	public int AdType { get; set; }
	[Preserve]
	public double Ecpm { get; set; }
	[Preserve]
	public string Currency { get; set; }
	[Preserve]
	public bool IsRendered { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6418E68 Offset: 0x6414E68 VA: 0x6418E68
	public string get_AdPlatform() { }

	[CompilerGenerated]
	// RVA: 0x6418E70 Offset: 0x6414E70 VA: 0x6418E70
	public void set_AdPlatform(string value) { }

	[CompilerGenerated]
	// RVA: 0x6418E78 Offset: 0x6414E78 VA: 0x6418E78
	public string get_MediationPlatform() { }

	[CompilerGenerated]
	// RVA: 0x6418E80 Offset: 0x6414E80 VA: 0x6418E80
	public void set_MediationPlatform(string value) { }

	[CompilerGenerated]
	// RVA: 0x6418E88 Offset: 0x6414E88 VA: 0x6418E88
	public string get_AdAppId() { }

	[CompilerGenerated]
	// RVA: 0x6418E90 Offset: 0x6414E90 VA: 0x6418E90
	public void set_AdAppId(string value) { }

	[CompilerGenerated]
	// RVA: 0x6418E98 Offset: 0x6414E98 VA: 0x6418E98
	public string get_AdPlacementId() { }

	[CompilerGenerated]
	// RVA: 0x6418EA0 Offset: 0x6414EA0 VA: 0x6418EA0
	public void set_AdPlacementId(string value) { }

	[CompilerGenerated]
	// RVA: 0x6418EA8 Offset: 0x6414EA8 VA: 0x6418EA8
	public int get_AdType() { }

	[CompilerGenerated]
	// RVA: 0x6418EB0 Offset: 0x6414EB0 VA: 0x6418EB0
	public void set_AdType(int value) { }

	[CompilerGenerated]
	// RVA: 0x6418EB8 Offset: 0x6414EB8 VA: 0x6418EB8
	public double get_Ecpm() { }

	[CompilerGenerated]
	// RVA: 0x6418EC0 Offset: 0x6414EC0 VA: 0x6418EC0
	public void set_Ecpm(double value) { }

	[CompilerGenerated]
	// RVA: 0x6418EC8 Offset: 0x6414EC8 VA: 0x6418EC8
	public string get_Currency() { }

	[CompilerGenerated]
	// RVA: 0x6418ED0 Offset: 0x6414ED0 VA: 0x6418ED0
	public void set_Currency(string value) { }

	[CompilerGenerated]
	// RVA: 0x6418ED8 Offset: 0x6414ED8 VA: 0x6418ED8
	public bool get_IsRendered() { }

	[CompilerGenerated]
	// RVA: 0x6418EE0 Offset: 0x6414EE0 VA: 0x6418EE0
	public void set_IsRendered(bool value) { }

	// RVA: 0x6418EEC Offset: 0x6414EEC VA: 0x6418EEC
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public sealed class SolarEngineAdClickEventArgs : SolarEngineEventArgs // TypeDefIndex: 26059
{
	// Fields
	[CompilerGenerated]
	private string <AdPlatform>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <MediationPlatform>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <AdPlacementId>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <AdType>k__BackingField; // 0x30

	// Properties
	[Preserve]
	public string AdPlatform { get; set; }
	[Preserve]
	public string MediationPlatform { get; set; }
	[Preserve]
	public string AdPlacementId { get; set; }
	[Preserve]
	public int AdType { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6418EF4 Offset: 0x6414EF4 VA: 0x6418EF4
	public string get_AdPlatform() { }

	[CompilerGenerated]
	// RVA: 0x6418EFC Offset: 0x6414EFC VA: 0x6418EFC
	public void set_AdPlatform(string value) { }

	[CompilerGenerated]
	// RVA: 0x6418F04 Offset: 0x6414F04 VA: 0x6418F04
	public string get_MediationPlatform() { }

	[CompilerGenerated]
	// RVA: 0x6418F0C Offset: 0x6414F0C VA: 0x6418F0C
	public void set_MediationPlatform(string value) { }

	[CompilerGenerated]
	// RVA: 0x6418F14 Offset: 0x6414F14 VA: 0x6418F14
	public string get_AdPlacementId() { }

	[CompilerGenerated]
	// RVA: 0x6418F1C Offset: 0x6414F1C VA: 0x6418F1C
	public void set_AdPlacementId(string value) { }

	[CompilerGenerated]
	// RVA: 0x6418F24 Offset: 0x6414F24 VA: 0x6418F24
	public int get_AdType() { }

	[CompilerGenerated]
	// RVA: 0x6418F2C Offset: 0x6414F2C VA: 0x6418F2C
	public void set_AdType(int value) { }

	// RVA: 0x6418F34 Offset: 0x6414F34 VA: 0x6418F34
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public sealed class SolarEngineRegisterEventArgs : SolarEngineEventArgs // TypeDefIndex: 26060
{
	// Fields
	[CompilerGenerated]
	private string <RegisterType>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <RegisterStatus>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <CheckId>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <ReportToTencent>k__BackingField; // 0x30

	// Properties
	[Preserve]
	public string RegisterType { get; set; }
	[Preserve]
	public string RegisterStatus { get; set; }
	[Preserve]
	public string CheckId { get; set; }
	[Preserve]
	public int ReportToTencent { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6418F3C Offset: 0x6414F3C VA: 0x6418F3C
	public string get_RegisterType() { }

	[CompilerGenerated]
	// RVA: 0x6418F44 Offset: 0x6414F44 VA: 0x6418F44
	public void set_RegisterType(string value) { }

	[CompilerGenerated]
	// RVA: 0x6418F4C Offset: 0x6414F4C VA: 0x6418F4C
	public string get_RegisterStatus() { }

	[CompilerGenerated]
	// RVA: 0x6418F54 Offset: 0x6414F54 VA: 0x6418F54
	public void set_RegisterStatus(string value) { }

	[CompilerGenerated]
	// RVA: 0x6418F5C Offset: 0x6414F5C VA: 0x6418F5C
	public string get_CheckId() { }

	[CompilerGenerated]
	// RVA: 0x6418F64 Offset: 0x6414F64 VA: 0x6418F64
	public void set_CheckId(string value) { }

	[CompilerGenerated]
	// RVA: 0x6418F6C Offset: 0x6414F6C VA: 0x6418F6C
	public int get_ReportToTencent() { }

	[CompilerGenerated]
	// RVA: 0x6418F74 Offset: 0x6414F74 VA: 0x6418F74
	public void set_ReportToTencent(int value) { }

	// RVA: 0x6418F7C Offset: 0x6414F7C VA: 0x6418F7C
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public sealed class SolarEngineLoginEventArgs : SolarEngineEventArgs // TypeDefIndex: 26061
{
	// Fields
	[CompilerGenerated]
	private string <LoginType>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <LoginStatus>k__BackingField; // 0x20

	// Properties
	[Preserve]
	public string LoginType { get; set; }
	[Preserve]
	public string LoginStatus { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6418F84 Offset: 0x6414F84 VA: 0x6418F84
	public string get_LoginType() { }

	[CompilerGenerated]
	// RVA: 0x6418F8C Offset: 0x6414F8C VA: 0x6418F8C
	public void set_LoginType(string value) { }

	[CompilerGenerated]
	// RVA: 0x6418F94 Offset: 0x6414F94 VA: 0x6418F94
	public string get_LoginStatus() { }

	[CompilerGenerated]
	// RVA: 0x6418F9C Offset: 0x6414F9C VA: 0x6418F9C
	public void set_LoginStatus(string value) { }

	// RVA: 0x6418FA4 Offset: 0x6414FA4 VA: 0x6418FA4
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public sealed class SolarEngineOrderEventArgs : SolarEngineEventArgs // TypeDefIndex: 26062
{
	// Fields
	[CompilerGenerated]
	private string <OrderId>k__BackingField; // 0x18
	[CompilerGenerated]
	private double <Amount>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Currency>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <PaymentType>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <Status>k__BackingField; // 0x38

	// Properties
	[Preserve]
	public string OrderId { get; set; }
	[Preserve]
	public double Amount { get; set; }
	[Preserve]
	public string Currency { get; set; }
	[Preserve]
	public string PaymentType { get; set; }
	[Preserve]
	public string Status { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6418FAC Offset: 0x6414FAC VA: 0x6418FAC
	public string get_OrderId() { }

	[CompilerGenerated]
	// RVA: 0x6418FB4 Offset: 0x6414FB4 VA: 0x6418FB4
	public void set_OrderId(string value) { }

	[CompilerGenerated]
	// RVA: 0x6418FBC Offset: 0x6414FBC VA: 0x6418FBC
	public double get_Amount() { }

	[CompilerGenerated]
	// RVA: 0x6418FC4 Offset: 0x6414FC4 VA: 0x6418FC4
	public void set_Amount(double value) { }

	[CompilerGenerated]
	// RVA: 0x6418FCC Offset: 0x6414FCC VA: 0x6418FCC
	public string get_Currency() { }

	[CompilerGenerated]
	// RVA: 0x6418FD4 Offset: 0x6414FD4 VA: 0x6418FD4
	public void set_Currency(string value) { }

	[CompilerGenerated]
	// RVA: 0x6418FDC Offset: 0x6414FDC VA: 0x6418FDC
	public string get_PaymentType() { }

	[CompilerGenerated]
	// RVA: 0x6418FE4 Offset: 0x6414FE4 VA: 0x6418FE4
	public void set_PaymentType(string value) { }

	[CompilerGenerated]
	// RVA: 0x6418FEC Offset: 0x6414FEC VA: 0x6418FEC
	public string get_Status() { }

	[CompilerGenerated]
	// RVA: 0x6418FF4 Offset: 0x6414FF4 VA: 0x6418FF4
	public void set_Status(string value) { }

	// RVA: 0x6418FFC Offset: 0x6414FFC VA: 0x6418FFC
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public sealed class SolarEngineAttributionEventArgs : SolarEngineEventArgs // TypeDefIndex: 26063
{
	// Fields
	[CompilerGenerated]
	private string <AdNetwork>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <SubChannel>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <AdAccountId>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <AdAccountName>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <AdCampaignId>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <AdCampaignName>k__BackingField; // 0x40
	[CompilerGenerated]
	private string <AdOfferId>k__BackingField; // 0x48
	[CompilerGenerated]
	private string <AdOfferName>k__BackingField; // 0x50
	[CompilerGenerated]
	private string <AdCreativeId>k__BackingField; // 0x58
	[CompilerGenerated]
	private string <AdCreativeName>k__BackingField; // 0x60
	[CompilerGenerated]
	private string <AttributionPlatform>k__BackingField; // 0x68

	// Properties
	[Preserve]
	public string AdNetwork { get; set; }
	[Preserve]
	public string SubChannel { get; set; }
	[Preserve]
	public string AdAccountId { get; set; }
	[Preserve]
	public string AdAccountName { get; set; }
	[Preserve]
	public string AdCampaignId { get; set; }
	[Preserve]
	public string AdCampaignName { get; set; }
	[Preserve]
	public string AdOfferId { get; set; }
	[Preserve]
	public string AdOfferName { get; set; }
	[Preserve]
	public string AdCreativeId { get; set; }
	[Preserve]
	public string AdCreativeName { get; set; }
	[Preserve]
	public string AttributionPlatform { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6419004 Offset: 0x6415004 VA: 0x6419004
	public string get_AdNetwork() { }

	[CompilerGenerated]
	// RVA: 0x641900C Offset: 0x641500C VA: 0x641900C
	public void set_AdNetwork(string value) { }

	[CompilerGenerated]
	// RVA: 0x6419014 Offset: 0x6415014 VA: 0x6419014
	public string get_SubChannel() { }

	[CompilerGenerated]
	// RVA: 0x641901C Offset: 0x641501C VA: 0x641901C
	public void set_SubChannel(string value) { }

	[CompilerGenerated]
	// RVA: 0x6419024 Offset: 0x6415024 VA: 0x6419024
	public string get_AdAccountId() { }

	[CompilerGenerated]
	// RVA: 0x641902C Offset: 0x641502C VA: 0x641902C
	public void set_AdAccountId(string value) { }

	[CompilerGenerated]
	// RVA: 0x6419034 Offset: 0x6415034 VA: 0x6419034
	public string get_AdAccountName() { }

	[CompilerGenerated]
	// RVA: 0x641903C Offset: 0x641503C VA: 0x641903C
	public void set_AdAccountName(string value) { }

	[CompilerGenerated]
	// RVA: 0x6419044 Offset: 0x6415044 VA: 0x6419044
	public string get_AdCampaignId() { }

	[CompilerGenerated]
	// RVA: 0x641904C Offset: 0x641504C VA: 0x641904C
	public void set_AdCampaignId(string value) { }

	[CompilerGenerated]
	// RVA: 0x6419054 Offset: 0x6415054 VA: 0x6419054
	public string get_AdCampaignName() { }

	[CompilerGenerated]
	// RVA: 0x641905C Offset: 0x641505C VA: 0x641905C
	public void set_AdCampaignName(string value) { }

	[CompilerGenerated]
	// RVA: 0x6419064 Offset: 0x6415064 VA: 0x6419064
	public string get_AdOfferId() { }

	[CompilerGenerated]
	// RVA: 0x641906C Offset: 0x641506C VA: 0x641906C
	public void set_AdOfferId(string value) { }

	[CompilerGenerated]
	// RVA: 0x6419074 Offset: 0x6415074 VA: 0x6419074
	public string get_AdOfferName() { }

	[CompilerGenerated]
	// RVA: 0x641907C Offset: 0x641507C VA: 0x641907C
	public void set_AdOfferName(string value) { }

	[CompilerGenerated]
	// RVA: 0x6419084 Offset: 0x6415084 VA: 0x6419084
	public string get_AdCreativeId() { }

	[CompilerGenerated]
	// RVA: 0x641908C Offset: 0x641508C VA: 0x641908C
	public void set_AdCreativeId(string value) { }

	[CompilerGenerated]
	// RVA: 0x6419094 Offset: 0x6415094 VA: 0x6419094
	public string get_AdCreativeName() { }

	[CompilerGenerated]
	// RVA: 0x641909C Offset: 0x641509C VA: 0x641909C
	public void set_AdCreativeName(string value) { }

	[CompilerGenerated]
	// RVA: 0x64190A4 Offset: 0x64150A4 VA: 0x64190A4
	public string get_AttributionPlatform() { }

	[CompilerGenerated]
	// RVA: 0x64190AC Offset: 0x64150AC VA: 0x64190AC
	public void set_AttributionPlatform(string value) { }

	// RVA: 0x64190B4 Offset: 0x64150B4 VA: 0x64190B4
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public class SolarEngineTencentEventArgs : SolarEngineEventArgs // TypeDefIndex: 26064
{
	// Fields
	[CompilerGenerated]
	private int <ReportToTencent>k__BackingField; // 0x18

	// Properties
	[Preserve]
	public int ReportToTencent { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x64190BC Offset: 0x64150BC VA: 0x64190BC
	public int get_ReportToTencent() { }

	[CompilerGenerated]
	// RVA: 0x64190C4 Offset: 0x64150C4 VA: 0x64190C4
	public void set_ReportToTencent(int value) { }

	// RVA: 0x64190CC Offset: 0x64150CC VA: 0x64190CC
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public sealed class SolarEngineReActiveEventArgs : SolarEngineTencentEventArgs // TypeDefIndex: 26065
{
	// Fields
	[CompilerGenerated]
	private int <BackFlowDay>k__BackingField; // 0x1C

	// Properties
	[Preserve]
	public int BackFlowDay { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x64190D4 Offset: 0x64150D4 VA: 0x64190D4
	public int get_BackFlowDay() { }

	[CompilerGenerated]
	// RVA: 0x64190DC Offset: 0x64150DC VA: 0x64190DC
	public void set_BackFlowDay(int value) { }

	// RVA: 0x64190E4 Offset: 0x64150E4 VA: 0x64190E4
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public sealed class SolarEngineWishlistEventArgs : SolarEngineTencentEventArgs // TypeDefIndex: 26066
{
	// Fields
	[CompilerGenerated]
	private string <WishlistType>k__BackingField; // 0x20

	// Properties
	[Preserve]
	public string WishlistType { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x64190EC Offset: 0x64150EC VA: 0x64190EC
	public string get_WishlistType() { }

	[CompilerGenerated]
	// RVA: 0x64190F4 Offset: 0x64150F4 VA: 0x64190F4
	public void set_WishlistType(string value) { }

	// RVA: 0x64190FC Offset: 0x64150FC VA: 0x64190FC
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public sealed class SolarEngineShareEventArgs : SolarEngineTencentEventArgs // TypeDefIndex: 26067
{
	// Fields
	[CompilerGenerated]
	private string <ShareTarget>k__BackingField; // 0x20

	// Properties
	[Preserve]
	public string ShareTarget { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6419104 Offset: 0x6415104 VA: 0x6419104
	public string get_ShareTarget() { }

	[CompilerGenerated]
	// RVA: 0x641910C Offset: 0x641510C VA: 0x641910C
	public void set_ShareTarget(string value) { }

	// RVA: 0x6419114 Offset: 0x6415114 VA: 0x6419114
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public sealed class SolarEngineCreateRoleEventArgs : SolarEngineTencentEventArgs // TypeDefIndex: 26068
{
	// Fields
	[CompilerGenerated]
	private string <RoleName>k__BackingField; // 0x20

	// Properties
	[Preserve]
	public string RoleName { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x641911C Offset: 0x641511C VA: 0x641911C
	public string get_RoleName() { }

	[CompilerGenerated]
	// RVA: 0x6419124 Offset: 0x6415124 VA: 0x6419124
	public void set_RoleName(string value) { }

	// RVA: 0x641912C Offset: 0x641512C VA: 0x641912C
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public sealed class SolarEngineUpdateLevelEventArgs : SolarEngineTencentEventArgs // TypeDefIndex: 26069
{
	// Fields
	[CompilerGenerated]
	private int <BeforeLevel>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <AfterLevel>k__BackingField; // 0x20

	// Properties
	[Preserve]
	public int BeforeLevel { get; set; }
	[Preserve]
	public int AfterLevel { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6419134 Offset: 0x6415134 VA: 0x6419134
	public int get_BeforeLevel() { }

	[CompilerGenerated]
	// RVA: 0x641913C Offset: 0x641513C VA: 0x641913C
	public void set_BeforeLevel(int value) { }

	[CompilerGenerated]
	// RVA: 0x6419144 Offset: 0x6415144 VA: 0x6419144
	public int get_AfterLevel() { }

	[CompilerGenerated]
	// RVA: 0x641914C Offset: 0x641514C VA: 0x641914C
	public void set_AfterLevel(int value) { }

	// RVA: 0x6419154 Offset: 0x6415154 VA: 0x6419154
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public class TokenInfo // TypeDefIndex: 26070
{
	// Fields
	[Preserve]
	public string accessToken; // 0x10
	[Preserve]
	public string expiresIn; // 0x18
	[Preserve]
	public long serverTime; // 0x20

	// Methods

	// RVA: 0x6418B1C Offset: 0x6414B1C VA: 0x6418B1C
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public class WeChatLoginResult // TypeDefIndex: 26071
{
	// Fields
	[Preserve]
	public string code; // 0x10
	[Preserve]
	public string lang; // 0x18
	[Preserve]
	public string country; // 0x20

	// Methods

	// RVA: 0x641915C Offset: 0x641515C VA: 0x641915C Slot: 3
	public override string ToString() { }

	// RVA: 0x6419168 Offset: 0x6415168 VA: 0x6419168
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public class WeChatPurchaseArgs : PurchaseArgs // TypeDefIndex: 26072
{
	// Fields
	[Preserve]
	public string partnerId; // 0x30
	[Preserve]
	public string prepayId; // 0x38
	[Preserve]
	public string nonceStr; // 0x40
	[Preserve]
	public string timeStamp; // 0x48
	[Preserve]
	public string package; // 0x50
	[Preserve]
	public string sign; // 0x58

	// Methods

	// RVA: 0x6419170 Offset: 0x6415170 VA: 0x6419170
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Model
[Preserve]
[Serializable]
public class WeChatPurchaseResult // TypeDefIndex: 26073
{
	// Fields
	[Preserve]
	public string returnKey; // 0x10

	// Methods

	// RVA: 0x6419174 Offset: 0x6415174 VA: 0x6419174
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Log
public static class GLog // TypeDefIndex: 26074
{
	// Fields
	private static readonly object SegmentedLogLock; // 0x0
	private static bool _enable; // 0x8

	// Methods

	// RVA: 0x641917C Offset: 0x641517C VA: 0x641917C
	public static void SetEnable(bool enable) { }

	// RVA: 0x640E568 Offset: 0x640A568 VA: 0x640E568
	public static void Info(string message) { }

	// RVA: 0x6407F74 Offset: 0x6403F74 VA: 0x6407F74
	public static void Warn(string message) { }

	// RVA: 0x64092FC Offset: 0x64052FC VA: 0x64092FC
	public static void Error(string message) { }

	// RVA: 0x64191DC Offset: 0x64151DC VA: 0x64191DC
	private static void LogSegmented(string message, Action<object> logAction, LogType logType) { }

	// RVA: 0x6419614 Offset: 0x6415614 VA: 0x6419614
	internal static string FormatSegment(string segment, bool isFirstSegment) { }

	// RVA: 0x64194AC Offset: 0x64154AC VA: 0x64194AC
	internal static List<string> SplitMessage(string message) { }

	// RVA: 0x6419678 Offset: 0x6415678 VA: 0x6419678
	private static int FindSegmentLength(string message, int startIndex) { }

	// RVA: 0x6419814 Offset: 0x6415814 VA: 0x6419814
	private static void .cctor() { }
}

// Namespace: GorillaBase.Runtime.Extensions
[Extension]
public static class ExceptionExtension // TypeDefIndex: 26075
{
	// Methods

	[Extension]
	// RVA: 0x64198A4 Offset: 0x64158A4 VA: 0x64198A4
	public static ValueTuple<int, string> ResolveError(Exception exception, string tag, bool handleAPIException = True) { }
}

// Namespace: GorillaBase.Runtime.Ability
[IsReadOnly]
public struct AccountServiceProvider // TypeDefIndex: 26076
{
	// Fields
	public readonly string ProviderId; // 0x0
	public readonly int Priority; // 0x8
	public readonly Func<IAccountService> Factory; // 0x10
	public readonly bool AutoSelectable; // 0x18

	// Methods

	// RVA: 0x6419B20 Offset: 0x6415B20 VA: 0x6419B20
	public void .ctor(string providerId, int priority, Func<IAccountService> factory, bool autoSelectable) { }
}

// Namespace: GorillaBase.Runtime.Ability
public static class AccountServiceRegistry // TypeDefIndex: 26077
{
	// Fields
	private static readonly Dictionary<string, AccountServiceProvider> Providers; // 0x0
	[CompilerGenerated]
	private static string <SelectedProviderId>k__BackingField; // 0x8

	// Properties
	private static string SelectedProviderId { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6419B6C Offset: 0x6415B6C VA: 0x6419B6C
	private static void set_SelectedProviderId(string value) { }

	// RVA: 0x6419BCC Offset: 0x6415BCC VA: 0x6419BCC
	public static void Register(GorillaAccountProvider provider, Func<IAccountService> factory, bool autoSelectable = True) { }

	// RVA: 0x6419C4C Offset: 0x6415C4C VA: 0x6419C4C
	private static void RegisterCore(string providerId, int priority, Func<IAccountService> factory, bool autoSelectable) { }

	// RVA: 0x6406A6C Offset: 0x6402A6C VA: 0x6406A6C
	public static IAccountService Resolve(SDKConfig config) { }

	// RVA: 0x6419DEC Offset: 0x6415DEC VA: 0x6419DEC
	private static bool TryGetProvider(SDKConfig config, out AccountServiceProvider provider, bool logMissingProvider) { }

	// RVA: 0x641A2DC Offset: 0x64162DC VA: 0x641A2DC
	private static bool TryGetBestAutoProvider(out AccountServiceProvider bestProvider) { }

	// RVA: 0x6419F2C Offset: 0x6415F2C VA: 0x6419F2C
	private static IAccountService Create(AccountServiceProvider provider) { }

	// RVA: 0x641A1B8 Offset: 0x64161B8 VA: 0x641A1B8
	private static IAccountService CreateDefault() { }

	// RVA: 0x641A580 Offset: 0x6416580 VA: 0x641A580
	private static void .cctor() { }
}

// Namespace: GorillaBase.Runtime.Ability
public interface IAccountService // TypeDefIndex: 26078
{
	// Properties
	public abstract IAccountServiceExtension Extension { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IAccountServiceExtension get_Extension();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Init(SDKConfig config, Action<bool> callback);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Login(LoginArgs args);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Logout();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Bind(BindArgs args);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void DeleteAccount(Action<bool> onFinish);
}

// Namespace: GorillaBase.Runtime.Ability
public interface IAccountServiceExtension // TypeDefIndex: 26079
{}

// Namespace: GorillaBase.Runtime.Ability
public interface IAccountServiceChinaExtension : IAccountServiceExtension // TypeDefIndex: 26080
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OpenUserCenter(OpenUserCenterArgs args);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OpenAntiAddictionTip(Action onClose);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OpenDebugger();
}

// Namespace: GorillaBase.Runtime.Ability
public interface IAnalytics // TypeDefIndex: 26081
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Init(object data);
}

// Namespace: GorillaBase.Runtime.Ability
public interface IAppsFlyerAnalytics : IAnalytics // TypeDefIndex: 26082
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string GetAppsFlyerId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetCustomUserId(string userId);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SetConsent(bool isConsent = True);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Track(string eventId, Dictionary<string, string> payload);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void TrackPurchase(string currency, Decimal revenue, string contentId, string quality = "1");
}

// Namespace: GorillaBase.Runtime.Ability
public interface IAdjustAnalytics : IAnalytics // TypeDefIndex: 26083
{
	// Properties
	public abstract Action<string> OnDeepLinkCallback { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Action<string> get_OnDeepLinkCallback();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_OnDeepLinkCallback(Action<string> value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string GetAdjustId();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void TrackEvent(string eventToken, string currency = "", double amount = 0);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void AddGlobalCallbackParameter(string key, string value);
}

// Namespace: GorillaBase.Runtime.Ability
public interface IJuLiangAnalytics : IAnalytics // TypeDefIndex: 26084
{
	// Properties
	public abstract Action<Dictionary<string, object>> OnAttributionSuccess { get; set; }
	public abstract Action<JuLiangAttributionFailure> OnAttributionFailure { get; set; }
	public abstract Action<JuLiangDeepLinkResult> OnDeepLinkCallback { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Action<Dictionary<string, object>> get_OnAttributionSuccess();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_OnAttributionSuccess(Action<Dictionary<string, object>> value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Action<JuLiangAttributionFailure> get_OnAttributionFailure();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_OnAttributionFailure(Action<JuLiangAttributionFailure> value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Action<JuLiangDeepLinkResult> get_OnDeepLinkCallback();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_OnDeepLinkCallback(Action<JuLiangDeepLinkResult> value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string GetDeviceId();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string GetSDKVersion();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void SetConsent(bool isConsent);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void SetDebugLogEnabled(bool enabled);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void TrackEvent(string eventName, Dictionary<string, object> properties);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void TrackRegister(string registerMethod, bool isSuccess);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void TrackPurchase(string productType, string productName, string productId, int productCount, string payChannel, string currency, bool isSuccess, Decimal amount);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void TrackConversion(string conversionEvent, Dictionary<string, object> properties);
}

// Namespace: GorillaBase.Runtime.Ability
[Preserve]
[Serializable]
public class JuLiangAttributionFailure // TypeDefIndex: 26085
{
	// Fields
	[Preserve]
	public int Code; // 0x10
	[Preserve]
	public long HttpStatus; // 0x18
	[Preserve]
	public string Message; // 0x20
	[Preserve]
	public string RawResponse; // 0x28

	// Methods

	// RVA: 0x641A640 Offset: 0x6416640 VA: 0x641A640
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Ability
[Preserve]
[Serializable]
public class JuLiangDeepLinkResult // TypeDefIndex: 26086
{
	// Fields
	[Preserve]
	public string Url; // 0x10
	[Preserve]
	public string Scheme; // 0x18
	[Preserve]
	public string Host; // 0x20
	[Preserve]
	public string Path; // 0x28
	[Preserve]
	public Dictionary<string, string> Parameters; // 0x30
	[Preserve]
	public bool IsDeferred; // 0x38

	// Methods

	// RVA: 0x641A648 Offset: 0x6416648 VA: 0x641A648
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Ability
public interface IAppDownloadService // TypeDefIndex: 26087
{}

// Namespace: GorillaBase.Runtime.Ability
public interface ICrashReporter // TypeDefIndex: 26088
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Init(object data);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetUserId(string userId);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SetCustomKey(string key, string value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void RecordException(Exception exception);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void ReportLog(string log);
}

// Namespace: GorillaBase.Runtime.Ability
[Preserve]
[Serializable]
public sealed class DataNexusRegisterArgs // TypeDefIndex: 26089
{
	// Fields
	public string method; // 0x10
	public bool isSuccess; // 0x18

	// Methods

	// RVA: 0x641A650 Offset: 0x6416650 VA: 0x641A650
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Ability
[Preserve]
[Serializable]
public sealed class DataNexusPurchaseArgs // TypeDefIndex: 26090
{
	// Fields
	public string contentType; // 0x10
	public string contentName; // 0x18
	public string contentId; // 0x20
	public int contentNumber; // 0x28
	public string paymentChannel; // 0x30
	public string currency; // 0x38
	public int value; // 0x40
	public bool isSuccess; // 0x44

	// Methods

	// RVA: 0x641A6B0 Offset: 0x64166B0 VA: 0x641A6B0
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Ability
[Preserve]
[Serializable]
public sealed class DataNexusShareArgs // TypeDefIndex: 26091
{
	// Fields
	public string channel; // 0x10
	public bool isSuccess; // 0x18

	// Methods

	// RVA: 0x641A770 Offset: 0x6416770 VA: 0x641A770
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Ability
[Preserve]
[Serializable]
public sealed class DataNexusContentArgs // TypeDefIndex: 26092
{
	// Fields
	public string contentType; // 0x10
	public string contentName; // 0x18
	public string contentId; // 0x20

	// Methods

	// RVA: 0x641A7D0 Offset: 0x64167D0 VA: 0x641A7D0
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Ability
[Preserve]
[Serializable]
public sealed class DataNexusQuestArgs // TypeDefIndex: 26093
{
	// Fields
	public string questId; // 0x10
	public string questType; // 0x18
	public string questName; // 0x20
	public int questNumber; // 0x28
	public string description; // 0x30
	public bool isSuccess; // 0x38

	// Methods

	// RVA: 0x641A848 Offset: 0x6416848 VA: 0x641A848
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Ability
public interface IDataNexus // TypeDefIndex: 26094
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Init();
}

// Namespace: GorillaBase.Runtime.Ability
public interface IFacebook // TypeDefIndex: 26095
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Init(SDKConfig config, Action<bool> callback);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Login(LoginArgs args, Action<FacebookLoginResult> onSuccess, Action<int, string> onFailure, Action onCancel);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Logout();
}

// Namespace: GorillaBase.Runtime.Ability
[Preserve]
[Serializable]
public class FacebookProfile // TypeDefIndex: 26096
{
	// Fields
	[Preserve]
	public string userId; // 0x10
	[Preserve]
	public string name; // 0x18
	[Preserve]
	public string imageUrl; // 0x20
	[Preserve]
	public string email; // 0x28

	// Methods

	// RVA: 0x641A8F8 Offset: 0x64168F8 VA: 0x641A8F8 Slot: 3
	public override string ToString() { }

	// RVA: 0x641AAA4 Offset: 0x6416AA4 VA: 0x641AAA4
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Ability
[Preserve]
[Serializable]
public class FacebookLoginResult // TypeDefIndex: 26097
{
	// Fields
	[Preserve]
	public string userId; // 0x10
	[Preserve]
	public string appId; // 0x18
	[Preserve]
	public string accessToken; // 0x20
	[Preserve]
	public string nonce; // 0x28
	[Preserve]
	public bool isLimitedLogin; // 0x30

	// Methods

	// RVA: 0x641AAAC Offset: 0x6416AAC VA: 0x641AAAC Slot: 3
	public override string ToString() { }

	// RVA: 0x641AC7C Offset: 0x6416C7C VA: 0x641AC7C
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Ability
public interface IFirebase : ICrashReporter // TypeDefIndex: 26098
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Track(string eventName, List<KeyValuePair<string, object>> parameters);
}

// Namespace: GorillaBase.Runtime.Ability
public interface IGameTrack // TypeDefIndex: 26099
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Init(object data);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Track(string eventName, Dictionary<string, object> properties);
}

// Namespace: GorillaBase.Runtime.Ability
public interface IGameTrackStandardProperties // TypeDefIndex: 26100
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetStandardAccountKey(string accountKey);
}

// Namespace: GorillaBase.Runtime.Ability
[Extension]
public static class GameTrackStandardPropertiesExtensions // TypeDefIndex: 26101
{
	// Methods

	[Extension]
	// RVA: 0x641AC84 Offset: 0x6416C84 VA: 0x641AC84
	public static void SetStandardAccountKey(IGameTrack gameTrack, string accountKey) { }
}

// Namespace: GorillaBase.Runtime.Ability
public interface IGorillaAbilityInitializer // TypeDefIndex: 26102
{
	// Properties
	public abstract int InitializeOrder { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_InitializeOrder();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnGorillaInitialize(SDKConfig config);
}

// Namespace: GorillaBase.Runtime.Ability
public interface IGorillaAbilityLoginObserver // TypeDefIndex: 26103
{
	// Properties
	public abstract int LoginOrder { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_LoginOrder();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnGorillaLoginSucceeded(LoginResult result);
}

// Namespace: GorillaBase.Runtime.Ability
public interface IGorillaAbilityLogoutObserver // TypeDefIndex: 26104
{
	// Properties
	public abstract int LogoutOrder { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_LogoutOrder();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnGorillaLogout();
}

// Namespace: GorillaBase.Runtime.Ability
public interface IGravityEngineAnalytics // TypeDefIndex: 26105
{}

// Namespace: GorillaBase.Runtime.Ability
public class LocalNotificationConfig : ScriptableObject // TypeDefIndex: 26106
{
	// Fields
	public const string Path = "Assets/Resources/GorillaSDK/LocalNotificationSettings";
	[Header("Android")]
	public string defaultAndroidChannelId; // 0x18
	public string defaultAndroidChannelName; // 0x20
	public string defaultAndroidChannelDesc; // 0x28
	public int androidImportance; // 0x30
	[Header("iOS")]
	public bool iosShowInForeground; // 0x34
	[Header("SDK Behavior")]
	public bool dispatchRouteOnReceived; // 0x35
	public bool enableLog; // 0x36

	// Properties
	public static LocalNotificationConfig Instance { get; }

	// Methods

	// RVA: 0x641AD4C Offset: 0x6416D4C VA: 0x641AD4C
	public static LocalNotificationConfig get_Instance() { }

	// RVA: 0x641AE1C Offset: 0x6416E1C VA: 0x641AE1C
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Ability
public interface ILocalNotification // TypeDefIndex: 26107
{}

// Namespace: GorillaBase.Runtime.Ability
public interface IPrivacyPolicyService // TypeDefIndex: 26108
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Show(PrivacyPolicyRequest request, Action onPresented, Action onConfirmed, Action onCancelled, Action<int, string> onFailure);
}

// Namespace: GorillaBase.Runtime.Ability
public sealed class PurchaseEligibilityContext // TypeDefIndex: 26109
{
	// Fields
	[CompilerGenerated]
	private int <AmountFen>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <MonthlyAmountFen>k__BackingField; // 0x14

	// Properties
	public int AmountFen { get; set; }
	public int MonthlyAmountFen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x641AED4 Offset: 0x6416ED4 VA: 0x641AED4
	public int get_AmountFen() { }

	[CompilerGenerated]
	// RVA: 0x641AEDC Offset: 0x6416EDC VA: 0x641AEDC
	public void set_AmountFen(int value) { }

	[CompilerGenerated]
	// RVA: 0x641AEE4 Offset: 0x6416EE4 VA: 0x641AEE4
	public int get_MonthlyAmountFen() { }

	[CompilerGenerated]
	// RVA: 0x641AEEC Offset: 0x6416EEC VA: 0x641AEEC
	public void set_MonthlyAmountFen(int value) { }

	// RVA: 0x641AEF4 Offset: 0x6416EF4 VA: 0x641AEF4
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Ability
public sealed class PurchaseEligibilityDecision // TypeDefIndex: 26110
{
	// Fields
	[CompilerGenerated]
	private readonly bool <Allowed>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly int <Code>k__BackingField; // 0x14
	[CompilerGenerated]
	private readonly string <Message>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly bool <HandledBySdk>k__BackingField; // 0x20

	// Properties
	public bool Allowed { get; }
	public int Code { get; }
	public string Message { get; }
	public bool HandledBySdk { get; }

	// Methods

	// RVA: 0x641AEFC Offset: 0x6416EFC VA: 0x641AEFC
	private void .ctor(bool allowed, int code, string message, bool handledBySdk) { }

	[CompilerGenerated]
	// RVA: 0x641AF50 Offset: 0x6416F50 VA: 0x641AF50
	public bool get_Allowed() { }

	[CompilerGenerated]
	// RVA: 0x641AF58 Offset: 0x6416F58 VA: 0x641AF58
	public int get_Code() { }

	[CompilerGenerated]
	// RVA: 0x641AF60 Offset: 0x6416F60 VA: 0x641AF60
	public string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x641AF68 Offset: 0x6416F68 VA: 0x641AF68
	public bool get_HandledBySdk() { }

	// RVA: 0x641AF70 Offset: 0x6416F70 VA: 0x641AF70
	public static PurchaseEligibilityDecision Allow() { }

	// RVA: 0x641AFE4 Offset: 0x6416FE4 VA: 0x641AFE4
	public static PurchaseEligibilityDecision Deny(int code, string message, bool handledBySdk = False) { }
}

// Namespace: GorillaBase.Runtime.Ability
public interface IPurchaseEligibilityService // TypeDefIndex: 26111
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract PurchaseEligibilityDecision CanPurchase(PurchaseEligibilityContext context);
}

// Namespace: GorillaBase.Runtime.Ability
public interface IPushAbility // TypeDefIndex: 26112
{}

// Namespace: GorillaBase.Runtime.Ability
public interface IReviewGuideService // TypeDefIndex: 26113
{}

// Namespace: GorillaBase.Runtime.Ability
public interface IReviewService // TypeDefIndex: 26114
{}

// Namespace: GorillaBase.Runtime.Ability
public interface ISecurityConfig // TypeDefIndex: 26115
{
	// Properties
	public abstract string AesKey { get; }
	public abstract string AesIv { get; }
	public abstract string RequestSignSecret { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_AesKey();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_AesIv();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_RequestSignSecret();
}

// Namespace: GorillaBase.Runtime.Ability
public interface ISolarEngineAnalytics // TypeDefIndex: 26116
{}

// Namespace: GorillaBase.Runtime.Ability
public interface ISystemInfoAbility // TypeDefIndex: 26117
{
	// Properties
	public abstract string DeviceId { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_DeviceId();
}

// Namespace: GorillaBase.Runtime.Ability
[Preserve]
public enum ToastDuration // TypeDefIndex: 26118
{
	// Fields
	public int value__; // 0x0
	public const ToastDuration Short = 0;
	public const ToastDuration Long = 1;
}

// Namespace: GorillaBase.Runtime.Ability
public interface ISystemUIAbility // TypeDefIndex: 26119
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ShowToast(string message, ToastDuration duration = 0);
}

// Namespace: GorillaBase.Runtime.Ability
public interface IUILoadAbility // TypeDefIndex: 26120
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Task<T> LoadAsync<T>(string fileName);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IUILoadAbility.LoadAsync<object>
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class PurchaseDispatcherRegistry.<>c__DisplayClass2_0<TArgs> // TypeDefIndex: 26121
{
	// Fields
	public Action<TArgs> dispatcher; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486E204 Offset: 0x486A204 VA: 0x486E204
	|-PurchaseDispatcherRegistry.<>c__DisplayClass2_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <Register>b__0(PurchaseArgs args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486E20C Offset: 0x486A20C VA: 0x486E20C
	|-PurchaseDispatcherRegistry.<>c__DisplayClass2_0<object>.<Register>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class PurchaseDispatcherRegistry.<>c__DisplayClass3_0 // TypeDefIndex: 26122
{
	// Fields
	public Action<PurchaseArgs> dispatcher; // 0x10
	public PurchaseArgs args; // 0x18

	// Methods

	// RVA: 0x641B1D4 Offset: 0x64171D4 VA: 0x641B1D4
	public void .ctor() { }

	// RVA: 0x641B274 Offset: 0x6417274 VA: 0x641B274
	internal void <TryGet>b__0() { }
}

// Namespace: GorillaBase.Runtime.Ability
public static class PurchaseDispatcherRegistry // TypeDefIndex: 26123
{
	// Fields
	private static readonly Dictionary<Type, Action<PurchaseArgs>> Dispatchers; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static void Register<TArgs>(Action<TArgs> dispatcher) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46AF60C Offset: 0x46AB60C VA: 0x46AF60C
	|-PurchaseDispatcherRegistry.Register<object>
	*/

	// RVA: 0x641B06C Offset: 0x641706C VA: 0x641B06C
	public static bool TryGet(PurchaseArgs args, out Action payAction) { }

	// RVA: 0x641B1DC Offset: 0x64171DC VA: 0x641B1DC
	private static void .cctor() { }
}

// Namespace: GorillaBase.Runtime.Ability
[Preserve]
[Serializable]
public class PushConfig // TypeDefIndex: 26124
{
	// Fields
	[Preserve]
	public bool autoRequestPushPermission; // 0x10
	[Preserve]
	public bool autoOpenBatteryOptimizationSettings; // 0x11
	[Preserve]
	public bool autoOpenAutoStartSettings; // 0x12

	// Methods

	// RVA: 0x641B29C Offset: 0x641729C VA: 0x641B29C
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Ability
public enum PushProvider // TypeDefIndex: 26125
{
	// Fields
	public int value__; // 0x0
	public const PushProvider Firebase = 0;
	public const PushProvider XiaoMi = 1;
	public const PushProvider Huawei = 2;
}

// Namespace: 
[IsReadOnly]
private struct PushService.RegisteredPushAbility // TypeDefIndex: 26126
{
	// Fields
	[CompilerGenerated]
	private readonly PushProvider <Provider>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly IPushAbility <Ability>k__BackingField; // 0x8
}

// Namespace: GorillaBase.Runtime.Ability
public class PushService // TypeDefIndex: 26127
{
	// Fields
	private readonly Dictionary<PushProvider, PushService.RegisteredPushAbility> _abilities; // 0x10

	// Methods

	// RVA: 0x6407920 Offset: 0x6403920 VA: 0x6407920
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DefaultAccountService.<>c__DisplayClass15_0 // TypeDefIndex: 26128
{
	// Fields
	public DefaultAccountService <>4__this; // 0x10
	public GameLoginRequest request; // 0x18
	public LoginArgs args; // 0x20

	// Methods

	// RVA: 0x641B53C Offset: 0x641753C VA: 0x641B53C
	public void .ctor() { }

	// RVA: 0x641C334 Offset: 0x6418334 VA: 0x641C334
	internal Task <SendGameLoginRequest>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DefaultAccountService.<>c__DisplayClass37_0 // TypeDefIndex: 26129
{
	// Fields
	public DefaultAccountService <>4__this; // 0x10
	public BindRequest request; // 0x18
	public BindArgs args; // 0x20

	// Methods

	// RVA: 0x641C028 Offset: 0x6418028 VA: 0x641C028
	public void .ctor() { }

	// RVA: 0x641C354 Offset: 0x6418354 VA: 0x641C354
	internal Task <SendBindRequest>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DefaultAccountService.<>c__DisplayClass39_0 // TypeDefIndex: 26130
{
	// Fields
	public Action<bool> onFinish; // 0x10

	// Methods

	// RVA: 0x641C32C Offset: 0x641832C VA: 0x641C32C
	public void .ctor() { }

	// RVA: 0x641C374 Offset: 0x6418374 VA: 0x641C374
	internal void <DeleteAccount>b__0(string _) { }

	// RVA: 0x641C3A8 Offset: 0x64183A8 VA: 0x641C3A8
	internal void <DeleteAccount>b__1(int code, string message) { }
}

// Namespace: 
[CompilerGenerated]
private struct DefaultAccountService.<SendBindRequestAsync>d__38 : IAsyncStateMachine // TypeDefIndex: 26131
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public DefaultAccountService <>4__this; // 0x20
	public BindRequest request; // 0x28
	public BindArgs args; // 0x30
	private TaskAwaiter<ChannelBindInfo> <>u__1; // 0x38

	// Methods

	// RVA: 0x641C3C8 Offset: 0x64183C8 VA: 0x641C3C8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x641C870 Offset: 0x6418870 VA: 0x641C870 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct DefaultAccountService.<SendGameLoginRequestAsync>d__16 : IAsyncStateMachine // TypeDefIndex: 26132
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public DefaultAccountService <>4__this; // 0x20
	public GameLoginRequest request; // 0x28
	public LoginArgs args; // 0x30
	private TaskAwaiter<GameLoginResponse> <>u__1; // 0x38

	// Methods

	// RVA: 0x641C8D8 Offset: 0x64188D8 VA: 0x641C8D8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x641CE90 Offset: 0x6418E90 VA: 0x641CE90 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: GorillaBase.Runtime.Ability.Default
public class DefaultAccountService : IAccountService // TypeDefIndex: 26133
{
	// Fields
	protected SDKConfig Config; // 0x10
	protected INetworkService Network; // 0x18
	[CompilerGenerated]
	private bool <EnableRetry>k__BackingField; // 0x20
	private int _retryCount; // 0x24

	// Properties
	protected bool EnableRetry { get; }
	public virtual IAccountServiceExtension Extension { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x641B2A4 Offset: 0x64172A4 VA: 0x641B2A4
	protected bool get_EnableRetry() { }

	// RVA: 0x641B2AC Offset: 0x64172AC VA: 0x641B2AC Slot: 10
	public virtual IAccountServiceExtension get_Extension() { }

	// RVA: 0x641B2B4 Offset: 0x64172B4 VA: 0x641B2B4 Slot: 11
	public virtual void Init(SDKConfig config, Action<bool> callback) { }

	// RVA: 0x641B3F8 Offset: 0x64173F8 VA: 0x641B3F8 Slot: 12
	public virtual void Login(LoginArgs args) { }

	// RVA: 0x641B434 Offset: 0x6417434 VA: 0x641B434
	protected void SendGameLoginRequest(GameLoginRequest request, LoginArgs args) { }

	[AsyncStateMachine(typeof(DefaultAccountService.<SendGameLoginRequestAsync>d__16))]
	// RVA: 0x641B544 Offset: 0x6417544 VA: 0x641B544
	private Task SendGameLoginRequestAsync(GameLoginRequest request, LoginArgs args) { }

	// RVA: 0x641B658 Offset: 0x6417658 VA: 0x641B658 Slot: 13
	protected virtual void OnGameLoginRequestStart(GameLoginRequest request, LoginArgs args) { }

	// RVA: 0x641B6D4 Offset: 0x64176D4 VA: 0x641B6D4 Slot: 14
	protected virtual void OnGameLoginRequestSuccess(GameLoginRequest request, LoginArgs args, LoginResult result, int retryCount) { }

	// RVA: 0x641B944 Offset: 0x6417944 VA: 0x641B944 Slot: 15
	protected virtual void OnGameLoginRequestFailure(GameLoginRequest request, LoginArgs args, int code, string message, int retryCount) { }

	// RVA: 0x641BA94 Offset: 0x6417A94 VA: 0x641BA94
	protected static void TrackLoginEvent(LoginArgs args, string step) { }

	// RVA: 0x641B6C0 Offset: 0x64176C0 VA: 0x641B6C0
	protected static void TrackLoginEvent(LoginArgs args, string step, int channelId) { }

	// RVA: 0x641BAB4 Offset: 0x6417AB4 VA: 0x641BAB4
	protected static void TrackLoginFailure(LoginArgs args, string step, string message) { }

	// RVA: 0x641BAD0 Offset: 0x6417AD0 VA: 0x641BAD0
	protected static void TrackLoginFailure(LoginArgs args, string step, LoginChannelId channelId, int code, string message, Nullable<int> retryCount) { }

	// RVA: 0x641B9F4 Offset: 0x64179F4 VA: 0x641B9F4
	protected static void TrackLoginFailure(LoginArgs args, string step, int channelId, int code, string message, Nullable<int> retryCount) { }

	// RVA: 0x641B7AC Offset: 0x64177AC VA: 0x641B7AC
	protected static void TrackLoginEvent(LoginArgs args, string step, int channelId, Nullable<int> code, string message, Nullable<int> retryCount, string accountId) { }

	// RVA: 0x641BAD4 Offset: 0x6417AD4 VA: 0x641BAD4
	public static Dictionary<string, object> CreateLoginEventProperties(string step, int channelId, Nullable<int> code, string message, Nullable<int> retryCount, string accountId) { }

	// RVA: 0x641BDA0 Offset: 0x6417DA0 VA: 0x641BDA0
	public static string GetLoginEventChannelName(int channelId) { }

	// RVA: 0x641BE84 Offset: 0x6417E84 VA: 0x641BE84
	private bool IsRetryable(int code) { }

	// RVA: 0x641BEB4 Offset: 0x6417EB4 VA: 0x641BEB4 Slot: 16
	public virtual void Logout() { }

	// RVA: 0x641BF1C Offset: 0x6417F1C VA: 0x641BF1C Slot: 17
	public virtual void Bind(BindArgs args) { }

	// RVA: 0x641BF20 Offset: 0x6417F20 VA: 0x641BF20
	protected void SendBindRequest(BindRequest request, BindArgs args) { }

	[AsyncStateMachine(typeof(DefaultAccountService.<SendBindRequestAsync>d__38))]
	// RVA: 0x641C030 Offset: 0x6418030 VA: 0x641C030
	private Task SendBindRequestAsync(BindRequest request, BindArgs args) { }

	// RVA: 0x641C144 Offset: 0x6418144 VA: 0x641C144 Slot: 9
	public void DeleteAccount(Action<bool> onFinish) { }

	// RVA: 0x641A570 Offset: 0x6416570 VA: 0x641A570
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Ability.Default
internal class DefaultAppsFlyerAnalytics : IAppsFlyerAnalytics, IAnalytics // TypeDefIndex: 26134
{
	// Methods

	// RVA: 0x641CEF8 Offset: 0x6418EF8 VA: 0x641CEF8 Slot: 9
	public void Init(object data) { }

	// RVA: 0x641CF5C Offset: 0x6418F5C VA: 0x641CF5C Slot: 4
	public string GetAppsFlyerId() { }

	// RVA: 0x641CFA4 Offset: 0x6418FA4 VA: 0x641CFA4 Slot: 5
	public void SetCustomUserId(string userId) { }

	// RVA: 0x641D008 Offset: 0x6419008 VA: 0x641D008 Slot: 6
	public void SetConsent(bool isConsent = True) { }

	// RVA: 0x641D0E0 Offset: 0x64190E0 VA: 0x641D0E0 Slot: 7
	public void Track(string eventId, Dictionary<string, string> payload) { }

	// RVA: 0x641D168 Offset: 0x6419168 VA: 0x641D168 Slot: 8
	public void TrackPurchase(string currency, Decimal revenue, string contentId, string quality = "1") { }

	// RVA: 0x64071F4 Offset: 0x64031F4 VA: 0x64071F4
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Ability.Default
internal class DefaultAdjustAnalytics : IAdjustAnalytics, IAnalytics // TypeDefIndex: 26135
{
	// Fields
	[CompilerGenerated]
	private Action<string> <OnDeepLinkCallback>k__BackingField; // 0x10

	// Properties
	public Action<string> OnDeepLinkCallback { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x641D1F0 Offset: 0x64191F0 VA: 0x641D1F0 Slot: 4
	public Action<string> get_OnDeepLinkCallback() { }

	[CompilerGenerated]
	// RVA: 0x641D1F8 Offset: 0x64191F8 VA: 0x641D1F8 Slot: 5
	public void set_OnDeepLinkCallback(Action<string> value) { }

	// RVA: 0x641D200 Offset: 0x6419200 VA: 0x641D200 Slot: 9
	public void Init(object data) { }

	// RVA: 0x641D264 Offset: 0x6419264 VA: 0x641D264 Slot: 6
	public string GetAdjustId() { }

	// RVA: 0x641D2AC Offset: 0x64192AC VA: 0x641D2AC Slot: 7
	public void TrackEvent(string eventToken, string currency = "", double amount = 0) { }

	// RVA: 0x641D334 Offset: 0x6419334 VA: 0x641D334 Slot: 8
	public void AddGlobalCallbackParameter(string key, string value) { }

	// RVA: 0x64070E0 Offset: 0x64030E0 VA: 0x64070E0
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Ability.Default
internal class DefaultJuLiangAnalytics : IJuLiangAnalytics, IAnalytics // TypeDefIndex: 26136
{
	// Fields
	[CompilerGenerated]
	private Action<Dictionary<string, object>> <OnAttributionSuccess>k__BackingField; // 0x10
	[CompilerGenerated]
	private Action<JuLiangAttributionFailure> <OnAttributionFailure>k__BackingField; // 0x18
	[CompilerGenerated]
	private Action<JuLiangDeepLinkResult> <OnDeepLinkCallback>k__BackingField; // 0x20

	// Properties
	public Action<Dictionary<string, object>> OnAttributionSuccess { get; set; }
	public Action<JuLiangAttributionFailure> OnAttributionFailure { get; set; }
	public Action<JuLiangDeepLinkResult> OnDeepLinkCallback { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x641D3BC Offset: 0x64193BC VA: 0x641D3BC Slot: 4
	public Action<Dictionary<string, object>> get_OnAttributionSuccess() { }

	[CompilerGenerated]
	// RVA: 0x641D3C4 Offset: 0x64193C4 VA: 0x641D3C4 Slot: 5
	public void set_OnAttributionSuccess(Action<Dictionary<string, object>> value) { }

	[CompilerGenerated]
	// RVA: 0x641D3CC Offset: 0x64193CC VA: 0x641D3CC Slot: 6
	public Action<JuLiangAttributionFailure> get_OnAttributionFailure() { }

	[CompilerGenerated]
	// RVA: 0x641D3D4 Offset: 0x64193D4 VA: 0x641D3D4 Slot: 7
	public void set_OnAttributionFailure(Action<JuLiangAttributionFailure> value) { }

	[CompilerGenerated]
	// RVA: 0x641D3DC Offset: 0x64193DC VA: 0x641D3DC Slot: 8
	public Action<JuLiangDeepLinkResult> get_OnDeepLinkCallback() { }

	[CompilerGenerated]
	// RVA: 0x641D3E4 Offset: 0x64193E4 VA: 0x641D3E4 Slot: 9
	public void set_OnDeepLinkCallback(Action<JuLiangDeepLinkResult> value) { }

	// RVA: 0x641D3EC Offset: 0x64193EC VA: 0x641D3EC Slot: 18
	public void Init(object data) { }

	// RVA: 0x641D450 Offset: 0x6419450 VA: 0x641D450 Slot: 10
	public string GetDeviceId() { }

	// RVA: 0x641D498 Offset: 0x6419498 VA: 0x641D498 Slot: 11
	public string GetSDKVersion() { }

	// RVA: 0x641D4E0 Offset: 0x64194E0 VA: 0x641D4E0 Slot: 12
	public void SetConsent(bool isConsent) { }

	// RVA: 0x641D5B8 Offset: 0x64195B8 VA: 0x641D5B8 Slot: 13
	public void SetDebugLogEnabled(bool enabled) { }

	// RVA: 0x641D690 Offset: 0x6419690 VA: 0x641D690 Slot: 14
	public void TrackEvent(string eventName, Dictionary<string, object> properties) { }

	// RVA: 0x641D718 Offset: 0x6419718 VA: 0x641D718 Slot: 15
	public void TrackRegister(string registerMethod, bool isSuccess) { }

	// RVA: 0x641D800 Offset: 0x6419800 VA: 0x641D800 Slot: 16
	public void TrackPurchase(string productType, string productName, string productId, int productCount, string payChannel, string currency, bool isSuccess, Decimal amount) { }

	// RVA: 0x641D888 Offset: 0x6419888 VA: 0x641D888 Slot: 17
	public void TrackConversion(string conversionEvent, Dictionary<string, object> properties) { }

	// RVA: 0x6407308 Offset: 0x6403308 VA: 0x6407308
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Ability.Default
internal class DefaultFirebase : IFirebase, ICrashReporter // TypeDefIndex: 26137
{
	// Methods

	// RVA: 0x641D910 Offset: 0x6419910 VA: 0x641D910 Slot: 5
	public void Init(object data) { }

	// RVA: 0x641D974 Offset: 0x6419974 VA: 0x641D974 Slot: 6
	public void SetUserId(string userId) { }

	// RVA: 0x641D9D8 Offset: 0x64199D8 VA: 0x641D9D8 Slot: 7
	public void SetCustomKey(string key, string value) { }

	// RVA: 0x641DA60 Offset: 0x6419A60 VA: 0x641DA60 Slot: 8
	public void RecordException(Exception exception) { }

	// RVA: 0x641DB00 Offset: 0x6419B00 VA: 0x641DB00 Slot: 9
	public void ReportLog(string log) { }

	// RVA: 0x641DB88 Offset: 0x6419B88 VA: 0x641DB88 Slot: 4
	public void Track(string eventName, List<KeyValuePair<string, object>> parameters) { }

	// RVA: 0x6407758 Offset: 0x6403758 VA: 0x6407758
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Ability.Default
internal class DefaultAppDownloadService : IAppDownloadService // TypeDefIndex: 26138
{
	// Methods

	// RVA: 0x6407C1C Offset: 0x6403C1C VA: 0x6407C1C
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Ability.Default
internal sealed class DefaultDataNexus : IDataNexus // TypeDefIndex: 26139
{
	// Methods

	// RVA: 0x641DC10 Offset: 0x6419C10 VA: 0x641DC10 Slot: 4
	public void Init() { }

	// RVA: 0x6406FCC Offset: 0x6402FCC VA: 0x6406FCC
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Ability.Default
internal class DefaultGameTrack : IGameTrack // TypeDefIndex: 26140
{
	// Methods

	// RVA: 0x641DC74 Offset: 0x6419C74 VA: 0x641DC74 Slot: 4
	public void Init(object data) { }

	// RVA: 0x641DCD8 Offset: 0x6419CD8 VA: 0x641DCD8 Slot: 5
	public void Track(string eventName, Dictionary<string, object> properties) { }

	// RVA: 0x6406EB8 Offset: 0x6402EB8 VA: 0x6406EB8
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Ability.Default
internal sealed class DefaultGravityEngineAnalytics : IGravityEngineAnalytics // TypeDefIndex: 26141
{
	// Methods

	// RVA: 0x6407530 Offset: 0x6403530 VA: 0x6407530
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Ability.Default
internal class DefaultPurchaseEligibilityService : IPurchaseEligibilityService // TypeDefIndex: 26142
{
	// Methods

	// RVA: 0x641DD98 Offset: 0x6419D98 VA: 0x641DD98 Slot: 4
	public PurchaseEligibilityDecision CanPurchase(PurchaseEligibilityContext context) { }

	// RVA: 0x6406CF8 Offset: 0x6402CF8 VA: 0x6406CF8
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Ability.Default
public class DefaultReviewGuideService : IReviewGuideService // TypeDefIndex: 26143
{
	// Methods

	// RVA: 0x6407D30 Offset: 0x6403D30 VA: 0x6407D30
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Ability.Default
internal class DefaultReviewService : IReviewService // TypeDefIndex: 26144
{
	// Methods

	// RVA: 0x6406268 Offset: 0x6402268 VA: 0x6406268
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Ability.Default
internal class DefaultSecurityConfig : ISecurityConfig // TypeDefIndex: 26145
{
	// Properties
	public string AesKey { get; }
	public string AesIv { get; }
	public string RequestSignSecret { get; }

	// Methods

	// RVA: 0x641DD9C Offset: 0x6419D9C VA: 0x641DD9C Slot: 4
	public string get_AesKey() { }

	// RVA: 0x641DDDC Offset: 0x6419DDC VA: 0x641DDDC Slot: 5
	public string get_AesIv() { }

	// RVA: 0x641DE1C Offset: 0x6419E1C VA: 0x641DE1C Slot: 6
	public string get_RequestSignSecret() { }

	// RVA: 0x6407644 Offset: 0x6403644 VA: 0x6407644
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Ability.Default
internal sealed class DefaultSolarEngineAnalytics : ISolarEngineAnalytics // TypeDefIndex: 26146
{
	// Methods

	// RVA: 0x640741C Offset: 0x640341C VA: 0x640741C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DefaultSystemInfoAbility.<>c // TypeDefIndex: 26147
{
	// Fields
	public static readonly DefaultSystemInfoAbility.<>c <>9; // 0x0
	public static Func<string> <>9__5_0; // 0x8
	public static Func<string> <>9__5_1; // 0x10
	public static Func<string> <>9__6_0; // 0x18
	public static Func<string> <>9__6_1; // 0x20

	// Methods

	// RVA: 0x641E1E8 Offset: 0x641A1E8 VA: 0x641E1E8
	private static void .cctor() { }

	// RVA: 0x641E250 Offset: 0x641A250 VA: 0x641E250
	public void .ctor() { }

	// RVA: 0x641E258 Offset: 0x641A258 VA: 0x641E258
	internal string <.ctor>b__5_0() { }

	// RVA: 0x641E260 Offset: 0x641A260 VA: 0x641E260
	internal string <.ctor>b__5_1() { }

	// RVA: 0x641E28C Offset: 0x641A28C VA: 0x641E28C
	internal string <.ctor>b__6_0() { }

	// RVA: 0x641E2D4 Offset: 0x641A2D4 VA: 0x641E2D4
	internal string <.ctor>b__6_1() { }
}

// Namespace: GorillaBase.Runtime.Ability.Default
public class DefaultSystemInfoAbility : ISystemInfoAbility // TypeDefIndex: 26148
{
	// Fields
	private readonly Func<string> _deviceIdentifierProvider; // 0x10
	private readonly Func<string> _guidProvider; // 0x18
	private string _deviceId; // 0x20

	// Properties
	public string DeviceId { get; }

	// Methods

	// RVA: 0x64065C8 Offset: 0x64025C8 VA: 0x64065C8
	public void .ctor() { }

	// RVA: 0x641DE5C Offset: 0x6419E5C VA: 0x641DE5C
	internal void .ctor(Func<string> deviceIdentifierProvider, Func<string> guidProvider) { }

	// RVA: 0x641E000 Offset: 0x641A000 VA: 0x641E000 Slot: 4
	public string get_DeviceId() { }

	// RVA: 0x641E048 Offset: 0x641A048 VA: 0x641E048
	private string GetOrCreateDeviceId() { }

	// RVA: 0x641E04C Offset: 0x641A04C VA: 0x641E04C
	private string GetOrCreatePlayerPrefsDeviceId() { }

	// RVA: 0x641E100 Offset: 0x641A100 VA: 0x641E100
	internal static string CreateFallbackDeviceId(string identifier, Func<string> guidProvider) { }
}

// Namespace: GorillaBase.Runtime.Ability.Default
internal class DefaultSystemUIAbility : ISystemUIAbility // TypeDefIndex: 26149
{
	// Methods

	// RVA: 0x641E300 Offset: 0x641A300 VA: 0x641E300 Slot: 4
	public void ShowToast(string message, ToastDuration duration = 0) { }

	// RVA: 0x641E494 Offset: 0x641A494 VA: 0x641E494
	private static void ShowAndroid(string message, ToastDuration duration) { }

	// RVA: 0x6406260 Offset: 0x6402260 VA: 0x6406260
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DefaultUILoadAbility.<>c__DisplayClass2_0<T> // TypeDefIndex: 26150
{
	// Fields
	public ResourceRequest request; // 0x0
	public DefaultUILoadAbility <>4__this; // 0x0
	public string fileName; // 0x0
	public TaskCompletionSource<T> tcs; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486DFE0 Offset: 0x4869FE0 VA: 0x486DFE0
	|-DefaultUILoadAbility.<>c__DisplayClass2_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <LoadAsync>b__0(AsyncOperation operation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486DFE8 Offset: 0x4869FE8 VA: 0x486DFE8
	|-DefaultUILoadAbility.<>c__DisplayClass2_0<object>.<LoadAsync>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private struct DefaultUILoadAbility.<LoadAsync>d__2<T> : IAsyncStateMachine // TypeDefIndex: 26151
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<T> <>t__builder; // 0x0
	public DefaultUILoadAbility <>4__this; // 0x0
	public string fileName; // 0x0
	private TaskAwaiter<T> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D37D60 Offset: 0x5D33D60 VA: 0x5D37D60
	|-DefaultUILoadAbility.<LoadAsync>d__2<object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D383A8 Offset: 0x5D343A8 VA: 0x5D383A8
	|-DefaultUILoadAbility.<LoadAsync>d__2<object>.SetStateMachine
	*/
}

// Namespace: GorillaBase.Runtime.Ability.Default
public class DefaultUILoadAbility : IUILoadAbility // TypeDefIndex: 26152
{
	// Fields
	private readonly Dictionary<string, Object> _assetCache; // 0x10

	// Properties
	private static string RelativePath { get; }
	private static string ImagesPath { get; }

	// Methods

	[AsyncStateMachine(typeof(DefaultUILoadAbility.<LoadAsync>d__2<T>))]
	// RVA: -1 Offset: -1 Slot: 4
	public Task<T> LoadAsync<T>(string fileName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4571340 Offset: 0x456D340 VA: 0x4571340
	|-DefaultUILoadAbility.LoadAsync<object>
	*/

	// RVA: 0x641E744 Offset: 0x641A744 VA: 0x641E744 Slot: 5
	public string GetAssetPath(string fileName) { }

	// RVA: 0x641E898 Offset: 0x641A898 VA: 0x641E898
	private static string get_RelativePath() { }

	// RVA: 0x641E858 Offset: 0x641A858 VA: 0x641E858
	private static string get_ImagesPath() { }

	// RVA: 0x6406838 Offset: 0x6402838 VA: 0x6406838
	public void .ctor() { }
}

// Namespace: GorillaBase.Runtime.Ability.Default
internal class LocalNotificationAbility : ILocalNotification // TypeDefIndex: 26153
{
	// Fields
	private readonly HashSet<string> _registeredChannels; // 0x10

	// Methods

	// RVA: 0x6406270 Offset: 0x6402270 VA: 0x6406270
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 26154
{
	// Methods

	// RVA: 0x640BCE8 Offset: 0x6407CE8 VA: 0x640BCE8
	internal static uint ComputeStringHash(string s) { }
}

