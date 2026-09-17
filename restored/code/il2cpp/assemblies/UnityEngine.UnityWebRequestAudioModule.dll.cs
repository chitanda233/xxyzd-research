// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28852
{}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequestAudio/Public/DownloadHandlerAudioClip.h")]
public sealed class DownloadHandlerAudioClip : DownloadHandler // TypeDefIndex: 28853
{
	// Fields
	private NativeArray<byte> m_NativeData; // 0x18

	// Properties
	[NativeThrows]
	public AudioClip audioClip { get; }

	// Methods

	// RVA: 0x89B9480 Offset: 0x89B5480 VA: 0x89B9480
	private static IntPtr Create(DownloadHandlerAudioClip obj, string url, AudioType audioType) { }

	// RVA: 0x89B94D4 Offset: 0x89B54D4 VA: 0x89B94D4
	private void InternalCreateAudioClip(string url, AudioType audioType) { }

	// RVA: 0x89B9530 Offset: 0x89B5530 VA: 0x89B9530
	public void .ctor(string url, AudioType audioType) { }

	// RVA: 0x89B9594 Offset: 0x89B5594 VA: 0x89B9594 Slot: 6
	protected override NativeArray<byte> GetNativeData() { }

	// RVA: 0x89B95A0 Offset: 0x89B55A0 VA: 0x89B95A0 Slot: 5
	public override void Dispose() { }

	// RVA: 0x89B95C4 Offset: 0x89B55C4 VA: 0x89B95C4 Slot: 8
	protected override string GetText() { }

	// RVA: 0x89B9610 Offset: 0x89B5610 VA: 0x89B9610
	public AudioClip get_audioClip() { }

	// RVA: 0x89B964C Offset: 0x89B564C VA: 0x89B964C
	public static AudioClip GetContent(UnityWebRequest www) { }
}

// Namespace: UnityEngine.Networking
public static class UnityWebRequestMultimedia // TypeDefIndex: 28854
{
	// Methods

	// RVA: 0x89B96C8 Offset: 0x89B56C8 VA: 0x89B96C8
	public static UnityWebRequest GetAudioClip(string uri, AudioType audioType) { }
}

