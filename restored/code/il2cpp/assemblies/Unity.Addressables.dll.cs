// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 26155
{}

// Namespace: 
[Serializable]
public struct PackedPlayModeBuildLogs.RuntimeBuildLog // TypeDefIndex: 26156
{
	// Fields
	public LogType Type; // 0x0
	public string Message; // 0x8

	// Methods

	// RVA: 0x85085C0 Offset: 0x85045C0 VA: 0x85085C0
	public void .ctor(LogType type, string message) { }
}

// Namespace: 
[Serializable]
public class PackedPlayModeBuildLogs // TypeDefIndex: 26157
{
	// Fields
	[SerializeField]
	private List<PackedPlayModeBuildLogs.RuntimeBuildLog> m_RuntimeBuildLogs; // 0x10

	// Properties
	public List<PackedPlayModeBuildLogs.RuntimeBuildLog> RuntimeBuildLogs { get; set; }

	// Methods

	// RVA: 0x8508528 Offset: 0x8504528 VA: 0x8508528
	public List<PackedPlayModeBuildLogs.RuntimeBuildLog> get_RuntimeBuildLogs() { }

	// RVA: 0x8508530 Offset: 0x8504530 VA: 0x8508530
	public void set_RuntimeBuildLogs(List<PackedPlayModeBuildLogs.RuntimeBuildLog> value) { }

	// RVA: 0x8508538 Offset: 0x8504538 VA: 0x8508538
	public void .ctor() { }
}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 26158
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
[CompilerGenerated]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 26159
{
	// Methods

	// RVA: 0x85085D0 Offset: 0x85045D0 VA: 0x85085D0
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x85086C8 Offset: 0x85046C8 VA: 0x85086C8
	public void .ctor() { }
}

// Namespace: UnityEngine
[Usage(384, AllowMultiple = True)]
public class AssetReferenceUIRestriction : Attribute // TypeDefIndex: 26160
{
	// Methods

	// RVA: 0x85086D0 Offset: 0x85046D0 VA: 0x85086D0 Slot: 11
	public virtual bool ValidateAsset(Object obj) { }

	// RVA: 0x85086D8 Offset: 0x85046D8 VA: 0x85086D8 Slot: 12
	public virtual bool ValidateAsset(string path) { }

	// RVA: 0x85086E0 Offset: 0x85046E0 VA: 0x85086E0
	public void .ctor() { }
}

// Namespace: UnityEngine
[Usage(384, AllowMultiple = False)]
public sealed class AssetReferenceUILabelRestriction : AssetReferenceUIRestriction // TypeDefIndex: 26161
{
	// Fields
	public string[] m_AllowedLabels; // 0x10
	public string m_CachedToString; // 0x18

	// Methods

	// RVA: 0x85086E8 Offset: 0x85046E8 VA: 0x85086E8
	public void .ctor(string[] allowedLabels) { }

	// RVA: 0x8508718 Offset: 0x8504718 VA: 0x8508718 Slot: 11
	public override bool ValidateAsset(Object obj) { }

	// RVA: 0x8508720 Offset: 0x8504720 VA: 0x8508720 Slot: 12
	public override bool ValidateAsset(string path) { }

	// RVA: 0x8508728 Offset: 0x8504728 VA: 0x8508728 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
internal class InitalizationObjectsOperation : AsyncOperationBase<bool> // TypeDefIndex: 26162
{
	// Fields
	private AsyncOperationHandle<ResourceManagerRuntimeData> m_RtdOp; // 0x98
	private AddressablesImpl m_Addressables; // 0xB0
	private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp; // 0xB8

	// Properties
	protected override string DebugName { get; }

	// Methods

	// RVA: 0x850883C Offset: 0x850483C VA: 0x850883C
	public void Init(AsyncOperationHandle<ResourceManagerRuntimeData> rtdOp, AddressablesImpl addressables) { }

	// RVA: 0x850889C Offset: 0x850489C VA: 0x850889C Slot: 31
	protected override string get_DebugName() { }

	// RVA: 0x85088DC Offset: 0x85048DC VA: 0x85088DC
	internal bool LogRuntimeWarnings(string pathToBuildLogs) { }

	// RVA: 0x8508C10 Offset: 0x8504C10 VA: 0x8508C10 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x8508DB0 Offset: 0x8504DB0 VA: 0x8508DB0 Slot: 28
	protected override void Execute() { }

	// RVA: 0x85094E8 Offset: 0x85054E8 VA: 0x85094E8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x8509530 Offset: 0x8505530 VA: 0x8509530
	private void <Execute>b__8_0(AsyncOperationHandle<IList<AsyncOperationHandle>> obj) { }
}

// Namespace: UnityEngine.AddressableAssets
public class ResourceLocatorInfo // TypeDefIndex: 26163
{
	// Fields
	[CompilerGenerated]
	private IResourceLocator <Locator>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <LocalHash>k__BackingField; // 0x18
	[CompilerGenerated]
	private IResourceLocation <CatalogLocation>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <ContentUpdateAvailable>k__BackingField; // 0x28

	// Properties
	public IResourceLocator Locator { get; set; }
	public string LocalHash { get; set; }
	public IResourceLocation CatalogLocation { get; set; }
	internal bool ContentUpdateAvailable { get; set; }
	public IResourceLocation HashLocation { get; }
	public bool CanUpdateContent { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x85096BC Offset: 0x85056BC VA: 0x85096BC
	public IResourceLocator get_Locator() { }

	[CompilerGenerated]
	// RVA: 0x85096C4 Offset: 0x85056C4 VA: 0x85096C4
	private void set_Locator(IResourceLocator value) { }

	[CompilerGenerated]
	// RVA: 0x85096CC Offset: 0x85056CC VA: 0x85096CC
	public string get_LocalHash() { }

	[CompilerGenerated]
	// RVA: 0x85096D4 Offset: 0x85056D4 VA: 0x85096D4
	private void set_LocalHash(string value) { }

	[CompilerGenerated]
	// RVA: 0x85096DC Offset: 0x85056DC VA: 0x85096DC
	public IResourceLocation get_CatalogLocation() { }

	[CompilerGenerated]
	// RVA: 0x85096E4 Offset: 0x85056E4 VA: 0x85096E4
	private void set_CatalogLocation(IResourceLocation value) { }

	[CompilerGenerated]
	// RVA: 0x85096EC Offset: 0x85056EC VA: 0x85096EC
	internal bool get_ContentUpdateAvailable() { }

	[CompilerGenerated]
	// RVA: 0x85096F4 Offset: 0x85056F4 VA: 0x85096F4
	internal void set_ContentUpdateAvailable(bool value) { }

	// RVA: 0x8509700 Offset: 0x8505700 VA: 0x8509700
	public void .ctor(IResourceLocator loc, string localHash, IResourceLocation remoteCatalogLocation) { }

	// RVA: 0x8509760 Offset: 0x8505760 VA: 0x8509760
	public IResourceLocation get_HashLocation() { }

	// RVA: 0x850987C Offset: 0x850587C VA: 0x850987C
	public bool get_CanUpdateContent() { }

	// RVA: 0x8509A20 Offset: 0x8505A20 VA: 0x8509A20
	internal void UpdateContent(IResourceLocator locator, string hash, IResourceLocation loc) { }
}

// Namespace: UnityEngine.AddressableAssets
public class InvalidKeyException : Exception // TypeDefIndex: 26164
{
	// Fields
	[CompilerGenerated]
	private object <Key>k__BackingField; // 0x90
	[CompilerGenerated]
	private Type <Type>k__BackingField; // 0x98
	[CompilerGenerated]
	private readonly Nullable<Addressables.MergeMode> <MergeMode>k__BackingField; // 0xA0
	private AddressablesImpl m_Addressables; // 0xA8
	private const string BaseInvalidKeyMessageFormat = "{0}, Key={1}, Type={2}";

	// Properties
	public object Key { get; set; }
	public Type Type { get; set; }
	public Nullable<Addressables.MergeMode> MergeMode { get; }
	public override string Message { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8509A68 Offset: 0x8505A68 VA: 0x8509A68
	public object get_Key() { }

	[CompilerGenerated]
	// RVA: 0x8509A70 Offset: 0x8505A70 VA: 0x8509A70
	private void set_Key(object value) { }

	[CompilerGenerated]
	// RVA: 0x8509A78 Offset: 0x8505A78 VA: 0x8509A78
	public Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x8509A80 Offset: 0x8505A80 VA: 0x8509A80
	private void set_Type(Type value) { }

	[CompilerGenerated]
	// RVA: 0x8509A88 Offset: 0x8505A88 VA: 0x8509A88
	public Nullable<Addressables.MergeMode> get_MergeMode() { }

	// RVA: 0x8509A90 Offset: 0x8505A90 VA: 0x8509A90
	public void .ctor(object key) { }

	// RVA: 0x8509B1C Offset: 0x8505B1C VA: 0x8509B1C
	public void .ctor(object key, Type type) { }

	// RVA: 0x8509BA4 Offset: 0x8505BA4 VA: 0x8509BA4
	internal void .ctor(object key, Type type, AddressablesImpl addr) { }

	// RVA: 0x8509C48 Offset: 0x8505C48 VA: 0x8509C48
	public void .ctor(object key, Type type, Addressables.MergeMode mergeMode) { }

	// RVA: 0x8509D10 Offset: 0x8505D10 VA: 0x8509D10
	internal void .ctor(object key, Type type, Addressables.MergeMode mergeMode, AddressablesImpl addr) { }

	// RVA: 0x8509DF4 Offset: 0x8505DF4 VA: 0x8509DF4
	public void .ctor() { }

	// RVA: 0x8509E4C Offset: 0x8505E4C VA: 0x8509E4C
	public void .ctor(string message) { }

	// RVA: 0x8509EB4 Offset: 0x8505EB4 VA: 0x8509EB4
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x8509F24 Offset: 0x8505F24 VA: 0x8509F24
	protected void .ctor(SerializationInfo message, StreamingContext context) { }

	// RVA: 0x8509FA4 Offset: 0x8505FA4 VA: 0x8509FA4 Slot: 5
	public override string get_Message() { }

	// RVA: 0x850A6B4 Offset: 0x85066B4 VA: 0x850A6B4
	private string GetMessageForSingleKey(string keyString) { }

	// RVA: 0x850C280 Offset: 0x8508280 VA: 0x850C280
	private string GetNotFoundMessage(string keyString) { }

	// RVA: 0x850C2E4 Offset: 0x85082E4 VA: 0x850C2E4
	private string GetTypeNotAssignableMessage(string keyString, HashSet<Type> typesAvailableForKey) { }

	// RVA: 0x850C5F8 Offset: 0x85085F8 VA: 0x850C5F8
	private string GetMultipleAssignableTypesMessage(string keyString, HashSet<Type> typesAvailableForKey) { }

	// RVA: 0x850AB14 Offset: 0x8506B14 VA: 0x850AB14
	private string GetMessageforMergeKeys(List<string> keys) { }

	// RVA: 0x850BB68 Offset: 0x8507B68 VA: 0x850BB68
	private HashSet<Type> GetTypesForKey(string keyString) { }

	// RVA: 0x850C930 Offset: 0x8508930 VA: 0x850C930
	private bool GetTypeToKeys(string key, Dictionary<Type, List<string>> typeToKeys) { }

	// RVA: 0x850A738 Offset: 0x8506738 VA: 0x850A738
	private string GetCSVString(IEnumerable<string> enumerator, string prefixSingle, string prefixPlural) { }
}

// Namespace: 
public enum Addressables.MergeMode // TypeDefIndex: 26165
{
	// Fields
	public int value__; // 0x0
	public const Addressables.MergeMode None = 0;
	public const Addressables.MergeMode UseFirst = 0;
	public const Addressables.MergeMode Union = 1;
	public const Addressables.MergeMode Intersection = 2;
}

// Namespace: UnityEngine.AddressableAssets
public static class Addressables // TypeDefIndex: 26166
{
	// Fields
	internal static bool reinitializeAddressables; // 0x0
	internal static AddressablesImpl m_AddressablesInstance; // 0x8
	public const string kAddressablesRuntimeDataPath = "AddressablesRuntimeDataPath";
	private const string k_AddressablesLogConditional = "ADDRESSABLES_LOG_ALL";
	public const string kAddressablesRuntimeBuildLogPath = "AddressablesRuntimeBuildLog";
	public static string LibraryPath; // 0x10
	public static string BuildReportPath; // 0x18

	// Properties
	private static AddressablesImpl m_Addressables { get; }
	public static string Version { get; }
	public static ResourceManager ResourceManager { get; }
	internal static AddressablesImpl Instance { get; }
	public static IInstanceProvider InstanceProvider { get; }
	public static Func<IResourceLocation, string> InternalIdTransformFunc { get; set; }
	public static Action<UnityWebRequest> WebRequestOverride { get; set; }
	public static string StreamingAssetsSubFolder { get; }
	public static string BuildPath { get; }
	public static string PlayerBuildDataPath { get; }
	public static string RuntimePath { get; }
	public static IEnumerable<IResourceLocator> ResourceLocators { get; }
	[Obsolete]
	public static AsyncOperationHandle<IResourceLocator> InitializationOperation { get; }

	// Methods

	// RVA: 0x850CD54 Offset: 0x8508D54 VA: 0x850CD54
	private static AddressablesImpl get_m_Addressables() { }

	// RVA: 0x850CDAC Offset: 0x8508DAC VA: 0x850CDAC
	public static string get_Version() { }

	// RVA: 0x850CDEC Offset: 0x8508DEC VA: 0x850CDEC
	public static ResourceManager get_ResourceManager() { }

	// RVA: 0x850CE80 Offset: 0x8508E80 VA: 0x850CE80
	internal static AddressablesImpl get_Instance() { }

	// RVA: 0x850CF08 Offset: 0x8508F08 VA: 0x850CF08
	public static IInstanceProvider get_InstanceProvider() { }

	// RVA: 0x850CF9C Offset: 0x8508F9C VA: 0x850CF9C
	public static string ResolveInternalId(string id) { }

	// RVA: 0x850D088 Offset: 0x8509088 VA: 0x850D088
	public static Func<IResourceLocation, string> get_InternalIdTransformFunc() { }

	// RVA: 0x850D140 Offset: 0x8509140 VA: 0x850D140
	public static void set_InternalIdTransformFunc(Func<IResourceLocation, string> value) { }

	// RVA: 0x850D200 Offset: 0x8509200 VA: 0x850D200
	public static Action<UnityWebRequest> get_WebRequestOverride() { }

	// RVA: 0x850D2B8 Offset: 0x85092B8 VA: 0x850D2B8
	public static void set_WebRequestOverride(Action<UnityWebRequest> value) { }

	// RVA: 0x850D378 Offset: 0x8509378 VA: 0x850D378
	public static string get_StreamingAssetsSubFolder() { }

	// RVA: 0x850D474 Offset: 0x8509474 VA: 0x850D474
	public static string get_BuildPath() { }

	// RVA: 0x850D5E0 Offset: 0x85095E0 VA: 0x850D5E0
	public static string get_PlayerBuildDataPath() { }

	// RVA: 0x850D71C Offset: 0x850971C VA: 0x850D71C
	public static string get_RuntimePath() { }

	// RVA: 0x850D7B0 Offset: 0x85097B0 VA: 0x850D7B0
	public static IEnumerable<IResourceLocator> get_ResourceLocators() { }

	[Conditional("ADDRESSABLES_LOG_ALL")]
	// RVA: 0x850D840 Offset: 0x8509840 VA: 0x850D840
	internal static void InternalSafeSerializationLog(string msg, LogType logType = 3) { }

	[Conditional("ADDRESSABLES_LOG_ALL")]
	// RVA: 0x850DA5C Offset: 0x8509A5C VA: 0x850DA5C
	internal static void InternalSafeSerializationLogFormat(string format, LogType logType = 3, object[] args) { }

	[Conditional("ADDRESSABLES_LOG_ALL")]
	// RVA: 0x850DCB8 Offset: 0x8509CB8 VA: 0x850DCB8
	public static void Log(string msg) { }

	[Conditional("ADDRESSABLES_LOG_ALL")]
	// RVA: 0x850DD50 Offset: 0x8509D50 VA: 0x850DD50
	public static void LogFormat(string format, object[] args) { }

	// RVA: 0x8508AE0 Offset: 0x8504AE0 VA: 0x8508AE0
	public static void LogWarning(string msg) { }

	// RVA: 0x850DDF8 Offset: 0x8509DF8 VA: 0x850DDF8
	public static void LogWarningFormat(string format, object[] args) { }

	// RVA: 0x8508B78 Offset: 0x8504B78 VA: 0x8508B78
	public static void LogError(string msg) { }

	// RVA: 0x850DEA0 Offset: 0x8509EA0 VA: 0x850DEA0
	public static void LogException(AsyncOperationHandle op, Exception ex) { }

	// RVA: 0x850E010 Offset: 0x850A010 VA: 0x850E010
	public static void LogException(Exception ex) { }

	// RVA: 0x8509440 Offset: 0x8505440 VA: 0x8509440
	public static void LogErrorFormat(string format, object[] args) { }

	[Obsolete]
	// RVA: 0x850E0A4 Offset: 0x850A0A4 VA: 0x850E0A4
	public static AsyncOperationHandle<IResourceLocator> Initialize() { }

	// RVA: 0x850E114 Offset: 0x850A114 VA: 0x850E114
	public static AsyncOperationHandle<IResourceLocator> InitializeAsync() { }

	// RVA: 0x850E258 Offset: 0x850A258 VA: 0x850E258
	public static AsyncOperationHandle<IResourceLocator> InitializeAsync(bool autoReleaseHandle) { }

	[Obsolete]
	// RVA: 0x850E3B0 Offset: 0x850A3B0 VA: 0x850E3B0
	public static AsyncOperationHandle<IResourceLocator> LoadContentCatalog(string catalogPath, string providerSuffix) { }

	// RVA: 0x850E438 Offset: 0x850A438 VA: 0x850E438
	public static AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, string providerSuffix) { }

	// RVA: 0x850E6FC Offset: 0x850A6FC VA: 0x850E6FC
	public static AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, bool autoReleaseHandle, string providerSuffix) { }

	// RVA: 0x850E7D4 Offset: 0x850A7D4 VA: 0x850E7D4
	public static AsyncOperationHandle<IResourceLocator> get_InitializationOperation() { }

