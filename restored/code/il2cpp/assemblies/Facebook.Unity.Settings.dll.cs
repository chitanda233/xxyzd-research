// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28890
{}

// Namespace: 
public enum FacebookSettings.BuildTarget // TypeDefIndex: 28891
{
	// Fields
	public int value__; // 0x0
	public const FacebookSettings.BuildTarget StandaloneOSX = 0;
	public const FacebookSettings.BuildTarget StandaloneWindows = 1;
	public const FacebookSettings.BuildTarget iOS = 2;
	public const FacebookSettings.BuildTarget Android = 3;
	public const FacebookSettings.BuildTarget StandaloneWindows64 = 4;
	public const FacebookSettings.BuildTarget WebGL = 5;
	public const FacebookSettings.BuildTarget WSAPlayer = 6;
	public const FacebookSettings.BuildTarget StandaloneLinux64 = 7;
	public const FacebookSettings.BuildTarget PS4 = 8;
	public const FacebookSettings.BuildTarget XboxOne = 9;
	public const FacebookSettings.BuildTarget tvOS = 10;
	public const FacebookSettings.BuildTarget Switch = 11;
	public const FacebookSettings.BuildTarget Stadia = 12;
	public const FacebookSettings.BuildTarget CloudRendering = 13;
	public const FacebookSettings.BuildTarget PS5 = 14;
	public const FacebookSettings.BuildTarget none = 15;
}

// Namespace: 
public sealed class FacebookSettings.OnChangeCallback : MulticastDelegate // TypeDefIndex: 28892
{
	// Methods

	// RVA: 0x413C448 Offset: 0x4138448 VA: 0x413C448
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x413C4E4 Offset: 0x41384E4 VA: 0x413C4E4 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x413C4F8 Offset: 0x41384F8 VA: 0x413C4F8 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x413C518 Offset: 0x4138518 VA: 0x413C518 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[Serializable]
public class FacebookSettings.UrlSchemes // TypeDefIndex: 28893
{
	// Fields
	[SerializeField]
	private List<string> list; // 0x10

	// Properties
	public List<string> Schemes { get; set; }

	// Methods

	// RVA: 0x413C320 Offset: 0x4138320 VA: 0x413C320
	public void .ctor(List<string> schemes) { }

	// RVA: 0x413C524 Offset: 0x4138524 VA: 0x413C524
	public List<string> get_Schemes() { }

	// RVA: 0x413C52C Offset: 0x413852C VA: 0x413C52C
	public void set_Schemes(List<string> value) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FacebookSettings.<>c // TypeDefIndex: 28894
{
	// Fields
	public static readonly FacebookSettings.<>c <>9; // 0x0
	public static Action<FacebookSettings.OnChangeCallback> <>9__85_0; // 0x8

	// Methods

	// RVA: 0x413C534 Offset: 0x4138534 VA: 0x413C534
	private static void .cctor() { }

	// RVA: 0x413C59C Offset: 0x413859C VA: 0x413C59C
	public void .ctor() { }

	// RVA: 0x413C5A4 Offset: 0x41385A4 VA: 0x413C5A4
	internal void <SettingsChanged>b__85_0(FacebookSettings.OnChangeCallback callback) { }
}

// Namespace: Facebook.Unity.Settings
public class FacebookSettings : ScriptableObject // TypeDefIndex: 28895
{
	// Fields
	public const string FacebookSettingsAssetName = "FacebookSettings";
	public const string FacebookSettingsPath = "FacebookSDK/SDK/Resources";
	public const string FacebookSettingsAssetExtension = ".asset";
	private static List<FacebookSettings.OnChangeCallback> onChangeCallbacks; // 0x0
	private static FacebookSettings instance; // 0x8
	[SerializeField]
	private int selectedAppIndex; // 0x18
	[SerializeField]
	private List<string> clientTokens; // 0x20
	[SerializeField]
	private List<string> appIds; // 0x28
	[SerializeField]
	private List<string> appLabels; // 0x30
	[SerializeField]
	private bool cookie; // 0x38
	[SerializeField]
	private bool logging; // 0x39
	[SerializeField]
	private bool status; // 0x3A
	[SerializeField]
	private bool xfbml; // 0x3B
	[SerializeField]
	private bool frictionlessRequests; // 0x3C
	[SerializeField]
	private string androidKeystorePath; // 0x40
	[SerializeField]
	private string iosURLSuffix; // 0x48
	[SerializeField]
	private List<FacebookSettings.UrlSchemes> appLinkSchemes; // 0x50
	[SerializeField]
	private string uploadAccessToken; // 0x58
	[SerializeField]
	private bool autoLogAppEventsEnabled; // 0x60
	[SerializeField]
	private bool advertiserIDCollectionEnabled; // 0x61
	private FacebookSettings.BuildTarget editorBuildTargetName; // 0x64

