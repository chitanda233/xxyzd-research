// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 27692
{}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 27693
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
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 27694
{
	// Methods

	// RVA: 0x648D33C Offset: 0x648933C VA: 0x648D33C
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x648D434 Offset: 0x6489434 VA: 0x648D434
	public void .ctor() { }
}

// Namespace: GorillaPurchase.Runtime
internal class EventData // TypeDefIndex: 27695
{
	// Fields
	private string _userId; // 0x10
	private string _preOrderId; // 0x18
	private int _purchaseId; // 0x20
	private int _goodsId; // 0x24
	private Dictionary<string, string> _extraData; // 0x28
	private string _cpOrderId; // 0x30
	private string _productId; // 0x38
	private Decimal _localPrice; // 0x40
	private string _currency; // 0x50
	private string _transactionId; // 0x58
	private string _receipt; // 0x60
	private Nullable<int> _errorCode; // 0x68
	private string _errorMessage; // 0x70

	// Properties
	private static string AccountId { get; }

	// Methods

	// RVA: 0x648D43C Offset: 0x648943C VA: 0x648D43C
	private static string get_AccountId() { }

	// RVA: 0x648D444 Offset: 0x6489444 VA: 0x648D444
	public EventData SetData(string userId, string productId, int purchaseId) { }

	// RVA: 0x648D450 Offset: 0x6489450 VA: 0x648D450
	public EventData SetData(string userId, string productId, int purchaseId, int goodsId, Dictionary<string, string> extraData) { }

	// RVA: 0x648D554 Offset: 0x6489554 VA: 0x648D554
	public EventData SetPreOrderData(string preOrderId, string cpOrderId) { }

	// RVA: 0x648D58C Offset: 0x648958C VA: 0x648D58C
	public EventData SetError(int code, string message) { }

	// RVA: 0x648D634 Offset: 0x6489634 VA: 0x648D634
	public EventData SetSuccess(string transactionId, string receipt) { }

	// RVA: 0x648D680 Offset: 0x6489680 VA: 0x648D680
	public EventData SetProduct(Product product) { }

	// RVA: 0x648D6C4 Offset: 0x64896C4 VA: 0x648D6C4
	public PurchaseFlowEvent ToFlowEvent(PurchaseFlowStage stage, PurchaseFlowStatus status, bool isRecoveredOrder = False) { }

	// RVA: 0x648D87C Offset: 0x648987C VA: 0x648D87C
	public Dictionary<string, object> ToProperties() { }

	// RVA: 0x648D4B8 Offset: 0x64894B8 VA: 0x648D4B8
	private static Dictionary<string, string> CloneExtraData(Dictionary<string, string> extraData) { }

	// RVA: 0x648DD84 Offset: 0x6489D84 VA: 0x648DD84
	public void .ctor() { }
}

// Namespace: 
private static class EventTracker.Key // TypeDefIndex: 27696
{
	// Fields
	public const string RetryTimes = "retry_times";
	public const string FailReason = "fail_reason";
	public const string Result = "result";
	public const string Success = "success";
	public const string Fail = "fail";
	public const string Cancel = "cancel";
}

// Namespace: 
private static class EventTracker.EventName // TypeDefIndex: 27697
{
	// Fields
	public const string IAPInitState = "iap_init_state";
	public const string IAPPreOrderStart = "iap_preOrder_request";
	public const string IAPPreOrderFinish = "iap_preOrder_response";
	public const string IAPLaunchPurchase = "iap_launch_purchase";
	public const string IAPChannelCallback = "iap_channel_callback";
	public const string IAPVerifyReceiptStart = "iap_verify_receipt_request";
	public const string IAPVerifyReceiptFinish = "iap_verify_receipt_response";
}

// Namespace: GorillaPurchase.Runtime
internal static class EventTracker // TypeDefIndex: 27698
{
	// Fields
	public static Action<string, Dictionary<string, object>> eventTracker; // 0x0

	// Methods

	// RVA: 0x648DE0C Offset: 0x6489E0C VA: 0x648DE0C
	public static void OnInitSuccess() { }

	// RVA: 0x648DFF0 Offset: 0x6489FF0 VA: 0x648DFF0
	public static void OnInitFailure(int retryCount, string message) { }

	// RVA: 0x648DE5C Offset: 0x6489E5C VA: 0x648DE5C
	private static void TrackIAPInitState(bool isSuccess, int retryTimes, string failReason) { }

	// RVA: 0x648E204 Offset: 0x648A204 VA: 0x648E204
	public static void OnPreOrderRequestStart(EventData eventData) { }

	// RVA: 0x648E26C Offset: 0x648A26C VA: 0x648E26C
	public static void OnRequestPreOrderSuccess(EventData eventData) { }

	// RVA: 0x648E324 Offset: 0x648A324 VA: 0x648E324
	public static void OnRequestPreOrderFailure(EventData eventData) { }

