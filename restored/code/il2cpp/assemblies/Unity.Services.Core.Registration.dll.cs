// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28776
{}

// Namespace: 
[CompilerGenerated]
private struct CorePackageInitializer.<GenerateProjectConfigurationAsync>d__53 : IAsyncStateMachine // TypeDefIndex: 28777
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<ProjectConfiguration> <>t__builder; // 0x8
	public InitializationOptions options; // 0x20
	public CorePackageInitializer <>4__this; // 0x28
	private TaskAwaiter<SerializableProjectConfiguration> <>u__1; // 0x30

	// Methods

	// RVA: 0x8639D8C Offset: 0x8635D8C VA: 0x8639D8C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x863A0A8 Offset: 0x86360A8 VA: 0x863A0A8 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct CorePackageInitializer.<GetSerializedConfigOrEmptyAsync>d__54 : IAsyncStateMachine // TypeDefIndex: 28778
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<SerializableProjectConfiguration> <>t__builder; // 0x8
	private TaskAwaiter<SerializableProjectConfiguration> <>u__1; // 0x20

	// Methods

	// RVA: 0x863A124 Offset: 0x8636124 VA: 0x863A124 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x863A548 Offset: 0x8636548 VA: 0x863A548 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct CorePackageInitializer.<InitializeComponents>d__47 : IAsyncStateMachine // TypeDefIndex: 28779
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public CorePackageInitializer <>4__this; // 0x20
	private TaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x863A5C4 Offset: 0x86365C4 VA: 0x863A5C4 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x863A9B0 Offset: 0x86369B0 VA: 0x863A9B0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct CorePackageInitializer.<InitializeProjectConfigAsync>d__52 : IAsyncStateMachine // TypeDefIndex: 28780
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public CorePackageInitializer <>4__this; // 0x20
	public InitializationOptions options; // 0x28
	private TaskAwaiter<ProjectConfiguration> <>u__1; // 0x30

	// Methods

	// RVA: 0x863AA18 Offset: 0x8636A18 VA: 0x863AA18 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x863ACA8 Offset: 0x8636CA8 VA: 0x863ACA8 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Unity.Services.Core.Registration
internal class CorePackageInitializer : IInitializablePackageV2, IInitializablePackage, IDiagnosticsComponentProvider // TypeDefIndex: 28781
{
	// Fields
	[CompilerGenerated]
	private ActionScheduler <ActionScheduler>k__BackingField; // 0x10
	[CompilerGenerated]
	private InstallationId <InstallationId>k__BackingField; // 0x18
	[CompilerGenerated]
	private ProjectConfiguration <ProjectConfig>k__BackingField; // 0x20
	[CompilerGenerated]
	private Environments <Environments>k__BackingField; // 0x28
	[CompilerGenerated]
	private ExternalUserId <ExternalUserId>k__BackingField; // 0x30
	[CompilerGenerated]
	private ICloudProjectId <CloudProjectId>k__BackingField; // 0x38
	[CompilerGenerated]
	private IDiagnosticsFactory <DiagnosticsFactory>k__BackingField; // 0x40
	[CompilerGenerated]
	private IMetricsFactory <MetricsFactory>k__BackingField; // 0x48
	[CompilerGenerated]
	private UnityThreadUtilsInternal <UnityThreadUtils>k__BackingField; // 0x50
	private CoreRegistry m_Registry; // 0x58
	private readonly IJsonSerializer m_Serializer; // 0x60
	private InitializationOptions m_CurrentInitializationOptions; // 0x68