	// Properties
	public static FacebookSettings.BuildTarget EditorBuildTarget { get; set; }
	public static int SelectedAppIndex { get; set; }
	public static List<string> AppIds { get; set; }
	public static List<string> AppLabels { get; set; }
	public static List<string> ClientTokens { get; set; }
	public static string AppId { get; }
	public static string ClientToken { get; }
	public static bool IsValidAppId { get; }
	public static bool Cookie { get; set; }
	public static bool Logging { get; set; }
	public static bool Status { get; set; }
	public static bool Xfbml { get; set; }
	public static string AndroidKeystorePath { get; set; }
	public static string IosURLSuffix { get; set; }
	public static string ChannelUrl { get; }
	public static bool FrictionlessRequests { get; set; }
	public static List<FacebookSettings.UrlSchemes> AppLinkSchemes { get; set; }
	public static string UploadAccessToken { get; set; }
	public static bool AutoLogAppEventsEnabled { get; set; }
	public static bool AdvertiserIDCollectionEnabled { get; set; }
	public static FacebookSettings Instance { get; }
	public static FacebookSettings NullableInstance { get; }

	// Methods

	// RVA: 0x413A96C Offset: 0x413696C VA: 0x413A96C
	public static FacebookSettings.BuildTarget get_EditorBuildTarget() { }

	// RVA: 0x413AAD8 Offset: 0x4136AD8 VA: 0x413AAD8
	public static void set_EditorBuildTarget(FacebookSettings.BuildTarget value) { }

	// RVA: 0x413AB38 Offset: 0x4136B38 VA: 0x413AB38
	public static int get_SelectedAppIndex() { }

	// RVA: 0x413AB94 Offset: 0x4136B94 VA: 0x413AB94
	public static void set_SelectedAppIndex(int value) { }

	// RVA: 0x413AD54 Offset: 0x4136D54 VA: 0x413AD54
	public static List<string> get_AppIds() { }

	// RVA: 0x413ADB0 Offset: 0x4136DB0 VA: 0x413ADB0
	public static void set_AppIds(List<string> value) { }

	// RVA: 0x413AE48 Offset: 0x4136E48 VA: 0x413AE48
	public static List<string> get_AppLabels() { }

	// RVA: 0x413AEA4 Offset: 0x4136EA4 VA: 0x413AEA4
	public static void set_AppLabels(List<string> value) { }

	// RVA: 0x413AF3C Offset: 0x4136F3C VA: 0x413AF3C
	public static List<string> get_ClientTokens() { }

	// RVA: 0x413AF98 Offset: 0x4136F98 VA: 0x413AF98
	public static void set_ClientTokens(List<string> value) { }

	// RVA: 0x413B030 Offset: 0x4137030 VA: 0x413B030
	public static string get_AppId() { }

	// RVA: 0x413B0BC Offset: 0x41370BC VA: 0x413B0BC
	public static string get_ClientToken() { }

	// RVA: 0x413B148 Offset: 0x4137148 VA: 0x413B148
	public static bool get_IsValidAppId() { }

	// RVA: 0x413B20C Offset: 0x413720C VA: 0x413B20C
	public static bool get_Cookie() { }

	// RVA: 0x413B268 Offset: 0x4137268 VA: 0x413B268
	public static void set_Cookie(bool value) { }

	// RVA: 0x413B2FC Offset: 0x41372FC VA: 0x413B2FC
	public static bool get_Logging() { }

