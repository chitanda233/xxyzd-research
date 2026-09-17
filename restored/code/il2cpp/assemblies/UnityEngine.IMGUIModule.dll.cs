// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 24560
{}

// Namespace: UnityEngine
[StaticAccessor("GUIEvent", 2)]
[NativeHeader("Modules/IMGUI/Event.bindings.h")]
public sealed class Event // TypeDefIndex: 24561
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private static Event s_Current; // 0x0
	private static Event s_MasterEvent; // 0x8

	// Properties
	[NativeProperty("type", False, 1)]
	public EventType rawType { get; }
	[NativeProperty("mousePosition", False, 1)]
	public Vector2 mousePosition { get; set; }
	[NativeProperty("delta", False, 1)]
	public Vector2 delta { get; set; }
	[NativeProperty("pointerType", False, 1)]
	public PointerType pointerType { get; }
	[NativeProperty("button", False, 1)]
	public int button { get; }
	[NativeProperty("modifiers", False, 1)]
	public EventModifiers modifiers { get; set; }
	[NativeProperty("pressure", False, 1)]
	public float pressure { get; }
	[NativeProperty("twist", False, 1)]
	public float twist { get; }
	[NativeProperty("tilt", False, 1)]
	public Vector2 tilt { get; }
	[NativeProperty("penStatus", False, 1)]
	public PenStatus penStatus { get; }
	[NativeProperty("clickCount", False, 1)]
	public int clickCount { get; }
	[NativeProperty("character", False, 1)]
	public char character { get; set; }
	[NativeProperty("keycode", False, 1)]
	public KeyCode keyCode { get; set; }
	[NativeProperty("displayIndex", False, 1)]
	public int displayIndex { get; set; }
	public EventType type { get; set; }
	public string commandName { get; set; }
	public bool shift { get; }
	public bool control { get; }
	public bool alt { get; }
	public bool command { get; }
	public static Event current { get; set; }
	public bool isKey { get; }
	public bool isMouse { get; }
	internal bool isDirectManipulationDevice { get; }

	// Methods

	// RVA: 0x8781D60 Offset: 0x877DD60 VA: 0x8781D60
	public EventType get_rawType() { }

	// RVA: 0x8781D9C Offset: 0x877DD9C VA: 0x8781D9C
	public Vector2 get_mousePosition() { }

	// RVA: 0x8781E2C Offset: 0x877DE2C VA: 0x8781E2C
	public void set_mousePosition(Vector2 value) { }

	// RVA: 0x8781EB8 Offset: 0x877DEB8 VA: 0x8781EB8
	public Vector2 get_delta() { }

	// RVA: 0x8781F48 Offset: 0x877DF48 VA: 0x8781F48
	public void set_delta(Vector2 value) { }

	// RVA: 0x8781FD4 Offset: 0x877DFD4 VA: 0x8781FD4
	public PointerType get_pointerType() { }

	// RVA: 0x8782010 Offset: 0x877E010 VA: 0x8782010
	public int get_button() { }

	// RVA: 0x878204C Offset: 0x877E04C VA: 0x878204C
	public EventModifiers get_modifiers() { }

	// RVA: 0x8782088 Offset: 0x877E088 VA: 0x8782088
	public void set_modifiers(EventModifiers value) { }

	// RVA: 0x87820CC Offset: 0x877E0CC VA: 0x87820CC
	public float get_pressure() { }

	// RVA: 0x8782108 Offset: 0x877E108 VA: 0x8782108
	public float get_twist() { }

	// RVA: 0x8782144 Offset: 0x877E144 VA: 0x8782144
	public Vector2 get_tilt() { }

	// RVA: 0x87821D4 Offset: 0x877E1D4 VA: 0x87821D4
	public PenStatus get_penStatus() { }

	// RVA: 0x8782210 Offset: 0x877E210 VA: 0x8782210
	public int get_clickCount() { }

	// RVA: 0x878224C Offset: 0x877E24C VA: 0x878224C
	public char get_character() { }

	// RVA: 0x8782288 Offset: 0x877E288 VA: 0x8782288
	public void set_character(char value) { }

	// RVA: 0x87822CC Offset: 0x877E2CC VA: 0x87822CC
	public KeyCode get_keyCode() { }

	// RVA: 0x8782308 Offset: 0x877E308 VA: 0x8782308
	public void set_keyCode(KeyCode value) { }

	// RVA: 0x878234C Offset: 0x877E34C VA: 0x878234C
	public int get_displayIndex() { }

	// RVA: 0x8782388 Offset: 0x877E388 VA: 0x8782388
	public void set_displayIndex(int value) { }

	[FreeFunction("GUIEvent::GetType", HasExplicitThis = True)]
	// RVA: 0x87823CC Offset: 0x877E3CC VA: 0x87823CC
	public EventType get_type() { }

	[FreeFunction("GUIEvent::SetType", HasExplicitThis = True)]
	// RVA: 0x8782408 Offset: 0x877E408 VA: 0x8782408
	public void set_type(EventType value) { }

	[FreeFunction("GUIEvent::GetCommandName", HasExplicitThis = True)]
	// RVA: 0x878244C Offset: 0x877E44C VA: 0x878244C
	public string get_commandName() { }

	[FreeFunction("GUIEvent::SetCommandName", HasExplicitThis = True)]
	// RVA: 0x8782488 Offset: 0x877E488 VA: 0x8782488
	public void set_commandName(string value) { }

	[NativeMethod("Use")]
	// RVA: 0x87824CC Offset: 0x877E4CC VA: 0x87824CC
	private void Internal_Use() { }

	[FreeFunction("GUIEvent::Internal_Create", IsThreadSafe = True)]
	// RVA: 0x8782508 Offset: 0x877E508 VA: 0x8782508
	private static IntPtr Internal_Create(int displayIndex) { }

	[FreeFunction("GUIEvent::Internal_Destroy", IsThreadSafe = True)]
	// RVA: 0x8782544 Offset: 0x877E544 VA: 0x8782544
	private static void Internal_Destroy(IntPtr ptr) { }

	[FreeFunction("GUIEvent::GetTypeForControl", HasExplicitThis = True)]
	// RVA: 0x8782580 Offset: 0x877E580 VA: 0x8782580
	public EventType GetTypeForControl(int controlID) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	[FreeFunction("GUIEvent::CopyFromPtr", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x87825C4 Offset: 0x877E5C4 VA: 0x87825C4
	internal void CopyFromPtr(IntPtr ptr) { }

	// RVA: 0x8782608 Offset: 0x877E608 VA: 0x8782608
	public static bool PopEvent(Event outEvent) { }

	// RVA: 0x8782644 Offset: 0x877E644 VA: 0x8782644
	private static void Internal_SetNativeEvent(IntPtr ptr) { }

	[RequiredByNativeCode]
	// RVA: 0x8782680 Offset: 0x877E680 VA: 0x8782680
	internal static void Internal_MakeMasterEventCurrent(int displayIndex) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x87827E0 Offset: 0x877E7E0 VA: 0x87827E0
	internal static int GetDoubleClickTime() { }

	// RVA: 0x8782808 Offset: 0x877E808 VA: 0x8782808
	public void .ctor() { }

	// RVA: 0x8782790 Offset: 0x877E790 VA: 0x8782790
	public void .ctor(int displayIndex) { }

	// RVA: 0x8782854 Offset: 0x877E854 VA: 0x8782854 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x878292C Offset: 0x877E92C VA: 0x878292C
	internal void CopyFrom(Event e) { }

	// RVA: 0x878299C Offset: 0x877E99C VA: 0x878299C
	public bool get_shift() { }

	// RVA: 0x87829E0 Offset: 0x877E9E0 VA: 0x87829E0
	public bool get_control() { }

	// RVA: 0x8782A24 Offset: 0x877EA24 VA: 0x8782A24
	public bool get_alt() { }

	// RVA: 0x8782A68 Offset: 0x877EA68 VA: 0x8782A68
	public bool get_command() { }

	// RVA: 0x8782AAC Offset: 0x877EAAC VA: 0x8782AAC
	public static Event get_current() { }

	// RVA: 0x8782AF4 Offset: 0x877EAF4 VA: 0x8782AF4
	public static void set_current(Event value) { }

	// RVA: 0x8782B98 Offset: 0x877EB98 VA: 0x8782B98
	public bool get_isKey() { }

	// RVA: 0x8782BE4 Offset: 0x877EBE4 VA: 0x8782BE4
	public bool get_isMouse() { }

	// RVA: 0x8782C48 Offset: 0x877EC48 VA: 0x8782C48
	internal bool get_isDirectManipulationDevice() { }

	// RVA: 0x8782CC4 Offset: 0x877ECC4 VA: 0x8782CC4
	public static Event KeyboardEvent(string key) { }

	// RVA: 0x8784CA4 Offset: 0x8780CA4 VA: 0x8784CA4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x8784DA4 Offset: 0x8780DA4 VA: 0x8784DA4 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x8785010 Offset: 0x8781010 VA: 0x8785010 Slot: 3
	public override string ToString() { }

	// RVA: 0x878588C Offset: 0x878188C VA: 0x878588C
	public void Use() { }

	// RVA: 0x8781DE8 Offset: 0x877DDE8 VA: 0x8781DE8
	private void get_mousePosition_Injected(out Vector2 ret) { }

	// RVA: 0x8781E74 Offset: 0x877DE74 VA: 0x8781E74
	private void set_mousePosition_Injected(ref Vector2 value) { }

	// RVA: 0x8781F04 Offset: 0x877DF04 VA: 0x8781F04
	private void get_delta_Injected(out Vector2 ret) { }

	// RVA: 0x8781F90 Offset: 0x877DF90 VA: 0x8781F90
	private void set_delta_Injected(ref Vector2 value) { }

	// RVA: 0x8782190 Offset: 0x877E190 VA: 0x8782190
	private void get_tilt_Injected(out Vector2 ret) { }
}

// Namespace: UnityEngine
public enum EventType // TypeDefIndex: 24562
{
	// Fields
	public int value__; // 0x0
	public const EventType MouseDown = 0;
	public const EventType MouseUp = 1;
	public const EventType MouseMove = 2;
	public const EventType MouseDrag = 3;
	public const EventType KeyDown = 4;
	public const EventType KeyUp = 5;
	public const EventType ScrollWheel = 6;
	public const EventType Repaint = 7;
	public const EventType Layout = 8;
	public const EventType DragUpdated = 9;
	public const EventType DragPerform = 10;
	public const EventType DragExited = 15;
	public const EventType Ignore = 11;
	public const EventType Used = 12;
	public const EventType ValidateCommand = 13;
	public const EventType ExecuteCommand = 14;
	public const EventType ContextClick = 16;
	public const EventType MouseEnterWindow = 20;
	public const EventType MouseLeaveWindow = 21;
	public const EventType TouchDown = 30;
	public const EventType TouchUp = 31;
	public const EventType TouchMove = 32;
	public const EventType TouchEnter = 33;
	public const EventType TouchLeave = 34;
	public const EventType TouchStationary = 35;
	[Obsolete("Use MouseDown instead (UnityUpgradable) -> MouseDown", True)]
	[EditorBrowsable(1)]
	public const EventType mouseDown = 0;
	[EditorBrowsable(1)]
	[Obsolete("Use MouseUp instead (UnityUpgradable) -> MouseUp", True)]
	public const EventType mouseUp = 1;
	[EditorBrowsable(1)]
	[Obsolete("Use MouseMove instead (UnityUpgradable) -> MouseMove", True)]
	public const EventType mouseMove = 2;
	[EditorBrowsable(1)]
	[Obsolete("Use MouseDrag instead (UnityUpgradable) -> MouseDrag", True)]
	public const EventType mouseDrag = 3;
	[EditorBrowsable(1)]
	[Obsolete("Use KeyDown instead (UnityUpgradable) -> KeyDown", True)]
	public const EventType keyDown = 4;
	[Obsolete("Use KeyUp instead (UnityUpgradable) -> KeyUp", True)]
	[EditorBrowsable(1)]
	public const EventType keyUp = 5;
	[EditorBrowsable(1)]
	[Obsolete("Use ScrollWheel instead (UnityUpgradable) -> ScrollWheel", True)]
	public const EventType scrollWheel = 6;
	[EditorBrowsable(1)]
	[Obsolete("Use Repaint instead (UnityUpgradable) -> Repaint", True)]
	public const EventType repaint = 7;
	[Obsolete("Use Layout instead (UnityUpgradable) -> Layout", True)]
	[EditorBrowsable(1)]
	public const EventType layout = 8;
	[Obsolete("Use DragUpdated instead (UnityUpgradable) -> DragUpdated", True)]
	[EditorBrowsable(1)]
	public const EventType dragUpdated = 9;
	[EditorBrowsable(1)]
	[Obsolete("Use DragPerform instead (UnityUpgradable) -> DragPerform", True)]
	public const EventType dragPerform = 10;
	[EditorBrowsable(1)]
	[Obsolete("Use Ignore instead (UnityUpgradable) -> Ignore", True)]
	public const EventType ignore = 11;
	[EditorBrowsable(1)]
	[Obsolete("Use Used instead (UnityUpgradable) -> Used", True)]
	public const EventType used = 12;
}

// Namespace: UnityEngine
[Flags]
public enum EventModifiers // TypeDefIndex: 24563
{
	// Fields
	public int value__; // 0x0
	public const EventModifiers None = 0;
	public const EventModifiers Shift = 1;
	public const EventModifiers Control = 2;
	public const EventModifiers Alt = 4;
	public const EventModifiers Command = 8;
	public const EventModifiers Numeric = 16;
	public const EventModifiers CapsLock = 32;
	public const EventModifiers FunctionKey = 64;
}

// Namespace: UnityEngine
public enum PointerType // TypeDefIndex: 24564
{
	// Fields
	public int value__; // 0x0
	public const PointerType Mouse = 0;
	public const PointerType Touch = 1;
	public const PointerType Pen = 2;
}

// Namespace: UnityEngine
internal struct EventInterests // TypeDefIndex: 24565
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <wantsMouseMove>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <wantsMouseEnterLeaveWindow>k__BackingField; // 0x1
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <wantsLessLayoutEvents>k__BackingField; // 0x2

	// Properties
	public bool wantsMouseMove { get; set; }
	public bool wantsMouseEnterLeaveWindow { get; set; }
	public bool wantsLessLayoutEvents { get; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x8785A64 Offset: 0x8781A64 VA: 0x8785A64
	public bool get_wantsMouseMove() { }

	[CompilerGenerated]
	// RVA: 0x8785A6C Offset: 0x8781A6C VA: 0x8785A6C
	public void set_wantsMouseMove(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x8785A78 Offset: 0x8781A78 VA: 0x8785A78
	public bool get_wantsMouseEnterLeaveWindow() { }

	[CompilerGenerated]
	// RVA: 0x8785A80 Offset: 0x8781A80 VA: 0x8785A80
	public void set_wantsMouseEnterLeaveWindow(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x8785A8C Offset: 0x8781A8C VA: 0x8785A8C
	public bool get_wantsLessLayoutEvents() { }

	// RVA: 0x8785A94 Offset: 0x8781A94 VA: 0x8785A94
	public bool WantsEvent(EventType type) { }

	// RVA: 0x8785AC4 Offset: 0x8781AC4 VA: 0x8785AC4
	public bool WantsLayoutPass(EventType type) { }
}

// Namespace: 
public enum GUI.ToolbarButtonSize // TypeDefIndex: 24566
{
	// Fields
	public int value__; // 0x0
	public const GUI.ToolbarButtonSize Fixed = 0;
	public const GUI.ToolbarButtonSize FitToContents = 1;
}

// Namespace: 
internal sealed class GUI.CustomSelectionGridItemGUI : MulticastDelegate // TypeDefIndex: 24567
{
	// Methods

	// RVA: 0x8795B9C Offset: 0x8791B9C VA: 0x8795B9C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x8795C3C Offset: 0x8791C3C VA: 0x8795C3C Slot: 13
	public virtual void Invoke(int item, Rect rect, GUIStyle style, int controlID) { }
}

// Namespace: 
public sealed class GUI.WindowFunction : MulticastDelegate // TypeDefIndex: 24568
{
	// Methods

	// RVA: 0x8795C50 Offset: 0x8791C50 VA: 0x8795C50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x8795CF0 Offset: 0x8791CF0 VA: 0x8795CF0 Slot: 13
	public virtual void Invoke(int id) { }
}

// Namespace: 
public abstract class GUI.Scope : IDisposable // TypeDefIndex: 24569
{
	// Fields
	private bool m_Disposed; // 0x10

	// Methods

	// RVA: 0x8795D04 Offset: 0x8791D04 VA: 0x8795D04 Slot: 5
	internal virtual void Dispose(bool disposing) { }

	// RVA: 0x8795DBC Offset: 0x8791DBC VA: 0x8795DBC Slot: 1
	protected override void Finalize() { }

	// RVA: 0x8795F68 Offset: 0x8791F68 VA: 0x8795F68 Slot: 4
	public void Dispose() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void CloseScope();

	// RVA: 0x8795FD4 Offset: 0x8791FD4 VA: 0x8795FD4
	protected void .ctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUI.bindings.h")]
[NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
public class GUI // TypeDefIndex: 24570
{
	// Fields
	private const float s_ScrollStepSize = 10;
	private static int s_ScrollControlId; // 0x0
	private static int s_HotTextField; // 0x4
	private static readonly int s_BoxHash; // 0x8
	private static readonly int s_ButonHash; // 0xC
	private static readonly int s_RepeatButtonHash; // 0x10
	private static readonly int s_ToggleHash; // 0x14
	private static readonly int s_ButtonGridHash; // 0x18
	private static readonly int s_SliderHash; // 0x1C
	private static readonly int s_BeginGroupHash; // 0x20
	private static readonly int s_ScrollviewHash; // 0x24
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static int <scrollTroughSide>k__BackingField; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static DateTime <nextScrollStepTime>k__BackingField; // 0x30
	private static GUISkin s_Skin; // 0x38
	internal static Rect s_ToolTipRect; // 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static GenericStack <scrollViewStates>k__BackingField; // 0x50

	// Properties
	public static Color color { get; set; }
	public static Color backgroundColor { get; set; }
	public static Color contentColor { get; set; }
	public static bool changed { get; set; }
	public static bool enabled { get; set; }
	public static int depth { get; set; }
	internal static bool usePageScrollbars { get; }
	internal static bool isInsideList { get; set; }
	internal static Material blendMaterial { get; }
	internal static Material blitMaterial { get; }
	internal static Material roundedRectMaterial { get; }
	internal static Material roundedRectWithColorPerBorderMaterial { get; }
	internal static int scrollTroughSide { get; set; }
	internal static DateTime nextScrollStepTime { get; set; }
	public static GUISkin skin { get; set; }
	public static Matrix4x4 matrix { get; set; }
	public static string tooltip { get; set; }
	protected static string mouseTooltip { get; }
	protected static Rect tooltipRect { get; set; }
	internal static GenericStack scrollViewStates { get; set; }

	// Methods

	// RVA: 0x8785B88 Offset: 0x8781B88 VA: 0x8785B88
	public static Color get_color() { }

	// RVA: 0x8785C4C Offset: 0x8781C4C VA: 0x8785C4C
	public static void set_color(Color value) { }

	// RVA: 0x8785D0C Offset: 0x8781D0C VA: 0x8785D0C
	public static Color get_backgroundColor() { }

	// RVA: 0x8785DD0 Offset: 0x8781DD0 VA: 0x8785DD0
	public static void set_backgroundColor(Color value) { }

	// RVA: 0x8785E90 Offset: 0x8781E90 VA: 0x8785E90
	public static Color get_contentColor() { }

	// RVA: 0x8785F54 Offset: 0x8781F54 VA: 0x8785F54
	public static void set_contentColor(Color value) { }

	// RVA: 0x8786014 Offset: 0x8782014 VA: 0x8786014
	public static bool get_changed() { }

	// RVA: 0x878603C Offset: 0x878203C VA: 0x878603C
	public static void set_changed(bool value) { }

	// RVA: 0x8786078 Offset: 0x8782078 VA: 0x8786078
	public static bool get_enabled() { }

	// RVA: 0x87860A0 Offset: 0x87820A0 VA: 0x87860A0
	public static void set_enabled(bool value) { }

	// RVA: 0x87860DC Offset: 0x87820DC VA: 0x87860DC
	public static int get_depth() { }

	// RVA: 0x8786104 Offset: 0x8782104 VA: 0x8786104
	public static void set_depth(int value) { }

	// RVA: 0x8786140 Offset: 0x8782140 VA: 0x8786140
	internal static bool get_usePageScrollbars() { }

	// RVA: 0x8786168 Offset: 0x8782168 VA: 0x8786168
	internal static bool get_isInsideList() { }

	// RVA: 0x8786190 Offset: 0x8782190 VA: 0x8786190
	internal static void set_isInsideList(bool value) { }

	[FreeFunction("GetGUIBlendMaterial")]
	// RVA: 0x87861CC Offset: 0x87821CC VA: 0x87861CC
	internal static Material get_blendMaterial() { }

	[FreeFunction("GetGUIBlitMaterial")]
	// RVA: 0x87861F4 Offset: 0x87821F4 VA: 0x87861F4
	internal static Material get_blitMaterial() { }

	[FreeFunction("GetGUIRoundedRectMaterial")]
	// RVA: 0x878621C Offset: 0x878221C VA: 0x878621C
	internal static Material get_roundedRectMaterial() { }

	[FreeFunction("GetGUIRoundedRectWithColorPerBorderMaterial")]
	// RVA: 0x8786244 Offset: 0x8782244 VA: 0x8786244
	internal static Material get_roundedRectWithColorPerBorderMaterial() { }

	// RVA: 0x878626C Offset: 0x878226C VA: 0x878626C
	internal static void GrabMouseControl(int id) { }

	// RVA: 0x87862A8 Offset: 0x87822A8 VA: 0x87862A8
	internal static bool HasMouseControl(int id) { }

	// RVA: 0x87862E4 Offset: 0x87822E4 VA: 0x87862E4
	internal static void ReleaseMouseControl() { }

	[FreeFunction("GetGUIState().SetNameOfNextControl")]
	// RVA: 0x878630C Offset: 0x878230C VA: 0x878630C
	public static void SetNextControlName(string name) { }

	[FreeFunction("GetGUIState().GetNameOfFocusedControl")]
	// RVA: 0x8786348 Offset: 0x8782348 VA: 0x8786348
	public static string GetNameOfFocusedControl() { }

	[FreeFunction("GetGUIState().FocusKeyboardControl")]
	// RVA: 0x8786370 Offset: 0x8782370 VA: 0x8786370
	public static void FocusControl(string name) { }

	// RVA: 0x87863AC Offset: 0x87823AC VA: 0x87863AC
	internal static void InternalRepaintEditorWindow() { }

	// RVA: 0x87863D4 Offset: 0x87823D4 VA: 0x87863D4
	private static string Internal_GetTooltip() { }

	// RVA: 0x87863FC Offset: 0x87823FC VA: 0x87863FC
	private static void Internal_SetTooltip(string value) { }

	// RVA: 0x8786438 Offset: 0x8782438 VA: 0x8786438
	private static string Internal_GetMouseTooltip() { }

	// RVA: 0x8786460 Offset: 0x8782460 VA: 0x8786460
	private static Rect Internal_DoModalWindow(int id, int instanceID, Rect clientRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, object skin) { }

	// RVA: 0x87865C8 Offset: 0x87825C8 VA: 0x87865C8
	private static Rect Internal_DoWindow(int id, int instanceID, Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout) { }

	// RVA: 0x878674C Offset: 0x878274C VA: 0x878674C
	public static void DragWindow(Rect position) { }

	// RVA: 0x878680C Offset: 0x878280C VA: 0x878680C
	public static void BringWindowToFront(int windowID) { }

	// RVA: 0x8786848 Offset: 0x8782848 VA: 0x8786848
	public static void BringWindowToBack(int windowID) { }

	// RVA: 0x8786884 Offset: 0x8782884 VA: 0x8786884
	public static void FocusWindow(int windowID) { }

	// RVA: 0x87868C0 Offset: 0x87828C0 VA: 0x87868C0
	public static void UnfocusWindow() { }

	// RVA: 0x87868E8 Offset: 0x87828E8 VA: 0x87868E8
	private static void Internal_BeginWindows() { }

	// RVA: 0x8786910 Offset: 0x8782910 VA: 0x8786910
	private static void Internal_EndWindows() { }

	// RVA: 0x8786938 Offset: 0x8782938 VA: 0x8786938
	internal static string Internal_Concatenate(GUIContent first, GUIContent second) { }

	// RVA: 0x878697C Offset: 0x878297C VA: 0x878697C
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x8786C14 Offset: 0x8782C14 VA: 0x8786C14
	internal static int get_scrollTroughSide() { }

	[CompilerGenerated]
	// RVA: 0x8786C6C Offset: 0x8782C6C VA: 0x8786C6C
	internal static void set_scrollTroughSide(int value) { }

	[CompilerGenerated]
	// RVA: 0x8786CC8 Offset: 0x8782CC8 VA: 0x8786CC8
	internal static DateTime get_nextScrollStepTime() { }

	[CompilerGenerated]
	// RVA: 0x8786D20 Offset: 0x8782D20 VA: 0x8786D20
	internal static void set_nextScrollStepTime(DateTime value) { }

	// RVA: 0x8786D7C Offset: 0x8782D7C VA: 0x8786D7C
	public static void set_skin(GUISkin value) { }

	// RVA: 0x8786ED4 Offset: 0x8782ED4 VA: 0x8786ED4
	public static GUISkin get_skin() { }

	// RVA: 0x8786DFC Offset: 0x8782DFC VA: 0x8786DFC
	internal static void DoSetSkin(GUISkin newSkin) { }

	// RVA: 0x8786F58 Offset: 0x8782F58 VA: 0x8786F58
	internal static void CleanupRoots() { }

	// RVA: 0x878711C Offset: 0x878311C VA: 0x878711C
	public static Matrix4x4 get_matrix() { }

	// RVA: 0x87871EC Offset: 0x87831EC VA: 0x87871EC
	public static void set_matrix(Matrix4x4 value) { }

	// RVA: 0x8787274 Offset: 0x8783274 VA: 0x8787274
	public static string get_tooltip() { }

	// RVA: 0x8787304 Offset: 0x8783304 VA: 0x8787304
	public static void set_tooltip(string value) { }

	// RVA: 0x8787378 Offset: 0x8783378 VA: 0x8787378
	protected static string get_mouseTooltip() { }

	// RVA: 0x87873E0 Offset: 0x87833E0 VA: 0x87873E0
	protected static Rect get_tooltipRect() { }

	// RVA: 0x878743C Offset: 0x878343C VA: 0x878743C
	protected static void set_tooltipRect(Rect value) { }

	// RVA: 0x87874B8 Offset: 0x87834B8 VA: 0x87874B8
	public static void Label(Rect position, string text) { }

	// RVA: 0x8787704 Offset: 0x8783704 VA: 0x8787704
	public static void Label(Rect position, Texture image) { }

	// RVA: 0x8787890 Offset: 0x8783890 VA: 0x8787890
	public static void Label(Rect position, GUIContent content) { }

	// RVA: 0x8787934 Offset: 0x8783934 VA: 0x8787934
	public static void Label(Rect position, string text, GUIStyle style) { }

	// RVA: 0x87879FC Offset: 0x87839FC VA: 0x87879FC
	public static void Label(Rect position, Texture image, GUIStyle style) { }

	// RVA: 0x8787644 Offset: 0x8783644 VA: 0x8787644
	public static void Label(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x8787D7C Offset: 0x8783D7C VA: 0x8787D7C
	public static void DrawTexture(Rect position, Texture image) { }

	// RVA: 0x8787E04 Offset: 0x8783E04 VA: 0x8787E04
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode) { }

	// RVA: 0x8787E9C Offset: 0x8783E9C VA: 0x8787E9C
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend) { }

	// RVA: 0x8787F3C Offset: 0x8783F3C VA: 0x8787F3C
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect) { }

	// RVA: 0x8788008 Offset: 0x8784008 VA: 0x8788008
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, float borderWidth, float borderRadius) { }

	// RVA: 0x878812C Offset: 0x878412C VA: 0x878812C
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, float borderRadius) { }

	// RVA: 0x8788268 Offset: 0x8784268 VA: 0x8788268
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses) { }

	// RVA: 0x87883B8 Offset: 0x87843B8 VA: 0x87883B8
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	// RVA: 0x8788BB8 Offset: 0x8784BB8 VA: 0x8788BB8
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color leftColor, Color topColor, Color rightColor, Color bottomColor, Vector4 borderWidths, Vector4 borderRadiuses) { }

	// RVA: 0x8788510 Offset: 0x8784510 VA: 0x8788510
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color leftColor, Color topColor, Color rightColor, Color bottomColor, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	// RVA: 0x8788E04 Offset: 0x8784E04 VA: 0x8788E04
	internal static bool CalculateScaledTextureRects(Rect position, ScaleMode scaleMode, float imageAspect, ref Rect outScreenRect, ref Rect outSourceRect) { }

	// RVA: 0x8788F08 Offset: 0x8784F08 VA: 0x8788F08
	public static void DrawTextureWithTexCoords(Rect position, Texture image, Rect texCoords) { }

	// RVA: 0x8788FC0 Offset: 0x8784FC0 VA: 0x8788FC0
	public static void DrawTextureWithTexCoords(Rect position, Texture image, Rect texCoords, bool alphaBlend) { }

	// RVA: 0x8789224 Offset: 0x8785224 VA: 0x8789224
	public static void Box(Rect position, string text) { }

	// RVA: 0x87894D4 Offset: 0x87854D4 VA: 0x87894D4
	public static void Box(Rect position, Texture image) { }

	// RVA: 0x87895AC Offset: 0x87855AC VA: 0x87895AC
	public static void Box(Rect position, GUIContent content) { }

	// RVA: 0x8789650 Offset: 0x8785650 VA: 0x8789650
	public static void Box(Rect position, string text, GUIStyle style) { }

	// RVA: 0x8789718 Offset: 0x8785718 VA: 0x8789718
	public static void Box(Rect position, Texture image, GUIStyle style) { }

	// RVA: 0x87892FC Offset: 0x87852FC VA: 0x87892FC
	public static void Box(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x87897E0 Offset: 0x87857E0 VA: 0x87897E0
	public static bool Button(Rect position, string text) { }

	// RVA: 0x87899A0 Offset: 0x87859A0 VA: 0x87899A0
	public static bool Button(Rect position, Texture image) { }

	// RVA: 0x8789A78 Offset: 0x8785A78 VA: 0x8789A78
	public static bool Button(Rect position, GUIContent content) { }

	// RVA: 0x8789B1C Offset: 0x8785B1C VA: 0x8789B1C
	public static bool Button(Rect position, string text, GUIStyle style) { }

	// RVA: 0x8789BE4 Offset: 0x8785BE4 VA: 0x8789BE4
	public static bool Button(Rect position, Texture image, GUIStyle style) { }

	// RVA: 0x87898B8 Offset: 0x87858B8 VA: 0x87898B8
	public static bool Button(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x8789CAC Offset: 0x8785CAC VA: 0x8789CAC
	internal static bool Button(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x8789E84 Offset: 0x8785E84 VA: 0x8789E84
	public static bool RepeatButton(Rect position, string text) { }

	// RVA: 0x878A340 Offset: 0x8786340 VA: 0x878A340
	public static bool RepeatButton(Rect position, Texture image) { }

	// RVA: 0x878A41C Offset: 0x878641C VA: 0x878A41C
	public static bool RepeatButton(Rect position, GUIContent content) { }

	// RVA: 0x878A4C4 Offset: 0x87864C4 VA: 0x878A4C4
	public static bool RepeatButton(Rect position, string text, GUIStyle style) { }

	// RVA: 0x878A590 Offset: 0x8786590 VA: 0x878A590
	public static bool RepeatButton(Rect position, Texture image, GUIStyle style) { }

	// RVA: 0x878A65C Offset: 0x878665C VA: 0x878A65C
	public static bool RepeatButton(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x8789F60 Offset: 0x8785F60 VA: 0x8789F60
	private static bool DoRepeatButton(Rect position, GUIContent content, GUIStyle style, FocusType focusType) { }

	// RVA: 0x878A6F4 Offset: 0x87866F4 VA: 0x878A6F4
	public static string TextField(Rect position, string text) { }

	// RVA: 0x878A8E4 Offset: 0x87868E4 VA: 0x878A8E4
	public static string TextField(Rect position, string text, int maxLength) { }

	// RVA: 0x878AA20 Offset: 0x8786A20 VA: 0x878AA20
	public static string TextField(Rect position, string text, GUIStyle style) { }

	// RVA: 0x878AB4C Offset: 0x8786B4C VA: 0x878AB4C
	public static string TextField(Rect position, string text, int maxLength, GUIStyle style) { }

	// RVA: 0x878AC7C Offset: 0x8786C7C VA: 0x878AC7C
	public static string PasswordField(Rect position, string password, char maskChar) { }

	// RVA: 0x878B028 Offset: 0x8787028 VA: 0x878B028
	public static string PasswordField(Rect position, string password, char maskChar, int maxLength) { }

	// RVA: 0x878B0DC Offset: 0x87870DC VA: 0x878B0DC
	public static string PasswordField(Rect position, string password, char maskChar, GUIStyle style) { }

	// RVA: 0x878AD2C Offset: 0x8786D2C VA: 0x878AD2C
	public static string PasswordField(Rect position, string password, char maskChar, int maxLength, GUIStyle style) { }

	// RVA: 0x878B17C Offset: 0x878717C VA: 0x878B17C
	internal static string PasswordFieldGetStrToShow(string password, char maskChar) { }

	// RVA: 0x878B630 Offset: 0x8787630 VA: 0x878B630
	public static string TextArea(Rect position, string text) { }

	// RVA: 0x878B760 Offset: 0x8787760 VA: 0x878B760
	public static string TextArea(Rect position, string text, int maxLength) { }

	// RVA: 0x878B89C Offset: 0x878789C VA: 0x878B89C
	public static string TextArea(Rect position, string text, GUIStyle style) { }

	// RVA: 0x878B9C8 Offset: 0x87879C8 VA: 0x878B9C8
	public static string TextArea(Rect position, string text, int maxLength, GUIStyle style) { }

	// RVA: 0x878A824 Offset: 0x8786824 VA: 0x878A824
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style) { }

	// RVA: 0x878BAF8 Offset: 0x8787AF8 VA: 0x878BAF8
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText) { }

	// RVA: 0x878B2C0 Offset: 0x87872C0 VA: 0x878B2C0
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar) { }

	// RVA: 0x878BFCC Offset: 0x8787FCC VA: 0x878BFCC
	private static void HandleTextFieldEventForTouchscreen(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar, TextEditor editor) { }

	// RVA: 0x878C470 Offset: 0x8788470 VA: 0x878C470
	private static void HandleTextFieldEventForDesktop(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, TextEditor editor) { }

	// RVA: 0x878BC28 Offset: 0x8787C28 VA: 0x878BC28
	private static void HandleTextFieldEventForDesktopWithForcedKeyboard(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, TextEditor editor) { }

	// RVA: 0x878CC60 Offset: 0x8788C60 VA: 0x878CC60
	public static bool Toggle(Rect position, bool value, string text) { }

	// RVA: 0x878CE3C Offset: 0x8788E3C VA: 0x878CE3C
	public static bool Toggle(Rect position, bool value, Texture image) { }

	// RVA: 0x878CF28 Offset: 0x8788F28 VA: 0x878CF28
	public static bool Toggle(Rect position, bool value, GUIContent content) { }

	// RVA: 0x878CFE0 Offset: 0x8788FE0 VA: 0x878CFE0
	public static bool Toggle(Rect position, bool value, string text, GUIStyle style) { }

	// RVA: 0x878D0B0 Offset: 0x87890B0 VA: 0x878D0B0
	public static bool Toggle(Rect position, bool value, Texture image, GUIStyle style) { }

	// RVA: 0x878CD4C Offset: 0x8788D4C VA: 0x878CD4C
	public static bool Toggle(Rect position, bool value, GUIContent content, GUIStyle style) { }

	// RVA: 0x878D29C Offset: 0x878929C VA: 0x878D29C
	public static bool Toggle(Rect position, int id, bool value, GUIContent content, GUIStyle style) { }

	// RVA: 0x878D374 Offset: 0x8789374 VA: 0x878D374
	public static int Toolbar(Rect position, int selected, string[] texts) { }

	// RVA: 0x878D62C Offset: 0x878962C VA: 0x878D62C
	public static int Toolbar(Rect position, int selected, Texture[] images) { }

	// RVA: 0x878D83C Offset: 0x878983C VA: 0x878D83C
	public static int Toolbar(Rect position, int selected, GUIContent[] contents) { }

	// RVA: 0x878D8F0 Offset: 0x87898F0 VA: 0x878D8F0
	public static int Toolbar(Rect position, int selected, string[] texts, GUIStyle style) { }

	// RVA: 0x878D9C0 Offset: 0x87899C0 VA: 0x878D9C0
	public static int Toolbar(Rect position, int selected, Texture[] images, GUIStyle style) { }

	// RVA: 0x878D584 Offset: 0x8789584 VA: 0x878D584
	public static int Toolbar(Rect position, int selected, GUIContent[] contents, GUIStyle style) { }

	// RVA: 0x878DC00 Offset: 0x8789C00 VA: 0x878DC00
	public static int Toolbar(Rect position, int selected, GUIContent[] contents, GUIStyle style, GUI.ToolbarButtonSize buttonSize) { }

	// RVA: 0x878DA90 Offset: 0x8789A90 VA: 0x878DA90
	internal static int Toolbar(Rect position, int selected, GUIContent[] contents, string[] controlNames, GUIStyle style, GUI.ToolbarButtonSize buttonSize, bool[] contentsEnabled) { }

	// RVA: 0x878EABC Offset: 0x878AABC VA: 0x878EABC
	public static int SelectionGrid(Rect position, int selected, string[] texts, int xCount) { }

	// RVA: 0x878EC8C Offset: 0x878AC8C VA: 0x878EC8C
	public static int SelectionGrid(Rect position, int selected, Texture[] images, int xCount) { }

	// RVA: 0x878ED60 Offset: 0x878AD60 VA: 0x878ED60
	public static int SelectionGrid(Rect position, int selected, GUIContent[] content, int xCount) { }

	// RVA: 0x878EE00 Offset: 0x878AE00 VA: 0x878EE00
	public static int SelectionGrid(Rect position, int selected, string[] texts, int xCount, GUIStyle style) { }

	// RVA: 0x878EEE0 Offset: 0x878AEE0 VA: 0x878EEE0
	public static int SelectionGrid(Rect position, int selected, Texture[] images, int xCount, GUIStyle style) { }

	// RVA: 0x878EB90 Offset: 0x878AB90 VA: 0x878EB90
	public static int SelectionGrid(Rect position, int selected, GUIContent[] contents, int xCount, GUIStyle style) { }

	// RVA: 0x878DCB4 Offset: 0x8789CB4 VA: 0x878DCB4
	internal static void FindStyles(ref GUIStyle style, out GUIStyle firstStyle, out GUIStyle midStyle, out GUIStyle lastStyle, string first, string mid, string last) { }

	// RVA: 0x878EFC0 Offset: 0x878AFC0 VA: 0x878EFC0
	internal static int CalcTotalHorizSpacing(int xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle) { }

	// RVA: 0x878F118 Offset: 0x878B118 VA: 0x878F118
	internal static bool DoControl(Rect position, int id, bool on, bool hover, GUIContent content, GUIStyle style) { }

	// RVA: 0x8787AC4 Offset: 0x8783AC4 VA: 0x8787AC4
	private static void DoLabel(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x878D180 Offset: 0x8789180 VA: 0x878D180
	internal static bool DoToggle(Rect position, int id, bool value, GUIContent content, GUIStyle style) { }

	// RVA: 0x8789D74 Offset: 0x8785D74 VA: 0x8789D74
	internal static bool DoButton(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x878F5F0 Offset: 0x878B5F0 VA: 0x878F5F0
	private static Rect[] CalcGridRectsFixedWidthFixedMargin(Rect position, int itemCount, int itemsPerRow, float elemWidth, float elemHeight, float spacingHorizontal, float spacingVertical) { }

	// RVA: 0x878F750 Offset: 0x878B750 VA: 0x878F750
	internal static int DoCustomSelectionGrid(Rect position, int selected, int itemCount, GUI.CustomSelectionGridItemGUI itemGUI, int itemsPerRow, GUIStyle style) { }

	// RVA: 0x878DE78 Offset: 0x8789E78 VA: 0x878DE78
	private static int DoButtonGrid(Rect position, int selected, GUIContent[] contents, string[] controlNames, int itemsPerRow, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, GUI.ToolbarButtonSize buttonSize, bool[] contentsEnabled) { }

	// RVA: 0x878FE1C Offset: 0x878BE1C VA: 0x878FE1C
	private static Rect[] CalcGridRects(Rect position, GUIContent[] contents, int xCount, float elemWidth, float elemHeight, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, GUI.ToolbarButtonSize buttonSize) { }

	// RVA: 0x87900B8 Offset: 0x878C0B8 VA: 0x87900B8
	public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue) { }

	// RVA: 0x8790358 Offset: 0x878C358 VA: 0x8790358
	public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb) { }

	// RVA: 0x8790424 Offset: 0x878C424 VA: 0x8790424
	public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUIStyle thumbExtent) { }

	// RVA: 0x879054C Offset: 0x878C54C VA: 0x879054C
	public static float VerticalSlider(Rect position, float value, float topValue, float bottomValue) { }

	// RVA: 0x8790644 Offset: 0x878C644 VA: 0x8790644
	public static float VerticalSlider(Rect position, float value, float topValue, float bottomValue, GUIStyle slider, GUIStyle thumb) { }

	// RVA: 0x8790710 Offset: 0x878C710 VA: 0x8790710
	public static float VerticalSlider(Rect position, float value, float topValue, float bottomValue, GUIStyle slider, GUIStyle thumb, GUIStyle thumbExtent) { }

	// RVA: 0x87901B0 Offset: 0x878C1B0 VA: 0x87901B0
	public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x8790838 Offset: 0x878C838 VA: 0x8790838
	public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue) { }

	// RVA: 0x8790D5C Offset: 0x878CD5C VA: 0x8790D5C
	public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle style) { }

	// RVA: 0x8790F10 Offset: 0x878CF10 VA: 0x8790F10
	internal static bool ScrollerRepeatButton(int scrollerID, Rect rect, GUIStyle style) { }

	// RVA: 0x87911E4 Offset: 0x878D1E4 VA: 0x87911E4
	public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue) { }

	// RVA: 0x87912F4 Offset: 0x878D2F4 VA: 0x87912F4
	public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue, GUIStyle style) { }

	// RVA: 0x8790948 Offset: 0x878C948 VA: 0x8790948
	internal static float Scroller(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUIStyle leftButton, GUIStyle rightButton, bool horiz) { }

	// RVA: 0x87914A8 Offset: 0x878D4A8 VA: 0x87914A8
	public static void BeginClip(Rect position, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x879156C Offset: 0x878D56C VA: 0x879156C
	public static void BeginGroup(Rect position) { }

	// RVA: 0x8791730 Offset: 0x878D730 VA: 0x8791730
	public static void BeginGroup(Rect position, string text) { }

	// RVA: 0x8791820 Offset: 0x878D820 VA: 0x8791820
	public static void BeginGroup(Rect position, Texture image) { }

	// RVA: 0x8791910 Offset: 0x878D910 VA: 0x8791910
	public static void BeginGroup(Rect position, GUIContent content) { }

	// RVA: 0x87919CC Offset: 0x878D9CC VA: 0x87919CC
	public static void BeginGroup(Rect position, GUIStyle style) { }

	// RVA: 0x8791A88 Offset: 0x878DA88 VA: 0x8791A88
	public static void BeginGroup(Rect position, string text, GUIStyle style) { }

	// RVA: 0x8791B50 Offset: 0x878DB50 VA: 0x8791B50
	public static void BeginGroup(Rect position, Texture image, GUIStyle style) { }

	// RVA: 0x8791658 Offset: 0x878D658 VA: 0x8791658
	public static void BeginGroup(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x8791C18 Offset: 0x878DC18 VA: 0x8791C18
	internal static void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset) { }

	// RVA: 0x8791EC8 Offset: 0x878DEC8 VA: 0x8791EC8
	public static void EndGroup() { }

	// RVA: 0x8791F60 Offset: 0x878DF60 VA: 0x8791F60
	public static void BeginClip(Rect position) { }

	// RVA: 0x8792024 Offset: 0x878E024 VA: 0x8792024
	public static void EndClip() { }

	[CompilerGenerated]
	// RVA: 0x87920BC Offset: 0x878E0BC VA: 0x87920BC
	internal static GenericStack get_scrollViewStates() { }

	[CompilerGenerated]
	// RVA: 0x8792114 Offset: 0x878E114 VA: 0x8792114
	internal static void set_scrollViewStates(GenericStack value) { }

	// RVA: 0x8792174 Offset: 0x878E174 VA: 0x8792174
	public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect) { }

	// RVA: 0x8792D34 Offset: 0x878ED34 VA: 0x8792D34
	public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical) { }

	// RVA: 0x8792E38 Offset: 0x878EE38 VA: 0x8792E38
	public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar) { }

	// RVA: 0x8792F14 Offset: 0x878EF14 VA: 0x8792F14
	public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar) { }

	// RVA: 0x8793000 Offset: 0x878F000 VA: 0x8793000
	protected static Vector2 DoBeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background) { }

	// RVA: 0x8792268 Offset: 0x878E268 VA: 0x8792268
	internal static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background) { }

	// RVA: 0x879312C Offset: 0x878F12C VA: 0x879312C
	public static void EndScrollView() { }

	// RVA: 0x879317C Offset: 0x878F17C VA: 0x879317C
	public static void EndScrollView(bool handleScrollWheel) { }

	// RVA: 0x8793D74 Offset: 0x878FD74 VA: 0x8793D74
	internal static ScrollViewState GetTopScrollView() { }

	// RVA: 0x8793EBC Offset: 0x878FEBC VA: 0x8793EBC
	public static void ScrollTo(Rect position) { }

	// RVA: 0x8793F58 Offset: 0x878FF58 VA: 0x8793F58
	public static bool ScrollTowards(Rect position, float maxDelta) { }

	// RVA: 0x8794008 Offset: 0x8790008 VA: 0x8794008
	public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, string text) { }

	// RVA: 0x8794228 Offset: 0x8790228 VA: 0x8794228
	public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, Texture image) { }

	// RVA: 0x879434C Offset: 0x879034C VA: 0x879434C
	public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, GUIContent content) { }

	// RVA: 0x879443C Offset: 0x879043C VA: 0x879443C
	public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, string text, GUIStyle style) { }

	// RVA: 0x8794554 Offset: 0x8790554 VA: 0x8794554
	public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, Texture image, GUIStyle style) { }

	// RVA: 0x879466C Offset: 0x879066C VA: 0x879466C
	public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style) { }

	// RVA: 0x8794750 Offset: 0x8790750 VA: 0x8794750
	public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, string text) { }

	// RVA: 0x879495C Offset: 0x879095C VA: 0x879495C
	public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, Texture image) { }

	// RVA: 0x8794A7C Offset: 0x8790A7C VA: 0x8794A7C
	public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, GUIContent content) { }

	// RVA: 0x8794B68 Offset: 0x8790B68 VA: 0x8794B68
	public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, string text, GUIStyle style) { }

	// RVA: 0x8794C7C Offset: 0x8790C7C VA: 0x8794C7C
	public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, Texture image, GUIStyle style) { }

	// RVA: 0x8794D90 Offset: 0x8790D90 VA: 0x8794D90
	public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, GUIContent content, GUIStyle style) { }

	// RVA: 0x879412C Offset: 0x879012C VA: 0x879412C
	private static Rect DoWindow(int id, Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style, GUISkin skin, bool forceRectOnLayout) { }

	// RVA: 0x8794870 Offset: 0x8790870 VA: 0x8794870
	private static Rect DoModalWindow(int id, Rect clientRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, GUISkin skin) { }

	[RequiredByNativeCode]
	// RVA: 0x8794E70 Offset: 0x8790E70 VA: 0x8794E70
	internal static void CallWindowDelegate(GUI.WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style) { }

	// RVA: 0x87958D4 Offset: 0x87918D4 VA: 0x87958D4
	public static void DragWindow() { }

	// RVA: 0x8795934 Offset: 0x8791934 VA: 0x8795934
	internal static void BeginWindows(int skinMode, int editorWindowInstanceID) { }

	// RVA: 0x8795A90 Offset: 0x8791A90 VA: 0x8795A90
	internal static void EndWindows() { }

	// RVA: 0x8795B94 Offset: 0x8791B94 VA: 0x8795B94
	public void .ctor() { }

	// RVA: 0x8785C10 Offset: 0x8781C10 VA: 0x8785C10
	private static void get_color_Injected(out Color ret) { }

	// RVA: 0x8785CD0 Offset: 0x8781CD0 VA: 0x8785CD0
	private static void set_color_Injected(ref Color value) { }

	// RVA: 0x8785D94 Offset: 0x8781D94 VA: 0x8785D94
	private static void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0x8785E54 Offset: 0x8781E54 VA: 0x8785E54
	private static void set_backgroundColor_Injected(ref Color value) { }

	// RVA: 0x8785F18 Offset: 0x8781F18 VA: 0x8785F18
	private static void get_contentColor_Injected(out Color ret) { }

	// RVA: 0x8785FD8 Offset: 0x8781FD8 VA: 0x8785FD8
	private static void set_contentColor_Injected(ref Color value) { }

	// RVA: 0x878653C Offset: 0x878253C VA: 0x878653C
	private static void Internal_DoModalWindow_Injected(int id, int instanceID, ref Rect clientRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, object skin, out Rect ret) { }

	// RVA: 0x87866B0 Offset: 0x87826B0 VA: 0x87866B0
	private static void Internal_DoWindow_Injected(int id, int instanceID, ref Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout, out Rect ret) { }

	// RVA: 0x87867D0 Offset: 0x87827D0 VA: 0x87867D0
	private static void DragWindow_Injected(ref Rect position) { }
}

