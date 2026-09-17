// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28474
{}

// Namespace: UnityEngine
public enum TouchPhase // TypeDefIndex: 28475
{
	// Fields
	public int value__; // 0x0
	public const TouchPhase Began = 0;
	public const TouchPhase Moved = 1;
	public const TouchPhase Stationary = 2;
	public const TouchPhase Ended = 3;
	public const TouchPhase Canceled = 4;
}

// Namespace: UnityEngine
public enum IMECompositionMode // TypeDefIndex: 28476
{
	// Fields
	public int value__; // 0x0
	public const IMECompositionMode Auto = 0;
	public const IMECompositionMode On = 1;
	public const IMECompositionMode Off = 2;
}

// Namespace: UnityEngine
public enum TouchType // TypeDefIndex: 28477
{
	// Fields
	public int value__; // 0x0
	public const TouchType Direct = 0;
	public const TouchType Indirect = 1;
	public const TouchType Stylus = 2;
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Input/InputBindings.h")]
public struct Touch // TypeDefIndex: 28478
{
	// Fields
	private int m_FingerId; // 0x0
	private Vector2 m_Position; // 0x4
	private Vector2 m_RawPosition; // 0xC
	private Vector2 m_PositionDelta; // 0x14
	private float m_TimeDelta; // 0x1C
	private int m_TapCount; // 0x20
	private TouchPhase m_Phase; // 0x24
	private TouchType m_Type; // 0x28
	private float m_Pressure; // 0x2C
	private float m_maximumPossiblePressure; // 0x30
	private float m_Radius; // 0x34
	private float m_RadiusVariance; // 0x38
	private float m_AltitudeAngle; // 0x3C
	private float m_AzimuthAngle; // 0x40

	// Properties
	public int fingerId { get; }
	public Vector2 position { get; set; }
	public Vector2 rawPosition { get; set; }
	public Vector2 deltaPosition { get; set; }
	public float deltaTime { get; }
	public int tapCount { get; }
	public TouchPhase phase { get; }
	public float pressure { get; }
	public float maximumPossiblePressure { get; }
	public TouchType type { get; }
	public float altitudeAngle { get; }
	public float azimuthAngle { get; }
	public float radius { get; }
	public float radiusVariance { get; }

	// Methods

	// RVA: 0x87B2720 Offset: 0x87AE720 VA: 0x87B2720
	public int get_fingerId() { }

	// RVA: 0x87B2728 Offset: 0x87AE728 VA: 0x87B2728
	public Vector2 get_position() { }

	// RVA: 0x87B2730 Offset: 0x87AE730 VA: 0x87B2730
	public void set_position(Vector2 value) { }

	// RVA: 0x87B2738 Offset: 0x87AE738 VA: 0x87B2738
	public Vector2 get_rawPosition() { }

	// RVA: 0x87B2740 Offset: 0x87AE740 VA: 0x87B2740
	public void set_rawPosition(Vector2 value) { }

	// RVA: 0x87B2748 Offset: 0x87AE748 VA: 0x87B2748
	public Vector2 get_deltaPosition() { }

	// RVA: 0x87B2750 Offset: 0x87AE750 VA: 0x87B2750
	public void set_deltaPosition(Vector2 value) { }

	// RVA: 0x87B2758 Offset: 0x87AE758 VA: 0x87B2758
	public float get_deltaTime() { }

	// RVA: 0x87B2760 Offset: 0x87AE760 VA: 0x87B2760
	public int get_tapCount() { }

	// RVA: 0x87B2768 Offset: 0x87AE768 VA: 0x87B2768
	public TouchPhase get_phase() { }

	// RVA: 0x87B2770 Offset: 0x87AE770 VA: 0x87B2770
	public float get_pressure() { }

	// RVA: 0x87B2778 Offset: 0x87AE778 VA: 0x87B2778
	public float get_maximumPossiblePressure() { }

	// RVA: 0x87B2780 Offset: 0x87AE780 VA: 0x87B2780
	public TouchType get_type() { }

	// RVA: 0x87B2788 Offset: 0x87AE788 VA: 0x87B2788
	public float get_altitudeAngle() { }

