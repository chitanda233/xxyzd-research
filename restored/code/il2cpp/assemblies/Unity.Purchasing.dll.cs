// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 25407
{}

// Namespace: Microsoft.CodeAnalysis
[CompilerGenerated]
[Embedded]
internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 25408
{
	// Methods

	// RVA: 0x853E3E4 Offset: 0x853A3E4 VA: 0x853E3E4
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(27524, AllowMultiple = False, Inherited = False)]
[CompilerGenerated]
[Embedded]
internal sealed class NullableAttribute : Attribute // TypeDefIndex: 25409
{
	// Fields
	public readonly byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x853E3EC Offset: 0x853A3EC VA: 0x853E3EC
	public void .ctor(byte ) { }

	// RVA: 0x853E474 Offset: 0x853A474 VA: 0x853E474
	public void .ctor(byte[] ) { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(5196, AllowMultiple = False, Inherited = False)]
[Embedded]
[CompilerGenerated]
internal sealed class NullableContextAttribute : Attribute // TypeDefIndex: 25410
{
	// Fields
	public readonly byte Flag; // 0x10

	// Methods

	// RVA: 0x853E4A4 Offset: 0x853A4A4 VA: 0x853E4A4
	public void .ctor(byte ) { }
}

// Namespace: Purchasing.Extension
internal abstract class InternalStore : Store, IInternalStore, IStore // TypeDefIndex: 25411
{
	// Fields
	internal IStoreConnectionStateService StoreConnectionStateService; // 0x50

	// Methods

	// RVA: 0x853E4CC Offset: 0x853A4CC VA: 0x853E4CC
	protected void .ctor() { }

	// RVA: 0x853E608 Offset: 0x853A608 VA: 0x853E608 Slot: 29
	public ConnectionState GetStoreConnectionState() { }

	// RVA: 0x853E6A8 Offset: 0x853A6A8 VA: 0x853E6A8 Slot: 28
	public void SetStoreConnectionState(ConnectionState connectionState) { }
}

// Namespace: UnityEngine.Purchasing
internal interface IAnalyticsAdapter // TypeDefIndex: 25412
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SendTransactionEvent(CartItem item, string receipt);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SendTransactionFailedEvent(PurchaseFailureDescription failureDescription);
}

// Namespace: UnityEngine.Purchasing
internal interface IAnalyticsClient // TypeDefIndex: 25413
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPurchaseSucceeded(ConfirmedOrder confirmedOrder);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnPurchaseFailed(FailedOrder failedOrder);
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
[Serializable]
public abstract class IapException : Exception // TypeDefIndex: 25414
{
	// Methods

	// RVA: 0x853E754 Offset: 0x853A754 VA: 0x853E754
	internal void .ctor() { }

	// RVA: 0x853E7AC Offset: 0x853A7AC VA: 0x853E7AC
	internal void .ctor(string message) { }

	// RVA: 0x853E814 Offset: 0x853A814 VA: 0x853E814
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
public class ServiceCreationException : IapException // TypeDefIndex: 25415
{
	// Methods

