// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28942
{}

// Namespace: Unity.Services.Core
internal class ExternalUserIdProperty // TypeDefIndex: 28943
{
	// Fields
	[CompilerGenerated]
	private Action<string> UserIdChanged; // 0x10
	private string m_UserId; // 0x18

	// Properties
	public string UserId { get; set; }

	// Methods

	// RVA: 0x8630798 Offset: 0x862C798 VA: 0x8630798
	public string get_UserId() { }

	// RVA: 0x86307A0 Offset: 0x862C7A0 VA: 0x86307A0
	public void set_UserId(string value) { }

	// RVA: 0x86307DC Offset: 0x862C7DC VA: 0x86307DC
	public void .ctor() { }
}

// Namespace: Unity.Services.Core
public class InitializationOptions // TypeDefIndex: 28944
{
	// Fields
	[CompilerGenerated]
	private readonly IDictionary<string, object> <Values>k__BackingField; // 0x10

	// Properties
	internal IDictionary<string, object> Values { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x86307E4 Offset: 0x862C7E4 VA: 0x86307E4
	internal IDictionary<string, object> get_Values() { }

	// RVA: 0x86307EC Offset: 0x862C7EC VA: 0x86307EC
	internal void .ctor(IDictionary<string, object> values) { }

	// RVA: 0x863081C Offset: 0x862C81C VA: 0x863081C
	internal void .ctor(InitializationOptions source) { }
}

// Namespace: Unity.Services.Core
public class ServicesInitializationException : Exception // TypeDefIndex: 28945
{
	// Methods

	// RVA: 0x86308B0 Offset: 0x862C8B0 VA: 0x86308B0
	public void .ctor() { }

	// RVA: 0x8630908 Offset: 0x862C908 VA: 0x8630908
	public void .ctor(string message) { }

	// RVA: 0x8630970 Offset: 0x862C970 VA: 0x8630970
	public void .ctor(string message, Exception innerException) { }
}

// Namespace: Unity.Services.Core
public enum ServicesInitializationState // TypeDefIndex: 28946
{
	// Fields
	public int value__; // 0x0
	public const ServicesInitializationState Uninitialized = 0;
	public const ServicesInitializationState Initializing = 1;
	public const ServicesInitializationState Initialized = 2;
}

// Namespace: Unity.Services.Core
internal class UnityProjectNotLinkedException : ServicesInitializationException // TypeDefIndex: 28947
{
	// Methods

	// RVA: 0x86309E0 Offset: 0x862C9E0 VA: 0x86309E0
	public void .ctor(string message) { }
}

// Namespace: Unity.Services.Core
public interface IUnityServices // TypeDefIndex: 28948
{}

// Namespace: Unity.Services.Core
public static class UnityServices // TypeDefIndex: 28949
{
	// Fields
	[CompilerGenerated]
	private static IUnityServices <Instance>k__BackingField; // 0x0
	[CompilerGenerated]
	private static TaskCompletionSource<object> <InstantiationCompletion>k__BackingField; // 0x8
	internal static ExternalUserIdProperty ExternalUserIdProperty; // 0x10
	[CompilerGenerated]
	private static readonly Dictionary<string, IUnityServices> <s_Services>k__BackingField; // 0x18

	// Properties
	public static IUnityServices Instance { get; set; }
	internal static TaskCompletionSource<object> InstantiationCompletion { get; }
	private static Dictionary<string, IUnityServices> s_Services { get; }
	public static string ExternalUserId { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x86309E4 Offset: 0x862C9E4 VA: 0x86309E4
	public static IUnityServices get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x8630A3C Offset: 0x862CA3C VA: 0x8630A3C
	public static void set_Instance(IUnityServices value) { }

	[CompilerGenerated]
	// RVA: 0x8630AA4 Offset: 0x862CAA4 VA: 0x8630AA4
	internal static TaskCompletionSource<object> get_InstantiationCompletion() { }

	[CompilerGenerated]
	// RVA: 0x8630AFC Offset: 0x862CAFC VA: 0x8630AFC
	private static Dictionary<string, IUnityServices> get_s_Services() { }

	// RVA: 0x8630B54 Offset: 0x862CB54 VA: 0x8630B54
	public static string get_ExternalUserId() { }

	// RVA: 0x8630BB8 Offset: 0x862CBB8 VA: 0x8630BB8
	public static void set_ExternalUserId(string value) { }

	// RVA: 0x8630C20 Offset: 0x862CC20 VA: 0x8630C20
	internal static void ClearServices() { }

	// RVA: 0x8630CC8 Offset: 0x862CCC8 VA: 0x8630CC8
	private static void .cctor() { }
}

// Namespace: 
internal sealed class UnityServicesBuilder.CreationDelegate : MulticastDelegate // TypeDefIndex: 28950
{
	// Methods

	// RVA: 0x8630DEC Offset: 0x862CDEC VA: 0x8630DEC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x8630E9C Offset: 0x862CE9C VA: 0x8630E9C Slot: 13
	public virtual IUnityServices Invoke(string servicesId) { }
}

// Namespace: Unity.Services.Core
internal static class UnityServicesBuilder // TypeDefIndex: 28951
{
	// Fields
	[CompilerGenerated]
	private static UnityServicesBuilder.CreationDelegate <InstanceCreationDelegate>k__BackingField; // 0x0

	// Properties
	internal static UnityServicesBuilder.CreationDelegate InstanceCreationDelegate { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8630D94 Offset: 0x862CD94 VA: 0x8630D94
	internal static void set_InstanceCreationDelegate(UnityServicesBuilder.CreationDelegate value) { }
}

// Namespace: Unity.Services.Core
internal static class UnityThreadUtils // TypeDefIndex: 28952
{
	// Fields
	private static int s_UnityThreadId; // 0x0
	[CompilerGenerated]
	private static TaskScheduler <UnityThreadScheduler>k__BackingField; // 0x8

	// Properties
	private static TaskScheduler UnityThreadScheduler { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8630EB0 Offset: 0x862CEB0 VA: 0x8630EB0
	private static void set_UnityThreadScheduler(TaskScheduler value) { }

	[RuntimeInitializeOnLoadMethod(4)]
	// RVA: 0x8630F00 Offset: 0x862CF00 VA: 0x8630F00
	private static void CaptureUnityThreadInfo() { }
}

