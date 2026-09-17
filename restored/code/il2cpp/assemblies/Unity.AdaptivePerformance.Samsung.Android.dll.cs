// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28212
{}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 28213
{
	// Fields
	public byte[] FilePathsData; // 0x0
	public byte[] TypesData; // 0x8
	public int TotalTypes; // 0x10
	public int TotalFiles; // 0x14
	public bool IsEditorOnly; // 0x18
}

// Namespace: 
[CompilerGenerated]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
[EditorBrowsable(1)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 28214
{
	// Methods

	// RVA: 0x85012B4 Offset: 0x84FD2B4 VA: 0x85012B4
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x85013AC Offset: 0x84FD3AC VA: 0x85013AC
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance
public class AdaptiveVariableRefreshRate : AdaptiveFramerate // TypeDefIndex: 28215
{
	// Fields
	private bool m_AdaptiveVRREnabled; // 0x48
	private IVariableRefreshRate m_VRR; // 0x50
	private int m_CurrentRefreshRateIndex; // 0x58
	private int m_DefaultRefreshRateIndex; // 0x5C

	// Properties
	public override string Name { get; }
	public override bool Enabled { get; set; }

	// Methods

	// RVA: 0x85013B4 Offset: 0x84FD3B4 VA: 0x85013B4 Slot: 4
	public override string get_Name() { }

	// RVA: 0x85013F4 Offset: 0x84FD3F4 VA: 0x85013F4 Slot: 6
	public override bool get_Enabled() { }

	// RVA: 0x85013FC Offset: 0x84FD3FC VA: 0x85013FC Slot: 7
	public override void set_Enabled(bool value) { }

	// RVA: 0x8501408 Offset: 0x84FD408 VA: 0x8501408 Slot: 20
	protected override void Awake() { }

	// RVA: 0x8501734 Offset: 0x84FD734 VA: 0x8501734 Slot: 25
	protected override void OnDisabled() { }

	// RVA: 0x85017F4 Offset: 0x84FD7F4 VA: 0x85017F4 Slot: 24
	protected override void OnEnabled() { }

	// RVA: 0x850193C Offset: 0x84FD93C VA: 0x850193C
	private void OnDestroy() { }

	// RVA: 0x8501A38 Offset: 0x84FDA38 VA: 0x8501A38
	private void RefreshRateChanged() { }

	// RVA: 0x8501B74 Offset: 0x84FDB74 VA: 0x8501B74 Slot: 21
	protected override void OnLevelIncrease() { }

	// RVA: 0x8501CFC Offset: 0x84FDCFC VA: 0x8501CFC Slot: 22
	protected override void OnLevelDecrease() { }

	// RVA: 0x8501EF8 Offset: 0x84FDEF8 VA: 0x8501EF8
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance.Samsung.Android
public static class SamsungAndroidProviderConstants // TypeDefIndex: 28216
{
	// Fields
	public const string k_SettingsKey = "com.unity.adaptiveperformance.samsung.android.provider_settings";
	public const int k_InvalidOperation = -999;
}

// Namespace: UnityEngine.AdaptivePerformance.Samsung.Android
public class SamsungAndroidProviderLoader : AdaptivePerformanceLoaderHelper // TypeDefIndex: 28217
{
	// Fields
	private static List<AdaptivePerformanceSubsystemDescriptor> s_SamsungGameSDKSubsystemDescriptors; // 0x0

	// Properties
	public override bool Initialized { get; }
	public override bool Running { get; }
	public SamsungGameSDKAdaptivePerformanceSubsystem samsungGameSDKSubsystem { get; }

	// Methods

	// RVA: 0x8501F00 Offset: 0x84FDF00 VA: 0x8501F00 Slot: 4
	public override bool get_Initialized() { }

	// RVA: 0x8501F7C Offset: 0x84FDF7C VA: 0x8501F7C Slot: 5
	public override bool get_Running() { }

	// RVA: 0x8501F18 Offset: 0x84FDF18 VA: 0x8501F18
	public SamsungGameSDKAdaptivePerformanceSubsystem get_samsungGameSDKSubsystem() { }

	// RVA: 0x8501FB0 Offset: 0x84FDFB0 VA: 0x8501FB0 Slot: 11
	public override ISubsystem GetDefaultSubsystem() { }

	// RVA: 0x8501FB4 Offset: 0x84FDFB4 VA: 0x8501FB4 Slot: 12
	public override IAdaptivePerformanceSettings GetSettings() { }

	// RVA: 0x8501FF4 Offset: 0x84FDFF4 VA: 0x8501FF4 Slot: 6
	public override bool Initialize() { }

	// RVA: 0x85020F0 Offset: 0x84FE0F0 VA: 0x85020F0 Slot: 7
	public override bool Start() { }

	// RVA: 0x8502140 Offset: 0x84FE140 VA: 0x8502140 Slot: 8
	public override bool Stop() { }

	// RVA: 0x8502190 Offset: 0x84FE190 VA: 0x8502190 Slot: 9
	public override bool Deinitialize() { }

	// RVA: 0x85021E4 Offset: 0x84FE1E4 VA: 0x85021E4
	public void .ctor() { }

	// RVA: 0x85021EC Offset: 0x84FE1EC VA: 0x85021EC
	private static void .cctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance.Samsung.Android
[AdaptivePerformanceConfigurationData("Samsung (Android)", "com.unity.adaptiveperformance.samsung.android.provider_settings")]
[Serializable]
public class SamsungAndroidProviderSettings : IAdaptivePerformanceSettings // TypeDefIndex: 28218
{
	// Fields
	[Tooltip("Enable Logging in Devmode")]
	[SerializeField]
	private bool m_SamsungProviderLogging; // 0x3C
	[SerializeField]
	[Tooltip("Allow High-Speed Variable Refresh Rate. It is required if you want to use variable refresh rates higher than 60hz. Can increase device temperature when activated.")]
	private bool m_HighSpeedVRR; // 0x3D
	[SerializeField]
	[Tooltip("Enable Automatic Variable Refresh Rate. Only enabled if VRR is supported on the target device.")]
	private bool m_AutomaticVRR; // 0x3E
	public static SamsungAndroidProviderSettings s_RuntimeInstance; // 0x0

	// Properties
	public bool samsungProviderLogging { get; set; }
	public bool highSpeedVRR { get; set; }
	public bool automaticVRR { get; set; }

	// Methods

	// RVA: 0x8502284 Offset: 0x84FE284 VA: 0x8502284
	public bool get_samsungProviderLogging() { }

	// RVA: 0x850228C Offset: 0x84FE28C VA: 0x850228C
	public void set_samsungProviderLogging(bool value) { }

	// RVA: 0x8502298 Offset: 0x84FE298 VA: 0x8502298
	public bool get_highSpeedVRR() { }

	// RVA: 0x85022A0 Offset: 0x84FE2A0 VA: 0x85022A0
	public void set_highSpeedVRR(bool value) { }

	// RVA: 0x85022AC Offset: 0x84FE2AC VA: 0x85022AC
	public bool get_automaticVRR() { }

	// RVA: 0x85022B4 Offset: 0x84FE2B4 VA: 0x85022B4
	public void set_automaticVRR(bool value) { }

	// RVA: 0x85022C0 Offset: 0x84FE2C0 VA: 0x85022C0
	private void Awake() { }

	// RVA: 0x8502318 Offset: 0x84FE318 VA: 0x8502318
	public static SamsungAndroidProviderSettings GetSettings() { }

	// RVA: 0x8502360 Offset: 0x84FE360 VA: 0x8502360
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance.Samsung.Android
internal static class GameSDKLog // TypeDefIndex: 28219
{
	// Fields
	private static SamsungAndroidProviderSettings settings; // 0x0

	// Methods

	[Conditional("DEVELOPMENT_BUILD")]
	// RVA: 0x8502370 Offset: 0x84FE370 VA: 0x8502370
	public static void Debug(string format, object[] args) { }

	// RVA: 0x85024B4 Offset: 0x84FE4B4 VA: 0x85024B4
	private static void .cctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance.Samsung.Android
internal class AsyncUpdater : IDisposable // TypeDefIndex: 28220
{
	// Fields
	private Thread m_Thread; // 0x10
	private bool m_Disposed; // 0x18
	private bool m_Quit; // 0x19
	private List<Action> m_UpdateAction; // 0x20
	private int[] m_UpdateRequests; // 0x28
	private bool[] m_RequestComplete; // 0x30
	private int m_UpdateRequestReadIndex; // 0x38
	private int m_UpdateRequestWriteIndex; // 0x3C
	private object m_Mutex; // 0x40
	private Semaphore m_Semaphore; // 0x48

	// Methods

	// RVA: 0x8502538 Offset: 0x84FE538 VA: 0x8502538
	public int Register(Action action) { }

	// RVA: 0x850260C Offset: 0x84FE60C VA: 0x850260C
	public void Start() { }

	// RVA: 0x8502720 Offset: 0x84FE720 VA: 0x8502720
	public bool RequestUpdate(int handle) { }

	// RVA: 0x850288C Offset: 0x84FE88C VA: 0x850288C
	public bool IsRequestComplete(int handle) { }

	// RVA: 0x8502980 Offset: 0x84FE980 VA: 0x8502980
	public void .ctor() { }

	// RVA: 0x8502AFC Offset: 0x84FEAFC VA: 0x8502AFC
	private void ThreadProc() { }

	// RVA: 0x8502E9C Offset: 0x84FEE9C VA: 0x8502E9C
	private void Dispose(bool disposing) { }

	// RVA: 0x8502FA4 Offset: 0x84FEFA4 VA: 0x8502FA4 Slot: 4
	public void Dispose() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AsyncValue.<>c__DisplayClass7_0<T> // TypeDefIndex: 28221
{
	// Fields
	public AsyncValue<T> <>4__this; // 0x0
	public Func<T> updateFunc; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545EC44 Offset: 0x545AC44 VA: 0x545EC44
	|-AsyncValue.<>c__DisplayClass7_0<double>..ctor
	|
	|-RVA: 0x545ECE0 Offset: 0x545ACE0 VA: 0x545ECE0
	|-AsyncValue.<>c__DisplayClass7_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <.ctor>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545EC4C Offset: 0x545AC4C VA: 0x545EC4C
	|-AsyncValue.<>c__DisplayClass7_0<double>.<.ctor>b__0
	|
	|-RVA: 0x545ECE8 Offset: 0x545ACE8 VA: 0x545ECE8
	|-AsyncValue.<>c__DisplayClass7_0<__Il2CppFullySharedGenericType>.<.ctor>b__0
	*/
}

// Namespace: UnityEngine.AdaptivePerformance.Samsung.Android
internal class AsyncValue<T> // TypeDefIndex: 28222
{
	// Fields
	private AsyncUpdater updater; // 0x0
	private int updateHandle; // 0x0
	private bool pendingUpdate; // 0x0
	private Func<T> updateFunc; // 0x0
	private T newValue; // 0x0
	private float updateTimeDeltaSeconds; // 0x0
	private float updateTimestamp; // 0x0
	[CompilerGenerated]
	private T <value>k__BackingField; // 0x0
	[CompilerGenerated]
	private float <changeTimestamp>k__BackingField; // 0x0

	// Properties
	public T value { get; set; }
	public float changeTimestamp { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(AsyncUpdater updater, T value, float updateTimeDeltaSeconds, Func<T> updateFunc) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5A7BD10 Offset: 0x5A77D10 VA: 0x5A7BD10
	|-AsyncValue<double>..ctor
	|
	|-RVA: 0x5A7BFFC Offset: 0x5A77FFC VA: 0x5A7BFFC
	|-AsyncValue<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool Update(float timestamp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5A7BE54 Offset: 0x5A77E54 VA: 0x5A7BE54
	|-AsyncValue<double>.Update
	|
	|-RVA: 0x5A7C25C Offset: 0x5A7825C VA: 0x5A7C25C
	|-AsyncValue<__Il2CppFullySharedGenericType>.Update
	*/

	// RVA: -1 Offset: -1
	public void SyncUpdate(float timestamp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5A7BF48 Offset: 0x5A77F48 VA: 0x5A7BF48
	|-AsyncValue<double>.SyncUpdate
	|
	|-RVA: 0x5A7C640 Offset: 0x5A78640 VA: 0x5A7C640
	|-AsyncValue<__Il2CppFullySharedGenericType>.SyncUpdate
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public T get_value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5A7BFDC Offset: 0x5A77FDC VA: 0x5A7BFDC
	|-AsyncValue<double>.get_value
	|
	|-RVA: 0x5A7C918 Offset: 0x5A78918 VA: 0x5A7C918
	|-AsyncValue<__Il2CppFullySharedGenericType>.get_value
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5A7BFE4 Offset: 0x5A77FE4 VA: 0x5A7BFE4
	|-AsyncValue<double>.set_value
	|
	|-RVA: 0x5A7C9B8 Offset: 0x5A789B8 VA: 0x5A7C9B8
	|-AsyncValue<__Il2CppFullySharedGenericType>.set_value
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public float get_changeTimestamp() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5A7BFEC Offset: 0x5A77FEC VA: 0x5A7BFEC
	|-AsyncValue<double>.get_changeTimestamp
	|
	|-RVA: 0x5A7CA70 Offset: 0x5A78A70 VA: 0x5A7CA70
	|-AsyncValue<__Il2CppFullySharedGenericType>.get_changeTimestamp
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_changeTimestamp(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5A7BFF4 Offset: 0x5A77FF4 VA: 0x5A7BFF4
	|-AsyncValue<double>.set_changeTimestamp
	|
	|-RVA: 0x5A7CA98 Offset: 0x5A78A98 VA: 0x5A7CA98
	|-AsyncValue<__Il2CppFullySharedGenericType>.set_changeTimestamp
	*/
}

// Namespace: 
internal class SamsungGameSDKAdaptivePerformanceSubsystem.SamsungGameSDKAdaptivePerformanceSubsystemProvider.NativeApi : AndroidJavaProxy // TypeDefIndex: 28223
{
	// Fields
	private static AndroidJavaObject s_GameSDK; // 0x0
	private static IntPtr s_GameSDKRawObjectID; // 0x8
	private static IntPtr s_GetGpuFrameTimeID; // 0x10
	private static IntPtr s_GetHighPrecisionSkinTempLevelID; // 0x18
	private static IntPtr s_GetClusterInfolID; // 0x20
	private static bool s_isAvailable; // 0x28
	private static jvalue[] s_NoArgs; // 0x30
	private Action<WarningLevel> PerformanceWarningEvent; // 0x20
	private Action PerformanceLevelTimeoutEvent; // 0x28
	private Action CpuPerformanceBoostReleasedByTimeoutEvent; // 0x30
	private Action GpuPerformanceBoostReleasedByTimeoutEvent; // 0x38
	private Action RefreshRateChangedEvent; // 0x40

	// Methods

	// RVA: 0x8503614 Offset: 0x84FF614 VA: 0x8503614
	public void .ctor(Action<WarningLevel> sustainedPerformanceWarning, Action sustainedPerformanceTimeout, Action refreshRateChanged, Action cpuPerformanceBoostReleasedByTimeout, Action gpuPerformanceBoostReleasedByTimeout) { }

	[Preserve]
	// RVA: 0x85071F8 Offset: 0x85031F8 VA: 0x85071F8
	private void onHighTempWarning(int warningLevel) { }

	[Preserve]
	// RVA: 0x8507274 Offset: 0x8503274 VA: 0x8507274
	private void onReleasedByTimeout() { }

	[Preserve]
	// RVA: 0x8507298 Offset: 0x8503298 VA: 0x8507298
	private void onReleasedCpuBoost() { }

	[Preserve]
	// RVA: 0x85072BC Offset: 0x85032BC VA: 0x85072BC
	private void onReleasedGpuBoost() { }

	[Preserve]
	// RVA: 0x85072E0 Offset: 0x85032E0 VA: 0x85072E0
	private void onRefreshRateChanged() { }

	// RVA: 0x8507304 Offset: 0x8503304 VA: 0x8507304
	private static IntPtr GetJavaMethodID(IntPtr classId, string name, string sig) { }

	// RVA: 0x8506D88 Offset: 0x8502D88 VA: 0x8506D88
	private static void StaticInit() { }

	// RVA: 0x8503174 Offset: 0x84FF174 VA: 0x8503174
	public static bool IsAvailable() { }

	// RVA: 0x8507398 Offset: 0x8503398 VA: 0x8507398
	public bool RegisterListener() { }

	// RVA: 0x8507528 Offset: 0x8503528 VA: 0x8507528
	public void UnregisterListener() { }

	// RVA: 0x8504210 Offset: 0x8500210 VA: 0x8504210
	public bool Initialize() { }

	// RVA: 0x8504904 Offset: 0x8500904 VA: 0x8504904
	public void Terminate() { }

	// RVA: 0x8504484 Offset: 0x8500484 VA: 0x8504484
	public string GetVersion() { }

	// RVA: 0x8503A64 Offset: 0x84FFA64 VA: 0x8503A64
	public double GetHighPrecisionSkinTempLevel() { }

	// RVA: 0x8506C64 Offset: 0x8502C64 VA: 0x8506C64
	public double GetGpuFrameTime() { }

	// RVA: 0x850607C Offset: 0x850207C VA: 0x850607C
	public int SetFreqLevels(int cpu, int gpu) { }

	// RVA: 0x85063E4 Offset: 0x85023E4 VA: 0x85063E4
	public bool EnableCpuBoost() { }

	// RVA: 0x85066C4 Offset: 0x85026C4 VA: 0x85066C4
	public bool EnableGpuBoost() { }

	// RVA: 0x8503BA4 Offset: 0x84FFBA4 VA: 0x8503BA4
	public int GetClusterInfo() { }

	// RVA: 0x8504614 Offset: 0x8500614 VA: 0x8504614
	public int GetMaxCpuPerformanceLevel() { }

	// RVA: 0x850478C Offset: 0x850078C VA: 0x850478C
	public int GetMaxGpuPerformanceLevel() { }

	// RVA: 0x8504D54 Offset: 0x8500D54 VA: 0x8504D54
	public bool IsVariableRefreshRateSupported() { }

	// RVA: 0x8507660 Offset: 0x8503660 VA: 0x8507660
	public int[] GetSupportedRefreshRates() { }

	// RVA: 0x85077FC Offset: 0x85037FC VA: 0x85077FC
	public bool SetRefreshRate(int targetRefreshRate) { }

	// RVA: 0x85079A4 Offset: 0x85039A4 VA: 0x85079A4
	public bool ResetRefreshRate() { }

	// RVA: 0x8507B08 Offset: 0x8503B08 VA: 0x8507B08
	public int GetCurrentRefreshRate() { }

	// RVA: 0x8507C80 Offset: 0x8503C80 VA: 0x8507C80
	private static void .cctor() { }
}

// Namespace: 
[Preserve]
internal class SamsungGameSDKAdaptivePerformanceSubsystem.SamsungGameSDKAdaptivePerformanceSubsystemProvider.VRRManager : IVariableRefreshRate // TypeDefIndex: 28224
{
	// Fields
	private SamsungGameSDKAdaptivePerformanceSubsystem.SamsungGameSDKAdaptivePerformanceSubsystemProvider.NativeApi m_Api; // 0x10
	private object m_RefreshRateChangedLock; // 0x18
	private bool m_RefreshRateChanged; // 0x20
	private int[] m_SupportedRefreshRates; // 0x28
	private int m_CurrentRefreshRate; // 0x30
	private int m_LastSetRefreshRate; // 0x34
	[CompilerGenerated]
	private VariableRefreshRateEventHandler RefreshRateChanged; // 0x38

	// Properties
	public int[] SupportedRefreshRates { get; }
	public int CurrentRefreshRate { get; }

	// Methods

	// RVA: 0x8507D18 Offset: 0x8503D18 VA: 0x8507D18
	private void UpdateRefreshRateInfo() { }

	// RVA: 0x8504ED0 Offset: 0x8500ED0 VA: 0x8504ED0
	public void .ctor(SamsungGameSDKAdaptivePerformanceSubsystem.SamsungGameSDKAdaptivePerformanceSubsystemProvider.NativeApi api) { }

	// RVA: 0x8507ED8 Offset: 0x8503ED8 VA: 0x8507ED8
	private void SetDefaultVRR() { }

	// RVA: 0x8506AD4 Offset: 0x8502AD4 VA: 0x8506AD4
	public void Resume() { }

	// RVA: 0x8505834 Offset: 0x8501834 VA: 0x8505834
	public void Update() { }

	// RVA: 0x85080B8 Offset: 0x85040B8 VA: 0x85080B8 Slot: 4
	public int[] get_SupportedRefreshRates() { }

	// RVA: 0x85080C0 Offset: 0x85040C0 VA: 0x85080C0 Slot: 5
	public int get_CurrentRefreshRate() { }

	// RVA: 0x85080C8 Offset: 0x85040C8 VA: 0x85080C8 Slot: 6
	public bool SetRefreshRateByIndex(int index) { }

	// RVA: 0x8507F84 Offset: 0x8503F84 VA: 0x8507F84
	private bool SetRefreshRateByIndexInternal(int index) { }

	[CompilerGenerated]
	// RVA: 0x8508144 Offset: 0x8504144 VA: 0x8508144 Slot: 7
	public void add_RefreshRateChanged(VariableRefreshRateEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x85081E0 Offset: 0x85041E0 VA: 0x85081E0 Slot: 8
	public void remove_RefreshRateChanged(VariableRefreshRateEventHandler value) { }

	// RVA: 0x850827C Offset: 0x850427C VA: 0x850827C
	public void OnRefreshRateChanged() { }
}

// Namespace: 
internal class SamsungGameSDKAdaptivePerformanceSubsystem.SamsungGameSDKAdaptivePerformanceSubsystemProvider.AutoVariableRefreshRate // TypeDefIndex: 28225
{
	// Fields
	private SamsungAndroidProviderSettings settings; // 0x10
	private IVariableRefreshRate vrrManager; // 0x18
	private float VrrUpdateTime; // 0x20
	private int lastRefreshRateIndex; // 0x24

	// Methods

	// RVA: 0x8504FA0 Offset: 0x8500FA0 VA: 0x8504FA0
	public void .ctor(IVariableRefreshRate vrrManagerInstance) { }

	// RVA: 0x8505994 Offset: 0x8501994 VA: 0x8505994
	public void UpdateAutoVRR() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SamsungGameSDKAdaptivePerformanceSubsystem.SamsungGameSDKAdaptivePerformanceSubsystemProvider.<>c // TypeDefIndex: 28226
{
	// Fields
	public static readonly SamsungGameSDKAdaptivePerformanceSubsystem.SamsungGameSDKAdaptivePerformanceSubsystemProvider.<>c <>9; // 0x0
	public static Action <>9__25_0; // 0x8

	// Methods

	// RVA: 0x8508338 Offset: 0x8504338 VA: 0x8508338
	private static void .cctor() { }

	// RVA: 0x85083A0 Offset: 0x85043A0 VA: 0x85083A0
	public void .ctor() { }

	// RVA: 0x85083A8 Offset: 0x85043A8 VA: 0x85083A8
	internal void <.ctor>b__25_0() { }
}

// Namespace: 
public class SamsungGameSDKAdaptivePerformanceSubsystem.SamsungGameSDKAdaptivePerformanceSubsystemProvider : AdaptivePerformanceSubsystem.APProvider, IApplicationLifecycle, IDevicePerformanceLevelControl // TypeDefIndex: 28227
{
	// Fields
	private SamsungGameSDKAdaptivePerformanceSubsystem.SamsungGameSDKAdaptivePerformanceSubsystemProvider.NativeApi m_Api; // 0x18
	private AsyncUpdater m_AsyncUpdater; // 0x20
	private PerformanceDataRecord m_Data; // 0x28
	private object m_DataLock; // 0x68
	private AsyncValue<double> m_SkinTemp; // 0x70
	private AsyncValue<double> m_GPUTime; // 0x78
	private Version m_Version; // 0x80
	private float m_MinTempLevel; // 0x88
	private float m_MaxTempLevel; // 0x8C
	private bool m_PerformanceLevelControlSystemChange; // 0x90
	private bool m_AllowPerformanceLevelControlChanges; // 0x91
	private SamsungGameSDKAdaptivePerformanceSubsystem.SamsungGameSDKAdaptivePerformanceSubsystemProvider.AutoVariableRefreshRate m_AutoVariableRefreshRate; // 0x98
	[CompilerGenerated]
	private int <MaxCpuPerformanceLevel>k__BackingField; // 0xA0
	[CompilerGenerated]
	private int <MaxGpuPerformanceLevel>k__BackingField; // 0xA4
	private static SamsungAndroidProviderSettings settings; // 0x0
	[CompilerGenerated]
	private Feature <Capabilities>k__BackingField; // 0xA8
	[CompilerGenerated]
	private bool <Initialized>k__BackingField; // 0xAC

	// Properties
	public override IApplicationLifecycle ApplicationLifecycle { get; }
	public override IDevicePerformanceLevelControl PerformanceLevelControl { get; }
	public int MaxCpuPerformanceLevel { get; set; }
	public int MaxGpuPerformanceLevel { get; set; }
	public override string Stats { get; }
	public override Version Version { get; }
	public override Feature Capabilities { get; set; }
	public override bool Initialized { get; set; }

	// Methods

	// RVA: 0x85031D8 Offset: 0x84FF1D8 VA: 0x85031D8 Slot: 11
	public override IApplicationLifecycle get_ApplicationLifecycle() { }

	// RVA: 0x85031DC Offset: 0x84FF1DC VA: 0x85031DC Slot: 12
	public override IDevicePerformanceLevelControl get_PerformanceLevelControl() { }

	[CompilerGenerated]
	// RVA: 0x85031E0 Offset: 0x84FF1E0 VA: 0x85031E0 Slot: 19
	public int get_MaxCpuPerformanceLevel() { }

	[CompilerGenerated]
	// RVA: 0x85031E8 Offset: 0x84FF1E8 VA: 0x85031E8
	public void set_MaxCpuPerformanceLevel(int value) { }

	[CompilerGenerated]
	// RVA: 0x85031F0 Offset: 0x84FF1F0 VA: 0x85031F0 Slot: 20
	public int get_MaxGpuPerformanceLevel() { }

	[CompilerGenerated]
	// RVA: 0x85031F8 Offset: 0x84FF1F8 VA: 0x85031F8
	public void set_MaxGpuPerformanceLevel(int value) { }

	// RVA: 0x8503200 Offset: 0x84FF200 VA: 0x8503200
	public void .ctor() { }

	// RVA: 0x8503728 Offset: 0x84FF728 VA: 0x8503728
	private void OnPerformanceWarning(WarningLevel warningLevel) { }

	// RVA: 0x85037F4 Offset: 0x84FF7F4 VA: 0x85037F4
	private void OnPerformanceLevelTimeout() { }

	// RVA: 0x85038BC Offset: 0x84FF8BC VA: 0x85038BC
	private void OnCpuPerformanceBoostModeTimeout() { }

	// RVA: 0x8503980 Offset: 0x84FF980 VA: 0x8503980
	private void OnGpuPerformanceBoostModeTimeout() { }

	// RVA: 0x8503A44 Offset: 0x84FFA44 VA: 0x8503A44
	private float GetHighPrecisionSkinTempLevel() { }

	// RVA: 0x8503B8C Offset: 0x84FFB8C VA: 0x8503B8C
	private int GetClusterInfo() { }

	// RVA: 0x8503CC4 Offset: 0x84FFCC4 VA: 0x8503CC4
	private void ImmediateUpdateTemperature() { }

	// RVA: 0x8503E28 Offset: 0x84FFE28 VA: 0x8503E28
	private static bool TryParseVersion(string versionString, out Version version) { }

	// RVA: 0x8503F24 Offset: 0x84FFF24 VA: 0x8503F24 Slot: 4
	protected override bool TryInitialize() { }

	// RVA: 0x8504AC4 Offset: 0x8500AC4 VA: 0x8504AC4 Slot: 5
	public override void Start() { }

	// RVA: 0x8504BAC Offset: 0x8500BAC VA: 0x8504BAC
	private void CheckAndInitializeVRR() { }

	// RVA: 0x8505020 Offset: 0x8501020 VA: 0x8505020
	private void CheckInitialTemperatureAndSendWarnings() { }

	// RVA: 0x85052A0 Offset: 0x85012A0 VA: 0x85052A0 Slot: 6
	public override void Stop() { }

	// RVA: 0x85052A8 Offset: 0x85012A8 VA: 0x85052A8 Slot: 7
	public override void Destroy() { }

	// RVA: 0x8505378 Offset: 0x8501378 VA: 0x8505378 Slot: 14
	public override string get_Stats() { }

	// RVA: 0x850543C Offset: 0x850143C VA: 0x850543C Slot: 10
	public override PerformanceDataRecord Update() { }

	// RVA: 0x8505CE0 Offset: 0x8501CE0 VA: 0x8505CE0 Slot: 13
	public override Version get_Version() { }

	[CompilerGenerated]
	// RVA: 0x8505CE8 Offset: 0x8501CE8 VA: 0x8505CE8 Slot: 8
	public override Feature get_Capabilities() { }

	[CompilerGenerated]
	// RVA: 0x8505CF0 Offset: 0x8501CF0 VA: 0x8505CF0 Slot: 9
	public override void set_Capabilities(Feature value) { }

	[CompilerGenerated]
	// RVA: 0x8505CF8 Offset: 0x8501CF8 VA: 0x8505CF8 Slot: 15
	public override bool get_Initialized() { }

	[CompilerGenerated]
	// RVA: 0x8505D00 Offset: 0x8501D00 VA: 0x8505D00 Slot: 16
	public override void set_Initialized(bool value) { }

	// RVA: 0x8505D0C Offset: 0x8501D0C VA: 0x8505D0C
	private static float NormalizeTemperatureLevel(float currentTempLevel, float minValue, float maxValue) { }

	// RVA: 0x8505DAC Offset: 0x8501DAC VA: 0x8505DAC
	private float NormalizeTemperatureLevel(float currentTempLevel) { }

	// RVA: 0x8503DD8 Offset: 0x84FFDD8 VA: 0x8503DD8
	private float GetTemperatureLevel() { }

	// RVA: 0x8505C88 Offset: 0x8501C88 VA: 0x8505C88
	private float LatestGpuFrameTime() { }

	// RVA: 0x8505E20 Offset: 0x8501E20 VA: 0x8505E20 Slot: 21
	public bool SetPerformanceLevel(ref int cpuLevel, ref int gpuLevel) { }

	// RVA: 0x85062C4 Offset: 0x85022C4 VA: 0x85062C4 Slot: 22
	public bool EnableCpuBoost() { }

	// RVA: 0x85065A4 Offset: 0x85025A4 VA: 0x85065A4 Slot: 23
	public bool EnableGpuBoost() { }

	// RVA: 0x8506884 Offset: 0x8502884 VA: 0x8506884 Slot: 17
	public void ApplicationPause() { }

	// RVA: 0x8506888 Offset: 0x8502888 VA: 0x8506888 Slot: 18
	public void ApplicationResume() { }

	// RVA: 0x85062A0 Offset: 0x85022A0 VA: 0x85062A0
	private void EnableSystemControl() { }

	// RVA: 0x8505C64 Offset: 0x8501C64 VA: 0x8505C64
	private void DisableSystemControl() { }

	// RVA: 0x8506BB4 Offset: 0x8502BB4 VA: 0x8506BB4
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x8506C38 Offset: 0x8502C38 VA: 0x8506C38
	private double <.ctor>b__25_1() { }

	[CompilerGenerated]
	// RVA: 0x8506C4C Offset: 0x8502C4C VA: 0x8506C4C
	private double <.ctor>b__25_2() { }
}

// Namespace: UnityEngine.AdaptivePerformance.Samsung.Android
[Preserve]
public class SamsungGameSDKAdaptivePerformanceSubsystem : AdaptivePerformanceSubsystem // TypeDefIndex: 28228
{
	// Methods

	[RuntimeInitializeOnLoadMethod(4)]
	// RVA: 0x8503008 Offset: 0x84FF008 VA: 0x8503008
	private static AdaptivePerformanceSubsystemDescriptor RegisterDescriptor() { }

	// RVA: 0x85031D0 Offset: 0x84FF1D0 VA: 0x85031D0
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance.Samsung.Android
public sealed class VariableRefreshRateEventHandler : MulticastDelegate // TypeDefIndex: 28229
{
	// Methods

	// RVA: 0x8501698 Offset: 0x84FD698 VA: 0x8501698
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x8508448 Offset: 0x8504448 VA: 0x8508448 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x850845C Offset: 0x850445C VA: 0x850845C Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x850847C Offset: 0x850447C VA: 0x850847C Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: UnityEngine.AdaptivePerformance.Samsung.Android
public interface IVariableRefreshRate // TypeDefIndex: 28230
{
	// Properties
	public abstract int[] SupportedRefreshRates { get; }
	public abstract int CurrentRefreshRate { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int[] get_SupportedRefreshRates();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_CurrentRefreshRate();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool SetRefreshRateByIndex(int index);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void add_RefreshRateChanged(VariableRefreshRateEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void remove_RefreshRateChanged(VariableRefreshRateEventHandler value);
}

// Namespace: UnityEngine.AdaptivePerformance.Samsung.Android
public static class VariableRefreshRate // TypeDefIndex: 28231
{
	// Fields
	[CompilerGenerated]
	private static IVariableRefreshRate <Instance>k__BackingField; // 0x0

	// Properties
	public static IVariableRefreshRate Instance { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8508488 Offset: 0x8504488 VA: 0x8508488
	public static IVariableRefreshRate get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x85084D0 Offset: 0x85044D0 VA: 0x85084D0
	public static void set_Instance(IVariableRefreshRate value) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=819 // TypeDefIndex: 28232
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1372 // TypeDefIndex: 28233
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 28234
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1372 1E7BD96FD332AF45B5613738DE0C64AA60D3383F327742A9BF569D16B71CB2B5 /*Metadata offset 0xF530A0*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=819 7241EE721A1D36B505476787A2B27D2A79C46F438D81C38F5487AD87A3D0A557 /*Metadata offset 0xF53600*/; // 0x55C
}

