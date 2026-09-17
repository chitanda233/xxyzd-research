// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28896
{}

// Namespace: FalconLogReport
public class ClientLogManager : Singleton<ClientLogManager> // TypeDefIndex: 28897
{
	// Fields
	private readonly ILogHandler _logHandler; // 0x10

	// Methods

	// RVA: 0x414EC64 Offset: 0x414AC64 VA: 0x414EC64
	public void InitReportLog(string roomId, string playerId) { }

	// RVA: 0x414ED98 Offset: 0x414AD98 VA: 0x414ED98
	public string GetUploadFileName() { }

	// RVA: 0x414EE3C Offset: 0x414AE3C VA: 0x414EE3C
	public void Stop() { }

	// RVA: -1 Offset: -1
	public void AddLog<T>(T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x454E2C8 Offset: 0x454A2C8 VA: 0x454E2C8
	|-ClientLogManager.AddLog<object>
	*/

	// RVA: 0x414EFB8 Offset: 0x414AFB8 VA: 0x414EFB8
	public void .ctor() { }
}

// Namespace: FalconLogReport
public interface ILogHandler // TypeDefIndex: 28898
{
	// Properties
	public abstract bool IsStart { get; }
	public abstract bool IsUpload { get; }
	public abstract string UploadFileName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsStart();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsUpload();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_UploadFileName();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void InitReportLog(string roomId, string playerId, bool isClient);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Stop();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void AddLog<T>(T data);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ILogHandler.AddLog<object>
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LogHandler.<UploadFileSync>d__13 : IAsyncStateMachine // TypeDefIndex: 28899
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncVoidMethodBuilder <>t__builder; // 0x18
	public LogHandler <>4__this; // 0x38
	private byte[] <bytes>5__1; // 0x40
	private string <resultUrl>5__2; // 0x48
	private HttpWebRequest <request>5__3; // 0x50
	private Stream <requestStream>5__4; // 0x58
	private HttpWebResponse <response>5__5; // 0x60
	private Stream <responseStream>5__6; // 0x68
	private StreamReader <reader>5__7; // 0x70
	private Exception <e>5__8; // 0x78

	// Methods

	// RVA: 0x414F4D0 Offset: 0x414B4D0 VA: 0x414F4D0
	public void .ctor() { }

	// RVA: 0x414F4D8 Offset: 0x414B4D8 VA: 0x414F4D8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41501AC Offset: 0x414C1AC VA: 0x41501AC Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: FalconLogReport
internal class LogHandler : ILogHandler // TypeDefIndex: 28900
{
	// Fields
	private string _uploadFileName; // 0x10
	private bool _isStart; // 0x18
	private bool _isUpload; // 0x19
	private ConcurrentQueue<object> _queue; // 0x20

	// Properties
	public bool IsStart { get; }
	public bool IsUpload { get; }
	public string UploadFileName { get; }

	// Methods

	// RVA: 0x414F0F8 Offset: 0x414B0F8 VA: 0x414F0F8 Slot: 4
	public bool get_IsStart() { }

	// RVA: 0x414F110 Offset: 0x414B110 VA: 0x414F110 Slot: 5
	public bool get_IsUpload() { }

	// RVA: 0x414F128 Offset: 0x414B128 VA: 0x414F128 Slot: 6
	public string get_UploadFileName() { }

	// RVA: 0x414F130 Offset: 0x414B130 VA: 0x414F130 Slot: 7
	public void InitReportLog(string roomId, string playerId, bool isClient) { }

	// RVA: -1 Offset: -1 Slot: 9
	public void AddLog<T>(T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466CD74 Offset: 0x4668D74 VA: 0x466CD74
	|-LogHandler.AddLog<object>
	*/

	// RVA: 0x414F348 Offset: 0x414B348 VA: 0x414F348 Slot: 8
	public void Stop() { }

	[AsyncStateMachine(typeof(LogHandler.<UploadFileSync>d__13))]
	[DebuggerStepThrough]
	// RVA: 0x414F3F4 Offset: 0x414B3F4 VA: 0x414F3F4
	private void UploadFileSync() { }

	// RVA: 0x414F060 Offset: 0x414B060 VA: 0x414F060
	public void .ctor() { }
}

// Namespace: FalconLogReport.Utility
public class Singleton<T> // TypeDefIndex: 28901
{
	// Fields
	private static T _instance; // 0x0
	private static readonly object SyncObject; // 0x0

	// Properties
	public static T Inst { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T get_Inst() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54EA764 Offset: 0x54E6764 VA: 0x54EA764
	|-Singleton<object>.get_Inst
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54EAB54 Offset: 0x54E6B54 VA: 0x54EAB54
	|-Singleton<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54EAB5C Offset: 0x54E6B5C VA: 0x54EAB5C
	|-Singleton<object>..cctor
	*/
}

