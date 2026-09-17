// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28694
{}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 28695
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
[EditorBrowsable(1)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 28696
{
	// Methods

	// RVA: 0x84FEB34 Offset: 0x84FAB34 VA: 0x84FEB34
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x84FEC2C Offset: 0x84FAC2C VA: 0x84FEC2C
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance.Google.Android
internal static class ADPFLog // TypeDefIndex: 28697
{
	// Fields
	private static GoogleAndroidProviderSettings settings; // 0x0

	// Methods

	[Conditional("DEVELOPMENT_BUILD")]
	// RVA: 0x84FEC34 Offset: 0x84FAC34 VA: 0x84FEC34
	public static void Debug(string format, object[] args) { }

	// RVA: 0x84FED78 Offset: 0x84FAD78 VA: 0x84FED78
	private static void .cctor() { }
}

// Namespace: 
internal class GoogleAndroidAdaptivePerformanceSubsystem.GoogleAndroidAdaptivePerformanceSubsystemProvider.NativeApi // TypeDefIndex: 28698
{
	// Fields
	private const int k_TemperatureWarningLevelErrorOrUnknown = -1;
	private const int k_TemperatureWarningLevelNoWarning = 0;
	private const int k_TemperatureWarningLevelThrottlingImminent = 1;
	private const int k_TemperatureWarningLevelThrottling = 2;
	private static Action<WarningLevel> s_PerformanceWarningEvent; // 0x0
	private static Action<int> s_OnHighTempWarningHandler; // 0x8
	private readonly IntPtr m_OnHighTempWarningHandlerFuncPtr; // 0x10
	private static int m_ApiLevel; // 0x10
	private int m_HintSessionCommon; // 0x18
	private int m_HintSessionCPU; // 0x1C
	private long m_ReportedDurationCommon; // 0x20
	private long m_ReportedDurationCPU; // 0x28
	private bool m_HintMultithreaded; // 0x30
	private FrameTiming[] m_FrameTimings; // 0x38

	// Methods

	// RVA: 0x84FF0C0 Offset: 0x84FB0C0 VA: 0x84FF0C0
	public void .ctor(Action<WarningLevel> sustainedPerformanceWarning) { }

	[Preserve]
	[MonoPInvokeCallback(typeof(Action<int>))]
	// RVA: 0x850074C Offset: 0x84FC74C VA: 0x850074C
	private static void OnHighTempWarning(int warningLevel) { }

	// RVA: 0x84FF9C8 Offset: 0x84FB9C8 VA: 0x84FF9C8
	public static int GetApiLevel() { }

	// RVA: 0x84FEF30 Offset: 0x84FAF30 VA: 0x84FEF30
	public static bool IsAvailable() { }

	// RVA: 0x8500010 Offset: 0x84FC010 VA: 0x8500010
	public static bool IsThermalStatusValid() { }

	// RVA: 0x85008C8 Offset: 0x84FC8C8 VA: 0x85008C8
	public static extern void ThermalSetup(IntPtr _onHighTempWarning) { }

	// RVA: 0x850019C Offset: 0x84FC19C VA: 0x850019C
	public static extern void ThermalTeardown() { }

	// RVA: 0x8500860 Offset: 0x84FC860 VA: 0x8500860
	public static extern int GetLatestThermalStatus() { }

	// RVA: 0x8500944 Offset: 0x84FC944 VA: 0x8500944
	public static extern IntPtr GetThermalPluginCallback() { }

	// RVA: 0x85009AC Offset: 0x84FC9AC VA: 0x85009AC
	public static extern double GetThermalHeadroomForSeconds(int forecastSeconds) { }

	// RVA: 0x8500A28 Offset: 0x84FCA28 VA: 0x8500A28
	public static extern bool HintMultithreaded() { }

	// RVA: 0x8500A98 Offset: 0x84FCA98 VA: 0x8500A98
	public static extern int HintCreateSession(bool mainThread, bool gfxThread, long desiredDuration) { }

	// RVA: 0x8500200 Offset: 0x84FC200 VA: 0x8500200
	public static extern void HintTeardown() { }

	// RVA: 0x8500B2C Offset: 0x84FCB2C VA: 0x8500B2C
	public static extern void ReportCompletionTimes(int session, long totalDuration, long cpuDuration, long gpuDuration, long workStart) { }

	// RVA: 0x8500BD8 Offset: 0x84FCBD8 VA: 0x8500BD8
	public static extern void UpdateTargetWorkDuration(int session, long targetDuration) { }

	// RVA: 0x8500C5C Offset: 0x84FCC5C VA: 0x8500C5C
	public static extern IntPtr GetHintPluginCallback() { }

	// RVA: 0x84FFC14 Offset: 0x84FBC14 VA: 0x84FFC14
	public bool SetupThermal() { }

	// RVA: 0x8500068 Offset: 0x84FC068 VA: 0x8500068
	public double GetThermalHeadroom(int forecastInSeconds = 0) { }

	// RVA: 0x84FF640 Offset: 0x84FB640 VA: 0x84FF640
	public WarningLevel GetThermalStatusWarningLevel() { }

	// RVA: 0x8500CC4 Offset: 0x84FCCC4 VA: 0x8500CC4
	private long GetDesiredDuration() { }

	// RVA: 0x8500D54 Offset: 0x84FCD54 VA: 0x8500D54
	private long GetDesiredTotalDuration(long desiredDuration, long totalDuration) { }

	// RVA: 0x8500D78 Offset: 0x84FCD78 VA: 0x8500D78
	private long DoubleMsToNanos(double time) { }

	// RVA: 0x84FFCF8 Offset: 0x84FBCF8 VA: 0x84FFCF8
	public bool SetupHints() { }

	// RVA: 0x8500460 Offset: 0x84FC460 VA: 0x8500460
	public void UpdateHintSystem() { }

	// RVA: 0x8500DA0 Offset: 0x84FCDA0 VA: 0x8500DA0
	public bool EnableCpuBoost() { }

	// RVA: 0x8500DA8 Offset: 0x84FCDA8 VA: 0x8500DA8
	public bool EnableGpuBoost() { }

	// RVA: 0x8500DB0 Offset: 0x84FCDB0 VA: 0x8500DB0
	public int GetClusterInfo() { }

	// RVA: 0x84FFCE8 Offset: 0x84FBCE8 VA: 0x84FFCE8
	public int GetMaxCpuPerformanceLevel() { }

	// RVA: 0x84FFCF0 Offset: 0x84FBCF0 VA: 0x84FFCF0
	public int GetMaxGpuPerformanceLevel() { }

	// RVA: 0x8500DB8 Offset: 0x84FCDB8 VA: 0x8500DB8
	private static void .cctor() { }
}

// Namespace: 
public class GoogleAndroidAdaptivePerformanceSubsystem.GoogleAndroidAdaptivePerformanceSubsystemProvider : AdaptivePerformanceSubsystem.APProvider, IApplicationLifecycle, IDevicePerformanceLevelControl // TypeDefIndex: 28699
{
	// Fields
	private GoogleAndroidAdaptivePerformanceSubsystem.GoogleAndroidAdaptivePerformanceSubsystemProvider.NativeApi m_Api; // 0x18
	private PerformanceDataRecord m_Data; // 0x20
	private object m_DataLock; // 0x60
	private float m_Temperature; // 0x68
	private float m_TemperatureUpdateTimestamp; // 0x6C
	private float m_TemperatureUpdateInterval; // 0x70
	private bool m_ThermalInitialized; // 0x74
	private bool m_HintInitialized; // 0x75
	private Version m_Version; // 0x78
	private PerformanceMode m_PerformanceMode; // 0x80
	[CompilerGenerated]
	private int <MaxCpuPerformanceLevel>k__BackingField; // 0x84
	[CompilerGenerated]
	private int <MaxGpuPerformanceLevel>k__BackingField; // 0x88
	private static GoogleAndroidProviderSettings s_Settings; // 0x0
	[CompilerGenerated]
	private Feature <Capabilities>k__BackingField; // 0x8C
	[CompilerGenerated]
	private bool <Initialized>k__BackingField; // 0x90

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

	// RVA: 0x84FEF90 Offset: 0x84FAF90 VA: 0x84FEF90 Slot: 11
	public override IApplicationLifecycle get_ApplicationLifecycle() { }

	// RVA: 0x84FEF94 Offset: 0x84FAF94 VA: 0x84FEF94 Slot: 12
	public override IDevicePerformanceLevelControl get_PerformanceLevelControl() { }

	[CompilerGenerated]
	// RVA: 0x84FEF98 Offset: 0x84FAF98 VA: 0x84FEF98 Slot: 19
	public int get_MaxCpuPerformanceLevel() { }

	[CompilerGenerated]
	// RVA: 0x84FEFA0 Offset: 0x84FAFA0 VA: 0x84FEFA0
	public void set_MaxCpuPerformanceLevel(int value) { }

	[CompilerGenerated]
	// RVA: 0x84FEFA8 Offset: 0x84FAFA8 VA: 0x84FEFA8 Slot: 20
	public int get_MaxGpuPerformanceLevel() { }

	[CompilerGenerated]
	// RVA: 0x84FEFB0 Offset: 0x84FAFB0 VA: 0x84FEFB0
	public void set_MaxGpuPerformanceLevel(int value) { }

	// RVA: 0x84FEFB8 Offset: 0x84FAFB8 VA: 0x84FEFB8
	public void .ctor() { }

	// RVA: 0x84FF1D8 Offset: 0x84FB1D8 VA: 0x84FF1D8
	private void OnPerformanceWarning(WarningLevel warningLevel) { }

	// RVA: 0x84FF2A0 Offset: 0x84FB2A0 VA: 0x84FF2A0
	private void ImmediateUpdateTemperature() { }

	// RVA: 0x84FF440 Offset: 0x84FB440 VA: 0x84FF440
	private void TimedUpdateTemperature() { }

	// RVA: 0x84FF558 Offset: 0x84FB558 VA: 0x84FF558
	private void ImmediateUpdateThermalStatus() { }

	// RVA: 0x84FF6A4 Offset: 0x84FB6A4 VA: 0x84FF6A4
	private void ImmediateUpdatePerformanceMode() { }

	// RVA: 0x84FF788 Offset: 0x84FB788 VA: 0x84FF788 Slot: 4
	protected override bool TryInitialize() { }

	// RVA: 0x84FFEDC Offset: 0x84FBEDC VA: 0x84FFEDC Slot: 5
	public override void Start() { }

	// RVA: 0x85000BC Offset: 0x84FC0BC VA: 0x85000BC Slot: 6
	public override void Stop() { }

	// RVA: 0x85000C4 Offset: 0x84FC0C4 VA: 0x85000C4 Slot: 7
	public override void Destroy() { }

	// RVA: 0x8500264 Offset: 0x84FC264 VA: 0x8500264 Slot: 14
	public override string get_Stats() { }

	// RVA: 0x8500320 Offset: 0x84FC320 VA: 0x8500320 Slot: 10
	public override PerformanceDataRecord Update() { }

	// RVA: 0x8500668 Offset: 0x84FC668 VA: 0x8500668 Slot: 13
	public override Version get_Version() { }

	[CompilerGenerated]
	// RVA: 0x8500670 Offset: 0x84FC670 VA: 0x8500670 Slot: 8
	public override Feature get_Capabilities() { }

	[CompilerGenerated]
	// RVA: 0x8500678 Offset: 0x84FC678 VA: 0x8500678 Slot: 9
	public override void set_Capabilities(Feature value) { }

	[CompilerGenerated]
	// RVA: 0x8500680 Offset: 0x84FC680 VA: 0x8500680 Slot: 15
	public override bool get_Initialized() { }

	[CompilerGenerated]
	// RVA: 0x8500688 Offset: 0x84FC688 VA: 0x8500688 Slot: 16
	public override void set_Initialized(bool value) { }

	// RVA: 0x8500694 Offset: 0x84FC694 VA: 0x8500694 Slot: 21
	public bool SetPerformanceLevel(ref int cpuLevel, ref int gpuLevel) { }

	// RVA: 0x850069C Offset: 0x84FC69C VA: 0x850069C Slot: 22
	public bool EnableCpuBoost() { }

	// RVA: 0x85006A4 Offset: 0x84FC6A4 VA: 0x85006A4 Slot: 23
	public bool EnableGpuBoost() { }

	// RVA: 0x85006AC Offset: 0x84FC6AC VA: 0x85006AC Slot: 17
	public void ApplicationPause() { }

	// RVA: 0x85006B0 Offset: 0x84FC6B0 VA: 0x85006B0 Slot: 18
	public void ApplicationResume() { }

	// RVA: 0x84FF38C Offset: 0x84FB38C VA: 0x84FF38C
	private void UpdateTemperatureLevel() { }

	// RVA: 0x85006C8 Offset: 0x84FC6C8 VA: 0x85006C8
	private static void .cctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance.Google.Android
[Preserve]
public class GoogleAndroidAdaptivePerformanceSubsystem : AdaptivePerformanceSubsystem // TypeDefIndex: 28700
{
	// Methods

	[RuntimeInitializeOnLoadMethod(4)]
	// RVA: 0x84FEDFC Offset: 0x84FADFC VA: 0x84FEDFC
	private static AdaptivePerformanceSubsystemDescriptor RegisterDescriptor() { }

	// RVA: 0x84FEF88 Offset: 0x84FAF88 VA: 0x84FEF88
	public void .ctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance.Google.Android
public static class GoogleAndroidProviderConstants // TypeDefIndex: 28701
{
	// Fields
	public const string k_SettingsKey = "com.unity.adaptiveperformance.google.android.provider_settings";
}

// Namespace: UnityEngine.AdaptivePerformance.Google.Android
public class GoogleAndroidProviderLoader : AdaptivePerformanceLoaderHelper // TypeDefIndex: 28702
{
	// Fields
	private static List<AdaptivePerformanceSubsystemDescriptor> s_GoogleAndroidSubsystemDescriptors; // 0x0

	// Properties
	public override bool Initialized { get; }
	public override bool Running { get; }
	public GoogleAndroidAdaptivePerformanceSubsystem googleAndroidSubsystem { get; }

	// Methods

	// RVA: 0x8500E60 Offset: 0x84FCE60 VA: 0x8500E60 Slot: 4
	public override bool get_Initialized() { }

	// RVA: 0x8500EDC Offset: 0x84FCEDC VA: 0x8500EDC Slot: 5
	public override bool get_Running() { }

	// RVA: 0x8500E78 Offset: 0x84FCE78 VA: 0x8500E78
	public GoogleAndroidAdaptivePerformanceSubsystem get_googleAndroidSubsystem() { }

	// RVA: 0x8500F10 Offset: 0x84FCF10 VA: 0x8500F10 Slot: 11
	public override ISubsystem GetDefaultSubsystem() { }

	// RVA: 0x8500F14 Offset: 0x84FCF14 VA: 0x8500F14 Slot: 12
	public override IAdaptivePerformanceSettings GetSettings() { }

	// RVA: 0x8500F54 Offset: 0x84FCF54 VA: 0x8500F54 Slot: 6
	public override bool Initialize() { }

	// RVA: 0x8501050 Offset: 0x84FD050 VA: 0x8501050 Slot: 7
	public override bool Start() { }

	// RVA: 0x85010A0 Offset: 0x84FD0A0 VA: 0x85010A0 Slot: 8
	public override bool Stop() { }

	// RVA: 0x85010F0 Offset: 0x84FD0F0 VA: 0x85010F0 Slot: 9
	public override bool Deinitialize() { }

	// RVA: 0x8501144 Offset: 0x84FD144 VA: 0x8501144
	public void .ctor() { }

	// RVA: 0x850114C Offset: 0x84FD14C VA: 0x850114C
	private static void .cctor() { }
}

// Namespace: UnityEngine.AdaptivePerformance.Google.Android
[AdaptivePerformanceConfigurationData("Android", "com.unity.adaptiveperformance.google.android.provider_settings")]
[Serializable]
public class GoogleAndroidProviderSettings : IAdaptivePerformanceSettings // TypeDefIndex: 28703
{
	// Fields
	[SerializeField]
	[Tooltip("Enable Logging in Devmode")]
	private bool m_GoogleProviderLogging; // 0x3C
	[SerializeField]
	private bool m_FrameStatsDialogDisplayed; // 0x3D
	public static GoogleAndroidProviderSettings s_RuntimeInstance; // 0x0

	// Properties
	public bool googleProviderLogging { get; set; }
	internal bool frameStatsDialogDisplayed { get; set; }

	// Methods

	// RVA: 0x85011E4 Offset: 0x84FD1E4 VA: 0x85011E4
	public bool get_googleProviderLogging() { }

	// RVA: 0x85011EC Offset: 0x84FD1EC VA: 0x85011EC
	public void set_googleProviderLogging(bool value) { }

	// RVA: 0x85011F8 Offset: 0x84FD1F8 VA: 0x85011F8
	internal bool get_frameStatsDialogDisplayed() { }

	// RVA: 0x8501200 Offset: 0x84FD200 VA: 0x8501200
	internal void set_frameStatsDialogDisplayed(bool value) { }

	// RVA: 0x850120C Offset: 0x84FD20C VA: 0x850120C
	private void Awake() { }

	// RVA: 0x8501264 Offset: 0x84FD264 VA: 0x8501264
	public static GoogleAndroidProviderSettings GetSettings() { }

	// RVA: 0x85012AC Offset: 0x84FD2AC VA: 0x85012AC
	public void .ctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=564 // TypeDefIndex: 28704
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=690 // TypeDefIndex: 28705
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 28706
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=690 3EC48DE17C512F901A2FC6379C63FA940C620E17E30C51EE87D626774546C8B1 /*Metadata offset 0xF547D0*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=564 6D872A3D6A008366FB27F2AB86362B6F07F1737D112C6D894BA6276D69C9816B /*Metadata offset 0xF54A88*/; // 0x2B2
}

