// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 25708
{}

// Namespace: 
internal sealed class Locale // TypeDefIndex: 25709
{
	// Methods

	// RVA: 0x79985AC Offset: 0x79945AC VA: 0x79985AC
	public static string GetText(string msg) { }

	// RVA: 0x79985B0 Offset: 0x79945B0 VA: 0x79985B0
	public static string GetText(string fmt, object[] args) { }
}

// Namespace: Mono.Security
[DefaultMember("Item")]
public class ASN1 // TypeDefIndex: 25710
{
	// Fields
	private byte m_nTag; // 0x10
	private byte[] m_aValue; // 0x18
	private ArrayList elist; // 0x20

	// Properties
	public int Count { get; }
	public byte Tag { get; }
	public int Length { get; }
	public byte[] Value { get; set; }
	public ASN1 Item { get; }

	// Methods

	// RVA: 0x79985B8 Offset: 0x79945B8 VA: 0x79985B8
	public void .ctor(byte tag) { }

	// RVA: 0x79985EC Offset: 0x79945EC VA: 0x79985EC
	public void .ctor(byte tag, byte[] data) { }

	// RVA: 0x7998624 Offset: 0x7994624 VA: 0x7998624
	public void .ctor(byte[] data) { }

	// RVA: 0x79988C8 Offset: 0x79948C8 VA: 0x79988C8
	public int get_Count() { }

	// RVA: 0x79988E4 Offset: 0x79948E4 VA: 0x79988E4
	public byte get_Tag() { }

	// RVA: 0x79988EC Offset: 0x79948EC VA: 0x79988EC
	public int get_Length() { }

	// RVA: 0x7998904 Offset: 0x7994904 VA: 0x7998904
	public byte[] get_Value() { }

	// RVA: 0x7998994 Offset: 0x7994994 VA: 0x7998994
	public void set_Value(byte[] value) { }

	// RVA: 0x7998A50 Offset: 0x7994A50 VA: 0x7998A50
	private bool CompareArray(byte[] array1, byte[] array2) { }

	// RVA: 0x7998AD8 Offset: 0x7994AD8 VA: 0x7998AD8
	public bool CompareValue(byte[] value) { }

	// RVA: 0x7998AE8 Offset: 0x7994AE8 VA: 0x7998AE8
	public ASN1 Add(ASN1 asn1) { }

	// RVA: 0x7998B80 Offset: 0x7994B80 VA: 0x7998B80 Slot: 4
	public virtual byte[] GetBytes() { }

	// RVA: 0x79987A0 Offset: 0x79947A0 VA: 0x79987A0
	protected void Decode(byte[] asn1, ref int anPos, int anLength) { }

	// RVA: 0x7999210 Offset: 0x7995210 VA: 0x7999210
	protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) { }

	// RVA: 0x7999340 Offset: 0x7995340 VA: 0x7999340
	public ASN1 get_Item(int index) { }

	// RVA: 0x7999470 Offset: 0x7995470 VA: 0x7999470
	public ASN1 Element(int index, byte anTag) { }

	// RVA: 0x79995C4 Offset: 0x79955C4 VA: 0x79995C4 Slot: 3
	public override string ToString() { }
}

// Namespace: Mono.Security
public static class ASN1Convert // TypeDefIndex: 25711
{
	// Methods

	// RVA: 0x7999858 Offset: 0x7995858 VA: 0x7999858
	public static ASN1 FromInt32(int value) { }

	// RVA: 0x79999E8 Offset: 0x79959E8 VA: 0x79999E8
	public static ASN1 FromOid(string oid) { }

	// RVA: 0x7999AC4 Offset: 0x7995AC4 VA: 0x7999AC4
	public static ASN1 FromUnsignedBigInteger(byte[] big) { }

	// RVA: 0x7999BE0 Offset: 0x7995BE0 VA: 0x7999BE0
	public static int ToInt32(ASN1 asn1) { }

	// RVA: 0x7999CF0 Offset: 0x7995CF0 VA: 0x7999CF0
	public static string ToOid(ASN1 asn1) { }

	// RVA: 0x7999F78 Offset: 0x7995F78 VA: 0x7999F78
	public static DateTime ToDateTime(ASN1 time) { }
}

// Namespace: Mono.Security
internal sealed class BitConverterLE // TypeDefIndex: 25712
{
	// Methods

	// RVA: 0x799A53C Offset: 0x799653C VA: 0x799A53C
	private static byte[] GetUIntBytes(byte* bytes) { }

	// RVA: 0x799A5D4 Offset: 0x79965D4 VA: 0x799A5D4
	private static byte[] GetULongBytes(byte* bytes) { }

	// RVA: 0x79999D0 Offset: 0x79959D0 VA: 0x79999D0
	internal static byte[] GetBytes(int value) { }

	// RVA: 0x799A6AC Offset: 0x79966AC VA: 0x799A6AC
	internal static byte[] GetBytes(long value) { }

	// RVA: 0x799A6C4 Offset: 0x79966C4 VA: 0x799A6C4
	private static void UShortFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x799A710 Offset: 0x7996710 VA: 0x799A710
	private static void UIntFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x799A794 Offset: 0x7996794 VA: 0x799A794
	internal static int ToInt32(byte[] value, int startIndex) { }

	// RVA: 0x799A7B8 Offset: 0x79967B8 VA: 0x799A7B8
	internal static ushort ToUInt16(byte[] value, int startIndex) { }

	// RVA: 0x799A7DC Offset: 0x79967DC VA: 0x799A7DC
	internal static uint ToUInt32(byte[] value, int startIndex) { }
}

// Namespace: 
public class PKCS7.ContentInfo // TypeDefIndex: 25713
{
	// Fields
	private string contentType; // 0x10
	private ASN1 content; // 0x18

	// Properties
	public ASN1 ASN1 { get; }
	public ASN1 Content { get; set; }
	public string ContentType { get; set; }

	// Methods

	// RVA: 0x799A800 Offset: 0x7996800 VA: 0x799A800
	public void .ctor() { }

	// RVA: 0x799A884 Offset: 0x7996884 VA: 0x799A884
	public void .ctor(string oid) { }

	// RVA: 0x799A8B0 Offset: 0x79968B0 VA: 0x799A8B0
	public void .ctor(byte[] data) { }

	// RVA: 0x799A918 Offset: 0x7996918 VA: 0x799A918
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x799AAB4 Offset: 0x7996AB4 VA: 0x799AAB4
	public ASN1 get_ASN1() { }

	// RVA: 0x799AB70 Offset: 0x7996B70 VA: 0x799AB70
	public ASN1 get_Content() { }

	// RVA: 0x799AB78 Offset: 0x7996B78 VA: 0x799AB78
	public void set_Content(ASN1 value) { }

	// RVA: 0x799AB80 Offset: 0x7996B80 VA: 0x799AB80
	public string get_ContentType() { }

	// RVA: 0x799AB88 Offset: 0x7996B88 VA: 0x799AB88
	public void set_ContentType(string value) { }

	// RVA: 0x799AAB8 Offset: 0x7996AB8 VA: 0x799AAB8
	internal ASN1 GetASN1() { }
}

// Namespace: 
public class PKCS7.EncryptedData // TypeDefIndex: 25714
{
	// Fields
	private byte _version; // 0x10
	private PKCS7.ContentInfo _content; // 0x18
	private PKCS7.ContentInfo _encryptionAlgorithm; // 0x20
	private byte[] _encrypted; // 0x28

	// Properties
	public PKCS7.ContentInfo EncryptionAlgorithm { get; }
	public byte[] EncryptedContent { get; }

	// Methods

	// RVA: 0x799AB90 Offset: 0x7996B90 VA: 0x799AB90
	public void .ctor() { }

	// RVA: 0x799ABAC Offset: 0x7996BAC VA: 0x799ABAC
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x799AEB4 Offset: 0x7996EB4 VA: 0x799AEB4
	public PKCS7.ContentInfo get_EncryptionAlgorithm() { }

	// RVA: 0x799AEBC Offset: 0x7996EBC VA: 0x799AEBC
	public byte[] get_EncryptedContent() { }
}

// Namespace: 
public class PKCS7.SignedData // TypeDefIndex: 25715
{
	// Fields
	private byte version; // 0x10
	private string hashAlgorithm; // 0x18
	private PKCS7.ContentInfo contentInfo; // 0x20
	private X509CertificateCollection certs; // 0x28
	private ArrayList crls; // 0x30
	private PKCS7.SignerInfo signerInfo; // 0x38
	private bool mda; // 0x40

	// Properties
	public X509CertificateCollection Certificates { get; }
	public PKCS7.ContentInfo ContentInfo { get; }
	public string HashName { set; }
	public PKCS7.SignerInfo SignerInfo { get; }

	// Methods

	// RVA: 0x799AF30 Offset: 0x7996F30 VA: 0x799AF30
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x799BC74 Offset: 0x7997C74 VA: 0x799BC74
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x799BC7C Offset: 0x7997C7C VA: 0x799BC7C
	public PKCS7.ContentInfo get_ContentInfo() { }

	// RVA: 0x799BC38 Offset: 0x7997C38 VA: 0x799BC38
	public void set_HashName(string value) { }

	// RVA: 0x799BC84 Offset: 0x7997C84 VA: 0x799BC84
	public PKCS7.SignerInfo get_SignerInfo() { }

	// RVA: 0x799BA84 Offset: 0x7997A84 VA: 0x799BA84
	internal string OidToName(string oid) { }
}

// Namespace: 
public class PKCS7.SignerInfo // TypeDefIndex: 25716
{
	// Fields
	private byte version; // 0x10
	private string hashAlgorithm; // 0x18
	private ArrayList authenticatedAttributes; // 0x20
	private ArrayList unauthenticatedAttributes; // 0x28
	private byte[] signature; // 0x30
	private string issuer; // 0x38
	private byte[] serial; // 0x40
	private byte[] ski; // 0x48

	// Properties
	public string IssuerName { get; }
	public byte[] SerialNumber { get; }
	public ArrayList AuthenticatedAttributes { get; }
	public string HashName { get; set; }
	public byte[] Signature { get; }
	public ArrayList UnauthenticatedAttributes { get; }
	public byte Version { get; }

	// Methods

	// RVA: 0x799B9EC Offset: 0x79979EC VA: 0x799B9EC
	public void .ctor() { }

	// RVA: 0x799B644 Offset: 0x7997644 VA: 0x799B644
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x799BDC8 Offset: 0x7997DC8 VA: 0x799BDC8
	public string get_IssuerName() { }

	// RVA: 0x799BDD0 Offset: 0x7997DD0 VA: 0x799BDD0
	public byte[] get_SerialNumber() { }

	// RVA: 0x799BE44 Offset: 0x7997E44 VA: 0x799BE44
	public ArrayList get_AuthenticatedAttributes() { }

	// RVA: 0x799BE4C Offset: 0x7997E4C VA: 0x799BE4C
	public string get_HashName() { }

	// RVA: 0x799BE54 Offset: 0x7997E54 VA: 0x799BE54
	public void set_HashName(string value) { }

	// RVA: 0x799BE5C Offset: 0x7997E5C VA: 0x799BE5C
	public byte[] get_Signature() { }

	// RVA: 0x799BED0 Offset: 0x7997ED0 VA: 0x799BED0
	public ArrayList get_UnauthenticatedAttributes() { }

	// RVA: 0x799BED8 Offset: 0x7997ED8 VA: 0x799BED8
	public byte get_Version() { }
}

// Namespace: Mono.Security
public sealed class PKCS7 // TypeDefIndex: 25717
{}

// Namespace: Mono.Security.X509
internal class SafeBag // TypeDefIndex: 25718
{
	// Fields
	private string _bagOID; // 0x10
	private ASN1 _asn1; // 0x18

	// Properties
	public string BagOID { get; }
	public ASN1 ASN1 { get; }

	// Methods

	// RVA: 0x799BEE0 Offset: 0x7997EE0 VA: 0x799BEE0
	public void .ctor(string bagOID, ASN1 asn1) { }

	// RVA: 0x799BF24 Offset: 0x7997F24 VA: 0x799BF24
	public string get_BagOID() { }

	// RVA: 0x799BF2C Offset: 0x7997F2C VA: 0x799BF2C
	public ASN1 get_ASN1() { }
}

// Namespace: 
public class PKCS12.DeriveBytes // TypeDefIndex: 25719
{
	// Fields
	private static byte[] keyDiversifier; // 0x0
	private static byte[] ivDiversifier; // 0x8
	private static byte[] macDiversifier; // 0x10
	private string _hashName; // 0x10
	private int _iterations; // 0x18
	private byte[] _password; // 0x20
	private byte[] _salt; // 0x28

	// Properties
	public string HashName { set; }
	public int IterationCount { set; }
	public byte[] Password { set; }
	public byte[] Salt { set; }

	// Methods

	// RVA: 0x799E5FC Offset: 0x799A5FC VA: 0x799E5FC
	public void .ctor() { }

	// RVA: 0x79A3060 Offset: 0x799F060 VA: 0x79A3060
	public void set_HashName(string value) { }

	// RVA: 0x79A3068 Offset: 0x799F068 VA: 0x79A3068
	public void set_IterationCount(int value) { }

	// RVA: 0x799E604 Offset: 0x799A604 VA: 0x799E604
	public void set_Password(byte[] value) { }

	// RVA: 0x799E6C8 Offset: 0x799A6C8 VA: 0x799E6C8
	public void set_Salt(byte[] value) { }

	// RVA: 0x79A3070 Offset: 0x799F070 VA: 0x79A3070
	private void Adjust(byte[] a, int aOff, byte[] b) { }

	// RVA: 0x79A3130 Offset: 0x799F130 VA: 0x79A3130
	private byte[] Derive(byte[] diversifier, int n) { }

	// RVA: 0x799E784 Offset: 0x799A784 VA: 0x799E784
	public byte[] DeriveKey(int size) { }

	// RVA: 0x799E7F4 Offset: 0x799A7F4 VA: 0x799E7F4
	public byte[] DeriveIV(int size) { }

	// RVA: 0x79A00C8 Offset: 0x799C0C8 VA: 0x79A00C8
	public byte[] DeriveMAC(int size) { }

	// RVA: 0x79A3560 Offset: 0x799F560 VA: 0x79A3560
	private static void .cctor() { }
}

// Namespace: Mono.Security.X509
public class PKCS12 : ICloneable // TypeDefIndex: 25720
{
	// Fields
	private byte[] _password; // 0x10
	private ArrayList _keyBags; // 0x18
	private ArrayList _secretBags; // 0x20
	private X509CertificateCollection _certs; // 0x28
	private bool _keyBagsChanged; // 0x30
	private bool _secretBagsChanged; // 0x31
	private bool _certsChanged; // 0x32
	private int _iterations; // 0x34
	private ArrayList _safeBags; // 0x38
	private RandomNumberGenerator _rng; // 0x40
	private static int password_max_length; // 0x0

	// Properties
	public string Password { set; }
	public int IterationCount { get; set; }
	public ArrayList Keys { get; }
	public X509CertificateCollection Certificates { get; }
	internal RandomNumberGenerator RNG { get; }
	public static int MaximumPasswordLength { get; }

	// Methods

	// RVA: 0x799BF34 Offset: 0x7997F34 VA: 0x799BF34
	public void .ctor() { }

	// RVA: 0x799C038 Offset: 0x7998038 VA: 0x799C038
	public void .ctor(byte[] data) { }