	// RVA: 0x87B2790 Offset: 0x87AE790 VA: 0x87B2790
	public float get_azimuthAngle() { }

	// RVA: 0x87B2798 Offset: 0x87AE798 VA: 0x87B2798
	public float get_radius() { }

	// RVA: 0x87B27A0 Offset: 0x87AE7A0 VA: 0x87B27A0
	public float get_radiusVariance() { }
}

// Namespace: UnityEngine
[Flags]
public enum PenStatus // TypeDefIndex: 28479
{
	// Fields
	public int value__; // 0x0
	public const PenStatus None = 0;
	public const PenStatus Contact = 1;
	public const PenStatus Barrel = 2;
	public const PenStatus Inverted = 4;
	public const PenStatus Eraser = 8;
}

// Namespace: UnityEngine
public enum PenEventType // TypeDefIndex: 28480
{
	// Fields
	public int value__; // 0x0
	public const PenEventType NoContact = 0;
	public const PenEventType PenDown = 1;
	public const PenEventType PenUp = 2;
}

// Namespace: UnityEngine
public struct PenData // TypeDefIndex: 28481
{
	// Fields
	public Vector2 position; // 0x0
	public Vector2 tilt; // 0x8
	public PenStatus penStatus; // 0x10
	public float twist; // 0x14
	public float pressure; // 0x18
	public PenEventType contactType; // 0x1C
	public Vector2 deltaPos; // 0x20
}

// Namespace: UnityEngine
public enum DeviceOrientation // TypeDefIndex: 28482
{
	// Fields
	public int value__; // 0x0
	public const DeviceOrientation Unknown = 0;
	public const DeviceOrientation Portrait = 1;
	public const DeviceOrientation PortraitUpsideDown = 2;
	public const DeviceOrientation LandscapeLeft = 3;
	public const DeviceOrientation LandscapeRight = 4;
	public const DeviceOrientation FaceUp = 5;
	public const DeviceOrientation FaceDown = 6;
}

// Namespace: UnityEngine
public struct AccelerationEvent // TypeDefIndex: 28483
{
	// Fields
	internal float x; // 0x0
	internal float y; // 0x4
	internal float z; // 0x8
	internal float m_TimeDelta; // 0xC
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Input/GetInput.h")]
public class Gyroscope // TypeDefIndex: 28484
{
	// Fields
	private int m_GyroIndex; // 0x10

	// Methods

	// RVA: 0x87B27A8 Offset: 0x87AE7A8 VA: 0x87B27A8
	internal void .ctor(int index) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Input/LocationService.h")]
[NativeHeader("Runtime/Input/InputBindings.h")]
public class LocationService // TypeDefIndex: 28485
{
	// Methods

	// RVA: 0x87B27D0 Offset: 0x87AE7D0 VA: 0x87B27D0
	public void .ctor() { }
}

// Namespace: UnityEngine
public class Compass // TypeDefIndex: 28486
{
	// Methods

	// RVA: 0x87B27D8 Offset: 0x87AE7D8 VA: 0x87B27D8
	public void .ctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Camera/Camera.h")]
internal class CameraRaycastHelper // TypeDefIndex: 28487
{
	// Methods

	[FreeFunction("CameraScripting::RaycastTry")]
	// RVA: 0x87B27E0 Offset: 0x87AE7E0 VA: 0x87B27E0
	internal static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask) { }

	[FreeFunction("CameraScripting::RaycastTry2D")]
	// RVA: 0x87B28A8 Offset: 0x87AE8A8 VA: 0x87B28A8
	internal static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask) { }

	// RVA: 0x87B2844 Offset: 0x87AE844 VA: 0x87B2844
	private static GameObject RaycastTry_Injected(Camera cam, ref Ray ray, float distance, int layerMask) { }

	// RVA: 0x87B290C Offset: 0x87AE90C VA: 0x87B290C
	private static GameObject RaycastTry2D_Injected(Camera cam, ref Ray ray, float distance, int layerMask) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Input/InputBindings.h")]
public class Input // TypeDefIndex: 28488
{
	// Fields
	private static LocationService locationServiceInstance; // 0x0
	private static Compass compassInstance; // 0x8
	private static Gyroscope s_MainGyro; // 0x10

