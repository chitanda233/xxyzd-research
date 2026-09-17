// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 24613
{}

// Namespace: 
public enum TournamentSortOrder // TypeDefIndex: 24614
{
	// Fields
	public int value__; // 0x0
	public const TournamentSortOrder HigherIsBetter = 0;
	public const TournamentSortOrder LowerIsBetter = 1;
}

// Namespace: 
public enum TournamentScoreFormat // TypeDefIndex: 24615
{
	// Fields
	public int value__; // 0x0
	public const TournamentScoreFormat Numeric = 0;
	public const TournamentScoreFormat Time = 1;
}

// Namespace: 
private enum Json.Parser.TOKEN // TypeDefIndex: 24616
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
private sealed class Json.Parser : IDisposable // TypeDefIndex: 24617
{
	// Fields
	private StringReader json; // 0x10

	// Properties
	private char PeekChar { get; }
	private char NextChar { get; }
	private string NextWord { get; }
	private Json.Parser.TOKEN NextToken { get; }

	// Methods

	// RVA: 0x411482C Offset: 0x411082C VA: 0x411482C
	private void .ctor(string jsonString) { }

	// RVA: 0x41148A8 Offset: 0x41108A8 VA: 0x41148A8
	private char get_PeekChar() { }

	// RVA: 0x4114920 Offset: 0x4110920 VA: 0x4114920
	private char get_NextChar() { }

	// RVA: 0x4114998 Offset: 0x4110998 VA: 0x4114998
	private string get_NextWord() { }

	// RVA: 0x4114A78 Offset: 0x4110A78 VA: 0x4114A78
	private Json.Parser.TOKEN get_NextToken() { }

	// RVA: 0x411455C Offset: 0x411055C VA: 0x411455C
	public static object Parse(string jsonString) { }

	// RVA: 0x4114CF4 Offset: 0x4110CF4 VA: 0x4114CF4 Slot: 4
	public void Dispose() { }

	// RVA: 0x4114D24 Offset: 0x4110D24 VA: 0x4114D24
	private Dictionary<string, object> ParseObject() { }

	// RVA: 0x41150A4 Offset: 0x41110A4 VA: 0x41150A4
	private List<object> ParseArray() { }

	// RVA: 0x4114CD8 Offset: 0x4110CD8 VA: 0x4114CD8
	private object ParseValue() { }

	// RVA: 0x41151D0 Offset: 0x41111D0 VA: 0x41151D0
	private object ParseByToken(Json.Parser.TOKEN token) { }

	// RVA: 0x4114E48 Offset: 0x4110E48 VA: 0x4114E48
	private string ParseString() { }

	// RVA: 0x41152C0 Offset: 0x41112C0 VA: 0x41152C0
	private object ParseNumber() { }

	// RVA: 0x4114C3C Offset: 0x4110C3C VA: 0x4114C3C
	private void EatWhitespace() { }
}

// Namespace: 
private sealed class Json.Serializer // TypeDefIndex: 24618
{
	// Fields
	private StringBuilder builder; // 0x10

	// Methods

	// RVA: 0x41153B8 Offset: 0x41113B8 VA: 0x41153B8
	private void .ctor() { }

	// RVA: 0x4114708 Offset: 0x4110708 VA: 0x4114708
	public static string Serialize(object obj) { }

	// RVA: 0x4115424 Offset: 0x4111424 VA: 0x4115424
	private void SerializeValue(object value) { }

	// RVA: 0x4115BDC Offset: 0x4111BDC VA: 0x4115BDC
	private void SerializeObject(IDictionary obj) { }

	// RVA: 0x411587C Offset: 0x411187C VA: 0x411587C
	private void SerializeArray(IList array) { }

	// RVA: 0x41155C4 Offset: 0x41115C4 VA: 0x41155C4
	private void SerializeString(string str) { }

	// RVA: 0x4116068 Offset: 0x4112068 VA: 0x4116068
	private void SerializeOther(object value) { }
}

// Namespace: Facebook.MiniJSON
public static class Json // TypeDefIndex: 24619
{
	// Fields
	private static NumberFormatInfo numberFormat; // 0x0

	// Methods

	// RVA: 0x4114550 Offset: 0x4110550 VA: 0x4114550
	public static object Deserialize(string json) { }

	// RVA: 0x4114704 Offset: 0x4110704 VA: 0x4114704
	public static string Serialize(object obj) { }

	// RVA: 0x411477C Offset: 0x411077C VA: 0x411477C
	private static void .cctor() { }
}

// Namespace: Facebook.Unity
public class AccessToken // TypeDefIndex: 24620
{
	// Fields
	[CompilerGenerated]
	private static AccessToken <CurrentAccessToken>k__BackingField; // 0x0
	[CompilerGenerated]
	private string <TokenString>k__BackingField; // 0x10
	[CompilerGenerated]
	private DateTime <ExpirationTime>k__BackingField; // 0x18
	[CompilerGenerated]
	private IEnumerable<string> <Permissions>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <UserId>k__BackingField; // 0x28
	[CompilerGenerated]
	private Nullable<DateTime> <LastRefresh>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <GraphDomain>k__BackingField; // 0x40

	// Properties
	public static AccessToken CurrentAccessToken { get; set; }
	public string TokenString { get; set; }
	public DateTime ExpirationTime { get; set; }
	public IEnumerable<string> Permissions { get; set; }
	public string UserId { get; set; }
	public Nullable<DateTime> LastRefresh { get; set; }
	public string GraphDomain { get; set; }

	// Methods

	// RVA: 0x4116244 Offset: 0x4112244 VA: 0x4116244
	internal void .ctor(string tokenString, string userId, DateTime expirationTime, IEnumerable<string> permissions, Nullable<DateTime> lastRefresh, string graphDomain) { }

	[CompilerGenerated]
	// RVA: 0x4116414 Offset: 0x4112414 VA: 0x4116414
	public static AccessToken get_CurrentAccessToken() { }

	[CompilerGenerated]
	// RVA: 0x411645C Offset: 0x411245C VA: 0x411645C
	internal static void set_CurrentAccessToken(AccessToken value) { }

	[CompilerGenerated]
	// RVA: 0x41164B4 Offset: 0x41124B4 VA: 0x41164B4
	public string get_TokenString() { }

	[CompilerGenerated]
	// RVA: 0x41164BC Offset: 0x41124BC VA: 0x41164BC
	private void set_TokenString(string value) { }

	[CompilerGenerated]
	// RVA: 0x41164C4 Offset: 0x41124C4 VA: 0x41164C4
	public DateTime get_ExpirationTime() { }

	[CompilerGenerated]
	// RVA: 0x41164CC Offset: 0x41124CC VA: 0x41164CC
	private void set_ExpirationTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x41164D4 Offset: 0x41124D4 VA: 0x41164D4
	public IEnumerable<string> get_Permissions() { }

	[CompilerGenerated]
	// RVA: 0x41164DC Offset: 0x41124DC VA: 0x41164DC
	private void set_Permissions(IEnumerable<string> value) { }

	[CompilerGenerated]
	// RVA: 0x41164E4 Offset: 0x41124E4 VA: 0x41164E4
	public string get_UserId() { }

	[CompilerGenerated]
	// RVA: 0x41164EC Offset: 0x41124EC VA: 0x41164EC
	private void set_UserId(string value) { }

	[CompilerGenerated]
	// RVA: 0x41164F4 Offset: 0x41124F4 VA: 0x41164F4
	public Nullable<DateTime> get_LastRefresh() { }

	[CompilerGenerated]
	// RVA: 0x4116500 Offset: 0x4112500 VA: 0x4116500
	private void set_LastRefresh(Nullable<DateTime> value) { }

	[CompilerGenerated]
	// RVA: 0x4116508 Offset: 0x4112508 VA: 0x4116508
	public string get_GraphDomain() { }

	[CompilerGenerated]
	// RVA: 0x4116510 Offset: 0x4112510 VA: 0x4116510
	private void set_GraphDomain(string value) { }

	// RVA: 0x4116518 Offset: 0x4112518 VA: 0x4116518 Slot: 3
	public override string ToString() { }

	// RVA: 0x4116CD0 Offset: 0x4112CD0 VA: 0x4116CD0
	internal string ToJson() { }
}

// Namespace: Facebook.Unity
internal class CallbackManager // TypeDefIndex: 24621
{
	// Fields
	private IDictionary<string, object> facebookDelegates; // 0x10
	private int nextAsyncId; // 0x18

	// Methods

	// RVA: -1 Offset: -1
	public string AddFacebookDelegate<T>(FacebookDelegate<T> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x454D098 Offset: 0x4549098 VA: 0x454D098
	|-CallbackManager.AddFacebookDelegate<object>
	|
	|-RVA: 0x454D190 Offset: 0x4549190 VA: 0x454D190
	|-CallbackManager.AddFacebookDelegate<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x4116F40 Offset: 0x4112F40 VA: 0x4116F40
	public void OnFacebookResponse(IInternalResult result) { }

	// RVA: 0x41171AC Offset: 0x41131AC VA: 0x41171AC
	private static void CallCallback(object callback, IResult result) { }

	// RVA: -1 Offset: -1
	private static bool TryCallCallback<T>(object callback, IResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x454D288 Offset: 0x4549288 VA: 0x454D288
	|-CallbackManager.TryCallCallback<object>
	|
	|-RVA: 0x454D340 Offset: 0x4549340 VA: 0x454D340
	|-CallbackManager.TryCallCallback<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x4117924 Offset: 0x4113924 VA: 0x4117924
	public void .ctor() { }
}

// Namespace: 
internal enum ComponentFactory.IfNotExist // TypeDefIndex: 24622
{
	// Fields
	public int value__; // 0x0
	public const ComponentFactory.IfNotExist AddNew = 0;
	public const ComponentFactory.IfNotExist ReturnNull = 1;
}

// Namespace: Facebook.Unity
internal class ComponentFactory // TypeDefIndex: 24623
{
	// Fields
	private static GameObject facebookGameObject; // 0x0

	// Properties
	private static GameObject FacebookGameObject { get; }

	// Methods

	// RVA: 0x41179AC Offset: 0x41139AC VA: 0x41179AC
	private static GameObject get_FacebookGameObject() { }

	// RVA: -1 Offset: -1
	public static T GetComponent<T>(ComponentFactory.IfNotExist ifNotExist = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45578CC Offset: 0x45538CC VA: 0x45578CC
	|-ComponentFactory.GetComponent<object>
	*/

	// RVA: -1 Offset: -1
	public static T AddComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4557894 Offset: 0x4553894 VA: 0x4557894
	|-ComponentFactory.AddComponent<object>
	*/
}

// Namespace: Facebook.Unity
internal static class Constants // TypeDefIndex: 24624
{
	// Fields
	private static Nullable<FacebookUnityPlatform> currentPlatform; // 0x0

	// Properties
	public static Uri GraphUrl { get; }
	public static string GraphApiUserAgent { get; }
	public static bool IsMobile { get; }
	public static bool IsEditor { get; }
	public static bool IsWeb { get; }
	public static string UnitySDKUserAgentSuffixLegacy { get; }
	public static string UnitySDKUserAgent { get; }
	public static bool DebugMode { get; }
	public static FacebookUnityPlatform CurrentPlatform { get; }

	// Methods

	// RVA: 0x4117A94 Offset: 0x4113A94 VA: 0x4117A94
	public static Uri get_GraphUrl() { }

	// RVA: 0x4117D54 Offset: 0x4113D54 VA: 0x4117D54
	public static string get_GraphApiUserAgent() { }

	// RVA: 0x4118058 Offset: 0x4114058 VA: 0x4118058
	public static bool get_IsMobile() { }

	// RVA: 0x4118134 Offset: 0x4114134 VA: 0x4118134
	public static bool get_IsEditor() { }

	// RVA: 0x4118184 Offset: 0x4114184 VA: 0x4118184
	public static bool get_IsWeb() { }

	// RVA: 0x411819C Offset: 0x411419C VA: 0x411819C
	public static string get_UnitySDKUserAgentSuffixLegacy() { }

	// RVA: 0x4117FEC Offset: 0x4113FEC VA: 0x4117FEC
	public static string get_UnitySDKUserAgent() { }

	// RVA: 0x411842C Offset: 0x411442C VA: 0x411842C
	public static bool get_DebugMode() { }

	// RVA: 0x411807C Offset: 0x411407C VA: 0x411807C
	public static FacebookUnityPlatform get_CurrentPlatform() { }

	// RVA: 0x411847C Offset: 0x411447C VA: 0x411847C
	private static FacebookUnityPlatform GetCurrentPlatform() { }
}

// Namespace: Facebook.Unity
public sealed class CustomUpdateContent // TypeDefIndex: 24625
{
	// Fields
	private string _contextTokenId; // 0x10
	private CustomUpdateLocalizedText _text; // 0x18
	private CustomUpdateLocalizedText _cta; // 0x20
	private string _image; // 0x28
	private CustomUpdateMedia _media; // 0x30
	private string _data; // 0x38

	// Methods

	// RVA: 0x4118508 Offset: 0x4114508 VA: 0x4118508
	public IDictionary<string, string> toGraphAPIData() { }
}

// Namespace: Facebook.Unity
public sealed class CustomUpdateLocalizedText // TypeDefIndex: 24626
{
	// Fields
	private string _default; // 0x10
	private IDictionary<string, string> _localizations; // 0x18

	// Methods

	// RVA: 0x41186B4 Offset: 0x41146B4 VA: 0x41186B4
	public string toJson() { }
}

// Namespace: Facebook.Unity
public sealed class CustomUpdateMedia // TypeDefIndex: 24627
{
	// Fields
	private CustomUpdateMediaInfo _gif; // 0x10
	private CustomUpdateMediaInfo _video; // 0x18

	// Methods

	// RVA: 0x41187BC Offset: 0x41147BC VA: 0x41187BC
	public string toJson() { }
}

// Namespace: Facebook.Unity
public sealed class CustomUpdateMediaInfo // TypeDefIndex: 24628
{
	// Fields
	private string _url; // 0x10

	// Properties
	public string Url { get; }

	// Methods

	// RVA: 0x411899C Offset: 0x411499C VA: 0x411899C
	public string get_Url() { }
}

// Namespace: 
private sealed class FB.OnDLLLoaded : MulticastDelegate // TypeDefIndex: 24629
{
	// Methods

	// RVA: 0x41199F4 Offset: 0x41159F4 VA: 0x41199F4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x411C808 Offset: 0x4118808 VA: 0x411C808 Slot: 13
	public virtual void Invoke() { }
}

// Namespace: 
public sealed class FB.Canvas // TypeDefIndex: 24630
{
	// Properties
	private static IPayFacebook FacebookPayImpl { get; }

	// Methods

	// RVA: 0x411C81C Offset: 0x411881C VA: 0x411C81C
	private static IPayFacebook get_FacebookPayImpl() { }

	// RVA: 0x411C8D4 Offset: 0x41188D4 VA: 0x411C8D4
	public static void Pay(string product, string action = "purchaseitem", int quantity = 1, Nullable<int> quantityMin, Nullable<int> quantityMax, string requestId, string pricepointId, string testCurrency, FacebookDelegate<IPayResult> callback) { }
}

// Namespace: 
public sealed class FB.Mobile // TypeDefIndex: 24631
{
	// Properties
	public static ShareDialogMode ShareDialogMode { set; }
	private static IMobileFacebook MobileFacebookImpl { get; }

	// Methods

	// RVA: 0x411C9E8 Offset: 0x41189E8 VA: 0x411C9E8
	public static void set_ShareDialogMode(ShareDialogMode value) { }

	// RVA: 0x411CA90 Offset: 0x4118A90 VA: 0x411CA90
	private static IMobileFacebook get_MobileFacebookImpl() { }

	// RVA: 0x411CB48 Offset: 0x4118B48 VA: 0x411CB48
	public static void LoginWithTrackingPreference(LoginTracking loginTracking, IEnumerable<string> permissions, string nonce, FacebookDelegate<ILoginResult> callback) { }

	// RVA: 0x411CC78 Offset: 0x4118C78 VA: 0x411CC78
	public static Profile CurrentProfile() { }

	// RVA: 0x411CD14 Offset: 0x4118D14 VA: 0x411CD14
	public static void FetchDeferredAppLinkData(FacebookDelegate<IAppLinkResult> callback) { }

	// RVA: 0x411CDD0 Offset: 0x4118DD0 VA: 0x411CDD0
	public static void RefreshCurrentAccessToken(FacebookDelegate<IAccessTokenRefreshResult> callback) { }

	// RVA: 0x411CE7C Offset: 0x4118E7C VA: 0x411CE7C
	public static bool IsImplicitPurchaseLoggingEnabled() { }

	// RVA: 0x411CF18 Offset: 0x4118F18 VA: 0x411CF18
	public static void GetTournaments(FacebookDelegate<IGetTournamentsResult> callback) { }

	// RVA: 0x411CFC4 Offset: 0x4118FC4 VA: 0x411CFC4
	public static void UpdateTournament(string tournamentID, int score, FacebookDelegate<ITournamentScoreResult> callback) { }

	// RVA: 0x411D088 Offset: 0x4119088 VA: 0x411D088
	public static void UpdateAndShareTournament(string tournamentID, int score, FacebookDelegate<IDialogResult> callback) { }

	// RVA: 0x411D14C Offset: 0x411914C VA: 0x411D14C
	public static void CreateAndShareTournament(int initialScore, string title, TournamentSortOrder sortOrder, TournamentScoreFormat scoreFormat, DateTime endTime, string payload, FacebookDelegate<IDialogResult> callback) { }
}

// Namespace: 
public sealed class FB.Windows // TypeDefIndex: 24632
{
	// Properties
	private static IWindowsFacebook WindowsFacebookImpl { get; }

	// Methods

	// RVA: 0x411D2FC Offset: 0x41192FC VA: 0x411D2FC
	private static IWindowsFacebook get_WindowsFacebookImpl() { }

	// RVA: 0x411D3B4 Offset: 0x41193B4 VA: 0x411D3B4
	public static void SetVirtualGamepadLayout(string layout, FacebookDelegate<IVirtualGamepadLayoutResult> callback) { }

	// RVA: 0x411D464 Offset: 0x4119464 VA: 0x411D464
	public static void SetSoftKeyboardOpen(bool open, FacebookDelegate<ISoftKeyboardOpenResult> callback) { }

	// RVA: 0x411D518 Offset: 0x4119518 VA: 0x411D518
	public static void CreateReferral(string payload, FacebookDelegate<IReferralsCreateResult> callback) { }

	// RVA: 0x411D5CC Offset: 0x41195CC VA: 0x411D5CC
	public static void GetDataReferral(FacebookDelegate<IReferralsGetDataResult> callback) { }
}

// Namespace: 
internal abstract class FB.CompiledFacebookLoader : MonoBehaviour // TypeDefIndex: 24633
{
	// Properties
	protected abstract FacebookGameObject FBGameObject { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract FacebookGameObject get_FBGameObject();

	// RVA: 0x411D678 Offset: 0x4119678 VA: 0x411D678
	public void Start() { }

	// RVA: 0x411D784 Offset: 0x4119784 VA: 0x411D784
	protected void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FB.<>c__DisplayClass36_0 // TypeDefIndex: 24634
{
	// Fields
	public string appId; // 0x10
	public HideUnityDelegate onHideUnity; // 0x18
	public InitDelegate onInitComplete; // 0x20
	public bool cookie; // 0x28
	public bool logging; // 0x29
	public bool status; // 0x2A
	public bool xfbml; // 0x2B
	public string authResponse; // 0x30
	public bool frictionlessRequests; // 0x38
	public string javascriptSDKLocale; // 0x40
	public string clientToken; // 0x48

	// Methods

	// RVA: 0x41199EC Offset: 0x41159EC VA: 0x41199EC
	public void .ctor() { }

	// RVA: 0x411D78C Offset: 0x411978C VA: 0x411D78C
	internal void <Init>b__0() { }

	// RVA: 0x411D958 Offset: 0x4119958 VA: 0x411D958
	internal void <Init>b__1() { }

	// RVA: 0x411DA0C Offset: 0x4119A0C VA: 0x411DA0C
	internal void <Init>b__2() { }

	// RVA: 0x411DB70 Offset: 0x4119B70 VA: 0x411DB70
	internal void <Init>b__3() { }

	// RVA: 0x411DC74 Offset: 0x4119C74 VA: 0x411DC74
	internal void <Init>b__4() { }

	// RVA: 0x411DD10 Offset: 0x4119D10 VA: 0x411DD10
	internal void <Init>b__5() { }
}

// Namespace: Facebook.Unity
public sealed class FB : ScriptableObject // TypeDefIndex: 24635
{
	// Fields
	private const string DefaultJSSDKLocale = "en_US";
	private static IFacebook facebook; // 0x0
	private static bool isInitCalled; // 0x8
	private static string facebookDomain; // 0x10
	private static string gamingDomain; // 0x18
	private static string graphApiVersion; // 0x20
	[CompilerGenerated]
	private static string <AppId>k__BackingField; // 0x28
	[CompilerGenerated]
	private static string <ClientToken>k__BackingField; // 0x30
	[CompilerGenerated]
	private static FB.OnDLLLoaded <OnDLLLoadedDelegate>k__BackingField; // 0x38

	// Properties
	public static string AppId { get; set; }
	public static string ClientToken { get; set; }
	public static string GraphApiVersion { get; set; }
	public static bool IsLoggedIn { get; }
	public static bool IsInitialized { get; }
	public static bool LimitAppEventUsage { get; set; }
	internal static IFacebook FacebookImpl { get; set; }
	internal static string FacebookDomain { get; set; }
	private static FB.OnDLLLoaded OnDLLLoadedDelegate { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x41189A4 Offset: 0x41149A4 VA: 0x41189A4
	public static string get_AppId() { }

	[CompilerGenerated]
	// RVA: 0x41189FC Offset: 0x41149FC VA: 0x41189FC
	private static void set_AppId(string value) { }

	[CompilerGenerated]
	// RVA: 0x4118A5C Offset: 0x4114A5C VA: 0x4118A5C
	public static string get_ClientToken() { }

	[CompilerGenerated]
	// RVA: 0x4118AB4 Offset: 0x4114AB4 VA: 0x4118AB4
	private static void set_ClientToken(string value) { }

	// RVA: 0x4118B14 Offset: 0x4114B14 VA: 0x4118B14
	public static string get_GraphApiVersion() { }

	// RVA: 0x4118B6C Offset: 0x4114B6C VA: 0x4118B6C
	public static void set_GraphApiVersion(string value) { }

	// RVA: 0x4118BCC Offset: 0x4114BCC VA: 0x4118BCC
	public static bool get_IsLoggedIn() { }

	// RVA: 0x4118CBC Offset: 0x4114CBC VA: 0x4118CBC
	public static bool get_IsInitialized() { }

	// RVA: 0x4118DB4 Offset: 0x4114DB4 VA: 0x4118DB4
	public static bool get_LimitAppEventUsage() { }

	// RVA: 0x4118EAC Offset: 0x4114EAC VA: 0x4118EAC
	public static void set_LimitAppEventUsage(bool value) { }

	// RVA: 0x4117F2C Offset: 0x4113F2C VA: 0x4117F2C
	internal static IFacebook get_FacebookImpl() { }

	// RVA: 0x4118FA8 Offset: 0x4114FA8 VA: 0x4118FA8
	internal static void set_FacebookImpl(IFacebook value) { }

	// RVA: 0x4117C64 Offset: 0x4113C64 VA: 0x4117C64
	internal static string get_FacebookDomain() { }

	// RVA: 0x4119010 Offset: 0x4115010 VA: 0x4119010
	internal static void set_FacebookDomain(string value) { }

	[CompilerGenerated]
	// RVA: 0x4119070 Offset: 0x4115070 VA: 0x4119070
	private static FB.OnDLLLoaded get_OnDLLLoadedDelegate() { }

	[CompilerGenerated]
	// RVA: 0x41190C8 Offset: 0x41150C8 VA: 0x41190C8
	private static void set_OnDLLLoadedDelegate(FB.OnDLLLoaded value) { }

	// RVA: 0x4119128 Offset: 0x4115128 VA: 0x4119128
	public static void Init(InitDelegate onInitComplete, HideUnityDelegate onHideUnity, string authResponse) { }

	// RVA: 0x4119268 Offset: 0x4115268 VA: 0x4119268
	public static void Init(string appId, string clientToken, bool cookie = True, bool logging = True, bool status = True, bool xfbml = False, bool frictionlessRequests = True, string authResponse, string javascriptSDKLocale = "en_US", HideUnityDelegate onHideUnity, InitDelegate onInitComplete) { }

	// RVA: 0x4119B94 Offset: 0x4115B94 VA: 0x4119B94
	public static void LogInWithPublishPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback) { }

	// RVA: 0x4119C74 Offset: 0x4115C74 VA: 0x4119C74
	public static void LogInWithReadPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback) { }

	// RVA: 0x4119D54 Offset: 0x4115D54 VA: 0x4119D54
	public static void LogOut() { }

	// RVA: 0x4119E1C Offset: 0x4115E1C VA: 0x4119E1C
	public static void AppRequest(string message, OGActionType actionType, string objectId, IEnumerable<string> to, string data = "", string title = "", FacebookDelegate<IAppRequestResult> callback) { }

	// RVA: 0x4119F74 Offset: 0x4115F74 VA: 0x4119F74
	public static void AppRequest(string message, OGActionType actionType, string objectId, IEnumerable<object> filters, IEnumerable<string> excludeIds, Nullable<int> maxRecipients, string data = "", string title = "", FacebookDelegate<IAppRequestResult> callback) { }

	// RVA: 0x411A0DC Offset: 0x41160DC VA: 0x411A0DC
	public static void AppRequest(string message, IEnumerable<string> to, IEnumerable<object> filters, IEnumerable<string> excludeIds, Nullable<int> maxRecipients, string data = "", string title = "", FacebookDelegate<IAppRequestResult> callback) { }

	// RVA: 0x411A214 Offset: 0x4116214 VA: 0x411A214
	public static void ShareLink(Uri contentURL, string contentTitle = "", string contentDescription = "", Uri photoURL, FacebookDelegate<IShareResult> callback) { }

	// RVA: 0x411A314 Offset: 0x4116314 VA: 0x411A314
	public static void FeedShare(string toId = "", Uri link, string linkName = "", string linkCaption = "", string linkDescription = "", Uri picture, string mediaSource = "", FacebookDelegate<IShareResult> callback) { }

	// RVA: 0x411A448 Offset: 0x4116448 VA: 0x411A448
	public static void API(string query, HttpMethod method, FacebookDelegate<IGraphResult> callback, IDictionary<string, string> formData) { }

	// RVA: 0x411A5A4 Offset: 0x41165A4 VA: 0x411A5A4
	public static void API(string query, HttpMethod method, FacebookDelegate<IGraphResult> callback, WWWForm formData) { }

	// RVA: 0x411A700 Offset: 0x4116700 VA: 0x411A700
	public static void ActivateApp() { }

	// RVA: 0x411A808 Offset: 0x4116808 VA: 0x411A808
	public static void GetAppLink(FacebookDelegate<IAppLinkResult> callback) { }

	// RVA: 0x411A8E8 Offset: 0x41168E8 VA: 0x411A8E8
	public static void ClearAppLink() { }

	// RVA: 0x411A8EC Offset: 0x41168EC VA: 0x411A8EC
	public static void LogAppEvent(string logEvent, Nullable<float> valueToSum, Dictionary<string, object> parameters) { }

	// RVA: 0x411A9D4 Offset: 0x41169D4 VA: 0x411A9D4
	public static void LogPurchase(Decimal logPurchase, string currency, Dictionary<string, object> parameters) { }

	// RVA: 0x411AAB0 Offset: 0x4116AB0 VA: 0x411AAB0
	public static void LogPurchase(float logPurchase, string currency, Dictionary<string, object> parameters) { }

	// RVA: 0x411ABD0 Offset: 0x4116BD0 VA: 0x411ABD0
	private static void LogVersion() { }

	// RVA: 0x411AE78 Offset: 0x4116E78 VA: 0x411AE78
	public static void GetCatalog(FacebookDelegate<ICatalogResult> callback) { }

	// RVA: 0x411AF48 Offset: 0x4116F48 VA: 0x411AF48
	public static void GetPurchases(FacebookDelegate<IPurchasesResult> callback) { }

	// RVA: 0x411B018 Offset: 0x4117018 VA: 0x411B018
	public static void Purchase(string productID, FacebookDelegate<IPurchaseResult> callback, string developerPayload = "") { }

	// RVA: 0x411B100 Offset: 0x4117100 VA: 0x411B100
	public static void ConsumePurchase(string productToken, FacebookDelegate<IConsumePurchaseResult> callback) { }

	// RVA: 0x411B1E0 Offset: 0x41171E0 VA: 0x411B1E0
	public static void GetSubscribableCatalog(FacebookDelegate<ISubscribableCatalogResult> callback) { }

	// RVA: 0x411B2B0 Offset: 0x41172B0 VA: 0x411B2B0
	public static void GetSubscriptions(FacebookDelegate<ISubscriptionsResult> callback) { }

	// RVA: 0x411B380 Offset: 0x4117380 VA: 0x411B380
	public static void PurchaseSubscription(string productID, FacebookDelegate<ISubscriptionResult> callback) { }

	// RVA: 0x411B460 Offset: 0x4117460 VA: 0x411B460
	public static void CancelSubscription(string purchaseToken, FacebookDelegate<ICancelSubscriptionResult> callback) { }

	// RVA: 0x411B540 Offset: 0x4117540 VA: 0x411B540
	public static Profile CurrentProfile() { }

	// RVA: 0x411B608 Offset: 0x4117608 VA: 0x411B608
	public static void CurrentProfile(FacebookDelegate<IProfileResult> callback) { }

	// RVA: 0x411B6D8 Offset: 0x41176D8 VA: 0x411B6D8
	public static void LoadInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback) { }

	// RVA: 0x411B7B8 Offset: 0x41177B8 VA: 0x411B7B8
	public static void ShowInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback) { }

	// RVA: 0x411B898 Offset: 0x4117898 VA: 0x411B898
	public static void LoadRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback) { }

	// RVA: 0x411B978 Offset: 0x4117978 VA: 0x411B978
	public static void ShowRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback) { }

	// RVA: 0x411BA58 Offset: 0x4117A58 VA: 0x411BA58
	public static void OpenFriendFinderDialog(FacebookDelegate<IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x411BB28 Offset: 0x4117B28 VA: 0x411BB28
	public static void GetFriendFinderInvitations(FacebookDelegate<IFriendFinderInvitationResult> callback) { }

	// RVA: 0x411BBF8 Offset: 0x4117BF8 VA: 0x411BBF8
	public static void DeleteFriendFinderInvitation(string invitationId, FacebookDelegate<IFriendFinderInvitationResult> callback) { }

	// RVA: 0x411BCD8 Offset: 0x4117CD8 VA: 0x411BCD8
	public static void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, FacebookDelegate<IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x411BDE8 Offset: 0x4117DE8 VA: 0x411BDE8
	public static void PostSessionScore(int score, FacebookDelegate<ISessionScoreResult> callback) { }

	// RVA: 0x411BEC8 Offset: 0x4117EC8 VA: 0x411BEC8
	public static void PostTournamentScore(int score, FacebookDelegate<ITournamentScoreResult> callback) { }

	// RVA: 0x411BFA8 Offset: 0x4117FA8 VA: 0x411BFA8
	public static void GetTournament(FacebookDelegate<ITournamentResult> callback) { }

	// RVA: 0x411C078 Offset: 0x4118078 VA: 0x411C078
	public static void ShareTournament(int score, Dictionary<string, string> data, FacebookDelegate<ITournamentScoreResult> callback) { }

	// RVA: 0x411C160 Offset: 0x4118160 VA: 0x411C160
	public static void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, Dictionary<string, string> data, FacebookDelegate<ITournamentResult> callback) { }

	// RVA: 0x411C288 Offset: 0x4118288 VA: 0x411C288
	public static void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback) { }

	// RVA: 0x411C380 Offset: 0x4118380 VA: 0x411C380
	public static void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback) { }

	// RVA: 0x411C478 Offset: 0x4118478 VA: 0x411C478
	public static void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, string travelId, FacebookDelegate<IMediaUploadResult> callback) { }

	// RVA: 0x411C574 Offset: 0x4118574 VA: 0x411C574
	public static void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, string travelId, FacebookDelegate<IMediaUploadResult> callback) { }

	// RVA: 0x411C674 Offset: 0x4118674 VA: 0x411C674
	public static void GetUserLocale(FacebookDelegate<ILocaleResult> callback) { }

	// RVA: 0x411C744 Offset: 0x4118744 VA: 0x411C744
	public void .ctor() { }

	// RVA: 0x411C74C Offset: 0x411874C VA: 0x411C74C
	private static void .cctor() { }
}

// Namespace: Facebook.Unity
public sealed class FBGamingServices : ScriptableObject // TypeDefIndex: 24636
{
	// Properties
	private static IMobileFacebook MobileFacebookImpl { get; }

	// Methods

	// RVA: 0x411DDA8 Offset: 0x4119DA8 VA: 0x411DDA8
	public static void OpenFriendFinderDialog(FacebookDelegate<IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x411DF0C Offset: 0x4119F0C VA: 0x411DF0C
	public static void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback) { }