	// RVA: 0x799C8F0 Offset: 0x79988F0 VA: 0x799C8F0
	public void .ctor(byte[] data, string password) { }

	// RVA: 0x799C25C Offset: 0x799825C VA: 0x799C25C
	private void Decode(byte[] data) { }

	// RVA: 0x799D268 Offset: 0x7999268 VA: 0x799D268 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x799C06C Offset: 0x799806C VA: 0x799C06C
	public void set_Password(string value) { }

	// RVA: 0x799D328 Offset: 0x7999328 VA: 0x799D328
	public int get_IterationCount() { }

	// RVA: 0x799D330 Offset: 0x7999330 VA: 0x799D330
	public void set_IterationCount(int value) { }

	// RVA: 0x799D338 Offset: 0x7999338 VA: 0x799D338
	public ArrayList get_Keys() { }

	// RVA: 0x799DBEC Offset: 0x7999BEC VA: 0x799DBEC
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x799E02C Offset: 0x799A02C VA: 0x799E02C
	internal RandomNumberGenerator get_RNG() { }

	// RVA: 0x799CA84 Offset: 0x7998A84 VA: 0x799CA84
	private bool Compare(byte[] expected, byte[] actual) { }

	// RVA: 0x799E05C Offset: 0x799A05C VA: 0x799E05C
	private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount) { }

	// RVA: 0x799DA3C Offset: 0x7999A3C VA: 0x799DA3C
	public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData) { }

	// RVA: 0x799D1D8 Offset: 0x79991D8 VA: 0x799D1D8
	public byte[] Decrypt(PKCS7.EncryptedData ed) { }

	// RVA: 0x799E864 Offset: 0x799A864 VA: 0x799E864
	public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data) { }

	// RVA: 0x799EAB4 Offset: 0x799AAB4 VA: 0x799EAB4
	private DSAParameters GetExistingParameters(out bool found) { }

	// RVA: 0x799F210 Offset: 0x799B210 VA: 0x799F210
	private void AddPrivateKey(PKCS8.PrivateKeyInfo pki) { }

	// RVA: 0x799CB0C Offset: 0x7998B0C VA: 0x799CB0C
	private void ReadSafeBag(ASN1 safeBag) { }

	// RVA: 0x799F46C Offset: 0x799B46C VA: 0x799F46C
	private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes) { }

	// RVA: 0x799C928 Offset: 0x7998928 VA: 0x799C928
	private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data) { }

	// RVA: 0x79A0138 Offset: 0x799C138 VA: 0x79A0138
	public byte[] GetBytes() { }

	// RVA: 0x79A2450 Offset: 0x799E450 VA: 0x79A2450
	private PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) { }

	// RVA: 0x79A2448 Offset: 0x799E448 VA: 0x79A2448
	public void AddCertificate(X509Certificate cert) { }

	// RVA: 0x79A27A0 Offset: 0x799E7A0 VA: 0x79A27A0
	public void AddCertificate(X509Certificate cert, IDictionary attributes) { }

	// RVA: 0x79A2440 Offset: 0x799E440 VA: 0x79A2440
	public void RemoveCertificate(X509Certificate cert) { }

	// RVA: 0x79A29E8 Offset: 0x799E9E8 VA: 0x79A29E8
	public void RemoveCertificate(X509Certificate cert, IDictionary attrs) { }

	// RVA: 0x79A2EF4 Offset: 0x799EEF4 VA: 0x79A2EF4 Slot: 4
	public object Clone() { }

	// RVA: 0x79A2FBC Offset: 0x799EFBC VA: 0x79A2FBC
	public static int get_MaximumPasswordLength() { }

	// RVA: 0x79A3014 Offset: 0x799F014 VA: 0x79A3014
	private static void .cctor() { }
}

// Namespace: Mono.Security.X509
public sealed class X501 // TypeDefIndex: 25721
{
	// Fields
	private static byte[] countryName; // 0x0
	private static byte[] organizationName; // 0x8
	private static byte[] organizationalUnitName; // 0x10
	private static byte[] commonName; // 0x18
	private static byte[] localityName; // 0x20
	private static byte[] stateOrProvinceName; // 0x28
	private static byte[] streetAddress; // 0x30
	private static byte[] serialNumber; // 0x38
	private static byte[] domainComponent; // 0x40
	private static byte[] userid; // 0x48
	private static byte[] email; // 0x50
	private static byte[] dnQualifier; // 0x58
	private static byte[] title; // 0x60
	private static byte[] surname; // 0x68
	private static byte[] givenName; // 0x70
	private static byte[] initial; // 0x78

	// Methods

	// RVA: 0x799BC8C Offset: 0x7997C8C VA: 0x799BC8C
	public static string ToString(ASN1 seq) { }

	// RVA: 0x79A3E58 Offset: 0x799FE58 VA: 0x79A3E58
	public static string ToString(ASN1 seq, bool reversed, string separator, bool quotes) { }

	// RVA: 0x79A3690 Offset: 0x799F690 VA: 0x79A3690
	private static void AppendEntry(StringBuilder sb, ASN1 entry, bool quotes) { }

	// RVA: 0x79A4018 Offset: 0x79A0018 VA: 0x79A4018
	private static void .cctor() { }
}

// Namespace: 
public class X509Crl.X509CrlEntry // TypeDefIndex: 25722
{
	// Fields
	private byte[] sn; // 0x10
	private DateTime revocationDate; // 0x18
	private X509ExtensionCollection extensions; // 0x20

	// Properties
	public byte[] SerialNumber { get; }
	public DateTime RevocationDate { get; }
	public X509ExtensionCollection Extensions { get; }

	// Methods

	// RVA: 0x79A4CA0 Offset: 0x79A0CA0 VA: 0x79A4CA0
	internal void .ctor(ASN1 entry) { }

	// RVA: 0x79A5354 Offset: 0x79A1354 VA: 0x79A5354
	public byte[] get_SerialNumber() { }

	// RVA: 0x79A58D8 Offset: 0x79A18D8 VA: 0x79A58D8
	public DateTime get_RevocationDate() { }

	// RVA: 0x79A58E0 Offset: 0x79A18E0 VA: 0x79A58E0
	public X509ExtensionCollection get_Extensions() { }
}

// Namespace: Mono.Security.X509
[DefaultMember("Item")]
public class X509Crl // TypeDefIndex: 25723
{
	// Fields
	private string issuer; // 0x10
	private byte version; // 0x18
	private DateTime thisUpdate; // 0x20
	private DateTime nextUpdate; // 0x28
	private ArrayList entries; // 0x30
	private string signatureOID; // 0x38
	private byte[] signature; // 0x40
	private X509ExtensionCollection extensions; // 0x48
	private byte[] encoded; // 0x50
	private byte[] hash_value; // 0x58

	// Properties
	public X509ExtensionCollection Extensions { get; }
	public byte[] Hash { get; }
	public string IssuerName { get; }
	public DateTime NextUpdate { get; }

	// Methods

	// RVA: 0x79A44CC Offset: 0x79A04CC VA: 0x79A44CC
	public void .ctor(byte[] crl) { }

	// RVA: 0x79A45E8 Offset: 0x79A05E8 VA: 0x79A45E8
	private void Parse(byte[] crl) { }

	// RVA: 0x79A4EC4 Offset: 0x79A0EC4 VA: 0x79A4EC4
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x79A4ECC Offset: 0x79A0ECC VA: 0x79A4ECC
	public byte[] get_Hash() { }

	// RVA: 0x79A50F4 Offset: 0x79A10F4 VA: 0x79A50F4
	public string get_IssuerName() { }

	// RVA: 0x79A50FC Offset: 0x79A10FC VA: 0x79A50FC
	public DateTime get_NextUpdate() { }

	// RVA: 0x79A5104 Offset: 0x79A1104 VA: 0x79A5104
	private bool Compare(byte[] array1, byte[] array2) { }

	// RVA: 0x79A5194 Offset: 0x79A1194 VA: 0x79A5194
	public X509Crl.X509CrlEntry GetCrlEntry(X509Certificate x509) { }

	// RVA: 0x79A5210 Offset: 0x79A1210 VA: 0x79A5210
	public X509Crl.X509CrlEntry GetCrlEntry(byte[] serialNumber) { }

	// RVA: 0x79A53CC Offset: 0x79A13CC VA: 0x79A53CC
	internal bool VerifySignature(DSA dsa) { }

	// RVA: 0x79A5690 Offset: 0x79A1690 VA: 0x79A5690
	internal bool VerifySignature(RSA rsa) { }

	// RVA: 0x79A5764 Offset: 0x79A1764 VA: 0x79A5764
	public bool VerifySignature(AsymmetricAlgorithm aa) { }
}

// Namespace: Mono.Security.X509
public class X509Certificate : ISerializable // TypeDefIndex: 25724
{
	// Fields
	private ASN1 decoder; // 0x10
	private byte[] m_encodedcert; // 0x18
	private DateTime m_from; // 0x20
	private DateTime m_until; // 0x28
	private ASN1 issuer; // 0x30
	private string m_issuername; // 0x38
	private string m_keyalgo; // 0x40
	private byte[] m_keyalgoparams; // 0x48
	private ASN1 subject; // 0x50
	private string m_subject; // 0x58
	private byte[] m_publickey; // 0x60
	private byte[] signature; // 0x68
	private string m_signaturealgo; // 0x70
	private byte[] m_signaturealgoparams; // 0x78
	private byte[] certhash; // 0x80
	private RSA _rsa; // 0x88
	private DSA _dsa; // 0x90
	private int version; // 0x98
	private byte[] serialnumber; // 0xA0
	private byte[] issuerUniqueID; // 0xA8
	private byte[] subjectUniqueID; // 0xB0
	private X509ExtensionCollection extensions; // 0xB8
	private static string encoding_error; // 0x0

	// Properties
	public DSA DSA { get; set; }
	public X509ExtensionCollection Extensions { get; }
	public byte[] Hash { get; }
	public virtual string IssuerName { get; }
	public virtual string KeyAlgorithm { get; }
	public virtual byte[] KeyAlgorithmParameters { get; set; }
	public virtual byte[] PublicKey { get; }
	public virtual RSA RSA { get; set; }
	public virtual byte[] RawData { get; }
	public virtual byte[] SerialNumber { get; }
	public virtual byte[] Signature { get; }
	public virtual string SubjectName { get; }
	public virtual DateTime ValidFrom { get; }
	public virtual DateTime ValidUntil { get; }
	public int Version { get; }
	public bool IsCurrent { get; }
	public bool IsSelfSigned { get; }

	// Methods

	// RVA: 0x79A58E8 Offset: 0x79A18E8 VA: 0x79A58E8
	private void Parse(byte[] data) { }

	// RVA: 0x799B448 Offset: 0x7997448 VA: 0x799B448
	public void .ctor(byte[] data) { }

	// RVA: 0x79A63F4 Offset: 0x79A23F4 VA: 0x79A63F4
	private byte[] GetUnsignedBigInteger(byte[] integer) { }

	// RVA: 0x799EE88 Offset: 0x799AE88 VA: 0x799EE88
	public DSA get_DSA() { }

	// RVA: 0x79A6488 Offset: 0x79A2488 VA: 0x79A6488
	public void set_DSA(DSA value) { }

	// RVA: 0x79A64C8 Offset: 0x79A24C8 VA: 0x79A64C8
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x79A64D0 Offset: 0x79A24D0 VA: 0x79A64D0
	public byte[] get_Hash() { }

	// RVA: 0x79A6778 Offset: 0x79A2778 VA: 0x79A6778 Slot: 5
	public virtual string get_IssuerName() { }

	// RVA: 0x79A6780 Offset: 0x79A2780 VA: 0x79A6780 Slot: 6
	public virtual string get_KeyAlgorithm() { }

	// RVA: 0x79A6788 Offset: 0x79A2788 VA: 0x79A6788 Slot: 7
	public virtual byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0x79A67FC Offset: 0x79A27FC VA: 0x79A67FC Slot: 8
	public virtual void set_KeyAlgorithmParameters(byte[] value) { }

	// RVA: 0x79A6804 Offset: 0x79A2804 VA: 0x79A6804 Slot: 9
	public virtual byte[] get_PublicKey() { }

	// RVA: 0x79A6878 Offset: 0x79A2878 VA: 0x79A6878 Slot: 10
	public virtual RSA get_RSA() { }

	// RVA: 0x79A6A30 Offset: 0x79A2A30 VA: 0x79A6A30 Slot: 11
	public virtual void set_RSA(RSA value) { }

	// RVA: 0x79A6A6C Offset: 0x79A2A6C VA: 0x79A6A6C Slot: 12
	public virtual byte[] get_RawData() { }

	// RVA: 0x79A6AE0 Offset: 0x79A2AE0 VA: 0x79A6AE0 Slot: 13
	public virtual byte[] get_SerialNumber() { }

	// RVA: 0x79A6B54 Offset: 0x79A2B54 VA: 0x79A6B54 Slot: 14
	public virtual byte[] get_Signature() { }

	// RVA: 0x79A6F88 Offset: 0x79A2F88 VA: 0x79A6F88 Slot: 15
	public virtual string get_SubjectName() { }

	// RVA: 0x79A6F90 Offset: 0x79A2F90 VA: 0x79A6F90 Slot: 16
	public virtual DateTime get_ValidFrom() { }

	// RVA: 0x79A6F98 Offset: 0x79A2F98 VA: 0x79A6F98 Slot: 17
	public virtual DateTime get_ValidUntil() { }

	// RVA: 0x79A6FA0 Offset: 0x79A2FA0 VA: 0x79A6FA0
	public int get_Version() { }

	// RVA: 0x79A6FA8 Offset: 0x79A2FA8 VA: 0x79A6FA8
	public bool get_IsCurrent() { }

	// RVA: 0x79A7008 Offset: 0x79A3008 VA: 0x79A7008
	public bool WasCurrent(DateTime instant) { }

	// RVA: 0x79A70E0 Offset: 0x79A30E0 VA: 0x79A70E0
	internal bool VerifySignature(DSA dsa) { }

	// RVA: 0x79A71A8 Offset: 0x79A31A8 VA: 0x79A71A8
	internal bool VerifySignature(RSA rsa) { }

	// RVA: 0x79A72D0 Offset: 0x79A32D0 VA: 0x79A72D0
	public bool VerifySignature(AsymmetricAlgorithm aa) { }

	// RVA: 0x79A7444 Offset: 0x79A3444 VA: 0x79A7444
	public bool get_IsSelfSigned() { }

	// RVA: 0x79A754C Offset: 0x79A354C VA: 0x79A754C Slot: 18
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x79A62C0 Offset: 0x79A22C0 VA: 0x79A62C0
	private static byte[] PEM(string type, byte[] data) { }

	// RVA: 0x79A75A8 Offset: 0x79A35A8 VA: 0x79A75A8
	private static void .cctor() { }
}

// Namespace: 
public class X509CertificateCollection.X509CertificateEnumerator : IEnumerator // TypeDefIndex: 25725
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Properties
	public X509Certificate Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x79A78D8 Offset: 0x79A38D8 VA: 0x79A78D8
	public void .ctor(X509CertificateCollection mappings) { }

	// RVA: 0x799ED98 Offset: 0x799AD98 VA: 0x799ED98
	public X509Certificate get_Current() { }

	// RVA: 0x79A7A68 Offset: 0x79A3A68 VA: 0x79A7A68 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x79A7B0C Offset: 0x79A3B0C VA: 0x79A7B0C Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x79A7BAC Offset: 0x79A3BAC VA: 0x79A7BAC Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x799F170 Offset: 0x799B170 VA: 0x799F170
	public bool MoveNext() { }
}

