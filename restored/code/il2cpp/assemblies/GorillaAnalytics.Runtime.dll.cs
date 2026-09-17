// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28914
{}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 28915
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
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 28916
{
	// Methods

	// RVA: 0x63FF518 Offset: 0x63FB518 VA: 0x63FF518
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x63FF60C Offset: 0x63FB60C VA: 0x63FF60C
	public void .ctor() { }
}

// Namespace: GorillaAnalytics.Runtime
public class AdjustConfig : ScriptableObject // TypeDefIndex: 28917
{
	// Fields
	public const string Path = "Assets/Resources/GorillaSDK/AdjustConfig";
	public const string LoadPath = "GorillaSDK/AdjustConfig";
	[Header("iOS 平台的 app token")]
	public string iOSAppToken; // 0x18
	[Header("Android 平台的 app token")]
	public string androidAppToken; // 0x20
	[Header("Android 平台的 Meta / Facebook App ID")]
	public string androidMetaAppId; // 0x28
	[Header("设置 Adjust 是否是生产环境")]
	public bool isProduction; // 0x30
	[Header("是否允许深度链接触发 Adjust 再归因")]
	public bool enableDeepLinkReattribution; // 0x31
	[Header("是否关联 Thinking Data SDK 到 Adjust")]
	public bool isAssociatedWithTGA; // 0x32

	// Properties
	public string AppToken { get; }

	// Methods

	// RVA: 0x63FF614 Offset: 0x63FB614 VA: 0x63FF614
	public string get_AppToken() { }

	// RVA: 0x63FF61C Offset: 0x63FB61C VA: 0x63FF61C
	public void .ctor() { }
}

// Namespace: GorillaAnalytics.Runtime
[Preserve]
internal static class AnalyticsServiceInjector // TypeDefIndex: 28918
{
	// Methods

	[Preserve]
	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x63FF62C Offset: 0x63FB62C VA: 0x63FF62C
	internal static void Initialize() { }
}

// Namespace: GorillaAnalytics.Runtime
public class AppsFlyerConfig : ScriptableObject // TypeDefIndex: 28919
{
	// Fields
	public const string Path = "Assets/Resources/GorillaSDK/AppsFlyerConfig";
	public const string LoadPath = "GorillaSDK/AppsFlyerConfig";
	[Header("Android 平台的 app id")]
	public string androidAppId; // 0x18
	[Header("iOS 平台的 app id")]
	public string iOSAppId; // 0x20
	[Header("iOS 平台下的 dev Key")]
	public string devKey; // 0x28
	[Header("是否开启调试模式")]
	public bool isDebug; // 0x30

	// Properties
	public string AppId { get; }

	// Methods

	// RVA: 0x63FF630 Offset: 0x63FB630 VA: 0x63FF630
	public string get_AppId() { }

	// RVA: 0x63FF638 Offset: 0x63FB638 VA: 0x63FF638
	public void .ctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=141 // TypeDefIndex: 28920
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=258 // TypeDefIndex: 28921
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 28922
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=141 0EA5861ECE7EB486E3C859C15902B4685EAFA286C83CF64F3B907FD2B53B6D75 /*Metadata offset 0xF559F8*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=258 768AFFBB7183054CB272BE1745368A054C11089257F856A23E1ADB77B0418783 /*Metadata offset 0xF55A88*/; // 0x8D
}