	// Properties
	public static bool simulateMouseWithTouches { get; set; }
	[NativeThrows]
	public static bool anyKey { get; }
	[NativeThrows]
	public static bool anyKeyDown { get; }
	[NativeThrows]
	public static string inputString { get; }
	[NativeThrows]
	public static Vector3 mousePosition { get; }
	[NativeThrows]
	public static Vector2 mouseScrollDelta { get; }
	public static IMECompositionMode imeCompositionMode { get; set; }
	public static string compositionString { get; }
	public static bool imeIsSelected { get; }
	public static Vector2 compositionCursorPos { get; set; }
	[Obsolete("eatKeyPressOnTextFieldFocus property is deprecated, and only provided to support legacy behavior.")]
	public static bool eatKeyPressOnTextFieldFocus { get; set; }
	public static bool mousePresent { get; }
	public static int penEventCount { get; }
	public static int touchCount { get; }
	public static bool touchPressureSupported { get; }
	public static bool stylusTouchSupported { get; }
	public static bool touchSupported { get; }
	public static bool multiTouchEnabled { get; set; }
	[Obsolete("isGyroAvailable property is deprecated. Please use SystemInfo.supportsGyroscope instead.")]
	public static bool isGyroAvailable { get; }
	public static DeviceOrientation deviceOrientation { get; }
	public static Vector3 acceleration { get; }
	public static bool compensateSensors { get; set; }
	public static int accelerationEventCount { get; }
	public static bool backButtonLeavesApp { get; set; }
	public static LocationService location { get; }
	public static Compass compass { get; }
	public static Gyroscope gyro { get; }
	public static Touch[] touches { get; }
	public static AccelerationEvent[] accelerationEvents { get; }

	// Methods

	// RVA: 0x87B2970 Offset: 0x87AE970 VA: 0x87B2970
	public static float GetAxis(string axisName) { }

	// RVA: 0x87B29E8 Offset: 0x87AE9E8 VA: 0x87B29E8
	public static float GetAxisRaw(string axisName) { }

	// RVA: 0x87B2A60 Offset: 0x87AEA60 VA: 0x87B2A60
	public static bool GetButton(string buttonName) { }

	// RVA: 0x87B2AD8 Offset: 0x87AEAD8 VA: 0x87B2AD8
	public static bool GetButtonDown(string buttonName) { }

	// RVA: 0x87B2B50 Offset: 0x87AEB50 VA: 0x87B2B50
	public static bool GetButtonUp(string buttonName) { }

	[NativeThrows]
	// RVA: 0x87B2BC8 Offset: 0x87AEBC8 VA: 0x87B2BC8
	private static bool GetKeyInt(KeyCode key) { }

	[NativeThrows]
	// RVA: 0x87B2C04 Offset: 0x87AEC04 VA: 0x87B2C04
	private static bool GetKeyUpInt(KeyCode key) { }

	[NativeThrows]
	// RVA: 0x87B2C40 Offset: 0x87AEC40 VA: 0x87B2C40
	private static bool GetKeyDownInt(KeyCode key) { }

	[NativeThrows]
	// RVA: 0x87B2C7C Offset: 0x87AEC7C VA: 0x87B2C7C
	public static bool GetMouseButton(int button) { }

	[NativeThrows]
	// RVA: 0x87B2CB8 Offset: 0x87AECB8 VA: 0x87B2CB8
	public static bool GetMouseButtonDown(int button) { }

	[NativeThrows]
	// RVA: 0x87B2CF4 Offset: 0x87AECF4 VA: 0x87B2CF4
	public static bool GetMouseButtonUp(int button) { }

	[FreeFunction("ResetInput")]
	// RVA: 0x87B2D30 Offset: 0x87AED30 VA: 0x87B2D30
	public static void ResetInputAxes() { }

	[NativeThrows]
	// RVA: 0x87B2D58 Offset: 0x87AED58 VA: 0x87B2D58
	public static string[] GetJoystickNames() { }

