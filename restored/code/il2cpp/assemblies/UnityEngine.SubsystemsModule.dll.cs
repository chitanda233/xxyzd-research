// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28590
{}

// Namespace: UnityEngine
public interface ISubsystem // TypeDefIndex: 28591
{
	// Properties
	public abstract bool running { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_running();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Start();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Stop();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Destroy();
}

// Namespace: UnityEngine
public interface ISubsystemDescriptor // TypeDefIndex: 28592
{
	// Properties
	public abstract string id { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_id();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract ISubsystem Create();
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Modules/Subsystems/Subsystem.h")]
public class IntegratedSubsystem : ISubsystem // TypeDefIndex: 28593
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	internal ISubsystemDescriptor m_SubsystemDescriptor; // 0x18

	// Properties
	public bool running { get; }
	internal bool valid { get; }

	// Methods

	// RVA: 0x87E4380 Offset: 0x87E0380 VA: 0x87E4380
	internal void SetHandle(IntegratedSubsystem subsystem) { }

	// RVA: 0x87E43C4 Offset: 0x87E03C4 VA: 0x87E43C4 Slot: 5
	public void Start() { }

	// RVA: 0x87E4400 Offset: 0x87E0400 VA: 0x87E4400 Slot: 6
	public void Stop() { }

	// RVA: 0x87E443C Offset: 0x87E043C VA: 0x87E443C Slot: 7
	public void Destroy() { }

	// RVA: 0x87E4658 Offset: 0x87E0658 VA: 0x87E4658 Slot: 4
	public bool get_running() { }

	// RVA: 0x87E46B8 Offset: 0x87E06B8 VA: 0x87E46B8
	internal bool get_valid() { }

	// RVA: 0x87E46C8 Offset: 0x87E06C8 VA: 0x87E46C8
	internal bool IsRunning() { }

	// RVA: 0x87E4704 Offset: 0x87E0704 VA: 0x87E4704
	public void .ctor() { }
}

// Namespace: UnityEngine
[UsedByNativeCode("Subsystem_TSubsystemDescriptor")]
public class IntegratedSubsystem<TSubsystemDescriptor> : IntegratedSubsystem // TypeDefIndex: 28594
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499C38C Offset: 0x499838C VA: 0x499C38C
	|-IntegratedSubsystem<object>..ctor
	|
	|-RVA: 0x499C394 Offset: 0x4998394 VA: 0x499C394
	|-IntegratedSubsystem<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: UnityEngine
internal static class SubsystemBindings // TypeDefIndex: 28595
{
	// Methods

	// RVA: 0x87E461C Offset: 0x87E061C VA: 0x87E461C
	internal static void DestroySubsystem(IntPtr nativePtr) { }
}

// Namespace: UnityEngine
[UsedByNativeCode("SubsystemDescriptorBase")]
public abstract class IntegratedSubsystemDescriptor : ISubsystemDescriptor // TypeDefIndex: 28596
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public string id { get; }

	// Methods

	// RVA: 0x87E470C Offset: 0x87E070C VA: 0x87E470C Slot: 4
	public string get_id() { }

	// RVA: 0x87E4784 Offset: 0x87E0784 VA: 0x87E4784 Slot: 5
	private ISubsystem UnityEngine.ISubsystemDescriptor.Create() { }

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract ISubsystem CreateImpl();

	// RVA: 0x87E4790 Offset: 0x87E0790 VA: 0x87E4790
	protected void .ctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Subsystems/SubsystemDescriptor.h")]
[UsedByNativeCode("SubsystemDescriptor")]
public class IntegratedSubsystemDescriptor<TSubsystem> : IntegratedSubsystemDescriptor // TypeDefIndex: 28597
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	internal override ISubsystem CreateImpl() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499C298 Offset: 0x4998298 VA: 0x499C298
	|-IntegratedSubsystemDescriptor<object>.CreateImpl
	*/

	// RVA: -1 Offset: -1
	public TSubsystem Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499C2A8 Offset: 0x49982A8 VA: 0x499C2A8
	|-IntegratedSubsystemDescriptor<object>.Create
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499C384 Offset: 0x4998384 VA: 0x499C384
	|-IntegratedSubsystemDescriptor<object>..ctor
	*/
}

// Namespace: UnityEngine
internal static class SubsystemDescriptorBindings // TypeDefIndex: 28598
{
	// Methods