	// RVA: 0x648E3DC Offset: 0x648A3DC VA: 0x648E3DC
	public static void OnLaunchPurchaseFlow(EventData eventData) { }

	// RVA: 0x648E444 Offset: 0x648A444 VA: 0x648E444
	public static void OnPurchaseSuccess(EventData eventData) { }

	// RVA: 0x648E4FC Offset: 0x648A4FC VA: 0x648E4FC
	public static void OnPurchaseFailure(EventData eventData) { }

	// RVA: 0x648E5B4 Offset: 0x648A5B4 VA: 0x648E5B4
	public static void OnVerifyPurchaseStart(EventData eventData) { }

	// RVA: 0x648E61C Offset: 0x648A61C VA: 0x648E61C
	public static void OnPurchaseCancelled(EventData eventData) { }

	// RVA: 0x648E6D4 Offset: 0x648A6D4 VA: 0x648E6D4
	public static void OnVerifyPurchaseSuccess(EventData eventData) { }

	// RVA: 0x648E78C Offset: 0x648A78C VA: 0x648E78C
	public static void OnVerifyPurchaseFailure(EventData eventData) { }

	// RVA: 0x648E000 Offset: 0x648A000 VA: 0x648E000
	private static void TryToTrack(string eventName, Dictionary<string, object> properties) { }
}