	[NativeThrows]
	// RVA: 0x87B2D80 Offset: 0x87AED80 VA: 0x87B2D80
	public static Touch GetTouch(int index) { }

	[NativeThrows]
	// RVA: 0x87B2E34 Offset: 0x87AEE34 VA: 0x87B2E34
	public static PenData GetPenEvent(int index) { }

	[NativeThrows]
	// RVA: 0x87B2EE4 Offset: 0x87AEEE4 VA: 0x87B2EE4
	public static PenData GetLastPenContactEvent() { }

	[NativeThrows]
	// RVA: 0x87B2F84 Offset: 0x87AEF84 VA: 0x87B2F84
	public static void ResetPenEvents() { }

	[NativeThrows]
	// RVA: 0x87B2FAC Offset: 0x87AEFAC VA: 0x87B2FAC
	public static void ClearLastPenContactEvent() { }

	[NativeThrows]
	// RVA: 0x87B2FD4 Offset: 0x87AEFD4 VA: 0x87B2FD4
	public static AccelerationEvent GetAccelerationEvent(int index) { }

	// RVA: 0x87B3070 Offset: 0x87AF070 VA: 0x87B3070
	public static bool GetKey(KeyCode key) { }

	// RVA: 0x87B30AC Offset: 0x87AF0AC VA: 0x87B30AC
	public static bool GetKey(string name) { }

	// RVA: 0x87B3124 Offset: 0x87AF124 VA: 0x87B3124
	public static bool GetKeyUp(KeyCode key) { }

	// RVA: 0x87B3160 Offset: 0x87AF160 VA: 0x87B3160
	public static bool GetKeyUp(string name) { }

	// RVA: 0x87B31D8 Offset: 0x87AF1D8 VA: 0x87B31D8
	public static bool GetKeyDown(KeyCode key) { }

	// RVA: 0x87B3214 Offset: 0x87AF214 VA: 0x87B3214
	public static bool GetKeyDown(string name) { }

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x87B328C Offset: 0x87AF28C VA: 0x87B328C
	internal static void SimulateTouch(Touch touch) { }

	[FreeFunction("SimulateTouch")]
	[NativeConditional("UNITY_EDITOR")]
	[Conditional("UNITY_EDITOR")]
	// RVA: 0x87B3290 Offset: 0x87AF290 VA: 0x87B3290
	private static void SimulateTouchInternal(Touch touch, long timestamp) { }

	// RVA: 0x87B3318 Offset: 0x87AF318 VA: 0x87B3318
	public static bool get_simulateMouseWithTouches() { }

	// RVA: 0x87B3340 Offset: 0x87AF340 VA: 0x87B3340
	public static void set_simulateMouseWithTouches(bool value) { }

	// RVA: 0x87B337C Offset: 0x87AF37C VA: 0x87B337C
	public static bool get_anyKey() { }

	// RVA: 0x87B33A4 Offset: 0x87AF3A4 VA: 0x87B33A4
	public static bool get_anyKeyDown() { }

	// RVA: 0x87B33CC Offset: 0x87AF3CC VA: 0x87B33CC
	public static string get_inputString() { }

	// RVA: 0x87B33F4 Offset: 0x87AF3F4 VA: 0x87B33F4
	public static Vector3 get_mousePosition() { }

	// RVA: 0x87B347C Offset: 0x87AF47C VA: 0x87B347C
	public static Vector2 get_mouseScrollDelta() { }

	// RVA: 0x87B34FC Offset: 0x87AF4FC VA: 0x87B34FC
	public static IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x87B3524 Offset: 0x87AF524 VA: 0x87B3524
	public static void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x87B3560 Offset: 0x87AF560 VA: 0x87B3560
	public static string get_compositionString() { }

	// RVA: 0x87B3588 Offset: 0x87AF588 VA: 0x87B3588
	public static bool get_imeIsSelected() { }

	// RVA: 0x87B35B0 Offset: 0x87AF5B0 VA: 0x87B35B0
	public static Vector2 get_compositionCursorPos() { }

