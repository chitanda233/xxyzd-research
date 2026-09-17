// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 27560
{}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 27561
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
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
[EditorBrowsable(1)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 27562
{
	// Methods

	// RVA: 0x847D5AC Offset: 0x84795AC VA: 0x847D5AC
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x847D6A4 Offset: 0x84796A4 VA: 0x847D6A4
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public struct ThinkingAnalyticsAPI.Token // TypeDefIndex: 27563
{
	// Fields
	public string appid; // 0x0
	public string serverUrl; // 0x8
	public ThinkingAnalyticsAPI.TAMode mode; // 0x10
	public ThinkingAnalyticsAPI.TATimeZone timeZone; // 0x14
	public string timeZoneId; // 0x18
	public bool enableEncrypt; // 0x20
	public int encryptVersion; // 0x24
	public string encryptPublicKey; // 0x28
	public TDSSLPinningMode pinningMode; // 0x30
	public bool allowInvalidCertificates; // 0x34
	public bool validatesDomainName; // 0x35
	private string instanceName; // 0x38

	// Methods

	// RVA: 0x8488244 Offset: 0x8484244 VA: 0x8488244
	public void .ctor(string appId, string serverUrl, ThinkingAnalyticsAPI.TAMode mode = 0, ThinkingAnalyticsAPI.TATimeZone timeZone = 0, string timeZoneId, string instanceName) { }

	// RVA: 0x8489854 Offset: 0x8485854 VA: 0x8489854
	public string GetInstanceName() { }

	// RVA: 0x848985C Offset: 0x848585C VA: 0x848985C
	public string getTimeZoneId() { }

	// RVA: 0x8488F34 Offset: 0x8484F34 VA: 0x8488F34
	internal TDConfig ToTDConfig() { }
}

// Namespace: 
public enum ThinkingAnalyticsAPI.TATimeZone // TypeDefIndex: 27564
{
	// Fields
	public int value__; // 0x0
	public const ThinkingAnalyticsAPI.TATimeZone Local = 0;
	public const ThinkingAnalyticsAPI.TATimeZone UTC = 1;
	public const ThinkingAnalyticsAPI.TATimeZone Asia_Shanghai = 2;
	public const ThinkingAnalyticsAPI.TATimeZone Asia_Tokyo = 3;
	public const ThinkingAnalyticsAPI.TATimeZone America_Los_Angeles = 4;
	public const ThinkingAnalyticsAPI.TATimeZone America_New_York = 5;
	public const ThinkingAnalyticsAPI.TATimeZone Other = 100;
}

// Namespace: 
public enum ThinkingAnalyticsAPI.TAMode // TypeDefIndex: 27565
{
	// Fields
	public int value__; // 0x0
	public const ThinkingAnalyticsAPI.TAMode NORMAL = 0;
	public const ThinkingAnalyticsAPI.TAMode DEBUG = 1;
	public const ThinkingAnalyticsAPI.TAMode DEBUG_ONLY = 2;
}

// Namespace: 
public enum ThinkingAnalyticsAPI.NetworkType // TypeDefIndex: 27566
{
	// Fields
	public int value__; // 0x0
	public const ThinkingAnalyticsAPI.NetworkType DEFAULT = 1;
	public const ThinkingAnalyticsAPI.NetworkType WIFI = 2;
	public const ThinkingAnalyticsAPI.NetworkType ALL = 3;
}

// Namespace: ThinkingAnalytics
[Obsolete("ThinkingAnalyticsAPI is deprecated, please use ThinkingData.Analytics instead.")]
[DisallowMultipleComponent]
public class ThinkingAnalyticsAPI : MonoBehaviour, TDDynamicSuperPropertiesHandler, TDAutoTrackEventHandler // TypeDefIndex: 27567
{
	// Fields
	[Header("Configuration")]
	[Tooltip("Enable Start SDK Manually")]
	public bool startManually; // 0x20
	[Tooltip("Enable Log")]
	public bool enableLog; // 0x21
	[Tooltip("Sets the Network Type")]
	public ThinkingAnalyticsAPI.NetworkType networkType; // 0x24
	[HideInInspector]
	[Tooltip("Project Setting, APP ID is given when the project is created")]
	[Header("Project")]
	public ThinkingAnalyticsAPI.Token[] tokens; // 0x28
	private static ThinkingAnalyticsAPI sThinkingAnalyticsAPI; // 0x0
	private static bool tracking_enabled; // 0x8
	private static List<Dictionary<string, object>> eventCaches; // 0x10
	private IDynamicSuperProperties _dynamicSuperProperties; // 0x30
	private IAutoTrackEventCallback _eventCallback; // 0x38

	// Methods

	// RVA: 0x847D6AC Offset: 0x84796AC VA: 0x847D6AC
	public static void EnableLog(bool enable, string appId = "") { }

	// RVA: 0x847D82C Offset: 0x847982C VA: 0x847D82C
	public static void Identify(string distinctId, string appId = "") { }

	// RVA: 0x847DB44 Offset: 0x8479B44 VA: 0x847DB44
	public static string GetDistinctId(string appId = "") { }

	// RVA: 0x847DC30 Offset: 0x8479C30 VA: 0x847DC30
	public static void Login(string account, string appId = "") { }

	// RVA: 0x847DF48 Offset: 0x8479F48 VA: 0x847DF48
	public static void Logout(string appId = "") { }

	// RVA: 0x847E214 Offset: 0x847A214 VA: 0x847E214
	public static void EnableAutoTrack(AUTO_TRACK_EVENTS events, Dictionary<string, object> properties, string appId = "") { }

	// RVA: 0x847E9AC Offset: 0x847A9AC VA: 0x847E9AC
	public static void EnableAutoTrack(AUTO_TRACK_EVENTS events, IAutoTrackEventCallback eventCallback, string appId = "") { }

	// RVA: 0x847F198 Offset: 0x847B198 VA: 0x847F198
	public static void SetAutoTrackProperties(AUTO_TRACK_EVENTS events, Dictionary<string, object> properties, string appId = "") { }

	// RVA: 0x847F6D8 Offset: 0x847B6D8 VA: 0x847F6D8
	public static void Track(string eventName, string appId = "") { }

	// RVA: 0x847F740 Offset: 0x847B740 VA: 0x847F740
	public static void Track(string eventName, Dictionary<string, object> properties, string appId = "") { }

	[Obsolete("Method is deprecated, please use Track(string eventName, Dictionary<string, object> properties, DateTime date, TimeZoneInfo timeZone, string appId = "") instead.")]
	// RVA: 0x847FAE0 Offset: 0x847BAE0 VA: 0x847FAE0
	public static void Track(string eventName, Dictionary<string, object> properties, DateTime date, string appId = "") { }

	// RVA: 0x847FEF8 Offset: 0x847BEF8 VA: 0x847FEF8
	public static void Track(string eventName, Dictionary<string, object> properties, DateTime date, TimeZoneInfo timeZone, string appId = "") { }

	// RVA: 0x8480354 Offset: 0x847C354 VA: 0x8480354
	public static void Track(ThinkingAnalyticsEvent analyticsEvent, string appId = "") { }

	// RVA: 0x8480A0C Offset: 0x847CA0C VA: 0x8480A0C
	public static void QuickTrack(string eventName, Dictionary<string, object> properties, string appId = "") { }

	// RVA: 0x8480F34 Offset: 0x847CF34 VA: 0x8480F34
	public static void Flush(string appId = "") { }

	// RVA: 0x8481200 Offset: 0x847D200 VA: 0x8481200
	public static void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x8481B58 Offset: 0x847DB58 VA: 0x8481B58
	public static void OnSceneUnloaded(Scene scene) { }

	// RVA: 0x84822A8 Offset: 0x847E2A8 VA: 0x84822A8
	public static void SetSuperProperties(Dictionary<string, object> superProperties, string appId = "") { }

	// RVA: 0x8482604 Offset: 0x847E604 VA: 0x8482604
	public static void UnsetSuperProperty(string property, string appId = "") { }

	// RVA: 0x8482948 Offset: 0x847E948 VA: 0x8482948
	public static Dictionary<string, object> GetSuperProperties(string appId = "") { }

	// RVA: 0x8482A34 Offset: 0x847EA34 VA: 0x8482A34
	public static void ClearSuperProperties(string appId = "") { }

	// RVA: 0x8482D00 Offset: 0x847ED00 VA: 0x8482D00
	public static TDPresetProperties GetPresetProperties(string appId = "") { }

	// RVA: 0x8482E54 Offset: 0x847EE54 VA: 0x8482E54
	public static void SetDynamicSuperProperties(IDynamicSuperProperties dynamicSuperProperties, string appId = "") { }

	// RVA: 0x84832C8 Offset: 0x847F2C8 VA: 0x84832C8
	public static void TimeEvent(string eventName, string appId = "") { }

	// RVA: 0x848360C Offset: 0x847F60C VA: 0x848360C
	public static void UserSet(Dictionary<string, object> properties, string appId = "") { }

	// RVA: 0x8483968 Offset: 0x847F968 VA: 0x8483968
	public static void UserSet(Dictionary<string, object> properties, DateTime dateTime, string appId = "") { }

	// RVA: 0x8483D38 Offset: 0x847FD38 VA: 0x8483D38
	public static void UserUnset(string property, string appId = "") { }

	// RVA: 0x8483E50 Offset: 0x847FE50 VA: 0x8483E50
	public static void UserUnset(List<string> properties, string appId = "") { }

	// RVA: 0x8484194 Offset: 0x8480194 VA: 0x8484194
	public static void UserUnset(List<string> properties, DateTime dateTime, string appId = "") { }

	// RVA: 0x848454C Offset: 0x848054C VA: 0x848454C
	public static void UserSetOnce(Dictionary<string, object> properties, string appId = "") { }

	// RVA: 0x84848A8 Offset: 0x84808A8 VA: 0x84848A8
	public static void UserSetOnce(Dictionary<string, object> properties, DateTime dateTime, string appId = "") { }

	// RVA: 0x8484C78 Offset: 0x8480C78 VA: 0x8484C78
	public static void UserAdd(string property, object value, string appId = "") { }

	// RVA: 0x8484D54 Offset: 0x8480D54 VA: 0x8484D54
	public static void UserAdd(Dictionary<string, object> properties, string appId = "") { }

	// RVA: 0x84850B0 Offset: 0x84810B0 VA: 0x84850B0
	public static void UserAdd(Dictionary<string, object> properties, DateTime dateTime, string appId = "") { }

	// RVA: 0x8485480 Offset: 0x8481480 VA: 0x8485480
	public static void UserAppend(Dictionary<string, object> properties, string appId = "") { }

	// RVA: 0x84857DC Offset: 0x84817DC VA: 0x84857DC
	public static void UserAppend(Dictionary<string, object> properties, DateTime dateTime, string appId = "") { }

	// RVA: 0x8485BAC Offset: 0x8481BAC VA: 0x8485BAC
	public static void UserUniqAppend(Dictionary<string, object> properties, string appId = "") { }

	// RVA: 0x8485F08 Offset: 0x8481F08 VA: 0x8485F08
	public static void UserUniqAppend(Dictionary<string, object> properties, DateTime dateTime, string appId = "") { }

	// RVA: 0x84862D8 Offset: 0x84822D8 VA: 0x84862D8
	public static void UserDelete(string appId = "") { }

	// RVA: 0x84865A4 Offset: 0x84825A4 VA: 0x84865A4
	public static void UserDelete(DateTime dateTime, string appId = "") { }

	// RVA: 0x84868EC Offset: 0x84828EC VA: 0x84868EC
	public static void SetNetworkType(ThinkingAnalyticsAPI.NetworkType networkType, string appId = "") { }

	// RVA: 0x8486C20 Offset: 0x8482C20 VA: 0x8486C20
	public static string GetDeviceId() { }

	// RVA: 0x8486CFC Offset: 0x8482CFC VA: 0x8486CFC
	public static void SetTrackStatus(TA_TRACK_STATUS status, string appId = "") { }

	[Obsolete("Method is deprecated, please use SetTrackStatus() instead.")]
	// RVA: 0x8487044 Offset: 0x8483044 VA: 0x8487044
	public static void OptOutTracking(string appId = "") { }

	[Obsolete("Method is deprecated, please use SetTrackStatus() instead.")]
	// RVA: 0x8487310 Offset: 0x8483310 VA: 0x8487310
	public static void OptOutTrackingAndDeleteUser(string appId = "") { }

	[Obsolete("Method is deprecated, please use SetTrackStatus() instead.")]
	// RVA: 0x84875DC Offset: 0x84835DC VA: 0x84875DC
	public static void OptInTracking(string appId = "") { }

	[Obsolete("Method is deprecated, please use SetTrackStatus() instead.")]
	// RVA: 0x84878A8 Offset: 0x84838A8 VA: 0x84878A8
	public static void EnableTracking(bool enabled, string appId = "") { }

	// RVA: 0x8487BE4 Offset: 0x8483BE4 VA: 0x8487BE4
	public static string CreateLightInstance(string appId = "") { }

	// RVA: 0x8487CC0 Offset: 0x8483CC0 VA: 0x8487CC0
	public static void CalibrateTime(long timestamp) { }

	// RVA: 0x8487D68 Offset: 0x8483D68 VA: 0x8487D68
	public static void CalibrateTimeWithNtp(string ntpServer) { }

	// RVA: 0x8487E10 Offset: 0x8483E10 VA: 0x8487E10
	public static void EnableThirdPartySharing(TAThirdPartyShareType shareType, Dictionary<string, object> properties, string appId = "") { }

	// RVA: 0x8488174 Offset: 0x8484174 VA: 0x8488174
	public static string GetLocalRegion() { }

	// RVA: 0x848819C Offset: 0x848419C VA: 0x848819C
	public static void StartThinkingAnalytics(string appId, string serverUrl) { }

	// RVA: 0x8488378 Offset: 0x8484378 VA: 0x8488378
	public static void StartThinkingAnalytics(ThinkingAnalyticsAPI.Token token) { }

	// RVA: 0x8488448 Offset: 0x8484448 VA: 0x8488448
	public static void StartThinkingAnalytics(ThinkingAnalyticsAPI.Token[] tokens) { }

	// RVA: 0x84890F8 Offset: 0x84850F8 VA: 0x84890F8
	private static void FlushEventCaches() { }

	// RVA: 0x8489464 Offset: 0x8485464 VA: 0x8489464
	private void Awake() { }

	// RVA: 0x84895C8 Offset: 0x84855C8 VA: 0x84895C8
	private void Start() { }

	// RVA: 0x84895CC Offset: 0x84855CC VA: 0x84895CC
	private void OnApplicationQuit() { }

	// RVA: 0x84895D0 Offset: 0x84855D0 VA: 0x84895D0 Slot: 4
	public Dictionary<string, object> GetDynamicSuperProperties() { }

	// RVA: 0x848967C Offset: 0x848567C VA: 0x848967C Slot: 5
	public Dictionary<string, object> GetAutoTrackEventProperties(int type, Dictionary<string, object> properties) { }

	// RVA: 0x8489744 Offset: 0x8485744 VA: 0x8489744
	public void .ctor() { }

	// RVA: 0x84897B8 Offset: 0x84857B8 VA: 0x84897B8
	private static void .cctor() { }
}

// Namespace: ThinkingAnalytics
[Obsolete("AUTO_TRACK_EVENTS is deprecated, please use ThinkingData.Analytics.TDAutoTrackEventType instead.")]
public enum AUTO_TRACK_EVENTS // TypeDefIndex: 27568
{
	// Fields
	public int value__; // 0x0
	public const AUTO_TRACK_EVENTS NONE = 0;
	public const AUTO_TRACK_EVENTS AppStart = 1;
	public const AUTO_TRACK_EVENTS AppEnd = 2;
	public const AUTO_TRACK_EVENTS AppCrash = 16;
	public const AUTO_TRACK_EVENTS AppInstall = 32;
	public const AUTO_TRACK_EVENTS AppSceneLoad = 64;
	public const AUTO_TRACK_EVENTS AppSceneUnload = 128;
	public const AUTO_TRACK_EVENTS ALL = 243;
}

// Namespace: ThinkingAnalytics
[Obsolete("TA_TRACK_STATUS is deprecated, please use ThinkingData.Analytics.TDTrackStatus instead.")]
public enum TA_TRACK_STATUS // TypeDefIndex: 27569
{
	// Fields
	public int value__; // 0x0
	public const TA_TRACK_STATUS PAUSE = 1;
	public const TA_TRACK_STATUS STOP = 2;
	public const TA_TRACK_STATUS SAVE_ONLY = 3;
	public const TA_TRACK_STATUS NORMAL = 4;
}

// Namespace: ThinkingAnalytics
[Obsolete("TAThirdPartyShareType is deprecated, please use ThinkingData.Analytics.Utils.TDThirdPartyType instead.")]
public enum TAThirdPartyShareType // TypeDefIndex: 27570
{
	// Fields
	public int value__; // 0x0
	public const TAThirdPartyShareType NONE = 0;
	public const TAThirdPartyShareType APPSFLYER = 1;
	public const TAThirdPartyShareType IRONSOURCE = 2;
	public const TAThirdPartyShareType ADJUST = 4;
	public const TAThirdPartyShareType BRANCH = 8;
	public const TAThirdPartyShareType TOPON = 16;
	public const TAThirdPartyShareType TRACKING = 32;
	public const TAThirdPartyShareType TRADPLUS = 64;
}

// Namespace: ThinkingAnalytics
[Obsolete("IDynamicSuperProperties is deprecated, please use ThinkingData.Analytics.TDDynamicSuperPropertiesHandler instead.")]
public interface IDynamicSuperProperties // TypeDefIndex: 27571
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Dictionary<string, object> GetDynamicSuperProperties();
}

// Namespace: ThinkingAnalytics
[Obsolete("IAutoTrackEventCallback is deprecated, please use ThinkingData.Analytics.TDAutoTrackEventHandler instead.")]
public interface IAutoTrackEventCallback // TypeDefIndex: 27572
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Dictionary<string, object> AutoTrackEventCallback(int type, Dictionary<string, object> properties);
}