	// RVA: 0x411DFD8 Offset: 0x4119FD8 VA: 0x411DFD8
	public static void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback) { }

	// RVA: 0x411E0A4 Offset: 0x411A0A4 VA: 0x411E0A4
	public static void PerformCustomUpdate(CustomUpdateContent content, FacebookDelegate<IGraphResult> callback) { }

	// RVA: 0x411E13C Offset: 0x411A13C VA: 0x411E13C
	public static void OnIAPReady(FacebookDelegate<IIAPReadyResult> callback) { }

	// RVA: 0x411E1E8 Offset: 0x411A1E8 VA: 0x411E1E8
	public static void GetCatalog(FacebookDelegate<ICatalogResult> callback) { }

	// RVA: 0x411E294 Offset: 0x411A294 VA: 0x411E294
	public static void GetPurchases(FacebookDelegate<IPurchasesResult> callback) { }

	// RVA: 0x411E340 Offset: 0x411A340 VA: 0x411E340
	public static void Purchase(string productID, FacebookDelegate<IPurchaseResult> callback, string developerPayload = "") { }

	// RVA: 0x411E404 Offset: 0x411A404 VA: 0x411E404
	public static void ConsumePurchase(string purchaseToken, FacebookDelegate<IConsumePurchaseResult> callback) { }

	// RVA: 0x411E4B8 Offset: 0x411A4B8 VA: 0x411E4B8
	public static void GetSubscribableCatalog(FacebookDelegate<ISubscribableCatalogResult> callback) { }

	// RVA: 0x411E564 Offset: 0x411A564 VA: 0x411E564
	public static void GetSubscriptions(FacebookDelegate<ISubscriptionsResult> callback) { }

	// RVA: 0x411E610 Offset: 0x411A610 VA: 0x411E610
	public static void PurchaseSubscription(string productID, FacebookDelegate<ISubscriptionResult> callback) { }

	// RVA: 0x411E6C4 Offset: 0x411A6C4 VA: 0x411E6C4
	public static void CancelSubscription(string purchaseToken, FacebookDelegate<ICancelSubscriptionResult> callback) { }

	// RVA: 0x411E778 Offset: 0x411A778 VA: 0x411E778
	public static void InitCloudGame(FacebookDelegate<IInitCloudGameResult> callback) { }

	// RVA: 0x411E824 Offset: 0x411A824 VA: 0x411E824
	public static void GameLoadComplete(FacebookDelegate<IGameLoadCompleteResult> callback) { }

	// RVA: 0x411E8D0 Offset: 0x411A8D0 VA: 0x411E8D0
	public static void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, FacebookDelegate<IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x411E9B4 Offset: 0x411A9B4 VA: 0x411E9B4
	public static void LoadInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback) { }

	// RVA: 0x411EA68 Offset: 0x411AA68 VA: 0x411EA68
	public static void ShowInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback) { }

	// RVA: 0x411EB1C Offset: 0x411AB1C VA: 0x411EB1C
	public static void LoadRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback) { }

	// RVA: 0x411EBD0 Offset: 0x411ABD0 VA: 0x411EBD0
	public static void ShowRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback) { }

	// RVA: 0x411EC84 Offset: 0x411AC84 VA: 0x411EC84
	public static void GetPayload(FacebookDelegate<IPayloadResult> callback) { }

	// RVA: 0x411ED30 Offset: 0x411AD30 VA: 0x411ED30
	public static void PostSessionScore(int score, FacebookDelegate<ISessionScoreResult> callback) { }

	// RVA: 0x411EDE4 Offset: 0x411ADE4 VA: 0x411EDE4
	public static void GetTournament(FacebookDelegate<ITournamentResult> callback) { }

	// RVA: 0x411EE90 Offset: 0x411AE90 VA: 0x411EE90
	public static void ShareTournament(int score, Dictionary<string, string> data, FacebookDelegate<ITournamentScoreResult> callback) { }

	// RVA: 0x411EF54 Offset: 0x411AF54 VA: 0x411EF54
	public static void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, Dictionary<string, string> data, FacebookDelegate<ITournamentResult> callback) { }

	// RVA: 0x411F058 Offset: 0x411B058 VA: 0x411F058
	public static void PostTournamentScore(int score, FacebookDelegate<ITournamentScoreResult> callback) { }

	// RVA: 0x411F10C Offset: 0x411B10C VA: 0x411F10C
	public static void OpenAppStore(FacebookDelegate<IOpenAppStoreResult> callback) { }

	// RVA: 0x411F1B8 Offset: 0x411B1B8 VA: 0x411F1B8
	public static void CreateGamingContext(string playerID, FacebookDelegate<ICreateGamingContextResult> callback) { }

	// RVA: 0x411F26C Offset: 0x411B26C VA: 0x411F26C
	public static void SwitchGamingContext(string gamingContextID, FacebookDelegate<ISwitchGamingContextResult> callback) { }

	// RVA: 0x411F320 Offset: 0x411B320 VA: 0x411F320
	public static void ChooseGamingContext(List<string> filters, int minSize, int maxSize, FacebookDelegate<IChooseGamingContextResult> callback) { }

	// RVA: 0x411F3EC Offset: 0x411B3EC VA: 0x411F3EC
	public static void GetCurrentGamingContext(FacebookDelegate<IGetCurrentGamingContextResult> callback) { }

	// RVA: 0x411DE54 Offset: 0x4119E54 VA: 0x411DE54
	private static IMobileFacebook get_MobileFacebookImpl() { }

	// RVA: 0x411F498 Offset: 0x411B498 VA: 0x411F498
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FacebookBase.<>c // TypeDefIndex: 24637
{
	// Fields
	public static readonly FacebookBase.<>c <>9; // 0x0
	public static Func<string, bool> <>9__41_0; // 0x8

	// Methods

	// RVA: 0x41204B8 Offset: 0x411C4B8 VA: 0x41204B8
	private static void .cctor() { }

	// RVA: 0x4120520 Offset: 0x411C520 VA: 0x4120520
	public void .ctor() { }

	// RVA: 0x4120528 Offset: 0x411C528 VA: 0x4120528
	internal bool <ValidateAppRequestArgs>b__41_0(string toWhom) { }
}

// Namespace: Facebook.Unity
internal abstract class FacebookBase : IFacebookImplementation, IFacebook, IFacebookWindows, IFacebookResultHandler // TypeDefIndex: 24638
{
	// Fields
	private InitDelegate onInitCompleteDelegate; // 0x10
	[CompilerGenerated]
	private bool <Initialized>k__BackingField; // 0x18
	[CompilerGenerated]
	private CallbackManager <CallbackManager>k__BackingField; // 0x20

	// Properties
	public abstract bool LimitEventUsage { get; set; }
	public abstract string SDKName { get; }
	public abstract string SDKVersion { get; }
	public virtual string SDKUserAgent { get; }
	public virtual bool LoggedIn { get; }
	public bool Initialized { get; set; }
	protected CallbackManager CallbackManager { get; set; }

	// Methods

	// RVA: 0x411F4A0 Offset: 0x411B4A0 VA: 0x411F4A0
	protected void .ctor(CallbackManager callbackManager) { }

	// RVA: -1 Offset: -1 Slot: 55
	public abstract bool get_LimitEventUsage();

	// RVA: -1 Offset: -1 Slot: 56
	public abstract void set_LimitEventUsage(bool value);

	// RVA: -1 Offset: -1 Slot: 57
	public abstract string get_SDKName();

	// RVA: -1 Offset: -1 Slot: 58
	public abstract string get_SDKVersion();

	// RVA: 0x411F4D0 Offset: 0x411B4D0 VA: 0x411F4D0 Slot: 59
	public virtual string get_SDKUserAgent() { }

	// RVA: 0x411F518 Offset: 0x411B518 VA: 0x411F518 Slot: 60
	public virtual bool get_LoggedIn() { }

	[CompilerGenerated]
	// RVA: 0x411F5B8 Offset: 0x411B5B8 VA: 0x411F5B8 Slot: 8
	public bool get_Initialized() { }

	[CompilerGenerated]
	// RVA: 0x411F5C0 Offset: 0x411B5C0 VA: 0x411F5C0 Slot: 61
	public void set_Initialized(bool value) { }

	[CompilerGenerated]
	// RVA: 0x411F5CC Offset: 0x411B5CC VA: 0x411F5CC
	protected CallbackManager get_CallbackManager() { }

	[CompilerGenerated]
	// RVA: 0x411F5D4 Offset: 0x411B5D4 VA: 0x411F5D4
	private void set_CallbackManager(CallbackManager value) { }

	// RVA: 0x411F5DC Offset: 0x411B5DC VA: 0x411F5DC Slot: 62
	public virtual void Init(InitDelegate onInitComplete) { }

	// RVA: -1 Offset: -1 Slot: 63
	public abstract void LogInWithPublishPermissions(IEnumerable<string> scope, FacebookDelegate<ILoginResult> callback);

	// RVA: -1 Offset: -1 Slot: 64
	public abstract void LogInWithReadPermissions(IEnumerable<string> scope, FacebookDelegate<ILoginResult> callback);

	// RVA: 0x411F5E4 Offset: 0x411B5E4 VA: 0x411F5E4 Slot: 65
	public virtual void LogOut() { }

	// RVA: -1 Offset: -1 Slot: 66
	public abstract void AppRequest(string message, Nullable<OGActionType> actionType, string objectId, IEnumerable<string> to, IEnumerable<object> filters, IEnumerable<string> excludeIds, Nullable<int> maxRecipients, string data, string title, FacebookDelegate<IAppRequestResult> callback);

	// RVA: -1 Offset: -1 Slot: 67
	public abstract void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, FacebookDelegate<IShareResult> callback);

	// RVA: -1 Offset: -1 Slot: 68
	public abstract void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, FacebookDelegate<IShareResult> callback);

	// RVA: 0x411F630 Offset: 0x411B630 VA: 0x411F630 Slot: 15
	public void API(string query, HttpMethod method, IDictionary<string, string> formData, FacebookDelegate<IGraphResult> callback) { }

	// RVA: 0x411FE74 Offset: 0x411BE74 VA: 0x411FE74 Slot: 16
	public void API(string query, HttpMethod method, WWWForm formData, FacebookDelegate<IGraphResult> callback) { }

	// RVA: -1 Offset: -1 Slot: 69
	public abstract void ActivateApp(string appId);

	// RVA: -1 Offset: -1 Slot: 70
	public abstract void GetAppLink(FacebookDelegate<IAppLinkResult> callback);

	// RVA: -1 Offset: -1 Slot: 71
	public abstract void AppEventsLogEvent(string logEvent, Nullable<float> valueToSum, Dictionary<string, object> parameters);

	// RVA: -1 Offset: -1 Slot: 72
	public abstract void AppEventsLogPurchase(float logPurchase, string currency, Dictionary<string, object> parameters);

	// RVA: 0x4120000 Offset: 0x411C000 VA: 0x4120000 Slot: 73
	public virtual void OnInitComplete(ResultContainer resultContainer) { }

	// RVA: -1 Offset: -1 Slot: 74
	public abstract void OnLoginComplete(ResultContainer resultContainer);

	// RVA: 0x4120164 Offset: 0x411C164 VA: 0x4120164 Slot: 51
	public void OnLogoutComplete(ResultContainer resultContainer) { }

	// RVA: -1 Offset: -1 Slot: 75
	public abstract void OnGetAppLinkComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 76
	public abstract void OnAppRequestsComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 77
	public abstract void OnShareLinkComplete(ResultContainer resultContainer);

	// RVA: 0x41201B0 Offset: 0x411C1B0 VA: 0x41201B0
	protected void ValidateAppRequestArgs(string message, Nullable<OGActionType> actionType, string objectId, IEnumerable<string> to, IEnumerable<object> filters, IEnumerable<string> excludeIds, Nullable<int> maxRecipients, string data = "", string title = "", FacebookDelegate<IAppRequestResult> callback) { }

	// RVA: 0x4120410 Offset: 0x411C410 VA: 0x4120410 Slot: 78
	protected virtual void OnAuthResponse(LoginResult result) { }

	// RVA: 0x411F918 Offset: 0x411B918 VA: 0x411F918
	private IDictionary<string, string> CopyByValue(IDictionary<string, string> data) { }

	// RVA: 0x411FDB4 Offset: 0x411BDB4 VA: 0x411FDB4
	private Uri GetGraphUrl(string query) { }

	// RVA: -1 Offset: -1 Slot: 79
	public abstract void GetCatalog(FacebookDelegate<ICatalogResult> callback);

	// RVA: -1 Offset: -1 Slot: 80
	public abstract void GetPurchases(FacebookDelegate<IPurchasesResult> callback);

	// RVA: -1 Offset: -1 Slot: 81
	public abstract void Purchase(string productID, FacebookDelegate<IPurchaseResult> callback, string developerPayload = "");

	// RVA: -1 Offset: -1 Slot: 82
	public abstract void ConsumePurchase(string productToken, FacebookDelegate<IConsumePurchaseResult> callback);

	// RVA: -1 Offset: -1 Slot: 83
	public abstract void GetSubscribableCatalog(FacebookDelegate<ISubscribableCatalogResult> callback);

	// RVA: -1 Offset: -1 Slot: 84
	public abstract void GetSubscriptions(FacebookDelegate<ISubscriptionsResult> callback);

	// RVA: -1 Offset: -1 Slot: 85
	public abstract void PurchaseSubscription(string productToken, FacebookDelegate<ISubscriptionResult> callback);

	// RVA: -1 Offset: -1 Slot: 86
	public abstract void CancelSubscription(string purchaseToken, FacebookDelegate<ICancelSubscriptionResult> callback);

	// RVA: -1 Offset: -1 Slot: 87
	public abstract Profile CurrentProfile();

	// RVA: -1 Offset: -1 Slot: 88
	public abstract void CurrentProfile(FacebookDelegate<IProfileResult> callback);

	// RVA: -1 Offset: -1 Slot: 89
	public abstract void LoadInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback);

	// RVA: -1 Offset: -1 Slot: 90
	public abstract void ShowInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback);

	// RVA: -1 Offset: -1 Slot: 91
	public abstract void LoadRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback);

	// RVA: -1 Offset: -1 Slot: 92
	public abstract void ShowRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback);

	// RVA: -1 Offset: -1 Slot: 93
	public abstract void OpenFriendFinderDialog(FacebookDelegate<IGamingServicesFriendFinderResult> callback);

	// RVA: -1 Offset: -1 Slot: 94
	public abstract void GetFriendFinderInvitations(FacebookDelegate<IFriendFinderInvitationResult> callback);

	// RVA: -1 Offset: -1 Slot: 95
	public abstract void DeleteFriendFinderInvitation(string invitationId, FacebookDelegate<IFriendFinderInvitationResult> callback);

	// RVA: -1 Offset: -1 Slot: 96
	public abstract void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, FacebookDelegate<IScheduleAppToUserNotificationResult> callback);

	// RVA: -1 Offset: -1 Slot: 97
	public abstract void PostSessionScore(int score, FacebookDelegate<ISessionScoreResult> callback);

	// RVA: -1 Offset: -1 Slot: 98
	public abstract void PostTournamentScore(int score, FacebookDelegate<ITournamentScoreResult> callback);

	// RVA: -1 Offset: -1 Slot: 99
	public abstract void GetTournament(FacebookDelegate<ITournamentResult> callback);

	// RVA: -1 Offset: -1 Slot: 100
	public abstract void ShareTournament(int score, Dictionary<string, string> data, FacebookDelegate<ITournamentScoreResult> callback);

	// RVA: -1 Offset: -1 Slot: 101
	public abstract void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, Dictionary<string, string> data, FacebookDelegate<ITournamentResult> callback);

	// RVA: -1 Offset: -1 Slot: 102
	public abstract void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback);

	// RVA: -1 Offset: -1 Slot: 103
	public abstract void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback);

	// RVA: 0x4120494 Offset: 0x411C494 VA: 0x4120494 Slot: 47
	public void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, string travelId, FacebookDelegate<IMediaUploadResult> callback) { }

	// RVA: 0x4120498 Offset: 0x411C498 VA: 0x4120498 Slot: 48
	public void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, string travelId, FacebookDelegate<IMediaUploadResult> callback) { }

	// RVA: -1 Offset: -1 Slot: 104
	public abstract void GetUserLocale(FacebookDelegate<ILocaleResult> callback);

	[CompilerGenerated]
	// RVA: 0x412049C Offset: 0x411C49C VA: 0x412049C
	private void <OnInitComplete>b__35_0(ILoginResult result) { }
}

// Namespace: Facebook.Unity
public sealed class InitDelegate : MulticastDelegate // TypeDefIndex: 24639
{
	// Methods

	// RVA: 0x4120534 Offset: 0x411C534 VA: 0x4120534
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x41205D0 Offset: 0x411C5D0 VA: 0x41205D0 Slot: 13
	public virtual void Invoke() { }
}

// Namespace: Facebook.Unity
public sealed class FacebookDelegate<T> : MulticastDelegate // TypeDefIndex: 24640
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6339FB0 Offset: 0x6335FB0 VA: 0x6339FB0
	|-FacebookDelegate<object>..ctor
	|
	|-RVA: 0x633A0CC Offset: 0x63360CC VA: 0x633A0CC
	|-FacebookDelegate<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633A0B8 Offset: 0x63360B8 VA: 0x633A0B8
	|-FacebookDelegate<object>.Invoke
	|
	|-RVA: 0x633A1D4 Offset: 0x63361D4 VA: 0x633A1D4
	|-FacebookDelegate<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: Facebook.Unity
public sealed class HideUnityDelegate : MulticastDelegate // TypeDefIndex: 24641
{
	// Methods

	// RVA: 0x41205E4 Offset: 0x411C5E4 VA: 0x41205E4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4120684 Offset: 0x411C684 VA: 0x4120684 Slot: 13
	public virtual void Invoke(bool isUnityShown) { }
}

// Namespace: Facebook.Unity
internal abstract class FacebookGameObject : MonoBehaviour, IFacebookCallbackHandler // TypeDefIndex: 24642
{
	// Fields
	[CompilerGenerated]
	private IFacebookImplementation <Facebook>k__BackingField; // 0x20

	// Properties
	public IFacebookImplementation Facebook { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x412069C Offset: 0x411C69C VA: 0x412069C
	public IFacebookImplementation get_Facebook() { }

	[CompilerGenerated]
	// RVA: 0x41206A4 Offset: 0x411C6A4 VA: 0x41206A4
	public void set_Facebook(IFacebookImplementation value) { }

	// RVA: 0x41206AC Offset: 0x411C6AC VA: 0x41206AC
	public void Awake() { }

	// RVA: 0x4120758 Offset: 0x411C758 VA: 0x4120758 Slot: 4
	public void OnInitComplete(string message) { }

	// RVA: 0x412098C Offset: 0x411C98C VA: 0x412098C Slot: 5
	public void OnLoginComplete(string message) { }

	// RVA: 0x4120A68 Offset: 0x411CA68 VA: 0x4120A68 Slot: 8
	public void OnLogoutComplete(string message) { }

	// RVA: 0x4120B44 Offset: 0x411CB44 VA: 0x4120B44 Slot: 9
	public void OnGetAppLinkComplete(string message) { }

	// RVA: 0x4120C20 Offset: 0x411CC20 VA: 0x4120C20 Slot: 6
	public void OnAppRequestsComplete(string message) { }

	// RVA: 0x4120CFC Offset: 0x411CCFC VA: 0x4120CFC Slot: 7
	public void OnShareLinkComplete(string message) { }

	// RVA: 0x4120DD8 Offset: 0x411CDD8 VA: 0x4120DD8 Slot: 10
	protected virtual void OnAwake() { }

	// RVA: 0x4120DDC Offset: 0x411CDDC VA: 0x4120DDC
	protected void .ctor() { }
}

// Namespace: Facebook.Unity
public class FacebookSdkVersion // TypeDefIndex: 24643
{
	// Properties
	public static string Build { get; }

	// Methods

	// RVA: 0x41182BC Offset: 0x41142BC VA: 0x41182BC
	public static string get_Build() { }
}

// Namespace: Facebook.Unity
internal enum FacebookUnityPlatform // TypeDefIndex: 24644
{
	// Fields
	public int value__; // 0x0
	public const FacebookUnityPlatform Unknown = 0;
	public const FacebookUnityPlatform Android = 1;
	public const FacebookUnityPlatform IOS = 2;
	public const FacebookUnityPlatform WebGL = 3;
	public const FacebookUnityPlatform Windows = 4;
}

// Namespace: Facebook.Unity
public class FriendFinderInviation // TypeDefIndex: 24645
{
	// Fields
	[CompilerGenerated]
	private string <Id>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <ApplicationName>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <FromName>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <ToName>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <Message>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <CreatedTime>k__BackingField; // 0x38

	// Properties
	public string Id { get; }
	public string ApplicationName { get; }
	public string FromName { get; }
	public string ToName { get; }
	public string Message { get; }
	public string CreatedTime { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4120DE4 Offset: 0x411CDE4 VA: 0x4120DE4
	public string get_Id() { }

	[CompilerGenerated]
	// RVA: 0x4120DEC Offset: 0x411CDEC VA: 0x4120DEC
	public string get_ApplicationName() { }

	[CompilerGenerated]
	// RVA: 0x4120DF4 Offset: 0x411CDF4 VA: 0x4120DF4
	public string get_FromName() { }

	[CompilerGenerated]
	// RVA: 0x4120DFC Offset: 0x411CDFC VA: 0x4120DFC
	public string get_ToName() { }

	[CompilerGenerated]
	// RVA: 0x4120E04 Offset: 0x411CE04 VA: 0x4120E04
	public string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x4120E0C Offset: 0x411CE0C VA: 0x4120E0C
	public string get_CreatedTime() { }
}

// Namespace: Facebook.Unity
internal interface IFacebook : IFacebookWindows // TypeDefIndex: 24646
{
	// Properties
	public abstract bool LoggedIn { get; }
	public abstract bool LimitEventUsage { get; set; }
	public abstract string SDKUserAgent { get; }
	public abstract bool Initialized { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_LoggedIn();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_LimitEventUsage();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_LimitEventUsage(bool value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_SDKUserAgent();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_Initialized();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void LogInWithPublishPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void LogInWithReadPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void LogOut();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void AppRequest(string message, Nullable<OGActionType> actionType, string objectId, IEnumerable<string> to, IEnumerable<object> filters, IEnumerable<string> excludeIds, Nullable<int> maxRecipients, string data, string title, FacebookDelegate<IAppRequestResult> callback);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, FacebookDelegate<IShareResult> callback);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, FacebookDelegate<IShareResult> callback);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void API(string query, HttpMethod method, IDictionary<string, string> formData, FacebookDelegate<IGraphResult> callback);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void API(string query, HttpMethod method, WWWForm formData, FacebookDelegate<IGraphResult> callback);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void ActivateApp(string appId);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void GetAppLink(FacebookDelegate<IAppLinkResult> callback);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void AppEventsLogEvent(string logEvent, Nullable<float> valueToSum, Dictionary<string, object> parameters);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void AppEventsLogPurchase(float logPurchase, string currency, Dictionary<string, object> parameters);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void GetCatalog(FacebookDelegate<ICatalogResult> callback);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void GetPurchases(FacebookDelegate<IPurchasesResult> callback);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void Purchase(string productID, FacebookDelegate<IPurchaseResult> callback, string developerPayload = "");

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void ConsumePurchase(string productToken, FacebookDelegate<IConsumePurchaseResult> callback);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void GetSubscribableCatalog(FacebookDelegate<ISubscribableCatalogResult> callback);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void GetSubscriptions(FacebookDelegate<ISubscriptionsResult> callback);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void PurchaseSubscription(string productToken, FacebookDelegate<ISubscriptionResult> callback);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void CancelSubscription(string purchaseToken, FacebookDelegate<ICancelSubscriptionResult> callback);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract Profile CurrentProfile();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract void CurrentProfile(FacebookDelegate<IProfileResult> callback);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void LoadInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void ShowInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void LoadRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void ShowRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract void OpenFriendFinderDialog(FacebookDelegate<IGamingServicesFriendFinderResult> callback);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract void GetFriendFinderInvitations(FacebookDelegate<IFriendFinderInvitationResult> callback);

	// RVA: -1 Offset: -1 Slot: 33
	public abstract void DeleteFriendFinderInvitation(string invitationId, FacebookDelegate<IFriendFinderInvitationResult> callback);

	// RVA: -1 Offset: -1 Slot: 34
	public abstract void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, FacebookDelegate<IScheduleAppToUserNotificationResult> callback);

	// RVA: -1 Offset: -1 Slot: 35
	public abstract void PostSessionScore(int score, FacebookDelegate<ISessionScoreResult> callback);

	// RVA: -1 Offset: -1 Slot: 36
	public abstract void PostTournamentScore(int score, FacebookDelegate<ITournamentScoreResult> callback);

	// RVA: -1 Offset: -1 Slot: 37
	public abstract void GetTournament(FacebookDelegate<ITournamentResult> callback);

	// RVA: -1 Offset: -1 Slot: 38
	public abstract void ShareTournament(int score, Dictionary<string, string> data, FacebookDelegate<ITournamentScoreResult> callback);

	// RVA: -1 Offset: -1 Slot: 39
	public abstract void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, Dictionary<string, string> data, FacebookDelegate<ITournamentResult> callback);

	// RVA: -1 Offset: -1 Slot: 40
	public abstract void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback);

	// RVA: -1 Offset: -1 Slot: 41
	public abstract void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback);

	// RVA: -1 Offset: -1 Slot: 42
	public abstract void GetUserLocale(FacebookDelegate<ILocaleResult> callback);
}

// Namespace: Facebook.Unity
internal interface IFacebookWindows // TypeDefIndex: 24647
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, string travelId, FacebookDelegate<IMediaUploadResult> callback);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, string travelId, FacebookDelegate<IMediaUploadResult> callback);
}

// Namespace: Facebook.Unity
internal interface IFacebookCallbackHandler // TypeDefIndex: 24648
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnInitComplete(string message);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnLoginComplete(string message);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnAppRequestsComplete(string message);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnShareLinkComplete(string message);
}

// Namespace: Facebook.Unity
internal interface IFacebookImplementation : IFacebook, IFacebookWindows, IFacebookResultHandler // TypeDefIndex: 24649
{}

// Namespace: Facebook.Unity
internal interface IFacebookResultHandler // TypeDefIndex: 24650
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnInitComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnLoginComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnLogoutComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnGetAppLinkComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnAppRequestsComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnShareLinkComplete(ResultContainer resultContainer);
}

// Namespace: Facebook.Unity
internal interface IPayFacebook // TypeDefIndex: 24651
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Pay(string product, string action, int quantity, Nullable<int> quantityMin, Nullable<int> quantityMax, string requestId, string pricepointId, string testCurrency, FacebookDelegate<IPayResult> callback);
}

// Namespace: Facebook.Unity
internal class MethodArguments // TypeDefIndex: 24652
{
	// Fields
	private IDictionary<string, object> arguments; // 0x10

	// Methods

	// RVA: 0x4120E14 Offset: 0x411CE14 VA: 0x4120E14
	public void .ctor() { }

	// RVA: 0x4120F2C Offset: 0x411CF2C VA: 0x4120F2C
	public void .ctor(MethodArguments methodArgs) { }

	// RVA: 0x4120E8C Offset: 0x411CE8C VA: 0x4120E8C
	private void .ctor(IDictionary<string, object> arguments) { }

