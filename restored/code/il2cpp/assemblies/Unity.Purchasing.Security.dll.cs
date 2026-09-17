// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28281
{}

// Namespace: LipingShare.LCLib.Asn1Processor
public enum Asn1EndOfIndefiniteLengthNodeType // TypeDefIndex: 28282
{
	// Fields
	public int value__; // 0x0
	public const Asn1EndOfIndefiniteLengthNodeType EndOfStream = 0;
	public const Asn1EndOfIndefiniteLengthNodeType EndOfNodeFooter = 1;
	public const Asn1EndOfIndefiniteLengthNodeType NotEnd = 2;
}

// Namespace: LipingShare.LCLib.Asn1Processor
internal class Asn1Node // TypeDefIndex: 28283
{
	// Fields
	private byte tag; // 0x10
	private long dataOffset; // 0x18
	private long dataLength; // 0x20
	private long lengthFieldBytes; // 0x28
	private byte[] data; // 0x30
	private ArrayList childNodeList; // 0x38
	private byte unusedBits; // 0x40
	private long deepness; // 0x48
	private string path; // 0x50
	private Asn1Node parentNode; // 0x58
	private bool requireRecalculatePar; // 0x60
	private bool isIndefiniteLength; // 0x61
	private bool parseEncapsulatedData; // 0x62

	// Properties
	public bool IsIndefiniteLength { get; }
	public byte Tag { get; }
	public byte MaskedTag { get; }
	public long ChildNodeCount { get; }
	public string TagName { get; }
	public Asn1Node ParentNode { get; }
	public long DataLength { get; }
	public byte[] Data { get; }
	public long Deepness { get; }
	protected bool RequireRecalculatePar { set; }

	// Methods

	// RVA: 0x855AA74 Offset: 0x8556A74 VA: 0x855AA74
	private void .ctor(Asn1Node parentNode, long dataOffset) { }

	// RVA: 0x855AB1C Offset: 0x8556B1C VA: 0x855AB1C
	private void Init() { }

	// RVA: 0x855ABD4 Offset: 0x8556BD4 VA: 0x855ABD4
	private string GetHexPrintingStr(Asn1Node startNode, string baseLine, string lStr, int lineLen) { }

	// RVA: 0x855B1F8 Offset: 0x85571F8 VA: 0x855B1F8
	private string FormatLineString(string lStr, int indent, int lineLen, string msg) { }

	// RVA: 0x855B000 Offset: 0x8557000 VA: 0x855B000
	private string FormatLineHexString(string lStr, int indent, int lineLen, string msg) { }

	// RVA: 0x855B4EC Offset: 0x85574EC VA: 0x855B4EC
	public void .ctor() { }

	// RVA: 0x855B560 Offset: 0x8557560 VA: 0x855B560
	public bool get_IsIndefiniteLength() { }

	// RVA: 0x855B568 Offset: 0x8557568 VA: 0x855B568 Slot: 4
	public byte get_Tag() { }

	// RVA: 0x855B570 Offset: 0x8557570 VA: 0x855B570 Slot: 5
	public byte get_MaskedTag() { }

	// RVA: 0x855B57C Offset: 0x855757C VA: 0x855B57C Slot: 6
	public bool LoadData(Stream xdata) { }

	// RVA: 0x855B6F0 Offset: 0x85576F0 VA: 0x855B6F0 Slot: 7
	public bool SaveData(Stream xdata) { }

	// RVA: 0x855BA34 Offset: 0x8557A34 VA: 0x855BA34 Slot: 8
	public void ClearAll() { }

	// RVA: 0x855BB84 Offset: 0x8557B84 VA: 0x855BB84 Slot: 9
	public void AddChild(Asn1Node xdata) { }

	// RVA: 0x855BBB4 Offset: 0x8557BB4 VA: 0x855BBB4
	private Asn1Node GetLastChild() { }

	// RVA: 0x855B81C Offset: 0x855781C VA: 0x855B81C Slot: 10
	public long get_ChildNodeCount() { }

	// RVA: 0x855B978 Offset: 0x8557978 VA: 0x855B978 Slot: 11
	public Asn1Node GetChildNode(int index) { }

	// RVA: 0x855BC60 Offset: 0x8557C60 VA: 0x855BC60 Slot: 12
	public string get_TagName() { }

