// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28424
{}

// Namespace: 
private enum InputTracking.TrackingStateEventType // TypeDefIndex: 28425
{
	// Fields
	public int value__; // 0x0
	public const InputTracking.TrackingStateEventType NodeAdded = 0;
	public const InputTracking.TrackingStateEventType NodeRemoved = 1;
	public const InputTracking.TrackingStateEventType TrackingAcquired = 2;
	public const InputTracking.TrackingStateEventType TrackingLost = 3;
}

// Namespace: UnityEngine.XR
[RequiredByNativeCode]
[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputTrackingFacade.h")]
[StaticAccessor("XRInputTrackingFacade::Get()", 0)]
public static class InputTracking // TypeDefIndex: 28426
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<XRNodeState> trackingAcquired; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<XRNodeState> trackingLost; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<XRNodeState> nodeAdded; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<XRNodeState> nodeRemoved; // 0x18

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x89C64A0 Offset: 0x89C24A0 VA: 0x89C64A0
	private static void InvokeTrackingEvent(InputTracking.TrackingStateEventType eventType, XRNode nodeType, long uniqueID, bool tracked) { }
}

// Namespace: UnityEngine.XR
public enum XRNode // TypeDefIndex: 28427
{
	// Fields
	public int value__; // 0x0
	public const XRNode LeftEye = 0;
	public const XRNode RightEye = 1;
	public const XRNode CenterEye = 2;
	public const XRNode Head = 3;
	public const XRNode LeftHand = 4;
	public const XRNode RightHand = 5;
	public const XRNode GameController = 6;
	public const XRNode TrackingReference = 7;
	public const XRNode HardwareTracker = 8;
}

// Namespace: UnityEngine.XR
[Flags]
internal enum AvailableTrackingData // TypeDefIndex: 28428
{
	// Fields
	public int value__; // 0x0
	public const AvailableTrackingData None = 0;
	public const AvailableTrackingData PositionAvailable = 1;
	public const AvailableTrackingData RotationAvailable = 2;
	public const AvailableTrackingData VelocityAvailable = 4;
	public const AvailableTrackingData AngularVelocityAvailable = 8;
	public const AvailableTrackingData AccelerationAvailable = 16;
	public const AvailableTrackingData AngularAccelerationAvailable = 32;
}

// Namespace: UnityEngine.XR
[UsedByNativeCode]
public struct XRNodeState // TypeDefIndex: 28429
{
	// Fields
	private XRNode m_Type; // 0x0
	private AvailableTrackingData m_AvailableFields; // 0x4
	private Vector3 m_Position; // 0x8
	private Quaternion m_Rotation; // 0x14
	private Vector3 m_Velocity; // 0x24
	private Vector3 m_AngularVelocity; // 0x30
	private Vector3 m_Acceleration; // 0x3C
	private Vector3 m_AngularAcceleration; // 0x48
	private int m_Tracked; // 0x54
	private ulong m_UniqueID; // 0x58

	// Properties
	public ulong uniqueID { set; }
	public XRNode nodeType { set; }
	public bool tracked { set; }

	// Methods

	// RVA: 0x89C6648 Offset: 0x89C2648 VA: 0x89C6648
	public void set_uniqueID(ulong value) { }

	// RVA: 0x89C6650 Offset: 0x89C2650 VA: 0x89C6650
	public void set_nodeType(XRNode value) { }

	// RVA: 0x89C6658 Offset: 0x89C2658 VA: 0x89C6658
	public void set_tracked(bool value) { }
}

// Namespace: UnityEngine.XR
internal enum InputFeatureType // TypeDefIndex: 28430
{
	// Fields
	public uint value__; // 0x0
	public const InputFeatureType Custom = 0;
	public const InputFeatureType Binary = 1;
	public const InputFeatureType DiscreteStates = 2;
	public const InputFeatureType Axis1D = 3;
	public const InputFeatureType Axis2D = 4;
	public const InputFeatureType Axis3D = 5;
	public const InputFeatureType Rotation = 6;
	public const InputFeatureType Hand = 7;
	public const InputFeatureType Bone = 8;
	public const InputFeatureType Eyes = 9;
	public const InputFeatureType kUnityXRInputFeatureTypeInvalid = 4294967295;
}