// Namespace: 
public enum ThinkingAnalyticsEvent.Type // TypeDefIndex: 27573
{
	// Fields
	public int value__; // 0x0
	public const ThinkingAnalyticsEvent.Type FIRST = 0;
	public const ThinkingAnalyticsEvent.Type UPDATABLE = 1;
	public const ThinkingAnalyticsEvent.Type OVERWRITABLE = 2;
}

// Namespace: ThinkingAnalytics
[Obsolete("ThinkingAnalyticsEvent is deprecated, please use ThinkingData.Analytics.TDEventModel instead.")]
public class ThinkingAnalyticsEvent // TypeDefIndex: 27574
{
	// Fields
	[CompilerGenerated]
	private Nullable<ThinkingAnalyticsEvent.Type> <EventType>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <EventName>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly Dictionary<string, object> <Properties>k__BackingField; // 0x20
	[CompilerGenerated]
	private DateTime <EventTime>k__BackingField; // 0x28
	[CompilerGenerated]
	private TimeZoneInfo <EventTimeZone>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <ExtraId>k__BackingField; // 0x38

	// Properties
	public Nullable<ThinkingAnalyticsEvent.Type> EventType { get; set; }
	public string EventName { get; }
	public Dictionary<string, object> Properties { get; }
	public DateTime EventTime { get; set; }
	public TimeZoneInfo EventTimeZone { get; set; }
	public string ExtraId { get; set; }

	// Methods

	// RVA: 0x8489B2C Offset: 0x8485B2C VA: 0x8489B2C
	public void .ctor(string eventName, Dictionary<string, object> properties) { }

	[CompilerGenerated]
	// RVA: 0x8489B70 Offset: 0x8485B70 VA: 0x8489B70
	public Nullable<ThinkingAnalyticsEvent.Type> get_EventType() { }

	[CompilerGenerated]
	// RVA: 0x8489B78 Offset: 0x8485B78 VA: 0x8489B78
	public void set_EventType(Nullable<ThinkingAnalyticsEvent.Type> value) { }

	[CompilerGenerated]
	// RVA: 0x8489B80 Offset: 0x8485B80 VA: 0x8489B80
	public string get_EventName() { }

	[CompilerGenerated]
	// RVA: 0x8489B88 Offset: 0x8485B88 VA: 0x8489B88
	public Dictionary<string, object> get_Properties() { }

	[CompilerGenerated]
	// RVA: 0x8489B90 Offset: 0x8485B90 VA: 0x8489B90
	public DateTime get_EventTime() { }

	[CompilerGenerated]
	// RVA: 0x8489B98 Offset: 0x8485B98 VA: 0x8489B98
	public void set_EventTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x8489BA0 Offset: 0x8485BA0 VA: 0x8489BA0
	public TimeZoneInfo get_EventTimeZone() { }

	[CompilerGenerated]
	// RVA: 0x8489BA8 Offset: 0x8485BA8 VA: 0x8489BA8
	public void set_EventTimeZone(TimeZoneInfo value) { }

	[CompilerGenerated]
	// RVA: 0x8489BB0 Offset: 0x8485BB0 VA: 0x8489BB0
	public string get_ExtraId() { }

	[CompilerGenerated]
	// RVA: 0x8489BB8 Offset: 0x8485BB8 VA: 0x8489BB8
	public void set_ExtraId(string value) { }
}

// Namespace: ThinkingAnalytics
[Obsolete("TDFirstEvent is deprecated, please use ThinkingData.Analytics.TDFirstEventModel instead.")]
public class TDFirstEvent : ThinkingAnalyticsEvent // TypeDefIndex: 27575
{
	// Methods

	// RVA: 0x8489BC0 Offset: 0x8485BC0 VA: 0x8489BC0
	public void .ctor(string eventName, Dictionary<string, object> properties) { }

	// RVA: 0x8489C44 Offset: 0x8485C44 VA: 0x8489C44
	public void SetFirstCheckId(string firstCheckId) { }
}

