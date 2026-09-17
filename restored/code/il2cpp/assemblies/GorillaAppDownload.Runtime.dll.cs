// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28958
{}

// Namespace: 
[CompilerGenerated]
private sealed class AndroidAppDownloadService.DownloadResultHandler.<>c__DisplayClass2_0 // TypeDefIndex: 28959
{
	// Fields
	public AndroidAppDownloadService.DownloadResultHandler <>4__this; // 0x10
	public int code; // 0x18
	public string msg; // 0x20

	// Methods

	// RVA: 0x6405E78 Offset: 0x6401E78 VA: 0x6405E78
	public void .ctor() { }

	// RVA: 0x6405E80 Offset: 0x6401E80 VA: 0x6405E80
	internal void <OnResult>b__0() { }
}

// Namespace: 
[Preserve]
private sealed class AndroidAppDownloadService.DownloadResultHandler : AndroidJavaProxy // TypeDefIndex: 28960
{
	// Fields
	private readonly Action<int, string> _callback; // 0x20

	// Methods

	// RVA: 0x6405CE4 Offset: 0x6401CE4 VA: 0x6405CE4
	public void .ctor(Action<int, string> callback) { }

	[Preserve]
	// RVA: 0x6405D70 Offset: 0x6401D70 VA: 0x6405D70
	public void OnResult(int code, string msg) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AndroidAppDownloadService.DownloadProgressHandler.<>c__DisplayClass2_0 // TypeDefIndex: 28961
{
	// Fields
	public AndroidAppDownloadService.DownloadProgressHandler <>4__this; // 0x10
	public int progress; // 0x18

	// Methods

	// RVA: 0x640603C Offset: 0x640203C VA: 0x640603C
	public void .ctor() { }

	// RVA: 0x6406044 Offset: 0x6402044 VA: 0x6406044
	internal void <OnProgress>b__0() { }
}

// Namespace: 
[Preserve]
private sealed class AndroidAppDownloadService.DownloadProgressHandler : AndroidJavaProxy // TypeDefIndex: 28962
{
	// Fields
	private readonly Action<int> _callback; // 0x20

	// Methods

	// RVA: 0x6405EBC Offset: 0x6401EBC VA: 0x6405EBC
	public void .ctor(Action<int> callback) { }

	[Preserve]
	// RVA: 0x6405F48 Offset: 0x6401F48 VA: 0x6405F48
	public void OnProgress(int progress) { }
}

// Namespace: GorillaAppDownload.Runtime
[Preserve]
internal class AndroidAppDownloadService : IAppDownloadService // TypeDefIndex: 28963
{
	// Methods

	[Preserve]
	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x6405C28 Offset: 0x6401C28 VA: 0x6405C28
	private static void AutoRegister() { }

	// RVA: 0x6405CDC Offset: 0x6401CDC VA: 0x6405CDC
	public void .ctor() { }
}

