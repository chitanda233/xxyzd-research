// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28707
{}

// Namespace: Sirenix.Serialization
public class CustomLogger : ILogger // TypeDefIndex: 28708
{
	// Fields
	private Action<string> logWarningDelegate; // 0x10
	private Action<string> logErrorDelegate; // 0x18
	private Action<Exception> logExceptionDelegate; // 0x20

	// Methods

	// RVA: 0x7E83DF4 Offset: 0x7E7FDF4 VA: 0x7E83DF4
	public void .ctor(Action<string> logWarningDelegate, Action<string> logErrorDelegate, Action<Exception> logExceptionDelegate) { }

	// RVA: 0x7E83EE8 Offset: 0x7E7FEE8 VA: 0x7E83EE8 Slot: 4
	public void LogWarning(string warning) { }

	// RVA: 0x7E83F0C Offset: 0x7E7FF0C VA: 0x7E83F0C Slot: 5
	public void LogError(string error) { }

	// RVA: 0x7E83F30 Offset: 0x7E7FF30 VA: 0x7E83F30 Slot: 6
	public void LogException(Exception exception) { }
}

// Namespace: Sirenix.Serialization
public enum DataFormat // TypeDefIndex: 28709
{
	// Fields
	public int value__; // 0x0
	public const DataFormat Binary = 0;
	public const DataFormat JSON = 1;
	public const DataFormat Nodes = 2;
}

// Namespace: Sirenix.Serialization
public static class DefaultLoggers // TypeDefIndex: 28710
{
	// Fields
	private static readonly object LOCK; // 0x0
	private static ILogger unityLogger; // 0x8

	// Properties
	public static ILogger DefaultLogger { get; }
	public static ILogger UnityLogger { get; }

	// Methods

	// RVA: 0x7E83F54 Offset: 0x7E7FF54 VA: 0x7E83F54
	public static ILogger get_DefaultLogger() { }

	// RVA: 0x7E83FA0 Offset: 0x7E7FFA0 VA: 0x7E83FA0
	public static ILogger get_UnityLogger() { }