	// RVA: 0x87B3630 Offset: 0x87AF630 VA: 0x87B3630
	public static void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x87B36AC Offset: 0x87AF6AC VA: 0x87B36AC
	public static bool get_eatKeyPressOnTextFieldFocus() { }

	// RVA: 0x87B36D4 Offset: 0x87AF6D4 VA: 0x87B36D4
	public static void set_eatKeyPressOnTextFieldFocus(bool value) { }

	[FreeFunction("GetMousePresent")]
	// RVA: 0x87B3710 Offset: 0x87AF710 VA: 0x87B3710
	public static bool get_mousePresent() { }

	[FreeFunction("GetPenEventCount")]
	// RVA: 0x87B3738 Offset: 0x87AF738 VA: 0x87B3738
	public static int get_penEventCount() { }

	[FreeFunction("GetTouchCount")]
	// RVA: 0x87B3760 Offset: 0x87AF760 VA: 0x87B3760
	public static int get_touchCount() { }

	[FreeFunction("IsTouchPressureSupported")]
	// RVA: 0x87B3788 Offset: 0x87AF788 VA: 0x87B3788
	public static bool get_touchPressureSupported() { }

	[FreeFunction("IsStylusTouchSupported")]
	// RVA: 0x87B37B0 Offset: 0x87AF7B0 VA: 0x87B37B0
	public static bool get_stylusTouchSupported() { }

	[FreeFunction("IsTouchSupported")]
	// RVA: 0x87B37D8 Offset: 0x87AF7D8 VA: 0x87B37D8
	public static bool get_touchSupported() { }

	[FreeFunction("IsMultiTouchEnabled")]
	// RVA: 0x87B3800 Offset: 0x87AF800 VA: 0x87B3800
	public static bool get_multiTouchEnabled() { }

	[FreeFunction("SetMultiTouchEnabled")]
	// RVA: 0x87B3828 Offset: 0x87AF828 VA: 0x87B3828
	public static void set_multiTouchEnabled(bool value) { }

	[FreeFunction("IsGyroAvailable")]
	// RVA: 0x87B3864 Offset: 0x87AF864 VA: 0x87B3864
	public static bool get_isGyroAvailable() { }

	[FreeFunction("GetDeviceOrientation")]
	// RVA: 0x87B388C Offset: 0x87AF88C VA: 0x87B388C
	public static DeviceOrientation get_deviceOrientation() { }

	[FreeFunction("GetAcceleration")]
	// RVA: 0x87B38B4 Offset: 0x87AF8B4 VA: 0x87B38B4
	public static Vector3 get_acceleration() { }

	[FreeFunction("IsCompensatingSensors")]
	// RVA: 0x87B393C Offset: 0x87AF93C VA: 0x87B393C
	public static bool get_compensateSensors() { }

	[FreeFunction("SetCompensatingSensors")]
	// RVA: 0x87B3964 Offset: 0x87AF964 VA: 0x87B3964
	public static void set_compensateSensors(bool value) { }

	[FreeFunction("GetAccelerationCount")]
	// RVA: 0x87B39A0 Offset: 0x87AF9A0 VA: 0x87B39A0
	public static int get_accelerationEventCount() { }

	[FreeFunction("GetBackButtonLeavesApp")]
	// RVA: 0x87B39C8 Offset: 0x87AF9C8 VA: 0x87B39C8
	public static bool get_backButtonLeavesApp() { }

	[FreeFunction("SetBackButtonLeavesApp")]
	// RVA: 0x87B39F0 Offset: 0x87AF9F0 VA: 0x87B39F0
	public static void set_backButtonLeavesApp(bool value) { }

	// RVA: 0x87B3A2C Offset: 0x87AFA2C VA: 0x87B3A2C
	public static LocationService get_location() { }

	// RVA: 0x87B3AC8 Offset: 0x87AFAC8 VA: 0x87B3AC8
	public static Compass get_compass() { }

	[FreeFunction("GetGyro")]
	// RVA: 0x87B3B5C Offset: 0x87AFB5C VA: 0x87B3B5C
	private static int GetGyroInternal() { }

