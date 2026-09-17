// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 26775
{}

// Namespace: 
[UnsafeValueType]
[CompilerGenerated]
public struct AdaptivePerformanceProfilerStats.ScalerInfo.<scalerName>e__FixedBuffer // TypeDefIndex: 26776
{
	// Fields
	public byte FixedElementField; // 0x0
}

// Namespace: 
public struct AdaptivePerformanceProfilerStats.ScalerInfo // TypeDefIndex: 26777
{
	// Fields
	[FixedBuffer(typeof(byte), 320)]
	public AdaptivePerformanceProfilerStats.ScalerInfo.<scalerName>e__FixedBuffer scalerName; // 0x0
	public uint enabled; // 0x140
	public int overrideLevel; // 0x144
	public int currentLevel; // 0x148
	public int maxLevel; // 0x14C
	public float scale; // 0x150
	public uint applied; // 0x154
}

// Namespace: 
public static class AdaptivePerformanceProfilerStats // TypeDefIndex: 26778
{
	// Fields
	public static readonly ProfilerCategory AdaptivePerformanceProfilerCategory; // 0x0
	public static ProfilerCounter<float> CurrentCPUCounter; // 0x2
	public static ProfilerCounter<float> AvgCPUCounter; // 0x3
	public static ProfilerCounter<float> CurrentGPUCounter; // 0x4
	public static ProfilerCounter<float> AvgGPUCounter; // 0x5
	public static ProfilerCounter<int> CurrentCPULevelCounter; // 0x6
	public static ProfilerCounter<int> CurrentGPULevelCounter; // 0x7
	public static ProfilerCounter<float> CurrentFrametimeCounter; // 0x8
	public static ProfilerCounter<float> AvgFrametimeCounter; // 0x9
	public static ProfilerCounter<int> WarningLevelCounter; // 0xA
	public static ProfilerCounter<float> TemperatureLevelCounter; // 0xB
	public static ProfilerCounter<float> TemperatureTrendCounter; // 0xC
	public static ProfilerCounter<int> BottleneckCounter; // 0xD
	public static ProfilerCounter<int> PerformanceModeCounter; // 0xE
	public static readonly Guid kAdaptivePerformanceProfilerModuleGuid; // 0x10
	public static readonly int kScalerDataTag; // 0x20
	private static List<AdaptivePerformanceProfilerStats.ScalerInfo> scalerInfos; // 0x28
	private const int maxScalerNameSizeInBytes = 320;
	private static byte[] arr; // 0x30

	// Methods

	[Conditional("ENABLE_PROFILER")]
	// RVA: 0x84EEE08 Offset: 0x84EAE08 VA: 0x84EEE08
	public static void EmitScalerDataToProfilerStream(string scalerName, bool enabled, int overrideLevel, int currentLevel, float scale, bool applied, int maxLevel) { }

	// RVA: 0x84EF284 Offset: 0x84EB284 VA: 0x84EF284
	public static void FlushScalerDataToProfilerStream() { }

	// RVA: 0x84EF288 Offset: 0x84EB288 VA: 0x84EF288
	private static void .cctor() { }
}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 26779
{
	// Fields
	public byte[] FilePathsData; // 0x0
	public byte[] TypesData; // 0x8
	public int TotalTypes; // 0x10
	public int TotalFiles; // 0x14
	public bool IsEditorOnly; // 0x18
}

