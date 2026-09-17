// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28843
{}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 28844
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
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 28845
{
	// Methods

	// RVA: 0x641E8D8 Offset: 0x641A8D8 VA: 0x641E8D8
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x641E9CC Offset: 0x641A9CC VA: 0x641E9CC
	public void .ctor() { }
}

// Namespace: GorillaCrashBugly.Runtime
[Preserve]
[CreateAssetMenu(fileName = "BuglyCrashReportConfig", menuName = "GorillaSDK/Bugly Crash Report Config")]
[Serializable]
public class BuglyCrashReportConfig : ScriptableObject // TypeDefIndex: 28846
{
	// Fields
	public const string Path = "Assets/Resources/GorillaSDK/BuglyCrashReportConfig";
	public const string LoadPath = "GorillaSDK/BuglyCrashReportConfig";
	[Header("Bugly App ID")]
	[Preserve]
	public string iOSAppId; // 0x18
	[Preserve]
	public string androidAppId; // 0x20
	[Preserve]
	[Header("Runtime")]
	public bool enableDebug; // 0x28
	[Preserve]
	public bool reportUnityErrors; // 0x29
	[Preserve]
	public bool reportUnityExceptions; // 0x2A
	[Header("Metadata")]
	[Preserve]
	public string channel; // 0x30
	[Preserve]
	public string appVersion; // 0x38

	// Properties
	public string AppId { get; }

	// Methods

	// RVA: 0x641E9D4 Offset: 0x641A9D4 VA: 0x641E9D4
	public string get_AppId() { }

	// RVA: 0x641E9DC Offset: 0x641A9DC VA: 0x641E9DC
	public static BuglyCrashReportConfig Load() { }

	// RVA: 0x641EA34 Offset: 0x641AA34 VA: 0x641EA34
	public void .ctor() { }
}

// Namespace: GorillaCrashBugly.Runtime
public sealed class BuglyCrashReporterAdapter : ICrashReporter // TypeDefIndex: 28847
{
	// Fields
	private const string Tag = "[BuglyCrashReporterAdapter]";
	private const int UnityExceptionCategory = 4;
	private BuglyCrashReportConfig _config; // 0x10
	private bool _logCallbackRegistered; // 0x18
	[CompilerGenerated]
	private bool <IsInitialized>k__BackingField; // 0x19

	// Properties
	public bool IsInitialized { get; set; }
	private static AndroidJavaObject CurrentActivity { get; }
	private static AndroidJavaObject ApplicationContext { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x641EA44 Offset: 0x641AA44 VA: 0x641EA44 Slot: 9
	public bool get_IsInitialized() { }

	[CompilerGenerated]
	// RVA: 0x641EA4C Offset: 0x641AA4C VA: 0x641EA4C
	private void set_IsInitialized(bool value) { }

	// RVA: 0x641EA58 Offset: 0x641AA58 VA: 0x641EA58 Slot: 4
	public void Init(object data) { }

	// RVA: 0x641F214 Offset: 0x641B214 VA: 0x641F214 Slot: 5
	public void SetUserId(string userId) { }

	// RVA: 0x641F638 Offset: 0x641B638 VA: 0x641F638 Slot: 6
	public void SetCustomKey(string key, string value) { }

	// RVA: 0x641FB98 Offset: 0x641BB98 VA: 0x641FB98 Slot: 7
	public void RecordException(Exception exception) { }

	// RVA: 0x641FC30 Offset: 0x641BC30 VA: 0x641FC30 Slot: 8
	public void ReportLog(string log) { }

	// RVA: 0x641F288 Offset: 0x641B288 VA: 0x641F288
	private bool CheckInitialized() { }

	// RVA: 0x641F134 Offset: 0x641B134 VA: 0x641F134
	private void RegisterUnityLogCallback() { }

	// RVA: 0x642001C Offset: 0x641C01C VA: 0x642001C
	private void OnLogMessage(string condition, string stackTrace, LogType type) { }

	// RVA: 0x641FC20 Offset: 0x641BC20 VA: 0x641FC20
	private void ReportException(string name, string reason, string stackTrace) { }

	// RVA: 0x642079C Offset: 0x641C79C VA: 0x642079C
	private static AndroidJavaObject get_CurrentActivity() { }

	// RVA: 0x642097C Offset: 0x641C97C VA: 0x642097C
	private static AndroidJavaObject get_ApplicationContext() { }

	// RVA: 0x641EBF4 Offset: 0x641ABF4 VA: 0x641EBF4
	private static bool InitAndroid(string appId, bool enableDebug) { }

	// RVA: 0x641F308 Offset: 0x641B308 VA: 0x641F308
	private static void TryCallAndroid(string methodName, string value) { }

	// RVA: 0x641F6C4 Offset: 0x641B6C4 VA: 0x641F6C4
	private static void TryPutAndroidUserData(string key, string value) { }

	// RVA: 0x642012C Offset: 0x641C12C VA: 0x642012C
	private static void TryPostAndroidException(string name, string reason, string stackTrace) { }

	// RVA: 0x641FCBC Offset: 0x641BCBC VA: 0x641FCBC
	private static void TryCallAndroidLog(string methodName, string tag, string log) { }

	// RVA: 0x6420B88 Offset: 0x641CB88 VA: 0x6420B88
	public void .ctor() { }
}

// Namespace: GorillaCrashBugly.Runtime
internal static class BuglyCrashReporterInjector // TypeDefIndex: 28848
{
	// Methods

	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x6420B90 Offset: 0x641CB90 VA: 0x6420B90
	internal static void Initialize() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=166 // TypeDefIndex: 28849
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=286 // TypeDefIndex: 28850
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 28851
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=286 6F69ADBF7BEB5C1AFE9D79648A75918CD2F7FA8DCD5F92B3F9403CD5FF8CDB07 /*Metadata offset 0xF55758*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=166 D7DA6669115B491840C7F949365346DF81428F03D307F502D425C85755058E5E /*Metadata offset 0xF55878*/; // 0x11E
}