	// RVA: 0x7E8422C Offset: 0x7E8022C VA: 0x7E8422C
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization
public enum ErrorHandlingPolicy // TypeDefIndex: 28711
{
	// Fields
	public int value__; // 0x0
	public const ErrorHandlingPolicy Resilient = 0;
	public const ErrorHandlingPolicy ThrowOnErrors = 1;
	public const ErrorHandlingPolicy ThrowOnWarningsAndErrors = 2;
}

// Namespace: Sirenix.Serialization
[SirenixGlobalConfig]
[HideMonoScript]
public class GlobalSerializationConfig : GlobalConfig<GlobalSerializationConfig> // TypeDefIndex: 28712
{
	// Fields
	public const string ODIN_SERIALIZATION_CAUTIONARY_WARNING_TEXT = "Odin\'s custom serialization protocol is stable and fast. It is built to be fast, reliable and resilient above all.\n\n*Words of caution* \nHowever, caveats apply - there is a reason Unity chose such a drastically limited serialization protocol. It keeps things simple and manageable, and limits how much complexity you can introduce into your data structures. It can be very easy to get carried away and shoot yourself in the foot when all limitations suddenly disappear, and hence we have included this cautionary warning.\n\nWarning words aside, there can of course be valid reasons to use a more powerful serialization protocol such as Odin\'s. However, we advise you to use it wisely and with restraint. After all, with great power comes great responsibility!";
	public const string ODIN_PREFAB_CAUTIONARY_WARNING_TEXT = "In 2018.3, Unity introduced a new prefab workflow, and in so doing, changed how all prefabs fundamentally work. Despite our best efforts, we have so far been unable to achieve a stable implementation of Odin-serialized prefab modifications on prefab instances and variants in the new prefab workflow.This has nothing to do with Odin serializer itself, which remains rock solid. Odin-serialized ScriptableObjects and non-prefab Components/Behaviours are still perfectly stable - you are only seeing this message because this is an Odin-serialized prefab asset or instance.\n\nUsing prefabs with Odin serialization in 2018.3 and above is considered a *deprecated feature* and is officially unsupported. In short, if you disregard this message and then experience issues, we will not be able to help or support you.\n\nPlease keep all this in mind, if you wish to continue using Odin-serialized prefabs.";
	public const string ODIN_SERIALIZATION_CAUTIONARY_WARNING_BUTTON_TEXT = "I know what I\'m about, son. Hide message forever.";
	public const string ODIN_PREFAB_CAUTIONARY_WARNING_BUTTON_TEXT = "I understand that I\'m on my own. Hide message forever.";
	private static readonly DataFormat[] BuildFormats; // 0x0
	[Title("Warning messages", null, 0, True, True)]
	[ToggleLeft]
	[DetailedInfoBox("Click to show warning message.", "Odin's custom serialization protocol is stable and fast. It is built to be fast, reliable and resilient above all.

*Words of caution* 
However, caveats apply - there is a reason Unity chose such a drastically limited serialization protocol. It keeps things simple and manageable, and limits how much complexity you can introduce into your data structures. It can be very easy to get carried away and shoot yourself in the foot when all limitations suddenly disappear, and hence we have included this cautionary warning.

Warning words aside, there can of course be valid reasons to use a more powerful serialization protocol such as Odin's. However, we advise you to use it wisely and with restraint. After all, with great power comes great responsibility!", 1, null)]
	public bool HideSerializationCautionaryMessage; // 0x18
	[DetailedInfoBox("Click to show warning message.", "In 2018.3, Unity introduced a new prefab workflow, and in so doing, changed how all prefabs fundamentally work. Despite our best efforts, we have so far been unable to achieve a stable implementation of Odin-serialized prefab modifications on prefab instances and variants in the new prefab workflow.This has nothing to do with Odin serializer itself, which remains rock solid. Odin-serialized ScriptableObjects and non-prefab Components/Behaviours are still perfectly stable - you are only seeing this message because this is an Odin-serialized prefab asset or instance.

Using prefabs with Odin serialization in 2018.3 and above is considered a *deprecated feature* and is officially unsupported. In short, if you disregard this message and then experience issues, we will not be able to help or support you.

Please keep all this in mind, if you wish to continue using Odin-serialized prefabs.", 1, null)]
	[ToggleLeft]
	public bool HidePrefabCautionaryMessage; // 0x19
	[InfoBox("Enabling this will hide all warning messages that will show up in the inspector when the OdinSerialize attribute potentially does not achieve the desired effect.", 1, null)]
	[SerializeField]
	[ToggleLeft]
	public bool HideOdinSerializeAttributeWarningMessages; // 0x1A
	[SerializeField]
	[InfoBox("Enabling this will hide all warning messages that show up when the SerializeField and the ShowInInspector attributes are used together on non-serialized fields or properties.", 1, null)]
	[LabelText("Hide Non-Serialized SerializeField/ShowInInspector Warning Messages")]
	[ToggleLeft]
	public bool HideNonSerializedShowInInspectorWarningMessages; // 0x1B
	[ValueDropdown("BuildFormats")]
	[Title("Data formatting options", null, 0, True, True)]
	[SerializeField]
	private DataFormat buildSerializationFormat; // 0x1C
	[SerializeField]
	private DataFormat editorSerializationFormat; // 0x20
	[SerializeField]
	[Title("Logging and error handling", null, 0, True, True)]
	private LoggingPolicy loggingPolicy; // 0x24
	[SerializeField]
	private ErrorHandlingPolicy errorHandlingPolicy; // 0x28

	// Properties
	public ILogger Logger { get; }
	public DataFormat EditorSerializationFormat { get; set; }
	public DataFormat BuildSerializationFormat { get; set; }
	public LoggingPolicy LoggingPolicy { get; set; }
	public ErrorHandlingPolicy ErrorHandlingPolicy { get; set; }

	// Methods

	// RVA: 0x7E842A8 Offset: 0x7E802A8 VA: 0x7E842A8
	public ILogger get_Logger() { }

	// RVA: 0x7E842F4 Offset: 0x7E802F4 VA: 0x7E842F4
	public DataFormat get_EditorSerializationFormat() { }

	// RVA: 0x7E842FC Offset: 0x7E802FC VA: 0x7E842FC
	public void set_EditorSerializationFormat(DataFormat value) { }

	// RVA: 0x7E84304 Offset: 0x7E80304 VA: 0x7E84304
	public DataFormat get_BuildSerializationFormat() { }

	// RVA: 0x7E8430C Offset: 0x7E8030C VA: 0x7E8430C
	public void set_BuildSerializationFormat(DataFormat value) { }

	// RVA: 0x7E84314 Offset: 0x7E80314 VA: 0x7E84314
	public LoggingPolicy get_LoggingPolicy() { }

	// RVA: 0x7E8431C Offset: 0x7E8031C VA: 0x7E8431C
	public void set_LoggingPolicy(LoggingPolicy value) { }

	// RVA: 0x7E84324 Offset: 0x7E80324 VA: 0x7E84324
	public ErrorHandlingPolicy get_ErrorHandlingPolicy() { }

	// RVA: 0x7E8432C Offset: 0x7E8032C VA: 0x7E8432C
	public void set_ErrorHandlingPolicy(ErrorHandlingPolicy value) { }

	[OnInspectorGUI]
	// RVA: 0x7E84334 Offset: 0x7E80334 VA: 0x7E84334
	private void OnInspectorGUI() { }

	// RVA: 0x7E847F8 Offset: 0x7E807F8 VA: 0x7E847F8
	public void .ctor() { }

	// RVA: 0x7E84848 Offset: 0x7E80848 VA: 0x7E84848
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization
public interface ILogger // TypeDefIndex: 28713
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void LogWarning(string warning);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void LogError(string error);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void LogException(Exception exception);
}

// Namespace: Sirenix.Serialization
public enum LoggingPolicy // TypeDefIndex: 28714
{
	// Fields
	public int value__; // 0x0
	public const LoggingPolicy LogErrors = 0;
	public const LoggingPolicy LogWarningsAndErrors = 1;
	public const LoggingPolicy Silent = 2;
}