	// RVA: -1 Offset: -1
	public void AddPrimative<T>(string argumentName, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x467BCCC Offset: 0x4677CCC VA: 0x467BCCC
	|-MethodArguments.AddPrimative<bool>
	|
	|-RVA: 0x467BDB0 Offset: 0x4677DB0 VA: 0x467BDB0
	|-MethodArguments.AddPrimative<int>
	|
	|-RVA: 0x467BE90 Offset: 0x4677E90 VA: 0x467BE90
	|-MethodArguments.AddPrimative<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void AddNullablePrimitive<T>(string argumentName, Nullable<T> nullable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x467B94C Offset: 0x467794C VA: 0x467B94C
	|-MethodArguments.AddNullablePrimitive<int>
	|
	|-RVA: 0x467BA4C Offset: 0x4677A4C VA: 0x467BA4C
	|-MethodArguments.AddNullablePrimitive<Int32Enum>
	|
	|-RVA: 0x467BB4C Offset: 0x4677B4C VA: 0x467BB4C
	|-MethodArguments.AddNullablePrimitive<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x4120F44 Offset: 0x411CF44 VA: 0x4120F44
	public void AddString(string argumentName, string value) { }

	// RVA: 0x4121020 Offset: 0x411D020 VA: 0x4121020
	public void AddCommaSeparatedList(string argumentName, IEnumerable<string> value) { }

	// RVA: 0x41210FC Offset: 0x411D0FC VA: 0x41210FC
	public void AddDictionary(string argumentName, IDictionary<string, object> dict) { }

	// RVA: -1 Offset: -1
	public void AddList<T>(string argumentName, IEnumerable<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x467B7AC Offset: 0x46777AC VA: 0x467B7AC
	|-MethodArguments.AddList<object>
	|
	|-RVA: 0x467B87C Offset: 0x467787C VA: 0x467B87C
	|-MethodArguments.AddList<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x4121558 Offset: 0x411D558 VA: 0x4121558
	public void AddUri(string argumentName, Uri uri) { }

	// RVA: 0x412168C Offset: 0x411D68C VA: 0x412168C
	public string ToJsonString() { }

	// RVA: 0x41211D8 Offset: 0x411D1D8 VA: 0x41211D8
	private static Dictionary<string, string> ToStringDict(IDictionary<string, object> dict) { }
}

// Namespace: Facebook.Unity
internal abstract class MethodCall<T> // TypeDefIndex: 24653
{
	// Fields
	[CompilerGenerated]
	private string <MethodName>k__BackingField; // 0x0
	[CompilerGenerated]
	private FacebookDelegate<T> <Callback>k__BackingField; // 0x0
	[CompilerGenerated]
	private FacebookBase <FacebookImpl>k__BackingField; // 0x0
	[CompilerGenerated]
	private MethodArguments <Parameters>k__BackingField; // 0x0

	// Properties
	public string MethodName { get; set; }
	protected FacebookDelegate<T> Callback { get; set; }
	protected FacebookBase FacebookImpl { set; }
	protected MethodArguments Parameters { set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(FacebookBase facebookImpl, string methodName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50F203C Offset: 0x50EE03C VA: 0x50F203C
	|-MethodCall<object>..ctor
	|
	|-RVA: 0x50F2108 Offset: 0x50EE108 VA: 0x50F2108
	|-MethodCall<__Il2CppFullySharedGenericType>..ctor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public string get_MethodName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50F20D8 Offset: 0x50EE0D8 VA: 0x50F20D8
	|-MethodCall<object>.get_MethodName
	|
	|-RVA: 0x50F21D4 Offset: 0x50EE1D4 VA: 0x50F21D4
	|-MethodCall<__Il2CppFullySharedGenericType>.get_MethodName
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_MethodName(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50F20E0 Offset: 0x50EE0E0 VA: 0x50F20E0
	|-MethodCall<object>.set_MethodName
	|
	|-RVA: 0x50F21DC Offset: 0x50EE1DC VA: 0x50F21DC
	|-MethodCall<__Il2CppFullySharedGenericType>.set_MethodName
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected FacebookDelegate<T> get_Callback() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50F20E8 Offset: 0x50EE0E8 VA: 0x50F20E8
	|-MethodCall<object>.get_Callback
	|
	|-RVA: 0x50F21E4 Offset: 0x50EE1E4 VA: 0x50F21E4
	|-MethodCall<__Il2CppFullySharedGenericType>.get_Callback
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_Callback(FacebookDelegate<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50F20F0 Offset: 0x50EE0F0 VA: 0x50F20F0
	|-MethodCall<object>.set_Callback
	|
	|-RVA: 0x50F21EC Offset: 0x50EE1EC VA: 0x50F21EC
	|-MethodCall<__Il2CppFullySharedGenericType>.set_Callback
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_FacebookImpl(FacebookBase value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50F20F8 Offset: 0x50EE0F8 VA: 0x50F20F8
	|-MethodCall<object>.set_FacebookImpl
	|
	|-RVA: 0x50F21F4 Offset: 0x50EE1F4 VA: 0x50F21F4
	|-MethodCall<__Il2CppFullySharedGenericType>.set_FacebookImpl
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_Parameters(MethodArguments value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50F2100 Offset: 0x50EE100 VA: 0x50F2100
	|-MethodCall<object>.set_Parameters
	|
	|-RVA: 0x50F21FC Offset: 0x50EE1FC VA: 0x50F21FC
	|-MethodCall<__Il2CppFullySharedGenericType>.set_Parameters
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Call(MethodArguments args);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MethodCall<__Il2CppFullySharedGenericType>.Call
	*/
}

// Namespace: Facebook.Unity
public enum ShareDialogMode // TypeDefIndex: 24654
{
	// Fields
	public int value__; // 0x0
	public const ShareDialogMode AUTOMATIC = 0;
	public const ShareDialogMode NATIVE = 1;
	public const ShareDialogMode WEB = 2;
	public const ShareDialogMode FEED = 3;
}

// Namespace: Facebook.Unity
public enum OGActionType // TypeDefIndex: 24655
{
	// Fields
	public int value__; // 0x0
	public const OGActionType SEND = 0;
	public const OGActionType ASKFOR = 1;
	public const OGActionType TURN = 2;
}

// Namespace: Facebook.Unity
public class CurrencyAmount // TypeDefIndex: 24656
{
	// Fields
	[CompilerGenerated]
	private string <Amount>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Currency>k__BackingField; // 0x18

	// Properties
	public string Amount { get; set; }
	public string Currency { get; set; }

	// Methods

	// RVA: 0x41216E4 Offset: 0x411D6E4 VA: 0x41216E4
	internal void .ctor(string amount, string currency) { }

	[CompilerGenerated]
	// RVA: 0x4121728 Offset: 0x411D728 VA: 0x4121728
	public string get_Amount() { }

	[CompilerGenerated]
	// RVA: 0x4121730 Offset: 0x411D730 VA: 0x4121730
	private void set_Amount(string value) { }

	[CompilerGenerated]
	// RVA: 0x4121738 Offset: 0x411D738 VA: 0x4121738
	public string get_Currency() { }

	[CompilerGenerated]
	// RVA: 0x4121740 Offset: 0x411D740 VA: 0x4121740
	private void set_Currency(string value) { }

	// RVA: 0x4121748 Offset: 0x411D748 VA: 0x4121748 Slot: 3
	public override string ToString() { }
}

// Namespace: Facebook.Unity
public class Product // TypeDefIndex: 24657
{
	// Fields
	[CompilerGenerated]
	private string <Title>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <ProductID>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Description>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <ImageURI>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <Price>k__BackingField; // 0x30
	[CompilerGenerated]
	private Nullable<double> <PriceAmount>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <PriceCurrencyCode>k__BackingField; // 0x48

	// Properties
	public string Title { get; set; }
	public string ProductID { get; set; }
	public string Description { get; set; }
	public string ImageURI { get; set; }
	public string Price { get; set; }
	public Nullable<double> PriceAmount { get; set; }
	public string PriceCurrencyCode { get; set; }

	// Methods

	// RVA: 0x4121858 Offset: 0x411D858 VA: 0x4121858
	internal void .ctor(string title, string productID, string description, string imageURI, string price, Nullable<double> priceAmount, string priceCurrencyCode) { }

	[CompilerGenerated]
	// RVA: 0x4121A0C Offset: 0x411DA0C VA: 0x4121A0C
	public string get_Title() { }

	[CompilerGenerated]
	// RVA: 0x4121A14 Offset: 0x411DA14 VA: 0x4121A14
	private void set_Title(string value) { }

	[CompilerGenerated]
	// RVA: 0x4121A1C Offset: 0x411DA1C VA: 0x4121A1C
	public string get_ProductID() { }

	[CompilerGenerated]
	// RVA: 0x4121A24 Offset: 0x411DA24 VA: 0x4121A24
	private void set_ProductID(string value) { }

	[CompilerGenerated]
	// RVA: 0x4121A2C Offset: 0x411DA2C VA: 0x4121A2C
	public string get_Description() { }

	[CompilerGenerated]
	// RVA: 0x4121A34 Offset: 0x411DA34 VA: 0x4121A34
	private void set_Description(string value) { }

	[CompilerGenerated]
	// RVA: 0x4121A3C Offset: 0x411DA3C VA: 0x4121A3C
	public string get_ImageURI() { }

	[CompilerGenerated]
	// RVA: 0x4121A44 Offset: 0x411DA44 VA: 0x4121A44
	private void set_ImageURI(string value) { }

	[CompilerGenerated]
	// RVA: 0x4121A4C Offset: 0x411DA4C VA: 0x4121A4C
	public string get_Price() { }

	[CompilerGenerated]
	// RVA: 0x4121A54 Offset: 0x411DA54 VA: 0x4121A54
	private void set_Price(string value) { }

	[CompilerGenerated]
	// RVA: 0x4121A5C Offset: 0x411DA5C VA: 0x4121A5C
	public Nullable<double> get_PriceAmount() { }

	[CompilerGenerated]
	// RVA: 0x4121A68 Offset: 0x411DA68 VA: 0x4121A68
	private void set_PriceAmount(Nullable<double> value) { }

	[CompilerGenerated]
	// RVA: 0x4121A70 Offset: 0x411DA70 VA: 0x4121A70
	public string get_PriceCurrencyCode() { }

	[CompilerGenerated]
	// RVA: 0x4121A78 Offset: 0x411DA78 VA: 0x4121A78
	private void set_PriceCurrencyCode(string value) { }

	// RVA: 0x4121A80 Offset: 0x411DA80 VA: 0x4121A80 Slot: 3
	public override string ToString() { }
}

// Namespace: Facebook.Unity
public class Purchase // TypeDefIndex: 24658
{
	// Fields
	[CompilerGenerated]
	private string <DeveloperPayload>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <IsConsumed>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <PaymentActionType>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <PaymentID>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <ProductID>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <PurchasePlatform>k__BackingField; // 0x38
	[CompilerGenerated]
	private CurrencyAmount <PurchasePrice>k__BackingField; // 0x40
	[CompilerGenerated]
	private DateTime <PurchaseTime>k__BackingField; // 0x48
	[CompilerGenerated]
	private string <PurchaseToken>k__BackingField; // 0x50
	[CompilerGenerated]
	private string <SignedRequest>k__BackingField; // 0x58

	// Properties
	public string DeveloperPayload { get; set; }
	public bool IsConsumed { get; }
	public string PaymentActionType { get; set; }
	public string PaymentID { get; set; }
	public string ProductID { get; set; }
	public string PurchasePlatform { get; set; }
	public CurrencyAmount PurchasePrice { get; set; }
	public DateTime PurchaseTime { get; set; }
	public string PurchaseToken { get; set; }
	public string SignedRequest { get; set; }

	// Methods

	// RVA: 0x4121CB8 Offset: 0x411DCB8 VA: 0x4121CB8
	internal void .ctor(string developerPayload, bool isConsumed, string paymentActionType, string paymentID, string productID, string purchasePlatform, IDictionary<string, object> purchasePrice, long purchaseTime, string purchaseToken, string signedRequest) { }

	[CompilerGenerated]
	// RVA: 0x4122188 Offset: 0x411E188 VA: 0x4122188
	public string get_DeveloperPayload() { }

	[CompilerGenerated]
	// RVA: 0x4122190 Offset: 0x411E190 VA: 0x4122190
	private void set_DeveloperPayload(string value) { }

	[CompilerGenerated]
	// RVA: 0x4122198 Offset: 0x411E198 VA: 0x4122198
	public bool get_IsConsumed() { }

	[CompilerGenerated]
	// RVA: 0x41221A0 Offset: 0x411E1A0 VA: 0x41221A0
	public string get_PaymentActionType() { }

	[CompilerGenerated]
	// RVA: 0x41221A8 Offset: 0x411E1A8 VA: 0x41221A8
	private void set_PaymentActionType(string value) { }

	[CompilerGenerated]
	// RVA: 0x41221B0 Offset: 0x411E1B0 VA: 0x41221B0
	public string get_PaymentID() { }

	[CompilerGenerated]
	// RVA: 0x41221B8 Offset: 0x411E1B8 VA: 0x41221B8
	private void set_PaymentID(string value) { }

	[CompilerGenerated]
	// RVA: 0x41221C0 Offset: 0x411E1C0 VA: 0x41221C0
	public string get_ProductID() { }

	[CompilerGenerated]
	// RVA: 0x41221C8 Offset: 0x411E1C8 VA: 0x41221C8
	private void set_ProductID(string value) { }

	[CompilerGenerated]
	// RVA: 0x41221D0 Offset: 0x411E1D0 VA: 0x41221D0
	public string get_PurchasePlatform() { }

	[CompilerGenerated]
	// RVA: 0x41221D8 Offset: 0x411E1D8 VA: 0x41221D8
	private void set_PurchasePlatform(string value) { }

	[CompilerGenerated]
	// RVA: 0x41221E0 Offset: 0x411E1E0 VA: 0x41221E0
	public CurrencyAmount get_PurchasePrice() { }

	[CompilerGenerated]
	// RVA: 0x41221E8 Offset: 0x411E1E8 VA: 0x41221E8
	private void set_PurchasePrice(CurrencyAmount value) { }

	[CompilerGenerated]
	// RVA: 0x41221F0 Offset: 0x411E1F0 VA: 0x41221F0
	public DateTime get_PurchaseTime() { }

	[CompilerGenerated]
	// RVA: 0x41221F8 Offset: 0x411E1F8 VA: 0x41221F8
	private void set_PurchaseTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x4122200 Offset: 0x411E200 VA: 0x4122200
	public string get_PurchaseToken() { }

	[CompilerGenerated]
	// RVA: 0x4122208 Offset: 0x411E208 VA: 0x4122208
	private void set_PurchaseToken(string value) { }

	[CompilerGenerated]
	// RVA: 0x4122210 Offset: 0x411E210 VA: 0x4122210
	public string get_SignedRequest() { }

	[CompilerGenerated]
	// RVA: 0x4122218 Offset: 0x411E218 VA: 0x4122218
	private void set_SignedRequest(string value) { }

	// RVA: 0x4122220 Offset: 0x411E220 VA: 0x4122220 Slot: 3
	public override string ToString() { }
}

// Namespace: Facebook.Unity
public class SubscribableProduct // TypeDefIndex: 24659
{
	// Fields
	[CompilerGenerated]
	private string <Title>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <ProductID>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Description>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <ImageURI>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <Price>k__BackingField; // 0x30
	[CompilerGenerated]
	private Nullable<double> <PriceAmount>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <PriceCurrencyCode>k__BackingField; // 0x48
	[CompilerGenerated]
	private string <SubscriptionTerm>k__BackingField; // 0x50

	// Properties
	public string Title { get; set; }
	public string ProductID { get; set; }
	public string Description { get; set; }
	public string ImageURI { get; set; }
	public string Price { get; set; }
	public Nullable<double> PriceAmount { get; set; }
	public string PriceCurrencyCode { get; set; }
	public string SubscriptionTerm { get; set; }

	// Methods

	// RVA: 0x41224F8 Offset: 0x411E4F8 VA: 0x41224F8
	internal void .ctor(string title, string productID, string description, string imageURI, string price, Nullable<double> priceAmount, string priceCurrencyCode, string subscriptionTerm) { }

	[CompilerGenerated]
	// RVA: 0x41226D4 Offset: 0x411E6D4 VA: 0x41226D4
	public string get_Title() { }

	[CompilerGenerated]
	// RVA: 0x41226DC Offset: 0x411E6DC VA: 0x41226DC
	private void set_Title(string value) { }

	[CompilerGenerated]
	// RVA: 0x41226E4 Offset: 0x411E6E4 VA: 0x41226E4
	public string get_ProductID() { }

	[CompilerGenerated]
	// RVA: 0x41226EC Offset: 0x411E6EC VA: 0x41226EC
	private void set_ProductID(string value) { }

	[CompilerGenerated]
	// RVA: 0x41226F4 Offset: 0x411E6F4 VA: 0x41226F4
	public string get_Description() { }

	[CompilerGenerated]
	// RVA: 0x41226FC Offset: 0x411E6FC VA: 0x41226FC
	private void set_Description(string value) { }

	[CompilerGenerated]
	// RVA: 0x4122704 Offset: 0x411E704 VA: 0x4122704
	public string get_ImageURI() { }

	[CompilerGenerated]
	// RVA: 0x412270C Offset: 0x411E70C VA: 0x412270C
	private void set_ImageURI(string value) { }

	[CompilerGenerated]
	// RVA: 0x4122714 Offset: 0x411E714 VA: 0x4122714
	public string get_Price() { }

	[CompilerGenerated]
	// RVA: 0x412271C Offset: 0x411E71C VA: 0x412271C
	private void set_Price(string value) { }

	[CompilerGenerated]
	// RVA: 0x4122724 Offset: 0x411E724 VA: 0x4122724
	public Nullable<double> get_PriceAmount() { }

	[CompilerGenerated]
	// RVA: 0x4122730 Offset: 0x411E730 VA: 0x4122730
	private void set_PriceAmount(Nullable<double> value) { }

	[CompilerGenerated]
	// RVA: 0x4122738 Offset: 0x411E738 VA: 0x4122738
	public string get_PriceCurrencyCode() { }

	[CompilerGenerated]
	// RVA: 0x4122740 Offset: 0x411E740 VA: 0x4122740
	private void set_PriceCurrencyCode(string value) { }

	[CompilerGenerated]
	// RVA: 0x4122748 Offset: 0x411E748 VA: 0x4122748
	public string get_SubscriptionTerm() { }

	[CompilerGenerated]
	// RVA: 0x4122750 Offset: 0x411E750 VA: 0x4122750
	private void set_SubscriptionTerm(string value) { }

	// RVA: 0x4122758 Offset: 0x411E758 VA: 0x4122758 Slot: 3
	public override string ToString() { }
}

// Namespace: Facebook.Unity
public class Subscription // TypeDefIndex: 24660
{
	// Fields
	[CompilerGenerated]
	private DateTime <DeactivationTime>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <IsEntitlementActive>k__BackingField; // 0x18
	[CompilerGenerated]
	private DateTime <PeriodStartTime>k__BackingField; // 0x20
	[CompilerGenerated]
	private DateTime <PeriodEndTime>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <ProductID>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <PurchasePlatform>k__BackingField; // 0x38
	[CompilerGenerated]
	private CurrencyAmount <PurchasePrice>k__BackingField; // 0x40
	[CompilerGenerated]
	private DateTime <PurchaseTime>k__BackingField; // 0x48
	[CompilerGenerated]
	private string <PurchaseToken>k__BackingField; // 0x50
	[CompilerGenerated]
	private string <SignedRequest>k__BackingField; // 0x58
	[CompilerGenerated]
	private string <Status>k__BackingField; // 0x60
	[CompilerGenerated]
	private string <SubscriptionTerm>k__BackingField; // 0x68

	// Properties
	public DateTime DeactivationTime { get; set; }
	public bool IsEntitlementActive { get; set; }
	public DateTime PeriodStartTime { get; set; }
	public DateTime PeriodEndTime { get; set; }
	public string ProductID { get; set; }
	public string PurchasePlatform { get; set; }
	public CurrencyAmount PurchasePrice { get; set; }
	public DateTime PurchaseTime { get; set; }
	public string PurchaseToken { get; set; }
	public string SignedRequest { get; set; }
	public string Status { get; set; }
	public string SubscriptionTerm { get; set; }

	// Methods

	// RVA: 0x41229B8 Offset: 0x411E9B8 VA: 0x41229B8
	internal void .ctor(long deactivationTime, bool isEntitlementActive, long periodStartTime, long periodEndTime, string productID, string purchasePlatform, IDictionary<string, object> purchasePrice, long purchaseTime, string purchaseToken, string signedRequest, string status, string subscriptionTerm) { }

	[CompilerGenerated]
	// RVA: 0x4123034 Offset: 0x411F034 VA: 0x4123034
	public DateTime get_DeactivationTime() { }

	[CompilerGenerated]
	// RVA: 0x412303C Offset: 0x411F03C VA: 0x412303C
	private void set_DeactivationTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x4123044 Offset: 0x411F044 VA: 0x4123044
	public bool get_IsEntitlementActive() { }

	[CompilerGenerated]
	// RVA: 0x412304C Offset: 0x411F04C VA: 0x412304C
	private void set_IsEntitlementActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4123058 Offset: 0x411F058 VA: 0x4123058
	public DateTime get_PeriodStartTime() { }

	[CompilerGenerated]
	// RVA: 0x4123060 Offset: 0x411F060 VA: 0x4123060
	private void set_PeriodStartTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x4123068 Offset: 0x411F068 VA: 0x4123068
	public DateTime get_PeriodEndTime() { }

	[CompilerGenerated]
	// RVA: 0x4123070 Offset: 0x411F070 VA: 0x4123070
	private void set_PeriodEndTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x4123078 Offset: 0x411F078 VA: 0x4123078
	public string get_ProductID() { }

	[CompilerGenerated]
	// RVA: 0x4123080 Offset: 0x411F080 VA: 0x4123080
	private void set_ProductID(string value) { }

	[CompilerGenerated]
	// RVA: 0x4123088 Offset: 0x411F088 VA: 0x4123088
	public string get_PurchasePlatform() { }

	[CompilerGenerated]
	// RVA: 0x4123090 Offset: 0x411F090 VA: 0x4123090
	private void set_PurchasePlatform(string value) { }

	[CompilerGenerated]
	// RVA: 0x4123098 Offset: 0x411F098 VA: 0x4123098
	public CurrencyAmount get_PurchasePrice() { }

	[CompilerGenerated]
	// RVA: 0x41230A0 Offset: 0x411F0A0 VA: 0x41230A0
	private void set_PurchasePrice(CurrencyAmount value) { }

	[CompilerGenerated]
	// RVA: 0x41230A8 Offset: 0x411F0A8 VA: 0x41230A8
	public DateTime get_PurchaseTime() { }

	[CompilerGenerated]
	// RVA: 0x41230B0 Offset: 0x411F0B0 VA: 0x41230B0
	private void set_PurchaseTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x41230B8 Offset: 0x411F0B8 VA: 0x41230B8
	public string get_PurchaseToken() { }

	[CompilerGenerated]
	// RVA: 0x41230C0 Offset: 0x411F0C0 VA: 0x41230C0
	private void set_PurchaseToken(string value) { }

	[CompilerGenerated]
	// RVA: 0x41230C8 Offset: 0x411F0C8 VA: 0x41230C8
	public string get_SignedRequest() { }

	[CompilerGenerated]
	// RVA: 0x41230D0 Offset: 0x411F0D0 VA: 0x41230D0
	private void set_SignedRequest(string value) { }

	[CompilerGenerated]
	// RVA: 0x41230D8 Offset: 0x411F0D8 VA: 0x41230D8
	public string get_Status() { }

	[CompilerGenerated]
	// RVA: 0x41230E0 Offset: 0x411F0E0 VA: 0x41230E0
	private void set_Status(string value) { }

	[CompilerGenerated]
	// RVA: 0x41230E8 Offset: 0x411F0E8 VA: 0x41230E8
	public string get_SubscriptionTerm() { }

	[CompilerGenerated]
	// RVA: 0x41230F0 Offset: 0x411F0F0 VA: 0x41230F0
	private void set_SubscriptionTerm(string value) { }

	// RVA: 0x41230F8 Offset: 0x411F0F8 VA: 0x41230F8 Slot: 3
	public override string ToString() { }
}

// Namespace: Facebook.Unity
internal class AccessTokenRefreshResult : ResultBase, IAccessTokenRefreshResult, IResult // TypeDefIndex: 24661
{
	// Fields
	[CompilerGenerated]
	private AccessToken <AccessToken>k__BackingField; // 0x50

	// Properties
	public AccessToken AccessToken { get; set; }

	// Methods

	// RVA: 0x4123460 Offset: 0x411F460 VA: 0x4123460
	public void .ctor(ResultContainer resultContainer) { }

	[CompilerGenerated]
	// RVA: 0x4123778 Offset: 0x411F778 VA: 0x4123778 Slot: 21
	public AccessToken get_AccessToken() { }

	[CompilerGenerated]
	// RVA: 0x4123780 Offset: 0x411F780 VA: 0x4123780
	private void set_AccessToken(AccessToken value) { }

	// RVA: 0x4123788 Offset: 0x411F788 VA: 0x4123788 Slot: 3
	public override string ToString() { }
}

// Namespace: Facebook.Unity
internal class AppLinkResult : ResultBase, IAppLinkResult, IResult // TypeDefIndex: 24662
{
	// Fields
	[CompilerGenerated]
	private string <Url>k__BackingField; // 0x50
	[CompilerGenerated]
	private string <TargetUrl>k__BackingField; // 0x58
	[CompilerGenerated]
	private string <Ref>k__BackingField; // 0x60
	[CompilerGenerated]
	private IDictionary<string, object> <Extras>k__BackingField; // 0x68

	// Properties
	public string Url { get; set; }
	public string TargetUrl { get; set; }
	public string Ref { get; set; }
	public IDictionary<string, object> Extras { get; set; }

	// Methods

	// RVA: 0x4123A54 Offset: 0x411FA54 VA: 0x4123A54
	public void .ctor(ResultContainer resultContainer) { }

	[CompilerGenerated]
	// RVA: 0x4123C18 Offset: 0x411FC18 VA: 0x4123C18 Slot: 21
	public string get_Url() { }

	[CompilerGenerated]
	// RVA: 0x4123C20 Offset: 0x411FC20 VA: 0x4123C20
	private void set_Url(string value) { }

	[CompilerGenerated]
	// RVA: 0x4123C28 Offset: 0x411FC28 VA: 0x4123C28 Slot: 22
	public string get_TargetUrl() { }

	[CompilerGenerated]
	// RVA: 0x4123C30 Offset: 0x411FC30 VA: 0x4123C30
	private void set_TargetUrl(string value) { }

	[CompilerGenerated]
	// RVA: 0x4123C38 Offset: 0x411FC38 VA: 0x4123C38 Slot: 23
	public string get_Ref() { }

	[CompilerGenerated]
	// RVA: 0x4123C40 Offset: 0x411FC40 VA: 0x4123C40
	private void set_Ref(string value) { }

	[CompilerGenerated]
	// RVA: 0x4123C48 Offset: 0x411FC48 VA: 0x4123C48 Slot: 24
	public IDictionary<string, object> get_Extras() { }

	[CompilerGenerated]
	// RVA: 0x4123C50 Offset: 0x411FC50 VA: 0x4123C50
	private void set_Extras(IDictionary<string, object> value) { }

	// RVA: 0x4123C58 Offset: 0x411FC58 VA: 0x4123C58 Slot: 3
	public override string ToString() { }
}

// Namespace: Facebook.Unity
internal class AppRequestResult : ResultBase, IAppRequestResult, IResult // TypeDefIndex: 24663
{
	// Fields
	[CompilerGenerated]
	private string <RequestID>k__BackingField; // 0x50
	[CompilerGenerated]
	private IEnumerable<string> <To>k__BackingField; // 0x58

	// Properties
	public string RequestID { get; set; }
	public IEnumerable<string> To { get; set; }

	// Methods

	// RVA: 0x4123E30 Offset: 0x411FE30 VA: 0x4123E30
	public void .ctor(ResultContainer resultContainer) { }

	[CompilerGenerated]
	// RVA: 0x412437C Offset: 0x412037C VA: 0x412437C Slot: 21
	public string get_RequestID() { }

	[CompilerGenerated]
	// RVA: 0x4124384 Offset: 0x4120384 VA: 0x4124384
	private void set_RequestID(string value) { }

	[CompilerGenerated]
	// RVA: 0x412438C Offset: 0x412038C VA: 0x412438C Slot: 22
	public IEnumerable<string> get_To() { }

	[CompilerGenerated]
	// RVA: 0x4124394 Offset: 0x4120394 VA: 0x4124394
	private void set_To(IEnumerable<string> value) { }

	// RVA: 0x412439C Offset: 0x412039C VA: 0x412439C Slot: 3
	public override string ToString() { }
}

// Namespace: Facebook.Unity
internal class CatalogResult : ResultBase, ICatalogResult, IResult // TypeDefIndex: 24664
{
	// Fields
	[CompilerGenerated]
	private IList<Product> <Products>k__BackingField; // 0x50

	// Properties
	public IList<Product> Products { get; set; }

	// Methods

	// RVA: 0x41244D8 Offset: 0x41204D8 VA: 0x41244D8
	public void .ctor(ResultContainer resultContainer) { }

	[CompilerGenerated]
	// RVA: 0x4124CC4 Offset: 0x4120CC4 VA: 0x4124CC4 Slot: 21
	public IList<Product> get_Products() { }

	[CompilerGenerated]
	// RVA: 0x4124CCC Offset: 0x4120CCC VA: 0x4124CCC
	private void set_Products(IList<Product> value) { }

	// RVA: 0x4124CD4 Offset: 0x4120CD4 VA: 0x4124CD4 Slot: 3
	public override string ToString() { }
}

// Namespace: Facebook.Unity
public interface IFriendFinderInvitationResult : IResult // TypeDefIndex: 24665
{
	// Properties
	public abstract IList<FriendFinderInviation> Invitations { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IList<FriendFinderInviation> get_Invitations();
}

// Namespace: Facebook.Unity
public interface ILocaleResult : IResult // TypeDefIndex: 24666
{
	// Properties
	public abstract string Locale { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Locale();
}

// Namespace: Facebook.Unity
public interface IProfileResult : IResult // TypeDefIndex: 24667
{
	// Properties
	public abstract Profile CurrentProfile { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Profile get_CurrentProfile();
}

// Namespace: Facebook.Unity
internal class CancelSubscriptionResult : ResultBase, ICancelSubscriptionResult, IResult // TypeDefIndex: 24668
{
	// Methods

	// RVA: 0x41250C0 Offset: 0x41210C0 VA: 0x41250C0
	internal void .ctor(ResultContainer resultContainer) { }
}

// Namespace: Facebook.Unity
internal class ConsumePurchaseResult : ResultBase, IConsumePurchaseResult, IResult // TypeDefIndex: 24669
{
	// Methods

	// RVA: 0x41250C4 Offset: 0x41210C4 VA: 0x41250C4
	internal void .ctor(ResultContainer resultContainer) { }
}

// Namespace: Facebook.Unity
internal class GamingServicesFriendFinderResult : ResultBase, IGamingServicesFriendFinderResult, IResult // TypeDefIndex: 24670
{
	// Methods

	// RVA: 0x41250C8 Offset: 0x41210C8 VA: 0x41250C8
	internal void .ctor(ResultContainer resultContainer) { }
}

// Namespace: Facebook.Unity
internal class GraphResult : ResultBase, IGraphResult, IResult // TypeDefIndex: 24671
{
	// Fields
	[CompilerGenerated]
	private IList<object> <ResultList>k__BackingField; // 0x50
	[CompilerGenerated]
	private Texture2D <Texture>k__BackingField; // 0x58

	// Properties
	private IList<object> ResultList { set; }
	public Texture2D Texture { get; set; }

	// Methods

	// RVA: 0x41250CC Offset: 0x41210CC VA: 0x41250CC
	internal void .ctor(UnityWebRequestAsyncOperation result) { }

	[CompilerGenerated]
	// RVA: 0x41253A0 Offset: 0x41213A0 VA: 0x41253A0
	private void set_ResultList(IList<object> value) { }

	[CompilerGenerated]
	// RVA: 0x41253A8 Offset: 0x41213A8 VA: 0x41253A8 Slot: 21
	public Texture2D get_Texture() { }

	[CompilerGenerated]
	// RVA: 0x41253B0 Offset: 0x41213B0 VA: 0x41253B0
	private void set_Texture(Texture2D value) { }

	// RVA: 0x4125290 Offset: 0x4121290 VA: 0x4125290
	private void Init(string rawResult) { }
}

// Namespace: Facebook.Unity
public interface IAccessTokenRefreshResult : IResult // TypeDefIndex: 24672
{}

// Namespace: Facebook.Unity
public interface IAppLinkResult : IResult // TypeDefIndex: 24673
{}

// Namespace: Facebook.Unity
internal class IAPReadyResult : ResultBase, IIAPReadyResult, IResult // TypeDefIndex: 24674
{
	// Methods

	// RVA: 0x41253B8 Offset: 0x41213B8 VA: 0x41253B8
	internal void .ctor(ResultContainer resultContainer) { }
}

// Namespace: Facebook.Unity
public interface IAppRequestResult : IResult // TypeDefIndex: 24675
{}

// Namespace: Facebook.Unity
public interface ICancelSubscriptionResult : IResult // TypeDefIndex: 24676
{}

// Namespace: Facebook.Unity
public interface ICatalogResult : IResult // TypeDefIndex: 24677
{
	// Properties
	public abstract IList<Product> Products { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IList<Product> get_Products();
}

// Namespace: Facebook.Unity
public interface IConsumePurchaseResult : IResult // TypeDefIndex: 24678
{}

// Namespace: Facebook.Unity
public interface IGamingServicesFriendFinderResult : IResult // TypeDefIndex: 24679
{}

// Namespace: Facebook.Unity
public interface IGraphResult : IResult // TypeDefIndex: 24680
{
	// Properties
	public abstract Texture2D Texture { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Texture2D get_Texture();
}

// Namespace: Facebook.Unity
public interface IGroupCreateResult : IResult // TypeDefIndex: 24681
{}

// Namespace: Facebook.Unity
public interface IGroupJoinResult : IResult // TypeDefIndex: 24682
{}

// Namespace: Facebook.Unity
internal class InitCloudGameResult : ResultBase, IInitCloudGameResult, IResult // TypeDefIndex: 24683
{
	// Methods

	// RVA: 0x41253BC Offset: 0x41213BC VA: 0x41253BC
	internal void .ctor(ResultContainer resultContainer) { }
}

// Namespace: Facebook.Unity
internal class GameLoadCompleteResult : ResultBase, IGameLoadCompleteResult, IResult // TypeDefIndex: 24684
{
	// Methods

	// RVA: 0x41253C0 Offset: 0x41213C0 VA: 0x41253C0
	internal void .ctor(ResultContainer resultContainer) { }
}

// Namespace: Facebook.Unity
internal class InterstitialAdResult : ResultBase, IInterstitialAdResult, IResult // TypeDefIndex: 24685
{
	// Methods

	// RVA: 0x41253C4 Offset: 0x41213C4 VA: 0x41253C4
	internal void .ctor(ResultContainer resultContainer) { }
}

// Namespace: Facebook.Unity
public interface IIAPReadyResult : IResult // TypeDefIndex: 24686
{}

// Namespace: Facebook.Unity
public interface IInitCloudGameResult : IResult // TypeDefIndex: 24687
{}

// Namespace: Facebook.Unity
public interface IGameLoadCompleteResult : IResult // TypeDefIndex: 24688
{}

// Namespace: Facebook.Unity
internal interface IInternalResult : IResult // TypeDefIndex: 24689
{
	// Properties
	public abstract string CallbackId { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_CallbackId();
}

// Namespace: Facebook.Unity
public interface IInterstitialAdResult : IResult // TypeDefIndex: 24690
{}

// Namespace: Facebook.Unity
public interface ILoginResult : IResult // TypeDefIndex: 24691
{}

// Namespace: Facebook.Unity
public interface ILoginStatusResult : ILoginResult, IResult // TypeDefIndex: 24692
{}

// Namespace: Facebook.Unity
public interface IOpenAppStoreResult : IResult // TypeDefIndex: 24693
{}

// Namespace: Facebook.Unity
public interface IPayloadResult : IResult // TypeDefIndex: 24694
{
	// Properties
	public abstract IDictionary<string, string> Payload { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDictionary<string, string> get_Payload();
}

// Namespace: Facebook.Unity
public interface IPayResult : IResult // TypeDefIndex: 24695
{}

// Namespace: Facebook.Unity
public interface IPurchaseResult : IResult // TypeDefIndex: 24696
{
	// Properties
	public abstract Purchase Purchase { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Purchase get_Purchase();
}

// Namespace: Facebook.Unity
public interface IPurchasesResult : IResult // TypeDefIndex: 24697
{
	// Properties
	public abstract IList<Purchase> Purchases { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IList<Purchase> get_Purchases();
}

// Namespace: Facebook.Unity
public interface IResult // TypeDefIndex: 24698
{
	// Properties
	public abstract string Error { get; }
	public abstract IDictionary<string, object> ResultDictionary { get; }
	public abstract string RawResult { get; }
	public abstract bool Cancelled { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Error();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDictionary<string, object> get_ResultDictionary();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_RawResult();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_Cancelled();
}

// Namespace: Facebook.Unity
public interface IReferralsCreateResult : IResult // TypeDefIndex: 24699
{
	// Properties
	public abstract string Raw { get; }
	public abstract string ReferralLink { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Raw();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_ReferralLink();
}

// Namespace: Facebook.Unity
public interface IReferralsGetDataResult : IResult // TypeDefIndex: 24700
{
	// Properties
	public abstract string Raw { get; }
	public abstract string Payload { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Raw();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_Payload();
}

// Namespace: Facebook.Unity
public interface IRewardedVideoResult : IResult // TypeDefIndex: 24701
{}

// Namespace: Facebook.Unity
public interface IScheduleAppToUserNotificationResult : IResult // TypeDefIndex: 24702
{}

// Namespace: Facebook.Unity
public interface IShareResult : IResult // TypeDefIndex: 24703
{}

// Namespace: Facebook.Unity
public interface ISoftKeyboardOpenResult : IResult // TypeDefIndex: 24704
{
	// Properties
	public abstract string Success { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Success();
}

// Namespace: Facebook.Unity
public interface ISubscribableCatalogResult : IResult // TypeDefIndex: 24705
{}

// Namespace: Facebook.Unity
public interface ISubscriptionResult : IResult // TypeDefIndex: 24706
{}

// Namespace: Facebook.Unity
public interface ISubscriptionsResult : IResult // TypeDefIndex: 24707
{}

// Namespace: Facebook.Unity
public interface IVirtualGamepadLayoutResult : IResult // TypeDefIndex: 24708
{
	// Properties
	public abstract string Success { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Success();
}

// Namespace: Facebook.Unity
internal class LoginResult : ResultBase, ILoginResult, IResult // TypeDefIndex: 24709
{
	// Fields
	public static readonly string UserIdKey; // 0x0
	public static readonly string ExpirationTimestampKey; // 0x8
	public static readonly string PermissionsKey; // 0x10
	public static readonly string AccessTokenKey; // 0x18
	public static readonly string GraphDomain; // 0x20
	public static readonly string AuthTokenString; // 0x28
	public static readonly string AuthNonce; // 0x30
	[CompilerGenerated]
	private AccessToken <AccessToken>k__BackingField; // 0x50
	[CompilerGenerated]
	private AuthenticationToken <AuthenticationToken>k__BackingField; // 0x58

	// Properties
	public AccessToken AccessToken { get; set; }
	public AuthenticationToken AuthenticationToken { get; set; }

	// Methods

	// RVA: 0x4125508 Offset: 0x4121508 VA: 0x4125508
	internal void .ctor(ResultContainer resultContainer) { }

	[CompilerGenerated]
	// RVA: 0x4125A50 Offset: 0x4121A50 VA: 0x4125A50 Slot: 21
	public AccessToken get_AccessToken() { }

	[CompilerGenerated]
	// RVA: 0x4125A58 Offset: 0x4121A58 VA: 0x4125A58
	private void set_AccessToken(AccessToken value) { }

	[CompilerGenerated]
	// RVA: 0x4125A60 Offset: 0x4121A60 VA: 0x4125A60 Slot: 22
	public AuthenticationToken get_AuthenticationToken() { }

	[CompilerGenerated]
	// RVA: 0x4125A68 Offset: 0x4121A68 VA: 0x4125A68
	private void set_AuthenticationToken(AuthenticationToken value) { }

	// RVA: 0x4125A70 Offset: 0x4121A70 VA: 0x4125A70 Slot: 3
	public override string ToString() { }

	// RVA: 0x4125BA4 Offset: 0x4121BA4 VA: 0x4125BA4
	private static void .cctor() { }
}

// Namespace: Facebook.Unity
internal class LoginStatusResult : LoginResult, ILoginStatusResult, ILoginResult, IResult // TypeDefIndex: 24710
{
	// Fields
	public static readonly string FailedKey; // 0x0
	[CompilerGenerated]
	private bool <Failed>k__BackingField; // 0x60

	// Properties
	public bool Failed { get; set; }

	// Methods

	// RVA: 0x4125D9C Offset: 0x4121D9C VA: 0x4125D9C
	internal void .ctor(ResultContainer resultContainer) { }

	[CompilerGenerated]
	// RVA: 0x4125F4C Offset: 0x4121F4C VA: 0x4125F4C Slot: 23
	public bool get_Failed() { }

	[CompilerGenerated]
	// RVA: 0x4125F54 Offset: 0x4121F54 VA: 0x4125F54
	private void set_Failed(bool value) { }

	// RVA: 0x4125F60 Offset: 0x4121F60 VA: 0x4125F60 Slot: 3
	public override string ToString() { }

	// RVA: 0x4126098 Offset: 0x4122098 VA: 0x4126098
	private static void .cctor() { }
}

// Namespace: Facebook.Unity
internal class OpenAppStoreResult : ResultBase, IOpenAppStoreResult, IResult // TypeDefIndex: 24711
{
	// Methods

	// RVA: 0x4126104 Offset: 0x4122104 VA: 0x4126104
	internal void .ctor(ResultContainer resultContainer) { }
}

// Namespace: Facebook.Unity
internal class PayloadResult : ResultBase, IPayloadResult, IResult // TypeDefIndex: 24712
{
	// Fields
	[CompilerGenerated]
	private IDictionary<string, string> <Payload>k__BackingField; // 0x50

	// Properties
	public IDictionary<string, string> Payload { get; set; }

	// Methods

	// RVA: 0x4126108 Offset: 0x4122108 VA: 0x4126108
	public void .ctor(ResultContainer resultContainer) { }

	[CompilerGenerated]
	// RVA: 0x412634C Offset: 0x412234C VA: 0x412634C Slot: 21
	public IDictionary<string, string> get_Payload() { }

	[CompilerGenerated]
	// RVA: 0x4126354 Offset: 0x4122354 VA: 0x4126354
	private void set_Payload(IDictionary<string, string> value) { }

	// RVA: 0x412635C Offset: 0x412235C VA: 0x412635C Slot: 3
	public override string ToString() { }
}

// Namespace: Facebook.Unity
internal class PayResult : ResultBase, IPayResult, IResult // TypeDefIndex: 24713
{
	// Properties
	public long ErrorCode { get; }

	// Methods

	// RVA: 0x4126398 Offset: 0x4122398 VA: 0x4126398
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x4126444 Offset: 0x4122444 VA: 0x4126444 Slot: 21
	public long get_ErrorCode() { }

	// RVA: 0x4126480 Offset: 0x4122480 VA: 0x4126480 Slot: 3
	public override string ToString() { }
}

// Namespace: Facebook.Unity
internal class PurchaseResult : ResultBase, IPurchaseResult, IResult // TypeDefIndex: 24714
{
	// Fields
	[CompilerGenerated]
	private Purchase <Purchase>k__BackingField; // 0x50

	// Properties
	public Purchase Purchase { get; set; }

	// Methods

	// RVA: 0x41265B8 Offset: 0x41225B8 VA: 0x41265B8
	public void .ctor(ResultContainer resultContainer) { }

	[CompilerGenerated]
	// RVA: 0x4126AE0 Offset: 0x4122AE0 VA: 0x4126AE0 Slot: 21
	public Purchase get_Purchase() { }

	[CompilerGenerated]
	// RVA: 0x4126AE8 Offset: 0x4122AE8 VA: 0x4126AE8
	private void set_Purchase(Purchase value) { }

	// RVA: 0x4126AF0 Offset: 0x4122AF0 VA: 0x4126AF0 Slot: 3
	public override string ToString() { }
}

// Namespace: Facebook.Unity
internal class PurchasesResult : ResultBase, IPurchasesResult, IResult // TypeDefIndex: 24715
{
	// Fields
	[CompilerGenerated]
	private IList<Purchase> <Purchases>k__BackingField; // 0x50

	// Properties
	public IList<Purchase> Purchases { get; set; }

	// Methods

	// RVA: 0x4126BE4 Offset: 0x4122BE4 VA: 0x4126BE4
	public void .ctor(ResultContainer resultContainer) { }

	[CompilerGenerated]
	// RVA: 0x41272A8 Offset: 0x41232A8 VA: 0x41272A8 Slot: 21
	public IList<Purchase> get_Purchases() { }

	[CompilerGenerated]
	// RVA: 0x41272B0 Offset: 0x41232B0 VA: 0x41272B0
	private void set_Purchases(IList<Purchase> value) { }

	// RVA: 0x41272B8 Offset: 0x41232B8 VA: 0x41272B8 Slot: 3
	public override string ToString() { }
}

// Namespace: Facebook.Unity
internal abstract class ResultBase : IInternalResult, IResult // TypeDefIndex: 24716
{
	// Fields
	[CompilerGenerated]
	private string <Error>k__BackingField; // 0x10
	[CompilerGenerated]
	private IDictionary<string, string> <ErrorDictionary>k__BackingField; // 0x18
	[CompilerGenerated]
	private IDictionary<string, object> <ResultDictionary>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <RawResult>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <Cancelled>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <CallbackId>k__BackingField; // 0x38
	[CompilerGenerated]
	private Nullable<long> <CanvasErrorCode>k__BackingField; // 0x40

	// Properties
	public virtual string Error { get; set; }
	public virtual IDictionary<string, string> ErrorDictionary { get; set; }
	public virtual IDictionary<string, object> ResultDictionary { get; set; }
	public virtual string RawResult { get; set; }
	public virtual bool Cancelled { get; set; }
	public virtual string CallbackId { get; set; }
	protected Nullable<long> CanvasErrorCode { get; set; }

	// Methods

	// RVA: 0x41235B0 Offset: 0x411F5B0 VA: 0x41235B0
	internal void .ctor(ResultContainer result) { }

	// RVA: 0x4125248 Offset: 0x4121248 VA: 0x4125248
	internal void .ctor(ResultContainer result, string error, bool cancelled) { }

	[CompilerGenerated]
	// RVA: 0x4127C30 Offset: 0x4123C30 VA: 0x4127C30 Slot: 9
	public virtual string get_Error() { }

	[CompilerGenerated]
	// RVA: 0x4127C38 Offset: 0x4123C38 VA: 0x4127C38 Slot: 10
	protected virtual void set_Error(string value) { }

	[CompilerGenerated]
	// RVA: 0x4127C40 Offset: 0x4123C40 VA: 0x4127C40 Slot: 11
	public virtual IDictionary<string, string> get_ErrorDictionary() { }

	[CompilerGenerated]
	// RVA: 0x4127C48 Offset: 0x4123C48 VA: 0x4127C48 Slot: 12
	protected virtual void set_ErrorDictionary(IDictionary<string, string> value) { }

	[CompilerGenerated]
	// RVA: 0x4127C50 Offset: 0x4123C50 VA: 0x4127C50 Slot: 13
	public virtual IDictionary<string, object> get_ResultDictionary() { }

	[CompilerGenerated]
	// RVA: 0x4127C58 Offset: 0x4123C58 VA: 0x4127C58 Slot: 14
	protected virtual void set_ResultDictionary(IDictionary<string, object> value) { }

	[CompilerGenerated]
	// RVA: 0x4127C60 Offset: 0x4123C60 VA: 0x4127C60 Slot: 15
	public virtual string get_RawResult() { }

	[CompilerGenerated]
	// RVA: 0x4127C68 Offset: 0x4123C68 VA: 0x4127C68 Slot: 16
	protected virtual void set_RawResult(string value) { }

	[CompilerGenerated]
	// RVA: 0x4127C70 Offset: 0x4123C70 VA: 0x4127C70 Slot: 17
	public virtual bool get_Cancelled() { }

	[CompilerGenerated]
	// RVA: 0x4127C78 Offset: 0x4123C78 VA: 0x4127C78 Slot: 18
	protected virtual void set_Cancelled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4127C84 Offset: 0x4123C84 VA: 0x4127C84 Slot: 19
	public virtual string get_CallbackId() { }

	[CompilerGenerated]
	// RVA: 0x4127C8C Offset: 0x4123C8C VA: 0x4127C8C Slot: 20
	protected virtual void set_CallbackId(string value) { }

	[CompilerGenerated]
	// RVA: 0x4127C94 Offset: 0x4123C94 VA: 0x4127C94
	protected Nullable<long> get_CanvasErrorCode() { }

	[CompilerGenerated]
	// RVA: 0x4127CA0 Offset: 0x4123CA0 VA: 0x4127CA0
	private void set_CanvasErrorCode(Nullable<long> value) { }

	// RVA: 0x4123884 Offset: 0x411F884 VA: 0x4123884 Slot: 3
	public override string ToString() { }

	// RVA: 0x4127A18 Offset: 0x4123A18 VA: 0x4127A18
	protected void Init(ResultContainer result, string error, bool cancelled, string callbackId) { }

	// RVA: 0x41276A4 Offset: 0x41236A4 VA: 0x41276A4
	private static string GetErrorValue(IDictionary<string, object> result) { }

	// RVA: 0x4127728 Offset: 0x4123728 VA: 0x4127728
	private static bool GetCancelledValue(IDictionary<string, object> result) { }

	// RVA: 0x4127994 Offset: 0x4123994 VA: 0x4127994
	private static string GetCallbackId(IDictionary<string, object> result) { }
}

// Namespace: Facebook.Unity
internal class ResultContainer // TypeDefIndex: 24717
{
	// Fields
	private const string CanvasResponseKey = "response";
	[CompilerGenerated]
	private string <RawResult>k__BackingField; // 0x10
	[CompilerGenerated]
	private IDictionary<string, object> <ResultDictionary>k__BackingField; // 0x18

	// Properties
	public string RawResult { get; set; }
	public IDictionary<string, object> ResultDictionary { get; set; }

	// Methods

	// RVA: 0x4127FCC Offset: 0x4123FCC VA: 0x4127FCC
	public void .ctor(IDictionary<string, object> dictionary) { }

	// RVA: 0x4120830 Offset: 0x411C830 VA: 0x4120830
	public void .ctor(string result) { }

	[CompilerGenerated]
	// RVA: 0x41281E0 Offset: 0x41241E0 VA: 0x41281E0
	public string get_RawResult() { }

	[CompilerGenerated]
	// RVA: 0x41281E8 Offset: 0x41241E8 VA: 0x41281E8
	private void set_RawResult(string value) { }

	[CompilerGenerated]
	// RVA: 0x41281F0 Offset: 0x41241F0 VA: 0x41281F0
	public IDictionary<string, object> get_ResultDictionary() { }

	[CompilerGenerated]
	// RVA: 0x41281F8 Offset: 0x41241F8 VA: 0x41281F8
	public void set_ResultDictionary(IDictionary<string, object> value) { }

	// RVA: 0x4128044 Offset: 0x4124044 VA: 0x4128044
	private IDictionary<string, object> GetWebFormattedResponseDictionary(IDictionary<string, object> resultDictionary) { }
}

// Namespace: Facebook.Unity
internal class RewardedVideoResult : ResultBase, IRewardedVideoResult, IResult // TypeDefIndex: 24718
{
	// Methods

	// RVA: 0x4128200 Offset: 0x4124200 VA: 0x4128200
	internal void .ctor(ResultContainer resultContainer) { }
}

// Namespace: Facebook.Unity
internal class ScheduleAppToUserNotificationResult : ResultBase, IScheduleAppToUserNotificationResult, IResult // TypeDefIndex: 24719
{
	// Methods

	// RVA: 0x4128344 Offset: 0x4124344 VA: 0x4128344
	internal void .ctor(ResultContainer resultContainer) { }
}

// Namespace: Facebook.Unity
internal class ShareResult : ResultBase, IShareResult, IResult // TypeDefIndex: 24720
{
	// Fields
	[CompilerGenerated]
	private string <PostId>k__BackingField; // 0x50

	// Properties
	public string PostId { get; set; }
	internal static string PostIDKey { get; }

	// Methods

	// RVA: 0x4128348 Offset: 0x4124348 VA: 0x4128348
	internal void .ctor(ResultContainer resultContainer) { }

	[CompilerGenerated]
	// RVA: 0x412849C Offset: 0x412449C VA: 0x412849C Slot: 21
	public string get_PostId() { }

	[CompilerGenerated]
	// RVA: 0x41284A4 Offset: 0x41244A4 VA: 0x41284A4
	private void set_PostId(string value) { }

	// RVA: 0x412843C Offset: 0x412443C VA: 0x412843C
	internal static string get_PostIDKey() { }

	// RVA: 0x41284AC Offset: 0x41244AC VA: 0x41284AC Slot: 3
	public override string ToString() { }
}

// Namespace: Facebook.Unity
internal class SubscribableCatalogResult : ResultBase, ISubscribableCatalogResult, IResult // TypeDefIndex: 24721
{
	// Fields
	[CompilerGenerated]
	private IList<SubscribableProduct> <SubscribableProducts>k__BackingField; // 0x50

	// Properties
	public IList<SubscribableProduct> SubscribableProducts { get; set; }

	// Methods

	// RVA: 0x41285A0 Offset: 0x41245A0 VA: 0x41285A0
	public void .ctor(ResultContainer resultContainer) { }

	[CompilerGenerated]
	// RVA: 0x4128D8C Offset: 0x4124D8C VA: 0x4128D8C Slot: 21
	public IList<SubscribableProduct> get_SubscribableProducts() { }

	[CompilerGenerated]
	// RVA: 0x4128D94 Offset: 0x4124D94 VA: 0x4128D94
	private void set_SubscribableProducts(IList<SubscribableProduct> value) { }

	// RVA: 0x4128D9C Offset: 0x4124D9C VA: 0x4128D9C Slot: 3
	public override string ToString() { }
}

// Namespace: Facebook.Unity
internal class SubscriptionResult : ResultBase, ISubscriptionResult, IResult // TypeDefIndex: 24722
{
	// Fields
	[CompilerGenerated]
	private Subscription <Subscription>k__BackingField; // 0x50

	// Properties
	public Subscription Subscription { get; set; }

	// Methods

	// RVA: 0x4129188 Offset: 0x4125188 VA: 0x4129188
	public void .ctor(ResultContainer resultContainer) { }

	[CompilerGenerated]
	// RVA: 0x41296B0 Offset: 0x41256B0 VA: 0x41296B0 Slot: 21
	public Subscription get_Subscription() { }

	[CompilerGenerated]
	// RVA: 0x41296B8 Offset: 0x41256B8 VA: 0x41296B8
	private void set_Subscription(Subscription value) { }

	// RVA: 0x41296C0 Offset: 0x41256C0 VA: 0x41296C0 Slot: 3
	public override string ToString() { }
}

// Namespace: Facebook.Unity
internal class SubscriptionsResult : ResultBase, ISubscriptionsResult, IResult // TypeDefIndex: 24723
{
	// Fields
	[CompilerGenerated]
	private IList<Subscription> <Subscriptions>k__BackingField; // 0x50

	// Properties
	public IList<Subscription> Subscriptions { get; set; }

	// Methods

	// RVA: 0x41297B4 Offset: 0x41257B4 VA: 0x41297B4
	public void .ctor(ResultContainer resultContainer) { }

	[CompilerGenerated]
	// RVA: 0x4129E6C Offset: 0x4125E6C VA: 0x4129E6C Slot: 21
	public IList<Subscription> get_Subscriptions() { }

	[CompilerGenerated]
	// RVA: 0x4129E74 Offset: 0x4125E74 VA: 0x4129E74
	private void set_Subscriptions(IList<Subscription> value) { }

	// RVA: 0x4129E7C Offset: 0x4125E7C VA: 0x4129E7C Slot: 3
	public override string ToString() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AsyncRequestString.<Start>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 24724
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AsyncRequestString <>4__this; // 0x20
	private UnityWebRequestAsyncOperation <webRequestOperation>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x412A4A4 Offset: 0x41264A4 VA: 0x412A4A4
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x412A4D4 Offset: 0x41264D4 VA: 0x412A4D4 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x412A4D8 Offset: 0x41264D8 VA: 0x412A4D8 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x412ADDC Offset: 0x4126DDC VA: 0x412ADDC Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x412ADE4 Offset: 0x4126DE4 VA: 0x412ADE4 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x412AE1C Offset: 0x4126E1C VA: 0x412AE1C Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: Facebook.Unity
internal class AsyncRequestString : MonoBehaviour // TypeDefIndex: 24725
{
	// Fields
	private Uri url; // 0x20
	private HttpMethod method; // 0x28
	private IDictionary<string, string> formData; // 0x30
	private WWWForm query; // 0x38
	private FacebookDelegate<IGraphResult> callback; // 0x40

	// Methods

	// RVA: 0x412A268 Offset: 0x4126268 VA: 0x412A268
	internal static void Post(Uri url, Dictionary<string, string> formData, FacebookDelegate<IGraphResult> callback) { }

	// RVA: 0x412A314 Offset: 0x4126314 VA: 0x412A314
	internal static void Get(Uri url, Dictionary<string, string> formData, FacebookDelegate<IGraphResult> callback) { }

	// RVA: 0x412A324 Offset: 0x4126324 VA: 0x412A324
	internal static void Request(Uri url, HttpMethod method, WWWForm query, FacebookDelegate<IGraphResult> callback) { }

	// RVA: 0x412A278 Offset: 0x4126278 VA: 0x412A278
	internal static void Request(Uri url, HttpMethod method, IDictionary<string, string> formData, FacebookDelegate<IGraphResult> callback) { }

	// RVA: 0x412A438 Offset: 0x4126438 VA: 0x412A438
	internal IEnumerator Start() { }

	// RVA: 0x412A3C0 Offset: 0x41263C0 VA: 0x412A3C0
	internal AsyncRequestString SetUrl(Uri url) { }

	// RVA: 0x412A3DC Offset: 0x41263DC VA: 0x412A3DC
	internal AsyncRequestString SetMethod(HttpMethod method) { }

	// RVA: 0x412A41C Offset: 0x412641C VA: 0x412A41C
	internal AsyncRequestString SetFormData(IDictionary<string, string> formData) { }

	// RVA: 0x412A3E4 Offset: 0x41263E4 VA: 0x412A3E4
	internal AsyncRequestString SetQuery(WWWForm query) { }

	// RVA: 0x412A400 Offset: 0x4126400 VA: 0x412A400
	internal AsyncRequestString SetCallback(FacebookDelegate<IGraphResult> callback) { }

	// RVA: 0x412A4CC Offset: 0x41264CC VA: 0x412A4CC
	public void .ctor() { }
}

// Namespace: 
private class FacebookLogger.DebugLogger : IFacebookLogger // TypeDefIndex: 24726
{
	// Methods

	// RVA: 0x412AEC4 Offset: 0x4126EC4 VA: 0x412AEC4
	public void .ctor() { }

	// RVA: 0x412B104 Offset: 0x4127104 VA: 0x412B104 Slot: 4
	public void Log(string msg) { }

	// RVA: 0x412B184 Offset: 0x4127184 VA: 0x412B184 Slot: 5
	public void Info(string msg) { }

	// RVA: 0x412B1DC Offset: 0x41271DC VA: 0x412B1DC Slot: 6
	public void Warn(string msg) { }
}

// Namespace: Facebook.Unity
internal static class FacebookLogger // TypeDefIndex: 24727
{
	// Fields
	[CompilerGenerated]
	private static IFacebookLogger <Instance>k__BackingField; // 0x0

	// Properties
	private static IFacebookLogger Instance { get; set; }

	// Methods

	// RVA: 0x412AE24 Offset: 0x4126E24 VA: 0x412AE24
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x412AECC Offset: 0x4126ECC VA: 0x412AECC
	private static IFacebookLogger get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x412AF24 Offset: 0x4126F24 VA: 0x412AF24
	internal static void set_Instance(IFacebookLogger value) { }

	// RVA: 0x412AF8C Offset: 0x4126F8C VA: 0x412AF8C
	public static void Log(string msg) { }

	// RVA: 0x411AD74 Offset: 0x4116D74 VA: 0x411AD74
	public static void Info(string msg) { }

	// RVA: 0x4119A90 Offset: 0x4115A90 VA: 0x4119A90
	public static void Warn(string msg) { }

	// RVA: 0x412B08C Offset: 0x412708C VA: 0x412B08C
	public static void Warn(string format, string[] args) { }
}

// Namespace: Facebook.Unity
public enum HttpMethod // TypeDefIndex: 24728
{
	// Fields
	public int value__; // 0x0
	public const HttpMethod GET = 0;
	public const HttpMethod POST = 1;
	public const HttpMethod DELETE = 2;
}

// Namespace: Facebook.Unity
internal interface IFacebookLogger // TypeDefIndex: 24729
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Log(string msg);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Info(string msg);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Warn(string msg);
}

// Namespace: 
public sealed class Utilities.Callback<T> : MulticastDelegate // TypeDefIndex: 24730
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA75DC Offset: 0x5BA35DC VA: 0x5BA75DC
	|-Utilities.Callback<object>..ctor
	|
	|-RVA: 0x5BA76F8 Offset: 0x5BA36F8 VA: 0x5BA76F8
	|-Utilities.Callback<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA76E4 Offset: 0x5BA36E4 VA: 0x5BA76E4
	|-Utilities.Callback<object>.Invoke
	|
	|-RVA: 0x5BA7800 Offset: 0x5BA3800 VA: 0x5BA7800
	|-Utilities.Callback<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Utilities.<>c // TypeDefIndex: 24731
{
	// Fields
	public static readonly Utilities.<>c <>9; // 0x0
	public static Func<object, string> <>9__19_0; // 0x8

	// Methods

	// RVA: 0x412D794 Offset: 0x4129794 VA: 0x412D794
	private static void .cctor() { }

	// RVA: 0x412D7FC Offset: 0x41297FC VA: 0x412D7FC
	public void .ctor() { }

	// RVA: 0x412D804 Offset: 0x4129804 VA: 0x412D804
	internal string <ParsePermissionFromResult>b__19_0(object permission) { }
}

// Namespace: Facebook.Unity
[Extension]
internal static class Utilities // TypeDefIndex: 24732
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static bool TryGetValue<T>(IDictionary<string, object> dictionary, string key, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x475A540 Offset: 0x4756540 VA: 0x475A540
	|-Utilities.TryGetValue<bool>
	|
	|-RVA: 0x475A69C Offset: 0x475669C VA: 0x475A69C
	|-Utilities.TryGetValue<int>
	|
	|-RVA: 0x475A7F0 Offset: 0x47567F0 VA: 0x475A7F0
	|-Utilities.TryGetValue<long>
	|
	|-RVA: 0x475A944 Offset: 0x4756944 VA: 0x475A944
	|-Utilities.TryGetValue<object>
	|
	|-RVA: 0x475AAE0 Offset: 0x4756AE0 VA: 0x475AAE0
	|-Utilities.TryGetValue<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x4116714 Offset: 0x4112714 VA: 0x4116714
	public static long TotalSeconds(DateTime dateTime) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetValueOrDefault<T>(IDictionary<string, object> dictionary, string key, bool logWarning = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x475A0B4 Offset: 0x47560B4 VA: 0x475A0B4
	|-Utilities.GetValueOrDefault<bool>
	|
	|-RVA: 0x475A1B0 Offset: 0x47561B0 VA: 0x475A1B0
	|-Utilities.GetValueOrDefault<long>
	|
	|-RVA: 0x475A2AC Offset: 0x47562AC VA: 0x475A2AC
	|-Utilities.GetValueOrDefault<object>
	|
	|-RVA: 0x475A3A8 Offset: 0x47563A8 VA: 0x475A3A8
	|-Utilities.GetValueOrDefault<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x41167F8 Offset: 0x41127F8 VA: 0x41167F8
	public static string ToCommaSeparateList(IEnumerable<string> list) { }

	[Extension]
	// RVA: 0x412B234 Offset: 0x4127234 VA: 0x412B234
	public static string AbsoluteUrlOrEmptyString(Uri uri) { }

	// RVA: 0x41182FC Offset: 0x41142FC VA: 0x41182FC
	public static string GetUserAgent(string productName, string productVersion) { }

	[Extension]
	// RVA: 0x4123DDC Offset: 0x411FDDC VA: 0x4123DDC
	public static string ToJson(IDictionary<string, object> dictionary) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static void AddAllKVPFrom<T1, T2>(IDictionary<T1, T2> dest, IDictionary<T1, T2> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4759698 Offset: 0x4755698 VA: 0x4759698
	|-Utilities.AddAllKVPFrom<object, object>
	|
	|-RVA: 0x4759AFC Offset: 0x4755AFC VA: 0x4759AFC
	|-Utilities.AddAllKVPFrom<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x4123620 Offset: 0x411F620 VA: 0x4123620
	public static AccessToken ParseAccessTokenFromResult(IDictionary<string, object> resultDictionary) { }

	// RVA: 0x4125970 Offset: 0x4121970 VA: 0x4125970
	public static AuthenticationToken ParseAuthenticationTokenFromResult(IDictionary<string, object> resultDictionary) { }

	[Extension]
	// RVA: 0x4116898 Offset: 0x4112898 VA: 0x4116898
	public static string ToStringNullOk(object obj) { }

	// RVA: 0x41168F8 Offset: 0x41128F8 VA: 0x41168F8
	public static string FormatToString(string baseString, string className, IDictionary<string, string> propertiesAndValues) { }

	// RVA: 0x412B2D4 Offset: 0x41272D4 VA: 0x412B2D4
	private static DateTime ParseExpirationDateFromResult(IDictionary<string, object> resultDictionary) { }

	// RVA: 0x412B714 Offset: 0x4127714 VA: 0x412B714
	private static Nullable<DateTime> ParseLastRefreshFromResult(IDictionary<string, object> resultDictionary) { }

	// RVA: 0x412B434 Offset: 0x4127434 VA: 0x412B434
	private static ICollection<string> ParsePermissionFromResult(IDictionary<string, object> resultDictionary) { }

	// RVA: 0x4124798 Offset: 0x4120798 VA: 0x4124798
	public static IList<Product> ParseCatalogFromResult(IDictionary<string, object> resultDictionary) { }

	// RVA: 0x412B8B4 Offset: 0x41278B4 VA: 0x412B8B4
	public static Product ParseProductFromCatalogResult(IDictionary<string, object> product, bool isWindows = False) { }

	// RVA: 0x4128860 Offset: 0x4124860 VA: 0x4128860
	public static IList<SubscribableProduct> ParseSubscribableCatalogFromResult(IDictionary<string, object> resultDictionary) { }

	// RVA: 0x412BF34 Offset: 0x4127F34 VA: 0x412BF34
	public static SubscribableProduct ParseSubscribableProductFromCatalogResult(IDictionary<string, object> product, bool isWindows = False) { }

	// RVA: 0x4126EA4 Offset: 0x4122EA4 VA: 0x4126EA4
	public static IList<Purchase> ParsePurchasesFromResult(IDictionary<string, object> resultDictionary) { }

	// RVA: 0x4126974 Offset: 0x4122974 VA: 0x4126974
	public static Purchase ParsePurchaseFromResult(IDictionary<string, object> resultDictionary) { }

	// RVA: 0x4129A68 Offset: 0x4125A68 VA: 0x4129A68
	public static IList<Subscription> ParseSubscriptionsFromResult(IDictionary<string, object> resultDictionary) { }

	// RVA: 0x4129544 Offset: 0x4125544 VA: 0x4129544
	public static Subscription ParseSubscriptionFromResult(IDictionary<string, object> resultDictionary) { }

	// RVA: 0x412C678 Offset: 0x4128678 VA: 0x412C678
	public static Purchase ParsePurchaseFromDictionary(IDictionary<string, object> purchase, bool isWindows = False) { }

	// RVA: 0x412D0E0 Offset: 0x41290E0 VA: 0x412D0E0
	public static Subscription ParseSubscriptionFromDictionary(IDictionary<string, object> subscription, bool isWindows = False) { }

	// RVA: 0x4127CA8 Offset: 0x4123CA8 VA: 0x4127CA8
	public static IDictionary<string, string> ParseStringDictionaryFromString(string input) { }

	// RVA: 0x412624C Offset: 0x412224C VA: 0x412624C
	public static IDictionary<string, string> ParseInnerStringDictionary(IDictionary<string, object> resultDictionary, string key) { }

	// RVA: 0x41220EC Offset: 0x411E0EC VA: 0x41220EC
	public static DateTime FromTimestamp(int timestamp) { }
}

// Namespace: Facebook.Unity
internal static class FBUnityUtility // TypeDefIndex: 24733
{
	// Fields
	private static IAsyncRequestStringWrapper asyncRequestStringWrapper; // 0x0

	// Properties
	public static IAsyncRequestStringWrapper AsyncRequestStringWrapper { get; }

	// Methods

	// RVA: 0x411FD18 Offset: 0x411BD18 VA: 0x411FD18
	public static IAsyncRequestStringWrapper get_AsyncRequestStringWrapper() { }
}

// Namespace: Facebook.Unity
internal class AsyncRequestStringWrapper : IAsyncRequestStringWrapper // TypeDefIndex: 24734
{
	// Methods

	// RVA: 0x412D830 Offset: 0x4129830 VA: 0x412D830 Slot: 4
	public void Request(Uri url, HttpMethod method, WWWForm query, FacebookDelegate<IGraphResult> callback) { }

	// RVA: 0x412D844 Offset: 0x4129844 VA: 0x412D844 Slot: 5
	public void Request(Uri url, HttpMethod method, IDictionary<string, string> formData, FacebookDelegate<IGraphResult> callback) { }

	// RVA: 0x412D828 Offset: 0x4129828 VA: 0x412D828
	public void .ctor() { }
}

// Namespace: Facebook.Unity
internal interface IAsyncRequestStringWrapper // TypeDefIndex: 24735
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Request(Uri url, HttpMethod method, WWWForm query, FacebookDelegate<IGraphResult> callback);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Request(Uri url, HttpMethod method, IDictionary<string, string> formData, FacebookDelegate<IGraphResult> callback);
}

// Namespace: 
[CompilerGenerated]
private sealed class FacebookScheduler.<DelayEvent>d__1 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 24736
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public long delay; // 0x20
	public Action action; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x412D8F4 Offset: 0x41298F4 VA: 0x412D8F4
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x412D924 Offset: 0x4129924 VA: 0x412D924 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x412D928 Offset: 0x4129928 VA: 0x412D928 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x412D9E0 Offset: 0x41299E0 VA: 0x412D9E0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x412D9E8 Offset: 0x41299E8 VA: 0x412D9E8 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x412DA20 Offset: 0x4129A20 VA: 0x412DA20 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: Facebook.Unity
internal class FacebookScheduler : MonoBehaviour // TypeDefIndex: 24737
{
	// Methods

	// RVA: 0x412D858 Offset: 0x4129858 VA: 0x412D858 Slot: 4
	public void Schedule(Action action, long delay) { }

	// RVA: 0x412D878 Offset: 0x4129878 VA: 0x412D878
	public IEnumerator DelayEvent(Action action, long delay) { }

	// RVA: 0x412D91C Offset: 0x412991C VA: 0x412D91C
	public void .ctor() { }
}

// Namespace: Facebook.Unity
public interface IHasLicenseResult : IResult // TypeDefIndex: 24738
{}

// Namespace: Facebook.Unity
internal class CodelessIAPAutoLog // TypeDefIndex: 24739
{
	// Methods

	// RVA: 0x412DA28 Offset: 0x4129A28 VA: 0x412DA28
	internal static void handlePurchaseCompleted(object data) { }

	// RVA: 0x412DE7C Offset: 0x4129E7C VA: 0x412DE7C
	internal static void addListenerToIAPButtons(object listenerObject) { }

	// RVA: 0x412DFA8 Offset: 0x4129FA8 VA: 0x412DFA8
	internal static void addListenerToGameObject(Object gameObject, object listenerObject) { }

	// RVA: 0x412E360 Offset: 0x412A360 VA: 0x412E360
	private static Type FindTypeInAssemblies(string typeName, string nameSpace) { }

	// RVA: 0x412DF2C Offset: 0x4129F2C VA: 0x412DF2C
	private static Object[] FindObjectsOfTypeByName(string typeName, string nameSpace) { }

	// RVA: 0x412E4A4 Offset: 0x412A4A4 VA: 0x412E4A4
	private static object GetField(object inObj, string fieldName) { }

	// RVA: 0x412DE1C Offset: 0x4129E1C VA: 0x412DE1C
	private static object GetProperty(object inObj, string propertyName) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CodelessCrawler.<GenSnapshot>d__4 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 24740
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x412E714 Offset: 0x412A714 VA: 0x412E714
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x412F978 Offset: 0x412B978 VA: 0x412F978 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x412F97C Offset: 0x412B97C VA: 0x412F97C Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x412FB6C Offset: 0x412BB6C VA: 0x412FB6C Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x412FB74 Offset: 0x412BB74 VA: 0x412FB74 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x412FBAC Offset: 0x412BBAC VA: 0x412FBAC Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: Facebook.Unity
public class CodelessCrawler : MonoBehaviour // TypeDefIndex: 24741
{
	// Fields
	private static bool isGeneratingSnapshot; // 0x0
	private static Camera mainCamera; // 0x8

	// Methods

	// RVA: 0x412E500 Offset: 0x412A500 VA: 0x412E500
	public void Awake() { }

	// RVA: 0x412E5A4 Offset: 0x412A5A4 VA: 0x412E5A4
	public void CaptureViewHierarchy(string message) { }

	// RVA: 0x412E6BC Offset: 0x412A6BC VA: 0x412E6BC
	private IEnumerator GenSnapshot() { }

	// RVA: 0x412E73C Offset: 0x412A73C VA: 0x412E73C
	private static void SendAndroid(string json) { }

	// RVA: 0x412E970 Offset: 0x412A970 VA: 0x412E970
	private static void SendIos(string json) { }

	// RVA: 0x412E974 Offset: 0x412A974 VA: 0x412E974
	private static string GenBase64Screenshot() { }

	// RVA: 0x412EABC Offset: 0x412AABC VA: 0x412EABC
	private static string GenViewJson() { }

	// RVA: 0x412EEF4 Offset: 0x412AEF4 VA: 0x412EEF4
	private static void GenChild(GameObject curObj, StringBuilder builder) { }

	// RVA: 0x412F96C Offset: 0x412B96C VA: 0x412F96C
	private void onActiveSceneChanged(Scene arg0, Scene arg1) { }

	// RVA: 0x412E664 Offset: 0x412A664 VA: 0x412E664
	private static void updateMainCamera() { }

	// RVA: 0x412F798 Offset: 0x412B798 VA: 0x412F798
	private static Vector2 getScreenCoordinate(Vector3 position, RenderMode renderMode) { }

	// RVA: 0x412F874 Offset: 0x412B874 VA: 0x412F874
	private static string getClasstypeBitmaskButton() { }

	// RVA: 0x412F8F8 Offset: 0x412B8F8 VA: 0x412F8F8
	private static string getVisibility(GameObject gameObj) { }

	// RVA: 0x412F970 Offset: 0x412B970 VA: 0x412F970
	public void .ctor() { }
}

// Namespace: Facebook.Unity
public class CodelessUIInteractEvent : MonoBehaviour // TypeDefIndex: 24742
{
	// Fields
	[CompilerGenerated]
	private FBSDKEventBindingManager <eventBindingManager>k__BackingField; // 0x20

	// Properties
	private FBSDKEventBindingManager eventBindingManager { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x412FBB4 Offset: 0x412BBB4 VA: 0x412FBB4
	private FBSDKEventBindingManager get_eventBindingManager() { }

	[CompilerGenerated]
	// RVA: 0x412FBBC Offset: 0x412BBBC VA: 0x412FBBC
	private void set_eventBindingManager(FBSDKEventBindingManager value) { }

	// RVA: 0x412FBC4 Offset: 0x412BBC4 VA: 0x412FBC4
	private void Awake() { }

	// RVA: 0x412FBE4 Offset: 0x412BBE4 VA: 0x412FBE4
	private static void SetLoggerInitAndroid() { }

	// RVA: 0x412FD20 Offset: 0x412BD20 VA: 0x412FD20
	private static void SetLoggerInitIos() { }

	// RVA: 0x412FD24 Offset: 0x412BD24 VA: 0x412FD24
	public void OnReceiveMapping(string message) { }

	// RVA: 0x41300B4 Offset: 0x412C0B4 VA: 0x41300B4
	public void .ctor() { }
}

// Namespace: Facebook.Unity
public class FBSDKViewHiearchy // TypeDefIndex: 24743
{
	// Methods

	// RVA: 0x41300BC Offset: 0x412C0BC VA: 0x41300BC
	public static bool CheckGameObjectMatchPath(GameObject go, List<FBSDKCodelessPathComponent> path) { }

	// RVA: 0x41300E0 Offset: 0x412C0E0 VA: 0x41300E0
	public static bool CheckPathMatchPath(List<FBSDKCodelessPathComponent> goPath, List<FBSDKCodelessPathComponent> path) { }

	// RVA: 0x41300D8 Offset: 0x412C0D8 VA: 0x41300D8
	public static List<FBSDKCodelessPathComponent> GetPath(GameObject go) { }

	// RVA: 0x4130208 Offset: 0x412C208 VA: 0x4130208
	public static List<FBSDKCodelessPathComponent> GetPath(GameObject go, int limit) { }

	// RVA: 0x4130508 Offset: 0x412C508 VA: 0x4130508
	public static GameObject GetParent(GameObject go) { }

	// RVA: 0x41309D4 Offset: 0x412C9D4 VA: 0x41309D4
	public static Dictionary<string, object> GetAttribute(GameObject obj, GameObject parent) { }
}

// Namespace: Facebook.Unity
public class FBSDKCodelessPathComponent // TypeDefIndex: 24744
{
	// Fields
	[CompilerGenerated]
	private string <className>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <text>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <hint>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <desc>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <tag>k__BackingField; // 0x30
	[CompilerGenerated]
	private long <index>k__BackingField; // 0x38
	[CompilerGenerated]
	private long <section>k__BackingField; // 0x40
	[CompilerGenerated]
	private long <row>k__BackingField; // 0x48
	[CompilerGenerated]
	private long <matchBitmask>k__BackingField; // 0x50

	// Properties
	public string className { get; set; }
	public string text { set; }
	public string hint { set; }
	public string desc { set; }
	public string tag { set; }
	public long index { set; }
	public long section { set; }
	public long row { set; }
	public long matchBitmask { set; }

	// Methods

	// RVA: 0x41305B0 Offset: 0x412C5B0 VA: 0x41305B0
	public void .ctor(Dictionary<string, object> dict) { }

	[CompilerGenerated]
	// RVA: 0x4130BA0 Offset: 0x412CBA0 VA: 0x4130BA0
	public string get_className() { }

	[CompilerGenerated]
	// RVA: 0x4130BA8 Offset: 0x412CBA8 VA: 0x4130BA8
	public void set_className(string value) { }

	[CompilerGenerated]
	// RVA: 0x4130BB0 Offset: 0x412CBB0 VA: 0x4130BB0
	public void set_text(string value) { }

	[CompilerGenerated]
	// RVA: 0x4130BB8 Offset: 0x412CBB8 VA: 0x4130BB8
	public void set_hint(string value) { }

	[CompilerGenerated]
	// RVA: 0x4130BC0 Offset: 0x412CBC0 VA: 0x4130BC0
	public void set_desc(string value) { }

	[CompilerGenerated]
	// RVA: 0x4130BC8 Offset: 0x412CBC8 VA: 0x4130BC8
	public void set_tag(string value) { }

	[CompilerGenerated]
	// RVA: 0x4130BD0 Offset: 0x412CBD0 VA: 0x4130BD0
	public void set_index(long value) { }

	[CompilerGenerated]
	// RVA: 0x4130BD8 Offset: 0x412CBD8 VA: 0x4130BD8
	public void set_section(long value) { }

	[CompilerGenerated]
	// RVA: 0x4130BE0 Offset: 0x412CBE0 VA: 0x4130BE0
	public void set_row(long value) { }

	[CompilerGenerated]
	// RVA: 0x4130BE8 Offset: 0x412CBE8 VA: 0x4130BE8
	public void set_matchBitmask(long value) { }
}

// Namespace: Facebook.Unity
public class FBSDKEventBinding // TypeDefIndex: 24745
{
	// Fields
	[CompilerGenerated]
	private string <eventName>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <eventType>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <appVersion>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <pathType>k__BackingField; // 0x28
	[CompilerGenerated]
	private List<FBSDKCodelessPathComponent> <path>k__BackingField; // 0x30
	[CompilerGenerated]
	private List<string> <parameters>k__BackingField; // 0x38

	// Properties
	public string eventName { get; set; }
	public string eventType { get; set; }
	public string appVersion { get; set; }
	public List<FBSDKCodelessPathComponent> path { get; set; }

	// Methods

	// RVA: 0x4130BF0 Offset: 0x412CBF0 VA: 0x4130BF0
	public void .ctor(Dictionary<string, object> dict) { }

	[CompilerGenerated]
	// RVA: 0x41310B0 Offset: 0x412D0B0 VA: 0x41310B0
	public string get_eventName() { }

	[CompilerGenerated]
	// RVA: 0x41310B8 Offset: 0x412D0B8 VA: 0x41310B8
	public void set_eventName(string value) { }

	[CompilerGenerated]
	// RVA: 0x41310C0 Offset: 0x412D0C0 VA: 0x41310C0
	public string get_eventType() { }

	[CompilerGenerated]
	// RVA: 0x41310C8 Offset: 0x412D0C8 VA: 0x41310C8
	public void set_eventType(string value) { }

	[CompilerGenerated]
	// RVA: 0x41310D0 Offset: 0x412D0D0 VA: 0x41310D0
	public string get_appVersion() { }

	[CompilerGenerated]
	// RVA: 0x41310D8 Offset: 0x412D0D8 VA: 0x41310D8
	public void set_appVersion(string value) { }

	[CompilerGenerated]
	// RVA: 0x41310E0 Offset: 0x412D0E0 VA: 0x41310E0
	public List<FBSDKCodelessPathComponent> get_path() { }

	[CompilerGenerated]
	// RVA: 0x41310E8 Offset: 0x412D0E8 VA: 0x41310E8
	public void set_path(List<FBSDKCodelessPathComponent> value) { }
}

// Namespace: Facebook.Unity
public class FBSDKEventBindingManager // TypeDefIndex: 24746
{
	// Fields
	[CompilerGenerated]
	private List<FBSDKEventBinding> <eventBindings>k__BackingField; // 0x10

	// Properties
	public List<FBSDKEventBinding> eventBindings { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x41310F0 Offset: 0x412D0F0 VA: 0x41310F0
	public List<FBSDKEventBinding> get_eventBindings() { }

	[CompilerGenerated]
	// RVA: 0x41310F8 Offset: 0x412D0F8 VA: 0x41310F8
	public void set_eventBindings(List<FBSDKEventBinding> value) { }

	// RVA: 0x412FE0C Offset: 0x412BE0C VA: 0x412FE0C
	public void .ctor(List<object> listDict) { }
}

// Namespace: Facebook.Unity
public interface IMediaUploadResult : IResult // TypeDefIndex: 24747
{
	// Properties
	public abstract string MediaId { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_MediaId();
}

// Namespace: Facebook.Unity
internal class MediaUploadResult : ResultBase, IMediaUploadResult, IResult // TypeDefIndex: 24748
{
	// Fields
	[CompilerGenerated]
	private string <MediaId>k__BackingField; // 0x50

	// Properties
	public string MediaId { get; set; }

	// Methods

	// RVA: 0x4131100 Offset: 0x412D100 VA: 0x4131100
	internal void .ctor(ResultContainer resultContainer) { }

	[CompilerGenerated]
	// RVA: 0x41311FC Offset: 0x412D1FC VA: 0x41311FC Slot: 21
	public string get_MediaId() { }

	[CompilerGenerated]
	// RVA: 0x4131204 Offset: 0x412D204 VA: 0x4131204
	private void set_MediaId(string value) { }

	// RVA: 0x413120C Offset: 0x412D20C VA: 0x413120C Slot: 3
	public override string ToString() { }
}

// Namespace: Facebook.Unity
public interface ISessionScoreResult : IResult // TypeDefIndex: 24749
{}

// Namespace: Facebook.Unity
internal class SessionScoreResult : ResultBase, ISessionScoreResult, IResult // TypeDefIndex: 24750
{
	// Methods

	// RVA: 0x4131300 Offset: 0x412D300 VA: 0x4131300
	internal void .ctor(ResultContainer resultContainer) { }
}

// Namespace: Facebook.Unity
public class AuthenticationToken // TypeDefIndex: 24751
{
	// Fields
	[CompilerGenerated]
	private string <TokenString>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Nonce>k__BackingField; // 0x18

	// Properties
	public string TokenString { get; set; }
	public string Nonce { get; set; }

	// Methods

	// RVA: 0x412B7E8 Offset: 0x41277E8 VA: 0x412B7E8
	internal void .ctor(string tokenString, string nonce) { }

	[CompilerGenerated]
	// RVA: 0x4131304 Offset: 0x412D304 VA: 0x4131304
	public string get_TokenString() { }

	[CompilerGenerated]
	// RVA: 0x413130C Offset: 0x412D30C VA: 0x413130C
	private void set_TokenString(string value) { }

	[CompilerGenerated]
	// RVA: 0x4131314 Offset: 0x412D314 VA: 0x4131314
	public string get_Nonce() { }

	[CompilerGenerated]
	// RVA: 0x413131C Offset: 0x412D31C VA: 0x413131C
	private void set_Nonce(string value) { }

	// RVA: 0x4131324 Offset: 0x412D324 VA: 0x4131324 Slot: 3
	public override string ToString() { }
}

// Namespace: Facebook.Unity
public enum LoginTracking // TypeDefIndex: 24752
{
	// Fields
	public int value__; // 0x0
	public const LoginTracking ENABLED = 0;
	public const LoginTracking LIMITED = 1;
}

// Namespace: Facebook.Unity
public class Profile // TypeDefIndex: 24753
{
	// Fields
	[CompilerGenerated]
	private string <UserID>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <FirstName>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <MiddleName>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <LastName>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <Email>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <ImageURL>k__BackingField; // 0x40
	[CompilerGenerated]
	private string <LinkURL>k__BackingField; // 0x48
	[CompilerGenerated]
	private string[] <FriendIDs>k__BackingField; // 0x50
	[CompilerGenerated]
	private Nullable<DateTime> <Birthday>k__BackingField; // 0x58
	[CompilerGenerated]
	private UserAgeRange <AgeRange>k__BackingField; // 0x68
	[CompilerGenerated]
	private FBLocation <Hometown>k__BackingField; // 0x70
	[CompilerGenerated]
	private FBLocation <Location>k__BackingField; // 0x78
	[CompilerGenerated]
	private string <Gender>k__BackingField; // 0x80

	// Properties
	public string UserID { get; set; }
	public string FirstName { get; set; }
	public string MiddleName { get; set; }
	public string LastName { get; set; }
	public string Name { get; set; }
	public string Email { get; set; }
	public string ImageURL { get; set; }
	public string LinkURL { get; set; }
	public string[] FriendIDs { get; set; }
	public Nullable<DateTime> Birthday { get; set; }
	public UserAgeRange AgeRange { get; set; }
	public FBLocation Hometown { get; set; }
	public FBLocation Location { get; set; }
	public string Gender { get; set; }

	// Methods

	// RVA: 0x4131434 Offset: 0x412D434 VA: 0x4131434
	internal void .ctor(string userID, string firstName, string middleName, string lastName, string name, string email, string imageURL, string linkURL, string[] friendIDs, string birthday, UserAgeRange ageRange, FBLocation hometown, FBLocation location, string gender) { }

	[CompilerGenerated]
	// RVA: 0x4131690 Offset: 0x412D690 VA: 0x4131690
	public string get_UserID() { }

	[CompilerGenerated]
	// RVA: 0x4131698 Offset: 0x412D698 VA: 0x4131698
	private void set_UserID(string value) { }

	[CompilerGenerated]
	// RVA: 0x41316A0 Offset: 0x412D6A0 VA: 0x41316A0
	public string get_FirstName() { }

	[CompilerGenerated]
	// RVA: 0x41316A8 Offset: 0x412D6A8 VA: 0x41316A8
	private void set_FirstName(string value) { }

	[CompilerGenerated]
	// RVA: 0x41316B0 Offset: 0x412D6B0 VA: 0x41316B0
	public string get_MiddleName() { }

	[CompilerGenerated]
	// RVA: 0x41316B8 Offset: 0x412D6B8 VA: 0x41316B8
	private void set_MiddleName(string value) { }

	[CompilerGenerated]
	// RVA: 0x41316C0 Offset: 0x412D6C0 VA: 0x41316C0
	public string get_LastName() { }

	[CompilerGenerated]
	// RVA: 0x41316C8 Offset: 0x412D6C8 VA: 0x41316C8
	private void set_LastName(string value) { }

	[CompilerGenerated]
	// RVA: 0x41316D0 Offset: 0x412D6D0 VA: 0x41316D0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x41316D8 Offset: 0x412D6D8 VA: 0x41316D8
	private void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x41316E0 Offset: 0x412D6E0 VA: 0x41316E0
	public string get_Email() { }

	[CompilerGenerated]
	// RVA: 0x41316E8 Offset: 0x412D6E8 VA: 0x41316E8
	private void set_Email(string value) { }

	[CompilerGenerated]
	// RVA: 0x41316F0 Offset: 0x412D6F0 VA: 0x41316F0
	public string get_ImageURL() { }

	[CompilerGenerated]
	// RVA: 0x41316F8 Offset: 0x412D6F8 VA: 0x41316F8
	private void set_ImageURL(string value) { }

	[CompilerGenerated]
	// RVA: 0x4131700 Offset: 0x412D700 VA: 0x4131700
	public string get_LinkURL() { }

	[CompilerGenerated]
	// RVA: 0x4131708 Offset: 0x412D708 VA: 0x4131708
	private void set_LinkURL(string value) { }

	[CompilerGenerated]
	// RVA: 0x4131710 Offset: 0x412D710 VA: 0x4131710
	public string[] get_FriendIDs() { }

	[CompilerGenerated]
	// RVA: 0x4131718 Offset: 0x412D718 VA: 0x4131718
	private void set_FriendIDs(string[] value) { }

	[CompilerGenerated]
	// RVA: 0x4131720 Offset: 0x412D720 VA: 0x4131720
	public Nullable<DateTime> get_Birthday() { }

	[CompilerGenerated]
	// RVA: 0x413172C Offset: 0x412D72C VA: 0x413172C
	private void set_Birthday(Nullable<DateTime> value) { }

	[CompilerGenerated]
	// RVA: 0x4131734 Offset: 0x412D734 VA: 0x4131734
	public UserAgeRange get_AgeRange() { }

	[CompilerGenerated]
	// RVA: 0x413173C Offset: 0x412D73C VA: 0x413173C
	private void set_AgeRange(UserAgeRange value) { }

	[CompilerGenerated]
	// RVA: 0x4131744 Offset: 0x412D744 VA: 0x4131744
	public FBLocation get_Hometown() { }

	[CompilerGenerated]
	// RVA: 0x413174C Offset: 0x412D74C VA: 0x413174C
	private void set_Hometown(FBLocation value) { }

	[CompilerGenerated]
	// RVA: 0x4131754 Offset: 0x412D754 VA: 0x4131754
	public FBLocation get_Location() { }

	[CompilerGenerated]
	// RVA: 0x413175C Offset: 0x412D75C VA: 0x413175C
	private void set_Location(FBLocation value) { }

	[CompilerGenerated]
	// RVA: 0x4131764 Offset: 0x412D764 VA: 0x4131764
	public string get_Gender() { }

	[CompilerGenerated]
	// RVA: 0x413176C Offset: 0x412D76C VA: 0x413176C
	private void set_Gender(string value) { }

	// RVA: 0x4131774 Offset: 0x412D774 VA: 0x4131774 Slot: 3
	public override string ToString() { }
}

// Namespace: Facebook.Unity
public class UserAgeRange // TypeDefIndex: 24754
{
	// Fields
	[CompilerGenerated]
	private long <Min>k__BackingField; // 0x10
	[CompilerGenerated]
	private long <Max>k__BackingField; // 0x18

	// Properties
	public long Min { get; set; }
	public long Max { get; set; }

	// Methods

	// RVA: 0x4131B74 Offset: 0x412DB74 VA: 0x4131B74
	internal void .ctor(long min, long max) { }

	[CompilerGenerated]
	// RVA: 0x4131BA0 Offset: 0x412DBA0 VA: 0x4131BA0
	public long get_Min() { }

	[CompilerGenerated]
	// RVA: 0x4131BA8 Offset: 0x412DBA8 VA: 0x4131BA8
	private void set_Min(long value) { }

	[CompilerGenerated]
	// RVA: 0x4131BB0 Offset: 0x412DBB0 VA: 0x4131BB0
	public long get_Max() { }

	[CompilerGenerated]
	// RVA: 0x4131BB8 Offset: 0x412DBB8 VA: 0x4131BB8
	private void set_Max(long value) { }

	// RVA: 0x4131BC0 Offset: 0x412DBC0 VA: 0x4131BC0
	internal static UserAgeRange AgeRangeFromDictionary(IDictionary<string, string> dictionary) { }

	// RVA: 0x4131D9C Offset: 0x412DD9C VA: 0x4131D9C Slot: 3
	public override string ToString() { }
}

// Namespace: Facebook.Unity
public class FBLocation // TypeDefIndex: 24755
{
	// Fields
	[CompilerGenerated]
	private string <ID>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x18

	// Properties
	public string ID { get; set; }
	public string Name { get; set; }

	// Methods

	// RVA: 0x4131EE4 Offset: 0x412DEE4 VA: 0x4131EE4
	internal void .ctor(string id, string name) { }

	[CompilerGenerated]
	// RVA: 0x4131F28 Offset: 0x412DF28 VA: 0x4131F28
	public string get_ID() { }

	[CompilerGenerated]
	// RVA: 0x4131F30 Offset: 0x412DF30 VA: 0x4131F30
	private void set_ID(string value) { }

	[CompilerGenerated]
	// RVA: 0x4131F38 Offset: 0x412DF38 VA: 0x4131F38
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x4131F40 Offset: 0x412DF40 VA: 0x4131F40
	private void set_Name(string value) { }

	// RVA: 0x4131F48 Offset: 0x412DF48 VA: 0x4131F48
	internal static FBLocation FromDictionary(string prefix, IDictionary<string, string> dictionary) { }

	// RVA: 0x4132108 Offset: 0x412E108 VA: 0x4132108 Slot: 3
	public override string ToString() { }
}

// Namespace: Facebook.Unity
public interface ITournamentResult : IResult // TypeDefIndex: 24756
{}

// Namespace: Facebook.Unity
internal class TournamentResult : ResultBase, ITournamentResult, IResult, IDialogResult // TypeDefIndex: 24757
{
	// Fields
	[CompilerGenerated]
	private string <TournamentId>k__BackingField; // 0x50
	[CompilerGenerated]
	private string <ContextId>k__BackingField; // 0x58
	[CompilerGenerated]
	private int <EndTime>k__BackingField; // 0x60
	[CompilerGenerated]
	private string <TournamentTitle>k__BackingField; // 0x68
	[CompilerGenerated]
	private IDictionary<string, string> <Payload>k__BackingField; // 0x70

	// Properties
	public string TournamentId { get; set; }
	public string ContextId { get; set; }
	public int EndTime { get; set; }
	public string TournamentTitle { get; set; }
	public IDictionary<string, string> Payload { get; set; }

	// Methods

	// RVA: 0x4132218 Offset: 0x412E218 VA: 0x4132218
	internal void .ctor(ResultContainer resultContainer) { }

	[CompilerGenerated]
	// RVA: 0x4132438 Offset: 0x412E438 VA: 0x4132438
	public string get_TournamentId() { }

	[CompilerGenerated]
	// RVA: 0x4132440 Offset: 0x412E440 VA: 0x4132440
	private void set_TournamentId(string value) { }

	[CompilerGenerated]
	// RVA: 0x4132448 Offset: 0x412E448 VA: 0x4132448
	public string get_ContextId() { }

	[CompilerGenerated]
	// RVA: 0x4132450 Offset: 0x412E450 VA: 0x4132450
	private void set_ContextId(string value) { }

	[CompilerGenerated]
	// RVA: 0x4132458 Offset: 0x412E458 VA: 0x4132458
	public int get_EndTime() { }

	[CompilerGenerated]
	// RVA: 0x4132460 Offset: 0x412E460 VA: 0x4132460
	private void set_EndTime(int value) { }

	[CompilerGenerated]
	// RVA: 0x4132468 Offset: 0x412E468 VA: 0x4132468
	public string get_TournamentTitle() { }

	[CompilerGenerated]
	// RVA: 0x4132470 Offset: 0x412E470 VA: 0x4132470
	private void set_TournamentTitle(string value) { }

	[CompilerGenerated]
	// RVA: 0x4132478 Offset: 0x412E478 VA: 0x4132478
	public IDictionary<string, string> get_Payload() { }

	[CompilerGenerated]
	// RVA: 0x4132480 Offset: 0x412E480 VA: 0x4132480
	private void set_Payload(IDictionary<string, string> value) { }

	// RVA: 0x4132488 Offset: 0x412E488 VA: 0x4132488 Slot: 3
	public override string ToString() { }
}

// Namespace: Facebook.Unity
public interface IGetTournamentsResult : IResult // TypeDefIndex: 24758
{}

// Namespace: Facebook.Unity
internal class GetTournamentsResult : ResultBase, IGetTournamentsResult, IResult // TypeDefIndex: 24759
{
	// Fields
	[CompilerGenerated]
	private TournamentResult[] <Tournaments>k__BackingField; // 0x50

	// Properties
	private TournamentResult[] Tournaments { set; }

	// Methods

	// RVA: 0x4132964 Offset: 0x412E964 VA: 0x4132964
	internal void .ctor(ResultContainer resultContainer) { }

	[CompilerGenerated]
	// RVA: 0x4132E30 Offset: 0x412EE30 VA: 0x4132E30
	private void set_Tournaments(TournamentResult[] value) { }
}

// Namespace: Facebook.Unity
public interface IDialogResult : IResult // TypeDefIndex: 24760
{}

// Namespace: Facebook.Unity
internal class AbortDialogResult : ResultBase, IDialogResult, IResult // TypeDefIndex: 24761
{
	// Fields
	[CompilerGenerated]
	private bool <Success>k__BackingField; // 0x50

	// Properties
	private bool Success { set; }

	// Methods

	// RVA: 0x4132E38 Offset: 0x412EE38 VA: 0x4132E38
	internal void .ctor(ResultContainer resultContainer) { }

	[CompilerGenerated]
	// RVA: 0x4132E50 Offset: 0x412EE50 VA: 0x4132E50
	private void set_Success(bool value) { }
}

// Namespace: Facebook.Unity
public interface ITournamentScoreResult : IResult // TypeDefIndex: 24762
{}

// Namespace: Facebook.Unity
internal class TournamentScoreResult : ResultBase, ITournamentScoreResult, IResult // TypeDefIndex: 24763
{
	// Methods

	// RVA: 0x4132E5C Offset: 0x412EE5C VA: 0x4132E5C
	internal void .ctor(ResultContainer resultContainer) { }
}

// Namespace: Facebook.Unity
public interface ICreateGamingContextResult : IResult // TypeDefIndex: 24764
{}

// Namespace: Facebook.Unity
public interface ISwitchGamingContextResult : IResult // TypeDefIndex: 24765
{}

// Namespace: Facebook.Unity
public interface IChooseGamingContextResult : IResult // TypeDefIndex: 24766
{}

// Namespace: Facebook.Unity
internal class ChooseGamingContextResult : ResultBase, IChooseGamingContextResult, IResult // TypeDefIndex: 24767
{
	// Fields
	[CompilerGenerated]
	private string <ContextId>k__BackingField; // 0x50

	// Properties
	public string ContextId { get; set; }

	// Methods

	// RVA: 0x4132E60 Offset: 0x412EE60 VA: 0x4132E60
	internal void .ctor(ResultContainer resultContainer) { }

	[CompilerGenerated]
	// RVA: 0x4132F20 Offset: 0x412EF20 VA: 0x4132F20
	public string get_ContextId() { }

	[CompilerGenerated]
	// RVA: 0x4132F28 Offset: 0x412EF28 VA: 0x4132F28
	private void set_ContextId(string value) { }

	// RVA: 0x4132F30 Offset: 0x412EF30 VA: 0x4132F30 Slot: 3
	public override string ToString() { }
}

// Namespace: Facebook.Unity
internal class CreateGamingContextResult : ResultBase, ICreateGamingContextResult, IResult // TypeDefIndex: 24768
{
	// Fields
	[CompilerGenerated]
	private string <ContextId>k__BackingField; // 0x50

	// Properties
	public string ContextId { get; set; }

	// Methods

	// RVA: 0x4133024 Offset: 0x412F024 VA: 0x4133024
	internal void .ctor(ResultContainer resultContainer) { }

	[CompilerGenerated]
	// RVA: 0x41330E4 Offset: 0x412F0E4 VA: 0x41330E4
	public string get_ContextId() { }

	[CompilerGenerated]
	// RVA: 0x41330EC Offset: 0x412F0EC VA: 0x41330EC
	private void set_ContextId(string value) { }

	// RVA: 0x41330F4 Offset: 0x412F0F4 VA: 0x41330F4 Slot: 3
	public override string ToString() { }
}

// Namespace: Facebook.Unity
internal class SwitchGamingContextResult : ResultBase, ISwitchGamingContextResult, IResult // TypeDefIndex: 24769
{
	// Fields
	[CompilerGenerated]
	private string <ContextId>k__BackingField; // 0x50

	// Properties
	public string ContextId { get; set; }

	// Methods

	// RVA: 0x41331E8 Offset: 0x412F1E8 VA: 0x41331E8
	internal void .ctor(ResultContainer resultContainer) { }

	[CompilerGenerated]
	// RVA: 0x41332A8 Offset: 0x412F2A8 VA: 0x41332A8
	public string get_ContextId() { }

	[CompilerGenerated]
	// RVA: 0x41332B0 Offset: 0x412F2B0 VA: 0x41332B0
	private void set_ContextId(string value) { }

	// RVA: 0x41332B8 Offset: 0x412F2B8 VA: 0x41332B8 Slot: 3
	public override string ToString() { }
}

// Namespace: Facebook.Unity
public interface IGetCurrentGamingContextResult : IResult // TypeDefIndex: 24770
{}

// Namespace: Facebook.Unity
internal class GetCurrentGamingContextResult : ResultBase, IGetCurrentGamingContextResult, IResult // TypeDefIndex: 24771
{
	// Fields
	[CompilerGenerated]
	private string <ContextId>k__BackingField; // 0x50

	// Properties
	public string ContextId { get; set; }

	// Methods

	// RVA: 0x41333AC Offset: 0x412F3AC VA: 0x41333AC
	internal void .ctor(ResultContainer resultContainer) { }

	[CompilerGenerated]
	// RVA: 0x413346C Offset: 0x412F46C VA: 0x413346C Slot: 21
	public string get_ContextId() { }

	[CompilerGenerated]
	// RVA: 0x4133474 Offset: 0x412F474 VA: 0x4133474
	private void set_ContextId(string value) { }

	// RVA: 0x413347C Offset: 0x412F47C VA: 0x413347C Slot: 3
	public override string ToString() { }
}

// Namespace: Facebook.Unity.Windows
internal sealed class WindowsFacebook : FacebookBase, IWindowsFacebookImplementation, IWindowsFacebook, IPayFacebook, IFacebook, IFacebookWindows, IFacebookResultHandler // TypeDefIndex: 24772
{
	// Fields
	private string appId; // 0x28
	private IWindowsWrapper windowsWrapper; // 0x30
	[CompilerGenerated]
	private bool <LimitEventUsage>k__BackingField; // 0x38

	// Properties
	public override bool LimitEventUsage { get; set; }
	public override string SDKName { get; }
	public override string SDKVersion { get; }
	public override bool LoggedIn { get; }

	// Methods

	// RVA: 0x4133570 Offset: 0x412F570 VA: 0x4133570
	public void .ctor() { }

	// RVA: 0x4133690 Offset: 0x412F690 VA: 0x4133690
	public void .ctor(IWindowsWrapper windowsWrapper, CallbackManager callbackManager) { }

	[CompilerGenerated]
	// RVA: 0x41336D4 Offset: 0x412F6D4 VA: 0x41336D4 Slot: 55
	public override bool get_LimitEventUsage() { }

	[CompilerGenerated]
	// RVA: 0x41336DC Offset: 0x412F6DC VA: 0x41336DC Slot: 56
	public override void set_LimitEventUsage(bool value) { }

	// RVA: 0x41336E8 Offset: 0x412F6E8 VA: 0x41336E8 Slot: 57
	public override string get_SDKName() { }

	// RVA: 0x4133728 Offset: 0x412F728 VA: 0x4133728 Slot: 58
	public override string get_SDKVersion() { }

	// RVA: 0x411D86C Offset: 0x411986C VA: 0x411D86C
	public void Init(string appId, string clientToken, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete) { }

	// RVA: 0x4133768 Offset: 0x412F768 VA: 0x4133768 Slot: 63
	public override void LogInWithPublishPermissions(IEnumerable<string> scope, FacebookDelegate<ILoginResult> callback) { }

	// RVA: 0x4133858 Offset: 0x412F858 VA: 0x4133858 Slot: 64
	public override void LogInWithReadPermissions(IEnumerable<string> scope, FacebookDelegate<ILoginResult> callback) { }

	// RVA: 0x4133948 Offset: 0x412F948 VA: 0x4133948 Slot: 65
	public override void LogOut() { }

	// RVA: 0x41339EC Offset: 0x412F9EC VA: 0x41339EC Slot: 60
	public override bool get_LoggedIn() { }

	// RVA: 0x4133A90 Offset: 0x412FA90 VA: 0x4133A90 Slot: 69
	public override void ActivateApp(string appId) { }

	// RVA: 0x4133B30 Offset: 0x412FB30 VA: 0x4133B30 Slot: 71
	public override void AppEventsLogEvent(string logEvent, Nullable<float> valueToSum, Dictionary<string, object> parameters) { }

	// RVA: 0x4133E6C Offset: 0x412FE6C VA: 0x4133E6C Slot: 72
	public override void AppEventsLogPurchase(float logPurchase, string currency, Dictionary<string, object> parameters) { }

	// RVA: 0x4133F94 Offset: 0x412FF94 VA: 0x4133F94 Slot: 79
	public override void GetCatalog(FacebookDelegate<ICatalogResult> callback) { }

	// RVA: 0x4134074 Offset: 0x4130074 VA: 0x4134074 Slot: 80
	public override void GetPurchases(FacebookDelegate<IPurchasesResult> callback) { }

	// RVA: 0x4134154 Offset: 0x4130154 VA: 0x4134154 Slot: 81
	public override void Purchase(string productID, FacebookDelegate<IPurchaseResult> callback, string developerPayload = "") { }

	// RVA: 0x413424C Offset: 0x413024C VA: 0x413424C Slot: 82
	public override void ConsumePurchase(string productToken, FacebookDelegate<IConsumePurchaseResult> callback) { }

	// RVA: 0x413433C Offset: 0x413033C VA: 0x413433C Slot: 83
	public override void GetSubscribableCatalog(FacebookDelegate<ISubscribableCatalogResult> callback) { }

	// RVA: 0x4134374 Offset: 0x4130374 VA: 0x4134374 Slot: 84
	public override void GetSubscriptions(FacebookDelegate<ISubscriptionsResult> callback) { }

	// RVA: 0x41343AC Offset: 0x41303AC VA: 0x41343AC Slot: 85
	public override void PurchaseSubscription(string productID, FacebookDelegate<ISubscriptionResult> callback) { }

	// RVA: 0x41343E4 Offset: 0x41303E4 VA: 0x41343E4 Slot: 86
	public override void CancelSubscription(string purchaseToken, FacebookDelegate<ICancelSubscriptionResult> callback) { }

	// RVA: 0x413441C Offset: 0x413041C VA: 0x413441C Slot: 88
	public override void CurrentProfile(FacebookDelegate<IProfileResult> callback) { }

	// RVA: 0x41344FC Offset: 0x41304FC VA: 0x41344FC Slot: 89
	public override void LoadInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback) { }

	// RVA: 0x41345EC Offset: 0x41305EC VA: 0x41345EC Slot: 90
	public override void ShowInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback) { }

	// RVA: 0x41346DC Offset: 0x41306DC VA: 0x41346DC Slot: 91
	public override void LoadRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback) { }

	// RVA: 0x41347CC Offset: 0x41307CC VA: 0x41347CC Slot: 92
	public override void ShowRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback) { }

	// RVA: 0x41348BC Offset: 0x41308BC VA: 0x41348BC Slot: 93
	public override void OpenFriendFinderDialog(FacebookDelegate<IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x413499C Offset: 0x413099C VA: 0x413499C Slot: 94
	public override void GetFriendFinderInvitations(FacebookDelegate<IFriendFinderInvitationResult> callback) { }

	// RVA: 0x4134A7C Offset: 0x4130A7C VA: 0x4134A7C Slot: 95
	public override void DeleteFriendFinderInvitation(string invitationId, FacebookDelegate<IFriendFinderInvitationResult> callback) { }

	// RVA: 0x4134B6C Offset: 0x4130B6C VA: 0x4134B6C Slot: 96
	public override void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, FacebookDelegate<IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x4134C9C Offset: 0x4130C9C VA: 0x4134C9C Slot: 97
	public override void PostSessionScore(int score, FacebookDelegate<ISessionScoreResult> callback) { }

	// RVA: 0x4134D8C Offset: 0x4130D8C VA: 0x4134D8C Slot: 98
	public override void PostTournamentScore(int score, FacebookDelegate<ITournamentScoreResult> callback) { }

	// RVA: 0x4134E7C Offset: 0x4130E7C VA: 0x4134E7C Slot: 99
	public override void GetTournament(FacebookDelegate<ITournamentResult> callback) { }

	// RVA: 0x4134F5C Offset: 0x4130F5C VA: 0x4134F5C Slot: 100
	public override void ShareTournament(int score, Dictionary<string, string> data, FacebookDelegate<ITournamentScoreResult> callback) { }

	// RVA: 0x4135054 Offset: 0x4131054 VA: 0x4135054 Slot: 101
	public override void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, Dictionary<string, string> data, FacebookDelegate<ITournamentResult> callback) { }

	// RVA: 0x4135188 Offset: 0x4131188 VA: 0x4135188 Slot: 47
	public void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, string travelId, FacebookDelegate<IMediaUploadResult> callback) { }

	// RVA: 0x4135298 Offset: 0x4131298 VA: 0x4135298 Slot: 48
	public void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, string travelId, FacebookDelegate<IMediaUploadResult> callback) { }

	// RVA: 0x41353A8 Offset: 0x41313A8 VA: 0x41353A8 Slot: 102
	public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback) { }

	// RVA: 0x41354CC Offset: 0x41314CC VA: 0x41354CC Slot: 103
	public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback) { }

	// RVA: 0x41355F0 Offset: 0x41315F0 VA: 0x41355F0 Slot: 104
	public override void GetUserLocale(FacebookDelegate<ILocaleResult> callback) { }

	// RVA: 0x41335D8 Offset: 0x412F5D8 VA: 0x41335D8
	private static IWindowsWrapper GetWindowsWrapper() { }

	// RVA: 0x41356D0 Offset: 0x41316D0 VA: 0x41356D0 Slot: 105
	public void Tick() { }

	// RVA: 0x4135774 Offset: 0x4131774 VA: 0x4135774 Slot: 106
	public void Deinit() { }

	// RVA: 0x4135818 Offset: 0x4131818 VA: 0x4135818 Slot: 107
	public void SetVirtualGamepadLayout(string layout, FacebookDelegate<IVirtualGamepadLayoutResult> callback) { }

	// RVA: 0x4135908 Offset: 0x4131908 VA: 0x4135908 Slot: 108
	public void SetSoftKeyboardOpen(bool open, FacebookDelegate<ISoftKeyboardOpenResult> callback) { }

	// RVA: 0x41359F8 Offset: 0x41319F8 VA: 0x41359F8 Slot: 109
	public void CreateReferral(string payload, FacebookDelegate<IReferralsCreateResult> callback) { }

	// RVA: 0x4135AE8 Offset: 0x4131AE8 VA: 0x4135AE8 Slot: 110
	public void GetDataReferral(FacebookDelegate<IReferralsGetDataResult> callback) { }

	// RVA: 0x4135BC8 Offset: 0x4131BC8 VA: 0x4135BC8 Slot: 66
	public override void AppRequest(string message, Nullable<OGActionType> actionType, string objectId, IEnumerable<string> to, IEnumerable<object> filters, IEnumerable<string> excludeIds, Nullable<int> maxRecipients, string data, string title, FacebookDelegate<IAppRequestResult> callback) { }

	// RVA: 0x4135C00 Offset: 0x4131C00 VA: 0x4135C00 Slot: 76
	public override void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: 0x4135C38 Offset: 0x4131C38 VA: 0x4135C38 Slot: 74
	public override void OnLoginComplete(ResultContainer resultContainer) { }

	// RVA: 0x4135C70 Offset: 0x4131C70 VA: 0x4135C70 Slot: 68
	public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, FacebookDelegate<IShareResult> callback) { }

	// RVA: 0x4135CA8 Offset: 0x4131CA8 VA: 0x4135CA8 Slot: 67
	public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, FacebookDelegate<IShareResult> callback) { }

	// RVA: 0x4135CE0 Offset: 0x4131CE0 VA: 0x4135CE0 Slot: 70
	public override void GetAppLink(FacebookDelegate<IAppLinkResult> callback) { }

	// RVA: 0x4135D18 Offset: 0x4131D18 VA: 0x4135D18 Slot: 77
	public override void OnShareLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x4135D50 Offset: 0x4131D50 VA: 0x4135D50 Slot: 75
	public override void OnGetAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x4135D88 Offset: 0x4131D88 VA: 0x4135D88 Slot: 111
	public void Pay(string product, string action, int quantity, Nullable<int> quantityMin, Nullable<int> quantityMax, string requestId, string pricepointId, string testCurrency, FacebookDelegate<IPayResult> callback) { }

	// RVA: 0x4135DC0 Offset: 0x4131DC0 VA: 0x4135DC0 Slot: 87
	public override Profile CurrentProfile() { }
}

// Namespace: Facebook.Unity.Windows
internal interface IWindowsFacebookImplementation : IWindowsFacebook, IPayFacebook, IFacebook, IFacebookWindows, IFacebookResultHandler // TypeDefIndex: 24773
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Tick();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Deinit();
}

// Namespace: Facebook.Unity.Windows
internal interface IWindowsFacebook : IPayFacebook, IFacebook, IFacebookWindows // TypeDefIndex: 24774
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetVirtualGamepadLayout(string layout, FacebookDelegate<IVirtualGamepadLayoutResult> callback);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetSoftKeyboardOpen(bool open, FacebookDelegate<ISoftKeyboardOpenResult> callback);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void CreateReferral(string payload, FacebookDelegate<IReferralsCreateResult> callback);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void GetDataReferral(FacebookDelegate<IReferralsGetDataResult> callback);
}

// Namespace: Facebook.Unity.Windows
internal interface IWindowsWrapper // TypeDefIndex: 24775
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Init(string appId, string clientToken);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void LogInWithScopes(IEnumerable<string> scope, string callbackId, CallbackManager callbackManager);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsLoggedIn();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void LogOut();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Tick();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Deinit();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void GetCatalog(string callbackId, CallbackManager callbackManager);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void GetPurchases(string callbackId, CallbackManager callbackManager);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Purchase(string productID, string developerPayload, string callbackId, CallbackManager callbackManager);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void ConsumePurchase(string productToken, string callbackId, CallbackManager callbackManager);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void CurrentProfile(string callbackId, CallbackManager callbackManager);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void LoadInterstitialAd(string placementID, string callbackId, CallbackManager callbackManager);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void ShowInterstitialAd(string placementID, string callbackId, CallbackManager callbackManager);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void LoadRewardedVideo(string placementID, string callbackId, CallbackManager callbackManager);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void ShowRewardedVideo(string placementID, string callbackId, CallbackManager callbackManager);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void OpenFriendFinderDialog(string callbackId, CallbackManager callbackManager);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void GetFriendFinderInvitations(string callbackId, CallbackManager callbackManager);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void DeleteFriendFinderInvitation(string invitationId, string callbackId, CallbackManager callbackManager);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, string callbackId, CallbackManager callbackManager);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void PostSessionScore(int score, string callbackId, CallbackManager callbackManager);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void PostTournamentScore(int score, string callbackId, CallbackManager callbackManager);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void GetTournament(string callbackId, CallbackManager callbackManager);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void ShareTournament(int score, Dictionary<string, string> data, string callbackId, CallbackManager callbackManager);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, Dictionary<string, string> data, string callbackId, CallbackManager callbackManager);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, string callbackId, string travelId, CallbackManager callbackManager);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, string callbackId, string travelId, CallbackManager callbackManager);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract void SetVirtualGamepadLayout(string layout, string callbackId, CallbackManager callbackManager);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void GetUserLocale(string callbackId, CallbackManager callbackManager);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void SetSoftKeyboardOpen(bool open, string callbackId, CallbackManager callbackManager);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void CreateReferral(string payload, string callbackId, CallbackManager callbackManager);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void GetDataReferral(string callbackId, CallbackManager callbackManager);
}

// Namespace: Facebook.Unity.Windows
internal class WindowsFacebookLoader : FB.CompiledFacebookLoader // TypeDefIndex: 24776
{
	// Properties
	protected override FacebookGameObject FBGameObject { get; }

	// Methods

	// RVA: 0x4135DF8 Offset: 0x4131DF8 VA: 0x4135DF8 Slot: 4
	protected override FacebookGameObject get_FBGameObject() { }

	// RVA: 0x4135E90 Offset: 0x4131E90 VA: 0x4135E90
	public void .ctor() { }
}

// Namespace: Facebook.Unity.Windows
internal class WindowsFacebookGameObject : FacebookGameObject, IFacebookCallbackHandler // TypeDefIndex: 24777
{
	// Properties
	protected IWindowsFacebookImplementation WindowsFacebookImpl { get; }

	// Methods

	// RVA: 0x4135E98 Offset: 0x4131E98 VA: 0x4135E98
	protected IWindowsFacebookImplementation get_WindowsFacebookImpl() { }

	// RVA: 0x4135F04 Offset: 0x4131F04 VA: 0x4135F04 Slot: 10
	protected override void OnAwake() { }

	// RVA: 0x4135F08 Offset: 0x4131F08 VA: 0x4135F08
	public void Update() { }

	// RVA: 0x4135FB0 Offset: 0x4131FB0 VA: 0x4135FB0
	public void OnDestroy() { }

	// RVA: 0x413605C Offset: 0x413205C VA: 0x413605C
	public void .ctor() { }
}

// Namespace: Facebook.Unity.Editor
internal class EditorFacebook : FacebookBase, IMobileFacebookImplementation, IMobileFacebook, IFacebook, IFacebookWindows, IMobileFacebookResultHandler, IFacebookResultHandler, ICanvasFacebookImplementation, IPayFacebook, ICanvasFacebookResultHandler // TypeDefIndex: 24778
{
	// Fields
	private IEditorWrapper editorWrapper; // 0x28
	[CompilerGenerated]
	private bool <LimitEventUsage>k__BackingField; // 0x30
	[CompilerGenerated]
	private ShareDialogMode <ShareDialogMode>k__BackingField; // 0x34

	// Properties
	public override bool LimitEventUsage { get; set; }
	public ShareDialogMode ShareDialogMode { set; }
	public override string SDKName { get; }
	public override string SDKVersion { get; }
	private static IFacebookCallbackHandler EditorGameObject { get; }

	// Methods

	// RVA: 0x4136064 Offset: 0x4132064 VA: 0x4136064
	public void .ctor(IEditorWrapper wrapper, CallbackManager callbackManager) { }

	// RVA: 0x41360A8 Offset: 0x41320A8 VA: 0x41360A8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x4136188 Offset: 0x4132188 VA: 0x4136188 Slot: 55
	public override bool get_LimitEventUsage() { }

	[CompilerGenerated]
	// RVA: 0x4136190 Offset: 0x4132190 VA: 0x4136190 Slot: 56
	public override void set_LimitEventUsage(bool value) { }

	[CompilerGenerated]
	// RVA: 0x413619C Offset: 0x413219C VA: 0x413619C Slot: 105
	public void set_ShareDialogMode(ShareDialogMode value) { }

	// RVA: 0x41361A4 Offset: 0x41321A4 VA: 0x41361A4 Slot: 57
	public override string get_SDKName() { }

	// RVA: 0x41361E4 Offset: 0x41321E4 VA: 0x41361E4 Slot: 58
	public override string get_SDKVersion() { }

	// RVA: 0x4136144 Offset: 0x4132144 VA: 0x4136144
	private static IFacebookCallbackHandler get_EditorGameObject() { }

	// RVA: 0x4136224 Offset: 0x4132224 VA: 0x4136224 Slot: 62
	public override void Init(InitDelegate onInitComplete) { }

	// RVA: 0x4136320 Offset: 0x4132320 VA: 0x4136320 Slot: 64
	public override void LogInWithReadPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback) { }

	// RVA: 0x4136330 Offset: 0x4132330 VA: 0x4136330 Slot: 63
	public override void LogInWithPublishPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback) { }

	// RVA: 0x413645C Offset: 0x413245C VA: 0x413645C Slot: 106
	public void LoginWithTrackingPreference(string tracking, IEnumerable<string> permissions, string nonce, FacebookDelegate<ILoginResult> callback) { }

	// RVA: 0x4136588 Offset: 0x4132588 VA: 0x4136588 Slot: 66
	public override void AppRequest(string message, Nullable<OGActionType> actionType, string objectId, IEnumerable<string> to, IEnumerable<object> filters, IEnumerable<string> excludeIds, Nullable<int> maxRecipients, string data, string title, FacebookDelegate<IAppRequestResult> callback) { }

	// RVA: 0x41366A0 Offset: 0x41326A0 VA: 0x41366A0 Slot: 67
	public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, FacebookDelegate<IShareResult> callback) { }

	// RVA: 0x41367D4 Offset: 0x41327D4 VA: 0x41367D4 Slot: 68
	public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, FacebookDelegate<IShareResult> callback) { }

	// RVA: 0x4136908 Offset: 0x4132908 VA: 0x4136908 Slot: 69
	public override void ActivateApp(string appId) { }

	// RVA: 0x413696C Offset: 0x413296C VA: 0x413696C Slot: 70
	public override void GetAppLink(FacebookDelegate<IAppLinkResult> callback) { }

	// RVA: 0x4136ACC Offset: 0x4132ACC VA: 0x4136ACC Slot: 71
	public override void AppEventsLogEvent(string logEvent, Nullable<float> valueToSum, Dictionary<string, object> parameters) { }

	// RVA: 0x4136B30 Offset: 0x4132B30 VA: 0x4136B30 Slot: 72
	public override void AppEventsLogPurchase(float logPurchase, string currency, Dictionary<string, object> parameters) { }

	// RVA: 0x4136B94 Offset: 0x4132B94 VA: 0x4136B94 Slot: 109
	public bool IsImplicitPurchaseLoggingEnabled() { }

	// RVA: 0x4136B9C Offset: 0x4132B9C VA: 0x4136B9C Slot: 87
	public override Profile CurrentProfile() { }

	// RVA: 0x4136BA4 Offset: 0x4132BA4 VA: 0x4136BA4 Slot: 88
	public override void CurrentProfile(FacebookDelegate<IProfileResult> callback) { }

	// RVA: 0x4136BDC Offset: 0x4132BDC VA: 0x4136BDC Slot: 107
	public void FetchDeferredAppLink(FacebookDelegate<IAppLinkResult> callback) { }

	// RVA: 0x4136EB0 Offset: 0x4132EB0 VA: 0x4136EB0 Slot: 160
	public void Pay(string product, string action, int quantity, Nullable<int> quantityMin, Nullable<int> quantityMax, string requestId, string pricepointId, string testCurrency, FacebookDelegate<IPayResult> callback) { }

	// RVA: 0x4136FC8 Offset: 0x4132FC8 VA: 0x4136FC8 Slot: 108
	public void RefreshCurrentAccessToken(FacebookDelegate<IAccessTokenRefreshResult> callback) { }

	// RVA: 0x413728C Offset: 0x413328C VA: 0x413728C Slot: 76
	public override void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: 0x41372FC Offset: 0x41332FC VA: 0x41372FC Slot: 75
	public override void OnGetAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x413736C Offset: 0x413336C VA: 0x413736C Slot: 74
	public override void OnLoginComplete(ResultContainer resultContainer) { }

	// RVA: 0x41373E0 Offset: 0x41333E0 VA: 0x41373E0 Slot: 77
	public override void OnShareLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x4136E40 Offset: 0x4132E40 VA: 0x4136E40 Slot: 123
	public void OnFetchDeferredAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x4137450 Offset: 0x4133450 VA: 0x4137450 Slot: 161
	public void OnPayComplete(ResultContainer resultContainer) { }

	// RVA: 0x413721C Offset: 0x413321C VA: 0x413721C Slot: 124
	public void OnRefreshCurrentAccessTokenComplete(ResultContainer resultContainer) { }

	// RVA: 0x41374C0 Offset: 0x41334C0 VA: 0x41374C0 Slot: 125
	public void OnFriendFinderComplete(ResultContainer resultContainer) { }

	// RVA: 0x4137530 Offset: 0x4133530 VA: 0x4137530 Slot: 126
	public void OnUploadImageToMediaLibraryComplete(ResultContainer resultContainer) { }

	// RVA: 0x41375A0 Offset: 0x41335A0 VA: 0x41375A0 Slot: 127
	public void OnUploadVideoToMediaLibraryComplete(ResultContainer resultContainer) { }

	// RVA: 0x4137610 Offset: 0x4133610 VA: 0x4137610 Slot: 128
	public void OnOnIAPReadyComplete(ResultContainer resultContainer) { }

	// RVA: 0x4137680 Offset: 0x4133680 VA: 0x4137680 Slot: 129
	public void OnGetCatalogComplete(ResultContainer resultContainer) { }

	// RVA: 0x41376F0 Offset: 0x41336F0 VA: 0x41376F0 Slot: 130
	public void OnGetPurchasesComplete(ResultContainer resultContainer) { }

	// RVA: 0x4137760 Offset: 0x4133760 VA: 0x4137760 Slot: 131
	public void OnPurchaseComplete(ResultContainer resultContainer) { }

	// RVA: 0x41377D0 Offset: 0x41337D0 VA: 0x41377D0 Slot: 132
	public void OnConsumePurchaseComplete(ResultContainer resultContainer) { }

	// RVA: 0x4137840 Offset: 0x4133840 VA: 0x4137840 Slot: 133
	public void OnGetSubscribableCatalogComplete(ResultContainer resultContainer) { }

	// RVA: 0x41378B0 Offset: 0x41338B0 VA: 0x41378B0 Slot: 134
	public void OnGetSubscriptionsComplete(ResultContainer resultContainer) { }

	// RVA: 0x4137920 Offset: 0x4133920 VA: 0x4137920 Slot: 135
	public void OnPurchaseSubscriptionComplete(ResultContainer resultContainer) { }

	// RVA: 0x4137990 Offset: 0x4133990 VA: 0x4137990 Slot: 136
	public void OnCancelSubscriptionComplete(ResultContainer resultContainer) { }

	// RVA: 0x4137A00 Offset: 0x4133A00 VA: 0x4137A00 Slot: 137
	public void OnInitCloudGameComplete(ResultContainer resultContainer) { }

	// RVA: 0x4137A70 Offset: 0x4133A70 VA: 0x4137A70 Slot: 138
	public void OnGameLoadCompleteComplete(ResultContainer resultContainer) { }

	// RVA: 0x4137AE0 Offset: 0x4133AE0 VA: 0x4137AE0 Slot: 139
	public void OnScheduleAppToUserNotificationComplete(ResultContainer resultContainer) { }

	// RVA: 0x4137B50 Offset: 0x4133B50 VA: 0x4137B50 Slot: 140
	public void OnLoadInterstitialAdComplete(ResultContainer resultContainer) { }

	// RVA: 0x4137BC0 Offset: 0x4133BC0 VA: 0x4137BC0 Slot: 141
	public void OnShowInterstitialAdComplete(ResultContainer resultContainer) { }

	// RVA: 0x4137C30 Offset: 0x4133C30 VA: 0x4137C30 Slot: 142
	public void OnLoadRewardedVideoComplete(ResultContainer resultContainer) { }

	// RVA: 0x4137CA0 Offset: 0x4133CA0 VA: 0x4137CA0 Slot: 143
	public void OnShowRewardedVideoComplete(ResultContainer resultContainer) { }

	// RVA: 0x4137D10 Offset: 0x4133D10 VA: 0x4137D10 Slot: 144
	public void OnGetPayloadComplete(ResultContainer resultContainer) { }

	// RVA: 0x4137D80 Offset: 0x4133D80 VA: 0x4137D80 Slot: 145
	public void OnPostSessionScoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x4137DF0 Offset: 0x4133DF0 VA: 0x4137DF0 Slot: 149
	public void OnPostTournamentScoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x4137E60 Offset: 0x4133E60 VA: 0x4137E60 Slot: 146
	public void OnGetTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x4137ED0 Offset: 0x4133ED0 VA: 0x4137ED0 Slot: 147
	public void OnShareTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x4137F40 Offset: 0x4133F40 VA: 0x4137F40 Slot: 148
	public void OnCreateTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x4137FB0 Offset: 0x4133FB0 VA: 0x4137FB0 Slot: 150
	public void OnGetTournamentsComplete(ResultContainer resultContainer) { }

	// RVA: 0x4138020 Offset: 0x4134020 VA: 0x4138020 Slot: 151
	public void OnUpdateTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x4138090 Offset: 0x4134090 VA: 0x4138090 Slot: 152
	public void OnTournamentDialogSuccess(ResultContainer resultContainer) { }

	// RVA: 0x4138100 Offset: 0x4134100 VA: 0x4138100 Slot: 153
	public void OnTournamentDialogCancel(ResultContainer resultContainer) { }

	// RVA: 0x4138174 Offset: 0x4134174 VA: 0x4138174 Slot: 154
	public void OnTournamentDialogError(ResultContainer resultContainer) { }

	// RVA: 0x41381E8 Offset: 0x41341E8 VA: 0x41381E8 Slot: 155
	public void OnOpenAppStoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x4138258 Offset: 0x4134258 VA: 0x4138258 Slot: 156
	public void OnCreateGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x41382C8 Offset: 0x41342C8 VA: 0x41382C8 Slot: 157
	public void OnSwitchGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x4138338 Offset: 0x4134338 VA: 0x4138338 Slot: 158
	public void OnChooseGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x41383A8 Offset: 0x41343A8 VA: 0x41383A8 Slot: 159
	public void OnGetCurrentGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x4138418 Offset: 0x4134418 VA: 0x4138418 Slot: 93
	public override void OpenFriendFinderDialog(FacebookDelegate<IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x413854C Offset: 0x413454C VA: 0x413854C Slot: 94
	public override void GetFriendFinderInvitations(FacebookDelegate<IFriendFinderInvitationResult> callback) { }

	// RVA: 0x4138584 Offset: 0x4134584 VA: 0x4138584 Slot: 95
	public override void DeleteFriendFinderInvitation(string invitationId, FacebookDelegate<IFriendFinderInvitationResult> callback) { }

	// RVA: 0x41385BC Offset: 0x41345BC VA: 0x41385BC Slot: 102
	public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback) { }

	// RVA: 0x4138710 Offset: 0x4134710 VA: 0x4138710 Slot: 103
	public override void UploadVideoToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback) { }

	// RVA: 0x4138864 Offset: 0x4134864 VA: 0x4138864 Slot: 104
	public override void GetUserLocale(FacebookDelegate<ILocaleResult> callback) { }

	// RVA: 0x413889C Offset: 0x413489C VA: 0x413889C Slot: 110
	public void OnIAPReady(FacebookDelegate<IIAPReadyResult> callback) { }

	// RVA: 0x41389B4 Offset: 0x41349B4 VA: 0x41389B4 Slot: 79
	public override void GetCatalog(FacebookDelegate<ICatalogResult> callback) { }

	// RVA: 0x4138ACC Offset: 0x4134ACC VA: 0x4138ACC Slot: 80
	public override void GetPurchases(FacebookDelegate<IPurchasesResult> callback) { }

	// RVA: 0x4138BE4 Offset: 0x4134BE4 VA: 0x4138BE4 Slot: 81
	public override void Purchase(string productID, FacebookDelegate<IPurchaseResult> callback, string developerPayload = "") { }

	// RVA: 0x4138CFC Offset: 0x4134CFC VA: 0x4138CFC Slot: 82
	public override void ConsumePurchase(string purchaseToken, FacebookDelegate<IConsumePurchaseResult> callback) { }

	// RVA: 0x4138E14 Offset: 0x4134E14 VA: 0x4138E14 Slot: 83
	public override void GetSubscribableCatalog(FacebookDelegate<ISubscribableCatalogResult> callback) { }

	// RVA: 0x4138F2C Offset: 0x4134F2C VA: 0x4138F2C Slot: 84
	public override void GetSubscriptions(FacebookDelegate<ISubscriptionsResult> callback) { }

	// RVA: 0x4139044 Offset: 0x4135044 VA: 0x4139044 Slot: 85
	public override void PurchaseSubscription(string productID, FacebookDelegate<ISubscriptionResult> callback) { }

	// RVA: 0x413915C Offset: 0x413515C VA: 0x413915C Slot: 86
	public override void CancelSubscription(string purchaseToken, FacebookDelegate<ICancelSubscriptionResult> callback) { }

	// RVA: 0x4139274 Offset: 0x4135274 VA: 0x4139274 Slot: 111
	public void InitCloudGame(FacebookDelegate<IInitCloudGameResult> callback) { }

	// RVA: 0x413938C Offset: 0x413538C VA: 0x413938C Slot: 112
	public void GameLoadComplete(FacebookDelegate<IGameLoadCompleteResult> callback) { }

	// RVA: 0x41394A4 Offset: 0x41354A4 VA: 0x41394A4 Slot: 96
	public override void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, FacebookDelegate<IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x41395BC Offset: 0x41355BC VA: 0x41395BC Slot: 89
	public override void LoadInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback) { }

	// RVA: 0x41396D4 Offset: 0x41356D4 VA: 0x41396D4 Slot: 90
	public override void ShowInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback) { }

	// RVA: 0x41397EC Offset: 0x41357EC VA: 0x41397EC Slot: 91
	public override void LoadRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback) { }

	// RVA: 0x4139904 Offset: 0x4135904 VA: 0x4139904 Slot: 92
	public override void ShowRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback) { }

	// RVA: 0x4139A1C Offset: 0x4135A1C VA: 0x4139A1C Slot: 113
	public void GetPayload(FacebookDelegate<IPayloadResult> callback) { }

	// RVA: 0x4139B34 Offset: 0x4135B34 VA: 0x4139B34 Slot: 97
	public override void PostSessionScore(int score, FacebookDelegate<ISessionScoreResult> callback) { }

	// RVA: 0x4139C4C Offset: 0x4135C4C VA: 0x4139C4C Slot: 98
	public override void PostTournamentScore(int score, FacebookDelegate<ITournamentScoreResult> callback) { }

	// RVA: 0x4139D64 Offset: 0x4135D64 VA: 0x4139D64 Slot: 99
	public override void GetTournament(FacebookDelegate<ITournamentResult> callback) { }

	// RVA: 0x4139F5C Offset: 0x4135F5C VA: 0x4139F5C Slot: 100
	public override void ShareTournament(int score, Dictionary<string, string> data, FacebookDelegate<ITournamentScoreResult> callback) { }

	// RVA: 0x413A074 Offset: 0x4136074 VA: 0x413A074 Slot: 101
	public override void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, Dictionary<string, string> data, FacebookDelegate<ITournamentResult> callback) { }

	// RVA: 0x413A26C Offset: 0x413626C VA: 0x413A26C Slot: 114
	public void GetTournaments(FacebookDelegate<IGetTournamentsResult> callback) { }

	// RVA: 0x413A2A4 Offset: 0x41362A4 VA: 0x413A2A4 Slot: 115
	public void UpdateTournament(string tournamentID, int score, FacebookDelegate<ITournamentScoreResult> callback) { }

	// RVA: 0x413A2DC Offset: 0x41362DC VA: 0x413A2DC Slot: 116
	public void UpdateAndShareTournament(string tournamentID, int score, FacebookDelegate<IDialogResult> callback) { }

	// RVA: 0x413A314 Offset: 0x4136314 VA: 0x413A314 Slot: 117
	public void CreateAndShareTournament(int initialScore, string title, TournamentSortOrder sortOrder, TournamentScoreFormat scoreFormat, long endTime, string payload, FacebookDelegate<IDialogResult> callback) { }

	// RVA: 0x413A34C Offset: 0x413634C VA: 0x413A34C Slot: 118
	public void OpenAppStore(FacebookDelegate<IOpenAppStoreResult> callback) { }

	// RVA: 0x413A464 Offset: 0x4136464 VA: 0x413A464 Slot: 119
	public void CreateGamingContext(string playerID, FacebookDelegate<ICreateGamingContextResult> callback) { }

	// RVA: 0x413A57C Offset: 0x413657C VA: 0x413A57C Slot: 120
	public void SwitchGamingContext(string gamingContextID, FacebookDelegate<ISwitchGamingContextResult> callback) { }

	// RVA: 0x413A694 Offset: 0x4136694 VA: 0x413A694 Slot: 121
	public void ChooseGamingContext(List<string> filters, int minSize, int maxSize, FacebookDelegate<IChooseGamingContextResult> callback) { }

	// RVA: 0x413A7AC Offset: 0x41367AC VA: 0x413A7AC Slot: 122
	public void GetCurrentGamingContext(FacebookDelegate<IGetCurrentGamingContextResult> callback) { }

	// RVA: 0x413A8C4 Offset: 0x41368C4 VA: 0x413A8C4 Slot: 162
	public void OnFacebookAuthResponseChange(ResultContainer resultContainer) { }

	// RVA: 0x413A8FC Offset: 0x41368FC VA: 0x413A8FC Slot: 163
	public void OnUrlResponse(string message) { }

	// RVA: 0x413A934 Offset: 0x4136934 VA: 0x413A934 Slot: 164
	public void OnHideUnity(bool hidden) { }
}

// Namespace: Facebook.Unity.Editor
internal class EditorFacebookGameObject : FacebookGameObject // TypeDefIndex: 24779
{
	// Methods