// Namespace: 
internal struct GUIClip.ParentClipScope : IDisposable // TypeDefIndex: 24571
{
	// Fields
	private bool m_Disposed; // 0x0

	// Methods

	// RVA: 0x879644C Offset: 0x879244C VA: 0x879644C
	public void .ctor(Matrix4x4 objectTransform, Rect clipRect) { }

	// RVA: 0x87964A0 Offset: 0x87924A0 VA: 0x87964A0 Slot: 4
	public void Dispose() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUIState.h")]
[NativeHeader("Modules/IMGUI/GUIClip.h")]
internal sealed class GUIClip // TypeDefIndex: 24572
{
	// Properties
	internal static Rect visibleRect { get; }

	// Methods

	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetVisibleRect")]
	// RVA: 0x878F5A8 Offset: 0x878B5A8 VA: 0x878F5A8
	internal static Rect get_visibleRect() { }

	// RVA: 0x8796018 Offset: 0x8792018 VA: 0x8796018
	internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x8791F38 Offset: 0x878DF38 VA: 0x8791F38
	internal static void Internal_Pop() { }

	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetCount")]
	// RVA: 0x87960D8 Offset: 0x87920D8 VA: 0x87960D8
	internal static int Internal_GetCount() { }

	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.Unclip")]
	// RVA: 0x8796100 Offset: 0x8792100 VA: 0x8796100
	private static Vector2 Unclip_Vector2(Vector2 pos) { }

	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.UnclipToWindow")]
	// RVA: 0x8796190 Offset: 0x8792190 VA: 0x8796190
	private static Vector2 UnclipToWindow_Vector2(Vector2 pos) { }

	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.ClipToWindow")]
	// RVA: 0x8796220 Offset: 0x8792220 VA: 0x8796220
	private static Vector2 ClipToWindow_Vector2(Vector2 absolutePos) { }

	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetUserMatrix")]
	// RVA: 0x8787188 Offset: 0x8783188 VA: 0x8787188
	internal static Matrix4x4 GetMatrix() { }