// Namespace: ThinkingAnalytics
[Obsolete("TDUpdatableEvent is deprecated, please use ThinkingData.Analytics.TDUpdatableEventModel instead.")]
public class TDUpdatableEvent : ThinkingAnalyticsEvent // TypeDefIndex: 27576
{
	// Methods

	// RVA: 0x8489C4C Offset: 0x8485C4C VA: 0x8489C4C
	public void .ctor(string eventName, Dictionary<string, object> properties, string eventId) { }
}

// Namespace: ThinkingAnalytics
[Obsolete("TDOverWritableEvent is deprecated, please use ThinkingData.Analytics.TDOverwritableEventModel instead.")]
public class TDOverWritableEvent : ThinkingAnalyticsEvent // TypeDefIndex: 27577
{
	// Methods

	// RVA: 0x8489CE4 Offset: 0x8485CE4 VA: 0x8489CE4
	public void .ctor(string eventName, Dictionary<string, object> properties, string eventId) { }
}

// Namespace: ThinkingAnalytics
[Obsolete("TDPresetProperties is deprecated, please use ThinkingData.Analytics.TDPresetProperties instead.")]
public class TDPresetProperties // TypeDefIndex: 27578
{
	// Fields
	[CompilerGenerated]
	private Dictionary<string, object> <mPresetProperties>k__BackingField; // 0x10

	// Properties
	public string AppVersion { get; }
	public string BundleId { get; }
	public string Carrier { get; }
	public string DeviceId { get; }
	public string DeviceModel { get; }
	public string Manufacturer { get; }
	public string NetworkType { get; }
	public string OS { get; }
	public string OSVersion { get; }
	public double ScreenHeight { get; }
	public double ScreenWidth { get; }
	public string SystemLanguage { get; }
	public double ZoneOffset { get; }
	public string InstallTime { get; }
	public string Disk { get; }
	public string Ram { get; }
	public double Fps { get; }
	public bool Simulator { get; }
	private Dictionary<string, object> mPresetProperties { get; set; }

	// Methods

	// RVA: 0x8482E1C Offset: 0x847EE1C VA: 0x8482E1C
	public void .ctor(Dictionary<string, object> properties) { }

	// RVA: 0x848A030 Offset: 0x8486030 VA: 0x848A030
	public Dictionary<string, object> ToEventPresetProperties() { }

	// RVA: 0x848A038 Offset: 0x8486038 VA: 0x848A038
	public string get_AppVersion() { }

	// RVA: 0x848A11C Offset: 0x848611C VA: 0x848A11C
	public string get_BundleId() { }

	// RVA: 0x848A200 Offset: 0x8486200 VA: 0x848A200
	public string get_Carrier() { }

	// RVA: 0x848A2E4 Offset: 0x84862E4 VA: 0x848A2E4
	public string get_DeviceId() { }

	// RVA: 0x848A3C8 Offset: 0x84863C8 VA: 0x848A3C8
	public string get_DeviceModel() { }

	// RVA: 0x848A4AC Offset: 0x84864AC VA: 0x848A4AC
	public string get_Manufacturer() { }

	// RVA: 0x848A590 Offset: 0x8486590 VA: 0x848A590
	public string get_NetworkType() { }

	// RVA: 0x848A674 Offset: 0x8486674 VA: 0x848A674
	public string get_OS() { }

	// RVA: 0x848A758 Offset: 0x8486758 VA: 0x848A758
	public string get_OSVersion() { }

	// RVA: 0x848A83C Offset: 0x848683C VA: 0x848A83C
	public double get_ScreenHeight() { }

	// RVA: 0x848A930 Offset: 0x8486930 VA: 0x848A930
	public double get_ScreenWidth() { }

	// RVA: 0x848AA24 Offset: 0x8486A24 VA: 0x848AA24
	public string get_SystemLanguage() { }

	// RVA: 0x848AB08 Offset: 0x8486B08 VA: 0x848AB08
	public double get_ZoneOffset() { }

	// RVA: 0x848ABFC Offset: 0x8486BFC VA: 0x848ABFC
	public string get_InstallTime() { }

	// RVA: 0x848ACE0 Offset: 0x8486CE0 VA: 0x848ACE0
	public string get_Disk() { }

	// RVA: 0x848ADC4 Offset: 0x8486DC4 VA: 0x848ADC4
	public string get_Ram() { }

	// RVA: 0x848AEA8 Offset: 0x8486EA8 VA: 0x848AEA8
	public double get_Fps() { }

	// RVA: 0x848AF9C Offset: 0x8486F9C VA: 0x848AF9C
	public bool get_Simulator() { }

	[CompilerGenerated]
	// RVA: 0x848B08C Offset: 0x848708C VA: 0x848B08C
	private Dictionary<string, object> get_mPresetProperties() { }

	[CompilerGenerated]
	// RVA: 0x848B094 Offset: 0x8487094 VA: 0x848B094
	private void set_mPresetProperties(Dictionary<string, object> value) { }

	// RVA: 0x8489D7C Offset: 0x8485D7C VA: 0x8489D7C
	private Dictionary<string, object> TDEncodeDate(Dictionary<string, object> properties) { }
}

// Namespace: ThinkingData.Analytics
[DisallowMultipleComponent]
public class TDAnalytics : MonoBehaviour // TypeDefIndex: 27579
{
	// Fields
	[Header("Configuration")]
	[Tooltip("Enable Start SDK Manually")]
	public bool startManually; // 0x20
	[Tooltip("Enable Log")]
	public bool enableLog; // 0x21
	[Tooltip("Sets the Network Type")]
	public TDNetworkType networkType; // 0x24
	[Header("Project")]
	[Tooltip("Project Setting, APP ID is given when the project is created")]
	[HideInInspector]
	public TDConfig[] configs; // 0x28
	private static TDAnalytics sThinkingData; // 0x0
	private static bool tracking_enabled; // 0x8
	private static List<Dictionary<string, object>> eventCaches; // 0x10

	// Methods

	// RVA: 0x848B09C Offset: 0x848709C VA: 0x848B09C
	public static void EnableLog(bool enable) { }

	// RVA: 0x848B1C8 Offset: 0x84871C8 VA: 0x848B1C8
	public static void SetDistinctId(string distinctId, string appId = "") { }

	// RVA: 0x848B47C Offset: 0x848747C VA: 0x848B47C
	public static string GetDistinctId(string appId = "") { }

	// RVA: 0x848B514 Offset: 0x8487514 VA: 0x848B514
	public static string GetAccountId(string appId = "") { }

	// RVA: 0x848B600 Offset: 0x8487600 VA: 0x848B600
	public static void Login(string account, string appId = "") { }

	// RVA: 0x848B8B4 Offset: 0x84878B4 VA: 0x848B8B4
	public static void Logout(string appId = "") { }

	// RVA: 0x848BB2C Offset: 0x8487B2C VA: 0x848BB2C
	public static void EnableAutoTrack(TDAutoTrackEventType eventType, Dictionary<string, object> properties, string appId = "") { }

	// RVA: 0x848BFE8 Offset: 0x8487FE8 VA: 0x848BFE8
	public static void EnableAutoTrack(TDAutoTrackEventType eventType, TDAutoTrackEventHandler eventHandler, string appId = "") { }

	// RVA: 0x848C47C Offset: 0x848847C VA: 0x848C47C
	public static void SetAutoTrackProperties(TDAutoTrackEventType eventType, Dictionary<string, object> properties, string appId = "") { }

	// RVA: 0x848CA20 Offset: 0x8488A20 VA: 0x848CA20
	public static void Track(string eventName, string appId = "") { }

	// RVA: 0x848CA88 Offset: 0x8488A88 VA: 0x848CA88
	public static void Track(string eventName, Dictionary<string, object> properties, string appId = "") { }

	// RVA: 0x848CD88 Offset: 0x8488D88 VA: 0x848CD88
	public static void TrackStr(string eventName, string properties = "", string appId = "") { }

	// RVA: 0x848D0F4 Offset: 0x84890F4 VA: 0x848D0F4
	public static void Track(string eventName, Dictionary<string, object> properties, DateTime time, TimeZoneInfo timeZone, string appId = "") { }

	// RVA: 0x848D498 Offset: 0x8489498 VA: 0x848D498
	public static void Track(TDEventModel eventModel, string appId = "") { }

	// RVA: 0x848D74C Offset: 0x848974C VA: 0x848D74C
	public static void QuickTrack(string eventName, Dictionary<string, object> properties, string appId = "") { }

	// RVA: 0x848DA4C Offset: 0x8489A4C VA: 0x848DA4C
	public static void Flush(string appId = "") { }

	// RVA: 0x848DCC4 Offset: 0x8489CC4 VA: 0x848DCC4
	public static void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x848DFE4 Offset: 0x8489FE4 VA: 0x848DFE4
	public static void OnSceneUnloaded(Scene scene) { }

	// RVA: 0x848E298 Offset: 0x848A298 VA: 0x848E298
	public static void SetSuperProperties(Dictionary<string, object> properties, string appId = "") { }

	// RVA: 0x848E54C Offset: 0x848A54C VA: 0x848E54C
	public static void SetSuperProperties(string properties, string appId = "") { }

	// RVA: 0x848E864 Offset: 0x848A864 VA: 0x848E864
	public static void UnsetSuperProperty(string property, string appId = "") { }

	// RVA: 0x848EB18 Offset: 0x848AB18 VA: 0x848EB18
	public static Dictionary<string, object> GetSuperProperties(string appId = "") { }

	// RVA: 0x848EBB0 Offset: 0x848ABB0 VA: 0x848EBB0
	public static void ClearSuperProperties(string appId = "") { }

	// RVA: 0x848EE28 Offset: 0x848AE28 VA: 0x848EE28
	public static TDPresetProperties GetPresetProperties(string appId = "") { }

	// RVA: 0x848EF28 Offset: 0x848AF28 VA: 0x848EF28
	public static void SetDynamicSuperProperties(TDDynamicSuperPropertiesHandler propertiesHandler, string appId = "") { }

	// RVA: 0x848F1DC Offset: 0x848B1DC VA: 0x848F1DC
	public static void TimeEvent(string eventName, string appId = "") { }

	// RVA: 0x848F490 Offset: 0x848B490 VA: 0x848F490
	public static void UserSet(Dictionary<string, object> properties, string appId = "") { }

	// RVA: 0x848F744 Offset: 0x848B744 VA: 0x848F744
	public static void UserSet(string properties, string appId = "") { }

	// RVA: 0x848FA5C Offset: 0x848BA5C VA: 0x848FA5C
	public static void UserSet(Dictionary<string, object> properties, DateTime dateTime, string appId = "") { }

	// RVA: 0x848FD7C Offset: 0x848BD7C VA: 0x848FD7C
	public static void UserUnset(string property, string appId = "") { }

	// RVA: 0x848FE94 Offset: 0x848BE94 VA: 0x848FE94
	public static void UserUnset(List<string> properties, string appId = "") { }

