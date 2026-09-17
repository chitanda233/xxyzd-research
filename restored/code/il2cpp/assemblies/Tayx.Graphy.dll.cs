// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 27645
{}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 27646
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
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 27647
{
	// Methods

	// RVA: 0x8470E9C Offset: 0x846CE9C VA: 0x8470E9C
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x8470F94 Offset: 0x846CF94 VA: 0x8470F94
	public void .ctor() { }
}

// Namespace: Graphy.Runtime.UI
[RequireComponent(typeof(RectTransform))]
public sealed class G_SafeArea : MonoBehaviour // TypeDefIndex: 27648
{
	// Fields
	[SerializeField]
	private bool m_conformX; // 0x20
	[SerializeField]
	private bool m_conformY; // 0x21
	private RectTransform m_rectTransform; // 0x28
	private Rect m_lastSafeArea; // 0x30

	// Methods

	// RVA: 0x8470F9C Offset: 0x846CF9C VA: 0x8470F9C
	private void Awake() { }

	// RVA: 0x8471050 Offset: 0x846D050 VA: 0x8471050
	private void Update() { }

	// RVA: 0x8470FFC Offset: 0x846CFFC VA: 0x8470FFC
	private void Refresh() { }

	// RVA: 0x8471054 Offset: 0x846D054 VA: 0x8471054
	private void ApplySafeArea(Rect r) { }

	// RVA: 0x847114C Offset: 0x846D14C VA: 0x847114C
	public void .ctor() { }
}

// Namespace: 
public enum GraphyDebugger.DebugVariable // TypeDefIndex: 27649
{
	// Fields
	public int value__; // 0x0
	public const GraphyDebugger.DebugVariable Fps = 0;
	public const GraphyDebugger.DebugVariable Fps_Min = 1;
	public const GraphyDebugger.DebugVariable Fps_Max = 2;
	public const GraphyDebugger.DebugVariable Fps_Avg = 3;
	public const GraphyDebugger.DebugVariable Ram_Allocated = 4;
	public const GraphyDebugger.DebugVariable Ram_Reserved = 5;
	public const GraphyDebugger.DebugVariable Ram_Mono = 6;
	public const GraphyDebugger.DebugVariable Audio_DB = 7;
}

// Namespace: 
public enum GraphyDebugger.DebugComparer // TypeDefIndex: 27650
{
	// Fields
	public int value__; // 0x0
	public const GraphyDebugger.DebugComparer Less_than = 0;
	public const GraphyDebugger.DebugComparer Equals_or_less_than = 1;
	public const GraphyDebugger.DebugComparer Equals = 2;
	public const GraphyDebugger.DebugComparer Equals_or_greater_than = 3;
	public const GraphyDebugger.DebugComparer Greater_than = 4;
}

// Namespace: 
public enum GraphyDebugger.ConditionEvaluation // TypeDefIndex: 27651
{
	// Fields
	public int value__; // 0x0
	public const GraphyDebugger.ConditionEvaluation All_conditions_must_be_met = 0;
	public const GraphyDebugger.ConditionEvaluation Only_one_condition_has_to_be_met = 1;
}

// Namespace: 
public enum GraphyDebugger.MessageType // TypeDefIndex: 27652
{
	// Fields
	public int value__; // 0x0
	public const GraphyDebugger.MessageType Log = 0;
	public const GraphyDebugger.MessageType Warning = 1;
	public const GraphyDebugger.MessageType Error = 2;
}

// Namespace: 
[Serializable]
public struct GraphyDebugger.DebugCondition // TypeDefIndex: 27653
{
	// Fields
	[Tooltip("Variable to compare against")]
	public GraphyDebugger.DebugVariable Variable; // 0x0
	[Tooltip("Comparer operator to use")]
	public GraphyDebugger.DebugComparer Comparer; // 0x4
	[Tooltip("Value to compare against the chosen variable")]
	public float Value; // 0x8
}

// Namespace: 
[Serializable]
public class GraphyDebugger.DebugPacket // TypeDefIndex: 27654
{
	// Fields
	[Tooltip("If false, it won't be checked")]
	public bool Active; // 0x10
	[Tooltip("Optional Id. It's used to get or remove DebugPackets in runtime")]
	public int Id; // 0x14
	[Tooltip("If true, once the actions are executed, this DebugPacket will delete itself")]
	public bool ExecuteOnce; // 0x18
	[Tooltip("Time to wait before checking if conditions are met (use this to avoid low fps drops triggering the conditions when loading the game)")]
	public float InitSleepTime; // 0x1C
	[Tooltip("Time to wait before checking if conditions are met again (once they have already been met and if ExecuteOnce is false)")]
	public float ExecuteSleepTime; // 0x20
	public GraphyDebugger.ConditionEvaluation ConditionEvaluation; // 0x24
	[Tooltip("List of conditions that will be checked each frame")]
	public List<GraphyDebugger.DebugCondition> DebugConditions; // 0x28
	public GraphyDebugger.MessageType MessageType; // 0x30
	[Multiline]
	public string Message; // 0x38
	public bool TakeScreenshot; // 0x40
	public string ScreenshotFileName; // 0x48
	[Tooltip("If true, it pauses the editor")]
	public bool DebugBreak; // 0x50
	public UnityEvent UnityEvents; // 0x58
	public List<Action> Callbacks; // 0x60
	private bool canBeChecked; // 0x68
	private bool executed; // 0x69
	private float timePassed; // 0x6C

	// Properties
	public bool Check { get; }

	// Methods

	// RVA: 0x8472B50 Offset: 0x846EB50 VA: 0x8472B50
	public bool get_Check() { }

	// RVA: 0x847241C Offset: 0x846E41C VA: 0x847241C
	public void Update() { }

	// RVA: 0x8472B44 Offset: 0x846EB44 VA: 0x8472B44
	public void Executed() { }

