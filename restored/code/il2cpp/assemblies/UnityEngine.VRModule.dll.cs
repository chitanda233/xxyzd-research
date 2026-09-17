// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28839
{}

// Namespace: 
public enum XRSettings.StereoRenderingMode // TypeDefIndex: 28840
{
	// Fields
	public int value__; // 0x0
	public const XRSettings.StereoRenderingMode MultiPass = 0;
	public const XRSettings.StereoRenderingMode SinglePass = 1;
	public const XRSettings.StereoRenderingMode SinglePassInstanced = 2;
	public const XRSettings.StereoRenderingMode SinglePassMultiview = 3;
}

// Namespace: UnityEngine.XR
[NativeHeader("Modules/VR/ScriptBindings/XR.bindings.h")]
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
[NativeHeader("Modules/VR/VRModule.h")]
[NativeHeader("Runtime/Interfaces/IVRDevice.h")]
[NativeConditional("ENABLE_VR")]
public static class XRSettings // TypeDefIndex: 28841
{
	// Properties
	public static bool enabled { get; }
	[NativeName("Active")]
	[StaticAccessor("GetIVRDeviceScripting()", 3)]
	public static bool isDeviceActive { get; }
	[NativeName("RenderScale")]
	[StaticAccessor("GetIVRDeviceScripting()", 3)]
	public static float eyeTextureResolutionScale { get; set; }
	[StaticAccessor("GetIVRDeviceScripting()", 3)]
	public static int eyeTextureWidth { get; }
	[StaticAccessor("GetIVRDeviceScripting()", 3)]
	public static int eyeTextureHeight { get; }
	[StaticAccessor("GetIVRDeviceScripting()", 3)]
	[NativeName("IntermediateEyeTextureDesc")]
	[NativeConditional("ENABLE_VR", "RenderTextureDesc()")]
	public static RenderTextureDescriptor eyeTextureDesc { get; }
	public static float renderViewportScale { get; }
	[StaticAccessor("GetIVRDeviceScripting()", 3)]
	[NativeName("RenderViewportScale")]
	internal static float renderViewportScaleInternal { get; }
	[NativeName("DeviceName")]
	[StaticAccessor("GetIVRDeviceScripting()", 3)]
	public static string loadedDeviceName { get; }
	public static string[] supportedDevices { get; }
	[StaticAccessor("GetIVRDeviceScripting()", 3)]
	public static XRSettings.StereoRenderingMode stereoRenderingMode { get; }

	// Methods

	[StaticAccessor("GetIVRDeviceScripting()", 3)]
	// RVA: 0x89C61C0 Offset: 0x89C21C0 VA: 0x89C61C0
	public static bool get_enabled() { }

	// RVA: 0x89C61E8 Offset: 0x89C21E8 VA: 0x89C61E8
	public static bool get_isDeviceActive() { }

	// RVA: 0x89C6210 Offset: 0x89C2210 VA: 0x89C6210
	public static float get_eyeTextureResolutionScale() { }

	// RVA: 0x89C6238 Offset: 0x89C2238 VA: 0x89C6238
	public static void set_eyeTextureResolutionScale(float value) { }

	// RVA: 0x89C6270 Offset: 0x89C2270 VA: 0x89C6270
	public static int get_eyeTextureWidth() { }

	// RVA: 0x89C6298 Offset: 0x89C2298 VA: 0x89C6298
	public static int get_eyeTextureHeight() { }

	// RVA: 0x89C62C0 Offset: 0x89C22C0 VA: 0x89C62C0
	public static RenderTextureDescriptor get_eyeTextureDesc() { }

	// RVA: 0x89C636C Offset: 0x89C236C VA: 0x89C636C
	public static float get_renderViewportScale() { }

	// RVA: 0x89C6394 Offset: 0x89C2394 VA: 0x89C6394
	internal static float get_renderViewportScaleInternal() { }

	// RVA: 0x89C63BC Offset: 0x89C23BC VA: 0x89C63BC
	public static string get_loadedDeviceName() { }

	// RVA: 0x89C63E4 Offset: 0x89C23E4 VA: 0x89C63E4
	public static string[] get_supportedDevices() { }

	// RVA: 0x89C640C Offset: 0x89C240C VA: 0x89C640C
	public static XRSettings.StereoRenderingMode get_stereoRenderingMode() { }

	// RVA: 0x89C6330 Offset: 0x89C2330 VA: 0x89C6330
	private static void get_eyeTextureDesc_Injected(out RenderTextureDescriptor ret) { }
}

// Namespace: UnityEngine.XR
[NativeConditional("ENABLE_VR")]
public static class XRDevice // TypeDefIndex: 28842
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<string> deviceLoaded; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x89C6434 Offset: 0x89C2434 VA: 0x89C6434
	private static void InvokeDeviceLoaded(string loadedDeviceName) { }
}