	// RVA: 0x8490148 Offset: 0x848C148 VA: 0x8490148
	public static void UserUnset(List<string> properties, DateTime dateTime, string appId = "") { }

	// RVA: 0x8490468 Offset: 0x848C468 VA: 0x8490468
	public static void UserSetOnce(Dictionary<string, object> properties, string appId = "") { }

	// RVA: 0x849071C Offset: 0x848C71C VA: 0x849071C
	public static void UserSetOnce(string properties, string appId = "") { }

	// RVA: 0x8490A34 Offset: 0x848CA34 VA: 0x8490A34
	public static void UserSetOnce(Dictionary<string, object> properties, DateTime dateTime, string appId = "") { }

	// RVA: 0x8490D54 Offset: 0x848CD54 VA: 0x8490D54
	public static void UserAdd(string property, object value, string appId = "") { }

	// RVA: 0x8490E30 Offset: 0x848CE30 VA: 0x8490E30
	public static void UserAdd(Dictionary<string, object> properties, string appId = "") { }

	// RVA: 0x84910E4 Offset: 0x848D0E4 VA: 0x84910E4
	public static void UserAddStr(string properties, string appId = "") { }

	// RVA: 0x84913FC Offset: 0x848D3FC VA: 0x84913FC
	public static void UserAdd(Dictionary<string, object> properties, DateTime dateTime, string appId = "") { }

	// RVA: 0x849171C Offset: 0x848D71C VA: 0x849171C
	public static void UserAppend(Dictionary<string, object> properties, string appId = "") { }

	// RVA: 0x84919D0 Offset: 0x848D9D0 VA: 0x84919D0
	public static void UserAppend(string properties, string appId = "") { }

	// RVA: 0x8491CE8 Offset: 0x848DCE8 VA: 0x8491CE8
	public static void UserAppend(Dictionary<string, object> properties, DateTime dateTime, string appId = "") { }

	// RVA: 0x8492008 Offset: 0x848E008 VA: 0x8492008
	public static void UserUniqAppend(Dictionary<string, object> properties, string appId = "") { }

	// RVA: 0x84922BC Offset: 0x848E2BC VA: 0x84922BC
	public static void UserUniqAppend(string properties, string appId = "") { }

	// RVA: 0x84925D4 Offset: 0x848E5D4 VA: 0x84925D4
	public static void UserUniqAppend(Dictionary<string, object> properties, DateTime dateTime, string appId = "") { }

	// RVA: 0x84928F4 Offset: 0x848E8F4 VA: 0x84928F4
	public static void UserDelete(string appId = "") { }

	// RVA: 0x8492B6C Offset: 0x848EB6C VA: 0x8492B6C
	public static void SetNetworkType(TDNetworkType networkType, string appId = "") { }

	// RVA: 0x8492E4C Offset: 0x848EE4C VA: 0x8492E4C
	public static string GetSDKVersion() { }

	// RVA: 0x8492EA4 Offset: 0x848EEA4 VA: 0x8492EA4
	public static string GetDeviceId() { }

	// RVA: 0x8492F34 Offset: 0x848EF34 VA: 0x8492F34
	public static void SetTrackStatus(TDTrackStatus status, string appId = "") { }

	[Obsolete("Method is deprecated, please use SetTrackStatus() instead.")]
	// RVA: 0x8493218 Offset: 0x848F218 VA: 0x8493218
	public static void OptOutTracking(string appId = "") { }

	[Obsolete("Method is deprecated, please use SetTrackStatus() instead.")]
	// RVA: 0x8493490 Offset: 0x848F490 VA: 0x8493490
	public static void OptOutTrackingAndDeleteUser(string appId = "") { }

	[Obsolete("Method is deprecated, please use SetTrackStatus() instead.")]
	// RVA: 0x8493708 Offset: 0x848F708 VA: 0x8493708
	public static void OptInTracking(string appId = "") { }

	[Obsolete("Method is deprecated, please use SetTrackStatus() instead.")]
	// RVA: 0x8493980 Offset: 0x848F980 VA: 0x8493980
	public static void EnableTracking(bool enabled, string appId = "") { }

	// RVA: 0x8493C68 Offset: 0x848FC68 VA: 0x8493C68
	public static string LightInstance(string appId = "") { }

	// RVA: 0x8493CF8 Offset: 0x848FCF8 VA: 0x8493CF8
	public static void CalibrateTime(long timestamp) { }

	// RVA: 0x8493D4C Offset: 0x848FD4C VA: 0x8493D4C
	public static void CalibrateTimeWithNtp(string ntpServer) { }

	// RVA: 0x8493DA0 Offset: 0x848FDA0 VA: 0x8493DA0
	public static void EnableThirdPartySharing(TDThirdPartyType shareType, Dictionary<string, object> properties, string appId = "") { }

	// RVA: 0x8494058 Offset: 0x8490058 VA: 0x8494058
	public static string GetLocalRegion() { }

	// RVA: 0x8494080 Offset: 0x8490080 VA: 0x8494080
	public static void Init(string appId, string serverUrl) { }

	// RVA: 0x849410C Offset: 0x849010C VA: 0x849410C
	public static void Init(TDConfig config) { }

	// RVA: 0x84942C4 Offset: 0x84902C4 VA: 0x84942C4
	public static void Init(TDConfig[] configs) { }

	// RVA: 0x8494A1C Offset: 0x8490A1C VA: 0x8494A1C
	private static void FlushEventCaches() { }

	// RVA: 0x8494D88 Offset: 0x8490D88 VA: 0x8494D88
	private void Awake() { }

	// RVA: 0x8494EEC Offset: 0x8490EEC VA: 0x8494EEC
	private void Start() { }

	// RVA: 0x8494EF0 Offset: 0x8490EF0 VA: 0x8494EF0
	private void OnApplicationQuit() { }

	// RVA: 0x8494EF4 Offset: 0x8490EF4 VA: 0x8494EF4
	public void .ctor() { }

	// RVA: 0x8494F68 Offset: 0x8490F68 VA: 0x8494F68
	private static void .cctor() { }
}

// Namespace: ThinkingData.Analytics
[Serializable]
public class TDConfig // TypeDefIndex: 27580
{
	// Fields
	public string appId; // 0x10
	public string serverUrl; // 0x18
	public TDMode mode; // 0x20
	public TDTimeZone timeZone; // 0x24
	public string timeZoneId; // 0x28
	internal bool enableEncrypt; // 0x30
	internal int encryptVersion; // 0x34
	internal string encryptPublicKey; // 0x38
	internal string symType; // 0x40
	internal string asymType; // 0x48
	public TDSSLPinningMode pinningMode; // 0x50
	public bool allowInvalidCertificates; // 0x54
	public bool validatesDomainName; // 0x55
	private string sName; // 0x58
	public int reportingToTencentSdk; // 0x60

	// Properties
	public string name { get; set; }

	// Methods

	// RVA: 0x8489A40 Offset: 0x8485A40 VA: 0x8489A40
	public void set_name(string value) { }

	// RVA: 0x8495004 Offset: 0x8491004 VA: 0x8495004
	public string get_name() { }

	// RVA: 0x848993C Offset: 0x848593C VA: 0x848993C
	public void .ctor(string appId, string serverUrl) { }

	// RVA: 0x8489ADC Offset: 0x8485ADC VA: 0x8489ADC
	public void EnableEncrypt(string publicKey, int version = 0, string symType = "", string asymType = "") { }

	// RVA: 0x849500C Offset: 0x849100C VA: 0x849500C
	public string getTimeZoneId() { }
}

// Namespace: ThinkingData.Analytics
public enum TDTimeZone // TypeDefIndex: 27581
{
	// Fields
	public int value__; // 0x0
	public const TDTimeZone Local = 0;
	public const TDTimeZone UTC = 1;
	public const TDTimeZone Asia_Shanghai = 2;
	public const TDTimeZone Asia_Tokyo = 3;
	public const TDTimeZone America_Los_Angeles = 4;
	public const TDTimeZone America_New_York = 5;
	public const TDTimeZone Other = 100;
}

// Namespace: ThinkingData.Analytics
public enum TDMode // TypeDefIndex: 27582
{
	// Fields
	public int value__; // 0x0
	public const TDMode Debug = 1;
	public const TDMode DebugOnly = 2;
	public const TDMode Normal = 0;
}

// Namespace: ThinkingData.Analytics
public enum TDNetworkType // TypeDefIndex: 27583
{
	// Fields
	public int value__; // 0x0
	public const TDNetworkType Wifi = 2;
	public const TDNetworkType All = 1;
}

// Namespace: ThinkingData.Analytics
[Flags]
public enum TDAutoTrackEventType // TypeDefIndex: 27584
{
	// Fields
	public int value__; // 0x0
	public const TDAutoTrackEventType None = 0;
	public const TDAutoTrackEventType AppStart = 1;
	public const TDAutoTrackEventType AppEnd = 2;
	public const TDAutoTrackEventType AppCrash = 16;
	public const TDAutoTrackEventType AppInstall = 32;
	public const TDAutoTrackEventType AppSceneLoad = 64;
	public const TDAutoTrackEventType AppSceneUnload = 128;
	public const TDAutoTrackEventType All = 243;
}

// Namespace: ThinkingData.Analytics
public enum TDTrackStatus // TypeDefIndex: 27585
{
	// Fields
	public int value__; // 0x0
	public const TDTrackStatus Pause = 1;
	public const TDTrackStatus Stop = 2;
	public const TDTrackStatus SaveOnly = 3;
	public const TDTrackStatus Normal = 4;
}

// Namespace: 
public enum TDEventModel.TDEventType // TypeDefIndex: 27586
{
	// Fields
	public int value__; // 0x0
	public const TDEventModel.TDEventType First = 0;
	public const TDEventModel.TDEventType Updatable = 1;
	public const TDEventModel.TDEventType Overwritable = 2;
}

// Namespace: ThinkingData.Analytics
public abstract class TDEventModel // TypeDefIndex: 27587
{
	// Fields
	[CompilerGenerated]
	private Nullable<TDEventModel.TDEventType> <EventType>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <EventName>k__BackingField; // 0x18
	[CompilerGenerated]
	private Dictionary<string, object> <Properties>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <StrProperties>k__BackingField; // 0x28
	[CompilerGenerated]
	private DateTime <EventTime>k__BackingField; // 0x30
	[CompilerGenerated]
	private TimeZoneInfo <EventTimeZone>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <ExtraId>k__BackingField; // 0x40

	// Properties
	public Nullable<TDEventModel.TDEventType> EventType { get; set; }
	public string EventName { get; }
	public Dictionary<string, object> Properties { get; set; }
	public string StrProperties { get; set; }
	private DateTime EventTime { get; set; }
	private TimeZoneInfo EventTimeZone { get; set; }
	protected string ExtraId { get; set; }

	// Methods

	// RVA: 0x84950EC Offset: 0x84910EC VA: 0x84950EC
	public void .ctor(string eventName) { }

	[CompilerGenerated]
	// RVA: 0x849511C Offset: 0x849111C VA: 0x849511C
	public Nullable<TDEventModel.TDEventType> get_EventType() { }