// Namespace: Mono.Security.X509
[DefaultMember("Item")]
[Serializable]
public class X509CertificateCollection : CollectionBase, IEnumerable // TypeDefIndex: 25726
{
	// Properties
	public X509Certificate Item { get; }

	// Methods

	// RVA: 0x799B440 Offset: 0x7997440 VA: 0x799B440
	public void .ctor() { }

	// RVA: 0x79A7610 Offset: 0x79A3610 VA: 0x79A7610
	public X509Certificate get_Item(int index) { }

	// RVA: 0x799B5D4 Offset: 0x79975D4 VA: 0x799B5D4
	public int Add(X509Certificate value) { }

	// RVA: 0x79A76A8 Offset: 0x79A36A8 VA: 0x79A76A8
	public void AddRange(X509CertificateCollection value) { }

	// RVA: 0x79A7778 Offset: 0x79A3778 VA: 0x79A7778
	public bool Contains(X509Certificate value) { }

	// RVA: 0x799ED40 Offset: 0x799AD40 VA: 0x799ED40
	public X509CertificateCollection.X509CertificateEnumerator GetEnumerator() { }

	// RVA: 0x79A7994 Offset: 0x79A3994 VA: 0x79A7994 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x79A79B8 Offset: 0x79A39B8 VA: 0x79A79B8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x79A7790 Offset: 0x79A3790 VA: 0x79A7790
	public int IndexOf(X509Certificate value) { }

	// RVA: 0x79A79D8 Offset: 0x79A39D8 VA: 0x79A79D8
	private bool Compare(byte[] array1, byte[] array2) { }
}

// Namespace: Mono.Security.X509
public class X509Chain // TypeDefIndex: 25727
{
	// Fields
	private X509CertificateCollection roots; // 0x10
	private X509CertificateCollection certs; // 0x18
	private X509Certificate _root; // 0x20
	private X509CertificateCollection _chain; // 0x28
	private X509ChainStatusFlags _status; // 0x30

	// Properties
	public X509CertificateCollection TrustAnchors { get; }

	// Methods

	// RVA: 0x79A7C50 Offset: 0x79A3C50 VA: 0x79A7C50
	public void .ctor() { }

	// RVA: 0x79A7CBC Offset: 0x79A3CBC VA: 0x79A7CBC
	public X509CertificateCollection get_TrustAnchors() { }

	// RVA: 0x79A7DE4 Offset: 0x79A3DE4 VA: 0x79A7DE4
	public void LoadCertificates(X509CertificateCollection collection) { }

	// RVA: 0x79A7DFC Offset: 0x79A3DFC VA: 0x79A7DFC
	public bool Build(X509Certificate leaf) { }

	// RVA: 0x79A87D8 Offset: 0x79A47D8 VA: 0x79A87D8
	public void Reset() { }

	// RVA: 0x79A872C Offset: 0x79A472C VA: 0x79A872C
	private bool IsValid(X509Certificate cert) { }

	// RVA: 0x79A81C4 Offset: 0x79A41C4 VA: 0x79A81C4
	private X509Certificate FindCertificateParent(X509Certificate child) { }

	// RVA: 0x79A83A0 Offset: 0x79A43A0 VA: 0x79A83A0
	private X509Certificate FindCertificateRoot(X509Certificate potentialRoot) { }

	// RVA: 0x79A8834 Offset: 0x79A4834 VA: 0x79A8834
	private bool IsTrusted(X509Certificate potentialTrusted) { }

	// RVA: 0x79A85E8 Offset: 0x79A45E8 VA: 0x79A85E8
	private bool IsParent(X509Certificate child, X509Certificate parent) { }
}

// Namespace: Mono.Security.X509
[Flags]
[Serializable]
public enum X509ChainStatusFlags // TypeDefIndex: 25728
{
	// Fields
	public int value__; // 0x0
	public const X509ChainStatusFlags InvalidBasicConstraints = 1024;
	public const X509ChainStatusFlags NoError = 0;
	public const X509ChainStatusFlags NotSignatureValid = 8;
	public const X509ChainStatusFlags NotTimeNested = 2;
	public const X509ChainStatusFlags NotTimeValid = 1;
	public const X509ChainStatusFlags PartialChain = 65536;
	public const X509ChainStatusFlags UntrustedRoot = 32;
}

// Namespace: Mono.Security.X509
public class X509Extension // TypeDefIndex: 25729
{
	// Fields
	protected string extnOid; // 0x10
	protected bool extnCritical; // 0x18
	protected ASN1 extnValue; // 0x20

	// Properties
	public string Oid { get; }
	public bool Critical { get; }
	public ASN1 Value { get; }

	// Methods

	// RVA: 0x79A8914 Offset: 0x79A4914 VA: 0x79A8914
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x79A8BF4 Offset: 0x79A4BF4 VA: 0x79A8BF4
	public void .ctor(X509Extension extension) { }

	// RVA: 0x79A8D74 Offset: 0x79A4D74 VA: 0x79A8D74 Slot: 4
	protected virtual void Decode() { }

	// RVA: 0x79A8D78 Offset: 0x79A4D78 VA: 0x79A8D78 Slot: 5
	protected virtual void Encode() { }

	// RVA: 0x79A8D7C Offset: 0x79A4D7C VA: 0x79A8D7C
	public string get_Oid() { }

	// RVA: 0x79A8D84 Offset: 0x79A4D84 VA: 0x79A8D84
	public bool get_Critical() { }

	// RVA: 0x79A8D48 Offset: 0x79A4D48 VA: 0x79A8D48
	public ASN1 get_Value() { }

	// RVA: 0x79A8D8C Offset: 0x79A4D8C VA: 0x79A8D8C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x79A8EDC Offset: 0x79A4EDC VA: 0x79A8EDC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x79A8EFC Offset: 0x79A4EFC VA: 0x79A8EFC
	private void WriteLine(StringBuilder sb, int n, int pos) { }

	// RVA: 0x79A9124 Offset: 0x79A5124 VA: 0x79A9124 Slot: 3
	public override string ToString() { }
}

// Namespace: Mono.Security.X509
[DefaultMember("Item")]
public sealed class X509ExtensionCollection : CollectionBase, IEnumerable // TypeDefIndex: 25730
{
	// Fields
	private bool readOnly; // 0x18

	// Properties
	public X509Extension Item { get; }

	// Methods

	// RVA: 0x79A91FC Offset: 0x79A51FC VA: 0x79A91FC
	public void .ctor() { }

	// RVA: 0x79A4D90 Offset: 0x79A0D90 VA: 0x79A4D90
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x79A9204 Offset: 0x79A5204 VA: 0x79A9204
	public int IndexOf(string oid) { }

	// RVA: 0x79A933C Offset: 0x79A533C VA: 0x79A933C Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x79A8860 Offset: 0x79A4860 VA: 0x79A8860
	public X509Extension get_Item(string oid) { }
}

// Namespace: Mono.Security.X509
public class X509Store // TypeDefIndex: 25731
{
	// Fields
	private string _storePath; // 0x10
	private X509CertificateCollection _certificates; // 0x18
	private ArrayList _crls; // 0x20
	private bool _crl; // 0x28
	private bool _newFormat; // 0x29

	// Properties
	public X509CertificateCollection Certificates { get; }
	public ArrayList Crls { get; }

	// Methods

	// RVA: 0x79A9360 Offset: 0x79A5360 VA: 0x79A9360
	internal void .ctor(string path, bool crl, bool newFormat) { }

	// RVA: 0x79A93AC Offset: 0x79A53AC VA: 0x79A93AC
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x79A95CC Offset: 0x79A55CC VA: 0x79A95CC
	public ArrayList get_Crls() { }

	// RVA: 0x79A982C Offset: 0x79A582C VA: 0x79A982C
	private byte[] Load(string filename) { }

	// RVA: 0x79A9A34 Offset: 0x79A5A34 VA: 0x79A9A34
	private X509Certificate LoadCertificate(string filename) { }

	// RVA: 0x79A9A9C Offset: 0x79A5A9C VA: 0x79A9A9C
	private X509Crl LoadCrl(string filename) { }

	// RVA: 0x79A9B04 Offset: 0x79A5B04 VA: 0x79A9B04
	private bool CheckStore(string path, bool throwException) { }

	// RVA: 0x79A93F0 Offset: 0x79A53F0 VA: 0x79A93F0
	private X509CertificateCollection BuildCertificatesCollection(string storeName) { }

	// RVA: 0x79A9664 Offset: 0x79A5664 VA: 0x79A9664
	private ArrayList BuildCrlsCollection(string storeName) { }
}

// Namespace: Mono.Security.X509
public sealed class X509StoreManager // TypeDefIndex: 25732
{
	// Fields
	private static string _userPath; // 0x0
	private static string _localMachinePath; // 0x8
	private static X509Stores _userStore; // 0x10
	private static X509Stores _machineStore; // 0x18

	// Properties
	internal static string CurrentUserPath { get; }
	internal static string LocalMachinePath { get; }
	public static X509Stores CurrentUser { get; }
	public static X509Stores LocalMachine { get; }
	public static X509CertificateCollection TrustedRootCertificates { get; }

	// Methods

	// RVA: 0x79A9BE0 Offset: 0x79A5BE0 VA: 0x79A9BE0
	internal static string get_CurrentUserPath() { }

	// RVA: 0x79A9CF8 Offset: 0x79A5CF8 VA: 0x79A9CF8
	internal static string get_LocalMachinePath() { }

	// RVA: 0x79A9E08 Offset: 0x79A5E08 VA: 0x79A9E08
	public static X509Stores get_CurrentUser() { }

	// RVA: 0x79A9EF8 Offset: 0x79A5EF8 VA: 0x79A9EF8
	public static X509Stores get_LocalMachine() { }

	// RVA: 0x79A7D48 Offset: 0x79A3D48 VA: 0x79A7D48
	public static X509CertificateCollection get_TrustedRootCertificates() { }
}

// Namespace: Mono.Security.X509
public class X509Stores // TypeDefIndex: 25733
{
	// Fields
	private string _storePath; // 0x10
	private bool _newFormat; // 0x18
	private X509Store _trusted; // 0x20

	// Properties
	public X509Store TrustedRoot { get; }

	// Methods

	// RVA: 0x79A9EBC Offset: 0x79A5EBC VA: 0x79A9EBC
	internal void .ctor(string path, bool newFormat) { }

	// RVA: 0x79A9FAC Offset: 0x79A5FAC VA: 0x79A9FAC
	public X509Store get_TrustedRoot() { }

	// RVA: 0x79AA09C Offset: 0x79A609C VA: 0x79AA09C
	public X509Store Open(string storeName, bool create) { }
}

// Namespace: Mono.Security.X509.Extensions
public class AuthorityKeyIdentifierExtension : X509Extension // TypeDefIndex: 25734
{
	// Fields
	private byte[] aki; // 0x28

	// Properties
	public byte[] Identifier { get; }

	// Methods

	// RVA: 0x79AA1BC Offset: 0x79A61BC VA: 0x79AA1BC
	public void .ctor(X509Extension extension) { }

	// RVA: 0x79AA1C0 Offset: 0x79A61C0 VA: 0x79AA1C0 Slot: 4
	protected override void Decode() { }

	// RVA: 0x79AA2E4 Offset: 0x79A62E4 VA: 0x79AA2E4 Slot: 5
	protected override void Encode() { }

	// RVA: 0x79AA42C Offset: 0x79A642C VA: 0x79AA42C
	public byte[] get_Identifier() { }

	// RVA: 0x79AA4A0 Offset: 0x79A64A0 VA: 0x79AA4A0 Slot: 3
	public override string ToString() { }
}

// Namespace: Mono.Security.X509.Extensions
public class BasicConstraintsExtension : X509Extension // TypeDefIndex: 25735
{
	// Fields
	private bool cA; // 0x28
	private int pathLenConstraint; // 0x2C

	// Properties
	public bool CertificateAuthority { get; }

	// Methods

	// RVA: 0x79A8910 Offset: 0x79A4910 VA: 0x79A8910
	public void .ctor(X509Extension extension) { }

	// RVA: 0x79AA60C Offset: 0x79A660C VA: 0x79AA60C Slot: 4
	protected override void Decode() { }

	// RVA: 0x79AA740 Offset: 0x79A6740 VA: 0x79AA740 Slot: 5
	protected override void Encode() { }

	// RVA: 0x79AA89C Offset: 0x79A689C VA: 0x79AA89C
	public bool get_CertificateAuthority() { }

	// RVA: 0x79AA8A4 Offset: 0x79A68A4 VA: 0x79AA8A4 Slot: 3
	public override string ToString() { }
}

// Namespace: Mono.Security.Protocol.Ntlm
[Obsolete("Use of this API is highly discouraged, it selects legacy-mode LM/NTLM authentication, which sends your password in very weak encryption over the wire even if the server supports the more secure NTLMv2 / NTLMv2 Session. You need to use the new `Type3Message (Type2Message)' constructor to use the more secure NTLMv2 / NTLMv2 Session authentication modes. These require the Type 2 message from the server to compute the response.")]
public class ChallengeResponse : IDisposable // TypeDefIndex: 25736
{
	// Fields
	private static byte[] magic; // 0x0
	private static byte[] nullEncMagic; // 0x8
	private bool _disposed; // 0x10
	private byte[] _challenge; // 0x18
	private byte[] _lmpwd; // 0x20
	private byte[] _ntpwd; // 0x28

	// Properties
	public string Password { set; }
	public byte[] Challenge { set; }
	public byte[] LM { get; }
	public byte[] NT { get; }

	// Methods

	// RVA: 0x79AAA44 Offset: 0x79A6A44 VA: 0x79AAA44
	public void .ctor() { }

	// RVA: 0x79AAAC8 Offset: 0x79A6AC8 VA: 0x79AAAC8
	public void .ctor(string password, byte[] challenge) { }

	// RVA: 0x79AB040 Offset: 0x79A7040 VA: 0x79AB040 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x79AAB00 Offset: 0x79A6B00 VA: 0x79AAB00
	public void set_Password(string value) { }

	// RVA: 0x79AAF10 Offset: 0x79A6F10 VA: 0x79AAF10
	public void set_Challenge(byte[] value) { }

	// RVA: 0x79AB288 Offset: 0x79A7288 VA: 0x79AB288
	public byte[] get_LM() { }

	// RVA: 0x79AB5D0 Offset: 0x79A75D0 VA: 0x79AB5D0
	public byte[] get_NT() { }

	// RVA: 0x79AB0E0 Offset: 0x79A70E0 VA: 0x79AB0E0 Slot: 4
	public void Dispose() { }

	// RVA: 0x79AB630 Offset: 0x79A7630 VA: 0x79AB630
	private void Dispose(bool disposing) { }

	// RVA: 0x79AB2E8 Offset: 0x79A72E8 VA: 0x79AB2E8
	private byte[] GetResponse(byte[] pwd) { }

	// RVA: 0x79AB69C Offset: 0x79A769C VA: 0x79AB69C
	private byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x79AB144 Offset: 0x79A7144 VA: 0x79AB144
	private byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x79AB894 Offset: 0x79A7894 VA: 0x79AB894
	private static void .cctor() { }
}