	// RVA: 0x855C0B4 Offset: 0x85580B4 VA: 0x855C0B4 Slot: 13
	public Asn1Node get_ParentNode() { }

	// RVA: 0x855C0BC Offset: 0x85580BC VA: 0x855C0BC Slot: 14
	public string GetText(Asn1Node startNode, int lineLen) { }

	// RVA: 0x855D6F0 Offset: 0x85596F0 VA: 0x855D6F0 Slot: 15
	public string GetDataStr(bool pureHexMode) { }

	// RVA: 0x855DA44 Offset: 0x8559A44 VA: 0x855DA44 Slot: 16
	public long get_DataLength() { }

	// RVA: 0x855DA4C Offset: 0x8559A4C VA: 0x855DA4C Slot: 17
	public byte[] get_Data() { }

	// RVA: 0x855DBD4 Offset: 0x8559BD4 VA: 0x855DBD4 Slot: 18
	public long get_Deepness() { }

	// RVA: 0x855DBDC Offset: 0x8559BDC VA: 0x855DBDC
	protected void set_RequireRecalculatePar(bool value) { }

	// RVA: 0x855BB28 Offset: 0x8557B28 VA: 0x855BB28
	protected void RecalculateTreePar() { }

	// RVA: 0x855DBE8 Offset: 0x8559BE8 VA: 0x855DBE8
	protected static long ResetBranchDataLength(Asn1Node node) { }

	// RVA: 0x855DDEC Offset: 0x8559DEC VA: 0x855DDEC
	protected static void ResetDataLengthFieldWidth(Asn1Node node) { }

	// RVA: 0x855DCB4 Offset: 0x8559CB4 VA: 0x855DCB4
	protected void ResetChildNodePar(Asn1Node xNode, long subOffset) { }

	// RVA: 0x855D5D8 Offset: 0x85595D8 VA: 0x855D5D8
	protected string GetListStr(Asn1Node startNode, int lineLen) { }

	// RVA: 0x855ADF4 Offset: 0x8556DF4 VA: 0x855ADF4
	protected string GetIndentStr(Asn1Node startNode) { }

	// RVA: 0x855DEA4 Offset: 0x8559EA4 VA: 0x855DEA4
	protected bool GeneralDecode(Stream xdata) { }

	// RVA: 0x855E0A0 Offset: 0x855A0A0 VA: 0x855E0A0
	private bool AreTagsOk() { }

	// RVA: 0x855E12C Offset: 0x855A12C VA: 0x855E12C
	private bool GeneralDecodeKnownLengthWithChecks(Stream xdata, long start, long nodeMaxLen) { }

	// RVA: 0x855E168 Offset: 0x855A168 VA: 0x855E168
	private bool IsGeneralStreamLengthOk(Stream xdata, long start, long nodeMaxLen) { }

	// RVA: 0x855E1D4 Offset: 0x855A1D4 VA: 0x855E1D4
	private bool GeneralDecodeKnownLength(Stream xdata) { }

	// RVA: 0x855E254 Offset: 0x855A254 VA: 0x855E254
	private void ReadStreamDataDefiniteLength(Stream xdata, int length) { }

	// RVA: 0x855E0D0 Offset: 0x855A0D0 VA: 0x855E0D0
	private bool GeneralDecodeIndefiniteLength(Stream xdata, long nodeMaxLen) { }

	// RVA: 0x855E2E4 Offset: 0x855A2E4 VA: 0x855E2E4
	private bool ReadStreamDataIndefiniteLength(Stream xdata, long nodeMaxLen) { }

	// RVA: 0x855E36C Offset: 0x855A36C VA: 0x855E36C
	private long MeasureContentLength(Stream xdata) { }

	// RVA: 0x855E400 Offset: 0x855A400 VA: 0x855E400
	private void ReadMeasuredLengthDataFromStart(Stream xdata, long startPosition, long length) { }

	// RVA: 0x855E4BC Offset: 0x855A4BC VA: 0x855E4BC
	protected bool ListDecode(Stream xdata) { }

	// RVA: 0x855E728 Offset: 0x855A728 VA: 0x855E728
	private bool ListDecodeKnownLengthWithChecks(Stream xdata, long start, long childNodeMaxLen) { }

	// RVA: 0x855E744 Offset: 0x855A744 VA: 0x855E744
	private bool IsListStreamLengthOk(Stream xdata, long childNodeMaxLen) { }

