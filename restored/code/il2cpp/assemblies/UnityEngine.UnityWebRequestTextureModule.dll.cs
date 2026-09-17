// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28836
{}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequestTexture/Public/DownloadHandlerTexture.h")]
public sealed class DownloadHandlerTexture : DownloadHandler // TypeDefIndex: 28837
{
	// Fields
	private NativeArray<byte> m_NativeData; // 0x18
	private bool mNonReadable; // 0x28

	// Properties
	public Texture2D texture { get; }

	// Methods

	// RVA: 0x89C29E0 Offset: 0x89BE9E0 VA: 0x89C29E0
	private static IntPtr Create(DownloadHandlerTexture obj, bool readable) { }

	// RVA: 0x89C2A24 Offset: 0x89BEA24 VA: 0x89C2A24
	private void InternalCreateTexture(bool readable) { }

	// RVA: 0x89C2A70 Offset: 0x89BEA70 VA: 0x89C2A70
	public void .ctor() { }

	// RVA: 0x89C2AC0 Offset: 0x89BEAC0 VA: 0x89C2AC0
	public void .ctor(bool readable) { }

	// RVA: 0x89C2B20 Offset: 0x89BEB20 VA: 0x89C2B20 Slot: 6
	protected override NativeArray<byte> GetNativeData() { }

	// RVA: 0x89C2B2C Offset: 0x89BEB2C VA: 0x89C2B2C Slot: 5
	public override void Dispose() { }

	// RVA: 0x89C2B50 Offset: 0x89BEB50 VA: 0x89C2B50
	public Texture2D get_texture() { }

	[NativeThrows]
	// RVA: 0x89C2B8C Offset: 0x89BEB8C VA: 0x89C2B8C
	private Texture2D InternalGetTextureNative() { }

	// RVA: 0x89C2BC8 Offset: 0x89BEBC8 VA: 0x89C2BC8
	public static Texture2D GetContent(UnityWebRequest www) { }
}

// Namespace: UnityEngine.Networking
public static class UnityWebRequestTexture // TypeDefIndex: 28838
{
	// Methods

	// RVA: 0x89C2C44 Offset: 0x89BEC44 VA: 0x89C2C44
	public static UnityWebRequest GetTexture(string uri) { }

	// RVA: 0x89C2D08 Offset: 0x89BED08 VA: 0x89C2D08
	public static UnityWebRequest GetTexture(Uri uri) { }

	// RVA: 0x89C2C4C Offset: 0x89BEC4C VA: 0x89C2C4C
	public static UnityWebRequest GetTexture(string uri, bool nonReadable) { }

	// RVA: 0x89C2D10 Offset: 0x89BED10 VA: 0x89C2D10
	public static UnityWebRequest GetTexture(Uri uri, bool nonReadable) { }
}