	[CompilerGenerated]
	// RVA: 0x8495124 Offset: 0x8491124 VA: 0x8495124
	public void set_EventType(Nullable<TDEventModel.TDEventType> value) { }

	[CompilerGenerated]
	// RVA: 0x849512C Offset: 0x849112C VA: 0x849512C
	public string get_EventName() { }

	[CompilerGenerated]
	// RVA: 0x8495134 Offset: 0x8491134 VA: 0x8495134
	public Dictionary<string, object> get_Properties() { }

	[CompilerGenerated]
	// RVA: 0x849513C Offset: 0x849113C VA: 0x849513C
	public void set_Properties(Dictionary<string, object> value) { }

	[CompilerGenerated]
	// RVA: 0x8495144 Offset: 0x8491144 VA: 0x8495144
	public string get_StrProperties() { }

	[CompilerGenerated]
	// RVA: 0x849514C Offset: 0x849114C VA: 0x849514C
	public void set_StrProperties(string value) { }

	[CompilerGenerated]
	// RVA: 0x8495154 Offset: 0x8491154 VA: 0x8495154
	private DateTime get_EventTime() { }

	[CompilerGenerated]
	// RVA: 0x849515C Offset: 0x849115C VA: 0x849515C
	private void set_EventTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x8495164 Offset: 0x8491164 VA: 0x8495164
	private TimeZoneInfo get_EventTimeZone() { }

	[CompilerGenerated]
	// RVA: 0x849516C Offset: 0x849116C VA: 0x849516C
	private void set_EventTimeZone(TimeZoneInfo value) { }

	[CompilerGenerated]
	// RVA: 0x8495174 Offset: 0x8491174 VA: 0x8495174
	protected string get_ExtraId() { }

	[CompilerGenerated]
	// RVA: 0x849517C Offset: 0x849117C VA: 0x849517C
	protected void set_ExtraId(string value) { }

	// RVA: 0x84808D0 Offset: 0x847C8D0 VA: 0x84808D0
	public void SetTime(DateTime time, TimeZoneInfo timeZone) { }

	// RVA: 0x8495184 Offset: 0x8491184 VA: 0x8495184
	public DateTime GetEventTime() { }

	// RVA: 0x849518C Offset: 0x849118C VA: 0x849518C
	public TimeZoneInfo GetEventTimeZone() { }

	// RVA: 0x8495194 Offset: 0x8491194 VA: 0x8495194
	public string GetEventId() { }
}

// Namespace: ThinkingData.Analytics
public class TDFirstEventModel : TDEventModel // TypeDefIndex: 27588
{
	// Methods

	// RVA: 0x84807AC Offset: 0x847C7AC VA: 0x84807AC
	public void .ctor(string eventName) { }

	// RVA: 0x8480830 Offset: 0x847C830 VA: 0x8480830
	public void .ctor(string eventName, string firstCheckId) { }
}

// Namespace: ThinkingData.Analytics
public class TDUpdatableEventModel : TDEventModel // TypeDefIndex: 27589
{
	// Methods

	// RVA: 0x848070C Offset: 0x847C70C VA: 0x848070C
	public void .ctor(string eventName, string eventId) { }
}

// Namespace: ThinkingData.Analytics
public class TDOverwritableEventModel : TDEventModel // TypeDefIndex: 27590
{
	// Methods

	// RVA: 0x849519C Offset: 0x849119C VA: 0x849519C
	public void .ctor(string eventName, string eventId) { }
}

// Namespace: ThinkingData.Analytics
public interface TDDynamicSuperPropertiesHandler // TypeDefIndex: 27591
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Dictionary<string, object> GetDynamicSuperProperties();
}

// Namespace: ThinkingData.Analytics
public interface TDAutoTrackEventHandler // TypeDefIndex: 27592
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Dictionary<string, object> GetAutoTrackEventProperties(int type, Dictionary<string, object> properties);
}

// Namespace: ThinkingData.Analytics
public class TDPresetProperties // TypeDefIndex: 27593
{
	// Fields
	[CompilerGenerated]
	private Dictionary<string, object> <mPresetProperties>k__BackingField; // 0x10

	// Properties
	public string AppVersion { get; }
	public string BundleId { get; }
	public string Carrier { get; }
	public string DeviceId { get; }
	public string DeviceModel { get; }
	public string Manufacturer { get; }
	public string NetworkType { get; }
	public string OS { get; }
	public string OSVersion { get; }
	public double ScreenHeight { get; }
	public double ScreenWidth { get; }
	public string SystemLanguage { get; }
	public double ZoneOffset { get; }
	public string InstallTime { get; }
	public string Disk { get; }
	public string Ram { get; }
	public double Fps { get; }
	public bool Simulator { get; }
	private Dictionary<string, object> mPresetProperties { get; set; }

	// Methods

	// RVA: 0x848EEF0 Offset: 0x848AEF0 VA: 0x848EEF0
	public void .ctor(Dictionary<string, object> properties) { }

	// RVA: 0x84954F0 Offset: 0x84914F0 VA: 0x84954F0
	public Dictionary<string, object> ToDictionary() { }

	// RVA: 0x84954F8 Offset: 0x84914F8 VA: 0x84954F8
	public string get_AppVersion() { }

	// RVA: 0x84955DC Offset: 0x84915DC VA: 0x84955DC
	public string get_BundleId() { }

	// RVA: 0x84956C0 Offset: 0x84916C0 VA: 0x84956C0
	public string get_Carrier() { }

	// RVA: 0x84957A4 Offset: 0x84917A4 VA: 0x84957A4
	public string get_DeviceId() { }

	// RVA: 0x8495888 Offset: 0x8491888 VA: 0x8495888
	public string get_DeviceModel() { }

	// RVA: 0x849596C Offset: 0x849196C VA: 0x849596C
	public string get_Manufacturer() { }

	// RVA: 0x8495A50 Offset: 0x8491A50 VA: 0x8495A50
	public string get_NetworkType() { }

	// RVA: 0x8495B34 Offset: 0x8491B34 VA: 0x8495B34
	public string get_OS() { }

	// RVA: 0x8495C18 Offset: 0x8491C18 VA: 0x8495C18
	public string get_OSVersion() { }

	// RVA: 0x8495CFC Offset: 0x8491CFC VA: 0x8495CFC
	public double get_ScreenHeight() { }

	// RVA: 0x8495DF0 Offset: 0x8491DF0 VA: 0x8495DF0
	public double get_ScreenWidth() { }

	// RVA: 0x8495EE4 Offset: 0x8491EE4 VA: 0x8495EE4
	public string get_SystemLanguage() { }

	// RVA: 0x8495FC8 Offset: 0x8491FC8 VA: 0x8495FC8
	public double get_ZoneOffset() { }

	// RVA: 0x84960BC Offset: 0x84920BC VA: 0x84960BC
	public string get_InstallTime() { }

	// RVA: 0x84961A0 Offset: 0x84921A0 VA: 0x84961A0
	public string get_Disk() { }

	// RVA: 0x8496284 Offset: 0x8492284 VA: 0x8496284
	public string get_Ram() { }

	// RVA: 0x8496368 Offset: 0x8492368 VA: 0x8496368
	public double get_Fps() { }

	// RVA: 0x849645C Offset: 0x849245C VA: 0x849645C
	public bool get_Simulator() { }

	[CompilerGenerated]
	// RVA: 0x849654C Offset: 0x849254C VA: 0x849654C
	private Dictionary<string, object> get_mPresetProperties() { }

	[CompilerGenerated]
	// RVA: 0x8496554 Offset: 0x8492554 VA: 0x8496554
	private void set_mPresetProperties(Dictionary<string, object> value) { }

	// RVA: 0x849523C Offset: 0x849123C VA: 0x849523C
	private Dictionary<string, object> TDEncodeDate(Dictionary<string, object> properties) { }
}

// Namespace: ThinkingData.Analytics
public class TDAnalyticSetting : ScriptableObject // TypeDefIndex: 27594
{
	// Fields
	public string appId; // 0x18
	public string serverUrl; // 0x20
	public bool enableLog; // 0x28
	public TDNetworkType networkType; // 0x2C
	public TDMode mode; // 0x30
	public TDTimeZone timeZone; // 0x34
	public int encryptVersion; // 0x38
	public string encryptPublicKey; // 0x40

	// Methods

	// RVA: 0x84948D4 Offset: 0x84908D4 VA: 0x84948D4
	public static TDAnalyticSetting GetSerializedObject() { }

	// RVA: 0x849655C Offset: 0x849255C VA: 0x849655C
	public void .ctor() { }
}

// Namespace: 
public interface TDWrapper.IDynamicSuperPropertiesTrackerListener // TypeDefIndex: 27595
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string getDynamicSuperPropertiesString();
}

// Namespace: 
private class TDWrapper.DynamicListenerAdapter : AndroidJavaProxy // TypeDefIndex: 27596
{
	// Methods

	// RVA: 0x849CFA0 Offset: 0x8498FA0 VA: 0x849CFA0
	public void .ctor() { }

	// RVA: 0x849E854 Offset: 0x849A854 VA: 0x849E854
	public string getDynamicSuperPropertiesString() { }
}

// Namespace: 
public interface TDWrapper.IAutoTrackEventTrackerListener // TypeDefIndex: 27597
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string eventCallback(int type, string appId, string properties);
}

// Namespace: 
private class TDWrapper.AutoTrackListenerAdapter : AndroidJavaProxy // TypeDefIndex: 27598
{
	// Methods

	// RVA: 0x849D500 Offset: 0x8499500 VA: 0x849D500
	public void .ctor() { }

	// RVA: 0x849E9AC Offset: 0x849A9AC VA: 0x849E9AC
	private string eventCallback(int type, string appId, string properties) { }
}

// Namespace: ThinkingData.Analytics.Wrapper
public class TDWrapper // TypeDefIndex: 27599
{
	// Fields
	private static readonly AndroidJavaClass sdkClass; // 0x0
	private static TimeZoneInfo defaultTimeZone; // 0x8
	private static TDTimeZone defaultTDTimeZone; // 0x10
	public static MonoBehaviour sMono; // 0x18
	private static TDDynamicSuperPropertiesHandler mDynamicSuperProperties; // 0x20
	private static Dictionary<string, TDAutoTrackEventHandler> mAutoTrackEventCallbacks; // 0x28
	private static Dictionary<string, Dictionary<string, object>> mAutoTrackProperties; // 0x30
	private static Dictionary<string, TDAutoTrackEventType> mAutoTrackEventInfos; // 0x38
	private static Random rnd; // 0x40
	private static string default_appId; // 0x48
	private static string TDAutoTrackEventType_APP_SCENE_LOAD; // 0x50
	private static string TDAutoTrackEventType_APP_SCENE_UNLOAD; // 0x58

	// Methods

	// RVA: 0x8496570 Offset: 0x8492570 VA: 0x8496570
	private static string getTimeString(DateTime dateTime) { }

	// RVA: 0x8496C48 Offset: 0x8492C48 VA: 0x8496C48
	private static void enableLog(bool enable) { }

