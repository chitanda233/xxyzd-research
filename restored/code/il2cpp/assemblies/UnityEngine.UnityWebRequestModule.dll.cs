// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 27886
{}

// Namespace: UnityEngineInternal
internal static class WebRequestUtils // TypeDefIndex: 27887
{
	// Fields
	private static Regex domainRegex; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x89B9784 Offset: 0x89B5784 VA: 0x89B9784
	internal static string RedirectTo(string baseUri, string redirectUri) { }

	// RVA: 0x89B9870 Offset: 0x89B5870 VA: 0x89B9870
	internal static string MakeInitialUrl(string targetUrl, string localUrl) { }

	// RVA: 0x89B9BE0 Offset: 0x89B5BE0 VA: 0x89B9BE0
	internal static string MakeUriString(Uri targetUri, string targetUrl, bool prependProtocol) { }

	// RVA: 0x89B9FC4 Offset: 0x89B5FC4 VA: 0x89B9FC4
	private static string URLDecode(string encoded) { }

	// RVA: 0x89BA0CC Offset: 0x89B60CC VA: 0x89BA0CC
	private static void .cctor() { }
}

// Namespace: UnityEngine
public class WWWForm // TypeDefIndex: 27888
{
	// Fields
	private List<byte[]> formData; // 0x10
	private List<string> fieldNames; // 0x18
	private List<string> fileNames; // 0x20
	private List<string> types; // 0x28
	private byte[] boundary; // 0x30
	private bool containsFiles; // 0x38
	private static byte[] dDash; // 0x0
	private static byte[] crlf; // 0x8
	private static byte[] contentTypeHeader; // 0x10
	private static byte[] dispositionHeader; // 0x18
	private static byte[] endQuote; // 0x20
	private static byte[] fileNameField; // 0x28
	private static byte[] ampersand; // 0x30
	private static byte[] equal; // 0x38

	// Properties
	internal static Encoding DefaultEncoding { get; }
	public Dictionary<string, string> headers { get; }
	public byte[] data { get; }

	// Methods

	// RVA: 0x89BA168 Offset: 0x89B6168 VA: 0x89BA168
	internal static Encoding get_DefaultEncoding() { }

	// RVA: 0x89BA170 Offset: 0x89B6170 VA: 0x89BA170
	public void .ctor() { }

	// RVA: 0x89BA328 Offset: 0x89B6328 VA: 0x89BA328
	public void AddField(string fieldName, string value) { }

	// RVA: 0x89BA360 Offset: 0x89B6360 VA: 0x89BA360
	public void AddField(string fieldName, string value, Encoding e) { }

	[ExcludeFromDocs]
	// RVA: 0x89BA5D0 Offset: 0x89B65D0 VA: 0x89BA5D0
	public void AddBinaryData(string fieldName, byte[] contents, string fileName) { }

	// RVA: 0x89BA5D8 Offset: 0x89B65D8 VA: 0x89BA5D8
	public void AddBinaryData(string fieldName, byte[] contents, string fileName, string mimeType) { }

	// RVA: 0x89BA8F0 Offset: 0x89B68F0 VA: 0x89BA8F0
	public Dictionary<string, string> get_headers() { }

	// RVA: 0x89BAA3C Offset: 0x89B6A3C VA: 0x89BAA3C
	public byte[] get_data() { }

	// RVA: 0x89BBAF8 Offset: 0x89B7AF8 VA: 0x89BBAF8
	private static void .cctor() { }
}

// Namespace: UnityEngine
[VisibleToOtherModules(new[] { "UnityEngine.UnityWebRequestWWWModule" })]
internal class WWWTranscoder // TypeDefIndex: 27889
{
	// Fields
	private static byte[] ucHexChars; // 0x0
	private static byte[] lcHexChars; // 0x8
	private static byte urlEscapeChar; // 0x10
	private static byte[] urlSpace; // 0x18
	private static byte[] dataSpace; // 0x20
	private static byte[] urlForbidden; // 0x28
	private static byte qpEscapeChar; // 0x30
	private static byte[] qpSpace; // 0x38
	private static byte[] qpForbidden; // 0x40

	// Methods

	// RVA: 0x89BBD90 Offset: 0x89B7D90 VA: 0x89BBD90
	private static byte Hex2Byte(byte[] b, int offset) { }

	// RVA: 0x89BBE3C Offset: 0x89B7E3C VA: 0x89BBE3C
	private static void Byte2Hex(byte b, byte[] hexChars, out byte byte0, out byte byte1) { }

	// RVA: 0x89BBE90 Offset: 0x89B7E90 VA: 0x89BBE90
	public static byte[] URLEncode(byte[] toEncode) { }

	// RVA: 0x89BC2D8 Offset: 0x89B82D8 VA: 0x89BC2D8
	public static string DataEncode(string toEncode) { }

	// RVA: 0x89BC340 Offset: 0x89B8340 VA: 0x89BC340
	public static string DataEncode(string toEncode, Encoding e) { }

	// RVA: 0x89BBA90 Offset: 0x89B7A90 VA: 0x89BBA90
	public static byte[] DataEncode(byte[] toEncode) { }

	// RVA: 0x89BB99C Offset: 0x89B799C VA: 0x89BB99C
	public static string QPEncode(string toEncode, Encoding e) { }

	// RVA: 0x89BBEFC Offset: 0x89B7EFC VA: 0x89BBEFC
	public static byte[] Encode(byte[] input, byte escapeChar, byte[] space, byte[] forbidden, bool uppercase) { }

	// RVA: 0x89BC434 Offset: 0x89B8434 VA: 0x89BC434
	private static bool ByteArrayContains(byte[] array, byte b) { }

	// RVA: 0x89BA068 Offset: 0x89B6068 VA: 0x89BA068
	public static byte[] URLDecode(byte[] toEncode) { }

	// RVA: 0x89BC7B4 Offset: 0x89B87B4 VA: 0x89BC7B4
	private static bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand) { }

	// RVA: 0x89BC49C Offset: 0x89B849C VA: 0x89BC49C
	public static byte[] Decode(byte[] input, byte escapeChar, byte[] space) { }

	// RVA: 0x89BB828 Offset: 0x89B7828 VA: 0x89BB828
	public static bool SevenBitClean(string s, Encoding e) { }

	// RVA: 0x89BC844 Offset: 0x89B8844 VA: 0x89BC844
	public static bool SevenBitClean(byte* input, int inputLength) { }

	// RVA: 0x89BC8A0 Offset: 0x89B88A0 VA: 0x89BC8A0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/CertificateHandler/CertificateHandlerScript.h")]
