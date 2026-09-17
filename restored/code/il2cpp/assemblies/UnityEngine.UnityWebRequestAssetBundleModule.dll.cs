// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28826
{}

// Namespace: UnityEngine.Networking
public static class UnityWebRequestAssetBundle // TypeDefIndex: 28827
{
	// Methods

	// RVA: 0x89B8DE0 Offset: 0x89B4DE0 VA: 0x89B8DE0
	public static UnityWebRequest GetAssetBundle(string uri) { }

	// RVA: 0x89B8EA4 Offset: 0x89B4EA4 VA: 0x89B8EA4
	public static UnityWebRequest GetAssetBundle(Uri uri) { }

	// RVA: 0x89B8DE8 Offset: 0x89B4DE8 VA: 0x89B8DE8
	public static UnityWebRequest GetAssetBundle(string uri, uint crc) { }

	// RVA: 0x89B8EAC Offset: 0x89B4EAC VA: 0x89B8EAC
	public static UnityWebRequest GetAssetBundle(Uri uri, uint crc) { }

	// RVA: 0x89B8FE8 Offset: 0x89B4FE8 VA: 0x89B8FE8
	public static UnityWebRequest GetAssetBundle(Uri uri, CachedAssetBundle cachedAssetBundle, uint crc = 0) { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequestAssetBundle/Public/DownloadHandlerAssetBundle.h")]
public sealed class DownloadHandlerAssetBundle : DownloadHandler // TypeDefIndex: 28828
{
	// Properties
	public AssetBundle assetBundle { get; }
	public bool autoLoadAssetBundle { get; set; }
	public bool isDownloadComplete { get; }

	// Methods

	// RVA: 0x89B914C Offset: 0x89B514C VA: 0x89B914C
	private static IntPtr Create(DownloadHandlerAssetBundle obj, string url, uint crc) { }

	// RVA: 0x89B91A0 Offset: 0x89B51A0 VA: 0x89B91A0
	private static IntPtr CreateCached(DownloadHandlerAssetBundle obj, string url, string name, Hash128 hash, uint crc) { }

	// RVA: 0x89B927C Offset: 0x89B527C VA: 0x89B927C
	private void InternalCreateAssetBundle(string url, uint crc) { }

	// RVA: 0x89B92D8 Offset: 0x89B52D8 VA: 0x89B92D8
	private void InternalCreateAssetBundleCached(string url, string name, Hash128 hash, uint crc) { }

	// RVA: 0x89B8F84 Offset: 0x89B4F84 VA: 0x89B8F84
	public void .ctor(string url, uint crc) { }

	// RVA: 0x89B90DC Offset: 0x89B50DC VA: 0x89B90DC
	public void .ctor(string url, CachedAssetBundle cachedBundle, uint crc) { }

	// RVA: 0x89B92F0 Offset: 0x89B52F0 VA: 0x89B92F0 Slot: 7
	protected override byte[] GetData() { }

	// RVA: 0x89B933C Offset: 0x89B533C VA: 0x89B933C Slot: 8
	protected override string GetText() { }

	// RVA: 0x89B9388 Offset: 0x89B5388 VA: 0x89B9388
	public AssetBundle get_assetBundle() { }

	// RVA: 0x89B93C4 Offset: 0x89B53C4 VA: 0x89B93C4
	public bool get_autoLoadAssetBundle() { }

	[NativeThrows]
	// RVA: 0x89B9400 Offset: 0x89B5400 VA: 0x89B9400
	public void set_autoLoadAssetBundle(bool value) { }

	// RVA: 0x89B9444 Offset: 0x89B5444 VA: 0x89B9444
	public bool get_isDownloadComplete() { }

	// RVA: 0x89B9210 Offset: 0x89B5210 VA: 0x89B9210
	private static IntPtr CreateCached_Injected(DownloadHandlerAssetBundle obj, string url, string name, ref Hash128 hash, uint crc) { }
}