	// RVA: 0x8496D78 Offset: 0x8492D78 VA: 0x8496D78
	private static void setVersionInfo(string libName, string version) { }

	// RVA: 0x8496EA8 Offset: 0x8492EA8 VA: 0x8496EA8
	private static void init(TDConfig token) { }

	// RVA: 0x849738C Offset: 0x849338C VA: 0x849738C
	private static void flush(string appId) { }

	// RVA: 0x849747C Offset: 0x849347C VA: 0x849747C
	private static long getDateTimeStamp(DateTime dateTime) { }

	// RVA: 0x849757C Offset: 0x849357C VA: 0x849757C
	private static void track(string eventName, Dictionary<string, object> properties, DateTime dateTime, string appId) { }

	// RVA: 0x8497A14 Offset: 0x8493A14 VA: 0x8497A14
	private static void track(string eventName, Dictionary<string, object> properties, DateTime dateTime, TimeZoneInfo timeZone, string appId) { }

	// RVA: 0x8497F64 Offset: 0x8493F64 VA: 0x8497F64
	private static void trackForAll(string eventName, Dictionary<string, object> properties) { }

	// RVA: 0x8498320 Offset: 0x8494320 VA: 0x8498320
	private static void track(TDEventModel taEvent, string appId) { }

	// RVA: 0x8497FE4 Offset: 0x8493FE4 VA: 0x8497FE4
	private static void track(string eventName, Dictionary<string, object> properties, string appId) { }

	// RVA: 0x84989C0 Offset: 0x84949C0 VA: 0x84989C0
	private static void trackStr(string eventName, string properties, string appId) { }

	// RVA: 0x8498CF0 Offset: 0x8494CF0 VA: 0x8498CF0
	private static void setSuperProperties(Dictionary<string, object> superProperties, string appId) { }

	// RVA: 0x8498F0C Offset: 0x8494F0C VA: 0x8498F0C
	private static void setSuperProperties(string superProperties, string appId) { }

	// RVA: 0x849911C Offset: 0x849511C VA: 0x849911C
	private static void unsetSuperProperty(string superPropertyName, string appId) { }

	// RVA: 0x849924C Offset: 0x849524C VA: 0x849924C
	private static void clearSuperProperty(string appId) { }

	// RVA: 0x849933C Offset: 0x849533C VA: 0x849933C
	private static Dictionary<string, object> getSuperProperties(string appId) { }

	// RVA: 0x8499524 Offset: 0x8495524 VA: 0x8499524
	private static Dictionary<string, object> getPresetProperties(string appId) { }

	// RVA: 0x8499700 Offset: 0x8495700 VA: 0x8499700
	private static void timeEvent(string eventName, string appId) { }

	// RVA: 0x8499830 Offset: 0x8495830 VA: 0x8499830
	private static void timeEventForAll(string eventName) { }

	// RVA: 0x8499978 Offset: 0x8495978 VA: 0x8499978
	private static void identify(string uniqueId, string appId) { }

	// RVA: 0x8499AA8 Offset: 0x8495AA8 VA: 0x8499AA8
	private static string getDistinctId(string appId) { }

	// RVA: 0x8499BAC Offset: 0x8495BAC VA: 0x8499BAC
	private static string getAccountId(string appId) { }

	// RVA: 0x8499CB0 Offset: 0x8495CB0 VA: 0x8499CB0
	private static void login(string uniqueId, string appId) { }

	// RVA: 0x8499DE0 Offset: 0x8495DE0 VA: 0x8499DE0
	private static void userSetOnce(Dictionary<string, object> properties, string appId) { }

	// RVA: 0x849A064 Offset: 0x8496064 VA: 0x849A064
	private static void userSetOnce(string properties, string appId) { }

	// RVA: 0x849A2DC Offset: 0x84962DC VA: 0x849A2DC
	private static void userSetOnce(Dictionary<string, object> properties, DateTime dateTime, string appId) { }

	// RVA: 0x849A57C Offset: 0x849657C VA: 0x849A57C
	private static void userSet(Dictionary<string, object> properties, string appId) { }

	// RVA: 0x849A800 Offset: 0x8496800 VA: 0x849A800
	private static void userSet(Dictionary<string, object> properties, DateTime dateTime, string appId) { }

	// RVA: 0x849AAA0 Offset: 0x8496AA0 VA: 0x849AAA0
	private static void userSet(string properties, string appId) { }

	// RVA: 0x849AD18 Offset: 0x8496D18 VA: 0x849AD18
	private static void userUnset(List<string> properties, string appId) { }

	// RVA: 0x849ADB4 Offset: 0x8496DB4 VA: 0x849ADB4
	private static void userUnset(List<string> properties, DateTime dateTime, string appId) { }

	// RVA: 0x849B1FC Offset: 0x84971FC VA: 0x849B1FC
	private static void userAdd(Dictionary<string, object> properties, string appId) { }

	// RVA: 0x849B480 Offset: 0x8497480 VA: 0x849B480
	private static void userAddStr(string properties, string appId) { }

	// RVA: 0x849B6F8 Offset: 0x84976F8 VA: 0x849B6F8
	private static void userAdd(Dictionary<string, object> properties, DateTime dateTime, string appId) { }

	// RVA: 0x849B998 Offset: 0x8497998 VA: 0x849B998
	private static void userAppend(Dictionary<string, object> properties, string appId) { }

	// RVA: 0x849BC1C Offset: 0x8497C1C VA: 0x849BC1C
	private static void userAppend(string properties, string appId) { }

	// RVA: 0x849BE94 Offset: 0x8497E94 VA: 0x849BE94
	private static void userAppend(Dictionary<string, object> properties, DateTime dateTime, string appId) { }

	// RVA: 0x849C134 Offset: 0x8498134 VA: 0x849C134
	private static void userUniqAppend(Dictionary<string, object> properties, string appId) { }

	// RVA: 0x849C3B8 Offset: 0x84983B8 VA: 0x849C3B8
	private static void userUniqAppend(string properties, string appId) { }

	// RVA: 0x849C630 Offset: 0x8498630 VA: 0x849C630
	private static void userUniqAppend(Dictionary<string, object> properties, DateTime dateTime, string appId) { }

	// RVA: 0x849C8D0 Offset: 0x84988D0 VA: 0x849C8D0
	private static void userDelete(string appId) { }

	// RVA: 0x849CA28 Offset: 0x8498A28 VA: 0x849CA28
	private static void userDelete(DateTime dateTime, string appId) { }

	// RVA: 0x849CC68 Offset: 0x8498C68 VA: 0x849CC68
	private static void logout(string appId) { }

	// RVA: 0x849CD58 Offset: 0x8498D58 VA: 0x849CD58
	private static string getDeviceId() { }

	// RVA: 0x849CE50 Offset: 0x8498E50 VA: 0x849CE50
	private static void setDynamicSuperProperties(TDDynamicSuperPropertiesHandler dynamicSuperProperties, string appId) { }

	// RVA: 0x849D010 Offset: 0x8499010 VA: 0x849D010
	private static void setNetworkType(TDNetworkType networkType) { }

	// RVA: 0x849D194 Offset: 0x8499194 VA: 0x849D194
	private static void enableAutoTrack(TDAutoTrackEventType events, Dictionary<string, object> properties, string appId) { }

	// RVA: 0x849D344 Offset: 0x8499344 VA: 0x849D344
	private static void enableAutoTrack(TDAutoTrackEventType events, TDAutoTrackEventHandler eventCallback, string appId) { }

	// RVA: 0x849D570 Offset: 0x8499570 VA: 0x849D570
	private static void setAutoTrackProperties(TDAutoTrackEventType events, Dictionary<string, object> properties, string appId) { }

	// RVA: 0x849D71C Offset: 0x849971C VA: 0x849D71C
	private static void setTrackStatus(TDTrackStatus status, string appId) { }

	// RVA: 0x849D8A0 Offset: 0x84998A0 VA: 0x849D8A0
	private static void optOutTracking(string appId) { }

	// RVA: 0x849D8A4 Offset: 0x84998A4 VA: 0x849D8A4
	private static void optOutTrackingAndDeleteUser(string appId) { }

	// RVA: 0x849D8A8 Offset: 0x84998A8 VA: 0x849D8A8
	private static void optInTracking(string appId) { }

	// RVA: 0x849D8AC Offset: 0x84998AC VA: 0x849D8AC
	private static void enableTracking(bool enabled, string appId) { }

	// RVA: 0x849D8B0 Offset: 0x84998B0 VA: 0x849D8B0
	private static string createLightInstance() { }

	// RVA: 0x849D9CC Offset: 0x84999CC VA: 0x849D9CC
	private static void calibrateTime(long timestamp) { }

	// RVA: 0x849DAF0 Offset: 0x8499AF0 VA: 0x849DAF0
	private static void calibrateTimeWithNtp(string ntpServer) { }

	// RVA: 0x849DBE0 Offset: 0x8499BE0 VA: 0x849DBE0
	private static void enableThirdPartySharing(TDThirdPartyType shareType, Dictionary<string, object> properties, string appId) { }

	// RVA: 0x849DD8C Offset: 0x8499D8C VA: 0x849DD8C
	public static void AddDictionary(Dictionary<string, object> originalDic, Dictionary<string, object> subDic) { }

	// RVA: 0x84978CC Offset: 0x84938CC VA: 0x84978CC
	private static string getJsonStr(Dictionary<string, object> data) { }

