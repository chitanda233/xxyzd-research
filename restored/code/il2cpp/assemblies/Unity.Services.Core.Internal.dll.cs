// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28069
{}

// Namespace: Unity.Services.Authentication.Server.Internal
public interface IServerEnvironmentId : IEnvironmentId, IServiceComponent // TypeDefIndex: 28070
{}

// Namespace: Unity.Services.Authentication.Internal
public interface IEnvironmentId : IServiceComponent // TypeDefIndex: 28071
{}

// Namespace: Unity.Services.Core.Threading.Internal
public interface IUnityThreadUtils : IServiceComponent // TypeDefIndex: 28072
{}

// Namespace: Unity.Services.Core.Telemetry.Internal
public interface IDiagnostics // TypeDefIndex: 28073
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SendDiagnostic(string name, string message, IDictionary<string, string> tags);
}

// Namespace: Unity.Services.Core.Telemetry.Internal
internal interface IDiagnosticsComponentProvider // TypeDefIndex: 28074
{}

// Namespace: Unity.Services.Core.Telemetry.Internal
public interface IDiagnosticsFactory : IServiceComponent // TypeDefIndex: 28075
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDiagnostics Create(string packageName);
}

// Namespace: Unity.Services.Core.Telemetry.Internal
public interface IMetrics // TypeDefIndex: 28076
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SendGaugeMetric(string name, double value = 0, IDictionary<string, string> tags);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SendHistogramMetric(string name, double time, IDictionary<string, string> tags);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SendSumMetric(string name, double value = 1, IDictionary<string, string> tags);
}

// Namespace: Unity.Services.Core.Telemetry.Internal
public interface IMetricsFactory : IServiceComponent // TypeDefIndex: 28077
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMetrics Create(string packageName);
}

// Namespace: Unity.Services.Core.Scheduler.Internal
public interface IActionScheduler : IServiceComponent // TypeDefIndex: 28078
{}

// Namespace: Unity.Services.Core.Environments.Internal
public interface IEnvironments : IServiceComponent // TypeDefIndex: 28079
{
	// Properties
	public abstract string Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Current();
}

// Namespace: Unity.Services.Core.Device.Internal
public interface IInstallationId : IServiceComponent // TypeDefIndex: 28080
{}

// Namespace: Unity.Services.Core.Configuration.Internal
public interface ICloudProjectId : IServiceComponent // TypeDefIndex: 28081
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string GetCloudProjectId();
}

// Namespace: Unity.Services.Core.Configuration.Internal
public interface IExternalUserId : IServiceComponent // TypeDefIndex: 28082
{}

// Namespace: Unity.Services.Core.Configuration.Internal
public interface IProjectConfiguration : IServiceComponent // TypeDefIndex: 28083
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string GetString(string key, string defaultValue);
}

// Namespace: Unity.Services.Core.Analytics.Internal
public interface IAnalyticsStandardEventComponent : IServiceComponent // TypeDefIndex: 28084
{}

// Namespace: Unity.Services.Core.Internal
internal abstract class AsyncOperationBase : CustomYieldInstruction // TypeDefIndex: 28085
{
	// Properties
	public override bool keepWaiting { get; }
	public abstract bool IsCompleted { get; }

	// Methods

	// RVA: 0x8632248 Offset: 0x862E248 VA: 0x8632248 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_IsCompleted();
}

// Namespace: Unity.Services.Core.Internal
internal class TaskAsyncOperation : AsyncOperationBase // TypeDefIndex: 28086
{
	// Fields
	internal static TaskScheduler Scheduler; // 0x0
	private Task m_Task; // 0x10

	// Properties
	public override bool IsCompleted { get; }

	// Methods

	// RVA: 0x8632268 Offset: 0x862E268 VA: 0x8632268 Slot: 9
	public override bool get_IsCompleted() { }

	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x8632284 Offset: 0x862E284 VA: 0x8632284
	internal static void SetScheduler() { }
}

// Namespace: Unity.Services.Core.Internal
internal static class CoreLogger // TypeDefIndex: 28087
{
	// Methods

	// RVA: 0x8632304 Offset: 0x862E304 VA: 0x8632304
	public static void LogWarning(object message) { }

	// RVA: 0x8632424 Offset: 0x862E424 VA: 0x8632424
	public static void LogError(object message) { }

	// RVA: 0x8632544 Offset: 0x862E544 VA: 0x8632544
	public static void LogException(Exception exception) { }
}

// Namespace: Unity.Services.Core.Internal
public class CircularDependencyException : ServicesInitializationException // TypeDefIndex: 28088
{
	// Methods

	// RVA: 0x8632668 Offset: 0x862E668 VA: 0x8632668
	public void .ctor() { }
}

// Namespace: Unity.Services.Core.Internal
internal class ComponentRegistry : IComponentRegistry // TypeDefIndex: 28089
{
	// Fields
	[CompilerGenerated]
	private readonly Dictionary<int, IServiceComponent> <ComponentTypeHashToInstance>k__BackingField; // 0x10