	// RVA: 0x413C5C4 Offset: 0x41385C4 VA: 0x413C5C4 Slot: 10
	protected override void OnAwake() { }

	// RVA: 0x413C5CC Offset: 0x41385CC VA: 0x413C5CC
	private void OnEnable() { }

	// RVA: 0x413C670 Offset: 0x4138670 VA: 0x413C670
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x413C678 Offset: 0x4138678 VA: 0x413C678
	private void OnDisable() { }

	// RVA: 0x413C71C Offset: 0x413871C VA: 0x413C71C
	public void onPurchaseCompleteHandler(object data) { }

	// RVA: 0x413C728 Offset: 0x4138728 VA: 0x413C728
	public void .ctor() { }
}

// Namespace: Facebook.Unity.Editor
internal class EditorFacebookLoader : FB.CompiledFacebookLoader // TypeDefIndex: 24780
{
	// Properties
	protected override FacebookGameObject FBGameObject { get; }

	// Methods

	// RVA: 0x413C730 Offset: 0x4138730 VA: 0x413C730 Slot: 4
	protected override FacebookGameObject get_FBGameObject() { }

	// RVA: 0x413C7C4 Offset: 0x41387C4 VA: 0x413C7C4
	public void .ctor() { }
}

// Namespace: Facebook.Unity.Editor
internal abstract class EditorFacebookMockDialog : MonoBehaviour // TypeDefIndex: 24781
{
	// Fields
	private Rect modalRect; // 0x20
	private GUIStyle modalStyle; // 0x30
	[CompilerGenerated]
	private Utilities.Callback<ResultContainer> <Callback>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <CallbackID>k__BackingField; // 0x40