	// RVA: -1 Offset: -1
	private static string serilize<T>(Dictionary<string, T> data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x470F4B4 Offset: 0x470B4B4 VA: 0x470F4B4
	|-TDWrapper.serilize<object>
	|
	|-RVA: 0x470F538 Offset: 0x470B538 VA: 0x470F538
	|-TDWrapper.serilize<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x8489014 Offset: 0x8485014 VA: 0x8489014
	public static void ShareInstance(TDConfig token, MonoBehaviour mono, bool initRequired = True) { }

	// RVA: 0x847D7D8 Offset: 0x84797D8 VA: 0x847D7D8
	public static void EnableLog(bool enable) { }

	// RVA: 0x8488E14 Offset: 0x8484E14 VA: 0x8488E14
	public static void SetVersionInfo(string version) { }

	// RVA: 0x847DAE0 Offset: 0x8479AE0 VA: 0x847DAE0
	public static void SetDistinctId(string uniqueId, string appId) { }

	// RVA: 0x847DBDC Offset: 0x8479BDC VA: 0x847DBDC
	public static string GetDistinctId(string appId) { }

	// RVA: 0x848B5AC Offset: 0x84875AC VA: 0x848B5AC
	public static string GetAccountId(string appId) { }

	// RVA: 0x847DEE4 Offset: 0x8479EE4 VA: 0x847DEE4
	public static void Login(string accountId, string appId) { }

	// RVA: 0x847E1C0 Offset: 0x847A1C0 VA: 0x847E1C0
	public static void Logout(string appId) { }

	// RVA: 0x847E6D0 Offset: 0x847A6D0 VA: 0x847E6D0
	public static void EnableAutoTrack(TDAutoTrackEventType events, Dictionary<string, object> properties, string appId) { }

	// RVA: 0x847EE8C Offset: 0x847AE8C VA: 0x847EE8C
	public static void EnableAutoTrack(TDAutoTrackEventType events, TDAutoTrackEventHandler eventCallback, string appId) { }

	// RVA: 0x847F510 Offset: 0x847B510 VA: 0x847F510
	public static void SetAutoTrackProperties(TDAutoTrackEventType events, Dictionary<string, object> properties, string appId) { }

	// RVA: 0x8481520 Offset: 0x847D520 VA: 0x8481520
	public static void TrackSceneLoad(Scene scene, string appId = "") { }

	// RVA: 0x8481E0C Offset: 0x847DE0C VA: 0x8481E0C
	public static void TrackSceneUnload(Scene scene, string appId = "") { }

	// RVA: 0x849DF10 Offset: 0x8499F10 VA: 0x849DF10
	private static void UpdateAutoTrackSceneInfos(TDAutoTrackEventType events, string appId = "") { }

	// RVA: 0x8498810 Offset: 0x8494810 VA: 0x8498810
	private static Dictionary<string, object> getFinalEventProperties(Dictionary<string, object> properties) { }

	// RVA: 0x847FA40 Offset: 0x847BA40 VA: 0x847FA40
	public static void Track(string eventName, Dictionary<string, object> properties, string appId) { }

	// RVA: 0x848D088 Offset: 0x8489088 VA: 0x848D088
	public static void TrackStr(string eventName, string properties, string appId) { }

	// RVA: 0x847FE48 Offset: 0x847BE48 VA: 0x847FE48
	public static void Track(string eventName, Dictionary<string, object> properties, DateTime datetime, string appId) { }

	// RVA: 0x848029C Offset: 0x847C29C VA: 0x848029C
	public static void Track(string eventName, Dictionary<string, object> properties, DateTime datetime, TimeZoneInfo timeZone, string appId) { }

	// RVA: 0x849E35C Offset: 0x849A35C VA: 0x849E35C
	public static void TrackForAll(string eventName, Dictionary<string, object> properties) { }

	// RVA: 0x84808E0 Offset: 0x847C8E0 VA: 0x84808E0
	public static void Track(TDEventModel taEvent, string appId) { }

	// RVA: 0x8480D0C Offset: 0x847CD0C VA: 0x8480D0C
	public static void QuickTrack(string eventName, Dictionary<string, object> properties, string appId) { }

	// RVA: 0x848255C Offset: 0x847E55C VA: 0x848255C
	public static void SetSuperProperties(Dictionary<string, object> superProperties, string appId) { }

	// RVA: 0x848E800 Offset: 0x848A800 VA: 0x848E800
	public static void SetSuperProperties(string superProperties, string appId) { }

	// RVA: 0x84828B8 Offset: 0x847E8B8 VA: 0x84828B8
	public static void UnsetSuperProperty(string superPropertyName, string appId) { }

	// RVA: 0x8482CAC Offset: 0x847ECAC VA: 0x8482CAC
	public static void ClearSuperProperty(string appId) { }

	// RVA: 0x848357C Offset: 0x847F57C VA: 0x848357C
	public static void TimeEvent(string eventName, string appId) { }

	// RVA: 0x849E3F4 Offset: 0x849A3F4 VA: 0x849E3F4
	public static void TimeEventForAll(string eventName) { }

	// RVA: 0x84829E0 Offset: 0x847E9E0 VA: 0x84829E0
	public static Dictionary<string, object> GetSuperProperties(string appId) { }

	// RVA: 0x8482DC8 Offset: 0x847EDC8 VA: 0x8482DC8
	public static Dictionary<string, object> GetPresetProperties(string appId) { }

	// RVA: 0x84838C0 Offset: 0x847F8C0 VA: 0x84838C0
	public static void UserSet(Dictionary<string, object> properties, string appId) { }

	// RVA: 0x848F9F8 Offset: 0x848B9F8 VA: 0x848F9F8
	public static void UserSet(string properties, string appId) { }

	// RVA: 0x8483C88 Offset: 0x847FC88 VA: 0x8483C88
	public static void UserSet(Dictionary<string, object> properties, DateTime dateTime, string appId) { }

	// RVA: 0x8484800 Offset: 0x8480800 VA: 0x8484800
	public static void UserSetOnce(Dictionary<string, object> properties, string appId) { }

	// RVA: 0x84909D0 Offset: 0x848C9D0 VA: 0x84909D0
	public static void UserSetOnce(string properties, string appId) { }

	// RVA: 0x8484BC8 Offset: 0x8480BC8 VA: 0x8484BC8
	public static void UserSetOnce(Dictionary<string, object> properties, DateTime dateTime, string appId) { }

	// RVA: 0x8484104 Offset: 0x8480104 VA: 0x8484104
	public static void UserUnset(List<string> properties, string appId) { }

	// RVA: 0x84844B4 Offset: 0x84804B4 VA: 0x84844B4
	public static void UserUnset(List<string> properties, DateTime dateTime, string appId) { }

	// RVA: 0x8485008 Offset: 0x8481008 VA: 0x8485008
	public static void UserAdd(Dictionary<string, object> properties, string appId) { }

	// RVA: 0x8491398 Offset: 0x848D398 VA: 0x8491398
	public static void UserAddStr(string properties, string appId) { }

	// RVA: 0x84853D0 Offset: 0x84813D0 VA: 0x84853D0
	public static void UserAdd(Dictionary<string, object> properties, DateTime dateTime, string appId) { }

	// RVA: 0x8485734 Offset: 0x8481734 VA: 0x8485734
	public static void UserAppend(Dictionary<string, object> properties, string appId) { }

	// RVA: 0x8491C84 Offset: 0x848DC84 VA: 0x8491C84
	public static void UserAppend(string properties, string appId) { }

	// RVA: 0x8485AFC Offset: 0x8481AFC VA: 0x8485AFC
	public static void UserAppend(Dictionary<string, object> properties, DateTime dateTime, string appId) { }

	// RVA: 0x8485E60 Offset: 0x8481E60 VA: 0x8485E60
	public static void UserUniqAppend(Dictionary<string, object> properties, string appId) { }

	// RVA: 0x8492570 Offset: 0x848E570 VA: 0x8492570
	public static void UserUniqAppend(string properties, string appId) { }

	// RVA: 0x8486228 Offset: 0x8482228 VA: 0x8486228
	public static void UserUniqAppend(Dictionary<string, object> properties, DateTime dateTime, string appId) { }

	// RVA: 0x8486550 Offset: 0x8482550 VA: 0x8486550
	public static void UserDelete(string appId) { }

	// RVA: 0x8486888 Offset: 0x8482888 VA: 0x8486888
	public static void UserDelete(DateTime dateTime, string appId) { }

	// RVA: 0x84811AC Offset: 0x847D1AC VA: 0x84811AC
	public static void Flush(string appId) { }

	// RVA: 0x8486BCC Offset: 0x8482BCC VA: 0x8486BCC
	public static void SetNetworkType(TDNetworkType networkType) { }

	// RVA: 0x8486CB0 Offset: 0x8482CB0 VA: 0x8486CB0
	public static string GetDeviceId() { }

	// RVA: 0x848313C Offset: 0x847F13C VA: 0x848313C
	public static void SetDynamicSuperProperties(TDDynamicSuperPropertiesHandler dynamicSuperProperties, string appId) { }

	// RVA: 0x8486FE0 Offset: 0x8482FE0 VA: 0x8486FE0
	public static void SetTrackStatus(TDTrackStatus status, string appId) { }

	// RVA: 0x84872BC Offset: 0x84832BC VA: 0x84872BC
	public static void OptOutTracking(string appId) { }

	// RVA: 0x8487588 Offset: 0x8483588 VA: 0x8487588
	public static void OptOutTrackingAndDeleteUser(string appId) { }

	// RVA: 0x8487854 Offset: 0x8483854 VA: 0x8487854
	public static void OptInTracking(string appId) { }

	// RVA: 0x8487B90 Offset: 0x8483B90 VA: 0x8487B90
	public static void EnableTracking(bool enabled, string appId) { }

	// RVA: 0x8487C74 Offset: 0x8483C74 VA: 0x8487C74
	public static string CreateLightInstance() { }

	// RVA: 0x8487D14 Offset: 0x8483D14 VA: 0x8487D14
	public static void CalibrateTime(long timestamp) { }

	// RVA: 0x8487DBC Offset: 0x8483DBC VA: 0x8487DBC
	public static void CalibrateTimeWithNtp(string ntpServer) { }

	// RVA: 0x84880C8 Offset: 0x84840C8 VA: 0x84880C8
	public static void EnableThirdPartySharing(TDThirdPartyType shareType, Dictionary<string, object> properties, string appId = "") { }

	// RVA: 0x849E5E8 Offset: 0x849A5E8 VA: 0x849E5E8
	public void .ctor() { }

	// RVA: 0x849E5F0 Offset: 0x849A5F0 VA: 0x849E5F0
	private static void .cctor() { }
}

// Namespace: ThinkingData.Analytics.Utils
public class TDCommonUtils // TypeDefIndex: 27600
{
	// Methods

	// RVA: 0x84968EC Offset: 0x84928EC VA: 0x84968EC
	public static string FormatDate(DateTime dateTime, TimeZoneInfo timeZone) { }

	// RVA: 0x8496614 Offset: 0x8492614 VA: 0x8496614
	public static string FormatDate(DateTime dateTime, TDTimeZone timeZone) { }

	// RVA: 0x849EB80 Offset: 0x849AB80 VA: 0x849EB80
	public void .ctor() { }
}

// Namespace: ThinkingData.Analytics.Utils
public class TDLog // TypeDefIndex: 27601
{
	// Fields
	private static bool enableLog; // 0x0

	// Methods

	// RVA: 0x849EB88 Offset: 0x849AB88 VA: 0x849EB88
	public static void EnableLog(bool enabled) { }

	// RVA: 0x849EBD8 Offset: 0x849ABD8 VA: 0x849EBD8
	public static bool GetEnable() { }

	// RVA: 0x8494968 Offset: 0x8490968 VA: 0x8494968
	public static void i(string message) { }

	// RVA: 0x8488E80 Offset: 0x8484E80 VA: 0x8488E80
	public static void d(string message) { }

	// RVA: 0x849EC20 Offset: 0x849AC20 VA: 0x849EC20
	public static void e(string message) { }

	// RVA: 0x8497960 Offset: 0x8493960 VA: 0x8497960
	public static void w(string message) { }