	// Properties
	[NotNull]
	internal Dictionary<int, IServiceComponent> ComponentTypeHashToInstance { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8632670 Offset: 0x862E670 VA: 0x8632670
	internal Dictionary<int, IServiceComponent> get_ComponentTypeHashToInstance() { }

	// RVA: 0x8632678 Offset: 0x862E678 VA: 0x8632678
	public void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public void RegisterServiceComponent<TComponent>(TComponent component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4558204 Offset: 0x4554204 VA: 0x4558204
	|-ComponentRegistry.RegisterServiceComponent<object>
	|
	|-RVA: 0x45583B4 Offset: 0x45543B4 VA: 0x45583B4
	|-ComponentRegistry.RegisterServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public TComponent GetServiceComponent<TComponent>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4557E18 Offset: 0x4553E18 VA: 0x4557E18
	|-ComponentRegistry.GetServiceComponent<object>
	|
	|-RVA: 0x4557FE4 Offset: 0x4553FE4 VA: 0x4557FE4
	|-ComponentRegistry.GetServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x8632700 Offset: 0x862E700 VA: 0x8632700
	private bool IsComponentTypeRegistered(int componentTypeHash) { }

	// RVA: 0x86327C8 Offset: 0x862E7C8 VA: 0x86327C8 Slot: 6
	public void ResetProvidedComponents(IDictionary<int, IServiceComponent> componentTypeHashToInstance) { }
}

// Namespace: Unity.Services.Core.Internal
internal interface IComponentRegistry // TypeDefIndex: 28090
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void RegisterServiceComponent<TComponent>(TComponent component);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IComponentRegistry.RegisterServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract TComponent GetServiceComponent<TComponent>();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IComponentRegistry.GetServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void ResetProvidedComponents(IDictionary<int, IServiceComponent> componentTypeHashToInstance);
}

// Namespace: Unity.Services.Core.Internal
internal class LockedComponentRegistry : IComponentRegistry // TypeDefIndex: 28091
{
	// Fields
	[CompilerGenerated]
	private readonly IComponentRegistry <Registry>k__BackingField; // 0x10