	// RVA: 0x87E4798 Offset: 0x87E0798 VA: 0x87E4798
	public static IntPtr Create(IntPtr descriptorPtr) { }

	// RVA: 0x87E4748 Offset: 0x87E0748 VA: 0x87E4748
	public static string GetId(IntPtr descriptorPtr) { }
}

// Namespace: UnityEngine
public abstract class Subsystem : ISubsystem // TypeDefIndex: 28599
{
	// Properties
	public abstract bool running { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_running();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Start();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Stop();

	// RVA: 0x87E47D4 Offset: 0x87E07D4 VA: 0x87E47D4 Slot: 7
	public void Destroy() { }

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnDestroy();

	// RVA: 0x87E48C8 Offset: 0x87E08C8 VA: 0x87E48C8
	protected void .ctor() { }
}

// Namespace: UnityEngine
public abstract class SubsystemDescriptor : ISubsystemDescriptor // TypeDefIndex: 28600
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <id>k__BackingField; // 0x10

	// Properties
	public string id { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x87E48D0 Offset: 0x87E08D0 VA: 0x87E48D0 Slot: 4
	public string get_id() { }

	// RVA: 0x87E48D8 Offset: 0x87E08D8 VA: 0x87E48D8 Slot: 5
	private ISubsystem UnityEngine.ISubsystemDescriptor.Create() { }

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract ISubsystem CreateImpl();

	// RVA: 0x87E48E4 Offset: 0x87E08E4 VA: 0x87E48E4
	protected void .ctor() { }
}

// Namespace: UnityEngine
internal static class Internal_SubsystemDescriptors // TypeDefIndex: 28601
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x87E48EC Offset: 0x87E08EC VA: 0x87E48EC
	internal static void Internal_AddDescriptor(SubsystemDescriptor descriptor) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Subsystems/SubsystemManager.h")]
public static class SubsystemManager // TypeDefIndex: 28602
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action beforeReloadSubsystems; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action afterReloadSubsystems; // 0x8
	private static List<IntegratedSubsystem> s_IntegratedSubsystems; // 0x10
	private static List<SubsystemWithProvider> s_StandaloneSubsystems; // 0x18
	private static List<Subsystem> s_DeprecatedSubsystems; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action reloadSubsytemsStarted; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action reloadSubsytemsCompleted; // 0x30

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x87E49B8 Offset: 0x87E09B8 VA: 0x87E49B8
	private static void ReloadSubsystemsStarted() { }

	[RequiredByNativeCode]
	// RVA: 0x87E4A98 Offset: 0x87E0A98 VA: 0x87E4A98
	private static void ReloadSubsystemsCompleted() { }

	[RequiredByNativeCode]
	// RVA: 0x87E4B78 Offset: 0x87E0B78 VA: 0x87E4B78
	private static void InitializeIntegratedSubsystem(IntPtr ptr, IntegratedSubsystem subsystem) { }

	[RequiredByNativeCode]
	// RVA: 0x87E4C84 Offset: 0x87E0C84 VA: 0x87E4C84
	private static void ClearSubsystems() { }

	// RVA: 0x87E4ED0 Offset: 0x87E0ED0 VA: 0x87E4ED0
	private static void StaticConstructScriptingClassMap() { }

	// RVA: 0x87E4EF8 Offset: 0x87E0EF8 VA: 0x87E4EF8
	private static void .cctor() { }

