// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28005
{}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 28006
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
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 28007
{
	// Methods

	// RVA: 0x64257A0 Offset: 0x64217A0 VA: 0x64257A0
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x6425898 Offset: 0x6421898 VA: 0x6425898
	public void .ctor() { }
}

// Namespace: GorillaGM.Runtime
public static class API // TypeDefIndex: 28008
{
	// Fields
	public const string OverseaTestServerUrl = "https://gm-test-api.gorillasvc.com";
	public const string OverseaServerUrl = "https://gm-api.gorillasvc.com.com";
	public const string ChinaTestServerUrl = "https://gm-test-api.dxxsvc.com";
	public const string ChinaServerUrl = "https://gm-api.dxxsvc.com";
}

// Namespace: GorillaGM.Runtime
[CreateAssetMenu(fileName = "CloudConfig", menuName = "GorillaSDK/Cloud Config")]
public class CloudConfig : ScriptableObject // TypeDefIndex: 28009
{
	// Fields
	public string serverUrl; // 0x18
	public string serviceToken; // 0x20
	public string feedbackUrl; // 0x28

	// Methods

	// RVA: 0x64258A0 Offset: 0x64218A0 VA: 0x64258A0
	public void .ctor() { }
}

// Namespace: GorillaGM.Runtime
[Preserve]
[Serializable]
public class CloudRequest // TypeDefIndex: 28010
{
	// Fields
	[Preserve]
	public string accessToken; // 0x10
	[Preserve]
	public string userId; // 0x18
	[Preserve]
	public string serviceToken; // 0x20
	[Preserve]
	public ClientData clientData; // 0x28
	[JsonIgnore]
	[Preserve]
	public bool isMask; // 0x30
	[JsonIgnore]
	[Preserve]
	public string exParam; // 0x38

	// Methods

	// RVA: 0x64258A8 Offset: 0x64218A8 VA: 0x64258A8 Slot: 3
	public override string ToString() { }

	// RVA: 0x6425904 Offset: 0x6421904 VA: 0x6425904
	public void .ctor() { }
}

// Namespace: GorillaGM.Runtime
[Preserve]
[Serializable]
public class ClientData // TypeDefIndex: 28011
{
	// Fields
	[Preserve]
	public int channelId; // 0x10
	[Preserve]
	public string deviceId; // 0x18
	[Preserve]
	public string appVersion; // 0x20
	[Preserve]
	public string os; // 0x28
	[Preserve]
	public string osVersion; // 0x30
	[Preserve]
	public string appLanguage; // 0x38
	[Preserve]
	public string systemLanguage; // 0x40
	[Preserve]
	public string appBundle; // 0x48
	[Preserve]
	public string deviceModel; // 0x50
	[Preserve]
	public string envVersion; // 0x58

	// Methods

	// RVA: 0x642590C Offset: 0x642190C VA: 0x642590C
	public void .ctor() { }
}

// Namespace: GorillaGM.Runtime
[Preserve]
[Serializable]
public class MarkCloudAsReadRequest : CloudRequest // TypeDefIndex: 28012
{
	// Fields
	[Preserve]
	public List<string> mailIds; // 0x40

	// Methods

	// RVA: 0x6425914 Offset: 0x6421914 VA: 0x6425914
	public void .ctor() { }
}

// Namespace: GorillaGM.Runtime
[Preserve]
[Serializable]
public class DeleteCloudRequest : CloudRequest // TypeDefIndex: 28013
{
	// Fields
	[Preserve]
	public List<string> mailIds; // 0x40

	// Methods

	// RVA: 0x642591C Offset: 0x642191C VA: 0x642591C
	public void .ctor() { }
}

// Namespace: GorillaGM.Runtime
[Preserve]
[Serializable]
public class ReceiveCloudRequest : CloudRequest // TypeDefIndex: 28014
{
	// Fields
	[Preserve]
	public List<string> mailIds; // 0x40

	// Methods

	// RVA: 0x6425924 Offset: 0x6421924 VA: 0x6425924
	public void .ctor() { }
}

// Namespace: GorillaGM.Runtime
[Preserve]
[Serializable]
public class ReceiveGiftCodeRequest : CloudRequest // TypeDefIndex: 28015
{
	// Fields
	[Preserve]
	public string code; // 0x40

	// Methods

	// RVA: 0x642592C Offset: 0x642192C VA: 0x642592C
	public void .ctor() { }
}

// Namespace: GorillaGM.Runtime
[Preserve]
[Serializable]
public class ReceiveShareRewardRequest : CloudRequest // TypeDefIndex: 28016
{
	// Fields
	[Preserve]
	public string shareId; // 0x40

	// Methods

	// RVA: 0x6425934 Offset: 0x6421934 VA: 0x6425934
	public void .ctor() { }
}

// Namespace: GorillaGM.Runtime
[Preserve]
[Serializable]
public class FeedBackRequest : CloudRequest // TypeDefIndex: 28017
{
	// Fields
	[Preserve]
	public int type; // 0x40
	[Preserve]
	public string message; // 0x48
	[Preserve]
	public string email; // 0x50
	[Preserve]
	public int memorySize; // 0x58
	[Preserve]
	public string operatingSystem; // 0x60
	[Preserve]
	public string graphicsDeviceName; // 0x68
	[Preserve]
	public string nettyType; // 0x70
	[Preserve]
	public string packageName; // 0x78

	// Methods

