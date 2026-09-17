// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28938
{}

// Namespace: UnityEngine.Purchasing.Security
public class AppleReceipt // TypeDefIndex: 28939
{
	// Fields
	[CompilerGenerated]
	private string <bundleID>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <appVersion>k__BackingField; // 0x18
	[CompilerGenerated]
	private byte[] <opaque>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte[] <hash>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <originalApplicationVersion>k__BackingField; // 0x30
	[CompilerGenerated]
	private DateTime <receiptCreationDate>k__BackingField; // 0x38
	public AppleInAppPurchaseReceipt[] inAppPurchaseReceipts; // 0x40

	// Properties
	internal string bundleID { set; }
	internal string appVersion { set; }
	internal byte[] opaque { set; }
	internal byte[] hash { set; }
	internal string originalApplicationVersion { set; }
	internal DateTime receiptCreationDate { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x85626EC Offset: 0x855E6EC VA: 0x85626EC
	internal void set_bundleID(string value) { }

	[CompilerGenerated]
	// RVA: 0x85626F4 Offset: 0x855E6F4 VA: 0x85626F4
	internal void set_appVersion(string value) { }

	[CompilerGenerated]
	// RVA: 0x85626FC Offset: 0x855E6FC VA: 0x85626FC
	internal void set_opaque(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x8562704 Offset: 0x855E704 VA: 0x8562704
	internal void set_hash(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x856270C Offset: 0x855E70C VA: 0x856270C
	internal void set_originalApplicationVersion(string value) { }

	[CompilerGenerated]
	// RVA: 0x8562714 Offset: 0x855E714 VA: 0x8562714
	internal void set_receiptCreationDate(DateTime value) { }

	// RVA: 0x856271C Offset: 0x855E71C VA: 0x856271C
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing.Security
public class AppleInAppPurchaseReceipt // TypeDefIndex: 28940
{
	// Fields
	[CompilerGenerated]
	private int <quantity>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <productID>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <transactionID>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <originalTransactionIdentifier>k__BackingField; // 0x28
	[CompilerGenerated]
	private DateTime <purchaseDate>k__BackingField; // 0x30
	[CompilerGenerated]
	private DateTime <originalPurchaseDate>k__BackingField; // 0x38
	[CompilerGenerated]
	private DateTime <subscriptionExpirationDate>k__BackingField; // 0x40
	[CompilerGenerated]
	private DateTime <cancellationDate>k__BackingField; // 0x48
	[CompilerGenerated]
	private int <isFreeTrial>k__BackingField; // 0x50
	[CompilerGenerated]
	private int <productType>k__BackingField; // 0x54
	[CompilerGenerated]
	private int <isIntroductoryPricePeriod>k__BackingField; // 0x58

	// Properties
	internal int quantity { set; }
	public string productID { get; set; }
	internal string transactionID { set; }
	internal string originalTransactionIdentifier { set; }
	public DateTime purchaseDate { get; set; }
	internal DateTime originalPurchaseDate { set; }
	public DateTime subscriptionExpirationDate { get; set; }
	public DateTime cancellationDate { get; set; }
	public int isFreeTrial { get; set; }
	public int productType { get; set; }
	public int isIntroductoryPricePeriod { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8562724 Offset: 0x855E724 VA: 0x8562724
	internal void set_quantity(int value) { }

	[CompilerGenerated]
	// RVA: 0x856272C Offset: 0x855E72C VA: 0x856272C Slot: 4
	public string get_productID() { }

	[CompilerGenerated]
	// RVA: 0x8562734 Offset: 0x855E734 VA: 0x8562734
	internal void set_productID(string value) { }

	[CompilerGenerated]
	// RVA: 0x856273C Offset: 0x855E73C VA: 0x856273C
	internal void set_transactionID(string value) { }

	[CompilerGenerated]
	// RVA: 0x8562744 Offset: 0x855E744 VA: 0x8562744
	internal void set_originalTransactionIdentifier(string value) { }

	[CompilerGenerated]
	// RVA: 0x856274C Offset: 0x855E74C VA: 0x856274C Slot: 5
	public DateTime get_purchaseDate() { }

	[CompilerGenerated]
	// RVA: 0x8562754 Offset: 0x855E754 VA: 0x8562754
	internal void set_purchaseDate(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x856275C Offset: 0x855E75C VA: 0x856275C
	internal void set_originalPurchaseDate(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x8562764 Offset: 0x855E764 VA: 0x8562764
	public DateTime get_subscriptionExpirationDate() { }

	[CompilerGenerated]
	// RVA: 0x856276C Offset: 0x855E76C VA: 0x856276C
	internal void set_subscriptionExpirationDate(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x8562774 Offset: 0x855E774 VA: 0x8562774
	public DateTime get_cancellationDate() { }

	[CompilerGenerated]
	// RVA: 0x856277C Offset: 0x855E77C VA: 0x856277C
	internal void set_cancellationDate(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x8562784 Offset: 0x855E784 VA: 0x8562784
	public int get_isFreeTrial() { }

	[CompilerGenerated]
	// RVA: 0x856278C Offset: 0x855E78C VA: 0x856278C
	internal void set_isFreeTrial(int value) { }

	[CompilerGenerated]
	// RVA: 0x8562794 Offset: 0x855E794 VA: 0x8562794
	public int get_productType() { }

	[CompilerGenerated]
	// RVA: 0x856279C Offset: 0x855E79C VA: 0x856279C
	internal void set_productType(int value) { }

	[CompilerGenerated]
	// RVA: 0x85627A4 Offset: 0x855E7A4 VA: 0x85627A4
	public int get_isIntroductoryPricePeriod() { }

	[CompilerGenerated]
	// RVA: 0x85627AC Offset: 0x855E7AC VA: 0x85627AC
	internal void set_isIntroductoryPricePeriod(int value) { }

	// RVA: 0x85627B4 Offset: 0x855E7B4 VA: 0x85627B4
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing.Security
public class IAPSecurityException : Exception // TypeDefIndex: 28941
{
	// Methods

	// RVA: 0x85627BC Offset: 0x855E7BC VA: 0x85627BC
	public void .ctor() { }
}