	// RVA: 0x87B3B84 Offset: 0x87AFB84 VA: 0x87B3B84
	public static Gyroscope get_gyro() { }

	// RVA: 0x87B3C48 Offset: 0x87AFC48 VA: 0x87B3C48
	public static Touch[] get_touches() { }

	// RVA: 0x87B3D88 Offset: 0x87AFD88 VA: 0x87B3D88
	public static AccelerationEvent[] get_accelerationEvents() { }

	// RVA: 0x87B3E58 Offset: 0x87AFE58 VA: 0x87B3E58
	internal static bool CheckDisabled() { }

	// RVA: 0x87B3E80 Offset: 0x87AFE80 VA: 0x87B3E80
	public void .ctor() { }

	// RVA: 0x87B2DF0 Offset: 0x87AEDF0 VA: 0x87B2DF0
	private static void GetTouch_Injected(int index, out Touch ret) { }

	// RVA: 0x87B2EA0 Offset: 0x87AEEA0 VA: 0x87B2EA0
	private static void GetPenEvent_Injected(int index, out PenData ret) { }

	// RVA: 0x87B2F48 Offset: 0x87AEF48 VA: 0x87B2F48
	private static void GetLastPenContactEvent_Injected(out PenData ret) { }

	// RVA: 0x87B302C Offset: 0x87AF02C VA: 0x87B302C
	private static void GetAccelerationEvent_Injected(int index, out AccelerationEvent ret) { }

	// RVA: 0x87B32D4 Offset: 0x87AF2D4 VA: 0x87B32D4
	private static void SimulateTouchInternal_Injected(ref Touch touch, long timestamp) { }

	// RVA: 0x87B3440 Offset: 0x87AF440 VA: 0x87B3440
	private static void get_mousePosition_Injected(out Vector3 ret) { }

	// RVA: 0x87B34C0 Offset: 0x87AF4C0 VA: 0x87B34C0
	private static void get_mouseScrollDelta_Injected(out Vector2 ret) { }

	// RVA: 0x87B35F4 Offset: 0x87AF5F4 VA: 0x87B35F4
	private static void get_compositionCursorPos_Injected(out Vector2 ret) { }

	// RVA: 0x87B3670 Offset: 0x87AF670 VA: 0x87B3670
	private static void set_compositionCursorPos_Injected(ref Vector2 value) { }

	// RVA: 0x87B3900 Offset: 0x87AF900 VA: 0x87B3900
	private static void get_acceleration_Injected(out Vector3 ret) { }
}

// Namespace: 
private struct SendMouseEvents.HitInfo // TypeDefIndex: 28489
{
	// Fields
	public GameObject target; // 0x0
	public Camera camera; // 0x8

	// Methods

	// RVA: 0x87B4F24 Offset: 0x87B0F24 VA: 0x87B4F24
	public void SendMessage(string name) { }

	// RVA: 0x87B4E84 Offset: 0x87B0E84 VA: 0x87B4E84
	public static bool op_Implicit(SendMouseEvents.HitInfo exists) { }

	// RVA: 0x87B4F48 Offset: 0x87B0F48 VA: 0x87B4F48
	public static bool Compare(SendMouseEvents.HitInfo lhs, SendMouseEvents.HitInfo rhs) { }
}

// Namespace: UnityEngine
internal class SendMouseEvents // TypeDefIndex: 28490
{
	// Fields
	private static bool s_MouseUsed; // 0x0
	private static readonly SendMouseEvents.HitInfo[] m_LastHit; // 0x8
	private static readonly SendMouseEvents.HitInfo[] m_MouseDownHit; // 0x10
	private static readonly SendMouseEvents.HitInfo[] m_CurrentHit; // 0x18
	private static Camera[] m_Cameras; // 0x20
	public static Func<KeyValuePair<int, Vector2>> s_GetMouseState; // 0x28
	private static Vector2 s_MousePosition; // 0x30
	private static bool s_MouseButtonPressedThisFrame; // 0x38
	private static bool s_MouseButtonIsPressed; // 0x39

	// Methods

	// RVA: 0x87B3E88 Offset: 0x87AFE88 VA: 0x87B3E88
	private static void UpdateMouse() { }