	// RVA: 0x642593C Offset: 0x642193C VA: 0x642593C
	public void .ctor() { }
}

// Namespace: GorillaGM.Runtime
[Preserve]
[Serializable]
public class FeedbackGameRequest : CloudRequest // TypeDefIndex: 28018
{
	// Methods

	// RVA: 0x6425944 Offset: 0x6421944 VA: 0x6425944
	public void .ctor() { }
}

// Namespace: GorillaGM.Runtime
[Preserve]
[Serializable]
public class AnnouncementReadRequest : CloudRequest // TypeDefIndex: 28019
{
	// Fields
	[Preserve]
	public List<string> announcementIds; // 0x40

	// Methods

	// RVA: 0x642594C Offset: 0x642194C VA: 0x642594C
	public void .ctor() { }
}

// Namespace: GorillaGM.Runtime
[Preserve]
[Serializable]
internal class CloudResponse<T> // TypeDefIndex: 28020
{
	// Fields
	[Preserve]
	public int code; // 0x0
	[Preserve]
	public T data; // 0x0
	[Preserve]
	public bool success; // 0x0
	[Preserve]
	public string message; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BB8AA0 Offset: 0x5BB4AA0 VA: 0x5BB8AA0
	|-CloudResponse<object>..ctor
	|
	|-RVA: 0x5BB8AA8 Offset: 0x5BB4AA8 VA: 0x5BB8AA8
	|-CloudResponse<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: GorillaGM.Runtime
[Preserve]
[Serializable]
public class Mail // TypeDefIndex: 28021
{
	// Fields
	[Preserve]
	public bool claimed; // 0x10
	[Preserve]
	public string customJsonStr; // 0x18
	[Preserve]
	public long effectiveAt; // 0x20
	[Preserve]
	public long expireAt; // 0x28
	[Preserve]
	public string mailContent; // 0x30
	[Preserve]
	public string mailId; // 0x38
	[Preserve]
	public string mailTitle; // 0x40
	[Preserve]
	public object placeholderData; // 0x48
	[Preserve]
	public bool readed; // 0x50
	[Preserve]
	public List<RewardItem> rewards; // 0x58
	[Preserve]
	public string tempId; // 0x60

	// Methods

	// RVA: 0x6425954 Offset: 0x6421954 VA: 0x6425954
	public bool HasReward() { }

	// RVA: 0x64259A8 Offset: 0x64219A8 VA: 0x64259A8
	public void .ctor() { }
}

// Namespace: GorillaGM.Runtime
[Preserve]
[Serializable]
public class RewardItem // TypeDefIndex: 28022
{
	// Fields
	[Preserve]
	public long amount; // 0x10
	[Preserve]
	public int id; // 0x18
	[Preserve]
	public int type; // 0x1C

	// Methods

	// RVA: 0x64259B0 Offset: 0x64219B0 VA: 0x64259B0
	public void .ctor() { }
}

// Namespace: GorillaGM.Runtime
[Preserve]
[Serializable]
public class MailReceiveResponse // TypeDefIndex: 28023
{
	// Fields
	[Preserve]
	public string commonDataBase64String; // 0x10

	// Methods

	// RVA: 0x64259B8 Offset: 0x64219B8 VA: 0x64259B8
	public void .ctor() { }
}

// Namespace: GorillaGM.Runtime
[Preserve]
[Serializable]
public class GetAnnouncementListResponse // TypeDefIndex: 28024
{
	// Fields
	[Preserve]
	public List<AnnouncementObjectData> announcementList; // 0x10
	[Preserve]
	public List<AnnouncementBannerData> bannerList; // 0x18

	// Methods

	// RVA: 0x64259C0 Offset: 0x64219C0 VA: 0x64259C0
	public void .ctor() { }
}

// Namespace: GorillaGM.Runtime
[Preserve]
[Serializable]
public class AnnouncementObjectData // TypeDefIndex: 28025
{
	// Fields
	[Preserve]
	public string announcementId; // 0x10
	[Preserve]
	public string content; // 0x18
	[Preserve]
	public long effectiveAt; // 0x20
	[Preserve]
	public long expireAt; // 0x28
	[Preserve]
	public int rank; // 0x30
	[Preserve]
	public string title; // 0x38
	[Preserve]
	public bool read; // 0x40

	// Methods

	// RVA: 0x64259C8 Offset: 0x64219C8 VA: 0x64259C8
	public void .ctor() { }
}

// Namespace: GorillaGM.Runtime
[Preserve]
[Serializable]
public class AnnouncementBannerData // TypeDefIndex: 28026
{
	// Fields
	[Preserve]
	public string bannerTip; // 0x10
	[Preserve]
	public string imgUrl; // 0x18
	[Preserve]
	public int jumpType; // 0x20
	[Preserve]
	public string jumpValue; // 0x28
	[Preserve]
	public int rank; // 0x30

	// Methods

	// RVA: 0x64259D0 Offset: 0x64219D0 VA: 0x64259D0
	public void .ctor() { }
}

// Namespace: GorillaGM.Runtime
[Preserve]
[Serializable]
public class ShareResponse // TypeDefIndex: 28027
{
	// Fields
	[Preserve]
	public ShareData shareData; // 0x10

	// Methods