	// RVA: 0x8787238 Offset: 0x8783238 VA: 0x8787238
	internal static void SetMatrix(Matrix4x4 m) { }

	// RVA: 0x8796328 Offset: 0x8792328 VA: 0x8796328
	internal static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect) { }

	// RVA: 0x8796368 Offset: 0x8792368 VA: 0x8796368
	internal static void Internal_PushParentClip(Matrix4x4 renderTransform, Matrix4x4 inputTransform, Rect clipRect) { }

	// RVA: 0x8796418 Offset: 0x8792418 VA: 0x8796418
	internal static void Internal_PopParentClip() { }

	// RVA: 0x8791564 Offset: 0x878D564 VA: 0x8791564
	internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x8792094 Offset: 0x878E094 VA: 0x8792094
	internal static void Pop() { }

	// RVA: 0x8796440 Offset: 0x8792440 VA: 0x8796440
	public static Vector2 Unclip(Vector2 pos) { }

	// RVA: 0x8796444 Offset: 0x8792444 VA: 0x8796444
	public static Vector2 UnclipToWindow(Vector2 pos) { }

	// RVA: 0x8796448 Offset: 0x8792448 VA: 0x8796448
	public static Vector2 ClipToWindow(Vector2 absolutePos) { }

	// RVA: 0x8795FDC Offset: 0x8791FDC VA: 0x8795FDC
	private static void get_visibleRect_Injected(out Rect ret) { }

	// RVA: 0x879607C Offset: 0x879207C VA: 0x879607C
	private static void Internal_Push_Injected(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x879614C Offset: 0x879214C VA: 0x879614C
	private static void Unclip_Vector2_Injected(ref Vector2 pos, out Vector2 ret) { }

	// RVA: 0x87961DC Offset: 0x87921DC VA: 0x87961DC
	private static void UnclipToWindow_Vector2_Injected(ref Vector2 pos, out Vector2 ret) { }

	// RVA: 0x879626C Offset: 0x879226C VA: 0x879626C
	private static void ClipToWindow_Vector2_Injected(ref Vector2 absolutePos, out Vector2 ret) { }

	// RVA: 0x87962B0 Offset: 0x87922B0 VA: 0x87962B0
	private static void GetMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x87962EC Offset: 0x87922EC VA: 0x87962EC
	private static void SetMatrix_Injected(ref Matrix4x4 m) { }

	// RVA: 0x87963C4 Offset: 0x87923C4 VA: 0x87963C4
	private static void Internal_PushParentClip_Injected(ref Matrix4x4 renderTransform, ref Matrix4x4 inputTransform, ref Rect clipRect) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUIContent.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Serializable]
public class GUIContent // TypeDefIndex: 24573
{
	// Fields
	[SerializeField]
	private string m_Text; // 0x10
	[SerializeField]
	private Texture m_Image; // 0x18
	[SerializeField]
	private string m_Tooltip; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action OnTextChanged; // 0x28
	private static readonly GUIContent s_Text; // 0x0
	private static readonly GUIContent s_Image; // 0x8
	private static readonly GUIContent s_TextImage; // 0x10
	public static GUIContent none; // 0x18

	// Properties
	public string text { get; set; }
	public Texture image { set; }
	public string tooltip { get; set; }
	internal int hash { get; }

	// Methods

	// RVA: 0x878A8DC Offset: 0x87868DC VA: 0x878A8DC
	public string get_text() { }

	// RVA: 0x878BBC0 Offset: 0x8787BC0 VA: 0x878BBC0
	public void set_text(string value) { }

	// RVA: 0x87964E0 Offset: 0x87924E0 VA: 0x87964E0
	public void set_image(Texture value) { }

	// RVA: 0x878F5A0 Offset: 0x878B5A0 VA: 0x878F5A0
	public string get_tooltip() { }

	// RVA: 0x87964E8 Offset: 0x87924E8 VA: 0x87964E8
	public void set_tooltip(string value) { }

	// RVA: 0x87964F0 Offset: 0x87924F0 VA: 0x87964F0
	public void .ctor() { }

	// RVA: 0x8796568 Offset: 0x8792568 VA: 0x8796568
	public void .ctor(string text) { }

	// RVA: 0x8796690 Offset: 0x8792690 VA: 0x8796690
	public void .ctor(Texture image) { }

	// RVA: 0x87965CC Offset: 0x87925CC VA: 0x87965CC
	public void .ctor(string text, Texture image, string tooltip) { }

	// RVA: 0x87966F4 Offset: 0x87926F4 VA: 0x87966F4
	public void .ctor(GUIContent src) { }

	// RVA: 0x87967B0 Offset: 0x87927B0 VA: 0x87967B0
	internal int get_hash() { }

	// RVA: 0x8787590 Offset: 0x8783590 VA: 0x8787590
	internal static GUIContent Temp(string t) { }

	// RVA: 0x87877DC Offset: 0x87837DC VA: 0x87877DC
	internal static GUIContent Temp(Texture i) { }

	// RVA: 0x87967F8 Offset: 0x87927F8 VA: 0x87967F8
	internal static void ClearStaticCache() { }

	// RVA: 0x878D45C Offset: 0x878945C VA: 0x878D45C
	internal static GUIContent[] Temp(string[] texts) { }

	// RVA: 0x878D714 Offset: 0x8789714 VA: 0x878D714
	internal static GUIContent[] Temp(Texture[] images) { }

	// RVA: 0x8796910 Offset: 0x8792910 VA: 0x8796910 Slot: 3
	public override string ToString() { }

	// RVA: 0x8796930 Offset: 0x8792930 VA: 0x8796930
	private static void .cctor() { }
}

// Namespace: UnityEngine
public enum ScaleMode // TypeDefIndex: 24574
{
	// Fields
	public int value__; // 0x0
	public const ScaleMode StretchToFill = 0;
	public const ScaleMode ScaleAndCrop = 1;
	public const ScaleMode ScaleToFit = 2;
}

// Namespace: UnityEngine
public enum FocusType // TypeDefIndex: 24575
{
	// Fields
	public int value__; // 0x0
	[Obsolete("FocusType.Native now behaves the same as FocusType.Passive in all OS cases. (UnityUpgradable) -> Passive", False)]
	public const FocusType Native = 0;
	public const FocusType Keyboard = 1;
	public const FocusType Passive = 2;
}

// Namespace: 
public class GUILayout.HorizontalScope : GUI.Scope // TypeDefIndex: 24576
{
	// Methods

	// RVA: 0x8799A7C Offset: 0x8795A7C VA: 0x8799A7C
	public void .ctor(GUILayoutOption[] options) { }

	// RVA: 0x8799A98 Offset: 0x8795A98 VA: 0x8799A98 Slot: 6
	protected override void CloseScope() { }
}

// Namespace: UnityEngine
public class GUILayout // TypeDefIndex: 24577
{
	// Methods

	// RVA: 0x8796A18 Offset: 0x8792A18 VA: 0x8796A18
	public static void Label(string text, GUILayoutOption[] options) { }

	// RVA: 0x8796B94 Offset: 0x8792B94 VA: 0x8796B94
	public static void Label(GUIContent content, GUILayoutOption[] options) { }

