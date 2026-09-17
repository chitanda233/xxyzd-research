// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28303
{}

// Namespace: GorillaNative.Runtime
public static class AndroidPluginRegistrarHub // TypeDefIndex: 28304
{
	// Fields
	private static readonly List<IAndroidPluginRegistrar> Registrars; // 0x0

	// Methods

	// RVA: 0x64852C8 Offset: 0x64812C8 VA: 0x64852C8
	public static void Register(IAndroidPluginRegistrar registrar) { }

	// RVA: 0x64853AC Offset: 0x64813AC VA: 0x64853AC
	public static IReadOnlyList<IAndroidPluginRegistrar> GetRegistrars() { }

	// RVA: 0x6485404 Offset: 0x6481404 VA: 0x6485404
	private static void .cctor() { }
}

// Namespace: GorillaNative.Runtime
public interface IAndroidPluginRegistrar // TypeDefIndex: 28305
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Register(AndroidPluginRegistry registry);
}

// Namespace: GorillaNative.Runtime
public sealed class AndroidPluginRegistry // TypeDefIndex: 28306
{
	// Fields
	private readonly HashSet<string> _plugins; // 0x10
	private readonly Dictionary<string, string> _aliasMap; // 0x18

	// Methods

	// RVA: 0x648549C Offset: 0x648149C VA: 0x648549C
	internal void .ctor(HashSet<string> plugins, Dictionary<string, string> aliasMap) { }

	// RVA: 0x64854E0 Offset: 0x64814E0 VA: 0x64854E0
	public void Register(string pluginClassName, string alias) { }
}

// Namespace: 
private sealed class DefaultPrivacyPolicyService.PrivacyPolicyLocalizedText // TypeDefIndex: 28307
{
	// Fields
	[CompilerGenerated]
	private string <Title>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <ContentTemplate>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <ServiceTermsText>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <PrivacyPolicyText>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <ConfirmButtonText>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <CancelButtonText>k__BackingField; // 0x38

	// Properties
	internal string Title { get; set; }
	internal string ContentTemplate { get; set; }
	internal string ServiceTermsText { get; set; }
	internal string PrivacyPolicyText { get; set; }
	internal string ConfirmButtonText { get; set; }
	internal string CancelButtonText { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6485FF4 Offset: 0x6481FF4 VA: 0x6485FF4
	internal string get_Title() { }

	[CompilerGenerated]
	// RVA: 0x6485FFC Offset: 0x6481FFC VA: 0x6485FFC
	internal void set_Title(string value) { }

	[CompilerGenerated]
	// RVA: 0x6486004 Offset: 0x6482004 VA: 0x6486004
	internal string get_ContentTemplate() { }

	[CompilerGenerated]
	// RVA: 0x648600C Offset: 0x648200C VA: 0x648600C
	internal void set_ContentTemplate(string value) { }

	[CompilerGenerated]
	// RVA: 0x6486014 Offset: 0x6482014 VA: 0x6486014
	internal string get_ServiceTermsText() { }

	[CompilerGenerated]
	// RVA: 0x648601C Offset: 0x648201C VA: 0x648601C
	internal void set_ServiceTermsText(string value) { }

	[CompilerGenerated]
	// RVA: 0x6486024 Offset: 0x6482024 VA: 0x6486024
	internal string get_PrivacyPolicyText() { }

	[CompilerGenerated]
	// RVA: 0x648602C Offset: 0x648202C VA: 0x648602C
	internal void set_PrivacyPolicyText(string value) { }

	[CompilerGenerated]
	// RVA: 0x6486034 Offset: 0x6482034 VA: 0x6486034
	internal string get_ConfirmButtonText() { }

	[CompilerGenerated]
	// RVA: 0x648603C Offset: 0x648203C VA: 0x648603C
	internal void set_ConfirmButtonText(string value) { }

	[CompilerGenerated]
	// RVA: 0x6486044 Offset: 0x6482044 VA: 0x6486044
	internal string get_CancelButtonText() { }

	[CompilerGenerated]
	// RVA: 0x648604C Offset: 0x648204C VA: 0x648604C
	internal void set_CancelButtonText(string value) { }

	// RVA: 0x6485DD0 Offset: 0x6481DD0 VA: 0x6485DD0
	public void .ctor() { }
}

// Namespace: GorillaNative.Runtime
internal sealed class DefaultPrivacyPolicyService : IPrivacyPolicyService // TypeDefIndex: 28308
{
	// Fields
	private readonly INativePrivacyPolicyPresenter _presenter; // 0x10

	// Methods

	// RVA: 0x6485600 Offset: 0x6481600 VA: 0x6485600
	public void .ctor(INativePrivacyPolicyPresenter presenter) { }

	// RVA: 0x6485630 Offset: 0x6481630 VA: 0x6485630 Slot: 4
	public void Show(PrivacyPolicyRequest request, Action onPresented, Action onConfirmed, Action onCancelled, Action<int, string> onFailure) { }

