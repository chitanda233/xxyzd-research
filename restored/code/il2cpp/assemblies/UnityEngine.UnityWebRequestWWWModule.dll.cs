// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28801
{}

// Namespace: UnityEngine
[Obsolete("Use UnityWebRequest, a fully featured replacement which is more efficient and has additional features")]
public class WWW : CustomYieldInstruction, IDisposable // TypeDefIndex: 28802
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private ThreadPriority <threadPriority>k__BackingField; // 0x10
	private UnityWebRequest _uwr; // 0x18
	private AssetBundle _assetBundle; // 0x20
	private Dictionary<string, string> _responseHeaders; // 0x28

	// Properties
	public string error { get; }
	public bool isDone { get; }
	public float progress { get; }
	public Dictionary<string, string> responseHeaders { get; }
	public string text { get; }
	public float uploadProgress { get; }
	public string url { get; }
	public override bool keepWaiting { get; }

	// Methods

	// RVA: 0x89C2DCC Offset: 0x89BEDCC VA: 0x89C2DCC
	public void .ctor(string url) { }

	// RVA: 0x89C2E1C Offset: 0x89BEE1C VA: 0x89C2E1C
	public void .ctor(string url, byte[] postData, Dictionary<string, string> headers) { }

	// RVA: 0x89C30E8 Offset: 0x89BF0E8 VA: 0x89C30E8
	public string get_error() { }

	// RVA: 0x89C3204 Offset: 0x89BF204 VA: 0x89C3204
	public bool get_isDone() { }

	// RVA: 0x89C3220 Offset: 0x89BF220 VA: 0x89C3220
	public float get_progress() { }

	// RVA: 0x89C3248 Offset: 0x89BF248 VA: 0x89C3248
	public Dictionary<string, string> get_responseHeaders() { }

	// RVA: 0x89C3410 Offset: 0x89BF410 VA: 0x89C3410
	public string get_text() { }

	// RVA: 0x89C3584 Offset: 0x89BF584 VA: 0x89C3584
	public void LoadImageIntoTexture(Texture2D texture) { }

	// RVA: 0x89C3690 Offset: 0x89BF690 VA: 0x89C3690
	public float get_uploadProgress() { }

	// RVA: 0x89C36B8 Offset: 0x89BF6B8 VA: 0x89C36B8
	public string get_url() { }

	// RVA: 0x89C36D4 Offset: 0x89BF6D4 VA: 0x89C36D4 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x89C3700 Offset: 0x89BF700 VA: 0x89C3700 Slot: 9
	public void Dispose() { }

	// RVA: 0x89C34A0 Offset: 0x89BF4A0 VA: 0x89C34A0
	private bool WaitUntilDoneIfPossible() { }
}