	// RVA: 0x413B358 Offset: 0x4137358 VA: 0x413B358
	public static void set_Logging(bool value) { }

	// RVA: 0x413B3EC Offset: 0x41373EC VA: 0x413B3EC
	public static bool get_Status() { }

	// RVA: 0x413B448 Offset: 0x4137448 VA: 0x413B448
	public static void set_Status(bool value) { }

	// RVA: 0x413B4DC Offset: 0x41374DC VA: 0x413B4DC
	public static bool get_Xfbml() { }

	// RVA: 0x413B538 Offset: 0x4137538 VA: 0x413B538
	public static void set_Xfbml(bool value) { }

	// RVA: 0x413B5CC Offset: 0x41375CC VA: 0x413B5CC
	public static string get_AndroidKeystorePath() { }

	// RVA: 0x413B628 Offset: 0x4137628 VA: 0x413B628
	public static void set_AndroidKeystorePath(string value) { }

	// RVA: 0x413B6C8 Offset: 0x41376C8 VA: 0x413B6C8
	public static string get_IosURLSuffix() { }

	// RVA: 0x413B724 Offset: 0x4137724 VA: 0x413B724
	public static void set_IosURLSuffix(string value) { }

	// RVA: 0x413B7C4 Offset: 0x41377C4 VA: 0x413B7C4
	public static string get_ChannelUrl() { }

	// RVA: 0x413B804 Offset: 0x4137804 VA: 0x413B804
	public static bool get_FrictionlessRequests() { }

	// RVA: 0x413B860 Offset: 0x4137860 VA: 0x413B860
	public static void set_FrictionlessRequests(bool value) { }

	// RVA: 0x413B8F4 Offset: 0x41378F4 VA: 0x413B8F4
	public static List<FacebookSettings.UrlSchemes> get_AppLinkSchemes() { }

	// RVA: 0x413B950 Offset: 0x4137950 VA: 0x413B950
	public static void set_AppLinkSchemes(List<FacebookSettings.UrlSchemes> value) { }

	// RVA: 0x413B9E8 Offset: 0x41379E8 VA: 0x413B9E8
	public static string get_UploadAccessToken() { }

	// RVA: 0x413BA44 Offset: 0x4137A44 VA: 0x413BA44
	public static void set_UploadAccessToken(string value) { }

	// RVA: 0x413BAE4 Offset: 0x4137AE4 VA: 0x413BAE4
	public static bool get_AutoLogAppEventsEnabled() { }

	// RVA: 0x413BB40 Offset: 0x4137B40 VA: 0x413BB40
	public static void set_AutoLogAppEventsEnabled(bool value) { }

	// RVA: 0x413BBD4 Offset: 0x4137BD4 VA: 0x413BBD4
	public static bool get_AdvertiserIDCollectionEnabled() { }

	// RVA: 0x413BC30 Offset: 0x4137C30 VA: 0x413BC30
	public static void set_AdvertiserIDCollectionEnabled(bool value) { }

	// RVA: 0x413A9C8 Offset: 0x41369C8 VA: 0x413A9C8
	public static FacebookSettings get_Instance() { }

	// RVA: 0x413BCC4 Offset: 0x4137CC4 VA: 0x413BCC4
	public static FacebookSettings get_NullableInstance() { }

	// RVA: 0x413BE30 Offset: 0x4137E30 VA: 0x413BE30
	public static void RegisterChangeEventCallback(FacebookSettings.OnChangeCallback callback) { }

	// RVA: 0x413BF04 Offset: 0x4137F04 VA: 0x413BF04
	public static void UnregisterChangeEventCallback(FacebookSettings.OnChangeCallback callback) { }

	// RVA: 0x413AC24 Offset: 0x4136C24 VA: 0x413AC24
	private static void SettingsChanged() { }

	// RVA: 0x413BF84 Offset: 0x4137F84 VA: 0x413BF84
	public void .ctor() { }

	// RVA: 0x413C3B0 Offset: 0x41383B0 VA: 0x413C3B0
	private static void .cctor() { }
}

