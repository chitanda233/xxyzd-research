// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28902
{}

// Namespace: Unity.Services.Core.Device
internal class InstallationId : IInstallationId, IServiceComponent // TypeDefIndex: 28903
{
	// Fields
	internal string Identifier; // 0x10
	internal IUserIdentifierProvider UnityAdsIdentifierProvider; // 0x18
	internal IUserIdentifierProvider UnityAnalyticsIdentifierProvider; // 0x20

	// Methods

	// RVA: 0x8630FC0 Offset: 0x862CFC0 VA: 0x8630FC0
	public void .ctor() { }

	// RVA: 0x863107C Offset: 0x862D07C VA: 0x863107C
	public void CreateIdentifier() { }

	// RVA: 0x8631328 Offset: 0x862D328 VA: 0x8631328
	private static string ReadIdentifierFromFile() { }

	// RVA: 0x8631398 Offset: 0x862D398 VA: 0x8631398
	private static void WriteIdentifierToFile(string identifier) { }

	// RVA: 0x863136C Offset: 0x862D36C VA: 0x863136C
	private static string GenerateGuid() { }
}

// Namespace: Unity.Services.Core.Device
internal static class AndroidUtils // TypeDefIndex: 28904
{
	// Methods

	// RVA: 0x86313EC Offset: 0x862D3EC VA: 0x86313EC
	public static AndroidJavaObject GetUnityActivity() { }

	// RVA: 0x86315CC Offset: 0x862D5CC VA: 0x86315CC
	public static AndroidJavaObject GetSharedPreferences(AndroidJavaObject context, string name, int mode = 0) { }

	// RVA: 0x8631718 Offset: 0x862D718 VA: 0x8631718
	public static AndroidJavaObject GetSharedPreferences(string name, int mode = 0) { }

	// RVA: 0x8631894 Offset: 0x862D894 VA: 0x8631894
	public static string SharedPreferencesGetString(string name, string key, string defValue = "") { }

	// RVA: 0x8631A1C Offset: 0x862DA1C VA: 0x8631A1C
	public static string SharedPreferencesGetString(AndroidJavaObject preferences, string key, string defValue = "") { }

	// RVA: 0x8631C6C Offset: 0x862DC6C VA: 0x8631C6C
	public static void SharedPreferencesPutString(string name, string key, string value) { }

	// RVA: 0x8631DE4 Offset: 0x862DDE4 VA: 0x8631DE4
	public static void SharedPreferencesPutString(AndroidJavaObject preferences, string key, string value) { }
}

// Namespace: Unity.Services.Core.Device
internal interface IUserIdentifierProvider // TypeDefIndex: 28905
{
	// Properties
	public abstract string UserId { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_UserId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_UserId(string value);
}

// Namespace: Unity.Services.Core.Device
internal class UnityAdsIdentifier : IUserIdentifierProvider // TypeDefIndex: 28906
{
	// Properties
	public string UserId { get; set; }
	private static string IdentifierForInstallAndroid { get; set; }

	// Methods

	// RVA: 0x8632034 Offset: 0x862E034 VA: 0x8632034 Slot: 4
	public string get_UserId() { }

	// RVA: 0x86320B0 Offset: 0x862E0B0 VA: 0x86320B0 Slot: 5
	public void set_UserId(string value) { }

	// RVA: 0x8632038 Offset: 0x862E038 VA: 0x8632038
	private static string get_IdentifierForInstallAndroid() { }

	// RVA: 0x86320B8 Offset: 0x862E0B8 VA: 0x86320B8
	private static void set_IdentifierForInstallAndroid(string value) { }

	// RVA: 0x863106C Offset: 0x862D06C VA: 0x863106C
	public void .ctor() { }
}

// Namespace: Unity.Services.Core.Device
internal class UnityAnalyticsIdentifier : IUserIdentifierProvider // TypeDefIndex: 28907
{
	// Properties
	public string UserId { get; set; }

	// Methods

	// RVA: 0x8632120 Offset: 0x862E120 VA: 0x8632120 Slot: 4
	public string get_UserId() { }

	// RVA: 0x8632164 Offset: 0x862E164 VA: 0x8632164 Slot: 5
	public void set_UserId(string value) { }

	// RVA: 0x8631074 Offset: 0x862D074 VA: 0x8631074
	public void .ctor() { }
}