	// RVA: 0x847196C Offset: 0x846D96C VA: 0x847196C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class GraphyDebugger.<>c // TypeDefIndex: 27655
{
	// Fields
	public static readonly GraphyDebugger.<>c <>9; // 0x0
	public static Predicate<GraphyDebugger.DebugPacket> <>9__24_0; // 0x8

	// Methods

	// RVA: 0x8472B58 Offset: 0x846EB58 VA: 0x8472B58
	private static void .cctor() { }

	// RVA: 0x8472BC0 Offset: 0x846EBC0 VA: 0x8472BC0
	public void .ctor() { }

	// RVA: 0x8472BC8 Offset: 0x846EBC8 VA: 0x8472BC8
	internal bool <CheckDebugPackets>b__24_0(GraphyDebugger.DebugPacket packet) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GraphyDebugger.<>c__DisplayClass18_0 // TypeDefIndex: 27656
{
	// Fields
	public int packetId; // 0x10

	// Methods

	// RVA: 0x8471ED8 Offset: 0x846DED8 VA: 0x8471ED8
	public void .ctor() { }

	// RVA: 0x8472BD4 Offset: 0x846EBD4 VA: 0x8472BD4
	internal bool <GetFirstDebugPacketWithId>b__0(GraphyDebugger.DebugPacket x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GraphyDebugger.<>c__DisplayClass19_0 // TypeDefIndex: 27657
{
	// Fields
	public int packetId; // 0x10

	// Methods

	// RVA: 0x8471FB8 Offset: 0x846DFB8 VA: 0x8471FB8
	public void .ctor() { }

	// RVA: 0x8472BF8 Offset: 0x846EBF8 VA: 0x8472BF8
	internal bool <GetAllDebugPacketsWithId>b__0(GraphyDebugger.DebugPacket x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GraphyDebugger.<>c__DisplayClass21_0 // TypeDefIndex: 27658
{
	// Fields
	public int packetId; // 0x10

	// Methods

	// RVA: 0x8472134 Offset: 0x846E134 VA: 0x8472134
	public void .ctor() { }

	// RVA: 0x8472C1C Offset: 0x846EC1C VA: 0x8472C1C
	internal bool <RemoveAllDebugPacketsWithId>b__0(GraphyDebugger.DebugPacket x) { }
}

// Namespace: Tayx.Graphy
public class GraphyDebugger : G_Singleton<GraphyDebugger> // TypeDefIndex: 27659
{
	// Fields
	[SerializeField]
	private List<GraphyDebugger.DebugPacket> m_debugPackets; // 0x20
	private G_FpsMonitor m_fpsMonitor; // 0x28
	private G_RamMonitor m_ramMonitor; // 0x30
	private G_AudioMonitor m_audioMonitor; // 0x38

	// Methods

	// RVA: 0x8471160 Offset: 0x846D160 VA: 0x8471160
	protected void .ctor() { }

	// RVA: 0x8471220 Offset: 0x846D220 VA: 0x8471220
	private void Start() { }

	// RVA: 0x84712E0 Offset: 0x846D2E0 VA: 0x84712E0
	private void Update() { }

	// RVA: 0x8471704 Offset: 0x846D704 VA: 0x8471704
	public void AddNewDebugPacket(GraphyDebugger.DebugPacket newDebugPacket) { }

	// RVA: 0x84717BC Offset: 0x846D7BC VA: 0x84717BC
	public void AddNewDebugPacket(int newId, GraphyDebugger.DebugCondition newDebugCondition, GraphyDebugger.MessageType newMessageType, string newMessage, bool newDebugBreak, Action newCallback) { }

	// RVA: 0x8471AB4 Offset: 0x846DAB4 VA: 0x8471AB4
	public void AddNewDebugPacket(int newId, List<GraphyDebugger.DebugCondition> newDebugConditions, GraphyDebugger.MessageType newMessageType, string newMessage, bool newDebugBreak, Action newCallback) { }

	// RVA: 0x8471BF0 Offset: 0x846DBF0 VA: 0x8471BF0
	public void AddNewDebugPacket(int newId, GraphyDebugger.DebugCondition newDebugCondition, GraphyDebugger.MessageType newMessageType, string newMessage, bool newDebugBreak, List<Action> newCallbacks) { }

	// RVA: 0x8471D34 Offset: 0x846DD34 VA: 0x8471D34
	public void AddNewDebugPacket(int newId, List<GraphyDebugger.DebugCondition> newDebugConditions, GraphyDebugger.MessageType newMessageType, string newMessage, bool newDebugBreak, List<Action> newCallbacks) { }

	// RVA: 0x8471E04 Offset: 0x846DE04 VA: 0x8471E04
	public GraphyDebugger.DebugPacket GetFirstDebugPacketWithId(int packetId) { }

	// RVA: 0x8471EE0 Offset: 0x846DEE0 VA: 0x8471EE0
	public List<GraphyDebugger.DebugPacket> GetAllDebugPacketsWithId(int packetId) { }

	// RVA: 0x8471FC0 Offset: 0x846DFC0 VA: 0x8471FC0
	public void RemoveFirstDebugPacketWithId(int packetId) { }

	// RVA: 0x847204C Offset: 0x846E04C VA: 0x847204C
	public void RemoveAllDebugPacketsWithId(int packetId) { }

	// RVA: 0x847213C Offset: 0x846E13C VA: 0x847213C
	public void AddCallbackToFirstDebugPacketWithId(Action callback, int id) { }

	// RVA: 0x8472228 Offset: 0x846E228 VA: 0x8472228
	public void AddCallbackToAllDebugPacketWithId(Action callback, int id) { }

	// RVA: 0x84712E4 Offset: 0x846D2E4 VA: 0x84712E4
	private void CheckDebugPackets() { }

	// RVA: 0x8472478 Offset: 0x846E478 VA: 0x8472478
	private bool CheckIfConditionIsMet(GraphyDebugger.DebugCondition debugCondition) { }

	// RVA: 0x8472950 Offset: 0x846E950 VA: 0x8472950
	private float GetRequestedValueFromDebugVariable(GraphyDebugger.DebugVariable debugVariable) { }

	// RVA: 0x847256C Offset: 0x846E56C VA: 0x847256C
	private void ExecuteOperationsInDebugPacket(GraphyDebugger.DebugPacket debugPacket) { }
}

// Namespace: 
public enum GraphyManager.Mode // TypeDefIndex: 27660
{
	// Fields
	public int value__; // 0x0
	public const GraphyManager.Mode FULL = 0;
	public const GraphyManager.Mode LIGHT = 1;
}

// Namespace: 
public enum GraphyManager.ModuleType // TypeDefIndex: 27661
{
	// Fields
	public int value__; // 0x0
	public const GraphyManager.ModuleType FPS = 0;
	public const GraphyManager.ModuleType RAM = 1;
	public const GraphyManager.ModuleType AUDIO = 2;
	public const GraphyManager.ModuleType ADVANCED = 3;
}

// Namespace: 
public enum GraphyManager.ModuleState // TypeDefIndex: 27662
{
	// Fields
	public int value__; // 0x0
	public const GraphyManager.ModuleState FULL = 0;
	public const GraphyManager.ModuleState TEXT = 1;
	public const GraphyManager.ModuleState BASIC = 2;
	public const GraphyManager.ModuleState BACKGROUND = 3;
	public const GraphyManager.ModuleState OFF = 4;
}

// Namespace: 
public enum GraphyManager.ModulePosition // TypeDefIndex: 27663
{
	// Fields
	public int value__; // 0x0
	public const GraphyManager.ModulePosition TOP_RIGHT = 0;
	public const GraphyManager.ModulePosition TOP_LEFT = 1;
	public const GraphyManager.ModulePosition BOTTOM_RIGHT = 2;
	public const GraphyManager.ModulePosition BOTTOM_LEFT = 3;
	public const GraphyManager.ModulePosition FREE = 4;
}

// Namespace: 
public enum GraphyManager.LookForAudioListener // TypeDefIndex: 27664
{
	// Fields
	public int value__; // 0x0
	public const GraphyManager.LookForAudioListener ALWAYS = 0;
	public const GraphyManager.LookForAudioListener ON_SCENE_LOAD = 1;
	public const GraphyManager.LookForAudioListener NEVER = 2;
}

// Namespace: 
public enum GraphyManager.ModulePreset // TypeDefIndex: 27665
{
	// Fields
	public int value__; // 0x0
	public const GraphyManager.ModulePreset FPS_BASIC = 0;
	public const GraphyManager.ModulePreset FPS_TEXT = 1;
	public const GraphyManager.ModulePreset FPS_FULL = 2;
	public const GraphyManager.ModulePreset FPS_TEXT_RAM_TEXT = 3;
	public const GraphyManager.ModulePreset FPS_FULL_RAM_TEXT = 4;
	public const GraphyManager.ModulePreset FPS_FULL_RAM_FULL = 5;
	public const GraphyManager.ModulePreset FPS_TEXT_RAM_TEXT_AUDIO_TEXT = 6;
	public const GraphyManager.ModulePreset FPS_FULL_RAM_TEXT_AUDIO_TEXT = 7;
	public const GraphyManager.ModulePreset FPS_FULL_RAM_FULL_AUDIO_TEXT = 8;
	public const GraphyManager.ModulePreset FPS_FULL_RAM_FULL_AUDIO_FULL = 9;
	public const GraphyManager.ModulePreset FPS_FULL_RAM_FULL_AUDIO_FULL_ADVANCED_FULL = 10;
	public const GraphyManager.ModulePreset FPS_BASIC_ADVANCED_FULL = 11;
}

// Namespace: Tayx.Graphy
public class GraphyManager : G_Singleton<GraphyManager> // TypeDefIndex: 27666
{
	// Fields
	[SerializeField]
	private GraphyManager.Mode m_graphyMode; // 0x20
	[SerializeField]
	private bool m_enableOnStartup; // 0x24
	[SerializeField]
	private bool m_keepAlive; // 0x25
	[SerializeField]
	private bool m_background; // 0x26
	[SerializeField]
	private Color m_backgroundColor; // 0x28
	[SerializeField]
	private bool m_enableHotkeys; // 0x38
	[SerializeField]
	private KeyCode m_toggleModeKeyCode; // 0x3C
	[SerializeField]
	private bool m_toggleModeCtrl; // 0x40
	[SerializeField]
	private bool m_toggleModeAlt; // 0x41
	[SerializeField]
	private KeyCode m_toggleActiveKeyCode; // 0x44
	[SerializeField]
	private bool m_toggleActiveCtrl; // 0x48
	[SerializeField]
	private bool m_toggleActiveAlt; // 0x49
	[SerializeField]
	private GraphyManager.ModulePosition m_graphModulePosition; // 0x4C
	[SerializeField]
	private Vector2 m_graphModuleOffset; // 0x50
	[SerializeField]
	private GraphyManager.ModuleState m_fpsModuleState; // 0x58
	[SerializeField]
	private Color m_goodFpsColor; // 0x5C
	[SerializeField]
	private int m_goodFpsThreshold; // 0x6C
	[SerializeField]
	private Color m_cautionFpsColor; // 0x70
	[SerializeField]
	private int m_cautionFpsThreshold; // 0x80
	[SerializeField]
	private Color m_criticalFpsColor; // 0x84
	[Range(10, 300)]
	[SerializeField]
	private int m_fpsGraphResolution; // 0x94
	[SerializeField]
	[Range(1, 200)]
	private int m_fpsTextUpdateRate; // 0x98
	[SerializeField]
	private GraphyManager.ModuleState m_ramModuleState; // 0x9C
	[SerializeField]
	private Color m_allocatedRamColor; // 0xA0
	[SerializeField]
	private Color m_reservedRamColor; // 0xB0
	[SerializeField]
	private Color m_monoRamColor; // 0xC0
	[SerializeField]
	[Range(10, 300)]
	private int m_ramGraphResolution; // 0xD0
	[Range(1, 200)]
	[SerializeField]
	private int m_ramTextUpdateRate; // 0xD4
	[SerializeField]
	private GraphyManager.ModuleState m_audioModuleState; // 0xD8
	[SerializeField]
	private GraphyManager.LookForAudioListener m_findAudioListenerInCameraIfNull; // 0xDC
	[SerializeField]
	private AudioListener m_audioListener; // 0xE0
	[SerializeField]
	private Color m_audioGraphColor; // 0xE8
	[SerializeField]
	[Range(10, 300)]
	private int m_audioGraphResolution; // 0xF8
	[SerializeField]
	[Range(1, 200)]
	private int m_audioTextUpdateRate; // 0xFC
	[SerializeField]
	private FFTWindow m_FFTWindow; // 0x100
	[SerializeField]
	[Tooltip("Must be a power of 2 and between 64-8192")]
	private int m_spectrumSize; // 0x104
	[SerializeField]
	private GraphyManager.ModulePosition m_advancedModulePosition; // 0x108
	[SerializeField]
	private Vector2 m_advancedModuleOffset; // 0x10C
	[SerializeField]
	private GraphyManager.ModuleState m_advancedModuleState; // 0x114
	private bool m_initialized; // 0x118
	private bool m_active; // 0x119
	private bool m_focused; // 0x11A
	private G_FpsManager m_fpsManager; // 0x120
	private G_RamManager m_ramManager; // 0x128
	private G_AudioManager m_audioManager; // 0x130
	private G_AdvancedData m_advancedData; // 0x138
	private G_FpsMonitor m_fpsMonitor; // 0x140
	private G_RamMonitor m_ramMonitor; // 0x148
	private G_AudioMonitor m_audioMonitor; // 0x150
	private GraphyManager.ModulePreset m_modulePresetState; // 0x158

	// Properties
	public GraphyManager.Mode GraphyMode { get; set; }
	public bool EnableOnStartup { get; }
	public bool KeepAlive { get; }
	public bool Background { get; set; }
	public Color BackgroundColor { get; set; }
	public GraphyManager.ModulePosition GraphModulePosition { get; set; }
	public GraphyManager.ModuleState FpsModuleState { get; set; }
	public Color GoodFPSColor { get; set; }
	public Color CautionFPSColor { get; set; }
	public Color CriticalFPSColor { get; set; }
	public int GoodFPSThreshold { get; set; }
	public int CautionFPSThreshold { get; set; }
	public int FpsGraphResolution { get; set; }
	public int FpsTextUpdateRate { get; set; }
	public float CurrentFPS { get; }
	public float AverageFPS { get; }
	public float OnePercentFPS { get; }
	public float Zero1PercentFps { get; }
	public GraphyManager.ModuleState RamModuleState { get; set; }
	public Color AllocatedRamColor { get; set; }
	public Color ReservedRamColor { get; set; }
	public Color MonoRamColor { get; set; }
	public int RamGraphResolution { get; set; }
	public int RamTextUpdateRate { get; set; }
	public float AllocatedRam { get; }
	public float ReservedRam { get; }
	public float MonoRam { get; }
	public GraphyManager.ModuleState AudioModuleState { get; set; }
	public AudioListener AudioListener { get; set; }
	public GraphyManager.LookForAudioListener FindAudioListenerInCameraIfNull { get; set; }
	public Color AudioGraphColor { get; set; }
	public int AudioGraphResolution { get; set; }
	public int AudioTextUpdateRate { get; set; }
	public FFTWindow FftWindow { get; set; }
	public int SpectrumSize { get; set; }
	public float[] Spectrum { get; }
	public float MaxDB { get; }
	public GraphyManager.ModuleState AdvancedModuleState { get; set; }
	public GraphyManager.ModulePosition AdvancedModulePosition { get; set; }

	// Methods

	// RVA: 0x8472C40 Offset: 0x846EC40 VA: 0x8472C40
	protected void .ctor() { }

	// RVA: 0x8472D84 Offset: 0x846ED84 VA: 0x8472D84
	public GraphyManager.Mode get_GraphyMode() { }

	// RVA: 0x8472D8C Offset: 0x846ED8C VA: 0x8472D8C
	public void set_GraphyMode(GraphyManager.Mode value) { }

	// RVA: 0x8472DD4 Offset: 0x846EDD4 VA: 0x8472DD4
	public bool get_EnableOnStartup() { }

	// RVA: 0x8472DDC Offset: 0x846EDDC VA: 0x8472DDC
	public bool get_KeepAlive() { }

	// RVA: 0x8472DE4 Offset: 0x846EDE4 VA: 0x8472DE4
	public bool get_Background() { }

	// RVA: 0x8472DEC Offset: 0x846EDEC VA: 0x8472DEC
	public void set_Background(bool value) { }

	// RVA: 0x8472DF8 Offset: 0x846EDF8 VA: 0x8472DF8
	public Color get_BackgroundColor() { }

	// RVA: 0x8472E04 Offset: 0x846EE04 VA: 0x8472E04
	public void set_BackgroundColor(Color value) { }

	// RVA: 0x8472E10 Offset: 0x846EE10 VA: 0x8472E10
	public GraphyManager.ModulePosition get_GraphModulePosition() { }

	// RVA: 0x8472E18 Offset: 0x846EE18 VA: 0x8472E18
	public void set_GraphModulePosition(GraphyManager.ModulePosition value) { }

	// RVA: 0x84737F4 Offset: 0x846F7F4 VA: 0x84737F4
	public GraphyManager.ModuleState get_FpsModuleState() { }

	// RVA: 0x84737FC Offset: 0x846F7FC VA: 0x84737FC
	public void set_FpsModuleState(GraphyManager.ModuleState value) { }

	// RVA: 0x84739CC Offset: 0x846F9CC VA: 0x84739CC
	public Color get_GoodFPSColor() { }

	// RVA: 0x84739D8 Offset: 0x846F9D8 VA: 0x84739D8
	public void set_GoodFPSColor(Color value) { }

	// RVA: 0x8473BF8 Offset: 0x846FBF8 VA: 0x8473BF8
	public Color get_CautionFPSColor() { }

	// RVA: 0x8473C04 Offset: 0x846FC04 VA: 0x8473C04
	public void set_CautionFPSColor(Color value) { }

	// RVA: 0x8473C28 Offset: 0x846FC28 VA: 0x8473C28
	public Color get_CriticalFPSColor() { }

	// RVA: 0x8473C34 Offset: 0x846FC34 VA: 0x8473C34
	public void set_CriticalFPSColor(Color value) { }

	// RVA: 0x8473C58 Offset: 0x846FC58 VA: 0x8473C58
	public int get_GoodFPSThreshold() { }

	// RVA: 0x8473C60 Offset: 0x846FC60 VA: 0x8473C60
	public void set_GoodFPSThreshold(int value) { }

	// RVA: 0x8473C80 Offset: 0x846FC80 VA: 0x8473C80
	public int get_CautionFPSThreshold() { }

	// RVA: 0x8473C88 Offset: 0x846FC88 VA: 0x8473C88
	public void set_CautionFPSThreshold(int value) { }

	// RVA: 0x8473CA8 Offset: 0x846FCA8 VA: 0x8473CA8
	public int get_FpsGraphResolution() { }

	// RVA: 0x8473CB0 Offset: 0x846FCB0 VA: 0x8473CB0
	public void set_FpsGraphResolution(int value) { }

	// RVA: 0x8473CD0 Offset: 0x846FCD0 VA: 0x8473CD0
	public int get_FpsTextUpdateRate() { }

	// RVA: 0x8473CD8 Offset: 0x846FCD8 VA: 0x8473CD8
	public void set_FpsTextUpdateRate(int value) { }

	// RVA: 0x8473CF8 Offset: 0x846FCF8 VA: 0x8473CF8
	public float get_CurrentFPS() { }

	// RVA: 0x8473D18 Offset: 0x846FD18 VA: 0x8473D18
	public float get_AverageFPS() { }

	// RVA: 0x8473D38 Offset: 0x846FD38 VA: 0x8473D38
	public float get_OnePercentFPS() { }

	// RVA: 0x8473D58 Offset: 0x846FD58 VA: 0x8473D58
	public float get_Zero1PercentFps() { }

	// RVA: 0x8473D78 Offset: 0x846FD78 VA: 0x8473D78
	public GraphyManager.ModuleState get_RamModuleState() { }

	// RVA: 0x8473D80 Offset: 0x846FD80 VA: 0x8473D80
	public void set_RamModuleState(GraphyManager.ModuleState value) { }

	// RVA: 0x8473EF4 Offset: 0x846FEF4 VA: 0x8473EF4
	public Color get_AllocatedRamColor() { }

	// RVA: 0x8473F00 Offset: 0x846FF00 VA: 0x8473F00
	public void set_AllocatedRamColor(Color value) { }

	// RVA: 0x84740D0 Offset: 0x84700D0 VA: 0x84740D0
	public Color get_ReservedRamColor() { }

	// RVA: 0x84740DC Offset: 0x84700DC VA: 0x84740DC
	public void set_ReservedRamColor(Color value) { }

	// RVA: 0x8474100 Offset: 0x8470100 VA: 0x8474100
	public Color get_MonoRamColor() { }

	// RVA: 0x847410C Offset: 0x847010C VA: 0x847410C
	public void set_MonoRamColor(Color value) { }

	// RVA: 0x8474130 Offset: 0x8470130 VA: 0x8474130
	public int get_RamGraphResolution() { }

	// RVA: 0x8474138 Offset: 0x8470138 VA: 0x8474138
	public void set_RamGraphResolution(int value) { }

	// RVA: 0x8474158 Offset: 0x8470158 VA: 0x8474158
	public int get_RamTextUpdateRate() { }

	// RVA: 0x8474160 Offset: 0x8470160 VA: 0x8474160
	public void set_RamTextUpdateRate(int value) { }

	// RVA: 0x8474180 Offset: 0x8470180 VA: 0x8474180
	public float get_AllocatedRam() { }

	// RVA: 0x847419C Offset: 0x847019C VA: 0x847419C
	public float get_ReservedRam() { }

	// RVA: 0x84741B8 Offset: 0x84701B8 VA: 0x84741B8
	public float get_MonoRam() { }

	// RVA: 0x84741D4 Offset: 0x84701D4 VA: 0x84741D4
	public GraphyManager.ModuleState get_AudioModuleState() { }

	// RVA: 0x84741DC Offset: 0x84701DC VA: 0x84741DC
	public void set_AudioModuleState(GraphyManager.ModuleState value) { }

	// RVA: 0x8474350 Offset: 0x8470350 VA: 0x8474350
	public AudioListener get_AudioListener() { }

	// RVA: 0x8474358 Offset: 0x8470358 VA: 0x8474358
	public void set_AudioListener(AudioListener value) { }

	// RVA: 0x8474544 Offset: 0x8470544 VA: 0x8474544
	public GraphyManager.LookForAudioListener get_FindAudioListenerInCameraIfNull() { }

	// RVA: 0x847454C Offset: 0x847054C VA: 0x847454C
	public void set_FindAudioListenerInCameraIfNull(GraphyManager.LookForAudioListener value) { }

	// RVA: 0x847456C Offset: 0x847056C VA: 0x847456C
	public Color get_AudioGraphColor() { }

	// RVA: 0x8474578 Offset: 0x8470578 VA: 0x8474578
	public void set_AudioGraphColor(Color value) { }

	// RVA: 0x847459C Offset: 0x847059C VA: 0x847459C
	public int get_AudioGraphResolution() { }

	// RVA: 0x84745A4 Offset: 0x84705A4 VA: 0x84745A4
	public void set_AudioGraphResolution(int value) { }

	// RVA: 0x84745C4 Offset: 0x84705C4 VA: 0x84745C4
	public int get_AudioTextUpdateRate() { }

	// RVA: 0x84745CC Offset: 0x84705CC VA: 0x84745CC
	public void set_AudioTextUpdateRate(int value) { }

	// RVA: 0x84745EC Offset: 0x84705EC VA: 0x84745EC
	public FFTWindow get_FftWindow() { }

	// RVA: 0x84745F4 Offset: 0x84705F4 VA: 0x84745F4
	public void set_FftWindow(FFTWindow value) { }

	// RVA: 0x8474614 Offset: 0x8470614 VA: 0x8474614
	public int get_SpectrumSize() { }

	// RVA: 0x847461C Offset: 0x847061C VA: 0x847461C
	public void set_SpectrumSize(int value) { }

	// RVA: 0x847463C Offset: 0x847063C VA: 0x847463C
	public float[] get_Spectrum() { }

	// RVA: 0x8474658 Offset: 0x8470658 VA: 0x8474658
	public float get_MaxDB() { }

	// RVA: 0x8474674 Offset: 0x8470674 VA: 0x8474674
	public GraphyManager.ModuleState get_AdvancedModuleState() { }

	// RVA: 0x847467C Offset: 0x847067C VA: 0x847467C
	public void set_AdvancedModuleState(GraphyManager.ModuleState value) { }

	// RVA: 0x8474718 Offset: 0x8470718 VA: 0x8474718
	public GraphyManager.ModulePosition get_AdvancedModulePosition() { }

	// RVA: 0x8474720 Offset: 0x8470720 VA: 0x8474720
	public void set_AdvancedModulePosition(GraphyManager.ModulePosition value) { }

	// RVA: 0x8474BD4 Offset: 0x8470BD4 VA: 0x8474BD4
	private void Start() { }

	// RVA: 0x8474ED4 Offset: 0x8470ED4 VA: 0x8474ED4
	private void OnDestroy() { }

	// RVA: 0x84750A0 Offset: 0x84710A0 VA: 0x84750A0
	private void Update() { }

	// RVA: 0x8475238 Offset: 0x8471238 VA: 0x8475238
	private void OnApplicationFocus(bool isFocused) { }

	// RVA: 0x8475294 Offset: 0x8471294 VA: 0x8475294
	public void SetModulePosition(GraphyManager.ModuleType moduleType, GraphyManager.ModulePosition modulePosition) { }

	// RVA: 0x8475358 Offset: 0x8471358 VA: 0x8475358
	public void SetModuleMode(GraphyManager.ModuleType moduleType, GraphyManager.ModuleState moduleState) { }

	// RVA: 0x84753EC Offset: 0x84713EC VA: 0x84753EC
	public void ToggleModes() { }

	// RVA: 0x84754D4 Offset: 0x84714D4 VA: 0x84754D4
	public void SetPreset(GraphyManager.ModulePreset modulePreset) { }

	// RVA: 0x8475768 Offset: 0x8471768 VA: 0x8475768
	public void ToggleActive() { }

	// RVA: 0x8475778 Offset: 0x8471778 VA: 0x8475778
	public void Enable() { }

	// RVA: 0x8475800 Offset: 0x8471800 VA: 0x8475800
	public void Disable() { }

	// RVA: 0x8474BD8 Offset: 0x8470BD8 VA: 0x8474BD8
	private void Init() { }

	// RVA: 0x84758A0 Offset: 0x84718A0 VA: 0x84758A0
	public void OnValidate() { }

	// RVA: 0x84750B8 Offset: 0x84710B8 VA: 0x84750B8
	private void CheckForHotkeyPresses() { }

	// RVA: 0x8475A90 Offset: 0x8471A90 VA: 0x8475A90
	private bool CheckFor1KeyPress(KeyCode key) { }

	// RVA: 0x8475A24 Offset: 0x8471A24 VA: 0x8475A24
	private bool CheckFor2KeyPress(KeyCode key1, KeyCode key2) { }

	// RVA: 0x8475964 Offset: 0x8471964 VA: 0x8475964
	private bool CheckFor3KeyPress(KeyCode key1, KeyCode key2, KeyCode key3) { }

	// RVA: 0x8472D94 Offset: 0x846ED94 VA: 0x8472D94
	private void UpdateAllParameters() { }

	// RVA: 0x8475254 Offset: 0x8471254 VA: 0x8475254
	private void RefreshAllParameters() { }
}

// Namespace: Tayx.Graphy
public class G_GraphShader // TypeDefIndex: 27667
{
	// Fields
	public const int ArrayMaxSizeFull = 512;
	public const int ArrayMaxSizeLight = 128;
	public int ArrayMaxSize; // 0x10
	public float[] ShaderArrayValues; // 0x18
	public Image Image; // 0x20
	public float Average; // 0x28
	public float GoodThreshold; // 0x2C
	public float CautionThreshold; // 0x30
	public Color GoodColor; // 0x34
	public Color CautionColor; // 0x44
	public Color CriticalColor; // 0x54
	private static readonly int AveragePropertyId; // 0x0
	private static readonly int GoodThresholdPropertyId; // 0x4
	private static readonly int CautionThresholdPropertyId; // 0x8
	private static readonly int GoodColorPropertyId; // 0xC
	private static readonly int CautionColorPropertyId; // 0x10
	private static readonly int CriticalColorPropertyId; // 0x14
	private static readonly int GraphValues; // 0x18
	private static readonly int GraphValuesLength; // 0x1C

	// Methods

	// RVA: 0x8476388 Offset: 0x8472388 VA: 0x8476388
	public void InitializeShader() { }

	// RVA: 0x8476444 Offset: 0x8472444 VA: 0x8476444
	public void UpdateArrayValuesLength() { }

	// RVA: 0x84764DC Offset: 0x84724DC VA: 0x84764DC
	public void UpdateAverage() { }

	// RVA: 0x847656C Offset: 0x847256C VA: 0x847656C
	public void UpdateThresholds() { }

	// RVA: 0x8476630 Offset: 0x8472630 VA: 0x8476630
	public void UpdateColors() { }

	// RVA: 0x8476734 Offset: 0x8472734 VA: 0x8476734
	public void UpdatePoints() { }

	// RVA: 0x84767C4 Offset: 0x84727C4 VA: 0x84767C4
	public void .ctor() { }

	// RVA: 0x84767E4 Offset: 0x84727E4 VA: 0x84767E4
	private static void .cctor() { }
}

// Namespace: Tayx.Graphy.Utils
[Extension]
public static class G_ExtensionMethods // TypeDefIndex: 27668
{
	// Methods

	[Extension]
	// RVA: 0x84769A0 Offset: 0x84729A0 VA: 0x84769A0
	public static List<GameObject> SetAllActive(List<GameObject> gameObjects, bool active) { }

	[Extension]
	// RVA: 0x8476B04 Offset: 0x8472B04 VA: 0x8476B04
	public static List<Image> SetOneActive(List<Image> images, int active) { }

	[Extension]
	// RVA: 0x8476BB8 Offset: 0x8472BB8 VA: 0x8476BB8
	public static List<Image> SetAllActive(List<Image> images, bool active) { }
}

// Namespace: Tayx.Graphy.Utils
public class G_Singleton<T> : MonoBehaviour // TypeDefIndex: 27669
{
	// Fields
	private static T _instance; // 0x0
	private static object _lock; // 0x0

	// Properties
	public static T Instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48EB260 Offset: 0x48E7260 VA: 0x48EB260
	|-G_Singleton<object>.get_Instance
	*/

	// RVA: -1 Offset: -1
	private void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48EB6B8 Offset: 0x48E76B8 VA: 0x48EB6B8
	|-G_Singleton<object>.Awake
	*/

	// RVA: -1 Offset: -1
	private void OnDestroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48EB83C Offset: 0x48E783C VA: 0x48EB83C
	|-G_Singleton<object>.OnDestroy
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48EB930 Offset: 0x48E7930 VA: 0x48EB930
	|-G_Singleton<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48EB938 Offset: 0x48E7938 VA: 0x48EB938
	|-G_Singleton<object>..cctor
	*/
}

// Namespace: Tayx.Graphy.Utils.NumString
[Extension]
public static class G_FloatString // TypeDefIndex: 27670
{
	// Fields
	private const string m_floatFormat = "0.0";
	private static float m_decimalMultiplier; // 0x0
	private static string[] m_negativeBuffer; // 0x8
	private static string[] m_positiveBuffer; // 0x10

	// Properties
	public static float MinValue { get; }
	public static float MaxValue { get; }

	// Methods

	// RVA: 0x8476D20 Offset: 0x8472D20 VA: 0x8476D20
	public static float get_MinValue() { }

	// RVA: 0x8476DF4 Offset: 0x8472DF4 VA: 0x8476DF4
	public static float get_MaxValue() { }

	// RVA: 0x8476E5C Offset: 0x8472E5C VA: 0x8476E5C
	public static void Init(float minNegativeValue, float maxPositiveValue) { }

	// RVA: 0x8474FF8 Offset: 0x8470FF8 VA: 0x8474FF8
	public static void Dispose() { }

	[Extension]
	// RVA: 0x8477190 Offset: 0x8473190 VA: 0x8477190
	public static string ToStringNonAlloc(float value) { }

	[Extension]
	// RVA: 0x84772D0 Offset: 0x84732D0 VA: 0x84772D0
	public static string ToStringNonAlloc(float value, string format) { }

	[Extension]
	// RVA: 0x8477410 Offset: 0x8473410 VA: 0x8477410
	public static int ToInt(float f) { }

	[Extension]
	// RVA: 0x847742C Offset: 0x847342C VA: 0x847742C
	public static float ToFloat(int i) { }

	[Extension]
	// RVA: 0x84770D0 Offset: 0x84730D0 VA: 0x84770D0
	private static int ToIndex(float f) { }

	[Extension]
	// RVA: 0x8476D90 Offset: 0x8472D90 VA: 0x8476D90
	private static float FromIndex(int i) { }

	// RVA: 0x8477434 Offset: 0x8473434 VA: 0x8477434
	private static void .cctor() { }
}

// Namespace: Tayx.Graphy.Utils.NumString
[Extension]
public static class G_IntString // TypeDefIndex: 27671
{
	// Fields
	private static string[] m_negativeBuffer; // 0x0
	private static string[] m_positiveBuffer; // 0x8

	// Properties
	public static int MinValue { get; }
	public static int MaxValue { get; }

	// Methods

	// RVA: 0x84774D8 Offset: 0x84734D8 VA: 0x84774D8
	public static int get_MinValue() { }

	// RVA: 0x8477544 Offset: 0x8473544 VA: 0x8477544
	public static int get_MaxValue() { }

	// RVA: 0x84775A8 Offset: 0x84735A8 VA: 0x84775A8
	public static void Init(int minNegativeValue, int maxPositiveValue) { }

	// RVA: 0x8474F48 Offset: 0x8470F48 VA: 0x8474F48
	public static void Dispose() { }

	[Extension]
	// RVA: 0x8477808 Offset: 0x8473808 VA: 0x8477808
	public static string ToStringNonAlloc(int value) { }

	// RVA: 0x8477928 Offset: 0x8473928 VA: 0x8477928
	private static void .cctor() { }
}

// Namespace: Tayx.Graphy.UI
public interface IModifiableState // TypeDefIndex: 27672
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetState(GraphyManager.ModuleState newState, bool silentUpdate);
}

// Namespace: Tayx.Graphy.UI
public interface IMovable // TypeDefIndex: 27673
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetPosition(GraphyManager.ModulePosition newModulePosition, Vector2 offset);
}

// Namespace: Tayx.Graphy.Ram
public class G_RamGraph : G_Graph // TypeDefIndex: 27674
{
	// Fields
	[SerializeField]
	private Image m_imageAllocated; // 0x20
	[SerializeField]
	private Image m_imageReserved; // 0x28
	[SerializeField]
	private Image m_imageMono; // 0x30
	[SerializeField]
	private Shader ShaderFull; // 0x38
	[SerializeField]
	private Shader ShaderLight; // 0x40
	[SerializeField]
	private bool m_isInitialized; // 0x48
	private GraphyManager m_graphyManager; // 0x50
	private G_RamMonitor m_ramMonitor; // 0x58
	private int m_resolution; // 0x60
	private G_GraphShader m_shaderGraphAllocated; // 0x68
	private G_GraphShader m_shaderGraphReserved; // 0x70
	private G_GraphShader m_shaderGraphMono; // 0x78
	private float[] m_allocatedArray; // 0x80
	private float[] m_reservedArray; // 0x88
	private float[] m_monoArray; // 0x90
	private float m_highestMemory; // 0x98

	// Methods

	// RVA: 0x84779C0 Offset: 0x84739C0 VA: 0x84779C0
	private void Update() { }

	// RVA: 0x84779CC Offset: 0x84739CC VA: 0x84779CC
	public void UpdateParameters() { }

	// RVA: 0x8477C18 Offset: 0x8473C18 VA: 0x8477C18 Slot: 4
	protected override void UpdateGraph() { }

	// RVA: 0x8478054 Offset: 0x8474054 VA: 0x8478054 Slot: 5
	protected override void CreatePoints() { }

	// RVA: 0x8477E84 Offset: 0x8473E84 VA: 0x8477E84
	private void Init() { }

	// RVA: 0x847838C Offset: 0x847438C VA: 0x847838C
	public void .ctor() { }
}

// Namespace: Tayx.Graphy.Ram
public class G_RamManager : MonoBehaviour, IMovable, IModifiableState // TypeDefIndex: 27675
{
	// Fields
	[SerializeField]
	private GameObject m_ramGraphGameObject; // 0x20
	[SerializeField]
	private List<Image> m_backgroundImages; // 0x28
	private GraphyManager m_graphyManager; // 0x30
	private G_RamGraph m_ramGraph; // 0x38
	private G_RamText m_ramText; // 0x40
	private RectTransform m_rectTransform; // 0x48
	private Vector2 m_origPosition; // 0x50
	private List<GameObject> m_childrenGameObjects; // 0x58
	private GraphyManager.ModuleState m_previousModuleState; // 0x60
	private GraphyManager.ModuleState m_currentModuleState; // 0x64

	// Methods

	// RVA: 0x84783A4 Offset: 0x84743A4 VA: 0x84783A4
	private void Awake() { }

	// RVA: 0x8478870 Offset: 0x8474870 VA: 0x8478870
	private void Start() { }

	// RVA: 0x847318C Offset: 0x846F18C VA: 0x847318C Slot: 4
	public void SetPosition(GraphyManager.ModulePosition newModulePosition, Vector2 offset) { }

	// RVA: 0x8473DA4 Offset: 0x846FDA4 VA: 0x8473DA4 Slot: 5
	public void SetState(GraphyManager.ModuleState state, bool silentUpdate = False) { }

	// RVA: 0x847587C Offset: 0x847187C VA: 0x847587C
	public void RestorePreviousState() { }

	// RVA: 0x8473F24 Offset: 0x846FF24 VA: 0x8473F24
	public void UpdateParameters() { }

	// RVA: 0x8475E70 Offset: 0x8471E70 VA: 0x8475E70
	public void RefreshParameters() { }

	// RVA: 0x84783A8 Offset: 0x84743A8 VA: 0x84783A8
	private void Init() { }

	// RVA: 0x8478874 Offset: 0x8474874 VA: 0x8478874
	private void SetGraphActive(bool active) { }

	// RVA: 0x8478958 Offset: 0x8474958 VA: 0x8478958
	public void .ctor() { }
}

// Namespace: Tayx.Graphy.Ram
public class G_RamMonitor : MonoBehaviour // TypeDefIndex: 27676
{
	// Fields
	[CompilerGenerated]
	private float <AllocatedRam>k__BackingField; // 0x20
	[CompilerGenerated]
	private float <ReservedRam>k__BackingField; // 0x24
	[CompilerGenerated]
	private float <MonoRam>k__BackingField; // 0x28

	// Properties
	public float AllocatedRam { get; set; }
	public float ReservedRam { get; set; }
	public float MonoRam { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8478A64 Offset: 0x8474A64 VA: 0x8478A64
	public float get_AllocatedRam() { }

	[CompilerGenerated]
	// RVA: 0x8478A6C Offset: 0x8474A6C VA: 0x8478A6C
	private void set_AllocatedRam(float value) { }

	[CompilerGenerated]
	// RVA: 0x8478A74 Offset: 0x8474A74 VA: 0x8478A74
	public float get_ReservedRam() { }

	[CompilerGenerated]
	// RVA: 0x8478A7C Offset: 0x8474A7C VA: 0x8478A7C
	private void set_ReservedRam(float value) { }

	[CompilerGenerated]
	// RVA: 0x8478A84 Offset: 0x8474A84 VA: 0x8478A84
	public float get_MonoRam() { }

	[CompilerGenerated]
	// RVA: 0x8478A8C Offset: 0x8474A8C VA: 0x8478A8C
	private void set_MonoRam(float value) { }

	// RVA: 0x8478A94 Offset: 0x8474A94 VA: 0x8478A94
	private void Update() { }

	// RVA: 0x8478AF0 Offset: 0x8474AF0 VA: 0x8478AF0
	public void .ctor() { }
}

// Namespace: Tayx.Graphy.Ram
public class G_RamText : MonoBehaviour // TypeDefIndex: 27677
{
	// Fields
	[SerializeField]
	private Text m_allocatedSystemMemorySizeText; // 0x20
	[SerializeField]
	private Text m_reservedSystemMemorySizeText; // 0x28
	[SerializeField]
	private Text m_monoSystemMemorySizeText; // 0x30
	private GraphyManager m_graphyManager; // 0x38
	private G_RamMonitor m_ramMonitor; // 0x40
	private float m_updateRate; // 0x48
	private float m_deltaTime; // 0x4C

	// Methods

	// RVA: 0x8478AF8 Offset: 0x8474AF8 VA: 0x8478AF8
	private void Awake() { }

	// RVA: 0x8478BD8 Offset: 0x8474BD8 VA: 0x8478BD8
	private void Update() { }

	// RVA: 0x84788B8 Offset: 0x84748B8 VA: 0x84788B8
	public void UpdateParameters() { }

	// RVA: 0x8478AFC Offset: 0x8474AFC VA: 0x8478AFC
	private void Init() { }

	// RVA: 0x8478D38 Offset: 0x8474D38 VA: 0x8478D38
	public void .ctor() { }
}

// Namespace: Tayx.Graphy.Graph
public abstract class G_Graph : MonoBehaviour // TypeDefIndex: 27678
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void UpdateGraph();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void CreatePoints();

	// RVA: 0x847839C Offset: 0x847439C VA: 0x847839C
	protected void .ctor() { }
}

// Namespace: Tayx.Graphy.Fps
public class G_FpsGraph : G_Graph // TypeDefIndex: 27679
{
	// Fields
	[SerializeField]
	private Image m_imageGraph; // 0x20
	[SerializeField]
	private Shader ShaderFull; // 0x28
	[SerializeField]
	private Shader ShaderLight; // 0x30
	[SerializeField]
	private bool m_isInitialized; // 0x38
	private GraphyManager m_graphyManager; // 0x40
	private G_FpsMonitor m_fpsMonitor; // 0x48
	private int m_resolution; // 0x50
	private G_GraphShader m_shaderGraph; // 0x58
	private int[] m_fpsArray; // 0x60
	private int m_highestFps; // 0x68

	// Methods

	// RVA: 0x8478D48 Offset: 0x8474D48 VA: 0x8478D48
	private void Update() { }

	// RVA: 0x8478D54 Offset: 0x8474D54 VA: 0x8478D54
	public void UpdateParameters() { }

	// RVA: 0x8478E58 Offset: 0x8474E58 VA: 0x8478E58 Slot: 4
	protected override void UpdateGraph() { }

	// RVA: 0x84791D4 Offset: 0x84751D4 VA: 0x84791D4 Slot: 5
	protected override void CreatePoints() { }

	// RVA: 0x84790BC Offset: 0x84750BC VA: 0x84790BC
	private void Init() { }

	// RVA: 0x8479344 Offset: 0x8475344 VA: 0x8479344
	public void .ctor() { }
}

// Namespace: Tayx.Graphy.Fps
public class G_FpsManager : MonoBehaviour, IMovable, IModifiableState // TypeDefIndex: 27680
{
	// Fields
	[SerializeField]
	private GameObject m_fpsGraphGameObject; // 0x20
	[SerializeField]
	private List<GameObject> m_nonBasicTextGameObjects; // 0x28
	[SerializeField]
	private List<Image> m_backgroundImages; // 0x30
	private GraphyManager m_graphyManager; // 0x38
	private G_FpsGraph m_fpsGraph; // 0x40
	private G_FpsMonitor m_fpsMonitor; // 0x48
	private G_FpsText m_fpsText; // 0x50
	private RectTransform m_rectTransform; // 0x58
	private Vector2 m_origPosition; // 0x60
	private List<GameObject> m_childrenGameObjects; // 0x68
	private GraphyManager.ModuleState m_previousModuleState; // 0x70
	private GraphyManager.ModuleState m_currentModuleState; // 0x74

	// Methods

	// RVA: 0x8479354 Offset: 0x8475354 VA: 0x8479354
	private void Awake() { }

	// RVA: 0x8479850 Offset: 0x8475850 VA: 0x8479850
	private void Start() { }

	// RVA: 0x8472E64 Offset: 0x846EE64 VA: 0x8472E64 Slot: 4
	public void SetPosition(GraphyManager.ModulePosition newModulePosition, Vector2 offset) { }

	// RVA: 0x8473820 Offset: 0x846F820 VA: 0x8473820 Slot: 5
	public void SetState(GraphyManager.ModuleState state, bool silentUpdate = False) { }

	// RVA: 0x8475870 Offset: 0x8471870 VA: 0x8475870
	public void RestorePreviousState() { }

	// RVA: 0x84739FC Offset: 0x846F9FC VA: 0x84739FC
	public void UpdateParameters() { }

	// RVA: 0x8475C7C Offset: 0x8471C7C VA: 0x8475C7C
	public void RefreshParameters() { }

	// RVA: 0x8479358 Offset: 0x8475358 VA: 0x8479358
	private void Init() { }

	// RVA: 0x8479854 Offset: 0x8475854 VA: 0x8479854
	private void SetGraphActive(bool active) { }

	// RVA: 0x84798F8 Offset: 0x84758F8 VA: 0x84798F8
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class G_FpsMonitor.<>c // TypeDefIndex: 27681
{
	// Fields
	public static readonly G_FpsMonitor.<>c <>9; // 0x0
	public static Comparison<short> <>9__25_0; // 0x8

	// Methods

	// RVA: 0x8479EE4 Offset: 0x8475EE4 VA: 0x8479EE4
	private static void .cctor() { }

	// RVA: 0x8479F4C Offset: 0x8475F4C VA: 0x8479F4C
	public void .ctor() { }

	// RVA: 0x8479F54 Offset: 0x8475F54 VA: 0x8479F54
	internal int <Update>b__25_0(short x, short y) { }
}

// Namespace: Tayx.Graphy.Fps
public class G_FpsMonitor : MonoBehaviour // TypeDefIndex: 27682
{
	// Fields
	private short[] m_fpsSamples; // 0x20
	private short[] m_fpsSamplesSorted; // 0x28
	private short m_fpsSamplesCapacity; // 0x30
	private short m_onePercentSamples; // 0x32
	private short m_zero1PercentSamples; // 0x34
	private short m_fpsSamplesCount; // 0x36
	private short m_indexSample; // 0x38
	private float m_unscaledDeltaTime; // 0x3C
	[CompilerGenerated]
	private short <CurrentFPS>k__BackingField; // 0x40
	[CompilerGenerated]
	private short <AverageFPS>k__BackingField; // 0x42
	[CompilerGenerated]
	private short <OnePercentFPS>k__BackingField; // 0x44
	[CompilerGenerated]
	private short <Zero1PercentFps>k__BackingField; // 0x46

	// Properties
	public short CurrentFPS { get; set; }
	public short AverageFPS { get; set; }
	public short OnePercentFPS { get; set; }
	public short Zero1PercentFps { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8479A30 Offset: 0x8475A30 VA: 0x8479A30
	public short get_CurrentFPS() { }

	[CompilerGenerated]
	// RVA: 0x8479A38 Offset: 0x8475A38 VA: 0x8479A38
	private void set_CurrentFPS(short value) { }

	[CompilerGenerated]
	// RVA: 0x8479A40 Offset: 0x8475A40 VA: 0x8479A40
	public short get_AverageFPS() { }

	[CompilerGenerated]
	// RVA: 0x8479A48 Offset: 0x8475A48 VA: 0x8479A48
	private void set_AverageFPS(short value) { }

	[CompilerGenerated]
	// RVA: 0x8479A50 Offset: 0x8475A50 VA: 0x8479A50
	public short get_OnePercentFPS() { }

	[CompilerGenerated]
	// RVA: 0x8479A58 Offset: 0x8475A58 VA: 0x8479A58
	private void set_OnePercentFPS(short value) { }

	[CompilerGenerated]
	// RVA: 0x8479A60 Offset: 0x8475A60 VA: 0x8479A60
	public short get_Zero1PercentFps() { }

	[CompilerGenerated]
	// RVA: 0x8479A68 Offset: 0x8475A68 VA: 0x8479A68
	private void set_Zero1PercentFps(short value) { }

	// RVA: 0x8479A70 Offset: 0x8475A70 VA: 0x8479A70
	private void Awake() { }

	// RVA: 0x8479B2C Offset: 0x8475B2C VA: 0x8479B2C
	private void Update() { }

	// RVA: 0x8479898 Offset: 0x8475898 VA: 0x8479898
	public void UpdateParameters() { }

	// RVA: 0x8479A74 Offset: 0x8475A74 VA: 0x8479A74
	private void Init() { }

	// RVA: 0x8479EC8 Offset: 0x8475EC8 VA: 0x8479EC8
	public void .ctor() { }
}

// Namespace: Tayx.Graphy.Fps
public class G_FpsText : MonoBehaviour // TypeDefIndex: 27683
{
	// Fields
	[SerializeField]
	private Text m_fpsText; // 0x20
	[SerializeField]
	private Text m_msText; // 0x28
	[SerializeField]
	private Text m_avgFpsText; // 0x30
	[SerializeField]
	private Text m_onePercentFpsText; // 0x38
	[SerializeField]
	private Text m_zero1PercentFpsText; // 0x40
	private GraphyManager m_graphyManager; // 0x48
	private G_FpsMonitor m_fpsMonitor; // 0x50
	private int m_updateRate; // 0x58
	private int m_frameCount; // 0x5C
	private float m_deltaTime; // 0x60
	private float m_fps; // 0x64
	private float m_ms; // 0x68
	private const string m_msStringFormat = "0.0";

	// Methods

	// RVA: 0x8479F74 Offset: 0x8475F74 VA: 0x8479F74
	private void Awake() { }

	// RVA: 0x847A098 Offset: 0x8476098 VA: 0x847A098
	private void Update() { }

	// RVA: 0x84798D8 Offset: 0x84758D8 VA: 0x84798D8
	public void UpdateParameters() { }

	// RVA: 0x847A3A4 Offset: 0x84763A4 VA: 0x847A3A4
	private void SetFpsRelatedTextColor(Text text, float fps) { }

	// RVA: 0x8479F78 Offset: 0x8475F78 VA: 0x8479F78
	private void Init() { }

	// RVA: 0x847A4F8 Offset: 0x84764F8 VA: 0x847A4F8
	public void .ctor() { }
}

// Namespace: Tayx.Graphy.Audio
public class G_AudioGraph : G_Graph // TypeDefIndex: 27684
{
	// Fields
	[SerializeField]
	private Image m_imageGraph; // 0x20
	[SerializeField]
	private Image m_imageGraphHighestValues; // 0x28
	[SerializeField]
	private Shader ShaderFull; // 0x30
	[SerializeField]
	private Shader ShaderLight; // 0x38
	[SerializeField]
	private bool m_isInitialized; // 0x40
	private GraphyManager m_graphyManager; // 0x48
	private G_AudioMonitor m_audioMonitor; // 0x50
	private int m_resolution; // 0x58
	private G_GraphShader m_shaderGraph; // 0x60
	private G_GraphShader m_shaderGraphHighestValues; // 0x68
	private float[] m_graphArray; // 0x70
	private float[] m_graphArrayHighestValue; // 0x78

	// Methods

	// RVA: 0x847A508 Offset: 0x8476508 VA: 0x847A508
	private void OnEnable() { }

	// RVA: 0x847A560 Offset: 0x8476560 VA: 0x847A560
	private void Update() { }

	// RVA: 0x847A5F8 Offset: 0x84765F8 VA: 0x847A5F8
	public void UpdateParameters() { }

	// RVA: 0x847A7A0 Offset: 0x84767A0 VA: 0x847A7A0 Slot: 4
	protected override void UpdateGraph() { }

	// RVA: 0x847AE28 Offset: 0x8476E28 VA: 0x847AE28 Slot: 5
	protected override void CreatePoints() { }

	// RVA: 0x847AC70 Offset: 0x8476C70 VA: 0x847AC70
	private void Init() { }

	// RVA: 0x847B070 Offset: 0x8477070 VA: 0x847B070
	public void .ctor() { }
}

// Namespace: Tayx.Graphy.Audio
public class G_AudioManager : MonoBehaviour, IMovable, IModifiableState // TypeDefIndex: 27685
{
	// Fields
	[SerializeField]
	private GameObject m_audioGraphGameObject; // 0x20
	[SerializeField]
	private Text m_audioDbText; // 0x28
	[SerializeField]
	private List<Image> m_backgroundImages; // 0x30
	private GraphyManager m_graphyManager; // 0x38
	private G_AudioGraph m_audioGraph; // 0x40
	private G_AudioMonitor m_audioMonitor; // 0x48
	private G_AudioText m_audioText; // 0x50
	private RectTransform m_rectTransform; // 0x58
	private Vector2 m_origPosition; // 0x60
	private List<GameObject> m_childrenGameObjects; // 0x68
	private GraphyManager.ModuleState m_previousModuleState; // 0x70
	private GraphyManager.ModuleState m_currentModuleState; // 0x74

	// Methods

	// RVA: 0x847B080 Offset: 0x8477080 VA: 0x847B080
	private void Awake() { }

	// RVA: 0x847B57C Offset: 0x847757C VA: 0x847B57C
	private void Start() { }

	// RVA: 0x84734B4 Offset: 0x846F4B4 VA: 0x84734B4 Slot: 4
	public void SetPosition(GraphyManager.ModulePosition newModulePosition, Vector2 offset) { }

	// RVA: 0x8474200 Offset: 0x8470200 VA: 0x8474200 Slot: 5
	public void SetState(GraphyManager.ModuleState state, bool silentUpdate = False) { }

	// RVA: 0x8475888 Offset: 0x8471888 VA: 0x8475888
	public void RestorePreviousState() { }

	// RVA: 0x8474380 Offset: 0x8470380 VA: 0x8474380
	public void UpdateParameters() { }

	// RVA: 0x8476004 Offset: 0x8472004 VA: 0x8476004
	public void RefreshParameters() { }

	// RVA: 0x847B084 Offset: 0x8477084 VA: 0x847B084
	private void Init() { }

	// RVA: 0x847B580 Offset: 0x8477580 VA: 0x847B580
	private void SetGraphActive(bool active) { }

	// RVA: 0x847B6F4 Offset: 0x84776F4 VA: 0x847B6F4
	public void .ctor() { }
}

// Namespace: Tayx.Graphy.Audio
public class G_AudioMonitor : MonoBehaviour // TypeDefIndex: 27686
{
	// Fields
	private const float m_refValue = 1;
	private GraphyManager m_graphyManager; // 0x20
	private AudioListener m_audioListener; // 0x28
	private GraphyManager.LookForAudioListener m_findAudioListenerInCameraIfNull; // 0x30
	private FFTWindow m_FFTWindow; // 0x34
	private int m_spectrumSize; // 0x38
	[CompilerGenerated]
	private float[] <Spectrum>k__BackingField; // 0x40
	[CompilerGenerated]
	private float[] <SpectrumHighestValues>k__BackingField; // 0x48
	[CompilerGenerated]
	private float <MaxDB>k__BackingField; // 0x50

	// Properties
	public float[] Spectrum { get; set; }
	public float[] SpectrumHighestValues { get; set; }
	public float MaxDB { get; set; }
	public bool SpectrumDataAvailable { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x847B800 Offset: 0x8477800 VA: 0x847B800
	public float[] get_Spectrum() { }

	[CompilerGenerated]
	// RVA: 0x847B808 Offset: 0x8477808 VA: 0x847B808
	private void set_Spectrum(float[] value) { }

	[CompilerGenerated]
	// RVA: 0x847B810 Offset: 0x8477810 VA: 0x847B810
	public float[] get_SpectrumHighestValues() { }

	[CompilerGenerated]
	// RVA: 0x847B818 Offset: 0x8477818 VA: 0x847B818
	private void set_SpectrumHighestValues(float[] value) { }

	[CompilerGenerated]
	// RVA: 0x847B820 Offset: 0x8477820 VA: 0x847B820
	public float get_MaxDB() { }

	[CompilerGenerated]
	// RVA: 0x847B828 Offset: 0x8477828 VA: 0x847B828
	private void set_MaxDB(float value) { }

	// RVA: 0x847A598 Offset: 0x8476598 VA: 0x847A598
	public bool get_SpectrumDataAvailable() { }

	// RVA: 0x847B830 Offset: 0x8477830 VA: 0x847B830
	private void Awake() { }

	// RVA: 0x847B92C Offset: 0x847792C VA: 0x847B92C
	private void Update() { }

	// RVA: 0x847BBEC Offset: 0x8477BEC VA: 0x847BBEC
	private void OnDestroy() { }

	// RVA: 0x847B5C4 Offset: 0x84775C4 VA: 0x847B5C4
	public void UpdateParameters() { }

	// RVA: 0x847ADE4 Offset: 0x8476DE4 VA: 0x847ADE4
	public float lin2dB(float linear) { }

	// RVA: 0x847AE14 Offset: 0x8476E14 VA: 0x847AE14
	public float dBNormalized(float db) { }

	// RVA: 0x847BB38 Offset: 0x8477B38 VA: 0x847BB38
	private AudioListener FindAudioListener() { }

	// RVA: 0x847BC90 Offset: 0x8477C90 VA: 0x847BC90
	private void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode) { }

	// RVA: 0x847B834 Offset: 0x8477834 VA: 0x847B834
	private void Init() { }

	// RVA: 0x847BCC4 Offset: 0x8477CC4 VA: 0x847BCC4
	public void .ctor() { }
}

// Namespace: Tayx.Graphy.Audio
public class G_AudioText : MonoBehaviour // TypeDefIndex: 27687
{
	// Fields
	[SerializeField]
	private Text m_DBText; // 0x20
	private GraphyManager m_graphyManager; // 0x28
	private G_AudioMonitor m_audioMonitor; // 0x30
	private int m_updateRate; // 0x38
	private float m_deltaTimeOffset; // 0x3C

	// Methods

	// RVA: 0x847BCE0 Offset: 0x8477CE0 VA: 0x847BCE0
	private void Awake() { }

	// RVA: 0x847BDD0 Offset: 0x8477DD0 VA: 0x847BDD0
	private void Update() { }

	// RVA: 0x847B6D4 Offset: 0x84776D4 VA: 0x847B6D4
	public void UpdateParameters() { }

	// RVA: 0x847BCE4 Offset: 0x8477CE4 VA: 0x847BCE4
	private void Init() { }

	// RVA: 0x847BED0 Offset: 0x8477ED0 VA: 0x847BED0
	public void .ctor() { }
}

// Namespace: Tayx.Graphy.Advanced
public class G_AdvancedData : MonoBehaviour, IMovable, IModifiableState // TypeDefIndex: 27688
{
	// Fields
	[SerializeField]
	private List<Image> m_backgroundImages; // 0x20
	[SerializeField]
	private Text m_graphicsDeviceVersionText; // 0x28
	[SerializeField]
	private Text m_processorTypeText; // 0x30
	[SerializeField]
	private Text m_operatingSystemText; // 0x38
	[SerializeField]
	private Text m_systemMemoryText; // 0x40
	[SerializeField]
	private Text m_graphicsDeviceNameText; // 0x48
	[SerializeField]
	private Text m_graphicsMemorySizeText; // 0x50
	[SerializeField]
	private Text m_screenResolutionText; // 0x58
	[SerializeField]
	private Text m_gameWindowResolutionText; // 0x60
	[SerializeField]
	private Text m_gameVRResolutionText; // 0x68
	private readonly List<XRDisplaySubsystem> m_displaySubsystems; // 0x70
	[Range(1, 60)]
	[SerializeField]
	private float m_updateRate; // 0x78
	private GraphyManager m_graphyManager; // 0x80
	private RectTransform m_rectTransform; // 0x88
	private Vector2 m_origPosition; // 0x90
	private float m_deltaTime; // 0x98
	private StringBuilder m_sb; // 0xA0
	private GraphyManager.ModuleState m_previousModuleState; // 0xA8
	private GraphyManager.ModuleState m_currentModuleState; // 0xAC
	private readonly string[] m_windowStrings; // 0xB0
	private readonly string[] m_vrStrings; // 0xB8

	// Methods

	// RVA: 0x847BEE0 Offset: 0x8477EE0 VA: 0x847BEE0
	private void Awake() { }

	// RVA: 0x847CCE4 Offset: 0x8478CE4 VA: 0x847CCE4
	private void Update() { }

	// RVA: 0x8474748 Offset: 0x8470748 VA: 0x8474748 Slot: 4
	public void SetPosition(GraphyManager.ModulePosition newModulePosition, Vector2 offset) { }

	// RVA: 0x84746A0 Offset: 0x84706A0 VA: 0x84746A0 Slot: 5
	public void SetState(GraphyManager.ModuleState state, bool silentUpdate = False) { }

	// RVA: 0x8475894 Offset: 0x8471894 VA: 0x8475894
	public void RestorePreviousState() { }

	// RVA: 0x8475A9C Offset: 0x8471A9C VA: 0x8475A9C
	public void UpdateParameters() { }

	// RVA: 0x84761C0 Offset: 0x84721C0 VA: 0x84761C0
	public void RefreshParameters() { }

	// RVA: 0x847BEE4 Offset: 0x8477EE4 VA: 0x847BEE4
	private void Init() { }

	// RVA: 0x847D258 Offset: 0x8479258 VA: 0x847D258
	public void .ctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=909 // TypeDefIndex: 27689
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 // TypeDefIndex: 27690
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 27691
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=909 6F50655316B93865C309A9ADF29C172B940F2909CE79875D7A478261DD708C85 /*Metadata offset 0xF4FAD0*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 D0D23B030BF1C90778BA95745088B39866835C2960407F1E2DF662F1358A1D16 /*Metadata offset 0xF4FE60*/; // 0x38D
}