// Namespace: UnityEngine.XR
internal enum ConnectionChangeType // TypeDefIndex: 28431
{
	// Fields
	public uint value__; // 0x0
	public const ConnectionChangeType Connected = 0;
	public const ConnectionChangeType Disconnected = 1;
	public const ConnectionChangeType ConfigChange = 2;
}

// Namespace: UnityEngine.XR
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[RequiredByNativeCode]
[NativeConditional("ENABLE_VR")]
public struct InputFeatureUsage : IEquatable<InputFeatureUsage> // TypeDefIndex: 28432
{
	// Fields
	internal string m_Name; // 0x0
	[NativeName("m_FeatureType")]
	internal InputFeatureType m_InternalType; // 0x8

	// Properties
	public string name { get; }
	internal InputFeatureType internalType { get; }

	// Methods

	// RVA: 0x89C6664 Offset: 0x89C2664 VA: 0x89C6664
	public string get_name() { }

	// RVA: 0x89C666C Offset: 0x89C266C VA: 0x89C666C
	internal InputFeatureType get_internalType() { }

	// RVA: 0x89C6674 Offset: 0x89C2674 VA: 0x89C6674 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x89C66FC Offset: 0x89C26FC VA: 0x89C66FC Slot: 4
	public bool Equals(InputFeatureUsage other) { }

	// RVA: 0x89C673C Offset: 0x89C273C VA: 0x89C673C Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.XR
[NativeConditional("ENABLE_VR")]
[UsedByNativeCode]
public struct InputDevice : IEquatable<InputDevice> // TypeDefIndex: 28433
{
	// Fields
	private ulong m_DeviceId; // 0x0
	private bool m_Initialized; // 0x8

	// Properties
	private ulong deviceId { get; }

	// Methods

	// RVA: 0x89C6788 Offset: 0x89C2788 VA: 0x89C6788
	internal void .ctor(ulong deviceId) { }

	// RVA: 0x89C6798 Offset: 0x89C2798 VA: 0x89C6798
	private ulong get_deviceId() { }

	// RVA: 0x89C67B0 Offset: 0x89C27B0 VA: 0x89C67B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x89C6840 Offset: 0x89C2840 VA: 0x89C6840 Slot: 4
	public bool Equals(InputDevice other) { }