	// RVA: -1 Offset: -1
	public static void GetSubsystemDescriptors<T>(List<T> descriptors) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x470DD90 Offset: 0x4709D90 VA: 0x470DD90
	|-SubsystemManager.GetSubsystemDescriptors<object>
	|
	|-RVA: 0x470DDF4 Offset: 0x4709DF4 VA: 0x470DDF4
	|-SubsystemManager.GetSubsystemDescriptors<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void GetSubsystems<T>(List<T> subsystems) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x470DE5C Offset: 0x4709E5C VA: 0x470DE5C
	|-SubsystemManager.GetSubsystems<object>
	|
	|-RVA: 0x470DF30 Offset: 0x4709F30 VA: 0x470DF30
	|-SubsystemManager.GetSubsystems<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void AddSubsystemSubset<TBaseTypeInList, TQueryType>(List<TBaseTypeInList> copyFrom, List<TQueryType> copyTo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x470D6C0 Offset: 0x47096C0 VA: 0x470D6C0
	|-SubsystemManager.AddSubsystemSubset<object, object>
	|
	|-RVA: 0x470D8D8 Offset: 0x47098D8 VA: 0x470D8D8
	|-SubsystemManager.AddSubsystemSubset<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x87E5058 Offset: 0x87E1058 VA: 0x87E5058
	internal static IntegratedSubsystem GetIntegratedSubsystemByPtr(IntPtr ptr) { }

	// RVA: 0x87E44C4 Offset: 0x87E04C4 VA: 0x87E44C4
	internal static void RemoveIntegratedSubsystemByPtr(IntPtr ptr) { }

	// RVA: 0x87E51DC Offset: 0x87E11DC VA: 0x87E51DC
	internal static void AddStandaloneSubsystem(SubsystemWithProvider subsystem) { }

	// RVA: 0x87E52B0 Offset: 0x87E12B0 VA: 0x87E52B0
	internal static bool RemoveStandaloneSubsystem(SubsystemWithProvider subsystem) { }

	// RVA: 0x87E5330 Offset: 0x87E1330 VA: 0x87E5330
	internal static SubsystemWithProvider FindStandaloneSubsystemByDescriptor(SubsystemDescriptorWithProvider descriptor) { }

	// RVA: -1 Offset: -1
	public static void GetInstances<T>(List<T> subsystems) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x470DCC4 Offset: 0x4709CC4 VA: 0x470DCC4
	|-SubsystemManager.GetInstances<object>
	|
	|-RVA: 0x470DD28 Offset: 0x4709D28 VA: 0x470DD28
	|-SubsystemManager.GetInstances<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x87E4848 Offset: 0x87E0848 VA: 0x87E4848
	internal static bool RemoveDeprecatedSubsystem(Subsystem subsystem) { }
}

// Namespace: UnityEngine.SubsystemsImplementation
[NativeHeader("Modules/Subsystems/SubsystemManager.h")]
public static class SubsystemDescriptorStore // TypeDefIndex: 28603
{
	// Fields
	private static List<IntegratedSubsystemDescriptor> s_IntegratedDescriptors; // 0x0
	private static List<SubsystemDescriptorWithProvider> s_StandaloneDescriptors; // 0x8
	private static List<SubsystemDescriptor> s_DeprecatedDescriptors; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x87E54B8 Offset: 0x87E14B8 VA: 0x87E54B8
	internal static void InitializeManagedDescriptor(IntPtr ptr, IntegratedSubsystemDescriptor desc) { }

	[RequiredByNativeCode]
	// RVA: 0x87E5598 Offset: 0x87E1598 VA: 0x87E5598
	internal static void ClearManagedDescriptors() { }

	// RVA: 0x87E5754 Offset: 0x87E1754 VA: 0x87E5754
	private static void ReportSingleSubsystemAnalytics(string id) { }

	// RVA: 0x87E5790 Offset: 0x87E1790 VA: 0x87E5790
	public static void RegisterDescriptor(SubsystemDescriptorWithProvider descriptor) { }