	// RVA: 0x64259D8 Offset: 0x64219D8 VA: 0x64259D8
	public void .ctor() { }
}

// Namespace: GorillaGM.Runtime
[Serializable]
public class ShareData // TypeDefIndex: 28028
{
	// Fields
	public string imgUrl; // 0x10
	public bool shared; // 0x18
	public string shareId; // 0x20
	public List<RewardItem> rewards; // 0x28
	public string weiboTopic; // 0x30

	// Methods

	// RVA: 0x64259E0 Offset: 0x64219E0 VA: 0x64259E0
	public void .ctor() { }
}

// Namespace: GorillaGM.Runtime
[Preserve]
[Serializable]
public class GameConfigResponse // TypeDefIndex: 28029
{
	// Fields
	[Preserve]
	public object cloudConfig; // 0x10
	[Preserve]
	public bool forceUpgrade; // 0x18
	[Preserve]
	public string forceUpgradeURL; // 0x20

	// Methods

	// RVA: 0x64259E8 Offset: 0x64219E8 VA: 0x64259E8
	public void .ctor() { }
}

// Namespace: 
[Preserve]
[Serializable]
public class AbTestResponse.Experiment // TypeDefIndex: 28030
{
	// Fields
	[Preserve]
	public string expName; // 0x10
	[Preserve]
	public string expId; // 0x18
	[Preserve]
	public string versionId; // 0x20
	[Preserve]
	public string versionName; // 0x28
	[Preserve]
	public string jsonStr; // 0x30

	// Methods

	// RVA: 0x64259F8 Offset: 0x64219F8 VA: 0x64259F8
	public void .ctor() { }
}

// Namespace: GorillaGM.Runtime
[Preserve]
[Serializable]
public class AbTestResponse // TypeDefIndex: 28031
{
	// Fields
	[Preserve]
	public AbTestResponse.Experiment[] experiments; // 0x10

	// Methods

	// RVA: 0x64259F0 Offset: 0x64219F0 VA: 0x64259F0
	public void .ctor() { }
}

// Namespace: GorillaGM.Runtime
[Preserve]
[Serializable]
public class FeedbackGameResponse // TypeDefIndex: 28032
{
	// Fields
	[Preserve]
	public bool notRead; // 0x10

	// Methods

	// RVA: 0x6425A00 Offset: 0x6421A00 VA: 0x6425A00
	public void .ctor() { }
}

// Namespace: GorillaGM.Runtime
public enum ErrorCode // TypeDefIndex: 28033
{
	// Fields
	public int value__; // 0x0
	public const ErrorCode Success = 0;
	public const ErrorCode GameServerInterfaceException = 20000;
	public const ErrorCode ParameterError = 20001;
	public const ErrorCode MailAlreadyReceived = 20002;
	public const ErrorCode GiftCodeAlreadyUsed = 20003;
	public const ErrorCode InvalidGiftCode = 20004;
	public const ErrorCode AllGiftCodesRedeemed = 20005;
	public const ErrorCode GiftCodeAlreadyRedeemedByYou = 20006;
	public const ErrorCode GiftCodeExpired = 20007;
	public const ErrorCode AlreadyShared = 20008;
	public const ErrorCode SystemException = -100;
	public const ErrorCode DatabaseException = -101;
	public const ErrorCode OperationTooFrequent = -102;
	public const ErrorCode SystemBusyRetryLater = -103;
}

// Namespace: 
[Preserve]
[Serializable]
private class GMService.MailList // TypeDefIndex: 28034
{
	// Fields
	[Preserve]
	public List<Mail> mailList; // 0x10

	// Methods