// Namespace: 
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
[CompilerGenerated]
[EditorBrowsable(1)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 26780
{
	// Methods

	// RVA: 0x84EF46C Offset: 0x84EB46C VA: 0x84EF46C
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x84EF564 Offset: 0x84EB564 VA: 0x84EF564
	public void .ctor() { }
}

// Namespace: 
internal static class AdaptivePerformanceAnalytics.AnalyticsLog // TypeDefIndex: 26781
{
	// Methods

	[Conditional("ADAPTIVE_PERFORMANCE_ANALYTICS_LOGGING")]
	// RVA: 0x84EF57C Offset: 0x84EB57C VA: 0x84EF57C
	public static void Debug(string format, object[] args) { }
}

// Namespace: UnityEngine.AdaptivePerformance
internal static class AdaptivePerformanceAnalytics // TypeDefIndex: 26782
{
	// Methods

	[Conditional("UNITY_ANALYTICS")]
	// RVA: 0x84EF56C Offset: 0x84EB56C VA: 0x84EF56C
	public static void RegisterFeature(string feature, bool status) { }

	[Conditional("UNITY_ANALYTICS")]
	// RVA: 0x84EF570 Offset: 0x84EB570 VA: 0x84EF570
	public static void SendAdaptiveStartupEvent(AdaptivePerformanceSubsystem subsystem) { }

	[Conditional("UNITY_ANALYTICS")]
	// RVA: 0x84EF574 Offset: 0x84EB574 VA: 0x84EF574
	public static void SendAdaptiveFeatureUpdateEvent(string feature, bool status) { }

	[Conditional("UNITY_ANALYTICS")]
	// RVA: 0x84EF578 Offset: 0x84EB578 VA: 0x84EF578
	public static void SendAdaptivePerformanceThermalEvent(ThermalMetrics thermalMetrics) { }
}

// Namespace: UnityEngine.AdaptivePerformance
internal class BottleneckUtil // TypeDefIndex: 26783
{
	// Methods

	// RVA: 0x84EF714 Offset: 0x84EB714 VA: 0x84EF714
	public static PerformanceBottleneck DetermineBottleneck(PerformanceBottleneck prevBottleneck, float averageCpuFrameTime, float averageGpuFrametime, float averageOverallFrametime, float targetFrameTime) { }

	// RVA: 0x84EF838 Offset: 0x84EB838 VA: 0x84EF838
	private static bool HittingFrameRateLimit(float actualFrameTime, float thresholdFactor, float targetFrameTime) { }

	// RVA: 0x84EF868 Offset: 0x84EB868 VA: 0x84EF868
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance
internal class AdaptivePerformanceManagerSpawner : ScriptableObject // TypeDefIndex: 26784
{
	// Fields
	public const string AdaptivePerformanceManagerObjectName = "AdaptivePerformanceManager";
	private GameObject m_ManagerGameObject; // 0x18

	// Properties
	public GameObject ManagerGameObject { get; }

	// Methods

	// RVA: 0x84EF870 Offset: 0x84EB870 VA: 0x84EF870
	public GameObject get_ManagerGameObject() { }

	// RVA: 0x84EF878 Offset: 0x84EB878 VA: 0x84EF878
	private void OnEnable() { }

	// RVA: 0x84EF918 Offset: 0x84EB918 VA: 0x84EF918
	public void Initialize(bool isCheckingProvider) { }

	// RVA: 0x84EFABC Offset: 0x84EBABC VA: 0x84EFABC
	public void Deinitialize() { }

	// RVA: 0x84EFBFC Offset: 0x84EBBFC VA: 0x84EFBFC
	private void InstallScalers() { }

	// RVA: 0x84EFF04 Offset: 0x84EBF04 VA: 0x84EFF04
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance
internal static class AdaptivePerformanceInitializer // TypeDefIndex: 26785
{
	// Fields
	private static AdaptivePerformanceManagerSpawner s_Spawner; // 0x0

	// Methods

	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x84EFF0C Offset: 0x84EBF0C VA: 0x84EFF0C
	private static void AutoInitialize() { }

	// RVA: 0x84F0068 Offset: 0x84EC068 VA: 0x84F0068
	public static void Initialize() { }

	// RVA: 0x84F0070 Offset: 0x84EC070 VA: 0x84F0070
	public static void Deinitialize() { }

	// RVA: 0x84EFF14 Offset: 0x84EBF14 VA: 0x84EFF14
	private static void InitializeSpawner(bool isAuto) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AdaptivePerformanceManager.<InvokeEndOfFrame>d__108 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 26786
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AdaptivePerformanceManager <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x84F19A8 Offset: 0x84ED9A8 VA: 0x84F19A8
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x84F435C Offset: 0x84F035C VA: 0x84F435C Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x84F4360 Offset: 0x84F0360 VA: 0x84F4360 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x84F4410 Offset: 0x84F0410 VA: 0x84F4410 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x84F4418 Offset: 0x84F0418 VA: 0x84F4418 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x84F4450 Offset: 0x84F0450 VA: 0x84F4450 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: UnityEngine.AdaptivePerformance
internal class AdaptivePerformanceManager : MonoBehaviour, IAdaptivePerformance, IThermalStatus, IPerformanceStatus, IDevicePerformanceControl, IDevelopmentSettings, IPerformanceModeStatus // TypeDefIndex: 26787
{
	// Fields
	[CompilerGenerated]
	private ThermalEventHandler ThermalEvent; // 0x20
	[CompilerGenerated]
	private PerformanceBottleneckChangeHandler PerformanceBottleneckChangeEvent; // 0x28
	[CompilerGenerated]
	private PerformanceLevelChangeHandler PerformanceLevelChangeEvent; // 0x30
	[CompilerGenerated]
	private PerformanceBoostChangeHandler PerformanceBoostChangeEvent; // 0x38
	[CompilerGenerated]
	private PerformanceModeEventHandler PerformanceModeEvent; // 0x40
	private bool m_JustResumed; // 0x48
	private int m_RequestedCpuLevel; // 0x4C
	private int m_RequestedGpuLevel; // 0x50
	private bool m_NewUserPerformanceLevelRequest; // 0x54
	private bool m_RequestedCpuBoost; // 0x55
	private bool m_RequestedGpuBoost; // 0x56
	private bool m_NewUserCpuPerformanceBoostRequest; // 0x57
	private bool m_NewUserGpuPerformanceBoostRequest; // 0x58
	private ThermalMetrics m_ThermalMetrics; // 0x5C
	private PerformanceMetrics m_PerformanceMetrics; // 0x68
	private FrameTiming m_FrameTiming; // 0x84
	private PerformanceMode m_PerformanceMode; // 0x9C
	[CompilerGenerated]
	private int <LoggingFrequencyInFrames>k__BackingField; // 0xA0
	private bool m_AutomaticPerformanceControl; // 0xA4
	private bool m_AutomaticPerformanceControlChanged; // 0xA5
	[CompilerGenerated]
	private AdaptivePerformanceIndexer <Indexer>k__BackingField; // 0xA8
	private IAdaptivePerformanceSettings m_Settings; // 0xB0
	private AdaptivePerformanceSubsystem m_Subsystem; // 0xB8
	private DevicePerformanceControlImpl m_DevicePerfControl; // 0xC0
	private AutoPerformanceLevelController m_AutoPerformanceLevelController; // 0xC8
	private AutoPerformanceModeController m_AutoPerformanceModeController; // 0xD0
	private CpuTimeProvider m_CpuFrameTimeProvider; // 0xD8
	private GpuTimeProvider m_GpuFrameTimeProvider; // 0xE0
	private IApplicationLifecycle m_AppLifecycle; // 0xE8
	private TemperatureTrend m_TemperatureTrend; // 0xF0
	private bool m_UseProviderOverallFrameTime; // 0xF8
	private WaitForEndOfFrame m_WaitForEndOfFrame; // 0x100
	private int m_FrameCount; // 0x108
	private RunningAverage m_OverallFrameTime; // 0x110
	private float m_OverallFrameTimeAccu; // 0x118
	private RunningAverage m_GpuFrameTime; // 0x120
	private RunningAverage m_CpuFrameTime; // 0x128

	// Properties
	public ThermalMetrics ThermalMetrics { get; }
	public PerformanceMetrics PerformanceMetrics { get; }
	public FrameTiming FrameTiming { get; }
	public PerformanceMode PerformanceMode { get; }
	public bool Logging { get; set; }
	public int LoggingFrequencyInFrames { get; set; }
	public bool Initialized { get; }
	public bool Active { get; }
	public int MaxCpuPerformanceLevel { get; }
	public int MaxGpuPerformanceLevel { get; }
	public bool AutomaticPerformanceControl { get; set; }
	public PerformanceControlMode PerformanceControlMode { get; }
	public int CpuLevel { get; set; }
	public int GpuLevel { get; set; }
	public bool CpuPerformanceBoost { get; set; }
	public bool GpuPerformanceBoost { get; set; }
	public IDevelopmentSettings DevelopmentSettings { get; }
	public IThermalStatus ThermalStatus { get; }
	public IPerformanceStatus PerformanceStatus { get; }
	public IDevicePerformanceControl DevicePerformanceControl { get; }
	public IPerformanceModeStatus PerformanceModeStatus { get; }
	public AdaptivePerformanceIndexer Indexer { get; set; }
	public IAdaptivePerformanceSettings Settings { get; set; }
	public AdaptivePerformanceSubsystem Subsystem { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x84F0154 Offset: 0x84EC154 VA: 0x84F0154 Slot: 20
	public void add_ThermalEvent(ThermalEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x84F01F0 Offset: 0x84EC1F0 VA: 0x84F01F0 Slot: 21
	public void remove_ThermalEvent(ThermalEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x84F028C Offset: 0x84EC28C VA: 0x84F028C Slot: 24
	public void add_PerformanceBottleneckChangeEvent(PerformanceBottleneckChangeHandler value) { }

	[CompilerGenerated]
	// RVA: 0x84F0328 Offset: 0x84EC328 VA: 0x84F0328 Slot: 25
	public void remove_PerformanceBottleneckChangeEvent(PerformanceBottleneckChangeHandler value) { }

	[CompilerGenerated]
	// RVA: 0x84F03C4 Offset: 0x84EC3C4 VA: 0x84F03C4 Slot: 26
	public void add_PerformanceLevelChangeEvent(PerformanceLevelChangeHandler value) { }

	[CompilerGenerated]
	// RVA: 0x84F0460 Offset: 0x84EC460 VA: 0x84F0460 Slot: 27
	public void remove_PerformanceLevelChangeEvent(PerformanceLevelChangeHandler value) { }

	[CompilerGenerated]
	// RVA: 0x84F04FC Offset: 0x84EC4FC VA: 0x84F04FC Slot: 28
	public void add_PerformanceBoostChangeEvent(PerformanceBoostChangeHandler value) { }

	[CompilerGenerated]
	// RVA: 0x84F0598 Offset: 0x84EC598 VA: 0x84F0598 Slot: 29
	public void remove_PerformanceBoostChangeEvent(PerformanceBoostChangeHandler value) { }

	[CompilerGenerated]
	// RVA: 0x84F0634 Offset: 0x84EC634 VA: 0x84F0634 Slot: 49
	public void add_PerformanceModeEvent(PerformanceModeEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x84F06D0 Offset: 0x84EC6D0 VA: 0x84F06D0 Slot: 50
	public void remove_PerformanceModeEvent(PerformanceModeEventHandler value) { }

	// RVA: 0x84F076C Offset: 0x84EC76C VA: 0x84F076C Slot: 19
	public ThermalMetrics get_ThermalMetrics() { }

	// RVA: 0x84F077C Offset: 0x84EC77C VA: 0x84F077C Slot: 22
	public PerformanceMetrics get_PerformanceMetrics() { }

	// RVA: 0x84F0790 Offset: 0x84EC790 VA: 0x84F0790 Slot: 23
	public FrameTiming get_FrameTiming() { }

	// RVA: 0x84F07A4 Offset: 0x84EC7A4 VA: 0x84F07A4 Slot: 48
	public PerformanceMode get_PerformanceMode() { }

	// RVA: 0x84F07AC Offset: 0x84EC7AC VA: 0x84F07AC Slot: 44
	public bool get_Logging() { }

	// RVA: 0x84F07F4 Offset: 0x84EC7F4 VA: 0x84F07F4 Slot: 45
	public void set_Logging(bool value) { }

	[CompilerGenerated]
	// RVA: 0x84F0844 Offset: 0x84EC844 VA: 0x84F0844 Slot: 46
	public int get_LoggingFrequencyInFrames() { }

	[CompilerGenerated]
	// RVA: 0x84F084C Offset: 0x84EC84C VA: 0x84F084C Slot: 47
	public void set_LoggingFrequencyInFrames(int value) { }

	// RVA: 0x84F0854 Offset: 0x84EC854 VA: 0x84F0854 Slot: 4
	public bool get_Initialized() { }

	// RVA: 0x84F099C Offset: 0x84EC99C VA: 0x84F099C Slot: 5
	public bool get_Active() { }

	// RVA: 0x84F0B28 Offset: 0x84ECB28 VA: 0x84F0B28 Slot: 34
	public int get_MaxCpuPerformanceLevel() { }

	// RVA: 0x84F0BE8 Offset: 0x84ECBE8 VA: 0x84F0BE8 Slot: 35
	public int get_MaxGpuPerformanceLevel() { }

	// RVA: 0x84F0CAC Offset: 0x84ECCAC VA: 0x84F0CAC Slot: 31
	public bool get_AutomaticPerformanceControl() { }

	// RVA: 0x84F0CB4 Offset: 0x84ECCB4 VA: 0x84F0CB4 Slot: 32
	public void set_AutomaticPerformanceControl(bool value) { }

	// RVA: 0x84F0CC8 Offset: 0x84ECCC8 VA: 0x84F0CC8 Slot: 33
	public PerformanceControlMode get_PerformanceControlMode() { }

	// RVA: 0x84F0CE0 Offset: 0x84ECCE0 VA: 0x84F0CE0 Slot: 36
	public int get_CpuLevel() { }

	// RVA: 0x84F0CE8 Offset: 0x84ECCE8 VA: 0x84F0CE8 Slot: 37
	public void set_CpuLevel(int value) { }

	// RVA: 0x84F0CF8 Offset: 0x84ECCF8 VA: 0x84F0CF8 Slot: 38
	public int get_GpuLevel() { }

	// RVA: 0x84F0D00 Offset: 0x84ECD00 VA: 0x84F0D00 Slot: 39
	public void set_GpuLevel(int value) { }

	// RVA: 0x84F0D10 Offset: 0x84ECD10 VA: 0x84F0D10 Slot: 40
	public bool get_CpuPerformanceBoost() { }

	// RVA: 0x84F0D18 Offset: 0x84ECD18 VA: 0x84F0D18 Slot: 41
	public void set_CpuPerformanceBoost(bool value) { }

	// RVA: 0x84F0D2C Offset: 0x84ECD2C VA: 0x84F0D2C Slot: 42
	public bool get_GpuPerformanceBoost() { }

	// RVA: 0x84F0D34 Offset: 0x84ECD34 VA: 0x84F0D34 Slot: 43
	public void set_GpuPerformanceBoost(bool value) { }

	// RVA: 0x84F0D48 Offset: 0x84ECD48 VA: 0x84F0D48 Slot: 10
	public IDevelopmentSettings get_DevelopmentSettings() { }

	// RVA: 0x84F0D4C Offset: 0x84ECD4C VA: 0x84F0D4C Slot: 6
	public IThermalStatus get_ThermalStatus() { }

	// RVA: 0x84F0D50 Offset: 0x84ECD50 VA: 0x84F0D50 Slot: 7
	public IPerformanceStatus get_PerformanceStatus() { }

	// RVA: 0x84F0D54 Offset: 0x84ECD54 VA: 0x84F0D54 Slot: 8
	public IDevicePerformanceControl get_DevicePerformanceControl() { }

	// RVA: 0x84F0D58 Offset: 0x84ECD58 VA: 0x84F0D58 Slot: 9
	public IPerformanceModeStatus get_PerformanceModeStatus() { }

	[CompilerGenerated]
	// RVA: 0x84F0D5C Offset: 0x84ECD5C VA: 0x84F0D5C Slot: 11
	public AdaptivePerformanceIndexer get_Indexer() { }

	[CompilerGenerated]
	// RVA: 0x84F0D64 Offset: 0x84ECD64 VA: 0x84F0D64
	private void set_Indexer(AdaptivePerformanceIndexer value) { }

	// RVA: 0x84F0D6C Offset: 0x84ECD6C VA: 0x84F0D6C Slot: 12
	public IAdaptivePerformanceSettings get_Settings() { }

	// RVA: 0x84F0D74 Offset: 0x84ECD74 VA: 0x84F0D74
	private void set_Settings(IAdaptivePerformanceSettings value) { }

	// RVA: 0x84F0D7C Offset: 0x84ECD7C VA: 0x84F0D7C Slot: 13
	public AdaptivePerformanceSubsystem get_Subsystem() { }

	// RVA: 0x84F0D84 Offset: 0x84ECD84 VA: 0x84F0D84 Slot: 14
	public bool SupportedFeature(Feature feature) { }

	// RVA: 0x84F0DB4 Offset: 0x84ECDB4 VA: 0x84F0DB4
	public void Awake() { }

	// RVA: 0x84F1830 Offset: 0x84ED830 VA: 0x84F1830
	private void LogThermalEvent(ThermalMetrics ev) { }

	// RVA: 0x84F1834 Offset: 0x84ED834 VA: 0x84F1834
	private void LogBottleneckEvent(PerformanceBottleneckChangeEventArgs ev) { }

	// RVA: 0x84F1838 Offset: 0x84ED838 VA: 0x84F1838
	private void LogBoostEvent(PerformanceBoostChangeEventArgs ev) { }

	// RVA: 0x84F183C Offset: 0x84ED83C VA: 0x84F183C
	private void LogPerformanceModeEvent(PerformanceMode performanceMode) { }

	// RVA: 0x84F1840 Offset: 0x84ED840 VA: 0x84F1840
	private static string ToStringWithSign(int x) { }

	// RVA: 0x84F1890 Offset: 0x84ED890 VA: 0x84F1890
	private void LogPerformanceLevelEvent(PerformanceLevelChangeEventArgs ev) { }

	// RVA: 0x84F1894 Offset: 0x84ED894 VA: 0x84F1894
	private void AddNonNegativeValue(RunningAverage runningAverage, float value) { }

	[IteratorStateMachine(typeof(AdaptivePerformanceManager.<InvokeEndOfFrame>d__108))]
	// RVA: 0x84F193C Offset: 0x84ED93C VA: 0x84F193C
	private IEnumerator InvokeEndOfFrame() { }

	// RVA: 0x84F19D0 Offset: 0x84ED9D0 VA: 0x84F19D0
	public void LateUpdate() { }

	// RVA: 0x84F1A90 Offset: 0x84EDA90 VA: 0x84F1A90
	public void Update() { }

	// RVA: 0x84F2438 Offset: 0x84EE438 VA: 0x84F2438
	private void CollectProfilerStats() { }

	// RVA: 0x84F243C Offset: 0x84EE43C VA: 0x84F243C
	private void AccumulateTimingValue(ref float accu, float newValue) { }

	// RVA: 0x84F1B24 Offset: 0x84EDB24 VA: 0x84F1B24
	private void UpdateSubsystem() { }

	// RVA: 0x84F1A28 Offset: 0x84EDA28 VA: 0x84F1A28
	private static bool WillCurrentFrameRender() { }

	// RVA: 0x84F2658 Offset: 0x84EE658 VA: 0x84F2658
	public static float EffectiveTargetFrameRate() { }

	// RVA: 0x84F2CCC Offset: 0x84EECCC VA: 0x84F2CCC
	public void OnDestroy() { }

	// RVA: 0x84F0F14 Offset: 0x84ECF14 VA: 0x84F0F14 Slot: 15
	public void InitializeAdaptivePerformance() { }

	// RVA: 0x84F3B94 Offset: 0x84EFB94 VA: 0x84F3B94 Slot: 16
	public void StartAdaptivePerformance() { }

	// RVA: 0x84F3D30 Offset: 0x84EFD30 VA: 0x84F3D30 Slot: 17
	public void StopAdaptivePerformance() { }

	// RVA: 0x84F2CD0 Offset: 0x84EECD0 VA: 0x84F2CD0 Slot: 18
	public void DeinitializeAdaptivePerformance() { }

	// RVA: 0x84F4010 Offset: 0x84F0010 VA: 0x84F4010
	public void OnApplicationPause(bool pause) { }

	// RVA: 0x84F41C0 Offset: 0x84F01C0 VA: 0x84F41C0
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance
internal static class APLog // TypeDefIndex: 26788
{
	// Fields
	public static bool enabled; // 0x0

	// Methods

	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	// RVA: 0x84F4458 Offset: 0x84F0458 VA: 0x84F4458
	public static void Debug(string format, object[] args) { }
}

// Namespace: UnityEngine.AdaptivePerformance
internal class AutoPerformanceLevelController // TypeDefIndex: 26789
{
	// Fields
	private IDevicePerformanceControl m_PerfControl; // 0x10
	private IPerformanceStatus m_PerfStats; // 0x18
	private IThermalStatus m_ThermalStats; // 0x20
	private float m_LastChangeTimeStamp; // 0x28
	private float m_LastGpuLevelRaiseTimeStamp; // 0x2C
	private float m_LastCpuLevelRaiseTimeStamp; // 0x30
	private float m_TargetFrameRateHitTimestamp; // 0x34
	private float m_BottleneckUnknownTimestamp; // 0x38
	private bool m_TriedToResolveUnknownBottleneck; // 0x3C
	private bool m_Enabled; // 0x3D
	private string m_FeatureName; // 0x40
	[CompilerGenerated]
	private float <TargetFrameTime>k__BackingField; // 0x48
	[CompilerGenerated]
	private float <AllowedCpuActiveTimeRatio>k__BackingField; // 0x4C
	[CompilerGenerated]
	private float <AllowedGpuActiveTimeRatio>k__BackingField; // 0x50
	[CompilerGenerated]
	private float <GpuLevelBounceAvoidanceThreshold>k__BackingField; // 0x54
	[CompilerGenerated]
	private float <CpuLevelBounceAvoidanceThreshold>k__BackingField; // 0x58
	[CompilerGenerated]
	private float <UpdateInterval>k__BackingField; // 0x5C
	[CompilerGenerated]
	private float <MinTargetFrameRateHitTime>k__BackingField; // 0x60
	[CompilerGenerated]
	private float <MaxTemperatureLevel>k__BackingField; // 0x64

	// Properties
	public float TargetFrameTime { get; set; }
	public float AllowedCpuActiveTimeRatio { get; set; }
	public float AllowedGpuActiveTimeRatio { get; set; }
	public float GpuLevelBounceAvoidanceThreshold { get; set; }
	public float CpuLevelBounceAvoidanceThreshold { get; set; }
	public float UpdateInterval { get; set; }
	public float MinTargetFrameRateHitTime { get; set; }
	public float MaxTemperatureLevel { get; set; }
	public bool Enabled { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x84F4528 Offset: 0x84F0528 VA: 0x84F4528
	public float get_TargetFrameTime() { }

	[CompilerGenerated]
	// RVA: 0x84F4530 Offset: 0x84F0530 VA: 0x84F4530
	public void set_TargetFrameTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x84F4538 Offset: 0x84F0538 VA: 0x84F4538
	public float get_AllowedCpuActiveTimeRatio() { }

	[CompilerGenerated]
	// RVA: 0x84F4540 Offset: 0x84F0540 VA: 0x84F4540
	public void set_AllowedCpuActiveTimeRatio(float value) { }

	[CompilerGenerated]
	// RVA: 0x84F4548 Offset: 0x84F0548 VA: 0x84F4548
	public float get_AllowedGpuActiveTimeRatio() { }

	[CompilerGenerated]
	// RVA: 0x84F4550 Offset: 0x84F0550 VA: 0x84F4550
	public void set_AllowedGpuActiveTimeRatio(float value) { }

	[CompilerGenerated]
	// RVA: 0x84F4558 Offset: 0x84F0558 VA: 0x84F4558
	public float get_GpuLevelBounceAvoidanceThreshold() { }

	[CompilerGenerated]
	// RVA: 0x84F4560 Offset: 0x84F0560 VA: 0x84F4560
	public void set_GpuLevelBounceAvoidanceThreshold(float value) { }

	[CompilerGenerated]
	// RVA: 0x84F4568 Offset: 0x84F0568 VA: 0x84F4568
	public float get_CpuLevelBounceAvoidanceThreshold() { }

	[CompilerGenerated]
	// RVA: 0x84F4570 Offset: 0x84F0570 VA: 0x84F4570
	public void set_CpuLevelBounceAvoidanceThreshold(float value) { }

	[CompilerGenerated]
	// RVA: 0x84F4578 Offset: 0x84F0578 VA: 0x84F4578
	public float get_UpdateInterval() { }

	[CompilerGenerated]
	// RVA: 0x84F4580 Offset: 0x84F0580 VA: 0x84F4580
	public void set_UpdateInterval(float value) { }

	[CompilerGenerated]
	// RVA: 0x84F4588 Offset: 0x84F0588 VA: 0x84F4588
	public float get_MinTargetFrameRateHitTime() { }

	[CompilerGenerated]
	// RVA: 0x84F4590 Offset: 0x84F0590 VA: 0x84F4590
	public void set_MinTargetFrameRateHitTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x84F4598 Offset: 0x84F0598 VA: 0x84F4598
	public float get_MaxTemperatureLevel() { }

	[CompilerGenerated]
	// RVA: 0x84F45A0 Offset: 0x84F05A0 VA: 0x84F45A0
	public void set_MaxTemperatureLevel(float value) { }

	// RVA: 0x84F31D8 Offset: 0x84EF1D8 VA: 0x84F31D8
	public void .ctor(IDevicePerformanceControl perfControl, IPerformanceStatus perfStat, IThermalStatus thermalStat) { }

	// RVA: 0x84F45A8 Offset: 0x84F05A8 VA: 0x84F45A8
	public bool get_Enabled() { }

	// RVA: 0x84F26CC Offset: 0x84EE6CC VA: 0x84F26CC
	public void set_Enabled(bool value) { }

	// RVA: 0x84F28F8 Offset: 0x84EE8F8 VA: 0x84F28F8
	public void Update() { }

	// RVA: 0x84F26E4 Offset: 0x84EE6E4 VA: 0x84F26E4
	public void Override(int requestedCpuLevel, int requestedGpuLevel) { }

	// RVA: 0x84F45B0 Offset: 0x84F05B0 VA: 0x84F45B0
	private void UpdateImpl(float timestamp) { }

	// RVA: 0x84F517C Offset: 0x84F117C VA: 0x84F517C
	private void OnBottleneckChange(PerformanceBottleneckChangeEventArgs ev) { }

	// RVA: 0x84F48BC Offset: 0x84F08BC VA: 0x84F48BC
	private void RaiseGpuLevel(float timestamp) { }

	// RVA: 0x84F4B10 Offset: 0x84F0B10 VA: 0x84F4B10
	private void RaiseCpuLevel(float timestamp) { }

	// RVA: 0x84F4DB8 Offset: 0x84F0DB8 VA: 0x84F4DB8
	private void LowerCpuLevel(float timestamp) { }

	// RVA: 0x84F5060 Offset: 0x84F1060 VA: 0x84F5060
	private void LowerGpuLevel(float timestamp) { }

	// RVA: 0x84F4C30 Offset: 0x84F0C30 VA: 0x84F4C30
	private bool AllowLowerCpuLevel(float timestamp) { }

	// RVA: 0x84F4ED4 Offset: 0x84F0ED4 VA: 0x84F4ED4
	private bool AllowLowerGpuLevel(float timestamp) { }

	// RVA: 0x84F51B8 Offset: 0x84F11B8 VA: 0x84F51B8
	private bool AllowRaiseLevels() { }

	// RVA: 0x84F49D8 Offset: 0x84F09D8 VA: 0x84F49D8
	private bool AllowRaiseCpuLevel() { }

	// RVA: 0x84F4784 Offset: 0x84F0784 VA: 0x84F4784
	private bool AllowRaiseGpuLevel() { }

	[CompilerGenerated]
	// RVA: 0x84F5280 Offset: 0x84F1280 VA: 0x84F5280
	private void <.ctor>b__43_0(PerformanceBottleneckChangeEventArgs ev) { }
}

// Namespace: UnityEngine.AdaptivePerformance
internal class AutoPerformanceModeController // TypeDefIndex: 26790
{
	// Fields
	private string m_FeatureName; // 0x10

	// Methods

	// RVA: 0x84F3358 Offset: 0x84EF358 VA: 0x84F3358
	public void .ctor(IPerformanceModeStatus perfModeStat) { }

	// RVA: 0x84F5288 Offset: 0x84F1288 VA: 0x84F5288
	private void OnPerformanceModeChange(PerformanceMode performanceMode) { }

	[CompilerGenerated]
	// RVA: 0x84F537C Offset: 0x84F137C VA: 0x84F537C
	private void <.ctor>b__1_0(PerformanceMode mode) { }
}

// Namespace: UnityEngine.AdaptivePerformance
internal class RenderThreadCpuTime // TypeDefIndex: 26791
{
	// Fields
	private CommandBuffer m_Commandbuffer; // 0x10

	// Methods

	// RVA: 0x84F5380 Offset: 0x84F1380 VA: 0x84F5380
	private static extern void AndroidCpuUsage_Reset() { }

	// RVA: 0x84F53E4 Offset: 0x84F13E4 VA: 0x84F53E4
	private static extern double AndroidCpuUsage_GetLatestCpuTimeDelta() { }

	// RVA: 0x84F5448 Offset: 0x84F1448 VA: 0x84F5448
	private static extern IntPtr AndroidCpuUsage_GetPluginCallback() { }

	// RVA: 0x84F54B0 Offset: 0x84F14B0 VA: 0x84F54B0
	public void .ctor() { }

	// RVA: 0x84F5554 Offset: 0x84F1554 VA: 0x84F5554
	public void Reset() { }

	// RVA: 0x84F5558 Offset: 0x84F1558 VA: 0x84F5558
	public void Measure() { }

	// RVA: 0x84F55B4 Offset: 0x84F15B4 VA: 0x84F55B4
	public float GetLatestResult() { }
}

// Namespace: UnityEngine.AdaptivePerformance
internal class MainThreadCpuTime // TypeDefIndex: 26792
{
	// Fields
	private double m_LastAbsoluteMainThreadCpuTime; // 0x10
	private float m_LatestMainthreadCpuTime; // 0x18

	// Methods

	// RVA: 0x84F55C8 Offset: 0x84F15C8 VA: 0x84F55C8
	private static extern double AndroidCpuUsage_CpuTimeForCurrentThread() { }

	// RVA: 0x84F562C Offset: 0x84F162C VA: 0x84F562C
	public float GetLatestResult() { }

	// RVA: 0x84F5634 Offset: 0x84F1634 VA: 0x84F5634
	public void Measure() { }

	// RVA: 0x84F5664 Offset: 0x84F1664 VA: 0x84F5664
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance
internal class CpuTimeProvider // TypeDefIndex: 26793
{
	// Fields
	private RenderThreadCpuTime m_RenderThreadCpuTime; // 0x10
	private MainThreadCpuTime m_MainThreadCpuTime; // 0x18

	// Properties
	public float CpuFrameTime { get; }

	// Methods

	// RVA: 0x84F24B8 Offset: 0x84EE4B8 VA: 0x84F24B8
	public float get_CpuFrameTime() { }

	// RVA: 0x84F3480 Offset: 0x84EF480 VA: 0x84F3480
	public void .ctor() { }

	// RVA: 0x84F5674 Offset: 0x84F1674 VA: 0x84F5674 Slot: 4
	protected virtual bool IsGraphicsMultiThreaded() { }

	// RVA: 0x84F41B0 Offset: 0x84F01B0 VA: 0x84F41B0
	public void Reset() { }

	// RVA: 0x84F1A78 Offset: 0x84EDA78 VA: 0x84F1A78
	public void LateUpdate() { }

	// RVA: 0x84F43D8 Offset: 0x84F03D8 VA: 0x84F43D8
	public void EndOfFrame() { }
}

// Namespace: UnityEngine.AdaptivePerformance
internal class DevicePerformanceControlImpl : IDevicePerformanceControl // TypeDefIndex: 26794
{
	// Fields
	private IDevicePerformanceLevelControl m_PerformanceLevelControl; // 0x10
	[CompilerGenerated]
	private PerformanceControlMode <PerformanceControlMode>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <CpuLevel>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <GpuLevel>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <CurrentCpuLevel>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <CurrentGpuLevel>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <CpuPerformanceBoost>k__BackingField; // 0x2C
	[CompilerGenerated]
	private bool <GpuPerformanceBoost>k__BackingField; // 0x2D

	// Properties
	public bool AutomaticPerformanceControl { get; set; }
	public PerformanceControlMode PerformanceControlMode { get; set; }
	public int MaxCpuPerformanceLevel { get; }
	public int MaxGpuPerformanceLevel { get; }
	public int CpuLevel { get; set; }
	public int GpuLevel { get; set; }
	public int CurrentCpuLevel { get; set; }
	public int CurrentGpuLevel { get; set; }
	public bool CpuPerformanceBoost { get; set; }
	public bool GpuPerformanceBoost { get; set; }

	// Methods

	// RVA: 0x84F3194 Offset: 0x84EF194 VA: 0x84F3194
	public void .ctor(IDevicePerformanceLevelControl performanceLevelControl) { }

	// RVA: 0x84F2924 Offset: 0x84EE924 VA: 0x84F2924
	public bool Update(out PerformanceLevelChangeEventArgs changeArgs) { }

	// RVA: 0x84F567C Offset: 0x84F167C VA: 0x84F567C
	private int ComputeDelta(int oldLevel, int newLevel) { }

	// RVA: 0x84F5690 Offset: 0x84F1690 VA: 0x84F5690 Slot: 4
	public bool get_AutomaticPerformanceControl() { }

	// RVA: 0x84F5698 Offset: 0x84F1698 VA: 0x84F5698 Slot: 5
	public void set_AutomaticPerformanceControl(bool value) { }

	[CompilerGenerated]
	// RVA: 0x84F569C Offset: 0x84F169C VA: 0x84F569C Slot: 6
	public PerformanceControlMode get_PerformanceControlMode() { }

	[CompilerGenerated]
	// RVA: 0x84F56A4 Offset: 0x84F16A4 VA: 0x84F56A4
	public void set_PerformanceControlMode(PerformanceControlMode value) { }

	// RVA: 0x84F0B3C Offset: 0x84ECB3C VA: 0x84F0B3C Slot: 7
	public int get_MaxCpuPerformanceLevel() { }

	// RVA: 0x84F0BFC Offset: 0x84ECBFC VA: 0x84F0BFC Slot: 8
	public int get_MaxGpuPerformanceLevel() { }

	[CompilerGenerated]
	// RVA: 0x84F56AC Offset: 0x84F16AC VA: 0x84F56AC Slot: 9
	public int get_CpuLevel() { }

	[CompilerGenerated]
	// RVA: 0x84F56B4 Offset: 0x84F16B4 VA: 0x84F56B4 Slot: 10
	public void set_CpuLevel(int value) { }

	[CompilerGenerated]
	// RVA: 0x84F56BC Offset: 0x84F16BC VA: 0x84F56BC Slot: 11
	public int get_GpuLevel() { }

	[CompilerGenerated]
	// RVA: 0x84F56C4 Offset: 0x84F16C4 VA: 0x84F56C4 Slot: 12
	public void set_GpuLevel(int value) { }

	[CompilerGenerated]
	// RVA: 0x84F56CC Offset: 0x84F16CC VA: 0x84F56CC
	public int get_CurrentCpuLevel() { }

	[CompilerGenerated]
	// RVA: 0x84F56D4 Offset: 0x84F16D4 VA: 0x84F56D4
	public void set_CurrentCpuLevel(int value) { }

	[CompilerGenerated]
	// RVA: 0x84F56DC Offset: 0x84F16DC VA: 0x84F56DC
	public int get_CurrentGpuLevel() { }

	[CompilerGenerated]
	// RVA: 0x84F56E4 Offset: 0x84F16E4 VA: 0x84F56E4
	public void set_CurrentGpuLevel(int value) { }

	[CompilerGenerated]
	// RVA: 0x84F56EC Offset: 0x84F16EC VA: 0x84F56EC Slot: 13
	public bool get_CpuPerformanceBoost() { }

	[CompilerGenerated]
	// RVA: 0x84F56F4 Offset: 0x84F16F4 VA: 0x84F56F4 Slot: 14
	public void set_CpuPerformanceBoost(bool value) { }

	[CompilerGenerated]
	// RVA: 0x84F5700 Offset: 0x84F1700 VA: 0x84F5700 Slot: 15
	public bool get_GpuPerformanceBoost() { }

	[CompilerGenerated]
	// RVA: 0x84F5708 Offset: 0x84F1708 VA: 0x84F5708 Slot: 16
	public void set_GpuPerformanceBoost(bool value) { }
}

// Namespace: UnityEngine.AdaptivePerformance
internal class GpuTimeProvider // TypeDefIndex: 26795
{
	// Fields
	private FrameTiming[] m_FrameTiming; // 0x10

	// Properties
	public float GpuFrameTime { get; }

	// Methods

	// RVA: 0x84F3548 Offset: 0x84EF548 VA: 0x84F3548
	public void .ctor() { }

	// RVA: 0x84F2460 Offset: 0x84EE460 VA: 0x84F2460
	public float get_GpuFrameTime() { }

	// RVA: 0x84F5714 Offset: 0x84F1714 VA: 0x84F5714 Slot: 4
	protected virtual uint GetLatestTimings() { }

	// RVA: 0x84F1A88 Offset: 0x84EDA88 VA: 0x84F1A88
	public void Measure() { }
}

// Namespace: UnityEngine.AdaptivePerformance
internal class RunningAverage // TypeDefIndex: 26796
{
	// Fields
	private float[] m_Values; // 0x10
	private int m_NumValues; // 0x18
	private int m_LastIndex; // 0x1C
	private float m_AverageValue; // 0x20

	// Methods

	// RVA: 0x84F42E4 Offset: 0x84F02E4 VA: 0x84F42E4
	public void .ctor(int sampleWindowSize = 100) { }

	// RVA: 0x84F5724 Offset: 0x84F1724 VA: 0x84F5724
	public int GetNumValues() { }

	// RVA: 0x84F26B0 Offset: 0x84EE6B0 VA: 0x84F26B0
	public int GetSampleWindowSize() { }

	// RVA: 0x84F2604 Offset: 0x84EE604 VA: 0x84F2604
	public float GetAverageOr(float defaultValue) { }

	// RVA: 0x84F2618 Offset: 0x84EE618 VA: 0x84F2618
	public float GetMostRecentValueOr(float defaultValue) { }

	// RVA: 0x84F18C0 Offset: 0x84ED8C0 VA: 0x84F18C0
	public void AddValue(float NewValue) { }

	// RVA: 0x84F417C Offset: 0x84F017C VA: 0x84F417C
	public void Reset() { }
}

// Namespace: UnityEngine.AdaptivePerformance
internal class TemperatureTrend // TypeDefIndex: 26797
{
	// Fields
	private bool m_UseProviderTrend; // 0x10
	private double m_SumX; // 0x18
	private double m_SumY; // 0x20
	private double m_SumXY; // 0x28
	private double m_SumXX; // 0x30
	private const int MeasurementTimeframeSeconds = 20;
	private const int UpdateFrequency = 10;
	private const int SamplesCapacity = 200;
	private const double SlopeAtMaxTrend = 0.005;
	private float[] m_TimeStamps; // 0x38
	private float[] m_Temperature; // 0x40
	private int m_NumValues; // 0x48
	private int m_NextValueIndex; // 0x4C
	private int m_OldestValueIndex; // 0x50
	[CompilerGenerated]
	private float <ThermalTrend>k__BackingField; // 0x54

	// Properties
	public float ThermalTrend { get; set; }
	public int NumValues { get; set; }

	// Methods

	// RVA: 0x84F572C Offset: 0x84F172C VA: 0x84F572C
	private void PopOldestValue() { }

	// RVA: 0x84F57E0 Offset: 0x84F17E0 VA: 0x84F57E0
	private void PushNewValue(float tempLevel, float timestamp) { }

	// RVA: 0x84F35AC Offset: 0x84EF5AC VA: 0x84F35AC
	public void .ctor(bool useProviderTrend) { }

	// RVA: 0x84F25F0 Offset: 0x84EE5F0 VA: 0x84F25F0
	public void Reset() { }

	[CompilerGenerated]
	// RVA: 0x84F5898 Offset: 0x84F1898 VA: 0x84F5898
	public float get_ThermalTrend() { }

	[CompilerGenerated]
	// RVA: 0x84F58A0 Offset: 0x84F18A0 VA: 0x84F58A0
	private void set_ThermalTrend(float value) { }

	// RVA: 0x84F58A8 Offset: 0x84F18A8 VA: 0x84F58A8
	private void UpdateTrend() { }

	// RVA: 0x84F24F8 Offset: 0x84EE4F8 VA: 0x84F24F8
	public void Update(float temperatureTrendFromProvider, float newTemperatureLevel, bool changed, float newTemperatureTimestamp) { }

	// RVA: 0x84F5994 Offset: 0x84F1994 VA: 0x84F5994
	public int get_NumValues() { }

	// RVA: 0x84F599C Offset: 0x84F199C VA: 0x84F599C
	public void set_NumValues(int value) { }
}

// Namespace: UnityEngine.AdaptivePerformance
public static class Constants // TypeDefIndex: 26798
{
	// Fields
	public const float MinTemperatureLevel = 0;
	public const float MaxTemperatureLevel = 1;
	public const int MinCpuPerformanceLevel = 0;
	public const int MinGpuPerformanceLevel = 0;
	public const int UnknownPerformanceLevel = -1;
	public const int DefaultAverageFrameCount = 100;
}

// Namespace: UnityEngine.AdaptivePerformance
public interface IAdaptivePerformance // TypeDefIndex: 26799
{
	// Properties
	public abstract bool Initialized { get; }
	public abstract bool Active { get; }
	public abstract IThermalStatus ThermalStatus { get; }
	public abstract IPerformanceStatus PerformanceStatus { get; }
	public abstract IDevicePerformanceControl DevicePerformanceControl { get; }
	public abstract IPerformanceModeStatus PerformanceModeStatus { get; }
	public abstract IDevelopmentSettings DevelopmentSettings { get; }
	public abstract AdaptivePerformanceIndexer Indexer { get; }
	public abstract IAdaptivePerformanceSettings Settings { get; }
	public abstract AdaptivePerformanceSubsystem Subsystem { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_Initialized();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_Active();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IThermalStatus get_ThermalStatus();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IPerformanceStatus get_PerformanceStatus();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IDevicePerformanceControl get_DevicePerformanceControl();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IPerformanceModeStatus get_PerformanceModeStatus();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IDevelopmentSettings get_DevelopmentSettings();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract AdaptivePerformanceIndexer get_Indexer();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IAdaptivePerformanceSettings get_Settings();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract AdaptivePerformanceSubsystem get_Subsystem();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool SupportedFeature(Feature feature);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void InitializeAdaptivePerformance();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void StartAdaptivePerformance();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void StopAdaptivePerformance();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void DeinitializeAdaptivePerformance();
}

// Namespace: UnityEngine.AdaptivePerformance
public static class Holder // TypeDefIndex: 26800
{
	// Fields
	private static IAdaptivePerformance m_Instance; // 0x0
	[CompilerGenerated]
	private static LifecycleEventHandler LifecycleEventHandler; // 0x8

	// Properties
	public static IAdaptivePerformance Instance { get; set; }

	// Methods

	// RVA: 0x84F59A4 Offset: 0x84F19A4 VA: 0x84F59A4
	public static IAdaptivePerformance get_Instance() { }

	// RVA: 0x84EFB5C Offset: 0x84EBB5C VA: 0x84EFB5C
	internal static void set_Instance(IAdaptivePerformance value) { }

	// RVA: 0x84F59EC Offset: 0x84F19EC VA: 0x84F59EC
	public static void Initialize() { }

	// RVA: 0x84F5AF8 Offset: 0x84F1AF8 VA: 0x84F5AF8
	public static void Deinitialize() { }

	[CompilerGenerated]
	// RVA: 0x84F5BC8 Offset: 0x84F1BC8 VA: 0x84F5BC8
	public static void add_LifecycleEventHandler(LifecycleEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x84F5C84 Offset: 0x84F1C84 VA: 0x84F5C84
	public static void remove_LifecycleEventHandler(LifecycleEventHandler value) { }
}

// Namespace: UnityEngine.AdaptivePerformance
public sealed class LifecycleEventHandler : MulticastDelegate // TypeDefIndex: 26801
{
	// Methods

	// RVA: 0x84F5D40 Offset: 0x84F1D40 VA: 0x84F5D40
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x84F5E4C Offset: 0x84F1E4C VA: 0x84F5E4C Slot: 13
	public virtual void Invoke(IAdaptivePerformance instance, LifecycleChangeType changeType) { }

	// RVA: 0x84F5E60 Offset: 0x84F1E60 VA: 0x84F5E60 Slot: 14
	public virtual IAsyncResult BeginInvoke(IAdaptivePerformance instance, LifecycleChangeType changeType, AsyncCallback callback, object object) { }

	// RVA: 0x84F5EF4 Offset: 0x84F1EF4 VA: 0x84F5EF4 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: UnityEngine.AdaptivePerformance
public enum LifecycleChangeType // TypeDefIndex: 26802
{
	// Fields
	public int value__; // 0x0
	public const LifecycleChangeType Created = 0;
	public const LifecycleChangeType Destroyed = 1;
}

// Namespace: UnityEngine.AdaptivePerformance
public interface IDevelopmentSettings // TypeDefIndex: 26803
{
	// Properties
	public abstract bool Logging { get; set; }
	public abstract int LoggingFrequencyInFrames { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_Logging();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Logging(bool value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_LoggingFrequencyInFrames();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_LoggingFrequencyInFrames(int value);
}

// Namespace: UnityEngine.AdaptivePerformance
public interface IDevicePerformanceControl // TypeDefIndex: 26804
{
	// Properties
	public abstract bool AutomaticPerformanceControl { get; set; }
	public abstract PerformanceControlMode PerformanceControlMode { get; }
	public abstract int MaxCpuPerformanceLevel { get; }
	public abstract int MaxGpuPerformanceLevel { get; }
	public abstract int CpuLevel { get; set; }
	public abstract int GpuLevel { get; set; }
	public abstract bool CpuPerformanceBoost { get; set; }
	public abstract bool GpuPerformanceBoost { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_AutomaticPerformanceControl();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_AutomaticPerformanceControl(bool value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract PerformanceControlMode get_PerformanceControlMode();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int get_MaxCpuPerformanceLevel();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_MaxGpuPerformanceLevel();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_CpuLevel();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void set_CpuLevel(int value);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_GpuLevel();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void set_GpuLevel(int value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_CpuPerformanceBoost();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void set_CpuPerformanceBoost(bool value);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool get_GpuPerformanceBoost();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void set_GpuPerformanceBoost(bool value);
}

// Namespace: UnityEngine.AdaptivePerformance
public enum PerformanceControlMode // TypeDefIndex: 26805
{
	// Fields
	public int value__; // 0x0
	public const PerformanceControlMode Automatic = 0;
	public const PerformanceControlMode Manual = 1;
	public const PerformanceControlMode System = 2;
}

// Namespace: UnityEngine.AdaptivePerformance
public enum StateAction // TypeDefIndex: 26806
{
	// Fields
	public int value__; // 0x0
	public const StateAction Stale = 0;
	public const StateAction Increase = 1;
	public const StateAction Decrease = 2;
	public const StateAction FastDecrease = 3;
}

// Namespace: UnityEngine.AdaptivePerformance
internal class ThermalStateTracker // TypeDefIndex: 26807
{
	// Fields
	private float warningTemp; // 0x10
	private float throttlingTemp; // 0x14

	// Methods

	// RVA: 0x84F5F00 Offset: 0x84F1F00 VA: 0x84F5F00
	public void .ctor() { }

	// RVA: 0x84F5F10 Offset: 0x84F1F10 VA: 0x84F5F10
	public StateAction Update() { }
}

// Namespace: UnityEngine.AdaptivePerformance
internal class PerformanceStateTracker // TypeDefIndex: 26808
{
	// Fields
	private Queue<float> m_Samples; // 0x10
	private int m_SampleCapacity; // 0x18
	[CompilerGenerated]
	private float <Trend>k__BackingField; // 0x1C

	// Properties
	public float Trend { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x84F6344 Offset: 0x84F2344 VA: 0x84F6344
	public float get_Trend() { }

	[CompilerGenerated]
	// RVA: 0x84F634C Offset: 0x84F234C VA: 0x84F634C
	public void set_Trend(float value) { }

	// RVA: 0x84F3964 Offset: 0x84EF964 VA: 0x84F3964
	public void .ctor(int sampleCapacity) { }

	// RVA: 0x84F6354 Offset: 0x84F2354 VA: 0x84F6354
	public StateAction Update() { }

	// RVA: 0x84F66C0 Offset: 0x84F26C0 VA: 0x84F66C0 Slot: 4
	protected virtual float GetEffectiveTargetFrameRate() { }
}

// Namespace: UnityEngine.AdaptivePerformance
internal class AdaptivePerformanceScalerEfficiencyTracker // TypeDefIndex: 26809
{
	// Fields
	private AdaptivePerformanceScaler m_Scaler; // 0x10
	private float m_LastAverageGpuFrameTime; // 0x18
	private float m_LastAverageCpuFrameTime; // 0x1C
	private bool m_IsApplied; // 0x20

	// Properties
	public bool IsRunning { get; }

	// Methods

	// RVA: 0x84F66C4 Offset: 0x84F26C4 VA: 0x84F66C4
	public bool get_IsRunning() { }

	// RVA: 0x84F6724 Offset: 0x84F2724 VA: 0x84F6724
	public void Start(AdaptivePerformanceScaler scaler, bool isApply) { }

	// RVA: 0x84F69AC Offset: 0x84F29AC VA: 0x84F69AC
	public void Stop() { }

	// RVA: 0x84F6C90 Offset: 0x84F2C90 VA: 0x84F6C90
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance
public class AdaptivePerformanceIndexer // TypeDefIndex: 26810
{
	// Fields
	private List<AdaptivePerformanceScaler> m_UnappliedScalers; // 0x10
	private List<AdaptivePerformanceScaler> m_AppliedScalers; // 0x18
	private List<AdaptivePerformanceScaler> m_DisabledScalers; // 0x20
	private ThermalStateTracker m_ThermalStateTracker; // 0x28
	private PerformanceStateTracker m_PerformanceStateTracker; // 0x30
	private AdaptivePerformanceScalerEfficiencyTracker m_ScalerEfficiencyTracker; // 0x38
	private IAdaptivePerformanceSettings m_Settings; // 0x40
	private const string m_FeatureName = "Indexer";
	[CompilerGenerated]
	private float <TimeUntilNextAction>k__BackingField; // 0x48
	[CompilerGenerated]
	private StateAction <ThermalAction>k__BackingField; // 0x4C
	[CompilerGenerated]
	private StateAction <PerformanceAction>k__BackingField; // 0x50

	// Properties
	public float TimeUntilNextAction { get; set; }
	public StateAction ThermalAction { get; set; }
	public StateAction PerformanceAction { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x84F6C98 Offset: 0x84F2C98 VA: 0x84F6C98
	public float get_TimeUntilNextAction() { }

	[CompilerGenerated]
	// RVA: 0x84F6CA0 Offset: 0x84F2CA0 VA: 0x84F6CA0
	private void set_TimeUntilNextAction(float value) { }

	[CompilerGenerated]
	// RVA: 0x84F6CA8 Offset: 0x84F2CA8 VA: 0x84F6CA8
	public StateAction get_ThermalAction() { }

	[CompilerGenerated]
	// RVA: 0x84F6CB0 Offset: 0x84F2CB0 VA: 0x84F6CB0
	private void set_ThermalAction(StateAction value) { }

	[CompilerGenerated]
	// RVA: 0x84F6CB8 Offset: 0x84F2CB8 VA: 0x84F6CB8
	public StateAction get_PerformanceAction() { }

	[CompilerGenerated]
	// RVA: 0x84F6CC0 Offset: 0x84F2CC0 VA: 0x84F6CC0
	private void set_PerformanceAction(StateAction value) { }

	// RVA: 0x84F6CC8 Offset: 0x84F2CC8 VA: 0x84F6CC8
	public void GetAppliedScalers(ref List<AdaptivePerformanceScaler> scalers) { }

	// RVA: 0x84F6D58 Offset: 0x84F2D58 VA: 0x84F6D58
	public void GetUnappliedScalers(ref List<AdaptivePerformanceScaler> scalers) { }

	// RVA: 0x84F6DE8 Offset: 0x84F2DE8 VA: 0x84F6DE8
	public void GetDisabledScalers(ref List<AdaptivePerformanceScaler> scalers) { }

	// RVA: 0x84F6E78 Offset: 0x84F2E78 VA: 0x84F6E78
	public void GetAllRegisteredScalers(ref List<AdaptivePerformanceScaler> scalers) { }

	// RVA: 0x84F3F78 Offset: 0x84EFF78 VA: 0x84F3F78
	public void UnapplyAllScalers() { }

	// RVA: 0x84F7024 Offset: 0x84F3024 VA: 0x84F7024
	internal void UpdateOverrideLevel(AdaptivePerformanceScaler scaler) { }

	// RVA: 0x84F7174 Offset: 0x84F3174 VA: 0x84F7174
	internal void AddScaler(AdaptivePerformanceScaler scaler) { }

	// RVA: 0x84F7270 Offset: 0x84F3270 VA: 0x84F7270
	internal void RemoveScaler(AdaptivePerformanceScaler scaler) { }

	// RVA: 0x84F39FC Offset: 0x84EF9FC VA: 0x84F39FC
	internal void .ctor(ref IAdaptivePerformanceSettings settings, PerformanceStateTracker tracker) { }

	// RVA: 0x84F2268 Offset: 0x84EE268 VA: 0x84F2268
	internal void Update() { }

	// RVA: 0x84F7DB8 Offset: 0x84F3DB8 VA: 0x84F7DB8 Slot: 4
	protected virtual float DeltaTime() { }

	// RVA: 0x84F7778 Offset: 0x84F3778 VA: 0x84F7778
	private void CollectProfilerStats() { }

	// RVA: 0x84F73F8 Offset: 0x84F33F8 VA: 0x84F73F8
	private void DeactivateDisabledScalers() { }

	// RVA: 0x84F7690 Offset: 0x84F3690 VA: 0x84F7690
	private void ActivateEnabledScalers() { }

	// RVA: 0x84F7A94 Offset: 0x84F3A94 VA: 0x84F7A94
	private bool ApplyLowestCostScaler() { }

	// RVA: 0x84F7090 Offset: 0x84F3090 VA: 0x84F7090
	private void ApplyScaler(AdaptivePerformanceScaler scaler) { }

	// RVA: 0x84F789C Offset: 0x84F389C VA: 0x84F789C
	private bool UnapplyHighestCostScaler() { }

	// RVA: 0x84F6F30 Offset: 0x84F2F30 VA: 0x84F6F30
	private void UnapplyScaler(AdaptivePerformanceScaler scaler) { }
}

// Namespace: UnityEngine.AdaptivePerformance
public static class AdaptivePerformanceRenderSettings // TypeDefIndex: 26811
{
	// Fields
	private static float s_MaxShadowDistanceMultiplier; // 0x0
	private static float s_ShadowResolutionMultiplier; // 0x4
	private static float s_RenderScaleMultiplier; // 0x8
	private static float s_DecalsMaxDistance; // 0xC
	[CompilerGenerated]
	private static int <MainLightShadowCascadesCountBias>k__BackingField; // 0x10
	[CompilerGenerated]
	private static int <ShadowQualityBias>k__BackingField; // 0x14
	[CompilerGenerated]
	private static float <LutBias>k__BackingField; // 0x18
	[CompilerGenerated]
	private static int <AntiAliasingQualityBias>k__BackingField; // 0x1C
	[CompilerGenerated]
	private static bool <SkipDynamicBatching>k__BackingField; // 0x20
	[CompilerGenerated]
	private static bool <SkipFrontToBackSorting>k__BackingField; // 0x21
	[CompilerGenerated]
	private static bool <SkipTransparentObjects>k__BackingField; // 0x22

	// Properties
	public static float MainLightShadowmapResolutionMultiplier { get; set; }
	public static float DecalsDrawDistance { get; set; }
	public static int MainLightShadowCascadesCountBias { get; set; }
	public static int ShadowQualityBias { get; set; }
	public static float LutBias { get; set; }
	public static float MaxShadowDistanceMultiplier { get; set; }
	public static float RenderScaleMultiplier { get; set; }
	public static int AntiAliasingQualityBias { get; set; }
	public static bool SkipDynamicBatching { get; set; }
	public static bool SkipFrontToBackSorting { get; set; }
	public static bool SkipTransparentObjects { get; set; }

	// Methods

	// RVA: 0x84F80DC Offset: 0x84F40DC VA: 0x84F80DC
	public static float get_MainLightShadowmapResolutionMultiplier() { }

	// RVA: 0x84F8134 Offset: 0x84F4134 VA: 0x84F8134
	public static void set_MainLightShadowmapResolutionMultiplier(float value) { }

	// RVA: 0x84F81AC Offset: 0x84F41AC VA: 0x84F81AC
	public static float get_DecalsDrawDistance() { }

	// RVA: 0x84F8204 Offset: 0x84F4204 VA: 0x84F8204
	public static void set_DecalsDrawDistance(float value) { }

	[CompilerGenerated]
	// RVA: 0x84F8268 Offset: 0x84F4268 VA: 0x84F8268
	public static int get_MainLightShadowCascadesCountBias() { }

	[CompilerGenerated]
	// RVA: 0x84F82C0 Offset: 0x84F42C0 VA: 0x84F82C0
	public static void set_MainLightShadowCascadesCountBias(int value) { }

	[CompilerGenerated]
	// RVA: 0x84F831C Offset: 0x84F431C VA: 0x84F831C
	public static int get_ShadowQualityBias() { }

	[CompilerGenerated]
	// RVA: 0x84F8374 Offset: 0x84F4374 VA: 0x84F8374
	public static void set_ShadowQualityBias(int value) { }

	[CompilerGenerated]
	// RVA: 0x84F83D0 Offset: 0x84F43D0 VA: 0x84F83D0
	public static float get_LutBias() { }

	[CompilerGenerated]
	// RVA: 0x84F8428 Offset: 0x84F4428 VA: 0x84F8428
	public static void set_LutBias(float value) { }

	// RVA: 0x84F848C Offset: 0x84F448C VA: 0x84F848C
	public static float get_MaxShadowDistanceMultiplier() { }

	// RVA: 0x84F84E4 Offset: 0x84F44E4 VA: 0x84F84E4
	public static void set_MaxShadowDistanceMultiplier(float value) { }

	// RVA: 0x84F855C Offset: 0x84F455C VA: 0x84F855C
	public static float get_RenderScaleMultiplier() { }

	// RVA: 0x84F85B4 Offset: 0x84F45B4 VA: 0x84F85B4
	public static void set_RenderScaleMultiplier(float value) { }

	[CompilerGenerated]
	// RVA: 0x84F862C Offset: 0x84F462C VA: 0x84F862C
	public static int get_AntiAliasingQualityBias() { }

	[CompilerGenerated]
	// RVA: 0x84F8684 Offset: 0x84F4684 VA: 0x84F8684
	public static void set_AntiAliasingQualityBias(int value) { }

	[CompilerGenerated]
	// RVA: 0x84F86E0 Offset: 0x84F46E0 VA: 0x84F86E0
	public static bool get_SkipDynamicBatching() { }

	[CompilerGenerated]
	// RVA: 0x84F8738 Offset: 0x84F4738 VA: 0x84F8738
	public static void set_SkipDynamicBatching(bool value) { }

	[CompilerGenerated]
	// RVA: 0x84F8798 Offset: 0x84F4798 VA: 0x84F8798
	public static bool get_SkipFrontToBackSorting() { }

	[CompilerGenerated]
	// RVA: 0x84F87F0 Offset: 0x84F47F0 VA: 0x84F87F0
	public static void set_SkipFrontToBackSorting(bool value) { }

	[CompilerGenerated]
	// RVA: 0x84F8850 Offset: 0x84F4850 VA: 0x84F8850
	public static bool get_SkipTransparentObjects() { }

	[CompilerGenerated]
	// RVA: 0x84F88A8 Offset: 0x84F48A8 VA: 0x84F88A8
	public static void set_SkipTransparentObjects(bool value) { }

	// RVA: 0x84F8908 Offset: 0x84F4908 VA: 0x84F8908
	private static void .cctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance
public enum ScalerVisualImpact // TypeDefIndex: 26812
{
	// Fields
	public int value__; // 0x0
	public const ScalerVisualImpact Low = 0;
	public const ScalerVisualImpact Medium = 1;
	public const ScalerVisualImpact High = 2;
}

// Namespace: UnityEngine.AdaptivePerformance
[Flags]
public enum ScalerTarget // TypeDefIndex: 26813
{
	// Fields
	public int value__; // 0x0
	public const ScalerTarget CPU = 1;
	public const ScalerTarget GPU = 2;
	public const ScalerTarget FillRate = 4;
}

// Namespace: UnityEngine.AdaptivePerformance
[RequireDerived]
public abstract class AdaptivePerformanceScaler : ScriptableObject // TypeDefIndex: 26814
{
	// Fields
	private AdaptivePerformanceIndexer m_Indexer; // 0x18
	[CompilerGenerated]
	private int <CurrentLevel>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <GpuImpact>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <CpuImpact>k__BackingField; // 0x28
	private int m_OverrideLevel; // 0x2C
	private AdaptivePerformanceScalerSettingsBase m_defaultSetting; // 0x30
	protected IAdaptivePerformanceSettings m_Settings; // 0x38

	// Properties
	public virtual string Name { get; set; }
	public virtual bool Enabled { get; set; }
	public virtual float Scale { get; set; }
	public virtual ScalerVisualImpact VisualImpact { get; set; }
	public virtual ScalerTarget Target { get; set; }
	public virtual int MaxLevel { get; set; }
	public virtual float MinBound { get; set; }
	public virtual float MaxBound { get; set; }
	public int CurrentLevel { get; set; }
	public bool IsMaxLevel { get; }
	public bool NotLeveled { get; }
	public int GpuImpact { get; set; }
	public int CpuImpact { get; set; }
	public int OverrideLevel { get; set; }

	// Methods

	// RVA: 0x84F8958 Offset: 0x84F4958 VA: 0x84F8958 Slot: 4
	public virtual string get_Name() { }

	// RVA: 0x84F8974 Offset: 0x84F4974 VA: 0x84F8974 Slot: 5
	public virtual void set_Name(string value) { }

	// RVA: 0x84F89C8 Offset: 0x84F49C8 VA: 0x84F89C8 Slot: 6
	public virtual bool get_Enabled() { }

	// RVA: 0x84F89E4 Offset: 0x84F49E4 VA: 0x84F89E4 Slot: 7
	public virtual void set_Enabled(bool value) { }

	// RVA: 0x84F8A18 Offset: 0x84F4A18 VA: 0x84F8A18 Slot: 8
	public virtual float get_Scale() { }

	// RVA: 0x84F8A34 Offset: 0x84F4A34 VA: 0x84F8A34 Slot: 9
	public virtual void set_Scale(float value) { }

	// RVA: 0x84F8A5C Offset: 0x84F4A5C VA: 0x84F8A5C Slot: 10
	public virtual ScalerVisualImpact get_VisualImpact() { }

	// RVA: 0x84F8A78 Offset: 0x84F4A78 VA: 0x84F8A78 Slot: 11
	public virtual void set_VisualImpact(ScalerVisualImpact value) { }

	// RVA: 0x84F8AA0 Offset: 0x84F4AA0 VA: 0x84F8AA0 Slot: 12
	public virtual ScalerTarget get_Target() { }

	// RVA: 0x84F8ABC Offset: 0x84F4ABC VA: 0x84F8ABC Slot: 13
	public virtual void set_Target(ScalerTarget value) { }

	// RVA: 0x84F8AE4 Offset: 0x84F4AE4 VA: 0x84F8AE4 Slot: 14
	public virtual int get_MaxLevel() { }

	// RVA: 0x84F8B00 Offset: 0x84F4B00 VA: 0x84F8B00 Slot: 15
	public virtual void set_MaxLevel(int value) { }

	// RVA: 0x84F8B28 Offset: 0x84F4B28 VA: 0x84F8B28 Slot: 16
	public virtual float get_MinBound() { }

	// RVA: 0x84F8B44 Offset: 0x84F4B44 VA: 0x84F8B44 Slot: 17
	public virtual void set_MinBound(float value) { }

	// RVA: 0x84F8B6C Offset: 0x84F4B6C VA: 0x84F8B6C Slot: 18
	public virtual float get_MaxBound() { }

	// RVA: 0x84F8B88 Offset: 0x84F4B88 VA: 0x84F8B88 Slot: 19
	public virtual void set_MaxBound(float value) { }

	[CompilerGenerated]
	// RVA: 0x84F8BB0 Offset: 0x84F4BB0 VA: 0x84F8BB0
	public int get_CurrentLevel() { }

	[CompilerGenerated]
	// RVA: 0x84F8BB8 Offset: 0x84F4BB8 VA: 0x84F8BB8
	private void set_CurrentLevel(int value) { }

	// RVA: 0x84F7FEC Offset: 0x84F3FEC VA: 0x84F7FEC
	public bool get_IsMaxLevel() { }

	// RVA: 0x84F73E8 Offset: 0x84F33E8 VA: 0x84F73E8
	public bool get_NotLeveled() { }

	[CompilerGenerated]
	// RVA: 0x84F8BC0 Offset: 0x84F4BC0 VA: 0x84F8BC0
	public int get_GpuImpact() { }

	[CompilerGenerated]
	// RVA: 0x84F8BC8 Offset: 0x84F4BC8 VA: 0x84F8BC8
	internal void set_GpuImpact(int value) { }

	[CompilerGenerated]
	// RVA: 0x84F8BD0 Offset: 0x84F4BD0 VA: 0x84F8BD0
	public int get_CpuImpact() { }

	[CompilerGenerated]
	// RVA: 0x84F8BD8 Offset: 0x84F4BD8 VA: 0x84F8BD8
	internal void set_CpuImpact(int value) { }

	// RVA: 0x84F8BE0 Offset: 0x84F4BE0 VA: 0x84F8BE0
	public int get_OverrideLevel() { }

	// RVA: 0x84F8BE8 Offset: 0x84F4BE8 VA: 0x84F8BE8
	public void set_OverrideLevel(int value) { }

	// RVA: 0x84F7DE0 Offset: 0x84F3DE0 VA: 0x84F7DE0
	public int CalculateCost() { }

	// RVA: 0x84F8C0C Offset: 0x84F4C0C VA: 0x84F8C0C Slot: 20
	protected virtual void Awake() { }

	// RVA: 0x84F8DA0 Offset: 0x84F4DA0 VA: 0x84F8DA0
	private void OnEnable() { }

	// RVA: 0x84F8DD8 Offset: 0x84F4DD8 VA: 0x84F8DD8
	private void OnDisable() { }

	// RVA: 0x84F8014 Offset: 0x84F4014 VA: 0x84F8014
	internal void IncreaseLevel() { }

	// RVA: 0x84F733C Offset: 0x84F333C VA: 0x84F733C
	internal void DecreaseLevel() { }

	// RVA: 0x84F7DD0 Offset: 0x84F3DD0 VA: 0x84F7DD0
	internal void Activate() { }

	// RVA: 0x84F7DC0 Offset: 0x84F3DC0 VA: 0x84F7DC0
	internal void Deactivate() { }

	// RVA: 0x84F8E10 Offset: 0x84F4E10 VA: 0x84F8E10
	public void ApplyDefaultSetting(AdaptivePerformanceScalerSettingsBase defaultSetting) { }

	// RVA: 0x84F8E18 Offset: 0x84F4E18 VA: 0x84F8E18
	protected bool ScaleChanged() { }

	// RVA: 0x84F8F08 Offset: 0x84F4F08 VA: 0x84F8F08 Slot: 21
	protected virtual void OnLevelIncrease() { }

	// RVA: 0x84F8F0C Offset: 0x84F4F0C VA: 0x84F8F0C Slot: 22
	protected virtual void OnLevelDecrease() { }

	// RVA: 0x84F8F10 Offset: 0x84F4F10 VA: 0x84F8F10 Slot: 23
	protected virtual void OnLevel() { }

	// RVA: 0x84F8F14 Offset: 0x84F4F14 VA: 0x84F8F14 Slot: 24
	protected virtual void OnEnabled() { }

	// RVA: 0x84F8F18 Offset: 0x84F4F18 VA: 0x84F8F18 Slot: 25
	protected virtual void OnDisabled() { }

	// RVA: 0x84F8F1C Offset: 0x84F4F1C VA: 0x84F8F1C
	protected void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance
public sealed class PerformanceModeEventHandler : MulticastDelegate // TypeDefIndex: 26815
{
	// Methods

	// RVA: 0x84F3824 Offset: 0x84EF824 VA: 0x84F3824
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x84F8FFC Offset: 0x84F4FFC VA: 0x84F8FFC Slot: 13
	public virtual void Invoke(PerformanceMode performanceMode) { }

	// RVA: 0x84F9010 Offset: 0x84F5010 VA: 0x84F9010 Slot: 14
	public virtual IAsyncResult BeginInvoke(PerformanceMode performanceMode, AsyncCallback callback, object object) { }

	// RVA: 0x84F9094 Offset: 0x84F5094 VA: 0x84F9094 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: UnityEngine.AdaptivePerformance
public interface IPerformanceModeStatus // TypeDefIndex: 26816
{
	// Properties
	public abstract PerformanceMode PerformanceMode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract PerformanceMode get_PerformanceMode();

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void add_PerformanceModeEvent(PerformanceModeEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void remove_PerformanceModeEvent(PerformanceModeEventHandler value);
}

// Namespace: UnityEngine.AdaptivePerformance
public struct PerformanceBottleneckChangeEventArgs // TypeDefIndex: 26817
{
	// Fields
	[CompilerGenerated]
	private PerformanceBottleneck <PerformanceBottleneck>k__BackingField; // 0x0

	// Properties
	public PerformanceBottleneck PerformanceBottleneck { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x84F90A0 Offset: 0x84F50A0 VA: 0x84F90A0
	public PerformanceBottleneck get_PerformanceBottleneck() { }

	[CompilerGenerated]
	// RVA: 0x84F90A8 Offset: 0x84F50A8 VA: 0x84F90A8
	public void set_PerformanceBottleneck(PerformanceBottleneck value) { }
}

// Namespace: UnityEngine.AdaptivePerformance
public sealed class PerformanceBottleneckChangeHandler : MulticastDelegate // TypeDefIndex: 26818
{
	// Methods

	// RVA: 0x84F36E4 Offset: 0x84EF6E4 VA: 0x84F36E4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x84F90B0 Offset: 0x84F50B0 VA: 0x84F90B0 Slot: 13
	public virtual void Invoke(PerformanceBottleneckChangeEventArgs bottleneckEventArgs) { }

	// RVA: 0x84F90C8 Offset: 0x84F50C8 VA: 0x84F90C8 Slot: 14
	public virtual IAsyncResult BeginInvoke(PerformanceBottleneckChangeEventArgs bottleneckEventArgs, AsyncCallback callback, object object) { }

	// RVA: 0x84F914C Offset: 0x84F514C VA: 0x84F914C Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: UnityEngine.AdaptivePerformance
public struct PerformanceBoostChangeEventArgs // TypeDefIndex: 26819
{
	// Fields
	[CompilerGenerated]
	private bool <CpuBoost>k__BackingField; // 0x0
	[CompilerGenerated]
	private bool <GpuBoost>k__BackingField; // 0x1

	// Properties
	public bool CpuBoost { get; set; }
	public bool GpuBoost { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x84F9158 Offset: 0x84F5158 VA: 0x84F9158
	public bool get_CpuBoost() { }

	[CompilerGenerated]
	// RVA: 0x84F9160 Offset: 0x84F5160 VA: 0x84F9160
	public void set_CpuBoost(bool value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x84F916C Offset: 0x84F516C VA: 0x84F916C
	public bool get_GpuBoost() { }

	[CompilerGenerated]
	// RVA: 0x84F9174 Offset: 0x84F5174 VA: 0x84F9174
	public void set_GpuBoost(bool value) { }
}

// Namespace: UnityEngine.AdaptivePerformance
public sealed class PerformanceBoostChangeHandler : MulticastDelegate // TypeDefIndex: 26820
{
	// Methods

	// RVA: 0x84F38C4 Offset: 0x84EF8C4 VA: 0x84F38C4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x84F9180 Offset: 0x84F5180 VA: 0x84F9180 Slot: 13
	public virtual void Invoke(PerformanceBoostChangeEventArgs boostEventArgs) { }

	// RVA: 0x84F9198 Offset: 0x84F5198 VA: 0x84F9198 Slot: 14
	public virtual IAsyncResult BeginInvoke(PerformanceBoostChangeEventArgs boostEventArgs, AsyncCallback callback, object object) { }

	// RVA: 0x84F921C Offset: 0x84F521C VA: 0x84F921C Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: UnityEngine.AdaptivePerformance
public struct PerformanceLevelChangeEventArgs // TypeDefIndex: 26821
{
	// Fields
	[CompilerGenerated]
	private int <CpuLevel>k__BackingField; // 0x0
	[CompilerGenerated]
	private int <CpuLevelDelta>k__BackingField; // 0x4
	[CompilerGenerated]
	private int <GpuLevel>k__BackingField; // 0x8
	[CompilerGenerated]
	private int <GpuLevelDelta>k__BackingField; // 0xC
	[CompilerGenerated]
	private PerformanceControlMode <PerformanceControlMode>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <ManualOverride>k__BackingField; // 0x14

	// Properties
	public int CpuLevel { get; set; }
	public int CpuLevelDelta { get; set; }
	public int GpuLevel { get; set; }
	public int GpuLevelDelta { get; set; }
	public PerformanceControlMode PerformanceControlMode { get; set; }
	public bool ManualOverride { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x84F9228 Offset: 0x84F5228 VA: 0x84F9228
	public int get_CpuLevel() { }

	[CompilerGenerated]
	// RVA: 0x84F9230 Offset: 0x84F5230 VA: 0x84F9230
	public void set_CpuLevel(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x84F9238 Offset: 0x84F5238 VA: 0x84F9238
	public int get_CpuLevelDelta() { }

	[CompilerGenerated]
	// RVA: 0x84F9240 Offset: 0x84F5240 VA: 0x84F9240
	public void set_CpuLevelDelta(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x84F9248 Offset: 0x84F5248 VA: 0x84F9248
	public int get_GpuLevel() { }

	[CompilerGenerated]
	// RVA: 0x84F9250 Offset: 0x84F5250 VA: 0x84F9250
	public void set_GpuLevel(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x84F9258 Offset: 0x84F5258 VA: 0x84F9258
	public int get_GpuLevelDelta() { }

	[CompilerGenerated]
	// RVA: 0x84F9260 Offset: 0x84F5260 VA: 0x84F9260
	public void set_GpuLevelDelta(int value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x84F9268 Offset: 0x84F5268 VA: 0x84F9268
	public PerformanceControlMode get_PerformanceControlMode() { }

	[CompilerGenerated]
	// RVA: 0x84F9270 Offset: 0x84F5270 VA: 0x84F9270
	public void set_PerformanceControlMode(PerformanceControlMode value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x84F9278 Offset: 0x84F5278 VA: 0x84F9278
	public bool get_ManualOverride() { }

	[CompilerGenerated]
	// RVA: 0x84F9280 Offset: 0x84F5280 VA: 0x84F9280
	public void set_ManualOverride(bool value) { }
}

// Namespace: UnityEngine.AdaptivePerformance
public sealed class PerformanceLevelChangeHandler : MulticastDelegate // TypeDefIndex: 26822
{
	// Methods

	// RVA: 0x84F3784 Offset: 0x84EF784 VA: 0x84F3784
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x84F928C Offset: 0x84F528C VA: 0x84F928C Slot: 13
	public virtual void Invoke(PerformanceLevelChangeEventArgs levelChangeEventArgs) { }

	// RVA: 0x84F92C8 Offset: 0x84F52C8 VA: 0x84F92C8 Slot: 14
	public virtual IAsyncResult BeginInvoke(PerformanceLevelChangeEventArgs levelChangeEventArgs, AsyncCallback callback, object object) { }

	// RVA: 0x84F9354 Offset: 0x84F5354 VA: 0x84F9354 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: UnityEngine.AdaptivePerformance
public interface IPerformanceStatus // TypeDefIndex: 26823
{
	// Properties
	public abstract PerformanceMetrics PerformanceMetrics { get; }
	public abstract FrameTiming FrameTiming { get; }
	public abstract PerformanceMode PerformanceMode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract PerformanceMetrics get_PerformanceMetrics();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract FrameTiming get_FrameTiming();

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_PerformanceBottleneckChangeEvent(PerformanceBottleneckChangeHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void remove_PerformanceBottleneckChangeEvent(PerformanceBottleneckChangeHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void add_PerformanceLevelChangeEvent(PerformanceLevelChangeHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void remove_PerformanceLevelChangeEvent(PerformanceLevelChangeHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 6
	public abstract void add_PerformanceBoostChangeEvent(PerformanceBoostChangeHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 7
	public abstract void remove_PerformanceBoostChangeEvent(PerformanceBoostChangeHandler value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract PerformanceMode get_PerformanceMode();
}

// Namespace: UnityEngine.AdaptivePerformance
public struct PerformanceMetrics // TypeDefIndex: 26824
{
	// Fields
	[CompilerGenerated]
	private int <CurrentCpuLevel>k__BackingField; // 0x0
	[CompilerGenerated]
	private int <CurrentGpuLevel>k__BackingField; // 0x4
	[CompilerGenerated]
	private PerformanceBottleneck <PerformanceBottleneck>k__BackingField; // 0x8
	[CompilerGenerated]
	private bool <CpuPerformanceBoost>k__BackingField; // 0xC
	[CompilerGenerated]
	private bool <GpuPerformanceBoost>k__BackingField; // 0xD
	[CompilerGenerated]
	private ClusterInfo <ClusterInfo>k__BackingField; // 0x10

	// Properties
	public int CurrentCpuLevel { get; set; }
	public int CurrentGpuLevel { get; set; }
	public PerformanceBottleneck PerformanceBottleneck { get; set; }
	public bool CpuPerformanceBoost { get; set; }
	public bool GpuPerformanceBoost { get; set; }
	public ClusterInfo ClusterInfo { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x84F9360 Offset: 0x84F5360 VA: 0x84F9360
	public int get_CurrentCpuLevel() { }

	[CompilerGenerated]
	// RVA: 0x84F9368 Offset: 0x84F5368 VA: 0x84F9368
	public void set_CurrentCpuLevel(int value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x84F9370 Offset: 0x84F5370 VA: 0x84F9370
	public int get_CurrentGpuLevel() { }

	[CompilerGenerated]
	// RVA: 0x84F9378 Offset: 0x84F5378 VA: 0x84F9378
	public void set_CurrentGpuLevel(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x84F9380 Offset: 0x84F5380 VA: 0x84F9380
	public PerformanceBottleneck get_PerformanceBottleneck() { }

	[CompilerGenerated]
	// RVA: 0x84F9388 Offset: 0x84F5388 VA: 0x84F9388
	public void set_PerformanceBottleneck(PerformanceBottleneck value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x84F9390 Offset: 0x84F5390 VA: 0x84F9390
	public bool get_CpuPerformanceBoost() { }

	[CompilerGenerated]
	// RVA: 0x84F9398 Offset: 0x84F5398 VA: 0x84F9398
	public void set_CpuPerformanceBoost(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x84F93A4 Offset: 0x84F53A4 VA: 0x84F93A4
	public bool get_GpuPerformanceBoost() { }

	[CompilerGenerated]
	// RVA: 0x84F93AC Offset: 0x84F53AC VA: 0x84F93AC
	public void set_GpuPerformanceBoost(bool value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x84F93B8 Offset: 0x84F53B8 VA: 0x84F93B8
	public ClusterInfo get_ClusterInfo() { }

	[CompilerGenerated]
	// RVA: 0x84F93C8 Offset: 0x84F53C8 VA: 0x84F93C8
	public void set_ClusterInfo(ClusterInfo value) { }
}

// Namespace: UnityEngine.AdaptivePerformance
public struct FrameTiming // TypeDefIndex: 26825
{
	// Fields
	[CompilerGenerated]
	private float <CurrentFrameTime>k__BackingField; // 0x0
	[CompilerGenerated]
	private float <AverageFrameTime>k__BackingField; // 0x4
	[CompilerGenerated]
	private float <CurrentGpuFrameTime>k__BackingField; // 0x8
	[CompilerGenerated]
	private float <AverageGpuFrameTime>k__BackingField; // 0xC
	[CompilerGenerated]
	private float <CurrentCpuFrameTime>k__BackingField; // 0x10
	[CompilerGenerated]
	private float <AverageCpuFrameTime>k__BackingField; // 0x14

	// Properties
	public float CurrentFrameTime { get; set; }
	public float AverageFrameTime { get; set; }
	public float CurrentGpuFrameTime { get; set; }
	public float AverageGpuFrameTime { get; set; }
	public float CurrentCpuFrameTime { get; set; }
	public float AverageCpuFrameTime { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x84F93D4 Offset: 0x84F53D4 VA: 0x84F93D4
	public float get_CurrentFrameTime() { }

	[CompilerGenerated]
	// RVA: 0x84F93DC Offset: 0x84F53DC VA: 0x84F93DC
	public void set_CurrentFrameTime(float value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x84F93E4 Offset: 0x84F53E4 VA: 0x84F93E4
	public float get_AverageFrameTime() { }

	[CompilerGenerated]
	// RVA: 0x84F93EC Offset: 0x84F53EC VA: 0x84F93EC
	public void set_AverageFrameTime(float value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x84F93F4 Offset: 0x84F53F4 VA: 0x84F93F4
	public float get_CurrentGpuFrameTime() { }

	[CompilerGenerated]
	// RVA: 0x84F93FC Offset: 0x84F53FC VA: 0x84F93FC
	public void set_CurrentGpuFrameTime(float value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x84F9404 Offset: 0x84F5404 VA: 0x84F9404
	public float get_AverageGpuFrameTime() { }

	[CompilerGenerated]
	// RVA: 0x84F940C Offset: 0x84F540C VA: 0x84F940C
	public void set_AverageGpuFrameTime(float value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x84F9414 Offset: 0x84F5414 VA: 0x84F9414
	public float get_CurrentCpuFrameTime() { }

	[CompilerGenerated]
	// RVA: 0x84F941C Offset: 0x84F541C VA: 0x84F941C
	public void set_CurrentCpuFrameTime(float value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x84F9424 Offset: 0x84F5424 VA: 0x84F9424
	public float get_AverageCpuFrameTime() { }

	[CompilerGenerated]
	// RVA: 0x84F942C Offset: 0x84F542C VA: 0x84F942C
	public void set_AverageCpuFrameTime(float value) { }
}

// Namespace: UnityEngine.AdaptivePerformance
public enum PerformanceMode // TypeDefIndex: 26826
{
	// Fields
	public int value__; // 0x0
	public const PerformanceMode Unknown = 0;
	public const PerformanceMode Standard = 1;
	public const PerformanceMode Optimize = 2;
	public const PerformanceMode CPU = 3;
	public const PerformanceMode GPU = 4;
	public const PerformanceMode Battery = 5;
}

// Namespace: UnityEngine.AdaptivePerformance
public enum PerformanceBottleneck // TypeDefIndex: 26827
{
	// Fields
	public int value__; // 0x0
	public const PerformanceBottleneck Unknown = 0;
	public const PerformanceBottleneck CPU = 1;
	public const PerformanceBottleneck GPU = 2;
	public const PerformanceBottleneck TargetFrameRate = 3;
}

// Namespace: UnityEngine.AdaptivePerformance
public struct ClusterInfo // TypeDefIndex: 26828
{
	// Fields
	[CompilerGenerated]
	private int <BigCore>k__BackingField; // 0x0
	[CompilerGenerated]
	private int <MediumCore>k__BackingField; // 0x4
	[CompilerGenerated]
	private int <LittleCore>k__BackingField; // 0x8

	// Properties
	public int BigCore { get; set; }
	public int MediumCore { get; set; }
	public int LittleCore { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x84F9434 Offset: 0x84F5434 VA: 0x84F9434
	public int get_BigCore() { }

	[CompilerGenerated]
	// RVA: 0x84F943C Offset: 0x84F543C VA: 0x84F943C
	public void set_BigCore(int value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x84F9444 Offset: 0x84F5444 VA: 0x84F9444
	public int get_MediumCore() { }

	[CompilerGenerated]
	// RVA: 0x84F944C Offset: 0x84F544C VA: 0x84F944C
	public void set_MediumCore(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x84F9454 Offset: 0x84F5454 VA: 0x84F9454
	public int get_LittleCore() { }

	[CompilerGenerated]
	// RVA: 0x84F945C Offset: 0x84F545C VA: 0x84F945C
	public void set_LittleCore(int value) { }
}

// Namespace: UnityEngine.AdaptivePerformance
public sealed class ThermalEventHandler : MulticastDelegate // TypeDefIndex: 26829
{
	// Methods

	// RVA: 0x84F3644 Offset: 0x84EF644 VA: 0x84F3644
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x84F9464 Offset: 0x84F5464 VA: 0x84F9464 Slot: 13
	public virtual void Invoke(ThermalMetrics thermalMetrics) { }

	// RVA: 0x84F947C Offset: 0x84F547C VA: 0x84F947C Slot: 14
	public virtual IAsyncResult BeginInvoke(ThermalMetrics thermalMetrics, AsyncCallback callback, object object) { }

	// RVA: 0x84F9504 Offset: 0x84F5504 VA: 0x84F9504 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: UnityEngine.AdaptivePerformance
public struct ThermalMetrics // TypeDefIndex: 26830
{
	// Fields
	[CompilerGenerated]
	private WarningLevel <WarningLevel>k__BackingField; // 0x0
	[CompilerGenerated]
	private float <TemperatureLevel>k__BackingField; // 0x4
	[CompilerGenerated]
	private float <TemperatureTrend>k__BackingField; // 0x8

	// Properties
	public WarningLevel WarningLevel { get; set; }
	public float TemperatureLevel { get; set; }
	public float TemperatureTrend { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x84F9510 Offset: 0x84F5510 VA: 0x84F9510
	public WarningLevel get_WarningLevel() { }

	[CompilerGenerated]
	// RVA: 0x84F9518 Offset: 0x84F5518 VA: 0x84F9518
	public void set_WarningLevel(WarningLevel value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x84F9520 Offset: 0x84F5520 VA: 0x84F9520
	public float get_TemperatureLevel() { }

	[CompilerGenerated]
	// RVA: 0x84F9528 Offset: 0x84F5528 VA: 0x84F9528
	public void set_TemperatureLevel(float value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x84F9530 Offset: 0x84F5530 VA: 0x84F9530
	public float get_TemperatureTrend() { }

	[CompilerGenerated]
	// RVA: 0x84F9538 Offset: 0x84F5538 VA: 0x84F9538
	public void set_TemperatureTrend(float value) { }
}

// Namespace: UnityEngine.AdaptivePerformance
public interface IThermalStatus // TypeDefIndex: 26831
{
	// Properties
	public abstract ThermalMetrics ThermalMetrics { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ThermalMetrics get_ThermalMetrics();

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void add_ThermalEvent(ThermalEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void remove_ThermalEvent(ThermalEventHandler value);
}

// Namespace: UnityEngine.AdaptivePerformance
public enum WarningLevel // TypeDefIndex: 26832
{
	// Fields
	public int value__; // 0x0
	public const WarningLevel NoWarning = 0;
	public const WarningLevel ThrottlingImminent = 1;
	public const WarningLevel Throttling = 2;
}

// Namespace: UnityEngine.AdaptivePerformance
[Usage(4)]
public sealed class AdaptivePerformanceConfigurationDataAttribute : Attribute // TypeDefIndex: 26833
{
	// Fields
	[CompilerGenerated]
	private string <displayName>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <buildSettingsKey>k__BackingField; // 0x18

	// Properties
	public string displayName { get; set; }
	public string buildSettingsKey { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x84F9540 Offset: 0x84F5540 VA: 0x84F9540
	public string get_displayName() { }

	[CompilerGenerated]
	// RVA: 0x84F9548 Offset: 0x84F5548 VA: 0x84F9548
	public void set_displayName(string value) { }

	[CompilerGenerated]
	// RVA: 0x84F9550 Offset: 0x84F5550 VA: 0x84F9550
	public string get_buildSettingsKey() { }

	[CompilerGenerated]
	// RVA: 0x84F9558 Offset: 0x84F5558 VA: 0x84F9558
	public void set_buildSettingsKey(string value) { }

	// RVA: 0x84F9560 Offset: 0x84F5560 VA: 0x84F9560
	private void .ctor() { }

	// RVA: 0x84F9568 Offset: 0x84F5568 VA: 0x84F9568
	public void .ctor(string displayName, string buildSettingsKey) { }
}

// Namespace: UnityEngine.AdaptivePerformance
public class AdaptivePerformanceGeneralSettings : ScriptableObject // TypeDefIndex: 26834
{
	// Fields
	public static string k_SettingsKey; // 0x0
	internal static AdaptivePerformanceGeneralSettings s_RuntimeSettingsInstance; // 0x8
	[SerializeField]
	internal AdaptivePerformanceManagerSettings m_LoaderManagerInstance; // 0x18
	[Tooltip("Enable this to automatically start up Adaptive Performance at runtime.")]
	[SerializeField]
	internal bool m_InitManagerOnStart; // 0x20
	private AdaptivePerformanceManagerSettings m_AdaptivePerformanceManager; // 0x28
	private bool m_ProviderIntialized; // 0x30
	private bool m_ProviderStarted; // 0x31

	// Properties
	public AdaptivePerformanceManagerSettings Manager { get; set; }
	public bool IsProviderInitialized { get; }
	public bool IsProviderStarted { get; }
	public static AdaptivePerformanceGeneralSettings Instance { get; }
	public AdaptivePerformanceManagerSettings AssignedSettings { get; }
	public bool InitManagerOnStart { get; }

	// Methods

	// RVA: 0x84F95AC Offset: 0x84F55AC VA: 0x84F95AC
	public AdaptivePerformanceManagerSettings get_Manager() { }

	// RVA: 0x84F95B4 Offset: 0x84F55B4 VA: 0x84F95B4
	public void set_Manager(AdaptivePerformanceManagerSettings value) { }

	// RVA: 0x84F95BC Offset: 0x84F55BC VA: 0x84F95BC
	public bool get_IsProviderInitialized() { }

	// RVA: 0x84F95C4 Offset: 0x84F55C4 VA: 0x84F95C4
	public bool get_IsProviderStarted() { }

	// RVA: 0x84F95CC Offset: 0x84F55CC VA: 0x84F95CC
	public static AdaptivePerformanceGeneralSettings get_Instance() { }

	// RVA: 0x84F9624 Offset: 0x84F5624 VA: 0x84F9624
	public AdaptivePerformanceManagerSettings get_AssignedSettings() { }

	// RVA: 0x84F962C Offset: 0x84F562C VA: 0x84F962C
	public bool get_InitManagerOnStart() { }

	// RVA: 0x84F9634 Offset: 0x84F5634 VA: 0x84F9634
	private void Awake() { }

	// RVA: 0x84F9754 Offset: 0x84F5754 VA: 0x84F9754
	private static void Quit() { }

	// RVA: 0x84F9830 Offset: 0x84F5830 VA: 0x84F9830
	private void OnDestroy() { }

	[RuntimeInitializeOnLoadMethod(2)]
	// RVA: 0x84F9898 Offset: 0x84F5898 VA: 0x84F9898
	internal static void AttemptInitializeAdaptivePerformanceOnLoad() { }

	[RuntimeInitializeOnLoadMethod(3)]
	// RVA: 0x84F997C Offset: 0x84F597C VA: 0x84F997C
	internal static void AttemptStartAdaptivePerformanceOnBeforeSplashScreen() { }

	// RVA: 0x84F2FC8 Offset: 0x84EEFC8 VA: 0x84F2FC8
	internal void InitAdaptivePerformance() { }

	// RVA: 0x84F3C40 Offset: 0x84EFC40 VA: 0x84F3C40
	internal void StartAdaptivePerformance() { }

	// RVA: 0x84F3DDC Offset: 0x84EFDDC VA: 0x84F3DDC
	internal void StopAdaptivePerformance() { }

	// RVA: 0x84F3EC8 Offset: 0x84EFEC8 VA: 0x84F3EC8
	internal void DeInitAdaptivePerformance() { }

	// RVA: 0x84FA090 Offset: 0x84F6090 VA: 0x84FA090
	public void .ctor() { }

	// RVA: 0x84FA0A0 Offset: 0x84F60A0 VA: 0x84FA0A0
	private static void .cctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance
public abstract class AdaptivePerformanceLoader : ScriptableObject // TypeDefIndex: 26835
{
	// Properties
	public abstract bool Initialized { get; }
	public abstract bool Running { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_Initialized();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_Running();

	// RVA: 0x84FA120 Offset: 0x84F6120 VA: 0x84FA120 Slot: 6
	public virtual bool Initialize() { }

	// RVA: 0x84FA128 Offset: 0x84F6128 VA: 0x84FA128 Slot: 7
	public virtual bool Start() { }

	// RVA: 0x84FA130 Offset: 0x84F6130 VA: 0x84FA130 Slot: 8
	public virtual bool Stop() { }

	// RVA: 0x84FA138 Offset: 0x84F6138 VA: 0x84FA138 Slot: 9
	public virtual bool Deinitialize() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract T GetLoadedSubsystem<T>();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AdaptivePerformanceLoader.GetLoadedSubsystem<object>
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public abstract ISubsystem GetDefaultSubsystem();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract IAdaptivePerformanceSettings GetSettings();

	// RVA: 0x84FA140 Offset: 0x84F6140 VA: 0x84FA140
	protected void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance
public abstract class AdaptivePerformanceLoaderHelper : AdaptivePerformanceLoader // TypeDefIndex: 26836
{
	// Fields
	protected Dictionary<Type, ISubsystem> m_SubsystemInstanceMap; // 0x18

	// Methods

	// RVA: -1 Offset: -1 Slot: 10
	public override T GetLoadedSubsystem<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B72F4 Offset: 0x44B32F4 VA: 0x44B72F4
	|-AdaptivePerformanceLoaderHelper.GetLoadedSubsystem<object>
	*/

	// RVA: -1 Offset: -1
	protected void StartSubsystem<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B740C Offset: 0x44B340C VA: 0x44B740C
	|-AdaptivePerformanceLoaderHelper.StartSubsystem<object>
	*/

	// RVA: -1 Offset: -1
	protected void StopSubsystem<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B74EC Offset: 0x44B34EC VA: 0x44B74EC
	|-AdaptivePerformanceLoaderHelper.StopSubsystem<object>
	*/

	// RVA: -1 Offset: -1
	protected void DestroySubsystem<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B70B8 Offset: 0x44B30B8 VA: 0x44B70B8
	|-AdaptivePerformanceLoaderHelper.DestroySubsystem<object>
	*/

	// RVA: -1 Offset: -1
	protected void CreateSubsystem<TDescriptor, TSubsystem>(List<TDescriptor> descriptors, string id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B6918 Offset: 0x44B2918 VA: 0x44B6918
	|-AdaptivePerformanceLoaderHelper.CreateSubsystem<object, object>
	|
	|-RVA: 0x44B6C1C Offset: 0x44B2C1C VA: 0x44B6C1C
	|-AdaptivePerformanceLoaderHelper.CreateSubsystem<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x84FA148 Offset: 0x84F6148 VA: 0x84FA148 Slot: 9
	public override bool Deinitialize() { }

	// RVA: 0x84FA1A0 Offset: 0x84F61A0 VA: 0x84FA1A0
	protected void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AdaptivePerformanceManagerSettings.<InitializeLoader>d__20 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 26837
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AdaptivePerformanceManagerSettings <>4__this; // 0x20
	private List.Enumerator<AdaptivePerformanceLoader> <>7__wrap1; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x84FA36C Offset: 0x84F636C VA: 0x84FA36C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x84FA444 Offset: 0x84F6444 VA: 0x84FA444 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x84FA460 Offset: 0x84F6460 VA: 0x84FA460 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x84FA760 Offset: 0x84F6760 VA: 0x84FA760
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x84FA7B0 Offset: 0x84F67B0 VA: 0x84FA7B0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x84FA7B8 Offset: 0x84F67B8 VA: 0x84FA7B8 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x84FA7F0 Offset: 0x84F67F0 VA: 0x84FA7F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: UnityEngine.AdaptivePerformance
public sealed class AdaptivePerformanceManagerSettings : ScriptableObject // TypeDefIndex: 26838
{
	// Fields
	[HideInInspector]
	private bool m_InitializationComplete; // 0x18
	[SerializeField]
	[Tooltip("Determines if the Adaptive Performance Manager instance is responsible for creating and destroying the appropriate loader instance.")]
	private bool m_AutomaticLoading; // 0x19
	[Tooltip("Determines if the Adaptive Performance Manager instance is responsible for starting and stopping subsystems for the active loader instance.")]
	[SerializeField]
	private bool m_AutomaticRunning; // 0x1A
	[SerializeField]
	[Tooltip("List of Adaptive Performance Loader instances arranged in desired load order.")]
	private List<AdaptivePerformanceLoader> m_Loaders; // 0x20
	[HideInInspector]
	private static AdaptivePerformanceLoader s_ActiveLoader; // 0x0

	// Properties
	public bool automaticLoading { get; set; }
	public bool automaticRunning { get; set; }
	public List<AdaptivePerformanceLoader> loaders { get; }
	public bool isInitializationComplete { get; }
	[HideInInspector]
	public AdaptivePerformanceLoader activeLoader { get; set; }

	// Methods

	// RVA: 0x84FA228 Offset: 0x84F6228 VA: 0x84FA228
	public bool get_automaticLoading() { }

	// RVA: 0x84FA230 Offset: 0x84F6230 VA: 0x84FA230
	public void set_automaticLoading(bool value) { }

	// RVA: 0x84FA23C Offset: 0x84F623C VA: 0x84FA23C
	public bool get_automaticRunning() { }

	// RVA: 0x84FA244 Offset: 0x84F6244 VA: 0x84FA244
	public void set_automaticRunning(bool value) { }

	// RVA: 0x84FA250 Offset: 0x84F6250 VA: 0x84FA250
	public List<AdaptivePerformanceLoader> get_loaders() { }

	// RVA: 0x84FA258 Offset: 0x84F6258 VA: 0x84FA258
	public bool get_isInitializationComplete() { }

	// RVA: 0x84FA260 Offset: 0x84F6260 VA: 0x84FA260
	public AdaptivePerformanceLoader get_activeLoader() { }

	// RVA: 0x84FA2A8 Offset: 0x84F62A8 VA: 0x84FA2A8
	private void set_activeLoader(AdaptivePerformanceLoader value) { }

	// RVA: -1 Offset: -1
	public T ActiveLoaderAs<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44B75CC Offset: 0x44B35CC VA: 0x44B75CC
	|-AdaptivePerformanceManagerSettings.ActiveLoaderAs<object>
	*/

	// RVA: 0x84F9A60 Offset: 0x84F5A60 VA: 0x84F9A60
	internal void InitializeLoaderSync() { }

	[IteratorStateMachine(typeof(AdaptivePerformanceManagerSettings.<InitializeLoader>d__20))]
	// RVA: 0x84FA300 Offset: 0x84F6300 VA: 0x84FA300
	internal IEnumerator InitializeLoader() { }

	// RVA: 0x84F9CE8 Offset: 0x84F5CE8 VA: 0x84F9CE8
	internal void StartSubsystems() { }

	// RVA: 0x84F9E18 Offset: 0x84F5E18 VA: 0x84F9E18
	internal void StopSubsystems() { }

	// RVA: 0x84F9F48 Offset: 0x84F5F48 VA: 0x84F9F48
	internal void DeinitializeLoader() { }

	// RVA: 0x84FA394 Offset: 0x84F6394 VA: 0x84FA394
	private void OnDisable() { }

	// RVA: 0x84FA3AC Offset: 0x84F63AC VA: 0x84FA3AC
	private void OnDestroy() { }

	// RVA: 0x84FA3BC Offset: 0x84F63BC VA: 0x84FA3BC
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance
[Serializable]
public class AdaptivePerformanceIndexerSettings // TypeDefIndex: 26839
{
	// Fields
	private const string m_FeatureName = "Indexer";
	[SerializeField]
	[Tooltip("Active")]
	private bool m_Active; // 0x10
	[SerializeField]
	[Tooltip("Thermal Action Delay")]
	private float m_ThermalActionDelay; // 0x14
	[Tooltip("Performance Action Delay")]
	[SerializeField]
	private float m_PerformanceActionDelay; // 0x18

	// Properties
	public bool active { get; set; }
	public float thermalActionDelay { get; set; }
	public float performanceActionDelay { get; set; }

	// Methods

	// RVA: 0x84FA7F8 Offset: 0x84F67F8 VA: 0x84FA7F8
	public bool get_active() { }

	// RVA: 0x84FA800 Offset: 0x84F6800 VA: 0x84FA800
	public void set_active(bool value) { }

	// RVA: 0x84FA818 Offset: 0x84F6818 VA: 0x84FA818
	public float get_thermalActionDelay() { }

	// RVA: 0x84FA820 Offset: 0x84F6820 VA: 0x84FA820
	public void set_thermalActionDelay(float value) { }

	// RVA: 0x84FA828 Offset: 0x84F6828 VA: 0x84FA828
	public float get_performanceActionDelay() { }

	// RVA: 0x84FA830 Offset: 0x84F6830 VA: 0x84FA830
	public void set_performanceActionDelay(float value) { }

	// RVA: 0x84FA838 Offset: 0x84F6838 VA: 0x84FA838
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance
[Serializable]
public class AdaptivePerformanceScalerProfile : AdaptivePerformanceScalerSettings // TypeDefIndex: 26840
{
	// Fields
	[SerializeField]
	[Tooltip("Name of the scaler profile.")]
	private string m_Name; // 0x90

	// Properties
	public string Name { get; set; }

	// Methods

	// RVA: 0x84FA854 Offset: 0x84F6854 VA: 0x84FA854
	public string get_Name() { }

	// RVA: 0x84FA85C Offset: 0x84F685C VA: 0x84FA85C
	public void set_Name(string value) { }

	// RVA: 0x84FA864 Offset: 0x84F6864 VA: 0x84FA864
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance
[Serializable]
public class AdaptivePerformanceScalerSettings // TypeDefIndex: 26841
{
	// Fields
	[SerializeField]
	[Tooltip("Settings for a scaler used by the Indexer to adjust the application update rate using Application.TargetFramerate")]
	private AdaptivePerformanceScalerSettingsBase m_AdaptiveFramerate; // 0x10
	[Tooltip("Settings for a scaler used by the Indexer to adjust the resolution of all render targets that allow dynamic resolution.")]
	[SerializeField]
	private AdaptivePerformanceScalerSettingsBase m_AdaptiveResolution; // 0x18
	[Tooltip("Settings for a scaler used by the Indexer to control if dynamic batching is enabled.")]
	[SerializeField]
	private AdaptivePerformanceScalerSettingsBase m_AdaptiveBatching; // 0x20
	[SerializeField]
	[Tooltip("Settings for a scaler used by the Indexer for adjusting at what distance LODs are switched.")]
	private AdaptivePerformanceScalerSettingsBase m_AdaptiveLOD; // 0x28
	[SerializeField]
	[Tooltip("Settings for a scaler used by the Indexer to adjust the size of the palette used for color grading in URP.")]
	private AdaptivePerformanceScalerSettingsBase m_AdaptiveLut; // 0x30
	[SerializeField]
	[Tooltip("Settings for a scaler used by the Indexer to adjust the level of antialiasing.")]
	private AdaptivePerformanceScalerSettingsBase m_AdaptiveMSAA; // 0x38
	[SerializeField]
	[Tooltip("Settings for a scaler used by the Indexer to adjust the number of shadow cascades to be used.")]
	private AdaptivePerformanceScalerSettingsBase m_AdaptiveShadowCascade; // 0x40
	private const string obsoleteMsg = "AdaptiveShadowCascades has been renamed. Please use AdaptiveShadowCascade. (UnityUpgradable) -> AdaptiveShadowCascade";
	[Tooltip("Settings for a scaler used by the Indexer to change the distance at which shadows are rendered.")]
	[SerializeField]
	private AdaptivePerformanceScalerSettingsBase m_AdaptiveShadowDistance; // 0x48
	[Tooltip("Settings for a scaler used by the Indexer to adjust the resolution of shadow maps.")]
	[SerializeField]
	private AdaptivePerformanceScalerSettingsBase m_AdaptiveShadowmapResolution; // 0x50
	[SerializeField]
	[Tooltip("Settings for a scaler used by the Indexer to adjust the quality of shadows.")]
	private AdaptivePerformanceScalerSettingsBase m_AdaptiveShadowQuality; // 0x58
	[SerializeField]
	[Tooltip("Settings for a scaler used by the Indexer to change if objects in the scene are sorted by depth before rendering to reduce overdraw.")]
	private AdaptivePerformanceScalerSettingsBase m_AdaptiveSorting; // 0x60
	[Tooltip("Settings for a scaler used by the Indexer to disable transparent objects rendering")]
	[SerializeField]
	private AdaptivePerformanceScalerSettingsBase m_AdaptiveTransparency; // 0x68
	[SerializeField]
	[Tooltip("Settings for a scaler used by the Indexer to change the view distance")]
	private AdaptivePerformanceScalerSettingsBase m_AdaptiveViewDistance; // 0x70
	[SerializeField]
	[Tooltip("Settings for a scaler used by the Indexer to change physics properties")]
	private AdaptivePerformanceScalerSettingsBase m_AdaptivePhysics; // 0x78
	[Tooltip("Settings for a scaler used by the Indexer to change decal properties")]
	[SerializeField]
	private AdaptivePerformanceScalerSettingsBase m_AdaptiveDecals; // 0x80
	[Tooltip("Settings for a scaler used by the Indexer to change the layer culling distance")]
	[SerializeField]
	private AdaptivePerformanceScalerSettingsBase m_AdaptiveLayerCulling; // 0x88

	// Properties
	public AdaptivePerformanceScalerSettingsBase AdaptiveFramerate { get; set; }
	public AdaptivePerformanceScalerSettingsBase AdaptiveResolution { get; set; }
	public AdaptivePerformanceScalerSettingsBase AdaptiveBatching { get; set; }
	public AdaptivePerformanceScalerSettingsBase AdaptiveLOD { get; set; }
	public AdaptivePerformanceScalerSettingsBase AdaptiveLut { get; set; }
	public AdaptivePerformanceScalerSettingsBase AdaptiveMSAA { get; set; }
	[Obsolete("AdaptiveShadowCascades has been renamed. Please use AdaptiveShadowCascade. (UnityUpgradable) -> AdaptiveShadowCascade", False)]
	public AdaptivePerformanceScalerSettingsBase AdaptiveShadowCascades { get; }
	public AdaptivePerformanceScalerSettingsBase AdaptiveShadowCascade { get; set; }
	public AdaptivePerformanceScalerSettingsBase AdaptiveShadowDistance { get; set; }
	public AdaptivePerformanceScalerSettingsBase AdaptiveShadowmapResolution { get; set; }
	public AdaptivePerformanceScalerSettingsBase AdaptiveShadowQuality { get; set; }
	public AdaptivePerformanceScalerSettingsBase AdaptiveSorting { get; set; }
	public AdaptivePerformanceScalerSettingsBase AdaptiveTransparency { get; set; }
	public AdaptivePerformanceScalerSettingsBase AdaptiveViewDistance { get; set; }
	public AdaptivePerformanceScalerSettingsBase AdaptivePhysics { get; set; }
	public AdaptivePerformanceScalerSettingsBase AdaptiveDecals { get; set; }
	public AdaptivePerformanceScalerSettingsBase AdaptiveLayerCulling { get; set; }

	// Methods

	// RVA: 0x84FAFBC Offset: 0x84F6FBC VA: 0x84FAFBC
	public void ApplySettings(AdaptivePerformanceScalerSettings settings) { }

	// RVA: 0x84FB09C Offset: 0x84F709C VA: 0x84FB09C
	private void ApplySettingsBase(AdaptivePerformanceScalerSettingsBase destination, AdaptivePerformanceScalerSettingsBase sources) { }

	// RVA: 0x84FB0DC Offset: 0x84F70DC VA: 0x84FB0DC
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveFramerate() { }

	// RVA: 0x84FB0E4 Offset: 0x84F70E4 VA: 0x84FB0E4
	public void set_AdaptiveFramerate(AdaptivePerformanceScalerSettingsBase value) { }

	// RVA: 0x84FB0EC Offset: 0x84F70EC VA: 0x84FB0EC
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveResolution() { }

	// RVA: 0x84FB0F4 Offset: 0x84F70F4 VA: 0x84FB0F4
	public void set_AdaptiveResolution(AdaptivePerformanceScalerSettingsBase value) { }

	// RVA: 0x84FB0FC Offset: 0x84F70FC VA: 0x84FB0FC
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveBatching() { }

	// RVA: 0x84FB104 Offset: 0x84F7104 VA: 0x84FB104
	public void set_AdaptiveBatching(AdaptivePerformanceScalerSettingsBase value) { }

	// RVA: 0x84FB10C Offset: 0x84F710C VA: 0x84FB10C
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveLOD() { }

	// RVA: 0x84FB114 Offset: 0x84F7114 VA: 0x84FB114
	public void set_AdaptiveLOD(AdaptivePerformanceScalerSettingsBase value) { }

	// RVA: 0x84FB11C Offset: 0x84F711C VA: 0x84FB11C
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveLut() { }

	// RVA: 0x84FB124 Offset: 0x84F7124 VA: 0x84FB124
	public void set_AdaptiveLut(AdaptivePerformanceScalerSettingsBase value) { }

	// RVA: 0x84FB12C Offset: 0x84F712C VA: 0x84FB12C
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveMSAA() { }

	// RVA: 0x84FB134 Offset: 0x84F7134 VA: 0x84FB134
	public void set_AdaptiveMSAA(AdaptivePerformanceScalerSettingsBase value) { }

	// RVA: 0x84FB13C Offset: 0x84F713C VA: 0x84FB13C
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveShadowCascades() { }

	// RVA: 0x84FB144 Offset: 0x84F7144 VA: 0x84FB144
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveShadowCascade() { }

	// RVA: 0x84FB14C Offset: 0x84F714C VA: 0x84FB14C
	public void set_AdaptiveShadowCascade(AdaptivePerformanceScalerSettingsBase value) { }

	// RVA: 0x84FB154 Offset: 0x84F7154 VA: 0x84FB154
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveShadowDistance() { }

	// RVA: 0x84FB15C Offset: 0x84F715C VA: 0x84FB15C
	public void set_AdaptiveShadowDistance(AdaptivePerformanceScalerSettingsBase value) { }

	// RVA: 0x84FB164 Offset: 0x84F7164 VA: 0x84FB164
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveShadowmapResolution() { }

	// RVA: 0x84FB16C Offset: 0x84F716C VA: 0x84FB16C
	public void set_AdaptiveShadowmapResolution(AdaptivePerformanceScalerSettingsBase value) { }

	// RVA: 0x84FB174 Offset: 0x84F7174 VA: 0x84FB174
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveShadowQuality() { }

	// RVA: 0x84FB17C Offset: 0x84F717C VA: 0x84FB17C
	public void set_AdaptiveShadowQuality(AdaptivePerformanceScalerSettingsBase value) { }

	// RVA: 0x84FB184 Offset: 0x84F7184 VA: 0x84FB184
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveSorting() { }

	// RVA: 0x84FB18C Offset: 0x84F718C VA: 0x84FB18C
	public void set_AdaptiveSorting(AdaptivePerformanceScalerSettingsBase value) { }

	// RVA: 0x84FB194 Offset: 0x84F7194 VA: 0x84FB194
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveTransparency() { }

	// RVA: 0x84FB19C Offset: 0x84F719C VA: 0x84FB19C
	public void set_AdaptiveTransparency(AdaptivePerformanceScalerSettingsBase value) { }

	// RVA: 0x84FB1A4 Offset: 0x84F71A4 VA: 0x84FB1A4
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveViewDistance() { }

	// RVA: 0x84FB1AC Offset: 0x84F71AC VA: 0x84FB1AC
	public void set_AdaptiveViewDistance(AdaptivePerformanceScalerSettingsBase value) { }

	// RVA: 0x84FB1B4 Offset: 0x84F71B4 VA: 0x84FB1B4
	public AdaptivePerformanceScalerSettingsBase get_AdaptivePhysics() { }

	// RVA: 0x84FB1BC Offset: 0x84F71BC VA: 0x84FB1BC
	public void set_AdaptivePhysics(AdaptivePerformanceScalerSettingsBase value) { }

	// RVA: 0x84FB1C4 Offset: 0x84F71C4 VA: 0x84FB1C4
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveDecals() { }

	// RVA: 0x84FB1CC Offset: 0x84F71CC VA: 0x84FB1CC
	public void set_AdaptiveDecals(AdaptivePerformanceScalerSettingsBase value) { }

	// RVA: 0x84FB1D4 Offset: 0x84F71D4 VA: 0x84FB1D4
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveLayerCulling() { }

	// RVA: 0x84FB1DC Offset: 0x84F71DC VA: 0x84FB1DC
	public void set_AdaptiveLayerCulling(AdaptivePerformanceScalerSettingsBase value) { }

	// RVA: 0x84FA8B8 Offset: 0x84F68B8 VA: 0x84FA8B8
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance
[Serializable]
public class AdaptivePerformanceScalerSettingsBase // TypeDefIndex: 26842
{
	// Fields
	[SerializeField]
	[Tooltip("Name of the scaler.")]
	private string m_Name; // 0x10
	[SerializeField]
	[Tooltip("Active")]
	private bool m_Enabled; // 0x18
	[SerializeField]
	[Tooltip("Scale to control the quality impact for the scaler. No quality change when 1, improved quality when >1, and lowered quality when <1.")]
	private float m_Scale; // 0x1C
	[SerializeField]
	[Tooltip("Visual impact the scaler has on the application. The higher the value, the more impact the scaler has on the visuals.")]
	private ScalerVisualImpact m_VisualImpact; // 0x20
	[SerializeField]
	[Tooltip("Application bottleneck that the scaler targets. The target selected has the most impact on the quality control of this scaler.")]
	private ScalerTarget m_Target; // 0x24
	[SerializeField]
	[Tooltip("Maximum level for the scaler. This is tied to the implementation of the scaler to divide the levels into concrete steps.")]
	private int m_MaxLevel; // 0x28
	[SerializeField]
	[Tooltip("Minimum value for the scale boundary.")]
	private float m_MinBound; // 0x2C
	[SerializeField]
	[Tooltip("Maximum value for the scale boundary.")]
	private float m_MaxBound; // 0x30

	// Properties
	public string name { get; set; }
	public bool enabled { get; set; }
	public float scale { get; set; }
	public ScalerVisualImpact visualImpact { get; set; }
	public ScalerTarget target { get; set; }
	public int maxLevel { get; set; }
	public float minBound { get; set; }
	public float maxBound { get; set; }

	// Methods

	// RVA: 0x84FB1E4 Offset: 0x84F71E4 VA: 0x84FB1E4
	public string get_name() { }

	// RVA: 0x84FB1EC Offset: 0x84F71EC VA: 0x84FB1EC
	public void set_name(string value) { }

	// RVA: 0x84FB1F4 Offset: 0x84F71F4 VA: 0x84FB1F4
	public bool get_enabled() { }

	// RVA: 0x84FB1FC Offset: 0x84F71FC VA: 0x84FB1FC
	public void set_enabled(bool value) { }

	// RVA: 0x84FB208 Offset: 0x84F7208 VA: 0x84FB208
	public float get_scale() { }

	// RVA: 0x84FB210 Offset: 0x84F7210 VA: 0x84FB210
	public void set_scale(float value) { }

	// RVA: 0x84FB218 Offset: 0x84F7218 VA: 0x84FB218
	public ScalerVisualImpact get_visualImpact() { }

	// RVA: 0x84FB220 Offset: 0x84F7220 VA: 0x84FB220
	public void set_visualImpact(ScalerVisualImpact value) { }

	// RVA: 0x84FB228 Offset: 0x84F7228 VA: 0x84FB228
	public ScalerTarget get_target() { }

	// RVA: 0x84FB230 Offset: 0x84F7230 VA: 0x84FB230
	public void set_target(ScalerTarget value) { }

	// RVA: 0x84FB238 Offset: 0x84F7238 VA: 0x84FB238
	public int get_maxLevel() { }

	// RVA: 0x84FB240 Offset: 0x84F7240 VA: 0x84FB240
	public void set_maxLevel(int value) { }

	// RVA: 0x84FB248 Offset: 0x84F7248 VA: 0x84FB248
	public float get_minBound() { }

	// RVA: 0x84FB250 Offset: 0x84F7250 VA: 0x84FB250
	public void set_minBound(float value) { }

	// RVA: 0x84FB258 Offset: 0x84F7258 VA: 0x84FB258
	public float get_maxBound() { }

	// RVA: 0x84FB260 Offset: 0x84F7260 VA: 0x84FB260
	public void set_maxBound(float value) { }

	// RVA: 0x84F8F8C Offset: 0x84F4F8C VA: 0x84F8F8C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class IAdaptivePerformanceSettings.<>c__DisplayClass29_0 // TypeDefIndex: 26843
{
	// Fields
	public PropertyInfo property; // 0x10

	// Methods

	// RVA: 0x84FB8E8 Offset: 0x84F78E8 VA: 0x84FB8E8
	public void .ctor() { }

	// RVA: 0x84FB9FC Offset: 0x84F79FC VA: 0x84FB9FC
	internal bool <ApplyScalerProfileToAllScalers>b__0(AdaptivePerformanceScaler s) { }
}

// Namespace: UnityEngine.AdaptivePerformance
public class IAdaptivePerformanceSettings : ScriptableObject // TypeDefIndex: 26844
{
	// Fields
	[Tooltip("Enable Logging in Devmode")]
	[SerializeField]
	private bool m_Logging; // 0x18
	[SerializeField]
	[Tooltip("Automatic Performance Mode")]
	private bool m_AutomaticPerformanceModeEnabled; // 0x19
	[Tooltip("Automatic Game Mode")]
	[SerializeField]
	private bool m_AutomaticGameModeEnabled; // 0x1A
	[SerializeField]
	[Tooltip("Enables the CPU and GPU boost mode before engine startup to decrease startup time.")]
	private bool m_EnableBoostOnStartup; // 0x1B
	[SerializeField]
	[Tooltip("Logging Frequency (Development mode only)")]
	private int m_StatsLoggingFrequencyInFrames; // 0x1C
	[Tooltip("Indexer Settings")]
	[SerializeField]
	private AdaptivePerformanceIndexerSettings m_IndexerSettings; // 0x20
	[SerializeField]
	[Tooltip("Scaler Settings")]
	private AdaptivePerformanceScalerSettings m_ScalerSettings; // 0x28
	[SerializeField]
	private AdaptivePerformanceScalerProfile[] m_scalerProfileList; // 0x30
	[SerializeField]
	internal int m_DefaultScalerProfilerIndex; // 0x38

	// Properties
	public bool logging { get; set; }
	public bool automaticPerformanceMode { get; set; }
	public bool automaticGameMode { get; set; }
	public bool enableBoostOnStartup { get; set; }
	public int statsLoggingFrequencyInFrames { get; set; }
	public AdaptivePerformanceIndexerSettings indexerSettings { get; set; }
	public AdaptivePerformanceScalerSettings scalerSettings { get; set; }
	public int defaultScalerProfilerIndex { get; set; }

	// Methods

	// RVA: 0x84FB268 Offset: 0x84F7268 VA: 0x84FB268
	public bool get_logging() { }

	// RVA: 0x84FB270 Offset: 0x84F7270 VA: 0x84FB270
	public void set_logging(bool value) { }

	// RVA: 0x84FB27C Offset: 0x84F727C VA: 0x84FB27C
	public bool get_automaticPerformanceMode() { }

	// RVA: 0x84FB284 Offset: 0x84F7284 VA: 0x84FB284
	public void set_automaticPerformanceMode(bool value) { }

	// RVA: 0x84FB290 Offset: 0x84F7290 VA: 0x84FB290
	public bool get_automaticGameMode() { }

	// RVA: 0x84FB298 Offset: 0x84F7298 VA: 0x84FB298
	public void set_automaticGameMode(bool value) { }

	// RVA: 0x84FB2A4 Offset: 0x84F72A4 VA: 0x84FB2A4
	public bool get_enableBoostOnStartup() { }

	// RVA: 0x84FB2AC Offset: 0x84F72AC VA: 0x84FB2AC
	public void set_enableBoostOnStartup(bool value) { }

	// RVA: 0x84FB2B8 Offset: 0x84F72B8 VA: 0x84FB2B8
	public int get_statsLoggingFrequencyInFrames() { }

	// RVA: 0x84FB2C0 Offset: 0x84F72C0 VA: 0x84FB2C0
	public void set_statsLoggingFrequencyInFrames(int value) { }

	// RVA: 0x84FB2C8 Offset: 0x84F72C8 VA: 0x84FB2C8
	public AdaptivePerformanceIndexerSettings get_indexerSettings() { }

	// RVA: 0x84FB2D0 Offset: 0x84F72D0 VA: 0x84FB2D0
	public void set_indexerSettings(AdaptivePerformanceIndexerSettings value) { }

	// RVA: 0x84FB2D8 Offset: 0x84F72D8 VA: 0x84FB2D8
	public AdaptivePerformanceScalerSettings get_scalerSettings() { }

	// RVA: 0x84FB2E0 Offset: 0x84F72E0 VA: 0x84FB2E0
	public void set_scalerSettings(AdaptivePerformanceScalerSettings value) { }

	// RVA: 0x84EFE34 Offset: 0x84EBE34 VA: 0x84EFE34
	public void LoadScalerProfile(string scalerProfileName) { }

	// RVA: 0x84FB2E8 Offset: 0x84F72E8 VA: 0x84FB2E8
	private bool ApplyScalerProfileToAllScalers() { }

	// RVA: 0x84EFD64 Offset: 0x84EBD64 VA: 0x84EFD64
	public string[] GetAvailableScalerProfiles() { }

	// RVA: 0x84FB8F0 Offset: 0x84F78F0 VA: 0x84FB8F0
	public int get_defaultScalerProfilerIndex() { }

	// RVA: 0x84FB8F8 Offset: 0x84F78F8 VA: 0x84FB8F8
	public void set_defaultScalerProfilerIndex(int value) { }

	// RVA: 0x84FB900 Offset: 0x84F7900 VA: 0x84FB900
	public void OnEnable() { }

	// RVA: 0x84FB904 Offset: 0x84F7904 VA: 0x84FB904
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance
public class AdaptiveBatching : AdaptivePerformanceScaler // TypeDefIndex: 26845
{
	// Fields
	private bool m_DefaultState; // 0x40

	// Methods

	// RVA: 0x84FBA60 Offset: 0x84F7A60 VA: 0x84FBA60 Slot: 20
	protected override void Awake() { }

	// RVA: 0x84FBAFC Offset: 0x84F7AFC VA: 0x84FBAFC Slot: 25
	protected override void OnDisabled() { }

	// RVA: 0x84FBB8C Offset: 0x84F7B8C VA: 0x84FBB8C Slot: 24
	protected override void OnEnabled() { }

	// RVA: 0x84FBC1C Offset: 0x84F7C1C VA: 0x84FBC1C Slot: 23
	protected override void OnLevel() { }

	// RVA: 0x84FBCDC Offset: 0x84F7CDC VA: 0x84FBCDC
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance
public class AdaptiveDecals : AdaptivePerformanceScaler // TypeDefIndex: 26846
{
	// Fields
	private float m_DefaultDecalsDistance; // 0x40

	// Methods

	// RVA: 0x84FBCE0 Offset: 0x84F7CE0 VA: 0x84FBCE0 Slot: 20
	protected override void Awake() { }

	// RVA: 0x84FBD7C Offset: 0x84F7D7C VA: 0x84FBD7C Slot: 25
	protected override void OnDisabled() { }

	// RVA: 0x84FBE14 Offset: 0x84F7E14 VA: 0x84FBE14 Slot: 24
	protected override void OnEnabled() { }

	// RVA: 0x84FBEA4 Offset: 0x84F7EA4 VA: 0x84FBEA4 Slot: 23
	protected override void OnLevel() { }

	// RVA: 0x84FBF80 Offset: 0x84F7F80 VA: 0x84FBF80
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance
public class AdaptiveFramerate : AdaptivePerformanceScaler // TypeDefIndex: 26847
{
	// Fields
	private int m_DefaultFPS; // 0x40
	private int m_FirstTimeStart; // 0x44

	// Methods

	// RVA: 0x84FBF84 Offset: 0x84F7F84 VA: 0x84FBF84 Slot: 20
	protected override void Awake() { }

	// RVA: 0x84FC024 Offset: 0x84F8024 VA: 0x84FC024 Slot: 25
	protected override void OnDisabled() { }

	// RVA: 0x84FC0A0 Offset: 0x84F80A0 VA: 0x84FC0A0 Slot: 24
	protected override void OnEnabled() { }

	// RVA: 0x84FC144 Offset: 0x84F8144 VA: 0x84FC144 Slot: 21
	protected override void OnLevelIncrease() { }

	// RVA: 0x84FC2D0 Offset: 0x84F82D0 VA: 0x84FC2D0 Slot: 22
	protected override void OnLevelDecrease() { }

	// RVA: 0x84FC398 Offset: 0x84F8398 VA: 0x84FC398
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance
public class AdaptiveLayerCulling : AdaptivePerformanceScaler // TypeDefIndex: 26848
{
	// Fields
	private float[] m_defaultDistances; // 0x40
	private float[] m_scaledDistances; // 0x48
	private bool init; // 0x50
	private Camera m_cachedCamera; // 0x58

	// Methods

	// RVA: 0x84FC39C Offset: 0x84F839C VA: 0x84FC39C Slot: 20
	protected override void Awake() { }

	// RVA: 0x84FC438 Offset: 0x84F8438 VA: 0x84FC438 Slot: 25
	protected override void OnDisabled() { }

	// RVA: 0x84FC4D8 Offset: 0x84F84D8 VA: 0x84FC4D8 Slot: 24
	protected override void OnEnabled() { }

	// RVA: 0x84FC610 Offset: 0x84F8610 VA: 0x84FC610 Slot: 23
	protected override void OnLevel() { }

	// RVA: 0x84FC4DC Offset: 0x84F84DC VA: 0x84FC4DC
	private void AsignDefaultValues() { }

	// RVA: 0x84FC734 Offset: 0x84F8734 VA: 0x84FC734
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance
public class AdaptiveLOD : AdaptivePerformanceScaler // TypeDefIndex: 26849
{
	// Fields
	private float m_DefaultLodBias; // 0x40

	// Methods

	// RVA: 0x84FC7B0 Offset: 0x84F87B0 VA: 0x84FC7B0 Slot: 20
	protected override void Awake() { }

	// RVA: 0x84FC84C Offset: 0x84F884C VA: 0x84FC84C Slot: 25
	protected override void OnDisabled() { }

	// RVA: 0x84FC858 Offset: 0x84F8858 VA: 0x84FC858 Slot: 24
	protected override void OnEnabled() { }

	// RVA: 0x84FC874 Offset: 0x84F8874 VA: 0x84FC874 Slot: 23
	protected override void OnLevel() { }

	// RVA: 0x84FC8BC Offset: 0x84F88BC VA: 0x84FC8BC
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance
public class AdaptiveLut : AdaptivePerformanceScaler // TypeDefIndex: 26850
{
	// Fields
	private float m_DefaultLutBias; // 0x40

	// Methods

	// RVA: 0x84FC8C0 Offset: 0x84F88C0 VA: 0x84FC8C0 Slot: 20
	protected override void Awake() { }

	// RVA: 0x84FC95C Offset: 0x84F895C VA: 0x84FC95C Slot: 25
	protected override void OnDisabled() { }

	// RVA: 0x84FC9F4 Offset: 0x84F89F4 VA: 0x84FC9F4 Slot: 24
	protected override void OnEnabled() { }

	// RVA: 0x84FCA84 Offset: 0x84F8A84 VA: 0x84FCA84 Slot: 23
	protected override void OnLevel() { }

	// RVA: 0x84FCB38 Offset: 0x84F8B38 VA: 0x84FCB38
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance
public class AdaptiveMSAA : AdaptivePerformanceScaler // TypeDefIndex: 26851
{
	// Fields
	private int m_DefaultAA; // 0x40

	// Methods

	// RVA: 0x84FCB3C Offset: 0x84F8B3C VA: 0x84FCB3C Slot: 20
	protected override void Awake() { }

	// RVA: 0x84FCBD8 Offset: 0x84F8BD8 VA: 0x84FCBD8 Slot: 25
	protected override void OnDisabled() { }

	// RVA: 0x84FCC68 Offset: 0x84F8C68 VA: 0x84FCC68 Slot: 24
	protected override void OnEnabled() { }

	// RVA: 0x84FCCF8 Offset: 0x84F8CF8 VA: 0x84FCCF8 Slot: 23
	protected override void OnLevel() { }

	// RVA: 0x84FCDC8 Offset: 0x84F8DC8 VA: 0x84FCDC8
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance
public class AdaptivePhysics : AdaptivePerformanceScaler // TypeDefIndex: 26852
{
	// Fields
	private float m_fixedDeltaTimeDefault; // 0x40

	// Methods

	// RVA: 0x84FCDCC Offset: 0x84F8DCC VA: 0x84FCDCC Slot: 20
	protected override void Awake() { }

	// RVA: 0x84FCE68 Offset: 0x84F8E68 VA: 0x84FCE68 Slot: 25
	protected override void OnDisabled() { }

	// RVA: 0x84FCE74 Offset: 0x84F8E74 VA: 0x84FCE74 Slot: 24
	protected override void OnEnabled() { }

	// RVA: 0x84FCE90 Offset: 0x84F8E90 VA: 0x84FCE90 Slot: 23
	protected override void OnLevel() { }

	// RVA: 0x84FCED8 Offset: 0x84F8ED8 VA: 0x84FCED8
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance
public class AdaptiveResolution : AdaptivePerformanceScaler // TypeDefIndex: 26853
{
	// Fields
	private static int instanceCount; // 0x0

	// Methods

	// RVA: 0x84FCEDC Offset: 0x84F8EDC VA: 0x84FCEDC Slot: 20
	protected override void Awake() { }

	// RVA: 0x84FCF78 Offset: 0x84F8F78 VA: 0x84FCF78 Slot: 25
	protected override void OnDisabled() { }

	// RVA: 0x84FD048 Offset: 0x84F9048 VA: 0x84FD048 Slot: 24
	protected override void OnEnabled() { }

	// RVA: 0x84FD04C Offset: 0x84F904C VA: 0x84FD04C
	private void OnValidate() { }

	// RVA: 0x84FD11C Offset: 0x84F911C VA: 0x84FD11C
	private bool IsDynamicResolutionSupported() { }

	// RVA: 0x84FD138 Offset: 0x84F9138 VA: 0x84FD138
	private void Start() { }

	// RVA: 0x84FCF7C Offset: 0x84F8F7C VA: 0x84FCF7C
	private void OnDestroy() { }

	// RVA: 0x84FD294 Offset: 0x84F9294 VA: 0x84FD294 Slot: 23
	protected override void OnLevel() { }

	// RVA: 0x84FD3AC Offset: 0x84F93AC VA: 0x84FD3AC
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance
public class AdaptiveShadowCascade : AdaptivePerformanceScaler // TypeDefIndex: 26854
{
	// Fields
	private int m_DefaultCascadeCount; // 0x40

	// Methods

	// RVA: 0x84FD3B0 Offset: 0x84F93B0 VA: 0x84FD3B0 Slot: 20
	protected override void Awake() { }

	// RVA: 0x84FD44C Offset: 0x84F944C VA: 0x84FD44C Slot: 25
	protected override void OnDisabled() { }

	// RVA: 0x84FD4DC Offset: 0x84F94DC VA: 0x84FD4DC Slot: 24
	protected override void OnEnabled() { }

	// RVA: 0x84FD56C Offset: 0x84F956C VA: 0x84FD56C Slot: 23
	protected override void OnLevel() { }

	// RVA: 0x84FD63C Offset: 0x84F963C VA: 0x84FD63C
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance
public class AdaptiveShadowDistance : AdaptivePerformanceScaler // TypeDefIndex: 26855
{
	// Fields
	private float m_DefaultShadowDistance; // 0x40

	// Methods

	// RVA: 0x84FD640 Offset: 0x84F9640 VA: 0x84FD640 Slot: 20
	protected override void Awake() { }

	// RVA: 0x84FD6DC Offset: 0x84F96DC VA: 0x84FD6DC Slot: 25
	protected override void OnDisabled() { }

	// RVA: 0x84FD73C Offset: 0x84F973C VA: 0x84FD73C Slot: 24
	protected override void OnEnabled() { }

	// RVA: 0x84FD7CC Offset: 0x84F97CC VA: 0x84FD7CC Slot: 23
	protected override void OnLevel() { }

	// RVA: 0x84FD858 Offset: 0x84F9858 VA: 0x84FD858
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance
public class AdaptiveShadowmapResolution : AdaptivePerformanceScaler // TypeDefIndex: 26856
{
	// Fields
	private float m_DefaultShadowmapResolution; // 0x40

	// Methods

	// RVA: 0x84FD85C Offset: 0x84F985C VA: 0x84FD85C Slot: 20
	protected override void Awake() { }

	// RVA: 0x84FD8F8 Offset: 0x84F98F8 VA: 0x84FD8F8 Slot: 25
	protected override void OnDisabled() { }

	// RVA: 0x84FD958 Offset: 0x84F9958 VA: 0x84FD958 Slot: 24
	protected override void OnEnabled() { }

	// RVA: 0x84FD9E8 Offset: 0x84F99E8 VA: 0x84FD9E8 Slot: 23
	protected override void OnLevel() { }

	// RVA: 0x84FDA74 Offset: 0x84F9A74 VA: 0x84FDA74
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance
public class AdaptiveShadowQuality : AdaptivePerformanceScaler // TypeDefIndex: 26857
{
	// Fields
	private int m_DefaultShadowQualityBias; // 0x40

	// Methods

	// RVA: 0x84FDA78 Offset: 0x84F9A78 VA: 0x84FDA78 Slot: 20
	protected override void Awake() { }

	// RVA: 0x84FDB14 Offset: 0x84F9B14 VA: 0x84FDB14 Slot: 25
	protected override void OnDisabled() { }

	// RVA: 0x84FDBA4 Offset: 0x84F9BA4 VA: 0x84FDBA4 Slot: 24
	protected override void OnEnabled() { }

	// RVA: 0x84FDC34 Offset: 0x84F9C34 VA: 0x84FDC34 Slot: 23
	protected override void OnLevel() { }

	// RVA: 0x84FDD0C Offset: 0x84F9D0C VA: 0x84FDD0C
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance
public class AdaptiveSorting : AdaptivePerformanceScaler // TypeDefIndex: 26858
{
	// Fields
	private bool m_DefaultSorting; // 0x40

	// Methods

	// RVA: 0x84FDD10 Offset: 0x84F9D10 VA: 0x84FDD10 Slot: 20
	protected override void Awake() { }

	// RVA: 0x84FDDAC Offset: 0x84F9DAC VA: 0x84FDDAC Slot: 25
	protected override void OnDisabled() { }

	// RVA: 0x84FDE3C Offset: 0x84F9E3C VA: 0x84FDE3C Slot: 24
	protected override void OnEnabled() { }

	// RVA: 0x84FDECC Offset: 0x84F9ECC VA: 0x84FDECC Slot: 23
	protected override void OnLevel() { }

	// RVA: 0x84FDF8C Offset: 0x84F9F8C VA: 0x84FDF8C
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance
public class AdaptiveTransparency : AdaptivePerformanceScaler // TypeDefIndex: 26859
{
	// Methods

	// RVA: 0x84FDF90 Offset: 0x84F9F90 VA: 0x84FDF90 Slot: 20
	protected override void Awake() { }

	// RVA: 0x84FE02C Offset: 0x84FA02C VA: 0x84FE02C Slot: 25
	protected override void OnDisabled() { }

	// RVA: 0x84FE030 Offset: 0x84FA030 VA: 0x84FE030
	private void OnDestroy() { }

	// RVA: 0x84FE0B8 Offset: 0x84FA0B8 VA: 0x84FE0B8 Slot: 23
	protected override void OnLevel() { }

	// RVA: 0x84FE178 Offset: 0x84FA178 VA: 0x84FE178
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance
public class AdaptiveViewDistance : AdaptivePerformanceScaler // TypeDefIndex: 26860
{
	// Fields
	private float m_DefaultFarClipPlane; // 0x40

	// Methods

	// RVA: 0x84FE17C Offset: 0x84FA17C VA: 0x84FE17C Slot: 20
	protected override void Awake() { }

	// RVA: 0x84FE218 Offset: 0x84FA218 VA: 0x84FE218 Slot: 25
	protected override void OnDisabled() { }

	// RVA: 0x84FE2BC Offset: 0x84FA2BC VA: 0x84FE2BC Slot: 24
	protected override void OnEnabled() { }

	// RVA: 0x84FE348 Offset: 0x84FA348 VA: 0x84FE348 Slot: 23
	protected override void OnLevel() { }

	// RVA: 0x84FE424 Offset: 0x84FA424 VA: 0x84FE424
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance.Provider
[Flags]
public enum Feature // TypeDefIndex: 26861
{
	// Fields
	public int value__; // 0x0
	public const Feature None = 0;
	public const Feature WarningLevel = 1;
	public const Feature TemperatureLevel = 2;
	public const Feature TemperatureTrend = 4;
	public const Feature CpuPerformanceLevel = 8;
	public const Feature GpuPerformanceLevel = 16;
	public const Feature PerformanceLevelControl = 32;
	public const Feature GpuFrameTime = 64;
	public const Feature CpuFrameTime = 128;
	public const Feature OverallFrameTime = 256;
	public const Feature CpuPerformanceBoost = 512;
	public const Feature GpuPerformanceBoost = 1024;
	public const Feature ClusterInfo = 2048;
	public const Feature PerformanceMode = 4096;
}

// Namespace: UnityEngine.AdaptivePerformance.Provider
public struct PerformanceDataRecord // TypeDefIndex: 26862
{
	// Fields
	[CompilerGenerated]
	private Feature <ChangeFlags>k__BackingField; // 0x0
	[CompilerGenerated]
	private float <TemperatureLevel>k__BackingField; // 0x4
	[CompilerGenerated]
	private float <TemperatureTrend>k__BackingField; // 0x8
	[CompilerGenerated]
	private WarningLevel <WarningLevel>k__BackingField; // 0xC
	[CompilerGenerated]
	private int <CpuPerformanceLevel>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <GpuPerformanceLevel>k__BackingField; // 0x14
	[CompilerGenerated]
	private bool <PerformanceLevelControlAvailable>k__BackingField; // 0x18
	[CompilerGenerated]
	private float <CpuFrameTime>k__BackingField; // 0x1C
	[CompilerGenerated]
	private float <GpuFrameTime>k__BackingField; // 0x20
	[CompilerGenerated]
	private float <OverallFrameTime>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <CpuPerformanceBoost>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <GpuPerformanceBoost>k__BackingField; // 0x29
	[CompilerGenerated]
	private ClusterInfo <ClusterInfo>k__BackingField; // 0x2C
	[CompilerGenerated]
	private PerformanceMode <PerformanceMode>k__BackingField; // 0x38

	// Properties
	public Feature ChangeFlags { get; set; }
	public float TemperatureLevel { get; set; }
	public float TemperatureTrend { get; set; }
	public WarningLevel WarningLevel { get; set; }
	public int CpuPerformanceLevel { get; set; }
	public int GpuPerformanceLevel { get; set; }
	public bool PerformanceLevelControlAvailable { get; set; }
	public float CpuFrameTime { get; set; }
	public float GpuFrameTime { get; set; }
	public float OverallFrameTime { get; set; }
	public bool CpuPerformanceBoost { get; set; }
	public bool GpuPerformanceBoost { get; set; }
	public ClusterInfo ClusterInfo { get; set; }
	public PerformanceMode PerformanceMode { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x84FE430 Offset: 0x84FA430 VA: 0x84FE430
	public Feature get_ChangeFlags() { }

	[CompilerGenerated]
	// RVA: 0x84FE438 Offset: 0x84FA438 VA: 0x84FE438
	public void set_ChangeFlags(Feature value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x84FE440 Offset: 0x84FA440 VA: 0x84FE440
	public float get_TemperatureLevel() { }

	[CompilerGenerated]
	// RVA: 0x84FE448 Offset: 0x84FA448 VA: 0x84FE448
	public void set_TemperatureLevel(float value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x84FE450 Offset: 0x84FA450 VA: 0x84FE450
	public float get_TemperatureTrend() { }

	[CompilerGenerated]
	// RVA: 0x84FE458 Offset: 0x84FA458 VA: 0x84FE458
	public void set_TemperatureTrend(float value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x84FE460 Offset: 0x84FA460 VA: 0x84FE460
	public WarningLevel get_WarningLevel() { }

	[CompilerGenerated]
	// RVA: 0x84FE468 Offset: 0x84FA468 VA: 0x84FE468
	public void set_WarningLevel(WarningLevel value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x84FE470 Offset: 0x84FA470 VA: 0x84FE470
	public int get_CpuPerformanceLevel() { }

	[CompilerGenerated]
	// RVA: 0x84FE478 Offset: 0x84FA478 VA: 0x84FE478
	public void set_CpuPerformanceLevel(int value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x84FE480 Offset: 0x84FA480 VA: 0x84FE480
	public int get_GpuPerformanceLevel() { }

	[CompilerGenerated]
	// RVA: 0x84FE488 Offset: 0x84FA488 VA: 0x84FE488
	public void set_GpuPerformanceLevel(int value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x84FE490 Offset: 0x84FA490 VA: 0x84FE490
	public bool get_PerformanceLevelControlAvailable() { }

	[CompilerGenerated]
	// RVA: 0x84FE498 Offset: 0x84FA498 VA: 0x84FE498
	public void set_PerformanceLevelControlAvailable(bool value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x84FE4A4 Offset: 0x84FA4A4 VA: 0x84FE4A4
	public float get_CpuFrameTime() { }

	[CompilerGenerated]
	// RVA: 0x84FE4AC Offset: 0x84FA4AC VA: 0x84FE4AC
	public void set_CpuFrameTime(float value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x84FE4B4 Offset: 0x84FA4B4 VA: 0x84FE4B4
	public float get_GpuFrameTime() { }

	[CompilerGenerated]
	// RVA: 0x84FE4BC Offset: 0x84FA4BC VA: 0x84FE4BC
	public void set_GpuFrameTime(float value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x84FE4C4 Offset: 0x84FA4C4 VA: 0x84FE4C4
	public float get_OverallFrameTime() { }

	[CompilerGenerated]
	// RVA: 0x84FE4CC Offset: 0x84FA4CC VA: 0x84FE4CC
	public void set_OverallFrameTime(float value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x84FE4D4 Offset: 0x84FA4D4 VA: 0x84FE4D4
	public bool get_CpuPerformanceBoost() { }

	[CompilerGenerated]
	// RVA: 0x84FE4DC Offset: 0x84FA4DC VA: 0x84FE4DC
	public void set_CpuPerformanceBoost(bool value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x84FE4E8 Offset: 0x84FA4E8 VA: 0x84FE4E8
	public bool get_GpuPerformanceBoost() { }

	[CompilerGenerated]
	// RVA: 0x84FE4F0 Offset: 0x84FA4F0 VA: 0x84FE4F0
	public void set_GpuPerformanceBoost(bool value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x84FE4FC Offset: 0x84FA4FC VA: 0x84FE4FC
	public ClusterInfo get_ClusterInfo() { }

	[CompilerGenerated]
	// RVA: 0x84FE50C Offset: 0x84FA50C VA: 0x84FE50C
	public void set_ClusterInfo(ClusterInfo value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x84FE518 Offset: 0x84FA518 VA: 0x84FE518
	public PerformanceMode get_PerformanceMode() { }

	[CompilerGenerated]
	// RVA: 0x84FE520 Offset: 0x84FA520 VA: 0x84FE520
	public void set_PerformanceMode(PerformanceMode value) { }
}

// Namespace: UnityEngine.AdaptivePerformance.Provider
public interface IApplicationLifecycle // TypeDefIndex: 26863
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ApplicationPause();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ApplicationResume();
}

// Namespace: UnityEngine.AdaptivePerformance.Provider
public interface IDevicePerformanceLevelControl // TypeDefIndex: 26864
{
	// Properties
	public abstract int MaxCpuPerformanceLevel { get; }
	public abstract int MaxGpuPerformanceLevel { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_MaxCpuPerformanceLevel();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_MaxGpuPerformanceLevel();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool SetPerformanceLevel(ref int cpu, ref int gpu);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool EnableCpuBoost();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool EnableGpuBoost();
}

// Namespace: UnityEngine.AdaptivePerformance.Provider
public abstract class AdaptivePerformanceSubsystemBase<TSubsystem, TSubsystemDescriptor, TProvider> : SubsystemWithProvider<TSubsystem, TSubsystemDescriptor, TProvider> // TypeDefIndex: 26865
{
	// Properties
	public abstract Feature Capabilities { get; set; }
	public abstract IApplicationLifecycle ApplicationLifecycle { get; }
	public abstract IDevicePerformanceLevelControl PerformanceLevelControl { get; }
	public abstract Version Version { get; }
	public abstract string Stats { get; }
	public abstract bool Initialized { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 14
	public abstract Feature get_Capabilities();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AdaptivePerformanceSubsystemBase<object, object, object>.get_Capabilities
	*/

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void set_Capabilities(Feature value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AdaptivePerformanceSubsystemBase<object, object, object>.set_Capabilities
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public abstract PerformanceDataRecord Update();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AdaptivePerformanceSubsystemBase<object, object, object>.Update
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public abstract IApplicationLifecycle get_ApplicationLifecycle();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AdaptivePerformanceSubsystemBase<object, object, object>.get_ApplicationLifecycle
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public abstract IDevicePerformanceLevelControl get_PerformanceLevelControl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AdaptivePerformanceSubsystemBase<object, object, object>.get_PerformanceLevelControl
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public abstract Version get_Version();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AdaptivePerformanceSubsystemBase<object, object, object>.get_Version
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public abstract string get_Stats();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AdaptivePerformanceSubsystemBase<object, object, object>.get_Stats
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public abstract bool get_Initialized();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AdaptivePerformanceSubsystemBase<object, object, object>.get_Initialized
	*/

	// RVA: -1 Offset: -1 Slot: 22
	protected abstract void set_Initialized(bool value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AdaptivePerformanceSubsystemBase<object, object, object>.set_Initialized
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6126BFC Offset: 0x6122BFC VA: 0x6126BFC
	|-AdaptivePerformanceSubsystemBase<object, object, object>..ctor
	*/
}

// Namespace: 
public abstract class AdaptivePerformanceSubsystem.APProvider : SubsystemProvider<AdaptivePerformanceSubsystem> // TypeDefIndex: 26866
{
	// Fields
	protected bool m_Running; // 0x11

	// Properties
	public abstract Feature Capabilities { get; set; }
	public abstract IApplicationLifecycle ApplicationLifecycle { get; }
	public abstract IDevicePerformanceLevelControl PerformanceLevelControl { get; }
	public abstract Version Version { get; }
	public virtual string Stats { get; }
	public abstract bool Initialized { get; set; }
	public bool running { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	public abstract Feature get_Capabilities();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void set_Capabilities(Feature value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract PerformanceDataRecord Update();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract IApplicationLifecycle get_ApplicationLifecycle();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract IDevicePerformanceLevelControl get_PerformanceLevelControl();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract Version get_Version();

	// RVA: 0x84FE868 Offset: 0x84FA868 VA: 0x84FE868 Slot: 14
	public virtual string get_Stats() { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract bool get_Initialized();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void set_Initialized(bool value);

	// RVA: 0x84FE8A8 Offset: 0x84FA8A8 VA: 0x84FE8A8
	public bool get_running() { }

	// RVA: 0x84FE8B0 Offset: 0x84FA8B0 VA: 0x84FE8B0
	protected void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance.Provider
public class AdaptivePerformanceSubsystem : AdaptivePerformanceSubsystemBase<AdaptivePerformanceSubsystem, AdaptivePerformanceSubsystemDescriptor, AdaptivePerformanceSubsystem.APProvider> // TypeDefIndex: 26867
{
	// Properties
	public override IApplicationLifecycle ApplicationLifecycle { get; }
	public override IDevicePerformanceLevelControl PerformanceLevelControl { get; }
	public override Version Version { get; }
	public override Feature Capabilities { get; set; }
	public override string Stats { get; }
	public override bool Initialized { get; set; }

	// Methods

	// RVA: 0x84FE528 Offset: 0x84FA528 VA: 0x84FE528
	public void .ctor() { }

	// RVA: 0x84FE570 Offset: 0x84FA570 VA: 0x84FE570 Slot: 17
	public override IApplicationLifecycle get_ApplicationLifecycle() { }

	// RVA: 0x84FE5BC Offset: 0x84FA5BC VA: 0x84FE5BC Slot: 18
	public override IDevicePerformanceLevelControl get_PerformanceLevelControl() { }

	// RVA: 0x84FE608 Offset: 0x84FA608 VA: 0x84FE608 Slot: 19
	public override Version get_Version() { }

	// RVA: 0x84FE658 Offset: 0x84FA658 VA: 0x84FE658 Slot: 14
	public override Feature get_Capabilities() { }

	// RVA: 0x84FE6A4 Offset: 0x84FA6A4 VA: 0x84FE6A4 Slot: 15
	protected override void set_Capabilities(Feature value) { }

	// RVA: 0x84FE6F8 Offset: 0x84FA6F8 VA: 0x84FE6F8 Slot: 20
	public override string get_Stats() { }

	// RVA: 0x84FE748 Offset: 0x84FA748 VA: 0x84FE748 Slot: 21
	public override bool get_Initialized() { }

	// RVA: 0x84FE798 Offset: 0x84FA798 VA: 0x84FE798 Slot: 22
	protected override void set_Initialized(bool value) { }

	// RVA: 0x84FE7F0 Offset: 0x84FA7F0 VA: 0x84FE7F0 Slot: 16
	public override PerformanceDataRecord Update() { }
}

// Namespace: UnityEngine.AdaptivePerformance.Provider
[Preserve]
internal static class AdaptivePerformanceSubsystemRegistry // TypeDefIndex: 26868
{
	// Methods

	// RVA: 0x84FE8F8 Offset: 0x84FA8F8 VA: 0x84FE8F8
	public static AdaptivePerformanceSubsystemDescriptor RegisterDescriptor(AdaptivePerformanceSubsystemDescriptor.Cinfo cinfo) { }

	// RVA: 0x84FEA1C Offset: 0x84FAA1C VA: 0x84FEA1C
	public static List<AdaptivePerformanceSubsystemDescriptor> GetRegisteredDescriptors() { }
}

// Namespace: 
public struct AdaptivePerformanceSubsystemDescriptor.Cinfo // TypeDefIndex: 26869
{
	// Fields
	[CompilerGenerated]
	private string <id>k__BackingField; // 0x0
	[CompilerGenerated]
	private Type <providerType>k__BackingField; // 0x8
	[CompilerGenerated]
	private Type <subsystemTypeOverride>k__BackingField; // 0x10
	[CompilerGenerated]
	private Type <subsystemImplementationType>k__BackingField; // 0x18

	// Properties
	public string id { get; set; }
	public Type providerType { get; set; }
	public Type subsystemTypeOverride { get; set; }
	[Obsolete("AdaptivePerformanceSubsystem no longer supports the deprecated set of base classes for subsystems as of Unity 2023.1. Use providerType and, optionally, subsystemTypeOverride instead.", True)]
	public Type subsystemImplementationType { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x84FEAF4 Offset: 0x84FAAF4 VA: 0x84FEAF4
	public string get_id() { }

	[CompilerGenerated]
	// RVA: 0x84FEAFC Offset: 0x84FAAFC VA: 0x84FEAFC
	public void set_id(string value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x84FEB04 Offset: 0x84FAB04 VA: 0x84FEB04
	public Type get_providerType() { }

	[CompilerGenerated]
	// RVA: 0x84FEB0C Offset: 0x84FAB0C VA: 0x84FEB0C
	public void set_providerType(Type value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x84FEB14 Offset: 0x84FAB14 VA: 0x84FEB14
	public Type get_subsystemTypeOverride() { }

	[CompilerGenerated]
	// RVA: 0x84FEB1C Offset: 0x84FAB1C VA: 0x84FEB1C
	public void set_subsystemTypeOverride(Type value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x84FEB24 Offset: 0x84FAB24 VA: 0x84FEB24
	public Type get_subsystemImplementationType() { }

	[CompilerGenerated]
	// RVA: 0x84FEB2C Offset: 0x84FAB2C VA: 0x84FEB2C
	public void set_subsystemImplementationType(Type value) { }
}

// Namespace: UnityEngine.AdaptivePerformance.Provider
[Preserve]
public sealed class AdaptivePerformanceSubsystemDescriptor : SubsystemDescriptorWithProvider<AdaptivePerformanceSubsystem, AdaptivePerformanceSubsystem.APProvider> // TypeDefIndex: 26870
{
	// Methods

	// RVA: 0x84FE998 Offset: 0x84FA998 VA: 0x84FE998
	public void .ctor(AdaptivePerformanceSubsystemDescriptor.Cinfo cinfo) { }

	// RVA: 0x84FEAD0 Offset: 0x84FAAD0 VA: 0x84FEAD0
	public static AdaptivePerformanceSubsystemDescriptor RegisterDescriptor(AdaptivePerformanceSubsystemDescriptor.Cinfo cinfo) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4547 // TypeDefIndex: 26871
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4878 // TypeDefIndex: 26872
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 26873
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4878 4F85D30027B2B8870D62FB0A4CD2B106B6B91E931908B87C1E38AAF1299DA300 /*Metadata offset 0xF47F90*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4547 A115FA2A351B6342D7AAD79039460AB39DD38DF2020C520F110B4D093173F223 /*Metadata offset 0xF492A0*/; // 0x130E
}