	// RVA: -1 Offset: -1
	internal static void GetSubsystemDescriptors<T>(List<T> descriptors) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x470CBDC Offset: 0x4708BDC VA: 0x470CBDC
	|-SubsystemDescriptorStore.GetSubsystemDescriptors<object>
	|
	|-RVA: 0x470CCB0 Offset: 0x4708CB0 VA: 0x470CCB0
	|-SubsystemDescriptorStore.GetSubsystemDescriptors<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void AddDescriptorSubset<TBaseTypeInList, TQueryType>(List<TBaseTypeInList> copyFrom, List<TQueryType> copyTo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x470C5D8 Offset: 0x47085D8 VA: 0x470C5D8
	|-SubsystemDescriptorStore.AddDescriptorSubset<object, object>
	|
	|-RVA: 0x470C7F0 Offset: 0x47087F0 VA: 0x470C7F0
	|-SubsystemDescriptorStore.AddDescriptorSubset<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static void RegisterDescriptor<TDescriptor, TBaseTypeInList>(TDescriptor descriptor, List<TBaseTypeInList> storeInList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x470CD80 Offset: 0x4708D80 VA: 0x470CD80
	|-SubsystemDescriptorStore.RegisterDescriptor<object, object>
	|
	|-RVA: 0x470D14C Offset: 0x470914C VA: 0x470D14C
	|-SubsystemDescriptorStore.RegisterDescriptor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x87E4940 Offset: 0x87E0940 VA: 0x87E4940
	internal static void RegisterDeprecatedDescriptor(SubsystemDescriptor descriptor) { }

	// RVA: 0x87E5820 Offset: 0x87E1820 VA: 0x87E5820
	private static void .cctor() { }
}

// Namespace: UnityEngine.SubsystemsImplementation
public abstract class SubsystemDescriptorWithProvider : ISubsystemDescriptor // TypeDefIndex: 28604
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <id>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Type <providerType>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Type <subsystemTypeOverride>k__BackingField; // 0x20

	// Properties
	public string id { get; set; }
	protected internal Type providerType { get; set; }
	protected internal Type subsystemTypeOverride { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x87E5968 Offset: 0x87E1968 VA: 0x87E5968 Slot: 4
	public string get_id() { }

	[CompilerGenerated]
	// RVA: 0x87E5970 Offset: 0x87E1970 VA: 0x87E5970
	public void set_id(string value) { }

	[CompilerGenerated]
	// RVA: 0x87E5978 Offset: 0x87E1978 VA: 0x87E5978
	protected internal Type get_providerType() { }

	[CompilerGenerated]
	// RVA: 0x87E5980 Offset: 0x87E1980 VA: 0x87E5980
	protected internal void set_providerType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x87E5988 Offset: 0x87E1988 VA: 0x87E5988
	protected internal Type get_subsystemTypeOverride() { }

	[CompilerGenerated]
	// RVA: 0x87E5990 Offset: 0x87E1990 VA: 0x87E5990
	protected internal void set_subsystemTypeOverride(Type value) { }

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract ISubsystem CreateImpl();

	// RVA: 0x87E5998 Offset: 0x87E1998 VA: 0x87E5998 Slot: 5
	private ISubsystem UnityEngine.ISubsystemDescriptor.Create() { }

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract void ThrowIfInvalid();

	// RVA: 0x87E59A4 Offset: 0x87E19A4 VA: 0x87E59A4
	protected void .ctor() { }
}

// Namespace: UnityEngine.SubsystemsImplementation
public class SubsystemDescriptorWithProvider<TSubsystem, TProvider> : SubsystemDescriptorWithProvider // TypeDefIndex: 28605
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	internal override ISubsystem CreateImpl() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5533B50 Offset: 0x552FB50 VA: 0x5533B50
	|-SubsystemDescriptorWithProvider<object, object>.CreateImpl
	*/

	// RVA: -1 Offset: -1
	public TSubsystem Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5533B60 Offset: 0x552FB60 VA: 0x5533B60
	|-SubsystemDescriptorWithProvider<object, object>.Create
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal sealed override void ThrowIfInvalid() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5533D50 Offset: 0x552FD50 VA: 0x5533D50
	|-SubsystemDescriptorWithProvider<object, object>.ThrowIfInvalid
	*/

	// RVA: -1 Offset: -1
	internal TProvider CreateProvider() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5533FEC Offset: 0x552FFEC VA: 0x5533FEC
	|-SubsystemDescriptorWithProvider<object, object>.CreateProvider
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5534074 Offset: 0x5530074 VA: 0x5534074
	|-SubsystemDescriptorWithProvider<object, object>..ctor
	*/
}

// Namespace: UnityEngine.SubsystemsImplementation
public abstract class SubsystemProvider // TypeDefIndex: 28606
{
	// Fields
	internal bool m_Running; // 0x10

	// Methods

	// RVA: 0x87E59AC Offset: 0x87E19AC VA: 0x87E59AC
	protected void .ctor() { }
}

// Namespace: UnityEngine.SubsystemsImplementation
public abstract class SubsystemProvider<TSubsystem> : SubsystemProvider // TypeDefIndex: 28607
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected internal virtual bool TryInitialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x553407C Offset: 0x553007C VA: 0x553407C
	|-SubsystemProvider<object>.TryInitialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Start();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SubsystemProvider<object>.Start
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Stop();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SubsystemProvider<object>.Stop
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Destroy();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SubsystemProvider<object>.Destroy
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5534084 Offset: 0x5530084 VA: 0x5534084
	|-SubsystemProvider<object>..ctor
	*/
}

// Namespace: UnityEngine.SubsystemsImplementation
public abstract class SubsystemWithProvider : ISubsystem // TypeDefIndex: 28608
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <running>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private SubsystemProvider <providerBase>k__BackingField; // 0x18