	// RVA: 0x853E894 Offset: 0x853A894 VA: 0x853E894
	internal void .ctor(string message) { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
public interface IProductService // TypeDefIndex: 25416
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void FetchProductsWithNoRetries(List<ProductDefinition> productDefinitions);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract ReadOnlyObservableCollection<Product> GetProducts();

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_OnProductsFetched(Action<List<Product>> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void remove_OnProductsFetched(Action<List<Product>> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void add_OnProductsFetchFailed(Action<ProductFetchFailed> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void remove_OnProductsFetchFailed(Action<ProductFetchFailed> value);
}

// Namespace: UnityEngine.Purchasing
internal interface IProductServiceFactory // TypeDefIndex: 25417
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IProductService Create(IStoreWrapper store);
}

// Namespace: UnityEngine.Purchasing
internal interface IProductServiceFactoryManager // TypeDefIndex: 25418
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IProductServiceFactory GetServiceFactory();
}

// Namespace: UnityEngine.Purchasing
internal interface IProductServiceFactoryManagerInjectionPoint // TypeDefIndex: 25419
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetServiceFactory(IProductServiceFactory serviceFactory);
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
public class ProductFetchFailed // TypeDefIndex: 25420
{
	// Fields
	[CompilerGenerated]
	private readonly List<ProductDefinition> <FailedFetchProducts>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <FailureReason>k__BackingField; // 0x18

	// Properties
	public List<ProductDefinition> FailedFetchProducts { get; }
	public string FailureReason { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x853E898 Offset: 0x853A898 VA: 0x853E898
	public List<ProductDefinition> get_FailedFetchProducts() { }

	[CompilerGenerated]
	// RVA: 0x853E8A0 Offset: 0x853A8A0 VA: 0x853E8A0
	public string get_FailureReason() { }

	// RVA: 0x853E8A8 Offset: 0x853A8A8 VA: 0x853E8A8
	internal void .ctor(List<ProductDefinition> products, string reason) { }
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
[Serializable]
public class ProductFetchFailureDescription : IRetryableRequestFailureDescription // TypeDefIndex: 25421
{
	// Fields
	public ProductFetchFailureReason reason; // 0x10
	public string message; // 0x18
	public bool isRetryable; // 0x20

	// Properties
	public ProductFetchFailureReason Reason { get; }
	public string Message { get; }
	public bool IsRetryable { get; }

	// Methods

	// RVA: 0x853E8EC Offset: 0x853A8EC VA: 0x853E8EC
	public ProductFetchFailureReason get_Reason() { }

	// RVA: 0x853E8F4 Offset: 0x853A8F4 VA: 0x853E8F4
	public string get_Message() { }

	// RVA: 0x853E8FC Offset: 0x853A8FC VA: 0x853E8FC Slot: 4
	public bool get_IsRetryable() { }

	// RVA: 0x853E904 Offset: 0x853A904 VA: 0x853E904
	public void .ctor(ProductFetchFailureReason reason, string message, bool isRetryable = False) { }
}

// Namespace: UnityEngine.Purchasing
public enum ProductFetchFailureReason // TypeDefIndex: 25422
{
	// Fields
	public int value__; // 0x0
	public const ProductFetchFailureReason ProviderUnavailable = 0;
	public const ProductFetchFailureReason ProductsUnavailable = 1;
	public const ProductFetchFailureReason Unknown = 2;
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
internal class ProductFetchRequest // TypeDefIndex: 25423
{
	// Fields
	[CompilerGenerated]
	private readonly ReadOnlyCollection<ProductDefinition> <RequestedProducts>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Action<List<Product>> <SuccessAction>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly Action<List<ProductDefinition>, string> <FailureAction>k__BackingField; // 0x20

	// Properties
	internal ReadOnlyCollection<ProductDefinition> RequestedProducts { get; }
	internal Action<List<Product>> SuccessAction { get; }
	internal Action<List<ProductDefinition>, string> FailureAction { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x853E950 Offset: 0x853A950 VA: 0x853E950
	internal ReadOnlyCollection<ProductDefinition> get_RequestedProducts() { }

	[CompilerGenerated]
	// RVA: 0x853E958 Offset: 0x853A958 VA: 0x853E958
	internal Action<List<Product>> get_SuccessAction() { }

	[CompilerGenerated]
	// RVA: 0x853E960 Offset: 0x853A960 VA: 0x853E960
	internal Action<List<ProductDefinition>, string> get_FailureAction() { }

	// RVA: 0x853E968 Offset: 0x853A968 VA: 0x853E968
	internal void .ctor(ReadOnlyCollection<ProductDefinition> products, Action<List<Product>> fetchSuccessAction, Action<List<ProductDefinition>, string> fetchFailureAction) { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
internal class ProductService : IProductService // TypeDefIndex: 25424
{
	// Fields
	private static readonly IRetryPolicy k_DefaultRetryPolicy; // 0x0
	private readonly IFetchProductsUseCase m_FetchProductsUseCase; // 0x10
	private readonly IStoreWrapper m_StoreWrapper; // 0x18
	private readonly IProductCache m_ProductCache; // 0x20
	[CompilerGenerated]
	[Nullable(new[] { 2, 1, 1 })]
	private Action<List<Product>> OnProductsFetched; // 0x28
	[CompilerGenerated]
	[Nullable(new[] { 2, 1 })]
	private Action<ProductFetchFailed> OnProductsFetchFailed; // 0x30

	// Methods

	[CompilerGenerated]
	// RVA: 0x853E9C8 Offset: 0x853A9C8 VA: 0x853E9C8 Slot: 6
	public void add_OnProductsFetched(Action<List<Product>> value) { }

	[CompilerGenerated]
	// RVA: 0x853EA78 Offset: 0x853AA78 VA: 0x853EA78 Slot: 7
	public void remove_OnProductsFetched(Action<List<Product>> value) { }

	[CompilerGenerated]
	// RVA: 0x853EB28 Offset: 0x853AB28 VA: 0x853EB28 Slot: 8
	public void add_OnProductsFetchFailed(Action<ProductFetchFailed> value) { }

	[CompilerGenerated]
	// RVA: 0x853EBD8 Offset: 0x853ABD8 VA: 0x853EBD8 Slot: 9
	public void remove_OnProductsFetchFailed(Action<ProductFetchFailed> value) { }

	// RVA: 0x853EC88 Offset: 0x853AC88 VA: 0x853EC88
	internal void .ctor(IFetchProductsUseCase fetchProductsUseCase, IStoreWrapper storeWrapper) { }

	// RVA: 0x853ED74 Offset: 0x853AD74 VA: 0x853ED74 Slot: 4
	public void FetchProductsWithNoRetries(List<ProductDefinition> productDefinitions) { }

	// RVA: 0x853ED7C Offset: 0x853AD7C VA: 0x853ED7C Slot: 10
	public void FetchProducts(List<ProductDefinition> productDefinitions, IRetryPolicy retryPolicy) { }

	// RVA: 0x853F1EC Offset: 0x853B1EC VA: 0x853F1EC Slot: 5
	public ReadOnlyObservableCollection<Product> GetProducts() { }

	// RVA: 0x853F290 Offset: 0x853B290 VA: 0x853F290
	private void HandleProductsFetched(List<Product> fetchedProducts) { }

	// RVA: 0x853F11C Offset: 0x853B11C VA: 0x853F11C
	private void HandleProductsFetchFailed(List<ProductDefinition> fetchedProducts, string reason) { }

	// RVA: 0x853EFBC Offset: 0x853AFBC VA: 0x853EFBC
	private void CheckStoreConnectionState() { }

	// RVA: 0x853F3A0 Offset: 0x853B3A0 VA: 0x853F3A0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
internal class ProductServiceContainer // TypeDefIndex: 25425
{
	// Fields
	[Nullable(2)]
	private static ProductServiceContainer s_Instance; // 0x0
	private readonly Dictionary<string, IProductService> m_InstantiatedServices; // 0x10

	// Methods

	// RVA: 0x853F4D8 Offset: 0x853B4D8 VA: 0x853F4D8
	internal static ProductServiceContainer Instance() { }

	// RVA: 0x853F5D8 Offset: 0x853B5D8 VA: 0x853F5D8
	internal IProductService FindService(string storeName) { }

	// RVA: 0x853F66C Offset: 0x853B66C VA: 0x853F66C
	internal void SetService(string storeName, IProductService service) { }

	// RVA: 0x853F550 Offset: 0x853B550 VA: 0x853F550
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
internal class ProductServiceDependencyInjector // TypeDefIndex: 25426
{
	// Fields
	private IStoreWrapper m_storeWrapper; // 0x10
	private IProductServiceFactoryManager m_ServiceFactoryManager; // 0x18

	// Methods

	// RVA: 0x853F768 Offset: 0x853B768 VA: 0x853F768
	internal void .ctor(IStoreWrapper storeWrapper) { }

	// RVA: 0x853F834 Offset: 0x853B834 VA: 0x853F834
	internal IProductService CreateProductService() { }
}

// Namespace: UnityEngine.Purchasing
internal class ProductServiceFactoryManager : IProductServiceFactoryManager, IProductServiceFactoryManagerInjectionPoint // TypeDefIndex: 25427
{
	// Fields
	private static ProductServiceFactoryManager s_Instance; // 0x0
	private IProductServiceFactory m_Factory; // 0x10

	// Methods

	// RVA: 0x853F7AC Offset: 0x853B7AC VA: 0x853F7AC
	internal static ProductServiceFactoryManager Instance() { }

	// RVA: 0x853F958 Offset: 0x853B958 VA: 0x853F958 Slot: 5
	public void SetServiceFactory(IProductServiceFactory serviceFactory) { }

	// RVA: 0x853F960 Offset: 0x853B960 VA: 0x853F960 Slot: 4
	public IProductServiceFactory GetServiceFactory() { }

	// RVA: 0x853F950 Offset: 0x853B950 VA: 0x853F950
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
internal static class ProductServiceProvider // TypeDefIndex: 25428
{
	// Methods

	// RVA: 0x853F968 Offset: 0x853B968 VA: 0x853F968
	public static IProductService GetDefaultProductService() { }

	// RVA: 0x853FA58 Offset: 0x853BA58 VA: 0x853FA58
	private static IProductService GetProductServiceInternal(IStoreWrapper storeWrapper) { }

	// RVA: 0x853FA7C Offset: 0x853BA7C VA: 0x853FA7C
	private static IProductService LocateExistingService(IStoreWrapper wrapper) { }

	// RVA: 0x853FB58 Offset: 0x853BB58 VA: 0x853FB58
	private static IProductService CreateNewService(IStoreWrapper wrapper) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FetchProductsUseCase.<>c__DisplayClass12_0 // TypeDefIndex: 25429
{
	// Fields
	[Nullable(new[] { 0, 1 })]
	public List<ProductDefinition> matchedDefinitions; // 0x10

	// Methods

	// RVA: 0x8540A54 Offset: 0x853CA54 VA: 0x8540A54
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x8540C18 Offset: 0x853CC18 VA: 0x8540C18
	internal bool <InvokeFailureIfIncomplete>b__0(ProductDefinition def) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FetchProductsUseCase.<>c__DisplayClass6_0 // TypeDefIndex: 25430
{
	// Fields
	[Nullable(0)]
	public FetchProductsUseCase <>4__this; // 0x10
	[Nullable(0)]
	public ProductFetchRequest request; // 0x18

	// Methods

	// RVA: 0x854018C Offset: 0x853C18C VA: 0x854018C
	public void .ctor() { }

	// RVA: 0x8540C7C Offset: 0x853CC7C VA: 0x8540C7C
	internal void <ProcessValidFetchRequest>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FetchProductsUseCase.<>c__DisplayClass9_0 // TypeDefIndex: 25431
{
	// Fields
	[Nullable(0)]
	public ProductDescription description; // 0x10

	// Methods

	// RVA: 0x8540A08 Offset: 0x853CA08 VA: 0x8540A08
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x8540D38 Offset: 0x853CD38 VA: 0x8540D38
	internal bool <GetMatchingDefinition>b__0(ProductDefinition definition) { }
}

// Namespace: 
[CompilerGenerated]
private struct FetchProductsUseCase.<OnProductsFetchFailed>d__13 : IAsyncStateMachine // TypeDefIndex: 25432
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public FetchProductsUseCase <>4__this; // 0x28
	[Nullable(0)]
	public ProductFetchFailureDescription failureDescription; // 0x30
	[Nullable(0)]
	private TaskAwaiter<bool> <>u__1; // 0x38

	// Methods

	// RVA: 0x8540D60 Offset: 0x853CD60 VA: 0x8540D60 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x8540FEC Offset: 0x853CFEC VA: 0x8540FEC Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
internal class FetchProductsUseCase : IFetchProductsUseCase, IStoreProductsCallback // TypeDefIndex: 25433
{
	// Fields
	private readonly IStore m_Store; // 0x10
	private readonly IRetryService m_RetryService; // 0x18
	[Nullable(2)]
	private ProductFetchRequest m_ActiveRequest; // 0x20
	[Nullable(2)]
	private IRetryRequest m_ActiveRetryRequest; // 0x28

	// Methods

	[Preserve]
	// RVA: 0x853FD6C Offset: 0x853BD6C VA: 0x853FD6C
	internal void .ctor(IStore storeResponsible, IRetryService retryService) { }

	// RVA: 0x853FE54 Offset: 0x853BE54 VA: 0x853FE54 Slot: 4
	public void FetchProducts(List<ProductDefinition> productDefinitions, Action<List<Product>> fetchSuccessAction, Action<List<ProductDefinition>, string> fetchFailureAction, IRetryPolicy retryPolicy) { }

	// RVA: 0x853FFA0 Offset: 0x853BFA0 VA: 0x853FFA0
	private void ProcessValidFetchRequest(ProductFetchRequest request, IRetryPolicy retryPolicy) { }

	// RVA: 0x8540194 Offset: 0x853C194 VA: 0x8540194 Slot: 5
	public void OnProductsFetched(IReadOnlyList<ProductDescription> products) { }

	// RVA: 0x85401AC Offset: 0x853C1AC VA: 0x85401AC
	private void ProcessFetchedProductsAndInvokeCallbacks(ProductFetchRequest request, IReadOnlyList<ProductDescription> productsRetrieved) { }

	// RVA: 0x8540668 Offset: 0x853C668 VA: 0x8540668
	private ProductDefinition GetMatchingDefinition(ProductDescription description) { }

	// RVA: 0x8540764 Offset: 0x853C764 VA: 0x8540764
	private Product CreateMatchedProduct(ProductDefinition definition, ProductDescription description) { }

	// RVA: 0x85407DC Offset: 0x853C7DC VA: 0x85407DC
	private static void InvokeSuccessIfFetchedProducts(List<Product> fetchedProducts, Action<List<Product>> successCallback) { }

	// RVA: 0x854084C Offset: 0x853C84C VA: 0x854084C
	private static void InvokeFailureIfIncomplete(ProductFetchRequest request, List<ProductDefinition> matchedDefinitions) { }

	[AsyncStateMachine(typeof(FetchProductsUseCase.<OnProductsFetchFailed>d__13))]
	// RVA: 0x8540A5C Offset: 0x853CA5C VA: 0x8540A5C Slot: 6
	public void OnProductsFetchFailed(ProductFetchFailureDescription failureDescription) { }

	// RVA: 0x8540B2C Offset: 0x853CB2C VA: 0x8540B2C
	private void SendRequestFailureCallback(ProductFetchRequest productFetchRequest, ProductFetchFailureDescription failureDescription) { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
internal interface IFetchProductsUseCase // TypeDefIndex: 25434
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void FetchProducts(List<ProductDefinition> productDefinitions, Action<List<Product>> fetchSuccessAction, Action<List<ProductDefinition>, string> fetchFailureAction, IRetryPolicy retryPolicy);
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
internal class GooglePlayStoreExtendedPurchaseService : PurchaseService // TypeDefIndex: 25435
{
	// Fields
	private readonly IGooglePlayChangeSubscriptionUseCase m_GooglePlayChangeSubscriptionUseCase; // 0x98
	private readonly IRestoreTransactionsUseCase m_RestoreTransactionsUseCase; // 0xA0

	// Methods

	[Preserve]
	// RVA: 0x8540FF8 Offset: 0x853CFF8 VA: 0x8540FF8
	internal void .ctor(IGooglePlayChangeSubscriptionUseCase googlePlayChangeSubscriptionUseCase, IRestoreTransactionsUseCase restoreTransactionsUseCase, IFetchPurchasesUseCase fetchPurchasesUseCase, IPurchaseUseCase purchaseUseCase, IConfirmOrderUseCase confirmOrderUseCase, ICheckEntitlementUseCase checkEntitlementUseCase, IStoreWrapper storeWrapper, IAnalyticsClient analyticsClient) { }

	[NullableContext(2)]
	// RVA: 0x8541428 Offset: 0x853D428 VA: 0x8541428 Slot: 24
	protected override void RestoreTransactionsInternal(Action<bool, string> callback) { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
internal class GooglePlayGetGooglePurchaseUseCase // TypeDefIndex: 25436
{
	// Fields
	private readonly IStore m_Store; // 0x10

	// Methods

	[Preserve]
	// RVA: 0x85414D0 Offset: 0x853D4D0 VA: 0x85414D0
	public void .ctor(IStore store) { }
}

// Namespace: UnityEngine.Purchasing
internal class GooglePlayRestoreTransactionUseCase : IRestoreTransactionsUseCase // TypeDefIndex: 25437
{
	// Fields
	[Nullable(1)]
	private readonly IFetchPurchasesUseCase m_FetchPurchasesUseCase; // 0x10

	// Methods

	[NullableContext(1)]
	[Preserve]
	// RVA: 0x8541500 Offset: 0x853D500 VA: 0x8541500
	public void .ctor(IFetchPurchasesUseCase fetchPurchasesUseCase) { }

	[NullableContext(2)]
	// RVA: 0x8541530 Offset: 0x853D530 VA: 0x8541530 Slot: 4
	public void RestoreTransactions(Action<bool, string> callback) { }
}

// Namespace: UnityEngine.Purchasing
internal class GooglePlayCartValidator : StoreCartValidator // TypeDefIndex: 25438
{
	// Methods

	[Preserve]
	// RVA: 0x8541550 Offset: 0x853D550 VA: 0x8541550
	internal void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
internal interface IGooglePlayChangeSubscriptionCallback : IStorePurchaseCallback // TypeDefIndex: 25439
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnSubscriptionChangeDeferredUntilRenewal(string storeSpecificId);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnSubscriptionChange(string storeSpecificId);
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
internal interface IGooglePlayChangeSubscriptionUseCase // TypeDefIndex: 25440
{}

// Namespace: UnityEngine.Purchasing
internal class SubscriptionChangeRequest // TypeDefIndex: 25441
{
	// Fields
	[CompilerGenerated]
	private readonly Order <CurrentOrder>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Product <NewSubscription>k__BackingField; // 0x18

	// Properties
	internal Order CurrentOrder { get; }
	internal Product NewSubscription { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8541798 Offset: 0x853D798 VA: 0x8541798
	internal Order get_CurrentOrder() { }

	[CompilerGenerated]
	// RVA: 0x85417A0 Offset: 0x853D7A0 VA: 0x85417A0
	internal Product get_NewSubscription() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GooglePlayPurchaseUseCase.<>c__DisplayClass16_0 // TypeDefIndex: 25442
{
	// Fields
	[Nullable(0)]
	public string productId; // 0x10

	// Methods

	// RVA: 0x85423E4 Offset: 0x853E3E4 VA: 0x85423E4
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x85423EC Offset: 0x853E3EC VA: 0x85423EC
	internal bool <GetMatchingRequest>b__0(SubscriptionChangeRequest request) { }
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
internal class GooglePlayPurchaseUseCase : PurchaseUseCase, IGooglePlayChangeSubscriptionUseCase, IGooglePlayChangeSubscriptionCallback, IStorePurchaseCallback // TypeDefIndex: 25443
{
	// Fields
	private readonly List<SubscriptionChangeRequest> m_PendingRequests; // 0x30
	private IProductCache m_ProductCache; // 0x38
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private Action<DeferredPaymentUntilRenewalDateOrder> OnDeferredPaymentUntilRenewalDate; // 0x40

	// Methods

	// RVA: 0x85417A8 Offset: 0x853D7A8 VA: 0x85417A8
	internal void .ctor(IGooglePlayStore storeResponsible, IProductCache productCache) { }

	// RVA: 0x8541A94 Offset: 0x853DA94 VA: 0x8541A94
	private void OnSubscriptionChangeFailed(FailedOrder order) { }

	// RVA: 0x8541D38 Offset: 0x853DD38 VA: 0x8541D38 Slot: 14
	public void OnSubscriptionChangeDeferredUntilRenewal(string storeSpecificId) { }

	// RVA: 0x8542010 Offset: 0x853E010 VA: 0x8542010
	internal void InvokeOnDeferredPaymentUntilRenewalDate(DeferredPaymentUntilRenewalDateOrder pendingPurchase) { }

	// RVA: 0x85421C4 Offset: 0x853E1C4 VA: 0x85421C4 Slot: 15
	public void OnSubscriptionChange(string storeSpecificId) { }

	// RVA: 0x8541C50 Offset: 0x853DC50 VA: 0x8541C50
	private SubscriptionChangeRequest GetMatchingRequest(string productId) { }
}

// Namespace: UnityEngine.Purchasing
internal class AppleAppStoreCartValidator : StoreCartValidator // TypeDefIndex: 25444
{
	// Methods

	// RVA: 0x8542420 Offset: 0x853E420 VA: 0x8542420
	internal void .ctor(string storeName) { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(2)]
public interface IAppleStoreExtendedPurchaseService // TypeDefIndex: 25445
{
	// Properties
	[Obsolete]
	public abstract string appReceipt { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_appReceipt();
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
public class AggregateCartValidator : ICartValidator // TypeDefIndex: 25446
{
	// Fields
	private readonly List<ICartValidator> m_CartValidators; // 0x10

	// Methods

	// RVA: 0x8542488 Offset: 0x853E488 VA: 0x8542488
	public void .ctor(ICartValidator[] cartValidators) { }

	// RVA: 0x8542518 Offset: 0x853E518 VA: 0x8542518 Slot: 4
	public void Validate(ICart cart) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class NonNullCartValidator.<>c // TypeDefIndex: 25447
{
	// Fields
	public static readonly NonNullCartValidator.<>c <>9; // 0x0
	public static Func<CartItem, bool> <>9__0_0; // 0x8

	// Methods

	// RVA: 0x8542944 Offset: 0x853E944 VA: 0x8542944
	private static void .cctor() { }

	// RVA: 0x85429AC Offset: 0x853E9AC VA: 0x85429AC
	public void .ctor() { }

	// RVA: 0x85429B4 Offset: 0x853E9B4 VA: 0x85429B4
	internal bool <Validate>b__0_0(CartItem cartItem) { }
}

// Namespace: UnityEngine.Purchasing
public class NonNullCartValidator : ICartValidator // TypeDefIndex: 25448
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x85426C8 Offset: 0x853E6C8 VA: 0x85426C8 Slot: 4
	public void Validate(ICart cart) { }

	// RVA: 0x854293C Offset: 0x853E93C VA: 0x854293C
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
public class SingleProductCartValidator : ICartValidator // TypeDefIndex: 25449
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x85429D8 Offset: 0x853E9D8 VA: 0x85429D8 Slot: 4
	public void Validate(ICart cart) { }

	// RVA: 0x8542AE0 Offset: 0x853EAE0 VA: 0x8542AE0
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
public class SingleProductSingleQuantityCartValidator : AggregateCartValidator // TypeDefIndex: 25450
{
	// Methods

	// RVA: 0x85415C8 Offset: 0x853D5C8 VA: 0x85415C8
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SingleQuantityCartValidator.<>c // TypeDefIndex: 25451
{
	// Fields
	public static readonly SingleQuantityCartValidator.<>c <>9; // 0x0
	public static Func<CartItem, bool> <>9__0_0; // 0x8

	// Methods

	// RVA: 0x8542CB4 Offset: 0x853ECB4 VA: 0x8542CB4
	private static void .cctor() { }

	// RVA: 0x8542D1C Offset: 0x853ED1C VA: 0x8542D1C
	public void .ctor() { }

	// RVA: 0x8542D24 Offset: 0x853ED24 VA: 0x8542D24
	internal bool <Validate>b__0_0(CartItem cartItem) { }
}

// Namespace: UnityEngine.Purchasing
public class SingleQuantityCartValidator : ICartValidator // TypeDefIndex: 25452
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x8542AF0 Offset: 0x853EAF0 VA: 0x8542AF0 Slot: 4
	public void Validate(ICart cart) { }

	// RVA: 0x8542AE8 Offset: 0x853EAE8 VA: 0x8542AE8
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
internal class StoreCartValidator : ICartValidator // TypeDefIndex: 25453
{
	// Fields
	private readonly string m_StoreName; // 0x10
	private readonly ICartValidator m_CartValidator; // 0x18

	// Methods

	// RVA: 0x8541754 Offset: 0x853D754 VA: 0x8541754
	public void .ctor(string storeName, ICartValidator cartValidator) { }

	// RVA: 0x8542D44 Offset: 0x853ED44 VA: 0x8542D44 Slot: 4
	public void Validate(ICart cart) { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
[Serializable]
public class InvalidCartException : IapException // TypeDefIndex: 25454
{
	// Methods

	// RVA: 0x8542ED8 Offset: 0x853EED8 VA: 0x8542ED8
	public void .ctor() { }

	// RVA: 0x8542934 Offset: 0x853E934 VA: 0x8542934
	public void .ctor(string message) { }

	// RVA: 0x8542EDC Offset: 0x853EEDC VA: 0x8542EDC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
[Serializable]
public class InvalidCartItemException : IapException // TypeDefIndex: 25455
{
	// Methods

	// RVA: 0x8542EE0 Offset: 0x853EEE0 VA: 0x8542EE0
	public void .ctor() { }

	// RVA: 0x8542938 Offset: 0x853E938 VA: 0x8542938
	public void .ctor(string message) { }

	// RVA: 0x8542EE4 Offset: 0x853EEE4 VA: 0x8542EE4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: UnityEngine.Purchasing
public interface IOnEntitlementRevokedCallback // TypeDefIndex: 25456
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void onEntitlementRevoked(string productId);
}

// Namespace: UnityEngine.Purchasing
public interface IStoreCheckEntitlementCallback // TypeDefIndex: 25457
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnCheckEntitlement(ProductDefinition productDefinition, EntitlementStatus status, string message);
}

// Namespace: UnityEngine.Purchasing
public interface IStorePurchaseCallback // TypeDefIndex: 25458
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPurchaseSucceeded(PendingOrder order);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnPurchaseFailed(FailedOrder failedOrder);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnPurchaseDeferred(DeferredOrder deferredOrder);
}

// Namespace: UnityEngine.Purchasing
public interface IStorePurchaseConfirmCallback // TypeDefIndex: 25459
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnConfirmOrderSucceeded(string transactionId);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnConfirmOrderFailed(FailedOrder failedOrder);
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
public interface IStorePurchaseFetchCallback // TypeDefIndex: 25460
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnAllPurchasesRetrieved(IReadOnlyList<Order> orders);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnPurchasesRetrievalFailed(PurchasesFetchFailureDescription failureReason);
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
public interface ICartValidator // TypeDefIndex: 25461
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Validate(ICart cart);
}

// Namespace: UnityEngine.Purchasing
public interface ICart // TypeDefIndex: 25462
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IReadOnlyList<CartItem> Items();
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
public interface IPurchaseService // TypeDefIndex: 25463
{
	// Properties
	[Nullable(2)]
	public abstract IAppleStoreExtendedPurchaseService Apple { get; }

	// Methods

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract IAppleStoreExtendedPurchaseService get_Apple();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void PurchaseProduct(Product product);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void ConfirmPurchase(PendingOrder order);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void FetchPurchases();

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void RestoreTransactions(Action<bool, string> callback);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void add_OnPurchasePending(Action<PendingOrder> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 6
	public abstract void remove_OnPurchasePending(Action<PendingOrder> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 7
	public abstract void add_OnPurchaseConfirmed(Action<Order> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 8
	public abstract void remove_OnPurchaseConfirmed(Action<Order> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 9
	public abstract void add_OnPurchaseFailed(Action<FailedOrder> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 10
	public abstract void remove_OnPurchaseFailed(Action<FailedOrder> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 11
	public abstract void add_OnPurchaseDeferred(Action<DeferredOrder> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 12
	public abstract void remove_OnPurchaseDeferred(Action<DeferredOrder> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 13
	public abstract void add_OnPurchasesFetched(Action<Orders> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 14
	public abstract void remove_OnPurchasesFetched(Action<Orders> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 15
	public abstract void add_OnPurchasesFetchFailed(Action<PurchasesFetchFailureDescription> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 16
	public abstract void remove_OnPurchasesFetchFailed(Action<PurchasesFetchFailureDescription> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 17
	public abstract void add_OnCheckEntitlement(Action<Entitlement> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 18
	public abstract void remove_OnCheckEntitlement(Action<Entitlement> value);
}

// Namespace: UnityEngine.Purchasing
internal interface IPurchaseServiceFactory // TypeDefIndex: 25464
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IPurchaseService Create(IStoreWrapper store);
}

// Namespace: UnityEngine.Purchasing
internal interface IPurchaseServiceFactoryManager // TypeDefIndex: 25465
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IPurchaseServiceFactory GetServiceFactory();
}

// Namespace: UnityEngine.Purchasing
internal interface IPurchaseServiceFactoryManagerInjectionPoint // TypeDefIndex: 25466
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetServiceFactory(IPurchaseServiceFactory serviceFactory);
}

// Namespace: UnityEngine.Purchasing
internal interface ICheckEntitlementUseCase // TypeDefIndex: 25467
{}

// Namespace: UnityEngine.Purchasing
internal interface IConfirmOrderUseCase // TypeDefIndex: 25468
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ConfirmOrder(PendingOrder order, Action<PendingOrder, Order> action);
}

// Namespace: UnityEngine.Purchasing
internal interface IFetchPurchasesUseCase // TypeDefIndex: 25469
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void FetchPurchases(Action<Orders> fetchSuccessAction, Action<PurchasesFetchFailureDescription> fetchFailureAction);
}

// Namespace: UnityEngine.Purchasing
internal interface IOnEntitlementRevokedUseCase // TypeDefIndex: 25470
{
	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void add_OnEntitlementRevoked(Action<string> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void remove_OnEntitlementRevoked(Action<string> value);
}

// Namespace: UnityEngine.Purchasing
internal interface IPurchaseUseCase // TypeDefIndex: 25471
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Purchase(ICart cart);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void add_OnPurchaseSuccess(Action<PendingOrder> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void remove_OnPurchaseSuccess(Action<PendingOrder> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void add_OnPurchaseFail(Action<FailedOrder> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void remove_OnPurchaseFail(Action<FailedOrder> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void add_OnPurchaseDefer(Action<DeferredOrder> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 6
	public abstract void remove_OnPurchaseDefer(Action<DeferredOrder> value);
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(2)]
internal class AppleOrderInfo : OrderInfo, IAppleOrderInfo // TypeDefIndex: 25472
{
	// Fields
	[Nullable(1)]
	private IAppleAppReceiptViewer m_ReceiptViewer; // 0x28
	[CompilerGenerated]
	private string <OriginalTransactionID>k__BackingField; // 0x30
	[CompilerGenerated]
	private OwnershipType <OwnershipType>k__BackingField; // 0x38
	[CompilerGenerated]
	[Nullable(1)]
	private string <StoreName>k__BackingField; // 0x40
	[CompilerGenerated]
	private Nullable<Guid> <AppAccountToken>k__BackingField; // 0x48
	[CompilerGenerated]
	private string <jwsRepresentation>k__BackingField; // 0x60

	// Properties
	public string AppReceipt { get; }
	public string OriginalTransactionID { get; set; }
	public OwnershipType OwnershipType { set; }
	[Nullable(1)]
	public string StoreName { get; set; }
	public Nullable<Guid> AppAccountToken { get; set; }
	public string jwsRepresentation { set; }

	// Methods

	// RVA: 0x8542EE8 Offset: 0x853EEE8 VA: 0x8542EE8 Slot: 10
	public string get_AppReceipt() { }

	[CompilerGenerated]
	// RVA: 0x8542F88 Offset: 0x853EF88 VA: 0x8542F88 Slot: 11
	public string get_OriginalTransactionID() { }

	[CompilerGenerated]
	// RVA: 0x8542F90 Offset: 0x853EF90 VA: 0x8542F90 Slot: 14
	public void set_OriginalTransactionID(string value) { }

	[CompilerGenerated]
	// RVA: 0x8542F98 Offset: 0x853EF98 VA: 0x8542F98 Slot: 15
	public void set_OwnershipType(OwnershipType value) { }

	[NullableContext(1)]
	[CompilerGenerated]
	// RVA: 0x8542FA0 Offset: 0x853EFA0 VA: 0x8542FA0 Slot: 12
	public string get_StoreName() { }

	[CompilerGenerated]
	[NullableContext(1)]
	// RVA: 0x8542FA8 Offset: 0x853EFA8 VA: 0x8542FA8 Slot: 16
	public void set_StoreName(string value) { }

	[CompilerGenerated]
	// RVA: 0x8542FB0 Offset: 0x853EFB0 VA: 0x8542FB0 Slot: 13
	public Nullable<Guid> get_AppAccountToken() { }

	[CompilerGenerated]
	// RVA: 0x8542FC4 Offset: 0x853EFC4 VA: 0x8542FC4 Slot: 17
	public void set_AppAccountToken(Nullable<Guid> value) { }

	[CompilerGenerated]
	// RVA: 0x8542FD8 Offset: 0x853EFD8 VA: 0x8542FD8 Slot: 18
	public void set_jwsRepresentation(string value) { }

	[NullableContext(1)]
	// RVA: 0x8542FE0 Offset: 0x853EFE0 VA: 0x8542FE0
	public void .ctor(string transactionID, string storeName, IAppleAppReceiptViewer appReceiptViewer, string originalTransactionID, OwnershipType ownershipType, Nullable<Guid> appAccountToken, string signatureJws) { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
public class Cart : ICart // TypeDefIndex: 25473
{
	// Fields
	private readonly HashSet<CartItem> m_CartItems; // 0x10
	[Nullable(new[] { 2, 1 })]
	private IReadOnlyList<CartItem> m_CachedItemsList; // 0x18

	// Methods

	// RVA: 0x8542034 Offset: 0x853E034 VA: 0x8542034
	public void .ctor(CartItem cartItem) { }

	// RVA: 0x85431DC Offset: 0x853F1DC VA: 0x85431DC Slot: 4
	public IReadOnlyList<CartItem> Items() { }

	// RVA: 0x854324C Offset: 0x853F24C VA: 0x854324C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x8543310 Offset: 0x853F310 VA: 0x8543310 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
public class CartItem // TypeDefIndex: 25474
{
	// Fields
	[CompilerGenerated]
	private readonly Product <Product>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly int <Quantity>k__BackingField; // 0x18

	// Properties
	public Product Product { get; }
	public int Quantity { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8543464 Offset: 0x853F464 VA: 0x8543464
	public Product get_Product() { }

	[CompilerGenerated]
	// RVA: 0x854346C Offset: 0x853F46C VA: 0x854346C
	public int get_Quantity() { }

	// RVA: 0x854202C Offset: 0x853E02C VA: 0x854202C
	public void .ctor(Product product) { }

	// RVA: 0x8543474 Offset: 0x853F474 VA: 0x8543474
	internal void .ctor(Product product, int quantity) { }

	// RVA: 0x8543500 Offset: 0x853F500 VA: 0x8543500
	public static CartItem op_Implicit(Product product) { }

	// RVA: 0x854355C Offset: 0x853F55C VA: 0x854355C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x854357C Offset: 0x853F57C VA: 0x854357C Slot: 0
	public override bool Equals(object obj) { }
}

// Namespace: UnityEngine.Purchasing
internal class CheckEntitlementRequest // TypeDefIndex: 25475
{
	// Fields
	[CompilerGenerated]
	private readonly Product <ProductToCheck>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Action<Entitlement> <OnChecked>k__BackingField; // 0x18

	// Properties
	internal Product ProductToCheck { get; }
	internal Action<Entitlement> OnChecked { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8543620 Offset: 0x853F620 VA: 0x8543620
	internal Product get_ProductToCheck() { }

	[CompilerGenerated]
	// RVA: 0x8543628 Offset: 0x853F628 VA: 0x8543628
	internal Action<Entitlement> get_OnChecked() { }
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
public class ConfirmedOrder : Order // TypeDefIndex: 25476
{
	// Methods

	// RVA: 0x8543630 Offset: 0x853F630 VA: 0x8543630
	public void .ctor(ICart cart, IOrderInfo info) { }

	// RVA: 0x8543744 Offset: 0x853F744 VA: 0x8543744
	private List<IPurchasedProductInfo> FillPurchasedProductInfo() { }
}

// Namespace: UnityEngine.Purchasing
internal class ConfirmOrderRequest // TypeDefIndex: 25477
{
	// Fields
	[CompilerGenerated]
	private readonly PendingOrder <OrderToConfirm>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Action<PendingOrder, Order> <Action>k__BackingField; // 0x18

	// Properties
	internal PendingOrder OrderToConfirm { get; }
	internal Action<PendingOrder, Order> Action { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8543A94 Offset: 0x853FA94 VA: 0x8543A94
	internal PendingOrder get_OrderToConfirm() { }

	[CompilerGenerated]
	// RVA: 0x8543A9C Offset: 0x853FA9C VA: 0x8543A9C
	internal Action<PendingOrder, Order> get_Action() { }

	// RVA: 0x8543AA4 Offset: 0x853FAA4 VA: 0x8543AA4
	internal void .ctor(PendingOrder order, Action<PendingOrder, Order> purchaseSuccessAction) { }
}

// Namespace: UnityEngine.Purchasing
public class DeferredOrder : Order // TypeDefIndex: 25478
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x8543AE8 Offset: 0x853FAE8 VA: 0x8543AE8
	public void .ctor(ICart cart, IOrderInfo info) { }
}

// Namespace: UnityEngine.Purchasing
public class DeferredPaymentUntilRenewalDateOrder // TypeDefIndex: 25479
{
	// Fields
	[CompilerGenerated]
	private readonly Order <CurrentOrder>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Product <SubscriptionOrdered>k__BackingField; // 0x18

	// Methods

	// RVA: 0x8541FCC Offset: 0x853DFCC VA: 0x8541FCC
	public void .ctor(Order currentOrder, Product subscriptionOrdered) { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(2)]
[Nullable(0)]
public class Entitlement // TypeDefIndex: 25480
{
	// Fields
	[CompilerGenerated]
	private readonly Product <Product>k__BackingField; // 0x10
	[CompilerGenerated]
	private Order <Order>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly EntitlementStatus <Status>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly string <ErrorMessage>k__BackingField; // 0x28

	// Properties
	public Product Product { get; }
	internal Order Order { set; }
	public EntitlementStatus Status { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8543AEC Offset: 0x853FAEC VA: 0x8543AEC
	public Product get_Product() { }

	[CompilerGenerated]
	// RVA: 0x8543AF4 Offset: 0x853FAF4 VA: 0x8543AF4
	internal void set_Order(Order value) { }

	[CompilerGenerated]
	// RVA: 0x8543AFC Offset: 0x853FAFC VA: 0x8543AFC
	public EntitlementStatus get_Status() { }

	// RVA: 0x8543B04 Offset: 0x853FB04 VA: 0x8543B04
	internal void .ctor(Product product, Order order, EntitlementStatus status, string message) { }
}

// Namespace: UnityEngine.Purchasing
public enum EntitlementStatus // TypeDefIndex: 25481
{
	// Fields
	public int value__; // 0x0
	public const EntitlementStatus Unknown = 0;
	public const EntitlementStatus NotEntitled = 1;
	public const EntitlementStatus EntitledUntilConsumed = 2;
	public const EntitlementStatus EntitledButNotFinished = 3;
	public const EntitlementStatus FullyEntitled = 4;
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
public class FailedOrder : Order // TypeDefIndex: 25482
{
	// Fields
	private PurchaseFailureReason m_FailureReason; // 0x20
	private string m_Details; // 0x28

	// Properties
	public PurchaseFailureReason FailureReason { get; }
	public string Details { get; }

	// Methods

	// RVA: 0x8543B6C Offset: 0x853FB6C VA: 0x8543B6C
	public PurchaseFailureReason get_FailureReason() { }

	// RVA: 0x8543B74 Offset: 0x853FB74 VA: 0x8543B74
	public string get_Details() { }

	// RVA: 0x85420F0 Offset: 0x853E0F0 VA: 0x85420F0
	public void .ctor(ICart cart, PurchaseFailureReason reason, string details) { }

	// RVA: 0x8543B7C Offset: 0x853FB7C VA: 0x8543B7C
	public void .ctor(Order order, PurchaseFailureReason reason, string details) { }
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(2)]
internal class GoogleOrderInfo : OrderInfo, IGoogleOrderInfo // TypeDefIndex: 25483
{
	// Fields
	[CompilerGenerated]
	private string <ObfuscatedAccountId>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <ObfuscatedProfileId>k__BackingField; // 0x30

	// Properties
	public string ObfuscatedAccountId { get; set; }
	public string ObfuscatedProfileId { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8543BC0 Offset: 0x853FBC0 VA: 0x8543BC0 Slot: 10
	public string get_ObfuscatedAccountId() { }

	[CompilerGenerated]
	// RVA: 0x8543BC8 Offset: 0x853FBC8 VA: 0x8543BC8 Slot: 11
	public void set_ObfuscatedAccountId(string value) { }

	[CompilerGenerated]
	// RVA: 0x8543BD0 Offset: 0x853FBD0 VA: 0x8543BD0 Slot: 12
	public void set_ObfuscatedProfileId(string value) { }

	// RVA: 0x8543BD8 Offset: 0x853FBD8 VA: 0x8543BD8
	public void .ctor(string receipt, string transactionID, string storeName, string obfuscatedAccountId, string obfuscatedProfileId) { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(2)]
public interface IAppleOrderInfo // TypeDefIndex: 25484
{
	// Properties
	public abstract string AppReceipt { get; }
	public abstract string OriginalTransactionID { get; }
	[Nullable(1)]
	public abstract string StoreName { get; }
	public abstract Nullable<Guid> AppAccountToken { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_AppReceipt();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_OriginalTransactionID();

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_StoreName();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Nullable<Guid> get_AppAccountToken();
}

// Namespace: UnityEngine.Purchasing
[NullableContext(2)]
public interface IGoogleOrderInfo // TypeDefIndex: 25485
{
	// Properties
	public abstract string ObfuscatedAccountId { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_ObfuscatedAccountId();
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
public interface IOrderInfo // TypeDefIndex: 25486
{
	// Properties
	[Nullable(2)]
	public abstract IAppleOrderInfo Apple { get; }
	[Nullable(2)]
	public abstract IGoogleOrderInfo Google { get; }
	public abstract List<IPurchasedProductInfo> PurchasedProductInfo { get; set; }
	public abstract string Receipt { get; }
	public abstract string TransactionID { get; }

	// Methods

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract IAppleOrderInfo get_Apple();

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract IGoogleOrderInfo get_Google();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract List<IPurchasedProductInfo> get_PurchasedProductInfo();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_PurchasedProductInfo(List<IPurchasedProductInfo> value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_Receipt();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_TransactionID();
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
public interface IPurchasedProductInfo // TypeDefIndex: 25487
{
	// Properties
	public abstract string productId { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_productId();
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
public abstract class Order // TypeDefIndex: 25488
{
	// Fields
	[CompilerGenerated]
	private ICart <CartOrdered>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly IOrderInfo <Info>k__BackingField; // 0x18

	// Properties
	public ICart CartOrdered { get; set; }
	public IOrderInfo Info { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8543C18 Offset: 0x853FC18 VA: 0x8543C18
	public ICart get_CartOrdered() { }

	[CompilerGenerated]
	// RVA: 0x8543C20 Offset: 0x853FC20 VA: 0x8543C20
	internal void set_CartOrdered(ICart value) { }

	[CompilerGenerated]
	// RVA: 0x8543C28 Offset: 0x853FC28 VA: 0x8543C28
	public IOrderInfo get_Info() { }

	// RVA: 0x8543700 Offset: 0x853F700 VA: 0x8543700
	protected void .ctor(ICart cart, IOrderInfo info) { }
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
internal class OrderInfo : IOrderInfo // TypeDefIndex: 25489
{
	// Fields
	[CompilerGenerated]
	private List<IPurchasedProductInfo> <PurchasedProductInfo>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <TransactionID>k__BackingField; // 0x18
	private string m_Receipt; // 0x20

	// Properties
	[Nullable(2)]
	public IAppleOrderInfo Apple { get; }
	[Nullable(2)]
	public IGoogleOrderInfo Google { get; }
	public List<IPurchasedProductInfo> PurchasedProductInfo { get; set; }
	public string TransactionID { get; }
	public string Receipt { get; set; }

	// Methods

	[NullableContext(2)]
	// RVA: 0x8543C30 Offset: 0x853FC30 VA: 0x8543C30 Slot: 4
	public IAppleOrderInfo get_Apple() { }

	[NullableContext(2)]
	// RVA: 0x8543C78 Offset: 0x853FC78 VA: 0x8543C78 Slot: 5
	public IGoogleOrderInfo get_Google() { }

	[CompilerGenerated]
	// RVA: 0x8543CC0 Offset: 0x853FCC0 VA: 0x8543CC0 Slot: 6
	public List<IPurchasedProductInfo> get_PurchasedProductInfo() { }

	[CompilerGenerated]
	// RVA: 0x8543CC8 Offset: 0x853FCC8 VA: 0x8543CC8 Slot: 7
	public void set_PurchasedProductInfo(List<IPurchasedProductInfo> value) { }

	[CompilerGenerated]
	// RVA: 0x8543CD0 Offset: 0x853FCD0 VA: 0x8543CD0 Slot: 9
	public string get_TransactionID() { }

	// RVA: 0x8543CD8 Offset: 0x853FCD8 VA: 0x8543CD8 Slot: 8
	public string get_Receipt() { }

	// RVA: 0x8543E4C Offset: 0x853FE4C VA: 0x8543E4C
	private void set_Receipt(string value) { }

	// RVA: 0x8543CDC Offset: 0x853FCDC VA: 0x8543CDC
	private string GetReceipt() { }

	// RVA: 0x8543E50 Offset: 0x853FE50 VA: 0x8543E50
	private void SetReceipt(string receipt) { }

	// RVA: 0x85430D8 Offset: 0x853F0D8 VA: 0x85430D8
	public void .ctor(string receipt, string transactionID, string storeName) { }

	// RVA: 0x8543E8C Offset: 0x853FE8C VA: 0x8543E8C
	private static string CreateUnifiedReceipt(string rawReceipt, string transactionId, string storeName) { }
}

// Namespace: UnityEngine.Purchasing
public class Orders // TypeDefIndex: 25490
{
	// Fields
	[CompilerGenerated]
	private readonly IReadOnlyList<ConfirmedOrder> <ConfirmedOrders>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly IReadOnlyList<PendingOrder> <PendingOrders>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly IReadOnlyList<DeferredOrder> <DeferredOrders>k__BackingField; // 0x20

	// Properties
	public IReadOnlyList<ConfirmedOrder> ConfirmedOrders { get; }
	public IReadOnlyList<PendingOrder> PendingOrders { get; }
	public IReadOnlyList<DeferredOrder> DeferredOrders { get; }

	// Methods

	// RVA: 0x8543F34 Offset: 0x853FF34 VA: 0x8543F34
	public void .ctor(IReadOnlyList<ConfirmedOrder> confirmedOrders, IReadOnlyList<PendingOrder> pendingOrders, IReadOnlyList<DeferredOrder> deferredOrders) { }

	[CompilerGenerated]
	// RVA: 0x8543F94 Offset: 0x853FF94 VA: 0x8543F94
	public IReadOnlyList<ConfirmedOrder> get_ConfirmedOrders() { }

	[CompilerGenerated]
	// RVA: 0x8543F9C Offset: 0x853FF9C VA: 0x8543F9C
	public IReadOnlyList<PendingOrder> get_PendingOrders() { }

	[CompilerGenerated]
	// RVA: 0x8543FA4 Offset: 0x853FFA4 VA: 0x8543FA4
	public IReadOnlyList<DeferredOrder> get_DeferredOrders() { }
}

// Namespace: UnityEngine.Purchasing
public enum OwnershipType // TypeDefIndex: 25491
{
	// Fields
	public int value__; // 0x0
	public const OwnershipType Undefined = -1;
	public const OwnershipType Purchased = 0;
	public const OwnershipType FamilyShared = 1;
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
public class PendingOrder : Order // TypeDefIndex: 25492
{
	// Methods

	// RVA: 0x8543FAC Offset: 0x853FFAC VA: 0x8543FAC
	public void .ctor(ICart cart, IOrderInfo info) { }

	// RVA: 0x854407C Offset: 0x854007C VA: 0x854407C
	private List<IPurchasedProductInfo> FillPurchasedProductInfo() { }
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
internal class PurchasedProductInfo : IPurchasedProductInfo // TypeDefIndex: 25493
{
	// Fields
	[CompilerGenerated]
	private readonly string <productId>k__BackingField; // 0x10
	[CompilerGenerated]
	[Nullable(2)]
	private SubscriptionInfo <subscriptionInfo>k__BackingField; // 0x18

	// Properties
	public string productId { get; }
	[Nullable(2)]
	private SubscriptionInfo subscriptionInfo { set; }

	// Methods

	// RVA: 0x85439E8 Offset: 0x853F9E8 VA: 0x85439E8
	public void .ctor(string productId, string receipt, ProductType productType) { }

	// RVA: 0x8544380 Offset: 0x8540380 VA: 0x8544380
	private void TryInitSubscriptionInfo(SubscriptionInfoHelper subscriptionInfoHelper) { }

	[CompilerGenerated]
	// RVA: 0x85446C0 Offset: 0x85406C0 VA: 0x85446C0 Slot: 4
	public string get_productId() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x85446C8 Offset: 0x85406C8 VA: 0x85446C8
	private void set_subscriptionInfo(SubscriptionInfo value) { }
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
[Serializable]
public class PurchasesFetchFailureDescription // TypeDefIndex: 25494
{
	// Fields
	public PurchasesFetchFailureReason failureReason; // 0x10
	public string message; // 0x18

	// Properties
	public PurchasesFetchFailureReason FailureReason { get; }
	public string Message { get; }

	// Methods

	// RVA: 0x85446D0 Offset: 0x85406D0 VA: 0x85446D0
	public PurchasesFetchFailureReason get_FailureReason() { }

	// RVA: 0x85446D8 Offset: 0x85406D8 VA: 0x85446D8
	public string get_Message() { }

	// RVA: 0x85446E0 Offset: 0x85406E0 VA: 0x85446E0
	public void .ctor(PurchasesFetchFailureReason reason, string message) { }
}

// Namespace: UnityEngine.Purchasing
public enum PurchasesFetchFailureReason // TypeDefIndex: 25495
{
	// Fields
	public int value__; // 0x0
	public const PurchasesFetchFailureReason PurchasingUnavailable = 0;
	public const PurchasesFetchFailureReason StoreNotConnected = 1;
	public const PurchasesFetchFailureReason Unknown = 2;
}

// Namespace: UnityEngine.Purchasing
public class SubscriptionInfo // TypeDefIndex: 25496
{
	// Fields
	private readonly Result m_IsSubscribed; // 0x10
	private readonly Result m_IsExpired; // 0x14
	private readonly Result m_IsCancelled; // 0x18
	private readonly Result m_IsFreeTrial; // 0x1C
	private readonly Result m_IsAutoRenewing; // 0x20
	private readonly Result m_IsIntroductoryPricePeriod; // 0x24
	private readonly string m_ProductId; // 0x28
	private readonly DateTime m_PurchaseDate; // 0x30
	private readonly DateTime m_SubscriptionExpireDate; // 0x38
	private readonly DateTime m_SubscriptionCancelDate; // 0x40
	private readonly TimeSpan m_RemainedTime; // 0x48
	private readonly string m_IntroductoryPrice; // 0x50
	private readonly TimeSpan m_IntroductoryPricePeriod; // 0x58
	private readonly long m_IntroductoryPriceCycles; // 0x60
	private readonly TimeSpan m_FreeTrialPeriod; // 0x68
	private readonly TimeSpan m_SubscriptionPeriod; // 0x70
	private readonly string m_FreeTrialPeriodString; // 0x78
	private readonly string m_SKUDetails; // 0x80

	// Methods

	// RVA: 0x8544718 Offset: 0x8540718 VA: 0x8544718
	public void .ctor(AppleInAppPurchaseReceipt r, string introJson) { }

	// RVA: 0x8544FFC Offset: 0x8540FFC VA: 0x8544FFC
	public void .ctor(string skuDetails, bool isAutoRenewing, DateTime purchaseDate, bool isFreeTrial, bool hasIntroductoryPriceTrial, bool purchaseHistorySupported, string updateMetadata) { }

	// RVA: 0x8545F88 Offset: 0x8541F88 VA: 0x8545F88
	private static DateTime NextBillingDate(DateTime billingBeginDate, TimeSpanUnits units) { }

	// RVA: 0x8545C74 Offset: 0x8541C74 VA: 0x8545C74
	private static TimeSpan AccumulateIntroductoryDuration(TimeSpanUnits units, long cycles) { }

	// RVA: 0x8545A78 Offset: 0x8541A78 VA: 0x8545A78
	private static TimeSpan ComputePeriodTimeSpan(TimeSpanUnits units) { }

	// RVA: 0x8545D28 Offset: 0x8541D28 VA: 0x8545D28
	private static double ComputeExtraTime(string metadata, double newSKUPeriodInSeconds) { }

	// RVA: 0x8545B34 Offset: 0x8541B34 VA: 0x8545B34
	private static TimeSpan ParseTimeSpan(string periodString) { }

	// RVA: 0x854584C Offset: 0x854184C VA: 0x854584C
	private static TimeSpanUnits ParsePeriodTimeSpanUnits(string timeSpan) { }
}

// Namespace: UnityEngine.Purchasing
public enum Result // TypeDefIndex: 25497
{
	// Fields
	public int value__; // 0x0
	public const Result True = 0;
	public const Result False = 1;
	public const Result Unsupported = 2;
}

// Namespace: UnityEngine.Purchasing
public enum SubscriptionPeriodUnit // TypeDefIndex: 25498
{
	// Fields
	public int value__; // 0x0
	public const SubscriptionPeriodUnit Day = 0;
	public const SubscriptionPeriodUnit Week = 1;
	public const SubscriptionPeriodUnit Month = 2;
	public const SubscriptionPeriodUnit Year = 3;
	public const SubscriptionPeriodUnit NotAvailable = 4;
}

// Namespace: UnityEngine.Purchasing
internal enum AppleStoreProductType // TypeDefIndex: 25499
{
	// Fields
	public int value__; // 0x0
	public const AppleStoreProductType NonConsumable = 0;
	public const AppleStoreProductType Consumable = 1;
	public const AppleStoreProductType NonRenewingSubscription = 2;
	public const AppleStoreProductType AutoRenewingSubscription = 3;
}

// Namespace: UnityEngine.Purchasing
public class TimeSpanUnits // TypeDefIndex: 25500
{
	// Fields
	public double days; // 0x10
	public int months; // 0x18
	public int years; // 0x1C

	// Methods

	// RVA: 0x85460CC Offset: 0x85420CC VA: 0x85460CC
	public void .ctor(double d, int m, int y) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SubscriptionInfoHelper.<>c // TypeDefIndex: 25501
{
	// Fields
	public static readonly SubscriptionInfoHelper.<>c <>9; // 0x0
	public static Comparison<AppleInAppPurchaseReceipt> <>9__7_0; // 0x8
	public static Func<object, string> <>9__8_0; // 0x10

	// Methods

	// RVA: 0x8546CBC Offset: 0x8542CBC VA: 0x8546CBC
	private static void .cctor() { }

	// RVA: 0x8546D24 Offset: 0x8542D24 VA: 0x8546D24
	public void .ctor() { }

	// RVA: 0x8546D2C Offset: 0x8542D2C VA: 0x8546D2C
	internal int <FindMostRecentReceipt>b__7_0(AppleInAppPurchaseReceipt b, AppleInAppPurchaseReceipt a) { }

	// RVA: 0x8546DB0 Offset: 0x8542DB0 VA: 0x8546DB0
	internal string <GetGooglePlayStoreSubInfo>b__8_0(object obj) { }
}

// Namespace: UnityEngine.Purchasing
public class SubscriptionInfoHelper // TypeDefIndex: 25502
{
	// Fields
	private readonly string m_Receipt; // 0x10
	private readonly string m_ProductId; // 0x18
	private readonly string m_IntroJson; // 0x20

	// Methods

	// RVA: 0x8544320 Offset: 0x8540320 VA: 0x8544320
	public void .ctor(string receipt, string id, string introJson) { }

	// RVA: 0x8544424 Offset: 0x8540424 VA: 0x8544424
	public SubscriptionInfo GetSubscriptionInfo() { }

	// RVA: 0x85467A4 Offset: 0x85427A4 VA: 0x85467A4
	private SubscriptionInfo GetAppleAppStoreSubInfo(string payload, string productId) { }

	// RVA: 0x8546B98 Offset: 0x8542B98 VA: 0x8546B98
	private static AppleInAppPurchaseReceipt FindMostRecentReceipt(List<AppleInAppPurchaseReceipt> receipts) { }

	// RVA: 0x8546108 Offset: 0x8542108 VA: 0x8546108
	private static SubscriptionInfo GetGooglePlayStoreSubInfo(string payload) { }
}

// Namespace: UnityEngine.Purchasing
[Serializable]
public class ReceiptParserException : IapException // TypeDefIndex: 25503
{
	// Methods

	// RVA: 0x8546E0C Offset: 0x8542E0C VA: 0x8546E0C
	public void .ctor() { }

	// RVA: 0x8546E10 Offset: 0x8542E10 VA: 0x8546E10
	public void .ctor(string message) { }

	// RVA: 0x8546E14 Offset: 0x8542E14 VA: 0x8546E14
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: UnityEngine.Purchasing
[Serializable]
public class InvalidProductTypeException : ReceiptParserException // TypeDefIndex: 25504
{
	// Methods

	// RVA: 0x8544F44 Offset: 0x8540F44 VA: 0x8544F44
	public void .ctor() { }

	// RVA: 0x8546E18 Offset: 0x8542E18 VA: 0x8546E18
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: UnityEngine.Purchasing
[Serializable]
public class NullProductIdException : ReceiptParserException // TypeDefIndex: 25505
{
	// Methods

	// RVA: 0x85467A0 Offset: 0x85427A0 VA: 0x85467A0
	public void .ctor() { }

	// RVA: 0x8546E1C Offset: 0x8542E1C VA: 0x8546E1C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: UnityEngine.Purchasing
[Serializable]
public class NullReceiptException : ReceiptParserException // TypeDefIndex: 25506
{
	// Methods

	// RVA: 0x8546B94 Offset: 0x8542B94 VA: 0x8546B94
	public void .ctor() { }

	// RVA: 0x8546E20 Offset: 0x8542E20 VA: 0x8546E20
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: UnityEngine.Purchasing
[Serializable]
public class StoreSubscriptionInfoNotSupportedException : ReceiptParserException // TypeDefIndex: 25507
{
	// Methods

	// RVA: 0x8546B90 Offset: 0x8542B90 VA: 0x8546B90
	public void .ctor(string message) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PurchaseService.<>c__DisplayClass40_0 // TypeDefIndex: 25508
{
	// Fields
	[Nullable(0)]
	public PendingOrder order; // 0x10

	// Methods

	// RVA: 0x8548690 Offset: 0x8544690 VA: 0x8548690
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x8549E94 Offset: 0x8545E94 VA: 0x8549E94
	internal bool <RemovePendingOrders>b__0(PendingOrder pendingOrder) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PurchaseService.<>c__DisplayClass41_0 // TypeDefIndex: 25509
{
	// Fields
	[Nullable(0)]
	public ICart pendingOrderItems; // 0x10

	// Methods

	// RVA: 0x8548698 Offset: 0x8544698 VA: 0x8548698
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x8549FC0 Offset: 0x8545FC0 VA: 0x8549FC0
	internal bool <RemoveDeferredOrders>b__0(DeferredOrder deferredOrder) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PurchaseService.<>c__DisplayClass56_0 // TypeDefIndex: 25510
{
	// Fields
	[Nullable(0)]
	public PurchaseService <>4__this; // 0x10
	[Nullable(new[] { 0, 2 })]
	public Action<bool, string> callback; // 0x18

	// Methods

	// RVA: 0x8549C5C Offset: 0x8545C5C VA: 0x8549C5C
	public void .ctor() { }

	[NullableContext(2)]
	// RVA: 0x8549FE4 Offset: 0x8545FE4 VA: 0x8549FE4
	internal void <RestoreTransactions>b__0(bool success, string error) { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
public class PurchaseService : IPurchaseService // TypeDefIndex: 25511
{
	// Fields
	private readonly IFetchPurchasesUseCase m_FetchPurchasesUseCase; // 0x10
	private readonly IPurchaseUseCase m_PurchaseUseCase; // 0x18
	private readonly IConfirmOrderUseCase m_ConfirmOrderUseCase; // 0x20
	private readonly ICheckEntitlementUseCase m_CheckEntitlementUseCase; // 0x28
	internal readonly ObservableCollection<Order> m_Purchases; // 0x30
	private readonly ReadOnlyObservableCollection<Order> m_PurchasesReadOnly; // 0x38
	private readonly IStoreWrapper m_StoreWrapper; // 0x40
	private readonly IAnalyticsClient m_AnalyticsClient; // 0x48
	private bool m_ProcessFetchedPendingOrders; // 0x50
	private readonly HashSet<string> m_PurchasesProcessedInSession; // 0x58
	[CompilerGenerated]
	[Nullable(new[] { 2, 1 })]
	private Action<PendingOrder> OnPurchasePending; // 0x60
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private Action<Order> OnPurchaseConfirmed; // 0x68
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private Action<FailedOrder> OnPurchaseFailed; // 0x70
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private Action<DeferredOrder> OnPurchaseDeferred; // 0x78
	[CompilerGenerated]
	[Nullable(new[] { 2, 1 })]
	private Action<Orders> OnPurchasesFetched; // 0x80
	[CompilerGenerated]
	[Nullable(new[] { 2, 1 })]
	private Action<PurchasesFetchFailureDescription> OnPurchasesFetchFailed; // 0x88
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private Action<Entitlement> OnCheckEntitlement; // 0x90

	// Properties
	[Nullable(2)]
	public IAppleStoreExtendedPurchaseService Apple { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8546E24 Offset: 0x8542E24 VA: 0x8546E24 Slot: 9
	public void add_OnPurchasePending(Action<PendingOrder> value) { }

	[CompilerGenerated]
	// RVA: 0x8546ED4 Offset: 0x8542ED4 VA: 0x8546ED4 Slot: 10
	public void remove_OnPurchasePending(Action<PendingOrder> value) { }

	[CompilerGenerated]
	// RVA: 0x8546F84 Offset: 0x8542F84 VA: 0x8546F84 Slot: 11
	public void add_OnPurchaseConfirmed(Action<Order> value) { }

	[CompilerGenerated]
	// RVA: 0x8547034 Offset: 0x8543034 VA: 0x8547034 Slot: 12
	public void remove_OnPurchaseConfirmed(Action<Order> value) { }

	[CompilerGenerated]
	// RVA: 0x85470E4 Offset: 0x85430E4 VA: 0x85470E4 Slot: 13
	public void add_OnPurchaseFailed(Action<FailedOrder> value) { }

	[CompilerGenerated]
	// RVA: 0x8547194 Offset: 0x8543194 VA: 0x8547194 Slot: 14
	public void remove_OnPurchaseFailed(Action<FailedOrder> value) { }

	[CompilerGenerated]
	// RVA: 0x8547244 Offset: 0x8543244 VA: 0x8547244 Slot: 15
	public void add_OnPurchaseDeferred(Action<DeferredOrder> value) { }

	[CompilerGenerated]
	// RVA: 0x85472F4 Offset: 0x85432F4 VA: 0x85472F4 Slot: 16
	public void remove_OnPurchaseDeferred(Action<DeferredOrder> value) { }

	[CompilerGenerated]
	// RVA: 0x85473A4 Offset: 0x85433A4 VA: 0x85473A4 Slot: 17
	public void add_OnPurchasesFetched(Action<Orders> value) { }

	[CompilerGenerated]
	// RVA: 0x8547454 Offset: 0x8543454 VA: 0x8547454 Slot: 18
	public void remove_OnPurchasesFetched(Action<Orders> value) { }

	[CompilerGenerated]
	// RVA: 0x8547504 Offset: 0x8543504 VA: 0x8547504 Slot: 19
	public void add_OnPurchasesFetchFailed(Action<PurchasesFetchFailureDescription> value) { }

	[CompilerGenerated]
	// RVA: 0x85475B4 Offset: 0x85435B4 VA: 0x85475B4 Slot: 20
	public void remove_OnPurchasesFetchFailed(Action<PurchasesFetchFailureDescription> value) { }

	[CompilerGenerated]
	// RVA: 0x8547664 Offset: 0x8543664 VA: 0x8547664 Slot: 21
	public void add_OnCheckEntitlement(Action<Entitlement> value) { }

	[CompilerGenerated]
	// RVA: 0x8547714 Offset: 0x8543714 VA: 0x8547714 Slot: 22
	public void remove_OnCheckEntitlement(Action<Entitlement> value) { }

	// RVA: 0x8541054 Offset: 0x853D054 VA: 0x8541054
	internal void .ctor(IFetchPurchasesUseCase fetchPurchasesUseCase, IPurchaseUseCase purchaseUseCase, IConfirmOrderUseCase confirmOrderUseCase, ICheckEntitlementUseCase checkEntitlementUseCase, IStoreWrapper storeWrapper, IAnalyticsClient analyticsClient) { }

	[NullableContext(2)]
	// RVA: 0x85477C4 Offset: 0x85437C4 VA: 0x85477C4 Slot: 4
	public IAppleStoreExtendedPurchaseService get_Apple() { }

	// RVA: 0x854780C Offset: 0x854380C VA: 0x854780C Slot: 5
	public void PurchaseProduct(Product product) { }

	// RVA: 0x85479B4 Offset: 0x85439B4 VA: 0x85479B4 Slot: 23
	public void Purchase(ICart cart) { }

	// RVA: 0x8547D20 Offset: 0x8543D20 VA: 0x8547D20
	internal void PurchaseSucceeded(PendingOrder order) { }

	// RVA: 0x8548198 Offset: 0x8544198 VA: 0x8548198
	private void RemovePendingOrders(PendingOrder order) { }

	// RVA: 0x8547EF0 Offset: 0x8543EF0 VA: 0x8547EF0
	private void RemoveDeferredOrders(PendingOrder pendingOrder) { }

	// RVA: 0x85486A0 Offset: 0x85446A0 VA: 0x85486A0
	internal void PurchaseFailed(FailedOrder order) { }

	// RVA: 0x8548774 Offset: 0x8544774 VA: 0x8548774
	private void PurchaseDeferred(DeferredOrder order) { }

	// RVA: 0x85487F4 Offset: 0x85447F4 VA: 0x85487F4 Slot: 6
	public void ConfirmPurchase(PendingOrder order) { }

	// RVA: 0x85489F4 Offset: 0x85449F4 VA: 0x85489F4
	private FailedOrder ConfirmPurchaseValidations(PendingOrder order) { }

	// RVA: 0x8548C10 Offset: 0x8544C10 VA: 0x8548C10
	private void OnConfirmSucceeded(PendingOrder pendingOrder, ConfirmedOrder confirmedOrder) { }

	// RVA: 0x8548BF4 Offset: 0x8544BF4 VA: 0x8548BF4
	private void OnConfirmFailed(FailedOrder failedOrder) { }

	// RVA: 0x8548D24 Offset: 0x8544D24 VA: 0x8548D24 Slot: 7
	public void FetchPurchases() { }

	// RVA: 0x8548FE8 Offset: 0x8544FE8 VA: 0x8548FE8
	private void OnFetchSuccess(Orders fetchedPurchases) { }

	// RVA: 0x8549A24 Offset: 0x8545A24 VA: 0x8549A24
	private bool WasPurchaseAlreadyProcessed(string transactionId) { }

	// RVA: 0x854859C Offset: 0x854459C VA: 0x854859C
	private void ProcessPendingOrder(PendingOrder fetchedPurchase) { }

	// RVA: 0x8548FCC Offset: 0x8544FCC VA: 0x8548FCC
	private void OnFetchFailure(PurchasesFetchFailureDescription fetchFailed) { }

	[NullableContext(2)]
	// RVA: 0x8549A7C Offset: 0x8545A7C VA: 0x8549A7C Slot: 8
	public void RestoreTransactions(Action<bool, string> callback) { }

	[NullableContext(2)]
	// RVA: 0x8549C64 Offset: 0x8545C64 VA: 0x8549C64 Slot: 24
	protected virtual void RestoreTransactionsInternal(Action<bool, string> callback) { }

	// RVA: 0x8549D34 Offset: 0x8545D34 VA: 0x8549D34 Slot: 25
	public ReadOnlyObservableCollection<Order> GetPurchases() { }

	// RVA: 0x8547C70 Offset: 0x8543C70 VA: 0x8547C70
	internal bool IsStoreConnected() { }

	[CompilerGenerated]
	[NullableContext(0)]
	// RVA: 0x8549D3C Offset: 0x8545D3C VA: 0x8549D3C
	private void <ConfirmPurchase>b__44_0(PendingOrder pendingOrder, Order resultOrder) { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
internal class PurchaseServiceContainer // TypeDefIndex: 25512
{
	// Fields
	[Nullable(2)]
	private static PurchaseServiceContainer s_Instance; // 0x0
	[Nullable(new[] { 1, 2, 1 })]
	private readonly Dictionary<string, IPurchaseService> m_InstantiatedServices; // 0x10

	// Methods

	// RVA: 0x854A040 Offset: 0x8546040 VA: 0x854A040
	internal static PurchaseServiceContainer Instance() { }

	// RVA: 0x854A140 Offset: 0x8546140 VA: 0x854A140
	internal IPurchaseService FindService(string storeName) { }

	// RVA: 0x854A1D4 Offset: 0x85461D4 VA: 0x854A1D4
	internal void SetService(string storeName, IPurchaseService service) { }

	// RVA: 0x854A0B8 Offset: 0x85460B8 VA: 0x854A0B8
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
internal class PurchaseServiceDependencyInjector // TypeDefIndex: 25513
{
	// Fields
	private IStoreWrapper m_storeWrapper; // 0x10
	private IPurchaseServiceFactoryManager m_ServiceFactoryManager; // 0x18

	// Methods

	// RVA: 0x854A2D0 Offset: 0x85462D0 VA: 0x854A2D0
	internal void .ctor(IStoreWrapper storeWrapper) { }

	// RVA: 0x854A39C Offset: 0x854639C VA: 0x854A39C
	internal IPurchaseService CreatePurchaseService() { }
}

// Namespace: UnityEngine.Purchasing
internal class PurchaseServiceFactoryManager : IPurchaseServiceFactoryManager, IPurchaseServiceFactoryManagerInjectionPoint // TypeDefIndex: 25514
{
	// Fields
	private static PurchaseServiceFactoryManager s_Instance; // 0x0
	private IPurchaseServiceFactory m_Factory; // 0x10

	// Methods

	// RVA: 0x854A314 Offset: 0x8546314 VA: 0x854A314
	internal static PurchaseServiceFactoryManager Instance() { }

	// RVA: 0x854A4C0 Offset: 0x85464C0 VA: 0x854A4C0 Slot: 5
	public void SetServiceFactory(IPurchaseServiceFactory serviceFactory) { }

	// RVA: 0x854A4C8 Offset: 0x85464C8 VA: 0x854A4C8 Slot: 4
	public IPurchaseServiceFactory GetServiceFactory() { }

	// RVA: 0x854A4B8 Offset: 0x85464B8 VA: 0x854A4B8
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
internal static class PurchaseServiceProvider // TypeDefIndex: 25515
{
	// Methods

	// RVA: 0x854A4D0 Offset: 0x85464D0 VA: 0x854A4D0
	public static IPurchaseService GetDefaultPurchaseService() { }

	// RVA: 0x854A4EC Offset: 0x85464EC VA: 0x854A4EC
	private static IPurchaseService GetPurchaseServiceInternal(IStoreWrapper storeWrapper) { }

	// RVA: 0x854A510 Offset: 0x8546510 VA: 0x854A510
	private static IPurchaseService LocateExistingService(IStoreWrapper wrapper) { }

	// RVA: 0x854A5C8 Offset: 0x85465C8 VA: 0x854A5C8
	private static IPurchaseService CreateNewService(IStoreWrapper wrapper) { }
}

// Namespace: UnityEngine.Purchasing
internal static class PurchaseUseCaseFactory // TypeDefIndex: 25516
{
	// Methods

	// RVA: 0x854A7B8 Offset: 0x85467B8 VA: 0x854A7B8
	internal static IPurchaseUseCase Create(IStore store, IProductCache productCache) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CheckEntitlementUseCase.<>c__DisplayClass7_0 // TypeDefIndex: 25517
{
	// Fields
	public ProductDefinition productDefinition; // 0x10

	// Methods

	// RVA: 0x854AC90 Offset: 0x8546C90 VA: 0x854AC90
	public void .ctor() { }

	// RVA: 0x854AC98 Offset: 0x8546C98 VA: 0x854AC98
	internal bool <GetMatchingRequest>b__0(CheckEntitlementRequest request) { }
}

// Namespace: UnityEngine.Purchasing
internal class CheckEntitlementUseCase : ICheckEntitlementUseCase, IStoreCheckEntitlementCallback // TypeDefIndex: 25518
{
	// Fields
	private readonly IStore m_Store; // 0x10
	private readonly List<CheckEntitlementRequest> m_OngoingRequests; // 0x18

	// Methods

	[Preserve]
	// RVA: 0x854A874 Offset: 0x8546874 VA: 0x854A874
	internal void .ctor(IStore storeResponsible) { }

	// RVA: 0x854A994 Offset: 0x8546994 VA: 0x854A994 Slot: 4
	public void OnCheckEntitlement(ProductDefinition productDefinition, EntitlementStatus status, string message) { }

	// RVA: 0x854ABA8 Offset: 0x8546BA8 VA: 0x854ABA8
	private CheckEntitlementRequest GetMatchingRequest(ProductDefinition productDefinition) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ConfirmOrderUseCase.<>c__DisplayClass4_0 // TypeDefIndex: 25519
{
	// Fields
	[Nullable(0)]
	public PendingOrder orderToCheckFor; // 0x10

	// Methods

	// RVA: 0x854B0FC Offset: 0x85470FC VA: 0x854B0FC
	public void .ctor() { }

	// RVA: 0x854B680 Offset: 0x8547680 VA: 0x854B680
	internal bool <FindExistingConfirmationRequest>b__0(ConfirmOrderRequest request) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ConfirmOrderUseCase.<>c__DisplayClass8_0 // TypeDefIndex: 25520
{
	// Fields
	[Nullable(0)]
	public string transactionIdentifier; // 0x10

	// Methods

	// RVA: 0x854B678 Offset: 0x8547678 VA: 0x854B678
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x854B7BC Offset: 0x85477BC VA: 0x854B7BC
	internal bool <GetMatchingRequest>b__0(ConfirmOrderRequest request) { }
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
internal class ConfirmOrderUseCase : IConfirmOrderUseCase, IStorePurchaseConfirmCallback // TypeDefIndex: 25521
{
	// Fields
	private readonly IStore m_Store; // 0x10
	private readonly List<ConfirmOrderRequest> m_ConfirmationRequests; // 0x18

	// Methods

	[Preserve]
	// RVA: 0x854ACD4 Offset: 0x8546CD4 VA: 0x854ACD4
	internal void .ctor(IStore storeResponsible) { }

	// RVA: 0x854ADF4 Offset: 0x8546DF4 VA: 0x854ADF4 Slot: 4
	public void ConfirmOrder(PendingOrder order, Action<PendingOrder, Order> confirmationAction) { }

	// RVA: 0x854AEBC Offset: 0x8546EBC VA: 0x854AEBC
	private bool FindExistingConfirmationRequest(PendingOrder orderToCheckFor) { }

	// RVA: 0x854AFA0 Offset: 0x8546FA0 VA: 0x854AFA0
	private void AddAndSendFinishTransactionRequest(PendingOrder order, Action<PendingOrder, Order> confirmationAction) { }

	// RVA: 0x854B104 Offset: 0x8547104 VA: 0x854B104 Slot: 5
	public void OnConfirmOrderSucceeded(string transactionId) { }

	// RVA: 0x854B370 Offset: 0x8547370 VA: 0x854B370 Slot: 6
	public void OnConfirmOrderFailed(FailedOrder failedOrder) { }

	// RVA: 0x854B288 Offset: 0x8547288 VA: 0x854B288
	private ConfirmOrderRequest GetMatchingRequest(string transactionIdentifier) { }
}

// Namespace: UnityEngine.Purchasing
internal class FetchPurchasesUseCase : IFetchPurchasesUseCase, IStorePurchaseFetchCallback // TypeDefIndex: 25522
{
	// Fields
	private readonly IStore m_Store; // 0x10
	[CompilerGenerated]
	private Action<Orders> FetchSuccessAction; // 0x18
	[CompilerGenerated]
	private Action<PurchasesFetchFailureDescription> FetchFailureAction; // 0x20

	// Methods

	[Preserve]
	// RVA: 0x854B87C Offset: 0x854787C VA: 0x854B87C
	internal void .ctor(IStore storeResponsible) { }

	// RVA: 0x854B948 Offset: 0x8547948 VA: 0x854B948 Slot: 4
	public void FetchPurchases(Action<Orders> fetchSuccessAction, Action<PurchasesFetchFailureDescription> fetchFailureAction) { }

	// RVA: 0x854BA1C Offset: 0x8547A1C VA: 0x854BA1C Slot: 5
	public void OnAllPurchasesRetrieved(IReadOnlyList<Order> orders) { }

	// RVA: 0x854BBD4 Offset: 0x8547BD4 VA: 0x854BBD4 Slot: 6
	public void OnPurchasesRetrievalFailed(PurchasesFetchFailureDescription failureReason) { }
}

// Namespace: UnityEngine.Purchasing
internal class OnEntitlementRevokedUseCase : IOnEntitlementRevokedUseCase, IOnEntitlementRevokedCallback // TypeDefIndex: 25523
{
	// Fields
	[CompilerGenerated]
	private Action<string> OnEntitlementRevoked; // 0x10

	// Methods

	[CompilerGenerated]
	// RVA: 0x854BBF0 Offset: 0x8547BF0 VA: 0x854BBF0 Slot: 4
	public void add_OnEntitlementRevoked(Action<string> value) { }

	[CompilerGenerated]
	// RVA: 0x854BCA0 Offset: 0x8547CA0 VA: 0x854BCA0 Slot: 5
	public void remove_OnEntitlementRevoked(Action<string> value) { }

	[Preserve]
	// RVA: 0x854BD50 Offset: 0x8547D50 VA: 0x854BD50
	internal void .ctor(IStore storeResponsible) { }

	// RVA: 0x854BE04 Offset: 0x8547E04 VA: 0x854BE04 Slot: 6
	public void onEntitlementRevoked(string productId) { }
}

// Namespace: UnityEngine.Purchasing
internal class PurchaseUseCase : IPurchaseUseCase, IStorePurchaseCallback // TypeDefIndex: 25524
{
	// Fields
	[CompilerGenerated]
	private readonly IStore <m_Store>k__BackingField; // 0x10
	[CompilerGenerated]
	private Action<PendingOrder> OnPurchaseSuccess; // 0x18
	[CompilerGenerated]
	private Action<FailedOrder> OnPurchaseFail; // 0x20
	[CompilerGenerated]
	private Action<DeferredOrder> OnPurchaseDefer; // 0x28

	// Properties
	protected IStore m_Store { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x854BE20 Offset: 0x8547E20 VA: 0x854BE20
	protected IStore get_m_Store() { }

	// RVA: 0x8541918 Offset: 0x853D918 VA: 0x8541918
	internal void .ctor(IStore storeResponsible) { }

	// RVA: 0x854BE28 Offset: 0x8547E28 VA: 0x854BE28 Slot: 4
	public void Purchase(ICart cart) { }

	[CompilerGenerated]
	// RVA: 0x854BED4 Offset: 0x8547ED4 VA: 0x854BED4 Slot: 5
	public void add_OnPurchaseSuccess(Action<PendingOrder> value) { }

	[CompilerGenerated]
	// RVA: 0x854BF84 Offset: 0x8547F84 VA: 0x854BF84 Slot: 6
	public void remove_OnPurchaseSuccess(Action<PendingOrder> value) { }

	[CompilerGenerated]
	// RVA: 0x85419E4 Offset: 0x853D9E4 VA: 0x85419E4 Slot: 7
	public void add_OnPurchaseFail(Action<FailedOrder> value) { }

	[CompilerGenerated]
	// RVA: 0x854C034 Offset: 0x8548034 VA: 0x854C034 Slot: 8
	public void remove_OnPurchaseFail(Action<FailedOrder> value) { }

	[CompilerGenerated]
	// RVA: 0x854C0E4 Offset: 0x85480E4 VA: 0x854C0E4 Slot: 9
	public void add_OnPurchaseDefer(Action<DeferredOrder> value) { }

	[CompilerGenerated]
	// RVA: 0x854C194 Offset: 0x8548194 VA: 0x854C194 Slot: 10
	public void remove_OnPurchaseDefer(Action<DeferredOrder> value) { }

	// RVA: 0x854C244 Offset: 0x8548244 VA: 0x854C244 Slot: 11
	public void OnPurchaseSucceeded(PendingOrder order) { }

	// RVA: 0x85421A8 Offset: 0x853E1A8 VA: 0x85421A8 Slot: 12
	public void OnPurchaseFailed(FailedOrder failedOrder) { }

	// RVA: 0x854C260 Offset: 0x8548260 VA: 0x854C260 Slot: 13
	public void OnPurchaseDeferred(DeferredOrder deferredOrder) { }
}

// Namespace: UnityEngine.Purchasing
internal class AsyncDelayer : IAsyncDelayer // TypeDefIndex: 25525
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x854C27C Offset: 0x854827C VA: 0x854C27C Slot: 4
	public Task Delay(int delayMilliseconds) { }

	// RVA: 0x854C2D4 Offset: 0x85482D4 VA: 0x854C2D4
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
internal interface IAsyncDelayer // TypeDefIndex: 25526
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Task Delay(int delayMilliseconds);
}

// Namespace: UnityEngine.Purchasing
internal interface IRetryableRequestFailureDescription // TypeDefIndex: 25527
{
	// Properties
	public abstract bool IsRetryable { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsRetryable();
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
public interface IRetryPolicy // TypeDefIndex: 25528
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Task<bool> ShouldRetry(IRetryPolicyInformation info);
}

// Namespace: UnityEngine.Purchasing
public interface IRetryPolicyInformation // TypeDefIndex: 25529
{
	// Properties
	public abstract int NumberOfAttempts { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_NumberOfAttempts();
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
internal interface IRetryRequest // TypeDefIndex: 25530
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Task<bool> Invoke();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Task<bool> Retry(IRetryableRequestFailureDescription requestFailureDescription);
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
internal interface IRetryService // TypeDefIndex: 25531
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IRetryRequest CreateRequest(Action request, IRetryPolicy retryPolicy);
}

// Namespace: 
[CompilerGenerated]
private struct ExponentialBackOffRetryPolicy.<ShouldRetry>d__9 : IAsyncStateMachine // TypeDefIndex: 25532
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	[Nullable(0)]
	public ExponentialBackOffRetryPolicy <>4__this; // 0x20
	[Nullable(0)]
	public IRetryPolicyInformation info; // 0x28
	private TaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x854C5D4 Offset: 0x85485D4 VA: 0x854C5D4 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x854C924 Offset: 0x8548924 VA: 0x854C924 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
public class ExponentialBackOffRetryPolicy : IRetryPolicy // TypeDefIndex: 25533
{
	// Fields
	private readonly int m_BaseRetryDelay; // 0x10
	private readonly int m_MaxRetryDelay; // 0x14
	private readonly float m_ExponentialFactor; // 0x18
	private readonly int m_MaxNumberOfRetriesBeforeCeiling; // 0x1C
	private readonly IAsyncDelayer m_Delayer; // 0x20

	// Methods

	// RVA: 0x853F424 Offset: 0x853B424 VA: 0x853F424
	public void .ctor(int baseRetryDelay = 1000, int maxRetryDelay = 30000, float exponentialFactor = 2) { }

	// RVA: 0x854C2DC Offset: 0x85482DC VA: 0x854C2DC
	private static void ValidateArguments(int baseRetryDelay, int maxRetryDelay, float exponentialFactor) { }

	// RVA: 0x854C388 Offset: 0x8548388 VA: 0x854C388
	private int CalculateMaxNumberOfRetriesBeforeCeiling(int baseRetryDelay, int maxRetryDelay, float exponentialFactor) { }

	[AsyncStateMachine(typeof(ExponentialBackOffRetryPolicy.<ShouldRetry>d__9))]
	// RVA: 0x854C420 Offset: 0x8548420 VA: 0x854C420 Slot: 5
	public virtual Task<bool> ShouldRetry(IRetryPolicyInformation info) { }

	// RVA: 0x854C54C Offset: 0x854854C VA: 0x854C54C
	private int AdjustDelay(int numberOfRetries) { }

	// RVA: 0x854C5AC Offset: 0x85485AC VA: 0x854C5AC
	private bool HasHitMaxRetryDelay(int numberOfRetries) { }
}

// Namespace: UnityEngine.Purchasing
public class MaximumNumberOfAttemptsRetryPolicy : IRetryPolicy // TypeDefIndex: 25534
{
	// Fields
	private readonly int m_MaximumNumberOfAttempts; // 0x10

	// Methods

	// RVA: 0x854C9A0 Offset: 0x85489A0 VA: 0x854C9A0
	public void .ctor(int maximumNumberOfAttempts) { }

	[NullableContext(1)]
	// RVA: 0x854C9C8 Offset: 0x85489C8 VA: 0x854C9C8 Slot: 5
	public virtual Task<bool> ShouldRetry(IRetryPolicyInformation info) { }
}

// Namespace: UnityEngine.Purchasing
public class NoRetriesPolicy : IRetryPolicy // TypeDefIndex: 25535
{
	// Methods

	// RVA: 0x854CAC4 Offset: 0x8548AC4 VA: 0x854CAC4 Slot: 5
	public virtual Task<bool> ShouldRetry(IRetryPolicyInformation info) { }

	// RVA: 0x854CB2C Offset: 0x8548B2C VA: 0x854CB2C
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
public struct RetryPolicyInformation : IRetryPolicyInformation // TypeDefIndex: 25536
{
	// Fields
	[CompilerGenerated]
	private readonly int <NumberOfAttempts>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly float <TimeSinceFirstAttempt>k__BackingField; // 0x4

	// Properties
	public int NumberOfAttempts { get; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x854CB34 Offset: 0x8548B34 VA: 0x854CB34 Slot: 4
	public int get_NumberOfAttempts() { }

	// RVA: 0x854CB3C Offset: 0x8548B3C VA: 0x854CB3C
	internal void .ctor(int numberOfAttempts, float timeSinceFirstAttempt) { }
}

// Namespace: 
private struct RetryRequest.<>c__DisplayClass7_0.<<RunTaskOnMainThread>g__RunRequestAndSetResult|0>d : IAsyncStateMachine // TypeDefIndex: 25537
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public RetryRequest.<>c__DisplayClass7_0 <>4__this; // 0x28
	[Nullable(0)]
	private TaskAwaiter<bool> <>u__1; // 0x30

	// Methods

	// RVA: 0x854D20C Offset: 0x854920C VA: 0x854D20C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x854D42C Offset: 0x854942C VA: 0x854D42C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RetryRequest.<>c__DisplayClass7_0 // TypeDefIndex: 25538
{
	// Fields
	[Nullable(new[] { 0, 1 })]
	public Func<Task<bool>> function; // 0x10
	[Nullable(0)]
	public TaskCompletionSource<bool> completionSource; // 0x18

	// Methods

	// RVA: 0x854CDCC Offset: 0x8548DCC VA: 0x854CDCC
	public void .ctor() { }

	[AsyncStateMachine(typeof(RetryRequest.<>c__DisplayClass7_0.<<RunTaskOnMainThread>g__RunRequestAndSetResult|0>d))]
	// RVA: 0x854D158 Offset: 0x8549158 VA: 0x854D158
	internal void <RunTaskOnMainThread>g__RunRequestAndSetResult|0() { }
}

// Namespace: 
[CompilerGenerated]
private struct RetryRequest.<InvokeFromMainThread>d__8 : IAsyncStateMachine // TypeDefIndex: 25539
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	[Nullable(0)]
	public RetryRequest <>4__this; // 0x20
	[Nullable(0)]
	private TaskAwaiter<bool> <>u__1; // 0x28

	// Methods

	// RVA: 0x854D438 Offset: 0x8549438 VA: 0x854D438 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x854D698 Offset: 0x8549698 VA: 0x854D698 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct RetryRequest.<Retry>d__10 : IAsyncStateMachine // TypeDefIndex: 25540
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	[Nullable(0)]
	public IRetryableRequestFailureDescription requestFailureDescription; // 0x20
	[Nullable(0)]
	public RetryRequest <>4__this; // 0x28
	[Nullable(0)]
	private TaskAwaiter<bool> <>u__1; // 0x30

	// Methods

	// RVA: 0x854D714 Offset: 0x8549714 VA: 0x854D714 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x854DA30 Offset: 0x8549A30 VA: 0x854DA30 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct RetryRequest.<RetryFromMainThread>d__11 : IAsyncStateMachine // TypeDefIndex: 25541
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	[Nullable(0)]
	public RetryRequest <>4__this; // 0x20
	[Nullable(0)]
	private TaskAwaiter<bool> <>u__1; // 0x28

	// Methods

	// RVA: 0x854DAAC Offset: 0x8549AAC VA: 0x854DAAC Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x854DDF4 Offset: 0x8549DF4 VA: 0x854DDF4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
internal class RetryRequest : IRetryRequest // TypeDefIndex: 25542
{
	// Fields
	private float m_StartTime; // 0x10
	private int m_NumberOfAttempts; // 0x14
	private readonly Action m_Request; // 0x18
	private readonly IRetryPolicy m_RetryPolicy; // 0x20
	private readonly IUtil m_Util; // 0x28

	// Methods

	// RVA: 0x854CB48 Offset: 0x8548B48 VA: 0x854CB48
	public void .ctor(Action request, IRetryPolicy retryPolicy, IUtil util) { }

	// RVA: 0x854CBA8 Offset: 0x8548BA8 VA: 0x854CBA8 Slot: 4
	public Task<bool> Invoke() { }

	// RVA: 0x854CC28 Offset: 0x8548C28 VA: 0x854CC28
	public Task<bool> RunTaskOnMainThread(Func<Task<bool>> function) { }

	[AsyncStateMachine(typeof(RetryRequest.<InvokeFromMainThread>d__8))]
	// RVA: 0x854CDD4 Offset: 0x8548DD4 VA: 0x854CDD4
	private Task<bool> InvokeFromMainThread() { }

	// RVA: 0x854CEE0 Offset: 0x8548EE0 VA: 0x854CEE0
	private void FirstTry() { }

	[AsyncStateMachine(typeof(RetryRequest.<Retry>d__10))]
	// RVA: 0x854CF20 Offset: 0x8548F20 VA: 0x854CF20 Slot: 5
	public Task<bool> Retry(IRetryableRequestFailureDescription requestFailureDescription) { }

	[AsyncStateMachine(typeof(RetryRequest.<RetryFromMainThread>d__11))]
	// RVA: 0x854D04C Offset: 0x854904C VA: 0x854D04C
	private Task<bool> RetryFromMainThread() { }
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
internal class RetryService : IRetryService // TypeDefIndex: 25543
{
	// Fields
	private readonly IUtil m_Util; // 0x10

	// Methods

	// RVA: 0x854DE70 Offset: 0x8549E70 VA: 0x854DE70
	internal void .ctor(IUtil util) { }

	// RVA: 0x854DEA0 Offset: 0x8549EA0 VA: 0x854DEA0 Slot: 4
	public IRetryRequest CreateRequest(Action request, IRetryPolicy retryPolicy) { }
}

// Namespace: UnityEngine.Purchasing
public interface IGooglePlayStoreExtendedService // TypeDefIndex: 25544
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetObfuscatedAccountId(string accountId);
}

// Namespace: UnityEngine.Purchasing
internal class GooglePlayStoreConnectionUseCase : IGooglePlayStoreConnectionUseCase // TypeDefIndex: 25545
{
	// Fields
	private readonly IGoogleBillingClient m_BillingClient; // 0x10

	// Methods

	[Preserve]
	// RVA: 0x854DF14 Offset: 0x8549F14 VA: 0x854DF14
	public void .ctor(IGoogleBillingClient billingClient) { }
}

// Namespace: UnityEngine.Purchasing
internal class GooglePlayStoreSetObfuscatedIdUseCase : IGooglePlayStoreSetObfuscatedIdUseCase // TypeDefIndex: 25546
{
	// Fields
	private readonly IGoogleBillingClient m_BillingClient; // 0x10

	// Methods

	[Preserve]
	// RVA: 0x854DF44 Offset: 0x8549F44 VA: 0x854DF44
	internal void .ctor(IGoogleBillingClient billingClient) { }

	// RVA: 0x854DF74 Offset: 0x8549F74 VA: 0x854DF74 Slot: 4
	public void SetObfuscatedAccountId(string accountId) { }
}

// Namespace: UnityEngine.Purchasing
public interface IGooglePlayStoreConnectionUseCase // TypeDefIndex: 25547
{}

// Namespace: UnityEngine.Purchasing
internal interface IGooglePlayStoreSetObfuscatedIdUseCase // TypeDefIndex: 25548
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetObfuscatedAccountId(string accountId);
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
internal class GooglePlayStoreExtendedService : StoreService, IGooglePlayStoreExtendedService // TypeDefIndex: 25549
{
	// Fields
	private readonly IGooglePlayStoreSetObfuscatedIdUseCase m_GooglePlayStoreSetObfuscatedIdUseCase; // 0x18
	private readonly IGooglePlayStoreConnectionUseCase m_GooglePlayStoreConnectionUseCase; // 0x20

	// Methods

	[Preserve]
	// RVA: 0x854E020 Offset: 0x854A020 VA: 0x854E020
	internal void .ctor(IGooglePlayStoreSetObfuscatedIdUseCase googlePlayStoreSetObfuscatedIdUseCase, IGooglePlayStoreConnectionUseCase googlePlayStoreConnectionUseCase, IStoreConnectUseCase connectUseCase) { }

	// RVA: 0x854E0B0 Offset: 0x854A0B0 VA: 0x854E0B0 Slot: 9
	public void SetObfuscatedAccountId(string accountId) { }
}

// Namespace: UnityEngine.Purchasing
public interface IAppleStoreExtendedService // TypeDefIndex: 25550
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetAppAccountToken(Guid appAccountToken);
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
public class StoreException : Exception // TypeDefIndex: 25551
{
	// Methods

	// RVA: 0x854E158 Offset: 0x854A158 VA: 0x854E158
	public void .ctor(string message) { }

	// RVA: 0x854E1C0 Offset: 0x854A1C0 VA: 0x854E1C0
	public void .ctor(string message, Exception innerException) { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
public interface IStoreConnectCallback // TypeDefIndex: 25552
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnStoreConnectionSucceeded();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnStoreConnectionFailed(StoreConnectionFailureDescription failureDescription);
}

// Namespace: UnityEngine.Purchasing
internal interface IStoreConnectionStateService // TypeDefIndex: 25553
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ConnectionState GetConnectionState();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetConnectionState(ConnectionState connectionState);
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
internal interface IStoreFactory // TypeDefIndex: 25554
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IStoreWrapper CreateStore(string storeName);
}

// Namespace: UnityEngine.Purchasing
internal interface IStoreManagerFactoryInjectionPoint // TypeDefIndex: 25555
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetStoreFactory(IStoreFactory storeFactory);
}

// Namespace: UnityEngine.Purchasing
[NullableContext(2)]
public interface IStoreService // TypeDefIndex: 25556
{
	// Properties
	public abstract IAppleStoreExtendedService Apple { get; }
	public abstract IGooglePlayStoreExtendedService Google { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IAppleStoreExtendedService get_Apple();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IGooglePlayStoreExtendedService get_Google();

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract Task Connect();

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void add_OnStoreDisconnected(Action<StoreConnectionFailureDescription> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void remove_OnStoreDisconnected(Action<StoreConnectionFailureDescription> value);
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
internal interface IStoreServiceFactory // TypeDefIndex: 25557
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IStoreService Create(IStoreWrapper store, IRetryPolicy retryPolicy);
}

// Namespace: UnityEngine.Purchasing
internal interface IStoreServiceFactoryManager // TypeDefIndex: 25558
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IStoreServiceFactory GetServiceFactory();
}

// Namespace: UnityEngine.Purchasing
internal interface IStoreServiceFactoryManagerInjectionPoint // TypeDefIndex: 25559
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetServiceFactory(IStoreServiceFactory serviceFactory);
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
public interface IStoreWrapper // TypeDefIndex: 25560
{
	// Properties
	public abstract Store instance { get; }
	public abstract string name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Store get_instance();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_name();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ConnectionState GetStoreConnectionState();
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
internal interface IStoreConnectUseCase // TypeDefIndex: 25561
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Task Connect();

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void add_OnStoreDisconnection(Action<StoreConnectionFailureDescription> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void remove_OnStoreDisconnection(Action<StoreConnectionFailureDescription> value);
}

// Namespace: UnityEngine.Purchasing
public enum ConnectionState // TypeDefIndex: 25562
{
	// Fields
	public int value__; // 0x0
	public const ConnectionState Disconnected = 0;
	public const ConnectionState Connecting = 1;
	public const ConnectionState Connected = 2;
	public const ConnectionState Disconnecting = 3;
	public const ConnectionState Unavailable = 4;
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
[Serializable]
public class StoreConnectionFailureDescription : IRetryableRequestFailureDescription // TypeDefIndex: 25563
{
	// Fields
	public string message; // 0x10
	public bool isRetryable; // 0x18

	// Properties
	public string Message { get; }
	public bool IsRetryable { get; }

	// Methods

	// RVA: 0x854E230 Offset: 0x854A230 VA: 0x854E230
	public string get_Message() { }

	// RVA: 0x854E238 Offset: 0x854A238 VA: 0x854E238 Slot: 4
	public bool get_IsRetryable() { }

	// RVA: 0x854E240 Offset: 0x854A240 VA: 0x854E240
	public void .ctor(string message, bool isRetryable = False) { }
}

// Namespace: UnityEngine.Purchasing
internal class StoreConnectionStateService : IStoreConnectionStateService // TypeDefIndex: 25564
{
	// Fields
	private Nullable<ConnectionState> m_StoreConnectionState; // 0x10

	// Methods

	// RVA: 0x853E598 Offset: 0x853A598 VA: 0x853E598
	public void .ctor() { }

	// RVA: 0x854E27C Offset: 0x854A27C VA: 0x854E27C Slot: 4
	public ConnectionState GetConnectionState() { }

	// RVA: 0x854E2D0 Offset: 0x854A2D0 VA: 0x854E2D0 Slot: 5
	public void SetConnectionState(ConnectionState connectionState) { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
internal class StoreManager : IStoreManagerFactoryInjectionPoint // TypeDefIndex: 25565
{
	// Fields
	[Nullable(2)]
	private static StoreManager s_Instance; // 0x0
	[Nullable(2)]
	private IStoreFactory m_StoreFactory; // 0x10
	[Nullable(new[] { 1, 2, 1 })]
	private readonly Dictionary<string, IStoreWrapper> m_InstantiatedStores; // 0x18

	// Methods

	[NullableContext(2)]
	// RVA: 0x854E338 Offset: 0x854A338 VA: 0x854E338 Slot: 4
	public void SetStoreFactory(IStoreFactory storeFactory) { }

	// RVA: 0x853F984 Offset: 0x853B984 VA: 0x853F984
	public static StoreManager Instance() { }

	// RVA: 0x854E3C8 Offset: 0x854A3C8 VA: 0x854E3C8 Slot: 5
	public IStoreWrapper GetStore(string name) { }

	// RVA: 0x853F9FC Offset: 0x853B9FC VA: 0x853F9FC
	public IStoreWrapper GetDefaultStore() { }

	// RVA: 0x854E340 Offset: 0x854A340 VA: 0x854E340
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(2)]
internal class StoreService : IStoreService // TypeDefIndex: 25566
{
	// Fields
	[Nullable(1)]
	private readonly IStoreConnectUseCase m_StoreConnectUseCase; // 0x10

	// Properties
	public IAppleStoreExtendedService Apple { get; }
	public IGooglePlayStoreExtendedService Google { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x854E080 Offset: 0x854A080 VA: 0x854E080
	internal void .ctor(IStoreConnectUseCase connectUseCase) { }

	// RVA: 0x854E5D0 Offset: 0x854A5D0 VA: 0x854E5D0 Slot: 4
	public IAppleStoreExtendedService get_Apple() { }

	// RVA: 0x854E618 Offset: 0x854A618 VA: 0x854E618 Slot: 5
	public IGooglePlayStoreExtendedService get_Google() { }

	[NullableContext(1)]
	// RVA: 0x854E660 Offset: 0x854A660 VA: 0x854E660 Slot: 6
	public Task Connect() { }

	// RVA: 0x854E700 Offset: 0x854A700 VA: 0x854E700 Slot: 7
	public void add_OnStoreDisconnected(Action<StoreConnectionFailureDescription> value) { }

	// RVA: 0x854E7AC Offset: 0x854A7AC VA: 0x854E7AC Slot: 8
	public void remove_OnStoreDisconnected(Action<StoreConnectionFailureDescription> value) { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
internal class StoreServiceContainer // TypeDefIndex: 25567
{
	// Fields
	[Nullable(2)]
	private static StoreServiceContainer s_Instance; // 0x0
	[Nullable(new[] { 1, 2, 1 })]
	private readonly Dictionary<string, IStoreService> m_InstantiatedServices; // 0x10

	// Methods

	// RVA: 0x854E858 Offset: 0x854A858 VA: 0x854E858
	internal static StoreServiceContainer Instance() { }

	// RVA: 0x854E958 Offset: 0x854A958 VA: 0x854E958
	internal IStoreService FindService(string storeName) { }

	// RVA: 0x854E9EC Offset: 0x854A9EC VA: 0x854E9EC
	internal void SetService(string storeName, IStoreService service) { }

	// RVA: 0x854E8D0 Offset: 0x854A8D0 VA: 0x854E8D0
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
internal class StoreServiceDependencyInjector // TypeDefIndex: 25568
{
	// Fields
	[Nullable(2)]
	private readonly IRetryPolicy m_RetryPolicy; // 0x10
	private readonly IStoreWrapper m_Store; // 0x18
	private IStoreServiceFactoryManager m_ServiceFactoryManager; // 0x20

	// Methods

	// RVA: 0x854EAE8 Offset: 0x854AAE8 VA: 0x854EAE8
	internal void .ctor(IStoreWrapper storeWrapper, IRetryPolicy retryPolicy) { }

	// RVA: 0x854EBC8 Offset: 0x854ABC8 VA: 0x854EBC8
	internal IStoreService CreateStoreService() { }
}

// Namespace: UnityEngine.Purchasing
internal class StoreServiceFactoryManager : IStoreServiceFactoryManager, IStoreServiceFactoryManagerInjectionPoint // TypeDefIndex: 25569
{
	// Fields
	private static StoreServiceFactoryManager s_Instance; // 0x0
	private IStoreServiceFactory m_Factory; // 0x10

	// Methods

	// RVA: 0x854EB40 Offset: 0x854AB40 VA: 0x854EB40
	internal static StoreServiceFactoryManager Instance() { }

	// RVA: 0x854ECF0 Offset: 0x854ACF0 VA: 0x854ECF0 Slot: 5
	public void SetServiceFactory(IStoreServiceFactory serviceFactory) { }

	// RVA: 0x854ECF8 Offset: 0x854ACF8 VA: 0x854ECF8 Slot: 4
	public IStoreServiceFactory GetServiceFactory() { }

	// RVA: 0x854ECE8 Offset: 0x854ACE8 VA: 0x854ECE8
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
internal static class StoreServiceProvider // TypeDefIndex: 25570
{
	// Methods

	// RVA: 0x854ED00 Offset: 0x854AD00 VA: 0x854ED00
	public static IStoreService GetDefaultStoreService() { }

	// RVA: 0x854ED1C Offset: 0x854AD1C VA: 0x854ED1C
	private static IStoreService GetStoreServiceInternal(IStoreWrapper storeWrapper) { }

	// RVA: 0x854ED40 Offset: 0x854AD40 VA: 0x854ED40
	private static IStoreService LocateExistingService(IStoreWrapper wrapper) { }

	// RVA: 0x854EDF8 Offset: 0x854ADF8 VA: 0x854EDF8
	private static IStoreService CreateNewService(IStoreWrapper wrapper) { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
internal class StoreWrapper : IStoreWrapper // TypeDefIndex: 25571
{
	// Fields
	private InternalStore m_InternalStore; // 0x10
	[CompilerGenerated]
	private readonly string <name>k__BackingField; // 0x18

	// Properties
	public string name { get; }
	public Store instance { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x854F01C Offset: 0x854B01C VA: 0x854F01C Slot: 5
	public string get_name() { }

	// RVA: 0x854F024 Offset: 0x854B024 VA: 0x854F024 Slot: 4
	public Store get_instance() { }

	// RVA: 0x854F02C Offset: 0x854B02C VA: 0x854F02C Slot: 6
	public ConnectionState GetStoreConnectionState() { }

	// RVA: 0x854F044 Offset: 0x854B044 VA: 0x854F044
	public void .ctor(string name, InternalStore instance) { }
}

// Namespace: 
[CompilerGenerated]
private struct StoreConnectUseCase.<OnStoreConnectionFailed>d__12 : IAsyncStateMachine // TypeDefIndex: 25572
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public StoreConnectUseCase <>4__this; // 0x28
	[Nullable(0)]
	public StoreConnectionFailureDescription failureDescription; // 0x30
	[Nullable(0)]
	private TaskAwaiter<bool> <>u__1; // 0x38

	// Methods

	// RVA: 0x854FA00 Offset: 0x854BA00 VA: 0x854FA00 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x854FDC0 Offset: 0x854BDC0 VA: 0x854FDC0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
internal class StoreConnectUseCase : IStoreConnectUseCase, IStoreConnectCallback // TypeDefIndex: 25573
{
	// Fields
	private readonly IStore m_Store; // 0x10
	private readonly IRetryService m_RetryService; // 0x18
	private IRetryPolicy m_RetryPolicyOnDisconnect; // 0x20
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private Action<StoreConnectionFailureDescription> OnStoreDisconnection; // 0x28
	[Nullable(2)]
	private TaskCompletionSource<object> m_CurrentConnectionCompletion; // 0x30
	[Nullable(2)]
	private IRetryRequest m_CurrentRequest; // 0x38

	// Methods

	[CompilerGenerated]
	// RVA: 0x854F088 Offset: 0x854B088 VA: 0x854F088 Slot: 5
	public void add_OnStoreDisconnection(Action<StoreConnectionFailureDescription> value) { }

	[CompilerGenerated]
	// RVA: 0x854F138 Offset: 0x854B138 VA: 0x854F138 Slot: 6
	public void remove_OnStoreDisconnection(Action<StoreConnectionFailureDescription> value) { }

	// RVA: 0x854F1E8 Offset: 0x854B1E8 VA: 0x854F1E8
	internal void .ctor(IStore store, IRetryService retryService, IRetryPolicy retryPolicyOnDisconnect) { }

	// RVA: 0x854F2E4 Offset: 0x854B2E4 VA: 0x854F2E4 Slot: 4
	public Task Connect() { }

	// RVA: 0x854F570 Offset: 0x854B570 VA: 0x854F570
	private void InitializeRequest() { }

	// RVA: 0x854F740 Offset: 0x854B740 VA: 0x854F740 Slot: 7
	public void OnStoreConnectionSucceeded() { }

	[AsyncStateMachine(typeof(StoreConnectUseCase.<OnStoreConnectionFailed>d__12))]
	// RVA: 0x854F824 Offset: 0x854B824 VA: 0x854F824 Slot: 8
	public void OnStoreConnectionFailed(StoreConnectionFailureDescription failureDescription) { }

	// RVA: 0x854F8F4 Offset: 0x854B8F4 VA: 0x854F8F4
	private void SendDisconnectionEvent(StoreConnectionFailureDescription connectionFailureDescription) { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
internal class StoreConnectUseCaseFactory // TypeDefIndex: 25574
{
	// Methods

	// RVA: 0x854FDCC Offset: 0x854BDCC VA: 0x854FDCC
	public IStoreConnectUseCase CreateUseCase(IStoreWrapper storeWrapper, IRetryService retryService) { }

	// RVA: 0x854FF18 Offset: 0x854BF18 VA: 0x854FF18
	private static IRetryPolicy CreateRetryPolicy(string storeName) { }

	// RVA: 0x854FFCC Offset: 0x854BFCC VA: 0x854FFCC
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
public static class UnityIAPServices // TypeDefIndex: 25575
{
	// Methods

	// RVA: 0x854FFD4 Offset: 0x854BFD4 VA: 0x854FFD4
	public static IStoreService DefaultStore() { }

	// RVA: 0x854FFD8 Offset: 0x854BFD8 VA: 0x854FFD8
	public static IPurchaseService DefaultPurchase() { }

	// RVA: 0x854FFDC Offset: 0x854BFDC VA: 0x854FFDC
	public static IProductService DefaultProduct() { }
}

// Namespace: UnityEngine.Purchasing
internal class CoreServicesEnvironmentSubject // TypeDefIndex: 25576
{
	// Fields
	private static CoreServicesEnvironmentSubject s_Instance; // 0x0
	private string m_LastKnownEnvironment; // 0x10
	private readonly List<ICoreServicesEnvironmentObserver> m_Observers; // 0x18

	// Methods

	// RVA: 0x854FFE0 Offset: 0x854BFE0 VA: 0x854FFE0
	internal static CoreServicesEnvironmentSubject Instance() { }

	// RVA: 0x85500EC Offset: 0x854C0EC VA: 0x85500EC
	internal void UpdateCurrentEnvironment(string currentEnvironment) { }

	// RVA: 0x8550108 Offset: 0x854C108 VA: 0x8550108
	private void NotifyObservers() { }

	// RVA: 0x8550064 Offset: 0x854C064 VA: 0x8550064
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
internal interface ICoreServicesEnvironmentObserver // TypeDefIndex: 25577
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnUpdatedCoreServicesEnvironment(string currentEnvironment);
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
[Serializable]
internal class DependencyInjectionException : Exception // TypeDefIndex: 25578
{
	// Methods

	// RVA: 0x85502C0 Offset: 0x854C2C0 VA: 0x85502C0
	internal void .ctor() { }

	// RVA: 0x8550318 Offset: 0x854C318 VA: 0x8550318
	internal void .ctor(string message) { }

	// RVA: 0x8550380 Offset: 0x854C380 VA: 0x8550380
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DependencyInjectionService.<>c // TypeDefIndex: 25579
{
	// Fields
	[Nullable(0)]
	public static readonly DependencyInjectionService.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<CustomAttributeData, bool> <>9__13_1; // 0x8
	[Nullable(0)]
	public static Func<ConstructorInfo, bool> <>9__13_0; // 0x10
	[Nullable(0)]
	public static Func<ParameterInfo, Type> <>9__14_0; // 0x18

	// Methods

	// RVA: 0x8550E5C Offset: 0x854CE5C VA: 0x8550E5C
	private static void .cctor() { }

	// RVA: 0x8550EC4 Offset: 0x854CEC4 VA: 0x8550EC4
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x8550ECC Offset: 0x854CECC VA: 0x8550ECC
	internal bool <FindInjectableConstructors>b__13_0(ConstructorInfo constructor) { }

	[NullableContext(0)]
	// RVA: 0x8550FEC Offset: 0x854CFEC VA: 0x8550FEC
	internal bool <FindInjectableConstructors>b__13_1(CustomAttributeData attribute) { }

	[NullableContext(0)]
	// RVA: 0x8551088 Offset: 0x854D088 VA: 0x8551088
	internal Type <GetParameterInstancesForConstructor>b__14_0(ParameterInfo paramInfo) { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
internal class DependencyInjectionService : IDependencyInjectionService // TypeDefIndex: 25580
{
	// Fields
	private readonly HashSet<object> m_ServiceInstances; // 0x10
	private readonly HashSet<Type> m_ServiceConcreteTypes; // 0x18

	// Methods

	// RVA: 0x8550400 Offset: 0x854C400 VA: 0x8550400 Slot: 4
	public void AddInstance(object instance) { }

	// RVA: -1 Offset: -1 Slot: 5
	public void AddService<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45716CC Offset: 0x456D6CC VA: 0x45716CC
	|-DependencyInjectionService.AddService<object>
	*/

	// RVA: 0x8550458 Offset: 0x854C458 VA: 0x8550458
	private void ValidateTypeIsNotAnInterface(Type type) { }

	// RVA: 0x85504D8 Offset: 0x854C4D8 VA: 0x85504D8
	private void ValidateTypeIsNotADuplicate(Type type) { }

	// RVA: -1 Offset: -1 Slot: 6
	public T GetInstance<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4571784 Offset: 0x456D784 VA: 0x4571784
	|-DependencyInjectionService.GetInstance<object>
	*/

	// RVA: 0x8550588 Offset: 0x854C588 VA: 0x8550588
	private object GetInstance(Type type) { }

	// RVA: 0x85505CC Offset: 0x854C5CC VA: 0x85505CC
	private object FindServiceInstance(Type type) { }

	// RVA: 0x8550708 Offset: 0x854C708 VA: 0x8550708
	private Type FindConcreteServiceType(Type type) { }

	// RVA: 0x855087C Offset: 0x854C87C VA: 0x855087C
	private object CreateServiceInstance(Type concreteType) { }

	// RVA: 0x85508D4 Offset: 0x854C8D4 VA: 0x85508D4
	private ConstructorInfo FindConstructorForType(Type concreteType) { }

	// RVA: 0x8550B88 Offset: 0x854CB88 VA: 0x8550B88
	private ConstructorInfo HandleMultipleConstructors(ConstructorInfo[] constructors, Type concreteType) { }

	// RVA: 0x8550C64 Offset: 0x854CC64 VA: 0x8550C64
	private List<ConstructorInfo> FindInjectableConstructors(ConstructorInfo[] constructors) { }

	// RVA: 0x85509C0 Offset: 0x854C9C0 VA: 0x85509C0
	private object[] GetParameterInstancesForConstructor(ConstructorInfo constructor) { }

	// RVA: 0x8550D80 Offset: 0x854CD80 VA: 0x8550D80
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
internal interface IDependencyInjectionService // TypeDefIndex: 25581
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void AddInstance(object instance);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void AddService<T>();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDependencyInjectionService.AddService<object>
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract T GetInstance<T>();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDependencyInjectionService.GetInstance<object>
	*/
}

// Namespace: UnityEngine.Purchasing
internal class InjectAttribute : Attribute // TypeDefIndex: 25582
{}

// Namespace: UnityEngine.Purchasing
[Preserve]
internal class ErrorMessages // TypeDefIndex: 25583
{
	// Methods

	// RVA: 0x85510B0 Offset: 0x854D0B0 VA: 0x85510B0
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
public class CatalogProvider // TypeDefIndex: 25584
{
	// Fields
	[Nullable(new[] { 1, 2, 1, 1, 1 })]
	private Dictionary<string, Dictionary<string, string>> m_StoreSpecificIds; // 0x10
	private List<ProductDefinition> m_Products; // 0x18

	// Methods

	// RVA: 0x85510B8 Offset: 0x854D0B8 VA: 0x85510B8 Slot: 4
	public List<ProductDefinition> GetProducts(string storeName) { }

	// RVA: 0x85512BC Offset: 0x854D2BC VA: 0x85512BC Slot: 5
	public void AddProduct(string id, ProductType type) { }

	// RVA: 0x85512C8 Offset: 0x854D2C8 VA: 0x85512C8 Slot: 6
	public void AddProduct(string id, ProductType type, StoreSpecificIds storeIDs) { }

	// RVA: 0x85512D0 Offset: 0x854D2D0 VA: 0x85512D0 Slot: 7
	public void AddProduct(string id, ProductType type, StoreSpecificIds storeIDs, IEnumerable<PayoutDefinition> payouts) { }

	// RVA: 0x8551404 Offset: 0x854D404 VA: 0x8551404
	private string AddStoreSpecificIds(string id, StoreSpecificIds storeIDs) { }

	// RVA: 0x85510D8 Offset: 0x854D0D8 VA: 0x85510D8
	private void UpdateStoreSpecificIDs(string storeName) { }

	// RVA: 0x8551910 Offset: 0x854D910 VA: 0x8551910
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
[Serializable]
public class Price : ISerializationCallbackReceiver // TypeDefIndex: 25585
{
	// Fields
	public Decimal value; // 0x10
	[SerializeField]
	private int[] data; // 0x20
	[SerializeField]
	private double num; // 0x28

	// Methods

	// RVA: 0x85519EC Offset: 0x854D9EC VA: 0x85519EC Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x8551A70 Offset: 0x854DA70 VA: 0x8551A70 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x8551ADC Offset: 0x854DADC VA: 0x8551ADC
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
[Serializable]
public class StoreID // TypeDefIndex: 25586
{
	// Fields
	public string store; // 0x10
	public string id; // 0x18
}

// Namespace: UnityEngine.Purchasing
public enum TranslationLocale // TypeDefIndex: 25587
{
	// Fields
	public int value__; // 0x0
	public const TranslationLocale af_ZA = 0;
	public const TranslationLocale sq_SQ = 1;
	public const TranslationLocale am_ET = 2;
	public const TranslationLocale ar_AE = 3;
	public const TranslationLocale hy_AM = 4;
	public const TranslationLocale az_AZ = 5;
	public const TranslationLocale bn_BD = 6;
	public const TranslationLocale eu_ES = 7;
	public const TranslationLocale be_BY = 8;
	public const TranslationLocale bg_BG = 9;
	public const TranslationLocale my_MM = 10;
	public const TranslationLocale ca_CA = 11;
	public const TranslationLocale zh_HK = 12;
	public const TranslationLocale zh_CN = 13;
	public const TranslationLocale zh_TW = 14;
	public const TranslationLocale hr_HR = 15;
	public const TranslationLocale cs_CZ = 16;
	public const TranslationLocale da_DK = 17;
	public const TranslationLocale nl_NL = 18;
	public const TranslationLocale en_AU = 19;
	public const TranslationLocale en_CA = 20;
	public const TranslationLocale en_US = 21;
	public const TranslationLocale en_GB = 22;
	public const TranslationLocale en_IN = 23;
	public const TranslationLocale en_SG = 24;
	public const TranslationLocale en_ZA = 25;
	public const TranslationLocale et_EE = 26;
	public const TranslationLocale fil_FIL = 27;
	public const TranslationLocale fi_FI = 28;
	public const TranslationLocale fr_CA = 29;
	public const TranslationLocale fr_FR = 30;
	public const TranslationLocale gl_ES = 31;
	public const TranslationLocale ka_GE = 32;
	public const TranslationLocale de_DE = 33;
	public const TranslationLocale el_GR = 34;
	public const TranslationLocale gu_IN = 35;
	public const TranslationLocale iw_IL = 36;
	public const TranslationLocale hi_IN = 37;
	public const TranslationLocale hu_HU = 38;
	public const TranslationLocale is_IS = 39;
	public const TranslationLocale id_ID = 40;
	public const TranslationLocale it_IT = 41;
	public const TranslationLocale ja_JP = 42;
	public const TranslationLocale kn_IN = 43;
	public const TranslationLocale kk_KZ = 44;
	public const TranslationLocale km_KH = 45;
	public const TranslationLocale ko_KR = 46;
	public const TranslationLocale ky_KG = 47;
	public const TranslationLocale lo_LA = 48;
	public const TranslationLocale lv_LV = 49;
	public const TranslationLocale lt_LT = 50;
	public const TranslationLocale mk_MK = 51;
	public const TranslationLocale ms_MY = 52;
	public const TranslationLocale ms_MS = 53;
	public const TranslationLocale ml_IN = 54;
	public const TranslationLocale mr_IN = 55;
	public const TranslationLocale mn_MN = 56;
	public const TranslationLocale ne_NP = 57;
	public const TranslationLocale no_NO = 58;
	public const TranslationLocale fa_FA = 59;
	public const TranslationLocale fa_AE = 60;
	public const TranslationLocale fa_AF = 61;
	public const TranslationLocale fa_IR = 62;
	public const TranslationLocale pl_PL = 63;
	public const TranslationLocale pt_BR = 64;
	public const TranslationLocale pt_PT = 65;
	public const TranslationLocale pa_IN = 66;
	public const TranslationLocale ro_RO = 67;
	public const TranslationLocale rm_CH = 68;
	public const TranslationLocale ru_RU = 69;
	public const TranslationLocale sr_RS = 70;
	public const TranslationLocale si_LK = 71;
	public const TranslationLocale sk_SK = 72;
	public const TranslationLocale sl_SI = 73;
	public const TranslationLocale es_419 = 74;
	public const TranslationLocale es_ES = 75;
	public const TranslationLocale es_MX = 76;
	public const TranslationLocale es_US = 77;
	public const TranslationLocale sw_KE = 78;
	public const TranslationLocale sv_SE = 79;
	public const TranslationLocale ta_IN = 80;
	public const TranslationLocale te_IN = 81;
	public const TranslationLocale th_TH = 82;
	public const TranslationLocale tr_TR = 83;
	public const TranslationLocale uk_UA = 84;
	public const TranslationLocale ur_UZ = 85;
	public const TranslationLocale vi_VN = 86;
	public const TranslationLocale zu_ZA = 87;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class LocalizedProductDescription.<>c // TypeDefIndex: 25588
{
	// Fields
	public static readonly LocalizedProductDescription.<>c <>9; // 0x0
	public static MatchEvaluator <>9__11_0; // 0x8

	// Methods

	// RVA: 0x8551C4C Offset: 0x854DC4C VA: 0x8551C4C
	private static void .cctor() { }

	// RVA: 0x8551CB4 Offset: 0x854DCB4 VA: 0x8551CB4
	public void .ctor() { }

	// RVA: 0x8551CBC Offset: 0x854DCBC VA: 0x8551CBC
	internal string <DecodeNonLatinCharacters>b__11_0(Match m) { }
}

// Namespace: UnityEngine.Purchasing
[Serializable]
public class LocalizedProductDescription // TypeDefIndex: 25589
{
	// Fields
	public TranslationLocale googleLocale; // 0x10
	[SerializeField]
	private string title; // 0x18
	[SerializeField]
	private string description; // 0x20

	// Properties
	public string Title { get; }
	public string Description { get; }

	// Methods

	// RVA: 0x8551AE4 Offset: 0x854DAE4 VA: 0x8551AE4
	public string get_Title() { }

	// RVA: 0x8551C34 Offset: 0x854DC34 VA: 0x8551C34
	public string get_Description() { }

	// RVA: 0x8551AEC Offset: 0x854DAEC VA: 0x8551AEC
	private static string DecodeNonLatinCharacters(string s) { }

	// RVA: 0x8551C3C Offset: 0x854DC3C VA: 0x8551C3C
	public void .ctor() { }
}

// Namespace: 
public enum ProductCatalogPayout.ProductCatalogPayoutType // TypeDefIndex: 25590
{
	// Fields
	public int value__; // 0x0
	public const ProductCatalogPayout.ProductCatalogPayoutType Other = 0;
	public const ProductCatalogPayout.ProductCatalogPayoutType Currency = 1;
	public const ProductCatalogPayout.ProductCatalogPayoutType Item = 2;
	public const ProductCatalogPayout.ProductCatalogPayoutType Resource = 3;
}

// Namespace: UnityEngine.Purchasing
[Serializable]
public class ProductCatalogPayout // TypeDefIndex: 25591
{
	// Fields
	[SerializeField]
	private string t; // 0x10
	[SerializeField]
	private string st; // 0x18
	[SerializeField]
	private string d; // 0x20

	// Methods

	// RVA: 0x8551D74 Offset: 0x854DD74 VA: 0x8551D74
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
[Serializable]
public class ProductCatalogItem // TypeDefIndex: 25592
{
	// Fields
	public string id; // 0x10
	public ProductType type; // 0x18
	[SerializeField]
	private List<StoreID> storeIDs; // 0x20
	public LocalizedProductDescription defaultDescription; // 0x28
	public Price googlePrice; // 0x30
	[SerializeField]
	private List<LocalizedProductDescription> descriptions; // 0x38
	[SerializeField]
	private List<ProductCatalogPayout> payouts; // 0x40

	// Properties
	public ICollection<StoreID> allStoreIDs { get; }

	// Methods

	// RVA: 0x8551E40 Offset: 0x854DE40 VA: 0x8551E40
	public ICollection<StoreID> get_allStoreIDs() { }

	// RVA: 0x8551E48 Offset: 0x854DE48 VA: 0x8551E48
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ProductCatalog.<>c // TypeDefIndex: 25593
{
	// Fields
	public static readonly ProductCatalog.<>c <>9; // 0x0
	public static Func<ProductCatalogItem, bool> <>9__9_0; // 0x8

	// Methods

	// RVA: 0x85523E8 Offset: 0x854E3E8 VA: 0x85523E8
	private static void .cctor() { }

	// RVA: 0x8552450 Offset: 0x854E450 VA: 0x8552450
	public void .ctor() { }

	// RVA: 0x8552458 Offset: 0x854E458 VA: 0x8552458
	internal bool <get_allValidProducts>b__9_0(ProductCatalogItem x) { }
}

// Namespace: UnityEngine.Purchasing
[Serializable]
public class ProductCatalog // TypeDefIndex: 25594
{
	// Fields
	private static IProductCatalogImpl instance; // 0x0
	public bool enableCodelessAutoInitialization; // 0x10
	[SerializeField]
	private List<ProductCatalogItem> products; // 0x18

	// Properties
	public ICollection<ProductCatalogItem> allProducts { get; }
	public ICollection<ProductCatalogItem> allValidProducts { get; }

	// Methods

	// RVA: 0x8551FF8 Offset: 0x854DFF8 VA: 0x8551FF8
	public ICollection<ProductCatalogItem> get_allProducts() { }

	// RVA: 0x8552000 Offset: 0x854E000 VA: 0x8552000
	public ICollection<ProductCatalogItem> get_allValidProducts() { }

	// RVA: 0x8552120 Offset: 0x854E120 VA: 0x8552120
	internal static void Initialize() { }

	// RVA: 0x85521E0 Offset: 0x854E1E0 VA: 0x85521E0
	public static void Initialize(IProductCatalogImpl productCatalogImpl) { }

	// RVA: 0x8552238 Offset: 0x854E238 VA: 0x8552238
	public static ProductCatalog Deserialize(string catalogJSON) { }

	// RVA: 0x8552280 Offset: 0x854E280 VA: 0x8552280
	public static ProductCatalog FromTextAsset(TextAsset asset) { }

	// RVA: 0x855229C Offset: 0x854E29C VA: 0x855229C
	public static ProductCatalog LoadDefaultCatalog() { }

	// RVA: 0x8552358 Offset: 0x854E358 VA: 0x8552358
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
public interface IProductCatalogImpl // TypeDefIndex: 25595
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ProductCatalog LoadDefaultCatalog();
}

// Namespace: UnityEngine.Purchasing
internal class ProductCatalogImpl : IProductCatalogImpl // TypeDefIndex: 25596
{
	// Methods

	// RVA: 0x85524A8 Offset: 0x854E4A8 VA: 0x85524A8 Slot: 4
	public ProductCatalog LoadDefaultCatalog() { }

	// RVA: 0x85521D8 Offset: 0x854E1D8 VA: 0x85521D8
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
internal class StoreConfiguration // TypeDefIndex: 25597
{
	// Fields
	[CompilerGenerated]
	private AppStore <androidStore>k__BackingField; // 0x10

	// Properties
	public AppStore androidStore { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x85525AC Offset: 0x854E5AC VA: 0x85525AC
	public AppStore get_androidStore() { }

	[CompilerGenerated]
	// RVA: 0x85525B4 Offset: 0x854E5B4 VA: 0x85525B4
	private void set_androidStore(AppStore value) { }

	// RVA: 0x85525BC Offset: 0x854E5BC VA: 0x85525BC
	public void .ctor(AppStore store) { }

	// RVA: 0x85525E4 Offset: 0x854E5E4 VA: 0x85525E4
	public static StoreConfiguration Deserialize(string json) { }
}

// Namespace: UnityEngine.Purchasing
[Serializable]
public class PayoutDefinition // TypeDefIndex: 25598
{
	// Fields
	[SerializeField]
	private string m_Subtype; // 0x10
	[SerializeField]
	private string m_Data; // 0x18

	// Methods

	// RVA: 0x8552868 Offset: 0x854E868 VA: 0x8552868
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
public class Product // TypeDefIndex: 25599
{
	// Fields
	[CompilerGenerated]
	private ProductDefinition <definition>k__BackingField; // 0x10
	[CompilerGenerated]
	private ProductMetadata <metadata>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <availableToPurchase>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <transactionID>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <appleOriginalTransactionID>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <appleProductIsRestored>k__BackingField; // 0x38
	private string m_Receipt; // 0x40

	// Properties
	public ProductDefinition definition { get; set; }
	public ProductMetadata metadata { get; set; }
	public bool availableToPurchase { get; set; }
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
	public string transactionID { get; set; }
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
	public string appleOriginalTransactionID { get; set; }
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
	public bool appleProductIsRestored { get; set; }
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
	public bool hasReceipt { get; }
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
	public string receipt { get; set; }

	// Methods

	[Obsolete("This constructor is obsolete and should not be used. Use the Product(ProductDefinition, ProductMetadata) constructor and assign the receipt separately if needed.")]
	// RVA: 0x85528E0 Offset: 0x854E8E0 VA: 0x85528E0
	internal void .ctor(ProductDefinition definition, ProductMetadata metadata, string receipt) { }

	// RVA: 0x8540A10 Offset: 0x853CA10 VA: 0x8540A10
	internal void .ctor(ProductDefinition definition, ProductMetadata metadata) { }

	// RVA: 0x8547BAC Offset: 0x8543BAC VA: 0x8547BAC
	internal static Product CreateUnknownProduct(string productId) { }

	[CompilerGenerated]
	// RVA: 0x8552928 Offset: 0x854E928 VA: 0x8552928
	public ProductDefinition get_definition() { }

	[CompilerGenerated]
	// RVA: 0x8552930 Offset: 0x854E930 VA: 0x8552930
	private void set_definition(ProductDefinition value) { }

	[CompilerGenerated]
	// RVA: 0x8552938 Offset: 0x854E938 VA: 0x8552938
	public ProductMetadata get_metadata() { }

	[CompilerGenerated]
	// RVA: 0x8552940 Offset: 0x854E940 VA: 0x8552940
	internal void set_metadata(ProductMetadata value) { }

	[CompilerGenerated]
	// RVA: 0x8552948 Offset: 0x854E948 VA: 0x8552948
	public bool get_availableToPurchase() { }

	[CompilerGenerated]
	// RVA: 0x8552950 Offset: 0x854E950 VA: 0x8552950
	internal void set_availableToPurchase(bool value) { }

	[CompilerGenerated]
	// RVA: 0x855295C Offset: 0x854E95C VA: 0x855295C
	public string get_transactionID() { }

	[CompilerGenerated]
	// RVA: 0x8552964 Offset: 0x854E964 VA: 0x8552964
	internal void set_transactionID(string value) { }

	[CompilerGenerated]
	// RVA: 0x855296C Offset: 0x854E96C VA: 0x855296C
	public string get_appleOriginalTransactionID() { }

	[CompilerGenerated]
	// RVA: 0x8552974 Offset: 0x854E974 VA: 0x8552974
	internal void set_appleOriginalTransactionID(string value) { }

	[CompilerGenerated]
	// RVA: 0x855297C Offset: 0x854E97C VA: 0x855297C
	public bool get_appleProductIsRestored() { }

	[CompilerGenerated]
	// RVA: 0x8552984 Offset: 0x854E984 VA: 0x8552984
	internal void set_appleProductIsRestored(bool value) { }

	// RVA: 0x8552990 Offset: 0x854E990 VA: 0x8552990
	public bool get_hasReceipt() { }

	// RVA: 0x85529D0 Offset: 0x854E9D0 VA: 0x85529D0
	public string get_receipt() { }

	// RVA: 0x8552908 Offset: 0x854E908 VA: 0x8552908
	internal void set_receipt(string value) { }

	// RVA: 0x85529D4 Offset: 0x854E9D4 VA: 0x85529D4
	private string GetReceipt() { }

	// RVA: 0x8552CC8 Offset: 0x854ECC8 VA: 0x8552CC8
	private static string CreateUnifiedReceipt(string rawReceipt, string transactionId, string storeName) { }

	// RVA: 0x8552B80 Offset: 0x854EB80 VA: 0x8552B80
	private void SetReceipt(string curReceipt) { }

	// RVA: 0x8552CCC Offset: 0x854ECCC VA: 0x8552CCC Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x8552D70 Offset: 0x854ED70 VA: 0x8552D70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x8552D90 Offset: 0x854ED90 VA: 0x8552D90 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.Purchasing
public class ProductDefinition // TypeDefIndex: 25600
{
	// Fields
	[CompilerGenerated]
	private string <id>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <storeSpecificId>k__BackingField; // 0x18
	[CompilerGenerated]
	private ProductType <type>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <enabled>k__BackingField; // 0x24
	private readonly List<PayoutDefinition> m_Payouts; // 0x28

	// Properties
	public string id { get; set; }
	public string storeSpecificId { get; set; }
	public ProductType type { get; set; }
	public bool enabled { get; set; }
	public IEnumerable<PayoutDefinition> payouts { get; }
	public PayoutDefinition payout { get; }

	// Methods

	// RVA: 0x8552DFC Offset: 0x854EDFC VA: 0x8552DFC
	private void .ctor() { }

	// RVA: 0x85517D0 Offset: 0x854D7D0 VA: 0x85517D0
	public void .ctor(string id, string storeSpecificId, ProductType type) { }

	// RVA: 0x8552E84 Offset: 0x854EE84 VA: 0x8552E84
	public void .ctor(string id, string storeSpecificId, ProductType type, bool enabled) { }

	// RVA: 0x8552F74 Offset: 0x854EF74 VA: 0x8552F74
	public void .ctor(string id, string storeSpecificId, ProductType type, bool enabled, PayoutDefinition payout) { }

	// RVA: 0x8553098 Offset: 0x854F098 VA: 0x8553098
	public void .ctor(string id, ProductType type, bool enabled, PayoutDefinition payout) { }

	// RVA: 0x8552E90 Offset: 0x854EE90 VA: 0x8552E90
	public void .ctor(string id, string storeSpecificId, ProductType type, bool enabled, IEnumerable<PayoutDefinition> payouts) { }

	// RVA: 0x855290C Offset: 0x854E90C VA: 0x855290C
	public void .ctor(string id, ProductType type) { }

	[CompilerGenerated]
	// RVA: 0x85531B8 Offset: 0x854F1B8 VA: 0x85531B8
	public string get_id() { }

	[CompilerGenerated]
	// RVA: 0x85531C0 Offset: 0x854F1C0 VA: 0x85531C0
	private void set_id(string value) { }

	[CompilerGenerated]
	// RVA: 0x85531C8 Offset: 0x854F1C8 VA: 0x85531C8
	public string get_storeSpecificId() { }

	[CompilerGenerated]
	// RVA: 0x85531D0 Offset: 0x854F1D0 VA: 0x85531D0
	internal void set_storeSpecificId(string value) { }

	[CompilerGenerated]
	// RVA: 0x85531D8 Offset: 0x854F1D8 VA: 0x85531D8
	public ProductType get_type() { }

	[CompilerGenerated]
	// RVA: 0x85531E0 Offset: 0x854F1E0 VA: 0x85531E0
	private void set_type(ProductType value) { }

	[CompilerGenerated]
	// RVA: 0x85531E8 Offset: 0x854F1E8 VA: 0x85531E8
	public bool get_enabled() { }

	[CompilerGenerated]
	// RVA: 0x85531F0 Offset: 0x854F1F0 VA: 0x85531F0
	private void set_enabled(bool value) { }

	// RVA: 0x85531FC Offset: 0x854F1FC VA: 0x85531FC Slot: 3
	public override string ToString() { }

	// RVA: 0x85533BC Offset: 0x854F3BC VA: 0x85533BC Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x8553458 Offset: 0x854F458 VA: 0x8553458 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x8553478 Offset: 0x854F478 VA: 0x8553478
	public IEnumerable<PayoutDefinition> get_payouts() { }

	// RVA: 0x8553480 Offset: 0x854F480 VA: 0x8553480
	public PayoutDefinition get_payout() { }

	// RVA: 0x85517DC Offset: 0x854D7DC VA: 0x85517DC
	internal void SetPayouts(IEnumerable<PayoutDefinition> newPayouts) { }
}

// Namespace: UnityEngine.Purchasing
public class ProductMetadata // TypeDefIndex: 25601
{
	// Fields
	[CompilerGenerated]
	private string <localizedPriceString>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <localizedTitle>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <localizedDescription>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <isoCurrencyCode>k__BackingField; // 0x28
	[CompilerGenerated]
	private Decimal <localizedPrice>k__BackingField; // 0x30

	// Properties
	public string localizedPriceString { get; set; }
	public string localizedTitle { get; set; }
	public string localizedDescription { get; set; }
	public string isoCurrencyCode { get; set; }
	public Decimal localizedPrice { get; set; }

	// Methods

	// RVA: 0x85534FC Offset: 0x854F4FC VA: 0x85534FC
	public void .ctor(string priceString, string title, string description, string currencyCode, Decimal localizedPrice) { }

	// RVA: 0x8553588 Offset: 0x854F588 VA: 0x8553588
	public void .ctor(ProductMetadata productMetadata) { }

	// RVA: 0x8552920 Offset: 0x854E920 VA: 0x8552920
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x85535FC Offset: 0x854F5FC VA: 0x85535FC
	public string get_localizedPriceString() { }

	[CompilerGenerated]
	// RVA: 0x8553604 Offset: 0x854F604 VA: 0x8553604
	internal void set_localizedPriceString(string value) { }

	[CompilerGenerated]
	// RVA: 0x855360C Offset: 0x854F60C VA: 0x855360C
	public string get_localizedTitle() { }

	[CompilerGenerated]
	// RVA: 0x8553614 Offset: 0x854F614 VA: 0x8553614
	internal void set_localizedTitle(string value) { }

	[CompilerGenerated]
	// RVA: 0x855361C Offset: 0x854F61C VA: 0x855361C
	public string get_localizedDescription() { }

	[CompilerGenerated]
	// RVA: 0x8553624 Offset: 0x854F624 VA: 0x8553624
	internal void set_localizedDescription(string value) { }

	[CompilerGenerated]
	// RVA: 0x855362C Offset: 0x854F62C VA: 0x855362C
	public string get_isoCurrencyCode() { }

	[CompilerGenerated]
	// RVA: 0x8553634 Offset: 0x854F634 VA: 0x8553634
	internal void set_isoCurrencyCode(string value) { }

	[CompilerGenerated]
	// RVA: 0x855363C Offset: 0x854F63C VA: 0x855363C
	public Decimal get_localizedPrice() { }

	[CompilerGenerated]
	// RVA: 0x8553648 Offset: 0x854F648 VA: 0x8553648
	internal void set_localizedPrice(Decimal value) { }

	// RVA: 0x8553650 Offset: 0x854F650 VA: 0x8553650 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.Purchasing
public enum ProductType // TypeDefIndex: 25602
{
	// Fields
	public int value__; // 0x0
	public const ProductType Consumable = 0;
	public const ProductType NonConsumable = 1;
	public const ProductType Subscription = 2;
	public const ProductType Unknown = 3;
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
public class PurchaseFailureDescription // TypeDefIndex: 25603
{
	// Fields
	[CompilerGenerated]
	private CartItem <item>k__BackingField; // 0x10
	[CompilerGenerated]
	private PurchaseFailureReason <reason>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <message>k__BackingField; // 0x20

	// Properties
	public CartItem item { get; set; }
	public PurchaseFailureReason reason { get; set; }
	public string message { get; set; }

	// Methods

	// RVA: 0x8553848 Offset: 0x854F848 VA: 0x8553848
	public void .ctor(CartItem item, PurchaseFailureReason reason, string message) { }

	[CompilerGenerated]
	// RVA: 0x855389C Offset: 0x854F89C VA: 0x855389C
	public CartItem get_item() { }

	[CompilerGenerated]
	// RVA: 0x85538A4 Offset: 0x854F8A4 VA: 0x85538A4
	private void set_item(CartItem value) { }

	[CompilerGenerated]
	// RVA: 0x85538AC Offset: 0x854F8AC VA: 0x85538AC
	public PurchaseFailureReason get_reason() { }

	[CompilerGenerated]
	// RVA: 0x85538B4 Offset: 0x854F8B4 VA: 0x85538B4
	private void set_reason(PurchaseFailureReason value) { }

	[CompilerGenerated]
	// RVA: 0x85538BC Offset: 0x854F8BC VA: 0x85538BC
	public string get_message() { }

	[CompilerGenerated]
	// RVA: 0x85538C4 Offset: 0x854F8C4 VA: 0x85538C4
	private void set_message(string value) { }

	// RVA: 0x85538CC Offset: 0x854F8CC VA: 0x85538CC
	internal FailedOrder ConvertToFailedOrder(string transactionId = "") { }
}

// Namespace: UnityEngine.Purchasing
public enum PurchaseFailureReason // TypeDefIndex: 25604
{
	// Fields
	public int value__; // 0x0
	public const PurchaseFailureReason PurchasingUnavailable = 0;
	public const PurchaseFailureReason ExistingPurchasePending = 1;
	public const PurchaseFailureReason ProductUnavailable = 2;
	public const PurchaseFailureReason SignatureInvalid = 3;
	public const PurchaseFailureReason UserCancelled = 4;
	public const PurchaseFailureReason PaymentDeclined = 5;
	public const PurchaseFailureReason DuplicateTransaction = 6;
	public const PurchaseFailureReason ValidationFailure = 7;
	public const PurchaseFailureReason StoreNotConnected = 8;
	public const PurchaseFailureReason PurchaseMissing = 9;
	public const PurchaseFailureReason Unknown = 10;
}

// Namespace: UnityEngine.Purchasing
[Extension]
internal static class ListExtension // TypeDefIndex: 25605
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	internal static AndroidJavaObject ToJava<T>(List<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4668AA0 Offset: 0x4664AA0 VA: 0x4668AA0
	|-ListExtension.ToJava<object>
	|
	|-RVA: 0x4668AD8 Offset: 0x4664AD8 VA: 0x4668AD8
	|-ListExtension.ToJava<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static AndroidJavaObject ToJavaArray<T>(List<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4668B14 Offset: 0x4664B14 VA: 0x4668B14
	|-ListExtension.ToJavaArray<object>
	|
	|-RVA: 0x4668D90 Offset: 0x4664D90 VA: 0x4668D90
	|-ListExtension.ToJavaArray<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: UnityEngine.Purchasing
internal class UnityActivity // TypeDefIndex: 25606
{
	// Fields
	private static AndroidJavaClass s_UnityPlayerClass; // 0x0

	// Methods

	// RVA: 0x85539F8 Offset: 0x854F9F8 VA: 0x85539F8
	private static AndroidJavaClass GetUnityPlayerClass() { }

	// RVA: 0x8553AAC Offset: 0x854FAAC VA: 0x8553AAC
	internal static AndroidJavaObject GetCurrentActivity() { }
}

// Namespace: UnityEngine.Purchasing
[Extension]
public static class GetGoogleProductMetadataExtension // TypeDefIndex: 25607
{
	// Methods

	[Extension]
	// RVA: 0x8553B08 Offset: 0x854FB08 VA: 0x8553B08
	public static GoogleProductMetadata GetGoogleProductMetadata(ProductMetadata productMetadata) { }
}

// Namespace: UnityEngine.Purchasing
public enum GooglePlayReplacementMode // TypeDefIndex: 25608
{
	// Fields
	public int value__; // 0x0
	public const GooglePlayReplacementMode UnknownReplacementMode = 0;
	public const GooglePlayReplacementMode WithTimeProration = 1;
	public const GooglePlayReplacementMode ChargeProratedPrice = 2;
	public const GooglePlayReplacementMode WithoutProration = 3;
	public const GooglePlayReplacementMode ChargeFullPrice = 5;
	public const GooglePlayReplacementMode Deferred = 6;
}

// Namespace: UnityEngine.Purchasing
internal interface IGooglePlayStore : IStore // TypeDefIndex: 25609
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetChangeSubscriptionCallback(IGooglePlayChangeSubscriptionCallback changeSubscriptionCallback);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnPause(bool isPaused);
}

// Namespace: UnityEngine.Purchasing
public class GoogleProductMetadata : ProductMetadata // TypeDefIndex: 25610
{
	// Fields
	[CompilerGenerated]
	private string <originalJson>k__BackingField; // 0x40
	[CompilerGenerated]
	private string <subscriptionPeriod>k__BackingField; // 0x48
	[CompilerGenerated]
	private string <freeTrialPeriod>k__BackingField; // 0x50
	[CompilerGenerated]
	private string <introductoryPrice>k__BackingField; // 0x58
	[CompilerGenerated]
	private string <introductoryPricePeriod>k__BackingField; // 0x60
	[CompilerGenerated]
	private int <introductoryPriceCycles>k__BackingField; // 0x68

	// Properties
	public string originalJson { get; set; }
	internal string subscriptionPeriod { set; }
	internal string freeTrialPeriod { set; }
	internal string introductoryPrice { set; }
	internal string introductoryPricePeriod { set; }
	internal int introductoryPriceCycles { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8553B80 Offset: 0x854FB80 VA: 0x8553B80
	public string get_originalJson() { }

	[CompilerGenerated]
	// RVA: 0x8553B88 Offset: 0x854FB88 VA: 0x8553B88
	internal void set_originalJson(string value) { }

	[CompilerGenerated]
	// RVA: 0x8553B90 Offset: 0x854FB90 VA: 0x8553B90
	internal void set_subscriptionPeriod(string value) { }

	[CompilerGenerated]
	// RVA: 0x8553B98 Offset: 0x854FB98 VA: 0x8553B98
	internal void set_freeTrialPeriod(string value) { }

	[CompilerGenerated]
	// RVA: 0x8553BA0 Offset: 0x854FBA0 VA: 0x8553BA0
	internal void set_introductoryPrice(string value) { }

	[CompilerGenerated]
	// RVA: 0x8553BA8 Offset: 0x854FBA8 VA: 0x8553BA8
	internal void set_introductoryPricePeriod(string value) { }

	[CompilerGenerated]
	// RVA: 0x8553BB0 Offset: 0x854FBB0 VA: 0x8553BB0
	internal void set_introductoryPriceCycles(int value) { }

	// RVA: 0x8553BB8 Offset: 0x854FBB8 VA: 0x8553BB8
	internal void .ctor(string priceString, string title, string description, string currencyCode, Decimal localizedPrice) { }
}

// Namespace: UnityEngine.Purchasing
internal interface IUnityCallback // TypeDefIndex: 25611
{}

// Namespace: UnityEngine.Purchasing
public class AppleProductMetadata : ProductMetadata // TypeDefIndex: 25612
{
	// Fields
	[CompilerGenerated]
	private readonly bool <isFamilyShareable>k__BackingField; // 0x40

	// Methods

	// RVA: 0x8553BBC Offset: 0x854FBBC VA: 0x8553BBC
	internal void .ctor(string priceString, string title, string description, string currencyCode, Decimal localizedPrice, bool isFamilyShareable) { }
}

// Namespace: UnityEngine.Purchasing
public enum AppleStorePromotionVisibility // TypeDefIndex: 25613
{
	// Fields
	public int value__; // 0x0
	public const AppleStorePromotionVisibility AppStoreConnectDefault = 0;
	public const AppleStorePromotionVisibility Default = 0;
	public const AppleStorePromotionVisibility Visible = 1;
	public const AppleStorePromotionVisibility Show = 1;
	public const AppleStorePromotionVisibility Hidden = 2;
	public const AppleStorePromotionVisibility Hide = 2;
}

// Namespace: UnityEngine.Purchasing
[NullableContext(2)]
internal interface IAppleAppReceiptViewer // TypeDefIndex: 25614
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string AppReceipt();
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
internal interface IAppleFetchProductsService // TypeDefIndex: 25615
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetNativeStore(INativeAppleStore nativeStore);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Task<List<ProductDescription>> FetchProducts(IReadOnlyCollection<ProductDefinition> products);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnProductsFetched(string json);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnProductDetailsRetrieveFailed(string errorMessage);
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
internal interface IAppleStoreCallbacks // TypeDefIndex: 25616
{
	// Methods

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetRestoreTransactionsCallback(Action<bool, string> successCallback);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetAppAccountToken(Guid token);
}

// Namespace: UnityEngine.Purchasing
internal interface INativeAppleStore : INativeStore // TypeDefIndex: 25617
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetUnityPurchasingCallback(UnityPurchasingCallback asyncCallback);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void RestoreTransactions();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void AddTransactionObserver();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void InterceptPromotionalPurchases();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void DeallocateMemory(IntPtr pointer);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void RefreshAppReceipt();
}

// Namespace: UnityEngine.Purchasing
public enum AppStore // TypeDefIndex: 25618
{
	// Fields
	public int value__; // 0x0
	public const AppStore NotSpecified = 0;
	public const AppStore GooglePlay = 1;
	public const AppStore MacAppStore = 2;
	public const AppStore AppleAppStore = 3;
	public const AppStore fake = 4;
}

// Namespace: UnityEngine.Purchasing
public interface INativeStore // TypeDefIndex: 25619
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Connect();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void FetchProducts(string json);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void FetchExistingPurchases();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Purchase(string productJson, string optionsJson);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void FinishTransaction(string productJSON, string transactionID);
}

// Namespace: UnityEngine.Purchasing
internal sealed class UnityPurchasingCallback : MulticastDelegate // TypeDefIndex: 25620
{
	// Methods

	// RVA: 0x8553BE0 Offset: 0x854FBE0 VA: 0x8553BE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x8553C80 Offset: 0x854FC80 VA: 0x8553C80 Slot: 13
	public virtual void Invoke(IntPtr subjectPtr, IntPtr payloadPtr, int entitlementStatus) { }
}

// Namespace: UnityEngine.Purchasing
public enum FakeStoreUIMode // TypeDefIndex: 25621
{
	// Fields
	public int value__; // 0x0
	public const FakeStoreUIMode Default = 0;
	public const FakeStoreUIMode StandardUser = 1;
	public const FakeStoreUIMode DeveloperUser = 2;
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
[Nullable(0)]
public static class DefaultStoreHelper // TypeDefIndex: 25622
{
	// Fields
	private static string s_DefaultCustomStoreOverrideName; // 0x0

	// Methods

	// RVA: 0x854E538 Offset: 0x854A538 VA: 0x854E538
	public static string GetDefaultStoreName() { }

	// RVA: 0x8553C94 Offset: 0x854FC94 VA: 0x8553C94
	private static string GetBuiltInDefaultStoreName() { }

	// RVA: 0x8552C08 Offset: 0x854EC08 VA: 0x8552C08
	internal static AppStore GetDefaultBuiltInAppStore() { }

	// RVA: 0x8553E64 Offset: 0x854FE64 VA: 0x8553E64
	private static void .cctor() { }
}

// Namespace: UnityEngine.Purchasing
internal static class SelectedAndroidStoreHelper // TypeDefIndex: 25623
{
	// Fields
	private static readonly string k_BillingModeFileName; // 0x0

	// Methods

	// RVA: 0x8553D88 Offset: 0x854FD88 VA: 0x8553D88
	internal static string GetSelectedAndroidStoreName() { }

	// RVA: 0x8553E0C Offset: 0x854FE0C VA: 0x8553E0C
	internal static AppStore GetSelectedAndroidStore() { }

	// RVA: 0x8553ED4 Offset: 0x854FED4 VA: 0x8553ED4
	private static StoreConfiguration LoadStoreConfiguration() { }

	// RVA: 0x8553FDC Offset: 0x854FFDC VA: 0x8553FDC
	private static void .cctor() { }
}

// Namespace: UnityEngine.Purchasing
public enum StoreSpecificPurchaseErrorCode // TypeDefIndex: 25624
{
	// Fields
	public int value__; // 0x0
	public const StoreSpecificPurchaseErrorCode SKErrorUnknown = 0;
	public const StoreSpecificPurchaseErrorCode SKErrorClientInvalid = 1;
	public const StoreSpecificPurchaseErrorCode SKErrorPaymentCancelled = 2;
	public const StoreSpecificPurchaseErrorCode SKErrorPaymentInvalid = 3;
	public const StoreSpecificPurchaseErrorCode SKErrorPaymentNotAllowed = 4;
	public const StoreSpecificPurchaseErrorCode SKErrorStoreProductNotAvailable = 5;
	public const StoreSpecificPurchaseErrorCode SKErrorCloudServicePermissionDenied = 6;
	public const StoreSpecificPurchaseErrorCode SKErrorCloudServiceNetworkConnectionFailed = 7;
	public const StoreSpecificPurchaseErrorCode SKErrorCloudServiceRevoked = 8;
	public const StoreSpecificPurchaseErrorCode BILLING_RESPONSE_RESULT_OK = 9;
	public const StoreSpecificPurchaseErrorCode BILLING_RESPONSE_RESULT_USER_CANCELED = 10;
	public const StoreSpecificPurchaseErrorCode BILLING_RESPONSE_RESULT_SERVICE_UNAVAILABLE = 11;
	public const StoreSpecificPurchaseErrorCode BILLING_RESPONSE_RESULT_BILLING_UNAVAILABLE = 12;
	public const StoreSpecificPurchaseErrorCode BILLING_RESPONSE_RESULT_ITEM_UNAVAILABLE = 13;
	public const StoreSpecificPurchaseErrorCode BILLING_RESPONSE_RESULT_DEVELOPER_ERROR = 14;
	public const StoreSpecificPurchaseErrorCode BILLING_RESPONSE_RESULT_ERROR = 15;
	public const StoreSpecificPurchaseErrorCode BILLING_RESPONSE_RESULT_ITEM_ALREADY_OWNED = 16;
	public const StoreSpecificPurchaseErrorCode BILLING_RESPONSE_RESULT_ITEM_NOT_OWNED = 17;
	public const StoreSpecificPurchaseErrorCode IABHELPER_ERROR_BASE = 18;
	public const StoreSpecificPurchaseErrorCode IABHELPER_REMOTE_EXCEPTION = 19;
	public const StoreSpecificPurchaseErrorCode IABHELPER_BAD_RESPONSE = 20;
	public const StoreSpecificPurchaseErrorCode IABHELPER_VERIFICATION_FAILED = 21;
	public const StoreSpecificPurchaseErrorCode IABHELPER_SEND_INTENT_FAILED = 22;
	public const StoreSpecificPurchaseErrorCode IABHELPER_USER_CANCELLED = 23;
	public const StoreSpecificPurchaseErrorCode IABHELPER_UNKNOWN_PURCHASE_RESPONSE = 24;
	public const StoreSpecificPurchaseErrorCode IABHELPER_MISSING_TOKEN = 25;
	public const StoreSpecificPurchaseErrorCode IABHELPER_UNKNOWN_ERROR = 26;
	public const StoreSpecificPurchaseErrorCode IABHELPER_SUBSCRIPTIONS_NOT_AVAILABLE = 27;
	public const StoreSpecificPurchaseErrorCode IABHELPER_INVALID_CONSUMPTION = 28;
	public const StoreSpecificPurchaseErrorCode Unknown = 29;
}

// Namespace: UnityEngine.Purchasing
[Serializable]
public class StoreSpecificIds : IEnumerable, ISerializationCallbackReceiver // TypeDefIndex: 25625
{
	// Fields
	private Dictionary<string, string> m_productIdDictionary; // 0x10
	[FormerlySerializedAs("m_keys")]
	[SerializeField]
	private List<string> m_storeNames; // 0x18
	[FormerlySerializedAs("m_values")]
	[SerializeField]
	private List<string> m_productIds; // 0x20

	// Methods

	// RVA: 0x8554048 Offset: 0x8550048 VA: 0x8554048 Slot: 4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x855187C Offset: 0x854D87C VA: 0x855187C
	public IEnumerator<KeyValuePair<string, string>> GetEnumerator() { }

	// RVA: 0x85540DC Offset: 0x85500DC VA: 0x85540DC
	public void Add(string id, string[] stores) { }

	// RVA: 0x8554188 Offset: 0x8550188 VA: 0x8554188 Slot: 5
	public void OnBeforeSerialize() { }

	// RVA: 0x855443C Offset: 0x855043C VA: 0x855443C Slot: 6
	public void OnAfterDeserialize() { }

	// RVA: 0x8554584 Offset: 0x8550584 VA: 0x8554584
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
[Serializable]
public class UnifiedReceipt // TypeDefIndex: 25626
{
	// Fields
	public string Payload; // 0x10
	public string Store; // 0x18
	public string TransactionID; // 0x20

	// Methods

	// RVA: 0x8554684 Offset: 0x8550684 VA: 0x8554684
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing
[Extension]
internal static class SerializationExtensions // TypeDefIndex: 25627
{
	// Methods

	[Extension]
	// RVA: 0x8544F48 Offset: 0x8540F48 VA: 0x8544F48
	public static string TryGetString(Dictionary<string, object> dic, string key) { }
}

// Namespace: UnityEngine.Purchasing
internal class JSONSerializer // TypeDefIndex: 25628
{
	// Methods

	// RVA: 0x855468C Offset: 0x855068C VA: 0x855468C
	public static string SerializeProductDef(ProductDefinition product) { }

	// RVA: 0x8554F94 Offset: 0x8550F94 VA: 0x8554F94
	public static string SerializeProductDefs(IEnumerable<ProductDefinition> products) { }

	// RVA: 0x855531C Offset: 0x855131C VA: 0x855531C
	public static Dictionary<string, Dictionary<string, object>> DeserializeFetchedPurchases(string json) { }

	// RVA: 0x8555670 Offset: 0x8551670 VA: 0x8555670
	public static List<ProductDescription> DeserializeProductDescriptions(string json) { }

	// RVA: 0x8555EBC Offset: 0x8551EBC VA: 0x8555EBC
	public static List<ProductDescription> DeserializeProductDescriptionsFromFetchProductsSk2(string json) { }

	// RVA: 0x85566F4 Offset: 0x85526F4 VA: 0x85566F4
	public static Dictionary<string, object> DeserializePurchaseDetails(string purchaseDetailJson) { }

	// RVA: 0x8555C28 Offset: 0x8551C28 VA: 0x8555C28
	private static ProductMetadata DeserializeMetadata(Dictionary<string, object> data) { }

	// RVA: 0x85546A0 Offset: 0x85506A0 VA: 0x85546A0
	private static Dictionary<string, object> EncodeProductDef(ProductDefinition product) { }
}

// Namespace: UnityEngine.Purchasing
[Extension]
internal static class ProductDefinitionExtensions // TypeDefIndex: 25629
{
	// Methods

	[Extension]
	// RVA: 0x8556A18 Offset: 0x8552A18 VA: 0x8556A18
	internal static List<ProductDefinition> DecodeJSON(List<object> productsList, string storeName) { }
}

// Namespace: UnityEngine.Purchasing
[Extension]
internal static class ProductTypeExtensions // TypeDefIndex: 25630
{
	// Methods

	[Extension]
	// RVA: 0x85565C0 Offset: 0x85525C0 VA: 0x85565C0
	internal static ProductType ToProductType(string productType) { }
}

// Namespace: UnityEngine.Purchasing
internal static class UnifiedReceiptFormatter // TypeDefIndex: 25631
{
	// Methods

	// RVA: 0x8543E90 Offset: 0x853FE90 VA: 0x8543E90
	internal static string FormatUnifiedReceipt(string platformReceipt, string transactionId, string storeName) { }
}

// Namespace: UnityEngine.Purchasing.Utilities
internal static class UnityUtilContainer // TypeDefIndex: 25632
{
	// Fields
	[Nullable(2)]
	private static UnityUtil s_UnityUtilInstance; // 0x0

	// Methods

	[NullableContext(1)]
	// RVA: 0x85571A8 Offset: 0x85531A8 VA: 0x85571A8
	internal static UnityUtil Instance() { }
}

// Namespace: UnityEngine.Purchasing.Utilities
internal static class UnityUtilDependencyInjector // TypeDefIndex: 25633
{
	// Methods

	// RVA: 0x8557220 Offset: 0x8553220 VA: 0x8557220
	internal static UnityUtil CreateUnityUtils() { }

	// RVA: 0x855747C Offset: 0x855347C VA: 0x855747C
	private static MonoBehaviourUtil CreateMonoBehaviourUtil() { }
}

// Namespace: UnityEngine.Purchasing.Telemetry
internal interface ITelemetryDiagnostics // TypeDefIndex: 25634
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SendDiagnostic(string diagnosticName, Exception e);
}

// Namespace: UnityEngine.Purchasing.Telemetry
internal interface ITelemetryDiagnosticsInstanceWrapper // TypeDefIndex: 25635
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetDiagnosticsInstance(IDiagnostics diagnosticsInstance);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SendDiagnostic(string diagnosticName, string diagnosticException);
}

// Namespace: UnityEngine.Purchasing.Telemetry
internal struct TelemetryDiagnosticParams // TypeDefIndex: 25636
{
	// Fields
	internal string name; // 0x0
	internal string exception; // 0x8

	// Methods

	// RVA: 0x8557550 Offset: 0x8553550 VA: 0x8557550
	internal void .ctor(string diagnosticName, string diagnosticException) { }
}

// Namespace: UnityEngine.Purchasing.Telemetry
internal class TelemetryDiagnostics : ITelemetryDiagnostics // TypeDefIndex: 25637
{
	// Fields
	private readonly ITelemetryDiagnosticsInstanceWrapper m_TelemetryDiagnosticsInstanceWrapper; // 0x10

	// Methods

	[Preserve]
	// RVA: 0x8557580 Offset: 0x8553580 VA: 0x8557580
	internal void .ctor(ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper) { }

	// RVA: 0x85575B0 Offset: 0x85535B0 VA: 0x85575B0 Slot: 4
	public void SendDiagnostic(string diagnosticName, Exception e) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TelemetryDiagnosticsInstanceWrapper.<>c__DisplayClass7_0 // TypeDefIndex: 25638
{
	// Fields
	public TelemetryDiagnosticsInstanceWrapper <>4__this; // 0x10
	public TelemetryDiagnosticParams diagnosticParams; // 0x18

	// Methods

	// RVA: 0x8557B14 Offset: 0x8553B14 VA: 0x8557B14
	public void .ctor() { }

	// RVA: 0x8557CBC Offset: 0x8553CBC VA: 0x8557CBC
	internal void <SendDiagnosticOnMainThread>b__0() { }
}

// Namespace: UnityEngine.Purchasing.Telemetry
internal class TelemetryDiagnosticsInstanceWrapper : ITelemetryDiagnosticsInstanceWrapper // TypeDefIndex: 25639
{
	// Fields
	private IDiagnostics m_Instance; // 0x10
	private ILogger m_Logger; // 0x18
	private IUtil m_Util; // 0x20
	private readonly TelemetryQueue<TelemetryDiagnosticParams> m_Queue; // 0x28

	// Methods

	// RVA: 0x85577A8 Offset: 0x85537A8 VA: 0x85577A8
	internal void .ctor(ILogger logger, IUtil util) { }

	// RVA: 0x85578B0 Offset: 0x85538B0 VA: 0x85578B0 Slot: 4
	public void SetDiagnosticsInstance(IDiagnostics diagnosticsInstance) { }

	// RVA: 0x8557914 Offset: 0x8553914 VA: 0x8557914 Slot: 5
	public void SendDiagnostic(string diagnosticName, string diagnosticException) { }

	// RVA: 0x85579C4 Offset: 0x85539C4 VA: 0x85579C4
	private void SendDiagnosticOnMainThread(TelemetryDiagnosticParams diagnosticParams) { }

	// RVA: 0x8557B1C Offset: 0x8553B1C VA: 0x8557B1C
	private void SendDiagnosticAndCatchExceptions(TelemetryDiagnosticParams diagnosticParams) { }
}

// Namespace: UnityEngine.Purchasing.Telemetry
internal class IapTelemetryException : Exception // TypeDefIndex: 25640
{
	// Methods

	// RVA: 0x8557CDC Offset: 0x8553CDC VA: 0x8557CDC
	public void .ctor(string message) { }
}

// Namespace: UnityEngine.Purchasing.Telemetry
internal interface ITelemetryMetricEvent // TypeDefIndex: 25641
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void StartMetric();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void StopAndSendMetric();
}

// Namespace: UnityEngine.Purchasing.Telemetry
internal interface ITelemetryMetricsInstanceWrapper // TypeDefIndex: 25642
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetMetricsInstance(IMetrics metricsInstance);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SendMetric(TelemetryMetricTypes telemetryMetricTypes, string metricName, double metricTimeSeconds);
}

// Namespace: UnityEngine.Purchasing.Telemetry
internal interface ITelemetryMetricsService // TypeDefIndex: 25643
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ExecuteTimedAction(Action timedAction, TelemetryMetricDefinition metricDefinition);
}

// Namespace: UnityEngine.Purchasing.Telemetry
internal struct TelemetryMetricDefinition // TypeDefIndex: 25644
{
	// Fields
	[CompilerGenerated]
	private readonly TelemetryMetricTypes <MetricType>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly string <MetricName>k__BackingField; // 0x8

	// Properties
	public TelemetryMetricTypes MetricType { get; }
	public string MetricName { get; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x8557D44 Offset: 0x8553D44 VA: 0x8557D44
	public TelemetryMetricTypes get_MetricType() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x8557D4C Offset: 0x8553D4C VA: 0x8557D4C
	public string get_MetricName() { }

	// RVA: 0x8557D54 Offset: 0x8553D54 VA: 0x8557D54
	public void .ctor(string metricName, TelemetryMetricTypes metricType = 2) { }

	// RVA: 0x8557D7C Offset: 0x8553D7C VA: 0x8557D7C
	public static TelemetryMetricDefinition op_Implicit(string name) { }
}

// Namespace: UnityEngine.Purchasing.Telemetry
internal static class TelemetryMetricDefinitions // TypeDefIndex: 25645
{
	// Fields
	internal static readonly TelemetryMetricDefinition confirmSubscriptionPriceChangeName; // 0x0
	internal static readonly TelemetryMetricDefinition continuePromotionalPurchasesName; // 0x10
	internal static readonly TelemetryMetricDefinition dequeueQueryProductsTimeName; // 0x20
	internal static readonly TelemetryMetricDefinition dequeueQueryPurchasesTimeName; // 0x30
	internal static readonly TelemetryMetricDefinition fetchStorePromotionOrderName; // 0x40
	internal static readonly TelemetryMetricDefinition fetchStorePromotionVisibilityName; // 0x50
	internal static readonly TelemetryMetricDefinition initPurchaseName; // 0x60
	internal static readonly TelemetryMetricDefinition packageInitTimeName; // 0x70
	internal static readonly TelemetryMetricDefinition presentCodeRedemptionSheetName; // 0x80
	internal static readonly TelemetryMetricDefinition refreshAppReceiptName; // 0x90
	internal static readonly TelemetryMetricDefinition restoreTransactionName; // 0xA0
	internal static readonly TelemetryMetricDefinition fetchProductsName; // 0xB0
	internal static readonly TelemetryMetricDefinition setStorePromotionOrderName; // 0xC0
	internal static readonly TelemetryMetricDefinition setStorePromotionVisibilityName; // 0xD0
	internal static readonly TelemetryMetricDefinition upgradeDowngradeSubscriptionName; // 0xE0

	// Methods

	// RVA: 0x8557DB0 Offset: 0x8553DB0 VA: 0x8557DB0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Purchasing.Telemetry
internal class TelemetryMetricEvent : ITelemetryMetricEvent // TypeDefIndex: 25646
{
	// Fields
	private readonly ITelemetryMetricsInstanceWrapper m_TelemetryMetricsInstanceWrapper; // 0x10
	private readonly TelemetryMetricTypes m_MetricType; // 0x18
	private readonly string m_MetricName; // 0x20
	private Stopwatch m_Stopwatch; // 0x28

	// Methods

	// RVA: 0x855825C Offset: 0x855425C VA: 0x855825C
	internal void .ctor(ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper, TelemetryMetricTypes metricType, string metricName) { }

	// RVA: 0x8558308 Offset: 0x8554308 VA: 0x8558308 Slot: 4
	public void StartMetric() { }

	// RVA: 0x855838C Offset: 0x855438C VA: 0x855838C Slot: 5
	public void StopAndSendMetric() { }
}

// Namespace: UnityEngine.Purchasing.Telemetry
internal struct TelemetryMetricParams // TypeDefIndex: 25647
{
	// Fields
	internal TelemetryMetricTypes type; // 0x0
	internal string name; // 0x8
	internal double timeSeconds; // 0x10

	// Methods

	// RVA: 0x855850C Offset: 0x855450C VA: 0x855850C
	internal void .ctor(TelemetryMetricTypes metricType, string metricName, double metricTimeSeconds) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TelemetryMetricsInstanceWrapper.<>c__DisplayClass7_0 // TypeDefIndex: 25648
{
	// Fields
	public TelemetryMetricsInstanceWrapper <>4__this; // 0x10
	public TelemetryMetricParams metricParams; // 0x18

	// Methods

	// RVA: 0x85588F0 Offset: 0x85548F0 VA: 0x85588F0
	public void .ctor() { }

	// RVA: 0x8558BCC Offset: 0x8554BCC VA: 0x8558BCC
	internal void <SendMetricOnMainThread>b__0() { }
}

// Namespace: UnityEngine.Purchasing.Telemetry
internal class TelemetryMetricsInstanceWrapper : ITelemetryMetricsInstanceWrapper // TypeDefIndex: 25649
{
	// Fields
	private IMetrics m_Instance; // 0x10
	private ILogger m_Logger; // 0x18
	private IUtil m_Util; // 0x20
	private readonly TelemetryQueue<TelemetryMetricParams> m_Queue; // 0x28

	// Methods

	// RVA: 0x855853C Offset: 0x855453C VA: 0x855853C
	internal void .ctor(ILogger logger, IUtil util) { }

	// RVA: 0x8558644 Offset: 0x8554644 VA: 0x8558644 Slot: 4
	public void SetMetricsInstance(IMetrics metricsInstance) { }

	// RVA: 0x85586C0 Offset: 0x85546C0 VA: 0x85586C0 Slot: 5
	public void SendMetric(TelemetryMetricTypes metricType, string metricName, double metricTimeSeconds) { }

	// RVA: 0x85587A4 Offset: 0x85547A4 VA: 0x85587A4
	private void SendMetricOnMainThread(TelemetryMetricParams metricParams) { }

	// RVA: 0x85588F8 Offset: 0x85548F8 VA: 0x85588F8
	private void SendMetricByTypeAndCatchExceptions(TelemetryMetricParams metricParams) { }

	// RVA: 0x8558A24 Offset: 0x8554A24 VA: 0x8558A24
	private void SendMetricByType(TelemetryMetricParams metricParams) { }
}

// Namespace: UnityEngine.Purchasing.Telemetry
internal class TelemetryMetricsService : ITelemetryMetricsService // TypeDefIndex: 25650
{
	// Fields
	private readonly ITelemetryMetricsInstanceWrapper m_TelemetryMetricsInstanceWrapper; // 0x10

	// Methods

	// RVA: 0x8558C18 Offset: 0x8554C18 VA: 0x8558C18
	public void .ctor(ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper) { }

	// RVA: 0x8558C48 Offset: 0x8554C48 VA: 0x8558C48 Slot: 4
	public void ExecuteTimedAction(Action timedAction, TelemetryMetricDefinition metricDefinition) { }

	// RVA: 0x8558E40 Offset: 0x8554E40 VA: 0x8558E40 Slot: 5
	public ITelemetryMetricEvent CreateAndStartMetricEvent(TelemetryMetricDefinition metricDefinition) { }
}

// Namespace: UnityEngine.Purchasing.Telemetry
internal enum TelemetryMetricTypes // TypeDefIndex: 25651
{
	// Fields
	public int value__; // 0x0
	public const TelemetryMetricTypes Gauge = 0;
	public const TelemetryMetricTypes Sum = 1;
	public const TelemetryMetricTypes Histogram = 2;
}

// Namespace: UnityEngine.Purchasing.Telemetry
internal class TelemetryQueue<TTelemetryEventParams> // TypeDefIndex: 25652
{
	// Fields
	private readonly Action<TTelemetryEventParams> m_SendTelemetryEvent; // 0x0
	private ConcurrentQueue<TTelemetryEventParams> m_Queue; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Action<TTelemetryEventParams> sendTelemetryEvent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55E8AE4 Offset: 0x55E4AE4 VA: 0x55E8AE4
	|-TelemetryQueue<TelemetryDiagnosticParams>..ctor
	|
	|-RVA: 0x55E8C6C Offset: 0x55E4C6C VA: 0x55E8C6C
	|-TelemetryQueue<TelemetryMetricParams>..ctor
	|
	|-RVA: 0x55E8E50 Offset: 0x55E4E50 VA: 0x55E8E50
	|-TelemetryQueue<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void QueueEvent(TTelemetryEventParams telemetryEvent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55E8B14 Offset: 0x55E4B14 VA: 0x55E8B14
	|-TelemetryQueue<TelemetryDiagnosticParams>.QueueEvent
	|
	|-RVA: 0x55E8C9C Offset: 0x55E4C9C VA: 0x55E8C9C
	|-TelemetryQueue<TelemetryMetricParams>.QueueEvent
	|
	|-RVA: 0x55E8E80 Offset: 0x55E4E80 VA: 0x55E8E80
	|-TelemetryQueue<__Il2CppFullySharedGenericType>.QueueEvent
	*/

	// RVA: -1 Offset: -1
	internal void SendQueuedEvents() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55E8BF4 Offset: 0x55E4BF4 VA: 0x55E8BF4
	|-TelemetryQueue<TelemetryDiagnosticParams>.SendQueuedEvents
	|
	|-RVA: 0x55E8DB4 Offset: 0x55E4DB4 VA: 0x55E8DB4
	|-TelemetryQueue<TelemetryMetricParams>.SendQueuedEvents
	|
	|-RVA: 0x55E9020 Offset: 0x55E5020 VA: 0x55E9020
	|-TelemetryQueue<__Il2CppFullySharedGenericType>.SendQueuedEvents
	*/
}

// Namespace: UnityEngine.Purchasing.Exceptions
internal class GoogleFetchProductException : FetchProductsException // TypeDefIndex: 25653
{
	// Fields
	[CompilerGenerated]
	private readonly GoogleFetchProductsFailureReason <FailureReason>k__BackingField; // 0x98
	[CompilerGenerated]
	private readonly GoogleBillingResponseCode <ResponseCode>k__BackingField; // 0x9C

	// Methods

	[NullableContext(1)]
	// RVA: 0x8559038 Offset: 0x8555038 VA: 0x8559038
	public void .ctor(GoogleFetchProductsFailureReason failureReason, GoogleBillingResponseCode responseCode, ProductFetchFailureDescription failureDescription) { }
}

// Namespace: UnityEngine.Purchasing.Exceptions
[Nullable(0)]
[NullableContext(1)]
internal class FetchProductsException : IapException // TypeDefIndex: 25654
{
	// Fields
	[CompilerGenerated]
	private readonly ProductFetchFailureDescription <FailureDescription>k__BackingField; // 0x90

	// Properties
	internal ProductFetchFailureDescription FailureDescription { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x855909C Offset: 0x855509C VA: 0x855909C
	internal ProductFetchFailureDescription get_FailureDescription() { }

	// RVA: 0x8559064 Offset: 0x8555064 VA: 0x8559064
	public void .ctor(ProductFetchFailureDescription failureDescription) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AndroidJavaObjectExtensions.<>c__DisplayClass0_0<T> // TypeDefIndex: 25655
{
	// Fields
	public AndroidJavaObject androidJavaList; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485CC74 Offset: 0x4858C74 VA: 0x485CC74
	|-AndroidJavaObjectExtensions.<>c__DisplayClass0_0<object>..ctor
	|
	|-RVA: 0x485CD8C Offset: 0x4858D8C VA: 0x485CD8C
	|-AndroidJavaObjectExtensions.<>c__DisplayClass0_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T <Enumerate>b__0(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485CC7C Offset: 0x4858C7C VA: 0x485CC7C
	|-AndroidJavaObjectExtensions.<>c__DisplayClass0_0<object>.<Enumerate>b__0
	|
	|-RVA: 0x485CD94 Offset: 0x4858D94 VA: 0x485CD94
	|-AndroidJavaObjectExtensions.<>c__DisplayClass0_0<__Il2CppFullySharedGenericType>.<Enumerate>b__0
	*/
}

// Namespace: UnityEngine.Purchasing.Models
[Extension]
internal static class AndroidJavaObjectExtensions // TypeDefIndex: 25656
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	internal static IEnumerable<T> Enumerate<T>(AndroidJavaObject androidJavaList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x475EF5C Offset: 0x475AF5C VA: 0x475EF5C
	|-AndroidJavaObjectExtensions.Enumerate<object>
	|
	|-RVA: 0x475F0F4 Offset: 0x475B0F4 VA: 0x475F0F4
	|-AndroidJavaObjectExtensions.Enumerate<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x85590A4 Offset: 0x85550A4 VA: 0x85590A4
	internal static IEnumerable<AndroidJavaObject> Enumerate(AndroidJavaObject androidJavaList) { }
}

// Namespace: UnityEngine.Purchasing.Models
internal interface IGoogleBillingResult // TypeDefIndex: 25657
{
	// Properties
	public abstract GoogleBillingResponseCode responseCode { get; }
	public abstract string debugMessage { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract GoogleBillingResponseCode get_responseCode();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_debugMessage();
}

// Namespace: UnityEngine.Purchasing.Models
internal enum GoogleBillingResponseCode // TypeDefIndex: 25658
{
	// Fields
	public int value__; // 0x0
	public const GoogleBillingResponseCode ServiceTimeout = -3;
	public const GoogleBillingResponseCode FeatureNotSupported = -2;
	public const GoogleBillingResponseCode ServiceDisconnected = -1;
	public const GoogleBillingResponseCode Ok = 0;
	public const GoogleBillingResponseCode UserCanceled = 1;
	public const GoogleBillingResponseCode ServiceUnavailable = 2;
	public const GoogleBillingResponseCode BillingUnavailable = 3;
	public const GoogleBillingResponseCode ItemUnavailable = 4;
	public const GoogleBillingResponseCode DeveloperError = 5;
	public const GoogleBillingResponseCode FatalError = 6;
	public const GoogleBillingResponseCode ItemAlreadyOwned = 7;
	public const GoogleBillingResponseCode ItemNotOwned = 8;
	public const GoogleBillingResponseCode NetworkError = 12;
}

// Namespace: UnityEngine.Purchasing.Models
internal enum GoogleFetchProductsFailureReason // TypeDefIndex: 25659
{
	// Fields
	public int value__; // 0x0
	public const GoogleFetchProductsFailureReason BillingServiceDisconnected = 0;
	public const GoogleFetchProductsFailureReason BillingServiceUnavailable = 1;
	public const GoogleFetchProductsFailureReason Unknown = 2;
}

// Namespace: UnityEngine.Purchasing.Interfaces
[NullableContext(2)]
internal interface IRestoreTransactionsUseCase // TypeDefIndex: 25660
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void RestoreTransactions(Action<bool, string> callback);
}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IBillingClientStateListener // TypeDefIndex: 25661
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void RegisterOnConnected(Action onConnected);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void RegisterOnDisconnected(Action<GoogleBillingResponseCode> onDisconnected);
}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGoogleBillingClient // TypeDefIndex: 25662
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void StartConnection(IBillingClientStateListener billingClientStateListener);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void QueryPurchasesAsync(string skuType, Action<IGoogleBillingResult, IEnumerable<AndroidJavaObject>> onQueryPurchasesResponse);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void QueryProductDetailsAsync(List<string> skus, string type, Action<IGoogleBillingResult, List<AndroidJavaObject>> onProductDetailsResponseAction);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract AndroidJavaObject LaunchBillingFlow(AndroidJavaObject productDetails, string oldPurchaseToken, Nullable<GooglePlayReplacementMode> replacementMode);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void ConsumeAsync(string purchaseToken, Action<IGoogleBillingResult> onConsume);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void AcknowledgePurchase(string purchaseToken, Action<IGoogleBillingResult> onAcknowledge);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SetObfuscationAccountId(string obfuscationAccountId);
}

// Namespace: UnityEngine.Purchasing.Interfaces
[NullableContext(1)]
internal interface IGooglePlayStoreService // TypeDefIndex: 25663
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void FetchProducts(IReadOnlyCollection<ProductDefinition> products, Action<List<ProductDescription>> onProductsReceived, Action<GoogleFetchProductException> onFetchProductsFailed);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Purchase(ProductDefinition product);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Task FinishTransaction(ProductDefinition product, string purchaseToken, Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void FetchPurchases(Action<List<IGooglePurchase>> onQueryPurchaseSucceed, Action<string> onQueryPurchaseFailed);
}

// Namespace: UnityEngine.Purchasing.Interfaces
[NullableContext(1)]
internal interface IGooglePurchase // TypeDefIndex: 25664
{
	// Properties
	public abstract int purchaseState { get; }
	public abstract List<string> skus { get; }
	public abstract string receipt { get; }
	[Nullable(2)]
	public abstract string obfuscatedAccountId { get; }
	[Nullable(2)]
	public abstract string obfuscatedProfileId { get; }
	public abstract string purchaseToken { get; }
	public abstract IEnumerable<ProductDescription> productDescriptions { get; }
	[Nullable(2)]
	public abstract string sku { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_purchaseState();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract List<string> get_skus();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_receipt();

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_obfuscatedAccountId();

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_obfuscatedProfileId();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_purchaseToken();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IEnumerable<ProductDescription> get_productDescriptions();

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_sku();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool IsAcknowledged();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool IsPurchased();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool IsPending();
}

// Namespace: UnityEngine.Purchasing.Interfaces
[NullableContext(1)]
internal interface IQueryProductDetailsService // TypeDefIndex: 25665
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Task<List<AndroidJavaObject>> QueryProductDetails(ProductDefinition product);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Task<List<ProductDescription>> QueryProductDescriptions(IReadOnlyCollection<ProductDefinition> products);
}

// Namespace: UnityEngine.Purchasing.Extension
public interface IStoreProductsCallback // TypeDefIndex: 25666
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnProductsFetched(IReadOnlyList<ProductDescription> products);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnProductsFetchFailed(ProductFetchFailureDescription failureDescription);
}

// Namespace: UnityEngine.Purchasing.Extension
internal interface IInternalStore : IStore // TypeDefIndex: 25667
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetStoreConnectionState(ConnectionState connectionState);
}

// Namespace: UnityEngine.Purchasing.Extension
[NullableContext(1)]
internal interface IProductCache // TypeDefIndex: 25668
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Add(List<Product> product);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract ReadOnlyObservableCollection<Product> GetProducts();

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract Product Find(string productId);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Product FindOrDefault(string productId);
}

// Namespace: UnityEngine.Purchasing.Extension
[NullableContext(1)]
internal interface IStore // TypeDefIndex: 25669
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Connect();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void FetchProducts(IReadOnlyCollection<ProductDefinition> products);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void FetchPurchases();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Purchase(ICart cart);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void FinishTransaction(PendingOrder pendingOrder);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SetProductsCallback(IStoreProductsCallback productsCallback);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchPurchaseCallback);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void SetPurchaseCallback(IStorePurchaseCallback purchaseCallback);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void SetPurchaseConfirmCallback(IStorePurchaseConfirmCallback confirmCallback);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void SetStoreConnectionCallback(IStoreConnectCallback storeConnectCallback);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void SetEntitlementCheckCallback(IStoreCheckEntitlementCallback entitlementCallback);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void SetOnRevokedEntitlementCallback(IOnEntitlementRevokedCallback entitlementRevokedCallback);
}

// Namespace: UnityEngine.Purchasing.Extension
[Nullable(0)]
[NullableContext(1)]
internal class ProductCache : IProductCache // TypeDefIndex: 25670
{
	// Fields
	private ObservableCollection<Product> m_Products; // 0x10
	private readonly ReadOnlyObservableCollection<Product> m_ProductsReadOnly; // 0x18
	[CompilerGenerated]
	private readonly Dictionary<string, Product> <productsById>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly Dictionary<string, Product> <productsByStoreSpecificId>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly Dictionary<string, string> <storeSpecificProductIds>k__BackingField; // 0x30

	// Properties
	public Dictionary<string, Product> productsById { get; }
	private Dictionary<string, Product> productsByStoreSpecificId { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x85590EC Offset: 0x85550EC VA: 0x85590EC Slot: 8
	public Dictionary<string, Product> get_productsById() { }

	[CompilerGenerated]
	// RVA: 0x85590F4 Offset: 0x85550F4 VA: 0x85590F4
	private Dictionary<string, Product> get_productsByStoreSpecificId() { }

	// RVA: 0x85590FC Offset: 0x85550FC VA: 0x85590FC
	internal void .ctor() { }

	// RVA: 0x85592B0 Offset: 0x85552B0 VA: 0x85592B0 Slot: 4
	public void Add(List<Product> products) { }

	// RVA: 0x85593EC Offset: 0x85553EC VA: 0x85593EC Slot: 9
	public void Add(Product product) { }

	// RVA: 0x8559568 Offset: 0x8555568 VA: 0x8559568 Slot: 5
	public ReadOnlyObservableCollection<Product> GetProducts() { }

	// RVA: 0x8559570 Offset: 0x8555570 VA: 0x8559570 Slot: 7
	public Product FindOrDefault(string productId) { }

	[NullableContext(2)]
	// RVA: 0x85594D8 Offset: 0x85554D8 VA: 0x85594D8 Slot: 6
	public Product Find(string productId) { }

	[NullableContext(2)]
	// RVA: 0x8559594 Offset: 0x8555594 VA: 0x8559594
	private bool HasId(string productId) { }

	[NullableContext(2)]
	// RVA: 0x8559600 Offset: 0x8555600 VA: 0x8559600
	private bool HasStoreSpecificId(string productId) { }
}

// Namespace: UnityEngine.Purchasing.Extension
public class ProductDescription // TypeDefIndex: 25671
{
	// Fields
	[CompilerGenerated]
	private string <storeSpecificId>k__BackingField; // 0x10
	public ProductType type; // 0x18
	[CompilerGenerated]
	private ProductMetadata <metadata>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <receipt>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <transactionId>k__BackingField; // 0x30

	// Properties
	public string storeSpecificId { get; set; }
	public ProductMetadata metadata { get; set; }
	public string receipt { get; set; }
	public string transactionId { get; set; }

	// Methods

	// RVA: 0x855966C Offset: 0x855566C VA: 0x855966C
	public void .ctor(string id, ProductMetadata metadata, string receipt, string transactionId) { }

	// RVA: 0x8555E98 Offset: 0x8551E98 VA: 0x8555E98
	public void .ctor(string id, ProductMetadata metadata, string receipt, string transactionId, ProductType type) { }

	// RVA: 0x85596E0 Offset: 0x85556E0 VA: 0x85596E0
	public void .ctor(string id, ProductMetadata metadata) { }

	[CompilerGenerated]
	// RVA: 0x85596EC Offset: 0x85556EC VA: 0x85596EC
	public string get_storeSpecificId() { }

	[CompilerGenerated]
	// RVA: 0x85596F4 Offset: 0x85556F4 VA: 0x85596F4
	private void set_storeSpecificId(string value) { }

	[CompilerGenerated]
	// RVA: 0x85596FC Offset: 0x85556FC VA: 0x85596FC
	public ProductMetadata get_metadata() { }

	[CompilerGenerated]
	// RVA: 0x8559704 Offset: 0x8555704 VA: 0x8559704
	private void set_metadata(ProductMetadata value) { }

	[CompilerGenerated]
	// RVA: 0x855970C Offset: 0x855570C VA: 0x855970C
	public string get_receipt() { }

	[CompilerGenerated]
	// RVA: 0x8559714 Offset: 0x8555714 VA: 0x8559714
	private void set_receipt(string value) { }

	[CompilerGenerated]
	// RVA: 0x855971C Offset: 0x855571C VA: 0x855971C
	public string get_transactionId() { }

	[CompilerGenerated]
	// RVA: 0x8559724 Offset: 0x8555724 VA: 0x8559724
	public void set_transactionId(string value) { }

	// RVA: 0x855972C Offset: 0x855572C VA: 0x855972C Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.Purchasing.Extension
[NullableContext(1)]
[Nullable(0)]
public abstract class Store : IStore // TypeDefIndex: 25672
{
	// Fields
	[Nullable(2)]
	protected IStoreProductsCallback ProductsCallback; // 0x10
	[Nullable(2)]
	protected IStorePurchaseFetchCallback PurchaseFetchCallback; // 0x18
	[Nullable(2)]
	protected IStorePurchaseCallback PurchaseCallback; // 0x20
	[Nullable(2)]
	protected IStorePurchaseConfirmCallback ConfirmCallback; // 0x28
	[Nullable(2)]
	protected IStoreCheckEntitlementCallback EntitlementCallback; // 0x30
	[Nullable(2)]
	protected IStoreConnectCallback ConnectCallback; // 0x38
	[Nullable(2)]
	protected IOnEntitlementRevokedCallback EntitlementRevokedCallback; // 0x40
	internal IProductCache ProductCache; // 0x48

	// Methods

	// RVA: 0x853E530 Offset: 0x853A530 VA: 0x853E530
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void Connect();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void FetchProducts(IReadOnlyCollection<ProductDefinition> products);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void FetchPurchases();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void Purchase(ICart cart);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void FinishTransaction(PendingOrder pendingOrder);

	// RVA: 0x85598FC Offset: 0x85558FC VA: 0x85598FC Slot: 21
	public virtual void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchPurchaseCallback) { }

	// RVA: 0x8559904 Offset: 0x8555904 VA: 0x8559904 Slot: 22
	public virtual void SetPurchaseCallback(IStorePurchaseCallback purchaseCallback) { }

	// RVA: 0x855990C Offset: 0x855590C VA: 0x855990C Slot: 23
	public virtual void SetPurchaseConfirmCallback(IStorePurchaseConfirmCallback confirmCallback) { }

	// RVA: 0x8559914 Offset: 0x8555914 VA: 0x8559914 Slot: 24
	public virtual void SetStoreConnectionCallback(IStoreConnectCallback storeConnectCallback) { }

	// RVA: 0x855991C Offset: 0x855591C VA: 0x855991C Slot: 25
	public virtual void SetProductsCallback(IStoreProductsCallback productsCallback) { }

	// RVA: 0x8559924 Offset: 0x8555924 VA: 0x8559924 Slot: 26
	public virtual void SetEntitlementCheckCallback(IStoreCheckEntitlementCallback entitlementCallback) { }

	// RVA: 0x855992C Offset: 0x855592C VA: 0x855992C Slot: 27
	public virtual void SetOnRevokedEntitlementCallback(IOnEntitlementRevokedCallback entitlementRevokedCallback) { }
}

// Namespace: UnityEngine.Purchasing.UseCases
[NullableContext(1)]
[Nullable(0)]
internal class FetchStorePromotionOrderUseCase : IFetchStorePromotionOrderUseCase // TypeDefIndex: 25673
{
	// Fields
	private readonly IAppleStoreCallbacks m_AppleStoreCallbacks; // 0x10
	private readonly INativeAppleStore m_NativeAppleStore; // 0x18

	// Methods

	[Preserve]
	// RVA: 0x8559934 Offset: 0x8555934 VA: 0x8559934
	internal void .ctor(IAppleStoreCallbacks appleStoreCallbacks, INativeAppleStore nativeStore) { }
}

// Namespace: UnityEngine.Purchasing.UseCases
[NullableContext(1)]
[Nullable(0)]
internal class FetchStorePromotionVisibilityUseCase : IFetchStorePromotionVisibilityUseCase // TypeDefIndex: 25674
{
	// Fields
	private readonly IAppleStoreCallbacks m_AppleStoreCallbacks; // 0x10
	private readonly INativeAppleStore m_NativeAppleStore; // 0x18

	// Methods

	[Preserve]
	// RVA: 0x8559978 Offset: 0x8555978 VA: 0x8559978
	internal void .ctor(IAppleStoreCallbacks appleStoreCallbacks, INativeAppleStore nativeStore) { }
}

// Namespace: UnityEngine.Purchasing.UseCases
[NullableContext(1)]
[Nullable(0)]
internal class GetIntroductoryPriceDictionaryUseCase : IGetIntroductoryPriceDictionaryUseCase // TypeDefIndex: 25675
{
	// Fields
	private readonly IAppleFetchProductsService m_FetchProductsService; // 0x10

	// Methods

	[Preserve]
	// RVA: 0x85599BC Offset: 0x85559BC VA: 0x85599BC
	internal void .ctor(IAppleFetchProductsService fetchProductsService) { }
}

// Namespace: UnityEngine.Purchasing.UseCases
[NullableContext(1)]
[Nullable(0)]
internal class GetProductDetailsUseCase : IGetProductDetailsUseCase // TypeDefIndex: 25676
{
	// Fields
	private readonly IAppleFetchProductsService m_FetchProductsService; // 0x10

	// Methods

	[Preserve]
	// RVA: 0x85599EC Offset: 0x85559EC VA: 0x85599EC
	internal void .ctor(IAppleFetchProductsService fetchProductsService) { }
}

// Namespace: UnityEngine.Purchasing.UseCases
[Nullable(0)]
[NullableContext(1)]
internal class SetStorePromotionOrderUseCase : ISetStorePromotionOrderUseCase // TypeDefIndex: 25677
{
	// Fields
	private readonly INativeAppleStore m_NativeAppleStore; // 0x10

	// Methods

	[Preserve]
	// RVA: 0x8559A1C Offset: 0x8555A1C VA: 0x8559A1C
	internal void .ctor(INativeAppleStore nativeStore) { }
}

// Namespace: UnityEngine.Purchasing.UseCases
[Nullable(0)]
[NullableContext(1)]
internal class SetStorePromotionVisibilityUseCase : ISetStorePromotionVisibilityUseCase // TypeDefIndex: 25678
{
	// Fields
	private readonly INativeAppleStore m_NativeAppleStore; // 0x10
	private readonly ITelemetryDiagnostics m_TelemetryDiagnostics; // 0x18

	// Methods

	[Preserve]
	// RVA: 0x8559A4C Offset: 0x8555A4C VA: 0x8559A4C
	internal void .ctor(INativeAppleStore nativeStore, ITelemetryDiagnostics telemetryDiagnostics) { }
}

// Namespace: UnityEngine.Purchasing.UseCases
[NullableContext(1)]
[Nullable(0)]
internal class AppleRefreshAppReceiptUseCase : IRefreshAppReceiptUseCase // TypeDefIndex: 25679
{
	// Fields
	private readonly IAppleStoreCallbacks m_AppleStoreCallbacks; // 0x10
	private readonly INativeAppleStore m_NativeAppleStore; // 0x18

	// Methods

	[Preserve]
	// RVA: 0x8559A90 Offset: 0x8555A90 VA: 0x8559A90
	internal void .ctor(IAppleStoreCallbacks appleStoreCallbacks, INativeAppleStore nativeStore) { }
}

// Namespace: UnityEngine.Purchasing.UseCases
[Nullable(0)]
[NullableContext(1)]
internal class AppleRestoreTransactionsUseCase : IRestoreTransactionsUseCase // TypeDefIndex: 25680
{
	// Fields
	private readonly IAppleStoreCallbacks m_AppleStoreCallbacks; // 0x10
	private readonly INativeAppleStore m_NativeAppleStore; // 0x18

	// Methods

	[Preserve]
	// RVA: 0x8559AD4 Offset: 0x8555AD4 VA: 0x8559AD4
	internal void .ctor(IAppleStoreCallbacks appleStoreCallbacks, INativeAppleStore nativeStore) { }

	[NullableContext(2)]
	// RVA: 0x8559B18 Offset: 0x8555B18 VA: 0x8559B18 Slot: 4
	public void RestoreTransactions(Action<bool, string> callback) { }
}

// Namespace: UnityEngine.Purchasing.UseCases
internal class AppReceiptUseCase : IAppReceiptUseCase // TypeDefIndex: 25681
{
	// Fields
	[Nullable(1)]
	private readonly IAppleAppReceiptViewer m_AppleAppReceiptViewer; // 0x10

	// Methods

	[NullableContext(1)]
	[Preserve]
	// RVA: 0x8559C38 Offset: 0x8555C38 VA: 0x8559C38
	internal void .ctor(IAppleAppReceiptViewer appleAppReceiptViewer) { }

	[NullableContext(2)]
	// RVA: 0x8559C68 Offset: 0x8555C68 VA: 0x8559C68 Slot: 4
	public string AppReceipt() { }
}

// Namespace: UnityEngine.Purchasing.UseCases
internal class ContinuePromotionalPurchasesUseCase : IContinuePromotionalPurchasesUseCase // TypeDefIndex: 25682
{
	// Fields
	[Nullable(1)]
	private readonly INativeAppleStore m_NativeAppleStore; // 0x10

	// Methods

	[Preserve]
	[NullableContext(1)]
	// RVA: 0x8559D08 Offset: 0x8555D08 VA: 0x8559D08
	internal void .ctor(INativeAppleStore nativeStore) { }
}

// Namespace: UnityEngine.Purchasing.UseCases
internal class PresentCodeRedemptionSheetUseCase : IPresentCodeRedemptionSheetUseCase // TypeDefIndex: 25683
{
	// Fields
	[Nullable(1)]
	private readonly INativeAppleStore m_NativeAppleStore; // 0x10

	// Methods

	[Preserve]
	[NullableContext(1)]
	// RVA: 0x8559D38 Offset: 0x8555D38 VA: 0x8559D38
	internal void .ctor(INativeAppleStore nativeStore) { }
}

// Namespace: UnityEngine.Purchasing.UseCases
internal class SetPromotionalPurchaseInterceptorCallbackUseCase : ISetPromotionalPurchaseInterceptorCallbackUseCase // TypeDefIndex: 25684
{
	// Fields
	[Nullable(1)]
	private readonly IAppleStoreCallbacks m_AppleStoreCallbacks; // 0x10

	// Methods

	[Preserve]
	[NullableContext(1)]
	// RVA: 0x8559D68 Offset: 0x8555D68 VA: 0x8559D68
	internal void .ctor(IAppleStoreCallbacks appleStoreCallbacks) { }
}

// Namespace: UnityEngine.Purchasing.UseCases
internal class SimulateAskToBuyUseCase : ISimulateAskToBuyUseCase // TypeDefIndex: 25685
{
	// Fields
	[Nullable(1)]
	private readonly IAppleStoreCallbacks m_AppleStoreCallbacks; // 0x10

	// Methods

	[Preserve]
	[NullableContext(1)]
	// RVA: 0x8559D98 Offset: 0x8555D98 VA: 0x8559D98
	internal void .ctor(IAppleStoreCallbacks appleStoreCallbacks) { }
}

// Namespace: UnityEngine.Purchasing.UseCases
internal class CanMakePaymentsUseCase : ICanMakePaymentsUseCase // TypeDefIndex: 25686
{
	// Fields
	[Nullable(1)]
	private readonly INativeAppleStore m_NativeAppleStore; // 0x10

	// Methods

	[NullableContext(1)]
	[Preserve]
	// RVA: 0x8559DC8 Offset: 0x8555DC8 VA: 0x8559DC8
	internal void .ctor(INativeAppleStore nativeStore) { }
}

// Namespace: UnityEngine.Purchasing.UseCases
internal class SetAppAccountTokenUseCase : ISetAppAccountTokenUseCase // TypeDefIndex: 25687
{
	// Fields
	[Nullable(1)]
	private readonly IAppleStoreCallbacks m_AppleStoreCallbacks; // 0x10

	// Methods

	[NullableContext(1)]
	[Preserve]
	// RVA: 0x8559DF8 Offset: 0x8555DF8 VA: 0x8559DF8
	internal void .ctor(IAppleStoreCallbacks appleStoreCallbacks) { }

	// RVA: 0x8559E28 Offset: 0x8555E28 VA: 0x8559E28 Slot: 4
	public void SetAppAccountToken(Guid token) { }
}

// Namespace: UnityEngine.Purchasing.UseCases.Interfaces
[NullableContext(1)]
internal interface IFetchStorePromotionOrderUseCase // TypeDefIndex: 25688
{}

// Namespace: UnityEngine.Purchasing.UseCases.Interfaces
[NullableContext(1)]
internal interface IFetchStorePromotionVisibilityUseCase // TypeDefIndex: 25689
{}

// Namespace: UnityEngine.Purchasing.UseCases.Interfaces
[NullableContext(1)]
internal interface IGetIntroductoryPriceDictionaryUseCase // TypeDefIndex: 25690
{}

// Namespace: UnityEngine.Purchasing.UseCases.Interfaces
[NullableContext(1)]
internal interface IGetProductDetailsUseCase // TypeDefIndex: 25691
{}

// Namespace: UnityEngine.Purchasing.UseCases.Interfaces
[NullableContext(1)]
internal interface ISetStorePromotionOrderUseCase // TypeDefIndex: 25692
{}

// Namespace: UnityEngine.Purchasing.UseCases.Interfaces
[NullableContext(1)]
internal interface ISetStorePromotionVisibilityUseCase // TypeDefIndex: 25693
{}

// Namespace: UnityEngine.Purchasing.UseCases.Interfaces
[NullableContext(2)]
internal interface IAppReceiptUseCase // TypeDefIndex: 25694
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string AppReceipt();
}

// Namespace: UnityEngine.Purchasing.UseCases.Interfaces
internal interface IContinuePromotionalPurchasesUseCase // TypeDefIndex: 25695
{}

// Namespace: UnityEngine.Purchasing.UseCases.Interfaces
internal interface IPresentCodeRedemptionSheetUseCase // TypeDefIndex: 25696
{}

// Namespace: UnityEngine.Purchasing.UseCases.Interfaces
internal interface IRefreshAppReceiptUseCase // TypeDefIndex: 25697
{}

// Namespace: UnityEngine.Purchasing.UseCases.Interfaces
[NullableContext(1)]
internal interface ISetPromotionalPurchaseInterceptorCallbackUseCase // TypeDefIndex: 25698
{}

// Namespace: UnityEngine.Purchasing.UseCases.Interfaces
internal interface ISimulateAskToBuyUseCase // TypeDefIndex: 25699
{}

// Namespace: UnityEngine.Purchasing.UseCases.Interfaces
internal class ClearAppleTransactionLogsUseCase : IClearAppleTransactionLogsUseCase // TypeDefIndex: 25700
{
	// Fields
	private readonly IAppleStoreCallbacks m_AppleStoreCallbacks; // 0x10

	// Methods

	[Preserve]
	// RVA: 0x8559EE4 Offset: 0x8555EE4 VA: 0x8559EE4
	internal void .ctor(IAppleStoreCallbacks appleStoreCallbacks) { }
}

// Namespace: UnityEngine.Purchasing.UseCases.Interfaces
internal interface ICanMakePaymentsUseCase // TypeDefIndex: 25701
{}

// Namespace: UnityEngine.Purchasing.UseCases.Interfaces
internal interface IClearAppleTransactionLogsUseCase // TypeDefIndex: 25702
{}

// Namespace: UnityEngine.Purchasing.UseCases.Interfaces
internal interface ISetAppAccountTokenUseCase // TypeDefIndex: 25703
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetAppAccountToken(Guid appAccountToken);
}

// Namespace: UnityEngine.Purchasing.Services
[Nullable(0)]
[NullableContext(1)]
internal class AppleStoreExtendedProductService : ProductService // TypeDefIndex: 25704
{
	// Fields
	private readonly IFetchStorePromotionOrderUseCase m_FetchStorePromotionOrderUseCase; // 0x38
	private readonly IFetchStorePromotionVisibilityUseCase m_FetchStorePromotionVisibilityUseCase; // 0x40
	private readonly IGetIntroductoryPriceDictionaryUseCase m_GetIntroductoryPriceDictionaryUseCase; // 0x48
	private readonly IGetProductDetailsUseCase m_GetProductDetailsUseCase; // 0x50
	private readonly ISetStorePromotionOrderUseCase m_SetStorePromotionOrderUseCase; // 0x58
	private readonly ISetStorePromotionVisibilityUseCase m_SetStorePromotionVisibilityUseCase; // 0x60

	// Methods

	[Preserve]
	// RVA: 0x8559F14 Offset: 0x8555F14 VA: 0x8559F14
	internal void .ctor(IFetchStorePromotionOrderUseCase fetchStorePromotionOrderUseCase, IFetchStorePromotionVisibilityUseCase fetchStorePromotionVisibilityUseCase, IGetIntroductoryPriceDictionaryUseCase getIntroductoryPriceDictionaryUseCase, IGetProductDetailsUseCase getProductDetailsUseCase, ISetStorePromotionOrderUseCase setStorePromotionOrderUseCase, ISetStorePromotionVisibilityUseCase setStorePromotionVisibilityUseCase, IFetchProductsUseCase fetchProductsUseCase, IStoreWrapper storeWrapper) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AppleStoreExtendedPurchaseService.<>c__DisplayClass10_0 // TypeDefIndex: 25705
{
	// Fields
	[Nullable(0)]
	public string productId; // 0x10

	// Methods

	// RVA: 0x855A7C4 Offset: 0x85567C4 VA: 0x855A7C4
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x855A914 Offset: 0x8556914 VA: 0x855A914
	internal bool <DoesOrderContainAnyRevokedProductIds>b__0(CartItem cartItem) { }
}

// Namespace: UnityEngine.Purchasing.Services
[Nullable(0)]
[NullableContext(1)]
internal class AppleStoreExtendedPurchaseService : PurchaseService, IAppleStoreExtendedPurchaseService // TypeDefIndex: 25706
{
	// Fields
	private readonly IAppReceiptUseCase m_AppReceiptUseCase; // 0x98
	private readonly IContinuePromotionalPurchasesUseCase m_ContinuePromotionalPurchasesUseCase; // 0xA0
	private readonly IPresentCodeRedemptionSheetUseCase m_PresentCodeRedemptionSheetUseCase; // 0xA8
	private readonly IRestoreTransactionsUseCase m_RestoreTransactionsUseCase; // 0xB0
	private readonly ISetPromotionalPurchaseInterceptorCallbackUseCase m_SetPromotionalPurchaseInterceptorCallbackUseCase; // 0xB8
	private readonly ISimulateAskToBuyUseCase m_SimulateAskToBuyUseCase; // 0xC0
	private readonly IOnEntitlementRevokedUseCase m_OnEntitlementRevokedUseCase; // 0xC8
	private readonly IRefreshAppReceiptUseCase m_RefreshAppReceiptUseCase; // 0xD0

	// Properties
	[Nullable(2)]
	public string appReceipt { get; }

	// Methods

	[Preserve]
	// RVA: 0x855A010 Offset: 0x8556010 VA: 0x855A010
	internal void .ctor(IAppReceiptUseCase appReceiptUseCase, IContinuePromotionalPurchasesUseCase continuePromotionalPurchasesUseCase, IPresentCodeRedemptionSheetUseCase presentCodeRedemptionSheetUseCase, IRestoreTransactionsUseCase restoreTransactionsUseCase, ISetPromotionalPurchaseInterceptorCallbackUseCase setPromotionalPurchaseInterceptorCallbackUseCase, ISimulateAskToBuyUseCase simulateAskToBuyUseCase, IFetchPurchasesUseCase fetchPurchasesUseCase, IPurchaseUseCase purchaseUseCase, IConfirmOrderUseCase confirmOrderUseCase, ICheckEntitlementUseCase checkEntitlementUseCase, IOnEntitlementRevokedUseCase onEntitlementRevokedUseCase, IStoreWrapper storeWrapper, IAnalyticsClient analyticsClient, IRefreshAppReceiptUseCase refreshAppReceiptUseCase) { }

	// RVA: 0x855A1F4 Offset: 0x85561F4 VA: 0x855A1F4
	private void OnEntitlementOnEntitlementRevokedUseCaseOnOnEntitlementRevoked(string productId) { }

	// RVA: 0x855A668 Offset: 0x8556668 VA: 0x855A668
	private static bool DoesOrderContainAnyRevokedProductIds(string productId, Order order) { }

	[NullableContext(2)]
	// RVA: 0x855A7CC Offset: 0x85567CC VA: 0x855A7CC Slot: 26
	public string get_appReceipt() { }

	[NullableContext(2)]
	// RVA: 0x855A86C Offset: 0x855686C VA: 0x855A86C Slot: 24
	protected override void RestoreTransactionsInternal(Action<bool, string> callback) { }
}

// Namespace: UnityEngine.Purchasing.Services
[Nullable(0)]
[NullableContext(1)]
internal class AppleStoreExtendedService : StoreService, IAppleStoreExtendedService // TypeDefIndex: 25707
{
	// Fields
	private readonly ICanMakePaymentsUseCase m_CanMakePaymentsUseCase; // 0x18
	private readonly IClearAppleTransactionLogsUseCase m_ClearAppleTransactionLogsUseCase; // 0x20
	private readonly ISetAppAccountTokenUseCase m_SetAppAccountTokenUseCase; // 0x28

	// Methods

	[Preserve]
	// RVA: 0x855A948 Offset: 0x8556948 VA: 0x855A948
	internal void .ctor(ICanMakePaymentsUseCase canMakePaymentsUseCase, IClearAppleTransactionLogsUseCase clearAppleTransactionLogsUseCase, ISetAppAccountTokenUseCase setAppAccountTokenUseCase, IStoreConnectUseCase connectUseCase) { }

	// RVA: 0x855A9BC Offset: 0x85569BC VA: 0x855A9BC Slot: 9
	public void SetAppAccountToken(Guid appAccountToken) { }
}