	// RVA: 0x89C6868 Offset: 0x89C2868 VA: 0x89C6868 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.XR
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[NativeHeader("XRScriptingClasses.h")]
[StaticAccessor("XRInputDevices::Get()", 0)]
[RequiredByNativeCode]
[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/XR/XRPrefix.h")]
public struct Hand : IEquatable<Hand> // TypeDefIndex: 28434
{
	// Fields
	private ulong m_DeviceId; // 0x0
	private uint m_FeatureIndex; // 0x8

	// Properties
	internal ulong deviceId { get; }
	internal uint featureIndex { get; }

	// Methods

	// RVA: 0x89C6898 Offset: 0x89C2898 VA: 0x89C6898
	internal ulong get_deviceId() { }

	// RVA: 0x89C68A0 Offset: 0x89C28A0 VA: 0x89C68A0
	internal uint get_featureIndex() { }

	// RVA: 0x89C68A8 Offset: 0x89C28A8 VA: 0x89C68A8 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x89C6930 Offset: 0x89C2930 VA: 0x89C6930 Slot: 4
	public bool Equals(Hand other) { }

	// RVA: 0x89C6954 Offset: 0x89C2954 VA: 0x89C6954 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.XR
[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeHeader("XRScriptingClasses.h")]
[RequiredByNativeCode]
[StaticAccessor("XRInputDevices::Get()", 0)]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
public struct Eyes : IEquatable<Eyes> // TypeDefIndex: 28435
{
	// Fields
	private ulong m_DeviceId; // 0x0
	private uint m_FeatureIndex; // 0x8

	// Properties
	internal ulong deviceId { get; }
	internal uint featureIndex { get; }

	// Methods

	// RVA: 0x89C69A4 Offset: 0x89C29A4 VA: 0x89C69A4
	internal ulong get_deviceId() { }

	// RVA: 0x89C69AC Offset: 0x89C29AC VA: 0x89C69AC
	internal uint get_featureIndex() { }

	// RVA: 0x89C69B4 Offset: 0x89C29B4 VA: 0x89C69B4 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x89C6A3C Offset: 0x89C2A3C VA: 0x89C6A3C Slot: 4
	public bool Equals(Eyes other) { }

	// RVA: 0x89C6A60 Offset: 0x89C2A60 VA: 0x89C6A60 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.XR
[StaticAccessor("XRInputDevices::Get()", 0)]
[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeHeader("XRScriptingClasses.h")]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[RequiredByNativeCode]
[NativeConditional("ENABLE_VR")]
public struct Bone : IEquatable<Bone> // TypeDefIndex: 28436
{
	// Fields
	private ulong m_DeviceId; // 0x0
	private uint m_FeatureIndex; // 0x8

	// Properties
	internal ulong deviceId { get; }
	internal uint featureIndex { get; }

	// Methods

	// RVA: 0x89C6AB0 Offset: 0x89C2AB0 VA: 0x89C6AB0
	internal ulong get_deviceId() { }

	// RVA: 0x89C6AB8 Offset: 0x89C2AB8 VA: 0x89C6AB8
	internal uint get_featureIndex() { }

	// RVA: 0x89C6AC0 Offset: 0x89C2AC0 VA: 0x89C6AC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x89C6B48 Offset: 0x89C2B48 VA: 0x89C6B48 Slot: 4
	public bool Equals(Bone other) { }

	// RVA: 0x89C6B6C Offset: 0x89C2B6C VA: 0x89C6B6C Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.XR
[UsedByNativeCode]
[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[StaticAccessor("XRInputDevices::Get()", 0)]
public class InputDevices // TypeDefIndex: 28437
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<InputDevice> deviceConnected; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<InputDevice> deviceDisconnected; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<InputDevice> deviceConfigChanged; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x89C6BBC Offset: 0x89C2BBC VA: 0x89C6BBC
	private static void InvokeConnectionEvent(ulong deviceId, ConnectionChangeType change) { }
}

// Namespace: 
[Flags]
public enum XRDisplaySubsystem.TextureLayout // TypeDefIndex: 28438
{
	// Fields
	public int value__; // 0x0
	public const XRDisplaySubsystem.TextureLayout Texture2DArray = 1;
	public const XRDisplaySubsystem.TextureLayout SingleTexture2D = 2;
	public const XRDisplaySubsystem.TextureLayout SeparateTexture2Ds = 4;
}

// Namespace: 
[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
public struct XRDisplaySubsystem.XRRenderParameter // TypeDefIndex: 28439
{
	// Fields
	public Matrix4x4 view; // 0x0
	public Matrix4x4 projection; // 0x40
	public Rect viewport; // 0x80
	public Mesh occlusionMesh; // 0x90
	public int textureArraySlice; // 0x98
	public Matrix4x4 previousView; // 0x9C
	public bool isPreviousViewValid; // 0xDC
}

// Namespace: 
[NativeHeader("Runtime/Graphics/RenderTextureDesc.h")]
[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
public struct XRDisplaySubsystem.XRRenderPass // TypeDefIndex: 28440
{
	// Fields
	private IntPtr displaySubsystemInstance; // 0x0
	public int renderPassIndex; // 0x8
	public RenderTargetIdentifier renderTarget; // 0x10
	public RenderTextureDescriptor renderTargetDesc; // 0x38
	public bool hasMotionVectorPass; // 0x6C
	public RenderTargetIdentifier motionVectorRenderTarget; // 0x70
	public RenderTextureDescriptor motionVectorRenderTargetDesc; // 0x98
	public bool shouldFillOutDepth; // 0xCC
	public int cullingPassIndex; // 0xD0
	public IntPtr foveatedRenderingInfo; // 0xD8

	// Methods

	[NativeConditional("ENABLE_XR")]
	[NativeMethod(Name = "XRRenderPassScriptApi::GetRenderParameter", IsFreeFunction = True, HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x89C731C Offset: 0x89C331C VA: 0x89C731C
	public void GetRenderParameter(Camera camera, int renderParameterIndex, out XRDisplaySubsystem.XRRenderParameter renderParameter) { }

	[NativeConditional("ENABLE_XR")]
	[NativeMethod(Name = "XRRenderPassScriptApi::GetRenderParameterCount", IsFreeFunction = True, HasExplicitThis = True)]
	// RVA: 0x89C73D4 Offset: 0x89C33D4 VA: 0x89C73D4
	public int GetRenderParameterCount() { }

	// RVA: 0x89C7378 Offset: 0x89C3378 VA: 0x89C7378
	private static void GetRenderParameter_Injected(ref XRDisplaySubsystem.XRRenderPass _unity_self, Camera camera, int renderParameterIndex, out XRDisplaySubsystem.XRRenderParameter renderParameter) { }

	// RVA: 0x89C7410 Offset: 0x89C3410 VA: 0x89C7410
	private static int GetRenderParameterCount_Injected(ref XRDisplaySubsystem.XRRenderPass _unity_self) { }
}

// Namespace: 
[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
public struct XRDisplaySubsystem.XRBlitParams // TypeDefIndex: 28441
{
	// Fields
	public RenderTexture srcTex; // 0x0
	public int srcTexArraySlice; // 0x8
	public Rect srcRect; // 0xC
	public Rect destRect; // 0x1C
	public IntPtr foveatedRenderingInfo; // 0x30
	public bool srcHdrEncoded; // 0x38
	public ColorGamut srcHdrColorGamut; // 0x3C
	public int srcHdrMaxLuminance; // 0x40
}

// Namespace: 
[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
public struct XRDisplaySubsystem.XRMirrorViewBlitDesc // TypeDefIndex: 28442
{
	// Fields
	private IntPtr displaySubsystemInstance; // 0x0
	public bool nativeBlitAvailable; // 0x8
	public bool nativeBlitInvalidStates; // 0x9
	public int blitParamsCount; // 0xC

	// Methods

	[NativeMethod(Name = "XRMirrorViewBlitDescScriptApi::GetBlitParameter", IsFreeFunction = True, HasExplicitThis = True)]
	[NativeConditional("ENABLE_XR")]
	// RVA: 0x89C744C Offset: 0x89C344C VA: 0x89C744C
	public void GetBlitParameter(int blitParameterIndex, out XRDisplaySubsystem.XRBlitParams blitParameter) { }

	// RVA: 0x89C74A0 Offset: 0x89C34A0 VA: 0x89C74A0
	private static void GetBlitParameter_Injected(ref XRDisplaySubsystem.XRMirrorViewBlitDesc _unity_self, int blitParameterIndex, out XRDisplaySubsystem.XRBlitParams blitParameter) { }
}

// Namespace: UnityEngine.XR
[NativeType(Header = "Modules/XR/Subsystems/Display/XRDisplaySubsystem.h")]
[NativeConditional("ENABLE_XR")]
[UsedByNativeCode]
[NativeHeader("Modules/XR/XRPrefix.h")]
public class XRDisplaySubsystem : IntegratedSubsystem<XRDisplaySubsystemDescriptor> // TypeDefIndex: 28443
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<bool> displayFocusChanged; // 0x20
	private HDROutputSettings m_HDROutputSettings; // 0x28

	// Properties
	public float scaleOfAllRenderTargets { set; }
	public float zNear { set; }
	public float zFar { set; }
	public bool sRGB { set; }
	public XRDisplaySubsystem.TextureLayout textureLayout { set; }
	public bool disableLegacyRenderer { set; }
	public HDROutputSettings hdrOutputSettings { get; }

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x89C6C78 Offset: 0x89C2C78 VA: 0x89C6C78
	private void InvokeDisplayFocusChanged(bool focus) { }

	// RVA: 0x89C6C98 Offset: 0x89C2C98 VA: 0x89C6C98
	public void set_scaleOfAllRenderTargets(float value) { }

	// RVA: 0x89C6CE4 Offset: 0x89C2CE4 VA: 0x89C6CE4
	public void set_zNear(float value) { }

	// RVA: 0x89C6D30 Offset: 0x89C2D30 VA: 0x89C6D30
	public void set_zFar(float value) { }

	// RVA: 0x89C6D7C Offset: 0x89C2D7C VA: 0x89C6D7C
	public void set_sRGB(bool value) { }

	// RVA: 0x89C6DC0 Offset: 0x89C2DC0 VA: 0x89C6DC0
	public void set_textureLayout(XRDisplaySubsystem.TextureLayout value) { }

	// RVA: 0x89C6E04 Offset: 0x89C2E04 VA: 0x89C6E04
	public void SetMSAALevel(int level) { }

	// RVA: 0x89C6E48 Offset: 0x89C2E48 VA: 0x89C6E48
	public void set_disableLegacyRenderer(bool value) { }

	// RVA: 0x89C6E8C Offset: 0x89C2E8C VA: 0x89C6E8C
	public int GetRenderPassCount() { }

	// RVA: 0x89C6EC8 Offset: 0x89C2EC8 VA: 0x89C6EC8
	public void GetRenderPass(int renderPassIndex, out XRDisplaySubsystem.XRRenderPass renderPass) { }

	[NativeMethod("TryGetRenderPass")]
	// RVA: 0x89C6F6C Offset: 0x89C2F6C VA: 0x89C6F6C
	private bool Internal_TryGetRenderPass(int renderPassIndex, out XRDisplaySubsystem.XRRenderPass renderPass) { }

	// RVA: 0x89C6FC0 Offset: 0x89C2FC0 VA: 0x89C6FC0
	public void GetCullingParameters(Camera camera, int cullingPassIndex, out ScriptableCullingParameters scriptableCullingParameters) { }

	[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/ScriptableCulling.h")]
	[NativeMethod("TryGetCullingParams")]
	// RVA: 0x89C70CC Offset: 0x89C30CC VA: 0x89C70CC
	private bool Internal_TryGetCullingParams(Camera camera, int cullingPassIndex, out ScriptableCullingParameters scriptableCullingParameters) { }

	[NativeMethod("TryGetDisplayRefreshRate")]
	// RVA: 0x89C7128 Offset: 0x89C3128 VA: 0x89C7128
	public bool TryGetDisplayRefreshRate(out float displayRefreshRate) { }

	[NativeMethod(Name = "GetPreferredMirrorViewBlitMode", IsThreadSafe = False)]
	[NativeConditional("ENABLE_XR")]
	// RVA: 0x89C716C Offset: 0x89C316C VA: 0x89C716C
	public int GetPreferredMirrorBlitMode() { }

	[NativeConditional("ENABLE_XR")]
	[NativeMethod(Name = "QueryMirrorViewBlitDesc", IsThreadSafe = False)]
	// RVA: 0x89C71A8 Offset: 0x89C31A8 VA: 0x89C71A8
	public bool GetMirrorViewBlitDesc(RenderTexture mirrorRt, out XRDisplaySubsystem.XRMirrorViewBlitDesc outDesc, int mode) { }

	[NativeConditional("ENABLE_XR")]
	[NativeMethod(Name = "AddGraphicsThreadMirrorViewBlit", IsThreadSafe = False)]
	[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
	// RVA: 0x89C7204 Offset: 0x89C3204 VA: 0x89C7204
	public bool AddGraphicsThreadMirrorViewBlit(CommandBuffer cmd, bool allowGraphicsStateInvalidate, int mode) { }

	// RVA: 0x89C7260 Offset: 0x89C3260 VA: 0x89C7260
	public HDROutputSettings get_hdrOutputSettings() { }

	// RVA: 0x89C72D4 Offset: 0x89C32D4 VA: 0x89C72D4
	public void .ctor() { }
}

// Namespace: UnityEngine.XR
[UsedByNativeCode]
[NativeType(Header = "Modules/XR/Subsystems/Display/XRDisplaySubsystemDescriptor.h")]
public class XRDisplaySubsystemDescriptor : IntegratedSubsystemDescriptor<XRDisplaySubsystem> // TypeDefIndex: 28444
{
	// Methods

	// RVA: 0x89C74F4 Offset: 0x89C34F4 VA: 0x89C74F4
	public void .ctor() { }
}

// Namespace: UnityEngine.XR
[NativeType(Header = "Modules/XR/Subsystems/Input/XRInputSubsystem.h")]
[NativeConditional("ENABLE_XR")]
[UsedByNativeCode]
public class XRInputSubsystem : IntegratedSubsystem<XRInputSubsystemDescriptor> // TypeDefIndex: 28445
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<XRInputSubsystem> trackingOriginUpdated; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<XRInputSubsystem> boundaryChanged; // 0x28

	// Methods

	[RequiredByNativeCode(GenerateProxy = True)]
	// RVA: 0x89C753C Offset: 0x89C353C VA: 0x89C753C
	private static void InvokeTrackingOriginUpdatedEvent(IntPtr internalPtr) { }

	[RequiredByNativeCode(GenerateProxy = True)]
	// RVA: 0x89C7600 Offset: 0x89C3600 VA: 0x89C7600
	private static void InvokeBoundaryChangedEvent(IntPtr internalPtr) { }

	// RVA: 0x89C76C4 Offset: 0x89C36C4 VA: 0x89C76C4
	public void .ctor() { }
}

// Namespace: UnityEngine.XR
[NativeConditional("ENABLE_XR")]
[UsedByNativeCode]
[NativeType(Header = "Modules/XR/Subsystems/Input/XRInputSubsystemDescriptor.h")]
[NativeHeader("Modules/XR/XRPrefix.h")]
public class XRInputSubsystemDescriptor : IntegratedSubsystemDescriptor<XRInputSubsystem> // TypeDefIndex: 28446
{
	// Methods

	// RVA: 0x89C770C Offset: 0x89C370C VA: 0x89C770C
	public void .ctor() { }
}

// Namespace: UnityEngine.XR
[UsedByNativeCode]
[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
public struct MeshId : IEquatable<MeshId> // TypeDefIndex: 28447
{
	// Fields
	private static MeshId s_InvalidId; // 0x0
	private ulong m_SubId1; // 0x0
	private ulong m_SubId2; // 0x8

	// Methods

	// RVA: 0x89C7754 Offset: 0x89C3754 VA: 0x89C7754 Slot: 3
	public override string ToString() { }

	// RVA: 0x89C77E8 Offset: 0x89C37E8 VA: 0x89C77E8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x89C781C Offset: 0x89C381C VA: 0x89C781C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x89C78D4 Offset: 0x89C38D4 VA: 0x89C78D4 Slot: 4
	public bool Equals(MeshId other) { }

	// RVA: 0x89C78F8 Offset: 0x89C38F8 VA: 0x89C78F8
	private static void .cctor() { }
}

// Namespace: UnityEngine.XR
[RequiredByNativeCode]
[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
public enum MeshGenerationStatus // TypeDefIndex: 28448
{
	// Fields
	public int value__; // 0x0
	public const MeshGenerationStatus Success = 0;
	public const MeshGenerationStatus InvalidMeshId = 1;
	public const MeshGenerationStatus GenerationAlreadyInProgress = 2;
	public const MeshGenerationStatus Canceled = 3;
	public const MeshGenerationStatus UnknownError = 4;
}

// Namespace: UnityEngine.XR
internal static class HashCodeHelper // TypeDefIndex: 28449
{
	// Methods

	// RVA: 0x89C7940 Offset: 0x89C3940 VA: 0x89C7940
	public static int Combine(int hash1, int hash2) { }

	// RVA: 0x89C7950 Offset: 0x89C3950 VA: 0x89C7950
	public static int Combine(int hash1, int hash2, int hash3) { }

	// RVA: 0x89C7964 Offset: 0x89C3964 VA: 0x89C7964
	public static int Combine(int hash1, int hash2, int hash3, int hash4) { }

	// RVA: 0x89C797C Offset: 0x89C397C VA: 0x89C797C
	public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5) { }

	// RVA: 0x89C7998 Offset: 0x89C3998 VA: 0x89C7998
	public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6) { }

	// RVA: 0x89C79B8 Offset: 0x89C39B8 VA: 0x89C79B8
	public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7) { }

	// RVA: 0x89C79DC Offset: 0x89C39DC VA: 0x89C79DC
	public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7, int hash8) { }
}

// Namespace: UnityEngine.XR
[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
[RequiredByNativeCode]
public struct MeshGenerationResult : IEquatable<MeshGenerationResult> // TypeDefIndex: 28450
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly MeshId <MeshId>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly Mesh <Mesh>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly MeshCollider <MeshCollider>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly MeshGenerationStatus <Status>k__BackingField; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly MeshVertexAttributes <Attributes>k__BackingField; // 0x24
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly ulong <Timestamp>k__BackingField; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly Vector3 <Position>k__BackingField; // 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly Quaternion <Rotation>k__BackingField; // 0x3C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly Vector3 <Scale>k__BackingField; // 0x4C

	// Properties
	public MeshId MeshId { get; }
	public Mesh Mesh { get; }
	public MeshCollider MeshCollider { get; }
	public MeshGenerationStatus Status { get; }
	public MeshVertexAttributes Attributes { get; }
	public Vector3 Position { get; }
	public Quaternion Rotation { get; }
	public Vector3 Scale { get; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x89C7A04 Offset: 0x89C3A04 VA: 0x89C7A04
	public MeshId get_MeshId() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x89C7A10 Offset: 0x89C3A10 VA: 0x89C7A10
	public Mesh get_Mesh() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x89C7A18 Offset: 0x89C3A18 VA: 0x89C7A18
	public MeshCollider get_MeshCollider() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x89C7A20 Offset: 0x89C3A20 VA: 0x89C7A20
	public MeshGenerationStatus get_Status() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x89C7A28 Offset: 0x89C3A28 VA: 0x89C7A28
	public MeshVertexAttributes get_Attributes() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x89C7A30 Offset: 0x89C3A30 VA: 0x89C7A30
	public Vector3 get_Position() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x89C7A3C Offset: 0x89C3A3C VA: 0x89C7A3C
	public Quaternion get_Rotation() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x89C7A48 Offset: 0x89C3A48 VA: 0x89C7A48
	public Vector3 get_Scale() { }

	// RVA: 0x89C7A54 Offset: 0x89C3A54 VA: 0x89C7A54 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x89C7AE4 Offset: 0x89C3AE4 VA: 0x89C7AE4 Slot: 4
	public bool Equals(MeshGenerationResult other) { }

	// RVA: 0x89C7CA8 Offset: 0x89C3CA8 VA: 0x89C7CA8 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.XR
[Flags]
[UsedByNativeCode]
[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
public enum MeshVertexAttributes // TypeDefIndex: 28451
{
	// Fields
	public int value__; // 0x0
	public const MeshVertexAttributes None = 0;
	public const MeshVertexAttributes Normals = 1;
	public const MeshVertexAttributes Tangents = 2;
	public const MeshVertexAttributes UVs = 4;
	public const MeshVertexAttributes Colors = 8;
}

// Namespace: 
[NativeConditional("ENABLE_XR")]
[IsReadOnly]
private struct XRMeshSubsystem.MeshTransformList : IDisposable // TypeDefIndex: 28452
{
	// Fields
	private readonly IntPtr m_Self; // 0x0

	// Methods

	// RVA: 0x89C7F88 Offset: 0x89C3F88 VA: 0x89C7F88 Slot: 4
	public void Dispose() { }

	[FreeFunction("UnityXRMeshTransformList_Dispose")]
	// RVA: 0x89C7FC4 Offset: 0x89C3FC4 VA: 0x89C7FC4
	private static void Dispose(IntPtr self) { }
}

// Namespace: UnityEngine.XR
[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshingSubsystem.h")]
[NativeConditional("ENABLE_XR")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[UsedByNativeCode]
public class XRMeshSubsystem : IntegratedSubsystem<XRMeshSubsystemDescriptor> // TypeDefIndex: 28453
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x89C7EE8 Offset: 0x89C3EE8 VA: 0x89C7EE8
	private void InvokeMeshReadyDelegate(MeshGenerationResult result, Action<MeshGenerationResult> onMeshGenerationComplete) { }

	// RVA: 0x89C7F40 Offset: 0x89C3F40 VA: 0x89C7F40
	public void .ctor() { }
}

// Namespace: UnityEngine.XR
[NativeType(Header = "Modules/XR/Subsystems/Planes/XRMeshSubsystemDescriptor.h")]
[UsedByNativeCode]
[NativeHeader("Modules/XR/XRPrefix.h")]
public class XRMeshSubsystemDescriptor : IntegratedSubsystemDescriptor<XRMeshSubsystem> // TypeDefIndex: 28454
{
	// Methods

	// RVA: 0x89C8000 Offset: 0x89C4000 VA: 0x89C8000
	public void .ctor() { }
}