public class CertificateHandler : IDisposable // TypeDefIndex: 27890
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x89BCB20 Offset: 0x89B8B20 VA: 0x89BCB20
	private static IntPtr Create(CertificateHandler obj) { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x89BCB5C Offset: 0x89B8B5C VA: 0x89BCB5C
	private void Release() { }

	// RVA: 0x89BCB98 Offset: 0x89B8B98 VA: 0x89BCB98
	protected void .ctor() { }

	// RVA: 0x89BCBE4 Offset: 0x89B8BE4 VA: 0x89BCBE4 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x89BCCD0 Offset: 0x89B8CD0 VA: 0x89BCCD0 Slot: 5
	protected virtual bool ValidateCertificate(byte[] certificateData) { }

	[RequiredByNativeCode]
	// RVA: 0x89BCCD8 Offset: 0x89B8CD8 VA: 0x89BCCD8
	internal bool ValidateCertificateNative(byte[] certificateData) { }

	// RVA: 0x89BCC78 Offset: 0x89B8C78 VA: 0x89BCC78 Slot: 4
	public void Dispose() { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandler.h")]
public class DownloadHandler : IDisposable // TypeDefIndex: 27891
{
	// Fields
	[VisibleToOtherModules]
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public bool isDone { get; }
	public string error { get; }
	public NativeArray.ReadOnly<byte> nativeData { get; }
	public byte[] data { get; }
	public string text { get; }

	// Methods

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x89BCCE4 Offset: 0x89B8CE4 VA: 0x89BCCE4
	private void Release() { }

	[VisibleToOtherModules]
	// RVA: 0x89BCD20 Offset: 0x89B8D20 VA: 0x89BCD20
	internal void .ctor() { }

	// RVA: 0x89BCD28 Offset: 0x89B8D28 VA: 0x89BCD28 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x89BCDC4 Offset: 0x89B8DC4 VA: 0x89BCDC4 Slot: 5
	public virtual void Dispose() { }

	// RVA: 0x89BCE1C Offset: 0x89B8E1C VA: 0x89BCE1C
	public bool get_isDone() { }

	// RVA: 0x89BCE58 Offset: 0x89B8E58 VA: 0x89BCE58
	private bool IsDone() { }

	// RVA: 0x89BCE94 Offset: 0x89B8E94 VA: 0x89BCE94
	public string get_error() { }

	// RVA: 0x89BCED0 Offset: 0x89B8ED0 VA: 0x89BCED0
	private string GetErrorMsg() { }

	// RVA: 0x89BCF0C Offset: 0x89B8F0C VA: 0x89BCF0C
	public NativeArray.ReadOnly<byte> get_nativeData() { }

	// RVA: 0x89BCF7C Offset: 0x89B8F7C VA: 0x89BCF7C
	public byte[] get_data() { }

	// RVA: 0x89BCF88 Offset: 0x89B8F88 VA: 0x89BCF88
	public string get_text() { }

	// RVA: 0x89BCF94 Offset: 0x89B8F94 VA: 0x89BCF94 Slot: 6
	protected virtual NativeArray<byte> GetNativeData() { }

	// RVA: 0x89BCFA0 Offset: 0x89B8FA0 VA: 0x89BCFA0 Slot: 7
	protected virtual byte[] GetData() { }

	// RVA: 0x89BD028 Offset: 0x89B9028 VA: 0x89BD028 Slot: 8
	protected virtual string GetText() { }

	// RVA: 0x89BD0E8 Offset: 0x89B90E8 VA: 0x89BD0E8
	private Encoding GetTextEncoder() { }

	// RVA: 0x89BD358 Offset: 0x89B9358 VA: 0x89BD358
	private string GetContentType() { }

	[RequiredByNativeCode]
	// RVA: 0x89BD394 Offset: 0x89B9394 VA: 0x89BD394 Slot: 9
	protected virtual bool ReceiveData(byte[] data, int dataLength) { }

	[RequiredByNativeCode]
	// RVA: 0x89BD39C Offset: 0x89B939C VA: 0x89BD39C Slot: 10
	protected virtual void ReceiveContentLengthHeader(ulong contentLength) { }

	[Obsolete("Use ReceiveContentLengthHeader")]
	// RVA: 0x89BD3A8 Offset: 0x89B93A8 VA: 0x89BD3A8 Slot: 11
	protected virtual void ReceiveContentLength(int contentLength) { }

	[RequiredByNativeCode]
	// RVA: 0x89BD3AC Offset: 0x89B93AC VA: 0x89BD3AC Slot: 12
	protected virtual void CompleteContent() { }

	[RequiredByNativeCode]
	// RVA: 0x89BD3B0 Offset: 0x89B93B0 VA: 0x89BD3B0 Slot: 13
	protected virtual float GetProgress() { }

	// RVA: -1 Offset: -1
	protected static T GetCheckedDownloader<T>(UnityWebRequest www) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4574330 Offset: 0x4570330 VA: 0x4574330
	|-DownloadHandler.GetCheckedDownloader<object>
	*/

	[VisibleToOtherModules]
	[NativeThrows]
	// RVA: 0x89BD3B8 Offset: 0x89B93B8 VA: 0x89BD3B8
	internal static byte* InternalGetByteArray(DownloadHandler dh, out int length) { }

	// RVA: 0x89BCFA4 Offset: 0x89B8FA4 VA: 0x89BCFA4
	internal static byte[] InternalGetByteArray(DownloadHandler dh) { }

	// RVA: 0x89BD3FC Offset: 0x89B93FC VA: 0x89BD3FC
	internal static NativeArray<byte> InternalGetNativeArray(DownloadHandler dh, ref NativeArray<byte> nativeArray) { }

	// RVA: 0x89BD4D4 Offset: 0x89B94D4 VA: 0x89BD4D4
	internal static void DisposeNativeArray(ref NativeArray<byte> data) { }

	// RVA: 0x89BD518 Offset: 0x89B9518 VA: 0x89BD518
	internal static void CreateNativeArrayForNativeData(ref NativeArray<byte> data, byte* bytes, int length) { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandlerBuffer.h")]
public sealed class DownloadHandlerBuffer : DownloadHandler // TypeDefIndex: 27892
{
	// Fields
	private NativeArray<byte> m_NativeData; // 0x18

	// Methods

	// RVA: 0x89BD580 Offset: 0x89B9580 VA: 0x89BD580
	private static IntPtr Create(DownloadHandlerBuffer obj) { }

	// RVA: 0x89BD5BC Offset: 0x89B95BC VA: 0x89BD5BC
	private void InternalCreateBuffer() { }

	// RVA: 0x89BD600 Offset: 0x89B9600 VA: 0x89BD600
	public void .ctor() { }

	// RVA: 0x89BD64C Offset: 0x89B964C VA: 0x89BD64C Slot: 6
	protected override NativeArray<byte> GetNativeData() { }

	// RVA: 0x89BD654 Offset: 0x89B9654 VA: 0x89BD654 Slot: 5
	public override void Dispose() { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandlerVFS.h")]
public sealed class DownloadHandlerFile : DownloadHandler // TypeDefIndex: 27893
{
	// Methods

	[NativeThrows]
	// RVA: 0x89BD6A0 Offset: 0x89B96A0 VA: 0x89BD6A0
	private static IntPtr Create(DownloadHandlerFile obj, string path, bool append) { }

	// RVA: 0x89BD6F4 Offset: 0x89B96F4 VA: 0x89BD6F4
	private void InternalCreateVFS(string path, bool append) { }

	// RVA: 0x89BD7B0 Offset: 0x89B97B0 VA: 0x89BD7B0
	public void .ctor(string path) { }

	// RVA: 0x89BD7E0 Offset: 0x89B97E0 VA: 0x89BD7E0
	public void .ctor(string path, bool append) { }

	// RVA: 0x89BD814 Offset: 0x89B9814 VA: 0x89BD814 Slot: 6
	protected override NativeArray<byte> GetNativeData() { }

	// RVA: 0x89BD860 Offset: 0x89B9860 VA: 0x89BD860 Slot: 7
	protected override byte[] GetData() { }

	// RVA: 0x89BD8AC Offset: 0x89B98AC VA: 0x89BD8AC Slot: 8
	protected override string GetText() { }
}

// Namespace: UnityEngine.Networking
public interface IMultipartFormSection // TypeDefIndex: 27894
{
	// Properties
	public abstract string sectionName { get; }
	public abstract byte[] sectionData { get; }
	public abstract string fileName { get; }
	public abstract string contentType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_sectionName();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract byte[] get_sectionData();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_fileName();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_contentType();
}

// Namespace: UnityEngine.Networking
public class MultipartFormDataSection : IMultipartFormSection // TypeDefIndex: 27895
{
	// Fields
	private string name; // 0x10
	private byte[] data; // 0x18
	private string content; // 0x20

	// Properties
	public string sectionName { get; }
	public byte[] sectionData { get; }
	public string fileName { get; }
	public string contentType { get; }

	// Methods

	// RVA: 0x89BD8F8 Offset: 0x89B98F8 VA: 0x89BD8F8
	public void .ctor(string name, byte[] data, string contentType) { }

	// RVA: 0x89BD9B0 Offset: 0x89B99B0 VA: 0x89BD9B0
	public void .ctor(string name, byte[] data) { }

	// RVA: 0x89BD9B8 Offset: 0x89B99B8 VA: 0x89BD9B8
	public void .ctor(byte[] data) { }

	// RVA: 0x89BD9C8 Offset: 0x89B99C8 VA: 0x89BD9C8
	public void .ctor(string name, string data, Encoding encoding, string contentType) { }

	// RVA: 0x89BDB40 Offset: 0x89B9B40 VA: 0x89BDB40
	public void .ctor(string name, string data, string contentType) { }

	// RVA: 0x89BDB88 Offset: 0x89B9B88 VA: 0x89BDB88
	public void .ctor(string name, string data) { }

	// RVA: 0x89BDBF8 Offset: 0x89B9BF8 VA: 0x89BDBF8
	public void .ctor(string data) { }

	// RVA: 0x89BDC04 Offset: 0x89B9C04 VA: 0x89BDC04 Slot: 4
	public string get_sectionName() { }

	// RVA: 0x89BDC0C Offset: 0x89B9C0C VA: 0x89BDC0C Slot: 5
	public byte[] get_sectionData() { }

	// RVA: 0x89BDC14 Offset: 0x89B9C14 VA: 0x89BDC14 Slot: 6
	public string get_fileName() { }

	// RVA: 0x89BDC1C Offset: 0x89B9C1C VA: 0x89BDC1C Slot: 7
	public string get_contentType() { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequestAsyncOperation.h")]
[UsedByNativeCode]
[NativeHeader("UnityWebRequestScriptingClasses.h")]
public class UnityWebRequestAsyncOperation : AsyncOperation // TypeDefIndex: 27896
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private UnityWebRequest <webRequest>k__BackingField; // 0x20

	// Properties
	public UnityWebRequest webRequest { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x89BDC24 Offset: 0x89B9C24 VA: 0x89BDC24
	public UnityWebRequest get_webRequest() { }

	[CompilerGenerated]
	// RVA: 0x89BDC2C Offset: 0x89B9C2C VA: 0x89BDC2C
	internal void set_webRequest(UnityWebRequest value) { }

	// RVA: 0x89BDC34 Offset: 0x89B9C34 VA: 0x89BDC34
	public void .ctor() { }
}

// Namespace: 
internal enum UnityWebRequest.UnityWebRequestMethod // TypeDefIndex: 27897
{
	// Fields
	public int value__; // 0x0
	public const UnityWebRequest.UnityWebRequestMethod Get = 0;
	public const UnityWebRequest.UnityWebRequestMethod Post = 1;
	public const UnityWebRequest.UnityWebRequestMethod Put = 2;
	public const UnityWebRequest.UnityWebRequestMethod Head = 3;
	public const UnityWebRequest.UnityWebRequestMethod Custom = 4;
}

// Namespace: 
internal enum UnityWebRequest.UnityWebRequestError // TypeDefIndex: 27898
{
	// Fields
	public int value__; // 0x0
	public const UnityWebRequest.UnityWebRequestError OK = 0;
	public const UnityWebRequest.UnityWebRequestError OKCached = 1;
	public const UnityWebRequest.UnityWebRequestError Unknown = 2;
	public const UnityWebRequest.UnityWebRequestError SDKError = 3;
	public const UnityWebRequest.UnityWebRequestError UnsupportedProtocol = 4;
	public const UnityWebRequest.UnityWebRequestError MalformattedUrl = 5;
	public const UnityWebRequest.UnityWebRequestError CannotResolveProxy = 6;
	public const UnityWebRequest.UnityWebRequestError CannotResolveHost = 7;
	public const UnityWebRequest.UnityWebRequestError CannotConnectToHost = 8;
	public const UnityWebRequest.UnityWebRequestError AccessDenied = 9;
	public const UnityWebRequest.UnityWebRequestError GenericHttpError = 10;
	public const UnityWebRequest.UnityWebRequestError WriteError = 11;
	public const UnityWebRequest.UnityWebRequestError ReadError = 12;
	public const UnityWebRequest.UnityWebRequestError OutOfMemory = 13;
	public const UnityWebRequest.UnityWebRequestError Timeout = 14;
	public const UnityWebRequest.UnityWebRequestError HTTPPostError = 15;
	public const UnityWebRequest.UnityWebRequestError SSLCannotConnect = 16;
	public const UnityWebRequest.UnityWebRequestError Aborted = 17;
	public const UnityWebRequest.UnityWebRequestError TooManyRedirects = 18;
	public const UnityWebRequest.UnityWebRequestError ReceivedNoData = 19;
	public const UnityWebRequest.UnityWebRequestError SSLNotSupported = 20;
	public const UnityWebRequest.UnityWebRequestError FailedToSendData = 21;
	public const UnityWebRequest.UnityWebRequestError FailedToReceiveData = 22;
	public const UnityWebRequest.UnityWebRequestError SSLCertificateError = 23;
	public const UnityWebRequest.UnityWebRequestError SSLCipherNotAvailable = 24;
	public const UnityWebRequest.UnityWebRequestError SSLCACertError = 25;
	public const UnityWebRequest.UnityWebRequestError UnrecognizedContentEncoding = 26;
	public const UnityWebRequest.UnityWebRequestError LoginFailed = 27;
	public const UnityWebRequest.UnityWebRequestError SSLShutdownFailed = 28;
	public const UnityWebRequest.UnityWebRequestError RedirectLimitInvalid = 29;
	public const UnityWebRequest.UnityWebRequestError InvalidRedirect = 30;
	public const UnityWebRequest.UnityWebRequestError CannotModifyRequest = 31;
	public const UnityWebRequest.UnityWebRequestError HeaderNameContainsInvalidCharacters = 32;
	public const UnityWebRequest.UnityWebRequestError HeaderValueContainsInvalidCharacters = 33;
	public const UnityWebRequest.UnityWebRequestError CannotOverrideSystemHeaders = 34;
	public const UnityWebRequest.UnityWebRequestError AlreadySent = 35;
	public const UnityWebRequest.UnityWebRequestError InvalidMethod = 36;
	public const UnityWebRequest.UnityWebRequestError NotImplemented = 37;
	public const UnityWebRequest.UnityWebRequestError NoInternetConnection = 38;
	public const UnityWebRequest.UnityWebRequestError DataProcessingError = 39;
	public const UnityWebRequest.UnityWebRequestError InsecureConnectionNotAllowed = 40;
}

// Namespace: 
public enum UnityWebRequest.Result // TypeDefIndex: 27899
{
	// Fields
	public int value__; // 0x0
	public const UnityWebRequest.Result InProgress = 0;
	public const UnityWebRequest.Result Success = 1;
	public const UnityWebRequest.Result ConnectionError = 2;
	public const UnityWebRequest.Result ProtocolError = 3;
	public const UnityWebRequest.Result DataProcessingError = 4;
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequest.h")]
public class UnityWebRequest : IDisposable // TypeDefIndex: 27900
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	internal DownloadHandler m_DownloadHandler; // 0x18
	internal UploadHandler m_UploadHandler; // 0x20
	internal CertificateHandler m_CertificateHandler; // 0x28
	internal Uri m_Uri; // 0x30
	public const string kHttpVerbGET = "GET";
	public const string kHttpVerbHEAD = "HEAD";
	public const string kHttpVerbPOST = "POST";
	public const string kHttpVerbPUT = "PUT";
	public const string kHttpVerbCREATE = "CREATE";
	public const string kHttpVerbDELETE = "DELETE";
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposeCertificateHandlerOnDispose>k__BackingField; // 0x38
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposeDownloadHandlerOnDispose>k__BackingField; // 0x39
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposeUploadHandlerOnDispose>k__BackingField; // 0x3A

	// Properties
	public bool disposeCertificateHandlerOnDispose { get; set; }
	public bool disposeDownloadHandlerOnDispose { get; set; }
	public bool disposeUploadHandlerOnDispose { get; set; }
	public string method { get; set; }
	public string error { get; }
	private bool use100Continue { get; set; }
	public bool useHttpContinue { get; set; }
	public string url { get; set; }
	public Uri uri { get; set; }
	public long responseCode { get; }
	public float uploadProgress { get; }
	public bool isModifiable { get; }
	public bool isDone { get; }
	[Obsolete("UnityWebRequest.isNetworkError is deprecated. Use (UnityWebRequest.result == UnityWebRequest.Result.ConnectionError) instead.", False)]
	public bool isNetworkError { get; }
	[Obsolete("UnityWebRequest.isHttpError is deprecated. Use (UnityWebRequest.result == UnityWebRequest.Result.ProtocolError) instead.", False)]
	public bool isHttpError { get; }
	public UnityWebRequest.Result result { get; }
	public float downloadProgress { get; }
	public ulong uploadedBytes { get; }
	public ulong downloadedBytes { get; }
	public int redirectLimit { get; set; }
	[Obsolete("HTTP/2 and many HTTP/1.1 servers don't support this; we recommend leaving it set to false (default).", False)]
	public bool chunkedTransfer { get; set; }
	public UploadHandler uploadHandler { get; set; }
	public DownloadHandler downloadHandler { get; set; }
	public CertificateHandler certificateHandler { get; set; }
	public int timeout { get; set; }
	internal bool suppressErrorsToConsole { get; set; }

	// Methods

	[NativeConditional("ENABLE_UNITYWEBREQUEST")]
	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x89BDC3C Offset: 0x89B9C3C VA: 0x89BDC3C
	private static string GetWebErrorString(UnityWebRequest.UnityWebRequestError err) { }

	[VisibleToOtherModules]
	// RVA: 0x89BDC78 Offset: 0x89B9C78 VA: 0x89BDC78
	internal static string GetHTTPStatusString(long responseCode) { }

	[CompilerGenerated]
	// RVA: 0x89BDCB4 Offset: 0x89B9CB4 VA: 0x89BDCB4
	public bool get_disposeCertificateHandlerOnDispose() { }

	[CompilerGenerated]
	// RVA: 0x89BDCBC Offset: 0x89B9CBC VA: 0x89BDCBC
	public void set_disposeCertificateHandlerOnDispose(bool value) { }

	[CompilerGenerated]
	// RVA: 0x89BDCC8 Offset: 0x89B9CC8 VA: 0x89BDCC8
	public bool get_disposeDownloadHandlerOnDispose() { }

	[CompilerGenerated]
	// RVA: 0x89BDCD0 Offset: 0x89B9CD0 VA: 0x89BDCD0
	public void set_disposeDownloadHandlerOnDispose(bool value) { }

	[CompilerGenerated]
	// RVA: 0x89BDCDC Offset: 0x89B9CDC VA: 0x89BDCDC
	public bool get_disposeUploadHandlerOnDispose() { }

	[CompilerGenerated]
	// RVA: 0x89BDCE4 Offset: 0x89B9CE4 VA: 0x89BDCE4
	public void set_disposeUploadHandlerOnDispose(bool value) { }

	// RVA: 0x89BDCF0 Offset: 0x89B9CF0 VA: 0x89BDCF0
	public static void ClearCookieCache() { }

	// RVA: 0x89BDD68 Offset: 0x89B9D68 VA: 0x89BDD68
	public static void ClearCookieCache(Uri uri) { }

	// RVA: 0x89BDD24 Offset: 0x89B9D24 VA: 0x89BDD24
	private static void ClearCookieCache(string domain, string path) { }

	[NativeThrows]
	// RVA: 0x89BDE70 Offset: 0x89B9E70 VA: 0x89BDE70
	internal static IntPtr Create() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x89BDE98 Offset: 0x89B9E98 VA: 0x89BDE98
	private void Release() { }

	// RVA: 0x89BDED4 Offset: 0x89B9ED4 VA: 0x89BDED4
	internal void InternalDestroy() { }

	// RVA: 0x89BDF90 Offset: 0x89B9F90 VA: 0x89BDF90
	private void InternalSetDefaults() { }

	// RVA: 0x89BDFA4 Offset: 0x89B9FA4 VA: 0x89BDFA4
	public void .ctor() { }

	// RVA: 0x89BDFFC Offset: 0x89B9FFC VA: 0x89BDFFC
	public void .ctor(string url) { }

	// RVA: 0x89BE0E8 Offset: 0x89BA0E8 VA: 0x89BE0E8
	public void .ctor(Uri uri) { }

	// RVA: 0x89BE23C Offset: 0x89BA23C VA: 0x89BE23C
	public void .ctor(string url, string method) { }

	// RVA: 0x89BE438 Offset: 0x89BA438 VA: 0x89BE438
	public void .ctor(Uri uri, string method) { }

	// RVA: 0x89BE4B4 Offset: 0x89BA4B4 VA: 0x89BE4B4
	public void .ctor(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	// RVA: 0x89BE770 Offset: 0x89BA770 VA: 0x89BE770
	public void .ctor(Uri uri, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	// RVA: 0x89BE814 Offset: 0x89BA814 VA: 0x89BE814 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x89BE910 Offset: 0x89BA910 VA: 0x89BE910 Slot: 4
	public void Dispose() { }

	// RVA: 0x89BE8B0 Offset: 0x89BA8B0 VA: 0x89BE8B0
	private void DisposeHandlers() { }

	[NativeThrows]
	// RVA: 0x89BE990 Offset: 0x89BA990 VA: 0x89BE990
	internal UnityWebRequestAsyncOperation BeginWebRequest() { }

	[Obsolete("Use SendWebRequest.  It returns a UnityWebRequestAsyncOperation which contains a reference to the WebRequest object.", False)]
	// RVA: 0x89BE9CC Offset: 0x89BA9CC VA: 0x89BE9CC
	public AsyncOperation Send() { }

	// RVA: 0x89BE9D0 Offset: 0x89BA9D0 VA: 0x89BE9D0
	public UnityWebRequestAsyncOperation SendWebRequest() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x89BDF54 Offset: 0x89B9F54 VA: 0x89BDF54
	public void Abort() { }

	// RVA: 0x89BEA2C Offset: 0x89BAA2C VA: 0x89BEA2C
	private UnityWebRequest.UnityWebRequestError SetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x89BEA70 Offset: 0x89BAA70 VA: 0x89BEA70
	internal void InternalSetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x89BEBAC Offset: 0x89BABAC VA: 0x89BEBAC
	private UnityWebRequest.UnityWebRequestError SetCustomMethod(string customMethodName) { }

	// RVA: 0x89BEBF0 Offset: 0x89BABF0 VA: 0x89BEBF0
	internal void InternalSetCustomMethod(string customMethodName) { }

	// RVA: 0x89BECF0 Offset: 0x89BACF0 VA: 0x89BECF0
	internal UnityWebRequest.UnityWebRequestMethod GetMethod() { }

	// RVA: 0x89BED2C Offset: 0x89BAD2C VA: 0x89BED2C
	internal string GetCustomMethod() { }

	// RVA: 0x89BED68 Offset: 0x89BAD68 VA: 0x89BED68
	public string get_method() { }

	// RVA: 0x89BE2B8 Offset: 0x89BA2B8 VA: 0x89BE2B8
	public void set_method(string value) { }

	// RVA: 0x89BEE70 Offset: 0x89BAE70 VA: 0x89BEE70
	private UnityWebRequest.UnityWebRequestError GetError() { }

	// RVA: 0x89BEEAC Offset: 0x89BAEAC VA: 0x89BEEAC
	public string get_error() { }

	// RVA: 0x89BF0C8 Offset: 0x89BB0C8 VA: 0x89BF0C8
	private bool get_use100Continue() { }

	// RVA: 0x89BF104 Offset: 0x89BB104 VA: 0x89BF104
	private void set_use100Continue(bool value) { }

	// RVA: 0x89BF148 Offset: 0x89BB148 VA: 0x89BF148
	public bool get_useHttpContinue() { }

	// RVA: 0x89BF184 Offset: 0x89BB184 VA: 0x89BF184
	public void set_useHttpContinue(bool value) { }

	// RVA: 0x89BF23C Offset: 0x89BB23C VA: 0x89BF23C
	public string get_url() { }

	// RVA: 0x89BE060 Offset: 0x89BA060 VA: 0x89BE060
	public void set_url(string value) { }

	// RVA: 0x89BF3B4 Offset: 0x89BB3B4 VA: 0x89BF3B4
	public Uri get_uri() { }

	// RVA: 0x89BE14C Offset: 0x89BA14C VA: 0x89BE14C
	public void set_uri(Uri value) { }

	// RVA: 0x89BF278 Offset: 0x89BB278 VA: 0x89BF278
	private string GetUrl() { }

	// RVA: 0x89BF440 Offset: 0x89BB440 VA: 0x89BF440
	private UnityWebRequest.UnityWebRequestError SetUrl(string url) { }

	// RVA: 0x89BF2B4 Offset: 0x89BB2B4 VA: 0x89BF2B4
	private void InternalSetUrl(string url) { }

	// RVA: 0x89BF08C Offset: 0x89BB08C VA: 0x89BF08C
	public long get_responseCode() { }

	// RVA: 0x89BF484 Offset: 0x89BB484 VA: 0x89BF484
	private float GetUploadProgress() { }

	// RVA: 0x89BF4C0 Offset: 0x89BB4C0 VA: 0x89BF4C0
	private bool IsExecuting() { }

	// RVA: 0x89BF4FC Offset: 0x89BB4FC VA: 0x89BF4FC
	public float get_uploadProgress() { }

	[NativeMethod("IsModifiable")]
	// RVA: 0x89BEB70 Offset: 0x89BAB70 VA: 0x89BEB70
	public bool get_isModifiable() { }

	// RVA: 0x89BF5A0 Offset: 0x89BB5A0 VA: 0x89BF5A0
	public bool get_isDone() { }

	// RVA: 0x89BF5E8 Offset: 0x89BB5E8 VA: 0x89BF5E8
	public bool get_isNetworkError() { }

	// RVA: 0x89BF630 Offset: 0x89BB630 VA: 0x89BF630
	public bool get_isHttpError() { }

	[NativeMethod("GetResult")]
	// RVA: 0x89BF050 Offset: 0x89BB050 VA: 0x89BF050
	public UnityWebRequest.Result get_result() { }

	// RVA: 0x89BF678 Offset: 0x89BB678 VA: 0x89BF678
	private float GetDownloadProgress() { }

	// RVA: 0x89BF6B4 Offset: 0x89BB6B4 VA: 0x89BF6B4
	public float get_downloadProgress() { }

	// RVA: 0x89BF758 Offset: 0x89BB758 VA: 0x89BF758
	public ulong get_uploadedBytes() { }

	// RVA: 0x89BF794 Offset: 0x89BB794 VA: 0x89BF794
	public ulong get_downloadedBytes() { }

	// RVA: 0x89BF7D0 Offset: 0x89BB7D0 VA: 0x89BF7D0
	private int GetRedirectLimit() { }

	[NativeThrows]
	// RVA: 0x89BF80C Offset: 0x89BB80C VA: 0x89BF80C
	private void SetRedirectLimitFromScripting(int limit) { }

	// RVA: 0x89BF850 Offset: 0x89BB850 VA: 0x89BF850
	public int get_redirectLimit() { }

	// RVA: 0x89BF88C Offset: 0x89BB88C VA: 0x89BF88C
	public void set_redirectLimit(int value) { }

	// RVA: 0x89BF8D0 Offset: 0x89BB8D0 VA: 0x89BF8D0
	private bool GetChunked() { }

	// RVA: 0x89BF90C Offset: 0x89BB90C VA: 0x89BF90C
	private UnityWebRequest.UnityWebRequestError SetChunked(bool chunked) { }

	// RVA: 0x89BF950 Offset: 0x89BB950 VA: 0x89BF950
	public bool get_chunkedTransfer() { }

	// RVA: 0x89BF98C Offset: 0x89BB98C VA: 0x89BF98C
	public void set_chunkedTransfer(bool value) { }

	// RVA: 0x89BFA8C Offset: 0x89BBA8C VA: 0x89BFA8C
	public string GetRequestHeader(string name) { }

	[NativeMethod("SetRequestHeader")]
	// RVA: 0x89BFAD0 Offset: 0x89BBAD0 VA: 0x89BFAD0
	internal UnityWebRequest.UnityWebRequestError InternalSetRequestHeader(string name, string value) { }

	// RVA: 0x89BFB24 Offset: 0x89BBB24 VA: 0x89BFB24
	public void SetRequestHeader(string name, string value) { }

	// RVA: 0x89BFC9C Offset: 0x89BBC9C VA: 0x89BFC9C
	public string GetResponseHeader(string name) { }

	// RVA: 0x89BFCE0 Offset: 0x89BBCE0 VA: 0x89BFCE0
	internal string[] GetResponseHeaderKeys() { }

	// RVA: 0x89BFD1C Offset: 0x89BBD1C VA: 0x89BFD1C
	public Dictionary<string, string> GetResponseHeaders() { }

	// RVA: 0x89BFEEC Offset: 0x89BBEEC VA: 0x89BFEEC
	private UnityWebRequest.UnityWebRequestError SetUploadHandler(UploadHandler uh) { }

	// RVA: 0x89BE980 Offset: 0x89BA980 VA: 0x89BE980
	public UploadHandler get_uploadHandler() { }

	// RVA: 0x89BE664 Offset: 0x89BA664 VA: 0x89BE664
	public void set_uploadHandler(UploadHandler value) { }

	// RVA: 0x89BFF30 Offset: 0x89BBF30 VA: 0x89BFF30
	private UnityWebRequest.UnityWebRequestError SetDownloadHandler(DownloadHandler dh) { }

	// RVA: 0x89BE978 Offset: 0x89BA978 VA: 0x89BE978
	public DownloadHandler get_downloadHandler() { }

	// RVA: 0x89BE558 Offset: 0x89BA558 VA: 0x89BE558
	public void set_downloadHandler(DownloadHandler value) { }

	// RVA: 0x89BFF74 Offset: 0x89BBF74 VA: 0x89BFF74
	private UnityWebRequest.UnityWebRequestError SetCertificateHandler(CertificateHandler ch) { }

	// RVA: 0x89BE988 Offset: 0x89BA988 VA: 0x89BE988
	public CertificateHandler get_certificateHandler() { }

	// RVA: 0x89BFFB8 Offset: 0x89BBFB8 VA: 0x89BFFB8
	public void set_certificateHandler(CertificateHandler value) { }

	// RVA: 0x89C00C4 Offset: 0x89BC0C4 VA: 0x89C00C4
	private int GetTimeoutMsec() { }

	// RVA: 0x89C0100 Offset: 0x89BC100 VA: 0x89C0100
	private UnityWebRequest.UnityWebRequestError SetTimeoutMsec(int timeout) { }

	// RVA: 0x89C0144 Offset: 0x89BC144 VA: 0x89C0144
	public int get_timeout() { }

	// RVA: 0x89C019C Offset: 0x89BC19C VA: 0x89C019C
	public void set_timeout(int value) { }

	// RVA: 0x89C02EC Offset: 0x89BC2EC VA: 0x89C02EC
	private bool GetSuppressErrorsToConsole() { }

	// RVA: 0x89C0328 Offset: 0x89BC328 VA: 0x89C0328
	private UnityWebRequest.UnityWebRequestError SetSuppressErrorsToConsole(bool suppress) { }

	// RVA: 0x89C036C Offset: 0x89BC36C VA: 0x89C036C
	internal bool get_suppressErrorsToConsole() { }

	// RVA: 0x89C03A8 Offset: 0x89BC3A8 VA: 0x89C03A8
	internal void set_suppressErrorsToConsole(bool value) { }

	// RVA: 0x89C04A8 Offset: 0x89BC4A8 VA: 0x89C04A8
	public static UnityWebRequest Get(string uri) { }

	// RVA: 0x89C054C Offset: 0x89BC54C VA: 0x89C054C
	public static UnityWebRequest Get(Uri uri) { }

	// RVA: 0x89C05F0 Offset: 0x89BC5F0 VA: 0x89C05F0
	public static UnityWebRequest Delete(string uri) { }

	// RVA: 0x89C0668 Offset: 0x89BC668 VA: 0x89C0668
	public static UnityWebRequest Delete(Uri uri) { }

	// RVA: 0x89C06E0 Offset: 0x89BC6E0 VA: 0x89C06E0
	public static UnityWebRequest Head(string uri) { }

	// RVA: 0x89C0758 Offset: 0x89BC758 VA: 0x89C0758
	public static UnityWebRequest Head(Uri uri) { }

	[EditorBrowsable(1)]
	[Obsolete("UnityWebRequest.GetTexture is obsolete. Use UnityWebRequestTexture.GetTexture instead (UnityUpgradable) -> [UnityEngine] UnityWebRequestTexture.GetTexture(*)", True)]
	// RVA: 0x89C07D0 Offset: 0x89BC7D0 VA: 0x89C07D0
	public static UnityWebRequest GetTexture(string uri) { }

	[Obsolete("UnityWebRequest.GetTexture is obsolete. Use UnityWebRequestTexture.GetTexture instead (UnityUpgradable) -> [UnityEngine] UnityWebRequestTexture.GetTexture(*)", True)]
	[EditorBrowsable(1)]
	// RVA: 0x89C081C Offset: 0x89BC81C VA: 0x89C081C
	public static UnityWebRequest GetTexture(string uri, bool nonReadable) { }

	[Obsolete("UnityWebRequest.GetAudioClip is obsolete. Use UnityWebRequestMultimedia.GetAudioClip instead (UnityUpgradable) -> [UnityEngine] UnityWebRequestMultimedia.GetAudioClip(*)", True)]
	[EditorBrowsable(1)]
	// RVA: 0x89C0868 Offset: 0x89BC868 VA: 0x89C0868
	public static UnityWebRequest GetAudioClip(string uri, AudioType audioType) { }

	[Obsolete("UnityWebRequest.GetAssetBundle is obsolete. Use UnityWebRequestAssetBundle.GetAssetBundle instead (UnityUpgradable) -> [UnityEngine] UnityWebRequestAssetBundle.GetAssetBundle(*)", True)]
	[EditorBrowsable(1)]
	// RVA: 0x89C0870 Offset: 0x89BC870 VA: 0x89C0870
	public static UnityWebRequest GetAssetBundle(string uri) { }

	[EditorBrowsable(1)]
	[Obsolete("UnityWebRequest.GetAssetBundle is obsolete. Use UnityWebRequestAssetBundle.GetAssetBundle instead (UnityUpgradable) -> [UnityEngine] UnityWebRequestAssetBundle.GetAssetBundle(*)", True)]
	// RVA: 0x89C0878 Offset: 0x89BC878 VA: 0x89C0878
	public static UnityWebRequest GetAssetBundle(string uri, uint crc) { }

	[EditorBrowsable(1)]
	[Obsolete("UnityWebRequest.GetAssetBundle is obsolete. Use UnityWebRequestAssetBundle.GetAssetBundle instead (UnityUpgradable) -> [UnityEngine] UnityWebRequestAssetBundle.GetAssetBundle(*)", True)]
	// RVA: 0x89C0880 Offset: 0x89BC880 VA: 0x89C0880
	public static UnityWebRequest GetAssetBundle(string uri, uint version, uint crc) { }

	[EditorBrowsable(1)]
	[Obsolete("UnityWebRequest.GetAssetBundle is obsolete. Use UnityWebRequestAssetBundle.GetAssetBundle instead (UnityUpgradable) -> [UnityEngine] UnityWebRequestAssetBundle.GetAssetBundle(*)", True)]
	// RVA: 0x89C0888 Offset: 0x89BC888 VA: 0x89C0888
	public static UnityWebRequest GetAssetBundle(string uri, Hash128 hash, uint crc) { }

	[EditorBrowsable(1)]
	[Obsolete("UnityWebRequest.GetAssetBundle is obsolete. Use UnityWebRequestAssetBundle.GetAssetBundle instead (UnityUpgradable) -> [UnityEngine] UnityWebRequestAssetBundle.GetAssetBundle(*)", True)]
	// RVA: 0x89C0890 Offset: 0x89BC890 VA: 0x89C0890
	public static UnityWebRequest GetAssetBundle(string uri, CachedAssetBundle cachedAssetBundle, uint crc) { }

	// RVA: 0x89C0898 Offset: 0x89BC898 VA: 0x89C0898
	public static UnityWebRequest Put(string uri, byte[] bodyData) { }

	// RVA: 0x89C09FC Offset: 0x89BC9FC VA: 0x89C09FC
	public static UnityWebRequest Put(Uri uri, byte[] bodyData) { }

	// RVA: 0x89C0AD4 Offset: 0x89BCAD4 VA: 0x89C0AD4
	public static UnityWebRequest Put(string uri, string bodyData) { }

	// RVA: 0x89C0BD8 Offset: 0x89BCBD8 VA: 0x89C0BD8
	public static UnityWebRequest Put(Uri uri, string bodyData) { }

	[Obsolete("UnityWebRequest.Post with only a string data is obsolete. Use UnityWebRequest.Post with content type argument or UnityWebRequest.PostWwwForm instead (UnityUpgradable) -> [UnityEngine] UnityWebRequest.PostWwwForm(*)", False)]
	[EditorBrowsable(1)]
	// RVA: 0x89C0CDC Offset: 0x89BCCDC VA: 0x89C0CDC
	public static UnityWebRequest Post(string uri, string postData) { }

	[Obsolete("UnityWebRequest.Post with only a string data is obsolete. Use UnityWebRequest.Post with content type argument or UnityWebRequest.PostWwwForm instead (UnityUpgradable) -> [UnityEngine] UnityWebRequest.PostWwwForm(*)", False)]
	[EditorBrowsable(1)]
	// RVA: 0x89C0D68 Offset: 0x89BCD68 VA: 0x89C0D68
	public static UnityWebRequest Post(Uri uri, string postData) { }

	// RVA: 0x89C0CE0 Offset: 0x89BCCE0 VA: 0x89C0CE0
	public static UnityWebRequest PostWwwForm(string uri, string form) { }

	// RVA: 0x89C0D6C Offset: 0x89BCD6C VA: 0x89C0D6C
	public static UnityWebRequest PostWwwForm(Uri uri, string form) { }

	// RVA: 0x89C0DF4 Offset: 0x89BCDF4 VA: 0x89C0DF4
	private static void SetupPostWwwForm(UnityWebRequest request, string postData) { }

	// RVA: 0x89C0F58 Offset: 0x89BCF58 VA: 0x89C0F58
	public static UnityWebRequest Post(string uri, string postData, string contentType) { }

	// RVA: 0x89C1114 Offset: 0x89BD114 VA: 0x89C1114
	public static UnityWebRequest Post(Uri uri, string postData, string contentType) { }

	// RVA: 0x89C0FF0 Offset: 0x89BCFF0 VA: 0x89C0FF0
	private static void SetupPost(UnityWebRequest request, string postData, string contentType) { }

	// RVA: 0x89C11AC Offset: 0x89BD1AC VA: 0x89C11AC
	public static UnityWebRequest Post(string uri, WWWForm formData) { }

	// RVA: 0x89C1414 Offset: 0x89BD414 VA: 0x89C1414
	public static UnityWebRequest Post(Uri uri, WWWForm formData) { }

	// RVA: 0x89C1234 Offset: 0x89BD234 VA: 0x89C1234
	private static void SetupPost(UnityWebRequest request, WWWForm formData) { }

	// RVA: 0x89C149C Offset: 0x89BD49C VA: 0x89C149C
	public static UnityWebRequest Post(string uri, List<IMultipartFormSection> multipartFormSections) { }

	// RVA: 0x89C1608 Offset: 0x89BD608 VA: 0x89C1608
	public static UnityWebRequest Post(Uri uri, List<IMultipartFormSection> multipartFormSections) { }

	// RVA: 0x89C1570 Offset: 0x89BD570 VA: 0x89C1570
	public static UnityWebRequest Post(string uri, List<IMultipartFormSection> multipartFormSections, byte[] boundary) { }

	// RVA: 0x89C1634 Offset: 0x89BD634 VA: 0x89C1634
	public static UnityWebRequest Post(Uri uri, List<IMultipartFormSection> multipartFormSections, byte[] boundary) { }

	// RVA: 0x89C16CC Offset: 0x89BD6CC VA: 0x89C16CC
	private static void SetupPost(UnityWebRequest request, List<IMultipartFormSection> multipartFormSections, byte[] boundary) { }

	// RVA: 0x89C1FF0 Offset: 0x89BDFF0 VA: 0x89C1FF0
	public static UnityWebRequest Post(string uri, Dictionary<string, string> formFields) { }

	// RVA: 0x89C218C Offset: 0x89BE18C VA: 0x89C218C
	public static UnityWebRequest Post(Uri uri, Dictionary<string, string> formFields) { }

	// RVA: 0x89C2078 Offset: 0x89BE078 VA: 0x89C2078
	private static void SetupPost(UnityWebRequest request, Dictionary<string, string> formFields) { }

	// RVA: 0x89C2480 Offset: 0x89BE480 VA: 0x89C2480
	public static string EscapeURL(string s) { }

	// RVA: 0x89C24A0 Offset: 0x89BE4A0 VA: 0x89C24A0
	public static string EscapeURL(string s, Encoding e) { }

	// RVA: 0x89C2578 Offset: 0x89BE578 VA: 0x89C2578
	public static string UnEscapeURL(string s) { }

	// RVA: 0x89C2598 Offset: 0x89BE598 VA: 0x89C2598
	public static string UnEscapeURL(string s, Encoding e) { }

	// RVA: 0x89C1818 Offset: 0x89BD818 VA: 0x89C1818
	public static byte[] SerializeFormSections(List<IMultipartFormSection> multipartFormSections, byte[] boundary) { }

	// RVA: 0x89C14C8 Offset: 0x89BD4C8 VA: 0x89C14C8
	public static byte[] GenerateBoundary() { }

	// RVA: 0x89C2214 Offset: 0x89BE214 VA: 0x89C2214
	public static byte[] SerializeSimpleForm(Dictionary<string, string> formFields) { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/UploadHandler/UploadHandler.h")]
public class UploadHandler : IDisposable // TypeDefIndex: 27901
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public string contentType { set; }

	// Methods

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x89C2674 Offset: 0x89BE674 VA: 0x89C2674
	private void Release() { }

	// RVA: 0x89C26B0 Offset: 0x89BE6B0 VA: 0x89C26B0
	internal void .ctor() { }

	// RVA: 0x89C26B8 Offset: 0x89BE6B8 VA: 0x89C26B8 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x89C2754 Offset: 0x89BE754 VA: 0x89C2754 Slot: 5
	public virtual void Dispose() { }

	// RVA: 0x89C0F4C Offset: 0x89BCF4C VA: 0x89C0F4C
	public void set_contentType(string value) { }

	// RVA: 0x89C27AC Offset: 0x89BE7AC VA: 0x89C27AC Slot: 6
	internal virtual void SetContentType(string newContentType) { }

	[NativeMethod("SetContentType")]
	// RVA: 0x89C27F0 Offset: 0x89BE7F0 VA: 0x89C27F0
	private void InternalSetContentType(string newContentType) { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/UploadHandler/UploadHandlerRaw.h")]
public sealed class UploadHandlerRaw : UploadHandler // TypeDefIndex: 27902
{
	// Fields
	private NativeArray<byte> m_Payload; // 0x18

	// Methods

	// RVA: 0x89C2834 Offset: 0x89BE834 VA: 0x89C2834
	private static IntPtr Create(UploadHandlerRaw self, byte* data, int dataLength) { }

	// RVA: 0x89C0970 Offset: 0x89BC970 VA: 0x89C0970
	public void .ctor(byte[] data) { }

	// RVA: 0x89C2888 Offset: 0x89BE888 VA: 0x89C2888
	public void .ctor(NativeArray<byte> data, bool transferOwnership) { }

	// RVA: 0x89C297C Offset: 0x89BE97C VA: 0x89C297C Slot: 5
	public override void Dispose() { }
}