	[Obsolete]
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<TObject> LoadAsset<TObject>(IResourceLocation location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B78B4 Offset: 0x44B38B4 VA: 0x44B78B4
	|-Addressables.LoadAsset<__Il2CppFullySharedGenericType>
	*/

	[Obsolete]
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<TObject> LoadAsset<TObject>(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B7940 Offset: 0x44B3940 VA: 0x44B7940
	|-Addressables.LoadAsset<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(IResourceLocation location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B7AA0 Offset: 0x44B3AA0 VA: 0x44B7AA0
	|-Addressables.LoadAssetAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B79CC Offset: 0x44B39CC VA: 0x44B79CC
	|-Addressables.LoadAssetAsync<object>
	|
	|-RVA: 0x44B7B78 Offset: 0x44B3B78 VA: 0x44B7B78
	|-Addressables.LoadAssetAsync<__Il2CppFullySharedGenericType>
	*/

	[Obsolete]
	// RVA: 0x850E7E0 Offset: 0x850A7E0 VA: 0x850E7E0
	public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocations(IList<object> keys, Addressables.MergeMode mode, Type type) { }

	[Obsolete]
	// RVA: 0x850E874 Offset: 0x850A874 VA: 0x850E874
	public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(IList<object> keys, Addressables.MergeMode mode, Type type) { }

	// RVA: 0x850EAD8 Offset: 0x850AAD8 VA: 0x850EAD8
	public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(IEnumerable keys, Addressables.MergeMode mode, Type type) { }

	[Obsolete]
	// RVA: 0x850EBB0 Offset: 0x850ABB0 VA: 0x850EBB0
	public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocations(object key, Type type) { }

	// RVA: 0x850EC38 Offset: 0x850AC38 VA: 0x850EC38
	public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(object key, Type type) { }

	[Obsolete]
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssets<TObject>(IList<IResourceLocation> locations, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B7C50 Offset: 0x44B3C50 VA: 0x44B7C50
	|-Addressables.LoadAssets<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<IResourceLocation> locations, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B7E24 Offset: 0x44B3E24 VA: 0x44B7E24
	|-Addressables.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<IResourceLocation> locations, Action<TObject> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B81D0 Offset: 0x44B41D0 VA: 0x44B81D0
	|-Addressables.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	[Obsolete]
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssets<TObject>(IList<object> keys, Action<TObject> callback, Addressables.MergeMode mode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B7D80 Offset: 0x44B3D80 VA: 0x44B7D80
	|-Addressables.LoadAssets<__Il2CppFullySharedGenericType>
	*/

	[Obsolete]
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<object> keys, Action<TObject> callback, Addressables.MergeMode mode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B82C0 Offset: 0x44B42C0 VA: 0x44B82C0
	|-Addressables.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IEnumerable keys, Action<TObject> callback, Addressables.MergeMode mode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B7FF4 Offset: 0x44B3FF4 VA: 0x44B7FF4
	|-Addressables.LoadAssetsAsync<object>
	|
	|-RVA: 0x44B83B4 Offset: 0x44B43B4 VA: 0x44B83B4
	|-Addressables.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	[Obsolete]
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<object> keys, Action<TObject> callback, Addressables.MergeMode mode, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B8690 Offset: 0x44B4690 VA: 0x44B8690
	|-Addressables.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IEnumerable keys, Action<TObject> callback, Addressables.MergeMode mode, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B8598 Offset: 0x44B4598 VA: 0x44B8598
	|-Addressables.LoadAssetsAsync<object>
	|
	|-RVA: 0x44B878C Offset: 0x44B478C VA: 0x44B878C
	|-Addressables.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	[Obsolete]
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssets<TObject>(object key, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B7CE8 Offset: 0x44B3CE8 VA: 0x44B7CE8
	|-Addressables.LoadAssets<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(object key, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B7F0C Offset: 0x44B3F0C VA: 0x44B7F0C
	|-Addressables.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(object key, Action<TObject> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B80E4 Offset: 0x44B40E4 VA: 0x44B80E4
	|-Addressables.LoadAssetsAsync<object>
	|
	|-RVA: 0x44B84A8 Offset: 0x44B44A8 VA: 0x44B84A8
	|-Addressables.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Release<TObject>(TObject obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B88C0 Offset: 0x44B48C0 VA: 0x44B88C0
	|-Addressables.Release<object>
	|
	|-RVA: 0x44B8998 Offset: 0x44B4998 VA: 0x44B8998
	|-Addressables.Release<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Release<TObject>(AsyncOperationHandle<TObject> handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B8888 Offset: 0x44B4888 VA: 0x44B8888
	|-Addressables.Release<long>
	|
	|-RVA: 0x44B8960 Offset: 0x44B4960 VA: 0x44B8960
	|-Addressables.Release<object>
	|
	|-RVA: 0x44B8AEC Offset: 0x44B4AEC VA: 0x44B8AEC
	|-Addressables.Release<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x850EE84 Offset: 0x850AE84 VA: 0x850EE84
	public static void Release(AsyncOperationHandle handle) { }

	// RVA: 0x850EE8C Offset: 0x850AE8C VA: 0x850EE8C
	public static bool ReleaseInstance(GameObject instance) { }

	// RVA: 0x850F010 Offset: 0x850B010 VA: 0x850F010
	public static bool ReleaseInstance(AsyncOperationHandle handle) { }

	// RVA: 0x850F028 Offset: 0x850B028 VA: 0x850F028
	public static bool ReleaseInstance(AsyncOperationHandle<GameObject> handle) { }

	[Obsolete]
	// RVA: 0x850F078 Offset: 0x850B078 VA: 0x850F078
	public static AsyncOperationHandle<long> GetDownloadSize(object key) { }

	// RVA: 0x850F0F4 Offset: 0x850B0F4 VA: 0x850F0F4
	public static AsyncOperationHandle<long> GetDownloadSizeAsync(object key) { }

	// RVA: 0x850F284 Offset: 0x850B284 VA: 0x850F284
	public static AsyncOperationHandle<long> GetDownloadSizeAsync(string key) { }

	[Obsolete]
	// RVA: 0x850F344 Offset: 0x850B344 VA: 0x850F344
	public static AsyncOperationHandle<long> GetDownloadSizeAsync(IList<object> keys) { }

	// RVA: 0x85103B8 Offset: 0x850C3B8 VA: 0x85103B8
	public static AsyncOperationHandle<long> GetDownloadSizeAsync(IEnumerable keys) { }

	[Obsolete]
	// RVA: 0x8510478 Offset: 0x850C478 VA: 0x8510478
	public static AsyncOperationHandle DownloadDependencies(object key) { }

	// RVA: 0x85104F8 Offset: 0x850C4F8 VA: 0x85104F8
	public static AsyncOperationHandle DownloadDependenciesAsync(object key, bool autoReleaseHandle = False) { }

	// RVA: 0x8510824 Offset: 0x850C824 VA: 0x8510824
	public static AsyncOperationHandle DownloadDependenciesAsync(IList<IResourceLocation> locations, bool autoReleaseHandle = False) { }

	[Obsolete]
	// RVA: 0x8510A2C Offset: 0x850CA2C VA: 0x8510A2C
	public static AsyncOperationHandle DownloadDependenciesAsync(IList<object> keys, Addressables.MergeMode mode, bool autoReleaseHandle = False) { }

	// RVA: 0x8510D80 Offset: 0x850CD80 VA: 0x8510D80
	public static AsyncOperationHandle DownloadDependenciesAsync(IEnumerable keys, Addressables.MergeMode mode, bool autoReleaseHandle = False) { }

	// RVA: 0x8510E58 Offset: 0x850CE58 VA: 0x8510E58
	public static void ClearDependencyCacheAsync(object key) { }

	// RVA: 0x8511160 Offset: 0x850D160 VA: 0x8511160
	public static void ClearDependencyCacheAsync(IList<IResourceLocation> locations) { }

	[Obsolete]
	// RVA: 0x851171C Offset: 0x850D71C VA: 0x851171C
	public static void ClearDependencyCacheAsync(IList<object> keys) { }

	// RVA: 0x8511CE8 Offset: 0x850DCE8 VA: 0x8511CE8
	public static void ClearDependencyCacheAsync(IEnumerable keys) { }

	// RVA: 0x8511D94 Offset: 0x850DD94 VA: 0x8511D94
	public static void ClearDependencyCacheAsync(string key) { }

	// RVA: 0x8511E40 Offset: 0x850DE40 VA: 0x8511E40
	public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(object key, bool autoReleaseHandle) { }

	// RVA: 0x8511F0C Offset: 0x850DF0C VA: 0x8511F0C
	public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(IList<IResourceLocation> locations, bool autoReleaseHandle) { }

	[Obsolete]
	// RVA: 0x8511FD8 Offset: 0x850DFD8 VA: 0x8511FD8
	public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(IList<object> keys, bool autoReleaseHandle) { }

	// RVA: 0x85120A4 Offset: 0x850E0A4 VA: 0x85120A4
	public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(IEnumerable keys, bool autoReleaseHandle) { }

	// RVA: 0x8512170 Offset: 0x850E170 VA: 0x8512170
	public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(string key, bool autoReleaseHandle) { }

	// RVA: 0x851223C Offset: 0x850E23C VA: 0x851223C
	public static ResourceLocatorInfo GetLocatorInfo(string locatorId) { }

	// RVA: 0x85124C4 Offset: 0x850E4C4 VA: 0x85124C4
	public static ResourceLocatorInfo GetLocatorInfo(IResourceLocator locator) { }

	[Obsolete]
	// RVA: 0x85125D0 Offset: 0x850E5D0 VA: 0x85125D0
	public static AsyncOperationHandle<GameObject> Instantiate(IResourceLocation location, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	[Obsolete]
	// RVA: 0x8512798 Offset: 0x850E798 VA: 0x8512798
	public static AsyncOperationHandle<GameObject> Instantiate(IResourceLocation location, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	[Obsolete]
	// RVA: 0x85129BC Offset: 0x850E9BC VA: 0x85129BC
	public static AsyncOperationHandle<GameObject> Instantiate(object key, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	[Obsolete]
	// RVA: 0x8512B40 Offset: 0x850EB40 VA: 0x8512B40
	public static AsyncOperationHandle<GameObject> Instantiate(object key, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	[Obsolete]
	// RVA: 0x8512D64 Offset: 0x850ED64 VA: 0x8512D64
	public static AsyncOperationHandle<GameObject> Instantiate(object key, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	[Obsolete]
	// RVA: 0x8512F18 Offset: 0x850EF18 VA: 0x8512F18
	public static AsyncOperationHandle<GameObject> Instantiate(IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x8512FD0 Offset: 0x850EFD0 VA: 0x8512FD0
	public static AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	// RVA: 0x8512888 Offset: 0x850E888 VA: 0x8512888
	public static AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	// RVA: 0x8512A5C Offset: 0x850EA5C VA: 0x8512A5C
	public static AsyncOperationHandle<GameObject> InstantiateAsync(object key, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	// RVA: 0x8512C30 Offset: 0x850EC30 VA: 0x8512C30
	public static AsyncOperationHandle<GameObject> InstantiateAsync(object key, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	// RVA: 0x8512E1C Offset: 0x850EE1C VA: 0x8512E1C
	public static AsyncOperationHandle<GameObject> InstantiateAsync(object key, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x851269C Offset: 0x850E69C VA: 0x851269C
	public static AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	[Obsolete]
	// RVA: 0x85137F0 Offset: 0x850F7F0 VA: 0x85137F0
	public static AsyncOperationHandle<SceneInstance> LoadScene(object key, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	[Obsolete]
	// RVA: 0x8513990 Offset: 0x850F990 VA: 0x8513990
	public static AsyncOperationHandle<SceneInstance> LoadScene(IResourceLocation location, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x8513890 Offset: 0x850F890 VA: 0x8513890
	public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x8513D78 Offset: 0x850FD78 VA: 0x8513D78
	public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneParameters loadSceneParameters, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x8513A30 Offset: 0x850FA30 VA: 0x8513A30
	public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x8513F5C Offset: 0x850FF5C VA: 0x8513F5C
	public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad = True, int priority = 100) { }

	[Obsolete]
	// RVA: 0x8514044 Offset: 0x8510044 VA: 0x8514044
	public static AsyncOperationHandle<SceneInstance> UnloadScene(SceneInstance scene, bool autoReleaseHandle = True) { }

	[Obsolete]
	// RVA: 0x85141B4 Offset: 0x85101B4 VA: 0x85141B4
	public static AsyncOperationHandle<SceneInstance> UnloadScene(AsyncOperationHandle handle, bool autoReleaseHandle = True) { }

	[Obsolete]
	// RVA: 0x851434C Offset: 0x851034C VA: 0x851434C
	public static AsyncOperationHandle<SceneInstance> UnloadScene(AsyncOperationHandle<SceneInstance> handle, bool autoReleaseHandle = True) { }

	[Obsolete]
	// RVA: 0x85144E4 Offset: 0x85104E4 VA: 0x85144E4
	public static AsyncOperationHandle<SceneInstance> UnloadScene(AsyncOperationHandle<SceneInstance> handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle = True) { }

	// RVA: 0x85146D4 Offset: 0x85106D4 VA: 0x85146D4
	public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene, UnloadSceneOptions unloadOptions, bool autoReleaseHandle = True) { }

	// RVA: 0x85145D8 Offset: 0x85105D8 VA: 0x85145D8
	public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle = True) { }

	// RVA: 0x85140D8 Offset: 0x85100D8 VA: 0x85140D8
	public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene, bool autoReleaseHandle = True) { }

	// RVA: 0x851425C Offset: 0x851025C VA: 0x851425C
	public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle handle, bool autoReleaseHandle = True) { }

	// RVA: 0x85143F4 Offset: 0x85103F4 VA: 0x85143F4
	public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle<SceneInstance> handle, bool autoReleaseHandle = True) { }

	// RVA: 0x8514C04 Offset: 0x8510C04 VA: 0x8514C04
	public static AsyncOperationHandle<List<string>> CheckForCatalogUpdates(bool autoReleaseHandle = True) { }

	// RVA: 0x8514E1C Offset: 0x8510E1C VA: 0x8514E1C
	public static AsyncOperationHandle<List<IResourceLocator>> UpdateCatalogs(IEnumerable<string> catalogs, bool autoReleaseHandle = True) { }

	// RVA: 0x8515144 Offset: 0x8511144 VA: 0x8515144
	public static AsyncOperationHandle<List<IResourceLocator>> UpdateCatalogs(bool autoCleanBundleCache, IEnumerable<string> catalogs, bool autoReleaseHandle = True) { }

	// RVA: 0x851521C Offset: 0x851121C VA: 0x851521C
	public static void AddResourceLocator(IResourceLocator locator, string localCatalogHash, IResourceLocation remoteCatalogLocation) { }

	// RVA: 0x85153C8 Offset: 0x85113C8 VA: 0x85153C8
	public static void RemoveResourceLocator(IResourceLocator locator) { }

	// RVA: 0x8515544 Offset: 0x8511544 VA: 0x8515544
	public static void ClearResourceLocators() { }

	// RVA: 0x8515644 Offset: 0x8511644 VA: 0x8515644
	public static AsyncOperationHandle<bool> CleanBundleCache(IEnumerable<string> catalogsIds) { }

	// RVA: -1 Offset: -1
	public static ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string remoteCatalogPath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B7744 Offset: 0x44B3744 VA: 0x44B7744
	|-Addressables.CreateCatalogLocationWithHashDependencies<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(IResourceLocation remoteCatalogLocation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B7690 Offset: 0x44B3690 VA: 0x44B7690
	|-Addressables.CreateCatalogLocationWithHashDependencies<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string remoteCatalogPath, string remoteHashPath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B77F8 Offset: 0x44B37F8 VA: 0x44B77F8
	|-Addressables.CreateCatalogLocationWithHashDependencies<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x8515C98 Offset: 0x8511C98 VA: 0x8515C98
	private static void .cctor() { }
}

// Namespace: 
private class AddressablesImpl.LoadResourceLocationKeyOp : AsyncOperationBase<IList<IResourceLocation>> // TypeDefIndex: 26167
{
	// Fields
	private object m_Keys; // 0x98
	private IList<IResourceLocation> m_locations; // 0xA0
	private AddressablesImpl m_Addressables; // 0xA8
	private Type m_ResourceType; // 0xB0

	// Properties
	protected override string DebugName { get; }

	// Methods

	// RVA: 0x851DEF4 Offset: 0x8519EF4 VA: 0x851DEF4 Slot: 31
	protected override string get_DebugName() { }

	// RVA: 0x8518C60 Offset: 0x8514C60 VA: 0x8518C60
	public void Init(AddressablesImpl aa, Type t, object keys) { }

	// RVA: 0x851DF14 Offset: 0x8519F14 VA: 0x851DF14 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x851DF88 Offset: 0x8519F88 VA: 0x851DF88 Slot: 28
	protected override void Execute() { }

	// RVA: 0x8518C18 Offset: 0x8514C18 VA: 0x8518C18
	public void .ctor() { }
}

// Namespace: 
private class AddressablesImpl.LoadResourceLocationKeysOp : AsyncOperationBase<IList<IResourceLocation>> // TypeDefIndex: 26168
{
	// Fields
	private IEnumerable m_Key; // 0x98
	private Addressables.MergeMode m_MergeMode; // 0xA0
	private IList<IResourceLocation> m_locations; // 0xA8
	private AddressablesImpl m_Addressables; // 0xB0
	private Type m_ResourceType; // 0xB8

	// Properties
	protected override string DebugName { get; }

	// Methods

	// RVA: 0x851E074 Offset: 0x851A074 VA: 0x851E074 Slot: 31
	protected override string get_DebugName() { }

	// RVA: 0x8518A54 Offset: 0x8514A54 VA: 0x8518A54
	public void Init(AddressablesImpl aa, Type t, IEnumerable key, Addressables.MergeMode mergeMode) { }

	// RVA: 0x851E0B4 Offset: 0x851A0B4 VA: 0x851E0B4 Slot: 28
	protected override void Execute() { }

	// RVA: 0x851E1A4 Offset: 0x851A1A4 VA: 0x851E1A4 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x8518A0C Offset: 0x8514A0C VA: 0x8518A0C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class AddressablesImpl.<>c // TypeDefIndex: 26169
{
	// Fields
	public static readonly AddressablesImpl.<>c <>9; // 0x0
	public static Func<ResourceLocatorInfo, IResourceLocator> <>9__59_0; // 0x8
	public static Func<ResourceLocatorInfo, bool> <>9__146_0; // 0x10
	public static Func<ResourceLocatorInfo, string> <>9__146_1; // 0x18
	public static Func<ResourceLocatorInfo, string> <>9__150_0; // 0x20

	// Methods

	// RVA: 0x851E218 Offset: 0x851A218 VA: 0x851E218
	private static void .cctor() { }

	// RVA: 0x851E280 Offset: 0x851A280 VA: 0x851E280
	public void .ctor() { }

	// RVA: 0x851E288 Offset: 0x851A288 VA: 0x851E288
	internal IResourceLocator <get_ResourceLocators>b__59_0(ResourceLocatorInfo l) { }

	// RVA: 0x851E2A0 Offset: 0x851A2A0 VA: 0x851E2A0
	internal bool <get_CatalogsWithAvailableUpdates>b__146_0(ResourceLocatorInfo s) { }

	// RVA: 0x851E2B8 Offset: 0x851A2B8 VA: 0x851E2B8
	internal string <get_CatalogsWithAvailableUpdates>b__146_1(ResourceLocatorInfo s) { }

	// RVA: 0x851E35C Offset: 0x851A35C VA: 0x851E35C
	internal string <CleanBundleCache>b__150_0(ResourceLocatorInfo s) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class AddressablesImpl.<>c__115<TObject> // TypeDefIndex: 26170
{
	// Fields
	public static readonly AddressablesImpl.<>c__115<TObject> <>9; // 0x0
	public static Action<AsyncOperationHandle> <>9__115_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4858A34 Offset: 0x4854A34 VA: 0x4858A34
	|-AddressablesImpl.<>c__115<object>..cctor
	|
	|-RVA: 0x4858B04 Offset: 0x4854B04 VA: 0x4858B04
	|-AddressablesImpl.<>c__115<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4858AF0 Offset: 0x4854AF0 VA: 0x4858AF0
	|-AddressablesImpl.<>c__115<object>..ctor
	|
	|-RVA: 0x4858BF8 Offset: 0x4854BF8 VA: 0x4858BF8
	|-AddressablesImpl.<>c__115<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <AutoReleaseHandleOnTypelessCompletion>b__115_0(AsyncOperationHandle op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4858AF8 Offset: 0x4854AF8 VA: 0x4858AF8
	|-AddressablesImpl.<>c__115<object>.<AutoReleaseHandleOnTypelessCompletion>b__115_0
	|
	|-RVA: 0x4858C00 Offset: 0x4854C00 VA: 0x4858C00
	|-AddressablesImpl.<>c__115<__Il2CppFullySharedGenericType>.<AutoReleaseHandleOnTypelessCompletion>b__115_0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass100_0 // TypeDefIndex: 26171
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public IResourceLocation catalogLoc; // 0x18

	// Methods

	// RVA: 0x85194E0 Offset: 0x85154E0 VA: 0x85194E0
	public void .ctor() { }

	// RVA: 0x851E400 Offset: 0x851A400 VA: 0x851E400
	internal AsyncOperationHandle<long> <ComputeCatalogSizeWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass103_0 // TypeDefIndex: 26172
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public IEnumerable keys; // 0x18

	// Methods

	// RVA: 0x8519EBC Offset: 0x8515EBC VA: 0x8519EBC
	public void .ctor() { }

	// RVA: 0x851E600 Offset: 0x851A600 VA: 0x851E600
	internal AsyncOperationHandle<long> <GetDownloadSizeWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass106_0 // TypeDefIndex: 26173
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public object key; // 0x18

	// Methods

	// RVA: 0x851A078 Offset: 0x8516078 VA: 0x851A078
	public void .ctor() { }

	// RVA: 0x851E644 Offset: 0x851A644 VA: 0x851E644
	internal AsyncOperationHandle<IList<IAssetBundleResource>> <DownloadDependenciesAsyncWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass110_0 // TypeDefIndex: 26174
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public IList<IResourceLocation> locations; // 0x18

	// Methods

	// RVA: 0x851ABE4 Offset: 0x8516BE4 VA: 0x851ABE4
	public void .ctor() { }

	// RVA: 0x851E6D4 Offset: 0x851A6D4 VA: 0x851E6D4
	internal AsyncOperationHandle<IList<IAssetBundleResource>> <DownloadDependenciesAsyncWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass112_0 // TypeDefIndex: 26175
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public IEnumerable keys; // 0x18
	public Addressables.MergeMode mode; // 0x20

	// Methods

	// RVA: 0x851ADA8 Offset: 0x8516DA8 VA: 0x851ADA8
	public void .ctor() { }

	// RVA: 0x851E764 Offset: 0x851A764 VA: 0x851E764
	internal AsyncOperationHandle<IList<IAssetBundleResource>> <DownloadDependenciesAsyncWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass116_0 // TypeDefIndex: 26176
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public object key; // 0x18
	public bool autoReleaseHandle; // 0x20

	// Methods

	// RVA: 0x851B568 Offset: 0x8517568 VA: 0x851B568
	public void .ctor() { }

	// RVA: 0x851E7F8 Offset: 0x851A7F8 VA: 0x851E7F8
	internal AsyncOperationHandle<bool> <ClearDependencyCacheAsync>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass117_0 // TypeDefIndex: 26177
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public IList<IResourceLocation> locations; // 0x18
	public bool autoReleaseHandle; // 0x20

	// Methods

	// RVA: 0x851B570 Offset: 0x8517570 VA: 0x851B570
	public void .ctor() { }

	// RVA: 0x851E840 Offset: 0x851A840 VA: 0x851E840
	internal AsyncOperationHandle<bool> <ClearDependencyCacheAsync>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass118_0 // TypeDefIndex: 26178
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public IEnumerable keys; // 0x18
	public bool autoReleaseHandle; // 0x20

	// Methods

	// RVA: 0x851B578 Offset: 0x8517578 VA: 0x851B578
	public void .ctor() { }

	// RVA: 0x851E888 Offset: 0x851A888 VA: 0x851E888
	internal AsyncOperationHandle<bool> <ClearDependencyCacheAsync>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass123_0 // TypeDefIndex: 26179
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public object key; // 0x18
	public InstantiationParameters instantiateParameters; // 0x20

	// Methods

	// RVA: 0x851B7B4 Offset: 0x85177B4 VA: 0x851B7B4
	public void .ctor() { }

	// RVA: 0x851E8D0 Offset: 0x851A8D0 VA: 0x851E8D0
	internal AsyncOperationHandle<GameObject> <InstantiateWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass125_0 // TypeDefIndex: 26180
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public IResourceLocation location; // 0x18
	public InstantiationParameters instantiateParameters; // 0x20

	// Methods

	// RVA: 0x851B960 Offset: 0x8517960 VA: 0x851B960
	public void .ctor() { }

	// RVA: 0x851E93C Offset: 0x851A93C VA: 0x851E93C
	internal AsyncOperationHandle<GameObject> <InstantiateWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass128_0 // TypeDefIndex: 26181
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public object key; // 0x18
	public LoadSceneParameters loadSceneParameters; // 0x20
	public bool activateOnLoad; // 0x28
	public int priority; // 0x2C

	// Methods

	// RVA: 0x851BAFC Offset: 0x8517AFC VA: 0x851BAFC
	public void .ctor() { }

	// RVA: 0x851E9A8 Offset: 0x851A9A8 VA: 0x851E9A8
	internal AsyncOperationHandle<SceneInstance> <LoadSceneWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass129_0 // TypeDefIndex: 26182
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public IResourceLocation key; // 0x18
	public LoadSceneMode loadMode; // 0x20
	public bool activateOnLoad; // 0x24
	public int priority; // 0x28

	// Methods

	// RVA: 0x851BC98 Offset: 0x8517C98 VA: 0x851BC98
	public void .ctor() { }

	// RVA: 0x851E9F8 Offset: 0x851A9F8 VA: 0x851E9F8
	internal AsyncOperationHandle<SceneInstance> <LoadSceneWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass138_0 // TypeDefIndex: 26183
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public UnloadSceneOptions unloadOptions; // 0x18
	public bool autoReleaseHandle; // 0x1C

	// Methods

	// RVA: 0x851C164 Offset: 0x8518164 VA: 0x851C164
	public void .ctor() { }

	// RVA: 0x851EA7C Offset: 0x851AA7C VA: 0x851EA7C
	internal AsyncOperationHandle<SceneInstance> <CreateUnloadSceneWithChain>b__0(AsyncOperationHandle completedHandle) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass139_0 // TypeDefIndex: 26184
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public UnloadSceneOptions unloadOptions; // 0x18
	public bool autoReleaseHandle; // 0x1C

	// Methods

	// RVA: 0x851C16C Offset: 0x851816C VA: 0x851C16C
	public void .ctor() { }

	// RVA: 0x851EB38 Offset: 0x851AB38 VA: 0x851EB38
	internal AsyncOperationHandle<SceneInstance> <CreateUnloadSceneWithChain>b__0(AsyncOperationHandle<SceneInstance> completedHandle) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass143_0 // TypeDefIndex: 26185
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public bool autoReleaseHandle; // 0x18

	// Methods

	// RVA: 0x851C958 Offset: 0x8518958 VA: 0x851C958
	public void .ctor() { }

	// RVA: 0x851EBA4 Offset: 0x851ABA4 VA: 0x851EBA4
	internal AsyncOperationHandle<List<string>> <CheckForCatalogUpdatesWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass147_0 // TypeDefIndex: 26186
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public bool autoReleaseHandle; // 0x18
	public bool autoCleanBundleCache; // 0x19

	// Methods

	// RVA: 0x851CB1C Offset: 0x8518B1C VA: 0x851CB1C
	public void .ctor() { }

	// RVA: 0x851EBE8 Offset: 0x851ABE8 VA: 0x851EBE8
	internal AsyncOperationHandle<List<IResourceLocator>> <UpdateCatalogs>b__0(AsyncOperationHandle<List<string>> depOp) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass152_0 // TypeDefIndex: 26187
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public AsyncOperationHandle<IList<AsyncOperationHandle>> depOp; // 0x18
	public bool forceSingleThreading; // 0x30

	// Methods

	// RVA: 0x851DD08 Offset: 0x8519D08 VA: 0x851DD08
	public void .ctor() { }

	// RVA: 0x851EC48 Offset: 0x851AC48 VA: 0x851EC48
	internal AsyncOperationHandle<bool> <CleanBundleCacheWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass153_0 // TypeDefIndex: 26188
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public IEnumerable<string> catalogIds; // 0x18
	public bool forceSingleThreading; // 0x20

	// Methods

	// RVA: 0x851DD10 Offset: 0x8519D10 VA: 0x851DD10
	public void .ctor() { }

	// RVA: 0x851ECB0 Offset: 0x851ACB0 VA: 0x851ECB0
	internal AsyncOperationHandle<bool> <CleanBundleCacheWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass61_0 // TypeDefIndex: 26189
{
	// Fields
	public IResourceLocator loc; // 0x10

	// Methods

	// RVA: 0x8516954 Offset: 0x8512954 VA: 0x8516954
	public void .ctor() { }

	// RVA: 0x851ECF8 Offset: 0x851ACF8 VA: 0x851ECF8
	internal bool <RemoveResourceLocator>b__0(ResourceLocatorInfo l) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass72_0 // TypeDefIndex: 26190
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public string catalogPath; // 0x18
	public bool autoReleaseHandle; // 0x20
	public string providerSuffix; // 0x28

	// Methods

	// RVA: 0x851805C Offset: 0x851405C VA: 0x851805C
	public void .ctor() { }

	// RVA: 0x851ED1C Offset: 0x851AD1C VA: 0x851ED1C
	internal AsyncOperationHandle<IResourceLocator> <LoadContentCatalogAsync>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass78_0<TObject> // TypeDefIndex: 26191
{
	// Fields
	public AddressablesImpl <>4__this; // 0x0
	public IResourceLocation loc; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545E354 Offset: 0x545A354 VA: 0x545E354
	|-AddressablesImpl.<>c__DisplayClass78_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<TObject> <LoadAssetWithChain>b__0(AsyncOperationHandle op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545E35C Offset: 0x545A35C VA: 0x545E35C
	|-AddressablesImpl.<>c__DisplayClass78_0<__Il2CppFullySharedGenericType>.<LoadAssetWithChain>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass79_0<TObject> // TypeDefIndex: 26192
{
	// Fields
	public AddressablesImpl <>4__this; // 0x0
	public object key; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545E6D4 Offset: 0x545A6D4 VA: 0x545E6D4
	|-AddressablesImpl.<>c__DisplayClass79_0<object>..ctor
	|
	|-RVA: 0x545E72C Offset: 0x545A72C VA: 0x545E72C
	|-AddressablesImpl.<>c__DisplayClass79_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<TObject> <LoadAssetWithChain>b__0(AsyncOperationHandle op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545E6DC Offset: 0x545A6DC VA: 0x545E6DC
	|-AddressablesImpl.<>c__DisplayClass79_0<object>.<LoadAssetWithChain>b__0
	|
	|-RVA: 0x545E734 Offset: 0x545A734 VA: 0x545E734
	|-AddressablesImpl.<>c__DisplayClass79_0<__Il2CppFullySharedGenericType>.<LoadAssetWithChain>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass83_0 // TypeDefIndex: 26193
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public IEnumerable keys; // 0x18
	public Addressables.MergeMode mode; // 0x20
	public Type type; // 0x28

	// Methods

	// RVA: 0x8518A04 Offset: 0x8514A04 VA: 0x8518A04
	public void .ctor() { }

	// RVA: 0x851ED68 Offset: 0x851AD68 VA: 0x851ED68
	internal AsyncOperationHandle<IList<IResourceLocation>> <LoadResourceLocationsWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass85_0 // TypeDefIndex: 26194
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public object key; // 0x18
	public Type type; // 0x20

	// Methods

	// RVA: 0x8518C10 Offset: 0x8514C10 VA: 0x8518C10
	public void .ctor() { }

	// RVA: 0x851EDB4 Offset: 0x851ADB4 VA: 0x851EDB4
	internal AsyncOperationHandle<IList<IResourceLocation>> <LoadResourceLocationsWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass88_0<TObject> // TypeDefIndex: 26195
{
	// Fields
	public AddressablesImpl <>4__this; // 0x0
	public IList<IResourceLocation> locations; // 0x0
	public Action<TObject> callback; // 0x0
	public bool releaseDependenciesOnFailure; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54695A8 Offset: 0x54655A8 VA: 0x54695A8
	|-AddressablesImpl.<>c__DisplayClass88_0<object>..ctor
	|
	|-RVA: 0x5469604 Offset: 0x5465604 VA: 0x5469604
	|-AddressablesImpl.<>c__DisplayClass88_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<IList<TObject>> <LoadAssetsWithChain>b__0(AsyncOperationHandle op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54695B0 Offset: 0x54655B0 VA: 0x54695B0
	|-AddressablesImpl.<>c__DisplayClass88_0<object>.<LoadAssetsWithChain>b__0
	|
	|-RVA: 0x546960C Offset: 0x546560C VA: 0x546960C
	|-AddressablesImpl.<>c__DisplayClass88_0<__Il2CppFullySharedGenericType>.<LoadAssetsWithChain>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass89_0<TObject> // TypeDefIndex: 26196
{
	// Fields
	public AddressablesImpl <>4__this; // 0x0
	public IEnumerable keys; // 0x0
	public Action<TObject> callback; // 0x0
	public Addressables.MergeMode mode; // 0x0
	public bool releaseDependenciesOnFailure; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5469664 Offset: 0x5465664 VA: 0x5469664
	|-AddressablesImpl.<>c__DisplayClass89_0<object>..ctor
	|
	|-RVA: 0x54696C4 Offset: 0x54656C4 VA: 0x54696C4
	|-AddressablesImpl.<>c__DisplayClass89_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<IList<TObject>> <LoadAssetsWithChain>b__0(AsyncOperationHandle op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x546966C Offset: 0x546566C VA: 0x546966C
	|-AddressablesImpl.<>c__DisplayClass89_0<object>.<LoadAssetsWithChain>b__0
	|
	|-RVA: 0x54696CC Offset: 0x54656CC VA: 0x54696CC
	|-AddressablesImpl.<>c__DisplayClass89_0<__Il2CppFullySharedGenericType>.<LoadAssetsWithChain>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass91_0<TObject> // TypeDefIndex: 26197
{
	// Fields
	public AddressablesImpl <>4__this; // 0x0
	public object key; // 0x0
	public Action<TObject> callback; // 0x0
	public bool releaseDependenciesOnFailure; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5469C50 Offset: 0x5465C50 VA: 0x5469C50
	|-AddressablesImpl.<>c__DisplayClass91_0<object>..ctor
	|
	|-RVA: 0x5469CAC Offset: 0x5465CAC VA: 0x5469CAC
	|-AddressablesImpl.<>c__DisplayClass91_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<IList<TObject>> <LoadAssetsWithChain>b__0(AsyncOperationHandle op2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5469C58 Offset: 0x5465C58 VA: 0x5469C58
	|-AddressablesImpl.<>c__DisplayClass91_0<object>.<LoadAssetsWithChain>b__0
	|
	|-RVA: 0x5469CB4 Offset: 0x5465CB4 VA: 0x5469CB4
	|-AddressablesImpl.<>c__DisplayClass91_0<__Il2CppFullySharedGenericType>.<LoadAssetsWithChain>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressablesImpl.<>c__DisplayClass99_0 // TypeDefIndex: 26198
{
	// Fields
	public AddressablesImpl <>4__this; // 0x10
	public object key; // 0x18

	// Methods

	// RVA: 0x85190FC Offset: 0x85150FC VA: 0x85190FC
	public void .ctor() { }

	// RVA: 0x851EDF8 Offset: 0x851ADF8 VA: 0x851EDF8
	internal AsyncOperationHandle<long> <GetDownloadSizeWithChain>b__0(AsyncOperationHandle op) { }
}

// Namespace: UnityEngine.AddressableAssets
internal class AddressablesImpl : IEqualityComparer<IResourceLocation> // TypeDefIndex: 26199
{
	// Fields
	private ResourceManager m_ResourceManager; // 0x10
	private IInstanceProvider m_InstanceProvider; // 0x18
	private int m_CatalogRequestsTimeout; // 0x20
	internal const string kCacheDataFolder = "{UnityEngine.Application.persistentDataPath}/com.unity.addressables/";
	public ISceneProvider SceneProvider; // 0x28
	internal List<ResourceLocatorInfo> m_ResourceLocators; // 0x30
	private AsyncOperationHandle<IResourceLocator> m_InitializationOperation; // 0x38
	private AsyncOperationHandle<List<string>> m_ActiveCheckUpdateOperation; // 0x50
	internal AsyncOperationHandle<List<IResourceLocator>> m_ActiveUpdateOperation; // 0x68
	private Action<AsyncOperationHandle> m_OnHandleCompleteAction; // 0x80
	private Action<AsyncOperationHandle> m_OnSceneHandleCompleteAction; // 0x88
	private Action<AsyncOperationHandle> m_OnHandleDestroyedAction; // 0x90
	private Dictionary<object, AsyncOperationHandle> m_resultToHandle; // 0x98
	internal HashSet<AsyncOperationHandle> m_SceneInstances; // 0xA0
	private AsyncOperationHandle<bool> m_ActiveCleanBundleCacheOperation; // 0xA8
	internal bool hasStartedInitialization; // 0xC0

	// Properties
	public IInstanceProvider InstanceProvider { get; set; }
	public ResourceManager ResourceManager { get; }
	public int CatalogRequestsTimeout { get; set; }
	internal int SceneOperationCount { get; }
	internal int TrackedHandleCount { get; }
	public Func<IResourceLocation, string> InternalIdTransformFunc { get; set; }
	public Action<UnityWebRequest> WebRequestOverride { get; set; }
	public AsyncOperationHandle ChainOperation { get; }
	internal bool ShouldChainRequest { get; }
	public string StreamingAssetsSubFolder { get; }
	public string BuildPath { get; }
	public string PlayerBuildDataPath { get; }
	public string RuntimePath { get; }
	public IEnumerable<IResourceLocator> ResourceLocators { get; }
	internal IEnumerable<string> CatalogsWithAvailableUpdates { get; }

	// Methods

	// RVA: 0x8515FA0 Offset: 0x8511FA0 VA: 0x8515FA0
	public IInstanceProvider get_InstanceProvider() { }

	// RVA: 0x8515FA8 Offset: 0x8511FA8 VA: 0x8515FA8
	public void set_InstanceProvider(IInstanceProvider value) { }

	// RVA: 0x851603C Offset: 0x851203C VA: 0x851603C
	public ResourceManager get_ResourceManager() { }

	// RVA: 0x8516044 Offset: 0x8512044 VA: 0x8516044
	public int get_CatalogRequestsTimeout() { }

	// RVA: 0x851604C Offset: 0x851204C VA: 0x851604C
	public void set_CatalogRequestsTimeout(int value) { }

	// RVA: 0x8516054 Offset: 0x8512054 VA: 0x8516054
	internal int get_SceneOperationCount() { }

	// RVA: 0x851609C Offset: 0x851209C VA: 0x851609C
	internal int get_TrackedHandleCount() { }

	// RVA: 0x8515DB4 Offset: 0x8511DB4 VA: 0x8515DB4
	public void .ctor(IAllocationStrategy alloc) { }

	// RVA: 0x85160EC Offset: 0x85120EC VA: 0x85160EC
	internal void ReleaseSceneManagerOperation() { }

	// RVA: 0x850D124 Offset: 0x8509124 VA: 0x850D124
	public Func<IResourceLocation, string> get_InternalIdTransformFunc() { }

	// RVA: 0x850D1E4 Offset: 0x85091E4 VA: 0x850D1E4
	public void set_InternalIdTransformFunc(Func<IResourceLocation, string> value) { }

	// RVA: 0x850D29C Offset: 0x850929C VA: 0x850D29C
	public Action<UnityWebRequest> get_WebRequestOverride() { }

	// RVA: 0x850D35C Offset: 0x850935C VA: 0x850D35C
	public void set_WebRequestOverride(Action<UnityWebRequest> value) { }

	// RVA: 0x8516190 Offset: 0x8512190 VA: 0x8516190
	public AsyncOperationHandle get_ChainOperation() { }

	// RVA: 0x8516348 Offset: 0x8512348 VA: 0x8516348
	internal bool get_ShouldChainRequest() { }

	// RVA: 0x8516428 Offset: 0x8512428 VA: 0x8516428
	internal void OnSceneUnloaded(Scene scene) { }

	// RVA: 0x850D434 Offset: 0x8509434 VA: 0x850D434
	public string get_StreamingAssetsSubFolder() { }

	// RVA: 0x850D504 Offset: 0x8509504 VA: 0x850D504
	public string get_BuildPath() { }

	// RVA: 0x850D670 Offset: 0x8509670 VA: 0x850D670
	public string get_PlayerBuildDataPath() { }

	// RVA: 0x850D7AC Offset: 0x85097AC VA: 0x850D7AC
	public string get_RuntimePath() { }

	// RVA: 0x850DA04 Offset: 0x8509A04 VA: 0x850DA04
	public void Log(string msg) { }

	// RVA: 0x850DC50 Offset: 0x8509C50 VA: 0x850DC50
	public void LogFormat(string format, object[] args) { }

	// RVA: 0x850D954 Offset: 0x8509954 VA: 0x850D954
	public void LogWarning(string msg) { }

	// RVA: 0x850DB80 Offset: 0x8509B80 VA: 0x850DB80
	public void LogWarningFormat(string format, object[] args) { }

	// RVA: 0x850D9AC Offset: 0x85099AC VA: 0x850D9AC
	public void LogError(string msg) { }

	// RVA: 0x850DF74 Offset: 0x8509F74 VA: 0x850DF74
	public void LogException(AsyncOperationHandle op, Exception ex) { }

	// RVA: 0x850E0A0 Offset: 0x850A0A0 VA: 0x850E0A0
	public void LogException(Exception ex) { }

	// RVA: 0x850DBE8 Offset: 0x8509BE8 VA: 0x850DBE8
	public void LogErrorFormat(string format, object[] args) { }

	// RVA: 0x850D034 Offset: 0x8509034 VA: 0x850D034
	public string ResolveInternalId(string id) { }

	// RVA: 0x850CC58 Offset: 0x8508C58 VA: 0x850CC58
	public IEnumerable<IResourceLocator> get_ResourceLocators() { }

	// RVA: 0x85152CC Offset: 0x85112CC VA: 0x85152CC
	public void AddResourceLocator(IResourceLocator loc, string localCatalogHash, IResourceLocation remoteCatalogLocation) { }

	// RVA: 0x8515460 Offset: 0x8511460 VA: 0x8515460
	public void RemoveResourceLocator(IResourceLocator loc) { }

	// RVA: 0x85155D4 Offset: 0x85115D4 VA: 0x85155D4
	public void ClearResourceLocators() { }

	// RVA: 0x851695C Offset: 0x851295C VA: 0x851695C
	internal bool GetResourceLocations(object key, Type type, out IList<IResourceLocation> locations) { }

	// RVA: 0x851712C Offset: 0x851312C VA: 0x851712C
	internal bool GetResourceLocations(IEnumerable keys, Type type, Addressables.MergeMode merge, out IList<IResourceLocation> locations) { }

	// RVA: 0x8517640 Offset: 0x8513640 VA: 0x8517640
	public AsyncOperationHandle<IResourceLocator> InitializeAsync(string runtimeDataPath, string providerSuffix, bool autoReleaseHandle = True) { }

	// RVA: 0x850E1C8 Offset: 0x850A1C8 VA: 0x850E1C8
	public AsyncOperationHandle<IResourceLocator> InitializeAsync() { }

	// RVA: 0x850E318 Offset: 0x850A318 VA: 0x850E318
	public AsyncOperationHandle<IResourceLocator> InitializeAsync(bool autoReleaseHandle) { }

	// RVA: -1 Offset: -1
	public ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(IResourceLocation catalogLocation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B8E34 Offset: 0x44B4E34 VA: 0x44B8E34
	|-AddressablesImpl.CreateCatalogLocationWithHashDependencies<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string catalogLocation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B8DA4 Offset: 0x44B4DA4 VA: 0x44B8DA4
	|-AddressablesImpl.CreateCatalogLocationWithHashDependencies<object>
	|
	|-RVA: 0x44B8EF4 Offset: 0x44B4EF4 VA: 0x44B8EF4
	|-AddressablesImpl.CreateCatalogLocationWithHashDependencies<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string catalogPath, string hashFilePath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B8F88 Offset: 0x44B4F88 VA: 0x44B8F88
	|-AddressablesImpl.CreateCatalogLocationWithHashDependencies<object>
	|
	|-RVA: 0x44B9500 Offset: 0x44B5500 VA: 0x44B9500
	|-AddressablesImpl.CreateCatalogLocationWithHashDependencies<__Il2CppFullySharedGenericType>
	*/

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x8518058 Offset: 0x8514058 VA: 0x8518058
	private void QueueEditorUpdateIfNeeded() { }

	// RVA: 0x850E508 Offset: 0x850A508 VA: 0x850E508
	public AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, bool autoReleaseHandle = True, string providerSuffix) { }

	// RVA: 0x8518750 Offset: 0x8514750 VA: 0x8518750
	private AsyncOperationHandle<SceneInstance> TrackHandle(AsyncOperationHandle<SceneInstance> handle) { }

	// RVA: -1 Offset: -1
	private AsyncOperationHandle<TObject> TrackHandle<TObject>(AsyncOperationHandle<TObject> handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460AAD4 Offset: 0x4606AD4 VA: 0x460AAD4
	|-AddressablesImpl.TrackHandle<long>
	|
	|-RVA: 0x460AB34 Offset: 0x4606B34 VA: 0x460AB34
	|-AddressablesImpl.TrackHandle<object>
	|
	|-RVA: 0x460AB94 Offset: 0x4606B94 VA: 0x460AB94
	|-AddressablesImpl.TrackHandle<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x851880C Offset: 0x851480C VA: 0x851880C
	private AsyncOperationHandle TrackHandle(AsyncOperationHandle handle) { }

	// RVA: 0x8518848 Offset: 0x8514848 VA: 0x8518848
	internal void ClearTrackHandles() { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(IResourceLocation location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44BA268 Offset: 0x44B6268 VA: 0x44BA268
	|-AddressablesImpl.LoadAssetAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private AsyncOperationHandle<TObject> LoadAssetWithChain<TObject>(AsyncOperationHandle dep, IResourceLocation loc) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44BADC4 Offset: 0x44B6DC4 VA: 0x44BADC4
	|-AddressablesImpl.LoadAssetWithChain<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private AsyncOperationHandle<TObject> LoadAssetWithChain<TObject>(AsyncOperationHandle dep, object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44BACA0 Offset: 0x44B6CA0 VA: 0x44BACA0
	|-AddressablesImpl.LoadAssetWithChain<object>
	|
	|-RVA: 0x44BAEF8 Offset: 0x44B6EF8 VA: 0x44BAEF8
	|-AddressablesImpl.LoadAssetWithChain<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B9A78 Offset: 0x44B5A78 VA: 0x44B9A78
	|-AddressablesImpl.LoadAssetAsync<object>
	|
	|-RVA: 0x44BA3B8 Offset: 0x44B63B8 VA: 0x44BA3B8
	|-AddressablesImpl.LoadAssetAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x8518898 Offset: 0x8514898 VA: 0x8518898
	public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsWithChain(AsyncOperationHandle dep, IEnumerable keys, Addressables.MergeMode mode, Type type) { }

	// RVA: 0x850E94C Offset: 0x850A94C VA: 0x850E94C
	public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(IEnumerable keys, Addressables.MergeMode mode, Type type) { }

	// RVA: 0x8518AAC Offset: 0x8514AAC VA: 0x8518AAC
	public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsWithChain(AsyncOperationHandle dep, object key, Type type) { }

	// RVA: 0x850ED04 Offset: 0x850AD04 VA: 0x850ED04
	public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(object key, Type type) { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<IResourceLocation> locations, Action<TObject> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44BB02C Offset: 0x44B702C VA: 0x44BB02C
	|-AddressablesImpl.LoadAssetsAsync<object>
	|
	|-RVA: 0x44BB368 Offset: 0x44B7368 VA: 0x44BB368
	|-AddressablesImpl.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private AsyncOperationHandle<IList<TObject>> LoadAssetsWithChain<TObject>(AsyncOperationHandle dep, IList<IResourceLocation> locations, Action<TObject> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44BBB58 Offset: 0x44B7B58 VA: 0x44BBB58
	|-AddressablesImpl.LoadAssetsWithChain<object>
	|
	|-RVA: 0x44BBDF8 Offset: 0x44B7DF8 VA: 0x44BBDF8
	|-AddressablesImpl.LoadAssetsWithChain<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private AsyncOperationHandle<IList<TObject>> LoadAssetsWithChain<TObject>(AsyncOperationHandle dep, IEnumerable keys, Action<TObject> callback, Addressables.MergeMode mode, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44BC0B8 Offset: 0x44B80B8 VA: 0x44BC0B8
	|-AddressablesImpl.LoadAssetsWithChain<object>
	|
	|-RVA: 0x44BC210 Offset: 0x44B8210 VA: 0x44BC210
	|-AddressablesImpl.LoadAssetsWithChain<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IEnumerable keys, Action<TObject> callback, Addressables.MergeMode mode, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44BB704 Offset: 0x44B7704 VA: 0x44BB704
	|-AddressablesImpl.LoadAssetsAsync<object>
	|
	|-RVA: 0x44BB91C Offset: 0x44B791C VA: 0x44BB91C
	|-AddressablesImpl.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private AsyncOperationHandle<IList<TObject>> LoadAssetsWithChain<TObject>(AsyncOperationHandle dep, object key, Action<TObject> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44BBCA8 Offset: 0x44B7CA8 VA: 0x44BBCA8
	|-AddressablesImpl.LoadAssetsWithChain<object>
	|
	|-RVA: 0x44BBF58 Offset: 0x44B7F58 VA: 0x44BBF58
	|-AddressablesImpl.LoadAssetsWithChain<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(object key, Action<TObject> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44BB160 Offset: 0x44B7160 VA: 0x44BB160
	|-AddressablesImpl.LoadAssetsAsync<object>
	|
	|-RVA: 0x44BB4D8 Offset: 0x44B74D8 VA: 0x44BB4D8
	|-AddressablesImpl.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x8518CA8 Offset: 0x8514CA8 VA: 0x8518CA8
	private void OnHandleDestroyed(AsyncOperationHandle handle) { }

	// RVA: 0x8518D30 Offset: 0x8514D30 VA: 0x8518D30
	private void OnSceneHandleCompleted(AsyncOperationHandle handle) { }

	// RVA: 0x8518E70 Offset: 0x8514E70 VA: 0x8518E70
	private void OnHandleCompleted(AsyncOperationHandle handle) { }

	// RVA: -1 Offset: -1
	public void Release<TObject>(TObject obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44BC378 Offset: 0x44B8378 VA: 0x44BC378
	|-AddressablesImpl.Release<object>
	|
	|-RVA: 0x44BC44C Offset: 0x44B844C VA: 0x44BC44C
	|-AddressablesImpl.Release<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void Release<TObject>(AsyncOperationHandle<TObject> handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460AA2C Offset: 0x4606A2C VA: 0x460AA2C
	|-AddressablesImpl.Release<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x8518F68 Offset: 0x8514F68 VA: 0x8518F68
	public void Release(AsyncOperationHandle handle) { }

	// RVA: 0x8518FB4 Offset: 0x8514FB4 VA: 0x8518FB4
	private AsyncOperationHandle<long> GetDownloadSizeWithChain(AsyncOperationHandle dep, object key) { }

	// RVA: 0x8519104 Offset: 0x8515104 VA: 0x8519104
	private AsyncOperationHandle<long> ComputeCatalogSizeWithChain(IResourceLocation catalogLoc) { }

	// RVA: 0x85194E8 Offset: 0x85154E8 VA: 0x85194E8
	internal bool IsCatalogCached(IResourceLocation catalogLoc, Hash128 remoteHash) { }

	// RVA: 0x8519918 Offset: 0x8515918 VA: 0x8519918
	internal AsyncOperationHandle<long> GetRemoteCatalogHeaderSize(IResourceLocation catalogLoc) { }

	// RVA: 0x8519D74 Offset: 0x8515D74 VA: 0x8519D74
	private AsyncOperationHandle<long> GetDownloadSizeWithChain(AsyncOperationHandle dep, IEnumerable keys) { }

	// RVA: 0x850F1B4 Offset: 0x850B1B4 VA: 0x850F1B4
	public AsyncOperationHandle<long> GetDownloadSizeAsync(object key) { }

	// RVA: 0x850F404 Offset: 0x850B404 VA: 0x850F404
	public AsyncOperationHandle<long> GetDownloadSizeAsync(IEnumerable keys) { }

	// RVA: 0x8519EC4 Offset: 0x8515EC4 VA: 0x8519EC4
	private AsyncOperationHandle DownloadDependenciesAsyncWithChain(AsyncOperationHandle dep, object key, bool autoReleaseHandle) { }

	// RVA: 0x851A080 Offset: 0x8516080 VA: 0x851A080
	internal static void WrapAsDownloadLocations(List<IResourceLocation> locations) { }

	// RVA: 0x851A170 Offset: 0x8516170 VA: 0x851A170
	private static List<IResourceLocation> GatherDependenciesFromLocations(IList<IResourceLocation> locations) { }

	// RVA: 0x85105C4 Offset: 0x850C5C4 VA: 0x85105C4
	public AsyncOperationHandle DownloadDependenciesAsync(object key, bool autoReleaseHandle = False) { }

	// RVA: 0x851AA30 Offset: 0x8516A30 VA: 0x851AA30
	private AsyncOperationHandle DownloadDependenciesAsyncWithChain(AsyncOperationHandle dep, IList<IResourceLocation> locations, bool autoReleaseHandle) { }

	// RVA: 0x85108F0 Offset: 0x850C8F0 VA: 0x85108F0
	public AsyncOperationHandle DownloadDependenciesAsync(IList<IResourceLocation> locations, bool autoReleaseHandle = False) { }

	// RVA: 0x851ABEC Offset: 0x8516BEC VA: 0x851ABEC
	private AsyncOperationHandle DownloadDependenciesAsyncWithChain(AsyncOperationHandle dep, IEnumerable keys, Addressables.MergeMode mode, bool autoReleaseHandle) { }

	// RVA: 0x8510B04 Offset: 0x850CB04 VA: 0x8510B04
	public AsyncOperationHandle DownloadDependenciesAsync(IEnumerable keys, Addressables.MergeMode mode, bool autoReleaseHandle = False) { }

	// RVA: 0x851ADB0 Offset: 0x8516DB0 VA: 0x851ADB0
	internal bool ClearDependencyCacheForKey(object key) { }

	// RVA: -1 Offset: -1
	internal void AutoReleaseHandleOnTypelessCompletion<TObject>(AsyncOperationHandle<TObject> handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B8B28 Offset: 0x44B4B28 VA: 0x44B8B28
	|-AddressablesImpl.AutoReleaseHandleOnTypelessCompletion<object>
	|
	|-RVA: 0x44B8C64 Offset: 0x44B4C64 VA: 0x44B8C64
	|-AddressablesImpl.AutoReleaseHandleOnTypelessCompletion<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x8510F04 Offset: 0x850CF04 VA: 0x8510F04
	public AsyncOperationHandle<bool> ClearDependencyCacheAsync(object key, bool autoReleaseHandle) { }

	// RVA: 0x851120C Offset: 0x850D20C VA: 0x851120C
	public AsyncOperationHandle<bool> ClearDependencyCacheAsync(IList<IResourceLocation> locations, bool autoReleaseHandle) { }

	// RVA: 0x85117C8 Offset: 0x850D7C8 VA: 0x85117C8
	public AsyncOperationHandle<bool> ClearDependencyCacheAsync(IEnumerable keys, bool autoReleaseHandle) { }

	// RVA: 0x851B580 Offset: 0x8517580 VA: 0x851B580
	public AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	// RVA: 0x8513218 Offset: 0x850F218 VA: 0x8513218
	public AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	// RVA: 0x85132A0 Offset: 0x850F2A0 VA: 0x85132A0
	public AsyncOperationHandle<GameObject> InstantiateAsync(object key, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	// RVA: 0x8513330 Offset: 0x850F330 VA: 0x8513330
	public AsyncOperationHandle<GameObject> InstantiateAsync(object key, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	// RVA: 0x851B610 Offset: 0x8517610 VA: 0x851B610
	private AsyncOperationHandle<GameObject> InstantiateWithChain(AsyncOperationHandle dep, object key, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x85133B8 Offset: 0x850F3B8 VA: 0x85133B8
	public AsyncOperationHandle<GameObject> InstantiateAsync(object key, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x851B7BC Offset: 0x85177BC VA: 0x851B7BC
	private AsyncOperationHandle<GameObject> InstantiateWithChain(AsyncOperationHandle dep, IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x85130E4 Offset: 0x850F0E4 VA: 0x85130E4
	public AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x850EF24 Offset: 0x850AF24 VA: 0x850EF24
	public bool ReleaseInstance(GameObject instance) { }

	// RVA: 0x851B968 Offset: 0x8517968 VA: 0x851B968
	internal AsyncOperationHandle<SceneInstance> LoadSceneWithChain(AsyncOperationHandle dep, object key, LoadSceneParameters loadSceneParameters, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x851BB04 Offset: 0x8517B04 VA: 0x851BB04
	internal AsyncOperationHandle<SceneInstance> LoadSceneWithChain(AsyncOperationHandle dep, IResourceLocation key, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x851BCA0 Offset: 0x8517CA0 VA: 0x851BCA0
	public AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key) { }

	// RVA: 0x8513B30 Offset: 0x850FB30 VA: 0x8513B30
	public AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneParameters loadSceneParameters, bool activateOnLoad = True, int priority = 100, bool trackHandle = True) { }

	// RVA: 0x851BD0C Offset: 0x8517D0C VA: 0x851BD0C
	public AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location) { }

	// RVA: 0x851BD78 Offset: 0x8517D78 VA: 0x851BD78
	public AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100, bool trackHandle = True) { }

	// RVA: 0x8513E60 Offset: 0x850FE60 VA: 0x8513E60
	public AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad = True, int priority = 100, bool trackHandle = True) { }

	// RVA: 0x85147B8 Offset: 0x85107B8 VA: 0x85147B8
	public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene, UnloadSceneOptions unloadOptions = 0, bool autoReleaseHandle = True) { }

	// RVA: 0x85149D8 Offset: 0x85109D8 VA: 0x85149D8
	public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle handle, UnloadSceneOptions unloadOptions = 0, bool autoReleaseHandle = True) { }

	// RVA: 0x8514B30 Offset: 0x8510B30 VA: 0x8514B30
	public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle<SceneInstance> handle, UnloadSceneOptions unloadOptions = 0, bool autoReleaseHandle = True) { }

	// RVA: 0x851BDF8 Offset: 0x8517DF8 VA: 0x851BDF8
	internal AsyncOperationHandle<SceneInstance> CreateUnloadSceneWithChain(AsyncOperationHandle handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle) { }

	// RVA: 0x851BF48 Offset: 0x8517F48 VA: 0x851BF48
	internal AsyncOperationHandle<SceneInstance> CreateUnloadSceneWithChain(AsyncOperationHandle<SceneInstance> handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle) { }

	// RVA: 0x851C098 Offset: 0x8518098 VA: 0x851C098
	internal AsyncOperationHandle<SceneInstance> InternalUnloadScene(AsyncOperationHandle<SceneInstance> handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle) { }

	// RVA: 0x8517050 Offset: 0x8513050 VA: 0x8517050
	private object EvaluateKey(object obj) { }

	// RVA: 0x8514CC4 Offset: 0x8510CC4 VA: 0x8514CC4
	internal AsyncOperationHandle<List<string>> CheckForCatalogUpdates(bool autoReleaseHandle = True) { }

	// RVA: 0x851C174 Offset: 0x8518174 VA: 0x851C174
	internal AsyncOperationHandle<List<string>> CheckForCatalogUpdatesWithChain(bool autoReleaseHandle) { }

	// RVA: 0x85122D4 Offset: 0x850E2D4 VA: 0x85122D4
	public ResourceLocatorInfo GetLocatorInfo(string c) { }

	// RVA: 0x851C960 Offset: 0x8518960 VA: 0x851C960
	internal IEnumerable<string> get_CatalogsWithAvailableUpdates() { }

	// RVA: 0x8514EEC Offset: 0x8510EEC VA: 0x8514EEC
	internal AsyncOperationHandle<List<IResourceLocator>> UpdateCatalogs(IEnumerable<string> catalogIds, bool autoReleaseHandle = True, bool autoCleanBundleCache = False) { }

	// RVA: 0x851D2C4 Offset: 0x85192C4 VA: 0x851D2C4 Slot: 4
	public bool Equals(IResourceLocation x, IResourceLocation y) { }

	// RVA: 0x851D5A4 Offset: 0x85195A4 VA: 0x851D5A4 Slot: 5
	public int GetHashCode(IResourceLocation loc) { }

	// RVA: 0x8515708 Offset: 0x8511708 VA: 0x8515708
	internal AsyncOperationHandle<bool> CleanBundleCache(IEnumerable<string> catalogIds, bool forceSingleThreading) { }

	// RVA: 0x851D820 Offset: 0x8519820 VA: 0x851D820
	internal AsyncOperationHandle<bool> CleanBundleCache(AsyncOperationHandle<IList<AsyncOperationHandle>> depOp, bool forceSingleThreading) { }

	// RVA: 0x851D9D0 Offset: 0x85199D0 VA: 0x851D9D0
	internal AsyncOperationHandle<bool> CleanBundleCacheWithChain(AsyncOperationHandle<IList<AsyncOperationHandle>> depOp, bool forceSingleThreading) { }

	// RVA: 0x851D6D4 Offset: 0x85196D4 VA: 0x851D6D4
	internal AsyncOperationHandle<bool> CleanBundleCacheWithChain(IEnumerable<string> catalogIds, bool forceSingleThreading) { }

	[CompilerGenerated]
	// RVA: 0x851DD18 Offset: 0x8519D18 VA: 0x851DD18
	private void <TrackHandle>b__73_0(AsyncOperationHandle<SceneInstance> sceneHandle) { }

	[CompilerGenerated]
	// RVA: 0x851DDD4 Offset: 0x8519DD4 VA: 0x851DDD4
	private AsyncOperationHandle<long> <GetRemoteCatalogHeaderSize>b__102_0(AsyncOperationHandle<UnityWebRequest> getOp) { }
}

// Namespace: UnityEngine.AddressableAssets
[Serializable]
public class AssetLabelReference : IKeyEvaluator // TypeDefIndex: 26200
{
	// Fields
	[FormerlySerializedAs("m_labelString")]
	[SerializeField]
	private string m_LabelString; // 0x10

	// Properties
	public string labelString { get; set; }
	public object RuntimeKey { get; }

	// Methods

	// RVA: 0x851EE3C Offset: 0x851AE3C VA: 0x851EE3C
	public string get_labelString() { }

	// RVA: 0x851EE44 Offset: 0x851AE44 VA: 0x851EE44
	public void set_labelString(string value) { }

	// RVA: 0x851EE4C Offset: 0x851AE4C VA: 0x851EE4C Slot: 4
	public object get_RuntimeKey() { }

	// RVA: 0x851EEB0 Offset: 0x851AEB0 VA: 0x851EEB0 Slot: 5
	public bool RuntimeKeyIsValid() { }

	// RVA: 0x851EEE4 Offset: 0x851AEE4 VA: 0x851EEE4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x851EF04 Offset: 0x851AF04 VA: 0x851EF04
	public void .ctor() { }
}

// Namespace: UnityEngine.AddressableAssets
[Serializable]
public class AssetReferenceT<TObject> : AssetReference // TypeDefIndex: 26201
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(string guid) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x549134C Offset: 0x548D34C VA: 0x549134C
	|-AssetReferenceT<object>..ctor
	*/

	[Obsolete]
	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> LoadAsset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5491354 Offset: 0x548D354 VA: 0x5491354
	|-AssetReferenceT<object>.LoadAsset
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public virtual AsyncOperationHandle<TObject> LoadAssetAsync() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5491390 Offset: 0x548D390 VA: 0x5491390
	|-AssetReferenceT<object>.LoadAssetAsync
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public override bool ValidateAsset(Object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54913FC Offset: 0x548D3FC VA: 0x54913FC
	|-AssetReferenceT<object>.ValidateAsset
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public override bool ValidateAsset(string mainAssetPath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5491498 Offset: 0x548D498 VA: 0x5491498
	|-AssetReferenceT<object>.ValidateAsset
	*/
}

// Namespace: UnityEngine.AddressableAssets
[Serializable]
public class AssetReferenceGameObject : AssetReferenceT<GameObject> // TypeDefIndex: 26202
{
	// Methods

	// RVA: 0x851EF0C Offset: 0x851AF0C VA: 0x851EF0C
	public void .ctor(string guid) { }
}

// Namespace: UnityEngine.AddressableAssets
[Serializable]
public class AssetReferenceTexture : AssetReferenceT<Texture> // TypeDefIndex: 26203
{
	// Methods

	// RVA: 0x851EF64 Offset: 0x851AF64 VA: 0x851EF64
	public void .ctor(string guid) { }
}

// Namespace: UnityEngine.AddressableAssets
[Serializable]
public class AssetReferenceTexture2D : AssetReferenceT<Texture2D> // TypeDefIndex: 26204
{
	// Methods

	// RVA: 0x851EFBC Offset: 0x851AFBC VA: 0x851EFBC
	public void .ctor(string guid) { }
}

// Namespace: UnityEngine.AddressableAssets
[Serializable]
public class AssetReferenceTexture3D : AssetReferenceT<Texture3D> // TypeDefIndex: 26205
{
	// Methods

	// RVA: 0x851F014 Offset: 0x851B014 VA: 0x851F014
	public void .ctor(string guid) { }
}

// Namespace: UnityEngine.AddressableAssets
[Serializable]
public class AssetReferenceSprite : AssetReferenceT<Sprite> // TypeDefIndex: 26206
{
	// Methods

	// RVA: 0x851F06C Offset: 0x851B06C VA: 0x851F06C
	public void .ctor(string guid) { }

	// RVA: 0x851F0C4 Offset: 0x851B0C4 VA: 0x851F0C4 Slot: 21
	public override bool ValidateAsset(string path) { }
}

// Namespace: UnityEngine.AddressableAssets
[Serializable]
public class AssetReferenceAtlasedSprite : AssetReferenceT<Sprite> // TypeDefIndex: 26207
{
	// Methods

	// RVA: 0x851F0CC Offset: 0x851B0CC VA: 0x851F0CC
	public void .ctor(string guid) { }

	// RVA: 0x851F124 Offset: 0x851B124 VA: 0x851F124 Slot: 20
	public override bool ValidateAsset(Object obj) { }

	// RVA: 0x851F19C Offset: 0x851B19C VA: 0x851F19C Slot: 21
	public override bool ValidateAsset(string path) { }
}

// Namespace: UnityEngine.AddressableAssets
[Serializable]
public class AssetReference : IKeyEvaluator // TypeDefIndex: 26208
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("m_assetGUID")]
	protected internal string m_AssetGUID; // 0x10
	[SerializeField]
	private string m_SubObjectName; // 0x18
	[SerializeField]
	private string m_SubObjectType; // 0x20
	private AsyncOperationHandle m_Operation; // 0x28

	// Properties
	public AsyncOperationHandle OperationHandle { get; set; }
	public virtual object RuntimeKey { get; }
	public virtual string AssetGUID { get; }
	public virtual string SubObjectName { get; set; }
	internal virtual Type SubOjbectType { get; }
	public bool IsDone { get; }
	public virtual Object Asset { get; }

	// Methods

	// RVA: 0x851F1A4 Offset: 0x851B1A4 VA: 0x851F1A4
	public AsyncOperationHandle get_OperationHandle() { }

	// RVA: 0x851F1B8 Offset: 0x851B1B8 VA: 0x851F1B8
	internal void set_OperationHandle(AsyncOperationHandle value) { }

	// RVA: 0x851F1D8 Offset: 0x851B1D8 VA: 0x851F1D8 Slot: 6
	public virtual object get_RuntimeKey() { }

	// RVA: 0x851F27C Offset: 0x851B27C VA: 0x851F27C Slot: 7
	public virtual string get_AssetGUID() { }

	// RVA: 0x851F284 Offset: 0x851B284 VA: 0x851F284 Slot: 8
	public virtual string get_SubObjectName() { }

	// RVA: 0x851F28C Offset: 0x851B28C VA: 0x851F28C Slot: 9
	public virtual void set_SubObjectName(string value) { }

	// RVA: 0x851F294 Offset: 0x851B294 VA: 0x851F294 Slot: 10
	internal virtual Type get_SubOjbectType() { }

	// RVA: 0x851F340 Offset: 0x851B340 VA: 0x851F340
	public bool IsValid() { }

	// RVA: 0x851F34C Offset: 0x851B34C VA: 0x851F34C
	public bool get_IsDone() { }

	// RVA: 0x851F358 Offset: 0x851B358 VA: 0x851F358
	public void .ctor() { }

	// RVA: 0x851F3B0 Offset: 0x851B3B0 VA: 0x851F3B0
	public void .ctor(string guid) { }

	// RVA: 0x851F428 Offset: 0x851B428 VA: 0x851F428 Slot: 11
	public virtual Object get_Asset() { }

	// RVA: 0x851F4C8 Offset: 0x851B4C8 VA: 0x851F4C8 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1
	private static AsyncOperationHandle<T> CreateFailedOperation<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4502AF8 Offset: 0x44FEAF8 VA: 0x4502AF8
	|-AssetReference.CreateFailedOperation<__Il2CppFullySharedGenericType>
	*/

	[Obsolete]
	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> LoadAsset<TObject>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4502CA8 Offset: 0x44FECA8 VA: 0x4502CA8
	|-AssetReference.LoadAsset<__Il2CppFullySharedGenericType>
	*/

	[Obsolete]
	// RVA: 0x851F534 Offset: 0x851B534 VA: 0x851F534
	public AsyncOperationHandle<SceneInstance> LoadScene() { }

	[Obsolete]
	// RVA: 0x851F57C Offset: 0x851B57C VA: 0x851F57C
	public AsyncOperationHandle<GameObject> Instantiate(Vector3 position, Quaternion rotation, Transform parent) { }

	[Obsolete]
	// RVA: 0x851F5B8 Offset: 0x851B5B8 VA: 0x851F5B8
	public AsyncOperationHandle<GameObject> Instantiate(Transform parent, bool instantiateInWorldSpace = False) { }

	// RVA: -1 Offset: -1 Slot: 12
	public virtual AsyncOperationHandle<TObject> LoadAssetAsync<TObject>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4502D20 Offset: 0x44FED20 VA: 0x4502D20
	|-AssetReference.LoadAssetAsync<object>
	|
	|-RVA: 0x4502E7C Offset: 0x44FEE7C VA: 0x4502E7C
	|-AssetReference.LoadAssetAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x851F5F8 Offset: 0x851B5F8 VA: 0x851F5F8 Slot: 13
	public virtual AsyncOperationHandle<SceneInstance> LoadSceneAsync(LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x851F774 Offset: 0x851B774 VA: 0x851F774 Slot: 14
	public virtual AsyncOperationHandle<SceneInstance> UnLoadScene() { }

	// RVA: 0x851F818 Offset: 0x851B818 VA: 0x851F818 Slot: 15
	public virtual AsyncOperationHandle<GameObject> InstantiateAsync(Vector3 position, Quaternion rotation, Transform parent) { }

	// RVA: 0x851F914 Offset: 0x851B914 VA: 0x851F914 Slot: 16
	public virtual AsyncOperationHandle<GameObject> InstantiateAsync(Transform parent, bool instantiateInWorldSpace = False) { }

	// RVA: 0x851F9C4 Offset: 0x851B9C4 VA: 0x851F9C4 Slot: 17
	public virtual bool RuntimeKeyIsValid() { }

	// RVA: 0x851FA44 Offset: 0x851BA44 VA: 0x851FA44 Slot: 18
	public virtual void ReleaseAsset() { }

	// RVA: 0x851FAE4 Offset: 0x851BAE4 VA: 0x851FAE4 Slot: 19
	public virtual void ReleaseInstance(GameObject obj) { }

	// RVA: 0x851FB38 Offset: 0x851BB38 VA: 0x851FB38 Slot: 20
	public virtual bool ValidateAsset(Object obj) { }

	// RVA: 0x851FB40 Offset: 0x851BB40 VA: 0x851FB40 Slot: 21
	public virtual bool ValidateAsset(string path) { }
}

// Namespace: UnityEngine.AddressableAssets
public interface IKeyEvaluator // TypeDefIndex: 26209
{
	// Properties
	public abstract object RuntimeKey { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_RuntimeKey();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool RuntimeKeyIsValid();
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class CheckCatalogsOperation.<>c // TypeDefIndex: 26210
{
	// Fields
	public static readonly CheckCatalogsOperation.<>c <>9; // 0x0
	public static Func<IResourceProvider, bool> <>9__5_0; // 0x8

	// Methods

	// RVA: 0x85204EC Offset: 0x851C4EC VA: 0x85204EC
	private static void .cctor() { }

	// RVA: 0x8520554 Offset: 0x851C554 VA: 0x8520554
	public void .ctor() { }

	// RVA: 0x852055C Offset: 0x851C55C VA: 0x852055C
	internal bool <Start>b__5_0(IResourceProvider rp) { }
}

// Namespace: UnityEngine.AddressableAssets
internal class CheckCatalogsOperation : AsyncOperationBase<List<string>> // TypeDefIndex: 26211
{
	// Fields
	private AddressablesImpl m_Addressables; // 0x98
	private List<string> m_LocalHashes; // 0xA0
	private List<ResourceLocatorInfo> m_LocatorInfos; // 0xA8
	private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp; // 0xB0

	// Methods

	// RVA: 0x851C2AC Offset: 0x85182AC VA: 0x851C2AC
	public void .ctor(AddressablesImpl aa) { }

	// RVA: 0x851C310 Offset: 0x8518310 VA: 0x851C310
	public AsyncOperationHandle<List<string>> Start(List<ResourceLocatorInfo> locatorInfos) { }

	// RVA: 0x851FB48 Offset: 0x851BB48 VA: 0x851FB48 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x851FC7C Offset: 0x851BC7C VA: 0x851FC7C Slot: 29
	protected override void Destroy() { }

	// RVA: 0x851FCC4 Offset: 0x851BCC4 VA: 0x851FCC4 Slot: 32
	public override void GetDependencies(List<AsyncOperationHandle> dependencies) { }

	// RVA: 0x851FDF4 Offset: 0x851BDF4 VA: 0x851FDF4
	internal static List<string> ProcessDependentOpResults(IList<AsyncOperationHandle> results, List<ResourceLocatorInfo> locatorInfos, List<string> localHashes, out string errorString, out bool success) { }

	// RVA: 0x852044C Offset: 0x851C44C VA: 0x852044C Slot: 28
	protected override void Execute() { }
}

// Namespace: UnityEngine.AddressableAssets
internal class CleanBundleCacheOperation : AsyncOperationBase<bool>, IUpdateReceiver // TypeDefIndex: 26212
{
	// Fields
	private AddressablesImpl m_Addressables; // 0x98
	private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp; // 0xA0
	private List<string> m_CacheDirsForRemoval; // 0xB8
	private Thread m_EnumerationThread; // 0xC0
	private string m_BaseCachePath; // 0xC8
	private bool m_UseMultiThreading; // 0xD0

	// Methods

	// RVA: 0x851DB28 Offset: 0x8519B28 VA: 0x851DB28
	public void .ctor(AddressablesImpl aa, bool forceSingleThreading) { }

	// RVA: 0x851DBDC Offset: 0x8519BDC VA: 0x851DBDC
	public AsyncOperationHandle<bool> Start(AsyncOperationHandle<IList<AsyncOperationHandle>> depOp) { }

	// RVA: 0x85205F8 Offset: 0x851C5F8 VA: 0x85205F8
	public void CompleteInternal(bool result, bool success, string errorMsg) { }

	// RVA: 0x8520688 Offset: 0x851C688 VA: 0x8520688 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x85208EC Offset: 0x851C8EC VA: 0x85208EC Slot: 29
	protected override void Destroy() { }

	// RVA: 0x8520968 Offset: 0x851C968 VA: 0x8520968 Slot: 32
	public override void GetDependencies(List<AsyncOperationHandle> dependencies) { }

	// RVA: 0x8520A98 Offset: 0x851CA98 VA: 0x8520A98 Slot: 28
	protected override void Execute() { }

	// RVA: 0x85219D8 Offset: 0x851D9D8 VA: 0x85219D8 Slot: 36
	private void UnityEngine.ResourceManagement.IUpdateReceiver.Update(float unscaledDeltaTime) { }

	// RVA: 0x8520758 Offset: 0x851C758 VA: 0x8520758
	private void RemoveCacheEntries() { }

	// RVA: 0x8521A34 Offset: 0x851DA34 VA: 0x8521A34
	private void DetermineCacheDirsNotInUse(object data) { }

	// RVA: 0x85215B0 Offset: 0x851D5B0 VA: 0x85215B0
	private void DetermineCacheDirsNotInUse(HashSet<string> cacheDirsInUse) { }

	// RVA: 0x8520C6C Offset: 0x851CC6C VA: 0x8520C6C
	private HashSet<string> GetCacheDirsInUse(IList<AsyncOperationHandle> catalogOps) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UpdateCatalogsOperation.<>c // TypeDefIndex: 26213
{
	// Fields
	public static readonly UpdateCatalogsOperation.<>c <>9; // 0x0
	public static Func<IResourceProvider, bool> <>9__6_0; // 0x8

	// Methods

	// RVA: 0x85225C4 Offset: 0x851E5C4 VA: 0x85225C4
	private static void .cctor() { }

	// RVA: 0x852262C Offset: 0x851E62C VA: 0x852262C
	public void .ctor() { }

	// RVA: 0x8522634 Offset: 0x851E634 VA: 0x8522634
	internal bool <Start>b__6_0(IResourceProvider rp) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UpdateCatalogsOperation.<>c__DisplayClass11_0 // TypeDefIndex: 26214
{
	// Fields
	public UpdateCatalogsOperation <>4__this; // 0x10
	public List<IResourceLocator> catalogs; // 0x18

	// Methods

	// RVA: 0x85225BC Offset: 0x851E5BC VA: 0x85225BC
	public void .ctor() { }

	// RVA: 0x85226D0 Offset: 0x851E6D0 VA: 0x85226D0
	internal void <OnCleanCacheCompleted>b__0(AsyncOperationHandle<bool> obj) { }
}

// Namespace: UnityEngine.AddressableAssets
internal class UpdateCatalogsOperation : AsyncOperationBase<List<IResourceLocator>> // TypeDefIndex: 26215
{
	// Fields
	private AddressablesImpl m_Addressables; // 0x98
	private List<ResourceLocatorInfo> m_LocatorInfos; // 0xA0
	internal AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp; // 0xA8
	private AsyncOperationHandle<bool> m_CleanCacheOp; // 0xC0
	private bool m_AutoCleanBundleCache; // 0xD8

	// Methods

	// RVA: 0x851CB24 Offset: 0x8518B24 VA: 0x851CB24
	public void .ctor(AddressablesImpl aa) { }

	// RVA: 0x851CB88 Offset: 0x8518B88 VA: 0x851CB88
	public AsyncOperationHandle<List<IResourceLocator>> Start(IEnumerable<string> catalogIds, bool autoCleanBundleCache) { }

	// RVA: 0x8521AE4 Offset: 0x851DAE4 VA: 0x8521AE4 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x8521C90 Offset: 0x851DC90 VA: 0x8521C90 Slot: 29
	protected override void Destroy() { }

	// RVA: 0x8521CD8 Offset: 0x851DCD8 VA: 0x8521CD8 Slot: 32
	public override void GetDependencies(List<AsyncOperationHandle> dependencies) { }

	// RVA: 0x8521E08 Offset: 0x851DE08 VA: 0x8521E08 Slot: 28
	protected override void Execute() { }

	// RVA: 0x85224C4 Offset: 0x851E4C4 VA: 0x85224C4
	private void OnCleanCacheCompleted(AsyncOperationHandle<bool> handle, List<IResourceLocator> catalogs) { }
}

// Namespace: UnityEngine.AddressableAssets
internal class DynamicResourceLocator : IResourceLocator // TypeDefIndex: 26216
{
	// Fields
	private AddressablesImpl m_Addressables; // 0x10
	private string m_AtlasSpriteProviderId; // 0x18

	// Properties
	public string LocatorId { get; }
	public virtual IEnumerable<object> Keys { get; }
	private string AtlasSpriteProviderId { get; }
	public IEnumerable<IResourceLocation> AllLocations { get; }

	// Methods

	// RVA: 0x8522858 Offset: 0x851E858 VA: 0x8522858 Slot: 4
	public string get_LocatorId() { }

	// RVA: 0x8522898 Offset: 0x851E898 VA: 0x8522898 Slot: 7
	public virtual IEnumerable<object> get_Keys() { }

	// RVA: 0x85228DC Offset: 0x851E8DC VA: 0x85228DC
	private string get_AtlasSpriteProviderId() { }

	// RVA: 0x8522D3C Offset: 0x851ED3C VA: 0x8522D3C
	public IEnumerable<IResourceLocation> get_AllLocations() { }

	// RVA: 0x8522D80 Offset: 0x851ED80 VA: 0x8522D80
	public void .ctor(AddressablesImpl addr) { }

	// RVA: 0x8522DB0 Offset: 0x851EDB0 VA: 0x8522DB0 Slot: 6
	public bool Locate(object key, Type type, out IList<IResourceLocation> locations) { }

	// RVA: 0x8523324 Offset: 0x851F324 VA: 0x8523324
	internal void CreateDynamicLocations(Type type, IList<IResourceLocation> locations, string locName, string subKey, IResourceLocation mainLoc) { }
}

// Namespace: UnityEngine.AddressableAssets
public enum AddressablesPlatform // TypeDefIndex: 26217
{
	// Fields
	public int value__; // 0x0
	public const AddressablesPlatform Unknown = 0;
	public const AddressablesPlatform Windows = 1;
	public const AddressablesPlatform OSX = 2;
	public const AddressablesPlatform Linux = 3;
	public const AddressablesPlatform PS4 = 4;
	public const AddressablesPlatform Switch = 5;
	public const AddressablesPlatform XboxOne = 6;
	public const AddressablesPlatform WebGL = 7;
	public const AddressablesPlatform iOS = 8;
	public const AddressablesPlatform Android = 9;
	public const AddressablesPlatform WindowsUniversal = 10;
}

// Namespace: UnityEngine.AddressableAssets
public class PlatformMappingService // TypeDefIndex: 26218
{
	// Fields
	internal static readonly Dictionary<RuntimePlatform, AddressablesPlatform> s_RuntimeTargetMapping; // 0x0

	// Methods

	// RVA: 0x85239C0 Offset: 0x851F9C0 VA: 0x85239C0
	internal static AddressablesPlatform GetAddressablesPlatformInternal(RuntimePlatform platform) { }

	// RVA: 0x8523A94 Offset: 0x851FA94 VA: 0x8523A94
	internal static string GetAddressablesPlatformPathInternal(RuntimePlatform platform) { }

	[Obsolete("This API doesn't adapt to the addition of new platforms.  Use GetPlatformPathSubFolder instead.")]
	// RVA: 0x8523BB4 Offset: 0x851FBB4 VA: 0x8523BB4
	public static AddressablesPlatform GetPlatform() { }

	// RVA: 0x8516824 Offset: 0x8512824 VA: 0x8516824
	public static string GetPlatformPathSubFolder() { }

	// RVA: 0x8523C38 Offset: 0x851FC38 VA: 0x8523C38
	public void .ctor() { }

	// RVA: 0x8523C40 Offset: 0x851FC40 VA: 0x8523C40
	private static void .cctor() { }
}

// Namespace: UnityEngine.AddressableAssets.Utility
internal class DiagnosticInfo // TypeDefIndex: 26219
{
	// Fields
	public string DisplayName; // 0x10
	public int ObjectId; // 0x18
	public int[] Dependencies; // 0x20

	// Methods

	// RVA: 0x8523E18 Offset: 0x851FE18 VA: 0x8523E18
	public DiagnosticEvent CreateEvent(string category, ResourceManager.DiagnosticEventType eventType, int frame, int val) { }

	// RVA: 0x8523E5C Offset: 0x851FE5C VA: 0x8523E5C
	public void .ctor() { }
}

// Namespace: UnityEngine.AddressableAssets.Utility
internal class ResourceManagerDiagnostics : IDisposable // TypeDefIndex: 26220
{
	// Fields
	private ResourceManager m_ResourceManager; // 0x10
	private const int k_NumberOfCompletedOpResultEntriesToShow = 4;
	private const int k_MaximumCompletedOpResultEntryLength = 30;
	private Dictionary<int, DiagnosticInfo> m_cachedDiagnosticInfo; // 0x18

	// Methods

	// RVA: 0x8523E64 Offset: 0x851FE64 VA: 0x8523E64
	public void .ctor(ResourceManager resourceManager) { }

	// RVA: 0x8523F64 Offset: 0x851FF64 VA: 0x8523F64
	internal int SumDependencyNameHashCodes(AsyncOperationHandle handle) { }

	// RVA: 0x8524190 Offset: 0x8520190 VA: 0x8524190
	internal int CalculateHashCode(AsyncOperationHandle handle) { }

	// RVA: 0x85242D4 Offset: 0x85202D4 VA: 0x85242D4
	internal int CalculateCompletedOperationHashcode(AsyncOperationHandle handle) { }

	// RVA: 0x8524360 Offset: 0x8520360 VA: 0x8524360
	internal string GenerateCompletedOperationDisplayName(AsyncOperationHandle handle) { }

	// RVA: 0x85247AC Offset: 0x85207AC VA: 0x85247AC
	private void OnResourceManagerDiagnosticEvent(ResourceManager.DiagnosticEventContext eventContext) { }

	// RVA: 0x8524B9C Offset: 0x8520B9C VA: 0x8524B9C Slot: 4
	public void Dispose() { }
}

// Namespace: 
internal enum SerializationUtilities.ObjectType // TypeDefIndex: 26221
{
	// Fields
	public int value__; // 0x0
	public const SerializationUtilities.ObjectType AsciiString = 0;
	public const SerializationUtilities.ObjectType UnicodeString = 1;
	public const SerializationUtilities.ObjectType UInt16 = 2;
	public const SerializationUtilities.ObjectType UInt32 = 3;
	public const SerializationUtilities.ObjectType Int32 = 4;
	public const SerializationUtilities.ObjectType Hash128 = 5;
	public const SerializationUtilities.ObjectType Type = 6;
	public const SerializationUtilities.ObjectType JsonObject = 7;
}

// Namespace: UnityEngine.AddressableAssets.Utility
internal static class SerializationUtilities // TypeDefIndex: 26222
{
	// Methods

	// RVA: 0x8524C74 Offset: 0x8520C74 VA: 0x8524C74
	internal static int ReadInt32FromByteArray(byte[] data, int offset) { }

	// RVA: 0x8524CE8 Offset: 0x8520CE8 VA: 0x8524CE8
	internal static int WriteInt32ToByteArray(byte[] data, int val, int offset) { }

	// RVA: 0x8524D6C Offset: 0x8520D6C VA: 0x8524D6C
	internal static object ReadObjectFromByteArray(byte[] keyData, int dataIndex) { }

	// RVA: 0x8525280 Offset: 0x8521280 VA: 0x8525280
	internal static int WriteObjectToByteList(object obj, List<byte> buffer) { }
}

// Namespace: 
public enum ContentCatalogProvider.DependencyHashIndex // TypeDefIndex: 26223
{
	// Fields
	public int value__; // 0x0
	public const ContentCatalogProvider.DependencyHashIndex Remote = 0;
	public const ContentCatalogProvider.DependencyHashIndex Cache = 1;
	public const ContentCatalogProvider.DependencyHashIndex Count = 2;
}

// Namespace: 
internal class ContentCatalogProvider.InternalOp.BundledCatalog // TypeDefIndex: 26224
{
	// Fields
	private readonly string m_BundlePath; // 0x10
	private bool m_OpInProgress; // 0x18
	private AssetBundleCreateRequest m_LoadBundleRequest; // 0x20
	internal AssetBundle m_CatalogAssetBundle; // 0x28
	private AssetBundleRequest m_LoadTextAssetRequest; // 0x30
	private ContentCatalogData m_CatalogData; // 0x38
	private WebRequestQueueOperation m_WebRequestQueueOperation; // 0x40
	private AsyncOperation m_RequestOperation; // 0x48
	private int m_WebRequestTimeout; // 0x50
	[CompilerGenerated]
	private Action<ContentCatalogData> OnLoaded; // 0x58

	// Properties
	public bool OpInProgress { get; }
	public bool OpIsSuccess { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x85273E4 Offset: 0x85233E4 VA: 0x85273E4
	public void add_OnLoaded(Action<ContentCatalogData> value) { }

	[CompilerGenerated]
	// RVA: 0x8528168 Offset: 0x8524168 VA: 0x8528168
	public void remove_OnLoaded(Action<ContentCatalogData> value) { }

	// RVA: 0x8528218 Offset: 0x8524218 VA: 0x8528218
	public bool get_OpInProgress() { }

	// RVA: 0x8528220 Offset: 0x8524220 VA: 0x8528220
	public bool get_OpIsSuccess() { }

	// RVA: 0x85272B4 Offset: 0x85232B4 VA: 0x85272B4
	public void .ctor(string bundlePath, int webRequestTimeout = 0) { }

	// RVA: 0x8528240 Offset: 0x8524240 VA: 0x8528240 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x85282D4 Offset: 0x85242D4 VA: 0x85282D4
	private void Unload() { }

	// RVA: 0x8527494 Offset: 0x8523494 VA: 0x8527494
	public void LoadCatalogFromBundleAsync() { }

	// RVA: 0x8528304 Offset: 0x8524304 VA: 0x8528304
	private void WebRequestOperationCompleted(AsyncOperation op) { }

	// RVA: 0x8528530 Offset: 0x8524530 VA: 0x8528530
	private void LoadTextAssetRequestComplete(AsyncOperation op) { }

	// RVA: 0x8527048 Offset: 0x8523048 VA: 0x8527048
	public bool WaitForCompletion() { }

	[CompilerGenerated]
	// RVA: 0x85286C8 Offset: 0x85246C8 VA: 0x85286C8
	private void <LoadCatalogFromBundleAsync>b__19_1(UnityWebRequestAsyncOperation asyncOp) { }

	[CompilerGenerated]
	// RVA: 0x8528770 Offset: 0x8524770 VA: 0x8528770
	private void <LoadCatalogFromBundleAsync>b__19_0(AsyncOperation loadOp) { }
}

// Namespace: 
internal class ContentCatalogProvider.InternalOp // TypeDefIndex: 26225
{
	// Fields
	private string m_LocalDataPath; // 0x10
	private string m_RemoteHashValue; // 0x18
	internal string m_LocalHashValue; // 0x20
	private ProvideHandle m_ProviderInterface; // 0x28
	internal ContentCatalogData m_ContentCatalogData; // 0x40
	private AsyncOperationHandle<ContentCatalogData> m_ContentCatalogDataLoadOp; // 0x48
	private ContentCatalogProvider.InternalOp.BundledCatalog m_BundledCatalog; // 0x60
	private bool m_Retried; // 0x68
	private bool m_DisableCatalogUpdateOnStart; // 0x69
	private bool m_IsLocalCatalogInBundle; // 0x6A
	private const string kCatalogExt = ".json";

	// Methods

	// RVA: 0x8526034 Offset: 0x8522034 VA: 0x8526034
	public void Start(ProvideHandle providerInterface, bool disableCatalogUpdateOnStart, bool isLocalCatalogInBundle) { }

	// RVA: 0x8526F80 Offset: 0x8522F80 VA: 0x8526F80
	private bool WaitForCompletionCallback() { }

	// RVA: 0x8525EC4 Offset: 0x8521EC4 VA: 0x8525EC4
	public void Release() { }

	// RVA: 0x85269E8 Offset: 0x85229E8 VA: 0x85269E8
	internal bool CanLoadCatalogFromBundle(string idToLoad, IResourceLocation location) { }

	// RVA: 0x8526AAC Offset: 0x8522AAC VA: 0x8526AAC
	internal void LoadCatalog(string idToLoad, bool loadCatalogFromLocalBundle) { }

	// RVA: 0x8527760 Offset: 0x8523760 VA: 0x8527760
	private void CatalogLoadOpCompleteCallback(AsyncOperationHandle<ContentCatalogData> op) { }

	// RVA: 0x85271F8 Offset: 0x85231F8 VA: 0x85271F8
	private string GetTransformedInternalId(IResourceLocation loc) { }

	// RVA: 0x85261D0 Offset: 0x85221D0 VA: 0x85261D0
	internal string DetermineIdToLoad(IResourceLocation location, IList<object> dependencyObjects, bool disableCatalogUpdateOnStart = False) { }

	// RVA: 0x85277F4 Offset: 0x85237F4 VA: 0x85277F4
	private void OnCatalogLoaded(ContentCatalogData ccd) { }

	// RVA: 0x852602C Offset: 0x852202C VA: 0x852602C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x852813C Offset: 0x852413C VA: 0x852813C
	private void <LoadCatalog>b__14_0(ContentCatalogData ccd) { }
}

// Namespace: UnityEngine.AddressableAssets.ResourceProviders
[DisplayName("Content Catalog Provider")]
public class ContentCatalogProvider : ResourceProviderBase // TypeDefIndex: 26226
{
	// Fields
	public bool DisableCatalogUpdateOnStart; // 0x1C
	public bool IsLocalCatalogInBundle; // 0x1D
	internal Dictionary<IResourceLocation, ContentCatalogProvider.InternalOp> m_LocationToCatalogLoadOpMap; // 0x20

	// Methods

	// RVA: 0x8525D54 Offset: 0x8521D54 VA: 0x8525D54
	public void .ctor(ResourceManager resourceManagerInstance) { }

	// RVA: 0x8525DE8 Offset: 0x8521DE8 VA: 0x8525DE8 Slot: 15
	public override void Release(IResourceLocation location, object obj) { }

	// RVA: 0x8525ED4 Offset: 0x8521ED4 VA: 0x8525ED4 Slot: 17
	public override void Provide(ProvideHandle providerInterface) { }
}

// Namespace: UnityEngine.AddressableAssets.ResourceLocators
public class ContentCatalogDataEntry // TypeDefIndex: 26227
{
	// Fields
	[CompilerGenerated]
	private string <InternalId>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Provider>k__BackingField; // 0x18
	[CompilerGenerated]
	private List<object> <Keys>k__BackingField; // 0x20
	[CompilerGenerated]
	private List<object> <Dependencies>k__BackingField; // 0x28
	[CompilerGenerated]
	private object <Data>k__BackingField; // 0x30
	[CompilerGenerated]
	private Type <ResourceType>k__BackingField; // 0x38

	// Properties
	public string InternalId { get; set; }
	public string Provider { get; set; }
	public List<object> Keys { get; set; }
	public List<object> Dependencies { get; set; }
	public object Data { get; set; }
	public Type ResourceType { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x852896C Offset: 0x852496C VA: 0x852896C
	public string get_InternalId() { }

	[CompilerGenerated]
	// RVA: 0x8528974 Offset: 0x8524974 VA: 0x8528974
	public void set_InternalId(string value) { }

	[CompilerGenerated]
	// RVA: 0x852897C Offset: 0x852497C VA: 0x852897C
	public string get_Provider() { }

	[CompilerGenerated]
	// RVA: 0x8528984 Offset: 0x8524984 VA: 0x8528984
	private void set_Provider(string value) { }

	[CompilerGenerated]
	// RVA: 0x852898C Offset: 0x852498C VA: 0x852898C
	public List<object> get_Keys() { }

	[CompilerGenerated]
	// RVA: 0x8528994 Offset: 0x8524994 VA: 0x8528994
	private void set_Keys(List<object> value) { }

	[CompilerGenerated]
	// RVA: 0x852899C Offset: 0x852499C VA: 0x852899C
	public List<object> get_Dependencies() { }

	[CompilerGenerated]
	// RVA: 0x85289A4 Offset: 0x85249A4 VA: 0x85289A4
	private void set_Dependencies(List<object> value) { }

	[CompilerGenerated]
	// RVA: 0x85289AC Offset: 0x85249AC VA: 0x85289AC
	public object get_Data() { }

	[CompilerGenerated]
	// RVA: 0x85289B4 Offset: 0x85249B4 VA: 0x85289B4
	public void set_Data(object value) { }

	[CompilerGenerated]
	// RVA: 0x85289BC Offset: 0x85249BC VA: 0x85289BC
	public Type get_ResourceType() { }

	[CompilerGenerated]
	// RVA: 0x85289C4 Offset: 0x85249C4 VA: 0x85289C4
	private void set_ResourceType(Type value) { }

	// RVA: 0x85289CC Offset: 0x85249CC VA: 0x85289CC
	public void .ctor(Type type, string internalId, string provider, IEnumerable<object> keys, IEnumerable<object> dependencies, object extraData) { }
}

// Namespace: 
private struct ContentCatalogData.Bucket // TypeDefIndex: 26228
{
	// Fields
	public int dataOffset; // 0x0
	public int[] entries; // 0x8
}

// Namespace: 
private class ContentCatalogData.CompactLocation : IResourceLocation // TypeDefIndex: 26229
{
	// Fields
	private ResourceLocationMap m_Locator; // 0x10
	private string m_InternalId; // 0x18
	private string m_ProviderId; // 0x20
	private object m_Dependency; // 0x28
	private object m_Data; // 0x30
	private int m_HashCode; // 0x38
	private int m_DependencyHashCode; // 0x3C
	private string m_PrimaryKey; // 0x40
	private Type m_Type; // 0x48

	// Properties
	public string InternalId { get; }
	public string ProviderId { get; }
	public IList<IResourceLocation> Dependencies { get; }
	public bool HasDependencies { get; }
	public int DependencyHashCode { get; }
	public object Data { get; }
	public string PrimaryKey { get; set; }
	public Type ResourceType { get; }

	// Methods

	// RVA: 0x852AF58 Offset: 0x8526F58 VA: 0x852AF58 Slot: 4
	public string get_InternalId() { }

	// RVA: 0x852AF60 Offset: 0x8526F60 VA: 0x852AF60 Slot: 5
	public string get_ProviderId() { }

	// RVA: 0x852AF68 Offset: 0x8526F68 VA: 0x852AF68 Slot: 6
	public IList<IResourceLocation> get_Dependencies() { }

	// RVA: 0x852B01C Offset: 0x852701C VA: 0x852B01C Slot: 9
	public bool get_HasDependencies() { }

	// RVA: 0x852B02C Offset: 0x852702C VA: 0x852B02C Slot: 8
	public int get_DependencyHashCode() { }

	// RVA: 0x852B034 Offset: 0x8527034 VA: 0x852B034 Slot: 10
	public object get_Data() { }

	// RVA: 0x852B03C Offset: 0x852703C VA: 0x852B03C Slot: 11
	public string get_PrimaryKey() { }

	// RVA: 0x852B044 Offset: 0x8527044 VA: 0x852B044
	public void set_PrimaryKey(string value) { }

	// RVA: 0x852B04C Offset: 0x852704C VA: 0x852B04C Slot: 12
	public Type get_ResourceType() { }

	// RVA: 0x852B054 Offset: 0x8527054 VA: 0x852B054 Slot: 3
	public override string ToString() { }

	// RVA: 0x852B05C Offset: 0x852705C VA: 0x852B05C Slot: 7
	public int Hash(Type t) { }

	// RVA: 0x8529670 Offset: 0x8525670 VA: 0x8529670
	public void .ctor(ResourceLocationMap locator, string internalId, string providerId, object dependencyKey, object data, int depHash, string primaryKey, Type type) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ContentCatalogData.<>c // TypeDefIndex: 26230
{
	// Fields
	public static readonly ContentCatalogData.<>c <>9; // 0x0
	public static Func<IResourceLocation, string> <>9__48_0; // 0x8

	// Methods

	// RVA: 0x852B0B0 Offset: 0x85270B0 VA: 0x852B0B0
	private static void .cctor() { }

	// RVA: 0x852B118 Offset: 0x8527118 VA: 0x852B118
	public void .ctor() { }

	// RVA: 0x852B120 Offset: 0x8527120 VA: 0x852B120
	internal string <GetData>b__48_0(IResourceLocation d) { }
}

// Namespace: UnityEngine.AddressableAssets.ResourceLocators
[Serializable]
public class ContentCatalogData // TypeDefIndex: 26231
{
	// Fields
	private static int kMagic; // 0x0
	private const int kVersion = 1;
	public string LocalHash; // 0x10
	internal IResourceLocation location; // 0x18
	[SerializeField]
	internal string m_LocatorId; // 0x20
	[SerializeField]
	internal string m_BuildResultHash; // 0x28
	[SerializeField]
	private ObjectInitializationData m_InstanceProviderData; // 0x30
	[SerializeField]
	private ObjectInitializationData m_SceneProviderData; // 0x60
	[SerializeField]
	internal List<ObjectInitializationData> m_ResourceProviderData; // 0x90
	private IList<ContentCatalogDataEntry> m_Entries; // 0x98
	[SerializeField]
	[FormerlySerializedAs("m_providerIds")]
	internal string[] m_ProviderIds; // 0xA0
	[FormerlySerializedAs("m_internalIds")]
	[SerializeField]
	internal string[] m_InternalIds; // 0xA8
	[FormerlySerializedAs("m_keyDataString")]
	[SerializeField]
	internal string m_KeyDataString; // 0xB0
	[SerializeField]
	[FormerlySerializedAs("m_bucketDataString")]
	internal string m_BucketDataString; // 0xB8
	[FormerlySerializedAs("m_entryDataString")]
	[SerializeField]
	internal string m_EntryDataString; // 0xC0
	private const int kBytesPerInt32 = 4;
	private const int k_EntryDataItemPerEntry = 7;
	[FormerlySerializedAs("m_extraDataString")]
	[SerializeField]
	internal string m_ExtraDataString; // 0xC8
	[SerializeField]
	internal SerializedType[] m_resourceTypes; // 0xD0
	[SerializeField]
	private string[] m_InternalIdPrefixes; // 0xD8

	// Properties
	public string BuildResultHash { get; set; }
	public string ProviderId { get; set; }
	public ObjectInitializationData InstanceProviderData { get; set; }
	public ObjectInitializationData SceneProviderData { get; set; }
	public List<ObjectInitializationData> ResourceProviderData { get; set; }
	public string[] ProviderIds { get; }
	public string[] InternalIds { get; }

	// Methods

	// RVA: 0x8528B1C Offset: 0x8524B1C VA: 0x8528B1C
	public string get_BuildResultHash() { }

	// RVA: 0x8528B24 Offset: 0x8524B24 VA: 0x8528B24
	public void set_BuildResultHash(string value) { }

	// RVA: 0x8528B2C Offset: 0x8524B2C VA: 0x8528B2C
	public string get_ProviderId() { }

	// RVA: 0x8528B34 Offset: 0x8524B34 VA: 0x8528B34
	internal void set_ProviderId(string value) { }

	// RVA: 0x8528B3C Offset: 0x8524B3C VA: 0x8528B3C
	public ObjectInitializationData get_InstanceProviderData() { }

	// RVA: 0x8528B50 Offset: 0x8524B50 VA: 0x8528B50
	public void set_InstanceProviderData(ObjectInitializationData value) { }

	// RVA: 0x8528B70 Offset: 0x8524B70 VA: 0x8528B70
	public ObjectInitializationData get_SceneProviderData() { }

	// RVA: 0x8528B84 Offset: 0x8524B84 VA: 0x8528B84
	public void set_SceneProviderData(ObjectInitializationData value) { }

	// RVA: 0x8528BA4 Offset: 0x8524BA4 VA: 0x8528BA4
	public List<ObjectInitializationData> get_ResourceProviderData() { }

	// RVA: 0x8528BAC Offset: 0x8524BAC VA: 0x8528BAC
	public void set_ResourceProviderData(List<ObjectInitializationData> value) { }

	// RVA: 0x8528BB4 Offset: 0x8524BB4 VA: 0x8528BB4
	public void .ctor(string id) { }

	// RVA: 0x8528C50 Offset: 0x8524C50 VA: 0x8528C50
	public void .ctor() { }

	// RVA: 0x8528CD8 Offset: 0x8524CD8 VA: 0x8528CD8
	public string[] get_ProviderIds() { }

	// RVA: 0x8528CE0 Offset: 0x8524CE0 VA: 0x8528CE0
	public string[] get_InternalIds() { }

	// RVA: 0x8528CE8 Offset: 0x8524CE8 VA: 0x8528CE8
	internal static ContentCatalogData LoadFromFile(string path, int cacheSize = 1024) { }

	// RVA: 0x8528D38 Offset: 0x8524D38 VA: 0x8528D38
	internal void SaveToFile(string path) { }

	// RVA: 0x852712C Offset: 0x852312C VA: 0x852712C
	internal void CleanData() { }

	// RVA: 0x8521AB8 Offset: 0x851DAB8 VA: 0x8521AB8
	internal ResourceLocationMap CreateCustomLocator(string overrideId = "", string providerSuffix) { }

	// RVA: 0x8528D5C Offset: 0x8524D5C VA: 0x8528D5C
	public ResourceLocationMap CreateLocator(string providerSuffix) { }

	// RVA: 0x8529870 Offset: 0x8525870 VA: 0x8529870
	internal IList<ContentCatalogDataEntry> GetData() { }

	// RVA: 0x85295B4 Offset: 0x85255B4 VA: 0x85295B4
	internal static string ExpandInternalId(string[] internalIdPrefixes, string v) { }

	// RVA: 0x852AEE4 Offset: 0x8526EE4 VA: 0x852AEE4
	private static void .cctor() { }
}

// Namespace: UnityEngine.AddressableAssets.ResourceLocators
public interface IResourceLocator // TypeDefIndex: 26232
{
	// Properties
	public abstract string LocatorId { get; }
	public abstract IEnumerable<object> Keys { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_LocatorId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IEnumerable<object> get_Keys();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool Locate(object key, Type type, out IList<IResourceLocation> locations);
}

// Namespace: UnityEngine.AddressableAssets.ResourceLocators
public class LegacyResourcesLocator : IResourceLocator // TypeDefIndex: 26233
{
	// Properties
	public IEnumerable<object> Keys { get; }
	public string LocatorId { get; }

	// Methods

	// RVA: 0x852B1C0 Offset: 0x85271C0 VA: 0x852B1C0 Slot: 6
	public bool Locate(object key, Type type, out IList<IResourceLocation> locations) { }

	// RVA: 0x852B450 Offset: 0x8527450 VA: 0x852B450 Slot: 5
	public IEnumerable<object> get_Keys() { }

	// RVA: 0x852B458 Offset: 0x8527458 VA: 0x852B458 Slot: 4
	public string get_LocatorId() { }

	// RVA: 0x852B498 Offset: 0x8527498 VA: 0x852B498
	public void .ctor() { }
}

// Namespace: UnityEngine.AddressableAssets.ResourceLocators
[Serializable]
public class ResourceLocationData // TypeDefIndex: 26234
{
	// Fields
	[FormerlySerializedAs("m_keys")]
	[SerializeField]
	private string[] m_Keys; // 0x10
	[SerializeField]
	[FormerlySerializedAs("m_internalId")]
	private string m_InternalId; // 0x18
	[SerializeField]
	[FormerlySerializedAs("m_provider")]
	private string m_Provider; // 0x20
	[SerializeField]
	[FormerlySerializedAs("m_dependencies")]
	private string[] m_Dependencies; // 0x28
	[SerializeField]
	private SerializedType m_ResourceType; // 0x30
	[SerializeField]
	private byte[] SerializedData; // 0x50
	private object _Data; // 0x58

	// Properties
	public string[] Keys { get; }
	public string InternalId { get; }
	public string Provider { get; }
	public string[] Dependencies { get; }
	public Type ResourceType { get; }
	public object Data { get; set; }

	// Methods

	// RVA: 0x852B4A0 Offset: 0x85274A0 VA: 0x852B4A0
	public string[] get_Keys() { }

	// RVA: 0x852B4A8 Offset: 0x85274A8 VA: 0x852B4A8
	public string get_InternalId() { }

	// RVA: 0x852B4B0 Offset: 0x85274B0 VA: 0x852B4B0
	public string get_Provider() { }

	// RVA: 0x852B4B8 Offset: 0x85274B8 VA: 0x852B4B8
	public string[] get_Dependencies() { }

	// RVA: 0x852B4C0 Offset: 0x85274C0 VA: 0x852B4C0
	public Type get_ResourceType() { }

	// RVA: 0x852B4CC Offset: 0x85274CC VA: 0x852B4CC
	public object get_Data() { }

	// RVA: 0x852B520 Offset: 0x8527520 VA: 0x852B520
	public void set_Data(object value) { }

	// RVA: 0x852B5D4 Offset: 0x85275D4 VA: 0x852B5D4
	public void .ctor(string[] keys, string id, Type provider, Type t, string[] dependencies) { }
}

// Namespace: UnityEngine.AddressableAssets.ResourceLocators
public class ResourceLocationMap : IResourceLocator // TypeDefIndex: 26235
{
	// Fields
	[CompilerGenerated]
	private string <LocatorId>k__BackingField; // 0x10
	private Dictionary<object, IList<IResourceLocation>> locations; // 0x18

	// Properties
	public string LocatorId { get; set; }
	public Dictionary<object, IList<IResourceLocation>> Locations { get; }
	public IEnumerable<object> Keys { get; }

	// Methods

	// RVA: 0x85294FC Offset: 0x85254FC VA: 0x85294FC
	public void .ctor(string id, int capacity = 0) { }

	[CompilerGenerated]
	// RVA: 0x852B750 Offset: 0x8527750 VA: 0x852B750 Slot: 4
	public string get_LocatorId() { }

	[CompilerGenerated]
	// RVA: 0x852B758 Offset: 0x8527758 VA: 0x852B758
	private void set_LocatorId(string value) { }

	// RVA: 0x852B760 Offset: 0x8527760 VA: 0x852B760
	public void .ctor(string id, IList<ResourceLocationData> locations) { }

	// RVA: 0x852C290 Offset: 0x8528290 VA: 0x852C290
	public Dictionary<object, IList<IResourceLocation>> get_Locations() { }

	// RVA: 0x852A5F4 Offset: 0x85265F4 VA: 0x852A5F4 Slot: 5
	public IEnumerable<object> get_Keys() { }

	// RVA: 0x852A644 Offset: 0x8526644 VA: 0x852A644 Slot: 6
	public bool Locate(object key, Type type, out IList<IResourceLocation> locations) { }

	// RVA: 0x852C130 Offset: 0x8528130 VA: 0x852C130
	public void Add(object key, IResourceLocation location) { }

	// RVA: 0x8529808 Offset: 0x8525808 VA: 0x8529808
	public void Add(object key, IList<IResourceLocation> locations) { }
}

// Namespace: UnityEngine.AddressableAssets.Initialization
public static class AddressablesRuntimeProperties // TypeDefIndex: 26236
{
	// Fields
	private static Stack<string> s_TokenStack; // 0x0
	private static Stack<int> s_TokenStartStack; // 0x8
	private static bool s_StaticStacksAreInUse; // 0x10
	private static Dictionary<string, string> s_CachedValues; // 0x18

	// Methods

	// RVA: 0x852C298 Offset: 0x8528298 VA: 0x852C298
	private static Assembly[] GetAssemblies() { }

	// RVA: 0x852C2B8 Offset: 0x85282B8 VA: 0x852C2B8
	internal static int GetCachedValueCount() { }

	// RVA: 0x852C330 Offset: 0x8528330 VA: 0x852C330
	public static void SetPropertyValue(string name, string val) { }

	// RVA: 0x852C3C0 Offset: 0x85283C0 VA: 0x852C3C0
	public static void ClearCachedPropertyValues() { }

	// RVA: 0x852C438 Offset: 0x8528438 VA: 0x852C438
	public static string EvaluateProperty(string name) { }

	// RVA: 0x85168A8 Offset: 0x85128A8 VA: 0x85168A8
	public static string EvaluateString(string input) { }

	// RVA: 0x852C870 Offset: 0x8528870 VA: 0x852C870
	public static string EvaluateString(string inputString, char startDelimiter, char endDelimiter, Func<string, string> varFunc) { }

	// RVA: 0x852CE04 Offset: 0x8528E04 VA: 0x852CE04
	private static void .cctor() { }
}

// Namespace: 
private class CacheInitialization.CacheInitOp : AsyncOperationBase<bool>, IUpdateReceiver // TypeDefIndex: 26237
{
	// Fields
	private Func<bool> m_Callback; // 0x98
	private bool m_UpdateRequired; // 0xA0

	// Methods

	// RVA: 0x852D310 Offset: 0x8529310 VA: 0x852D310
	public void Init(Func<bool> callback) { }

	// RVA: 0x852D318 Offset: 0x8529318 VA: 0x852D318 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x852D3AC Offset: 0x85293AC VA: 0x852D3AC Slot: 36
	public void Update(float unscaledDeltaTime) { }

	// RVA: 0x852D468 Offset: 0x8529468 VA: 0x852D468 Slot: 28
	protected override void Execute() { }

	// RVA: 0x852D240 Offset: 0x8529240 VA: 0x852D240
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CacheInitialization.<>c__DisplayClass1_0 // TypeDefIndex: 26238
{
	// Fields
	public CacheInitialization <>4__this; // 0x10
	public string id; // 0x18
	public string data; // 0x20

	// Methods

	// RVA: 0x852D238 Offset: 0x8529238 VA: 0x852D238
	public void .ctor() { }

	// RVA: 0x852D500 Offset: 0x8529500 VA: 0x852D500
	internal bool <InitializeAsync>b__0() { }
}

// Namespace: UnityEngine.AddressableAssets.Initialization
[Serializable]
public class CacheInitialization : IInitializableObject // TypeDefIndex: 26239
{
	// Properties
	public static string RootPath { get; }

	// Methods

	// RVA: 0x852CF60 Offset: 0x8528F60 VA: 0x852CF60 Slot: 4
	public bool Initialize(string id, string dataStr) { }

	// RVA: 0x852D0A8 Offset: 0x85290A8 VA: 0x852D0A8 Slot: 6
	public virtual AsyncOperationHandle<bool> InitializeAsync(ResourceManager rm, string id, string data) { }

	// RVA: 0x852D290 Offset: 0x8529290 VA: 0x852D290
	public static string get_RootPath() { }

	// RVA: 0x852D308 Offset: 0x8529308 VA: 0x852D308
	public void .ctor() { }
}

// Namespace: UnityEngine.AddressableAssets.Initialization
[Serializable]
public class CacheInitializationData // TypeDefIndex: 26240
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("m_compressionEnabled")]
	private bool m_CompressionEnabled; // 0x10
	[SerializeField]
	[FormerlySerializedAs("m_cacheDirectoryOverride")]
	private string m_CacheDirectoryOverride; // 0x18
	[SerializeField]
	[FormerlySerializedAs("m_expirationDelay")]
	private int m_ExpirationDelay; // 0x20
	[FormerlySerializedAs("m_limitCacheSize")]
	[SerializeField]
	private bool m_LimitCacheSize; // 0x24
	[FormerlySerializedAs("m_maximumCacheSize")]
	[SerializeField]
	private long m_MaximumCacheSize; // 0x28

	// Properties
	public bool CompressionEnabled { get; set; }
	public string CacheDirectoryOverride { get; set; }
	[Obsolete("Functionality remains unchanged.  However, due to issues with Caching this property is being marked obsolete.  See Caching API documentation for more details.")]
	public int ExpirationDelay { get; set; }
	public bool LimitCacheSize { get; set; }
	public long MaximumCacheSize { get; set; }

	// Methods

	// RVA: 0x852D524 Offset: 0x8529524 VA: 0x852D524
	public bool get_CompressionEnabled() { }

	// RVA: 0x852D52C Offset: 0x852952C VA: 0x852D52C
	public void set_CompressionEnabled(bool value) { }

	// RVA: 0x852D538 Offset: 0x8529538 VA: 0x852D538
	public string get_CacheDirectoryOverride() { }

	// RVA: 0x852D540 Offset: 0x8529540 VA: 0x852D540
	public void set_CacheDirectoryOverride(string value) { }

	// RVA: 0x852D548 Offset: 0x8529548 VA: 0x852D548
	public int get_ExpirationDelay() { }

	// RVA: 0x852D550 Offset: 0x8529550 VA: 0x852D550
	public void set_ExpirationDelay(int value) { }

	// RVA: 0x852D558 Offset: 0x8529558 VA: 0x852D558
	public bool get_LimitCacheSize() { }

	// RVA: 0x852D560 Offset: 0x8529560 VA: 0x852D560
	public void set_LimitCacheSize(bool value) { }

	// RVA: 0x852D56C Offset: 0x852956C VA: 0x852D56C
	public long get_MaximumCacheSize() { }

	// RVA: 0x852D574 Offset: 0x8529574 VA: 0x852D574
	public void set_MaximumCacheSize(long value) { }

	// RVA: 0x852D57C Offset: 0x852957C VA: 0x852D57C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class InitializationOperation.<>c // TypeDefIndex: 26241
{
	// Fields
	public static readonly InitializationOperation.<>c <>9; // 0x0
	public static Func<IResourceProvider, bool> <>9__13_0; // 0x8

	// Methods

	// RVA: 0x852F6B0 Offset: 0x852B6B0 VA: 0x852F6B0
	private static void .cctor() { }

	// RVA: 0x852F718 Offset: 0x852B718 VA: 0x852F718
	public void .ctor() { }

	// RVA: 0x852F720 Offset: 0x852B720 VA: 0x852F720
	internal bool <Execute>b__13_0(IResourceProvider rp) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InitializationOperation.<>c__DisplayClass16_0 // TypeDefIndex: 26242
{
	// Fields
	public AddressablesImpl addressables; // 0x10
	public string providerSuffix; // 0x18
	public IResourceLocation remoteHashLocation; // 0x20

	// Methods

	// RVA: 0x852F7BC Offset: 0x852B7BC VA: 0x852F7BC
	public void .ctor() { }

	// RVA: 0x852F7C4 Offset: 0x852B7C4 VA: 0x852F7C4
	internal AsyncOperationHandle<IResourceLocator> <LoadContentCatalog>b__0(AsyncOperationHandle<ContentCatalogData> res) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InitializationOperation.<>c__DisplayClass18_0 // TypeDefIndex: 26243
{
	// Fields
	public InitializationOperation <>4__this; // 0x10
	public IList<IResourceLocation> catalogs; // 0x18
	public ResourceLocationMap locMap; // 0x20
	public int index; // 0x28
	public IResourceLocation remoteHashLocation; // 0x30

	// Methods

	// RVA: 0x852F818 Offset: 0x852B818 VA: 0x852F818
	public void .ctor() { }

	// RVA: 0x852F820 Offset: 0x852B820 VA: 0x852F820
	internal void <LoadContentCatalogInternal>b__0(AsyncOperationHandle<IResourceLocator> op) { }
}

// Namespace: UnityEngine.AddressableAssets.Initialization
internal class InitializationOperation : AsyncOperationBase<IResourceLocator> // TypeDefIndex: 26244
{
	// Fields
	private AsyncOperationHandle<ResourceManagerRuntimeData> m_rtdOp; // 0x98
	private AsyncOperationHandle<IResourceLocator> m_loadCatalogOp; // 0xB0
	private string m_ProviderSuffix; // 0xC8
	private AddressablesImpl m_Addressables; // 0xD0
	private ResourceManagerDiagnostics m_Diagnostics; // 0xD8
	private InitalizationObjectsOperation m_InitGroupOps; // 0xE0

	// Properties
	protected override float Progress { get; }
	protected override string DebugName { get; }

	// Methods

	// RVA: 0x852D5F0 Offset: 0x85295F0 VA: 0x852D5F0
	public void .ctor(AddressablesImpl aa) { }

	// RVA: 0x852D698 Offset: 0x8529698 VA: 0x852D698 Slot: 30
	protected override float get_Progress() { }

	// RVA: 0x852D718 Offset: 0x8529718 VA: 0x852D718 Slot: 31
	protected override string get_DebugName() { }

	// RVA: 0x8517AB0 Offset: 0x8513AB0 VA: 0x8517AB0
	internal static AsyncOperationHandle<IResourceLocator> CreateInitializationOperation(AddressablesImpl aa, string playerSettingsLocation, string providerSuffix) { }

	// RVA: 0x852D758 Offset: 0x8529758 VA: 0x852D758 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x852D924 Offset: 0x8529924 VA: 0x852D924 Slot: 28
	protected override void Execute() { }

	// RVA: 0x852E8B0 Offset: 0x852A8B0 VA: 0x852E8B0
	private static void LoadProvider(AddressablesImpl addressables, ObjectInitializationData providerData, string providerSuffix) { }

	// RVA: 0x852ED38 Offset: 0x852AD38 VA: 0x852ED38
	private static AsyncOperationHandle<IResourceLocator> OnCatalogDataLoaded(AddressablesImpl addressables, AsyncOperationHandle<ContentCatalogData> op, string providerSuffix, IResourceLocation remoteHashLocation) { }

	// RVA: 0x8518064 Offset: 0x8514064 VA: 0x8518064
	public static AsyncOperationHandle<IResourceLocator> LoadContentCatalog(AddressablesImpl addressables, IResourceLocation loc, string providerSuffix, IResourceLocation remoteHashLocation) { }

	// RVA: 0x852F2E8 Offset: 0x852B2E8 VA: 0x852F2E8
	public AsyncOperationHandle<IResourceLocator> LoadContentCatalog(IResourceLocation loc, string providerSuffix, IResourceLocation remoteHashLocation) { }

	// RVA: 0x852E674 Offset: 0x852A674 VA: 0x852E674
	internal AsyncOperationHandle<IResourceLocator> LoadContentCatalogInternal(IList<IResourceLocation> catalogs, int index, ResourceLocationMap locMap, IResourceLocation remoteHashLocation) { }

	// RVA: 0x852F31C Offset: 0x852B31C VA: 0x852F31C
	private void LoadOpComplete(AsyncOperationHandle<IResourceLocator> op, IList<IResourceLocation> catalogs, ResourceLocationMap locMap, int index, IResourceLocation remoteHashLocation) { }
}

// Namespace: UnityEngine.AddressableAssets.Initialization
[Serializable]
public class ResourceManagerRuntimeData // TypeDefIndex: 26245
{
	// Fields
	public const string kCatalogAddress = "AddressablesMainContentCatalog";
	[SerializeField]
	private string m_buildTarget; // 0x10
	[FormerlySerializedAs("m_settingsHash")]
	[SerializeField]
	private string m_SettingsHash; // 0x18
	[FormerlySerializedAs("m_catalogLocations")]
	[SerializeField]
	private List<ResourceLocationData> m_CatalogLocations; // 0x20
	[SerializeField]
	[FormerlySerializedAs("m_profileEvents")]
	private bool m_ProfileEvents; // 0x28
	[FormerlySerializedAs("m_logResourceManagerExceptions")]
	[SerializeField]
	private bool m_LogResourceManagerExceptions; // 0x29
	[FormerlySerializedAs("m_extraInitializationData")]
	[SerializeField]
	private List<ObjectInitializationData> m_ExtraInitializationData; // 0x30
	[SerializeField]
	private bool m_DisableCatalogUpdateOnStart; // 0x38
	[SerializeField]
	private bool m_IsLocalCatalogInBundle; // 0x39
	[SerializeField]
	private SerializedType m_CertificateHandlerType; // 0x40
	[SerializeField]
	private string m_AddressablesVersion; // 0x60
	[SerializeField]
	private int m_maxConcurrentWebRequests; // 0x68
	[SerializeField]
	private int m_CatalogRequestsTimeout; // 0x6C

	// Properties
	public string BuildTarget { get; set; }
	public string SettingsHash { get; set; }
	public List<ResourceLocationData> CatalogLocations { get; }
	public bool ProfileEvents { get; set; }
	public bool LogResourceManagerExceptions { get; set; }
	public List<ObjectInitializationData> InitializationObjects { get; }
	public bool DisableCatalogUpdateOnStartup { get; set; }
	public bool IsLocalCatalogInBundle { get; set; }
	public Type CertificateHandlerType { get; set; }
	public string AddressablesVersion { get; set; }
	public int MaxConcurrentWebRequests { get; set; }
	public int CatalogRequestsTimeout { get; set; }

	// Methods

	// RVA: 0x852F87C Offset: 0x852B87C VA: 0x852F87C
	public string get_BuildTarget() { }

	// RVA: 0x852F884 Offset: 0x852B884 VA: 0x852F884
	public void set_BuildTarget(string value) { }

	// RVA: 0x852F88C Offset: 0x852B88C VA: 0x852F88C
	public string get_SettingsHash() { }

	// RVA: 0x852F894 Offset: 0x852B894 VA: 0x852F894
	public void set_SettingsHash(string value) { }

	// RVA: 0x852F89C Offset: 0x852B89C VA: 0x852F89C
	public List<ResourceLocationData> get_CatalogLocations() { }

	// RVA: 0x852F8A4 Offset: 0x852B8A4 VA: 0x852F8A4
	public bool get_ProfileEvents() { }

	// RVA: 0x852F8AC Offset: 0x852B8AC VA: 0x852F8AC
	public void set_ProfileEvents(bool value) { }

	// RVA: 0x852F8B8 Offset: 0x852B8B8 VA: 0x852F8B8
	public bool get_LogResourceManagerExceptions() { }

	// RVA: 0x852F8C0 Offset: 0x852B8C0 VA: 0x852F8C0
	public void set_LogResourceManagerExceptions(bool value) { }

	// RVA: 0x852F8CC Offset: 0x852B8CC VA: 0x852F8CC
	public List<ObjectInitializationData> get_InitializationObjects() { }

	// RVA: 0x852F8D4 Offset: 0x852B8D4 VA: 0x852F8D4
	public bool get_DisableCatalogUpdateOnStartup() { }

	// RVA: 0x852F8DC Offset: 0x852B8DC VA: 0x852F8DC
	public void set_DisableCatalogUpdateOnStartup(bool value) { }

	// RVA: 0x852F8E8 Offset: 0x852B8E8 VA: 0x852F8E8
	public bool get_IsLocalCatalogInBundle() { }

	// RVA: 0x852F8F0 Offset: 0x852B8F0 VA: 0x852F8F0
	public void set_IsLocalCatalogInBundle(bool value) { }

	// RVA: 0x852F8FC Offset: 0x852B8FC VA: 0x852F8FC
	public Type get_CertificateHandlerType() { }

	// RVA: 0x852F908 Offset: 0x852B908 VA: 0x852F908
	public void set_CertificateHandlerType(Type value) { }

	// RVA: 0x852F914 Offset: 0x852B914 VA: 0x852F914
	public string get_AddressablesVersion() { }

	// RVA: 0x852F91C Offset: 0x852B91C VA: 0x852F91C
	public void set_AddressablesVersion(string value) { }

	// RVA: 0x852F924 Offset: 0x852B924 VA: 0x852F924
	public int get_MaxConcurrentWebRequests() { }

	// RVA: 0x852F92C Offset: 0x852B92C VA: 0x852F92C
	public void set_MaxConcurrentWebRequests(int value) { }

	// RVA: 0x852F948 Offset: 0x852B948 VA: 0x852F948
	public int get_CatalogRequestsTimeout() { }

	// RVA: 0x852F950 Offset: 0x852B950 VA: 0x852F950
	public void set_CatalogRequestsTimeout(int value) { }

	// RVA: 0x852F96C Offset: 0x852B96C VA: 0x852F96C
	public void .ctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2589 // TypeDefIndex: 26246
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2943 // TypeDefIndex: 26247
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 26248
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2943 665ECC1C05160C0F32D3061E27307CCD620C172A96858BE3F9B40764886531FC /*Metadata offset 0xF43F88*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2589 915F098662DB855AFE64CBFACF6839FC652CED0140B9FFA733C3BDEBD84E36E7 /*Metadata offset 0xF44B08*/; // 0xB7F
}