	// RVA: 0x849ECD4 Offset: 0x849ACD4 VA: 0x849ECD4
	public void .ctor() { }
}

// Namespace: 
private enum TDMiniJson.Parser.TOKEN // TypeDefIndex: 27602
{
	// Fields
	public int value__; // 0x0
	public const TDMiniJson.Parser.TOKEN NONE = 0;
	public const TDMiniJson.Parser.TOKEN CURLY_OPEN = 1;
	public const TDMiniJson.Parser.TOKEN CURLY_CLOSE = 2;
	public const TDMiniJson.Parser.TOKEN SQUARED_OPEN = 3;
	public const TDMiniJson.Parser.TOKEN SQUARED_CLOSE = 4;
	public const TDMiniJson.Parser.TOKEN COLON = 5;
	public const TDMiniJson.Parser.TOKEN COMMA = 6;
	public const TDMiniJson.Parser.TOKEN STRING = 7;
	public const TDMiniJson.Parser.TOKEN NUMBER = 8;
	public const TDMiniJson.Parser.TOKEN TRUE = 9;
	public const TDMiniJson.Parser.TOKEN FALSE = 10;
	public const TDMiniJson.Parser.TOKEN NULL = 11;
}

// Namespace: 
private sealed class TDMiniJson.Parser : IDisposable // TypeDefIndex: 27603
{
	// Fields
	private const string WORD_BREAK = "{}[],:\"";
	private StringReader json; // 0x10

	// Properties
	private char PeekChar { get; }
	private char NextChar { get; }
	private string NextWord { get; }
	private TDMiniJson.Parser.TOKEN NextToken { get; }

	// Methods

	// RVA: 0x849EF10 Offset: 0x849AF10 VA: 0x849EF10
	public static bool IsWordBreak(char c) { }

	// RVA: 0x849EFAC Offset: 0x849AFAC VA: 0x849EFAC
	private void .ctor(string jsonString) { }

	// RVA: 0x849ECDC Offset: 0x849ACDC VA: 0x849ECDC
	public static Dictionary<string, object> Parse(string jsonString) { }

	// RVA: 0x849F14C Offset: 0x849B14C VA: 0x849F14C Slot: 4
	public void Dispose() { }

	// RVA: 0x849F028 Offset: 0x849B028 VA: 0x849F028
	private Dictionary<string, object> ParseObject() { }

	// RVA: 0x849F5DC Offset: 0x849B5DC VA: 0x849F5DC
	private List<object> ParseArray() { }

	// RVA: 0x849F5C0 Offset: 0x849B5C0 VA: 0x849F5C0
	private object ParseValue() { }

	// RVA: 0x849F708 Offset: 0x849B708 VA: 0x849F708
	private object ParseByToken(TDMiniJson.Parser.TOKEN token) { }

	// RVA: 0x849F340 Offset: 0x849B340 VA: 0x849F340
	private string ParseString() { }

	// RVA: 0x849F880 Offset: 0x849B880 VA: 0x849F880
	private object ParseNumber() { }

	// RVA: 0x849FB48 Offset: 0x849BB48 VA: 0x849FB48
	private void EatWhitespace() { }

	// RVA: 0x849FBEC Offset: 0x849BBEC VA: 0x849FBEC
	private char get_PeekChar() { }

	// RVA: 0x849FA1C Offset: 0x849BA1C VA: 0x849FA1C
	private char get_NextChar() { }

	// RVA: 0x849FA94 Offset: 0x849BA94 VA: 0x849FA94
	private string get_NextWord() { }

	// RVA: 0x849F17C Offset: 0x849B17C VA: 0x849F17C
	private TDMiniJson.Parser.TOKEN get_NextToken() { }
}

// Namespace: 
private sealed class TDMiniJson.Serializer // TypeDefIndex: 27604
{
	// Fields
	private StringBuilder builder; // 0x10
	private Func<DateTime, string> func; // 0x18

	// Methods

	// RVA: 0x849FC64 Offset: 0x849BC64 VA: 0x849FC64
	private void .ctor() { }

	// RVA: 0x849EE78 Offset: 0x849AE78 VA: 0x849EE78
	public static string Serialize(object obj, Func<DateTime, string> func) { }

	// RVA: 0x849FCD0 Offset: 0x849BCD0 VA: 0x849FCD0
	private void SerializeValue(object value) { }

	// RVA: 0x84A04BC Offset: 0x849C4BC VA: 0x84A04BC
	private void SerializeObject(IDictionary obj) { }

	// RVA: 0x84A015C Offset: 0x849C15C VA: 0x84A015C
	private void SerializeArray(IList anArray) { }

	// RVA: 0x849FEA0 Offset: 0x849BEA0 VA: 0x849FEA0
	private void SerializeString(string str) { }

	// RVA: 0x84A0948 Offset: 0x849C948 VA: 0x84A0948
	private void SerializeOther(object value) { }
}

// Namespace: ThinkingData.Analytics.Utils
public class TDMiniJson // TypeDefIndex: 27605
{
	// Methods

	// RVA: 0x8499518 Offset: 0x8495518 VA: 0x8499518
	public static Dictionary<string, object> Deserialize(string json) { }

	// RVA: 0x849D340 Offset: 0x8499340 VA: 0x849D340
	public static string Serialize(object obj, Func<DateTime, string> func) { }

	// RVA: 0x849EF08 Offset: 0x849AF08 VA: 0x849EF08
	public void .ctor() { }
}

// Namespace: ThinkingData.Analytics.Utils
public class TDPropertiesChecker // TypeDefIndex: 27606
{
	// Fields
	private static readonly Regex keyPattern; // 0x0
	private static readonly List<string> propertyNameWhitelist; // 0x8

	// Methods

	// RVA: 0x84A0E20 Offset: 0x849CE20 VA: 0x84A0E20
	public static bool IsNumeric(object obj) { }

	// RVA: 0x84A0FC0 Offset: 0x849CFC0 VA: 0x84A0FC0
	public static bool IsString(object obj) { }

	// RVA: 0x84A101C Offset: 0x849D01C VA: 0x84A101C
	public static bool IsDictionary(object obj) { }

	// RVA: 0x84A1100 Offset: 0x849D100 VA: 0x84A1100
	public static bool IsList(object obj) { }

	// RVA: -1 Offset: -1
	public static bool CheckProperties<V>(Dictionary<string, V> properties) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x470E63C Offset: 0x470A63C VA: 0x470E63C
	|-TDPropertiesChecker.CheckProperties<object>
	|
	|-RVA: 0x470EB18 Offset: 0x470AB18 VA: 0x470EB18
	|-TDPropertiesChecker.CheckProperties<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x84A122C Offset: 0x849D22C VA: 0x84A122C
	public static bool CheckProperties(List<object> properties) { }

	// RVA: 0x849E474 Offset: 0x849A474 VA: 0x849E474
	public static bool CheckProperties(List<string> properties) { }

	// RVA: 0x84A166C Offset: 0x849D66C VA: 0x84A166C
	public static bool CheckProperties(string properties) { }

	// RVA: 0x84A17A4 Offset: 0x849D7A4 VA: 0x84A17A4
	public static bool CheckProperties(double properties) { }

	// RVA: 0x849E1BC Offset: 0x849A1BC VA: 0x849E1BC
	public static bool CheckString(string eventName) { }

	// RVA: 0x849DFD0 Offset: 0x8499FD0 VA: 0x849DFD0
	public static void MergeProperties(Dictionary<string, object> source, Dictionary<string, object> dest) { }

	// RVA: 0x84A1888 Offset: 0x849D888 VA: 0x84A1888
	public void .ctor() { }

	// RVA: 0x84A1890 Offset: 0x849D890 VA: 0x84A1890
	private static void .cctor() { }
}

// Namespace: ThinkingData.Analytics.Utils
public enum TDThirdPartyType // TypeDefIndex: 27607
{
	// Fields
	public int value__; // 0x0
	public const TDThirdPartyType NONE = 0;
	public const TDThirdPartyType APPSFLYER = 1;
	public const TDThirdPartyType IRONSOURCE = 2;
	public const TDThirdPartyType ADJUST = 4;
	public const TDThirdPartyType BRANCH = 8;
	public const TDThirdPartyType TOPON = 16;
	public const TDThirdPartyType TRACKING = 32;
	public const TDThirdPartyType TRADPLUS = 64;
}

// Namespace: ThinkingData.Analytics.Utils
public enum TDSSLPinningMode // TypeDefIndex: 27608
{
	// Fields
	public int value__; // 0x0
	public const TDSSLPinningMode NONE = 0;
	public const TDSSLPinningMode PUBLIC_KEY = 1;
	public const TDSSLPinningMode CERTIFICATE = 2;
}

// Namespace: ThinkingData.Analytics.Utils
public class TDPublicConfig // TypeDefIndex: 27609
{
	// Fields
	public static bool DisableCSharpException; // 0x0
	public static List<string> DisPresetProperties; // 0x8
	public static readonly string LIB_VERSION; // 0x10

	// Methods

	// RVA: 0x8488988 Offset: 0x8484988 VA: 0x8488988
	public static void GetPublicConfig() { }

	// RVA: 0x84A1AE4 Offset: 0x849DAE4 VA: 0x84A1AE4
	public void .ctor() { }

	// RVA: 0x84A1AEC Offset: 0x849DAEC VA: 0x84A1AEC
	private static void .cctor() { }
}

// Namespace: ThinkingData.Analytics.TDException
public class TDExceptionHandler // TypeDefIndex: 27610
{
	// Fields
	public static bool IsQuitWhenException; // 0x0
	public static bool IsRegistered; // 0x1
	private static TDAutoTrackEventHandler mEventCallback; // 0x8
	private static Dictionary<string, object> mProperties; // 0x10

	// Methods

	// RVA: 0x848C7DC Offset: 0x84887DC VA: 0x848C7DC
	public static void SetAutoTrackProperties(Dictionary<string, object> properties) { }

	// RVA: 0x847EFCC Offset: 0x847AFCC VA: 0x847EFCC
	public static void RegisterTAExceptionHandler(TDAutoTrackEventHandler eventCallback) { }

	// RVA: 0x847E7EC Offset: 0x847A7EC VA: 0x847E7EC
	public static void RegisterTAExceptionHandler(Dictionary<string, object> properties) { }

	// RVA: 0x84A1BB0 Offset: 0x849DBB0 VA: 0x84A1BB0
	public static void UnregisterTAExceptionHandler() { }

	// RVA: 0x84A1D30 Offset: 0x849DD30 VA: 0x84A1D30
	private static void _LogHandler(string logString, string stackTrace, LogType type) { }

	// RVA: 0x84A23B0 Offset: 0x849E3B0 VA: 0x84A23B0
	private static void _UncaughtExceptionHandler(object sender, UnhandledExceptionEventArgs args) { }

	// RVA: 0x84A2064 Offset: 0x849E064 VA: 0x84A2064
	private static Dictionary<string, object> MergeProperties(Dictionary<string, object> properties) { }

	// RVA: 0x84A2804 Offset: 0x849E804 VA: 0x84A2804
	public void .ctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1489 // TypeDefIndex: 27611
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1631 // TypeDefIndex: 27612
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 27613
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1489 18FC837D4CDFCA696695188871C78DF28B4565F374246EB08263D7702DF1C49C /*Metadata offset 0xF4ED10*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1631 D6132FF4055DA6A05AFF4C88866033997A8C65EEEAD69A6B0B820E1085FF8489 /*Metadata offset 0xF4F2E8*/; // 0x5D1
}

