// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28535
{}

// Namespace: 
[CompilerGenerated]
private sealed class Gorilla.<>c__DisplayClass17_0 // TypeDefIndex: 28536
{
	// Fields
	public Action<PrivacyPolicyResult> onResult; // 0x10
	public Action<int, string> onFailure; // 0x18
	public bool presented; // 0x20
	public bool terminalInvoked; // 0x21

	// Methods

	// RVA: 0x642D6A8 Offset: 0x64296A8 VA: 0x642D6A8
	public void .ctor() { }

	// RVA: 0x642E754 Offset: 0x642A754 VA: 0x642E754
	internal void <ShowPrivacyPolicy>b__6() { }

	// RVA: 0x642E774 Offset: 0x642A774 VA: 0x642E774
	internal void <ShowPrivacyPolicy>g__MarkPresented|0() { }

	// RVA: 0x642E7EC Offset: 0x642A7EC VA: 0x642E7EC
	internal void <ShowPrivacyPolicy>g__Complete|1(PrivacyPolicyResult result) { }

	// RVA: 0x642D7BC Offset: 0x64297BC VA: 0x642D7BC
	internal void <ShowPrivacyPolicy>g__Fail|2(int code, string message) { }

	// RVA: 0x642E8F0 Offset: 0x642A8F0 VA: 0x642E8F0
	internal void <ShowPrivacyPolicy>b__3() { }

	// RVA: 0x642E994 Offset: 0x642A994 VA: 0x642E994
	internal void <ShowPrivacyPolicy>b__4() { }