	// RVA: 0x855E760 Offset: 0x855A760 VA: 0x855E760
	private bool ListDecodeKnownLength(Stream xdata, long start) { }

	// RVA: 0x855E800 Offset: 0x855A800 VA: 0x855E800
	private long CalculateListEncodeFieldBytesAndOffset(Stream xdata, long start) { }

	// RVA: 0x855E84C Offset: 0x855A84C VA: 0x855E84C
	private bool HandleBitStringTag(Stream xdata, ref long offset) { }

	// RVA: 0x855E8B8 Offset: 0x855A8B8 VA: 0x855E8B8
	private bool ListDecodeKnownLengthInternal(Stream xdata, long offset) { }

	// RVA: 0x855E8E4 Offset: 0x855A8E4 VA: 0x855E8E4
	private Stream CreateAndPrepareListDecodeMemoryStreamKnownLength(Stream xdata) { }

	// RVA: 0x855EA00 Offset: 0x855AA00 VA: 0x855EA00
	private bool ListDecodeChildNodesWithKnownLength(Stream secData, long offset) { }

	// RVA: 0x855EA7C Offset: 0x855AA7C VA: 0x855EA7C
	private bool CreateAndAddChildNode(Stream secData, ref long offset) { }

	// RVA: 0x855E6A8 Offset: 0x855A6A8 VA: 0x855E6A8
	private bool ListDecodeIndefiniteLength(Stream xdata, long start, long childNodeMaxLen) { }

	// RVA: 0x855EB5C Offset: 0x855AB5C VA: 0x855EB5C
	private bool ListDecodeIndefiniteLengthInternal(Stream xdata, long offset, long childNodeMaxLen) { }

	// RVA: 0x855EBD8 Offset: 0x855ABD8 VA: 0x855EBD8
	private bool ReadNextChildNodeOrEndFooterOfIndefiniteListClearIfInvalid(Stream xdata, ref long offset, long childNodeMaxLen) { }

	// RVA: 0x855EC64 Offset: 0x855AC64 VA: 0x855EC64
	private Asn1EndOfIndefiniteLengthNodeType DetectEndOfIndefiniteListContents(Stream xdata) { }

	// RVA: 0x855ECD8 Offset: 0x855ACD8 VA: 0x855ECD8
	private bool ReadNextChildNodeOfIndefiniteListClearIfInvalid(Stream xdata, ref long offset, long childNodeMaxLen) { }

	// RVA: 0x855B620 Offset: 0x8557620 VA: 0x855B620
	protected bool InternalLoadData(Stream xdata) { }
}

// Namespace: LipingShare.LCLib.Asn1Processor
internal class Asn1Parser // TypeDefIndex: 28284
{
	// Fields
	private byte[] rawData; // 0x10
	private Asn1Node rootNode; // 0x18

	// Properties
	public Asn1Node RootNode { get; }

	// Methods

	// RVA: 0x855ED9C Offset: 0x855AD9C VA: 0x855ED9C
	public void .ctor() { }

	// RVA: 0x855EE04 Offset: 0x855AE04 VA: 0x855EE04
	public void LoadData(Stream stream) { }

	// RVA: 0x855EF38 Offset: 0x855AF38 VA: 0x855EF38
	public Asn1Node get_RootNode() { }

	// RVA: 0x855EF40 Offset: 0x855AF40 VA: 0x855EF40
	public static string GetNodeTextHeader(int lineLen) { }

	// RVA: 0x855F06C Offset: 0x855B06C VA: 0x855F06C Slot: 3
	public override string ToString() { }

	// RVA: 0x855F078 Offset: 0x855B078 VA: 0x855F078
	public static string GetNodeText(Asn1Node node, int lineLen) { }
}

// Namespace: LipingShare.LCLib.Asn1Processor
internal class Asn1Util // TypeDefIndex: 28285
{
	// Fields
	private static char[] hexDigits; // 0x0

	// Methods

	// RVA: 0x855D8B0 Offset: 0x85598B0 VA: 0x855D8B0
	public static string FormatString(string inStr, int lineLen, int groupLen) { }

	// RVA: 0x855B44C Offset: 0x855744C VA: 0x855B44C
	public static string GenStr(int len, char xch) { }