// Namespace: Mono.Security.Protocol.Ntlm
public static class ChallengeResponse2 // TypeDefIndex: 25737
{
	// Fields
	private static byte[] magic; // 0x0
	private static byte[] nullEncMagic; // 0x8

	// Methods

	// RVA: 0x79AB978 Offset: 0x79A7978 VA: 0x79AB978
	private static byte[] Compute_LM(string password, byte[] challenge) { }

	// RVA: 0x79AC114 Offset: 0x79A8114 VA: 0x79AC114
	private static byte[] Compute_NTLM_Password(string password) { }

	// RVA: 0x79AC218 Offset: 0x79A8218 VA: 0x79AC218
	private static byte[] Compute_NTLM(string password, byte[] challenge) { }

	// RVA: 0x79AC284 Offset: 0x79A8284 VA: 0x79AC284
	private static void Compute_NTLMv2_Session(string password, byte[] challenge, out byte[] lm, out byte[] ntlm) { }

	// RVA: 0x79AC468 Offset: 0x79A8468 VA: 0x79AC468
	private static byte[] Compute_NTLMv2(Type2Message type2, string username, string password, string domain) { }

	// RVA: 0x79AC98C Offset: 0x79A898C VA: 0x79AC98C
	public static void Compute(Type2Message type2, NtlmAuthLevel level, string username, string password, string domain, out byte[] lm, out byte[] ntlm) { }

	// RVA: 0x79ABE14 Offset: 0x79A7E14 VA: 0x79ABE14
	private static byte[] GetResponse(byte[] challenge, byte[] pwd) { }

	// RVA: 0x79ACBA4 Offset: 0x79A8BA4 VA: 0x79ACBA4
	private static byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x79ABCAC Offset: 0x79A7CAC VA: 0x79ABCAC
	private static byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x79ACD9C Offset: 0x79A8D9C VA: 0x79ACD9C
	private static void .cctor() { }
}

// Namespace: Mono.Security.Protocol.Ntlm
public abstract class MessageBase // TypeDefIndex: 25738
{
	// Fields
	private static byte[] header; // 0x0
	private int _type; // 0x10
	private NtlmFlags _flags; // 0x14

	// Properties
	public NtlmFlags Flags { get; set; }
	public int Type { get; }

	// Methods

	// RVA: 0x79ACE80 Offset: 0x79A8E80 VA: 0x79ACE80
	protected void .ctor(int messageType) { }

	// RVA: 0x79ACEA8 Offset: 0x79A8EA8 VA: 0x79ACEA8
	public NtlmFlags get_Flags() { }

	// RVA: 0x79ACEB0 Offset: 0x79A8EB0 VA: 0x79ACEB0
	public void set_Flags(NtlmFlags value) { }

	// RVA: 0x79ACEB8 Offset: 0x79A8EB8 VA: 0x79ACEB8
	public int get_Type() { }

	// RVA: 0x79ACEC0 Offset: 0x79A8EC0 VA: 0x79ACEC0
	protected byte[] PrepareMessage(int messageSize) { }

	// RVA: 0x79ACFC0 Offset: 0x79A8FC0 VA: 0x79ACFC0 Slot: 4
	protected virtual void Decode(byte[] message) { }

	// RVA: 0x79AD158 Offset: 0x79A9158 VA: 0x79AD158
	protected bool CheckHeader(byte[] message) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract byte[] GetBytes();

	// RVA: 0x79AD26C Offset: 0x79A926C VA: 0x79AD26C
	private static void .cctor() { }
}

// Namespace: Mono.Security.Protocol.Ntlm
public enum NtlmAuthLevel // TypeDefIndex: 25739
{
	// Fields
	public int value__; // 0x0
	public const NtlmAuthLevel LM_and_NTLM = 0;
	public const NtlmAuthLevel LM_and_NTLM_and_try_NTLMv2_Session = 1;
	public const NtlmAuthLevel NTLM_only = 2;
	public const NtlmAuthLevel NTLMv2_only = 3;
}

// Namespace: Mono.Security.Protocol.Ntlm
[Flags]
public enum NtlmFlags // TypeDefIndex: 25740
{
	// Fields
	public int value__; // 0x0
	public const NtlmFlags NegotiateUnicode = 1;
	public const NtlmFlags NegotiateOem = 2;
	public const NtlmFlags RequestTarget = 4;
	public const NtlmFlags NegotiateNtlm = 512;
	public const NtlmFlags NegotiateDomainSupplied = 4096;
	public const NtlmFlags NegotiateWorkstationSupplied = 8192;
	public const NtlmFlags NegotiateAlwaysSign = 32768;
	public const NtlmFlags NegotiateNtlm2Key = 524288;
	public const NtlmFlags Negotiate128 = 536870912;
	public const NtlmFlags Negotiate56 = -2147483648;
}

// Namespace: Mono.Security.Protocol.Ntlm
public static class NtlmSettings // TypeDefIndex: 25741
{
	// Fields
	private static NtlmAuthLevel defaultAuthLevel; // 0x0

	// Properties
	public static NtlmAuthLevel DefaultAuthLevel { get; }

	// Methods

	// RVA: 0x79AD30C Offset: 0x79A930C VA: 0x79AD30C
	public static NtlmAuthLevel get_DefaultAuthLevel() { }

	// RVA: 0x79AD364 Offset: 0x79A9364 VA: 0x79AD364
	private static void .cctor() { }
}

// Namespace: Mono.Security.Protocol.Ntlm
public class Type1Message : MessageBase // TypeDefIndex: 25742
{
	// Fields
	private string _host; // 0x18
	private string _domain; // 0x20

	// Properties
	public string Domain { set; }
	public string Host { set; }

	// Methods

	// RVA: 0x79AD3B0 Offset: 0x79A93B0 VA: 0x79AD3B0
	public void .ctor() { }

	// RVA: 0x79AD44C Offset: 0x79A944C VA: 0x79AD44C
	public void set_Domain(string value) { }

	// RVA: 0x79AD4D8 Offset: 0x79A94D8 VA: 0x79AD4D8
	public void set_Host(string value) { }

	// RVA: 0x79AD564 Offset: 0x79A9564 VA: 0x79AD564 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x79AD66C Offset: 0x79A966C VA: 0x79AD66C Slot: 5
	public override byte[] GetBytes() { }
}

// Namespace: Mono.Security.Protocol.Ntlm
public class Type2Message : MessageBase // TypeDefIndex: 25743
{
	// Fields
	private byte[] _nonce; // 0x18
	private string _targetName; // 0x20
	private byte[] _targetInfo; // 0x28

	// Properties
	public byte[] Nonce { get; }
	public string TargetName { get; }
	public byte[] TargetInfo { get; }

	// Methods

	// RVA: 0x79AD8B8 Offset: 0x79A98B8 VA: 0x79AD8B8
	public void .ctor(byte[] message) { }

	// RVA: 0x79AD968 Offset: 0x79A9968 VA: 0x79AD968 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x79AC914 Offset: 0x79A8914 VA: 0x79AC914
	public byte[] get_Nonce() { }

	// RVA: 0x79ADA10 Offset: 0x79A9A10 VA: 0x79ADA10
	public string get_TargetName() { }

	// RVA: 0x79AC89C Offset: 0x79A889C VA: 0x79AC89C
	public byte[] get_TargetInfo() { }

	// RVA: 0x79ADA18 Offset: 0x79A9A18 VA: 0x79ADA18 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x79ADBB0 Offset: 0x79A9BB0 VA: 0x79ADBB0 Slot: 5
	public override byte[] GetBytes() { }
}

// Namespace: Mono.Security.Protocol.Ntlm
public class Type3Message : MessageBase // TypeDefIndex: 25744
{
	// Fields
	private NtlmAuthLevel _level; // 0x18
	private byte[] _challenge; // 0x20
	private string _host; // 0x28
	private string _domain; // 0x30
	private string _username; // 0x38
	private string _password; // 0x40
	private Type2Message _type2; // 0x48
	private byte[] _lm; // 0x50
	private byte[] _nt; // 0x58

	// Properties
	public string Domain { set; }
	public string Password { set; }
	public string Username { set; }

	// Methods

	// RVA: 0x79ADC68 Offset: 0x79A9C68 VA: 0x79ADC68
	public void .ctor(Type2Message type2) { }

	// RVA: 0x79ADEAC Offset: 0x79A9EAC VA: 0x79ADEAC Slot: 1
	protected override void Finalize() { }

	// RVA: 0x79ADF8C Offset: 0x79A9F8C VA: 0x79ADF8C
	public void set_Domain(string value) { }

	// RVA: 0x79AE018 Offset: 0x79AA018 VA: 0x79AE018
	public void set_Password(string value) { }

	// RVA: 0x79AE020 Offset: 0x79AA020 VA: 0x79AE020
	public void set_Username(string value) { }

	// RVA: 0x79AE028 Offset: 0x79AA028 VA: 0x79AE028 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x79AE298 Offset: 0x79AA298 VA: 0x79AE298
	private string DecodeString(byte[] buffer, int offset, int len) { }

	// RVA: 0x79AE2F0 Offset: 0x79AA2F0 VA: 0x79AE2F0
	private byte[] EncodeString(string text) { }

	// RVA: 0x79AE380 Offset: 0x79AA380 VA: 0x79AE380 Slot: 5
	public override byte[] GetBytes() { }
}

// Namespace: Mono.Security.Interface
public enum AlertLevel // TypeDefIndex: 25745
{
	// Fields
	public byte value__; // 0x0
	public const AlertLevel Warning = 1;
	public const AlertLevel Fatal = 2;
}

// Namespace: Mono.Security.Interface
public enum AlertDescription // TypeDefIndex: 25746
{
	// Fields
	public byte value__; // 0x0
	public const AlertDescription CloseNotify = 0;
	public const AlertDescription UnexpectedMessage = 10;
	public const AlertDescription BadRecordMAC = 20;
	public const AlertDescription DecryptionFailed_RESERVED = 21;
	public const AlertDescription RecordOverflow = 22;
	public const AlertDescription DecompressionFailure = 30;
	public const AlertDescription HandshakeFailure = 40;
	public const AlertDescription NoCertificate_RESERVED = 41;
	public const AlertDescription BadCertificate = 42;
	public const AlertDescription UnsupportedCertificate = 43;
	public const AlertDescription CertificateRevoked = 44;
	public const AlertDescription CertificateExpired = 45;
	public const AlertDescription CertificateUnknown = 46;
	public const AlertDescription IlegalParameter = 47;
	public const AlertDescription UnknownCA = 48;
	public const AlertDescription AccessDenied = 49;
	public const AlertDescription DecodeError = 50;
	public const AlertDescription DecryptError = 51;
	public const AlertDescription ExportRestriction = 60;
	public const AlertDescription ProtocolVersion = 70;
	public const AlertDescription InsuficientSecurity = 71;
	public const AlertDescription InternalError = 80;
	public const AlertDescription UserCancelled = 90;
	public const AlertDescription NoRenegotiation = 100;
	public const AlertDescription UnsupportedExtension = 110;
}

// Namespace: Mono.Security.Interface
public class Alert // TypeDefIndex: 25747
{
	// Fields
	private AlertLevel level; // 0x10
	private AlertDescription description; // 0x11

	// Properties
	public AlertLevel Level { get; }
	public AlertDescription Description { get; }

	// Methods

	// RVA: 0x79AE9B0 Offset: 0x79AA9B0 VA: 0x79AE9B0
	public AlertLevel get_Level() { }

	// RVA: 0x79AE9B8 Offset: 0x79AA9B8 VA: 0x79AE9B8
	public AlertDescription get_Description() { }

	// RVA: 0x79AE9C0 Offset: 0x79AA9C0 VA: 0x79AE9C0
	public void .ctor(AlertDescription description) { }

	// RVA: 0x79AEA2C Offset: 0x79AAA2C VA: 0x79AEA2C
	private void inferAlertLevel() { }

	// RVA: 0x79AEA6C Offset: 0x79AAA6C VA: 0x79AEA6C Slot: 3
	public override string ToString() { }
}

// Namespace: Mono.Security.Interface
public class ValidationResult // TypeDefIndex: 25748
{
	// Fields
	private bool trusted; // 0x10
	private bool user_denied; // 0x11
	private int error_code; // 0x14
	private Nullable<MonoSslPolicyErrors> policy_errors; // 0x18

	// Properties
	public bool Trusted { get; }
	public bool UserDenied { get; }

	// Methods

	// RVA: 0x79AEB28 Offset: 0x79AAB28 VA: 0x79AEB28
	public void .ctor(bool trusted, bool user_denied, int error_code, Nullable<MonoSslPolicyErrors> policy_errors) { }

	// RVA: 0x79AEB70 Offset: 0x79AAB70 VA: 0x79AEB70
	public bool get_Trusted() { }

	// RVA: 0x79AEB78 Offset: 0x79AAB78 VA: 0x79AEB78
	public bool get_UserDenied() { }
}

// Namespace: Mono.Security.Interface
public interface ICertificateValidator // TypeDefIndex: 25749
{}