	// RVA: 0x642E99C Offset: 0x642A99C VA: 0x642E99C
	internal void <ShowPrivacyPolicy>b__5() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Gorilla.<>c__DisplayClass17_1 // TypeDefIndex: 28537
{
	// Fields
	public string validationError; // 0x10
	public Gorilla.<>c__DisplayClass17_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x642D6B0 Offset: 0x64296B0 VA: 0x642D6B0
	public void .ctor() { }

	// RVA: 0x642E9A4 Offset: 0x642A9A4 VA: 0x642E9A4
	internal void <ShowPrivacyPolicy>b__7() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Gorilla.<>c__DisplayClass17_2 // TypeDefIndex: 28538
{
	// Fields
	public PrivacyPolicyResult result; // 0x10
	public Gorilla.<>c__DisplayClass17_0 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0x642E8E0 Offset: 0x642A8E0 VA: 0x642E8E0
	public void .ctor() { }

	// RVA: 0x642E9E0 Offset: 0x642A9E0 VA: 0x642E9E0
	internal void <ShowPrivacyPolicy>b__8() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Gorilla.<>c__DisplayClass17_3 // TypeDefIndex: 28539
{
	// Fields
	public int code; // 0x10
	public string message; // 0x18
	public Gorilla.<>c__DisplayClass17_0 CS$<>8__locals3; // 0x20

	// Methods

	// RVA: 0x642E8E8 Offset: 0x642A8E8 VA: 0x642E8E8
	public void .ctor() { }

	// RVA: 0x642EB54 Offset: 0x642AB54 VA: 0x642EB54
	internal void <ShowPrivacyPolicy>b__9() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Gorilla.<>c__DisplayClass25_0 // TypeDefIndex: 28540
{
	// Fields
	public Action<LoginResult> onSuccess; // 0x10

	// Methods

	// RVA: 0x642E114 Offset: 0x642A114 VA: 0x642E114
	public void .ctor() { }

	// RVA: 0x642ECC0 Offset: 0x642ACC0 VA: 0x642ECC0
	internal void <BuildLoginArgsWithStandardProperties>b__0(LoginResult result) { }
}

// Namespace: GorillaHub.Runtime
public static class Gorilla // TypeDefIndex: 28541
{
	// Fields
	private const int UnsupportedPaymentErrorCode = -1;
	private const string PrivacyPolicyShownKey = "gorilla_sdk_privacy_policy_shown";
	private const string Tag = "[Gorilla]";
	private static readonly object PrivacyPolicyLock; // 0x0
	private static IPrivacyPolicyService _privacyPolicyService; // 0x8
	private static bool _privacyPolicyShowing; // 0x10

	// Properties
	public static IPrivacyPolicyService PrivacyPolicyService { get; set; }

	// Methods

	// RVA: 0x642C0F4 Offset: 0x64280F4 VA: 0x642C0F4
	public static void Init(SDKConfig config, Action<bool> callback) { }

	[Obsolete("Use Login(LoginArgs args) instead")]
	// RVA: 0x642C6BC Offset: 0x64286BC VA: 0x642C6BC
	public static void Login(Action<LoginResult> onSuccess, Action<int, string> onFailure, Action onCancel) { }

	// RVA: 0x642C780 Offset: 0x6428780 VA: 0x642C780
	public static void Login(LoginArgs args) { }

	// RVA: 0x642C988 Offset: 0x6428988 VA: 0x642C988
	public static void Logout() { }

	// RVA: 0x642CA5C Offset: 0x6428A5C VA: 0x642CA5C
	public static void Bind(BindArgs args) { }

	// RVA: 0x642CB30 Offset: 0x6428B30 VA: 0x642CB30
	public static void DeleteAccount(Action<bool> onFinish) { }

	// RVA: 0x642CC04 Offset: 0x6428C04 VA: 0x642CC04
	public static void OpenUserCenter(OpenUserCenterArgs args) { }

	// RVA: 0x642CD5C Offset: 0x6428D5C VA: 0x642CD5C
	public static void OpenAntiAddictionTip(Action onClose) { }

	// RVA: 0x642CEB8 Offset: 0x6428EB8 VA: 0x642CEB8
	public static IPrivacyPolicyService get_PrivacyPolicyService() { }

	// RVA: 0x642CFCC Offset: 0x6428FCC VA: 0x642CFCC
	public static void set_PrivacyPolicyService(IPrivacyPolicyService value) { }

	// RVA: 0x642D0E8 Offset: 0x64290E8 VA: 0x642D0E8
	public static void ShowPrivacyPolicy(PrivacyPolicyRequest request, Action<PrivacyPolicyResult> onResult, Action<int, string> onFailure) { }

	// RVA: 0x642D6B8 Offset: 0x64296B8 VA: 0x642D6B8
	private static bool TryValidatePrivacyPolicyRequest(PrivacyPolicyRequest request, out string error) { }

	// RVA: 0x642D8C4 Offset: 0x64298C4 VA: 0x642D8C4
	private static bool IsHttpUrl(string value) { }

	// RVA: 0x642D9D4 Offset: 0x64299D4 VA: 0x642D9D4
	public static void ShowPayList(long amountFen, Action<PayChannelId> onSuccess, Action<int, string> onFailure, Action onCancel) { }

	// RVA: 0x642DAE0 Offset: 0x6429AE0 VA: 0x642DAE0
	public static void ShowPayList(long amountFen, PayChannelId[] showList, Action<PayChannelId> onSuccess, Action<int, string> onFailure, Action onCancel) { }

	// RVA: 0x642DBB4 Offset: 0x6429BB4 VA: 0x642DBB4
	public static void Pay(PurchaseArgs args) { }

	// RVA: 0x642DDDC Offset: 0x6429DDC VA: 0x642DDDC
	public static void QueryOrderResult(QueryOrderArgs args, Action<QueryOrderResponse> onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x642DFC4 Offset: 0x6429FC4 VA: 0x642DFC4
	public static void SetLogEnable(bool enable) { }

	// RVA: 0x642C888 Offset: 0x6428888 VA: 0x642C888
	private static LoginArgs BuildLoginArgsWithStandardProperties(LoginArgs args) { }

	// RVA: 0x642E11C Offset: 0x642A11C VA: 0x642E11C
	private static void OnLoginSuccess(LoginResult result) { }

	// RVA: 0x642DD28 Offset: 0x6429D28 VA: 0x642DD28
	private static string BuildUnsupportedPurchaseArgsMessage(PurchaseArgs args) { }

	// RVA: 0x642E6D8 Offset: 0x642A6D8 VA: 0x642E6D8
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ExplicitOverseasAccountService.<>c // TypeDefIndex: 28542
{
	// Fields
	public static readonly ExplicitOverseasAccountService.<>c <>9; // 0x0
	public static Func<IAccountService> <>9__2_0; // 0x8

	// Methods

	// RVA: 0x6430894 Offset: 0x642C894 VA: 0x6430894
	private static void .cctor() { }

	// RVA: 0x64308FC Offset: 0x642C8FC VA: 0x64308FC
	public void .ctor() { }

	// RVA: 0x6430904 Offset: 0x642C904 VA: 0x6430904
	internal IAccountService <Register>b__2_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ExplicitOverseasAccountService.<>c__DisplayClass10_0 // TypeDefIndex: 28543
{
	// Fields
	public LoginArgs args; // 0x10
	public ExplicitOverseasAccountService <>4__this; // 0x18

	// Methods

	// RVA: 0x6430030 Offset: 0x642C030 VA: 0x6430030
	public void .ctor() { }

	// RVA: 0x6430958 Offset: 0x642C958 VA: 0x6430958
	internal void <LoginWithAppleID>b__0(AppleIDLoginResult result) { }

	// RVA: 0x6430990 Offset: 0x642C990 VA: 0x6430990
	internal void <LoginWithAppleID>b__1(int code, string message) { }

	// RVA: 0x6430998 Offset: 0x642C998 VA: 0x6430998
	internal void <LoginWithAppleID>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ExplicitOverseasAccountService.<>c__DisplayClass11_0 // TypeDefIndex: 28544
{
	// Fields
	public ExplicitOverseasAccountService <>4__this; // 0x10
	public BindArgs args; // 0x18

	// Methods

	// RVA: 0x6430038 Offset: 0x642C038 VA: 0x6430038
	public void .ctor() { }

	// RVA: 0x64309A0 Offset: 0x642C9A0 VA: 0x64309A0
	internal void <BindWithFacebook>b__0(FacebookLoginResult result) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ExplicitOverseasAccountService.<>c__DisplayClass13_0 // TypeDefIndex: 28545
{
	// Fields
	public ExplicitOverseasAccountService <>4__this; // 0x10
	public BindArgs args; // 0x18

	// Methods

	// RVA: 0x64300CC Offset: 0x642C0CC VA: 0x64300CC
	public void .ctor() { }

	// RVA: 0x64309C0 Offset: 0x642C9C0 VA: 0x64309C0
	internal void <BindWithAppleID>b__0(AppleIDLoginResult result) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ExplicitOverseasAccountService.<>c__DisplayClass8_0 // TypeDefIndex: 28546
{
	// Fields
	public LoginArgs args; // 0x10
	public ExplicitOverseasAccountService <>4__this; // 0x18

	// Methods

	// RVA: 0x642FFDC Offset: 0x642BFDC VA: 0x642FFDC
	public void .ctor() { }

	// RVA: 0x64309E0 Offset: 0x642C9E0 VA: 0x64309E0
	internal void <LoginWithFacebook>b__0(FacebookLoginResult result) { }

	// RVA: 0x6430A18 Offset: 0x642CA18 VA: 0x6430A18
	internal void <LoginWithFacebook>b__1(int code, string message) { }

	// RVA: 0x6430A20 Offset: 0x642CA20 VA: 0x6430A20
	internal void <LoginWithFacebook>b__2() { }
}

// Namespace: GorillaHub.Runtime
[Preserve]
internal class ExplicitOverseasAccountService : DefaultAccountService // TypeDefIndex: 28547
{
	// Methods

	[Preserve]
	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x642ED4C Offset: 0x642AD4C VA: 0x642ED4C
	private static void Register() { }

	// RVA: 0x642EE54 Offset: 0x642AE54 VA: 0x642EE54 Slot: 12
	public override void Login(LoginArgs args) { }

	// RVA: 0x642F00C Offset: 0x642B00C VA: 0x642F00C
	private void TryLoginWithCachedToken(LoginArgs args) { }

	// RVA: 0x642F89C Offset: 0x642B89C VA: 0x642F89C Slot: 16
	public override void Logout() { }

	// RVA: 0x642F9C4 Offset: 0x642B9C4 VA: 0x642F9C4 Slot: 17
	public override void Bind(BindArgs args) { }

	// RVA: 0x642F218 Offset: 0x642B218 VA: 0x642F218
	private void LoginWithDevice(LoginArgs args) { }

	// RVA: 0x642F248 Offset: 0x642B248 VA: 0x642F248
	private void LoginWithFacebook(LoginArgs args) { }

	// RVA: 0x642F524 Offset: 0x642B524 VA: 0x642F524
	private void LoginWithPlayGame(LoginArgs args) { }

	// RVA: 0x642F56C Offset: 0x642B56C VA: 0x642F56C
	private void LoginWithAppleID(LoginArgs args) { }

	// RVA: 0x642FCD8 Offset: 0x642BCD8 VA: 0x642FCD8
	private void BindWithFacebook(BindArgs args) { }

	// RVA: 0x642FC90 Offset: 0x642BC90 VA: 0x642FC90
	private void BindWithPlayGame(BindArgs args) { }

	// RVA: 0x642FB08 Offset: 0x642BB08 VA: 0x642FB08
	private void BindWithAppleID(BindArgs args) { }

	// RVA: 0x6430040 Offset: 0x642C040 VA: 0x6430040
	private static LoginArgs CreateFacebookLoginArgs(BindArgs args) { }

	// RVA: 0x64300D4 Offset: 0x642C0D4 VA: 0x64300D4
	private void SendFacebookLoginRequest(FacebookLoginResult result, LoginArgs args) { }

	// RVA: 0x6430274 Offset: 0x642C274 VA: 0x6430274
	private void SendFacebookBindRequest(FacebookLoginResult result, BindArgs args) { }

	// RVA: 0x6430408 Offset: 0x642C408 VA: 0x6430408
	private void SendAppleIDLoginRequest(AppleIDLoginResult result, LoginArgs args) { }

	// RVA: 0x64305A0 Offset: 0x642C5A0 VA: 0x64305A0
	private void SendAppleIDBindRequest(AppleIDLoginResult result, BindArgs args) { }

	// RVA: 0x642FFE4 Offset: 0x642BFE4 VA: 0x642FFE4
	private static void TrackChannelLoginStart(LoginArgs args) { }

	// RVA: 0x643072C Offset: 0x642C72C VA: 0x643072C
	private static void TrackChannelLoginSuccess(LoginArgs args) { }

	// RVA: 0x6430778 Offset: 0x642C778 VA: 0x6430778
	private static void FailChannelLogin(LoginArgs args, int code, string message) { }

	// RVA: 0x6430818 Offset: 0x642C818 VA: 0x6430818
	private static void CancelChannelLogin(LoginArgs args) { }

	// RVA: 0x642F790 Offset: 0x642B790 VA: 0x642F790
	private static void Fail(LoginArgs args, string message) { }

	// RVA: 0x642FF18 Offset: 0x642BF18 VA: 0x642FF18
	private static void Fail(BindArgs args, string message) { }

	// RVA: 0x643088C Offset: 0x642C88C VA: 0x643088C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class OverseasAccountService.<>c // TypeDefIndex: 28548
{
	// Fields
	public static readonly OverseasAccountService.<>c <>9; // 0x0
	public static Func<IAccountService> <>9__1_0; // 0x8

	// Methods

	// RVA: 0x643107C Offset: 0x642D07C VA: 0x643107C
	private static void .cctor() { }

	// RVA: 0x64310E4 Offset: 0x642D0E4 VA: 0x64310E4
	public void .ctor() { }

	// RVA: 0x64310EC Offset: 0x642D0EC VA: 0x64310EC
	internal IAccountService <Register>b__1_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class OverseasAccountService.<>c__DisplayClass2_0 // TypeDefIndex: 28549
{
	// Fields
	public OverseasAccountService <>4__this; // 0x10
	public LoginArgs args; // 0x18

	// Methods

	// RVA: 0x6430D44 Offset: 0x642CD44 VA: 0x6430D44
	public void .ctor() { }

	// RVA: 0x6431140 Offset: 0x642D140 VA: 0x6431140
	internal void <Login>b__0(GameCenterLoginResult result) { }

	// RVA: 0x6431160 Offset: 0x642D160 VA: 0x6431160
	internal void <Login>b__1(int code, string message) { }

	// RVA: 0x6431444 Offset: 0x642D444 VA: 0x6431444
	internal void <Login>b__2() { }
}

// Namespace: GorillaHub.Runtime
[Preserve]
internal class OverseasAccountService : DefaultAccountService // TypeDefIndex: 28550
{
	// Methods

	[RuntimeInitializeOnLoadMethod(1)]
	[Preserve]
	// RVA: 0x6430A28 Offset: 0x642CA28 VA: 0x6430A28
	private static void Register() { }

	// RVA: 0x6430B30 Offset: 0x642CB30 VA: 0x6430B30 Slot: 12
	public override void Login(LoginArgs args) { }

	// RVA: 0x6430D4C Offset: 0x642CD4C VA: 0x6430D4C
	private void SendGameCenterLoginRequest(GameCenterLoginResult result, LoginArgs args) { }

	[Preserve]
	// RVA: 0x6430EDC Offset: 0x642CEDC VA: 0x6430EDC
	private void SendPlayGameLoginRequest(PlayGameLoginResult result, LoginArgs args) { }

	// RVA: 0x643106C Offset: 0x642D06C VA: 0x643106C
	public void .ctor() { }

	[CompilerGenerated]
	[DebuggerHidden]
	// RVA: 0x6431074 Offset: 0x642D074 VA: 0x6431074
	private void <>n__0(LoginArgs args) { }
}