	// RVA: 0x855D580 Offset: 0x8559580 VA: 0x855D580
	public static long BytesToLong(byte[] bytes) { }

	// RVA: 0x855D488 Offset: 0x8559488 VA: 0x855D488
	public static string BytesToString(byte[] bytes) { }

	// RVA: 0x855AE94 Offset: 0x8556E94 VA: 0x855AE94
	public static string ToHexString(byte[] bytes) { }

	// RVA: 0x855F0C4 Offset: 0x855B0C4 VA: 0x855F0C4
	public static int BytePrecision(ulong value) { }

	// RVA: 0x855B848 Offset: 0x8557848 VA: 0x855B848
	public static int DERLengthEncode(Stream xdata, ulong length) { }

	// RVA: 0x855DFEC Offset: 0x8559FEC VA: 0x855DFEC
	public static long DerLengthDecode(Stream bt, ref bool isIndefiniteLength) { }

	// RVA: 0x855BCB8 Offset: 0x8557CB8 VA: 0x855BCB8
	public static string GetTagName(byte tag) { }

	// RVA: 0x855F0F0 Offset: 0x855B0F0 VA: 0x855F0F0
	private static void .cctor() { }
}

// Namespace: LipingShare.LCLib.Asn1Processor
internal class Oid // TypeDefIndex: 28286
{
	// Fields
	private static StringDictionary oidDictionary; // 0x0

	// Methods

	// RVA: 0x855D3CC Offset: 0x85593CC VA: 0x855D3CC
	public string GetOidName(string inOidStr) { }

	// RVA: 0x855F190 Offset: 0x855B190 VA: 0x855F190
	public string Decode(byte[] data) { }

	// RVA: 0x855F244 Offset: 0x855B244 VA: 0x855F244 Slot: 4
	public virtual string Decode(Stream bt) { }

	// RVA: 0x855D3C4 Offset: 0x85593C4 VA: 0x855D3C4
	public void .ctor() { }

	// RVA: 0x855F4A4 Offset: 0x855B4A4 VA: 0x855F4A4
	protected int DecodeValue(Stream bt, ref ulong v) { }
}

// Namespace: LipingShare.LCLib.Asn1Processor
internal class RelativeOid : Oid // TypeDefIndex: 28287
{
	// Methods

	// RVA: 0x855D480 Offset: 0x8559480 VA: 0x855D480
	public void .ctor() { }

	// RVA: 0x855F500 Offset: 0x855B500 VA: 0x855F500 Slot: 4
	public override string Decode(Stream bt) { }
}

// Namespace: UnityEngine.Purchasing.Security
public class AppleReceiptParser // TypeDefIndex: 28288
{
	// Fields
	private static Dictionary<string, object> _mostRecentReceiptData; // 0x0

	// Methods

	// RVA: 0x855F700 Offset: 0x855B700 VA: 0x855F700
	public AppleReceipt Parse(byte[] receiptData) { }

	// RVA: 0x855F718 Offset: 0x855B718 VA: 0x855F718
	internal AppleReceipt Parse(byte[] receiptData, out PKCS7 receipt) { }

	// RVA: 0x855FDDC Offset: 0x855BDDC VA: 0x855FDDC
	private static CultureInfo PushInvariantCultureOnThread() { }

	// RVA: 0x8560390 Offset: 0x855C390 VA: 0x8560390
	private static void PopCultureOffThread(CultureInfo originalCulture) { }

	// RVA: 0x855FEAC Offset: 0x855BEAC VA: 0x855FEAC
	private AppleReceipt ParseReceipt(Asn1Node data) { }

	// RVA: 0x85603C0 Offset: 0x855C3C0 VA: 0x85603C0
	private Asn1Node GetSetNode(Asn1Node data) { }

	// RVA: 0x856041C Offset: 0x855C41C VA: 0x856041C
	private AppleInAppPurchaseReceipt ParseInAppReceipt(Asn1Node inApp) { }

	// RVA: 0x8560848 Offset: 0x855C848 VA: 0x8560848
	private static DateTime TryParseDateTimeNode(Asn1Node node) { }