// Namespace: Mono.Security.Interface
[CLSCompliant(False)]
public enum CipherSuiteCode // TypeDefIndex: 25750
{
	// Fields
	public ushort value__; // 0x0
	public const CipherSuiteCode TLS_NULL_WITH_NULL_NULL = 0;
	public const CipherSuiteCode TLS_RSA_WITH_NULL_MD5 = 1;
	public const CipherSuiteCode TLS_RSA_WITH_NULL_SHA = 2;
	public const CipherSuiteCode TLS_RSA_EXPORT_WITH_RC4_40_MD5 = 3;
	public const CipherSuiteCode TLS_RSA_WITH_RC4_128_MD5 = 4;
	public const CipherSuiteCode TLS_RSA_WITH_RC4_128_SHA = 5;
	public const CipherSuiteCode TLS_RSA_EXPORT_WITH_RC2_CBC_40_MD5 = 6;
	public const CipherSuiteCode TLS_RSA_WITH_IDEA_CBC_SHA = 7;
	public const CipherSuiteCode TLS_RSA_EXPORT_WITH_DES40_CBC_SHA = 8;
	public const CipherSuiteCode TLS_RSA_WITH_DES_CBC_SHA = 9;
	public const CipherSuiteCode TLS_RSA_WITH_3DES_EDE_CBC_SHA = 10;
	public const CipherSuiteCode TLS_DH_DSS_EXPORT_WITH_DES40_CBC_SHA = 11;
	public const CipherSuiteCode TLS_DH_DSS_WITH_DES_CBC_SHA = 12;
	public const CipherSuiteCode TLS_DH_DSS_WITH_3DES_EDE_CBC_SHA = 13;
	public const CipherSuiteCode TLS_DH_RSA_EXPORT_WITH_DES40_CBC_SHA = 14;
	public const CipherSuiteCode TLS_DH_RSA_WITH_DES_CBC_SHA = 15;
	public const CipherSuiteCode TLS_DH_RSA_WITH_3DES_EDE_CBC_SHA = 16;
	public const CipherSuiteCode TLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA = 17;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_DES_CBC_SHA = 18;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA = 19;
	public const CipherSuiteCode TLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA = 20;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_DES_CBC_SHA = 21;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA = 22;
	public const CipherSuiteCode TLS_DH_anon_EXPORT_WITH_RC4_40_MD5 = 23;
	public const CipherSuiteCode TLS_DH_anon_WITH_RC4_128_MD5 = 24;
	public const CipherSuiteCode TLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA = 25;
	public const CipherSuiteCode TLS_DH_anon_WITH_DES_CBC_SHA = 26;
	public const CipherSuiteCode TLS_DH_anon_WITH_3DES_EDE_CBC_SHA = 27;
	public const CipherSuiteCode TLS_RSA_WITH_AES_128_CBC_SHA = 47;
	public const CipherSuiteCode TLS_DH_DSS_WITH_AES_128_CBC_SHA = 48;
	public const CipherSuiteCode TLS_DH_RSA_WITH_AES_128_CBC_SHA = 49;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_AES_128_CBC_SHA = 50;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_128_CBC_SHA = 51;
	public const CipherSuiteCode TLS_DH_anon_WITH_AES_128_CBC_SHA = 52;
	public const CipherSuiteCode TLS_RSA_WITH_AES_256_CBC_SHA = 53;
	public const CipherSuiteCode TLS_DH_DSS_WITH_AES_256_CBC_SHA = 54;
	public const CipherSuiteCode TLS_DH_RSA_WITH_AES_256_CBC_SHA = 55;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_AES_256_CBC_SHA = 56;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_256_CBC_SHA = 57;
	public const CipherSuiteCode TLS_DH_anon_WITH_AES_256_CBC_SHA = 58;
	public const CipherSuiteCode TLS_RSA_WITH_CAMELLIA_128_CBC_SHA = 65;
	public const CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA = 66;
	public const CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA = 67;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA = 68;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA = 69;
	public const CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA = 70;
	public const CipherSuiteCode TLS_RSA_WITH_CAMELLIA_256_CBC_SHA = 132;
	public const CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA = 133;
	public const CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA = 134;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA = 135;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA = 136;
	public const CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA = 137;
	public const CipherSuiteCode TLS_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 186;
	public const CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 187;
	public const CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 188;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 189;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 190;
	public const CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA256 = 191;
	public const CipherSuiteCode TLS_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 192;
	public const CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 193;
	public const CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 194;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 195;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 196;
	public const CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA256 = 197;
	public const CipherSuiteCode TLS_RSA_WITH_SEED_CBC_SHA = 150;
	public const CipherSuiteCode TLS_DH_DSS_WITH_SEED_CBC_SHA = 151;
	public const CipherSuiteCode TLS_DH_RSA_WITH_SEED_CBC_SHA = 152;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_SEED_CBC_SHA = 153;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_SEED_CBC_SHA = 154;
	public const CipherSuiteCode TLS_DH_anon_WITH_SEED_CBC_SHA = 155;
	public const CipherSuiteCode TLS_PSK_WITH_RC4_128_SHA = 138;
	public const CipherSuiteCode TLS_PSK_WITH_3DES_EDE_CBC_SHA = 139;
	public const CipherSuiteCode TLS_PSK_WITH_AES_128_CBC_SHA = 140;
	public const CipherSuiteCode TLS_PSK_WITH_AES_256_CBC_SHA = 141;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_RC4_128_SHA = 142;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_3DES_EDE_CBC_SHA = 143;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_128_CBC_SHA = 144;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_256_CBC_SHA = 145;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_RC4_128_SHA = 146;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_3DES_EDE_CBC_SHA = 147;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_AES_128_CBC_SHA = 148;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_AES_256_CBC_SHA = 149;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_NULL_SHA = 49153;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_RC4_128_SHA = 49154;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA = 49155;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA = 49156;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA = 49157;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_NULL_SHA = 49158;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_RC4_128_SHA = 49159;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA = 49160;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA = 49161;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA = 49162;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_NULL_SHA = 49163;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_RC4_128_SHA = 49164;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA = 49165;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_AES_128_CBC_SHA = 49166;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_AES_256_CBC_SHA = 49167;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_NULL_SHA = 49168;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_RC4_128_SHA = 49169;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA = 49170;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA = 49171;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA = 49172;
	public const CipherSuiteCode TLS_ECDH_anon_WITH_NULL_SHA = 49173;
	public const CipherSuiteCode TLS_ECDH_anon_WITH_RC4_128_SHA = 49174;
	public const CipherSuiteCode TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA = 49175;
	public const CipherSuiteCode TLS_ECDH_anon_WITH_AES_128_CBC_SHA = 49176;
	public const CipherSuiteCode TLS_ECDH_anon_WITH_AES_256_CBC_SHA = 49177;
	public const CipherSuiteCode TLS_PSK_WITH_NULL_SHA = 44;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_NULL_SHA = 45;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_NULL_SHA = 46;
	public const CipherSuiteCode TLS_SRP_SHA_WITH_3DES_EDE_CBC_SHA = 49178;
	public const CipherSuiteCode TLS_SRP_SHA_RSA_WITH_3DES_EDE_CBC_SHA = 49179;
	public const CipherSuiteCode TLS_SRP_SHA_DSS_WITH_3DES_EDE_CBC_SHA = 49180;
	public const CipherSuiteCode TLS_SRP_SHA_WITH_AES_128_CBC_SHA = 49181;
	public const CipherSuiteCode TLS_SRP_SHA_RSA_WITH_AES_128_CBC_SHA = 49182;
	public const CipherSuiteCode TLS_SRP_SHA_DSS_WITH_AES_128_CBC_SHA = 49183;
	public const CipherSuiteCode TLS_SRP_SHA_WITH_AES_256_CBC_SHA = 49184;
	public const CipherSuiteCode TLS_SRP_SHA_RSA_WITH_AES_256_CBC_SHA = 49185;
	public const CipherSuiteCode TLS_SRP_SHA_DSS_WITH_AES_256_CBC_SHA = 49186;
	public const CipherSuiteCode TLS_RSA_WITH_NULL_SHA256 = 59;
	public const CipherSuiteCode TLS_RSA_WITH_AES_128_CBC_SHA256 = 60;
	public const CipherSuiteCode TLS_RSA_WITH_AES_256_CBC_SHA256 = 61;
	public const CipherSuiteCode TLS_DH_DSS_WITH_AES_128_CBC_SHA256 = 62;
	public const CipherSuiteCode TLS_DH_RSA_WITH_AES_128_CBC_SHA256 = 63;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_AES_128_CBC_SHA256 = 64;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_128_CBC_SHA256 = 103;
	public const CipherSuiteCode TLS_DH_DSS_WITH_AES_256_CBC_SHA256 = 104;
	public const CipherSuiteCode TLS_DH_RSA_WITH_AES_256_CBC_SHA256 = 105;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_AES_256_CBC_SHA256 = 106;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_256_CBC_SHA256 = 107;
	public const CipherSuiteCode TLS_DH_anon_WITH_AES_128_CBC_SHA256 = 108;
	public const CipherSuiteCode TLS_DH_anon_WITH_AES_256_CBC_SHA256 = 109;
	public const CipherSuiteCode TLS_RSA_WITH_AES_128_GCM_SHA256 = 156;
	public const CipherSuiteCode TLS_RSA_WITH_AES_256_GCM_SHA384 = 157;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_128_GCM_SHA256 = 158;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_256_GCM_SHA384 = 159;
	public const CipherSuiteCode TLS_DH_RSA_WITH_AES_128_GCM_SHA256 = 160;
	public const CipherSuiteCode TLS_DH_RSA_WITH_AES_256_GCM_SHA384 = 161;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_AES_128_GCM_SHA256 = 162;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_AES_256_GCM_SHA384 = 163;
	public const CipherSuiteCode TLS_DH_DSS_WITH_AES_128_GCM_SHA256 = 164;
	public const CipherSuiteCode TLS_DH_DSS_WITH_AES_256_GCM_SHA384 = 165;
	public const CipherSuiteCode TLS_DH_anon_WITH_AES_128_GCM_SHA256 = 166;
	public const CipherSuiteCode TLS_DH_anon_WITH_AES_256_GCM_SHA384 = 167;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256 = 49187;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384 = 49188;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256 = 49189;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384 = 49190;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256 = 49191;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384 = 49192;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256 = 49193;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384 = 49194;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256 = 49195;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384 = 49196;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256 = 49197;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384 = 49198;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256 = 49199;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384 = 49200;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256 = 49201;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384 = 49202;
	public const CipherSuiteCode TLS_PSK_WITH_AES_128_GCM_SHA256 = 168;
	public const CipherSuiteCode TLS_PSK_WITH_AES_256_GCM_SHA384 = 169;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_128_GCM_SHA256 = 170;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_256_GCM_SHA384 = 171;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_AES_128_GCM_SHA256 = 172;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_AES_256_GCM_SHA384 = 173;
	public const CipherSuiteCode TLS_PSK_WITH_AES_128_CBC_SHA256 = 174;
	public const CipherSuiteCode TLS_PSK_WITH_AES_256_CBC_SHA384 = 175;
	public const CipherSuiteCode TLS_PSK_WITH_NULL_SHA256 = 176;
	public const CipherSuiteCode TLS_PSK_WITH_NULL_SHA384 = 177;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_128_CBC_SHA256 = 178;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_256_CBC_SHA384 = 179;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_NULL_SHA256 = 180;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_NULL_SHA384 = 181;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_AES_128_CBC_SHA256 = 182;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_AES_256_CBC_SHA384 = 183;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_NULL_SHA256 = 184;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_NULL_SHA384 = 185;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_RC4_128_SHA = 49203;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_3DES_EDE_CBC_SHA = 49204;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA = 49205;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA = 49206;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA256 = 49207;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA384 = 49208;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_NULL_SHA = 49209;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_NULL_SHA256 = 49210;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_NULL_SHA384 = 49211;
	public const CipherSuiteCode TLS_EMPTY_RENEGOTIATION_INFO_SCSV = 255;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49266;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49267;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49268;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49269;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49270;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49271;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49272;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49273;
	public const CipherSuiteCode TLS_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49274;
	public const CipherSuiteCode TLS_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49275;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49276;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49277;
	public const CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49278;
	public const CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49279;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49280;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49281;
	public const CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49282;
	public const CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49283;
	public const CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_128_GCM_SHA256 = 49284;
	public const CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_256_GCM_SHA384 = 49285;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49286;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49287;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49288;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49289;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49290;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49291;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49292;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49293;
	public const CipherSuiteCode TLS_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49294;
	public const CipherSuiteCode TLS_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49295;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49296;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49297;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49298;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49299;
	public const CipherSuiteCode TLS_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49300;
	public const CipherSuiteCode TLS_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49301;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49302;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49303;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49304;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49305;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49306;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49307;
	public const CipherSuiteCode TLS_RSA_WITH_AES_128_CCM = 49308;
	public const CipherSuiteCode TLS_RSA_WITH_AES_256_CCM = 49309;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_128_CCM = 49310;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_256_CCM = 49311;
	public const CipherSuiteCode TLS_RSA_WITH_AES_128_CCM_8 = 49312;
	public const CipherSuiteCode TLS_RSA_WITH_AES_256_CCM_8 = 49313;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_128_CCM_8 = 49314;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_256_CCM_8 = 49315;
	public const CipherSuiteCode TLS_PSK_WITH_AES_128_CCM = 49316;
	public const CipherSuiteCode TLS_PSK_WITH_AES_256_CCM = 49317;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_128_CCM = 49318;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_256_CCM = 49319;
	public const CipherSuiteCode TLS_PSK_WITH_AES_128_CCM_8 = 49320;
	public const CipherSuiteCode TLS_PSK_WITH_AES_256_CCM_8 = 49321;
	public const CipherSuiteCode TLS_PSK_DHE_WITH_AES_128_CCM_8 = 49322;
	public const CipherSuiteCode TLS_PSK_DHE_WITH_AES_256_CCM_8 = 49323;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52243;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256 = 52244;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52245;
	public const CipherSuiteCode TLS_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58384;
	public const CipherSuiteCode TLS_RSA_WITH_SALSA20_SHA1 = 58385;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58386;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_SALSA20_SHA1 = 58387;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_ESTREAM_SALSA20_SHA1 = 58388;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_SALSA20_SHA1 = 58389;
	public const CipherSuiteCode TLS_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58390;
	public const CipherSuiteCode TLS_PSK_WITH_SALSA20_SHA1 = 58391;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58392;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_SALSA20_SHA1 = 58393;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58394;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_SALSA20_SHA1 = 58395;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58396;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_SALSA20_SHA1 = 58397;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58398;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_SALSA20_SHA1 = 58399;
	public const CipherSuiteCode TLS_FALLBACK_SCSV = 22016;
}

// Namespace: Mono.Security.Interface
public class MonoTlsConnectionInfo // TypeDefIndex: 25751
{
	// Fields
	[CompilerGenerated]
	private CipherSuiteCode <CipherSuiteCode>k__BackingField; // 0x10
	[CompilerGenerated]
	private TlsProtocols <ProtocolVersion>k__BackingField; // 0x14
	[CompilerGenerated]
	private string <PeerDomainName>k__BackingField; // 0x18

	// Properties
	[CLSCompliant(False)]
	public CipherSuiteCode CipherSuiteCode { get; set; }
	public TlsProtocols ProtocolVersion { get; set; }
	public string PeerDomainName { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x79AEB80 Offset: 0x79AAB80 VA: 0x79AEB80
	public CipherSuiteCode get_CipherSuiteCode() { }

	[CompilerGenerated]
	// RVA: 0x79AEB88 Offset: 0x79AAB88 VA: 0x79AEB88
	public void set_CipherSuiteCode(CipherSuiteCode value) { }

	[CompilerGenerated]
	// RVA: 0x79AEB90 Offset: 0x79AAB90 VA: 0x79AEB90
	public TlsProtocols get_ProtocolVersion() { }

	[CompilerGenerated]
	// RVA: 0x79AEB98 Offset: 0x79AAB98 VA: 0x79AEB98
	public void set_ProtocolVersion(TlsProtocols value) { }

	[CompilerGenerated]
	// RVA: 0x79AEBA0 Offset: 0x79AABA0 VA: 0x79AEBA0
	public void set_PeerDomainName(string value) { }

	// RVA: 0x79AEBA8 Offset: 0x79AABA8 VA: 0x79AEBA8 Slot: 3
	public override string ToString() { }

	// RVA: 0x79AEC64 Offset: 0x79AAC64 VA: 0x79AEC64
	public void .ctor() { }
}

// Namespace: Mono.Security.Interface
[Flags]
public enum MonoSslPolicyErrors // TypeDefIndex: 25752
{
	// Fields
	public int value__; // 0x0
	public const MonoSslPolicyErrors None = 0;
	public const MonoSslPolicyErrors RemoteCertificateNotAvailable = 1;
	public const MonoSslPolicyErrors RemoteCertificateNameMismatch = 2;
	public const MonoSslPolicyErrors RemoteCertificateChainErrors = 4;
}

// Namespace: Mono.Security.Interface
public sealed class MonoRemoteCertificateValidationCallback : MulticastDelegate // TypeDefIndex: 25753
{
	// Methods

	// RVA: 0x79AEC6C Offset: 0x79AAC6C VA: 0x79AEC6C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x79AED20 Offset: 0x79AAD20 VA: 0x79AED20 Slot: 13
	public virtual bool Invoke(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors) { }
}

// Namespace: Mono.Security.Interface
public sealed class MonoLocalCertificateSelectionCallback : MulticastDelegate // TypeDefIndex: 25754
{
	// Methods

