// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28869
{}

// Namespace: Unity.Services.Core.Configuration
internal class CloudProjectId : ICloudProjectId, IServiceComponent // TypeDefIndex: 28870
{
	// Methods

	// RVA: 0x862F7EC Offset: 0x862B7EC VA: 0x862F7EC Slot: 4
	public string GetCloudProjectId() { }

	// RVA: 0x862F83C Offset: 0x862B83C VA: 0x862F83C
	public void .ctor() { }
}

// Namespace: Unity.Services.Core.Configuration
[Extension]
internal static class ConfigurationCollectionHelper // TypeDefIndex: 28871
{
	// Methods

	[Extension]
	// RVA: 0x862F844 Offset: 0x862B844 VA: 0x862F844
	public static void FillWith(IDictionary<string, ConfigurationEntry> self, SerializableProjectConfiguration config) { }

	[Extension]
	// RVA: 0x862FA68 Offset: 0x862BA68 VA: 0x862FA68
	public static void FillWith(IDictionary<string, ConfigurationEntry> self, InitializationOptions options) { }

	[Extension]
	// RVA: 0x862F8D4 Offset: 0x862B8D4 VA: 0x862F8D4
	private static void SetOrCreateEntry(IDictionary<string, ConfigurationEntry> self, string key, ConfigurationEntry entry) { }
}

// Namespace: Unity.Services.Core.Configuration
[Serializable]
internal class ConfigurationEntry // TypeDefIndex: 28872
{
	// Fields
	[JsonRequired]
	[SerializeField]
	private string m_Value; // 0x10
	[JsonRequired]
	[SerializeField]
	private bool m_IsReadOnly; // 0x18

	// Properties
	[JsonIgnore]
	public string Value { get; }
	[JsonIgnore]
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x862FE94 Offset: 0x862BE94 VA: 0x862FE94
	public string get_Value() { }

	// RVA: 0x862FE9C Offset: 0x862BE9C VA: 0x862FE9C
	public bool get_IsReadOnly() { }

	// RVA: 0x862FEA4 Offset: 0x862BEA4 VA: 0x862FEA4
	public void .ctor() { }

	// RVA: 0x862FEAC Offset: 0x862BEAC VA: 0x862FEAC
	public void .ctor(string value, bool isReadOnly = False) { }

	// RVA: 0x862FE70 Offset: 0x862BE70 VA: 0x862FE70
	public bool TrySetValue(string value) { }

	// RVA: 0x862FE58 Offset: 0x862BE58 VA: 0x862FE58
	public static string op_Implicit(ConfigurationEntry entry) { }

	// RVA: 0x862FDEC Offset: 0x862BDEC VA: 0x862FDEC
	public static ConfigurationEntry op_Implicit(string value) { }
}

// Namespace: Unity.Services.Core.Configuration
internal static class ConfigurationUtils // TypeDefIndex: 28873
{
	// Fields
	[CompilerGenerated]
	private static IConfigurationLoader <ConfigurationLoader>k__BackingField; // 0x0

	// Properties
	public static IConfigurationLoader ConfigurationLoader { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x862FEE8 Offset: 0x862BEE8 VA: 0x862FEE8
	public static IConfigurationLoader get_ConfigurationLoader() { }

	// RVA: 0x862FF40 Offset: 0x862BF40 VA: 0x862FF40
	private static void .cctor() { }
}

// Namespace: Unity.Services.Core.Configuration
internal class ExternalUserId : IExternalUserId, IServiceComponent // TypeDefIndex: 28874
{
	// Methods

	// RVA: 0x8630030 Offset: 0x862C030 VA: 0x8630030
	public void .ctor() { }
}

// Namespace: Unity.Services.Core.Configuration
internal interface IConfigurationLoader // TypeDefIndex: 28875
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Task<SerializableProjectConfiguration> GetConfigAsync();
}

// Namespace: Unity.Services.Core.Configuration
internal class ProjectConfiguration : IProjectConfiguration, IServiceComponent // TypeDefIndex: 28876
{
	// Fields
	private readonly IReadOnlyDictionary<string, ConfigurationEntry> m_ConfigValues; // 0x10
	[CompilerGenerated]
	private readonly IJsonSerializer <Serializer>k__BackingField; // 0x18

	// Methods

	// RVA: 0x8630038 Offset: 0x862C038 VA: 0x8630038
	public void .ctor(IReadOnlyDictionary<string, ConfigurationEntry> configValues, IJsonSerializer serializer) { }

	// RVA: 0x863007C Offset: 0x862C07C VA: 0x863007C Slot: 4
	public string GetString(string key, string defaultValue) { }
}

// Namespace: Unity.Services.Core.Configuration
[Serializable]
internal struct SerializableProjectConfiguration // TypeDefIndex: 28877
{
	// Fields
	[SerializeField]
	[JsonRequired]
	internal string[] Keys; // 0x0
	[JsonRequired]
	[SerializeField]
	internal ConfigurationEntry[] Values; // 0x8

	// Properties
	public static SerializableProjectConfiguration Empty { get; }

	// Methods

	// RVA: 0x8630154 Offset: 0x862C154 VA: 0x8630154
	public static SerializableProjectConfiguration get_Empty() { }
}

// Namespace: 
[CompilerGenerated]
private struct StreamingAssetsConfigurationLoader.<GetConfigAsync>d__2 : IAsyncStateMachine // TypeDefIndex: 28878
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<SerializableProjectConfiguration> <>t__builder; // 0x8
	public StreamingAssetsConfigurationLoader <>4__this; // 0x20
	private TaskAwaiter<string> <>u__1; // 0x28

	// Methods

	// RVA: 0x863037C Offset: 0x862C37C VA: 0x863037C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x863071C Offset: 0x862C71C VA: 0x863071C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Unity.Services.Core.Configuration
internal class StreamingAssetsConfigurationLoader : IConfigurationLoader // TypeDefIndex: 28879
{
	// Fields
	private readonly IJsonSerializer m_Serializer; // 0x10

	// Methods

	// RVA: 0x8630000 Offset: 0x862C000 VA: 0x8630000
	public void .ctor(IJsonSerializer serializer) { }

	[AsyncStateMachine(typeof(StreamingAssetsConfigurationLoader.<GetConfigAsync>d__2))]
	// RVA: 0x8630270 Offset: 0x862C270 VA: 0x8630270 Slot: 4
	public Task<SerializableProjectConfiguration> GetConfigAsync() { }
}

// Namespace: Unity.Services.Core.Configuration
internal static class StreamingAssetsUtils // TypeDefIndex: 28880
{
	// Methods

	// RVA: 0x8630684 Offset: 0x862C684 VA: 0x8630684
	public static Task<string> GetFileTextFromStreamingAssetsAsync(string path) { }
}