	// RVA: 0x8796C10 Offset: 0x8792C10 VA: 0x8796C10
	public static void Label(string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x8796AC8 Offset: 0x8792AC8 VA: 0x8796AC8
	private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x8796CEC Offset: 0x8792CEC VA: 0x8796CEC
	public static void Box(Texture image, GUILayoutOption[] options) { }

	// RVA: 0x8796E68 Offset: 0x8792E68 VA: 0x8796E68
	public static void Box(string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x8796D9C Offset: 0x8792D9C VA: 0x8796D9C
	private static void DoBox(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x8796ED8 Offset: 0x8792ED8 VA: 0x8796ED8
	public static bool Button(string text, GUILayoutOption[] options) { }

	// RVA: 0x8797054 Offset: 0x8793054 VA: 0x8797054
	public static bool Button(string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x8796F88 Offset: 0x8792F88 VA: 0x8796F88
	private static bool DoButton(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x87970C4 Offset: 0x87930C4 VA: 0x87970C4
	public static string TextField(string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x87972FC Offset: 0x87932FC VA: 0x87972FC
	public static string TextArea(string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x87970D8 Offset: 0x87930D8 VA: 0x87970D8
	private static string DoTextField(string text, int maxLength, bool multiline, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x8797310 Offset: 0x8793310 VA: 0x8797310
	public static int Toolbar(int selected, string[] texts, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x879739C Offset: 0x879339C VA: 0x879739C
	public static int Toolbar(int selected, GUIContent[] contents, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x87973B0 Offset: 0x87933B0 VA: 0x87973B0
	public static int Toolbar(int selected, GUIContent[] contents, GUIStyle style, GUI.ToolbarButtonSize buttonSize, GUILayoutOption[] options) { }

	// RVA: 0x87973C4 Offset: 0x87933C4 VA: 0x87973C4
	public static int Toolbar(int selected, GUIContent[] contents, bool[] enabled, GUIStyle style, GUI.ToolbarButtonSize buttonSize, GUILayoutOption[] options) { }

	// RVA: 0x8797724 Offset: 0x8793724 VA: 0x8797724
	public static float HorizontalSlider(float value, float leftValue, float rightValue, GUILayoutOption[] options) { }

	// RVA: 0x87977D0 Offset: 0x87937D0 VA: 0x87977D0
	private static float DoHorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUILayoutOption[] options) { }

	// RVA: 0x879790C Offset: 0x879390C VA: 0x879790C
	public static void Space(float pixels) { }

	// RVA: 0x8797C14 Offset: 0x8793C14 VA: 0x8797C14
	public static void FlexibleSpace() { }

	// RVA: 0x8798018 Offset: 0x8794018 VA: 0x8798018
	public static void BeginHorizontal(GUILayoutOption[] options) { }

	// RVA: 0x87980B0 Offset: 0x87940B0 VA: 0x87980B0
	public static void BeginHorizontal(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x87985B0 Offset: 0x87945B0 VA: 0x87985B0
	public static void EndHorizontal() { }

	// RVA: 0x8798884 Offset: 0x8794884 VA: 0x8798884
	public static void BeginVertical(GUILayoutOption[] options) { }

	// RVA: 0x8798AD4 Offset: 0x8794AD4 VA: 0x8798AD4
	public static void BeginVertical(GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x879891C Offset: 0x879491C VA: 0x879891C
	public static void BeginVertical(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x8798B44 Offset: 0x8794B44 VA: 0x8798B44
	public static void EndVertical() { }

	// RVA: 0x8798B90 Offset: 0x8794B90 VA: 0x8798B90
	public static void BeginArea(Rect screenRect) { }

	// RVA: 0x8798C50 Offset: 0x8794C50 VA: 0x8798C50
	public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style) { }

	// RVA: 0x8799160 Offset: 0x8795160 VA: 0x8799160
	public static void EndArea() { }

	// RVA: 0x8799408 Offset: 0x8795408 VA: 0x8799408
	public static Vector2 BeginScrollView(Vector2 scrollPosition, GUILayoutOption[] options) { }

	// RVA: 0x87994C4 Offset: 0x87954C4 VA: 0x87994C4
	public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, GUILayoutOption[] options) { }

	// RVA: 0x8799768 Offset: 0x8795768 VA: 0x8799768
	public static void EndScrollView() { }

	// RVA: 0x8799770 Offset: 0x8795770 VA: 0x8799770
	internal static void EndScrollView(bool handleScrollWheel) { }

	// RVA: 0x87952DC Offset: 0x87912DC VA: 0x87952DC
	public static GUILayoutOption Width(float width) { }

	// RVA: 0x87997EC Offset: 0x87957EC VA: 0x87997EC
	public static GUILayoutOption MinWidth(float minWidth) { }

	// RVA: 0x8799890 Offset: 0x8795890 VA: 0x8799890
	public static GUILayoutOption MaxWidth(float maxWidth) { }

	// RVA: 0x879537C Offset: 0x879137C VA: 0x879537C
	public static GUILayoutOption Height(float height) { }

	// RVA: 0x8799934 Offset: 0x8795934 VA: 0x8799934
	public static GUILayoutOption MinHeight(float minHeight) { }

	// RVA: 0x87999D8 Offset: 0x87959D8 VA: 0x87999D8
	public static GUILayoutOption MaxHeight(float maxHeight) { }

	// RVA: 0x8797F38 Offset: 0x8793F38 VA: 0x8797F38
	public static GUILayoutOption ExpandWidth(bool expand) { }

	// RVA: 0x8797E90 Offset: 0x8793E90 VA: 0x8797E90
	public static GUILayoutOption ExpandHeight(bool expand) { }
}

// Namespace: 
internal enum GUILayoutOption.Type // TypeDefIndex: 24578
{
	// Fields
	public int value__; // 0x0
	public const GUILayoutOption.Type fixedWidth = 0;
	public const GUILayoutOption.Type fixedHeight = 1;
	public const GUILayoutOption.Type minWidth = 2;
	public const GUILayoutOption.Type maxWidth = 3;
	public const GUILayoutOption.Type minHeight = 4;
	public const GUILayoutOption.Type maxHeight = 5;
	public const GUILayoutOption.Type stretchWidth = 6;
	public const GUILayoutOption.Type stretchHeight = 7;
	public const GUILayoutOption.Type alignStart = 8;
	public const GUILayoutOption.Type alignMiddle = 9;
	public const GUILayoutOption.Type alignEnd = 10;
	public const GUILayoutOption.Type alignJustify = 11;
	public const GUILayoutOption.Type equalSize = 12;
	public const GUILayoutOption.Type spacing = 13;
}

// Namespace: UnityEngine
public sealed class GUILayoutOption // TypeDefIndex: 24579
{
	// Fields
	internal GUILayoutOption.Type type; // 0x10
	internal object value; // 0x18

	// Methods

	// RVA: 0x8797FE0 Offset: 0x8793FE0 VA: 0x8797FE0
	internal void .ctor(GUILayoutOption.Type type, object value) { }
}

// Namespace: 
[DebuggerDisplay("id={id}, groups={layoutGroups.Count}")]
internal sealed class GUILayoutUtility.LayoutCache // TypeDefIndex: 24580
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <id>k__BackingField; // 0x10
	internal GUILayoutGroup topLevel; // 0x18
	internal GenericStack layoutGroups; // 0x20
	internal GUILayoutGroup windows; // 0x28

	// Properties
	private int id { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x879B218 Offset: 0x8797218 VA: 0x879B218
	private void set_id(int value) { }

	// RVA: 0x8799CF4 Offset: 0x8795CF4 VA: 0x8799CF4
	internal void .ctor(int instanceID = -1) { }

	// RVA: 0x879B220 Offset: 0x8797220 VA: 0x879B220
	public void ResetCursor() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUILayoutUtility.bindings.h")]
public class GUILayoutUtility // TypeDefIndex: 24581
{
	// Fields
	private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredLayouts; // 0x0
	private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredWindows; // 0x8
	internal static GUILayoutUtility.LayoutCache current; // 0x10
	internal static readonly Rect kDummyRect; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static int <unbalancedgroupscount>k__BackingField; // 0x28
	private static GUIStyle s_SpaceStyle; // 0x30

	// Properties
	internal static int unbalancedgroupscount { get; set; }
	internal static GUIStyle spaceStyle { get; }

	// Methods

	// RVA: 0x8799A9C Offset: 0x8795A9C VA: 0x8799A9C
	private static Rect Internal_GetWindowRect(int windowID) { }

	// RVA: 0x8799B70 Offset: 0x8795B70 VA: 0x8799B70
	private static void Internal_MoveWindow(int windowID, Rect r) { }

	[CompilerGenerated]
	// RVA: 0x8799C40 Offset: 0x8795C40 VA: 0x8799C40
	internal static int get_unbalancedgroupscount() { }

	[CompilerGenerated]
	// RVA: 0x8799C98 Offset: 0x8795C98 VA: 0x8799C98
	internal static void set_unbalancedgroupscount(int value) { }

	// RVA: 0x878703C Offset: 0x878303C VA: 0x878703C
	internal static void CleanupRoots() { }

	// RVA: 0x8799DFC Offset: 0x8795DFC VA: 0x8799DFC
	internal static GUILayoutUtility.LayoutCache GetLayoutCache(int instanceID, bool isWindow) { }

	// RVA: 0x879516C Offset: 0x879116C VA: 0x879516C
	internal static GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow) { }

	// RVA: 0x8799EA4 Offset: 0x8795EA4 VA: 0x8799EA4
	internal static void RemoveSelectedIdList(int instanceID, bool isWindow) { }

	// RVA: 0x8799F78 Offset: 0x8795F78 VA: 0x8799F78
	internal static void Begin(int instanceID) { }

	// RVA: 0x879A1A4 Offset: 0x87961A4 VA: 0x879A1A4
	internal static void BeginContainer(GUILayoutUtility.LayoutCache cache) { }

	// RVA: 0x8795420 Offset: 0x8791420 VA: 0x8795420
	internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x87956F0 Offset: 0x87916F0 VA: 0x87956F0
	internal static void Layout() { }

	// RVA: 0x879A690 Offset: 0x8796690 VA: 0x879A690
	internal static void LayoutFromEditorWindow() { }

	// RVA: 0x879A864 Offset: 0x8796864 VA: 0x879A864
	internal static void LayoutFromContainer(float w, float h) { }

	// RVA: 0x879A354 Offset: 0x8796354 VA: 0x879A354
	internal static void LayoutFreeGroup(GUILayoutGroup toplevel) { }

	// RVA: 0x879A518 Offset: 0x8796518 VA: 0x879A518
	private static void LayoutSingleGroup(GUILayoutGroup i) { }

	// RVA: 0x879A9EC Offset: 0x87969EC VA: 0x879A9EC
	private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType) { }

	// RVA: 0x8798264 Offset: 0x8794264 VA: 0x8798264
	internal static GUILayoutGroup BeginLayoutGroup(GUIStyle style, GUILayoutOption[] options, Type layoutType) { }

	// RVA: 0x87985FC Offset: 0x87945FC VA: 0x87985FC
	internal static void EndLayoutGroup() { }

	// RVA: 0x8798E4C Offset: 0x8794E4C VA: 0x8798E4C
	internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType) { }

	// RVA: 0x8799278 Offset: 0x8795278 VA: 0x8799278
	internal static void EndLayoutArea() { }

	// RVA: 0x879AB38 Offset: 0x8796B38 VA: 0x879AB38
	public static Rect GetRect(GUIContent content, GUIStyle style) { }

	// RVA: 0x8796C80 Offset: 0x8792C80 VA: 0x8796C80
	public static Rect GetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x879ABA0 Offset: 0x8796BA0 VA: 0x879ABA0
	private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x87976A0 Offset: 0x87936A0 VA: 0x87976A0
	public static Rect GetRect(float width, float height, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x879AF28 Offset: 0x8796F28 VA: 0x879AF28
	private static Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x8797B30 Offset: 0x8793B30 VA: 0x8797B30
	internal static GUIStyle get_spaceStyle() { }

	// RVA: 0x879B104 Offset: 0x8797104 VA: 0x879B104
	private static void .cctor() { }

	// RVA: 0x8799B2C Offset: 0x8795B2C VA: 0x8799B2C
	private static void Internal_GetWindowRect_Injected(int windowID, out Rect ret) { }

	// RVA: 0x8799BFC Offset: 0x8795BFC VA: 0x8799BFC
	private static void Internal_MoveWindow_Injected(int windowID, ref Rect r) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
[Serializable]
public sealed class GUISettings // TypeDefIndex: 24582
{
	// Fields
	[SerializeField]
	private bool m_DoubleClickSelectsWord; // 0x10
	[SerializeField]
	private bool m_TripleClickSelectsLine; // 0x11
	[SerializeField]
	private Color m_CursorColor; // 0x14
	[SerializeField]
	private float m_CursorFlashSpeed; // 0x24
	[SerializeField]
	private Color m_SelectionColor; // 0x28

	// Properties
	public bool doubleClickSelectsWord { get; }
	public bool tripleClickSelectsLine { get; }
	public Color cursorColor { get; }
	public float cursorFlashSpeed { get; }
	public Color selectionColor { get; }

	// Methods

	// RVA: 0x879B50C Offset: 0x879750C VA: 0x879B50C
	private static float Internal_GetCursorFlashSpeed() { }

	// RVA: 0x879B534 Offset: 0x8797534 VA: 0x879B534
	public bool get_doubleClickSelectsWord() { }

	// RVA: 0x879B53C Offset: 0x879753C VA: 0x879B53C
	public bool get_tripleClickSelectsLine() { }

	// RVA: 0x879B544 Offset: 0x8797544 VA: 0x879B544
	public Color get_cursorColor() { }

	// RVA: 0x879B550 Offset: 0x8797550 VA: 0x879B550
	public float get_cursorFlashSpeed() { }

	// RVA: 0x879B58C Offset: 0x879758C VA: 0x879B58C
	public Color get_selectionColor() { }

	// RVA: 0x879B598 Offset: 0x8797598 VA: 0x879B598
	public void .ctor() { }
}

// Namespace: 
internal sealed class GUISkin.SkinChangedDelegate : MulticastDelegate // TypeDefIndex: 24583
{
	// Methods

	// RVA: 0x879D074 Offset: 0x8799074 VA: 0x879D074
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x879D110 Offset: 0x8799110 VA: 0x879D110 Slot: 13
	public virtual void Invoke() { }
}

// Namespace: UnityEngine
[AssetFileNameExtension("guiskin", new[] {  })]
[RequiredByNativeCode]
[ExecuteInEditMode]
[Serializable]
public sealed class GUISkin : ScriptableObject // TypeDefIndex: 24584
{
	// Fields
	[SerializeField]
	private Font m_Font; // 0x18
	[SerializeField]
	private GUIStyle m_box; // 0x20
	[SerializeField]
	private GUIStyle m_button; // 0x28
	[SerializeField]
	private GUIStyle m_toggle; // 0x30
	[SerializeField]
	private GUIStyle m_label; // 0x38
	[SerializeField]
	private GUIStyle m_textField; // 0x40
	[SerializeField]
	private GUIStyle m_textArea; // 0x48
	[SerializeField]
	private GUIStyle m_window; // 0x50
	[SerializeField]
	private GUIStyle m_horizontalSlider; // 0x58
	[SerializeField]
	private GUIStyle m_horizontalSliderThumb; // 0x60
	private GUIStyle m_horizontalSliderThumbExtent; // 0x68
	[SerializeField]
	private GUIStyle m_verticalSlider; // 0x70
	[SerializeField]
	private GUIStyle m_verticalSliderThumb; // 0x78
	private GUIStyle m_verticalSliderThumbExtent; // 0x80
	private GUIStyle m_SliderMixed; // 0x88
	[SerializeField]
	private GUIStyle m_horizontalScrollbar; // 0x90
	[SerializeField]
	private GUIStyle m_horizontalScrollbarThumb; // 0x98
	[SerializeField]
	private GUIStyle m_horizontalScrollbarLeftButton; // 0xA0
	[SerializeField]
	private GUIStyle m_horizontalScrollbarRightButton; // 0xA8
	[SerializeField]
	private GUIStyle m_verticalScrollbar; // 0xB0
	[SerializeField]
	private GUIStyle m_verticalScrollbarThumb; // 0xB8
	[SerializeField]
	private GUIStyle m_verticalScrollbarUpButton; // 0xC0
	[SerializeField]
	private GUIStyle m_verticalScrollbarDownButton; // 0xC8
	[SerializeField]
	private GUIStyle m_ScrollView; // 0xD0
	[SerializeField]
	internal GUIStyle[] m_CustomStyles; // 0xD8
	[SerializeField]
	private GUISettings m_Settings; // 0xE0
	internal static GUIStyle ms_Error; // 0x0
	private Dictionary<string, GUIStyle> m_Styles; // 0xE8
	internal static GUISkin.SkinChangedDelegate m_SkinChanged; // 0x8
	internal static GUISkin current; // 0x10

	// Properties
	public Font font { get; set; }
	public GUIStyle box { get; set; }
	public GUIStyle label { get; set; }
	public GUIStyle textField { get; set; }
	public GUIStyle textArea { get; set; }
	public GUIStyle button { get; set; }
	public GUIStyle toggle { get; set; }
	public GUIStyle window { get; set; }
	public GUIStyle horizontalSlider { get; set; }
	public GUIStyle horizontalSliderThumb { get; set; }
	internal GUIStyle horizontalSliderThumbExtent { get; set; }
	internal GUIStyle sliderMixed { get; set; }
	public GUIStyle verticalSlider { get; set; }
	public GUIStyle verticalSliderThumb { get; set; }
	internal GUIStyle verticalSliderThumbExtent { get; set; }
	public GUIStyle horizontalScrollbar { get; set; }
	public GUIStyle horizontalScrollbarThumb { get; set; }
	public GUIStyle horizontalScrollbarLeftButton { get; set; }
	public GUIStyle horizontalScrollbarRightButton { get; set; }
	public GUIStyle verticalScrollbar { get; set; }
	public GUIStyle verticalScrollbarThumb { get; set; }
	public GUIStyle verticalScrollbarUpButton { get; set; }
	public GUIStyle verticalScrollbarDownButton { get; set; }
	public GUIStyle scrollView { get; set; }
	public GUIStyle[] customStyles { get; set; }
	public GUISettings settings { get; }
	internal static GUIStyle error { get; }

	// Methods

	// RVA: 0x879B5C4 Offset: 0x87975C4 VA: 0x879B5C4
	public void .ctor() { }

	// RVA: 0x879B69C Offset: 0x879769C VA: 0x879B69C
	internal void OnEnable() { }

	// RVA: 0x879B71C Offset: 0x879771C VA: 0x879B71C
	internal static void CleanupRoots() { }

	// RVA: 0x879B784 Offset: 0x8797784 VA: 0x879B784
	public Font get_font() { }

	// RVA: 0x879B78C Offset: 0x879778C VA: 0x879B78C
	public void set_font(Font value) { }

	// RVA: 0x879B8C0 Offset: 0x87978C0 VA: 0x879B8C0
	public GUIStyle get_box() { }

	// RVA: 0x879B8C8 Offset: 0x87978C8 VA: 0x879B8C8
	public void set_box(GUIStyle value) { }

	// RVA: 0x879B8E4 Offset: 0x87978E4 VA: 0x879B8E4
	public GUIStyle get_label() { }

	// RVA: 0x879B8EC Offset: 0x87978EC VA: 0x879B8EC
	public void set_label(GUIStyle value) { }

	// RVA: 0x879B908 Offset: 0x8797908 VA: 0x879B908
	public GUIStyle get_textField() { }

	// RVA: 0x879B910 Offset: 0x8797910 VA: 0x879B910
	public void set_textField(GUIStyle value) { }

	// RVA: 0x879B92C Offset: 0x879792C VA: 0x879B92C
	public GUIStyle get_textArea() { }

	// RVA: 0x879B934 Offset: 0x8797934 VA: 0x879B934
	public void set_textArea(GUIStyle value) { }

	// RVA: 0x879B950 Offset: 0x8797950 VA: 0x879B950
	public GUIStyle get_button() { }

	// RVA: 0x879B958 Offset: 0x8797958 VA: 0x879B958
	public void set_button(GUIStyle value) { }

	// RVA: 0x879B974 Offset: 0x8797974 VA: 0x879B974
	public GUIStyle get_toggle() { }

	// RVA: 0x879B97C Offset: 0x879797C VA: 0x879B97C
	public void set_toggle(GUIStyle value) { }

	// RVA: 0x879B998 Offset: 0x8797998 VA: 0x879B998
	public GUIStyle get_window() { }

	// RVA: 0x879B9A0 Offset: 0x87979A0 VA: 0x879B9A0
	public void set_window(GUIStyle value) { }

	// RVA: 0x879B9BC Offset: 0x87979BC VA: 0x879B9BC
	public GUIStyle get_horizontalSlider() { }

	// RVA: 0x879B9C4 Offset: 0x87979C4 VA: 0x879B9C4
	public void set_horizontalSlider(GUIStyle value) { }

	// RVA: 0x879B9E0 Offset: 0x87979E0 VA: 0x879B9E0
	public GUIStyle get_horizontalSliderThumb() { }

	// RVA: 0x879B9E8 Offset: 0x87979E8 VA: 0x879B9E8
	public void set_horizontalSliderThumb(GUIStyle value) { }

	// RVA: 0x879BA04 Offset: 0x8797A04 VA: 0x879BA04
	internal GUIStyle get_horizontalSliderThumbExtent() { }

	// RVA: 0x879BA0C Offset: 0x8797A0C VA: 0x879BA0C
	internal void set_horizontalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x879BA28 Offset: 0x8797A28 VA: 0x879BA28
	internal GUIStyle get_sliderMixed() { }

	// RVA: 0x879BA30 Offset: 0x8797A30 VA: 0x879BA30
	internal void set_sliderMixed(GUIStyle value) { }

	// RVA: 0x879BA4C Offset: 0x8797A4C VA: 0x879BA4C
	public GUIStyle get_verticalSlider() { }

	// RVA: 0x879BA54 Offset: 0x8797A54 VA: 0x879BA54
	public void set_verticalSlider(GUIStyle value) { }

	// RVA: 0x879BA70 Offset: 0x8797A70 VA: 0x879BA70
	public GUIStyle get_verticalSliderThumb() { }

	// RVA: 0x879BA78 Offset: 0x8797A78 VA: 0x879BA78
	public void set_verticalSliderThumb(GUIStyle value) { }

	// RVA: 0x879BA94 Offset: 0x8797A94 VA: 0x879BA94
	internal GUIStyle get_verticalSliderThumbExtent() { }

	// RVA: 0x879BA9C Offset: 0x8797A9C VA: 0x879BA9C
	internal void set_verticalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x879BAB8 Offset: 0x8797AB8 VA: 0x879BAB8
	public GUIStyle get_horizontalScrollbar() { }

	// RVA: 0x879BAC0 Offset: 0x8797AC0 VA: 0x879BAC0
	public void set_horizontalScrollbar(GUIStyle value) { }

	// RVA: 0x879BADC Offset: 0x8797ADC VA: 0x879BADC
	public GUIStyle get_horizontalScrollbarThumb() { }

	// RVA: 0x879BAE4 Offset: 0x8797AE4 VA: 0x879BAE4
	public void set_horizontalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x879BB00 Offset: 0x8797B00 VA: 0x879BB00
	public GUIStyle get_horizontalScrollbarLeftButton() { }

	// RVA: 0x879BB08 Offset: 0x8797B08 VA: 0x879BB08
	public void set_horizontalScrollbarLeftButton(GUIStyle value) { }

	// RVA: 0x879BB24 Offset: 0x8797B24 VA: 0x879BB24
	public GUIStyle get_horizontalScrollbarRightButton() { }

	// RVA: 0x879BB2C Offset: 0x8797B2C VA: 0x879BB2C
	public void set_horizontalScrollbarRightButton(GUIStyle value) { }

	// RVA: 0x879BB48 Offset: 0x8797B48 VA: 0x879BB48
	public GUIStyle get_verticalScrollbar() { }

	// RVA: 0x879BB50 Offset: 0x8797B50 VA: 0x879BB50
	public void set_verticalScrollbar(GUIStyle value) { }

	// RVA: 0x879BB6C Offset: 0x8797B6C VA: 0x879BB6C
	public GUIStyle get_verticalScrollbarThumb() { }

	// RVA: 0x879BB74 Offset: 0x8797B74 VA: 0x879BB74
	public void set_verticalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x879BB90 Offset: 0x8797B90 VA: 0x879BB90
	public GUIStyle get_verticalScrollbarUpButton() { }

	// RVA: 0x879BB98 Offset: 0x8797B98 VA: 0x879BB98
	public void set_verticalScrollbarUpButton(GUIStyle value) { }

	// RVA: 0x879BBB4 Offset: 0x8797BB4 VA: 0x879BBB4
	public GUIStyle get_verticalScrollbarDownButton() { }

	// RVA: 0x879BBBC Offset: 0x8797BBC VA: 0x879BBBC
	public void set_verticalScrollbarDownButton(GUIStyle value) { }

	// RVA: 0x879BBD8 Offset: 0x8797BD8 VA: 0x879BBD8
	public GUIStyle get_scrollView() { }

	// RVA: 0x879BBE0 Offset: 0x8797BE0 VA: 0x879BBE0
	public void set_scrollView(GUIStyle value) { }

	// RVA: 0x879BBFC Offset: 0x8797BFC VA: 0x879BBFC
	public GUIStyle[] get_customStyles() { }

	// RVA: 0x879BC04 Offset: 0x8797C04 VA: 0x879BC04
	public void set_customStyles(GUIStyle[] value) { }

	// RVA: 0x879BC20 Offset: 0x8797C20 VA: 0x879BC20
	public GUISettings get_settings() { }

	// RVA: 0x879BC28 Offset: 0x8797C28 VA: 0x879BC28
	internal static GUIStyle get_error() { }

	// RVA: 0x879B6A0 Offset: 0x87976A0 VA: 0x879B6A0
	internal void Apply() { }

	// RVA: 0x879BDC4 Offset: 0x8797DC4 VA: 0x879BDC4
	private void BuildStyleCache() { }

	// RVA: 0x879CC24 Offset: 0x8798C24 VA: 0x879CC24
	public GUIStyle GetStyle(string styleName) { }

	// RVA: 0x879CE54 Offset: 0x8798E54 VA: 0x879CE54
	public GUIStyle FindStyle(string styleName) { }

	// RVA: 0x879CEDC Offset: 0x8798EDC VA: 0x879CEDC
	internal void MakeCurrent() { }

	// RVA: 0x879CFB4 Offset: 0x8798FB4 VA: 0x879CFB4
	public IEnumerator GetEnumerator() { }
}

// Namespace: UnityEngine
internal class GUIStateObjects // TypeDefIndex: 24585
{
	// Fields
	private static Dictionary<int, object> s_StateCache; // 0x0

	// Methods

	// RVA: 0x879D124 Offset: 0x8799124 VA: 0x879D124
	internal static object GetStateObject(Type t, int controlID) { }

	// RVA: 0x879D26C Offset: 0x879926C VA: 0x879D26C
	internal static object QueryStateObject(Type t, int controlID) { }

	// RVA: 0x879D324 Offset: 0x8799324 VA: 0x879D324
	private static void .cctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
[Serializable]
public sealed class GUIStyleState // TypeDefIndex: 24586
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private readonly GUIStyle m_SourceStyle; // 0x18

	// Properties
	[NativeProperty("Background", False, 0)]
	public Texture2D background { get; set; }
	[NativeProperty("textColor", False, 1)]
	public Color textColor { get; set; }

	// Methods

	// RVA: 0x879D3BC Offset: 0x87993BC VA: 0x879D3BC
	public Texture2D get_background() { }

	// RVA: 0x879D3F8 Offset: 0x87993F8 VA: 0x879D3F8
	public void set_background(Texture2D value) { }

	// RVA: 0x879D43C Offset: 0x879943C VA: 0x879D43C
	public Color get_textColor() { }

	// RVA: 0x879CBD0 Offset: 0x8798BD0 VA: 0x879CBD0
	public void set_textColor(Color value) { }

	[FreeFunction(Name = "GUIStyleState_Bindings::Init", IsThreadSafe = True)]
	// RVA: 0x879D51C Offset: 0x879951C VA: 0x879D51C
	private static IntPtr Init() { }

	[FreeFunction(Name = "GUIStyleState_Bindings::Cleanup", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x879D544 Offset: 0x8799544 VA: 0x879D544
	private void Cleanup() { }

	// RVA: 0x879D580 Offset: 0x8799580 VA: 0x879D580
	public void .ctor() { }

	// RVA: 0x879D5C8 Offset: 0x87995C8 VA: 0x879D5C8
	private void .ctor(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x879D604 Offset: 0x8799604 VA: 0x879D604
	internal static GUIStyleState ProduceGUIStyleStateFromDeserialization(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x879D67C Offset: 0x879967C VA: 0x879D67C
	internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x879D6F4 Offset: 0x87996F4 VA: 0x879D6F4 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x879D494 Offset: 0x8799494 VA: 0x879D494
	private void get_textColor_Injected(out Color ret) { }

	// RVA: 0x879D4D8 Offset: 0x87994D8 VA: 0x879D4D8
	private void set_textColor_Injected(ref Color value) { }
}

// Namespace: UnityEngine
[NativeHeader("IMGUIScriptingClasses.h")]
[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
[RequiredByNativeCode]
[Serializable]
public sealed class GUIStyle // TypeDefIndex: 24587
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private GUIStyleState m_Normal; // 0x18
	private GUIStyleState m_Hover; // 0x20
	private GUIStyleState m_Active; // 0x28
	private GUIStyleState m_Focused; // 0x30
	private GUIStyleState m_OnNormal; // 0x38
	private GUIStyleState m_OnHover; // 0x40
	private GUIStyleState m_OnActive; // 0x48
	private GUIStyleState m_OnFocused; // 0x50
	private RectOffset m_Border; // 0x58
	private RectOffset m_Padding; // 0x60
	private RectOffset m_Margin; // 0x68
	private RectOffset m_Overflow; // 0x70
	private string m_Name; // 0x78
	internal static bool showKeyboardFocus; // 0x0
	private static GUIStyle s_None; // 0x8

	// Properties
	[NativeProperty("Name", False, 0)]
	internal string rawName { get; set; }
	[NativeProperty("Font", False, 0)]
	public Font font { get; set; }
	[NativeProperty("m_ImagePosition", False, 1)]
	public ImagePosition imagePosition { get; set; }
	[NativeProperty("m_Alignment", False, 1)]
	public TextAnchor alignment { get; set; }
	[NativeProperty("m_WordWrap", False, 1)]
	public bool wordWrap { get; set; }
	[NativeProperty("m_Clipping", False, 1)]
	public TextClipping clipping { get; set; }
	[NativeProperty("m_ContentOffset", False, 1)]
	public Vector2 contentOffset { get; set; }
	[NativeProperty("m_FixedWidth", False, 1)]
	public float fixedWidth { get; set; }
	[NativeProperty("m_FixedHeight", False, 1)]
	public float fixedHeight { get; set; }
	[NativeProperty("m_StretchWidth", False, 1)]
	public bool stretchWidth { get; set; }
	[NativeProperty("m_StretchHeight", False, 1)]
	public bool stretchHeight { get; set; }
	[NativeProperty("m_FontSize", False, 1)]
	public int fontSize { get; set; }
	[NativeProperty("m_FontStyle", False, 1)]
	public FontStyle fontStyle { get; set; }
	[NativeProperty("m_RichText", False, 1)]
	public bool richText { get; set; }
	[Obsolete("Don't use clipOffset - put things inside BeginGroup instead. This functionality will be removed in a later version.", False)]
	[NativeProperty("m_ClipOffset", False, 1)]
	public Vector2 clipOffset { get; set; }
	[NativeProperty("m_ClipOffset", False, 1)]
	internal Vector2 Internal_clipOffset { get; set; }
	public string name { get; set; }
	public GUIStyleState normal { get; set; }
	public GUIStyleState hover { get; set; }
	public GUIStyleState active { get; set; }
	public GUIStyleState onNormal { get; set; }
	public GUIStyleState onHover { get; set; }
	public GUIStyleState onActive { get; set; }
	public GUIStyleState focused { get; set; }
	public GUIStyleState onFocused { get; set; }
	public RectOffset border { get; set; }
	public RectOffset margin { get; set; }
	public RectOffset padding { get; set; }
	public RectOffset overflow { get; set; }
	public float lineHeight { get; }
	public static GUIStyle none { get; }
	public bool isHeightDependantOnWidth { get; }

	// Methods

	// RVA: 0x879D7B8 Offset: 0x87997B8 VA: 0x879D7B8
	internal string get_rawName() { }

	// RVA: 0x879D7F4 Offset: 0x87997F4 VA: 0x879D7F4
	internal void set_rawName(string value) { }

	// RVA: 0x879D838 Offset: 0x8799838 VA: 0x879D838
	public Font get_font() { }

	// RVA: 0x879D874 Offset: 0x8799874 VA: 0x879D874
	public void set_font(Font value) { }

	// RVA: 0x879D8B8 Offset: 0x87998B8 VA: 0x879D8B8
	public ImagePosition get_imagePosition() { }

	// RVA: 0x879D8F4 Offset: 0x87998F4 VA: 0x879D8F4
	public void set_imagePosition(ImagePosition value) { }

	// RVA: 0x879D938 Offset: 0x8799938 VA: 0x879D938
	public TextAnchor get_alignment() { }

	// RVA: 0x879D974 Offset: 0x8799974 VA: 0x879D974
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x879D9B8 Offset: 0x87999B8 VA: 0x879D9B8
	public bool get_wordWrap() { }

	// RVA: 0x879D9F4 Offset: 0x87999F4 VA: 0x879D9F4
	public void set_wordWrap(bool value) { }

	// RVA: 0x879DA38 Offset: 0x8799A38 VA: 0x879DA38
	public TextClipping get_clipping() { }

	// RVA: 0x879DA74 Offset: 0x8799A74 VA: 0x879DA74
	public void set_clipping(TextClipping value) { }

	// RVA: 0x879DAB8 Offset: 0x8799AB8 VA: 0x879DAB8
	public Vector2 get_contentOffset() { }

	// RVA: 0x879DB48 Offset: 0x8799B48 VA: 0x879DB48
	public void set_contentOffset(Vector2 value) { }

	// RVA: 0x879DBD4 Offset: 0x8799BD4 VA: 0x879DBD4
	public float get_fixedWidth() { }

	// RVA: 0x879DC10 Offset: 0x8799C10 VA: 0x879DC10
	public void set_fixedWidth(float value) { }

	// RVA: 0x879DC5C Offset: 0x8799C5C VA: 0x879DC5C
	public float get_fixedHeight() { }

	// RVA: 0x879DC98 Offset: 0x8799C98 VA: 0x879DC98
	public void set_fixedHeight(float value) { }

	// RVA: 0x879DCE4 Offset: 0x8799CE4 VA: 0x879DCE4
	public bool get_stretchWidth() { }

	// RVA: 0x879DD20 Offset: 0x8799D20 VA: 0x879DD20
	public void set_stretchWidth(bool value) { }

	// RVA: 0x879DD64 Offset: 0x8799D64 VA: 0x879DD64
	public bool get_stretchHeight() { }

	// RVA: 0x879CB18 Offset: 0x8798B18 VA: 0x879CB18
	public void set_stretchHeight(bool value) { }

	// RVA: 0x879DDA0 Offset: 0x8799DA0 VA: 0x879DDA0
	public int get_fontSize() { }

	// RVA: 0x879DDDC Offset: 0x8799DDC VA: 0x879DDDC
	public void set_fontSize(int value) { }

	// RVA: 0x879DE20 Offset: 0x8799E20 VA: 0x879DE20
	public FontStyle get_fontStyle() { }

	// RVA: 0x879DE5C Offset: 0x8799E5C VA: 0x879DE5C
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0x879DEA0 Offset: 0x8799EA0 VA: 0x879DEA0
	public bool get_richText() { }

	// RVA: 0x879DEDC Offset: 0x8799EDC VA: 0x879DEDC
	public void set_richText(bool value) { }

	// RVA: 0x879DF20 Offset: 0x8799F20 VA: 0x879DF20
	public Vector2 get_clipOffset() { }

	// RVA: 0x879DFB0 Offset: 0x8799FB0 VA: 0x879DFB0
	public void set_clipOffset(Vector2 value) { }

	// RVA: 0x879E03C Offset: 0x879A03C VA: 0x879E03C
	internal Vector2 get_Internal_clipOffset() { }

	// RVA: 0x879E0CC Offset: 0x879A0CC VA: 0x879E0CC
	internal void set_Internal_clipOffset(Vector2 value) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Create", IsThreadSafe = True)]
	// RVA: 0x879E158 Offset: 0x879A158 VA: 0x879E158
	private static IntPtr Internal_Create(GUIStyle self) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Copy", IsThreadSafe = True)]
	// RVA: 0x879E194 Offset: 0x879A194 VA: 0x879E194
	private static IntPtr Internal_Copy(GUIStyle self, GUIStyle other) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Destroy", IsThreadSafe = True)]
	// RVA: 0x879E1D8 Offset: 0x879A1D8 VA: 0x879E1D8
	private static void Internal_Destroy(IntPtr self) { }

	[FreeFunction(Name = "GUIStyle_Bindings::GetStyleStatePtr", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x879E214 Offset: 0x879A214 VA: 0x879E214
	private IntPtr GetStyleStatePtr(int idx) { }

	[FreeFunction(Name = "GUIStyle_Bindings::AssignStyleState", HasExplicitThis = True)]
	// RVA: 0x879E258 Offset: 0x879A258 VA: 0x879E258
	private void AssignStyleState(int idx, IntPtr srcStyleState) { }

	[FreeFunction(Name = "GUIStyle_Bindings::GetRectOffsetPtr", HasExplicitThis = True)]
	// RVA: 0x879E2AC Offset: 0x879A2AC VA: 0x879E2AC
	private IntPtr GetRectOffsetPtr(int idx) { }

	[FreeFunction(Name = "GUIStyle_Bindings::AssignRectOffset", HasExplicitThis = True)]
	// RVA: 0x879E2F0 Offset: 0x879A2F0 VA: 0x879E2F0
	private void AssignRectOffset(int idx, IntPtr srcRectOffset) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetLineHeight")]
	// RVA: 0x879E344 Offset: 0x879A344 VA: 0x879E344
	private static float Internal_GetLineHeight(IntPtr target) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw", HasExplicitThis = True)]
	// RVA: 0x879E380 Offset: 0x879A380 VA: 0x879E380
	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw2", HasExplicitThis = True)]
	// RVA: 0x879E490 Offset: 0x879A490 VA: 0x879E490
	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_DrawCursor", HasExplicitThis = True)]
	// RVA: 0x879E570 Offset: 0x879A570 VA: 0x879E570
	private void Internal_DrawCursor(Rect position, GUIContent content, int pos, Color cursorColor) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_DrawWithTextSelection", HasExplicitThis = True)]
	// RVA: 0x879E654 Offset: 0x879A654 VA: 0x879E654
	private void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetCursorPixelPosition", HasExplicitThis = True)]
	// RVA: 0x879E7E0 Offset: 0x879A7E0 VA: 0x879E7E0
	internal Vector2 Internal_GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetCursorStringIndex", HasExplicitThis = True)]
	// RVA: 0x879E8C0 Offset: 0x879A8C0 VA: 0x879E8C0
	internal int Internal_GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetSelectedRenderedText", HasExplicitThis = True)]
	// RVA: 0x879E980 Offset: 0x879A980 VA: 0x879E980
	internal string Internal_GetSelectedRenderedText(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetHyperlinksRect", HasExplicitThis = True)]
	// RVA: 0x879EA60 Offset: 0x879AA60 VA: 0x879EA60
	internal Rect[] Internal_GetHyperlinksRect(Rect localPosition, GUIContent mContent) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetNumCharactersThatFitWithinWidth", HasExplicitThis = True)]
	// RVA: 0x879EB10 Offset: 0x879AB10 VA: 0x879EB10
	internal int Internal_GetNumCharactersThatFitWithinWidth(string text, float width) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSize", HasExplicitThis = True)]
	// RVA: 0x879EB64 Offset: 0x879AB64 VA: 0x879EB64
	internal Vector2 Internal_CalcSize(GUIContent content) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSizeWithConstraints", HasExplicitThis = True)]
	// RVA: 0x879EC14 Offset: 0x879AC14 VA: 0x879EC14
	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcHeight", HasExplicitThis = True)]
	// RVA: 0x879ECD4 Offset: 0x879ACD4 VA: 0x879ECD4
	private float Internal_CalcHeight(GUIContent content, float width) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcMinMaxWidth", HasExplicitThis = True)]
	// RVA: 0x879ED28 Offset: 0x879AD28 VA: 0x879ED28
	private Vector2 Internal_CalcMinMaxWidth(GUIContent content) { }

	[FreeFunction(Name = "GUIStyle_Bindings::SetMouseTooltip")]
	// RVA: 0x879EDD8 Offset: 0x879ADD8 VA: 0x879EDD8
	internal static void SetMouseTooltip(string tooltip, Rect screenRect) { }

	[FreeFunction(Name = "GUIStyle_Bindings::IsTooltipActive")]
	// RVA: 0x879EEA8 Offset: 0x879AEA8 VA: 0x879EEA8
	internal static bool IsTooltipActive(string tooltip) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetCursorFlashOffset")]
	// RVA: 0x879EEE4 Offset: 0x879AEE4 VA: 0x879EEE4
	private static float Internal_GetCursorFlashOffset() { }

	[FreeFunction(Name = "GUIStyle::SetDefaultFont")]
	// RVA: 0x879B884 Offset: 0x8797884 VA: 0x879B884
	internal static void SetDefaultFont(Font font) { }

	// RVA: 0x879BCF0 Offset: 0x8797CF0 VA: 0x879BCF0
	public void .ctor() { }

	// RVA: 0x879EF0C Offset: 0x879AF0C VA: 0x879EF0C
	public void .ctor(GUIStyle other) { }

	// RVA: 0x879EFEC Offset: 0x879AFEC VA: 0x879EFEC Slot: 1
	protected override void Finalize() { }

	// RVA: 0x879F0FC Offset: 0x879B0FC VA: 0x879F0FC
	internal static void CleanupRoots() { }

	// RVA: 0x879F158 Offset: 0x879B158 VA: 0x879F158
	internal void InternalOnAfterDeserialize() { }

	// RVA: 0x879CAB4 Offset: 0x8798AB4 VA: 0x879CAB4
	public string get_name() { }

	// RVA: 0x879BD78 Offset: 0x8797D78 VA: 0x879BD78
	public void set_name(string value) { }

	// RVA: 0x879CB5C Offset: 0x8798B5C VA: 0x879CB5C
	public GUIStyleState get_normal() { }

	// RVA: 0x879F390 Offset: 0x879B390 VA: 0x879F390
	public void set_normal(GUIStyleState value) { }

	// RVA: 0x879F3E0 Offset: 0x879B3E0 VA: 0x879F3E0
	public GUIStyleState get_hover() { }

	// RVA: 0x879F454 Offset: 0x879B454 VA: 0x879F454
	public void set_hover(GUIStyleState value) { }

	// RVA: 0x879F4A4 Offset: 0x879B4A4 VA: 0x879F4A4
	public GUIStyleState get_active() { }

	// RVA: 0x879F518 Offset: 0x879B518 VA: 0x879F518
	public void set_active(GUIStyleState value) { }

	// RVA: 0x879F568 Offset: 0x879B568 VA: 0x879F568
	public GUIStyleState get_onNormal() { }

	// RVA: 0x879F5DC Offset: 0x879B5DC VA: 0x879F5DC
	public void set_onNormal(GUIStyleState value) { }

	// RVA: 0x879F62C Offset: 0x879B62C VA: 0x879F62C
	public GUIStyleState get_onHover() { }

	// RVA: 0x879F6A0 Offset: 0x879B6A0 VA: 0x879F6A0
	public void set_onHover(GUIStyleState value) { }

	// RVA: 0x879F6F0 Offset: 0x879B6F0 VA: 0x879F6F0
	public GUIStyleState get_onActive() { }

	// RVA: 0x879F764 Offset: 0x879B764 VA: 0x879F764
	public void set_onActive(GUIStyleState value) { }

	// RVA: 0x879F7B4 Offset: 0x879B7B4 VA: 0x879F7B4
	public GUIStyleState get_focused() { }

	// RVA: 0x879F828 Offset: 0x879B828 VA: 0x879F828
	public void set_focused(GUIStyleState value) { }

	// RVA: 0x879F878 Offset: 0x879B878 VA: 0x879F878
	public GUIStyleState get_onFocused() { }

	// RVA: 0x879F8EC Offset: 0x879B8EC VA: 0x879F8EC
	public void set_onFocused(GUIStyleState value) { }

	// RVA: 0x879F93C Offset: 0x879B93C VA: 0x879F93C
	public RectOffset get_border() { }

	// RVA: 0x879F9F4 Offset: 0x879B9F4 VA: 0x879F9F4
	public void set_border(RectOffset value) { }

	// RVA: 0x879FA44 Offset: 0x879BA44 VA: 0x879FA44
	public RectOffset get_margin() { }

	// RVA: 0x879FAFC Offset: 0x879BAFC VA: 0x879FAFC
	public void set_margin(RectOffset value) { }

	// RVA: 0x879FB4C Offset: 0x879BB4C VA: 0x879FB4C
	public RectOffset get_padding() { }

	// RVA: 0x879FC04 Offset: 0x879BC04 VA: 0x879FC04
	public void set_padding(RectOffset value) { }

	// RVA: 0x879FC54 Offset: 0x879BC54 VA: 0x879FC54
	public RectOffset get_overflow() { }

	// RVA: 0x879FD0C Offset: 0x879BD0C VA: 0x879FD0C
	public void set_overflow(RectOffset value) { }

	// RVA: 0x879FD5C Offset: 0x879BD5C VA: 0x879FD5C
	public float get_lineHeight() { }

	// RVA: 0x879FE58 Offset: 0x879BE58 VA: 0x879FE58
	public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x879FF3C Offset: 0x879BF3C VA: 0x879FF3C
	public void Draw(Rect position, string text, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x87A000C Offset: 0x879C00C VA: 0x87A000C
	public void Draw(Rect position, Texture image, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x87A00DC Offset: 0x879C0DC VA: 0x87A00DC
	public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x87A00F0 Offset: 0x879C0F0 VA: 0x87A00F0
	public void Draw(Rect position, GUIContent content, int controlID) { }

	// RVA: 0x87A0104 Offset: 0x879C104 VA: 0x87A0104
	public void Draw(Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x87A0118 Offset: 0x879C118 VA: 0x87A0118
	public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover) { }

	// RVA: 0x879FF18 Offset: 0x879BF18 VA: 0x879FF18
	private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x87A0310 Offset: 0x879C310 VA: 0x87A0310
	public void DrawCursor(Rect position, GUIContent content, int controlID, int character) { }

	// RVA: 0x87A04E4 Offset: 0x879C4E4 VA: 0x87A04E4
	internal void DrawWithTextSelection(Rect position, GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, Color selectionColor) { }

	// RVA: 0x87A0748 Offset: 0x879C748 VA: 0x87A0748
	internal void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition) { }

	// RVA: 0x87A0918 Offset: 0x879C918 VA: 0x87A0918
	public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter) { }

	// RVA: 0x87A0920 Offset: 0x879C920 VA: 0x87A0920
	public static GUIStyle op_Implicit(string str) { }

	// RVA: 0x87A0A18 Offset: 0x879CA18 VA: 0x87A0A18
	public static GUIStyle get_none() { }

	// RVA: 0x87A0AA8 Offset: 0x879CAA8 VA: 0x87A0AA8
	public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	// RVA: 0x87A0AAC Offset: 0x879CAAC VA: 0x87A0AAC
	public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	// RVA: 0x87A0AB0 Offset: 0x879CAB0 VA: 0x87A0AB0
	internal int GetNumCharactersThatFitWithinWidth(string text, float width) { }

	// RVA: 0x87A0B04 Offset: 0x879CB04 VA: 0x87A0B04
	public Vector2 CalcSize(GUIContent content) { }

	// RVA: 0x87A0B08 Offset: 0x879CB08 VA: 0x87A0B08
	internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints) { }

	// RVA: 0x87A0B0C Offset: 0x879CB0C VA: 0x87A0B0C
	public Vector2 CalcScreenSize(Vector2 contentSize) { }

	// RVA: 0x87A0C74 Offset: 0x879CC74 VA: 0x87A0C74
	public float CalcHeight(GUIContent content, float width) { }

	// RVA: 0x87A0CC8 Offset: 0x879CCC8 VA: 0x87A0CC8
	public bool get_isHeightDependantOnWidth() { }

	// RVA: 0x87A0D74 Offset: 0x879CD74 VA: 0x87A0D74
	public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth) { }

	// RVA: 0x87A0D9C Offset: 0x879CD9C VA: 0x87A0D9C Slot: 3
	public override string ToString() { }

	// RVA: 0x87A0E60 Offset: 0x879CE60 VA: 0x87A0E60
	private static void .cctor() { }

	// RVA: 0x879DB04 Offset: 0x8799B04 VA: 0x879DB04
	private void get_contentOffset_Injected(out Vector2 ret) { }

	// RVA: 0x879DB90 Offset: 0x8799B90 VA: 0x879DB90
	private void set_contentOffset_Injected(ref Vector2 value) { }

	// RVA: 0x879DF6C Offset: 0x8799F6C VA: 0x879DF6C
	private void get_clipOffset_Injected(out Vector2 ret) { }

	// RVA: 0x879DFF8 Offset: 0x8799FF8 VA: 0x879DFF8
	private void set_clipOffset_Injected(ref Vector2 value) { }

	// RVA: 0x879E088 Offset: 0x879A088 VA: 0x879E088
	private void get_Internal_clipOffset_Injected(out Vector2 ret) { }

	// RVA: 0x879E114 Offset: 0x879A114 VA: 0x879E114
	private void set_Internal_clipOffset_Injected(ref Vector2 value) { }

	// RVA: 0x879E40C Offset: 0x879A40C VA: 0x879E40C
	private void Internal_Draw_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x879E504 Offset: 0x879A504 VA: 0x879E504
	private void Internal_Draw2_Injected(ref Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x879E5E8 Offset: 0x879A5E8 VA: 0x879E5E8
	private void Internal_DrawCursor_Injected(ref Rect position, GUIContent content, int pos, ref Color cursorColor) { }

	// RVA: 0x879E724 Offset: 0x879A724 VA: 0x879E724
	private void Internal_DrawWithTextSelection_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, ref Color cursorColor, ref Color selectionColor) { }

	// RVA: 0x879E854 Offset: 0x879A854 VA: 0x879E854
	private void Internal_GetCursorPixelPosition_Injected(ref Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret) { }

	// RVA: 0x879E924 Offset: 0x879A924 VA: 0x879E924
	private int Internal_GetCursorStringIndex_Injected(ref Rect position, GUIContent content, ref Vector2 cursorPixelPosition) { }

	// RVA: 0x879E9F4 Offset: 0x879A9F4 VA: 0x879E9F4
	private string Internal_GetSelectedRenderedText_Injected(ref Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	// RVA: 0x879EABC Offset: 0x879AABC VA: 0x879EABC
	private Rect[] Internal_GetHyperlinksRect_Injected(ref Rect localPosition, GUIContent mContent) { }

	// RVA: 0x879EBC0 Offset: 0x879ABC0 VA: 0x879EBC0
	private void Internal_CalcSize_Injected(GUIContent content, out Vector2 ret) { }

	// RVA: 0x879EC78 Offset: 0x879AC78 VA: 0x879EC78
	private void Internal_CalcSizeWithConstraints_Injected(GUIContent content, ref Vector2 maxSize, out Vector2 ret) { }

	// RVA: 0x879ED84 Offset: 0x879AD84 VA: 0x879ED84
	private void Internal_CalcMinMaxWidth_Injected(GUIContent content, out Vector2 ret) { }

	// RVA: 0x879EE64 Offset: 0x879AE64 VA: 0x879EE64
	private static void SetMouseTooltip_Injected(string tooltip, ref Rect screenRect) { }
}

// Namespace: UnityEngine
public enum ImagePosition // TypeDefIndex: 24588
{
	// Fields
	public int value__; // 0x0
	public const ImagePosition ImageLeft = 0;
	public const ImagePosition ImageAbove = 1;
	public const ImagePosition ImageOnly = 2;
	public const ImagePosition TextOnly = 3;
}

// Namespace: UnityEngine
public enum TextClipping // TypeDefIndex: 24589
{
	// Fields
	public int value__; // 0x0
	public const TextClipping Overflow = 0;
	public const TextClipping Clip = 1;
}

// Namespace: UnityEngine
[Usage(64)]
public class GUITargetAttribute : Attribute // TypeDefIndex: 24590
{
	// Fields
	internal int displayMask; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x87A0EAC Offset: 0x879CEAC VA: 0x87A0EAC
	private static int GetGUITargetAttrValue(Type klass, string methodName) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Input/InputBindings.h")]
[NativeHeader("Runtime/Utilities/CopyPaste.h")]
[NativeHeader("Runtime/Input/InputManager.h")]
[NativeHeader("Modules/IMGUI/GUIUtility.h")]
[NativeHeader("Modules/IMGUI/GUIManager.h")]
[NativeHeader("Runtime/Camera/RenderLayers/GUITexture.h")]
public class GUIUtility // TypeDefIndex: 24591
{
	// Fields
	internal static int s_ControlCount; // 0x0
	internal static int s_SkinMode; // 0x4
	internal static int s_OriginalID; // 0x8
	internal static Action takeCapture; // 0x10
	internal static Action releaseCapture; // 0x18
	internal static Func<int, IntPtr, bool> processEvent; // 0x20
	internal static Action cleanupRoots; // 0x28
	internal static Func<Exception, bool> endContainerGUIFromException; // 0x30
	internal static Action guiChanged; // 0x38
	internal static Action<EventType, KeyCode> beforeEventProcessed; // 0x40
	private static Event m_Event; // 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static bool <guiIsExiting>k__BackingField; // 0x50
	internal static Func<bool> s_HasCurrentWindowKeyFocusFunc; // 0x58

	// Properties
	public static bool hasModalWindow { get; }
	[NativeProperty("GetGUIState().m_PixelsPerPoint", True, 1)]
	internal static float pixelsPerPoint { get; }
	[NativeProperty("GetGUIState().m_OnGUIDepth", True, 1)]
	internal static int guiDepth { get; }
	internal static Vector2 s_EditorScreenPointOffset { get; set; }
	[NativeProperty("GetGUIState().m_CanvasGUIState.m_IsMouseUsed", True, 1)]
	internal static bool mouseUsed { get; set; }
	[StaticAccessor("GetInputManager()", 0)]
	internal static bool textFieldInput { get; set; }
	internal static bool manualTex2SRGBEnabled { get; set; }
	public static string systemCopyBuffer { get; set; }
	[StaticAccessor("InputBindings", 2)]
	internal static string compositionString { get; }
	[StaticAccessor("InputBindings", 2)]
	internal static IMECompositionMode imeCompositionMode { get; set; }
	[StaticAccessor("InputBindings", 2)]
	internal static Vector2 compositionCursorPos { get; set; }
	internal static bool guiIsExiting { get; set; }
	public static int hotControl { get; set; }
	public static int keyboardControl { get; set; }

	// Methods

	// RVA: 0x87A1048 Offset: 0x879D048 VA: 0x87A1048
	public static bool get_hasModalWindow() { }

	// RVA: 0x87A1070 Offset: 0x879D070 VA: 0x87A1070
	internal static float get_pixelsPerPoint() { }

	// RVA: 0x87A1098 Offset: 0x879D098 VA: 0x87A1098
	internal static int get_guiDepth() { }

	[NativeMethod("GetGUIState().GetGUIPixelOffset", True)]
	// RVA: 0x87A10C0 Offset: 0x879D0C0 VA: 0x87A10C0
	internal static Vector2 get_s_EditorScreenPointOffset() { }

	[NativeMethod("GetGUIState().SetGUIPixelOffset", True)]
	// RVA: 0x87A1178 Offset: 0x879D178 VA: 0x87A1178
	internal static void set_s_EditorScreenPointOffset(Vector2 value) { }

	// RVA: 0x87A122C Offset: 0x879D22C VA: 0x87A122C
	internal static bool get_mouseUsed() { }

	// RVA: 0x87A1254 Offset: 0x879D254 VA: 0x87A1254
	internal static void set_mouseUsed(bool value) { }

	// RVA: 0x87A1290 Offset: 0x879D290 VA: 0x87A1290
	internal static bool get_textFieldInput() { }

	// RVA: 0x87A12B8 Offset: 0x879D2B8 VA: 0x87A12B8
	internal static void set_textFieldInput(bool value) { }

	[FreeFunction("GUITexture::IsManualTex2SRGBEnabled")]
	// RVA: 0x87A12F4 Offset: 0x879D2F4 VA: 0x87A12F4
	internal static bool get_manualTex2SRGBEnabled() { }

	[FreeFunction("GUITexture::SetManualTex2SRGBEnabled")]
	// RVA: 0x87A131C Offset: 0x879D31C VA: 0x87A131C
	internal static void set_manualTex2SRGBEnabled(bool value) { }

	[FreeFunction("GetCopyBuffer")]
	// RVA: 0x87A1358 Offset: 0x879D358 VA: 0x87A1358
	public static string get_systemCopyBuffer() { }

	[FreeFunction("SetCopyBuffer")]
	// RVA: 0x87A1380 Offset: 0x879D380 VA: 0x87A1380
	public static void set_systemCopyBuffer(string value) { }

	[FreeFunction("GetGUIState().GetControlID")]
	// RVA: 0x87A13BC Offset: 0x879D3BC VA: 0x87A13BC
	private static int Internal_GetControlID(int hint, FocusType focusType, Rect rect) { }

	// RVA: 0x87A14AC Offset: 0x879D4AC VA: 0x87A14AC
	public static int GetControlID(int hint, FocusType focusType, Rect rect) { }

	// RVA: 0x87A1554 Offset: 0x879D554 VA: 0x87A1554
	internal static void BeginContainerFromOwner(ScriptableObject owner) { }

	// RVA: 0x87A1590 Offset: 0x879D590 VA: 0x87A1590
	internal static void BeginContainer(ObjectGUIState objectGUIState) { }

	[NativeMethod("EndContainer")]
	// RVA: 0x87A15CC Offset: 0x879D5CC VA: 0x87A15CC
	internal static void Internal_EndContainer() { }

	[FreeFunction("GetSpecificGUIState(0).m_EternalGUIState->GetNextUniqueID")]
	// RVA: 0x87A15F4 Offset: 0x879D5F4 VA: 0x87A15F4
	internal static int GetPermanentControlID() { }

	// RVA: 0x87A161C Offset: 0x879D61C VA: 0x87A161C
	internal static int CheckForTabEvent(Event evt) { }

	// RVA: 0x87A1658 Offset: 0x879D658 VA: 0x87A1658
	internal static void SetKeyboardControlToFirstControlId() { }

	// RVA: 0x87A1680 Offset: 0x879D680 VA: 0x87A1680
	internal static void SetKeyboardControlToLastControlId() { }

	// RVA: 0x87A16A8 Offset: 0x879D6A8 VA: 0x87A16A8
	internal static bool HasFocusableControls() { }

	// RVA: 0x87A16D0 Offset: 0x879D6D0 VA: 0x87A16D0
	internal static bool OwnsId(int id) { }

	// RVA: 0x87A170C Offset: 0x879D70C VA: 0x87A170C
	public static Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels) { }

	// RVA: 0x87A1814 Offset: 0x879D814 VA: 0x87A1814
	internal static string get_compositionString() { }

	// RVA: 0x87A183C Offset: 0x879D83C VA: 0x87A183C
	internal static IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x87A1864 Offset: 0x879D864 VA: 0x87A1864
	internal static void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x87A18A0 Offset: 0x879D8A0 VA: 0x87A18A0
	internal static Vector2 get_compositionCursorPos() { }

	// RVA: 0x87A1958 Offset: 0x879D958 VA: 0x87A1958
	internal static void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x87A1A0C Offset: 0x879DA0C VA: 0x87A1A0C
	internal static Vector3 Internal_MultiplyPoint(Vector3 point, Matrix4x4 transform) { }

	// RVA: 0x87A1B00 Offset: 0x879DB00 VA: 0x87A1B00
	internal static bool GetChanged() { }

	// RVA: 0x87A1B28 Offset: 0x879DB28 VA: 0x87A1B28
	internal static void SetChanged(bool changed) { }

	// RVA: 0x87A1B64 Offset: 0x879DB64 VA: 0x87A1B64
	internal static void SetDidGUIWindowsEatLastEvent(bool value) { }

	// RVA: 0x87A1BA0 Offset: 0x879DBA0 VA: 0x87A1BA0
	private static int Internal_GetHotControl() { }

	// RVA: 0x87A1BC8 Offset: 0x879DBC8 VA: 0x87A1BC8
	private static int Internal_GetKeyboardControl() { }

	// RVA: 0x87A1BF0 Offset: 0x879DBF0 VA: 0x87A1BF0
	private static void Internal_SetHotControl(int value) { }

	// RVA: 0x87A1C2C Offset: 0x879DC2C VA: 0x87A1C2C
	private static void Internal_SetKeyboardControl(int value) { }

	// RVA: 0x87A1C68 Offset: 0x879DC68 VA: 0x87A1C68
	private static object Internal_GetDefaultSkin(int skinMode) { }

	// RVA: 0x87A1CA4 Offset: 0x879DCA4 VA: 0x87A1CA4
	private static Object Internal_GetBuiltinSkin(int skin) { }

	// RVA: 0x87A1CE0 Offset: 0x879DCE0 VA: 0x87A1CE0
	private static void Internal_ExitGUI() { }

	// RVA: 0x87A1D08 Offset: 0x879DD08 VA: 0x87A1D08
	private static Vector2 InternalWindowToScreenPoint(Vector2 windowPoint) { }

	// RVA: 0x87A1DD8 Offset: 0x879DDD8 VA: 0x87A1DD8
	private static Vector2 InternalScreenToWindowPoint(Vector2 screenPoint) { }

	[RequiredByNativeCode]
	// RVA: 0x87A1EA8 Offset: 0x879DEA8 VA: 0x87A1EA8
	private static void MarkGUIChanged() { }

	// RVA: 0x87A1F1C Offset: 0x879DF1C VA: 0x87A1F1C
	public static int GetControlID(FocusType focus) { }

	// RVA: 0x87A2010 Offset: 0x879E010 VA: 0x87A2010
	public static int GetControlID(GUIContent contents, FocusType focus) { }

	// RVA: 0x87A2088 Offset: 0x879E088 VA: 0x87A2088
	public static int GetControlID(FocusType focus, Rect position) { }

	// RVA: 0x87A2110 Offset: 0x879E110 VA: 0x87A2110
	public static int GetControlID(GUIContent contents, FocusType focus, Rect position) { }

	// RVA: 0x87A1F74 Offset: 0x879DF74 VA: 0x87A1F74
	public static int GetControlID(int hint, FocusType focus) { }

	// RVA: 0x87A21B8 Offset: 0x879E1B8 VA: 0x87A21B8
	public static object GetStateObject(Type t, int controlID) { }

	// RVA: 0x87A221C Offset: 0x879E21C VA: 0x87A221C
	public static object QueryStateObject(Type t, int controlID) { }

	[CompilerGenerated]
	// RVA: 0x87A2280 Offset: 0x879E280 VA: 0x87A2280
	internal static bool get_guiIsExiting() { }

	[CompilerGenerated]
	// RVA: 0x87A22D8 Offset: 0x879E2D8 VA: 0x87A22D8
	internal static void set_guiIsExiting(bool value) { }

	// RVA: 0x87A01E8 Offset: 0x879C1E8 VA: 0x87A01E8
	public static int get_hotControl() { }

	// RVA: 0x87A2338 Offset: 0x879E338 VA: 0x87A2338
	public static void set_hotControl(int value) { }

	[RequiredByNativeCode]
	// RVA: 0x87A23AC Offset: 0x879E3AC VA: 0x87A23AC
	internal static void TakeCapture() { }

	[RequiredByNativeCode]
	// RVA: 0x87A2420 Offset: 0x879E420 VA: 0x87A2420
	internal static void RemoveCapture() { }

	// RVA: 0x87A08B0 Offset: 0x879C8B0 VA: 0x87A08B0
	public static int get_keyboardControl() { }

	// RVA: 0x87A2494 Offset: 0x879E494 VA: 0x87A2494
	public static void set_keyboardControl(int value) { }

	// RVA: 0x87A0250 Offset: 0x879C250 VA: 0x87A0250
	internal static bool HasKeyFocus(int controlID) { }

	// RVA: 0x87A2508 Offset: 0x879E508 VA: 0x87A2508
	public static void ExitGUI() { }

	// RVA: 0x87A25FC Offset: 0x879E5FC VA: 0x87A25FC
	internal static GUISkin GetDefaultSkin(int skinMode) { }

	// RVA: 0x87A269C Offset: 0x879E69C VA: 0x87A269C
	internal static GUISkin GetDefaultSkin() { }

	// RVA: 0x87A2744 Offset: 0x879E744 VA: 0x87A2744
	internal static GUISkin GetBuiltinSkin(int skin) { }

	[RequiredByNativeCode]
	// RVA: 0x87A27E4 Offset: 0x879E7E4 VA: 0x87A27E4
	internal static void ProcessEvent(int instanceID, IntPtr nativeEventPtr, out bool result) { }

	// RVA: 0x87A2940 Offset: 0x879E940 VA: 0x87A2940
	internal static void EndContainer() { }

	// RVA: 0x87A29C8 Offset: 0x879E9C8 VA: 0x87A29C8
	internal static void CleanupRoots() { }

	[RequiredByNativeCode]
	// RVA: 0x87A2A3C Offset: 0x879EA3C VA: 0x87A2A3C
	internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout) { }

	[RequiredByNativeCode]
	// RVA: 0x87A2C00 Offset: 0x879EC00 VA: 0x87A2C00
	internal static void DestroyGUI(int instanceID) { }

	[RequiredByNativeCode]
	// RVA: 0x87A2C5C Offset: 0x879EC5C VA: 0x87A2C5C
	internal static void EndGUI(int layoutType) { }

	[RequiredByNativeCode]
	// RVA: 0x87A2E44 Offset: 0x879EE44 VA: 0x87A2E44
	internal static bool EndGUIFromException(Exception exception) { }

	[RequiredByNativeCode]
	// RVA: 0x87A2F0C Offset: 0x879EF0C VA: 0x87A2F0C
	internal static bool EndContainerGUIFromException(Exception exception) { }

	// RVA: 0x87A2AEC Offset: 0x879EAEC VA: 0x87A2AEC
	internal static void ResetGlobalState() { }

	// RVA: 0x87A2FAC Offset: 0x879EFAC VA: 0x87A2FAC
	internal static bool IsExitGUIException(Exception exception) { }

	// RVA: 0x87A2EB8 Offset: 0x879EEB8 VA: 0x87A2EB8
	internal static bool ShouldRethrowException(Exception exception) { }

	// RVA: 0x87A3030 Offset: 0x879F030 VA: 0x87A3030
	internal static void CheckOnGUI() { }

	// RVA: 0x87A30F0 Offset: 0x879F0F0 VA: 0x87A30F0
	internal static float RoundToPixelGrid(float v) { }

	// RVA: 0x87A31A0 Offset: 0x879F1A0 VA: 0x87A31A0
	internal static float RoundToPixelGrid(float v, float scale) { }

	// RVA: 0x87A31BC Offset: 0x879F1BC VA: 0x87A31BC
	public static Vector2 GUIToScreenPoint(Vector2 guiPoint) { }

	// RVA: 0x87A3238 Offset: 0x879F238 VA: 0x87A3238
	public static Rect GUIToScreenRect(Rect guiRect) { }

	// RVA: 0x87A32B8 Offset: 0x879F2B8 VA: 0x87A32B8
	public static Vector2 ScreenToGUIPoint(Vector2 screenPoint) { }

	// RVA: 0x87A3324 Offset: 0x879F324 VA: 0x87A3324
	public static Rect ScreenToGUIRect(Rect screenRect) { }

	// RVA: 0x87A33A4 Offset: 0x879F3A4 VA: 0x87A33A4
	public static void RotateAroundPivot(float angle, Vector2 pivotPoint) { }

	// RVA: 0x87A3674 Offset: 0x879F674 VA: 0x87A3674
	public static void ScaleAroundPivot(Vector2 scale, Vector2 pivotPoint) { }

	// RVA: 0x87A38BC Offset: 0x879F8BC VA: 0x87A38BC
	public static Rect AlignRectToDevice(Rect rect) { }

	// RVA: 0x87A3948 Offset: 0x879F948 VA: 0x87A3948
	internal static bool HitTest(Rect rect, Vector2 point, int offset) { }

	// RVA: 0x87A3994 Offset: 0x879F994 VA: 0x87A3994
	internal static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice) { }

	// RVA: 0x87A3A54 Offset: 0x879FA54 VA: 0x87A3A54
	internal static bool HitTest(Rect rect, Event evt) { }

	// RVA: 0x87A3B10 Offset: 0x879FB10 VA: 0x87A3B10
	public void .ctor() { }

	// RVA: 0x87A3B18 Offset: 0x879FB18 VA: 0x87A3B18
	private static void .cctor() { }

	// RVA: 0x87A113C Offset: 0x879D13C VA: 0x87A113C
	private static void get_s_EditorScreenPointOffset_Injected(out Vector2 ret) { }

	// RVA: 0x87A11F0 Offset: 0x879D1F0 VA: 0x87A11F0
	private static void set_s_EditorScreenPointOffset_Injected(ref Vector2 value) { }

	// RVA: 0x87A1458 Offset: 0x879D458 VA: 0x87A1458
	private static int Internal_GetControlID_Injected(int hint, FocusType focusType, ref Rect rect) { }

	// RVA: 0x87A17B8 Offset: 0x879D7B8 VA: 0x87A17B8
	private static void AlignRectToDevice_Injected(ref Rect rect, out int widthInPixels, out int heightInPixels, out Rect ret) { }

	// RVA: 0x87A191C Offset: 0x879D91C VA: 0x87A191C
	private static void get_compositionCursorPos_Injected(out Vector2 ret) { }

	// RVA: 0x87A19D0 Offset: 0x879D9D0 VA: 0x87A19D0
	private static void set_compositionCursorPos_Injected(ref Vector2 value) { }

	// RVA: 0x87A1AAC Offset: 0x879DAAC VA: 0x87A1AAC
	private static void Internal_MultiplyPoint_Injected(ref Vector3 point, ref Matrix4x4 transform, out Vector3 ret) { }

	// RVA: 0x87A1D94 Offset: 0x879DD94 VA: 0x87A1D94
	private static void InternalWindowToScreenPoint_Injected(ref Vector2 windowPoint, out Vector2 ret) { }

	// RVA: 0x87A1E64 Offset: 0x879DE64 VA: 0x87A1E64
	private static void InternalScreenToWindowPoint_Injected(ref Vector2 screenPoint, out Vector2 ret) { }
}

// Namespace: UnityEngine
public sealed class ExitGUIException : Exception // TypeDefIndex: 24592
{
	// Methods

	// RVA: 0x87A253C Offset: 0x879E53C VA: 0x87A253C
	public void .ctor() { }

	// RVA: 0x87A3B98 Offset: 0x879FB98 VA: 0x87A3B98
	internal void .ctor(string message) { }
}

// Namespace: UnityEngine
internal class GUILayoutEntry // TypeDefIndex: 24593
{
	// Fields
	public float minWidth; // 0x10
	public float maxWidth; // 0x14
	public float minHeight; // 0x18
	public float maxHeight; // 0x1C
	public Rect rect; // 0x20
	public int stretchWidth; // 0x30
	public int stretchHeight; // 0x34
	public bool consideredForMargin; // 0x38
	private GUIStyle m_Style; // 0x40
	internal static Rect kDummyRect; // 0x0
	protected static int indent; // 0x10

	// Properties
	public GUIStyle style { get; set; }
	public virtual int marginLeft { get; }
	public virtual int marginRight { get; }
	public virtual int marginTop { get; }
	public virtual int marginBottom { get; }
	public int marginHorizontal { get; }
	public int marginVertical { get; }

	// Methods

	// RVA: 0x87A3C68 Offset: 0x879FC68 VA: 0x87A3C68
	public GUIStyle get_style() { }

	// RVA: 0x87A3C70 Offset: 0x879FC70 VA: 0x87A3C70
	public void set_style(GUIStyle value) { }

	// RVA: 0x87A3CA4 Offset: 0x879FCA4 VA: 0x87A3CA4 Slot: 4
	public virtual int get_marginLeft() { }

	// RVA: 0x87A3CC8 Offset: 0x879FCC8 VA: 0x87A3CC8 Slot: 5
	public virtual int get_marginRight() { }

	// RVA: 0x87A3CEC Offset: 0x879FCEC VA: 0x87A3CEC Slot: 6
	public virtual int get_marginTop() { }

	// RVA: 0x87A3D10 Offset: 0x879FD10 VA: 0x87A3D10 Slot: 7
	public virtual int get_marginBottom() { }

	// RVA: 0x87A3D34 Offset: 0x879FD34 VA: 0x87A3D34
	public int get_marginHorizontal() { }

	// RVA: 0x87A3D70 Offset: 0x879FD70 VA: 0x87A3D70
	public int get_marginVertical() { }

	// RVA: 0x87A3DAC Offset: 0x879FDAC VA: 0x87A3DAC
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style) { }

	// RVA: 0x87A3E9C Offset: 0x879FE9C VA: 0x87A3E9C
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options) { }

	// RVA: 0x87A3F8C Offset: 0x879FF8C VA: 0x87A3F8C Slot: 8
	public virtual void CalcWidth() { }

	// RVA: 0x87A3F90 Offset: 0x879FF90 VA: 0x87A3F90 Slot: 9
	public virtual void CalcHeight() { }

	// RVA: 0x87A3F94 Offset: 0x879FF94 VA: 0x87A3F94 Slot: 10
	public virtual void SetHorizontal(float x, float width) { }

	// RVA: 0x87A3FA0 Offset: 0x879FFA0 VA: 0x87A3FA0 Slot: 11
	public virtual void SetVertical(float y, float height) { }

	// RVA: 0x87A3FAC Offset: 0x879FFAC VA: 0x87A3FAC Slot: 12
	protected virtual void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x87A40B0 Offset: 0x87A00B0 VA: 0x87A40B0 Slot: 13
	public virtual void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x87A4384 Offset: 0x87A0384 VA: 0x87A4384 Slot: 3
	public override string ToString() { }

	// RVA: 0x87A48F8 Offset: 0x87A08F8 VA: 0x87A48F8
	private static void .cctor() { }
}

// Namespace: UnityEngine
internal sealed class GUIWordWrapSizer : GUILayoutEntry // TypeDefIndex: 24594
{
	// Fields
	private readonly GUIContent m_Content; // 0x48
	private readonly float m_ForcedMinHeight; // 0x50
	private readonly float m_ForcedMaxHeight; // 0x54

	// Methods

	// RVA: 0x87A4954 Offset: 0x87A0954 VA: 0x87A4954
	public void .ctor(GUIStyle style, GUIContent content, GUILayoutOption[] options) { }

	// RVA: 0x87A4A38 Offset: 0x87A0A38 VA: 0x87A4A38 Slot: 8
	public override void CalcWidth() { }

	// RVA: 0x87A4AA0 Offset: 0x87A0AA0 VA: 0x87A4AA0 Slot: 9
	public override void CalcHeight() { }
}

// Namespace: UnityEngine
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule", "Unity.UIElements" })]
internal class GUILayoutGroup : GUILayoutEntry // TypeDefIndex: 24595
{
	// Fields
	public List<GUILayoutEntry> entries; // 0x48
	public bool isVertical; // 0x50
	public bool resetCoords; // 0x51
	public float spacing; // 0x54
	public bool sameSize; // 0x58
	public bool isWindow; // 0x59
	public int windowID; // 0x5C
	private int m_Cursor; // 0x60
	protected int m_StretchableCountX; // 0x64
	protected int m_StretchableCountY; // 0x68
	protected bool m_UserSpecifiedWidth; // 0x6C
	protected bool m_UserSpecifiedHeight; // 0x6D
	protected float m_ChildMinWidth; // 0x70
	protected float m_ChildMaxWidth; // 0x74
	protected float m_ChildMinHeight; // 0x78
	protected float m_ChildMaxHeight; // 0x7C
	protected int m_MarginLeft; // 0x80
	protected int m_MarginRight; // 0x84
	protected int m_MarginTop; // 0x88
	protected int m_MarginBottom; // 0x8C
	private static readonly GUILayoutEntry none; // 0x0

	// Properties
	public override int marginLeft { get; }
	public override int marginRight { get; }
	public override int marginTop { get; }
	public override int marginBottom { get; }

	// Methods

	// RVA: 0x87A4B40 Offset: 0x87A0B40 VA: 0x87A4B40 Slot: 4
	public override int get_marginLeft() { }

	// RVA: 0x87A4B48 Offset: 0x87A0B48 VA: 0x87A4B48 Slot: 5
	public override int get_marginRight() { }

	// RVA: 0x87A4B50 Offset: 0x87A0B50 VA: 0x87A4B50 Slot: 6
	public override int get_marginTop() { }

	// RVA: 0x87A4B58 Offset: 0x87A0B58 VA: 0x87A4B58 Slot: 7
	public override int get_marginBottom() { }

	// RVA: 0x87A4B60 Offset: 0x87A0B60 VA: 0x87A4B60
	public void .ctor() { }

	// RVA: 0x87A4C7C Offset: 0x87A0C7C VA: 0x87A4C7C Slot: 13
	public override void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x87A4D9C Offset: 0x87A0D9C VA: 0x87A4D9C Slot: 12
	protected override void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x87A4E10 Offset: 0x87A0E10 VA: 0x87A4E10
	public void ResetCursor() { }

	// RVA: 0x87A4E18 Offset: 0x87A0E18 VA: 0x87A4E18
	public GUILayoutEntry GetNext() { }

	// RVA: 0x87A50B0 Offset: 0x87A10B0 VA: 0x87A50B0
	public void Add(GUILayoutEntry e) { }

	// RVA: 0x87A515C Offset: 0x87A115C VA: 0x87A515C Slot: 8
	public override void CalcWidth() { }

	// RVA: 0x87A5808 Offset: 0x87A1808 VA: 0x87A5808 Slot: 10
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x87A6044 Offset: 0x87A2044 VA: 0x87A6044 Slot: 9
	public override void CalcHeight() { }

	// RVA: 0x87A6640 Offset: 0x87A2640 VA: 0x87A6640 Slot: 11
	public override void SetVertical(float y, float height) { }

	// RVA: 0x87A6E88 Offset: 0x87A2E88 VA: 0x87A6E88 Slot: 3
	public override string ToString() { }

	// RVA: 0x87A7260 Offset: 0x87A3260 VA: 0x87A7260
	private static void .cctor() { }
}

// Namespace: UnityEngine
internal sealed class GUIScrollGroup : GUILayoutGroup // TypeDefIndex: 24596
{
	// Fields
	public float calcMinWidth; // 0x90
	public float calcMaxWidth; // 0x94
	public float calcMinHeight; // 0x98
	public float calcMaxHeight; // 0x9C
	public float clientWidth; // 0xA0
	public float clientHeight; // 0xA4
	public bool allowHorizontalScroll; // 0xA8
	public bool allowVerticalScroll; // 0xA9
	public bool needsHorizontalScrollbar; // 0xAA
	public bool needsVerticalScrollbar; // 0xAB
	public GUIStyle horizontalScrollbar; // 0xB0
	public GUIStyle verticalScrollbar; // 0xB8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x87A7334 Offset: 0x87A3334 VA: 0x87A7334
	public void .ctor() { }

	// RVA: 0x87A7390 Offset: 0x87A3390 VA: 0x87A7390 Slot: 8
	public override void CalcWidth() { }

	// RVA: 0x87A740C Offset: 0x87A340C VA: 0x87A740C Slot: 10
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x87A7508 Offset: 0x87A3508 VA: 0x87A7508 Slot: 9
	public override void CalcHeight() { }

	// RVA: 0x87A7604 Offset: 0x87A3604 VA: 0x87A7604 Slot: 11
	public override void SetVertical(float y, float height) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUIState.h")]
internal class ObjectGUIState : IDisposable // TypeDefIndex: 24597
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x87A77A8 Offset: 0x87A37A8 VA: 0x87A77A8
	public void .ctor() { }

	// RVA: 0x87A7818 Offset: 0x87A3818 VA: 0x87A7818 Slot: 4
	public void Dispose() { }

	// RVA: 0x87A78D4 Offset: 0x87A38D4 VA: 0x87A78D4 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x87A7878 Offset: 0x87A3878 VA: 0x87A7878
	private void Destroy() { }

	// RVA: 0x87A77F0 Offset: 0x87A37F0 VA: 0x87A77F0
	private static IntPtr Internal_Create() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x87A7968 Offset: 0x87A3968 VA: 0x87A7968
	private static void Internal_Destroy(IntPtr ptr) { }
}

// Namespace: UnityEngine
internal class ScrollViewState // TypeDefIndex: 24598
{
	// Fields
	public Rect position; // 0x10
	public Rect visibleRect; // 0x20
	public Rect viewRect; // 0x30
	public Vector2 scrollPosition; // 0x40
	public bool apply; // 0x48
	public bool isDuringTouchScroll; // 0x49
	public Vector2 touchScrollStartMousePosition; // 0x4C
	public Vector2 touchScrollStartPosition; // 0x54
	public Vector2 velocity; // 0x5C
	public float previousTimeSinceStartup; // 0x64

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x87A79A4 Offset: 0x87A39A4 VA: 0x87A79A4
	public void .ctor() { }

	// RVA: 0x87A79AC Offset: 0x87A39AC VA: 0x87A79AC
	public void ScrollTo(Rect pos) { }

	// RVA: 0x87A79B8 Offset: 0x87A39B8 VA: 0x87A79B8
	public bool ScrollTowards(Rect pos, float maxDelta) { }

	// RVA: 0x87A7B34 Offset: 0x87A3B34 VA: 0x87A7B34
	private Vector2 ScrollNeeded(Rect pos) { }
}

// Namespace: UnityEngine
internal class SliderState // TypeDefIndex: 24599
{
	// Fields
	public float dragStartPos; // 0x10
	public float dragStartValue; // 0x14
	public bool isDragging; // 0x18

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x87A7CB8 Offset: 0x87A3CB8 VA: 0x87A7CB8
	public void .ctor() { }
}

// Namespace: UnityEngine
internal struct SliderHandler // TypeDefIndex: 24600
{
	// Fields
	private readonly Rect position; // 0x0
	private readonly float currentValue; // 0x10
	private readonly float size; // 0x14
	private readonly float start; // 0x18
	private readonly float end; // 0x1C
	private readonly GUIStyle slider; // 0x20
	private readonly GUIStyle thumb; // 0x28
	private readonly GUIStyle thumbExtent; // 0x30
	private readonly bool horiz; // 0x38
	private readonly int id; // 0x3C

	// Methods

	// RVA: 0x87A7CC0 Offset: 0x87A3CC0 VA: 0x87A7CC0
	public void .ctor(Rect position, float currentValue, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x87A7D30 Offset: 0x87A3D30 VA: 0x87A7D30
	public float Handle() { }

	// RVA: 0x87A7DD8 Offset: 0x87A3DD8 VA: 0x87A7DD8
	private float OnMouseDown() { }

	// RVA: 0x87A81D8 Offset: 0x87A41D8 VA: 0x87A81D8
	private float OnMouseDrag() { }

	// RVA: 0x87A82F0 Offset: 0x87A42F0 VA: 0x87A82F0
	private float OnMouseUp() { }

	// RVA: 0x87A8384 Offset: 0x87A4384 VA: 0x87A8384
	private float OnRepaint() { }

	// RVA: 0x87A7DB0 Offset: 0x87A3DB0 VA: 0x87A7DB0
	private EventType CurrentEventType() { }

	// RVA: 0x87A8ACC Offset: 0x87A4ACC VA: 0x87A8ACC
	private int CurrentScrollTroughSide() { }

	// RVA: 0x87A88D8 Offset: 0x87A48D8 VA: 0x87A88D8
	private bool IsEmptySlider() { }

	// RVA: 0x87A895C Offset: 0x87A495C VA: 0x87A895C
	private bool SupportsPageMovements() { }

	// RVA: 0x87A8B30 Offset: 0x87A4B30 VA: 0x87A8B30
	private float PageMovementValue() { }

	// RVA: 0x87A8E14 Offset: 0x87A4E14 VA: 0x87A8E14
	private float PageUpMovementBound() { }

	// RVA: 0x87A88D0 Offset: 0x87A48D0 VA: 0x87A88D0
	private Event CurrentEvent() { }

	// RVA: 0x87A8BB8 Offset: 0x87A4BB8 VA: 0x87A8BB8
	private float ValueForCurrentMousePosition() { }

	// RVA: 0x87A8C2C Offset: 0x87A4C2C VA: 0x87A8C2C
	private float Clamp(float value) { }

	// RVA: 0x87A88CC Offset: 0x87A48CC VA: 0x87A88CC
	private Rect ThumbSelectionRect() { }

	// RVA: 0x87A8914 Offset: 0x87A4914 VA: 0x87A8914
	private void StartDraggingWithValue(float dragStartValue) { }

	// RVA: 0x87A89CC Offset: 0x87A49CC VA: 0x87A89CC
	private SliderState SliderState() { }

	// RVA: 0x87A8D44 Offset: 0x87A4D44 VA: 0x87A8D44
	private Rect ThumbExtRect() { }

	// RVA: 0x87A8E04 Offset: 0x87A4E04 VA: 0x87A8E04
	private Rect ThumbRect() { }

	// RVA: 0x87A8E7C Offset: 0x87A4E7C VA: 0x87A8E7C
	private Rect VerticalThumbRect() { }

	// RVA: 0x87A8FD0 Offset: 0x87A4FD0 VA: 0x87A8FD0
	private Rect HorizontalThumbRect() { }

	// RVA: 0x87A88E8 Offset: 0x87A48E8 VA: 0x87A88E8
	private float ClampedCurrentValue() { }

	// RVA: 0x87A8C58 Offset: 0x87A4C58 VA: 0x87A8C58
	private float MousePosition() { }

	// RVA: 0x87A8CA4 Offset: 0x87A4CA4 VA: 0x87A8CA4
	private float ValuesPerPixel() { }

	// RVA: 0x87A9124 Offset: 0x87A5124 VA: 0x87A9124
	private float ThumbSize() { }

	// RVA: 0x87A8E64 Offset: 0x87A4E64 VA: 0x87A8E64
	private float MaxValue() { }

	// RVA: 0x87A8E54 Offset: 0x87A4E54 VA: 0x87A8E54
	private float MinValue() { }
}

// Namespace: UnityEngine
internal enum TextEditOp // TypeDefIndex: 24601
{
	// Fields
	public int value__; // 0x0
	public const TextEditOp MoveLeft = 0;
	public const TextEditOp MoveRight = 1;
	public const TextEditOp MoveUp = 2;
	public const TextEditOp MoveDown = 3;
	public const TextEditOp MoveLineStart = 4;
	public const TextEditOp MoveLineEnd = 5;
	public const TextEditOp MoveTextStart = 6;
	public const TextEditOp MoveTextEnd = 7;
	public const TextEditOp MovePageUp = 8;
	public const TextEditOp MovePageDown = 9;
	public const TextEditOp MoveGraphicalLineStart = 10;
	public const TextEditOp MoveGraphicalLineEnd = 11;
	public const TextEditOp MoveWordLeft = 12;
	public const TextEditOp MoveWordRight = 13;
	public const TextEditOp MoveParagraphForward = 14;
	public const TextEditOp MoveParagraphBackward = 15;
	public const TextEditOp MoveToStartOfNextWord = 16;
	public const TextEditOp MoveToEndOfPreviousWord = 17;
	public const TextEditOp Delete = 18;
	public const TextEditOp Backspace = 19;
	public const TextEditOp DeleteWordBack = 20;
	public const TextEditOp DeleteWordForward = 21;
	public const TextEditOp DeleteLineBack = 22;
	public const TextEditOp Cut = 23;
	public const TextEditOp Paste = 24;
	public const TextEditOp ScrollStart = 25;
	public const TextEditOp ScrollEnd = 26;
	public const TextEditOp ScrollPageUp = 27;
	public const TextEditOp ScrollPageDown = 28;
}

// Namespace: UnityEngine
internal enum TextSelectOp // TypeDefIndex: 24602
{
	// Fields
	public int value__; // 0x0
	public const TextSelectOp SelectLeft = 0;
	public const TextSelectOp SelectRight = 1;
	public const TextSelectOp SelectUp = 2;
	public const TextSelectOp SelectDown = 3;
	public const TextSelectOp SelectTextStart = 4;
	public const TextSelectOp SelectTextEnd = 5;
	public const TextSelectOp SelectPageUp = 6;
	public const TextSelectOp SelectPageDown = 7;
	public const TextSelectOp ExpandSelectGraphicalLineStart = 8;
	public const TextSelectOp ExpandSelectGraphicalLineEnd = 9;
	public const TextSelectOp SelectGraphicalLineStart = 10;
	public const TextSelectOp SelectGraphicalLineEnd = 11;
	public const TextSelectOp SelectWordLeft = 12;
	public const TextSelectOp SelectWordRight = 13;
	public const TextSelectOp SelectToEndOfPreviousWord = 14;
	public const TextSelectOp SelectToStartOfNextWord = 15;
	public const TextSelectOp SelectParagraphBackward = 16;
	public const TextSelectOp SelectParagraphForward = 17;
	public const TextSelectOp Copy = 18;
	public const TextSelectOp SelectAll = 19;
	public const TextSelectOp SelectNone = 20;
}

// Namespace: UnityEngine
internal class TextEditingUtilities // TypeDefIndex: 24603
{
	// Fields
	private TextSelectingUtilities m_TextSelectingUtility; // 0x10
	private TextHandle m_TextHandle; // 0x18
	private int m_CursorIndexSavedState; // 0x20
	internal bool isCompositionActive; // 0x24
	private bool m_UpdateImeWindowPosition; // 0x25
	public bool multiline; // 0x26
	private string m_Text; // 0x28
	private static Dictionary<Event, TextEditOp> s_KeyEditOps; // 0x0

	// Properties
	private bool hasSelection { get; }
	internal bool revealCursor { set; }
	private int cursorIndex { get; set; }
	private int selectIndex { get; set; }
	public string text { get; set; }

	// Methods

	// RVA: 0x87A923C Offset: 0x87A523C VA: 0x87A923C
	private bool get_hasSelection() { }

	// RVA: 0x87A9258 Offset: 0x87A5258 VA: 0x87A9258
	internal void set_revealCursor(bool value) { }

	// RVA: 0x87A9278 Offset: 0x87A5278 VA: 0x87A9278
	private int get_cursorIndex() { }

	// RVA: 0x87A9294 Offset: 0x87A5294 VA: 0x87A9294
	private void set_cursorIndex(int value) { }

	// RVA: 0x87A92B0 Offset: 0x87A52B0 VA: 0x87A92B0
	private int get_selectIndex() { }

	// RVA: 0x87A92CC Offset: 0x87A52CC VA: 0x87A92CC
	private void set_selectIndex(int value) { }

	// RVA: 0x87A92E8 Offset: 0x87A52E8 VA: 0x87A92E8
	public string get_text() { }

	// RVA: 0x87A92F0 Offset: 0x87A52F0 VA: 0x87A92F0
	public void set_text(string value) { }

	// RVA: 0x87A9370 Offset: 0x87A5370 VA: 0x87A9370
	public void .ctor(TextSelectingUtilities selectingUtilities, TextHandle textHandle, string text) { }

	// RVA: 0x87A93DC Offset: 0x87A53DC VA: 0x87A93DC
	public bool UpdateImeState() { }

	// RVA: 0x87A9568 Offset: 0x87A5568 VA: 0x87A9568
	public bool ShouldUpdateImeWindowPosition() { }

	// RVA: 0x87A9570 Offset: 0x87A5570 VA: 0x87A9570
	public void SetImeWindowPosition(Vector2 worldPosition) { }

	// RVA: 0x87A9618 Offset: 0x87A5618 VA: 0x87A9618
	public string GeneratePreviewString(bool richText) { }

	// RVA: 0x87A9794 Offset: 0x87A5794 VA: 0x87A9794
	public void EnableCursorPreviewState() { }

	// RVA: 0x87A973C Offset: 0x87A573C VA: 0x87A973C
	public void RestoreCursorState() { }

	[VisibleToOtherModules]
	// RVA: 0x87A9870 Offset: 0x87A5870 VA: 0x87A9870
	internal bool HandleKeyEvent(Event e) { }

	// RVA: 0x87A9FCC Offset: 0x87A5FCC VA: 0x87A9FCC
	private void PerformOperation(TextEditOp operation) { }

	// RVA: 0x87AA8D8 Offset: 0x87A68D8 VA: 0x87AA8D8
	private static void MapKey(string key, TextEditOp action) { }

	// RVA: 0x87A9984 Offset: 0x87A5984 VA: 0x87A9984
	private void InitKeyActions() { }

	// RVA: 0x87AA6E8 Offset: 0x87A66E8 VA: 0x87AA6E8
	public bool DeleteLineBack() { }

	// RVA: 0x87AA5F8 Offset: 0x87A65F8 VA: 0x87AA5F8
	public bool DeleteWordBack() { }

	// RVA: 0x87AA7EC Offset: 0x87A67EC VA: 0x87AA7EC
	public bool DeleteWordForward() { }

	// RVA: 0x87AA31C Offset: 0x87A631C VA: 0x87AA31C
	public bool Delete() { }

	// RVA: 0x87AA404 Offset: 0x87A6404 VA: 0x87AA404
	public bool Backspace() { }

	// RVA: 0x87AA968 Offset: 0x87A6968 VA: 0x87AA968
	public bool DeleteSelection() { }

	// RVA: 0x87A94B0 Offset: 0x87A54B0 VA: 0x87A94B0
	public void ReplaceSelection(string replace) { }

	// RVA: 0x87AAB94 Offset: 0x87A6B94 VA: 0x87AAB94
	public void Insert(char c) { }

	// RVA: 0x87AAC08 Offset: 0x87A6C08 VA: 0x87AAC08
	public bool CanPaste() { }

	// RVA: 0x87AA504 Offset: 0x87A6504 VA: 0x87AA504
	public bool Cut() { }

	// RVA: 0x87AA52C Offset: 0x87A652C VA: 0x87AA52C
	public bool Paste() { }

	// RVA: 0x87AAC8C Offset: 0x87A6C8C VA: 0x87AAC8C
	private static string ReplaceNewlinesWithSpaces(string value) { }

	// RVA: 0x87AAD20 Offset: 0x87A6D20 VA: 0x87AAD20
	internal void OnBlur() { }

	// RVA: 0x87AAD54 Offset: 0x87A6D54 VA: 0x87AAD54
	internal bool TouchScreenKeyboardShouldBeUsed() { }
}

// Namespace: 
public enum TextEditor.DblClickSnapping // TypeDefIndex: 24604
{
	// Fields
	public byte value__; // 0x0
	public const TextEditor.DblClickSnapping WORDS = 0;
	public const TextEditor.DblClickSnapping PARAGRAPHS = 1;
}

// Namespace: 
private enum TextEditor.CharacterType // TypeDefIndex: 24605
{
	// Fields
	public int value__; // 0x0
	public const TextEditor.CharacterType LetterLike = 0;
	public const TextEditor.CharacterType Symbol = 1;
	public const TextEditor.CharacterType Symbol2 = 2;
	public const TextEditor.CharacterType WhiteSpace = 3;
}

// Namespace: 
private enum TextEditor.Direction // TypeDefIndex: 24606
{
	// Fields
	public int value__; // 0x0
	public const TextEditor.Direction Forward = 0;
	public const TextEditor.Direction Backward = 1;
}

// Namespace: 
private enum TextEditor.TextEditOp // TypeDefIndex: 24607
{
	// Fields
	public int value__; // 0x0
	public const TextEditor.TextEditOp MoveLeft = 0;
	public const TextEditor.TextEditOp MoveRight = 1;
	public const TextEditor.TextEditOp MoveUp = 2;
	public const TextEditor.TextEditOp MoveDown = 3;
	public const TextEditor.TextEditOp MoveLineStart = 4;
	public const TextEditor.TextEditOp MoveLineEnd = 5;
	public const TextEditor.TextEditOp MoveTextStart = 6;
	public const TextEditor.TextEditOp MoveTextEnd = 7;
	public const TextEditor.TextEditOp MovePageUp = 8;
	public const TextEditor.TextEditOp MovePageDown = 9;
	public const TextEditor.TextEditOp MoveGraphicalLineStart = 10;
	public const TextEditor.TextEditOp MoveGraphicalLineEnd = 11;
	public const TextEditor.TextEditOp MoveWordLeft = 12;
	public const TextEditor.TextEditOp MoveWordRight = 13;
	public const TextEditor.TextEditOp MoveParagraphForward = 14;
	public const TextEditor.TextEditOp MoveParagraphBackward = 15;
	public const TextEditor.TextEditOp MoveToStartOfNextWord = 16;
	public const TextEditor.TextEditOp MoveToEndOfPreviousWord = 17;
	public const TextEditor.TextEditOp SelectLeft = 18;
	public const TextEditor.TextEditOp SelectRight = 19;
	public const TextEditor.TextEditOp SelectUp = 20;
	public const TextEditor.TextEditOp SelectDown = 21;
	public const TextEditor.TextEditOp SelectTextStart = 22;
	public const TextEditor.TextEditOp SelectTextEnd = 23;
	public const TextEditor.TextEditOp SelectPageUp = 24;
	public const TextEditor.TextEditOp SelectPageDown = 25;
	public const TextEditor.TextEditOp ExpandSelectGraphicalLineStart = 26;
	public const TextEditor.TextEditOp ExpandSelectGraphicalLineEnd = 27;
	public const TextEditor.TextEditOp SelectGraphicalLineStart = 28;
	public const TextEditor.TextEditOp SelectGraphicalLineEnd = 29;
	public const TextEditor.TextEditOp SelectWordLeft = 30;
	public const TextEditor.TextEditOp SelectWordRight = 31;
	public const TextEditor.TextEditOp SelectToEndOfPreviousWord = 32;
	public const TextEditor.TextEditOp SelectToStartOfNextWord = 33;
	public const TextEditor.TextEditOp SelectParagraphBackward = 34;
	public const TextEditor.TextEditOp SelectParagraphForward = 35;
	public const TextEditor.TextEditOp Delete = 36;
	public const TextEditor.TextEditOp Backspace = 37;
	public const TextEditor.TextEditOp DeleteWordBack = 38;
	public const TextEditor.TextEditOp DeleteWordForward = 39;
	public const TextEditor.TextEditOp DeleteLineBack = 40;
	public const TextEditor.TextEditOp Cut = 41;
	public const TextEditor.TextEditOp Copy = 42;
	public const TextEditor.TextEditOp Paste = 43;
	public const TextEditor.TextEditOp SelectAll = 44;
	public const TextEditor.TextEditOp SelectNone = 45;
	public const TextEditor.TextEditOp ScrollStart = 46;
	public const TextEditor.TextEditOp ScrollEnd = 47;
	public const TextEditor.TextEditOp ScrollPageUp = 48;
	public const TextEditor.TextEditOp ScrollPageDown = 49;
}

// Namespace: UnityEngine
public class TextEditor // TypeDefIndex: 24608
{
	// Fields
	public TouchScreenKeyboard keyboardOnScreen; // 0x10
	public int controlID; // 0x18
	public GUIStyle style; // 0x20
	public bool multiline; // 0x28
	public bool hasHorizontalCursorPos; // 0x29
	public bool isPasswordField; // 0x2A
	internal bool m_HasFocus; // 0x2B
	public Vector2 scrollOffset; // 0x2C
	private GUIContent m_Content; // 0x38
	private Rect m_Position; // 0x40
	private int m_CursorIndex; // 0x50
	private int m_SelectIndex; // 0x54
	private bool m_RevealCursor; // 0x58
	public Vector2 graphicalCursorPos; // 0x5C
	public Vector2 graphicalSelectCursorPos; // 0x64
	private bool m_MouseDragSelectsWholeWords; // 0x6C
	private int m_DblClickInitPos; // 0x70
	private TextEditor.DblClickSnapping m_DblClickSnap; // 0x74
	private bool m_bJustSelected; // 0x75
	private int m_iAltCursorPos; // 0x78
	private string oldText; // 0x80
	private int oldPos; // 0x88
	private int oldSelectPos; // 0x8C
	private static Dictionary<Event, TextEditor.TextEditOp> s_Keyactions; // 0x0

	// Properties
	public string text { get; set; }
	public Rect position { get; set; }
	internal virtual Rect localPosition { get; }
	public int cursorIndex { get; set; }
	public int selectIndex { get; set; }
	public bool hasSelection { get; }

	// Methods

	// RVA: 0x87AADDC Offset: 0x87A6DDC VA: 0x87AADDC
	public string get_text() { }

	// RVA: 0x87AADF8 Offset: 0x87A6DF8 VA: 0x87AADF8
	public void set_text(string value) { }

	// RVA: 0x87AAEB8 Offset: 0x87A6EB8 VA: 0x87AAEB8
	public Rect get_position() { }

	// RVA: 0x87AAEC4 Offset: 0x87A6EC4 VA: 0x87AAEC4
	public void set_position(Rect value) { }

	// RVA: 0x87AB224 Offset: 0x87A7224 VA: 0x87AB224 Slot: 4
	internal virtual Rect get_localPosition() { }

	// RVA: 0x87AB230 Offset: 0x87A7230 VA: 0x87AB230
	public int get_cursorIndex() { }

	// RVA: 0x87AB238 Offset: 0x87A7238 VA: 0x87AB238
	public void set_cursorIndex(int value) { }

	// RVA: 0x87AB290 Offset: 0x87A7290 VA: 0x87AB290
	public int get_selectIndex() { }

	// RVA: 0x87AB298 Offset: 0x87A7298 VA: 0x87AB298
	public void set_selectIndex(int value) { }

	// RVA: 0x87AB2E8 Offset: 0x87A72E8 VA: 0x87AB2E8
	private void ClearCursorPos() { }

	[RequiredByNativeCode]
	// RVA: 0x87AB2F8 Offset: 0x87A72F8 VA: 0x87AB2F8
	public void .ctor() { }

	// RVA: 0x87AB414 Offset: 0x87A7414 VA: 0x87AB414
	public void OnFocus() { }

	// RVA: 0x87AB4A0 Offset: 0x87A74A0 VA: 0x87AB4A0
	public void OnLostFocus() { }

	// RVA: 0x87AB4F4 Offset: 0x87A74F4 VA: 0x87AB4F4
	private void GrabGraphicalCursorPos() { }

	// RVA: 0x87AB570 Offset: 0x87A7570 VA: 0x87AB570
	public bool HandleKeyEvent(Event e) { }

	[VisibleToOtherModules]
	// RVA: 0x87AB578 Offset: 0x87A7578 VA: 0x87AB578
	internal bool HandleKeyEvent(Event e, bool textIsReadOnly) { }

	// RVA: 0x87AC49C Offset: 0x87A849C VA: 0x87AC49C
	public bool DeleteLineBack() { }

	// RVA: 0x87AC720 Offset: 0x87A8720 VA: 0x87AC720
	public bool DeleteWordBack() { }

	// RVA: 0x87AC898 Offset: 0x87A8898 VA: 0x87AC898
	public bool DeleteWordForward() { }

	// RVA: 0x87ACB10 Offset: 0x87A8B10 VA: 0x87ACB10
	public bool Delete() { }

	// RVA: 0x87ACCB8 Offset: 0x87A8CB8 VA: 0x87ACCB8
	public bool Backspace() { }

	// RVA: 0x87AB458 Offset: 0x87A7458 VA: 0x87AB458
	public void SelectAll() { }

	// RVA: 0x87ACE2C Offset: 0x87A8E2C VA: 0x87ACE2C
	public void SelectNone() { }

	// RVA: 0x87AC574 Offset: 0x87A8574 VA: 0x87AC574
	public bool get_hasSelection() { }

	// RVA: 0x87AC584 Offset: 0x87A8584 VA: 0x87AC584
	public bool DeleteSelection() { }

	// RVA: 0x87ACE50 Offset: 0x87A8E50 VA: 0x87ACE50
	public void ReplaceSelection(string replace) { }

	// RVA: 0x87ACEE0 Offset: 0x87A8EE0 VA: 0x87ACEE0
	public void Insert(char c) { }

	// RVA: 0x87ACF54 Offset: 0x87A8F54 VA: 0x87ACF54
	public void MoveRight() { }

	// RVA: 0x87ACFCC Offset: 0x87A8FCC VA: 0x87ACFCC
	public void MoveLeft() { }

	// RVA: 0x87AD024 Offset: 0x87A9024 VA: 0x87AD024
	public void MoveUp() { }

	// RVA: 0x87AD0D0 Offset: 0x87A90D0 VA: 0x87AD0D0
	public void MoveDown() { }

	// RVA: 0x87AD1AC Offset: 0x87A91AC VA: 0x87AD1AC
	public void MoveLineStart() { }

	// RVA: 0x87AD224 Offset: 0x87A9224 VA: 0x87AD224
	public void MoveLineEnd() { }

	// RVA: 0x87AD2C0 Offset: 0x87A92C0 VA: 0x87AD2C0
	public void MoveGraphicalLineStart() { }

	// RVA: 0x87AD3E8 Offset: 0x87A93E8 VA: 0x87AD3E8
	public void MoveGraphicalLineEnd() { }

	// RVA: 0x87AD524 Offset: 0x87A9524 VA: 0x87AD524
	public void MoveTextStart() { }

	// RVA: 0x87AD544 Offset: 0x87A9544 VA: 0x87AD544
	public void MoveTextEnd() { }

	// RVA: 0x87AD58C Offset: 0x87A958C VA: 0x87AD58C
	private int IndexOfEndOfLine(int startIndex) { }

	// RVA: 0x87AD5F0 Offset: 0x87A95F0 VA: 0x87AD5F0
	public void MoveParagraphForward() { }

	// RVA: 0x87AD674 Offset: 0x87A9674 VA: 0x87AD674
	public void MoveParagraphBackward() { }

	// RVA: 0x87AD6F4 Offset: 0x87A96F4 VA: 0x87AD6F4
	public void MoveCursorToPosition(Vector2 cursorPosition) { }

	// RVA: 0x87AD73C Offset: 0x87A973C VA: 0x87AD73C
	protected internal void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) { }

	// RVA: 0x87AD7C0 Offset: 0x87A97C0 VA: 0x87AD7C0
	public void SelectToPosition(Vector2 cursorPosition) { }

	// RVA: 0x87ADB80 Offset: 0x87A9B80 VA: 0x87ADB80
	public void SelectLeft() { }

	// RVA: 0x87ADBD8 Offset: 0x87A9BD8 VA: 0x87ADBD8
	public void SelectRight() { }

	// RVA: 0x87ADC30 Offset: 0x87A9C30 VA: 0x87ADC30
	public void SelectUp() { }

	// RVA: 0x87ADC90 Offset: 0x87A9C90 VA: 0x87ADC90
	public void SelectDown() { }

	// RVA: 0x87ADD08 Offset: 0x87A9D08 VA: 0x87ADD08
	public void SelectTextEnd() { }

	// RVA: 0x87ADD38 Offset: 0x87A9D38 VA: 0x87ADD38
	public void SelectTextStart() { }

	// RVA: 0x87ADD40 Offset: 0x87A9D40 VA: 0x87ADD40
	public void MouseDragSelectsWholeWords(bool on) { }

	// RVA: 0x87ADD54 Offset: 0x87A9D54 VA: 0x87ADD54
	public void DblClickSnap(TextEditor.DblClickSnapping snapping) { }

	// RVA: 0x87AD300 Offset: 0x87A9300 VA: 0x87AD300
	private int GetGraphicalLineStart(int p) { }

	// RVA: 0x87AD428 Offset: 0x87A9428 VA: 0x87AD428
	private int GetGraphicalLineEnd(int p) { }

	// RVA: 0x87ADD5C Offset: 0x87A9D5C VA: 0x87ADD5C
	private int FindNextSeperator(int startPos) { }

	// RVA: 0x87ADEFC Offset: 0x87A9EFC VA: 0x87ADEFC
	private int FindPrevSeperator(int startPos) { }

	// RVA: 0x87ADF98 Offset: 0x87A9F98 VA: 0x87ADF98
	public void MoveWordRight() { }

	// RVA: 0x87ADFF4 Offset: 0x87A9FF4 VA: 0x87ADFF4
	public void MoveToStartOfNextWord() { }

	// RVA: 0x87AE054 Offset: 0x87AA054 VA: 0x87AE054
	public void MoveToEndOfPreviousWord() { }

	// RVA: 0x87AE0B4 Offset: 0x87AA0B4 VA: 0x87AE0B4
	public void SelectToStartOfNextWord() { }

	// RVA: 0x87AE0E0 Offset: 0x87AA0E0 VA: 0x87AE0E0
	public void SelectToEndOfPreviousWord() { }

	// RVA: 0x87ADDF4 Offset: 0x87A9DF4 VA: 0x87ADDF4
	private TextEditor.CharacterType ClassifyChar(int index) { }

	// RVA: 0x87AC944 Offset: 0x87A8944 VA: 0x87AC944
	public int FindStartOfNextWord(int p) { }

	// RVA: 0x87AC7CC Offset: 0x87A87CC VA: 0x87AC7CC
	private int FindEndOfPreviousWord(int p) { }

	// RVA: 0x87AE10C Offset: 0x87AA10C VA: 0x87AE10C
	public void MoveWordLeft() { }

	// RVA: 0x87AE14C Offset: 0x87AA14C VA: 0x87AE14C
	public void SelectWordRight() { }

	// RVA: 0x87AE1B4 Offset: 0x87AA1B4 VA: 0x87AE1B4
	public void SelectWordLeft() { }

	// RVA: 0x87AE21C Offset: 0x87AA21C VA: 0x87AE21C
	public void ExpandSelectGraphicalLineStart() { }

	// RVA: 0x87AE280 Offset: 0x87AA280 VA: 0x87AE280
	public void ExpandSelectGraphicalLineEnd() { }

	// RVA: 0x87AE2E4 Offset: 0x87AA2E4 VA: 0x87AE2E4
	public void SelectGraphicalLineStart() { }

	// RVA: 0x87AE310 Offset: 0x87AA310 VA: 0x87AE310
	public void SelectGraphicalLineEnd() { }

	// RVA: 0x87AE33C Offset: 0x87AA33C VA: 0x87AE33C
	public void SelectParagraphForward() { }

	// RVA: 0x87AE3C8 Offset: 0x87AA3C8 VA: 0x87AE3C8
	public void SelectParagraphBackward() { }

	// RVA: 0x87AE478 Offset: 0x87AA478 VA: 0x87AE478
	public void SelectCurrentWord() { }

	// RVA: 0x87ADA04 Offset: 0x87A9A04 VA: 0x87ADA04
	private int FindEndOfClassification(int p, TextEditor.Direction dir) { }

	// RVA: 0x87AE4E4 Offset: 0x87AA4E4 VA: 0x87AE4E4
	public void SelectCurrentParagraph() { }

	// RVA: 0x87AE57C Offset: 0x87AA57C VA: 0x87AE57C
	public void UpdateScrollOffsetIfNeeded(Event evt) { }

	[VisibleToOtherModules]
	// RVA: 0x87AAF84 Offset: 0x87A6F84 VA: 0x87AAF84
	internal void UpdateScrollOffset() { }

	// RVA: 0x87AE5D8 Offset: 0x87AA5D8 VA: 0x87AE5D8
	public void DrawCursor(string newText) { }

	// RVA: 0x87AC0C4 Offset: 0x87A80C4 VA: 0x87AC0C4
	private bool PerformOperation(TextEditor.TextEditOp operation, bool textIsReadOnly) { }

	// RVA: 0x87AEB6C Offset: 0x87AAB6C VA: 0x87AEB6C
	public void SaveBackup() { }

	// RVA: 0x87AE9B4 Offset: 0x87AA9B4 VA: 0x87AE9B4
	public bool Cut() { }

	// RVA: 0x87AE9E0 Offset: 0x87AA9E0 VA: 0x87AE9E0
	public void Copy() { }

	// RVA: 0x87AEBA8 Offset: 0x87AABA8 VA: 0x87AEBA8
	private static string ReplaceNewlinesWithSpaces(string value) { }

	// RVA: 0x87AEAA8 Offset: 0x87AAAA8 VA: 0x87AEAA8
	public bool Paste() { }

	// RVA: 0x87AEC3C Offset: 0x87AAC3C VA: 0x87AEC3C
	private static void MapKey(string key, TextEditor.TextEditOp action) { }

	// RVA: 0x87AB694 Offset: 0x87A7694 VA: 0x87AB694
	private void InitKeyActions() { }

	// RVA: 0x87ACFC0 Offset: 0x87A8FC0 VA: 0x87ACFC0
	public void DetectFocusChange() { }

	// RVA: 0x87AECCC Offset: 0x87AACCC VA: 0x87AECCC Slot: 5
	internal virtual void OnDetectFocusChange() { }

	// RVA: 0x87AED74 Offset: 0x87AAD74 VA: 0x87AED74 Slot: 6
	internal virtual void OnCursorIndexChange() { }

	// RVA: 0x87AED78 Offset: 0x87AAD78 VA: 0x87AED78 Slot: 7
	internal virtual void OnSelectIndexChange() { }

	// RVA: 0x87AED7C Offset: 0x87AAD7C VA: 0x87AED7C
	private void ClampTextIndex(ref int index) { }

	// RVA: 0x87AAE78 Offset: 0x87A6E78 VA: 0x87AAE78
	private void EnsureValidCodePointIndex(ref int index) { }

	// RVA: 0x87AEDC8 Offset: 0x87AADC8 VA: 0x87AEDC8
	private bool IsValidCodePointIndex(int index) { }

	// RVA: 0x87ACD6C Offset: 0x87A8D6C VA: 0x87ACD6C
	private int PreviousCodePointIndex(int index) { }

	// RVA: 0x87ACBCC Offset: 0x87A8BCC VA: 0x87ACBCC
	private int NextCodePointIndex(int index) { }
}

// Namespace: 
private enum TextSelectingUtilities.CharacterType // TypeDefIndex: 24609
{
	// Fields
	public int value__; // 0x0
	public const TextSelectingUtilities.CharacterType LetterLike = 0;
	public const TextSelectingUtilities.CharacterType Symbol = 1;
	public const TextSelectingUtilities.CharacterType Symbol2 = 2;
	public const TextSelectingUtilities.CharacterType WhiteSpace = 3;
	public const TextSelectingUtilities.CharacterType NewLine = 4;
}

// Namespace: 
private enum TextSelectingUtilities.Direction // TypeDefIndex: 24610
{
	// Fields
	public int value__; // 0x0
	public const TextSelectingUtilities.Direction Forward = 0;
	public const TextSelectingUtilities.Direction Backward = 1;
}

// Namespace: UnityEngine
internal class TextSelectingUtilities // TypeDefIndex: 24611
{
	// Fields
	public TextEditor.DblClickSnapping dblClickSnap; // 0x10
	public int iAltCursorPos; // 0x14
	public bool hasHorizontalCursorPos; // 0x18
	private bool m_bJustSelected; // 0x19
	private bool m_MouseDragSelectsWholeWords; // 0x1A
	private int m_DblClickInitPosStart; // 0x1C
	private int m_DblClickInitPosEnd; // 0x20
	private TextHandle m_TextHandle; // 0x28
	private const int kMoveDownHeight = 5;
	private const char kNewLineChar = '\xa';
	private bool m_RevealCursor; // 0x30
	private int m_CursorIndex; // 0x34
	internal int m_SelectIndex; // 0x38
	private static Dictionary<Event, TextSelectOp> s_KeySelectOps; // 0x0
	internal Action OnCursorIndexChange; // 0x40
	internal Action OnSelectIndexChange; // 0x48
	internal Action OnRevealCursorChange; // 0x50

	// Properties
	public bool hasSelection { get; }
	public bool revealCursor { get; set; }
	private int m_CharacterCount { get; }
	private int characterCount { get; }
	private TextElementInfo[] m_TextElementInfos { get; }
	public int cursorIndex { get; set; }
	public int selectIndex { get; set; }
	public string selectedText { get; }

	// Methods

	// RVA: 0x87AEEB4 Offset: 0x87AAEB4 VA: 0x87AEEB4
	public bool get_hasSelection() { }

	// RVA: 0x87AEEFC Offset: 0x87AAEFC VA: 0x87AEEFC
	public bool get_revealCursor() { }

	// RVA: 0x87AEF04 Offset: 0x87AAF04 VA: 0x87AEF04
	public void set_revealCursor(bool value) { }

	// RVA: 0x87AEF34 Offset: 0x87AAF34 VA: 0x87AEF34
	private int get_m_CharacterCount() { }

	// RVA: 0x87AEF5C Offset: 0x87AAF5C VA: 0x87AEF5C
	private int get_characterCount() { }

	// RVA: 0x87AEFF0 Offset: 0x87AAFF0 VA: 0x87AEFF0
	private TextElementInfo[] get_m_TextElementInfos() { }

	// RVA: 0x87AEEEC Offset: 0x87AAEEC VA: 0x87AEEEC
	public int get_cursorIndex() { }

	// RVA: 0x87AF070 Offset: 0x87AB070 VA: 0x87AF070
	public void set_cursorIndex(int value) { }

	// RVA: 0x87AF09C Offset: 0x87AB09C VA: 0x87AF09C
	internal void SetCursorIndexWithoutNotify(int index) { }

	// RVA: 0x87AEEF4 Offset: 0x87AAEF4 VA: 0x87AEEF4
	public int get_selectIndex() { }

	// RVA: 0x87AF0A4 Offset: 0x87AB0A4 VA: 0x87AF0A4
	public void set_selectIndex(int value) { }

	// RVA: 0x87AF0D0 Offset: 0x87AB0D0 VA: 0x87AF0D0
	internal void SetSelectIndexWithoutNotify(int index) { }

	// RVA: 0x87AF0D8 Offset: 0x87AB0D8 VA: 0x87AF0D8
	public string get_selectedText() { }

	// RVA: 0x87AF1E8 Offset: 0x87AB1E8 VA: 0x87AF1E8
	public void .ctor(TextHandle textHandle) { }

	// RVA: 0x87AF238 Offset: 0x87AB238 VA: 0x87AF238
	internal bool HandleKeyEvent(Event e) { }

	// RVA: 0x87AF758 Offset: 0x87AB758 VA: 0x87AF758
	private bool PerformOperation(TextSelectOp operation) { }

	// RVA: 0x87B05F0 Offset: 0x87AC5F0 VA: 0x87B05F0
	private static void MapKey(string key, TextSelectOp action) { }

	// RVA: 0x87AF344 Offset: 0x87AB344 VA: 0x87AF344
	private void InitKeyActions() { }

	// RVA: 0x87B0680 Offset: 0x87AC680 VA: 0x87B0680
	public void ClearCursorPos() { }

	// RVA: 0x87B0690 Offset: 0x87AC690 VA: 0x87B0690
	public void OnFocus(bool selectAll = True) { }

	// RVA: 0x87B0538 Offset: 0x87AC538 VA: 0x87B0538
	public void SelectAll() { }

	// RVA: 0x87B05A4 Offset: 0x87AC5A4 VA: 0x87B05A4
	public void SelectNone() { }

	// RVA: 0x87AF948 Offset: 0x87AB948 VA: 0x87AF948
	public void SelectLeft() { }

	// RVA: 0x87AFA44 Offset: 0x87ABA44 VA: 0x87AFA44
	public void SelectRight() { }

	// RVA: 0x87AFB40 Offset: 0x87ABB40 VA: 0x87AFB40
	public void SelectUp() { }

	// RVA: 0x87AFBAC Offset: 0x87ABBAC VA: 0x87AFBAC
	public void SelectDown() { }

	// RVA: 0x87AFF58 Offset: 0x87ABF58 VA: 0x87AFF58
	public void SelectTextEnd() { }

	// RVA: 0x87AFF30 Offset: 0x87ABF30 VA: 0x87AFF30
	public void SelectTextStart() { }

	// RVA: 0x87AFED4 Offset: 0x87ABED4 VA: 0x87AFED4
	public void SelectToStartOfNextWord() { }

	// RVA: 0x87AFE78 Offset: 0x87ABE78 VA: 0x87AFE78
	public void SelectToEndOfPreviousWord() { }

	// RVA: 0x87AFC18 Offset: 0x87ABC18 VA: 0x87AFC18
	public void SelectWordRight() { }

	// RVA: 0x87AFD48 Offset: 0x87ABD48 VA: 0x87AFD48
	public void SelectWordLeft() { }

	// RVA: 0x87B03E8 Offset: 0x87AC3E8 VA: 0x87B03E8
	public void SelectGraphicalLineStart() { }

	// RVA: 0x87B0444 Offset: 0x87AC444 VA: 0x87B0444
	public void SelectGraphicalLineEnd() { }

	// RVA: 0x87B0178 Offset: 0x87AC178 VA: 0x87B0178
	public void SelectParagraphForward() { }

	// RVA: 0x87B028C Offset: 0x87AC28C VA: 0x87B028C
	public void SelectParagraphBackward() { }

	// RVA: 0x87B0EBC Offset: 0x87ACEBC VA: 0x87B0EBC
	public void SelectCurrentWord() { }

	// RVA: 0x87B1110 Offset: 0x87AD110 VA: 0x87B1110
	public void SelectCurrentParagraph() { }

	// RVA: 0x87B1200 Offset: 0x87AD200 VA: 0x87B1200
	public void MoveRight() { }

	// RVA: 0x87B1314 Offset: 0x87AD314 VA: 0x87B1314
	public void MoveLeft() { }

	// RVA: 0x87B1420 Offset: 0x87AD420 VA: 0x87B1420
	public void MoveUp() { }

	// RVA: 0x87B1554 Offset: 0x87AD554 VA: 0x87B1554
	public void MoveDown() { }

	// RVA: 0x87B1694 Offset: 0x87AD694 VA: 0x87B1694
	public void MoveLineStart() { }

	// RVA: 0x87B17C8 Offset: 0x87AD7C8 VA: 0x87B17C8
	public void MoveLineEnd() { }

	// RVA: 0x87B1914 Offset: 0x87AD914 VA: 0x87B1914
	public void MoveGraphicalLineStart() { }

	// RVA: 0x87B19C8 Offset: 0x87AD9C8 VA: 0x87B19C8
	public void MoveGraphicalLineEnd() { }

	// RVA: 0x87B1A7C Offset: 0x87ADA7C VA: 0x87B1A7C
	public void MoveTextStart() { }

	// RVA: 0x87B1AD8 Offset: 0x87ADAD8 VA: 0x87B1AD8
	public void MoveTextEnd() { }

	// RVA: 0x87B1B50 Offset: 0x87ADB50 VA: 0x87B1B50
	public void MoveParagraphForward() { }

	// RVA: 0x87B1C5C Offset: 0x87ADC5C VA: 0x87B1C5C
	public void MoveParagraphBackward() { }

	// RVA: 0x87B0B34 Offset: 0x87ACB34 VA: 0x87B0B34
	public void MoveWordRight() { }

	// RVA: 0x87B1E30 Offset: 0x87ADE30 VA: 0x87B1E30
	public void MoveToStartOfNextWord() { }

	// RVA: 0x87B1EF8 Offset: 0x87ADEF8 VA: 0x87B1EF8
	public void MoveToEndOfPreviousWord() { }

	// RVA: 0x87B0C24 Offset: 0x87ACC24 VA: 0x87B0C24
	public void MoveWordLeft() { }

	// RVA: 0x87B205C Offset: 0x87AE05C VA: 0x87B205C
	public void MouseDragSelectsWholeWords(bool on) { }

	// RVA: 0x87AFF98 Offset: 0x87ABF98 VA: 0x87AFF98
	public void ExpandSelectGraphicalLineStart() { }

	// RVA: 0x87B0088 Offset: 0x87AC088 VA: 0x87B0088
	public void ExpandSelectGraphicalLineEnd() { }

	// RVA: 0x87B20F4 Offset: 0x87AE0F4 VA: 0x87B20F4
	public void DblClickSnap(TextEditor.DblClickSnapping snapping) { }

	// RVA: 0x87B20FC Offset: 0x87AE0FC VA: 0x87B20FC
	protected internal void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) { }

	// RVA: 0x87B2198 Offset: 0x87AE198 VA: 0x87B2198
	public void SelectToPosition(Vector2 cursorPosition) { }

	// RVA: 0x87B1DAC Offset: 0x87ADDAC VA: 0x87B1DAC
	private int FindNextSeperator(int startPos) { }

	// RVA: 0x87B1FC0 Offset: 0x87ADFC0 VA: 0x87B1FC0
	private int FindPrevSeperator(int startPos) { }

	// RVA: 0x87B0894 Offset: 0x87AC894 VA: 0x87B0894
	public int FindStartOfNextWord(int p) { }

	// RVA: 0x87B0A58 Offset: 0x87ACA58 VA: 0x87B0A58
	public int FindEndOfPreviousWord(int p) { }

	// RVA: 0x87B0FCC Offset: 0x87ACFCC VA: 0x87B0FCC
	private int FindEndOfClassification(int p, TextSelectingUtilities.Direction dir) { }

	// RVA: 0x87B25B0 Offset: 0x87AE5B0 VA: 0x87B25B0
	private int ClampTextIndex(int index) { }

	// RVA: 0x87AF018 Offset: 0x87AB018 VA: 0x87AF018
	internal int EnsureValidCodePointIndex(int index) { }

	// RVA: 0x87B25D4 Offset: 0x87AE5D4 VA: 0x87B25D4
	private bool IsValidCodePointIndex(int index) { }

	// RVA: 0x87B0E7C Offset: 0x87ACE7C VA: 0x87B0E7C
	private int IndexOfEndOfLine(int startIndex) { }

	// RVA: 0x87B06DC Offset: 0x87AC6DC VA: 0x87B06DC
	public int PreviousCodePointIndex(int index) { }

	// RVA: 0x87B07B4 Offset: 0x87AC7B4 VA: 0x87B07B4
	public int NextCodePointIndex(int index) { }

	// RVA: 0x87B0D1C Offset: 0x87ACD1C VA: 0x87B0D1C
	private int GetGraphicalLineStart(int p) { }

	// RVA: 0x87B0DC8 Offset: 0x87ACDC8 VA: 0x87B0DC8
	private int GetGraphicalLineEnd(int p) { }

	// RVA: 0x87B04A0 Offset: 0x87AC4A0 VA: 0x87B04A0
	public void Copy() { }

	// RVA: 0x87B24A4 Offset: 0x87AE4A4 VA: 0x87B24A4
	private TextSelectingUtilities.CharacterType ClassifyChar(int index) { }
}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 24612
{
	// Methods

	// RVA: 0x87B26A4 Offset: 0x87AE6A4 VA: 0x87B26A4
	internal static uint ComputeStringHash(string s) { }
}