	// RVA: 0x79AED34 Offset: 0x79AAD34 VA: 0x79AED34
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x79AEDE8 Offset: 0x79AADE8 VA: 0x79AEDE8 Slot: 13
	public virtual X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }
}

// Namespace: Mono.Security.Interface
public abstract class MonoTlsProvider // TypeDefIndex: 25755
{
	// Properties
	public abstract Guid ID { get; }
	public abstract string Name { get; }
	public abstract bool SupportsSslStream { get; }
	public abstract bool SupportsConnectionInfo { get; }
	public abstract bool SupportsMonoExtensions { get; }
	public abstract SslProtocols SupportedProtocols { get; }
	internal abstract bool SupportsCleanShutdown { get; }

	// Methods

	// RVA: 0x79AEDFC Offset: 0x79AADFC VA: 0x79AEDFC
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Guid get_ID();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_SupportsSslStream();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_SupportsConnectionInfo();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_SupportsMonoExtensions();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract SslProtocols get_SupportedProtocols();

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract bool get_SupportsCleanShutdown();
}

// Namespace: Mono.Security.Interface
public static class MonoTlsProviderFactory // TypeDefIndex: 25756
{
	// Methods

	// RVA: 0x79AEE04 Offset: 0x79AAE04 VA: 0x79AEE04
	public static MonoTlsProvider GetProvider() { }
}

// Namespace: Mono.Security.Interface
public sealed class MonoTlsSettings // TypeDefIndex: 25757
{
	// Fields
	[CompilerGenerated]
	private MonoRemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField; // 0x10
	[CompilerGenerated]
	private MonoLocalCertificateSelectionCallback <ClientCertificateSelectionCallback>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<DateTime> <CertificateValidationTime>k__BackingField; // 0x20
	[CompilerGenerated]
	private X509CertificateCollection <TrustAnchors>k__BackingField; // 0x30
	[CompilerGenerated]
	private object <UserSettings>k__BackingField; // 0x38
	[CompilerGenerated]
	private string[] <CertificateSearchPaths>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <SendCloseNotify>k__BackingField; // 0x48
	[CompilerGenerated]
	private string[] <ClientCertificateIssuers>k__BackingField; // 0x50
	[CompilerGenerated]
	private bool <DisallowUnauthenticatedCertificateRequest>k__BackingField; // 0x58
	[CompilerGenerated]
	private Nullable<TlsProtocols> <EnabledProtocols>k__BackingField; // 0x5C
	[CompilerGenerated]
	private CipherSuiteCode[] <EnabledCiphers>k__BackingField; // 0x68
	private bool cloned; // 0x70
	private bool checkCertName; // 0x71
	private bool checkCertRevocationStatus; // 0x72
	private Nullable<bool> useServicePointManagerCallback; // 0x73
	private bool skipSystemValidators; // 0x75
	private bool callbackNeedsChain; // 0x76
	private ICertificateValidator certificateValidator; // 0x78
	private static MonoTlsSettings defaultSettings; // 0x0

	// Properties
	public MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback { get; set; }
	public MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback { get; set; }
	public Nullable<bool> UseServicePointManagerCallback { get; set; }
	public bool CallbackNeedsCertificateChain { get; }
	public Nullable<DateTime> CertificateValidationTime { get; set; }
	public X509CertificateCollection TrustAnchors { get; set; }
	public object UserSettings { get; set; }
	internal string[] CertificateSearchPaths { get; set; }
	internal bool SendCloseNotify { get; set; }
	public string[] ClientCertificateIssuers { get; set; }
	public bool DisallowUnauthenticatedCertificateRequest { get; set; }
	public Nullable<TlsProtocols> EnabledProtocols { get; set; }
	[CLSCompliant(False)]
	public CipherSuiteCode[] EnabledCiphers { get; set; }
	public static MonoTlsSettings DefaultSettings { get; }
	[Obsolete("Do not use outside System.dll!")]
	public ICertificateValidator CertificateValidator { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x79AEE74 Offset: 0x79AAE74 VA: 0x79AEE74
	public MonoRemoteCertificateValidationCallback get_RemoteCertificateValidationCallback() { }

	[CompilerGenerated]
	// RVA: 0x79AEE7C Offset: 0x79AAE7C VA: 0x79AEE7C
	public void set_RemoteCertificateValidationCallback(MonoRemoteCertificateValidationCallback value) { }

	[CompilerGenerated]
	// RVA: 0x79AEE84 Offset: 0x79AAE84 VA: 0x79AEE84
	public MonoLocalCertificateSelectionCallback get_ClientCertificateSelectionCallback() { }

	[CompilerGenerated]
	// RVA: 0x79AEE8C Offset: 0x79AAE8C VA: 0x79AEE8C
	public void set_ClientCertificateSelectionCallback(MonoLocalCertificateSelectionCallback value) { }

	// RVA: 0x79AEE94 Offset: 0x79AAE94 VA: 0x79AEE94
	public Nullable<bool> get_UseServicePointManagerCallback() { }

	// RVA: 0x79AEE9C Offset: 0x79AAE9C VA: 0x79AEE9C
	public void set_UseServicePointManagerCallback(Nullable<bool> value) { }

	// RVA: 0x79AEEA4 Offset: 0x79AAEA4 VA: 0x79AEEA4
	public bool get_CallbackNeedsCertificateChain() { }

	[CompilerGenerated]
	// RVA: 0x79AEEAC Offset: 0x79AAEAC VA: 0x79AEEAC
	public Nullable<DateTime> get_CertificateValidationTime() { }

	[CompilerGenerated]
	// RVA: 0x79AEEB8 Offset: 0x79AAEB8 VA: 0x79AEEB8
	public void set_CertificateValidationTime(Nullable<DateTime> value) { }

	[CompilerGenerated]
	// RVA: 0x79AEEC0 Offset: 0x79AAEC0 VA: 0x79AEEC0
	public X509CertificateCollection get_TrustAnchors() { }

	[CompilerGenerated]
	// RVA: 0x79AEEC8 Offset: 0x79AAEC8 VA: 0x79AEEC8
	public void set_TrustAnchors(X509CertificateCollection value) { }

	[CompilerGenerated]
	// RVA: 0x79AEED0 Offset: 0x79AAED0 VA: 0x79AEED0
	public object get_UserSettings() { }

	[CompilerGenerated]
	// RVA: 0x79AEED8 Offset: 0x79AAED8 VA: 0x79AEED8
	public void set_UserSettings(object value) { }

	[CompilerGenerated]
	// RVA: 0x79AEEE0 Offset: 0x79AAEE0 VA: 0x79AEEE0
	internal string[] get_CertificateSearchPaths() { }

	[CompilerGenerated]
	// RVA: 0x79AEEE8 Offset: 0x79AAEE8 VA: 0x79AEEE8
	internal void set_CertificateSearchPaths(string[] value) { }

	[CompilerGenerated]
	// RVA: 0x79AEEF0 Offset: 0x79AAEF0 VA: 0x79AEEF0
	internal bool get_SendCloseNotify() { }

	[CompilerGenerated]
	// RVA: 0x79AEEF8 Offset: 0x79AAEF8 VA: 0x79AEEF8
	internal void set_SendCloseNotify(bool value) { }

	[CompilerGenerated]
	// RVA: 0x79AEF04 Offset: 0x79AAF04 VA: 0x79AEF04
	public string[] get_ClientCertificateIssuers() { }

	[CompilerGenerated]
	// RVA: 0x79AEF0C Offset: 0x79AAF0C VA: 0x79AEF0C
	public void set_ClientCertificateIssuers(string[] value) { }

	[CompilerGenerated]
	// RVA: 0x79AEF14 Offset: 0x79AAF14 VA: 0x79AEF14
	public bool get_DisallowUnauthenticatedCertificateRequest() { }

	[CompilerGenerated]
	// RVA: 0x79AEF1C Offset: 0x79AAF1C VA: 0x79AEF1C
	public void set_DisallowUnauthenticatedCertificateRequest(bool value) { }

	[CompilerGenerated]
	// RVA: 0x79AEF28 Offset: 0x79AAF28 VA: 0x79AEF28
	public Nullable<TlsProtocols> get_EnabledProtocols() { }

	[CompilerGenerated]
	// RVA: 0x79AEF30 Offset: 0x79AAF30 VA: 0x79AEF30
	public void set_EnabledProtocols(Nullable<TlsProtocols> value) { }

	[CompilerGenerated]
	// RVA: 0x79AEF38 Offset: 0x79AAF38 VA: 0x79AEF38
	public CipherSuiteCode[] get_EnabledCiphers() { }

	[CompilerGenerated]
	// RVA: 0x79AEF40 Offset: 0x79AAF40 VA: 0x79AEF40
	public void set_EnabledCiphers(CipherSuiteCode[] value) { }

	// RVA: 0x79AEF48 Offset: 0x79AAF48 VA: 0x79AEF48
	public void .ctor() { }

	// RVA: 0x79AEF5C Offset: 0x79AAF5C VA: 0x79AEF5C
	public static MonoTlsSettings get_DefaultSettings() { }

	// RVA: 0x79AEFE8 Offset: 0x79AAFE8 VA: 0x79AEFE8
	public static MonoTlsSettings CopyDefaultSettings() { }

	// RVA: 0x79AF058 Offset: 0x79AB058 VA: 0x79AF058
	public ICertificateValidator get_CertificateValidator() { }

	[Obsolete("Do not use outside System.dll!")]
	// RVA: 0x79AF060 Offset: 0x79AB060 VA: 0x79AF060
	public MonoTlsSettings CloneWithValidator(ICertificateValidator validator) { }

	// RVA: 0x79AF000 Offset: 0x79AB000 VA: 0x79AF000
	public MonoTlsSettings Clone() { }

	// RVA: 0x79AF0EC Offset: 0x79AB0EC VA: 0x79AF0EC
	private void .ctor(MonoTlsSettings other) { }
}

// Namespace: Mono.Security.Interface
public sealed class TlsException : Exception // TypeDefIndex: 25758
{
	// Fields
	private Alert alert; // 0x90

	// Methods

	// RVA: 0x79AF280 Offset: 0x79AB280 VA: 0x79AF280
	public void .ctor(Alert alert, string message) { }

	// RVA: 0x79AF2FC Offset: 0x79AB2FC VA: 0x79AF2FC
	public void .ctor(AlertDescription description, string message) { }
}

// Namespace: Mono.Security.Interface
[Flags]
public enum TlsProtocols // TypeDefIndex: 25759
{
	// Fields
	public int value__; // 0x0
	public const TlsProtocols Zero = 0;
	public const TlsProtocols Tls10Client = 128;
	public const TlsProtocols Tls10Server = 64;
	public const TlsProtocols Tls10 = 192;
	public const TlsProtocols Tls11Client = 512;
	public const TlsProtocols Tls11Server = 256;
	public const TlsProtocols Tls11 = 768;
	public const TlsProtocols Tls12Client = 2048;
	public const TlsProtocols Tls12Server = 1024;
	public const TlsProtocols Tls12 = 3072;
	public const TlsProtocols ClientMask = 2688;
	public const TlsProtocols ServerMask = 1344;
}

// Namespace: Mono.Security.Cryptography
public sealed class CryptoConvert // TypeDefIndex: 25760
{
	// Methods

	// RVA: 0x79AF370 Offset: 0x79AB370 VA: 0x79AF370
	public static string ToHex(byte[] input) { }
}

// Namespace: Mono.Security.Cryptography
public abstract class MD2 : HashAlgorithm // TypeDefIndex: 25761
{
	// Methods

	// RVA: 0x79AF4AC Offset: 0x79AB4AC VA: 0x79AF4AC
	protected void .ctor() { }

	// RVA: 0x79AF4CC Offset: 0x79AB4CC VA: 0x79AF4CC
	public static MD2 Create() { }
}

// Namespace: Mono.Security.Cryptography
public class MD2Managed : MD2 // TypeDefIndex: 25762
{
	// Fields
	private byte[] state; // 0x28
	private byte[] checksum; // 0x30
	private byte[] buffer; // 0x38
	private int count; // 0x40
	private byte[] x; // 0x48
	private static readonly byte[] PI_SUBST; // 0x0

	// Methods

	// RVA: 0x79AF5F0 Offset: 0x79AB5F0 VA: 0x79AF5F0
	private byte[] Padding(int nLength) { }

	// RVA: 0x79AF51C Offset: 0x79AB51C VA: 0x79AF51C
	public void .ctor() { }

	// RVA: 0x79AF68C Offset: 0x79AB68C VA: 0x79AF68C Slot: 20
	public override void Initialize() { }

	// RVA: 0x79AF6EC Offset: 0x79AB6EC VA: 0x79AF6EC Slot: 18
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x79AFA2C Offset: 0x79ABA2C VA: 0x79AFA2C Slot: 19
	protected override byte[] HashFinal() { }

	// RVA: 0x79AF7C8 Offset: 0x79AB7C8 VA: 0x79AF7C8
	private void MD2Transform(byte[] state, byte[] checksum, byte[] block, int index) { }

	// RVA: 0x79AFB1C Offset: 0x79ABB1C VA: 0x79AFB1C
	private static void .cctor() { }
}

// Namespace: Mono.Security.Cryptography
public abstract class MD4 : HashAlgorithm // TypeDefIndex: 25763
{
	// Methods

	// RVA: 0x79AFBBC Offset: 0x79ABBBC VA: 0x79AFBBC
	protected void .ctor() { }

	// RVA: 0x79AFBDC Offset: 0x79ABBDC VA: 0x79AFBDC
	public static MD4 Create() { }
}

// Namespace: Mono.Security.Cryptography
public class MD4Managed : MD4 // TypeDefIndex: 25764
{
	// Fields
	private uint[] state; // 0x28
	private byte[] buffer; // 0x30
	private uint[] count; // 0x38
	private uint[] x; // 0x40
	private byte[] digest; // 0x48

	// Methods

	// RVA: 0x79AFC2C Offset: 0x79ABC2C VA: 0x79AFC2C
	public void .ctor() { }

	// RVA: 0x79AFD38 Offset: 0x79ABD38 VA: 0x79AFD38 Slot: 20
	public override void Initialize() { }

	// RVA: 0x79AFDEC Offset: 0x79ABDEC VA: 0x79AFDEC Slot: 18
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x79B0588 Offset: 0x79AC588 VA: 0x79B0588 Slot: 19
	protected override byte[] HashFinal() { }

	// RVA: 0x79B077C Offset: 0x79AC77C VA: 0x79B077C
	private byte[] Padding(int nLength) { }

	// RVA: 0x79B07F4 Offset: 0x79AC7F4 VA: 0x79B07F4
	private uint F(uint x, uint y, uint z) { }

	// RVA: 0x79B0804 Offset: 0x79AC804 VA: 0x79B0804
	private uint G(uint x, uint y, uint z) { }

	// RVA: 0x79B0818 Offset: 0x79AC818 VA: 0x79B0818
	private uint H(uint x, uint y, uint z) { }

	// RVA: 0x79B0824 Offset: 0x79AC824 VA: 0x79B0824
	private uint ROL(uint x, byte n) { }

	// RVA: 0x79B0830 Offset: 0x79AC830 VA: 0x79B0830
	private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x79B0858 Offset: 0x79AC858 VA: 0x79B0858
	private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x79B0890 Offset: 0x79AC890 VA: 0x79B0890
	private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x79B0684 Offset: 0x79AC684 VA: 0x79B0684
	private void Encode(byte[] output, uint[] input) { }

