// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 26249
{}

// Namespace: Microsoft.CodeAnalysis
[CompilerGenerated]
[Embedded]
internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 26250
{
	// Methods

	// RVA: 0x8562814 Offset: 0x855E814 VA: 0x8562814
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Embedded]
[CompilerGenerated]
[Usage(27524, AllowMultiple = False, Inherited = False)]
internal sealed class NullableAttribute : Attribute // TypeDefIndex: 26251
{
	// Fields
	public readonly byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x856281C Offset: 0x855E81C VA: 0x856281C
	public void .ctor(byte ) { }

	// RVA: 0x85628A4 Offset: 0x855E8A4 VA: 0x85628A4
	public void .ctor(byte[] ) { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(5196, AllowMultiple = False, Inherited = False)]
[Embedded]
[CompilerGenerated]
internal sealed class NullableContextAttribute : Attribute // TypeDefIndex: 26252
{
	// Fields
	public readonly byte Flag; // 0x10

	// Methods

	// RVA: 0x85628D4 Offset: 0x855E8D4 VA: 0x85628D4
	public void .ctor(byte ) { }
}

// Namespace: Stores.Android.GooglePlay.AAR.Interfaces
internal interface IGooglePurchasesUpdatedHandler // TypeDefIndex: 26253
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetProductCache(IProductCache productCache);
}

// Namespace: UnityEngine.Purchasing
internal class AnalyticsClient : IAnalyticsClient // TypeDefIndex: 26254
{
	// Fields
	private readonly IAnalyticsAdapter m_Analytics; // 0x10

	// Methods

	[Preserve]
	// RVA: 0x85628FC Offset: 0x855E8FC VA: 0x85628FC
	internal void .ctor(IAnalyticsAdapter analytics) { }

	// RVA: 0x856292C Offset: 0x855E92C VA: 0x856292C Slot: 4
	public void OnPurchaseSucceeded(ConfirmedOrder confirmedOrder) { }

	// RVA: 0x8562D90 Offset: 0x855ED90 VA: 0x8562D90 Slot: 5
	public void OnPurchaseFailed(FailedOrder failedOrder) { }
}

// Namespace: UnityEngine.Purchasing
[Preserve]
internal class EmptyAnalyticsAdapter : IAnalyticsAdapter // TypeDefIndex: 26255
{
	// Methods

	// RVA: 0x85631D4 Offset: 0x855F1D4 VA: 0x85631D4 Slot: 4
	public void SendTransactionEvent(CartItem item, string receipt) { }

	// RVA: 0x85631D8 Offset: 0x855F1D8 VA: 0x85631D8 Slot: 5
	public void SendTransactionFailedEvent(PurchaseFailureDescription failureDescription) { }

	// RVA: 0x85631DC Offset: 0x855F1DC VA: 0x85631DC
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class GoogleCachedQueryProductDetailsService.<>c // TypeDefIndex: 26256
{
	// Fields
	public static readonly GoogleCachedQueryProductDetailsService.<>c <>9; // 0x0
	public static Func<ProductDefinition, string> <>9__5_0; // 0x8

	// Methods

	// RVA: 0x8563C60 Offset: 0x855FC60 VA: 0x8563C60
	private static void .cctor() { }

	// RVA: 0x8563CC8 Offset: 0x855FCC8 VA: 0x8563CC8
	public void .ctor() { }

	// RVA: 0x8563CD0 Offset: 0x855FCD0 VA: 0x8563CD0
	internal string <GetCachedQueriedProductDetails>b__5_0(ProductDefinition product) { }
}

// Namespace: UnityEngine.Purchasing
[Preserve]
internal class GoogleCachedQueryProductDetailsService : IGoogleCachedQueryProductDetailsService // TypeDefIndex: 26257
{
	// Fields
	private readonly ConcurrentDictionary<string, AndroidJavaObject> m_CachedQueriedProductDetails; // 0x10

	// Methods

	// RVA: 0x85631E4 Offset: 0x855F1E4 VA: 0x85631E4 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x856350C Offset: 0x855F50C VA: 0x856350C Slot: 4
	public IEnumerable<AndroidJavaObject> GetCachedQueriedProducts() { }

	// RVA: 0x856355C Offset: 0x855F55C VA: 0x856355C
	private AndroidJavaObject GetCachedQueriedProductDetails(string productId) { }

	// RVA: 0x85635B4 Offset: 0x855F5B4 VA: 0x85635B4
	private IEnumerable<AndroidJavaObject> GetCachedQueriedProductDetails(IEnumerable<string> productIds) { }

	// RVA: 0x8563658 Offset: 0x855F658 VA: 0x8563658 Slot: 5
	public IEnumerable<AndroidJavaObject> GetCachedQueriedProductDetails(IEnumerable<ProductDefinition> products) { }

	// RVA: 0x856378C Offset: 0x855F78C VA: 0x856378C
	private bool Contains(string productId) { }

	// RVA: 0x85637E4 Offset: 0x855F7E4 VA: 0x85637E4 Slot: 6
	public bool Contains(ProductDefinition products) { }

	// RVA: 0x85637FC Offset: 0x855F7FC VA: 0x85637FC Slot: 7
	public void AddCachedQueriedProductDetails(IEnumerable<AndroidJavaObject> queriedProducts) { }

	// RVA: 0x8563BD8 Offset: 0x855FBD8 VA: 0x8563BD8
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GoogleFinishTransactionUseCase.<>c__DisplayClass4_0 // TypeDefIndex: 26258
{
	// Fields
	[Nullable(new[] { 0, 1, 1 })]
	public Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished; // 0x10
	[Nullable(0)]
	public IGooglePurchase purchase; // 0x18

	// Methods

	// RVA: 0x85640E0 Offset: 0x85600E0 VA: 0x85640E0
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x85640E8 Offset: 0x85600E8 VA: 0x85640E8
	internal void <FinishTransactionForPurchase>b__0(IGoogleBillingResult result) { }

	[NullableContext(0)]
	// RVA: 0x8564110 Offset: 0x8560110 VA: 0x8564110
	internal void <FinishTransactionForPurchase>b__1(IGoogleBillingResult result) { }
}

// Namespace: 
[CompilerGenerated]
private struct GoogleFinishTransactionUseCase.<FinishTransaction>d__3 : IAsyncStateMachine // TypeDefIndex: 26259
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public GoogleFinishTransactionUseCase <>4__this; // 0x20
	[Nullable(0)]
	public string purchaseToken; // 0x28
	[Nullable(0)]
	public ProductDefinition product; // 0x30
	[Nullable(new[] { 0, 1, 1 })]
	public Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished; // 0x38
	[Nullable(new[] { 0, 2 })]
	private TaskAwaiter<IGooglePurchase> <>u__1; // 0x40

	// Methods

	// RVA: 0x8564138 Offset: 0x8560138 VA: 0x8564138 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x8564524 Offset: 0x8560524 VA: 0x8564524 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
internal class GoogleFinishTransactionUseCase : IGoogleFinishTransactionUseCase // TypeDefIndex: 26260
{
	// Fields
	private readonly IGoogleBillingClient m_BillingClient; // 0x10
	private readonly IGoogleQueryPurchasesUseCase m_GoogleQueryPurchasesUseCase; // 0x18

	// Methods

	[Preserve]
	// RVA: 0x8563CE8 Offset: 0x855FCE8 VA: 0x8563CE8
	internal void .ctor(IGoogleBillingClient billingClient, IGoogleQueryPurchasesUseCase googleQueryPurchasesUseCase) { }

	[AsyncStateMachine(typeof(GoogleFinishTransactionUseCase.<FinishTransaction>d__3))]
	// RVA: 0x8563D2C Offset: 0x855FD2C VA: 0x8563D2C Slot: 4
	public Task FinishTransaction(ProductDefinition product, string purchaseToken, Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished) { }

	// RVA: 0x8563E58 Offset: 0x855FE58 VA: 0x8563E58
	private void FinishTransactionForPurchase(IGooglePurchase purchase, ProductDefinition product, string purchaseToken, Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished) { }
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[Preserve]
[NullableContext(2)]
internal class GoogleLastKnownProductService : IGoogleLastKnownProductService // TypeDefIndex: 26261
{
	// Fields
	[CompilerGenerated]
	private string <LastKnownOldProductId>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <LastKnownProductId>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<GooglePlayReplacementMode> <LastKnownReplacementMode>k__BackingField; // 0x20