	// RVA: 0x64857F0 Offset: 0x64817F0 VA: 0x64857F0
	private static DefaultPrivacyPolicyService.PrivacyPolicyLocalizedText ResolveLocalizedText(PrivacyPolicyTextOverrides overrides) { }

	// RVA: 0x6485DD8 Offset: 0x6481DD8 VA: 0x6485DD8
	private static string ResolveOverride(string value, string key) { }

	// RVA: 0x64859E0 Offset: 0x64819E0 VA: 0x64859E0
	private static bool TryBuildContent(string template, string termsText, string privacyText, PrivacyPolicyRequest request, out PrivacyPolicyNativeArgs args, out string error) { }

	// RVA: 0x6485F34 Offset: 0x6481F34 VA: 0x6485F34
	private static PrivacyPolicyNativeLink AppendLink(StringBuilder builder, string text, string url) { }

	// RVA: 0x6485EEC Offset: 0x6481EEC VA: 0x6485EEC
	private static bool StartsWith(string value, int startIndex, string token) { }

	// RVA: 0x6485E68 Offset: 0x6481E68 VA: 0x6485E68
	private static int CountToken(string value, string token) { }
}

// Namespace: GorillaNative.Runtime
internal interface INativePrivacyPolicyPresenter // TypeDefIndex: 28309
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ShowPrivacyPolicy(PrivacyPolicyNativeArgs args, Action onPresented, Action onConfirmed, Action onCancelled, Action<int, string> onFailure);
}

// Namespace: GorillaNative.Runtime
public interface INativeSDK // TypeDefIndex: 28310
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetEnableLog(bool enable);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void WeChatLogin(object args, Action<WeChatLoginResult> onSuccess, Action<int, string> onFailure, Action onCancel);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void QQLogin(object args, Action<QQLoginResult> onSuccess, Action<int, string> onFailure, Action onCancel);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SendSms(SendSmsArgs args, Action<string> onSuccess, Action<int, string> onFailure, Action onCancel);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool IsAppInstalled(NativeApp app);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void WeChatPay(WeChatPurchaseArgs args);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void AliPay(AliPurchaseArgs args);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void ShowPayList(ShowPayListArgs args);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void OpenSystemSettings();
}

// Namespace: GorillaNative.Runtime
public interface INumberAuth // TypeDefIndex: 28311
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void NumberAuthInit(NumberAuthConfig args, Action<string> onSuccess, Action<int, string> onFailure);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void NumberAuthPrepare(NumberAuthConfig args, Action<string> onSuccess, Action<int, string> onFailure);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void NumberAuthLogin(NumberAuthConfig args, Action<string> onSuccess, Action<int, string> onFailure, Action<string> onEvent);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void NumberAuthDismiss(Action<string> onSuccess, Action<int, string> onFailure);
}

// Namespace: GorillaNative.Runtime
public interface IAlternateIcon // TypeDefIndex: 28312
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetAlternateIcon(string iconName, Action onSuccess, Action<int, string> onFailure);
}

// Namespace: GorillaNative.Runtime
public interface INativeSDKiOS : INativeSDK, INumberAuth, IAlternateIcon // TypeDefIndex: 28313
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GameCenterLogin(Action<GameCenterLoginResult> onSuccess, Action<int, string> onFailure, Action onCancel);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void AppleIDLogin(AppleIDLoginArgs args, Action<AppleIDLoginResult> onSuccess, Action<int, string> onFailure, Action onCancel);
}

// Namespace: GorillaNative.Runtime
public class NativeSDK : MonoBehaviour // TypeDefIndex: 28314
{
	// Fields
	private static NativeSDK _instance; // 0x0
	private INativeSDK _nativeSDK; // 0x20
	private IPrivacyPolicyService _defaultPrivacyPolicyService; // 0x28

	// Properties
	public static NativeSDK Instance { get; }
	public bool IsWeChatInstalled { get; }
	public bool IsQQInstalled { get; }
	public bool IsWeiboInstalled { get; }
	internal IPrivacyPolicyService DefaultPrivacyPolicyService { get; }

	// Methods

	// RVA: 0x6486054 Offset: 0x6482054 VA: 0x6486054
	public static NativeSDK get_Instance() { }

	// RVA: 0x6486164 Offset: 0x6482164 VA: 0x6486164
	private void Awake() { }

	// RVA: 0x648627C Offset: 0x648227C VA: 0x648627C
	private void CreateNativeSDKImplementation() { }

	// RVA: 0x64863F0 Offset: 0x64823F0 VA: 0x64863F0
	public void SetEnableLog(bool enable) { }

	// RVA: 0x6486498 Offset: 0x6482498 VA: 0x6486498
	public void Init(Action<bool> callback) { }