	// RVA: -1 Offset: -1
	public static bool ArrayEquals<T>(T[] a, T[] b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x476032C Offset: 0x475C32C VA: 0x476032C
	|-AppleReceiptParser.ArrayEquals<byte>
	|
	|-RVA: 0x47603F8 Offset: 0x475C3F8 VA: 0x47603F8
	|-AppleReceiptParser.ArrayEquals<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x8560930 Offset: 0x855C930 VA: 0x8560930
	public void .ctor() { }

	// RVA: 0x8560938 Offset: 0x855C938 VA: 0x8560938
	private static void .cctor() { }
}

// Namespace: UnityEngine.Purchasing.Security
internal class DistinguishedName // TypeDefIndex: 28289
{
	// Fields
	[CompilerGenerated]
	private string <Country>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Organization>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <OrganizationalUnit>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Dnq>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <State>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <CommonName>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <SerialNumber>k__BackingField; // 0x40

	// Properties
	public string Country { get; set; }
	public string Organization { get; set; }
	public string OrganizationalUnit { get; set; }
	public string Dnq { get; set; }
	public string State { get; set; }
	public string CommonName { get; set; }
	public string SerialNumber { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x85609D0 Offset: 0x855C9D0 VA: 0x85609D0
	public string get_Country() { }

	[CompilerGenerated]
	// RVA: 0x85609D8 Offset: 0x855C9D8 VA: 0x85609D8
	public void set_Country(string value) { }

	[CompilerGenerated]
	// RVA: 0x85609E0 Offset: 0x855C9E0 VA: 0x85609E0
	public string get_Organization() { }

	[CompilerGenerated]
	// RVA: 0x85609E8 Offset: 0x855C9E8 VA: 0x85609E8
	public void set_Organization(string value) { }

	[CompilerGenerated]
	// RVA: 0x85609F0 Offset: 0x855C9F0 VA: 0x85609F0
	public string get_OrganizationalUnit() { }

	[CompilerGenerated]
	// RVA: 0x85609F8 Offset: 0x855C9F8 VA: 0x85609F8
	public void set_OrganizationalUnit(string value) { }

	[CompilerGenerated]
	// RVA: 0x8560A00 Offset: 0x855CA00 VA: 0x8560A00
	public string get_Dnq() { }

	[CompilerGenerated]
	// RVA: 0x8560A08 Offset: 0x855CA08 VA: 0x8560A08
	public void set_Dnq(string value) { }

	[CompilerGenerated]
	// RVA: 0x8560A10 Offset: 0x855CA10 VA: 0x8560A10
	public string get_State() { }

	[CompilerGenerated]
	// RVA: 0x8560A18 Offset: 0x855CA18 VA: 0x8560A18
	public void set_State(string value) { }

	[CompilerGenerated]
	// RVA: 0x8560A20 Offset: 0x855CA20 VA: 0x8560A20
	public string get_CommonName() { }

	[CompilerGenerated]
	// RVA: 0x8560A28 Offset: 0x855CA28 VA: 0x8560A28
	public void set_CommonName(string value) { }

	[CompilerGenerated]
	// RVA: 0x8560A30 Offset: 0x855CA30 VA: 0x8560A30
	public void set_SerialNumber(string value) { }

	// RVA: 0x8560A38 Offset: 0x855CA38 VA: 0x8560A38
	public void .ctor(Asn1Node n) { }

	// RVA: 0x8561028 Offset: 0x855D028 VA: 0x8561028
	public bool Equals(DistinguishedName n2) { }

	// RVA: 0x85610CC Offset: 0x855D0CC VA: 0x85610CC Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.Purchasing.Security
internal class X509Cert // TypeDefIndex: 28290
{
	// Fields
	[CompilerGenerated]
	private string <SerialNumber>k__BackingField; // 0x10
	[CompilerGenerated]
	private DateTime <ValidAfter>k__BackingField; // 0x18
	[CompilerGenerated]
	private DateTime <ValidBefore>k__BackingField; // 0x20
	[CompilerGenerated]
	private RSAKey <PubKey>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <SelfSigned>k__BackingField; // 0x30
	[CompilerGenerated]
	private DistinguishedName <Subject>k__BackingField; // 0x38
	[CompilerGenerated]
	private DistinguishedName <Issuer>k__BackingField; // 0x40
	private Asn1Node TbsCertificate; // 0x48
	[CompilerGenerated]
	private Asn1Node <Signature>k__BackingField; // 0x50
	public byte[] rawTBSCertificate; // 0x58

	// Properties
	private string SerialNumber { set; }
	private DateTime ValidAfter { set; }
	private DateTime ValidBefore { set; }
	private RSAKey PubKey { set; }
	private bool SelfSigned { set; }
	public DistinguishedName Subject { get; set; }
	public DistinguishedName Issuer { get; set; }
	private Asn1Node Signature { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8561278 Offset: 0x855D278 VA: 0x8561278
	private void set_SerialNumber(string value) { }

	[CompilerGenerated]
	// RVA: 0x8561280 Offset: 0x855D280 VA: 0x8561280
	private void set_ValidAfter(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x8561288 Offset: 0x855D288 VA: 0x8561288
	private void set_ValidBefore(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x8561290 Offset: 0x855D290 VA: 0x8561290
	private void set_PubKey(RSAKey value) { }

	[CompilerGenerated]
	// RVA: 0x8561298 Offset: 0x855D298 VA: 0x8561298
	private void set_SelfSigned(bool value) { }

	[CompilerGenerated]
	// RVA: 0x85612A4 Offset: 0x855D2A4 VA: 0x85612A4
	public DistinguishedName get_Subject() { }

	[CompilerGenerated]
	// RVA: 0x85612AC Offset: 0x855D2AC VA: 0x85612AC
	private void set_Subject(DistinguishedName value) { }

	[CompilerGenerated]
	// RVA: 0x85612B4 Offset: 0x855D2B4 VA: 0x85612B4
	public DistinguishedName get_Issuer() { }

	[CompilerGenerated]
	// RVA: 0x85612BC Offset: 0x855D2BC VA: 0x85612BC
	private void set_Issuer(DistinguishedName value) { }

	[CompilerGenerated]
	// RVA: 0x85612C4 Offset: 0x855D2C4 VA: 0x85612C4
	private void set_Signature(Asn1Node value) { }

	// RVA: 0x85612CC Offset: 0x855D2CC VA: 0x85612CC
	public void .ctor(Asn1Node n) { }

	// RVA: 0x85612F8 Offset: 0x855D2F8 VA: 0x85612F8
	private void ParseNode(Asn1Node root) { }

	// RVA: 0x8561654 Offset: 0x855D654 VA: 0x8561654
	private DateTime ParseTime(Asn1Node n) { }
}

// Namespace: UnityEngine.Purchasing.Security
public class InvalidTimeFormat : IAPSecurityException // TypeDefIndex: 28291
{
	// Methods

	// RVA: 0x85618BC Offset: 0x855D8BC VA: 0x85618BC
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing.Security
public class InvalidX509Data : IAPSecurityException // TypeDefIndex: 28292
{
	// Methods

	// RVA: 0x8560FA4 Offset: 0x855CFA4 VA: 0x8560FA4
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Obfuscator.<>c__DisplayClass0_0 // TypeDefIndex: 28293
{
	// Fields
	public int key; // 0x10

	// Methods

	// RVA: 0x8561B54 Offset: 0x855DB54 VA: 0x8561B54
	public void .ctor() { }

	// RVA: 0x8561B5C Offset: 0x855DB5C VA: 0x8561B5C
	internal byte <DeObfuscate>b__0(byte x) { }
}

// Namespace: UnityEngine.Purchasing.Security
public static class Obfuscator // TypeDefIndex: 28294
{
	// Methods

	// RVA: 0x85618C4 Offset: 0x855D8C4 VA: 0x85618C4
	public static byte[] DeObfuscate(byte[] data, int[] order, int key) { }
}

// Namespace: UnityEngine.Purchasing.Security
internal class PKCS7 // TypeDefIndex: 28295
{
	// Fields
	private Asn1Node root; // 0x10
	[CompilerGenerated]
	private Asn1Node <data>k__BackingField; // 0x18
	[CompilerGenerated]
	private List<SignerInfo> <sinfos>k__BackingField; // 0x20
	[CompilerGenerated]
	private List<X509Cert> <certChain>k__BackingField; // 0x28
	private bool validStructure; // 0x30

	// Properties
	public Asn1Node data { get; set; }
	public List<SignerInfo> sinfos { get; set; }
	public List<X509Cert> certChain { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8561B68 Offset: 0x855DB68 VA: 0x8561B68
	public Asn1Node get_data() { }

	[CompilerGenerated]
	// RVA: 0x8561B70 Offset: 0x855DB70 VA: 0x8561B70
	private void set_data(Asn1Node value) { }

	[CompilerGenerated]
	// RVA: 0x8561B78 Offset: 0x855DB78 VA: 0x8561B78
	public List<SignerInfo> get_sinfos() { }

	[CompilerGenerated]
	// RVA: 0x8561B80 Offset: 0x855DB80 VA: 0x8561B80
	private void set_sinfos(List<SignerInfo> value) { }

	[CompilerGenerated]
	// RVA: 0x8561B88 Offset: 0x855DB88 VA: 0x8561B88
	public List<X509Cert> get_certChain() { }

	[CompilerGenerated]
	// RVA: 0x8561B90 Offset: 0x855DB90 VA: 0x8561B90
	private void set_certChain(List<X509Cert> value) { }

	// RVA: 0x855FE74 Offset: 0x855BE74 VA: 0x855FE74
	public void .ctor(Asn1Node node) { }

	// RVA: 0x8561B98 Offset: 0x855DB98 VA: 0x8561B98
	private void CheckStructure() { }
}

// Namespace: UnityEngine.Purchasing.Security
internal class SignerInfo // TypeDefIndex: 28296
{
	// Fields
	[CompilerGenerated]
	private int <Version>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <IssuerSerialNumber>k__BackingField; // 0x18
	[CompilerGenerated]
	private byte[] <EncryptedDigest>k__BackingField; // 0x20

	// Properties
	public int Version { get; set; }
	private string IssuerSerialNumber { set; }
	private byte[] EncryptedDigest { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x85622D4 Offset: 0x855E2D4 VA: 0x85622D4
	public int get_Version() { }

	[CompilerGenerated]
	// RVA: 0x85622DC Offset: 0x855E2DC VA: 0x85622DC
	private void set_Version(int value) { }

	[CompilerGenerated]
	// RVA: 0x85622E4 Offset: 0x855E2E4 VA: 0x85622E4
	private void set_IssuerSerialNumber(string value) { }

	[CompilerGenerated]
	// RVA: 0x85622EC Offset: 0x855E2EC VA: 0x85622EC
	private void set_EncryptedDigest(byte[] value) { }

	// RVA: 0x85620E4 Offset: 0x855E0E4 VA: 0x85620E4
	public void .ctor(Asn1Node n) { }
}

// Namespace: UnityEngine.Purchasing.Security
public class InvalidPKCS7Data : IAPSecurityException // TypeDefIndex: 28297
{
	// Methods

	// RVA: 0x85603B8 Offset: 0x855C3B8 VA: 0x85603B8
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing.Security
public class UnsupportedSignerInfoVersion : IAPSecurityException // TypeDefIndex: 28298
{
	// Methods

	// RVA: 0x85622F4 Offset: 0x855E2F4 VA: 0x85622F4
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing.Security
internal class RSAKey // TypeDefIndex: 28299
{
	// Fields
	[CompilerGenerated]
	private RSACryptoServiceProvider <rsa>k__BackingField; // 0x10

	// Properties
	private RSACryptoServiceProvider rsa { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x85622FC Offset: 0x855E2FC VA: 0x85622FC
	private void set_rsa(RSACryptoServiceProvider value) { }

	// RVA: 0x8561880 Offset: 0x855D880 VA: 0x8561880
	public void .ctor(Asn1Node n) { }

	// RVA: 0x8562304 Offset: 0x855E304 VA: 0x8562304
	private RSACryptoServiceProvider ParseNode(Asn1Node n) { }

	// RVA: 0x85625A0 Offset: 0x855E5A0 VA: 0x85625A0
	private string ToXML(string modulus, string exponent) { }
}

// Namespace: UnityEngine.Purchasing.Security
public class InvalidRSAData : IAPSecurityException // TypeDefIndex: 28300
{
	// Methods

	// RVA: 0x85626E4 Offset: 0x855E6E4 VA: 0x85626E4
	public void .ctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 // TypeDefIndex: 28301
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 28302
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 2EF83B43314F8CD03190EEE30ECCF048DA37791237F27C62A579F23EACE9FD70 /*Metadata offset 0xF53998*/; // 0x0

	// Methods

	// RVA: 0x8560FAC Offset: 0x855CFAC VA: 0x8560FAC
	internal static uint ComputeStringHash(string s) { }
}