	// Properties
	protected Utilities.Callback<ResultContainer> Callback { get; set; }
	protected string CallbackID { get; set; }
	protected abstract string DialogTitle { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x413C7CC Offset: 0x41387CC VA: 0x413C7CC
	protected Utilities.Callback<ResultContainer> get_Callback() { }

	[CompilerGenerated]
	// RVA: 0x413C7D4 Offset: 0x41387D4 VA: 0x413C7D4
	public void set_Callback(Utilities.Callback<ResultContainer> value) { }

	[CompilerGenerated]
	// RVA: 0x413C7DC Offset: 0x41387DC VA: 0x413C7DC
	protected string get_CallbackID() { }

	[CompilerGenerated]
	// RVA: 0x413C7E4 Offset: 0x41387E4 VA: 0x413C7E4
	public void set_CallbackID(string value) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract string get_DialogTitle();

	// RVA: 0x413C7EC Offset: 0x41387EC VA: 0x413C7EC
	public void Start() { }

	// RVA: 0x413C908 Offset: 0x4138908 VA: 0x413C908
	public void OnGUI() { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void DoGui();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void SendSuccessResult();

	// RVA: 0x413CA14 Offset: 0x4138A14 VA: 0x413CA14 Slot: 7
	protected virtual void SendCancelResult() { }

	// RVA: 0x413CB8C Offset: 0x4138B8C VA: 0x413CB8C Slot: 8
	protected virtual void SendErrorResult(string errorMessage) { }

	// RVA: 0x413CCD4 Offset: 0x4138CD4 VA: 0x413CCD4
	private void OnGUIDialog(int windowId) { }

	// RVA: 0x413D104 Offset: 0x4139104 VA: 0x413D104
	protected void .ctor() { }
}

// Namespace: Facebook.Unity.Editor
internal class EditorWrapper : IEditorWrapper // TypeDefIndex: 24782
{
	// Fields
	private IFacebookCallbackHandler callbackHandler; // 0x10

	// Methods

	// RVA: 0x413D10C Offset: 0x413910C VA: 0x413D10C
	public void .ctor(IFacebookCallbackHandler callbackHandler) { }

	// RVA: 0x413D13C Offset: 0x413913C VA: 0x413D13C Slot: 4
	public void Init() { }

	// RVA: 0x413D200 Offset: 0x4139200 VA: 0x413D200 Slot: 5
	public void ShowLoginMockDialog(Utilities.Callback<ResultContainer> callback, string callbackId, string permsisions) { }

	// RVA: 0x413D27C Offset: 0x413927C VA: 0x413D27C Slot: 6
	public void ShowAppRequestMockDialog(Utilities.Callback<ResultContainer> callback, string callbackId) { }

	// RVA: 0x413D364 Offset: 0x4139364 VA: 0x413D364 Slot: 7
	public void ShowPayMockDialog(Utilities.Callback<ResultContainer> callback, string callbackId) { }

	// RVA: 0x413D3BC Offset: 0x41393BC VA: 0x413D3BC Slot: 8
	public void ShowMockShareDialog(Utilities.Callback<ResultContainer> callback, string subTitle, string callbackId) { }

	// RVA: 0x413D44C Offset: 0x413944C VA: 0x413D44C Slot: 9
	public void ShowMockFriendFinderDialog(Utilities.Callback<ResultContainer> callback, string subTitle, string callbackId) { }

	// RVA: 0x413D2D4 Offset: 0x41392D4 VA: 0x413D2D4
	private void ShowEmptyMockDialog(Utilities.Callback<ResultContainer> callback, string callbackId, string title) { }
}

// Namespace: Facebook.Unity.Editor
internal interface IEditorWrapper // TypeDefIndex: 24783
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Init();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ShowLoginMockDialog(Utilities.Callback<ResultContainer> callback, string callbackId, string permissions);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void ShowAppRequestMockDialog(Utilities.Callback<ResultContainer> callback, string callbackId);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void ShowPayMockDialog(Utilities.Callback<ResultContainer> callback, string callbackId);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void ShowMockShareDialog(Utilities.Callback<ResultContainer> callback, string subTitle, string callbackId);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void ShowMockFriendFinderDialog(Utilities.Callback<ResultContainer> callback, string subTitle, string callbackId);
}

// Namespace: Facebook.Unity.Editor.Dialogs
internal class EmptyMockDialog : EditorFacebookMockDialog // TypeDefIndex: 24784
{
	// Fields
	[CompilerGenerated]
	private string <EmptyDialogTitle>k__BackingField; // 0x48