	// RVA: 0x79B08C0 Offset: 0x79AC8C0 VA: 0x79B08C0
	private void Decode(uint[] output, byte[] input, int index) { }

	// RVA: 0x79AFF10 Offset: 0x79ABF10 VA: 0x79AFF10
	private void MD4Transform(uint[] state, byte[] block, int index) { }
}

// Namespace: Mono.Security.Cryptography
public sealed class PKCS1 // TypeDefIndex: 25765
{
	// Fields
	private static byte[] emptySHA1; // 0x0
	private static byte[] emptySHA256; // 0x8
	private static byte[] emptySHA384; // 0x10
	private static byte[] emptySHA512; // 0x18

	// Methods

	// RVA: 0x79B0988 Offset: 0x79AC988 VA: 0x79B0988
	private static bool Compare(byte[] array1, byte[] array2) { }

	// RVA: 0x79B0A14 Offset: 0x79ACA14 VA: 0x79B0A14
	public static byte[] I2OSP(byte[] x, int size) { }

	// RVA: 0x79B0AA0 Offset: 0x79ACAA0 VA: 0x79B0AA0
	public static byte[] OS2IP(byte[] x) { }

	// RVA: 0x79B0B60 Offset: 0x79ACB60 VA: 0x79B0B60
	public static byte[] RSAVP1(RSA rsa, byte[] s) { }

	// RVA: 0x79B0B80 Offset: 0x79ACB80 VA: 0x79B0B80
	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding) { }

	// RVA: 0x79B0D5C Offset: 0x79ACD5C VA: 0x79B0D5C
	public static byte[] Encode_v15(HashAlgorithm hash, byte[] hashValue, int emLength) { }

	// RVA: 0x79B1090 Offset: 0x79AD090 VA: 0x79B1090
	internal static string HashNameFromOid(string oid, bool throwOnError = True) { }

	// RVA: 0x79B1498 Offset: 0x79AD498 VA: 0x79B1498
	internal static HashAlgorithm CreateFromOid(string oid) { }

	// RVA: 0x79B14F4 Offset: 0x79AD4F4 VA: 0x79B14F4
	internal static HashAlgorithm CreateFromName(string name) { }

	// RVA: 0x79B18F8 Offset: 0x79AD8F8 VA: 0x79B18F8
	private static void .cctor() { }
}

// Namespace: 
public class PKCS8.PrivateKeyInfo // TypeDefIndex: 25766
{
	// Fields
	private int _version; // 0x10
	private string _algorithm; // 0x18
	private byte[] _key; // 0x20
	private ArrayList _list; // 0x28

	// Properties
	public string Algorithm { get; }
	public byte[] PrivateKey { get; }

	// Methods

	// RVA: 0x79B1A6C Offset: 0x79ADA6C VA: 0x79B1A6C
	public void .ctor() { }

	// RVA: 0x79B1ADC Offset: 0x79ADADC VA: 0x79B1ADC
	public void .ctor(byte[] data) { }

	// RVA: 0x79B1D74 Offset: 0x79ADD74 VA: 0x79B1D74
	public string get_Algorithm() { }

	// RVA: 0x79B1D7C Offset: 0x79ADD7C VA: 0x79B1D7C
	public byte[] get_PrivateKey() { }

	// RVA: 0x79B1B04 Offset: 0x79ADB04 VA: 0x79B1B04
	private void Decode(byte[] data) { }

	// RVA: 0x79B1DF0 Offset: 0x79ADDF0 VA: 0x79B1DF0
	private static byte[] RemoveLeadingZero(byte[] bigInt) { }

	// RVA: 0x79B1E8C Offset: 0x79ADE8C VA: 0x79B1E8C
	private static byte[] Normalize(byte[] bigInt, int length) { }

	// RVA: 0x79B1F2C Offset: 0x79ADF2C VA: 0x79B1F2C
	public static RSA DecodeRSA(byte[] keypair) { }

	// RVA: 0x79B2388 Offset: 0x79AE388 VA: 0x79B2388
	public static byte[] Encode(RSA rsa) { }

	// RVA: 0x79B2584 Offset: 0x79AE584 VA: 0x79B2584
	public static DSA DecodeDSA(byte[] privateKey, DSAParameters dsaParameters) { }

	// RVA: 0x79B26B8 Offset: 0x79AE6B8 VA: 0x79B26B8
	public static byte[] Encode(DSA dsa) { }

	// RVA: 0x79B2708 Offset: 0x79AE708 VA: 0x79B2708
	public static byte[] Encode(AsymmetricAlgorithm aa) { }
}

// Namespace: 
public class PKCS8.EncryptedPrivateKeyInfo // TypeDefIndex: 25767
{
	// Fields
	private string _algorithm; // 0x10
	private byte[] _salt; // 0x18
	private int _iterations; // 0x20
	private byte[] _data; // 0x28

	// Properties
	public string Algorithm { get; }
	public byte[] EncryptedData { get; }
	public byte[] Salt { get; }
	public int IterationCount { get; }

	// Methods

	// RVA: 0x79B282C Offset: 0x79AE82C VA: 0x79B282C
	public void .ctor() { }

	// RVA: 0x79B2834 Offset: 0x79AE834 VA: 0x79B2834
	public void .ctor(byte[] data) { }

	// RVA: 0x79B2B2C Offset: 0x79AEB2C VA: 0x79B2B2C
	public string get_Algorithm() { }

	// RVA: 0x79B2B34 Offset: 0x79AEB34 VA: 0x79B2B34
	public byte[] get_EncryptedData() { }

	// RVA: 0x79B2BA8 Offset: 0x79AEBA8 VA: 0x79B2BA8
	public byte[] get_Salt() { }

	// RVA: 0x79B2C68 Offset: 0x79AEC68 VA: 0x79B2C68
	public int get_IterationCount() { }

	// RVA: 0x79B2860 Offset: 0x79AE860 VA: 0x79B2860
	private void Decode(byte[] data) { }
}

// Namespace: Mono.Security.Cryptography
public sealed class PKCS8 // TypeDefIndex: 25768
{}

// Namespace: 
public sealed class RSAManaged.KeyGeneratedEventHandler : MulticastDelegate // TypeDefIndex: 25769
{
	// Methods

	// RVA: 0x79B558C Offset: 0x79B158C VA: 0x79B558C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x79B5698 Offset: 0x79B1698 VA: 0x79B5698 Slot: 13
	public virtual void Invoke(object sender, EventArgs e) { }
}

// Namespace: Mono.Security.Cryptography
public class RSAManaged : RSA // TypeDefIndex: 25770
{
	// Fields
	private bool isCRTpossible; // 0x20
	private bool keyBlinding; // 0x21
	private bool keypairGenerated; // 0x22
	private bool m_disposed; // 0x23
	private BigInteger d; // 0x28
	private BigInteger p; // 0x30
	private BigInteger q; // 0x38
	private BigInteger dp; // 0x40
	private BigInteger dq; // 0x48
	private BigInteger qInv; // 0x50
	private BigInteger n; // 0x58
	private BigInteger e; // 0x60
	[CompilerGenerated]
	private RSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x68

	// Properties
	public override int KeySize { get; }
	public override string KeyExchangeAlgorithm { get; }
	public bool PublicOnly { get; }
	public override string SignatureAlgorithm { get; }

	// Methods

	// RVA: 0x79B2C70 Offset: 0x79AEC70 VA: 0x79B2C70
	public void .ctor() { }

	// RVA: 0x79B2C78 Offset: 0x79AEC78 VA: 0x79B2C78
	public void .ctor(int keySize) { }

	// RVA: 0x79B2D60 Offset: 0x79AED60 VA: 0x79B2D60 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x79B2E00 Offset: 0x79AEE00 VA: 0x79B2E00
	private void GenerateKeyPair() { }

	// RVA: 0x79B36F4 Offset: 0x79AF6F4 VA: 0x79B36F4 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x79B3790 Offset: 0x79AF790 VA: 0x79B3790 Slot: 10
	public override string get_KeyExchangeAlgorithm() { }

	// RVA: 0x79B37D0 Offset: 0x79AF7D0 VA: 0x79B37D0
	public bool get_PublicOnly() { }

	// RVA: 0x79B3920 Offset: 0x79AF920 VA: 0x79B3920 Slot: 9
	public override string get_SignatureAlgorithm() { }

	// RVA: 0x79B3960 Offset: 0x79AF960 VA: 0x79B3960 Slot: 34
	public override byte[] DecryptValue(byte[] rgb) { }

	// RVA: 0x79B4170 Offset: 0x79B0170 VA: 0x79B4170 Slot: 35
	public override byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x79B4278 Offset: 0x79B0278 VA: 0x79B4278 Slot: 36
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x79B4734 Offset: 0x79B0734 VA: 0x79B4734 Slot: 37
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x79B4C7C Offset: 0x79B0C7C VA: 0x79B4C7C Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x79B4F00 Offset: 0x79B0F00 VA: 0x79B4F00 Slot: 12
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: 0x79B40C0 Offset: 0x79B00C0 VA: 0x79B40C0
	private byte[] GetPaddedValue(BigInteger value, int length) { }
}

// Namespace: Mono.Security.Authenticode
public class AuthenticodeBase // TypeDefIndex: 25771
{
	// Fields
	private byte[] fileblock; // 0x10
	private Stream fs; // 0x18
	private int blockNo; // 0x20
	private int blockLength; // 0x24
	private int peOffset; // 0x28
	private int dirSecurityOffset; // 0x2C
	private int dirSecuritySize; // 0x30
	private int coffSymbolTableOffset; // 0x34
	private bool pe64; // 0x38

	// Properties
	internal int PEOffset { get; }

	// Methods

	// RVA: 0x79B56AC Offset: 0x79B16AC VA: 0x79B56AC
	public void .ctor() { }

	// RVA: 0x79B5710 Offset: 0x79B1710 VA: 0x79B5710
	internal int get_PEOffset() { }

	// RVA: 0x79B5808 Offset: 0x79B1808 VA: 0x79B5808
	internal void Open(string filename) { }

	// RVA: 0x79B58DC Offset: 0x79B18DC VA: 0x79B58DC
	internal void Open(byte[] rawdata) { }

	// RVA: 0x79B58A0 Offset: 0x79B18A0 VA: 0x79B58A0
	internal void Close() { }

	// RVA: 0x79B5738 Offset: 0x79B1738 VA: 0x79B5738
	internal void ReadFirstBlock() { }

	// RVA: 0x79B596C Offset: 0x79B196C VA: 0x79B596C
	internal int ProcessFirstBlock() { }

	// RVA: 0x79B5BA4 Offset: 0x79B1BA4 VA: 0x79B5BA4
	internal byte[] GetSecurityEntry() { }

	// RVA: 0x79B5C74 Offset: 0x79B1C74 VA: 0x79B5C74
	internal byte[] GetHash(HashAlgorithm hash) { }
}

// Namespace: Mono.Security.Authenticode
public class AuthenticodeDeformatter : AuthenticodeBase // TypeDefIndex: 25772
{
	// Fields
	private string filename; // 0x40
	private byte[] rawdata; // 0x48
	private byte[] hash; // 0x50
	private X509CertificateCollection coll; // 0x58
	private ASN1 signedHash; // 0x60
	private DateTime timestamp; // 0x68
	private X509Certificate signingCertificate; // 0x70
	private int reason; // 0x78
	private bool trustedRoot; // 0x7C
	private bool trustedTimestampRoot; // 0x7D
	private byte[] entry; // 0x80
	private X509Chain signerChain; // 0x88
	private X509Chain timestampChain; // 0x90

	// Properties
	public byte[] RawData { set; }
	public X509Certificate SigningCertificate { get; }

	// Methods

	// RVA: 0x79B60FC Offset: 0x79B20FC VA: 0x79B60FC
	public void .ctor() { }

	// RVA: 0x79B6190 Offset: 0x79B2190 VA: 0x79B6190
	public void .ctor(byte[] rawData) { }

	// RVA: 0x79B61B8 Offset: 0x79B21B8 VA: 0x79B61B8
	public void set_RawData(byte[] value) { }

	// RVA: 0x79B6670 Offset: 0x79B2670 VA: 0x79B6670
	public X509Certificate get_SigningCertificate() { }

	// RVA: 0x79B6388 Offset: 0x79B2388 VA: 0x79B6388
	private bool CheckSignature() { }

	// RVA: 0x79B70D0 Offset: 0x79B30D0 VA: 0x79B70D0
	private bool CompareIssuerSerial(string issuer, byte[] serial, X509Certificate x509) { }

	// RVA: 0x79B6678 Offset: 0x79B2678 VA: 0x79B6678
	private bool VerifySignature(PKCS7.SignedData sd, byte[] calculatedMessageDigest, HashAlgorithm ha) { }

	// RVA: 0x79B71CC Offset: 0x79B31CC VA: 0x79B71CC
	private bool VerifyCounterSignature(PKCS7.SignerInfo cs, byte[] signature) { }

	// RVA: 0x79B6294 Offset: 0x79B2294 VA: 0x79B6294
	private void Reset() { }
}

// Namespace: 
public enum BigInteger.Sign // TypeDefIndex: 25773
{
	// Fields
	public int value__; // 0x0
	public const BigInteger.Sign Negative = -1;
	public const BigInteger.Sign Zero = 0;
	public const BigInteger.Sign Positive = 1;
}

// Namespace: 
public sealed class BigInteger.ModulusRing // TypeDefIndex: 25774
{
	// Fields
	private BigInteger mod; // 0x10
	private BigInteger constant; // 0x18

	// Methods

	// RVA: 0x79B9CD8 Offset: 0x79B5CD8 VA: 0x79B9CD8
	public void .ctor(BigInteger modulus) { }

	// RVA: 0x79BA00C Offset: 0x79B600C VA: 0x79BA00C
	public void BarrettReduction(BigInteger x) { }

	// RVA: 0x79BA660 Offset: 0x79B6660 VA: 0x79BA660
	public BigInteger Multiply(BigInteger a, BigInteger b) { }

	// RVA: 0x79BA7DC Offset: 0x79B67DC VA: 0x79BA7DC
	public BigInteger Difference(BigInteger a, BigInteger b) { }

	// RVA: 0x79B9DD8 Offset: 0x79B5DD8 VA: 0x79B9DD8
	public BigInteger Pow(BigInteger a, BigInteger k) { }

	[CLSCompliant(False)]
	// RVA: 0x79BA990 Offset: 0x79B6990 VA: 0x79BA990
	public BigInteger Pow(uint b, BigInteger exp) { }
}

// Namespace: 
private sealed class BigInteger.Kernel // TypeDefIndex: 25775
{
	// Methods