	[RequiredByNativeCode]
	// RVA: 0x87B404C Offset: 0x87B004C VA: 0x87B404C
	private static void SetMouseMoved() { }

	[RequiredByNativeCode]
	// RVA: 0x87B40A8 Offset: 0x87B00A8 VA: 0x87B40A8
	private static void DoSendMouseEvents(int skipRTCameras) { }

	// RVA: 0x87B4A50 Offset: 0x87B0A50 VA: 0x87B4A50
	private static void SendEvents(int i, SendMouseEvents.HitInfo hit) { }

	// RVA: 0x87B4FFC Offset: 0x87B0FFC VA: 0x87B4FFC
	private static void .cctor() { }
}

// Namespace: UnityEngine.Internal
[NativeHeader("Runtime/Input/InputBindings.h")]
internal static class InputUnsafeUtility // TypeDefIndex: 28491
{
	// Methods

	[NativeThrows]
	// RVA: 0x87B30E8 Offset: 0x87AF0E8 VA: 0x87B30E8
	internal static bool GetKeyString(string name) { }

	[NativeThrows]
	// RVA: 0x87B50C0 Offset: 0x87B10C0 VA: 0x87B50C0
	internal static bool GetKeyString__Unmanaged(byte* name, int nameLen) { }

	[NativeThrows]
	// RVA: 0x87B319C Offset: 0x87AF19C VA: 0x87B319C
	internal static bool GetKeyUpString(string name) { }

	[NativeThrows]
	// RVA: 0x87B5104 Offset: 0x87B1104 VA: 0x87B5104
	internal static bool GetKeyUpString__Unmanaged(byte* name, int nameLen) { }

	[NativeThrows]
	// RVA: 0x87B3250 Offset: 0x87AF250 VA: 0x87B3250
	internal static bool GetKeyDownString(string name) { }

	[NativeThrows]
	// RVA: 0x87B5148 Offset: 0x87B1148 VA: 0x87B5148
	internal static bool GetKeyDownString__Unmanaged(byte* name, int nameLen) { }

	[NativeThrows]
	// RVA: 0x87B29AC Offset: 0x87AE9AC VA: 0x87B29AC
	internal static float GetAxis(string axisName) { }

	[NativeThrows]
	// RVA: 0x87B518C Offset: 0x87B118C VA: 0x87B518C
	internal static float GetAxis__Unmanaged(byte* axisName, int axisNameLen) { }

	[NativeThrows]
	// RVA: 0x87B2A24 Offset: 0x87AEA24 VA: 0x87B2A24
	internal static float GetAxisRaw(string axisName) { }

	[NativeThrows]
	// RVA: 0x87B51D0 Offset: 0x87B11D0 VA: 0x87B51D0
	internal static float GetAxisRaw__Unmanaged(byte* axisName, int axisNameLen) { }

	[NativeThrows]
	// RVA: 0x87B2A9C Offset: 0x87AEA9C VA: 0x87B2A9C
	internal static bool GetButton(string buttonName) { }

	[NativeThrows]
	// RVA: 0x87B5214 Offset: 0x87B1214 VA: 0x87B5214
	internal static bool GetButton__Unmanaged(byte* buttonName, int buttonNameLen) { }

	[NativeThrows]
	// RVA: 0x87B2B14 Offset: 0x87AEB14 VA: 0x87B2B14
	internal static bool GetButtonDown(string buttonName) { }

	[NativeThrows]
	// RVA: 0x87B5258 Offset: 0x87B1258 VA: 0x87B5258
	internal static byte GetButtonDown__Unmanaged(byte* buttonName, int buttonNameLen) { }

	[NativeThrows]
	// RVA: 0x87B2B8C Offset: 0x87AEB8C VA: 0x87B2B8C
	internal static bool GetButtonUp(string buttonName) { }

	[NativeThrows]
	// RVA: 0x87B529C Offset: 0x87B129C VA: 0x87B529C
	internal static bool GetButtonUp__Unmanaged(byte* buttonName, int buttonNameLen) { }
}