	// Properties
	public bool running { get; set; }
	internal SubsystemProvider providerBase { get; set; }
	internal abstract SubsystemDescriptorWithProvider descriptor { get; }

	// Methods

	// RVA: 0x87E59B4 Offset: 0x87E19B4 VA: 0x87E59B4 Slot: 5
	public void Start() { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void OnStart();

	// RVA: 0x87E59F0 Offset: 0x87E19F0 VA: 0x87E59F0 Slot: 6
	public void Stop() { }

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void OnStop();

	// RVA: 0x87E5A28 Offset: 0x87E1A28 VA: 0x87E5A28 Slot: 7
	public void Destroy() { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnDestroy();

	[CompilerGenerated]
	// RVA: 0x87E5AA4 Offset: 0x87E1AA4 VA: 0x87E5AA4 Slot: 4
	public bool get_running() { }

	[CompilerGenerated]
	// RVA: 0x87E5AAC Offset: 0x87E1AAC VA: 0x87E5AAC
	private void set_running(bool value) { }

	[CompilerGenerated]
	// RVA: 0x87E5AB8 Offset: 0x87E1AB8 VA: 0x87E5AB8
	internal SubsystemProvider get_providerBase() { }

	[CompilerGenerated]
	// RVA: 0x87E5AC0 Offset: 0x87E1AC0 VA: 0x87E5AC0
	internal void set_providerBase(SubsystemProvider value) { }

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract void Initialize(SubsystemDescriptorWithProvider descriptor, SubsystemProvider subsystemProvider);

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract SubsystemDescriptorWithProvider get_descriptor();

	// RVA: 0x87E5AC8 Offset: 0x87E1AC8 VA: 0x87E5AC8
	protected void .ctor() { }
}

// Namespace: UnityEngine.SubsystemsImplementation
public abstract class SubsystemWithProvider<TSubsystem, TSubsystemDescriptor, TProvider> : SubsystemWithProvider // TypeDefIndex: 28609
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private TSubsystemDescriptor <subsystemDescriptor>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private TProvider <provider>k__BackingField; // 0x0

	// Properties
	public TSubsystemDescriptor subsystemDescriptor { get; set; }
	protected internal TProvider provider { get; set; }
	internal sealed override SubsystemDescriptorWithProvider descriptor { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public TSubsystemDescriptor get_subsystemDescriptor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x553408C Offset: 0x553008C VA: 0x553408C
	|-SubsystemWithProvider<object, object, object>.get_subsystemDescriptor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_subsystemDescriptor(TSubsystemDescriptor value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5534094 Offset: 0x5530094 VA: 0x5534094
	|-SubsystemWithProvider<object, object, object>.set_subsystemDescriptor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected internal TProvider get_provider() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x553409C Offset: 0x553009C VA: 0x553409C
	|-SubsystemWithProvider<object, object, object>.get_provider
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_provider(TProvider value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55340A4 Offset: 0x55300A4 VA: 0x55340A4
	|-SubsystemWithProvider<object, object, object>.set_provider
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected virtual void OnCreate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55340AC Offset: 0x55300AC VA: 0x55340AC
	|-SubsystemWithProvider<object, object, object>.OnCreate
	*/

	// RVA: -1 Offset: -1 Slot: 8
	protected override void OnStart() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55340B0 Offset: 0x55300B0 VA: 0x55340B0
	|-SubsystemWithProvider<object, object, object>.OnStart
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override void OnStop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55340D0 Offset: 0x55300D0 VA: 0x55340D0
	|-SubsystemWithProvider<object, object, object>.OnStop
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override void OnDestroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55340F0 Offset: 0x55300F0 VA: 0x55340F0
	|-SubsystemWithProvider<object, object, object>.OnDestroy
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal sealed override void Initialize(SubsystemDescriptorWithProvider descriptor, SubsystemProvider provider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5534110 Offset: 0x5530110 VA: 0x5534110
	|-SubsystemWithProvider<object, object, object>.Initialize
	*/

	// RVA: -1 Offset: -1 Slot: 12
	internal sealed override SubsystemDescriptorWithProvider get_descriptor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5534208 Offset: 0x5530208 VA: 0x5534208
	|-SubsystemWithProvider<object, object, object>.get_descriptor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5534210 Offset: 0x5530210 VA: 0x5534210
	|-SubsystemWithProvider<object, object, object>..ctor
	*/
}