	// Properties
	public string EmptyDialogTitle { get; set; }
	protected override string DialogTitle { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x413D45C Offset: 0x413945C VA: 0x413D45C
	public string get_EmptyDialogTitle() { }

	[CompilerGenerated]
	// RVA: 0x413D464 Offset: 0x4139464 VA: 0x413D464
	public void set_EmptyDialogTitle(string value) { }

	// RVA: 0x413D46C Offset: 0x413946C VA: 0x413D46C Slot: 4
	protected override string get_DialogTitle() { }

	// RVA: 0x413D474 Offset: 0x4139474 VA: 0x413D474 Slot: 5
	protected override void DoGui() { }

	// RVA: 0x413D478 Offset: 0x4139478 VA: 0x413D478 Slot: 6
	protected override void SendSuccessResult() { }

	// RVA: 0x413D5DC Offset: 0x41395DC VA: 0x413D5DC
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MockLoginDialog.<>c__DisplayClass4_0 // TypeDefIndex: 24785
{
	// Fields
	public MockLoginDialog <>4__this; // 0x10
	public string graphDomain; // 0x18

	// Methods

	// RVA: 0x413DC08 Offset: 0x4139C08 VA: 0x413DC08
	public void .ctor() { }

	// RVA: 0x413DC70 Offset: 0x4139C70 VA: 0x413DC70
	internal void <SendSuccessResult>b__0(IGraphResult graphResult) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MockLoginDialog.<>c__DisplayClass4_1 // TypeDefIndex: 24786
{
	// Fields
	public string facebookID; // 0x10
	public MockLoginDialog.<>c__DisplayClass4_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x413DFDC Offset: 0x4139FDC VA: 0x413DFDC
	public void .ctor() { }

	// RVA: 0x413DFE4 Offset: 0x4139FE4 VA: 0x413DFE4
	internal void <SendSuccessResult>b__1(IGraphResult permResult) { }
}

// Namespace: Facebook.Unity.Editor.Dialogs
internal class MockLoginDialog : EditorFacebookMockDialog // TypeDefIndex: 24787
{
	// Fields
	private string accessToken; // 0x48

	// Properties
	protected override string DialogTitle { get; }

	// Methods

	// RVA: 0x413D5E4 Offset: 0x41395E4 VA: 0x413D5E4 Slot: 4
	protected override string get_DialogTitle() { }

	// RVA: 0x413D624 Offset: 0x4139624 VA: 0x413D624 Slot: 5
	protected override void DoGui() { }

	// RVA: 0x413D874 Offset: 0x4139874 VA: 0x413D874 Slot: 6
	protected override void SendSuccessResult() { }

	// RVA: 0x413DC10 Offset: 0x4139C10 VA: 0x413DC10
	public void .ctor() { }
}

// Namespace: Facebook.Unity.Editor.Dialogs
internal class MockShareDialog : EditorFacebookMockDialog // TypeDefIndex: 24788
{
	// Fields
	[CompilerGenerated]
	private string <SubTitle>k__BackingField; // 0x48

	// Properties
	private string SubTitle { get; set; }
	protected override string DialogTitle { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x413E990 Offset: 0x413A990 VA: 0x413E990
	private string get_SubTitle() { }

	[CompilerGenerated]
	// RVA: 0x413E998 Offset: 0x413A998 VA: 0x413E998
	public void set_SubTitle(string value) { }

	// RVA: 0x413E9A0 Offset: 0x413A9A0 VA: 0x413E9A0 Slot: 4
	protected override string get_DialogTitle() { }

	// RVA: 0x413EA0C Offset: 0x413AA0C VA: 0x413EA0C Slot: 5
	protected override void DoGui() { }

	// RVA: 0x413EA10 Offset: 0x413AA10 VA: 0x413EA10 Slot: 6
	protected override void SendSuccessResult() { }

	// RVA: 0x413ECB4 Offset: 0x413ACB4 VA: 0x413ECB4 Slot: 7
	protected override void SendCancelResult() { }

	// RVA: 0x413EBCC Offset: 0x413ABCC VA: 0x413EBCC
	private string GenerateFakePostID() { }

	// RVA: 0x413EDF8 Offset: 0x413ADF8 VA: 0x413EDF8
	public void .ctor() { }
}

// Namespace: Facebook.Unity.Mobile
internal interface IMobileFacebook : IFacebook, IFacebookWindows // TypeDefIndex: 24789
{
	// Properties
	public abstract ShareDialogMode ShareDialogMode { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void set_ShareDialogMode(ShareDialogMode value);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void LoginWithTrackingPreference(string tracking, IEnumerable<string> permissions, string nonce, FacebookDelegate<ILoginResult> callback);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void FetchDeferredAppLink(FacebookDelegate<IAppLinkResult> callback);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void RefreshCurrentAccessToken(FacebookDelegate<IAccessTokenRefreshResult> callback);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool IsImplicitPurchaseLoggingEnabled();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnIAPReady(FacebookDelegate<IIAPReadyResult> callback);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void InitCloudGame(FacebookDelegate<IInitCloudGameResult> callback);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void GameLoadComplete(FacebookDelegate<IGameLoadCompleteResult> callback);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void GetPayload(FacebookDelegate<IPayloadResult> callback);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void GetTournaments(FacebookDelegate<IGetTournamentsResult> callback);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void UpdateTournament(string tournamentID, int score, FacebookDelegate<ITournamentScoreResult> callback);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void UpdateAndShareTournament(string tournamentID, int score, FacebookDelegate<IDialogResult> callback);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void CreateAndShareTournament(int initialScore, string title, TournamentSortOrder sortOrder, TournamentScoreFormat scoreFormat, long endTime, string payload, FacebookDelegate<IDialogResult> callback);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void OpenAppStore(FacebookDelegate<IOpenAppStoreResult> callback);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void CreateGamingContext(string playerID, FacebookDelegate<ICreateGamingContextResult> callback);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void SwitchGamingContext(string gamingContextID, FacebookDelegate<ISwitchGamingContextResult> callback);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void ChooseGamingContext(List<string> filters, int minSize, int maxSize, FacebookDelegate<IChooseGamingContextResult> callback);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void GetCurrentGamingContext(FacebookDelegate<IGetCurrentGamingContextResult> callback);
}

// Namespace: Facebook.Unity.Mobile
internal interface IMobileFacebookImplementation : IMobileFacebook, IFacebook, IFacebookWindows, IMobileFacebookResultHandler, IFacebookResultHandler // TypeDefIndex: 24790
{}

// Namespace: Facebook.Unity.Mobile
internal interface IMobileFacebookResultHandler : IFacebookResultHandler // TypeDefIndex: 24791
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnFetchDeferredAppLinkComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnRefreshCurrentAccessTokenComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnFriendFinderComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnUploadImageToMediaLibraryComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnUploadVideoToMediaLibraryComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnOnIAPReadyComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnGetCatalogComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void OnGetPurchasesComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void OnPurchaseComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void OnConsumePurchaseComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void OnGetSubscribableCatalogComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void OnGetSubscriptionsComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void OnPurchaseSubscriptionComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void OnCancelSubscriptionComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void OnInitCloudGameComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void OnGameLoadCompleteComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void OnScheduleAppToUserNotificationComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void OnLoadInterstitialAdComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void OnShowInterstitialAdComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void OnLoadRewardedVideoComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void OnShowRewardedVideoComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void OnGetPayloadComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void OnPostSessionScoreComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void OnGetTournamentComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void OnShareTournamentComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void OnCreateTournamentComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract void OnPostTournamentScoreComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void OnGetTournamentsComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void OnUpdateTournamentComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void OnTournamentDialogSuccess(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void OnTournamentDialogCancel(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract void OnTournamentDialogError(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract void OnOpenAppStoreComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 33
	public abstract void OnCreateGamingContextComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 34
	public abstract void OnSwitchGamingContextComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 35
	public abstract void OnChooseGamingContextComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 36
	public abstract void OnGetCurrentGamingContextComplete(ResultContainer resultContainer);
}

// Namespace: Facebook.Unity.Mobile
internal abstract class MobileFacebook : FacebookBase, IMobileFacebookImplementation, IMobileFacebook, IFacebook, IFacebookWindows, IMobileFacebookResultHandler, IFacebookResultHandler // TypeDefIndex: 24792
{
	// Fields
	private ShareDialogMode shareDialogMode; // 0x28

	// Properties
	public ShareDialogMode ShareDialogMode { set; }

	// Methods

	// RVA: 0x413EE00 Offset: 0x413AE00 VA: 0x413EE00
	protected void .ctor(CallbackManager callbackManager) { }

	// RVA: 0x413EE08 Offset: 0x413AE08 VA: 0x413EE08 Slot: 105
	public void set_ShareDialogMode(ShareDialogMode value) { }

	// RVA: -1 Offset: -1 Slot: 160
	public abstract AuthenticationToken CurrentAuthenticationToken();

	// RVA: 0x413EE1C Offset: 0x413AE1C VA: 0x413EE1C Slot: 87
	public override Profile CurrentProfile() { }

	// RVA: 0x413EE54 Offset: 0x413AE54 VA: 0x413EE54 Slot: 88
	public override void CurrentProfile(FacebookDelegate<IProfileResult> callback) { }

	// RVA: -1 Offset: -1 Slot: 161
	public abstract void LoginWithTrackingPreference(string tracking, IEnumerable<string> permissions, string nonce, FacebookDelegate<ILoginResult> callback);

	// RVA: -1 Offset: -1 Slot: 162
	public abstract void FetchDeferredAppLink(FacebookDelegate<IAppLinkResult> callback);

	// RVA: -1 Offset: -1 Slot: 163
	public abstract void RefreshCurrentAccessToken(FacebookDelegate<IAccessTokenRefreshResult> callback);

	// RVA: -1 Offset: -1 Slot: 164
	public abstract bool IsImplicitPurchaseLoggingEnabled();

	// RVA: 0x413EE8C Offset: 0x413AE8C VA: 0x413EE8C Slot: 74
	public override void OnLoginComplete(ResultContainer resultContainer) { }

	// RVA: 0x413EF04 Offset: 0x413AF04 VA: 0x413EF04 Slot: 75
	public override void OnGetAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x413EF7C Offset: 0x413AF7C VA: 0x413EF7C Slot: 76
	public override void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: 0x413EFF4 Offset: 0x413AFF4 VA: 0x413EFF4 Slot: 123
	public void OnFetchDeferredAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x413F06C Offset: 0x413B06C VA: 0x413F06C Slot: 77
	public override void OnShareLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x413F0E4 Offset: 0x413B0E4 VA: 0x413F0E4 Slot: 124
	public void OnRefreshCurrentAccessTokenComplete(ResultContainer resultContainer) { }

	// RVA: 0x413F1AC Offset: 0x413B1AC VA: 0x413F1AC Slot: 93
	public override void OpenFriendFinderDialog(FacebookDelegate<IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x413F1E4 Offset: 0x413B1E4 VA: 0x413F1E4 Slot: 94
	public override void GetFriendFinderInvitations(FacebookDelegate<IFriendFinderInvitationResult> callback) { }

	// RVA: 0x413F21C Offset: 0x413B21C VA: 0x413F21C Slot: 95
	public override void DeleteFriendFinderInvitation(string invitationId, FacebookDelegate<IFriendFinderInvitationResult> callback) { }

	// RVA: 0x413F254 Offset: 0x413B254 VA: 0x413F254 Slot: 125
	public void OnFriendFinderComplete(ResultContainer resultContainer) { }

	// RVA: 0x413F2CC Offset: 0x413B2CC VA: 0x413F2CC Slot: 126
	public void OnUploadImageToMediaLibraryComplete(ResultContainer resultContainer) { }

	// RVA: 0x413F344 Offset: 0x413B344 VA: 0x413F344 Slot: 127
	public void OnUploadVideoToMediaLibraryComplete(ResultContainer resultContainer) { }

	// RVA: 0x413F3BC Offset: 0x413B3BC VA: 0x413F3BC Slot: 128
	public void OnOnIAPReadyComplete(ResultContainer resultContainer) { }

	// RVA: 0x413F434 Offset: 0x413B434 VA: 0x413F434 Slot: 129
	public void OnGetCatalogComplete(ResultContainer resultContainer) { }

	// RVA: 0x413F4AC Offset: 0x413B4AC VA: 0x413F4AC Slot: 130
	public void OnGetPurchasesComplete(ResultContainer resultContainer) { }

	// RVA: 0x413F524 Offset: 0x413B524 VA: 0x413F524 Slot: 131
	public void OnPurchaseComplete(ResultContainer resultContainer) { }

	// RVA: 0x413F59C Offset: 0x413B59C VA: 0x413F59C Slot: 132
	public void OnConsumePurchaseComplete(ResultContainer resultContainer) { }

	// RVA: 0x413F614 Offset: 0x413B614 VA: 0x413F614 Slot: 133
	public void OnGetSubscribableCatalogComplete(ResultContainer resultContainer) { }

	// RVA: 0x413F68C Offset: 0x413B68C VA: 0x413F68C Slot: 134
	public void OnGetSubscriptionsComplete(ResultContainer resultContainer) { }

	// RVA: 0x413F704 Offset: 0x413B704 VA: 0x413F704 Slot: 135
	public void OnPurchaseSubscriptionComplete(ResultContainer resultContainer) { }

	// RVA: 0x413F77C Offset: 0x413B77C VA: 0x413F77C Slot: 136
	public void OnCancelSubscriptionComplete(ResultContainer resultContainer) { }

	// RVA: 0x413F7F4 Offset: 0x413B7F4 VA: 0x413F7F4 Slot: 137
	public void OnInitCloudGameComplete(ResultContainer resultContainer) { }

	// RVA: 0x413F86C Offset: 0x413B86C VA: 0x413F86C Slot: 138
	public void OnGameLoadCompleteComplete(ResultContainer resultContainer) { }

	// RVA: 0x413F8E4 Offset: 0x413B8E4 VA: 0x413F8E4 Slot: 139
	public void OnScheduleAppToUserNotificationComplete(ResultContainer resultContainer) { }

	// RVA: 0x413F95C Offset: 0x413B95C VA: 0x413F95C Slot: 140
	public void OnLoadInterstitialAdComplete(ResultContainer resultContainer) { }

	// RVA: 0x413F9D4 Offset: 0x413B9D4 VA: 0x413F9D4 Slot: 141
	public void OnShowInterstitialAdComplete(ResultContainer resultContainer) { }

	// RVA: 0x413FA4C Offset: 0x413BA4C VA: 0x413FA4C Slot: 142
	public void OnLoadRewardedVideoComplete(ResultContainer resultContainer) { }

	// RVA: 0x413FAC4 Offset: 0x413BAC4 VA: 0x413FAC4 Slot: 143
	public void OnShowRewardedVideoComplete(ResultContainer resultContainer) { }

	// RVA: 0x413FB3C Offset: 0x413BB3C VA: 0x413FB3C Slot: 144
	public void OnGetPayloadComplete(ResultContainer resultContainer) { }

	// RVA: 0x413FBB4 Offset: 0x413BBB4 VA: 0x413FBB4 Slot: 145
	public void OnPostSessionScoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x413FC2C Offset: 0x413BC2C VA: 0x413FC2C Slot: 149
	public void OnPostTournamentScoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x413FCA4 Offset: 0x413BCA4 VA: 0x413FCA4 Slot: 146
	public void OnGetTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x413FD1C Offset: 0x413BD1C VA: 0x413FD1C Slot: 147
	public void OnShareTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x413FD94 Offset: 0x413BD94 VA: 0x413FD94 Slot: 148
	public void OnCreateTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x413FE0C Offset: 0x413BE0C VA: 0x413FE0C Slot: 150
	public void OnGetTournamentsComplete(ResultContainer resultContainer) { }

	// RVA: 0x413FE84 Offset: 0x413BE84 VA: 0x413FE84 Slot: 151
	public void OnUpdateTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x413FEFC Offset: 0x413BEFC VA: 0x413FEFC Slot: 152
	public void OnTournamentDialogSuccess(ResultContainer resultContainer) { }

	// RVA: 0x413FF74 Offset: 0x413BF74 VA: 0x413FF74 Slot: 154
	public void OnTournamentDialogError(ResultContainer resultContainer) { }

	// RVA: 0x413FFEC Offset: 0x413BFEC VA: 0x413FFEC Slot: 153
	public void OnTournamentDialogCancel(ResultContainer resultContainer) { }

	// RVA: 0x4140064 Offset: 0x413C064 VA: 0x4140064 Slot: 155
	public void OnOpenAppStoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x41400DC Offset: 0x413C0DC VA: 0x41400DC Slot: 156
	public void OnCreateGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x4140154 Offset: 0x413C154 VA: 0x4140154 Slot: 157
	public void OnSwitchGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x41401CC Offset: 0x413C1CC VA: 0x41401CC Slot: 158
	public void OnChooseGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x4140244 Offset: 0x413C244 VA: 0x4140244 Slot: 159
	public void OnGetCurrentGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x41402BC Offset: 0x413C2BC VA: 0x41402BC Slot: 102
	public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback) { }

	// RVA: 0x41402F4 Offset: 0x413C2F4 VA: 0x41402F4 Slot: 103
	public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback) { }

	// RVA: 0x414032C Offset: 0x413C32C VA: 0x414032C Slot: 165
	public virtual void OnIAPReady(FacebookDelegate<IIAPReadyResult> callback) { }

	// RVA: 0x4140364 Offset: 0x413C364 VA: 0x4140364 Slot: 79
	public override void GetCatalog(FacebookDelegate<ICatalogResult> callback) { }

	// RVA: 0x414039C Offset: 0x413C39C VA: 0x414039C Slot: 80
	public override void GetPurchases(FacebookDelegate<IPurchasesResult> callback) { }

	// RVA: 0x41403D4 Offset: 0x413C3D4 VA: 0x41403D4 Slot: 81
	public override void Purchase(string productID, FacebookDelegate<IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x414040C Offset: 0x413C40C VA: 0x414040C Slot: 82
	public override void ConsumePurchase(string purchaseToken, FacebookDelegate<IConsumePurchaseResult> callback) { }

	// RVA: 0x4140444 Offset: 0x413C444 VA: 0x4140444 Slot: 83
	public override void GetSubscribableCatalog(FacebookDelegate<ISubscribableCatalogResult> callback) { }

	// RVA: 0x414047C Offset: 0x413C47C VA: 0x414047C Slot: 84
	public override void GetSubscriptions(FacebookDelegate<ISubscriptionsResult> callback) { }

	// RVA: 0x41404B4 Offset: 0x413C4B4 VA: 0x41404B4 Slot: 85
	public override void PurchaseSubscription(string productToken, FacebookDelegate<ISubscriptionResult> callback) { }

	// RVA: 0x41404EC Offset: 0x413C4EC VA: 0x41404EC Slot: 86
	public override void CancelSubscription(string purchaseToken, FacebookDelegate<ICancelSubscriptionResult> callback) { }

	// RVA: 0x4140524 Offset: 0x413C524 VA: 0x4140524 Slot: 166
	public virtual void InitCloudGame(FacebookDelegate<IInitCloudGameResult> callback) { }

	// RVA: 0x414055C Offset: 0x413C55C VA: 0x414055C Slot: 167
	public virtual void GameLoadComplete(FacebookDelegate<IGameLoadCompleteResult> callback) { }

	// RVA: 0x4140594 Offset: 0x413C594 VA: 0x4140594 Slot: 96
	public override void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, FacebookDelegate<IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x41405CC Offset: 0x413C5CC VA: 0x41405CC Slot: 89
	public override void LoadInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback) { }

	// RVA: 0x4140604 Offset: 0x413C604 VA: 0x4140604 Slot: 90
	public override void ShowInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback) { }

	// RVA: 0x414063C Offset: 0x413C63C VA: 0x414063C Slot: 91
	public override void LoadRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback) { }

	// RVA: 0x4140674 Offset: 0x413C674 VA: 0x4140674 Slot: 92
	public override void ShowRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback) { }

	// RVA: 0x41406AC Offset: 0x413C6AC VA: 0x41406AC Slot: 168
	public virtual void GetPayload(FacebookDelegate<IPayloadResult> callback) { }

	// RVA: 0x41406E4 Offset: 0x413C6E4 VA: 0x41406E4 Slot: 97
	public override void PostSessionScore(int score, FacebookDelegate<ISessionScoreResult> callback) { }

	// RVA: 0x414071C Offset: 0x413C71C VA: 0x414071C Slot: 98
	public override void PostTournamentScore(int score, FacebookDelegate<ITournamentScoreResult> callback) { }

	// RVA: 0x4140754 Offset: 0x413C754 VA: 0x4140754 Slot: 99
	public override void GetTournament(FacebookDelegate<ITournamentResult> callback) { }

	// RVA: 0x414078C Offset: 0x413C78C VA: 0x414078C Slot: 100
	public override void ShareTournament(int score, Dictionary<string, string> data, FacebookDelegate<ITournamentScoreResult> callback) { }

	// RVA: 0x41407C4 Offset: 0x413C7C4 VA: 0x41407C4 Slot: 101
	public override void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, Dictionary<string, string> data, FacebookDelegate<ITournamentResult> callback) { }

	// RVA: 0x41407FC Offset: 0x413C7FC VA: 0x41407FC Slot: 169
	public virtual void GetTournaments(FacebookDelegate<IGetTournamentsResult> callback) { }

	// RVA: 0x4140834 Offset: 0x413C834 VA: 0x4140834 Slot: 170
	public virtual void UpdateTournament(string tournamentID, int score, FacebookDelegate<ITournamentScoreResult> callback) { }

	// RVA: 0x414086C Offset: 0x413C86C VA: 0x414086C Slot: 171
	public virtual void UpdateAndShareTournament(string tournamentID, int score, FacebookDelegate<IDialogResult> callback) { }

	// RVA: 0x41408A4 Offset: 0x413C8A4 VA: 0x41408A4 Slot: 172
	public virtual void CreateAndShareTournament(int initialScore, string title, TournamentSortOrder sortOrder, TournamentScoreFormat scoreFormat, long endTime, string payload, FacebookDelegate<IDialogResult> callback) { }

	// RVA: 0x41408DC Offset: 0x413C8DC VA: 0x41408DC Slot: 173
	public virtual void OpenAppStore(FacebookDelegate<IOpenAppStoreResult> callback) { }

	// RVA: 0x4140914 Offset: 0x413C914 VA: 0x4140914 Slot: 174
	public virtual void CreateGamingContext(string playerID, FacebookDelegate<ICreateGamingContextResult> callback) { }

	// RVA: 0x414094C Offset: 0x413C94C VA: 0x414094C Slot: 175
	public virtual void SwitchGamingContext(string gamingContextID, FacebookDelegate<ISwitchGamingContextResult> callback) { }

	// RVA: 0x4140984 Offset: 0x413C984 VA: 0x4140984 Slot: 176
	public virtual void ChooseGamingContext(List<string> filters, int minSize, int maxSize, FacebookDelegate<IChooseGamingContextResult> callback) { }

	// RVA: 0x41409BC Offset: 0x413C9BC VA: 0x41409BC Slot: 177
	public virtual void GetCurrentGamingContext(FacebookDelegate<IGetCurrentGamingContextResult> callback) { }

	// RVA: -1 Offset: -1 Slot: 178
	protected abstract void SetShareDialogMode(ShareDialogMode mode);
}

// Namespace: Facebook.Unity.Mobile
internal abstract class MobileFacebookGameObject : FacebookGameObject, IFacebookCallbackHandler // TypeDefIndex: 24793
{
	// Properties
	private IMobileFacebookImplementation MobileFacebook { get; }

	// Methods

	// RVA: 0x41409F4 Offset: 0x413C9F4 VA: 0x41409F4
	private IMobileFacebookImplementation get_MobileFacebook() { }

	// RVA: 0x4140A60 Offset: 0x413CA60 VA: 0x4140A60 Slot: 11
	public void OnFetchDeferredAppLinkComplete(string message) { }

	// RVA: 0x4140B48 Offset: 0x413CB48 VA: 0x4140B48 Slot: 12
	public void OnRefreshCurrentAccessTokenComplete(string message) { }

	// RVA: 0x4140C34 Offset: 0x413CC34 VA: 0x4140C34 Slot: 13
	public void OnFriendFinderComplete(string message) { }

	// RVA: 0x4140D20 Offset: 0x413CD20 VA: 0x4140D20 Slot: 14
	public void OnUploadImageToMediaLibraryComplete(string message) { }

	// RVA: 0x4140E0C Offset: 0x413CE0C VA: 0x4140E0C Slot: 15
	public void OnUploadVideoToMediaLibraryComplete(string message) { }

	// RVA: 0x4140EF8 Offset: 0x413CEF8 VA: 0x4140EF8 Slot: 16
	public void OnOnIAPReadyComplete(string message) { }

	// RVA: 0x4140FE4 Offset: 0x413CFE4 VA: 0x4140FE4 Slot: 17
	public void OnGetCatalogComplete(string message) { }

	// RVA: 0x41410D0 Offset: 0x413D0D0 VA: 0x41410D0 Slot: 18
	public void OnGetPurchasesComplete(string message) { }

	// RVA: 0x41411BC Offset: 0x413D1BC VA: 0x41411BC Slot: 19
	public void OnPurchaseComplete(string message) { }

	// RVA: 0x41412A8 Offset: 0x413D2A8 VA: 0x41412A8 Slot: 20
	public void OnConsumePurchaseComplete(string message) { }

	// RVA: 0x4141394 Offset: 0x413D394 VA: 0x4141394 Slot: 21
	public void OnGetSubscribableCatalogComplete(string message) { }

	// RVA: 0x4141480 Offset: 0x413D480 VA: 0x4141480 Slot: 22
	public void OnGetSubscriptionsComplete(string message) { }

	// RVA: 0x414156C Offset: 0x413D56C VA: 0x414156C Slot: 23
	public void OnPurchaseSubscriptionComplete(string message) { }

	// RVA: 0x4141658 Offset: 0x413D658 VA: 0x4141658 Slot: 24
	public void OnCancelSubscriptionComplete(string message) { }

	// RVA: 0x4141744 Offset: 0x413D744 VA: 0x4141744 Slot: 25
	public void OnInitCloudGameComplete(string message) { }

	// RVA: 0x4141830 Offset: 0x413D830 VA: 0x4141830 Slot: 26
	public void OnGameLoadCompleteComplete(string message) { }

	// RVA: 0x414191C Offset: 0x413D91C VA: 0x414191C Slot: 27
	public void OnScheduleAppToUserNotificationComplete(string message) { }

	// RVA: 0x4141A08 Offset: 0x413DA08 VA: 0x4141A08 Slot: 28
	public void OnLoadInterstitialAdComplete(string message) { }

	// RVA: 0x4141AF4 Offset: 0x413DAF4 VA: 0x4141AF4 Slot: 29
	public void OnShowInterstitialAdComplete(string message) { }

	// RVA: 0x4141BE0 Offset: 0x413DBE0 VA: 0x4141BE0 Slot: 30
	public void OnLoadRewardedVideoComplete(string message) { }

	// RVA: 0x4141CCC Offset: 0x413DCCC VA: 0x4141CCC Slot: 31
	public void OnShowRewardedVideoComplete(string message) { }

	// RVA: 0x4141DB8 Offset: 0x413DDB8 VA: 0x4141DB8 Slot: 32
	public void OnGetPayloadComplete(string message) { }

	// RVA: 0x4141EA4 Offset: 0x413DEA4 VA: 0x4141EA4 Slot: 33
	public virtual void OnPostSessionScoreComplete(string message) { }

	// RVA: 0x4141F90 Offset: 0x413DF90 VA: 0x4141F90 Slot: 34
	public virtual void OnPostTournamentScoreComplete(string message) { }

	// RVA: 0x414207C Offset: 0x413E07C VA: 0x414207C Slot: 35
	public virtual void OnGetTournamentComplete(string message) { }

	// RVA: 0x4142168 Offset: 0x413E168 VA: 0x4142168 Slot: 36
	public virtual void OnShareTournamentComplete(string message) { }

	// RVA: 0x4142254 Offset: 0x413E254 VA: 0x4142254 Slot: 37
	public virtual void OnCreateTournamentComplete(string message) { }

	// RVA: 0x4142340 Offset: 0x413E340 VA: 0x4142340 Slot: 38
	public virtual void OnGetTournamentsComplete(string message) { }

	// RVA: 0x414242C Offset: 0x413E42C VA: 0x414242C Slot: 39
	public virtual void OnUpdateTournamentComplete(string message) { }

	// RVA: 0x4142518 Offset: 0x413E518 VA: 0x4142518 Slot: 40
	public virtual void OnTournamentDialogSuccess(string message) { }

	// RVA: 0x4142604 Offset: 0x413E604 VA: 0x4142604 Slot: 41
	public virtual void OnTournamentDialogCancel(string message) { }

	// RVA: 0x41426F0 Offset: 0x413E6F0 VA: 0x41426F0 Slot: 42
	public virtual void OnTournamentDialogError(string message) { }

	// RVA: 0x41427DC Offset: 0x413E7DC VA: 0x41427DC Slot: 43
	public void OnOpenAppStoreComplete(string message) { }

	// RVA: 0x41428C8 Offset: 0x413E8C8 VA: 0x41428C8 Slot: 44
	public void OnCreateGamingContextComplete(string message) { }

	// RVA: 0x41429B4 Offset: 0x413E9B4 VA: 0x41429B4 Slot: 45
	public void OnSwitchGamingContextComplete(string message) { }

	// RVA: 0x4142AA0 Offset: 0x413EAA0 VA: 0x4142AA0 Slot: 46
	public void OnChooseGamingContextComplete(string message) { }

	// RVA: 0x4142B8C Offset: 0x413EB8C VA: 0x4142B8C Slot: 47
	public void OnGetCurrentGamingContextComplete(string message) { }

	// RVA: 0x4142C78 Offset: 0x413EC78 VA: 0x4142C78
	protected void .ctor() { }
}

// Namespace: Facebook.Unity.Mobile.IOS
internal interface IIOSWrapper // TypeDefIndex: 24794
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Init(string appId, bool frictionlessRequests, string urlSuffix, string unityUserAgentSuffix);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void LogInWithReadPermissions(int requestId, string scope);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void LogInWithPublishPermissions(int requestId, string scope);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void LoginWithTrackingPreference(int requestId, string scope, string tracking, string nonce);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void LogOut();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SetShareDialogMode(int mode);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void ShareLink(int requestId, string contentURL, string contentTitle, string contentDescription, string photoURL);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void FeedShare(int requestId, string toId, string link, string linkName, string linkCaption, string linkDescription, string picture, string mediaSource);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void AppRequest(int requestId, string message, string actionType, string objectId, string[] to, int toLength = 0, string filters = "", string[] excludeIds, int excludeIdsLength = 0, bool hasMaxRecipients = False, int maxRecipients = 0, string data = "", string title = "");

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void FBAppEventsActivateApp();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void LogAppEvent(string logEvent, double valueToSum, int numParams, string[] paramKeys, string[] paramVals);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void LogPurchaseAppEvent(double logPurchase, string currency, int numParams, string[] paramKeys, string[] paramVals);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void FBAppEventsSetLimitEventUsage(bool limitEventUsage);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void GetAppLink(int requestId);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void RefreshCurrentAccessToken(int requestId);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract string FBSdkVersion();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract string FBGetUserID();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void OpenFriendFinderDialog(int requestId);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void CreateGamingContext(int requestId, string playerID);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void SwitchGamingContext(int requestId, string gamingContextID);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void GetCurrentGamingContext(int requestId);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void ChooseGamingContext(int requestId, string filter, int minSize, int maxSize);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void GetTournaments(int requestId);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void UpdateTournament(string tournamentId, int score, int requestId);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void UpdateAndShareTournament(string tournamentId, int score, int requestId);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void CreateAndShareTournament(int initialScore, string title, TournamentSortOrder sortOrder, TournamentScoreFormat scoreFormat, long endTime, string payload, int requestId);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract void UploadImageToMediaLibrary(int requestId, string caption, string mediaUri, bool shouldLaunchMediaDialog);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void UploadVideoToMediaLibrary(int requestId, string caption, string videoUri);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void FetchDeferredAppLink(int requestId);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract AuthenticationToken CurrentAuthenticationToken();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract Profile CurrentProfile();
}

// Namespace: 
private class IOSFacebook.NativeDict // TypeDefIndex: 24795
{
	// Fields
	[CompilerGenerated]
	private int <NumEntries>k__BackingField; // 0x10
	[CompilerGenerated]
	private string[] <Keys>k__BackingField; // 0x18
	[CompilerGenerated]
	private string[] <Values>k__BackingField; // 0x20