// Namespace: GorillaPurchase.Runtime
public interface IPurchaseService // TypeDefIndex: 27699
{
	// Properties
	public abstract IPurchaseNetworkService NetworkService { get; set; }
	public abstract IPurchaseUIDelegate UIDelegate { get; set; }
	public abstract Action<string, Dictionary<string, object>> PurchaseEventTracker { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IPurchaseNetworkService get_NetworkService();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_NetworkService(IPurchaseNetworkService value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IPurchaseUIDelegate get_UIDelegate();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_UIDelegate(IPurchaseUIDelegate value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Action<string, Dictionary<string, object>> get_PurchaseEventTracker();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_PurchaseEventTracker(Action<string, Dictionary<string, object>> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 6
	public abstract void add_OnPurchaseFlowEvent(Action<PurchaseFlowEvent> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 7
	public abstract void remove_OnPurchaseFlowEvent(Action<PurchaseFlowEvent> value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Initialize();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void DeInitialize();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool GetProduct(string productId, out Product product);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void Purchase(PurchaseData data, Action<NativePurchaseResult> onSuccess, Action<int, string> onFailure, Action onCancel);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void RestoreTransactions(Action<bool, string> callback);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void FetchUnfinishedOrder();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void BeginRefundRequest(string transactionID, Action<bool> callback);
}

// Namespace: GorillaPurchase.Runtime
public interface IPurchaseUIDelegate // TypeDefIndex: 27700
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ShowProgress();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void HideProgress();
}

// Namespace: GorillaPurchase.Runtime
public interface IPurchaseNetworkService // TypeDefIndex: 27701
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SendPreOrderRequest(PurchaseData data, Product product, Action<PreOrderResponseData> onSuccess, Action<int, string> onFailure);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SendVerifyOrderRequest(VerifyOrderData data, Action<VerifyOrderResult> callback);
}

// Namespace: GorillaPurchase.Runtime
public enum PurchaseFlowStage // TypeDefIndex: 27702
{
	// Fields
	public int value__; // 0x0
	public const PurchaseFlowStage PreOrder = 0;
	public const PurchaseFlowStage Channel = 1;
	public const PurchaseFlowStage Verify = 2;
}

// Namespace: GorillaPurchase.Runtime
public enum PurchaseFlowStatus // TypeDefIndex: 27703
{
	// Fields
	public int value__; // 0x0
	public const PurchaseFlowStatus Started = 0;
	public const PurchaseFlowStatus Succeeded = 1;
	public const PurchaseFlowStatus Failed = 2;
	public const PurchaseFlowStatus Cancelled = 3;
	public const PurchaseFlowStatus Deferred = 4;
}

// Namespace: GorillaPurchase.Runtime
[Preserve]
[Serializable]
public class PurchaseFlowEvent // TypeDefIndex: 27704
{
	// Fields
	[Preserve]
	public PurchaseFlowStage stage; // 0x10
	[Preserve]
	public PurchaseFlowStatus status; // 0x14
	[Preserve]
	public string userId; // 0x18
	[Preserve]
	public string productId; // 0x20
	[Preserve]
	public int purchaseId; // 0x28
	[Preserve]
	public int goodsId; // 0x2C
	[Preserve]
	public string preOrderId; // 0x30
	[Preserve]
	public string cpOrderId; // 0x38
	[Preserve]
	public string transactionId; // 0x40
	[Preserve]
	public Decimal localizedPrice; // 0x48
	[Preserve]
	public string currencyCode; // 0x58
	[Preserve]
	public int errorCode; // 0x60
	[Preserve]
	public string errorMessage; // 0x68
	[Preserve]
	public bool isRecoveredOrder; // 0x70
	[Preserve]
	public Dictionary<string, string> extraData; // 0x78

	// Methods

	// RVA: 0x648E844 Offset: 0x648A844 VA: 0x648E844 Slot: 3
	public override string ToString() { }

	// RVA: 0x648D7F4 Offset: 0x64897F4 VA: 0x648D7F4
	public void .ctor() { }
}

// Namespace: GorillaPurchase.Runtime
[Preserve]
[Serializable]
public class NativePurchaseResult // TypeDefIndex: 27705
{
	// Fields
	[Preserve]
	public string preOrderId; // 0x10
	[Preserve]
	public string productId; // 0x18
	[Preserve]
	public string transactionId; // 0x20
	[Preserve]
	public string receipt; // 0x28
	[Preserve]
	public object verifyOrderData; // 0x30

	// Methods

	// RVA: 0x648EB9C Offset: 0x648AB9C VA: 0x648EB9C Slot: 3
	public override string ToString() { }

	// RVA: 0x648ED48 Offset: 0x648AD48 VA: 0x648ED48
	public void .ctor() { }
}

// Namespace: GorillaPurchase.Runtime
[Preserve]
[Serializable]
public class PreOrderResponseData // TypeDefIndex: 27706
{
	// Fields
	[Preserve]
	public string preOrderId; // 0x10
	[Preserve]
	public string cpOrderId; // 0x18

	// Methods

	// RVA: 0x648ED50 Offset: 0x648AD50 VA: 0x648ED50
	public void .ctor() { }
}

// Namespace: GorillaPurchase.Runtime
[Preserve]
[Serializable]
public class VerifyOrderData // TypeDefIndex: 27707
{
	// Fields
	[Preserve]
	public string preOrderId; // 0x10
	[Preserve]
	public string receipt; // 0x18
	[Preserve]
	public string transactionId; // 0x20
	[Preserve]
	public string productId; // 0x28
	[Preserve]
	public string productName; // 0x30
	[Preserve]
	public string productDescription; // 0x38
	[Preserve]
	public Decimal localizedPrice; // 0x40
	[Preserve]
	public string currencyCode; // 0x50
	[Preserve]
	public int orderType; // 0x58

	// Methods

	// RVA: 0x648ED58 Offset: 0x648AD58 VA: 0x648ED58
	public void .ctor() { }
}

// Namespace: GorillaPurchase.Runtime
[Preserve]
[Serializable]
public class VerifyOrderResult // TypeDefIndex: 27708
{
	// Fields
	[Preserve]
	public int code; // 0x10
	[Preserve]
	public string message; // 0x18
	[Preserve]
	public bool isNetworkError; // 0x20
	[Preserve]
	public object data; // 0x28

	// Methods

	// RVA: 0x648ED60 Offset: 0x648AD60 VA: 0x648ED60
	public bool IsSuccess() { }

	// RVA: 0x648ED9C Offset: 0x648AD9C VA: 0x648ED9C
	public void .ctor() { }
}

// Namespace: GorillaPurchase.Runtime
[Preserve]
[Serializable]
internal class PurchaseCacheData // TypeDefIndex: 27709
{
	// Fields
	[Preserve]
	public string userId; // 0x10
	[Preserve]
	public int purchaseId; // 0x18
	[Preserve]
	public int goodsId; // 0x1C
	[Preserve]
	public string preOrderId; // 0x20
	[Preserve]
	public string cpOrderId; // 0x28
	[Preserve]
	public Dictionary<string, string> extraData; // 0x30
	[Preserve]
	public string receipt; // 0x38
	[Preserve]
	public string transactionId; // 0x40
	[Preserve]
	public string productId; // 0x48
	[Preserve]
	public string storeSpecificId; // 0x50
	[Preserve]
	public string productName; // 0x58
	[Preserve]
	public string productDescription; // 0x60
	[Preserve]
	public Decimal localizedPrice; // 0x68
	[Preserve]
	public string currencyCode; // 0x78
	public long createTime; // 0x80

	// Methods

	// RVA: 0x648EDA4 Offset: 0x648ADA4 VA: 0x648EDA4
	public void .ctor() { }
}

// Namespace: GorillaPurchase.Runtime
[Preserve]
[Serializable]
internal class PreOrderCacheData // TypeDefIndex: 27710
{
	// Fields
	[Preserve]
	public string userId; // 0x10
	[Preserve]
	public int purchaseId; // 0x18
	[Preserve]
	public int goodsId; // 0x1C
	[Preserve]
	public string productId; // 0x20
	[Preserve]
	public string preOrderId; // 0x28
	[Preserve]
	public string cpOrderId; // 0x30
	[Preserve]
	public Dictionary<string, string> extraData; // 0x38
	[Preserve]
	public long createTime; // 0x40

	// Methods

	// RVA: 0x648EE7C Offset: 0x648AE7C VA: 0x648EE7C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PurchaseCacheService.<>c__DisplayClass11_0 // TypeDefIndex: 27711
{
	// Fields
	public PurchaseCacheService <>4__this; // 0x10
	public long currentTime; // 0x18
	public bool hasExpiredData; // 0x20

	// Methods

	// RVA: 0x648F9F4 Offset: 0x648B9F4 VA: 0x648F9F4
	public void .ctor() { }

	// RVA: 0x648FF50 Offset: 0x648BF50 VA: 0x648FF50
	internal bool <RemoveExpiredData>b__0(PurchaseCacheData data) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PurchaseCacheService.<>c__DisplayClass12_0 // TypeDefIndex: 27712
{
	// Fields
	public PurchaseCacheData cacheData; // 0x10

	// Methods

	// RVA: 0x648FF48 Offset: 0x648BF48 VA: 0x648FF48
	public void .ctor() { }

	// RVA: 0x649002C Offset: 0x648C02C VA: 0x649002C
	internal bool <Delete>b__0(PurchaseCacheData p) { }

	// RVA: 0x6490090 Offset: 0x648C090 VA: 0x6490090
	internal bool <Delete>b__1(PurchaseCacheData p) { }
}

// Namespace: GorillaPurchase.Runtime
internal class PurchaseCacheService // TypeDefIndex: 27713
{
	// Fields
	private const string Tag = "[PurchaseCacheService]";
	private const string PurchaseDataFileName = "PurchaseDataV1.json";
	private readonly string _purchaseFilePath; // 0x10
	private readonly List<PurchaseCacheData> _dataList; // 0x18
	private readonly object _lock; // 0x20
	private readonly int _expiredTime; // 0x28

	// Methods

	// RVA: 0x648EF50 Offset: 0x648AF50 VA: 0x648EF50
	public void .ctor(int expiredTime = 604800) { }

	// RVA: 0x648F09C Offset: 0x648B09C VA: 0x648F09C
	private static void CreatePurchaseFolder(string folder) { }

	// RVA: 0x648F44C Offset: 0x648B44C VA: 0x648F44C
	public void Save(PurchaseCacheData cacheData) { }

	// RVA: 0x648F794 Offset: 0x648B794 VA: 0x648F794
	public List<PurchaseCacheData> Load() { }

	// RVA: 0x648F1A4 Offset: 0x648B1A4 VA: 0x648F1A4
	private List<PurchaseCacheData> LoadFromFile() { }

	// RVA: 0x648F8B4 Offset: 0x648B8B4 VA: 0x648F8B4
	private void RemoveExpiredData() { }

	// RVA: 0x648F9FC Offset: 0x648B9FC VA: 0x648F9FC
	public void Delete(PurchaseCacheData cacheData) { }

	// RVA: 0x648F688 Offset: 0x648B688 VA: 0x648F688
	private void SaveToFile() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PreOrderCacheService.<>c__DisplayClass10_0 // TypeDefIndex: 27714
{
	// Fields
	public string preOrderId; // 0x10
	public string cpOrderId; // 0x18

	// Methods

	// RVA: 0x6491240 Offset: 0x648D240 VA: 0x6491240
	public void .ctor() { }

	// RVA: 0x6491250 Offset: 0x648D250 VA: 0x6491250
	internal bool <Delete>b__0(PreOrderCacheData item) { }

	// RVA: 0x6491270 Offset: 0x648D270 VA: 0x6491270
	internal bool <Delete>b__1(PreOrderCacheData item) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PreOrderCacheService.<>c__DisplayClass12_0 // TypeDefIndex: 27715
{
	// Fields
	public PreOrderCacheService <>4__this; // 0x10
	public long currentTime; // 0x18
	public bool hasExpiredData; // 0x20

	// Methods

	// RVA: 0x6491248 Offset: 0x648D248 VA: 0x6491248
	public void .ctor() { }

	// RVA: 0x6491290 Offset: 0x648D290 VA: 0x6491290
	internal bool <RemoveExpiredData>b__0(PreOrderCacheData data) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PreOrderCacheService.<>c__DisplayClass8_0 // TypeDefIndex: 27716
{
	// Fields
	public PreOrderCacheData cacheData; // 0x10

	// Methods

	// RVA: 0x6490964 Offset: 0x648C964 VA: 0x6490964
	public void .ctor() { }

	// RVA: 0x64912D8 Offset: 0x648D2D8 VA: 0x64912D8
	internal bool <SaveOrUpdate>b__0(PreOrderCacheData item) { }
}

// Namespace: GorillaPurchase.Runtime
internal class PreOrderCacheService // TypeDefIndex: 27717
{
	// Fields
	private const string Tag = "[PreOrderCacheService]";
	private const string PreOrderDataFileName = "PreOrderDataV1.json";
	private readonly string _preOrderFilePath; // 0x10
	private readonly List<PreOrderCacheData> _dataList; // 0x18
	private readonly object _lock; // 0x20
	private readonly int _expiredTime; // 0x28

	// Methods

	// RVA: 0x64900F0 Offset: 0x648C0F0 VA: 0x64900F0
	public void .ctor(int expiredTime = 604800) { }

	// RVA: 0x649023C Offset: 0x648C23C VA: 0x649023C
	private static void CreatePreOrderFolder(string folder) { }

	// RVA: 0x64905EC Offset: 0x648C5EC VA: 0x64905EC
	public void SaveOrUpdate(PreOrderCacheData cacheData) { }

	// RVA: 0x6490BB8 Offset: 0x648CBB8 VA: 0x6490BB8
	public PreOrderCacheData Find(string productId, string cpOrderId) { }

	// RVA: 0x6490DEC Offset: 0x648CDEC VA: 0x6490DEC
	public void Delete(string preOrderId, string cpOrderId, string productId) { }

	// RVA: 0x6490344 Offset: 0x648C344 VA: 0x6490344
	private List<PreOrderCacheData> LoadFromFile() { }

	// RVA: 0x649096C Offset: 0x648C96C VA: 0x649096C
	private void RemoveExpiredData() { }

	// RVA: 0x6490AAC Offset: 0x648CAAC VA: 0x6490AAC
	private void SaveToFile() { }
}

// Namespace: GorillaPurchase.Runtime
[Preserve]
[Serializable]
public class PurchaseData // TypeDefIndex: 27718
{
	// Fields
	[Preserve]
	public string userId; // 0x10
	[Preserve]
	public string productId; // 0x18
	[Preserve]
	public int purchaseId; // 0x20
	[Preserve]
	public int goodsId; // 0x24
	[Preserve]
	public Dictionary<string, string> extraData; // 0x28

	// Methods

	// RVA: 0x6491374 Offset: 0x648D374 VA: 0x6491374
	public void .ctor() { }
}

// Namespace: 
private class PurchaseService.CallbackWrapper // TypeDefIndex: 27719
{
	// Fields
	public Action<NativePurchaseResult> OnSuccess; // 0x10
	public Action<int, string> OnFailure; // 0x18
	public Action OnCancel; // 0x20
	public PurchaseData Data; // 0x28
	public string PreOrderId; // 0x30
	public string CpOrderId; // 0x38

	// Methods

	// RVA: 0x6498D64 Offset: 0x6494D64 VA: 0x6498D64
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PurchaseService.<>c // TypeDefIndex: 27720
{
	// Fields
	public static readonly PurchaseService.<>c <>9; // 0x0
	public static Func<Product, string> <>9__51_0; // 0x8

	// Methods

	// RVA: 0x6498D6C Offset: 0x6494D6C VA: 0x6498D6C
	private static void .cctor() { }

	// RVA: 0x6498DD4 Offset: 0x6494DD4 VA: 0x6498DD4
	public void .ctor() { }

	// RVA: 0x6498DDC Offset: 0x6494DDC VA: 0x6498DDC
	internal string <OnProductsFetchSuccess>b__51_0(Product p) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PurchaseService.<>c__DisplayClass39_0 // TypeDefIndex: 27721
{
	// Fields
	public string productId; // 0x10

	// Methods

	// RVA: 0x64933DC Offset: 0x648F3DC VA: 0x64933DC
	public void .ctor() { }

	// RVA: 0x6498DFC Offset: 0x6494DFC VA: 0x6498DFC
	internal bool <GetProduct>b__0(Product p) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PurchaseService.<>c__DisplayClass40_0 // TypeDefIndex: 27722
{
	// Fields
	public string productId; // 0x10
	public EventData eventData; // 0x18
	public PurchaseService <>4__this; // 0x20
	public PurchaseData data; // 0x28
	public Action<NativePurchaseResult> onSuccess; // 0x30
	public Action<int, string> onFailure; // 0x38
	public Action onCancel; // 0x40
	public Product product; // 0x48

	// Methods

	// RVA: 0x6493AD8 Offset: 0x648FAD8 VA: 0x6493AD8
	public void .ctor() { }

	// RVA: 0x6498E28 Offset: 0x6494E28 VA: 0x6498E28
	internal bool <Purchase>b__2(Product e) { }

	// RVA: 0x6498E54 Offset: 0x6494E54 VA: 0x6498E54
	internal void <Purchase>b__0(PreOrderResponseData response) { }

	// RVA: 0x64991E0 Offset: 0x64951E0 VA: 0x64991E0
	internal void <Purchase>b__1(int code, string message) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PurchaseService.<>c__DisplayClass58_0 // TypeDefIndex: 27723
{
	// Fields
	public PurchaseCacheData cacheData; // 0x10

	// Methods

	// RVA: 0x64977F4 Offset: 0x64937F4 VA: 0x64977F4
	public void .ctor() { }

	// RVA: 0x64993A8 Offset: 0x64953A8 VA: 0x64993A8
	internal bool <SaveCacheData>b__0(PurchaseCacheData e) { }

	// RVA: 0x64993D0 Offset: 0x64953D0 VA: 0x64993D0
	internal bool <SaveCacheData>b__1(PurchaseCacheData e) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PurchaseService.<>c__DisplayClass62_0 // TypeDefIndex: 27724
{
	// Fields
	public PurchaseService <>4__this; // 0x10
	public string transactionId; // 0x18
	public EventData eventData; // 0x20
	public bool isUnfinishedOrder; // 0x28
	public PurchaseService.CallbackWrapper callbackWrapper; // 0x30
	public string productId; // 0x38
	public PurchaseCacheData cacheData; // 0x40
	public PendingOrder pendingOrder; // 0x48
	public string receipt; // 0x50

	// Methods

	// RVA: 0x64979F0 Offset: 0x64939F0 VA: 0x64979F0
	public void .ctor() { }

	// RVA: 0x64993F8 Offset: 0x64953F8 VA: 0x64993F8
	internal void <HandlePendingOrder>b__0(VerifyOrderResult result) { }
}

// Namespace: 
[CompilerGenerated]
private struct PurchaseService.<Initialize>d__37 : IAsyncStateMachine // TypeDefIndex: 27725
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public PurchaseService <>4__this; // 0x28
	private int <currentAttemptId>5__2; // 0x30
	private TaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x64998AC Offset: 0x64958AC VA: 0x64998AC Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x6499DAC Offset: 0x6495DAC VA: 0x6499DAC Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct PurchaseService.<OnProductsFetchFailed>d__52 : IAsyncStateMachine // TypeDefIndex: 27726
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public PurchaseService <>4__this; // 0x28
	public ProductFetchFailed failed; // 0x30
	private TaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x6499DB8 Offset: 0x6495DB8 VA: 0x6499DB8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x649A354 Offset: 0x6496354 VA: 0x649A354 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct PurchaseService.<ScheduleInitializeRetry>d__72 : IAsyncStateMachine // TypeDefIndex: 27727
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public PurchaseService <>4__this; // 0x28
	public string reason; // 0x30
	private TaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x649A360 Offset: 0x6496360 VA: 0x649A360 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x649A968 Offset: 0x6496968 VA: 0x649A968 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: GorillaPurchase.Runtime
public class PurchaseService : IPurchaseService // TypeDefIndex: 27728
{
	// Fields
	private const string Tag = "[PurchaseService]";
	private const int InternalErrorCode = -1;
	private const int MaxRetryCount = 10;
	private const int RetryExponential = 2;
	private bool _isConnected; // 0x10
	private int _fetchProductRetryCount; // 0x14
	private int _connectRetryCount; // 0x18
	private int _connectAttemptId; // 0x1C
	private bool _isReconnectScheduled; // 0x20
	private bool _isServiceActive; // 0x21
	private bool _isCallbacksConfigured; // 0x22
	private readonly CatalogProvider _catalogProvider; // 0x28
	private readonly Dictionary<string, PurchaseService.CallbackWrapper> _callbackMap; // 0x30
	private readonly object _callbackLock; // 0x38
	private readonly List<Product> _fetchedProducts; // 0x40
	private readonly HashSet<string> _verifyingTransactionIds; // 0x48
	private readonly PurchaseCacheService _cacheService; // 0x50
	private readonly PreOrderCacheService _preOrderCacheService; // 0x58
	[CompilerGenerated]
	private IPurchaseNetworkService <NetworkService>k__BackingField; // 0x60
	[CompilerGenerated]
	private IPurchaseUIDelegate <UIDelegate>k__BackingField; // 0x68
	[CompilerGenerated]
	private bool <IsFetchUnfinishedOrderAfterInit>k__BackingField; // 0x70
	[CompilerGenerated]
	private Action<PurchaseFlowEvent> OnPurchaseFlowEvent; // 0x78

	// Properties
	public IPurchaseNetworkService NetworkService { get; set; }
	public IPurchaseUIDelegate UIDelegate { get; set; }
	public bool IsFetchUnfinishedOrderAfterInit { get; set; }
	public Action<string, Dictionary<string, object>> PurchaseEventTracker { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x64913FC Offset: 0x648D3FC VA: 0x64913FC Slot: 4
	public IPurchaseNetworkService get_NetworkService() { }

	[CompilerGenerated]
	// RVA: 0x6491404 Offset: 0x648D404 VA: 0x6491404 Slot: 5
	public void set_NetworkService(IPurchaseNetworkService value) { }

	[CompilerGenerated]
	// RVA: 0x649140C Offset: 0x648D40C VA: 0x649140C Slot: 6
	public IPurchaseUIDelegate get_UIDelegate() { }

	[CompilerGenerated]
	// RVA: 0x6491414 Offset: 0x648D414 VA: 0x6491414 Slot: 7
	public void set_UIDelegate(IPurchaseUIDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x649141C Offset: 0x648D41C VA: 0x649141C
	public bool get_IsFetchUnfinishedOrderAfterInit() { }

	[CompilerGenerated]
	// RVA: 0x6491424 Offset: 0x648D424 VA: 0x6491424
	public void set_IsFetchUnfinishedOrderAfterInit(bool value) { }

	// RVA: 0x6491430 Offset: 0x648D430 VA: 0x6491430 Slot: 8
	public Action<string, Dictionary<string, object>> get_PurchaseEventTracker() { }

	// RVA: 0x6491478 Offset: 0x648D478 VA: 0x6491478 Slot: 9
	public void set_PurchaseEventTracker(Action<string, Dictionary<string, object>> value) { }

	[CompilerGenerated]
	// RVA: 0x64914D0 Offset: 0x648D4D0 VA: 0x64914D0 Slot: 10
	public void add_OnPurchaseFlowEvent(Action<PurchaseFlowEvent> value) { }

	[CompilerGenerated]
	// RVA: 0x6491580 Offset: 0x648D580 VA: 0x6491580 Slot: 11
	public void remove_OnPurchaseFlowEvent(Action<PurchaseFlowEvent> value) { }

	// RVA: 0x6491630 Offset: 0x648D630 VA: 0x6491630
	public void .ctor() { }

	[AsyncStateMachine(typeof(PurchaseService.<Initialize>d__37))]
	// RVA: 0x64927B8 Offset: 0x648E7B8 VA: 0x64927B8 Slot: 12
	public void Initialize() { }

	// RVA: 0x6492868 Offset: 0x648E868 VA: 0x6492868 Slot: 13
	public void DeInitialize() { }

	// RVA: 0x6493154 Offset: 0x648F154 VA: 0x6493154 Slot: 14
	public bool GetProduct(string productId, out Product product) { }

	// RVA: 0x64933E4 Offset: 0x648F3E4 VA: 0x64933E4 Slot: 15
	public void Purchase(PurchaseData data, Action<NativePurchaseResult> onSuccess, Action<int, string> onFailure, Action onCancel) { }

	// RVA: 0x6493BA0 Offset: 0x648FBA0 VA: 0x6493BA0 Slot: 16
	public void RestoreTransactions(Action<bool, string> callback) { }

	// RVA: 0x6493DA0 Offset: 0x648FDA0 VA: 0x6493DA0 Slot: 17
	public void FetchUnfinishedOrder() { }

	// RVA: 0x6493F64 Offset: 0x648FF64 VA: 0x6493F64 Slot: 18
	public void BeginRefundRequest(string transactionID, Action<bool> callback) { }

	// RVA: 0x64940D4 Offset: 0x64900D4 VA: 0x64940D4
	private void OnPurchasePending(PendingOrder pendingOrder) { }

	// RVA: 0x64957E0 Offset: 0x64917E0 VA: 0x64957E0
	private void OnPurchaseConfirmed(Order order) { }

	// RVA: 0x6495984 Offset: 0x6491984 VA: 0x6495984
	private void OnPurchaseFailed(FailedOrder failedOrder) { }

	// RVA: 0x6496004 Offset: 0x6492004 VA: 0x6496004
	private void OnPurchaseDeferred(DeferredOrder deferredOrder) { }

	// RVA: 0x6496318 Offset: 0x6492318 VA: 0x6496318
	private void OnPurchasesFetchSuccess(Orders orders) { }

	// RVA: 0x6496ADC Offset: 0x6492ADC VA: 0x6496ADC
	private void OnPurchasesFetchFailed(PurchasesFetchFailureDescription description) { }

	// RVA: 0x6496BC0 Offset: 0x6492BC0 VA: 0x6496BC0
	private void OnCheckEntitlement(Entitlement checkEntitlementAction) { }

	// RVA: 0x6496CC8 Offset: 0x6492CC8 VA: 0x6496CC8
	private void OnProductsFetchSuccess(List<Product> products) { }

	[AsyncStateMachine(typeof(PurchaseService.<OnProductsFetchFailed>d__52))]
	// RVA: 0x6496F54 Offset: 0x6492F54 VA: 0x6496F54
	private void OnProductsFetchFailed(ProductFetchFailed failed) { }

	// RVA: 0x6497024 Offset: 0x6493024 VA: 0x6497024
	private void OnStoreDisconnected(StoreConnectionFailureDescription description) { }

	// RVA: 0x6493AE0 Offset: 0x648FAE0 VA: 0x6493AE0
	private void DispatchFlowEvent(EventData eventData, PurchaseFlowStage stage, PurchaseFlowStatus status, bool isRecoveredOrder = False) { }

	// RVA: 0x6497280 Offset: 0x6493280 VA: 0x6497280
	private void DispatchFlowEvent(PurchaseFlowEvent flowEvent) { }

	// RVA: 0x6495D4C Offset: 0x6491D4C VA: 0x6495D4C
	private PurchaseService.CallbackWrapper GetCallbackWrapper(string productId) { }

	// RVA: 0x6495F04 Offset: 0x6491F04 VA: 0x6495F04
	private void DeleteCallbackWrapper(string productId) { }

	// RVA: 0x64973E4 Offset: 0x64933E4 VA: 0x64973E4
	private void SaveCacheData(PurchaseCacheData cacheData) { }

	// RVA: 0x64977FC Offset: 0x64937FC VA: 0x64977FC
	private void SavePreOrderData(PurchaseData data, PreOrderResponseData response) { }

	// RVA: 0x64979D8 Offset: 0x64939D8 VA: 0x64979D8
	private PreOrderCacheData LoadPreOrderData(string productId, string cpOrderId) { }

	// RVA: 0x6495E80 Offset: 0x6491E80 VA: 0x6495E80
	private void DeletePreOrderData(string productId, string preOrderId, string cpOrderId) { }

	// RVA: 0x649498C Offset: 0x649098C VA: 0x649498C
	private void HandlePendingOrder(PendingOrder pendingOrder, bool isUnfinishedOrder = False) { }

	// RVA: 0x64979F8 Offset: 0x64939F8 VA: 0x64979F8
	private bool ValidatePendingOrder(PendingOrder pendingOrder) { }

	// RVA: 0x6491860 Offset: 0x648D860 VA: 0x6491860
	private void ConfigureProduct() { }

	// RVA: 0x6492090 Offset: 0x648E090 VA: 0x6492090
	private void ConfigureCallbacks() { }

	// RVA: 0x6492A20 Offset: 0x648EA20 VA: 0x6492A20
	private void UnconfigureCallbacks() { }

	// RVA: 0x6498484 Offset: 0x6494484 VA: 0x6498484
	private static void ConfigureFraudDetection(string cpOrderId) { }

	// RVA: 0x649877C Offset: 0x649477C VA: 0x649877C
	private static void AppleConfigureFraudDetection(string cpOrderId) { }

	// RVA: 0x64985E0 Offset: 0x64945E0 VA: 0x64985E0
	private static void GoogleConfigureFraudDetection(string cpOrderId) { }

	// RVA: 0x6497EDC Offset: 0x6493EDC VA: 0x6497EDC
	private static string ExtractCpOrderIdIfNeeded(PendingOrder pendingOrder) { }

	// RVA: 0x6498C10 Offset: 0x6494C10 VA: 0x6498C10
	private void FetchProducts() { }

	[AsyncStateMachine(typeof(PurchaseService.<ScheduleInitializeRetry>d__72))]
	// RVA: 0x64971B0 Offset: 0x64931B0 VA: 0x64971B0
	private void ScheduleInitializeRetry(string reason) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Extension.<>c // TypeDefIndex: 27729
{
	// Fields
	public static readonly Extension.<>c <>9; // 0x0
	public static Func<IPurchasedProductInfo, string> <>9__1_0; // 0x8

	// Methods

	// RVA: 0x649A974 Offset: 0x6496974 VA: 0x649A974
	private static void .cctor() { }

	// RVA: 0x649A9DC Offset: 0x64969DC VA: 0x649A9DC
	public void .ctor() { }

	// RVA: 0x649A9E4 Offset: 0x64969E4 VA: 0x649A9E4
	internal string <DebugMessage>b__1_0(IPurchasedProductInfo e) { }
}

// Namespace: GorillaPurchase.Runtime
[Extension]
internal static class Extension // TypeDefIndex: 27730
{
	// Methods

	[Extension]
	// RVA: 0x6498970 Offset: 0x6494970 VA: 0x6498970
	internal static Guid ToGuid(string value) { }

	[Extension]
	// RVA: 0x6494194 Offset: 0x6490194 VA: 0x6494194
	internal static string DebugMessage(Order order) { }
}

// Namespace: GorillaPurchase.Runtime
public static class RefundService // TypeDefIndex: 27731
{
	// Methods

	// RVA: 0x649401C Offset: 0x649001C VA: 0x649401C
	public static void BeginRefundRequest(string transactionID, Action<bool> callback) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=475 // TypeDefIndex: 27732
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=969 // TypeDefIndex: 27733
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 27734
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=969 7DE9CB03DDAA0665AB6705D70AD228B476870570592C8EE3A48C0578B2BF26F7 /*Metadata offset 0xF507B0*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=475 DA97C51A48B8A6083A30015CC1115DED1564862A87F2419F8AFA17929A82C11C /*Metadata offset 0xF50B80*/; // 0x3C9
}