	// Properties
	internal ActionScheduler ActionScheduler { get; set; }
	internal InstallationId InstallationId { get; set; }
	internal ProjectConfiguration ProjectConfig { get; set; }
	internal Environments Environments { get; set; }
	internal ExternalUserId ExternalUserId { get; set; }
	internal ICloudProjectId CloudProjectId { get; set; }
	internal IDiagnosticsFactory DiagnosticsFactory { get; set; }
	internal IMetricsFactory MetricsFactory { get; set; }
	internal UnityThreadUtilsInternal UnityThreadUtils { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8638DB0 Offset: 0x8634DB0 VA: 0x8638DB0
	internal ActionScheduler get_ActionScheduler() { }

	[CompilerGenerated]
	// RVA: 0x8638DB8 Offset: 0x8634DB8 VA: 0x8638DB8
	private void set_ActionScheduler(ActionScheduler value) { }

	[CompilerGenerated]
	// RVA: 0x8638DC0 Offset: 0x8634DC0 VA: 0x8638DC0
	internal InstallationId get_InstallationId() { }

	[CompilerGenerated]
	// RVA: 0x8638DC8 Offset: 0x8634DC8 VA: 0x8638DC8
	private void set_InstallationId(InstallationId value) { }

	[CompilerGenerated]
	// RVA: 0x8638DD0 Offset: 0x8634DD0 VA: 0x8638DD0
	internal ProjectConfiguration get_ProjectConfig() { }

	[CompilerGenerated]
	// RVA: 0x8638DD8 Offset: 0x8634DD8 VA: 0x8638DD8
	private void set_ProjectConfig(ProjectConfiguration value) { }

	[CompilerGenerated]
	// RVA: 0x8638DE0 Offset: 0x8634DE0 VA: 0x8638DE0
	internal Environments get_Environments() { }

	[CompilerGenerated]
	// RVA: 0x8638DE8 Offset: 0x8634DE8 VA: 0x8638DE8
	private void set_Environments(Environments value) { }

	[CompilerGenerated]
	// RVA: 0x8638DF0 Offset: 0x8634DF0 VA: 0x8638DF0
	internal ExternalUserId get_ExternalUserId() { }

	[CompilerGenerated]
	// RVA: 0x8638DF8 Offset: 0x8634DF8 VA: 0x8638DF8
	private void set_ExternalUserId(ExternalUserId value) { }

	[CompilerGenerated]
	// RVA: 0x8638E00 Offset: 0x8634E00 VA: 0x8638E00
	internal ICloudProjectId get_CloudProjectId() { }

	[CompilerGenerated]
	// RVA: 0x8638E08 Offset: 0x8634E08 VA: 0x8638E08
	private void set_CloudProjectId(ICloudProjectId value) { }

	[CompilerGenerated]
	// RVA: 0x8638E10 Offset: 0x8634E10 VA: 0x8638E10
	internal IDiagnosticsFactory get_DiagnosticsFactory() { }

	[CompilerGenerated]
	// RVA: 0x8638E18 Offset: 0x8634E18 VA: 0x8638E18
	private void set_DiagnosticsFactory(IDiagnosticsFactory value) { }

	[CompilerGenerated]
	// RVA: 0x8638E20 Offset: 0x8634E20 VA: 0x8638E20
	internal IMetricsFactory get_MetricsFactory() { }

	[CompilerGenerated]
	// RVA: 0x8638E28 Offset: 0x8634E28 VA: 0x8638E28
	private void set_MetricsFactory(IMetricsFactory value) { }

	[CompilerGenerated]
	// RVA: 0x8638E30 Offset: 0x8634E30 VA: 0x8638E30
	internal UnityThreadUtilsInternal get_UnityThreadUtils() { }

	[CompilerGenerated]
	// RVA: 0x8638E38 Offset: 0x8634E38 VA: 0x8638E38
	private void set_UnityThreadUtils(UnityThreadUtilsInternal value) { }

	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x8638E40 Offset: 0x8634E40 VA: 0x8638E40
	private static void InitializeOnLoad() { }

	// RVA: 0x8638F34 Offset: 0x8634F34 VA: 0x8638F34 Slot: 6
	public void Register(CorePackageRegistry registry) { }

	// RVA: 0x8638F04 Offset: 0x8634F04 VA: 0x8638F04
	public void .ctor(IJsonSerializer serializer) { }

	// RVA: 0x8639168 Offset: 0x8635168 VA: 0x8639168 Slot: 5
	public Task Initialize(CoreRegistry registry) { }

	// RVA: 0x8639268 Offset: 0x8635268 VA: 0x8639268 Slot: 4
	public Task InitializeInstanceAsync(CoreRegistry registry) { }

	[AsyncStateMachine(typeof(CorePackageInitializer.<InitializeComponents>d__47))]
	// RVA: 0x8639184 Offset: 0x8635184 VA: 0x8639184
	private Task InitializeComponents() { }

	// RVA: 0x8639284 Offset: 0x8635284 VA: 0x8639284
	private bool HaveInitOptionsChanged() { }

	// RVA: 0x86392F8 Offset: 0x86352F8 VA: 0x86392F8
	private void FreeOptionsDependantComponents() { }

	// RVA: 0x8639340 Offset: 0x8635340 VA: 0x8639340
	internal void InitializeInstallationId() { }

	// RVA: 0x86393C8 Offset: 0x86353C8 VA: 0x86393C8
	internal void InitializeActionScheduler() { }

	[AsyncStateMachine(typeof(CorePackageInitializer.<InitializeProjectConfigAsync>d__52))]
	// RVA: 0x8639450 Offset: 0x8635450 VA: 0x8639450
	internal Task InitializeProjectConfigAsync(InitializationOptions options) { }

	[AsyncStateMachine(typeof(CorePackageInitializer.<GenerateProjectConfigurationAsync>d__53))]
	// RVA: 0x863954C Offset: 0x863554C VA: 0x863954C
	internal Task<ProjectConfiguration> GenerateProjectConfigurationAsync(InitializationOptions options) { }

	[AsyncStateMachine(typeof(CorePackageInitializer.<GetSerializedConfigOrEmptyAsync>d__54))]
	// RVA: 0x8639668 Offset: 0x8635668 VA: 0x8639668
	internal static Task<SerializableProjectConfiguration> GetSerializedConfigOrEmptyAsync() { }

	// RVA: 0x8639758 Offset: 0x8635758 VA: 0x8639758
	internal void InitializeExternalUserId(IProjectConfiguration projectConfiguration) { }

	// RVA: 0x86398CC Offset: 0x86358CC VA: 0x86398CC
	internal void InitializeEnvironments(IProjectConfiguration projectConfiguration) { }

	// RVA: 0x8639A18 Offset: 0x8635A18 VA: 0x8639A18
	internal void InitializeMetrics() { }

	// RVA: 0x8639A8C Offset: 0x8635A8C VA: 0x8639A8C
	internal void InitializeDiagnostics() { }

	// RVA: 0x8639B00 Offset: 0x8635B00 VA: 0x8639B00
	internal void InitializeCloudProjectId(ICloudProjectId cloudProjectId) { }

	// RVA: 0x8639B7C Offset: 0x8635B7C VA: 0x8639B7C
	internal void InitializeUnityThreadUtils() { }

	[CompilerGenerated]
	// RVA: 0x8639BF0 Offset: 0x8635BF0 VA: 0x8639BF0
	private void <InitializeComponents>g__RegisterProvidedComponents|47_0() { }

	[CompilerGenerated]
	// RVA: 0x8639D84 Offset: 0x8635D84 VA: 0x8639D84
	internal static bool <InitializeComponents>g__SendFailedInitDiagnostic|47_1(Exception reason) { }
}

