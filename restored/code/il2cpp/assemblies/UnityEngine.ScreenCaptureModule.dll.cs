// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28862
{}

// Namespace: 
public enum ScreenCapture.StereoScreenCaptureMode // TypeDefIndex: 28863
{
	// Fields
	public int value__; // 0x0
	public const ScreenCapture.StereoScreenCaptureMode LeftEye = 1;
	public const ScreenCapture.StereoScreenCaptureMode RightEye = 2;
	public const ScreenCapture.StereoScreenCaptureMode BothEyes = 3;
}

// Namespace: UnityEngine
[NativeHeader("Modules/ScreenCapture/Public/CaptureScreenshot.h")]
public static class ScreenCapture // TypeDefIndex: 28864
{
	// Methods

	// RVA: 0x87E37FC Offset: 0x87DF7FC VA: 0x87E37FC
	public static void CaptureScreenshot(string filename) { }

	// RVA: 0x87E3840 Offset: 0x87DF840 VA: 0x87E3840
	private static void CaptureScreenshot(string filename, int superSize, ScreenCapture.StereoScreenCaptureMode CaptureMode) { }
}