	// RVA: 0x6428A80 Offset: 0x6424A80 VA: 0x6428A80
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class GMService.<>c // TypeDefIndex: 28035
{
	// Fields
	public static readonly GMService.<>c <>9; // 0x0
	public static Comparison<AnnouncementBannerData> <>9__26_2; // 0x8

	// Methods

	// RVA: 0x6428A88 Offset: 0x6424A88 VA: 0x6428A88
	private static void .cctor() { }

	// RVA: 0x6428AF0 Offset: 0x6424AF0 VA: 0x6428AF0
	public void .ctor() { }

	// RVA: 0x6428AF8 Offset: 0x6424AF8 VA: 0x6428AF8
	internal int <GetAnnouncementList>b__26_2(AnnouncementBannerData a, AnnouncementBannerData b) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GMService.<>c__DisplayClass22_0 // TypeDefIndex: 28036
{
	// Fields
	public Action<List<Mail>> onSuccess; // 0x10
	public Action<int, string> onFailure; // 0x18
	public Action<GMService.MailList> <>9__1; // 0x20

	// Methods

	// RVA: 0x642637C Offset: 0x642237C VA: 0x642637C
	public void .ctor() { }

	// RVA: 0x6428B1C Offset: 0x6424B1C VA: 0x6428B1C
	internal void <GetMailList>b__0(string response) { }

	// RVA: 0x6428BD8 Offset: 0x6424BD8 VA: 0x6428BD8
	internal void <GetMailList>b__1(GMService.MailList mailList) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GMService.<>c__DisplayClass23_0 // TypeDefIndex: 28037
{
	// Fields
	public Action<MailReceiveResponse> onSuccess; // 0x10
	public Action<int, string> onFailure; // 0x18

	// Methods

	// RVA: 0x6426890 Offset: 0x6422890 VA: 0x6426890
	public void .ctor() { }

	// RVA: 0x6428CA0 Offset: 0x6424CA0 VA: 0x6428CA0
	internal void <ReceiveMail>b__0(string response) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GMService.<>c__DisplayClass24_0 // TypeDefIndex: 28038
{
	// Fields
	public Action onSuccess; // 0x10
	public Action<object> <>9__1; // 0x18

	// Methods

	// RVA: 0x6426A9C Offset: 0x6422A9C VA: 0x6426A9C
	public void .ctor() { }

	// RVA: 0x6428CF8 Offset: 0x6424CF8 VA: 0x6428CF8
	internal void <MarkMailAsRead>b__0(string response) { }

	// RVA: 0x6428DB4 Offset: 0x6424DB4 VA: 0x6428DB4
	internal void <MarkMailAsRead>b__1(object _) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GMService.<>c__DisplayClass25_0 // TypeDefIndex: 28039
{
	// Fields
	public Action onSuccess; // 0x10
	public Action<int, string> onFailure; // 0x18
	public Action<object> <>9__1; // 0x20

	// Methods

	// RVA: 0x6426CC0 Offset: 0x6422CC0 VA: 0x6426CC0
	public void .ctor() { }

	// RVA: 0x6428DD0 Offset: 0x6424DD0 VA: 0x6428DD0
	internal void <DeleteMail>b__0(string response) { }

	// RVA: 0x6428E8C Offset: 0x6424E8C VA: 0x6428E8C
	internal void <DeleteMail>b__1(object _) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GMService.<>c__DisplayClass26_0 // TypeDefIndex: 28040
{
	// Fields
	public Action<GetAnnouncementListResponse> onSuccess; // 0x10
	public Action<int, string> onFailure; // 0x18
	public Action<GetAnnouncementListResponse> <>9__1; // 0x20

	// Methods

	// RVA: 0x6426E8C Offset: 0x6422E8C VA: 0x6426E8C
	public void .ctor() { }

	// RVA: 0x6428EA8 Offset: 0x6424EA8 VA: 0x6428EA8
	internal void <GetAnnouncementList>b__0(string response) { }

	// RVA: 0x6428F64 Offset: 0x6424F64 VA: 0x6428F64
	internal void <GetAnnouncementList>b__1(GetAnnouncementListResponse data) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GMService.<>c__DisplayClass27_0 // TypeDefIndex: 28041
{
	// Fields
	public Action onSuccess; // 0x10
	public Action<int, string> onFailure; // 0x18
	public Action<object> <>9__1; // 0x20

	// Methods

	// RVA: 0x64270DC Offset: 0x64230DC VA: 0x64270DC
	public void .ctor() { }

	// RVA: 0x64290A4 Offset: 0x64250A4 VA: 0x64290A4
	internal void <AnnouncementRead>b__0(string response) { }

	// RVA: 0x6429160 Offset: 0x6425160 VA: 0x6429160
	internal void <AnnouncementRead>b__1(object _) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GMService.<>c__DisplayClass28_0 // TypeDefIndex: 28042
{
	// Fields
	public Action onSuccess; // 0x10
	public Action<object> <>9__1; // 0x18

	// Methods

	// RVA: 0x64272EC Offset: 0x64232EC VA: 0x64272EC
	public void .ctor() { }

	// RVA: 0x642917C Offset: 0x642517C VA: 0x642917C
	internal void <ReceiveGiftCode>b__0(string response) { }

	// RVA: 0x6429238 Offset: 0x6425238 VA: 0x6429238
	internal void <ReceiveGiftCode>b__1(object _) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GMService.<>c__DisplayClass29_0 // TypeDefIndex: 28043
{
	// Fields
	public Action<ShareResponse> onSuccess; // 0x10
	public Action<int, string> onFailure; // 0x18

	// Methods

	// RVA: 0x6427418 Offset: 0x6423418 VA: 0x6427418
	public void .ctor() { }

	// RVA: 0x6429254 Offset: 0x6425254 VA: 0x6429254
	internal void <GetShareData>b__0(string response) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GMService.<>c__DisplayClass30_0 // TypeDefIndex: 28044
{
	// Fields
	public Action onSuccess; // 0x10
	public Action<int, string> onFailure; // 0x18
	public Action<object> <>9__1; // 0x20

	// Methods

	// RVA: 0x64275EC Offset: 0x64235EC VA: 0x64275EC
	public void .ctor() { }

	// RVA: 0x64292AC Offset: 0x64252AC VA: 0x64292AC
	internal void <ReceiveShareReward>b__0(string response) { }

	// RVA: 0x6429368 Offset: 0x6425368 VA: 0x6429368
	internal void <ReceiveShareReward>b__1(object result) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GMService.<>c__DisplayClass31_0 // TypeDefIndex: 28045
{
	// Fields
	public Action<Dictionary<string, object>> onSuccess; // 0x10
	public Action<int, string> onFailure; // 0x18

	// Methods

	// RVA: 0x6427798 Offset: 0x6423798 VA: 0x6427798
	public void .ctor() { }

	// RVA: 0x6429384 Offset: 0x6425384 VA: 0x6429384
	internal void <GetAnonymousGameConfig>b__0(string response) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GMService.<>c__DisplayClass32_0 // TypeDefIndex: 28046
{
	// Fields
	public Action<GameConfigResponse> onSuccess; // 0x10
	public Action<int, string> onFailure; // 0x18

	// Methods

	// RVA: 0x64278C4 Offset: 0x64238C4 VA: 0x64278C4
	public void .ctor() { }

	// RVA: 0x64293DC Offset: 0x64253DC VA: 0x64293DC
	internal void <GetGameConfig>b__0(string response) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GMService.<>c__DisplayClass34_0 // TypeDefIndex: 28047
{
	// Fields
	public Action onSuccess; // 0x10
	public Action<int, string> onFailure; // 0x18
	public Action<object> <>9__1; // 0x20

	// Methods

	// RVA: 0x6427C80 Offset: 0x6423C80 VA: 0x6427C80
	public void .ctor() { }

	// RVA: 0x6429434 Offset: 0x6425434 VA: 0x6429434
	internal void <FeedBack>b__0(string response) { }

	// RVA: 0x64294F0 Offset: 0x64254F0 VA: 0x64294F0
	internal void <FeedBack>b__1(object _) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GMService.<>c__DisplayClass35_0 // TypeDefIndex: 28048
{
	// Fields
	public Action<FeedbackGameResponse> onSuccess; // 0x10
	public Action<int, string> onFailure; // 0x18

	// Methods

	// RVA: 0x6427E30 Offset: 0x6423E30 VA: 0x6427E30
	public void .ctor() { }

	// RVA: 0x642950C Offset: 0x642550C VA: 0x642950C
	internal void <FeedbackGame>b__0(string response) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GMService.<>c__DisplayClass36_0 // TypeDefIndex: 28049
{
	// Fields
	public UniWebView webView; // 0x10
	public GameObject obj; // 0x18

	// Methods

	// RVA: 0x6428500 Offset: 0x6424500 VA: 0x6428500
	public void .ctor() { }

	// RVA: 0x6429564 Offset: 0x6425564 VA: 0x6429564
	internal bool <OpenFeedbackWebView>b__0(UniWebView view) { }

	// RVA: 0x6429634 Offset: 0x6425634 VA: 0x6429634
	internal void <OpenFeedbackWebView>b__1(UniWebView view, UniWebViewMessage message) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GMService.<>c__DisplayClass42_0 // TypeDefIndex: 28050
{
	// Fields
	public GorillaGMManager manager; // 0x10
	public CloudRequest request; // 0x18
	public Action<string> onSuccess; // 0x20
	public Action<int, string> onFailure; // 0x28

	// Methods

	// RVA: 0x64288C8 Offset: 0x64248C8 VA: 0x64288C8
	public void .ctor() { }

	// RVA: 0x642975C Offset: 0x642575C VA: 0x642975C
	internal void <SendPost>b__0() { }

	// RVA: 0x64297B0 Offset: 0x64257B0 VA: 0x64297B0
	internal void <SendPost>b__1(string response) { }

	// RVA: 0x6429834 Offset: 0x6425834 VA: 0x6429834
	internal void <SendPost>b__2(int code, string message) { }
}

// Namespace: GorillaGM.Runtime
internal class GMService : IGMService, IMailService, IAnnouncementService, IGiftCodeService, IShareService, IGameConfig, IFeedBack // TypeDefIndex: 28051
{
	// Fields
	private const string Tag = "[GorillaGM] [CloudService]";
	private const string MailListPath = "/api/mail/list";
	private const string MailReadPath = "/api/mail/read";
	private const string MailDeletePath = "/api/mail/delete";
	private const string MailReceivePath = "/api/mail/receive";
	private const string AnnouncementListPath = "/api/announcement/list";
	private const string AnnouncementReadPath = "/api/announcement/read";
	private const int AnnouncementRequestTimeoutSeconds = 20;
	private const string GiftCodeReceivePath = "/api/giftcode/receive";
	private const string ShareListPath = "/api/share/list";
	private const string DoSharePath = "/api/share/doShare";
	private const string AnonymousGameConfigPath = "/api/gameconfig-anonymous/list";
	private const string GetGameConfigPath = "/api/gameconfig/list";
	private const string FeedBackPath = "/api/feedback";
	private const string FeedBackGamePath = "/api/feedback/game";
	private CloudConfig _cloudConfig; // 0x10
	private CloudRequest _cloudRequest; // 0x18
	private bool _isInitialized; // 0x20
	private bool _isLoggedIn; // 0x21

	// Properties
	private static int ChannelId { get; }
	private static string Os { get; }
	private static string LanguageType { get; }

	// Methods

	// RVA: 0x6425A08 Offset: 0x6421A08 VA: 0x6425A08 Slot: 4
	public void Init(CloudConfig config) { }

	// RVA: 0x6426080 Offset: 0x6422080 VA: 0x6426080 Slot: 5
	public void OnLogin(string userId, string accessToken) { }

	// RVA: 0x6426198 Offset: 0x6422198 VA: 0x6426198 Slot: 6
	public void OnAppLanguageChanged(string language) { }

	// RVA: 0x6426254 Offset: 0x6422254 VA: 0x6426254 Slot: 7
	public CloudRequest GetMailList(Action<List<Mail>> onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x6426674 Offset: 0x6422674 VA: 0x6426674 Slot: 8
	public CloudRequest ReceiveMail(List<string> mailIds, Action<MailReceiveResponse> onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x6426898 Offset: 0x6422898 VA: 0x6426898 Slot: 9
	public CloudRequest MarkMailAsRead(List<string> mailIds, Action onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x6426AA4 Offset: 0x6422AA4 VA: 0x6426AA4 Slot: 10
	public CloudRequest DeleteMail(List<string> mailIds, Action onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x6426CC8 Offset: 0x6422CC8 VA: 0x6426CC8 Slot: 11
	public void GetAnnouncementList(Action<GetAnnouncementListResponse> onSuccess, Action<int, string> onFailure, bool isMask = True) { }

	// RVA: 0x6426F04 Offset: 0x6422F04 VA: 0x6426F04 Slot: 12
	public void AnnouncementRead(List<string> announcementIds, Action onSuccess, Action<int, string> onFailure, bool isMask = True) { }

	// RVA: 0x64270E4 Offset: 0x64230E4 VA: 0x64270E4 Slot: 13
	public void ReceiveGiftCode(string code, Action onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x64272F4 Offset: 0x64232F4 VA: 0x64272F4 Slot: 14
	public void GetShareData(Action<ShareResponse> onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x6427420 Offset: 0x6423420 VA: 0x6427420 Slot: 15
	public void ReceiveShareReward(string shareId, Action onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x64275F4 Offset: 0x64235F4 VA: 0x64275F4 Slot: 16
	public void GetAnonymousGameConfig(Action<Dictionary<string, object>> onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x64277A0 Offset: 0x64237A0 VA: 0x64277A0 Slot: 17
	public void GetGameConfig(Action<GameConfigResponse> onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x64278CC Offset: 0x64238CC VA: 0x64278CC Slot: 18
	public void GetAbTest(Action<AbTestResponse> onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x6427930 Offset: 0x6423930 VA: 0x6427930 Slot: 19
	public void FeedBack(int type, string message, string email, Action onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x6427C88 Offset: 0x6423C88 VA: 0x6427C88 Slot: 20
	public void FeedbackGame(Action<FeedbackGameResponse> onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x6427E38 Offset: 0x6423E38 VA: 0x6427E38 Slot: 21
	public void OpenFeedbackWebView() { }

	// RVA: 0x64285EC Offset: 0x64245EC VA: 0x64285EC
	private static void CreateFullScreenBlackBackground(Transform parent) { }

	// RVA: 0x6428508 Offset: 0x6424508 VA: 0x6428508
	private static string GetOSShortName() { }

	// RVA: 0x6426E94 Offset: 0x6422E94 VA: 0x6426E94
	private bool ValidateInitializedState(Action<int, string> onFailure) { }

	// RVA: 0x6426384 Offset: 0x6422384 VA: 0x6426384
	private bool ValidateState(Action<int, string> onFailure) { }

	// RVA: -1 Offset: -1
	private static void HandleResponse<T>(string response, Action<T> onSuccess, Action<int, string> onFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462C100 Offset: 0x4628100 VA: 0x462C100
	|-GMService.HandleResponse<object>
	|
	|-RVA: 0x462C344 Offset: 0x4628344 VA: 0x462C344
	|-GMService.HandleResponse<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x6426408 Offset: 0x6422408 VA: 0x6426408
	private CloudRequest SendPost(CloudRequest request, string path, Action<string> onSuccess, Action<int, string> onFailure, int timeoutSeconds = 0) { }

	// RVA: 0x6425E44 Offset: 0x6421E44 VA: 0x6425E44
	private static int get_ChannelId() { }

	// RVA: 0x6425E4C Offset: 0x6421E4C VA: 0x6425E4C
	private static string get_Os() { }

	// RVA: 0x6425F18 Offset: 0x6421F18 VA: 0x6425F18
	private static string get_LanguageType() { }

	// RVA: 0x6428A78 Offset: 0x6424A78 VA: 0x6428A78
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GorillaGMManager.<>c__DisplayClass24_0 // TypeDefIndex: 28052
{
	// Fields
	public GorillaGMManager <>4__this; // 0x10
	public Action<MailReceiveResponse> onSuccess; // 0x18

	// Methods

	// RVA: 0x6429DB0 Offset: 0x6425DB0 VA: 0x6429DB0
	public void .ctor() { }

	// RVA: 0x642A820 Offset: 0x6426820 VA: 0x642A820
	internal void <ReceiveMail>b__0(MailReceiveResponse result) { }
}

// Namespace: GorillaGM.Runtime
public class GorillaGMManager // TypeDefIndex: 28053
{
	// Fields
	private static GorillaGMManager _instance; // 0x0
	private IGMService _impl; // 0x10
	[CompilerGenerated]
	private Action<string> <CommonDataHandler>k__BackingField; // 0x18
	[CompilerGenerated]
	private Action<CloudRequest> <RequestStarted>k__BackingField; // 0x20
	[CompilerGenerated]
	private Action<CloudRequest> <RequestFinished>k__BackingField; // 0x28

	// Properties
	public static GorillaGMManager Instance { get; }
	public Action<string> CommonDataHandler { get; set; }
	public Action<CloudRequest> RequestStarted { get; set; }
	public Action<CloudRequest> RequestFinished { get; set; }

	// Methods

	// RVA: 0x64288D0 Offset: 0x64248D0 VA: 0x64288D0
	public static GorillaGMManager get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x6429910 Offset: 0x6425910 VA: 0x6429910
	public Action<string> get_CommonDataHandler() { }

	[CompilerGenerated]
	// RVA: 0x6429918 Offset: 0x6425918 VA: 0x6429918
	public void set_CommonDataHandler(Action<string> value) { }

	[CompilerGenerated]
	// RVA: 0x6429920 Offset: 0x6425920 VA: 0x6429920
	public Action<CloudRequest> get_RequestStarted() { }

	[CompilerGenerated]
	// RVA: 0x6429928 Offset: 0x6425928 VA: 0x6429928
	public void set_RequestStarted(Action<CloudRequest> value) { }

	[CompilerGenerated]
	// RVA: 0x6429930 Offset: 0x6425930 VA: 0x6429930
	public Action<CloudRequest> get_RequestFinished() { }

	[CompilerGenerated]
	// RVA: 0x6429938 Offset: 0x6425938 VA: 0x6429938
	public void set_RequestFinished(Action<CloudRequest> value) { }

	// RVA: 0x64298A4 Offset: 0x64258A4 VA: 0x64298A4
	private void .ctor() { }

	// RVA: 0x6429940 Offset: 0x6425940 VA: 0x6429940
	public void SetImplementation(IGMService impl) { }

	// RVA: 0x6429948 Offset: 0x6425948 VA: 0x6429948
	public void Init(CloudConfig config) { }

	// RVA: 0x64299F8 Offset: 0x64259F8 VA: 0x64299F8
	public void OnLogin(string userId, string accessToken) { }

	// RVA: 0x6429AC0 Offset: 0x6425AC0 VA: 0x6429AC0
	public void OnAppLanguageChanged(string language) { }

	// RVA: 0x6429794 Offset: 0x6425794 VA: 0x6429794
	internal void NotifyRequestStarted(CloudRequest request) { }

	// RVA: 0x6429818 Offset: 0x6425818 VA: 0x6429818
	internal void NotifyRequestFinished(CloudRequest request) { }

	// RVA: 0x6429B74 Offset: 0x6425B74 VA: 0x6429B74
	public CloudRequest GetMailList(Action<List<Mail>> onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x6429C3C Offset: 0x6425C3C VA: 0x6429C3C
	public CloudRequest ReceiveMail(List<string> mailIds, Action<MailReceiveResponse> onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x6429DB8 Offset: 0x6425DB8 VA: 0x6429DB8
	public CloudRequest MarkMailAsRead(List<string> mailIds, Action onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x6429E8C Offset: 0x6425E8C VA: 0x6429E8C
	public CloudRequest DeleteMail(List<string> mailIds, Action onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x6429F60 Offset: 0x6425F60 VA: 0x6429F60
	public void GetAnnouncementList(Action<GetAnnouncementListResponse> onSuccess, Action<int, string> onFailure, bool isMask = True) { }

	// RVA: 0x642A02C Offset: 0x642602C VA: 0x642A02C
	public void AnnouncementRead(List<string> announcementIds, Action onSuccess, Action<int, string> onFailure, bool isMask = True) { }

	// RVA: 0x642A110 Offset: 0x6426110 VA: 0x642A110
	public void ReceiveGiftCode(string code, Action onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x642A1DC Offset: 0x64261DC VA: 0x642A1DC
	public void GetShareData(Action<ShareResponse> onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x642A2A0 Offset: 0x64262A0 VA: 0x642A2A0
	public void ReceiveShareReward(string shareId, Action onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x642A370 Offset: 0x6426370 VA: 0x642A370
	public void GetAnonymousGameConfig(Action<Dictionary<string, object>> onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x642A434 Offset: 0x6426434 VA: 0x642A434
	public void GetGameConfig(Action<GameConfigResponse> onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x642A4FC Offset: 0x64264FC VA: 0x642A4FC
	public void GetAbTest(Action<AbTestResponse> onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x642A5C4 Offset: 0x64265C4 VA: 0x642A5C4
	public void FeedBack(int type, string message, string email, Action onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x642A6AC Offset: 0x64266AC VA: 0x642A6AC
	public void FeedbackGame(Action<FeedbackGameResponse> onSuccess, Action<int, string> onFailure) { }

	// RVA: 0x642A774 Offset: 0x6426774 VA: 0x642A774
	public void OpenFeedbackWebView() { }
}

// Namespace: 
private class HttpService.AcceptAllCertificates : CertificateHandler // TypeDefIndex: 28054
{
	// Methods

	// RVA: 0x642B454 Offset: 0x6427454 VA: 0x642B454 Slot: 5
	protected override bool ValidateCertificate(byte[] certificateData) { }

	// RVA: 0x642AD9C Offset: 0x6426D9C VA: 0x642AD9C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class HttpService.<>c // TypeDefIndex: 28055
{
	// Fields
	public static readonly HttpService.<>c <>9; // 0x0
	public static Func<KeyValuePair<string, string>, bool> <>9__4_0; // 0x8

	// Methods

	// RVA: 0x642B45C Offset: 0x642745C VA: 0x642B45C
	private static void .cctor() { }

	// RVA: 0x642B4C4 Offset: 0x64274C4 VA: 0x642B4C4
	public void .ctor() { }

	// RVA: 0x642B4CC Offset: 0x64274CC VA: 0x642B4CC
	internal bool <LogAsCurlCommand>b__4_0(KeyValuePair<string, string> h) { }
}

// Namespace: 
[CompilerGenerated]
private struct HttpService.<SendPost>d__1 : IAsyncStateMachine // TypeDefIndex: 28056
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public Action onStart; // 0x28
	public string url; // 0x30
	public string body; // 0x38
	public int timeoutSeconds; // 0x40
	public Action<string> onSuccess; // 0x48
	public Action<int, string> onFailure; // 0x50
	private YieldAwaitable.YieldAwaiter <>u__1; // 0x58
	[TupleElementNames(new[] { "success", "text", "responseCode" })]
	private TaskAwaiter<ValueTuple<bool, string, long>> <>u__2; // 0x60

	// Methods

	// RVA: 0x642B518 Offset: 0x6427518 VA: 0x642B518 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x642B9A8 Offset: 0x64279A8 VA: 0x642B9A8 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct HttpService.<SendPostAsync>d__2 : IAsyncStateMachine // TypeDefIndex: 28057
{
	// Fields
	public int <>1__state; // 0x0
	[TupleElementNames(new[] { "success", "text", "responseCode" })]
	public AsyncTaskMethodBuilder<ValueTuple<bool, string, long>> <>t__builder; // 0x8
	public string url; // 0x20
	public string json; // 0x28
	public int timeoutSeconds; // 0x30
	private UnityWebRequest <webRequest>5__2; // 0x38
	private UnityWebRequestAsyncOperation <operation>5__3; // 0x40
	private YieldAwaitable.YieldAwaiter <>u__1; // 0x48

	// Methods

	// RVA: 0x642B9B4 Offset: 0x64279B4 VA: 0x642B9B4 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x642C078 Offset: 0x6428078 VA: 0x642C078 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: GorillaGM.Runtime
internal static class HttpService // TypeDefIndex: 28058
{
	// Fields
	private const string Tag = "[GorillaGM] [HttpService]";

	// Methods

	[AsyncStateMachine(typeof(HttpService.<SendPost>d__1))]
	// RVA: 0x6428948 Offset: 0x6424948 VA: 0x6428948
	public static void SendPost(string url, string body, Action onStart, Action<string> onSuccess, Action<int, string> onFailure, int timeoutSeconds = 0) { }

	[AsyncStateMachine(typeof(HttpService.<SendPostAsync>d__2))]
	// RVA: 0x642A930 Offset: 0x6426930 VA: 0x642A930
	private static Task<ValueTuple<bool, string, long>> SendPostAsync(string url, string json, int timeoutSeconds) { }

	// RVA: 0x642AA54 Offset: 0x6426A54 VA: 0x642AA54
	private static UnityWebRequest BuildWebRequest(string url, string json, int timeoutSeconds) { }

	// RVA: 0x642ADA4 Offset: 0x6426DA4 VA: 0x642ADA4
	private static void LogAsCurlCommand(string url, string body, Dictionary<string, string> headers) { }
}

// Namespace: GorillaGM.Runtime
public interface IGMService : IMailService, IAnnouncementService, IGiftCodeService, IShareService, IGameConfig, IFeedBack // TypeDefIndex: 28059
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Init(CloudConfig config);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnLogin(string userId, string accessToken);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnAppLanguageChanged(string language);
}

// Namespace: GorillaGM.Runtime
public interface IMailService // TypeDefIndex: 28060
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract CloudRequest GetMailList(Action<List<Mail>> onSuccess, Action<int, string> onFailure);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract CloudRequest ReceiveMail(List<string> mailIds, Action<MailReceiveResponse> onSuccess, Action<int, string> onFailure);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract CloudRequest MarkMailAsRead(List<string> mailIds, Action onSuccess, Action<int, string> onFailure);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract CloudRequest DeleteMail(List<string> mailIds, Action onSuccess, Action<int, string> onFailure);
}

// Namespace: GorillaGM.Runtime
public interface IAnnouncementService // TypeDefIndex: 28061
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GetAnnouncementList(Action<GetAnnouncementListResponse> onSuccess, Action<int, string> onFailure, bool isMask = True);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void AnnouncementRead(List<string> announcementIds, Action onSuccess, Action<int, string> onFailure, bool isMask = True);
}

// Namespace: GorillaGM.Runtime
public interface IGiftCodeService // TypeDefIndex: 28062
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ReceiveGiftCode(string code, Action onSuccess, Action<int, string> onFailure);
}

// Namespace: GorillaGM.Runtime
public interface IShareService // TypeDefIndex: 28063
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GetShareData(Action<ShareResponse> onSuccess, Action<int, string> onFailure);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ReceiveShareReward(string shareId, Action onSuccess, Action<int, string> onFailure);
}

// Namespace: GorillaGM.Runtime
public interface IGameConfig // TypeDefIndex: 28064
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GetAnonymousGameConfig(Action<Dictionary<string, object>> onSuccess, Action<int, string> onFailure);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void GetGameConfig(Action<GameConfigResponse> onSuccess, Action<int, string> onFailure);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void GetAbTest(Action<AbTestResponse> onSuccess, Action<int, string> onFailure);
}

// Namespace: GorillaGM.Runtime
public interface IFeedBack // TypeDefIndex: 28065
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void FeedBack(int type, string message, string email, Action onSuccess, Action<int, string> onFailure);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void FeedbackGame(Action<FeedbackGameResponse> onSuccess, Action<int, string> onFailure);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OpenFeedbackWebView();
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=469 // TypeDefIndex: 28066
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1444 // TypeDefIndex: 28067
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 28068
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1444 69E8DA2CE6CB97D93B87BA1167F221A5C6351218D53AD4A58D1A38738F5BB42A /*Metadata offset 0xF51588*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=469 B02A1E2004D4F60909069E25361E8CC25C889236BC1EA6AF7468CC59A5CC528E /*Metadata offset 0xF51B30*/; // 0x5A4
}