	// RVA: 0x79B7F60 Offset: 0x79B3F60 VA: 0x79B7F60
	public static BigInteger AddSameSign(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x79B8280 Offset: 0x79B4280 VA: 0x79B8280
	public static BigInteger Subtract(BigInteger big, BigInteger small) { }

	// RVA: 0x79BA3A0 Offset: 0x79B63A0 VA: 0x79BA3A0
	public static void MinusEq(BigInteger big, BigInteger small) { }

	// RVA: 0x79BA4D0 Offset: 0x79B64D0 VA: 0x79BA4D0
	public static void PlusEq(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x79B813C Offset: 0x79B413C VA: 0x79B813C
	public static BigInteger.Sign Compare(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x79B94A4 Offset: 0x79B54A4 VA: 0x79B94A4
	public static uint SingleByteDivideInPlace(BigInteger n, uint d) { }

	// RVA: 0x79B8444 Offset: 0x79B4444 VA: 0x79B8444
	public static uint DwordMod(BigInteger n, uint d) { }

	// RVA: 0x79BAA00 Offset: 0x79B6A00 VA: 0x79BAA00
	public static BigInteger[] DwordDivMod(BigInteger n, uint d) { }

	// RVA: 0x79B84A8 Offset: 0x79B44A8 VA: 0x79B84A8
	public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x79B8AA4 Offset: 0x79B4AA4 VA: 0x79B8AA4
	public static BigInteger LeftShift(BigInteger bi, int n) { }

	// RVA: 0x79B8C8C Offset: 0x79B4C8C VA: 0x79B8C8C
	public static BigInteger RightShift(BigInteger bi, int n) { }

	// RVA: 0x79B89A4 Offset: 0x79B49A4 VA: 0x79B89A4
	public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset) { }

	// RVA: 0x79BA264 Offset: 0x79B6264 VA: 0x79BA264
	public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod) { }

	// RVA: 0x79BABA0 Offset: 0x79B6BA0 VA: 0x79BABA0
	public static uint modInverse(BigInteger bi, uint modulus) { }

	// RVA: 0x79B96C0 Offset: 0x79B56C0 VA: 0x79B96C0
	public static BigInteger modInverse(BigInteger bi, BigInteger modulus) { }
}

// Namespace: Mono.Math
public class BigInteger // TypeDefIndex: 25776
{
	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x79B7BBC Offset: 0x79B3BBC VA: 0x79B7BBC
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x79B7C3C Offset: 0x79B3C3C VA: 0x79B7C3C
	public void .ctor(BigInteger bi) { }

	[CLSCompliant(False)]
	// RVA: 0x79B7D24 Offset: 0x79B3D24 VA: 0x79B7D24
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x79B3C70 Offset: 0x79AFC70 VA: 0x79B3C70
	public void .ctor(byte[] inData) { }

	[CLSCompliant(False)]
	// RVA: 0x79B7E64 Offset: 0x79B3E64 VA: 0x79B7E64
	public void .ctor(uint ui) { }

	[CLSCompliant(False)]
	// RVA: 0x79B3114 Offset: 0x79AF114 VA: 0x79B3114
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x79B34B4 Offset: 0x79AF4B4 VA: 0x79B34B4
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x79B3F94 Offset: 0x79AFF94 VA: 0x79B3F94
	public static BigInteger op_Addition(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x79B3558 Offset: 0x79AF558 VA: 0x79B3558
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliant(False)]
	// RVA: 0x79B31D8 Offset: 0x79AF1D8 VA: 0x79B31D8
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x79B36C8 Offset: 0x79AF6C8 VA: 0x79B36C8
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x79B897C Offset: 0x79B497C VA: 0x79B897C
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x79B328C Offset: 0x79AF28C VA: 0x79B328C
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x79B8AA0 Offset: 0x79B4AA0 VA: 0x79B8AA0
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x79B8C88 Offset: 0x79B4C88 VA: 0x79B8C88
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x79B8E04 Offset: 0x79B4E04 VA: 0x79B8E04
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x79B8EB0 Offset: 0x79B4EB0 VA: 0x79B8EB0
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x79B3EA8 Offset: 0x79AFEA8 VA: 0x79B3EA8
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x79B3434 Offset: 0x79AF434 VA: 0x79B3434
	public int BitCount() { }

	// RVA: 0x79B9010 Offset: 0x79B5010 VA: 0x79B9010
	public bool TestBit(int bitNum) { }

	[CLSCompliant(False)]
	// RVA: 0x79B90A4 Offset: 0x79B50A4 VA: 0x79B90A4
	public void SetBit(uint bitNum) { }

	[CLSCompliant(False)]
	// RVA: 0x79B90AC Offset: 0x79B50AC VA: 0x79B90AC
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x79B9108 Offset: 0x79B5108 VA: 0x79B9108
	public int LowestSetBit() { }

	// RVA: 0x79B4600 Offset: 0x79B0600 VA: 0x79B4600
	public byte[] GetBytes() { }

	[CLSCompliant(False)]
	// RVA: 0x79B7EF4 Offset: 0x79B3EF4 VA: 0x79B7EF4
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	[CLSCompliant(False)]
	// RVA: 0x79B9184 Offset: 0x79B5184 VA: 0x79B9184
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x79B3870 Offset: 0x79AF870 VA: 0x79B3870
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x79B31DC Offset: 0x79AF1DC VA: 0x79B31DC
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x79B3F7C Offset: 0x79AFF7C VA: 0x79B3F7C
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x79B34A0 Offset: 0x79AF4A0 VA: 0x79B34A0
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x79B91F0 Offset: 0x79B51F0 VA: 0x79B91F0
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x79B9208 Offset: 0x79B5208 VA: 0x79B9208
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliant(False)]
	// RVA: 0x79B9220 Offset: 0x79B5220 VA: 0x79B9220
	public string ToString(uint radix) { }

	[CLSCompliant(False)]
	// RVA: 0x79B9278 Offset: 0x79B5278 VA: 0x79B9278
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x79B7E0C Offset: 0x79B3E0C VA: 0x79B7E0C
	private void Normalize() { }

	// RVA: 0x79B4070 Offset: 0x79B0070 VA: 0x79B4070
	public void Clear() { }

	// RVA: 0x79B9518 Offset: 0x79B5518 VA: 0x79B9518 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x79B9570 Offset: 0x79B5570 VA: 0x79B9570 Slot: 3
	public override string ToString() { }

	// RVA: 0x79B9578 Offset: 0x79B5578 VA: 0x79B9578 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x79B36C4 Offset: 0x79AF6C4 VA: 0x79B36C4
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x79B3F04 Offset: 0x79AFF04 VA: 0x79B3F04
	public BigInteger ModPow(BigInteger exp, BigInteger n) { }

	// RVA: 0x79B316C Offset: 0x79AF16C VA: 0x79B316C
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x79B9EE4 Offset: 0x79B5EE4 VA: 0x79B9EE4
	public void Incr2() { }

	// RVA: 0x79B9F6C Offset: 0x79B5F6C VA: 0x79B9F6C
	private static void .cctor() { }
}

// Namespace: Mono.Math.Prime
public enum ConfidenceFactor // TypeDefIndex: 25777
{
	// Fields
	public int value__; // 0x0
	public const ConfidenceFactor ExtraLow = 0;
	public const ConfidenceFactor Low = 1;
	public const ConfidenceFactor Medium = 2;
	public const ConfidenceFactor High = 3;
	public const ConfidenceFactor ExtraHigh = 4;
	public const ConfidenceFactor Provable = 5;
}

// Namespace: Mono.Math.Prime
public sealed class PrimalityTest : MulticastDelegate // TypeDefIndex: 25778
{
	// Methods

	// RVA: 0x79BAC60 Offset: 0x79B6C60 VA: 0x79BAC60
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x79BAD6C Offset: 0x79B6D6C VA: 0x79BAD6C Slot: 13
	public virtual bool Invoke(BigInteger bi, ConfidenceFactor confidence) { }
}

// Namespace: Mono.Math.Prime
public sealed class PrimalityTests // TypeDefIndex: 25779
{
	// Methods

	// RVA: 0x79BAD80 Offset: 0x79B6D80 VA: 0x79BAD80
	private static int GetSPPRounds(BigInteger bi, ConfidenceFactor confidence) { }

	// RVA: 0x79BAF0C Offset: 0x79B6F0C VA: 0x79BAF0C
	public static bool RabinMillerTest(BigInteger n, ConfidenceFactor confidence) { }
}

// Namespace: Mono.Math.Prime.Generator
public abstract class PrimeGeneratorBase // TypeDefIndex: 25780
{
	// Properties
	public virtual ConfidenceFactor Confidence { get; }
	public virtual PrimalityTest PrimalityTest { get; }
	public virtual int TrialDivisionBounds { get; }

	// Methods

	// RVA: 0x79BB1A4 Offset: 0x79B71A4 VA: 0x79BB1A4 Slot: 4
	public virtual ConfidenceFactor get_Confidence() { }

	// RVA: 0x79BB1AC Offset: 0x79B71AC VA: 0x79BB1AC Slot: 5
	public virtual PrimalityTest get_PrimalityTest() { }

	// RVA: 0x79BB218 Offset: 0x79B7218 VA: 0x79BB218 Slot: 6
	public virtual int get_TrialDivisionBounds() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract BigInteger GenerateNewPrime(int bits);

	// RVA: 0x79BB220 Offset: 0x79B7220 VA: 0x79BB220
	protected void .ctor() { }
}

// Namespace: Mono.Math.Prime.Generator
public class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase // TypeDefIndex: 25781
{
	// Methods

	// RVA: 0x79BB228 Offset: 0x79B7228 VA: 0x79BB228 Slot: 8
	protected virtual BigInteger GenerateSearchBase(int bits, object context) { }

	// RVA: 0x79BB29C Offset: 0x79B729C VA: 0x79BB29C Slot: 7
	public override BigInteger GenerateNewPrime(int bits) { }

	// RVA: 0x79BB2AC Offset: 0x79B72AC VA: 0x79BB2AC Slot: 9
	public virtual BigInteger GenerateNewPrime(int bits, object context) { }

	// RVA: 0x79BB590 Offset: 0x79B7590 VA: 0x79BB590 Slot: 10
	protected virtual bool IsPrimeAcceptable(BigInteger bi, object context) { }

	// RVA: 0x79B9EDC Offset: 0x79B5EDC VA: 0x79B9EDC
	public void .ctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 // TypeDefIndex: 25782
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 // TypeDefIndex: 25783
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 // TypeDefIndex: 25784
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=18 // TypeDefIndex: 25785
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 // TypeDefIndex: 25786
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 // TypeDefIndex: 25787
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 // TypeDefIndex: 25788
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 // TypeDefIndex: 25789
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 // TypeDefIndex: 25790
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3132 // TypeDefIndex: 25791
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 25792
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 001D686DB504E20C792EAA07FE09224A45FF328E24A80072D04D16ABC5C2B5D2 /*Metadata offset 0xF41AE8*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3132 25E3E48132FBDBE9B7C0C6C54D7C10A5DE12A105AA3E5DE2A0DC808BF245B7A5 /*Metadata offset 0xF41B30*/; // 0x40
	internal static readonly long 290C4A052C215D096172EB81AEE671FB3286E5C1DB5E73F96021FC09825DDB88 = 2676302836908902219; // 0xC80
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 32D0830B8EE1D49A66F395C8EA80E02BFC07C2A12A8EA8C8B484AF02108A1950 /*Metadata offset 0xF42780*/; // 0xC88
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 35BF50EEF3270FD8CA09E66FC5B0481C5A151B14F6A634854E32F63633D49DCB /*Metadata offset 0xF42788*/; // 0xC8B
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 3C0C410618682C4DF0474E034114CC8E562F05A512B521AC367571017BDFA75D /*Metadata offset 0xF42790*/; // 0xC8E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 44F5B1A2C48314502ACCBF186D1A2F9F7F176825898F32F1A2047B956194F174 /*Metadata offset 0xF42798*/; // 0xC91
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 4800FBFC4566EB02D1727A4B1C949CCBC7535C216A0766564C199308631B5DD6 /*Metadata offset 0xF427A0*/; // 0xC94
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 533B8C444F951E83EFF7305E3807B66CE0005DE0A2D0A44873C130895A3BE6AA /*Metadata offset 0xF427D8*/; // 0xCC4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 55D0BF716B334D123E0088CFB3F8E2FEA17AF5025BB527F95EEB09BA978EA329 /*Metadata offset 0xF427F0*/; // 0xCD8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 59BE5A634187B8A57216EFF5371A47732C05744B1C1A0A6382A6D5622C9FFDCE /*Metadata offset 0xF428F8*/; // 0xDD8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 5DF6E0E2761359D30A8275058E299FCC0381534545F55CF43E41983F5D4C9456 /*Metadata offset 0xF42900*/; // 0xDDB
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 5F8C6B3C66B972606D85E7651F67ADBD02E8316876884674E8328FA710747E5B /*Metadata offset 0xF42928*/; // 0xDFB
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 60C6ED13AF98DBFEEDA8F8197FFFCC349BB04395CC81DF0D477CBC57BF5B398B /*Metadata offset 0xF42930*/; // 0xDFE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 64B3E7D737AFF47D4C3BBD81D2D06D697DDD8EB60F29E13E4425D19D8BBCA1F7 /*Metadata offset 0xF42940*/; // 0xE08
	internal static readonly long 6772A9B8BF207A3CFE6EE68769D6985B69522183F24A2A3D41BC3B4602953426 = 22609615381091406; // 0xE18
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 684312AFB7719E57993D2826FFBAF7EA965614F20F91D999FB19B01E21AA62E6 /*Metadata offset 0xF42960*/; // 0xE20
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 6AA56C4BCD208911792AD24C7681FEFB93BED51903AFC54860C9BD37E41E5A31 /*Metadata offset 0xF42970*/; // 0xE29
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 796E63069E193A008CB4E85573AA1FE53C5F4E58B42A7F61FD0EEE1D89B5120B /*Metadata offset 0xF429B8*/; // 0xE69
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 7C8975E1E60A5C8337F28EDF8C33C3B180360B7279644A9BC1AF3C51E6220BF5 /*Metadata offset 0xF429C0*/; // 0xE6C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 850D7367E4FB0766E2CBC3ACF5AB42B4E98348E58E5A789845D4FCCDB63D2AEE /*Metadata offset 0xF42A08*/; // 0xEAC
	internal static readonly long 992F16C986809AB68C7466CC3EC6F12B2506A962EA539753E5D84A2FB7FF8A24 = -1295888024253181014; // 0xEB0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 9A65C09A11757751BFED67A414E00B188DC4C7757FCB6CBD33A916DDE4A3D925 /*Metadata offset 0xF42A20*/; // 0xEB8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=18 9ACEFCC0C950280B64AB9E045E38C34ABF71EC70A0DC61B9C621C6BFB4F78047 /*Metadata offset 0xF42A28*/; // 0xEBB
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 B1E34F4A11EE411B83415EF0B252A0B2BBCFCAC2E592865E09C12E4252C93A75 /*Metadata offset 0xF42A40*/; // 0xECD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 C92FAD7F348A682E7D5B7E74C76B5D019174EE7BC87545B25A1FDD49FBCC2D0B /*Metadata offset 0xF42A48*/; // 0xED0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 E17B8359E685992B0DE6242AAA24FCB7404173CBB7FF8646FF7D658139F41B5F /*Metadata offset 0xF42A50*/; // 0xED3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 F83B332BE4E6A5A4B1C56AAF6DB52657DA495E149870057D8590AB9D7A6167AD /*Metadata offset 0xF42A58*/; // 0xED6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 FB6D7301FFDCB5FBA5807A19B4F0606947897C1105240B6BBA815352DBBE2064 /*Metadata offset 0xF42AA0*/; // 0xF16

	// Methods

	// RVA: 0x79B141C Offset: 0x79AD41C VA: 0x79B141C
	internal static uint ComputeStringHash(string s) { }
}