	// Properties
	[NotNull]
	internal IComponentRegistry Registry { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8632840 Offset: 0x862E840 VA: 0x8632840
	internal IComponentRegistry get_Registry() { }

	// RVA: 0x8632848 Offset: 0x862E848 VA: 0x8632848
	public void .ctor(IComponentRegistry registryToLock) { }

	// RVA: -1 Offset: -1 Slot: 4
	public void RegisterServiceComponent<TComponent>(TComponent component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466CAA4 Offset: 0x4668AA4 VA: 0x466CAA4
	|-LockedComponentRegistry.RegisterServiceComponent<object>
	|
	|-RVA: 0x466CAEC Offset: 0x4668AEC VA: 0x466CAEC
	|-LockedComponentRegistry.RegisterServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public TComponent GetServiceComponent<TComponent>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466C8D8 Offset: 0x46688D8 VA: 0x466C8D8
	|-LockedComponentRegistry.GetServiceComponent<object>
	|
	|-RVA: 0x466C980 Offset: 0x4668980 VA: 0x466C980
	|-LockedComponentRegistry.GetServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x8632878 Offset: 0x862E878 VA: 0x8632878 Slot: 6
	public void ResetProvidedComponents(IDictionary<int, IServiceComponent> componentTypeHashToInstance) { }
}

// Namespace: Unity.Services.Core.Internal
public sealed class CorePackageRegistry // TypeDefIndex: 28092
{
	// Fields
	[CompilerGenerated]
	private static CorePackageRegistry <Instance>k__BackingField; // 0x0
	[CompilerGenerated]
	private IPackageRegistry <Registry>k__BackingField; // 0x10

	// Properties
	public static CorePackageRegistry Instance { get; set; }
	internal IPackageRegistry Registry { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x86328C4 Offset: 0x862E8C4 VA: 0x86328C4
	public static CorePackageRegistry get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x863290C Offset: 0x862E90C VA: 0x863290C
	internal static void set_Instance(CorePackageRegistry value) { }

	[CompilerGenerated]
	// RVA: 0x8632964 Offset: 0x862E964 VA: 0x8632964
	internal IPackageRegistry get_Registry() { }

	[CompilerGenerated]
	// RVA: 0x863296C Offset: 0x862E96C VA: 0x863296C
	internal void set_Registry(IPackageRegistry value) { }

	// RVA: 0x8632974 Offset: 0x862E974 VA: 0x8632974
	internal void .ctor() { }

	// RVA: -1 Offset: -1
	public CoreRegistration Register<TPackage>(TPackage package) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4560414 Offset: 0x455C414 VA: 0x4560414
	|-CorePackageRegistry.Register<object>
	|
	|-RVA: 0x45604C4 Offset: 0x455C4C4 VA: 0x45604C4
	|-CorePackageRegistry.Register<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x8632B9C Offset: 0x862EB9C VA: 0x8632B9C
	internal void Lock() { }
}

// Namespace: Unity.Services.Core.Internal
[IsReadOnly]
public struct CoreRegistration // TypeDefIndex: 28093
{
	// Fields
	private readonly IPackageRegistry m_Registry; // 0x0
	private readonly int m_PackageHash; // 0x8

	// Methods

	// RVA: 0x8632C78 Offset: 0x862EC78 VA: 0x8632C78
	internal void .ctor(IPackageRegistry registry, int packageHash) { }

	// RVA: -1 Offset: -1
	public CoreRegistration DependsOn<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4560604 Offset: 0x455C604 VA: 0x4560604
	|-CoreRegistration.DependsOn<object>
	|
	|-RVA: 0x45606C4 Offset: 0x455C6C4 VA: 0x45606C4
	|-CoreRegistration.DependsOn<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public CoreRegistration OptionallyDependsOn<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4560784 Offset: 0x455C784 VA: 0x4560784
	|-CoreRegistration.OptionallyDependsOn<object>
	|
	|-RVA: 0x4560844 Offset: 0x455C844 VA: 0x4560844
	|-CoreRegistration.OptionallyDependsOn<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public CoreRegistration ProvidesComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4560904 Offset: 0x455C904 VA: 0x4560904
	|-CoreRegistration.ProvidesComponent<object>
	|
	|-RVA: 0x45609C4 Offset: 0x455C9C4 VA: 0x45609C4
	|-CoreRegistration.ProvidesComponent<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.Services.Core.Internal
public sealed class CoreRegistry // TypeDefIndex: 28094
{
	// Fields
	[CompilerGenerated]
	private static CoreRegistry <Instance>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly string <InstanceId>k__BackingField; // 0x10
	[CompilerGenerated]
	private ServicesType <Type>k__BackingField; // 0x18
	[CompilerGenerated]
	private InitializationOptions <Options>k__BackingField; // 0x20
	[CompilerGenerated]
	private IPackageRegistry <PackageRegistry>k__BackingField; // 0x28
	[CompilerGenerated]
	private IComponentRegistry <ComponentRegistry>k__BackingField; // 0x30
	[CompilerGenerated]
	private IServiceRegistry <ServiceRegistry>k__BackingField; // 0x38

	// Properties
	public static CoreRegistry Instance { get; set; }
	internal ServicesType Type { get; set; }
	internal InitializationOptions Options { get; }
	[NotNull]
	internal IPackageRegistry PackageRegistry { get; set; }
	[NotNull]
	internal IComponentRegistry ComponentRegistry { get; set; }
	[NotNull]
	private IServiceRegistry ServiceRegistry { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8632CA0 Offset: 0x862ECA0 VA: 0x8632CA0
	public static CoreRegistry get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x8632CE8 Offset: 0x862ECE8 VA: 0x8632CE8
	internal static void set_Instance(CoreRegistry value) { }

	[CompilerGenerated]
	// RVA: 0x8632D40 Offset: 0x862ED40 VA: 0x8632D40
	internal ServicesType get_Type() { }

	[CompilerGenerated]
	// RVA: 0x8632D48 Offset: 0x862ED48 VA: 0x8632D48
	private void set_Type(ServicesType value) { }

	[CompilerGenerated]
	// RVA: 0x8632D50 Offset: 0x862ED50 VA: 0x8632D50
	internal InitializationOptions get_Options() { }

	[CompilerGenerated]
	// RVA: 0x8632D58 Offset: 0x862ED58 VA: 0x8632D58
	internal IPackageRegistry get_PackageRegistry() { }

	[CompilerGenerated]
	// RVA: 0x8632D60 Offset: 0x862ED60 VA: 0x8632D60
	private void set_PackageRegistry(IPackageRegistry value) { }

	[CompilerGenerated]
	// RVA: 0x8632D68 Offset: 0x862ED68 VA: 0x8632D68
	internal IComponentRegistry get_ComponentRegistry() { }

	[CompilerGenerated]
	// RVA: 0x8632D70 Offset: 0x862ED70 VA: 0x8632D70
	private void set_ComponentRegistry(IComponentRegistry value) { }

	[CompilerGenerated]
	// RVA: 0x8632D78 Offset: 0x862ED78 VA: 0x8632D78
	private void set_ServiceRegistry(IServiceRegistry value) { }

	// RVA: 0x8632D80 Offset: 0x862ED80 VA: 0x8632D80
	internal void .ctor(IPackageRegistry packageRegistry, ServicesType type = 0, string instanceId) { }

	// RVA: -1 Offset: -1
	public CoreRegistration RegisterPackage<TPackage>(TPackage package) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4560C50 Offset: 0x455CC50 VA: 0x4560C50
	|-CoreRegistry.RegisterPackage<object>
	|
	|-RVA: 0x4560D00 Offset: 0x455CD00 VA: 0x4560D00
	|-CoreRegistry.RegisterPackage<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void RegisterServiceComponent<TComponent>(TComponent component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4560E40 Offset: 0x455CE40 VA: 0x4560E40
	|-CoreRegistry.RegisterServiceComponent<object>
	|
	|-RVA: 0x4560EF0 Offset: 0x455CEF0 VA: 0x4560EF0
	|-CoreRegistry.RegisterServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public TComponent GetServiceComponent<TComponent>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4560A84 Offset: 0x455CA84 VA: 0x4560A84
	|-CoreRegistry.GetServiceComponent<object>
	|
	|-RVA: 0x4560B2C Offset: 0x455CB2C VA: 0x4560B2C
	|-CoreRegistry.GetServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x8632EE4 Offset: 0x862EEE4 VA: 0x8632EE4
	internal void LockComponentRegistration() { }
}

// Namespace: 
private struct CoreRegistryInitializer.<>c__DisplayClass3_0.<<InitializeRegistryAsync>g__InitializePackageAsync|2>d : IAsyncStateMachine // TypeDefIndex: 28095
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public CoreRegistryInitializer.<>c__DisplayClass3_0 <>4__this; // 0x20
	public IInitializablePackage package; // 0x28
	private TaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x86333D8 Offset: 0x862F3D8 VA: 0x86333D8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x8633808 Offset: 0x862F808 VA: 0x8633808 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
private struct CoreRegistryInitializer.<>c__DisplayClass3_0.<<InitializeRegistryAsync>g__TryInitializePackageAsync|0>d : IAsyncStateMachine // TypeDefIndex: 28096
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public CoreRegistryInitializer.<>c__DisplayClass3_0 <>4__this; // 0x20
	public IInitializablePackage package; // 0x28
	private TaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x8633870 Offset: 0x862F870 VA: 0x8633870 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x8633D04 Offset: 0x862FD04 VA: 0x8633D04 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CoreRegistryInitializer.<>c__DisplayClass3_0 // TypeDefIndex: 28097
{
	// Fields
	public Stopwatch stopwatch; // 0x10
	public List<PackageInitializationInfo> packagesInitInfos; // 0x18
	public List<Exception> failureReasons; // 0x20
	public CoreRegistryInitializer <>4__this; // 0x28
	public DependencyTree dependencyTree; // 0x30

	// Methods

	// RVA: 0x86330D0 Offset: 0x862F0D0 VA: 0x86330D0
	public void .ctor() { }

	[AsyncStateMachine(typeof(CoreRegistryInitializer.<>c__DisplayClass3_0.<<InitializeRegistryAsync>g__TryInitializePackageAsync|0>d))]
	// RVA: 0x86330D8 Offset: 0x862F0D8 VA: 0x86330D8
	internal Task <InitializeRegistryAsync>g__TryInitializePackageAsync|0(IInitializablePackage package) { }

	// RVA: 0x86331D4 Offset: 0x862F1D4 VA: 0x86331D4
	internal IInitializablePackage <InitializeRegistryAsync>g__GetPackageAt|1(int index) { }

	[AsyncStateMachine(typeof(CoreRegistryInitializer.<>c__DisplayClass3_0.<<InitializeRegistryAsync>g__InitializePackageAsync|2>d))]
	// RVA: 0x8633264 Offset: 0x862F264 VA: 0x8633264
	internal Task <InitializeRegistryAsync>g__InitializePackageAsync|2(IInitializablePackage package) { }

	// RVA: 0x8633360 Offset: 0x862F360 VA: 0x8633360
	internal void <InitializeRegistryAsync>g__Fail|3() { }
}

// Namespace: 
[CompilerGenerated]
private struct CoreRegistryInitializer.<InitializeRegistryAsync>d__3 : IAsyncStateMachine // TypeDefIndex: 28098
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<List<PackageInitializationInfo>> <>t__builder; // 0x8
	public CoreRegistryInitializer <>4__this; // 0x20
	private CoreRegistryInitializer.<>c__DisplayClass3_0 <>8__1; // 0x28
	private int <i>5__2; // 0x30
	private TaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x8633D6C Offset: 0x862FD6C VA: 0x8633D6C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x8634410 Offset: 0x8630410 VA: 0x8634410 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Unity.Services.Core.Internal
internal class CoreRegistryInitializer // TypeDefIndex: 28099
{
	// Fields
	[NotNull]
	private readonly CoreRegistry m_Registry; // 0x10
	[NotNull]
	private readonly List<int> m_SortedPackageTypeHashes; // 0x18

	// Methods

	// RVA: 0x8632F90 Offset: 0x862EF90 VA: 0x8632F90
	public void .ctor(CoreRegistry registry, List<int> sortedPackageTypeHashes) { }

	[AsyncStateMachine(typeof(CoreRegistryInitializer.<InitializeRegistryAsync>d__3))]
	// RVA: 0x8632FD4 Offset: 0x862EFD4 VA: 0x8632FD4
	public Task<List<PackageInitializationInfo>> InitializeRegistryAsync() { }
}

// Namespace: Unity.Services.Core.Internal
internal class DependencyTree // TypeDefIndex: 28100
{
	// Fields
	public readonly Dictionary<int, IInitializablePackage> PackageTypeHashToInstance; // 0x10
	public readonly Dictionary<int, int> ComponentTypeHashToPackageTypeHash; // 0x18
	public readonly Dictionary<int, List<int>> PackageTypeHashToComponentTypeHashDependencies; // 0x20
	public readonly Dictionary<int, IServiceComponent> ComponentTypeHashToInstance; // 0x28

	// Methods

	// RVA: 0x8632A1C Offset: 0x862EA1C VA: 0x8632A1C
	internal void .ctor() { }

	// RVA: 0x863448C Offset: 0x863048C VA: 0x863448C
	internal void .ctor(Dictionary<int, IInitializablePackage> packageToInstance, Dictionary<int, int> componentToPackage, Dictionary<int, List<int>> packageToComponentDependencies, Dictionary<int, IServiceComponent> componentToInstance) { }
}

// Namespace: Unity.Services.Core.Internal
internal class DependencyTreeSortFailedException : Exception // TypeDefIndex: 28101
{
	// Methods

	// RVA: 0x8634500 Offset: 0x8630500 VA: 0x8634500
	public void .ctor(DependencyTree tree, ICollection<int> target, Exception inner) { }

	// RVA: 0x8634594 Offset: 0x8630594 VA: 0x8634594
	private static string CreateExceptionMessage(DependencyTree tree, ICollection<int> target, Exception inner) { }
}

// Namespace: Unity.Services.Core.Internal
[Extension]
internal static class DependencyTreeExtensions // TypeDefIndex: 28102
{
	// Methods

	[Extension]
	// RVA: 0x8634674 Offset: 0x8630674 VA: 0x8634674
	internal static string ToJson(DependencyTree tree, ICollection<int> order) { }

	[Extension]
	// RVA: 0x8635934 Offset: 0x8631934 VA: 0x8635934
	internal static bool IsOptional(DependencyTree tree, int componentTypeHash) { }

	[Extension]
	// RVA: 0x86359B4 Offset: 0x86319B4 VA: 0x86359B4
	internal static bool IsProvided(DependencyTree tree, int componentTypeHash) { }

	// RVA: 0x8634E34 Offset: 0x8630E34 VA: 0x8634E34
	private static JObject GetPackageJObject(DependencyTree tree, int packageHash) { }

	// RVA: 0x86355A0 Offset: 0x86315A0 VA: 0x86355A0
	private static JObject GetComponentJObject(DependencyTree tree, int componentHash) { }

	// RVA: 0x8635A10 Offset: 0x8631A10 VA: 0x8635A10
	private static string GetComponentIdentifier(IServiceComponent component) { }
}

// Namespace: 
private enum DependencyTreeInitializeOrderSorter.ExplorationMark // TypeDefIndex: 28103
{
	// Fields
	public int value__; // 0x0
	public const DependencyTreeInitializeOrderSorter.ExplorationMark None = 0;
	public const DependencyTreeInitializeOrderSorter.ExplorationMark Viewed = 1;
	public const DependencyTreeInitializeOrderSorter.ExplorationMark Sorted = 2;
}

// Namespace: Unity.Services.Core.Internal
internal struct DependencyTreeInitializeOrderSorter // TypeDefIndex: 28104
{
	// Fields
	public readonly DependencyTree Tree; // 0x0
	public readonly ICollection<int> Target; // 0x8
	private Dictionary<int, DependencyTreeInitializeOrderSorter.ExplorationMark> m_PackageTypeHashExplorationHistory; // 0x10

	// Methods

	// RVA: 0x8635ACC Offset: 0x8631ACC VA: 0x8635ACC
	public void .ctor(DependencyTree tree, ICollection<int> target) { }

	// RVA: 0x8635B0C Offset: 0x8631B0C VA: 0x8635B0C
	public void SortRegisteredPackagesIntoTarget() { }

	// RVA: 0x8635FF4 Offset: 0x8631FF4 VA: 0x8635FF4
	private void RemoveUnprovidedOptionalDependenciesFromTree() { }

	// RVA: 0x863648C Offset: 0x863248C VA: 0x863648C
	private void RemoveUnprovidedOptionalDependencies(IList<int> dependencyTypeHashes) { }

	// RVA: 0x86361A4 Offset: 0x86321A4 VA: 0x86361A4
	private void SortTreeThrough(int packageTypeHash) { }

	// RVA: 0x8636794 Offset: 0x8632794 VA: 0x8636794
	private void SortTreeThrough(IEnumerable<int> dependencyTypeHashes) { }

	// RVA: 0x8636640 Offset: 0x8632640 VA: 0x8636640
	private void MarkPackage(int packageTypeHash, DependencyTreeInitializeOrderSorter.ExplorationMark mark) { }

	// RVA: 0x863614C Offset: 0x863214C VA: 0x863614C
	private IReadOnlyCollection<int> GetPackageTypeHashes() { }

	// RVA: 0x8636A7C Offset: 0x8632A7C VA: 0x8636A7C
	private int GetPackageTypeHashFor(int componentTypeHash) { }

	// RVA: 0x86366A8 Offset: 0x86326A8 VA: 0x86366A8
	private IEnumerable<int> GetDependencyTypeHashesFor(int packageTypeHash) { }
}

// Namespace: Unity.Services.Core.Internal
internal class HashException : Exception // TypeDefIndex: 28105
{
	// Fields
	[CompilerGenerated]
	private readonly int <Hash>k__BackingField; // 0x8C

	// Properties
	public int Hash { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8636B70 Offset: 0x8632B70 VA: 0x8636B70
	public int get_Hash() { }

	// RVA: 0x8636B78 Offset: 0x8632B78 VA: 0x8636B78
	public void .ctor(int hash, string message) { }

	// RVA: 0x8636BE4 Offset: 0x8632BE4 VA: 0x8636BE4
	public void .ctor(int hash, string message, Exception inner) { }
}

// Namespace: Unity.Services.Core.Internal
internal class DependencyTreePackageHashException : HashException // TypeDefIndex: 28106
{
	// Methods

	// RVA: 0x8636B6C Offset: 0x8632B6C VA: 0x8636B6C
	public void .ctor(int hash, string message) { }

	// RVA: 0x8636A78 Offset: 0x8632A78 VA: 0x8636A78
	public void .ctor(int hash, string message, Exception inner) { }
}

// Namespace: Unity.Services.Core.Internal
internal class DependencyTreeComponentHashException : HashException // TypeDefIndex: 28107
{
	// Methods

	// RVA: 0x8636B68 Offset: 0x8632B68 VA: 0x8636B68
	public void .ctor(int hash, string message) { }
}

// Namespace: Unity.Services.Core.Internal
public interface IInitializablePackage // TypeDefIndex: 28108
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Task Initialize(CoreRegistry registry);
}

// Namespace: Unity.Services.Core.Internal
public interface IInitializablePackageV2 : IInitializablePackage // TypeDefIndex: 28109
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Task InitializeInstanceAsync(CoreRegistry registry);
}

// Namespace: Unity.Services.Core.Internal
public interface IServiceComponent // TypeDefIndex: 28110
{}

// Namespace: Unity.Services.Core.Internal
internal class MissingComponent : IServiceComponent // TypeDefIndex: 28111
{
	// Fields
	[CompilerGenerated]
	private readonly Type <IntendedType>k__BackingField; // 0x10

	// Properties
	public Type IntendedType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8636C68 Offset: 0x8632C68 VA: 0x8636C68
	public Type get_IntendedType() { }

	// RVA: 0x8636C70 Offset: 0x8632C70 VA: 0x8636C70
	internal void .ctor(Type intendedType) { }
}

// Namespace: Unity.Services.Core.Internal
internal class PackageInitializationInfo // TypeDefIndex: 28112
{
	// Fields
	public Type PackageType; // 0x10
	public double InitializationTimeInSeconds; // 0x18

	// Methods

	// RVA: 0x8633CFC Offset: 0x862FCFC VA: 0x8633CFC
	public void .ctor() { }
}

// Namespace: Unity.Services.Core.Internal
internal interface IPackageRegistry // TypeDefIndex: 28113
{
	// Properties
	[CanBeNull]
	public abstract DependencyTree Tree { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DependencyTree get_Tree();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract CoreRegistration RegisterPackage<TPackage>(TPackage package);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPackageRegistry.RegisterPackage<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void RegisterDependency<TComponent>(int packageTypeHash);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPackageRegistry.RegisterDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void RegisterOptionalDependency<TComponent>(int packageTypeHash);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPackageRegistry.RegisterOptionalDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void RegisterProvision<TComponent>(int packageTypeHash);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPackageRegistry.RegisterProvision<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.Services.Core.Internal
internal class LockedPackageRegistry : IPackageRegistry // TypeDefIndex: 28114
{
	// Fields
	[CompilerGenerated]
	private readonly IPackageRegistry <Registry>k__BackingField; // 0x10

	// Properties
	[NotNull]
	internal IPackageRegistry Registry { get; }
	public DependencyTree Tree { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8636CA0 Offset: 0x8632CA0 VA: 0x8636CA0
	internal IPackageRegistry get_Registry() { }

	// RVA: 0x8632C48 Offset: 0x862EC48 VA: 0x8632C48
	public void .ctor(IPackageRegistry registryToLock) { }

	// RVA: 0x8636CA8 Offset: 0x8632CA8 VA: 0x8636CA8 Slot: 4
	public DependencyTree get_Tree() { }

	// RVA: -1 Offset: -1 Slot: 5
	public CoreRegistration RegisterPackage<TPackage>(TPackage package) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466CC54 Offset: 0x4668C54 VA: 0x466CC54
	|-LockedPackageRegistry.RegisterPackage<object>
	|
	|-RVA: 0x466CC9C Offset: 0x4668C9C VA: 0x466CC9C
	|-LockedPackageRegistry.RegisterPackage<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void RegisterDependency<TComponent>(int packageTypeHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466CB34 Offset: 0x4668B34 VA: 0x466CB34
	|-LockedPackageRegistry.RegisterDependency<object>
	|
	|-RVA: 0x466CB7C Offset: 0x4668B7C VA: 0x466CB7C
	|-LockedPackageRegistry.RegisterDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void RegisterOptionalDependency<TComponent>(int packageTypeHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466CBC4 Offset: 0x4668BC4 VA: 0x466CBC4
	|-LockedPackageRegistry.RegisterOptionalDependency<object>
	|
	|-RVA: 0x466CC0C Offset: 0x4668C0C VA: 0x466CC0C
	|-LockedPackageRegistry.RegisterOptionalDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RegisterProvision<TComponent>(int packageTypeHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466CCE4 Offset: 0x4668CE4 VA: 0x466CCE4
	|-LockedPackageRegistry.RegisterProvision<object>
	|
	|-RVA: 0x466CD2C Offset: 0x4668D2C VA: 0x466CD2C
	|-LockedPackageRegistry.RegisterProvision<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.Services.Core.Internal
internal class PackageRegistry : IPackageRegistry // TypeDefIndex: 28115
{
	// Fields
	[CompilerGenerated]
	private DependencyTree <Tree>k__BackingField; // 0x10

	// Properties
	public DependencyTree Tree { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8636D48 Offset: 0x8632D48 VA: 0x8636D48 Slot: 4
	public DependencyTree get_Tree() { }

	[CompilerGenerated]
	// RVA: 0x8636D50 Offset: 0x8632D50 VA: 0x8636D50 Slot: 9
	public void set_Tree(DependencyTree value) { }

	// RVA: 0x8632B6C Offset: 0x862EB6C VA: 0x8632B6C
	public void .ctor(DependencyTree tree) { }

	// RVA: -1 Offset: -1 Slot: 5
	public CoreRegistration RegisterPackage<TPackage>(TPackage package) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46874E0 Offset: 0x46834E0 VA: 0x46874E0
	|-PackageRegistry.RegisterPackage<object>
	|
	|-RVA: 0x468763C Offset: 0x468363C VA: 0x468763C
	|-PackageRegistry.RegisterPackage<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void RegisterDependency<TComponent>(int packageTypeHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46870C0 Offset: 0x46830C0 VA: 0x46870C0
	|-PackageRegistry.RegisterDependency<object>
	|
	|-RVA: 0x46871D0 Offset: 0x46831D0 VA: 0x46871D0
	|-PackageRegistry.RegisterDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void RegisterOptionalDependency<TComponent>(int packageTypeHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46872E0 Offset: 0x46832E0 VA: 0x46872E0
	|-PackageRegistry.RegisterOptionalDependency<object>
	|
	|-RVA: 0x46873E0 Offset: 0x46833E0 VA: 0x46873E0
	|-PackageRegistry.RegisterOptionalDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RegisterProvision<TComponent>(int packageTypeHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x468781C Offset: 0x468381C VA: 0x468781C
	|-PackageRegistry.RegisterProvision<object>
	|
	|-RVA: 0x46878D0 Offset: 0x46838D0 VA: 0x46878D0
	|-PackageRegistry.RegisterProvision<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x8636D58 Offset: 0x8632D58 VA: 0x8636D58
	private void AddComponentDependencyToPackage(int componentTypeHash, int packageTypeHash) { }
}

// Namespace: Unity.Services.Core.Internal
internal interface IServiceRegistry // TypeDefIndex: 28116
{}

// Namespace: Unity.Services.Core.Internal
internal class ServiceRegistry : IServiceRegistry // TypeDefIndex: 28117
{
	// Fields
	[CompilerGenerated]
	private readonly Dictionary<int, object> <ServiceTypeHashToInstance>k__BackingField; // 0x10

	// Methods

	// RVA: 0x8632E5C Offset: 0x862EE5C VA: 0x8632E5C
	public void .ctor() { }
}

// Namespace: Unity.Services.Core.Internal
internal enum ServicesType // TypeDefIndex: 28118
{
	// Fields
	public int value__; // 0x0
	public const ServicesType Default = 0;
	public const ServicesType Instance = 1;
}

// Namespace: Unity.Services.Core.Internal
internal class CoreDiagnostics // TypeDefIndex: 28119
{
	// Fields
	[CompilerGenerated]
	private static CoreDiagnostics <Instance>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly IDictionary<string, string> <CoreTags>k__BackingField; // 0x10
	[CompilerGenerated]
	private IDiagnosticsComponentProvider <DiagnosticsComponentProvider>k__BackingField; // 0x18

	// Properties
	public static CoreDiagnostics Instance { get; set; }
	internal IDiagnosticsComponentProvider DiagnosticsComponentProvider { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8636E64 Offset: 0x8632E64 VA: 0x8636E64
	public static CoreDiagnostics get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x8636EAC Offset: 0x8632EAC VA: 0x8636EAC
	internal static void set_Instance(CoreDiagnostics value) { }

	[CompilerGenerated]
	// RVA: 0x8636F04 Offset: 0x8632F04 VA: 0x8636F04
	internal void set_DiagnosticsComponentProvider(IDiagnosticsComponentProvider value) { }

	// RVA: 0x8636F0C Offset: 0x8632F0C VA: 0x8636F0C
	public void .ctor() { }
}

// Namespace: Unity.Services.Core.Internal
internal class CoreMetrics // TypeDefIndex: 28120
{
	// Fields
	[CompilerGenerated]
	private static CoreMetrics <Instance>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly IDictionary<Type, IMetrics> <AllPackageMetrics>k__BackingField; // 0x10

	// Properties
	public static CoreMetrics Instance { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8636F94 Offset: 0x8632F94 VA: 0x8636F94
	public static CoreMetrics get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x8636FDC Offset: 0x8632FDC VA: 0x8636FDC
	internal static void set_Instance(CoreMetrics value) { }

	// RVA: 0x8637034 Offset: 0x8633034 VA: 0x8637034
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct UnityServicesInitializer.<EnableServicesInitializationAsync>d__1 : IAsyncStateMachine // TypeDefIndex: 28121
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	private TaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x863766C Offset: 0x863366C VA: 0x863766C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x8637980 Offset: 0x8633980 VA: 0x8637980 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Unity.Services.Core.Internal
internal static class UnityServicesInitializer // TypeDefIndex: 28122
{
	// Methods

	[RuntimeInitializeOnLoadMethod(2)]
	// RVA: 0x86370BC Offset: 0x86330BC VA: 0x86370BC
	private static void CreateStaticInstance() { }

	[AsyncStateMachine(typeof(UnityServicesInitializer.<EnableServicesInitializationAsync>d__1))]
	[RuntimeInitializeOnLoadMethod(0)]
	// RVA: 0x8637480 Offset: 0x8633480 VA: 0x8637480
	private static void EnableServicesInitializationAsync() { }

	// RVA: 0x8637514 Offset: 0x8633514 VA: 0x8637514
	internal static IUnityServices CreateInstance(string servicesId) { }
}

// Namespace: 
private struct UnityServicesInternal.<>c__DisplayClass33_0.<<InitializeServicesAsync>g__InitializePackagesAsync|1>d : IAsyncStateMachine // TypeDefIndex: 28123
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public UnityServicesInternal.<>c__DisplayClass33_0 <>4__this; // 0x20
	private TaskAwaiter<List<PackageInitializationInfo>> <>u__1; // 0x28

	// Methods

	// RVA: 0x8637CB0 Offset: 0x8633CB0 VA: 0x8637CB0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x8637F24 Offset: 0x8633F24 VA: 0x8637F24 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UnityServicesInternal.<>c__DisplayClass33_0 // TypeDefIndex: 28124
{
	// Fields
	public DependencyTree dependencyTree; // 0x10
	public List<int> sortedPackageTypeHashes; // 0x18
	public UnityServicesInternal <>4__this; // 0x20
	public Stopwatch initStopwatch; // 0x28

	// Methods

	// RVA: 0x8637A94 Offset: 0x8633A94 VA: 0x8637A94
	public void .ctor() { }

	// RVA: 0x8637A9C Offset: 0x8633A9C VA: 0x8637A9C
	internal void <InitializeServicesAsync>g__SortPackages|0() { }

	[AsyncStateMachine(typeof(UnityServicesInternal.<>c__DisplayClass33_0.<<InitializeServicesAsync>g__InitializePackagesAsync|1>d))]
	// RVA: 0x8637AC8 Offset: 0x8633AC8 VA: 0x8637AC8
	internal Task <InitializeServicesAsync>g__InitializePackagesAsync|1() { }

	// RVA: 0x8637BAC Offset: 0x8633BAC VA: 0x8637BAC
	internal void <InitializeServicesAsync>g__FailServicesInitialization|2(Exception reason) { }

	// RVA: 0x8637C28 Offset: 0x8633C28 VA: 0x8637C28
	internal void <InitializeServicesAsync>g__SucceedServicesInitialization|3() { }
}

// Namespace: 
[CompilerGenerated]
private struct UnityServicesInternal.<EnableInitializationAsync>d__36 : IAsyncStateMachine // TypeDefIndex: 28125
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public UnityServicesInternal <>4__this; // 0x20
	private TaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x8637F8C Offset: 0x8633F8C VA: 0x8637F8C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x86381C0 Offset: 0x86341C0 VA: 0x86381C0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct UnityServicesInternal.<InitializeServicesAsync>d__33 : IAsyncStateMachine // TypeDefIndex: 28126
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public UnityServicesInternal <>4__this; // 0x20
	private UnityServicesInternal.<>c__DisplayClass33_0 <>8__1; // 0x28
	private TaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x8638228 Offset: 0x8634228 VA: 0x8638228 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x86387B0 Offset: 0x86347B0 VA: 0x86387B0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Unity.Services.Core.Internal
internal class UnityServicesInternal : IUnityServices // TypeDefIndex: 28127
{
	// Fields
	[CompilerGenerated]
	private ServicesInitializationState <State>k__BackingField; // 0x10
	internal bool CanInitialize; // 0x14
	private TaskCompletionSource<object> m_Initialization; // 0x18
	[CompilerGenerated]
	private readonly CoreRegistry <Registry>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly CoreMetrics <Metrics>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly CoreDiagnostics <Diagnostics>k__BackingField; // 0x30

	// Properties
	private ServicesInitializationState State { set; }
	[NotNull]
	internal CoreRegistry Registry { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x863798C Offset: 0x863398C VA: 0x863798C
	private void set_State(ServicesInitializationState value) { }

	[CompilerGenerated]
	// RVA: 0x8637994 Offset: 0x8633994 VA: 0x8637994
	internal CoreRegistry get_Registry() { }

	// RVA: 0x8637420 Offset: 0x8633420 VA: 0x8637420
	public void .ctor(CoreRegistry registry, CoreMetrics coreMetrics, CoreDiagnostics coreDiagnostics) { }

	// RVA: 0x863799C Offset: 0x863399C VA: 0x863799C
	private bool HasRequestedInitialization() { }

	[AsyncStateMachine(typeof(UnityServicesInternal.<InitializeServicesAsync>d__33))]
	// RVA: 0x86379AC Offset: 0x86339AC VA: 0x86379AC
	private Task InitializeServicesAsync() { }

	// RVA: 0x8637660 Offset: 0x8633660 VA: 0x8637660
	internal void EnableInitialization() { }

	[AsyncStateMachine(typeof(UnityServicesInternal.<EnableInitializationAsync>d__36))]
	// RVA: 0x863789C Offset: 0x863389C VA: 0x863789C
	internal Task EnableInitializationAsync() { }
}

// Namespace: Unity.Services.Core.Internal
[Extension]
internal static class DictionaryExtensions // TypeDefIndex: 28128
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static TDictionary MergeAllowOverride<TDictionary, TKey, TValue>(TDictionary self, IDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4572640 Offset: 0x456E640 VA: 0x4572640
	|-DictionaryExtensions.MergeAllowOverride<object, int, object>
	|
	|-RVA: 0x45729B4 Offset: 0x456E9B4 VA: 0x45729B4
	|-DictionaryExtensions.MergeAllowOverride<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool ValueEquals<TKey, TValue>(IDictionary<TKey, TValue> x, IDictionary<TKey, TValue> y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4572EC0 Offset: 0x456EEC0 VA: 0x4572EC0
	|-DictionaryExtensions.ValueEquals<object, object>
	|
	|-RVA: 0x4572F10 Offset: 0x456EF10 VA: 0x4572F10
	|-DictionaryExtensions.ValueEquals<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool ValueEquals<TKey, TValue, TComparer>(IDictionary<TKey, TValue> x, IDictionary<TKey, TValue> y, TComparer valueComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4572F88 Offset: 0x456EF88 VA: 0x4572F88
	|-DictionaryExtensions.ValueEquals<object, object, object>
	|
	|-RVA: 0x45734B0 Offset: 0x456F4B0 VA: 0x45734B0
	|-DictionaryExtensions.ValueEquals<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class UnityWebRequestUtils.<>c__DisplayClass2_0 // TypeDefIndex: 28129
{
	// Fields
	public TaskCompletionSource<string> completionSource; // 0x10

	// Methods

	// RVA: 0x8638980 Offset: 0x8634980 VA: 0x8638980
	public void .ctor() { }

	// RVA: 0x8638988 Offset: 0x8634988 VA: 0x8638988
	internal void <GetTextAsync>g__CompleteFetchTaskOnRequestCompleted|0(AsyncOperation rawOperation) { }
}

// Namespace: Unity.Services.Core.Internal
[Extension]
internal static class UnityWebRequestUtils // TypeDefIndex: 28130
{
	// Methods

	[Extension]
	// RVA: 0x8638818 Offset: 0x8634818 VA: 0x8638818
	public static bool HasSucceeded(UnityWebRequest self) { }

	// RVA: 0x863883C Offset: 0x863483C VA: 0x863883C
	public static Task<string> GetTextAsync(string uri) { }
}

// Namespace: Unity.Services.Core.Internal.Serialization
internal interface IJsonSerializer // TypeDefIndex: 28131
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T DeserializeObject<T>(string value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IJsonSerializer.DeserializeObject<__Il2CppFullySharedGenericType>
	|-IJsonSerializer.DeserializeObject<SerializableProjectConfiguration>
	*/
}

// Namespace: Unity.Services.Core.Internal.Serialization
internal class NewtonsoftSerializer : IJsonSerializer // TypeDefIndex: 28132
{
	// Fields
	private readonly JsonSerializer m_Serializer; // 0x10

	// Methods

	// RVA: 0x8638D40 Offset: 0x8634D40 VA: 0x8638D40
	public void .ctor(JsonSerializerSettings settings) { }

	// RVA: 0x8638D80 Offset: 0x8634D80 VA: 0x8638D80
	internal void .ctor(JsonSerializer serializer) { }

	// RVA: -1 Offset: -1 Slot: 4
	public T DeserializeObject<T>(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x468229C Offset: 0x467E29C VA: 0x468229C
	|-NewtonsoftSerializer.DeserializeObject<SerializableProjectConfiguration>
	|
	|-RVA: 0x4682520 Offset: 0x467E520 VA: 0x4682520
	|-NewtonsoftSerializer.DeserializeObject<__Il2CppFullySharedGenericType>
	*/
}