	// Properties
	public int NumEntries { get; set; }
	public string[] Keys { get; set; }
	public string[] Values { get; set; }

	// Methods

	// RVA: 0x41454FC Offset: 0x41414FC VA: 0x41454FC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x4145534 Offset: 0x4141534 VA: 0x4145534
	public int get_NumEntries() { }

	[CompilerGenerated]
	// RVA: 0x414553C Offset: 0x414153C VA: 0x414553C
	public void set_NumEntries(int value) { }

	[CompilerGenerated]
	// RVA: 0x4145544 Offset: 0x4141544 VA: 0x4145544
	public string[] get_Keys() { }

	[CompilerGenerated]
	// RVA: 0x414554C Offset: 0x414154C VA: 0x414554C
	public void set_Keys(string[] value) { }

	[CompilerGenerated]
	// RVA: 0x4145554 Offset: 0x4141554 VA: 0x4145554
	public string[] get_Values() { }

	[CompilerGenerated]
	// RVA: 0x414555C Offset: 0x414155C VA: 0x414555C
	public void set_Values(string[] value) { }
}

// Namespace: Facebook.Unity.Mobile.IOS
internal class IOSFacebook : MobileFacebook // TypeDefIndex: 24796
{
	// Fields
	private bool limitEventUsage; // 0x2C
	private IIOSWrapper iosWrapper; // 0x30
	private string userID; // 0x38

	// Properties
	public override bool LimitEventUsage { get; set; }
	public override string SDKName { get; }
	public override string SDKVersion { get; }
	public override bool LoggedIn { get; }

	// Methods

	// RVA: 0x4142C80 Offset: 0x413EC80 VA: 0x4142C80
	public void .ctor() { }

	// RVA: 0x4142DB4 Offset: 0x413EDB4 VA: 0x4142DB4
	public void .ctor(IIOSWrapper iosWrapper, CallbackManager callbackManager) { }

	// RVA: 0x4142DE8 Offset: 0x413EDE8 VA: 0x4142DE8 Slot: 55
	public override bool get_LimitEventUsage() { }

	// RVA: 0x4142DF0 Offset: 0x413EDF0 VA: 0x4142DF0 Slot: 56
	public override void set_LimitEventUsage(bool value) { }

	// RVA: 0x4142EA4 Offset: 0x413EEA4 VA: 0x4142EA4 Slot: 57
	public override string get_SDKName() { }

	// RVA: 0x4142EE4 Offset: 0x413EEE4 VA: 0x4142EE4 Slot: 58
	public override string get_SDKVersion() { }

	// RVA: 0x4142F88 Offset: 0x413EF88 VA: 0x4142F88
	public void Init(string appId, bool frictionlessRequests, string iosURLSuffix, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete) { }

	// RVA: 0x41430EC Offset: 0x413F0EC VA: 0x41430EC Slot: 161
	public override void LoginWithTrackingPreference(string tracking, IEnumerable<string> permissions, string nonce, FacebookDelegate<ILoginResult> callback) { }

	// RVA: 0x41431F8 Offset: 0x413F1F8 VA: 0x41431F8 Slot: 64
	public override void LogInWithReadPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback) { }

	// RVA: 0x41432EC Offset: 0x413F2EC VA: 0x41432EC Slot: 63
	public override void LogInWithPublishPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback) { }

	// RVA: 0x41433E0 Offset: 0x413F3E0 VA: 0x41433E0 Slot: 65
	public override void LogOut() { }

	// RVA: 0x4143490 Offset: 0x413F490 VA: 0x4143490 Slot: 60
	public override bool get_LoggedIn() { }

	// RVA: 0x4143560 Offset: 0x413F560 VA: 0x4143560 Slot: 160
	public override AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x4143604 Offset: 0x413F604 VA: 0x4143604 Slot: 87
	public override Profile CurrentProfile() { }

	// RVA: 0x41436A8 Offset: 0x413F6A8 VA: 0x41436A8 Slot: 66
	public override void AppRequest(string message, Nullable<OGActionType> actionType, string objectId, IEnumerable<string> to, IEnumerable<object> filters, IEnumerable<string> excludeIds, Nullable<int> maxRecipients, string data, string title, FacebookDelegate<IAppRequestResult> callback) { }

	// RVA: 0x4143A0C Offset: 0x413FA0C VA: 0x4143A0C Slot: 67
	public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, FacebookDelegate<IShareResult> callback) { }