	// RVA: 0x64864B4 Offset: 0x64824B4 VA: 0x64864B4
	public void GameCenterLogin(Action<GameCenterLoginResult> onSuccess, Action<int, string> onFailure, Action onCancel) { }

	// RVA: 0x64865D8 Offset: 0x64825D8 VA: 0x64865D8
	public void AppleIDLogin(AppleIDLoginArgs args, Action<AppleIDLoginResult> onSuccess, Action<int, string> onFailure, Action onCancel) { }

	// RVA: 0x6486708 Offset: 0x6482708 VA: 0x6486708
	public void WeChatLogin(object args, Action<WeChatLoginResult> onSuccess, Action<int, string> onFailure, Action onCancel) { }

	// RVA: 0x64867DC Offset: 0x64827DC VA: 0x64867DC
	public void QQLogin(object args, Action<QQLoginResult> onSuccess, Action<int, string> onFailure, Action onCancel) { }

	// RVA: 0x64868B0 Offset: 0x64828B0 VA: 0x64868B0
	public void SendSms(SendSmsArgs args, Action<string> onSuccess, Action<int, string> onFailure, Action onCancel) { }

	// RVA: 0x6486984 Offset: 0x6482984 VA: 0x6486984
	public void NumberAuthInit(NumberAuthConfig args, Action<string> onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x6486AA8 Offset: 0x6482AA8 VA: 0x6486AA8
	public void NumberAuthPrepare(NumberAuthConfig args, Action<string> onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x6486BD0 Offset: 0x6482BD0 VA: 0x6486BD0
	public void NumberAuthLogin(NumberAuthConfig args, Action<string> onSuccess, Action<int, string> onFailure, Action<string> onEvent) { }

	// RVA: 0x6486D00 Offset: 0x6482D00 VA: 0x6486D00
	public void NumberAuthDismiss(Action<string> onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x6486E10 Offset: 0x6482E10 VA: 0x6486E10
	public void SetAlternateIcon(string iconName, Action onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x6486F34 Offset: 0x6482F34 VA: 0x6486F34
	public bool get_IsWeChatInstalled() { }

	// RVA: 0x6486FDC Offset: 0x6482FDC VA: 0x6486FDC
	public bool get_IsQQInstalled() { }

	// RVA: 0x6487084 Offset: 0x6483084 VA: 0x6487084
	public bool get_IsWeiboInstalled() { }

	// RVA: 0x648712C Offset: 0x648312C VA: 0x648712C
	public void ShowPayList(ShowPayListArgs args) { }

	// RVA: 0x64871D8 Offset: 0x64831D8 VA: 0x64871D8
	public void WeChatPay(WeChatPurchaseArgs args) { }

	// RVA: 0x6487284 Offset: 0x6483284 VA: 0x6487284
	public void AliPay(AliPurchaseArgs args) { }

	// RVA: 0x6487330 Offset: 0x6483330 VA: 0x6487330
	public void OpenSystemSettings() { }

	// RVA: 0x64873D4 Offset: 0x64833D4 VA: 0x64873D4
	internal IPrivacyPolicyService get_DefaultPrivacyPolicyService() { }

	// RVA: 0x648748C Offset: 0x648348C VA: 0x648748C
	public void .ctor() { }
}

// Namespace: 
[Serializable]
private sealed class NativeSDKAndroid.PrivacyPolicyNativeEvent // TypeDefIndex: 28315
{
	// Fields
	public string eventName; // 0x10

	// Methods

	// RVA: 0x648AAC8 Offset: 0x6486AC8 VA: 0x648AAC8
	public void .ctor() { }
}

// Namespace: 
[Serializable]
private sealed class NativeSDKAndroid.NumberAuthRawPayload // TypeDefIndex: 28316
{
	// Fields
	public string callbackType; // 0x10

	// Methods

	// RVA: 0x648AAD0 Offset: 0x6486AD0 VA: 0x648AAD0
	public void .ctor() { }
}

// Namespace: 
private class NativeSDKAndroid.WeChatShareProvider : IShareProvider // TypeDefIndex: 28317
{
	// Methods

	// RVA: 0x648832C Offset: 0x648432C VA: 0x648832C
	public void .ctor() { }
}

// Namespace: 
private class NativeSDKAndroid.QQShareProvider : IShareProvider // TypeDefIndex: 28318
{
	// Methods

	// RVA: 0x6488334 Offset: 0x6484334 VA: 0x6488334
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NativeSDKAndroid.SuccessCb.<>c__DisplayClass2_0<T> // TypeDefIndex: 28319
{
	// Fields
	public string result; // 0x0
	public NativeSDKAndroid.SuccessCb<T> <>4__this; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486CC4C Offset: 0x4868C4C VA: 0x486CC4C
	|-NativeSDKAndroid.SuccessCb.<>c__DisplayClass2_0<object>..ctor
	|
	|-RVA: 0x486D154 Offset: 0x4869154 VA: 0x486D154
	|-NativeSDKAndroid.SuccessCb.<>c__DisplayClass2_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <onSuccess>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486CC54 Offset: 0x4868C54 VA: 0x486CC54
	|-NativeSDKAndroid.SuccessCb.<>c__DisplayClass2_0<object>.<onSuccess>b__0
	|
	|-RVA: 0x486D15C Offset: 0x486915C VA: 0x486D15C
	|-NativeSDKAndroid.SuccessCb.<>c__DisplayClass2_0<__Il2CppFullySharedGenericType>.<onSuccess>b__0
	*/
}

// Namespace: 
[Preserve]
private class NativeSDKAndroid.SuccessCb<T> : AndroidJavaProxy // TypeDefIndex: 28320
{
	// Fields
	private readonly Action<T> _cb; // 0x0

	// Methods

	[Preserve]
	// RVA: -1 Offset: -1
	public void .ctor(Action<T> cb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5534218 Offset: 0x5530218 VA: 0x5534218
	|-NativeSDKAndroid.SuccessCb<object>..ctor
	|
	|-RVA: 0x55343A4 Offset: 0x55303A4 VA: 0x55343A4
	|-NativeSDKAndroid.SuccessCb<__Il2CppFullySharedGenericType>..ctor
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	public void onSuccess(string result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55342A4 Offset: 0x55302A4 VA: 0x55342A4
	|-NativeSDKAndroid.SuccessCb<object>.onSuccess
	|
	|-RVA: 0x5534430 Offset: 0x5530430 VA: 0x5534430
	|-NativeSDKAndroid.SuccessCb<__Il2CppFullySharedGenericType>.onSuccess
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class NativeSDKAndroid.RawSuccessCb.<>c__DisplayClass2_0 // TypeDefIndex: 28321
{
	// Fields
	public NativeSDKAndroid.RawSuccessCb <>4__this; // 0x10
	public string result; // 0x18

	// Methods

	// RVA: 0x648AC64 Offset: 0x6486C64 VA: 0x648AC64
	public void .ctor() { }

	// RVA: 0x648AC6C Offset: 0x6486C6C VA: 0x648AC6C
	internal void <onSuccess>b__0() { }
}

// Namespace: 
[Preserve]
private class NativeSDKAndroid.RawSuccessCb : AndroidJavaProxy // TypeDefIndex: 28322
{
	// Fields
	private readonly Action<string> _cb; // 0x20

	// Methods

	[Preserve]
	// RVA: 0x648AAD8 Offset: 0x6486AD8 VA: 0x648AAD8
	public void .ctor(Action<string> cb) { }

	[Preserve]
	// RVA: 0x648AB64 Offset: 0x6486B64 VA: 0x648AB64
	public void onSuccess(string result) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NativeSDKAndroid.FailureCb.<>c__DisplayClass2_0 // TypeDefIndex: 28323
{
	// Fields
	public NativeSDKAndroid.FailureCb <>4__this; // 0x10
	public int code; // 0x18
	public string msg; // 0x20

	// Methods

	// RVA: 0x648AE38 Offset: 0x6486E38 VA: 0x648AE38
	public void .ctor() { }

	// RVA: 0x648AE40 Offset: 0x6486E40 VA: 0x648AE40
	internal void <onFailure>b__0() { }
}

// Namespace: 
[Preserve]
private class NativeSDKAndroid.FailureCb : AndroidJavaProxy // TypeDefIndex: 28324
{
	// Fields
	private readonly Action<int, string> _cb; // 0x20

	// Methods

	[Preserve]
	// RVA: 0x648ACA4 Offset: 0x6486CA4 VA: 0x648ACA4
	public void .ctor(Action<int, string> cb) { }

	[Preserve]
	// RVA: 0x648AD30 Offset: 0x6486D30 VA: 0x648AD30
	public void onFailure(int code, string msg) { }
}

// Namespace: 
[Preserve]
private class NativeSDKAndroid.CancelCb : AndroidJavaProxy // TypeDefIndex: 28325
{
	// Fields
	private readonly Action _cb; // 0x20

	// Methods

	[Preserve]
	// RVA: 0x648AEC4 Offset: 0x6486EC4 VA: 0x648AEC4
	public void .ctor(Action cb) { }

	[Preserve]
	// RVA: 0x648AF50 Offset: 0x6486F50 VA: 0x648AF50
	public void onCancel() { }

	[CompilerGenerated]
	// RVA: 0x648AFF4 Offset: 0x6486FF4 VA: 0x648AFF4
	private void <onCancel>b__2_0() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class NativeSDKAndroid.<>c // TypeDefIndex: 28326
{
	// Fields
	public static readonly NativeSDKAndroid.<>c <>9; // 0x0
	public static Action <>9__18_0; // 0x8
	public static Action <>9__32_0; // 0x10

	// Methods

	// RVA: 0x648B010 Offset: 0x6487010 VA: 0x648B010
	private static void .cctor() { }

	// RVA: 0x648B078 Offset: 0x6487078 VA: 0x648B078
	public void .ctor() { }

	// RVA: 0x648B080 Offset: 0x6487080 VA: 0x648B080
	internal void <.ctor>b__18_0() { }

	// RVA: 0x648B2B4 Offset: 0x64872B4 VA: 0x648B2B4
	internal void <OpenSystemSettings>b__32_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NativeSDKAndroid.<>c__DisplayClass19_0 // TypeDefIndex: 28327
{
	// Fields
	public bool enable; // 0x10

	// Methods

	// RVA: 0x648840C Offset: 0x648440C VA: 0x648840C
	public void .ctor() { }

	// RVA: 0x648B958 Offset: 0x6487958 VA: 0x648B958
	internal void <SetEnableLog>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NativeSDKAndroid.<>c__DisplayClass26_0 // TypeDefIndex: 28328
{
	// Fields
	public Action<string> onEvent; // 0x10
	public Action<string> onSuccess; // 0x18

	// Methods

	// RVA: 0x648961C Offset: 0x648561C VA: 0x648961C
	public void .ctor() { }

	// RVA: 0x648BA80 Offset: 0x6487A80 VA: 0x648BA80
	internal void <NumberAuthLogin>b__0(string raw) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NativeSDKAndroid.<>c__DisplayClass31_0 // TypeDefIndex: 28329
{
	// Fields
	public ShowPayListArgs args; // 0x10

	// Methods

	// RVA: 0x6489DDC Offset: 0x6485DDC VA: 0x6489DDC
	public void .ctor() { }

	// RVA: 0x648BB18 Offset: 0x6487B18 VA: 0x648BB18
	internal void <ShowPayList>b__0(string raw) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NativeSDKAndroid.<>c__DisplayClass33_0 // TypeDefIndex: 28330
{
	// Fields
	public Action onPresented; // 0x10
	public Action onConfirmed; // 0x18
	public Action<int, string> onFailure; // 0x20

	// Methods

	// RVA: 0x648A458 Offset: 0x6486458 VA: 0x648A458
	public void .ctor() { }

	// RVA: 0x648BC7C Offset: 0x6487C7C VA: 0x648BC7C
	internal void <ShowPrivacyPolicy>b__0(string raw) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NativeSDKAndroid.<>c__DisplayClass34_0 // TypeDefIndex: 28331
{
	// Fields
	public Action onSuccess; // 0x10

	// Methods

	// RVA: 0x648A654 Offset: 0x6486654 VA: 0x648A654
	public void .ctor() { }

	// RVA: 0x648BEA8 Offset: 0x6487EA8 VA: 0x648BEA8
	internal void <SetAlternateIcon>b__0(string _) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NativeSDKAndroid.<>c__DisplayClass46_0<T> // TypeDefIndex: 28332
{
	// Fields
	public string methodName; // 0x0
	public string pluginClassName; // 0x0
	public Action<T> onSuccess; // 0x0
	public Action<int, string> onFailure; // 0x0
	public Action onCancel; // 0x0
	public AndroidJavaObject jsonObject; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5457818 Offset: 0x5453818 VA: 0x5457818
	|-NativeSDKAndroid.<>c__DisplayClass46_0<object>..ctor
	|
	|-RVA: 0x5457A84 Offset: 0x5453A84 VA: 0x5457A84
	|-NativeSDKAndroid.<>c__DisplayClass46_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CallNativeMethodWithCallback>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5457820 Offset: 0x5453820 VA: 0x5457820
	|-NativeSDKAndroid.<>c__DisplayClass46_0<object>.<CallNativeMethodWithCallback>b__0
	|
	|-RVA: 0x5457A8C Offset: 0x5453A8C VA: 0x5457A8C
	|-NativeSDKAndroid.<>c__DisplayClass46_0<__Il2CppFullySharedGenericType>.<CallNativeMethodWithCallback>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class NativeSDKAndroid.<>c__DisplayClass47_0 // TypeDefIndex: 28333
{
	// Fields
	public string methodName; // 0x10
	public string pluginClassName; // 0x18
	public Action<string> onSuccess; // 0x20
	public Action<int, string> onFailure; // 0x28
	public AndroidJavaObject jsonObject; // 0x30

	// Methods

	// RVA: 0x648A96C Offset: 0x648696C VA: 0x648A96C
	public void .ctor() { }

	// RVA: 0x648BEC4 Offset: 0x6487EC4 VA: 0x648BEC4
	internal void <CallNativeMethodRawWithCallback>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NativeSDKAndroid.<>c__DisplayClass48_0 // TypeDefIndex: 28334
{
	// Fields
	public string methodName; // 0x10
	public Action<string> onSuccess; // 0x18
	public Action<int, string> onFailure; // 0x20
	public Action onCancel; // 0x28
	public AndroidJavaObject jsonObject; // 0x30

	// Methods

	// RVA: 0x648A974 Offset: 0x6486974 VA: 0x648A974
	public void .ctor() { }

	// RVA: 0x648C0B0 Offset: 0x64880B0 VA: 0x648C0B0
	internal void <CallStaticMethodRawWithCallback>b__0() { }
}

// Namespace: GorillaNative.Runtime
internal class NativeSDKAndroid : INativeSDK, INumberAuth, IAlternateIcon, INativePrivacyPolicyPresenter // TypeDefIndex: 28335
{
	// Fields
	private static readonly HashSet<string> PluginClasses; // 0x0
	private static readonly Dictionary<string, string> PluginAliasMap; // 0x8
	private static bool _pluginsCollected; // 0x10
	private static string _weChatPluginName; // 0x18
	private static string _qqPluginName; // 0x20
	private static string _aliPluginName; // 0x28
	private static string _numberAuthPluginName; // 0x30
	private static NativeSDKAndroid _instance; // 0x38
	private static AndroidJavaObject _activity; // 0x40
	private static AndroidJavaClass _apiClass; // 0x48

	// Properties
	public static NativeSDKAndroid Instance { get; }

	// Methods

	// RVA: 0x6486360 Offset: 0x6482360 VA: 0x6486360
	public static NativeSDKAndroid get_Instance() { }

	// RVA: 0x6487494 Offset: 0x6483494 VA: 0x6487494
	private void .ctor() { }

	// RVA: 0x648833C Offset: 0x648433C VA: 0x648833C Slot: 4
	public void SetEnableLog(bool enable) { }

	// RVA: 0x6488414 Offset: 0x6484414 VA: 0x6488414
	private static void RegisterPlugin(string pluginName) { }

	// RVA: 0x648853C Offset: 0x648453C VA: 0x648853C Slot: 5
	public void WeChatLogin(object args, Action<WeChatLoginResult> onSuccess, Action<int, string> onFailure, Action onCancel) { }

	// RVA: 0x6488744 Offset: 0x6484744 VA: 0x6488744 Slot: 6
	public void QQLogin(object args, Action<QQLoginResult> onSuccess, Action<int, string> onFailure, Action onCancel) { }

	// RVA: 0x6488850 Offset: 0x6484850 VA: 0x6488850 Slot: 7
	public void SendSms(SendSmsArgs args, Action<string> onSuccess, Action<int, string> onFailure, Action onCancel) { }

	// RVA: 0x6488C64 Offset: 0x6484C64 VA: 0x6488C64 Slot: 13
	public void NumberAuthInit(NumberAuthConfig args, Action<string> onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x648938C Offset: 0x648538C VA: 0x648938C Slot: 14
	public void NumberAuthPrepare(NumberAuthConfig args, Action<string> onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x6489480 Offset: 0x6485480 VA: 0x6489480 Slot: 15
	public void NumberAuthLogin(NumberAuthConfig args, Action<string> onSuccess, Action<int, string> onFailure, Action<string> onEvent) { }

	// RVA: 0x6489624 Offset: 0x6485624 VA: 0x6489624 Slot: 16
	public void NumberAuthDismiss(Action<string> onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x6489700 Offset: 0x6485700 VA: 0x6489700 Slot: 8
	public bool IsAppInstalled(NativeApp app) { }

	// RVA: 0x6489ABC Offset: 0x6485ABC VA: 0x6489ABC Slot: 9
	public void WeChatPay(WeChatPurchaseArgs args) { }

	// RVA: 0x6489BA8 Offset: 0x6485BA8 VA: 0x6489BA8 Slot: 10
	public void AliPay(AliPurchaseArgs args) { }

	// RVA: 0x6489C94 Offset: 0x6485C94 VA: 0x6489C94 Slot: 11
	public void ShowPayList(ShowPayListArgs args) { }

	// RVA: 0x648A108 Offset: 0x6486108 VA: 0x648A108 Slot: 12
	public void OpenSystemSettings() { }

	// RVA: 0x648A304 Offset: 0x6486304 VA: 0x648A304 Slot: 18
	public void ShowPrivacyPolicy(PrivacyPolicyNativeArgs args, Action onPresented, Action onConfirmed, Action onCancelled, Action<int, string> onFailure) { }

	// RVA: 0x648A460 Offset: 0x6486460 VA: 0x648A460 Slot: 17
	public void SetAlternateIcon(string iconName, Action onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x6489DE4 Offset: 0x6485DE4 VA: 0x6489DE4
	private static Dictionary<string, object> SerializeShowPayListArgs(ShowPayListArgs args) { }

	// RVA: 0x648A6D0 Offset: 0x64866D0 VA: 0x648A6D0
	private static PayChannelId ParseShowPayListChannel(string channel) { }

	// RVA: 0x648A65C Offset: 0x648665C VA: 0x648A65C
	private static string ToNativePayListChannel(PayChannelId channelId) { }

	// RVA: 0x6488D58 Offset: 0x6484D58 VA: 0x6488D58
	private Dictionary<string, object> SerializeNumberAuthArgs(NumberAuthConfig args, Action<int, string> onFailure) { }

	// RVA: 0x648A7B4 Offset: 0x64867B4 VA: 0x648A7B4
	private static bool IsNumberAuthEventPayload(string raw) { }

	// RVA: 0x648794C Offset: 0x648394C VA: 0x648794C
	private static void CollectPluginClasses() { }

	// RVA: 0x648A8BC Offset: 0x64868BC VA: 0x648A8BC
	private static string ResolvePluginClass(string alias) { }

	// RVA: 0x6488648 Offset: 0x6484648 VA: 0x6488648
	private static bool EnsurePluginConfigured(string pluginName, string alias, Action<int, string> onFailure) { }

	// RVA: -1 Offset: -1
	private static void CallNativeMethodWithCallback<T>(string methodName, string pluginClassName, object args, Action<T> onSuccess, Action<int, string> onFailure, Action onCancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4680500 Offset: 0x467C500 VA: 0x4680500
	|-NativeSDKAndroid.CallNativeMethodWithCallback<object>
	|
	|-RVA: 0x46809B0 Offset: 0x467C9B0 VA: 0x46809B0
	|-NativeSDKAndroid.CallNativeMethodWithCallback<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x6488F14 Offset: 0x6484F14 VA: 0x6488F14
	private static void CallNativeMethodRawWithCallback(string methodName, string pluginClassName, object args, Action<string> onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x64888E4 Offset: 0x64848E4 VA: 0x64888E4
	private static void CallStaticMethodRawWithCallback(string methodName, object args, Action<string> onSuccess, Action<int, string> onFailure, Action onCancel) { }

	// RVA: 0x64880CC Offset: 0x64840CC VA: 0x64880CC
	private static void RunOnUIThread(Action action) { }

	// RVA: 0x648A97C Offset: 0x648697C VA: 0x648A97C
	private static void .cctor() { }
}

// Namespace: GorillaNative.Runtime
internal class NativeSDKEditor : INativeSDK // TypeDefIndex: 28336
{
	// Methods

	// RVA: 0x648C2C4 Offset: 0x64882C4 VA: 0x648C2C4 Slot: 4
	public void SetEnableLog(bool enable) { }

	// RVA: 0x648C32C Offset: 0x648832C VA: 0x648C32C Slot: 5
	public void WeChatLogin(object args, Action<WeChatLoginResult> onSuccess, Action<int, string> onFailure, Action onCancel) { }

	// RVA: 0x648C3D4 Offset: 0x64883D4 VA: 0x648C3D4 Slot: 6
	public void QQLogin(object args, Action<QQLoginResult> onSuccess, Action<int, string> onFailure, Action onCancel) { }

	// RVA: 0x648C47C Offset: 0x648847C VA: 0x648C47C Slot: 7
	public void SendSms(SendSmsArgs args, Action<string> onSuccess, Action<int, string> onFailure, Action onCancel) { }

	// RVA: 0x648C524 Offset: 0x6488524 VA: 0x648C524 Slot: 8
	public bool IsAppInstalled(NativeApp app) { }

	// RVA: 0x648C594 Offset: 0x6488594 VA: 0x648C594 Slot: 11
	public void ShowPayList(ShowPayListArgs args) { }

	// RVA: 0x648C644 Offset: 0x6488644 VA: 0x648C644 Slot: 9
	public void WeChatPay(WeChatPurchaseArgs args) { }

	// RVA: 0x648C6F8 Offset: 0x64886F8 VA: 0x648C6F8 Slot: 10
	public void AliPay(AliPurchaseArgs args) { }

	// RVA: 0x648C7AC Offset: 0x64887AC VA: 0x648C7AC Slot: 12
	public void OpenSystemSettings() { }

	// RVA: 0x6486358 Offset: 0x6482358 VA: 0x6486358
	public void .ctor() { }
}

// Namespace: GorillaNative.Runtime.Model
[Preserve]
[Serializable]
public enum NativeApp // TypeDefIndex: 28337
{
	// Fields
	public int value__; // 0x0
	public const NativeApp WeChat = 0;
	public const NativeApp QQ = 1;
	public const NativeApp Weibo = 2;
}

// Namespace: GorillaNative.Runtime.Model
[Preserve]
[Serializable]
internal enum NativeCallbackStatus // TypeDefIndex: 28338
{
	// Fields
	public int value__; // 0x0
	public const NativeCallbackStatus Success = 0;
	public const NativeCallbackStatus Failure = 1;
	public const NativeCallbackStatus Cancel = 2;
}

// Namespace: GorillaNative.Runtime.Model
[Preserve]
[Serializable]
internal class NativeErrorResult // TypeDefIndex: 28339
{
	// Fields
	[Preserve]
	public int code; // 0x10
	[Preserve]
	public string message; // 0x18

	// Methods

	// RVA: 0x648C814 Offset: 0x6488814 VA: 0x648C814 Slot: 3
	public override string ToString() { }

	// RVA: 0x648C820 Offset: 0x6488820 VA: 0x648C820
	public void .ctor() { }
}

// Namespace: GorillaNative.Runtime.Model
[Preserve]
[Serializable]
public class NumberAuthConfig // TypeDefIndex: 28340
{
	// Fields
	[HideInInspector]
	[Preserve]
	public string appId; // 0x10
	[Preserve]
	public string iOSAppId; // 0x18
	[Preserve]
	public string androidAppId; // 0x20
	[Preserve]
	public bool enableLogger; // 0x28
	[Preserve]
	public int timeoutMs; // 0x2C
	[Preserve]
	public bool privacyChecked; // 0x30
	[HideInInspector]
	[Preserve]
	public string customLogoBase64; // 0x38
	[HideInInspector]
	[Preserve]
	public string userUrl; // 0x40
	[HideInInspector]
	[Preserve]
	public string privacyUrl; // 0x48

	// Methods

	// RVA: 0x648C828 Offset: 0x6488828 VA: 0x648C828
	public string ResolveAppId() { }

	// RVA: 0x648C87C Offset: 0x648887C VA: 0x648C87C
	public void .ctor() { }
}

// Namespace: GorillaNative.Runtime.Model
[Preserve]
[Serializable]
public class NumberAuthLoginResult // TypeDefIndex: 28341
{
	// Fields
	[Preserve]
	public string code; // 0x10
	[Preserve]
	public string message; // 0x18
	[Preserve]
	public string token; // 0x20
	[Preserve]
	public string provider; // 0x28
	[Preserve]
	public string raw; // 0x30

	// Methods

	// RVA: 0x648C88C Offset: 0x648888C VA: 0x648C88C Slot: 3
	public override string ToString() { }

	// RVA: 0x648CA8C Offset: 0x6488A8C VA: 0x648CA8C
	public void .ctor() { }
}

// Namespace: GorillaNative.Runtime.Model
[Preserve]
[Serializable]
public class NumberAuthEventResult // TypeDefIndex: 28342
{
	// Fields
	[Preserve]
	public string eventType; // 0x10
	[Preserve]
	public string code; // 0x18
	[Preserve]
	public string message; // 0x20
	[Preserve]
	public Nullable<bool> isChecked; // 0x28
	[Preserve]
	public bool terminal; // 0x2A
	[Preserve]
	public string raw; // 0x30

	// Methods

	// RVA: 0x648CA94 Offset: 0x6488A94 VA: 0x648CA94 Slot: 3
	public override string ToString() { }

	// RVA: 0x648CCC4 Offset: 0x6488CC4 VA: 0x648CCC4
	public void .ctor() { }
}

// Namespace: GorillaNative.Runtime.Model
[Preserve]
[Serializable]
internal sealed class PrivacyPolicyNativeArgs // TypeDefIndex: 28343
{
	// Fields
	[Preserve]
	public string title; // 0x10
	[Preserve]
	public string content; // 0x18
	[Preserve]
	public string confirmButtonText; // 0x20
	[Preserve]
	public string cancelButtonText; // 0x28
	[Preserve]
	public bool showCancelButton; // 0x30
	[Preserve]
	public PrivacyPolicyNativeLink serviceTermsLink; // 0x38
	[Preserve]
	public PrivacyPolicyNativeLink privacyPolicyLink; // 0x40

	// Methods

	// RVA: 0x6485FE4 Offset: 0x6481FE4 VA: 0x6485FE4
	public void .ctor() { }
}

// Namespace: GorillaNative.Runtime.Model
[Preserve]
[Serializable]
internal sealed class PrivacyPolicyNativeLink // TypeDefIndex: 28344
{
	// Fields
	[Preserve]
	public int start; // 0x10
	[Preserve]
	public int length; // 0x14
	[Preserve]
	public string url; // 0x18

	// Methods

	// RVA: 0x6485FEC Offset: 0x6481FEC VA: 0x6485FEC
	public void .ctor() { }
}

// Namespace: GorillaNative.Runtime.Model
[Preserve]
[Serializable]
public class ShowPayListArgs : Callback<PayChannelId> // TypeDefIndex: 28345
{
	// Fields
	[Preserve]
	public long amountFen; // 0x28
	[Preserve]
	public PayChannelId[] showList; // 0x30

	// Methods

	// RVA: 0x648CCCC Offset: 0x6488CCC VA: 0x648CCCC
	public void .ctor() { }
}