	// Properties
	public string LastKnownOldProductId { get; set; }
	public string LastKnownProductId { get; set; }
	public Nullable<GooglePlayReplacementMode> LastKnownReplacementMode { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x856458C Offset: 0x856058C VA: 0x856458C Slot: 4
	public string get_LastKnownOldProductId() { }

	[CompilerGenerated]
	// RVA: 0x8564594 Offset: 0x8560594 VA: 0x8564594 Slot: 5
	public void set_LastKnownOldProductId(string value) { }

	[CompilerGenerated]
	// RVA: 0x856459C Offset: 0x856059C VA: 0x856459C Slot: 6
	public string get_LastKnownProductId() { }

	[CompilerGenerated]
	// RVA: 0x85645A4 Offset: 0x85605A4 VA: 0x85645A4 Slot: 7
	public void set_LastKnownProductId(string value) { }

	[CompilerGenerated]
	// RVA: 0x85645AC Offset: 0x85605AC VA: 0x85645AC Slot: 8
	public Nullable<GooglePlayReplacementMode> get_LastKnownReplacementMode() { }

	[CompilerGenerated]
	// RVA: 0x85645B4 Offset: 0x85605B4 VA: 0x85645B4 Slot: 9
	public void set_LastKnownReplacementMode(Nullable<GooglePlayReplacementMode> value) { }

	// RVA: 0x85645BC Offset: 0x85605BC VA: 0x85645BC
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
internal class GooglePlayCheckEntitlementUseCase : IGooglePlayCheckEntitlementUseCase // TypeDefIndex: 26262
{
	// Fields
	private readonly IGoogleQueryPurchasesUseCase m_GoogleQueryPurchasesUseCase; // 0x10

	// Methods

	[Preserve]
	// RVA: 0x856462C Offset: 0x856062C VA: 0x856462C
	internal void .ctor(IGoogleQueryPurchasesUseCase googleQueryPurchasesUseCase) { }
}

// Namespace: 
[CompilerGenerated]
private struct GooglePlayStoreService.<FetchProducts>d__10 : IAsyncStateMachine // TypeDefIndex: 26263
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public GooglePlayStoreService <>4__this; // 0x28
	[Nullable(new[] { 0, 1 })]
	public IReadOnlyCollection<ProductDefinition> products; // 0x30
	[Nullable(new[] { 0, 1, 1 })]
	public Action<List<ProductDescription>> onProductsReceived; // 0x38
	[Nullable(new[] { 0, 1 })]
	public Action<GoogleFetchProductException> onFetchProductsFailed; // 0x40
	[Nullable(new[] { 0, 1, 1 })]
	private TaskAwaiter<List<ProductDescription>> <>u__1; // 0x48

	// Methods

	// RVA: 0x8564E60 Offset: 0x8560E60 VA: 0x8564E60 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x8565244 Offset: 0x8561244 VA: 0x8565244 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct GooglePlayStoreService.<FetchPurchases>d__14 : IAsyncStateMachine // TypeDefIndex: 26264
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public GooglePlayStoreService <>4__this; // 0x28
	[Nullable(new[] { 0, 1, 1 })]
	public Action<List<IGooglePurchase>> onQueryPurchaseSucceed; // 0x30
	[Nullable(new[] { 0, 2 })]
	public Action<string> onQueryPurchaseFailed; // 0x38
	private TaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x8565250 Offset: 0x8561250 VA: 0x8565250 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x85654A4 Offset: 0x85614A4 VA: 0x85654A4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct GooglePlayStoreService.<FinishTransaction>d__13 : IAsyncStateMachine // TypeDefIndex: 26265
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public GooglePlayStoreService <>4__this; // 0x20
	[Nullable(0)]
	public ProductDefinition product; // 0x28
	[Nullable(0)]
	public string purchaseToken; // 0x30
	[Nullable(new[] { 0, 1, 1 })]
	public Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished; // 0x38
	private TaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x85654B0 Offset: 0x85614B0 VA: 0x85654B0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x8565724 Offset: 0x8561724 VA: 0x8565724 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct GooglePlayStoreService.<TryFetchPurchases>d__15 : IAsyncStateMachine // TypeDefIndex: 26266
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public GooglePlayStoreService <>4__this; // 0x20
	[Nullable(new[] { 0, 1, 1 })]
	public Action<List<IGooglePurchase>> onQueryPurchaseSucceed; // 0x28
	[Nullable(new[] { 0, 1, 1 })]
	private TaskAwaiter<List<IGooglePurchase>> <>u__1; // 0x30

	// Methods

	// RVA: 0x856578C Offset: 0x856178C VA: 0x856578C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x8565A44 Offset: 0x8561A44 VA: 0x8565A44 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
internal class GooglePlayStoreService : IGooglePlayStoreService // TypeDefIndex: 26267
{
	// Fields
	private readonly IQueryProductDetailsService m_QueryProductDetailsService; // 0x10
	private readonly IGoogleLastKnownProductService m_GoogleLastKnownProductService; // 0x18
	private readonly IGooglePurchaseService m_GooglePurchaseService; // 0x20
	private readonly IGoogleFinishTransactionUseCase m_GoogleFinishTransactionUseCase; // 0x28
	private readonly ITelemetryDiagnostics m_TelemetryDiagnostics; // 0x30
	private readonly IGoogleQueryPurchasesUseCase m_GoogleQueryPurchasesUseCase; // 0x38
	private readonly IGooglePlayCheckEntitlementUseCase m_GoogleCheckEntitlementUseCase; // 0x40
	private readonly IGoogleBillingClient m_BillingClient; // 0x48
	private readonly IGooglePlayStoreConnectionService m_GooglePlayStoreConnectionService; // 0x50

	// Methods

	// RVA: 0x856465C Offset: 0x856065C VA: 0x856465C
	internal void .ctor(IGoogleBillingClient billingClient, IGooglePlayStoreConnectionService connectionService, IQueryProductDetailsService queryProductDetailsService, IGoogleLastKnownProductService lastKnownProductService, IGooglePurchaseService purchaseService, IGoogleFinishTransactionUseCase finishTransactionUseCase, IGoogleQueryPurchasesUseCase queryPurchasesUseCase, IGooglePlayCheckEntitlementUseCase googleCheckEntitlementUseCase, ITelemetryDiagnostics telemetryDiagnostics) { }

	[AsyncStateMachine(typeof(GooglePlayStoreService.<FetchProducts>d__10))]
	// RVA: 0x8564748 Offset: 0x8560748 VA: 0x8564748 Slot: 8
	public virtual void FetchProducts(IReadOnlyCollection<ProductDefinition> products, Action<List<ProductDescription>> onProductsReceived, Action<GoogleFetchProductException> onFetchProductsFailed) { }

	// RVA: 0x8564850 Offset: 0x8560850 VA: 0x8564850 Slot: 5
	public void Purchase(ProductDefinition product) { }

	// RVA: 0x8564864 Offset: 0x8560864 VA: 0x8564864 Slot: 9
	public virtual void Purchase(ProductDefinition product, Order currentOrder, Nullable<GooglePlayReplacementMode> desiredReplacementMode) { }

	[AsyncStateMachine(typeof(GooglePlayStoreService.<FinishTransaction>d__13))]
	// RVA: 0x8564B50 Offset: 0x8560B50 VA: 0x8564B50 Slot: 6
	public Task FinishTransaction(ProductDefinition product, string purchaseToken, Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished) { }

	[AsyncStateMachine(typeof(GooglePlayStoreService.<FetchPurchases>d__14))]
	// RVA: 0x8564C7C Offset: 0x8560C7C VA: 0x8564C7C Slot: 7
	public void FetchPurchases(Action<List<IGooglePurchase>> onQueryPurchaseSucceed, Action<string> onQueryPurchaseFailed) { }

	[AsyncStateMachine(typeof(GooglePlayStoreService.<TryFetchPurchases>d__15))]
	// RVA: 0x8564D64 Offset: 0x8560D64 VA: 0x8564D64
	private Task TryFetchPurchases(Action<List<IGooglePurchase>> onQueryPurchaseSucceed) { }
}

// Namespace: 
[CompilerGenerated]
private struct GooglePurchaseService.<Purchase>d__6 : IAsyncStateMachine // TypeDefIndex: 26268
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public GooglePurchaseService <>4__this; // 0x28
	[Nullable(0)]
	public ProductDefinition product; // 0x30
	[Nullable(0)]
	public Order currentOrder; // 0x38
	public Nullable<GooglePlayReplacementMode> desiredReplacementMode; // 0x40
	[Nullable(new[] { 0, 1, 1 })]
	private TaskAwaiter<List<AndroidJavaObject>> <>u__1; // 0x48

	// Methods

	// RVA: 0x8566A24 Offset: 0x8562A24 VA: 0x8566A24 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x8566C94 Offset: 0x8562C94 VA: 0x8566C94 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
internal class GooglePurchaseService : IGooglePurchaseService // TypeDefIndex: 26269
{
	// Fields
	private readonly IGoogleBillingClient m_BillingClient; // 0x10
	private readonly IGooglePurchaseCallback m_GooglePurchaseCallback; // 0x18
	private readonly IQueryProductDetailsService m_QueryProductDetailsService; // 0x20
	private readonly ILogger m_Logger; // 0x28
	[Nullable(2)]
	private IProductCache m_ProductCache; // 0x30

	// Methods

	[Preserve]
	// RVA: 0x8565AAC Offset: 0x8561AAC VA: 0x8565AAC
	internal void .ctor(IGoogleBillingClient billingClient, IGooglePurchaseCallback googlePurchaseCallback, IQueryProductDetailsService queryProductDetailsService, ILogger logger) { }

	[AsyncStateMachine(typeof(GooglePurchaseService.<Purchase>d__6))]
	// RVA: 0x8565B20 Offset: 0x8561B20 VA: 0x8565B20 Slot: 4
	public void Purchase(ProductDefinition product, Order currentOrder, Nullable<GooglePlayReplacementMode> desiredReplacementMode) { }

	// RVA: 0x8565C18 Offset: 0x8561C18 VA: 0x8565C18
	private void OnQueryProductDetailsResponse(List<AndroidJavaObject> productDetailsList, ProductDefinition productToBuy, Order currentOrder, Nullable<GooglePlayReplacementMode> desiredReplacementMode) { }

	// RVA: 0x8565CCC Offset: 0x8561CCC VA: 0x8565CCC
	private bool ValidateQueryProductDetailsResponseParams(List<AndroidJavaObject> skus, ProductDefinition productToBuy, Order currentOrder) { }

	// RVA: 0x8565ED4 Offset: 0x8561ED4 VA: 0x8565ED4
	private bool ValidateSkus(List<AndroidJavaObject> skus) { }

	// RVA: 0x8566434 Offset: 0x8562434 VA: 0x8566434
	private void VerifyAndWarnIfMoreThanOneSku(List<AndroidJavaObject> skus) { }

	// RVA: 0x8565F34 Offset: 0x8561F34 VA: 0x8565F34
	private void PurchaseFailedSkuNotFound(ProductDefinition productToBuy) { }

	[NullableContext(2)]
	// RVA: 0x85660E8 Offset: 0x85620E8 VA: 0x85660E8
	private static bool ValidateCurrentOrder(Order currentOrder) { }

	// RVA: 0x85661AC Offset: 0x85621AC VA: 0x85661AC
	private void PurchaseFailedInvalidOldProduct(ProductDefinition productToBuy, Order currentOrder) { }

	// RVA: 0x8565D30 Offset: 0x8561D30 VA: 0x8565D30
	private void LaunchGoogleBillingFlow(AndroidJavaObject productToPurchase, Order currentOrder, Nullable<GooglePlayReplacementMode> desiredReplacementMode) { }

	// RVA: 0x85666FC Offset: 0x85626FC VA: 0x85666FC
	private void HandleBillingFlowResult(IGoogleBillingResult billingResult, AndroidJavaObject sku) { }

	[NullableContext(2)]
	// RVA: 0x8566A1C Offset: 0x8562A1C VA: 0x8566A1C Slot: 5
	public void SetProductCache(IProductCache productCache) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GooglePurchasesUpdatedHandler.<>c__DisplayClass10_0 // TypeDefIndex: 26270
{
	// Fields
	[Nullable(0)]
	public GooglePurchasesUpdatedHandler <>4__this; // 0x10
	[Nullable(0)]
	public IGoogleBillingResult billingResult; // 0x18

	// Methods

	// RVA: 0x856808C Offset: 0x856408C VA: 0x856808C
	public void .ctor() { }

	// RVA: 0x8569C6C Offset: 0x8565C6C VA: 0x8569C6C
	internal void <HandleExistingPurchasesErrorCase>b__0(IGooglePurchase purchase) { }
}

// Namespace: 
[CompilerGenerated]
private struct GooglePurchasesUpdatedHandler.<HandleUserCancelledPurchaseFailure>d__12 : IAsyncStateMachine // TypeDefIndex: 26271
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public GooglePurchasesUpdatedHandler <>4__this; // 0x28
	[Nullable(0)]
	public IGoogleBillingResult billingResult; // 0x30
	[Nullable(new[] { 0, 1, 1 })]
	private TaskAwaiter<List<IGooglePurchase>> <>u__1; // 0x38

	// Methods

	// RVA: 0x8569D2C Offset: 0x8565D2C VA: 0x8569D2C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x8569F90 Offset: 0x8565F90 VA: 0x8569F90 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
internal class GooglePurchasesUpdatedHandler : IGooglePurchasesUpdatedHandler // TypeDefIndex: 26272
{
	// Fields
	private readonly IGoogleLastKnownProductService m_LastKnownProductService; // 0x10
	private readonly IGooglePurchaseStateEnumProvider m_GooglePurchaseStateEnumProvider; // 0x18
	private readonly IGoogleQueryPurchasesUseCase m_GoogleQueryPurchasesUseCase; // 0x20
	private readonly IGooglePurchaseCallback m_GooglePurchaseCallback; // 0x28
	[Nullable(2)]
	private IProductCache m_ProductCache; // 0x30

	// Methods

	[Preserve]
	// RVA: 0x8566CA0 Offset: 0x8562CA0 VA: 0x8566CA0
	internal void .ctor(IGoogleLastKnownProductService googleLastKnownProductService, IGooglePurchaseCallback googlePurchaseCallback, IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider, IGoogleQueryPurchasesUseCase googleQueryPurchasesUseCase) { }

	// RVA: 0x8566D14 Offset: 0x8562D14 VA: 0x8566D14
	public void SubscribeToPurchasesUpdatedEvent(IGooglePurchasesUpdatedListener purchasesUpdatedListener) { }

	// RVA: 0x8566DF8 Offset: 0x8562DF8 VA: 0x8566DF8 Slot: 5
	public void HandleUpdatedPurchases(IGoogleBillingResult result, List<IGooglePurchase> purchases) { }

	// RVA: 0x8566ED4 Offset: 0x8562ED4 VA: 0x8566ED4
	private void HandleResultOkCases(IGoogleBillingResult result, List<IGooglePurchase> purchases) { }

	// RVA: 0x8566F98 Offset: 0x8562F98 VA: 0x8566F98
	private void HandleErrorCases(IGoogleBillingResult billingResult, List<IGooglePurchase> purchases) { }

	// RVA: 0x8567E68 Offset: 0x8563E68 VA: 0x8567E68
	private void HandleExistingPurchasesErrorCase(List<IGooglePurchase> purchases, IGoogleBillingResult billingResult) { }

	// RVA: 0x856716C Offset: 0x856316C VA: 0x856716C
	private void HandleNoPurchasesErrorCase(IGoogleBillingResult billingResult) { }

	[AsyncStateMachine(typeof(GooglePurchasesUpdatedHandler.<HandleUserCancelledPurchaseFailure>d__12))]
	// RVA: 0x8568094 Offset: 0x8564094 VA: 0x8568094
	private void HandleUserCancelledPurchaseFailure(IGoogleBillingResult billingResult) { }

	// RVA: 0x8568164 Offset: 0x8564164 VA: 0x8568164
	private void HandleUserCancelledPurchaseFailure(IGoogleBillingResult billingResult, List<IGooglePurchase> googlePurchases) { }

	// RVA: 0x856701C Offset: 0x856301C VA: 0x856701C
	private void ApplyOnPurchases(List<IGooglePurchase> purchases, Action<IGooglePurchase> action) { }

	// RVA: 0x85682B0 Offset: 0x85642B0 VA: 0x85682B0
	private void OnPurchaseOk(IGooglePurchase googlePurchase) { }

	// RVA: 0x8568D04 Offset: 0x8564D04 VA: 0x8568D04
	private void HandlePurchasedProduct(IGooglePurchase googlePurchase) { }

	// RVA: 0x85690DC Offset: 0x85650DC VA: 0x85690DC
	private bool IsDeferredSubscriptionChange(IGooglePurchase googlePurchase) { }

	// RVA: 0x8569224 Offset: 0x8565224 VA: 0x8569224
	private bool IsLastReplacementModeDeferred() { }

	// RVA: 0x8568738 Offset: 0x8564738 VA: 0x8568738
	private void OnPurchaseCancelled(IGoogleBillingResult billingResult) { }

	// RVA: 0x85692FC Offset: 0x85652FC VA: 0x85692FC
	private void OnPurchaseCancelled(IGooglePurchase googlePurchase) { }

	// RVA: 0x85695CC Offset: 0x85655CC VA: 0x85695CC
	private void OnPurchaseAlreadyOwned(IGooglePurchase googlePurchase) { }

	// RVA: 0x856989C Offset: 0x856589C VA: 0x856989C
	private void OnPurchaseFailedForUnknownReason(IGooglePurchase googlePurchase, string debugMessage) { }

	[NullableContext(2)]
	// RVA: 0x8569B34 Offset: 0x8565B34 VA: 0x8569B34 Slot: 4
	public void SetProductCache(IProductCache productCache) { }

	[CompilerGenerated]
	[NullableContext(0)]
	// RVA: 0x8569B3C Offset: 0x8565B3C VA: 0x8569B3C
	private bool <HandleUserCancelledPurchaseFailure>b__13_0(IGooglePurchase purchase) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class GoogleQueryPurchasesUseCase.<>c // TypeDefIndex: 26273
{
	// Fields
	[Nullable(0)]
	public static readonly GoogleQueryPurchasesUseCase.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<IEnumerable<IGooglePurchase>, IEnumerable<IGooglePurchase>> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x856A450 Offset: 0x8566450 VA: 0x856A450
	private static void .cctor() { }

	// RVA: 0x856A4B8 Offset: 0x85664B8 VA: 0x856A4B8
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x856A4C0 Offset: 0x85664C0 VA: 0x856A4C0
	internal IEnumerable<IGooglePurchase> <QueryPurchases>b__3_0(IEnumerable<IGooglePurchase> result) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GoogleQueryPurchasesUseCase.<>c__DisplayClass4_0 // TypeDefIndex: 26274
{
	// Fields
	[Nullable(0)]
	public GoogleQueryPurchasesUseCase <>4__this; // 0x10
	[Nullable(new[] { 0, 1, 1 })]
	public TaskCompletionSource<IEnumerable<IGooglePurchase>> taskCompletion; // 0x18

	// Methods

	// RVA: 0x856A288 Offset: 0x8566288 VA: 0x856A288
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x856A4C8 Offset: 0x85664C8 VA: 0x856A4C8
	internal void <QueryPurchasesWithSkuType>b__0(IGoogleBillingResult billingResult, IEnumerable<AndroidJavaObject> purchases) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GoogleQueryPurchasesUseCase.<>c__DisplayClass5_0 // TypeDefIndex: 26275
{
	// Fields
	[Nullable(0)]
	public string purchaseToken; // 0x10

	// Methods

	// RVA: 0x856A620 Offset: 0x8566620 VA: 0x856A620
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x856A628 Offset: 0x8566628 VA: 0x856A628
	internal bool <GetPurchaseByToken>b__0(IGooglePurchase purchase) { }
}

// Namespace: 
[CompilerGenerated]
private struct GoogleQueryPurchasesUseCase.<GetPurchaseByToken>d__5 : IAsyncStateMachine // TypeDefIndex: 26276
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<IGooglePurchase> <>t__builder; // 0x8
	[Nullable(0)]
	public string purchaseToken; // 0x20
	[Nullable(0)]
	public GoogleQueryPurchasesUseCase <>4__this; // 0x28
	[Nullable(0)]
	private GoogleQueryPurchasesUseCase.<>c__DisplayClass5_0 <>8__1; // 0x30
	[Nullable(new[] { 0, 1, 1 })]
	private TaskAwaiter<List<IGooglePurchase>> <>u__1; // 0x38

	// Methods

	// RVA: 0x856A6D8 Offset: 0x85666D8 VA: 0x856A6D8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x856AA3C Offset: 0x8566A3C VA: 0x856AA3C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct GoogleQueryPurchasesUseCase.<QueryPurchases>d__3 : IAsyncStateMachine // TypeDefIndex: 26277
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(new[] { 0, 0, 1 })]
	public AsyncTaskMethodBuilder<List<IGooglePurchase>> <>t__builder; // 0x8
	[Nullable(0)]
	public GoogleQueryPurchasesUseCase <>4__this; // 0x20
	[Nullable(0)]
	private TaskAwaiter<IEnumerable<IGooglePurchase>[]> <>u__1; // 0x28

	// Methods

	// RVA: 0x856AAB8 Offset: 0x8566AB8 VA: 0x856AAB8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x856AF34 Offset: 0x8566F34 VA: 0x856AF34 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
internal class GoogleQueryPurchasesUseCase : IGoogleQueryPurchasesUseCase // TypeDefIndex: 26278
{
	// Fields
	private readonly IGoogleBillingClient m_BillingClient; // 0x10
	private readonly IGooglePurchaseBuilder m_PurchaseBuilder; // 0x18

	// Methods

	[Preserve]
	// RVA: 0x8569F9C Offset: 0x8565F9C VA: 0x8569F9C
	internal void .ctor(IGoogleBillingClient billingClient, IGooglePurchaseBuilder purchaseBuilder) { }

	[AsyncStateMachine(typeof(GoogleQueryPurchasesUseCase.<QueryPurchases>d__3))]
	// RVA: 0x8569FE0 Offset: 0x8565FE0 VA: 0x8569FE0 Slot: 4
	public Task<List<IGooglePurchase>> QueryPurchases() { }

	// RVA: 0x856A0DC Offset: 0x85660DC VA: 0x856A0DC
	private Task<IEnumerable<IGooglePurchase>> QueryPurchasesWithSkuType(string skuType) { }

	[NullableContext(2)]
	[AsyncStateMachine(typeof(GoogleQueryPurchasesUseCase.<GetPurchaseByToken>d__5))]
	// RVA: 0x856A290 Offset: 0x8566290 VA: 0x856A290 Slot: 5
	public Task<IGooglePurchase> GetPurchaseByToken(string purchaseToken) { }

	// RVA: 0x856A3A8 Offset: 0x85663A8 VA: 0x856A3A8
	private static bool IsResultOk(IGoogleBillingResult result) { }
}

// Namespace: UnityEngine.Purchasing
internal interface IGoogleCachedQueryProductDetailsService // TypeDefIndex: 26279
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IEnumerable<AndroidJavaObject> GetCachedQueriedProducts();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IEnumerable<AndroidJavaObject> GetCachedQueriedProductDetails(IEnumerable<ProductDefinition> products);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool Contains(ProductDefinition products);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void AddCachedQueriedProductDetails(IEnumerable<AndroidJavaObject> queriedProducts);
}

// Namespace: 
[CompilerGenerated]
private sealed class BillingClientStateListener.<>c__DisplayClass7_0 // TypeDefIndex: 26280
{
	// Fields
	public BillingClientStateListener <>4__this; // 0x10
	public AndroidJavaObject billingResult; // 0x18

	// Methods

	// RVA: 0x856B18C Offset: 0x856718C VA: 0x856B18C
	public void .ctor() { }

	// RVA: 0x856B420 Offset: 0x8567420 VA: 0x856B420
	internal void <onBillingSetupFinished>b__0() { }
}

// Namespace: UnityEngine.Purchasing
internal class BillingClientStateListener : AndroidJavaProxy, IBillingClientStateListener // TypeDefIndex: 26281
{
	// Fields
	private const string k_AndroidBillingClientStateListenerClassName = "com.android.billingclient.api.BillingClientStateListener";
	private Action m_OnConnected; // 0x20
	private Action<GoogleBillingResponseCode> m_Disconnect; // 0x28
	private readonly IUtil m_Util; // 0x30

	// Methods

	// RVA: 0x856AFB0 Offset: 0x8566FB0 VA: 0x856AFB0
	internal void .ctor(IUtil util) { }

	// RVA: 0x856B03C Offset: 0x856703C VA: 0x856B03C Slot: 10
	public void RegisterOnConnected(Action onConnected) { }

	// RVA: 0x856B044 Offset: 0x8567044 VA: 0x856B044 Slot: 11
	public void RegisterOnDisconnected(Action<GoogleBillingResponseCode> onDisconnected) { }

	[Preserve]
	// RVA: 0x856B04C Offset: 0x856704C VA: 0x856B04C
	public void onBillingSetupFinished(AndroidJavaObject billingResult) { }

	// RVA: 0x856B194 Offset: 0x8567194 VA: 0x856B194
	private void HandleBillingSetupFinished(AndroidJavaObject billingResult) { }

	[Preserve]
	// RVA: 0x856B308 Offset: 0x8567308 VA: 0x856B308
	public void onBillingServiceDisconnected() { }

	[CompilerGenerated]
	// RVA: 0x856B3F8 Offset: 0x85673F8 VA: 0x856B3F8
	private void <onBillingServiceDisconnected>b__9_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GoogleAcknowledgePurchaseListener.<>c__DisplayClass4_0 // TypeDefIndex: 26282
{
	// Fields
	public GoogleAcknowledgePurchaseListener <>4__this; // 0x10
	public AndroidJavaObject billingResult; // 0x18

	// Methods

	// RVA: 0x856B620 Offset: 0x8567620 VA: 0x856B620
	public void .ctor() { }

	// RVA: 0x856B628 Offset: 0x8567628 VA: 0x856B628
	internal void <onAcknowledgePurchaseResponse>b__0() { }
}

// Namespace: UnityEngine.Purchasing
internal class GoogleAcknowledgePurchaseListener : AndroidJavaProxy // TypeDefIndex: 26283
{
	// Fields
	private const string k_AndroidAcknowledgePurchaseResponseListenerClassName = "com.android.billingclient.api.AcknowledgePurchaseResponseListener";
	private readonly Action<IGoogleBillingResult> m_OnAcknowledgePurchaseResponse; // 0x20
	private readonly IUtil m_Util; // 0x28

	// Methods

	// RVA: 0x856B440 Offset: 0x8567440 VA: 0x856B440
	internal void .ctor(Action<IGoogleBillingResult> onAcknowledgePurchaseResponseAction, IUtil util) { }

	[Preserve]
	// RVA: 0x856B4E0 Offset: 0x85674E0 VA: 0x856B4E0
	private void onAcknowledgePurchaseResponse(AndroidJavaObject billingResult) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GoogleConsumeResponseListener.<>c__DisplayClass4_0 // TypeDefIndex: 26284
{
	// Fields
	public GoogleConsumeResponseListener <>4__this; // 0x10
	public AndroidJavaObject billingResult; // 0x18

	// Methods

	// RVA: 0x856B89C Offset: 0x856789C VA: 0x856B89C
	public void .ctor() { }

	// RVA: 0x856B8A4 Offset: 0x85678A4 VA: 0x856B8A4
	internal void <onConsumeResponse>b__0() { }
}

// Namespace: UnityEngine.Purchasing
internal class GoogleConsumeResponseListener : AndroidJavaProxy // TypeDefIndex: 26285
{
	// Fields
	private const string k_AndroidConsumeResponseListenerClassName = "com.android.billingclient.api.ConsumeResponseListener";
	private readonly Action<IGoogleBillingResult> m_OnConsumeResponse; // 0x20
	private readonly IUtil m_Util; // 0x28

	// Methods

	// RVA: 0x856B6BC Offset: 0x85676BC VA: 0x856B6BC
	internal void .ctor(Action<IGoogleBillingResult> onConsumeResponseAction, IUtil util) { }

	[Preserve]
	// RVA: 0x856B75C Offset: 0x856775C VA: 0x856B75C
	private void onConsumeResponse(AndroidJavaObject billingResult, string purchaseToken) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GooglePurchasesResponseListener.<>c__DisplayClass4_0 // TypeDefIndex: 26286
{
	// Fields
	public AndroidJavaObject purchases; // 0x10
	public GooglePurchasesResponseListener <>4__this; // 0x18
	public AndroidJavaObject billingResult; // 0x20

	// Methods

	// RVA: 0x856BB34 Offset: 0x8567B34 VA: 0x856BB34
	public void .ctor() { }

	// RVA: 0x856BB3C Offset: 0x8567B3C VA: 0x856BB3C
	internal void <onQueryPurchasesResponse>b__0() { }
}

// Namespace: UnityEngine.Purchasing
internal class GooglePurchasesResponseListener : AndroidJavaProxy // TypeDefIndex: 26287
{
	// Fields
	private const string k_AndroidPurchasesResponseListenerClassName = "com.android.billingclient.api.PurchasesResponseListener";
	private readonly Action<IGoogleBillingResult, IEnumerable<AndroidJavaObject>> m_OnQueryPurchasesResponse; // 0x20
	private readonly IUtil m_Util; // 0x28

	// Methods

	// RVA: 0x856B938 Offset: 0x8567938 VA: 0x856B938
	internal void .ctor(Action<IGoogleBillingResult, IEnumerable<AndroidJavaObject>> onQueryPurchasesResponse, IUtil util) { }

	[Preserve]
	// RVA: 0x856B9D8 Offset: 0x85679D8 VA: 0x856B9D8
	public void onQueryPurchasesResponse(AndroidJavaObject billingResult, AndroidJavaObject purchases) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GooglePurchasesUpdatedListener.<>c__DisplayClass7_0 // TypeDefIndex: 26288
{
	// Fields
	public GooglePurchasesUpdatedListener <>4__this; // 0x10
	public AndroidJavaObject billingResult; // 0x18
	public AndroidJavaObject javaPurchasesList; // 0x20

	// Methods

	// RVA: 0x856C074 Offset: 0x8568074 VA: 0x856C074
	public void .ctor() { }

	// RVA: 0x856C2F4 Offset: 0x85682F4 VA: 0x856C2F4
	internal void <onPurchasesUpdated>b__0() { }
}

// Namespace: UnityEngine.Purchasing
internal class GooglePurchasesUpdatedListener : AndroidJavaProxy, IGooglePurchasesUpdatedListener // TypeDefIndex: 26289
{
	// Fields
	private const string k_AndroidPurchaseListenerClassName = "com.android.billingclient.api.PurchasesUpdatedListener";
	[CompilerGenerated]
	private Action<IGoogleBillingResult, List<IGooglePurchase>> OnPurchaseUpdated; // 0x20
	private readonly IGooglePurchaseBuilder m_PurchaseBuilder; // 0x28
	private readonly IUtil m_Util; // 0x30

	// Methods

	[CompilerGenerated]
	// RVA: 0x856BD18 Offset: 0x8567D18 VA: 0x856BD18 Slot: 10
	public void add_OnPurchaseUpdated(Action<IGoogleBillingResult, List<IGooglePurchase>> value) { }

	[CompilerGenerated]
	// RVA: 0x856BDC8 Offset: 0x8567DC8 VA: 0x856BDC8 Slot: 11
	public void remove_OnPurchaseUpdated(Action<IGoogleBillingResult, List<IGooglePurchase>> value) { }

	// RVA: 0x856BE78 Offset: 0x8567E78 VA: 0x856BE78
	internal void .ctor(IGooglePurchaseBuilder purchaseBuilder, IUtil util) { }

	[Preserve]
	// RVA: 0x856BF18 Offset: 0x8567F18 VA: 0x856BF18
	public void onPurchasesUpdated(AndroidJavaObject billingResult, AndroidJavaObject javaPurchasesList) { }

	// RVA: 0x856C07C Offset: 0x856807C VA: 0x856C07C
	private void HandlePurchasesUpdated(AndroidJavaObject billingResult, AndroidJavaObject javaPurchasesList) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ProductDetailsResponseListener.<>c__DisplayClass5_0 // TypeDefIndex: 26290
{
	// Fields
	[Nullable(0)]
	public AndroidJavaObject queryProductDetailsResult; // 0x10
	[Nullable(0)]
	public ProductDetailsResponseListener <>4__this; // 0x18
	[Nullable(0)]
	public AndroidJavaObject billingResult; // 0x20

	// Methods

	// RVA: 0x856C52C Offset: 0x856852C VA: 0x856C52C
	public void .ctor() { }

	// RVA: 0x856C534 Offset: 0x8568534 VA: 0x856C534
	internal void <onProductDetailsResponse>b__0() { }
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
internal class ProductDetailsResponseListener : AndroidJavaProxy // TypeDefIndex: 26291
{
	// Fields
	private const string k_AndroidProductDetailsResponseListenerClassName = "com.android.billingclient.api.ProductDetailsResponseListener";
	private readonly Action<IGoogleBillingResult, List<AndroidJavaObject>> m_OnProductDetailsResponse; // 0x20
	private readonly IUtil m_Util; // 0x28
	private readonly ITelemetryDiagnostics m_TelemetryDiagnostics; // 0x30

	// Methods

	// RVA: 0x856C314 Offset: 0x8568314 VA: 0x856C314
	internal void .ctor(Action<IGoogleBillingResult, List<AndroidJavaObject>> onProductDetailsResponseAction, IUtil util, ITelemetryDiagnostics telemetryDiagnostics) { }

	[Preserve]
	// RVA: 0x856C3D0 Offset: 0x85683D0 VA: 0x856C3D0
	public void onProductDetailsResponse(AndroidJavaObject billingResult, AndroidJavaObject queryProductDetailsResult) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MetricizedGooglePlayStoreService.<>c__DisplayClass2_0 // TypeDefIndex: 26292
{
	// Fields
	[Nullable(0)]
	public MetricizedGooglePlayStoreService <>4__this; // 0x10
	[Nullable(new[] { 0, 1 })]
	public IReadOnlyCollection<ProductDefinition> products; // 0x18
	[Nullable(new[] { 0, 1, 1 })]
	public Action<List<ProductDescription>> onProductsReceived; // 0x20
	[Nullable(new[] { 0, 1 })]
	public Action<GoogleFetchProductException> onFetchProductsFailed; // 0x28

	// Methods

	// RVA: 0x856CB00 Offset: 0x8568B00 VA: 0x856CB00
	public void .ctor() { }

	// RVA: 0x856CCBC Offset: 0x8568CBC VA: 0x856CCBC
	internal void <FetchProducts>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MetricizedGooglePlayStoreService.<>c__DisplayClass3_0 // TypeDefIndex: 26293
{
	// Fields
	[Nullable(0)]
	public MetricizedGooglePlayStoreService <>4__this; // 0x10
	[Nullable(0)]
	public ProductDefinition product; // 0x18
	[Nullable(0)]
	public Order currentOrder; // 0x20
	public Nullable<GooglePlayReplacementMode> desiredReplacementMode; // 0x28

	// Methods

	// RVA: 0x856CCAC Offset: 0x8568CAC VA: 0x856CCAC
	public void .ctor() { }

	// RVA: 0x856CCE0 Offset: 0x8568CE0 VA: 0x856CCE0
	internal void <Purchase>b__0() { }
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
internal class MetricizedGooglePlayStoreService : GooglePlayStoreService // TypeDefIndex: 26294
{
	// Fields
	private readonly ITelemetryMetricsService m_TelemetryMetricsService; // 0x58

	// Methods

	[Preserve]
	// RVA: 0x856C914 Offset: 0x8568914 VA: 0x856C914
	internal void .ctor(IGoogleBillingClient billingClient, IGooglePlayStoreConnectionService connectionService, IQueryProductDetailsService queryProductDetailsService, IGoogleLastKnownProductService lastKnownProductService, IGooglePurchaseService purchaseService, IGoogleFinishTransactionUseCase finishTransactionUseCase, IGoogleQueryPurchasesUseCase queryPurchasesUseCase, IGooglePlayCheckEntitlementUseCase googleCheckEntitlementUseCase, ITelemetryDiagnostics telemetryDiagnostics, ITelemetryMetricsService telemetryMetricsService) { }

	// RVA: 0x856C950 Offset: 0x8568950 VA: 0x856C950 Slot: 8
	public override void FetchProducts(IReadOnlyCollection<ProductDefinition> products, Action<List<ProductDescription>> onProductsReceived, Action<GoogleFetchProductException> onFetchProductsFailed) { }

	// RVA: 0x856CB08 Offset: 0x8568B08 VA: 0x856CB08 Slot: 9
	public override void Purchase(ProductDefinition product, Order currentOrder, Nullable<GooglePlayReplacementMode> desiredReplacementMode) { }

	[CompilerGenerated]
	[DebuggerHidden]
	// RVA: 0x856CCB4 Offset: 0x8568CB4 VA: 0x856CCB4
	private void <>n__0(IReadOnlyCollection<ProductDefinition> products, Action<List<ProductDescription>> onProductsReceived, Action<GoogleFetchProductException> onFetchProductsFailed) { }

	[DebuggerHidden]
	[CompilerGenerated]
	// RVA: 0x856CCB8 Offset: 0x8568CB8 VA: 0x856CCB8
	private void <>n__1(ProductDefinition product, Order currentOrder, Nullable<GooglePlayReplacementMode> desiredReplacementMode) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ProductDetailsQueryResponse.<>c // TypeDefIndex: 26295
{
	// Fields
	public static readonly ProductDetailsQueryResponse.<>c <>9; // 0x0
	public static Func<AndroidJavaObject, AndroidJavaObject> <>9__2_0; // 0x8
	public static Func<ValueTuple<IGoogleBillingResult, IEnumerable<AndroidJavaObject>>, bool> <>9__3_0; // 0x10
	public static Func<ValueTuple<IGoogleBillingResult, IEnumerable<AndroidJavaObject>>, IEnumerable<AndroidJavaObject>> <>9__3_1; // 0x18
	public static Func<ValueTuple<IGoogleBillingResult, IEnumerable<AndroidJavaObject>>, IGoogleBillingResult> <>9__4_0; // 0x20
	public static Func<ValueTuple<IGoogleBillingResult, IEnumerable<AndroidJavaObject>>, IGoogleBillingResult> <>9__5_0; // 0x28
	public static Func<ValueTuple<IGoogleBillingResult, IEnumerable<AndroidJavaObject>>, IGoogleBillingResult> <>9__5_1; // 0x30

	// Methods

	// RVA: 0x856DCB4 Offset: 0x8569CB4 VA: 0x856DCB4
	private static void .cctor() { }

	// RVA: 0x856DD1C Offset: 0x8569D1C VA: 0x856DD1C
	public void .ctor() { }

	// RVA: 0x856DD24 Offset: 0x8569D24 VA: 0x856DD24
	internal AndroidJavaObject <AddResponse>b__2_0(AndroidJavaObject product) { }

	// RVA: 0x856DD2C Offset: 0x8569D2C VA: 0x856DD2C
	internal bool <ProductDetails>b__3_0(ValueTuple<IGoogleBillingResult, IEnumerable<AndroidJavaObject>> response) { }

	// RVA: 0x856DDD4 Offset: 0x8569DD4 VA: 0x856DDD4
	internal IEnumerable<AndroidJavaObject> <ProductDetails>b__3_1(ValueTuple<IGoogleBillingResult, IEnumerable<AndroidJavaObject>> response) { }

	// RVA: 0x856DDDC Offset: 0x8569DDC VA: 0x856DDDC
	internal IGoogleBillingResult <IsRecoverable>b__4_0(ValueTuple<IGoogleBillingResult, IEnumerable<AndroidJavaObject>> response) { }

	// RVA: 0x856DDE4 Offset: 0x8569DE4 VA: 0x856DDE4
	internal IGoogleBillingResult <GetRecoverableBillingResponseCode>b__5_0(ValueTuple<IGoogleBillingResult, IEnumerable<AndroidJavaObject>> response) { }

	// RVA: 0x856DDEC Offset: 0x8569DEC VA: 0x856DDEC
	internal IGoogleBillingResult <GetRecoverableBillingResponseCode>b__5_1(ValueTuple<IGoogleBillingResult, IEnumerable<AndroidJavaObject>> response) { }
}

// Namespace: UnityEngine.Purchasing
internal class ProductDetailsQueryResponse : IProductDetailsQueryResponse // TypeDefIndex: 26296
{
	// Fields
	private readonly ConcurrentBag<ValueTuple<IGoogleBillingResult, IEnumerable<AndroidJavaObject>>> m_Responses; // 0x10

	// Methods

	// RVA: 0x856CD04 Offset: 0x8568D04 VA: 0x856CD04 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x856D2A4 Offset: 0x85692A4 VA: 0x856D2A4 Slot: 5
	public void AddResponse(IGoogleBillingResult billingResult, IEnumerable<AndroidJavaObject> productDetails) { }

	// RVA: 0x856D438 Offset: 0x8569438 VA: 0x856D438 Slot: 6
	public List<AndroidJavaObject> ProductDetails() { }

	// RVA: 0x856D618 Offset: 0x8569618 VA: 0x856D618 Slot: 4
	public bool IsRecoverable() { }

	// RVA: 0x856D794 Offset: 0x8569794 VA: 0x856D794 Slot: 7
	public GoogleBillingResponseCode GetRecoverableBillingResponseCode() { }

	// RVA: 0x856DAB4 Offset: 0x8569AB4 VA: 0x856DAB4
	private static bool IsRecoverable(IGoogleBillingResult billingResult) { }

	// RVA: 0x856DADC Offset: 0x8569ADC VA: 0x856DADC
	private static bool IsServiceUnavailable(IGoogleBillingResult billingResult) { }

	// RVA: 0x856DB84 Offset: 0x8569B84 VA: 0x856DB84
	private static bool IsDeveloperError(IGoogleBillingResult billingResult) { }

	// RVA: 0x856DC2C Offset: 0x8569C2C VA: 0x856DC2C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class QueryProductDetailsService.<>c // TypeDefIndex: 26297
{
	// Fields
	[Nullable(0)]
	public static readonly QueryProductDetailsService.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<bool, bool> <>9__9_0; // 0x8
	[Nullable(0)]
	public static Func<ProductDefinition, bool> <>9__11_0; // 0x10
	[Nullable(0)]
	public static Func<ProductDefinition, string> <>9__11_1; // 0x18
	[Nullable(0)]
	public static Func<ProductDefinition, bool> <>9__12_0; // 0x20
	[Nullable(0)]
	public static Func<ProductDefinition, string> <>9__12_1; // 0x28

	// Methods

	// RVA: 0x856ED70 Offset: 0x856AD70 VA: 0x856ED70
	private static void .cctor() { }

	// RVA: 0x856EDD8 Offset: 0x856ADD8 VA: 0x856EDD8
	public void .ctor() { }

	// RVA: 0x856EDE0 Offset: 0x856ADE0 VA: 0x856EDE0
	internal bool <AreAllProductDetailsCached>b__9_0(bool isCached) { }

	[NullableContext(0)]
	// RVA: 0x856EDE8 Offset: 0x856ADE8 VA: 0x856EDE8
	internal bool <QueryInAppsAsync>b__11_0(ProductDefinition product) { }

	[NullableContext(0)]
	// RVA: 0x856EE08 Offset: 0x856AE08 VA: 0x856EE08
	internal string <QueryInAppsAsync>b__11_1(ProductDefinition product) { }

	[NullableContext(0)]
	// RVA: 0x856EE20 Offset: 0x856AE20 VA: 0x856EE20
	internal bool <QuerySubsAsync>b__12_0(ProductDefinition product) { }

	[NullableContext(0)]
	// RVA: 0x856EE40 Offset: 0x856AE40 VA: 0x856EE40
	internal string <QuerySubsAsync>b__12_1(ProductDefinition product) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class QueryProductDetailsService.<>c__DisplayClass13_0 // TypeDefIndex: 26298
{
	// Fields
	[Nullable(new[] { 0, 0, 1, 1, 1 })]
	public TaskCompletionSource<ValueTuple<IGoogleBillingResult, IEnumerable<AndroidJavaObject>>> taskCompletionSource; // 0x10

	// Methods

	// RVA: 0x856ED68 Offset: 0x856AD68 VA: 0x856ED68
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x856EE58 Offset: 0x856AE58 VA: 0x856EE58
	internal void <QueryProductDetails>b__0(IGoogleBillingResult billingResult, List<AndroidJavaObject> productDetails) { }
}

// Namespace: 
[CompilerGenerated]
private struct QueryProductDetailsService.<QueryInAppsAndSubsProductDetails>d__7 : IAsyncStateMachine // TypeDefIndex: 26299
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<ProductDetailsQueryResponse> <>t__builder; // 0x8
	[Nullable(0)]
	public QueryProductDetailsService <>4__this; // 0x20
	[Nullable(new[] { 0, 1 })]
	public IReadOnlyCollection<ProductDefinition> products; // 0x28
	[Nullable(new[] { 0, 1, 0, 1, 1, 1 })]
	private List<Task<ValueTuple<IGoogleBillingResult, IEnumerable<AndroidJavaObject>>>> <tasks>5__2; // 0x30
	[Nullable(0)]
	private TaskAwaiter<ValueTuple<IGoogleBillingResult, IEnumerable<AndroidJavaObject>>[]> <>u__1; // 0x38

	// Methods

	// RVA: 0x856EEF8 Offset: 0x856AEF8 VA: 0x856EEF8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x856F4D0 Offset: 0x856B4D0 VA: 0x856F4D0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct QueryProductDetailsService.<QueryProductDescriptions>d__5 : IAsyncStateMachine // TypeDefIndex: 26300
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(new[] { 0, 0, 1 })]
	public AsyncTaskMethodBuilder<List<ProductDescription>> <>t__builder; // 0x8
	[Nullable(0)]
	public QueryProductDetailsService <>4__this; // 0x20
	[Nullable(new[] { 0, 1 })]
	public IReadOnlyCollection<ProductDefinition> products; // 0x28
	[Nullable(new[] { 0, 1, 1 })]
	private TaskAwaiter<List<AndroidJavaObject>> <>u__1; // 0x30

	// Methods

	// RVA: 0x856F54C Offset: 0x856B54C VA: 0x856F54C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x856F840 Offset: 0x856B840 VA: 0x856F840 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct QueryProductDetailsService.<QueryProductDetails>d__6 : IAsyncStateMachine // TypeDefIndex: 26301
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(new[] { 0, 0, 1 })]
	public AsyncTaskMethodBuilder<List<AndroidJavaObject>> <>t__builder; // 0x8
	[Nullable(0)]
	public QueryProductDetailsService <>4__this; // 0x20
	[Nullable(new[] { 0, 1 })]
	public IReadOnlyCollection<ProductDefinition> products; // 0x28
	[Nullable(new[] { 0, 1 })]
	private TaskAwaiter<ProductDetailsQueryResponse> <>u__1; // 0x30

	// Methods

	// RVA: 0x856F8BC Offset: 0x856B8BC VA: 0x856F8BC Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x856FCC8 Offset: 0x856BCC8 VA: 0x856FCC8 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
internal class QueryProductDetailsService : IQueryProductDetailsService // TypeDefIndex: 26302
{
	// Fields
	private readonly IGoogleBillingClient m_BillingClient; // 0x10
	private readonly IGoogleCachedQueryProductDetailsService m_GoogleCachedQueryProductDetailsService; // 0x18
	private readonly IProductDetailsConverter m_ProductDetailsConverter; // 0x20

	// Methods

	[Preserve]
	// RVA: 0x856DDF4 Offset: 0x8569DF4 VA: 0x856DDF4
	internal void .ctor(IGoogleBillingClient billingClient, IGoogleCachedQueryProductDetailsService googleCachedQueryProductDetailsService, IProductDetailsConverter productDetailsConverter) { }

	// RVA: 0x856DE54 Offset: 0x8569E54 VA: 0x856DE54 Slot: 4
	public Task<List<AndroidJavaObject>> QueryProductDetails(ProductDefinition product) { }

	[AsyncStateMachine(typeof(QueryProductDetailsService.<QueryProductDescriptions>d__5))]
	// RVA: 0x856DF70 Offset: 0x8569F70 VA: 0x856DF70 Slot: 5
	public Task<List<ProductDescription>> QueryProductDescriptions(IReadOnlyCollection<ProductDefinition> products) { }

	[AsyncStateMachine(typeof(QueryProductDetailsService.<QueryProductDetails>d__6))]
	// RVA: 0x856E08C Offset: 0x856A08C VA: 0x856E08C Slot: 6
	public virtual Task<List<AndroidJavaObject>> QueryProductDetails(IReadOnlyCollection<ProductDefinition> products) { }

	[AsyncStateMachine(typeof(QueryProductDetailsService.<QueryInAppsAndSubsProductDetails>d__7))]
	// RVA: 0x856E1A8 Offset: 0x856A1A8 VA: 0x856E1A8
	private Task<ProductDetailsQueryResponse> QueryInAppsAndSubsProductDetails(IReadOnlyCollection<ProductDefinition> products) { }

	// RVA: 0x856E2C0 Offset: 0x856A2C0 VA: 0x856E2C0
	private bool ShouldRetryQuery(IEnumerable<ProductDefinition> requestedProducts, IProductDetailsQueryResponse queryResponse) { }

	// RVA: 0x856E390 Offset: 0x856A390 VA: 0x856E390
	private bool AreAllProductDetailsCached(IEnumerable<ProductDefinition> products) { }

	// RVA: 0x856E560 Offset: 0x856A560 VA: 0x856E560
	private IEnumerable<AndroidJavaObject> GetCachedProductDetails(IEnumerable<ProductDefinition> products) { }

	// RVA: 0x856E6EC Offset: 0x856A6EC VA: 0x856E6EC
	private Task<ValueTuple<IGoogleBillingResult, IEnumerable<AndroidJavaObject>>> QueryInAppsAsync(IEnumerable<ProductDefinition> products) { }

	// RVA: 0x856EB6C Offset: 0x856AB6C VA: 0x856EB6C
	private Task<ValueTuple<IGoogleBillingResult, IEnumerable<AndroidJavaObject>>> QuerySubsAsync(IEnumerable<ProductDefinition> products) { }

	// RVA: 0x856E8E8 Offset: 0x856A8E8 VA: 0x856E8E8
	private Task<ValueTuple<IGoogleBillingResult, IEnumerable<AndroidJavaObject>>> QueryProductDetails(List<string> productList, string type) { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
internal class GooglePlayPurchaseCallback : IGooglePurchaseCallback // TypeDefIndex: 26303
{
	// Fields
	[Nullable(2)]
	private IProductCache m_ProductCache; // 0x10
	[Nullable(2)]
	private IStorePurchaseCallback m_PurchaseCallback; // 0x18
	[Nullable(2)]
	private IStorePurchaseFetchCallback m_PurchaseFetchCallback; // 0x20
	[Nullable(2)]
	private IGooglePlayChangeSubscriptionCallback m_ChangeSubscriptionCallback; // 0x28
	private readonly IGooglePurchaseConverter m_GooglePurchaseConverter; // 0x30
	private readonly IUtil m_Util; // 0x38

	// Methods

	[Preserve]
	// RVA: 0x856FD44 Offset: 0x856BD44 VA: 0x856FD44
	internal void .ctor(IGooglePurchaseConverter googlePurchaseConverter, IUtil util) { }

	// RVA: 0x856FD88 Offset: 0x856BD88 VA: 0x856FD88 Slot: 12
	public void SetProductCache(IProductCache productCache) { }

	// RVA: 0x856FD90 Offset: 0x856BD90 VA: 0x856FD90 Slot: 4
	public void SetPurchaseCallback(IStorePurchaseCallback purchaseCallback) { }

	// RVA: 0x856FD98 Offset: 0x856BD98 VA: 0x856FD98 Slot: 5
	public void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchCallback) { }

	// RVA: 0x856FDA0 Offset: 0x856BDA0 VA: 0x856FDA0 Slot: 6
	public void SetChangeSubscriptionCallback(IGooglePlayChangeSubscriptionCallback changeSubscriptionCallback) { }

	// RVA: 0x856FDA8 Offset: 0x856BDA8 VA: 0x856FDA8 Slot: 7
	public void OnPurchaseSuccessful(IGooglePurchase purchase) { }

	// RVA: 0x856FE6C Offset: 0x856BE6C VA: 0x856FE6C
	private void OnOrderPurchaseSuccessful(Order order) { }

	// RVA: 0x85700C4 Offset: 0x856C0C4 VA: 0x85700C4 Slot: 8
	public void OnPurchaseFailed(PurchaseFailureDescription purchaseFailureDescription) { }

	// RVA: 0x85701A8 Offset: 0x856C1A8 VA: 0x85701A8 Slot: 9
	public void NotifyDeferredPurchase(IGooglePurchase purchase) { }

	// RVA: 0x857033C Offset: 0x856C33C VA: 0x857033C Slot: 10
	public void NotifyDeferredProrationUpgradeDowngradeSubscription(string sku) { }

	// RVA: 0x85703EC Offset: 0x856C3EC VA: 0x85703EC Slot: 11
	public void NotifyUpgradeDowngradeSubscription(string sku) { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
internal class GooglePlayStore : InternalStore, IGooglePlayStore, IStore // TypeDefIndex: 26304
{
	// Fields
	private readonly IGooglePlayStoreConnectionService m_ConnectionService; // 0x58
	private readonly IGooglePlayStoreFetchProductsService m_FetchProductsService; // 0x60
	private readonly IGooglePlayStorePurchaseService m_StorePurchaseService; // 0x68
	private readonly IGooglePlayStoreFetchPurchasesService m_PlayStoreFetchPurchasesService; // 0x70
	private readonly IGooglePlayStoreCheckEntitlementService m_CheckEntitlementsService; // 0x78
	private readonly IGooglePlayStoreFinishTransactionService m_FinishTransactionService; // 0x80
	private readonly IGooglePlayStoreChangeSubscriptionService m_ChangeSubscriptionService; // 0x88
	private readonly IGooglePurchaseCallback m_GooglePurchaseCallback; // 0x90
	private readonly ICartValidator m_CartValidator; // 0x98
	internal IGoogleBillingClient m_BillingClient; // 0xA0

	// Methods

	[Preserve]
	// RVA: 0x85704A0 Offset: 0x856C4A0 VA: 0x85704A0
	internal void .ctor(IGooglePlayStoreFetchProductsService fetchProductsService, IGooglePlayStorePurchaseService storePurchaseService, IGooglePlayStoreFetchPurchasesService playStoreFetchPurchasesService, IGooglePlayStoreFinishTransactionService transactionService, IGooglePlayStoreChangeSubscriptionService changeSubscriptionService, IGooglePlayStoreCheckEntitlementService checkEntitlementsService, IGooglePurchaseCallback googlePurchaseCallback, ICartValidator cartValidator, IGooglePlayStoreConnectionService connectionService, IGoogleBillingClient billingClient) { }

	// RVA: 0x85705A0 Offset: 0x856C5A0 VA: 0x85705A0 Slot: 17
	public override void FetchProducts(IReadOnlyCollection<ProductDefinition> products) { }

	// RVA: 0x8570648 Offset: 0x856C648 VA: 0x8570648 Slot: 18
	public override void FetchPurchases() { }

	// RVA: 0x857064C Offset: 0x856C64C VA: 0x857064C
	private void FetchPurchasesInternal() { }

	// RVA: 0x85706F0 Offset: 0x856C6F0 VA: 0x85706F0 Slot: 19
	public override void Purchase(ICart cart) { }

	// RVA: 0x85708AC Offset: 0x856C8AC VA: 0x85708AC Slot: 20
	public override void FinishTransaction(PendingOrder pendingOrder) { }

	// RVA: 0x8570B00 Offset: 0x856CB00 VA: 0x8570B00 Slot: 16
	public override void Connect() { }

	// RVA: 0x8570BA0 Offset: 0x856CBA0 VA: 0x8570BA0 Slot: 21
	public override void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchPurchaseCallback) { }

	// RVA: 0x8570CC8 Offset: 0x856CCC8 VA: 0x8570CC8 Slot: 22
	public override void SetPurchaseCallback(IStorePurchaseCallback purchaseCallback) { }

	// RVA: 0x8570D70 Offset: 0x856CD70 VA: 0x8570D70 Slot: 30
	public void SetChangeSubscriptionCallback(IGooglePlayChangeSubscriptionCallback changeSubscriptionCallback) { }

	// RVA: 0x8570E1C Offset: 0x856CE1C VA: 0x8570E1C Slot: 23
	public override void SetPurchaseConfirmCallback(IStorePurchaseConfirmCallback confirmCallback) { }

	// RVA: 0x8570EC8 Offset: 0x856CEC8 VA: 0x8570EC8 Slot: 25
	public override void SetProductsCallback(IStoreProductsCallback productsCallback) { }

	// RVA: 0x8570F74 Offset: 0x856CF74 VA: 0x8570F74 Slot: 26
	public override void SetEntitlementCheckCallback(IStoreCheckEntitlementCallback entitlementCallback) { }

	// RVA: 0x857101C Offset: 0x856D01C VA: 0x857101C Slot: 24
	public override void SetStoreConnectionCallback(IStoreConnectCallback storeConnectCallback) { }

	// RVA: 0x85710C8 Offset: 0x856D0C8 VA: 0x85710C8 Slot: 31
	public void OnPause(bool isPaused) { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
internal class GooglePurchaseConverter : IGooglePurchaseConverter // TypeDefIndex: 26305
{
	// Methods

	[Preserve]
	// RVA: 0x85710D4 Offset: 0x856D0D4 VA: 0x85710D4
	internal void .ctor(IProductDetailsConverter productDetailsConverter) { }

	// RVA: 0x85710DC Offset: 0x856D0DC VA: 0x85710DC Slot: 4
	public Order CreateOrderFromPurchase(IGooglePurchase purchase, IProductCache productCache) { }

	// RVA: 0x857172C Offset: 0x856D72C VA: 0x857172C
	private static ProductType GetProductType(ICart cart) { }

	// RVA: 0x8571494 Offset: 0x856D494 VA: 0x8571494 Slot: 5
	public ICart CreateCartFromPurchase(IGooglePurchase purchase, IProductCache productCache) { }

	// RVA: 0x8571854 Offset: 0x856D854 VA: 0x8571854
	private Product DefaultProduct(IGooglePurchase purchase) { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
internal interface IGooglePurchaseConverter // TypeDefIndex: 26306
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Order CreateOrderFromPurchase(IGooglePurchase purchase, IProductCache productCache);
}

// Namespace: UnityEngine.Purchasing
internal class GooglePlayStoreChangeSubscriptionService : IGooglePlayStoreChangeSubscriptionService // TypeDefIndex: 26307
{
	// Fields
	private readonly IGooglePlayStoreService m_GooglePlayStoreService; // 0x10

	// Methods

	[Preserve]
	// RVA: 0x8571A54 Offset: 0x856DA54 VA: 0x8571A54
	internal void .ctor(IGooglePlayStoreService googlePlayStoreService) { }
}

// Namespace: UnityEngine.Purchasing
internal class GooglePlayStoreCheckEntitlementService : IGooglePlayStoreCheckEntitlementService // TypeDefIndex: 26308
{
	// Fields
	private readonly IGooglePlayStoreService m_GooglePlayStoreService; // 0x10
	private IStoreCheckEntitlementCallback m_EntitlementCallback; // 0x18

	// Methods

	[Preserve]
	// RVA: 0x8571A84 Offset: 0x856DA84 VA: 0x8571A84
	internal void .ctor(IGooglePlayStoreService googlePlayStoreService) { }

	// RVA: 0x8571AB4 Offset: 0x856DAB4 VA: 0x8571AB4 Slot: 4
	public void SetCheckEntitlementCallback(IStoreCheckEntitlementCallback entitlementCallback) { }
}

// Namespace: UnityEngine.Purchasing
internal class GooglePlayStoreConnectionService : IGooglePlayStoreConnectionService // TypeDefIndex: 26309
{
	// Fields
	private readonly IGoogleBillingClient m_BillingClient; // 0x10
	private readonly IBillingClientStateListener m_BillingClientStateListener; // 0x18
	private IStoreConnectCallback m_ConnectCallback; // 0x20

	// Methods

	[Preserve]
	// RVA: 0x8571ABC Offset: 0x856DABC VA: 0x8571ABC
	public void .ctor(IGoogleBillingClient billingClient, IBillingClientStateListener billingClientStateListener) { }

	// RVA: 0x8571B00 Offset: 0x856DB00 VA: 0x8571B00 Slot: 4
	public void Connect() { }

	// RVA: 0x8571D20 Offset: 0x856DD20 VA: 0x8571D20 Slot: 5
	public void SetConnectionCallback(IStoreConnectCallback storeConnectCallback) { }

	// RVA: 0x8571D28 Offset: 0x856DD28 VA: 0x8571D28
	private void OnConnected() { }

	// RVA: 0x8571DC8 Offset: 0x856DDC8 VA: 0x8571DC8
	private void OnDisconnected(GoogleBillingResponseCode responseCode) { }
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
internal class GooglePlayStoreFetchProductsService : IGooglePlayStoreFetchProductsService // TypeDefIndex: 26310
{
	// Fields
	private readonly IGooglePlayStoreService m_GooglePlayStoreService; // 0x10
	[Nullable(2)]
	private IStoreProductsCallback m_ProductsCallback; // 0x18

	// Methods

	[Preserve]
	// RVA: 0x8571EBC Offset: 0x856DEBC VA: 0x8571EBC
	internal void .ctor(IGooglePlayStoreService googlePlayStoreService) { }

	// RVA: 0x8571EEC Offset: 0x856DEEC VA: 0x8571EEC Slot: 4
	public void FetchProducts(IReadOnlyCollection<ProductDefinition> products) { }

	// RVA: 0x8572034 Offset: 0x856E034 VA: 0x8572034
	private void OnProductsFetched(List<ProductDescription> retrievedProducts) { }

	// RVA: 0x85720E4 Offset: 0x856E0E4 VA: 0x85720E4
	private void OnFetchProductsFailed(GoogleFetchProductException exception) { }

	// RVA: 0x85721A4 Offset: 0x856E1A4 VA: 0x85721A4 Slot: 5
	public void SetProductsCallback(IStoreProductsCallback productsCallback) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class GooglePlayStoreFetchPurchasesService.<>c // TypeDefIndex: 26311
{
	// Fields
	[Nullable(0)]
	public static readonly GooglePlayStoreFetchPurchasesService.<>c <>9; // 0x0
	[Nullable(new[] { 0, 1 })]
	public static Func<IGooglePurchase, bool> <>9__17_0; // 0x8

	// Methods

	// RVA: 0x8572CBC Offset: 0x856ECBC VA: 0x8572CBC
	private static void .cctor() { }

	// RVA: 0x8572D24 Offset: 0x856ED24 VA: 0x8572D24
	public void .ctor() { }

	// RVA: 0x8572D2C Offset: 0x856ED2C VA: 0x8572D2C
	internal bool <PurchaseIsPending>b__17_0(IGooglePurchase purchase) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GooglePlayStoreFetchPurchasesService.<>c__DisplayClass14_0 // TypeDefIndex: 26312
{
	// Fields
	[Nullable(0)]
	public GooglePlayStoreFetchPurchasesService <>4__this; // 0x10
	[Nullable(0)]
	public List<IGooglePurchase> deferredPurchases; // 0x18

	// Methods

	// RVA: 0x8572624 Offset: 0x856E624 VA: 0x8572624
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x8572DCC Offset: 0x856EDCC VA: 0x8572DCC
	internal Order <OnPurchasesFetched>b__0(IGooglePurchase purchase) { }

	// RVA: 0x8572E84 Offset: 0x856EE84 VA: 0x8572E84
	internal void <OnPurchasesFetched>b__1() { }
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
internal class GooglePlayStoreFetchPurchasesService : IGooglePlayStoreFetchPurchasesService // TypeDefIndex: 26313
{
	// Fields
	private readonly IGooglePlayStoreService m_GooglePlayStoreService; // 0x10
	private readonly IGooglePurchaseConverter m_PurchaseConverter; // 0x18
	[Nullable(2)]
	private IProductCache m_ProductCache; // 0x20
	[Nullable(2)]
	private IStorePurchaseFetchCallback m_FetchCallback; // 0x28
	private IUtil m_Util; // 0x30

	// Methods

	[Preserve]
	// RVA: 0x85721AC Offset: 0x856E1AC VA: 0x85721AC
	internal void .ctor(IGooglePlayStoreService googlePlayStoreService, IGooglePlayStoreFinishTransactionService transactionService, IGooglePurchaseConverter purchaseConverter, IUtil util) { }

	// RVA: 0x857220C Offset: 0x856E20C VA: 0x857220C Slot: 4
	public void SetProductCache(IProductCache productCache) { }

	// RVA: 0x8572214 Offset: 0x856E214 VA: 0x8572214 Slot: 5
	public void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchCallback) { }

	// RVA: 0x857221C Offset: 0x856E21C VA: 0x857221C Slot: 6
	public void FetchPurchases() { }

	// RVA: 0x8572360 Offset: 0x856E360 VA: 0x8572360
	private void OnPurchasesFetched(List<IGooglePurchase> purchases) { }

	[NullableContext(2)]
	// RVA: 0x857262C Offset: 0x856E62C VA: 0x857262C
	private void PurchaseRetrievalFailedForUnknownReasons(string message) { }

	// RVA: 0x8572740 Offset: 0x856E740 VA: 0x8572740
	private static Func<IGooglePurchase, bool> PurchaseIsPending() { }

	// RVA: 0x8572810 Offset: 0x856E810 VA: 0x8572810
	private void UpdateDeferredProductsByPurchases(List<IGooglePurchase> deferredPurchases) { }

	// RVA: 0x857294C Offset: 0x856E94C VA: 0x857294C
	private void UpdateDeferredProductsByPurchase(IGooglePurchase deferredPurchase) { }

	// RVA: 0x8572AFC Offset: 0x856EAFC VA: 0x8572AFC
	private void UpdateDeferredProduct(IGooglePurchase deferredPurchase, string sku) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GooglePlayStoreFinishTransactionService.<>c__DisplayClass9_0 // TypeDefIndex: 26314
{
	// Fields
	[Nullable(0)]
	public GooglePlayStoreFinishTransactionService <>4__this; // 0x10
	[Nullable(0)]
	public ProductDefinition product; // 0x18

	// Methods

	// RVA: 0x8573914 Offset: 0x856F914 VA: 0x8573914
	public void .ctor() { }

	// RVA: 0x857391C Offset: 0x856F91C VA: 0x857391C
	internal void <FinishTransaction>b__0(IGoogleBillingResult billingResult, IGooglePurchase googlePurchase) { }
}

// Namespace: 
[CompilerGenerated]
private struct GooglePlayStoreFinishTransactionService.<FinishTransaction>d__9 : IAsyncStateMachine // TypeDefIndex: 26315
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public GooglePlayStoreFinishTransactionService <>4__this; // 0x28
	[Nullable(0)]
	public ProductDefinition product; // 0x30
	[Nullable(0)]
	public string purchaseToken; // 0x38
	[Nullable(0)]
	private GooglePlayStoreFinishTransactionService.<>c__DisplayClass9_0 <>8__1; // 0x40
	private TaskAwaiter <>u__1; // 0x48

	// Methods

	// RVA: 0x8573944 Offset: 0x856F944 VA: 0x8573944 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x8573E54 Offset: 0x856FE54 VA: 0x8573E54 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
internal class GooglePlayStoreFinishTransactionService : IGooglePlayStoreFinishTransactionService // TypeDefIndex: 26316
{
	// Fields
	[Nullable(new[] { 1, 2 })]
	private readonly HashSet<string> m_ProcessedPurchaseToken; // 0x10
	private readonly IGooglePlayStoreService m_GooglePlayStoreService; // 0x18
	[Nullable(2)]
	private IProductCache m_ProductCache; // 0x20
	[Nullable(2)]
	private IStorePurchaseConfirmCallback m_ConfirmCallback; // 0x28
	private int m_RetryCount; // 0x30

	// Methods

	[Preserve]
	// RVA: 0x8572EA4 Offset: 0x856EEA4 VA: 0x8572EA4
	internal void .ctor(IGooglePlayStoreService googlePlayStoreService) { }

	[NullableContext(2)]
	// RVA: 0x8572F40 Offset: 0x856EF40 VA: 0x8572F40 Slot: 4
	public void SetProductCache(IProductCache productCache) { }

	// RVA: 0x8572F48 Offset: 0x856EF48 VA: 0x8572F48 Slot: 5
	public void SetConfirmCallback(IStorePurchaseConfirmCallback confirmCallback) { }

	[AsyncStateMachine(typeof(GooglePlayStoreFinishTransactionService.<FinishTransaction>d__9))]
	// RVA: 0x8572F50 Offset: 0x856EF50 VA: 0x8572F50 Slot: 6
	public void FinishTransaction(ProductDefinition product, string purchaseToken) { }

	// RVA: 0x8573038 Offset: 0x856F038 VA: 0x8573038
	private void HandleFinishTransaction(ProductDefinition product, IGoogleBillingResult billingResult, IGooglePurchase purchase) { }

	// RVA: 0x8573834 Offset: 0x856F834 VA: 0x8573834
	private void SendTransactionFailedCallback(PurchaseFailureDescription purchaseFailureDescription, string purchaseToken) { }

	// RVA: 0x8573598 Offset: 0x856F598 VA: 0x8573598
	private void CallPurchaseSucceededUpdateReceipt(IGooglePurchase googlePurchase) { }

	// RVA: 0x85736C4 Offset: 0x856F6C4 VA: 0x85736C4
	private static bool IsResponseCodeInRecoverableState(IGoogleBillingResult billingResult) { }
}

// Namespace: UnityEngine.Purchasing
internal class GooglePlayStorePurchaseService : IGooglePlayStorePurchaseService // TypeDefIndex: 26317
{
	// Fields
	private readonly IGooglePlayStoreService m_GooglePlayStoreService; // 0x10

	// Methods

	[Preserve]
	// RVA: 0x8573E60 Offset: 0x856FE60 VA: 0x8573E60
	internal void .ctor(IGooglePlayStoreService googlePlayStoreService) { }

	// RVA: 0x8573E90 Offset: 0x856FE90 VA: 0x8573E90 Slot: 4
	public void Purchase(ProductDefinition product) { }
}

// Namespace: UnityEngine.Purchasing
internal interface IGooglePlayStoreChangeSubscriptionService // TypeDefIndex: 26318
{}

// Namespace: UnityEngine.Purchasing
internal interface IGooglePlayStoreConnectionService // TypeDefIndex: 26319
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Connect();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetConnectionCallback(IStoreConnectCallback storeConnectCallback);
}

// Namespace: UnityEngine.Purchasing
internal interface IGooglePlayStoreFetchProductsService // TypeDefIndex: 26320
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void FetchProducts(IReadOnlyCollection<ProductDefinition> products);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetProductsCallback(IStoreProductsCallback productsCallback);
}

// Namespace: UnityEngine.Purchasing
internal interface IGooglePlayStoreFetchPurchasesService // TypeDefIndex: 26321
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetProductCache(IProductCache productCache);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchCallback);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void FetchPurchases();
}

// Namespace: UnityEngine.Purchasing
internal interface IGooglePlayStoreFinishTransactionService // TypeDefIndex: 26322
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetProductCache(IProductCache productCache);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetConfirmCallback(IStorePurchaseConfirmCallback confirmCallback);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void FinishTransaction(ProductDefinition product, string purchaseToken);
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
internal interface IGooglePlayStorePurchaseService // TypeDefIndex: 26323
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Purchase(ProductDefinition product);
}

// Namespace: 
[CompilerGenerated]
private sealed class AppleFetchProductsService.<>c__DisplayClass8_0 // TypeDefIndex: 26324
{
	// Fields
	[Nullable(0)]
	public AppleFetchProductsService <>4__this; // 0x10
	[Nullable(new[] { 0, 1 })]
	public IReadOnlyCollection<ProductDefinition> products; // 0x18

	// Methods

	// RVA: 0x8574048 Offset: 0x8570048 VA: 0x8574048
	public void .ctor() { }

	// RVA: 0x85743B0 Offset: 0x85703B0 VA: 0x85743B0
	internal Task<List<ProductDescription>> <FetchProducts>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private struct AppleFetchProductsService.<ExecuteFetchProductsRequest>d__10 : IAsyncStateMachine // TypeDefIndex: 26325
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(new[] { 0, 0, 1 })]
	public AsyncTaskMethodBuilder<List<ProductDescription>> <>t__builder; // 0x8
	[Nullable(0)]
	public AppleFetchProductsService <>4__this; // 0x20
	[Nullable(new[] { 0, 1 })]
	public IReadOnlyCollection<ProductDefinition> products; // 0x28
	[Nullable(new[] { 0, 1, 1 })]
	private TaskAwaiter<List<ProductDescription>> <>u__1; // 0x30

	// Methods

	// RVA: 0x85743D0 Offset: 0x85703D0 VA: 0x85743D0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x8574800 Offset: 0x8570800 VA: 0x8574800 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: UnityEngine.Purchasing
[Preserve]
[Nullable(0)]
[NullableContext(1)]
internal class AppleFetchProductsService : IAppleFetchProductsService // TypeDefIndex: 26326
{
	// Fields
	[Nullable(2)]
	private INativeAppleStore m_NativeStore; // 0x10
	[Nullable(2)]
	[CompilerGenerated]
	private string <LastRequestProductsJson>k__BackingField; // 0x18
	private readonly TaskQueue queue; // 0x20
	[Nullable(new[] { 2, 1, 1 })]
	private TaskCompletionSource<List<ProductDescription>> m_CurrentRequestCompletionSource; // 0x28

	// Properties
	[Nullable(2)]
	private string LastRequestProductsJson { set; }

	// Methods

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x8573F3C Offset: 0x856FF3C VA: 0x8573F3C
	private void set_LastRequestProductsJson(string value) { }

	// RVA: 0x8573F44 Offset: 0x856FF44 VA: 0x8573F44 Slot: 4
	public void SetNativeStore(INativeAppleStore nativeStore) { }

	// RVA: 0x8573F4C Offset: 0x856FF4C VA: 0x8573F4C Slot: 8
	public virtual Task<List<ProductDescription>> FetchProducts(IReadOnlyCollection<ProductDefinition> products) { }

	// RVA: 0x8574050 Offset: 0x8570050 VA: 0x8574050
	private void ValidateThatRequestIsPossible() { }

	[AsyncStateMachine(typeof(AppleFetchProductsService.<ExecuteFetchProductsRequest>d__10))]
	// RVA: 0x85740AC Offset: 0x85700AC VA: 0x85740AC
	private Task<List<ProductDescription>> ExecuteFetchProductsRequest(IReadOnlyCollection<ProductDefinition> products) { }

	// RVA: 0x85741C8 Offset: 0x85701C8 VA: 0x85741C8 Slot: 6
	public void OnProductsFetched(string json) { }

	// RVA: 0x8574248 Offset: 0x8570248 VA: 0x8574248 Slot: 7
	public void OnProductDetailsRetrieveFailed(string errorMessage) { }

	// RVA: 0x8574344 Offset: 0x8570344 VA: 0x8574344
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class AppleStoreImpl.<>c // TypeDefIndex: 26327
{
	// Fields
	[Nullable(0)]
	public static readonly AppleStoreImpl.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<KeyValuePair<string, object>, string> <>9__52_0; // 0x8
	[Nullable(0)]
	public static Func<KeyValuePair<string, object>, string> <>9__52_1; // 0x10
	[Nullable(0)]
	public static Func<CartItem, bool> <>9__72_0; // 0x18

	// Methods

	// RVA: 0x8578160 Offset: 0x8574160 VA: 0x8578160
	private static void .cctor() { }

	// RVA: 0x85781C8 Offset: 0x85741C8 VA: 0x85781C8
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x85781D0 Offset: 0x85741D0 VA: 0x85781D0
	internal string <OnFetchStorePromotionVisibilitySucceeded>b__52_0(KeyValuePair<string, object> k) { }

	[NullableContext(0)]
	// RVA: 0x857820C Offset: 0x857420C VA: 0x857820C
	internal string <OnFetchStorePromotionVisibilitySucceeded>b__52_1(KeyValuePair<string, object> k) { }

	[NullableContext(0)]
	// RVA: 0x8578258 Offset: 0x8574258 VA: 0x8578258
	internal bool <InvokeErrorIfRepurchasedConsumables>b__72_0(CartItem item) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AppleStoreImpl.<>c__DisplayClass22_0 // TypeDefIndex: 26328
{
	// Fields
	[Nullable(0)]
	public INativeAppleStore apple; // 0x10

	// Methods

	// RVA: 0x8574DA4 Offset: 0x8570DA4 VA: 0x8574DA4
	public void .ctor() { }

	// RVA: 0x8578288 Offset: 0x8574288 VA: 0x8578288
	internal void <SetNativeStore>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AppleStoreImpl.<>c__DisplayClass54_0 // TypeDefIndex: 26329
{
	// Fields
	public IntPtr subjectPtr; // 0x10
	public IntPtr payloadPtr; // 0x18
	public int entitlementStatus; // 0x20

	// Methods

	// RVA: 0x85769D8 Offset: 0x85729D8 VA: 0x85769D8
	public void .ctor() { }

	// RVA: 0x857832C Offset: 0x857432C VA: 0x857832C
	internal void <MessageCallback>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private struct AppleStoreImpl.<FetchProducts>d__29 : IAsyncStateMachine // TypeDefIndex: 26330
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public AppleStoreImpl <>4__this; // 0x28
	[Nullable(new[] { 0, 1 })]
	public IReadOnlyCollection<ProductDefinition> products; // 0x30
	[Nullable(new[] { 0, 1, 1 })]
	private TaskAwaiter<List<ProductDescription>> <>u__1; // 0x38

	// Methods

	// RVA: 0x8578390 Offset: 0x8574390 VA: 0x8578390 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x8578998 Offset: 0x8574998 VA: 0x8578998 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct AppleStoreImpl.<OnPurchaseSucceeded>d__63 : IAsyncStateMachine // TypeDefIndex: 26331
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public AppleStoreImpl <>4__this; // 0x28
	[Nullable(0)]
	public string purchaseDetailsJson; // 0x30
	[Nullable(0)]
	private TaskAwaiter<bool> <>u__1; // 0x38

	// Methods

	// RVA: 0x85789A4 Offset: 0x85749A4 VA: 0x85789A4 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x8578EEC Offset: 0x8574EEC VA: 0x8578EEC Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
internal class AppleStoreImpl : JsonStore, IAppleStoreCallbacks, IAppleAppReceiptViewer // TypeDefIndex: 26332
{
	// Fields
	[Nullable(2)]
	private Action<bool, string> m_RestoreCallback; // 0x88
	[Nullable(new[] { 2, 1 })]
	private Action<string> m_FetchStorePromotionOrderError; // 0x90
	[Nullable(new[] { 2, 1, 1 })]
	private Action<List<Product>> m_FetchStorePromotionOrderSuccess; // 0x98
	[Nullable(new[] { 2, 1 })]
	private Action<string> m_FetchStorePromotionVisibilityError; // 0xA0
	[Nullable(new[] { 2, 1 })]
	private Action<string, AppleStorePromotionVisibility> m_FetchStorePromotionVisibilitySuccess; // 0xA8
	[Nullable(new[] { 2, 1 })]
	private Action<string> m_RefreshAppReceiptSuccessCallback; // 0xB0
	[Nullable(new[] { 2, 1 })]
	private Action<string> m_RefreshAppReceiptErrorCallback; // 0xB8
	[Nullable(2)]
	private TaskCompletionSource<bool> m_RefreshAppReceiptTask; // 0xC0
	private bool m_RefreshAppReceipt; // 0xC8
	[Nullable(2)]
	private INativeAppleStore m_Native; // 0xD0
	private readonly IAppleFetchProductsService m_FetchProductsService; // 0xD8
	private readonly ITransactionLog m_TransactionLog; // 0xE0
	[Nullable(2)]
	private static IUtil s_Util; // 0x0
	[Nullable(2)]
	private static AppleStoreImpl s_Instance; // 0x8
	[Nullable(2)]
	private string appReceipt; // 0xE8
	private bool m_IsTransactionObserverEnabled; // 0xF0
	private Guid m_AppAccountToken; // 0xF4
	[CompilerGenerated]
	[Nullable(new[] { 2, 1 })]
	private Action<Product> OnPromotionalPurchaseIntercepted; // 0x108
	[CompilerGenerated]
	private bool <simulateAskToBuy>k__BackingField; // 0x110

	// Properties
	public bool simulateAskToBuy { get; }

	// Methods

	// RVA: 0x85749D4 Offset: 0x85709D4 VA: 0x85749D4
	protected void .ctor(ICartValidator cartValidator, IAppleFetchProductsService fetchProductsService, ITransactionLog transactionLog, IUtil util, ILogger logger, ITelemetryDiagnostics telemetryDiagnostics) { }

	// RVA: 0x8574B50 Offset: 0x8570B50 VA: 0x8574B50
	public void SetNativeStore(INativeAppleStore apple) { }

	[NullableContext(2)]
	// RVA: 0x8574DAC Offset: 0x8570DAC VA: 0x8574DAC
	public INativeAppleStore GetNativeStore() { }

	[NullableContext(2)]
	// RVA: 0x8574DB4 Offset: 0x8570DB4 VA: 0x8574DB4 Slot: 39
	public string AppReceipt() { }

	// RVA: 0x8574DBC Offset: 0x8570DBC VA: 0x8574DBC Slot: 16
	public override void Connect() { }

	// RVA: 0x8574ED8 Offset: 0x8570ED8 VA: 0x8574ED8 Slot: 32
	protected override void FinishTransaction(ProductDefinition productDefinition, string transactionId) { }

	// RVA: 0x857507C Offset: 0x857107C VA: 0x857507C Slot: 19
	public override void Purchase(ICart cart) { }

	// RVA: 0x85751E4 Offset: 0x85711E4 VA: 0x85751E4
	private string PurchaseOptions() { }

	[AsyncStateMachine(typeof(AppleStoreImpl.<FetchProducts>d__29))]
	// RVA: 0x8575324 Offset: 0x8571324 VA: 0x8575324 Slot: 17
	public override void FetchProducts(IReadOnlyCollection<ProductDefinition> products) { }

	// RVA: 0x85753F4 Offset: 0x85713F4 VA: 0x85753F4 Slot: 18
	public override void FetchPurchases() { }

	[NullableContext(2)]
	// RVA: 0x85754A0 Offset: 0x85714A0 VA: 0x85754A0 Slot: 37
	public void SetRestoreTransactionsCallback(Action<bool, string> successCallback) { }

	[CompilerGenerated]
	// RVA: 0x85754A8 Offset: 0x85714A8 VA: 0x85754A8 Slot: 40
	public bool get_simulateAskToBuy() { }

	// RVA: 0x85754B0 Offset: 0x85714B0 VA: 0x85754B0 Slot: 38
	public void SetAppAccountToken(Guid value) { }

	// RVA: 0x85754BC Offset: 0x85714BC VA: 0x85754BC Slot: 36
	public override void OnPurchaseDeferred(string productDetails) { }

	// RVA: 0x8575734 Offset: 0x8571734 VA: 0x8575734
	private void OnPromotionalPurchaseAttempted(string payload) { }

	// RVA: 0x8575814 Offset: 0x8571814 VA: 0x8575814 Slot: 30
	public override void OnPurchasesFetched(string json) { }

	// RVA: 0x85758E0 Offset: 0x85718E0 VA: 0x85758E0
	private List<Order> CreateOrdersFromFetchedPurchases(Dictionary<string, Dictionary<string, object>> fetchedPurchases) { }

	// RVA: 0x8575A64 Offset: 0x8571A64 VA: 0x8575A64
	private List<Order> GenerateOrdersFromProducts(Dictionary<string, object> transactions, bool isPending) { }

	// RVA: 0x8575F24 Offset: 0x8571F24 VA: 0x8575F24
	private static OwnershipType OwnershipTypeFromString(string ownershipTypeString) { }

	// RVA: 0x8576230 Offset: 0x8572230 VA: 0x8576230
	private void OnTransactionsRestoredSuccess() { }

	// RVA: 0x8576254 Offset: 0x8572254 VA: 0x8576254
	private void OnTransactionsRestoredFail(string error) { }

	// RVA: 0x8576278 Offset: 0x8572278 VA: 0x8576278
	private void OnEntitlementRevoked(string purchaseDetailsJson) { }

	// RVA: 0x85762E4 Offset: 0x85722E4 VA: 0x85762E4
	private void RevokeEntitlement(string productId) { }

	// RVA: 0x8576394 Offset: 0x8572394 VA: 0x8576394
	private void OnFetchStorePromotionOrderSucceeded(string productIds) { }

	// RVA: 0x85766A0 Offset: 0x85726A0 VA: 0x85766A0
	private void OnFetchStorePromotionOrderFailed(string error) { }

	// RVA: 0x85766BC Offset: 0x85726BC VA: 0x85766BC
	private void OnFetchStorePromotionVisibilitySucceeded(string result) { }

	// RVA: 0x85769BC Offset: 0x85729BC VA: 0x85769BC
	private void OnFetchStorePromotionVisibilityFailed(string error) { }

	[MonoPInvokeCallback(typeof(UnityPurchasingCallback))]
	// RVA: 0x857487C Offset: 0x857087C VA: 0x857487C
	private static void MessageCallback(IntPtr subjectPtr, IntPtr payloadPtr, int entitlementStatus) { }

	// RVA: 0x85769E0 Offset: 0x85729E0 VA: 0x85769E0
	private void ProcessCallbackMessage(IntPtr subjectPtr, IntPtr payloadPtr, int entitlementStatus) { }

	// RVA: 0x85770C0 Offset: 0x85730C0 VA: 0x85770C0
	private string ConvertPtrToString(IntPtr subjectPtr) { }

	// RVA: 0x85777F0 Offset: 0x85737F0 VA: 0x85777F0
	private void OnAppReceiptRetrieved(string receipt) { }

	// RVA: 0x8577880 Offset: 0x8573880 VA: 0x8577880
	private void OnAppReceiptRefreshedFailed(string error) { }

	// RVA: 0x8577590 Offset: 0x8573590 VA: 0x8577590
	private void OnCheckEntitlement(string productId, int entitlementStatus) { }

	[AsyncStateMachine(typeof(AppleStoreImpl.<OnPurchaseSucceeded>d__63))]
	// RVA: 0x85771FC Offset: 0x85731FC VA: 0x85771FC
	private void OnPurchaseSucceeded(string purchaseDetailsJson) { }

	// RVA: 0x85778FC Offset: 0x85738FC VA: 0x85778FC
	private Task<bool> RefreshAppReceiptAsync() { }

	// RVA: 0x8577A14 Offset: 0x8573A14 VA: 0x8577A14
	private void ProcessValidPurchase(string id, string transactionId, string originalTransactionId, string expirationDate, OwnershipType ownershipType, Nullable<Guid> appAccountToken, string signatureJws) { }

	// RVA: 0x8577B68 Offset: 0x8573B68 VA: 0x8577B68
	private void ProcessNewPurchase(string id, string transactionId, string originalTransactionId, string expirationDate, OwnershipType ownershipType, Nullable<Guid> appAccountToken, string signatureJws) { }

	// RVA: 0x8577C90 Offset: 0x8573C90 VA: 0x8577C90
	private void ProcessLoggedPurchase(string id, string transactionId, string originalTransactionId, string expirationDate, OwnershipType ownershipType, Nullable<Guid> appAccountToken, string signatureJws) { }

	// RVA: 0x85755F4 Offset: 0x85715F4 VA: 0x85755F4
	private DeferredOrder GenerateAppleDeferredOrder(string id, string transactionID, string originalTransactionId, OwnershipType ownershipType, Nullable<Guid> appAccountToken, string signatureJws) { }

	// RVA: 0x8575FB0 Offset: 0x8571FB0 VA: 0x8575FB0
	private PendingOrder GenerateApplePendingOrder(string id, string transactionID, string originalTransactionId, OwnershipType ownershipType, Nullable<Guid> appAccountToken, string signatureJws) { }

	// RVA: 0x85760F0 Offset: 0x85720F0 VA: 0x85760F0
	private ConfirmedOrder GenerateAppleConfirmedOrder(string id, string transactionID, string originalTransactionId, OwnershipType ownershipType, Nullable<Guid> appAccountToken, string signatureJws) { }

	// RVA: 0x8577CD0 Offset: 0x8573CD0 VA: 0x8577CD0
	private void EnsureConfirmedOrderIsFinished(ConfirmedOrder confirmedOrder) { }

	// RVA: 0x8577EF4 Offset: 0x8573EF4 VA: 0x8577EF4
	private void InvokeErrorIfRepurchasedConsumables(ConfirmedOrder confirmedOrder) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MetricizedAppleStoreImpl.<>c__DisplayClass2_0 // TypeDefIndex: 26333
{
	// Fields
	[Nullable(0)]
	public MetricizedAppleStoreImpl <>4__this; // 0x10
	[Nullable(new[] { 0, 1 })]
	public IReadOnlyCollection<ProductDefinition> products; // 0x18

	// Methods

	// RVA: 0x85790A4 Offset: 0x85750A4 VA: 0x85790A4
	public void .ctor() { }

	// RVA: 0x857923C Offset: 0x857523C VA: 0x857923C
	internal void <FetchProducts>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MetricizedAppleStoreImpl.<>c__DisplayClass3_0 // TypeDefIndex: 26334
{
	// Fields
	[Nullable(0)]
	public MetricizedAppleStoreImpl <>4__this; // 0x10
	[Nullable(0)]
	public ICart cart; // 0x18

	// Methods

	// RVA: 0x857922C Offset: 0x857522C VA: 0x857922C
	public void .ctor() { }

	// RVA: 0x857925C Offset: 0x857525C VA: 0x857925C
	internal void <Purchase>b__0() { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
internal class MetricizedAppleStoreImpl : AppleStoreImpl // TypeDefIndex: 26335
{
	// Fields
	private readonly ITelemetryMetricsService m_TelemetryMetricsService; // 0x118

	// Methods

	[Preserve]
	// RVA: 0x8578EF8 Offset: 0x8574EF8 VA: 0x8578EF8
	internal void .ctor(ICartValidator cartValidator, IAppleFetchProductsService fetchProductsService, ITransactionLog transactionLog, IUtil util, ILogger logger, ITelemetryDiagnostics telemetryDiagnostics, ITelemetryMetricsService telemetryMetricsService) { }

	// RVA: 0x8578F24 Offset: 0x8574F24 VA: 0x8578F24 Slot: 17
	public override void FetchProducts(IReadOnlyCollection<ProductDefinition> products) { }

	// RVA: 0x85790AC Offset: 0x85750AC VA: 0x85790AC Slot: 19
	public override void Purchase(ICart cart) { }

	[CompilerGenerated]
	[DebuggerHidden]
	// RVA: 0x8579234 Offset: 0x8575234 VA: 0x8579234
	private void <>n__0(IReadOnlyCollection<ProductDefinition> products) { }

	[CompilerGenerated]
	[DebuggerHidden]
	// RVA: 0x8579238 Offset: 0x8575238 VA: 0x8579238
	private void <>n__1(ICart cart) { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
internal interface INativeStoreProvider // TypeDefIndex: 26336
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract INativeAppleStore GetStorekit(IUnityCallback callback);
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
internal class JsonStore : InternalStore, IUnityCallback // TypeDefIndex: 26337
{
	// Fields
	protected ICartValidator m_CartValidator; // 0x58
	protected string m_StoreName; // 0x60
	[Nullable(2)]
	private INativeStore m_Store; // 0x68
	protected readonly ILogger Logger; // 0x70
	[Nullable(2)]
	private PurchaseFailureDescription LastPurchaseFailureDescription; // 0x78
	private StoreSpecificPurchaseErrorCode m_LastPurchaseErrorCode; // 0x80

	// Methods

	// RVA: 0x857927C Offset: 0x857527C VA: 0x857927C
	public void SetNativeStore(INativeStore native) { }

	// RVA: 0x8574AE8 Offset: 0x8570AE8 VA: 0x8574AE8
	internal void .ctor(ICartValidator cartValidator, ILogger logger, string storeName) { }

	// RVA: 0x8579284 Offset: 0x8575284 VA: 0x8579284 Slot: 17
	public override void FetchProducts(IReadOnlyCollection<ProductDefinition> products) { }

	// RVA: 0x8579348 Offset: 0x8575348 VA: 0x8579348 Slot: 18
	public override void FetchPurchases() { }

	// RVA: 0x85793F4 Offset: 0x85753F4 VA: 0x85793F4 Slot: 30
	public virtual void OnPurchasesFetched(string json) { }

	// RVA: 0x85794C0 Offset: 0x85754C0 VA: 0x85794C0
	internal List<Order> CreateOrdersFromFetchedPurchases(List<ProductDescription> productDescriptions) { }

	// RVA: 0x857996C Offset: 0x857596C VA: 0x857996C Slot: 19
	public override void Purchase(ICart cart) { }

	// RVA: 0x8579AE4 Offset: 0x8575AE4 VA: 0x8579AE4 Slot: 31
	protected virtual void Purchase(ProductDefinition productDefinition, string developerPayload) { }

	// RVA: 0x8579BBC Offset: 0x8575BBC VA: 0x8579BBC Slot: 20
	public override void FinishTransaction(PendingOrder pendingOrder) { }

	// RVA: 0x8574FA0 Offset: 0x8570FA0 VA: 0x8574FA0 Slot: 32
	protected virtual void FinishTransaction(ProductDefinition productDefinition, string transactionId) { }

	// RVA: 0x8579EA0 Offset: 0x8575EA0 VA: 0x8579EA0 Slot: 16
	public override void Connect() { }

	// RVA: 0x8579F48 Offset: 0x8575F48 VA: 0x8579F48 Slot: 33
	public void OnStoreConnectionSucceeded() { }

	// RVA: 0x8579FF0 Offset: 0x8575FF0 VA: 0x8579FF0 Slot: 34
	public virtual void OnPurchaseSucceeded(string id, string receipt, string transactionID) { }

	// RVA: 0x857A0CC Offset: 0x85760CC VA: 0x857A0CC
	protected DeferredOrder GenerateDeferredOrder(string id, string receipt, string transactionID) { }

	// RVA: 0x8579764 Offset: 0x8575764 VA: 0x8579764
	protected PendingOrder GeneratePendingOrder(string id, string receipt, string transactionID) { }

	// RVA: 0x8579868 Offset: 0x8575868 VA: 0x8579868
	protected ConfirmedOrder GenerateConfirmedOrder(string id, string receipt, string transactionID) { }

	// RVA: 0x8577E48 Offset: 0x8573E48 VA: 0x8577E48
	protected Product FindProductById(string productId) { }

	// RVA: 0x85772CC Offset: 0x85732CC VA: 0x85772CC Slot: 35
	public void OnPurchaseFailed(string json) { }

	// RVA: 0x857A1D0 Offset: 0x85761D0 VA: 0x857A1D0
	public void OnPurchaseFailed(PurchaseFailureDescription failure, string json) { }

	// RVA: 0x857A558 Offset: 0x8576558 VA: 0x857A558 Slot: 36
	public virtual void OnPurchaseDeferred(string productDetails) { }

	[NullableContext(2)]
	// RVA: 0x857A2E0 Offset: 0x85762E0 VA: 0x857A2E0
	private static StoreSpecificPurchaseErrorCode ParseStoreSpecificPurchaseErrorCode(string json) { }
}

// Namespace: UnityEngine.Purchasing
internal class NativeStoreProvider : INativeStoreProvider // TypeDefIndex: 26338
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x857A658 Offset: 0x8576658 VA: 0x857A658 Slot: 4
	public INativeAppleStore GetStorekit(IUnityCallback callback) { }

	// RVA: 0x857A72C Offset: 0x857672C VA: 0x857A72C
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
internal static class ProductServiceDependencyFactoryInjector // TypeDefIndex: 26339
{
	// Methods

	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x857A734 Offset: 0x8576734 VA: 0x857A734
	private static void SetStoreManagerFactory() { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
internal class ProductServiceFactory : IProductServiceFactory // TypeDefIndex: 26340
{
	// Fields
	[Nullable(2)]
	private static ProductServiceFactory s_Instance; // 0x0
	[Nullable(new[] { 1, 2, 1, 1, 1 })]
	private readonly Dictionary<string, Func<IStoreWrapper, IProductService>> m_ProductServiceInstantiationByName; // 0x10

	// Methods

	// RVA: 0x857A7E4 Offset: 0x85767E4 VA: 0x857A7E4
	internal static ProductServiceFactory Instance() { }

	// RVA: 0x857A85C Offset: 0x857685C VA: 0x857A85C
	private void .ctor() { }

	// RVA: 0x857A9C8 Offset: 0x85769C8 VA: 0x857A9C8 Slot: 4
	public IProductService Create(IStoreWrapper store) { }

	// RVA: 0x857AB90 Offset: 0x8576B90 VA: 0x857AB90
	private static ProductService CreateGenericProductService(IStoreWrapper storeWrapper) { }

	// RVA: 0x857AC78 Offset: 0x8576C78 VA: 0x857AC78
	private static void AddProductServiceDependencies(IStoreWrapper store, IDependencyInjectionService di) { }

	// RVA: 0x857AF94 Offset: 0x8576F94 VA: 0x857AF94
	private static AppleStoreExtendedProductService CreateAppleProductService(IStoreWrapper store) { }
}

// Namespace: UnityEngine.Purchasing
internal static class PurchaseServiceDependencyFactoryInjector // TypeDefIndex: 26341
{
	// Methods

	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x857B908 Offset: 0x8577908 VA: 0x857B908
	private static void SetStoreManagerFactory() { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
internal class PurchaseServiceFactory : IPurchaseServiceFactory // TypeDefIndex: 26342
{
	// Fields
	[Nullable(2)]
	private static PurchaseServiceFactory s_Instance; // 0x0
	[Nullable(new[] { 1, 2, 1, 1, 1 })]
	private readonly Dictionary<string, Func<IStoreWrapper, IPurchaseService>> m_PurchaseServiceInstantiationByName; // 0x10

	// Methods

	// RVA: 0x857B9B8 Offset: 0x85779B8 VA: 0x857B9B8
	internal static PurchaseServiceFactory Instance() { }

	// RVA: 0x857BA30 Offset: 0x8577A30 VA: 0x857BA30
	private void .ctor() { }

	// RVA: 0x857BBFC Offset: 0x8577BFC VA: 0x857BBFC Slot: 4
	public IPurchaseService Create(IStoreWrapper store) { }

	// RVA: 0x857BDC4 Offset: 0x8577DC4 VA: 0x857BDC4
	private static PurchaseService CreateDefaultPurchaseService(IStoreWrapper store) { }

	// RVA: 0x857BF30 Offset: 0x8577F30 VA: 0x857BF30
	private static void AddPurchaseServiceDependencies(IStoreWrapper store, IDependencyInjectionService di) { }

	// RVA: 0x857C5B8 Offset: 0x85785B8 VA: 0x857C5B8
	private static void AddAnalyticsDependencies(IDependencyInjectionService di) { }

	// RVA: 0x857C66C Offset: 0x857866C VA: 0x857C66C
	private static GooglePlayStoreExtendedPurchaseService CreateGooglePurchaseService(IStoreWrapper store) { }

	// RVA: 0x857C964 Offset: 0x8578964 VA: 0x857C964
	private static AppleStoreExtendedPurchaseService CreateApplePurchaseService(IStoreWrapper store) { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
internal class StoreFactory : IStoreFactory // TypeDefIndex: 26343
{
	// Fields
	[Nullable(2)]
	private static StoreFactory s_Instance; // 0x0
	private readonly IUtil m_Util; // 0x10
	private readonly ILogger m_Logger; // 0x18
	private readonly INativeStoreProvider m_NativeStoreProvider; // 0x20
	public readonly ITelemetryMetricsInstanceWrapper TelemetryMetricsInstanceWrapper; // 0x28
	public readonly ITelemetryDiagnosticsInstanceWrapper TelemetryDiagnosticsInstanceWrapper; // 0x30
	[Nullable(new[] { 1, 2, 1, 1 })]
	private readonly Dictionary<string, Func<IStoreWrapper>> m_StoreInstantiationByName; // 0x38

	// Methods

	// RVA: 0x857CF64 Offset: 0x8578F64 VA: 0x857CF64
	internal void .ctor(IUtil util, ILogger logger, INativeStoreProvider nativeStoreProvider, ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper, ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper) { }

	// RVA: 0x857B768 Offset: 0x8577768 VA: 0x857B768
	internal static StoreFactory Instance() { }

	// RVA: 0x857D068 Offset: 0x8579068 VA: 0x857D068
	private void RegisterBaseStores() { }

	// RVA: 0x857D214 Offset: 0x8579214 VA: 0x857D214 Slot: 5
	public void RegisterStore(string storeName, Func<IStoreWrapper> function) { }

	// RVA: 0x857D27C Offset: 0x857927C VA: 0x857D27C Slot: 4
	public IStoreWrapper CreateStore(string storeName) { }

	// RVA: 0x857D3DC Offset: 0x85793DC VA: 0x857D3DC
	private IDependencyInjectionService CreateBaseDiService() { }

	// RVA: 0x857D44C Offset: 0x857944C VA: 0x857D44C
	private void AddUtilsDependencies(IDependencyInjectionService di) { }

	// RVA: 0x857D55C Offset: 0x857955C VA: 0x857D55C
	private void AddTelemetryDependencies(IDependencyInjectionService di) { }

	// RVA: 0x857D774 Offset: 0x8579774 VA: 0x857D774
	private IStoreWrapper InstantiateAppleStore() { }

	// RVA: 0x857D96C Offset: 0x857996C VA: 0x857D96C
	private IStoreWrapper InstantiateMacAppStore() { }

	// RVA: 0x857D7DC Offset: 0x85797DC VA: 0x857D7DC
	private IStoreWrapper InstantiateAppleAppStore(string storeName, string storeDisplayName) { }

	// RVA: 0x857D9D4 Offset: 0x85799D4 VA: 0x857D9D4
	private void AddMetricizedAppleStoreDependencies(IDependencyInjectionService di) { }

	// RVA: 0x857DD44 Offset: 0x8579D44 VA: 0x857DD44
	private static ITransactionLog BuildTransactionLog() { }

	// RVA: 0x857DB8C Offset: 0x8579B8C VA: 0x857DB8C
	private void CreateAndAssignNativeAppleStore(AppleStoreImpl store) { }

	// RVA: 0x857DDD0 Offset: 0x8579DD0 VA: 0x857DDD0
	private IStoreWrapper InstantiateFakeStore() { }

	// RVA: 0x857DE60 Offset: 0x8579E60 VA: 0x857DE60
	private FakeStore CreateFakeStoreByUIMode(FakeStoreUIMode useFakeStoreUIMode) { }

	// RVA: 0x857E07C Offset: 0x857A07C VA: 0x857E07C
	private IStoreWrapper InstantiateGooglePlayStore() { }

	// RVA: 0x857DC44 Offset: 0x8579C44 VA: 0x857DC44
	private static IStoreWrapper CreateStoreWrapper(string storeName, IDependencyInjectionService di) { }

	// RVA: 0x857EF44 Offset: 0x857AF44 VA: 0x857EF44
	private void LinkGooglePlayStoreDependencies(IDependencyInjectionService di) { }

	// RVA: 0x857F248 Offset: 0x857B248 VA: 0x857F248
	private static void LinkProductCache(IDependencyInjectionService di) { }

	// RVA: 0x857E0E8 Offset: 0x857A0E8 VA: 0x857E0E8
	private static void AddGooglePlayStoreServices(IDependencyInjectionService di) { }

	// RVA: 0x857E750 Offset: 0x857A750 VA: 0x857E750
	private void AddGooglePlayStoreServiceAars(IDependencyInjectionService di) { }
}

// Namespace: UnityEngine.Purchasing
internal static class StoreManagerFactoryInjector // TypeDefIndex: 26344
{
	// Methods

	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x857F794 Offset: 0x857B794 VA: 0x857F794
	private static void SetStoreManagerFactory() { }
}

// Namespace: UnityEngine.Purchasing
internal static class StoreServiceDependencyFactoryInjector // TypeDefIndex: 26345
{
	// Methods

	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x857F844 Offset: 0x857B844 VA: 0x857F844
	private static void SetStoreManagerFactory() { }
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
internal class StoreServiceFactory : IStoreServiceFactory // TypeDefIndex: 26346
{
	// Fields
	[Nullable(2)]
	private static StoreServiceFactory s_Instance; // 0x0
	[Nullable(new[] { 1, 2, 1, 1, 1, 1 })]
	private readonly Dictionary<string, Func<IRetryPolicy, IStoreWrapper, IStoreService>> m_StoreServiceInstantiationByName; // 0x10

	// Methods

	// RVA: 0x857F8F4 Offset: 0x857B8F4 VA: 0x857F8F4
	internal static StoreServiceFactory Instance() { }

	// RVA: 0x857F96C Offset: 0x857B96C VA: 0x857F96C
	private void .ctor() { }

	// RVA: 0x857FB38 Offset: 0x857BB38 VA: 0x857FB38 Slot: 4
	public IStoreService Create(IStoreWrapper store, IRetryPolicy retryPolicy) { }

	// RVA: 0x857FD4C Offset: 0x857BD4C VA: 0x857FD4C
	private static StoreService CreateGenericStoreService(IRetryPolicy retryPolicy, IStoreWrapper storeWrapper) { }

	// RVA: 0x857FE44 Offset: 0x857BE44 VA: 0x857FE44
	private static void AddStoreServiceDependencies(IDependencyInjectionService di, IRetryPolicy retryPolicy, IStoreWrapper store) { }

	// RVA: 0x858019C Offset: 0x857C19C VA: 0x858019C
	private static GooglePlayStoreExtendedService CreateGoogleStoreService(IRetryPolicy retryPolicy, IStoreWrapper store) { }

	// RVA: 0x8580694 Offset: 0x857C694 VA: 0x8580694
	private static AppleStoreExtendedService CreateAppleStoreService(IRetryPolicy retryPolicy, IStoreWrapper store) { }
}

// Namespace: UnityEngine.Purchasing
internal class DialogRequest // TypeDefIndex: 26347
{
	// Fields
	public string QueryText; // 0x10
	public string OkayButtonText; // 0x18
	public string CancelButtonText; // 0x20
	public List<string> Options; // 0x28
	public Action<bool, int> Callback; // 0x30

	// Methods

	// RVA: 0x8580C0C Offset: 0x857CC0C VA: 0x8580C0C
	public void .ctor() { }
}

// Namespace: 
protected enum FakeStore.DialogType // TypeDefIndex: 26348
{
	// Fields
	public int value__; // 0x0
	public const FakeStore.DialogType Purchase = 0;
	public const FakeStore.DialogType FetchProducts = 1;
}

// Namespace: 
[CompilerGenerated]
private sealed class FakeStore.<>c__DisplayClass13_0 // TypeDefIndex: 26349
{
	// Fields
	public FakeStore <>4__this; // 0x10
	public List<ProductDescription> products; // 0x18

	// Methods

	// RVA: 0x8581290 Offset: 0x857D290 VA: 0x8581290
	public void .ctor() { }

	// RVA: 0x85821D4 Offset: 0x857E1D4 VA: 0x85821D4
	internal void <StoreFetchProducts>g__handleAllowInitializeOrFetchProducts|0(bool allow, ProductFetchFailureReason failureReason) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FakeStore.<>c__DisplayClass19_0 // TypeDefIndex: 26350
{
	// Fields
	public FakeStore <>4__this; // 0x10
	public ProductDefinition productDefinition; // 0x18

	// Methods

	// RVA: 0x8581F40 Offset: 0x857DF40 VA: 0x8581F40
	public void .ctor() { }

	// RVA: 0x8581F48 Offset: 0x857DF48 VA: 0x8581F48
	internal void <FakePurchase>g__handleAllowPurchase|0(bool allow, PurchaseFailureReason failureReason) { }
}

// Namespace: UnityEngine.Purchasing
internal class FakeStore : JsonStore, INativeStore // TypeDefIndex: 26351
{
	// Fields
	private readonly List<ConfirmedOrder> m_ConfirmedOrders; // 0x88
	[CompilerGenerated]
	private string <unavailableProductId>k__BackingField; // 0x90
	public FakeStoreUIMode UIMode; // 0x98

	// Properties
	public string unavailableProductId { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8580C14 Offset: 0x857CC14 VA: 0x8580C14
	public string get_unavailableProductId() { }

	// RVA: 0x857DFB8 Offset: 0x8579FB8 VA: 0x857DFB8
	public void .ctor(ICartValidator cartValidator, ILogger logger) { }

	// RVA: 0x8580C1C Offset: 0x857CC1C VA: 0x8580C1C Slot: 16
	public override void Connect() { }

	// RVA: 0x8580C20 Offset: 0x857CC20 VA: 0x8580C20 Slot: 38
	public void FetchProducts(string json) { }

	// RVA: 0x8580D38 Offset: 0x857CD38 VA: 0x8580D38
	public void StoreFetchProducts(ReadOnlyCollection<ProductDefinition> productDefinitions) { }

	// RVA: 0x8581298 Offset: 0x857D298 VA: 0x8581298
	private ProductMetadata GetOrCreateProductMetadata(string productId) { }

	// RVA: 0x85817A8 Offset: 0x857D7A8 VA: 0x85817A8 Slot: 39
	public void FetchExistingPurchases() { }

	// RVA: 0x8581858 Offset: 0x857D858 VA: 0x8581858 Slot: 40
	public void Purchase(string productJson, string optionsJson) { }

	// RVA: 0x8581874 Offset: 0x857D874 VA: 0x8581874
	private ProductDefinition ParseProductDefinition(string productJSON) { }

	// RVA: 0x8581D8C Offset: 0x857DD8C VA: 0x8581D8C
	private ProductType ParseProductType(Dictionary<string, object> dictionary) { }

	// RVA: 0x85819E8 Offset: 0x857D9E8 VA: 0x85819E8
	private void FakePurchase(ProductDefinition productDefinition, string developerPayload) { }

	// RVA: 0x85821CC Offset: 0x857E1CC VA: 0x85821CC Slot: 41
	public void FinishTransaction(string productJSON, string transactionID) { }

	// RVA: -1 Offset: -1 Slot: 42
	protected virtual bool StartUI<T>(object model, FakeStore.DialogType dialogType, Action<bool, T> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45FCF60 Offset: 0x45F8F60 VA: 0x45FCF60
	|-FakeStore.StartUI<Int32Enum>
	|
	|-RVA: 0x45FCF68 Offset: 0x45F8F68 VA: 0x45FCF68
	|-FakeStore.StartUI<__Il2CppFullySharedGenericStructType>
	*/

	[DebuggerHidden]
	[CompilerGenerated]
	[NullableContext(1)]
	// RVA: 0x85821D0 Offset: 0x857E1D0 VA: 0x85821D0
	private void <>n__0(string id, string receipt, string transactionID) { }
}

// Namespace: UnityEngine.Purchasing
internal class FakeStoreCartValidator : StoreCartValidator // TypeDefIndex: 26352
{
	// Methods

	// RVA: 0x857DF34 Offset: 0x8579F34 VA: 0x857DF34
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
internal class LifecycleNotifier : MonoBehaviour // TypeDefIndex: 26353
{
	// Fields
	public Action OnDestroyCallback; // 0x20

	// Methods

	// RVA: 0x8582348 Offset: 0x857E348 VA: 0x8582348
	private void OnDestroy() { }

	// RVA: 0x8582364 Offset: 0x857E364 VA: 0x8582364
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UIFakeStore.<>c // TypeDefIndex: 26354
{
	// Fields
	public static readonly UIFakeStore.<>c <>9; // 0x0
	public static Func<ProductDefinition, string> <>9__20_0; // 0x8

	// Methods

	// RVA: 0x858310C Offset: 0x857F10C VA: 0x858310C
	private static void .cctor() { }

	// RVA: 0x8583174 Offset: 0x857F174 VA: 0x8583174
	public void .ctor() { }

	// RVA: 0x858317C Offset: 0x857F17C VA: 0x858317C
	internal string <CreateFetchProductsQuestion>b__20_0(ProductDefinition pid) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UIFakeStore.<>c__DisplayClass10_0<T> // TypeDefIndex: 26355
{
	// Fields
	public Action<bool, T> callback; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4864878 Offset: 0x4860878 VA: 0x4864878
	|-UIFakeStore.<>c__DisplayClass10_0<Int32Enum>..ctor
	|
	|-RVA: 0x4864958 Offset: 0x4860958 VA: 0x4864958
	|-UIFakeStore.<>c__DisplayClass10_0<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <StartUI>b__0(bool result, int codeValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4864880 Offset: 0x4860880 VA: 0x4864880
	|-UIFakeStore.<>c__DisplayClass10_0<Int32Enum>.<StartUI>b__0
	|
	|-RVA: 0x4864960 Offset: 0x4860960 VA: 0x4864960
	|-UIFakeStore.<>c__DisplayClass10_0<__Il2CppFullySharedGenericStructType>.<StartUI>b__0
	*/
}

// Namespace: UnityEngine.Purchasing
internal class UIFakeStore : FakeStore // TypeDefIndex: 26356
{
	// Fields
	private DialogRequest m_CurrentDialog; // 0xA0
	private int m_LastSelectedDropdownIndex; // 0xA8
	private GameObject m_UIFakeStoreWindowObject; // 0xB0
	private GameObject m_EventSystem; // 0xB8

	// Methods

	// RVA: 0x857DFB4 Offset: 0x8579FB4 VA: 0x857DFB4
	public void .ctor(ICartValidator cartValidator, ILogger logger) { }

	// RVA: -1 Offset: -1 Slot: 42
	protected override bool StartUI<T>(object model, FakeStore.DialogType dialogType, Action<bool, T> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x473A42C Offset: 0x473642C VA: 0x473A42C
	|-UIFakeStore.StartUI<Int32Enum>
	|
	|-RVA: 0x473AB5C Offset: 0x4736B5C VA: 0x473AB5C
	|-UIFakeStore.StartUI<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x858236C Offset: 0x857E36C VA: 0x858236C
	private bool StartUI(string queryText, string okayButtonText, string cancelButtonText, List<string> options, Action<bool, int> callback) { }

	// RVA: 0x8582480 Offset: 0x857E480 VA: 0x8582480
	private void InstantiateDialog() { }

	// RVA: 0x85825A4 Offset: 0x857E5A4 VA: 0x85825A4
	private UIFakeStoreWindow GetOrCreateFakeStoreWindow() { }

	// RVA: 0x85826A4 Offset: 0x857E6A4 VA: 0x85826A4
	private void AddLifeCycleNotifierAndSetDestroyCallback(GameObject gameObject) { }

	// RVA: 0x8582760 Offset: 0x857E760 VA: 0x8582760
	private void EnsureEventSystemCreated(Transform rootTransform) { }

	// RVA: 0x8582800 Offset: 0x857E800 VA: 0x8582800
	private void ConfigureDialogWindow(UIFakeStoreWindow dialogWindow) { }

	// RVA: 0x8582B48 Offset: 0x857EB48 VA: 0x8582B48
	private void ConfigureDialogWindowCallbacks(UIFakeStoreWindow dialogWindow, bool assignCancelCallback, bool assignDropDownCallback) { }

	// RVA: 0x8582874 Offset: 0x857E874 VA: 0x8582874
	private void CreateEventSystem(Transform rootTransform) { }

	// RVA: 0x8582CD4 Offset: 0x857ECD4 VA: 0x8582CD4
	private string CreatePurchaseQuestion(ProductDefinition definition) { }

	// RVA: 0x8582D40 Offset: 0x857ED40 VA: 0x8582D40
	private string CreateFetchProductsQuestion(ReadOnlyCollection<ProductDefinition> definitions) { }

	// RVA: 0x8582F64 Offset: 0x857EF64 VA: 0x8582F64
	private void OkayButtonClicked() { }

	// RVA: 0x85830B8 Offset: 0x857F0B8 VA: 0x85830B8
	private void CancelButtonClicked() { }

	// RVA: 0x85830F8 Offset: 0x857F0F8 VA: 0x85830F8
	private void DropdownValueChanged(int selectedItem) { }

	// RVA: 0x8583014 Offset: 0x857F014 VA: 0x8583014
	private void CloseDialog() { }

	// RVA: 0x8582470 Offset: 0x857E470 VA: 0x8582470
	public bool IsShowingDialog() { }

	[CompilerGenerated]
	// RVA: 0x8583100 Offset: 0x857F100 VA: 0x8583100
	private void <AddLifeCycleNotifierAndSetDestroyCallback>b__14_0() { }
}

// Namespace: UnityEngine.Purchasing
internal class UIFakeStoreDropdown // TypeDefIndex: 26357
{
	// Fields
	private List<string> m_Options; // 0x10
	private Action<int, string> m_OnDropdown; // 0x18
	private Vector2 scrollPosition; // 0x20

	// Methods

	// RVA: 0x8583194 Offset: 0x857F194 VA: 0x8583194
	public void DoPopup(int windowID) { }

	// RVA: 0x8583430 Offset: 0x857F430 VA: 0x8583430
	private void OnOptionSelected(int optionIndex) { }

	// RVA: 0x85834B8 Offset: 0x857F4B8 VA: 0x85834B8
	internal void SetOptions(List<string> options) { }

	// RVA: 0x858353C Offset: 0x857F53C VA: 0x858353C
	internal void SetSelectionAction(Action<int, string> onDropdown) { }

	// RVA: 0x8583544 Offset: 0x857F544 VA: 0x8583544
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
internal class UIFakeStoreWindow : MonoBehaviour // TypeDefIndex: 26358
{
	// Fields
	private string m_QueryText; // 0x20
	private string m_OkText; // 0x28
	private string m_CancelText; // 0x30
	private string m_LastSelectedOptionText; // 0x38
	private Action m_OnOk; // 0x40
	private Action m_OnCancel; // 0x48
	private Action<int> m_OnDropdown; // 0x50
	private bool m_CancelEnabled; // 0x58
	private bool m_DropdownEnabled; // 0x59
	private bool m_DoDropdown; // 0x5A
	private readonly UIFakeStoreDropdown m_Dropdown; // 0x60
	private Vector2 scrollPosition; // 0x68
	private const float k_MenuScreenRatio = 0.6;

	// Methods

	// RVA: 0x858354C Offset: 0x857F54C VA: 0x858354C
	private void OnGUI() { }

	// RVA: 0x85836C0 Offset: 0x857F6C0 VA: 0x85836C0
	private Rect CreateCenteredWindowRect() { }

	// RVA: 0x8583734 Offset: 0x857F734 VA: 0x8583734
	private void DoMainGUI(int windowID) { }

	// RVA: 0x8583A50 Offset: 0x857FA50 VA: 0x8583A50
	private void DoDropDown() { }

	// RVA: 0x8583A5C Offset: 0x857FA5C VA: 0x8583A5C
	private void OnOkClicked() { }

	// RVA: 0x8583A78 Offset: 0x857FA78 VA: 0x8583A78
	private void OnCancelClicked() { }

	// RVA: 0x8582A04 Offset: 0x857EA04 VA: 0x8582A04
	internal void ConfigureMainDialogText(string queryText, string okText, string cancelText) { }

	// RVA: 0x8582A48 Offset: 0x857EA48 VA: 0x8582A48
	internal void ConfigureDropdownOptions(List<string> options) { }

	// RVA: 0x8583A94 Offset: 0x857FA94 VA: 0x8583A94
	private void OnDropdown(int index, string selectionText) { }

	// RVA: 0x8582C78 Offset: 0x857EC78 VA: 0x8582C78
	internal void AssignCallbacks(Action onOk, Action onCancel, Action<int> onDropdown) { }

	// RVA: 0x8583AE4 Offset: 0x857FAE4 VA: 0x8583AE4
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class IapCoreInitializeCallback.<>c__DisplayClass2_0 // TypeDefIndex: 26359
{
	// Fields
	public CoreRegistry registry; // 0x10
	public ITelemetryMetricsInstanceWrapper metricsInstanceWrapper; // 0x18
	public ITelemetryDiagnosticsInstanceWrapper diagnosticsInstanceWrapper; // 0x20

	// Methods

	// RVA: 0x8583F18 Offset: 0x857FF18 VA: 0x8583F18
	public void .ctor() { }

	// RVA: 0x858436C Offset: 0x858036C VA: 0x858436C
	internal void <Initialize>b__0() { }
}

// Namespace: UnityEngine.Purchasing.Registration
internal class IapCoreInitializeCallback : IInitializablePackage // TypeDefIndex: 26360
{
	// Methods

	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x8583B50 Offset: 0x857FB50 VA: 0x8583B50
	private static void Register() { }

	// RVA: 0x8583CEC Offset: 0x857FCEC VA: 0x8583CEC Slot: 4
	public Task Initialize(CoreRegistry registry) { }

	// RVA: 0x8583F20 Offset: 0x857FF20 VA: 0x8583F20
	private static void CacheInitializedEnvironment(CoreRegistry registry) { }

	// RVA: 0x8583F4C Offset: 0x857FF4C VA: 0x8583F4C
	private static string GetCurrentEnvironment(CoreRegistry registry) { }

	// RVA: 0x8584094 Offset: 0x8580094 VA: 0x8584094
	private static void InitializeTelemetryComponents(ITelemetryMetricsInstanceWrapper metricsInstanceWrapper, ITelemetryDiagnosticsInstanceWrapper diagnosticsInstanceWrapper) { }

	// RVA: 0x8583CE4 Offset: 0x857FCE4 VA: 0x8583CE4
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GooglePurchaseBuilder.<>c__DisplayClass6_0 // TypeDefIndex: 26361
{
	// Fields
	public IEnumerable<AndroidJavaObject> productDetails; // 0x10

	// Methods

	// RVA: 0x8584C0C Offset: 0x8580C0C VA: 0x8584C0C
	public void .ctor() { }

	// RVA: 0x8584C14 Offset: 0x8580C14 VA: 0x8584C14
	internal AndroidJavaObject <TryFindAllProductDetails>b__0(string sku) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GooglePurchaseBuilder.<>c__DisplayClass6_1 // TypeDefIndex: 26362
{
	// Fields
	public string sku; // 0x10

	// Methods

	// RVA: 0x8584CFC Offset: 0x8580CFC VA: 0x8584CFC
	public void .ctor() { }

	// RVA: 0x8584D04 Offset: 0x8580D04 VA: 0x8584D04
	internal bool <TryFindAllProductDetails>b__1(AndroidJavaObject productDetail) { }
}

// Namespace: UnityEngine.Purchasing.Utils
internal class GooglePurchaseBuilder : IGooglePurchaseBuilder // TypeDefIndex: 26363
{
	// Fields
	private readonly IGoogleCachedQueryProductDetailsService m_CachedQueryProductDetailsService; // 0x10
	private readonly ILogger m_Logger; // 0x18

	// Methods

	[Preserve]
	// RVA: 0x8584388 Offset: 0x8580388 VA: 0x8584388
	internal void .ctor(IGoogleCachedQueryProductDetailsService cachedQueryProductDetailsService, ILogger logger) { }

	// RVA: 0x85843CC Offset: 0x85803CC VA: 0x85843CC Slot: 4
	public IEnumerable<IGooglePurchase> BuildPurchases(IEnumerable<AndroidJavaObject> purchases) { }

	// RVA: 0x858450C Offset: 0x858050C VA: 0x858450C
	private void LogWarningForException(Exception exception) { }

	// RVA: 0x8584544 Offset: 0x8580544 VA: 0x8584544
	public IGooglePurchase BuildPurchase(AndroidJavaObject purchase) { }

	// RVA: 0x8584B28 Offset: 0x8580B28 VA: 0x8584B28
	private static IEnumerable<AndroidJavaObject> TryFindAllProductDetails(IEnumerable<string> skus, IEnumerable<AndroidJavaObject> productDetails) { }
}

// Namespace: UnityEngine.Purchasing.Utils
internal static class GoogleReceiptEncoder // TypeDefIndex: 26364
{
	// Methods

	// RVA: 0x8584DF0 Offset: 0x8580DF0 VA: 0x8584DF0
	internal static string EncodeReceipt(string purchaseOriginalJson, string purchaseSignature, List<string> productDetailsJson) { }
}

// Namespace: UnityEngine.Purchasing.Utils
[NullableContext(1)]
[Preserve]
[Nullable(0)]
internal class ProductDetailsConverter : IProductDetailsConverter // TypeDefIndex: 26365
{
	// Methods

	// RVA: 0x8584F0C Offset: 0x8580F0C VA: 0x8584F0C Slot: 4
	public List<ProductDescription> ConvertOnQueryProductDetailsResponse(IEnumerable<AndroidJavaObject> productDetails, IReadOnlyCollection<ProductDefinition> productDefinitions) { }

	// RVA: 0x8585A64 Offset: 0x8581A64 VA: 0x8585A64
	public string GetProductId(AndroidJavaObject productDetails) { }

	// RVA: 0x8585C0C Offset: 0x8581C0C VA: 0x8585C0C
	public ProductDescription ConvertToProductDescription(AndroidJavaObject productDetails, ProductType productType) { }

	// RVA: 0x8585CAC Offset: 0x8581CAC VA: 0x8585CAC
	internal static ProductDescription BuildProductDescription(AndroidJavaObject productDetails, ProductType productType = 3) { }

	// RVA: 0x8587600 Offset: 0x8583600 VA: 0x8587600
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GoogleBillingClient.<>c__DisplayClass47_0 // TypeDefIndex: 26366
{
	// Fields
	public string type; // 0x10

	// Methods

	// RVA: 0x8589238 Offset: 0x8585238 VA: 0x8589238
	public void .ctor() { }

	// RVA: 0x858B2F0 Offset: 0x85872F0 VA: 0x858B2F0
	internal AndroidJavaObject <QueryProductDetailsParamsProductList>b__0(string product) { }
}

// Namespace: UnityEngine.Purchasing.Models
internal class GoogleBillingClient : IGoogleBillingClient // TypeDefIndex: 26367
{
	// Fields
	private static AndroidJavaClass s_AndroidProductClassName; // 0x0
	private static AndroidJavaClass s_AndroidQueryProductDetailsParamsClassName; // 0x8
	private static AndroidJavaClass s_BillingFlowParamsClass; // 0x10
	private static AndroidJavaClass s_ProductDetailsParamsClass; // 0x18
	private static AndroidJavaClass s_SubscriptionUpdateParamsClass; // 0x20
	private static AndroidJavaClass s_ConsumeParamsClass; // 0x28
	private static AndroidJavaClass s_AcknowledgePurchaseParamsClass; // 0x30
	private static AndroidJavaClass s_BillingClientClass; // 0x38
	private static AndroidJavaClass s_PendingPurchasesParamsClass; // 0x40
	private static AndroidJavaClass s_QueryPurchasesParamsClass; // 0x48
	private readonly AndroidJavaObject m_BillingClient; // 0x10
	private string m_ObfuscatedAccountId; // 0x18
	private string m_ObfuscatedProfileId; // 0x20
	private readonly IUtil m_Util; // 0x28
	private readonly ITelemetryDiagnostics m_TelemetryDiagnostics; // 0x30

	// Methods

	// RVA: 0x8587608 Offset: 0x8583608 VA: 0x8587608
	private static AndroidJavaClass GetProductParamsClass() { }

	// RVA: 0x85876BC Offset: 0x85836BC VA: 0x85876BC
	private static AndroidJavaClass GetQueryProductDetailsParamsParamsClass() { }

	// RVA: 0x8587768 Offset: 0x8583768 VA: 0x8587768
	private static AndroidJavaClass GetBillingFlowParamClass() { }

	// RVA: 0x8587814 Offset: 0x8583814 VA: 0x8587814
	private static AndroidJavaClass GetProductDetailsParamsClass() { }

	// RVA: 0x85878C0 Offset: 0x85838C0 VA: 0x85878C0
	private static AndroidJavaClass GetSubscriptionUpdateParamClass() { }

	// RVA: 0x858796C Offset: 0x858396C VA: 0x858796C
	private static AndroidJavaClass GetConsumeParamsClass() { }

	// RVA: 0x8587A18 Offset: 0x8583A18 VA: 0x8587A18
	private static AndroidJavaClass GetAcknowledgePurchaseParamsClass() { }

	// RVA: 0x8587AC4 Offset: 0x8583AC4 VA: 0x8587AC4
	private static AndroidJavaClass GetBillingClientClass() { }

	// RVA: 0x8587B70 Offset: 0x8583B70 VA: 0x8587B70
	private static AndroidJavaClass GetPendingPurchasesParamsClass() { }

	// RVA: 0x8587C1C Offset: 0x8583C1C VA: 0x8587C1C
	private static AndroidJavaObject PendingPurchasesParams() { }

	// RVA: 0x8587F48 Offset: 0x8583F48 VA: 0x8587F48
	private static AndroidJavaClass GetQueryPurchasesParamsClass() { }

	// RVA: 0x8587FF4 Offset: 0x8583FF4 VA: 0x8587FF4
	private static AndroidJavaObject QueryPurchasesParams(string productType) { }

	[Preserve]
	// RVA: 0x8588354 Offset: 0x8584354 VA: 0x8588354
	internal void .ctor(IGooglePurchasesUpdatedListener googlePurchasesUpdatedListener, IUtil util, ITelemetryDiagnostics telemetryDiagnostics) { }

	// RVA: 0x85887AC Offset: 0x85847AC VA: 0x85887AC Slot: 10
	public void SetObfuscationAccountId(string obfuscationAccountId) { }

	// RVA: 0x85887B4 Offset: 0x85847B4 VA: 0x85887B4 Slot: 4
	public void StartConnection(IBillingClientStateListener billingClientStateListener) { }

	// RVA: 0x8588884 Offset: 0x8584884 VA: 0x8588884 Slot: 5
	public void QueryPurchasesAsync(string productType, Action<IGoogleBillingResult, IEnumerable<AndroidJavaObject>> onQueryPurchasesResponse) { }

	// RVA: 0x85889D4 Offset: 0x85849D4 VA: 0x85889D4 Slot: 6
	public void QueryProductDetailsAsync(List<string> products, string type, Action<IGoogleBillingResult, List<AndroidJavaObject>> onProductDetailsResponseAction) { }

	// RVA: 0x8588C7C Offset: 0x8584C7C VA: 0x8588C7C
	private static AndroidJavaObject QueryProductDetailsParams(List<string> products, string type) { }

	// RVA: 0x8589114 Offset: 0x8585114 VA: 0x8589114
	private static AndroidJavaObject QueryProductDetailsParamsProductList(List<string> products, string type) { }

	// RVA: 0x8589240 Offset: 0x8585240 VA: 0x8589240
	private static AndroidJavaObject QueryProductDetailsParamsProduct(string type, string product) { }

	// RVA: 0x8589648 Offset: 0x8585648 VA: 0x8589648 Slot: 7
	public AndroidJavaObject LaunchBillingFlow(AndroidJavaObject productDetails, string oldPurchaseToken, Nullable<GooglePlayReplacementMode> replacementMode) { }

	// RVA: 0x858A034 Offset: 0x8586034 VA: 0x858A034
	private AndroidJavaObject MakeBillingFlowParams(AndroidJavaObject productDetailsParamsList, string oldPurchaseToken, Nullable<GooglePlayReplacementMode> replacementMode) { }

	// RVA: 0x858A520 Offset: 0x8586520 VA: 0x858A520
	private static AndroidJavaObject BuildSubscriptionUpdateParams(string oldPurchaseToken, GooglePlayReplacementMode replacementMode) { }

	// RVA: 0x858A42C Offset: 0x858642C VA: 0x858A42C
	private AndroidJavaObject SetObfuscatedProfileIdIfNeeded(AndroidJavaObject billingFlowParams) { }

	// RVA: 0x858A338 Offset: 0x8586338 VA: 0x858A338
	private AndroidJavaObject SetObfuscatedAccountIdIfNeeded(AndroidJavaObject billingFlowParams) { }

	// RVA: 0x858A7E0 Offset: 0x85867E0 VA: 0x858A7E0 Slot: 8
	public void ConsumeAsync(string purchaseToken, Action<IGoogleBillingResult> onConsume) { }

	// RVA: 0x858AD68 Offset: 0x8586D68 VA: 0x858AD68 Slot: 9
	public void AcknowledgePurchase(string purchaseToken, Action<IGoogleBillingResult> onAcknowledge) { }
}

// Namespace: UnityEngine.Purchasing.Models
internal class GoogleBillingResult : IGoogleBillingResult // TypeDefIndex: 26368
{
	// Fields
	[CompilerGenerated]
	private readonly GoogleBillingResponseCode <responseCode>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <debugMessage>k__BackingField; // 0x18

	// Properties
	public GoogleBillingResponseCode responseCode { get; }
	public string debugMessage { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x858B2F8 Offset: 0x85872F8 VA: 0x858B2F8 Slot: 4
	public GoogleBillingResponseCode get_responseCode() { }

	[CompilerGenerated]
	// RVA: 0x858B300 Offset: 0x8587300 VA: 0x858B300 Slot: 5
	public string get_debugMessage() { }

	// RVA: 0x8566570 Offset: 0x8562570 VA: 0x8566570
	internal void .ctor(AndroidJavaObject billingResult) { }
}

// Namespace: UnityEngine.Purchasing.Models
internal static class GoogleBillingStrings // TypeDefIndex: 26369
{
	// Methods

	// RVA: 0x858B308 Offset: 0x8587308 VA: 0x858B308
	internal static string getWarningMessageMoreThanOneSkuFound(string sku) { }
}

// Namespace: UnityEngine.Purchasing.Models
internal static class GoogleProductTypeEnum // TypeDefIndex: 26370
{
	// Methods

	// RVA: 0x858B374 Offset: 0x8587374 VA: 0x858B374
	internal static string InApp() { }

	// RVA: 0x858B3B4 Offset: 0x85873B4 VA: 0x858B3B4
	internal static string Sub() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class GooglePurchase.<>c // TypeDefIndex: 26371
{
	// Fields
	[Nullable(0)]
	public static readonly GooglePurchase.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<AndroidJavaObject, ProductDescription> <>9__35_0; // 0x8
	[Nullable(0)]
	public static Func<ProductDescription, string> <>9__35_1; // 0x10

	// Methods

	// RVA: 0x858C2CC Offset: 0x85882CC VA: 0x858C2CC
	private static void .cctor() { }

	// RVA: 0x858C334 Offset: 0x8588334 VA: 0x858C334
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x858C33C Offset: 0x858833C VA: 0x858C33C
	internal ProductDescription <.ctor>b__35_0(AndroidJavaObject productDetails) { }

	[NullableContext(0)]
	// RVA: 0x858C34C Offset: 0x858834C VA: 0x858C34C
	internal string <.ctor>b__35_1(ProductDescription productDescription) { }
}

// Namespace: UnityEngine.Purchasing.Models
[NullableContext(1)]
[Nullable(0)]
internal class GooglePurchase : IGooglePurchase // TypeDefIndex: 26372
{
	// Fields
	[CompilerGenerated]
	private readonly bool <isAcknowledged>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly int <purchaseState>k__BackingField; // 0x14
	[CompilerGenerated]
	private readonly List<string> <skus>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string <orderId>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly string <receipt>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly string <signature>k__BackingField; // 0x30
	[CompilerGenerated]
	private readonly string <originalJson>k__BackingField; // 0x38
	[CompilerGenerated]
	private readonly string <purchaseToken>k__BackingField; // 0x40
	[CompilerGenerated]
	[Nullable(2)]
	private readonly string <obfuscatedAccountId>k__BackingField; // 0x48
	[CompilerGenerated]
	[Nullable(2)]
	private readonly string <obfuscatedProfileId>k__BackingField; // 0x50
	[CompilerGenerated]
	private readonly IEnumerable<ProductDescription> <productDescriptions>k__BackingField; // 0x58

	// Properties
	public bool isAcknowledged { get; }
	public int purchaseState { get; }
	public List<string> skus { get; }
	public string receipt { get; }
	public string signature { get; }
	public string originalJson { get; }
	public string purchaseToken { get; }
	[Nullable(2)]
	public string obfuscatedAccountId { get; }
	[Nullable(2)]
	public string obfuscatedProfileId { get; }
	public IEnumerable<ProductDescription> productDescriptions { get; }
	[Nullable(2)]
	public string sku { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x858B3F4 Offset: 0x85873F4 VA: 0x858B3F4
	public bool get_isAcknowledged() { }

	[CompilerGenerated]
	// RVA: 0x858B3FC Offset: 0x85873FC VA: 0x858B3FC Slot: 4
	public int get_purchaseState() { }

	[CompilerGenerated]
	// RVA: 0x858B404 Offset: 0x8587404 VA: 0x858B404 Slot: 5
	public List<string> get_skus() { }

	[CompilerGenerated]
	// RVA: 0x858B40C Offset: 0x858740C VA: 0x858B40C Slot: 6
	public string get_receipt() { }

	[CompilerGenerated]
	// RVA: 0x858B414 Offset: 0x8587414 VA: 0x858B414 Slot: 15
	public string get_signature() { }

	[CompilerGenerated]
	// RVA: 0x858B41C Offset: 0x858741C VA: 0x858B41C Slot: 16
	public string get_originalJson() { }

	[CompilerGenerated]
	// RVA: 0x858B424 Offset: 0x8587424 VA: 0x858B424 Slot: 9
	public string get_purchaseToken() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x858B42C Offset: 0x858742C VA: 0x858B42C Slot: 7
	public string get_obfuscatedAccountId() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x858B434 Offset: 0x8587434 VA: 0x858B434 Slot: 8
	public string get_obfuscatedProfileId() { }

	[CompilerGenerated]
	// RVA: 0x858B43C Offset: 0x858743C VA: 0x858B43C Slot: 10
	public IEnumerable<ProductDescription> get_productDescriptions() { }

	[NullableContext(2)]
	// RVA: 0x858B444 Offset: 0x8587444 VA: 0x858B444 Slot: 11
	public string get_sku() { }

	// RVA: 0x858B48C Offset: 0x858748C VA: 0x858B48C
	internal void .ctor(AndroidJavaObject purchase, IEnumerable<AndroidJavaObject> productDetailsEnum) { }

	// RVA: 0x858BE20 Offset: 0x8587E20 VA: 0x858BE20 Slot: 17
	public virtual bool IsAcknowledged() { }

	// RVA: 0x858BE28 Offset: 0x8587E28 VA: 0x858BE28 Slot: 18
	public virtual bool IsPurchased() { }

	// RVA: 0x858C078 Offset: 0x8588078 VA: 0x858C078 Slot: 19
	public virtual bool IsPending() { }
}

// Namespace: UnityEngine.Purchasing.Models
internal static class GooglePurchaseStateEnum // TypeDefIndex: 26373
{
	// Fields
	private static Nullable<int> s_Purchased; // 0x0
	private static Nullable<int> s_Pending; // 0x8

	// Methods

	// RVA: 0x858C374 Offset: 0x8588374 VA: 0x858C374
	private static AndroidJavaObject GetPurchaseStateJavaObject() { }

	// RVA: 0x858BE44 Offset: 0x8587E44 VA: 0x858BE44
	internal static int Purchased() { }

	// RVA: 0x858C094 Offset: 0x8588094 VA: 0x858C094
	internal static int Pending() { }
}

// Namespace: UnityEngine.Purchasing.Models
[Preserve]
internal class GooglePurchaseStateEnumProvider : IGooglePurchaseStateEnumProvider // TypeDefIndex: 26374
{
	// Methods

	// RVA: 0x858C3E0 Offset: 0x85883E0 VA: 0x858C3E0 Slot: 4
	public int Purchased() { }

	// RVA: 0x858C3E4 Offset: 0x85883E4 VA: 0x858C3E4 Slot: 5
	public int Pending() { }

	// RVA: 0x858C3E8 Offset: 0x85883E8 VA: 0x858C3E8
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGoogleFinishTransactionUseCase // TypeDefIndex: 26375
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Task FinishTransaction(ProductDefinition product, string purchaseToken, Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished);
}

// Namespace: UnityEngine.Purchasing.Interfaces
[NullableContext(2)]
internal interface IGoogleLastKnownProductService // TypeDefIndex: 26376
{
	// Properties
	public abstract string LastKnownOldProductId { get; set; }
	public abstract string LastKnownProductId { get; set; }
	public abstract Nullable<GooglePlayReplacementMode> LastKnownReplacementMode { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_LastKnownOldProductId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_LastKnownOldProductId(string value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_LastKnownProductId();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_LastKnownProductId(string value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Nullable<GooglePlayReplacementMode> get_LastKnownReplacementMode();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_LastKnownReplacementMode(Nullable<GooglePlayReplacementMode> value);
}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGooglePlayCheckEntitlementUseCase // TypeDefIndex: 26377
{}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGooglePurchaseBuilder // TypeDefIndex: 26378
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IEnumerable<IGooglePurchase> BuildPurchases(IEnumerable<AndroidJavaObject> purchases);
}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGooglePurchaseCallback // TypeDefIndex: 26379
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetPurchaseCallback(IStorePurchaseCallback purchaseCallback);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchCallback);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SetChangeSubscriptionCallback(IGooglePlayChangeSubscriptionCallback changeSubscriptionCallback);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnPurchaseSuccessful(IGooglePurchase purchase);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnPurchaseFailed(PurchaseFailureDescription purchaseFailureDescription);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void NotifyDeferredPurchase(IGooglePurchase purchase);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void NotifyDeferredProrationUpgradeDowngradeSubscription(string sku);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void NotifyUpgradeDowngradeSubscription(string sku);
}

// Namespace: UnityEngine.Purchasing.Interfaces
[NullableContext(1)]
internal interface IGooglePurchaseService // TypeDefIndex: 26380
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Purchase(ProductDefinition product, Order currentOrder, Nullable<GooglePlayReplacementMode> desiredReplacementMode);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetProductCache(IProductCache productCache);
}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGooglePurchaseStateEnumProvider // TypeDefIndex: 26381
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int Purchased();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int Pending();
}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGooglePurchasesUpdatedListener // TypeDefIndex: 26382
{
	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void add_OnPurchaseUpdated(Action<IGoogleBillingResult, List<IGooglePurchase>> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void remove_OnPurchaseUpdated(Action<IGoogleBillingResult, List<IGooglePurchase>> value);
}

// Namespace: UnityEngine.Purchasing.Interfaces
[NullableContext(1)]
internal interface IGoogleQueryPurchasesUseCase // TypeDefIndex: 26383
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Task<List<IGooglePurchase>> QueryPurchases();

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract Task<IGooglePurchase> GetPurchaseByToken(string purchaseToken);
}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IProductDetailsConverter // TypeDefIndex: 26384
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract List<ProductDescription> ConvertOnQueryProductDetailsResponse(IEnumerable<AndroidJavaObject> productDetails, IReadOnlyCollection<ProductDefinition> productDefinitions);
}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IProductDetailsQueryResponse // TypeDefIndex: 26385
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool IsRecoverable();
}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGooglePlayStoreCheckEntitlementService // TypeDefIndex: 26386
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetCheckEntitlementCallback(IStoreCheckEntitlementCallback entitlementCallback);
}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 26387
{
	// Methods

	// RVA: 0x858C3F0 Offset: 0x85883F0 VA: 0x858C3F0
	internal static uint ComputeStringHash(string s) { }
}