	// RVA: 0x4143B38 Offset: 0x413FB38 VA: 0x4143B38 Slot: 68
	public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, FacebookDelegate<IShareResult> callback) { }

	// RVA: 0x4143D24 Offset: 0x413FD24 VA: 0x4143D24 Slot: 71
	public override void AppEventsLogEvent(string logEvent, Nullable<float> valueToSum, Dictionary<string, object> parameters) { }

	// RVA: 0x41441C0 Offset: 0x41401C0 VA: 0x41441C0 Slot: 72
	public override void AppEventsLogPurchase(float logPurchase, string currency, Dictionary<string, object> parameters) { }

	// RVA: 0x41442A8 Offset: 0x41402A8 VA: 0x41442A8 Slot: 164
	public override bool IsImplicitPurchaseLoggingEnabled() { }

	// RVA: 0x41442B0 Offset: 0x41402B0 VA: 0x41442B0 Slot: 69
	public override void ActivateApp(string appId) { }

	// RVA: 0x4144354 Offset: 0x4140354 VA: 0x4144354 Slot: 162
	public override void FetchDeferredAppLink(FacebookDelegate<IAppLinkResult> callback) { }

	// RVA: 0x4144430 Offset: 0x4140430 VA: 0x4144430 Slot: 70
	public override void GetAppLink(FacebookDelegate<IAppLinkResult> callback) { }

	// RVA: 0x4144540 Offset: 0x4140540 VA: 0x4144540 Slot: 93
	public override void OpenFriendFinderDialog(FacebookDelegate<IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x4144650 Offset: 0x4140650 VA: 0x4144650 Slot: 94
	public override void GetFriendFinderInvitations(FacebookDelegate<IFriendFinderInvitationResult> callback) { }

	// RVA: 0x4144688 Offset: 0x4140688 VA: 0x4144688 Slot: 95
	public override void DeleteFriendFinderInvitation(string invitationId, FacebookDelegate<IFriendFinderInvitationResult> callback) { }

	// RVA: 0x41446C0 Offset: 0x41406C0 VA: 0x41446C0 Slot: 174
	public override void CreateGamingContext(string playerID, FacebookDelegate<ICreateGamingContextResult> callback) { }

	// RVA: 0x41447E0 Offset: 0x41407E0 VA: 0x41447E0 Slot: 175
	public override void SwitchGamingContext(string gamingContextID, FacebookDelegate<ISwitchGamingContextResult> callback) { }

	// RVA: 0x4144900 Offset: 0x4140900 VA: 0x4144900 Slot: 176
	public override void ChooseGamingContext(List<string> filters, int minSize, int maxSize, FacebookDelegate<IChooseGamingContextResult> callback) { }

	// RVA: 0x4144A94 Offset: 0x4140A94 VA: 0x4144A94 Slot: 177
	public override void GetCurrentGamingContext(FacebookDelegate<IGetCurrentGamingContextResult> callback) { }

	// RVA: 0x4144BA4 Offset: 0x4140BA4 VA: 0x4144BA4 Slot: 169
	public override void GetTournaments(FacebookDelegate<IGetTournamentsResult> callback) { }

	// RVA: 0x4144CB4 Offset: 0x4140CB4 VA: 0x4144CB4 Slot: 170
	public override void UpdateTournament(string tournamentID, int score, FacebookDelegate<ITournamentScoreResult> callback) { }

	// RVA: 0x4144DDC Offset: 0x4140DDC VA: 0x4144DDC Slot: 171
	public override void UpdateAndShareTournament(string tournamentID, int score, FacebookDelegate<IDialogResult> callback) { }

	// RVA: 0x4144F04 Offset: 0x4140F04 VA: 0x4144F04 Slot: 172
	public override void CreateAndShareTournament(int initialScore, string title, TournamentSortOrder sortOrder, TournamentScoreFormat scoreFormat, long endTime, string payload, FacebookDelegate<IDialogResult> callback) { }

	// RVA: 0x4145060 Offset: 0x4141060 VA: 0x4145060 Slot: 163
	public override void RefreshCurrentAccessToken(FacebookDelegate<IAccessTokenRefreshResult> callback) { }

	// RVA: 0x4145170 Offset: 0x4141170 VA: 0x4145170 Slot: 178
	protected override void SetShareDialogMode(ShareDialogMode mode) { }

	// RVA: 0x414521C Offset: 0x414121C VA: 0x414521C Slot: 102
	public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback) { }

	// RVA: 0x4145378 Offset: 0x4141378 VA: 0x4145378 Slot: 103
	public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback) { }

	// RVA: 0x41454C4 Offset: 0x41414C4 VA: 0x41454C4 Slot: 104
	public override void GetUserLocale(FacebookDelegate<ILocaleResult> callback) { }

	// RVA: 0x4142CFC Offset: 0x413ECFC VA: 0x4142CFC
	private static IIOSWrapper GetIOSWrapper() { }

	// RVA: 0x4143EF8 Offset: 0x413FEF8 VA: 0x4143EF8
	private static IOSFacebook.NativeDict MarshallDict(Dictionary<string, object> dict) { }

	// RVA: -1 Offset: -1
	private int AddCallback<T>(FacebookDelegate<T> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x464580C Offset: 0x464180C VA: 0x464580C
	|-IOSFacebook.AddCallback<object>
	|
	|-RVA: 0x4645898 Offset: 0x4641898 VA: 0x4645898
	|-IOSFacebook.AddCallback<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Facebook.Unity.Mobile.IOS
internal class IOSFacebookGameObject : MobileFacebookGameObject // TypeDefIndex: 24797
{
	// Methods

	// RVA: 0x4145564 Offset: 0x4141564 VA: 0x4145564
	public void .ctor() { }
}

// Namespace: Facebook.Unity.Mobile.IOS
internal class IOSFacebookLoader : FB.CompiledFacebookLoader // TypeDefIndex: 24798
{
	// Properties
	protected override FacebookGameObject FBGameObject { get; }

	// Methods

	// RVA: 0x414556C Offset: 0x414156C VA: 0x414556C Slot: 4
	protected override FacebookGameObject get_FBGameObject() { }

	// RVA: 0x4145604 Offset: 0x4141604 VA: 0x4145604
	public void .ctor() { }
}

// Namespace: 
private class AndroidFacebook.JavaMethodCall<T> : MethodCall<T> // TypeDefIndex: 24799
{
	// Fields
	private AndroidFacebook androidImpl; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(AndroidFacebook androidImpl, string methodName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A76548 Offset: 0x4A72548 VA: 0x4A76548
	|-AndroidFacebook.JavaMethodCall<object>..ctor
	|
	|-RVA: 0x4A76688 Offset: 0x4A72688 VA: 0x4A76688
	|-AndroidFacebook.JavaMethodCall<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Call(MethodArguments args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A76580 Offset: 0x4A72580 VA: 0x4A76580
	|-AndroidFacebook.JavaMethodCall<object>.Call
	|
	|-RVA: 0x4A766C4 Offset: 0x4A726C4 VA: 0x4A766C4
	|-AndroidFacebook.JavaMethodCall<__Il2CppFullySharedGenericType>.Call
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class AndroidFacebook.<>c // TypeDefIndex: 24800
{
	// Fields
	public static readonly AndroidFacebook.<>c <>9; // 0x0
	public static Func<KeyValuePair<string, string>, string> <>9__73_0; // 0x8
	public static Func<KeyValuePair<string, string>, object> <>9__73_1; // 0x10
	public static Func<KeyValuePair<string, string>, string> <>9__74_0; // 0x18
	public static Func<KeyValuePair<string, string>, object> <>9__74_1; // 0x20

	// Methods

	// RVA: 0x414A7B4 Offset: 0x41467B4 VA: 0x414A7B4
	private static void .cctor() { }

	// RVA: 0x414A81C Offset: 0x414681C VA: 0x414A81C
	public void .ctor() { }

	// RVA: 0x414A824 Offset: 0x4146824 VA: 0x414A824
	internal string <CreateTournament>b__73_0(KeyValuePair<string, string> pair) { }

	// RVA: 0x414A860 Offset: 0x4146860 VA: 0x414A860
	internal object <CreateTournament>b__73_1(KeyValuePair<string, string> pair) { }

	// RVA: 0x414A89C Offset: 0x414689C VA: 0x414A89C
	internal string <ShareTournament>b__74_0(KeyValuePair<string, string> pair) { }

	// RVA: 0x414A8D8 Offset: 0x41468D8 VA: 0x414A8D8
	internal object <ShareTournament>b__74_1(KeyValuePair<string, string> pair) { }
}

// Namespace: Facebook.Unity.Mobile.Android
internal sealed class AndroidFacebook : MobileFacebook // TypeDefIndex: 24801
{
	// Fields
	private bool limitEventUsage; // 0x2C
	private IAndroidWrapper androidWrapper; // 0x30
	private string userID; // 0x38
	[CompilerGenerated]
	private string <KeyHash>k__BackingField; // 0x40

	// Properties
	private string KeyHash { set; }
	public override bool LimitEventUsage { get; set; }
	public override string SDKName { get; }
	public override string SDKVersion { get; }

	// Methods

	// RVA: 0x414560C Offset: 0x414160C VA: 0x414560C
	public void .ctor() { }

	// RVA: 0x4145730 Offset: 0x4141730 VA: 0x4145730
	public void .ctor(IAndroidWrapper androidWrapper, CallbackManager callbackManager) { }

	[CompilerGenerated]
	// RVA: 0x41457B4 Offset: 0x41417B4 VA: 0x41457B4
	private void set_KeyHash(string value) { }

	// RVA: 0x41457BC Offset: 0x41417BC VA: 0x41457BC Slot: 55
	public override bool get_LimitEventUsage() { }

	// RVA: 0x41457C4 Offset: 0x41417C4 VA: 0x41457C4 Slot: 56
	public override void set_LimitEventUsage(bool value) { }

	// RVA: 0x414597C Offset: 0x414197C VA: 0x414597C Slot: 57
	public override string get_SDKName() { }

	// RVA: 0x41459BC Offset: 0x41419BC VA: 0x41459BC Slot: 58
	public override string get_SDKVersion() { }

	// RVA: 0x4145A90 Offset: 0x4141A90 VA: 0x4145A90
	public void Init(string appId, string clientToken, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete) { }

	// RVA: 0x4145CF8 Offset: 0x4141CF8 VA: 0x4145CF8 Slot: 161
	public override void LoginWithTrackingPreference(string tracking, IEnumerable<string> permissions, string nonce, FacebookDelegate<ILoginResult> callback) { }

	// RVA: 0x4145D88 Offset: 0x4141D88 VA: 0x4145D88 Slot: 64
	public override void LogInWithReadPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback) { }

	// RVA: 0x4145EAC Offset: 0x4141EAC VA: 0x4145EAC Slot: 63
	public override void LogInWithPublishPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback) { }

	// RVA: 0x4145FD0 Offset: 0x4141FD0 VA: 0x4145FD0 Slot: 65
	public override void LogOut() { }

	// RVA: 0x4146080 Offset: 0x4142080 VA: 0x4146080 Slot: 160
	public override AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x4146370 Offset: 0x4142370 VA: 0x4146370 Slot: 87
	public override Profile CurrentProfile() { }

	// RVA: 0x4146C28 Offset: 0x4142C28 VA: 0x4146C28
	public void OnLoginStatusRetrieved(ResultContainer resultContainer) { }

	// RVA: 0x4146CA0 Offset: 0x4142CA0 VA: 0x4146CA0 Slot: 66
	public override void AppRequest(string message, Nullable<OGActionType> actionType, string objectId, IEnumerable<string> to, IEnumerable<object> filters, IEnumerable<string> excludeIds, Nullable<int> maxRecipients, string data, string title, FacebookDelegate<IAppRequestResult> callback) { }

	// RVA: 0x4146FE8 Offset: 0x4142FE8 VA: 0x4146FE8 Slot: 67
	public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, FacebookDelegate<IShareResult> callback) { }

	// RVA: 0x41471A4 Offset: 0x41431A4 VA: 0x41471A4 Slot: 68
	public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, FacebookDelegate<IShareResult> callback) { }

	// RVA: 0x41473E4 Offset: 0x41433E4 VA: 0x41473E4 Slot: 70
	public override void GetAppLink(FacebookDelegate<IAppLinkResult> callback) { }

	// RVA: 0x41474B0 Offset: 0x41434B0 VA: 0x41474B0 Slot: 71
	public override void AppEventsLogEvent(string logEvent, Nullable<float> valueToSum, Dictionary<string, object> parameters) { }

	// RVA: 0x4147694 Offset: 0x4143694 VA: 0x4147694 Slot: 72
	public override void AppEventsLogPurchase(float logPurchase, string currency, Dictionary<string, object> parameters) { }

	// RVA: 0x4147840 Offset: 0x4143840 VA: 0x4147840 Slot: 164
	public override bool IsImplicitPurchaseLoggingEnabled() { }

	// RVA: 0x4147914 Offset: 0x4143914 VA: 0x4147914 Slot: 69
	public override void ActivateApp(string appId) { }

	// RVA: 0x4147960 Offset: 0x4143960 VA: 0x4147960 Slot: 162
	public override void FetchDeferredAppLink(FacebookDelegate<IAppLinkResult> callback) { }

	// RVA: 0x4147A54 Offset: 0x4143A54 VA: 0x4147A54 Slot: 163
	public override void RefreshCurrentAccessToken(FacebookDelegate<IAccessTokenRefreshResult> callback) { }

	// RVA: 0x4147B20 Offset: 0x4143B20 VA: 0x4147B20 Slot: 93
	public override void OpenFriendFinderDialog(FacebookDelegate<IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x4147BEC Offset: 0x4143BEC VA: 0x4147BEC Slot: 94
	public override void GetFriendFinderInvitations(FacebookDelegate<IFriendFinderInvitationResult> callback) { }

	// RVA: 0x4147C24 Offset: 0x4143C24 VA: 0x4147C24 Slot: 95
	public override void DeleteFriendFinderInvitation(string invitationId, FacebookDelegate<IFriendFinderInvitationResult> callback) { }

	// RVA: 0x4147C5C Offset: 0x4143C5C VA: 0x4147C5C Slot: 102
	public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback) { }

	// RVA: 0x4147E28 Offset: 0x4143E28 VA: 0x4147E28 Slot: 103
	public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback) { }

	// RVA: 0x4147F80 Offset: 0x4143F80 VA: 0x4147F80 Slot: 104
	public override void GetUserLocale(FacebookDelegate<ILocaleResult> callback) { }

	// RVA: 0x4147FB8 Offset: 0x4143FB8 VA: 0x4147FB8 Slot: 165
	public override void OnIAPReady(FacebookDelegate<IIAPReadyResult> callback) { }

	// RVA: 0x4148084 Offset: 0x4144084 VA: 0x4148084 Slot: 79
	public override void GetCatalog(FacebookDelegate<ICatalogResult> callback) { }

	// RVA: 0x4148150 Offset: 0x4144150 VA: 0x4148150 Slot: 80
	public override void GetPurchases(FacebookDelegate<IPurchasesResult> callback) { }

	// RVA: 0x414821C Offset: 0x414421C VA: 0x414821C Slot: 81
	public override void Purchase(string productID, FacebookDelegate<IPurchaseResult> callback, string developerPayload = "") { }

	// RVA: 0x4148374 Offset: 0x4144374 VA: 0x4148374 Slot: 82
	public override void ConsumePurchase(string purchaseToken, FacebookDelegate<IConsumePurchaseResult> callback) { }

	// RVA: 0x4148498 Offset: 0x4144498 VA: 0x4148498 Slot: 83
	public override void GetSubscribableCatalog(FacebookDelegate<ISubscribableCatalogResult> callback) { }

	// RVA: 0x4148564 Offset: 0x4144564 VA: 0x4148564 Slot: 84
	public override void GetSubscriptions(FacebookDelegate<ISubscriptionsResult> callback) { }

	// RVA: 0x4148630 Offset: 0x4144630 VA: 0x4148630 Slot: 85
	public override void PurchaseSubscription(string productID, FacebookDelegate<ISubscriptionResult> callback) { }

	// RVA: 0x4148754 Offset: 0x4144754 VA: 0x4148754 Slot: 86
	public override void CancelSubscription(string purchaseToken, FacebookDelegate<ICancelSubscriptionResult> callback) { }

	// RVA: 0x4148878 Offset: 0x4144878 VA: 0x4148878 Slot: 166
	public override void InitCloudGame(FacebookDelegate<IInitCloudGameResult> callback) { }

	// RVA: 0x4148944 Offset: 0x4144944 VA: 0x4148944 Slot: 167
	public override void GameLoadComplete(FacebookDelegate<IGameLoadCompleteResult> callback) { }

	// RVA: 0x4148A10 Offset: 0x4144A10 VA: 0x4148A10 Slot: 96
	public override void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, FacebookDelegate<IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x4148C0C Offset: 0x4144C0C VA: 0x4148C0C Slot: 89
	public override void LoadInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback) { }

	// RVA: 0x4148D30 Offset: 0x4144D30 VA: 0x4148D30 Slot: 90
	public override void ShowInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback) { }

	// RVA: 0x4148E54 Offset: 0x4144E54 VA: 0x4148E54 Slot: 91
	public override void LoadRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback) { }

	// RVA: 0x4148F78 Offset: 0x4144F78 VA: 0x4148F78 Slot: 92
	public override void ShowRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback) { }

	// RVA: 0x414909C Offset: 0x414509C VA: 0x414909C Slot: 168
	public override void GetPayload(FacebookDelegate<IPayloadResult> callback) { }

	// RVA: 0x4149168 Offset: 0x4145168 VA: 0x4149168 Slot: 97
	public override void PostSessionScore(int score, FacebookDelegate<ISessionScoreResult> callback) { }

	// RVA: 0x414929C Offset: 0x414529C VA: 0x414929C Slot: 98
	public override void PostTournamentScore(int score, FacebookDelegate<ITournamentScoreResult> callback) { }

	// RVA: 0x41493D0 Offset: 0x41453D0 VA: 0x41493D0 Slot: 99
	public override void GetTournament(FacebookDelegate<ITournamentResult> callback) { }

	// RVA: 0x414949C Offset: 0x414549C VA: 0x414949C Slot: 101
	public override void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, Dictionary<string, string> data, FacebookDelegate<ITournamentResult> callback) { }

	// RVA: 0x4149820 Offset: 0x4145820 VA: 0x4149820 Slot: 100
	public override void ShareTournament(int score, Dictionary<string, string> data, FacebookDelegate<ITournamentScoreResult> callback) { }

	// RVA: 0x4149B18 Offset: 0x4145B18 VA: 0x4149B18 Slot: 169
	public override void GetTournaments(FacebookDelegate<IGetTournamentsResult> callback) { }

	// RVA: 0x4149BE4 Offset: 0x4145BE4 VA: 0x4149BE4 Slot: 170
	public override void UpdateTournament(string tournamentID, int score, FacebookDelegate<ITournamentScoreResult> callback) { }

	// RVA: 0x4149D4C Offset: 0x4145D4C VA: 0x4149D4C Slot: 171
	public override void UpdateAndShareTournament(string tournamentID, int score, FacebookDelegate<IDialogResult> callback) { }

	// RVA: 0x4149EB4 Offset: 0x4145EB4 VA: 0x4149EB4 Slot: 172
	public override void CreateAndShareTournament(int initialScore, string title, TournamentSortOrder sortOrder, TournamentScoreFormat scoreFormat, long endTime, string payload, FacebookDelegate<IDialogResult> callback) { }

	// RVA: 0x414A15C Offset: 0x414615C VA: 0x414A15C Slot: 173
	public override void OpenAppStore(FacebookDelegate<IOpenAppStoreResult> callback) { }

	// RVA: 0x414A228 Offset: 0x4146228 VA: 0x414A228 Slot: 174
	public override void CreateGamingContext(string playerID, FacebookDelegate<ICreateGamingContextResult> callback) { }

	// RVA: 0x414A34C Offset: 0x414634C VA: 0x414A34C Slot: 175
	public override void SwitchGamingContext(string gamingContextID, FacebookDelegate<ISwitchGamingContextResult> callback) { }

	// RVA: 0x414A470 Offset: 0x4146470 VA: 0x414A470 Slot: 176
	public override void ChooseGamingContext(List<string> filters, int minSize, int maxSize, FacebookDelegate<IChooseGamingContextResult> callback) { }

	// RVA: 0x414A62C Offset: 0x414662C VA: 0x414A62C Slot: 177
	public override void GetCurrentGamingContext(FacebookDelegate<IGetCurrentGamingContextResult> callback) { }

	// RVA: 0x414A720 Offset: 0x4146720 VA: 0x414A720 Slot: 178
	protected override void SetShareDialogMode(ShareDialogMode mode) { }

	// RVA: 0x4145678 Offset: 0x4141678 VA: 0x4145678
	private static IAndroidWrapper GetAndroidWrapper() { }

	// RVA: 0x4145858 Offset: 0x4141858 VA: 0x4145858
	private void CallFB(string method, string args) { }
}

// Namespace: Facebook.Unity.Mobile.Android
internal class AndroidFacebookGameObject : MobileFacebookGameObject // TypeDefIndex: 24802
{
	// Methods

	// RVA: 0x414A914 Offset: 0x4146914 VA: 0x414A914 Slot: 10
	protected override void OnAwake() { }

	// RVA: 0x414A91C Offset: 0x414691C VA: 0x414A91C
	private void OnEnable() { }

	// RVA: 0x414A9C0 Offset: 0x41469C0 VA: 0x414A9C0
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x414A9C8 Offset: 0x41469C8 VA: 0x414A9C8
	private void OnDisable() { }

	// RVA: 0x414AA6C Offset: 0x4146A6C VA: 0x414AA6C
	public void onPurchaseCompleteHandler(object data) { }

	// RVA: 0x414AA78 Offset: 0x4146A78 VA: 0x414AA78
	public void OnLoginStatusRetrieved(string message) { }

	// RVA: 0x414AB18 Offset: 0x4146B18 VA: 0x414AB18
	public void .ctor() { }
}

// Namespace: Facebook.Unity.Mobile.Android
internal class AndroidFacebookLoader : FB.CompiledFacebookLoader // TypeDefIndex: 24803
{
	// Properties
	protected override FacebookGameObject FBGameObject { get; }

	// Methods

	// RVA: 0x414AB20 Offset: 0x4146B20 VA: 0x414AB20 Slot: 4
	protected override FacebookGameObject get_FBGameObject() { }

	// RVA: 0x414ABB8 Offset: 0x4146BB8 VA: 0x414ABB8
	public void .ctor() { }
}

// Namespace: Facebook.Unity.Mobile.Android
internal interface IAndroidWrapper // TypeDefIndex: 24804
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T CallStatic<T>(string methodName);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IAndroidWrapper.CallStatic<__Il2CppFullySharedGenericType>
	|-IAndroidWrapper.CallStatic<bool>
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void CallStatic(string methodName, object[] args);
}

// Namespace: 
private class CanvasFacebook.CanvasUIMethodCall<T> : MethodCall<T> // TypeDefIndex: 24805
{
	// Fields
	private CanvasFacebook canvasImpl; // 0x0
	private string callbackMethod; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(CanvasFacebook canvasImpl, string methodName, string callbackMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA7F3C Offset: 0x5BA3F3C VA: 0x5BA7F3C
	|-CanvasFacebook.CanvasUIMethodCall<object>..ctor
	|
	|-RVA: 0x5BA81C4 Offset: 0x5BA41C4 VA: 0x5BA81C4
	|-CanvasFacebook.CanvasUIMethodCall<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Call(MethodArguments args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA7F88 Offset: 0x5BA3F88 VA: 0x5BA7F88
	|-CanvasFacebook.CanvasUIMethodCall<object>.Call
	|
	|-RVA: 0x5BA8214 Offset: 0x5BA4214 VA: 0x5BA8214
	|-CanvasFacebook.CanvasUIMethodCall<__Il2CppFullySharedGenericType>.Call
	*/

	// RVA: -1 Offset: -1
	private void UI(string method, MethodArguments args, FacebookDelegate<T> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA7FB4 Offset: 0x5BA3FB4 VA: 0x5BA7FB4
	|-CanvasFacebook.CanvasUIMethodCall<object>.UI
	|
	|-RVA: 0x5BA8294 Offset: 0x5BA4294 VA: 0x5BA8294
	|-CanvasFacebook.CanvasUIMethodCall<__Il2CppFullySharedGenericType>.UI
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class CanvasFacebook.<>c // TypeDefIndex: 24806
{
	// Fields
	public static readonly CanvasFacebook.<>c <>9; // 0x0
	public static Utilities.Callback<ResultContainer> <>9__40_0; // 0x8

	// Methods

	// RVA: 0x414D860 Offset: 0x4149860 VA: 0x414D860
	private static void .cctor() { }

	// RVA: 0x414D8C8 Offset: 0x41498C8 VA: 0x414D8C8
	public void .ctor() { }

	// RVA: 0x414D8D0 Offset: 0x41498D0 VA: 0x414D8D0
	internal void <OnFacebookAuthResponseChange>b__40_0(ResultContainer formattedResponse) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CanvasFacebook.<>c__DisplayClass47_0 // TypeDefIndex: 24807
{
	// Fields
	public ResultContainer result; // 0x10
	public Utilities.Callback<ResultContainer> callback; // 0x18

	// Methods

	// RVA: 0x414D230 Offset: 0x4149230 VA: 0x414D230
	public void .ctor() { }

	// RVA: 0x414D974 Offset: 0x4149974 VA: 0x414D974
	internal void <FormatAuthResponse>b__0(IGraphResult r) { }
}

// Namespace: Facebook.Unity.Canvas
internal sealed class CanvasFacebook : FacebookBase, ICanvasFacebookImplementation, IPayFacebook, IFacebook, IFacebookWindows, ICanvasFacebookResultHandler, IFacebookResultHandler // TypeDefIndex: 24808
{
	// Fields
	private string appId; // 0x28
	private string appLinkUrl; // 0x30
	private ICanvasJSWrapper canvasJSWrapper; // 0x38
	private HideUnityDelegate onHideUnityDelegate; // 0x40
	[CompilerGenerated]
	private bool <LimitEventUsage>k__BackingField; // 0x48

	// Properties
	public override bool LimitEventUsage { get; set; }
	public override string SDKName { get; }
	public override string SDKVersion { get; }
	public override string SDKUserAgent { get; }

	// Methods

	// RVA: 0x414ABC0 Offset: 0x4146BC0 VA: 0x414ABC0
	public void .ctor() { }

	// RVA: 0x414ACF4 Offset: 0x4146CF4 VA: 0x414ACF4
	public void .ctor(ICanvasJSWrapper canvasJSWrapper, CallbackManager callbackManager) { }

	// RVA: 0x414AC3C Offset: 0x4146C3C VA: 0x414AC3C
	private static ICanvasJSWrapper GetCanvasJSWrapper() { }

	[CompilerGenerated]
	// RVA: 0x414AD28 Offset: 0x4146D28 VA: 0x414AD28 Slot: 55
	public override bool get_LimitEventUsage() { }

	[CompilerGenerated]
	// RVA: 0x414AD30 Offset: 0x4146D30 VA: 0x414AD30 Slot: 56
	public override void set_LimitEventUsage(bool value) { }

	// RVA: 0x414AD3C Offset: 0x4146D3C VA: 0x414AD3C Slot: 57
	public override string get_SDKName() { }

	// RVA: 0x414AD7C Offset: 0x4146D7C VA: 0x414AD7C Slot: 58
	public override string get_SDKVersion() { }

	// RVA: 0x414AE1C Offset: 0x4146E1C VA: 0x414AE1C Slot: 59
	public override string get_SDKUserAgent() { }

	// RVA: 0x414B0C4 Offset: 0x41470C4 VA: 0x414B0C4
	public void Init(string appId, bool cookie, bool logging, bool status, bool xfbml, string channelUrl, string authResponse, bool frictionlessRequests, string javascriptSDKLocale, bool loadDebugJSSDK, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete) { }

	// RVA: 0x414B4BC Offset: 0x41474BC VA: 0x414B4BC Slot: 63
	public override void LogInWithPublishPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback) { }

	// RVA: 0x414B608 Offset: 0x4147608 VA: 0x414B608 Slot: 64
	public override void LogInWithReadPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback) { }

	// RVA: 0x414B754 Offset: 0x4147754 VA: 0x414B754 Slot: 65
	public override void LogOut() { }

	// RVA: 0x414B804 Offset: 0x4147804 VA: 0x414B804 Slot: 66
	public override void AppRequest(string message, Nullable<OGActionType> actionType, string objectId, IEnumerable<string> to, IEnumerable<object> filters, IEnumerable<string> excludeIds, Nullable<int> maxRecipients, string data, string title, FacebookDelegate<IAppRequestResult> callback) { }

	// RVA: 0x414BB68 Offset: 0x4147B68 VA: 0x414BB68 Slot: 69
	public override void ActivateApp(string appId) { }

	// RVA: 0x414BC0C Offset: 0x4147C0C VA: 0x414BC0C Slot: 67
	public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, FacebookDelegate<IShareResult> callback) { }

	// RVA: 0x414BDE0 Offset: 0x4147DE0 VA: 0x414BDE0 Slot: 68
	public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, FacebookDelegate<IShareResult> callback) { }

	// RVA: 0x414C038 Offset: 0x4148038 VA: 0x414C038 Slot: 105
	public void Pay(string product, string action, int quantity, Nullable<int> quantityMin, Nullable<int> quantityMax, string requestId, string pricepointId, string testCurrency, FacebookDelegate<IPayResult> callback) { }

	// RVA: 0x414C37C Offset: 0x414837C VA: 0x414C37C Slot: 70
	public override void GetAppLink(FacebookDelegate<IAppLinkResult> callback) { }

	// RVA: 0x414C4CC Offset: 0x41484CC VA: 0x414C4CC Slot: 71
	public override void AppEventsLogEvent(string logEvent, Nullable<float> valueToSum, Dictionary<string, object> parameters) { }

	// RVA: 0x414C5CC Offset: 0x41485CC VA: 0x414C5CC Slot: 72
	public override void AppEventsLogPurchase(float purchaseAmount, string currency, Dictionary<string, object> parameters) { }

	// RVA: 0x414C6CC Offset: 0x41486CC VA: 0x414C6CC Slot: 74
	public override void OnLoginComplete(ResultContainer result) { }

	// RVA: 0x414CF88 Offset: 0x4148F88 VA: 0x414CF88 Slot: 75
	public override void OnGetAppLinkComplete(ResultContainer message) { }

	// RVA: 0x414CFC0 Offset: 0x4148FC0 VA: 0x414CFC0 Slot: 107
	public void OnFacebookAuthResponseChange(ResultContainer resultContainer) { }

	// RVA: 0x414D0A0 Offset: 0x41490A0 VA: 0x414D0A0 Slot: 106
	public void OnPayComplete(ResultContainer resultContainer) { }

	// RVA: 0x414D118 Offset: 0x4149118 VA: 0x414D118 Slot: 76
	public override void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: 0x414D190 Offset: 0x4149190 VA: 0x414D190 Slot: 77
	public override void OnShareLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x414D208 Offset: 0x4149208 VA: 0x414D208 Slot: 108
	public void OnUrlResponse(string url) { }

	// RVA: 0x414D210 Offset: 0x4149210 VA: 0x414D210 Slot: 109
	public void OnHideUnity(bool isGameShown) { }

	// RVA: 0x414C750 Offset: 0x4148750 VA: 0x414C750
	private static void FormatAuthResponse(ResultContainer result, Utilities.Callback<ResultContainer> callback) { }

	// RVA: 0x414C078 Offset: 0x4148078 VA: 0x414C078
	private void PayImpl(string product, string productId, string action, int quantity, Nullable<int> quantityMin, Nullable<int> quantityMax, string requestId, string pricepointId, string testCurrency, string developerPayload, FacebookDelegate<IPayResult> callback) { }

	// RVA: 0x414D238 Offset: 0x4149238 VA: 0x414D238 Slot: 79
	public override void GetCatalog(FacebookDelegate<ICatalogResult> callback) { }

	// RVA: 0x414D270 Offset: 0x4149270 VA: 0x414D270 Slot: 80
	public override void GetPurchases(FacebookDelegate<IPurchasesResult> callback) { }

	// RVA: 0x414D2A8 Offset: 0x41492A8 VA: 0x414D2A8 Slot: 81
	public override void Purchase(string productID, FacebookDelegate<IPurchaseResult> callback, string developerPayload = "") { }

	// RVA: 0x414D2E0 Offset: 0x41492E0 VA: 0x414D2E0 Slot: 82
	public override void ConsumePurchase(string productToken, FacebookDelegate<IConsumePurchaseResult> callback) { }

	// RVA: 0x414D318 Offset: 0x4149318 VA: 0x414D318 Slot: 83
	public override void GetSubscribableCatalog(FacebookDelegate<ISubscribableCatalogResult> callback) { }

	// RVA: 0x414D350 Offset: 0x4149350 VA: 0x414D350 Slot: 84
	public override void GetSubscriptions(FacebookDelegate<ISubscriptionsResult> callback) { }

	// RVA: 0x414D388 Offset: 0x4149388 VA: 0x414D388 Slot: 85
	public override void PurchaseSubscription(string productID, FacebookDelegate<ISubscriptionResult> callback) { }

	// RVA: 0x414D3C0 Offset: 0x41493C0 VA: 0x414D3C0 Slot: 86
	public override void CancelSubscription(string productToken, FacebookDelegate<ICancelSubscriptionResult> callback) { }

	// RVA: 0x414D3F8 Offset: 0x41493F8 VA: 0x414D3F8 Slot: 87
	public override Profile CurrentProfile() { }

	// RVA: 0x414D430 Offset: 0x4149430 VA: 0x414D430 Slot: 88
	public override void CurrentProfile(FacebookDelegate<IProfileResult> callback) { }

	// RVA: 0x414D468 Offset: 0x4149468 VA: 0x414D468 Slot: 89
	public override void LoadInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback) { }

	// RVA: 0x414D4A0 Offset: 0x41494A0 VA: 0x414D4A0 Slot: 90
	public override void ShowInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback) { }

	// RVA: 0x414D4D8 Offset: 0x41494D8 VA: 0x414D4D8 Slot: 91
	public override void LoadRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback) { }

	// RVA: 0x414D510 Offset: 0x4149510 VA: 0x414D510 Slot: 92
	public override void ShowRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback) { }

	// RVA: 0x414D548 Offset: 0x4149548 VA: 0x414D548 Slot: 93
	public override void OpenFriendFinderDialog(FacebookDelegate<IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x414D580 Offset: 0x4149580 VA: 0x414D580 Slot: 94
	public override void GetFriendFinderInvitations(FacebookDelegate<IFriendFinderInvitationResult> callback) { }

	// RVA: 0x414D5B8 Offset: 0x41495B8 VA: 0x414D5B8 Slot: 95
	public override void DeleteFriendFinderInvitation(string invitationId, FacebookDelegate<IFriendFinderInvitationResult> callback) { }

	// RVA: 0x414D5F0 Offset: 0x41495F0 VA: 0x414D5F0 Slot: 96
	public override void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, FacebookDelegate<IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x414D628 Offset: 0x4149628 VA: 0x414D628 Slot: 97
	public override void PostSessionScore(int score, FacebookDelegate<ISessionScoreResult> callback) { }

	// RVA: 0x414D660 Offset: 0x4149660 VA: 0x414D660 Slot: 98
	public override void PostTournamentScore(int score, FacebookDelegate<ITournamentScoreResult> callback) { }

	// RVA: 0x414D698 Offset: 0x4149698 VA: 0x414D698 Slot: 99
	public override void GetTournament(FacebookDelegate<ITournamentResult> callback) { }

	// RVA: 0x414D6D0 Offset: 0x41496D0 VA: 0x414D6D0 Slot: 100
	public override void ShareTournament(int score, Dictionary<string, string> data, FacebookDelegate<ITournamentScoreResult> callback) { }

	// RVA: 0x414D708 Offset: 0x4149708 VA: 0x414D708 Slot: 101
	public override void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, Dictionary<string, string> data, FacebookDelegate<ITournamentResult> callback) { }

	// RVA: 0x414D740 Offset: 0x4149740 VA: 0x414D740 Slot: 102
	public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback) { }

	// RVA: 0x414D778 Offset: 0x4149778 VA: 0x414D778 Slot: 103
	public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback) { }

	// RVA: 0x414D7B0 Offset: 0x41497B0 VA: 0x414D7B0 Slot: 104
	public override void GetUserLocale(FacebookDelegate<ILocaleResult> callback) { }

	[CompilerGenerated]
	// RVA: 0x414D7E8 Offset: 0x41497E8 VA: 0x414D7E8
	private void <OnLoginComplete>b__37_0(ResultContainer formattedResponse) { }
}

// Namespace: Facebook.Unity.Canvas
internal class CanvasFacebookGameObject : FacebookGameObject, ICanvasFacebookCallbackHandler, IFacebookCallbackHandler // TypeDefIndex: 24809
{
	// Properties
	protected ICanvasFacebookImplementation CanvasFacebookImpl { get; }

	// Methods

	// RVA: 0x414E158 Offset: 0x414A158 VA: 0x414E158
	protected ICanvasFacebookImplementation get_CanvasFacebookImpl() { }

	// RVA: 0x414E1C4 Offset: 0x414A1C4 VA: 0x414E1C4 Slot: 11
	public void OnPayComplete(string result) { }

	// RVA: 0x414E2AC Offset: 0x414A2AC VA: 0x414E2AC Slot: 12
	public void OnFacebookAuthResponseChange(string message) { }

	// RVA: 0x414E398 Offset: 0x414A398 VA: 0x414E398 Slot: 13
	public void OnUrlResponse(string message) { }

	// RVA: 0x414E44C Offset: 0x414A44C VA: 0x414E44C Slot: 14
	public void OnHideUnity(bool hide) { }

	// RVA: 0x414E500 Offset: 0x414A500 VA: 0x414E500 Slot: 10
	protected override void OnAwake() { }

	// RVA: 0x414E5D4 Offset: 0x414A5D4 VA: 0x414E5D4
	public void .ctor() { }
}

// Namespace: Facebook.Unity.Canvas
internal class CanvasFacebookLoader : FB.CompiledFacebookLoader // TypeDefIndex: 24810
{
	// Properties
	protected override FacebookGameObject FBGameObject { get; }

	// Methods

	// RVA: 0x414E5DC Offset: 0x414A5DC VA: 0x414E5DC Slot: 4
	protected override FacebookGameObject get_FBGameObject() { }

	// RVA: 0x414E674 Offset: 0x414A674 VA: 0x414E674
	public void .ctor() { }
}

// Namespace: Facebook.Unity.Canvas
internal interface ICanvasFacebookCallbackHandler : IFacebookCallbackHandler // TypeDefIndex: 24811
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPayComplete(string message);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnFacebookAuthResponseChange(string message);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnUrlResponse(string message);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnHideUnity(bool hide);
}

// Namespace: Facebook.Unity.Canvas
internal interface ICanvasFacebookImplementation : IPayFacebook, IFacebook, IFacebookWindows, ICanvasFacebookResultHandler, IFacebookResultHandler // TypeDefIndex: 24812
{}

// Namespace: Facebook.Unity.Canvas
internal interface ICanvasFacebookResultHandler : IFacebookResultHandler // TypeDefIndex: 24813
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPayComplete(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnFacebookAuthResponseChange(ResultContainer resultContainer);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnUrlResponse(string message);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnHideUnity(bool hide);
}

// Namespace: Facebook.Unity.Canvas
internal interface ICanvasJSWrapper // TypeDefIndex: 24814
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string GetSDKVersion();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void DisableFullScreen();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Init(string connectFacebookUrl, string locale, int debug, string initParams, int status);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Login(IEnumerable<string> scope, string callback_id);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Logout();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void ActivateApp();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void LogAppEvent(string eventName, Nullable<float> valueToSum, string parameters);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void LogPurchase(float purchaseAmount, string currency, string parameters);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Ui(string x, string uid, string callbackMethodName);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void InitScreenPosition();
}

// Namespace: Facebook.Unity.Canvas
internal class JsBridge : MonoBehaviour // TypeDefIndex: 24815
{
	// Fields
	private ICanvasFacebookCallbackHandler facebook; // 0x20

	// Methods

	// RVA: 0x414E67C Offset: 0x414A67C VA: 0x414E67C
	public void Start() { }

	// RVA: 0x414E6D4 Offset: 0x414A6D4 VA: 0x414E6D4
	public void OnLoginComplete(string responseJsonData = "") { }

	// RVA: 0x414E780 Offset: 0x414A780 VA: 0x414E780
	public void OnFacebookAuthResponseChange(string responseJsonData = "") { }

	// RVA: 0x414E82C Offset: 0x414A82C VA: 0x414E82C
	public void OnPayComplete(string responseJsonData = "") { }

	// RVA: 0x414E8D4 Offset: 0x414A8D4 VA: 0x414E8D4
	public void OnAppRequestsComplete(string responseJsonData = "") { }

	// RVA: 0x414E980 Offset: 0x414A980 VA: 0x414E980
	public void OnShareLinkComplete(string responseJsonData = "") { }

	// RVA: 0x414EA2C Offset: 0x414AA2C VA: 0x414EA2C
	public void OnFacebookFocus(string state) { }

	// RVA: 0x414EB08 Offset: 0x414AB08 VA: 0x414EB08
	public void OnInitComplete(string responseJsonData = "") { }

	// RVA: 0x414EBB0 Offset: 0x414ABB0 VA: 0x414EBB0
	public void OnUrlResponse(string url = "") { }

	// RVA: 0x414EC5C Offset: 0x414AC5C VA: 0x414EC5C
	public void .ctor() { }
}

